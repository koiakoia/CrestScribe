# ESI.Api.SkillsApi

All URIs are relative to *https://esi.tech.ccp.is/dev*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetCharactersCharacterIdSkillqueue**](SkillsApi.md#getcharacterscharacteridskillqueue) | **GET** /characters/{character_id}/skillqueue/ | Get character&#39;s skill queue
[**GetCharactersCharacterIdSkills**](SkillsApi.md#getcharacterscharacteridskills) | **GET** /characters/{character_id}/skills/ | Get character skills


<a name="getcharacterscharacteridskillqueue"></a>
# **GetCharactersCharacterIdSkillqueue**
> List<GetCharactersCharacterIdSkillqueue200Ok> GetCharactersCharacterIdSkillqueue (int? characterId, string datasource = null)

Get character's skill queue

List the configured skill queue for the given character  - --  Alternate route: `/v2/characters/{character_id}/skillqueue/`  Alternate route: `/legacy/characters/{character_id}/skillqueue/`  Alternate route: `/latest/characters/{character_id}/skillqueue/`   - --  This route is cached for up to 120 seconds

### Example
```csharp
using System;
using System.Diagnostics;
using ESI.Api;
using ESI.Client;
using ESI.Model;

namespace Example
{
    public class GetCharactersCharacterIdSkillqueueExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: evesso
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SkillsApi();
            var characterId = 56;  // int? | Character id of the target character
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)

            try
            {
                // Get character's skill queue
                List&lt;GetCharactersCharacterIdSkillqueue200Ok&gt; result = apiInstance.GetCharactersCharacterIdSkillqueue(characterId, datasource);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SkillsApi.GetCharactersCharacterIdSkillqueue: " + e.Message );
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

[**List<GetCharactersCharacterIdSkillqueue200Ok>**](GetCharactersCharacterIdSkillqueue200Ok.md)

### Authorization

[evesso](../README.md#evesso)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcharacterscharacteridskills"></a>
# **GetCharactersCharacterIdSkills**
> GetCharactersCharacterIdSkillsOk GetCharactersCharacterIdSkills (int? characterId, string datasource = null)

Get character skills

List all trained skills for the given character  - --  Alternate route: `/v3/characters/{character_id}/skills/`  Alternate route: `/latest/characters/{character_id}/skills/`   - --  This route is cached for up to 120 seconds

### Example
```csharp
using System;
using System.Diagnostics;
using ESI.Api;
using ESI.Client;
using ESI.Model;

namespace Example
{
    public class GetCharactersCharacterIdSkillsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: evesso
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SkillsApi();
            var characterId = 56;  // int? | An EVE character ID
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)

            try
            {
                // Get character skills
                GetCharactersCharacterIdSkillsOk result = apiInstance.GetCharactersCharacterIdSkills(characterId, datasource);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SkillsApi.GetCharactersCharacterIdSkills: " + e.Message );
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

[**GetCharactersCharacterIdSkillsOk**](GetCharactersCharacterIdSkillsOk.md)

### Authorization

[evesso](../README.md#evesso)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

