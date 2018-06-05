using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineTestSystemApp
{
    public static class Test
    {
        private static TestModel db = new TestModel();
        // private static List<Question> questions = new List<Question>();
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
        /// <param name="emailId">roll number</param>
        /// <returns></returns>

        public static Question CreateQuestion(string QuestionText, int option1, int option2, int  option3, int  option4, int correctOption, int markedOption,string emailId)
        {
            var question = new Question
            {
                QuestionText = QuestionText,
                Option1 =option1,
                Option2 = option2,
                Option3 = option3,
                Option4 = option4,
                EmailId = emailId,
                CorrectOption = correctOption,
                MarkedOption = markedOption,
            };
            
            // questions.Add(question);
            question.AnswerTheQuestion(markedOption);
            question.Evaluate();
            
          
            db.Questions.Add(question);
            db.SaveChanges();




            //question.Evaluate();

            //Print whether correct or wrong
            //if (question.isAnsweredCorrect == true)
            //{
            //    Console.WriteLine("Correct!!");
            //}
            //else
            //{
            //    Console.WriteLine($"Incorrect. The correct option is {question.correctOption}");
            //}
            return question;


        }
        public static IEnumerable<Question> GetAllQuestions(string emailId)
        {
            return db.Questions.Where(q => q.EmailId == emailId);
        }

        public static Question GetAllQuestionDetails(int questionNumber)
        {
            return db.Questions.Find(questionNumber);
        }
        public static Question EditQuestion(Question question)
        {
            var UpdatedQuestion = GetAllQuestionDetails(question.QuestionNumber);
              UpdatedQuestion.QuestionText = question.QuestionText;
            UpdatedQuestion.Option1 = question.Option1;
            UpdatedQuestion.Option2 = question.Option2;
            UpdatedQuestion.Option3 = question.Option3;
            UpdatedQuestion.Option4 = question.Option4;
            UpdatedQuestion.MarkedOption = question.MarkedOption;
            UpdatedQuestion.EmailId = question.EmailId;


            db.Entry(UpdatedQuestion).CurrentValues.SetValues(UpdatedQuestion);
            db.SaveChanges();
            return UpdatedQuestion;
        }

    }
}












