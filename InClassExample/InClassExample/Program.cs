﻿// Clay Sullivan
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InClassExample
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1, num2, num3;
            num1 = 28;
            num2 = 482.2;
            num3 = 382.222;
                double result = Add(5, 17.5);

            Console.WriteLine($"5 + 17.5 = {result.ToString("N2")}");
            result = Add(num1, num2);
            Console.WriteLine($"{num1} + {num2} = {result}");
            double[] nums = { num1, num2, num3 };




            Console.ReadKey();

        }
        static double Add(double[] numberToAddUp)
        {
            double r = 0;
            int counter = 0;
            while (counter < numberToAddUp.Length)
            {
                var number = numberToAddUp[counter];
                r += number;
            }
            for (counter = 0; counter < numberToAddUp.Length; counter++)
            {
                var number = numberToAddUp[counter];
                r += number;
            }
            foreach(var number in numberToAddUp)
            {
                r += number;
            }
            return r;
            
        }
        

        /// <summary>
        /// Sums up two numbers
        /// </summary>
        /// <param name="val1"></param>
        /// <param name="val2"></param>
        /// <returns></returns>
        static double Add(double val1, double val2)
        {
            double sum = val1 + val2;
            return sum;
            
        }
            
    }
}
