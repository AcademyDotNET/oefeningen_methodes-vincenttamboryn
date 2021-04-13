using System;

namespace Rekenmachine
{
    class Program
    {
        static void Main(string[] args)
        {
            double number1 = GiveNumber("r", "Type the first number");
            double number2 = GiveNumber("r", "Type the second number");
            double choice;
            do
            {
                choice = GiveNumber("int", $"What would you like to do? \n1 to add \n2 for minus \n3 to multiply \n4 to divide");
            } while (choice > 4);
            switch (choice)
            {
                case 1:
                    TelOp(number1,number2);
                    break;

                case 2:
                    TrekAf(number1, number2);
                    break;

                case 3:
                    Vermenigvuldig(number1, number2);
                    break;

                case 4:
                    Deel(number1, number2);
                    break;
                default:
                    break;
            }
        }
        static double TelOp(double getal1, double getal2)
        {
            Console.WriteLine($"{getal1}+{getal2} = {getal1 + getal2}");
            return getal1 + getal2;
        }
        static double TrekAf(double getal1, double getal2)
        {
            Console.WriteLine($"{getal1}-{getal2} = {getal1 - getal2}");
            return getal1 - getal2;
        }
        static double Vermenigvuldig(double getal1, double getal2)
        {
            Console.WriteLine($"{getal1}*{getal2} = {getal1 * getal2}");
            return getal1 * getal2;
        }
        static double Deel(double getal1, double getal2)
        {
            Console.WriteLine($"{getal1}/{getal2} = {getal1 / getal2}");
            return getal1 / getal2;
        }
        static double GiveNumber(string test, string question)
        {
            string numberString;
            do
            {
                Console.WriteLine(question);
                numberString = Console.ReadLine();
            } while (!(Microsoft.VisualBasic.Information.IsNumeric(numberString)));
            double number = Convert.ToDouble(numberString);
            if (test == "+")
            {
                if (number >= 0)
                {
                    return number;
                }
                else
                {
                    number = GiveNumber("+", question);
                    return number;
                }
            }
            else if (test == "-")
            {
                if (number < 0)
                {
                    return number;
                }
                else
                {
                    number = GiveNumber("+", question);
                    return number;
                }
            }
            else if (test == "int")
            {
                char[] komma = { ',' };
                if (numberString.IndexOfAny(komma) == -1)
                {
                    return number;
                }
                else
                {
                    number = GiveNumber("int", question);
                    return number;
                }
            }
            else
            {
                return number;
            }

        }
    }
}
