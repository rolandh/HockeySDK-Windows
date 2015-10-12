﻿namespace Microsoft.HockeyApp.DataContracts
{
    /// <summary>
    /// This enumeration is used by ExceptionTelemetry to identify if and where exception was handled.
    /// </summary>
    public enum ExceptionHandledAt
    {
        /// <summary>
        /// Exception was not handled. Application crashed.
        /// </summary>
        Unhandled,

        /// <summary>
        /// Exception was handled in user code.
        /// </summary>
        UserCode,

        /// <summary>
        /// Exception was handled by some platform handlers.
        /// </summary>
        Platform
    }
}
