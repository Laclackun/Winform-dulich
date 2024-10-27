using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TravelTour.Controller;
using TravelTour.Model;
using TravelTour.Utils;
using TravelTour.Controller;

namespace TravelTour.View
{
    public partial class StaffAccount : Form
    {
        private UserAccountModel currentUser;

        public StaffAccount()
        {
            InitializeComponent();
            LoadData();
        }

        public StaffAccount(UserAccountModel user)
        {
            InitializeComponent();
            currentUser = user;
            LoadData();
        }

        private void LoadData()
        {
            UserAccountController userAccountController = new UserAccountController("your_connection_string");
            DataTable dt = userAccountController.LoadAll();

            // Lọc các tài khoản có role là "Staff" và "Manager"
            DataView view = new DataView(dt);
            view.RowFilter = "role = 'Staff' OR role = 'Manager'";
            dataGridView.DataSource = view;
        }

        private void StaffAccount_Load(object sender, EventArgs e)
        {
            txtID.ReadOnly = true; // Chỉ cho phép xem, không cho phép chỉnh sửa
        }

        private void butBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Homepage home = new Homepage(currentUser);
            home.ShowDialog();
            this.Close();
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Đảm bảo là dòng hợp lệ
            {
                DataGridViewRow row = dataGridView.Rows[e.RowIndex];
                txtID.Text = row.Cells["ID"].Value.ToString();
                txtName.Text = row.Cells["username"].Value.ToString();
                txtPass.Text = row.Cells["password"].Value.ToString();
                string role = row.Cells["role"].Value.ToString();
                if (role == "Manager")
                {
                    raManager.Checked = true;
                }
                else if (role == "Staff")
                {
                    raStaff.Checked = true;
                }
            }
        }


        private void butSave_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy dữ liệu từ giao diện
                string employeeName = txtName.Text;
                string password = txtPass.Text;
                string role = raManager.Checked ? "Manager" : "Staff";

                // Tạo đối tượng UserAccountModel
                UserAccountModel userAccount = new UserAccountModel
                {
                    Username = employeeName,
                    Password = password,
                    Role = role
                };

                UserAccountController controller = new UserAccountController("your_connection_string");

                // Nếu txtID trống, thêm mới
                if (string.IsNullOrEmpty(txtID.Text))
                {
                    bool success = controller.Create(userAccount);
                    if (success)
                    {
                        MessageBox.Show("Thêm tài khoản thành công!");
                    }
                    else
                    {
                        MessageBox.Show("Không thể thêm tài khoản.");
                    }
                }
                else
                {
                    // Nếu có ID, cập nhật tài khoản
                    userAccount.ID = int.Parse(txtID.Text);
                    bool success = controller.Update(userAccount);
                    if (success)
                    {
                        MessageBox.Show("Cập nhật tài khoản thành công!");
                    }
                    else
                    {
                        MessageBox.Show("Không thể cập nhật tài khoản.");
                    }
                }

                // Tải lại dữ liệu
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}");
            }
        }



        private void butDel_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtID.Text))
            {
                UserAccountController controller = new UserAccountController("your_connection_string");
                int id = int.Parse(txtID.Text);
                bool success = controller.Delete(id);
                if (success)
                {
                    MessageBox.Show("Xóa tài khoản thành công.");
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Xóa thất bại.");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một tài khoản để xóa.");
            }
        }
    }
}

