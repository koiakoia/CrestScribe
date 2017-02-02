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
    ///  Class for testing ContactsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class ContactsApiTests
    {
        private ContactsApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new ContactsApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ContactsApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' ContactsApi
            //Assert.IsInstanceOfType(typeof(ContactsApi), instance, "instance is a ContactsApi");
        }

        
        /// <summary>
        /// Test DeleteCharactersCharacterIdContacts
        /// </summary>
        [Test]
        public void DeleteCharactersCharacterIdContactsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? characterId = null;
            //List<int?> contactIds = null;
            //string datasource = null;
            //instance.DeleteCharactersCharacterIdContacts(characterId, contactIds, datasource);
            
        }
        
        /// <summary>
        /// Test GetCharactersCharacterIdContacts
        /// </summary>
        [Test]
        public void GetCharactersCharacterIdContactsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? characterId = null;
            //int? page = null;
            //string datasource = null;
            //var response = instance.GetCharactersCharacterIdContacts(characterId, page, datasource);
            //Assert.IsInstanceOf<List<GetCharactersCharacterIdContacts200Ok>> (response, "response is List<GetCharactersCharacterIdContacts200Ok>");
        }
        
        /// <summary>
        /// Test GetCharactersCharacterIdContactsLabels
        /// </summary>
        [Test]
        public void GetCharactersCharacterIdContactsLabelsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? characterId = null;
            //string datasource = null;
            //var response = instance.GetCharactersCharacterIdContactsLabels(characterId, datasource);
            //Assert.IsInstanceOf<List<GetCharactersCharacterIdContactsLabels200Ok>> (response, "response is List<GetCharactersCharacterIdContactsLabels200Ok>");
        }
        
        /// <summary>
        /// Test PostCharactersCharacterIdContacts
        /// </summary>
        [Test]
        public void PostCharactersCharacterIdContactsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? characterId = null;
            //float? standing = null;
            //List<int?> contactIds = null;
            //bool? watched = null;
            //long? labelId = null;
            //string datasource = null;
            //var response = instance.PostCharactersCharacterIdContacts(characterId, standing, contactIds, watched, labelId, datasource);
            //Assert.IsInstanceOf<List<int?>> (response, "response is List<int?>");
        }
        
        /// <summary>
        /// Test PutCharactersCharacterIdContacts
        /// </summary>
        [Test]
        public void PutCharactersCharacterIdContactsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? characterId = null;
            //float? standing = null;
            //List<int?> contactIds = null;
            //bool? watched = null;
            //long? labelId = null;
            //string datasource = null;
            //instance.PutCharactersCharacterIdContacts(characterId, standing, contactIds, watched, labelId, datasource);
            
        }
        
    }

}
