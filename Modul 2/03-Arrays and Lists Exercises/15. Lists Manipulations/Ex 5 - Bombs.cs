using System;
using System.Collections.Generic;
using System.Linq;

namespace dghmn
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> Nums = Console.ReadLine().Split().Select(int.Parse).ToList();

            List<int> SpecialNums = Console.ReadLine().Split().Select(int.Parse).ToList();

            ////////////////////////////////////////////////////////////////////////

            int Bomb = SpecialNums[0];
            int Power = SpecialNums[1];
            int BombIndex = Nums.IndexOf(Bomb);//
            int StartIndex = BombIndex - Power;
            int EndIndex = BombIndex + Power;
            int Range = EndIndex - StartIndex + 1;

            while (Nums.Contains(Bomb))
            {
                if(EndIndex >= Nums.Count && StartIndex < 0)
                {
                    StartIndex = 0;
                    Range = Nums.Count;
                }
                else if(EndIndex >= Nums.Count)
                {
                    Range = Nums.Count - StartIndex;
                }
                else if(StartIndex < 0)
                {
                    StartIndex = 0;
                }
                Nums.RemoveRange(StartIndex, Range);
            }

            //////////////////////////////////////////////////////////////////
            int sum = 0;
            foreach (var num in Nums)
            {
                sum += num;
            }
            Console.WriteLine(sum);

            
            
        }
    }
}
