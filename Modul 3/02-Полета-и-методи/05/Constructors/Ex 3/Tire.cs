using System;
using System.Collections.Generic;
using System.Text;

namespace Ex_3
{
    public class Tire
    {
        private double presure;
        private int age;

        public Tire(double presure, int age)
        {
            this.Presure = presure;
            this.Age = age;
        }

        public double Presure
        {
            get { return presure; }
            set { presure = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
    }
}
