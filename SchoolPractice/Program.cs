using System;

namespace SchoolPractice
{
    class Program
    {
        public static void Main(string[] args)
        {
            // TODO: Instantiate your objects and test your exercise solutions with print statements here.
            Student Toni = new Student("Toni", 1, 100, 4.0);
            Student Aaron = new Student("Aaron", 5, 4, 4.0);

            Console.WriteLine(Toni.GetGradeLevel());

            Toni.AddGrade(4, 4.0);
            Toni.AddGrade(4, 3.0);

            Console.WriteLine(Toni.Equals(Aaron));

            Console.WriteLine(Toni.ToString());

        }
    }
}
