using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateV2
{
    class Program
    {
        static void Main(string[] args)
        {
            Context ctx = new Context();
            NewLogin newLogin = new NewLogin(ctx);
            ctx.Init(newLogin);

            ctx.login("");
            ctx.login("12345");
            ctx.restart();
            ctx.login("");
            ctx.login("");
            ctx.login("12345");
            ctx.restart();
            ctx.restart();
            ctx.login("");
            ctx.restart();
        }
    }
}
