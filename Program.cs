using System;
using CSharpClass.Lessons;
using CSharpClass.Lab2;

namespace CSharpClass
{
    /* This class is the start of My Application.
    Lesson 3 - My First Application */
    class Program
    {       
        static void Main(string[] args)
        {
           //Console.WriteLine("Hello World!");
           //MyLesson5Examples();
           //MyLesson6Examples();
           //MyLesson7Examples();
           //MyExampleSample();
           //MyLesson8Examples();
           //MyOtherLesson8Examples();
           //MyLesson9Examples();
           //MyLesson10Examples();
           //MyLesson11Examples();
           //MyBeerSong();
           //MyLab2();
           //MyLesson13House();
           //MyLesson14Examples();
           Lesson15Examples();

        } // End Method Main

        static void Lesson15Examples()
        {
            Lesson15 my15 = new Lesson15();
            my15.CheckExternalEnum();
            my15.MyFavoriteFlavor(Lesson15.IceCreamFlavors.Strawberry);

            my15[2] = 17;
            for (int i = 0; i < my15.ConeArrayLength; i++)
            {
                Console.WriteLine("Value of {0} = {1}", i, my15[i]);
            }

        } // end my method lesson 15 examples

        static void MyLesson14Examples()
        {
            Lesson14Static.CelsiustoFahrenheit("34.5");
            Lesson14Static.FahrenheittoCelsius("34.5");

            Lesson14Derived myLesson14 = new Lesson14Derived(9);
            myLesson14.ShowResultsFeet();
            myLesson14.ShowResultMiles();

        } // end my method my lesson 14 examples

        static void MyLesson13House()    
        {
            House myHouse = new House(36, "granite");
            Console.WriteLine(myHouse.DoorColor);
            myHouse.RoofType = "steel";
            myHouse.DoorOpenClose();
        } // end my method my lesson 13 house

        static void MyLab2()
        {
            Counting myLab2 = new Counting();
            myLab2.MyLab2();
        } // end my lab 2

        static void MyBeerSong()
        {
            BottlesOfBeer beer = new BottlesOfBeer();
            Console.WriteLine(beer.LetsSing());
        } // end my beer song

        static void MyLesson11Examples()
        {
            Lesson11 myEleven = new Lesson11("Happy", 69);
            Lesson11 myOtherEleven = new Lesson11(22);
            Lesson11 MyLesson11 = new Lesson11();

            Lesson11Struct myStruct = new Lesson11Struct(15.99m, "Jefferson", 
            "The Calling");
            int myValue = 14;
            myEleven.MyBasicRefExample(ref myValue);
            Console.WriteLine(myValue + " from program");

            string first, last;
            MyLesson11.MyBasicOutExample("Optimus Prime", out first, out last);
            Console.WriteLine(first);
            Console.WriteLine(last);
        } // end method my lesson 11 examples

        static void MyLesson10Examples()
        {
            Lesson10 myTen = new Lesson10();
            myTen.BasicPublicMethod();
            Lesson5 myFive = new Lesson5();
            myFive._myLongValue = 12345L; // can see because it's internal

        } // end method my lesson 10 examples

        static void MyLesson9Examples()
        {
            Lesson9 myNine = new Lesson9();
            //myNine.BasicArray();
            //myNine.MutliArraySample();
            //myNine.My3DArrayExample();
            //myNine.MyJaggedArrayExample();
        } // end method my lesson 9 examples

        static void MyOtherLesson8Examples()
        {
            Lesson8 MyLesson8 = new Lesson8();
            //MyLesson8.BasicWhileLoop();
            //MyLesson8.BasicDoWhileLoopExample();
            //MyLesson8.BasicForLoopExample(5);
            //MyLesson8.BasicForEachLoopExample();
            //Console.WriteLine(MyLesson8.BasicJumpStatementExample("Sunday"));
            //MyLesson8.BasicOtherJumpStatement();
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
