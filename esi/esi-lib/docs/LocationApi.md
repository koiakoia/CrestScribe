# ESI.Api.LocationApi

All URIs are relative to *https://esi.tech.ccp.is/dev*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetCharactersCharacterIdLocation**](LocationApi.md#getcharacterscharacteridlocation) | **GET** /characters/{character_id}/location/ | Get character location
[**GetCharactersCharacterIdShip**](LocationApi.md#getcharacterscharacteridship) | **GET** /characters/{character_id}/ship/ | Get current ship


<a name="getcharacterscharacteridlocation"></a>
# **GetCharactersCharacterIdLocation**
> GetCharactersCharacterIdLocationOk GetCharactersCharacterIdLocation (int? characterId, string datasource = null)

Get character location

Information about the characters current location. Returns the current solar system id, and also the current station or structure ID if applicable.  - --  Alternate route: `/v1/characters/{character_id}/location/`  Alternate route: `/legacy/characters/{character_id}/location/`  Alternate route: `/latest/characters/{character_id}/location/`   - --  This route is cached for up to 5 seconds

### Example
```csharp
using System;
using System.Diagnostics;
using ESI.Api;
using ESI.Client;
using ESI.Model;

namespace Example
{
    public class GetCharactersCharacterIdLocationExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: evesso
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LocationApi();
            var characterId = 56;  // int? | An EVE character ID
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)

            try
            {
                // Get character location
                GetCharactersCharacterIdLocationOk result = apiInstance.GetCharactersCharacterIdLocation(characterId, datasource);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LocationApi.GetCharactersCharacterIdLocation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **characterId** | **int?**| An EVE character ID | 
 **datasource** | **string**| The server name you would like data from | [optional] [default to tranquility]

### Return type

[**GetCharactersCharacterIdLocationOk**](GetCharactersCharacterIdLocationOk.md)

### Authorization

[evesso](../README.md#evesso)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcharacterscharacteridship"></a>
# **GetCharactersCharacterIdShip**
> GetCharactersCharacterIdShipOk GetCharactersCharacterIdShip (int? characterId, string datasource = null)

Get current ship

Get the current ship type, name and id  - --  Alternate route: `/v1/characters/{character_id}/ship/`  Alternate route: `/legacy/characters/{character_id}/ship/`  Alternate route: `/latest/characters/{character_id}/ship/`   - --  This route is cached for up to 5 seconds

### Example
```csharp
using System;
using System.Diagnostics;
using ESI.Api;
using ESI.Client;
using ESI.Model;

namespace Example
{
    public class GetCharactersCharacterIdShipExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: evesso
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LocationApi();
            var characterId = 56;  // int? | An EVE character ID
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)

            try
            {
                // Get current ship
                GetCharactersCharacterIdShipOk result = apiInstance.GetCharactersCharacterIdShip(characterId, datasource);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LocationApi.GetCharactersCharacterIdShip: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **characterId** | **int?**| An EVE character ID | 
 **datasource** | **string**| The server name you would like data from | [optional] [default to tranquility]

### Return type

[**GetCharactersCharacterIdShipOk**](GetCharactersCharacterIdShipOk.md)

### Authorization

[evesso](../README.md#evesso)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

