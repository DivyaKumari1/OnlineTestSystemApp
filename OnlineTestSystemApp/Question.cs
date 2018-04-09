﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineTestSystemApp
{
   
        class Question
        {
            private static int lastQuestionNumber = 1;
            public int QuestionNumber { get; set; }
            public string option1 { get; set; }
            public string option2 { get; set; }
            public string option3 { get; set; }
            public string option4 { get; set; }
            public int correctOption { get; set; }
            public int markedOption { get; set; }

            #region Constructor
            public Question()
            {
                QuestionNumber = lastQuestionNumber++;

            }
            #endregion

            #region Methods

            public int MarksObtained(int QuestionNumber, int option1, int option2, int option3, int option4, int correctOption, int markedOption)
            {
                int totalMarks = 0;
                if (markedOption == correctOption)
                {
                    totalMarks = totalMarks + 3;
                }
                else
                {
                    totalMarks = totalMarks - 1;

                }
                return totalMarks;


            }
            #endregion

        }

    
}
