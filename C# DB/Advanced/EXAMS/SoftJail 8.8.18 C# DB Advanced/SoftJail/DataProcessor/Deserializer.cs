namespace SoftJail.DataProcessor
{
    using AutoMapper;
    using Data;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using SoftJail.Data.Models;
    using SoftJail.DataProcessor.ExportDto;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Text;

    public class Deserializer
    {
        private const string FailureMessage = "Invalid Data";

        public static string ImportDepartmentsCells(SoftJailDbContext context, string jsonString)
        {
            var deserializedDepartments = JsonConvert.DeserializeObject<DepartmentDTO[]>(jsonString);
            var validDepartments = new List<Department>();
            var validCells = new List<Cell>();
            var sb = new StringBuilder();
            foreach (var dto in deserializedDepartments)
            {

                bool departmentIsValid = IsValid(dto);

                var cellsAreValid = true;

                if (departmentIsValid)
                {
                    foreach (var cell in dto.Cells)
                    {
                        if (!IsValid(cell))
                        {
                            cellsAreValid = false;
                            continue;
                        }
                    }
                }

                if (!departmentIsValid || !cellsAreValid)
                {
                    sb.AppendLine(FailureMessage);
                    continue;
                }

                validDepartments.Add(dto);
                validCells.AddRange(dto.Cells);
                context.Cells.AddRange(validCells);

                sb.AppendLine(String.Format("Imported {0} with {1} cells", dto.Name, dto.Cells.Count));
            }
            context.Departments.AddRange(validDepartments);
            context.SaveChanges();

            string result = sb.ToString().TrimEnd();
            return result;
        }

        public static string ImportPrisonersMails(SoftJailDbContext context, string jsonString)
        {
            var format = "dd/MM/yyyy"; // your datetime format
            var dateTimeConverter = new IsoDateTimeConverter { DateTimeFormat = format };

            var deserializedPrisoners = JsonConvert.DeserializeObject<PrisonerDTO[]>(jsonString, dateTimeConverter);
            var validPrisoners = new List<Prisoner>();
            var validMails = new List<Mail>();
            var sb = new StringBuilder();
            foreach (var dto in deserializedPrisoners)
            {
                bool prisonerIsValid = IsValid(dto);

                var mailsAreValid = true;

                if (prisonerIsValid)
                {
                    foreach (var mail in dto.Mails)
                    {
                        if (!IsValid(mail))
                        {
                            mailsAreValid = false;
                            continue;
                        }
                    }
                }

                if (!prisonerIsValid || !mailsAreValid)
                {
                    sb.AppendLine(FailureMessage);
                    continue;
                }

                validPrisoners.Add(dto);
                validMails.AddRange(dto.Mails);
                context.Mails.AddRange(validMails);

                sb.AppendLine(String.Format("Imported {0} with {1} cells", dto.FullName, dto.Age));
            }
            context.Prisoners.AddRange(validPrisoners);
            context.SaveChanges();

            string result = sb.ToString().TrimEnd();
            return result;
        }

        public static string ImportOfficersPrisoners(SoftJailDbContext context, string xmlString)
        {
            throw new NotImplementedException();
        }

        private static bool IsValid(object obj)
        {
            var validationContext = new System.ComponentModel.DataAnnotations.ValidationContext(obj);
            var validationResults = new List<ValidationResult>();

            var isValid = Validator.TryValidateObject(obj, validationContext, validationResults, true);

            return isValid;
        }
    }
}