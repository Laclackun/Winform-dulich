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
        }

        private void butReg_Click(object sender, EventArgs e)
        {
            this.Hide();
            Register reg = new Register();
            reg.ShowDialog();
            this.Close();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            // Vô hiệu hóa nút Login khi form được tải
            butLog.Enabled = false;
        }

        private void EnableLoginButton()
        {
            // Kích hoạt nút Login chỉ khi cả tên đăng nhập và mật khẩu không rỗng
            butLog.Enabled = !string.IsNullOrEmpty(txtName.Text) && !string.IsNullOrEmpty(txtPass.Text);
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            // Gọi hàm kiểm tra trạng thái của nút Login
            EnableLoginButton();
        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {
            // Gọi hàm kiểm tra trạng thái của nút Login
            EnableLoginButton();
        }

        private void butLog_Click(object sender, EventArgs e)
        {
            string username = txtName.Text;
            string password = txtPass.Text;

            // Tạo đối tượng của UserAccountController
            string connectionString = "Data Source=PCTRAN;Initial Catalog=dulich;Integrated Security=True";
            UserAccountController userAccountController = new UserAccountController(connectionString);

            // Kiểm tra đăng nhập
            bool isValidLogin = userAccountController.ValidateLogin(username, password);

            if (isValidLogin)
            {
                MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Lưu thông tin người dùng đã đăng nhập
                LoggedInUser = userAccountController.GetUserByUsername(username);

                // Chuyển đến trang homepage sau khi đăng nhập thành công
                this.DialogResult = DialogResult.OK; // Đặt kết quả Dialog
                this.Close(); // Đóng form đăng nhập
            }
            else
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void checkShow_CheckedChanged(object sender, EventArgs e)
        {
            // Hiển thị hoặc ẩn mật khẩu khi người dùng chọn checkbox "Show Password"
            txtPass.PasswordChar = checkShow.Checked ? '\0' : '*';
        }

        private void linkForgot_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Hiển thị thông báo khi người dùng nhấn "Forgot Password"
            MessageBox.Show("Chức năng quên mật khẩu sẽ được triển khai sau.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}