using System.Collections.Generic;
using System.IO;

namespace QuizMilionaire
{
    public class Question
    {
        string question;

        string answerA;
        string answerB;
        string answerC;
        string answerD;
        
        string solution;
        
        int ID = 0;

        // Constructor
        public Question(
            string _question, string _answerA, string _answerB, 
            string _answerC, string _answerD, string _solution)
        {
            question = _question;
            answerA = _answerA;
            answerB = _answerB;
            answerC = _answerC;
            answerD = _answerD;
            solution = _solution;
            ID = ID++;
        }
        
        // Initialization - method to read the questions from file
        public List<Question> Init()
        {
            List<Question> questions = new List<Question>();
            
            // Stream streamFisierText = File.Open("Intrebari.txt", FileMode.Create);
            Stream streamFisierText = File.Open("Intrebari.txt", FileMode.Open);
            using (StreamReader reader = new StreamReader(streamFisierText))
            {
                string fileLine;
                while ((fileLine = reader.ReadLine()) != null)
                {
                    string[] temp = fileLine.Split(';');
                    questions.Add(new Question(temp[0], temp[1], temp[2], temp[3], temp[4], temp[5]));
                }
            }
            return questions;
        }

        // Obtin the question on the current list index
        public string GetQuestion()
        {
            return question; 
        }

        // Obtain the first option
        public string GetA()
        {
            return answerA;
        }

        // Obtain the second opption
        public string GetB()
        {
            return answerB;
        }

        // Obtain the third option
        public string GetC()
        {
            return answerC;
        }

        // Obtain the forth option
        public string GetD()
        {
            return answerD;
        }

        // Otain the correct nswer
        public string GetSolution()
        {
            return solution;
        }
    }
}