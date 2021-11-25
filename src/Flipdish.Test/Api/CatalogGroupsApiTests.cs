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
    ///  Class for testing CatalogGroupsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class CatalogGroupsApiTests
    {
        private CatalogGroupsApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new CatalogGroupsApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of CatalogGroupsApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' CatalogGroupsApi
            //Assert.IsInstanceOfType(typeof(CatalogGroupsApi), instance, "instance is a CatalogGroupsApi");
        }

        
        /// <summary>
        /// Test GetById
        /// </summary>
        [Test]
        public void GetByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string appId = null;
            //string catalogGroupId = null;
            //var response = instance.GetById(appId, catalogGroupId);
            //Assert.IsInstanceOf<CatalogGroup> (response, "response is CatalogGroup");
        }
        
        /// <summary>
        /// Test GetGroups
        /// </summary>
        [Test]
        public void GetGroupsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string appId = null;
            //List<string> groupTypes = null;
            //string searchTerm = null;
            //int? page = null;
            //int? limit = null;
            //var response = instance.GetGroups(appId, groupTypes, searchTerm, page, limit);
            //Assert.IsInstanceOf<RestApiPaginationResultCatalogGroup> (response, "response is RestApiPaginationResultCatalogGroup");
        }
        
    }

}
