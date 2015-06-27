﻿namespace TerminologyLauncher.Entities.Account
{
    public enum LoginResult
    {
        UnknownError = 0,
        Success = 1,
        IncompleteOfArguments = 2,
        UserNotExists = 3,
        WrongPassword = 4,
        NetworkTimedOut = 5
    }
}
