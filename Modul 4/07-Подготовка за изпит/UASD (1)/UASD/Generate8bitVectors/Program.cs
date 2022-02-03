using System;

namespace Generate8bitVectors
{
    class Program
    {
        static void Main(string[] args)
        {
            Generate(0, new int[8]);
        }

        public static void Generate(int index, int[] vector)
        {
            if(index >= vector.Length)
            {
                Console.WriteLine(string.Join(" ", vector));
            }
            else
            {
                for (int i = 0; i <= 1; i++)
                {
                    vector[index] = i;
                    Generate(index + 1, vector);
                }
            }

        }
    }
}
