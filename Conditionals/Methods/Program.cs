//Chad Simmons
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number to factor");
            int num = Convert.ToInt32(Console.ReadLine());

            int factor = Factorial(num);

            Console.WriteLine($"The factorial for {num} is {factor}");

            Console.WriteLine("Press Enter to Continue...");
            Console.ReadLine();
        }
        static double LineValueForY (double m, double x, double b)
        {
            double formulaY = (m) * x + b;
            return formulaY;
        }
        static int Factorial (int factor)
        {
            int answer = 0;

            for (int i = 0; i <= factor; i--)
            {
                answer = answer * i;
            }
            return answer;

            
        }
    }
}
