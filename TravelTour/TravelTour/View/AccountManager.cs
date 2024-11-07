using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TravelTour.Controller;
using TravelTour.Model;

namespace TravelTour.View
{
    public partial class AccountManager : Form
    {
        private UserAccountModel currentUser;
        UserAccountController userAccountController = new UserAccountController("your_connection_string");
        
        public AccountManager(UserAccountModel user)
        {
            InitializeComponent();
            currentUser = user;
            LoadData();
        }
        public void SetDataToText(object item)
        {
            if (item is UserAccountModel user)
            {
                txtID.Text = user.ID.ToString();
                txtName.Text = user.Username;
                txtPass.Text = user.Password;
            }
        }

        public void GetDataFromText()
        {
            if (currentUser != null)
            {
                currentUser.Username = txtName.Text;
                currentUser.Password = txtPass.Text;
                if (int.TryParse(txtID.Text, out int id))
                {
                    currentUser.ID = id;
                }
            }
        }

        private void LoadData()
        {
            DataTable dt = userAccountController.LoadAll();
            DataView view = new DataView(dt);
            view.RowFilter = "role = 'Customer'";
            dataGridView.DataSource = view;
        }

        private void AccountManager_Load(object sender, EventArgs e)
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
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView.Rows[e.RowIndex];
                UserAccountModel selectedUser = new UserAccountModel
                {
                    ID = Convert.ToInt32(row.Cells["ID"].Value),
                    Username = row.Cells["username"].Value.ToString(),
                    Password = row.Cells["password"].Value.ToString(),
                    Role = row.Cells["role"].Value.ToString()
                };
        
                SetDataToText(selectedUser);
            }
        }

        private void butSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text) || string.IsNullOrEmpty(txtPass.Text))
            {
                MessageBox.Show("Username và Password không được để trống.");
                return;
            }

            UserAccountModel model = new UserAccountModel
            {
                Username = txtName.Text,
                Password = txtPass.Text,
                Role = "Customer"
            };

            if (string.IsNullOrEmpty(txtID.Text)) // Thêm mới
            {
                bool success = userAccountController.Create(model);
                if (success)
                {
                    MessageBox.Show("Thêm mới tài khoản thành công.");
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Thêm mới thất bại.");
                }
            }
            else
            {
                model.ID = int.Parse(txtID.Text);
                bool success = userAccountController.Update(model);
                if (success)
                {
                    MessageBox.Show("Cập nhật tài khoản thành công.");
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại.");
                }
            }
        }

        private void butDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                int id = int.Parse(txtID.Text); 
                UserAccountController userAccountController = new UserAccountController("your_connection_string");

                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa tài khoản này?", "Xóa", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    bool success = userAccountController.Delete(id);
                    if (success)
                    {
                        MessageBox.Show("Xóa tài khoản thành công.");
                        LoadData();
                    }
                    else
                    {
                        MessageBox.Show("Xóa tài khoản thất bại.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một tài khoản để xóa.");
            }
        }
    }
}
