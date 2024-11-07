using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using TravelTour.Controller;
using TravelTour.Model;

namespace TravelTour.View
{
    public partial class TourManager : Form
    {
        private UserAccountModel currentUser;
        private TravelModel model;
        private TravelController travelController = new TravelController("your_connection_string");
        private bool imageDisposed = false;

        public TourManager(UserAccountModel user)
        {
            InitializeComponent();
            currentUser = user;
            
            LoadAll();
            LoadComboBox();
        }

        private void LoadAll()
        {
            dataGridView.DataSource = travelController.LoadAll();
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void LoadComboBox()
        {
            comboType.Items.Clear();
            comboType.Items.Add("Du lịch biển");
            comboType.Items.Add("Du lịch văn hóa");
            comboType.Items.Add("Du lịch lịch sử");
        }

        public void SetDataToText(object item)
        {
            if (item is TravelModel travel)
            {
                txtIDTour.Text = travel.IDtv.ToString();
                txtName.Text = travel.Nametv;
                txtDesciption.Text = travel.Description;
                txtQuantity.Text = travel.Quantity.ToString();
                txtLocation.Text = travel.Location;
                comboType.SelectedItem = travel.TypeTv;
                datePickStart.Value = travel.DateStart;
                datePickEnd.Value = travel.DateEnd;
                string imagePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\Image", travel.ImageUrl);
                if (File.Exists(imagePath))
                {
                    picTravel.Image = Image.FromFile(imagePath);
                }
            }
        }
        
        public void GetDataFromText()
        {
            // Lấy dữ liệu từ các control và cập nhật vào TravelModel
            TravelModel updatedTravel = new TravelModel
            {
                IDtv = string.IsNullOrEmpty(txtIDTour.Text) ? 0 : int.Parse(txtIDTour.Text),
                Nametv = txtName.Text,
                Description = txtDesciption.Text,
                Quantity = int.Parse(txtQuantity.Text),
                Location = txtLocation.Text,
                TypeTv = comboType.SelectedItem.ToString(),
                DateStart = datePickStart.Value,
                DateEnd = datePickEnd.Value,
                ImageUrl = imageDisposed ? null : SaveImage()
            };
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView.Rows[e.RowIndex];
                txtIDTour.Text = row.Cells["IDtv"].Value.ToString();
                txtName.Text = row.Cells["Nametv"].Value.ToString();
                txtDesciption.Text = row.Cells["Description"].Value.ToString();
                txtQuantity.Text = row.Cells["Quantity"].Value.ToString();
                txtLocation.Text = row.Cells["Location"].Value.ToString();
                comboType.SelectedItem = row.Cells["TypeTv"].Value.ToString();
                datePickStart.Value = Convert.ToDateTime(row.Cells["DateStart"].Value);
                datePickEnd.Value = Convert.ToDateTime(row.Cells["DateEnd"].Value);

                string imagePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\Image", row.Cells["ImageUrl"].Value.ToString());
                if (File.Exists(imagePath))
                {
                    picTravel.Image = Image.FromFile(imagePath);
                }
            }
        }

        private void butSave_Click(object sender, EventArgs e)
        {
            var travel = new TravelModel
            {
                IDtv = string.IsNullOrEmpty(txtIDTour.Text) ? 0 : int.Parse(txtIDTour.Text),
                Nametv = txtName.Text,
                DateStart = datePickStart.Value,
                DateEnd = datePickEnd.Value,
                Description = txtDesciption.Text,
                Location = txtLocation.Text,
                TypeTv = comboType.SelectedItem.ToString(),
                Quantity = int.Parse(txtQuantity.Text),
            };
            if (imageDisposed && picTravel.Image == null)
            {
                var travelData = travelController.Read(travel.IDtv) as TravelModel;
                travel.ImageUrl = travelData?.ImageUrl;
            }
            else if (!imageDisposed)
            {
                travel.ImageUrl = SaveImage();
            }

            bool exists = travel.IDtv != 0 && travelController.Read(travel.IDtv) != null;

            if (!exists)
            {
                bool isCreated = travelController.Create(travel);
                MessageBox.Show(isCreated ? "Thêm thành công!" : "Thêm thất bại.");
            }
            else
            {
                bool isUpdated = travelController.Update(travel);
                MessageBox.Show(isUpdated ? "Cập nhật thành công!" : "Cập nhật thất bại.");
            }

            LoadAll();
        }


        private void butDispose_Click(object sender, EventArgs e)
        {
            if (picTravel.Image != null)
            {
                picTravel.Image.Dispose();
                picTravel.Image = null;
                imageDisposed = true;
                MessageBox.Show("Hình ảnh đã được giải phóng.");
            }
        }

        private void picTravel_Click(object sender, EventArgs e)
        {
            if (imageDisposed || picTravel.Image == null)
            {
                OpenFileDialog openFileDialog = new OpenFileDialog
                {
                    Filter = "Image Files|*.jpg;*.jpeg;*.png;"
                };
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    picTravel.Image = Image.FromFile(openFileDialog.FileName);
                    imageDisposed = false;
                }
            }
            else
            {
                MessageBox.Show("Bạn cần giải phóng hình ảnh trước khi chọn ảnh mới.");
            }
        }

        private string SaveImage()
        {
            if (imageDisposed) return null;

            string imagePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\Image");
            string imageFileName = $"{txtIDTour.Text}_tour.png";
            string fullPath = Path.Combine(imagePath, imageFileName);

            if (picTravel.Image != null)
            {
                picTravel.Image.Save(fullPath);
                return imageFileName;
            }
            return null;
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
