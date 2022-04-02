using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace NewDB
{
    class Program
    {
        static async Task Main(string[] args)
        {
            using (var dbcontext = new SoftUniContext())
            {
                Employee employee =await  dbcontext.Employees.Where(x=>x.FirstName == "Gay").FirstOrDefaultAsync();

                Console.WriteLine($"{employee.FirstName} {employee.LastName}");
            }
        }
    }
}
