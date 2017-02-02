# ESI.Api.CorporationApi

All URIs are relative to *https://esi.tech.ccp.is/dev*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetCorporationsCorporationId**](CorporationApi.md#getcorporationscorporationid) | **GET** /corporations/{corporation_id}/ | Get corporation information
[**GetCorporationsCorporationIdAlliancehistory**](CorporationApi.md#getcorporationscorporationidalliancehistory) | **GET** /corporations/{corporation_id}/alliancehistory/ | Get alliance history
[**GetCorporationsCorporationIdIcons**](CorporationApi.md#getcorporationscorporationidicons) | **GET** /corporations/{corporation_id}/icons/ | Get corporation icon
[**GetCorporationsCorporationIdMembers**](CorporationApi.md#getcorporationscorporationidmembers) | **GET** /corporations/{corporation_id}/members/ | Get corporation members
[**GetCorporationsCorporationIdRoles**](CorporationApi.md#getcorporationscorporationidroles) | **GET** /corporations/{corporation_id}/roles/ | Get corporation member roles
[**GetCorporationsNames**](CorporationApi.md#getcorporationsnames) | **GET** /corporations/names/ | Get corporation names


<a name="getcorporationscorporationid"></a>
# **GetCorporationsCorporationId**
> GetCorporationsCorporationIdOk GetCorporationsCorporationId (int? corporationId, string datasource = null)

Get corporation information

Public information about a corporation  - --  Alternate route: `/v3/corporations/{corporation_id}/`   - --  This route is cached for up to 3600 seconds

### Example
```csharp
using System;
using System.Diagnostics;
using ESI.Api;
using ESI.Client;
using ESI.Model;

namespace Example
{
    public class GetCorporationsCorporationIdExample
    {
        public void main()
        {
            
            var apiInstance = new CorporationApi();
            var corporationId = 56;  // int? | An Eve corporation ID
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)

            try
            {
                // Get corporation information
                GetCorporationsCorporationIdOk result = apiInstance.GetCorporationsCorporationId(corporationId, datasource);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CorporationApi.GetCorporationsCorporationId: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **corporationId** | **int?**| An Eve corporation ID | 
 **datasource** | **string**| The server name you would like data from | [optional] [default to tranquility]

### Return type

[**GetCorporationsCorporationIdOk**](GetCorporationsCorporationIdOk.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcorporationscorporationidalliancehistory"></a>
# **GetCorporationsCorporationIdAlliancehistory**
> List<GetCorporationsCorporationIdAlliancehistory200Ok> GetCorporationsCorporationIdAlliancehistory (int? corporationId, string datasource = null)

Get alliance history

Get a list of all the alliances a corporation has been a member of  - --  Alternate route: `/v1/corporations/{corporation_id}/alliancehistory/`  Alternate route: `/legacy/corporations/{corporation_id}/alliancehistory/`  Alternate route: `/latest/corporations/{corporation_id}/alliancehistory/`   - --  This route is cached for up to 3600 seconds

### Example
```csharp
using System;
using System.Diagnostics;
using ESI.Api;
using ESI.Client;
using ESI.Model;

namespace Example
{
    public class GetCorporationsCorporationIdAlliancehistoryExample
    {
        public void main()
        {
            
            var apiInstance = new CorporationApi();
            var corporationId = 56;  // int? | An EVE corporation ID
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)

            try
            {
                // Get alliance history
                List&lt;GetCorporationsCorporationIdAlliancehistory200Ok&gt; result = apiInstance.GetCorporationsCorporationIdAlliancehistory(corporationId, datasource);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CorporationApi.GetCorporationsCorporationIdAlliancehistory: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **corporationId** | **int?**| An EVE corporation ID | 
 **datasource** | **string**| The server name you would like data from | [optional] [default to tranquility]

### Return type

[**List<GetCorporationsCorporationIdAlliancehistory200Ok>**](GetCorporationsCorporationIdAlliancehistory200Ok.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcorporationscorporationidicons"></a>
# **GetCorporationsCorporationIdIcons**
> GetCorporationsCorporationIdIconsOk GetCorporationsCorporationIdIcons (int? corporationId, string datasource = null)

Get corporation icon

Get the icon urls for a corporation  - --  Alternate route: `/v1/corporations/{corporation_id}/icons/`  Alternate route: `/legacy/corporations/{corporation_id}/icons/`  Alternate route: `/latest/corporations/{corporation_id}/icons/`   - --  This route is cached for up to 3600 seconds

### Example
```csharp
using System;
using System.Diagnostics;
using ESI.Api;
using ESI.Client;
using ESI.Model;

namespace Example
{
    public class GetCorporationsCorporationIdIconsExample
    {
        public void main()
        {
            
            var apiInstance = new CorporationApi();
            var corporationId = 56;  // int? | An EVE corporation ID
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)

            try
            {
                // Get corporation icon
                GetCorporationsCorporationIdIconsOk result = apiInstance.GetCorporationsCorporationIdIcons(corporationId, datasource);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CorporationApi.GetCorporationsCorporationIdIcons: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **corporationId** | **int?**| An EVE corporation ID | 
 **datasource** | **string**| The server name you would like data from | [optional] [default to tranquility]

### Return type

[**GetCorporationsCorporationIdIconsOk**](GetCorporationsCorporationIdIconsOk.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcorporationscorporationidmembers"></a>
# **GetCorporationsCorporationIdMembers**
> List<GetCorporationsCorporationIdMembers200Ok> GetCorporationsCorporationIdMembers (int? corporationId, string datasource = null)

Get corporation members

Read the current list of members if the calling character is a member.  - --  Alternate route: `/v2/corporations/{corporation_id}/members/`  Alternate route: `/legacy/corporations/{corporation_id}/members/`  Alternate route: `/latest/corporations/{corporation_id}/members/`   - --  This route is cached for up to 3600 seconds

### Example
```csharp
using System;
using System.Diagnostics;
using ESI.Api;
using ESI.Client;
using ESI.Model;

namespace Example
{
    public class GetCorporationsCorporationIdMembersExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: evesso
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CorporationApi();
            var corporationId = 56;  // int? | A corporation ID
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)

            try
            {
                // Get corporation members
                List&lt;GetCorporationsCorporationIdMembers200Ok&gt; result = apiInstance.GetCorporationsCorporationIdMembers(corporationId, datasource);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CorporationApi.GetCorporationsCorporationIdMembers: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **corporationId** | **int?**| A corporation ID | 
 **datasource** | **string**| The server name you would like data from | [optional] [default to tranquility]

### Return type

[**List<GetCorporationsCorporationIdMembers200Ok>**](GetCorporationsCorporationIdMembers200Ok.md)

### Authorization

[evesso](../README.md#evesso)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcorporationscorporationidroles"></a>
# **GetCorporationsCorporationIdRoles**
> List<GetCorporationsCorporationIdRoles200Ok> GetCorporationsCorporationIdRoles (int? corporationId, string datasource = null)

Get corporation member roles

Return the roles of all members if the character has the personnel manager role or any grantable role.  - --  Alternate route: `/v1/corporations/{corporation_id}/roles/`  Alternate route: `/legacy/corporations/{corporation_id}/roles/`  Alternate route: `/latest/corporations/{corporation_id}/roles/`   - --  This route is cached for up to 3600 seconds

### Example
```csharp
using System;
using System.Diagnostics;
using ESI.Api;
using ESI.Client;
using ESI.Model;

namespace Example
{
    public class GetCorporationsCorporationIdRolesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: evesso
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CorporationApi();
            var corporationId = 56;  // int? | A corporation ID
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)

            try
            {
                // Get corporation member roles
                List&lt;GetCorporationsCorporationIdRoles200Ok&gt; result = apiInstance.GetCorporationsCorporationIdRoles(corporationId, datasource);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CorporationApi.GetCorporationsCorporationIdRoles: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **corporationId** | **int?**| A corporation ID | 
 **datasource** | **string**| The server name you would like data from | [optional] [default to tranquility]

### Return type

[**List<GetCorporationsCorporationIdRoles200Ok>**](GetCorporationsCorporationIdRoles200Ok.md)

### Authorization

[evesso](../README.md#evesso)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcorporationsnames"></a>
# **GetCorporationsNames**
> List<GetCorporationsNames200Ok> GetCorporationsNames (List<long?> corporationIds, string datasource = null)

Get corporation names

Resolve a set of corporation IDs to corporation names  - --  Alternate route: `/v1/corporations/names/`  Alternate route: `/legacy/corporations/names/`  Alternate route: `/latest/corporations/names/`   - --  This route is cached for up to 3600 seconds

### Example
```csharp
using System;
using System.Diagnostics;
using ESI.Api;
using ESI.Client;
using ESI.Model;

namespace Example
{
    public class GetCorporationsNamesExample
    {
        public void main()
        {
            
            var apiInstance = new CorporationApi();
            var corporationIds = new List<long?>(); // List<long?> | A comma separated list of corporation IDs
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)

            try
            {
                // Get corporation names
                List&lt;GetCorporationsNames200Ok&gt; result = apiInstance.GetCorporationsNames(corporationIds, datasource);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CorporationApi.GetCorporationsNames: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **corporationIds** | [**List&lt;long?&gt;**](long?.md)| A comma separated list of corporation IDs | 
 **datasource** | **string**| The server name you would like data from | [optional] [default to tranquility]

### Return type

[**List<GetCorporationsNames200Ok>**](GetCorporationsNames200Ok.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

