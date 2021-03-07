using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GenericScale
{
    class BooklistArray
    {
        public List<Book> MyProperty = new List<Book>();


        public void ADD(Book g)
        {
            

            MyProperty.Add(g);
        }
        public void Printer()
        {
            foreach (var item in MyProperty.OrderBy(x=>x.CountPages))
             {
                Console.WriteLine( $"{item.Name }-{item.Title}-{item.CountPages}" ) ;
             }


            
        }

    }
}
