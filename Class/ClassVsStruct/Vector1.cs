using System;
using System.Collections.Generic;
using System.Text;

namespace ClassVsStruct
{
    public class Vector1
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Vector1(int x, int y)
        {
            X = x;
            Y = y;

        }

        public static Vector1 Square(Vector1 v)
        {
            v.X *= v.X;
            v.Y *= v.Y;

            return v;
        }


    }
}
