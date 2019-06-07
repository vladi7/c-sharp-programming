using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    class TehiConsole
    {
        public void PrintString(string s)
        {
            Console.WriteLine(s);
        }

        /// <summary>
        /// Keep reading a value until an integer value between 0 and 5 is typed and return the value
        /// </summary>
        /// <returns>return an integer with index</returns>
        public int ReadIndex()
        {
            bool check = false;
            int value;
            do
            {
                Console.Write("Swap Card(1-5) or No Swap (0) : ");
                string line = Console.ReadLine();
                if (Int32.TryParse(line, out value) && (0 <= value) && (value <= 5))
                {                    
                        check = true;                    
                }
            } while (!check);
            return value;
        }

        /// <summary>
        /// Keep reading a character until ‘y’, ‘Y’, ‘n’, or ‘N’ is typed and return its upper case letter(Y or N)
        /// </summary>
        /// <returns></returns>
        public char ReadYN()
        {
            char YN = 'a';
            bool check = true;
            while (check)
            {
                Console.Write("Another Game(Y/N) ?: ");
                string answer = Console.ReadLine().ToUpper();
                if (answer == "N")
                {
                    check = false;
                    YN = 'N';                 
                }
                else if (answer == "Y")
                {                
                    check = false;
                    YN = 'Y';
                }
            }
            return YN;
        }
    }
}
