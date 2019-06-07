//////////////////////////////////////////////////////////////////
//  Domestic Telephone System (DTS)                             //
//    Written by Masaaki Mizuno, (c) 2007, 2008                 //
//      for K-State Course cis501                               //
//      also for Learning Tree Course, 123P, 230Y               //
//////////////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace DTS_Project
{
    public class TerminalDevice: ITerminalDevice
    {

        TerminalController terminalController;
        public TerminalDevice(TerminalController terminalController)
        {
            this.terminalController = terminalController;
        }

        public void ShowMainMenuDialog()
        {
            MainMenuDialog mainMenuDialog = new MainMenuDialog(terminalController);
            mainMenuDialog.Show();
        }

        public void ShowTenantMenuDialog()
        {
            TenantMenuDialog tenantMenuDialog = new TenantMenuDialog(terminalController);
            tenantMenuDialog.Show();
        }

        public void DisplayList(object[] list)
        {
            ListDialog listDialog = new ListDialog();
            listDialog.AddDisplayItems(list);
            listDialog.ShowDialog();
        }

        public bool GetPassword(ref string password)
        {
            PasswordDialog passwordDialog = new PasswordDialog();
            if (passwordDialog.ShowDialog() != System.Windows.Forms.DialogResult.OK) return false;
            password = passwordDialog.Password;
            return true;
        }

        public bool GetTenantInfo(ref string firstName, ref string lastName, ref string accessCode)
        {
            InputTenantDialog inputTenantDialog = new InputTenantDialog();
            if (inputTenantDialog.ShowDialog() != DialogResult.OK) return false;
            firstName = inputTenantDialog.FirstName;
            lastName = inputTenantDialog.LastName;
            accessCode = inputTenantDialog.AccessCode;
            return true;
        }

        public bool GetTenantName(ref string firstName, ref string lastName)
        {
            LocateTenantDialog locateTenantDialog = new LocateTenantDialog();
            if (locateTenantDialog.ShowDialog() != DialogResult.OK) return false;
            firstName = locateTenantDialog.FirstName;
            lastName = locateTenantDialog.LastName;
            return true;
        }

        public bool GetAreaCode(ref string areaCode)
        {
            AreaCodeDialog areaCodeDialog = new AreaCodeDialog();
            if (areaCodeDialog.ShowDialog() != DialogResult.OK) return false;
            areaCode = areaCodeDialog.AreaCode;
            return true;
        }

        public bool GetTelephoneNumber (ref string areaCode, ref string exchange, ref string number)
        {
            TelephoneDialog telephoneDialog = new TelephoneDialog();
            if (telephoneDialog.ShowDialog() != DialogResult.OK) return false;
            areaCode = telephoneDialog.AreaCode;
            exchange = telephoneDialog.Exchange;
            number = telephoneDialog.Number;
            return true;
        }
    }
}
