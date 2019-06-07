using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
namespace DTS_Project
{
    public class TelephoneController
    {
        private ITelephoneDevice telephoneDevice;
        Tenant currentTenant;

        public TelephoneController(ITelephoneDevice telephoneDevice)
        {
            this.telephoneDevice = telephoneDevice;
        }

        public void Activate()
        {
          
            
            // Receive an access code
            string accessCode = null;
            if (!telephoneDevice.GetAccessCode(ref accessCode)) return;
            if (TenantData.FindTenantByAC(accessCode, ref currentTenant))
            {
                // Receive a telephone number
                string areaCode = null;
                string exchange = null;
                string number = null;
                if (!telephoneDevice.GetTelephoneNumber(ref areaCode, ref exchange, ref number)) return;
                StringBuilder sb = new StringBuilder();
                sb.Append(areaCode);
                sb.Append("-");
                sb.Append(exchange);
                sb.Append("-");
                sb.Append(number);
                if (!currentTenant.barredList.checkIfBarred(areaCode) && !currentTenant.barredList.checkIfBarred(sb.ToString()))
                {
                    DateTime date = DateTime.Now;
                    currentTenant.callData.StartCall(areaCode, exchange, number, date.ToString());
                    // Connect the phone
                    telephoneDevice.ConnectPhone();
                    // User has terminated the call
                    DateTime localDate = DateTime.Now;
                    currentTenant.callData.EndCall(localDate.ToString());
                }
            }
        }
    }
}
