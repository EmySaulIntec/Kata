using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumeralsLibrary
{
    public class RomanConversor
    {
        public string Convert(int n)
        {
            // Valores Permitidos
            // Estos numeros en romano, puedo buscarlo debido a que no evaluamos que sepa los numeros romanos jaja XD

            string[] units = new string[] { "", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX" };
            string[] decs = new string[] { "", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC" };
            string[] cents = new string[] { "", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM" };
            string[] mils = new string[] { "", "M", "MM", "MMM" };

            // Validar Numero
            if (n == 0)
                return "";

            // Fracciones
            int resto = n % 1000; // Deja el resto de la division entre 1000
            int m = n / 1000;
            int c = resto / 100;
            resto = resto % 100;
            int d = resto / 10;
            int u  = resto % 10;

            // Devolver 
            return $"{mils.ElementAt(m)}{cents.ElementAt(c)}{decs.ElementAt(d)}{units.ElementAt(u)}";
        }
    }
}
