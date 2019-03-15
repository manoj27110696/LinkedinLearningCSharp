using System;

namespace LinkedinLearningCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name ?");
            string name=AnswerQuestion();
            Console.WriteLine("How old are you ?");
            string age = AnswerQuestion();
            Console.WriteLine("What month were you born in");
            string month = AnswerQuestion();
            Console.WriteLine("Your Name : {0}", name);
            Console.WriteLine("Your Age :{0}", age);
            Console.WriteLine("You were born in the month : {0}", month);
            if (month == "march")
            {
                Console.WriteLine("You are an Aries");
            }
            else if (month == "april")
            {
                Console.WriteLine("You are a Taurus");
            }
            else if (month == "July")
            {
                Console.WriteLine("You are an Orion");
            }
            Console.ReadKey();


        }

        static string AnswerQuestion()
        {
            string Answer=Console.ReadLine();
            if(Answer=="")
            { 
            Console.WriteLine("You didnt write anything,please try again");
            return Console.ReadLine();           
            }
           else
           return Answer;
             
        }
    }
}
