using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateV2
{
    public abstract class LoginBase : ILoginState
    {
        protected const string PASSWORD = "12345";
        protected Context ctx;

        protected LoginBase(Context ctx)
        {
            this.ctx = ctx;
        }

        public abstract void Login(string pass);

        public abstract void Restart();
    }
}
