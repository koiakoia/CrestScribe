# ESI.Api.SearchApi

All URIs are relative to *https://esi.tech.ccp.is/dev*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetCharactersCharacterIdSearch**](SearchApi.md#getcharacterscharacteridsearch) | **GET** /characters/{character_id}/search/ | Search on a string
[**GetSearch**](SearchApi.md#getsearch) | **GET** /search/ | Search on a string


<a name="getcharacterscharacteridsearch"></a>
# **GetCharactersCharacterIdSearch**
> GetCharactersCharacterIdSearchOk GetCharactersCharacterIdSearch (int? characterId, string search, List<string> categories, string language = null, bool? strict = null, string datasource = null)

Search on a string

Search for entities that match a given sub-string.  - --  Alternate route: `/v3/characters/{character_id}/search/`   - --  This route is cached for up to 3600 seconds

### Example
```csharp
using System;
using System.Diagnostics;
using ESI.Api;
using ESI.Client;
using ESI.Model;

namespace Example
{
    public class GetCharactersCharacterIdSearchExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: evesso
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SearchApi();
            var characterId = 56;  // int? | An EVE character ID
            var search = search_example;  // string | The string to search on
            var categories = new List<string>(); // List<string> | Type of entities to search for
            var language = language_example;  // string | Search locale (optional)  (default to en-us)
            var strict = true;  // bool? | Whether the search should be a strict match (optional)  (default to false)
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)

            try
            {
                // Search on a string
                GetCharactersCharacterIdSearchOk result = apiInstance.GetCharactersCharacterIdSearch(characterId, search, categories, language, strict, datasource);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SearchApi.GetCharactersCharacterIdSearch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **characterId** | **int?**| An EVE character ID | 
 **search** | **string**| The string to search on | 
 **categories** | [**List&lt;string&gt;**](string.md)| Type of entities to search for | 
 **language** | **string**| Search locale | [optional] [default to en-us]
 **strict** | **bool?**| Whether the search should be a strict match | [optional] [default to false]
 **datasource** | **string**| The server name you would like data from | [optional] [default to tranquility]

### Return type

[**GetCharactersCharacterIdSearchOk**](GetCharactersCharacterIdSearchOk.md)

### Authorization

[evesso](../README.md#evesso)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getsearch"></a>
# **GetSearch**
> GetSearchOk GetSearch (string search, List<string> categories, string language = null, bool? strict = null, string datasource = null)

Search on a string

Search for entities that match a given sub-string.  - --  Alternate route: `/v2/search/`   - --  This route is cached for up to 3600 seconds

### Example
```csharp
using System;
using System.Diagnostics;
using ESI.Api;
using ESI.Client;
using ESI.Model;

namespace Example
{
    public class GetSearchExample
    {
        public void main()
        {
            
            var apiInstance = new SearchApi();
            var search = search_example;  // string | The string to search on
            var categories = new List<string>(); // List<string> | Type of entities to search for
            var language = language_example;  // string | Search locale (optional)  (default to en-us)
            var strict = true;  // bool? | Whether the search should be a strict match (optional)  (default to false)
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)

            try
            {
                // Search on a string
                GetSearchOk result = apiInstance.GetSearch(search, categories, language, strict, datasource);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SearchApi.GetSearch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **search** | **string**| The string to search on | 
 **categories** | [**List&lt;string&gt;**](string.md)| Type of entities to search for | 
 **language** | **string**| Search locale | [optional] [default to en-us]
 **strict** | **bool?**| Whether the search should be a strict match | [optional] [default to false]
 **datasource** | **string**| The server name you would like data from | [optional] [default to tranquility]

### Return type

[**GetSearchOk**](GetSearchOk.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

