using System;
using System.Collections.Generic;
using System.Configuration;
using System.Windows.Forms;

namespace QuizMilionaire
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(new Milionaire());

            var configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            var settings = configFile.AppSettings.Settings;

            // Args handler
            if (args.Length == 0)
            {
                Console.WriteLine("Nu au fost introduse argumente");
            } else
            {
                settings.Remove("FileName");
                settings.Add("FileName", args[0]);
                
                configFile.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection(configFile.AppSettings.SectionInformation.Name);

                Console.WriteLine("Argumentele identificate sunt: ");
                foreach (string arg in args)
                {
                    Console.WriteLine(arg);
                }
            }

            // Main program
            // List<Question> questions = new List<Question>();
            // Question question = new Question("template", "A", "B", "C", "D", "S");
            // questions = question.Init();

            // int score = 1;
            // string input = "";
            // Call the menu interface
            // DEACTIVATE TO LET FORMS WORK
            // Menu menu = new Menu();
            // input = menu.Init();
            // if (input != "")
            // {
            //     Console.WriteLine(input);
            //     menu.AddQuestion(input);
            // }
            
            // Application loop
            // while (true)
            // {
            //    Random random = new Random();
            //    int ID = random.Next(1, 15);
            //    string result = menu.PrintQuestion(score,
            //        questions[ID].GetQuestion(),
            //        questions[ID].GetA(),
            //        questions[ID].GetB(),
            //        questions[ID].GetC(),
            //        questions[ID].GetD(),
            //        questions[ID].GetSolution()
            //        );
            //
            //    if (result == questions[ID].GetSolution())
            //    {
            //        score++;
            //    } else
            //    {
            //        menu.resultScreen(score);
            //        break;
            //    }
            //}

            // Application close automatically W/
            //Console.ReadKey();
        }
    }
}