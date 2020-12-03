using System;

namespace Assignment_Pop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first name of the student");
            string firstName = Convert.ToString(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Enter the last name of the student");
            string lastName = Convert.ToString(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Enter the student number");
            string studentNumber = Convert.ToString(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Enter the age of the student");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Enter the number of the street");
            int adress = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the street");
            string street = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter the city");
            string city = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter the country");
            string country = Convert.ToString(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("How much grade have " + firstName);
            int length = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            int[] scores = new int[length];
            int grade;
            int sumGrades = 0;
            for (int i = 0; i < length; i++)
            {
                Console.WriteLine("Enter a grade");
                grade = Convert.ToInt32(Console.ReadLine());
                scores[i] = grade;
                sumGrades = sumGrades + grade;
                Console.Clear();
            }
            double average = sumGrades / scores.Length;
            Address address = new Address(adress, street, city, country);
            Student student = new Student(firstName, lastName, studentNumber, age, address, "", scores, average, "");
            Console.WriteLine("Student " + student.fullName + " score is " + student.average);
            Console.WriteLine("Student " + student.fullName + " is living in " + student.address.city);
            Console.WriteLine("Student " + student.fullName + " adress is " + student.fullAddress);
            Console.WriteLine();
            Console.WriteLine(student.ToString());
        }
    }
}
