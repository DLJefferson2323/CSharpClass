using System;

/* This class goes over lesson 18 content
Exception Handling */
namespace CSharpClass.Lessons
{
    public class Lesson18
    {
        public void MyThrowExample(House house)
        {
            if (house == null)
            {
                throw new NullReferenceException("House object is null");
            } // end method if null statement
            Console.WriteLine(house.DoorColor);
        } // end method my throw example

        public void MyException(House house)
        {
            try
            {
               Console.WriteLine(house.DoorColor);
            } // end method try
            catch (NullReferenceException ex)
            {
                Console.WriteLine("Null Exception thrown. "+ex.Message);
                throw;
            } // end method catch
            finally
            {
                Console.WriteLine("Finally blocked called");
            } // end method finally
        } // end method my exception example

        public void MyArrayException()
        {
            string[] names = { "Dave", "Matt", "Jody" };
            string[] values = { "24333", "424444", "38543" };

            try  
            {
                byte b = byte.Parse(values[1]);
                Console.WriteLine(b);
            } // end method try
            catch (IndexOutOfRangeException ex) 
            { 
                Console.WriteLine("Please provide at least 1 argument"); 
            } // end method index out of range exception
            catch (FormatException fe) 
            { 
                Console.WriteLine("That is not a number"); 
            } // end method format exception
            catch (OverflowException oe) 
            { 
                Console.WriteLine("You have given me more than a byte"); 
            } // end method overflow exception
        }


    } // end class
} // end namespace