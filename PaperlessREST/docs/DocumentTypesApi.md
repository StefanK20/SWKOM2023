# Org.OpenAPITools.Api.DocumentTypesApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateDocumentType**](DocumentTypesApi.md#createdocumenttype) | **POST** /api/document_types |  |
| [**DeleteDocumentType**](DocumentTypesApi.md#deletedocumenttype) | **DELETE** /api/document_types/{id} |  |
| [**GetDocumentTypes**](DocumentTypesApi.md#getdocumenttypes) | **GET** /api/document_types |  |
| [**UpdateDocumentType**](DocumentTypesApi.md#updatedocumenttype) | **PUT** /api/document_types/{id} |  |

<a id="createdocumenttype"></a>
# **CreateDocumentType**
> void CreateDocumentType (NewDocumentType? newDocumentType = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CreateDocumentTypeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new DocumentTypesApi(config);
            var newDocumentType = new NewDocumentType?(); // NewDocumentType? |  (optional) 

            try
            {
                apiInstance.CreateDocumentType(newDocumentType);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DocumentTypesApi.CreateDocumentType: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateDocumentTypeWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.CreateDocumentTypeWithHttpInfo(newDocumentType);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DocumentTypesApi.CreateDocumentTypeWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **newDocumentType** | [**NewDocumentType?**](NewDocumentType?.md) |  | [optional]  |

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

<a id="deletedocumenttype"></a>
# **DeleteDocumentType**
> void DeleteDocumentType (int id)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DeleteDocumentTypeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new DocumentTypesApi(config);
            var id = 56;  // int | 

            try
            {
                apiInstance.DeleteDocumentType(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DocumentTypesApi.DeleteDocumentType: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteDocumentTypeWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.DeleteDocumentTypeWithHttpInfo(id);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DocumentTypesApi.DeleteDocumentTypeWithHttpInfo: " + e.Message);
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

<a id="getdocumenttypes"></a>
# **GetDocumentTypes**
> void GetDocumentTypes ()



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetDocumentTypesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new DocumentTypesApi(config);

            try
            {
                apiInstance.GetDocumentTypes();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DocumentTypesApi.GetDocumentTypes: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetDocumentTypesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.GetDocumentTypesWithHttpInfo();
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DocumentTypesApi.GetDocumentTypesWithHttpInfo: " + e.Message);
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

<a id="updatedocumenttype"></a>
# **UpdateDocumentType**
> void UpdateDocumentType (int id, DocumentType? documentType = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UpdateDocumentTypeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new DocumentTypesApi(config);
            var id = 56;  // int | 
            var documentType = new DocumentType?(); // DocumentType? |  (optional) 

            try
            {
                apiInstance.UpdateDocumentType(id, documentType);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DocumentTypesApi.UpdateDocumentType: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateDocumentTypeWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.UpdateDocumentTypeWithHttpInfo(id, documentType);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DocumentTypesApi.UpdateDocumentTypeWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** |  |  |
| **documentType** | [**DocumentType?**](DocumentType?.md) |  | [optional]  |

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

