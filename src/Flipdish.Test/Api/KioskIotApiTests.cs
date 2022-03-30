/* 
 * Flipdish Open API v1.0
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: v1.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using Flipdish.Client;
using Flipdish.Api;
using Flipdish.Model;

namespace Flipdish.Test
{
    /// <summary>
    ///  Class for testing KioskIotApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class KioskIotApiTests
    {
        private KioskIotApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new KioskIotApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of KioskIotApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' KioskIotApi
            //Assert.IsInstanceOfType(typeof(KioskIotApi), instance, "instance is a KioskIotApi");
        }

        
        /// <summary>
        /// Test GetKioskIotConnection
        /// </summary>
        [Test]
        public void GetKioskIotConnectionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetKioskIotConnection();
            //Assert.IsInstanceOf<RestApiResultKioskIotConnectionParameters> (response, "response is RestApiResultKioskIotConnectionParameters");
        }
        
    }

}