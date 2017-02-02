# ESI.Api.MarketApi

All URIs are relative to *https://esi.tech.ccp.is/dev*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetMarketsPrices**](MarketApi.md#getmarketsprices) | **GET** /markets/prices/ | List market prices
[**GetMarketsRegionIdHistory**](MarketApi.md#getmarketsregionidhistory) | **GET** /markets/{region_id}/history/ | List historical market statistics in a region
[**GetMarketsRegionIdOrders**](MarketApi.md#getmarketsregionidorders) | **GET** /markets/{region_id}/orders/ | List orders in a region
[**GetMarketsStructuresStructureId**](MarketApi.md#getmarketsstructuresstructureid) | **GET** /markets/structures/{structure_id}/ | List orders in a structure


<a name="getmarketsprices"></a>
# **GetMarketsPrices**
> List<GetMarketsPrices200Ok> GetMarketsPrices (string datasource = null)

List market prices

Return a list of prices  - --  Alternate route: `/v1/markets/prices/`  Alternate route: `/legacy/markets/prices/`  Alternate route: `/latest/markets/prices/`   - --  This route is cached for up to 3600 seconds

### Example
```csharp
using System;
using System.Diagnostics;
using ESI.Api;
using ESI.Client;
using ESI.Model;

namespace Example
{
    public class GetMarketsPricesExample
    {
        public void main()
        {
            
            var apiInstance = new MarketApi();
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)

            try
            {
                // List market prices
                List&lt;GetMarketsPrices200Ok&gt; result = apiInstance.GetMarketsPrices(datasource);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MarketApi.GetMarketsPrices: " + e.Message );
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

[**List<GetMarketsPrices200Ok>**](GetMarketsPrices200Ok.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getmarketsregionidhistory"></a>
# **GetMarketsRegionIdHistory**
> List<GetMarketsRegionIdHistory200Ok> GetMarketsRegionIdHistory (int? regionId, int? typeId, string datasource = null)

List historical market statistics in a region

Return a list of historical market statistics for the specified type in a region  - --  Alternate route: `/v1/markets/{region_id}/history/`  Alternate route: `/legacy/markets/{region_id}/history/`  Alternate route: `/latest/markets/{region_id}/history/`   - --  This route is cached for up to 3600 seconds

### Example
```csharp
using System;
using System.Diagnostics;
using ESI.Api;
using ESI.Client;
using ESI.Model;

namespace Example
{
    public class GetMarketsRegionIdHistoryExample
    {
        public void main()
        {
            
            var apiInstance = new MarketApi();
            var regionId = 56;  // int? | Return statistics in this region
            var typeId = 56;  // int? | Return statistics for this type
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)

            try
            {
                // List historical market statistics in a region
                List&lt;GetMarketsRegionIdHistory200Ok&gt; result = apiInstance.GetMarketsRegionIdHistory(regionId, typeId, datasource);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MarketApi.GetMarketsRegionIdHistory: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **regionId** | **int?**| Return statistics in this region | 
 **typeId** | **int?**| Return statistics for this type | 
 **datasource** | **string**| The server name you would like data from | [optional] [default to tranquility]

### Return type

[**List<GetMarketsRegionIdHistory200Ok>**](GetMarketsRegionIdHistory200Ok.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getmarketsregionidorders"></a>
# **GetMarketsRegionIdOrders**
> List<GetMarketsRegionIdOrders200Ok> GetMarketsRegionIdOrders (int? regionId, string orderType, int? typeId = null, int? page = null, string datasource = null)

List orders in a region

Return a list of orders in a region  - --  Alternate route: `/v1/markets/{region_id}/orders/`  Alternate route: `/legacy/markets/{region_id}/orders/`  Alternate route: `/latest/markets/{region_id}/orders/`   - --  This route is cached for up to 300 seconds

### Example
```csharp
using System;
using System.Diagnostics;
using ESI.Api;
using ESI.Client;
using ESI.Model;

namespace Example
{
    public class GetMarketsRegionIdOrdersExample
    {
        public void main()
        {
            
            var apiInstance = new MarketApi();
            var regionId = 56;  // int? | Return orders in this region
            var orderType = orderType_example;  // string | Filter buy/sell orders, return all orders by default. If you query without type_id, we always return both buy and sell orders.  (default to all)
            var typeId = 56;  // int? | Return orders only for this type (optional) 
            var page = 56;  // int? | Which page to query, only used for querying without type_id. Starting at 1  (optional)  (default to 1)
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)

            try
            {
                // List orders in a region
                List&lt;GetMarketsRegionIdOrders200Ok&gt; result = apiInstance.GetMarketsRegionIdOrders(regionId, orderType, typeId, page, datasource);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MarketApi.GetMarketsRegionIdOrders: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **regionId** | **int?**| Return orders in this region | 
 **orderType** | **string**| Filter buy/sell orders, return all orders by default. If you query without type_id, we always return both buy and sell orders.  | [default to all]
 **typeId** | **int?**| Return orders only for this type | [optional] 
 **page** | **int?**| Which page to query, only used for querying without type_id. Starting at 1  | [optional] [default to 1]
 **datasource** | **string**| The server name you would like data from | [optional] [default to tranquility]

### Return type

[**List<GetMarketsRegionIdOrders200Ok>**](GetMarketsRegionIdOrders200Ok.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getmarketsstructuresstructureid"></a>
# **GetMarketsStructuresStructureId**
> List<GetMarketsStructuresStructureId200Ok> GetMarketsStructuresStructureId (long? structureId, int? page = null, string datasource = null)

List orders in a structure

Return all orders in a structure  - --  Alternate route: `/v1/markets/structures/{structure_id}/`  Alternate route: `/legacy/markets/structures/{structure_id}/`  Alternate route: `/latest/markets/structures/{structure_id}/`   - --  This route is cached for up to 300 seconds

### Example
```csharp
using System;
using System.Diagnostics;
using ESI.Api;
using ESI.Client;
using ESI.Model;

namespace Example
{
    public class GetMarketsStructuresStructureIdExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: evesso
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MarketApi();
            var structureId = 789;  // long? | Return orders in this structure
            var page = 56;  // int? | Which page to query, starting at 1 (optional)  (default to 1)
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)

            try
            {
                // List orders in a structure
                List&lt;GetMarketsStructuresStructureId200Ok&gt; result = apiInstance.GetMarketsStructuresStructureId(structureId, page, datasource);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MarketApi.GetMarketsStructuresStructureId: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **structureId** | **long?**| Return orders in this structure | 
 **page** | **int?**| Which page to query, starting at 1 | [optional] [default to 1]
 **datasource** | **string**| The server name you would like data from | [optional] [default to tranquility]

### Return type

[**List<GetMarketsStructuresStructureId200Ok>**](GetMarketsStructuresStructureId200Ok.md)

### Authorization

[evesso](../README.md#evesso)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

