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
            double Total = 0;
            double average = 0;

            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine("Please enter you exam grade");
                ExamGrades = Convert.ToDouble(Console.ReadLine());


            }

                Total += ExamGrades;
                average = ExamGrades / Total;

                Console.WriteLine("The average for your combined exams is: ");
                Console.WriteLine(average.ToString("P2"));

            Console.ReadKey();
        }
    }
}
