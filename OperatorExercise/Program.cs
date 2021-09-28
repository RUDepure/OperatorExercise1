using System;
using System.Collections.Generic;
using System.Text;

namespace OperatorExercise
{
    class Program
    {
        //Operator Exercise 2
        public static double AreaOfCicle(double r)
        {
            double result;

            result = (Math.PI * (r * r));

            return result;
        }
        static void Main(string[] args)
        {
            //Operator Exercise 1
            int a = 17;
            int b = 4;
            int quotient = a / b;
            int remainder = a % b;

            if (a == 17 && b == 4)
            {
                Console.WriteLine($"{a}/{b} is {quotient} remainder {remainder}");
            }

            //Operator Exercise 2
            double area;
            Console.WriteLine("What is the radius of your circle ?");
            var radius = double.Parse(Console.ReadLine());
            area = AreaOfCicle(radius);
            Console.WriteLine($"The area of a circle with radius of {radius} is {area}");
        }
    }
}
