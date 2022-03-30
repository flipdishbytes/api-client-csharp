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
    ///  Class for testing LocationApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class LocationApiTests
    {
        private LocationApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new LocationApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of LocationApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' LocationApi
            //Assert.IsInstanceOfType(typeof(LocationApi), instance, "instance is a LocationApi");
        }

        
        /// <summary>
        /// Test CreateLocation
        /// </summary>
        [Test]
        public void CreateLocationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //CreateLocation createLocationInput = null;
            //int? locationAreaId = null;
            //string appId = null;
            //int? storeId = null;
            //var response = instance.CreateLocation(createLocationInput, locationAreaId, appId, storeId);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
        
    }

}