using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C42_G02_OOP05
{
    internal class Point3D1
    {
        private double x, y, z;
        public Point3D1() : this(0.0, 0.0, 0.0)
        {
            Console.WriteLine("Default constructor called");
        }
        public Point3D1(double x, double y, double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            Console.WriteLine("Parameterized constructor called");
        }
        public Point3D1(Point3D1 other) : this(other.x, other.y, other.z)
        {
            Console.WriteLine("Copy constructor called");
        }
        public override string ToString()
        {
            return $"Point Coordinates: ({x}, {y}, {z})";
        }

        public void Print()
        {
            Console.WriteLine(this.ToString());
        }
        public static Point3D1 ReadPoint()
        {
            double x, y, z;
            while (true)
            {
                try
                {
                    Console.Write("Enter x coordinate: ");
                    x = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Enter y coordinate: ");
                    y = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Enter z coordinate: ");
                    z = Convert.ToDouble(Console.ReadLine());

                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Please enter numeric values.");
                }
            }
            return new Point3D1(x, y, z);
        }
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            Point3D1 other = (Point3D1)obj;
            return x == other.x && y == other.y && z == other.z;
        }
        public override int GetHashCode()
        {
            return Tuple.Create(x, y, z).GetHashCode();
        }
        public static bool operator ==(Point3D1 P1, Point3D1 P2)
        {
            if (ReferenceEquals(P1, P2))
            {
                return true;
            }
            if (((object)P1 == null) || ((object)P2 == null))
            {
                return false;
            }
            return P1.Equals(P2);
        }

        public static bool operator !=(Point3D1 P1, Point3D1 P2)
        {
            return !(P1 == P2);
        }

    }
}
