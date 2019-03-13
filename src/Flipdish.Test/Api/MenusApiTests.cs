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
        /// Test CreateDraftMenuFromExistingMenu
        /// </summary>
        [Test]
        public void CreateDraftMenuFromExistingMenuTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? menuId = null;
            //instance.CreateDraftMenuFromExistingMenu(menuId);
            
        }
        
        /// <summary>
        /// Test CreateNewMenuForApp
        /// </summary>
        [Test]
        public void CreateNewMenuForAppTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string appId = null;
            //var response = instance.CreateNewMenuForApp(appId);
            //Assert.IsInstanceOf<int?> (response, "response is int?");
        }
        
        /// <summary>
        /// Test DeleteMenu
        /// </summary>
        [Test]
        public void DeleteMenuTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? menuId = null;
            //instance.DeleteMenu(menuId);
            
        }
        
        /// <summary>
        /// Test DeleteMenuImage
        /// </summary>
        [Test]
        public void DeleteMenuImageTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? menuId = null;
            //instance.DeleteMenuImage(menuId);
            
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
            //instance.DeleteMenuItemMetadata(menuId, storeId, menuItemId, key);
            
        }
        
        /// <summary>
        /// Test GetMenuById
        /// </summary>
        [Test]
        public void GetMenuByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? menuId = null;
            //var response = instance.GetMenuById(menuId);
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
            //var response = instance.GetMenuItemMetadata(menuId, storeId, menuItemId);
            //Assert.IsInstanceOf<RestApiArrayResultMetadata> (response, "response is RestApiArrayResultMetadata");
        }
        
        /// <summary>
        /// Test GetMenuItemMetadataByKey
        /// </summary>
        [Test]
        public void GetMenuItemMetadataByKeyTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? menuId = null;
            //int? storeId = null;
            //int? menuItemId = null;
            //string key = null;
            //instance.GetMenuItemMetadataByKey(menuId, storeId, menuItemId, key);
            
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
            //var response = instance.GetMenuItemOptionSetItemMetadata(menuId, storeId, optionSetItemId);
            //Assert.IsInstanceOf<RestApiResultMetadata> (response, "response is RestApiResultMetadata");
        }
        
        /// <summary>
        /// Test GetMenusByAppId
        /// </summary>
        [Test]
        public void GetMenusByAppIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string appId = null;
            //var response = instance.GetMenusByAppId(appId);
            //Assert.IsInstanceOf<RestApiArrayResultMenuSummary> (response, "response is RestApiArrayResultMenuSummary");
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
            //instance.SetMenuItemMetadata(menuId, storeId, menuItemId, metadata);
            
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
            //instance.SetMenuItemOptionSetItemMetadata(menuId, storeId, optionSetItemId, metadata);
            
        }
        
        /// <summary>
        /// Test SetMenuLock
        /// </summary>
        [Test]
        public void SetMenuLockTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? menuId = null;
            //bool? locked = null;
            //instance.SetMenuLock(menuId, locked);
            
        }
        
        /// <summary>
        /// Test SetMenuName
        /// </summary>
        [Test]
        public void SetMenuNameTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? menuId = null;
            //string name = null;
            //instance.SetMenuName(menuId, name);
            
        }
        
        /// <summary>
        /// Test UpdateMenu
        /// </summary>
        [Test]
        public void UpdateMenuTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? menuId = null;
            //MenuBase menu = null;
            //instance.UpdateMenu(menuId, menu);
            
        }
        
        /// <summary>
        /// Test UploadMenuImage
        /// </summary>
        [Test]
        public void UploadMenuImageTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? menuId = null;
            //System.IO.Stream image = null;
            //var response = instance.UploadMenuImage(menuId, image);
            //Assert.IsInstanceOf<RestApiStringResult> (response, "response is RestApiStringResult");
        }
        
    }

}
