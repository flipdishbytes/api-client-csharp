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
    ///  Class for testing HeartbeatApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class HeartbeatApiTests
    {
        private HeartbeatApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new HeartbeatApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of HeartbeatApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' HeartbeatApi
            //Assert.IsInstanceOfType(typeof(HeartbeatApi), instance, "instance is a HeartbeatApi");
        }

        
        /// <summary>
        /// Test HeadHostname
        /// </summary>
        [Test]
        public void HeadHostnameTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.HeadHostname();
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
        
        /// <summary>
        /// Test HeadPing
        /// </summary>
        [Test]
        public void HeadPingTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.HeadPing();
            //Assert.IsInstanceOf<RestApiStringResult> (response, "response is RestApiStringResult");
        }
        
        /// <summary>
        /// Test Hostname
        /// </summary>
        [Test]
        public void HostnameTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.Hostname();
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
        
        /// <summary>
        /// Test Ping
        /// </summary>
        [Test]
        public void PingTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.Ping();
            //Assert.IsInstanceOf<RestApiStringResult> (response, "response is RestApiStringResult");
        }
        
    }

}
