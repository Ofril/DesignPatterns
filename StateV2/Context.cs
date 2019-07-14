﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateV2
{
    public class Context
    {
        public ILoginState State { get; set; }

        public Context()
        {
        }

        public void Init(ILoginState state)
        {
            this.State = state;
        }

        public void login(string pass)
        {
            if (State == null)
                throw new ApplicationException("state not initailized!");

            State.Login(pass);
        }

        public void restart()
        {
            if (State == null)
                throw new ApplicationException("state not initailized!");

            State.Restart();
        }
    }
}
