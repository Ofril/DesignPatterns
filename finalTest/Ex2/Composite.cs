using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public class Composite : Component
    {

        IList<Component> childs = new List<Component>();

        public Composite(int num) : base(num)
        {
        }

        public override void AddChild(Component c)
        {
            childs.Add(c);
        }

        public override IList<Component> GetChilds()
        {
            return childs;
        }

        public override void RemoveChild(Component c)
        {
            childs.Remove(c);
        }

        public override bool IsEven()
        {
            if (this.num % 2 == 1)
            {
                return false;
            }
            else if (this.GetChilds().Count == 0)
            {
                return true;
            }
            else
            {
                bool currEven = true;

                foreach (Component currComponent in this.GetChilds())
                {
                    currEven = currEven && currComponent.IsEven();
                }

                return currEven;
            }
        }
        public override int Sum()
        {
            int sum = this.num;

            foreach (Component currComponent in childs)
            {
                sum += currComponent.Sum();
            }

            return sum;
        }

        public override void Draw(string s)
        {
            Console.WriteLine(s + this.num);

            foreach (Component c in childs)
            {
                c.Draw(s + "    ");
            }
        }
    }
}
