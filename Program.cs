using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wk2Ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {

           //Excercise 1
            Console.WriteLine("Interest Calculator Program");

            // Input principal
            Console.Write("What is principal amount of the loan in dollars: ");
            double principal = Convert.ToDouble(Console.ReadLine());
            // Input interest
            Console.Write("what is interest rate(intput 0.05 for 5%): ");
            double rate = Convert.ToDouble(Console.ReadLine());
            // Input time
            Console.Write("What is period of loan in years?: ");
            double time = Convert.ToDouble(Console.ReadLine());

            // Calculate interest
            double interest = principal * rate * time;

            // Output
            Console.WriteLine($"Total interest of Loan: {interest} dollars");

           //Excercise 2 
           
            // Input length 
            Console.Write("Enter the length of the rectangle: ");
            double length = Convert.ToDouble(Console.ReadLine());
            // Input width
            Console.Write("Enter the width of the rectangle: ");
            double width = Convert.ToDouble(Console.ReadLine());

            // Calculate area
            double area = length * width;
            double perimeter = 2 * (length + width);

            // Output 
            Console.WriteLine($"Area of the rectangle: {area}");
            Console.WriteLine($"Perimeter of the rectangle: {perimeter}");

            //Excercise 3
            Console.WriteLine("Welcome to Temperature Converter");

            // Input temperature 
            Console.Write("Enter the temperature: ");
            double fahrenheit = Convert.ToDouble(Console.ReadLine());

            // Convert to celsius
            double celsius = (5.0 / 9.0) * (fahrenheit - 32);

            // Output
            Console.WriteLine($"{fahrenheit}°F is equivalent to {celsius:F2}°C");


            //Excercise 4
            Console.WriteLine("Welcome to the Hypotenuse Calculator");

            // Input length a 
            Console.Write("Enter the length of the first side (a): ");
            double a = Convert.ToDouble(Console.ReadLine());
            // Input length b
            Console.Write("Enter the length of the second side (b): ");
            double b = Convert.ToDouble(Console.ReadLine());

            // Calculate the hypotenuse
            double c = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));

            // Output 
            Console.WriteLine($"The length of the hypotenuse is: {c}");

            Console.WriteLine("Thank you for using the Hypotenuse Calculator");


        }
    }
}
