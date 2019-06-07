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
    public partial class OwnerRegistrationDialogbox : Form
    {
        public OwnerRegistrationDialogbox()
        {
            InitializeComponent();
        }

        public string SSN
        {
            get { return tbSSN.Text.Trim(); }
        }

        public string FirstName
        {
            get { return tbFirstName.Text.Trim(); }
        }

        public string LastName
        {
            get { return tbLastName.Text.Trim(); }
        }

        public string Address
        {
            get { return tbAddress.Text.Trim(); }
        }
        public string BirthDate
        {
            get { return tbBirthDate.Text.Trim(); }
        }
    }
}
