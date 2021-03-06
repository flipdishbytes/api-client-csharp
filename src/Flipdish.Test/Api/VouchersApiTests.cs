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
    ///  Class for testing VouchersApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class VouchersApiTests
    {
        private VouchersApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new VouchersApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of VouchersApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' VouchersApi
            //Assert.IsInstanceOfType(typeof(VouchersApi), instance, "instance is a VouchersApi");
        }

        
        /// <summary>
        /// Test CreateVoucher
        /// </summary>
        [Test]
        public void CreateVoucherTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string appId = null;
            //CreateVoucher voucher = null;
            //var response = instance.CreateVoucher(appId, voucher);
            //Assert.IsInstanceOf<RestApiResultVoucherWithStats> (response, "response is RestApiResultVoucherWithStats");
        }
        
        /// <summary>
        /// Test GetVoucherById
        /// </summary>
        [Test]
        public void GetVoucherByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? voucherId = null;
            //var response = instance.GetVoucherById(voucherId);
            //Assert.IsInstanceOf<RestApiResultVoucherWithStats> (response, "response is RestApiResultVoucherWithStats");
        }
        
        /// <summary>
        /// Test GetVoucherStatsById
        /// </summary>
        [Test]
        public void GetVoucherStatsByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? voucherId = null;
            //string aggregateDataBy = null;
            //int? dataPointLimit = null;
            //var response = instance.GetVoucherStatsById(voucherId, aggregateDataBy, dataPointLimit);
            //Assert.IsInstanceOf<RestApiArrayResultVoucherDataPoint> (response, "response is RestApiArrayResultVoucherDataPoint");
        }
        
        /// <summary>
        /// Test GetVouchers
        /// </summary>
        [Test]
        public void GetVouchersTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string appId = null;
            //int? pageIndex = null;
            //int? pageSize = null;
            //List<string> searchCodes = null;
            //List<string> statusSearch = null;
            //List<string> typeSearch = null;
            //List<string> subTypeSearch = null;
            //List<int?> storeIds = null;
            //var response = instance.GetVouchers(appId, pageIndex, pageSize, searchCodes, statusSearch, typeSearch, subTypeSearch, storeIds);
            //Assert.IsInstanceOf<RestApiPaginationResultVoucherSummary> (response, "response is RestApiPaginationResultVoucherSummary");
        }
        
        /// <summary>
        /// Test UpdateVoucher
        /// </summary>
        [Test]
        public void UpdateVoucherTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? voucherId = null;
            //VoucherBase voucher = null;
            //List<int?> storeId = null;
            //int? percentValue = null;
            //double? lumpValue = null;
            //int? freeItemId = null;
            //var response = instance.UpdateVoucher(voucherId, voucher, storeId, percentValue, lumpValue, freeItemId);
            //Assert.IsInstanceOf<RestApiResultVoucherWithStats> (response, "response is RestApiResultVoucherWithStats");
        }
        
    }

}
