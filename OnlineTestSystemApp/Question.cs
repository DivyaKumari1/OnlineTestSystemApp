using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineTestSystemApp
{

    public class Question
    {
       // private static int lastQuestionNumber = 1;

        [Key]
        public int QuestionNumber { get; set; }
       
        public string EmailId { get; set; }

        [Required]
        [StringLength(500, ErrorMessage = "Question Text cannot be more than 500 character")]
        public string QuestionText { get;  set; }

        [Required]
        public int Option1 { get; set; }

        [Required]
        public int Option2 { get; set; }

        [Required]
        public int Option3 { get; set; }

        [Required]
        public int Option4 { get;  set; }
      
        [Required]
        public int CorrectOption { get; set; }

        [Required]
        public int  MarkedOption { get; set; }

        
        public bool? isAnsweredCorrect { get; set; }

        public DateTime CreatedDate { get;  set; }

        //public Question()
        //{
        //    QuestionNumber = lastQuestionNumber++;
        //    CreatedDate = DateTime.UtcNow;

        //}

        public void AnswerTheQuestion(int markedOption)
        {
            MarkedOption = markedOption;
        }

        public void Evaluate()
        {
            if (MarkedOption == CorrectOption)
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


    

