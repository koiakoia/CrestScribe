# ESI.Api.IncursionsApi

All URIs are relative to *https://esi.tech.ccp.is/dev*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetIncursions**](IncursionsApi.md#getincursions) | **GET** /incursions/ | List incursions


<a name="getincursions"></a>
# **GetIncursions**
> List<GetIncursions200Ok> GetIncursions (string datasource = null)

List incursions

Return a list of current incursions  - --  Alternate route: `/v1/incursions/`  Alternate route: `/legacy/incursions/`  Alternate route: `/latest/incursions/`   - --  This route is cached for up to 300 seconds

### Example
```csharp
using System;
using System.Diagnostics;
using ESI.Api;
using ESI.Client;
using ESI.Model;

namespace Example
{
    public class GetIncursionsExample
    {
        public void main()
        {
            
            var apiInstance = new IncursionsApi();
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)

            try
            {
                // List incursions
                List&lt;GetIncursions200Ok&gt; result = apiInstance.GetIncursions(datasource);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IncursionsApi.GetIncursions: " + e.Message );
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

[**List<GetIncursions200Ok>**](GetIncursions200Ok.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

