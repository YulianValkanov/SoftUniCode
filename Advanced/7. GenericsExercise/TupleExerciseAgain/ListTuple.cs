using System;
using System.Collections.Generic;
using System.Text;

namespace TupleExerciseAgain
{
    public class ListTuple<T>
    {
        public List<T> MyPropertyy = new List<T>();

        public ListTuple(List<T> myProp)
        {
            this.MyPropertyy = myProp;
        }

        public  static void Addd<T>(Tuple h)
        {


            MyPropertyy.Addd(h);
        }
    }
}
