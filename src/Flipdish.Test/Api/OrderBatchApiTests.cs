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
    ///  Class for testing OrderBatchApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class OrderBatchApiTests
    {
        private OrderBatchApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new OrderBatchApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of OrderBatchApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' OrderBatchApi
            //Assert.IsInstanceOfType(typeof(OrderBatchApi), instance, "instance is a OrderBatchApi");
        }

        
        /// <summary>
        /// Test GetAllOrderBatches
        /// </summary>
        [Test]
        public void GetAllOrderBatchesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string appId = null;
            //int? storeId = null;
            //DateTime? startDate = null;
            //DateTime? endDate = null;
            //var response = instance.GetAllOrderBatches(appId, storeId, startDate, endDate);
            //Assert.IsInstanceOf<RestApiArrayResultOrderBatchItem> (response, "response is RestApiArrayResultOrderBatchItem");
        }
        
    }

}
