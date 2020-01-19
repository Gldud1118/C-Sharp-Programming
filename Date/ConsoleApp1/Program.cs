using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //한달에 몇주가 있는 구하기

            DateTime today = DateTime.Now;

            int year = today.Year;
            int month = today.Month;

            int daysInMonth = DateTime.DaysInMonth(year, month);
            DateTime firstOfMonth = new DateTime(year, month, 1);
            int firstDayOfWeek = (int)firstOfMonth.DayOfWeek; //friday 

            int weeksInMonth = (int)Math.Ceiling((daysInMonth + firstDayOfWeek) / 7.0);
            Console.Write(weeksInMonth);


            //저번주 월요일이 무슨 요일인지 구하기 

            /*
             1. 오늘이 무슨 일인지 구하기
             2. 오늘의 DayOfWeek를 구한다. 오늘이 목요일일 경우 DayOfWeek는 4
             3. 일주일 전 그리고 월요일과 목요일이 떨어져 있는 사이를 거슬러서 언젠지 구함 
             
             */

            //예를 들어 2019년 11월
            /*
             10.28 ~11.03
             11.04 ~11.10
             11.11~11.17
             11.18 ~ 11.24
             11.25 ~ 12. 01
             
             */
            //주간 구하기

            var dates = Enumerable.Range(1, DateTime.DaysInMonth(year, 7)).Select(n => new DateTime(year, 7, n));
            //var weekends = (from d in dates
            //                where d.DayOfWeek == DayOfWeek.Monday
            //                select new { start = d.ToString("yyyy-MM-dd"), end = d.AddDays(6).ToString("yyyy-MM-dd") }).ToList();

            //foreach (var week in weekends)
            //{
            //    Console.WriteLine(week);
            //}


            var weekends = new List<Weekend>();
            foreach (var d in dates)
            {
                var week = new Weekend();
                if (d.Day == 1)
                {
                    int dayOfWeek = (int)d.DayOfWeek;
                    if (dayOfWeek <= 4)
                    {
                        week.Start = new DateTime(d.Year, d.Month, d.Day).AddDays(-(dayOfWeek-1));
                        week.End = week.Start.AddDays(6);
                        weekends.Add(week);
                    }
                }
                if (d.DayOfWeek == DayOfWeek.Monday)
                {
                    week.Start = d;
                    week.End = d.AddDays(6);
                    weekends.Add(week);
                }
            }

            foreach (var week in weekends)
            {
                Console.WriteLine(week.Start.ToString("yyyy-MM-dd") + week.End.ToString("yyyy-MM-dd"));
            }
            //전달과 주가 겹칠 때는? 

            //주간 구하기2
        }
    }

    public class Weekend
    {
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
    }
}
