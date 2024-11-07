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
            DataView view = new DataView(dt);
            view.RowFilter = "role = 'Staff' OR role = 'Manager'";
            dataGridView.DataSource = view;
        }

        public void SetDataToText(object item)
        {
            if (item is UserAccountModel userAccount)
            {
                txtID.Text = userAccount.ID.ToString();
                txtName.Text = userAccount.Username;
                txtPass.Text = userAccount.Password;
                
                if (userAccount.Role == "Manager")
                {
                    raManager.Checked = true;
                }
                else if (userAccount.Role == "Staff")
                {
                    raStaff.Checked = true;
                }
            }
        }
        
        public void GetDataFromText()
        {
            if (!string.IsNullOrEmpty(txtID.Text))
            {
                UserAccountModel updatedUserAccount = new UserAccountModel
                {
                    ID = int.Parse(txtID.Text),
                    Username = txtName.Text,
                    Password = txtPass.Text,
                    Role = raManager.Checked ? "Manager" : "Staff"
                };
            }
        }


        private void StaffAccount_Load(object sender, EventArgs e)
        {
            txtID.ReadOnly = true;
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
                string employeeName = txtName.Text;
                string password = txtPass.Text;
                string role = raManager.Checked ? "Manager" : "Staff";
                UserAccountModel userAccount = new UserAccountModel
                {
                    Username = employeeName,
                    Password = password,
                    Role = role
                };

                UserAccountController controller = new UserAccountController("your_connection_string");
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

