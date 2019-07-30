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
    ///  Class for testing HydraApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class HydraApiTests
    {
        private HydraApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new HydraApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of HydraApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' HydraApi
            //Assert.IsInstanceOfType(typeof(HydraApi), instance, "instance is a HydraApi");
        }

        
        /// <summary>
        /// Test GetAttachedDevices
        /// </summary>
        [Test]
        public void GetAttachedDevicesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string appId = null;
            //string deviceType = null;
            //int? pageIndex = null;
            //int? pageSize = null;
            //int? storeId = null;
            //string deviceName = null;
            //string deviceSerial = null;
            //var response = instance.GetAttachedDevices(appId, deviceType, pageIndex, pageSize, storeId, deviceName, deviceSerial);
            //Assert.IsInstanceOf<RestApiPaginationResultHydraDeviceDetails> (response, "response is RestApiPaginationResultHydraDeviceDetails");
        }
        
        /// <summary>
        /// Test GetRegistration
        /// </summary>
        [Test]
        public void GetRegistrationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetRegistration();
            //Assert.IsInstanceOf<RestApiResultHydraStatus> (response, "response is RestApiResultHydraStatus");
        }
        
        /// <summary>
        /// Test GetSettings
        /// </summary>
        [Test]
        public void GetSettingsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetSettings();
            //Assert.IsInstanceOf<RestApiResultHydraConfig> (response, "response is RestApiResultHydraConfig");
        }
        
        /// <summary>
        /// Test GetTerminalDetails
        /// </summary>
        [Test]
        public void GetTerminalDetailsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string appId = null;
            //var response = instance.GetTerminalDetails(appId);
            //Assert.IsInstanceOf<RestApiResultPaymentTerminalDetails> (response, "response is RestApiResultPaymentTerminalDetails");
        }
        
        /// <summary>
        /// Test LoginWithDeviceId
        /// </summary>
        [Test]
        public void LoginWithDeviceIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string deviceId = null;
            //string hydraUserType = null;
            //instance.LoginWithDeviceId(deviceId, hydraUserType);
            
        }
        
        /// <summary>
        /// Test Register
        /// </summary>
        [Test]
        public void RegisterTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string appId = null;
            //HydraRegistrationRequest hydraRegistration = null;
            //var response = instance.Register(appId, hydraRegistration);
            //Assert.IsInstanceOf<RestApiResultHydraStatus> (response, "response is RestApiResultHydraStatus");
        }
        
        /// <summary>
        /// Test UnAssign
        /// </summary>
        [Test]
        public void UnAssignTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string appId = null;
            //string deviceId = null;
            //instance.UnAssign(appId, deviceId);
            
        }
        
    }

}
