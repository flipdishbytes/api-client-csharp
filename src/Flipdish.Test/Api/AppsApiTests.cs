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
        /// Test GetAppHostnameStatus
        /// </summary>
        [Test]
        public void GetAppHostnameStatusTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string appId = null;
            //var response = instance.GetAppHostnameStatus(appId);
            //Assert.IsInstanceOf<RestApiResultDnsRecordInformation> (response, "response is RestApiResultDnsRecordInformation");
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
        /// Test GetPanaceaVanityUrl
        /// </summary>
        [Test]
        public void GetPanaceaVanityUrlTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string appId = null;
            //var response = instance.GetPanaceaVanityUrl(appId);
            //Assert.IsInstanceOf<RestApiStringResult> (response, "response is RestApiStringResult");
        }
        
        /// <summary>
        /// Test GetSupportedCountries
        /// </summary>
        [Test]
        public void GetSupportedCountriesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetSupportedCountries();
            //Assert.IsInstanceOf<RestApiArrayResultSupportedCountry> (response, "response is RestApiArrayResultSupportedCountry");
        }
        
        /// <summary>
        /// Test IsPanaceaVanityUrlAvailable
        /// </summary>
        [Test]
        public void IsPanaceaVanityUrlAvailableTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string vanityUrl = null;
            //string appId = null;
            //var response = instance.IsPanaceaVanityUrlAvailable(vanityUrl, appId);
            //Assert.IsInstanceOf<RestApiStringResult> (response, "response is RestApiStringResult");
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
        /// Test SetAppHostname
        /// </summary>
        [Test]
        public void SetAppHostnameTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string appId = null;
            //string hostname = null;
            //bool? isEmbed = null;
            //var response = instance.SetAppHostname(appId, hostname, isEmbed);
            //Assert.IsInstanceOf<RestApiStringResult> (response, "response is RestApiStringResult");
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
        /// Test SetPanaceaVanityUrl
        /// </summary>
        [Test]
        public void SetPanaceaVanityUrlTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string appId = null;
            //string vanityUrl = null;
            //var response = instance.SetPanaceaVanityUrl(appId, vanityUrl);
            //Assert.IsInstanceOf<RestApiStringResult> (response, "response is RestApiStringResult");
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
