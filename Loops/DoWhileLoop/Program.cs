using System;

namespace DoWhileLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("User count: ");

            int length = int.Parse(Console.ReadLine());
            int[] ages = new int[length];

            float[] heights = new float[length];

            int totalAges = 0;
            float totalHeights = 0.0f;
            int count = 0;
            do
            {
                Console.Write($"Enter user{count}'s age: ");
                ages[count] = int.Parse(Console.ReadLine());
                totalAges += ages[count];

                Console.Write($"Enter user{count}'s height(cm: ");
                heights[count] = float.Parse(Console.ReadLine());
                totalHeights += heights[count];

                ++count;
            } while (count < length);

                Console.WriteLine("Print result------------");

            for (int i = 0; i < length; ++i)
            {
                Console.WriteLine($"User{i}: Age({ages[i]}), Height({heights[i]})");
            }

            Console.WriteLine($"Total ages: {totalAges}");
            Console.WriteLine($"Total heights: {totalHeights}");
        }
    }
}
