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

        public enum MyEnum { Sun, Mon, Tue, Wed, Thu, Fri, Sat }; // A Value Type Collection

        static void Main(string[] args)
        {
            var myList = new List<object>();

            // - Complete all of the TODO's for this exercise
            // - Once finished save, commit, and then push to GitHub!

            #region List of C# Value Types https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/value-types
            //  DATATYPES         |       Size         |                     VALUES                          |
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

            // TODO: Declare 5 constansts
            const int Months = 12, Weeks = 52, Days = 365;
            const int FavoriteNumber = 100;
            const string Cryptographic_GUID = "sldkf$($&*j23o38i*&!idbu12ygeML83#@($^&jkfd78f3$($&*f28CX^&*Uidsjkjf0-I#&YCB#*@!Y$($&**&^D*S!GBFDJHjcbr$($&*jhmdsjc76g1hjbvx3y7u";

            // TODO: Declare 2 variables of each type from the list above (1 pair for each) 
            // Make sure to use C# naming convention best practices (camelCase, PascalCase, etc...)




            // TODO: Initialize 1 of the variables with that datatypes minimum value
            // TODO: Initialize the other variable with that datatypes maximum value
            // TODO: Write out each of the variables to the Console 




            // **BONUS**
            // TODO: Create your own enum and initialize it with constants of your choosing
            // TODO: Declare it and then iterate through it writing out to the console            
            // TODO: Instantiate a struct and initialize all of it's members
            // TODO: Create a program that creatively displays all of the variables you have created

        }

    }
}
