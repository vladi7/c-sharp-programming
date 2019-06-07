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
    public partial class TenantMenuDialog : Form
    {
        TerminalController terminal;

        public TenantMenuDialog()
        {
            InitializeComponent();
        }

        public TenantMenuDialog(TerminalController terminal):this()
        {
            this.terminal = terminal;
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
           this. Visible = false;
        }

        private void btnBarAreaCode_Click(object sender, EventArgs e)
        {
            terminal.BarAreaCode_Handler();
        }

        private void btnBarTelNumber_Click(object sender, EventArgs e)
        {
            terminal.BarTelephoneNumber_Handler();
        }

        private void btnUnBarAreaCode_Click(object sender, EventArgs e)
        {

            terminal.UnBarAreaCode_Handler();
        }

        private void btnUnBarTelNumber_Click(object sender, EventArgs e)
        {
            terminal.UnBarTelephoneNumber_Handler();
        }

        private void btnListBarNumbers_Click(object sender, EventArgs e)
        {
            terminal.DisplayBarList_Handler();
        }

        private void btnListCalls_Click(object sender, EventArgs e)
        {
            terminal.DisplayCallList_Handler();
        }

        private void btnClearCalls_Click(object sender, EventArgs e)
        {
            // Clear "tenant's" call list
            terminal.ClearCalls_Handler();
        }
    }
}