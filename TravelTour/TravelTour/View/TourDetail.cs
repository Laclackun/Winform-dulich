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
    public partial class TourDetail : Form
    {
        private UserAccountModel currentUser;
        private int IDtravel;
        private TravelController travelController = new TravelController("your_connection_string");

        public TourDetail(UserAccountModel user, int idTravel)
        {
            InitializeComponent();
            currentUser = user;
            IDtravel = idTravel;
            LoadTourDetail();
        }

        private void LoadTourDetail()
        {
            txtIDTour.ReadOnly = true;
            txtName.ReadOnly = true;
            txtDesciption.ReadOnly = true;
            txtQuantity.ReadOnly = true;
            txtLocation.ReadOnly = true;
            comboType.Enabled = false;
            datePickStart.Enabled = false;
            datePickEnd.Enabled = false;
            picTravel.Enabled = false;
            TravelModel travel = (TravelModel)travelController.Read(IDtravel);
            if (travel != null)
            {
                txtIDTour.Text = travel.IDtv.ToString();
                txtName.Text = travel.Nametv;
                txtDesciption.Text = travel.Description;
                txtQuantity.Text = travel.Quantity.ToString();
                txtLocation.Text = travel.Location;
                comboType.Text = travel.TypeTv;
                datePickStart.Value = travel.DateStart;
                datePickEnd.Value = travel.DateEnd;

                if (!string.IsNullOrEmpty(travel.ImageUrl))
                {
                    picTravel.ImageLocation = travel.ImageUrl; // Hiển thị ảnh từ URL
                }
            }
        }

        private void butBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

