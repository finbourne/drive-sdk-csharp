# Lusid.Drive.Sdk.Api.SearchApi

All URIs are relative to *https://fbn-prd.lusid.com/drive*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**Search**](SearchApi.md#search) | **POST** /api/search | [EARLY ACCESS] Search: Search for a file or folder with a given name and path |

<a id="search"></a>
# **Search**
> PagedResourceListOfStorageObject Search (SearchBody searchBody, string? page = null, List<string>? sortBy = null, int? limit = null, string? filter = null)

[EARLY ACCESS] Search: Search for a file or folder with a given name and path

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
            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<SearchApi>();
            var searchBody = new SearchBody(); // SearchBody | Search parameters
            var page = "page_example";  // string? |  (optional) 
            var sortBy = new List<string>?(); // List<string>? |  (optional) 
            var limit = 56;  // int? |  (optional) 
            var filter = "\"\"";  // string? |  (optional)  (default to "")

            try
            {
                // [EARLY ACCESS] Search: Search for a file or folder with a given name and path
                PagedResourceListOfStorageObject result = apiInstance.Search(searchBody, page, sortBy, limit, filter);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling SearchApi.Search: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the SearchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EARLY ACCESS] Search: Search for a file or folder with a given name and path
    ApiResponse<PagedResourceListOfStorageObject> response = apiInstance.SearchWithHttpInfo(searchBody, page, sortBy, limit, filter);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling SearchApi.SearchWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **searchBody** | [**SearchBody**](SearchBody.md) | Search parameters |  |
| **page** | **string?** |  | [optional]  |
| **sortBy** | [**List&lt;string&gt;?**](string.md) |  | [optional]  |
| **limit** | **int?** |  | [optional]  |
| **filter** | **string?** |  | [optional] [default to &quot;&quot;] |

### Return type

[**PagedResourceListOfStorageObject**](PagedResourceListOfStorageObject.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

