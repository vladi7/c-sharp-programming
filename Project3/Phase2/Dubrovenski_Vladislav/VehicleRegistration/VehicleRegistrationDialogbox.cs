using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VehicleRegistration
{
    public partial class VehicleRegistrationDialogbox : Form
    {
        public VehicleRegistrationDialogbox()
        {
            InitializeComponent();
        }

        private void VehicleRegistrationDialog_Load(object sender, EventArgs e)
        {

        }

        public string InitialDealerID
        {
           get { return tbDealer.Text.Trim();}
        }

        public string VIN
        {
            get { return tbVIN.Text.Trim(); }
        }

        public string Make
        {
            get { return tbMake.Text.Trim(); }
        }

        public string Model
        {
            get { return tbModel.Text.Trim(); }
        }

        public string Year
        {
            get { return tbYear.Text.Trim(); }
        }
        public string Color
        {
            get { return tbColor.Text.Trim(); }
        }
    }
}
