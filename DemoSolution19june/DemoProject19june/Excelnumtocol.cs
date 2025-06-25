using System;

namespace DemoProject19june
{
    class Excelnumtocol
    {
        public static void Main()
        {
            Excelnumtocol test = new Excelnumtocol();
         
            Console.Write("Enter a column number: ");
            if (int.TryParse(Console.ReadLine(), out int columnNumber) && columnNumber > 0)
            {
                string columnName = test.NumberToColumnName(columnNumber);
                Console.WriteLine($"{columnName}.");
            }
            else
            {
                Console.WriteLine("Please enter a valid positive number.");
            }
        }

        private string NumberToColumnName(int number)
        {
            string columnName = string.Empty;
            while (number > 0)
            {
                number--;
                columnName = (char)('A' + (number % 26)) + columnName;
                number /= 26;
            }
            return columnName;
        }
    }
}