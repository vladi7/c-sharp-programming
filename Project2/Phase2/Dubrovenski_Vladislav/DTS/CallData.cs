using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace DTS_Project
{
    [Serializable()]
    class CallData
    {
        StringBuilder currentCall = new StringBuilder();

        public List<string> callData { get; private set; } = new List<string>();

        public delegate object[] del(List<string> calledNumber);

        public del toObjectArray { get; private set; }

        public CallData()
        {
            this.toObjectArray = s =>
            { return callData.Cast<object>().ToArray(); };
        }

        public void StartCall(string areaCode, string exchange, string number, string time)
        {
            currentCall.Append(areaCode);
            currentCall.Append("-");
            currentCall.Append(exchange);
            currentCall.Append("-");
            currentCall.Append(number);
            currentCall.Append(" : ");
            currentCall.Append(time);

        }

        public void EndCall(string time)
        {
            currentCall.Append("---");
            currentCall.Append(time);
            callData.Add((currentCall.ToString()));
            currentCall.Clear();
        }

        public void ClearCallData()
        {
            callData.Clear();
        }
    }
}
