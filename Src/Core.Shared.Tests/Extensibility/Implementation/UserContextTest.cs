﻿namespace Microsoft.HockeyApp.Extensibility.Implementation
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.IO;
    using System.Reflection;
    using DataContracts;
#if WINDOWS_PHONE || WINDOWS_STORE
    using Microsoft.VisualStudio.TestPlatform.UnitTestFramework;
#else
    using Microsoft.VisualStudio.TestTools.UnitTesting;
#endif
    using Assert = Xunit.Assert;
    using EndpointUserContext = Microsoft.Developer.Analytics.DataCollection.Model.v2.UserContextData;
    using JsonConvert = Newtonsoft.Json.JsonConvert;

    /// <summary>
    /// Portable tests for <see cref="UserContext"/>.
    /// </summary>
    [TestClass]
    public class UserContextTest
    {
        [TestMethod]
        public void ClassIsPublicToAllowSpecifyingCustomUserContextPropertiesInUserCode()
        {
            Assert.True(typeof(UserContext).GetTypeInfo().IsPublic);
        }
        
        [TestMethod]
        public void IdCanBeChangedByUserToSpecifyACustomValue()
        {
            var context = new UserContext(new Dictionary<string, string>());
            context.Id = "test value";
            Assert.Equal("test value", context.Id);
        }

        [TestMethod]
        public void AcquisitionDateCanBeChangedByUserToSpecifyACustomValue()
        {
            var context = new UserContext(new Dictionary<string, string>());

            DateTimeOffset testValue = DateTimeOffset.Now;
            context.AcquisitionDate = testValue;

            Assert.Equal(testValue, context.AcquisitionDate);
        }

        [TestMethod]
        public void UserAgentIsNullByDefaultToAvoidSendingItToEndpointUnnecessarily()
        {
            var context = new UserContext(new Dictionary<string, string>());
            Assert.Null(context.UserAgent);
        }

        [TestMethod]
        public void UserAgentCanBeChangedByUserToSpecifyACustomValue()
        {
            var context = new UserContext(new Dictionary<string, string>());
            context.UserAgent = "test value";
            Assert.Equal("test value", context.UserAgent);
        }

        [TestMethod]
        public void AccountIdIsNullByDefaultToAvoidSendingItToEndpointUnnecessarily()
        {
            var context = new UserContext(new Dictionary<string, string>());
            Assert.Null(context.AccountId);
        }

        [TestMethod]
        public void AccountIdCanBeChangedByUserToSpecifyACustomValue()
        {
            var context = new UserContext(new Dictionary<string, string>());
            context.AccountId = "test value";            
            Assert.Equal("test value", context.AccountId);
        }
    }
}
