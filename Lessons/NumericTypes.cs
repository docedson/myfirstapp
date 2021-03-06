using System;

namespace Lessons
{
    public class NumericTypes
    {
       // Integral - Signed 
       // range -128 to -127
       sbyte _mySbyteValue = 2;

       // range -32,768 to -32,767
       short _myShortValue = 4;

       // range -2,147,483,648 to - 2,147,483,647
       int _myIntValue = 25000;

       // range -9,223,372,036,854,775,808 to -9,223,372,036,854,775,807
       long _myLongValue = 1_234_567L;
       long _myLongValue2 = 0x5F;

       // Integral - Unsigned
       // rage 0 to 55
       byte _myByteValue = 3;

       // range 0 to 65,535
       ushort _myUShortValue = 35;

       // range 0 to 4,294,967,295
       uint _myUInt = 2345U;

       // range 0 to 18,46,744,073,709,551,615
       ulong _myULongValue = 123456UL;

       // Real Numbers
       // range 3.4E +/- 38(7digits)
       float _myFloatValue = -123.6589F;

       // range 1.7E +/- 308(15 digits)
       double _myDoubleValue = 12.34;
       double _myDoubleValue2 = 1E06;

       // range -7.9228E+24 to 7.9228E+24
       decimal _myDecimalValue = 13.234M;

       public void GetSomeType()
       {
           Console.WriteLine(3.0.GetType());
           Console.WriteLine(_myFloatValue.GetType());
       }

    }
}