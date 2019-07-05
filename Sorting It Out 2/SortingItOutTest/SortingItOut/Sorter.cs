using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingItOut
{
    public class Sorter
    {
        public string Sort(string input)
        {
            string result = string.Empty;

            SortText(input.ToLower(), (int)'a', (int)'z', ref result);

            return result;
        }

        private void SortText(string input, int init, int end, ref string result, int index = 0)
        {
            if (string.IsNullOrEmpty(input))
                return;

            if (init == end + 1) // Verifica si init desde a llego a z
                return;

            if (index == input.Length) // Verifica si el index llego a la ultima letra
            {
                init += 1;
                index = 0;
            }

            if (input[index] == init) // Verifica si la letra actual es la correspondiente a init
                result += input[index];

            SortText(input, init, end, ref result, index + 1); // Cambia de index
        }
    }
}
