using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnagramLibrary
{
    public class AnagramGetter
    {
        public IEnumerable<string> Get(string path)
        {
            return File.ReadAllLines(path)
                   .GroupBy(e => string.Concat(e.OrderBy(b => b)))
                   .Where(e => e.Count() > 1)
                   .Select(e =>
                   {
                       return e.Key + " " + e.LastOrDefault();
                   });
        }
    }
}
