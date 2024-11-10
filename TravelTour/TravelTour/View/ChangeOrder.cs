using System;
using System.Data;
using System.Windows.Forms;
using TravelTour.Model;
using TravelTour.Controller;

namespace TravelTour.View
{
    public partial class ChangeOrder : Form
    {
        private int orderId;
        private UserAccountModel currentUser;
        private TourController controller = new TourController("your_connection_string");

        public ChangeOrder(int orderId, UserAccountModel user)
        {
            InitializeComponent();
            this.orderId = orderId;
            this.currentUser = user;
            LoadOrderDetails();
        }

        public void SetDataToText(object item)
        {
            if (item is TourModel order)
            {
                txtIDOrder.Text = order.IDtour.ToString();
                txtIDAcc.Text = order.ID.ToString();
                txtIDTour.Text = order.IDtv.ToString();
                txtQuantity.Text = order.Quantity.ToString();
                datePick.Value = order.BookingDate;
            }
        }

        public void GetDataFromText()
        {
            if (currentUser != null)
            {
                currentUser.Username = txtIDAcc.Text;
                currentUser.Password = txtIDTour.Text;
            }
        }
        
        private void LoadOrderDetails()
        {
            TourModel order = controller.Read(orderId) as TourModel;
            if (order != null)
            {
                txtIDOrder.Text = order.IDtour.ToString();
                txtIDAcc.Text = order.ID.ToString();
                txtIDTour.Text = order.IDtv.ToString();
                txtQuantity.Text = order.Quantity.ToString();
                datePick.Value = order.BookingDate;
            }
        }

        private void butChange_Click(object sender, EventArgs e)
        {
            TourModel updatedOrder = new TourModel
            {
                IDtour = orderId,
                ID = int.Parse(txtIDAcc.Text),
                IDtv = int.Parse(txtIDTour.Text),
                BookingDate = datePick.Value,
                Quantity = int.Parse(txtQuantity.Text)
            };

            if (controller.Update(updatedOrder))
            {
                MessageBox.Show("Cập nhật thành công!");
                this.Close();
            }
        }

        private void butCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
