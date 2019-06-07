using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTS_Project
{
    [Serializable()]
    class Tenant
    {
        public BarredNumbersList barredList { get; private set; } = new BarredNumbersList();

        public CallData callData { get; private set; } = new CallData();

        public string firstName { get; private set; }

        public string lastName { get; private set; }

        public string accessCode { get; private set; }

        public Tenant(string firstName, string lastName, string accessCode, BarredNumbersList barredList, CallData callData)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.accessCode = accessCode;
            this.barredList = barredList;
            this.callData = callData;
        }
    }
}
