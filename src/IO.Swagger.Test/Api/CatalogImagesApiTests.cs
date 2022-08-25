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

using IO.Swagger.Client;
using IO.Swagger.Api;
using IO.Swagger.Model;

namespace IO.Swagger.Test
{
    /// <summary>
    ///  Class for testing CatalogImagesApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class CatalogImagesApiTests
    {
        private CatalogImagesApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new CatalogImagesApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of CatalogImagesApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' CatalogImagesApi
            //Assert.IsInstanceOfType(typeof(CatalogImagesApi), instance, "instance is a CatalogImagesApi");
        }

        
        /// <summary>
        /// Test UploadCatalogImage
        /// </summary>
        [Test]
        public void UploadCatalogImageTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string appId = null;
            //System.IO.Stream image = null;
            //var response = instance.UploadCatalogImage(appId, image);
            //Assert.IsInstanceOf<CatalogImage> (response, "response is CatalogImage");
        }
        
    }

}
