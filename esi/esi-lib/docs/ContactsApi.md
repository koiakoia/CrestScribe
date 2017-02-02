# ESI.Api.ContactsApi

All URIs are relative to *https://esi.tech.ccp.is/dev*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteCharactersCharacterIdContacts**](ContactsApi.md#deletecharacterscharacteridcontacts) | **DELETE** /characters/{character_id}/contacts/ | Delete contacts
[**GetCharactersCharacterIdContacts**](ContactsApi.md#getcharacterscharacteridcontacts) | **GET** /characters/{character_id}/contacts/ | Get contacts
[**GetCharactersCharacterIdContactsLabels**](ContactsApi.md#getcharacterscharacteridcontactslabels) | **GET** /characters/{character_id}/contacts/labels/ | Get contact labels
[**PostCharactersCharacterIdContacts**](ContactsApi.md#postcharacterscharacteridcontacts) | **POST** /characters/{character_id}/contacts/ | Add contacts
[**PutCharactersCharacterIdContacts**](ContactsApi.md#putcharacterscharacteridcontacts) | **PUT** /characters/{character_id}/contacts/ | Edit contacts


<a name="deletecharacterscharacteridcontacts"></a>
# **DeleteCharactersCharacterIdContacts**
> void DeleteCharactersCharacterIdContacts (int? characterId, List<int?> contactIds, string datasource = null)

Delete contacts

Bulk delete contacts  - --  Alternate route: `/v1/characters/{character_id}/contacts/`  Alternate route: `/legacy/characters/{character_id}/contacts/`  Alternate route: `/latest/characters/{character_id}/contacts/` 

### Example
```csharp
using System;
using System.Diagnostics;
using ESI.Api;
using ESI.Client;
using ESI.Model;

namespace Example
{
    public class DeleteCharactersCharacterIdContactsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: evesso
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ContactsApi();
            var characterId = 56;  // int? | ID for a character
            var contactIds = ;  // List<int?> | A list of contacts to edit
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)

            try
            {
                // Delete contacts
                apiInstance.DeleteCharactersCharacterIdContacts(characterId, contactIds, datasource);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContactsApi.DeleteCharactersCharacterIdContacts: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **characterId** | **int?**| ID for a character | 
 **contactIds** | **List&lt;int?&gt;**| A list of contacts to edit | 
 **datasource** | **string**| The server name you would like data from | [optional] [default to tranquility]

### Return type

void (empty response body)

### Authorization

[evesso](../README.md#evesso)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcharacterscharacteridcontacts"></a>
# **GetCharactersCharacterIdContacts**
> List<GetCharactersCharacterIdContacts200Ok> GetCharactersCharacterIdContacts (int? characterId, int? page = null, string datasource = null)

Get contacts

Return contacts of a character  - --  Alternate route: `/v1/characters/{character_id}/contacts/`  Alternate route: `/legacy/characters/{character_id}/contacts/`  Alternate route: `/latest/characters/{character_id}/contacts/`   - --  This route is cached for up to 300 seconds

### Example
```csharp
using System;
using System.Diagnostics;
using ESI.Api;
using ESI.Client;
using ESI.Model;

namespace Example
{
    public class GetCharactersCharacterIdContactsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: evesso
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ContactsApi();
            var characterId = 56;  // int? | ID for a character
            var page = 56;  // int? | page integer (optional)  (default to 1)
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)

            try
            {
                // Get contacts
                List&lt;GetCharactersCharacterIdContacts200Ok&gt; result = apiInstance.GetCharactersCharacterIdContacts(characterId, page, datasource);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContactsApi.GetCharactersCharacterIdContacts: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **characterId** | **int?**| ID for a character | 
 **page** | **int?**| page integer | [optional] [default to 1]
 **datasource** | **string**| The server name you would like data from | [optional] [default to tranquility]

### Return type

[**List<GetCharactersCharacterIdContacts200Ok>**](GetCharactersCharacterIdContacts200Ok.md)

### Authorization

[evesso](../README.md#evesso)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcharacterscharacteridcontactslabels"></a>
# **GetCharactersCharacterIdContactsLabels**
> List<GetCharactersCharacterIdContactsLabels200Ok> GetCharactersCharacterIdContactsLabels (int? characterId, string datasource = null)

Get contact labels

Return custom labels for contacts the character defined  - --  Alternate route: `/v1/characters/{character_id}/contacts/labels/`  Alternate route: `/legacy/characters/{character_id}/contacts/labels/`  Alternate route: `/latest/characters/{character_id}/contacts/labels/`   - --  This route is cached for up to 300 seconds

### Example
```csharp
using System;
using System.Diagnostics;
using ESI.Api;
using ESI.Client;
using ESI.Model;

namespace Example
{
    public class GetCharactersCharacterIdContactsLabelsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: evesso
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ContactsApi();
            var characterId = 56;  // int? | ID for a character
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)

            try
            {
                // Get contact labels
                List&lt;GetCharactersCharacterIdContactsLabels200Ok&gt; result = apiInstance.GetCharactersCharacterIdContactsLabels(characterId, datasource);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContactsApi.GetCharactersCharacterIdContactsLabels: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **characterId** | **int?**| ID for a character | 
 **datasource** | **string**| The server name you would like data from | [optional] [default to tranquility]

### Return type

[**List<GetCharactersCharacterIdContactsLabels200Ok>**](GetCharactersCharacterIdContactsLabels200Ok.md)

### Authorization

[evesso](../README.md#evesso)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postcharacterscharacteridcontacts"></a>
# **PostCharactersCharacterIdContacts**
> List<int?> PostCharactersCharacterIdContacts (int? characterId, float? standing, List<int?> contactIds, bool? watched = null, long? labelId = null, string datasource = null)

Add contacts

Bulk add contacts with same settings  - --  Alternate route: `/v1/characters/{character_id}/contacts/`  Alternate route: `/legacy/characters/{character_id}/contacts/`  Alternate route: `/latest/characters/{character_id}/contacts/` 

### Example
```csharp
using System;
using System.Diagnostics;
using ESI.Api;
using ESI.Client;
using ESI.Model;

namespace Example
{
    public class PostCharactersCharacterIdContactsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: evesso
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ContactsApi();
            var characterId = 56;  // int? | ID for a character
            var standing = 3.4;  // float? | Standing for the new contact
            var contactIds = ;  // List<int?> | A list of contacts to add
            var watched = true;  // bool? | Whether the new contact should be watched, note this is only effective on characters (optional)  (default to false)
            var labelId = 789;  // long? | Add a custom label to the new contact (optional)  (default to 0)
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)

            try
            {
                // Add contacts
                List&lt;int?&gt; result = apiInstance.PostCharactersCharacterIdContacts(characterId, standing, contactIds, watched, labelId, datasource);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContactsApi.PostCharactersCharacterIdContacts: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **characterId** | **int?**| ID for a character | 
 **standing** | **float?**| Standing for the new contact | 
 **contactIds** | **List&lt;int?&gt;**| A list of contacts to add | 
 **watched** | **bool?**| Whether the new contact should be watched, note this is only effective on characters | [optional] [default to false]
 **labelId** | **long?**| Add a custom label to the new contact | [optional] [default to 0]
 **datasource** | **string**| The server name you would like data from | [optional] [default to tranquility]

### Return type

**List<int?>**

### Authorization

[evesso](../README.md#evesso)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putcharacterscharacteridcontacts"></a>
# **PutCharactersCharacterIdContacts**
> void PutCharactersCharacterIdContacts (int? characterId, float? standing, List<int?> contactIds, bool? watched = null, long? labelId = null, string datasource = null)

Edit contacts

Bulk edit contacts with same settings  - --  Alternate route: `/v1/characters/{character_id}/contacts/`  Alternate route: `/legacy/characters/{character_id}/contacts/`  Alternate route: `/latest/characters/{character_id}/contacts/` 

### Example
```csharp
using System;
using System.Diagnostics;
using ESI.Api;
using ESI.Client;
using ESI.Model;

namespace Example
{
    public class PutCharactersCharacterIdContactsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: evesso
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ContactsApi();
            var characterId = 56;  // int? | ID for a character
            var standing = 3.4;  // float? | Standing for the contact
            var contactIds = ;  // List<int?> | A list of contacts to edit
            var watched = true;  // bool? | Whether the contact should be watched, note this is only effective on characters (optional)  (default to false)
            var labelId = 789;  // long? | Add a custom label to the contact, use 0 for clearing label (optional)  (default to 0)
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)

            try
            {
                // Edit contacts
                apiInstance.PutCharactersCharacterIdContacts(characterId, standing, contactIds, watched, labelId, datasource);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContactsApi.PutCharactersCharacterIdContacts: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **characterId** | **int?**| ID for a character | 
 **standing** | **float?**| Standing for the contact | 
 **contactIds** | **List&lt;int?&gt;**| A list of contacts to edit | 
 **watched** | **bool?**| Whether the contact should be watched, note this is only effective on characters | [optional] [default to false]
 **labelId** | **long?**| Add a custom label to the contact, use 0 for clearing label | [optional] [default to 0]
 **datasource** | **string**| The server name you would like data from | [optional] [default to tranquility]

### Return type

void (empty response body)

### Authorization

[evesso](../README.md#evesso)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

