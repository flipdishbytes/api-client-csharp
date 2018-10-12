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
    ///  Class for testing StoresApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class StoresApiTests
    {
        private StoresApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new StoresApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of StoresApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' StoresApi
            //Assert.IsInstanceOfType(typeof(StoresApi), instance, "instance is a StoresApi");
        }

        
        /// <summary>
        /// Test CreateStore
        /// </summary>
        [Test]
        public void CreateStoreTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? storeGroupId = null;
            //StoreCreateBase store = null;
            //var response = instance.CreateStore(storeGroupId, store);
            //Assert.IsInstanceOf<RestApiResultStore> (response, "response is RestApiResultStore");
        }
        
        /// <summary>
        /// Test GetProcessingFeeConfigsByStoreId
        /// </summary>
        [Test]
        public void GetProcessingFeeConfigsByStoreIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? storeId = null;
            //string appNameId = null;
            //var response = instance.GetProcessingFeeConfigsByStoreId(storeId, appNameId);
            //Assert.IsInstanceOf<RestApiArrayResultProcessingFeeConfig> (response, "response is RestApiArrayResultProcessingFeeConfig");
        }
        
        /// <summary>
        /// Test GetProcessingFeeConfigsByStoreIdAndPaymentAccountType
        /// </summary>
        [Test]
        public void GetProcessingFeeConfigsByStoreIdAndPaymentAccountTypeTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? storeId = null;
            //string paymentAccountType = null;
            //string appNameId = null;
            //var response = instance.GetProcessingFeeConfigsByStoreIdAndPaymentAccountType(storeId, paymentAccountType, appNameId);
            //Assert.IsInstanceOf<RestApiResultProcessingFeeConfig> (response, "response is RestApiResultProcessingFeeConfig");
        }
        
        /// <summary>
        /// Test GetStoreById
        /// </summary>
        [Test]
        public void GetStoreByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? storeId = null;
            //var response = instance.GetStoreById(storeId);
            //Assert.IsInstanceOf<RestApiResultStore> (response, "response is RestApiResultStore");
        }
        
        /// <summary>
        /// Test GetStores
        /// </summary>
        [Test]
        public void GetStoresTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string searchQuery = null;
            //int? page = null;
            //int? limit = null;
            //int? storeGroupId = null;
            //var response = instance.GetStores(searchQuery, page, limit, storeGroupId);
            //Assert.IsInstanceOf<RestApiPaginationResultStore> (response, "response is RestApiPaginationResultStore");
        }
        
        /// <summary>
        /// Test UpdateStore
        /// </summary>
        [Test]
        public void UpdateStoreTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? storeId = null;
            //StoreBase store = null;
            //var response = instance.UpdateStore(storeId, store);
            //Assert.IsInstanceOf<RestApiResultStore> (response, "response is RestApiResultStore");
        }
        
        /// <summary>
        /// Test UpdateStoreAddress
        /// </summary>
        [Test]
        public void UpdateStoreAddressTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? storeId = null;
            //StoreAddressBase storeAddress = null;
            //var response = instance.UpdateStoreAddress(storeId, storeAddress);
            //Assert.IsInstanceOf<RestApiResultStoreAddress> (response, "response is RestApiResultStoreAddress");
        }
        
        /// <summary>
        /// Test UpdateStoreAddressCoordinates
        /// </summary>
        [Test]
        public void UpdateStoreAddressCoordinatesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? storeId = null;
            //Coordinates coordinates = null;
            //string appNameId = null;
            //var response = instance.UpdateStoreAddressCoordinates(storeId, coordinates, appNameId);
            //Assert.IsInstanceOf<RestApiResultCoordinates> (response, "response is RestApiResultCoordinates");
        }
        
    }

}
