# Org.OpenAPITools.Api.CorrespondentsApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateCorrespondent**](CorrespondentsApi.md#createcorrespondent) | **POST** /api/correspondents |  |
| [**DeleteCorrespondent**](CorrespondentsApi.md#deletecorrespondent) | **DELETE** /api/correspondents/{id} |  |
| [**GetCorrespondents**](CorrespondentsApi.md#getcorrespondents) | **GET** /api/correspondents |  |
| [**UpdateCorrespondent**](CorrespondentsApi.md#updatecorrespondent) | **PUT** /api/correspondents/{id} |  |

<a id="createcorrespondent"></a>
# **CreateCorrespondent**
> void CreateCorrespondent (NewCorrespondent? newCorrespondent = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CreateCorrespondentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new CorrespondentsApi(config);
            var newCorrespondent = new NewCorrespondent?(); // NewCorrespondent? |  (optional) 

            try
            {
                apiInstance.CreateCorrespondent(newCorrespondent);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CorrespondentsApi.CreateCorrespondent: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateCorrespondentWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.CreateCorrespondentWithHttpInfo(newCorrespondent);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CorrespondentsApi.CreateCorrespondentWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **newCorrespondent** | [**NewCorrespondent?**](NewCorrespondent?.md) |  | [optional]  |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/*+json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deletecorrespondent"></a>
# **DeleteCorrespondent**
> void DeleteCorrespondent (int id)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DeleteCorrespondentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new CorrespondentsApi(config);
            var id = 56;  // int | 

            try
            {
                apiInstance.DeleteCorrespondent(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CorrespondentsApi.DeleteCorrespondent: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteCorrespondentWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.DeleteCorrespondentWithHttpInfo(id);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CorrespondentsApi.DeleteCorrespondentWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** |  |  |

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

<a id="getcorrespondents"></a>
# **GetCorrespondents**
> void GetCorrespondents ()



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetCorrespondentsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new CorrespondentsApi(config);

            try
            {
                apiInstance.GetCorrespondents();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CorrespondentsApi.GetCorrespondents: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetCorrespondentsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.GetCorrespondentsWithHttpInfo();
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CorrespondentsApi.GetCorrespondentsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
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

<a id="updatecorrespondent"></a>
# **UpdateCorrespondent**
> void UpdateCorrespondent (int id, Correspondent? correspondent = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UpdateCorrespondentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new CorrespondentsApi(config);
            var id = 56;  // int | 
            var correspondent = new Correspondent?(); // Correspondent? |  (optional) 

            try
            {
                apiInstance.UpdateCorrespondent(id, correspondent);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CorrespondentsApi.UpdateCorrespondent: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateCorrespondentWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.UpdateCorrespondentWithHttpInfo(id, correspondent);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CorrespondentsApi.UpdateCorrespondentWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** |  |  |
| **correspondent** | [**Correspondent?**](Correspondent?.md) |  | [optional]  |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/*+json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

