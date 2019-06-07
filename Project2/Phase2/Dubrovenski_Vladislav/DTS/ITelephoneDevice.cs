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
    public interface ITelephoneDevice
    {
        bool GetAccessCode(ref string accessCode);
      
        bool GetTelephoneNumber(ref string areaCode, ref string exchange, ref string number);
        
        void ConnectPhone();
    }
}
