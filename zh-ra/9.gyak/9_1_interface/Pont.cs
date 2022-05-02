using System;
using System.Collections.Generic;
using System.Text;

namespace Pontok
{
    class Pont
    {
        int x;
        int y;

        public Pont(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public override string ToString()
        {
            return $"x: {x}, y: {y}";
        }
    }
}
