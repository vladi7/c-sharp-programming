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
    public partial class MainMenuDialog : Form
    {
        private TerminalController terminal;

        public MainMenuDialog()
        {
            InitializeComponent();
        }

        public MainMenuDialog(TerminalController terminal)
            : this()
        {
            this.terminal = terminal;
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            Visible = false;
        }

        private void btnAddTenant_Click(object sender, EventArgs e)
        {
            terminal.AddTenant_Handler();
        }

        private void btnDeleteTenant_Click(object sender, EventArgs e)
        {
            terminal.DeleteTenant_Handler();
        }

        private void btnListTenants_Click(object sender, EventArgs e)
        {
            terminal.DisplayTenantList_Handler();
        }

        private void btnWorkTenant_Click(object sender, EventArgs e)
        {
            terminal.WorkOnTenant_Handler();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            terminal.Save_Handler();
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            terminal.Restore_Handler();
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            terminal.ChangePassword_Handler();
        }
    }
}