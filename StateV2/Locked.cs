using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateV2
{
    class Locked : LoginBase
    {
        public Locked(Context ctx) : base(ctx)
        {
        }

        public override void Login(string pass)
        {
            Console.WriteLine("You are locked, please restart");
        }

        public override void Restart()
        {
            Console.WriteLine("Restarting now...");
            ctx.State = new NewLogin(ctx);
        }
    }
}
