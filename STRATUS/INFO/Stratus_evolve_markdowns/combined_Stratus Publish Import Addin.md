---
created: 2025-06-25T11:08:05 (UTC -04:00)
tags: []
source: https://gtpservices.atlassian.net/wiki/spaces/SK/pages/2282586113/CAMduct+ESTmep+Publish+and+Import
author: 
---

# CAMduct / ESTmep Publish and Import - STRATUS Knowledge Base - Confluence

> ## Excerpt
> This article describes the steps and settings that impact publishing CAMduct/ESTmep job files to Stratus and importing specific data back into the CAMduct/ESTmep job. The Stratus Addin is required to publish and import.

---
This article describes the steps and settings that impact publishing CAMduct/ESTmep job files to Stratus and importing specific data back into the CAMduct/ESTmep job. The [**Stratus Addin**](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/10551828/STRATUS+Addin "https://gtpservices.atlassian.net/wiki/spaces/SK/pages/10551828/STRATUS+Addin") is required to publish and import.

**Note:** The CAMduct/ESTmep Addin is a premium feature. To enable it for your company, request access through your GTP Sales Team.

-   1 [Stratus Academy Course Video](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/2282586113/CAMduct+ESTmep+Publish+and+Import#Stratus-Academy-Course-Video)
-   2 [CAMduct/ESTmep Publish Use Cases](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/2282586113/CAMduct+ESTmep+Publish+and+Import#CAMduct%2FESTmep-Publish-Use-Cases)
-   3 [CAMduct/ESTmep Publish and Import (General Steps)](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/2282586113/CAMduct+ESTmep+Publish+and+Import#CAMduct%2FESTmep-Publish-and-Import-(General-Steps))
    -   3.1 [Publish a MAJ Model](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/2282586113/CAMduct+ESTmep+Publish+and+Import#Publish-a-MAJ-Model)
    -   3.2 [Publish a MAJ Package](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/2282586113/CAMduct+ESTmep+Publish+and+Import#Publish-a-MAJ-Package)
    -   3.3 [Import](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/2282586113/CAMduct+ESTmep+Publish+and+Import#Import)
-   4 [AutoCAD Publish Considerations](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/2282586113/CAMduct+ESTmep+Publish+and+Import#AutoCAD-Publish-Considerations)
-   5 [Settings](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/2282586113/CAMduct+ESTmep+Publish+and+Import#Settings)
    -   5.1 [Property Mapping Settings](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/2282586113/CAMduct+ESTmep+Publish+and+Import#Property-Mapping-Settings)
        -   5.1.1 [Updating CAMduct/ESTmep/MAJ Settings](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/2282586113/CAMduct+ESTmep+Publish+and+Import#Updating-CAMduct%2FESTmep%2FMAJ-Settings)
        -   5.1.2 [Property for Model Stamp](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/2282586113/CAMduct+ESTmep+Publish+and+Import#Property-for-Model-Stamp)
        -   5.1.3 [Use Pattern Dimension Names (Coming with 7.3.1 Update)](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/2282586113/CAMduct+ESTmep+Publish+and+Import#Use-Pattern-Dimension-Names-(Coming-with-7.3.1-Update))
-   6 [Scenarios](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/2282586113/CAMduct+ESTmep+Publish+and+Import#Scenarios)
    -   6.1 [Publish Failures](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/2282586113/CAMduct+ESTmep+Publish+and+Import#Publish-Failures)
        -   6.1.1 [CAMduct/ESTmep Addin Not Enabled for Company](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/2282586113/CAMduct+ESTmep+Publish+and+Import#CAMduct%2FESTmep-Addin-Not-Enabled-for-Company)
        -   6.1.2 [Publish Packages Checkbox Not Configured for Placeholder Model](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/2282586113/CAMduct+ESTmep+Publish+and+Import#Publish-Packages-Checkbox-Not-Configured-for-Placeholder-Model)
        -   6.1.3 [Error: The Specified Package Name or Number Has Already Been Used](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/2282586113/CAMduct+ESTmep+Publish+and+Import#Error%3A-The-Specified-Package-Name-or-Number-Has-Already-Been-Used)
        -   6.1.4 [Cannot Republish a Model that is Checked for Publishing Packages](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/2282586113/CAMduct+ESTmep+Publish+and+Import#Cannot-Republish-a-Model-that-is-Checked-for-Publishing-Packages)
    -   6.2 [Item Numbering and Dimensioning](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/2282586113/CAMduct+ESTmep+Publish+and+Import#Item-Numbering-and-Dimensioning)
    -   6.3 [Handling of Assemblies](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/2282586113/CAMduct+ESTmep+Publish+and+Import#Handling-of-Assemblies)

## Stratus Academy Course Video

To take publish related courses, login to [**Stratus Academy**](https://academy.stratus.build/ "https://academy.stratus.build/") and locate the following courses:

-   **ADM-500: Publishing Settings Revit and CAD**
    
-   **VDC-401: Stratus Addin Installation**
    
-   **VDC-407: CAMduct / ESTmep Publishing**
    

## CAMduct/ESTmep Publish Use Cases

The Stratus CAMduct/ESTmep Publisher is designed to bring fabrication content directly from Autodesk CAMduct and ESTmep into Stratus as fabrication ready .MAJs to allow streamlined shop management, status tracking and reporting alongside other Stratus fabrication packages.

There are two common workflows:

1.  **Import non-modeled (field ordered) fabrication requests to Stratus.**  Many sheet metal shops receive field orders and orders from outside customers on paper, PDFs, and other non-modeled input forms which are input to CAMduct for fabrication.  With the Stratus CAMduct/ESTmep Publisher, these parts can be published directly into Stratus as .MAJ files where they can be tracked, managed and statused alongside other fabrication in the shop.  As an added benefit, quantities can be handled within this workflow - so a single piece in CAMduct can be published with a manufacturing quantity greater than one for creating assemblies, reporting, percent complete tracking, and analytics.
    
2.  **Adjust modeled content in CAMduct and republish.**  Often, sheet metal content published from Revit to Stratus needs additional modification in CAMduct before it is ready for fabrication.  In this case, the Revit to Stratus publish creates the initial .MAJ file in Stratus.  This .MAJ can then opened and edited in CAMduct and then using the Stratus CAMduct/ESTmep Publisher - republished to Stratus.  **Note:** In this case, the original .MAJ package still exists in Stratus and is not deleted or modified resulting in 2 packages in Stratus for the same part. The most common workflow here is to publish the new .MAJ file from CAMduct to a new Stratus model that collects the “as manufactured” MAJs. In this case, the original Revit .MAJs live in one model which is “as designed” and the modified .MAJs from CAMduct live in a new model which is as manufactured. Both models can than be used for reporting and even calculation of differences between design and manufactured.
    

Details on how this Publisher works in both CAMduct and ESTmep are included below.

## **CAMduct/ESTmep Publish and Import (General Steps)**

The **CAMduct/ESTmep Addin** can be used to publish CAMduct/ESTmep models or packages.

### Publish a MAJ Model

1.  Before publishing, your Stratus administrator can configure publish settings.
    
2.  Desktop installer includes Stratus Addin for CAMduct and ESTmep in versions 2021 or later.
    
3.  Open CAMduct or ESTmep.
    
4.  Select the Fabrication Database Configuration.
    
    1.  **Note:** Make sure the latest Fabrication database has been uploaded to [**Lightning**](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/2556264449 "https://gtpservices.atlassian.net/wiki/spaces/SK/pages/2556264449") (required for publishing as a package).
        
5.  Under Actions, select **Create Blank Job** or **Open Job** (If MAJ file already exists).
    
    1.  **Note**: Users can open **Fabrication REJ (Remote Entry Job) files** and publish using CAMduct.
        
6.  When opening each application, the GTP Stratus palette ribbon menu Add-Ins will display as follows:
    
    1.  **CAMduct**
        
    2.  **ESTmep** (Has two locations: In the top dropdown **Add-Ins,** and underneath Add-Ins ribbon.
        
        1.  Dropdown.
            
        2.  Ribbon.
            
7.  Once parts are added to MAJ and Job is saved with filename to be used as model or package name.
    
8.  Click **Stratus Publish** on the Add-Ins.
    
9.  **Login to Stratus and Autodesk.**
    
    1.  **Stratus Login** - If a user attempts to publish but is not signed in to Stratus, a prompt similar to the following will display. The user will enter their credentials.
        
        1.  If the model was previously published but has been deleted in Stratus, the following prompt "Model Not Found in Stratus" will display.  
            
            ![](blob:https://gtpservices.atlassian.net/25a1664f-7114-48f5-aa51-77198a968d27)
            
            1.  **Publish as New Model** - Click Publish as New Model to proceed.
                
            2.  **Cancel Publish** - Click Cancel Publish to stop the publish or to review the model.
                
10.  The Publish dialog will display:
    
    1.  **User** - The user who is publishing the model.
        
    2.  **Model** \-  The Model name (the MAJ filename).
        
    3.  **Company** - Select a **Company** from a list of the logged-in user permitted Companies.
        
        1.  **Note**: If CAM/EST publishing has not been enabled for the company, a message will appear and prevent publishing.
            
    4.  **Project** - Select a **Project** from a list of the logged-in user permitted Projects.
        
        1.  **Note:** See the [**Configure BIM 360 Publish Folder Path**](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/2282586113/CAMduct+ESTmep+Publish+and+Import# "#") section for more information on configuring the project's **BIM 360 Publish Folder Path**. 
            
11.   Click the **Publish** button and the following will occur:
    
    1.  **Publish Activity.**
        
    2.  **Locked Model** - For anyone working within Stratus on a project based on the model being published, the Parts and Assemblies will be locked and view only.
        
        1.  Below is a summary of features that are "Locked" and "Not Locked".
            
            1.  **Locked Options**
                
                1.  Create New Assembly.
                    
                2.  Add/Remove Parts To/From and Assembly.
                    
                3.  Edit/Rename Assembly.
                    
            2.  **Not Locked Options**
                
                1.  Packages – Parts and Assemblies can be added to or removed from a Package.
                    
                2.  Tracking Status – The Tracking Status of any item (Part, Assembly, Package) can be changed.
                    
                3.  Cut Lists – Cut lists can be created and processed.
                    
                4.  Reports – Reports can be used and edited.
                    
                5.  Categories – Categories can be used and edited.
                    
                6.  Filters – Filters can be used and edited.
                    
                7.  Part Templates – Part Templates can be edited.
                    
                8.  Attachments – Attachments can be used and edited.
                    
        2.  When a model is being published and the model is “Locked”, users will notice the following:
            
            1.  The Models > Viewer canvas is highlighted in red and the lock icon displays next to the model name.
                
            2.  The Assemblies > Viewer canvas is highlighted in red and the lock icon displays next to the model name.
                
            3.  In the Models > Viewer, the Create Assembly and Add/Remove Parts To/From and Assembly buttons are disabled.
                
            4.  The Assemblies > Dashboard buttons to Edit or Delete an assembly item are disabled.
                
    3.  **BIM 360** - The model will be published to your BIM 360 project as a DWG file. Although this is just a placeholder empty DWG required by Stratus.  In BIM 360 the published model file is automatically organized under Project Files > Model Name > Stratus > with the authoring tool abbreviation DWG.
        
    4.  **Republish is not allowed** - While a model is being published, a second publish of the same model cannot be started. A message similar to the following will display:
        
        If you believe you’ve reached this message in error, please contact GTP Software Help Desk for support.
        
12.  **Close button enabled** \- When the Stratus Addin completes the publishing process, the **Close** button is enabled and the elapsed time displays.
    
    1.  Close indicates that the model and related data files have been uploaded to Stratus and the BIM 360 folder.
        
    2.  The model cannot be viewed in Stratus until the Autodesk translation completes.
        
    3.  If an existing version of the model or drawing exists, the Stratus publish will overwrite the file with a new version of the file. Stratus always references the most recently published version of any file it displays, assuming it was published using Stratus. You can access older versions as needed.
        
    4.  Fabrication Extended Data will be extracted. See below for a list of **Fabrication Extended Data**.
        
13.  **Forge Translation** - Behind the scenes, Autodesk will translate the file so that it can be viewed in the Autodesk Forge viewer (which is embedded in Stratus). The Models > Viewer page will display a message similar to the following until the Autodesk translation is complete.  This step can take a few minutes to several hours depending on the size of the model.
    
14.  **Multiple Publishes** - A model with the same name can be published multiple times to Stratus.  Stratus operates on the most recent revision.  Packages will be retained, as they reference unique CAD IDs that remain constant from one publish to the next. 
    
15.  **Initial Tracking Status** - After the initial publish to Stratus, the initial tracking status of all parts in the model will be set to Design or the #1 tracking status configured under Admin > Company > Tracking Statuses. Subsequent publishes will retain the Stratus tracking status.
    
16.  **Model Publish Notification** - After a model is published, the person who published the model will receive an automated email notification similar to the following that indicates the publish completed or failed.
    
17.  **Republish Model** - After a model is published, if the Publish is clicked, Stratus will determine if data needs to be imported. If so, the **import will begin automatically**.  If there are import conflicts based on company or project settings (see the [**Settings (Admin)**](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/10518994 "https://gtpservices.atlassian.net/wiki/spaces/SK/pages/10518994") article for more information), the user will receive prompts to resolve issues. Once data is imported the publish process will continue.  An import is required when a model in Stratus has new assemblies or packages, or parts have been moved from one assembly or package to another, or when a tracking status has changed. For CAMduct and ESTmep, it is assumed Stratus is Always Right when it comes to import data.
    

### Publish a MAJ Package

1.  Before publishing, your Stratus administrator must configure publish settings.
    
2.  To enable publishing MAJ file packages:
    
    1.  **Publish a placeholder model** - Publish a placeholder model to Stratus using AutoCAD or Revit prior to publishing MAJ files as packages to a specific Project.
        
    2.  **Publish Packages** - Once the placeholder model is published, under Models > Dashboard, select the **Project** and then check the **Publish Packages** checkbox associated with the placeholder model (above).
        
    3.  **Tooltip**: Use Model only to Publish Packages from CAMduct, ESTmep, Field Orderz, and PypeServer.
        
    4.  **Note**: Only 1 model can be designated to publish packages.
        
        1.  User will need to to uncheck the current selection, if they desire to select another model as a placeholder to publish a package.
            
3.  Open CAMduct or ESTmep.
    
4.  Select Fabrication Database Configuration.
    
    **Note: the Fabrication database MUST be uploaded to Stratus using Lightning, prior to publishing MAJ files as Packages.**
    
5.  Under **Actions,** select **Create Blank Job** or **Open Job** (if MAJ file already exists).
    
6.  When opening each application, the GTP Stratus palette ribbon menu add-in will display as follows:
    
    1.  **CAMduct.**
        
    2.  **ESTmep** (Has two locations: In the top dropdown **Add-Ins,** and underneath Add-Ins ribbon.
        
        1.  Dropdown.
            
        2.  Ribbon.
            
7.  Once parts are added to MAJ and job file is saved, click the **Stratus Publish** button on the Add-Ins.
    
8.  **Login to Stratus and Autodesk.**
    
    1.  **Stratus Login** - If a user attempts to publish but is not signed in to Stratus, the following prompt will display. The user will enter their credentials.
        
        1.  If the model has not been previously published, the following prompt "Model Not Found in Stratus" will display.  
            
            ![](blob:https://gtpservices.atlassian.net/384d189e-5ad9-47ce-ad05-24e5aa470b34)
            
            1.  **Publish as New Model** - Click Publish as New Model to proceed.
                
            2.  **Cancel Publish** - Click Cancel Publish to stop the publish or to review the model.
                
9.  The Publish dialog will display:
    
    1.  **User** - The user who is publishing the model.
        
    2.  **Model** \-  Only models that are checked for **Publish Packages** in the Models>Dashboard will be available.
        
    3.  **Company** - Select a **Company** from a list of the logged-in users permitted Companies.
        
        1.  NOTE: If publishing from CAMduct and ESTmep has not been enabled for the company, this message will appear and prevent publishing.
            
    4.  **Project** - Select a **Project** from a list of the logged-in users permitted Projects.
        
        1.  **Note:** See the [**Configure BIM 360 Publish Folder Path**](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/2282586113/CAMduct+ESTmep+Publish+and+Import# "#") section for more information on configuring the project's **BIM 360 Publish Folder Path**. 
            
    5.  **Package** - Check box to indicate user wants to publish MAJ file as a Package to Stratus.
        
    6.  **Name** \- Package Name (Job filename).
        
    7.  **Number** \- Manually input data for package number.
        
        1.  Note: If kept empty, Stratus will assign package number per naming and numbering rules. Also, the package Number must be unique across all packages associated with this model. Publish will fail if Number is not unique or empty.
            
    8.  **Category** \- set to **Default**. This aligns with the packages categories created from Admin>Company>Package Categories and may be specified prior to publish.
        
    9.  **Description** \- Manually input data for package description.
        
10.   Click the **Publish** button and the following will occur:
    
    1.  **Publish Activity.**
        
11.  Final result in Stratus, Packages>Dashboard.
    

### Import

1.  Click on Add-Ins.
    
2.  Select **Stratus Import.**
    
3.  **Initiate import data** - The **Initiating Stratus requests to generate import data** dialog will display.
    
4.  Click **OK** to begin the import generation and then wait.
    
5.  **Receive import data** - After a minute, the **Received Stratus import data** dialog displays. This message indicates that the file generation has finished.
    
6.  Click **OK** to complete the import and then wait.
    
7.  Once done the **Successfully imported data from Stratus** message will display. Click OK.
    

## AutoCAD Publish Considerations

-   [AutoCAD Publish and Import | Configure BIM 360 Publish Folder Path](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/1183384125/AutoCAD+Publish+and+Import#Configure-BIM-360-Publish-Folder-Path)
    
-   [AutoCAD Publish and Import | Insulation](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/1183384125/AutoCAD+Publish+and+Import#Insulation)
    
-   [AutoCAD Publish and Import | STRATUS Tracking Status Matches Fabrication Database](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/1183384125/AutoCAD+Publish+and+Import#STRATUS-Tracking-Status-Matches-Fabrication-Database)
    

## Settings

Your Stratus administrator can configure settings that will impact the process and data synchronization of the publish and import process including the Assembly Conflict settings Stratus is always right or AutoCAD is always right. See the [**Settings**](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/10518994 "https://gtpservices.atlassian.net/wiki/spaces/SK/pages/10518994") article for more information. 

## Property Mapping Settings

1.  Settings **Specific to CAMduct, ESTmep, and MAJ** are located under Admin > Company > Settings.
    

**Property for Model Stamp (Required):** The Model Stamp is the model’s unique id and Is created when published to Stratus.

**Property for Project Number:** Value is set from a specific project number on Project dashboard.

**Property for Project Name:** Value is set from a specific project name on Project dashboard.

**Checkbox "Include Project Number Prefix with Name":** Value is set from a specific project, Name Override value on Project dashboard.

**Property for Project Description:** Value is set from a specific project description on Project dashboard.

**Checkbox "Set Project Color"**: This is set from Admin>Company>Projects, the specific color for the project the user is actively working in.

**The below properties** apply when dealing with a "Package" in Stratus, either import into CAM for published package OR exporting MAJ for package from Stratus for CAD/Revit model package.

**Property for Package Number:** Value is set from a specific package number on Packages dashboard.

**Property for Package Name:** Value is set from a specific package name on Packages dashboard.

**Checkbox "Include Package Number Prefix with Name":** Value is set from combining the specific package number and name on the Packages dashboard.

**Property for Package Description:** Value is set from a specific package description on Packages dashboard.

**Set Package Required Date:** Value is set from a specific package required date on Packages dashboard.

**Note: The above Properties refer to MAJ Job Property mappings for Package Details.**

### Updating CAMduct/ESTmep/MAJ Settings

1.  In Admin>Company>Settings>AUTOcad/Revit/CAMduct/ESTmep, set specific property mapping locations from the drop-down for each property to be saved in CAMduct/ESTmep.
    
    1.  **Note**: If "None" is selected, no specific property information will be added to the Job Information for the MAJ.
        
    2.  **Note**: Property for Model Stamp is the only property that is required to have a property mapping.
        
    3.  **Note**: Only ONE property mapping can be applied at a time. If user attempts to same mapping for multiple properties, an error modal will appear after saving.
        
2.  Click Save button at bottom of page.
    

**Property mapping locations in CAMduct/ESTmep**

1.  Select a part
    
2.  Click on job Information Tab
    
3.  The drop-down options from Admin>Company>Settings, will appear in the following fields on the standard form:
    
    1.  **CustomerPONumber**: Customer PO Number.
        
        1.  Note: this field is not on the standard form.
            
    2.  **Description**: Job Description Field.
        
        1.  Note: this field is not on the standard form.
            
    3.  **DescriptionField1**: General tab, Field 1.
        
    4.  **DescriptionField2**: General tab, Field 2.
        
    5.  **Notes:** Project tab, Notes.
        
    6.  **Project**: Job Project.
        
        1.  Note: this field is not on the stand form.
            
    7.  **ProjectInfo**: Project tab, Job Project Information.
        
    8.  **Reference**: General tab, Job Reference.
        
    9.  **Required**: General tab, Job date.
        
    10.  **Note:** If properties don’t appear on the standard form, users will have to create a custom form and add those mappings to the form.
        

### Property for Model Stamp

1.  **Property for Model Stamp**\- Maps the Stratus CompanyId, ProjectId, ModelId, and PackageId. This information is used to prevent duplicate publishes of same model and store the Stratus link within the MAJ file.
    
    1.  Example: If the setting is put to **ProjectInfo.** Once the publish is complete, the user can click on **Job Information** on the top context bar in CAMduct, then navigate to **Project,** then look at the text box **Job Project Information,** and see the Stratus Model Stamp Information. **Note: do not edit or delete this information.**
        

### Use Pattern Dimension Names (Coming with 7.3.1 Update)

Under Admin>Company>Settings>AutoCAD, Revit, CAMduct, and ESTmep: Dimension property names for each fabrication item can now be modified in Stratus. **If checked**, the fabrication item dimension properties will use the default Autodesk dimension names. **If unchecked**, the dimension names from the authoring software will be applied to the dimension part properties in Stratus.

Example: when the Use Pattern Dimension Names is turned **ON**, the default Autodesk Dimension will look like this:

Example: when the Use Pattern Dimension Names is turned **OFF**, the default Autodesk Dimension will look like this:

## Scenarios

## Publish Failures

### CAMduct/ESTmep Addin Not Enabled for Company

1.  If a user gets the below error message, this means their company has NOT been enabled to publish models or packages with CAMduct/ESTmep.
    
2.  To enable publishing, users will need to contact their GTP sales representative.
    

### Publish Packages Checkbox Not Configured for Placeholder Model

1.  When a user attempts to publish a package, the **Publish** button is disabled and the **Model** list is empty. This occurs because a model in Stratus has not been designated for **Publish Packages**.
    
2.  See the [**Publish a MAJ Package**](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/2282586113/CAMduct+ESTmep+Publish+and+Import#To-Publish-a-MAJ-Package "https://gtpservices.atlassian.net/wiki/spaces/SK/pages/2282586113/CAMduct+ESTmep+Publish+and+Import#To-Publish-a-MAJ-Package") section for more information.
    

### Error: The Specified Package Name or Number Has Already Been Used

1.  When creating new packages, if the specified package name or number has already been used for the selected Model, the user will receive an error message.
    
    1.  **Package Number example**: In this example, the Package Number **123** has already been used, therefore the error message displays.
        
        1.  The Packages > Dashboard displays the already existing Package Number **123.**
            
    2.  In this example: the Package Name **CAMduct\_2022\_Package\_BV** has already been used, therefore the error message displays.
        
        1.  The Packages > Dashboard displays the already existing Package Name **CAMduct\_2022\_Package\_BV.**
            

### Cannot Republish a Model that is Checked for Publishing Packages

1.  When a model is selected as a placeholder for package publishing, it cannot be republished.
    
2.  An error modal will appear if there is an attempted republish.
    

## Item Numbering and Dimensioning

Item numbering and dimensioning follow the same rules as normal Stratus models. Except, all of the same parts will get the same Item numbers, and users will have to use manual dimensioning for each part.

## Handling of Assemblies

The spool property is referenced on the initial publish to create assemblies in Stratus. Afterward, Stratus is Always right is assumed. Updates to packages and assemblies on the Stratus side are imported and the spool property on items is updated. Assemblies are not currently supported when Item quantities exceed (1).
---
created: 2025-06-25T11:08:05 (UTC -04:00)
tags: []
source: https://gtpservices.atlassian.net/wiki/spaces/SK/pages/2122022926/GTP+Software+Installers
author: 
---

# GTP Software Installers - STRATUS Knowledge Base - Confluence

> ## Excerpt
> Use this page to manually download GTP software installers.

---
Use this page to manually download GTP software installers.

Alternatively, GTP software can be installed via AutoUpdate. See the [**WinGet Automated Installation of GTP Software**](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/2291531777 "https://gtpservices.atlassian.net/wiki/spaces/SK/pages/2291531777") article for more information.

See the [**Stratus Change Log**](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/2470248450 "https://gtpservices.atlassian.net/wiki/spaces/SK/pages/2470248450") for features and enhancements included in each release.

### Stratus AddIn

-   [7.6.1045](https://assets.gtp.one/installers/GTPSTRATUSAddIn/GTPSTRATUSAddIn.7.6.1045.msi "https://assets.gtp.one/installers/GTPSTRATUSAddIn/GTPSTRATUSAddIn.7.6.1045.msi") Installer released on 06/19/2025 - (**optional**)
    
-   [7.6.1043](https://assets.gtp.one/installers/GTPSTRATUSAddIn/GTPSTRATUSAddIn.7.6.1043.msi "https://assets.gtp.one/installers/GTPSTRATUSAddIn/GTPSTRATUSAddIn.7.6.1043.msi") Installer released on 06/13/2025 - (**optional**)
    
-   [7.6.1042](https://assets.gtp.one/installers/GTPSTRATUSAddIn/GTPSTRATUSAddIn.7.6.1042.msi "https://assets.gtp.one/installers/GTPSTRATUSAddIn/GTPSTRATUSAddIn.7.6.1042.msi") Installer released on 06/09/2025 - (**optional**)
    
-   [7.6.1040](https://assets.gtp.one/installers/GTPSTRATUSAddIn/GTPSTRATUSAddIn.7.6.1040.msi "https://assets.gtp.one/installers/GTPSTRATUSAddIn/GTPSTRATUSAddIn.7.6.1040.msi") Installer released on 06/05/2025 - (**optional**)
    
-   [7.6.1033](https://assets.gtp.one/installers/GTPSTRATUSAddIn/GTPSTRATUSAddIn.7.6.1033.msi "https://assets.gtp.one/installers/GTPSTRATUSAddIn/GTPSTRATUSAddIn.7.6.1033.msi") Installer released on 5/11/2025 - (**optional**)
    
-   [7.6.1030](https://assets.gtp.one/installers/GTPSTRATUSAddIn/GTPSTRATUSAddIn.7.6.1030.msi "https://assets.gtp.one/installers/GTPSTRATUSAddIn/GTPSTRATUSAddIn.7.6.1030.msi") Installer released on 5/5/2025 - (**optional**)
    
-   [7.6.1009](https://assets.gtp.one/installers/GTPSTRATUSAddIn/GTPSTRATUSAddIn.7.6.1009.msi "https://assets.gtp.one/installers/GTPSTRATUSAddIn/GTPSTRATUSAddIn.7.6.1009.msi") Installer released on 3/20/2025 - (**optional**)
    
-   [7.5.1050](https://assets.gtp.one/installers/GTPSTRATUSAddIn/GTPSTRATUSAddIn.7.5.1050.msi "https://assets.gtp.one/installers/GTPSTRATUSAddIn/GTPSTRATUSAddIn.7.5.1050.msi") Installer released on 2/4/2025 - (**optional**)
    
-   [7.5.1026](https://cdn.winget.pro/d1588e01-761c-48ff-b102-2776fc4f8ec5/GTPSTRATUSAddIn.7.5.1026-eXhyh9bIjS.msi "https://cdn.winget.pro/d1588e01-761c-48ff-b102-2776fc4f8ec5/GTPSTRATUSAddIn.7.5.1026-eXhyh9bIjS.msi") Installer released on 12/23/2024 - (**optional**)
    
-   [7.5.1013](https://assets.gtp.one/installers/GTPSTRATUSAddIn/GTPSTRATUSAddIn.7.5.1013.msi "https://assets.gtp.one/installers/GTPSTRATUSAddIn/GTPSTRATUSAddIn.7.5.1013.msi") Installer released on 10/24/2024 - (**optional**)
    
-   [7.5.1011](https://assets.gtp.one/installers/GTPSTRATUSAddIn/GTPSTRATUSAddIn.7.5.1011.msi "https://assets.gtp.one/installers/GTPSTRATUSAddIn/GTPSTRATUSAddIn.7.5.1011.msi") Installer released on 10/6/2024 - (**optional**)
    
-   [7.5.1007](https://assets.gtp.one/installers/GTPSTRATUSAddIn/GTPSTRATUSAddIn.7.5.1007.msi "https://assets.gtp.one/installers/GTPSTRATUSAddIn/GTPSTRATUSAddIn.7.5.1007.msi") Installer released on 10/6/2024 - (**optional**)
    
-   [7.5.1001](https://assets.gtp.one/installers/GTPSTRATUSAddIn/GTPSTRATUSAddIn.7.5.1001.msi "https://assets.gtp.one/installers/GTPSTRATUSAddIn/GTPSTRATUSAddIn.7.5.1001.msi") Installer released on 9/23/2024 - (**required**)
    
    -   ADDED 2025 Support for Revit and AutoCAD
        
    -   Note that Flex geometry extraction is not quite yet supported for Revit 2025
        
-   7.4.1018 Installer released on 9/19/2024 - (**optional**)
    
    -   Issue resolved with failed model publishes for very large models
        
-   7.4.1013 Installer released on 9/13/2024 - (**optional**)
    
    -   Windows PCs will stay awake while going through an extended import/publish cycle
        
    -   Other import-related bugs were resolved
        
-   7.4.1006 Installer released on 8/19/2024 - (**optional**)
    
    -   Incremental update for Flex model publishing (only required if testing Flex model viewer)
        
-   7.4.1002 Installer released on 8/7/2024 - (**optional**)
    
    -   Adds support for [https://gtpservices.atlassian.net/wiki/spaces/SK/pages/166199351/Package+Categories+Admin#MAJQR](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/166199351/Package+Categories+Admin#MAJQR)
        
-   7.3.1078 (Denali) Official installer released on 7/16/2024 - (**optional**)
    
-   7.2.1122 (Yellowstone) Official installer released on 5/14/2024 - (**optional**)
    
    -   [https://gtpservices.atlassian.net/wiki/spaces/SK/pages/2329411585](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/2329411585)
        
    -   Only different in number from the pre-release build. Either version will work identically.
        
    -   **Only required for FLEX model viewer (beta) publishes**
        
-   7.2.1112 (Yellowstone) Pre-release installer on 5/13/2024 - (**optional**)
    
-   7.1.1159 released on 4/2/2024 (optional)
    
    -   Fixed CAM/EST import issue for beta users
        
-   7.1.1108 released on 3/15/2024 (optional)
    
    -   Fixed CAM/EST import issue for beta users
        
-   7.1.1105 released on 3/14/2024 (**required**)
    
    -   [https://gtpservices.atlassian.net/wiki/spaces/SK/pages/2255814657](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/2255814657)
        

### GTP FieldOrderz

-   [2.3.144.0 released on 1/4/2024](https://assets.gtp.one/installers/GTPFieldOrderz/GTPFieldOrderz.2.3.144.0.msi "https://assets.gtp.one/installers/GTPFieldOrderz/GTPFieldOrderz.2.3.144.0.msi")
    

### GTP Lightning

-   [7.5.103](https://assets.gtp.one/installers/GTPLightning/GTPLightning.7.5.103.msi "https://assets.gtp.one/installers/GTPLightning/GTPLightning.7.5.103.msi") Installer released on 9/23/2024 - (**required before October 18th**)
    
-   7.4.122 Official installer released on 9/19/2024 - (**optional**)
    
    -   Issue resolved with failed model publishes for very large models
        
-   7.4.120 Official installer released on 9/18/2024 - (**optional**)
    
    -   An issue with the installer not opening was resolved
        
-   7.4.111 Official installer released on 9/13/2024 - (**optional**)
    
    -   Lightning publish was made more robust
        
    -   Please hold off from installing this version as an issue has been found with it not loading.
        
-   7.3.128 (Denali) Official installer released on 7/16/2024 - (**optional**)
    
-   7.2.144 (Yellowstone) Official installer released on 5/14/2024 - (**optional**)
    
    -   Only different in number from the pre-release build. Either version will work identically.
        
-   7.2.142 (Yellowstone) Pre-release on 5/13/2024 - (**optional**)
    
-   7.1.161 (Grand Canyon) released on 3/14/2024 (**required**)
    
-   6.3.432 released on 1/25/2024
    
-   6.3.335 released on 12/17/2023
    
-   6.3.204 released on 11/7/2023
    
-   6.3.1.172 released on 8/16/2023
    

### GTP Print

-   [7.6.1045](https://assets.gtp.one/installers/GTPSTRATUSPrint/GTPSTRATUSPrint.7.6.1045.msi "https://assets.gtp.one/installers/GTPSTRATUSPrint/GTPSTRATUSPrint.7.6.1045.msi") Installer released on 6/19/2025 - (**optional)**
    
-   [7.5.1050](https://assets.gtp.one/installers/GTPSTRATUSPrint/GTPSTRATUSPrint.7.5.1050.msi "https://assets.gtp.one/installers/GTPSTRATUSPrint/GTPSTRATUSPrint.7.5.1050.msi") Installer released on 2/4/2025 - (**optional)**
    
-   [7.5.1001](https://assets.gtp.one/installers/GTPSTRATUSPrint/GTPSTRATUSPrint.7.5.1001.msi "https://assets.gtp.one/installers/GTPSTRATUSPrint/GTPSTRATUSPrint.7.5.1001.msi") Installer released on 9/23/2024 - (**required before October 18th**)
    
-   7.3.1078 (Denali) Official installer released on 7/16/2024 - (**optional**)
    
-   7.2.1141 (Yellowstone) Official installer released on 5/21/2024 with the fix for label printing - (**optional**)
    
-   7.2.1122 (Yellowstone) Official installer released on 5/14/2024 - ((**This version has been pulled as a label printing issue was found**))
    
    -   Only different in number from the pre-release build. Either version will work identically.
        
-   7.2.1112 (Yellowstone) Pre-release on 5/13/2024 - (**optional**)
    
-   7.1.1105 (Grand Canyon) released on 3/14/2024 (optional)
    
-   6.3.4053 released on 1/25/2024 (optional)
    
-   6.3.3059 released on 12/17/2023 (optional)
    
-   6.3.2007 released on 11/7/2023 (optional)
    
-   6.3.1.1174 released on 8/16/2023 (optional)
    

### GTP Workstation

-   [7.6.1045](https://assets.gtp.one/installers/GTPSTRATUSWorkstation/GTPSTRATUSWorkstation.7.6.1045.msi "https://assets.gtp.one/installers/GTPSTRATUSWorkstation/GTPSTRATUSWorkstation.7.6.1045.msi") Installer released on 06/19/2025 - (**optional**)
    
-   [7.6.1040](https://assets.gtp.one/installers/GTPSTRATUSWorkstation/GTPSTRATUSWorkstation.7.6.1040.msi "https://assets.gtp.one/installers/GTPSTRATUSWorkstation/GTPSTRATUSWorkstation.7.6.1040.msi") Installer released on 06/05/2025 - (**optional**)
    
    -   Lockformer Spiral tool support
        
-   [7.6.1031](https://cdn.winget.pro/d1588e01-761c-48ff-b102-2776fc4f8ec5/GTPSTRATUSWorkstation.7.6.1031-R7zUhadpxD.msi "https://cdn.winget.pro/d1588e01-761c-48ff-b102-2776fc4f8ec5/GTPSTRATUSWorkstation.7.6.1031-R7zUhadpxD.msi") Installer released on 05/07/2025 - (**optional**)
    
-   7.6.1007 Installer released on 12/10/2024 - (**optional**)
    
-   [7.5.1024](https://assets.gtp.one/installers/GTPSTRATUSWorkstation/GTPSTRATUSWorkstation.7.5.1024.msi "https://assets.gtp.one/installers/GTPSTRATUSWorkstation/GTPSTRATUSWorkstation.7.5.1024.msi") Installer released on 12/10/2024 - (**optional**)
    
-   [7.5.1011](https://assets.gtp.one/installers/GTPSTRATUSWorkstation/GTPSTRATUSWorkstation.7.5.1011.msi "https://assets.gtp.one/installers/GTPSTRATUSWorkstation/GTPSTRATUSWorkstation.7.5.1011.msi") Installer released on 10/6/2024 - (**optional**)
    
-   [7.5.1007](https://assets.gtp.one/installers/GTPSTRATUSWorkstation/GTPSTRATUSWorkstation.7.5.1007.msi "https://assets.gtp.one/installers/GTPSTRATUSWorkstation/GTPSTRATUSWorkstation.7.5.1007.msi") Installer released on 10/6/2024 - (**optional**)
    
-   [7.5.1001](https://assets.gtp.one/installers/GTPSTRATUSWorkstation/GTPSTRATUSWorkstation.7.5.1001.msi "https://assets.gtp.one/installers/GTPSTRATUSWorkstation/GTPSTRATUSWorkstation.7.5.1001.msi") Installer released on 9/23/2024 - (**Required**)
    
-   7.4.1010 Hotfix installer released on 8/2/2024 - (**optional**)
    
    -   Stratus Workstation was not allowing the selection of different package filters after completing a cut list
        
-   7.3.1078 (Denali) Official installer released on 7/16/2024 - (**optional**)
    
-   7.2.1141 (Yellowstone) Official installer released on 5/21/2024 with the fix for label printing - (**optional**)
    
-   7.2.1122 (Yellowstone) Official installer released on 5/14/2024 - (**This version has been pulled as a label printing issue was found**)
    
    -   Only different in number from the pre-release build. Either version will work identically.
        
-   7.2.1112 (Yellowstone) Pre-release on 5/13/2024 - (**optional**)
    
-   7.1.1105 (Grand Canyon) released on 3/14/2024 (optional)
    
-   6.3.4053 released on 1/25/2024 (optional)
    
-   6.3.3065 hotfix released on 1/10/2024 (optional)
    
-   6.3.3059 released on 12/17/2023 (optional)
    
-   6.3.2023 released on 11/21/2023 (optional)
    
-   6.3.2007 released on 11/7/2023 (optional)
    
-   6.3.1.1174 released on 8/16/2023 (optional)
    

### Older RazorGage Software (pre RG3)

-   [v34 release on 6/12/2023](https://update.gtp.one/razor/StratusRazorInstall.exe "https://update.gtp.one/razor/StratusRazorInstall.exe")
---
created: 2025-06-25T11:08:05 (UTC -04:00)
tags: []
source: https://gtpservices.atlassian.net/wiki/spaces/SK/pages/2174517261/Publishing+Emails
author: 
---

# Publishing Emails - STRATUS Knowledge Base - Confluence

> ## Excerpt
> After a model is published, an email is sent to the publisher’s email with the following information:

---
After a model is published, an email is sent to the publisher’s email with the following information:

-   **Publish Job Id** \- this is a unique identifier for the publish job processed on the server
    
-   **Desktop Platform** \- this is the specific version information from AutoCAD or Revit
    
-   **Model Size** \- this is the source \*.dwg or \*.rvt file size
    
-   **Model Version** \- this is the revision number from ACC for the model dwg or rvt file
    
-   **Attachments** \- this is the number of related files uploaded during publish
    
-   **Assemblies** \- this is the number of assemblies processed during publish
    
-   **Parts** \- this is the number of parts processed during publish
    
-   **Fabrication Parts** \- this is the number of Fabrication parts processed during publish
    
-   **Views** \- this is the number of views processed during publish
    
-   **Extract Stage** \- this is the minutes spent in data extract data for the job
    
-   **Transform Stage** \- this is the minutes spent in data transform stage for the job
    
-   **Load Stage** \- this is the minutes spent in data load stage for the job
    
-   **Autodesk Processing** \- this is the minutes spent in Autodesk model translation for web viewing, including 2d sheet and 3d view processing
    
-   **Publishing Total** \- total minutes to complete the publish job
    
-   **Warnings** \- these are warnings which may indicate an issue with the model or publish processing
    

### **Sample Publish Email**

This following email is from the publish of a model called, “OnePipe”, published to the “Build Project.”
---
created: 2025-06-25T11:08:05 (UTC -04:00)
tags: []
source: https://gtpservices.atlassian.net/wiki/spaces/SK/pages/1183383557/Revit+Publish+and+Import#RevitPublishandImport-ConfigureBIM360PublishFolderPath
author: 
---

# Revit Publish and Import - STRATUS Knowledge Base - Confluence

> ## Excerpt
> This article describes the steps and settings that impact publishing Revit models to Stratus and importing specific data back into the Revit model. The Stratus Addin is required to publish and import drawing data.

---
This article describes the steps and settings that impact publishing Revit models to Stratus and importing specific data back into the Revit model. The [Stratus Addin](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/10551828/STRATUS+Addin "https://gtpservices.atlassian.net/wiki/spaces/SK/pages/10551828/STRATUS+Addin") is required to publish and import drawing data.

-   1 [Stratus Academy Course Video](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/1183383557/Revit+Publish+and+Import#Stratus-Academy-Course-Video)
-   2 [Revit Publish Model (General Steps)](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/1183383557/Revit+Publish+and+Import#Revit-Publish-Model-(General-Steps))
    -   2.1 [Silent Import / Publish](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/1183383557/Revit+Publish+and+Import#Silent-Import-%2F-Publish)
        -   2.1.1 [Silent Publish Will Fail in these Cases:](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/1183383557/Revit+Publish+and+Import#Silent-Publish-Will-Fail-in-these-Cases%3A)
-   3 [Revit Publish Considerations](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/1183383557/Revit+Publish+and+Import#Revit-Publish-Considerations)
    -   3.1 [Configure BIM 360 Publish Folder Path](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/1183383557/Revit+Publish+and+Import#Configure-BIM-360-Publish-Folder-Path)
        -   3.1.1 [Configure Publish Folder Path - Default Settings](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/1183383557/Revit+Publish+and+Import#Configure-Publish-Folder-Path---Default-Settings)
        -   3.1.2 [Configure Publish Folder Path - Existing Projects](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/1183383557/Revit+Publish+and+Import#Configure-Publish-Folder-Path---Existing-Projects)
        -   3.1.3 [Configure Publish Folder Path - Newly Activated Projects](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/1183383557/Revit+Publish+and+Import#Configure-Publish-Folder-Path---Newly-Activated-Projects)
    -   3.2 [Collaborate > Publish Settings](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/1183383557/Revit+Publish+and+Import#Collaborate-%3E-Publish-Settings)
    -   3.3 [Control the Color of Published Content](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/1183383557/Revit+Publish+and+Import#Control-the-Color-of-Published-Content)
    -   3.4 [Local Model that has Pending Changes Cannot be Published](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/1183383557/Revit+Publish+and+Import#Local-Model-that-has-Pending-Changes-Cannot-be-Published)
    -   3.5 [Fabrication Database Tracking Statuses Must Match Stratus Tracking Statuses](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/1183383557/Revit+Publish+and+Import#Fabrication-Database-Tracking-Statuses-Must-Match-Stratus-Tracking-Statuses)
    -   3.6 [Fabrication Parts Duplicate ID's](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/1183383557/Revit+Publish+and+Import#%5BhardBreak%5DFabrication-Parts-Duplicate-ID's)
    -   3.7 [Fabrication Database Blank Description Error](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/1183383557/Revit+Publish+and+Import#Fabrication-Database-Blank-Description-Error)
    -   3.8 [Override Insulation Visibility](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/1183383557/Revit+Publish+and+Import#Override-Insulation-Visibility)
    -   3.9 [Model Conflict Dialog](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/1183383557/Revit+Publish+and+Import#Model-Conflict-Dialog)
    -   3.10 [Work-Sharing Conflicts](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/1183383557/Revit+Publish+and+Import#Work-Sharing-Conflicts)
    -   3.11 [Revit Shared Nested Parts](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/1183383557/Revit+Publish+and+Import#Revit-Shared-Nested-Parts)
    -   3.12 [Workflow to Utilize CAD Sheets](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/1183383557/Revit+Publish+and+Import#Workflow-to-Utilize-CAD-Sheets)
    -   3.13 [Exclude Selected Part Properties During Publish](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/1183383557/Revit+Publish+and+Import#Exclude-Selected-Part-Properties-During-Publish)
    -   3.14 [Purge Evolve Parameters from Revit Model](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/1183383557/Revit+Publish+and+Import#Purge-Evolve-Parameters-from-Revit-Model)
    -   3.15 [How to Configure Revit Shared Parameter Property](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/1183383557/Revit+Publish+and+Import#How-to-Configure-Revit-Shared-Parameter-Property)
    -   3.16 [Exclude Imports into Fabrication "Item Number" Property](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/1183383557/Revit+Publish+and+Import#Exclude-Imports-into-Fabrication-%22Item-Number%22-Property)
    -   3.17 [Revit 2022 Notification](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/1183383557/Revit+Publish+and+Import#Revit-2022-Notification)
    -   3.18 [Currency Configuration](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/1183383557/Revit+Publish+and+Import#Currency-Configuration)
-   4 [Import, Settings, and Scenarios](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/1183383557/Revit+Publish+and+Import#Import%2C-Settings%2C-and-Scenarios)
    -   4.1 [Import Failures](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/1183383557/Revit+Publish+and+Import#Import-Failures)
    -   4.2 [Property to Map to Stratus Name (Setting) - Assign Tracking Statuses](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/1183383557/Revit+Publish+and+Import#Property-to-Map-to-Stratus-Name-(Setting)---Assign-Tracking-Statuses)
        -   4.2.1 [Property to Map To Status Name is Empty](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/1183383557/Revit+Publish+and+Import#Property-to-Map-To-Status-Name-is-Empty)
        -   4.2.2 [Property to Map To Status Name has a value and the Revit Project Parameter is correct](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/1183383557/Revit+Publish+and+Import#Property-to-Map-To-Status-Name-has-a-value-and-the-Revit-Project-Parameter-is-correct)
    -   4.3 [Assign Assemblies](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/1183383557/Revit+Publish+and+Import#Assign-Assemblies)
        -   4.3.1 [Resolve Conflicts Log](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/1183383557/Revit+Publish+and+Import#Resolve-Conflicts-Log)
        -   4.3.2 [Create an Assembly in Stratus](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/1183383557/Revit+Publish+and+Import#Create-an-Assembly-in-Stratus)
        -   4.3.3 [Rename an Assembly in Stratus](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/1183383557/Revit+Publish+and+Import#Rename-an-Assembly-in-Stratus)
        -   4.3.4 [Delete an Assembly in Stratus](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/1183383557/Revit+Publish+and+Import#Delete-an-Assembly-in-Stratus)
        -   4.3.5 [Assembly Parts Removed in Stratus](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/1183383557/Revit+Publish+and+Import#Assembly-Parts-Removed-in-Stratus)
        -   4.3.6 [Assembly Parts Added in Stratus](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/1183383557/Revit+Publish+and+Import#Assembly-Parts-Added-in-Stratus)
    -   4.4 [Property to Map Package Name (Setting) - Assign Packages](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/1183383557/Revit+Publish+and+Import#Property-to-Map-Package-Name-(Setting)---Assign-Packages)
        -   4.4.1 [Property to Map To Package Name is Empty](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/1183383557/Revit+Publish+and+Import#Property-to-Map-To-Package-Name-is-Empty)
        -   4.4.2 [Property to Map To Package Name has a value, but Revit Project Parameter not set](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/1183383557/Revit+Publish+and+Import#Property-to-Map-To-Package-Name-has-a-value%2C-but-Revit-Project-Parameter-not-set)
        -   4.4.3 [Property to Map To Package Name has a value and the Revit Project Parameter is correct](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/1183383557/Revit+Publish+and+Import#Property-to-Map-To-Package-Name-has-a-value-and-the-Revit-Project-Parameter-is-correct)
    -   4.5 [Property to Map Item Number (Setting) - Assign Item Numbers](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/1183383557/Revit+Publish+and+Import#Property-to-Map-Item-Number-(Setting)---Assign-Item-Numbers)
        -   4.5.1 [Renumber Item Numbers](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/1183383557/Revit+Publish+and+Import#Renumber-Item-Numbers)
        -   4.5.2 [Property to Map To Item Number has a value, but Revit Project Parameter not set](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/1183383557/Revit+Publish+and+Import#Property-to-Map-To-Item-Number-has-a-value%2C-but-Revit-Project-Parameter-not-set)
        -   4.5.3 [Property to Map To Item Number has a value and the Revit Project Parameter is correct](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/1183383557/Revit+Publish+and+Import#Property-to-Map-To-Item-Number-has-a-value-and-the-Revit-Project-Parameter-is-correct)
    -   4.6 [Property to Map To QR Code (Setting) - Assign QR Code](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/1183383557/Revit+Publish+and+Import#Property-to-Map-To-QR-Code-(Setting)---Assign-QR-Code)
        -   4.6.1 [Property to Map To QR Code is Empty](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/1183383557/Revit+Publish+and+Import#Property-to-Map-To-QR-Code-is-Empty)
        -   4.6.2 [Property to Map To QR Code has a value, but Revit Project Parameter not set](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/1183383557/Revit+Publish+and+Import#Property-to-Map-To-QR-Code-has-a-value%2C-but-Revit-Project-Parameter-not-set)
        -   4.6.3 [Property to Map To QR Code has a value and the Revit Project Parameter is correct](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/1183383557/Revit+Publish+and+Import#Property-to-Map-To-QR-Code-has-a-value-and-the-Revit-Project-Parameter-is-correct)
    -   4.7 [Part Property Names (Exclude)](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/1183383557/Revit+Publish+and+Import#Part-Property-Names-(Exclude))

## Stratus Academy Course Video

To take publish related courses, login to [**Stratus Academy**](https://academy.stratus.build/ "https://academy.stratus.build/") and locate the following courses:

-   **ADM-500: Publishing Settings Revit and CAD**
    
-   **VDC-401: Stratus Addin Installation**
    
-   **VDC-403: Prepare Revit Models for Publishing**
    
-   **VDC-405: Publish Revit Models to Stratus**
    

## **Revit Publish Model (General Steps)**

The Revit Publish Model (General Steps) are the basic publish steps. See the sections below for more details about the publishing process. Note: With the release of version 6.1.3 on 3/2/2023, publishing can also be accomplished using the **GTP Stratus Import Silent** and **GTP Stratus Publish Silent** commands where there are no prompts. See the [**Silent Import / Publish**](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/1183383557/Revit+Publish+and+Import#Silent-Import-/-Publish "https://gtpservices.atlassian.net/wiki/spaces/SK/pages/1183383557/Revit+Publish+and+Import#Silent-Import-/-Publish") sub-section for more information.

-   Revit Publish Considerations 
    
-   Stratus Publish Settings
    
-   Import
    

**To publish a model:**

1.  Before publishing, your Stratus administrator can configure settings that will impact the process and data synchronization of the publish and import process including the Assembly Conflict settings Stratus is always right or Revit is always right. See the [**Settings (Admin)**](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/10518994 "https://gtpservices.atlassian.net/wiki/spaces/SK/pages/10518994") article for more information.
    
2.  Before publishing, configure the **BIM 360 Publish Folder Path**. See the [**Configure BIM 360 Publish Folder Path**](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/1183383557#RevitPublishandImport-ConfigureBIM360PublishFolderPath "https://gtpservices.atlassian.net/wiki/spaces/SK/pages/1183383557#RevitPublishandImport-ConfigureBIM360PublishFolderPath") section for more information.
    
3.  In Revit, the GTP Stratus palette ribbon menu add-in will display.  
    
    ![](blob:https://gtpservices.atlassian.net/ac4228fd-3478-433b-b12f-77fff6dc4b6b)
    
4.  **Login to Stratus and Autodesk**
    
    1.  **Stratus Login** - If a user attempts to publish but is not signed in to Stratus, the following prompt will display. The user will enter their credentials.
        
        1.  If the model has not been previously published, the following prompt "Model Not Found in Stratus" will display.
            
            1.  **Publish as New Model** - Click Publish as New Model to proceed.
                
            2.  **Cancel Publish** - Click Cancel Publish to stop the publish or to review the model.
                
    2.  If a user attempts to publish from Revit or AutoCAD but is not signed into Autodesk, the following prompt will display. If the user clicks **OK**, the GTP Stratus Sign In dialog will display.
        
5.  The Publish dialog will display:
    
    1.  **User** - The user who is publishing the model.
        
    2.  **Model** \-  The Model name.
        
    3.  **Company** - Select a **Company** from a list of the logged-in users permitted Companies.
        
    4.  **Project** - Select a **Project** from a list of the logged-in users permitted Projects.
        
        1.  **Note**: See the [**Configure BIM 360 Publish Folder Path**](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/1183383557#RevitPublishandImport-ConfigureBIM360PublishFolderPath "https://gtpservices.atlassian.net/wiki/spaces/SK/pages/1183383557#RevitPublishandImport-ConfigureBIM360PublishFolderPath") section for more information on configuring the **BIM 360 Publish Folder Path.**
            
    5.  **Default 3D View** - Select the **Default 3D View** which will display on the Models > Viewer page. 
        
        1.  **Note**: There must be at least one active 3D View in order to publish to Stratus.
            
        2.  **Note**: The **Default 3D View** drop-down list only displays selected views.
            
        3.  **Note:** After the model has been published, the **Default 3D View** will display on the Models > Viewer page in Stratus. For users who have permission, Views can be manually changed in Stratus.
            
    6.  **Include References**
        
        1.  **Checked (Default)** - When **Include References** is checked linked models, if any, will be included in the publish. When included with the master model publish, these separate files are also uploaded to BIM 360.  Only loaded reference files will be published. Reference models do add time to the publishing process. Reference models display in both 3D and 2D views. See the [**Filters Reference**](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/9043969/Models+Viewer#Filters "https://gtpservices.atlassian.net/wiki/spaces/SK/pages/9043969/Models+Viewer#Filters") section of the Models Viewer article for information.
            
        2.  **Unchecked** - When **Include References** is unchecked and the model contains references, those references will not be published.
            
6.  Click the **Publish** button and the following will occur:
    
    1.  **Publish Activity** - Publish activity will display.
        
    2.  The **Publish** and **Close** buttons are disabled to indicate the publish is in process.
        
    3.  **Fabrication Database Cannot Be Found** - If the Fabrication database cannot be found, a message similar to the following will display.  
        
        ![](blob:https://gtpservices.atlassian.net/a1210bab-1c70-4835-b795-e52ac75ab6c7)
        
        1.  **Yes** - Click **Yes** to continue the publishing process knowing that some Fabrication property values will not be populated depending on the company's default Fabrication database.
            
        2.  **No** - Click No to end the publishing process and review the model.
            
    4.  **Locked Model** - For anyone working within Stratus on a project based on the model being published, the Parts and Assemblies will be locked and view only.
        
        1.  Below is a summary of features that are "Locked" and "Not Locked".
            
            1.  **Locked Options**
                
                1.  Create New Assembly
                    
                2.  Add/Remove Parts To/From and Assembly
                    
                3.  Edit/Rename Assembly
                    
            2.  **Not Locked Options**
                
                1.  Packages – Parts and Assemblies can be added to or removed from a Package.
                    
                2.  Tracking Status – The Tracking Status of any item (Part, Assembly, Package) can be changed.
                    
                3.  Cut Lists – Cut lists can be created and processed.
                    
                4.  Reports – Reports can be used and edited.
                    
                5.  Categories – Categories can be used and edited.
                    
                6.  Filters – Filters can be used and edited.
                    
                7.  Part Templates – Part Templates can be edited.
                    
                8.  Attachments – Attachments can be used and edited.
                    
        2.  When a model is being published and the model is “Locked”, users will notice the following:
            
            1.  **Models Viewe**r - The Models > Viewer canvas is highlighted in red, the publish icon displays next to the model name, and the Actions > Assemblies buttons hover text reads “Disabled during publishing.”
                
            2.  **Assemblies Viewer** - The Assemblies > Viewer canvas is highlighted in red and the publish icon displays next to the model name.
                
            3.  **Assemblies Dashboard** - The publish icon displays next to the model name, the Assemblies > Dashboard buttons to Edit or Delete an assembly item are disabled, and the hover text reads “Disabled during publishing.”
                
    5.  **BIM 360** - The model will be published to your BIM 360 project.  In BIM 360 a published model file is automatically organized under Project Files > Model Name > Stratus > and the authoring tool abbreviation (RVT or DWG).
        
    6.  **Republish is not allowed** - While a model is being published, a second publish of the same model cannot be started. A message similar to the following will display:
        
7.  **Close button enabled** \- When the Stratus Addin completes the publishing process, the **Close** button is enabled and the elapsed time displays. 
    
    1.  Close indicates that the model and related data files have been uploaded to the BIM 360 folder.
        
    2.  The model cannot be viewed in Stratus until the Forge translation completes.
        
    3.  If an existing version of the model or drawing exists, the Stratus publish will overwrite the file with a new version of the file. Stratus always references the most recently published version of any file it displays, assuming it was published using Stratus. You can access older versions as needed.
        
8.  **Post-publish messages** - Depending on the content of the model post-publish messages might display.
    
    1.  Below is a dialog that provides information about Elements with unresolved connectors. To locate the Element in the model, the Element ID listed can be copied and then pasted into Revit under Manage > Select by ID.
        
    2.  The number of dimension points is capped to 40 for any published element. If the number of dimension points published was capped, the Publish was successful dialog will display the following recommendation to use the Stratus sPoint feature.
        
9.  **Forge Translation** - Behind the scenes, Autodesk will translate the file so that it can be viewed in the Autodesk Forge viewer (which is embedded in Stratus). The Models > Viewer page will display a message similar to the following until the Autodesk translation is complete.  This step can take a few minutes to several hours depending on the size of the model.  
    
    ![](blob:https://gtpservices.atlassian.net/0a12b57c-ffe4-4572-8fb3-eaf37812bda3)
    
10.  **Multiple Publishes** - A model with the same name can be published multiple times to Stratus.  Stratus operates on the most recent revision.  Packages will be retained, as they reference unique CAD IDs that remain constant from one publish to the next. 
    
11.  **Initial Tracking Status** - After the initial publish to Stratus, the initial tracking status of all parts in the model will be set to Design or the #1 tracking status configured under Admin > Company > Tracking Statuses. Subsequent publishes will retain the Stratus tracking status.
    
12.  **Assemblies** \- Assemblies that were created in Revit will be accessible in Stratus in the Assemblies Viewer.
    
13.  **New Revit Parameters** - Newly created Revit parameters are automatically added to Part Templates where the **Item Number** setting will be unchecked by default. As a result, it will not change whether or not the part is unique in relation to Item Numbering Rules. Below is an example of a newly created Revit parameter published to Stratus with the Item Number checkbox set unchecked.   
    
    ![](blob:https://gtpservices.atlassian.net/4051df54-09e3-42b2-b28b-2c8000bb3628)
    
14.  **Model Publish Notification** - After a model is published, the person who published the model will receive an automated email notification similar to the following that indicates the publish completed or failed.
    
15.  **Republish Model** - After a model is published, if the Publish is clicked, Stratus will determine if data needs to be imported. If so, the **import will begin automatically**.  If there are import conflicts based on company or project settings (see the [**Settings (Admin)**](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/10518994 "https://gtpservices.atlassian.net/wiki/spaces/SK/pages/10518994") article for more information), the user will receive prompts to resolve issues. Once data is imported the publish process will continue.  An import is required when a model in Stratus has new assemblies or packages, or parts have been moved from one assembly or package to another, or when a tracking status has changed.
    

## Silent Import / Publish

The **GTP Stratus Import Silent** and **GTP Stratus Publish Silent** commands for Revit were added in version 6.1.3 on 3/2/2023. Running these commands from the Revit ribbon will import and publish the model without any prompts or selections. The real power of these commands to enable Revit customers to schedule the model import/publish process by calling these Revit commands with a separate (non-GTP) tool.

Perquisites to use either **GTP Stratus Import Silent** and **GTP Stratus Publish Silent** commands:

1.  Install the v6.1.3 Stratus Addin.
    
2.  Open a model that has been previously published. If the model path has changed since the last publish, using this tool will result in an error.
    
3.  Make sure you are Signed In.
    
4.  Check that **Stratus is always right** or **Revit is always right** under Admin > Company > Settings > AutoCAD & Revit > Specific to Revit > Assembly Conflict Resolution.
    
    1.  **Note:** For any conflicts, there will not be any prompts and the tool will automatically accept all defaults and import data.
        

To manually use the **GTP Stratus Publish Silent** command:

1.  Under External Tools, click **GTP Stratus Publish Silent**.
    
2.  The first step is to execute the **GTP Stratus Import Silent**. You may see import dialogs but the user will not be prompted for any information or clicks. The command will automatically accept all defaults and import data.
    
3.  Once complete, the model will be published. You may see a publish dialog but the user will not be prompted for any information or clicks. The company, model, and folder will be automatically selected based on the previous model publish settings.
    

To manually use only the **GTP Stratus Import Silent** command:

1.  Under External Tools, click **GTP Stratus Import Silent**.
    
    1.  **Note:** Do NOT use either the GTP Stratus V1 Import or GTP Stratus V1 Import Silent commands that are visible in external tools.
        
2.  You may see import dialogs but the user will not be prompted for any information or clicks. The command will automatically accept all defaults and import data.
    

### Silent Publish Will Fail in these Cases:

-   On first publish
    
-   No access to central model
    
-   If worksets cannot be checked out
    
-   If publishing is disabled in Stratus
    
-   If the model is being published by someone else (or is stuck in a prior publish)
    
-   The import bundle cannot be retrieved from Stratus in less than 1 hour
    
-   The imported stratus tracking statuses do not match the fab db
    
-   Failure to obtain Stratus or Bim360 credentials
    
-   If the model file name starts with a leading space
    
-   If the model is empty
    
-   If the model contains duplicate guids
    
-   If you moved he model location since last publish
    

## Revit Publish Considerations

For Revit users, there are some additional steps you can take to control what is published and improve performance. When publishing models from Revit, it is up to the user to specify which 2D views, 2D sheets and 3D views will be available in Stratus.  The views under Collaborate > Publish Settings, must be specified inside Revit prior to running the Stratus publish command.  This is an especially important step for the Stratus assembly viewer, because if the 3D view for each assembly is included, then the assembly will load much faster inside the Stratus assembly viewer.  If the 3D view for an assembly is not included, then, Stratus will first load the entire model and then will filter the model to the selected assembly which is a much slower process.

## Configure BIM 360 Publish Folder Path

See the following sections for how to configure the A360 Publish Folder Path

-   [**Configure Publish Folder Path - Default Settings**](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/1183383557#RevitPublishandImport-ConfigurePublishFolderPath-DefaultSettings "https://gtpservices.atlassian.net/wiki/spaces/SK/pages/1183383557#RevitPublishandImport-ConfigurePublishFolderPath-DefaultSettings")
    
-   [**Configure Publish Folder Path - Existing Projects**](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/1183383557#RevitPublishandImport-ConfigurePublishFolderPath-ExistingProjects "https://gtpservices.atlassian.net/wiki/spaces/SK/pages/1183383557#RevitPublishandImport-ConfigurePublishFolderPath-ExistingProjects")
    
-   [**Configure Publish Folder Path - Newly Activated Projects**](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/1183383557#RevitPublishandImport-ConfigurePublishFolderPath-NewlyActivatedProjects "https://gtpservices.atlassian.net/wiki/spaces/SK/pages/1183383557#RevitPublishandImport-ConfigurePublishFolderPath-NewlyActivatedProjects")
    

### Configure Publish Folder Path - Default Settings

1.  By default, the A360 Publish Folder Path for each project is set to **Project Files\\Stratus**.
    
2.  The project can be selected in the Publish dialog.
    
3.  After the model has been published, Stratus will create sub-folders (Ex. Hosptial and RVT). 
    
    1.  _Note: This will create a folder named “Stratus” in the folder you chose. If you already have a folder named “Stratus”, this will be the root folder used when publishing. If you have a folder name like “Stratus”, where the case does not match, please rename it to be spelled with all caps._
        
4.  Sub-folders (Ex. RVT, ESJ, MAJ, Parts, Assemblies and Assembly Names, Packages and Package Names, Reference, CSV) will be created as those file types are generated in Stratus. 
    
    1.  **Syntax:** Project Files\\Stratus\\Project sub-folder\\
        
    2.  **Example**: Project Files\\Stratus\\Hosptial \\**RVT**\\Hosptial.rvt
        
        1.  **Note:** For publishes after 11/5/21, Reference files are located in the RVT sub-folder.
            
    3.  **Example:** Project Files\\Stratus\\Hosptial \\**ESJ**\\Hosptial .esj
        
    4.  **Example:** Project Files\\Stratus\\Hosptial \\**MAJ**\\Hosptial .maj
        
    5.  **Example:** Project Files\\Stratus\\Hosptial \\**Packages**\\**GTP00002-FP-0001**\\Attachment01.pdf
        
5.  If this file structure is not how your company organizes files, then see the following sections for more information. 
    

-   [**Configure Publish Folder Path - Existing Projects**](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/1183383557#RevitPublishandImport-ConfigurePublishFolderPath-ExistingProjects "https://gtpservices.atlassian.net/wiki/spaces/SK/pages/1183383557#RevitPublishandImport-ConfigurePublishFolderPath-ExistingProjects")
    
-   [**Configure Publish Folder Path - Newly Activated Projects**](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/1183383557#RevitPublishandImport-ConfigurePublishFolderPath-NewlyActivatedProjects "https://gtpservices.atlassian.net/wiki/spaces/SK/pages/1183383557#RevitPublishandImport-ConfigurePublishFolderPath-NewlyActivatedProjects")
    

### Configure Publish Folder Path - Existing Projects

**Warning:** The **A360 Publish Folder Path** can be edited for existing projects, however, any models that have already been published to an **A360 Publish Folder Path** will continue to be published to the same BIM 360 folder path. In other words, a model can only have one **A360 Publish Folder Path**. Only newly published models will use an edited **A360 Publish Folder Path.**

By default, the **A360 Publish Folder Path** for each project is set to **Project Files\\Stratus**. To set the A360 Publish Folder Path to a different \\Project Files sub-folder:

1.  In BIM360, create a Project Files sub-folder (Ex. NEBRASKA).
    
2.  In Stratus, go to Admin > Company > Projects and identify the project whose path needs to be edited (Ex. GTP - ITM - CAD - Revit).
    
3.  Under **A360 Folder Path**, click the cell, and edit the path to match the BIM360 path. (Example: Project Files\\NEBRASKA)  
    
    ![](blob:https://gtpservices.atlassian.net/cbd06379-2c99-456a-8c06-0f2e12b9cdff)
    
    1.  **Note**: The path must include Project Files\\
        
    2.  **Note**: If the Project Files sub-folder was not created in the correct path in A360, a message similar to the following will display:
        
4.  With the project selected in the Publish dialog, the model will be stored in the **A360 Folder Path (Ex. Project Files\\NEBRASKA)**.
    
5.  The model will be saved to A360. Sub-folders (Ex. RVT, ESJ, MAJ, Parts, Assemblies and Assembly Names, Packages and Package Names, Reference, CSV) will be created as those file types are generated in Stratus.
    
    1.  **Syntax:** Project Files\\NEBRASKA\\Project sub-folder\\
        
    2.  **Example**: Project Files\\NEBRASKA\\School\\**RVT**\\School.rvt
        
        1.  **Note:** For publishes after 11/5/21, Reference files are located in the RVT sub-folder.
            
    3.  **Example:** Project Files\\NEBRASKA\\School\\**ESJ**\\School.esj
        
    4.  **Example:** Project Files\\NEBRASKA\\School\\**MAJ**\\School.maj
        
    5.  **Example:** Project Files\\NEBRASKA\\School\\**Packages**\\**GTP00002-FP-0001**\\Attachment01.pdf
        

### Configure Publish Folder Path - Newly Activated Projects

A newly activated project is a new BIM 360 project that has been added to Stratus by clicking the **Add Projects from BIM 360 Docs** button under Admin > Company Projects. The **Default Company A360 Root Folder Path** provides for a consistent folder structure for all newly activated projects. By default, the **Default Company A360 Root Folder Path** is set to Project Files\\Stratus. 

To configure a different **Default Company A360 Root Folder Path** for future projects:

1.  Under Admin > Company > Projects, click the **Default Company A360 Root Folder Path** link.
    
    ![](blob:https://gtpservices.atlassian.net/31f23d13-c874-4b02-b2dc-7b67f9896389)
    
2.  Enter the path with sub-folders separated by backslashes (\\) (Ex. Project Files\\Stratus - Pipe). 
    
3.  When the model is published the **Default Company A360 Root Folder Path** sub-folders in A360 will be created.
    

## Collaborate > Publish Settings

1.  In Revit click **Collaborate** > **Publish Settings** to display the Publish Settings dialog.  
    
    ![](blob:https://gtpservices.atlassian.net/a7ed8c96-0c18-4956-9714-5e36b3d08288)
    
2.  Select one or more **Select Sets** at the top of the dialog.  
    
    1.  **Note:** Changes that you make in the **Edit Set** list of checkboxes only modifies the selected “Select Set”,  “BUILDERS WORKS” in the example above. Be sure to check the **“Include” checkbox** for the set at the top of the dialog before clicking Save & Close.
        
3.  Use the **Show in list** drop-down and **Search** criteria to correctly check the views and sheets you want Autodesk to translate for web viewing. GTP suggests that you check all 3d assembly views and the default 3d ortho view to be displayed in the Stratus model viewer. If you want a Revit sheet to be displayed in Stratus, it must be included in publish settings. If you don't find the a specific spool assembly sheet in STRATUs, you can determine if it was published by open the model RVT in BIM 360 and locate the 2D sheet. If it's not there, it won't be in Stratus either.
    
    1.  **Note:**  If a view isn't checked, it won’t be in Stratus.
        
    2.  **Note**: It is important to select the view that you will choose in the Stratus Publish Dialog under the Default 3D View option.
        
    3.  **Note:** After the model has been published, the default 3d ortho view will display on the Models >Viewer page, the 3d assembly view will display for each Revit assembly you select in the Assemblies > Viewer, and, if you selected any sheets, you can click the Sheets tab in the Assemblies > Viewer to display the selected 2D sheet.
        
    4.  **Note:** For a cloud workshared model, you must use the Synchronize with Central tool to update your changes, and use the Manage Cloud Models tool to publish the latest version of the model in the cloud.
        
4.  Click **Save & Close**.
    
    1.  Don't ignore this warning if it displays. It means that all views will be published which can take significantly longer to publish.  
        
        ![](blob:https://gtpservices.atlassian.net/6dcde1f8-55a2-4235-aa5c-c07440fb21dc)
        

## Control the Color of Published Content

You can control the color of published content by using view filters in your Stratus publish views and setting the view to shaded.

1.  Create the filters on your content. For example, you may want to differentiate branch lines from feeders, or, something based on worksets.
    
2.  Apply visibility overrides using those filters on the colors for solid pattern and the lines.  
    
    ![](blob:https://gtpservices.atlassian.net/21c00164-a94c-49e9-8af9-6c7539931977)
    
3.  The color changes will display in Stratus after publishing.
    

## Local Model that has Pending Changes Cannot be Published

A Revit user cannot publish an out-of-date model. If a Revit user tries to publish a local model that has pending changes which have not been synched from the central model, the user will be blocked from publishing until the model has been synched.

## Fabrication Database Tracking Statuses Must Match Stratus Tracking Statuses

1.  For Fabrication users, before publishing, all Stratus tracking statuses must match (case sensitive) a tracking status in your Fabrication database. Otherwise, an error will display.
    
2.  Otherwise, an error will display. In this case, the Fab “Status” will not be updated, but if the “Stratus Status” is setup it will update properly.
    
3.  When a fab part gets updated to a tracking status in Stratus that is not in the FAB DB the **Stratus Status** will still import into Revit if the Stratus Status parameter is setup. **Note**: The best solution is to update the statuses in the Fab DB.
    
    1.  In instances where the status is in the FAB DB the statuses will match and both be correct.
        

##   
Fabrication Parts Duplicate ID's

During the Stratus publish process, Duplicate ID’s are filtered out so no data is published. If Fabrication parts have Duplicate ID’s, something similar to the following will display where no data displays under Properties when the part is selected. To fix this issue in your Fabrication database, see the [**How to Fix Fabrication Parts that have Duplicate ID's**](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/269680683 "https://gtpservices.atlassian.net/wiki/spaces/SK/pages/269680683") article.

## Fabrication Database Blank Description Error

When custom data has a blank description in the Fabrication Database, a warning message will display in the publish dialog (Ex. Custom data ids which have no names: \[#\]. To correct these, ensure that each custom data field exists in the fabrication database.) will display in the publish pop-up dialog.

## Override Insulation Visibility

Before publishing, the modeler should use visibility graphics to override insulation visibility.  The Autodesk Forge viewer thinks insulation is a separate part. As a result, you need to publish the model without insulation.

## Model Conflict Dialog

During the publishing process, the **Model Conflict** dialog may display if the model had been published from a different location, which means that Stratus has detected that the path of the model being published has changed. Those who publish from a central model will not get this dialog. **Stratus best practice** - Do not move or copy the model once it has been published.  If it is moved or copied, the **Model Conflict** dialog will display. Users should verify that they are publishing the latest model. When the **I Moved It** button or the **I Copied It** button is clicked, Stratus will overwrite the existing model in BIM 360 and may change parts, assemblies, and packages in Stratus.

**The Model Conflict dialog displays the following options:**

1.  **I Copied It** - If you copied the model to a new location and click the **I Copied It** button, the Import Process will stop and the QR code and package properties will be cleared from the model. When published, the model will be published as a new model.  
    
    ![](blob:https://gtpservices.atlassian.net/df4c19f5-1a4d-4c8e-a184-34ef94474075)
    
2.  **I Moved It -** If you moved the model and click the **I Moved It** button, the import will proceed as normal. When you publish the model, it will overwrite the model in Stratus.
    
3.  **Cancel** - Click the **Cancel** button to cancel the import process. 
    

## Work-Sharing Conflicts

To avoid work-sharing conflicts:

1.  If User A does not have session ownership of the model attempts to Import the model, a message will display informing User A that User B must sync the model before changes can be imported.   
    
    ![](blob:https://gtpservices.atlassian.net/db0182be-810e-477e-8beb-417179dcb59d)
    
2.  If User A does not have session ownership of the model and attempts to Publish the model, a message will display informing User A that User B must sync the model before it can be published.  
    
    ![](blob:https://gtpservices.atlassian.net/22a497ac-3a7a-4a61-bbcd-5d9d963303f0)
    

When Revit shared nested parts are used AND Stratus is being used to assemble those components, the following workflow needs to be followed:

1.  Under Settings, uncheck **Publish Nested Family Assemblies** and under Assembly Conflict Resolution, set **Stratus is always right**.
    
2.  The first publish brings Revit content into Stratus.
    
3.  In Stratus use the **Window Select tool** to create assemblies that include a parent family with child shared nested parts. If the **Window Select tool** is not used, the Stratus assembly will not include the shared nested parts and child components.
    
4.  Run the Stratus **Import** inside of Revit which will create the Revit Assemblies and will then include the shared nested components.
    
5.  Publish from Revit and the Stratus Assemblies will now include all of the shared nested components.
    

## Workflow to Utilize CAD Sheets

If you plan to annotate sheets in Revit and utilize the CAD Sheets in Stratus under [**Assemblies > Viewer > CAD Sheets**](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/8749081 "https://gtpservices.atlassian.net/wiki/spaces/SK/pages/8749081"), the following are the recommended steps: 

1.  Publish Revit model without assemblies to Stratus.
    
2.  Create Assemblies in the Stratus website.
    
3.  Import assemblies back into Revit.
    
4.  Annotate assembly sheets in Revit.
    
5.  Make sure assembly sheets are included in Revit publish set.
    
6.  Publish to Stratus.
    
7.  View assembly CAD Sheets in Stratus.
    

## Exclude Selected Part Properties During Publish

Part Properties can be excluded from being published and from being available in Stratus once they are published. This is especially useful when a third-party software has added hundreds of properties to parts in the model which significantly increases the publish time. For more information see the [**Exclude Selected Part Properties During Publish**](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/217809750/Part+Templates+Admin#Exclude-Selected-Part-Properties-During-Publish "https://gtpservices.atlassian.net/wiki/spaces/SK/pages/217809750/Part+Templates+Admin#Exclude-Selected-Part-Properties-During-Publish") section of the Part Templates (Admin) article.

## Purge Evolve Parameters from Revit Model

An Evolve Revit model can include 500+ parameters for each part which can really slow down the Stratus model publish process and loading models in Stratus viewers (Models, Packages, and Assemblies). Some customers report that Stratus sync times are reduced from 1 hour to 5 minutes. Below are steps to purge unused Evolve parameters from Revit model. These steps can be done in template files and will not add all the other parameters each time they are opened.

1.  Within the Revit model, click the **eVolve Mechanical tab** \> **Utilities** \> **Settings** \> **Manage Mechanical Properties**.
    
2.  The **Project Manage Mechanical Properties** dialog will display. Click the **Disable All** button and then **Apply**.
    
3.  Necessary parameters can be added back and applied.
    
4.  **Note**: The Export/Import feature can also be used in other projects to only include the Shared Project Parameters your company uses.
    

A Revit Project Parameter Property can also be configured, but a Revit Shared Parameter Property has the advantage of being taggable and reportable in Revit.

**Note**: If the Shared Parameters on a RVT file match the names in the fabrication database, then there is an overwrite, and the values in Stratus are not translated back-and-forth between multiple import-publish cycles. To fix this, users will need to rename the duplicate Shared Parameter name(s) so that they are not the same names as in the FAB database.

Below is an example of configuring a **Revit Shared Parameter Property.**

**Configure Revit Shared Parameter Property Example**

Below is a Revit electrical model example where you can associate Revit assemblies and sheet views in Stratus. You’ll map the **Property To Associate Sheets With Assemblies** and the **Property To Map to Assemblies (formerly Property To Recognize For Assemblies)** Stratus settings to project parameters in Revit and in Stratus.

1.  To create a project parameter in Revit, go to Manage > Project Parameters.
    
    1.  Add the new project parameter Ex. Conduit Prefab ID, set the type to Text, select the **Values can vary by group instance,** and apply it to Conduit Categories.
        
    2.  Add another project parameter Ex. Stratus Sheet, set the type to Text, select the **Values can vary by group instance,** and apply it to the Sheet and Views Categories.
        
2.  In Stratus, under Admin > Company > Settings, enter the project parameter names:
    
    1.  **Property To Map tp Assemblies(formerly Property To Recognize For Assemblies)** Stratus = Conduit Prefab ID
        
    2.  **Property To Associate Sheets With Assemblies** = Stratus Sheet
        
    3.  **Auto-Generate Assembly Views and Sheets** – Unchecked as you probably don’t want to auto-generate assembly views and sheets. This still generates the Revit assembly if an assembly is first created in Stratus, just not the assembly views and sheets to go along.
        
3.  In Revit, set each assembly name in the Conduit Prefab ID project parameter and create your sheets.  
    
    ![](blob:https://gtpservices.atlassian.net/06979bfc-4207-49b6-b153-6c5c1f1e8cf7)
    
4.  In Revit, under Collaborate > Publish Settings, select the Sheets that need to be published as well as any other 3D Views.  
    
    ![](blob:https://gtpservices.atlassian.net/c8fd39ff-fe28-4e74-829f-e607df667ae0)
    
5.  Publish the model.
    
6.  The following will be published to Stratus:
    
    1.  In the Models > Viewer, the selected assembly displays a link to the assembly.
        
    2.  In the Assemblies > Dashboard, all the assemblies are defined using the “Conduit Prefab ID project parameter” display.  
        
        ![](blob:https://gtpservices.atlassian.net/5c97d0c9-4983-4e26-9bb1-0c4e1591c054)
        
    3.  The Revit assembly sheet will display.  
        
        ![](blob:https://gtpservices.atlassian.net/809c602c-efe5-4ab0-a493-d16a4ebe1422)
        
7.  If you create new assemblies in Stratus and then Import the model, you’ll find that:
    
    1.  Currently, the Revit assemblies are created.
        
8.  In the future, there will be an option to populate the “Conduit Prefab ID project parameter” with the Stratus assembly number.
    

## Exclude Imports into Fabrication "Item Number" Property

A checkbox setting called **Exclude Imports into Fabrication "Item Number" Property** in the \[Company Admin > Settings > AutoCAD, Revit… > Specific to Revit\] page directly under the Property to Map to Item Number setting.

When enabled the Stratus Revit addin will NOT import your Stratus.Part.Number values are added to the Fabrication “Item Number” property. This can be useful when using Revit groups as they do not support unique Item Number values on parts contained within them.

## Revit 2022 Notification

If you use Revit 2022 you may receive the Revit “Stop running this script?” message during the Import process. Autodesk provides information on how to resolve the issue at: [**Manage Cloud Models in Revit**](https://knowledge.autodesk.com/support/bim-360/troubleshooting/caas/sfdcarticles/sfdcarticles/Script-error-when-opening-Manage-Cloud-Models-in-Revit.html "https://knowledge.autodesk.com/support/bim-360/troubleshooting/caas/sfdcarticles/sfdcarticles/Script-error-when-opening-Manage-Cloud-Models-in-Revit.html")  

[![](blob:https://gtpservices.atlassian.net/a46bfc4b-7f62-4bc5-a4ee-e7ecb28338f0)](https://knowledge.autodesk.com/support/bim-360/troubleshooting/caas/sfdcarticles/sfdcarticles/Script-error-when-opening-Manage-Cloud-Models-in-Revit.html)

## Currency Configuration

During publish, the currency selected in AutoCAD will be imported and used as the currency for the model in Stratus.

## Import, Settings, and Scenarios

Based on Stratus Settings, importing Stratus data into the model and then publishing the model back to Stratus presents many different scenarios. This section covers the import process under different settings and scenarios. For mapping property data back to the model like "item number mapping", see the Property to Map sections below.

## Import Failures

An import will fail and an error message will display if either of the following is true:

1.  For Fabrication users, before publishing all Stratus tracking statuses must match (case sensitive) a tracking status in your Fabrication database. If Stratus detects a mismatch, a dialog similar to the following will display. Click **OK** and then you must match the Tracking Statuses between the Fabrication database and Stratus before proceeding.
    
2.  Another import failure will occur if the person who attempts to import from Stratus cannot write to the Fabrication database.
    

## Property to Map to Stratus Name (Setting) - Assign Tracking Statuses

### Property to Map To Status Name is Empty

1.  If the **Property to Map To Status Name** has a value Ex. Stratus Status, it means that on import, the Import process will attempt to set a Revit Project Parameter named Stratus Status to the value in Stratus.
    
2.  Import the model. The Imported Changes dialog will display. In this case, a list of tracking statuses that can be changed in Revit should display. However, since a Revit Project Parameter has not yet been created, the import FAILS and the dialog indicates that the Revit Tracking status property does not exist for part or assembly \[Element ID\]. Note: The same result would be true if a Revit Project Parameter were created but the name did not match the Stratus **Property to Map To Status Name.**
    

### Property to Map To Status Name has a value and the Revit Project Parameter is correct

1.  See the Example Stratus Knowledge Base article [**Settings (Admin)**](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/10518994 "https://gtpservices.atlassian.net/wiki/spaces/SK/pages/10518994") and the Configure Revit Project Parameter Property section for more information.
    
2.  If you have configured a Revit Project Parameter and set a matching value in the **Property to Map To Status Name**, then Import the model.
    
3.  The Imported Changes dialog will display. The result should list tracking statuses that can be changed in Revit. In this case, there are mixed results:
    
    1.  Parts, like walls, whose categories were not added to the Revit Project Parameter, will FAIL, but that’s okay. To verify, select the part’s Element ID (the number in brackets) in the model. Determine if the category should be included in the Revit Project Parameter setting for Stratus Status. If so, add the category to the Revit Project Parameter. If not, it is safe to ignore.
        
4.  Scroll down and you’ll find that the import also successfully assigned tracking status for parts and assemblies. The part’s Element ID is the numbers in brackets and can be selected in the model.
    

## Assign Assemblies

Below are descriptions of the dialogs to delete an assembly, rename an assembly, remove parts from an assembly, or add parts to an assembly. It is important to note that these operations are controlled by the Admin > Company > **Tracking Status** > **Can Assemble** flag (checked) for the tracking status the part is in. In order to see results for any of these operations, the Can Assemble flag must be checked for the part.  

When an assembly is created in Stratus, it is assigned a Stratus Assembly ID.  When this assembly is imported into Revit, Revit creates an assembly object for the assembly and assigns a different Assembly ID.  When the model is re-published, the Revit ID replaces the Stratus ID. When the model is imported again into Revit, the Revit Assembly ID and the Stratus Assembly ID match.

### Resolve Conflicts Log

A .TXT log of all changes, including Resolve Conflicts, can be opened on the computer of the user who published the model via Windows Explorer by entering: %appdata%, and then in the GTP Stratus Logs folder under either AutoCAD or Revit folder there will be a list of published models will display.

### Create an Assembly in Stratus

1.  In Stratus, create an assembly. The assembly can be included in a Package or not.
    
2.  Open the Revit model.
    
3.  Click the **Import** button in the Revit model. The Imported Changes dialog will display. In this case, 36 parts were “automatically assigned part to \[Element ID\] to \[assembly name\].
    
4.  Click **OK** to accept the changes.
    
5.  In the Revit model, under the **Project Browser** > **Assemblies** the new assembly will display.
    
6.  Sheets have not yet been created.
    

### Rename an Assembly in Stratus

1.  In Stratus, go to the Assemblies > Dashboard.
    
2.  Click the **Edit** selected item button associated with the assembly.
    
3.  **Rename** the assembly and **Save**. The assembly name should reflect the new name in the Dashboard.
    
4.  Open the Revit model.
    
5.  Click the **Import** button in the Revit model. The Imported Changes dialog will display. In this case, 27 parts were “automatically changed part \[Element ID\] from one \[assembly name\] to the new \[assembly name\].
    
6.  Click **OK** to accept the changes.
    
7.  In the Revit model, under the Project Browser, expand **Assemblies** and you should see the renamed assembly name.
    
8.  In Stratus, the Auto-Generate Assembly Views and Sheets can be checked before the import.
    
9.  If this is done, then in the Revit model, under the Project Browser, expand **Assemblies** and you will see the assembly name. Stratus has added one or more assemblies to the model. Notice that the assembly can be expanded.
    

### Delete an Assembly in Stratus

1.  In Stratus, go to the Assemblies > Dashboard.
    
2.  Click the **Delete** button associated with the assembly and confirm the deletion.
    
3.  Open the Revit model.
    
4.  Click the **Import** button in the Revit model. The Imported Changes dialog will display. In this case, 27 parts were “automatically removed part \[Element ID\] from \[assembly name\].
    
5.  Click **OK** to accept the changes. The Autodesk Revit warning will display. This Revit message notes that because the assembly doesn’t exist, the views and sheets will also be deleted.
    
6.  Click the **Delete Elements** button.
    
7.  In the Revit model, under the Project Browser, the assembly has been deleted.
    
8.  Publish the model back to Stratus.
    
9.  After the Publish completes and the model is refreshed in the Stratus Models > Viewer, go to the **Assemblies** > **Dashboard** and refresh the page. The deleted assembly does not display. At this time, the assembly is fully deleted from the database.
    

### Assembly Parts Removed in Stratus

1.  In Stratus, go to the **Models** > **Viewer**.
    
2.  Go to **Actions** > **Assemblies** and select an existing assembly.
    
3.  Hover over one of the assembly parts, press tab, and then click to select one part.
    
4.  Click the **Remove selected parts from assembly** button. The part will be removed from the assembly.
    
5.  Repeat as needed to remove additional parts.
    
6.  Click the **Import** button in the Revit model. The Resolve Assembly Conflicts dialog similar to the following will display. It notes that it is **Resolving 1 of 5 assembly conflicts**. This dialog displays because for the given **Revit Element ID,** the **Revit Assembly Name** exists, but the **Stratus Assembly Name** does not exist. The Import process cannot determine whether a part has been removed using Stratus or if a part has been added in Revit. 
    
7.  The user will need to make two decisions:
    
    1.  To either **Reassign to the Assembly specified in Stratus** or **Keep the Assembly in the Revit Model.**
        
        1.  **Reassign to the Assembly specified in Stratus** – Clicking this option will reassign the Revit Element ID to the assembly specified in Stratus. The Stratus Assembly Name is blank, so the Revit Element ID (part) will be removed from the Revit Assembly Name.
            
            1.  After clicking the **Reassign to the Assembly specified in Stratus** button, the import process will continue, and the Imported Changes dialog will display. In this case, 2 parts were “Manually removed part \[Element ID\] from \[assembly name\].
                
            2.  Click **OK** to accept the changes or Cancel Import to cancel the process. 
                
            3.  Select the assembly in the model and the 2 parts manually removed parts will not be part of the assembly.
                
        2.  **Keep the Assembly in the Revit Model** – Clicking this option will keep the Revit Element ID associated with the Revit Assembly Name.
            
            1.  When the model is Published, the parts previously removed in Stratus above will be re-added as part of the assembly.
                
    2.  To either **Apply to all remaining conflicts** or **Apply to all parts in this Assembly**
        
        1.  When checked, the **Apply to all parts in this Assembly** option replaces the necessity to resolve conflicts for each part and enables the person importing the model to resolve conflicts for each assembly.
            
        2.  When checked, the **Apply to all remaining conflicts** option will apply your selection to all remaining conflicts.
            
8.  **Cancel Import** – Click this option to cancel the import process. This gives the person importing the model an opportunity to stop the import and investigate if needed.
    
9.  **Publish** the model to Stratus.
    
10.  Once the publish is complete, refresh the Models > Viewer page.
    
11.  Go to **Actions** > **Assemblies** and select an existing assembly.
    
    1.  If the **Reassign to the Assembly specified in Stratus** decision was made above, the 2 removed parts will not be part of the assembly.
        
    2.  If the **Keep the Assembly in the Revit Model** decision was made above, the 2 removed parts will be part of the assembly.
        

### Assembly Parts Added in Stratus

1.  In Stratus, go to the **Models** > **Viewer**. In this case, add 2 parts to the selected assembly.
    
2.  Go to **Actions** > **Assemblies** and select an existing assembly.
    
3.  Select the 2 parts and then click the **Add select parts to the assembly** button.
    
4.  Click the **Import** button in the Revit model. The Resolve Assembly Conflicts dialog similar to the following will display. It notes that it is **Resolving 1 of 2 assembly conflicts**. This dialog displays because for the given **Revit Element ID,** the **Revit Assembly Name** does not exist, but does have a **Stratus Assembly Name**. The Import process cannot determine whether a part has been added using Stratus or if a part has been removed from a Revit assembly.  
    
5.  The user will need to make two decisions:
    
    1.  To either **Reassign to the Assembly specified in Stratus** or **Keep the Assembly in the Revit Model.**
        
        1.  **Reassign to the Assembly specified in Stratus** - After clicking the **Reassign to the Assembly specified in Stratus** button, the import process will continue, and the Imported Changes dialog will display. In this case, 4 parts were “Manually assigned part \[Element ID\] to \[assembly name\]."
            
            1.  Click **OK** to accept the changes or Cancel Import to cancel the process.
                
            2.  Select the assembly in the model and the 2 parts manually added will be part of the assembly.
                
        2.  **Keep the Assembly in the Revit Model** – Clicking this option will keep the Revit Element ID associated with the Revit Assembly Name.
            
            1.  When the model is Published, the parts previously added to the assembly in Stratus above will be removed as part of the assembly.
                
    2.  To either **Apply to all remaining conflicts** or **Apply to all parts in this Assembly**
        
        1.  When checked, the **Apply to all parts in this Assembly** option replaces the necessity to resolve conflicts for each part and enables the person importing the model to resolve conflicts for each assembly.
            
        2.  When checked, the **Apply to all remaining conflicts** option will apply your selection to all remaining conflicts.
            
    3.  **Cancel Import** – Click this option to cancel the import process. This gives the person importing the model an opportunity to stop the import and investigate if needed.
        
6.  **Publish** the model to Stratus.
    
7.  Once the publish is complete, refresh the Models > Viewer page.
    
8.  Go to **Actions** > **Assemblies** and select an existing assembly.
    
    1.  If the **Reassign to the Assembly specified in Stratus** decision was made, the 2 added parts will be part of the assembly.
        
    2.  If the **Keep the Assembly in the Revit Model** decision was made, the 2 added parts will not be part of the assembly.
        

## Property to Map Package Name (Setting) - Assign Packages

### Property to Map To Package Name is Empty

1.  Under **Admin** > **Company** > **Settings**, if the **Property to Map To Package Name** remains **Empty** and then the model is imported, it means there is no field in the Revit model that the Stratus package name can be mapped to.
    
2.  Import the model. The Imported Changes dialog will display. In this case, there should be no imported changes.
    
3.  Since there are no changes to import, the user should click the **Cancel Import** button.
    

### Property to Map To Package Name has a value, but Revit Project Parameter not set

1.  If the **Property to Map To Package Name** has a value Ex. Stratus Package, then, it means that on import, the Import process will attempt to set a Revit Project Parameter named Stratus Package to the value in Stratus.
    
2.  Import the model. The Imported Changes dialog will display. However, since a Revit Project Parameter has not yet been created, the import FAILS and the dialog indicates that the Revit Order Property \[Stratus Package\] does not exist for part or assembly \[Element ID\]. Note: The same result would be true if a Revit Project Parameter were created but the name did not match the Stratus **Property to Map To Package Name.**  
    
    ![](blob:https://gtpservices.atlassian.net/41213317-fad5-4063-a958-d2e322d2e855)
    

### Property to Map To Package Name has a value and the Revit Project Parameter is correct

1.  See the Example Stratus Knowledge Base article [**Settings (Admin)**](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/10518994 "https://gtpservices.atlassian.net/wiki/spaces/SK/pages/10518994") and the Configure Revit Project Parameter Property section for more information.
    
2.  If you have configured a Revit Project Parameter and set a matching value in the **Property to Map To Property Name**, then Import the model.
    
3.  The Imported Changes dialog will display. The result should list of parts or assemblies that have been assigned the Package Name.
    

## Property to Map Item Number (Setting) - Assign Item Numbers

Property to Map Item Number

1.  Under **Admin** > **Company** > **Settings**, if the **Property to Map To Item Number** remains **Empty** and then the model is imported, it means there is no field in the Revit model that the Stratus status can be mapped to.
    
2.  Import the model. The Imported Changes dialog will display. In this case, there should be no imported changes.
    
3.  Since there are no changes to import, the user should click the **Cancel Import** button.
    

### Renumber Item Numbers

1.  In the Assemblies > Viewer, assembly item numbers can be changed in Stratus. Below, the left image shows item numbers from Revit, the right image shows parts renumbered after clicking the **Renumber All Items for Assembly** button.
    

### Property to Map To Item Number has a value, but Revit Project Parameter not set

1.  If the **Property to Map To Item Number** has a value Ex. Stratus Item Number, then, it means that on import, the Import process will attempt to set a Revit Project Parameter named Stratus Item Number to the value in Stratus. And, if the **Apply Item Numbers During Model Import** is checked, then Stratus will update the **Property to Map To Item Number** with the renumbered item numbers.
    
2.  Import the model. The Imported Changes dialog will display. However, since a Revit Project Parameter has not yet been created, the import FAILS and the dialog indicates that the \[Stratus Item Number\] property does not exist for part or assembly \[Element ID\]. Note: The same result would be true if a Revit Project Parameter were created but the name did not match the Stratus **Property to Map To Item Number** value**.**  
    
    ![](blob:https://gtpservices.atlassian.net/279b9f61-d8d0-4e6c-b9ac-d77964690dbd)
    

### Property to Map To Item Number has a value and the Revit Project Parameter is correct

1.  See the Example Stratus Knowledge Base article [Settings (Admin)](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/10518994 "https://gtpservices.atlassian.net/wiki/spaces/SK/pages/10518994") and the Configure Revit Project Parameter Property section for more information. It will display in Revit.
    
2.  Once you have configured a Revit Project Parameter and set a matching value in the **Property to Map To Item Number**, Import the model.
    
3.  The Imported Changes dialog will display.
    
4.  The Stratus Item Number has been sync’ed with the part in the model.
    

## Property to Map To QR Code (Setting) - Assign QR Code

### Property to Map To QR Code is Empty

1.  Under **Admin** > **Company** > **Settings**, if the **Property to Map To QR** remains **Empty** and then the model is imported, it means there is no field in the Revit model that the Stratus package name can be mapped to.
    
2.  Import the model. The Imported Changes dialog will display. In this case, there should be no imported changes.
    
3.  Since there are no changes to import, the user should click the **Cancel Import** button.
    

### Property to Map To QR Code has a value, but Revit Project Parameter not set

1.  If the **Property to Map To QR** has a value Ex. Stratus QR Code, then, it means that on import, the Import process will attempt to set a Revit Project Parameter named Stratus Status to the value in Stratus.
    
2.  Import the model. The Imported Changes dialog will display. In this case, a list of QR Codes that can be changed in Revit should display. However, since a Revit Project Parameter has not yet been created, the import FAILS and the dialog indicates that the \[Stratus QR Code\] property does not exist for part or assembly \[Element ID\]. Note: The same result would be true if a Revit Project Parameter were created but the name did not match the Stratus **Property to Map To QR Code.**  
    
    ![](blob:https://gtpservices.atlassian.net/65f80d4e-b961-41e9-a17b-3817f87c4d51)
    

### Property to Map To QR Code has a value and the Revit Project Parameter is correct

1.  See the Example Stratus Knowledge Base article [Settings (Admin)](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/10518994 "https://gtpservices.atlassian.net/wiki/spaces/SK/pages/10518994") and the Configure Revit Project Parameter Property section for more information.
    
2.  If you have configured a Revit Project Parameter and set a matching value in the **Property to Map To QR Code**, then Import the model.
    
3.  Once you have configured a Revit Project Parameter and set a matching value in the **Property to Map To Item Number**, Import the model.
    
4.  The Imported Changes dialog will display. Some parts that are not in the Project Parameter category will Fail (left) while those that are included will assign the QR code to the part (right).
    
5.  Click OK to apply the changes.
    
6.  The Stratus QR Code has been sync’ed with the part in the model.
    

## Part Property Names (Exclude)

Part Properties can be excluded from being published and from being available in Stratus once they are published. This is especially useful when a third-party software has added hundreds of properties to parts in the model which significantly increases the publish time. For more information see the [**Exclude Selected Part Properties During Publish**](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/217809750/Part+Templates+Admin#Exclude-Selected-Part-Properties-During-Publish "https://gtpservices.atlassian.net/wiki/spaces/SK/pages/217809750/Part+Templates+Admin#Exclude-Selected-Part-Properties-During-Publish") section of the Part Templates (Admin) article.
---
created: 2025-06-25T11:08:05 (UTC -04:00)
tags: []
source: https://gtpservices.atlassian.net/wiki/spaces/SK/pages/2470248450/Stratus+Change+Log
author: 
---

# Stratus Change Log - STRATUS Knowledge Base - Confluence

> ## Excerpt
> The Stratus Changelog details the features and enhancements included in each release.

---
The Stratus Changelog details the features and enhancements included in each release.

Links to the latest Stratus AddIn and other Stratus software is available on the **Installation of GTP Software on Windows** article which includes links to:

-   [GTP Software Installers (Manual)](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/2122022926 "https://gtpservices.atlassian.net/wiki/spaces/SK/pages/2122022926")
    
-   [WinGet Automated Installation of GTP Software](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/2291531777 "https://gtpservices.atlassian.net/wiki/spaces/SK/pages/2291531777")
    

## 23 June 2025 - 7.6.10.46

**Installers:**

-   **Stratus Addin** - None
    
-   **Stratus Workstation** - None
    

update Updated the loading process for the Assemblies Dashboard to better handle scenarios involving hundreds of thousands of assemblies, improving performance and responsiveness during large-scale data loads.

Fixed Fixed an issue where parts in the viewer were filtered but a resulting report included parts outside of the filter.

## 19 June 2025 - 7.6.10.45

**Installers:**

-   **Stratus Addin** - Optional
    
    -   Updated the publish process related to the Specific to Revit > Publish Conduit Assemblies (Custom Mark) setting. Conduit assemblies created in Revit will no longer duplicate when publishing to Stratus, even if the assembly name is changed.
        
-   **Stratus Workstation** - Optional
    
    -   Added support for metric display units.
        
    -   Fixed a cut list scrolling issue.
        

ADDED Added to Stratus Workstation support for metric display units (mm, cm, m). POS/Position and Remaining fields use units configured on the physical TigerStop machine. Under Settings, set the **Cut Length Display Units** and the Length values will displaying accordingly. **Note:** For the Material and Size tab, the 6” value shown in the screenshot will display in metric units if the Revit parts were configured in metric.

update All duct weight properties have been updated to report per item quantity. Material Weight and Weight have been changed to multiply out the rated weight by the centerline length. Duct Weight has been added. If you have your Cost Units set to Per Item Qty on your fittings, the value that you will see after your next publish will potentially be larger than was previously reported. These properties were previously only multiplying weight per ft on straights but are now reporting correctly!

-   A new “Duct Weight” property has been added from the Fabrication database.
    
-   The available weight properties for duct in Stratus are as follows:
    
    -   Duct Weight (Part development weight including conn/seam allowances)
        
    -   Material Weight (Same as Duct Weight but this includes wastage % from the costing database)
        
    -   Weight (Same as Material Weight but also includes including ancillary weight)
        

Example report out of CAD

Example report our of Stratus

update Updated the Required Date field to accept weekend entries, though the Package Schedule will continue to calculate using Monday through Friday only. Previously, Stratus would automatically change the date to the nearest weekday.

update Updated the **Assign New User Role** dialog (Admin > Company > Users > New User > Next) and the **Update User** dialog (Admin > Company > Users > Update User) to support sorting by the checked project column and to display only active Project Names.

update Updated the Insulation Specification Property value to “Not Set” when it is set to “off” in the Fabrication Database.

update Updated the Packages Dashboard to support report data table sorting by up to five Report Sort Indexes. Note: Any indexes beyond the 5th will not be applied.

update Updated Stratus API messaging to return a clear error message when a non-existing “**ViewId**” is used in the “**GET /v1/model/{id}/report/{reportid}**” request. The API now correctly displays the message **"View with ID '<id>' was not found."**

update Updated the Knowledge Base with print setup instructions for configuring computers running the Stratus Workstation app. Refer to the [IT Department Instructions](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/2132574209/Labels+ZPL+Printers+Codes+Troubleshooting+and+Configuration#IT-Department-Instructions "https://gtpservices.atlassian.net/wiki/spaces/SK/pages/2132574209/Labels+ZPL+Printers+Codes+Troubleshooting+and+Configuration#IT-Department-Instructions") section within the Labels, ZPL Printers, Codes, Troubleshooting, and Configuration article.

Fixed Fixed a Stratus Workstation issue scrolling the list of cut list items.

Fixed Fixed an issue in the Package Viewer that prevented Assembly Display Mode colors from displaying correctly. With this fix assembly colors match with the corresponding Display Mode colors.

Fixed Fixed a Display Modes issue where hanger and rod colors did not update to match the Tracking Display Mode color settings.

Fixed Fixed a Models Viewer issue where part Item Number tags in View A persisted in View B, even when those parts were not included in View B. Tags now correctly display only on parts included in the active view.

Fixed Fixed a Package Task issue where moving a task card to the Done column triggered an "Error updating task status" message. The root cause was that the task configured to label print was not assigned to a Station causing the print to fail. This fix suppresses the error if no station is assigned. For more information on how to configure a task to label print, see the [**Example: Label Printing Triggered by Tasks**](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/217711302/Task+Definitions+Admin#Example%3A-Label-Printing-Triggered-by-Tasks "https://gtpservices.atlassian.net/wiki/spaces/SK/pages/217711302/Task+Definitions+Admin#Example%3A-Label-Printing-Triggered-by-Tasks") Knowledge Base article or the [**Stratus Academy**](https://academy.stratus.build/ "https://academy.stratus.build/") course **ADM-518: Task Definitions**.

Fixed Fixed a Tracking Status update issue in Assemblies > Viewer > Parts, ensuring that status changes now reflect immediately upon update.

Fixed Fixed a website page load error that resulted in a 500 response error when navigating to [gtpstratus.com](http://gtpstratus.com/ "http://gtpstratus.com").

Fixed Fixed a Packages Dashboard issue where the Required Date did not match the Required Date set in Packages > Viewer > Properties.

Fixed Fixed a Stratus Sheet issue where the STRATUS.Assembly.PackageRequiredDT property did not display.

Fixed Fixed an issue where Assemblies created from a package that included an assigned Division did not inherit the same Division as the Package.

Fixed Fixed an issue with Project Roles > Packages > Categories where users who did not have the Project Role permission for a given Package Category (e.g., Category A) were still able to open packages assigned to that Package Category.

## 17 June 2025 - 7.6.10.44

**Installers:**

-   **Stratus Addin** - None
    
-   **Stratus Workstation** - None
    

ADDED Added arrow buttons to the Assemblies > Viewer, positioned on either side of the Assembly drop-down, allowing users to navigate to the previous or next assembly.

update Updated Admin > Company > Users to display Active users by default.

update Updated the Big Data sync process to remove deleted content.

update Updated the filter on dashboard columns utilizing a custom date field to ensure they now display the standard required date range column filter.

update Updated the Dashboards (Packages and Assemblies) to ensure the attachment preview box stays within the page border.

update Fixed a CAMduct publish issue where the “Section” and “Notes” properties in CAM were not publishing to Stratus. **Note**: If the issue persists after this release, companies should submit a Service Desk ticket to request deletion of their Lightning database. After deletion, the Lightning database must be republished with defined Sections.

Fixed Fixed a Filters issue where the Systems filter incorrectly displayed all parts in the model. With this fix, only the parts that pertain to the package or assembly display in the filter. Below is an example of the issue that has been resolved.

Fixed Fixed a Stratus Sheet issue that incorrectly removed duplicate tags, when assembly tag pointed to different parts of the same connected assembly.

Fixed Fixed a tracking status issue where removing assemblies from a package failed to update the package tracking status, which should reflect the lowest tracking status of the remaining parts or assemblies.

Fixed Fixed an issue in the Packages Dashboard where blank pages displayed when navigating between multiple pages of data.

Fixed Fixed an issue where editable expression fields failed to recalculate when the edited value was removed or cleared.

Fixed Fixed a Dashboard (Packages and Assemblies) report issue where Date fields did not sort correctly based on their report index setting.

## 12 June 2025 - 7.6.10.43

**Installers:**

-   **Stratus Addin** - Optional
    
    -   Updated Stratus Addin for CAMduct, ESTmep publishing to handle multiple active files within the same CAMduct or CAMest session.
        
-   **Stratus Workstation** - None
    

update Updated the Packages Dashboard “New Package” button to be disabled after it is single clicked to prevent a double-click issue.

update Updated Admin > Company > Activities to display assembly tracking status changes.

update Updated the Window Select tool in all viewers so that users can select the tool and then select content multiple times without losing their previous selection set.

Fixed Fixed a Project Roles issue where a user assigned to a Project Role that did have Desktop > Publish permission was able to publish.

Fixed Fixed an issue when using Task Definitions where completed tasks were not logged to the assigned station for reporting.

## 9 June 2025 - 7.6.10.42

**Installers:**

-   **Stratus Addin** - Optional.
    
-   **Stratus Workstation** - None
    

update Removed the /v1/container/dashboard Open API method and replaced it with Big Data for container data. See the [**Big Data (Admin)**](https://gtpservices.atlassian.net/wiki/x/AYBNo "https://gtpservices.atlassian.net/wiki/x/AYBNo") article for more information.

update Removed deleted secondary reports from Templates and added a message “MISSING - <report name>” similar to the following to inform the Administrator:

## 5 June 2025 - 7.6.10.40

**Installers:**

-   **Stratus Addin** - Fixed an AutoCAD publish issue where parts could be duplicated in assemblies. Update to this installer to resolve the issue.
    
-   **Stratus Workstation**
    
    -   Updated app to support the Lockformer Spiral tool type.
        
    -   Fixed an issue where TigerStop was making extra push movements.
        

ADDED Added support for the Lockformer Spiral tool type with dedicated communication and control which can be found clicking the Tool Type drop-down in the General tab. The Stratus Workstation app has undergone a few user interface changes that can be reviewed in the **Stratus Workstation** Knowledge Base article.

ADDED Added Big Data Package Task columns for AssemblyId and PartId. Values are optional and depend on the task association type. These columns will automatically populate the PackageTasks table when the “Rebuild Data” button is clicked under Admin > Company > Big Data > Configuration.

ADDED Added a Tools table to Big Data SQL.

Fixed Fixed an issue that, in specific scenarios, prevented multiple part selection when utilizing a Report with Report Fields set to Merge Like Values.

Fixed Fixed a Packages Dashboard issue that prevented packages from loading on other pages when a filter was enabled.

Fixed Fixed a Packages Dashboard issue where custom editable drop-down fields were not sortable.

Fixed Fixed a Stratus Sheet issue where duplicate tags were created after moving an assembly tag in the viewer.

Fixed Fixed a Projects > Areas > Manage Areas issue where, under certain conditions, the list of areas failed to appear.

Fixed Fixed an issue with auto-generated PDF reports where an incorrect QR code link was displayed.

Fixed Fixed a Winget installer issue where the message “No package found matching input criteria.” displayed and as a result the software did not get installed.

## 2 June 2025 - 7.6.10.39

Fixed Fixed a Dashboards (Packages and Assembly) issue where after a data table filter was applied the table did not update correctly.

Fixed Fixed a Dashboards (Packages and Assembly) issue updating total values.

Fixed Fixed a Package Dashboard issue using the CSV or Excel export buttons.

Fixed Fixed a Package Dashboard issue that removed packages from the dashboard when the selected report was configured with a sort index and then a filter was applied to the data table.

Fixed Fixed a Project Role issue on the Packages Dashboard where after updating a value for the package, packages not permissioned to the user would display.

Fixed Fixed an issue that would cause filtered search results to fail when updates were made to packages on the Packages Dashboard data table.

Fixed Fixed an issue in Packages > Items > Parts within the Add Lightning Catalog Parts feature. Previously, if parts were initially added to a package and later included in an assembly before publishing the model, they would be removed from both the assembly and the package upon publication. This fix ensures that parts remain correctly assigned after the model is published.

Fixed Fixed an issue in the Parts report data table under Packages > Viewer > Items where after editing a report field configured as a Date format, the Package Number disappeared.

Fixed Fixed an issue under Admin > Company > Divisions where deleting and reassigning tracking entries to a different Division resulted in an error.

## 19 May 2025 - 7.6.1038

Fixed Some users were reporting an issue generating master reports.

Fixed Some users were reporting an issue generating CSV exports from the package dashboard.

update Various backend and infrastructure improvements.

## 15 May 2025 - 7.6.1037

Fixed Fixed an issue exporting the CSV or Excel report from the Packages Dashboard.

Fixed Fixed a Packages Dashboard issue where filters did not work due to an issue with the report Sort Index.

## 14 May 2025 - 7.6.1036

Fixed Fixed an issue with the dashboard's sort index, ensuring that report Sort Index settings now properly organize the report data.

Fixed Fixed a Display Mode > Tracking issue in the Models Viewer where the parts displayed were not restricted to the active filter(s).

## 11 May 2025 - 7.6.1033

Installers This release does include an optional Stratus Addin.

Fixed Fixed a Package Dashboard issue where aggregate totals were displaying incorrect values for the InchFraction format.

Fixed Fixed a dashboard issue where a custom report that included duplicate report field names would not display, rather the Default report would display.

Fixed Fixed a guest user login issue after the user has been deactivated from the guest company. With this fix, the deactivated user will be logged in under their active company account.

Fixed Fixed an issue deleting custom tags where instead of deleting the individual tag, all tags of the same type and label were also deleted.

## 5 May 2025 - 7.6.1030

Installers This release does include new Revit/AutoCAD Stratus Addin for 2026 support.

ADDED Added to the Stratus Addin support for Revit/AutoCad 2026.

**Urgent Note:** Fabrication CADmep 2026 is currently having a license initialization issue. Ensure, CADmep is fully initialized and licensed prior to publishing to Stratus.

-   **No license issue:** Acad 2026 RTM product version is W.60.0.0
    
-   **Causes license issue:** Acad 2026.0.1 product version is W.74.0.0
    

**Issue:** If users attempt to open a model in CADmep, and their first click is to publish in the Stratus Addin, this error modal may appear and the application will shut down.

**Note**: Autodesk is actively working on this issue.

**Work-around**

1.  Download this version of AutoCAD.
    
2.  If AutoCAD 2026.0.1 has already been downloaded, the following is a work-around until Autodesk has an update.
    
    1.  If creating a new model:
        
        1.  After the first click to add a part, the Licence failure will appear.
            
        2.  Click OK.
            
        3.  Click to add the part again.
            
        4.  User will be able to proceed to create model and publish.
            
    2.  If publishing an existing model:
        
        1.  Click to add a part, the Licence failure will appear.
            
        2.  Click OK.
            
        3.  User will be able to proceed to publish the model.
            
        4.  Click Publish button on the Stratus Addin.
            

ADDED Added to Big Data a SQL data table that includes Big Data Updates including the last refreshed date-time. This data table will automatically populate the PowerBI Data when any Big Data update is made such as clicking the **Rebuild Data** button is clicked from Admin > Company > Big Data or when any scheduled update is executed.

ADDED Added a divider separating 3D Views from 2D Views.

ADDED Added a Report drop-down in Assemblies > Stratus Sheet, aligning the selection process for Stratus Sheet reports with that of Packages > Stratus Sheet. In addition, the Report drop-down options are restricted based on the View selected, either 3D or 2D. If a 3D View is selected, only Report Templates that include a 3D View element (Ex. Top View, Front View, Isometric View) will display. Similarly, when a 2D View is selected, only Report Templates that include the 2D Plan View element will display.

ADDED Added a report property to list a part’s View Names, STRATUS.Part.ViewNames. One purpose of this property is to identify whether a part is visible in specific views when generating a report for the entire model.

ADDED Added Stratus Publish messaging for errors that occur during the import process. Below is an example:

ADDED Added the **ArrayMultiply**() function for use with STRATUS.Ancillary.\* reporting.

ArrayMultiply()

Returns array of product results from array1\[0..n\] times array2\[0..n\] in semi-colon separated list of values with provided precision

**Syntax:** ArrayMultiply(array1, array2, precision=0)

**Example:** Field: ArrayMultiply({STRATUS.Ancillary.Quantity},{STRATUS.Ancillary.Length},2)

The STRATUS.Field.Frank Ancillary Part 4 field multiples STRATUS.Ancillary.Quantity x STRATUS.Ancillary.Length and results in the following:

ADDED Added to the Generate Deliverables dialog under Projects > Deliverables, a search box that searches for characters in model names. Note that neither the Deliverable Definition (Ex. Sheet Metal) or Package Category (Ex. 5. Sheet Metal Fab) is searched using the search box.

update Improved the performance of reports run from Models > Viewer > Actions > Reports.

update Updated the IndexOf() and LastIndexOf() functions to effectively find the closed parentheses “)” in a string.

update Eliminated unnecessary messaging during CAMduct publishing:

update Updated Project Role permissions for the Containers > Assign tab making it so that a user is not required to also have the Containers > Dashboard Project Role permission.

Fixed Fixed an issue deleting notes that were created from the Packages or Assemblies Notes tab.

Fixed Fixed an issue that was allowing packages to appear on the Package Dashboard that did not match the dashboard filter criteria.

Fixed Fixed a Projects > Deliverables issue Generating Packages where the package Naming Convention was not properly applied under certain conditions.

Fixed Fixed a package naming issue when using the "New Package" button on the Packages Dashboard.

Fixed Fixed an issue under Packages > Items where after changing the assembly status (Ex. Issued for Fabrication), its child parts did not update to the same status.

Fixed Fixed a Point List issue under Jobsites > Station where after a Point List had been sent to a Station, it did not display on the Jobsites > Station page.

## 17 April 2025 - 7.6.1017

This release does not include any new installers.

ADDED Added to Big Data the ability to configure a Container report. Currently, reports only display in PowerBI.

update Updated the dashboards (Packages, Assemblies, Containers) with a notable performance improvement. The "**Show Entries**" option "**All**" has been removed and replaced with a maximum of **500** entries per page. For instance, if the dashboard contains 10,000 records, each pagination button at the bottom right can promptly display up to 500 rows. However, when either the **CSV** or **Excel** button is clicked to download the file, all 10,000 rows in this example must be loaded first. This process might take some time, depending on the dashboard report's complexity.

Fixed Fixed a dimensioning issue where Stratus dimension values now match CAMduct dimension values.

Fixed Fixed an issue where the part data table was not sorting STRATUS.Part.Number in alphanumeric order.

Fixed Fixed an issue where any STRATUS.Part.PackageXXX property expression (Ex. STRATUS.Part.PackageNumber) was not displaying values when used in reports.

Fixed Fixed an issue in the Assembly Viewer where nested parts could not be selected; parts are now selectable with a single click and correctly linked to the Parts report.

Fixed Fixed a report issue where neither the STRATUS.Assembly.Container or STRATUS.Package.Container field data did not display.

known issue On the Assemblies Dashboard, Checkbox selections are not preserved when filters are modified or when navigating between pages of results. The Stratus team is actively working on a solution that will be implemented in an upcoming update.

## 20 March 2025 - 7.6.1009

update A new publish installer is available.

ADDED Add the Open API method /v1/container/dashboard to run containers dashboard reports.

Fixed Fixed an issue where reports configured under Generate on Tracking Status under Admin > Company > Packages Categories were not auto generating the PDF report.

## 13 March 2025 - 7.6.1007

update Removed the ExtractGeometryStatus field from public model APIs.

update Updated QR Scan Pages (Part, Assembly, Package, Container) to include a button to download attachments.

Fixed Fixed a Containers issue where after adding assemblies of a package into a container, the package tracking status did not update to the first Tracking Status where “Applies to Container” is checked.

## 9 March 2025 - 7.6.1006

ADDED Added support for a new RazorGage RG3.

update Updated Big Data which requires that all companies regenerate their SQL user name and password.

Fixed Fixed a scan issue on the Scan tab when using a ChromeOS device such as a Chromebook or Chromebox.

Fixed Fixed a Model Viewer issue so that very large models and tools like Display Modes load faster.

Fixed Fixed an issue where CAMduct and Field Orderz published packages would not load in the Packages Viewer.

## 2 March 2025 - 7.6.1004

ADDED Added startup messaging to Stratus Workstation. The processes behind these checks also detect that the workstation is starting up correctly.

ADDED Added new trigonometry functions that can be used in Field Expressions including:

sin, cos, tan, atan, atan2, asin, acos, cot, sec, csc

**Syntax**:

Most take (value, units as 0=radians (default) or 1=degrees)

atan2 takes (y, x, units (optional))

update Updated the AsMetric() function used in Field Expressions so that 1, 2, 3, or 4 arguments can be passed. For example, using the following arguments the metric unit of measurement will be visible on reports:

Precision (optional number of decimal places, defaults to 0),  
Format (optional, defaults to 0, 0=mm, 1=cm, 2=m),  
Display Units (optional, defaults to 0, 0=OFF, 1=ON)

update Updated the report engine to prevent certain errors so that the report generates correctly.

Fixed Fixed an issue generating automated report configured under Package Categories.

Fixed Fixed a Stratus Workstation issue when using filters, the app would occasionally freeze.

Fixed Fixed an Admin Package Category issue where the Report Fields of the selected "Package Creation Report" included a display order, however, that display order was incorrect under the Packages > Properties > Additional Fields section.

## 23 February 2025 - 7.5.1058

ADDED Added new part properties for new model publishes:

1.  Fabrication Body Area (No Allowances)
    
2.  Fabrication Skin Area (No Allowances)
    

update Updated messaging when generating a MAJ from the Packages Dashboard and a Fabrication Job Error message displays. The message will include one of the reasons below as to why the MAJ creation failed.

1.  Model is not found.
    
2.  Latest version of the model not found.
    
3.  Source MAJ files not found.
    

update Updated Cut List Mappings are now visible in Admin > Company > Activities.

Fixed Fixed an API error after scheduled maintenance.

Fixed Fixed an issue where after an Admin updated a user’s first name or last name, the change did not immediately display when the user logged out, then back in.

Fixed Fixed a dashboard issue where checkboxes did not remain checked or unchecked after being clicked by a user.

## 17 February 2025 - 7.5.1056

update Our backend infrastructure has been significantly updated and modernized.

## 9 February 2025 - 7.5.1054

update Updated Stratus automated event messages to provide more context.

Fixed Fixed a Quick Pass issue where if two or more users have the same first and last name, they were created as a guest user rather than a full access user.

Fixed Fixed a Package Report issue where Merge Like Values was set to Yes on the Stratus.Part.PackageName Report Field but did not merge values correctly.

## 4 February 2025 - 7.5.1050

update General and backend infrastructure changes

Installers have a new version available but this update optional

[GTP Software Installers](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/2122022926)

## 15 January 2025 - 7.5.1033

ADDED Added an Open API method v1/company/field which can be used to create a new company field.

update Updated the Generate Deliverables messaging when a user attempts to generate deliverables but a model has not yet been published to the project.

Fixed Fixed an issue where using the Select Connected tool in the viewer did not work properly when the modeled piping system included zero-length welds or joints.

Fixed Fixed an issue running a report that includes a Field with an Alias.

Fixed Fixed a report issue where a Report Field’s Hidden checkbox was checked, but in the resulting report, the hidden field’s value could not be used to sort the report data.

Fixed Fixed an iPad issue where the Window Select tool in the viewer did not work as expected.

## 09 January 2025 - 7.5.1028

update Updated when package notifications are sent to eliminate irrelevant notifications.

Fixed - Fixed an issue that was allowing packages to appear on the Package Dashboard that did not match the dashboard filter criteria.

## 20 December 2024 - 7.5.1026

Fixed Fixed an issue where the publish import timed out after 30 minutes and is now 1 hour.

## 10 December 2024 - 7.5.1024 (Redeployment of 7.5.1023)

update There is an optional Workstation app installer update available [HERE](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/edit-v2/2122022926#GTP-Workstation "https://gtpservices.atlassian.net/wiki/spaces/SK/pages/edit-v2/2122022926#GTP-Workstation") that includes some internal changes that should not affect end users.

Fixed An issue was causing some reports to take a long time to generate.

Fixed An issue was causing assembly creation to take a long time.

Fixed An issue was popping up an “Object reference not set to the instance of an object” while using Spool Checker.

Fixed Fixed a reported issue where an exported Package Parts Report did not include the same fields and values in the Excel file.

Fixed Fixed an issue under Admin > Company > Projects where the Manufacturer Source Type could not be edited.

Fixed Fixed an issue using the Excel or CSV button on the Packages Dashboard or Packages Viewer where the download to the local computer did not work.

update Made internal improvements to Stratus Workstation app. While there is no user impact within the user interface, the app will have an updated version number.

update Updated Projects > Areas. The administration of project areas has been reworked to make them easier to configure and more efficient to use. Some of the changes to functionality are as follows:

1.  Search functionality has been added to the areas so that you can take a different approach to configuration. Search for terms like “scopebox”, “level”, or “Area A” and then have the option for individual selection, check matches, or uncheck matches.
    
2.  You can now manage your areas instead of importing and overriding. This means that you can add areas to your original selection without losing existing area data like area codes, abbreviations, and overridden elevation properties.
    

<iframe data-hasbody="false" data-layout="default" data-local-id="99f2871e-27fc-4c37-9c67-981e365c0378" data-macro-id="cc6be4de95c860049e062992c86320437cf9f89accb20c3daae4a48210af2768" data-macro-name="widget" frameborder="0" type="text/html" src="//www.youtube.com/embed/v_X9X9mAdBQ?wmode=opaque"></iframe>

## 05 December 2024 - 7.5.1022 (Release was rolled back to 7.5.1018)

Fixed An issue was causing some reports to take a long time to generate.

Fixed An issue was causing assembly creation to take a long time.

Fixed An issue was popping up an “Object reference not set to the instance of an object” while using Spool Checker.

## 01 December 2024 - 7.5.1018

Fixed When removing an assembly/package from a container, the tracking status of the assembly/package was being reverted to its previous status.

## 20 November 2024 - 7.5.1017

**Please** [**update**](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/2122022926 "https://gtpservices.atlassian.net/wiki/spaces/SK/pages/2122022926") **your Stratus desktop software to version 7.5.1001 or later. Older versions will no longer be supported. This includes the Stratus Addin for publishing, Stratus Workstation, Stratus Print, and Lightning (v7.5.103) apps.**

ADDED The package and assembly viewers now support viewing image files (.png and .jpg) as attachments for packages and assemblies that do not contain parts.

ADDED Updated PDF rendering when an assembly does not include any parts, but does include a PDF attachment, the PDF will render in the viewer. Note: This functionality already exists when a package does not include any parts, but does include a PDF attachment, the PDF renders in the viewer.

update Empty assemblies can now be seen in Package Assembly report tables.

update Filter Rule Conditions:

1.  Added a 'Case Sensitive” option checkbox and removed the rules **ContainsAnyCase** and **DoesNotContainAnyCase**. We swapped any existing filters and checked the corresponding checkboxes during the deployment.
    
2.  Added new Rule Conditions including:
    
    1.  DoesNotStartWith
        
    2.  EndsWith
        
    3.  DoesNotEndWith
        
    4.  Regex (See [https://regex101.com/](https://regex101.com/ "https://regex101.com/") for more information)
        
        1.  RegexMatch
            
        2.  DoesNotRegexMatch
            

Fixed In rare cases, Assembly Stratus Sheets in a Master Report were showing annotation lines from the Package Assembly Tags when run from the package viewer or as an automated report generated by Tracking Status changes configured in the Package Categories tab of the Company Admin.

Fixed Increased performance in the speed of creating assemblies and displaying certain reports.

## 06 November 2024 - 7.5.1014 (Release was rolled back to 7.5.1013)

update The first phase of a long-term effort towards simplifying our reporting engine codebase has gone live.

Increased performance in the speed of creating assemblies and displaying certain reports.

Fixed Fixed an issue running a report that includes a Field with an Alias.

## 24 October 2024 - 7.5.1013

update Updated Part Report > Report Fields where **Aggregate** is either Sum or Average and **Merge Like Values** is set to Yes to ensure that the total is based on having a common Description, Material and Size.

update Updated backend report engine code. This change may impact client code written against our Open API for pulling down reports.

**Warning:** When generating reports with the Open API, some fields will now result in strings being empty vs. null. This change may impact client parsing software that operates on data from our Open API.

Fixed Fixed an issue selecting nested families in a Viewer Filter.

Fixed Fixed an issue adding/removing nested family parts to/from an assembly or package.

Fixed Fixed a Container Details report issue when a Report Fields **Merge Like Values** was set to Yes, the report now displays the merged sum and quantity.

Fixed Fixed an issue where a Filters Grouping was applied to a ZPL (label) report, the alphanumeric order was incorrect.

Fixed Fixed an Admin > Company > Part Templates issue where after selecting 2 or more Parts, then in the **Shared Properties** tab editing a property, the edits now correctly save for the selected parts.

## 14 October 2024 - 7.5.1011

ADDED A new Field format called _QRCode_ has been added to reports. When this format is used in a report, the value of the field/property will be rendered as a QR code in the Stratus UI and in generated PDFs. When the report type is CSV, the value of the field/property will still be rendered as a string.

ADDED New API call for creating a new assembly.

-   POST /v1/model/{id}/assembly
    

ADDED 2 new API endpoints used to automate project import from Autodesk and project creation in Stratus and control over project role assignments for the new project.

-   GET /v1/project/autodesk-projects
    
-   POST /v1/project
    

ADDED A new tool type called “Lockformer Spiral” has been added.

ADDED AsMetric() Field Function which converts a numeric value from feet units to metric mm, cm, or m units and also control the number of decimal places displayed in the resulting string.

Examples:  
AsMetric({Length})

AsMetric({Length},2)

AsMetric({Length},2,2)

where the 2nd and 3rd arguments are optional as specified above

ADDED Markups Project Role permissions (Create & Edit, Delete, and View) in both Assemblies and Packages Attachments.

update Admin > Company > Big Data > Analytics Reports to include Service Principal Authentication fields (Optional).

update Publish to include the Fabrication Data property “Item Drawing Name” value which will display in Stratus Properties.

update Naming conventions part property dropdown performance improvement.

update Attachment filenames that contain invalid characters which will be replaced with an underscore so they can successfully be uploaded to ACC/BIM 360.

## 8 October 2024 - 7.5.1010

update Resolved an issue with authentication access tokens that were causing brief outages.

## 7 October 2024 - 7.5.1008

Fixed An issue where, when editing a field, random characters appeared in the field expression.

## 6 October 2024 - 7.5.1007

-   Both the Stratus Addin and Workstation applications have available updates.
    
-   **Remember, all Stratus software must be on version 7.5.1001 or later by October 18th as previous versions will no longer be supported.**
    

ADDED A checkbox setting called Exclude Imports into Fabrication Item Number Property to the \[Company Admin > Settings > AutoCAD, Revit… > Specific to Revit\] page directly under the Property to Map to Item Number setting.

When enabled the Stratus Revit addin will NOT import your Stratus.Part.Number values into the Fabrication Item Number property. This can be useful when using Revit groups as they do not support unique Item Number values on parts contained within them.

ADDED The Stratus Community feed was added to the homepage.

Fixed 2D views included in the Revit publish set will be visible in the model viewer’s View droplist and visible in Stratus.

Fixed All reports will now honor your defined sort indices.

Fixed An issue where markups were not landing at where expected.

Fixed An issue where the advanced estimating metrics were not showing when creating a package.

Fixed Excel exports of part reports were missing data.

Fixed Groupings in a filter were missing some values in the Company Filters UI.

Fixed Scope box selection was not working in the Project Areas graphical selector.

Fixed Some PDF Reports were not downloading.

Fixed Some reports with multiple groupings were failing when one of those grouper properties had empty values.

Fixed Some tags were not displaying in Stratus Sheets.

Fixed Stratus Sheets were missing the Hidden Parts Shaded content.

Fixed The annotations endpoint for packages were returning no annotations in some cases.

Fixed View orientation between Stratus Sheets and the Model Viewer were not being maintained.

Fixed Workstations filtering was breaking import cut lists.

update Adjusted Length tags were overlapping with their leaders.

update General API Improvements

update Performance improvements on the Fields admin page.

update The JSON type has been removed as a report format.

## 28 September 2024 - 7.5.1003

Fixed An issue adding parts to assemblies

Fixed An issue with a user being disabled

update Infrastructure

## 23 September 2024 - 7.5.1001

[GTP Software Installers](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/2122022926)

ADDED 2025 Support for Revit and AutoCAD

-   Note that Flex geometry extraction is not quite yet supported for Revit 2025
    

update 7.5 version release for Stratus Workstation, Print, and Lightning

## 19 September 2024 - 7.4.1018

Fixed Issue resolved with failed model publishes for very large models

-   [GTP Software Installers](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/2122022926)
    

Fixed Clearing an editable property value displayed in a package’s additional fields, but not the dashboard, also cleared properties not in additional fields but displayed on the dashboard.

## 18 September 2024 - 7.4.1017

Fixed Resolves an isolated incident where a customer could not access and Edit Aliases

## 18 September 2024 - Lighning v7.4.120

Fixed An issue with the installer not opening was resolved

[GTP Software Installers | GTP Lightning](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/2122022926/GTP+Software+Installers#GTP-Lightning)

## 15 September 2024 - 7.4.1010

update Completed Dark Mode

## 13 September 2024 - 7.4.1013

### Desktop Installers Updated

[GTP Software Installers | STRATUS AddIn](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/2122022926/GTP+Software+Installers#STRATUS-AddIn)

[GTP Software Installers | GTP Lightning](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/2122022926/GTP+Software+Installers#GTP-Lightning)

update Windows PCs will stay awake while going through an extended import/publish cycle

update Infrastructure upgrades

update Lightning publish was made more robust

update Revit, and AutoCAD, CAMduct, and ESTmep

Fixed ImportNotSilent import error resolved

Fixed Publishes were failing when the publish path was specified as Project Files and not a subfolder within the Project Files directory in BIM 360

Fixed The Conflict Resolution override was reset after a successful publish

Fixed Lightning was listing a user name instead of the company name

## 2 September 2024 - 7.4.1010

ADDED A new property called STRATUS.Part.HoleInfoType can now be used that expands what the current STRATUS.Part.HoleInfo property contains by adding the Olet type for each hole using an abbreviation

-   DEF = Default
    
-   COP = Cooplet
    
-   SOC = Sockolet
    
-   THR = Threadolet
    
-   WLD = Weldolet
    
-   SAD = Saddle
    

update Project Roles are now limiting the available statuses that an individual can use when scanning to update tracking statuses

Fixed Stratus Workstation was not allowing the selection of different package filters after completing a cut list.

-   An updated installer has been released to resolve this issue  
    [GTP Software Installers | GTP Workstation](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/2122022926/GTP+Software+Installers#GTP-Workstation)
    

Fixed Reports using a field expression that used Stratus.Part.PackageName were not reporting the package name unless the STRATUS.Part.PackageName<Package Category> was also included in the report.

Fixed STRATUS.Package.TrackingHours was reporting incorrectly in the package dashboard

Fixed In some cases the STRATUS.Part.HoleInfo property was reporting the size of the pipe that the holes were cut into for taps

Fixed In rare instances, Stratus Sheet PDFs were generated with annotations and dimensions on separate pages.

Fixed Open API endpoint for getting package annotations was responding with duplicates

Fixed The format was not respected for package dashboard reports with duplicate property names with different format settings

Fixed Tag Shapes for some were incorrect on the Viewer and Stratus Sheet

Fixed Users were experiencing an error dialog when navigating to the assembly dashboard when there were no packages or assemblies

Fixed Removing connecting parts from an assembly was not removing the connected assembly tag

Fixed Tech debt item was paid off, resulting in a 10% performance improvement sitewide as found in testing

Fixed When tracking statuses and reports were deleted that were used in the automated reports from the Generate on Tracking Status settings, users were seeing an error when trying to add or remove reports

Fixed Deliverables that used groupings were not adding parts to packages as expected. Additional modifications were also made to improve deliverable processing speed.

## 26 August 2024 - 7.4.1009

update Corrected error messages that were appearing when trying to attach unaccepted file types

Fixed Some master reports were failing to generate as expected

Fixed Issue using Ctrl+select where the last selected parts were recalled

Fixed Selected part reports were not retained when switching assemblies

Fixed Some users were unable to add parts to containers from the model viewer

Fixed Multiple simultaneous package publishes were failing when published to the same model

## 21 August 2024 - 7.4.1008

update The model viewer has been upgraded to use Autodesk Platform Services Viewer v7.98

Fixed Customer Tags that were causing console errors in the browser

Fixed Stratus Sheets that were no longer generating in color

## 19 August 2024 - 7.4.1006

ADDED In data tables such as the package dashboard or parts reports, when certain report fields are merged, the values in the cells of the non-merged report fields will be organized in alpha-numerical order. For example, if there is a report with a column merged based on ‘Stratus.Part.Number’ and another column for ‘Material,’ the values within the ‘Material’ column will be sorted alpha-numerically. This means that within the ‘Material’ column, ‘Carbon Steel’ would be listed before ‘Copper’ due to the alpha-numerical sorting criteria applied to that field.

update Incremental update for Flex model publishing (only required if testing Flex model viewer)

-   [GTP Software Installers](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/2122022926)
    

Fixed There was an issue with assemblies when a lightning catalog publish was happening as the same time as a model publish

Fixed Parts were not isolating when using system filters

Fixed The calendar picker was not functioning on iPadOS

Fixed Issue selecting parts in Firefox

Fixed Stratus Flex SSO login issue when using Okta for MFA

Fixed Additional part reports on the Assembly viewer page were not updating when the assembly was changed

Fixed An issue related to a project role where company filters were not loading

Fixed A package dashboard with 7,000+ packages was failing to load all entries

Fixed Tracking status issue involving merged reports

## 15 August 2024 - 7.4.1005

update Stratus SSO implementation for LMS

## 12 August 2024 - 7.4.1004

Fixed Various Package Dashboard issues were resolved

## 8 August 2024 - 7.4.1003

Fixed Some customers using Revit is Always Right for assembly conflict resolution were seeing inconsistencies with their assembly continuation tags

Fixed A360 folder path modifications from Stratus were failing

Fixed Markups were disappearing for some customers

## 7 August 2024 - 7.4.1002

ADDED Package Category option added for MAJ QR codes in CAMduct import

-   [Package Categories (Admin) | MAJQR](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/166199351/Package+Categories+Admin#MAJQR)
    
-   Requires Stratus desktop addin version xxx or greater.
    
    -   [GTP Software Installers | STRATUS AddIn](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/edit-v2/2122022926#STRATUS-AddIn)
        

ADDED Stratus assemblies supported in CAMduct

-   [CAMduct / ESTmep Publish and Import | Handling of Assemblies](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/2282586113/CAMduct+ESTmep+Publish+and+Import#Handling-of-Assemblies)
    

## 5 August 2024 - 7.3.2003

update Authentication cookies were causing users to have to log in multiple times per day

## 1 August 2024 - 7.3.2002

update Miscellaneous backend changes

Fixed Multiple scanned assemblies were not displaying on the Scan page

Fixed Some automated reports were not generating on a tracking status change

Fixed VueJS console error when generating a Stratus Sheet

Fixed Cutlists from CAM published packages were failing

Fixed Model Viewer System Filters were not catching fabrication hangers by their applied service

## 31 July 2024 - 7.3.2001

update Package Dashboard patch

Fixed Perceived regression in the select connected tool

## 24 July 2024 - 7.3.1094

Fixed License counts were not calculated correctly when using QuckiPass

Fixed There was a regression where assembly continuation tags were not populating

## 24 July 2024 - 7.3.1091

update Package Dashboard patch

## 24 July 2024 - 7.3.1087

Fixed Reports with a precision set to 16 were failing

Fixed API patched

## 24 July 2024 - 7.3.1084

Fixed CAMDuct publishes were placing parts incorrectly

Fixed Could not generate Stratus sheets for empty packages

Fixed License counts were reported incorrectly

Fixed Assembly continuation tags were not populating on Stratus Sheets

Fixed Project Role: Report>Part>Default Report was affecting all default reports

Fixed Boolean checkboxes were not functioning as expected in Reports

Fixed SplitOnNewLines error

## 24 July 2024 - 7.3.1078 (Denali Feature Release)

[07/16/2024 - v7.3 - Denali Release](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/2355462165)
---
created: 2025-06-25T11:08:05 (UTC -04:00)
tags: []
source: https://gtpservices.atlassian.net/wiki/spaces/SK/pages/2556264449/Stratus+Lightning
author: 
---

# Stratus Lightning - STRATUS Knowledge Base - Confluence

> ## Excerpt
> This article describes how to upload a Fabrication Database to Stratus using Stratus Lightning.

---
This article describes how to upload a Fabrication Database to Stratus using Stratus Lightning.

-   1 [Stratus Academy Course Video](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/2556264449/Stratus+Lightning#Stratus-Academy-Course-Video)
-   2 [Stratus Lightning Installation](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/2556264449/Stratus+Lightning#Stratus-Lightning-Installation)
-   3 [Stratus App Key](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/2556264449/Stratus+Lightning#Stratus-App-Key)
    -   3.1 [Generate App Key](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/2556264449/Stratus+Lightning#Generate-App-Key)
        -   3.1.1 [Add to Lightning](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/2556264449/Stratus+Lightning#Add-to-Lightning)
-   4 [Add Lightning Catalog Parts](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/2556264449/Stratus+Lightning#Add-Lightning-Catalog-Parts)

## Stratus Academy Course Video

To take the Stratus Lightning course, login to [**Stratus Academy**](https://academy.stratus.build/ "https://academy.stratus.build/") and locate the following course:

-   **VDC-406: Stratus Lightning App**
    

## Stratus Lightning Installation

For the person publishing, download and install the GTP Lightning app by clicking the link on the Stratus Help page and then follow the instructions.

## Stratus App Key

## Generate App Key

Before Lightning can be used, an Admin must create a Lightning App Key.

1.  In Stratus, go to Admin > Company > App Keys.
    
2.  Click **New App Key**
    
    1.  **Partner App** - GTP Lightning
        
    2.  **Run as User** - A user who has permission to publish to Stratus.
        
3.  Once the app key is created, copy the **Key** and provide it to the user who will publish the database with Lightning.
    

### Add to Lightning

To launch Lightning with the App Key:

1.  Open Lightning.
    
2.  Paste the Stratus App Key into the **Open API App Key** text box, and then click **Save**.
    
3.  After Lightning restarts, the fabrication Configuration tab will display the available versions and a list of services from your Fabrication database.
    
4.  In this example, Fabrication 2024 is selected. The available databases will display.
    
5.  Hover over the database upload button to verify the correct path.
    
6.  Click the upload button to start the upload process. The first time the database is published and depending on the size of the database, it may take awhile to complete because it is gathering everything from your database. When the database uploads successfully, the synchronized column will change to yes.
    
7.  Down the road, as the local database is updated, the upload button will change to green to inform you that there have been local changes made to your database. When you publish the updated database, Lightning will scan the database to see what has changed and only upload the changed items so it will be much faster. And, once the database is published, it can be published again without having direct access to it on the machine, so it will essentially look to Stratus to find that information and pull that data.
    

## Add Lightning Catalog Parts

Publishing a database to Stratus with Lightning also unlocks the **Add Lightning Catalog Parts** feature where items from the Fabrication database catalog can be added to the package and published to Stratus.

**To use the Add Lightning Catalog Parts feature:**

1.  Publish the Fabrication Database using Stratus Lightning.
    
2.  Open a package from a model that uses the Fabrication Database.
    
3.  Under the Items tab and the Parts section, the **Add Lightning Catalog Parts** button will display as a plus icon.
    
4.  Click the **Add Lightning Catalog Parts** button. The **Add Parts** dialog will display. Select one or parts and then click the **Publish Items to Stratus** button.
    
5.  See the [**Lightning Catalog Parts**](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/166658049#PackageItems-LightningCatalogParts "https://gtpservices.atlassian.net/wiki/spaces/SK/pages/166658049#PackageItems-LightningCatalogParts") article for more information.
---
created: 2025-06-25T11:08:05 (UTC -04:00)
tags: []
source: https://gtpservices.atlassian.net/wiki/spaces/SK/pages/2038333441/Project+Divisions+Admin
author: 
---

# Stratus Publish / Import Addin - STRATUS Knowledge Base - Confluence

> ## Excerpt
> The GTP STRATUS Addin for Revit and AutoCAD, includes tools to Create Assembly, Publish, Import, Software Update, and Help. Once the addin is installed, it will be automatically updated when a new version is available.

---
The **GTP STRATUS Addin** for Revit and AutoCAD, includes tools to Create Assembly, Publish, Import, Software Update, and Help. Once the addin is installed, it will be automatically updated when a new version is available.

See the **[Installation of GTP Software on Windows](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/2121400321/Installation+of+GTP+Software+on+Windows)** article for information on installing GTP software.

## ****[Revit Publish and Import (Article Link)](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/1183383557/Revit+Publish+and+Import)****

## ****[AutoCAD Publish and Import (Article Link)](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/1183384125/AutoCAD+Publish+and+Import)****
---
created: 2025-06-25T11:08:05 (UTC -04:00)
tags: []
source: https://gtpservices.atlassian.net/wiki/spaces/SK/pages/2291531777/WinGet+Automated+Installation+of+GTP+Software
author: 
---

# WinGet Automated Installation of GTP Software - STRATUS Knowledge Base - Confluence

> ## Excerpt
> Use this page to set up automatic GTP software installations using WinGet.

---
Use this page to set up automatic GTP software installations using WinGet.

Alternatively, GTP software can be installed manually. See the [GTP Software Installers](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/2122022926) article for more information.

-   1 [User Installation via WinGet](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/2291531777/WinGet+Automated+Installation+of+GTP+Software#User-Installation-via-WinGet)
-   2 [Company Installation](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/2291531777/WinGet+Automated+Installation+of+GTP+Software#Company-Installation)
-   3 [Version Compatibility](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/2291531777/WinGet+Automated+Installation+of+GTP+Software#Version-Compatibility) 
-   4 [WinGet Tools](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/2291531777/WinGet+Automated+Installation+of+GTP+Software#WinGet-Tools)
    -   4.1 [Install WinGet for Windows](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/2291531777/WinGet+Automated+Installation+of+GTP+Software#Install-WinGet-for-Windows)
    -   4.2 [Search for Available GTP Software Versions](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/2291531777/WinGet+Automated+Installation+of+GTP+Software#Search-for-Available-GTP-Software-Versions)
    -   4.3 [Install a Specific GTP Software Version](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/2291531777/WinGet+Automated+Installation+of+GTP+Software#Install-a-Specific-GTP-Software-Version)
    -   4.4 [What if The Installer Failed with Error Code 1603?](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/2291531777/WinGet+Automated+Installation+of+GTP+Software#What-if-The-Installer-Failed-with-Error-Code-1603%3F)
-   5 [What If the Program I Install Will Not Login to STRATUS?](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/2291531777/WinGet+Automated+Installation+of+GTP+Software#What-If-the-Program-I-Install-Will-Not-Login-to-STRATUS%3F)

## User Installation via WinGet

Installation/update of GTP software is handled using the WinGet Package Manager. A user with Admin rights can install individual apps and optionally install an AutoUpdate task.

1.  **Uninstall all GTP (Required)** - Uninstall all GTP software prior to version 6.3.1 under:
    
    1.  Windows Add Remove Programs.
        
    2.  or the Apps > Apps & features > App list page.
        
2.  **Open a Command Prompt and Run As Administrator (Required)** - All GTP software is installed via WinGet using the Windows Command Prompt.
    
    1.  On the computer search for command prompt then select the **Run as administrator** option.
        
3.  **Install GTP Source (Required)** - Skip this step only if GTP software has been previously installed on the computer using WinGet.
    
    1.  In the command prompt copy/paste the following and then press enter:  
        `WinGet source add -n GTPSoftware -a https://WinGet.gtp.one/d1588e01-761c-48ff-b102-2776fc4f8ec5 -t "Microsoft.Rest"`
        
        If this command fails with 1603 error, run with elevated rights. That is, run as administrator.
        
        If this command fails, with “missing source”, run the following commands as Administrator:
        
        1.  `winget source reset --force`
            
        2.  `winget source update`
            
        3.  `WinGet source add -n GTPSoftware -a https://WinGet.gtp.one/d1588e01-761c-48ff-b102-2776fc4f8ec5 -t "Microsoft.Rest"`
            
            GTP WinGet source should now be registered on the PC.
            
    2.  If the following message “WinGet is not recognized as an internal or external command” displays, see the [**Install Winget for Windows**](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/2121400321/Installation+of+GTP+Software+on+Windows+QA#Install-Winget-for-Windows "https://gtpservices.atlassian.net/wiki/spaces/SK/pages/2121400321/Installation+of+GTP+Software+on+Windows+QA#Install-Winget-for-Windows") section below.
        
    3.  If GTP Source has already been registered on the computer, a message similar to the following “A source with the given name already exists…” will display. This message can be ignored. Move on to Install Software.
        
4.  **Install Software** - For the software you want to install on each computer, copy/paste the install command (highlighted in gray starting with WinGet). Once pasted, press enter and the command will run and install. No further action is need until the installation is complete. If the **Successfully Installed** message does not display, contact the [**STRATUS Service Desk**](https://gtpservices.atlassian.net/servicedesk/customer/portal/3 "https://gtpservices.atlassian.net/servicedesk/customer/portal/3")**.**  See the **GTP STRATUS Addin** for and example.
    
    1.  **GTP Lightning**  
        `WinGet install GTPSoftware.Lightning -s GTPSoftware`
        
    2.  **GTP Print**  
        `WinGet install GTPSoftware.Print -s GTPSoftware`
        
    3.  **GTP STRATUS Addin**  
        `WinGet install GTPSoftware.AddIn -s GTPSoftware`  
        **Example:**
        
          
        **Success!**
        
        **Error.** If you get an error running this step, see the section below on what to do next.
        
    4.  **GTP Workstation**  
        `WinGet install GTPSoftware.Workstation -s GTPSoftware`
        
    5.  **GTP WireWorks (not yet released - install won’t work)**  
        `WinGet install GTPSoftware.WireWorks -s GTPSoftware`
        
    6.  **GTP SchematicViewer (not yet released - install won’t work)**  
        `WinGet install GTPSoftware.SchematicViewer -s GTPSoftware`
        
5.  **AutoUpdate (Optional-Recommended)**
    
    1.  The AutoUpdate task will check for updates of all installed GTP Software:
        
        1.  at 1am local time
            
        2.  when a user logs in
            
        3.  **Note**: This is the same method used by MS Edge.
            
        4.  **Note**: Other package managers such as Homebrew or Chocolatey can be supported in the future depending on demand.
            
    2.  **Enable AutoUpdate** - In order to enable **automatic-updates** install the following via copy/paste into the Command Prompt:  
        `WinGet install GTPSoftware.AutoUpdate -s GTPSoftware`
        
    3.  **Disable** **AutoUpdate** - To disable automatic updates after AutoUpdate has been installed (Enable AutoUpdate above), uninstall this process with the following via copy/paste into the Command Prompt:  
        `WinGet uninstall GTPSoftware.AutoUpdate`
        
6.  **Remove Tasks (Optional)** - This step can be done anytime and will not impact the **AutoUpdate**. To cleanup tasks if any GTP Software version was installed prior to v6.3.1 you’ll can manually remove all Tasks from the items from the Windows Task Scheduler that have GTP or STRATUS in the name.
    
    1.  Using Windows search, enter Task Scheduler and open the **Task Scheduler App**.
        
    2.  **Delete all Tasks** - Delete all Tasks that have GTP or STRATUS in the name.
        

## Company Installation

For companies who do not want to install GTP Applications using the AutoUpdate feature, they can choose to either:

1.  Manually install GTP Software and updates
    
2.  Or use an MDM tool such as KACE, MaaS360, InTune, etc.
    
    1.  **Note**: Installation/update of GTP software using this method is supported via .msi installers.
        
3.  A historical log of the msi based installers for GTP Applications can be found at the link below. Also use this link to download GTP Applications when there is a mandatory update. See the [**Release History**](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/2122022926 "https://gtpservices.atlassian.net/wiki/spaces/SK/pages/2122022926") article for more information.
    

## Version Compatibility 

Version compatibility between major/minor releases for the STRATUS web site and GTP Apps is provided. For example if you have version 6.1.x of the Addin installed it will remain compatible with any 6.1.x version of the STRATUS Web site. However if we a fix is released in the Addin, the Addin would need to be installed in order to receive the fix. These fixes are noted in the release notes. When the STRATUS web site is updated to a newer major/minor version the all apps have to be updated to that same version before they can be used.

## Install WinGet for Windows

For older Windows versions, the WinGet command may not be found and the WinGet source cannot be registered on the PC. In this case, the following message will display.

To install WinGet, following the instructions in this Microsoft article. [Use WinGet to install and manage applications](https://learn.microsoft.com/en-us/windows/package-manager/winget/)

**Note:** The instructions note that installing WinGet is done via Windows PowerShell.

To open Windows PowerShell

1.  On the pc search for and open PowerShell.
    
2.  The PowerShell app will display.
    
3.  Copy/paste the command from the instructions (below) and then press enter.  
    `Add-AppxPackage -RegisterByFamilyName -MainPackage Microsoft.DesktopAppInstaller_8wekyb3d8bbwe`
    
4.  WinGet is now installed.
    

## Search for Available GTP Software Versions

To search for available GTP software versions.

1.  On the pc search for command prompt then select the **Run as administrator** option.
    
2.  Copy/paste the following into the Command Prompt:  
    `winget search -q "GTP" -s GTPSoftware`
    
3.  A list of available software similar to the following will display.
    

## Install a Specific GTP Software Version

To install a specific software version:

1.  Search for available software versions to identify the **ID** and **Version**. See the [**Search for Available Software Versions**](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/2121400321/Installation+of+GTP+Software+on+Windows+QA#Search-for-Available-Software-Versions "https://gtpservices.atlassian.net/wiki/spaces/SK/pages/2121400321/Installation+of+GTP+Software+on+Windows+QA#Search-for-Available-Software-Versions") section above.
    
2.  On the pc search for command prompt then select the **Run as administrator** option.
    
3.  Copy/paste a command similar to the following into the Command Prompt substituting the **ID** determined in the search for GTPSoftware.Print and the **Version** number for 6.3.1174.  
    `WinGet install GTPSoftware.Print -v 6.3.1174 -s GTPSoftware`
    

## What if The Installer Failed with Error Code 1603?

In the event that this happens, you can replace the word “install” with “show”. E.g., if Autoupdate isn’t installing, run this command:

**winget show GTPSoftware.Autoupdate -s GTPSoftware**

And this generated an Installer Url hyperlink to an msi file, as below:

The “Installer Url:” is a link to a working MSI installer that does NOT depend upon winget.

## What If the Program I Install Will Not Login to STRATUS?

If, after an install, you run one of the apps that requires a login (this can be the Revit addin, the AutoCad addin, etc., the Workstation App, the Printer App,..), and if you get a message like this

At this point, it is likely a WebView2 installer issue.

We automatically install WebView2 with our software: [![](https://edgestatic.azureedge.net/welcome/static/favicon.png)Microsoft Edge WebView2 | Microsoft Edge Developer](https://developer.microsoft.com/en-us/microsoft-edge/webview2/) However, in the event of the above error, consider going into Windows Add/Remove programs, and search for WebView2, and then “Modify” the installation to perform a repair.
