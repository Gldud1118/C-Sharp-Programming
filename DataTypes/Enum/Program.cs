using System;

namespace Enum
{
    class Program
    {
        enum Edirection { North, South, East, West, Max }; //메서드 밖에서 선언해야함 
        enum Animal : byte { mouse, cat, bird, dog = 100, koala, pig = 200, lion }; //int형 이외의 정수형을 기본으로 열거형을 만들려면 콜론을 이용하여 형을 지정 

        enum EOperator
        {
            Plus = '+',
            Minus = '-',
            Multiply = '*',
            Divide = '/',
            Mod = '%'
        }

        static void Main(string[] args)
        {
            int x = 0;
            int y = 0;

            Edirection direction = (Edirection)int.Parse(Console.ReadLine());


            Move(direction, ref x, ref y);

            Console.WriteLine("x : {0}, y: {1}", x, y);

            string[] directions = new string[(int)Edirection.Max];

            Console.WriteLine(directions.Length);

        }

        static void Move(Edirection direction, ref int x, ref int y)
        {
            switch (direction)
            {
                case Edirection.North:
                    x += 1;
                    break;
                case Edirection.South:
                    y += 1;
                    break;
                case Edirection.East:
                    x -= 1;
                    break;
                case Edirection.West:
                    y -= 1;
                    break;
            }
        }
    }
}
