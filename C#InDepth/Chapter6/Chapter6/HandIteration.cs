using System;
using System.Collections;

namespace Chapter6
{
    public class HandIteration
    {
        public HandIteration()
        {
        }

        public static void Demo()
        {
            object[] values = { "a", "b", "c", "d", "e" };
            IterationSample collection = new IterationSample(values, 3);
            foreach(object x in collection)
            {
                Console.WriteLine(x);
            }
        }

        public class IterationSample: IEnumerable
        {
            public object[] values;
            public int startingPoint;

            public IterationSample(object[] values, int startingPoint)
            {
                this.values = values;
                this.startingPoint = startingPoint;
            }

            public IEnumerator GetEnumerator()
            {
                throw new NotImplementedException();
            }
        }

        public class IterationSampleIterator: IEnumerable
        {
            public IterationSample parent;
            public int position;
            private IterationSampleIterator iterationSampleIterator;

            internal IterationSampleIterator(IterationSample parent)
            {
                this.parent = parent;
                position = -1;
            }

            public IterationSampleIterator(IterationSampleIterator iterationSampleIterator)
            {
                this.iterationSampleIterator = iterationSampleIterator;
            }

            public bool MoveNext()
            {
                if(position != parent.values.Length)
                {
                    position++;
                }
                return position < parent.values.Length;
            }

            public object Current
            {
                get
                {
                    if(position == -1 || position == parent.values.Length)
                    {
                        throw new InvalidOperationException();
                    }
                    int index = position + parent.startingPoint;
                    index = index % parent.values.Length;
                    return parent.values[index];
                }
            }

            public void Reset()
            {
                position = -1;
            }

            public IEnumerator GetEnumerator()
            {
                yield return new IterationSampleIterator(this);
            }
        }
    }
}
