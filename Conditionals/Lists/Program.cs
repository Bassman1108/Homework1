//Chad Simmons
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            double QuizGrades = 0;
            double average = 0;
            double total = 0;
            string answer = " ";
            //count// total+=quizgrades;
            while(answer == "yes")
            {
                Console.WriteLine("Please enter your first quiz grade Ex: (98)");
                QuizGrades = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Do you wish to input another quiz grade? (yes or no)");
                answer = Console.ReadLine();

                if(answer == "yes")
                {
                    Console.WriteLine("Please enter another quiz grade");
                    QuizGrades = Convert.ToDouble(Console.ReadLine());
                }
                else
                {

                }
            }
        }
    }
}
