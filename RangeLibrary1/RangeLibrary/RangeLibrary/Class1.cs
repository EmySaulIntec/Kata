using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RangeLibrary
{
    public class RangeController
    {

        public class Set
        {
            public bool IsOpen { get; set; }
            public bool IsClosed { get; set; }
            public int Init { get; set; }
            public int End { get; set; }
        }

        public bool IntegerRangeContain(string set, List<int> subset)
        {

            var createdRange = GetAllPointsFromSet(set);

            // Preguntamos si todos los elementos del subset estan dentro del rango creado.
            var result = subset.All(e => createdRange.Contains(e));

            return result;
        }

        public IEnumerable<int> GetAllPointsFromSet(string set)
        {
            Set setResult = GetSetFromStringAndSetParameters(set);

            // Creamos el rango definido por el string
            return Enumerable.Range(setResult.Init, (setResult.End - setResult.Init) + 1);
        }

        // Parameters = "[, ], (, )"
        private Set GetSetFromStringAndSetParameters(string set)
        {
            Set setResult = GetSetFromString(set);

            // Setear valores init y end en base a si es cerrado o abierto los corchetes.
            setResult.Init = setResult.IsOpen ? setResult.Init : setResult.Init + 1;
            setResult.End = setResult.IsClosed ? setResult.End : setResult.End - 1;
            return setResult;
        }

        // "[23,10)
        private Set GetSetFromString(string set)
        {
            var spplitedValue = set.Split(',');
            bool isOpened = spplitedValue[0].Contains('[');
            bool isClosed = spplitedValue[1].Contains(']');

            // 
            int.TryParse(spplitedValue[0].Substring(1), out int init);
            int.TryParse(spplitedValue[1].Substring(0, spplitedValue[1].Length - 1), out int end);

            // TODO: Validar salida

            return new Set()
            {
                IsOpen = isOpened,
                IsClosed = isClosed,
                Init = init,
                End = end
            };
        }
    }
}
