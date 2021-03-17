using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();
            //12345678
            string[] commandLine = new string[3];
            while (commandLine[0] != "print")
            {
                commandLine = Console.ReadLine().Split();
                switch (commandLine[0])
                {
                    case "push":
                        nums.Add(Int32.Parse(commandLine[1]));
                        break;

                    case "pop":
                        Console.WriteLine(nums[nums.Count -1]);
                        nums.RemoveAt(nums.Count - 1);
                        break;

                    case "shift":
                        int firstNum = nums[0];
                        nums[0] = nums[nums.Count - 1];
                        nums[nums.Count - 1] = firstNum;
                        break;

                    case "addMany":
                        if(nums.Count > int.Parse(commandLine[1]))
                        {
                            for (int i = 0; i < commandLine.Length - 2; i++)
                            {
                                int indext = int.Parse(commandLine[1]);
                                int index = indext + i;
                                int newNum = int.Parse(commandLine[2 + i]);
                                nums.Insert(index, newNum);
                            }
                        }
                        break;

                    case "remove":
                        if(nums.Count > int.Parse(commandLine[1]))
                        {
                            nums.RemoveAt(int.Parse(commandLine[1]));
                        }
                        break;
                }
            }
            nums.Reverse();
            Console.WriteLine(string.Join(", ", nums));
            
        }
    }
}
