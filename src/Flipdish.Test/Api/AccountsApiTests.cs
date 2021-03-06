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
    ///  Class for testing AccountsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class AccountsApiTests
    {
        private AccountsApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new AccountsApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of AccountsApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' AccountsApi
            //Assert.IsInstanceOfType(typeof(AccountsApi), instance, "instance is a AccountsApi");
        }

        
        /// <summary>
        /// Test AnswerSignUpQuestion
        /// </summary>
        [Test]
        public void AnswerSignUpQuestionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string signupStepAction = null;
            //int? answerId = null;
            //instance.AnswerSignUpQuestion(signupStepAction, answerId);
            
        }
        
        /// <summary>
        /// Test ChangePassword
        /// </summary>
        [Test]
        public void ChangePasswordTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //ChangePasswordModel changePasswordModel = null;
            //instance.ChangePassword(changePasswordModel);
            
        }
        
        /// <summary>
        /// Test ChangePasswordWithPin
        /// </summary>
        [Test]
        public void ChangePasswordWithPinTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //SetPasswordWithPinModel changePasswordModel = null;
            //instance.ChangePasswordWithPin(changePasswordModel);
            
        }
        
        /// <summary>
        /// Test CreateAccount
        /// </summary>
        [Test]
        public void CreateAccountTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //CreateAccountModel createAccountModel = null;
            //instance.CreateAccount(createAccountModel);
            
        }
        
        /// <summary>
        /// Test GetAccountDetails
        /// </summary>
        [Test]
        public void GetAccountDetailsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetAccountDetails();
            //Assert.IsInstanceOf<RestApiResultAccountDetail> (response, "response is RestApiResultAccountDetail");
        }
        
        /// <summary>
        /// Test GetLocalisedTimeZones
        /// </summary>
        [Test]
        public void GetLocalisedTimeZonesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetLocalisedTimeZones();
            //Assert.IsInstanceOf<RestApiArrayResultLocalisedTimeZone> (response, "response is RestApiArrayResultLocalisedTimeZone");
        }
        
        /// <summary>
        /// Test Login
        /// </summary>
        [Test]
        public void LoginTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //LoginModel loginModel = null;
            //instance.Login(loginModel);
            
        }
        
        /// <summary>
        /// Test LoginWithPin
        /// </summary>
        [Test]
        public void LoginWithPinTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //LoginWithPinModel loginModel = null;
            //instance.LoginWithPin(loginModel);
            
        }
        
        /// <summary>
        /// Test Logout
        /// </summary>
        [Test]
        public void LogoutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //instance.Logout();
            
        }
        
        /// <summary>
        /// Test PasswordResetWithToken
        /// </summary>
        [Test]
        public void PasswordResetWithTokenTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //PasswordResetModel passwordResetModel = null;
            //instance.PasswordResetWithToken(passwordResetModel);
            
        }
        
        /// <summary>
        /// Test RequestLoginPin
        /// </summary>
        [Test]
        public void RequestLoginPinTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //RequestLoginPinModel requestLoginPinRequest = null;
            //var response = instance.RequestLoginPin(requestLoginPinRequest);
            //Assert.IsInstanceOf<RequestLoginPinResposne> (response, "response is RequestLoginPinResposne");
        }
        
        /// <summary>
        /// Test RequestPasswordReset
        /// </summary>
        [Test]
        public void RequestPasswordResetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //RequestPasswordResetModel requestPasswordResetModel = null;
            //instance.RequestPasswordReset(requestPasswordResetModel);
            
        }
        
        /// <summary>
        /// Test SkipSignupStep
        /// </summary>
        [Test]
        public void SkipSignupStepTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string signupStepAction = null;
            //instance.SkipSignupStep(signupStepAction);
            
        }
        
        /// <summary>
        /// Test UpdateAccount
        /// </summary>
        [Test]
        public void UpdateAccountTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //AccountDetailBase updateAccountModel = null;
            //instance.UpdateAccount(updateAccountModel);
            
        }
        
    }

}
