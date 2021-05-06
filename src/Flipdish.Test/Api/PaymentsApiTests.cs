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
    ///  Class for testing PaymentsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class PaymentsApiTests
    {
        private PaymentsApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new PaymentsApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of PaymentsApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' PaymentsApi
            //Assert.IsInstanceOfType(typeof(PaymentsApi), instance, "instance is a PaymentsApi");
        }

        
        /// <summary>
        /// Test GetOrderPaymentInformation
        /// </summary>
        [Test]
        public void GetOrderPaymentInformationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? orderId = null;
            //var response = instance.GetOrderPaymentInformation(orderId);
            //Assert.IsInstanceOf<RestApiResultOrderPaymentInformation> (response, "response is RestApiResultOrderPaymentInformation");
        }
        
    }

}
