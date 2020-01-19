using System;

namespace TwoDimensionalArray
{
    class Program
    {
        static void Main(string[] args)
        {
            const int X = 4;
            const int Y = 2;
            int[,] arrA= new int[Y, X]; //y방향의 요소 수, x방향의 요소 수 

            int[,] arrB = new int[2, 2]
            {
                {1,2 },
                {3,4 }

            };

            int[,] arrC =
            {
                {2,3,4 },
                {5,6,7 },
                {8,9,0 }
            };


            for(int i=0;i<3;i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("{0,5}", arrC[i, j]);
                    Console.WriteLine();
                }

            }
        }
    }
}
