# ESI.Api.AssetsApi

All URIs are relative to *https://esi.tech.ccp.is/dev*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetCharactersCharacterIdAssets**](AssetsApi.md#getcharacterscharacteridassets) | **GET** /characters/{character_id}/assets/ | Get character assets


<a name="getcharacterscharacteridassets"></a>
# **GetCharactersCharacterIdAssets**
> List<GetCharactersCharacterIdAssets200Ok> GetCharactersCharacterIdAssets (int? characterId, string datasource = null)

Get character assets

Return a list of the characters assets  - --  Alternate route: `/v1/characters/{character_id}/assets/`  Alternate route: `/legacy/characters/{character_id}/assets/`  Alternate route: `/latest/characters/{character_id}/assets/`   - --  This route is cached for up to 3600 seconds

### Example
```csharp
using System;
using System.Diagnostics;
using ESI.Api;
using ESI.Client;
using ESI.Model;

namespace Example
{
    public class GetCharactersCharacterIdAssetsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: evesso
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AssetsApi();
            var characterId = 56;  // int? | Character id of the target character
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)

            try
            {
                // Get character assets
                List&lt;GetCharactersCharacterIdAssets200Ok&gt; result = apiInstance.GetCharactersCharacterIdAssets(characterId, datasource);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AssetsApi.GetCharactersCharacterIdAssets: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **characterId** | **int?**| Character id of the target character | 
 **datasource** | **string**| The server name you would like data from | [optional] [default to tranquility]

### Return type

[**List<GetCharactersCharacterIdAssets200Ok>**](GetCharactersCharacterIdAssets200Ok.md)

### Authorization

[evesso](../README.md#evesso)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

