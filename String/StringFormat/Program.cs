using System;

namespace StringFormat
{
    class Program
    {
        static void Main(string[] args)
        {

            int x = 1;
            int y = 2;

            //기본 사용법

            Console.WriteLine("{0} 더하기 {1}는 {2}입니다.", x, y, x+y);

            
            //C : Currency(통화, 환율) 타입
            
            Decimal exchangeRate = 1129.20m;

            string s = String.Format("현재 원달러 환율은 {0:C2}입니다.", exchangeRate);

            Console.WriteLine(s);

            
            // 날짜 및 시간 표현
           
            s = String.Format("오늘 날짜는 {0:d}, 시간은 {0:t} 입니다.", DateTime.Now);

            Console.WriteLine(s);

            s = String.Format("{0:yyyy-MM-dd}", DateTime.Now);

            Console.WriteLine(s);


            // N : Number 타입 
            double num = 1234.333;
            s = string.Format("{0:N3}", num);

            Console.WriteLine(s);

          

        }
    }
}
