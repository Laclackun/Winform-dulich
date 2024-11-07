using System;
using System.Data;
using System.Windows.Forms;
using TravelTour.Model;
using TravelTour.Controller;
using System.Xml.Linq;

namespace TravelTour.View
{
    public partial class DetailOrder : Form
    {
        private int orderId;
        private TourController controller = new TourController("your_connection_string");

        public DetailOrder(int orderId)
        {
            InitializeComponent();
            this.orderId = orderId;
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
                txtNameAcc.Text = GetAccountName(order.ID);
                txtNameTour.Text = GetTravelName(order.IDtv);
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
            txtIDOrder.ReadOnly = true;
            txtIDAcc.ReadOnly = true;
            txtIDTour.ReadOnly = true;
            txtQuantity.ReadOnly = true;
            txtNameAcc.ReadOnly = true;
            txtNameTour.ReadOnly = true;
            datePick.Enabled = false;
            TourModel order = controller.Read(orderId) as TourModel;
            if (order != null)
            {
                txtIDOrder.Text = order.IDtour.ToString();
                txtIDAcc.Text = order.ID.ToString();
                txtIDTour.Text = order.IDtv.ToString();
                txtQuantity.Text = order.Quantity.ToString();
                datePick.Value = order.BookingDate;
                txtNameAcc.Text = GetAccountName(order.ID);
                txtNameTour.Text = GetTravelName(order.IDtv);
            }

        }

        private string GetAccountName(int accountId)
        {
            InforController accountController = new InforController("your_connection_string");
            var account = accountController.Read(accountId) as InforModel;
            return account != null ? account.Name : "Tên tài khoản không tìm thấy";
        }

        private string GetTravelName(int travelId)
        {
            TravelController travelController = new TravelController("your_connection_string");
            var travel = travelController.Read(travelId) as TravelModel; 
            return travel != null ? travel.Nametv : "Tên tour không tìm thấy";
        }

        private void butBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
