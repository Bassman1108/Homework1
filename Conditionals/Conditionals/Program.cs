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
            double TotalCogsPrice = 0;
            double TotalGearsPrice = 0;

            if (TotalCogs > 16 && TotalGears > 16)
            {
                 TotalCogsPrice = TotalCogs * otherMarkup * salesTax;
                 TotalGearsPrice = TotalGears * otherMarkup * salesTax;
            }
            if (TotalCogs < 10 )
            {
                TotalCogsPrice = TotalCogs * floorMarkup * salesTax;
            }
            else if(TotalGears < 10)
            {
                 TotalGearsPrice = TotalGears * floorMarkup * salesTax;
            }
            else if(TotalGears > 10)
            {
                 TotalGearsPrice = TotalGears * otherMarkup * salesTax;
            }
            else if(TotalCogs > 10)
            {
                 TotalCogsPrice = TotalCogs * otherMarkup * salesTax;
            }

            double TotalSalesTax = 0;
            TotalCogsPrice += Cogs;
            TotalGearsPrice += Gears;
            double OverallDiscount = floorMarkup + otherMarkup;
            double TotalOverall = (TotalCogsPrice + TotalGearsPrice) * TotalSalesTax * OverallDiscount ;
             TotalSalesTax = TotalOverall * salesTax;
            double OverallbTax = TotalCogsPrice + TotalGearsPrice;
            

            Console.WriteLine("\t\t\t\t\t-----Reciept for Purchase-----");
            Console.WriteLine();

            Console.Write("\tThe Total before Tax is:\t\t\t\t\t ");
            Console.WriteLine(OverallbTax.ToString("C2"));

            Console.Write("\tThe Grand Total after Tax is:\t\t\t\t\t ");
            Console.WriteLine(TotalOverall.ToString("C2"));

            Console.Write("\tThe Total Discount is:\t\t\t\t\t\t ");
            Console.WriteLine(OverallDiscount.ToString("C2"));

            Console.Write("\tThe Total Sales Tax is:\t\t\t\t\t\t ");
            Console.WriteLine(TotalSalesTax.ToString("C2"));
            Console.WriteLine();

            Console.WriteLine("\tPress Enter to Continue...");
            Console.ReadKey();



        }
    }
}
