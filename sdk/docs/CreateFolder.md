# Lusid.Drive.Sdk.Model.CreateFolder
DTO representing the creation of a folder

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Path** | **string** | Path of the created folder | 
**Name** | **string** | Name of the created folder | 

```csharp
using Lusid.Drive.Sdk.Model;
using System;

string path = "path";
string name = "name";

CreateFolder createFolderInstance = new CreateFolder(
    path: path,
    name: name);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
