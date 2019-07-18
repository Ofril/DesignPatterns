using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            Component composite = new Composite(12);
            Component rightChild = new Composite(2);
            Component leftChild = new Leaf(4);
            Component rightChildOfRightChild = new Leaf(10);
            Component leftChildOfRightChild = new Leaf(6);
            rightChild.AddChild(rightChildOfRightChild);
            rightChild.AddChild(leftChildOfRightChild);
            composite.AddChild(rightChild);
            composite.AddChild(leftChild);
            composite.Draw("");
            Console.WriteLine(composite.Sum());
            Console.WriteLine("Is the tree even? " + (composite.IsEven() ? "Yes" : "No"));
        }

        static bool IsEven(Component biNonde)
        {
            return biNonde.IsEven();
        }
    }
}
