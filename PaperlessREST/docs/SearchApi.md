# Org.OpenAPITools.Api.SearchApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AutoComplete**](SearchApi.md#autocomplete) | **GET** /api/search/autocomplete |  |

<a id="autocomplete"></a>
# **AutoComplete**
> void AutoComplete (string? term = null, int? limit = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AutoCompleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new SearchApi(config);
            var term = "term_example";  // string? |  (optional) 
            var limit = 56;  // int? |  (optional) 

            try
            {
                apiInstance.AutoComplete(term, limit);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SearchApi.AutoComplete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AutoCompleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.AutoCompleteWithHttpInfo(term, limit);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SearchApi.AutoCompleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **term** | **string?** |  | [optional]  |
| **limit** | **int?** |  | [optional]  |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

