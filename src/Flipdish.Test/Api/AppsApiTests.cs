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
    ///  Class for testing AppsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class AppsApiTests
    {
        private AppsApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new AppsApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of AppsApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' AppsApi
            //Assert.IsInstanceOfType(typeof(AppsApi), instance, "instance is a AppsApi");
        }

        
        /// <summary>
        /// Test GetApp
        /// </summary>
        [Test]
        public void GetAppTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string appId = null;
            //var response = instance.GetApp(appId);
            //Assert.IsInstanceOf<RestApiResultApp> (response, "response is RestApiResultApp");
        }
        
        /// <summary>
        /// Test GetApps
        /// </summary>
        [Test]
        public void GetAppsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string nameFilter = null;
            //int? page = null;
            //int? limit = null;
            //var response = instance.GetApps(nameFilter, page, limit);
            //Assert.IsInstanceOf<RestApiPaginationResultApp> (response, "response is RestApiPaginationResultApp");
        }
        
        /// <summary>
        /// Test SetAppConfig
        /// </summary>
        [Test]
        public void SetAppConfigTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string appId = null;
            //AppConfigUpdateModel appConfigUpdate = null;
            //var response = instance.SetAppConfig(appId, appConfigUpdate);
            //Assert.IsInstanceOf<RestApiResultApp> (response, "response is RestApiResultApp");
        }
        
        /// <summary>
        /// Test SetAppLanguages
        /// </summary>
        [Test]
        public void SetAppLanguagesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string appId = null;
            //List<Language> languages = null;
            //var response = instance.SetAppLanguages(appId, languages);
            //Assert.IsInstanceOf<RestApiResultApp> (response, "response is RestApiResultApp");
        }
        
        /// <summary>
        /// Test UploadAppLogo
        /// </summary>
        [Test]
        public void UploadAppLogoTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string appId = null;
            //System.IO.Stream image = null;
            //instance.UploadAppLogo(appId, image);
            
        }
        
    }

}
