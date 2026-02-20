using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    public class Calculator
    {
        public static  double add(double num1,double num2)
        {
            return num1 + num2;
        }
        public static double subtract(double num1,double num2)
        { return num1 - num2; }
       public  static double multiply(double num1,double num2)
        { return num1 * num2; }
        public static double divide(double num1, double num2)
        {
            if (num2 == 0)
            {
                Console.WriteLine("Cannot divide by zero.");
                throw new DivideByZeroException("Cannot divide by zero.");
            }

            return num1 / num2;
        }
        public static void CalculateCircle(double radius, out double area, out double circumference)
        {
            if (radius < 0)
            {
                Console.WriteLine("Warning: Radius cannot be negative. Using absolute value.");
                radius = Math.Abs(radius);
            }        
            area = Math.PI * radius * radius;
            circumference = 2 * Math.PI * radius;
        }
    }
}
