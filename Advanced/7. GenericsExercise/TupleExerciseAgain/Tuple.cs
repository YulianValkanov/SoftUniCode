using System;
using System.Collections.Generic;
using System.Text;

namespace TupleExerciseAgain
{
    public class Tuple<T>
    {
        public T[] item1 { get; set; }

        public T item2 { get; set; }

        public Tuple(List<T> elements)
        {
            if (elements.Count == 2)
            {
                T[] current = new T[] { elements[0] };

                this.item1 = current;

                this.item2 = elements[1];

                
            }
            else if (elements.Count == 3)
            {
                T[] current = new T[] { elements[0], elements[1] };

                this.item1 = current;

                this.item2 = elements[2];
            }
        }

        public override string ToString()
        {
            return $"{string.Join(" ", item1) } -> {item2}";
        }
    }
}
