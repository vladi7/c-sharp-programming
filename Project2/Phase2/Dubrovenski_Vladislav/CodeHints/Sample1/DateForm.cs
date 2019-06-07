using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DTS_Project
{
    public partial class DateForm : Form
    {
        public DateForm()
        {
            InitializeComponent();
        }

        private void DateForm_Load(object sender, EventArgs e)
        {
            DateTime currentTime = DateTime.Now;
            // New is a class property that returns a DateTime
            // object containing the current time

            lblDate.Text = currentTime.ToString();
            // DateTime has ToString() implemented
        }
    }
}