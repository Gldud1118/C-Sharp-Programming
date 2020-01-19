using System;

namespace PrimitiveTypesToBinary
{
    class Program
    {
        static void Main(string[] args)
        {

            Byte byte1 = byte.MinValue;
            Byte byte2 = byte.MaxValue;

            int int1 = int.MinValue;
            int int2 = int.MaxValue;

            long long1= long.MinValue;
            long long2 = long.MaxValue;

            char char1 = 's';
            char char2 = 'A';

            Console.WriteLine($"Byte1 ===> {Convert.ToString(byte1, 2)}");
            Console.WriteLine($"Byte2 ===> {Convert.ToString(byte2, 2)}");

            Console.WriteLine($"int1 ===> {Convert.ToString(int1, 2)}");
            Console.WriteLine($"int2 ===> {Convert.ToString(int2, 2)}");

            Console.WriteLine($"ulong1 ===> {Convert.ToString(long1, 2)}");
            Console.WriteLine($"ulong2 ===> {Convert.ToString(long2, 2)}");

            Console.WriteLine($"char1 ===> {Convert.ToString(char1, 2)}");
            Console.WriteLine($"char2 ===> {Convert.ToString(char2, 2)}");
        }
    }
}
