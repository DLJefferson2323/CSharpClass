using System;

namespace CSharpClass.Lab3
{
    public class LEDTelevision : Television
    {
        public override void TurnOn()
        {
            Console.WriteLine("Turn on with remote");
        } // end override

        public LEDTelevision(int size, decimal price, int ports,
        bool isMountable)
            : base (size, price, ports, isMountable)
            {

            } // end base
        public LEDTelevision(int size, decimal price)
            : this (size, price, 4, false)
            {

            } // end this

    } // end class
} // end namespace