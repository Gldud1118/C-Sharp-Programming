using System;

namespace ConstVsReadonly
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(ConstEx.number);

            ReadonllyEx readonllyEx = new ReadonllyEx();

            Console.WriteLine(readonllyEx.number);

            ReadonllyEx readonllyEx2 = new ReadonllyEx(15);

            Console.WriteLine(readonllyEx2.number);

        }
    }

    class ConstEx
    {
        public const int number = 13;
    }

    class ReadonllyEx
    {
        public readonly int number = 10;

        public ReadonllyEx()
        {
            number = 20;
        }

        public ReadonllyEx(int n)
        {
            number = n;
        }
    }
}
