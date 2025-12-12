using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS285Project.Models
{
    public class GradeBook
    {
        public List<StudentRecord> Students { get; private set; }

        public GradeBook()
        {
            Students = new List<StudentRecord>();
        }

        public void AddStudent(StudentRecord s) => Students.Add(s);

        public void UpdateStudent(int index, StudentRecord s)
        {
            if (index >= 0 && index < Students.Count)
                Students[index] = s;
        }

        public void RemoveStudent(int index)
        {
            if (index >= 0 && index < Students.Count)
                Students.RemoveAt(index);
        }

        public double CalculateClassAverage()
        {
            if (Students.Count == 0)
                return 0;

            return Students.Average(s => s.Average);
        }
    }
}
