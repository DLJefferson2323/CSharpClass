using System;

namespace CSharpClass.Lab2
{
    public class Pony : Horse
    {
        string _teeth;
        string _coursehair;

        public string Teeth { get; set; }

        public void playful()
        {

        } // end method playful

        public override void Racing()
        {
            Console.WriteLine("The pony is not racing.");
        } // end override method racing

        public string CourseHair 
        {
            get { return _coursehair;}
            set { _coursehair = value;}
        } // end softhair

    } // end class
} // end namespace