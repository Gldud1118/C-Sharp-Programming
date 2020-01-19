using System;

namespace ArrayClass
{
    class Program
    {
        static void Main(string[] args)
        {
            //배열 선언
            int[] num = new int[3];

            //배열을 선언하고 초기화하는 세 가지 방법
            int[] num1 = { 1, 2, 3 };
            int[] num2 = new int[]{ 1, 2, 3 };
            int[] num3 = new int[3] {1,2,3};

            foreach(var value in num1)
            {
                //Console.WriteLine(value);
            }

            for(int i=0; i<num2.Length;i++)
            {
                //Console.WriteLine(num2[i]);
            }


            int[] a = { 5, 32, 76, 98, 45 };
            PrintArray(a);


            int[] b;
            b = (int[])a.Clone(); //Clone()메서드는 Object를 리턴하므로 (int[])로 캐스팅
            PrintArray(b);

            int[] c = new int[10];
            Array.Copy(a, 0, c, 1, 3);
            PrintArray(c);

            a.CopyTo(c, 3);
            PrintArray(c);

            Array.Sort(a); //오름차순으로 정렬
            PrintArray(a);


            Array.Reverse(a);//배열을 뒤집음 
            PrintArray(a);

            Array.Clear(a, 0, a.Length);
            PrintArray(a);

        }

        public static void PrintArray(int[] arr)
        {
            foreach(var value in arr)
            {
                Console.Write("{0,5}", value);
                Console.WriteLine();
            }
        }
    }
}
