using System;

namespace Calculator
{
    public class Calculator
    {
        public void Run()
        {
            Calculation calculate = new Calculation();

            while (true)
            {
                Console.WriteLine("Choose operation: 1.+  2.-  3.*  4./ 5.%  or type 'exit' to quit:");
                string operators = Console.ReadLine();

                if (operators.ToLower() == "exit")
                {
                    Console.WriteLine("Exiting...");
                    break;
                }

                int num1 = 0, num2 = 0;
                bool num1Valid = false, num2Valid = false;

                while (!num1Valid || !num2Valid)
                {
                    try
                    {
                        if (!num1Valid)
                        {
                            Console.Write("Enter first number: ");
                            num1 = int.Parse(Console.ReadLine());
                            num1Valid = true;
                        }
                        if (!num2Valid)
                        {
                            Console.Write("Enter second number: ");
                            num2 = int.Parse(Console.ReadLine());
                            num2Valid = true;
                        }
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Invalid input! Please enter a valid integer.\n");
                    }
                }

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
            try
            {
                if (b == 0)
                    throw new DivideByZeroException("Cannot divide by zero.");
                Console.WriteLine("Quotient: " + (a / b));
            }
            catch (Exception e)
            {
                Console.WriteLine("Error during division: " + e.Message);
            }
        }

        public void RemainderOf(int a, int b)
        {
            try
            {
                if (b == 0)
                    throw new DivideByZeroException("Cannot mod by zero.");
                Console.WriteLine("Remainder: " + (a % b));
            }
            catch (Exception e)
            {
                Console.WriteLine("Error during modulo: " + e.Message);
            }
        }
    }
}
