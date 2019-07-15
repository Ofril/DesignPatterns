using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public class Rectangle : Shape
    {
        public Point p1 { get; set; }
        public Point p2 { get; set; }
        public Point p3 { get; set; }
        public Point p4 { get; set; }

        public Rectangle(Point p1, Point p2, Point p3, Point p4)
        {
            this.p1 = p1;
            this.p2 = p2;
            this.p3 = p3;
            this.p4 = p4;
        }

        public override string ToString()
        {
            return $"Rectangle p1 {p1} p2 {p2} p3 {p3} p4 {p4} ";
        }

        public override Shape clone()
        {
            return new Rectangle((Point)p1.clone(), (Point)p2.clone(), (Point)p3.clone(), (Point)p4.clone());
        }
    }
}
