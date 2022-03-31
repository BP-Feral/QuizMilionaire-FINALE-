using System;
using System.Collections.Generic;

namespace QuizMilionaire
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Question> questions = new List<Question>();
            Question question = new Question("template", "A", "B", "C", "D", "S");
            questions = question.Init();

            // Call the menu interface
            Menu menu = new Menu();
            menu.Init();

            // Application loop
            while (true)
            {
                Random random = new Random();
                int ID = random.Next(1, 4);
                string result = menu.PrintQuestion(
                    questions[ID].GetQuestion(),
                    questions[ID].GetA(),
                    questions[ID].GetB(),
                    questions[ID].GetC(),
                    questions[ID].GetD(),
                    questions[ID].GetSolution()
                    );

                // !TODO menu.resultscreen()
                // UNFINISHED
            }

            // Application close automatically W/
            Console.ReadKey();
        }
    }
}