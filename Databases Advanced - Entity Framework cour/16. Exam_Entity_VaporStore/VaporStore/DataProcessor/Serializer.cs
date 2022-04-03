namespace VaporStore.DataProcessor
{
    using System;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Xml.Serialization;
    using Data;
    using Microsoft.EntityFrameworkCore;
    using Newtonsoft.Json;
    using VaporStore.DataProcessor.Dto.Export;

    public static class Serializer
    {
        public static string ExportGamesByGenres(VaporStoreDbContext context, string[] genreNames)
        {
            var genre = context.Genres
                .Where(x => genreNames.Contains(x.Name))
                .ToArray()
                .Select(g => new
                {
                    Id = g.Id,
                    Genre = g.Name,
                    Games = g.Games
                    .Where(x => x.Purchases.Count > 0)
                    .Select(x => new
                    {
                        Id = x.Id,
                        Title = x.Name,
                        Developer = x.Developer.Name,
                        Tags = string.Join(", ", x.GameTags.Select(t => t.Tag.Name)),
                        Players = x.Purchases.Count

                    })
                    .OrderByDescending(x => x.Players)
                    .ThenBy(x => x.Id),
                    TotalPlayers = g.Games.Sum(x => x.Purchases.Count)

                })
                .OrderByDescending(x => x.TotalPlayers)
                .ThenBy(x => x.Id)
                .ToArray();



            //	"Id": 4,
            //"Genre": "Violent",
            //"Games": [
            //  {
            //    "Id": 49,
            //    "Title": "Warframe",
            //    "Developer": "Digital Extremes",
            //    "Tags": "Single-player, In-App Purchases, Steam Trading Cards, Co-op, Multi-player, Partial Controller Support",
            //    "Players": 6


            string json = JsonConvert.SerializeObject(genre, Formatting.Indented);

            return json;
        }

        public static string ExportUserPurchasesByType(VaporStoreDbContext context, string storeType)
        {
            StringBuilder sb = new StringBuilder();

            XmlRootAttribute xmlRoot = new XmlRootAttribute("Users");

            XmlSerializerNamespaces namespaces = new XmlSerializerNamespaces();

            namespaces.Add(string.Empty, string.Empty);

            XmlSerializer xmlSerializer = new XmlSerializer(typeof(ExportUsers[]), xmlRoot);

            using StringWriter sw = new StringWriter(sb);

            ExportUsers[] users = context
                .Users
               .ToArray()
               .Where(x => x.Cards.Any(c => c.Purchases.Count() > 0))
                .Select(p => new ExportUsers()
                {
                    Username = p.Username,
                    Purchases = p.Cards
                   
                    .Where(x => x.Type.ToString() == storeType)
                   .Select(x => new ExportPurchases()
                   {
                       Card = x.Number,
                       Cvc = x.Cvc,
                       Date = x.Purchases.Select(x => x.Date).ToString(),
                       Game = x.Purchases
                       .Select(p => new ExportGame
                       {
                           Title = p.Game.Name,
                           Genre = p.Game.Genre.Name,
                           Price = p.Game.Price.ToString()
                       })
                      
                       .ToArray()


                   }).ToArray(),
                   
                   // TotalSpent = decimal.Parse(p.Cards.Select(x => x.Purchases.Sum(a => a.Game.Price)).ToString())
                })
              //  .OrderByDescending(x=>x.TotalSpent)
              //  .ThenBy(x=>x.Username)
                .ToArray();



            //    TasksCount = p.Tasks.Count,
            //    HasEndDate = p.DueDate.HasValue ? "Yes" : "No",
            //    Tasks = p.Tasks
            //    .Select(t => new ExportProjectTaskDto()
            //    {

            //        Name = t.Name,
            //        LabelString = t.LabelType.ToString()
            //    })
            //    .OrderBy(t => t.Name)
            //    .ToArray()
            //})
            //.OrderByDescending(p => p.TasksCount)
            //.ThenBy(p => p.Name)
            //.ToArray();


            xmlSerializer.Serialize(sw, users, namespaces);

            return sb.ToString().Trim();
        }
    }
}