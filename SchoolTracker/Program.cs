using System;
using System.Collections.Generic;

namespace SchoolTracker
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a program to accept to set of ten students
             int[] StudentGrades=new int[]{80,77,45,87,54,42,67,24,86,98,40 };

            foreach(var item in StudentGrades)
            {
                Console.WriteLine(item);
            }
            
        }
    }
}
