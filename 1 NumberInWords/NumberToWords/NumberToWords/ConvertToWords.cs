using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberToWords
{
    public class ConvertToWords
    {

        // Convertir del 0 al 1000 sin decimales
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
            if (number >= 1000 && number < 1000000)
            {
                int m = number / 1000; // 2
                int c = number % 1000; // 10
                return ConvertNumber(m) + " Thousand " + ConvertNumber(c);
            }
            else if (number >= 100 && number < 1000)  // 210
            {
                int c = number / 100; // 2
                int d = number % 100; // 10
                return ConvertNumber(c) + " hundred " + ConvertNumber(d);
            }
            else if (number >= 20 && number <= 99)  // 210
            {

                string[] nitValues = new string[] { "", "", "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };

                int d = number / 10; // 2
                int u = number % 10; // 10
                return nitValues[d] + " " + ConvertNumber(u);
            }
            else if (number > 10 && number <= 19)
            {
                int u = number % 10; // 10

                string[] nitValues = new string[] { "", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen" };

                return nitValues[u];
            }
            else if (number >= 1 && number <= 10)
            {
                string[] nitValues = new string[] { "", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten" };

                return nitValues[number];
            }
            else
            {
                return "";
            }
        }
    }
}
