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
    public class TelephoneDevice : ITelephoneDevice

    {
        public TelephoneDevice() 
        {
        }

        public bool GetAccessCode(ref string accessCode)
        {
            AccessCodeDialog accessCodeDialog = new AccessCodeDialog();
            if (accessCodeDialog.ShowDialog() != System.Windows.Forms.DialogResult.OK) return false;
            accessCode = accessCodeDialog.AccessCode;
            return true;
        }

        public bool GetTelephoneNumber(ref string areaCode, ref string exchange, ref string number)
        {
            TelephoneDialog telephoneDialog = new TelephoneDialog();
            if (telephoneDialog.ShowDialog() != DialogResult.OK) return false;
            areaCode = telephoneDialog.AreaCode;
            exchange = telephoneDialog.Exchange;
            number = telephoneDialog.Number;
            return true;
        }

        public void ConnectPhone()
        {
            ConnectedDialog connectedDialog = new ConnectedDialog();
            connectedDialog.ShowDialog();
        }

    }
}
