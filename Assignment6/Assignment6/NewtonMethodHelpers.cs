﻿namespace Assignment6
{
    internal static class NewtonMethodHelpers
    {
        public static double Sqrt(int Count3, double Num5)
        {
            double Root;

            double x = Num5; //assuming root value is num
            double n = 0.00001; //a
            while (true)
            {
                Count3++;
                //calculate more closed x
                Root = 0.5 * (x + Num5 / x);
                if (Math.Abs(Root - x) < n)
                {
                    Console.WriteLine("Squareroot of " + Num5 + " is " + Root);
                    break;
                }
                x = Root;
            }
            return Root;

        }
    }
}