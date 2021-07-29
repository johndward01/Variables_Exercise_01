using System;
using System.Collections.Generic;

namespace Variables_Exercise_01
{
    class Program
    {
        public struct PointA // A Value Type Container with a parameterized constructor
        {
            private double X;
            private double Y;

            public PointA(double x, double y)
            {
                X = x;
                Y = y;
            }
        }
        public struct PointB // A Value Type Container with default constructor
        {
            public double X { get; set; }
            public double Y { get; set; }
        }

        public struct Person // Bonus
        {
            public string name;
            public int age;
        }

        public enum WeekDays { Sun = 1, Mon, Tue, Wed, Thu, Fri, Sat }; // A Value Type Collection

        public enum Suits
        {
            Clubs,
            Diamonds,
            Spades,
            Hearts,
            Jokers
        }

        static void Main(string[] args)
        {
            var myList = new List<object>();

            // - Complete all of the TODO's for this exercise
            // - Once finished save, commit, and then push to GitHub!

            #region List of C# Value Types https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/value-types
            //  DATATYPES         |       Size            |                       VALUES                          |
            sbyte _sbyte;               // 8 bit	                      -128 to 127
            byte _byte;                 // 8 bit	                         0 to 255
            short _short;               // 16 bit	                   -32,768 to 32,767
            ushort _ushort;             // 16 bit	                         0 to 65,535
            int _int;                   // 32 bit	            -2,147,483,648 to 2,147,483,647
            uint _uint;                 // 32 bit	                         0 to 4,294,967,295
            long _long;                 // 64 bit	-9,223,372,036,854,775,808 to 9,223,372,036,854,775,807
            ulong _ulong;               // 64 bit	                         0 to 18,446,744,073,709,551,615

            float _float;               // 32 bit	               -1.5 x 1045 to 3.4 x 1038
            double _double;             // 64 bit	                -5 x 10324 to 1.7 x 10308
            decimal _decimal;           // 128 bit	                     -1028 to 7.9 x 1028

            char _char;                 // 16 bit	                         0 to 65535
            bool _bool;                 // ~1 bit	                      True or false
            #endregion

            #region// TODO: Declare 5 constansts
            const int Months = 12, Weeks = 52, Days = 365;
            const int FavoriteNumber = 100;
            const string Cryptographic_GUID = "sldkf$($&*j23o38i*&!idbu12ygeML83#@($^&jkfd78f3$($&*f28CX^&*Uidsjkjf0-I#&YCB#*@!Y$($&**&^D*S!GBFDJHjcbr$($&*jhmdsjc76g1hjbvx3y7u";
            #endregion

            #region // TODO: Declare 2 variables of each type from the list above (1 pair for each) 
            // TODO: Initialize 1 of the variables with that datatypes minimum value
            // TODO: Initialize the other variable with that datatypes maximum value
            sbyte mySByte1 = sbyte.MinValue;
            sbyte mySByte2 = sbyte.MaxValue;
            byte myByte1 = byte.MinValue;
            byte myByte2 = byte.MaxValue;
            short myShort1 = short.MinValue;
            short myShort2 = short.MaxValue;
            ushort myUShort1 = ushort.MinValue;
            ushort myUShort2 = ushort.MaxValue;
            int myInt1 = int.MinValue;
            int myInt2 = int.MaxValue;
            uint myUInt1 = uint.MinValue;
            uint myUInt2 = uint.MaxValue;
            long myLong1 = long.MinValue;
            long myLong2 = long.MaxValue;
            ulong myULong1 = ulong.MinValue;
            ulong myULong2 = ulong.MaxValue;
            float myFloat1 = float.MinValue;
            float myFloat2 = float.MaxValue;
            double myDouble1 = double.MinValue;
            double myDouble2 = double.MaxValue;
            decimal myDecimal1 = decimal.MinValue;
            decimal myDecimal2 = decimal.MaxValue;
            char letter = ' ';
            char number = '2';
            char myChar1 = char.MinValue;
            char myChar2 = char.MaxValue;
            bool isTrue = true;
            bool isFalse = false;
            #endregion

            #region// TODO: Write out each of the variables to the Console 

            Console.WriteLine(mySByte1);
            Console.WriteLine(mySByte2);


            Console.WriteLine(myByte1);
            Console.WriteLine(myByte2);

            Console.WriteLine(myShort1);
            Console.WriteLine(myShort2);

            Console.WriteLine(myUShort1);
            Console.WriteLine(myUShort2);

            Console.WriteLine(myInt1);
            Console.WriteLine(myInt2);

            Console.WriteLine(myUInt1);
            Console.WriteLine(myUInt2);

            Console.WriteLine(myLong1);
            Console.WriteLine(myLong2);

            Console.WriteLine(myULong1);
            Console.WriteLine(myULong2);

            Console.WriteLine(myFloat1);
            Console.WriteLine(myFloat2);

            Console.WriteLine(myDouble1);
            Console.WriteLine(myDouble2);

            Console.WriteLine(myDecimal1);
            Console.WriteLine(myDecimal2);

            Console.WriteLine(isTrue);
            Console.WriteLine(isFalse);
            #endregion



            #region// **BONUS**
            // TODO: Create your own enum and initialize it with constants of your choosing            
            // TODO: Declare it and then iterate through it writing out to the console            
            PrintEnumItems();

            // TODO: Instantiate a struct and initialize all of it's members            
            PointA myStruct2 = new PointA(1, 1);
            PointB myStruct3 = new PointB();
            myStruct3.X = 2;
            myStruct3.Y = 2;

            Person myStruct4; // using fields instead of properties we can use value type instantiation
            myStruct4.age = 33;
            myStruct4.name = "John Doe";

            #endregion
        }
        public static void PrintEnumItems()
        {
            foreach (string name in Enum.GetValues(typeof(Suits)))
            {
                Console.WriteLine(name.ToString());
            }
        }

    }
}
