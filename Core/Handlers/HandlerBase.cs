﻿using System;

namespace TerminologyLauncher.Core.Handlers
{
    public abstract class HandlerBase
    {
        protected Engine Engine { get; set; }
        public HandlerBase(Engine engine)
        {
            this.Engine = engine;
        }
        public abstract void HandleEvent(object sender, EventArgs e);
    }
}
