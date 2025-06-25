using System;

namespace Calculator
{
    public class Calculator
    {
        public static int GetValidatedInteger(string prompt)
        {
            int result;
            Console.Write(prompt);
            while (!int.TryParse(Console.ReadLine(), out result))
            {
                Console.Write("Invalid input! Please enter a valid integer: ");
            }
            return result;
        }
        public void Run()
        {
            Calculation calculate = new Calculation();

            while (true)
            {
                Console.WriteLine("Choose operation: 1.+  2.-  3.*  4./  5.%  or type 'exit' to quit:");
                string operators = Console.ReadLine();

                if (operators.ToLower() == "exit")
                {
                    Console.WriteLine("Exiting...");
                    break;
                }

                int num1 = GetValidatedInteger("Enter first number: ");
                int num2 = GetValidatedInteger("Enter second number: ");

                switch (operators)
                {
                    case "1":
                        calculate.Adding(num1, num2);
                        break;
                    case "2":
                        calculate.Subtracting(num1, num2);
                        break;
                    case "3":
                        calculate.Multiplying(num1, num2);
                        break;
                    case "4":
                        calculate.Dividing(num1, num2);
                        break;
                    case "5":
                        calculate.RemainderOf(num1, num2);
                        break;
                    default:
                        Console.WriteLine("Invalid operation selected.\n");
                        break;
                }

                Console.WriteLine();
            }
        }
    }

    public class Calculation
    {
        public void Adding(int a, int b) => Console.WriteLine("Sum: " + (a + b));
        public void Subtracting(int a, int b) => Console.WriteLine("Difference: " + (a - b));
        public void Multiplying(int a, int b) => Console.WriteLine("Product: " + (a * b));

        public void Dividing(int a, int b)
        {
            if (b == 0)
            {
                Console.WriteLine("Error during division: Cannot divide by zero.");
                return;
            }
            Console.WriteLine("Quotient: " + (a / b));
        }

        public void RemainderOf(int a, int b)
        {
            if (b == 0)
            {
                Console.WriteLine("Error during modulo: Cannot mod by zero.");
                return;
            }
            Console.WriteLine("Remainder: " + (a % b));
        }
    }
}