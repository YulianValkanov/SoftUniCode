namespace Theatre.DataProcessor
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Globalization;
    using System.IO;
    using System.Text;
    using System.Xml.Serialization;
    using Theatre.Data;
    using Theatre.Data.Models;
    using Theatre.Data.Models.Enums;
    using Theatre.DataProcessor.ImportDto;

    public class Deserializer
    {
        private const string ErrorMessage = "Invalid data!";

        private const string SuccessfulImportPlay
            = "Successfully imported {0} with genre {1} and a rating of {2}!";

        private const string SuccessfulImportActor
            = "Successfully imported actor {0} as a {1} character!";

        private const string SuccessfulImportTheatre
            = "Successfully imported theatre {0} with #{1} tickets!";

        public static string ImportPlays(TheatreContext context, string xmlString)
        {
            StringBuilder sb = new StringBuilder();

            XmlRootAttribute xmlRoot = new XmlRootAttribute("Plays");

            XmlSerializer xmlSerializer = new XmlSerializer(typeof(ImportPlayersDto[]), xmlRoot);

            using StringReader sr = new StringReader(xmlString);

            ImportPlayersDto[] playersDto = (ImportPlayersDto[])xmlSerializer.Deserialize(sr);

            HashSet<Play> validPlayers = new HashSet<Play>();

            foreach (var players in playersDto)
            {
                if (!IsValid(players))
                {
                    sb.AppendLine("Invalid data!");
                    continue;
                }

                //  TimeSpan duratin = TimeSpan.Parse(players.Duration);

               bool isValidDuration= TimeSpan.TryParseExact(players.Duration, "c", CultureInfo.CurrentCulture, out TimeSpan validDuration);

                if (!isValidDuration || validDuration.Hours<1)
                {
                    sb.AppendLine("Invalid data!");
                    continue;
                }

                bool isValidType = Enum.TryParse<Genre>(players.Genre, out Genre validGenreType);

                if (!isValidType)
                {
                    sb.AppendLine("Invalid data!");
                    continue;
                }

                Play play = new Play()
                {
                    Title = players.Title,
                    Duration= validDuration,
                    Rating=players.Rating,
                    Genre= validGenreType,
                    Description=players.Description,
                    Screenwriter=players.Screenwriter

                };

                
                validPlayers.Add(play);
                sb.AppendLine($"Successfully imported {play.Title} with genre {play.Genre} and a rating of {play.Rating}!");

                //  <Title>The Hsdfoming</Title>
                //  <Duration>03:40:00</Duration>
                //  <Rating>8.2</Rating>
                //  <Genre>Action</Genre>
                //  <Description>A guyat Pinter turns into a debatable conundrum as oth ordinary and menacing.
                //Much of this has to do with the fabled Pinter Pause, which simply mirrors the way we often 
                //respond to each other in conversation, tossing in remainders of thoughts on one subject well after having moved on to another.</Description>

                //  <Screenwriter>Roger Nciotti</Screenwriter>
           
            }

            context.AddRange(validPlayers);

            context.SaveChanges();

            return sb.ToString().TrimEnd();


        }

        public static string ImportCasts(TheatreContext context, string xmlString)
        {
            StringBuilder sb = new StringBuilder();

            XmlRootAttribute xmlRoot = new XmlRootAttribute("Casts");

            XmlSerializer xmlSerializer = new XmlSerializer(typeof(ImportCastDto[]), xmlRoot);

            using StringReader sr = new StringReader(xmlString);

            ImportCastDto[] castDto = (ImportCastDto[])xmlSerializer.Deserialize(sr);

            HashSet<Cast> validCast = new HashSet<Cast>();

            foreach (var cast in castDto)
            {

                if (!IsValid(cast))
                {
                    sb.AppendLine("Invalid data!");
                    continue;
                }


                Cast currentCst = new Cast()
                {
                    FullName=cast.FullName,
                    IsMainCharacter=cast.IsMainCharacter,
                    PhoneNumber=cast.PhoneNumber,
                    PlayId=cast.PlayId
                };

                string mainLasserRole = "";
                if (currentCst.IsMainCharacter==true)
                {
                    mainLasserRole = "main";
                }
                else
                {
                    mainLasserRole = "lesser";
                }

                validCast.Add(currentCst);
                sb.AppendLine($"Successfully imported actor {currentCst.FullName} as a {mainLasserRole} character!");

            }

            context.Casts.AddRange(validCast);

            context.SaveChanges();

            return sb.ToString().TrimEnd();

            //  <Casts>
            //<Cast>
            //  <FullName>Van Tyson</FullName>
            //  <IsMainCharacter>false</IsMainCharacter>

            //  <PhoneNumber>+44-35-745-2774</PhoneNumber>

            //  <PlayId>26</PlayId>
            //</Cast>
        }

        public static string ImportTtheatersTickets(TheatreContext context, string jsonString)
        {
            StringBuilder sb = new StringBuilder();

            ImportTheatresDto[] theatreDto = JsonConvert.DeserializeObject<ImportTheatresDto[]>(jsonString);

            HashSet<Theatre> validTheatres = new HashSet<Theatre>();

            foreach (var theatre in theatreDto)
            {
                HashSet<Ticket> validTicket = new HashSet<Ticket>();


                if (!IsValid(theatre))
                {
                    sb.AppendLine("Invalid data!");
                    continue;
                }


                foreach (var ticket in theatre.Tickets)
                {

                    if (!IsValid(ticket))
                    {
                        sb.AppendLine("Invalid data!");
                        continue;
                    }

                    Ticket currentTicket = new Ticket()
                    {
                        Price=ticket.Price,
                        RowNumber=ticket.RowNumber,
                        PlayId=ticket.PlayId

                    };
                    //                "Price": 7.63,
                    ////    "RowNumber": 5,
                    ////    "PlayId": 4
                    ///
                    validTicket.Add(currentTicket);
                }

                Theatre currentTheatre = new Theatre()
                {
                    Name = theatre.Name,
                    NumberOfHalls = theatre.NumberOfHalls,
                    Director = theatre.Director,
                    Tickets = validTicket
                };

                // "Name": "",
                //"NumberOfHalls": 7,
                //"Director": "Ulwin Mabosty",
                //"Tickets": 

                validTheatres.Add(currentTheatre);

                context.Tickets.AddRange(validTicket);

                sb.AppendLine($"Successfully imported theatre {currentTheatre.Name} with #{currentTheatre.Tickets.Count} tickets!");
            }

            context.AddRange(validTheatres);

            context.SaveChanges();

            return sb.ToString().TrimEnd();
        }


        private static bool IsValid(object obj)
        {
            var validator = new ValidationContext(obj);
            var validationRes = new List<ValidationResult>();

            var result = Validator.TryValidateObject(obj, validator, validationRes, true);
            return result;
        }
    }
}
