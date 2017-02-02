# ESI.Api.SovereigntyApi

All URIs are relative to *https://esi.tech.ccp.is/dev*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetSovereigntyCampaigns**](SovereigntyApi.md#getsovereigntycampaigns) | **GET** /sovereignty/campaigns/ | List sovereignty campaigns
[**GetSovereigntyStructures**](SovereigntyApi.md#getsovereigntystructures) | **GET** /sovereignty/structures/ | List sovereignty structures


<a name="getsovereigntycampaigns"></a>
# **GetSovereigntyCampaigns**
> List<GetSovereigntyCampaigns200Ok> GetSovereigntyCampaigns (string datasource = null)

List sovereignty campaigns

Shows sovereignty data for campaigns.  - --  Alternate route: `/v1/sovereignty/campaigns/`  Alternate route: `/legacy/sovereignty/campaigns/`  Alternate route: `/latest/sovereignty/campaigns/`   - --  This route is cached for up to 5 seconds

### Example
```csharp
using System;
using System.Diagnostics;
using ESI.Api;
using ESI.Client;
using ESI.Model;

namespace Example
{
    public class GetSovereigntyCampaignsExample
    {
        public void main()
        {
            
            var apiInstance = new SovereigntyApi();
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)

            try
            {
                // List sovereignty campaigns
                List&lt;GetSovereigntyCampaigns200Ok&gt; result = apiInstance.GetSovereigntyCampaigns(datasource);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SovereigntyApi.GetSovereigntyCampaigns: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **datasource** | **string**| The server name you would like data from | [optional] [default to tranquility]

### Return type

[**List<GetSovereigntyCampaigns200Ok>**](GetSovereigntyCampaigns200Ok.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getsovereigntystructures"></a>
# **GetSovereigntyStructures**
> List<GetSovereigntyStructures200Ok> GetSovereigntyStructures (string datasource = null)

List sovereignty structures

Shows sovereignty data for structures.  - --  Alternate route: `/v1/sovereignty/structures/`  Alternate route: `/legacy/sovereignty/structures/`  Alternate route: `/latest/sovereignty/structures/`   - --  This route is cached for up to 120 seconds

### Example
```csharp
using System;
using System.Diagnostics;
using ESI.Api;
using ESI.Client;
using ESI.Model;

namespace Example
{
    public class GetSovereigntyStructuresExample
    {
        public void main()
        {
            
            var apiInstance = new SovereigntyApi();
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)

            try
            {
                // List sovereignty structures
                List&lt;GetSovereigntyStructures200Ok&gt; result = apiInstance.GetSovereigntyStructures(datasource);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SovereigntyApi.GetSovereigntyStructures: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **datasource** | **string**| The server name you would like data from | [optional] [default to tranquility]

### Return type

[**List<GetSovereigntyStructures200Ok>**](GetSovereigntyStructures200Ok.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

