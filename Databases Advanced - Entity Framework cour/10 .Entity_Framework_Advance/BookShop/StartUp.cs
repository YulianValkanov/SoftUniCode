namespace BookShop
{
    using BookShop.Models.Enums;
    using Data;
    using Initializer;
    using System;
    using System.Linq;
    using System.Text;
    // using BookShop.Initializer;
    // using BookShop.Data;
    using BookShop.Models;

    public class StartUp
    {
        public static void Main()
        {
            using var db = new BookShopContext();
          //  DbInitializer.ResetDatabase(db);

            //string AgeRestrictionString = Console.ReadLine();

            // string result = GetGoldenBooks(db);

            //int year = int.Parse(Console.ReadLine());

            // string result = GetBooksNotReleasedIn(db, year);

            //  string input = Console.ReadLine();

            // string result = CountCopiesByAuthor(db);

            //string result = GetTotalProfitByCategory(db);

            //string result = GetMostRecentBooks(db);

            //IncreasePrices(db);

            // RemoveBooks(db);
         string result= GetBooksByCategory(db, "horror mystery drama");

         


           Console.WriteLine(result);


        }

        public static string GetBooksByAgeRestriction(BookShopContext context, string command)
        {
            StringBuilder sb = new StringBuilder();

            ///Pars ENUM !!!  string->Enum:    Enum.Parse<T>     Enum.TryParse<T>
            /// int-> Enum:    casting TEnum(value);
            AgeRestriction ageRestriction = Enum.Parse<AgeRestriction>(command, true);

            string[] bookTitles = context
                .Books
                .Where(b => b.AgeRestriction == ageRestriction)
                .OrderBy(b => b.Title)
                .Select(a => a.Title)
                .ToArray();

            foreach (var title in bookTitles)
            {
                sb.AppendLine(title);
            }

            return sb.ToString().TrimEnd();
        }

        public static string GetGoldenBooks(BookShopContext context)
        {

            StringBuilder sb = new StringBuilder();

            string[] golednBookss = context.Books
                .Where(x => x.EditionType == EditionType.Gold && x.Copies < 5000)
                .OrderBy(x => x.BookId)
                .Select(x => x.Title)
                .ToArray();

            foreach (var item in golednBookss)
            {
                sb.AppendLine(item);
            }

            return sb.ToString().TrimEnd();


        }

        public static string GetBooksNotReleasedIn(BookShopContext context, int year)
        {
            StringBuilder sb = new StringBuilder();

            string[] bookNotReleased = context.Books
                .Where(b => b.ReleaseDate.HasValue && b.ReleaseDate.Value.Year != year)
                .OrderBy(x => x.BookId)
                .Select(x => x.Title)
                .ToArray();

            foreach (var item in bookNotReleased)
            {
                sb.AppendLine(item);
            }

            return sb.ToString().TrimEnd();
        }

        public static string GetAuthorNamesEndingIn(BookShopContext context, string input)
        {
            StringBuilder sb = new StringBuilder();

            string[] authorNames = context.Authors
                .ToArray()
                .Where(x => x.FirstName.ToLower().EndsWith(input.ToLower()))
                .Select(a => $"{a.FirstName} {a.LastName}")
                .OrderBy(a=>a)
                .ToArray();

            foreach (var item in authorNames)
            {
                sb.AppendLine(item);
            }

            return sb.ToString().TrimEnd();
        }


        public static string CountCopiesByAuthor(BookShopContext context)
        {
            StringBuilder sb = new StringBuilder();

            var authorsWihtBookCopies = context.Authors
                .Select(a => new
                {
                    FullName = a.FirstName + " " + a.LastName,
                    TotalBooks = a.Books.Sum(a => a.Copies)
                })
                .OrderByDescending(a=>a.TotalBooks)
                .ToArray();

            foreach (var item in authorsWihtBookCopies)
            {
                sb.AppendLine($"{item.FullName} - {item.TotalBooks}");
            }

            return sb.ToString().TrimEnd();
        }

        public static string GetTotalProfitByCategory(BookShopContext context)
        {
            StringBuilder sb = new StringBuilder();

            var categoriesByProfit = context.Categories
                .Select(a => new
                {
                    categoryName = a.Name,
                    totalProfit = a.CategoryBooks.Sum(x => x.Book.Copies * x.Book.Price)
                }).OrderByDescending(a => a.totalProfit).ThenBy(a => a.categoryName).ToArray();

            foreach (var item in categoriesByProfit)
            {
                sb.AppendLine($"{item.categoryName} ${item.totalProfit:f2}");
            }

            return sb.ToString().TrimEnd();

        }

        public static string GetMostRecentBooks(BookShopContext context)
        {
            StringBuilder sb = new StringBuilder();

            var categories = context.Categories
                .Select(a => new
                {
                    CategoryName = a.Name,
                    MostReasant = a.CategoryBooks
                .Select(x => x.Book)
                .OrderByDescending(b => b.ReleaseDate)
                .Select(a => new
                {
                    bookTitel = a.Title,
                    releaseYear = a.ReleaseDate.Value.Year
                })
                .Take(3)
                .ToArray()
                }).OrderBy(c => c.CategoryName).ToArray();

            foreach (var item in categories)
            {
                sb.AppendLine($"--{item.CategoryName}");

                foreach (var book in item.MostReasant)
                {
                    sb.AppendLine($"{book.bookTitel} ({book.releaseYear})");
                }
                    
            }

            return sb.ToString().TrimEnd();

        }

        public static void IncreasePrices(BookShopContext context)
        {
            IQueryable<Book> allbooksBefore2010 = context.Books
                    .Where(x => x.ReleaseDate.HasValue &&
                    x.ReleaseDate.Value.Year < 2010);

            foreach (var book in allbooksBefore2010)
            {
                book.Price += 5;
            }

            context.BulkUpdate(allbooksBefore2010);
        }

        public static int RemoveBooks(BookShopContext context)
        {
           IQueryable<Book> books = context.Books.Where(x => x.Copies < 42000);

            int bo = books.Count();

            context.BulkDelete(books);

            return bo;



        }

        public static string GetBooksByCategory(BookShopContext context, string input)
        {

            StringBuilder sb = new StringBuilder();

            string[] films = input.Split(" "). ToArray();


            var books = context.Books

                .Select(x => new
                {
                    name = x.Title,
                    categoryName = x.BookCategories.Select(c => c.Category.Name).First().ToLower()
                } )
                .Where(x=>films.Contains(x.categoryName))
                .OrderBy(x=>x.name)
                .ToArray();

            foreach (var book in books)
            {
                sb.AppendLine($"{book.name}");

               
            }

            return sb.ToString().TrimEnd();
        }
    }
}
