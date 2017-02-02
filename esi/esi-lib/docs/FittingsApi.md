# ESI.Api.FittingsApi

All URIs are relative to *https://esi.tech.ccp.is/dev*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteCharactersCharacterIdFittingsFittingId**](FittingsApi.md#deletecharacterscharacteridfittingsfittingid) | **DELETE** /characters/{character_id}/fittings/{fitting_id}/ | Delete fitting
[**GetCharactersCharacterIdFittings**](FittingsApi.md#getcharacterscharacteridfittings) | **GET** /characters/{character_id}/fittings/ | Get fittings
[**PostCharactersCharacterIdFittings**](FittingsApi.md#postcharacterscharacteridfittings) | **POST** /characters/{character_id}/fittings/ | Create fitting


<a name="deletecharacterscharacteridfittingsfittingid"></a>
# **DeleteCharactersCharacterIdFittingsFittingId**
> void DeleteCharactersCharacterIdFittingsFittingId (int? characterId, int? fittingId, string datasource = null)

Delete fitting

Delete a fitting from a character  - --  Alternate route: `/v1/characters/{character_id}/fittings/{fitting_id}/`  Alternate route: `/legacy/characters/{character_id}/fittings/{fitting_id}/`  Alternate route: `/latest/characters/{character_id}/fittings/{fitting_id}/` 

### Example
```csharp
using System;
using System.Diagnostics;
using ESI.Api;
using ESI.Client;
using ESI.Model;

namespace Example
{
    public class DeleteCharactersCharacterIdFittingsFittingIdExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: evesso
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new FittingsApi();
            var characterId = 56;  // int? | ID for a character
            var fittingId = 56;  // int? | ID for a fitting of this character
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)

            try
            {
                // Delete fitting
                apiInstance.DeleteCharactersCharacterIdFittingsFittingId(characterId, fittingId, datasource);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FittingsApi.DeleteCharactersCharacterIdFittingsFittingId: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **characterId** | **int?**| ID for a character | 
 **fittingId** | **int?**| ID for a fitting of this character | 
 **datasource** | **string**| The server name you would like data from | [optional] [default to tranquility]

### Return type

void (empty response body)

### Authorization

[evesso](../README.md#evesso)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcharacterscharacteridfittings"></a>
# **GetCharactersCharacterIdFittings**
> List<GetCharactersCharacterIdFittings200Ok> GetCharactersCharacterIdFittings (int? characterId, string datasource = null)

Get fittings

Return fittings of a character  - --  Alternate route: `/v1/characters/{character_id}/fittings/`  Alternate route: `/legacy/characters/{character_id}/fittings/`  Alternate route: `/latest/characters/{character_id}/fittings/`   - --  This route is cached for up to 300 seconds

### Example
```csharp
using System;
using System.Diagnostics;
using ESI.Api;
using ESI.Client;
using ESI.Model;

namespace Example
{
    public class GetCharactersCharacterIdFittingsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: evesso
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new FittingsApi();
            var characterId = 56;  // int? | ID for a character
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)

            try
            {
                // Get fittings
                List&lt;GetCharactersCharacterIdFittings200Ok&gt; result = apiInstance.GetCharactersCharacterIdFittings(characterId, datasource);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FittingsApi.GetCharactersCharacterIdFittings: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **characterId** | **int?**| ID for a character | 
 **datasource** | **string**| The server name you would like data from | [optional] [default to tranquility]

### Return type

[**List<GetCharactersCharacterIdFittings200Ok>**](GetCharactersCharacterIdFittings200Ok.md)

### Authorization

[evesso](../README.md#evesso)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postcharacterscharacteridfittings"></a>
# **PostCharactersCharacterIdFittings**
> PostCharactersCharacterIdFittingsCreated PostCharactersCharacterIdFittings (int? characterId, PostCharactersCharacterIdFittingsFitting fitting = null, string datasource = null)

Create fitting

Save a new fitting for a character  - --  Alternate route: `/v1/characters/{character_id}/fittings/`  Alternate route: `/legacy/characters/{character_id}/fittings/`  Alternate route: `/latest/characters/{character_id}/fittings/` 

### Example
```csharp
using System;
using System.Diagnostics;
using ESI.Api;
using ESI.Client;
using ESI.Model;

namespace Example
{
    public class PostCharactersCharacterIdFittingsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: evesso
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new FittingsApi();
            var characterId = 56;  // int? | ID for a character
            var fitting = new PostCharactersCharacterIdFittingsFitting(); // PostCharactersCharacterIdFittingsFitting | Details about the new fitting (optional) 
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)

            try
            {
                // Create fitting
                PostCharactersCharacterIdFittingsCreated result = apiInstance.PostCharactersCharacterIdFittings(characterId, fitting, datasource);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FittingsApi.PostCharactersCharacterIdFittings: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **characterId** | **int?**| ID for a character | 
 **fitting** | [**PostCharactersCharacterIdFittingsFitting**](PostCharactersCharacterIdFittingsFitting.md)| Details about the new fitting | [optional] 
 **datasource** | **string**| The server name you would like data from | [optional] [default to tranquility]

### Return type

[**PostCharactersCharacterIdFittingsCreated**](PostCharactersCharacterIdFittingsCreated.md)

### Authorization

[evesso](../README.md#evesso)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

