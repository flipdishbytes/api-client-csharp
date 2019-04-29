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
    ///  Class for testing HomeApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class HomeApiTests
    {
        private HomeApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new HomeApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of HomeApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' HomeApi
            //Assert.IsInstanceOfType(typeof(HomeApi), instance, "instance is a HomeApi");
        }

        
        /// <summary>
        /// Test CompleteHomeAction
        /// </summary>
        [Test]
        public void CompleteHomeActionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? homeActionId = null;
            //bool? isDismissed = null;
            //var response = instance.CompleteHomeAction(homeActionId, isDismissed);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
        
        /// <summary>
        /// Test GetHomeActions
        /// </summary>
        [Test]
        public void GetHomeActionsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string appId = null;
            //var response = instance.GetHomeActions(appId);
            //Assert.IsInstanceOf<RestApiArrayResultHomeAction> (response, "response is RestApiArrayResultHomeAction");
        }
        
        /// <summary>
        /// Test GetHomeStatistics
        /// </summary>
        [Test]
        public void GetHomeStatisticsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string appId = null;
            //var response = instance.GetHomeStatistics(appId);
            //Assert.IsInstanceOf<RestApiResultHomeStatistics> (response, "response is RestApiResultHomeStatistics");
        }
        
    }

}
