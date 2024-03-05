using System.Globalization;

namespace assignment3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //culture
            CultureInfo ci = new CultureInfo("en-US");
            Thread.CurrentThread.CurrentUICulture = ci;
            Thread.CurrentThread.CurrentCulture = ci;

            //variables
            Console.WriteLine("Enter course name: ");
            string course = Console.ReadLine();
            Console.WriteLine("Enter number of students: ");
            int number = Convert.ToInt32(Console.ReadLine());
            double average = 0;
            int highestNumber = 0;
            string highestName = "";
            //arrays
            int[] grade = new int[number];
            string[] name = new string[number];

            //looping to store and fill arrays
            for (int i = 0; i < number; i++)
            {
                Console.WriteLine($"Enter name of student {i + 1}");
                name[i] = Console.ReadLine();
            }
            for (int i = 0; i < number; i++)
            {
                Console.WriteLine($"Enter grade of {name[i]}");
                grade[i] = Convert.ToInt32(Console.ReadLine());
                average += grade[i];    //adds every grade to the average
                if (grade[i] > highestNumber)
                {
                    highestNumber = grade[i];
                    highestName = name[i];
                }
            }
            average = average / number;
            Console.WriteLine($"average grade: {average:0.0}"); //gets the average
            Console.WriteLine($"Student {highestName} has highest grade: {highestNumber}");
            for (int i = 0; i < number; i++)
            {
                Console.WriteLine($"Grade for student {name[i]} (course {course}): {grade[i]}");
            }
        }
    }
}