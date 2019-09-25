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
           // MyLesson5Examples();
           MyLesson6Examples(); 
        } // End Method Main

        static void MyLesson6Examples()
        {
             Lesson6 mySix = new Lesson6();
             mySix.MyTrimExample();
             mySix.MyEqualsExample();
             mySix.MyLowerUpperExample();
             mySix.MyStringLength();
             string myJoined = mySix.MyJoinedStrings("Happy","Coding");
             Console.WriteLine(myJoined);
             string myFav = mySix.MyStringBuilder("Taco Salad",4);
             Console.WriteLine(myFav);
             mySix.MyExampleChar();
             mySix.MyEscapeExample();
             mySix.MyPlaceHolderExample("Mortal Kombat", "Classic Fighting Game");

        } // end method my lesson 6 examples

        static void MyLesson5Examples()
        {
            Lesson5 myFive = new Lesson5();
            myFive.ConvertFloatToInt();
            myFive.LongFromtInt();
        } // End method my lesson 5 examples

    } // End Class
} // end namespace
