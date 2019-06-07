using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTS_Project
{
    [Serializable()]
    class BarredNumbersList
    {
        public List<string> barredNumbers { get;  set; } = new List<string>();

        public delegate void del(string s);
        public delegate object[] del2(List<string> barredNumber);
        public delegate bool del3(string number);
        public del addToList { get; private set; }

        public del2 toObjectArray { get; private set; }

        public del3 checkIfBarred { get; private set; }
        /// <summary>
        /// using lambda expressions
        /// </summary>
        public BarredNumbersList()
        {
            this.addToList = s => { barredNumbers.Add(s); };
            this.toObjectArray = s =>
            {  return barredNumbers.Cast<object>().ToArray();  };
            this.checkIfBarred = x => { return barredNumbers.Contains(x); };

        }

        public void addBarredNumber(string areaCode, string exchange, string number)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(areaCode);
            sb.Append("-");
            sb.Append(exchange);
            sb.Append("-");
            sb.Append(number);
            addToList(sb.ToString());
        }

        public void addBarredArea(string area)
        {
            addToList(area);
        }

        public void deleteBarredNumber(string areaCode, string exchange, string number)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(areaCode);
            sb.Append("-");
            sb.Append(exchange);
            sb.Append("-");
            sb.Append(number);
            barredNumbers.Remove(sb.ToString());
        }

        public void deleteBarredArea(string area)
        {
            barredNumbers.Remove(area);
        }
    }
}
