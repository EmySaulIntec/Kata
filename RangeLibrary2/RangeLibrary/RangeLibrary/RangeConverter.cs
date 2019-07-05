using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RangeLibrary
{
    public class RangeConverter
    {
        public class Set
        {
            public Set(string set)
            {
                string[] spplited = set.Split(',');

                this.IsOpen = spplited[0].Contains("[");
                this.IsClosed = spplited[1].Contains("]");

                int.TryParse(spplited[0].Substring(1), out int init);
                int.TryParse(spplited[1].Substring(0, spplited[1].Length - 1), out int end);

                this.Init = this.IsOpen ? init : init + 1;
                this.End = this.IsClosed ? end : end - 1;
            }

            public bool IsOpen { get; internal set; }
            public bool IsClosed { get; internal set; }
            public int Init { get; internal set; }
            public int End { get; internal set; }
        }

        public IEnumerable<int> GetElements(string set)
        {
            Set setElements = new Set(set);

            return Enumerable.Range(setElements.Init, (setElements.End - setElements.Init) + 1);
        }

        public bool IntegerContain(string set, List<int> subSet)
        {
            IEnumerable<int> elementsInSet = GetElements(set);

            return subSet.TrueForAll(e => elementsInSet.Any(b => b == e));
        }

        public IEnumerable<int> GetAllPoints(string set)
        {
            return GetElements(set);
        }

        public bool RangeContain(string set, string otherSet)
        {
            var setElements = GetAllPoints(set);
            var otherSetElements = GetAllPoints(otherSet).ToList();

            return otherSetElements.TrueForAll(e => setElements.Any(b => b == e));
        }

        public bool EndPoints(string set, int[] endPoints)
        {
            Set setElements = new Set(set);
            return setElements.Init == endPoints[0] && setElements.End == endPoints[1];
        }
    }
}
