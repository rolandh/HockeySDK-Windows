﻿namespace Microsoft.HockeyApp.Extensibility.Implementation.Tracing
{
    internal interface IDiagnosticsSender
    {
        /// <summary>
        /// Sends diagnostics data to the appropriate output.
        /// </summary>
        /// <param name="eventData">Information about trace event.</param>
        void Send(TraceEvent eventData);
    }
}