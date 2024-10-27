using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using TravelTour.Controller;
using TravelTour.Model;

namespace TravelTour.View
{
    public partial class Infor : Form
    {
        private InforController inforController;
        private UserAccountModel currentUser;
        private string connectionString = "your_connection_string";
        private bool imageDisposed = false;

        public Infor(UserAccountModel user)
        {
            InitializeComponent();
            currentUser = user;
            inforController = new InforController(connectionString);
            LoadComboBox();
            LoadUserInfor();
        }

        private void LoadComboBox()
        {
            comboSex.Items.Clear();
            comboSex.Items.Add("Nam");
            comboSex.Items.Add("Nữ");
        }

        private void LoadUserInfor()
        {
            var userInfo = inforController.Read(currentUser.ID) as InforModel;
            if (userInfo != null)
            {
                txtName.Text = userInfo.Name;
                datePick.Value = userInfo.Date;
                txtLoca.Text = userInfo.Location;
                comboSex.SelectedItem = userInfo.Sex;
                txtAge.Text = userInfo.Age.ToString();

                string imagePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\Image");
                if (!string.IsNullOrEmpty(userInfo.ImageUrl))
                {
                    picAccount.Image = Image.FromFile(Path.Combine(imagePath, userInfo.ImageUrl));
                }
            }
        }

        private void butSave_Click(object sender, EventArgs e)
        {
            var userInfo = inforController.Read(currentUser.ID) as InforModel;
            if (inforController.IsExist(currentUser.ID))
            {
                // Cập nhật thông tin người dùng
                InforModel updatedInfor = new InforModel
                {
                    ID = currentUser.ID,
                    Name = txtName.Text,
                    Date = datePick.Value,
                    Location = txtLoca.Text,
                    Sex = comboSex.SelectedItem.ToString(),
                    Age = int.Parse(txtAge.Text)
                };

                // Kiểm tra xem người dùng đã ấn nút Dispose hay chưa
                if (imageDisposed && picAccount.Image == null)
                {
                    updatedInfor.ImageUrl = userInfo.ImageUrl;
                }
                else if (!imageDisposed)
                {
                    updatedInfor.ImageUrl = SaveImage();
                }

                bool isUpdated = inforController.Update(updatedInfor);
                if (isUpdated)
                {
                    MessageBox.Show("Thông tin đã được cập nhật thành công.");
                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại.");
                }
            }
            else
            {
                // Tạo mới thông tin người dùng
                InforModel newInfor = new InforModel
                {
                    ID = currentUser.ID,
                    Name = txtName.Text,
                    Date = datePick.Value,
                    Location = txtLoca.Text,
                    Sex = comboSex.SelectedItem.ToString(),
                    Age = int.Parse(txtAge.Text)
                };

                if (imageDisposed && picAccount.Image == null)
                {
                    newInfor.ImageUrl = userInfo.ImageUrl;
                }
                else if (!imageDisposed)
                {
                    newInfor.ImageUrl = SaveImage();
                }

                bool isCreated = inforController.Create(newInfor);
                if (isCreated)
                {
                    MessageBox.Show("Thông tin đã được lưu thành công.");
                }
                else
                {
                    MessageBox.Show("Lưu thông tin thất bại.");
                }
            }
        }



        private string SaveImage()
        {
            // Nếu hình ảnh đã bị giải phóng thì trả về null
            if (imageDisposed)
            {
                return null;
            }

            // Lưu ảnh vào thư mục
            string imagePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\Image");
            string imageFileName = $"{currentUser.ID}_profile.png";
            string fullPath = Path.Combine(imagePath, imageFileName);

            if (picAccount.Image != null)
            {
                picAccount.Image.Save(fullPath);
                return imageFileName;
            }

            return null;
        }

        private void butDispose_Click(object sender, EventArgs e)
        {
            if (picAccount.Image != null)
            {
                // Giải phóng ảnh
                picAccount.Image.Dispose();
                picAccount.Image = null;
                imageDisposed = true;
                MessageBox.Show("Hình ảnh đã được giải phóng.");
            }
        }

        private void picAccount_Click(object sender, EventArgs e)
        {
            if (imageDisposed || picAccount.Image == null) // Kiểm tra nếu hình ảnh đã bị giải phóng
            {
                OpenFileDialog openFileDialog = new OpenFileDialog
                {
                    Filter = "Image Files|*.jpg;*.jpeg;*.png;"
                };
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    picAccount.Image = Image.FromFile(openFileDialog.FileName);
                    imageDisposed = false;
                }
            }
            else
            {
                MessageBox.Show("Bạn cần giải phóng hình ảnh trước khi chọn ảnh mới.");
            }
        }

        private void butBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Homepage home = new Homepage(currentUser);
            home.ShowDialog();
            this.Close();
        }
    }
}
