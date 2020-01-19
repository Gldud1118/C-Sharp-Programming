using System;
using System.Collections.Generic;
using System.Text;

namespace ClassVsStruct
{
    public struct Vector2
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Vector2(int x, int y)
        {
            X = x;
            Y = y;
        }

        public static Vector2 Square(Vector2 v)
        {
            v.X *= v.X;
            v.Y *= v.Y;

            return v;
        }

        public static void Square(ref Vector2 v)
        {
            v.X *= v.X;
            v.Y *= v.Y;
        }
    }
}
