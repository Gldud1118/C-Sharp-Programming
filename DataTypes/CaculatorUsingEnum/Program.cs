using System;

namespace CaculatorUsingEnum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("num1: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("num2: ");
            int num2 = int.Parse(Console.ReadLine());

            Console.Write("operation (+, -, *, /)");
            char operatioChar = char.Parse(Console.ReadLine());

            Eoperator operation = (Eoperator)operatioChar;

            switch(operation)
            {
                case Eoperator.Plus:
                    Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
                    break;

                case Eoperator.Minus:
                    Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
                    break;

                case Eoperator.Multiply:
                    Console.WriteLine($"{num1} * {num2} = {num1 * num2}");
                    break;
                case Eoperator.Divide:
                    Console.WriteLine($"{num1} / {num2} = {num1 / num2}");
                    break;
                default:
                    Console.WriteLine($"잘못된 연산자 {operation}을 입력하셨습니다.");
                    break;
            }
        }
    }
}
