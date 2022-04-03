using CarDealer.Data;
using CarDealer.DTO.ExportDTO;
using CarDealer.DTO.ImportDTO;
using CarDealer.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace CarDealer
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            CarDealerContext dbContext = new CarDealerContext();

            //ResetDb(dbContext);

            // string read = File.ReadAllText("../../../Datasets/suppliers.xml");

           // string read = File.ReadAllText("../../../Datasets/sales.xml");

           Console.WriteLine(GetSalesWithAppliedDiscount(dbContext));
        }

        public static string GetSalesWithAppliedDiscount(CarDealerContext context)

        {
            StringBuilder sb = new StringBuilder();

            using StringWriter streamWriter = new StringWriter(sb);

            XmlSerializer xmlSerializer = GenerateXmlSerializer("sales", typeof(ExportSalesWithDiscount[]));

            XmlSerializerNamespaces namespaces = new XmlSerializerNamespaces();
            namespaces.Add(String.Empty, String.Empty);

            ExportSalesWithDiscount[] sales = context
                .Sales
                .Select(s => new ExportSalesWithDiscount()
                {
                    Car = new ExportCarWithDiscountCarDto()
                    {
                        Make = s.Car.Make,
                        Model = s.Car.Model,
                        TraveledDistance = s.Car.TravelledDistance.ToString()

                    },
                    CustomerName = s.Customer.Name,
                    Discount = s.Discount.ToString(),
                    Price = s.Car.PartCars.Sum(x => x.Part.Price).ToString(),
                    PriceWithDiscount = (s.Car.PartCars.Sum(x => x.Part.Price) - s.Car.PartCars.Sum(x => x.Part.Price) * s.Discount/100).ToString()

                }).ToArray();


            xmlSerializer.Serialize(streamWriter, sales, namespaces);

            return sb.ToString().TrimEnd();

        }

        public static string GetCarsWithDistance(CarDealerContext context)
        {
            StringBuilder sb = new StringBuilder();

            XmlSerializer xmlSerializer = GenerateXmlSerializer("cars", typeof(ExportCarsDto[]));

            XmlSerializerNamespaces namespaces = new XmlSerializerNamespaces();
            namespaces.Add(String.Empty, String.Empty);

            using StringWriter streamWriter = new StringWriter(sb);


            ExportCarsDto[] carsDto = context
                .Cars
                .Where(x => x.TravelledDistance > 2000000)
                .OrderBy(x => x.Make)
                .ThenBy(x => x.Model)
                .Take(10)
                .Select(c => new ExportCarsDto
                {
                    Make = c.Make,
                    Model = c.Model,
                    TravelledDistance = c.TravelledDistance.ToString()

                }).ToArray();

            xmlSerializer.Serialize(streamWriter, carsDto, namespaces);

            return sb.ToString().TrimEnd();
        }

        public static string ImportSales(CarDealerContext context, string inputXml)
        {
            XmlSerializer serializer = GenerateXmlSerializer("Sales", typeof(ImportSalesDto[]));

            using StringReader stringRreader = new StringReader(inputXml);

            ImportSalesDto[] dtos = (ImportSalesDto[])serializer.Deserialize(stringRreader);

            ICollection<Sale> sales = new HashSet<Sale>();

            foreach (var sale in dtos)
            {
                Car car = context.Cars.FirstOrDefault(x=>x.Id==sale.CarId);

                if (car==null)
                {
                    continue;
                }


                Sale s = new Sale()
                {
                    Car=car,
                    CustomerId=sale.CustomerId,
                    Discount=sale.Discount
                };

                sales.Add(s);
            }

            context.Sales.AddRange(sales);
            context.SaveChanges();

            return $"Successfully imported {sales.Count}";

        }

        public static string ImportCustomers(CarDealerContext context, string inputXml)
        {
            XmlRootAttribute xmlRoot = new XmlRootAttribute("Customers");

            XmlSerializer serializer = new XmlSerializer(typeof(ImportCustomersDto[]), xmlRoot);

            using StringReader stringReader = new StringReader(inputXml);

            ImportCustomersDto[] dtos = (ImportCustomersDto[])serializer.Deserialize(stringReader);

            ICollection<Customer> customers = new HashSet<Customer>();

            foreach (var customer in dtos)
            {
                Customer c = new Customer()
                {
                    Name = customer.Name,
                    BirthDate = DateTime.Parse(customer.BirthDate),
                    IsYoungDriver = bool.Parse(customer.IsYoungDriver)
                };

                customers.Add(c);

            }

            //<birthDate>1993-11-20T00:00:00</birthDate>

            context.Customers.AddRange(customers);
            context.SaveChanges();

            return $"Successfully imported {customers.Count}";

        }

        public static string ImportCars(CarDealerContext context, string inputXml)
        {

           XmlSerializer xmlSerializer=  GenerateXmlSerializer("Cars",typeof(ImportCarsDto[]));

            using StringReader stringRreader = new StringReader(inputXml);

           ImportCarsDto[] dtos = (ImportCarsDto[])xmlSerializer.Deserialize(stringRreader);

            ICollection<Car> cars = new HashSet<Car>();
           

            foreach (var car in dtos)
            {
                Car c = new Car()
                {
                    Make=car.Make,
                    Model=car.Model,
                    TravelledDistance=car.TraveledDistance
                   
                   
                };

                ICollection<PartCar> partCars = new HashSet<PartCar>();

                foreach (var partId in car.Parts.Select(x=>x.Id).Distinct())
                {
                    Part part = context.Parts.Find(partId);

                    if (part==null)
                    {
                        continue;
                    }

                    PartCar carPart = new PartCar()
                    {
                        Car = c,
                        Part = part
                    };

                    partCars.Add(carPart);
                }

                c.PartCars = partCars;

                cars.Add(c);
            }

            context.Cars.AddRange(cars);
            context.SaveChanges();

            return $"Successfully imported {cars.Count}";

        }

        private static XmlSerializer GenerateXmlSerializer(string RootName, Type dtoType)
        {
            XmlRootAttribute xmlRoot = new XmlRootAttribute(RootName);

            XmlSerializer xmlSerializer = new XmlSerializer(dtoType, xmlRoot);

            return xmlSerializer;

        }

        public static string ImportSuppliers(CarDealerContext context, string inputXml)
        {
            XmlRootAttribute xmlRoot = new XmlRootAttribute("Suppliers");

            XmlSerializer xmlSerializer = new XmlSerializer(typeof(ImportSupplierDto[]),xmlRoot);

            using StringReader stringRreader = new StringReader(inputXml);

            ImportSupplierDto[] dtos = (ImportSupplierDto[])xmlSerializer.Deserialize(stringRreader);

            ICollection<Supplier> suplers = new HashSet<Supplier>();

            foreach (var supplierDto in dtos)
            {
                Supplier s = new Supplier()
                {
                    Name = supplierDto.Name,
                    IsImporter = bool.Parse(supplierDto.IsImporter)
                };

                suplers.Add(s);
            }

            context.Suppliers.AddRange(suplers);
            context.SaveChanges();

            return $"Successfully imported {suplers.Count}";
        }

        public static string ImportParts(CarDealerContext context, string inputXml)
        {
            XmlRootAttribute xmlRoot = new XmlRootAttribute("Parts");

            XmlSerializer xmlSerializer = new XmlSerializer(typeof(ImportPartsDto[]), xmlRoot);

            using StringReader stringRreader = new StringReader(inputXml);

            ImportPartsDto[] dtos = (ImportPartsDto[])xmlSerializer.Deserialize(stringRreader);

            ICollection<Part> parts = new HashSet<Part>();

            foreach (var part in dtos)
            {
                Supplier suppier = context.Suppliers.Find(part.SupplierId);

                if (suppier==null)
                {
                    continue;
                }

                Part p = new Part()
                {
                    Name = part.Name,
                    Price = decimal.Parse(part.Price),
                    Quantity = int.Parse(part.Quantity),
                    Supplier = suppier

                };

                parts.Add(p);

            }

            context.Parts.AddRange(parts);

            context.SaveChanges();

            return $"Successfully imported {parts.Count}";
        }

        private static void ResetDb(CarDealerContext db)
        {
            db.Database.EnsureDeleted();
            db.Database.EnsureCreated();
            System.Console.WriteLine("Db reset!");
        }
    }
}