using System;

namespace _02._1
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList<string> list = new ArrayList<string>();
            list.Add("Pesho");
            list.Add("Gosho");
            list.Add("Tosho");
            list[1] = "Penka";
            Console.WriteLine(list.RemoveAt(1));
            //.WriteLine(list.Remove("Tosho"));

            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(list[1]);
        }
    }
}
