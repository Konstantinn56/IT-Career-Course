using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrokerCompanySystem.Buildings
{
    class Hotel : Building
    {
        private const string ENDS_WITH = "Hotel";
        public Hotel(string name, string city, int stars, double rentAmount) 
            : base(name, city, stars, rentAmount)
        {
            
        }

        public override string Name 
        { 
            get => base.Name;
            protected set 
            { 
                base.Name = value;
                if (!name.EndsWith(ENDS_WITH))
                {
                    throw new ArgumentException("Name of hotel buildings should end on Hotel!");
                }
            } 
        }
    }
}
