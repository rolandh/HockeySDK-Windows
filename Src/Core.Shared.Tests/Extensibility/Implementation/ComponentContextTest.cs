﻿namespace Microsoft.HockeyApp.Extensibility.Implementation
{
    using System;
    using System.Collections.Generic;
    using System.Reflection;
    using Extensibility.Implementation.External;
#if WINDOWS_PHONE || WINDOWS_STORE
    using Microsoft.VisualStudio.TestPlatform.UnitTestFramework;
#else
    using Microsoft.VisualStudio.TestTools.UnitTesting;
#endif
    using Assert = Xunit.Assert;

    /// <summary>
    /// Portable tests for <see cref="ComponentContext"/>.
    /// </summary>
    [TestClass]
    public class ComponentContextTest
    {
        [TestMethod]
        public void ClassIsPublicToEnableInstantiatingItInSdkAndUserCode()
        {
            Assert.True(typeof(ComponentContext).GetTypeInfo().IsPublic);
        }
        
        [TestMethod]
        public void VersionIsNullByDefaultToAvoidSendingItToEndpointUnnecessarily()
        {
            var tags = new Dictionary<string, string>();
            var component = new ComponentContext(tags);
            Assert.Null(component.Version);
        }

        [TestMethod]
        public void VersionCanBeChangedByUserToSpecifyVersionOfTheirApplication()
        {
            var tags = new Dictionary<string, string>();
            var component = new ComponentContext(tags);
            component.Version = "4.2";
            Assert.Equal("4.2", component.Version);
        }
        
        [TestMethod]
        public void VersionSetsCorrectTagKeyAndValue()
        {
            IDictionary<string, string> tags = new Dictionary<string, string>();
            var component = new ComponentContext(tags);

            string componentVersion = "fakeVersion";
            component.Version = componentVersion;

            Assert.True(tags.Contains(new KeyValuePair<string, string>(ContextTagKeys.Keys.ApplicationVersion, componentVersion)));
        }
    }
}
