using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());

            int LitersInCountainer = 0;
            int AllLiters = 0;
            for (int i = 1; i <= rows; i++)
            {
                int NewLitersAdded = int.Parse(Console.ReadLine());

                if (LitersInCountainer + NewLitersAdded <= 255)
                {
                    LitersInCountainer += NewLitersAdded;
                }
                
                AllLiters += NewLitersAdded; 
            }
            if (AllLiters > 255)
            {
                Console.WriteLine("Insufficient capacity!");
                Console.WriteLine(LitersInCountainer);
            }
            else
            {
                Console.WriteLine(LitersInCountainer);
            }

        }
    }
}
