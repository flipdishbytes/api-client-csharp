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
    ///  Class for testing HttpRequestResponseLogsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class HttpRequestResponseLogsApiTests
    {
        private HttpRequestResponseLogsApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new HttpRequestResponseLogsApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of HttpRequestResponseLogsApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' HttpRequestResponseLogsApi
            //Assert.IsInstanceOfType(typeof(HttpRequestResponseLogsApi), instance, "instance is a HttpRequestResponseLogsApi");
        }

        
        /// <summary>
        /// Test GetHttpLogsByUserIdAsync
        /// </summary>
        [Test]
        public void GetHttpLogsByUserIdAsyncTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //DateTime? start = null;
            //DateTime? end = null;
            //int? filterByUserId = null;
            //int? take = null;
            //var response = instance.GetHttpLogsByUserIdAsync(start, end, filterByUserId, take);
            //Assert.IsInstanceOf<FlipdishPublicModelsV1ApiResultsRestApiArrayResultFlipdishPublicModelsV1ApiRequestResponseLogHttpRequestAndResponseLog> (response, "response is FlipdishPublicModelsV1ApiResultsRestApiArrayResultFlipdishPublicModelsV1ApiRequestResponseLogHttpRequestAndResponseLog");
        }
        
    }

}
