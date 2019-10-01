using System;

namespace CSharpClass
{
    // A simple application using C#
    public class Example1
    {
        // The main function
        public void MyExampleSample()
        {
            // Outer Scope
            int i =1;
            {
                // Inner Scope
                int j =2;
                // Displaying the Outer Scope value
                Console.WriteLine("The Outer Scope value is " + i);

                // Displaying the Inner Scope value
                Console.Read();
            }
            // Console.WriteLine("The Inner Scope value is " + j);
        }

    }
}