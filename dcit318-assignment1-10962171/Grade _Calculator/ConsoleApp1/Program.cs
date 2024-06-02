using System;
namespace GradeCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ask for user's score
            Console.WriteLine("Please enter your score out of 100:");
            int score = Convert.ToInt32(Console.ReadLine());

            // Grading system
            char grade;
            if (score >= 90)
            {
                grade = 'A';
            }
            else if (score >= 80)
            {
                grade = 'B';
            }
            else if (score >= 70)
            {
                grade = 'C';
            }
            else if (score >= 60)
            {
                grade = 'D';
            }
            else
            {
                grade = 'F';
            }

            // Output grade obtained
            Console.WriteLine($"You got a/an: {grade}");

            // Wait for user input before closing the console window
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
