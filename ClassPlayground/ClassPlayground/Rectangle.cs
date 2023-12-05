using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassPlayground
{
    public class Rectangle
    {
        public int width, height;
        public Rectangle(int width, int height)
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
            if (width == height)
            {
                Console.WriteLine("čtverec");
            }
            else if (width > height)
            {
                Console.WriteLine("široký");
            }
            else
            {
                Console.WriteLine("vysoký");
            }
            return width / height;
            
        }
        public bool ContainsPoint()
        {
            int x = 2;
            int y = 2;
            if (x >= 0 && x <= width)
                if (y >= 0 && y <= height)
                    return true;
            else
            return false;
        }
        
    }
}
