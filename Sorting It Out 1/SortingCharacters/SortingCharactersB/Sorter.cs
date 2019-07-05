using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingCharactersB
{
    public class Sorter
    {
        public string Order(string input)
        {

            string result = string.Empty;

            OrderText(input, (int)'a', (int)'z', ref result);

            return result;
        }
        // dbacdedecd
        private void OrderText(string input, int init, int end, ref string result, int index = 0)
        {
            if (index == input.Length)
            {
                index = 0;
                init += 1;
            }

            if (init == end + 1)
                return;

            if (input[index] == init)
                result += input[index];


            OrderText(input, init, end, ref result, index + 1);

        }
    }
}