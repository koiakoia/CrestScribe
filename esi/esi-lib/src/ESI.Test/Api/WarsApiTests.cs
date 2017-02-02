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
    ///  Class for testing WarsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class WarsApiTests
    {
        private WarsApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new WarsApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of WarsApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' WarsApi
            //Assert.IsInstanceOfType(typeof(WarsApi), instance, "instance is a WarsApi");
        }

        
        /// <summary>
        /// Test GetWars
        /// </summary>
        [Test]
        public void GetWarsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? maxWarId = null;
            //string datasource = null;
            //var response = instance.GetWars(maxWarId, datasource);
            //Assert.IsInstanceOf<List<int?>> (response, "response is List<int?>");
        }
        
        /// <summary>
        /// Test GetWarsWarId
        /// </summary>
        [Test]
        public void GetWarsWarIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? warId = null;
            //string datasource = null;
            //var response = instance.GetWarsWarId(warId, datasource);
            //Assert.IsInstanceOf<GetWarsWarIdOk> (response, "response is GetWarsWarIdOk");
        }
        
        /// <summary>
        /// Test GetWarsWarIdKillmails
        /// </summary>
        [Test]
        public void GetWarsWarIdKillmailsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? warId = null;
            //int? page = null;
            //string datasource = null;
            //var response = instance.GetWarsWarIdKillmails(warId, page, datasource);
            //Assert.IsInstanceOf<List<GetWarsWarIdKillmails200Ok>> (response, "response is List<GetWarsWarIdKillmails200Ok>");
        }
        
    }

}
