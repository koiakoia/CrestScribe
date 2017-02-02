# ESI.Api.WalletApi

All URIs are relative to *https://esi.tech.ccp.is/dev*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetCharactersCharacterIdWallets**](WalletApi.md#getcharacterscharacteridwallets) | **GET** /characters/{character_id}/wallets/ | List wallets and balances


<a name="getcharacterscharacteridwallets"></a>
# **GetCharactersCharacterIdWallets**
> List<GetCharactersCharacterIdWallets200Ok> GetCharactersCharacterIdWallets (int? characterId, string datasource = null)

List wallets and balances

List your wallets and their balances. Characters typically have only one wallet, with wallet_id 1000 being the master wallet.  - --  Alternate route: `/v1/characters/{character_id}/wallets/`  Alternate route: `/legacy/characters/{character_id}/wallets/`  Alternate route: `/latest/characters/{character_id}/wallets/`   - --  This route is cached for up to 120 seconds

### Example
```csharp
using System;
using System.Diagnostics;
using ESI.Api;
using ESI.Client;
using ESI.Model;

namespace Example
{
    public class GetCharactersCharacterIdWalletsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: evesso
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WalletApi();
            var characterId = 56;  // int? | An EVE character ID
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)

            try
            {
                // List wallets and balances
                List&lt;GetCharactersCharacterIdWallets200Ok&gt; result = apiInstance.GetCharactersCharacterIdWallets(characterId, datasource);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WalletApi.GetCharactersCharacterIdWallets: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **characterId** | **int?**| An EVE character ID | 
 **datasource** | **string**| The server name you would like data from | [optional] [default to tranquility]

### Return type

[**List<GetCharactersCharacterIdWallets200Ok>**](GetCharactersCharacterIdWallets200Ok.md)

### Authorization

[evesso](../README.md#evesso)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

