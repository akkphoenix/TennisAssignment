using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TennisScorer1
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int scoreA = 0; scoreA <= 5; scoreA++)
            {
                for (int scoreB = 0; scoreB <= 5; scoreB++)
                {
                    Console.Write("{0} {1} = ", scoreA, scoreB);
                    DisplayScore(scoreA, scoreB);
                }
            }
            Console.ReadLine();
        }

        static void DisplayScore(int fscore, int sscore)
        {
            //Modify this method - use ifs and switches based on the value of a and b
            //Console.WriteLine("____");
            switch (fscore)
            {
                case 0:
                    DisplayforZero(sscore);
                    break;
                case 1:
                    DisplayforOne(sscore);
                    break;
                case 2:
                    DisplayforTwo(sscore);
                    break;
                case 3:
                    DisplayforThree(sscore);
                    break;
                case 4:
                    DisplayforFour(sscore);
                    break;
                default: DisplayforFive(sscore);
                    break;
            }
        }

        static void DisplayforZero(int sscore)
        {
            switch (sscore)
            {
                case 0:
                        Console.WriteLine("Love all");
                        break;
                case 1:
                        Console.WriteLine("Love-15");
                        break;
                case 2:
                        Console.WriteLine("Love-30");
                        break;
                case 3   :
                        Console.WriteLine("Love-40");
                        break;
                case 4:
                        Console.WriteLine("Game B");
                        break;
                default:
                        Console.WriteLine("N/A");
                    break;

            }
        }

        static void DisplayforOne(int sscore)
        {
            switch (sscore)
            {
                case 0:
                    Console.WriteLine("15-love");
                    break;
                case 1:
                    Console.WriteLine("15 all");
                    break;
                case 2:
                    Console.WriteLine("15 30");
                    break;
                case 3:
                    Console.WriteLine("15 40");
                    break;
                case 4:
                    Console.WriteLine("Game B");
                    break;
                default:
                    Console.WriteLine("N/A");
                    break;

            }
        }

        static void DisplayforTwo(int sscore)
        {
            switch (sscore)
            {
                case 0:
                    Console.WriteLine("30-love");
                    break;
                case 1:
                    Console.WriteLine("30 15");
                    break;
                case 2:
                    Console.WriteLine("30 all");
                    break;
                case 3:
                    Console.WriteLine("30 40");
                    break;
                case 4:
                    Console.WriteLine("Game B");
                    break;
                default:
                    Console.WriteLine("N/A");
                    break;

            }
        }

        static void DisplayforThree(int sscore)
        {
            switch (sscore)
            {
                case 0:
                    Console.WriteLine("40-love");
                    break;
                case 1:
                    Console.WriteLine("40 15");
                    break;
                case 2:
                    Console.WriteLine("40 30");
                    break;
                case 3:
                    Console.WriteLine("Deuce");
                    break;
                case 4:
                    Console.WriteLine("Advantage B");
                    break;
                default:
                    Console.WriteLine("Game B");
                    break;

            }
        }
         static void DisplayforFour(int sscore)
        {
            switch (sscore)
            {
                case 0:
                    Console.WriteLine("Game A");
                    break;
                case 1:
                    Console.WriteLine("Game A");
                    break;
                case 2:
                    Console.WriteLine("Game A");
                    break;
                case 3:
                    Console.WriteLine("Advantage A");
                    break;
                case 4:
                    Console.WriteLine("Deuce");
                    break;
                default:
                    Console.WriteLine("Advantage B");
                    break;

            }
        }

         static void DisplayforFive(int sscore)
        {
            switch (sscore)
            {
                case 0:
                    Console.WriteLine("N/A");
                    break;
                case 1:
                    Console.WriteLine("N/A");
                    break;
                case 2:
                    Console.WriteLine("N/A");
                    break;
                case 3:
                    Console.WriteLine("Game A");
                    break;
                case 4:
                    Console.WriteLine("Advantage A");
                    break;
                default:
                    Console.WriteLine("Deuce");
                    break;

            }
        }
    }
}
