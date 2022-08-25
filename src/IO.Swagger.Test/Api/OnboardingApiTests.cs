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

using IO.Swagger.Client;
using IO.Swagger.Api;
using IO.Swagger.Model;

namespace IO.Swagger.Test
{
    /// <summary>
    ///  Class for testing OnboardingApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class OnboardingApiTests
    {
        private OnboardingApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new OnboardingApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of OnboardingApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' OnboardingApi
            //Assert.IsInstanceOfType(typeof(OnboardingApi), instance, "instance is a OnboardingApi");
        }

        
        /// <summary>
        /// Test OnboardingGetOnboardingConfig
        /// </summary>
        [Test]
        public void OnboardingGetOnboardingConfigTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string appId = null;
            //var response = instance.OnboardingGetOnboardingConfig(appId);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
        
        /// <summary>
        /// Test OnboardingGetOnboardingItems
        /// </summary>
        [Test]
        public void OnboardingGetOnboardingItemsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string appId = null;
            //int? storeId = null;
            //var response = instance.OnboardingGetOnboardingItems(appId, storeId);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
        
        /// <summary>
        /// Test OnboardingUpdateOnboardingConfig
        /// </summary>
        [Test]
        public void OnboardingUpdateOnboardingConfigTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string appId = null;
            //OnboardingConfigUpdate configUpdate = null;
            //var response = instance.OnboardingUpdateOnboardingConfig(appId, configUpdate);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
        
        /// <summary>
        /// Test OnboardingUpdateOnboardingItem
        /// </summary>
        [Test]
        public void OnboardingUpdateOnboardingItemTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string appId = null;
            //int? storeId = null;
            //int? onboardingItemId = null;
            //OnboardingItemUpdate itemUpdate = null;
            //var response = instance.OnboardingUpdateOnboardingItem(appId, storeId, onboardingItemId, itemUpdate);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
        
    }

}
