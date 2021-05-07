using System;
using System.Collections.Generic;
using System.Text;

namespace Ex_2
{
    public class Rectangle
    {
        private string id;
        private int width;
        private int height;
        private int leftCornerX;
        private int leftCornerY;
        public Rectangle(string id, int width, int height, int leftCornerX, int leftCornerY)
        {
            Id = id;
            Width = width;
            Height = height;
            LeftCornerX = leftCornerX;
            LeftCornerY = leftCornerY;
        }

        public string Id
        {
            get { return id; }
            set { id = value; }
        }
        public int Width
        {
            get { return width; }
            set { width = value; }
        }
        public int Height
        {
            get { return height; }
            set { height = value; }
        }
        public int LeftCornerX
        {
            get { return leftCornerX; }
            set { leftCornerX = value; }
        }
        public int LeftCornerY
        {
            get { return leftCornerY; }
            set { leftCornerY = value; }
        }

        static public bool DoTheRectanglesOverlap(Rectangle rec1, Rectangle rec2)
        {
            int r1LeftCornerX = rec1.leftCornerX;
            int r1LeftCornerY = rec1.leftCornerY;
            int r1BottomRightCornerX = r1LeftCornerX + rec1.Width;
            int r1BottomRightCornerY = r1LeftCornerY - rec1.Height;

            int r2LeftCornerX = rec2.leftCornerX;
            int r2LeftCornerY = rec2.leftCornerY;
            int r2BottomRightCornerX = r2LeftCornerX + rec2.Width;
            int r2BottomRightCornerY = r2LeftCornerY - rec2.Height;

            if(r1LeftCornerX >= r2BottomRightCornerX || r2LeftCornerX >= r1BottomRightCornerX)
            {
                return false;
            }
            if(r1LeftCornerY <= r2BottomRightCornerY || r2LeftCornerY <= r1BottomRightCornerY)
            {
                return false;
            }
            return true;
        }
    }
}
