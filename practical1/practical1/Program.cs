using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practical1
{
    public class Student
    {
        private int number;
        private string name;
        private string course;
        private int semester;
        private double fees;

        // Constructor
        public Student(int num, string n, string c, int sem, double f)
        {
            number = num;
            name = n;
            course = c;
            semester = sem;
            fees = f;
        }

        // Scholarship Method
        public void Scholarship()
        {
            double percentage;

            Console.Write("\nEnter Student Percentage: ");
            percentage = Convert.ToDouble(Console.ReadLine());

            if (percentage >= 75)
            {
                Console.WriteLine("Congratulations! Student is eligible for Scholarship.");

                // 20% fee discount
                fees = fees - (fees * 20 / 100);

                Console.WriteLine("Updated Fees after Scholarship: " + fees);
            }
            else
            {
                Console.WriteLine("Student is NOT eligible for Scholarship.");
                Console.WriteLine("Fees remains: " + fees);
            }
        }

        // Display Method
        public void Display()
        {
            Console.WriteLine("\n------ Student Admission Details ------");
            Console.WriteLine("Student Number : " + number);
            Console.WriteLine("Student Name   : " + name);
            Console.WriteLine("Course         : " + course);
            Console.WriteLine("Semester       : " + semester);
            Console.WriteLine("Fees           : " + fees);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            int number, semester;
            string name, course;
            double fees;

            Console.Write("Enter Student Number: ");
            number = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Student Name: ");
            name = Console.ReadLine();

            Console.Write("Enter Course: ");
            course = Console.ReadLine();

            Console.Write("Enter Semester: ");
            semester = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Fees: ");
            fees = Convert.ToDouble(Console.ReadLine());

            // Constructor
            Student s1 = new Student(number, name, course, semester, fees);

            // Scholarship Check
            s1.Scholarship();

            // Display Final Details
            s1.Display();

            Console.ReadKey();
        }
    }
}
