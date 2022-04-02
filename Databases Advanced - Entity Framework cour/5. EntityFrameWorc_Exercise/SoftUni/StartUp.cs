
namespace SoftUni
{
    using Microsoft.EntityFrameworkCore;
    using SoftUni.Data;
    using SoftUni.Models;
    using System;
    using System.Linq;
    using System.Text;

    public class StartUp
    {
        static void Main(string[] args)
        {
            SoftUniContext db = new SoftUniContext();

            string result = GetAddressesByTown(db);

            Console.WriteLine(result);
        }

        public static string GetEmployeesWithSalaryOver50000(SoftUniContext context)
        {
            StringBuilder sb = new StringBuilder();

            var employees = context
                .Employees
                .Where(x => x.Salary > 50000)
                .OrderBy(x => x.FirstName)
                .Select(e => new
                {
                    e.FirstName,
                    e.Salary
                })
                .ToArray();

            foreach (var employee in employees)
            {
                sb.AppendLine($"{employee.FirstName} - {employee.Salary:f2}");
            }

            return sb.ToString().TrimEnd();
        }


        public static string GetEmployeesFromResearchAndDevelopment(SoftUniContext context)
        {
            StringBuilder sb = new StringBuilder();

            var employees = context
                .Employees
                .Where(x => x.Department.Name == "Research and Development")
                .OrderBy(x => x.Salary)
                .ThenByDescending(x => x.FirstName)
                .Select(e => new
                {
                    e.FirstName,
                    e.LastName,
                    DepartmentName = e.Department.Name,
                    e.Salary
                })
                .ToArray();

            foreach (var employee in employees)
            {
                sb.AppendLine($"{employee.FirstName} {employee.LastName} from {employee.DepartmentName} - ${employee.Salary:f2}");
            }

            return sb.ToString().TrimEnd();
        }


        public static string AddNewAddressToEmployee(SoftUniContext context)
        {


            Address adress = new Address();
            adress.AddressText = "Vitoshka 15";
            adress.TownId = 4;

            context.Addresses.Add(adress);

            Employee employee = context.Employees.FirstOrDefault(x => x.LastName == "Nakov");

            employee.Address = adress;

            context.SaveChanges();

            var allEmployees = context.Employees.OrderByDescending(x => x.AddressId).Select(x => x.Address.AddressText).Take(10);

            return String.Join(Environment.NewLine, allEmployees);
        }

        public static string IncreaseSalaries(SoftUniContext context)
        {
            StringBuilder sb = new StringBuilder();

            IQueryable<Employee> employeesToIncreese = context.Employees
                .Where(x => x.Department.Name == "Engineering" ||
                x.Department.Name == "Tool Design" ||
                x.Department.Name == "Marketing" ||
                x.Department.Name == "Information Services");

            foreach (var employee in employeesToIncreese)
            {
                employee.Salary += employee.Salary * 0.12m;

            }
            context.SaveChanges();

            var returnEmployees = employeesToIncreese.Select(x => new
            {
                x.FirstName,
                x.LastName,
                x.Salary
            }
            )
                .OrderBy(x => x.FirstName)
                .ThenBy(x => x.LastName)
                .ToArray();

            foreach (var e in returnEmployees)
            {
                sb.AppendLine($"{e.FirstName} {e.LastName} (${e.Salary:f2})");
            }


            return sb.ToString().TrimEnd();
        }


        public static string RemoveTown(SoftUniContext context)
        {
            Address[] adresses = context.Addresses.Where(x => x.Town.Name == "Seattle").ToArray();

            Employee[] employees = context
                .Employees
                .ToArray()
                .Where(e => adresses.Any(a => a.AddressId == e.AddressId))
                .ToArray();
            ;
            foreach (var e in employees)
            {
                e.AddressId = null;
            }

            context.Addresses.RemoveRange(adresses);

            Town town = context.Towns.FirstOrDefault(x => x.Name == "Seattle");

            context.Towns.Remove(town);

            context.SaveChanges();

            return $"{adresses.Length} addresses in Seattle were deleted";
        }

        public static string GetEmployeesInPeriodActual(SoftUniContext context)
        {
            var employees = context.Employees
                .Where(e => e.EmployeesProjects.Any(ep => ep.Project.StartDate.Year >= 2001 && ep.Project.StartDate.Year <= 2003))
               .Select(e => new
               {
                   FirstName = e.FirstName,
                   LastName = e.LastName,
                   ManagerFirstName = e.Manager.FirstName,
                   ManagerLastName = e.Manager.LastName,
                   Projects = e.EmployeesProjects.Select(ep => new
                   {
                       ProjectName = ep.Project.Name,
                       ProjectStartDate = ep.Project.StartDate,
                       ProjectEndDate = ep.Project.EndDate
                   })
               }).Take(10)
               .ToArray();

            StringBuilder employeeManagerResult = new StringBuilder();

            foreach (var employee in employees)
            {
                employeeManagerResult.AppendLine($"{employee.FirstName} {employee.LastName} - Manager: {employee.ManagerFirstName} {employee.ManagerLastName}");

                foreach (var project in employee.Projects)
                {
                    var startDate = project.ProjectStartDate.ToString("M/d/yyyy h:mm:ss tt");
                    var endDate = project.ProjectEndDate.HasValue ? project.ProjectEndDate.Value.ToString("M/d/yyyy h:mm:ss tt") : "not finished";

                    employeeManagerResult.AppendLine($"--{project.ProjectName} - {startDate} - {endDate}");
                }
            }
            return employeeManagerResult.ToString().TrimEnd();
        }

        public static string GetEmployeesInPeriod(SoftUniContext context)
        {
            StringBuilder sb = new StringBuilder();

            var employee = context.Employees
                .Where(x => x.EmployeesProjects.Any(p => p.Project.StartDate.Year >= 2001 && p.Project.StartDate.Year <= 2003))
                .Select(x=>new
                { 
                x.FirstName,
                x.LastName,
                x.Manager,
               project =x.EmployeesProjects.Select(p=>new
               {
                   p.Project.Name,
                   p.Project.StartDate,                
                   p.Project.EndDate
               })
                })
               
                .ToArray()
                 .Take(10);

            foreach (var e in employee)
            {
                sb.AppendLine($"{e.FirstName} {e.LastName} - Manager: {e.Manager.FirstName} {e.Manager.LastName}");

                foreach (var p in e.project)
                {
                    string end = "not finished";

                    if (p.EndDate!=null)
                    {
                       DateTime end1 = DateTime.Parse(p.EndDate.ToString());
                        end = end1.ToString("M/d/yyyy h:mm:ss tt");                          
                    }

                    sb.AppendLine($"--{p.Name} - {p.StartDate.ToString("M/d/yyyy h:mm:ss tt")} - {end}");
                }
            }

            return sb.ToString().TrimEnd();
        }

        public static string GetAddressesByTown(SoftUniContext context)
        {
            var addreses = context.Addresses
                .Select(x=>new
            { 
            x.AddressText,
            x.Town,
            countt=x.Employees.Count(e=>e.AddressId==x.AddressId)
            }
            )      
                .OrderByDescending(a=>a.countt)
                .ThenBy(x=>x.Town.Name)
                .ThenBy(x => x.AddressText)
                .Take(10)
                .ToArray()
                ;

         

            StringBuilder sb = new StringBuilder();

            foreach (var a in addreses)
            {
                sb.AppendLine($"{a.AddressText}, {a.Town.Name} - {a.countt} employees");
            }

            return sb.ToString().TrimEnd();
            
        }
    }
}
