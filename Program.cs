using System;
using CSharpClass.Lessons;

namespace CSharpClass
{
    /* This class is the start of My Application.
    Lesson 3 - My First Application */
    class Program
    {
        static void Main(string[] args)
        {
           // Console.WriteLine("Hello World!");
           MyLesson5Examples();
        } // End Method Main

        static void MyLesson5Examples()
        {
            Lesson5 myFive = new Lesson5();
            myFive.ConvertFloatToInt();
            myFive.LongFromtInt();
        } // End method my lesson 5 examples

    } // End Class
} // end namespace
