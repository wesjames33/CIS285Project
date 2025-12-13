using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS285Project.Models
{
    /// <summary>
    /// Manages a collection of student records and provides
    /// methods for modifying students and calculating class statistics.
    /// </summary>
    public class GradeBook
    {
        /// <summary>
        /// Gets the list of students in the grade book.
        /// </summary>
        public List<StudentRecord> Students { get; private set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="GradeBook"/> class.
        /// </summary>
        public GradeBook()
        {
            Students = new List<StudentRecord>();
        }

        /// <summary>
        /// Adds a new student to the grade book.
        /// </summary>
        /// <param name="s">The student record to add.</param>
        public void AddStudent(StudentRecord s) => Students.Add(s);

        /// <summary>
        /// Updates an existing student at the specified index.
        /// </summary>
        /// <param name="index">The index of the student to update.</param>
        /// <param name="s">The updated student record.</param>
        public void UpdateStudent(int index, StudentRecord s)
        {
            if (index >= 0 && index < Students.Count)
                Students[index] = s;
        }

        /// <summary>
        /// Removes a student from the grade book at the specified index.
        /// </summary>
        /// <param name="index">The index of the student to remove.</param>
        public void RemoveStudent(int index)
        {
            if (index >= 0 && index < Students.Count)
                Students.RemoveAt(index);
        }

        /// <summary>
        /// Calculates the average grade across all students.
        /// </summary>
        /// <returns>The class average.</returns>
        public double CalculateClassAverage()
        {
            if (Students.Count == 0)
                return 0;

            return Students.Average(s => s.Average);
        }
    }
}
