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
    ///  Class for testing AppStoreConfigurationsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class AppStoreConfigurationsApiTests
    {
        private AppStoreConfigurationsApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new AppStoreConfigurationsApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of AppStoreConfigurationsApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' AppStoreConfigurationsApi
            //Assert.IsInstanceOfType(typeof(AppStoreConfigurationsApi), instance, "instance is a AppStoreConfigurationsApi");
        }

        
        /// <summary>
        /// Test CreateAppStoreConfig
        /// </summary>
        [Test]
        public void CreateAppStoreConfigTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string appId = null;
            //string appStoreAppId = null;
            //var response = instance.CreateAppStoreConfig(appId, appStoreAppId);
            //Assert.IsInstanceOf<RestApiResultAppConfigurationSummary> (response, "response is RestApiResultAppConfigurationSummary");
        }
        
        /// <summary>
        /// Test DeleteAppStoreConfig
        /// </summary>
        [Test]
        public void DeleteAppStoreConfigTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string appId = null;
            //string appStoreAppId = null;
            //string configId = null;
            //var response = instance.DeleteAppStoreConfig(appId, appStoreAppId, configId);
            //Assert.IsInstanceOf<RestApiStringResult> (response, "response is RestApiStringResult");
        }
        
        /// <summary>
        /// Test GetAppStoreConfig
        /// </summary>
        [Test]
        public void GetAppStoreConfigTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string appId = null;
            //string appStoreAppId = null;
            //string configId = null;
            //var response = instance.GetAppStoreConfig(appId, appStoreAppId, configId);
            //Assert.IsInstanceOf<AppConfigurationDetail> (response, "response is AppConfigurationDetail");
        }
        
        /// <summary>
        /// Test GetConfiguredAppSingleApp
        /// </summary>
        [Test]
        public void GetConfiguredAppSingleAppTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string appId = null;
            //string appStoreAppId = null;
            //var response = instance.GetConfiguredAppSingleApp(appId, appStoreAppId);
            //Assert.IsInstanceOf<RestApiArrayResultAppConfigurationSummary> (response, "response is RestApiArrayResultAppConfigurationSummary");
        }
        
        /// <summary>
        /// Test GetConfiguredApps
        /// </summary>
        [Test]
        public void GetConfiguredAppsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string appId = null;
            //var response = instance.GetConfiguredApps(appId);
            //Assert.IsInstanceOf<RestApiArrayResultConfiguredAppHeader> (response, "response is RestApiArrayResultConfiguredAppHeader");
        }
        
        /// <summary>
        /// Test UpdateAppStoreConfig
        /// </summary>
        [Test]
        public void UpdateAppStoreConfigTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string appId = null;
            //string appStoreAppId = null;
            //string configId = null;
            //AppConfigurationBase appConfigurationBase = null;
            //instance.UpdateAppStoreConfig(appId, appStoreAppId, configId, appConfigurationBase);
            
        }
        
    }

}