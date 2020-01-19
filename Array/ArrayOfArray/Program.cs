using System;

namespace ArrayOfArray
{
    class Program
    {
        static void Main(string[] args)
        {
            const int CLASS_COUNT = 3;
            string[][] classrooms = new string[CLASS_COUNT][];

            int[] STUDENT_COUNT_PER_COUNT = { 3, 4, 5 };

            for(int i=0;i<CLASS_COUNT;i++)
            {
                classrooms[i] = new string[STUDENT_COUNT_PER_COUNT[i]];
            }

            string[] classroom2 = classrooms[1];
            Console.WriteLine("기존 반 수: " + classrooms[1].Length);
            string[] newClassroom2 = new string[classroom2.Length + 1];

            Array.Copy(classroom2, newClassroom2, 4);
            newClassroom2[newClassroom2.Length - 1] = "Nicole";

            classrooms[1] = newClassroom2;
            Console.WriteLine("변경 후 반 수: " + classrooms[1].Length);

        }
    }
}
