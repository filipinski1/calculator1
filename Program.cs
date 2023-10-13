using System;

namespace calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                double num1 = 0;
                double num2 = 0;
                double result = 0;

                Console.WriteLine("Calculator Pragram");
                //user inputs always a string we need to convert that
                Console.Write("Enter number 1: ");
                num1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter number 2: ");
                num2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter an option:");
                Console.WriteLine("\t+ : Add");
                Console.WriteLine("\t- : Subtrack");
                Console.WriteLine("\t* : Multiply");
                Console.WriteLine("\t/ : Divide");
                Console.Write("Enter an option");


                switch (Console.ReadLine())
                {
                    case "+":
                        result = num1 + num2;
                        Console.WriteLine($"Your result: {num1} + {num2}= " + result);
                        break;

                    case "-":
                        result = num1 - num2;
                        Console.WriteLine($"Your result: {num1} - {num2}= " + result);
                        break;

                    case "*":
                        result = num1 * num2;
                        Console.WriteLine($"Your result: {num1} * {num2}= " + result);
                        break;

                    case "/":
                        result = num1 / num2;
                        Console.WriteLine($"Your result: {num1} / {num2}= " + result);
                        break;
                    default:

                        Console.WriteLine("That was not a valid option");
                        break;

                }
                //Loop in case they would like to continue using calculator
                Console.WriteLine("Would you like to continue (Y = yes, N = no");
                // If user will put capital letter
            } while (Console.ReadLine().ToUpper() == "Y");

            //in case they would like to exit calculator 4
            Console.WriteLine("Bye!");
            Console.ReadKey();

        }
    }
}
