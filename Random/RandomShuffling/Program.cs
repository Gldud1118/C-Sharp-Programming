using System;

namespace RandomShuffling
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
            Console.WriteLine($"{string.Join(",", arr)}");
            Random random = new Random();

            for(int i= arr.Length-1; i > 0;i--)
            {
                int j = random.Next(0, i);
                int temp = arr[j];
                arr[j] = arr[i];
                arr[i] = temp;
            }



            Console.WriteLine($"{string.Join(",", arr)}");
        }
    }
}
