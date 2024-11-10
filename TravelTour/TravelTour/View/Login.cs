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
    public partial class Login : Form
    {
        public UserAccountModel LoggedInUser { get; private set; }
        public Login()
        {
            UserAccountController userAccountController = new UserAccountController("your_connection_string");
            InitializeComponent();
            txtPass.PasswordChar = '*';
        }

        public void SetDataToText(object item)
        {
            if (item is UserAccountModel userAccount)
            {
                txtName.Text = userAccount.Username;
                txtPass.Text = userAccount.Password;
            }
        }

        public void GetDataFromText()
        {
            if (LoggedInUser != null)
            {
                LoggedInUser.Username = txtName.Text;
                LoggedInUser.Password = txtPass.Text;
            }
        }

        private void butReg_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng quên mật khẩu sẽ được triển khai sau.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Login_Load(object sender, EventArgs e)
        {
            butLog.Enabled = false;
        }

        private void EnableLoginButton()
        {
            butLog.Enabled = !string.IsNullOrEmpty(txtName.Text) && !string.IsNullOrEmpty(txtPass.Text);
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            EnableLoginButton();
        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {
            EnableLoginButton();
        }

        private void butLog_Click(object sender, EventArgs e)
        {
            string username = txtName.Text;
            string password = txtPass.Text;
            string connectionString = "Data Source=PCTRAN;Initial Catalog=dulich;Integrated Security=True";
            UserAccountController userAccountController = new UserAccountController(connectionString);
            bool isValidLogin = userAccountController.ValidateLogin(username, password);

            if (isValidLogin)
            {
                MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoggedInUser = userAccountController.GetUserByUsername(username);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void checkShow_CheckedChanged(object sender, EventArgs e)
        {
            txtPass.PasswordChar = checkShow.Checked ? '\0' : '*';
        }

        private void linkForgot_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Chức năng quên mật khẩu sẽ được triển khai sau.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
