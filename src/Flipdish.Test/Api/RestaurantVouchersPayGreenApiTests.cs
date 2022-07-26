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
    ///  Class for testing RestaurantVouchersPayGreenApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class RestaurantVouchersPayGreenApiTests
    {
        private RestaurantVouchersPayGreenApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new RestaurantVouchersPayGreenApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of RestaurantVouchersPayGreenApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' RestaurantVouchersPayGreenApi
            //Assert.IsInstanceOfType(typeof(RestaurantVouchersPayGreenApi), instance, "instance is a RestaurantVouchersPayGreenApi");
        }

        
        /// <summary>
        /// Test CreatePayGreenConfiguration
        /// </summary>
        [Test]
        public void CreatePayGreenConfigurationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string appId = null;
            //CreatePayGreenConfigurationRequest request = null;
            //var response = instance.CreatePayGreenConfiguration(appId, request);
            //Assert.IsInstanceOf<RestApiResultRestaurantVoucherPayGreenConfiguration> (response, "response is RestApiResultRestaurantVoucherPayGreenConfiguration");
        }
        
        /// <summary>
        /// Test DeletePayGreenConfiguration
        /// </summary>
        [Test]
        public void DeletePayGreenConfigurationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string appId = null;
            //int? paygreenConfigurationId = null;
            //var response = instance.DeletePayGreenConfiguration(appId, paygreenConfigurationId);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
        
        /// <summary>
        /// Test GetElegibleStores
        /// </summary>
        [Test]
        public void GetElegibleStoresTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string appId = null;
            //var response = instance.GetElegibleStores(appId);
            //Assert.IsInstanceOf<RestApiArrayResultRestaurantVoucherEligibleStore> (response, "response is RestApiArrayResultRestaurantVoucherEligibleStore");
        }
        
        /// <summary>
        /// Test GetPayGreenConfigurations
        /// </summary>
        [Test]
        public void GetPayGreenConfigurationsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string appId = null;
            //var response = instance.GetPayGreenConfigurations(appId);
            //Assert.IsInstanceOf<RestApiArrayResultRestaurantVoucherPayGreenConfiguration> (response, "response is RestApiArrayResultRestaurantVoucherPayGreenConfiguration");
        }
        
        /// <summary>
        /// Test GetStoreAvailablePayGreenConfigurations
        /// </summary>
        [Test]
        public void GetStoreAvailablePayGreenConfigurationsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string appId = null;
            //int? storeId = null;
            //var response = instance.GetStoreAvailablePayGreenConfigurations(appId, storeId);
            //Assert.IsInstanceOf<RestApiArrayResultRestaurantVoucherPayGreenConfigurationSummary> (response, "response is RestApiArrayResultRestaurantVoucherPayGreenConfigurationSummary");
        }
        
        /// <summary>
        /// Test GetStorePayGreenConfiguration_
        /// </summary>
        [Test]
        public void GetStorePayGreenConfiguration_Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string appId = null;
            //int? storeId = null;
            //var response = instance.GetStorePayGreenConfiguration_(appId, storeId);
            //Assert.IsInstanceOf<RestApiResultRestaurantVoucherPayGreenStoreConfiguration> (response, "response is RestApiResultRestaurantVoucherPayGreenStoreConfiguration");
        }
        
        /// <summary>
        /// Test ListPayGreenConfigurations
        /// </summary>
        [Test]
        public void ListPayGreenConfigurationsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string appId = null;
            //int? paygreenConfigurationId = null;
            //var response = instance.ListPayGreenConfigurations(appId, paygreenConfigurationId);
            //Assert.IsInstanceOf<RestApiResultRestaurantVoucherPayGreenConfiguration> (response, "response is RestApiResultRestaurantVoucherPayGreenConfiguration");
        }
        
        /// <summary>
        /// Test UpdatePayGreenConfiguration
        /// </summary>
        [Test]
        public void UpdatePayGreenConfigurationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string appId = null;
            //int? paygreenConfigurationId = null;
            //UpdatePayGreenConfigurationRequest request = null;
            //var response = instance.UpdatePayGreenConfiguration(appId, paygreenConfigurationId, request);
            //Assert.IsInstanceOf<RestApiResultRestaurantVoucherPayGreenConfiguration> (response, "response is RestApiResultRestaurantVoucherPayGreenConfiguration");
        }
        
        /// <summary>
        /// Test UpdateStorePayGreenConfiguration_
        /// </summary>
        [Test]
        public void UpdateStorePayGreenConfiguration_Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string appId = null;
            //int? storeId = null;
            //UpdateStorePayGreenConfigurationRequest request = null;
            //var response = instance.UpdateStorePayGreenConfiguration_(appId, storeId, request);
            //Assert.IsInstanceOf<RestApiResultRestaurantVoucherPayGreenStoreConfiguration> (response, "response is RestApiResultRestaurantVoucherPayGreenStoreConfiguration");
        }
        
    }

}
