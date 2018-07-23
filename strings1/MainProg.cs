using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace strings1
{
    class MainProg
    {


        static void Main(string[] args)
        {
            ReverseString rs = new ReverseString();

            Console.WriteLine("Instantiated projects.");
            bool continuing = true;
            
            while (continuing)
            {
                Console.WriteLine("Select: 1. String Reverser");
                int selection = Convert.ToInt32(Console.ReadLine());
                if(selection == 1)
                {
                    Console.WriteLine("Input string to reverse:");
                    string input = Console.ReadLine();
                    Console.WriteLine("Result: " + rs.reverse(input));
                }
                else
                {
                    Console.WriteLine("Invalid option");
                }
                Console.WriteLine("Do you wish to continue?");
                Console.WriteLine("1 to continue, 2 to stop.");
                int select2 = Convert.ToInt32(Console.ReadLine());
                if(select2 != 1)
                {
                    continuing = false;
                }
            }

        }

    }
}
