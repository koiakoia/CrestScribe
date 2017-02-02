# ESI.Api.KillmailsApi

All URIs are relative to *https://esi.tech.ccp.is/dev*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetCharactersCharacterIdKillmailsRecent**](KillmailsApi.md#getcharacterscharacteridkillmailsrecent) | **GET** /characters/{character_id}/killmails/recent/ | List kills and losses
[**GetKillmailsKillmailIdKillmailHash**](KillmailsApi.md#getkillmailskillmailidkillmailhash) | **GET** /killmails/{killmail_id}/{killmail_hash}/ | Get a single killmail


<a name="getcharacterscharacteridkillmailsrecent"></a>
# **GetCharactersCharacterIdKillmailsRecent**
> List<GetCharactersCharacterIdKillmailsRecent200Ok> GetCharactersCharacterIdKillmailsRecent (int? characterId, int? maxCount = null, int? maxKillId = null, string datasource = null)

List kills and losses

Return a list of character's recent kills and losses  - --  Alternate route: `/v1/characters/{character_id}/killmails/recent/`  Alternate route: `/legacy/characters/{character_id}/killmails/recent/`  Alternate route: `/latest/characters/{character_id}/killmails/recent/`   - --  This route is cached for up to 120 seconds

### Example
```csharp
using System;
using System.Diagnostics;
using ESI.Api;
using ESI.Client;
using ESI.Model;

namespace Example
{
    public class GetCharactersCharacterIdKillmailsRecentExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: evesso
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new KillmailsApi();
            var characterId = 56;  // int? | An EVE character ID
            var maxCount = 56;  // int? | How many killmails to return at maximum (optional)  (default to 50)
            var maxKillId = 56;  // int? | Only return killmails with ID smaller than this.  (optional) 
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)

            try
            {
                // List kills and losses
                List&lt;GetCharactersCharacterIdKillmailsRecent200Ok&gt; result = apiInstance.GetCharactersCharacterIdKillmailsRecent(characterId, maxCount, maxKillId, datasource);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling KillmailsApi.GetCharactersCharacterIdKillmailsRecent: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **characterId** | **int?**| An EVE character ID | 
 **maxCount** | **int?**| How many killmails to return at maximum | [optional] [default to 50]
 **maxKillId** | **int?**| Only return killmails with ID smaller than this.  | [optional] 
 **datasource** | **string**| The server name you would like data from | [optional] [default to tranquility]

### Return type

[**List<GetCharactersCharacterIdKillmailsRecent200Ok>**](GetCharactersCharacterIdKillmailsRecent200Ok.md)

### Authorization

[evesso](../README.md#evesso)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getkillmailskillmailidkillmailhash"></a>
# **GetKillmailsKillmailIdKillmailHash**
> GetKillmailsKillmailIdKillmailHashOk GetKillmailsKillmailIdKillmailHash (int? killmailId, string killmailHash, string datasource = null)

Get a single killmail

Return a single killmail from its ID and hash  - --  Alternate route: `/v1/killmails/{killmail_id}/{killmail_hash}/`  Alternate route: `/legacy/killmails/{killmail_id}/{killmail_hash}/`  Alternate route: `/latest/killmails/{killmail_id}/{killmail_hash}/`   - --  This route is cached for up to 3600 seconds

### Example
```csharp
using System;
using System.Diagnostics;
using ESI.Api;
using ESI.Client;
using ESI.Model;

namespace Example
{
    public class GetKillmailsKillmailIdKillmailHashExample
    {
        public void main()
        {
            
            var apiInstance = new KillmailsApi();
            var killmailId = 56;  // int? | The killmail ID to be queried
            var killmailHash = killmailHash_example;  // string | The killmail hash for verification
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)

            try
            {
                // Get a single killmail
                GetKillmailsKillmailIdKillmailHashOk result = apiInstance.GetKillmailsKillmailIdKillmailHash(killmailId, killmailHash, datasource);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling KillmailsApi.GetKillmailsKillmailIdKillmailHash: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **killmailId** | **int?**| The killmail ID to be queried | 
 **killmailHash** | **string**| The killmail hash for verification | 
 **datasource** | **string**| The server name you would like data from | [optional] [default to tranquility]

### Return type

[**GetKillmailsKillmailIdKillmailHashOk**](GetKillmailsKillmailIdKillmailHashOk.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

