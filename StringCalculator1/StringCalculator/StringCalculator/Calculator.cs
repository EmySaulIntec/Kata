using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace StringCalculator
{
    public class Calculator
    {
        public decimal Calculate(string numbers)
        {
            IEnumerable<decimal> values = GetValues(numbers);

            return values.Sum();
        }
        public IEnumerable<decimal> GetValues(string numbers)
        {
            IEnumerable<decimal> values;

            // Conseguir separador
            char separator = GetSeparator(ref numbers);

            if (!IsValidate(numbers, separator))
            {
                return new decimal[] { 0 };
            }

            // Conseguir numeros
            string[] numbersList = numbers.Split(separator);

            // Realizar Operacion
            values = numbersList.Select(e => decimal.Parse(e));

            return values;
        }


        // TODO: Es necesario validar que el texto introducido sea valido.
        private bool IsValidate(string numbers, char separator)
        {
            return true;
        }

        //;\n2;3\n5
        private char GetSeparator(ref string numbers)
        {
            Match match = Regex.Match(numbers, "(?<=\\/\\/)(.+?)(?=\\n)");
            if (match.Success)
            {
                int index = numbers.IndexOf("\n");

                numbers = numbers.Substring(index + 1).Replace(match.Value, "\n");
            }

            return '\n';
        }
    }
}
