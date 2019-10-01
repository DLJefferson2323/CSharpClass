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
           //MyLesson7Examples();
           //MyExampleSample();
           //MyLesson8Examples();
           MyOtherLesson8Examples();
        } // End Method Main

        static void MyOtherLesson8Examples()
        {
            Lesson8 MyLesson8 = new Lesson8();
            //MyLesson8.BasicWhileLoop();
            //MyLesson8.BasicDoWhileLoopExample();
            //MyLesson8.BasicForLoopExample(5);
            //MyLesson8.BasicForEachLoopExample();
            Console.WriteLine(MyLesson8.BasicJumpStatementExample("Sunday"));
            MyLesson8.BasicOtherJumpStatement();
        } // end method my other lesson 8 examples

        static void MyLesson8Examples()
        {
            Lesson8 myEight = new Lesson8();
            myEight.BasicIfStatement();
            myEight.BasicIfElseExample();
            myEight.BasicIfElseChainExample();
            Console.WriteLine(myEight.BasicAndConditionExample());
            Console.WriteLine(myEight.BasicOrConditionExample(34));
            myEight.BasicTernaryOperatorExample(42);
            myEight.BasicSwitchExample(2);  
        } // end method my lesson 8 examples

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

        static void MyExampleSample()
        {
            Example1 exam1 = new Example1();
            exam1.MyExampleSample();
        }

    } // End Class
} // end namespace
