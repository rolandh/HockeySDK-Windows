﻿namespace Microsoft.HockeyApp.Extensibility.Implementation.Tracing
{
    /// <summary>
    /// Event Source event wrapper.
    /// Contains description information for trace event.
    /// </summary>
    internal class TraceEvent
    {
        /// <summary>
        /// Gets or sets event metadata.
        /// </summary>
        public EventMetaData MetaData { get; set; }

        /// <summary>
        /// Gets or sets event event parameters.
        /// </summary>
        public object[] Payload { get; set; }
    }
}
