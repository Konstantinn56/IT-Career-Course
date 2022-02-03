using System;

namespace _04._5._3
{
    class Program
    {
        static void Main(string[] args)
        {

            Smartphone smartphone = new Smartphone();
            string[] phoneNumbers = Console.ReadLine().Split();
            string[] urls = Console.ReadLine().Split();

            try
            {
                foreach (var pN in phoneNumbers)
                {
                    smartphone.Call(pN);
                }
            }
            catch (ArgumentException ex)
            {
                throw ex;
            }
            try
            {
                foreach (var url in urls)
                {
                    smartphone.Browsing(url);
                }
            }
            catch (ArgumentException ex)
            {
                throw ex;
            }

        }
    }
}
