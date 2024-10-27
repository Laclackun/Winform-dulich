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

namespace TravelTour.View
{
    public partial class Register : Form
    {
        SqlConnection con = new SqlConnection("Data Source=PCTRAN;Initial Catalog=dulich;Integrated Security=True;Encrypt=False");
        public Register()
        {
            InitializeComponent();
        }

        private void butBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Homepage home = new Homepage();
            home.ShowDialog();
            this.Close();
        }


        private void butRegis_Click(object sender, EventArgs e)
        {
            string username = txtName.Text;
            string password = txtPass.Text;
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Vui lòng nhập tên đăng nhập và mật khẩu.");
                return;
            }

            RegisterUser(username, password);
        }

        private void RegisterUser(string username, string password)
        {
            try
            {
                con.Open();

                // Kiểm tra xem username đã tồn tại chưa
                string queryCheckUsername = "SELECT COUNT(*) FROM account WHERE username = @Username";
                SqlCommand cmdCheckUsername = new SqlCommand(queryCheckUsername, con);
                cmdCheckUsername.Parameters.AddWithValue("@Username", username);
                int userExists = (int)cmdCheckUsername.ExecuteScalar(); // Lấy số lượng username

                if (userExists > 0)
                {
                    MessageBox.Show("Tên đăng nhập đã tồn tại. Vui lòng chọn tên khác.");
                    return; // Dừng thực hiện nếu username đã tồn tại
                }

                // Thêm tài khoản vào bảng account
                string queryAccount = "INSERT INTO account (username, password, role) OUTPUT INSERTED.ID VALUES (@Username, @Password, 'Customer')";
                SqlCommand cmdAccount = new SqlCommand(queryAccount, con);
                cmdAccount.Parameters.AddWithValue("@Username", username);
                cmdAccount.Parameters.AddWithValue("@Password", password);

                // Sử dụng Convert.ToInt32 để chuyển đổi
                int accountId = Convert.ToInt32(cmdAccount.ExecuteScalar()); // Lấy ID của tài khoản vừa thêm

                // Thêm thông tin vào bảng infor
                string queryInfor = "INSERT INTO infor (ID) VALUES (@ID)";
                SqlCommand cmdInfor = new SqlCommand(queryInfor, con);
                cmdInfor.Parameters.AddWithValue("@ID", accountId);

                cmdInfor.ExecuteNonQuery();
                MessageBox.Show("Đăng ký thành công!");
                this.Hide();
                Homepage home = new Homepage(); // Chuyển đến giao diện chính
                home.ShowDialog();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void Register_Load(object sender, EventArgs e)
        {
            butRegis.Enabled = false;
        }

        private void EnableRegisterButton()
        {
            butRegis.Enabled = !string.IsNullOrEmpty(txtName.Text) && !string.IsNullOrEmpty(txtPass.Text);
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            EnableRegisterButton();
        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {
            EnableRegisterButton();
        }
    }
}
