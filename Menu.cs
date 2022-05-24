using System;
using System.Configuration;
using System.IO;

namespace QuizMilionaire
{
    internal class Menu
    {
        // Initialization for menu interface
        public string Init()
        {
            Console.WriteLine("========================================================================================================================");
            Console.WriteLine("                                                   Welcome                                                              ");
            Console.WriteLine("========================================================================================================================");
            Console.WriteLine("                                                                                                                        ");
            Console.WriteLine("                                                                                                                        ");
            Console.WriteLine("                                                                                                                        ");
            Console.WriteLine("                                                                                                                        ");
            Console.WriteLine("                              To add a Question, Start typing it and Press Enter                                        ");
            Console.WriteLine("                                                   -OR-                                                                 ");
            Console.WriteLine("                                       Press Enter to Start solving                                                     ");
            Console.WriteLine("                                                                                                                        ");
            Console.WriteLine("                                                                                                                        ");
            Console.WriteLine("========================================================================================================================");
            string input = Console.ReadLine();
            return input;
        }

        // Add a new question
        public void AddQuestion(string input)
        {
            string answerA ="", answerB = "", answerC = "", answerD = "", result = "";

            string defaultsA = "    A.                                                                                                                  ";
            string defaultsB = "    B.                                                                                                                  ";
            string defaultsC = "    C.                                                                                                                  ";
            string defaultsD = "    D.                                                                                                                  ";
            
            int i = 0;

            for (i = 0; i < 5; i++)
            {
                Console.Clear();
                Console.WriteLine("========================================================================================================================");
                Console.WriteLine(string.Format(" Create > {0}", input));
                Console.WriteLine("========================================================================================================================");
                Console.WriteLine("                                                                                                                        ");
                Console.WriteLine("                                                                                                                        ");
                Console.WriteLine(defaultsA);
                Console.WriteLine("                                                                                                                        ");
                Console.WriteLine(defaultsB);
                Console.WriteLine("                                                                                                                        ");
                Console.WriteLine(defaultsC);
                Console.WriteLine("                                                                                                                        ");
                Console.WriteLine(defaultsD);
                Console.WriteLine("========================================================================================================================");
                switch (i)
                {
                    case 0:
                        Console.WriteLine("Input the first answer");
                        answerA = Console.ReadLine();
                        defaultsA = string.Format("    A. {0}", answerA);
                        break;

                    case 1:
                        Console.WriteLine("Input the second answer");
                        answerB = Console.ReadLine();
                        defaultsB = string.Format("    B. {0}", answerB);
                        break;

                    case 2:
                        Console.WriteLine("Input the third answer");
                        answerC = Console.ReadLine();
                        defaultsC = string.Format("    C. {0}", answerC);
                        break;

                    case 3:
                        Console.WriteLine("Input the forth answer");
                        answerD = Console.ReadLine();
                        defaultsD = string.Format("    D. {0}", answerD);
                        break;

                    case 4:
                        Console.WriteLine("Input the letter of the correct answer");
                        result = Console.ReadLine();
                        break;
                }
            }

            using (StreamWriter sw = File.AppendText(ConfigurationManager.AppSettings.Get("FileName")))
            {
                sw.WriteLine(string.Format(Environment.NewLine + "{0};{1};{2};{3};{4};{5}", input, answerA, answerB, answerC, answerD, result));
            }
            Console.WriteLine("Question saved! Press enter to return...");
            Console.ReadKey();
            Init();
        }

        // Print on screen a random question based of ID
        public string PrintQuestion(int score, string question, string A, string B, string C, string D, string Solution)
        {
            Console.Clear();
            Console.WriteLine("========================================================================================================================");
            Console.WriteLine(string.Format("      {0}] {1}",score, question));
            Console.WriteLine("========================================================================================================================");
            Console.WriteLine("                                                                                                                        ");
            Console.WriteLine("                                                                                                                        ");
            Console.WriteLine(string.Format("      \tA.{0}",A));
            Console.WriteLine("                                                                                                                        ");
            Console.WriteLine(string.Format("      \tB.{0}",B));
            Console.WriteLine("                                                                                                                        ");
            Console.WriteLine(string.Format("      \tC.{0}",C));
            Console.WriteLine("                                                                                                                        ");
            Console.WriteLine(string.Format("      \tD.{0}",D));
            Console.WriteLine("                                                                                                                        ");
            Console.WriteLine("========================================================================================================================");
            return Console.ReadLine();
        }
        // result screen (if fail)
        public void resultScreen(int score)
        {
            Console.Clear();
            Console.WriteLine("========================================================================================================================");
            Console.WriteLine("                                     You have failed the last question                                                  ");
            Console.WriteLine("========================================================================================================================");
            Console.WriteLine("                                                                                                                        ");
            Console.WriteLine("                                                                                                                        ");
            Console.WriteLine("                                                                                                                        ");
            Console.WriteLine("                                                                                                                        ");
            Console.WriteLine(string.Format("                                You have answered a total of {0} questions correctly", score-1));
            Console.WriteLine("                                                                                                                        ");
            Console.WriteLine("                                                                                                                        ");
            Console.WriteLine("                                                                                                                        ");
            Console.WriteLine("                                                                                                                        ");
            Console.WriteLine("                                                                                                                        ");
            Console.WriteLine("========================================================================================================================");

        }
    }
}
