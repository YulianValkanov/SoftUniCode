using System.Collections.Generic;

namespace GenericScale
{
    public class Book
    {

       

        public string Name { get; set; }

        public string Title { get; set; }

        public int CountPages { get; set; }

        public Book(string name, string title, int countPages)
        {
            this.Name = name;
            this.Title = title;
            this.CountPages = countPages;

           
        }

        public Book()
        {

        }

       

        

    }
}