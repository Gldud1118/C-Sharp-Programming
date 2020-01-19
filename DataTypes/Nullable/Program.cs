using System;

namespace Nullable
{
    class Program
    {
        static void Main(string[] args)
        {
            Nullable<int> i= null;
            //int  int1 = null; int는 null을 허용하지 않는 값 형식이므로 null을 이 형식으로 변환할 수 없습니다 컴파일 오류

            Console.WriteLine(i.GetValueOrDefault());
            if(i.HasValue)
            {
                Console.WriteLine(i.Value);
            }
            else
            {
                Console.WriteLine("Null");
            }

            int? x = null;
            //int j = x그냥 할당할 경우 암시적으로 int?형식을 int형식으로 변환할 수 없습니다.
            int j = x ?? 0;

            Console.WriteLine("x = {0}, y = {1}", x, j);

            Console.WriteLine("x >= 10 ? {0}", x >= 10);
            Console.WriteLine("x < 10 ? {0}", x < 10); // Nullable변수는 숫자나 non-Nullable변수와 직접 비교할 수 없음. 항상 false출력

            //if(Nullable.Compare<int>(i,j) < 0)
            //{
            //    Console.WriteLine("i < j");
            //}else if(Nullable.Compare<int>(i, j) < 0)
            //{
            //    Console.WriteLine("i > j");
            //}
            //else
            //{
            //    Console.WriteLine("i = j");
            //} 


           

        }
    }
}
