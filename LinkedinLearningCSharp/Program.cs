using System;

namespace LinkedinLearningCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var passcode="";
            int nooftries=0;
          while(passcode!="secret" && nooftries<3)
          { 
          Console.WriteLine("Enter the Passcode");
          passcode=  Console.ReadLine();
            if(passcode=="secret")
            {
                Console.WriteLine("Your are successfully authenticated");
            }
            else
                { 
                Console.WriteLine("please retry and enter the correct passcode");
                nooftries++;
                }
          }

          if(nooftries==3)
            {
                Console.WriteLine("You have exceeded the {0} attempts",nooftries);
            }

        }
    }
}
