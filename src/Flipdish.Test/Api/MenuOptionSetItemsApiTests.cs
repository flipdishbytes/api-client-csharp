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
    ///  Class for testing MenuOptionSetItemsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class MenuOptionSetItemsApiTests
    {
        private MenuOptionSetItemsApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new MenuOptionSetItemsApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of MenuOptionSetItemsApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' MenuOptionSetItemsApi
            //Assert.IsInstanceOfType(typeof(MenuOptionSetItemsApi), instance, "instance is a MenuOptionSetItemsApi");
        }

        
        /// <summary>
        /// Test AddMenuItemOptionSetItem
        /// </summary>
        [Test]
        public void AddMenuItemOptionSetItemTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? menuId = null;
            //int? menuSectionId = null;
            //int? menuSectionItemId = null;
            //int? optionSetId = null;
            //MenuItemOptionSetItemBase menuItemOptionSetItem = null;
            //var response = instance.AddMenuItemOptionSetItem(menuId, menuSectionId, menuSectionItemId, optionSetId, menuItemOptionSetItem);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
        
        /// <summary>
        /// Test DeleteOptionSetItemImage
        /// </summary>
        [Test]
        public void DeleteOptionSetItemImageTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? menuId = null;
            //int? menuSectionId = null;
            //int? menuSectionItemId = null;
            //int? optionSetId = null;
            //int? menuItemOptionSetItemId = null;
            //instance.DeleteOptionSetItemImage(menuId, menuSectionId, menuSectionItemId, optionSetId, menuItemOptionSetItemId);
            
        }
        
        /// <summary>
        /// Test GetMenuItemOptionSetItemById
        /// </summary>
        [Test]
        public void GetMenuItemOptionSetItemByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? menuId = null;
            //int? menuSectionId = null;
            //int? menuSectionItemId = null;
            //int? optionSetId = null;
            //int? menuItemOptionSetItemId = null;
            //var response = instance.GetMenuItemOptionSetItemById(menuId, menuSectionId, menuSectionItemId, optionSetId, menuItemOptionSetItemId);
            //Assert.IsInstanceOf<RestApiResultMenuItemOptionSetItem> (response, "response is RestApiResultMenuItemOptionSetItem");
        }
        
        /// <summary>
        /// Test GetMenuItemOptionSetItems
        /// </summary>
        [Test]
        public void GetMenuItemOptionSetItemsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? menuId = null;
            //int? menuSectionId = null;
            //int? menuSectionItemId = null;
            //int? optionSetId = null;
            //var response = instance.GetMenuItemOptionSetItems(menuId, menuSectionId, menuSectionItemId, optionSetId);
            //Assert.IsInstanceOf<RestApiArrayResultMenuItemOptionSetItem> (response, "response is RestApiArrayResultMenuItemOptionSetItem");
        }
        
        /// <summary>
        /// Test RemoveMenuItemOptionSetItem
        /// </summary>
        [Test]
        public void RemoveMenuItemOptionSetItemTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? menuId = null;
            //int? menuSectionId = null;
            //int? menuSectionItemId = null;
            //int? optionSetId = null;
            //int? menuItemOptionSetItemId = null;
            //instance.RemoveMenuItemOptionSetItem(menuId, menuSectionId, menuSectionItemId, optionSetId, menuItemOptionSetItemId);
            
        }
        
        /// <summary>
        /// Test UpdateMenuItemOptionSetItem
        /// </summary>
        [Test]
        public void UpdateMenuItemOptionSetItemTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? menuId = null;
            //int? menuSectionId = null;
            //int? menuSectionItemId = null;
            //int? optionSetId = null;
            //int? menuItemOptionSetItemId = null;
            //MenuItemOptionSetItemBase menuItemOptionSetItem = null;
            //instance.UpdateMenuItemOptionSetItem(menuId, menuSectionId, menuSectionItemId, optionSetId, menuItemOptionSetItemId, menuItemOptionSetItem);
            
        }
        
        /// <summary>
        /// Test UploadOptionSetItemImage
        /// </summary>
        [Test]
        public void UploadOptionSetItemImageTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? menuId = null;
            //int? menuSectionId = null;
            //int? menuSectionItemId = null;
            //int? optionSetId = null;
            //int? menuItemOptionSetItemId = null;
            //System.IO.Stream image = null;
            //var response = instance.UploadOptionSetItemImage(menuId, menuSectionId, menuSectionItemId, optionSetId, menuItemOptionSetItemId, image);
            //Assert.IsInstanceOf<RestApiStringResult> (response, "response is RestApiStringResult");
        }
        
    }

}
