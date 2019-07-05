using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumeralLibrary
{
    public class Conversor
    {
        public string Convert(int number)
        {

            // Valores permitidos
            // SE debe definir los valores permitidos, como no es parte de la prueba el hecho de que me sepa los numeros en romano, los copiares.
            string[] units = new string[] { "", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX" };
            string[] decs = new string[] { "", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC" };
            string[] cents = new string[] { "", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM" };
            string[] mils = new string[] { "", "M", "MM", "MMM" };

            if (number == 0)
                return "";

            // Fracciones
            int resto = number % 1000;
            int m = number / 1000;

            int c = resto / 100;
            resto = resto % 100;

            int d = resto / 10;
            resto = resto % 10;

            int u = resto;

            // Retornar concatenacion

            return $"{mils.ElementAt(m)}{cents.ElementAt(c)}{decs.ElementAt(d)}{units.ElementAt(u)}";
        }
    }
}
