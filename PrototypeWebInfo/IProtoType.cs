using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeWebInfo
{
    public interface IProtoType<T>
    {
        T clone();
    }
}
