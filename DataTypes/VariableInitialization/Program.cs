using System;

namespace VariableInitialization
{
    class Program
    {
        enum E { Red, Green, Blue }; //enum은 메서드 밖에 선언해야함 

        static void Main(string[] args)
        {
            int a = default;
            string s = default;
            
            Console.WriteLine("int a: " + a);
            Console.WriteLine("string s: " + s);

            Console.WriteLine("Enum E: " + default(E));
            Console.WriteLine("Enum E: " + (E)0);





        }
    }
}
