using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExponentsPowersTableLab
{
    internal class Program
    {
        static void Main(string[] args)

        {


            bool restart = true;
            do

            {
                Console.WriteLine("Please enter an integer.\n");
                int num1 = int.Parse(Console.ReadLine());

                bool restartneg = true;
                if (num1 <= 0) 
                    Console.WriteLine("number must be positive");

                Console.WriteLine("" +
                "Number\t\tSquared\t\tCubed\n" +
                "=======\t\t=======\t\t=======\n");
                for (int x = 1; x <= num1; x++)
                {
                    Console.WriteLine("" +
                        x + "\t\t" + (x + x) + "\t\t" + (x * x * x));
                }
                Console.WriteLine("Would you like to enter another number? ");
                string choice = Console.ReadLine().ToLower().Trim();
                if (choice == "y" || choice == "yes")
                {
                    restart = true;
                }
                else
                {
                    restart = false;
                }
                

            }


            while(restart);

           




        }
    }
}
