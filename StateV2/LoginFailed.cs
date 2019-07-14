using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateV2
{
    class LoginFailed : LoginBase
    {
        private int failsLeft = 3;
        public LoginFailed(Context ctx) : base(ctx)
        {
        }

        public override void Login(string pass)
        {
            failsLeft--;

            if (pass.Equals(password))
            {
                Console.WriteLine("Loggin in");
                ctx.State = new LoginSucceed(ctx);
            }
            else if (failsLeft == 0)
            {
                Console.WriteLine("You are locked");
                ctx.State = new Locked(ctx);
            }
            else
            {
                Console.WriteLine("Password is incorrect");
            }
        }

        public override void Restart()
        {
            Console.WriteLine("You can log in now");
            ctx.State = new NewLogin(ctx);
        }
    }
}
