using System;

namespace CSharpClass.Lab3
{
    
    public class UltraTelevision : Television
    {
        public override void TurnOn()
        {
            Console.WriteLine("Turn on with app");
        } // end override

        public UltraTelevision(int size, decimal price, int ports,
        bool isMountable)
            : base (size, price, ports, isMountable)
            {

            } // end base
        public UltraTelevision(int size, decimal price)
            : this (size, price, 4, false)
            {

            } // end this
    } // end class
} // end namespace