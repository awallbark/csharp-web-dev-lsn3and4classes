using System;

namespace SchoolPractice
{
    class Program
    {
        public static void Main(string[] args)
        {
            // TODO: Instantiate your objects and test your exercise solutions with print statements here.
            Student Toni = new Student("Toni", 1, 100, 4.0);

            Console.WriteLine(Toni.GetGradeLevel());

            Toni.NumberOfCredits = 40;

            Console.WriteLine(Toni.GetGradeLevel());
        }
    }
}
