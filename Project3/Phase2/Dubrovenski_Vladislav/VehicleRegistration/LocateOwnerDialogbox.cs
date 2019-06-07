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
    public partial class LocateOwnerDialogbox : Form
    {
        public LocateOwnerDialogbox()
        {
            InitializeComponent();
        }

        public string SSN
        {
            get { return tbSSN.Text.Trim(); }
        }
    }
}
