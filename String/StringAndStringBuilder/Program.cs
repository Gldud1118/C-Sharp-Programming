using System;
using System.Diagnostics;
using System.Text;

namespace StringAndStringBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] strArr = { "Hello", "My name is", "Christina" };

            Stopwatch stopwatch = new Stopwatch();

            string str1 = string.Empty;

            stopwatch.Start();

            for(int i = 0; i < strArr.Length;i++)
            {
                str1 += strArr[i];
            }

            stopwatch.Stop();

            Console.WriteLine(str1);
            Console.WriteLine($"String: {stopwatch.ElapsedTicks}"); // 현재 인스턴스가 측정한 총 경과 시간(타이머 틱 수)을 가져옴

            StringBuilder sb = new StringBuilder();
            stopwatch.Reset();

            for (int i = 0; i < strArr.Length; i++)
            {
                sb.Append(strArr[i]);
            }

            stopwatch.Stop();

            Console.WriteLine(sb);
            Console.WriteLine($"StringBuilder: {stopwatch.ElapsedTicks}");

        }
    }
}
