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
    public partial class TransferVehicleDealerDialogbox : Form
    {
        public TransferVehicleDealerDialogbox()
        {
            InitializeComponent();
        }

        public void SetTransferVehicleDealerDialogbox(string VIN, string make, string model,
            string year, string color)
        {
            tbVIN.Text = VIN;
            tbMake.Text = make;
            tbModel.Text = model;
            tbYear.Text = year;
            tbColor.Text = color;
        }

        public string DealerID {get{return tbDealerID.Text.Trim();}}
    }
}
