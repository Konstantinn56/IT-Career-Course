using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09
{
    public class Business : Building
    {
        public Business(string name, string city, int stars, double rentAmount, bool isAvailable) : base(name, city, stars, rentAmount, isAvailable)
        {

        }
        

    }
}
