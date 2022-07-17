using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsExercise2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is the radius of your circle?");
            var radius = double.Parse(Console.ReadLine());
            Console.WriteLine($"The are of a circle with radius of {radius} is {AreaOfCircle(radius)}");
            Console.ReadLine(); // This is just to keep the console from closing right away
        }
        public static double AreaOfCircle(double radius)
        {
            return Math.PI * radius * radius;
        }
    }
}
