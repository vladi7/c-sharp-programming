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
    public partial class OwnershipTransferDialogbox : Form
    {
        public OwnershipTransferDialogbox()
        {
            InitializeComponent();
        }

        private void OwnershipTransferDialogbox_Load(object sender, EventArgs e)
        {
            TransferFromDealer = true;
            TransferToDealer = true;

        }

        public Boolean TransferFromDealer
        {
            get { return rbFromDealer.Checked; }
            set { rbFromDealer.Checked = value; }
        }

        public Boolean TransferFromPrivateOwner
        {
            get { return rbFromPrivateOwner.Checked; }
            set { rbFromPrivateOwner.Checked = value; }
        }

        public Boolean TransferToDealer
        {
            get { return rbToDealer.Checked; }
            set { rbToDealer.Checked = value; }
        }

        public Boolean TransferToPrivateOwner
        {
            get { return rbToPrivateOwner.Checked; }
            set { rbToPrivateOwner.Checked = value; }
        }

        public string FromDealerID
        {
            get { return tbFromDealerID.Text; }
        }

        public string FromSSN
        {
            get { return tbFromSSN.Text; }
        }

        public string ToDealerID
        {
            get { return tbToDealerID.Text; }
        }
        public string ToSSN
        {
            get { return tbToSSN.Text; }
        }

        public string VIN
        {
            get { return tbVIN.Text; }
        }

        public string Price
        {
            get { return tbPrice.Text; }
        }

        public string Date
        {
            get { return tbDate.Text; }
        }

        public string LicenceNumber
        {
            get { return tbLicenceNumber.Text; }
        }
    }
}
