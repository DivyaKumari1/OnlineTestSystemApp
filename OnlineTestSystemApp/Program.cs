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
            // // Create Question

            // var question = new Question("what is the value of pi?", "2.14", "3.14", "4.14", "5.14", 2);

            //// Console.WriteLine($"Q{ question.QuestionNumber }: {question.QuestionText}");
            // //Console.WriteLine($"1) {question.option1}  2) { question.option2}   3) { question.option3}  4) { question.option4}");




            // //Console.WriteLine($"2) {question.option2}");
            // //Console.WriteLine($"3) {question.option3}");
            // //Console.WriteLine($"4) {question.option4}");
            // //Console.Write("Select Answer: ");
            // string selectedOption = Console.ReadLine();

            // // Answer the question
            // question.AnswerTheQuestion(int.Parse(selectedOption));

            // // Evaluate
            // question.Evaluate();

            // // Print whether correct or wrong
            // if (question.isAnsweredCorrect == true)
            // {
            //     Console.WriteLine("Correct!!");
            // }
            // else
            // {
            //     Console.WriteLine($"Incorrect. The correct option is {question.correctOption}");
            // }

            Console.WriteLine("welcome!");
            while (true)
            {
                Console.WriteLine("0. Quit");
                Console.WriteLine("1. Create a question");
                Console.WriteLine("2.Answer the Question");
                Console.WriteLine("3. Total Number of correct Answers");
                Console.WriteLine("4.Total Number of Incorrect Answers");
                Console.WriteLine("5.print all questions");
                Console.Write("please select an option from above");
                var choice = Console.ReadLine();

                switch (choice)
                {
                    case "0":
                        return;
                    case "1":
                        Console.Write("enter roll number: ");
                        var rollNumber = int.Parse(Console.ReadLine());
                        Console.Write("write the question text: ");
                        var questionText = Console.ReadLine();
                        Console.Write("write option1: ");
                        var option1 = Console.ReadLine();
                        Console.Write("write option2: ");
                        var option2 = Console.ReadLine();
                        Console.Write("write option3: ");
                        var option3 = Console.ReadLine();
                        Console.Write("write option4: ");
                        var option4 = Console.ReadLine();
                        Console.Write("correct option: ");
                        var correctOption = int.Parse(Console.ReadLine());
                        Console.Write("Answer the question: ");
                        var markedOption = int.Parse(Console.ReadLine());
                        var question= Test.CreateQuestion(questionText,option1,option2, option3, option4, correctOption,markedOption,rollNumber);

                        
                        Console.WriteLine($"QN: {question.QuestionNumber}, QT: {question.QuestionText}, o1: {question.option1}, o2: {question.option2}, o3:  {question.option3}, o4:  {question.option1}, ma: {question.MarkedOption}, ca: {question.correctOption}, evaluate: {question.isAnsweredCorrect}");


                        break;
                    case "5":
                        Console.Write("enter roll number: ");
                        rollNumber = int.Parse(Console.ReadLine());

                        var questions= Test.GetAllQuestions(rollNumber);
                        foreach( var q in questions)
                        {
                            Console.WriteLine($"QN: {q.QuestionNumber}, QT: {q.QuestionText}, o1: {q.option1}, o2: {q.option2}, o3:  {q.option3}, o4:  {q.option1}, ma: {q.MarkedOption}, ca: {q.correctOption}, evaluate: {q.isAnsweredCorrect}");


                        }
                        break;




                }
            }


        }
    }


}
    

