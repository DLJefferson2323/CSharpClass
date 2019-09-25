using System;
using System.Text;

namespace CSharpClass.Lessons
{
    public class Lesson6
    {
        string _myString = "Hello";

        public void MyTrimExample()
        {
            string myString = " Hello ";
            Console.WriteLine("Before Trim");
            Console.WriteLine(myString);
            string myTrim = myString.Trim();
            Console.WriteLine("After Trim");
            Console.WriteLine(myTrim);

        } // end method my trim example

        public void MyEqualsExample()
        {
            bool isExampleEqual = _myString.Equals("World");
            Console.WriteLine(isExampleEqual);

        } // end method my equals example 

        public void MyLowerUpperExample()
        {
            // Nested Method - Method called through another method.
            Console.WriteLine(_myString.ToLower());
            Console.WriteLine(_myString.ToUpper());
        } // end method my lower upper example

        public void MyStringLength()
        {
            Console.WriteLine(_myString.Length);
        } // end method my string length

        public string MyJoinedStrings(string value1, string value2)
        {
            return value1 + value2;

        } // end method my joined strings

        public string MyStringBuilder(string food, int amount)
        {
            StringBuilder builder = new StringBuilder();
            builder.Append("My favorite food is ");
            builder.Append(food).Append(" and I ate ")
            .Append(amount).Append(" plates of it.");
            return builder.ToString();
        } // end method my string builder

        public void MyExampleChar()
        {
            char myChar = 't';
            char myOtherChar = '\u00A7';
            char copyright = '\u00A9';
            Console.WriteLine(myOtherChar);
            Console.WriteLine(copyright);
        } // end method my example char

        public void MyEscapeExample()
        {
            Console.WriteLine("That\'s a cool toy. \tCan I\n play with it?");
        } // end method my escape example

        public void MyPlaceHolderExample(string game, string type)
        {
            Console.WriteLine("My favorite game {0} is a {1}", game, type);
        } // end method my place holder example

    } // end class
} // end namespace