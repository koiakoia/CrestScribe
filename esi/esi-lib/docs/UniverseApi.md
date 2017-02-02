# ESI.Api.UniverseApi

All URIs are relative to *https://esi.tech.ccp.is/dev*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetUniverseCategories**](UniverseApi.md#getuniversecategories) | **GET** /universe/categories/ | Get item categories
[**GetUniverseCategoriesCategoryId**](UniverseApi.md#getuniversecategoriescategoryid) | **GET** /universe/categories/{category_id}/ | Get item category information
[**GetUniverseGroups**](UniverseApi.md#getuniversegroups) | **GET** /universe/groups/ | Get item groups
[**GetUniverseGroupsGroupId**](UniverseApi.md#getuniversegroupsgroupid) | **GET** /universe/groups/{group_id}/ | Get item group information
[**GetUniverseRaces**](UniverseApi.md#getuniverseraces) | **GET** /universe/races/ | Get character races
[**GetUniverseStationsStationId**](UniverseApi.md#getuniversestationsstationid) | **GET** /universe/stations/{station_id}/ | Get station information
[**GetUniverseStructures**](UniverseApi.md#getuniversestructures) | **GET** /universe/structures/ | List all public structures
[**GetUniverseStructuresStructureId**](UniverseApi.md#getuniversestructuresstructureid) | **GET** /universe/structures/{structure_id}/ | Get structure information
[**GetUniverseSystemsSystemId**](UniverseApi.md#getuniversesystemssystemid) | **GET** /universe/systems/{system_id}/ | Get solar system information
[**GetUniverseTypes**](UniverseApi.md#getuniversetypes) | **GET** /universe/types/ | Get types
[**GetUniverseTypesTypeId**](UniverseApi.md#getuniversetypestypeid) | **GET** /universe/types/{type_id}/ | Get type information
[**PostUniverseNames**](UniverseApi.md#postuniversenames) | **POST** /universe/names/ | Get names and categories for a set of ID&#39;s


<a name="getuniversecategories"></a>
# **GetUniverseCategories**
> List<int?> GetUniverseCategories (string datasource = null)

Get item categories

Get a list of item categories  - --  Alternate route: `/v1/universe/categories/`  Alternate route: `/legacy/universe/categories/`  Alternate route: `/latest/universe/categories/`   - --  This route is cached for up to 3600 seconds

### Example
```csharp
using System;
using System.Diagnostics;
using ESI.Api;
using ESI.Client;
using ESI.Model;

namespace Example
{
    public class GetUniverseCategoriesExample
    {
        public void main()
        {
            
            var apiInstance = new UniverseApi();
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)

            try
            {
                // Get item categories
                List&lt;int?&gt; result = apiInstance.GetUniverseCategories(datasource);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UniverseApi.GetUniverseCategories: " + e.Message );
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

<a name="getuniversecategoriescategoryid"></a>
# **GetUniverseCategoriesCategoryId**
> GetUniverseCategoriesCategoryIdOk GetUniverseCategoriesCategoryId (int? categoryId, string language = null, string datasource = null)

Get item category information

Get information of an item category  - --  Alternate route: `/v1/universe/categories/{category_id}/`  Alternate route: `/legacy/universe/categories/{category_id}/`  Alternate route: `/latest/universe/categories/{category_id}/`   - --  This route is cached for up to 3600 seconds

### Example
```csharp
using System;
using System.Diagnostics;
using ESI.Api;
using ESI.Client;
using ESI.Model;

namespace Example
{
    public class GetUniverseCategoriesCategoryIdExample
    {
        public void main()
        {
            
            var apiInstance = new UniverseApi();
            var categoryId = 56;  // int? | An Eve item category ID
            var language = language_example;  // string | Language to use in the response (optional)  (default to en-us)
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)

            try
            {
                // Get item category information
                GetUniverseCategoriesCategoryIdOk result = apiInstance.GetUniverseCategoriesCategoryId(categoryId, language, datasource);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UniverseApi.GetUniverseCategoriesCategoryId: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **categoryId** | **int?**| An Eve item category ID | 
 **language** | **string**| Language to use in the response | [optional] [default to en-us]
 **datasource** | **string**| The server name you would like data from | [optional] [default to tranquility]

### Return type

[**GetUniverseCategoriesCategoryIdOk**](GetUniverseCategoriesCategoryIdOk.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getuniversegroups"></a>
# **GetUniverseGroups**
> List<int?> GetUniverseGroups (int? page = null, string datasource = null)

Get item groups

Get a list of item groups  - --  Alternate route: `/v1/universe/groups/`  Alternate route: `/legacy/universe/groups/`  Alternate route: `/latest/universe/groups/`   - --  This route is cached for up to 3600 seconds

### Example
```csharp
using System;
using System.Diagnostics;
using ESI.Api;
using ESI.Client;
using ESI.Model;

namespace Example
{
    public class GetUniverseGroupsExample
    {
        public void main()
        {
            
            var apiInstance = new UniverseApi();
            var page = 56;  // int? | Which page to query (optional) 
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)

            try
            {
                // Get item groups
                List&lt;int?&gt; result = apiInstance.GetUniverseGroups(page, datasource);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UniverseApi.GetUniverseGroups: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **page** | **int?**| Which page to query | [optional] 
 **datasource** | **string**| The server name you would like data from | [optional] [default to tranquility]

### Return type

**List<int?>**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getuniversegroupsgroupid"></a>
# **GetUniverseGroupsGroupId**
> GetUniverseGroupsGroupIdOk GetUniverseGroupsGroupId (int? groupId, string language = null, string datasource = null)

Get item group information

Get information on an item group  - --  Alternate route: `/v1/universe/groups/{group_id}/`  Alternate route: `/legacy/universe/groups/{group_id}/`  Alternate route: `/latest/universe/groups/{group_id}/`   - --  This route is cached for up to 3600 seconds

### Example
```csharp
using System;
using System.Diagnostics;
using ESI.Api;
using ESI.Client;
using ESI.Model;

namespace Example
{
    public class GetUniverseGroupsGroupIdExample
    {
        public void main()
        {
            
            var apiInstance = new UniverseApi();
            var groupId = 56;  // int? | An Eve item group ID
            var language = language_example;  // string | Language to use in the response (optional)  (default to en-us)
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)

            try
            {
                // Get item group information
                GetUniverseGroupsGroupIdOk result = apiInstance.GetUniverseGroupsGroupId(groupId, language, datasource);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UniverseApi.GetUniverseGroupsGroupId: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **groupId** | **int?**| An Eve item group ID | 
 **language** | **string**| Language to use in the response | [optional] [default to en-us]
 **datasource** | **string**| The server name you would like data from | [optional] [default to tranquility]

### Return type

[**GetUniverseGroupsGroupIdOk**](GetUniverseGroupsGroupIdOk.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getuniverseraces"></a>
# **GetUniverseRaces**
> List<GetUniverseRaces200Ok> GetUniverseRaces (string language = null, string datasource = null)

Get character races

Get a list of character races  - --  Alternate route: `/v1/universe/races/`  Alternate route: `/legacy/universe/races/`  Alternate route: `/latest/universe/races/`   - --  This route is cached for up to 3600 seconds

### Example
```csharp
using System;
using System.Diagnostics;
using ESI.Api;
using ESI.Client;
using ESI.Model;

namespace Example
{
    public class GetUniverseRacesExample
    {
        public void main()
        {
            
            var apiInstance = new UniverseApi();
            var language = language_example;  // string | Language to use in the response (optional)  (default to en-us)
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)

            try
            {
                // Get character races
                List&lt;GetUniverseRaces200Ok&gt; result = apiInstance.GetUniverseRaces(language, datasource);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UniverseApi.GetUniverseRaces: " + e.Message );
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

[**List<GetUniverseRaces200Ok>**](GetUniverseRaces200Ok.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getuniversestationsstationid"></a>
# **GetUniverseStationsStationId**
> GetUniverseStationsStationIdOk GetUniverseStationsStationId (int? stationId, string datasource = null)

Get station information

Public information on stations  - --  Alternate route: `/v1/universe/stations/{station_id}/`  Alternate route: `/legacy/universe/stations/{station_id}/`  Alternate route: `/latest/universe/stations/{station_id}/`   - --  This route is cached for up to 3600 seconds

### Example
```csharp
using System;
using System.Diagnostics;
using ESI.Api;
using ESI.Client;
using ESI.Model;

namespace Example
{
    public class GetUniverseStationsStationIdExample
    {
        public void main()
        {
            
            var apiInstance = new UniverseApi();
            var stationId = 56;  // int? | An Eve station ID
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)

            try
            {
                // Get station information
                GetUniverseStationsStationIdOk result = apiInstance.GetUniverseStationsStationId(stationId, datasource);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UniverseApi.GetUniverseStationsStationId: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **stationId** | **int?**| An Eve station ID | 
 **datasource** | **string**| The server name you would like data from | [optional] [default to tranquility]

### Return type

[**GetUniverseStationsStationIdOk**](GetUniverseStationsStationIdOk.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getuniversestructures"></a>
# **GetUniverseStructures**
> List<long?> GetUniverseStructures (string datasource = null)

List all public structures

List all public structures  - --  Alternate route: `/v1/universe/structures/`  Alternate route: `/latest/universe/structures/`  Alternate route: `/legacy/universe/structures/`   - --  This route is cached for up to 3600 seconds

### Example
```csharp
using System;
using System.Diagnostics;
using ESI.Api;
using ESI.Client;
using ESI.Model;

namespace Example
{
    public class GetUniverseStructuresExample
    {
        public void main()
        {
            
            var apiInstance = new UniverseApi();
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)

            try
            {
                // List all public structures
                List&lt;long?&gt; result = apiInstance.GetUniverseStructures(datasource);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UniverseApi.GetUniverseStructures: " + e.Message );
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

**List<long?>**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getuniversestructuresstructureid"></a>
# **GetUniverseStructuresStructureId**
> GetUniverseStructuresStructureIdOk GetUniverseStructuresStructureId (long? structureId, string datasource = null)

Get structure information

Returns information on requested structure, if you are on the ACL. Otherwise, returns \"Forbidden\" for all inputs.  - --  Alternate route: `/v1/universe/structures/{structure_id}/`  Alternate route: `/legacy/universe/structures/{structure_id}/`  Alternate route: `/latest/universe/structures/{structure_id}/` 

### Example
```csharp
using System;
using System.Diagnostics;
using ESI.Api;
using ESI.Client;
using ESI.Model;

namespace Example
{
    public class GetUniverseStructuresStructureIdExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: evesso
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UniverseApi();
            var structureId = 789;  // long? | An Eve structure ID
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)

            try
            {
                // Get structure information
                GetUniverseStructuresStructureIdOk result = apiInstance.GetUniverseStructuresStructureId(structureId, datasource);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UniverseApi.GetUniverseStructuresStructureId: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **structureId** | **long?**| An Eve structure ID | 
 **datasource** | **string**| The server name you would like data from | [optional] [default to tranquility]

### Return type

[**GetUniverseStructuresStructureIdOk**](GetUniverseStructuresStructureIdOk.md)

### Authorization

[evesso](../README.md#evesso)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getuniversesystemssystemid"></a>
# **GetUniverseSystemsSystemId**
> GetUniverseSystemsSystemIdOk GetUniverseSystemsSystemId (int? systemId, string datasource = null)

Get solar system information

Information on solar systems  - --  Alternate route: `/v1/universe/systems/{system_id}/`  Alternate route: `/legacy/universe/systems/{system_id}/`  Alternate route: `/latest/universe/systems/{system_id}/`   - --  This route is cached for up to 3600 seconds

### Example
```csharp
using System;
using System.Diagnostics;
using ESI.Api;
using ESI.Client;
using ESI.Model;

namespace Example
{
    public class GetUniverseSystemsSystemIdExample
    {
        public void main()
        {
            
            var apiInstance = new UniverseApi();
            var systemId = 56;  // int? | An Eve solar system ID
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)

            try
            {
                // Get solar system information
                GetUniverseSystemsSystemIdOk result = apiInstance.GetUniverseSystemsSystemId(systemId, datasource);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UniverseApi.GetUniverseSystemsSystemId: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **systemId** | **int?**| An Eve solar system ID | 
 **datasource** | **string**| The server name you would like data from | [optional] [default to tranquility]

### Return type

[**GetUniverseSystemsSystemIdOk**](GetUniverseSystemsSystemIdOk.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getuniversetypes"></a>
# **GetUniverseTypes**
> List<int?> GetUniverseTypes (int? page = null, string datasource = null)

Get types

Get a list of type ids  - --  Alternate route: `/v1/universe/types/`  Alternate route: `/legacy/universe/types/`  Alternate route: `/latest/universe/types/`   - --  This route is cached for up to 3600 seconds

### Example
```csharp
using System;
using System.Diagnostics;
using ESI.Api;
using ESI.Client;
using ESI.Model;

namespace Example
{
    public class GetUniverseTypesExample
    {
        public void main()
        {
            
            var apiInstance = new UniverseApi();
            var page = 56;  // int? | Which page to query (optional) 
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)

            try
            {
                // Get types
                List&lt;int?&gt; result = apiInstance.GetUniverseTypes(page, datasource);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UniverseApi.GetUniverseTypes: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **page** | **int?**| Which page to query | [optional] 
 **datasource** | **string**| The server name you would like data from | [optional] [default to tranquility]

### Return type

**List<int?>**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getuniversetypestypeid"></a>
# **GetUniverseTypesTypeId**
> GetUniverseTypesTypeIdOk GetUniverseTypesTypeId (int? typeId, string language = null, string datasource = null)

Get type information

Get information on a type  - --  Alternate route: `/v2/universe/types/{type_id}/`  Alternate route: `/latest/universe/types/{type_id}/`   - --  This route is cached for up to 3600 seconds

### Example
```csharp
using System;
using System.Diagnostics;
using ESI.Api;
using ESI.Client;
using ESI.Model;

namespace Example
{
    public class GetUniverseTypesTypeIdExample
    {
        public void main()
        {
            
            var apiInstance = new UniverseApi();
            var typeId = 56;  // int? | An Eve item type ID
            var language = language_example;  // string | Language to use in the response (optional)  (default to en-us)
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)

            try
            {
                // Get type information
                GetUniverseTypesTypeIdOk result = apiInstance.GetUniverseTypesTypeId(typeId, language, datasource);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UniverseApi.GetUniverseTypesTypeId: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **typeId** | **int?**| An Eve item type ID | 
 **language** | **string**| Language to use in the response | [optional] [default to en-us]
 **datasource** | **string**| The server name you would like data from | [optional] [default to tranquility]

### Return type

[**GetUniverseTypesTypeIdOk**](GetUniverseTypesTypeIdOk.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postuniversenames"></a>
# **PostUniverseNames**
> List<PostUniverseNames200Ok> PostUniverseNames (List<int?> ids, string datasource = null)

Get names and categories for a set of ID's

Resolve a set of IDs to names and categories. Supported ID's for resolving are: Characters, Corporations, Alliances, Stations, Solar Systems, Constellations, Regions, Types.  - --  Alternate route: `/v2/universe/names/` 

### Example
```csharp
using System;
using System.Diagnostics;
using ESI.Api;
using ESI.Client;
using ESI.Model;

namespace Example
{
    public class PostUniverseNamesExample
    {
        public void main()
        {
            
            var apiInstance = new UniverseApi();
            var ids = ;  // List<int?> | The ids to resolve
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)

            try
            {
                // Get names and categories for a set of ID's
                List&lt;PostUniverseNames200Ok&gt; result = apiInstance.PostUniverseNames(ids, datasource);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UniverseApi.PostUniverseNames: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ids** | **List&lt;int?&gt;**| The ids to resolve | 
 **datasource** | **string**| The server name you would like data from | [optional] [default to tranquility]

### Return type

[**List<PostUniverseNames200Ok>**](PostUniverseNames200Ok.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

