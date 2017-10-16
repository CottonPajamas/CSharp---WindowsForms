using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BizApp01
{
    public partial class Form_EnquireStatus : Form
    {
        public Form_EnquireStatus()
        {
            InitializeComponent();
            textBoxModel.ReadOnly = true;
            textBoxColour.ReadOnly = true;
            textBoxEngSerialNo.ReadOnly = true;
            textBoxStatus.ReadOnly = true;
        }


        // 1 : enterId()
        // 2 : submit()
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            EnquireStatusInitiate();
        }

        private void textBoxVehPlateNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                EnquireStatusInitiate();
            }
        }



        private void EnquireStatusInitiate()
        {
            //Clears the textboxes at the start everytime the button is clicked.
            textBoxModel.Text = "";
            textBoxColour.Text = "";
            textBoxEngSerialNo.Text = "";
            textBoxStatus.Text = "";
            toolStripStatusLabel1.Text = "";

            string input = textBoxVehPlateNo.Text.Trim();


            if ((string.IsNullOrWhiteSpace(input)) || input.Count() > 7)
            {
                MessageBox.Show("Please enter a registered vehicle plate number.");
            }
            else
            {
                try
                {
                    // 3 : retrieveVehicle()  -  Request is sent to the EnquireStatusControl controller
                    EnquireStatusControl esControl = new EnquireStatusControl();

                    //Here, vehicle object is received from the EnquireStatusControl
                    Vehicle v = esControl.RetrieveVehicle(input);

                    // 7 : getAttr() from our new object  &&   8 : displayDetails()
                    textBoxModel.Text = v.VehicleModel;
                    textBoxColour.Text = v.VehicleColour;
                    textBoxEngSerialNo.Text = v.EngineSerialNo;
                    textBoxStatus.Text = v.VehicleStatus;


                    toolStripStatusLabel1.Text = CarRentalMessage.VehiclePlateNoFound;

                }

                // 9 : displayError()
                catch (CarRentalException carRentalExcep)
                {
                    Console.WriteLine("Exception !!!");
                    Console.WriteLine(carRentalExcep.Message);
                    Console.WriteLine(carRentalExcep.StackTrace);
                    MessageBox.Show(carRentalExcep.Message);
                }
                catch (Exception excep)
                {
                    Console.WriteLine("Exception !!!");
                    Console.WriteLine(excep.Message);
                    Console.WriteLine(excep.StackTrace);
                    MessageBox.Show(CarRentalMessage.RegularErrorMsg);
                    //Will initialize the error message class and retrieve that specific string.
                }
            }
        }
    }
}
