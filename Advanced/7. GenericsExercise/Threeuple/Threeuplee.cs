using System;
using System.Collections.Generic;
using System.Text;

namespace Threeuple
{
    public class Threeuplee<T1,T2,T3>
    {


        public T1 FirstElement { get; set; }

        public T2 SecondElement { get; set; }

        public T3 ThirthElement { get; set; }



        public Threeuplee(T1 first, T2 second, T3 thirth )
        {
            this.FirstElement = first;

            this.SecondElement = second;

            this.ThirthElement = thirth;

            
        }

        public override string ToString()
        {
            return $"{FirstElement} -> {SecondElement} -> {ThirthElement}";
        }
    }
}
