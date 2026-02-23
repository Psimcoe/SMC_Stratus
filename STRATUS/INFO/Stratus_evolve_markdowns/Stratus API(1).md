---
created: 2026-01-28T22:23:37 (UTC -05:00)
tags: []
source: https://api.gtpstratus.com/index.html
author: Authorize
---

# Stratus API

> ## Excerpt
> Activity NameDescriptioninclude(query)A comma delimited list of JSON properties to return. All remaining JSON properties will removed from the JSON response. Example: id, description, cutListItems. Specific dictionary keys can be included as follows: properties["Family"], propertiesGtp["Material"]where(query)Filter on JSON property values. Example: To filter on two JSON properties: length eq '10' AND description == "truck". To get the last 30 days of data, use: createdDT ge DateTime.Now.AddDays(-30)page(query)Offset retrieves a given page of data, where 0 is the 1st page, etc (number of elements per page is set by PageSize below)pagesize(query)Optional: defines the number of elements per page (default (and max) is 1000)disabletotal(query)Optional: disable total calculation to improve performance (default is false)CodeDescriptionLinks200OKMedia typeControls Accept header.{
  "data": [
    {
      "id": "string",
      "createdDT": "2026-01-29T03:23:16.130Z",
      "createdById": "string",
      "createdByName": "string",
      "divisionId": "string",
      "divisionName": "string",
      "route": "string",
      "projectId": "string",
      "projectName": "string",
      "projectNumber": "string",
      "projectColor": "string",
      "modelId": "string",
      "modelName": "string",
      "reference": "0 = Unspecified",
      "referenceId": "string",
      "referenceName": "string",
      "action": "0 = Unspecified",
      "actionName": "string",
      "name": "string",
      "value": "string",
      "trackingStatusId": "string",
      "trackingStatusName": "string",
      "trackingStatusColor": "string",
      "stationId": "string",
      "stationName": "string"
    }
  ],
  "pageOffset": 0,
  "pageLimit": 0,
  "pageCount": 0,
  "total": 0,
  "truncatedResults": true,
  "truncatedReason": "string",
  "filterOptions": [
    {
      "isValueConcatenated": true,
      "data": "string",
      "options": [
        "string"
      ]
    }
  ],
  "links": {
    "additionalProp1": "string",
    "additionalProp2": "string",
    "additionalProp3": "string"
  }
}No links400Bad RequestNo links401UnauthorizedNo links404Not FoundNo links500Internal Server ErrorNo links Assembly NameDescriptionid *string(path)STRATUS Assembly Idinclude(query)A comma delimited list of JSON properties to return. All remaining JSON properties will removed from the JSON response. Example: id, description, cutListItems. Specific dictionary keys can be included as follows: properties["Family"], propertiesGtp["Material"]CodeDescriptionLinks200OKMedia typeControls Accept header.[
  {
    "id": "string",
    "projectId": "string",
    "modelId": "string",
    "stratusDimensionType": "0 = AliasTag",
    "orderId": "string",
    "assemblyId": "string",
    "partCadIds": [
      "string"
    ],
    "colorIndex": 0,
    "dimensionLineType": "0 = LabelOnly",
    "connectedAssemblyId": "string",
    "distance": 0,
    "label": "string",
    "lineVertices": [
      {
        "x": 0,
        "y": 0,
        "z": 0
      }
    ],
    "location": {
      "x": 0,
      "y": 0,
      "z": 0
    },
    "gridlineAnnotation": "string",
    "dimensionAnchorTypes": [
      {
        "location": {
          "x": 0,
          "y": 0,
          "z": 0
        },
        "partPointType": "0 = Unspecified"
      }
    ]
  }
]No links400Bad RequestNo links401UnauthorizedNo links404Not FoundNo links500Internal Server ErrorNo linksNameDescriptionid *string(path)STRATUS Assembly Idinclude(query)A comma delimited list of JSON properties to return. All remaining JSON properties will removed from the JSON response. Example: id, description, cutListItems. Specific dictionary keys can be included as follows: properties["Family"], propertiesGtp["Material"]where(query)Filter on JSON property values. Example: To filter on two JSON properties: length eq '10' AND description == "truck". To get the last 30 days of data, use: createdDT ge DateTime.Now.AddDays(-30)page(query)Offset retrieves a given page of data, where 0 is the 1st page, etc (number of elements per page is set by PageSize below)pagesize(query)Optional: defines the number of elements per page (default (and max) is 1000)disabletotal(query)Optional: disable total calculation to improve performance (default is false)CodeDescriptionLinks200OKMedia typeControls Accept header.{
  "data": [
    {
      "id": "string",
      "createdById": "string",
      "createdDT": "2026-01-29T03:23:16.234Z",
      "projectId": "string",
      "modelId": "string",
      "referenceType": "0 = Unspecified",
      "referenceName": "string",
      "referenceId": "string",
      "role": "0 = Unspecified",
      "roleName": "string",
      "fileType": "0 = Unspecified",
      "fileTypeName": "string",
      "localFilePath": "string",
      "fileName": "string",
      "overriddenRemoteFolder": "string"
    }
  ],
  "pageOffset": 0,
  "pageLimit": 0,
  "pageCount": 0,
  "total": 0,
  "truncatedResults": true,
  "truncatedReason": "string",
  "filterOptions": [
    {
      "isValueConcatenated": true,
      "data": "string",
      "options": [
        "string"
      ]
    }
  ],
  "links": {
    "additionalProp1": "string",
    "additionalProp2": "string",
    "additionalProp3": "string"
  }
}No links400Bad RequestNo links401UnauthorizedNo links404Not FoundNo links500Internal Server ErrorNo linksNameDescriptionid *string(path)STRATUS Assembly IdincludeStratusPropertiesboolean(query)Pass true to this optional query parameter if you want to generate STRATUS.Part.* properties and have them returned for the parts.Default value : falseexcludeNullAndEmptyboolean(query)Pass true to this optional query parameter if you want empty or null values removed from the part's Properties and PropertiesGtp collections to improve performance.Default value : falseinclude(query)A comma delimited list of JSON properties to return. All remaining JSON properties will removed from the JSON response. Example: id, description, cutListItems. Specific dictionary keys can be included as follows: properties["Family"], propertiesGtp["Material"]where(query)Filter on JSON property values. Example: To filter on two JSON properties: length eq '10' AND description == "truck". To get the last 30 days of data, use: createdDT ge DateTime.Now.AddDays(-30)page(query)Offset retrieves a given page of data, where 0 is the 1st page, etc (number of elements per page is set by PageSize below)pagesize(query)Optional: defines the number of elements per page (default (and max) is 100)disabletotal(query)Optional: disable total calculation to improve performance (default is false)CodeDescriptionLinks200OKMedia typeControls Accept header.{
  "data": [
    {
      "id": "string",
      "createdDT": "2026-01-29T03:23:16.313Z",
      "modifiedDT": "2026-01-29T03:23:16.313Z",
      "cutDT": "2026-01-29T03:23:16.313Z",
      "projectId": "string",
      "projectName": "string",
      "projectNumber": "string",
      "modelId": "string",
      "modelName": "string",
      "bimAreaId": "string",
      "bimArea": "string",
      "cadId": "string",
      "cadType": "string",
      "webId": "string",
      "description": "string",
      "currentTrackingStatusId": "string",
      "currentDivisionId": "string",
      "properties": {
        "additionalProp1": "string",
        "additionalProp2": "string",
        "additionalProp3": "string"
      },
      "propertiesGtp": {
        "additionalProp1": "string",
        "additionalProp2": "string",
        "additionalProp3": "string"
      },
      "points": [
        {
          "pointType": "0 = Unspecified",
          "cadId": "string",
          "location": {
            "x": 0,
            "y": 0,
            "z": 0
          },
          "direction": {
            "x": 0,
            "y": 0,
            "z": 0
          },
          "upVector": {
            "x": 0,
            "y": 0,
            "z": 0
          },
          "width": 0,
          "height": 0,
          "matingElementUniqueId": "string"
        }
      ],
      "cutLengthAdjustment": 0,
      "cutLength2Adjustment": 0,
      "lockLength": true,
      "lockLocation": true,
      "qrCodeUrl": "string",
      "partUrl": "string",
      "patternNumber": "string",
      "source": "0 = PublishedModel",
      "fieldIdToValueMap": {
        "additionalProp1": "string",
        "additionalProp2": "string",
        "additionalProp3": "string"
      },
      "fieldNameToValueMap": {
        "additionalProp1": "string",
        "additionalProp2": "string",
        "additionalProp3": "string"
      }
    }
  ],
  "pageOffset": 0,
  "pageLimit": 0,
  "pageCount": 0,
  "total": 0,
  "truncatedResults": true,
  "truncatedReason": "string",
  "filterOptions": [
    {
      "isValueConcatenated": true,
      "data": "string",
      "options": [
        "string"
      ]
    }
  ],
  "links": {
    "additionalProp1": "string",
    "additionalProp2": "string",
    "additionalProp3": "string"
  }
}No links400Bad RequestNo links401UnauthorizedNo links404Not FoundNo links500Internal Server ErrorNo linksNameDescriptionqrcode *string(path)The decoded text from a STRATUS QR Code -- being a URL or just the last eight characters of the URL.include(query)A comma delimited list of JSON properties to return. All remaining JSON properties will removed from the JSON response. Example: id, description, cutListItems. Specific dictionary keys can be included as follows: properties["Family"], propertiesGtp["Material"]CodeDescriptionLinks200OKMedia typeControls Accept header.{
  "id": "string",
  "createdDT": "2026-01-29T03:23:16.352Z",
  "modifiedDT": "2026-01-29T03:23:16.352Z",
  "projectId": "string",
  "modelId": "string",
  "cadId": "string",
  "sheetId": "string",
  "viewId": "string",
  "isViewIdOverridden": true,
  "currentTrackingStatusId": "string",
  "currentDivisionId": "string",
  "assemblyType": "0 = Unspecified",
  "assemblyTypeLabel": "string",
  "excludedCadIds": [
    "string"
  ],
  "fieldIdToValueMap": {
    "additionalProp1": "string",
    "additionalProp2": "string",
    "additionalProp3": "string"
  },
  "fieldNameToValueMap": {
    "additionalProp1": "string",
    "additionalProp2": "string",
    "additionalProp3": "string"
  },
  "name": "string",
  "nameLabel": "string",
  "partIds": [
    "string"
  ],
  "instanceIndex": "string",
  "lastUsedAssembliesPartsTableReportIds": [
    "string"
  ],
  "qrCodeUrl": "string",
  "notes": [
    {
      "isPartialData": true,
      "isReadOnly": true,
      "id": "string",
      "createdDT": "2026-01-29T03:23:16.352Z",
      "createdById": "string",
      "modifiedDT": "2026-01-29T03:23:16.352Z",
      "modifiedById": "string",
      "name": "string"
    }
  ],
  "defaultOrientationForReportTemplatesForgeViewerViewJson": {
    "additionalProp1": "string",
    "additionalProp2": "string",
    "additionalProp3": "string"
  }
}No links400Bad RequestNo links401UnauthorizedNo links404Not FoundNo links500Internal Server ErrorNo linksNameDescriptionid *string(path)STRATUS Assembly IdtrackingLogEntryIdstring(query)Optional TrackingLogEntry Id to associate Attachment with a TrackingLogEntryCodeDescriptionLinks200OKMedia typeControls Accept header.{
  "id": "string",
  "createdById": "string",
  "createdDT": "2026-01-29T03:23:16.394Z",
  "projectId": "string",
  "modelId": "string",
  "referenceType": "0 = Unspecified",
  "referenceName": "string",
  "referenceId": "string",
  "role": "0 = Unspecified",
  "roleName": "string",
  "fileType": "0 = Unspecified",
  "fileTypeName": "string",
  "localFilePath": "string",
  "fileName": "string",
  "overriddenRemoteFolder": "string"
}No links400Bad RequestNo links401UnauthorizedNo links404Not FoundNo links500Internal Server ErrorNo linksNameDescriptionid *string(path)STRATUS Assembly IdREQUIRED: TrackingStatusId{
  "comment": "string",
  "costTypeId": "string",
  "createdDT": "2026-01-29T03:23:16.444Z",
  "divisionId": "string",
  "hours": 0,
  "trackingLogEntryIdResult": "string",
  "trackingStatusId": "string"
}CodeDescriptionLinks200OKMedia typeControls Accept header.{
  "comment": "string",
  "costTypeId": "string",
  "createdDT": "2026-01-29T03:23:16.452Z",
  "divisionId": "string",
  "hours": 0,
  "trackingLogEntryIdResult": "string",
  "trackingStatusId": "string"
}No links400Bad RequestNo links401UnauthorizedNo links404Not FoundNo links500Internal Server ErrorNo linksNameDescriptionid *string(path)STRATUS Assembly IdArray of Part CadIds used to replace existing.CodeDescriptionLinks200OKMedia typeControls Accept header.{
  "id": "string",
  "createdDT": "2026-01-29T03:23:16.506Z",
  "modifiedDT": "2026-01-29T03:23:16.506Z",
  "projectId": "string",
  "modelId": "string",
  "cadId": "string",
  "sheetId": "string",
  "viewId": "string",
  "isViewIdOverridden": true,
  "currentTrackingStatusId": "string",
  "currentDivisionId": "string",
  "assemblyType": "0 = Unspecified",
  "assemblyTypeLabel": "string",
  "excludedCadIds": [
    "string"
  ],
  "fieldIdToValueMap": {
    "additionalProp1": "string",
    "additionalProp2": "string",
    "additionalProp3": "string"
  },
  "fieldNameToValueMap": {
    "additionalProp1": "string",
    "additionalProp2": "string",
    "additionalProp3": "string"
  },
  "name": "string",
  "nameLabel": "string",
  "partIds": [
    "string"
  ],
  "instanceIndex": "string",
  "lastUsedAssembliesPartsTableReportIds": [
    "string"
  ],
  "qrCodeUrl": "string",
  "notes": [
    {
      "isPartialData": true,
      "isReadOnly": true,
      "id": "string",
      "createdDT": "2026-01-29T03:23:16.506Z",
      "createdById": "string",
      "modifiedDT": "2026-01-29T03:23:16.506Z",
      "modifiedById": "string",
      "name": "string"
    }
  ],
  "defaultOrientationForReportTemplatesForgeViewerViewJson": {
    "additionalProp1": "string",
    "additionalProp2": "string",
    "additionalProp3": "string"
  }
}No links400Bad RequestNo links401UnauthorizedNo links404Not FoundNo links500Internal Server ErrorNo linksNameDescriptionid *string(path)STRATUS Assembly IdExample JSON KeyValuePair: {
  "key": "string",
  "value": "string"
}CodeDescriptionLinks200OKMedia typeControls Accept header.{
  "key": "string",
  "value": "string"
}No links400Bad RequestNo links401UnauthorizedNo links404Not FoundNo links500Internal Server ErrorNo linksNameDescriptionid *string(path)STRATUS Assembly IdExample JSON Array of KeyValuePair: [,,...][
  {
    "key": "string",
    "value": "string"
  }
]CodeDescriptionLinks200OKMedia typeControls Accept header.0No links400Bad RequestNo links401UnauthorizedNo links404Not FoundNo links500Internal Server ErrorNo linksNameDescriptionid *string(path)STRATUS Assembly IdArray of Part CadIds used to add.CodeDescriptionLinks200OKMedia typeControls Accept header.{
  "id": "string",
  "createdDT": "2026-01-29T03:23:16.654Z",
  "modifiedDT": "2026-01-29T03:23:16.654Z",
  "projectId": "string",
  "modelId": "string",
  "cadId": "string",
  "sheetId": "string",
  "viewId": "string",
  "isViewIdOverridden": true,
  "currentTrackingStatusId": "string",
  "currentDivisionId": "string",
  "assemblyType": "0 = Unspecified",
  "assemblyTypeLabel": "string",
  "excludedCadIds": [
    "string"
  ],
  "fieldIdToValueMap": {
    "additionalProp1": "string",
    "additionalProp2": "string",
    "additionalProp3": "string"
  },
  "fieldNameToValueMap": {
    "additionalProp1": "string",
    "additionalProp2": "string",
    "additionalProp3": "string"
  },
  "name": "string",
  "nameLabel": "string",
  "partIds": [
    "string"
  ],
  "instanceIndex": "string",
  "lastUsedAssembliesPartsTableReportIds": [
    "string"
  ],
  "qrCodeUrl": "string",
  "notes": [
    {
      "isPartialData": true,
      "isReadOnly": true,
      "id": "string",
      "createdDT": "2026-01-29T03:23:16.654Z",
      "createdById": "string",
      "modifiedDT": "2026-01-29T03:23:16.654Z",
      "modifiedById": "string",
      "name": "string"
    }
  ],
  "defaultOrientationForReportTemplatesForgeViewerViewJson": {
    "additionalProp1": "string",
    "additionalProp2": "string",
    "additionalProp3": "string"
  }
}No links400Bad RequestNo links401UnauthorizedNo links404Not FoundNo links500Internal Server ErrorNo links Attachment NameDescriptionid *string(path)STRATUS Attachment IdCodeDescriptionLinks200OKMedia typeControls Accept header."string"No links400Bad RequestNo links401UnauthorizedNo links404Not FoundNo links500Internal Server ErrorNo linksNameDescriptioninclude(query)A comma delimited list of JSON properties to return. All remaining JSON properties will removed from the JSON response. Example: id, description, cutListItems. Specific dictionary keys can be included as follows: properties["Family"], propertiesGtp["Material"]where(query)Filter on JSON property values. Example: To filter on two JSON properties: length eq '10' AND description == "truck". To get the last 30 days of data, use: createdDT ge DateTime.Now.AddDays(-30)page(query)Offset retrieves a given page of data, where 0 is the 1st page, etc (number of elements per page is set by PageSize below)pagesize(query)Optional: defines the number of elements per page (default (and max) is 1000)disabletotal(query)Optional: disable total calculation to improve performance (default is false)CodeDescriptionLinks200OKMedia typeControls Accept header.{
  "data": [
    {
      "id": "string",
      "createdById": "string",
      "createdDT": "2026-01-29T03:23:16.739Z",
      "projectId": "string",
      "modelId": "string",
      "referenceType": "0 = Unspecified",
      "referenceName": "string",
      "referenceId": "string",
      "role": "0 = Unspecified",
      "roleName": "string",
      "fileType": "0 = Unspecified",
      "fileTypeName": "string",
      "localFilePath": "string",
      "fileName": "string",
      "overriddenRemoteFolder": "string"
    }
  ],
  "pageOffset": 0,
  "pageLimit": 0,
  "pageCount": 0,
  "total": 0,
  "truncatedResults": true,
  "truncatedReason": "string",
  "filterOptions": [
    {
      "isValueConcatenated": true,
      "data": "string",
      "options": [
        "string"
      ]
    }
  ],
  "links": {
    "additionalProp1": "string",
    "additionalProp2": "string",
    "additionalProp3": "string"
  }
}No links400Bad RequestNo links401UnauthorizedNo links404Not FoundNo links500Internal Server ErrorNo linksNameDescriptionid *string(path)STRATUS Attachment IdCodeDescriptionLinks200OKMedia typeControls Accept header.{
  "isPartialData": true,
  "isReadOnly": true,
  "id": "string",
  "createdDT": "2026-01-29T03:23:16.776Z",
  "createdById": "string",
  "modifiedDT": "2026-01-29T03:23:16.776Z",
  "modifiedById": "string",
  "fabConfigName": "string",
  "fabFileGroupId": 0,
  "fabLocaleId": 0,
  "fabProfileName": "string",
  "fabUnitType": "0 = Imperial",
  "fileByteCount": 0,
  "fileName": "string",
  "fileType": "0 = Unspecified",
  "fileUploadTimeInSeconds": 0,
  "isCollaboration": true,
  "isPrimaryModel": true,
  "itemIdBase64URN": "string",
  "itemId": "string",
  "itemLink": "string",
  "localFilePath": "string",
  "modelId": "string",
  "overriddenRemoteFolder": "string",
  "parentAttachmentId": "string",
  "previewImageFileId": "string",
  "previousVersions": {
    "additionalProp1": "string",
    "additionalProp2": "string",
    "additionalProp3": "string"
  },
  "projectId": "string",
  "referenceId": "string",
  "referenceType": "0 = Unspecified",
  "role": "0 = Unspecified",
  "totalTransformationMatrix": [
    "string"
  ]
}No links400Bad RequestNo links401UnauthorizedNo links404Not FoundNo links500Internal Server ErrorNo links Company CodeDescriptionLinks200OKMedia typeControls Accept header.[
  {
    "id": "string",
    "name": "string",
    "sequenceNumber": 0
  }
]No links400Bad RequestNo links401UnauthorizedNo links404Not FoundNo links500Internal Server ErrorNo linksNameDescriptionwhere(query)Filter on JSON property values. Example: To filter on two JSON properties: length eq '10' AND description == "truck". To get the last 30 days of data, use: createdDT ge DateTime.Now.AddDays(-30)CodeDescriptionLinks200OKMedia typeControls Accept header.[
  {
    "id": "string",
    "name": "string",
    "code": "string",
    "color": "string",
    "hourlyRate": 0
  }
]No links400Bad RequestNo links401UnauthorizedNo links404Not FoundNo links500Internal Server ErrorNo linksNameDescriptionwhere(query)Filter on JSON property values. Example: To filter on two JSON properties: length eq '10' AND description == "truck". To get the last 30 days of data, use: createdDT ge DateTime.Now.AddDays(-30)CodeDescriptionLinks200OKMedia typeControls Accept header.[
  {
    "createdDT": "2026-01-29T03:23:16.855Z",
    "dataType": "0 = String",
    "dataTypeName": "string",
    "defaultValue": "string",
    "description": "string",
    "displayName": "string",
    "expression": "string",
    "filterId": "string",
    "id": "string",
    "isEditable": true,
    "isExpression": true,
    "isTotal": true,
    "modifiedDT": "2026-01-29T03:23:16.855Z",
    "name": "string",
    "possibleValues": "string",
    "unit": "string"
  }
]No links400Bad RequestNo links401UnauthorizedNo links404Not FoundNo links500Internal Server ErrorNo linksCodeDescriptionLinks200OKMedia typeControls Accept header.{
  "assemblyName": "string",
  "packageName": "string",
  "packageNumber": "string",
  "purchaseNumber": "string"
}No links400Bad RequestNo links401UnauthorizedNo links404Not FoundNo links500Internal Server ErrorNo linksNameDescriptionprojectIdstring(query)enforceProjectRoleboolean(query)Default value : falsewhere(query)Filter on JSON property values. Example: To filter on two JSON properties: length eq '10' AND description == "truck". To get the last 30 days of data, use: createdDT ge DateTime.Now.AddDays(-30)CodeDescriptionLinks200OKMedia typeControls Accept header.[
  {
    "id": "string",
    "name": "string",
    "description": "string",
    "abbreviation": "string",
    "useAssemblies": true,
    "useContainers": true
  }
]No links400Bad RequestNo links401UnauthorizedNo links404Not FoundNo links500Internal Server ErrorNo linksNameDescriptiontrackingStatusIdstring(query)where(query)Filter on JSON property values. Example: To filter on two JSON properties: length eq '10' AND description == "truck". To get the last 30 days of data, use: createdDT ge DateTime.Now.AddDays(-30)CodeDescriptionLinks200OKMedia typeControls Accept header.[
  {
    "id": "string",
    "name": "string",
    "trackingStatusGroupId": "string",
    "trackingStatusGroupName": "string"
  }
]No links400Bad RequestNo links401UnauthorizedNo links404Not FoundNo links500Internal Server ErrorNo linksCodeDescriptionLinks200OKMedia typeControls Accept header.[
  {
    "id": "string",
    "name": "string"
  }
]No links400Bad RequestNo links401UnauthorizedNo links404Not FoundNo links500Internal Server ErrorNo linksCodeDescriptionLinks200OKMedia typeControls Accept header.[
  {
    "id": "string",
    "name": "string"
  }
]No links400Bad RequestNo links401UnauthorizedNo links404Not FoundNo links500Internal Server ErrorNo linksCodeDescriptionLinks200OKMedia typeControls Accept header.[
  {
    "id": "string",
    "name": "string",
    "formatTypeName": "string",
    "itemTypeName": "string"
  }
]No links400Bad RequestNo links401UnauthorizedNo links404Not FoundNo links500Internal Server ErrorNo linksNameDescriptionqueryIdstring(query)CodeDescriptionLinks200OKMedia typeControls Accept header.{
  "content": "string"
}No links400Bad RequestNo links401UnauthorizedNo links404Not FoundNo links500Internal Server ErrorNo linksNameDescriptionwhere(query)Filter on JSON property values. Example: To filter on two JSON properties: length eq '10' AND description == "truck". To get the last 30 days of data, use: createdDT ge DateTime.Now.AddDays(-30)CodeDescriptionLinks200OKMedia typeControls Accept header.[
  {
    "id": "string",
    "name": "string",
    "description": "string",
    "divisionId": "string",
    "toolId": "string",
    "imageFileId": "string",
    "managedMaterials": [
      "string"
    ],
    "managedMaterialsValues": "string",
    "taskDefinitionIds": [
      "string"
    ]
  }
]No links400Bad RequestNo links401UnauthorizedNo links404Not FoundNo links500Internal Server ErrorNo linksNameDescriptionwhere(query)Filter on JSON property values. Example: To filter on two JSON properties: length eq '10' AND description == "truck". To get the last 30 days of data, use: createdDT ge DateTime.Now.AddDays(-30)CodeDescriptionLinks200OKMedia typeControls Accept header.[
  {
    "applyToPackageCategoryId": "string",
    "autoComplete": true,
    "color": "string",
    "costCategoryId": "string",
    "costTypeId": "string",
    "description": "string",
    "filterIds": [
      "string"
    ],
    "id": "string",
    "initiatedByTrackingStatusId": "string",
    "isEnabled": true,
    "isJoin": true,
    "name": "string",
    "referenceType": "0 = Unspecified",
    "reportId": "string",
    "separateTaskPerFilter": true,
    "sequenceNumber": 0,
    "taskCategoryId": "string",
    "trackingStatusApplyToAssembly": true,
    "trackingStatusApplyToOrder": true,
    "trackingStatusApplyToPart": true,
    "trackingStatusBypassDialog": true,
    "trackingStatusId": "string",
    "unitOfMeasureFieldId": "string",
    "unitVelocity": 0
  }
]No links400Bad RequestNo links401UnauthorizedNo links404Not FoundNo links500Internal Server ErrorNo linksCodeDescriptionLinks200OKMedia typeControls Accept header.[
  {
    "id": "string",
    "name": "string",
    "sequenceNumber": 0
  }
]No links400Bad RequestNo links401UnauthorizedNo links404Not FoundNo links500Internal Server ErrorNo linksNameDescriptionprojectIdstring(query)where(query)Filter on JSON property values. Example: To filter on two JSON properties: length eq '10' AND description == "truck". To get the last 30 days of data, use: createdDT ge DateTime.Now.AddDays(-30)CodeDescriptionLinks200OKMedia typeControls Accept header.[
  {
    "id": "string",
    "name": "string",
    "description": "string",
    "color": "string",
    "sequenceNumber": 0,
    "canAddToAssembly": true,
    "canAddToOrder": true,
    "canRenumberItems": true,
    "canAddToBOM": true,
    "canGenerateCutList": true,
    "appliedAtOrder": true,
    "appliedAtAssembly": true,
    "appliedAtPart": true,
    "appliedAtContainer": true,
    "onHold": true,
    "trackingStatusGroupIds": [
      "string"
    ],
    "trackingStatusGroups": [
      "string"
    ],
    "trackingStatusGroupPercentageMapping": {
      "additionalProp1": 0,
      "additionalProp2": 0,
      "additionalProp3": 0
    }
  }
]No links400Bad RequestNo links401UnauthorizedNo links404Not FoundNo links500Internal Server ErrorNo linksREQUIRED: FieldDataApi - minimum json includes name{
  "createdDT": "2026-01-29T03:23:17.266Z",
  "dataType": "0 = String",
  "defaultValue": "string",
  "description": "string",
  "displayName": "string",
  "expression": "string",
  "filterId": "string",
  "id": "string",
  "isEditable": true,
  "isExpression": true,
  "isTotal": true,
  "modifiedDT": "2026-01-29T03:23:17.266Z",
  "name": "string",
  "possibleValues": "string",
  "unit": "string"
}CodeDescriptionLinks200OKMedia typeControls Accept header.{
  "createdDT": "2026-01-29T03:23:17.272Z",
  "dataType": "0 = String",
  "dataTypeName": "string",
  "defaultValue": "string",
  "description": "string",
  "displayName": "string",
  "expression": "string",
  "filterId": "string",
  "id": "string",
  "isEditable": true,
  "isExpression": true,
  "isTotal": true,
  "modifiedDT": "2026-01-29T03:23:17.272Z",
  "name": "string",
  "possibleValues": "string",
  "unit": "string"
}No links400Bad RequestNo links401UnauthorizedNo links404Not FoundNo links500Internal Server ErrorNo links Container NameDescriptioninclude(query)A comma delimited list of JSON properties to return. All remaining JSON properties will removed from the JSON response. Example: id, description, cutListItems. Specific dictionary keys can be included as follows: properties["Family"], propertiesGtp["Material"]where(query)Filter on JSON property values. Example: To filter on two JSON properties: length eq '10' AND description == "truck". To get the last 30 days of data, use: createdDT ge DateTime.Now.AddDays(-30)page(query)Offset retrieves a given page of data, where 0 is the 1st page, etc (number of elements per page is set by PageSize below)pagesize(query)Optional: defines the number of elements per page (default (and max) is 1000)disabletotal(query)Optional: disable total calculation to improve performance (default is false)CodeDescriptionLinks200OKMedia typeControls Accept header.{
  "data": [
    {
      "id": "string",
      "name": "string",
      "description": "string",
      "length": "string",
      "width": "string",
      "height": "string",
      "location": "string",
      "containerTypeName": "string",
      "parentContainerId": "string",
      "currentTrackingStatusId": "string",
      "currentDivisionId": "string",
      "qrCodeUrl": "string",
      "fieldIdToValueMap": {
        "additionalProp1": "string",
        "additionalProp2": "string",
        "additionalProp3": "string"
      },
      "partIds": [
        "string"
      ],
      "assemblyCadIds": [
        "string"
      ],
      "packageIds": [
        "string"
      ],
      "containerIds": [
        "string"
      ],
      "contents": [
        {
          "projectId": "string",
          "referenceId": "string",
          "referenceType": "0 = Unspecified"
        }
      ]
    }
  ],
  "pageOffset": 0,
  "pageLimit": 0,
  "pageCount": 0,
  "total": 0,
  "truncatedResults": true,
  "truncatedReason": "string",
  "filterOptions": [
    {
      "isValueConcatenated": true,
      "data": "string",
      "options": [
        "string"
      ]
    }
  ],
  "links": {
    "additionalProp1": "string",
    "additionalProp2": "string",
    "additionalProp3": "string"
  }
}No links400Bad RequestNo links401UnauthorizedNo links404Not FoundNo links500Internal Server ErrorNo linksNameDescriptionid *string(path)STRATUS Container Idinclude(query)A comma delimited list of JSON properties to return. All remaining JSON properties will removed from the JSON response. Example: id, description, cutListItems. Specific dictionary keys can be included as follows: properties["Family"], propertiesGtp["Material"]CodeDescriptionLinks200OKMedia typeControls Accept header.{
  "id": "string",
  "name": "string",
  "description": "string",
  "length": "string",
  "width": "string",
  "height": "string",
  "location": "string",
  "containerTypeName": "string",
  "parentContainerId": "string",
  "currentTrackingStatusId": "string",
  "currentDivisionId": "string",
  "qrCodeUrl": "string",
  "fieldIdToValueMap": {
    "additionalProp1": "string",
    "additionalProp2": "string",
    "additionalProp3": "string"
  },
  "partIds": [
    "string"
  ],
  "assemblyCadIds": [
    "string"
  ],
  "packageIds": [
    "string"
  ],
  "containerIds": [
    "string"
  ],
  "contents": [
    {
      "projectId": "string",
      "referenceId": "string",
      "referenceType": "0 = Unspecified"
    }
  ]
}No links400Bad RequestNo links401UnauthorizedNo links404Not FoundNo links500Internal Server ErrorNo linksNameDescriptionwhere(query)Filter on JSON property values. Example: To filter on two JSON properties: length eq '10' AND description == "truck". To get the last 30 days of data, use: createdDT ge DateTime.Now.AddDays(-30)page(query)Offset retrieves a given page of data, where 0 is the 1st page, etc (number of elements per page is set by PageSize below)pagesize(query)Optional: defines the number of elements per page (default (and max) is 1000)disabletotal(query)Optional: disable total calculation to improve performance (default is false)CodeDescriptionLinks200OKMedia typeControls Accept header.{
  "data": [
    {
      "id": "string",
      "url": "string",
      "projectId": "string",
      "modelId": "string"
    }
  ],
  "pageOffset": 0,
  "pageLimit": 0,
  "pageCount": 0,
  "total": 0,
  "truncatedResults": true,
  "truncatedReason": "string",
  "filterOptions": [
    {
      "isValueConcatenated": true,
      "data": "string",
      "options": [
        "string"
      ]
    }
  ],
  "links": {
    "additionalProp1": "string",
    "additionalProp2": "string",
    "additionalProp3": "string"
  }
}No links400Bad RequestNo links401UnauthorizedNo links404Not FoundNo links500Internal Server ErrorNo linksContainer creation request containing name, description, dimensions, and other properties{
  "name": "string",
  "description": "string",
  "containerTypeId": "string",
  "divisionId": "string",
  "length": 0,
  "width": 0,
  "height": 0,
  "location": "string"
}CodeDescriptionLinks200OKMedia typeControls Accept header.{
  "id": "string",
  "name": "string",
  "description": "string",
  "length": "string",
  "width": "string",
  "height": "string",
  "location": "string",
  "containerTypeName": "string",
  "parentContainerId": "string",
  "currentTrackingStatusId": "string",
  "currentDivisionId": "string",
  "qrCodeUrl": "string",
  "fieldIdToValueMap": {
    "additionalProp1": "string",
    "additionalProp2": "string",
    "additionalProp3": "string"
  },
  "partIds": [
    "string"
  ],
  "assemblyCadIds": [
    "string"
  ],
  "packageIds": [
    "string"
  ],
  "containerIds": [
    "string"
  ],
  "contents": [
    {
      "projectId": "string",
      "referenceId": "string",
      "referenceType": "0 = Unspecified"
    }
  ]
}No links400Bad RequestNo links401UnauthorizedNo links409ConflictNo links500Internal Server ErrorNo linksNameDescriptionid *string(path)STRATUS Container IdREQUIRED: TrackingStatusId{
  "comment": "string",
  "costTypeId": "string",
  "createdDT": "2026-01-29T03:23:17.525Z",
  "divisionId": "string",
  "hours": 0,
  "trackingLogEntryIdResult": "string",
  "trackingStatusId": "string"
}CodeDescriptionLinks200OKMedia typeControls Accept header.{
  "comment": "string",
  "costTypeId": "string",
  "createdDT": "2026-01-29T03:23:17.533Z",
  "divisionId": "string",
  "hours": 0,
  "trackingLogEntryIdResult": "string",
  "trackingStatusId": "string"
}No links400Bad RequestNo links401UnauthorizedNo links404Not FoundNo links500Internal Server ErrorNo linksNameDescriptionid *string(path)STRATUS Container IdLocation hyperlink or descriptionCodeDescriptionLinks200OKMedia typeControls Accept header.trueNo links400Bad RequestNo links401UnauthorizedNo links404Not FoundNo links500Internal Server ErrorNo linksNameDescriptionid *string(path)STRATUS Container IdCodeDescriptionLinks200OKMedia typeControls Accept header.trueNo links400Bad RequestNo links401UnauthorizedNo links404Not FoundNo links500Internal Server ErrorNo links CutList NameDescriptioninclude(query)A comma delimited list of JSON properties to return. All remaining JSON properties will removed from the JSON response. Example: id, description, cutListItems. Specific dictionary keys can be included as follows: properties["Family"], propertiesGtp["Material"]where(query)Filter on JSON property values. Example: To filter on two JSON properties: length eq '10' AND description == "truck". To get the last 30 days of data, use: createdDT ge DateTime.Now.AddDays(-30)page(query)Offset retrieves a given page of data, where 0 is the 1st page, etc (number of elements per page is set by PageSize below)pagesize(query)Optional: defines the number of elements per page (default (and max) is 100)disabletotal(query)Optional: disable total calculation to improve performance (default is false)CodeDescriptionLinks200OKMedia typeControls Accept header.{
  "data": [
    {
      "id": "string",
      "completedDT": "2026-01-29T03:23:17.669Z",
      "createdDT": "2026-01-29T03:23:17.669Z",
      "createdById": "string",
      "modifiedDT": "2026-01-29T03:23:17.669Z",
      "modifiedById": "string",
      "cutListItems": [
        {
          "area": "string",
          "assemblyId": "string",
          "assemblyName": "string",
          "index": 0,
          "cadId": "string",
          "cutDateTime": "2026-01-29T03:23:17.669Z",
          "description": "string",
          "itemNumber": "string",
          "lengthInInches": 0,
          "lengthInFeetAndInches": "string",
          "level": "string",
          "preFabId": "string",
          "qrCode": "string",
          "userData1": "string",
          "userData2": "string",
          "userData3": "string",
          "userData4": "string",
          "userData5": "string",
          "userData6": "string",
          "userData7": "string",
          "userData8": "string",
          "userData9": "string",
          "userData10": "string",
          "userData11": "string",
          "userData12": "string",
          "userData13": "string",
          "userData14": "string",
          "userData15": "string"
        }
      ],
      "cutListItemCount": 0,
      "cutListStatus": "0 = New",
      "cutListStatusLabel": "string",
      "cutListStatusName": "string",
      "isAutoGeneratedCutList": true,
      "material": "string",
      "modelId": "string",
      "name": "string",
      "packageId": "string",
      "percentComplete": 0,
      "projectId": "string",
      "requestedDT": "2026-01-29T03:23:17.669Z",
      "requestedUserId": "string",
      "size": "string",
      "startedDT": "2026-01-29T03:23:17.669Z",
      "stationId": "string",
      "totalLengthInInches": 0,
      "totalLengthInFeetAndInches": "string"
    }
  ],
  "pageOffset": 0,
  "pageLimit": 0,
  "pageCount": 0,
  "total": 0,
  "truncatedResults": true,
  "truncatedReason": "string",
  "filterOptions": [
    {
      "isValueConcatenated": true,
      "data": "string",
      "options": [
        "string"
      ]
    }
  ],
  "links": {
    "additionalProp1": "string",
    "additionalProp2": "string",
    "additionalProp3": "string"
  }
}No links400Bad RequestNo links401UnauthorizedNo links404Not FoundNo links500Internal Server ErrorNo linksNameDescriptionid *string(path)STRATUS Cut List IdCodeDescriptionLinks200OKMedia typeControls Accept header.{
  "id": "string",
  "completedDT": "2026-01-29T03:23:17.703Z",
  "createdDT": "2026-01-29T03:23:17.703Z",
  "createdById": "string",
  "modifiedDT": "2026-01-29T03:23:17.703Z",
  "modifiedById": "string",
  "cutListItems": [
    {
      "area": "string",
      "assemblyId": "string",
      "assemblyName": "string",
      "index": 0,
      "cadId": "string",
      "cutDateTime": "2026-01-29T03:23:17.703Z",
      "description": "string",
      "itemNumber": "string",
      "lengthInInches": 0,
      "lengthInFeetAndInches": "string",
      "level": "string",
      "preFabId": "string",
      "qrCode": "string",
      "userData1": "string",
      "userData2": "string",
      "userData3": "string",
      "userData4": "string",
      "userData5": "string",
      "userData6": "string",
      "userData7": "string",
      "userData8": "string",
      "userData9": "string",
      "userData10": "string",
      "userData11": "string",
      "userData12": "string",
      "userData13": "string",
      "userData14": "string",
      "userData15": "string"
    }
  ],
  "cutListItemCount": 0,
  "cutListStatus": "0 = New",
  "cutListStatusLabel": "string",
  "cutListStatusName": "string",
  "isAutoGeneratedCutList": true,
  "material": "string",
  "modelId": "string",
  "name": "string",
  "packageId": "string",
  "percentComplete": 0,
  "projectId": "string",
  "requestedDT": "2026-01-29T03:23:17.703Z",
  "requestedUserId": "string",
  "size": "string",
  "startedDT": "2026-01-29T03:23:17.703Z",
  "stationId": "string",
  "totalLengthInInches": 0,
  "totalLengthInFeetAndInches": "string"
}No links400Bad RequestNo links401UnauthorizedNo links404Not FoundNo links500Internal Server ErrorNo links Model NameDescriptioninclude(query)A comma delimited list of JSON properties to return. All remaining JSON properties will removed from the JSON response. Example: id, description, cutListItems. Specific dictionary keys can be included as follows: properties["Family"], propertiesGtp["Material"]where(query)Filter on JSON property values. Example: To filter on two JSON properties: length eq '10' AND description == "truck". To get the last 30 days of data, use: createdDT ge DateTime.Now.AddDays(-30)page(query)Offset retrieves a given page of data, where 0 is the 1st page, etc (number of elements per page is set by PageSize below)pagesize(query)Optional: defines the number of elements per page (default (and max) is 1000)disabletotal(query)Optional: disable total calculation to improve performance (default is false)CodeDescriptionLinks200OKMedia typeControls Accept header.{
  "data": [
    {
      "a360FolderId": "string",
      "createdDT": "2026-01-29T03:23:17.770Z",
      "databaseUnits": "0 = Imperial",
      "defaultViewId": "string",
      "id": "string",
      "isFieldOrderz": true,
      "lastPublishedDT": "2026-01-29T03:23:17.770Z",
      "modelName": "string",
      "modelType": "0 = Unspecified",
      "modifiedDT": "2026-01-29T03:23:17.770Z",
      "name": "string",
      "projectId": "string",
      "publishStatus": "0 = Published",
      "releaseVersion": "string"
    }
  ],
  "pageOffset": 0,
  "pageLimit": 0,
  "pageCount": 0,
  "total": 0,
  "truncatedResults": true,
  "truncatedReason": "string",
  "filterOptions": [
    {
      "isValueConcatenated": true,
      "data": "string",
      "options": [
        "string"
      ]
    }
  ],
  "links": {
    "additionalProp1": "string",
    "additionalProp2": "string",
    "additionalProp3": "string"
  }
}No links400Bad RequestNo links401UnauthorizedNo links404Not FoundNo links500Internal Server ErrorNo linksNameDescriptionid *string(path)STRATUS Model Idinclude(query)A comma delimited list of JSON properties to return. All remaining JSON properties will removed from the JSON response. Example: id, description, cutListItems. Specific dictionary keys can be included as follows: properties["Family"], propertiesGtp["Material"]CodeDescriptionLinks200OKMedia typeControls Accept header.{
  "a360FolderId": "string",
  "createdDT": "2026-01-29T03:23:17.817Z",
  "databaseUnits": "0 = Imperial",
  "defaultViewId": "string",
  "id": "string",
  "isFieldOrderz": true,
  "lastPublishedDT": "2026-01-29T03:23:17.817Z",
  "modelName": "string",
  "modelType": "0 = Unspecified",
  "modifiedDT": "2026-01-29T03:23:17.817Z",
  "name": "string",
  "projectId": "string",
  "publishStatus": "0 = Published",
  "releaseVersion": "string"
}No links400Bad RequestNo links401UnauthorizedNo links404Not FoundNo links500Internal Server ErrorNo linksNameDescriptionid *string(path)STRATUS Model Idinclude(query)A comma delimited list of JSON properties to return. All remaining JSON properties will removed from the JSON response. Example: id, description, cutListItems. Specific dictionary keys can be included as follows: properties["Family"], propertiesGtp["Material"]where(query)Filter on JSON property values. Example: To filter on two JSON properties: length eq '10' AND description == "truck". To get the last 30 days of data, use: createdDT ge DateTime.Now.AddDays(-30)page(query)Offset retrieves a given page of data, where 0 is the 1st page, etc (number of elements per page is set by PageSize below)pagesize(query)Optional: defines the number of elements per page (default (and max) is 1000)disabletotal(query)Optional: disable total calculation to improve performance (default is false)CodeDescriptionLinks200OKMedia typeControls Accept header.{
  "data": [
    {
      "id": "string",
      "createdDT": "2026-01-29T03:23:17.878Z",
      "modifiedDT": "2026-01-29T03:23:17.878Z",
      "projectId": "string",
      "modelId": "string",
      "cadId": "string",
      "sheetId": "string",
      "viewId": "string",
      "isViewIdOverridden": true,
      "currentTrackingStatusId": "string",
      "currentDivisionId": "string",
      "assemblyType": "0 = Unspecified",
      "assemblyTypeLabel": "string",
      "excludedCadIds": [
        "string"
      ],
      "fieldIdToValueMap": {
        "additionalProp1": "string",
        "additionalProp2": "string",
        "additionalProp3": "string"
      },
      "fieldNameToValueMap": {
        "additionalProp1": "string",
        "additionalProp2": "string",
        "additionalProp3": "string"
      },
      "name": "string",
      "nameLabel": "string",
      "partIds": [
        "string"
      ],
      "instanceIndex": "string",
      "lastUsedAssembliesPartsTableReportIds": [
        "string"
      ],
      "qrCodeUrl": "string",
      "notes": [
        {
          "isPartialData": true,
          "isReadOnly": true,
          "id": "string",
          "createdDT": "2026-01-29T03:23:17.879Z",
          "createdById": "string",
          "modifiedDT": "2026-01-29T03:23:17.879Z",
          "modifiedById": "string",
          "name": "string"
        }
      ],
      "defaultOrientationForReportTemplatesForgeViewerViewJson": {
        "additionalProp1": "string",
        "additionalProp2": "string",
        "additionalProp3": "string"
      }
    }
  ],
  "pageOffset": 0,
  "pageLimit": 0,
  "pageCount": 0,
  "total": 0,
  "truncatedResults": true,
  "truncatedReason": "string",
  "filterOptions": [
    {
      "isValueConcatenated": true,
      "data": "string",
      "options": [
        "string"
      ]
    }
  ],
  "links": {
    "additionalProp1": "string",
    "additionalProp2": "string",
    "additionalProp3": "string"
  }
}No links400Bad RequestNo links401UnauthorizedNo links404Not FoundNo links500Internal Server ErrorNo linksNameDescriptionid *string(path)STRATUS Model IdCodeDescriptionLinks200OKMedia typeControls Accept header.[
  {
    "createdById": "string",
    "createdDT": "2026-01-29T03:23:17.913Z",
    "gridIntersections": [
      {
        "horizontalAnnotation": "string",
        "horizontalDirection": {
          "x": 0,
          "y": 0,
          "z": 0
        },
        "horizontalGridLineId": "string",
        "intersectionPoint": {
          "x": 0,
          "y": 0,
          "z": 0
        },
        "verticalAnnotation": "string",
        "verticalDirection": {
          "x": 0,
          "y": 0,
          "z": 0
        },
        "verticalGridLineId": "string"
      }
    ],
    "gridLines": [
      {
        "annotation": "string",
        "gridLineType": "0 = LineSegment",
        "id": "string",
        "linePoints": [
          {
            "x": 0,
            "y": 0,
            "z": 0
          }
        ]
      }
    ],
    "id": "string",
    "modelId": "string",
    "modifiedById": "string",
    "modifiedDT": "2026-01-29T03:23:17.913Z",
    "name": "string"
  }
]No links400Bad RequestNo links401UnauthorizedNo links404Not FoundNo links500Internal Server ErrorNo linksNameDescriptionid *string(path)STRATUS Model Idinclude(query)A comma delimited list of JSON properties to return. All remaining JSON properties will removed from the JSON response. Example: id, description, cutListItems. Specific dictionary keys can be included as follows: properties["Family"], propertiesGtp["Material"]where(query)Filter on JSON property values. Example: To filter on two JSON properties: length eq '10' AND description == "truck". To get the last 30 days of data, use: createdDT ge DateTime.Now.AddDays(-30)page(query)Offset retrieves a given page of data, where 0 is the 1st page, etc (number of elements per page is set by PageSize below)pagesize(query)Optional: defines the number of elements per page (default (and max) is 200)disabletotal(query)Optional: disable total calculation to improve performance (default is false)CodeDescriptionLinks200OKMedia typeControls Accept header.{
  "data": [
    {
      "assemblyIds": [
        "string"
      ],
      "bimAreaId": "string",
      "bimAreaName": "string",
      "cadIdsBySequence": [
        "string"
      ],
      "categoryId": "string",
      "createdBy": "string",
      "createdDT": "2026-01-29T03:23:17.978Z",
      "currentTrackingStatusId": "string",
      "currentDivisionId": "string",
      "description": "string",
      "fieldIdToValueMap": {
        "additionalProp1": "string",
        "additionalProp2": "string",
        "additionalProp3": "string"
      },
      "fieldNameToValueMap": {
        "additionalProp1": "string",
        "additionalProp2": "string",
        "additionalProp3": "string"
      },
      "hoursEstimatedField": 0,
      "hoursEstimatedOffice": 0,
      "hoursEstimatedPurchasing": 0,
      "hoursEstimatedShop": 0,
      "id": "string",
      "installedDT": "2026-01-29T03:23:17.978Z",
      "modelId": "string",
      "modifiedBy": "string",
      "modifiedDT": "2026-01-29T03:23:17.978Z",
      "name": "string",
      "number": "string",
      "officeDuration": 0,
      "officeStartDT": "2026-01-29T03:23:17.978Z",
      "partCadIds": [
        "string"
      ],
      "projectId": "string",
      "purchasingDuration": 0,
      "purchasingStartDT": "2026-01-29T03:23:17.978Z",
      "qrCodeUrl": "string",
      "requiredDT": "2026-01-29T03:23:17.978Z",
      "selectedTaskWorkflowIdsForAssemblyAndPartCadIds": {
        "additionalProp1": "string",
        "additionalProp2": "string",
        "additionalProp3": "string"
      },
      "shopDuration": 0,
      "startDT": "2026-01-29T03:23:17.978Z",
      "status": "0 = Active",
      "statusName": "string",
      "viewId": "string",
      "isViewIdOverridden": true
    }
  ],
  "pageOffset": 0,
  "pageLimit": 0,
  "pageCount": 0,
  "total": 0,
  "truncatedResults": true,
  "truncatedReason": "string",
  "filterOptions": [
    {
      "isValueConcatenated": true,
      "data": "string",
      "options": [
        "string"
      ]
    }
  ],
  "links": {
    "additionalProp1": "string",
    "additionalProp2": "string",
    "additionalProp3": "string"
  }
}No links400Bad RequestNo links401UnauthorizedNo links404Not FoundNo links500Internal Server ErrorNo linksNameDescriptionid *string(path)cadid *string(path)STRATUS.Part.CadIdexcludeNullAndEmpty *boolean(path)Pass true to this optional query parameter if you want empty or null values removed from the part's Properties and PropertiesGtp collections to improve performance.Default value : falseinclude(query)A comma delimited list of JSON properties to return. All remaining JSON properties will removed from the JSON response. Example: id, description, cutListItems. Specific dictionary keys can be included as follows: properties["Family"], propertiesGtp["Material"]CodeDescriptionLinks200OKMedia typeControls Accept header.{
  "id": "string",
  "createdDT": "2026-01-29T03:23:18.032Z",
  "modifiedDT": "2026-01-29T03:23:18.032Z",
  "cutDT": "2026-01-29T03:23:18.032Z",
  "projectId": "string",
  "projectName": "string",
  "projectNumber": "string",
  "modelId": "string",
  "modelName": "string",
  "bimAreaId": "string",
  "bimArea": "string",
  "cadId": "string",
  "cadType": "string",
  "webId": "string",
  "description": "string",
  "currentTrackingStatusId": "string",
  "currentDivisionId": "string",
  "properties": {
    "additionalProp1": "string",
    "additionalProp2": "string",
    "additionalProp3": "string"
  },
  "propertiesGtp": {
    "additionalProp1": "string",
    "additionalProp2": "string",
    "additionalProp3": "string"
  },
  "points": [
    {
      "pointType": "0 = Unspecified",
      "cadId": "string",
      "location": {
        "x": 0,
        "y": 0,
        "z": 0
      },
      "direction": {
        "x": 0,
        "y": 0,
        "z": 0
      },
      "upVector": {
        "x": 0,
        "y": 0,
        "z": 0
      },
      "width": 0,
      "height": 0,
      "matingElementUniqueId": "string"
    }
  ],
  "cutLengthAdjustment": 0,
  "cutLength2Adjustment": 0,
  "lockLength": true,
  "lockLocation": true,
  "qrCodeUrl": "string",
  "partUrl": "string",
  "patternNumber": "string",
  "source": "0 = PublishedModel",
  "fieldIdToValueMap": {
    "additionalProp1": "string",
    "additionalProp2": "string",
    "additionalProp3": "string"
  },
  "fieldNameToValueMap": {
    "additionalProp1": "string",
    "additionalProp2": "string",
    "additionalProp3": "string"
  }
}No links400Bad RequestNo links401UnauthorizedNo links404Not FoundNo links500Internal Server ErrorNo linksNameDescriptionid *string(path)STRATUS Model IdincludeStratusPropertiesboolean(query)Pass true to this optional query parameter if you want to generate STRATUS.Part.* properties and have them returned for the parts.Default value : falseexcludeNullAndEmptyboolean(query)Pass true to this optional query parameter if you want empty or null values removed from the part's Properties and PropertiesGtp collections to improve performance.Default value : falseinclude(query)A comma delimited list of JSON properties to return. All remaining JSON properties will removed from the JSON response. Example: id, description, cutListItems. Specific dictionary keys can be included as follows: properties["Family"], propertiesGtp["Material"]where(query)Filter on JSON property values. Example: To filter on two JSON properties: length eq '10' AND description == "truck". To get the last 30 days of data, use: createdDT ge DateTime.Now.AddDays(-30)page(query)Offset retrieves a given page of data, where 0 is the 1st page, etc (number of elements per page is set by PageSize below)pagesize(query)Optional: defines the number of elements per page (default (and max) is 100)disabletotal(query)Optional: disable total calculation to improve performance (default is false)CodeDescriptionLinks200OKMedia typeControls Accept header.{
  "data": [
    {
      "id": "string",
      "createdDT": "2026-01-29T03:23:18.113Z",
      "modifiedDT": "2026-01-29T03:23:18.113Z",
      "cutDT": "2026-01-29T03:23:18.113Z",
      "projectId": "string",
      "projectName": "string",
      "projectNumber": "string",
      "modelId": "string",
      "modelName": "string",
      "bimAreaId": "string",
      "bimArea": "string",
      "cadId": "string",
      "cadType": "string",
      "webId": "string",
      "description": "string",
      "currentTrackingStatusId": "string",
      "currentDivisionId": "string",
      "properties": {
        "additionalProp1": "string",
        "additionalProp2": "string",
        "additionalProp3": "string"
      },
      "propertiesGtp": {
        "additionalProp1": "string",
        "additionalProp2": "string",
        "additionalProp3": "string"
      },
      "points": [
        {
          "pointType": "0 = Unspecified",
          "cadId": "string",
          "location": {
            "x": 0,
            "y": 0,
            "z": 0
          },
          "direction": {
            "x": 0,
            "y": 0,
            "z": 0
          },
          "upVector": {
            "x": 0,
            "y": 0,
            "z": 0
          },
          "width": 0,
          "height": 0,
          "matingElementUniqueId": "string"
        }
      ],
      "cutLengthAdjustment": 0,
      "cutLength2Adjustment": 0,
      "lockLength": true,
      "lockLocation": true,
      "qrCodeUrl": "string",
      "partUrl": "string",
      "patternNumber": "string",
      "source": "0 = PublishedModel",
      "fieldIdToValueMap": {
        "additionalProp1": "string",
        "additionalProp2": "string",
        "additionalProp3": "string"
      },
      "fieldNameToValueMap": {
        "additionalProp1": "string",
        "additionalProp2": "string",
        "additionalProp3": "string"
      }
    }
  ],
  "pageOffset": 0,
  "pageLimit": 0,
  "pageCount": 0,
  "total": 0,
  "truncatedResults": true,
  "truncatedReason": "string",
  "filterOptions": [
    {
      "isValueConcatenated": true,
      "data": "string",
      "options": [
        "string"
      ]
    }
  ],
  "links": {
    "additionalProp1": "string",
    "additionalProp2": "string",
    "additionalProp3": "string"
  }
}No links400Bad RequestNo links401UnauthorizedNo links404Not FoundNo links500Internal Server ErrorNo linksNameDescriptionid *string(path)STRATUS Model Idreportid *string(path)STRATUS Company Report IdviewIdstring(query)(optional) STRATUS View Id for a View in the STRATUS ModelCodeDescriptionLinks200OKMedia typeControls Accept header."string"No links400Bad RequestNo links401UnauthorizedNo links404Not FoundNo links429Too Many RequestsNo links500Internal Server ErrorNo linksNameDescriptionid *string(path)STRATUS Model Idinclude(query)A comma delimited list of JSON properties to return. All remaining JSON properties will removed from the JSON response. Example: id, description, cutListItems. Specific dictionary keys can be included as follows: properties["Family"], propertiesGtp["Material"]where(query)Filter on JSON property values. Example: To filter on two JSON properties: length eq '10' AND description == "truck". To get the last 30 days of data, use: createdDT ge DateTime.Now.AddDays(-30)page(query)Offset retrieves a given page of data, where 0 is the 1st page, etc (number of elements per page is set by PageSize below)pagesize(query)Optional: defines the number of elements per page (default (and max) is 1000)disabletotal(query)Optional: disable total calculation to improve performance (default is false)CodeDescriptionLinks200OKMedia typeControls Accept header.{
  "data": [
    {
      "id": "string",
      "createdDT": "2026-01-29T03:23:18.222Z",
      "currentDivisionId": "string",
      "modifiedDT": "2026-01-29T03:23:18.222Z",
      "modelId": "string",
      "referenceType": "0 = Unspecified",
      "referenceName": "string",
      "referenceId": "string",
      "currentTrackingStatusId": "string",
      "totalHours": 0,
      "trackingLogEntries": [
        {
          "trackingStatusId": "string",
          "createdById": "string",
          "createdDT": "2026-01-29T03:23:18.222Z",
          "divisionId": "string",
          "id": "string",
          "origin": "0 = Unknown",
          "comment": "string",
          "hours": 0,
          "costTypeId": "string",
          "hoursCost": 0
        }
      ]
    }
  ],
  "pageOffset": 0,
  "pageLimit": 0,
  "pageCount": 0,
  "total": 0,
  "truncatedResults": true,
  "truncatedReason": "string",
  "filterOptions": [
    {
      "isValueConcatenated": true,
      "data": "string",
      "options": [
        "string"
      ]
    }
  ],
  "links": {
    "additionalProp1": "string",
    "additionalProp2": "string",
    "additionalProp3": "string"
  }
}No links400Bad RequestNo links401UnauthorizedNo links404Not FoundNo links500Internal Server ErrorNo linksNameDescriptionid *string(path)STRATUS Model Idrefid *string(path)This is a generic Reference Id, that is, it is an id that may map to any one of the following:
Part.CadId, Assembly.Id, Model.Id, Order.Id, Project.Id, Container.Id.include(query)A comma delimited list of JSON properties to return. All remaining JSON properties will removed from the JSON response. Example: id, description, cutListItems. Specific dictionary keys can be included as follows: properties["Family"], propertiesGtp["Material"]where(query)Filter on JSON property values. Example: To filter on two JSON properties: length eq '10' AND description == "truck". To get the last 30 days of data, use: createdDT ge DateTime.Now.AddDays(-30)page(query)Offset retrieves a given page of data, where 0 is the 1st page, etc (number of elements per page is set by PageSize below)pagesize(query)Optional: defines the number of elements per page (default (and max) is 1000)disabletotal(query)Optional: disable total calculation to improve performance (default is false)CodeDescriptionLinks200OKMedia typeControls Accept header.{
  "data": [
    {
      "id": "string",
      "createdDT": "2026-01-29T03:23:18.296Z",
      "currentDivisionId": "string",
      "modifiedDT": "2026-01-29T03:23:18.296Z",
      "modelId": "string",
      "referenceType": "0 = Unspecified",
      "referenceName": "string",
      "referenceId": "string",
      "currentTrackingStatusId": "string",
      "totalHours": 0,
      "trackingLogEntries": [
        {
          "trackingStatusId": "string",
          "createdById": "string",
          "createdDT": "2026-01-29T03:23:18.296Z",
          "divisionId": "string",
          "id": "string",
          "origin": "0 = Unknown",
          "comment": "string",
          "hours": 0,
          "costTypeId": "string",
          "hoursCost": 0
        }
      ]
    }
  ],
  "pageOffset": 0,
  "pageLimit": 0,
  "pageCount": 0,
  "total": 0,
  "truncatedResults": true,
  "truncatedReason": "string",
  "filterOptions": [
    {
      "isValueConcatenated": true,
      "data": "string",
      "options": [
        "string"
      ]
    }
  ],
  "links": {
    "additionalProp1": "string",
    "additionalProp2": "string",
    "additionalProp3": "string"
  }
}No links400Bad RequestNo links401UnauthorizedNo links404Not FoundNo links500Internal Server ErrorNo linksNameDescriptionid *string(path)STRATUS Model IdCodeDescriptionLinks200OKMedia typeControls Accept header.[
  {
    "id": "string",
    "name": "string",
    "viewRole": "string",
    "autodeskViewId": "string"
  }
]No links400Bad RequestNo links401UnauthorizedNo links404Not FoundNo links500Internal Server ErrorNo linksNameDescriptionid *string(path)STRATUS Model Idcadids *string(header)Comma separated list of CadIds (pass them in the header)include(query)A comma delimited list of JSON properties to return. All remaining JSON properties will removed from the JSON response. Example: id, description, cutListItems. Specific dictionary keys can be included as follows: properties["Family"], propertiesGtp["Material"]where(query)Filter on JSON property values. Example: To filter on two JSON properties: length eq '10' AND description == "truck". To get the last 30 days of data, use: createdDT ge DateTime.Now.AddDays(-30)page(query)Offset retrieves a given page of data, where 0 is the 1st page, etc (number of elements per page is set by PageSize below)pagesize(query)Optional: defines the number of elements per page (default (and max) is 1000)disabletotal(query)Optional: disable total calculation to improve performance (default is false)CodeDescriptionLinks200OKMedia typeControls Accept header.{
  "data": [
    {
      "id": "string",
      "createdDT": "2026-01-29T03:23:18.406Z",
      "currentDivisionId": "string",
      "modifiedDT": "2026-01-29T03:23:18.406Z",
      "modelId": "string",
      "referenceType": "0 = Unspecified",
      "referenceName": "string",
      "referenceId": "string",
      "currentTrackingStatusId": "string",
      "totalHours": 0,
      "trackingLogEntries": [
        {
          "trackingStatusId": "string",
          "createdById": "string",
          "createdDT": "2026-01-29T03:23:18.406Z",
          "divisionId": "string",
          "id": "string",
          "origin": "0 = Unknown",
          "comment": "string",
          "hours": 0,
          "costTypeId": "string",
          "hoursCost": 0
        }
      ]
    }
  ],
  "pageOffset": 0,
  "pageLimit": 0,
  "pageCount": 0,
  "total": 0,
  "truncatedResults": true,
  "truncatedReason": "string",
  "filterOptions": [
    {
      "isValueConcatenated": true,
      "data": "string",
      "options": [
        "string"
      ]
    }
  ],
  "links": {
    "additionalProp1": "string",
    "additionalProp2": "string",
    "additionalProp3": "string"
  }
}No links400Bad RequestNo links401UnauthorizedNo links404Not FoundNo links500Internal Server ErrorNo linksNameDescriptionid *string(path)Stratus Model IdREQUIRED: Name, NOTE: if Name contains "Incrementor XX", it will be replaced with an auto-incremented value, supporting as many XXXXX digits as specified, but must match company assembly naming convention.  OPTIONAL: CadId, will be assigned by Stratus if not provided.  Id will be assigned by Stratus. OPTIONAL: InitialTrackingStatusId and CreatedByUserEmail, if provided, these will be used in the construction of the new assembly.{
  "cadId": "string",
  "createdByUserEmail": "string",
  "id": "string",
  "initialTrackingStatusId": "string",
  "name": "string"
}CodeDescriptionLinks201CreatedMedia typeControls Accept header.{
  "cadId": "string",
  "createdByUserEmail": "string",
  "id": "string",
  "initialTrackingStatusId": "string",
  "name": "string"
}No links400Bad RequestNo links401UnauthorizedNo links404Not FoundNo links500Internal Server ErrorNo linksNameDescriptionid *string(path)STRATUS Model Idcadid *string(path)STRATUS Assembly CadIdREQUIRED: TrackingStatusId{
  "comment": "string",
  "costTypeId": "string",
  "createdDT": "2026-01-29T03:23:18.522Z",
  "divisionId": "string",
  "hours": 0,
  "trackingLogEntryIdResult": "string",
  "trackingStatusId": "string"
}CodeDescriptionLinks200OKMedia typeControls Accept header.{
  "comment": "string",
  "costTypeId": "string",
  "createdDT": "2026-01-29T03:23:18.532Z",
  "divisionId": "string",
  "hours": 0,
  "trackingLogEntryIdResult": "string",
  "trackingStatusId": "string"
}No links400Bad RequestNo links401UnauthorizedNo links404Not FoundNo links500Internal Server ErrorNo linksNameDescriptionid *string(path)Stratus Model IdREQUIRED: CategoryId and Name. OPTIONAL: InitialTrackingStatusId and CreatedByUserEmail, if provided, these will be used in the construction of the new package.{
  "areaId": "string",
  "categoryId": "string",
  "createdByUserEmail": "string",
  "description": "string",
  "initialTrackingStatusId": "string",
  "name": "string",
  "number": "string",
  "orderNameFOZ": "string"
}CodeDescriptionLinks201CreatedMedia typeControls Accept header."string"No links400Bad RequestNo links401UnauthorizedNo links404Not FoundNo links500Internal Server ErrorNo linksNameDescriptionid *string(path)STRATUS Model Idcadid *string(path)STRATUS Part CadIdREQUIRED: TrackingStatusId{
  "comment": "string",
  "costTypeId": "string",
  "createdDT": "2026-01-29T03:23:18.638Z",
  "divisionId": "string",
  "hours": 0,
  "trackingLogEntryIdResult": "string",
  "trackingStatusId": "string"
}CodeDescriptionLinks200OKMedia typeControls Accept header.{
  "comment": "string",
  "costTypeId": "string",
  "createdDT": "2026-01-29T03:23:18.644Z",
  "divisionId": "string",
  "hours": 0,
  "trackingLogEntryIdResult": "string",
  "trackingStatusId": "string"
}No links400Bad RequestNo links401UnauthorizedNo links404Not FoundNo links500Internal Server ErrorNo linksNameDescriptionid *string(path)STRATUS Model Idcadid *string(path)STRATUS Part CadIdExample JSON KeyValuePair: {
  "key": "string",
  "value": "string"
}CodeDescriptionLinks200OKMedia typeControls Accept header.{
  "key": "string",
  "value": "string"
}No links400Bad RequestNo links401UnauthorizedNo links404Not FoundNo links500Internal Server ErrorNo links NonStratusUser NameDescriptionwhere(query)Filter on JSON property values. Example: To filter on two JSON properties: length eq '10' AND description == "truck". To get the last 30 days of data, use: createdDT ge DateTime.Now.AddDays(-30)CodeDescriptionLinks200OKMedia typeControls Accept header.[
  {
    "createdById": "string",
    "createdDT": "2026-01-29T03:23:18.736Z",
    "divisionId": "string",
    "employeeId": "string",
    "firstName": "string",
    "id": "string",
    "isCheckedIn": true,
    "isTimeTrackingEnabled": true,
    "lastName": "string",
    "modifiedById": "string",
    "modifiedDT": "2026-01-29T03:23:18.736Z",
    "status": "1 = Active"
  }
]No links400Bad RequestNo links401UnauthorizedNo links404Not FoundNo links500Internal Server ErrorNo linksNameDescriptionid *string(path)NonStratusUser IdCodeDescriptionLinks200OKMedia typeControls Accept header.{
  "createdById": "string",
  "createdDT": "2026-01-29T03:23:18.769Z",
  "divisionId": "string",
  "employeeId": "string",
  "firstName": "string",
  "id": "string",
  "isCheckedIn": true,
  "isTimeTrackingEnabled": true,
  "lastName": "string",
  "modifiedById": "string",
  "modifiedDT": "2026-01-29T03:23:18.769Z",
  "status": "1 = Active"
}No links400Bad RequestNo links401UnauthorizedNo links404Not FoundNo links500Internal Server ErrorNo linksREQUIRED: NonStratusUser data - minimum json includes FirstName and LastName, Id will be assigned by server.{
  "createdById": "string",
  "createdDT": "2026-01-29T03:23:18.808Z",
  "divisionId": "string",
  "employeeId": "string",
  "firstName": "string",
  "id": "string",
  "isCheckedIn": true,
  "isTimeTrackingEnabled": true,
  "lastName": "string",
  "modifiedById": "string",
  "modifiedDT": "2026-01-29T03:23:18.808Z",
  "status": "1 = Active"
}CodeDescriptionLinks201CreatedMedia typeControls Accept header.{
  "createdById": "string",
  "createdDT": "2026-01-29T03:23:18.817Z",
  "divisionId": "string",
  "employeeId": "string",
  "firstName": "string",
  "id": "string",
  "isCheckedIn": true,
  "isTimeTrackingEnabled": true,
  "lastName": "string",
  "modifiedById": "string",
  "modifiedDT": "2026-01-29T03:23:18.817Z",
  "status": "1 = Active"
}No links400Bad RequestNo links401UnauthorizedNo links404Not FoundNo links500Internal Server ErrorNo linksNameDescriptionid *string(path){
  "createdById": "string",
  "createdDT": "2026-01-29T03:23:18.864Z",
  "divisionId": "string",
  "employeeId": "string",
  "firstName": "string",
  "id": "string",
  "isCheckedIn": true,
  "isTimeTrackingEnabled": true,
  "lastName": "string",
  "modifiedById": "string",
  "modifiedDT": "2026-01-29T03:23:18.864Z",
  "status": "1 = Active"
}CodeDescriptionLinks202AcceptedMedia typeControls Accept header.{
  "createdById": "string",
  "createdDT": "2026-01-29T03:23:18.871Z",
  "divisionId": "string",
  "employeeId": "string",
  "firstName": "string",
  "id": "string",
  "isCheckedIn": true,
  "isTimeTrackingEnabled": true,
  "lastName": "string",
  "modifiedById": "string",
  "modifiedDT": "2026-01-29T03:23:18.871Z",
  "status": "1 = Active"
}No links400Bad RequestNo links401UnauthorizedNo links404Not FoundNo links500Internal Server ErrorNo links Package NameDescriptioninclude(query)A comma delimited list of JSON properties to return. All remaining JSON properties will removed from the JSON response. Example: id, description, cutListItems. Specific dictionary keys can be included as follows: properties["Family"], propertiesGtp["Material"]where(query)Filter on JSON property values. Example: To filter on two JSON properties: length eq '10' AND description == "truck". To get the last 30 days of data, use: createdDT ge DateTime.Now.AddDays(-30)page(query)Offset retrieves a given page of data, where 0 is the 1st page, etc (number of elements per page is set by PageSize below)pagesize(query)Optional: defines the number of elements per page (default (and max) is 200)disabletotal(query)Optional: disable total calculation to improve performance (default is false)CodeDescriptionLinks200OKMedia typeControls Accept header.{
  "data": [
    {
      "assemblyIds": [
        "string"
      ],
      "bimAreaId": "string",
      "bimAreaName": "string",
      "cadIdsBySequence": [
        "string"
      ],
      "categoryId": "string",
      "createdBy": "string",
      "createdDT": "2026-01-29T03:23:18.927Z",
      "currentTrackingStatusId": "string",
      "currentDivisionId": "string",
      "description": "string",
      "fieldIdToValueMap": {
        "additionalProp1": "string",
        "additionalProp2": "string",
        "additionalProp3": "string"
      },
      "fieldNameToValueMap": {
        "additionalProp1": "string",
        "additionalProp2": "string",
        "additionalProp3": "string"
      },
      "hoursEstimatedField": 0,
      "hoursEstimatedOffice": 0,
      "hoursEstimatedPurchasing": 0,
      "hoursEstimatedShop": 0,
      "id": "string",
      "installedDT": "2026-01-29T03:23:18.927Z",
      "modelId": "string",
      "modifiedBy": "string",
      "modifiedDT": "2026-01-29T03:23:18.927Z",
      "name": "string",
      "number": "string",
      "officeDuration": 0,
      "officeStartDT": "2026-01-29T03:23:18.927Z",
      "partCadIds": [
        "string"
      ],
      "projectId": "string",
      "purchasingDuration": 0,
      "purchasingStartDT": "2026-01-29T03:23:18.927Z",
      "qrCodeUrl": "string",
      "requiredDT": "2026-01-29T03:23:18.927Z",
      "selectedTaskWorkflowIdsForAssemblyAndPartCadIds": {
        "additionalProp1": "string",
        "additionalProp2": "string",
        "additionalProp3": "string"
      },
      "shopDuration": 0,
      "startDT": "2026-01-29T03:23:18.927Z",
      "status": "0 = Active",
      "statusName": "string",
      "viewId": "string",
      "isViewIdOverridden": true
    }
  ],
  "pageOffset": 0,
  "pageLimit": 0,
  "pageCount": 0,
  "total": 0,
  "truncatedResults": true,
  "truncatedReason": "string",
  "filterOptions": [
    {
      "isValueConcatenated": true,
      "data": "string",
      "options": [
        "string"
      ]
    }
  ],
  "links": {
    "additionalProp1": "string",
    "additionalProp2": "string",
    "additionalProp3": "string"
  }
}No links400Bad RequestNo links401UnauthorizedNo links404Not FoundNo links500Internal Server ErrorNo linksNameDescriptionid *string(path)STRATUS Package Idinclude(query)A comma delimited list of JSON properties to return. All remaining JSON properties will removed from the JSON response. Example: id, description, cutListItems. Specific dictionary keys can be included as follows: properties["Family"], propertiesGtp["Material"]CodeDescriptionLinks200OKMedia typeControls Accept header.{
  "assemblyIds": [
    "string"
  ],
  "bimAreaId": "string",
  "bimAreaName": "string",
  "cadIdsBySequence": [
    "string"
  ],
  "categoryId": "string",
  "createdBy": "string",
  "createdDT": "2026-01-29T03:23:18.971Z",
  "currentTrackingStatusId": "string",
  "currentDivisionId": "string",
  "description": "string",
  "fieldIdToValueMap": {
    "additionalProp1": "string",
    "additionalProp2": "string",
    "additionalProp3": "string"
  },
  "fieldNameToValueMap": {
    "additionalProp1": "string",
    "additionalProp2": "string",
    "additionalProp3": "string"
  },
  "hoursEstimatedField": 0,
  "hoursEstimatedOffice": 0,
  "hoursEstimatedPurchasing": 0,
  "hoursEstimatedShop": 0,
  "id": "string",
  "installedDT": "2026-01-29T03:23:18.971Z",
  "modelId": "string",
  "modifiedBy": "string",
  "modifiedDT": "2026-01-29T03:23:18.971Z",
  "name": "string",
  "number": "string",
  "officeDuration": 0,
  "officeStartDT": "2026-01-29T03:23:18.971Z",
  "partCadIds": [
    "string"
  ],
  "projectId": "string",
  "purchasingDuration": 0,
  "purchasingStartDT": "2026-01-29T03:23:18.971Z",
  "qrCodeUrl": "string",
  "requiredDT": "2026-01-29T03:23:18.971Z",
  "selectedTaskWorkflowIdsForAssemblyAndPartCadIds": {
    "additionalProp1": "string",
    "additionalProp2": "string",
    "additionalProp3": "string"
  },
  "shopDuration": 0,
  "startDT": "2026-01-29T03:23:18.971Z",
  "status": "0 = Active",
  "statusName": "string",
  "viewId": "string",
  "isViewIdOverridden": true
}No links400Bad RequestNo links401UnauthorizedNo links404Not FoundNo links500Internal Server ErrorNo linksNameDescriptionid *string(path)STRATUS Package Idinclude(query)A comma delimited list of JSON properties to return. All remaining JSON properties will removed from the JSON response. Example: id, description, cutListItems. Specific dictionary keys can be included as follows: properties["Family"], propertiesGtp["Material"]CodeDescriptionLinks200OKMedia typeControls Accept header.[
  {
    "id": "string",
    "projectId": "string",
    "modelId": "string",
    "stratusDimensionType": "0 = AliasTag",
    "orderId": "string",
    "assemblyId": "string",
    "partCadIds": [
      "string"
    ],
    "colorIndex": 0,
    "dimensionLineType": "0 = LabelOnly",
    "connectedAssemblyId": "string",
    "distance": 0,
    "label": "string",
    "lineVertices": [
      {
        "x": 0,
        "y": 0,
        "z": 0
      }
    ],
    "location": {
      "x": 0,
      "y": 0,
      "z": 0
    },
    "gridlineAnnotation": "string",
    "dimensionAnchorTypes": [
      {
        "location": {
          "x": 0,
          "y": 0,
          "z": 0
        },
        "partPointType": "0 = Unspecified"
      }
    ]
  }
]No links400Bad RequestNo links401UnauthorizedNo links404Not FoundNo links500Internal Server ErrorNo linksNameDescriptionid *string(path)STRATUS Package Idinclude(query)A comma delimited list of JSON properties to return. All remaining JSON properties will removed from the JSON response. Example: id, description, cutListItems. Specific dictionary keys can be included as follows: properties["Family"], propertiesGtp["Material"]where(query)Filter on JSON property values. Example: To filter on two JSON properties: length eq '10' AND description == "truck". To get the last 30 days of data, use: createdDT ge DateTime.Now.AddDays(-30)page(query)Offset retrieves a given page of data, where 0 is the 1st page, etc (number of elements per page is set by PageSize below)pagesize(query)Optional: defines the number of elements per page (default (and max) is 1000)disabletotal(query)Optional: disable total calculation to improve performance (default is false)CodeDescriptionLinks200OKMedia typeControls Accept header.{
  "data": [
    {
      "id": "string",
      "createdById": "string",
      "createdDT": "2026-01-29T03:23:19.074Z",
      "projectId": "string",
      "modelId": "string",
      "referenceType": "0 = Unspecified",
      "referenceName": "string",
      "referenceId": "string",
      "role": "0 = Unspecified",
      "roleName": "string",
      "fileType": "0 = Unspecified",
      "fileTypeName": "string",
      "localFilePath": "string",
      "fileName": "string",
      "overriddenRemoteFolder": "string"
    }
  ],
  "pageOffset": 0,
  "pageLimit": 0,
  "pageCount": 0,
  "total": 0,
  "truncatedResults": true,
  "truncatedReason": "string",
  "filterOptions": [
    {
      "isValueConcatenated": true,
      "data": "string",
      "options": [
        "string"
      ]
    }
  ],
  "links": {
    "additionalProp1": "string",
    "additionalProp2": "string",
    "additionalProp3": "string"
  }
}No links400Bad RequestNo links401UnauthorizedNo links404Not FoundNo links500Internal Server ErrorNo linksNameDescriptionid *string(path)STRATUS Package Idinclude(query)A comma delimited list of JSON properties to return. All remaining JSON properties will removed from the JSON response. Example: id, description, cutListItems. Specific dictionary keys can be included as follows: properties["Family"], propertiesGtp["Material"]CodeDescriptionLinks200OKMedia typeControls Accept header.{
  "id": "string",
  "divisionId": "string",
  "projectId": "string",
  "modelId": "string",
  "packageId": "string",
  "requiredDT": "2026-01-29T03:23:19.116Z",
  "isLocked": true,
  "generatedDT": "2026-01-29T03:23:19.116Z",
  "generatedByName": "string",
  "lockedDT": "2026-01-29T03:23:19.116Z",
  "lockedByName": "string",
  "unlockedDT": "2026-01-29T03:23:19.116Z",
  "unlockedByName": "string",
  "lineItems": [
    {
      "groupedPartCadIds": [
        "string"
      ],
      "sequence": 0,
      "isModeled": true,
      "isReportable": true,
      "isConsolidated": true,
      "manufacturer": "string",
      "quantity": 0,
      "size": "string",
      "description": "string",
      "material": "string",
      "productCode": "string",
      "diameter": "string",
      "width": "string",
      "length": "string",
      "isLengthNestable": true,
      "nominalStockLength": "string",
      "additionalProperty": "string",
      "unitOfMeasure": "0 = Bundle",
      "unitOfMeasureName": "string",
      "comment": "string",
      "notPurchased": true,
      "isAncillary": true,
      "serviceName": "string",
      "serviceCode": "string",
      "possibleSupplierCodes": {
        "additionalProp1": "string",
        "additionalProp2": "string",
        "additionalProp3": "string"
      }
    }
  ]
}No links400Bad RequestNo links401UnauthorizedNo links404Not FoundNo links500Internal Server ErrorNo linksNameDescriptionid *string(path)STRATUS Package Idreportid *string(path)STRATUS Company Report IdCodeDescriptionLinks200OKMedia typeControls Accept header."string"No links400Bad RequestNo links401UnauthorizedNo links404Not FoundNo links429Too Many RequestsNo links500Internal Server ErrorNo linksNameDescriptionpackageIdstring(query)Package Id. Empty=all (def).Default value :projectIdstring(query)Project Id. Empty=all (def).modelIdstring(query)Model Id. Empty=all (def).reportIdstring(query)Id of report to run. Empty=dashboard.businessUnitsstring(query)Project Business Units. Empty=all (def). Semicolon separated list of values as filter.divisionsstring(query)Division Names or Ids. Empty=all (def). Semicolon separated list of values as filter.packageCategoriesstring(query)Package Category Names or Ids. Empty=all (def). Semicolon separated list of values as filter.activeboolean(query)Active packages. true is def.Default value : truearchivedboolean(query)Archived packages. false is def.Default value : falseCodeDescriptionLinks200OKMedia typeControls Accept header.stringNo links400Bad RequestNo links401UnauthorizedNo links404Not FoundNo links429Too Many RequestsNo links500Internal Server ErrorNo linksNameDescriptionid *string(path)STRATUS Package Idinclude(query)A comma delimited list of JSON properties to return. All remaining JSON properties will removed from the JSON response. Example: id, description, cutListItems. Specific dictionary keys can be included as follows: properties["Family"], propertiesGtp["Material"]where(query)Filter on JSON property values. Example: To filter on two JSON properties: length eq '10' AND description == "truck". To get the last 30 days of data, use: createdDT ge DateTime.Now.AddDays(-30)page(query)Offset retrieves a given page of data, where 0 is the 1st page, etc (number of elements per page is set by PageSize below)pagesize(query)Optional: defines the number of elements per page (default (and max) is 1000)disabletotal(query)Optional: disable total calculation to improve performance (default is false)CodeDescriptionLinks200OKMedia typeControls Accept header.{
  "data": [
    {
      "id": "string",
      "createdDT": "2026-01-29T03:23:19.321Z",
      "modifiedDT": "2026-01-29T03:23:19.321Z",
      "projectId": "string",
      "modelId": "string",
      "cadId": "string",
      "sheetId": "string",
      "viewId": "string",
      "isViewIdOverridden": true,
      "currentTrackingStatusId": "string",
      "currentDivisionId": "string",
      "assemblyType": "0 = Unspecified",
      "assemblyTypeLabel": "string",
      "excludedCadIds": [
        "string"
      ],
      "fieldIdToValueMap": {
        "additionalProp1": "string",
        "additionalProp2": "string",
        "additionalProp3": "string"
      },
      "fieldNameToValueMap": {
        "additionalProp1": "string",
        "additionalProp2": "string",
        "additionalProp3": "string"
      },
      "name": "string",
      "nameLabel": "string",
      "partIds": [
        "string"
      ],
      "instanceIndex": "string",
      "lastUsedAssembliesPartsTableReportIds": [
        "string"
      ],
      "qrCodeUrl": "string",
      "notes": [
        {
          "isPartialData": true,
          "isReadOnly": true,
          "id": "string",
          "createdDT": "2026-01-29T03:23:19.321Z",
          "createdById": "string",
          "modifiedDT": "2026-01-29T03:23:19.321Z",
          "modifiedById": "string",
          "name": "string"
        }
      ],
      "defaultOrientationForReportTemplatesForgeViewerViewJson": {
        "additionalProp1": "string",
        "additionalProp2": "string",
        "additionalProp3": "string"
      }
    }
  ],
  "pageOffset": 0,
  "pageLimit": 0,
  "pageCount": 0,
  "total": 0,
  "truncatedResults": true,
  "truncatedReason": "string",
  "filterOptions": [
    {
      "isValueConcatenated": true,
      "data": "string",
      "options": [
        "string"
      ]
    }
  ],
  "links": {
    "additionalProp1": "string",
    "additionalProp2": "string",
    "additionalProp3": "string"
  }
}No links400Bad RequestNo links401UnauthorizedNo links404Not FoundNo links500Internal Server ErrorNo linksNameDescriptionid *string(path)STRATUS Package IdincludeAssemblyPartsboolean(query)OPTIONALDefault value : falseincludeStratusPropertiesboolean(query)Pass true to this optional query parameter if you want to generate STRATUS.Part.* properties and have them returned for the parts.Default value : falseexcludeNullAndEmptyboolean(query)Pass true to this optional query parameter if you want empty or null values removed from the part's Properties and PropertiesGtp collections to improve performance.Default value : falseinclude(query)A comma delimited list of JSON properties to return. All remaining JSON properties will removed from the JSON response. Example: id, description, cutListItems. Specific dictionary keys can be included as follows: properties["Family"], propertiesGtp["Material"]where(query)Filter on JSON property values. Example: To filter on two JSON properties: length eq '10' AND description == "truck". To get the last 30 days of data, use: createdDT ge DateTime.Now.AddDays(-30)page(query)Offset retrieves a given page of data, where 0 is the 1st page, etc (number of elements per page is set by PageSize below)pagesize(query)Optional: defines the number of elements per page (default (and max) is 100)disabletotal(query)Optional: disable total calculation to improve performance (default is false)CodeDescriptionLinks200OKMedia typeControls Accept header.{
  "data": [
    {
      "id": "string",
      "createdDT": "2026-01-29T03:23:19.414Z",
      "modifiedDT": "2026-01-29T03:23:19.414Z",
      "cutDT": "2026-01-29T03:23:19.414Z",
      "projectId": "string",
      "projectName": "string",
      "projectNumber": "string",
      "modelId": "string",
      "modelName": "string",
      "bimAreaId": "string",
      "bimArea": "string",
      "cadId": "string",
      "cadType": "string",
      "webId": "string",
      "description": "string",
      "currentTrackingStatusId": "string",
      "currentDivisionId": "string",
      "properties": {
        "additionalProp1": "string",
        "additionalProp2": "string",
        "additionalProp3": "string"
      },
      "propertiesGtp": {
        "additionalProp1": "string",
        "additionalProp2": "string",
        "additionalProp3": "string"
      },
      "points": [
        {
          "pointType": "0 = Unspecified",
          "cadId": "string",
          "location": {
            "x": 0,
            "y": 0,
            "z": 0
          },
          "direction": {
            "x": 0,
            "y": 0,
            "z": 0
          },
          "upVector": {
            "x": 0,
            "y": 0,
            "z": 0
          },
          "width": 0,
          "height": 0,
          "matingElementUniqueId": "string"
        }
      ],
      "cutLengthAdjustment": 0,
      "cutLength2Adjustment": 0,
      "lockLength": true,
      "lockLocation": true,
      "qrCodeUrl": "string",
      "partUrl": "string",
      "patternNumber": "string",
      "source": "0 = PublishedModel",
      "fieldIdToValueMap": {
        "additionalProp1": "string",
        "additionalProp2": "string",
        "additionalProp3": "string"
      },
      "fieldNameToValueMap": {
        "additionalProp1": "string",
        "additionalProp2": "string",
        "additionalProp3": "string"
      }
    }
  ],
  "pageOffset": 0,
  "pageLimit": 0,
  "pageCount": 0,
  "total": 0,
  "truncatedResults": true,
  "truncatedReason": "string",
  "filterOptions": [
    {
      "isValueConcatenated": true,
      "data": "string",
      "options": [
        "string"
      ]
    }
  ],
  "links": {
    "additionalProp1": "string",
    "additionalProp2": "string",
    "additionalProp3": "string"
  }
}No links400Bad RequestNo links401UnauthorizedNo links404Not FoundNo links500Internal Server ErrorNo linksNameDescriptionqrcode *string(path)The decoded text from a STRATUS QR Code -- being a URL or just the last eight characters of the URL.include(query)A comma delimited list of JSON properties to return. All remaining JSON properties will removed from the JSON response. Example: id, description, cutListItems. Specific dictionary keys can be included as follows: properties["Family"], propertiesGtp["Material"]CodeDescriptionLinks200OKMedia typeControls Accept header.{
  "assemblyIds": [
    "string"
  ],
  "bimAreaId": "string",
  "bimAreaName": "string",
  "cadIdsBySequence": [
    "string"
  ],
  "categoryId": "string",
  "createdBy": "string",
  "createdDT": "2026-01-29T03:23:19.454Z",
  "currentTrackingStatusId": "string",
  "currentDivisionId": "string",
  "description": "string",
  "fieldIdToValueMap": {
    "additionalProp1": "string",
    "additionalProp2": "string",
    "additionalProp3": "string"
  },
  "fieldNameToValueMap": {
    "additionalProp1": "string",
    "additionalProp2": "string",
    "additionalProp3": "string"
  },
  "hoursEstimatedField": 0,
  "hoursEstimatedOffice": 0,
  "hoursEstimatedPurchasing": 0,
  "hoursEstimatedShop": 0,
  "id": "string",
  "installedDT": "2026-01-29T03:23:19.454Z",
  "modelId": "string",
  "modifiedBy": "string",
  "modifiedDT": "2026-01-29T03:23:19.454Z",
  "name": "string",
  "number": "string",
  "officeDuration": 0,
  "officeStartDT": "2026-01-29T03:23:19.454Z",
  "partCadIds": [
    "string"
  ],
  "projectId": "string",
  "purchasingDuration": 0,
  "purchasingStartDT": "2026-01-29T03:23:19.454Z",
  "qrCodeUrl": "string",
  "requiredDT": "2026-01-29T03:23:19.454Z",
  "selectedTaskWorkflowIdsForAssemblyAndPartCadIds": {
    "additionalProp1": "string",
    "additionalProp2": "string",
    "additionalProp3": "string"
  },
  "shopDuration": 0,
  "startDT": "2026-01-29T03:23:19.454Z",
  "status": "0 = Active",
  "statusName": "string",
  "viewId": "string",
  "isViewIdOverridden": true
}No links400Bad RequestNo links401UnauthorizedNo links404Not FoundNo links500Internal Server ErrorNo linksNameDescriptionid *string(path)STRATUS Package IdtrackingLogEntryIdstring(query)Optional TrackingLogEntry Id to associate Attachment with a TrackingLogEntryCodeDescriptionLinks200OKMedia typeControls Accept header.{
  "id": "string",
  "createdById": "string",
  "createdDT": "2026-01-29T03:23:19.493Z",
  "projectId": "string",
  "modelId": "string",
  "referenceType": "0 = Unspecified",
  "referenceName": "string",
  "referenceId": "string",
  "role": "0 = Unspecified",
  "roleName": "string",
  "fileType": "0 = Unspecified",
  "fileTypeName": "string",
  "localFilePath": "string",
  "fileName": "string",
  "overriddenRemoteFolder": "string"
}No links400Bad RequestNo links401UnauthorizedNo links404Not FoundNo links500Internal Server ErrorNo linksNameDescriptionid *string(path)STRATUS Package IdREQUIRED: CutListDataApi - minimum json includes material, size, and cutListItems list with at least one entry containing lengthInInches{
  "id": "string",
  "completedDT": "2026-01-29T03:23:19.534Z",
  "createdDT": "2026-01-29T03:23:19.534Z",
  "createdById": "string",
  "modifiedDT": "2026-01-29T03:23:19.534Z",
  "modifiedById": "string",
  "cutListItems": [
    {
      "area": "string",
      "assemblyId": "string",
      "assemblyName": "string",
      "index": 0,
      "cadId": "string",
      "cutDateTime": "2026-01-29T03:23:19.534Z",
      "description": "string",
      "itemNumber": "string",
      "lengthInInches": 0,
      "lengthInFeetAndInches": "string",
      "level": "string",
      "preFabId": "string",
      "qrCode": "string",
      "userData1": "string",
      "userData2": "string",
      "userData3": "string",
      "userData4": "string",
      "userData5": "string",
      "userData6": "string",
      "userData7": "string",
      "userData8": "string",
      "userData9": "string",
      "userData10": "string",
      "userData11": "string",
      "userData12": "string",
      "userData13": "string",
      "userData14": "string",
      "userData15": "string"
    }
  ],
  "cutListItemCount": 0,
  "cutListStatus": "0 = New",
  "cutListStatusLabel": "string",
  "cutListStatusName": "string",
  "isAutoGeneratedCutList": true,
  "material": "string",
  "modelId": "string",
  "name": "string",
  "packageId": "string",
  "projectId": "string",
  "requestedDT": "2026-01-29T03:23:19.534Z",
  "requestedUserId": "string",
  "size": "string",
  "startedDT": "2026-01-29T03:23:19.534Z",
  "stationId": "string",
  "totalLengthInInches": 0,
  "totalLengthInFeetAndInches": "string"
}CodeDescriptionLinks200OKMedia typeControls Accept header.{
  "id": "string",
  "completedDT": "2026-01-29T03:23:19.543Z",
  "createdDT": "2026-01-29T03:23:19.543Z",
  "createdById": "string",
  "modifiedDT": "2026-01-29T03:23:19.543Z",
  "modifiedById": "string",
  "cutListItems": [
    {
      "area": "string",
      "assemblyId": "string",
      "assemblyName": "string",
      "index": 0,
      "cadId": "string",
      "cutDateTime": "2026-01-29T03:23:19.543Z",
      "description": "string",
      "itemNumber": "string",
      "lengthInInches": 0,
      "lengthInFeetAndInches": "string",
      "level": "string",
      "preFabId": "string",
      "qrCode": "string",
      "userData1": "string",
      "userData2": "string",
      "userData3": "string",
      "userData4": "string",
      "userData5": "string",
      "userData6": "string",
      "userData7": "string",
      "userData8": "string",
      "userData9": "string",
      "userData10": "string",
      "userData11": "string",
      "userData12": "string",
      "userData13": "string",
      "userData14": "string",
      "userData15": "string"
    }
  ],
  "cutListItemCount": 0,
  "cutListStatus": "0 = New",
  "cutListStatusLabel": "string",
  "cutListStatusName": "string",
  "isAutoGeneratedCutList": true,
  "material": "string",
  "modelId": "string",
  "name": "string",
  "packageId": "string",
  "percentComplete": 0,
  "projectId": "string",
  "requestedDT": "2026-01-29T03:23:19.543Z",
  "requestedUserId": "string",
  "size": "string",
  "startedDT": "2026-01-29T03:23:19.543Z",
  "stationId": "string",
  "totalLengthInInches": 0,
  "totalLengthInFeetAndInches": "string"
}No links400Bad RequestNo links401UnauthorizedNo links404Not FoundNo links500Internal Server ErrorNo linksNameDescriptionid *string(path)STRATUS Package IdREQUIRED: TrackingStatusId{
  "comment": "string",
  "costTypeId": "string",
  "createdDT": "2026-01-29T03:23:19.588Z",
  "divisionId": "string",
  "hours": 0,
  "trackingLogEntryIdResult": "string",
  "trackingStatusId": "string"
}CodeDescriptionLinks200OKMedia typeControls Accept header.{
  "comment": "string",
  "costTypeId": "string",
  "createdDT": "2026-01-29T03:23:19.593Z",
  "divisionId": "string",
  "hours": 0,
  "trackingLogEntryIdResult": "string",
  "trackingStatusId": "string"
}No links400Bad RequestNo links401UnauthorizedNo links404Not FoundNo links500Internal Server ErrorNo linksNameDescriptionid *string(path)STRATUS Package IdArray of Assembly CadIds to add.CodeDescriptionLinks200OKMedia typeControls Accept header.{
  "assemblyIds": [
    "string"
  ],
  "bimAreaId": "string",
  "bimAreaName": "string",
  "cadIdsBySequence": [
    "string"
  ],
  "categoryId": "string",
  "createdBy": "string",
  "createdDT": "2026-01-29T03:23:19.644Z",
  "currentTrackingStatusId": "string",
  "currentDivisionId": "string",
  "description": "string",
  "fieldIdToValueMap": {
    "additionalProp1": "string",
    "additionalProp2": "string",
    "additionalProp3": "string"
  },
  "fieldNameToValueMap": {
    "additionalProp1": "string",
    "additionalProp2": "string",
    "additionalProp3": "string"
  },
  "hoursEstimatedField": 0,
  "hoursEstimatedOffice": 0,
  "hoursEstimatedPurchasing": 0,
  "hoursEstimatedShop": 0,
  "id": "string",
  "installedDT": "2026-01-29T03:23:19.644Z",
  "modelId": "string",
  "modifiedBy": "string",
  "modifiedDT": "2026-01-29T03:23:19.644Z",
  "name": "string",
  "number": "string",
  "officeDuration": 0,
  "officeStartDT": "2026-01-29T03:23:19.644Z",
  "partCadIds": [
    "string"
  ],
  "projectId": "string",
  "purchasingDuration": 0,
  "purchasingStartDT": "2026-01-29T03:23:19.644Z",
  "qrCodeUrl": "string",
  "requiredDT": "2026-01-29T03:23:19.644Z",
  "selectedTaskWorkflowIdsForAssemblyAndPartCadIds": {
    "additionalProp1": "string",
    "additionalProp2": "string",
    "additionalProp3": "string"
  },
  "shopDuration": 0,
  "startDT": "2026-01-29T03:23:19.644Z",
  "status": "0 = Active",
  "statusName": "string",
  "viewId": "string",
  "isViewIdOverridden": true
}No links400Bad RequestNo links401UnauthorizedNo links404Not FoundNo links500Internal Server ErrorNo linksNameDescriptionid *string(path)STRATUS Package IdArray of Assembly CadIds used to replace existing.CodeDescriptionLinks200OKMedia typeControls Accept header.{
  "assemblyIds": [
    "string"
  ],
  "bimAreaId": "string",
  "bimAreaName": "string",
  "cadIdsBySequence": [
    "string"
  ],
  "categoryId": "string",
  "createdBy": "string",
  "createdDT": "2026-01-29T03:23:19.697Z",
  "currentTrackingStatusId": "string",
  "currentDivisionId": "string",
  "description": "string",
  "fieldIdToValueMap": {
    "additionalProp1": "string",
    "additionalProp2": "string",
    "additionalProp3": "string"
  },
  "fieldNameToValueMap": {
    "additionalProp1": "string",
    "additionalProp2": "string",
    "additionalProp3": "string"
  },
  "hoursEstimatedField": 0,
  "hoursEstimatedOffice": 0,
  "hoursEstimatedPurchasing": 0,
  "hoursEstimatedShop": 0,
  "id": "string",
  "installedDT": "2026-01-29T03:23:19.697Z",
  "modelId": "string",
  "modifiedBy": "string",
  "modifiedDT": "2026-01-29T03:23:19.697Z",
  "name": "string",
  "number": "string",
  "officeDuration": 0,
  "officeStartDT": "2026-01-29T03:23:19.697Z",
  "partCadIds": [
    "string"
  ],
  "projectId": "string",
  "purchasingDuration": 0,
  "purchasingStartDT": "2026-01-29T03:23:19.697Z",
  "qrCodeUrl": "string",
  "requiredDT": "2026-01-29T03:23:19.697Z",
  "selectedTaskWorkflowIdsForAssemblyAndPartCadIds": {
    "additionalProp1": "string",
    "additionalProp2": "string",
    "additionalProp3": "string"
  },
  "shopDuration": 0,
  "startDT": "2026-01-29T03:23:19.697Z",
  "status": "0 = Active",
  "statusName": "string",
  "viewId": "string",
  "isViewIdOverridden": true
}No links400Bad RequestNo links401UnauthorizedNo links404Not FoundNo links500Internal Server ErrorNo linksNameDescriptionid *string(path)STRATUS Package IdArray of Part CadIds used to replace existing.CodeDescriptionLinks200OKMedia typeControls Accept header.{
  "assemblyIds": [
    "string"
  ],
  "bimAreaId": "string",
  "bimAreaName": "string",
  "cadIdsBySequence": [
    "string"
  ],
  "categoryId": "string",
  "createdBy": "string",
  "createdDT": "2026-01-29T03:23:19.744Z",
  "currentTrackingStatusId": "string",
  "currentDivisionId": "string",
  "description": "string",
  "fieldIdToValueMap": {
    "additionalProp1": "string",
    "additionalProp2": "string",
    "additionalProp3": "string"
  },
  "fieldNameToValueMap": {
    "additionalProp1": "string",
    "additionalProp2": "string",
    "additionalProp3": "string"
  },
  "hoursEstimatedField": 0,
  "hoursEstimatedOffice": 0,
  "hoursEstimatedPurchasing": 0,
  "hoursEstimatedShop": 0,
  "id": "string",
  "installedDT": "2026-01-29T03:23:19.744Z",
  "modelId": "string",
  "modifiedBy": "string",
  "modifiedDT": "2026-01-29T03:23:19.744Z",
  "name": "string",
  "number": "string",
  "officeDuration": 0,
  "officeStartDT": "2026-01-29T03:23:19.744Z",
  "partCadIds": [
    "string"
  ],
  "projectId": "string",
  "purchasingDuration": 0,
  "purchasingStartDT": "2026-01-29T03:23:19.744Z",
  "qrCodeUrl": "string",
  "requiredDT": "2026-01-29T03:23:19.744Z",
  "selectedTaskWorkflowIdsForAssemblyAndPartCadIds": {
    "additionalProp1": "string",
    "additionalProp2": "string",
    "additionalProp3": "string"
  },
  "shopDuration": 0,
  "startDT": "2026-01-29T03:23:19.744Z",
  "status": "0 = Active",
  "statusName": "string",
  "viewId": "string",
  "isViewIdOverridden": true
}No links400Bad RequestNo links401UnauthorizedNo links404Not FoundNo links500Internal Server ErrorNo linksNameDescriptionid *string(path)STRATUS Package IdExample JSON KeyValuePair: {
  "key": "string",
  "value": "string"
}CodeDescriptionLinks200OKMedia typeControls Accept header.{
  "key": "string",
  "value": "string"
}No links400Bad RequestNo links401UnauthorizedNo links404Not FoundNo links500Internal Server ErrorNo linksNameDescriptionid *string(path)STRATUS Package IdExample JSON Array of KeyValuePair: [,,...][
  {
    "key": "string",
    "value": "string"
  }
]CodeDescriptionLinks200OKMedia typeControls Accept header.0No links400Bad RequestNo links401UnauthorizedNo links404Not FoundNo links500Internal Server ErrorNo linksNameDescriptionid *string(path)STRATUS Package IdArray of Part CadIds to add.CodeDescriptionLinks200OKMedia typeControls Accept header.{
  "assemblyIds": [
    "string"
  ],
  "bimAreaId": "string",
  "bimAreaName": "string",
  "cadIdsBySequence": [
    "string"
  ],
  "categoryId": "string",
  "createdBy": "string",
  "createdDT": "2026-01-29T03:23:19.889Z",
  "currentTrackingStatusId": "string",
  "currentDivisionId": "string",
  "description": "string",
  "fieldIdToValueMap": {
    "additionalProp1": "string",
    "additionalProp2": "string",
    "additionalProp3": "string"
  },
  "fieldNameToValueMap": {
    "additionalProp1": "string",
    "additionalProp2": "string",
    "additionalProp3": "string"
  },
  "hoursEstimatedField": 0,
  "hoursEstimatedOffice": 0,
  "hoursEstimatedPurchasing": 0,
  "hoursEstimatedShop": 0,
  "id": "string",
  "installedDT": "2026-01-29T03:23:19.889Z",
  "modelId": "string",
  "modifiedBy": "string",
  "modifiedDT": "2026-01-29T03:23:19.889Z",
  "name": "string",
  "number": "string",
  "officeDuration": 0,
  "officeStartDT": "2026-01-29T03:23:19.889Z",
  "partCadIds": [
    "string"
  ],
  "projectId": "string",
  "purchasingDuration": 0,
  "purchasingStartDT": "2026-01-29T03:23:19.889Z",
  "qrCodeUrl": "string",
  "requiredDT": "2026-01-29T03:23:19.889Z",
  "selectedTaskWorkflowIdsForAssemblyAndPartCadIds": {
    "additionalProp1": "string",
    "additionalProp2": "string",
    "additionalProp3": "string"
  },
  "shopDuration": 0,
  "startDT": "2026-01-29T03:23:19.889Z",
  "status": "0 = Active",
  "statusName": "string",
  "viewId": "string",
  "isViewIdOverridden": true
}No links400Bad RequestNo links401UnauthorizedNo links404Not FoundNo links500Internal Server ErrorNo linksId is required.
Status: 0 = Active, 1 = Archived.{
  "categoryId": "string",
  "description": "string",
  "hoursEstimatedField": 0,
  "hoursEstimatedOffice": 0,
  "hoursEstimatedPurchasing": 0,
  "hoursEstimatedShop": 0,
  "id": "string",
  "installedDT": "2026-01-29T03:23:19.930Z",
  "name": "string",
  "number": "string",
  "officeDuration": 0,
  "officeStartDT": "2026-01-29T03:23:19.930Z",
  "purchasingDuration": 0,
  "purchasingStartDT": "2026-01-29T03:23:19.930Z",
  "requiredDT": "2026-01-29T03:23:19.930Z",
  "shopDuration": 0,
  "startDT": "2026-01-29T03:23:19.930Z",
  "status": 0
}CodeDescriptionLinks200OKMedia typeControls Accept header.{
  "assemblyIds": [
    "string"
  ],
  "bimAreaId": "string",
  "bimAreaName": "string",
  "cadIdsBySequence": [
    "string"
  ],
  "categoryId": "string",
  "createdBy": "string",
  "createdDT": "2026-01-29T03:23:19.937Z",
  "currentTrackingStatusId": "string",
  "currentDivisionId": "string",
  "description": "string",
  "fieldIdToValueMap": {
    "additionalProp1": "string",
    "additionalProp2": "string",
    "additionalProp3": "string"
  },
  "fieldNameToValueMap": {
    "additionalProp1": "string",
    "additionalProp2": "string",
    "additionalProp3": "string"
  },
  "hoursEstimatedField": 0,
  "hoursEstimatedOffice": 0,
  "hoursEstimatedPurchasing": 0,
  "hoursEstimatedShop": 0,
  "id": "string",
  "installedDT": "2026-01-29T03:23:19.937Z",
  "modelId": "string",
  "modifiedBy": "string",
  "modifiedDT": "2026-01-29T03:23:19.937Z",
  "name": "string",
  "number": "string",
  "officeDuration": 0,
  "officeStartDT": "2026-01-29T03:23:19.937Z",
  "partCadIds": [
    "string"
  ],
  "projectId": "string",
  "purchasingDuration": 0,
  "purchasingStartDT": "2026-01-29T03:23:19.937Z",
  "qrCodeUrl": "string",
  "requiredDT": "2026-01-29T03:23:19.937Z",
  "selectedTaskWorkflowIdsForAssemblyAndPartCadIds": {
    "additionalProp1": "string",
    "additionalProp2": "string",
    "additionalProp3": "string"
  },
  "shopDuration": 0,
  "startDT": "2026-01-29T03:23:19.937Z",
  "status": "0 = Active",
  "statusName": "string",
  "viewId": "string",
  "isViewIdOverridden": true
}No links400Bad RequestNo links401UnauthorizedNo links404Not FoundNo links500Internal Server ErrorNo links Part NameDescriptionincludeStratusPropertiesboolean(query)Pass true to this optional query parameter if you want to generate STRATUS.Part.* properties and have them returned for the parts.  When in use, query must be limited to a single model id.Default value : falseexcludeNullAndEmptyboolean(query)Pass true to this optional query parameter if you want empty or null values removed from the part's Properties and PropertiesGtp collections to improve performance.Default value : falseinclude(query)A comma delimited list of JSON properties to return. All remaining JSON properties will removed from the JSON response. Example: id, description, cutListItems. Specific dictionary keys can be included as follows: properties["Family"], propertiesGtp["Material"]where(query)Filter on JSON property values. Example: To filter on two JSON properties: length eq '10' AND description == "truck". To get the last 30 days of data, use: createdDT ge DateTime.Now.AddDays(-30)page(query)Offset retrieves a given page of data, where 0 is the 1st page, etc (number of elements per page is set by PageSize below)pagesize(query)Optional: defines the number of elements per page (default (and max) is 100)disabletotal(query)Optional: disable total calculation to improve performance (default is false)CodeDescriptionLinks200OKMedia typeControls Accept header.{
  "data": [
    {
      "id": "string",
      "createdDT": "2026-01-29T03:23:20.016Z",
      "modifiedDT": "2026-01-29T03:23:20.016Z",
      "cutDT": "2026-01-29T03:23:20.016Z",
      "projectId": "string",
      "projectName": "string",
      "projectNumber": "string",
      "modelId": "string",
      "modelName": "string",
      "bimAreaId": "string",
      "bimArea": "string",
      "cadId": "string",
      "cadType": "string",
      "webId": "string",
      "description": "string",
      "currentTrackingStatusId": "string",
      "currentDivisionId": "string",
      "properties": {
        "additionalProp1": "string",
        "additionalProp2": "string",
        "additionalProp3": "string"
      },
      "propertiesGtp": {
        "additionalProp1": "string",
        "additionalProp2": "string",
        "additionalProp3": "string"
      },
      "points": [
        {
          "pointType": "0 = Unspecified",
          "cadId": "string",
          "location": {
            "x": 0,
            "y": 0,
            "z": 0
          },
          "direction": {
            "x": 0,
            "y": 0,
            "z": 0
          },
          "upVector": {
            "x": 0,
            "y": 0,
            "z": 0
          },
          "width": 0,
          "height": 0,
          "matingElementUniqueId": "string"
        }
      ],
      "cutLengthAdjustment": 0,
      "cutLength2Adjustment": 0,
      "lockLength": true,
      "lockLocation": true,
      "qrCodeUrl": "string",
      "partUrl": "string",
      "patternNumber": "string",
      "source": "0 = PublishedModel",
      "fieldIdToValueMap": {
        "additionalProp1": "string",
        "additionalProp2": "string",
        "additionalProp3": "string"
      },
      "fieldNameToValueMap": {
        "additionalProp1": "string",
        "additionalProp2": "string",
        "additionalProp3": "string"
      }
    }
  ],
  "pageOffset": 0,
  "pageLimit": 0,
  "pageCount": 0,
  "total": 0,
  "truncatedResults": true,
  "truncatedReason": "string",
  "filterOptions": [
    {
      "isValueConcatenated": true,
      "data": "string",
      "options": [
        "string"
      ]
    }
  ],
  "links": {
    "additionalProp1": "string",
    "additionalProp2": "string",
    "additionalProp3": "string"
  }
}No links400Bad RequestNo links401UnauthorizedNo links404Not FoundNo links500Internal Server ErrorNo linksNameDescriptionqrcode *string(path)The decoded text from a STRATUS QR Code -- being a URL or just the last eight characters of the URL.includeStratusPropertiesboolean(query)Pass true to this optional query parameter if you want to generate STRATUS.Part.* properties and have them returned for the parts.  When in use, query must be limited to a single model id.Default value : falseexcludeNullAndEmptyboolean(query)Pass true to this optional query parameter if you want empty or null values removed from the part's Properties and PropertiesGtp collections to improve performance.Default value : falseinclude(query)A comma delimited list of JSON properties to return. All remaining JSON properties will removed from the JSON response. Example: id, description, cutListItems. Specific dictionary keys can be included as follows: properties["Family"], propertiesGtp["Material"]CodeDescriptionLinks200OKMedia typeControls Accept header.{
  "id": "string",
  "createdDT": "2026-01-29T03:23:20.070Z",
  "modifiedDT": "2026-01-29T03:23:20.070Z",
  "cutDT": "2026-01-29T03:23:20.070Z",
  "projectId": "string",
  "projectName": "string",
  "projectNumber": "string",
  "modelId": "string",
  "modelName": "string",
  "bimAreaId": "string",
  "bimArea": "string",
  "cadId": "string",
  "cadType": "string",
  "webId": "string",
  "description": "string",
  "currentTrackingStatusId": "string",
  "currentDivisionId": "string",
  "properties": {
    "additionalProp1": "string",
    "additionalProp2": "string",
    "additionalProp3": "string"
  },
  "propertiesGtp": {
    "additionalProp1": "string",
    "additionalProp2": "string",
    "additionalProp3": "string"
  },
  "points": [
    {
      "pointType": "0 = Unspecified",
      "cadId": "string",
      "location": {
        "x": 0,
        "y": 0,
        "z": 0
      },
      "direction": {
        "x": 0,
        "y": 0,
        "z": 0
      },
      "upVector": {
        "x": 0,
        "y": 0,
        "z": 0
      },
      "width": 0,
      "height": 0,
      "matingElementUniqueId": "string"
    }
  ],
  "cutLengthAdjustment": 0,
  "cutLength2Adjustment": 0,
  "lockLength": true,
  "lockLocation": true,
  "qrCodeUrl": "string",
  "partUrl": "string",
  "patternNumber": "string",
  "source": "0 = PublishedModel",
  "fieldIdToValueMap": {
    "additionalProp1": "string",
    "additionalProp2": "string",
    "additionalProp3": "string"
  },
  "fieldNameToValueMap": {
    "additionalProp1": "string",
    "additionalProp2": "string",
    "additionalProp3": "string"
  }
}No links400Bad RequestNo links401UnauthorizedNo links404Not FoundNo links500Internal Server ErrorNo linksNameDescriptionid *string(path)STRATUS Part IdincludeStratusPropertiesboolean(query)Pass true to this optional query parameter if you want to generate STRATUS.Part.* properties and have them returned for the parts.Default value : falseexcludeNullAndEmptyboolean(query)Pass true to this optional query parameter if you want empty or null values removed from the part's Properties and PropertiesGtp collections to improve performance.Default value : falseinclude(query)A comma delimited list of JSON properties to return. All remaining JSON properties will removed from the JSON response. Example: id, description, cutListItems. Specific dictionary keys can be included as follows: properties["Family"], propertiesGtp["Material"]CodeDescriptionLinks200OKMedia typeControls Accept header.{
  "id": "string",
  "createdDT": "2026-01-29T03:23:20.126Z",
  "modifiedDT": "2026-01-29T03:23:20.126Z",
  "cutDT": "2026-01-29T03:23:20.126Z",
  "projectId": "string",
  "projectName": "string",
  "projectNumber": "string",
  "modelId": "string",
  "modelName": "string",
  "bimAreaId": "string",
  "bimArea": "string",
  "cadId": "string",
  "cadType": "string",
  "webId": "string",
  "description": "string",
  "currentTrackingStatusId": "string",
  "currentDivisionId": "string",
  "properties": {
    "additionalProp1": "string",
    "additionalProp2": "string",
    "additionalProp3": "string"
  },
  "propertiesGtp": {
    "additionalProp1": "string",
    "additionalProp2": "string",
    "additionalProp3": "string"
  },
  "points": [
    {
      "pointType": "0 = Unspecified",
      "cadId": "string",
      "location": {
        "x": 0,
        "y": 0,
        "z": 0
      },
      "direction": {
        "x": 0,
        "y": 0,
        "z": 0
      },
      "upVector": {
        "x": 0,
        "y": 0,
        "z": 0
      },
      "width": 0,
      "height": 0,
      "matingElementUniqueId": "string"
    }
  ],
  "cutLengthAdjustment": 0,
  "cutLength2Adjustment": 0,
  "lockLength": true,
  "lockLocation": true,
  "qrCodeUrl": "string",
  "partUrl": "string",
  "patternNumber": "string",
  "source": "0 = PublishedModel",
  "fieldIdToValueMap": {
    "additionalProp1": "string",
    "additionalProp2": "string",
    "additionalProp3": "string"
  },
  "fieldNameToValueMap": {
    "additionalProp1": "string",
    "additionalProp2": "string",
    "additionalProp3": "string"
  }
}No links400Bad RequestNo links401UnauthorizedNo links404Not FoundNo links500Internal Server ErrorNo linksNameDescriptioncsvIdsstring(header)List of STRATUS Part IdsCodeDescriptionLinks200OKMedia typeControls Accept header.stringNo links400Bad RequestNo links401UnauthorizedNo links404Not FoundNo links500Internal Server ErrorNo linksNameDescriptionid *string(path)STRATUS Part IdtrackingLogEntryIdstring(query)Optional TrackingLogEntry Id to associate Attachment with a TrackingLogEntryCodeDescriptionLinks200OKMedia typeControls Accept header.{
  "id": "string",
  "createdById": "string",
  "createdDT": "2026-01-29T03:23:20.216Z",
  "projectId": "string",
  "modelId": "string",
  "referenceType": "0 = Unspecified",
  "referenceName": "string",
  "referenceId": "string",
  "role": "0 = Unspecified",
  "roleName": "string",
  "fileType": "0 = Unspecified",
  "fileTypeName": "string",
  "localFilePath": "string",
  "fileName": "string",
  "overriddenRemoteFolder": "string"
}No links400Bad RequestNo links401UnauthorizedNo links404Not FoundNo links500Internal Server ErrorNo linksNameDescriptionid *string(path)STRATUS Part IdisCutboolean(query)DEFAULT: true. If set to false, will not mark the part as cut.Default value : trueREQUIRED: TrackingStatusId{
  "comment": "string",
  "costTypeId": "string",
  "createdDT": "2026-01-29T03:23:20.285Z",
  "divisionId": "string",
  "hours": 0,
  "trackingLogEntryIdResult": "string",
  "trackingStatusId": "string"
}CodeDescriptionLinks200OKMedia typeControls Accept header.{
  "comment": "string",
  "costTypeId": "string",
  "createdDT": "2026-01-29T03:23:20.292Z",
  "divisionId": "string",
  "hours": 0,
  "trackingLogEntryIdResult": "string",
  "trackingStatusId": "string"
}No links400Bad RequestNo links401UnauthorizedNo links404Not FoundNo links500Internal Server ErrorNo linksNameDescriptionid *string(path)STRATUS Part IdExample JSON KeyValuePair: {
  "key": "string",
  "value": "string"
}CodeDescriptionLinks200OKMedia typeControls Accept header.{
  "key": "string",
  "value": "string"
}No links400Bad RequestNo links401UnauthorizedNo links404Not FoundNo links500Internal Server ErrorNo linksExample List of PartPropertiesDataApi JSON: [},}][
  {
    "id": "string",
    "properties": {
      "additionalProp1": "string",
      "additionalProp2": "string",
      "additionalProp3": "string"
    }
  }
]CodeDescriptionLinks200OKMedia typeControls Accept header.trueNo links400Bad RequestNo links401UnauthorizedNo links404Not FoundNo links500Internal Server ErrorNo linksNameDescriptionid *string(path)STRATUS Part IdExample JSON KeyValuePair: {
  "key": "string",
  "value": "string"
}CodeDescriptionLinks200OKMedia typeControls Accept header.{
  "key": "string",
  "value": "string"
}No links400Bad RequestNo links401UnauthorizedNo links404Not FoundNo links500Internal Server ErrorNo linksNameDescriptionid *string(path)STRATUS Part IdExample JSON Array of KeyValuePair: [,,...][
  {
    "key": "string",
    "value": "string"
  }
]CodeDescriptionLinks200OKMedia typeControls Accept header.0No links400Bad RequestNo links401UnauthorizedNo links404Not FoundNo links500Internal Server ErrorNo links Ping NameDescriptionapp-idstring(header)(optional) Partner App IdCodeDescriptionLinks200OKNo links401UnauthorizedNo links Project NameDescriptionid *string(path)STRATUS Project IdCodeDescriptionLinks200OKMedia typeControls Accept header.{
  "id": "string",
  "createdDT": "2026-01-29T03:23:20.560Z",
  "modifiedDT": "2026-01-29T03:23:20.560Z",
  "status": "0 = New",
  "statusName": "string",
  "a360Id": "string",
  "a360RootFolderId": "string",
  "companyId": "string",
  "category": "string",
  "number": "string",
  "name": "string",
  "phase": "string",
  "description": "string",
  "imageAttachmentId": "string",
  "address1": "string",
  "address2": "string",
  "city": "string",
  "state": "string",
  "zip": "string",
  "targetStartDate": "2026-01-29T03:23:20.560Z",
  "actualStartDate": "2026-01-29T03:23:20.560Z",
  "targetEndDate": "2026-01-29T03:23:20.560Z",
  "actualEndDate": "2026-01-29T03:23:20.560Z",
  "color": "string",
  "isTaxExempt": true
}No links400Bad RequestNo links401UnauthorizedNo links404Not FoundNo links500Internal Server ErrorNo linksNameDescriptionid *string(path)STRATUS Project IdasFlatListboolean(query)if true, results will be list of areas instead of hierarchy data structure using children, where ParentId can be used to understand hierarchyDefault value : falseCodeDescriptionLinks200OKMedia typeControls Accept header.[
  {
    "abbreviation": "string",
    "children": [
      "string"
    ],
    "code": "string",
    "color": "string",
    "createdById": "string",
    "createdDT": "2026-01-29T03:23:20.599Z",
    "elevation": 0,
    "id": "string",
    "levelBottomOffset": 0,
    "levelTopOffset": 0,
    "modifiedById": "string",
    "modifiedDT": "2026-01-29T03:23:20.599Z",
    "name": "string",
    "parentId": "string"
  }
]No links400Bad RequestNo links401UnauthorizedNo links404Not FoundNo links500Internal Server ErrorNo linksNameDescriptionid *string(path)STRATUS Project Idinclude(query)A comma delimited list of JSON properties to return. All remaining JSON properties will removed from the JSON response. Example: id, description, cutListItems. Specific dictionary keys can be included as follows: properties["Family"], propertiesGtp["Material"]where(query)Filter on JSON property values. Example: To filter on two JSON properties: length eq '10' AND description == "truck". To get the last 30 days of data, use: createdDT ge DateTime.Now.AddDays(-30)page(query)Offset retrieves a given page of data, where 0 is the 1st page, etc (number of elements per page is set by PageSize below)pagesize(query)Optional: defines the number of elements per page (default (and max) is 1000)disabletotal(query)Optional: disable total calculation to improve performance (default is false)CodeDescriptionLinks200OKMedia typeControls Accept header.{
  "data": [
    {
      "id": "string",
      "createdDT": "2026-01-29T03:23:20.669Z",
      "modifiedDT": "2026-01-29T03:23:20.669Z",
      "projectId": "string",
      "modelId": "string",
      "cadId": "string",
      "sheetId": "string",
      "viewId": "string",
      "isViewIdOverridden": true,
      "currentTrackingStatusId": "string",
      "currentDivisionId": "string",
      "assemblyType": "0 = Unspecified",
      "assemblyTypeLabel": "string",
      "excludedCadIds": [
        "string"
      ],
      "fieldIdToValueMap": {
        "additionalProp1": "string",
        "additionalProp2": "string",
        "additionalProp3": "string"
      },
      "fieldNameToValueMap": {
        "additionalProp1": "string",
        "additionalProp2": "string",
        "additionalProp3": "string"
      },
      "name": "string",
      "nameLabel": "string",
      "partIds": [
        "string"
      ],
      "instanceIndex": "string",
      "lastUsedAssembliesPartsTableReportIds": [
        "string"
      ],
      "qrCodeUrl": "string",
      "notes": [
        {
          "isPartialData": true,
          "isReadOnly": true,
          "id": "string",
          "createdDT": "2026-01-29T03:23:20.669Z",
          "createdById": "string",
          "modifiedDT": "2026-01-29T03:23:20.669Z",
          "modifiedById": "string",
          "name": "string"
        }
      ],
      "defaultOrientationForReportTemplatesForgeViewerViewJson": {
        "additionalProp1": "string",
        "additionalProp2": "string",
        "additionalProp3": "string"
      }
    }
  ],
  "pageOffset": 0,
  "pageLimit": 0,
  "pageCount": 0,
  "total": 0,
  "truncatedResults": true,
  "truncatedReason": "string",
  "filterOptions": [
    {
      "isValueConcatenated": true,
      "data": "string",
      "options": [
        "string"
      ]
    }
  ],
  "links": {
    "additionalProp1": "string",
    "additionalProp2": "string",
    "additionalProp3": "string"
  }
}No links400Bad RequestNo links401UnauthorizedNo links404Not FoundNo links500Internal Server ErrorNo linksNameDescriptionid *string(path)STRATUS Project Idinclude(query)A comma delimited list of JSON properties to return. All remaining JSON properties will removed from the JSON response. Example: id, description, cutListItems. Specific dictionary keys can be included as follows: properties["Family"], propertiesGtp["Material"]where(query)Filter on JSON property values. Example: To filter on two JSON properties: length eq '10' AND description == "truck". To get the last 30 days of data, use: createdDT ge DateTime.Now.AddDays(-30)page(query)Offset retrieves a given page of data, where 0 is the 1st page, etc (number of elements per page is set by PageSize below)pagesize(query)Optional: defines the number of elements per page (default (and max) is 1000)disabletotal(query)Optional: disable total calculation to improve performance (default is false)CodeDescriptionLinks200OKMedia typeControls Accept header.{
  "data": [
    {
      "id": "string",
      "name": "string",
      "description": "string",
      "length": "string",
      "width": "string",
      "height": "string",
      "location": "string",
      "containerTypeName": "string",
      "parentContainerId": "string",
      "currentTrackingStatusId": "string",
      "currentDivisionId": "string",
      "qrCodeUrl": "string",
      "fieldIdToValueMap": {
        "additionalProp1": "string",
        "additionalProp2": "string",
        "additionalProp3": "string"
      },
      "partIds": [
        "string"
      ],
      "assemblyCadIds": [
        "string"
      ],
      "packageIds": [
        "string"
      ],
      "containerIds": [
        "string"
      ],
      "contents": [
        {
          "projectId": "string",
          "referenceId": "string",
          "referenceType": "0 = Unspecified"
        }
      ]
    }
  ],
  "pageOffset": 0,
  "pageLimit": 0,
  "pageCount": 0,
  "total": 0,
  "truncatedResults": true,
  "truncatedReason": "string",
  "filterOptions": [
    {
      "isValueConcatenated": true,
      "data": "string",
      "options": [
        "string"
      ]
    }
  ],
  "links": {
    "additionalProp1": "string",
    "additionalProp2": "string",
    "additionalProp3": "string"
  }
}No links400Bad RequestNo links401UnauthorizedNo links404Not FoundNo links500Internal Server ErrorNo linksNameDescriptionid *string(path)STRATUS Project Idinclude(query)A comma delimited list of JSON properties to return. All remaining JSON properties will removed from the JSON response. Example: id, description, cutListItems. Specific dictionary keys can be included as follows: properties["Family"], propertiesGtp["Material"]where(query)Filter on JSON property values. Example: To filter on two JSON properties: length eq '10' AND description == "truck". To get the last 30 days of data, use: createdDT ge DateTime.Now.AddDays(-30)page(query)Offset retrieves a given page of data, where 0 is the 1st page, etc (number of elements per page is set by PageSize below)pagesize(query)Optional: defines the number of elements per page (default (and max) is 1000)disabletotal(query)Optional: disable total calculation to improve performance (default is false)CodeDescriptionLinks200OKMedia typeControls Accept header.{
  "data": [
    {
      "a360FolderId": "string",
      "createdDT": "2026-01-29T03:23:20.816Z",
      "databaseUnits": "0 = Imperial",
      "defaultViewId": "string",
      "id": "string",
      "isFieldOrderz": true,
      "lastPublishedDT": "2026-01-29T03:23:20.816Z",
      "modelName": "string",
      "modelType": "0 = Unspecified",
      "modifiedDT": "2026-01-29T03:23:20.816Z",
      "name": "string",
      "projectId": "string",
      "publishStatus": "0 = Published",
      "releaseVersion": "string"
    }
  ],
  "pageOffset": 0,
  "pageLimit": 0,
  "pageCount": 0,
  "total": 0,
  "truncatedResults": true,
  "truncatedReason": "string",
  "filterOptions": [
    {
      "isValueConcatenated": true,
      "data": "string",
      "options": [
        "string"
      ]
    }
  ],
  "links": {
    "additionalProp1": "string",
    "additionalProp2": "string",
    "additionalProp3": "string"
  }
}No links400Bad RequestNo links401UnauthorizedNo links404Not FoundNo links500Internal Server ErrorNo linksNameDescriptionid *string(path)STRATUS Project Idpage(query)Offset retrieves a given page of data, where 0 is the 1st page, etc (number of elements per page is set by PageSize below)pagesize(query)Optional: defines the number of elements per page (default (and max) is 1000)disabletotal(query)Optional: disable total calculation to improve performance (default is false)CodeDescriptionLinks200OKMedia typeControls Accept header.{
  "data": [
    {
      "id": "string",
      "name": "string",
      "number": "string",
      "description": "string",
      "statusName": "string",
      "supplierName": "string",
      "supplierResponseNumber": "string",
      "tax": 0,
      "freight": 0,
      "totalAmount": 0,
      "projectId": "string",
      "lineItems": [
        {
          "additionalProperty": "string",
          "ancillaryType": "string",
          "ancillaryUsageType": "string",
          "backorderedQTY": 0,
          "comment": "string",
          "description": "string",
          "diameter": "string",
          "isAncillary": true,
          "isModeled": true,
          "length": "string",
          "lineNumber": 0,
          "manufacturer": "string",
          "material": "string",
          "nominalStockLength": "string",
          "orderedQTY": 0,
          "partTemplateName": "string",
          "productCode": "string",
          "quotedQTY": 0,
          "serviceCode": "string",
          "serviceName": "string",
          "shippedQTY": 0,
          "size": "string",
          "totalPrice": 0,
          "unitOfMeasure": "string",
          "unitPrice": "string",
          "width": "string"
        }
      ]
    }
  ],
  "pageOffset": 0,
  "pageLimit": 0,
  "pageCount": 0,
  "total": 0,
  "truncatedResults": true,
  "truncatedReason": "string",
  "filterOptions": [
    {
      "isValueConcatenated": true,
      "data": "string",
      "options": [
        "string"
      ]
    }
  ],
  "links": {
    "additionalProp1": "string",
    "additionalProp2": "string",
    "additionalProp3": "string"
  }
}No links400Bad RequestNo links401UnauthorizedNo links404Not FoundNo links500Internal Server ErrorNo linksNameDescriptionid *string(path)STRATUS Project Idpage(query)Offset retrieves a given page of data, where 0 is the 1st page, etc (number of elements per page is set by PageSize below)pagesize(query)Optional: defines the number of elements per page (default (and max) is 1000)disabletotal(query)Optional: disable total calculation to improve performance (default is false)CodeDescriptionLinks200OKMedia typeControls Accept header.{
  "data": [
    {
      "source": "1 = STRATUS",
      "name": "string",
      "code": "string",
      "abbreviation": "string",
      "group": "string",
      "fabConfigId": "string",
      "fabServiceId": "string",
      "fabServiceSpecId": "string",
      "fabServiceInsulationSpecId": "string"
    }
  ],
  "pageOffset": 0,
  "pageLimit": 0,
  "pageCount": 0,
  "total": 0,
  "truncatedResults": true,
  "truncatedReason": "string",
  "filterOptions": [
    {
      "isValueConcatenated": true,
      "data": "string",
      "options": [
        "string"
      ]
    }
  ],
  "links": {
    "additionalProp1": "string",
    "additionalProp2": "string",
    "additionalProp3": "string"
  }
}No links400Bad RequestNo links401UnauthorizedNo links404Not FoundNo links500Internal Server ErrorNo linksNameDescriptionnonStratusProjectsOnlyboolean(query)If true, returns only projects which have not been synced to Stratus, otherwise all projects (which takes longer).CodeDescriptionLinks200OKMedia typeControls Accept header.[
  {
    "id": "string",
    "createdDT": "2026-01-29T03:23:20.966Z",
    "modifiedDT": "2026-01-29T03:23:20.966Z",
    "status": "0 = New",
    "statusName": "string",
    "a360Id": "string",
    "a360RootFolderId": "string",
    "companyId": "string",
    "category": "string",
    "number": "string",
    "name": "string",
    "phase": "string",
    "description": "string",
    "imageAttachmentId": "string",
    "address1": "string",
    "address2": "string",
    "city": "string",
    "state": "string",
    "zip": "string",
    "targetStartDate": "2026-01-29T03:23:20.966Z",
    "actualStartDate": "2026-01-29T03:23:20.966Z",
    "targetEndDate": "2026-01-29T03:23:20.966Z",
    "actualEndDate": "2026-01-29T03:23:20.966Z",
    "color": "string",
    "isTaxExempt": true
  }
]No links400Bad RequestNo links401UnauthorizedNo links404Not FoundNo links500Internal Server ErrorNo linksNameDescriptioninclude(query)A comma delimited list of JSON properties to return. All remaining JSON properties will removed from the JSON response. Example: id, description, cutListItems. Specific dictionary keys can be included as follows: properties["Family"], propertiesGtp["Material"]where(query)Filter on JSON property values. Example: To filter on two JSON properties: length eq '10' AND description == "truck". To get the last 30 days of data, use: createdDT ge DateTime.Now.AddDays(-30)page(query)Offset retrieves a given page of data, where 0 is the 1st page, etc (number of elements per page is set by PageSize below)pagesize(query)Optional: defines the number of elements per page (default (and max) is 1000)disabletotal(query)Optional: disable total calculation to improve performance (default is false)CodeDescriptionLinks200OKMedia typeControls Accept header.{
  "data": [
    {
      "id": "string",
      "createdDT": "2026-01-29T03:23:21.023Z",
      "modifiedDT": "2026-01-29T03:23:21.023Z",
      "status": "0 = New",
      "statusName": "string",
      "a360Id": "string",
      "a360RootFolderId": "string",
      "companyId": "string",
      "category": "string",
      "number": "string",
      "name": "string",
      "phase": "string",
      "description": "string",
      "imageAttachmentId": "string",
      "address1": "string",
      "address2": "string",
      "city": "string",
      "state": "string",
      "zip": "string",
      "targetStartDate": "2026-01-29T03:23:21.023Z",
      "actualStartDate": "2026-01-29T03:23:21.023Z",
      "targetEndDate": "2026-01-29T03:23:21.023Z",
      "actualEndDate": "2026-01-29T03:23:21.023Z",
      "color": "string",
      "isTaxExempt": true
    }
  ],
  "pageOffset": 0,
  "pageLimit": 0,
  "pageCount": 0,
  "total": 0,
  "truncatedResults": true,
  "truncatedReason": "string",
  "filterOptions": [
    {
      "isValueConcatenated": true,
      "data": "string",
      "options": [
        "string"
      ]
    }
  ],
  "links": {
    "additionalProp1": "string",
    "additionalProp2": "string",
    "additionalProp3": "string"
  }
}No links400Bad RequestNo links401UnauthorizedNo links404Not FoundNo links500Internal Server ErrorNo linksNameDescriptionqrcode *string(path)The decoded text from a STRATUS QR Code -- being a URL or just the last eight characters of the URL.include(query)A comma delimited list of JSON properties to return. All remaining JSON properties will removed from the JSON response. Example: id, description, cutListItems. Specific dictionary keys can be included as follows: properties["Family"], propertiesGtp["Material"]CodeDescriptionLinks200OKMedia typeControls Accept header.{
  "id": "string",
  "createdDT": "2026-01-29T03:23:21.061Z",
  "modifiedDT": "2026-01-29T03:23:21.061Z",
  "status": "0 = New",
  "statusName": "string",
  "a360Id": "string",
  "a360RootFolderId": "string",
  "companyId": "string",
  "category": "string",
  "number": "string",
  "name": "string",
  "phase": "string",
  "description": "string",
  "imageAttachmentId": "string",
  "address1": "string",
  "address2": "string",
  "city": "string",
  "state": "string",
  "zip": "string",
  "targetStartDate": "2026-01-29T03:23:21.061Z",
  "actualStartDate": "2026-01-29T03:23:21.061Z",
  "targetEndDate": "2026-01-29T03:23:21.061Z",
  "actualEndDate": "2026-01-29T03:23:21.061Z",
  "color": "string",
  "isTaxExempt": true
}No links400Bad RequestNo links401UnauthorizedNo links404Not FoundNo links500Internal Server ErrorNo linksNameDescriptionuserid *string(path)User Id specified for Project Role filtering.include(query)A comma delimited list of JSON properties to return. All remaining JSON properties will removed from the JSON response. Example: id, description, cutListItems. Specific dictionary keys can be included as follows: properties["Family"], propertiesGtp["Material"]where(query)Filter on JSON property values. Example: To filter on two JSON properties: length eq '10' AND description == "truck". To get the last 30 days of data, use: createdDT ge DateTime.Now.AddDays(-30)page(query)Offset retrieves a given page of data, where 0 is the 1st page, etc (number of elements per page is set by PageSize below)pagesize(query)Optional: defines the number of elements per page (default (and max) is 1000)disabletotal(query)Optional: disable total calculation to improve performance (default is false)CodeDescriptionLinks200OKMedia typeControls Accept header.{
  "data": [
    {
      "id": "string",
      "createdDT": "2026-01-29T03:23:21.125Z",
      "modifiedDT": "2026-01-29T03:23:21.125Z",
      "status": "0 = New",
      "statusName": "string",
      "a360Id": "string",
      "a360RootFolderId": "string",
      "companyId": "string",
      "category": "string",
      "number": "string",
      "name": "string",
      "phase": "string",
      "description": "string",
      "imageAttachmentId": "string",
      "address1": "string",
      "address2": "string",
      "city": "string",
      "state": "string",
      "zip": "string",
      "targetStartDate": "2026-01-29T03:23:21.125Z",
      "actualStartDate": "2026-01-29T03:23:21.125Z",
      "targetEndDate": "2026-01-29T03:23:21.125Z",
      "actualEndDate": "2026-01-29T03:23:21.125Z",
      "color": "string",
      "isTaxExempt": true
    }
  ],
  "pageOffset": 0,
  "pageLimit": 0,
  "pageCount": 0,
  "total": 0,
  "truncatedResults": true,
  "truncatedReason": "string",
  "filterOptions": [
    {
      "isValueConcatenated": true,
      "data": "string",
      "options": [
        "string"
      ]
    }
  ],
  "links": {
    "additionalProp1": "string",
    "additionalProp2": "string",
    "additionalProp3": "string"
  }
}No links400Bad RequestNo links401UnauthorizedNo links404Not FoundNo links500Internal Server ErrorNo linksNameDescriptionaddDefaultUserProjectRolesboolean(query)if true, default user project roles will be added to the new projectsetActiveboolean(query)if true, project will be set to Active status, otherwise set to NewPass Project object in request body.
Project object returned by call to available-autodesk-projects can be passed into this method.
Project object must contain valid A360Id and Name.
Resulting ProjectDataApi will be returned with new Stratus Project Id if successful, otherwise null.{
  "id": "string",
  "createdDT": "2026-01-29T03:23:21.177Z",
  "modifiedDT": "2026-01-29T03:23:21.177Z",
  "status": "0 = New",
  "statusName": "string",
  "a360Id": "string",
  "a360RootFolderId": "string",
  "companyId": "string",
  "category": "string",
  "number": "string",
  "name": "string",
  "phase": "string",
  "description": "string",
  "imageAttachmentId": "string",
  "address1": "string",
  "address2": "string",
  "city": "string",
  "state": "string",
  "zip": "string",
  "targetStartDate": "2026-01-29T03:23:21.177Z",
  "actualStartDate": "2026-01-29T03:23:21.177Z",
  "targetEndDate": "2026-01-29T03:23:21.177Z",
  "actualEndDate": "2026-01-29T03:23:21.177Z",
  "color": "string",
  "isTaxExempt": true
}CodeDescriptionLinks200OKNo links QRCode NameDescriptionurlSubstringstring(query)Optional: Returns all ShortURL records that have the given sub-string inside the URL field.where(query)Filter on JSON property values. Example: To filter on two JSON properties: length eq '10' AND description == "truck". To get the last 30 days of data, use: createdDT ge DateTime.Now.AddDays(-30)page(query)Offset retrieves a given page of data, where 0 is the 1st page, etc (number of elements per page is set by PageSize below)pagesize(query)Optional: defines the number of elements per page (default (and max) is 1000)disabletotal(query)Optional: disable total calculation to improve performance (default is false)CodeDescriptionLinks200OKMedia typeControls Accept header.{
  "data": [
    {
      "id": "string",
      "url": "string",
      "projectId": "string",
      "modelId": "string"
    }
  ],
  "pageOffset": 0,
  "pageLimit": 0,
  "pageCount": 0,
  "total": 0,
  "truncatedResults": true,
  "truncatedReason": "string",
  "filterOptions": [
    {
      "isValueConcatenated": true,
      "data": "string",
      "options": [
        "string"
      ]
    }
  ],
  "links": {
    "additionalProp1": "string",
    "additionalProp2": "string",
    "additionalProp3": "string"
  }
}No links400Bad RequestNo links401UnauthorizedNo links404Not FoundNo links500Internal Server ErrorNo links Tables NameDescriptioninclude(query)A comma delimited list of JSON properties to return. All remaining JSON properties will removed from the JSON response. Example: id, description, cutListItems. Specific dictionary keys can be included as follows: properties["Family"], propertiesGtp["Material"]where(query)Filter on JSON property values. Example: To filter on two JSON properties: length eq '10' AND description == "truck". To get the last 30 days of data, use: createdDT ge DateTime.Now.AddDays(-30)CodeDescriptionLinks200OKMedia typeControls Accept header.[
  {
    "companyTableId": "string",
    "createdById": "string",
    "createdByName": "string",
    "createdDT": "2026-01-29T03:23:21.296Z",
    "csvData": "string",
    "headers": [
      "string"
    ],
    "id": "string",
    "isCloneToProjectTableEnabled": true,
    "modifiedById": "string",
    "modifiedByName": "string",
    "modifiedDT": "2026-01-29T03:23:21.296Z",
    "name": "string",
    "notes": "string",
    "projectId": "string",
    "referencesCount": 0
  }
]No links400Bad RequestNo links401UnauthorizedNo links404Not FoundNo links500Internal Server ErrorNo linksNameDescriptionid *string(path)Table IDinclude(query)A comma delimited list of JSON properties to return. All remaining JSON properties will removed from the JSON response. Example: id, description, cutListItems. Specific dictionary keys can be included as follows: properties["Family"], propertiesGtp["Material"]CodeDescriptionLinks200OKMedia typeControls Accept header.{
  "companyTableId": "string",
  "createdById": "string",
  "createdByName": "string",
  "createdDT": "2026-01-29T03:23:21.333Z",
  "csvData": "string",
  "headers": [
    "string"
  ],
  "id": "string",
  "isCloneToProjectTableEnabled": true,
  "modifiedById": "string",
  "modifiedByName": "string",
  "modifiedDT": "2026-01-29T03:23:21.333Z",
  "name": "string",
  "notes": "string",
  "projectId": "string",
  "referencesCount": 0
}No links400Bad RequestNo links401UnauthorizedNo links404Not FoundNo links500Internal Server ErrorNo linksNameDescriptionid *string(path)Table IDCodeDescriptionLinks200OKMedia typeControls Accept header.No links400Bad RequestNo links401UnauthorizedNo links404Not FoundNo links500Internal Server ErrorNo linksNameDescriptionprojectId *string(path)Project IDinclude(query)A comma delimited list of JSON properties to return. All remaining JSON properties will removed from the JSON response. Example: id, description, cutListItems. Specific dictionary keys can be included as follows: properties["Family"], propertiesGtp["Material"]where(query)Filter on JSON property values. Example: To filter on two JSON properties: length eq '10' AND description == "truck". To get the last 30 days of data, use: createdDT ge DateTime.Now.AddDays(-30)CodeDescriptionLinks200OKMedia typeControls Accept header.[
  {
    "companyTableId": "string",
    "createdById": "string",
    "createdByName": "string",
    "createdDT": "2026-01-29T03:23:21.400Z",
    "csvData": "string",
    "headers": [
      "string"
    ],
    "id": "string",
    "isCloneToProjectTableEnabled": true,
    "modifiedById": "string",
    "modifiedByName": "string",
    "modifiedDT": "2026-01-29T03:23:21.400Z",
    "name": "string",
    "notes": "string",
    "projectId": "string",
    "referencesCount": 0
  }
]No links400Bad RequestNo links401UnauthorizedNo links404Not FoundNo links500Internal Server ErrorNo linksNameDescriptionprojectId *string(path)Project IDid *string(path)Table IDinclude(query)A comma delimited list of JSON properties to return. All remaining JSON properties will removed from the JSON response. Example: id, description, cutListItems. Specific dictionary keys can be included as follows: properties["Family"], propertiesGtp["Material"]CodeDescriptionLinks200OKMedia typeControls Accept header.{
  "companyTableId": "string",
  "createdById": "string",
  "createdByName": "string",
  "createdDT": "2026-01-29T03:23:21.446Z",
  "csvData": "string",
  "headers": [
    "string"
  ],
  "id": "string",
  "isCloneToProjectTableEnabled": true,
  "modifiedById": "string",
  "modifiedByName": "string",
  "modifiedDT": "2026-01-29T03:23:21.446Z",
  "name": "string",
  "notes": "string",
  "projectId": "string",
  "referencesCount": 0
}No links400Bad RequestNo links401UnauthorizedNo links404Not FoundNo links500Internal Server ErrorNo linksNameDescriptionprojectId *string(path)Project IDid *string(path)Table IDCodeDescriptionLinks200OKMedia typeControls Accept header.No links400Bad RequestNo links401UnauthorizedNo links404Not FoundNo links500Internal Server ErrorNo linksTable data{
  "isReadOnly": true,
  "id": "string",
  "createdDT": "2026-01-29T03:23:21.527Z",
  "createdById": "string",
  "modifiedDT": "2026-01-29T03:23:21.527Z",
  "modifiedById": "string",
  "companyTableId": "string",
  "csvData": "string",
  "headers": [
    "string"
  ],
  "isCloneToProjectTableEnabled": true,
  "name": "string",
  "notes": "string",
  "projectId": "string"
}CodeDescriptionLinks200OKMedia typeControls Accept header.{
  "companyTableId": "string",
  "createdById": "string",
  "createdByName": "string",
  "createdDT": "2026-01-29T03:23:21.535Z",
  "csvData": "string",
  "headers": [
    "string"
  ],
  "id": "string",
  "isCloneToProjectTableEnabled": true,
  "modifiedById": "string",
  "modifiedByName": "string",
  "modifiedDT": "2026-01-29T03:23:21.535Z",
  "name": "string",
  "notes": "string",
  "projectId": "string",
  "referencesCount": 0
}No links400Bad RequestNo links401UnauthorizedNo links404Not FoundNo links500Internal Server ErrorNo linksNameDescriptionid *string(path)Table IDColumn operation details{
  "columnMappings": {
    "additionalProp1": 0,
    "additionalProp2": 0,
    "additionalProp3": 0
  },
  "columnName": "string",
  "defaultValue": "string",
  "index": 0,
  "operation": "1 = Add"
}CodeDescriptionLinks200OKMedia typeControls Accept header.{
  "companyTableId": "string",
  "createdById": "string",
  "createdByName": "string",
  "createdDT": "2026-01-29T03:23:21.585Z",
  "csvData": "string",
  "headers": [
    "string"
  ],
  "id": "string",
  "isCloneToProjectTableEnabled": true,
  "modifiedById": "string",
  "modifiedByName": "string",
  "modifiedDT": "2026-01-29T03:23:21.585Z",
  "name": "string",
  "notes": "string",
  "projectId": "string",
  "referencesCount": 0
}No links400Bad RequestNo links401UnauthorizedNo links404Not FoundNo links500Internal Server ErrorNo linksNameDescriptionid *string(path)Table IDindexinteger($int32)(query)Index where to insert the columncolumnNamestring(query)Name of the new columndefaultValuestring(query)Default value for the new columnDefault value :CodeDescriptionLinks200OKMedia typeControls Accept header.{
  "companyTableId": "string",
  "createdById": "string",
  "createdByName": "string",
  "createdDT": "2026-01-29T03:23:21.639Z",
  "csvData": "string",
  "headers": [
    "string"
  ],
  "id": "string",
  "isCloneToProjectTableEnabled": true,
  "modifiedById": "string",
  "modifiedByName": "string",
  "modifiedDT": "2026-01-29T03:23:21.639Z",
  "name": "string",
  "notes": "string",
  "projectId": "string",
  "referencesCount": 0
}No links400Bad RequestNo links401UnauthorizedNo links404Not FoundNo links500Internal Server ErrorNo linksNameDescriptionprojectId *string(path)Project IDTable data{
  "isReadOnly": true,
  "id": "string",
  "createdDT": "2026-01-29T03:23:21.683Z",
  "createdById": "string",
  "modifiedDT": "2026-01-29T03:23:21.683Z",
  "modifiedById": "string",
  "companyTableId": "string",
  "csvData": "string",
  "headers": [
    "string"
  ],
  "isCloneToProjectTableEnabled": true,
  "name": "string",
  "notes": "string",
  "projectId": "string"
}CodeDescriptionLinks200OKMedia typeControls Accept header.{
  "companyTableId": "string",
  "createdById": "string",
  "createdByName": "string",
  "createdDT": "2026-01-29T03:23:21.691Z",
  "csvData": "string",
  "headers": [
    "string"
  ],
  "id": "string",
  "isCloneToProjectTableEnabled": true,
  "modifiedById": "string",
  "modifiedByName": "string",
  "modifiedDT": "2026-01-29T03:23:21.691Z",
  "name": "string",
  "notes": "string",
  "projectId": "string",
  "referencesCount": 0
}No links400Bad RequestNo links401UnauthorizedNo links404Not FoundNo links500Internal Server ErrorNo linksUpdated table data{
  "isReadOnly": true,
  "id": "string",
  "createdDT": "2026-01-29T03:23:21.727Z",
  "createdById": "string",
  "modifiedDT": "2026-01-29T03:23:21.727Z",
  "modifiedById": "string",
  "companyTableId": "string",
  "csvData": "string",
  "headers": [
    "string"
  ],
  "isCloneToProjectTableEnabled": true,
  "name": "string",
  "notes": "string",
  "projectId": "string"
}CodeDescriptionLinks200OKMedia typeControls Accept header.{
  "companyTableId": "string",
  "createdById": "string",
  "createdByName": "string",
  "createdDT": "2026-01-29T03:23:21.735Z",
  "csvData": "string",
  "headers": [
    "string"
  ],
  "id": "string",
  "isCloneToProjectTableEnabled": true,
  "modifiedById": "string",
  "modifiedByName": "string",
  "modifiedDT": "2026-01-29T03:23:21.735Z",
  "name": "string",
  "notes": "string",
  "projectId": "string",
  "referencesCount": 0
}No links400Bad RequestNo links401UnauthorizedNo links404Not FoundNo links500Internal Server ErrorNo linksNameDescriptionid *string(path)Table IDindex *integer($int32)(path)Index of the column to renamenewColumnNamestring(query)New name for the columnCodeDescriptionLinks200OKMedia typeControls Accept header.{
  "companyTableId": "string",
  "createdById": "string",
  "createdByName": "string",
  "createdDT": "2026-01-29T03:23:21.782Z",
  "csvData": "string",
  "headers": [
    "string"
  ],
  "id": "string",
  "isCloneToProjectTableEnabled": true,
  "modifiedById": "string",
  "modifiedByName": "string",
  "modifiedDT": "2026-01-29T03:23:21.782Z",
  "name": "string",
  "notes": "string",
  "projectId": "string",
  "referencesCount": 0
}No links400Bad RequestNo links401UnauthorizedNo links404Not FoundNo links500Internal Server ErrorNo linksNameDescriptionid *string(path)Table IDColumn mappings (new index -> old index){
  "additionalProp1": 0,
  "additionalProp2": 0,
  "additionalProp3": 0
}CodeDescriptionLinks200OKMedia typeControls Accept header.{
  "companyTableId": "string",
  "createdById": "string",
  "createdByName": "string",
  "createdDT": "2026-01-29T03:23:21.836Z",
  "csvData": "string",
  "headers": [
    "string"
  ],
  "id": "string",
  "isCloneToProjectTableEnabled": true,
  "modifiedById": "string",
  "modifiedByName": "string",
  "modifiedDT": "2026-01-29T03:23:21.836Z",
  "name": "string",
  "notes": "string",
  "projectId": "string",
  "referencesCount": 0
}No links400Bad RequestNo links401UnauthorizedNo links404Not FoundNo links500Internal Server ErrorNo linksNameDescriptionprojectId *string(path)Project IDUpdated table data{
  "isReadOnly": true,
  "id": "string",
  "createdDT": "2026-01-29T03:23:21.884Z",
  "createdById": "string",
  "modifiedDT": "2026-01-29T03:23:21.884Z",
  "modifiedById": "string",
  "companyTableId": "string",
  "csvData": "string",
  "headers": [
    "string"
  ],
  "isCloneToProjectTableEnabled": true,
  "name": "string",
  "notes": "string",
  "projectId": "string"
}CodeDescriptionLinks200OKMedia typeControls Accept header.{
  "companyTableId": "string",
  "createdById": "string",
  "createdByName": "string",
  "createdDT": "2026-01-29T03:23:21.892Z",
  "csvData": "string",
  "headers": [
    "string"
  ],
  "id": "string",
  "isCloneToProjectTableEnabled": true,
  "modifiedById": "string",
  "modifiedByName": "string",
  "modifiedDT": "2026-01-29T03:23:21.892Z",
  "name": "string",
  "notes": "string",
  "projectId": "string",
  "referencesCount": 0
}No links400Bad RequestNo links401UnauthorizedNo links404Not FoundNo links500Internal Server ErrorNo linksNameDescriptionid *string(path)Table IDCodeDescriptionLinks200OKMedia typeControls Accept header.trueNo links400Bad RequestNo links401UnauthorizedNo links404Not FoundNo links500Internal Server ErrorNo linksNameDescriptionid *string(path)Table IDindex *integer($int32)(path)Index of the column to removeCodeDescriptionLinks200OKMedia typeControls Accept header.{
  "companyTableId": "string",
  "createdById": "string",
  "createdByName": "string",
  "createdDT": "2026-01-29T03:23:21.958Z",
  "csvData": "string",
  "headers": [
    "string"
  ],
  "id": "string",
  "isCloneToProjectTableEnabled": true,
  "modifiedById": "string",
  "modifiedByName": "string",
  "modifiedDT": "2026-01-29T03:23:21.958Z",
  "name": "string",
  "notes": "string",
  "projectId": "string",
  "referencesCount": 0
}No links400Bad RequestNo links401UnauthorizedNo links404Not FoundNo links500Internal Server ErrorNo linksNameDescriptionprojectId *string(path)Project IDCodeDescriptionLinks200OKMedia typeControls Accept header.0No links400Bad RequestNo links401UnauthorizedNo links404Not FoundNo links500Internal Server ErrorNo linksNameDescriptionprojectId *string(path)Project IDid *string(path)Table IDCodeDescriptionLinks200OKMedia typeControls Accept header.trueNo links400Bad RequestNo links401UnauthorizedNo links404Not FoundNo links500Internal Server ErrorNo links Task NameDescriptioninclude(query)A comma delimited list of JSON properties to return. All remaining JSON properties will removed from the JSON response. Example: id, description, cutListItems. Specific dictionary keys can be included as follows: properties["Family"], propertiesGtp["Material"]where(query)Filter on JSON property values. Example: To filter on two JSON properties: length eq '10' AND description == "truck". To get the last 30 days of data, use: createdDT ge DateTime.Now.AddDays(-30)page(query)Offset retrieves a given page of data, where 0 is the 1st page, etc (number of elements per page is set by PageSize below)pagesize(query)Optional: defines the number of elements per page (default (and max) is 1000)disabletotal(query)Optional: disable total calculation to improve performance (default is false)CodeDescriptionLinks200OKMedia typeControls Accept header.{
  "data": [
    {
      "id": "string",
      "createdDT": "2026-01-29T03:23:22.088Z",
      "createdById": "string",
      "modifiedDT": "2026-01-29T03:23:22.088Z",
      "modifiedById": "string",
      "projectId": "string",
      "modelId": "string",
      "packageId": "string",
      "taskWorkflowId": "string",
      "taskDefinitionId": "string",
      "description": "string",
      "referenceType": "0 = Unspecified",
      "referenceTypeName": "string",
      "referenceId": "string",
      "referenceCadId": "string",
      "taskStatus": "string",
      "assignedUserId": "string",
      "assignedStationId": "string",
      "logEntries": [
        {
          "createdById": "string",
          "createdDT": "2026-01-29T03:23:22.088Z",
          "taskStatus": "string",
          "stationId": "string"
        }
      ]
    }
  ],
  "pageOffset": 0,
  "pageLimit": 0,
  "pageCount": 0,
  "total": 0,
  "truncatedResults": true,
  "truncatedReason": "string",
  "filterOptions": [
    {
      "isValueConcatenated": true,
      "data": "string",
      "options": [
        "string"
      ]
    }
  ],
  "links": {
    "additionalProp1": "string",
    "additionalProp2": "string",
    "additionalProp3": "string"
  }
}No links400Bad RequestNo links401UnauthorizedNo links404Not FoundNo links500Internal Server ErrorNo linksNameDescriptionid *string(path)STRATUS Task IdCodeDescriptionLinks200OKMedia typeControls Accept header.{
  "id": "string",
  "createdDT": "2026-01-29T03:23:22.126Z",
  "createdById": "string",
  "modifiedDT": "2026-01-29T03:23:22.126Z",
  "modifiedById": "string",
  "projectId": "string",
  "modelId": "string",
  "packageId": "string",
  "taskWorkflowId": "string",
  "taskDefinitionId": "string",
  "description": "string",
  "referenceType": "0 = Unspecified",
  "referenceTypeName": "string",
  "referenceId": "string",
  "referenceCadId": "string",
  "taskStatus": "string",
  "assignedUserId": "string",
  "assignedStationId": "string",
  "logEntries": [
    {
      "createdById": "string",
      "createdDT": "2026-01-29T03:23:22.126Z",
      "taskStatus": "string",
      "stationId": "string"
    }
  ]
}No links400Bad RequestNo links401UnauthorizedNo links404Not FoundNo links500Internal Server ErrorNo linksNameDescriptionid *string(path)STRATUS Task IdstationIdstring(query)Optional Station Id to associate with Status updatetaskStatusIdstring(query)Required Task Status Id to assign to TaskCodeDescriptionLinks200OKMedia typeControls Accept header.trueNo links400Bad RequestNo links401UnauthorizedNo links404Not FoundNo links500Internal Server ErrorNo linksNameDescriptiontoolIdstring(query)STRATUS Tool IdmodelIdstring(query)STRATUS Model IdpartCadIdstring(query)STRATUS Part CadIdtaskDefinitionIdstring(query)STRATUS Task Definition IdCodeDescriptionLinks200OKMedia typeControls Accept header.trueNo links400Bad RequestNo links401UnauthorizedNo links404Not FoundNo links500Internal Server ErrorNo linksNameDescriptiontoolIdstring(query)STRATUS Tool IdmodelIdstring(query)STRATUS Model IdpartCadIdstring(query)STRATUS Part CadIdtaskDefinitionIdstring(query)STRATUS Task Definition IdCodeDescriptionLinks200OKMedia typeControls Accept header.trueNo links400Bad RequestNo links401UnauthorizedNo links404Not FoundNo links500Internal Server ErrorNo links TimeSession NameDescriptionwhere(query)Filter on JSON property values. Example: To filter on two JSON properties: length eq '10' AND description == "truck". To get the last 30 days of data, use: createdDT ge DateTime.Now.AddDays(-30)page(query)Offset retrieves a given page of data, where 0 is the 1st page, etc (number of elements per page is set by PageSize below)pagesize(query)Optional: defines the number of elements per page (default (and max) is 1000)disabletotal(query)Optional: disable total calculation to improve performance (default is false)CodeDescriptionLinks200OKMedia typeControls Accept header.{
  "data": [
    {
      "isPartialData": true,
      "isReadOnly": true,
      "id": "string",
      "createdDT": "2026-01-29T03:23:22.312Z",
      "createdById": "string",
      "modifiedDT": "2026-01-29T03:23:22.312Z",
      "modifiedById": "string",
      "activityType": "0 = None",
      "activityTypeName": "string",
      "divisionId": "string",
      "divisionName": "string",
      "email": "string",
      "employeeId": "string",
      "firstName": "string",
      "isLocked": true,
      "lastName": "string",
      "modelId": "string",
      "modelName": "string",
      "packageCategoryId": "string",
      "packageCategoryName": "string",
      "packageDivisionId": "string",
      "packageDivisionName": "string",
      "packageId": "string",
      "packageName": "string",
      "packageNumber": "string",
      "projectId": "string",
      "projectName": "string",
      "projectNumber": "string",
      "shiftTypeId": "string",
      "startDT": "2026-01-29T03:23:22.312Z",
      "stationDivisionId": "string",
      "stationDivisionName": "string",
      "stationId": "string",
      "stationName": "string",
      "stopDT": "2026-01-29T03:23:22.312Z",
      "taskDefinitionId": "string",
      "userTypeName": "string",
      "workerId": "string"
    }
  ],
  "pageOffset": 0,
  "pageLimit": 0,
  "pageCount": 0,
  "total": 0,
  "truncatedResults": true,
  "truncatedReason": "string",
  "filterOptions": [
    {
      "isValueConcatenated": true,
      "data": "string",
      "options": [
        "string"
      ]
    }
  ],
  "links": {
    "additionalProp1": "string",
    "additionalProp2": "string",
    "additionalProp3": "string"
  }
}No links400Bad RequestNo links401UnauthorizedNo links404Not FoundNo links500Internal Server ErrorNo links{
  "isLocked": true,
  "timeSessionIds": [
    "string"
  ]
}CodeDescriptionLinks200OKNo links400Bad RequestNo links401UnauthorizedNo links404Not FoundNo links500Internal Server ErrorNo links TrackingLog NameDescriptioninclude(query)A comma delimited list of JSON properties to return. All remaining JSON properties will removed from the JSON response. Example: id, description, cutListItems. Specific dictionary keys can be included as follows: properties["Family"], propertiesGtp["Material"]where(query)Filter on JSON property values. Example: To filter on two JSON properties: length eq '10' AND description == "truck". To get the last 30 days of data, use: createdDT ge DateTime.Now.AddDays(-30)page(query)Offset retrieves a given page of data, where 0 is the 1st page, etc (number of elements per page is set by PageSize below)pagesize(query)Optional: defines the number of elements per page (default (and max) is 1000)disabletotal(query)Optional: disable total calculation to improve performance (default is false)CodeDescriptionLinks200OKMedia typeControls Accept header.{
  "data": [
    {
      "id": "string",
      "createdDT": "2026-01-29T03:23:22.694Z",
      "currentDivisionId": "string",
      "modifiedDT": "2026-01-29T03:23:22.694Z",
      "modelId": "string",
      "referenceType": "0 = Unspecified",
      "referenceName": "string",
      "referenceId": "string",
      "currentTrackingStatusId": "string",
      "totalHours": 0,
      "trackingLogEntries": [
        {
          "trackingStatusId": "string",
          "createdById": "string",
          "createdDT": "2026-01-29T03:23:22.694Z",
          "divisionId": "string",
          "id": "string",
          "origin": "0 = Unknown",
          "comment": "string",
          "hours": 0,
          "costTypeId": "string",
          "hoursCost": 0
        }
      ]
    }
  ],
  "pageOffset": 0,
  "pageLimit": 0,
  "pageCount": 0,
  "total": 0,
  "truncatedResults": true,
  "truncatedReason": "string",
  "filterOptions": [
    {
      "isValueConcatenated": true,
      "data": "string",
      "options": [
        "string"
      ]
    }
  ],
  "links": {
    "additionalProp1": "string",
    "additionalProp2": "string",
    "additionalProp3": "string"
  }
}No links400Bad RequestNo links401UnauthorizedNo links404Not FoundNo links500Internal Server ErrorNo linksCodeDescriptionLinks200OKMedia typeControls Accept header.{
  "additionalProp1": "string",
  "additionalProp2": "string",
  "additionalProp3": "string"
}No links400Bad RequestNo links401UnauthorizedNo links404Not FoundNo links500Internal Server ErrorNo linksCodeDescriptionLinks200OKMedia typeControls Accept header.{
  "additionalProp1": "string",
  "additionalProp2": "string",
  "additionalProp3": "string"
}No links400Bad RequestNo links401UnauthorizedNo links404Not FoundNo links500Internal Server ErrorNo links User NameDescriptionid *string(path)STRATUS User Idinclude(query)A comma delimited list of JSON properties to return. All remaining JSON properties will removed from the JSON response. Example: id, description, cutListItems. Specific dictionary keys can be included as follows: properties["Family"], propertiesGtp["Material"]CodeDescriptionLinks200OKMedia typeControls Accept header.{
  "cellPhone": "string",
  "companyId": "string",
  "companyName": "string",
  "dateFormat": "string",
  "email": "string",
  "firstName": "string",
  "hourFormat": "string",
  "id": "string",
  "isCheckedIn": true,
  "isTimeTrackingEnabled": true,
  "lastName": "string",
  "lastViewedDateTimeForAssemblyId": {
    "additionalProp1": "2026-01-29T03:23:22.787Z",
    "additionalProp2": "2026-01-29T03:23:22.787Z",
    "additionalProp3": "2026-01-29T03:23:22.787Z"
  },
  "lastViewedDateTimeForModelId": {
    "additionalProp1": "2026-01-29T03:23:22.787Z",
    "additionalProp2": "2026-01-29T03:23:22.787Z",
    "additionalProp3": "2026-01-29T03:23:22.787Z"
  },
  "lastViewedDateTimeForPackageId": {
    "additionalProp1": "2026-01-29T03:23:22.787Z",
    "additionalProp2": "2026-01-29T03:23:22.787Z",
    "additionalProp3": "2026-01-29T03:23:22.787Z"
  },
  "longDateFormat": "string",
  "profileImageUrl": "string",
  "profileImageBase64": "string",
  "status": "1 = Active",
  "timeFormat": "string",
  "timeZoneInfoId": "string"
}No links400Bad RequestNo links401UnauthorizedNo links404Not FoundNo links500Internal Server ErrorNo linksNameDescriptionid *string(path)STRATUS User IdCodeDescriptionLinks200OKMedia typeControls Accept header.{
  "userId": "string",
  "firstName": "string",
  "lastName": "string",
  "shortUrl": "string"
}No links400Bad RequestNo links401UnauthorizedNo links404Not FoundNo links500Internal Server ErrorNo linksNameDescriptionid *string(path)STRATUS User IdCodeDescriptionLinks200OKMedia typeControls Accept header.[
  {
    "projectId": "string",
    "projectRoleTypeId": "string"
  }
]No links400Bad RequestNo links401UnauthorizedNo links404Not FoundNo links500Internal Server ErrorNo linksNameDescriptioninclude(query)A comma delimited list of JSON properties to return. All remaining JSON properties will removed from the JSON response. Example: id, description, cutListItems. Specific dictionary keys can be included as follows: properties["Family"], propertiesGtp["Material"]where(query)Filter on JSON property values. Example: To filter on two JSON properties: length eq '10' AND description == "truck". To get the last 30 days of data, use: createdDT ge DateTime.Now.AddDays(-30)page(query)Offset retrieves a given page of data, where 0 is the 1st page, etc (number of elements per page is set by PageSize below)pagesize(query)Optional: defines the number of elements per page (default (and max) is 1000)disabletotal(query)Optional: disable total calculation to improve performance (default is false)CodeDescriptionLinks200OKMedia typeControls Accept header.{
  "data": [
    {
      "cellPhone": "string",
      "companyId": "string",
      "companyName": "string",
      "dateFormat": "string",
      "email": "string",
      "firstName": "string",
      "hourFormat": "string",
      "id": "string",
      "isCheckedIn": true,
      "isTimeTrackingEnabled": true,
      "lastName": "string",
      "lastViewedDateTimeForAssemblyId": {
        "additionalProp1": "2026-01-29T03:23:22.913Z",
        "additionalProp2": "2026-01-29T03:23:22.913Z",
        "additionalProp3": "2026-01-29T03:23:22.913Z"
      },
      "lastViewedDateTimeForModelId": {
        "additionalProp1": "2026-01-29T03:23:22.913Z",
        "additionalProp2": "2026-01-29T03:23:22.913Z",
        "additionalProp3": "2026-01-29T03:23:22.913Z"
      },
      "lastViewedDateTimeForPackageId": {
        "additionalProp1": "2026-01-29T03:23:22.913Z",
        "additionalProp2": "2026-01-29T03:23:22.913Z",
        "additionalProp3": "2026-01-29T03:23:22.913Z"
      },
      "longDateFormat": "string",
      "profileImageUrl": "string",
      "profileImageBase64": "string",
      "status": "1 = Active",
      "timeFormat": "string",
      "timeZoneInfoId": "string"
    }
  ],
  "pageOffset": 0,
  "pageLimit": 0,
  "pageCount": 0,
  "total": 0,
  "truncatedResults": true,
  "truncatedReason": "string",
  "filterOptions": [
    {
      "isValueConcatenated": true,
      "data": "string",
      "options": [
        "string"
      ]
    }
  ],
  "links": {
    "additionalProp1": "string",
    "additionalProp2": "string",
    "additionalProp3": "string"
  }
}No links400Bad RequestNo links401UnauthorizedNo links404Not FoundNo links500Internal Server ErrorNo linksNameDescriptionemail *string(path)include(query)A comma delimited list of JSON properties to return. All remaining JSON properties will removed from the JSON response. Example: id, description, cutListItems. Specific dictionary keys can be included as follows: properties["Family"], propertiesGtp["Material"]CodeDescriptionLinks200OKMedia typeControls Accept header.{
  "cellPhone": "string",
  "companyId": "string",
  "companyName": "string",
  "dateFormat": "string",
  "email": "string",
  "firstName": "string",
  "hourFormat": "string",
  "id": "string",
  "isCheckedIn": true,
  "isTimeTrackingEnabled": true,
  "lastName": "string",
  "lastViewedDateTimeForAssemblyId": {
    "additionalProp1": "2026-01-29T03:23:22.949Z",
    "additionalProp2": "2026-01-29T03:23:22.949Z",
    "additionalProp3": "2026-01-29T03:23:22.949Z"
  },
  "lastViewedDateTimeForModelId": {
    "additionalProp1": "2026-01-29T03:23:22.949Z",
    "additionalProp2": "2026-01-29T03:23:22.949Z",
    "additionalProp3": "2026-01-29T03:23:22.949Z"
  },
  "lastViewedDateTimeForPackageId": {
    "additionalProp1": "2026-01-29T03:23:22.949Z",
    "additionalProp2": "2026-01-29T03:23:22.949Z",
    "additionalProp3": "2026-01-29T03:23:22.949Z"
  },
  "longDateFormat": "string",
  "profileImageUrl": "string",
  "profileImageBase64": "string",
  "status": "1 = Active",
  "timeFormat": "string",
  "timeZoneInfoId": "string"
}No links400Bad RequestNo links401UnauthorizedNo links404Not FoundNo links500Internal Server ErrorNo linksNameDescriptionid *string(path)STRATUS User Id{
  "projectId": "string",
  "projectRoleTypeId": "string"
}CodeDescriptionLinks200OKMedia typeControls Accept header.{
  "projectId": "string",
  "projectRoleTypeId": "string"
}No links400Bad RequestNo links401UnauthorizedNo links404Not FoundNo links500Internal Server ErrorNo linksNameDescriptionid *string(path)STRATUS User Id{
  "projectId": "string",
  "projectRoleTypeId": "string"
}CodeDescriptionLinks200OKMedia typeControls Accept header.{
  "projectId": "string",
  "projectRoleTypeId": "string"
}No links400Bad RequestNo links401UnauthorizedNo links404Not FoundNo links500Internal Server ErrorNo linksNameDescriptionid *string(path){
  "cellPhone": "string",
  "companyId": "string",
  "companyName": "string",
  "dateFormat": "string",
  "email": "string",
  "firstName": "string",
  "hourFormat": "string",
  "id": "string",
  "isCheckedIn": true,
  "isTimeTrackingEnabled": true,
  "lastName": "string",
  "lastViewedDateTimeForAssemblyId": {
    "additionalProp1": "2026-01-29T03:23:23.085Z",
    "additionalProp2": "2026-01-29T03:23:23.085Z",
    "additionalProp3": "2026-01-29T03:23:23.085Z"
  },
  "lastViewedDateTimeForModelId": {
    "additionalProp1": "2026-01-29T03:23:23.085Z",
    "additionalProp2": "2026-01-29T03:23:23.085Z",
    "additionalProp3": "2026-01-29T03:23:23.085Z"
  },
  "lastViewedDateTimeForPackageId": {
    "additionalProp1": "2026-01-29T03:23:23.085Z",
    "additionalProp2": "2026-01-29T03:23:23.085Z",
    "additionalProp3": "2026-01-29T03:23:23.085Z"
  },
  "longDateFormat": "string",
  "profileImageUrl": "string",
  "profileImageBase64": "string",
  "status": "1 = Active",
  "timeFormat": "string",
  "timeZoneInfoId": "string"
}CodeDescriptionLinks202AcceptedMedia typeControls Accept header.{
  "cellPhone": "string",
  "companyId": "string",
  "companyName": "string",
  "dateFormat": "string",
  "email": "string",
  "firstName": "string",
  "hourFormat": "string",
  "id": "string",
  "isCheckedIn": true,
  "isTimeTrackingEnabled": true,
  "lastName": "string",
  "lastViewedDateTimeForAssemblyId": {
    "additionalProp1": "2026-01-29T03:23:23.092Z",
    "additionalProp2": "2026-01-29T03:23:23.092Z",
    "additionalProp3": "2026-01-29T03:23:23.092Z"
  },
  "lastViewedDateTimeForModelId": {
    "additionalProp1": "2026-01-29T03:23:23.092Z",
    "additionalProp2": "2026-01-29T03:23:23.092Z",
    "additionalProp3": "2026-01-29T03:23:23.092Z"
  },
  "lastViewedDateTimeForPackageId": {
    "additionalProp1": "2026-01-29T03:23:23.092Z",
    "additionalProp2": "2026-01-29T03:23:23.092Z",
    "additionalProp3": "2026-01-29T03:23:23.092Z"
  },
  "longDateFormat": "string",
  "profileImageUrl": "string",
  "profileImageBase64": "string",
  "status": "1 = Active",
  "timeFormat": "string",
  "timeZoneInfoId": "string"
}No links400Bad RequestNo links401UnauthorizedNo links404Not FoundNo links500Internal Server ErrorNo linksNameDescriptionid *string(path)STRATUS User IdprojectId *string(path)STRATUS Project IdCodeDescriptionLinks200OKMedia typeControls Accept header.trueNo links400Bad RequestNo links401UnauthorizedNo links404Not FoundNo links500Internal Server ErrorNo links Version CodeDescriptionLinks200OKMedia typeControls Accept header."string"No links400Bad RequestNo links401UnauthorizedNo links404Not FoundNo links500Internal Server ErrorNo links API Health CodeDescriptionLinks200Health descriptionMedia typeControls Accept header.{
  "status": "string",
  "totalDuration": "string",
  "entries": 
}No links

---
### Activity

| Name | Description |
| --- | --- |
| 
include

(query)

 | 

A comma delimited list of JSON properties to return. All remaining JSON properties will removed from the JSON response. Example: id, description, cutListItems. Specific dictionary keys can be included as follows: properties\["Family"\], propertiesGtp\["Material"\]

 |
| 

where

(query)

 | 

Filter on JSON property values. Example: To filter on two JSON properties: length eq '10' AND description == "truck". To get the last 30 days of data, use: createdDT ge DateTime.Now.AddDays(-30)

 |
| 

page

(query)

 | 

Offset retrieves a given page of data, where 0 is the 1st page, etc (number of elements per page is set by PageSize below)

 |
| 

pagesize

(query)

 | 

Optional: defines the number of elements per page (default (and max) is 1000)

 |
| 

disabletotal

(query)

 | 

Optional: disable total calculation to improve performance (default is false)

 |

| Code | Description | Links |
| --- | --- | --- |
| 200 | 
OK

Media type

Controls `Accept` header.

```
{
  "data": [
    {
      "id": "string",
      "createdDT": "2026-01-29T03:23:16.130Z",
      "createdById": "string",
      "createdByName": "string",
      "divisionId": "string",
      "divisionName": "string",
      "route": "string",
      "projectId": "string",
      "projectName": "string",
      "projectNumber": "string",
      "projectColor": "string",
      "modelId": "string",
      "modelName": "string",
      "reference": "0 = Unspecified",
      "referenceId": "string",
      "referenceName": "string",
      "action": "0 = Unspecified",
      "actionName": "string",
      "name": "string",
      "value": "string",
      "trackingStatusId": "string",
      "trackingStatusName": "string",
      "trackingStatusColor": "string",
      "stationId": "string",
      "stationName": "string"
    }
  ],
  "pageOffset": 0,
  "pageLimit": 0,
  "pageCount": 0,
  "total": 0,
  "truncatedResults": true,
  "truncatedReason": "string",
  "filterOptions": [
    {
      "isValueConcatenated": true,
      "data": "string",
      "options": [
        "string"
      ]
    }
  ],
  "links": {
    "additionalProp1": "string",
    "additionalProp2": "string",
    "additionalProp3": "string"
  }
}
```





 | _No links_ |
| 400 | 

Bad Request



 | _No links_ |
| 401 | 

Unauthorized



 | _No links_ |
| 404 | 

Not Found



 | _No links_ |
| 500 | 

Internal Server Error



 | _No links_ |

### Assembly

| Name | Description |
| --- | --- |
| 
id \*

string

(path)

 | 

STRATUS Assembly Id

 |
| 

include

(query)

 | 

A comma delimited list of JSON properties to return. All remaining JSON properties will removed from the JSON response. Example: id, description, cutListItems. Specific dictionary keys can be included as follows: properties\["Family"\], propertiesGtp\["Material"\]

 |

| Code | Description | Links |
| --- | --- | --- |
| 200 | 
OK

Media type

Controls `Accept` header.

```
[
  {
    "id": "string",
    "projectId": "string",
    "modelId": "string",
    "stratusDimensionType": "0 = AliasTag",
    "orderId": "string",
    "assemblyId": "string",
    "partCadIds": [
      "string"
    ],
    "colorIndex": 0,
    "dimensionLineType": "0 = LabelOnly",
    "connectedAssemblyId": "string",
    "distance": 0,
    "label": "string",
    "lineVertices": [
      {
        "x": 0,
        "y": 0,
        "z": 0
      }
    ],
    "location": {
      "x": 0,
      "y": 0,
      "z": 0
    },
    "gridlineAnnotation": "string",
    "dimensionAnchorTypes": [
      {
        "location": {
          "x": 0,
          "y": 0,
          "z": 0
        },
        "partPointType": "0 = Unspecified"
      }
    ]
  }
]
```





 | _No links_ |
| 400 | 

Bad Request



 | _No links_ |
| 401 | 

Unauthorized



 | _No links_ |
| 404 | 

Not Found



 | _No links_ |
| 500 | 

Internal Server Error



 | _No links_ |

| Name | Description |
| --- | --- |
| 
id \*

string

(path)

 | 

STRATUS Assembly Id

 |
| 

include

(query)

 | 

A comma delimited list of JSON properties to return. All remaining JSON properties will removed from the JSON response. Example: id, description, cutListItems. Specific dictionary keys can be included as follows: properties\["Family"\], propertiesGtp\["Material"\]

 |
| 

where

(query)

 | 

Filter on JSON property values. Example: To filter on two JSON properties: length eq '10' AND description == "truck". To get the last 30 days of data, use: createdDT ge DateTime.Now.AddDays(-30)

 |
| 

page

(query)

 | 

Offset retrieves a given page of data, where 0 is the 1st page, etc (number of elements per page is set by PageSize below)

 |
| 

pagesize

(query)

 | 

Optional: defines the number of elements per page (default (and max) is 1000)

 |
| 

disabletotal

(query)

 | 

Optional: disable total calculation to improve performance (default is false)

 |

| Code | Description | Links |
| --- | --- | --- |
| 200 | 
OK

Media type

Controls `Accept` header.

```
{
  "data": [
    {
      "id": "string",
      "createdById": "string",
      "createdDT": "2026-01-29T03:23:16.234Z",
      "projectId": "string",
      "modelId": "string",
      "referenceType": "0 = Unspecified",
      "referenceName": "string",
      "referenceId": "string",
      "role": "0 = Unspecified",
      "roleName": "string",
      "fileType": "0 = Unspecified",
      "fileTypeName": "string",
      "localFilePath": "string",
      "fileName": "string",
      "overriddenRemoteFolder": "string"
    }
  ],
  "pageOffset": 0,
  "pageLimit": 0,
  "pageCount": 0,
  "total": 0,
  "truncatedResults": true,
  "truncatedReason": "string",
  "filterOptions": [
    {
      "isValueConcatenated": true,
      "data": "string",
      "options": [
        "string"
      ]
    }
  ],
  "links": {
    "additionalProp1": "string",
    "additionalProp2": "string",
    "additionalProp3": "string"
  }
}
```





 | _No links_ |
| 400 | 

Bad Request



 | _No links_ |
| 401 | 

Unauthorized



 | _No links_ |
| 404 | 

Not Found



 | _No links_ |
| 500 | 

Internal Server Error



 | _No links_ |

| Name | Description |
| --- | --- |
| 
id \*

string

(path)

 | 

STRATUS Assembly Id

 |
| 

includeStratusProperties

boolean

(query)

 | 

Pass true to this optional query parameter if you want to generate STRATUS.Part.\* properties and have them returned for the parts.

_Default value_ : false

 |
| 

excludeNullAndEmpty

boolean

(query)

 | 

Pass true to this optional query parameter if you want empty or null values removed from the part's Properties and PropertiesGtp collections to improve performance.

_Default value_ : false

 |
| 

include

(query)

 | 

A comma delimited list of JSON properties to return. All remaining JSON properties will removed from the JSON response. Example: id, description, cutListItems. Specific dictionary keys can be included as follows: properties\["Family"\], propertiesGtp\["Material"\]

 |
| 

where

(query)

 | 

Filter on JSON property values. Example: To filter on two JSON properties: length eq '10' AND description == "truck". To get the last 30 days of data, use: createdDT ge DateTime.Now.AddDays(-30)

 |
| 

page

(query)

 | 

Offset retrieves a given page of data, where 0 is the 1st page, etc (number of elements per page is set by PageSize below)

 |
| 

pagesize

(query)

 | 

Optional: defines the number of elements per page (default (and max) is 100)

 |
| 

disabletotal

(query)

 | 

Optional: disable total calculation to improve performance (default is false)

 |

| Code | Description | Links |
| --- | --- | --- |
| 200 | 
OK

Media type

Controls `Accept` header.

```
{
  "data": [
    {
      "id": "string",
      "createdDT": "2026-01-29T03:23:16.313Z",
      "modifiedDT": "2026-01-29T03:23:16.313Z",
      "cutDT": "2026-01-29T03:23:16.313Z",
      "projectId": "string",
      "projectName": "string",
      "projectNumber": "string",
      "modelId": "string",
      "modelName": "string",
      "bimAreaId": "string",
      "bimArea": "string",
      "cadId": "string",
      "cadType": "string",
      "webId": "string",
      "description": "string",
      "currentTrackingStatusId": "string",
      "currentDivisionId": "string",
      "properties": {
        "additionalProp1": "string",
        "additionalProp2": "string",
        "additionalProp3": "string"
      },
      "propertiesGtp": {
        "additionalProp1": "string",
        "additionalProp2": "string",
        "additionalProp3": "string"
      },
      "points": [
        {
          "pointType": "0 = Unspecified",
          "cadId": "string",
          "location": {
            "x": 0,
            "y": 0,
            "z": 0
          },
          "direction": {
            "x": 0,
            "y": 0,
            "z": 0
          },
          "upVector": {
            "x": 0,
            "y": 0,
            "z": 0
          },
          "width": 0,
          "height": 0,
          "matingElementUniqueId": "string"
        }
      ],
      "cutLengthAdjustment": 0,
      "cutLength2Adjustment": 0,
      "lockLength": true,
      "lockLocation": true,
      "qrCodeUrl": "string",
      "partUrl": "string",
      "patternNumber": "string",
      "source": "0 = PublishedModel",
      "fieldIdToValueMap": {
        "additionalProp1": "string",
        "additionalProp2": "string",
        "additionalProp3": "string"
      },
      "fieldNameToValueMap": {
        "additionalProp1": "string",
        "additionalProp2": "string",
        "additionalProp3": "string"
      }
    }
  ],
  "pageOffset": 0,
  "pageLimit": 0,
  "pageCount": 0,
  "total": 0,
  "truncatedResults": true,
  "truncatedReason": "string",
  "filterOptions": [
    {
      "isValueConcatenated": true,
      "data": "string",
      "options": [
        "string"
      ]
    }
  ],
  "links": {
    "additionalProp1": "string",
    "additionalProp2": "string",
    "additionalProp3": "string"
  }
}
```





 | _No links_ |
| 400 | 

Bad Request



 | _No links_ |
| 401 | 

Unauthorized



 | _No links_ |
| 404 | 

Not Found



 | _No links_ |
| 500 | 

Internal Server Error



 | _No links_ |

| Name | Description |
| --- | --- |
| 
qrcode \*

string

(path)

 | 

The decoded text from a STRATUS QR Code -- being a URL or just the last eight characters of the URL.

 |
| 

include

(query)

 | 

A comma delimited list of JSON properties to return. All remaining JSON properties will removed from the JSON response. Example: id, description, cutListItems. Specific dictionary keys can be included as follows: properties\["Family"\], propertiesGtp\["Material"\]

 |

| Code | Description | Links |
| --- | --- | --- |
| 200 | 
OK

Media type

Controls `Accept` header.

```
{
  "id": "string",
  "createdDT": "2026-01-29T03:23:16.352Z",
  "modifiedDT": "2026-01-29T03:23:16.352Z",
  "projectId": "string",
  "modelId": "string",
  "cadId": "string",
  "sheetId": "string",
  "viewId": "string",
  "isViewIdOverridden": true,
  "currentTrackingStatusId": "string",
  "currentDivisionId": "string",
  "assemblyType": "0 = Unspecified",
  "assemblyTypeLabel": "string",
  "excludedCadIds": [
    "string"
  ],
  "fieldIdToValueMap": {
    "additionalProp1": "string",
    "additionalProp2": "string",
    "additionalProp3": "string"
  },
  "fieldNameToValueMap": {
    "additionalProp1": "string",
    "additionalProp2": "string",
    "additionalProp3": "string"
  },
  "name": "string",
  "nameLabel": "string",
  "partIds": [
    "string"
  ],
  "instanceIndex": "string",
  "lastUsedAssembliesPartsTableReportIds": [
    "string"
  ],
  "qrCodeUrl": "string",
  "notes": [
    {
      "isPartialData": true,
      "isReadOnly": true,
      "id": "string",
      "createdDT": "2026-01-29T03:23:16.352Z",
      "createdById": "string",
      "modifiedDT": "2026-01-29T03:23:16.352Z",
      "modifiedById": "string",
      "name": "string"
    }
  ],
  "defaultOrientationForReportTemplatesForgeViewerViewJson": {
    "additionalProp1": "string",
    "additionalProp2": "string",
    "additionalProp3": "string"
  }
}
```





 | _No links_ |
| 400 | 

Bad Request



 | _No links_ |
| 401 | 

Unauthorized



 | _No links_ |
| 404 | 

Not Found



 | _No links_ |
| 500 | 

Internal Server Error



 | _No links_ |

| Name | Description |
| --- | --- |
| 
id \*

string

(path)

 | 

STRATUS Assembly Id

 |
| 

trackingLogEntryId

string

(query)

 | 

Optional TrackingLogEntry Id to associate Attachment with a TrackingLogEntry

 |

| Code | Description | Links |
| --- | --- | --- |
| 200 | 
OK

Media type

Controls `Accept` header.

```
{
  "id": "string",
  "createdById": "string",
  "createdDT": "2026-01-29T03:23:16.394Z",
  "projectId": "string",
  "modelId": "string",
  "referenceType": "0 = Unspecified",
  "referenceName": "string",
  "referenceId": "string",
  "role": "0 = Unspecified",
  "roleName": "string",
  "fileType": "0 = Unspecified",
  "fileTypeName": "string",
  "localFilePath": "string",
  "fileName": "string",
  "overriddenRemoteFolder": "string"
}
```





 | _No links_ |
| 400 | 

Bad Request



 | _No links_ |
| 401 | 

Unauthorized



 | _No links_ |
| 404 | 

Not Found



 | _No links_ |
| 500 | 

Internal Server Error



 | _No links_ |

| Name | Description |
| --- | --- |
| 
id \*

string

(path)

 | 

STRATUS Assembly Id

 |

REQUIRED: TrackingStatusId

```
{
  "comment": "string",
  "costTypeId": "string",
  "createdDT": "2026-01-29T03:23:16.444Z",
  "divisionId": "string",
  "hours": 0,
  "trackingLogEntryIdResult": "string",
  "trackingStatusId": "string"
}
```

| Code | Description | Links |
| --- | --- | --- |
| 200 | 
OK

Media type

Controls `Accept` header.

```
{
  "comment": "string",
  "costTypeId": "string",
  "createdDT": "2026-01-29T03:23:16.452Z",
  "divisionId": "string",
  "hours": 0,
  "trackingLogEntryIdResult": "string",
  "trackingStatusId": "string"
}
```





 | _No links_ |
| 400 | 

Bad Request



 | _No links_ |
| 401 | 

Unauthorized



 | _No links_ |
| 404 | 

Not Found



 | _No links_ |
| 500 | 

Internal Server Error



 | _No links_ |

| Name | Description |
| --- | --- |
| 
id \*

string

(path)

 | 

STRATUS Assembly Id

 |

Array of Part CadIds used to replace existing.

| Code | Description | Links |
| --- | --- | --- |
| 200 | 
OK

Media type

Controls `Accept` header.

```
{
  "id": "string",
  "createdDT": "2026-01-29T03:23:16.506Z",
  "modifiedDT": "2026-01-29T03:23:16.506Z",
  "projectId": "string",
  "modelId": "string",
  "cadId": "string",
  "sheetId": "string",
  "viewId": "string",
  "isViewIdOverridden": true,
  "currentTrackingStatusId": "string",
  "currentDivisionId": "string",
  "assemblyType": "0 = Unspecified",
  "assemblyTypeLabel": "string",
  "excludedCadIds": [
    "string"
  ],
  "fieldIdToValueMap": {
    "additionalProp1": "string",
    "additionalProp2": "string",
    "additionalProp3": "string"
  },
  "fieldNameToValueMap": {
    "additionalProp1": "string",
    "additionalProp2": "string",
    "additionalProp3": "string"
  },
  "name": "string",
  "nameLabel": "string",
  "partIds": [
    "string"
  ],
  "instanceIndex": "string",
  "lastUsedAssembliesPartsTableReportIds": [
    "string"
  ],
  "qrCodeUrl": "string",
  "notes": [
    {
      "isPartialData": true,
      "isReadOnly": true,
      "id": "string",
      "createdDT": "2026-01-29T03:23:16.506Z",
      "createdById": "string",
      "modifiedDT": "2026-01-29T03:23:16.506Z",
      "modifiedById": "string",
      "name": "string"
    }
  ],
  "defaultOrientationForReportTemplatesForgeViewerViewJson": {
    "additionalProp1": "string",
    "additionalProp2": "string",
    "additionalProp3": "string"
  }
}
```





 | _No links_ |
| 400 | 

Bad Request



 | _No links_ |
| 401 | 

Unauthorized



 | _No links_ |
| 404 | 

Not Found



 | _No links_ |
| 500 | 

Internal Server Error



 | _No links_ |

| Name | Description |
| --- | --- |
| 
id \*

string

(path)

 | 

STRATUS Assembly Id

 |

Example JSON KeyValuePair: {"key":"fieldId","value":"fieldValue"}

```
{
  "key": "string",
  "value": "string"
}
```

| Code | Description | Links |
| --- | --- | --- |
| 200 | 
OK

Media type

Controls `Accept` header.

```
{
  "key": "string",
  "value": "string"
}
```





 | _No links_ |
| 400 | 

Bad Request



 | _No links_ |
| 401 | 

Unauthorized



 | _No links_ |
| 404 | 

Not Found



 | _No links_ |
| 500 | 

Internal Server Error



 | _No links_ |

| Name | Description |
| --- | --- |
| 
id \*

string

(path)

 | 

STRATUS Assembly Id

 |

Example JSON Array of KeyValuePair: \[{"key":"field1Id","value":"field1Value"},{"key":"field2Id","value":"field2Value"},...\]

```
[
  {
    "key": "string",
    "value": "string"
  }
]
```

| Code | Description | Links |
| --- | --- | --- |
| 200 | 
OK

Media type

Controls `Accept` header.

```
0
```





 | _No links_ |
| 400 | 

Bad Request



 | _No links_ |
| 401 | 

Unauthorized



 | _No links_ |
| 404 | 

Not Found



 | _No links_ |
| 500 | 

Internal Server Error



 | _No links_ |

| Name | Description |
| --- | --- |
| 
id \*

string

(path)

 | 

STRATUS Assembly Id

 |

Array of Part CadIds used to add.

| Code | Description | Links |
| --- | --- | --- |
| 200 | 
OK

Media type

Controls `Accept` header.

```
{
  "id": "string",
  "createdDT": "2026-01-29T03:23:16.654Z",
  "modifiedDT": "2026-01-29T03:23:16.654Z",
  "projectId": "string",
  "modelId": "string",
  "cadId": "string",
  "sheetId": "string",
  "viewId": "string",
  "isViewIdOverridden": true,
  "currentTrackingStatusId": "string",
  "currentDivisionId": "string",
  "assemblyType": "0 = Unspecified",
  "assemblyTypeLabel": "string",
  "excludedCadIds": [
    "string"
  ],
  "fieldIdToValueMap": {
    "additionalProp1": "string",
    "additionalProp2": "string",
    "additionalProp3": "string"
  },
  "fieldNameToValueMap": {
    "additionalProp1": "string",
    "additionalProp2": "string",
    "additionalProp3": "string"
  },
  "name": "string",
  "nameLabel": "string",
  "partIds": [
    "string"
  ],
  "instanceIndex": "string",
  "lastUsedAssembliesPartsTableReportIds": [
    "string"
  ],
  "qrCodeUrl": "string",
  "notes": [
    {
      "isPartialData": true,
      "isReadOnly": true,
      "id": "string",
      "createdDT": "2026-01-29T03:23:16.654Z",
      "createdById": "string",
      "modifiedDT": "2026-01-29T03:23:16.654Z",
      "modifiedById": "string",
      "name": "string"
    }
  ],
  "defaultOrientationForReportTemplatesForgeViewerViewJson": {
    "additionalProp1": "string",
    "additionalProp2": "string",
    "additionalProp3": "string"
  }
}
```





 | _No links_ |
| 400 | 

Bad Request



 | _No links_ |
| 401 | 

Unauthorized



 | _No links_ |
| 404 | 

Not Found



 | _No links_ |
| 500 | 

Internal Server Error



 | _No links_ |

### Attachment

| Name | Description |
| --- | --- |
| 
id \*

string

(path)

 | 

STRATUS Attachment Id

 |

| Code | Description | Links |
| --- | --- | --- |
| 200 | 
OK

Media type

Controls `Accept` header.

```
"string"
```





 | _No links_ |
| 400 | 

Bad Request



 | _No links_ |
| 401 | 

Unauthorized



 | _No links_ |
| 404 | 

Not Found



 | _No links_ |
| 500 | 

Internal Server Error



 | _No links_ |

| Name | Description |
| --- | --- |
| 
include

(query)

 | 

A comma delimited list of JSON properties to return. All remaining JSON properties will removed from the JSON response. Example: id, description, cutListItems. Specific dictionary keys can be included as follows: properties\["Family"\], propertiesGtp\["Material"\]

 |
| 

where

(query)

 | 

Filter on JSON property values. Example: To filter on two JSON properties: length eq '10' AND description == "truck". To get the last 30 days of data, use: createdDT ge DateTime.Now.AddDays(-30)

 |
| 

page

(query)

 | 

Offset retrieves a given page of data, where 0 is the 1st page, etc (number of elements per page is set by PageSize below)

 |
| 

pagesize

(query)

 | 

Optional: defines the number of elements per page (default (and max) is 1000)

 |
| 

disabletotal

(query)

 | 

Optional: disable total calculation to improve performance (default is false)

 |

| Code | Description | Links |
| --- | --- | --- |
| 200 | 
OK

Media type

Controls `Accept` header.

```
{
  "data": [
    {
      "id": "string",
      "createdById": "string",
      "createdDT": "2026-01-29T03:23:16.739Z",
      "projectId": "string",
      "modelId": "string",
      "referenceType": "0 = Unspecified",
      "referenceName": "string",
      "referenceId": "string",
      "role": "0 = Unspecified",
      "roleName": "string",
      "fileType": "0 = Unspecified",
      "fileTypeName": "string",
      "localFilePath": "string",
      "fileName": "string",
      "overriddenRemoteFolder": "string"
    }
  ],
  "pageOffset": 0,
  "pageLimit": 0,
  "pageCount": 0,
  "total": 0,
  "truncatedResults": true,
  "truncatedReason": "string",
  "filterOptions": [
    {
      "isValueConcatenated": true,
      "data": "string",
      "options": [
        "string"
      ]
    }
  ],
  "links": {
    "additionalProp1": "string",
    "additionalProp2": "string",
    "additionalProp3": "string"
  }
}
```





 | _No links_ |
| 400 | 

Bad Request



 | _No links_ |
| 401 | 

Unauthorized



 | _No links_ |
| 404 | 

Not Found



 | _No links_ |
| 500 | 

Internal Server Error



 | _No links_ |

| Name | Description |
| --- | --- |
| 
id \*

string

(path)

 | 

STRATUS Attachment Id

 |

| Code | Description | Links |
| --- | --- | --- |
| 200 | 
OK

Media type

Controls `Accept` header.

```
{
  "isPartialData": true,
  "isReadOnly": true,
  "id": "string",
  "createdDT": "2026-01-29T03:23:16.776Z",
  "createdById": "string",
  "modifiedDT": "2026-01-29T03:23:16.776Z",
  "modifiedById": "string",
  "fabConfigName": "string",
  "fabFileGroupId": 0,
  "fabLocaleId": 0,
  "fabProfileName": "string",
  "fabUnitType": "0 = Imperial",
  "fileByteCount": 0,
  "fileName": "string",
  "fileType": "0 = Unspecified",
  "fileUploadTimeInSeconds": 0,
  "isCollaboration": true,
  "isPrimaryModel": true,
  "itemIdBase64URN": "string",
  "itemId": "string",
  "itemLink": "string",
  "localFilePath": "string",
  "modelId": "string",
  "overriddenRemoteFolder": "string",
  "parentAttachmentId": "string",
  "previewImageFileId": "string",
  "previousVersions": {
    "additionalProp1": "string",
    "additionalProp2": "string",
    "additionalProp3": "string"
  },
  "projectId": "string",
  "referenceId": "string",
  "referenceType": "0 = Unspecified",
  "role": "0 = Unspecified",
  "totalTransformationMatrix": [
    "string"
  ]
}
```





 | _No links_ |
| 400 | 

Bad Request



 | _No links_ |
| 401 | 

Unauthorized



 | _No links_ |
| 404 | 

Not Found



 | _No links_ |
| 500 | 

Internal Server Error



 | _No links_ |

### Company

| Code | Description | Links |
| --- | --- | --- |
| 200 | 
OK

Media type

Controls `Accept` header.

```
[
  {
    "id": "string",
    "name": "string",
    "sequenceNumber": 0
  }
]
```





 | _No links_ |
| 400 | 

Bad Request



 | _No links_ |
| 401 | 

Unauthorized



 | _No links_ |
| 404 | 

Not Found



 | _No links_ |
| 500 | 

Internal Server Error



 | _No links_ |

| Name | Description |
| --- | --- |
| 
where

(query)

 | 

Filter on JSON property values. Example: To filter on two JSON properties: length eq '10' AND description == "truck". To get the last 30 days of data, use: createdDT ge DateTime.Now.AddDays(-30)

 |

| Code | Description | Links |
| --- | --- | --- |
| 200 | 
OK

Media type

Controls `Accept` header.

```
[
  {
    "id": "string",
    "name": "string",
    "code": "string",
    "color": "string",
    "hourlyRate": 0
  }
]
```





 | _No links_ |
| 400 | 

Bad Request



 | _No links_ |
| 401 | 

Unauthorized



 | _No links_ |
| 404 | 

Not Found



 | _No links_ |
| 500 | 

Internal Server Error



 | _No links_ |

| Name | Description |
| --- | --- |
| 
where

(query)

 | 

Filter on JSON property values. Example: To filter on two JSON properties: length eq '10' AND description == "truck". To get the last 30 days of data, use: createdDT ge DateTime.Now.AddDays(-30)

 |

| Code | Description | Links |
| --- | --- | --- |
| 200 | 
OK

Media type

Controls `Accept` header.

```
[
  {
    "createdDT": "2026-01-29T03:23:16.855Z",
    "dataType": "0 = String",
    "dataTypeName": "string",
    "defaultValue": "string",
    "description": "string",
    "displayName": "string",
    "expression": "string",
    "filterId": "string",
    "id": "string",
    "isEditable": true,
    "isExpression": true,
    "isTotal": true,
    "modifiedDT": "2026-01-29T03:23:16.855Z",
    "name": "string",
    "possibleValues": "string",
    "unit": "string"
  }
]
```





 | _No links_ |
| 400 | 

Bad Request



 | _No links_ |
| 401 | 

Unauthorized



 | _No links_ |
| 404 | 

Not Found



 | _No links_ |
| 500 | 

Internal Server Error



 | _No links_ |

| Code | Description | Links |
| --- | --- | --- |
| 200 | 
OK

Media type

Controls `Accept` header.

```
{
  "assemblyName": "string",
  "packageName": "string",
  "packageNumber": "string",
  "purchaseNumber": "string"
}
```





 | _No links_ |
| 400 | 

Bad Request



 | _No links_ |
| 401 | 

Unauthorized



 | _No links_ |
| 404 | 

Not Found



 | _No links_ |
| 500 | 

Internal Server Error



 | _No links_ |

| Name | Description |
| --- | --- |
| 
projectId

string

(query)

 |  |
| 

enforceProjectRole

boolean

(query)

 | 

_Default value_ : false

 |
| 

where

(query)

 | 

Filter on JSON property values. Example: To filter on two JSON properties: length eq '10' AND description == "truck". To get the last 30 days of data, use: createdDT ge DateTime.Now.AddDays(-30)

 |

| Code | Description | Links |
| --- | --- | --- |
| 200 | 
OK

Media type

Controls `Accept` header.

```
[
  {
    "id": "string",
    "name": "string",
    "description": "string",
    "abbreviation": "string",
    "useAssemblies": true,
    "useContainers": true
  }
]
```





 | _No links_ |
| 400 | 

Bad Request



 | _No links_ |
| 401 | 

Unauthorized



 | _No links_ |
| 404 | 

Not Found



 | _No links_ |
| 500 | 

Internal Server Error



 | _No links_ |

| Name | Description |
| --- | --- |
| 
trackingStatusId

string

(query)

 |  |
| 

where

(query)

 | 

Filter on JSON property values. Example: To filter on two JSON properties: length eq '10' AND description == "truck". To get the last 30 days of data, use: createdDT ge DateTime.Now.AddDays(-30)

 |

| Code | Description | Links |
| --- | --- | --- |
| 200 | 
OK

Media type

Controls `Accept` header.

```
[
  {
    "id": "string",
    "name": "string",
    "trackingStatusGroupId": "string",
    "trackingStatusGroupName": "string"
  }
]
```





 | _No links_ |
| 400 | 

Bad Request



 | _No links_ |
| 401 | 

Unauthorized



 | _No links_ |
| 404 | 

Not Found



 | _No links_ |
| 500 | 

Internal Server Error



 | _No links_ |

| Code | Description | Links |
| --- | --- | --- |
| 200 | 
OK

Media type

Controls `Accept` header.

```
[
  {
    "id": "string",
    "name": "string"
  }
]
```





 | _No links_ |
| 400 | 

Bad Request



 | _No links_ |
| 401 | 

Unauthorized



 | _No links_ |
| 404 | 

Not Found



 | _No links_ |
| 500 | 

Internal Server Error



 | _No links_ |

| Code | Description | Links |
| --- | --- | --- |
| 200 | 
OK

Media type

Controls `Accept` header.

```
[
  {
    "id": "string",
    "name": "string"
  }
]
```





 | _No links_ |
| 400 | 

Bad Request



 | _No links_ |
| 401 | 

Unauthorized



 | _No links_ |
| 404 | 

Not Found



 | _No links_ |
| 500 | 

Internal Server Error



 | _No links_ |

| Code | Description | Links |
| --- | --- | --- |
| 200 | 
OK

Media type

Controls `Accept` header.

```
[
  {
    "id": "string",
    "name": "string",
    "formatTypeName": "string",
    "itemTypeName": "string"
  }
]
```





 | _No links_ |
| 400 | 

Bad Request



 | _No links_ |
| 401 | 

Unauthorized



 | _No links_ |
| 404 | 

Not Found



 | _No links_ |
| 500 | 

Internal Server Error



 | _No links_ |

| Name | Description |
| --- | --- |
| 
queryId

string

(query)

 |  |

| Code | Description | Links |
| --- | --- | --- |
| 200 | 
OK

Media type

Controls `Accept` header.

```
{
  "content": "string"
}
```





 | _No links_ |
| 400 | 

Bad Request



 | _No links_ |
| 401 | 

Unauthorized



 | _No links_ |
| 404 | 

Not Found



 | _No links_ |
| 500 | 

Internal Server Error



 | _No links_ |

| Name | Description |
| --- | --- |
| 
where

(query)

 | 

Filter on JSON property values. Example: To filter on two JSON properties: length eq '10' AND description == "truck". To get the last 30 days of data, use: createdDT ge DateTime.Now.AddDays(-30)

 |

| Code | Description | Links |
| --- | --- | --- |
| 200 | 
OK

Media type

Controls `Accept` header.

```
[
  {
    "id": "string",
    "name": "string",
    "description": "string",
    "divisionId": "string",
    "toolId": "string",
    "imageFileId": "string",
    "managedMaterials": [
      "string"
    ],
    "managedMaterialsValues": "string",
    "taskDefinitionIds": [
      "string"
    ]
  }
]
```





 | _No links_ |
| 400 | 

Bad Request



 | _No links_ |
| 401 | 

Unauthorized



 | _No links_ |
| 404 | 

Not Found



 | _No links_ |
| 500 | 

Internal Server Error



 | _No links_ |

| Name | Description |
| --- | --- |
| 
where

(query)

 | 

Filter on JSON property values. Example: To filter on two JSON properties: length eq '10' AND description == "truck". To get the last 30 days of data, use: createdDT ge DateTime.Now.AddDays(-30)

 |

| Code | Description | Links |
| --- | --- | --- |
| 200 | 
OK

Media type

Controls `Accept` header.

```
[
  {
    "applyToPackageCategoryId": "string",
    "autoComplete": true,
    "color": "string",
    "costCategoryId": "string",
    "costTypeId": "string",
    "description": "string",
    "filterIds": [
      "string"
    ],
    "id": "string",
    "initiatedByTrackingStatusId": "string",
    "isEnabled": true,
    "isJoin": true,
    "name": "string",
    "referenceType": "0 = Unspecified",
    "reportId": "string",
    "separateTaskPerFilter": true,
    "sequenceNumber": 0,
    "taskCategoryId": "string",
    "trackingStatusApplyToAssembly": true,
    "trackingStatusApplyToOrder": true,
    "trackingStatusApplyToPart": true,
    "trackingStatusBypassDialog": true,
    "trackingStatusId": "string",
    "unitOfMeasureFieldId": "string",
    "unitVelocity": 0
  }
]
```





 | _No links_ |
| 400 | 

Bad Request



 | _No links_ |
| 401 | 

Unauthorized



 | _No links_ |
| 404 | 

Not Found



 | _No links_ |
| 500 | 

Internal Server Error



 | _No links_ |

| Code | Description | Links |
| --- | --- | --- |
| 200 | 
OK

Media type

Controls `Accept` header.

```
[
  {
    "id": "string",
    "name": "string",
    "sequenceNumber": 0
  }
]
```





 | _No links_ |
| 400 | 

Bad Request



 | _No links_ |
| 401 | 

Unauthorized



 | _No links_ |
| 404 | 

Not Found



 | _No links_ |
| 500 | 

Internal Server Error



 | _No links_ |

| Name | Description |
| --- | --- |
| 
projectId

string

(query)

 |  |
| 

where

(query)

 | 

Filter on JSON property values. Example: To filter on two JSON properties: length eq '10' AND description == "truck". To get the last 30 days of data, use: createdDT ge DateTime.Now.AddDays(-30)

 |

| Code | Description | Links |
| --- | --- | --- |
| 200 | 
OK

Media type

Controls `Accept` header.

```
[
  {
    "id": "string",
    "name": "string",
    "description": "string",
    "color": "string",
    "sequenceNumber": 0,
    "canAddToAssembly": true,
    "canAddToOrder": true,
    "canRenumberItems": true,
    "canAddToBOM": true,
    "canGenerateCutList": true,
    "appliedAtOrder": true,
    "appliedAtAssembly": true,
    "appliedAtPart": true,
    "appliedAtContainer": true,
    "onHold": true,
    "trackingStatusGroupIds": [
      "string"
    ],
    "trackingStatusGroups": [
      "string"
    ],
    "trackingStatusGroupPercentageMapping": {
      "additionalProp1": 0,
      "additionalProp2": 0,
      "additionalProp3": 0
    }
  }
]
```





 | _No links_ |
| 400 | 

Bad Request



 | _No links_ |
| 401 | 

Unauthorized



 | _No links_ |
| 404 | 

Not Found



 | _No links_ |
| 500 | 

Internal Server Error



 | _No links_ |

REQUIRED: FieldDataApi - minimum json includes name

```
{
  "createdDT": "2026-01-29T03:23:17.266Z",
  "dataType": "0 = String",
  "defaultValue": "string",
  "description": "string",
  "displayName": "string",
  "expression": "string",
  "filterId": "string",
  "id": "string",
  "isEditable": true,
  "isExpression": true,
  "isTotal": true,
  "modifiedDT": "2026-01-29T03:23:17.266Z",
  "name": "string",
  "possibleValues": "string",
  "unit": "string"
}
```

| Code | Description | Links |
| --- | --- | --- |
| 200 | 
OK

Media type

Controls `Accept` header.

```
{
  "createdDT": "2026-01-29T03:23:17.272Z",
  "dataType": "0 = String",
  "dataTypeName": "string",
  "defaultValue": "string",
  "description": "string",
  "displayName": "string",
  "expression": "string",
  "filterId": "string",
  "id": "string",
  "isEditable": true,
  "isExpression": true,
  "isTotal": true,
  "modifiedDT": "2026-01-29T03:23:17.272Z",
  "name": "string",
  "possibleValues": "string",
  "unit": "string"
}
```





 | _No links_ |
| 400 | 

Bad Request



 | _No links_ |
| 401 | 

Unauthorized



 | _No links_ |
| 404 | 

Not Found



 | _No links_ |
| 500 | 

Internal Server Error



 | _No links_ |

### Container

| Name | Description |
| --- | --- |
| 
include

(query)

 | 

A comma delimited list of JSON properties to return. All remaining JSON properties will removed from the JSON response. Example: id, description, cutListItems. Specific dictionary keys can be included as follows: properties\["Family"\], propertiesGtp\["Material"\]

 |
| 

where

(query)

 | 

Filter on JSON property values. Example: To filter on two JSON properties: length eq '10' AND description == "truck". To get the last 30 days of data, use: createdDT ge DateTime.Now.AddDays(-30)

 |
| 

page

(query)

 | 

Offset retrieves a given page of data, where 0 is the 1st page, etc (number of elements per page is set by PageSize below)

 |
| 

pagesize

(query)

 | 

Optional: defines the number of elements per page (default (and max) is 1000)

 |
| 

disabletotal

(query)

 | 

Optional: disable total calculation to improve performance (default is false)

 |

| Code | Description | Links |
| --- | --- | --- |
| 200 | 
OK

Media type

Controls `Accept` header.

```
{
  "data": [
    {
      "id": "string",
      "name": "string",
      "description": "string",
      "length": "string",
      "width": "string",
      "height": "string",
      "location": "string",
      "containerTypeName": "string",
      "parentContainerId": "string",
      "currentTrackingStatusId": "string",
      "currentDivisionId": "string",
      "qrCodeUrl": "string",
      "fieldIdToValueMap": {
        "additionalProp1": "string",
        "additionalProp2": "string",
        "additionalProp3": "string"
      },
      "partIds": [
        "string"
      ],
      "assemblyCadIds": [
        "string"
      ],
      "packageIds": [
        "string"
      ],
      "containerIds": [
        "string"
      ],
      "contents": [
        {
          "projectId": "string",
          "referenceId": "string",
          "referenceType": "0 = Unspecified"
        }
      ]
    }
  ],
  "pageOffset": 0,
  "pageLimit": 0,
  "pageCount": 0,
  "total": 0,
  "truncatedResults": true,
  "truncatedReason": "string",
  "filterOptions": [
    {
      "isValueConcatenated": true,
      "data": "string",
      "options": [
        "string"
      ]
    }
  ],
  "links": {
    "additionalProp1": "string",
    "additionalProp2": "string",
    "additionalProp3": "string"
  }
}
```





 | _No links_ |
| 400 | 

Bad Request



 | _No links_ |
| 401 | 

Unauthorized



 | _No links_ |
| 404 | 

Not Found



 | _No links_ |
| 500 | 

Internal Server Error



 | _No links_ |

| Name | Description |
| --- | --- |
| 
id \*

string

(path)

 | 

STRATUS Container Id

 |
| 

include

(query)

 | 

A comma delimited list of JSON properties to return. All remaining JSON properties will removed from the JSON response. Example: id, description, cutListItems. Specific dictionary keys can be included as follows: properties\["Family"\], propertiesGtp\["Material"\]

 |

| Code | Description | Links |
| --- | --- | --- |
| 200 | 
OK

Media type

Controls `Accept` header.

```
{
  "id": "string",
  "name": "string",
  "description": "string",
  "length": "string",
  "width": "string",
  "height": "string",
  "location": "string",
  "containerTypeName": "string",
  "parentContainerId": "string",
  "currentTrackingStatusId": "string",
  "currentDivisionId": "string",
  "qrCodeUrl": "string",
  "fieldIdToValueMap": {
    "additionalProp1": "string",
    "additionalProp2": "string",
    "additionalProp3": "string"
  },
  "partIds": [
    "string"
  ],
  "assemblyCadIds": [
    "string"
  ],
  "packageIds": [
    "string"
  ],
  "containerIds": [
    "string"
  ],
  "contents": [
    {
      "projectId": "string",
      "referenceId": "string",
      "referenceType": "0 = Unspecified"
    }
  ]
}
```





 | _No links_ |
| 400 | 

Bad Request



 | _No links_ |
| 401 | 

Unauthorized



 | _No links_ |
| 404 | 

Not Found



 | _No links_ |
| 500 | 

Internal Server Error



 | _No links_ |

| Name | Description |
| --- | --- |
| 
where

(query)

 | 

Filter on JSON property values. Example: To filter on two JSON properties: length eq '10' AND description == "truck". To get the last 30 days of data, use: createdDT ge DateTime.Now.AddDays(-30)

 |
| 

page

(query)

 | 

Offset retrieves a given page of data, where 0 is the 1st page, etc (number of elements per page is set by PageSize below)

 |
| 

pagesize

(query)

 | 

Optional: defines the number of elements per page (default (and max) is 1000)

 |
| 

disabletotal

(query)

 | 

Optional: disable total calculation to improve performance (default is false)

 |

| Code | Description | Links |
| --- | --- | --- |
| 200 | 
OK

Media type

Controls `Accept` header.

```
{
  "data": [
    {
      "id": "string",
      "url": "string",
      "projectId": "string",
      "modelId": "string"
    }
  ],
  "pageOffset": 0,
  "pageLimit": 0,
  "pageCount": 0,
  "total": 0,
  "truncatedResults": true,
  "truncatedReason": "string",
  "filterOptions": [
    {
      "isValueConcatenated": true,
      "data": "string",
      "options": [
        "string"
      ]
    }
  ],
  "links": {
    "additionalProp1": "string",
    "additionalProp2": "string",
    "additionalProp3": "string"
  }
}
```





 | _No links_ |
| 400 | 

Bad Request



 | _No links_ |
| 401 | 

Unauthorized



 | _No links_ |
| 404 | 

Not Found



 | _No links_ |
| 500 | 

Internal Server Error



 | _No links_ |

Container creation request containing name, description, dimensions, and other properties

```
{
  "name": "string",
  "description": "string",
  "containerTypeId": "string",
  "divisionId": "string",
  "length": 0,
  "width": 0,
  "height": 0,
  "location": "string"
}
```

| Code | Description | Links |
| --- | --- | --- |
| 200 | 
OK

Media type

Controls `Accept` header.

```
{
  "id": "string",
  "name": "string",
  "description": "string",
  "length": "string",
  "width": "string",
  "height": "string",
  "location": "string",
  "containerTypeName": "string",
  "parentContainerId": "string",
  "currentTrackingStatusId": "string",
  "currentDivisionId": "string",
  "qrCodeUrl": "string",
  "fieldIdToValueMap": {
    "additionalProp1": "string",
    "additionalProp2": "string",
    "additionalProp3": "string"
  },
  "partIds": [
    "string"
  ],
  "assemblyCadIds": [
    "string"
  ],
  "packageIds": [
    "string"
  ],
  "containerIds": [
    "string"
  ],
  "contents": [
    {
      "projectId": "string",
      "referenceId": "string",
      "referenceType": "0 = Unspecified"
    }
  ]
}
```





 | _No links_ |
| 400 | 

Bad Request



 | _No links_ |
| 401 | 

Unauthorized



 | _No links_ |
| 409 | 

Conflict



 | _No links_ |
| 500 | 

Internal Server Error



 | _No links_ |

| Name | Description |
| --- | --- |
| 
id \*

string

(path)

 | 

STRATUS Container Id

 |

REQUIRED: TrackingStatusId

```
{
  "comment": "string",
  "costTypeId": "string",
  "createdDT": "2026-01-29T03:23:17.525Z",
  "divisionId": "string",
  "hours": 0,
  "trackingLogEntryIdResult": "string",
  "trackingStatusId": "string"
}
```

| Code | Description | Links |
| --- | --- | --- |
| 200 | 
OK

Media type

Controls `Accept` header.

```
{
  "comment": "string",
  "costTypeId": "string",
  "createdDT": "2026-01-29T03:23:17.533Z",
  "divisionId": "string",
  "hours": 0,
  "trackingLogEntryIdResult": "string",
  "trackingStatusId": "string"
}
```





 | _No links_ |
| 400 | 

Bad Request



 | _No links_ |
| 401 | 

Unauthorized



 | _No links_ |
| 404 | 

Not Found



 | _No links_ |
| 500 | 

Internal Server Error



 | _No links_ |

| Name | Description |
| --- | --- |
| 
id \*

string

(path)

 | 

STRATUS Container Id

 |

Location hyperlink or description

| Code | Description | Links |
| --- | --- | --- |
| 200 | 
OK

Media type

Controls `Accept` header.

```
true
```





 | _No links_ |
| 400 | 

Bad Request



 | _No links_ |
| 401 | 

Unauthorized



 | _No links_ |
| 404 | 

Not Found



 | _No links_ |
| 500 | 

Internal Server Error



 | _No links_ |

| Name | Description |
| --- | --- |
| 
id \*

string

(path)

 | 

STRATUS Container Id

 |

| Code | Description | Links |
| --- | --- | --- |
| 200 | 
OK

Media type

Controls `Accept` header.

```
true
```





 | _No links_ |
| 400 | 

Bad Request



 | _No links_ |
| 401 | 

Unauthorized



 | _No links_ |
| 404 | 

Not Found



 | _No links_ |
| 500 | 

Internal Server Error



 | _No links_ |

### CutList

| Name | Description |
| --- | --- |
| 
include

(query)

 | 

A comma delimited list of JSON properties to return. All remaining JSON properties will removed from the JSON response. Example: id, description, cutListItems. Specific dictionary keys can be included as follows: properties\["Family"\], propertiesGtp\["Material"\]

 |
| 

where

(query)

 | 

Filter on JSON property values. Example: To filter on two JSON properties: length eq '10' AND description == "truck". To get the last 30 days of data, use: createdDT ge DateTime.Now.AddDays(-30)

 |
| 

page

(query)

 | 

Offset retrieves a given page of data, where 0 is the 1st page, etc (number of elements per page is set by PageSize below)

 |
| 

pagesize

(query)

 | 

Optional: defines the number of elements per page (default (and max) is 100)

 |
| 

disabletotal

(query)

 | 

Optional: disable total calculation to improve performance (default is false)

 |

| Code | Description | Links |
| --- | --- | --- |
| 200 | 
OK

Media type

Controls `Accept` header.

```
{
  "data": [
    {
      "id": "string",
      "completedDT": "2026-01-29T03:23:17.669Z",
      "createdDT": "2026-01-29T03:23:17.669Z",
      "createdById": "string",
      "modifiedDT": "2026-01-29T03:23:17.669Z",
      "modifiedById": "string",
      "cutListItems": [
        {
          "area": "string",
          "assemblyId": "string",
          "assemblyName": "string",
          "index": 0,
          "cadId": "string",
          "cutDateTime": "2026-01-29T03:23:17.669Z",
          "description": "string",
          "itemNumber": "string",
          "lengthInInches": 0,
          "lengthInFeetAndInches": "string",
          "level": "string",
          "preFabId": "string",
          "qrCode": "string",
          "userData1": "string",
          "userData2": "string",
          "userData3": "string",
          "userData4": "string",
          "userData5": "string",
          "userData6": "string",
          "userData7": "string",
          "userData8": "string",
          "userData9": "string",
          "userData10": "string",
          "userData11": "string",
          "userData12": "string",
          "userData13": "string",
          "userData14": "string",
          "userData15": "string"
        }
      ],
      "cutListItemCount": 0,
      "cutListStatus": "0 = New",
      "cutListStatusLabel": "string",
      "cutListStatusName": "string",
      "isAutoGeneratedCutList": true,
      "material": "string",
      "modelId": "string",
      "name": "string",
      "packageId": "string",
      "percentComplete": 0,
      "projectId": "string",
      "requestedDT": "2026-01-29T03:23:17.669Z",
      "requestedUserId": "string",
      "size": "string",
      "startedDT": "2026-01-29T03:23:17.669Z",
      "stationId": "string",
      "totalLengthInInches": 0,
      "totalLengthInFeetAndInches": "string"
    }
  ],
  "pageOffset": 0,
  "pageLimit": 0,
  "pageCount": 0,
  "total": 0,
  "truncatedResults": true,
  "truncatedReason": "string",
  "filterOptions": [
    {
      "isValueConcatenated": true,
      "data": "string",
      "options": [
        "string"
      ]
    }
  ],
  "links": {
    "additionalProp1": "string",
    "additionalProp2": "string",
    "additionalProp3": "string"
  }
}
```





 | _No links_ |
| 400 | 

Bad Request



 | _No links_ |
| 401 | 

Unauthorized



 | _No links_ |
| 404 | 

Not Found



 | _No links_ |
| 500 | 

Internal Server Error



 | _No links_ |

| Name | Description |
| --- | --- |
| 
id \*

string

(path)

 | 

STRATUS Cut List Id

 |

| Code | Description | Links |
| --- | --- | --- |
| 200 | 
OK

Media type

Controls `Accept` header.

```
{
  "id": "string",
  "completedDT": "2026-01-29T03:23:17.703Z",
  "createdDT": "2026-01-29T03:23:17.703Z",
  "createdById": "string",
  "modifiedDT": "2026-01-29T03:23:17.703Z",
  "modifiedById": "string",
  "cutListItems": [
    {
      "area": "string",
      "assemblyId": "string",
      "assemblyName": "string",
      "index": 0,
      "cadId": "string",
      "cutDateTime": "2026-01-29T03:23:17.703Z",
      "description": "string",
      "itemNumber": "string",
      "lengthInInches": 0,
      "lengthInFeetAndInches": "string",
      "level": "string",
      "preFabId": "string",
      "qrCode": "string",
      "userData1": "string",
      "userData2": "string",
      "userData3": "string",
      "userData4": "string",
      "userData5": "string",
      "userData6": "string",
      "userData7": "string",
      "userData8": "string",
      "userData9": "string",
      "userData10": "string",
      "userData11": "string",
      "userData12": "string",
      "userData13": "string",
      "userData14": "string",
      "userData15": "string"
    }
  ],
  "cutListItemCount": 0,
  "cutListStatus": "0 = New",
  "cutListStatusLabel": "string",
  "cutListStatusName": "string",
  "isAutoGeneratedCutList": true,
  "material": "string",
  "modelId": "string",
  "name": "string",
  "packageId": "string",
  "percentComplete": 0,
  "projectId": "string",
  "requestedDT": "2026-01-29T03:23:17.703Z",
  "requestedUserId": "string",
  "size": "string",
  "startedDT": "2026-01-29T03:23:17.703Z",
  "stationId": "string",
  "totalLengthInInches": 0,
  "totalLengthInFeetAndInches": "string"
}
```





 | _No links_ |
| 400 | 

Bad Request



 | _No links_ |
| 401 | 

Unauthorized



 | _No links_ |
| 404 | 

Not Found



 | _No links_ |
| 500 | 

Internal Server Error



 | _No links_ |

### Model

| Name | Description |
| --- | --- |
| 
include

(query)

 | 

A comma delimited list of JSON properties to return. All remaining JSON properties will removed from the JSON response. Example: id, description, cutListItems. Specific dictionary keys can be included as follows: properties\["Family"\], propertiesGtp\["Material"\]

 |
| 

where

(query)

 | 

Filter on JSON property values. Example: To filter on two JSON properties: length eq '10' AND description == "truck". To get the last 30 days of data, use: createdDT ge DateTime.Now.AddDays(-30)

 |
| 

page

(query)

 | 

Offset retrieves a given page of data, where 0 is the 1st page, etc (number of elements per page is set by PageSize below)

 |
| 

pagesize

(query)

 | 

Optional: defines the number of elements per page (default (and max) is 1000)

 |
| 

disabletotal

(query)

 | 

Optional: disable total calculation to improve performance (default is false)

 |

| Code | Description | Links |
| --- | --- | --- |
| 200 | 
OK

Media type

Controls `Accept` header.

```
{
  "data": [
    {
      "a360FolderId": "string",
      "createdDT": "2026-01-29T03:23:17.770Z",
      "databaseUnits": "0 = Imperial",
      "defaultViewId": "string",
      "id": "string",
      "isFieldOrderz": true,
      "lastPublishedDT": "2026-01-29T03:23:17.770Z",
      "modelName": "string",
      "modelType": "0 = Unspecified",
      "modifiedDT": "2026-01-29T03:23:17.770Z",
      "name": "string",
      "projectId": "string",
      "publishStatus": "0 = Published",
      "releaseVersion": "string"
    }
  ],
  "pageOffset": 0,
  "pageLimit": 0,
  "pageCount": 0,
  "total": 0,
  "truncatedResults": true,
  "truncatedReason": "string",
  "filterOptions": [
    {
      "isValueConcatenated": true,
      "data": "string",
      "options": [
        "string"
      ]
    }
  ],
  "links": {
    "additionalProp1": "string",
    "additionalProp2": "string",
    "additionalProp3": "string"
  }
}
```





 | _No links_ |
| 400 | 

Bad Request



 | _No links_ |
| 401 | 

Unauthorized



 | _No links_ |
| 404 | 

Not Found



 | _No links_ |
| 500 | 

Internal Server Error



 | _No links_ |

| Name | Description |
| --- | --- |
| 
id \*

string

(path)

 | 

STRATUS Model Id

 |
| 

include

(query)

 | 

A comma delimited list of JSON properties to return. All remaining JSON properties will removed from the JSON response. Example: id, description, cutListItems. Specific dictionary keys can be included as follows: properties\["Family"\], propertiesGtp\["Material"\]

 |

| Code | Description | Links |
| --- | --- | --- |
| 200 | 
OK

Media type

Controls `Accept` header.

```
{
  "a360FolderId": "string",
  "createdDT": "2026-01-29T03:23:17.817Z",
  "databaseUnits": "0 = Imperial",
  "defaultViewId": "string",
  "id": "string",
  "isFieldOrderz": true,
  "lastPublishedDT": "2026-01-29T03:23:17.817Z",
  "modelName": "string",
  "modelType": "0 = Unspecified",
  "modifiedDT": "2026-01-29T03:23:17.817Z",
  "name": "string",
  "projectId": "string",
  "publishStatus": "0 = Published",
  "releaseVersion": "string"
}
```





 | _No links_ |
| 400 | 

Bad Request



 | _No links_ |
| 401 | 

Unauthorized



 | _No links_ |
| 404 | 

Not Found



 | _No links_ |
| 500 | 

Internal Server Error



 | _No links_ |

| Name | Description |
| --- | --- |
| 
id \*

string

(path)

 | 

STRATUS Model Id

 |
| 

include

(query)

 | 

A comma delimited list of JSON properties to return. All remaining JSON properties will removed from the JSON response. Example: id, description, cutListItems. Specific dictionary keys can be included as follows: properties\["Family"\], propertiesGtp\["Material"\]

 |
| 

where

(query)

 | 

Filter on JSON property values. Example: To filter on two JSON properties: length eq '10' AND description == "truck". To get the last 30 days of data, use: createdDT ge DateTime.Now.AddDays(-30)

 |
| 

page

(query)

 | 

Offset retrieves a given page of data, where 0 is the 1st page, etc (number of elements per page is set by PageSize below)

 |
| 

pagesize

(query)

 | 

Optional: defines the number of elements per page (default (and max) is 1000)

 |
| 

disabletotal

(query)

 | 

Optional: disable total calculation to improve performance (default is false)

 |

| Code | Description | Links |
| --- | --- | --- |
| 200 | 
OK

Media type

Controls `Accept` header.

```
{
  "data": [
    {
      "id": "string",
      "createdDT": "2026-01-29T03:23:17.878Z",
      "modifiedDT": "2026-01-29T03:23:17.878Z",
      "projectId": "string",
      "modelId": "string",
      "cadId": "string",
      "sheetId": "string",
      "viewId": "string",
      "isViewIdOverridden": true,
      "currentTrackingStatusId": "string",
      "currentDivisionId": "string",
      "assemblyType": "0 = Unspecified",
      "assemblyTypeLabel": "string",
      "excludedCadIds": [
        "string"
      ],
      "fieldIdToValueMap": {
        "additionalProp1": "string",
        "additionalProp2": "string",
        "additionalProp3": "string"
      },
      "fieldNameToValueMap": {
        "additionalProp1": "string",
        "additionalProp2": "string",
        "additionalProp3": "string"
      },
      "name": "string",
      "nameLabel": "string",
      "partIds": [
        "string"
      ],
      "instanceIndex": "string",
      "lastUsedAssembliesPartsTableReportIds": [
        "string"
      ],
      "qrCodeUrl": "string",
      "notes": [
        {
          "isPartialData": true,
          "isReadOnly": true,
          "id": "string",
          "createdDT": "2026-01-29T03:23:17.879Z",
          "createdById": "string",
          "modifiedDT": "2026-01-29T03:23:17.879Z",
          "modifiedById": "string",
          "name": "string"
        }
      ],
      "defaultOrientationForReportTemplatesForgeViewerViewJson": {
        "additionalProp1": "string",
        "additionalProp2": "string",
        "additionalProp3": "string"
      }
    }
  ],
  "pageOffset": 0,
  "pageLimit": 0,
  "pageCount": 0,
  "total": 0,
  "truncatedResults": true,
  "truncatedReason": "string",
  "filterOptions": [
    {
      "isValueConcatenated": true,
      "data": "string",
      "options": [
        "string"
      ]
    }
  ],
  "links": {
    "additionalProp1": "string",
    "additionalProp2": "string",
    "additionalProp3": "string"
  }
}
```





 | _No links_ |
| 400 | 

Bad Request



 | _No links_ |
| 401 | 

Unauthorized



 | _No links_ |
| 404 | 

Not Found



 | _No links_ |
| 500 | 

Internal Server Error



 | _No links_ |

| Name | Description |
| --- | --- |
| 
id \*

string

(path)

 | 

STRATUS Model Id

 |

| Code | Description | Links |
| --- | --- | --- |
| 200 | 
OK

Media type

Controls `Accept` header.

```
[
  {
    "createdById": "string",
    "createdDT": "2026-01-29T03:23:17.913Z",
    "gridIntersections": [
      {
        "horizontalAnnotation": "string",
        "horizontalDirection": {
          "x": 0,
          "y": 0,
          "z": 0
        },
        "horizontalGridLineId": "string",
        "intersectionPoint": {
          "x": 0,
          "y": 0,
          "z": 0
        },
        "verticalAnnotation": "string",
        "verticalDirection": {
          "x": 0,
          "y": 0,
          "z": 0
        },
        "verticalGridLineId": "string"
      }
    ],
    "gridLines": [
      {
        "annotation": "string",
        "gridLineType": "0 = LineSegment",
        "id": "string",
        "linePoints": [
          {
            "x": 0,
            "y": 0,
            "z": 0
          }
        ]
      }
    ],
    "id": "string",
    "modelId": "string",
    "modifiedById": "string",
    "modifiedDT": "2026-01-29T03:23:17.913Z",
    "name": "string"
  }
]
```





 | _No links_ |
| 400 | 

Bad Request



 | _No links_ |
| 401 | 

Unauthorized



 | _No links_ |
| 404 | 

Not Found



 | _No links_ |
| 500 | 

Internal Server Error



 | _No links_ |

| Name | Description |
| --- | --- |
| 
id \*

string

(path)

 | 

STRATUS Model Id

 |
| 

include

(query)

 | 

A comma delimited list of JSON properties to return. All remaining JSON properties will removed from the JSON response. Example: id, description, cutListItems. Specific dictionary keys can be included as follows: properties\["Family"\], propertiesGtp\["Material"\]

 |
| 

where

(query)

 | 

Filter on JSON property values. Example: To filter on two JSON properties: length eq '10' AND description == "truck". To get the last 30 days of data, use: createdDT ge DateTime.Now.AddDays(-30)

 |
| 

page

(query)

 | 

Offset retrieves a given page of data, where 0 is the 1st page, etc (number of elements per page is set by PageSize below)

 |
| 

pagesize

(query)

 | 

Optional: defines the number of elements per page (default (and max) is 200)

 |
| 

disabletotal

(query)

 | 

Optional: disable total calculation to improve performance (default is false)

 |

| Code | Description | Links |
| --- | --- | --- |
| 200 | 
OK

Media type

Controls `Accept` header.

```
{
  "data": [
    {
      "assemblyIds": [
        "string"
      ],
      "bimAreaId": "string",
      "bimAreaName": "string",
      "cadIdsBySequence": [
        "string"
      ],
      "categoryId": "string",
      "createdBy": "string",
      "createdDT": "2026-01-29T03:23:17.978Z",
      "currentTrackingStatusId": "string",
      "currentDivisionId": "string",
      "description": "string",
      "fieldIdToValueMap": {
        "additionalProp1": "string",
        "additionalProp2": "string",
        "additionalProp3": "string"
      },
      "fieldNameToValueMap": {
        "additionalProp1": "string",
        "additionalProp2": "string",
        "additionalProp3": "string"
      },
      "hoursEstimatedField": 0,
      "hoursEstimatedOffice": 0,
      "hoursEstimatedPurchasing": 0,
      "hoursEstimatedShop": 0,
      "id": "string",
      "installedDT": "2026-01-29T03:23:17.978Z",
      "modelId": "string",
      "modifiedBy": "string",
      "modifiedDT": "2026-01-29T03:23:17.978Z",
      "name": "string",
      "number": "string",
      "officeDuration": 0,
      "officeStartDT": "2026-01-29T03:23:17.978Z",
      "partCadIds": [
        "string"
      ],
      "projectId": "string",
      "purchasingDuration": 0,
      "purchasingStartDT": "2026-01-29T03:23:17.978Z",
      "qrCodeUrl": "string",
      "requiredDT": "2026-01-29T03:23:17.978Z",
      "selectedTaskWorkflowIdsForAssemblyAndPartCadIds": {
        "additionalProp1": "string",
        "additionalProp2": "string",
        "additionalProp3": "string"
      },
      "shopDuration": 0,
      "startDT": "2026-01-29T03:23:17.978Z",
      "status": "0 = Active",
      "statusName": "string",
      "viewId": "string",
      "isViewIdOverridden": true
    }
  ],
  "pageOffset": 0,
  "pageLimit": 0,
  "pageCount": 0,
  "total": 0,
  "truncatedResults": true,
  "truncatedReason": "string",
  "filterOptions": [
    {
      "isValueConcatenated": true,
      "data": "string",
      "options": [
        "string"
      ]
    }
  ],
  "links": {
    "additionalProp1": "string",
    "additionalProp2": "string",
    "additionalProp3": "string"
  }
}
```





 | _No links_ |
| 400 | 

Bad Request



 | _No links_ |
| 401 | 

Unauthorized



 | _No links_ |
| 404 | 

Not Found



 | _No links_ |
| 500 | 

Internal Server Error



 | _No links_ |

| Name | Description |
| --- | --- |
| 
id \*

string

(path)

 |  |
| 

cadid \*

string

(path)

 | 

STRATUS.Part.CadId

 |
| 

excludeNullAndEmpty \*

boolean

(path)

 | 

Pass true to this optional query parameter if you want empty or null values removed from the part's Properties and PropertiesGtp collections to improve performance.

_Default value_ : false

 |
| 

include

(query)

 | 

A comma delimited list of JSON properties to return. All remaining JSON properties will removed from the JSON response. Example: id, description, cutListItems. Specific dictionary keys can be included as follows: properties\["Family"\], propertiesGtp\["Material"\]

 |

| Code | Description | Links |
| --- | --- | --- |
| 200 | 
OK

Media type

Controls `Accept` header.

```
{
  "id": "string",
  "createdDT": "2026-01-29T03:23:18.032Z",
  "modifiedDT": "2026-01-29T03:23:18.032Z",
  "cutDT": "2026-01-29T03:23:18.032Z",
  "projectId": "string",
  "projectName": "string",
  "projectNumber": "string",
  "modelId": "string",
  "modelName": "string",
  "bimAreaId": "string",
  "bimArea": "string",
  "cadId": "string",
  "cadType": "string",
  "webId": "string",
  "description": "string",
  "currentTrackingStatusId": "string",
  "currentDivisionId": "string",
  "properties": {
    "additionalProp1": "string",
    "additionalProp2": "string",
    "additionalProp3": "string"
  },
  "propertiesGtp": {
    "additionalProp1": "string",
    "additionalProp2": "string",
    "additionalProp3": "string"
  },
  "points": [
    {
      "pointType": "0 = Unspecified",
      "cadId": "string",
      "location": {
        "x": 0,
        "y": 0,
        "z": 0
      },
      "direction": {
        "x": 0,
        "y": 0,
        "z": 0
      },
      "upVector": {
        "x": 0,
        "y": 0,
        "z": 0
      },
      "width": 0,
      "height": 0,
      "matingElementUniqueId": "string"
    }
  ],
  "cutLengthAdjustment": 0,
  "cutLength2Adjustment": 0,
  "lockLength": true,
  "lockLocation": true,
  "qrCodeUrl": "string",
  "partUrl": "string",
  "patternNumber": "string",
  "source": "0 = PublishedModel",
  "fieldIdToValueMap": {
    "additionalProp1": "string",
    "additionalProp2": "string",
    "additionalProp3": "string"
  },
  "fieldNameToValueMap": {
    "additionalProp1": "string",
    "additionalProp2": "string",
    "additionalProp3": "string"
  }
}
```





 | _No links_ |
| 400 | 

Bad Request



 | _No links_ |
| 401 | 

Unauthorized



 | _No links_ |
| 404 | 

Not Found



 | _No links_ |
| 500 | 

Internal Server Error



 | _No links_ |

| Name | Description |
| --- | --- |
| 
id \*

string

(path)

 | 

STRATUS Model Id

 |
| 

includeStratusProperties

boolean

(query)

 | 

Pass true to this optional query parameter if you want to generate STRATUS.Part.\* properties and have them returned for the parts.

_Default value_ : false

 |
| 

excludeNullAndEmpty

boolean

(query)

 | 

Pass true to this optional query parameter if you want empty or null values removed from the part's Properties and PropertiesGtp collections to improve performance.

_Default value_ : false

 |
| 

include

(query)

 | 

A comma delimited list of JSON properties to return. All remaining JSON properties will removed from the JSON response. Example: id, description, cutListItems. Specific dictionary keys can be included as follows: properties\["Family"\], propertiesGtp\["Material"\]

 |
| 

where

(query)

 | 

Filter on JSON property values. Example: To filter on two JSON properties: length eq '10' AND description == "truck". To get the last 30 days of data, use: createdDT ge DateTime.Now.AddDays(-30)

 |
| 

page

(query)

 | 

Offset retrieves a given page of data, where 0 is the 1st page, etc (number of elements per page is set by PageSize below)

 |
| 

pagesize

(query)

 | 

Optional: defines the number of elements per page (default (and max) is 100)

 |
| 

disabletotal

(query)

 | 

Optional: disable total calculation to improve performance (default is false)

 |

| Code | Description | Links |
| --- | --- | --- |
| 200 | 
OK

Media type

Controls `Accept` header.

```
{
  "data": [
    {
      "id": "string",
      "createdDT": "2026-01-29T03:23:18.113Z",
      "modifiedDT": "2026-01-29T03:23:18.113Z",
      "cutDT": "2026-01-29T03:23:18.113Z",
      "projectId": "string",
      "projectName": "string",
      "projectNumber": "string",
      "modelId": "string",
      "modelName": "string",
      "bimAreaId": "string",
      "bimArea": "string",
      "cadId": "string",
      "cadType": "string",
      "webId": "string",
      "description": "string",
      "currentTrackingStatusId": "string",
      "currentDivisionId": "string",
      "properties": {
        "additionalProp1": "string",
        "additionalProp2": "string",
        "additionalProp3": "string"
      },
      "propertiesGtp": {
        "additionalProp1": "string",
        "additionalProp2": "string",
        "additionalProp3": "string"
      },
      "points": [
        {
          "pointType": "0 = Unspecified",
          "cadId": "string",
          "location": {
            "x": 0,
            "y": 0,
            "z": 0
          },
          "direction": {
            "x": 0,
            "y": 0,
            "z": 0
          },
          "upVector": {
            "x": 0,
            "y": 0,
            "z": 0
          },
          "width": 0,
          "height": 0,
          "matingElementUniqueId": "string"
        }
      ],
      "cutLengthAdjustment": 0,
      "cutLength2Adjustment": 0,
      "lockLength": true,
      "lockLocation": true,
      "qrCodeUrl": "string",
      "partUrl": "string",
      "patternNumber": "string",
      "source": "0 = PublishedModel",
      "fieldIdToValueMap": {
        "additionalProp1": "string",
        "additionalProp2": "string",
        "additionalProp3": "string"
      },
      "fieldNameToValueMap": {
        "additionalProp1": "string",
        "additionalProp2": "string",
        "additionalProp3": "string"
      }
    }
  ],
  "pageOffset": 0,
  "pageLimit": 0,
  "pageCount": 0,
  "total": 0,
  "truncatedResults": true,
  "truncatedReason": "string",
  "filterOptions": [
    {
      "isValueConcatenated": true,
      "data": "string",
      "options": [
        "string"
      ]
    }
  ],
  "links": {
    "additionalProp1": "string",
    "additionalProp2": "string",
    "additionalProp3": "string"
  }
}
```





 | _No links_ |
| 400 | 

Bad Request



 | _No links_ |
| 401 | 

Unauthorized



 | _No links_ |
| 404 | 

Not Found



 | _No links_ |
| 500 | 

Internal Server Error



 | _No links_ |

| Name | Description |
| --- | --- |
| 
id \*

string

(path)

 | 

STRATUS Model Id

 |
| 

reportid \*

string

(path)

 | 

STRATUS Company Report Id

 |
| 

viewId

string

(query)

 | 

(optional) STRATUS View Id for a View in the STRATUS Model

 |

| Code | Description | Links |
| --- | --- | --- |
| 200 | 
OK

Media type

Controls `Accept` header.

```
"string"
```





 | _No links_ |
| 400 | 

Bad Request



 | _No links_ |
| 401 | 

Unauthorized



 | _No links_ |
| 404 | 

Not Found



 | _No links_ |
| 429 | 

Too Many Requests



 | _No links_ |
| 500 | 

Internal Server Error



 | _No links_ |

| Name | Description |
| --- | --- |
| 
id \*

string

(path)

 | 

STRATUS Model Id

 |
| 

include

(query)

 | 

A comma delimited list of JSON properties to return. All remaining JSON properties will removed from the JSON response. Example: id, description, cutListItems. Specific dictionary keys can be included as follows: properties\["Family"\], propertiesGtp\["Material"\]

 |
| 

where

(query)

 | 

Filter on JSON property values. Example: To filter on two JSON properties: length eq '10' AND description == "truck". To get the last 30 days of data, use: createdDT ge DateTime.Now.AddDays(-30)

 |
| 

page

(query)

 | 

Offset retrieves a given page of data, where 0 is the 1st page, etc (number of elements per page is set by PageSize below)

 |
| 

pagesize

(query)

 | 

Optional: defines the number of elements per page (default (and max) is 1000)

 |
| 

disabletotal

(query)

 | 

Optional: disable total calculation to improve performance (default is false)

 |

| Code | Description | Links |
| --- | --- | --- |
| 200 | 
OK

Media type

Controls `Accept` header.

```
{
  "data": [
    {
      "id": "string",
      "createdDT": "2026-01-29T03:23:18.222Z",
      "currentDivisionId": "string",
      "modifiedDT": "2026-01-29T03:23:18.222Z",
      "modelId": "string",
      "referenceType": "0 = Unspecified",
      "referenceName": "string",
      "referenceId": "string",
      "currentTrackingStatusId": "string",
      "totalHours": 0,
      "trackingLogEntries": [
        {
          "trackingStatusId": "string",
          "createdById": "string",
          "createdDT": "2026-01-29T03:23:18.222Z",
          "divisionId": "string",
          "id": "string",
          "origin": "0 = Unknown",
          "comment": "string",
          "hours": 0,
          "costTypeId": "string",
          "hoursCost": 0
        }
      ]
    }
  ],
  "pageOffset": 0,
  "pageLimit": 0,
  "pageCount": 0,
  "total": 0,
  "truncatedResults": true,
  "truncatedReason": "string",
  "filterOptions": [
    {
      "isValueConcatenated": true,
      "data": "string",
      "options": [
        "string"
      ]
    }
  ],
  "links": {
    "additionalProp1": "string",
    "additionalProp2": "string",
    "additionalProp3": "string"
  }
}
```





 | _No links_ |
| 400 | 

Bad Request



 | _No links_ |
| 401 | 

Unauthorized



 | _No links_ |
| 404 | 

Not Found



 | _No links_ |
| 500 | 

Internal Server Error



 | _No links_ |

| Name | Description |
| --- | --- |
| 
id \*

string

(path)

 | 

STRATUS Model Id

 |
| 

refid \*

string

(path)

 | 

This is a generic Reference Id, that is, it is an id that may map to any one of the following: Part.CadId, Assembly.Id, Model.Id, Order.Id, Project.Id, Container.Id.

 |
| 

include

(query)

 | 

A comma delimited list of JSON properties to return. All remaining JSON properties will removed from the JSON response. Example: id, description, cutListItems. Specific dictionary keys can be included as follows: properties\["Family"\], propertiesGtp\["Material"\]

 |
| 

where

(query)

 | 

Filter on JSON property values. Example: To filter on two JSON properties: length eq '10' AND description == "truck". To get the last 30 days of data, use: createdDT ge DateTime.Now.AddDays(-30)

 |
| 

page

(query)

 | 

Offset retrieves a given page of data, where 0 is the 1st page, etc (number of elements per page is set by PageSize below)

 |
| 

pagesize

(query)

 | 

Optional: defines the number of elements per page (default (and max) is 1000)

 |
| 

disabletotal

(query)

 | 

Optional: disable total calculation to improve performance (default is false)

 |

| Code | Description | Links |
| --- | --- | --- |
| 200 | 
OK

Media type

Controls `Accept` header.

```
{
  "data": [
    {
      "id": "string",
      "createdDT": "2026-01-29T03:23:18.296Z",
      "currentDivisionId": "string",
      "modifiedDT": "2026-01-29T03:23:18.296Z",
      "modelId": "string",
      "referenceType": "0 = Unspecified",
      "referenceName": "string",
      "referenceId": "string",
      "currentTrackingStatusId": "string",
      "totalHours": 0,
      "trackingLogEntries": [
        {
          "trackingStatusId": "string",
          "createdById": "string",
          "createdDT": "2026-01-29T03:23:18.296Z",
          "divisionId": "string",
          "id": "string",
          "origin": "0 = Unknown",
          "comment": "string",
          "hours": 0,
          "costTypeId": "string",
          "hoursCost": 0
        }
      ]
    }
  ],
  "pageOffset": 0,
  "pageLimit": 0,
  "pageCount": 0,
  "total": 0,
  "truncatedResults": true,
  "truncatedReason": "string",
  "filterOptions": [
    {
      "isValueConcatenated": true,
      "data": "string",
      "options": [
        "string"
      ]
    }
  ],
  "links": {
    "additionalProp1": "string",
    "additionalProp2": "string",
    "additionalProp3": "string"
  }
}
```





 | _No links_ |
| 400 | 

Bad Request



 | _No links_ |
| 401 | 

Unauthorized



 | _No links_ |
| 404 | 

Not Found



 | _No links_ |
| 500 | 

Internal Server Error



 | _No links_ |

| Name | Description |
| --- | --- |
| 
id \*

string

(path)

 | 

STRATUS Model Id

 |

| Code | Description | Links |
| --- | --- | --- |
| 200 | 
OK

Media type

Controls `Accept` header.

```
[
  {
    "id": "string",
    "name": "string",
    "viewRole": "string",
    "autodeskViewId": "string"
  }
]
```





 | _No links_ |
| 400 | 

Bad Request



 | _No links_ |
| 401 | 

Unauthorized



 | _No links_ |
| 404 | 

Not Found



 | _No links_ |
| 500 | 

Internal Server Error



 | _No links_ |

| Name | Description |
| --- | --- |
| 
id \*

string

(path)

 | 

STRATUS Model Id

 |
| 

cadids \*

string

(header)

 | 

Comma separated list of CadIds (pass them in the header)

 |
| 

include

(query)

 | 

A comma delimited list of JSON properties to return. All remaining JSON properties will removed from the JSON response. Example: id, description, cutListItems. Specific dictionary keys can be included as follows: properties\["Family"\], propertiesGtp\["Material"\]

 |
| 

where

(query)

 | 

Filter on JSON property values. Example: To filter on two JSON properties: length eq '10' AND description == "truck". To get the last 30 days of data, use: createdDT ge DateTime.Now.AddDays(-30)

 |
| 

page

(query)

 | 

Offset retrieves a given page of data, where 0 is the 1st page, etc (number of elements per page is set by PageSize below)

 |
| 

pagesize

(query)

 | 

Optional: defines the number of elements per page (default (and max) is 1000)

 |
| 

disabletotal

(query)

 | 

Optional: disable total calculation to improve performance (default is false)

 |

| Code | Description | Links |
| --- | --- | --- |
| 200 | 
OK

Media type

Controls `Accept` header.

```
{
  "data": [
    {
      "id": "string",
      "createdDT": "2026-01-29T03:23:18.406Z",
      "currentDivisionId": "string",
      "modifiedDT": "2026-01-29T03:23:18.406Z",
      "modelId": "string",
      "referenceType": "0 = Unspecified",
      "referenceName": "string",
      "referenceId": "string",
      "currentTrackingStatusId": "string",
      "totalHours": 0,
      "trackingLogEntries": [
        {
          "trackingStatusId": "string",
          "createdById": "string",
          "createdDT": "2026-01-29T03:23:18.406Z",
          "divisionId": "string",
          "id": "string",
          "origin": "0 = Unknown",
          "comment": "string",
          "hours": 0,
          "costTypeId": "string",
          "hoursCost": 0
        }
      ]
    }
  ],
  "pageOffset": 0,
  "pageLimit": 0,
  "pageCount": 0,
  "total": 0,
  "truncatedResults": true,
  "truncatedReason": "string",
  "filterOptions": [
    {
      "isValueConcatenated": true,
      "data": "string",
      "options": [
        "string"
      ]
    }
  ],
  "links": {
    "additionalProp1": "string",
    "additionalProp2": "string",
    "additionalProp3": "string"
  }
}
```





 | _No links_ |
| 400 | 

Bad Request



 | _No links_ |
| 401 | 

Unauthorized



 | _No links_ |
| 404 | 

Not Found



 | _No links_ |
| 500 | 

Internal Server Error



 | _No links_ |

| Name | Description |
| --- | --- |
| 
id \*

string

(path)

 | 

Stratus Model Id

 |

REQUIRED: Name, NOTE: if Name contains "Incrementor XX", it will be replaced with an auto-incremented value, supporting as many XXXXX digits as specified, but must match company assembly naming convention. OPTIONAL: CadId, will be assigned by Stratus if not provided. Id will be assigned by Stratus. OPTIONAL: InitialTrackingStatusId and CreatedByUserEmail, if provided, these will be used in the construction of the new assembly.

```
{
  "cadId": "string",
  "createdByUserEmail": "string",
  "id": "string",
  "initialTrackingStatusId": "string",
  "name": "string"
}
```

| Code | Description | Links |
| --- | --- | --- |
| 201 | 
Created

Media type

Controls `Accept` header.

```
{
  "cadId": "string",
  "createdByUserEmail": "string",
  "id": "string",
  "initialTrackingStatusId": "string",
  "name": "string"
}
```





 | _No links_ |
| 400 | 

Bad Request



 | _No links_ |
| 401 | 

Unauthorized



 | _No links_ |
| 404 | 

Not Found



 | _No links_ |
| 500 | 

Internal Server Error



 | _No links_ |

| Name | Description |
| --- | --- |
| 
id \*

string

(path)

 | 

STRATUS Model Id

 |
| 

cadid \*

string

(path)

 | 

STRATUS Assembly CadId

 |

REQUIRED: TrackingStatusId

```
{
  "comment": "string",
  "costTypeId": "string",
  "createdDT": "2026-01-29T03:23:18.522Z",
  "divisionId": "string",
  "hours": 0,
  "trackingLogEntryIdResult": "string",
  "trackingStatusId": "string"
}
```

| Code | Description | Links |
| --- | --- | --- |
| 200 | 
OK

Media type

Controls `Accept` header.

```
{
  "comment": "string",
  "costTypeId": "string",
  "createdDT": "2026-01-29T03:23:18.532Z",
  "divisionId": "string",
  "hours": 0,
  "trackingLogEntryIdResult": "string",
  "trackingStatusId": "string"
}
```





 | _No links_ |
| 400 | 

Bad Request



 | _No links_ |
| 401 | 

Unauthorized



 | _No links_ |
| 404 | 

Not Found



 | _No links_ |
| 500 | 

Internal Server Error



 | _No links_ |

| Name | Description |
| --- | --- |
| 
id \*

string

(path)

 | 

Stratus Model Id

 |

REQUIRED: CategoryId and Name. OPTIONAL: InitialTrackingStatusId and CreatedByUserEmail, if provided, these will be used in the construction of the new package.

```
{
  "areaId": "string",
  "categoryId": "string",
  "createdByUserEmail": "string",
  "description": "string",
  "initialTrackingStatusId": "string",
  "name": "string",
  "number": "string",
  "orderNameFOZ": "string"
}
```

| Code | Description | Links |
| --- | --- | --- |
| 201 | 
Created

Media type

Controls `Accept` header.

```
"string"
```





 | _No links_ |
| 400 | 

Bad Request



 | _No links_ |
| 401 | 

Unauthorized



 | _No links_ |
| 404 | 

Not Found



 | _No links_ |
| 500 | 

Internal Server Error



 | _No links_ |

| Name | Description |
| --- | --- |
| 
id \*

string

(path)

 | 

STRATUS Model Id

 |
| 

cadid \*

string

(path)

 | 

STRATUS Part CadId

 |

REQUIRED: TrackingStatusId

```
{
  "comment": "string",
  "costTypeId": "string",
  "createdDT": "2026-01-29T03:23:18.638Z",
  "divisionId": "string",
  "hours": 0,
  "trackingLogEntryIdResult": "string",
  "trackingStatusId": "string"
}
```

| Code | Description | Links |
| --- | --- | --- |
| 200 | 
OK

Media type

Controls `Accept` header.

```
{
  "comment": "string",
  "costTypeId": "string",
  "createdDT": "2026-01-29T03:23:18.644Z",
  "divisionId": "string",
  "hours": 0,
  "trackingLogEntryIdResult": "string",
  "trackingStatusId": "string"
}
```





 | _No links_ |
| 400 | 

Bad Request



 | _No links_ |
| 401 | 

Unauthorized



 | _No links_ |
| 404 | 

Not Found



 | _No links_ |
| 500 | 

Internal Server Error



 | _No links_ |

| Name | Description |
| --- | --- |
| 
id \*

string

(path)

 | 

STRATUS Model Id

 |
| 

cadid \*

string

(path)

 | 

STRATUS Part CadId

 |

Example JSON KeyValuePair: {"key":"propertyKey","value":"propertyValue"}

```
{
  "key": "string",
  "value": "string"
}
```

| Code | Description | Links |
| --- | --- | --- |
| 200 | 
OK

Media type

Controls `Accept` header.

```
{
  "key": "string",
  "value": "string"
}
```





 | _No links_ |
| 400 | 

Bad Request



 | _No links_ |
| 401 | 

Unauthorized



 | _No links_ |
| 404 | 

Not Found



 | _No links_ |
| 500 | 

Internal Server Error



 | _No links_ |

### NonStratusUser

| Name | Description |
| --- | --- |
| 
where

(query)

 | 

Filter on JSON property values. Example: To filter on two JSON properties: length eq '10' AND description == "truck". To get the last 30 days of data, use: createdDT ge DateTime.Now.AddDays(-30)

 |

| Code | Description | Links |
| --- | --- | --- |
| 200 | 
OK

Media type

Controls `Accept` header.

```
[
  {
    "createdById": "string",
    "createdDT": "2026-01-29T03:23:18.736Z",
    "divisionId": "string",
    "employeeId": "string",
    "firstName": "string",
    "id": "string",
    "isCheckedIn": true,
    "isTimeTrackingEnabled": true,
    "lastName": "string",
    "modifiedById": "string",
    "modifiedDT": "2026-01-29T03:23:18.736Z",
    "status": "1 = Active"
  }
]
```





 | _No links_ |
| 400 | 

Bad Request



 | _No links_ |
| 401 | 

Unauthorized



 | _No links_ |
| 404 | 

Not Found



 | _No links_ |
| 500 | 

Internal Server Error



 | _No links_ |

| Name | Description |
| --- | --- |
| 
id \*

string

(path)

 | 

NonStratusUser Id

 |

| Code | Description | Links |
| --- | --- | --- |
| 200 | 
OK

Media type

Controls `Accept` header.

```
{
  "createdById": "string",
  "createdDT": "2026-01-29T03:23:18.769Z",
  "divisionId": "string",
  "employeeId": "string",
  "firstName": "string",
  "id": "string",
  "isCheckedIn": true,
  "isTimeTrackingEnabled": true,
  "lastName": "string",
  "modifiedById": "string",
  "modifiedDT": "2026-01-29T03:23:18.769Z",
  "status": "1 = Active"
}
```





 | _No links_ |
| 400 | 

Bad Request



 | _No links_ |
| 401 | 

Unauthorized



 | _No links_ |
| 404 | 

Not Found



 | _No links_ |
| 500 | 

Internal Server Error



 | _No links_ |

REQUIRED: NonStratusUser data - minimum json includes FirstName and LastName, Id will be assigned by server.

```
{
  "createdById": "string",
  "createdDT": "2026-01-29T03:23:18.808Z",
  "divisionId": "string",
  "employeeId": "string",
  "firstName": "string",
  "id": "string",
  "isCheckedIn": true,
  "isTimeTrackingEnabled": true,
  "lastName": "string",
  "modifiedById": "string",
  "modifiedDT": "2026-01-29T03:23:18.808Z",
  "status": "1 = Active"
}
```

| Code | Description | Links |
| --- | --- | --- |
| 201 | 
Created

Media type

Controls `Accept` header.

```
{
  "createdById": "string",
  "createdDT": "2026-01-29T03:23:18.817Z",
  "divisionId": "string",
  "employeeId": "string",
  "firstName": "string",
  "id": "string",
  "isCheckedIn": true,
  "isTimeTrackingEnabled": true,
  "lastName": "string",
  "modifiedById": "string",
  "modifiedDT": "2026-01-29T03:23:18.817Z",
  "status": "1 = Active"
}
```





 | _No links_ |
| 400 | 

Bad Request



 | _No links_ |
| 401 | 

Unauthorized



 | _No links_ |
| 404 | 

Not Found



 | _No links_ |
| 500 | 

Internal Server Error



 | _No links_ |

| Name | Description |
| --- | --- |
| 
id \*

string

(path)

 |  |

```
{
  "createdById": "string",
  "createdDT": "2026-01-29T03:23:18.864Z",
  "divisionId": "string",
  "employeeId": "string",
  "firstName": "string",
  "id": "string",
  "isCheckedIn": true,
  "isTimeTrackingEnabled": true,
  "lastName": "string",
  "modifiedById": "string",
  "modifiedDT": "2026-01-29T03:23:18.864Z",
  "status": "1 = Active"
}
```

| Code | Description | Links |
| --- | --- | --- |
| 202 | 
Accepted

Media type

Controls `Accept` header.

```
{
  "createdById": "string",
  "createdDT": "2026-01-29T03:23:18.871Z",
  "divisionId": "string",
  "employeeId": "string",
  "firstName": "string",
  "id": "string",
  "isCheckedIn": true,
  "isTimeTrackingEnabled": true,
  "lastName": "string",
  "modifiedById": "string",
  "modifiedDT": "2026-01-29T03:23:18.871Z",
  "status": "1 = Active"
}
```





 | _No links_ |
| 400 | 

Bad Request



 | _No links_ |
| 401 | 

Unauthorized



 | _No links_ |
| 404 | 

Not Found



 | _No links_ |
| 500 | 

Internal Server Error



 | _No links_ |

### Package

| Name | Description |
| --- | --- |
| 
include

(query)

 | 

A comma delimited list of JSON properties to return. All remaining JSON properties will removed from the JSON response. Example: id, description, cutListItems. Specific dictionary keys can be included as follows: properties\["Family"\], propertiesGtp\["Material"\]

 |
| 

where

(query)

 | 

Filter on JSON property values. Example: To filter on two JSON properties: length eq '10' AND description == "truck". To get the last 30 days of data, use: createdDT ge DateTime.Now.AddDays(-30)

 |
| 

page

(query)

 | 

Offset retrieves a given page of data, where 0 is the 1st page, etc (number of elements per page is set by PageSize below)

 |
| 

pagesize

(query)

 | 

Optional: defines the number of elements per page (default (and max) is 200)

 |
| 

disabletotal

(query)

 | 

Optional: disable total calculation to improve performance (default is false)

 |

| Code | Description | Links |
| --- | --- | --- |
| 200 | 
OK

Media type

Controls `Accept` header.

```
{
  "data": [
    {
      "assemblyIds": [
        "string"
      ],
      "bimAreaId": "string",
      "bimAreaName": "string",
      "cadIdsBySequence": [
        "string"
      ],
      "categoryId": "string",
      "createdBy": "string",
      "createdDT": "2026-01-29T03:23:18.927Z",
      "currentTrackingStatusId": "string",
      "currentDivisionId": "string",
      "description": "string",
      "fieldIdToValueMap": {
        "additionalProp1": "string",
        "additionalProp2": "string",
        "additionalProp3": "string"
      },
      "fieldNameToValueMap": {
        "additionalProp1": "string",
        "additionalProp2": "string",
        "additionalProp3": "string"
      },
      "hoursEstimatedField": 0,
      "hoursEstimatedOffice": 0,
      "hoursEstimatedPurchasing": 0,
      "hoursEstimatedShop": 0,
      "id": "string",
      "installedDT": "2026-01-29T03:23:18.927Z",
      "modelId": "string",
      "modifiedBy": "string",
      "modifiedDT": "2026-01-29T03:23:18.927Z",
      "name": "string",
      "number": "string",
      "officeDuration": 0,
      "officeStartDT": "2026-01-29T03:23:18.927Z",
      "partCadIds": [
        "string"
      ],
      "projectId": "string",
      "purchasingDuration": 0,
      "purchasingStartDT": "2026-01-29T03:23:18.927Z",
      "qrCodeUrl": "string",
      "requiredDT": "2026-01-29T03:23:18.927Z",
      "selectedTaskWorkflowIdsForAssemblyAndPartCadIds": {
        "additionalProp1": "string",
        "additionalProp2": "string",
        "additionalProp3": "string"
      },
      "shopDuration": 0,
      "startDT": "2026-01-29T03:23:18.927Z",
      "status": "0 = Active",
      "statusName": "string",
      "viewId": "string",
      "isViewIdOverridden": true
    }
  ],
  "pageOffset": 0,
  "pageLimit": 0,
  "pageCount": 0,
  "total": 0,
  "truncatedResults": true,
  "truncatedReason": "string",
  "filterOptions": [
    {
      "isValueConcatenated": true,
      "data": "string",
      "options": [
        "string"
      ]
    }
  ],
  "links": {
    "additionalProp1": "string",
    "additionalProp2": "string",
    "additionalProp3": "string"
  }
}
```





 | _No links_ |
| 400 | 

Bad Request



 | _No links_ |
| 401 | 

Unauthorized



 | _No links_ |
| 404 | 

Not Found



 | _No links_ |
| 500 | 

Internal Server Error



 | _No links_ |

| Name | Description |
| --- | --- |
| 
id \*

string

(path)

 | 

STRATUS Package Id

 |
| 

include

(query)

 | 

A comma delimited list of JSON properties to return. All remaining JSON properties will removed from the JSON response. Example: id, description, cutListItems. Specific dictionary keys can be included as follows: properties\["Family"\], propertiesGtp\["Material"\]

 |

| Code | Description | Links |
| --- | --- | --- |
| 200 | 
OK

Media type

Controls `Accept` header.

```
{
  "assemblyIds": [
    "string"
  ],
  "bimAreaId": "string",
  "bimAreaName": "string",
  "cadIdsBySequence": [
    "string"
  ],
  "categoryId": "string",
  "createdBy": "string",
  "createdDT": "2026-01-29T03:23:18.971Z",
  "currentTrackingStatusId": "string",
  "currentDivisionId": "string",
  "description": "string",
  "fieldIdToValueMap": {
    "additionalProp1": "string",
    "additionalProp2": "string",
    "additionalProp3": "string"
  },
  "fieldNameToValueMap": {
    "additionalProp1": "string",
    "additionalProp2": "string",
    "additionalProp3": "string"
  },
  "hoursEstimatedField": 0,
  "hoursEstimatedOffice": 0,
  "hoursEstimatedPurchasing": 0,
  "hoursEstimatedShop": 0,
  "id": "string",
  "installedDT": "2026-01-29T03:23:18.971Z",
  "modelId": "string",
  "modifiedBy": "string",
  "modifiedDT": "2026-01-29T03:23:18.971Z",
  "name": "string",
  "number": "string",
  "officeDuration": 0,
  "officeStartDT": "2026-01-29T03:23:18.971Z",
  "partCadIds": [
    "string"
  ],
  "projectId": "string",
  "purchasingDuration": 0,
  "purchasingStartDT": "2026-01-29T03:23:18.971Z",
  "qrCodeUrl": "string",
  "requiredDT": "2026-01-29T03:23:18.971Z",
  "selectedTaskWorkflowIdsForAssemblyAndPartCadIds": {
    "additionalProp1": "string",
    "additionalProp2": "string",
    "additionalProp3": "string"
  },
  "shopDuration": 0,
  "startDT": "2026-01-29T03:23:18.971Z",
  "status": "0 = Active",
  "statusName": "string",
  "viewId": "string",
  "isViewIdOverridden": true
}
```





 | _No links_ |
| 400 | 

Bad Request



 | _No links_ |
| 401 | 

Unauthorized



 | _No links_ |
| 404 | 

Not Found



 | _No links_ |
| 500 | 

Internal Server Error



 | _No links_ |

| Name | Description |
| --- | --- |
| 
id \*

string

(path)

 | 

STRATUS Package Id

 |
| 

include

(query)

 | 

A comma delimited list of JSON properties to return. All remaining JSON properties will removed from the JSON response. Example: id, description, cutListItems. Specific dictionary keys can be included as follows: properties\["Family"\], propertiesGtp\["Material"\]

 |

| Code | Description | Links |
| --- | --- | --- |
| 200 | 
OK

Media type

Controls `Accept` header.

```
[
  {
    "id": "string",
    "projectId": "string",
    "modelId": "string",
    "stratusDimensionType": "0 = AliasTag",
    "orderId": "string",
    "assemblyId": "string",
    "partCadIds": [
      "string"
    ],
    "colorIndex": 0,
    "dimensionLineType": "0 = LabelOnly",
    "connectedAssemblyId": "string",
    "distance": 0,
    "label": "string",
    "lineVertices": [
      {
        "x": 0,
        "y": 0,
        "z": 0
      }
    ],
    "location": {
      "x": 0,
      "y": 0,
      "z": 0
    },
    "gridlineAnnotation": "string",
    "dimensionAnchorTypes": [
      {
        "location": {
          "x": 0,
          "y": 0,
          "z": 0
        },
        "partPointType": "0 = Unspecified"
      }
    ]
  }
]
```





 | _No links_ |
| 400 | 

Bad Request



 | _No links_ |
| 401 | 

Unauthorized



 | _No links_ |
| 404 | 

Not Found



 | _No links_ |
| 500 | 

Internal Server Error



 | _No links_ |

| Name | Description |
| --- | --- |
| 
id \*

string

(path)

 | 

STRATUS Package Id

 |
| 

include

(query)

 | 

A comma delimited list of JSON properties to return. All remaining JSON properties will removed from the JSON response. Example: id, description, cutListItems. Specific dictionary keys can be included as follows: properties\["Family"\], propertiesGtp\["Material"\]

 |
| 

where

(query)

 | 

Filter on JSON property values. Example: To filter on two JSON properties: length eq '10' AND description == "truck". To get the last 30 days of data, use: createdDT ge DateTime.Now.AddDays(-30)

 |
| 

page

(query)

 | 

Offset retrieves a given page of data, where 0 is the 1st page, etc (number of elements per page is set by PageSize below)

 |
| 

pagesize

(query)

 | 

Optional: defines the number of elements per page (default (and max) is 1000)

 |
| 

disabletotal

(query)

 | 

Optional: disable total calculation to improve performance (default is false)

 |

| Code | Description | Links |
| --- | --- | --- |
| 200 | 
OK

Media type

Controls `Accept` header.

```
{
  "data": [
    {
      "id": "string",
      "createdById": "string",
      "createdDT": "2026-01-29T03:23:19.074Z",
      "projectId": "string",
      "modelId": "string",
      "referenceType": "0 = Unspecified",
      "referenceName": "string",
      "referenceId": "string",
      "role": "0 = Unspecified",
      "roleName": "string",
      "fileType": "0 = Unspecified",
      "fileTypeName": "string",
      "localFilePath": "string",
      "fileName": "string",
      "overriddenRemoteFolder": "string"
    }
  ],
  "pageOffset": 0,
  "pageLimit": 0,
  "pageCount": 0,
  "total": 0,
  "truncatedResults": true,
  "truncatedReason": "string",
  "filterOptions": [
    {
      "isValueConcatenated": true,
      "data": "string",
      "options": [
        "string"
      ]
    }
  ],
  "links": {
    "additionalProp1": "string",
    "additionalProp2": "string",
    "additionalProp3": "string"
  }
}
```





 | _No links_ |
| 400 | 

Bad Request



 | _No links_ |
| 401 | 

Unauthorized



 | _No links_ |
| 404 | 

Not Found



 | _No links_ |
| 500 | 

Internal Server Error



 | _No links_ |

| Name | Description |
| --- | --- |
| 
id \*

string

(path)

 | 

STRATUS Package Id

 |
| 

include

(query)

 | 

A comma delimited list of JSON properties to return. All remaining JSON properties will removed from the JSON response. Example: id, description, cutListItems. Specific dictionary keys can be included as follows: properties\["Family"\], propertiesGtp\["Material"\]

 |

| Code | Description | Links |
| --- | --- | --- |
| 200 | 
OK

Media type

Controls `Accept` header.

```
{
  "id": "string",
  "divisionId": "string",
  "projectId": "string",
  "modelId": "string",
  "packageId": "string",
  "requiredDT": "2026-01-29T03:23:19.116Z",
  "isLocked": true,
  "generatedDT": "2026-01-29T03:23:19.116Z",
  "generatedByName": "string",
  "lockedDT": "2026-01-29T03:23:19.116Z",
  "lockedByName": "string",
  "unlockedDT": "2026-01-29T03:23:19.116Z",
  "unlockedByName": "string",
  "lineItems": [
    {
      "groupedPartCadIds": [
        "string"
      ],
      "sequence": 0,
      "isModeled": true,
      "isReportable": true,
      "isConsolidated": true,
      "manufacturer": "string",
      "quantity": 0,
      "size": "string",
      "description": "string",
      "material": "string",
      "productCode": "string",
      "diameter": "string",
      "width": "string",
      "length": "string",
      "isLengthNestable": true,
      "nominalStockLength": "string",
      "additionalProperty": "string",
      "unitOfMeasure": "0 = Bundle",
      "unitOfMeasureName": "string",
      "comment": "string",
      "notPurchased": true,
      "isAncillary": true,
      "serviceName": "string",
      "serviceCode": "string",
      "possibleSupplierCodes": {
        "additionalProp1": "string",
        "additionalProp2": "string",
        "additionalProp3": "string"
      }
    }
  ]
}
```





 | _No links_ |
| 400 | 

Bad Request



 | _No links_ |
| 401 | 

Unauthorized



 | _No links_ |
| 404 | 

Not Found



 | _No links_ |
| 500 | 

Internal Server Error



 | _No links_ |

| Name | Description |
| --- | --- |
| 
id \*

string

(path)

 | 

STRATUS Package Id

 |
| 

reportid \*

string

(path)

 | 

STRATUS Company Report Id

 |

| Code | Description | Links |
| --- | --- | --- |
| 200 | 
OK

Media type

Controls `Accept` header.

```
"string"
```





 | _No links_ |
| 400 | 

Bad Request



 | _No links_ |
| 401 | 

Unauthorized



 | _No links_ |
| 404 | 

Not Found



 | _No links_ |
| 429 | 

Too Many Requests



 | _No links_ |
| 500 | 

Internal Server Error



 | _No links_ |

| Name | Description |
| --- | --- |
| 
packageId

string

(query)

 | 

Package Id. Empty=all (def).

_Default value_ :

 |
| 

projectId

string

(query)

 | 

Project Id. Empty=all (def).

 |
| 

modelId

string

(query)

 | 

Model Id. Empty=all (def).

 |
| 

reportId

string

(query)

 | 

Id of report to run. Empty=dashboard.

 |
| 

businessUnits

string

(query)

 | 

Project Business Units. Empty=all (def). Semicolon separated list of values as filter.

 |
| 

divisions

string

(query)

 | 

Division Names or Ids. Empty=all (def). Semicolon separated list of values as filter.

 |
| 

packageCategories

string

(query)

 | 

Package Category Names or Ids. Empty=all (def). Semicolon separated list of values as filter.

 |
| 

active

boolean

(query)

 | 

Active packages. true is def.

_Default value_ : true

 |
| 

archived

boolean

(query)

 | 

Archived packages. false is def.

_Default value_ : false

 |

| Code | Description | Links |
| --- | --- | --- |
| 200 | 
OK

Media type

Controls `Accept` header.

```
string
```





 | _No links_ |
| 400 | 

Bad Request



 | _No links_ |
| 401 | 

Unauthorized



 | _No links_ |
| 404 | 

Not Found



 | _No links_ |
| 429 | 

Too Many Requests



 | _No links_ |
| 500 | 

Internal Server Error



 | _No links_ |

| Name | Description |
| --- | --- |
| 
id \*

string

(path)

 | 

STRATUS Package Id

 |
| 

include

(query)

 | 

A comma delimited list of JSON properties to return. All remaining JSON properties will removed from the JSON response. Example: id, description, cutListItems. Specific dictionary keys can be included as follows: properties\["Family"\], propertiesGtp\["Material"\]

 |
| 

where

(query)

 | 

Filter on JSON property values. Example: To filter on two JSON properties: length eq '10' AND description == "truck". To get the last 30 days of data, use: createdDT ge DateTime.Now.AddDays(-30)

 |
| 

page

(query)

 | 

Offset retrieves a given page of data, where 0 is the 1st page, etc (number of elements per page is set by PageSize below)

 |
| 

pagesize

(query)

 | 

Optional: defines the number of elements per page (default (and max) is 1000)

 |
| 

disabletotal

(query)

 | 

Optional: disable total calculation to improve performance (default is false)

 |

| Code | Description | Links |
| --- | --- | --- |
| 200 | 
OK

Media type

Controls `Accept` header.

```
{
  "data": [
    {
      "id": "string",
      "createdDT": "2026-01-29T03:23:19.321Z",
      "modifiedDT": "2026-01-29T03:23:19.321Z",
      "projectId": "string",
      "modelId": "string",
      "cadId": "string",
      "sheetId": "string",
      "viewId": "string",
      "isViewIdOverridden": true,
      "currentTrackingStatusId": "string",
      "currentDivisionId": "string",
      "assemblyType": "0 = Unspecified",
      "assemblyTypeLabel": "string",
      "excludedCadIds": [
        "string"
      ],
      "fieldIdToValueMap": {
        "additionalProp1": "string",
        "additionalProp2": "string",
        "additionalProp3": "string"
      },
      "fieldNameToValueMap": {
        "additionalProp1": "string",
        "additionalProp2": "string",
        "additionalProp3": "string"
      },
      "name": "string",
      "nameLabel": "string",
      "partIds": [
        "string"
      ],
      "instanceIndex": "string",
      "lastUsedAssembliesPartsTableReportIds": [
        "string"
      ],
      "qrCodeUrl": "string",
      "notes": [
        {
          "isPartialData": true,
          "isReadOnly": true,
          "id": "string",
          "createdDT": "2026-01-29T03:23:19.321Z",
          "createdById": "string",
          "modifiedDT": "2026-01-29T03:23:19.321Z",
          "modifiedById": "string",
          "name": "string"
        }
      ],
      "defaultOrientationForReportTemplatesForgeViewerViewJson": {
        "additionalProp1": "string",
        "additionalProp2": "string",
        "additionalProp3": "string"
      }
    }
  ],
  "pageOffset": 0,
  "pageLimit": 0,
  "pageCount": 0,
  "total": 0,
  "truncatedResults": true,
  "truncatedReason": "string",
  "filterOptions": [
    {
      "isValueConcatenated": true,
      "data": "string",
      "options": [
        "string"
      ]
    }
  ],
  "links": {
    "additionalProp1": "string",
    "additionalProp2": "string",
    "additionalProp3": "string"
  }
}
```





 | _No links_ |
| 400 | 

Bad Request



 | _No links_ |
| 401 | 

Unauthorized



 | _No links_ |
| 404 | 

Not Found



 | _No links_ |
| 500 | 

Internal Server Error



 | _No links_ |

| Name | Description |
| --- | --- |
| 
id \*

string

(path)

 | 

STRATUS Package Id

 |
| 

includeAssemblyParts

boolean

(query)

 | 

OPTIONAL

_Default value_ : false

 |
| 

includeStratusProperties

boolean

(query)

 | 

Pass true to this optional query parameter if you want to generate STRATUS.Part.\* properties and have them returned for the parts.

_Default value_ : false

 |
| 

excludeNullAndEmpty

boolean

(query)

 | 

Pass true to this optional query parameter if you want empty or null values removed from the part's Properties and PropertiesGtp collections to improve performance.

_Default value_ : false

 |
| 

include

(query)

 | 

A comma delimited list of JSON properties to return. All remaining JSON properties will removed from the JSON response. Example: id, description, cutListItems. Specific dictionary keys can be included as follows: properties\["Family"\], propertiesGtp\["Material"\]

 |
| 

where

(query)

 | 

Filter on JSON property values. Example: To filter on two JSON properties: length eq '10' AND description == "truck". To get the last 30 days of data, use: createdDT ge DateTime.Now.AddDays(-30)

 |
| 

page

(query)

 | 

Offset retrieves a given page of data, where 0 is the 1st page, etc (number of elements per page is set by PageSize below)

 |
| 

pagesize

(query)

 | 

Optional: defines the number of elements per page (default (and max) is 100)

 |
| 

disabletotal

(query)

 | 

Optional: disable total calculation to improve performance (default is false)

 |

| Code | Description | Links |
| --- | --- | --- |
| 200 | 
OK

Media type

Controls `Accept` header.

```
{
  "data": [
    {
      "id": "string",
      "createdDT": "2026-01-29T03:23:19.414Z",
      "modifiedDT": "2026-01-29T03:23:19.414Z",
      "cutDT": "2026-01-29T03:23:19.414Z",
      "projectId": "string",
      "projectName": "string",
      "projectNumber": "string",
      "modelId": "string",
      "modelName": "string",
      "bimAreaId": "string",
      "bimArea": "string",
      "cadId": "string",
      "cadType": "string",
      "webId": "string",
      "description": "string",
      "currentTrackingStatusId": "string",
      "currentDivisionId": "string",
      "properties": {
        "additionalProp1": "string",
        "additionalProp2": "string",
        "additionalProp3": "string"
      },
      "propertiesGtp": {
        "additionalProp1": "string",
        "additionalProp2": "string",
        "additionalProp3": "string"
      },
      "points": [
        {
          "pointType": "0 = Unspecified",
          "cadId": "string",
          "location": {
            "x": 0,
            "y": 0,
            "z": 0
          },
          "direction": {
            "x": 0,
            "y": 0,
            "z": 0
          },
          "upVector": {
            "x": 0,
            "y": 0,
            "z": 0
          },
          "width": 0,
          "height": 0,
          "matingElementUniqueId": "string"
        }
      ],
      "cutLengthAdjustment": 0,
      "cutLength2Adjustment": 0,
      "lockLength": true,
      "lockLocation": true,
      "qrCodeUrl": "string",
      "partUrl": "string",
      "patternNumber": "string",
      "source": "0 = PublishedModel",
      "fieldIdToValueMap": {
        "additionalProp1": "string",
        "additionalProp2": "string",
        "additionalProp3": "string"
      },
      "fieldNameToValueMap": {
        "additionalProp1": "string",
        "additionalProp2": "string",
        "additionalProp3": "string"
      }
    }
  ],
  "pageOffset": 0,
  "pageLimit": 0,
  "pageCount": 0,
  "total": 0,
  "truncatedResults": true,
  "truncatedReason": "string",
  "filterOptions": [
    {
      "isValueConcatenated": true,
      "data": "string",
      "options": [
        "string"
      ]
    }
  ],
  "links": {
    "additionalProp1": "string",
    "additionalProp2": "string",
    "additionalProp3": "string"
  }
}
```





 | _No links_ |
| 400 | 

Bad Request



 | _No links_ |
| 401 | 

Unauthorized



 | _No links_ |
| 404 | 

Not Found



 | _No links_ |
| 500 | 

Internal Server Error



 | _No links_ |

| Name | Description |
| --- | --- |
| 
qrcode \*

string

(path)

 | 

The decoded text from a STRATUS QR Code -- being a URL or just the last eight characters of the URL.

 |
| 

include

(query)

 | 

A comma delimited list of JSON properties to return. All remaining JSON properties will removed from the JSON response. Example: id, description, cutListItems. Specific dictionary keys can be included as follows: properties\["Family"\], propertiesGtp\["Material"\]

 |

| Code | Description | Links |
| --- | --- | --- |
| 200 | 
OK

Media type

Controls `Accept` header.

```
{
  "assemblyIds": [
    "string"
  ],
  "bimAreaId": "string",
  "bimAreaName": "string",
  "cadIdsBySequence": [
    "string"
  ],
  "categoryId": "string",
  "createdBy": "string",
  "createdDT": "2026-01-29T03:23:19.454Z",
  "currentTrackingStatusId": "string",
  "currentDivisionId": "string",
  "description": "string",
  "fieldIdToValueMap": {
    "additionalProp1": "string",
    "additionalProp2": "string",
    "additionalProp3": "string"
  },
  "fieldNameToValueMap": {
    "additionalProp1": "string",
    "additionalProp2": "string",
    "additionalProp3": "string"
  },
  "hoursEstimatedField": 0,
  "hoursEstimatedOffice": 0,
  "hoursEstimatedPurchasing": 0,
  "hoursEstimatedShop": 0,
  "id": "string",
  "installedDT": "2026-01-29T03:23:19.454Z",
  "modelId": "string",
  "modifiedBy": "string",
  "modifiedDT": "2026-01-29T03:23:19.454Z",
  "name": "string",
  "number": "string",
  "officeDuration": 0,
  "officeStartDT": "2026-01-29T03:23:19.454Z",
  "partCadIds": [
    "string"
  ],
  "projectId": "string",
  "purchasingDuration": 0,
  "purchasingStartDT": "2026-01-29T03:23:19.454Z",
  "qrCodeUrl": "string",
  "requiredDT": "2026-01-29T03:23:19.454Z",
  "selectedTaskWorkflowIdsForAssemblyAndPartCadIds": {
    "additionalProp1": "string",
    "additionalProp2": "string",
    "additionalProp3": "string"
  },
  "shopDuration": 0,
  "startDT": "2026-01-29T03:23:19.454Z",
  "status": "0 = Active",
  "statusName": "string",
  "viewId": "string",
  "isViewIdOverridden": true
}
```





 | _No links_ |
| 400 | 

Bad Request



 | _No links_ |
| 401 | 

Unauthorized



 | _No links_ |
| 404 | 

Not Found



 | _No links_ |
| 500 | 

Internal Server Error



 | _No links_ |

| Name | Description |
| --- | --- |
| 
id \*

string

(path)

 | 

STRATUS Package Id

 |
| 

trackingLogEntryId

string

(query)

 | 

Optional TrackingLogEntry Id to associate Attachment with a TrackingLogEntry

 |

| Code | Description | Links |
| --- | --- | --- |
| 200 | 
OK

Media type

Controls `Accept` header.

```
{
  "id": "string",
  "createdById": "string",
  "createdDT": "2026-01-29T03:23:19.493Z",
  "projectId": "string",
  "modelId": "string",
  "referenceType": "0 = Unspecified",
  "referenceName": "string",
  "referenceId": "string",
  "role": "0 = Unspecified",
  "roleName": "string",
  "fileType": "0 = Unspecified",
  "fileTypeName": "string",
  "localFilePath": "string",
  "fileName": "string",
  "overriddenRemoteFolder": "string"
}
```





 | _No links_ |
| 400 | 

Bad Request



 | _No links_ |
| 401 | 

Unauthorized



 | _No links_ |
| 404 | 

Not Found



 | _No links_ |
| 500 | 

Internal Server Error



 | _No links_ |

| Name | Description |
| --- | --- |
| 
id \*

string

(path)

 | 

STRATUS Package Id

 |

REQUIRED: CutListDataApi - minimum json includes material, size, and cutListItems list with at least one entry containing lengthInInches

```
{
  "id": "string",
  "completedDT": "2026-01-29T03:23:19.534Z",
  "createdDT": "2026-01-29T03:23:19.534Z",
  "createdById": "string",
  "modifiedDT": "2026-01-29T03:23:19.534Z",
  "modifiedById": "string",
  "cutListItems": [
    {
      "area": "string",
      "assemblyId": "string",
      "assemblyName": "string",
      "index": 0,
      "cadId": "string",
      "cutDateTime": "2026-01-29T03:23:19.534Z",
      "description": "string",
      "itemNumber": "string",
      "lengthInInches": 0,
      "lengthInFeetAndInches": "string",
      "level": "string",
      "preFabId": "string",
      "qrCode": "string",
      "userData1": "string",
      "userData2": "string",
      "userData3": "string",
      "userData4": "string",
      "userData5": "string",
      "userData6": "string",
      "userData7": "string",
      "userData8": "string",
      "userData9": "string",
      "userData10": "string",
      "userData11": "string",
      "userData12": "string",
      "userData13": "string",
      "userData14": "string",
      "userData15": "string"
    }
  ],
  "cutListItemCount": 0,
  "cutListStatus": "0 = New",
  "cutListStatusLabel": "string",
  "cutListStatusName": "string",
  "isAutoGeneratedCutList": true,
  "material": "string",
  "modelId": "string",
  "name": "string",
  "packageId": "string",
  "projectId": "string",
  "requestedDT": "2026-01-29T03:23:19.534Z",
  "requestedUserId": "string",
  "size": "string",
  "startedDT": "2026-01-29T03:23:19.534Z",
  "stationId": "string",
  "totalLengthInInches": 0,
  "totalLengthInFeetAndInches": "string"
}
```

| Code | Description | Links |
| --- | --- | --- |
| 200 | 
OK

Media type

Controls `Accept` header.

```
{
  "id": "string",
  "completedDT": "2026-01-29T03:23:19.543Z",
  "createdDT": "2026-01-29T03:23:19.543Z",
  "createdById": "string",
  "modifiedDT": "2026-01-29T03:23:19.543Z",
  "modifiedById": "string",
  "cutListItems": [
    {
      "area": "string",
      "assemblyId": "string",
      "assemblyName": "string",
      "index": 0,
      "cadId": "string",
      "cutDateTime": "2026-01-29T03:23:19.543Z",
      "description": "string",
      "itemNumber": "string",
      "lengthInInches": 0,
      "lengthInFeetAndInches": "string",
      "level": "string",
      "preFabId": "string",
      "qrCode": "string",
      "userData1": "string",
      "userData2": "string",
      "userData3": "string",
      "userData4": "string",
      "userData5": "string",
      "userData6": "string",
      "userData7": "string",
      "userData8": "string",
      "userData9": "string",
      "userData10": "string",
      "userData11": "string",
      "userData12": "string",
      "userData13": "string",
      "userData14": "string",
      "userData15": "string"
    }
  ],
  "cutListItemCount": 0,
  "cutListStatus": "0 = New",
  "cutListStatusLabel": "string",
  "cutListStatusName": "string",
  "isAutoGeneratedCutList": true,
  "material": "string",
  "modelId": "string",
  "name": "string",
  "packageId": "string",
  "percentComplete": 0,
  "projectId": "string",
  "requestedDT": "2026-01-29T03:23:19.543Z",
  "requestedUserId": "string",
  "size": "string",
  "startedDT": "2026-01-29T03:23:19.543Z",
  "stationId": "string",
  "totalLengthInInches": 0,
  "totalLengthInFeetAndInches": "string"
}
```





 | _No links_ |
| 400 | 

Bad Request



 | _No links_ |
| 401 | 

Unauthorized



 | _No links_ |
| 404 | 

Not Found



 | _No links_ |
| 500 | 

Internal Server Error



 | _No links_ |

| Name | Description |
| --- | --- |
| 
id \*

string

(path)

 | 

STRATUS Package Id

 |

REQUIRED: TrackingStatusId

```
{
  "comment": "string",
  "costTypeId": "string",
  "createdDT": "2026-01-29T03:23:19.588Z",
  "divisionId": "string",
  "hours": 0,
  "trackingLogEntryIdResult": "string",
  "trackingStatusId": "string"
}
```

| Code | Description | Links |
| --- | --- | --- |
| 200 | 
OK

Media type

Controls `Accept` header.

```
{
  "comment": "string",
  "costTypeId": "string",
  "createdDT": "2026-01-29T03:23:19.593Z",
  "divisionId": "string",
  "hours": 0,
  "trackingLogEntryIdResult": "string",
  "trackingStatusId": "string"
}
```





 | _No links_ |
| 400 | 

Bad Request



 | _No links_ |
| 401 | 

Unauthorized



 | _No links_ |
| 404 | 

Not Found



 | _No links_ |
| 500 | 

Internal Server Error



 | _No links_ |

| Name | Description |
| --- | --- |
| 
id \*

string

(path)

 | 

STRATUS Package Id

 |

Array of Assembly CadIds to add.

| Code | Description | Links |
| --- | --- | --- |
| 200 | 
OK

Media type

Controls `Accept` header.

```
{
  "assemblyIds": [
    "string"
  ],
  "bimAreaId": "string",
  "bimAreaName": "string",
  "cadIdsBySequence": [
    "string"
  ],
  "categoryId": "string",
  "createdBy": "string",
  "createdDT": "2026-01-29T03:23:19.644Z",
  "currentTrackingStatusId": "string",
  "currentDivisionId": "string",
  "description": "string",
  "fieldIdToValueMap": {
    "additionalProp1": "string",
    "additionalProp2": "string",
    "additionalProp3": "string"
  },
  "fieldNameToValueMap": {
    "additionalProp1": "string",
    "additionalProp2": "string",
    "additionalProp3": "string"
  },
  "hoursEstimatedField": 0,
  "hoursEstimatedOffice": 0,
  "hoursEstimatedPurchasing": 0,
  "hoursEstimatedShop": 0,
  "id": "string",
  "installedDT": "2026-01-29T03:23:19.644Z",
  "modelId": "string",
  "modifiedBy": "string",
  "modifiedDT": "2026-01-29T03:23:19.644Z",
  "name": "string",
  "number": "string",
  "officeDuration": 0,
  "officeStartDT": "2026-01-29T03:23:19.644Z",
  "partCadIds": [
    "string"
  ],
  "projectId": "string",
  "purchasingDuration": 0,
  "purchasingStartDT": "2026-01-29T03:23:19.644Z",
  "qrCodeUrl": "string",
  "requiredDT": "2026-01-29T03:23:19.644Z",
  "selectedTaskWorkflowIdsForAssemblyAndPartCadIds": {
    "additionalProp1": "string",
    "additionalProp2": "string",
    "additionalProp3": "string"
  },
  "shopDuration": 0,
  "startDT": "2026-01-29T03:23:19.644Z",
  "status": "0 = Active",
  "statusName": "string",
  "viewId": "string",
  "isViewIdOverridden": true
}
```





 | _No links_ |
| 400 | 

Bad Request



 | _No links_ |
| 401 | 

Unauthorized



 | _No links_ |
| 404 | 

Not Found



 | _No links_ |
| 500 | 

Internal Server Error



 | _No links_ |

| Name | Description |
| --- | --- |
| 
id \*

string

(path)

 | 

STRATUS Package Id

 |

Array of Assembly CadIds used to replace existing.

| Code | Description | Links |
| --- | --- | --- |
| 200 | 
OK

Media type

Controls `Accept` header.

```
{
  "assemblyIds": [
    "string"
  ],
  "bimAreaId": "string",
  "bimAreaName": "string",
  "cadIdsBySequence": [
    "string"
  ],
  "categoryId": "string",
  "createdBy": "string",
  "createdDT": "2026-01-29T03:23:19.697Z",
  "currentTrackingStatusId": "string",
  "currentDivisionId": "string",
  "description": "string",
  "fieldIdToValueMap": {
    "additionalProp1": "string",
    "additionalProp2": "string",
    "additionalProp3": "string"
  },
  "fieldNameToValueMap": {
    "additionalProp1": "string",
    "additionalProp2": "string",
    "additionalProp3": "string"
  },
  "hoursEstimatedField": 0,
  "hoursEstimatedOffice": 0,
  "hoursEstimatedPurchasing": 0,
  "hoursEstimatedShop": 0,
  "id": "string",
  "installedDT": "2026-01-29T03:23:19.697Z",
  "modelId": "string",
  "modifiedBy": "string",
  "modifiedDT": "2026-01-29T03:23:19.697Z",
  "name": "string",
  "number": "string",
  "officeDuration": 0,
  "officeStartDT": "2026-01-29T03:23:19.697Z",
  "partCadIds": [
    "string"
  ],
  "projectId": "string",
  "purchasingDuration": 0,
  "purchasingStartDT": "2026-01-29T03:23:19.697Z",
  "qrCodeUrl": "string",
  "requiredDT": "2026-01-29T03:23:19.697Z",
  "selectedTaskWorkflowIdsForAssemblyAndPartCadIds": {
    "additionalProp1": "string",
    "additionalProp2": "string",
    "additionalProp3": "string"
  },
  "shopDuration": 0,
  "startDT": "2026-01-29T03:23:19.697Z",
  "status": "0 = Active",
  "statusName": "string",
  "viewId": "string",
  "isViewIdOverridden": true
}
```





 | _No links_ |
| 400 | 

Bad Request



 | _No links_ |
| 401 | 

Unauthorized



 | _No links_ |
| 404 | 

Not Found



 | _No links_ |
| 500 | 

Internal Server Error



 | _No links_ |

| Name | Description |
| --- | --- |
| 
id \*

string

(path)

 | 

STRATUS Package Id

 |

Array of Part CadIds used to replace existing.

| Code | Description | Links |
| --- | --- | --- |
| 200 | 
OK

Media type

Controls `Accept` header.

```
{
  "assemblyIds": [
    "string"
  ],
  "bimAreaId": "string",
  "bimAreaName": "string",
  "cadIdsBySequence": [
    "string"
  ],
  "categoryId": "string",
  "createdBy": "string",
  "createdDT": "2026-01-29T03:23:19.744Z",
  "currentTrackingStatusId": "string",
  "currentDivisionId": "string",
  "description": "string",
  "fieldIdToValueMap": {
    "additionalProp1": "string",
    "additionalProp2": "string",
    "additionalProp3": "string"
  },
  "fieldNameToValueMap": {
    "additionalProp1": "string",
    "additionalProp2": "string",
    "additionalProp3": "string"
  },
  "hoursEstimatedField": 0,
  "hoursEstimatedOffice": 0,
  "hoursEstimatedPurchasing": 0,
  "hoursEstimatedShop": 0,
  "id": "string",
  "installedDT": "2026-01-29T03:23:19.744Z",
  "modelId": "string",
  "modifiedBy": "string",
  "modifiedDT": "2026-01-29T03:23:19.744Z",
  "name": "string",
  "number": "string",
  "officeDuration": 0,
  "officeStartDT": "2026-01-29T03:23:19.744Z",
  "partCadIds": [
    "string"
  ],
  "projectId": "string",
  "purchasingDuration": 0,
  "purchasingStartDT": "2026-01-29T03:23:19.744Z",
  "qrCodeUrl": "string",
  "requiredDT": "2026-01-29T03:23:19.744Z",
  "selectedTaskWorkflowIdsForAssemblyAndPartCadIds": {
    "additionalProp1": "string",
    "additionalProp2": "string",
    "additionalProp3": "string"
  },
  "shopDuration": 0,
  "startDT": "2026-01-29T03:23:19.744Z",
  "status": "0 = Active",
  "statusName": "string",
  "viewId": "string",
  "isViewIdOverridden": true
}
```





 | _No links_ |
| 400 | 

Bad Request



 | _No links_ |
| 401 | 

Unauthorized



 | _No links_ |
| 404 | 

Not Found



 | _No links_ |
| 500 | 

Internal Server Error



 | _No links_ |

| Name | Description |
| --- | --- |
| 
id \*

string

(path)

 | 

STRATUS Package Id

 |

Example JSON KeyValuePair: {"key":"fieldId","value":"fieldValue"}

```
{
  "key": "string",
  "value": "string"
}
```

| Code | Description | Links |
| --- | --- | --- |
| 200 | 
OK

Media type

Controls `Accept` header.

```
{
  "key": "string",
  "value": "string"
}
```





 | _No links_ |
| 400 | 

Bad Request



 | _No links_ |
| 401 | 

Unauthorized



 | _No links_ |
| 404 | 

Not Found



 | _No links_ |
| 500 | 

Internal Server Error



 | _No links_ |

| Name | Description |
| --- | --- |
| 
id \*

string

(path)

 | 

STRATUS Package Id

 |

Example JSON Array of KeyValuePair: \[{"key":"field1Id","value":"field1Value"},{"key":"field2Id","value":"field2Value"},...\]

```
[
  {
    "key": "string",
    "value": "string"
  }
]
```

| Code | Description | Links |
| --- | --- | --- |
| 200 | 
OK

Media type

Controls `Accept` header.

```
0
```





 | _No links_ |
| 400 | 

Bad Request



 | _No links_ |
| 401 | 

Unauthorized



 | _No links_ |
| 404 | 

Not Found



 | _No links_ |
| 500 | 

Internal Server Error



 | _No links_ |

| Name | Description |
| --- | --- |
| 
id \*

string

(path)

 | 

STRATUS Package Id

 |

Array of Part CadIds to add.

| Code | Description | Links |
| --- | --- | --- |
| 200 | 
OK

Media type

Controls `Accept` header.

```
{
  "assemblyIds": [
    "string"
  ],
  "bimAreaId": "string",
  "bimAreaName": "string",
  "cadIdsBySequence": [
    "string"
  ],
  "categoryId": "string",
  "createdBy": "string",
  "createdDT": "2026-01-29T03:23:19.889Z",
  "currentTrackingStatusId": "string",
  "currentDivisionId": "string",
  "description": "string",
  "fieldIdToValueMap": {
    "additionalProp1": "string",
    "additionalProp2": "string",
    "additionalProp3": "string"
  },
  "fieldNameToValueMap": {
    "additionalProp1": "string",
    "additionalProp2": "string",
    "additionalProp3": "string"
  },
  "hoursEstimatedField": 0,
  "hoursEstimatedOffice": 0,
  "hoursEstimatedPurchasing": 0,
  "hoursEstimatedShop": 0,
  "id": "string",
  "installedDT": "2026-01-29T03:23:19.889Z",
  "modelId": "string",
  "modifiedBy": "string",
  "modifiedDT": "2026-01-29T03:23:19.889Z",
  "name": "string",
  "number": "string",
  "officeDuration": 0,
  "officeStartDT": "2026-01-29T03:23:19.889Z",
  "partCadIds": [
    "string"
  ],
  "projectId": "string",
  "purchasingDuration": 0,
  "purchasingStartDT": "2026-01-29T03:23:19.889Z",
  "qrCodeUrl": "string",
  "requiredDT": "2026-01-29T03:23:19.889Z",
  "selectedTaskWorkflowIdsForAssemblyAndPartCadIds": {
    "additionalProp1": "string",
    "additionalProp2": "string",
    "additionalProp3": "string"
  },
  "shopDuration": 0,
  "startDT": "2026-01-29T03:23:19.889Z",
  "status": "0 = Active",
  "statusName": "string",
  "viewId": "string",
  "isViewIdOverridden": true
}
```





 | _No links_ |
| 400 | 

Bad Request



 | _No links_ |
| 401 | 

Unauthorized



 | _No links_ |
| 404 | 

Not Found



 | _No links_ |
| 500 | 

Internal Server Error



 | _No links_ |

Id is required. Status: 0 = Active, 1 = Archived.

```
{
  "categoryId": "string",
  "description": "string",
  "hoursEstimatedField": 0,
  "hoursEstimatedOffice": 0,
  "hoursEstimatedPurchasing": 0,
  "hoursEstimatedShop": 0,
  "id": "string",
  "installedDT": "2026-01-29T03:23:19.930Z",
  "name": "string",
  "number": "string",
  "officeDuration": 0,
  "officeStartDT": "2026-01-29T03:23:19.930Z",
  "purchasingDuration": 0,
  "purchasingStartDT": "2026-01-29T03:23:19.930Z",
  "requiredDT": "2026-01-29T03:23:19.930Z",
  "shopDuration": 0,
  "startDT": "2026-01-29T03:23:19.930Z",
  "status": 0
}
```

| Code | Description | Links |
| --- | --- | --- |
| 200 | 
OK

Media type

Controls `Accept` header.

```
{
  "assemblyIds": [
    "string"
  ],
  "bimAreaId": "string",
  "bimAreaName": "string",
  "cadIdsBySequence": [
    "string"
  ],
  "categoryId": "string",
  "createdBy": "string",
  "createdDT": "2026-01-29T03:23:19.937Z",
  "currentTrackingStatusId": "string",
  "currentDivisionId": "string",
  "description": "string",
  "fieldIdToValueMap": {
    "additionalProp1": "string",
    "additionalProp2": "string",
    "additionalProp3": "string"
  },
  "fieldNameToValueMap": {
    "additionalProp1": "string",
    "additionalProp2": "string",
    "additionalProp3": "string"
  },
  "hoursEstimatedField": 0,
  "hoursEstimatedOffice": 0,
  "hoursEstimatedPurchasing": 0,
  "hoursEstimatedShop": 0,
  "id": "string",
  "installedDT": "2026-01-29T03:23:19.937Z",
  "modelId": "string",
  "modifiedBy": "string",
  "modifiedDT": "2026-01-29T03:23:19.937Z",
  "name": "string",
  "number": "string",
  "officeDuration": 0,
  "officeStartDT": "2026-01-29T03:23:19.937Z",
  "partCadIds": [
    "string"
  ],
  "projectId": "string",
  "purchasingDuration": 0,
  "purchasingStartDT": "2026-01-29T03:23:19.937Z",
  "qrCodeUrl": "string",
  "requiredDT": "2026-01-29T03:23:19.937Z",
  "selectedTaskWorkflowIdsForAssemblyAndPartCadIds": {
    "additionalProp1": "string",
    "additionalProp2": "string",
    "additionalProp3": "string"
  },
  "shopDuration": 0,
  "startDT": "2026-01-29T03:23:19.937Z",
  "status": "0 = Active",
  "statusName": "string",
  "viewId": "string",
  "isViewIdOverridden": true
}
```





 | _No links_ |
| 400 | 

Bad Request



 | _No links_ |
| 401 | 

Unauthorized



 | _No links_ |
| 404 | 

Not Found



 | _No links_ |
| 500 | 

Internal Server Error



 | _No links_ |

### Part

| Name | Description |
| --- | --- |
| 
includeStratusProperties

boolean

(query)

 | 

Pass true to this optional query parameter if you want to generate STRATUS.Part.\* properties and have them returned for the parts. When in use, query must be limited to a single model id.

_Default value_ : false

 |
| 

excludeNullAndEmpty

boolean

(query)

 | 

Pass true to this optional query parameter if you want empty or null values removed from the part's Properties and PropertiesGtp collections to improve performance.

_Default value_ : false

 |
| 

include

(query)

 | 

A comma delimited list of JSON properties to return. All remaining JSON properties will removed from the JSON response. Example: id, description, cutListItems. Specific dictionary keys can be included as follows: properties\["Family"\], propertiesGtp\["Material"\]

 |
| 

where

(query)

 | 

Filter on JSON property values. Example: To filter on two JSON properties: length eq '10' AND description == "truck". To get the last 30 days of data, use: createdDT ge DateTime.Now.AddDays(-30)

 |
| 

page

(query)

 | 

Offset retrieves a given page of data, where 0 is the 1st page, etc (number of elements per page is set by PageSize below)

 |
| 

pagesize

(query)

 | 

Optional: defines the number of elements per page (default (and max) is 100)

 |
| 

disabletotal

(query)

 | 

Optional: disable total calculation to improve performance (default is false)

 |

| Code | Description | Links |
| --- | --- | --- |
| 200 | 
OK

Media type

Controls `Accept` header.

```
{
  "data": [
    {
      "id": "string",
      "createdDT": "2026-01-29T03:23:20.016Z",
      "modifiedDT": "2026-01-29T03:23:20.016Z",
      "cutDT": "2026-01-29T03:23:20.016Z",
      "projectId": "string",
      "projectName": "string",
      "projectNumber": "string",
      "modelId": "string",
      "modelName": "string",
      "bimAreaId": "string",
      "bimArea": "string",
      "cadId": "string",
      "cadType": "string",
      "webId": "string",
      "description": "string",
      "currentTrackingStatusId": "string",
      "currentDivisionId": "string",
      "properties": {
        "additionalProp1": "string",
        "additionalProp2": "string",
        "additionalProp3": "string"
      },
      "propertiesGtp": {
        "additionalProp1": "string",
        "additionalProp2": "string",
        "additionalProp3": "string"
      },
      "points": [
        {
          "pointType": "0 = Unspecified",
          "cadId": "string",
          "location": {
            "x": 0,
            "y": 0,
            "z": 0
          },
          "direction": {
            "x": 0,
            "y": 0,
            "z": 0
          },
          "upVector": {
            "x": 0,
            "y": 0,
            "z": 0
          },
          "width": 0,
          "height": 0,
          "matingElementUniqueId": "string"
        }
      ],
      "cutLengthAdjustment": 0,
      "cutLength2Adjustment": 0,
      "lockLength": true,
      "lockLocation": true,
      "qrCodeUrl": "string",
      "partUrl": "string",
      "patternNumber": "string",
      "source": "0 = PublishedModel",
      "fieldIdToValueMap": {
        "additionalProp1": "string",
        "additionalProp2": "string",
        "additionalProp3": "string"
      },
      "fieldNameToValueMap": {
        "additionalProp1": "string",
        "additionalProp2": "string",
        "additionalProp3": "string"
      }
    }
  ],
  "pageOffset": 0,
  "pageLimit": 0,
  "pageCount": 0,
  "total": 0,
  "truncatedResults": true,
  "truncatedReason": "string",
  "filterOptions": [
    {
      "isValueConcatenated": true,
      "data": "string",
      "options": [
        "string"
      ]
    }
  ],
  "links": {
    "additionalProp1": "string",
    "additionalProp2": "string",
    "additionalProp3": "string"
  }
}
```





 | _No links_ |
| 400 | 

Bad Request



 | _No links_ |
| 401 | 

Unauthorized



 | _No links_ |
| 404 | 

Not Found



 | _No links_ |
| 500 | 

Internal Server Error



 | _No links_ |

| Name | Description |
| --- | --- |
| 
qrcode \*

string

(path)

 | 

The decoded text from a STRATUS QR Code -- being a URL or just the last eight characters of the URL.

 |
| 

includeStratusProperties

boolean

(query)

 | 

Pass true to this optional query parameter if you want to generate STRATUS.Part.\* properties and have them returned for the parts. When in use, query must be limited to a single model id.

_Default value_ : false

 |
| 

excludeNullAndEmpty

boolean

(query)

 | 

Pass true to this optional query parameter if you want empty or null values removed from the part's Properties and PropertiesGtp collections to improve performance.

_Default value_ : false

 |
| 

include

(query)

 | 

A comma delimited list of JSON properties to return. All remaining JSON properties will removed from the JSON response. Example: id, description, cutListItems. Specific dictionary keys can be included as follows: properties\["Family"\], propertiesGtp\["Material"\]

 |

| Code | Description | Links |
| --- | --- | --- |
| 200 | 
OK

Media type

Controls `Accept` header.

```
{
  "id": "string",
  "createdDT": "2026-01-29T03:23:20.070Z",
  "modifiedDT": "2026-01-29T03:23:20.070Z",
  "cutDT": "2026-01-29T03:23:20.070Z",
  "projectId": "string",
  "projectName": "string",
  "projectNumber": "string",
  "modelId": "string",
  "modelName": "string",
  "bimAreaId": "string",
  "bimArea": "string",
  "cadId": "string",
  "cadType": "string",
  "webId": "string",
  "description": "string",
  "currentTrackingStatusId": "string",
  "currentDivisionId": "string",
  "properties": {
    "additionalProp1": "string",
    "additionalProp2": "string",
    "additionalProp3": "string"
  },
  "propertiesGtp": {
    "additionalProp1": "string",
    "additionalProp2": "string",
    "additionalProp3": "string"
  },
  "points": [
    {
      "pointType": "0 = Unspecified",
      "cadId": "string",
      "location": {
        "x": 0,
        "y": 0,
        "z": 0
      },
      "direction": {
        "x": 0,
        "y": 0,
        "z": 0
      },
      "upVector": {
        "x": 0,
        "y": 0,
        "z": 0
      },
      "width": 0,
      "height": 0,
      "matingElementUniqueId": "string"
    }
  ],
  "cutLengthAdjustment": 0,
  "cutLength2Adjustment": 0,
  "lockLength": true,
  "lockLocation": true,
  "qrCodeUrl": "string",
  "partUrl": "string",
  "patternNumber": "string",
  "source": "0 = PublishedModel",
  "fieldIdToValueMap": {
    "additionalProp1": "string",
    "additionalProp2": "string",
    "additionalProp3": "string"
  },
  "fieldNameToValueMap": {
    "additionalProp1": "string",
    "additionalProp2": "string",
    "additionalProp3": "string"
  }
}
```





 | _No links_ |
| 400 | 

Bad Request



 | _No links_ |
| 401 | 

Unauthorized



 | _No links_ |
| 404 | 

Not Found



 | _No links_ |
| 500 | 

Internal Server Error



 | _No links_ |

| Name | Description |
| --- | --- |
| 
id \*

string

(path)

 | 

STRATUS Part Id

 |
| 

includeStratusProperties

boolean

(query)

 | 

Pass true to this optional query parameter if you want to generate STRATUS.Part.\* properties and have them returned for the parts.

_Default value_ : false

 |
| 

excludeNullAndEmpty

boolean

(query)

 | 

Pass true to this optional query parameter if you want empty or null values removed from the part's Properties and PropertiesGtp collections to improve performance.

_Default value_ : false

 |
| 

include

(query)

 | 

A comma delimited list of JSON properties to return. All remaining JSON properties will removed from the JSON response. Example: id, description, cutListItems. Specific dictionary keys can be included as follows: properties\["Family"\], propertiesGtp\["Material"\]

 |

| Code | Description | Links |
| --- | --- | --- |
| 200 | 
OK

Media type

Controls `Accept` header.

```
{
  "id": "string",
  "createdDT": "2026-01-29T03:23:20.126Z",
  "modifiedDT": "2026-01-29T03:23:20.126Z",
  "cutDT": "2026-01-29T03:23:20.126Z",
  "projectId": "string",
  "projectName": "string",
  "projectNumber": "string",
  "modelId": "string",
  "modelName": "string",
  "bimAreaId": "string",
  "bimArea": "string",
  "cadId": "string",
  "cadType": "string",
  "webId": "string",
  "description": "string",
  "currentTrackingStatusId": "string",
  "currentDivisionId": "string",
  "properties": {
    "additionalProp1": "string",
    "additionalProp2": "string",
    "additionalProp3": "string"
  },
  "propertiesGtp": {
    "additionalProp1": "string",
    "additionalProp2": "string",
    "additionalProp3": "string"
  },
  "points": [
    {
      "pointType": "0 = Unspecified",
      "cadId": "string",
      "location": {
        "x": 0,
        "y": 0,
        "z": 0
      },
      "direction": {
        "x": 0,
        "y": 0,
        "z": 0
      },
      "upVector": {
        "x": 0,
        "y": 0,
        "z": 0
      },
      "width": 0,
      "height": 0,
      "matingElementUniqueId": "string"
    }
  ],
  "cutLengthAdjustment": 0,
  "cutLength2Adjustment": 0,
  "lockLength": true,
  "lockLocation": true,
  "qrCodeUrl": "string",
  "partUrl": "string",
  "patternNumber": "string",
  "source": "0 = PublishedModel",
  "fieldIdToValueMap": {
    "additionalProp1": "string",
    "additionalProp2": "string",
    "additionalProp3": "string"
  },
  "fieldNameToValueMap": {
    "additionalProp1": "string",
    "additionalProp2": "string",
    "additionalProp3": "string"
  }
}
```





 | _No links_ |
| 400 | 

Bad Request



 | _No links_ |
| 401 | 

Unauthorized



 | _No links_ |
| 404 | 

Not Found



 | _No links_ |
| 500 | 

Internal Server Error



 | _No links_ |

| Name | Description |
| --- | --- |
| 
csvIds

string

(header)

 | 

List of STRATUS Part Ids

 |

| Code | Description | Links |
| --- | --- | --- |
| 200 | 
OK

Media type

Controls `Accept` header.

```
string
```





 | _No links_ |
| 400 | 

Bad Request



 | _No links_ |
| 401 | 

Unauthorized



 | _No links_ |
| 404 | 

Not Found



 | _No links_ |
| 500 | 

Internal Server Error



 | _No links_ |

| Name | Description |
| --- | --- |
| 
id \*

string

(path)

 | 

STRATUS Part Id

 |
| 

trackingLogEntryId

string

(query)

 | 

Optional TrackingLogEntry Id to associate Attachment with a TrackingLogEntry

 |

| Code | Description | Links |
| --- | --- | --- |
| 200 | 
OK

Media type

Controls `Accept` header.

```
{
  "id": "string",
  "createdById": "string",
  "createdDT": "2026-01-29T03:23:20.216Z",
  "projectId": "string",
  "modelId": "string",
  "referenceType": "0 = Unspecified",
  "referenceName": "string",
  "referenceId": "string",
  "role": "0 = Unspecified",
  "roleName": "string",
  "fileType": "0 = Unspecified",
  "fileTypeName": "string",
  "localFilePath": "string",
  "fileName": "string",
  "overriddenRemoteFolder": "string"
}
```





 | _No links_ |
| 400 | 

Bad Request



 | _No links_ |
| 401 | 

Unauthorized



 | _No links_ |
| 404 | 

Not Found



 | _No links_ |
| 500 | 

Internal Server Error



 | _No links_ |

| Name | Description |
| --- | --- |
| 
id \*

string

(path)

 | 

STRATUS Part Id

 |
| 

isCut

boolean

(query)

 | 

DEFAULT: true. If set to false, will not mark the part as cut.

_Default value_ : true

 |

REQUIRED: TrackingStatusId

```
{
  "comment": "string",
  "costTypeId": "string",
  "createdDT": "2026-01-29T03:23:20.285Z",
  "divisionId": "string",
  "hours": 0,
  "trackingLogEntryIdResult": "string",
  "trackingStatusId": "string"
}
```

| Code | Description | Links |
| --- | --- | --- |
| 200 | 
OK

Media type

Controls `Accept` header.

```
{
  "comment": "string",
  "costTypeId": "string",
  "createdDT": "2026-01-29T03:23:20.292Z",
  "divisionId": "string",
  "hours": 0,
  "trackingLogEntryIdResult": "string",
  "trackingStatusId": "string"
}
```





 | _No links_ |
| 400 | 

Bad Request



 | _No links_ |
| 401 | 

Unauthorized



 | _No links_ |
| 404 | 

Not Found



 | _No links_ |
| 500 | 

Internal Server Error



 | _No links_ |

| Name | Description |
| --- | --- |
| 
id \*

string

(path)

 | 

STRATUS Part Id

 |

Example JSON KeyValuePair: {"key":"propertyKey","value":"propertyValue"}

```
{
  "key": "string",
  "value": "string"
}
```

| Code | Description | Links |
| --- | --- | --- |
| 200 | 
OK

Media type

Controls `Accept` header.

```
{
  "key": "string",
  "value": "string"
}
```





 | _No links_ |
| 400 | 

Bad Request



 | _No links_ |
| 401 | 

Unauthorized



 | _No links_ |
| 404 | 

Not Found



 | _No links_ |
| 500 | 

Internal Server Error



 | _No links_ |

Example List of PartPropertiesDataApi JSON: \[{"Id":"Part1.Id","Properties":{"Property1Key":"Property1Value","Property2Key":"Property2Value"}},{"Id":"Part2.Id","Properties":{"Property1Key":"Property1Value","Property2Key":"Property2Value"}}\]

```
[
  {
    "id": "string",
    "properties": {
      "additionalProp1": "string",
      "additionalProp2": "string",
      "additionalProp3": "string"
    }
  }
]
```

| Code | Description | Links |
| --- | --- | --- |
| 200 | 
OK

Media type

Controls `Accept` header.

```
true
```





 | _No links_ |
| 400 | 

Bad Request



 | _No links_ |
| 401 | 

Unauthorized



 | _No links_ |
| 404 | 

Not Found



 | _No links_ |
| 500 | 

Internal Server Error



 | _No links_ |

| Name | Description |
| --- | --- |
| 
id \*

string

(path)

 | 

STRATUS Part Id

 |

Example JSON KeyValuePair: {"key":"fieldId","value":"fieldValue"}

```
{
  "key": "string",
  "value": "string"
}
```

| Code | Description | Links |
| --- | --- | --- |
| 200 | 
OK

Media type

Controls `Accept` header.

```
{
  "key": "string",
  "value": "string"
}
```





 | _No links_ |
| 400 | 

Bad Request



 | _No links_ |
| 401 | 

Unauthorized



 | _No links_ |
| 404 | 

Not Found



 | _No links_ |
| 500 | 

Internal Server Error



 | _No links_ |

| Name | Description |
| --- | --- |
| 
id \*

string

(path)

 | 

STRATUS Part Id

 |

Example JSON Array of KeyValuePair: \[{"key":"field1Id","value":"field1Value"},{"key":"field2Id","value":"field2Value"},...\]

```
[
  {
    "key": "string",
    "value": "string"
  }
]
```

| Code | Description | Links |
| --- | --- | --- |
| 200 | 
OK

Media type

Controls `Accept` header.

```
0
```





 | _No links_ |
| 400 | 

Bad Request



 | _No links_ |
| 401 | 

Unauthorized



 | _No links_ |
| 404 | 

Not Found



 | _No links_ |
| 500 | 

Internal Server Error



 | _No links_ |

### Ping

| Name | Description |
| --- | --- |
| 
app-id

string

(header)

 | 

(optional) Partner App Id

 |

| Code | Description | Links |
| --- | --- | --- |
| 200 | 
OK



 | _No links_ |
| 401 | 

Unauthorized



 | _No links_ |

### Project

| Name | Description |
| --- | --- |
| 
id \*

string

(path)

 | 

STRATUS Project Id

 |

| Code | Description | Links |
| --- | --- | --- |
| 200 | 
OK

Media type

Controls `Accept` header.

```
{
  "id": "string",
  "createdDT": "2026-01-29T03:23:20.560Z",
  "modifiedDT": "2026-01-29T03:23:20.560Z",
  "status": "0 = New",
  "statusName": "string",
  "a360Id": "string",
  "a360RootFolderId": "string",
  "companyId": "string",
  "category": "string",
  "number": "string",
  "name": "string",
  "phase": "string",
  "description": "string",
  "imageAttachmentId": "string",
  "address1": "string",
  "address2": "string",
  "city": "string",
  "state": "string",
  "zip": "string",
  "targetStartDate": "2026-01-29T03:23:20.560Z",
  "actualStartDate": "2026-01-29T03:23:20.560Z",
  "targetEndDate": "2026-01-29T03:23:20.560Z",
  "actualEndDate": "2026-01-29T03:23:20.560Z",
  "color": "string",
  "isTaxExempt": true
}
```





 | _No links_ |
| 400 | 

Bad Request



 | _No links_ |
| 401 | 

Unauthorized



 | _No links_ |
| 404 | 

Not Found



 | _No links_ |
| 500 | 

Internal Server Error



 | _No links_ |

| Name | Description |
| --- | --- |
| 
id \*

string

(path)

 | 

STRATUS Project Id

 |
| 

asFlatList

boolean

(query)

 | 

if true, results will be list of areas instead of hierarchy data structure using children, where ParentId can be used to understand hierarchy

_Default value_ : false

 |

| Code | Description | Links |
| --- | --- | --- |
| 200 | 
OK

Media type

Controls `Accept` header.

```
[
  {
    "abbreviation": "string",
    "children": [
      "string"
    ],
    "code": "string",
    "color": "string",
    "createdById": "string",
    "createdDT": "2026-01-29T03:23:20.599Z",
    "elevation": 0,
    "id": "string",
    "levelBottomOffset": 0,
    "levelTopOffset": 0,
    "modifiedById": "string",
    "modifiedDT": "2026-01-29T03:23:20.599Z",
    "name": "string",
    "parentId": "string"
  }
]
```





 | _No links_ |
| 400 | 

Bad Request



 | _No links_ |
| 401 | 

Unauthorized



 | _No links_ |
| 404 | 

Not Found



 | _No links_ |
| 500 | 

Internal Server Error



 | _No links_ |

| Name | Description |
| --- | --- |
| 
id \*

string

(path)

 | 

STRATUS Project Id

 |
| 

include

(query)

 | 

A comma delimited list of JSON properties to return. All remaining JSON properties will removed from the JSON response. Example: id, description, cutListItems. Specific dictionary keys can be included as follows: properties\["Family"\], propertiesGtp\["Material"\]

 |
| 

where

(query)

 | 

Filter on JSON property values. Example: To filter on two JSON properties: length eq '10' AND description == "truck". To get the last 30 days of data, use: createdDT ge DateTime.Now.AddDays(-30)

 |
| 

page

(query)

 | 

Offset retrieves a given page of data, where 0 is the 1st page, etc (number of elements per page is set by PageSize below)

 |
| 

pagesize

(query)

 | 

Optional: defines the number of elements per page (default (and max) is 1000)

 |
| 

disabletotal

(query)

 | 

Optional: disable total calculation to improve performance (default is false)

 |

| Code | Description | Links |
| --- | --- | --- |
| 200 | 
OK

Media type

Controls `Accept` header.

```
{
  "data": [
    {
      "id": "string",
      "createdDT": "2026-01-29T03:23:20.669Z",
      "modifiedDT": "2026-01-29T03:23:20.669Z",
      "projectId": "string",
      "modelId": "string",
      "cadId": "string",
      "sheetId": "string",
      "viewId": "string",
      "isViewIdOverridden": true,
      "currentTrackingStatusId": "string",
      "currentDivisionId": "string",
      "assemblyType": "0 = Unspecified",
      "assemblyTypeLabel": "string",
      "excludedCadIds": [
        "string"
      ],
      "fieldIdToValueMap": {
        "additionalProp1": "string",
        "additionalProp2": "string",
        "additionalProp3": "string"
      },
      "fieldNameToValueMap": {
        "additionalProp1": "string",
        "additionalProp2": "string",
        "additionalProp3": "string"
      },
      "name": "string",
      "nameLabel": "string",
      "partIds": [
        "string"
      ],
      "instanceIndex": "string",
      "lastUsedAssembliesPartsTableReportIds": [
        "string"
      ],
      "qrCodeUrl": "string",
      "notes": [
        {
          "isPartialData": true,
          "isReadOnly": true,
          "id": "string",
          "createdDT": "2026-01-29T03:23:20.669Z",
          "createdById": "string",
          "modifiedDT": "2026-01-29T03:23:20.669Z",
          "modifiedById": "string",
          "name": "string"
        }
      ],
      "defaultOrientationForReportTemplatesForgeViewerViewJson": {
        "additionalProp1": "string",
        "additionalProp2": "string",
        "additionalProp3": "string"
      }
    }
  ],
  "pageOffset": 0,
  "pageLimit": 0,
  "pageCount": 0,
  "total": 0,
  "truncatedResults": true,
  "truncatedReason": "string",
  "filterOptions": [
    {
      "isValueConcatenated": true,
      "data": "string",
      "options": [
        "string"
      ]
    }
  ],
  "links": {
    "additionalProp1": "string",
    "additionalProp2": "string",
    "additionalProp3": "string"
  }
}
```





 | _No links_ |
| 400 | 

Bad Request



 | _No links_ |
| 401 | 

Unauthorized



 | _No links_ |
| 404 | 

Not Found



 | _No links_ |
| 500 | 

Internal Server Error



 | _No links_ |

| Name | Description |
| --- | --- |
| 
id \*

string

(path)

 | 

STRATUS Project Id

 |
| 

include

(query)

 | 

A comma delimited list of JSON properties to return. All remaining JSON properties will removed from the JSON response. Example: id, description, cutListItems. Specific dictionary keys can be included as follows: properties\["Family"\], propertiesGtp\["Material"\]

 |
| 

where

(query)

 | 

Filter on JSON property values. Example: To filter on two JSON properties: length eq '10' AND description == "truck". To get the last 30 days of data, use: createdDT ge DateTime.Now.AddDays(-30)

 |
| 

page

(query)

 | 

Offset retrieves a given page of data, where 0 is the 1st page, etc (number of elements per page is set by PageSize below)

 |
| 

pagesize

(query)

 | 

Optional: defines the number of elements per page (default (and max) is 1000)

 |
| 

disabletotal

(query)

 | 

Optional: disable total calculation to improve performance (default is false)

 |

| Code | Description | Links |
| --- | --- | --- |
| 200 | 
OK

Media type

Controls `Accept` header.

```
{
  "data": [
    {
      "id": "string",
      "name": "string",
      "description": "string",
      "length": "string",
      "width": "string",
      "height": "string",
      "location": "string",
      "containerTypeName": "string",
      "parentContainerId": "string",
      "currentTrackingStatusId": "string",
      "currentDivisionId": "string",
      "qrCodeUrl": "string",
      "fieldIdToValueMap": {
        "additionalProp1": "string",
        "additionalProp2": "string",
        "additionalProp3": "string"
      },
      "partIds": [
        "string"
      ],
      "assemblyCadIds": [
        "string"
      ],
      "packageIds": [
        "string"
      ],
      "containerIds": [
        "string"
      ],
      "contents": [
        {
          "projectId": "string",
          "referenceId": "string",
          "referenceType": "0 = Unspecified"
        }
      ]
    }
  ],
  "pageOffset": 0,
  "pageLimit": 0,
  "pageCount": 0,
  "total": 0,
  "truncatedResults": true,
  "truncatedReason": "string",
  "filterOptions": [
    {
      "isValueConcatenated": true,
      "data": "string",
      "options": [
        "string"
      ]
    }
  ],
  "links": {
    "additionalProp1": "string",
    "additionalProp2": "string",
    "additionalProp3": "string"
  }
}
```





 | _No links_ |
| 400 | 

Bad Request



 | _No links_ |
| 401 | 

Unauthorized



 | _No links_ |
| 404 | 

Not Found



 | _No links_ |
| 500 | 

Internal Server Error



 | _No links_ |

| Name | Description |
| --- | --- |
| 
id \*

string

(path)

 | 

STRATUS Project Id

 |
| 

include

(query)

 | 

A comma delimited list of JSON properties to return. All remaining JSON properties will removed from the JSON response. Example: id, description, cutListItems. Specific dictionary keys can be included as follows: properties\["Family"\], propertiesGtp\["Material"\]

 |
| 

where

(query)

 | 

Filter on JSON property values. Example: To filter on two JSON properties: length eq '10' AND description == "truck". To get the last 30 days of data, use: createdDT ge DateTime.Now.AddDays(-30)

 |
| 

page

(query)

 | 

Offset retrieves a given page of data, where 0 is the 1st page, etc (number of elements per page is set by PageSize below)

 |
| 

pagesize

(query)

 | 

Optional: defines the number of elements per page (default (and max) is 1000)

 |
| 

disabletotal

(query)

 | 

Optional: disable total calculation to improve performance (default is false)

 |

| Code | Description | Links |
| --- | --- | --- |
| 200 | 
OK

Media type

Controls `Accept` header.

```
{
  "data": [
    {
      "a360FolderId": "string",
      "createdDT": "2026-01-29T03:23:20.816Z",
      "databaseUnits": "0 = Imperial",
      "defaultViewId": "string",
      "id": "string",
      "isFieldOrderz": true,
      "lastPublishedDT": "2026-01-29T03:23:20.816Z",
      "modelName": "string",
      "modelType": "0 = Unspecified",
      "modifiedDT": "2026-01-29T03:23:20.816Z",
      "name": "string",
      "projectId": "string",
      "publishStatus": "0 = Published",
      "releaseVersion": "string"
    }
  ],
  "pageOffset": 0,
  "pageLimit": 0,
  "pageCount": 0,
  "total": 0,
  "truncatedResults": true,
  "truncatedReason": "string",
  "filterOptions": [
    {
      "isValueConcatenated": true,
      "data": "string",
      "options": [
        "string"
      ]
    }
  ],
  "links": {
    "additionalProp1": "string",
    "additionalProp2": "string",
    "additionalProp3": "string"
  }
}
```





 | _No links_ |
| 400 | 

Bad Request



 | _No links_ |
| 401 | 

Unauthorized



 | _No links_ |
| 404 | 

Not Found



 | _No links_ |
| 500 | 

Internal Server Error



 | _No links_ |

| Name | Description |
| --- | --- |
| 
id \*

string

(path)

 | 

STRATUS Project Id

 |
| 

page

(query)

 | 

Offset retrieves a given page of data, where 0 is the 1st page, etc (number of elements per page is set by PageSize below)

 |
| 

pagesize

(query)

 | 

Optional: defines the number of elements per page (default (and max) is 1000)

 |
| 

disabletotal

(query)

 | 

Optional: disable total calculation to improve performance (default is false)

 |

| Code | Description | Links |
| --- | --- | --- |
| 200 | 
OK

Media type

Controls `Accept` header.

```
{
  "data": [
    {
      "id": "string",
      "name": "string",
      "number": "string",
      "description": "string",
      "statusName": "string",
      "supplierName": "string",
      "supplierResponseNumber": "string",
      "tax": 0,
      "freight": 0,
      "totalAmount": 0,
      "projectId": "string",
      "lineItems": [
        {
          "additionalProperty": "string",
          "ancillaryType": "string",
          "ancillaryUsageType": "string",
          "backorderedQTY": 0,
          "comment": "string",
          "description": "string",
          "diameter": "string",
          "isAncillary": true,
          "isModeled": true,
          "length": "string",
          "lineNumber": 0,
          "manufacturer": "string",
          "material": "string",
          "nominalStockLength": "string",
          "orderedQTY": 0,
          "partTemplateName": "string",
          "productCode": "string",
          "quotedQTY": 0,
          "serviceCode": "string",
          "serviceName": "string",
          "shippedQTY": 0,
          "size": "string",
          "totalPrice": 0,
          "unitOfMeasure": "string",
          "unitPrice": "string",
          "width": "string"
        }
      ]
    }
  ],
  "pageOffset": 0,
  "pageLimit": 0,
  "pageCount": 0,
  "total": 0,
  "truncatedResults": true,
  "truncatedReason": "string",
  "filterOptions": [
    {
      "isValueConcatenated": true,
      "data": "string",
      "options": [
        "string"
      ]
    }
  ],
  "links": {
    "additionalProp1": "string",
    "additionalProp2": "string",
    "additionalProp3": "string"
  }
}
```





 | _No links_ |
| 400 | 

Bad Request



 | _No links_ |
| 401 | 

Unauthorized



 | _No links_ |
| 404 | 

Not Found



 | _No links_ |
| 500 | 

Internal Server Error



 | _No links_ |

| Name | Description |
| --- | --- |
| 
id \*

string

(path)

 | 

STRATUS Project Id

 |
| 

page

(query)

 | 

Offset retrieves a given page of data, where 0 is the 1st page, etc (number of elements per page is set by PageSize below)

 |
| 

pagesize

(query)

 | 

Optional: defines the number of elements per page (default (and max) is 1000)

 |
| 

disabletotal

(query)

 | 

Optional: disable total calculation to improve performance (default is false)

 |

| Code | Description | Links |
| --- | --- | --- |
| 200 | 
OK

Media type

Controls `Accept` header.

```
{
  "data": [
    {
      "source": "1 = STRATUS",
      "name": "string",
      "code": "string",
      "abbreviation": "string",
      "group": "string",
      "fabConfigId": "string",
      "fabServiceId": "string",
      "fabServiceSpecId": "string",
      "fabServiceInsulationSpecId": "string"
    }
  ],
  "pageOffset": 0,
  "pageLimit": 0,
  "pageCount": 0,
  "total": 0,
  "truncatedResults": true,
  "truncatedReason": "string",
  "filterOptions": [
    {
      "isValueConcatenated": true,
      "data": "string",
      "options": [
        "string"
      ]
    }
  ],
  "links": {
    "additionalProp1": "string",
    "additionalProp2": "string",
    "additionalProp3": "string"
  }
}
```





 | _No links_ |
| 400 | 

Bad Request



 | _No links_ |
| 401 | 

Unauthorized



 | _No links_ |
| 404 | 

Not Found



 | _No links_ |
| 500 | 

Internal Server Error



 | _No links_ |

| Name | Description |
| --- | --- |
| 
nonStratusProjectsOnly

boolean

(query)

 | 

If true, returns only projects which have not been synced to Stratus, otherwise all projects (which takes longer).

 |

| Code | Description | Links |
| --- | --- | --- |
| 200 | 
OK

Media type

Controls `Accept` header.

```
[
  {
    "id": "string",
    "createdDT": "2026-01-29T03:23:20.966Z",
    "modifiedDT": "2026-01-29T03:23:20.966Z",
    "status": "0 = New",
    "statusName": "string",
    "a360Id": "string",
    "a360RootFolderId": "string",
    "companyId": "string",
    "category": "string",
    "number": "string",
    "name": "string",
    "phase": "string",
    "description": "string",
    "imageAttachmentId": "string",
    "address1": "string",
    "address2": "string",
    "city": "string",
    "state": "string",
    "zip": "string",
    "targetStartDate": "2026-01-29T03:23:20.966Z",
    "actualStartDate": "2026-01-29T03:23:20.966Z",
    "targetEndDate": "2026-01-29T03:23:20.966Z",
    "actualEndDate": "2026-01-29T03:23:20.966Z",
    "color": "string",
    "isTaxExempt": true
  }
]
```





 | _No links_ |
| 400 | 

Bad Request



 | _No links_ |
| 401 | 

Unauthorized



 | _No links_ |
| 404 | 

Not Found



 | _No links_ |
| 500 | 

Internal Server Error



 | _No links_ |

| Name | Description |
| --- | --- |
| 
include

(query)

 | 

A comma delimited list of JSON properties to return. All remaining JSON properties will removed from the JSON response. Example: id, description, cutListItems. Specific dictionary keys can be included as follows: properties\["Family"\], propertiesGtp\["Material"\]

 |
| 

where

(query)

 | 

Filter on JSON property values. Example: To filter on two JSON properties: length eq '10' AND description == "truck". To get the last 30 days of data, use: createdDT ge DateTime.Now.AddDays(-30)

 |
| 

page

(query)

 | 

Offset retrieves a given page of data, where 0 is the 1st page, etc (number of elements per page is set by PageSize below)

 |
| 

pagesize

(query)

 | 

Optional: defines the number of elements per page (default (and max) is 1000)

 |
| 

disabletotal

(query)

 | 

Optional: disable total calculation to improve performance (default is false)

 |

| Code | Description | Links |
| --- | --- | --- |
| 200 | 
OK

Media type

Controls `Accept` header.

```
{
  "data": [
    {
      "id": "string",
      "createdDT": "2026-01-29T03:23:21.023Z",
      "modifiedDT": "2026-01-29T03:23:21.023Z",
      "status": "0 = New",
      "statusName": "string",
      "a360Id": "string",
      "a360RootFolderId": "string",
      "companyId": "string",
      "category": "string",
      "number": "string",
      "name": "string",
      "phase": "string",
      "description": "string",
      "imageAttachmentId": "string",
      "address1": "string",
      "address2": "string",
      "city": "string",
      "state": "string",
      "zip": "string",
      "targetStartDate": "2026-01-29T03:23:21.023Z",
      "actualStartDate": "2026-01-29T03:23:21.023Z",
      "targetEndDate": "2026-01-29T03:23:21.023Z",
      "actualEndDate": "2026-01-29T03:23:21.023Z",
      "color": "string",
      "isTaxExempt": true
    }
  ],
  "pageOffset": 0,
  "pageLimit": 0,
  "pageCount": 0,
  "total": 0,
  "truncatedResults": true,
  "truncatedReason": "string",
  "filterOptions": [
    {
      "isValueConcatenated": true,
      "data": "string",
      "options": [
        "string"
      ]
    }
  ],
  "links": {
    "additionalProp1": "string",
    "additionalProp2": "string",
    "additionalProp3": "string"
  }
}
```





 | _No links_ |
| 400 | 

Bad Request



 | _No links_ |
| 401 | 

Unauthorized



 | _No links_ |
| 404 | 

Not Found



 | _No links_ |
| 500 | 

Internal Server Error



 | _No links_ |

| Name | Description |
| --- | --- |
| 
qrcode \*

string

(path)

 | 

The decoded text from a STRATUS QR Code -- being a URL or just the last eight characters of the URL.

 |
| 

include

(query)

 | 

A comma delimited list of JSON properties to return. All remaining JSON properties will removed from the JSON response. Example: id, description, cutListItems. Specific dictionary keys can be included as follows: properties\["Family"\], propertiesGtp\["Material"\]

 |

| Code | Description | Links |
| --- | --- | --- |
| 200 | 
OK

Media type

Controls `Accept` header.

```
{
  "id": "string",
  "createdDT": "2026-01-29T03:23:21.061Z",
  "modifiedDT": "2026-01-29T03:23:21.061Z",
  "status": "0 = New",
  "statusName": "string",
  "a360Id": "string",
  "a360RootFolderId": "string",
  "companyId": "string",
  "category": "string",
  "number": "string",
  "name": "string",
  "phase": "string",
  "description": "string",
  "imageAttachmentId": "string",
  "address1": "string",
  "address2": "string",
  "city": "string",
  "state": "string",
  "zip": "string",
  "targetStartDate": "2026-01-29T03:23:21.061Z",
  "actualStartDate": "2026-01-29T03:23:21.061Z",
  "targetEndDate": "2026-01-29T03:23:21.061Z",
  "actualEndDate": "2026-01-29T03:23:21.061Z",
  "color": "string",
  "isTaxExempt": true
}
```





 | _No links_ |
| 400 | 

Bad Request



 | _No links_ |
| 401 | 

Unauthorized



 | _No links_ |
| 404 | 

Not Found



 | _No links_ |
| 500 | 

Internal Server Error



 | _No links_ |

| Name | Description |
| --- | --- |
| 
userid \*

string

(path)

 | 

User Id specified for Project Role filtering.

 |
| 

include

(query)

 | 

A comma delimited list of JSON properties to return. All remaining JSON properties will removed from the JSON response. Example: id, description, cutListItems. Specific dictionary keys can be included as follows: properties\["Family"\], propertiesGtp\["Material"\]

 |
| 

where

(query)

 | 

Filter on JSON property values. Example: To filter on two JSON properties: length eq '10' AND description == "truck". To get the last 30 days of data, use: createdDT ge DateTime.Now.AddDays(-30)

 |
| 

page

(query)

 | 

Offset retrieves a given page of data, where 0 is the 1st page, etc (number of elements per page is set by PageSize below)

 |
| 

pagesize

(query)

 | 

Optional: defines the number of elements per page (default (and max) is 1000)

 |
| 

disabletotal

(query)

 | 

Optional: disable total calculation to improve performance (default is false)

 |

| Code | Description | Links |
| --- | --- | --- |
| 200 | 
OK

Media type

Controls `Accept` header.

```
{
  "data": [
    {
      "id": "string",
      "createdDT": "2026-01-29T03:23:21.125Z",
      "modifiedDT": "2026-01-29T03:23:21.125Z",
      "status": "0 = New",
      "statusName": "string",
      "a360Id": "string",
      "a360RootFolderId": "string",
      "companyId": "string",
      "category": "string",
      "number": "string",
      "name": "string",
      "phase": "string",
      "description": "string",
      "imageAttachmentId": "string",
      "address1": "string",
      "address2": "string",
      "city": "string",
      "state": "string",
      "zip": "string",
      "targetStartDate": "2026-01-29T03:23:21.125Z",
      "actualStartDate": "2026-01-29T03:23:21.125Z",
      "targetEndDate": "2026-01-29T03:23:21.125Z",
      "actualEndDate": "2026-01-29T03:23:21.125Z",
      "color": "string",
      "isTaxExempt": true
    }
  ],
  "pageOffset": 0,
  "pageLimit": 0,
  "pageCount": 0,
  "total": 0,
  "truncatedResults": true,
  "truncatedReason": "string",
  "filterOptions": [
    {
      "isValueConcatenated": true,
      "data": "string",
      "options": [
        "string"
      ]
    }
  ],
  "links": {
    "additionalProp1": "string",
    "additionalProp2": "string",
    "additionalProp3": "string"
  }
}
```





 | _No links_ |
| 400 | 

Bad Request



 | _No links_ |
| 401 | 

Unauthorized



 | _No links_ |
| 404 | 

Not Found



 | _No links_ |
| 500 | 

Internal Server Error



 | _No links_ |

| Name | Description |
| --- | --- |
| 
addDefaultUserProjectRoles

boolean

(query)

 | 

if true, default user project roles will be added to the new project

 |
| 

setActive

boolean

(query)

 | 

if true, project will be set to Active status, otherwise set to New

 |

Pass Project object in request body. Project object returned by call to available-autodesk-projects can be passed into this method. Project object must contain valid A360Id and Name. Resulting ProjectDataApi will be returned with new Stratus Project Id if successful, otherwise null.

```
{
  "id": "string",
  "createdDT": "2026-01-29T03:23:21.177Z",
  "modifiedDT": "2026-01-29T03:23:21.177Z",
  "status": "0 = New",
  "statusName": "string",
  "a360Id": "string",
  "a360RootFolderId": "string",
  "companyId": "string",
  "category": "string",
  "number": "string",
  "name": "string",
  "phase": "string",
  "description": "string",
  "imageAttachmentId": "string",
  "address1": "string",
  "address2": "string",
  "city": "string",
  "state": "string",
  "zip": "string",
  "targetStartDate": "2026-01-29T03:23:21.177Z",
  "actualStartDate": "2026-01-29T03:23:21.177Z",
  "targetEndDate": "2026-01-29T03:23:21.177Z",
  "actualEndDate": "2026-01-29T03:23:21.177Z",
  "color": "string",
  "isTaxExempt": true
}
```

| Code | Description | Links |
| --- | --- | --- |
| 200 | 
OK



 | _No links_ |

### QRCode

| Name | Description |
| --- | --- |
| 
urlSubstring

string

(query)

 | 

Optional: Returns all ShortURL records that have the given sub-string inside the URL field.

 |
| 

where

(query)

 | 

Filter on JSON property values. Example: To filter on two JSON properties: length eq '10' AND description == "truck". To get the last 30 days of data, use: createdDT ge DateTime.Now.AddDays(-30)

 |
| 

page

(query)

 | 

Offset retrieves a given page of data, where 0 is the 1st page, etc (number of elements per page is set by PageSize below)

 |
| 

pagesize

(query)

 | 

Optional: defines the number of elements per page (default (and max) is 1000)

 |
| 

disabletotal

(query)

 | 

Optional: disable total calculation to improve performance (default is false)

 |

| Code | Description | Links |
| --- | --- | --- |
| 200 | 
OK

Media type

Controls `Accept` header.

```
{
  "data": [
    {
      "id": "string",
      "url": "string",
      "projectId": "string",
      "modelId": "string"
    }
  ],
  "pageOffset": 0,
  "pageLimit": 0,
  "pageCount": 0,
  "total": 0,
  "truncatedResults": true,
  "truncatedReason": "string",
  "filterOptions": [
    {
      "isValueConcatenated": true,
      "data": "string",
      "options": [
        "string"
      ]
    }
  ],
  "links": {
    "additionalProp1": "string",
    "additionalProp2": "string",
    "additionalProp3": "string"
  }
}
```





 | _No links_ |
| 400 | 

Bad Request



 | _No links_ |
| 401 | 

Unauthorized



 | _No links_ |
| 404 | 

Not Found



 | _No links_ |
| 500 | 

Internal Server Error



 | _No links_ |

### Tables

| Name | Description |
| --- | --- |
| 
include

(query)

 | 

A comma delimited list of JSON properties to return. All remaining JSON properties will removed from the JSON response. Example: id, description, cutListItems. Specific dictionary keys can be included as follows: properties\["Family"\], propertiesGtp\["Material"\]

 |
| 

where

(query)

 | 

Filter on JSON property values. Example: To filter on two JSON properties: length eq '10' AND description == "truck". To get the last 30 days of data, use: createdDT ge DateTime.Now.AddDays(-30)

 |

| Code | Description | Links |
| --- | --- | --- |
| 200 | 
OK

Media type

Controls `Accept` header.

```
[
  {
    "companyTableId": "string",
    "createdById": "string",
    "createdByName": "string",
    "createdDT": "2026-01-29T03:23:21.296Z",
    "csvData": "string",
    "headers": [
      "string"
    ],
    "id": "string",
    "isCloneToProjectTableEnabled": true,
    "modifiedById": "string",
    "modifiedByName": "string",
    "modifiedDT": "2026-01-29T03:23:21.296Z",
    "name": "string",
    "notes": "string",
    "projectId": "string",
    "referencesCount": 0
  }
]
```





 | _No links_ |
| 400 | 

Bad Request



 | _No links_ |
| 401 | 

Unauthorized



 | _No links_ |
| 404 | 

Not Found



 | _No links_ |
| 500 | 

Internal Server Error



 | _No links_ |

| Name | Description |
| --- | --- |
| 
id \*

string

(path)

 | 

Table ID

 |
| 

include

(query)

 | 

A comma delimited list of JSON properties to return. All remaining JSON properties will removed from the JSON response. Example: id, description, cutListItems. Specific dictionary keys can be included as follows: properties\["Family"\], propertiesGtp\["Material"\]

 |

| Code | Description | Links |
| --- | --- | --- |
| 200 | 
OK

Media type

Controls `Accept` header.

```
{
  "companyTableId": "string",
  "createdById": "string",
  "createdByName": "string",
  "createdDT": "2026-01-29T03:23:21.333Z",
  "csvData": "string",
  "headers": [
    "string"
  ],
  "id": "string",
  "isCloneToProjectTableEnabled": true,
  "modifiedById": "string",
  "modifiedByName": "string",
  "modifiedDT": "2026-01-29T03:23:21.333Z",
  "name": "string",
  "notes": "string",
  "projectId": "string",
  "referencesCount": 0
}
```





 | _No links_ |
| 400 | 

Bad Request



 | _No links_ |
| 401 | 

Unauthorized



 | _No links_ |
| 404 | 

Not Found



 | _No links_ |
| 500 | 

Internal Server Error



 | _No links_ |

| Name | Description |
| --- | --- |
| 
id \*

string

(path)

 | 

Table ID

 |

| Code | Description | Links |
| --- | --- | --- |
| 200 | 
OK

Media type

Controls `Accept` header.

```
{}
```





 | _No links_ |
| 400 | 

Bad Request



 | _No links_ |
| 401 | 

Unauthorized



 | _No links_ |
| 404 | 

Not Found



 | _No links_ |
| 500 | 

Internal Server Error



 | _No links_ |

| Name | Description |
| --- | --- |
| 
projectId \*

string

(path)

 | 

Project ID

 |
| 

include

(query)

 | 

A comma delimited list of JSON properties to return. All remaining JSON properties will removed from the JSON response. Example: id, description, cutListItems. Specific dictionary keys can be included as follows: properties\["Family"\], propertiesGtp\["Material"\]

 |
| 

where

(query)

 | 

Filter on JSON property values. Example: To filter on two JSON properties: length eq '10' AND description == "truck". To get the last 30 days of data, use: createdDT ge DateTime.Now.AddDays(-30)

 |

| Code | Description | Links |
| --- | --- | --- |
| 200 | 
OK

Media type

Controls `Accept` header.

```
[
  {
    "companyTableId": "string",
    "createdById": "string",
    "createdByName": "string",
    "createdDT": "2026-01-29T03:23:21.400Z",
    "csvData": "string",
    "headers": [
      "string"
    ],
    "id": "string",
    "isCloneToProjectTableEnabled": true,
    "modifiedById": "string",
    "modifiedByName": "string",
    "modifiedDT": "2026-01-29T03:23:21.400Z",
    "name": "string",
    "notes": "string",
    "projectId": "string",
    "referencesCount": 0
  }
]
```





 | _No links_ |
| 400 | 

Bad Request



 | _No links_ |
| 401 | 

Unauthorized



 | _No links_ |
| 404 | 

Not Found



 | _No links_ |
| 500 | 

Internal Server Error



 | _No links_ |

| Name | Description |
| --- | --- |
| 
projectId \*

string

(path)

 | 

Project ID

 |
| 

id \*

string

(path)

 | 

Table ID

 |
| 

include

(query)

 | 

A comma delimited list of JSON properties to return. All remaining JSON properties will removed from the JSON response. Example: id, description, cutListItems. Specific dictionary keys can be included as follows: properties\["Family"\], propertiesGtp\["Material"\]

 |

| Code | Description | Links |
| --- | --- | --- |
| 200 | 
OK

Media type

Controls `Accept` header.

```
{
  "companyTableId": "string",
  "createdById": "string",
  "createdByName": "string",
  "createdDT": "2026-01-29T03:23:21.446Z",
  "csvData": "string",
  "headers": [
    "string"
  ],
  "id": "string",
  "isCloneToProjectTableEnabled": true,
  "modifiedById": "string",
  "modifiedByName": "string",
  "modifiedDT": "2026-01-29T03:23:21.446Z",
  "name": "string",
  "notes": "string",
  "projectId": "string",
  "referencesCount": 0
}
```





 | _No links_ |
| 400 | 

Bad Request



 | _No links_ |
| 401 | 

Unauthorized



 | _No links_ |
| 404 | 

Not Found



 | _No links_ |
| 500 | 

Internal Server Error



 | _No links_ |

| Name | Description |
| --- | --- |
| 
projectId \*

string

(path)

 | 

Project ID

 |
| 

id \*

string

(path)

 | 

Table ID

 |

| Code | Description | Links |
| --- | --- | --- |
| 200 | 
OK

Media type

Controls `Accept` header.

```
{}
```





 | _No links_ |
| 400 | 

Bad Request



 | _No links_ |
| 401 | 

Unauthorized



 | _No links_ |
| 404 | 

Not Found



 | _No links_ |
| 500 | 

Internal Server Error



 | _No links_ |

Table data

```
{
  "isReadOnly": true,
  "id": "string",
  "createdDT": "2026-01-29T03:23:21.527Z",
  "createdById": "string",
  "modifiedDT": "2026-01-29T03:23:21.527Z",
  "modifiedById": "string",
  "companyTableId": "string",
  "csvData": "string",
  "headers": [
    "string"
  ],
  "isCloneToProjectTableEnabled": true,
  "name": "string",
  "notes": "string",
  "projectId": "string"
}
```

| Code | Description | Links |
| --- | --- | --- |
| 200 | 
OK

Media type

Controls `Accept` header.

```
{
  "companyTableId": "string",
  "createdById": "string",
  "createdByName": "string",
  "createdDT": "2026-01-29T03:23:21.535Z",
  "csvData": "string",
  "headers": [
    "string"
  ],
  "id": "string",
  "isCloneToProjectTableEnabled": true,
  "modifiedById": "string",
  "modifiedByName": "string",
  "modifiedDT": "2026-01-29T03:23:21.535Z",
  "name": "string",
  "notes": "string",
  "projectId": "string",
  "referencesCount": 0
}
```





 | _No links_ |
| 400 | 

Bad Request



 | _No links_ |
| 401 | 

Unauthorized



 | _No links_ |
| 404 | 

Not Found



 | _No links_ |
| 500 | 

Internal Server Error



 | _No links_ |

| Name | Description |
| --- | --- |
| 
id \*

string

(path)

 | 

Table ID

 |

Column operation details

```
{
  "columnMappings": {
    "additionalProp1": 0,
    "additionalProp2": 0,
    "additionalProp3": 0
  },
  "columnName": "string",
  "defaultValue": "string",
  "index": 0,
  "operation": "1 = Add"
}
```

| Code | Description | Links |
| --- | --- | --- |
| 200 | 
OK

Media type

Controls `Accept` header.

```
{
  "companyTableId": "string",
  "createdById": "string",
  "createdByName": "string",
  "createdDT": "2026-01-29T03:23:21.585Z",
  "csvData": "string",
  "headers": [
    "string"
  ],
  "id": "string",
  "isCloneToProjectTableEnabled": true,
  "modifiedById": "string",
  "modifiedByName": "string",
  "modifiedDT": "2026-01-29T03:23:21.585Z",
  "name": "string",
  "notes": "string",
  "projectId": "string",
  "referencesCount": 0
}
```





 | _No links_ |
| 400 | 

Bad Request



 | _No links_ |
| 401 | 

Unauthorized



 | _No links_ |
| 404 | 

Not Found



 | _No links_ |
| 500 | 

Internal Server Error



 | _No links_ |

| Name | Description |
| --- | --- |
| 
id \*

string

(path)

 | 

Table ID

 |
| 

index

integer($int32)

(query)

 | 

Index where to insert the column

 |
| 

columnName

string

(query)

 | 

Name of the new column

 |
| 

defaultValue

string

(query)

 | 

Default value for the new column

_Default value_ :

 |

| Code | Description | Links |
| --- | --- | --- |
| 200 | 
OK

Media type

Controls `Accept` header.

```
{
  "companyTableId": "string",
  "createdById": "string",
  "createdByName": "string",
  "createdDT": "2026-01-29T03:23:21.639Z",
  "csvData": "string",
  "headers": [
    "string"
  ],
  "id": "string",
  "isCloneToProjectTableEnabled": true,
  "modifiedById": "string",
  "modifiedByName": "string",
  "modifiedDT": "2026-01-29T03:23:21.639Z",
  "name": "string",
  "notes": "string",
  "projectId": "string",
  "referencesCount": 0
}
```





 | _No links_ |
| 400 | 

Bad Request



 | _No links_ |
| 401 | 

Unauthorized



 | _No links_ |
| 404 | 

Not Found



 | _No links_ |
| 500 | 

Internal Server Error



 | _No links_ |

| Name | Description |
| --- | --- |
| 
projectId \*

string

(path)

 | 

Project ID

 |

Table data

```
{
  "isReadOnly": true,
  "id": "string",
  "createdDT": "2026-01-29T03:23:21.683Z",
  "createdById": "string",
  "modifiedDT": "2026-01-29T03:23:21.683Z",
  "modifiedById": "string",
  "companyTableId": "string",
  "csvData": "string",
  "headers": [
    "string"
  ],
  "isCloneToProjectTableEnabled": true,
  "name": "string",
  "notes": "string",
  "projectId": "string"
}
```

| Code | Description | Links |
| --- | --- | --- |
| 200 | 
OK

Media type

Controls `Accept` header.

```
{
  "companyTableId": "string",
  "createdById": "string",
  "createdByName": "string",
  "createdDT": "2026-01-29T03:23:21.691Z",
  "csvData": "string",
  "headers": [
    "string"
  ],
  "id": "string",
  "isCloneToProjectTableEnabled": true,
  "modifiedById": "string",
  "modifiedByName": "string",
  "modifiedDT": "2026-01-29T03:23:21.691Z",
  "name": "string",
  "notes": "string",
  "projectId": "string",
  "referencesCount": 0
}
```





 | _No links_ |
| 400 | 

Bad Request



 | _No links_ |
| 401 | 

Unauthorized



 | _No links_ |
| 404 | 

Not Found



 | _No links_ |
| 500 | 

Internal Server Error



 | _No links_ |

Updated table data

```
{
  "isReadOnly": true,
  "id": "string",
  "createdDT": "2026-01-29T03:23:21.727Z",
  "createdById": "string",
  "modifiedDT": "2026-01-29T03:23:21.727Z",
  "modifiedById": "string",
  "companyTableId": "string",
  "csvData": "string",
  "headers": [
    "string"
  ],
  "isCloneToProjectTableEnabled": true,
  "name": "string",
  "notes": "string",
  "projectId": "string"
}
```

| Code | Description | Links |
| --- | --- | --- |
| 200 | 
OK

Media type

Controls `Accept` header.

```
{
  "companyTableId": "string",
  "createdById": "string",
  "createdByName": "string",
  "createdDT": "2026-01-29T03:23:21.735Z",
  "csvData": "string",
  "headers": [
    "string"
  ],
  "id": "string",
  "isCloneToProjectTableEnabled": true,
  "modifiedById": "string",
  "modifiedByName": "string",
  "modifiedDT": "2026-01-29T03:23:21.735Z",
  "name": "string",
  "notes": "string",
  "projectId": "string",
  "referencesCount": 0
}
```





 | _No links_ |
| 400 | 

Bad Request



 | _No links_ |
| 401 | 

Unauthorized



 | _No links_ |
| 404 | 

Not Found



 | _No links_ |
| 500 | 

Internal Server Error



 | _No links_ |

| Name | Description |
| --- | --- |
| 
id \*

string

(path)

 | 

Table ID

 |
| 

index \*

integer($int32)

(path)

 | 

Index of the column to rename

 |
| 

newColumnName

string

(query)

 | 

New name for the column

 |

| Code | Description | Links |
| --- | --- | --- |
| 200 | 
OK

Media type

Controls `Accept` header.

```
{
  "companyTableId": "string",
  "createdById": "string",
  "createdByName": "string",
  "createdDT": "2026-01-29T03:23:21.782Z",
  "csvData": "string",
  "headers": [
    "string"
  ],
  "id": "string",
  "isCloneToProjectTableEnabled": true,
  "modifiedById": "string",
  "modifiedByName": "string",
  "modifiedDT": "2026-01-29T03:23:21.782Z",
  "name": "string",
  "notes": "string",
  "projectId": "string",
  "referencesCount": 0
}
```





 | _No links_ |
| 400 | 

Bad Request



 | _No links_ |
| 401 | 

Unauthorized



 | _No links_ |
| 404 | 

Not Found



 | _No links_ |
| 500 | 

Internal Server Error



 | _No links_ |

| Name | Description |
| --- | --- |
| 
id \*

string

(path)

 | 

Table ID

 |

Column mappings (new index -> old index)

```
{
  "additionalProp1": 0,
  "additionalProp2": 0,
  "additionalProp3": 0
}
```

| Code | Description | Links |
| --- | --- | --- |
| 200 | 
OK

Media type

Controls `Accept` header.

```
{
  "companyTableId": "string",
  "createdById": "string",
  "createdByName": "string",
  "createdDT": "2026-01-29T03:23:21.836Z",
  "csvData": "string",
  "headers": [
    "string"
  ],
  "id": "string",
  "isCloneToProjectTableEnabled": true,
  "modifiedById": "string",
  "modifiedByName": "string",
  "modifiedDT": "2026-01-29T03:23:21.836Z",
  "name": "string",
  "notes": "string",
  "projectId": "string",
  "referencesCount": 0
}
```





 | _No links_ |
| 400 | 

Bad Request



 | _No links_ |
| 401 | 

Unauthorized



 | _No links_ |
| 404 | 

Not Found



 | _No links_ |
| 500 | 

Internal Server Error



 | _No links_ |

| Name | Description |
| --- | --- |
| 
projectId \*

string

(path)

 | 

Project ID

 |

Updated table data

```
{
  "isReadOnly": true,
  "id": "string",
  "createdDT": "2026-01-29T03:23:21.884Z",
  "createdById": "string",
  "modifiedDT": "2026-01-29T03:23:21.884Z",
  "modifiedById": "string",
  "companyTableId": "string",
  "csvData": "string",
  "headers": [
    "string"
  ],
  "isCloneToProjectTableEnabled": true,
  "name": "string",
  "notes": "string",
  "projectId": "string"
}
```

| Code | Description | Links |
| --- | --- | --- |
| 200 | 
OK

Media type

Controls `Accept` header.

```
{
  "companyTableId": "string",
  "createdById": "string",
  "createdByName": "string",
  "createdDT": "2026-01-29T03:23:21.892Z",
  "csvData": "string",
  "headers": [
    "string"
  ],
  "id": "string",
  "isCloneToProjectTableEnabled": true,
  "modifiedById": "string",
  "modifiedByName": "string",
  "modifiedDT": "2026-01-29T03:23:21.892Z",
  "name": "string",
  "notes": "string",
  "projectId": "string",
  "referencesCount": 0
}
```





 | _No links_ |
| 400 | 

Bad Request



 | _No links_ |
| 401 | 

Unauthorized



 | _No links_ |
| 404 | 

Not Found



 | _No links_ |
| 500 | 

Internal Server Error



 | _No links_ |

| Name | Description |
| --- | --- |
| 
id \*

string

(path)

 | 

Table ID

 |

| Code | Description | Links |
| --- | --- | --- |
| 200 | 
OK

Media type

Controls `Accept` header.

```
true
```





 | _No links_ |
| 400 | 

Bad Request



 | _No links_ |
| 401 | 

Unauthorized



 | _No links_ |
| 404 | 

Not Found



 | _No links_ |
| 500 | 

Internal Server Error



 | _No links_ |

| Name | Description |
| --- | --- |
| 
id \*

string

(path)

 | 

Table ID

 |
| 

index \*

integer($int32)

(path)

 | 

Index of the column to remove

 |

| Code | Description | Links |
| --- | --- | --- |
| 200 | 
OK

Media type

Controls `Accept` header.

```
{
  "companyTableId": "string",
  "createdById": "string",
  "createdByName": "string",
  "createdDT": "2026-01-29T03:23:21.958Z",
  "csvData": "string",
  "headers": [
    "string"
  ],
  "id": "string",
  "isCloneToProjectTableEnabled": true,
  "modifiedById": "string",
  "modifiedByName": "string",
  "modifiedDT": "2026-01-29T03:23:21.958Z",
  "name": "string",
  "notes": "string",
  "projectId": "string",
  "referencesCount": 0
}
```





 | _No links_ |
| 400 | 

Bad Request



 | _No links_ |
| 401 | 

Unauthorized



 | _No links_ |
| 404 | 

Not Found



 | _No links_ |
| 500 | 

Internal Server Error



 | _No links_ |

| Name | Description |
| --- | --- |
| 
projectId \*

string

(path)

 | 

Project ID

 |

| Code | Description | Links |
| --- | --- | --- |
| 200 | 
OK

Media type

Controls `Accept` header.

```
0
```





 | _No links_ |
| 400 | 

Bad Request



 | _No links_ |
| 401 | 

Unauthorized



 | _No links_ |
| 404 | 

Not Found



 | _No links_ |
| 500 | 

Internal Server Error



 | _No links_ |

| Name | Description |
| --- | --- |
| 
projectId \*

string

(path)

 | 

Project ID

 |
| 

id \*

string

(path)

 | 

Table ID

 |

| Code | Description | Links |
| --- | --- | --- |
| 200 | 
OK

Media type

Controls `Accept` header.

```
true
```





 | _No links_ |
| 400 | 

Bad Request



 | _No links_ |
| 401 | 

Unauthorized



 | _No links_ |
| 404 | 

Not Found



 | _No links_ |
| 500 | 

Internal Server Error



 | _No links_ |

### Task

| Name | Description |
| --- | --- |
| 
include

(query)

 | 

A comma delimited list of JSON properties to return. All remaining JSON properties will removed from the JSON response. Example: id, description, cutListItems. Specific dictionary keys can be included as follows: properties\["Family"\], propertiesGtp\["Material"\]

 |
| 

where

(query)

 | 

Filter on JSON property values. Example: To filter on two JSON properties: length eq '10' AND description == "truck". To get the last 30 days of data, use: createdDT ge DateTime.Now.AddDays(-30)

 |
| 

page

(query)

 | 

Offset retrieves a given page of data, where 0 is the 1st page, etc (number of elements per page is set by PageSize below)

 |
| 

pagesize

(query)

 | 

Optional: defines the number of elements per page (default (and max) is 1000)

 |
| 

disabletotal

(query)

 | 

Optional: disable total calculation to improve performance (default is false)

 |

| Code | Description | Links |
| --- | --- | --- |
| 200 | 
OK

Media type

Controls `Accept` header.

```
{
  "data": [
    {
      "id": "string",
      "createdDT": "2026-01-29T03:23:22.088Z",
      "createdById": "string",
      "modifiedDT": "2026-01-29T03:23:22.088Z",
      "modifiedById": "string",
      "projectId": "string",
      "modelId": "string",
      "packageId": "string",
      "taskWorkflowId": "string",
      "taskDefinitionId": "string",
      "description": "string",
      "referenceType": "0 = Unspecified",
      "referenceTypeName": "string",
      "referenceId": "string",
      "referenceCadId": "string",
      "taskStatus": "string",
      "assignedUserId": "string",
      "assignedStationId": "string",
      "logEntries": [
        {
          "createdById": "string",
          "createdDT": "2026-01-29T03:23:22.088Z",
          "taskStatus": "string",
          "stationId": "string"
        }
      ]
    }
  ],
  "pageOffset": 0,
  "pageLimit": 0,
  "pageCount": 0,
  "total": 0,
  "truncatedResults": true,
  "truncatedReason": "string",
  "filterOptions": [
    {
      "isValueConcatenated": true,
      "data": "string",
      "options": [
        "string"
      ]
    }
  ],
  "links": {
    "additionalProp1": "string",
    "additionalProp2": "string",
    "additionalProp3": "string"
  }
}
```





 | _No links_ |
| 400 | 

Bad Request



 | _No links_ |
| 401 | 

Unauthorized



 | _No links_ |
| 404 | 

Not Found



 | _No links_ |
| 500 | 

Internal Server Error



 | _No links_ |

| Name | Description |
| --- | --- |
| 
id \*

string

(path)

 | 

STRATUS Task Id

 |

| Code | Description | Links |
| --- | --- | --- |
| 200 | 
OK

Media type

Controls `Accept` header.

```
{
  "id": "string",
  "createdDT": "2026-01-29T03:23:22.126Z",
  "createdById": "string",
  "modifiedDT": "2026-01-29T03:23:22.126Z",
  "modifiedById": "string",
  "projectId": "string",
  "modelId": "string",
  "packageId": "string",
  "taskWorkflowId": "string",
  "taskDefinitionId": "string",
  "description": "string",
  "referenceType": "0 = Unspecified",
  "referenceTypeName": "string",
  "referenceId": "string",
  "referenceCadId": "string",
  "taskStatus": "string",
  "assignedUserId": "string",
  "assignedStationId": "string",
  "logEntries": [
    {
      "createdById": "string",
      "createdDT": "2026-01-29T03:23:22.126Z",
      "taskStatus": "string",
      "stationId": "string"
    }
  ]
}
```





 | _No links_ |
| 400 | 

Bad Request



 | _No links_ |
| 401 | 

Unauthorized



 | _No links_ |
| 404 | 

Not Found



 | _No links_ |
| 500 | 

Internal Server Error



 | _No links_ |

| Name | Description |
| --- | --- |
| 
id \*

string

(path)

 | 

STRATUS Task Id

 |
| 

stationId

string

(query)

 | 

Optional Station Id to associate with Status update

 |
| 

taskStatusId

string

(query)

 | 

Required Task Status Id to assign to Task

 |

| Code | Description | Links |
| --- | --- | --- |
| 200 | 
OK

Media type

Controls `Accept` header.

```
true
```





 | _No links_ |
| 400 | 

Bad Request



 | _No links_ |
| 401 | 

Unauthorized



 | _No links_ |
| 404 | 

Not Found



 | _No links_ |
| 500 | 

Internal Server Error



 | _No links_ |

| Name | Description |
| --- | --- |
| 
toolId

string

(query)

 | 

STRATUS Tool Id

 |
| 

modelId

string

(query)

 | 

STRATUS Model Id

 |
| 

partCadId

string

(query)

 | 

STRATUS Part CadId

 |
| 

taskDefinitionId

string

(query)

 | 

STRATUS Task Definition Id

 |

| Code | Description | Links |
| --- | --- | --- |
| 200 | 
OK

Media type

Controls `Accept` header.

```
true
```





 | _No links_ |
| 400 | 

Bad Request



 | _No links_ |
| 401 | 

Unauthorized



 | _No links_ |
| 404 | 

Not Found



 | _No links_ |
| 500 | 

Internal Server Error



 | _No links_ |

| Name | Description |
| --- | --- |
| 
toolId

string

(query)

 | 

STRATUS Tool Id

 |
| 

modelId

string

(query)

 | 

STRATUS Model Id

 |
| 

partCadId

string

(query)

 | 

STRATUS Part CadId

 |
| 

taskDefinitionId

string

(query)

 | 

STRATUS Task Definition Id

 |

| Code | Description | Links |
| --- | --- | --- |
| 200 | 
OK

Media type

Controls `Accept` header.

```
true
```





 | _No links_ |
| 400 | 

Bad Request



 | _No links_ |
| 401 | 

Unauthorized



 | _No links_ |
| 404 | 

Not Found



 | _No links_ |
| 500 | 

Internal Server Error



 | _No links_ |

### TimeSession

| Name | Description |
| --- | --- |
| 
where

(query)

 | 

Filter on JSON property values. Example: To filter on two JSON properties: length eq '10' AND description == "truck". To get the last 30 days of data, use: createdDT ge DateTime.Now.AddDays(-30)

 |
| 

page

(query)

 | 

Offset retrieves a given page of data, where 0 is the 1st page, etc (number of elements per page is set by PageSize below)

 |
| 

pagesize

(query)

 | 

Optional: defines the number of elements per page (default (and max) is 1000)

 |
| 

disabletotal

(query)

 | 

Optional: disable total calculation to improve performance (default is false)

 |

| Code | Description | Links |
| --- | --- | --- |
| 200 | 
OK

Media type

Controls `Accept` header.

```
{
  "data": [
    {
      "isPartialData": true,
      "isReadOnly": true,
      "id": "string",
      "createdDT": "2026-01-29T03:23:22.312Z",
      "createdById": "string",
      "modifiedDT": "2026-01-29T03:23:22.312Z",
      "modifiedById": "string",
      "activityType": "0 = None",
      "activityTypeName": "string",
      "divisionId": "string",
      "divisionName": "string",
      "email": "string",
      "employeeId": "string",
      "firstName": "string",
      "isLocked": true,
      "lastName": "string",
      "modelId": "string",
      "modelName": "string",
      "packageCategoryId": "string",
      "packageCategoryName": "string",
      "packageDivisionId": "string",
      "packageDivisionName": "string",
      "packageId": "string",
      "packageName": "string",
      "packageNumber": "string",
      "projectId": "string",
      "projectName": "string",
      "projectNumber": "string",
      "shiftTypeId": "string",
      "startDT": "2026-01-29T03:23:22.312Z",
      "stationDivisionId": "string",
      "stationDivisionName": "string",
      "stationId": "string",
      "stationName": "string",
      "stopDT": "2026-01-29T03:23:22.312Z",
      "taskDefinitionId": "string",
      "userTypeName": "string",
      "workerId": "string"
    }
  ],
  "pageOffset": 0,
  "pageLimit": 0,
  "pageCount": 0,
  "total": 0,
  "truncatedResults": true,
  "truncatedReason": "string",
  "filterOptions": [
    {
      "isValueConcatenated": true,
      "data": "string",
      "options": [
        "string"
      ]
    }
  ],
  "links": {
    "additionalProp1": "string",
    "additionalProp2": "string",
    "additionalProp3": "string"
  }
}
```





 | _No links_ |
| 400 | 

Bad Request



 | _No links_ |
| 401 | 

Unauthorized



 | _No links_ |
| 404 | 

Not Found



 | _No links_ |
| 500 | 

Internal Server Error



 | _No links_ |

```
{
  "isLocked": true,
  "timeSessionIds": [
    "string"
  ]
}
```

| Code | Description | Links |
| --- | --- | --- |
| 200 | 
OK



 | _No links_ |
| 400 | 

Bad Request



 | _No links_ |
| 401 | 

Unauthorized



 | _No links_ |
| 404 | 

Not Found



 | _No links_ |
| 500 | 

Internal Server Error



 | _No links_ |

### TrackingLog

| Name | Description |
| --- | --- |
| 
include

(query)

 | 

A comma delimited list of JSON properties to return. All remaining JSON properties will removed from the JSON response. Example: id, description, cutListItems. Specific dictionary keys can be included as follows: properties\["Family"\], propertiesGtp\["Material"\]

 |
| 

where

(query)

 | 

Filter on JSON property values. Example: To filter on two JSON properties: length eq '10' AND description == "truck". To get the last 30 days of data, use: createdDT ge DateTime.Now.AddDays(-30)

 |
| 

page

(query)

 | 

Offset retrieves a given page of data, where 0 is the 1st page, etc (number of elements per page is set by PageSize below)

 |
| 

pagesize

(query)

 | 

Optional: defines the number of elements per page (default (and max) is 1000)

 |
| 

disabletotal

(query)

 | 

Optional: disable total calculation to improve performance (default is false)

 |

| Code | Description | Links |
| --- | --- | --- |
| 200 | 
OK

Media type

Controls `Accept` header.

```
{
  "data": [
    {
      "id": "string",
      "createdDT": "2026-01-29T03:23:22.694Z",
      "currentDivisionId": "string",
      "modifiedDT": "2026-01-29T03:23:22.694Z",
      "modelId": "string",
      "referenceType": "0 = Unspecified",
      "referenceName": "string",
      "referenceId": "string",
      "currentTrackingStatusId": "string",
      "totalHours": 0,
      "trackingLogEntries": [
        {
          "trackingStatusId": "string",
          "createdById": "string",
          "createdDT": "2026-01-29T03:23:22.694Z",
          "divisionId": "string",
          "id": "string",
          "origin": "0 = Unknown",
          "comment": "string",
          "hours": 0,
          "costTypeId": "string",
          "hoursCost": 0
        }
      ]
    }
  ],
  "pageOffset": 0,
  "pageLimit": 0,
  "pageCount": 0,
  "total": 0,
  "truncatedResults": true,
  "truncatedReason": "string",
  "filterOptions": [
    {
      "isValueConcatenated": true,
      "data": "string",
      "options": [
        "string"
      ]
    }
  ],
  "links": {
    "additionalProp1": "string",
    "additionalProp2": "string",
    "additionalProp3": "string"
  }
}
```





 | _No links_ |
| 400 | 

Bad Request



 | _No links_ |
| 401 | 

Unauthorized



 | _No links_ |
| 404 | 

Not Found



 | _No links_ |
| 500 | 

Internal Server Error



 | _No links_ |

| Code | Description | Links |
| --- | --- | --- |
| 200 | 
OK

Media type

Controls `Accept` header.

```
{
  "additionalProp1": "string",
  "additionalProp2": "string",
  "additionalProp3": "string"
}
```





 | _No links_ |
| 400 | 

Bad Request



 | _No links_ |
| 401 | 

Unauthorized



 | _No links_ |
| 404 | 

Not Found



 | _No links_ |
| 500 | 

Internal Server Error



 | _No links_ |

| Code | Description | Links |
| --- | --- | --- |
| 200 | 
OK

Media type

Controls `Accept` header.

```
{
  "additionalProp1": "string",
  "additionalProp2": "string",
  "additionalProp3": "string"
}
```





 | _No links_ |
| 400 | 

Bad Request



 | _No links_ |
| 401 | 

Unauthorized



 | _No links_ |
| 404 | 

Not Found



 | _No links_ |
| 500 | 

Internal Server Error



 | _No links_ |

### User

| Name | Description |
| --- | --- |
| 
id \*

string

(path)

 | 

STRATUS User Id

 |
| 

include

(query)

 | 

A comma delimited list of JSON properties to return. All remaining JSON properties will removed from the JSON response. Example: id, description, cutListItems. Specific dictionary keys can be included as follows: properties\["Family"\], propertiesGtp\["Material"\]

 |

| Code | Description | Links |
| --- | --- | --- |
| 200 | 
OK

Media type

Controls `Accept` header.

```
{
  "cellPhone": "string",
  "companyId": "string",
  "companyName": "string",
  "dateFormat": "string",
  "email": "string",
  "firstName": "string",
  "hourFormat": "string",
  "id": "string",
  "isCheckedIn": true,
  "isTimeTrackingEnabled": true,
  "lastName": "string",
  "lastViewedDateTimeForAssemblyId": {
    "additionalProp1": "2026-01-29T03:23:22.787Z",
    "additionalProp2": "2026-01-29T03:23:22.787Z",
    "additionalProp3": "2026-01-29T03:23:22.787Z"
  },
  "lastViewedDateTimeForModelId": {
    "additionalProp1": "2026-01-29T03:23:22.787Z",
    "additionalProp2": "2026-01-29T03:23:22.787Z",
    "additionalProp3": "2026-01-29T03:23:22.787Z"
  },
  "lastViewedDateTimeForPackageId": {
    "additionalProp1": "2026-01-29T03:23:22.787Z",
    "additionalProp2": "2026-01-29T03:23:22.787Z",
    "additionalProp3": "2026-01-29T03:23:22.787Z"
  },
  "longDateFormat": "string",
  "profileImageUrl": "string",
  "profileImageBase64": "string",
  "status": "1 = Active",
  "timeFormat": "string",
  "timeZoneInfoId": "string"
}
```





 | _No links_ |
| 400 | 

Bad Request



 | _No links_ |
| 401 | 

Unauthorized



 | _No links_ |
| 404 | 

Not Found



 | _No links_ |
| 500 | 

Internal Server Error



 | _No links_ |

| Name | Description |
| --- | --- |
| 
id \*

string

(path)

 | 

STRATUS User Id

 |

| Code | Description | Links |
| --- | --- | --- |
| 200 | 
OK

Media type

Controls `Accept` header.

```
{
  "userId": "string",
  "firstName": "string",
  "lastName": "string",
  "shortUrl": "string"
}
```





 | _No links_ |
| 400 | 

Bad Request



 | _No links_ |
| 401 | 

Unauthorized



 | _No links_ |
| 404 | 

Not Found



 | _No links_ |
| 500 | 

Internal Server Error



 | _No links_ |

| Name | Description |
| --- | --- |
| 
id \*

string

(path)

 | 

STRATUS User Id

 |

| Code | Description | Links |
| --- | --- | --- |
| 200 | 
OK

Media type

Controls `Accept` header.

```
[
  {
    "projectId": "string",
    "projectRoleTypeId": "string"
  }
]
```





 | _No links_ |
| 400 | 

Bad Request



 | _No links_ |
| 401 | 

Unauthorized



 | _No links_ |
| 404 | 

Not Found



 | _No links_ |
| 500 | 

Internal Server Error



 | _No links_ |

| Name | Description |
| --- | --- |
| 
include

(query)

 | 

A comma delimited list of JSON properties to return. All remaining JSON properties will removed from the JSON response. Example: id, description, cutListItems. Specific dictionary keys can be included as follows: properties\["Family"\], propertiesGtp\["Material"\]

 |
| 

where

(query)

 | 

Filter on JSON property values. Example: To filter on two JSON properties: length eq '10' AND description == "truck". To get the last 30 days of data, use: createdDT ge DateTime.Now.AddDays(-30)

 |
| 

page

(query)

 | 

Offset retrieves a given page of data, where 0 is the 1st page, etc (number of elements per page is set by PageSize below)

 |
| 

pagesize

(query)

 | 

Optional: defines the number of elements per page (default (and max) is 1000)

 |
| 

disabletotal

(query)

 | 

Optional: disable total calculation to improve performance (default is false)

 |

| Code | Description | Links |
| --- | --- | --- |
| 200 | 
OK

Media type

Controls `Accept` header.

```
{
  "data": [
    {
      "cellPhone": "string",
      "companyId": "string",
      "companyName": "string",
      "dateFormat": "string",
      "email": "string",
      "firstName": "string",
      "hourFormat": "string",
      "id": "string",
      "isCheckedIn": true,
      "isTimeTrackingEnabled": true,
      "lastName": "string",
      "lastViewedDateTimeForAssemblyId": {
        "additionalProp1": "2026-01-29T03:23:22.913Z",
        "additionalProp2": "2026-01-29T03:23:22.913Z",
        "additionalProp3": "2026-01-29T03:23:22.913Z"
      },
      "lastViewedDateTimeForModelId": {
        "additionalProp1": "2026-01-29T03:23:22.913Z",
        "additionalProp2": "2026-01-29T03:23:22.913Z",
        "additionalProp3": "2026-01-29T03:23:22.913Z"
      },
      "lastViewedDateTimeForPackageId": {
        "additionalProp1": "2026-01-29T03:23:22.913Z",
        "additionalProp2": "2026-01-29T03:23:22.913Z",
        "additionalProp3": "2026-01-29T03:23:22.913Z"
      },
      "longDateFormat": "string",
      "profileImageUrl": "string",
      "profileImageBase64": "string",
      "status": "1 = Active",
      "timeFormat": "string",
      "timeZoneInfoId": "string"
    }
  ],
  "pageOffset": 0,
  "pageLimit": 0,
  "pageCount": 0,
  "total": 0,
  "truncatedResults": true,
  "truncatedReason": "string",
  "filterOptions": [
    {
      "isValueConcatenated": true,
      "data": "string",
      "options": [
        "string"
      ]
    }
  ],
  "links": {
    "additionalProp1": "string",
    "additionalProp2": "string",
    "additionalProp3": "string"
  }
}
```





 | _No links_ |
| 400 | 

Bad Request



 | _No links_ |
| 401 | 

Unauthorized



 | _No links_ |
| 404 | 

Not Found



 | _No links_ |
| 500 | 

Internal Server Error



 | _No links_ |

| Name | Description |
| --- | --- |
| 
email \*

string

(path)

 |  |
| 

include

(query)

 | 

A comma delimited list of JSON properties to return. All remaining JSON properties will removed from the JSON response. Example: id, description, cutListItems. Specific dictionary keys can be included as follows: properties\["Family"\], propertiesGtp\["Material"\]

 |

| Code | Description | Links |
| --- | --- | --- |
| 200 | 
OK

Media type

Controls `Accept` header.

```
{
  "cellPhone": "string",
  "companyId": "string",
  "companyName": "string",
  "dateFormat": "string",
  "email": "string",
  "firstName": "string",
  "hourFormat": "string",
  "id": "string",
  "isCheckedIn": true,
  "isTimeTrackingEnabled": true,
  "lastName": "string",
  "lastViewedDateTimeForAssemblyId": {
    "additionalProp1": "2026-01-29T03:23:22.949Z",
    "additionalProp2": "2026-01-29T03:23:22.949Z",
    "additionalProp3": "2026-01-29T03:23:22.949Z"
  },
  "lastViewedDateTimeForModelId": {
    "additionalProp1": "2026-01-29T03:23:22.949Z",
    "additionalProp2": "2026-01-29T03:23:22.949Z",
    "additionalProp3": "2026-01-29T03:23:22.949Z"
  },
  "lastViewedDateTimeForPackageId": {
    "additionalProp1": "2026-01-29T03:23:22.949Z",
    "additionalProp2": "2026-01-29T03:23:22.949Z",
    "additionalProp3": "2026-01-29T03:23:22.949Z"
  },
  "longDateFormat": "string",
  "profileImageUrl": "string",
  "profileImageBase64": "string",
  "status": "1 = Active",
  "timeFormat": "string",
  "timeZoneInfoId": "string"
}
```





 | _No links_ |
| 400 | 

Bad Request



 | _No links_ |
| 401 | 

Unauthorized



 | _No links_ |
| 404 | 

Not Found



 | _No links_ |
| 500 | 

Internal Server Error



 | _No links_ |

| Name | Description |
| --- | --- |
| 
id \*

string

(path)

 | 

STRATUS User Id

 |

```
{
  "projectId": "string",
  "projectRoleTypeId": "string"
}
```

| Code | Description | Links |
| --- | --- | --- |
| 200 | 
OK

Media type

Controls `Accept` header.

```
{
  "projectId": "string",
  "projectRoleTypeId": "string"
}
```





 | _No links_ |
| 400 | 

Bad Request



 | _No links_ |
| 401 | 

Unauthorized



 | _No links_ |
| 404 | 

Not Found



 | _No links_ |
| 500 | 

Internal Server Error



 | _No links_ |

| Name | Description |
| --- | --- |
| 
id \*

string

(path)

 | 

STRATUS User Id

 |

```
{
  "projectId": "string",
  "projectRoleTypeId": "string"
}
```

| Code | Description | Links |
| --- | --- | --- |
| 200 | 
OK

Media type

Controls `Accept` header.

```
{
  "projectId": "string",
  "projectRoleTypeId": "string"
}
```





 | _No links_ |
| 400 | 

Bad Request



 | _No links_ |
| 401 | 

Unauthorized



 | _No links_ |
| 404 | 

Not Found



 | _No links_ |
| 500 | 

Internal Server Error



 | _No links_ |

| Name | Description |
| --- | --- |
| 
id \*

string

(path)

 |  |

```
{
  "cellPhone": "string",
  "companyId": "string",
  "companyName": "string",
  "dateFormat": "string",
  "email": "string",
  "firstName": "string",
  "hourFormat": "string",
  "id": "string",
  "isCheckedIn": true,
  "isTimeTrackingEnabled": true,
  "lastName": "string",
  "lastViewedDateTimeForAssemblyId": {
    "additionalProp1": "2026-01-29T03:23:23.085Z",
    "additionalProp2": "2026-01-29T03:23:23.085Z",
    "additionalProp3": "2026-01-29T03:23:23.085Z"
  },
  "lastViewedDateTimeForModelId": {
    "additionalProp1": "2026-01-29T03:23:23.085Z",
    "additionalProp2": "2026-01-29T03:23:23.085Z",
    "additionalProp3": "2026-01-29T03:23:23.085Z"
  },
  "lastViewedDateTimeForPackageId": {
    "additionalProp1": "2026-01-29T03:23:23.085Z",
    "additionalProp2": "2026-01-29T03:23:23.085Z",
    "additionalProp3": "2026-01-29T03:23:23.085Z"
  },
  "longDateFormat": "string",
  "profileImageUrl": "string",
  "profileImageBase64": "string",
  "status": "1 = Active",
  "timeFormat": "string",
  "timeZoneInfoId": "string"
}
```

| Code | Description | Links |
| --- | --- | --- |
| 202 | 
Accepted

Media type

Controls `Accept` header.

```
{
  "cellPhone": "string",
  "companyId": "string",
  "companyName": "string",
  "dateFormat": "string",
  "email": "string",
  "firstName": "string",
  "hourFormat": "string",
  "id": "string",
  "isCheckedIn": true,
  "isTimeTrackingEnabled": true,
  "lastName": "string",
  "lastViewedDateTimeForAssemblyId": {
    "additionalProp1": "2026-01-29T03:23:23.092Z",
    "additionalProp2": "2026-01-29T03:23:23.092Z",
    "additionalProp3": "2026-01-29T03:23:23.092Z"
  },
  "lastViewedDateTimeForModelId": {
    "additionalProp1": "2026-01-29T03:23:23.092Z",
    "additionalProp2": "2026-01-29T03:23:23.092Z",
    "additionalProp3": "2026-01-29T03:23:23.092Z"
  },
  "lastViewedDateTimeForPackageId": {
    "additionalProp1": "2026-01-29T03:23:23.092Z",
    "additionalProp2": "2026-01-29T03:23:23.092Z",
    "additionalProp3": "2026-01-29T03:23:23.092Z"
  },
  "longDateFormat": "string",
  "profileImageUrl": "string",
  "profileImageBase64": "string",
  "status": "1 = Active",
  "timeFormat": "string",
  "timeZoneInfoId": "string"
}
```





 | _No links_ |
| 400 | 

Bad Request



 | _No links_ |
| 401 | 

Unauthorized



 | _No links_ |
| 404 | 

Not Found



 | _No links_ |
| 500 | 

Internal Server Error



 | _No links_ |

| Name | Description |
| --- | --- |
| 
id \*

string

(path)

 | 

STRATUS User Id

 |
| 

projectId \*

string

(path)

 | 

STRATUS Project Id

 |

| Code | Description | Links |
| --- | --- | --- |
| 200 | 
OK

Media type

Controls `Accept` header.

```
true
```





 | _No links_ |
| 400 | 

Bad Request



 | _No links_ |
| 401 | 

Unauthorized



 | _No links_ |
| 404 | 

Not Found



 | _No links_ |
| 500 | 

Internal Server Error



 | _No links_ |

### Version

| Code | Description | Links |
| --- | --- | --- |
| 200 | 
OK

Media type

Controls `Accept` header.

```
"string"
```





 | _No links_ |
| 400 | 

Bad Request



 | _No links_ |
| 401 | 

Unauthorized



 | _No links_ |
| 404 | 

Not Found



 | _No links_ |
| 500 | 

Internal Server Error



 | _No links_ |

### API Health

| Code | Description | Links |
| --- | --- | --- |
| 200 | 
Health description

Media type

Controls `Accept` header.

```
{
  "status": "string",
  "totalDuration": "string",
  "entries": {}
}
```





 | _No links_ |

integer($int32)Enum:  

{

<table><tbody><tr><td>id<span>*</span></td><td><span><span></span></span></td></tr><tr><td>createdDT</td><td><span><span></span></span></td></tr><tr><td>createdById</td><td><span><span></span></span></td></tr><tr><td>createdByName</td><td><span><span></span></span></td></tr><tr><td>divisionId</td><td><span><span></span></span></td></tr><tr><td>divisionName</td><td><span><span></span></span></td></tr><tr><td>route</td><td><span><span></span></span></td></tr><tr><td>projectId</td><td><span><span></span></span></td></tr><tr><td>projectName</td><td><span><span></span></span></td></tr><tr><td>projectNumber</td><td><span><span></span></span></td></tr><tr><td>projectColor</td><td><span><span></span></span></td></tr><tr><td>modelId</td><td><span><span></span></span></td></tr><tr><td>modelName</td><td><span><span></span></span></td></tr><tr><td>reference</td><td><span><span></span></span></td></tr><tr><td>referenceId</td><td><span><span></span></span></td></tr><tr><td>referenceName</td><td><span><span></span></span></td></tr><tr><td>action</td><td><span><span></span></span></td></tr><tr><td>actionName</td><td><span><span></span></span></td></tr><tr><td>name</td><td><span><span></span></span></td></tr><tr><td>value</td><td><span><span></span></span></td></tr><tr><td>trackingStatusId</td><td><span><span></span></span></td></tr><tr><td>trackingStatusName</td><td><span><span></span></span></td></tr><tr><td>trackingStatusColor</td><td><span><span></span></span></td></tr><tr><td>stationId</td><td><span><span></span></span></td></tr><tr><td>stationName</td><td><span><span></span></span></td></tr></tbody></table>

}

{

<table><tbody><tr><td>data</td><td><span><span></span></span></td></tr><tr><td>pageOffset</td><td><span><span></span></span></td></tr><tr><td>pageLimit</td><td><span><span></span></span></td></tr><tr><td>pageCount</td><td><span><span></span></span></td></tr><tr><td>total</td><td><span><span></span></span></td></tr><tr><td>truncatedResults</td><td><span><span></span></span></td></tr><tr><td>truncatedReason</td><td><span><span></span></span></td></tr><tr><td>filterOptions</td><td><span><span></span></span></td></tr><tr><td>links</td><td><span><span></span><span><br>nullable: true</span></span></td></tr></tbody></table>

}

integer($int32)Enum:  

{

<table><tbody><tr><td>id</td><td><span><span></span></span></td></tr><tr><td>projectId</td><td><span><span></span></span></td></tr><tr><td>modelId</td><td><span><span></span></span></td></tr><tr><td>stratusDimensionType</td><td><span><span></span></span></td></tr><tr><td>orderId</td><td><span><span></span></span></td></tr><tr><td>assemblyId</td><td><span><span></span></span></td></tr><tr><td>partCadIds</td><td><span><span></span></span></td></tr><tr><td>colorIndex</td><td><span><span></span></span></td></tr><tr><td>dimensionLineType</td><td><span><span></span></span></td></tr><tr><td>connectedAssemblyId</td><td><span><span></span></span></td></tr><tr><td>distance</td><td><span><span></span></span></td></tr><tr><td>label</td><td><span><span></span></span></td></tr><tr><td>lineVertices</td><td><span><span></span></span></td></tr><tr><td>location</td><td><span><span></span></span></td></tr><tr><td>gridlineAnnotation</td><td><span><span></span></span></td></tr><tr><td>dimensionAnchorTypes</td><td><span><span></span></span></td></tr></tbody></table>

}

{

<table><tbody><tr><td>abbreviation</td><td><span><span></span></span></td></tr><tr><td>children</td><td><span><span></span></span></td></tr><tr><td>code</td><td><span><span></span></span></td></tr><tr><td>color</td><td><span><span></span></span></td></tr><tr><td>createdById</td><td><span><span></span></span></td></tr><tr><td>createdDT</td><td><span><span></span></span></td></tr><tr><td>elevation</td><td><span><span></span></span></td></tr><tr><td>id</td><td><span><span></span></span></td></tr><tr><td>levelBottomOffset</td><td><span><span></span></span></td></tr><tr><td>levelTopOffset</td><td><span><span></span></span></td></tr><tr><td>modifiedById</td><td><span><span></span></span></td></tr><tr><td>modifiedDT</td><td><span><span></span></span></td></tr><tr><td>name</td><td><span><span></span></span></td></tr><tr><td>parentId</td><td><span><span></span></span></td></tr></tbody></table>

}

{

<table><tbody><tr><td>id</td><td><span><span></span></span></td></tr><tr><td>createdDT</td><td><span><span></span></span></td></tr><tr><td>modifiedDT</td><td><span><span></span></span></td></tr><tr><td>projectId</td><td><span><span></span></span></td></tr><tr><td>modelId</td><td><span><span></span></span></td></tr><tr><td>cadId</td><td><span><span></span></span></td></tr><tr><td>sheetId</td><td><span><span></span></span></td></tr><tr><td>viewId</td><td><span><span></span></span></td></tr><tr><td>isViewIdOverridden</td><td><span><span></span></span></td></tr><tr><td>currentTrackingStatusId</td><td><span><span></span></span></td></tr><tr><td>currentDivisionId</td><td><span><span></span></span></td></tr><tr><td>assemblyType</td><td><span><span></span></span></td></tr><tr><td>assemblyTypeLabel</td><td><span><span></span></span></td></tr><tr><td>excludedCadIds</td><td><span><span></span></span></td></tr><tr><td>fieldIdToValueMap</td><td><span><span></span><span><br>nullable: true</span></span></td></tr><tr><td>fieldNameToValueMap</td><td><span><span></span><span><br>nullable: true</span></span></td></tr><tr><td>name</td><td><span><span></span></span></td></tr><tr><td>nameLabel</td><td><span><span></span></span></td></tr><tr><td>partIds</td><td><span><span></span></span></td></tr><tr><td>instanceIndex</td><td><span><span></span></span></td></tr><tr><td>lastUsedAssembliesPartsTableReportId</td><td><span><span></span></span></td></tr><tr><td>lastUsedAssembliesPartsTableReportIds</td><td><span><span></span></span></td></tr><tr><td>qrCodeUrl</td><td><span><span></span></span></td></tr><tr><td>notes</td><td><span><span></span></span></td></tr><tr><td>defaultOrientationForReportTemplatesForgeViewerViewJson</td><td><span><span></span><span><br>nullable: true</span></span></td></tr></tbody></table>

}

{

<table><tbody><tr><td>data</td><td><span><span></span></span></td></tr><tr><td>pageOffset</td><td><span><span></span></span></td></tr><tr><td>pageLimit</td><td><span><span></span></span></td></tr><tr><td>pageCount</td><td><span><span></span></span></td></tr><tr><td>total</td><td><span><span></span></span></td></tr><tr><td>truncatedResults</td><td><span><span></span></span></td></tr><tr><td>truncatedReason</td><td><span><span></span></span></td></tr><tr><td>filterOptions</td><td><span><span></span></span></td></tr><tr><td>links</td><td><span><span></span><span><br>nullable: true</span></span></td></tr></tbody></table>

}

{

<table><tbody><tr><td>cadId</td><td><span><span></span></span></td></tr><tr><td>createdByUserEmail</td><td><span><span></span></span></td></tr><tr><td>id</td><td><span><span></span></span></td></tr><tr><td>initialTrackingStatusId</td><td><span><span></span></span></td></tr><tr><td>name<span>*</span></td><td><span><span></span></span></td></tr></tbody></table>

}

integer($int32)Enum:  

{

<table><tbody><tr><td>isPartialData</td><td><span><span></span></span></td></tr><tr><td>isReadOnly</td><td><span><span></span></span></td></tr><tr><td>id<span>*</span></td><td><span><span></span></span></td></tr><tr><td>createdDT</td><td><span><span></span></span></td></tr><tr><td>createdById</td><td><span><span></span></span></td></tr><tr><td>modifiedDT</td><td><span><span></span></span></td></tr><tr><td>modifiedById</td><td><span><span></span></span></td></tr><tr><td>fabConfigName</td><td><span><span></span></span></td></tr><tr><td>fabFileGroupId</td><td><span><span></span></span></td></tr><tr><td>fabLocaleId</td><td><span><span></span></span></td></tr><tr><td>fabProfileName</td><td><span><span></span></span></td></tr><tr><td>fabUnitType</td><td><span><span></span></span></td></tr><tr><td>fileByteCount</td><td><span><span></span></span></td></tr><tr><td>fileName<span>*</span></td><td><span><span></span></span></td></tr><tr><td>fileType</td><td><span><span></span></span></td></tr><tr><td>fileUploadTimeInSeconds</td><td><span><span></span></span></td></tr><tr><td>isCollaboration</td><td><span><span></span></span></td></tr><tr><td>isMarkups</td><td><span><span></span></span></td></tr><tr><td>isPrimaryModel</td><td><span><span></span></span></td></tr><tr><td>itemIdBase64URN</td><td><span><span></span></span></td></tr><tr><td>itemId<span>*</span></td><td><span><span></span></span></td></tr><tr><td>itemLink<span>*</span></td><td><span><span></span></span></td></tr><tr><td>localFilePath</td><td><span><span></span></span></td></tr><tr><td>modelId</td><td><span><span></span></span></td></tr><tr><td>overriddenRemoteFolder</td><td><span><span></span></span></td></tr><tr><td>parentAttachmentId</td><td><span><span></span></span></td></tr><tr><td>previewImageFileId</td><td><span><span></span></span></td></tr><tr><td>previousVersions</td><td><span><span></span><span><br>nullable: true</span></span></td></tr><tr><td>projectId<span>*</span></td><td><span><span></span></span></td></tr><tr><td>referenceId<span>*</span></td><td><span><span></span></span></td></tr><tr><td>referenceType<span>*</span></td><td><span><span></span></span></td></tr><tr><td>role</td><td><span><span></span></span></td></tr><tr><td>totalTransformationMatrix</td><td><span><span></span></span></td></tr></tbody></table>

}

{

<table><tbody><tr><td>id</td><td><span><span></span></span></td></tr><tr><td>createdById</td><td><span><span></span></span></td></tr><tr><td>createdDT</td><td><span><span></span></span></td></tr><tr><td>projectId</td><td><span><span></span></span></td></tr><tr><td>modelId</td><td><span><span></span></span></td></tr><tr><td>referenceType</td><td><span><span></span></span></td></tr><tr><td>referenceName</td><td><span><span></span></span></td></tr><tr><td>referenceId</td><td><span><span></span></span></td></tr><tr><td>role</td><td><span><span></span></span></td></tr><tr><td>roleName</td><td><span><span></span></span></td></tr><tr><td>fileType</td><td><span><span></span></span></td></tr><tr><td>fileTypeName</td><td><span><span></span></span></td></tr><tr><td>localFilePath</td><td><span><span></span></span></td></tr><tr><td>fileName</td><td><span><span></span></span></td></tr><tr><td>overriddenRemoteFolder</td><td><span><span></span></span></td></tr></tbody></table>

}

{

<table><tbody><tr><td>data</td><td><span><span></span></span></td></tr><tr><td>pageOffset</td><td><span><span></span></span></td></tr><tr><td>pageLimit</td><td><span><span></span></span></td></tr><tr><td>pageCount</td><td><span><span></span></span></td></tr><tr><td>total</td><td><span><span></span></span></td></tr><tr><td>truncatedResults</td><td><span><span></span></span></td></tr><tr><td>truncatedReason</td><td><span><span></span></span></td></tr><tr><td>filterOptions</td><td><span><span></span></span></td></tr><tr><td>links</td><td><span><span></span><span><br>nullable: true</span></span></td></tr></tbody></table>

}

{

<table><tbody><tr><td>bytes</td><td><span><span></span></span></td></tr><tr><td>contentType</td><td><span><span></span></span></td></tr><tr><td>fileName</td><td><span><span></span></span></td></tr><tr><td>localPath</td><td><span><span></span></span></td></tr></tbody></table>

}

integer($int32)Enum:  

integer($int32)Enum:  

{

<table><tbody><tr><td>id</td><td><span><span></span></span></td></tr><tr><td>divisionId</td><td><span><span></span></span></td></tr><tr><td>projectId</td><td><span><span></span></span></td></tr><tr><td>modelId</td><td><span><span></span></span></td></tr><tr><td>packageId<span>*</span></td><td><span><span></span></span></td></tr><tr><td>requiredDT</td><td><span><span></span></span></td></tr><tr><td>isLocked</td><td><span><span></span></span></td></tr><tr><td>generatedDT</td><td><span><span></span></span></td></tr><tr><td>generatedByName</td><td><span><span></span></span></td></tr><tr><td>lockedDT</td><td><span><span></span></span></td></tr><tr><td>lockedByName</td><td><span><span></span></span></td></tr><tr><td>unlockedDT</td><td><span><span></span></span></td></tr><tr><td>unlockedByName</td><td><span><span></span></span></td></tr><tr><td>lineItems</td><td><span><span></span></span></td></tr></tbody></table>

}

{

<table><tbody><tr><td>groupedPartCadIds</td><td><span><span></span></span></td></tr><tr><td>sequence</td><td><span><span></span></span></td></tr><tr><td>isModeled</td><td><span><span></span></span></td></tr><tr><td>isReportable</td><td><span><span></span></span></td></tr><tr><td>isConsolidated</td><td><span><span></span></span></td></tr><tr><td>manufacturer</td><td><span><span></span></span></td></tr><tr><td>quantity</td><td><span><span></span></span></td></tr><tr><td>size</td><td><span><span></span></span></td></tr><tr><td>description<span>*</span></td><td><span><span></span></span></td></tr><tr><td>material</td><td><span><span></span></span></td></tr><tr><td>productCode</td><td><span><span></span></span></td></tr><tr><td>diameter</td><td><span><span></span></span></td></tr><tr><td>width</td><td><span><span></span></span></td></tr><tr><td>length</td><td><span><span></span></span></td></tr><tr><td>isLengthNestable</td><td><span><span></span></span></td></tr><tr><td>nominalStockLength</td><td><span><span></span></span></td></tr><tr><td>additionalProperty</td><td><span><span></span></span></td></tr><tr><td>unitOfMeasure</td><td><span><span></span></span></td></tr><tr><td>unitOfMeasureName</td><td><span><span></span></span></td></tr><tr><td>comment</td><td><span><span></span></span></td></tr><tr><td>notPurchased</td><td><span><span></span></span></td></tr><tr><td>isAncillary</td><td><span><span></span></span></td></tr><tr><td>serviceName</td><td><span><span></span></span></td></tr><tr><td>serviceCode</td><td><span><span></span></span></td></tr><tr><td>possibleSupplierCodes</td><td><span><span></span><span><br>nullable: true</span></span></td></tr></tbody></table>

}

{

<table><tbody><tr><td>id</td><td><span><span></span></span></td></tr><tr><td>name</td><td><span><span></span></span></td></tr><tr><td>description</td><td><span><span></span></span></td></tr><tr><td>abbreviation</td><td><span><span></span></span></td></tr><tr><td>useAssemblies</td><td><span><span></span></span></td></tr><tr><td>useContainers</td><td><span><span></span></span></td></tr></tbody></table>

}

{

<table><tbody><tr><td>id</td><td><span><span></span></span></td></tr><tr><td>name</td><td><span><span></span></span></td></tr><tr><td>description</td><td><span><span></span></span></td></tr><tr><td>length</td><td><span><span></span></span></td></tr><tr><td>width</td><td><span><span></span></span></td></tr><tr><td>height</td><td><span><span></span></span></td></tr><tr><td>location</td><td><span><span></span></span></td></tr><tr><td>containerTypeName</td><td><span><span></span></span></td></tr><tr><td>parentContainerId</td><td><span><span></span></span></td></tr><tr><td>currentTrackingStatusId</td><td><span><span></span></span></td></tr><tr><td>currentDivisionId</td><td><span><span></span></span></td></tr><tr><td>qrCodeUrl</td><td><span><span></span></span></td></tr><tr><td>fieldIdToValueMap</td><td><span><span></span><span><br>nullable: true</span></span></td></tr><tr><td>partIds</td><td><span><span></span></span></td></tr><tr><td>assemblyCadIds</td><td><span><span></span></span></td></tr><tr><td>packageIds</td><td><span><span></span></span></td></tr><tr><td>containerIds</td><td><span><span></span></span></td></tr><tr><td>contents</td><td><span><span></span></span></td></tr></tbody></table>

}

{

<table><tbody><tr><td>data</td><td><span><span></span></span></td></tr><tr><td>pageOffset</td><td><span><span></span></span></td></tr><tr><td>pageLimit</td><td><span><span></span></span></td></tr><tr><td>pageCount</td><td><span><span></span></span></td></tr><tr><td>total</td><td><span><span></span></span></td></tr><tr><td>truncatedResults</td><td><span><span></span></span></td></tr><tr><td>truncatedReason</td><td><span><span></span></span></td></tr><tr><td>filterOptions</td><td><span><span></span></span></td></tr><tr><td>links</td><td><span><span></span><span><br>nullable: true</span></span></td></tr></tbody></table>

}

{

<table><tbody><tr><td>projectId</td><td><span><span></span></span></td></tr><tr><td>referenceId</td><td><span><span></span></span></td></tr><tr><td>referenceType</td><td><span><span></span></span></td></tr></tbody></table>

}

{}

{

<table><tbody><tr><td>id</td><td><span><span></span></span></td></tr><tr><td>name</td><td><span><span></span></span></td></tr><tr><td>code</td><td><span><span></span></span></td></tr><tr><td>color</td><td><span><span></span></span></td></tr><tr><td>hourlyRate</td><td><span><span></span></span></td></tr></tbody></table>

}

{

<table><tbody><tr><td>name</td><td><span><span></span></span></td></tr><tr><td>description</td><td><span><span></span></span></td></tr><tr><td>containerTypeId</td><td><span><span></span></span></td></tr><tr><td>divisionId</td><td><span><span></span></span></td></tr><tr><td>length</td><td><span><span></span></span></td></tr><tr><td>width</td><td><span><span></span></span></td></tr><tr><td>height</td><td><span><span></span></span></td></tr><tr><td>location</td><td><span><span></span></span></td></tr></tbody></table>

}

{

<table><tbody><tr><td>id</td><td><span><span></span></span></td></tr><tr><td>completedDT</td><td><span><span></span></span></td></tr><tr><td>createdDT</td><td><span><span></span></span></td></tr><tr><td>createdById</td><td><span><span></span></span></td></tr><tr><td>modifiedDT</td><td><span><span></span></span></td></tr><tr><td>modifiedById</td><td><span><span></span></span></td></tr><tr><td>cutListItems</td><td><span><span></span></span></td></tr><tr><td>cutListItemCount</td><td><span><span></span></span></td></tr><tr><td>cutListStatus</td><td><span><span></span></span></td></tr><tr><td>cutListStatusLabel</td><td><span><span></span></span></td></tr><tr><td>cutListStatusName</td><td><span><span></span></span></td></tr><tr><td>isAutoGeneratedCutList</td><td><span><span></span></span></td></tr><tr><td>material</td><td><span><span></span></span></td></tr><tr><td>modelId</td><td><span><span></span></span></td></tr><tr><td>name</td><td><span><span></span></span></td></tr><tr><td>packageId</td><td><span><span></span></span></td></tr><tr><td>percentComplete</td><td><span><span></span></span></td></tr><tr><td>projectId</td><td><span><span></span></span></td></tr><tr><td>requestedDT</td><td><span><span></span></span></td></tr><tr><td>requestedUserId</td><td><span><span></span></span></td></tr><tr><td>size</td><td><span><span></span></span></td></tr><tr><td>startedDT</td><td><span><span></span></span></td></tr><tr><td>stationId</td><td><span><span></span></span></td></tr><tr><td>totalLengthInInches</td><td><span><span></span></span></td></tr><tr><td>totalLengthInFeetAndInches</td><td><span><span></span></span></td></tr></tbody></table>

}

{

<table><tbody><tr><td>data</td><td><span><span></span></span></td></tr><tr><td>pageOffset</td><td><span><span></span></span></td></tr><tr><td>pageLimit</td><td><span><span></span></span></td></tr><tr><td>pageCount</td><td><span><span></span></span></td></tr><tr><td>total</td><td><span><span></span></span></td></tr><tr><td>truncatedResults</td><td><span><span></span></span></td></tr><tr><td>truncatedReason</td><td><span><span></span></span></td></tr><tr><td>filterOptions</td><td><span><span></span></span></td></tr><tr><td>links</td><td><span><span></span><span><br>nullable: true</span></span></td></tr></tbody></table>

}

{

<table><tbody><tr><td>area</td><td><span><span></span></span></td></tr><tr><td>assemblyId</td><td><span><span></span></span></td></tr><tr><td>assemblyName</td><td><span><span></span></span></td></tr><tr><td>index</td><td><span><span></span></span></td></tr><tr><td>cadId</td><td><span><span></span></span></td></tr><tr><td>cutDateTime</td><td><span><span></span></span></td></tr><tr><td>description</td><td><span><span></span></span></td></tr><tr><td>itemNumber</td><td><span><span></span></span></td></tr><tr><td>lengthInInches</td><td><span><span></span></span></td></tr><tr><td>lengthInFeetAndInches</td><td><span><span></span></span></td></tr><tr><td>level</td><td><span><span></span></span></td></tr><tr><td>preFabId</td><td><span><span></span></span></td></tr><tr><td>qrCode</td><td><span><span></span></span></td></tr><tr><td>userData1</td><td><span><span></span></span></td></tr><tr><td>userData2</td><td><span><span></span></span></td></tr><tr><td>userData3</td><td><span><span></span></span></td></tr><tr><td>userData4</td><td><span><span></span></span></td></tr><tr><td>userData5</td><td><span><span></span></span></td></tr><tr><td>userData6</td><td><span><span></span></span></td></tr><tr><td>userData7</td><td><span><span></span></span></td></tr><tr><td>userData8</td><td><span><span></span></span></td></tr><tr><td>userData9</td><td><span><span></span></span></td></tr><tr><td>userData10</td><td><span><span></span></span></td></tr><tr><td>userData11</td><td><span><span></span></span></td></tr><tr><td>userData12</td><td><span><span></span></span></td></tr><tr><td>userData13</td><td><span><span></span></span></td></tr><tr><td>userData14</td><td><span><span></span></span></td></tr><tr><td>userData15</td><td><span><span></span></span></td></tr></tbody></table>

}

integer($int32)Enum:  

integer($int32)Enum:  

{}

integer($int32)Enum:  

{

<table><tbody><tr><td>id</td><td><span><span></span></span></td></tr><tr><td>name</td><td><span><span></span></span></td></tr><tr><td>trackingStatusGroupId</td><td><span><span></span></span></td></tr><tr><td>trackingStatusGroupName</td><td><span><span></span></span></td></tr></tbody></table>

}

{

<table><tbody><tr><td>createdDT</td><td><span><span></span></span></td></tr><tr><td>dataType</td><td><span><span></span></span></td></tr><tr><td>dataTypeName</td><td><span><span></span></span></td></tr><tr><td>defaultValue</td><td><span><span></span></span></td></tr><tr><td>description</td><td><span><span></span></span></td></tr><tr><td>displayName</td><td><span><span></span></span></td></tr><tr><td>expression</td><td><span><span></span></span></td></tr><tr><td>filterId</td><td><span><span></span></span></td></tr><tr><td>id</td><td><span><span></span></span></td></tr><tr><td>isEditable</td><td><span><span></span></span></td></tr><tr><td>isExpression</td><td><span><span></span></span></td></tr><tr><td>isTotal</td><td><span><span></span></span></td></tr><tr><td>modifiedDT</td><td><span><span></span></span></td></tr><tr><td>name</td><td><span><span></span></span></td></tr><tr><td>possibleValues</td><td><span><span></span></span></td></tr><tr><td>unit</td><td><span><span></span></span></td></tr></tbody></table>

}

integer($int32)Enum:  

{}

{

<table><tbody><tr><td>isValueConcatenated</td><td><span><span></span></span></td></tr><tr><td>data</td><td><span><span></span></span></td></tr><tr><td>options</td><td><span><span></span></span></td></tr></tbody></table>

}

{

<table><tbody><tr><td>createdById</td><td><span><span></span></span></td></tr><tr><td>createdDT</td><td><span><span></span></span></td></tr><tr><td>gridIntersections</td><td><span><span></span></span></td></tr><tr><td>gridLines</td><td><span><span></span></span></td></tr><tr><td>id</td><td><span><span></span></span></td></tr><tr><td>modelId</td><td><span><span></span></span></td></tr><tr><td>modifiedById</td><td><span><span></span></span></td></tr><tr><td>modifiedDT</td><td><span><span></span></span></td></tr><tr><td>name</td><td><span><span></span></span></td></tr></tbody></table>

}

{

<table><tbody><tr><td>horizontalAnnotation</td><td><span><span></span></span></td></tr><tr><td>horizontalDirection</td><td><span><span></span></span></td></tr><tr><td>horizontalGridLineId</td><td><span><span></span></span></td></tr><tr><td>intersectionPoint</td><td><span><span></span></span></td></tr><tr><td>verticalAnnotation</td><td><span><span></span></span></td></tr><tr><td>verticalDirection</td><td><span><span></span></span></td></tr><tr><td>verticalGridLineId</td><td><span><span></span></span></td></tr></tbody></table>

}

{

<table><tbody><tr><td>annotation</td><td><span><span></span></span></td></tr><tr><td>gridLineType</td><td><span><span></span></span></td></tr><tr><td>id</td><td><span><span></span></span></td></tr><tr><td>linePoints</td><td><span><span></span></span></td></tr></tbody></table>

}

integer($int32)Enum:  

{

<table><tbody><tr><td>status</td><td><span><span></span></span></td></tr><tr><td>totalDuration</td><td><span><span></span></span></td></tr><tr><td>entries</td><td><span><span></span></span></td></tr></tbody></table>

}

{

<table><tbody><tr><td>isPartialData</td><td><span><span></span></span></td></tr><tr><td>isReadOnly</td><td><span><span></span></span></td></tr><tr><td>id<span>*</span></td><td><span><span></span></span></td></tr><tr><td>createdDT</td><td><span><span></span></span></td></tr><tr><td>createdById</td><td><span><span></span></span></td></tr><tr><td>modifiedDT</td><td><span><span></span></span></td></tr><tr><td>modifiedById</td><td><span><span></span></span></td></tr><tr><td>companyTableId</td><td><span><span></span></span></td></tr><tr><td>csvData</td><td><span><span></span></span></td></tr><tr><td>headers</td><td><span><span></span></span></td></tr><tr><td>isCloneToProjectTableEnabled</td><td><span><span></span></span></td></tr><tr><td>name<span>*</span></td><td><span><span></span></span></td></tr><tr><td>notes</td><td><span><span></span></span></td></tr><tr><td>projectId</td><td><span><span></span></span></td></tr></tbody></table>

}

integer($int32)Enum:  

{

<table><tbody><tr><td>a360FolderId</td><td><span><span></span></span></td></tr><tr><td>createdDT</td><td><span><span></span></span></td></tr><tr><td>databaseUnits</td><td><span><span></span></span></td></tr><tr><td>defaultViewId</td><td><span><span></span></span></td></tr><tr><td>id</td><td><span><span></span></span></td></tr><tr><td>isFieldOrderz</td><td><span><span></span></span></td></tr><tr><td>lastPublishedDT</td><td><span><span></span></span></td></tr><tr><td>modelName</td><td><span><span></span></span></td></tr><tr><td>modelType</td><td><span><span></span></span></td></tr><tr><td>modifiedDT</td><td><span><span></span></span></td></tr><tr><td>name</td><td><span><span></span></span></td></tr><tr><td>projectId</td><td><span><span></span></span></td></tr><tr><td>publishStatus</td><td><span><span></span></span></td></tr><tr><td>releaseVersion</td><td><span><span></span></span></td></tr></tbody></table>

}

{

<table><tbody><tr><td>data</td><td><span><span></span></span></td></tr><tr><td>pageOffset</td><td><span><span></span></span></td></tr><tr><td>pageLimit</td><td><span><span></span></span></td></tr><tr><td>pageCount</td><td><span><span></span></span></td></tr><tr><td>total</td><td><span><span></span></span></td></tr><tr><td>truncatedResults</td><td><span><span></span></span></td></tr><tr><td>truncatedReason</td><td><span><span></span></span></td></tr><tr><td>filterOptions</td><td><span><span></span></span></td></tr><tr><td>links</td><td><span><span></span><span><br>nullable: true</span></span></td></tr></tbody></table>

}

integer($int32)Enum:  

{

<table><tbody><tr><td>id</td><td><span><span></span></span></td></tr><tr><td>name</td><td><span><span></span></span></td></tr><tr><td>viewRole</td><td><span><span></span></span></td></tr><tr><td>autodeskViewId</td><td><span><span></span></span></td></tr></tbody></table>

}

{

<table><tbody><tr><td>assemblyName</td><td><span><span></span></span></td></tr><tr><td>packageName</td><td><span><span></span></span></td></tr><tr><td>packageNumber</td><td><span><span></span></span></td></tr><tr><td>purchaseNumber</td><td><span><span></span></span></td></tr></tbody></table>

}

{

<table><tbody><tr><td>createdById</td><td><span><span></span></span></td></tr><tr><td>createdDT</td><td><span><span></span></span></td></tr><tr><td>divisionId</td><td><span><span></span></span></td></tr><tr><td>employeeId</td><td><span><span></span></span></td></tr><tr><td>firstName</td><td><span><span></span></span></td></tr><tr><td>id</td><td><span><span></span></span></td></tr><tr><td>isCheckedIn</td><td><span><span></span></span></td></tr><tr><td>isTimeTrackingEnabled</td><td><span><span></span></span></td></tr><tr><td>lastName</td><td><span><span></span></span></td></tr><tr><td>modifiedById</td><td><span><span></span></span></td></tr><tr><td>modifiedDT</td><td><span><span></span></span></td></tr><tr><td>status</td><td><span><span></span></span></td></tr></tbody></table>

}

{

<table><tbody><tr><td>isPartialData</td><td><span><span></span></span></td></tr><tr><td>isReadOnly</td><td><span><span></span></span></td></tr><tr><td>id<span>*</span></td><td><span><span></span></span></td></tr><tr><td>createdDT</td><td><span><span></span></span></td></tr><tr><td>createdById</td><td><span><span></span></span></td></tr><tr><td>modifiedDT</td><td><span><span></span></span></td></tr><tr><td>modifiedById</td><td><span><span></span></span></td></tr><tr><td>name</td><td><span><span></span></span></td></tr></tbody></table>

}

integer($int32)Enum:  

{

<table><tbody><tr><td>assemblyIds</td><td><span><span></span></span></td></tr><tr><td>bimAreaId</td><td><span><span></span></span></td></tr><tr><td>bimAreaName</td><td><span><span></span></span></td></tr><tr><td>assemblyCadIds</td><td><span><span></span></span></td></tr><tr><td>cadIdsBySequence</td><td><span><span></span></span></td></tr><tr><td>categoryId</td><td><span><span></span></span></td></tr><tr><td>createdBy</td><td><span><span></span></span></td></tr><tr><td>createdDT</td><td><span><span></span></span></td></tr><tr><td>currentTrackingStatusId</td><td><span><span></span></span></td></tr><tr><td>currentDivisionId</td><td><span><span></span></span></td></tr><tr><td>description</td><td><span><span></span></span></td></tr><tr><td>fieldIdToValueMap</td><td><span><span></span><span><br>nullable: true</span></span></td></tr><tr><td>fieldNameToValueMap</td><td><span><span></span><span><br>nullable: true</span></span></td></tr><tr><td>hoursEstimatedField</td><td><span><span></span></span></td></tr><tr><td>hoursEstimatedOffice</td><td><span><span></span></span></td></tr><tr><td>hoursEstimatedPurchasing</td><td><span><span></span></span></td></tr><tr><td>hoursEstimatedShop</td><td><span><span></span></span></td></tr><tr><td>id</td><td><span><span></span></span></td></tr><tr><td>installedDT</td><td><span><span></span></span></td></tr><tr><td>modelId</td><td><span><span></span></span></td></tr><tr><td>modifiedBy</td><td><span><span></span></span></td></tr><tr><td>modifiedDT</td><td><span><span></span></span></td></tr><tr><td>name</td><td><span><span></span></span></td></tr><tr><td>number</td><td><span><span></span></span></td></tr><tr><td>officeDuration</td><td><span><span></span></span></td></tr><tr><td>officeStartDT</td><td><span><span></span></span></td></tr><tr><td>partCadIds</td><td><span><span></span></span></td></tr><tr><td>projectId</td><td><span><span></span></span></td></tr><tr><td>purchasingDuration</td><td><span><span></span></span></td></tr><tr><td>purchasingStartDT</td><td><span><span></span></span></td></tr><tr><td>qrCodeUrl</td><td><span><span></span></span></td></tr><tr><td>requiredDT</td><td><span><span></span></span></td></tr><tr><td>selectedTaskWorkflowIdsForAssemblyAndPartCadIds</td><td><span><span></span><span><br>nullable: true</span></span></td></tr><tr><td>shopDuration</td><td><span><span></span></span></td></tr><tr><td>startDT</td><td><span><span></span></span></td></tr><tr><td>status</td><td><span><span></span></span></td></tr><tr><td>statusName</td><td><span><span></span></span></td></tr><tr><td>viewId</td><td><span><span></span></span></td></tr><tr><td>isViewIdOverridden</td><td><span><span></span></span></td></tr></tbody></table>

}

{

<table><tbody><tr><td>data</td><td><span><span></span></span></td></tr><tr><td>pageOffset</td><td><span><span></span></span></td></tr><tr><td>pageLimit</td><td><span><span></span></span></td></tr><tr><td>pageCount</td><td><span><span></span></span></td></tr><tr><td>total</td><td><span><span></span></span></td></tr><tr><td>truncatedResults</td><td><span><span></span></span></td></tr><tr><td>truncatedReason</td><td><span><span></span></span></td></tr><tr><td>filterOptions</td><td><span><span></span></span></td></tr><tr><td>links</td><td><span><span></span><span><br>nullable: true</span></span></td></tr></tbody></table>

}

{

<table><tbody><tr><td>categoryId</td><td><span><span></span></span></td></tr><tr><td>description</td><td><span><span></span></span></td></tr><tr><td>hoursEstimatedField</td><td><span><span></span></span></td></tr><tr><td>hoursEstimatedOffice</td><td><span><span></span></span></td></tr><tr><td>hoursEstimatedPurchasing</td><td><span><span></span></span></td></tr><tr><td>hoursEstimatedShop</td><td><span><span></span></span></td></tr><tr><td>id<span>*</span></td><td><span><span></span></span></td></tr><tr><td>installedDT</td><td><span><span></span></span></td></tr><tr><td>name</td><td><span><span></span></span></td></tr><tr><td>number</td><td><span><span></span></span></td></tr><tr><td>officeDuration</td><td><span><span></span></span></td></tr><tr><td>officeStartDT</td><td><span><span></span></span></td></tr><tr><td>purchasingDuration</td><td><span><span></span></span></td></tr><tr><td>purchasingStartDT</td><td><span><span></span></span></td></tr><tr><td>requiredDT</td><td><span><span></span></span></td></tr><tr><td>shopDuration</td><td><span><span></span></span></td></tr><tr><td>startDT</td><td><span><span></span></span></td></tr><tr><td>status</td><td><span><span></span></span></td></tr></tbody></table>

}

{

<table><tbody><tr><td>areaId</td><td><span><span></span></span></td></tr><tr><td>categoryId<span>*</span></td><td><span><span></span></span></td></tr><tr><td>createdByUserEmail</td><td><span><span></span></span></td></tr><tr><td>description</td><td><span><span></span></span></td></tr><tr><td>initialTrackingStatusId</td><td><span><span></span></span></td></tr><tr><td>name<span>*</span></td><td><span><span></span></span></td></tr><tr><td>number</td><td><span><span></span></span></td></tr><tr><td>orderNameFOZ</td><td><span><span></span></span></td></tr></tbody></table>

}

{

<table><tbody><tr><td>id</td><td><span><span></span></span></td></tr><tr><td>createdDT</td><td><span><span></span></span></td></tr><tr><td>modifiedDT</td><td><span><span></span></span></td></tr><tr><td>cutDT</td><td><span><span></span></span></td></tr><tr><td>projectId</td><td><span><span></span></span></td></tr><tr><td>projectName</td><td><span><span></span></span></td></tr><tr><td>projectNumber</td><td><span><span></span></span></td></tr><tr><td>modelId</td><td><span><span></span></span></td></tr><tr><td>modelName</td><td><span><span></span></span></td></tr><tr><td>bimAreaId</td><td><span><span></span></span></td></tr><tr><td>bimArea</td><td><span><span></span></span></td></tr><tr><td>cadId</td><td><span><span></span></span></td></tr><tr><td>cadType</td><td><span><span></span></span></td></tr><tr><td>webId</td><td><span><span></span></span></td></tr><tr><td>description</td><td><span><span></span></span></td></tr><tr><td>currentTrackingStatusId</td><td><span><span></span></span></td></tr><tr><td>currentDivisionId</td><td><span><span></span></span></td></tr><tr><td>properties</td><td><span><span></span><span><br>nullable: true</span></span></td></tr><tr><td>propertiesGtp</td><td><span><span></span><span><br>nullable: true</span></span></td></tr><tr><td>points</td><td><span><span></span></span></td></tr><tr><td>cutLengthAdjustment</td><td><span><span></span></span></td></tr><tr><td>cutLength2Adjustment</td><td><span><span></span></span></td></tr><tr><td>lockLength</td><td><span><span></span></span></td></tr><tr><td>lockLocation</td><td><span><span></span></span></td></tr><tr><td>qrCodeUrl</td><td><span><span></span></span></td></tr><tr><td>partUrl</td><td><span><span></span></span></td></tr><tr><td>patternNumber</td><td><span><span></span></span></td></tr><tr><td>source</td><td><span><span></span></span></td></tr><tr><td>fieldIdToValueMap</td><td><span><span></span><span><br>nullable: true</span></span></td></tr><tr><td>fieldNameToValueMap</td><td><span><span></span><span><br>nullable: true</span></span></td></tr></tbody></table>

}

{

<table><tbody><tr><td>data</td><td><span><span></span></span></td></tr><tr><td>pageOffset</td><td><span><span></span></span></td></tr><tr><td>pageLimit</td><td><span><span></span></span></td></tr><tr><td>pageCount</td><td><span><span></span></span></td></tr><tr><td>total</td><td><span><span></span></span></td></tr><tr><td>truncatedResults</td><td><span><span></span></span></td></tr><tr><td>truncatedReason</td><td><span><span></span></span></td></tr><tr><td>filterOptions</td><td><span><span></span></span></td></tr><tr><td>links</td><td><span><span></span><span><br>nullable: true</span></span></td></tr></tbody></table>

}

{

<table><tbody><tr><td>pointType</td><td><span><span></span></span></td></tr><tr><td>cadId</td><td><span><span></span></span></td></tr><tr><td>location</td><td><span><span></span></span></td></tr><tr><td>direction</td><td><span><span></span></span></td></tr><tr><td>upVector</td><td><span><span></span></span></td></tr><tr><td>width</td><td><span><span></span></span></td></tr><tr><td>height</td><td><span><span></span></span></td></tr><tr><td>matingElementUniqueId</td><td><span><span></span></span></td></tr></tbody></table>

}

integer($int32)Enum:  

{

<table><tbody><tr><td>id</td><td><span><span></span></span></td></tr><tr><td>properties</td><td><span><span></span><span><br>nullable: true</span></span></td></tr></tbody></table>

}

integer($int32)Enum:  

{}

{

<table><tbody><tr><td>id</td><td><span><span></span></span></td></tr><tr><td>createdDT</td><td><span><span></span></span></td></tr><tr><td>modifiedDT</td><td><span><span></span></span></td></tr><tr><td>status</td><td><span><span></span></span></td></tr><tr><td>statusName</td><td><span><span></span></span></td></tr><tr><td>a360Id</td><td><span><span></span></span></td></tr><tr><td>a360RootFolderId</td><td><span><span></span></span></td></tr><tr><td>companyId</td><td><span><span></span></span></td></tr><tr><td>category</td><td><span><span></span></span></td></tr><tr><td>number</td><td><span><span></span></span></td></tr><tr><td>name</td><td><span><span></span></span></td></tr><tr><td>phase</td><td><span><span></span></span></td></tr><tr><td>description</td><td><span><span></span></span></td></tr><tr><td>imageAttachmentId</td><td><span><span></span></span></td></tr><tr><td>address1</td><td><span><span></span></span></td></tr><tr><td>address2</td><td><span><span></span></span></td></tr><tr><td>city</td><td><span><span></span></span></td></tr><tr><td>state</td><td><span><span></span></span></td></tr><tr><td>zip</td><td><span><span></span></span></td></tr><tr><td>targetStartDate</td><td><span><span></span></span></td></tr><tr><td>actualStartDate</td><td><span><span></span></span></td></tr><tr><td>targetEndDate</td><td><span><span></span></span></td></tr><tr><td>actualEndDate</td><td><span><span></span></span></td></tr><tr><td>color</td><td><span><span></span></span></td></tr><tr><td>isTaxExempt</td><td><span><span></span></span></td></tr></tbody></table>

}

{

<table><tbody><tr><td>data</td><td><span><span></span></span></td></tr><tr><td>pageOffset</td><td><span><span></span></span></td></tr><tr><td>pageLimit</td><td><span><span></span></span></td></tr><tr><td>pageCount</td><td><span><span></span></span></td></tr><tr><td>total</td><td><span><span></span></span></td></tr><tr><td>truncatedResults</td><td><span><span></span></span></td></tr><tr><td>truncatedReason</td><td><span><span></span></span></td></tr><tr><td>filterOptions</td><td><span><span></span></span></td></tr><tr><td>links</td><td><span><span></span><span><br>nullable: true</span></span></td></tr></tbody></table>

}

{

<table><tbody><tr><td>projectId</td><td><span><span></span></span></td></tr><tr><td>projectRoleTypeId</td><td><span><span></span></span></td></tr></tbody></table>

}

{}

{

<table><tbody><tr><td>source</td><td><span><span></span></span></td></tr><tr><td>name</td><td><span><span></span></span></td></tr><tr><td>code</td><td><span><span></span></span></td></tr><tr><td>abbreviation</td><td><span><span></span></span></td></tr><tr><td>group</td><td><span><span></span></span></td></tr><tr><td>fabConfigId</td><td><span><span></span></span></td></tr><tr><td>fabServiceId</td><td><span><span></span></span></td></tr><tr><td>fabServiceSpecId</td><td><span><span></span></span></td></tr><tr><td>fabServiceInsulationSpecId</td><td><span><span></span></span></td></tr></tbody></table>

}

{

<table><tbody><tr><td>data</td><td><span><span></span></span></td></tr><tr><td>pageOffset</td><td><span><span></span></span></td></tr><tr><td>pageLimit</td><td><span><span></span></span></td></tr><tr><td>pageCount</td><td><span><span></span></span></td></tr><tr><td>total</td><td><span><span></span></span></td></tr><tr><td>truncatedResults</td><td><span><span></span></span></td></tr><tr><td>truncatedReason</td><td><span><span></span></span></td></tr><tr><td>filterOptions</td><td><span><span></span></span></td></tr><tr><td>links</td><td><span><span></span><span><br>nullable: true</span></span></td></tr></tbody></table>

}

integer($int32)Enum:  

integer($int32)Enum:  

{

<table><tbody><tr><td>id</td><td><span><span></span></span></td></tr><tr><td>name</td><td><span><span></span></span></td></tr><tr><td>number</td><td><span><span></span></span></td></tr><tr><td>description</td><td><span><span></span></span></td></tr><tr><td>statusName</td><td><span><span></span></span></td></tr><tr><td>supplierName</td><td><span><span></span></span></td></tr><tr><td>supplierResponseNumber</td><td><span><span></span></span></td></tr><tr><td>tax</td><td><span><span></span></span></td></tr><tr><td>freight</td><td><span><span></span></span></td></tr><tr><td>totalAmount</td><td><span><span></span></span></td></tr><tr><td>projectId</td><td><span><span></span></span></td></tr><tr><td>lineItems</td><td><span><span></span></span></td></tr></tbody></table>

}

{

<table><tbody><tr><td>data</td><td><span><span></span></span></td></tr><tr><td>pageOffset</td><td><span><span></span></span></td></tr><tr><td>pageLimit</td><td><span><span></span></span></td></tr><tr><td>pageCount</td><td><span><span></span></span></td></tr><tr><td>total</td><td><span><span></span></span></td></tr><tr><td>truncatedResults</td><td><span><span></span></span></td></tr><tr><td>truncatedReason</td><td><span><span></span></span></td></tr><tr><td>filterOptions</td><td><span><span></span></span></td></tr><tr><td>links</td><td><span><span></span><span><br>nullable: true</span></span></td></tr></tbody></table>

}

{

<table><tbody><tr><td>additionalProperty</td><td><span><span></span></span></td></tr><tr><td>ancillaryType</td><td><span><span></span></span></td></tr><tr><td>ancillaryUsageType</td><td><span><span></span></span></td></tr><tr><td>backorderedQTY</td><td><span><span></span></span></td></tr><tr><td>comment</td><td><span><span></span></span></td></tr><tr><td>description</td><td><span><span></span></span></td></tr><tr><td>diameter</td><td><span><span></span></span></td></tr><tr><td>isAncillary</td><td><span><span></span></span></td></tr><tr><td>isModeled</td><td><span><span></span></span></td></tr><tr><td>length</td><td><span><span></span></span></td></tr><tr><td>lineNumber</td><td><span><span></span></span></td></tr><tr><td>manufacturer</td><td><span><span></span></span></td></tr><tr><td>material</td><td><span><span></span></span></td></tr><tr><td>nominalStockLength</td><td><span><span></span></span></td></tr><tr><td>orderedQTY</td><td><span><span></span></span></td></tr><tr><td>partTemplateName</td><td><span><span></span></span></td></tr><tr><td>productCode</td><td><span><span></span></span></td></tr><tr><td>quotedQTY</td><td><span><span></span></span></td></tr><tr><td>serviceCode</td><td><span><span></span></span></td></tr><tr><td>serviceName</td><td><span><span></span></span></td></tr><tr><td>shippedQTY</td><td><span><span></span></span></td></tr><tr><td>size</td><td><span><span></span></span></td></tr><tr><td>totalPrice</td><td><span><span></span></span></td></tr><tr><td>unitOfMeasure</td><td><span><span></span></span></td></tr><tr><td>unitPrice</td><td><span><span></span></span></td></tr><tr><td>width</td><td><span><span></span></span></td></tr></tbody></table>

}

{}

{}

{

<table><tbody><tr><td>userId</td><td><span><span></span></span></td></tr><tr><td>firstName</td><td><span><span></span></span></td></tr><tr><td>lastName</td><td><span><span></span></span></td></tr><tr><td>shortUrl</td><td><span><span></span></span></td></tr></tbody></table>

}

integer($int32)Enum:  

{

<table><tbody><tr><td>id</td><td><span><span></span></span></td></tr><tr><td>name</td><td><span><span></span></span></td></tr><tr><td>formatTypeName</td><td><span><span></span></span></td></tr><tr><td>itemTypeName</td><td><span><span></span></span></td></tr></tbody></table>

}

integer($int32)Enum:  

{}

{

<table><tbody><tr><td>data</td><td><span><span></span></span></td></tr><tr><td>pageOffset</td><td><span><span></span></span></td></tr><tr><td>pageLimit</td><td><span><span></span></span></td></tr><tr><td>pageCount</td><td><span><span></span></span></td></tr><tr><td>total</td><td><span><span></span></span></td></tr><tr><td>truncatedResults</td><td><span><span></span></span></td></tr><tr><td>truncatedReason</td><td><span><span></span></span></td></tr><tr><td>filterOptions</td><td><span><span></span></span></td></tr><tr><td>links</td><td><span><span></span><span><br>nullable: true</span></span></td></tr></tbody></table>

}

{

<table><tbody><tr><td>id</td><td><span><span></span></span></td></tr><tr><td>name</td><td><span><span></span></span></td></tr><tr><td>description</td><td><span><span></span></span></td></tr><tr><td>divisionId</td><td><span><span></span></span></td></tr><tr><td>toolId</td><td><span><span></span></span></td></tr><tr><td>imageFileId</td><td><span><span></span></span></td></tr><tr><td>managedMaterials</td><td><span><span></span></span></td></tr><tr><td>managedMaterialsValues</td><td><span><span></span></span></td></tr><tr><td>taskDefinitionIds</td><td><span><span></span></span></td></tr></tbody></table>

}

integer($int32)Enum:  

{}

{

<table><tbody><tr><td>columnMappings</td><td><span><span></span><span><br>nullable: true</span></span></td></tr><tr><td>columnName</td><td><span><span></span></span></td></tr><tr><td>defaultValue</td><td><span><span></span></span></td></tr><tr><td>index</td><td><span><span></span></span></td></tr><tr><td>operation</td><td><span><span></span></span></td></tr></tbody></table>

}

integer($int32)Enum:  

{

<table><tbody><tr><td>companyTableId</td><td><span><span></span></span></td></tr><tr><td>createdById</td><td><span><span></span></span></td></tr><tr><td>createdByName</td><td><span><span></span></span></td></tr><tr><td>createdDT</td><td><span><span></span></span></td></tr><tr><td>csvData</td><td><span><span></span></span></td></tr><tr><td>headers</td><td><span><span></span></span></td></tr><tr><td>id</td><td><span><span></span></span></td></tr><tr><td>isCloneToProjectTableEnabled</td><td><span><span></span></span></td></tr><tr><td>modifiedById</td><td><span><span></span></span></td></tr><tr><td>modifiedByName</td><td><span><span></span></span></td></tr><tr><td>modifiedDT</td><td><span><span></span></span></td></tr><tr><td>name</td><td><span><span></span></span></td></tr><tr><td>notes</td><td><span><span></span></span></td></tr><tr><td>projectId</td><td><span><span></span></span></td></tr><tr><td>referencesCount</td><td><span><span></span></span></td></tr></tbody></table>

}

{

<table><tbody><tr><td>id</td><td><span><span></span></span></td></tr><tr><td>createdDT</td><td><span><span></span></span></td></tr><tr><td>createdById</td><td><span><span></span></span></td></tr><tr><td>modifiedDT</td><td><span><span></span></span></td></tr><tr><td>modifiedById</td><td><span><span></span></span></td></tr><tr><td>projectId</td><td><span><span></span></span></td></tr><tr><td>modelId</td><td><span><span></span></span></td></tr><tr><td>packageId</td><td><span><span></span></span></td></tr><tr><td>taskWorkflowId</td><td><span><span></span></span></td></tr><tr><td>taskDefinitionId</td><td><span><span></span></span></td></tr><tr><td>description</td><td><span><span></span></span></td></tr><tr><td>referenceType</td><td><span><span></span></span></td></tr><tr><td>referenceTypeName</td><td><span><span></span></span></td></tr><tr><td>referenceId</td><td><span><span></span></span></td></tr><tr><td>referenceCadId</td><td><span><span></span></span></td></tr><tr><td>taskStatus</td><td><span><span></span></span></td></tr><tr><td>assignedUserId</td><td><span><span></span></span></td></tr><tr><td>assignedStationId</td><td><span><span></span></span></td></tr><tr><td>logEntries</td><td><span><span></span></span></td></tr></tbody></table>

}

{

<table><tbody><tr><td>data</td><td><span><span></span></span></td></tr><tr><td>pageOffset</td><td><span><span></span></span></td></tr><tr><td>pageLimit</td><td><span><span></span></span></td></tr><tr><td>pageCount</td><td><span><span></span></span></td></tr><tr><td>total</td><td><span><span></span></span></td></tr><tr><td>truncatedResults</td><td><span><span></span></span></td></tr><tr><td>truncatedReason</td><td><span><span></span></span></td></tr><tr><td>filterOptions</td><td><span><span></span></span></td></tr><tr><td>links</td><td><span><span></span><span><br>nullable: true</span></span></td></tr></tbody></table>

}

{

<table><tbody><tr><td>applyToPackageCategoryId</td><td><span><span></span></span></td></tr><tr><td>autoComplete</td><td><span><span></span></span></td></tr><tr><td>color</td><td><span><span></span></span></td></tr><tr><td>costCategoryId</td><td><span><span></span></span></td></tr><tr><td>costTypeId</td><td><span><span></span></span></td></tr><tr><td>description</td><td><span><span></span></span></td></tr><tr><td>filterIds</td><td><span><span></span></span></td></tr><tr><td>id</td><td><span><span></span></span></td></tr><tr><td>initiatedByTrackingStatusId</td><td><span><span></span></span></td></tr><tr><td>isEnabled</td><td><span><span></span></span></td></tr><tr><td>isJoin</td><td><span><span></span></span></td></tr><tr><td>name</td><td><span><span></span></span></td></tr><tr><td>referenceType</td><td><span><span></span></span></td></tr><tr><td>reportId</td><td><span><span></span></span></td></tr><tr><td>separateTaskPerFilter</td><td><span><span></span></span></td></tr><tr><td>sequenceNumber</td><td><span><span></span></span></td></tr><tr><td>taskCategoryId</td><td><span><span></span></span></td></tr><tr><td>trackingStatusApplyToAssembly</td><td><span><span></span></span></td></tr><tr><td>trackingStatusApplyToOrder</td><td><span><span></span></span></td></tr><tr><td>trackingStatusApplyToPart</td><td><span><span></span></span></td></tr><tr><td>trackingStatusBypassDialog</td><td><span><span></span></span></td></tr><tr><td>trackingStatusId</td><td><span><span></span></span></td></tr><tr><td>unitOfMeasureFieldId</td><td><span><span></span></span></td></tr><tr><td>unitVelocity</td><td><span><span></span></span></td></tr></tbody></table>

}

{

<table><tbody><tr><td>createdById</td><td><span><span></span></span></td></tr><tr><td>createdDT</td><td><span><span></span></span></td></tr><tr><td>taskStatus</td><td><span><span></span></span></td></tr><tr><td>stationId</td><td><span><span></span></span></td></tr></tbody></table>

}

{}

integer($int32)Enum:  

{

<table><tbody><tr><td>isPartialData</td><td><span><span></span></span></td></tr><tr><td>isReadOnly</td><td><span><span></span></span></td></tr><tr><td>id<span>*</span></td><td><span><span></span></span></td></tr><tr><td>createdDT</td><td><span><span></span></span></td></tr><tr><td>createdById</td><td><span><span></span></span></td></tr><tr><td>modifiedDT</td><td><span><span></span></span></td></tr><tr><td>modifiedById</td><td><span><span></span></span></td></tr><tr><td>activityType</td><td><span><span></span></span></td></tr><tr><td>activityTypeName</td><td><span><span></span></span></td></tr><tr><td>divisionId<span>*</span></td><td><span><span></span></span></td></tr><tr><td>divisionName</td><td><span><span></span></span></td></tr><tr><td>email</td><td><span><span></span></span></td></tr><tr><td>employeeId</td><td><span><span></span></span></td></tr><tr><td>firstName</td><td><span><span></span></span></td></tr><tr><td>isLocked</td><td><span><span></span></span></td></tr><tr><td>lastName</td><td><span><span></span></span></td></tr><tr><td>modelId</td><td><span><span></span></span></td></tr><tr><td>modelName</td><td><span><span></span></span></td></tr><tr><td>packageCategoryId</td><td><span><span></span></span></td></tr><tr><td>packageCategoryName</td><td><span><span></span></span></td></tr><tr><td>packageDivisionId</td><td><span><span></span></span></td></tr><tr><td>packageDivisionName</td><td><span><span></span></span></td></tr><tr><td>packageId</td><td><span><span></span></span></td></tr><tr><td>packageName</td><td><span><span></span></span></td></tr><tr><td>packageNumber</td><td><span><span></span></span></td></tr><tr><td>projectId</td><td><span><span></span></span></td></tr><tr><td>projectName</td><td><span><span></span></span></td></tr><tr><td>projectNumber</td><td><span><span></span></span></td></tr><tr><td>shiftTypeId</td><td><span><span></span></span></td></tr><tr><td>startDT</td><td><span><span></span></span></td></tr><tr><td>stationDivisionId</td><td><span><span></span></span></td></tr><tr><td>stationDivisionName</td><td><span><span></span></span></td></tr><tr><td>stationId</td><td><span><span></span></span></td></tr><tr><td>stationName</td><td><span><span></span></span></td></tr><tr><td>stopDT</td><td><span><span></span></span></td></tr><tr><td>taskDefinitionId</td><td><span><span></span></span></td></tr><tr><td>userTypeName<span>*</span></td><td><span><span></span></span></td></tr><tr><td>workerId<span>*</span></td><td><span><span></span></span></td></tr></tbody></table>

}

{}

{

<table><tbody><tr><td>data</td><td><span><span></span></span></td></tr><tr><td>pageOffset</td><td><span><span></span></span></td></tr><tr><td>pageLimit</td><td><span><span></span></span></td></tr><tr><td>pageCount</td><td><span><span></span></span></td></tr><tr><td>total</td><td><span><span></span></span></td></tr><tr><td>truncatedResults</td><td><span><span></span></span></td></tr><tr><td>truncatedReason</td><td><span><span></span></span></td></tr><tr><td>filterOptions</td><td><span><span></span></span></td></tr><tr><td>links</td><td><span><span></span><span><br>nullable: true</span></span></td></tr></tbody></table>

}

{

<table><tbody><tr><td>id</td><td><span><span></span></span></td></tr><tr><td>createdDT</td><td><span><span></span></span></td></tr><tr><td>modifiedDT</td><td><span><span></span></span></td></tr><tr><td>name</td><td><span><span></span></span></td></tr><tr><td>location</td><td><span><span></span></span></td></tr><tr><td>toolType</td><td><span><span></span></span></td></tr><tr><td>toolTypeName</td><td><span><span></span></span></td></tr><tr><td>enabled</td><td><span><span></span></span></td></tr><tr><td>newStatusWhenDoneId</td><td><span><span></span></span></td></tr><tr><td>newTaskDefinitionWhenDoneId</td><td><span><span></span></span></td></tr><tr><td>labelTemplate</td><td><span><span></span></span></td></tr></tbody></table>

}

{

<table><tbody><tr><td>id</td><td><span><span></span></span></td></tr><tr><td>createdDT</td><td><span><span></span></span></td></tr><tr><td>modifiedDT</td><td><span><span></span></span></td></tr><tr><td>toolId</td><td><span><span></span></span></td></tr><tr><td>messageJson</td><td><span><span></span></span></td></tr><tr><td>messageType</td><td><span><span></span></span></td></tr><tr><td>projectId</td><td><span><span></span></span></td></tr><tr><td>modelId</td><td><span><span></span></span></td></tr><tr><td>packageId</td><td><span><span></span></span></td></tr><tr><td>assemblyId</td><td><span><span></span></span></td></tr><tr><td>toolType</td><td><span><span></span></span></td></tr><tr><td>toolTypeName</td><td><span><span></span></span></td></tr><tr><td>toolName</td><td><span><span></span></span></td></tr></tbody></table>

}

integer($int32)Enum:  

{

<table><tbody><tr><td>id</td><td><span><span></span></span></td></tr><tr><td>createdDT</td><td><span><span></span></span></td></tr><tr><td>currentDivisionId</td><td><span><span></span></span></td></tr><tr><td>modifiedDT</td><td><span><span></span></span></td></tr><tr><td>modelId</td><td><span><span></span></span></td></tr><tr><td>referenceType</td><td><span><span></span></span></td></tr><tr><td>referenceName</td><td><span><span></span></span></td></tr><tr><td>referenceId</td><td><span><span></span></span></td></tr><tr><td>currentTrackingStatusId</td><td><span><span></span></span></td></tr><tr><td>totalHours</td><td><span><span></span></span></td></tr><tr><td>trackingLogEntries</td><td><span><span></span></span></td></tr></tbody></table>

}

{

<table><tbody><tr><td>data</td><td><span><span></span></span></td></tr><tr><td>pageOffset</td><td><span><span></span></span></td></tr><tr><td>pageLimit</td><td><span><span></span></span></td></tr><tr><td>pageCount</td><td><span><span></span></span></td></tr><tr><td>total</td><td><span><span></span></span></td></tr><tr><td>truncatedResults</td><td><span><span></span></span></td></tr><tr><td>truncatedReason</td><td><span><span></span></span></td></tr><tr><td>filterOptions</td><td><span><span></span></span></td></tr><tr><td>links</td><td><span><span></span><span><br>nullable: true</span></span></td></tr></tbody></table>

}

{

<table><tbody><tr><td>trackingStatusId</td><td><span><span></span></span></td></tr><tr><td>createdById</td><td><span><span></span></span></td></tr><tr><td>createdDT</td><td><span><span></span></span></td></tr><tr><td>divisionId</td><td><span><span></span></span></td></tr><tr><td>id</td><td><span><span></span></span></td></tr><tr><td>origin</td><td><span><span></span></span></td></tr><tr><td>comment</td><td><span><span></span></span></td></tr><tr><td>hours</td><td><span><span></span></span></td></tr><tr><td>costTypeId</td><td><span><span></span></span></td></tr><tr><td>hoursCost</td><td><span><span></span></span></td></tr></tbody></table>

}

integer($int32)Enum:  

{

<table><tbody><tr><td>id</td><td><span><span></span></span></td></tr><tr><td>name</td><td><span><span></span></span></td></tr><tr><td>description</td><td><span><span></span></span></td></tr><tr><td>color</td><td><span><span></span></span></td></tr><tr><td>sequenceNumber</td><td><span><span></span></span></td></tr><tr><td>canAddToAssembly</td><td><span><span></span></span></td></tr><tr><td>canAddToOrder</td><td><span><span></span></span></td></tr><tr><td>canRenumberItems</td><td><span><span></span></span></td></tr><tr><td>canAddToBOM</td><td><span><span></span></span></td></tr><tr><td>canGenerateCutList</td><td><span><span></span></span></td></tr><tr><td>appliedAtOrder</td><td><span><span></span></span></td></tr><tr><td>appliedAtAssembly</td><td><span><span></span></span></td></tr><tr><td>appliedAtPart</td><td><span><span></span></span></td></tr><tr><td>appliedAtContainer</td><td><span><span></span></span></td></tr><tr><td>onHold</td><td><span><span></span></span></td></tr><tr><td>trackingStatusGroupIds</td><td><span><span></span></span></td></tr><tr><td>trackingStatusGroups</td><td><span><span></span></span></td></tr><tr><td>trackingStatusGroupPercentageMapping</td><td><span><span></span><span><br>nullable: true</span></span></td></tr></tbody></table>

}

{

<table><tbody><tr><td>comment</td><td><span><span></span></span></td></tr><tr><td>costTypeId</td><td><span><span></span></span></td></tr><tr><td>createdDT</td><td><span><span></span></span></td></tr><tr><td>divisionId</td><td><span><span></span></span></td></tr><tr><td>hours</td><td><span><span></span></span></td></tr><tr><td>trackingLogEntryIdResult</td><td><span><span></span></span></td></tr><tr><td>trackingStatusId<span>*</span></td><td><span><span></span></span></td></tr></tbody></table>

}

integer($int32)Enum:  

{

<table><tbody><tr><td>cellPhone</td><td><span><span></span></span></td></tr><tr><td>companyId</td><td><span><span></span></span></td></tr><tr><td>companyName</td><td><span><span></span></span></td></tr><tr><td>dateFormat</td><td><span><span></span></span></td></tr><tr><td>email</td><td><span><span></span></span></td></tr><tr><td>firstName</td><td><span><span></span></span></td></tr><tr><td>hourFormat</td><td><span><span></span></span></td></tr><tr><td>id</td><td><span><span></span></span></td></tr><tr><td>isCheckedIn</td><td><span><span></span></span></td></tr><tr><td>isTimeTrackingEnabled</td><td><span><span></span></span></td></tr><tr><td>lastName</td><td><span><span></span></span></td></tr><tr><td>lastViewedDateTimeForAssemblyId</td><td><span><span></span><span><br>nullable: true</span></span></td></tr><tr><td>lastViewedDateTimeForModelId</td><td><span><span></span><span><br>nullable: true</span></span></td></tr><tr><td>lastViewedDateTimeForPackageId</td><td><span><span></span><span><br>nullable: true</span></span></td></tr><tr><td>longDateFormat</td><td><span><span></span></span></td></tr><tr><td>profileImageUrl</td><td><span><span></span></span></td></tr><tr><td>profileImageBase64</td><td><span><span></span></span></td></tr><tr><td>status</td><td><span><span></span></span></td></tr><tr><td>timeFormat</td><td><span><span></span></span></td></tr><tr><td>timeZoneInfoId</td><td><span><span></span></span></td></tr></tbody></table>

}

{

<table><tbody><tr><td>data</td><td><span><span></span></span></td></tr><tr><td>pageOffset</td><td><span><span></span></span></td></tr><tr><td>pageLimit</td><td><span><span></span></span></td></tr><tr><td>pageCount</td><td><span><span></span></span></td></tr><tr><td>total</td><td><span><span></span></span></td></tr><tr><td>truncatedResults</td><td><span><span></span></span></td></tr><tr><td>truncatedReason</td><td><span><span></span></span></td></tr><tr><td>filterOptions</td><td><span><span></span></span></td></tr><tr><td>links</td><td><span><span></span><span><br>nullable: true</span></span></td></tr></tbody></table>

}

integer($int32)Enum:  

{}
