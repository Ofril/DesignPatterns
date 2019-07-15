using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    class ShapeHolder : IProtoType<ShapeHolder>
    {
        List<Shape> shapesList = new List<Shape>();

        public void addShape(Shape shape)
        {
            this.shapesList.Add(shape);
        }

        public void removeShape(Shape shape)
        {
            this.shapesList.Remove(shape);
        }

        public ShapeHolder clone()
        {
            ShapeHolder shapesClone = new ShapeHolder();

            foreach (Shape shape in this.shapesList)
            {
                shapesClone.addShape(shape.clone());
            }

            return shapesClone;
        }

        public override string ToString()
        {
            string str = "the list of shapes is: \n";

            foreach (Shape shape in this.shapesList)
            {
                str += shape.ToString() + '\n';
            }

            return str;
        }
    }
}
