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
        public AccountManager()
        {
            InitializeComponent();
            LoadData();
        }

        public AccountManager(UserAccountModel user)
        {
            InitializeComponent();
            currentUser = user;
            LoadData();
        }


        private void LoadData()
        {
            UserAccountController userAccountController = new UserAccountController("your_connection_string");
            DataTable dt = userAccountController.LoadAll();

            // Lọc các tài khoản có role là "Customer"
            DataView view = new DataView(dt);
            view.RowFilter = "role = 'Customer'";
            dataGridView.DataSource = view;
        }

        private void AccountManager_Load(object sender, EventArgs e)
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
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView.Rows[e.RowIndex];
                txtID.Text = row.Cells["ID"].Value.ToString();
                txtName.Text = row.Cells["username"].Value.ToString();
                txtPass.Text = row.Cells["password"].Value.ToString();
            }
        }


        private void butSave_Click(object sender, EventArgs e)
        {
            UserAccountController userAccountController = new UserAccountController("your_connection_string");

            if (string.IsNullOrEmpty(txtName.Text) || string.IsNullOrEmpty(txtPass.Text))
            {
                MessageBox.Show("Username và Password không được để trống.");
                return;
            }

            UserAccountModel model = new UserAccountModel
            {
                Username = txtName.Text,
                Password = txtPass.Text,
                Role = "Customer" // Luôn là role "Customer" khi thêm mới
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
            else // Cập nhật
            {
                model.ID = int.Parse(txtID.Text); // Lấy ID hiện tại để cập nhật
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
