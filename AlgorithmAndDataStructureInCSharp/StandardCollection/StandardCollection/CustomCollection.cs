using System;
using System.Collections;
using System.Collections.Generic;

namespace StandardCollection
{
    public class CustomCollection<T> : IEnumerable<T>
    {
        private List<T> data = new List<T>();

        public CustomCollection()
        {
        }

        IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public void FillList(params T[] items)
        {
            foreach (var datum in items)
                data.Add(datum);
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            foreach(var datum in data)
            {
                yield return datum;
            }
        }



    }
}
