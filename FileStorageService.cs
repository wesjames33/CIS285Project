using CIS285Project.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace CIS285Project.Services
{
    public class FileStorageService
    {
        public void Save(string filePath, List<StudentRecord> students)
        {
            var doc = new XDocument(
                new XElement("Students",
                    students.Select(s =>
                        new XElement("Student",
                            new XAttribute("Name", s.Name ?? ""),
                            new XAttribute("Grade1", s.Grade1?.ToString() ?? ""),
                            new XAttribute("Grade2", s.Grade2?.ToString() ?? ""),
                            new XAttribute("Grade3", s.Grade3?.ToString() ?? ""),
                            new XAttribute("Grade4", s.Grade4?.ToString() ?? ""),
                            new XAttribute("Grade5", s.Grade5?.ToString() ?? ""),
                            new XAttribute("Grade6", s.Grade6?.ToString() ?? ""),
                            new XAttribute("Grade7", s.Grade7?.ToString() ?? ""),
                            new XAttribute("Grade8", s.Grade8?.ToString() ?? ""),
                            new XElement("Notes", s.Notes ?? "")
                        )
                    )
                )
            );

            doc.Save(filePath);
        }

        public List<StudentRecord> Load(string filePath)
        {
            var result = new List<StudentRecord>();

            if (!File.Exists(filePath))
                return result;

            var doc = XDocument.Load(filePath);
            foreach (var elem in doc.Root.Elements("Student"))
            {
                var s = new StudentRecord
                {
                    Name = (string)elem.Attribute("Name")
                };

                s.Grade1 = ParseNullableDouble((string)elem.Attribute("Grade1"));
                s.Grade2 = ParseNullableDouble((string)elem.Attribute("Grade2"));
                s.Grade3 = ParseNullableDouble((string)elem.Attribute("Grade3"));
                s.Grade4 = ParseNullableDouble((string)elem.Attribute("Grade4"));
                s.Grade5 = ParseNullableDouble((string)elem.Attribute("Grade5"));
                s.Grade6 = ParseNullableDouble((string)elem.Attribute("Grade6"));
                s.Grade7 = ParseNullableDouble((string)elem.Attribute("Grade7"));
                s.Grade8 = ParseNullableDouble((string)elem.Attribute("Grade8"));

                s.Notes = (string)elem.Element("Notes") ?? "";

                result.Add(s);
            }

            return result;
        }

        private double? ParseNullableDouble(string value)
        {
            if (double.TryParse(value, out double d))
                return d;
            return null;
        }
    }
}
