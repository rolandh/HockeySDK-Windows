﻿namespace Microsoft.HockeyApp.Extensibility.Implementation
{
    using System;
    using System.Threading.Tasks;

    internal interface IPlatformDispatcher
    {
        Task RunAsync(Action action);
    }
}
