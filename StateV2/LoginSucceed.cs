using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateV2
{
    class LoginSucceed : LoginBase
    {
        public LoginSucceed(Context ctx) : base(ctx)
        {
        }

        public override void Login(string pass)
        {
            Console.WriteLine("You are already logged in");
        }

        public override void Restart()
        {
            Console.WriteLine("You can log in now");
            ctx.State = new NewLogin(ctx);
        }
    }
}
