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
    ///  Class for testing UniverseApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class UniverseApiTests
    {
        private UniverseApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new UniverseApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of UniverseApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' UniverseApi
            //Assert.IsInstanceOfType(typeof(UniverseApi), instance, "instance is a UniverseApi");
        }

        
        /// <summary>
        /// Test GetUniverseCategories
        /// </summary>
        [Test]
        public void GetUniverseCategoriesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string datasource = null;
            //var response = instance.GetUniverseCategories(datasource);
            //Assert.IsInstanceOf<List<int?>> (response, "response is List<int?>");
        }
        
        /// <summary>
        /// Test GetUniverseCategoriesCategoryId
        /// </summary>
        [Test]
        public void GetUniverseCategoriesCategoryIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? categoryId = null;
            //string language = null;
            //string datasource = null;
            //var response = instance.GetUniverseCategoriesCategoryId(categoryId, language, datasource);
            //Assert.IsInstanceOf<GetUniverseCategoriesCategoryIdOk> (response, "response is GetUniverseCategoriesCategoryIdOk");
        }
        
        /// <summary>
        /// Test GetUniverseGroups
        /// </summary>
        [Test]
        public void GetUniverseGroupsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? page = null;
            //string datasource = null;
            //var response = instance.GetUniverseGroups(page, datasource);
            //Assert.IsInstanceOf<List<int?>> (response, "response is List<int?>");
        }
        
        /// <summary>
        /// Test GetUniverseGroupsGroupId
        /// </summary>
        [Test]
        public void GetUniverseGroupsGroupIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? groupId = null;
            //string language = null;
            //string datasource = null;
            //var response = instance.GetUniverseGroupsGroupId(groupId, language, datasource);
            //Assert.IsInstanceOf<GetUniverseGroupsGroupIdOk> (response, "response is GetUniverseGroupsGroupIdOk");
        }
        
        /// <summary>
        /// Test GetUniverseRaces
        /// </summary>
        [Test]
        public void GetUniverseRacesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string language = null;
            //string datasource = null;
            //var response = instance.GetUniverseRaces(language, datasource);
            //Assert.IsInstanceOf<List<GetUniverseRaces200Ok>> (response, "response is List<GetUniverseRaces200Ok>");
        }
        
        /// <summary>
        /// Test GetUniverseStationsStationId
        /// </summary>
        [Test]
        public void GetUniverseStationsStationIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? stationId = null;
            //string datasource = null;
            //var response = instance.GetUniverseStationsStationId(stationId, datasource);
            //Assert.IsInstanceOf<GetUniverseStationsStationIdOk> (response, "response is GetUniverseStationsStationIdOk");
        }
        
        /// <summary>
        /// Test GetUniverseStructures
        /// </summary>
        [Test]
        public void GetUniverseStructuresTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string datasource = null;
            //var response = instance.GetUniverseStructures(datasource);
            //Assert.IsInstanceOf<List<long?>> (response, "response is List<long?>");
        }
        
        /// <summary>
        /// Test GetUniverseStructuresStructureId
        /// </summary>
        [Test]
        public void GetUniverseStructuresStructureIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? structureId = null;
            //string datasource = null;
            //var response = instance.GetUniverseStructuresStructureId(structureId, datasource);
            //Assert.IsInstanceOf<GetUniverseStructuresStructureIdOk> (response, "response is GetUniverseStructuresStructureIdOk");
        }
        
        /// <summary>
        /// Test GetUniverseSystemsSystemId
        /// </summary>
        [Test]
        public void GetUniverseSystemsSystemIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? systemId = null;
            //string datasource = null;
            //var response = instance.GetUniverseSystemsSystemId(systemId, datasource);
            //Assert.IsInstanceOf<GetUniverseSystemsSystemIdOk> (response, "response is GetUniverseSystemsSystemIdOk");
        }
        
        /// <summary>
        /// Test GetUniverseTypes
        /// </summary>
        [Test]
        public void GetUniverseTypesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? page = null;
            //string datasource = null;
            //var response = instance.GetUniverseTypes(page, datasource);
            //Assert.IsInstanceOf<List<int?>> (response, "response is List<int?>");
        }
        
        /// <summary>
        /// Test GetUniverseTypesTypeId
        /// </summary>
        [Test]
        public void GetUniverseTypesTypeIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? typeId = null;
            //string language = null;
            //string datasource = null;
            //var response = instance.GetUniverseTypesTypeId(typeId, language, datasource);
            //Assert.IsInstanceOf<GetUniverseTypesTypeIdOk> (response, "response is GetUniverseTypesTypeIdOk");
        }
        
        /// <summary>
        /// Test PostUniverseNames
        /// </summary>
        [Test]
        public void PostUniverseNamesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //List<int?> ids = null;
            //string datasource = null;
            //var response = instance.PostUniverseNames(ids, datasource);
            //Assert.IsInstanceOf<List<PostUniverseNames200Ok>> (response, "response is List<PostUniverseNames200Ok>");
        }
        
    }

}
