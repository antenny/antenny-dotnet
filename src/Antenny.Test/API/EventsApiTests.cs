/*
 * Antenny API
 *
 * This is an api that allows you to interact with the Antenny platform. It allows you to manage your clients and subscriptions.
 *
 * The version of the OpenAPI document: 1.0.0
 * Contact: admin@antenny.io
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using Xunit;

using Antenny.Client;
using Antenny.API;
using Antenny.Model;

namespace Antenny.Test
{
    /// <summary>
    ///  Class for testing EventsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class EventsApiTests : IDisposable
    {
        private EventsApi instance;

        public EventsApiTests()
        {
            instance = new EventsApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of EventsApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' EventsApi
            //Assert.IsType(typeof(EventsApi), instance, "instance is a EventsApi");
        }

        
        /// <summary>
        /// Test ListEvents
        /// </summary>
        [Fact]
        public void ListEventsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid subId = null;
            //string sort = null;
            //string level = null;
            //int? limit = null;
            //string startKey = null;
            //var response = instance.ListEvents(subId, sort, level, limit, startKey);
            //Assert.IsType<EventList> (response, "response is EventList");
        }
        
    }

}
