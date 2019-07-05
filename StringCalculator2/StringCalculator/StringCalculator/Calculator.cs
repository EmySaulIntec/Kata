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
        public string ErrorMessage { get; set; }

        public decimal Convert(string numbers)
        {
            ErrorMessage = string.Empty;

            if (string.IsNullOrEmpty(numbers))
                return 0;

            // Get separator 
            char separator = GetSeparator(ref numbers);

            // Validate Text
            var resultValidate = ValidatingText(numbers, separator);
            if (resultValidate != null)
            {
                ErrorMessage = resultValidate;
                return 0;
            }

            // Get Numbers
            IEnumerable<decimal> numberResulted = GetNumbers(numbers, separator);

            // Sum Numbers
            return numberResulted.Sum();
        }

        private string ValidatingText(string numbers, char separator)
        {
            string doubleSeparator = separator + "," + separator;

            if (numbers.Contains(doubleSeparator))
                return $"Number expected but '\n' found at position {numbers.IndexOf(doubleSeparator)}";

            if (numbers.EndsWith(separator.ToString()))
                return "Number expected but EOF found.";

            Match match = Regex.Match(numbers, "(?=-)(.+?)(?=" + separator + ")");

            if (match.Success)
                return $"Negative not allowed : {match.Value}";

            return null;
        }

        private char GetSeparator(ref string numbers)
        {
            char separator = '\n';

            // 
            Match match = Regex.Match(numbers, "(?<=\\/\\/)(.+)(?=\\n)");

            if (match.Success)
            {
                int index = numbers.IndexOf("\n");

                numbers = numbers.Substring(index + 1).Replace(match.Value, "\n");
            }
            else
            {
                numbers = numbers.Replace(",", "\n");
            }

            return separator;

        }


        private IEnumerable<decimal> GetNumbers(string numbers, char separator)
        {
            return numbers.Split(separator).Select(e =>
            {
                return decimal.Parse(e);
            });
        }
    }
}
