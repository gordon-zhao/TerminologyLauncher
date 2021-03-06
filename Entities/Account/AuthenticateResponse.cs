﻿using System;
using System.Collections.Generic;
using TerminologyLauncher.Entities.Account.Authentication;

namespace TerminologyLauncher.Entities.Account
{
    public class AuthenticateResponse : ResponseEntity
    {
        public String AccessToken { get; set; }
        public String ClientToken { get; set; }
        public List<ProfileEntity> AvailableProfiles { get; set; }
        public ProfileEntity SelectedProfile { get; set; }
    }
}
