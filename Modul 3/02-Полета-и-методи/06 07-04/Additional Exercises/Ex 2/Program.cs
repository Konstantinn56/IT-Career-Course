using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] info = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int count = info[0];
            int overlapCount = info[1];

            List<Rectangle> rectangles = new List<Rectangle>();

            for (int i = 0; i < count; i++)
            {
                string[] rInfo = Console.ReadLine().Split();
                string id = rInfo[0];
                int width = int.Parse(rInfo[1]);
                int height = int.Parse(rInfo[2]);
                int lX = int.Parse(rInfo[3]);
                int lY = int.Parse(rInfo[4]);
                Rectangle rectangle = new Rectangle(id, width, height, lX, lY);
                rectangles.Add(rectangle);
            }

            for (int i = 0; i < overlapCount; i++)
            {
                string[] infoId = Console.ReadLine().Split();
                string r1Id = infoId[0];
                string r2Id = infoId[1];

                Rectangle r1 = new Rectangle("",0,0,0,0);
                Rectangle r2 = new Rectangle("",0,0,0,0);

                foreach (var r in rectangles)
                {
                    if (r.Id.Equals(r1Id))
                    {
                        r1 = r;
                    }
                    if (r.Id.Equals(r2Id))
                    {
                        r2 = r;
                    }
                }

                bool isTrue = Rectangle.DoTheRectanglesOverlap(r1, r2);
                Console.WriteLine(isTrue);
            }
        }
    }
}
