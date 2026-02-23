
# 📌 **API Class – Methods and Properties**

## API Class
- **Methods**
  - CreateButton
  - GetAsDataTable
  - GetData
  - GetFabAncillaryValue
  - GetLastUpdated
  - GetParameter
  - GetProfileFieldNames
  - GetProfileNames
  - GetSpoolStatus
  - GetSpoolStatusDefinitionNames
  - GetTable
  - GetTableNames
  - GetUniqueId
  - OpenDataProfilesDialog
  - OpenTablesConfigurationDialog
  - RegisterFieldColumnNamesSelectionList
  - RegisterImplementingFeature
  - RegisterModelDataExportDestination<T>
  - SaveTable
  - SetSpoolStatus
  - TryExportToMaj
  - TryExportToPdf
  - UnregisterFieldColumnNamesSelectionList
  - UnregisterImplementingFeature
  - UnregisterModelDataExportDestination
  - ViewData
  - WriteData

- **Properties**
  - IdColumnName
  - IgnoreProfileNamesFeaturedFilter
  - IntegrationRibbonPanel
  - IsLicensed
  - IsOnline
  - ProductName
  - ProductVersion
  - SupportsMapStatusUpdates
  - UniqueIdSeparator

- **Enumerations**
  - ModelDataExportFormat
  - UnmappedFieldAction
  - Boolean
  - DataType
  - Decimal
  - DWF
  - DWG
  - DXF
  - Error
  - IFC
  - Ignore
  - NWC
  - PDF
  - ProfileDirection
  - Project
  - Prompt
  - Selection
  - SelectionScope
  - Text
  - View
  - Export

- **Delegates**
  - OnElementProcessed

---

## SpecialParameterNameKeys Structure
- **Fields**
  - Element_Id
  - Element_InLinkedModel
  - Element_IsNested
  - Element_LinkedModelSource
  - Element_UniqueId
  - Element_Weight
  - Element_X
  - Element_Y
  - eVolve_ProductVersion
  - eVolve_RevitVersion
  - eVolve_Timestamp
  - eVolve_UserName
  - eVolve_WindowsUserName
  - eVolve_WorkstationName
  - FabAncillary_Depth
  - FabAncillary_Description
  - FabAncillary_Id
  - FabAncillary_Length
  - FabAncillary_ProductCode
  - FabAncillary_Quantity
  - FabAncillary_Type
  - FabAncillary_UsageType
  - FabAncillary_WidthDiameter
  - Project_Address
  - Project_Author
  - Project_BuildingName
  - Project_ClientName
  - Project_FileName
  - Project_FilePath
  - Project_IssueDate
  - Project_Name
  - Project_Number
  - Project_OrgDescription
  - Project_OrgName
  - Project_Status

- **Methods**
  - GetSpecialParameterNameDataType
  - GetSpecialParameterNameUnitType

---

# 📌 **EVOLVE API INDEX**
- **Namespaces**
  - EVOLVE.Core.Revit.Integration
  - EVOLVE.Core.Revit.ProductInfo
  - EVOLVE.Core.Revit.Reporting
  - EVOLVE.Core.Revit.Spooling
  - EVOLVE.Core.Revit.Utilities

- **Classes**
  - EVOLVE.API
  - EVOLVE.ProductInfo.API
  - EVOLVE.Reporting.API
  - EVOLVE.Spooling.API
  - EVOLVE.Utilities.API
  - EVOLVE.Utilities.API.ModelDataExportDestination Interface
  - EVOLVE.Utilities.API.WindowFolderModelDataExportDestination Class

- **Delegates**
  - EVOLVE.API.OnElementProcessed

- **Structures**
  - EVOLVE.API.SpecialParameterNameKeys

- **Enumerations**
  - EVOLVE.API.UnmappedFieldAction
  - EVOLVE.API.ModelDataExportFormat
  - EVOLVE.API.DataType
  - EVOLVE.API.ProfileDirection
  - EVOLVE.API.SelectionScope

---

## WindowFolderModelDataExportDestination Class
- **Constructor**
  - WindowFolderModelDataExportDestination constructor

- **Methods**
  - FinalizePublish
  - GetLocation
  - GetLocationDisplay
  - InitializePublish
  - ModifyViewAfterPublish
  - ModifyViewBeforeGeneration
  - PublishFile

- **Properties**
  - Id
  - ModifiesViewForAllExporters
  - Name

---

## IModelDataExportDestination Interface
- **Methods**
  - FinalizePublish
  - GetLocation
  - GetLocationDisplay
  - InitializePublish
  - ModifyViewAfterPublish
  - ModifyViewBeforeGeneration
  - PublishFile

- **Properties**
  - Id
  - ModifiesViewForAllExporters
  - Name
