using System;

namespace ExtensionMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Hello World!";

            string newStr = str.Reverse(2,8);

            

            Console.WriteLine(newStr);
        }
    }
}
