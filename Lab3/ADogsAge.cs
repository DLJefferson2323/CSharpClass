using System;

/* This class contains Lab 3 going over 
Dog Years */
namespace CSharpClass.Lab3
{
    public class ADogsAge
    {
        public void SmallDogToHumanYears()
        {
            for (int i = 15; i < 80; i++)
            {
                //Console.WriteLine("For Number = {0}", i);
                if (i % 4 == 0)

                {
                    Console.WriteLine("For Number = {0}", i);
                }
            } // end for

        } // end Small Dog to Human Years
    } // end class
} // end namespace