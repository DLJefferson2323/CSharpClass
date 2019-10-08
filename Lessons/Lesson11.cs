using System;

/*This class goes over the lesson 11 Constructors, 
Structs & More */
namespace CSharpClass.Lessons
{
    public class Lesson11
    {
        public Lesson11(string type, int value)
        {
            Console.WriteLine("This {0} type and {1} value are from a constuctor",
            type, value);

        } // end constructor

        public Lesson11(int value)
        {
            Console.WriteLine("This {0} value came from a different constuctor",
            value);
        } // end constructor

        public Lesson11()
        {
            Console.WriteLine("My default constructor");
        } // end default constructor

        // This method uses the REF keyword
        public void MyBasicRefExample(ref int able)
        {
            able += 6;
            Console.WriteLine(able);

        } // end my basic ref example

        // This method uses the out keyword
        public void MyBasicOutExample(string name, out string firstName,
        out string lastName)
        {

            int myIndex = name.IndexOf(' ');
            firstName = name.Substring(0, myIndex);
            lastName = name.Substring(myIndex + 1);

        } // end method my basic out example

    } // end class
} // end namespace