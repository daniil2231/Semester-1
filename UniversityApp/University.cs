using System;
using System.Collections.Generic;

namespace UniversityApp
{
    public class University
    {
        private Grade[] grades = Enum.GetValues<Grade>();
        private List<StudentResult> studentResults;

        public University()
        {
            studentResults = new List<StudentResult>();
        }

        public void AddResult(string name, string grade)
        {
        }

        public Grade[] GetGradeOptions()
        {
            return grades;
        }

        public List<StudentResult> GetStudentResults()
        {
            return studentResults;
        }

        public string GetStatistics()
        {
            throw new NotImplementedException();
        }

        private double[] CalculateStatistics()
        {
            throw new NotImplementedException();
        }

        private double CountGrade(Grade grade)
        {
            throw new NotImplementedException();
        }
    }
}
