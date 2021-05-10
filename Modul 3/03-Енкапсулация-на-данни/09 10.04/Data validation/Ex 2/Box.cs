﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Ex_2
{
    public class Box
    {
        private double length;
        private double width;
        private double height;

        public Box(double length, double width, double height)
        {
            this.Length = length;
            this.Width = width;
            this.Height = height;
        }

        public double Length
        {
            get { return length; }
            private set 
            { 
                if(value <= 0)
                {
                    throw new ArgumentException("Length cannot be zero or negative.");
                }
                length = value; 
            }
        }
        public double Width
        {
            get { return width; }
            private set 
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Width cannot be zero or negative.");
                }
                width = value; 
            }
        }
        public double Height
        {
            get { return height; }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Height cannot be zero or negative.");
                }
                height = value; 
            }
        }
        public double GetLateralSurfaceArea()
        {
            double l = this.length;
            double h = this.height;
            double w = this.width;
            double result = 2 * l * h + 2 * w * h;
            return result;
        }
        public double GetSurfaceArea()
        {
            double l = this.length;
            double h = this.height;
            double w = this.width;
            double result = 2 * l * w + 2 * l * h + 2 * w * h;
            return result;
        }
        public double GetVolume()
        {
            double l = this.length;
            double h = this.height;
            double w = this.width;
            double result = l * w * h;
            return result;
        }
    }
}
