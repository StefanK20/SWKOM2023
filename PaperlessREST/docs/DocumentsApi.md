# Org.OpenAPITools.Api.DocumentsApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**DeleteDocument**](DocumentsApi.md#deletedocument) | **DELETE** /api/documents/{id} |  |
| [**DownloadDocument**](DocumentsApi.md#downloaddocument) | **GET** /api/documents/{id}/download |  |
| [**GetDocumentMetadata**](DocumentsApi.md#getdocumentmetadata) | **GET** /api/documents/{id}/metadata |  |
| [**GetDocumentPreview**](DocumentsApi.md#getdocumentpreview) | **GET** /api/documents/{id}/preview |  |
| [**GetDocumentThumb**](DocumentsApi.md#getdocumentthumb) | **GET** /api/documents/{id}/thumb |  |
| [**GetDocuments**](DocumentsApi.md#getdocuments) | **GET** /api/documents |  |
| [**UpdateDocument**](DocumentsApi.md#updatedocument) | **PUT** /api/documents/{id} |  |
| [**UploadDocument**](DocumentsApi.md#uploaddocument) | **POST** /api/documents/post_document |  |

<a id="deletedocument"></a>
# **DeleteDocument**
> void DeleteDocument (int id)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DeleteDocumentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new DocumentsApi(config);
            var id = 56;  // int | 

            try
            {
                apiInstance.DeleteDocument(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DocumentsApi.DeleteDocument: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteDocumentWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.DeleteDocumentWithHttpInfo(id);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DocumentsApi.DeleteDocumentWithHttpInfo: " + e.Message);
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

<a id="downloaddocument"></a>
# **DownloadDocument**
> void DownloadDocument (int id, bool? original = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DownloadDocumentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new DocumentsApi(config);
            var id = 56;  // int | 
            var original = true;  // bool? |  (optional) 

            try
            {
                apiInstance.DownloadDocument(id, original);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DocumentsApi.DownloadDocument: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DownloadDocumentWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.DownloadDocumentWithHttpInfo(id, original);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DocumentsApi.DownloadDocumentWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** |  |  |
| **original** | **bool?** |  | [optional]  |

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

<a id="getdocumentmetadata"></a>
# **GetDocumentMetadata**
> void GetDocumentMetadata (int id)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetDocumentMetadataExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new DocumentsApi(config);
            var id = 56;  // int | 

            try
            {
                apiInstance.GetDocumentMetadata(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DocumentsApi.GetDocumentMetadata: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetDocumentMetadataWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.GetDocumentMetadataWithHttpInfo(id);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DocumentsApi.GetDocumentMetadataWithHttpInfo: " + e.Message);
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

<a id="getdocumentpreview"></a>
# **GetDocumentPreview**
> void GetDocumentPreview (int id)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetDocumentPreviewExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new DocumentsApi(config);
            var id = 56;  // int | 

            try
            {
                apiInstance.GetDocumentPreview(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DocumentsApi.GetDocumentPreview: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetDocumentPreviewWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.GetDocumentPreviewWithHttpInfo(id);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DocumentsApi.GetDocumentPreviewWithHttpInfo: " + e.Message);
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

<a id="getdocumentthumb"></a>
# **GetDocumentThumb**
> void GetDocumentThumb (int id)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetDocumentThumbExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new DocumentsApi(config);
            var id = 56;  // int | 

            try
            {
                apiInstance.GetDocumentThumb(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DocumentsApi.GetDocumentThumb: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetDocumentThumbWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.GetDocumentThumbWithHttpInfo(id);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DocumentsApi.GetDocumentThumbWithHttpInfo: " + e.Message);
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

<a id="getdocuments"></a>
# **GetDocuments**
> void GetDocuments (int? page = null, int? pageSize = null, string? query = null, string? ordering = null, List<int>? tagsIdAll = null, int? documentTypeId = null, int? correspondentId = null, bool? truncateContent = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetDocumentsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new DocumentsApi(config);
            var page = 56;  // int? |  (optional) 
            var pageSize = 56;  // int? |  (optional) 
            var query = "query_example";  // string? |  (optional) 
            var ordering = "ordering_example";  // string? |  (optional) 
            var tagsIdAll = new List<int>?(); // List<int>? |  (optional) 
            var documentTypeId = 56;  // int? |  (optional) 
            var correspondentId = 56;  // int? |  (optional) 
            var truncateContent = true;  // bool? |  (optional) 

            try
            {
                apiInstance.GetDocuments(page, pageSize, query, ordering, tagsIdAll, documentTypeId, correspondentId, truncateContent);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DocumentsApi.GetDocuments: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetDocumentsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.GetDocumentsWithHttpInfo(page, pageSize, query, ordering, tagsIdAll, documentTypeId, correspondentId, truncateContent);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DocumentsApi.GetDocumentsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **page** | **int?** |  | [optional]  |
| **pageSize** | **int?** |  | [optional]  |
| **query** | **string?** |  | [optional]  |
| **ordering** | **string?** |  | [optional]  |
| **tagsIdAll** | [**List&lt;int&gt;?**](int.md) |  | [optional]  |
| **documentTypeId** | **int?** |  | [optional]  |
| **correspondentId** | **int?** |  | [optional]  |
| **truncateContent** | **bool?** |  | [optional]  |

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

<a id="updatedocument"></a>
# **UpdateDocument**
> void UpdateDocument (int id, Document? document = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UpdateDocumentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new DocumentsApi(config);
            var id = 56;  // int | 
            var document = new Document?(); // Document? |  (optional) 

            try
            {
                apiInstance.UpdateDocument(id, document);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DocumentsApi.UpdateDocument: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateDocumentWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.UpdateDocumentWithHttpInfo(id, document);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DocumentsApi.UpdateDocumentWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** |  |  |
| **document** | [**Document?**](Document?.md) |  | [optional]  |

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

<a id="uploaddocument"></a>
# **UploadDocument**
> void UploadDocument (string? title = null, DateTime? created = null, int? documentType = null, List<int>? tags = null, int? correspondent = null, List<System.IO.Stream>? document = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UploadDocumentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new DocumentsApi(config);
            var title = "title_example";  // string? |  (optional) 
            var created = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? |  (optional) 
            var documentType = 56;  // int? |  (optional) 
            var tags = new List<int>?(); // List<int>? |  (optional) 
            var correspondent = 56;  // int? |  (optional) 
            var document = new List<System.IO.Stream>?(); // List<System.IO.Stream>? |  (optional) 

            try
            {
                apiInstance.UploadDocument(title, created, documentType, tags, correspondent, document);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DocumentsApi.UploadDocument: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UploadDocumentWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.UploadDocumentWithHttpInfo(title, created, documentType, tags, correspondent, document);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DocumentsApi.UploadDocumentWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **title** | **string?** |  | [optional]  |
| **created** | **DateTime?** |  | [optional]  |
| **documentType** | **int?** |  | [optional]  |
| **tags** | [**List&lt;int&gt;?**](int.md) |  | [optional]  |
| **correspondent** | **int?** |  | [optional]  |
| **document** | **List&lt;System.IO.Stream&gt;?** |  | [optional]  |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

