using System;
using System.Collections.Generic;
using System.Text;

namespace StaticClass
{
    public static class UnitConverter
    {
        public static double GetInchesFromCentimeters(double centimeters)
        {
            return centimeters * 0.393701;
        }

        public static double GetCentimetersFromInches(double inches)
        {
            return inches / 0.393701;
        }

        public static double GetMetersFromCentimeters(double centimeters)
        {
            return centimeters / 100;
        }

        public static double GetFeetFromInches(double inches)
        {
            return inches / 12;
        }


        //public void SomeMethod()
        //{
        //    Console.WriteLine("Won't compile!");
        //} 

        //정적 클래스 안에 정적이 아닌 함수들을 넣을 수 없음

        //정적 클래스는 개체를 전혀 생성할 필요가 없을 때 유용

    }
}
