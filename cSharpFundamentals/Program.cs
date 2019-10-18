using System;

namespace cSharpFundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            //value types
            var a = 10;
            var b = a;
            b++;

            Console.WriteLine(string.Format("a: {0}, b: {1}", a, b));

            //refernce types
            var array1 = new int[3] { 1, 2, 3 };
            var array2 = array1;
            //creates a new address that points to the same orginal value
            array2[0] = 0;
            Console.WriteLine(string.Format("array1: {0}, array2: {1}", array1, array2));
        }
    }
}
