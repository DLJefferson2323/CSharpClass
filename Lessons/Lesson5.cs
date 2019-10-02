using System;

namespace CSharpClass.Lessons
{
    /*This class goes over value types
    Lesson 5 - Value Types */
    public class Lesson5
    {
        // Integral
        // range -128 to 127
        sbyte _mySByteValue = 2;

        // range -32,768 to 32,767
        short _myShortValue = 4;

        // range -2,147,483,648 to 2,147,483,647
        int _myIntValue = 25000;

        // range -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807
        internal long _myLongValue = 1234567L;

        // Integral - Unsigned
        // range 0 - 255
        byte _myByte = 3;

        // range 0 - 65,535
        ushort _myUShortValue = 35;

        // range 0 - 4,294,967,295
        uint _myUInt = 2345U;

        // range 0 to 18,446,744,073,709,551,615
        ulong _myULong = 123456UL;

        // Real Numbers
        // range 3.4E +/- 38 (7 digits)
        float _myFloatValue = -123.6589F;

        // range 1.7E +/- 308 (15 digits)
        double _myDoubleValue = 12.34D;

        // range -7.9228E+24 to 7.9228E+24
        decimal _myDecimalValue = 13.234M;

        // Ingetral Literals
        // Decimal value of 26
        int _value = 26;

        // Hexadecimal value of 26
        int value2 = 0x1a;

        // Binary value of 26
        int _value3 = 0b11010;

        // Notation & Underscores
        double _valNote = 6.26e-22;

        // Using _ to separate numbers
        long _myUnderscoreLong = 1_234_834L;

        double _myUnderscoreDouble = 1_348.4;

        // Casting
        // Explicit cast where fractions are truncated and not rounded
        public void ConvertFloatToInt()
        {
            // local variable
            int converted = (int)_myFloatValue;
            Console.WriteLine(converted);
        }// End method convert float to int

        // Implicit cast which requires no casting
        public void LongFromtInt()
        {
            long someLongValue = _myIntValue;
            Console.WriteLine(someLongValue);

        } // End method long from int

    } // End Class
} // End Namespace