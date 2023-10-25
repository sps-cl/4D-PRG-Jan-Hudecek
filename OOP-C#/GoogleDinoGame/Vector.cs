using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoogleDinoGame
{
    class Vector
    {
        public float X { get; set; }
        public float Y { get; set; }

        public Vector(float x, float y)
        {
            X = x;
            Y = y;
        }

        public void Add(Vector other)
        {
            X += other.X;
            Y += other.Y;
        }

        public float SquareSize
        {
            get
            {
                return X * X + Y * Y;
            }
        }

        public static Vector operator -(Vector a, Vector b)
        {
            return new Vector(a.X - b.X, a.Y - b.Y);
        }
    }
}
