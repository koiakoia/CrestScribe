# ESI.Api.CalendarApi

All URIs are relative to *https://esi.tech.ccp.is/dev*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetCharactersCharacterIdCalendar**](CalendarApi.md#getcharacterscharacteridcalendar) | **GET** /characters/{character_id}/calendar/ | List calendar event summaries
[**GetCharactersCharacterIdCalendarEventId**](CalendarApi.md#getcharacterscharacteridcalendareventid) | **GET** /characters/{character_id}/calendar/{event_id}/ | Get an event
[**PutCharactersCharacterIdCalendarEventId**](CalendarApi.md#putcharacterscharacteridcalendareventid) | **PUT** /characters/{character_id}/calendar/{event_id}/ | Respond to an event


<a name="getcharacterscharacteridcalendar"></a>
# **GetCharactersCharacterIdCalendar**
> List<GetCharactersCharacterIdCalendar200Ok> GetCharactersCharacterIdCalendar (int? characterId, int? fromEvent = null, string datasource = null)

List calendar event summaries

Get 50 event summaries from the calendar. If no event ID is given, the resource will return the next 50 chronological event summaries from now. If an event ID is specified, it will return the next 50 chronological event summaries from after that event.   - --  Alternate route: `/v1/characters/{character_id}/calendar/`  Alternate route: `/legacy/characters/{character_id}/calendar/`  Alternate route: `/latest/characters/{character_id}/calendar/`   - --  This route is cached for up to 5 seconds

### Example
```csharp
using System;
using System.Diagnostics;
using ESI.Api;
using ESI.Client;
using ESI.Model;

namespace Example
{
    public class GetCharactersCharacterIdCalendarExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: evesso
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CalendarApi();
            var characterId = 56;  // int? | The character to retrieve events from
            var fromEvent = 56;  // int? | The event ID to retrieve events from (optional) 
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)

            try
            {
                // List calendar event summaries
                List&lt;GetCharactersCharacterIdCalendar200Ok&gt; result = apiInstance.GetCharactersCharacterIdCalendar(characterId, fromEvent, datasource);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CalendarApi.GetCharactersCharacterIdCalendar: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **characterId** | **int?**| The character to retrieve events from | 
 **fromEvent** | **int?**| The event ID to retrieve events from | [optional] 
 **datasource** | **string**| The server name you would like data from | [optional] [default to tranquility]

### Return type

[**List<GetCharactersCharacterIdCalendar200Ok>**](GetCharactersCharacterIdCalendar200Ok.md)

### Authorization

[evesso](../README.md#evesso)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcharacterscharacteridcalendareventid"></a>
# **GetCharactersCharacterIdCalendarEventId**
> GetCharactersCharacterIdCalendarEventIdOk GetCharactersCharacterIdCalendarEventId (int? characterId, int? eventId, string datasource = null)

Get an event

Get all the information for a specific event  - --  Alternate route: `/v3/characters/{character_id}/calendar/{event_id}/`  Alternate route: `/latest/characters/{character_id}/calendar/{event_id}/`   - --  This route is cached for up to 5 seconds

### Example
```csharp
using System;
using System.Diagnostics;
using ESI.Api;
using ESI.Client;
using ESI.Model;

namespace Example
{
    public class GetCharactersCharacterIdCalendarEventIdExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: evesso
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CalendarApi();
            var characterId = 56;  // int? | The character id requesting the event
            var eventId = 56;  // int? | The id of the event requested
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)

            try
            {
                // Get an event
                GetCharactersCharacterIdCalendarEventIdOk result = apiInstance.GetCharactersCharacterIdCalendarEventId(characterId, eventId, datasource);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CalendarApi.GetCharactersCharacterIdCalendarEventId: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **characterId** | **int?**| The character id requesting the event | 
 **eventId** | **int?**| The id of the event requested | 
 **datasource** | **string**| The server name you would like data from | [optional] [default to tranquility]

### Return type

[**GetCharactersCharacterIdCalendarEventIdOk**](GetCharactersCharacterIdCalendarEventIdOk.md)

### Authorization

[evesso](../README.md#evesso)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putcharacterscharacteridcalendareventid"></a>
# **PutCharactersCharacterIdCalendarEventId**
> void PutCharactersCharacterIdCalendarEventId (int? characterId, int? eventId, PutCharactersCharacterIdCalendarEventIdResponse response, string datasource = null)

Respond to an event

Set your response status to an event  - --  Alternate route: `/v3/characters/{character_id}/calendar/{event_id}/`  Alternate route: `/latest/characters/{character_id}/calendar/{event_id}/` 

### Example
```csharp
using System;
using System.Diagnostics;
using ESI.Api;
using ESI.Client;
using ESI.Model;

namespace Example
{
    public class PutCharactersCharacterIdCalendarEventIdExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: evesso
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CalendarApi();
            var characterId = 56;  // int? | The character ID requesting the event
            var eventId = 56;  // int? | The ID of the event requested
            var response = new PutCharactersCharacterIdCalendarEventIdResponse(); // PutCharactersCharacterIdCalendarEventIdResponse | The response value to set, overriding current value.
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)

            try
            {
                // Respond to an event
                apiInstance.PutCharactersCharacterIdCalendarEventId(characterId, eventId, response, datasource);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CalendarApi.PutCharactersCharacterIdCalendarEventId: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **characterId** | **int?**| The character ID requesting the event | 
 **eventId** | **int?**| The ID of the event requested | 
 **response** | [**PutCharactersCharacterIdCalendarEventIdResponse**](PutCharactersCharacterIdCalendarEventIdResponse.md)| The response value to set, overriding current value. | 
 **datasource** | **string**| The server name you would like data from | [optional] [default to tranquility]

### Return type

void (empty response body)

### Authorization

[evesso](../README.md#evesso)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

