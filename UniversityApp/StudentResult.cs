using System;

namespace UniversityApp
{
    public class StudentResult
    {
        private string name;
        private Grade grade;

        public string GetName()
        {
            return this.name;
        }

        public Grade GetGrade()
        {
            return this.grade;
        }

        public string GetGradeLabel()
        {
            return this.grade.ToString();
        }

        public void SetName(string name)
        {
            this.name = name;
        }

        public void SetGrade(string grade)
        {
            this.grade = Enum.Parse<Grade>(grade);
        }
    }
}
