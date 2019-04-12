/* 
 * Flipdish Open API v1.0
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: v1.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */


using NUnit.Framework;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using Flipdish.Api;
using Flipdish.Model;
using Flipdish.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace Flipdish.Test
{
    /// <summary>
    ///  Class for testing Voucher
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class VoucherTests
    {
        // TODO uncomment below to declare an instance variable for Voucher
        //private Voucher instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of Voucher
            //instance = new Voucher();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of Voucher
        /// </summary>
        [Test]
        public void VoucherInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" Voucher
            //Assert.IsInstanceOfType<Voucher> (instance, "variable 'instance' is a Voucher");
        }


        /// <summary>
        /// Test the property 'VoucherId'
        /// </summary>
        [Test]
        public void VoucherIdTest()
        {
            // TODO unit test for the property 'VoucherId'
        }
        /// <summary>
        /// Test the property 'Status'
        /// </summary>
        [Test]
        public void StatusTest()
        {
            // TODO unit test for the property 'Status'
        }
        /// <summary>
        /// Test the property 'VoucherType'
        /// </summary>
        [Test]
        public void VoucherTypeTest()
        {
            // TODO unit test for the property 'VoucherType'
        }
        /// <summary>
        /// Test the property 'VoucherSubType'
        /// </summary>
        [Test]
        public void VoucherSubTypeTest()
        {
            // TODO unit test for the property 'VoucherSubType'
        }
        /// <summary>
        /// Test the property 'Currency'
        /// </summary>
        [Test]
        public void CurrencyTest()
        {
            // TODO unit test for the property 'Currency'
        }
        /// <summary>
        /// Test the property 'AddItemDetails'
        /// </summary>
        [Test]
        public void AddItemDetailsTest()
        {
            // TODO unit test for the property 'AddItemDetails'
        }
        /// <summary>
        /// Test the property 'CreditNoteDetails'
        /// </summary>
        [Test]
        public void CreditNoteDetailsTest()
        {
            // TODO unit test for the property 'CreditNoteDetails'
        }
        /// <summary>
        /// Test the property 'LumpDiscountDetails'
        /// </summary>
        [Test]
        public void LumpDiscountDetailsTest()
        {
            // TODO unit test for the property 'LumpDiscountDetails'
        }
        /// <summary>
        /// Test the property 'PercentDiscountDetails'
        /// </summary>
        [Test]
        public void PercentDiscountDetailsTest()
        {
            // TODO unit test for the property 'PercentDiscountDetails'
        }
        /// <summary>
        /// Test the property 'Code'
        /// </summary>
        [Test]
        public void CodeTest()
        {
            // TODO unit test for the property 'Code'
        }
        /// <summary>
        /// Test the property 'Description'
        /// </summary>
        [Test]
        public void DescriptionTest()
        {
            // TODO unit test for the property 'Description'
        }
        /// <summary>
        /// Test the property 'Stores'
        /// </summary>
        [Test]
        public void StoresTest()
        {
            // TODO unit test for the property 'Stores'
        }
        /// <summary>
        /// Test the property 'ValidOnOrdersOver'
        /// </summary>
        [Test]
        public void ValidOnOrdersOverTest()
        {
            // TODO unit test for the property 'ValidOnOrdersOver'
        }
        /// <summary>
        /// Test the property 'IsEnabled'
        /// </summary>
        [Test]
        public void IsEnabledTest()
        {
            // TODO unit test for the property 'IsEnabled'
        }
        /// <summary>
        /// Test the property 'IsAutomaticallyApplied'
        /// </summary>
        [Test]
        public void IsAutomaticallyAppliedTest()
        {
            // TODO unit test for the property 'IsAutomaticallyApplied'
        }
        /// <summary>
        /// Test the property 'IncludeDeliveryFee'
        /// </summary>
        [Test]
        public void IncludeDeliveryFeeTest()
        {
            // TODO unit test for the property 'IncludeDeliveryFee'
        }
        /// <summary>
        /// Test the property 'IsValidForDeliveryOrders'
        /// </summary>
        [Test]
        public void IsValidForDeliveryOrdersTest()
        {
            // TODO unit test for the property 'IsValidForDeliveryOrders'
        }
        /// <summary>
        /// Test the property 'IsValidForPickupOrders'
        /// </summary>
        [Test]
        public void IsValidForPickupOrdersTest()
        {
            // TODO unit test for the property 'IsValidForPickupOrders'
        }
        /// <summary>
        /// Test the property 'IsValidForOrdersPayedOnline'
        /// </summary>
        [Test]
        public void IsValidForOrdersPayedOnlineTest()
        {
            // TODO unit test for the property 'IsValidForOrdersPayedOnline'
        }
        /// <summary>
        /// Test the property 'IsValidForOrdersPayedByCash'
        /// </summary>
        [Test]
        public void IsValidForOrdersPayedByCashTest()
        {
            // TODO unit test for the property 'IsValidForOrdersPayedByCash'
        }
        /// <summary>
        /// Test the property 'IsValidForFirstOrderOnly'
        /// </summary>
        [Test]
        public void IsValidForFirstOrderOnlyTest()
        {
            // TODO unit test for the property 'IsValidForFirstOrderOnly'
        }
        /// <summary>
        /// Test the property 'IsValidOncePerCustomer'
        /// </summary>
        [Test]
        public void IsValidOncePerCustomerTest()
        {
            // TODO unit test for the property 'IsValidOncePerCustomer'
        }
        /// <summary>
        /// Test the property 'IsValidOnlyOnce'
        /// </summary>
        [Test]
        public void IsValidOnlyOnceTest()
        {
            // TODO unit test for the property 'IsValidOnlyOnce'
        }
        /// <summary>
        /// Test the property 'StartDate'
        /// </summary>
        [Test]
        public void StartDateTest()
        {
            // TODO unit test for the property 'StartDate'
        }
        /// <summary>
        /// Test the property 'ExpiryDate'
        /// </summary>
        [Test]
        public void ExpiryDateTest()
        {
            // TODO unit test for the property 'ExpiryDate'
        }

    }

}
