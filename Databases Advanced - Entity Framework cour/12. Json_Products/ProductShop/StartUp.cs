using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using ProductShop.Data;
using ProductShop.DTO.Input;
using ProductShop.DTO.Output;
using ProductShop.Models;

namespace ProductShop
{
    public class StartUp
    {
        private static IMapper mapper;

        public static void Main(string[] args)
        {
            var context = new ProductShopContext();

            //context.Database.EnsureDeleted();

            //context.Database.EnsureCreated();


            //string usersJsonAsString = File.ReadAllText("../../../Datasets/users.json");

            //Console.WriteLine(ImportUsers(context, usersJsonAsString));

            /////Next

            //string productsJsonAsString = File.ReadAllText("../../../Datasets/products.json");

            //Console.WriteLine(ImportProducts(context, productsJsonAsString));


            ////Next
            //string categoryJsonStrng = File.ReadAllText("../../../Datasets/categories.json");

            //Console.WriteLine(ImportCategories(context,categoryJsonStrng));

            /////Next
            //string categoryProductsString = File.ReadAllText("../../../Datasets/categories-products.json");

            //Console.WriteLine(ImportCategoryProducts(context, categoryProductsString));

            // Console.WriteLine(GetProductsInRange(context));

            Console.WriteLine(GetCategoriesByProductsCount(context));
        }

        public static string ImportUsers(ProductShopContext context, string inputJson)
        {
            IEnumerable<UserInputDto> users = JsonConvert.DeserializeObject<IEnumerable<UserInputDto>>(inputJson);

            InitializeMapper();

            IEnumerable<User> mappedusers = mapper.Map<IEnumerable<User>>(users);

            //IEnumerable<User> mappedusers = users
            //   .Select(x => x.MapToDomainUser())
            //   .ToList();

            context.Users.AddRange(mappedusers);

            context.SaveChanges();

            return $"Successfully imported {mappedusers.Count()}";
        }

        private static void InitializeMapper()
        {
            var MaperConfuguration = new MapperConfiguration(cnf =>
            {
                cnf.AddProfile<ProductShopProfile>();
            });

            mapper = new Mapper(MaperConfuguration);
        }

        public static string ImportProducts(ProductShopContext context, string inputJson)
        {
            IEnumerable<ProductInputDto> products = JsonConvert.DeserializeObject<IEnumerable<ProductInputDto>>(inputJson);

            InitializeMapper();

            IEnumerable<Product> mappeedProducts = mapper.Map<IEnumerable<Product>>(products);

            context.Products.AddRange(mappeedProducts);

            context.SaveChanges();

            return $"Successfully imported {mappeedProducts.Count()}";

        }


        public static string ImportCategories(ProductShopContext context, string inputJson)
        {
            IEnumerable<CategoriseInputDto> categoryes = JsonConvert.DeserializeObject<IEnumerable<CategoriseInputDto>>(inputJson)
                .Where(x => x.Name != null);

            InitializeMapper();

            IEnumerable<Category> mappeedCategories = mapper.Map<IEnumerable<Category>>(categoryes);

            context.Categories.AddRange(mappeedCategories);

            context.SaveChanges();

            return $"Successfully imported {mappeedCategories.Count()}";


        }

        public static string ImportCategoryProducts(ProductShopContext context, string inputJson)
        {
            IEnumerable<CategoryProductInputDto> categoryProducts = JsonConvert.DeserializeObject<IEnumerable<CategoryProductInputDto>>(inputJson);

            InitializeMapper();

            IEnumerable<CategoryProduct> mappedCategoryProducts = mapper.Map<IEnumerable<CategoryProduct>>(categoryProducts);

            context.CategoryProducts.AddRange(mappedCategoryProducts);

            context.SaveChanges();

            return $"Successfully imported {mappedCategoryProducts.Count()}";

        }


        public static string GetProductsInRange(ProductShopContext context)
        {
            InitializeMapper();

            var result = context.Products
                .Where(x => x.Price >= 500 && x.Price <= 1000)
                .OrderBy(x => x.Price)
                .ProjectTo<ProductsOutputDto>(mapper.ConfigurationProvider)
                //.Select(x => new UserOutputDto
                //{
                //    Name = x.Name,
                //    Price = x.Price,
                //    Seller = $"{x.Seller.FirstName} {x.Seller.LastName}"
                //})
                .ToList();

            //  var maperResult = Mapper.Map<IEnumerable< ProductsOutputDto>>(result);


            DefaultContractResolver contractResolver = new DefaultContractResolver
            {
                NamingStrategy = new CamelCaseNamingStrategy()
            };

            var JsonSettings = new JsonSerializerSettings
            {
                Formatting = Formatting.Indented,
                ContractResolver = contractResolver
            };

            string JsonResult = JsonConvert.SerializeObject(result, JsonSettings);

            return JsonResult;
        }


        public static string GetSoldProducts(ProductShopContext context)
        {
            var users = context
                .Users
                //.Include(a => a.ProductsSold)
                .Where(x => x.ProductsSold.Count()>0 && x.ProductsSold.Any(c => c.Buyer!=null))
                .OrderBy(x => x.LastName)
                .ThenBy(x => x.FirstName)
                .Select(x => new
                {
                    FirstName = x.FirstName,
                    LastName = x.LastName,
                    SoldProducts = x.ProductsSold.Where(c=>c.Buyer!=null)
                    .Select(p => new
                    {
                        Name = p.Name,
                        Price = p.Price,
                        BuyerFirstName = p.Buyer.FirstName,
                        BuyerLastName = p.Buyer.LastName
                    }).ToList()
                }).ToList();

            DefaultContractResolver contractResolver = new DefaultContractResolver
            {
                NamingStrategy = new CamelCaseNamingStrategy()
            };

            var JsonSettings = new JsonSerializerSettings
            {
                Formatting = Formatting.Indented,
                ContractResolver = contractResolver
            };

            string JsonResult = JsonConvert.SerializeObject(users, JsonSettings);

            return JsonResult;
        }


        public static string GetCategoriesByProductsCount(ProductShopContext context)
        {

            var categories = context.Categories
                .OrderByDescending(x => x.CategoryProducts.Count)
                .Select(x => new
                {
                    Category = x.Name,
                    ProductsCount = x.CategoryProducts.Count,
                    AvaragePrice = $"{(x.CategoryProducts.Sum(a => a.Product.Price))/x.CategoryProducts.Count:f2}",
                    TotalRevenues = $"{x.CategoryProducts.Sum(a => a.Product.Price):f2}"
                })
                .ToList();

            DefaultContractResolver contractResolver = new DefaultContractResolver
            {
                NamingStrategy = new CamelCaseNamingStrategy()
            };

            var JsonSettings = new JsonSerializerSettings
            {
                Formatting = Formatting.Indented,
                ContractResolver = contractResolver
            };

            string JsonResult = JsonConvert.SerializeObject(categories, JsonSettings);

            return JsonResult;
        }
    }



    public static class UserMappings

    {
        public static User MapToDomainUser(this UserInputDto userDto)
        {
            return new User
            {
                Age = userDto.Age,
                FirstName = userDto.FirstName,
                LastName = userDto.LastName


            };
        }


    }
}