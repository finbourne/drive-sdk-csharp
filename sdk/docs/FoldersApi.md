# Lusid.Drive.Sdk.Api.FoldersApi

All URIs are relative to *https://fbn-prd.lusid.com/drive*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateFolder**](FoldersApi.md#createfolder) | **POST** /api/folders | [EARLY ACCESS] CreateFolder: Create a new folder in LUSID Drive |
| [**DeleteFolder**](FoldersApi.md#deletefolder) | **DELETE** /api/folders/{id} | [EARLY ACCESS] DeleteFolder: Delete a specified folder and all subfolders |
| [**GetFolder**](FoldersApi.md#getfolder) | **GET** /api/folders/{id} | [EARLY ACCESS] GetFolder: Get metadata of folder |
| [**GetFolderContents**](FoldersApi.md#getfoldercontents) | **GET** /api/folders/{id}/contents | GetFolderContents: List contents of a folder |
| [**GetRootFolder**](FoldersApi.md#getrootfolder) | **GET** /api/folders | GetRootFolder: List contents of root folder |
| [**MoveFolder**](FoldersApi.md#movefolder) | **POST** /api/folders/{id} | [EARLY ACCESS] MoveFolder: Move files to specified folder |
| [**UpdateFolder**](FoldersApi.md#updatefolder) | **PUT** /api/folders/{id} | [EARLY ACCESS] UpdateFolder: Update an existing folder&#39;s name, path |

<a id="createfolder"></a>
# **CreateFolder**
> StorageObject CreateFolder (CreateFolder createFolder)

[EARLY ACCESS] CreateFolder: Create a new folder in LUSID Drive

### Example
```csharp
using System.Collections.Generic;
using Lusid.Drive.Sdk.Api;
using Lusid.Drive.Sdk.Client;
using Lusid.Drive.Sdk.Extensions;
using Lusid.Drive.Sdk.Model;
using Newtonsoft.Json;

namespace Examples
{
    public static class Program
    {
        public static void Main()
        {
            var secretsFilename = "secrets.json";
            var path = Path.Combine(Directory.GetCurrentDirectory(), secretsFilename);
            // Replace with the relevant values
            File.WriteAllText(
                path, 
                @"{
                    ""api"": {
                        ""tokenUrl"": ""<your-token-url>"",
                        ""driveUrl"": ""https://<your-domain>.lusid.com/drive"",
                        ""username"": ""<your-username>"",
                        ""password"": ""<your-password>"",
                        ""clientId"": ""<your-client-id>"",
                        ""clientSecret"": ""<your-client-secret>""
                    }
                }");

            // uncomment the below to use configuration overrides
            // var opts = new ConfigurationOptions();
            // opts.TimeoutMs = 30_000;

            // uncomment the below to use an api factory with overrides
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<FoldersApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<FoldersApi>();
            var createFolder = new CreateFolder(); // CreateFolder | A CreateFolder object that defines the name and path of the new folder

            try
            {
                // uncomment the below to set overrides at the request level
                // StorageObject result = apiInstance.CreateFolder(createFolder, opts: opts);

                // [EARLY ACCESS] CreateFolder: Create a new folder in LUSID Drive
                StorageObject result = apiInstance.CreateFolder(createFolder);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling FoldersApi.CreateFolder: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateFolderWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EARLY ACCESS] CreateFolder: Create a new folder in LUSID Drive
    ApiResponse<StorageObject> response = apiInstance.CreateFolderWithHttpInfo(createFolder);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling FoldersApi.CreateFolderWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createFolder** | [**CreateFolder**](CreateFolder.md) | A CreateFolder object that defines the name and path of the new folder |  |

### Return type

[**StorageObject**](StorageObject.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Created |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="deletefolder"></a>
# **DeleteFolder**
> void DeleteFolder (string id)

[EARLY ACCESS] DeleteFolder: Delete a specified folder and all subfolders

### Example
```csharp
using System.Collections.Generic;
using Lusid.Drive.Sdk.Api;
using Lusid.Drive.Sdk.Client;
using Lusid.Drive.Sdk.Extensions;
using Lusid.Drive.Sdk.Model;
using Newtonsoft.Json;

namespace Examples
{
    public static class Program
    {
        public static void Main()
        {
            var secretsFilename = "secrets.json";
            var path = Path.Combine(Directory.GetCurrentDirectory(), secretsFilename);
            // Replace with the relevant values
            File.WriteAllText(
                path, 
                @"{
                    ""api"": {
                        ""tokenUrl"": ""<your-token-url>"",
                        ""driveUrl"": ""https://<your-domain>.lusid.com/drive"",
                        ""username"": ""<your-username>"",
                        ""password"": ""<your-password>"",
                        ""clientId"": ""<your-client-id>"",
                        ""clientSecret"": ""<your-client-secret>""
                    }
                }");

            // uncomment the below to use configuration overrides
            // var opts = new ConfigurationOptions();
            // opts.TimeoutMs = 30_000;

            // uncomment the below to use an api factory with overrides
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<FoldersApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<FoldersApi>();
            var id = "id_example";  // string | Unique ID of the folder

            try
            {
                // uncomment the below to set overrides at the request level
                // apiInstance.DeleteFolder(id, opts: opts);

                // [EARLY ACCESS] DeleteFolder: Delete a specified folder and all subfolders
                apiInstance.DeleteFolder(id);
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling FoldersApi.DeleteFolder: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteFolderWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EARLY ACCESS] DeleteFolder: Delete a specified folder and all subfolders
    apiInstance.DeleteFolderWithHttpInfo(id);
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling FoldersApi.DeleteFolderWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | Unique ID of the folder |  |

### Return type

void (empty response body)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No Content |  -  |
| **400** | The details of the input related failure |  -  |
| **404** | No folder with this Id exists |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="getfolder"></a>
# **GetFolder**
> StorageObject GetFolder (string id)

[EARLY ACCESS] GetFolder: Get metadata of folder

### Example
```csharp
using System.Collections.Generic;
using Lusid.Drive.Sdk.Api;
using Lusid.Drive.Sdk.Client;
using Lusid.Drive.Sdk.Extensions;
using Lusid.Drive.Sdk.Model;
using Newtonsoft.Json;

namespace Examples
{
    public static class Program
    {
        public static void Main()
        {
            var secretsFilename = "secrets.json";
            var path = Path.Combine(Directory.GetCurrentDirectory(), secretsFilename);
            // Replace with the relevant values
            File.WriteAllText(
                path, 
                @"{
                    ""api"": {
                        ""tokenUrl"": ""<your-token-url>"",
                        ""driveUrl"": ""https://<your-domain>.lusid.com/drive"",
                        ""username"": ""<your-username>"",
                        ""password"": ""<your-password>"",
                        ""clientId"": ""<your-client-id>"",
                        ""clientSecret"": ""<your-client-secret>""
                    }
                }");

            // uncomment the below to use configuration overrides
            // var opts = new ConfigurationOptions();
            // opts.TimeoutMs = 30_000;

            // uncomment the below to use an api factory with overrides
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<FoldersApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<FoldersApi>();
            var id = "id_example";  // string | Unique ID of the folder

            try
            {
                // uncomment the below to set overrides at the request level
                // StorageObject result = apiInstance.GetFolder(id, opts: opts);

                // [EARLY ACCESS] GetFolder: Get metadata of folder
                StorageObject result = apiInstance.GetFolder(id);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling FoldersApi.GetFolder: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetFolderWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EARLY ACCESS] GetFolder: Get metadata of folder
    ApiResponse<StorageObject> response = apiInstance.GetFolderWithHttpInfo(id);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling FoldersApi.GetFolderWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | Unique ID of the folder |  |

### Return type

[**StorageObject**](StorageObject.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | The details of the input related failure |  -  |
| **404** | No folder with this Id exists |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="getfoldercontents"></a>
# **GetFolderContents**
> PagedResourceListOfStorageObject GetFolderContents (string id, string? page = null, List<string>? sortBy = null, int? start = null, int? limit = null, string? filter = null)

GetFolderContents: List contents of a folder

### Example
```csharp
using System.Collections.Generic;
using Lusid.Drive.Sdk.Api;
using Lusid.Drive.Sdk.Client;
using Lusid.Drive.Sdk.Extensions;
using Lusid.Drive.Sdk.Model;
using Newtonsoft.Json;

namespace Examples
{
    public static class Program
    {
        public static void Main()
        {
            var secretsFilename = "secrets.json";
            var path = Path.Combine(Directory.GetCurrentDirectory(), secretsFilename);
            // Replace with the relevant values
            File.WriteAllText(
                path, 
                @"{
                    ""api"": {
                        ""tokenUrl"": ""<your-token-url>"",
                        ""driveUrl"": ""https://<your-domain>.lusid.com/drive"",
                        ""username"": ""<your-username>"",
                        ""password"": ""<your-password>"",
                        ""clientId"": ""<your-client-id>"",
                        ""clientSecret"": ""<your-client-secret>""
                    }
                }");

            // uncomment the below to use configuration overrides
            // var opts = new ConfigurationOptions();
            // opts.TimeoutMs = 30_000;

            // uncomment the below to use an api factory with overrides
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<FoldersApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<FoldersApi>();
            var id = "id_example";  // string | Unique ID of the folder
            var page = "page_example";  // string? | The pagination token to use to continue listing contents from a previous call to list contents.              This value is returned from the previous call. If a pagination token is provided the sortBy and filter fields              must not have changed since the original request. Also, if set, a start value cannot be provided. (optional) 
            var sortBy = new List<string>?(); // List<string>? | Order the results by these fields. Use use the '-' sign to denote descending order. (optional) 
            var start = 56;  // int? | When paginating, skip this number of results. (optional) 
            var limit = 56;  // int? | When paginating, limit the number of returned results to this many. (optional) 
            var filter = "\"\"";  // string? | Expression to filter the result set. (optional)  (default to "")

            try
            {
                // uncomment the below to set overrides at the request level
                // PagedResourceListOfStorageObject result = apiInstance.GetFolderContents(id, page, sortBy, start, limit, filter, opts: opts);

                // GetFolderContents: List contents of a folder
                PagedResourceListOfStorageObject result = apiInstance.GetFolderContents(id, page, sortBy, start, limit, filter);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling FoldersApi.GetFolderContents: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetFolderContentsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // GetFolderContents: List contents of a folder
    ApiResponse<PagedResourceListOfStorageObject> response = apiInstance.GetFolderContentsWithHttpInfo(id, page, sortBy, start, limit, filter);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling FoldersApi.GetFolderContentsWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | Unique ID of the folder |  |
| **page** | **string?** | The pagination token to use to continue listing contents from a previous call to list contents.              This value is returned from the previous call. If a pagination token is provided the sortBy and filter fields              must not have changed since the original request. Also, if set, a start value cannot be provided. | [optional]  |
| **sortBy** | [**List&lt;string&gt;?**](string.md) | Order the results by these fields. Use use the &#39;-&#39; sign to denote descending order. | [optional]  |
| **start** | **int?** | When paginating, skip this number of results. | [optional]  |
| **limit** | **int?** | When paginating, limit the number of returned results to this many. | [optional]  |
| **filter** | **string?** | Expression to filter the result set. | [optional] [default to &quot;&quot;] |

### Return type

[**PagedResourceListOfStorageObject**](PagedResourceListOfStorageObject.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | The details of the input related failure |  -  |
| **404** | No folder with this Id exists |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="getrootfolder"></a>
# **GetRootFolder**
> PagedResourceListOfStorageObject GetRootFolder (string? page = null, List<string>? sortBy = null, int? start = null, int? limit = null, string? filter = null)

GetRootFolder: List contents of root folder

### Example
```csharp
using System.Collections.Generic;
using Lusid.Drive.Sdk.Api;
using Lusid.Drive.Sdk.Client;
using Lusid.Drive.Sdk.Extensions;
using Lusid.Drive.Sdk.Model;
using Newtonsoft.Json;

namespace Examples
{
    public static class Program
    {
        public static void Main()
        {
            var secretsFilename = "secrets.json";
            var path = Path.Combine(Directory.GetCurrentDirectory(), secretsFilename);
            // Replace with the relevant values
            File.WriteAllText(
                path, 
                @"{
                    ""api"": {
                        ""tokenUrl"": ""<your-token-url>"",
                        ""driveUrl"": ""https://<your-domain>.lusid.com/drive"",
                        ""username"": ""<your-username>"",
                        ""password"": ""<your-password>"",
                        ""clientId"": ""<your-client-id>"",
                        ""clientSecret"": ""<your-client-secret>""
                    }
                }");

            // uncomment the below to use configuration overrides
            // var opts = new ConfigurationOptions();
            // opts.TimeoutMs = 30_000;

            // uncomment the below to use an api factory with overrides
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<FoldersApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<FoldersApi>();
            var page = "page_example";  // string? | The pagination token to use to continue listing contents from a previous call to list contents.              This value is returned from the previous call. If a pagination token is provided the sortBy and filter fields              must not have changed since the original request. Also, if set, a start value cannot be provided. (optional) 
            var sortBy = new List<string>?(); // List<string>? | Order the results by these fields. Use use the '-' sign to denote descending order. (optional) 
            var start = 56;  // int? | When paginating, skip this number of results. (optional) 
            var limit = 56;  // int? | When paginating, limit the number of returned results to this many. (optional) 
            var filter = "\"true\"";  // string? | Expression to filter the result set. (optional)  (default to "true")

            try
            {
                // uncomment the below to set overrides at the request level
                // PagedResourceListOfStorageObject result = apiInstance.GetRootFolder(page, sortBy, start, limit, filter, opts: opts);

                // GetRootFolder: List contents of root folder
                PagedResourceListOfStorageObject result = apiInstance.GetRootFolder(page, sortBy, start, limit, filter);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling FoldersApi.GetRootFolder: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetRootFolderWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // GetRootFolder: List contents of root folder
    ApiResponse<PagedResourceListOfStorageObject> response = apiInstance.GetRootFolderWithHttpInfo(page, sortBy, start, limit, filter);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling FoldersApi.GetRootFolderWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **page** | **string?** | The pagination token to use to continue listing contents from a previous call to list contents.              This value is returned from the previous call. If a pagination token is provided the sortBy and filter fields              must not have changed since the original request. Also, if set, a start value cannot be provided. | [optional]  |
| **sortBy** | [**List&lt;string&gt;?**](string.md) | Order the results by these fields. Use use the &#39;-&#39; sign to denote descending order. | [optional]  |
| **start** | **int?** | When paginating, skip this number of results. | [optional]  |
| **limit** | **int?** | When paginating, limit the number of returned results to this many. | [optional]  |
| **filter** | **string?** | Expression to filter the result set. | [optional] [default to &quot;true&quot;] |

### Return type

[**PagedResourceListOfStorageObject**](PagedResourceListOfStorageObject.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="movefolder"></a>
# **MoveFolder**
> PagedResourceListOfStorageObject MoveFolder (string id, List<string> requestBody, bool? overwrite = null, bool? deleteSource = null)

[EARLY ACCESS] MoveFolder: Move files to specified folder

### Example
```csharp
using System.Collections.Generic;
using Lusid.Drive.Sdk.Api;
using Lusid.Drive.Sdk.Client;
using Lusid.Drive.Sdk.Extensions;
using Lusid.Drive.Sdk.Model;
using Newtonsoft.Json;

namespace Examples
{
    public static class Program
    {
        public static void Main()
        {
            var secretsFilename = "secrets.json";
            var path = Path.Combine(Directory.GetCurrentDirectory(), secretsFilename);
            // Replace with the relevant values
            File.WriteAllText(
                path, 
                @"{
                    ""api"": {
                        ""tokenUrl"": ""<your-token-url>"",
                        ""driveUrl"": ""https://<your-domain>.lusid.com/drive"",
                        ""username"": ""<your-username>"",
                        ""password"": ""<your-password>"",
                        ""clientId"": ""<your-client-id>"",
                        ""clientSecret"": ""<your-client-secret>""
                    }
                }");

            // uncomment the below to use configuration overrides
            // var opts = new ConfigurationOptions();
            // opts.TimeoutMs = 30_000;

            // uncomment the below to use an api factory with overrides
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<FoldersApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<FoldersApi>();
            var id = "id_example";  // string | Unique ID of the folder where the files should be moved
            var requestBody = new List<string>(); // List<string> | Enumerable of unique IDs of files that should be moved
            var overwrite = false;  // bool? | True if the destination has file with same name if should be overwritten (optional)  (default to false)
            var deleteSource = false;  // bool? | If true after moving the original file is deleted (optional)  (default to false)

            try
            {
                // uncomment the below to set overrides at the request level
                // PagedResourceListOfStorageObject result = apiInstance.MoveFolder(id, requestBody, overwrite, deleteSource, opts: opts);

                // [EARLY ACCESS] MoveFolder: Move files to specified folder
                PagedResourceListOfStorageObject result = apiInstance.MoveFolder(id, requestBody, overwrite, deleteSource);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling FoldersApi.MoveFolder: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the MoveFolderWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EARLY ACCESS] MoveFolder: Move files to specified folder
    ApiResponse<PagedResourceListOfStorageObject> response = apiInstance.MoveFolderWithHttpInfo(id, requestBody, overwrite, deleteSource);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling FoldersApi.MoveFolderWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | Unique ID of the folder where the files should be moved |  |
| **requestBody** | [**List&lt;string&gt;**](string.md) | Enumerable of unique IDs of files that should be moved |  |
| **overwrite** | **bool?** | True if the destination has file with same name if should be overwritten | [optional] [default to false] |
| **deleteSource** | **bool?** | If true after moving the original file is deleted | [optional] [default to false] |

### Return type

[**PagedResourceListOfStorageObject**](PagedResourceListOfStorageObject.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | The details of the input related failure |  -  |
| **404** | No folder or file with the supplied Id exists |  -  |
| **409** | There is already a file with the same name at this location |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="updatefolder"></a>
# **UpdateFolder**
> StorageObject UpdateFolder (string id, UpdateFolder updateFolder)

[EARLY ACCESS] UpdateFolder: Update an existing folder's name, path

### Example
```csharp
using System.Collections.Generic;
using Lusid.Drive.Sdk.Api;
using Lusid.Drive.Sdk.Client;
using Lusid.Drive.Sdk.Extensions;
using Lusid.Drive.Sdk.Model;
using Newtonsoft.Json;

namespace Examples
{
    public static class Program
    {
        public static void Main()
        {
            var secretsFilename = "secrets.json";
            var path = Path.Combine(Directory.GetCurrentDirectory(), secretsFilename);
            // Replace with the relevant values
            File.WriteAllText(
                path, 
                @"{
                    ""api"": {
                        ""tokenUrl"": ""<your-token-url>"",
                        ""driveUrl"": ""https://<your-domain>.lusid.com/drive"",
                        ""username"": ""<your-username>"",
                        ""password"": ""<your-password>"",
                        ""clientId"": ""<your-client-id>"",
                        ""clientSecret"": ""<your-client-secret>""
                    }
                }");

            // uncomment the below to use configuration overrides
            // var opts = new ConfigurationOptions();
            // opts.TimeoutMs = 30_000;

            // uncomment the below to use an api factory with overrides
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<FoldersApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<FoldersApi>();
            var id = "id_example";  // string | Unique ID of the folder
            var updateFolder = new UpdateFolder(); // UpdateFolder | An UpdateFolder object that defines the new name or path of the folder

            try
            {
                // uncomment the below to set overrides at the request level
                // StorageObject result = apiInstance.UpdateFolder(id, updateFolder, opts: opts);

                // [EARLY ACCESS] UpdateFolder: Update an existing folder's name, path
                StorageObject result = apiInstance.UpdateFolder(id, updateFolder);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling FoldersApi.UpdateFolder: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateFolderWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EARLY ACCESS] UpdateFolder: Update an existing folder's name, path
    ApiResponse<StorageObject> response = apiInstance.UpdateFolderWithHttpInfo(id, updateFolder);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling FoldersApi.UpdateFolderWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | Unique ID of the folder |  |
| **updateFolder** | [**UpdateFolder**](UpdateFolder.md) | An UpdateFolder object that defines the new name or path of the folder |  |

### Return type

[**StorageObject**](StorageObject.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | The details of the input related failure |  -  |
| **404** | No folder with this Id exists |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

