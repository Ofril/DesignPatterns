using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateV2
{
    public interface ILoginState
    {
        void Login(string pass);

        void Restart();
    }
}
