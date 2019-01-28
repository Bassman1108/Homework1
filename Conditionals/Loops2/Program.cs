//Chad Simmons
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops2
{
    class Program
    {
        static void Main(string[] args)
        {
            double ExamScore = 0;
            double count = 0;
            double total = 0;
            string question = " ";
            Console.WriteLine("Please enter your Exam Score");
            ExamScore = Convert.ToDouble(Console.ReadLine());
            //figure out counter and accumulater
            do
            {
                Console.WriteLine("Do you have another score to enter? (yes or no)");
                question = Convert.ToString(Console.ReadLine());

                if (question == "yes")
                {
                    Console.WriteLine("Please enter another Exam Score");
                }
                else
                {

                }
            } while (question != "no");
        }
    }
}
