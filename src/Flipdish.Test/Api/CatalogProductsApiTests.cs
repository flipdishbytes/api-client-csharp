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
    ///  Class for testing CatalogProductsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class CatalogProductsApiTests
    {
        private CatalogProductsApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new CatalogProductsApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of CatalogProductsApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' CatalogProductsApi
            //Assert.IsInstanceOfType(typeof(CatalogProductsApi), instance, "instance is a CatalogProductsApi");
        }

        
        /// <summary>
        /// Test ArchiveProduct
        /// </summary>
        [Test]
        public void ArchiveProductTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string appId = null;
            //string catalogItemId = null;
            //instance.ArchiveProduct(appId, catalogItemId);
            
        }
        
        /// <summary>
        /// Test CreateProduct
        /// </summary>
        [Test]
        public void CreateProductTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string appId = null;
            //CreateProduct createProduct = null;
            //var response = instance.CreateProduct(appId, createProduct);
            //Assert.IsInstanceOf<RestApiResultProduct> (response, "response is RestApiResultProduct");
        }
        
        /// <summary>
        /// Test DuplicateProduct
        /// </summary>
        [Test]
        public void DuplicateProductTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string appId = null;
            //string catalogItemId = null;
            //instance.DuplicateProduct(appId, catalogItemId);
            
        }
        
        /// <summary>
        /// Test GetProductById
        /// </summary>
        [Test]
        public void GetProductByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string appId = null;
            //string catalogItemId = null;
            //var response = instance.GetProductById(appId, catalogItemId);
            //Assert.IsInstanceOf<Product> (response, "response is Product");
        }
        
        /// <summary>
        /// Test GetProducts
        /// </summary>
        [Test]
        public void GetProductsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string appId = null;
            //List<string> itemTypes = null;
            //string searchTerm = null;
            //int? page = null;
            //int? limit = null;
            //var response = instance.GetProducts(appId, itemTypes, searchTerm, page, limit);
            //Assert.IsInstanceOf<RestApiPaginationResultCatalogItem> (response, "response is RestApiPaginationResultCatalogItem");
        }
        
        /// <summary>
        /// Test UpdateProduct
        /// </summary>
        [Test]
        public void UpdateProductTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string appId = null;
            //string catalogItemId = null;
            //UpdateProduct updateProduct = null;
            //instance.UpdateProduct(appId, catalogItemId, updateProduct);
            
        }
        
    }

}