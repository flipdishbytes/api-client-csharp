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
    ///  Class for testing StuartApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class StuartApiTests
    {
        private StuartApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new StuartApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of StuartApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' StuartApi
            //Assert.IsInstanceOfType(typeof(StuartApi), instance, "instance is a StuartApi");
        }

        
        /// <summary>
        /// Test StuartCancelJob
        /// </summary>
        [Test]
        public void StuartCancelJobTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? jobId = null;
            //int? storeId = null;
            //var response = instance.StuartCancelJob(jobId, storeId);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
        
        /// <summary>
        /// Test StuartGetJob
        /// </summary>
        [Test]
        public void StuartGetJobTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? jobId = null;
            //int? storeId = null;
            //var response = instance.StuartGetJob(jobId, storeId);
            //Assert.IsInstanceOf<RestApiResultJobResponse> (response, "response is RestApiResultJobResponse");
        }
        
        /// <summary>
        /// Test StuartGetStuartSettings
        /// </summary>
        [Test]
        public void StuartGetStuartSettingsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? storeId = null;
            //var response = instance.StuartGetStuartSettings(storeId);
            //Assert.IsInstanceOf<RestApiResultStuartSettings> (response, "response is RestApiResultStuartSettings");
        }
        
        /// <summary>
        /// Test StuartPostStuartSettings
        /// </summary>
        [Test]
        public void StuartPostStuartSettingsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? storeId = null;
            //StuartSettings stuartSettings = null;
            //var response = instance.StuartPostStuartSettings(storeId, stuartSettings);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
        
    }

}
