﻿// -----------------------------------------------------------------------
// <copyright file="IDiagnoisticsEventThrottlingManager.cs" company="Microsoft">
// Copyright © Microsoft. All Rights Reserved.
// </copyright>
// <author>Sergei Nikitin: sergeyni@microsoft.com</author>
// <summary></summary>
// -----------------------------------------------------------------------

namespace Microsoft.HockeyApp.Extensibility.Implementation.Tracing
{
    internal interface IDiagnoisticsEventThrottlingManager
    {
        bool ThrottleEvent(int eventId, long keywords);
    }
}
