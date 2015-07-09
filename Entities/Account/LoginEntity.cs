﻿using System;

namespace TerminologyLauncher.Entities.Account
{
    public class LoginEntity
    {
        public String UserName { get; set; }
        public String Password { get; set; }
        public LoginModeEnum LoginMode { get; set; }
    }
}