using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04._8._1.IC
{
    class Robot : IIdentifiable
    {
        private string model;
        private string id;

        public Robot(string m , string id)
        {
            this.Model = m;
            this.Id = id;
        }

        public string Model
        {
            get { return model; }
            set { model = value; }
        }
        public string Id 
        {
            get { return this.id; }
            set { this.id = value; }
        }
    }
}
