using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS285Project.Models
{
    public class StudentRecord
    {
        public string Name { get; set; }

        public double? Grade1 { get; set; }
        public double? Grade2 { get; set; }
        public double? Grade3 { get; set; }
        public double? Grade4 { get; set; }
        public double? Grade5 { get; set; }
        public double? Grade6 { get; set; }
        public double? Grade7 { get; set; }
        public double? Grade8 { get; set; }

        public string Notes { get; set; }

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
