using System;
using System.Data;
using System.Windows.Forms;
using TravelTour.Model;
using TravelTour.Controller;

namespace TravelTour.View
{
    public partial class Order : Form
    {
        private UserAccountModel currentUser;
        private int selectedOrderId;

        public Order(UserAccountModel user)
        {
            InitializeComponent();
            currentUser = user;
            LoadAll();
            if (currentUser.Role == "Customer")
            {
                butChange.Enabled = false;
            }
        }

        private void LoadAll()
        {
            TourController controller = new TourController("your_connection_string");
            dataGridView.DataSource = controller.LoadAll();
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }


        private void butChange_Click(object sender, EventArgs e)
        {
            if (selectedOrderId > 0)
            {
                this.Hide();
                ChangeOrder changeOrderForm = new ChangeOrder(selectedOrderId, currentUser);
                changeOrderForm.ShowDialog();
                LoadAll();
                this.Show();
            }
            else { MessageBox.Show("Hãy chọn dòng để sửa"); }

        }

        private void butDetail_Click(object sender, EventArgs e)
        {
            if (selectedOrderId > 0)
            {
                DetailOrder detailOrderForm = new DetailOrder(selectedOrderId);
                this.Hide();
                detailOrderForm.ShowDialog();
                this.Show();
            }
            else { MessageBox.Show("Hãy chọn dòng để xem chi tiết"); }
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
                if (row.Cells["IDtour"].Value != null && int.TryParse(row.Cells["IDtour"].Value.ToString(), out int id))
                {
                    selectedOrderId = id;
                }
            }
        }
    }
}
