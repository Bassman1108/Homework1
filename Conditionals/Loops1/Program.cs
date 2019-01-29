//Chad Simmons
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops1
{
    class Program
    {
        static void Main(string[] args)
        {
            double ExamGrades = 0;
            double Total = 300;
            double average = 0;

            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine("Please enter you exam grade");
                ExamGrades = Convert.ToDouble(Console.ReadLine());


            }

                ExamGrades += ExamGrades;
                average = ExamGrades / Total;
            //Not Averaging out correctly

            Console.Write("The average for your combined exams is: ");
            Console.WriteLine(average.ToString("P2"));
            Console.WriteLine();
            Console.WriteLine("Press Enter to Continue...");
            Console.ReadKey();
        }
    }
}
