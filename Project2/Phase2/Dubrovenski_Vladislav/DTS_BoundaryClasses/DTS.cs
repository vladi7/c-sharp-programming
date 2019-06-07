//////////////////////////////////////////////////////////////////
//  Domestic Telephone System (DTS)                             //
//    Written by Masaaki Mizuno, (c) 2007, 2008                 //
//      for K-State Course cis501                               //
//      also for Learning Tree Course, 123P, 230Y               //
//////////////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DTS_Project
{
    public partial class DTS : Form
    {

        TelephoneDevice telephoneDevice;
        TelephoneController telephoneController;
        TerminalDevice terminalDevice;
        TerminalController terminalController;

        public DTS()
        {
            InitializeComponent();
        }

        private void DTS_Load(object sender, EventArgs e)
        {

            // You may need to modify the following to construct your initial object structure
            terminalController = new TerminalController();
            terminalDevice = new TerminalDevice(terminalController);
            terminalController.TerminalDevice = terminalDevice;

            telephoneDevice = new TelephoneDevice();
            telephoneController = new TelephoneController(telephoneDevice);
        }

        private void btnTerminal_Click(object sender, EventArgs e)
        {
            terminalController.Activate();
        }

        private void btnTelephone_Click(object sender, EventArgs e)
        {
            telephoneController.Activate();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}