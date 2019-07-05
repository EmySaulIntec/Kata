using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberToWords
{
    public class WordConversor
    {
        public string Convert(int number)
        {
            if (number == 0)
                return "Zero";

            return ConvertNumber(number).Trim();
        }

        private string ConvertNumber(int number)
        {
            if (number == 1000000)
            {
                return "One Million";
            }
            else if (number >= 1000 && number < 1000000)
            {
                int m = number / 1000;
                int c = number % 1000;

                return ConvertNumber(m) + " Thousand " + ConvertNumber(c);
            }
            else if (number >= 100 && number < 1000)
            {
                int c = number / 100;
                int d = number % 100;

                return ConvertNumber(c) + " Hundred " + ConvertNumber(d);
            }
            else if (number >= 20 && number < 100)
            {
                string[] values = new string[] { "", "", "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };
                int d = number / 10;
                int u = number % 10;

                return values[d] + " " + ConvertNumber(u);
            }
            else if (number >= 11 && number < 20) // 11
            {
                int u = number % 10;
                string[] values = new string[] { "", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen" };

                return values[u];
            }
            else if (number >= 1 && number < 11)
            {
                int u = number % 10;
                string[] values = new string[] { "Ten", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eigh", "Nine" };

                return values[u];
            }
            else
            {
                return "";
            }
        }
    }
}
