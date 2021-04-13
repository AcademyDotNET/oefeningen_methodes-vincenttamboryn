using System;

namespace Deel1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        static void MyIntro()
        {
            Console.WriteLine("Ik ben Vincent Tamboryn, ik ben 23 jaar en ik woon in Overijse");
        }
        static void MyIntroAdvance(string name, double age, string location)
        {
            Console.WriteLine($"Ik ben {name}, ik ben {age} jaar en ik woon in {location}");
        }
        static double GrootsteVanDrie(double a, double b, double c)
        {
            if (a < b)
            {
                if (b < c)
                {
                    return c;
                }
                else
                {
                    return b;
                }
            }
            else
            {
                if (a < c)
                {
                    return c;
                }
                else
                {
                    return a;
                }
            }
        }
    }
}
