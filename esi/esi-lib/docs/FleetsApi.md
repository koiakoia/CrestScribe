# ESI.Api.FleetsApi

All URIs are relative to *https://esi.tech.ccp.is/dev*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteFleetsFleetIdMembersMemberId**](FleetsApi.md#deletefleetsfleetidmembersmemberid) | **DELETE** /fleets/{fleet_id}/members/{member_id}/ | Kick fleet member
[**DeleteFleetsFleetIdSquadsSquadId**](FleetsApi.md#deletefleetsfleetidsquadssquadid) | **DELETE** /fleets/{fleet_id}/squads/{squad_id}/ | Delete fleet squad
[**DeleteFleetsFleetIdWingsWingId**](FleetsApi.md#deletefleetsfleetidwingswingid) | **DELETE** /fleets/{fleet_id}/wings/{wing_id}/ | Delete fleet wing
[**GetFleetsFleetId**](FleetsApi.md#getfleetsfleetid) | **GET** /fleets/{fleet_id}/ | Get fleet information
[**GetFleetsFleetIdMembers**](FleetsApi.md#getfleetsfleetidmembers) | **GET** /fleets/{fleet_id}/members/ | Get fleet members
[**GetFleetsFleetIdWings**](FleetsApi.md#getfleetsfleetidwings) | **GET** /fleets/{fleet_id}/wings/ | Get fleet wings
[**PostFleetsFleetIdMembers**](FleetsApi.md#postfleetsfleetidmembers) | **POST** /fleets/{fleet_id}/members/ | Create fleet invitation
[**PostFleetsFleetIdWings**](FleetsApi.md#postfleetsfleetidwings) | **POST** /fleets/{fleet_id}/wings/ | Create fleet wing
[**PostFleetsFleetIdWingsWingIdSquads**](FleetsApi.md#postfleetsfleetidwingswingidsquads) | **POST** /fleets/{fleet_id}/wings/{wing_id}/squads/ | Create fleet squad
[**PutFleetsFleetId**](FleetsApi.md#putfleetsfleetid) | **PUT** /fleets/{fleet_id}/ | Update fleet
[**PutFleetsFleetIdMembersMemberId**](FleetsApi.md#putfleetsfleetidmembersmemberid) | **PUT** /fleets/{fleet_id}/members/{member_id}/ | Move fleet member
[**PutFleetsFleetIdSquadsSquadId**](FleetsApi.md#putfleetsfleetidsquadssquadid) | **PUT** /fleets/{fleet_id}/squads/{squad_id}/ | Rename fleet squad
[**PutFleetsFleetIdWingsWingId**](FleetsApi.md#putfleetsfleetidwingswingid) | **PUT** /fleets/{fleet_id}/wings/{wing_id}/ | Rename fleet wing


<a name="deletefleetsfleetidmembersmemberid"></a>
# **DeleteFleetsFleetIdMembersMemberId**
> void DeleteFleetsFleetIdMembersMemberId (long? fleetId, int? memberId, string datasource = null)

Kick fleet member

Kick a fleet member  - --  Alternate route: `/v1/fleets/{fleet_id}/members/{member_id}/`  Alternate route: `/legacy/fleets/{fleet_id}/members/{member_id}/`  Alternate route: `/latest/fleets/{fleet_id}/members/{member_id}/` 

### Example
```csharp
using System;
using System.Diagnostics;
using ESI.Api;
using ESI.Client;
using ESI.Model;

namespace Example
{
    public class DeleteFleetsFleetIdMembersMemberIdExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: evesso
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new FleetsApi();
            var fleetId = 789;  // long? | ID for a fleet
            var memberId = 56;  // int? | The character ID of a member in this fleet
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)

            try
            {
                // Kick fleet member
                apiInstance.DeleteFleetsFleetIdMembersMemberId(fleetId, memberId, datasource);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FleetsApi.DeleteFleetsFleetIdMembersMemberId: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **fleetId** | **long?**| ID for a fleet | 
 **memberId** | **int?**| The character ID of a member in this fleet | 
 **datasource** | **string**| The server name you would like data from | [optional] [default to tranquility]

### Return type

void (empty response body)

### Authorization

[evesso](../README.md#evesso)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletefleetsfleetidsquadssquadid"></a>
# **DeleteFleetsFleetIdSquadsSquadId**
> void DeleteFleetsFleetIdSquadsSquadId (long? fleetId, long? squadId, string datasource = null)

Delete fleet squad

Delete a fleet squad, only empty squads can be deleted  - --  Alternate route: `/v1/fleets/{fleet_id}/squads/{squad_id}/`  Alternate route: `/legacy/fleets/{fleet_id}/squads/{squad_id}/`  Alternate route: `/latest/fleets/{fleet_id}/squads/{squad_id}/` 

### Example
```csharp
using System;
using System.Diagnostics;
using ESI.Api;
using ESI.Client;
using ESI.Model;

namespace Example
{
    public class DeleteFleetsFleetIdSquadsSquadIdExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: evesso
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new FleetsApi();
            var fleetId = 789;  // long? | ID for a fleet
            var squadId = 789;  // long? | The squad to delete
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)

            try
            {
                // Delete fleet squad
                apiInstance.DeleteFleetsFleetIdSquadsSquadId(fleetId, squadId, datasource);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FleetsApi.DeleteFleetsFleetIdSquadsSquadId: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **fleetId** | **long?**| ID for a fleet | 
 **squadId** | **long?**| The squad to delete | 
 **datasource** | **string**| The server name you would like data from | [optional] [default to tranquility]

### Return type

void (empty response body)

### Authorization

[evesso](../README.md#evesso)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletefleetsfleetidwingswingid"></a>
# **DeleteFleetsFleetIdWingsWingId**
> void DeleteFleetsFleetIdWingsWingId (long? fleetId, long? wingId, string datasource = null)

Delete fleet wing

Delete a fleet wing, only empty wings can be deleted. The wing may contain squads, but the squads must be empty  - --  Alternate route: `/v1/fleets/{fleet_id}/wings/{wing_id}/`  Alternate route: `/legacy/fleets/{fleet_id}/wings/{wing_id}/`  Alternate route: `/latest/fleets/{fleet_id}/wings/{wing_id}/` 

### Example
```csharp
using System;
using System.Diagnostics;
using ESI.Api;
using ESI.Client;
using ESI.Model;

namespace Example
{
    public class DeleteFleetsFleetIdWingsWingIdExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: evesso
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new FleetsApi();
            var fleetId = 789;  // long? | ID for a fleet
            var wingId = 789;  // long? | The wing to delete
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)

            try
            {
                // Delete fleet wing
                apiInstance.DeleteFleetsFleetIdWingsWingId(fleetId, wingId, datasource);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FleetsApi.DeleteFleetsFleetIdWingsWingId: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **fleetId** | **long?**| ID for a fleet | 
 **wingId** | **long?**| The wing to delete | 
 **datasource** | **string**| The server name you would like data from | [optional] [default to tranquility]

### Return type

void (empty response body)

### Authorization

[evesso](../README.md#evesso)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getfleetsfleetid"></a>
# **GetFleetsFleetId**
> GetFleetsFleetIdOk GetFleetsFleetId (long? fleetId, string datasource = null)

Get fleet information

Return details about a fleet  - --  Alternate route: `/v1/fleets/{fleet_id}/`  Alternate route: `/legacy/fleets/{fleet_id}/`  Alternate route: `/latest/fleets/{fleet_id}/`   - --  This route is cached for up to 5 seconds

### Example
```csharp
using System;
using System.Diagnostics;
using ESI.Api;
using ESI.Client;
using ESI.Model;

namespace Example
{
    public class GetFleetsFleetIdExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: evesso
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new FleetsApi();
            var fleetId = 789;  // long? | ID for a fleet
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)

            try
            {
                // Get fleet information
                GetFleetsFleetIdOk result = apiInstance.GetFleetsFleetId(fleetId, datasource);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FleetsApi.GetFleetsFleetId: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **fleetId** | **long?**| ID for a fleet | 
 **datasource** | **string**| The server name you would like data from | [optional] [default to tranquility]

### Return type

[**GetFleetsFleetIdOk**](GetFleetsFleetIdOk.md)

### Authorization

[evesso](../README.md#evesso)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getfleetsfleetidmembers"></a>
# **GetFleetsFleetIdMembers**
> List<GetFleetsFleetIdMembers200Ok> GetFleetsFleetIdMembers (long? fleetId, string language = null, string datasource = null)

Get fleet members

Return information about fleet members  - --  Alternate route: `/v1/fleets/{fleet_id}/members/`  Alternate route: `/legacy/fleets/{fleet_id}/members/`  Alternate route: `/latest/fleets/{fleet_id}/members/`   - --  This route is cached for up to 5 seconds

### Example
```csharp
using System;
using System.Diagnostics;
using ESI.Api;
using ESI.Client;
using ESI.Model;

namespace Example
{
    public class GetFleetsFleetIdMembersExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: evesso
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new FleetsApi();
            var fleetId = 789;  // long? | ID for a fleet
            var language = language_example;  // string | Language to use in the response (optional)  (default to en-us)
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)

            try
            {
                // Get fleet members
                List&lt;GetFleetsFleetIdMembers200Ok&gt; result = apiInstance.GetFleetsFleetIdMembers(fleetId, language, datasource);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FleetsApi.GetFleetsFleetIdMembers: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **fleetId** | **long?**| ID for a fleet | 
 **language** | **string**| Language to use in the response | [optional] [default to en-us]
 **datasource** | **string**| The server name you would like data from | [optional] [default to tranquility]

### Return type

[**List<GetFleetsFleetIdMembers200Ok>**](GetFleetsFleetIdMembers200Ok.md)

### Authorization

[evesso](../README.md#evesso)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getfleetsfleetidwings"></a>
# **GetFleetsFleetIdWings**
> List<GetFleetsFleetIdWings200Ok> GetFleetsFleetIdWings (long? fleetId, string language = null, string datasource = null)

Get fleet wings

Return information about wings in a fleet  - --  Alternate route: `/v1/fleets/{fleet_id}/wings/`  Alternate route: `/legacy/fleets/{fleet_id}/wings/`  Alternate route: `/latest/fleets/{fleet_id}/wings/`   - --  This route is cached for up to 5 seconds

### Example
```csharp
using System;
using System.Diagnostics;
using ESI.Api;
using ESI.Client;
using ESI.Model;

namespace Example
{
    public class GetFleetsFleetIdWingsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: evesso
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new FleetsApi();
            var fleetId = 789;  // long? | ID for a fleet
            var language = language_example;  // string | Language to use in the response (optional)  (default to en-us)
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)

            try
            {
                // Get fleet wings
                List&lt;GetFleetsFleetIdWings200Ok&gt; result = apiInstance.GetFleetsFleetIdWings(fleetId, language, datasource);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FleetsApi.GetFleetsFleetIdWings: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **fleetId** | **long?**| ID for a fleet | 
 **language** | **string**| Language to use in the response | [optional] [default to en-us]
 **datasource** | **string**| The server name you would like data from | [optional] [default to tranquility]

### Return type

[**List<GetFleetsFleetIdWings200Ok>**](GetFleetsFleetIdWings200Ok.md)

### Authorization

[evesso](../README.md#evesso)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postfleetsfleetidmembers"></a>
# **PostFleetsFleetIdMembers**
> void PostFleetsFleetIdMembers (long? fleetId, PostFleetsFleetIdMembersInvitation invitation, string datasource = null)

Create fleet invitation

Invite a character into the fleet, if a character has a CSPA charge set, it is not possible to invite them to the fleet using ESI  - --  Alternate route: `/v1/fleets/{fleet_id}/members/`  Alternate route: `/legacy/fleets/{fleet_id}/members/`  Alternate route: `/latest/fleets/{fleet_id}/members/` 

### Example
```csharp
using System;
using System.Diagnostics;
using ESI.Api;
using ESI.Client;
using ESI.Model;

namespace Example
{
    public class PostFleetsFleetIdMembersExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: evesso
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new FleetsApi();
            var fleetId = 789;  // long? | ID for a fleet
            var invitation = new PostFleetsFleetIdMembersInvitation(); // PostFleetsFleetIdMembersInvitation | Details of the invitation
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)

            try
            {
                // Create fleet invitation
                apiInstance.PostFleetsFleetIdMembers(fleetId, invitation, datasource);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FleetsApi.PostFleetsFleetIdMembers: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **fleetId** | **long?**| ID for a fleet | 
 **invitation** | [**PostFleetsFleetIdMembersInvitation**](PostFleetsFleetIdMembersInvitation.md)| Details of the invitation | 
 **datasource** | **string**| The server name you would like data from | [optional] [default to tranquility]

### Return type

void (empty response body)

### Authorization

[evesso](../README.md#evesso)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postfleetsfleetidwings"></a>
# **PostFleetsFleetIdWings**
> PostFleetsFleetIdWingsCreated PostFleetsFleetIdWings (long? fleetId, string datasource = null)

Create fleet wing

Create a new wing in a fleet  - --  Alternate route: `/v1/fleets/{fleet_id}/wings/`  Alternate route: `/legacy/fleets/{fleet_id}/wings/`  Alternate route: `/latest/fleets/{fleet_id}/wings/` 

### Example
```csharp
using System;
using System.Diagnostics;
using ESI.Api;
using ESI.Client;
using ESI.Model;

namespace Example
{
    public class PostFleetsFleetIdWingsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: evesso
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new FleetsApi();
            var fleetId = 789;  // long? | ID for a fleet
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)

            try
            {
                // Create fleet wing
                PostFleetsFleetIdWingsCreated result = apiInstance.PostFleetsFleetIdWings(fleetId, datasource);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FleetsApi.PostFleetsFleetIdWings: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **fleetId** | **long?**| ID for a fleet | 
 **datasource** | **string**| The server name you would like data from | [optional] [default to tranquility]

### Return type

[**PostFleetsFleetIdWingsCreated**](PostFleetsFleetIdWingsCreated.md)

### Authorization

[evesso](../README.md#evesso)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postfleetsfleetidwingswingidsquads"></a>
# **PostFleetsFleetIdWingsWingIdSquads**
> PostFleetsFleetIdWingsWingIdSquadsCreated PostFleetsFleetIdWingsWingIdSquads (long? fleetId, long? wingId, string datasource = null)

Create fleet squad

Create a new squad in a fleet  - --  Alternate route: `/v1/fleets/{fleet_id}/wings/{wing_id}/squads/`  Alternate route: `/legacy/fleets/{fleet_id}/wings/{wing_id}/squads/`  Alternate route: `/latest/fleets/{fleet_id}/wings/{wing_id}/squads/` 

### Example
```csharp
using System;
using System.Diagnostics;
using ESI.Api;
using ESI.Client;
using ESI.Model;

namespace Example
{
    public class PostFleetsFleetIdWingsWingIdSquadsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: evesso
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new FleetsApi();
            var fleetId = 789;  // long? | ID for a fleet
            var wingId = 789;  // long? | The wing_id to create squad in
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)

            try
            {
                // Create fleet squad
                PostFleetsFleetIdWingsWingIdSquadsCreated result = apiInstance.PostFleetsFleetIdWingsWingIdSquads(fleetId, wingId, datasource);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FleetsApi.PostFleetsFleetIdWingsWingIdSquads: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **fleetId** | **long?**| ID for a fleet | 
 **wingId** | **long?**| The wing_id to create squad in | 
 **datasource** | **string**| The server name you would like data from | [optional] [default to tranquility]

### Return type

[**PostFleetsFleetIdWingsWingIdSquadsCreated**](PostFleetsFleetIdWingsWingIdSquadsCreated.md)

### Authorization

[evesso](../README.md#evesso)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putfleetsfleetid"></a>
# **PutFleetsFleetId**
> void PutFleetsFleetId (long? fleetId, PutFleetsFleetIdNewSettings newSettings, string datasource = null)

Update fleet

Update settings about a fleet  - --  Alternate route: `/v1/fleets/{fleet_id}/`  Alternate route: `/legacy/fleets/{fleet_id}/`  Alternate route: `/latest/fleets/{fleet_id}/` 

### Example
```csharp
using System;
using System.Diagnostics;
using ESI.Api;
using ESI.Client;
using ESI.Model;

namespace Example
{
    public class PutFleetsFleetIdExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: evesso
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new FleetsApi();
            var fleetId = 789;  // long? | ID for a fleet
            var newSettings = new PutFleetsFleetIdNewSettings(); // PutFleetsFleetIdNewSettings | What to update for this fleet
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)

            try
            {
                // Update fleet
                apiInstance.PutFleetsFleetId(fleetId, newSettings, datasource);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FleetsApi.PutFleetsFleetId: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **fleetId** | **long?**| ID for a fleet | 
 **newSettings** | [**PutFleetsFleetIdNewSettings**](PutFleetsFleetIdNewSettings.md)| What to update for this fleet | 
 **datasource** | **string**| The server name you would like data from | [optional] [default to tranquility]

### Return type

void (empty response body)

### Authorization

[evesso](../README.md#evesso)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putfleetsfleetidmembersmemberid"></a>
# **PutFleetsFleetIdMembersMemberId**
> void PutFleetsFleetIdMembersMemberId (long? fleetId, int? memberId, PutFleetsFleetIdMembersMemberIdMovement movement, string datasource = null)

Move fleet member

Move a fleet member around  - --  Alternate route: `/v1/fleets/{fleet_id}/members/{member_id}/`  Alternate route: `/legacy/fleets/{fleet_id}/members/{member_id}/`  Alternate route: `/latest/fleets/{fleet_id}/members/{member_id}/` 

### Example
```csharp
using System;
using System.Diagnostics;
using ESI.Api;
using ESI.Client;
using ESI.Model;

namespace Example
{
    public class PutFleetsFleetIdMembersMemberIdExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: evesso
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new FleetsApi();
            var fleetId = 789;  // long? | ID for a fleet
            var memberId = 56;  // int? | The character ID of a member in this fleet
            var movement = new PutFleetsFleetIdMembersMemberIdMovement(); // PutFleetsFleetIdMembersMemberIdMovement | Details of the invitation
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)

            try
            {
                // Move fleet member
                apiInstance.PutFleetsFleetIdMembersMemberId(fleetId, memberId, movement, datasource);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FleetsApi.PutFleetsFleetIdMembersMemberId: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **fleetId** | **long?**| ID for a fleet | 
 **memberId** | **int?**| The character ID of a member in this fleet | 
 **movement** | [**PutFleetsFleetIdMembersMemberIdMovement**](PutFleetsFleetIdMembersMemberIdMovement.md)| Details of the invitation | 
 **datasource** | **string**| The server name you would like data from | [optional] [default to tranquility]

### Return type

void (empty response body)

### Authorization

[evesso](../README.md#evesso)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putfleetsfleetidsquadssquadid"></a>
# **PutFleetsFleetIdSquadsSquadId**
> void PutFleetsFleetIdSquadsSquadId (long? fleetId, long? squadId, PutFleetsFleetIdSquadsSquadIdNaming naming, string datasource = null)

Rename fleet squad

Rename a fleet squad  - --  Alternate route: `/v1/fleets/{fleet_id}/squads/{squad_id}/`  Alternate route: `/legacy/fleets/{fleet_id}/squads/{squad_id}/`  Alternate route: `/latest/fleets/{fleet_id}/squads/{squad_id}/` 

### Example
```csharp
using System;
using System.Diagnostics;
using ESI.Api;
using ESI.Client;
using ESI.Model;

namespace Example
{
    public class PutFleetsFleetIdSquadsSquadIdExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: evesso
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new FleetsApi();
            var fleetId = 789;  // long? | ID for a fleet
            var squadId = 789;  // long? | The squad to rename
            var naming = new PutFleetsFleetIdSquadsSquadIdNaming(); // PutFleetsFleetIdSquadsSquadIdNaming | New name of the squad
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)

            try
            {
                // Rename fleet squad
                apiInstance.PutFleetsFleetIdSquadsSquadId(fleetId, squadId, naming, datasource);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FleetsApi.PutFleetsFleetIdSquadsSquadId: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **fleetId** | **long?**| ID for a fleet | 
 **squadId** | **long?**| The squad to rename | 
 **naming** | [**PutFleetsFleetIdSquadsSquadIdNaming**](PutFleetsFleetIdSquadsSquadIdNaming.md)| New name of the squad | 
 **datasource** | **string**| The server name you would like data from | [optional] [default to tranquility]

### Return type

void (empty response body)

### Authorization

[evesso](../README.md#evesso)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putfleetsfleetidwingswingid"></a>
# **PutFleetsFleetIdWingsWingId**
> void PutFleetsFleetIdWingsWingId (long? fleetId, long? wingId, PutFleetsFleetIdWingsWingIdNaming naming, string datasource = null)

Rename fleet wing

Rename a fleet wing  - --  Alternate route: `/v1/fleets/{fleet_id}/wings/{wing_id}/`  Alternate route: `/legacy/fleets/{fleet_id}/wings/{wing_id}/`  Alternate route: `/latest/fleets/{fleet_id}/wings/{wing_id}/` 

### Example
```csharp
using System;
using System.Diagnostics;
using ESI.Api;
using ESI.Client;
using ESI.Model;

namespace Example
{
    public class PutFleetsFleetIdWingsWingIdExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: evesso
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new FleetsApi();
            var fleetId = 789;  // long? | ID for a fleet
            var wingId = 789;  // long? | The wing to rename
            var naming = new PutFleetsFleetIdWingsWingIdNaming(); // PutFleetsFleetIdWingsWingIdNaming | New name of the wing
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)

            try
            {
                // Rename fleet wing
                apiInstance.PutFleetsFleetIdWingsWingId(fleetId, wingId, naming, datasource);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FleetsApi.PutFleetsFleetIdWingsWingId: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **fleetId** | **long?**| ID for a fleet | 
 **wingId** | **long?**| The wing to rename | 
 **naming** | [**PutFleetsFleetIdWingsWingIdNaming**](PutFleetsFleetIdWingsWingIdNaming.md)| New name of the wing | 
 **datasource** | **string**| The server name you would like data from | [optional] [default to tranquility]

### Return type

void (empty response body)

### Authorization

[evesso](../README.md#evesso)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

