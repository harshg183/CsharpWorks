using System;

namespace VotingMachine
{
    static class Program
    {
        static void Main(string[] args)
        {
            try
            { 
                Console.Write("Enter your age: ");
                string input = Console.ReadLine();
                int age = int.Parse(input);

                if (age >= 18)
                {
                    Console.WriteLine("You are eligible to vote.");
                    Console.WriteLine("\n--- Candidates ---");
                    Console.WriteLine("1. Harsh");
                    Console.WriteLine("2. Himanshu");
                    Console.WriteLine("3. Dhruv");
                    Console.Write("Enter the number of the candidate you want to vote for: ");

                    string voteInput = Console.ReadLine();
                    int vote = int.Parse(voteInput);

                    switch (vote)
                    {
                        case 1:
                            Console.WriteLine("You voted for Harsh. Thank you!");
                            break;
                        case 2:
                            Console.WriteLine("You voted for Himanshu. Thank you!");
                            break;
                        case 3:
                            Console.WriteLine("You voted for Dhruv. Thank you!");
                            break;
                        default:
                            Console.WriteLine("Invalid candidate number.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("You can't vote. Age must be 18 or above.");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter only numbers.");
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Array index out of range.");
            }
            catch (Exception)
            {
                Console.WriteLine("Something went wrong.");
            }
            finally
            {
                Console.WriteLine("The voting process is complete.");
            }
        }
    }
}
