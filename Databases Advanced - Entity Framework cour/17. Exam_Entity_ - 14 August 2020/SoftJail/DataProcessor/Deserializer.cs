namespace SoftJail.DataProcessor
{

    using Data;
    using Newtonsoft.Json;
    using SoftJail.Data.Models;
    using SoftJail.DataProcessor.ImportDto;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Globalization;
    using System.Text;

    public class Deserializer
    {
        public static string ImportDepartmentsCells(SoftJailDbContext context, string jsonString)
        {
            StringBuilder sb = new StringBuilder();

            ImportDepartmentDto[] departmentsDto = JsonConvert.DeserializeObject<ImportDepartmentDto[]>(jsonString);

            HashSet<Department> validdepartment = new HashSet<Department>();
        
            foreach (var department in departmentsDto)
            {
                HashSet<Cell> validCell = new HashSet<Cell>();

                bool isCellsValid = true;

                if (!IsValid(department))
                {
                    sb.AppendLine("Invalid Data");
                    continue;
                }

                
                foreach (var cell in department.Cells)
                {
                    if (!IsValid(cell))
                    {                     
                        isCellsValid = false;
                        continue;
                    }

                    Cell currentCell = new Cell()
                    {
                        CellNumber = cell.CellNumber,
                        HasWindow = cell.HasWindow
                    };

                    validCell.Add(currentCell);
                }

                Department currentDepartment = new Department()
                {
                    Name = department.Name,
                    Cells=validCell
                };

                if (!isCellsValid)
                {
                    sb.AppendLine("Invalid Data");
                    continue;
                }



                validdepartment.Add(currentDepartment);
                
                sb.AppendLine($"Imported {currentDepartment.Name} with {currentDepartment.Cells.Count} cells");

                context.Cells.AddRange(validCell);
            }

            context.Departments.AddRange(validdepartment);
            context.SaveChanges();

            return sb.ToString().TrimEnd();

        }

        public static string ImportPrisonersMails(SoftJailDbContext context, string jsonString)
        {
            StringBuilder sb = new StringBuilder();

            ImportPrisonersDto[] PrisonersDto = JsonConvert.DeserializeObject<ImportPrisonersDto[]>(jsonString);

            HashSet<Prisoner> validPersons = new HashSet<Prisoner>();

            foreach (var prisoner in PrisonersDto)
            {

                HashSet<Mail> validMails = new HashSet<Mail>();

                bool isValidMails = true;

                bool isValidIncarcerationDate = DateTime.TryParseExact
                (prisoner.IncarcerationDate, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime validIncarcarationDate);

                bool isReleaseDate = DateTime.TryParseExact
                 (prisoner.ReleaseDate, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime validReliseDate);

                DateTime? dddd = null;

                if (isReleaseDate==true)
                {
                    dddd = validReliseDate;
                }

                if (!IsValid(prisoner)|| !isValidIncarcerationDate)
                {
                    sb.AppendLine("Invalid Data");
                    continue;
                }


                foreach (var mail in prisoner.Mails)
                {

                    if (!IsValid(mail))
                    {
                        isValidMails = false;
                        continue;
                    }

                    Mail currentMail = new Mail()
                    {
                        Description = mail.Description,
                        Sender = mail.Sender,
                        Address = mail.Address
                    };

                    validMails.Add(currentMail);

                }

               

               

                Prisoner currentPrisoner = new Prisoner()
                {
                    FullName = prisoner.FullName,
                    Nickname = prisoner.Nickname,
                    Age = prisoner.Age,
                    IncarcerationDate = validIncarcarationDate,
                    ReleaseDate = dddd,
                    Bail = prisoner.Bail,
                    CellId = prisoner.CellId,
                    Mails = validMails

                };

                if (!isValidMails)
                {
                    sb.AppendLine("Invalid Data");
                    continue;
                }

                context.Mails.AddRange(validMails);

                validPersons.Add(currentPrisoner);

                sb.AppendLine($"Imported {currentPrisoner.FullName} {currentPrisoner.Age} years old");

            }

            context.Prisoners. AddRange(validPersons);

            context.SaveChanges();

            return sb.ToString().TrimEnd();


            //     "FullName": "",
            //"Nickname": "The Wallaby",
            //"Age": 32,
            //"IncarcerationDate": "29/03/1957",
            //"ReleaseDate": "27/03/2006",
            //"Bail": null,
            //"CellId": 5,
            //"Mails": [
            //  {
            //    "Description": "Invalid FullName",
            //    "Sender": "Invalid Sender",
            //    "Address": "No Address"
            //  },
            //  {
            //    "Description": "Do not put this in your code",
            //    "Sender": "My Ansell",
            //    "Address": "ha-ha-ha"
        }



        public static string ImportOfficersPrisoners(SoftJailDbContext context, string xmlString)
        {
            throw new NotImplementedException();
        }

        private static bool IsValid(object obj)
        {
            var validationContext = new System.ComponentModel.DataAnnotations.ValidationContext(obj);
            var validationResult = new List<ValidationResult>();

            bool isValid = Validator.TryValidateObject(obj, validationContext, validationResult, true);
            return isValid;
        }
    }
}