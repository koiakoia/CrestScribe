# ESI.Api.AllianceApi

All URIs are relative to *https://esi.tech.ccp.is/dev*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetAlliances**](AllianceApi.md#getalliances) | **GET** /alliances/ | List all alliances
[**GetAlliancesAllianceId**](AllianceApi.md#getalliancesallianceid) | **GET** /alliances/{alliance_id}/ | Get alliance information
[**GetAlliancesAllianceIdCorporations**](AllianceApi.md#getalliancesallianceidcorporations) | **GET** /alliances/{alliance_id}/corporations/ | List alliance&#39;s corporations
[**GetAlliancesAllianceIdIcons**](AllianceApi.md#getalliancesallianceidicons) | **GET** /alliances/{alliance_id}/icons/ | Get alliance icon
[**GetAlliancesNames**](AllianceApi.md#getalliancesnames) | **GET** /alliances/names/ | Get alliance names


<a name="getalliances"></a>
# **GetAlliances**
> List<int?> GetAlliances (string datasource = null)

List all alliances

List all active player alliances  - --  Alternate route: `/v1/alliances/`  Alternate route: `/latest/alliances/`  Alternate route: `/legacy/alliances/`   - --  This route is cached for up to 3600 seconds

### Example
```csharp
using System;
using System.Diagnostics;
using ESI.Api;
using ESI.Client;
using ESI.Model;

namespace Example
{
    public class GetAlliancesExample
    {
        public void main()
        {
            
            var apiInstance = new AllianceApi();
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)

            try
            {
                // List all alliances
                List&lt;int?&gt; result = apiInstance.GetAlliances(datasource);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AllianceApi.GetAlliances: " + e.Message );
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

**List<int?>**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getalliancesallianceid"></a>
# **GetAlliancesAllianceId**
> GetAlliancesAllianceIdOk GetAlliancesAllianceId (int? allianceId, string datasource = null)

Get alliance information

Public information about an alliance  - --  Alternate route: `/v1/alliances/{alliance_id}/`   - --  This route is cached for up to 3600 seconds

### Example
```csharp
using System;
using System.Diagnostics;
using ESI.Api;
using ESI.Client;
using ESI.Model;

namespace Example
{
    public class GetAlliancesAllianceIdExample
    {
        public void main()
        {
            
            var apiInstance = new AllianceApi();
            var allianceId = 56;  // int? | An Eve alliance ID
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)

            try
            {
                // Get alliance information
                GetAlliancesAllianceIdOk result = apiInstance.GetAlliancesAllianceId(allianceId, datasource);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AllianceApi.GetAlliancesAllianceId: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **allianceId** | **int?**| An Eve alliance ID | 
 **datasource** | **string**| The server name you would like data from | [optional] [default to tranquility]

### Return type

[**GetAlliancesAllianceIdOk**](GetAlliancesAllianceIdOk.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getalliancesallianceidcorporations"></a>
# **GetAlliancesAllianceIdCorporations**
> List<int?> GetAlliancesAllianceIdCorporations (int? allianceId, string datasource = null)

List alliance's corporations

List all current member corporations of an alliance  - --  Alternate route: `/v1/alliances/{alliance_id}/corporations/`  Alternate route: `/latest/alliances/{alliance_id}/corporations/`  Alternate route: `/legacy/alliances/{alliance_id}/corporations/`   - --  This route is cached for up to 3600 seconds

### Example
```csharp
using System;
using System.Diagnostics;
using ESI.Api;
using ESI.Client;
using ESI.Model;

namespace Example
{
    public class GetAlliancesAllianceIdCorporationsExample
    {
        public void main()
        {
            
            var apiInstance = new AllianceApi();
            var allianceId = 56;  // int? | An EVE alliance ID
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)

            try
            {
                // List alliance's corporations
                List&lt;int?&gt; result = apiInstance.GetAlliancesAllianceIdCorporations(allianceId, datasource);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AllianceApi.GetAlliancesAllianceIdCorporations: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **allianceId** | **int?**| An EVE alliance ID | 
 **datasource** | **string**| The server name you would like data from | [optional] [default to tranquility]

### Return type

**List<int?>**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getalliancesallianceidicons"></a>
# **GetAlliancesAllianceIdIcons**
> GetAlliancesAllianceIdIconsOk GetAlliancesAllianceIdIcons (int? allianceId, string datasource = null)

Get alliance icon

Get the icon urls for a alliance  - --  Alternate route: `/v1/alliances/{alliance_id}/icons/`  Alternate route: `/legacy/alliances/{alliance_id}/icons/`  Alternate route: `/latest/alliances/{alliance_id}/icons/`   - --  This route is cached for up to 3600 seconds

### Example
```csharp
using System;
using System.Diagnostics;
using ESI.Api;
using ESI.Client;
using ESI.Model;

namespace Example
{
    public class GetAlliancesAllianceIdIconsExample
    {
        public void main()
        {
            
            var apiInstance = new AllianceApi();
            var allianceId = 56;  // int? | An EVE alliance ID
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)

            try
            {
                // Get alliance icon
                GetAlliancesAllianceIdIconsOk result = apiInstance.GetAlliancesAllianceIdIcons(allianceId, datasource);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AllianceApi.GetAlliancesAllianceIdIcons: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **allianceId** | **int?**| An EVE alliance ID | 
 **datasource** | **string**| The server name you would like data from | [optional] [default to tranquility]

### Return type

[**GetAlliancesAllianceIdIconsOk**](GetAlliancesAllianceIdIconsOk.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getalliancesnames"></a>
# **GetAlliancesNames**
> List<GetAlliancesNames200Ok> GetAlliancesNames (List<long?> allianceIds, string datasource = null)

Get alliance names

Resolve a set of alliance IDs to alliance names  - --  Alternate route: `/v1/alliances/names/`  Alternate route: `/legacy/alliances/names/`  Alternate route: `/latest/alliances/names/`   - --  This route is cached for up to 3600 seconds

### Example
```csharp
using System;
using System.Diagnostics;
using ESI.Api;
using ESI.Client;
using ESI.Model;

namespace Example
{
    public class GetAlliancesNamesExample
    {
        public void main()
        {
            
            var apiInstance = new AllianceApi();
            var allianceIds = new List<long?>(); // List<long?> | A comma separated list of alliance IDs
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)

            try
            {
                // Get alliance names
                List&lt;GetAlliancesNames200Ok&gt; result = apiInstance.GetAlliancesNames(allianceIds, datasource);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AllianceApi.GetAlliancesNames: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **allianceIds** | [**List&lt;long?&gt;**](long?.md)| A comma separated list of alliance IDs | 
 **datasource** | **string**| The server name you would like data from | [optional] [default to tranquility]

### Return type

[**List<GetAlliancesNames200Ok>**](GetAlliancesNames200Ok.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

