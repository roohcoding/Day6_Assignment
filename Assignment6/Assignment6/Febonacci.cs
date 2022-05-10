using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6
{
    internal class Febonacci
    {
        public static void Febonaci()
        {
            Console.Write("Please enter the Length of the Fibonacci Series : ");
            int number = int.Parse(Console.ReadLine());
            FibonacciSeries(0, 1, 1, number);
            Console.ReadKey();
        }
        public static void FibonacciSeries(int firstNumber, int secondNumber, int counter, int number)
        {
            Console.Write(firstNumber + " ");
            if (counter < number)
            {
                FibonacciSeries(secondNumber, firstNumber + secondNumber, counter + 1, number);
            }
        }
    }
}
