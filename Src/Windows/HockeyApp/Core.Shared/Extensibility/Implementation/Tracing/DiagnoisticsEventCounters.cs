﻿// -----------------------------------------------------------------------
// <copyright file="DiagnoisticsEventCounters.cs" company="Microsoft">
// Copyright © Microsoft. All Rights Reserved.
// </copyright>
// <author>Sergei Nikitin: sergeyni@microsoft.com</author>
// <summary></summary>
// -----------------------------------------------------------------------

namespace Microsoft.ApplicationInsights.Extensibility.Implementation.Tracing
{
    internal class DiagnoisticsEventCounters
    {
        private readonly object syncRoot = new object();
        private volatile int execCount;

        internal DiagnoisticsEventCounters(
            int execCountInitial = 0)
        {
            this.execCount = execCountInitial;
        }

        internal int ExecCount
        {
            get { return this.execCount; }
        }

        internal int Increment()
        {
            this.syncRoot.ExecuteSpinWaitLock(() =>
            {
                if (int.MaxValue > this.execCount)
                {
                    ++this.execCount;
                }
            });

            return this.execCount;
        }
    }
}
