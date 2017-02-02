/* 
 * EVE Swagger Interface
 *
 * An OpenAPI for EVE Online
 *
 * OpenAPI spec version: 0.3.9
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

using ESI.Client;
using ESI.Api;
using ESI.Model;

namespace ESI.Test
{
    /// <summary>
    ///  Class for testing InsuranceApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class InsuranceApiTests
    {
        private InsuranceApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new InsuranceApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of InsuranceApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' InsuranceApi
            //Assert.IsInstanceOfType(typeof(InsuranceApi), instance, "instance is a InsuranceApi");
        }

        
        /// <summary>
        /// Test GetInsurancePrices
        /// </summary>
        [Test]
        public void GetInsurancePricesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string language = null;
            //string datasource = null;
            //var response = instance.GetInsurancePrices(language, datasource);
            //Assert.IsInstanceOf<List<GetInsurancePrices200Ok>> (response, "response is List<GetInsurancePrices200Ok>");
        }
        
    }

}
