using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS285Project.Models
{
    /// <summary>
    /// Represents a student record containing the student's name,
    /// grades, notes, and calculated average.
    /// </summary>
    public class StudentRecord
    {
        /// <summary>
        /// The student's full name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>First grade.</summary>
        public double? Grade1 { get; set; }

        /// <summary>Second grade.</summary>
        public double? Grade2 { get; set; }

        /// <summary>Third grade.</summary>
        public double? Grade3 { get; set; }

        /// <summary>Fourth grade.</summary>
        public double? Grade4 { get; set; }

        /// <summary>Fifth grade.</summary>
        public double? Grade5 { get; set; }

        /// <summary>Sixth grade.</summary>
        public double? Grade6 { get; set; }

        /// <summary>Seventh grade.</summary>
        public double? Grade7 { get; set; }

        /// <summary>Eighth grade.</summary>
        public double? Grade8 { get; set; }

        /// <summary>
        /// Optional notes associated with the student.
        /// </summary>
        public string Notes { get; set; }

        /// <summary>
        /// Calculates the student's average grade based on all
        /// non-null grade values.
        /// </summary>
        public double Average
        {
            get
            {
                var grades = new double?[]
                {
                    Grade1, Grade2, Grade3, Grade4,
                    Grade5, Grade6, Grade7, Grade8
                };

                var valid = grades.Where(g => g.HasValue).Select(g => g.Value);
                return valid.Any() ? valid.Average() : 0;
            }
        }
    }
}
