using System;

namespace Exception
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int[] numbers = new int[100];
                numbers[-1] = 1000;
            }
            catch
            {
                Console.WriteLine("IndexOutOfRangeException");
            }
        }
    }
}
