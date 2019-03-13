using System;

namespace LinkedinLearningCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
          Console.WriteLine("What is your name ?");
          String a=  Console.ReadLine();
          Console.WriteLine("How old are you ?");
          String b=Console.ReadLine();
          Console.WriteLine("What month were you born in");
          String c=Console.ReadLine();
          Console.WriteLine("Your Name : {0}",a);
          Console.WriteLine("Your Age :{0}",b);
          Console.WriteLine("You were born in the month : {0}",c);
          Console.ReadKey();


        }
    }
}
