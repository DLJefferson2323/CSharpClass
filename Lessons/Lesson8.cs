using System;

namespace CSharpClass.Lessons
{
    /* This class goes over content for Lesson 8
    Control Flow Statements */

    public class Lesson8
    {
        // Basic IF statement
        public void BasicIfStatement()
        {
            int value = 17;
            Console.WriteLine("Before if statement");
            if (value > 15)
            {
                Console.WriteLine("Statement was valid");
            } // end if
            Console.WriteLine("After if statement");
        } // end method basic if statement

        //Basic If/Else statement
        public void BasicIfElseExample()
        {
            int value = 12;
            Console.WriteLine("Before if statement");
            if (value >= 15)
            {
                Console.WriteLine("Statement was valid");
            } // end if
            else
            {
                Console.WriteLine("Statement was not valid");
            } // end else
            Console.WriteLine("After if else statement");
        } // end method basic if/else statement

        // Basic If/Else chain
        public void BasicIfElseChainExample()
        {
            int value = 18;
            Console.WriteLine("Before if");
            if (value == 15)
            {
                Console.WriteLine("Statement was valid 15");
            } // end if

            else if (value == 18)
            {
                Console.WriteLine("Statement was valid 18");
            } // end else if

            else
            {
                Console.WriteLine("Statement was valid");
            } //end else

            Console.WriteLine("After if else chain");
        } // end method basic if else chain example

        // This method uses the && operator
        public string BasicAndConditionExample()
        {
            int value = 18;
            Console.WriteLine("Before if statement");
            if (value > 15 && value < 30)
            {
                return "Statement was valid";
            } // end if

            else
            {
                return "Statement was not valid";
            }
        } // end basic and condition example

        // This method uses the || (OR) example
        public int BasicOrConditionExample(int able)
        {
            Console.WriteLine("Before If Statement");
            if (able == 12 || able > 13)
            {
                return able;
            } // end if
            else
            {
                return 0;
            } // end else
        } // end method basic || or condition example

        // This method shows a shortcut if statement called the ternary operator
        public void BasicTernaryOperatorExample(int beta)
        {
            string valid = beta > 30 ? "valid" : "not valid";
            Console.WriteLine("valid");
        } // end method basic ternary operator example

        // This method shows basic switch statement
        public void BasicSwitchExample(int charlie)
        {
            switch (charlie)
            {
                case 1:
                case 2:
                    Console.WriteLine("1 or 2 was chosen");
                    break;
                case 3:
                    Console.WriteLine("3 was chosen");
                    break;
                case 4:
                    Console.WriteLine("4 was chosen");
                    break;
                case 5:
                    Console.WriteLine("5 was chosen");
                    break;
                default:
                    Console.WriteLine("The number was greater than 5");
                    break;
            } // end switch
        } // end method basic switch example

        // This method shows a basic while loop
        public void BasicWhileLoop()
        {
            int value = 0;
            while (value < 15)
            {
                Console.WriteLine("number = {0}", value);
                value++;
            } // end while
        } // end method basic while loop

        // Basic do while loop
        public void BasicDoWhileLoopExample()
        {
            int value = 0;
            do
            {
                Console.WriteLine("Do While Number = {0}", value);
                value++;
            } while (value < 12);

        } // end method basic do while loop example

        // This method shows a basic for loop
        public void BasicForLoopExample(int total)
        {
            for (int i = 0; i < total; i++)
            {
                Console.WriteLine("For Number = {0}", i);
            } // end for
        } // end basic for loop example

        // This method shows a foreach loop
        public void BasicForEachLoopExample()
        {
            foreach (char ch in "Something")
            {
                Console.WriteLine(ch);
            } // end foreach
        } // end method basic foreach loop example

        // This method shows different jump statements
        public string BasicJumpStatementExample(string day)
        {
            switch (day)
            {
                case "Sunday":
                    goto default;
                case "Monday":
                case "Tuesday":
                    return "Test something Monday or Tuesday";

                default:
                    return "Test Nothing";
            } // end switch
        } // end method basic jump statement example

        // This method shows other jump statements
        public void BasicOtherJumpStatement()
        {
            for (int i = 0; i < 10; i++)
            {
                if(i == 2)
                {
                    continue;
                }
                if(i == 4)
                {
                    Console.WriteLine("loop breaks");
                    break;
                } // end if
                Console.WriteLine(i);
            } // end for
            Console.WriteLine("End of loop");
        } // end method basic other jump statements

    } // end class
} // end namespace