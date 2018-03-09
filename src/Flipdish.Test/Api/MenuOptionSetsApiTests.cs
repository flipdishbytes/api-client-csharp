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
    ///  Class for testing MenuOptionSetsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class MenuOptionSetsApiTests
    {
        private MenuOptionSetsApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new MenuOptionSetsApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of MenuOptionSetsApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' MenuOptionSetsApi
            //Assert.IsInstanceOfType(typeof(MenuOptionSetsApi), instance, "instance is a MenuOptionSetsApi");
        }

        
        /// <summary>
        /// Test CreateMenuItemOptionSet
        /// </summary>
        [Test]
        public void CreateMenuItemOptionSetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? menuId = null;
            //int? menuSectionId = null;
            //int? menuSectionItemId = null;
            //MenuItemOptionSetBase menuItemOptionSet = null;
            //var response = instance.CreateMenuItemOptionSet(menuId, menuSectionId, menuSectionItemId, menuItemOptionSet);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
        
        /// <summary>
        /// Test DeleteMenuItemOptionSet
        /// </summary>
        [Test]
        public void DeleteMenuItemOptionSetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? menuId = null;
            //int? menuSectionItemId = null;
            //int? menuSectionId = null;
            //int? optionSetId = null;
            //instance.DeleteMenuItemOptionSet(menuId, menuSectionItemId, menuSectionId, optionSetId);
            
        }
        
        /// <summary>
        /// Test DeleteOptionSetImage
        /// </summary>
        [Test]
        public void DeleteOptionSetImageTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? menuId = null;
            //int? menuSectionId = null;
            //int? menuSectionItemId = null;
            //int? optionSetId = null;
            //instance.DeleteOptionSetImage(menuId, menuSectionId, menuSectionItemId, optionSetId);
            
        }
        
        /// <summary>
        /// Test GetMenuItemOptionSetById
        /// </summary>
        [Test]
        public void GetMenuItemOptionSetByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? menuId = null;
            //int? menuSectionId = null;
            //int? menuSectionItemId = null;
            //int? optionSetId = null;
            //var response = instance.GetMenuItemOptionSetById(menuId, menuSectionId, menuSectionItemId, optionSetId);
            //Assert.IsInstanceOf<RestApiResultMenuItemOptionSet> (response, "response is RestApiResultMenuItemOptionSet");
        }
        
        /// <summary>
        /// Test GetMenuItemOptionSets
        /// </summary>
        [Test]
        public void GetMenuItemOptionSetsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? menuId = null;
            //int? menuSectionId = null;
            //int? menuSectionItemId = null;
            //var response = instance.GetMenuItemOptionSets(menuId, menuSectionId, menuSectionItemId);
            //Assert.IsInstanceOf<RestApiArrayResultMenuItemOptionSet> (response, "response is RestApiArrayResultMenuItemOptionSet");
        }
        
        /// <summary>
        /// Test UpdateMenuItemOptionSet
        /// </summary>
        [Test]
        public void UpdateMenuItemOptionSetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? menuId = null;
            //int? menuSectionItemId = null;
            //int? menuSectionId = null;
            //int? optionSetId = null;
            //MenuItemOptionSetBase menuItemOptionSet = null;
            //instance.UpdateMenuItemOptionSet(menuId, menuSectionItemId, menuSectionId, optionSetId, menuItemOptionSet);
            
        }
        
        /// <summary>
        /// Test UploadOptionSetImage
        /// </summary>
        [Test]
        public void UploadOptionSetImageTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? menuId = null;
            //int? menuSectionId = null;
            //int? menuSectionItemId = null;
            //int? optionSetId = null;
            //System.IO.Stream image = null;
            //var response = instance.UploadOptionSetImage(menuId, menuSectionId, menuSectionItemId, optionSetId, image);
            //Assert.IsInstanceOf<RestApiStringResult> (response, "response is RestApiStringResult");
        }
        
    }

}
