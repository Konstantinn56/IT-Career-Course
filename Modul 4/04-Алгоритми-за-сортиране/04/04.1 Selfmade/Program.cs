using System;
using System.Linq;

namespace _04._1_Selfmade
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] firstTeam = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] secondTeam = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int count = firstTeam.Length + secondTeam.Length;
            int[] allTeam = new int[count];
            int firstIndex = 0;
            int secondIndex = 0;
            for (int i = 0; i < firstTeam.Length; i++)
            {
                allTeam[i] = firstTeam[i];
            }
            
            for (int i = firstTeam.Length, b = 0 ; i < allTeam.Length; i++ , b++)
            {
                allTeam[i] = secondTeam[b];
            }
            SelectionSort(allTeam);
            
            //int[] height = Console.ReadLine().Split().Select(int.Parse).ToArray();
            //int[] students = Console.ReadLine().Split().Select(int.Parse).ToArray();
            //SelectionSortByDescending(height);
            //Console.WriteLine(height[students[0] - 1]);
            //Console.WriteLine(height[students[1] - 1]);
        }
        static void SelectionSort(int[] array)
        {
            //0 1 2 3 4 5 6
            //6 5 4 3 2 1 0
            for (int i = 0; i < array.Length; i++)
            {
                int minIndex = i;
                for (int a = i + 1; a < array.Length; a++)
                {
                    if(array[minIndex] > array[a])
                    {
                        //Console.WriteLine($"Num {array[minIndex]} was swapped with {array[a]}");
                        int temp = array[minIndex];
                        array[minIndex] = array[a];
                        array[a] = temp;
                        //Console.WriteLine(string.Join(" ", array));
                        //Console.WriteLine();
                    }
                }
            }
            Console.WriteLine($"Final result: {string.Join(" ", array)}");
        }
        static void SelectionSortByDescending(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                int maxIndex = i;
                for (int a = i + 1; a < array.Length; a++)
                {
                    if(array[maxIndex] < array[a])
                    {
                        int temp = array[maxIndex];
                        array[maxIndex] = array[a];
                        array[a] = temp;
                    }
                }
            }
            //Console.WriteLine($"Final result: {string.Join(" ", array)}");
        }
    }
}
