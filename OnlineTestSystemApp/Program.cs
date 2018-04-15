using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineTestSystemApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create Question
            var question = new Question("what is the value of pi?", "2.14", "3.14", "4.14", "5.14", 2);

            Console.WriteLine($"Q{ question.QuestionNumber }: {question.QuestionText}");
            Console.WriteLine($"1) {question.option1}  2) { question.option2}   3) { question.option3}  4) { question.option4}");



            //Console.WriteLine($"2) {question.option2}");
            //Console.WriteLine($"3) {question.option3}");
            //Console.WriteLine($"4) {question.option4}");
            //Console.Write("Select Answer: ");
            string selectedOption = Console.ReadLine();

            // Answer the question
            question.AnswerTheQuestion(int.Parse(selectedOption));

            // Evaluate
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
        }
    }
}
