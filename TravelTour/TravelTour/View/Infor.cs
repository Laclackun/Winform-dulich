using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
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

        public void SetDataToText(object item)
        {
            if (item is InforModel userInfo)
            {
                txtName.Text = userInfo.Name;
                datePick.Value = userInfo.Date;
                txtLoca.Text = userInfo.Location;
                comboSex.SelectedItem = userInfo.Sex;
                txtAge.Text = userInfo.Age.ToString();
                string imagePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Image", userInfo.ImageUrl);
                if (File.Exists(imagePath))
                {
                    picAccount.Image = Image.FromFile(imagePath);
                }
                else
                {
                    MessageBox.Show("Không tìm thấy file ảnh.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
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

                string imagePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Image", userInfo.ImageUrl);
                if (File.Exists(imagePath))
                {
                    picAccount.Image = Image.FromFile(imagePath);
                }
                else
                {
                    MessageBox.Show("Không tìm thấy file ảnh.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void butSave_Click(object sender, EventArgs e)
        {
            var userInfo = inforController.Read(currentUser.ID) as InforModel;
            if (inforController.IsExist(currentUser.ID))
            {
                InforModel updatedInfor = new InforModel
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
            if (imageDisposed)
            {
                return null;
            };

            string imagePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Image");
            string imageFileName = $"{currentUser.ID}_profile.png";
            string fullPath = Path.Combine(imagePath, imageFileName);

            if (!Directory.Exists(imagePath))
            {
                Directory.CreateDirectory(imagePath);
            }

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
                picAccount.Image.Dispose();
                picAccount.Image = null;
                imageDisposed = true;
                MessageBox.Show("Hình ảnh đã được giải phóng.");
            }
        }

        private void picAccount_Click(object sender, EventArgs e)
        {
            if (imageDisposed || picAccount.Image == null)
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
