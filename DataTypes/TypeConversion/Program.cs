using System;

namespace TypeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            /*오버플로*/
            int int1 = int.MaxValue;
            int overflowInt = int1 + 1;

            Console.WriteLine("int1: " + int1);
            Console.WriteLine("overflowInt: " + overflowInt);

            /*언더플로*/
            int int2 = -2147483648;
            int underflowInt = int2 - 1;

            Console.WriteLine("underflowInt: " + underflowInt);


            /*정수형을 실수형에 대입*/
            int int3 = 8;
            float int3ToFloat = int3;

            Console.WriteLine("int3ToFloat: " + int3ToFloat);

            /*decimal형을 부동소수점형에 대입*/
            decimal decimal1 = 29;
            //float decimal1ToFloat = decimal1;
            float decimal1ToFloat = (float)decimal1;
            double decimal1ToDouble1 = (double)decimal1;
            double decimal1ToDouble2 = Convert.ToDouble(decimal1);
            
            Console.WriteLine("decimal1ToFloat: " + decimal1ToFloat);
            Console.WriteLine("decimal1ToDouble1: " + decimal1ToDouble1);
            Console.WriteLine("decimal1ToDouble2: " + decimal1ToDouble2);


            /*범위가 더 큰 형에 대입*/
            byte byte1 = 10;
            int byte1ToInt = byte1;
           
            Console.WriteLine("byte1ToInt: " + byte1ToInt);

            
            /*범위가 감당할 수 없는 형에 대입*/
            byte byte2 = 74;
            //sbyte byte2ToSbyte = byte2; 암시적으로 byte형식를 sbyte형식로 변환할 수 없다는 컴파일 오류
            sbyte byte2ToSbyte1 = Convert.ToSByte(byte2);
            sbyte byte2ToSbyte2 = (sbyte)byte2;
            
            Console.WriteLine("byte2ToSbyte1: " + byte2ToSbyte1);
            Console.WriteLine("byte2ToSbyte1: " + byte2ToSbyte2);

            
            /*범위가 더 작은 형에 대입*/
            long long1 = long.MaxValue;
            int long1ToInt = (int)long1;
            
            Console.WriteLine("long1ToInt: " + long1ToInt);


            /*정수형을 문자형에 대입 */
            ulong ulong1 = 100;
            //char char2 = ulong1; 암시적으로 ulong형식을 char형식으로 변환할 수 없다는 컴파일 오류
            char ulongToChar = Convert.ToChar(ulong1);

            Console.WriteLine("ulongToChar: " + ulongToChar);


            /*문자형을 정수형에 대입*/
            char char1 = 'a';
            int char1ToInt = char1;
            
            Console.WriteLine("char1ToInt: " + char1ToInt);

            
            /*문자형을 부동소수점형에 대입*/
            long char1ToLong = char1;

            Console.WriteLine("char1ToLong: " + char1ToLong);

        }
    }
}
