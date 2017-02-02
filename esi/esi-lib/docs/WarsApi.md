# ESI.Api.WarsApi

All URIs are relative to *https://esi.tech.ccp.is/dev*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetWars**](WarsApi.md#getwars) | **GET** /wars/ | List wars
[**GetWarsWarId**](WarsApi.md#getwarswarid) | **GET** /wars/{war_id}/ | Get war information
[**GetWarsWarIdKillmails**](WarsApi.md#getwarswaridkillmails) | **GET** /wars/{war_id}/killmails/ | List kills for a war


<a name="getwars"></a>
# **GetWars**
> List<int?> GetWars (int? maxWarId = null, string datasource = null)

List wars

Return a list of wars  - --  Alternate route: `/v1/wars/`  Alternate route: `/legacy/wars/`  Alternate route: `/latest/wars/`   - --  This route is cached for up to 3600 seconds

### Example
```csharp
using System;
using System.Diagnostics;
using ESI.Api;
using ESI.Client;
using ESI.Model;

namespace Example
{
    public class GetWarsExample
    {
        public void main()
        {
            
            var apiInstance = new WarsApi();
            var maxWarId = 56;  // int? | Only return wars with ID smaller than this. (optional) 
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)

            try
            {
                // List wars
                List&lt;int?&gt; result = apiInstance.GetWars(maxWarId, datasource);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WarsApi.GetWars: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **maxWarId** | **int?**| Only return wars with ID smaller than this. | [optional] 
 **datasource** | **string**| The server name you would like data from | [optional] [default to tranquility]

### Return type

**List<int?>**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getwarswarid"></a>
# **GetWarsWarId**
> GetWarsWarIdOk GetWarsWarId (int? warId, string datasource = null)

Get war information

Return details about a war  - --  Alternate route: `/v1/wars/{war_id}/`  Alternate route: `/legacy/wars/{war_id}/`  Alternate route: `/latest/wars/{war_id}/`   - --  This route is cached for up to 3600 seconds

### Example
```csharp
using System;
using System.Diagnostics;
using ESI.Api;
using ESI.Client;
using ESI.Model;

namespace Example
{
    public class GetWarsWarIdExample
    {
        public void main()
        {
            
            var apiInstance = new WarsApi();
            var warId = 56;  // int? | ID for a war
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)

            try
            {
                // Get war information
                GetWarsWarIdOk result = apiInstance.GetWarsWarId(warId, datasource);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WarsApi.GetWarsWarId: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **warId** | **int?**| ID for a war | 
 **datasource** | **string**| The server name you would like data from | [optional] [default to tranquility]

### Return type

[**GetWarsWarIdOk**](GetWarsWarIdOk.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getwarswaridkillmails"></a>
# **GetWarsWarIdKillmails**
> List<GetWarsWarIdKillmails200Ok> GetWarsWarIdKillmails (int? warId, int? page = null, string datasource = null)

List kills for a war

Return a list of kills related to a war  - --  Alternate route: `/v1/wars/{war_id}/killmails/`  Alternate route: `/legacy/wars/{war_id}/killmails/`  Alternate route: `/latest/wars/{war_id}/killmails/`   - --  This route is cached for up to 3600 seconds

### Example
```csharp
using System;
using System.Diagnostics;
using ESI.Api;
using ESI.Client;
using ESI.Model;

namespace Example
{
    public class GetWarsWarIdKillmailsExample
    {
        public void main()
        {
            
            var apiInstance = new WarsApi();
            var warId = 56;  // int? | A valid war ID
            var page = 56;  // int? | Which page to query, starting at 1, 2000 killmails per page. (optional)  (default to 1)
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)

            try
            {
                // List kills for a war
                List&lt;GetWarsWarIdKillmails200Ok&gt; result = apiInstance.GetWarsWarIdKillmails(warId, page, datasource);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WarsApi.GetWarsWarIdKillmails: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **warId** | **int?**| A valid war ID | 
 **page** | **int?**| Which page to query, starting at 1, 2000 killmails per page. | [optional] [default to 1]
 **datasource** | **string**| The server name you would like data from | [optional] [default to tranquility]

### Return type

[**List<GetWarsWarIdKillmails200Ok>**](GetWarsWarIdKillmails200Ok.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

