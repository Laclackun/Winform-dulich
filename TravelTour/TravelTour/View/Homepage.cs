using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TravelTour.View;
using TravelTour.Model;
using Microsoft.VisualBasic.ApplicationServices;
using TravelTour.Controller;
using System.Xml.Linq;
using System.Data.SqlClient;
using TravelTour.Utils;

namespace TravelTour
{
    public partial class Homepage : Form
    {
        private UserAccountModel currentUser;
        private TravelController travelController = new TravelController("your_connection_string");
        public Homepage()
        {
            InitializeComponent();
            HideAllMenuItems();
            LoadAll();
        }
        public Homepage(UserAccountModel user)
        {
            InitializeComponent();
            HideAllMenuItems();
            DisplayMenuByRole(user);
            LoadAll();
        }

        private void LoadAll()
        {
            dataGridView.DataSource = travelController.LoadAll();
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        // Phương thức ẩn tất cả các ToolStripMenuItem
        private void HideAllMenuItems()
        {
            orderToolStripMenuItem.Visible = false;
            tourManagerToolStripMenuItem.Visible = false;
            accountManagerToolStripMenuItem.Visible = false;
            inforAccountToolStripMenuItem.Visible = false;
            logoutToolStripMenuItem.Visible = false;
            staffManagerToolStripMenuItem.Visible = false;
        }

        public void DisplayMenuByRole(UserAccountModel user)
        {
            currentUser = user;

            // Ẩn tất cả các ToolStripMenuItem trước
            inforAccountToolStripMenuItem.Visible = true;
            orderToolStripMenuItem.Visible = true; // Tất cả roles đều xem được thông tin tài khoản và đặt tour

            // Hiển thị menu dựa trên role
            if (currentUser != null)
            {
                switch (currentUser.Role)
                {
                    case "Staff":
                        tourManagerToolStripMenuItem.Visible = true;
                        accountManagerToolStripMenuItem.Visible = true;
                        break;
                    case "Manager":
                        tourManagerToolStripMenuItem.Visible = true;
                        staffManagerToolStripMenuItem.Visible = true;
                        accountManagerToolStripMenuItem.Visible = true;
                        break;
                }
                // Hiển thị nút Logout
                logoutToolStripMenuItem.Visible = true;
                // Ẩn nút Login khi đã đăng nhập
                loginToolStripMenuItem1.Visible = false;
            }
            else
            {
                // Hiển thị nút Login nếu chưa đăng nhập
                loginToolStripMenuItem1.Visible = true;
            }
        }


        private void loginToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide(); // Ẩn form hiện tại
            Login loginForm = new Login();
            if (loginForm.ShowDialog() == DialogResult.OK)
            {
                // Lấy thông tin người dùng sau khi login
                UserAccountModel currentUser = loginForm.LoggedInUser; // Thay đổi tên biến cho rõ ràng
                DisplayMenuByRole(currentUser); // Truyền currentUser vào hàm này
            }

            this.Show(); // Hiển thị lại form Homepage sau khi đăng nhập hoặc hủy đăng nhập
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Ẩn nút Logout và hiển thị nút Login lại
            logoutToolStripMenuItem.Visible = false;
            loginToolStripMenuItem1.Visible = true;

            // Xóa thông tin người dùng hiện tại
            currentUser = null;

            // Hiển thị lại form Homepage
            this.Hide();
            Homepage home = new Homepage();
            home.ShowDialog();
            this.Close();
        }


        private void registerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Register sig = new Register();
            sig.ShowDialog();
            this.Close();
        }

        private void tourManagerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            TourManager tm = new TourManager(currentUser);
            tm.ShowDialog();
            this.Close();
        }

        private void orderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Order od = new Order(currentUser);
            od.ShowDialog();
            this.Close();
        }

        private void inforAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Infor ir = new Infor(currentUser);
            ir.ShowDialog();
            this.Close();
        }

        private void accountManagerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            AccountManager am = new AccountManager(currentUser);
            am.ShowDialog();
            this.Close();
        }

        private void staffManagerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            StaffAccount st = new StaffAccount(currentUser);
            st.ShowDialog();
            this.Close();
        }

        private void hướngDẫnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Guide gu = new Guide(currentUser);
            gu.ShowDialog();
            this.Close();
        }

        private void butSreach_Click(object sender, EventArgs e)
        {
            string searchText = txtSreach.Text.Trim();

            if (!string.IsNullOrEmpty(searchText))
            {
                // Tìm kiếm theo bất kỳ cột nào chứa từ khóa
                string query = @"
            SELECT * FROM travel 
            WHERE Nametv LIKE @searchText 
               OR description LIKE @searchText 
               OR location LIKE @searchText 
               OR typetv LIKE @searchText";

                using (DatabaseHelper dbHelper = new DatabaseHelper("your_connection_string"))
                {
                    SqlParameter[] parameters = new SqlParameter[]
                    {
                new SqlParameter("@searchText", $"%{searchText}%")
                    };

                    DataTable searchResult = dbHelper.ExecuteQuery(query, parameters);
                    dataGridView.DataSource = searchResult;
                }
            }
            else
            {
                // Nếu không có nội dung tìm kiếm, tải lại toàn bộ dữ liệu
                LoadAll();
            }
        }


        private void butDetail_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                int selectedIDtravel = Convert.ToInt32(dataGridView.SelectedRows[0].Cells["IDtv"].Value);
                TourDetail tourDetailForm = new TourDetail(currentUser, selectedIDtravel);
                this.Hide();
                tourDetailForm.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng để xem chi tiết.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }



        private void butClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (Form.ModifierKeys == Keys.None && keyData == Keys.Escape)
            {
                DialogResult result = MessageBox.Show("Do you want to close ?",
                                                      "Close Winform",
                                                      MessageBoxButtons.YesNo,
                                                      MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    this.Close();
                }

                return true;
            }
            return base.ProcessDialogKey(keyData);
        }
    }
}
