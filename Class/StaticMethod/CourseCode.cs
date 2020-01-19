using System;
using System.Collections.Generic;
using System.Text;

namespace StaticMethod
{
    class CourseCode
    {
        public CourseCode(ESubject subject, ushort number) //생성자
        {
            Subject = subject;
            Number = number;
        }

        public ESubject Subject { get; private set; } //프로퍼티

        public ushort Number { get; private set; }

        public static CourseCode Parse(string courseCodeString)
        {
            string subjectString = courseCodeString.Substring(0, 4);
            ESubject subject = Enum.Parse<ESubject>(subjectString);

            string numberString = courseCodeString.Substring(4);

            ushort number = ushort.Parse(numberString);
            return new CourseCode(subject, number);
        }

        public static bool TryParse(string courseCodeString, out CourseCode courseCode)
        {
            courseCode = null; 

            if(string.IsNullOrWhiteSpace(courseCodeString) || courseCodeString.Length != 8)
            {
                return false;
            }

            string subjectString = courseCodeString.Substring(0, 4);

            ESubject subject;

            if(!Enum.TryParse(subjectString, out subject))
            {
                return false;
            }

            string numberString = courseCodeString.Substring(4);

            ushort number;

            if(!ushort.TryParse(numberString, out number))
            {
                return false;
            }

            courseCode = new CourseCode(subject, number);

            return true;
        }

    }
}
