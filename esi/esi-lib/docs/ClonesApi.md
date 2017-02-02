# ESI.Api.ClonesApi

All URIs are relative to *https://esi.tech.ccp.is/dev*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetCharactersCharacterIdClones**](ClonesApi.md#getcharacterscharacteridclones) | **GET** /characters/{character_id}/clones/ | Get clones


<a name="getcharacterscharacteridclones"></a>
# **GetCharactersCharacterIdClones**
> GetCharactersCharacterIdClonesOk GetCharactersCharacterIdClones (int? characterId, string datasource = null)

Get clones

A list of the character's clones  - --  Alternate route: `/v2/characters/{character_id}/clones/`  Alternate route: `/latest/characters/{character_id}/clones/`   - --  This route is cached for up to 120 seconds

### Example
```csharp
using System;
using System.Diagnostics;
using ESI.Api;
using ESI.Client;
using ESI.Model;

namespace Example
{
    public class GetCharactersCharacterIdClonesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: evesso
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ClonesApi();
            var characterId = 56;  // int? | An EVE character ID
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)

            try
            {
                // Get clones
                GetCharactersCharacterIdClonesOk result = apiInstance.GetCharactersCharacterIdClones(characterId, datasource);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ClonesApi.GetCharactersCharacterIdClones: " + e.Message );
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

[**GetCharactersCharacterIdClonesOk**](GetCharactersCharacterIdClonesOk.md)

### Authorization

[evesso](../README.md#evesso)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

