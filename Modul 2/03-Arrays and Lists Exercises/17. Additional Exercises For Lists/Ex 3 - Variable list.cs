using System;
using System.Collections.Generic;
using System.Linq;

namespace fyj
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            string[] commandLine = Console.ReadLine().Split();

            while (!commandLine[0].Equals("Odd")
               && !commandLine[0].Equals("Even"))// false && true => false
            {
                switch (commandLine[0])
                {
                    case "Delete":
                        int item = int.Parse(commandLine[1]);
                        while (nums.Contains(item))
                        {
                            nums.Remove(item);
                        }

                        //nums.RemoveAll(x => x == 5);
                        break;
                    case "Insert":
                        int number = int.Parse(commandLine[1]);
                        int position = int.Parse(commandLine[2]);
                        nums.Insert(position, number);
                        break;
                }

                commandLine = Console.ReadLine().Split();
            }

            if (commandLine[0].Equals("Odd"))
            {
                List<int> odds = nums.Where(x => x % 2 != 0).ToList();
                Console.WriteLine(string.Join(" ", odds));
            }
            else
            {
                for (int i = 0; i < nums.Count; i++)
                {
                    if (nums[i] % 2 == 0)
                    {
                        Console.Write($"{nums[i]} ");
                    }
                }
            }
        }
    }
}
