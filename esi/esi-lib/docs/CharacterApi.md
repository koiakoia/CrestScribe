# ESI.Api.CharacterApi

All URIs are relative to *https://esi.tech.ccp.is/dev*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetCharactersCharacterId**](CharacterApi.md#getcharacterscharacterid) | **GET** /characters/{character_id}/ | Get character&#39;s public information
[**GetCharactersCharacterIdCorporationhistory**](CharacterApi.md#getcharacterscharacteridcorporationhistory) | **GET** /characters/{character_id}/corporationhistory/ | Get corporation history
[**GetCharactersCharacterIdPortrait**](CharacterApi.md#getcharacterscharacteridportrait) | **GET** /characters/{character_id}/portrait/ | Get character portraits
[**GetCharactersNames**](CharacterApi.md#getcharactersnames) | **GET** /characters/names/ | Get character names
[**PostCharactersCharacterIdCspa**](CharacterApi.md#postcharacterscharacteridcspa) | **POST** /characters/{character_id}/cspa/ | Calculate a CSPA charge cost


<a name="getcharacterscharacterid"></a>
# **GetCharactersCharacterId**
> GetCharactersCharacterIdOk GetCharactersCharacterId (int? characterId, string datasource = null)

Get character's public information

Public information about a character  - --  Alternate route: `/v4/characters/{character_id}/`   - --  This route is cached for up to 3600 seconds

### Example
```csharp
using System;
using System.Diagnostics;
using ESI.Api;
using ESI.Client;
using ESI.Model;

namespace Example
{
    public class GetCharactersCharacterIdExample
    {
        public void main()
        {
            
            var apiInstance = new CharacterApi();
            var characterId = 56;  // int? | An EVE character ID
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)

            try
            {
                // Get character's public information
                GetCharactersCharacterIdOk result = apiInstance.GetCharactersCharacterId(characterId, datasource);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CharacterApi.GetCharactersCharacterId: " + e.Message );
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

[**GetCharactersCharacterIdOk**](GetCharactersCharacterIdOk.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcharacterscharacteridcorporationhistory"></a>
# **GetCharactersCharacterIdCorporationhistory**
> List<GetCharactersCharacterIdCorporationhistory200Ok> GetCharactersCharacterIdCorporationhistory (int? characterId, string datasource = null)

Get corporation history

Get a list of all the corporations a character has been a member of  - --  Alternate route: `/v1/characters/{character_id}/corporationhistory/`  Alternate route: `/legacy/characters/{character_id}/corporationhistory/`  Alternate route: `/latest/characters/{character_id}/corporationhistory/`   - --  This route is cached for up to 3600 seconds

### Example
```csharp
using System;
using System.Diagnostics;
using ESI.Api;
using ESI.Client;
using ESI.Model;

namespace Example
{
    public class GetCharactersCharacterIdCorporationhistoryExample
    {
        public void main()
        {
            
            var apiInstance = new CharacterApi();
            var characterId = 56;  // int? | An EVE character ID
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)

            try
            {
                // Get corporation history
                List&lt;GetCharactersCharacterIdCorporationhistory200Ok&gt; result = apiInstance.GetCharactersCharacterIdCorporationhistory(characterId, datasource);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CharacterApi.GetCharactersCharacterIdCorporationhistory: " + e.Message );
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

[**List<GetCharactersCharacterIdCorporationhistory200Ok>**](GetCharactersCharacterIdCorporationhistory200Ok.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcharacterscharacteridportrait"></a>
# **GetCharactersCharacterIdPortrait**
> GetCharactersCharacterIdPortraitOk GetCharactersCharacterIdPortrait (int? characterId, string datasource = null)

Get character portraits

Get portrait urls for a character  - --  Alternate route: `/v2/characters/{character_id}/portrait/`  Alternate route: `/latest/characters/{character_id}/portrait/`   - --  This route is cached for up to 3600 seconds

### Example
```csharp
using System;
using System.Diagnostics;
using ESI.Api;
using ESI.Client;
using ESI.Model;

namespace Example
{
    public class GetCharactersCharacterIdPortraitExample
    {
        public void main()
        {
            
            var apiInstance = new CharacterApi();
            var characterId = 56;  // int? | An EVE character ID
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)

            try
            {
                // Get character portraits
                GetCharactersCharacterIdPortraitOk result = apiInstance.GetCharactersCharacterIdPortrait(characterId, datasource);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CharacterApi.GetCharactersCharacterIdPortrait: " + e.Message );
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

[**GetCharactersCharacterIdPortraitOk**](GetCharactersCharacterIdPortraitOk.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcharactersnames"></a>
# **GetCharactersNames**
> List<GetCharactersNames200Ok> GetCharactersNames (List<long?> characterIds, string datasource = null)

Get character names

Resolve a set of character IDs to character names  - --  Alternate route: `/v1/characters/names/`  Alternate route: `/legacy/characters/names/`  Alternate route: `/latest/characters/names/`   - --  This route is cached for up to 3600 seconds

### Example
```csharp
using System;
using System.Diagnostics;
using ESI.Api;
using ESI.Client;
using ESI.Model;

namespace Example
{
    public class GetCharactersNamesExample
    {
        public void main()
        {
            
            var apiInstance = new CharacterApi();
            var characterIds = new List<long?>(); // List<long?> | A comma separated list of character IDs
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)

            try
            {
                // Get character names
                List&lt;GetCharactersNames200Ok&gt; result = apiInstance.GetCharactersNames(characterIds, datasource);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CharacterApi.GetCharactersNames: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **characterIds** | [**List&lt;long?&gt;**](long?.md)| A comma separated list of character IDs | 
 **datasource** | **string**| The server name you would like data from | [optional] [default to tranquility]

### Return type

[**List<GetCharactersNames200Ok>**](GetCharactersNames200Ok.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postcharacterscharacteridcspa"></a>
# **PostCharactersCharacterIdCspa**
> PostCharactersCharacterIdCspaCreated PostCharactersCharacterIdCspa (int? characterId, PostCharactersCharacterIdCspaCharacters characters, string datasource = null)

Calculate a CSPA charge cost

Takes a source character ID in the url and a set of target character ID's in the body, returns a CSPA charge cost  - --  Alternate route: `/v3/characters/{character_id}/cspa/`  Alternate route: `/legacy/characters/{character_id}/cspa/`  Alternate route: `/latest/characters/{character_id}/cspa/` 

### Example
```csharp
using System;
using System.Diagnostics;
using ESI.Api;
using ESI.Client;
using ESI.Model;

namespace Example
{
    public class PostCharactersCharacterIdCspaExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: evesso
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CharacterApi();
            var characterId = 56;  // int? | An EVE character ID
            var characters = new PostCharactersCharacterIdCspaCharacters(); // PostCharactersCharacterIdCspaCharacters | The target characters to calculate the charge for
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)

            try
            {
                // Calculate a CSPA charge cost
                PostCharactersCharacterIdCspaCreated result = apiInstance.PostCharactersCharacterIdCspa(characterId, characters, datasource);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CharacterApi.PostCharactersCharacterIdCspa: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **characterId** | **int?**| An EVE character ID | 
 **characters** | [**PostCharactersCharacterIdCspaCharacters**](PostCharactersCharacterIdCspaCharacters.md)| The target characters to calculate the charge for | 
 **datasource** | **string**| The server name you would like data from | [optional] [default to tranquility]

### Return type

[**PostCharactersCharacterIdCspaCreated**](PostCharactersCharacterIdCspaCreated.md)

### Authorization

[evesso](../README.md#evesso)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

