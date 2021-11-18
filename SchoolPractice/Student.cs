using System;

// Start working here with your Student class.
// To instantiate the Student class, add your code to the Main method in Program

namespace SchoolPractice
{
    public class Student
    {
        private static int nextStudentId = 1;
        public string Name { get; set; }
        public readonly int studentId;
        public int NumberOfCredits { get; set; }
        public double Gpa { get; set; }

        public Student(string name, int sId, int numberOfCredits, double gpa)
        {
            Name = name;
            studentId = sId;
            NumberOfCredits = numberOfCredits;
            Gpa = gpa;
        }

        public Student(string name, int sId)
        {
            Name = name;
            studentId = sId;
            NumberOfCredits = 0;
            Gpa = 0.0;
        }

        public Student(string name)
        {
            Name = name;
            studentId = nextStudentId;
            nextStudentId++;
            NumberOfCredits = 0;
            Gpa = 0.0;
        }

        public string StudentInfo()
        {
            return (Name + " has a GPA of: " + Gpa);
        }

        public void AddGrade(int courseCredits, double grade)
        {
           
            double currentQualityScore = Gpa * NumberOfCredits;
            double totalQualityScore = (courseCredits * grade) + currentQualityScore;
            double totalNumberofCredits = this.NumberOfCredits + courseCredits;
            double newGpa = Math.Round((totalQualityScore / totalNumberofCredits), 2);

            Console.WriteLine(newGpa);

        }

        public string GetGradeLevel()
        {
            // Determine the grade level of the student based on NumberOfCredits
            if (NumberOfCredits <= 29)
            {
                return "Freshman";
            }
            else if (NumberOfCredits == 30 || NumberOfCredits <= 59)
            {
                return "Sophmore";
            }
            else if (NumberOfCredits == 60 || NumberOfCredits <= 89)
            {
                return "Junior";
            }
            else return "Senior";
        }

        public override bool Equals(object obj)
        {
            //Reference Check
            if (obj == this)
            {
                return true;
            }
            //Null check
            if (obj == null)
            {
                return false;
            }
            //Class check
            if (obj.GetType() != this.GetType())
            {
                return false;
            }
            //Cast
            Student s = obj as Student;

            //Comparison
            return obj is Student student &&
                   studentId == student.studentId;
        }
    }

}
