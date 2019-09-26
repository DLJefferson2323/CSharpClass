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
           // MyLesson6Examples();
           MyLesson7Examples();
        } // End Method Main

        static void MyLesson7Examples()
        {
            Lesson7 mySeven = new Lesson7();
            mySeven.BasicMath();
            mySeven.BasicModulus();
            mySeven.MyCheckOperator1();
            mySeven.MyCheckOperator2();
            mySeven.MyLeftShiftOperator();
            mySeven.MyRightShiftOperator();
            mySeven.MyAndAssignmentOperator();
            mySeven.MyOrAssignmentOperator();
            mySeven.MyXORAssignmentOperator();
            mySeven.MyIncrementDecrementExample();
        } // end method my lesson 7 examples

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
