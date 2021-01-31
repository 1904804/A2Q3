using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2Q3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Assignment 2 question 3
            //Distance between two points

            double point1x;
            double point1y;
            double point2x;
            double point2y;
            double valueA;
            double valueB;
            double valueTotal;
            double distance;


            //Capture point 1 x / y and point 2 x / y and assign to intgerters
            Console.WriteLine("Please enter the value of point 1 x - ");
            point1x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please enter the value of point 1 y - ");
            point1y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please enter the value of point 2 x - ");
            point2x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please enter the value of point 2 y - ");
            point2y = Convert.ToDouble(Console.ReadLine());

            //Calculate the value to be squared
            //the calulation is broken down to simlify the equation
            valueA = point1x - point2x;
            valueB = point1y - point2y;

            valueTotal = (valueA * valueA) + (valueB * valueB);

            Console.WriteLine(valueTotal);
            distance = Math.Sqrt(valueTotal);


            Console.WriteLine("The distance between point 1 and point 2 is - {0:F2}", distance);

        }
    }
}
