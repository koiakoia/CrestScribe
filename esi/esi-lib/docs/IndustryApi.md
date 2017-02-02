# ESI.Api.IndustryApi

All URIs are relative to *https://esi.tech.ccp.is/dev*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetIndustryFacilities**](IndustryApi.md#getindustryfacilities) | **GET** /industry/facilities/ | List industry facilities
[**GetIndustrySystems**](IndustryApi.md#getindustrysystems) | **GET** /industry/systems/ | List solar system cost indices


<a name="getindustryfacilities"></a>
# **GetIndustryFacilities**
> List<GetIndustryFacilities200Ok> GetIndustryFacilities (string datasource = null)

List industry facilities

Return a list of industry facilities  - --  Alternate route: `/v1/industry/facilities/`  Alternate route: `/legacy/industry/facilities/`  Alternate route: `/latest/industry/facilities/`   - --  This route is cached for up to 3600 seconds

### Example
```csharp
using System;
using System.Diagnostics;
using ESI.Api;
using ESI.Client;
using ESI.Model;

namespace Example
{
    public class GetIndustryFacilitiesExample
    {
        public void main()
        {
            
            var apiInstance = new IndustryApi();
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)

            try
            {
                // List industry facilities
                List&lt;GetIndustryFacilities200Ok&gt; result = apiInstance.GetIndustryFacilities(datasource);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IndustryApi.GetIndustryFacilities: " + e.Message );
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

[**List<GetIndustryFacilities200Ok>**](GetIndustryFacilities200Ok.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getindustrysystems"></a>
# **GetIndustrySystems**
> List<GetIndustrySystems200Ok> GetIndustrySystems (string datasource = null)

List solar system cost indices

Return cost indices for solar systems  - --  Alternate route: `/v1/industry/systems/`  Alternate route: `/legacy/industry/systems/`  Alternate route: `/latest/industry/systems/`   - --  This route is cached for up to 3600 seconds

### Example
```csharp
using System;
using System.Diagnostics;
using ESI.Api;
using ESI.Client;
using ESI.Model;

namespace Example
{
    public class GetIndustrySystemsExample
    {
        public void main()
        {
            
            var apiInstance = new IndustryApi();
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)

            try
            {
                // List solar system cost indices
                List&lt;GetIndustrySystems200Ok&gt; result = apiInstance.GetIndustrySystems(datasource);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IndustryApi.GetIndustrySystems: " + e.Message );
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

[**List<GetIndustrySystems200Ok>**](GetIndustrySystems200Ok.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

