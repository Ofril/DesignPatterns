using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public class Leaf :  Component
    {
        public Leaf(int num) : base(num)
        {
        }

        public override void AddChild(Component c)
        {
            throw new NotSupportedException("Leaf cannot add a child because it can't have any children");
        }

        public override IList<Component> GetChilds()
        {
            return null;
        }

        public override void RemoveChild(Component c)
        {
            throw new NotSupportedException("Leaf cannot remove a child because it can't have any children");
        }

        public override bool IsEven()
        {
            if (this.num % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override int Sum()
        {
            return this.num;
        }

        public override void Draw(string s)
        {
            Console.WriteLine(s + this.num);
        }
    }
}
