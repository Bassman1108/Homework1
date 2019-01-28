//Chad Simmons
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            double Cogs = 79.99;
            double Gears = 250;
            double TotalCogs = 0;
            double TotalGears = 0;
            const double floorMarkup = .15;
            const double otherMarkup = .125;
            const double salesTax = .089;

            Console.WriteLine("How many Cogs are in the sales order?");
            TotalCogs = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("How may Gears are in the sales order?");
            TotalGears = Convert.ToDouble(Console.ReadLine());

            double TotalShoes = TotalCogs + TotalGears;

            if (TotalCogs < 10 )
            {
               double TotalCogsPrice = TotalCogs* floorMarkup;
            }
            else if(TotalGears < 10)
            {
                double TotalGearsPrice = TotalGears * floorMarkup;
            }
            else if(TotalGears > 10)
            {
                double TotalGearsPrice = TotalGears * otherMarkup;
            }
            else if(TotalCogs > 10)
            {
                double TotalCogsPrice = TotalCogs * otherMarkup;
            }


        }
    }
}
