namespace C42_G02_OOP05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1
            //Define 3D Point Class and the basic Constructors (use chaining in constructors).
            Point3D p1 = new Point3D();               
            p1.Print();

            Point3D p2 = new Point3D(1.0, 2.0, 3.0);  
            p2.Print();

            Point3D p3 = new Point3D(p2);             
            p3.Print();
            #endregion
            Console.WriteLine("=========================");
            #region 2
            Point3D1 d1 = new Point3D1();              
            Console.WriteLine(d1.ToString());

            Point3D1 d2 = new Point3D1(1.0, 2.0, 3.0); 
            Console.WriteLine(d2.ToString());

            Point3D1 d3 = new Point3D1(d2);             
            Console.WriteLine(d3.ToString());

            Point3D1 d4 = new Point3D1(10, 10, 10);     
            Console.WriteLine(d4.ToString());
            #endregion
            Console.WriteLine("=========================");
            #region 3
            //Read from the User the Coordinates for 2 points P1, P2 (Check the input using try Pares, Parse, Convert).
            Console.WriteLine("Enter coordinates for Point m1:");
            Point3D1 m1 = Point3D1.ReadPoint();
            Console.WriteLine("Point m1: " + m1.ToString());

            Console.WriteLine("Enter coordinates for Point m2:");
            Point3D1 m2 = Point3D1.ReadPoint();
            Console.WriteLine("Point m2: " + m2.ToString());
            #endregion
            Console.WriteLine("=========================");
            #region 4
            Console.WriteLine("Enter coordinates for Point P1:");
            Point3D1 P1 = Point3D1.ReadPoint();
            Console.WriteLine("Point P1: " + P1.ToString());

            Console.WriteLine("Enter coordinates for Point P2:");
            Point3D1 P2 = Point3D1.ReadPoint();
            Console.WriteLine("Point P2: " + P2.ToString());

            if (P1 == P2)
            {
                Console.WriteLine("P1 and P2 are equal.");
            }
            else
            {
                Console.WriteLine("P1 and P2 are not equal.");
            }
            #endregion
            Console.WriteLine("=========================");
            #region PART2 
            Maths maths = new Maths();
            double a = 20;
            double b = 10;
            double sum = maths.Add(a, b);
            double difference = maths.Subtract(a, b);
            double product = maths.Multiply(a, b);
            double quotient = maths.Divide(a, b);
            Console.WriteLine($"Add: {a} + {b} = {sum}");
            Console.WriteLine($"Subtract: {a} - {b} = {difference}");
            Console.WriteLine($"Multiply: {a} * {b} = {product}");
            Console.WriteLine($"Divide: {a} / {b} = {quotient}");
            #endregion
            Console.WriteLine("=========================");
            #region After Modifying
            Console.WriteLine("AFTER MODIFYING");
            double a1 = 20;
            double b1 = 10;
            double sum1 = maths.Add(a, b);
            double difference1 = maths.Subtract(a, b);
            double product1 = maths.Multiply(a, b);
            double quotient1 = maths.Divide(a, b);
            Console.WriteLine($"Add: {a} + {b} = {sum}");
            Console.WriteLine($"Subtract: {a} - {b} = {difference}");
            Console.WriteLine($"Multiply: {a} * {b} = {product}");
            Console.WriteLine($"Divide: {a} / {b} = {quotient}");
            #endregion
            Console.WriteLine("=========================");
            #region PART3 1
            Duration duration = new Duration(4,15,35);
            Console.WriteLine($"Duration:{duration.Hours} hours,{duration.Minutes} minutes,{duration.Seconds} seconds");
            #endregion
            Console.WriteLine("=========================");
            #region 2
            Duration duration1 = new Duration(2, 30, 10);
            Duration duration2 = new Duration(2, 30, 10);
            Duration duration3 = new Duration(4, 15, 35);

            Console.WriteLine(duration1.ToString()); 
            Console.WriteLine(duration1.Equals(duration2)); 
            Console.WriteLine(duration1.Equals(duration3));

            Console.WriteLine(duration1.GetHashCode()); 
            Console.WriteLine(duration2.GetHashCode());
            #endregion
        }
    }
}
