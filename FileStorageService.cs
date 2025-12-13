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
    /// <summary>
    /// Provides functionality for saving and loading student records
    /// to and from XML files.
    /// </summary>
    public class FileStorageService
    {
        /// <summary>
        /// Saves a list of student records to an XML file.
        /// </summary>
        /// <param name="filePath">The file path where the XML file will be saved.</param>
        /// <param name="students">The list of student records to save.</param>
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

        /// <summary>
        /// Loads student records from an XML file.
        /// </summary>
        /// <param name="filePath">The file path of the XML file to load.</param>
        /// <returns>A list of student records loaded from the file.</returns>
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

        /// <summary>
        /// Attempts to parse a string value into a nullable double.
        /// </summary>
        /// <param name="value">The string value to parse.</param>
        /// <returns>
        /// A nullable double containing the parsed value if successful;
        /// otherwise, null.
        /// </returns>
        private double? ParseNullableDouble(string value)
        {
            if (double.TryParse(value, out double d))
                return d;
            return null;
        }
    }
}
