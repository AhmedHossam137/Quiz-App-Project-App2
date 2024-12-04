using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz_App_Project_App2
{
    internal class Program
    {
        static int correctAnswers = 0;
        static int incorrectAnswers = 0;

        static void Main(string[] args)
        {
            /*i just make 3 questions not 10 , it is the same logic 
            Submitted by: Ahmed Hossam Hosni Hammad 
            To: Eng Eslam 
            simple console quiz application 
             */
            Console.WriteLine(" Welcome to Quiz Application ");
            getData();
            printQuestions();
            printEndScore();
        }

        static void getData()
        {
            try
            {
                Console.WriteLine("Enter your Name");
                String studentName = Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine("Enter your Age ");
                int ageofStudent = int.Parse(Console.ReadLine());
                Console.WriteLine("Welcome " + studentName);
            }
            catch
            {
                Console.WriteLine("You should enter your name as text and your age as number.");
            }
        }

        public static void printQuestions()
        {
            string[,] questions = { { "Which of the following is a contextual keyword in C#?", "A - get B - set C - add  D - All of the above.","D" },
                                   {"Which of the following converts a type to a Boolean value, where possible in C#?","A - ToBoolean B - ToSingle C - ToChar D - ToDateTime","A" },
                                   {"Which of the following converts a type to a 32-bit integer in C#?","A - ToDecimal B - ToDouble  C - ToInt16 D - ToInt32","D" },
            };
            // print questions
            for (int i = 0; i < questions.GetLength(0); i++)
            {
                Console.WriteLine(questions[i, 0]);
                Console.WriteLine();

                // Display the multiple choice options
                for (int j = 1; j < questions.GetLength(1) - 1; j++)
                {
                    Console.WriteLine(questions[i, j]);
                }
                checkAnswer(questions, i);
            }
        }

        public static void checkAnswer(string[,] questions, int i)
        {
            Console.Write("Enter your answer (A-D): ");
            string answer = Console.ReadLine().ToUpper();

            // Check if the answer is correct
            if (answer == questions[i, questions.GetLength(1) - 1][0].ToString())
            {
                Console.WriteLine("Correct!");
                correctAnswers++;
            }
            else
            {
                Console.WriteLine("Incorrect. The correct answer is " + questions[i, questions.GetLength(1) - 1]);
                incorrectAnswers++;
            }
        }

        public static void printEndScore()
        {
            Console.WriteLine();
            Console.WriteLine("Quiz completed. Here is your score:");
            Console.WriteLine("Correct Answers: " + correctAnswers);
            Console.WriteLine("Incorrect Answers: " + incorrectAnswers);
        }
    }
}