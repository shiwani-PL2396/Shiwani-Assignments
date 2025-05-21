using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1_a__pollymorphism__method_overriding_
{
    public class Rectangle
    {
        private int x, y;

        public Rectangle()
        {
            x = 0;
            y = 0;
        }

        public Rectangle(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public void SetValues(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public int GetArea()
        {
            return x * y;
        }
    }

}
