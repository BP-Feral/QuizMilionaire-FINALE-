using System;

namespace QuizMilionaire
{
    internal class Menu
    {
        // Initialization for menu interface
        public void Init()
        {
            Console.WriteLine("===================================================================================");
            Console.WriteLine("                                      Welcome                                      ");
            Console.WriteLine("===================================================================================");
            Console.WriteLine("                                                                                   ");
            Console.WriteLine("                                                                                   ");
            Console.WriteLine("                                                                                   ");
            Console.WriteLine("                               Press Enter to Start                                ");
            Console.WriteLine("                                                                                   ");
            Console.WriteLine("                                                                                   ");
            Console.WriteLine("                                                                                   ");
            Console.WriteLine("                                                                                   ");
            Console.WriteLine("                                                                                   ");
            Console.WriteLine("                                                                                   ");
            Console.WriteLine("                                                                                   ");
            Console.WriteLine("                                                                                   ");
            Console.WriteLine("===================================================================================");
            Console.ReadKey(); // Wait before next frame
        }

        // Print on screen a random question based of ID
        public string PrintQuestion(string question, string A, string B, string C, string D, string Solution)
        {
            Console.Clear();
            Console.WriteLine("===================================================================================");
            Console.WriteLine(string.Format("     {0}", question));
            Console.WriteLine("===================================================================================");
            Console.WriteLine("                                                                                   ");
            Console.WriteLine("                                                                                   ");
            Console.WriteLine("                                                                                   ");
            Console.WriteLine(string.Format("      \tA.{0}",A));
            Console.WriteLine("                                                                                   ");
            Console.WriteLine(string.Format("      \tB.{0}",B));
            Console.WriteLine("                                                                                   ");
            Console.WriteLine(string.Format("      \tC.{0}",C));
            Console.WriteLine("                                                                                   ");
            Console.WriteLine(string.Format("      \tD.{0}",D));
            Console.WriteLine("                                                                                   ");
            Console.WriteLine("                                                                                   ");
            Console.WriteLine("                                                                                   ");
            Console.WriteLine("===================================================================================");
            return Console.ReadLine(); // Return to user the input string //DEBUG //UNFINISHED
        }
    }
}
