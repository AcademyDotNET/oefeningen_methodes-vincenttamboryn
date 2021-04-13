using System;

namespace PasswordGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            int lenght =Convert.ToInt32(GiveNumber("int", "How long would you like your new password to be?"));
            string password = PasswordGenerator(lenght);
            Console.WriteLine($"your new password is:\n{password}");
        }
        static string PasswordGenerator(int lenght)
        {
            Random randomGenerator = new Random();
            string password = "";
            for (int i = 0; i < lenght; i++)
            { 
                int random = randomGenerator.Next(33, 126);
                password += Convert.ToChar(random);
            }
            return password;
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
                    number = GiveNumber("-", question);
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
