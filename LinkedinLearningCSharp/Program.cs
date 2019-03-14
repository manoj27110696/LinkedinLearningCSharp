using System;

namespace LinkedinLearningCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int repeat = 1; repeat <= 5; repeat++)
            {
                for (int count = 1; count <= 10; count++)
                {
                    Console.WriteLine(count);
                }
                for (int count = 10; count >= 1; count--)
                {
                    Console.WriteLine(count);
                }

            }

        }

    }    
}
