using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineTestSystemApp
{
    public static class Test
    {
        /// <summary>
        /// This creates question for test
        /// </summary>
        /// <param name="QuestionText"> question text</param>
        /// <param name="option1"> option1</param>
        /// <param name="option2">option2</param>
        /// <param name="option3">option3</param>
        /// <param name="option4">option4</param>
        /// <param name="correctOption">correct option</param>
        /// <param name="markedOption">marked option</param>
        /// <param name="rollNumber">roll number</param>
        /// <returns></returns>
        public static Question CreateQuestion(string QuestionText, string option1, string option2, string option3, string option4, int correctOption, int markedOption,int rollNumber)
        {
            var question = new Question
            {
                RollNumber = rollNumber,
                MarkedOption = markedOption.ToString(),

            };
            
             question.Evaluate();
            
            // Print whether correct or wrong
            if (question.isAnsweredCorrect == true)
            {
                Console.WriteLine("Correct!!");
            }
            else
            {
                Console.WriteLine($"Incorrect. The correct option is {question.correctOption}");
            }
            return question;


        }

    }
}












