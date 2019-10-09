using System;

/* This class is a child class of House Lesson 12 Inheritance*/
namespace CSharpClass
{
    public class Condo : House
    {
        public string Balcony { get; set; }

        public Condo()
            : this("second floor")
        {

        } // end condo

        public Condo(string balcony)
            : base(36, "granite")
        {
            Balcony = balcony;
        }


        public void Maintenance() { base.DoorOpenClose(); }



        public override void DoorOpenClose()
        {
            base.DoorOpenClose();
            Console.WriteLine("This condo door is closed");
        } // end override
    } // end class
} // end namespace