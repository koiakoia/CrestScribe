# ESI.Api.PlanetaryInteractionApi

All URIs are relative to *https://esi.tech.ccp.is/dev*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetCharactersCharacterIdPlanets**](PlanetaryInteractionApi.md#getcharacterscharacteridplanets) | **GET** /characters/{character_id}/planets/ | Get colonies
[**GetCharactersCharacterIdPlanetsPlanetId**](PlanetaryInteractionApi.md#getcharacterscharacteridplanetsplanetid) | **GET** /characters/{character_id}/planets/{planet_id}/ | Get colony layout
[**GetUniverseSchematicsSchematicId**](PlanetaryInteractionApi.md#getuniverseschematicsschematicid) | **GET** /universe/schematics/{schematic_id}/ | Get schematic information


<a name="getcharacterscharacteridplanets"></a>
# **GetCharactersCharacterIdPlanets**
> List<GetCharactersCharacterIdPlanets200Ok> GetCharactersCharacterIdPlanets (int? characterId, string datasource = null)

Get colonies

Returns a list of all planetary colonies owned by a character.  - --  Alternate route: `/v1/characters/{character_id}/planets/`  Alternate route: `/legacy/characters/{character_id}/planets/`  Alternate route: `/latest/characters/{character_id}/planets/`   - --  This route is cached for up to 600 seconds

### Example
```csharp
using System;
using System.Diagnostics;
using ESI.Api;
using ESI.Client;
using ESI.Model;

namespace Example
{
    public class GetCharactersCharacterIdPlanetsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: evesso
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PlanetaryInteractionApi();
            var characterId = 56;  // int? | Character id of the target character
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)

            try
            {
                // Get colonies
                List&lt;GetCharactersCharacterIdPlanets200Ok&gt; result = apiInstance.GetCharactersCharacterIdPlanets(characterId, datasource);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PlanetaryInteractionApi.GetCharactersCharacterIdPlanets: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **characterId** | **int?**| Character id of the target character | 
 **datasource** | **string**| The server name you would like data from | [optional] [default to tranquility]

### Return type

[**List<GetCharactersCharacterIdPlanets200Ok>**](GetCharactersCharacterIdPlanets200Ok.md)

### Authorization

[evesso](../README.md#evesso)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcharacterscharacteridplanetsplanetid"></a>
# **GetCharactersCharacterIdPlanetsPlanetId**
> GetCharactersCharacterIdPlanetsPlanetIdOk GetCharactersCharacterIdPlanetsPlanetId (int? characterId, int? planetId, string datasource = null)

Get colony layout

Returns full details on the layout of a single planetary colony, including links, pins and routes. Note: Planetary information is only recalculated when the colony is viewed through the client. Information on this endpoint will not update until this criteria is met.  - --  Alternate route: `/v1/characters/{character_id}/planets/{planet_id}/`  Alternate route: `/legacy/characters/{character_id}/planets/{planet_id}/`  Alternate route: `/latest/characters/{character_id}/planets/{planet_id}/`   - --  This route is cached for up to 600 seconds

### Example
```csharp
using System;
using System.Diagnostics;
using ESI.Api;
using ESI.Client;
using ESI.Model;

namespace Example
{
    public class GetCharactersCharacterIdPlanetsPlanetIdExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: evesso
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PlanetaryInteractionApi();
            var characterId = 56;  // int? | Character id of the target character
            var planetId = 56;  // int? | Planet id of the target planet
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)

            try
            {
                // Get colony layout
                GetCharactersCharacterIdPlanetsPlanetIdOk result = apiInstance.GetCharactersCharacterIdPlanetsPlanetId(characterId, planetId, datasource);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PlanetaryInteractionApi.GetCharactersCharacterIdPlanetsPlanetId: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **characterId** | **int?**| Character id of the target character | 
 **planetId** | **int?**| Planet id of the target planet | 
 **datasource** | **string**| The server name you would like data from | [optional] [default to tranquility]

### Return type

[**GetCharactersCharacterIdPlanetsPlanetIdOk**](GetCharactersCharacterIdPlanetsPlanetIdOk.md)

### Authorization

[evesso](../README.md#evesso)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getuniverseschematicsschematicid"></a>
# **GetUniverseSchematicsSchematicId**
> GetUniverseSchematicsSchematicIdOk GetUniverseSchematicsSchematicId (int? schematicId, string datasource = null)

Get schematic information

Get information on a planetary factory schematic  - --  Alternate route: `/v1/universe/schematics/{schematic_id}/`  Alternate route: `/legacy/universe/schematics/{schematic_id}/`  Alternate route: `/latest/universe/schematics/{schematic_id}/`   - --  This route is cached for up to 3600 seconds

### Example
```csharp
using System;
using System.Diagnostics;
using ESI.Api;
using ESI.Client;
using ESI.Model;

namespace Example
{
    public class GetUniverseSchematicsSchematicIdExample
    {
        public void main()
        {
            
            var apiInstance = new PlanetaryInteractionApi();
            var schematicId = 56;  // int? | A PI schematic ID
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)

            try
            {
                // Get schematic information
                GetUniverseSchematicsSchematicIdOk result = apiInstance.GetUniverseSchematicsSchematicId(schematicId, datasource);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PlanetaryInteractionApi.GetUniverseSchematicsSchematicId: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **schematicId** | **int?**| A PI schematic ID | 
 **datasource** | **string**| The server name you would like data from | [optional] [default to tranquility]

### Return type

[**GetUniverseSchematicsSchematicIdOk**](GetUniverseSchematicsSchematicIdOk.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

