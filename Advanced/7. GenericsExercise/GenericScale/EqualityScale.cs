using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace GenericScale
{
    public class EqualityScale<T>
    {


        private T Left;

        private T Right;

        public EqualityScale(T left, T right)
        {
            this.Left = left;

            this.Right = right;
        }

 

       
        public  bool AreEqual ()
        {
            //return Left.Equals(Right);

            if (Left.Equals(Right))
            {
                return true;
            }
            return false;
        }

    }
}
