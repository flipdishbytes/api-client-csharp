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
    ///  Class for testing LightspeedApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class LightspeedApiTests
    {
        private LightspeedApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new LightspeedApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of LightspeedApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' LightspeedApi
            //Assert.IsInstanceOfType(typeof(LightspeedApi), instance, "instance is a LightspeedApi");
        }

        
        /// <summary>
        /// Test LightspeedGenerateMenu
        /// </summary>
        [Test]
        public void LightspeedGenerateMenuTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? storeId = null;
            //var response = instance.LightspeedGenerateMenu(storeId);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
        
        /// <summary>
        /// Test LightspeedGetStoreSettings
        /// </summary>
        [Test]
        public void LightspeedGetStoreSettingsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? storeId = null;
            //var response = instance.LightspeedGetStoreSettings(storeId);
            //Assert.IsInstanceOf<RestApiResultLightspeedSettings> (response, "response is RestApiResultLightspeedSettings");
        }
        
        /// <summary>
        /// Test LightspeedSaveStoreSettings
        /// </summary>
        [Test]
        public void LightspeedSaveStoreSettingsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? storeId = null;
            //LightspeedSettings lightspeedSettings = null;
            //var response = instance.LightspeedSaveStoreSettings(storeId, lightspeedSettings);
            //Assert.IsInstanceOf<RestApiResultLightspeedSettings> (response, "response is RestApiResultLightspeedSettings");
        }
        
    }

}
