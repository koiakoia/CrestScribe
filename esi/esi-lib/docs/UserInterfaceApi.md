# ESI.Api.UserInterfaceApi

All URIs are relative to *https://esi.tech.ccp.is/dev*

Method | HTTP request | Description
------------- | ------------- | -------------
[**PostUiAutopilotWaypoint**](UserInterfaceApi.md#postuiautopilotwaypoint) | **POST** /ui/autopilot/waypoint/ | Set Autopilot Waypoint
[**PostUiOpenwindowContract**](UserInterfaceApi.md#postuiopenwindowcontract) | **POST** /ui/openwindow/contract/ | Open Contract Window
[**PostUiOpenwindowInformation**](UserInterfaceApi.md#postuiopenwindowinformation) | **POST** /ui/openwindow/information/ | Open Information Window
[**PostUiOpenwindowMarketdetails**](UserInterfaceApi.md#postuiopenwindowmarketdetails) | **POST** /ui/openwindow/marketdetails/ | Open Market Details
[**PostUiOpenwindowNewmail**](UserInterfaceApi.md#postuiopenwindownewmail) | **POST** /ui/openwindow/newmail/ | Open New Mail Window


<a name="postuiautopilotwaypoint"></a>
# **PostUiAutopilotWaypoint**
> void PostUiAutopilotWaypoint (long? destinationId, bool? clearOtherWaypoints, bool? addToBeginning, string datasource = null)

Set Autopilot Waypoint

Set a solar system as autopilot waypoint  - --  Alternate route: `/v2/ui/autopilot/waypoint/`  Alternate route: `/latest/ui/autopilot/waypoint/` 

### Example
```csharp
using System;
using System.Diagnostics;
using ESI.Api;
using ESI.Client;
using ESI.Model;

namespace Example
{
    public class PostUiAutopilotWaypointExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: evesso
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UserInterfaceApi();
            var destinationId = 789;  // long? | The destination to travel to, can be solar system, station or structure's id
            var clearOtherWaypoints = true;  // bool? | Whether clean other waypoints beforing adding this one (default to false)
            var addToBeginning = true;  // bool? | Whether this solar system should be added to the beginning of all waypoints (default to false)
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)

            try
            {
                // Set Autopilot Waypoint
                apiInstance.PostUiAutopilotWaypoint(destinationId, clearOtherWaypoints, addToBeginning, datasource);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserInterfaceApi.PostUiAutopilotWaypoint: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **destinationId** | **long?**| The destination to travel to, can be solar system, station or structure&#39;s id | 
 **clearOtherWaypoints** | **bool?**| Whether clean other waypoints beforing adding this one | [default to false]
 **addToBeginning** | **bool?**| Whether this solar system should be added to the beginning of all waypoints | [default to false]
 **datasource** | **string**| The server name you would like data from | [optional] [default to tranquility]

### Return type

void (empty response body)

### Authorization

[evesso](../README.md#evesso)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postuiopenwindowcontract"></a>
# **PostUiOpenwindowContract**
> void PostUiOpenwindowContract (int? contractId, string datasource = null)

Open Contract Window

Open the contract window inside the client  - --  Alternate route: `/v1/ui/openwindow/contract/`  Alternate route: `/legacy/ui/openwindow/contract/`  Alternate route: `/latest/ui/openwindow/contract/` 

### Example
```csharp
using System;
using System.Diagnostics;
using ESI.Api;
using ESI.Client;
using ESI.Model;

namespace Example
{
    public class PostUiOpenwindowContractExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: evesso
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UserInterfaceApi();
            var contractId = 56;  // int? | The contract to open
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)

            try
            {
                // Open Contract Window
                apiInstance.PostUiOpenwindowContract(contractId, datasource);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserInterfaceApi.PostUiOpenwindowContract: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **contractId** | **int?**| The contract to open | 
 **datasource** | **string**| The server name you would like data from | [optional] [default to tranquility]

### Return type

void (empty response body)

### Authorization

[evesso](../README.md#evesso)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postuiopenwindowinformation"></a>
# **PostUiOpenwindowInformation**
> void PostUiOpenwindowInformation (int? targetId, string datasource = null)

Open Information Window

Open the information window for a character, corporation or alliance inside the client  - --  Alternate route: `/v1/ui/openwindow/information/`  Alternate route: `/legacy/ui/openwindow/information/`  Alternate route: `/latest/ui/openwindow/information/` 

### Example
```csharp
using System;
using System.Diagnostics;
using ESI.Api;
using ESI.Client;
using ESI.Model;

namespace Example
{
    public class PostUiOpenwindowInformationExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: evesso
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UserInterfaceApi();
            var targetId = 56;  // int? | The target to open
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)

            try
            {
                // Open Information Window
                apiInstance.PostUiOpenwindowInformation(targetId, datasource);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserInterfaceApi.PostUiOpenwindowInformation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **targetId** | **int?**| The target to open | 
 **datasource** | **string**| The server name you would like data from | [optional] [default to tranquility]

### Return type

void (empty response body)

### Authorization

[evesso](../README.md#evesso)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postuiopenwindowmarketdetails"></a>
# **PostUiOpenwindowMarketdetails**
> void PostUiOpenwindowMarketdetails (int? typeId, string datasource = null)

Open Market Details

Open the market details window for a specific typeID inside the client  - --  Alternate route: `/v1/ui/openwindow/marketdetails/`  Alternate route: `/legacy/ui/openwindow/marketdetails/`  Alternate route: `/latest/ui/openwindow/marketdetails/` 

### Example
```csharp
using System;
using System.Diagnostics;
using ESI.Api;
using ESI.Client;
using ESI.Model;

namespace Example
{
    public class PostUiOpenwindowMarketdetailsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: evesso
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UserInterfaceApi();
            var typeId = 56;  // int? | The item type to open in market window
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)

            try
            {
                // Open Market Details
                apiInstance.PostUiOpenwindowMarketdetails(typeId, datasource);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserInterfaceApi.PostUiOpenwindowMarketdetails: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **typeId** | **int?**| The item type to open in market window | 
 **datasource** | **string**| The server name you would like data from | [optional] [default to tranquility]

### Return type

void (empty response body)

### Authorization

[evesso](../README.md#evesso)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postuiopenwindownewmail"></a>
# **PostUiOpenwindowNewmail**
> void PostUiOpenwindowNewmail (PostUiOpenwindowNewmailNewMail newMail, string datasource = null)

Open New Mail Window

Open the New Mail window, according to settings from the request if applicable  - --  Alternate route: `/v1/ui/openwindow/newmail/`  Alternate route: `/legacy/ui/openwindow/newmail/`  Alternate route: `/latest/ui/openwindow/newmail/` 

### Example
```csharp
using System;
using System.Diagnostics;
using ESI.Api;
using ESI.Client;
using ESI.Model;

namespace Example
{
    public class PostUiOpenwindowNewmailExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: evesso
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UserInterfaceApi();
            var newMail = new PostUiOpenwindowNewmailNewMail(); // PostUiOpenwindowNewmailNewMail | The details of mail to create
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)

            try
            {
                // Open New Mail Window
                apiInstance.PostUiOpenwindowNewmail(newMail, datasource);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserInterfaceApi.PostUiOpenwindowNewmail: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **newMail** | [**PostUiOpenwindowNewmailNewMail**](PostUiOpenwindowNewmailNewMail.md)| The details of mail to create | 
 **datasource** | **string**| The server name you would like data from | [optional] [default to tranquility]

### Return type

void (empty response body)

### Authorization

[evesso](../README.md#evesso)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

