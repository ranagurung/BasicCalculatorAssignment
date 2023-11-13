using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;

namespace BasicCalculatorAssignment
{
    internal class Program
    {
        // The goal of this assignment is to learn how to create and use methods in our code
        static void Main(string[] args)
        {
            while (true)
            {


                Console.WriteLine("Simple Calculator");
                Console.WriteLine("-----------------");
                Console.WriteLine("1. Add");
                Console.WriteLine("2. Subtract");
                Console.WriteLine("3. Multiply");
                Console.WriteLine("4. Divide");
                Console.WriteLine("5. Exit");

                Console.Write("Choose an operation: ");
                int option =int.Parse(Console.ReadLine());


                if (option == 5)
                {
                    Console.Write("Have a nice day...");
                    break;
                }

                Console.Write("Enter the first number:");
                double firstNum = double.Parse(Console.ReadLine());
                Console.Write("Enter the second number:");
                double secondNum = double.Parse(Console.ReadLine());

                double result = 0;
                if (option ==1)
                {

                  result = Add(firstNum, secondNum);
                  Console.WriteLine($"Addition of {secondNum} and {firstNum} is: {result}");

                }
                if (option ==2)
                {
                    result = subtract(firstNum, secondNum);
                    Console.WriteLine($"Subtraction of {secondNum} from {firstNum} is: {result}");
                }
                if ( option ==3)
                {
                    result = multiply(firstNum, secondNum);
                    Console.WriteLine($"multiplication of {firstNum} and {secondNum} is: {result}");
                }
                if ( option == 4)
                {
                    result = divide(firstNum, secondNum);
                    Console.WriteLine($"division of {firstNum} by {secondNum}is: {result}");
                }
            }
        }

        // Declare your methods/functions here

        static double Add(double a, double b)
        {
            return a + b;
        }
        static double subtract(double a, double b)
        {
            return a - b;
        }
        static double multiply(double a, double b)
        {
            return a * b;   
        }
        static double divide(double a, double b)
        {
            return a / b;
        }
    }

}