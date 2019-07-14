using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateV2
{
    class NewLogin : LoginBase
    {
        public NewLogin(Context ctx) : base(ctx)
        {
        }

        public override void Login(string pass)
        {
            if (pass.Equals(PASSWORD))
            {
                Console.WriteLine("Logging in");
                ctx.State = new LoginSucceed(ctx);
            }
            else
            {
                Console.WriteLine("Password is incorrect");
                ctx.State = new LoginFailed(ctx);
            }
        }

        public override void Restart()
        {
            Console.WriteLine("No restart is needed, you can log in");
        }
    }
}
