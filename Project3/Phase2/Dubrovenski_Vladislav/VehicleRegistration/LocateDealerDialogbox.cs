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
    public partial class LocateDealerDialogbox : Form
    {
        public LocateDealerDialogbox()
        {
            InitializeComponent();
        }

        public string DealerID
        {
            get { return tbDealerID.Text.Trim(); }
        }
    }
}
