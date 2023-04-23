using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Travel_Booking_System
{
    public partial class frmTravelbookingSystem : Form
    {
        const double HOTEL_COST_PER_NIGHT = 150;
        const double CAR_LUXURY = 100;
        const double CAR_BASIC = 50;
        
        private double airFareCost;
        private double hotelCost;
        private double carRentalCost;
        private double totalCost;
        public frmTravelbookingSystem()
        {
            InitializeComponent();
        }

        private void btnCalcTotalCost_Click(object sender, EventArgs e)
        {
            int numGuests = int.Parse(tboxNumGuests.Text);
            string destination;

            if(lboxDestination.SelectedIndex != -1)
            {
                destination = lboxDestination.SelectedItem.ToString();

                if(destination == "New York ($400)")
                {
                    airFareCost = 400;
                }
                else if(destination == "Los Angeles ($500)")
                {
                    airFareCost = 500;
                }
                else if(destination == "Miami ($450)")
                {
                    airFareCost = 450;
                }
                else if(destination == "Chicago ($350)")
                {
                    airFareCost = 350;
                }
                else if(destination == "San Francisco ($550)")
                {
                    airFareCost = 550;
                }
            }
            else
            {
                MessageBox.Show("Please select a destination.");
            }

            int numDays = int.Parse(tboxNumDays.Text);

            if(radBasic.Checked)
            {
                carRentalCost = numDays * CAR_BASIC;
            }

            if(radLuxury.Checked)
            {
                carRentalCost = numDays * CAR_LUXURY;
            }

            if(radNone.Checked)
            {
                carRentalCost = numDays * 0;
            }

            int numNights = int.Parse(tboxNumNights.Text);

            hotelCost = numNights * HOTEL_COST_PER_NIGHT;

            totalCost = (airFareCost + carRentalCost + hotelCost) * numGuests;

            lblOutTotalCost.Text = totalCost.ToString("c2");

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
