using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C42_G02_OOP05
{
    internal class Point3D
    {
        private double x, y, z;
        public Point3D() : this(0.0, 0.0, 0.0)
        {
            Console.WriteLine("Default constructor called");
        }
        public Point3D(double x, double y, double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            Console.WriteLine("Parameterized constructor called");
        }
        public Point3D(Point3D other) : this(other.x, other.y, other.z)
        {
            Console.WriteLine("Copy constructor called");
        }

        
        public void Print()
        {
            Console.WriteLine($"Point({x}, {y}, {z})");
        }

    }
}
