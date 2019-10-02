using System;

/* This class will discuss Lesson 10 content
Lesson 10 - Access Modifiers */
namespace CSharpClass.Lessons
{
    public class Lesson10
    {
        // This method shows the private modifier
        private void BasicPrivateMethod()
        {
            Console.WriteLine("This is from a private method");
        } // end method basic private method

        
        // This method shows the public modifier
        public void BasicPublicMethod()
        {
            // Will access the private method above
            BasicPrivateMethod();
            // The next action is to change a value from lesson 5
            Lesson5 MyLesson5= new Lesson5();
            MyLesson5._myLongValue = 985632741L;
            Console.WriteLine("This value {0} is from lesson 5 internal modifier",
            MyLesson5._myLongValue);
        } // end method basic public method

    } // end class
} // end namespace