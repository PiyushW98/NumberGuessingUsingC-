using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGuessingGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random x = new Random();

            int assume = x.Next(0, 100);
            //long assume = Convert.ToInt64(Console.ReadLine());

            bool check = false;

            do
            {
                Console.WriteLine("Guess the number between 0 to 100");
                long a = Convert.ToInt64(Console.ReadLine());

                if (a > assume)
                {
                    Console.WriteLine("The Number Guessed is high try lower");
                }
                else if (a < assume)
                {
                    Console.WriteLine("The number is low try higher");
                }
                else if (a == assume)
                {
                    Console.WriteLine("Hooray!! You have guessed Right");
                    check = true;
                }
                
            } while (check == false);
            Console.ReadLine();
        }
    }
}
