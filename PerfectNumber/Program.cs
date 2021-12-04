using System;

namespace PerfectNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int perfectNumber = 0;
            Console.WriteLine("enter the number");
            int number = Convert.ToInt32(Console.ReadLine());
            // take input from user;
            for(int i = 1; i <= number/2; i++)
            {
                if(number % 2 == 0)
                {
                    perfectNumber += i;
                }
                if(number == perfectNumber)
                {
                    Console.WriteLine("{0} number is Perfect number", number);

                }
              
            }
           

        }
    }
}
