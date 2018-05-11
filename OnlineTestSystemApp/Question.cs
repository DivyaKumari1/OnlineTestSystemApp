using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineTestSystemApp
{
   
    public class Question
        {
            private static int lastQuestionNumber = 1;
            
            public int QuestionNumber { get;  private set; }
            public int RollNumber { get; set; }
            public string QuestionText { get; private set; }
            public string option1 { get; private set; }
            public string option2 { get; private set; }
            public string option3 { get; private set; }
            public string option4 { get; private set; }
            public string correctOption { get; private set; }
            public string MarkedOption { get; set; }
            public bool? isAnsweredCorrect { get; set; }

        //public Question(string QuestionText, string option1, string option2, string option3, string option4, int correctOption)
        //{
        //    this.QuestionNumber = lastQuestionNumber++;
        //    this.QuestionText = QuestionText;
        //    this.option1 = option1;
        //    this.option2 = option2;
        //    this.option3 = option3;
        //    this.option4 = option4;

        //    this.correctOption = correctOption;
        //}

        //public void AnswerTheQuestion(int markedOption)
        //{
        //    this.markedOption = markedOption;
        //}

        public void Evaluate()
        {
            if (this.MarkedOption == this.correctOption)
            {
                isAnsweredCorrect = true;
            }
            else
            {
                isAnsweredCorrect = false;
            }
        }
    }

}


    

