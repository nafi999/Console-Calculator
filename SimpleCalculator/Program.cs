using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{   
    class Program
    {
        static void Main(string[] args)
        {
            //Prompting user for two numbers and storing them in memory
            double X = GetNumber("Enter your first number: ");
            double Y = GetNumber("Enter your second number: ");

            // initializing output
            double output = 0;

            while (true) //looping until user inputs one of the mentioned operators
            {
                Console.Write("Enter Add(A),Subtract(S), M(Multiply) or D(Divide): "); //Prompting user to select operator

                ConsoleKeyInfo info = Console.ReadKey();  //reading a key from user input
                string operation = info.Key.ToString();   //converting the key to string and storing it in memory

                // Checking user input for operator and showing output accordingly
                switch (operation.ToUpper()) 
                {
                    case "A":
                        output = Add(X, Y);
                        break;

                    case "S":
                        output = Subtract(X, Y);
                        break;

                    case "M":
                        output = Multiply(X, Y);
                        break;

                    case "D":
                        output = Divide(X, Y);
                        break;

                    default:
                        Console.WriteLine("\nYou must enter one of the operations.");
                        continue;
                }
                Console.WriteLine("\nOutput: " + output);
                Console.Read();
                break;
            }
        }
         
        // GetNumber method   
        private static double GetNumber(string prompt)
        {
            double number; 

            while (true) //looping until user inputs a number
            {
                Console.Write(prompt);
                String userInput = Console.ReadLine();

                // Checking to see if string representation of a number can be parsed into double
                if (Double.TryParse(userInput, out number)) 
                {
                    return number;
                }
                else
                {
                    Console.WriteLine("Your input is not a number.");
                }
            }
        }

        // Add method
        private static double Add(double X, double Y)
        {
            return X + Y;
        }

        // Subtract method
        private static double Subtract(double X, double Y)
        {
            return X - Y;
        }

        // Multiply method
        private static double Multiply(double X, double Y)
        {
            return X * Y;
        }

        // Divide method
        private static double Divide(double X, double Y)
        {
            if (X == 0 || Y == 0)
            {
                return 0; 
            }
            else
            {
                return X / Y;
            }
        }
    }
}          




