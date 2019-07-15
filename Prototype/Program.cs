using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {

            Circle c = new Circle(new Point(5, 5), 50.5);
            Rectangle r = new Rectangle(new Point(0, 0), new Point(0, 5), new Point(5, 0), new Point(5, 5));
            ShapeHolder shapeHolder = new ShapeHolder();

            Console.WriteLine(c);
            Console.WriteLine(r);
            
            DoStuffWithCircle((Circle)c.clone());
            DoStuffWithRectangle((Rectangle)r.clone());
            
            Console.WriteLine(c);
            Console.WriteLine(r);

            shapeHolder.addShape(c);
            shapeHolder.addShape(r);

            Console.WriteLine(shapeHolder.clone());
        }

        public static void DoStuffWithCircle(Circle c)
        {
            c.Center.X = 15;
            c.Area = -5;
        }

        public static void DoStuffWithRectangle(Rectangle r)
        {
            r.p1 = new Point(1, 1);
            r.p2 = new Point(2, 2); ;
            r.p3 = new Point(3, 3); ;
            r.p4 = new Point(4, 4); ;
        }
    }
}
