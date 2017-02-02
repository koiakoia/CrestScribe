# ESI.Api.InsuranceApi

All URIs are relative to *https://esi.tech.ccp.is/dev*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetInsurancePrices**](InsuranceApi.md#getinsuranceprices) | **GET** /insurance/prices/ | List insurance levels


<a name="getinsuranceprices"></a>
# **GetInsurancePrices**
> List<GetInsurancePrices200Ok> GetInsurancePrices (string language = null, string datasource = null)

List insurance levels

Return available insurance levels for all ship types  - --  Alternate route: `/v1/insurance/prices/`  Alternate route: `/legacy/insurance/prices/`  Alternate route: `/latest/insurance/prices/`   - --  This route is cached for up to 3600 seconds

### Example
```csharp
using System;
using System.Diagnostics;
using ESI.Api;
using ESI.Client;
using ESI.Model;

namespace Example
{
    public class GetInsurancePricesExample
    {
        public void main()
        {
            
            var apiInstance = new InsuranceApi();
            var language = language_example;  // string | Language to use in the response (optional)  (default to en-us)
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)

            try
            {
                // List insurance levels
                List&lt;GetInsurancePrices200Ok&gt; result = apiInstance.GetInsurancePrices(language, datasource);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InsuranceApi.GetInsurancePrices: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **language** | **string**| Language to use in the response | [optional] [default to en-us]
 **datasource** | **string**| The server name you would like data from | [optional] [default to tranquility]

### Return type

[**List<GetInsurancePrices200Ok>**](GetInsurancePrices200Ok.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

