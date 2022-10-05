using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics;
using System.Text;
using System.Threading.Tasks;

namespace ACC
{
    internal class Helpers
    {
        public double distance(Vector2 v1, Vector2 v2)
        // sqrt((x_2 - x_1)^2 + (y_2 - y_1)^2)
        {
            double st1 = Math.Pow((v1.X - v2.X), 2);
            double st2 = Math.Pow((v1.Y - v2.Y), 2);
            return Math.Sqrt(st1 + st2);
        }
    }
}
