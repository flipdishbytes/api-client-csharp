/* 
 * Flipdish Open API
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
    ///  Class for testing MenusApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class MenusApiTests
    {
        private MenusApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new MenusApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of MenusApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' MenusApi
            //Assert.IsInstanceOfType(typeof(MenusApi), instance, "instance is a MenusApi");
        }

        
        /// <summary>
        /// Test DeleteMenuItemMetadata
        /// </summary>
        [Test]
        public void DeleteMenuItemMetadataTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? menuId = null;
            //int? storeId = null;
            //int? menuItemId = null;
            //string key = null;
            //string apiVersion = null;
            //instance.DeleteMenuItemMetadata(menuId, storeId, menuItemId, key, apiVersion);
            
        }
        
        /// <summary>
        /// Test DeleteMenuItemMetadata_0
        /// </summary>
        [Test]
        public void DeleteMenuItemMetadata_0Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? menuId = null;
            //int? storeId = null;
            //int? menuItemId = null;
            //string key = null;
            //string apiVersion = null;
            //instance.DeleteMenuItemMetadata_0(menuId, storeId, menuItemId, key, apiVersion);
            
        }
        
        /// <summary>
        /// Test DeleteMenuSectionImage
        /// </summary>
        [Test]
        public void DeleteMenuSectionImageTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? menuId = null;
            //string apiVersion = null;
            //instance.DeleteMenuSectionImage(menuId, apiVersion);
            
        }
        
        /// <summary>
        /// Test GetMenuById
        /// </summary>
        [Test]
        public void GetMenuByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? menuId = null;
            //string apiVersion = null;
            //var response = instance.GetMenuById(menuId, apiVersion);
            //Assert.IsInstanceOf<RestApiResultMenu> (response, "response is RestApiResultMenu");
        }
        
        /// <summary>
        /// Test GetMenuItemMetadata
        /// </summary>
        [Test]
        public void GetMenuItemMetadataTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? menuId = null;
            //int? storeId = null;
            //int? menuItemId = null;
            //string apiVersion = null;
            //var response = instance.GetMenuItemMetadata(menuId, storeId, menuItemId, apiVersion);
            //Assert.IsInstanceOf<RestApiArrayResultMetadata> (response, "response is RestApiArrayResultMetadata");
        }
        
        /// <summary>
        /// Test GetMenuItemOptionSetItemMetadata
        /// </summary>
        [Test]
        public void GetMenuItemOptionSetItemMetadataTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? menuId = null;
            //int? storeId = null;
            //int? optionSetItemId = null;
            //string apiVersion = null;
            //var response = instance.GetMenuItemOptionSetItemMetadata(menuId, storeId, optionSetItemId, apiVersion);
            //Assert.IsInstanceOf<RestApiResultMetadata> (response, "response is RestApiResultMetadata");
        }
        
        /// <summary>
        /// Test SetMenuItemMetadata
        /// </summary>
        [Test]
        public void SetMenuItemMetadataTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? menuId = null;
            //int? storeId = null;
            //int? menuItemId = null;
            //Metadata metadata = null;
            //string apiVersion = null;
            //instance.SetMenuItemMetadata(menuId, storeId, menuItemId, metadata, apiVersion);
            
        }
        
        /// <summary>
        /// Test SetMenuItemOptionSetItemMetadata
        /// </summary>
        [Test]
        public void SetMenuItemOptionSetItemMetadataTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? menuId = null;
            //int? storeId = null;
            //int? optionSetItemId = null;
            //Metadata metadata = null;
            //string apiVersion = null;
            //instance.SetMenuItemOptionSetItemMetadata(menuId, storeId, optionSetItemId, metadata, apiVersion);
            
        }
        
        /// <summary>
        /// Test UploadMenuSectionImage
        /// </summary>
        [Test]
        public void UploadMenuSectionImageTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? menuId = null;
            //string apiVersion = null;
            //System.IO.Stream image = null;
            //var response = instance.UploadMenuSectionImage(menuId, apiVersion, image);
            //Assert.IsInstanceOf<RestApiStringResult> (response, "response is RestApiStringResult");
        }
        
    }

}
