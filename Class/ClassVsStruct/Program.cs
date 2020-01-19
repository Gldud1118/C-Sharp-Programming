using System;

namespace ClassVsStruct
{
    class Program
    {
        static void Main(string[] args)
        {
            Vector1 v1 = new Vector1(10, 20);
            Vector2 v2 = new Vector2(10, 20);

            Vector1 result1 = Vector1.Square(v1);

            Console.WriteLine(v1.X);
            Console.WriteLine(v1.Y);

            Vector2 result2 = Vector2.Square(v2);

            Console.WriteLine(v2.X);
            Console.WriteLine(v2.Y);

            Vector2.Square(ref v2); //참조형으로 변함 

            Console.WriteLine(v2.X);
            Console.WriteLine(v2.Y);

            
        }
    }
}
