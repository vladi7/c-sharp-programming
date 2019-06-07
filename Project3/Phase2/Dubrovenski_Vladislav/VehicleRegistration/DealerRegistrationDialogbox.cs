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
    public partial class DealerRegistrationDialogbox : Form
    {
        public DealerRegistrationDialogbox()
        {
            InitializeComponent();
        }

        public string DealerID
        {
            get { return tbDealerID.Text.Trim(); }
        }

        public string DealerName
        {
            get { return tbDealerName.Text.Trim(); }
        }

        public string DealerCity
        {
            get { return tbDealerCity.Text.Trim(); }
        }

        public string DealerState
        {
            get { return tbDealerState.Text.Trim(); }
        }

    }
}
