using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassPlayground
{
    public class Rectangle
    {
        public double width, height;
        public Rectangle(double width, double height)
        {
            this.width = width;
            this.height = height;
        }
        public double CalculateArea()
        {
            return width * height;
        }
        public double CalculateAspectRatio()
        {
            return width / height;
            
        }
        public void FindRectType()
        {
            if (width == height)
            {
                Console.Write("čtverec");
            }
            else if (width > height)
            {
                Console.Write("široký");
            }
            else
            {
                Console.Write("vysoký");
            }
            
        }
        /*public bool ContainsPoint()
        {
            int x = 2;
            int y = 2;
            if (x >= 0 && x <= width)
                if (y >= 0 && y <= height)
                    return true;
            else
            return false;
        }
        */
    }
}
