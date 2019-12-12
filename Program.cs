using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            var input = Console.ReadLine();
            Console.WriteLine("Hello {0}! Enter a number: ", input);
            //We need a loop and ask a user to enter a number
            var isRunning = true;
            var sum = 0;
            while (isRunning)
            {
                Console.WriteLine("Enter a number: ");
                input = Console.ReadLine();
                if (input == "ok")
                {

                    isRunning = false;

                } else
                {

                    var number = int.Parse(input);
                    sum += number;

                    //We need to add this number to an array
                    //Then we need to get all the numbers in the array and add them 


                }

               



            }
            //We need a place to store all the numbers the user  gives
            //Calculate and add up all the numbers
            //Display sum on Console\
            Console.WriteLine("Program has finished");
            Console.WriteLine(sum);

        }
    }
}
