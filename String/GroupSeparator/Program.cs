using System;

namespace GroupSeparator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("숫자를 입력하세요.");

            //double num = double.Parse(Console.ReadLine());


            string test = NumberWithGroupSeparator("12345.4444");
            Console.WriteLine($"{test}을 입력하셨습니다.");

        }

        private static string NumberWithGroupSeparator(string str)
        {
            
            int pos = 0;
            double num = Double.Parse(str);

           if(str.Contains('.'))
            {
                pos = str.Length - str.IndexOf('.');

                string formatStr = "{0:N" + (pos - 1) + "}";

                str = String.Format(formatStr, num);
            }
            else
            {
                str = string.Format("{0:N0}", num);
            }



            return str;
        }
    }
}
