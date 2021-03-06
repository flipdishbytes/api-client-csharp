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
    ///  Class for testing StoresApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class StoresApiTests
    {
        private StoresApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new StoresApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of StoresApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' StoresApi
            //Assert.IsInstanceOfType(typeof(StoresApi), instance, "instance is a StoresApi");
        }

        
        /// <summary>
        /// Test ArchiveStore
        /// </summary>
        [Test]
        public void ArchiveStoreTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? storeId = null;
            //instance.ArchiveStore(storeId);
            
        }
        
        /// <summary>
        /// Test AssignMenu
        /// </summary>
        [Test]
        public void AssignMenuTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? storeId = null;
            //int? menuId = null;
            //var response = instance.AssignMenu(storeId, menuId);
            //Assert.IsInstanceOf<RestApiArrayResultRestApiDefaultResponse> (response, "response is RestApiArrayResultRestApiDefaultResponse");
        }
        
        /// <summary>
        /// Test CloneStore
        /// </summary>
        [Test]
        public void CloneStoreTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? storeId = null;
            //StoreCloneSettings settings = null;
            //var response = instance.CloneStore(storeId, settings);
            //Assert.IsInstanceOf<RestApiResultStore> (response, "response is RestApiResultStore");
        }
        
        /// <summary>
        /// Test CreateBusinessHoursOverrideByStoreId
        /// </summary>
        [Test]
        public void CreateBusinessHoursOverrideByStoreIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? storeId = null;
            //BusinessHoursOverrideBase businessHoursOverride = null;
            //var response = instance.CreateBusinessHoursOverrideByStoreId(storeId, businessHoursOverride);
            //Assert.IsInstanceOf<RestApiResultBusinessHoursOverride> (response, "response is RestApiResultBusinessHoursOverride");
        }
        
        /// <summary>
        /// Test CreateStore
        /// </summary>
        [Test]
        public void CreateStoreTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? storeGroupId = null;
            //StoreCreateBase store = null;
            //var response = instance.CreateStore(storeGroupId, store);
            //Assert.IsInstanceOf<RestApiResultStore> (response, "response is RestApiResultStore");
        }
        
        /// <summary>
        /// Test DeleteBusinessHoursOverride
        /// </summary>
        [Test]
        public void DeleteBusinessHoursOverrideTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? storeId = null;
            //int? businessHoursOverrideId = null;
            //var response = instance.DeleteBusinessHoursOverride(storeId, businessHoursOverrideId);
            //Assert.IsInstanceOf<RestApiArrayResultRestApiDefaultResponse> (response, "response is RestApiArrayResultRestApiDefaultResponse");
        }
        
        /// <summary>
        /// Test GetBankAccountForStore
        /// </summary>
        [Test]
        public void GetBankAccountForStoreTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? storeId = null;
            //var response = instance.GetBankAccountForStore(storeId);
            //Assert.IsInstanceOf<RestApiResultAssignedBankAccount> (response, "response is RestApiResultAssignedBankAccount");
        }
        
        /// <summary>
        /// Test GetBusinessHours
        /// </summary>
        [Test]
        public void GetBusinessHoursTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? storeId = null;
            //string deliveryType = null;
            //var response = instance.GetBusinessHours(storeId, deliveryType);
            //Assert.IsInstanceOf<RestApiArrayResultBusinessHoursPeriod> (response, "response is RestApiArrayResultBusinessHoursPeriod");
        }
        
        /// <summary>
        /// Test GetBusinessHoursOverrideByStoreId
        /// </summary>
        [Test]
        public void GetBusinessHoursOverrideByStoreIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? storeId = null;
            //DateTime? after = null;
            //int? page = null;
            //int? limit = null;
            //var response = instance.GetBusinessHoursOverrideByStoreId(storeId, after, page, limit);
            //Assert.IsInstanceOf<RestApiPaginationResultBusinessHoursOverride> (response, "response is RestApiPaginationResultBusinessHoursOverride");
        }
        
        /// <summary>
        /// Test GetEndOfDayReport
        /// </summary>
        [Test]
        public void GetEndOfDayReportTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? storeId = null;
            //DateTime? date = null;
            //var response = instance.GetEndOfDayReport(storeId, date);
            //Assert.IsInstanceOf<RestApiResultStoreEndOfDayReport> (response, "response is RestApiResultStoreEndOfDayReport");
        }
        
        /// <summary>
        /// Test GetPreOrderConfig
        /// </summary>
        [Test]
        public void GetPreOrderConfigTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? storeId = null;
            //string deliveryType = null;
            //var response = instance.GetPreOrderConfig(storeId, deliveryType);
            //Assert.IsInstanceOf<RestApiResultPreOrderConfig> (response, "response is RestApiResultPreOrderConfig");
        }
        
        /// <summary>
        /// Test GetPreOrderPreview
        /// </summary>
        [Test]
        public void GetPreOrderPreviewTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? storeId = null;
            //string deliveryType = null;
            //int? preOrderConfigLeadTimeMinutes = null;
            //int? preOrderConfigIntervalMinutes = null;
            //int? preOrderConfigMaxOrderAheadDays = null;
            //bool? preOrderConfigIncludeAsap = null;
            //bool? preOrderConfigIncludeMoreGranularInitialTime = null;
            //string preOrderConfigCutOffTimePreviousDayBasic = null;
            //string preOrderConfigCutOffTimeCurrentDayBasic = null;
            //string preOrderConfigPreOrderTimeDisplayType = null;
            //bool? preOrderConfigAlwaysAppearOpen = null;
            //bool? preOrderConfigRequireExplicitSelectAlways = null;
            //var response = instance.GetPreOrderPreview(storeId, deliveryType, preOrderConfigLeadTimeMinutes, preOrderConfigIntervalMinutes, preOrderConfigMaxOrderAheadDays, preOrderConfigIncludeAsap, preOrderConfigIncludeMoreGranularInitialTime, preOrderConfigCutOffTimePreviousDayBasic, preOrderConfigCutOffTimeCurrentDayBasic, preOrderConfigPreOrderTimeDisplayType, preOrderConfigAlwaysAppearOpen, preOrderConfigRequireExplicitSelectAlways);
            //Assert.IsInstanceOf<RestApiArrayResultPreOrderTime> (response, "response is RestApiArrayResultPreOrderTime");
        }
        
        /// <summary>
        /// Test GetProcessingFeeConfigsByStoreId
        /// </summary>
        [Test]
        public void GetProcessingFeeConfigsByStoreIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? storeId = null;
            //string appNameId = null;
            //var response = instance.GetProcessingFeeConfigsByStoreId(storeId, appNameId);
            //Assert.IsInstanceOf<RestApiArrayResultProcessingFeeConfig> (response, "response is RestApiArrayResultProcessingFeeConfig");
        }
        
        /// <summary>
        /// Test GetProcessingFeeConfigsByStoreIdAndPaymentAccountType
        /// </summary>
        [Test]
        public void GetProcessingFeeConfigsByStoreIdAndPaymentAccountTypeTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? storeId = null;
            //string paymentAccountType = null;
            //string appNameId = null;
            //var response = instance.GetProcessingFeeConfigsByStoreIdAndPaymentAccountType(storeId, paymentAccountType, appNameId);
            //Assert.IsInstanceOf<RestApiResultProcessingFeeConfig> (response, "response is RestApiResultProcessingFeeConfig");
        }
        
        /// <summary>
        /// Test GetStoreById
        /// </summary>
        [Test]
        public void GetStoreByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? storeId = null;
            //var response = instance.GetStoreById(storeId);
            //Assert.IsInstanceOf<RestApiResultStore> (response, "response is RestApiResultStore");
        }
        
        /// <summary>
        /// Test GetStoreHeadersByAppId
        /// </summary>
        [Test]
        public void GetStoreHeadersByAppIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string appId = null;
            //string storeNameQuery = null;
            //int? page = null;
            //int? limit = null;
            //var response = instance.GetStoreHeadersByAppId(appId, storeNameQuery, page, limit);
            //Assert.IsInstanceOf<RestApiPaginationResultStoreHeader> (response, "response is RestApiPaginationResultStoreHeader");
        }
        
        /// <summary>
        /// Test GetStoreNetSales
        /// </summary>
        [Test]
        public void GetStoreNetSalesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string appId = null;
            //List<int?> storeId = null;
            //var response = instance.GetStoreNetSales(appId, storeId);
            //Assert.IsInstanceOf<RestApiArrayResultStoreStatistics> (response, "response is RestApiArrayResultStoreStatistics");
        }
        
        /// <summary>
        /// Test GetStores
        /// </summary>
        [Test]
        public void GetStoresTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string searchQuery = null;
            //int? page = null;
            //int? limit = null;
            //int? storeGroupId = null;
            //var response = instance.GetStores(searchQuery, page, limit, storeGroupId);
            //Assert.IsInstanceOf<RestApiPaginationResultStore> (response, "response is RestApiPaginationResultStore");
        }
        
        /// <summary>
        /// Test GetStoresByAppId
        /// </summary>
        [Test]
        public void GetStoresByAppIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string appId = null;
            //string searchQuery = null;
            //int? page = null;
            //int? limit = null;
            //var response = instance.GetStoresByAppId(appId, searchQuery, page, limit);
            //Assert.IsInstanceOf<RestApiPaginationResultStore> (response, "response is RestApiPaginationResultStore");
        }
        
        /// <summary>
        /// Test PublishStore
        /// </summary>
        [Test]
        public void PublishStoreTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? storeId = null;
            //instance.PublishStore(storeId);
            
        }
        
        /// <summary>
        /// Test SetBusinessHours
        /// </summary>
        [Test]
        public void SetBusinessHoursTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? storeId = null;
            //string deliveryType = null;
            //BusinessHoursPeriodBase businessHoursPeriod = null;
            //var response = instance.SetBusinessHours(storeId, deliveryType, businessHoursPeriod);
            //Assert.IsInstanceOf<RestApiResultBusinessHoursPeriod> (response, "response is RestApiResultBusinessHoursPeriod");
        }
        
        /// <summary>
        /// Test SetPreOrdeEnabled
        /// </summary>
        [Test]
        public void SetPreOrdeEnabledTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? storeId = null;
            //string deliveryType = null;
            //bool? enabled = null;
            //var response = instance.SetPreOrdeEnabled(storeId, deliveryType, enabled);
            //Assert.IsInstanceOf<RestApiArrayResultRestApiDefaultResponse> (response, "response is RestApiArrayResultRestApiDefaultResponse");
        }
        
        /// <summary>
        /// Test UnpublishStore
        /// </summary>
        [Test]
        public void UnpublishStoreTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? storeId = null;
            //instance.UnpublishStore(storeId);
            
        }
        
        /// <summary>
        /// Test UpdatePreOrderConfig
        /// </summary>
        [Test]
        public void UpdatePreOrderConfigTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? storeId = null;
            //string deliveryType = null;
            //PreOrderConfig preOrderConfig = null;
            //var response = instance.UpdatePreOrderConfig(storeId, deliveryType, preOrderConfig);
            //Assert.IsInstanceOf<RestApiArrayResultRestApiDefaultResponse> (response, "response is RestApiArrayResultRestApiDefaultResponse");
        }
        
        /// <summary>
        /// Test UpdateStore
        /// </summary>
        [Test]
        public void UpdateStoreTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? storeId = null;
            //StoreBase store = null;
            //var response = instance.UpdateStore(storeId, store);
            //Assert.IsInstanceOf<RestApiResultStore> (response, "response is RestApiResultStore");
        }
        
        /// <summary>
        /// Test UpdateStoreAddress
        /// </summary>
        [Test]
        public void UpdateStoreAddressTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? storeId = null;
            //StoreAddressBase storeAddress = null;
            //var response = instance.UpdateStoreAddress(storeId, storeAddress);
            //Assert.IsInstanceOf<RestApiResultStoreAddress> (response, "response is RestApiResultStoreAddress");
        }
        
        /// <summary>
        /// Test UpdateStoreAddressCoordinates
        /// </summary>
        [Test]
        public void UpdateStoreAddressCoordinatesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? storeId = null;
            //Coordinates coordinates = null;
            //string appNameId = null;
            //var response = instance.UpdateStoreAddressCoordinates(storeId, coordinates, appNameId);
            //Assert.IsInstanceOf<RestApiResultCoordinates> (response, "response is RestApiResultCoordinates");
        }
        
    }

}
