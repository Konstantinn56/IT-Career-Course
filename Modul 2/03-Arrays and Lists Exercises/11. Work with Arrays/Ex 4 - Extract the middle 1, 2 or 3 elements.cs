using System;
using System.Linq;

namespace asdsad
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            //•	n = 1 -> 1 елемент
            //•	за четно n -> 2 елемента
            //•	за нечетно n-> 3 елемента
            
            if (nums.Length == 1)
            {
                
            }
            else if (nums.Length % 2 == 0)
            {
                int[] elements = new int[2];
                elements[0] = nums[nums.Length / 2 - 1];
                elements[1] = nums[nums.Length / 2];
                nums = elements;
            }
            else if(nums.Length % 2 != 0)
            {
                int[] elements = new int[3];
                elements[0] = nums[nums.Length/2 -1];
                elements[1] = nums[nums.Length/2];
                elements[2] = nums[nums.Length/2 + 1];
                nums = elements;
            }
            Console.WriteLine($"{{ {string.Join(", ", nums)} }}");
            
        }
    }
}
