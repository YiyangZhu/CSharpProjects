using System;
using System.Collections;
using System.Collections.Generic;

namespace StandardCollection
{
    public class CustomCollection<T> : IEnumerable<T>
    {
        public CustomCollection()
        {
        }

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }


    }
}
