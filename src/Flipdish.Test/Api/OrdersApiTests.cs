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
    ///  Class for testing OrdersApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class OrdersApiTests
    {
        private OrdersApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new OrdersApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of OrdersApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' OrdersApi
            //Assert.IsInstanceOfType(typeof(OrdersApi), instance, "instance is a OrdersApi");
        }

        
        /// <summary>
        /// Test AcceptOrder
        /// </summary>
        [Test]
        public void AcceptOrderTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? id = null;
            //Accept acceptObject = null;
            //instance.AcceptOrder(id, acceptObject);
            
        }
        
        /// <summary>
        /// Test GetOrderById
        /// </summary>
        [Test]
        public void GetOrderByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? id = null;
            //var response = instance.GetOrderById(id);
            //Assert.IsInstanceOf<RestApiResultOrder> (response, "response is RestApiResultOrder");
        }
        
        /// <summary>
        /// Test GetOrders
        /// </summary>
        [Test]
        public void GetOrdersTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //List<int?> physicalRestaurantId = null;
            //List<string> state = null;
            //int? page = null;
            //int? limit = null;
            //var response = instance.GetOrders(physicalRestaurantId, state, page, limit);
            //Assert.IsInstanceOf<RestApiPaginationResultOrder> (response, "response is RestApiPaginationResultOrder");
        }
        
        /// <summary>
        /// Test RefundOrder
        /// </summary>
        [Test]
        public void RefundOrderTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? id = null;
            //Refund refundObject = null;
            //instance.RefundOrder(id, refundObject);
            
        }
        
        /// <summary>
        /// Test RejectOrder
        /// </summary>
        [Test]
        public void RejectOrderTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? id = null;
            //Reject rejectObject = null;
            //instance.RejectOrder(id, rejectObject);
            
        }
        
    }

}
