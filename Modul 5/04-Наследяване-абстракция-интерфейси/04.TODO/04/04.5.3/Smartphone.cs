using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04._5._3
{
    class Smartphone : IBrowsable, ICallable
    {
        public void Browsing(string url)
        {
            if (url.Any(char.IsDigit))
            {
                throw new ArgumentException("Invalid URL!");
            }
            Console.WriteLine($"Browsing: {url}!");
        }

        public void Call(string tNumber)
        {
            if (!tNumber.All(char.IsDigit))
            {
                throw new ArgumentException("Invalid number!");
            }
            Console.WriteLine($"Calling... {tNumber}");
            
        }
    }
}
