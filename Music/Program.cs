using System;

namespace Music
{
    class Program
    {
        static void Main(string[] args)
        {
            Interface();
        }
        static void Interface()
        {
            Console.WriteLine("Which song would you like to play next? \n1: You are my sunshine \n2: Never gonna give you up(standard 133m notes)");
            string choice = Console.ReadLine();
            int milliseconds = Convert.ToInt32(GiveNumber("+","How long do you want each note to last? (in milliseconds)"));
            int octave = Convert.ToInt32(GiveNumber("+", "Which octave? (1 for the default)"));
            switch (choice)
            {
                case "1":
                    var stopwatch = System.Diagnostics.Stopwatch.StartNew();
                    PlayYouAreMySunshine(milliseconds,octave);
                    stopwatch.Stop();
                    double totaletijd = stopwatch.Elapsed.TotalSeconds;
                    Console.WriteLine($"This song was {totaletijd} seconds long.");

                    break;
                case "2":
                    stopwatch = System.Diagnostics.Stopwatch.StartNew();
                    PlayNeverGonnaGiveYouUpSharp(milliseconds, octave);
                    stopwatch.Stop();
                    totaletijd = stopwatch.Elapsed.TotalSeconds;
                    Console.WriteLine($"This song was {totaletijd} seconds long.");

                    break;
                default:
                    break;
            }
            Interface();
        }

        private static void Do(int milliseconden = 1000, int octaaf = 1)
        {
            Console.ForegroundColor = (ConsoleColor)1;
            Console.WriteLine("Do");
            Console.Beep(264 * octaaf, milliseconden);
            Console.ForegroundColor = ConsoleColor.White;
        }

        private static void Re(int milliseconden = 1000, int octaaf = 1)
        {
            Console.ForegroundColor = (ConsoleColor)2;
            Console.WriteLine("Re");
            Console.Beep(297 * octaaf, milliseconden);
            Console.ForegroundColor = ConsoleColor.White;
        }

        private static void Mi(int milliseconden = 1000, int octaaf = 1)
        {
            Console.ForegroundColor = (ConsoleColor)3;
            Console.WriteLine("Mi");
            Console.Beep(330 * octaaf, milliseconden);
            Console.ForegroundColor = ConsoleColor.White;
        }

        private static void Fa(int milliseconden = 1000, int octaaf = 1)
        {
            Console.ForegroundColor = (ConsoleColor)4;
            Console.WriteLine("Fa");
            Console.Beep(352 * octaaf, milliseconden);
            Console.ForegroundColor = ConsoleColor.White;
        }

        private static void Sol(int milliseconden = 1000, int octaaf = 1)
        {
            Console.ForegroundColor = (ConsoleColor)5;
            Console.WriteLine("Sol");
            Console.Beep(396 * octaaf, milliseconden);
            Console.ForegroundColor = ConsoleColor.White;
        }

        private static void La(int milliseconden = 1000, int octaaf = 1)
        {
            Console.ForegroundColor = (ConsoleColor)6;
            Console.WriteLine("La");
            Console.Beep(440 * octaaf, milliseconden);
            Console.ForegroundColor = ConsoleColor.White;
        }

        private static void Si(int milliseconden = 1000, int octaaf = 1)
        {
            Console.ForegroundColor = (ConsoleColor)7;
            Console.WriteLine("Si");
            Console.Beep(495 * octaaf, milliseconden);
            Console.ForegroundColor = ConsoleColor.White;
        }

        private static void Do2(int milliseconden = 1000, int octaaf = 1)
        {
            Console.ForegroundColor = (ConsoleColor)8;
            Console.WriteLine("Do2");
            Console.Beep(528 * octaaf, milliseconden);
            Console.ForegroundColor = ConsoleColor.White;
        }
        private static void DoSharp(int milliseconden = 1000, int octaaf = 1)
        {
            Console.ForegroundColor = (ConsoleColor)9;
            Console.WriteLine("DoSharp");
            Console.Beep(277 * octaaf, milliseconden);
            Console.ForegroundColor = ConsoleColor.White;
        }
        private static void FaSharp(int milliseconden = 1000, int octaaf = 1)
        {
            Console.ForegroundColor = (ConsoleColor)10;
            Console.WriteLine("FaSharp");
            Console.Beep(370 * octaaf, milliseconden);
            Console.ForegroundColor = ConsoleColor.White;
        }

        static void ToonLadder(int milliseconden = 1000, int octaaf = 1)
        {
            Do(milliseconden, octaaf);
            Re(milliseconden, octaaf);
            Mi(milliseconden, octaaf);
            Fa(milliseconden, octaaf);
            Sol(milliseconden, octaaf);
            La(milliseconden, octaaf);
            Si(milliseconden, octaaf);
            Do2(milliseconden, octaaf);
        }
        static void PlayYouAreMySunshine(int milliseconden = 1000, int octaaf = 1)
        {
            Re(milliseconden, octaaf);
            Sol(milliseconden, octaaf);
            La(milliseconden, octaaf);
            Si(milliseconden, octaaf);
            Si(milliseconden, octaaf);
            Si(milliseconden, octaaf);
            La(milliseconden, octaaf);
            Si(milliseconden, octaaf);
            Sol(milliseconden, octaaf);
            Sol(milliseconden, octaaf);
            Sol(milliseconden, octaaf);
            La(milliseconden, octaaf);
            Si(milliseconden, octaaf);
            Do(milliseconden, octaaf);
            Mi(milliseconden, octaaf);
            Mi(milliseconden, octaaf);
            Re(milliseconden, octaaf);
            Do(milliseconden, octaaf);
            Si(milliseconden, octaaf);
        }
        static void PlayNeverGonnaGiveYouUp(int milliseconden = 250, int octaaf = 1)
        {
            Si(milliseconden, octaaf);
            Do(milliseconden, octaaf);
            Re(milliseconden, octaaf);
            Re(milliseconden, octaaf);
            Mi(milliseconden, octaaf);
            Do(milliseconden, octaaf);
            Si(milliseconden, octaaf);
            La(milliseconden, octaaf);
            Si(milliseconden, octaaf);
            Si(milliseconden, octaaf);
            Do(milliseconden, octaaf);
            Re(milliseconden, octaaf);
            Si(milliseconden, octaaf);
            La(milliseconden, octaaf);
            La(milliseconden, octaaf);
            La(milliseconden, octaaf);
            Mi(milliseconden, octaaf);
            Si(milliseconden, octaaf);
            Si(milliseconden, octaaf);
            Do(milliseconden, octaaf);
            Re(milliseconden, octaaf);
            Si(milliseconden, octaaf);
            Re(milliseconden, octaaf);
            Mi(milliseconden, octaaf);
            Do(milliseconden, octaaf);
            Si(milliseconden, octaaf);
            Do(milliseconden, octaaf);
            Si(milliseconden, octaaf);
            La(milliseconden, octaaf);
            Si(milliseconden, octaaf);
            Si(milliseconden, octaaf);
            Do(milliseconden, octaaf);
            Re(milliseconden, octaaf);
            Si(milliseconden, octaaf);
            La(milliseconden, octaaf);
            Mi(milliseconden, octaaf);
            Mi(milliseconden, octaaf);
            Mi(milliseconden, octaaf);
            Fa(milliseconden, octaaf);
            Mi(milliseconden, octaaf);
            Re(milliseconden, octaaf);
            Mi(milliseconden, octaaf);
            Fa(milliseconden, octaaf);
            Re(milliseconden, octaaf);
            Mi(milliseconden, octaaf);
            Mi(milliseconden, octaaf);
            Mi(milliseconden, octaaf);
            Fa(milliseconden, octaaf);
            Mi(milliseconden, octaaf);
            La(milliseconden, octaaf);
            Si(milliseconden, octaaf);
            Do(milliseconden, octaaf);
            Re(milliseconden, octaaf);
            Si(milliseconden, octaaf);
            Mi(milliseconden, octaaf);
            Fa(milliseconden, octaaf);
            Mi(milliseconden, octaaf);
            La(milliseconden, octaaf);
            Si(milliseconden, octaaf);
            Re(milliseconden, octaaf);
            Si(milliseconden, octaaf);
            Fa(milliseconden, octaaf);
            Fa(milliseconden, octaaf);
            Mi(milliseconden, octaaf);
            La(milliseconden, octaaf);
            Si(milliseconden, octaaf);
            Re(milliseconden, octaaf);
            Si(milliseconden, octaaf);
            Mi(milliseconden, octaaf);
            Mi(milliseconden, octaaf);
            Re(milliseconden, octaaf);
            Do(milliseconden, octaaf);
            Si(milliseconden, octaaf);
            La(milliseconden, octaaf);
            Si(milliseconden, octaaf);
            Re(milliseconden, octaaf);
            Si(milliseconden, octaaf);
            Re(milliseconden, octaaf);
            Mi(milliseconden, octaaf);
            Do(milliseconden, octaaf);
            La(milliseconden, octaaf);
            La(milliseconden, octaaf);
            Mi(milliseconden, octaaf);
            Re(milliseconden, octaaf);
            La(milliseconden, octaaf);
            Si(milliseconden, octaaf);
            Re(milliseconden, octaaf);
            Si(milliseconden, octaaf);
            Fa(milliseconden, octaaf);
            Fa(milliseconden, octaaf);
            Mi(milliseconden, octaaf);
            La(milliseconden, octaaf);
            Si(milliseconden, octaaf);
            Re(milliseconden, octaaf);
            Si(milliseconden, octaaf);
            La(milliseconden, octaaf);
            Do(milliseconden, octaaf);
            Re(milliseconden, octaaf);
            Do(milliseconden, octaaf);
            Si(milliseconden, octaaf);
            La(milliseconden, octaaf);
            Si(milliseconden, octaaf);
            Re(milliseconden, octaaf);
            Si(milliseconden, octaaf);
            Re(milliseconden, octaaf);
            Mi(milliseconden, octaaf);
            Do(milliseconden, octaaf);
            La(milliseconden, octaaf);
            La(milliseconden, octaaf);
            Mi(milliseconden, octaaf);
            Re(milliseconden, octaaf);

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
        static void PlayNeverGonnaGiveYouUpSharp(int milliseconden = 250, int octaaf = 1)
        {
            Si(milliseconden, octaaf);
            DoSharp(milliseconden, octaaf*2); //octave //sharp
            Re(milliseconden, octaaf*2); //octave
            Re(milliseconden, octaaf*2); //octave
            Mi(milliseconden, octaaf*2); //octave
            DoSharp(milliseconden, octaaf*2); //octave //sharp
            Si(milliseconden, octaaf);
            La(milliseconden, octaaf);
            Si(milliseconden, octaaf);
            Si(milliseconden, octaaf);
            DoSharp(milliseconden, octaaf*2); //octave //sharp
            Re(milliseconden, octaaf*2); //octave
            Si(milliseconden, octaaf);
            La(milliseconden, octaaf); 
            La(milliseconden, octaaf*2); //octave
            La(milliseconden, octaaf*2); //octave
            Mi(milliseconden, octaaf*2); //octave
            Si(milliseconden, octaaf);
            Si(milliseconden, octaaf);
            DoSharp(milliseconden, octaaf*2); //octave //sharp
            Re(milliseconden, octaaf*2); //octave
            Si(milliseconden, octaaf);
            Re(milliseconden, octaaf*2); //octave
            Mi(milliseconden, octaaf*2); //octave
            DoSharp(milliseconden, octaaf*2); //octave //sharp
            Si(milliseconden, octaaf);
            DoSharp(milliseconden, octaaf*2); //octave //sharp
            Si(milliseconden, octaaf);
            La(milliseconden, octaaf);
            Si(milliseconden, octaaf);
            Si(milliseconden, octaaf);
            Do(milliseconden, octaaf*2); //octave
            Re(milliseconden, octaaf*2); //octave
            Si(milliseconden, octaaf);
            La(milliseconden, octaaf);
            Mi(milliseconden, octaaf*2); //octave
            Mi(milliseconden, octaaf*2); //octave
            Mi(milliseconden, octaaf*2); //octave
            FaSharp(milliseconden, octaaf*2); //octave //sharp
            Mi(milliseconden, octaaf*2); //octave
            Re(milliseconden, octaaf*2); //octave
            Mi(milliseconden, octaaf*2); //octave
            FaSharp(milliseconden, octaaf*2); //octave //sharp
            Re(milliseconden, octaaf*2); //octave
            Mi(milliseconden, octaaf*2); //octave
            Mi(milliseconden, octaaf*2); //octave
            Mi(milliseconden, octaaf*2); //octave
            Fa(milliseconden, octaaf); //octave //sharp
            Mi(milliseconden, octaaf*2); //octave
            La(milliseconden, octaaf);
            Si(milliseconden, octaaf);
            DoSharp(milliseconden, octaaf*2); //octave //sharp
            Re(milliseconden, octaaf*2); //octave
            Si(milliseconden, octaaf);
            Mi(milliseconden, octaaf*2); //octave
            FaSharp(milliseconden, octaaf*2); //octave //sharp
            Mi(milliseconden, octaaf*2); //octave
            La(milliseconden, octaaf);
            Si(milliseconden, octaaf);
            Re(milliseconden, octaaf*2); //octave
            Si(milliseconden, octaaf);
            FaSharp(milliseconden, octaaf*2); //octave //sharp
            FaSharp(milliseconden, octaaf*2); //octave //sharp
            Mi(milliseconden, octaaf*2); //octave
            La(milliseconden, octaaf);
            Si(milliseconden, octaaf);
            Re(milliseconden, octaaf*2); //octave
            Si(milliseconden, octaaf);
            Mi(milliseconden, octaaf*2); //octave
            Mi(milliseconden, octaaf*2); //octave
            Re(milliseconden, octaaf*2); //octave
            DoSharp(milliseconden, octaaf*2); //octave //sharp
            Si(milliseconden, octaaf);
            La(milliseconden, octaaf);
            Si(milliseconden, octaaf);
            Re(milliseconden, octaaf*2); //octave
            Si(milliseconden, octaaf);
            Re(milliseconden, octaaf*2); //octave
            Mi(milliseconden, octaaf*2); //octave
            DoSharp(milliseconden, octaaf*2); //octave //sharp
            La(milliseconden, octaaf);
            La(milliseconden, octaaf);
            Mi(milliseconden, octaaf*2); //octave
            Re(milliseconden, octaaf*2); //octave
            La(milliseconden, octaaf);
            Si(milliseconden, octaaf);
            Re(milliseconden, octaaf*2); //octave
            Si(milliseconden, octaaf);
            FaSharp(milliseconden, octaaf*2); //octave //sharp
            FaSharp(milliseconden, octaaf*2); //octave //sharp
            Mi(milliseconden, octaaf*2); //octave
            La(milliseconden, octaaf);
            Si(milliseconden, octaaf);
            Re(milliseconden, octaaf*2); //octave
            Si(milliseconden, octaaf);
            La(milliseconden, octaaf*2); //octave
            DoSharp(milliseconden, octaaf*2); //octave //sharp
            Re(milliseconden, octaaf*2); //octave
            DoSharp(milliseconden, octaaf*2); //octave //sharp
            Si(milliseconden, octaaf);
            La(milliseconden, octaaf);
            Si(milliseconden, octaaf);
            Re(milliseconden, octaaf*2); //octave
            Si(milliseconden, octaaf);
            Re(milliseconden, octaaf*2); //octave
            Mi(milliseconden, octaaf*2); //octave
            DoSharp(milliseconden, octaaf*2); //octave //sharp
            La(milliseconden, octaaf);
            La(milliseconden, octaaf);
            Mi(milliseconden, octaaf*2); //octave
            Re(milliseconden, octaaf*2); //octave

        }
    }
}
