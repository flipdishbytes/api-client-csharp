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
    ///  Class for testing MenuSectionsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class MenuSectionsApiTests
    {
        private MenuSectionsApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new MenuSectionsApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of MenuSectionsApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' MenuSectionsApi
            //Assert.IsInstanceOfType(typeof(MenuSectionsApi), instance, "instance is a MenuSectionsApi");
        }

        
        /// <summary>
        /// Test CloneMenuSection
        /// </summary>
        [Test]
        public void CloneMenuSectionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? menuId = null;
            //int? menuSectionId = null;
            //var response = instance.CloneMenuSection(menuId, menuSectionId);
            //Assert.IsInstanceOf<RestApiResultMenuSection> (response, "response is RestApiResultMenuSection");
        }
        
        /// <summary>
        /// Test CreateMenuSection
        /// </summary>
        [Test]
        public void CreateMenuSectionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? menuId = null;
            //MenuSectionBase menuSection = null;
            //var response = instance.CreateMenuSection(menuId, menuSection);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
        
        /// <summary>
        /// Test CreateMenuSection_0
        /// </summary>
        [Test]
        public void CreateMenuSection_0Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? menuId = null;
            //int? menuSectionId = null;
            //MenuSectionAvailabilityBase menuSectionAvailability = null;
            //var response = instance.CreateMenuSection_0(menuId, menuSectionId, menuSectionAvailability);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
        
        /// <summary>
        /// Test CreateMenuSection_1
        /// </summary>
        [Test]
        public void CreateMenuSection_1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? menuId = null;
            //int? menuSectionId = null;
            //string dayOfWeek = null;
            //BusinessHoursPeriodBase businessHoursPeriod = null;
            //var response = instance.CreateMenuSection_1(menuId, menuSectionId, dayOfWeek, businessHoursPeriod);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
        
        /// <summary>
        /// Test DeleteMenuSection
        /// </summary>
        [Test]
        public void DeleteMenuSectionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? menuId = null;
            //int? menuSectionId = null;
            //instance.DeleteMenuSection(menuId, menuSectionId);
            
        }
        
        /// <summary>
        /// Test DeleteMenuSectionImage
        /// </summary>
        [Test]
        public void DeleteMenuSectionImageTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? menuId = null;
            //int? menuSectionId = null;
            //instance.DeleteMenuSectionImage(menuId, menuSectionId);
            
        }
        
        /// <summary>
        /// Test GetMenuSectionById
        /// </summary>
        [Test]
        public void GetMenuSectionByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? menuId = null;
            //int? menuSectionId = null;
            //var response = instance.GetMenuSectionById(menuId, menuSectionId);
            //Assert.IsInstanceOf<RestApiResultMenuSection> (response, "response is RestApiResultMenuSection");
        }
        
        /// <summary>
        /// Test GetMenuSections
        /// </summary>
        [Test]
        public void GetMenuSectionsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? menuId = null;
            //var response = instance.GetMenuSections(menuId);
            //Assert.IsInstanceOf<RestApiArrayResultMenuSection> (response, "response is RestApiArrayResultMenuSection");
        }
        
        /// <summary>
        /// Test UpdateMenuSection
        /// </summary>
        [Test]
        public void UpdateMenuSectionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? menuId = null;
            //int? menuSectionId = null;
            //MenuSectionBase menuSection = null;
            //double? undoAfter = null;
            //instance.UpdateMenuSection(menuId, menuSectionId, menuSection, undoAfter);
            
        }
        
        /// <summary>
        /// Test UploadMenuSectionImage
        /// </summary>
        [Test]
        public void UploadMenuSectionImageTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? menuId = null;
            //int? menuSectionId = null;
            //System.IO.Stream image = null;
            //var response = instance.UploadMenuSectionImage(menuId, menuSectionId, image);
            //Assert.IsInstanceOf<RestApiStringResult> (response, "response is RestApiStringResult");
        }
        
    }

}
