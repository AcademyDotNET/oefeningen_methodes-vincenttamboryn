using System;

namespace Woensdag7_4
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintAllArmstrong(1000);
        }
        static double Kwadraad(double getal)
        {
            return getal * getal;
        }
        static double BerekenStraal(double diameter)
        {
            return diameter / 2;
        }
        static double BerekenOmtrek(double diameter)
        {
            return 2 * BerekenStraal(diameter) * Math.PI;
        }
        static double BerekenOppervlakte(double diameter)
        {
            return BerekenStraal(diameter)* BerekenStraal(diameter)* Math.PI;
        }
        static double GrootsteVanTwee(double getal1, double getal2)
        {
            if (getal1 > getal2)
            {
                return getal1;
            }
            else if (getal2 > getal1)
            {
                return getal2;
            }
            else
                Console.WriteLine("numbers are equal");
                return 0;
        }
        static bool IsEven(int getal)
        {
            if (getal%2 ==0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static bool IsArmstrong(int number)
        {

            string armNumber = Convert.ToString(number);
            double sum = 0;
            double armstrongNumber = Convert.ToDouble(armNumber);
            foreach (char v in armNumber)
            {
                string c = Convert.ToString(v);
                int digit = Convert.ToInt32(c);
                sum += Math.Pow(digit, armNumber.Length);
            }

            if (sum == armstrongNumber)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static void PrintAllUnevenNumbers(int number)
        {
            for (int i = 1; i <= number; i++)
            {
                if (!(i % 2 == 0))
                {
                    Console.WriteLine(i);
                }
            }
        }
        static void PrintAllArmstrong(int number)
        {
            for (int i = 1; i <= number; i++)
            {
                if (IsArmstrong(i))
                {
                    Console.WriteLine(i);
                }

            }
        }
    }
}
