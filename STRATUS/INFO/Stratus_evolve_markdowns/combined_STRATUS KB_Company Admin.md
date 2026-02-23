---
created: 2025-06-25T06:27:04 (UTC -04:00)
tags: []
source: https://gtpservices.atlassian.net/wiki/spaces/SK/pages/1788444702/Activities+Admin
author: 
---

# Activities (Admin) - STRATUS Knowledge Base - Confluence

> ## Excerpt
> Activities in Stratus and with the Stratus Addin for Revit and AutoCAD are logged on the Activities page in a tabular format. Many activities can also display in the Change Notifications Activities Feed. See the Change Notifications article for more information.

---
Activities in Stratus and with the Stratus Addin for Revit and AutoCAD are logged on the Activities page in a tabular format. Many activities can also display in the Change Notifications Activities Feed. See the [**Change Notifications**](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/827261046/Change+Notifications "https://gtpservices.atlassian.net/wiki/spaces/SK/pages/827261046/Change+Notifications") article for more information.

-   1 [Activities Table](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/1788444702/Activities+Admin#Activities-Table)
    -   1.1 [Activities Logging for Publish Setting Changes](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/1788444702/Activities+Admin#Activities-Logging-for-Publish-Setting-Changes)

## Activities Table

The Activities tab logs **Stratus** and **Stratus Addin for Revit and AutoCAD** changes over time. This information can help track down how a change was made and when.

1.  **Show** - Select the number of activities to display on the page.
    
2.  **Search** - Search for any character sequence in the table.
    
3.  **Filters** - Filter by any column except value and Route.
    
4.  **Sort** - Sort items by Date.
    
5.  **Date** - The Date the activity occurred.
    
6.  **User** - The User who initiated the activity. Only user’s who have an activity will display.
    
7.  **Project** - The Project the activity occurred in.
    
8.  **Model** - The model impacted by the change.
    
9.  **Item** - The Item type (Assembly, Company, Cut List, Model, Package, Package BOM, Project, Supplier) for which the activity occurred. 
    
10.  **Action** - The action executed on the Item including: Activated, Archived, Assigned To Station, Completed, Created, Date Changed, Deleted, Locked, Modified, Publish Failed, Published, Purchase Order Processed, Quote Processed, Reverted, Tracking Status Changed, and Unlocked.
    
11.  **Name** - The name of the Item (Ex Assembly Name or Package Name).
    
12.  **Tracking Status** - If the Item was an Assembly or Package, the Tracking Status change at the Date specified will display.
    
13.  **Division** - If the Item was an Assembly or Package and a Division was changed for the Date specified, it will display.
    
14.  **Value** - The Value indicates what was changed or a tracking change comment that was made.
    
15.  **Route** - Displays where the change was made and the type of action that occurred.
    

## Activities Logging for Publish Setting Changes

Publish Setting changes will be logged for the following saved activities:

**Admin > Company > Settings > AutoCAD & Revit**

-   Assembly conflict resolution (Specific to AutoCAD)
    
-   Assembly conflict resolution (Specific to Revit)
    
-   Use Parameter Mapping for Assembly Import and Publish
    
-   Property to Map to Assemblies
    

**Admin > Project > Settings**

-   Assembly conflict resolution (Specific to AutoCAD)
    
-   Assembly conflict resolution (Specific to Revit)
    
-   Use Parameter Mapping for Assembly Import and Publish
    
-   Property to Map to Assemblies
---
created: 2025-06-25T06:27:04 (UTC -04:00)
tags: []
source: https://gtpservices.atlassian.net/wiki/spaces/SK/pages/3146038/Admin
author: 
---

# Admin - STRATUS Knowledge Base - Confluence

> ## Excerpt
> The Admin tab in STRATUS rolls out into the Company and Project settings associated with your account.

---
The Admin tab in STRATUS rolls out into the Company and Project settings associated with your account.

Company Admin settings are those which affect all projects and includes user settings as well as all things tracking, reporting, filtering and much more. These are handled through detailed and data driven configurations from within the Company Admin. 

The Project Admin settings are those which are applied on a project-by-project basis and includes project level team member roles mapping, BIM Area imports and creation as well as deliverable definitions.

Below is a node graph that shows the dependencies that exist across our Company and Project Admins settings. This will need to be an ever-evolving document but I hope that it sheds some light on when and where settings are required, optional, or necessary to get another portion of the settings configured. You will notice that by the nature of our site, the center of mass, if we can call it that, tends to gravitate towards the filters. They are really the heart and soul of STRATUS and think that is plain to see in the graph below. You can read this graph by following the dependency arrows through the document until there are no more "required" nodes feeding into another.

For example:

If I wanted to set up Task Workflows, I would need to configure the following.

-   Required
    
    -   Filters
        
    -   Cost Categories
        
    -   Cost Types
        
    -   Task Categories
        
    -   Task Definitions
        
-   Optional
    
    -   Package Categories
        
    -   Tracking Statuses (Though this one might as well be required)
        
    -   Processors
        
    -   Stations
        
    -   Tools
        
    -   Materials
        

Now, this is about the worst-case scenario. It just goes to show that STRATUS is like an onion, it has layers, and you don't get to the middle without peeling off the outside first.
---
created: 2025-06-25T06:27:04 (UTC -04:00)
tags: []
source: https://gtpservices.atlassian.net/wiki/spaces/SK/pages/10518824/Aliases+Admin
author: 
---

# Aliases (Admin) - STRATUS Knowledge Base - Confluence

> ## Excerpt
> An Alias is the way to identify different property names in different parts that mean the same thing. For example, properties that reference a size might include Diameter, Diameter #1, Branch Diameter #1, Product Size, etc.  Once defined, an alias can be used in a filter or report. By defining an alias to combine properties from different parts, you can configure a report without having to worry if you are getting the right value from each part.  Note: For reporting, Aliases are only used with parts, not assemblies or packages. To report for assemblies, use a Stratus.Field or Stratus.Item in the report to populate assembly names for assemblies.

---
___

An Alias is the way to identify different property names in different parts that mean the same thing. For example, properties that reference a size might include Diameter, Diameter #1, Branch Diameter #1, Product Size, etc.  Once defined, an alias can be used in a filter or report. By defining an alias to combine properties from different parts, you can configure a report without having to worry if you are getting the right value from each part.  **Note**: For reporting, Aliases are only used with parts, not assemblies or packages. To report for assemblies, use a Stratus.Field or Stratus.Item in the report to populate assembly names for assemblies.

-   1 [Stratus Academy Course Video](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/10518824/Aliases+Admin#Stratus-Academy-Course-Video)
-   2 [Configure](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/10518824/Aliases+Admin#Configure)
-   3 [Add Alias to a Report](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/10518824/Aliases+Admin#Add-Alias-to-a-Report)
-   4 [Add Alias to a Field Expression](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/10518824/Aliases+Admin#Add-Alias-to-a-Field-Expression)
-   5 [Add Alias to a BOM Line Item Mapping](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/10518824/Aliases+Admin#Add-Alias-to-a-BOM-Line-Item-Mapping)
-   6 [Add Alias to a Filter](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/10518824/Aliases+Admin#Add-Alias-to-a-Filter)
-   7 [Add Alias to a Naming Convention](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/10518824/Aliases+Admin#Add-Alias-to-a-Naming-Convention)

## Stratus Academy Course Video

To take the Task Definitions course, login to [**Stratus Academy**](https://academy.stratus.build/ "https://academy.stratus.build/") and locate the course **ADM-520: Aliases**.

## Configure

To configure an alias:

1.  Under Admin > Company > Aliases, click the **New Alias** button and name the Alias.
    
    1.  **Name** - The name given to the alias.
        
    2.  **References** - The number of places where the alias is referenced. Click the References link to display these references.
        
    3.  **Notes** - A note describing the purpose of the alias.
        
2.  Expand the Alias to add **Alias Properties**.  Click the **New Alias Property** button.
    
3.  Click the **Name** drop-down to select the property.
    
    1.  To reference a Stratus Field, select the field name (Ex. Stratus.Field.GTP SYS MP PL Pipe Length Only). 
        
4.  Repeat until all Alias properties have been added to the Alias.
    
5.  Use the **Sequence** column to tell Stratus which values should be used first in filters and reports:
    
    1.  The lowest sequence number is ordered at the top making it your first choice.
        
    2.  Numbers can be negative.
        
    3.  Sequence numbers do not have to be unique.
        
    4.  Stratus will use the first alias it finds that includes a value.
        

## Add Alias to a Report

To Add an Alias to a Report:

1.  Edit the Report Fields of a new or existing report where the Format is ZPL or CSV.
    
2.  Click the Property Name and select the Alias.
    

## Add Alias to a Field Expression

To Add an Alias to a Field Expression:

1.  Edit the Field Expression by adding the alias with the following syntax where AliasName is the name of the alias.  
    STRATUS.Alias.AliasName
    

## Add Alias to a BOM Line Item Mapping

To Add an Alias to a BOM Line Item Mapping:

1.  Go to Admin > Company > Part Templates
    
2.  Select Part template.
    
3.  Click the BOM Mappings tab.
    
4.  Click New BOM Mapping or edit an existing BOM Mapping.
    
5.  For any column, click the value drop-down and select Property.
    
6.  Select any alias (Ex. STRATUS.Alias.AliasName.
    

## Add Alias to a Filter

To Add an Alias to a Filter

1.  Go to Admin > Company > Filters.
    
2.  Select any STRATUS.Alias.AliasName Property.
    

## Add Alias to a Naming Convention

To Add an Alias to a Naming Convention:

1.  Go to Admin > Company > Naming and Numbering > Naming Conventions
    
2.  Add new or select a naming convention button.
    
3.  In the Options panel, select the Alias in the Aliases section.
    

___
---
created: 2025-06-25T06:27:04 (UTC -04:00)
tags: []
source: https://gtpservices.atlassian.net/wiki/spaces/SK/pages/201654303/App+Keys+Admin
author: 
---

# App Keys (Admin) - STRATUS Knowledge Base - Confluence

> ## Excerpt
> App Keys can be used by those customers who want to access the Stratus Open API. The application programming interface (API) is very easy to set up and use.  It can be accessed via most modern programming languages. It may be beneficial to create a new A360/Stratus user specifically for each integration. This approach will provide maximum flexibility regarding API data access and permissions in the future.

---
App Keys can be used by those customers who want to access the Stratus Open API. The application programming interface (API) is very easy to set up and use.  It can be accessed via most modern programming languages. It may be beneficial to create a new A360/Stratus user specifically for each integration. This approach will provide maximum flexibility regarding API data access and permissions in the future.

-   1 [Configure an App Key](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/201654303/App+Keys+Admin#Configure-an-App-Key)
-   2 [Configure App Key for PyperServer](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/201654303/App+Keys+Admin#Configure-App-Key-for-PyperServer)

## Configure an App Key

To use the Open API:

1.  Generate an application key in Admin > Company > App Keys.
    
    1.  **App Name**: A name to identify this particular integration.
        
    2.  **Key**: The unique app-key used by web api methods.
        
    3.  **Regenerate**: The way to reset an existing key for security purposes.
        
    4.  **Partner App**: App Keys used for partner apps (PypeServer, Novarc, FieldOrderz, GTP Connect, GTP Lightning, RazorGage, VicTools, WattsMueller, etc.) require this parameter to be selected. If the App Key is an internal application, no action is required.
        
    5.  **Run as User**: The Stratus user account that is used for project access and permissions.
        
    6.  **Modified By**: The last admin user to modify the application key entry.
        
    7.  **Active?**: A toggle to enable/disable the given app-key.
        
        ![](blob:https://gtpservices.atlassian.net/bde0256a-0a06-4fda-9785-b32848b30399#media-blob-url=true&id=b50b7353-028e-42da-97ac-d408ef656cb0&collection=contentId-201654303&contextId=201654303&mimeType=image%2Fpng&name=image2022-1-4_9-31-40.png&size=77225&width=1305&height=361&alt=)
        
2.  Test the API.
    
    1.  Go to [https://api.gtpstratus.com](https://api.gtpstratus.com/ "https://api.gtpstratus.com") to view and test out the available Stratus Open API web methods.  The API is fully documented with available data, methods, response details, objects, etc.  By copying-pasting your application key into the app-key authorize field above the methods, you can test them out by clicking the Execute button.  The response details will be displayed.
        
    2.  Copy/paste the API Key to use in the OpenAPI portal. Note: The API Key can be regenerated at anytime.
        
        ![](blob:https://gtpservices.atlassian.net/a3f41345-c176-449d-b284-9c9a68509d83)
        
        ![](blob:https://gtpservices.atlassian.net/49f67a4e-2d08-4ae4-8962-39a85d826f0b)
        

## Configure App Key for PyperServer

1.  Generate an App Key where the Partner App = PypeServer.
    
    ![app 1.png](blob:https://gtpservices.atlassian.net/362787dc-dc8a-426c-9517-9faf12cdfccd#media-blob-url=true&id=4884af44-88da-42f9-b09e-9b6c6abbefb9&collection=contentId-201654303&contextId=201654303&mimeType=image%2Fpng&name=app%201.png&size=23406&width=1543&height=185&alt=app%201.png)
    
2.  During the PypeServer installation process, enter the generated Key when prompted.
---
created: 2025-06-25T06:27:04 (UTC -04:00)
tags: []
source: https://gtpservices.atlassian.net/wiki/spaces/SK/pages/2689433601/Big+Data+Admin
author: 
---

# Big Data (Admin) - STRATUS Knowledge Base - Confluence

> ## Excerpt
> Stratus projects capture a huge volume of data, like tracking logs for example, but Stratus reporting has limits and Stratus APIs can be complex to consume. Stratus wants to provide customers access to all their project data, including custom calculated fields and much more. Stratus Big Data is the Stratus approach to providing an easy to consume data set, aggregated across all projects, comprised of data required to build extremely valuable cross project dashboards, with a fast API and straight forward data model. And there is a side benefit too, the new Power BI dashboards created with big data can be embedded into Stratus, so Stratus users have interactive context specific visual reports right in Stratus.

---
Stratus projects capture a huge volume of data, like tracking logs for example, but Stratus reporting has limits and Stratus APIs can be complex to consume. Stratus wants to provide customers access to all their project data, including custom calculated fields and much more. Stratus Big Data is the Stratus approach to providing an easy to consume data set, aggregated across all projects, comprised of data required to build extremely valuable cross project dashboards, with a fast API and straight forward data model. And there is a side benefit too, the new Power BI dashboards created with big data can be embedded into Stratus, so Stratus users have interactive context specific visual reports right in Stratus.

-   1 [Stratus Academy Course Video](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/2689433601/Big+Data+Admin#Stratus-Academy-Course-Video)
-   2 [Stratus Setup](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/2689433601/Big+Data+Admin#Stratus-Setup)
    -   2.1 [Prepare Reports and Fields](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/2689433601/Big+Data+Admin#Prepare-Reports-and-Fields)
    -   2.2 [Configuration](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/2689433601/Big+Data+Admin#Configuration)
        -   2.2.1 [Reports](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/2689433601/Big+Data+Admin#Reports)
        -   2.2.2 [Start Date](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/2689433601/Big+Data+Admin#Start-Date)
        -   2.2.3 [Run As Admin User](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/2689433601/Big+Data+Admin#Run-As-Admin-User)
        -   2.2.4 [Database Connection](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/2689433601/Big+Data+Admin#Database-Connection)
    -   2.3 [Analytics Reports](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/2689433601/Big+Data+Admin#Analytics-Reports)
    -   2.4 [Sync History](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/2689433601/Big+Data+Admin#Sync-History)
-   3 [Power BI Setup from Scratch](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/2689433601/Big+Data+Admin#Power-BI-Setup-from-Scratch)
    -   3.1 [Connect to SQL Server Data Tables](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/2689433601/Big+Data+Admin#Connect-to-SQL-Server-Data-Tables)
    -   3.2 [Data Table Relationship Mapping](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/2689433601/Big+Data+Admin#Data-Table-Relationship-Mapping)
        -   3.2.1 [Common Data Table Relationships](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/2689433601/Big+Data+Admin#Common-Data-Table-Relationships)
-   4 [Power BI Setup from Template](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/2689433601/Big+Data+Admin#Power-BI-Setup-from-Template)
-   5 [Convert Existing Power BI (Big Data Alpha) to Big Data SQL Connection](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/2689433601/Big+Data+Admin#Convert-Existing-Power-BI-(Big-Data-Alpha)-to-Big-Data-SQL-Connection)
-   6 [Power BI Training Resources](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/2689433601/Big+Data+Admin#Power-BI-Training-Resources)
-   7 [Contractor Metrics Recommendations](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/2689433601/Big+Data+Admin#Contractor-Metrics-Recommendations)

## Stratus Academy Course Video

To take the Big Data course, login to [**Stratus Academy**](https://academy.stratus.build/ "https://academy.stratus.build/") and and locate the course **ADM-521: Big Data**.

## Stratus Setup

## Prepare Reports and Fields

Create new reports and fields dedicated to Big Data Analytics for Models, Packages, Assemblies, and Parts that specify metrics to be captured.

**Prepare Fields and Reports Summary:**

1.  Big Data Package and Assembly reports are analogous to existing Package and Assembly dashboard reports, and can be configured to extract as many package and assembly data fields as needed.
    
2.  Report configuration tips:
    
    1.  **Dedicated Big Data Reports** - It is recommended that a dedicated report be created for each of area (Models, Packages, Assemblies, and Parts) and that the reports only be utilized by Stratus Big Data. A single report will specify metrics to be captured in each Big Data area (Models, Packages, Assemblies, and Parts). Any unexpected changes to the referenced reports or fields can cause issues with the Power BI data and republishing data could take up to 2 days to complete.
        
    2.  **Permissioned Reports** - In addition to creating dedicated reports, it is also recommended that Big Data reports be permissioned to those who are involved in Big Data and creating Power BI reports.
        
    3.  **Report Item Types** - When creating reports, only the following Report Item Types are allowed:
        
        1.  **Models** - Parts
            
            1.  **Note**: The Model report is actually a “Part” item type report and does not work like the others. Report metrics are gathered at the model level, so this report only extracts aggregated column data (the bottom or total row) holding a Sum or Average numeric result.
                
        2.  **Packages** \- Package
            
        3.  **Assemblies** \- Assembly
            
        4.  **Parts** \- Part
            
    4.  **Required Properties** - Only one report can be specified for each area (Models, Packages, Assemblies, and Parts), so create each report with the required properties that need to be published and used in Power BI. **Note:** If a report field needs to be added after the database has been published, it can take up to 2 days to publish the database again to include a missed report field.
        
    5.  **Report Field Format and Precision** - It is recommended to set Format to String, Integer, Decimal, Date, and Boolean. If, for example, FeetInch or InchFraction is selected, Big Data will convert it to a Decimal as Power BI does not recognize these as numbers. It is also recommended to configure **Precision** to specify how many decimal points are to be used.
        
    6.  **Report Field Built-in Properties** - The following Report Field properties are automatically included in reports published to Power BI and do not need to be included as a Report Field of a Report. If they are included, they will be ignored. Below is a list of “built-in properties”.
        
    7.  **Report Field Header or Field Display Name** - Under Reports > Report Fields, the Header overrides the Property Name. Similarly, under Fields the Display Name overrides the Name. Overriding these names can become confusing in Power BI if more than one field has the same override name. For this reason, it is recommended that Big Data report fields do not use either a **Report Field Header** or **Field Display Name**.
        
    8.  **Converted Property Names** - SQL and/or Power BI requires that Report Field property names follow certain standards, so Stratus helps convert property names. For example, spaces and invalid characters are replaced with an underscore. Below are some examples of how property names will be converted:
        
        1.  STRATUS.Assembly.NumParts to NumberofParts
            
        2.  Package(s) to Package\_s\_
            
        3.  Spool Name to SpoolName
            
    9.  **Model Viewer Checkbox** - Check the Model Viewer checkbox while testing and validating the data in the report. Once the report is working as expected, the Model Viewer checkbox can be unchecked.
        

## Configuration

**To Configure Big Data:**

1.  Go to Admin > Company > Big Data.
    

### **Reports**

1.  Under Reports, select the report to be used for:
    
    1.  Models
        
    2.  Packages
        
    3.  Assemblies
        
    4.  Parts
        
    5.  Containers
        

### **Start Date**

The **Start Date** is used to filter dated Tracking Log and Task entries. Only those entries newer than the Start Date will be published to the Big Data database in Power BI.

### **Run As Admin User**

The user selected under **Run As Admin User** is required to publish Big Data. The selected user does not require a specific project role and the data is not filtered based on the selected user’s permissions.

### **Database Connection**

The **Database Connection** section has two parts. The **Server** and **Database** values will automatically populate after the full data sync has completed. See the Sync History tab to see the data sync percent complete. The **Regenerate SQL User and Password** button generates the user name and password that enables login to the database in Power BI. These values will be used when connecting to Power BI. In addition, this section provides an option to rebuild the data after relevant Stratus report fields have changed.

1.  **Server** and **Database** - The **Server** and **Database** information identifies the database in Stratus Big Data. These values are copy/pasted into the SQL Server database dialog during step 3 of the [**Power BI Setup**](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/2689433601/Big+Data+Admin#Power-BI-Setup "https://gtpservices.atlassian.net/wiki/spaces/SK/pages/2689433601/Big+Data+Admin#Power-BI-Setup") process.
    
2.  **Regenerate SQL User and Password** - The SQL Server database in step 1 requires a **User name** and **Password**. To generate this User name and Password:
    
    1.  Click the **Regenerate SQL User and Password** button. The **Regenerate SQL User and Password** prompt will display. In addition to the prompt message, know that Stratus does **NOT** store the username and password. You must store these values for safe keeping within your own password management system. If **Yes** is clicked and a username and password already exists, then all existing connections will be broken and will require updating to the new username and password values.
        
    2.  Click **Yes** to generate a new SQL User name and Password.
        
    3.  The New SQL User and Password dialog will display. **Warning:** Be sure to copy the entire Password string as it is cutoff in this dialog. Store this User and Password in a safe place. All users running Power BI desktop will use this User name and Password to access the SQL Server database. Copy/paste this information during step 5 of the [**Power BI Setup**](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/2689433601/Big+Data+Admin#Power-BI-Setup "https://gtpservices.atlassian.net/wiki/spaces/SK/pages/2689433601/Big+Data+Admin#Power-BI-Setup") process
        
3.  **Rebuild Data (As Needed)** - Clicking the **Rebuild Data** button is used to force a full refresh of all big data. This manual operation is done anytime changes are made to the configured Report Fields and referenced field expressions as Stratus does not attempt to recognize all the potential modifications an admin can make that would impact the report generated results. Know that a full big data rebuild may take up to two days to complete as it processes all active projects in your company database.
    

## Analytics Reports

The Analytics Reports section is where Power BI reports are registered and embedded within Stratus.

To register a **New Analytics Report:**

1.  Click the **New Analytics Report** button.
    
2.  **Name** \- Enter the Name that will display in your analytics dropdowns in Stratus.
    
3.  **Report Type** - Defines the report type. Right now, the only option is Power BI.
    
4.  **Report Id** \- Copy/paste the unique ID that associates a specific report. This **reportId** is found in Power BI under File > Embed Report > Website or portal.
    
5.  **Tenant Id** (CTID) - Copy/paste the unique ID that associates a specific Microsoft tenant. This tenantId is found in Power BI under File > Embed Report > Website or portal.
    
6.  **Service Principal Authentication (Optional)** - This is a unique Microsoft Authentication and can be used like a universal username and password for accessing all Big Data reports embedded in Stratus. Without configuring the Service Principal Authentication, when a user attempts to access a report, like under Projects > Analytics, they will be prompted for their credentials.
    
    1.  **Workspace Id** - Locate Workspace Id in your company’s Azure settings.
        
    2.  **Client Id** - Locate Client Id in your company’s Azure settings.
        
    3.  **Client Secret** \- Locate Client Secret in your company’s Azure settings.
        

7.  **Projects** \- Select this option to display the Analytics Report under the Projects > Analytics tab in Stratus.
    
8.  **Models** \- Select this option to display the Analytics Report under the Models > Analytics tab in Stratus.
    
9.  **Packages** \- Select this option to display the Analytics Report under the Packages > Analytics tab in Stratus.
    
10.  **Show Filters** - Choose this option if you want your Analytics Report filters to display. This will give users access to the same filters you might see in Power BI.
    
11.  **Note**: Since Power BI is leveraged to aggregate data, non-Stratus data sources (Ex. ERP) can also be used and embedded within the context of Stratus projects.
    

## Sync History

The **Sync History** tab shows the history of data syncs from Stratus to the Stratus Analytics database. The Sync History section keeps the oldest publish record along with the most recent 9 updates, so 10 total. This allows you to see when the last full Rebuild took place and monitor how long each hourly sync is taking to complete. During a full rebuild, you can monitor the percent complete to know when all data has been updated in the big data SQL database. The initial data extraction may take up to two days to complete, as it processes all active projects in the company database. After the initial data sync, the data automatically synchronizes changed data every hour.

## Power BI Setup from Scratch

## Connect to SQL Server Data Tables

Each user who will use the Power BI Desktop application needs to connect to the SQL Server database generated in Stratus Big Data using the same SQL Server database Username and Password. See the [**Database Connection**](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/2689433601/Big+Data+Admin#Database-Connection "https://gtpservices.atlassian.net/wiki/spaces/SK/pages/2689433601/Big+Data+Admin#Database-Connection") section for more information.

1.  In Power BI, click **Get data** and then click **More**.
    
2.  In the Get Data dialog, click **Azure**, then **Azure SQL database** and then **Connect**.
    
3.  In the **SQL Server database** dialog, copy/paste the **Server** and **Database** information from the Stratus provided **Database Connection** under Admin > Company > Big Data > Configuration. See step 1 of the [**Database Connection**](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/2689433601/Big+Data+Admin#Database-Connection "https://gtpservices.atlassian.net/wiki/spaces/SK/pages/2689433601/Big+Data+Admin#Database-Connection") section for more information.
    
    1.  For **Data Connectivity Mode**, select either:
        
        1.  **Import (Recommended)** \- Check this option if you want to download the entire database and “Import” it into the report.
            
        2.  **DirectQuery** \- Check this option if you want to query the server database directly. This method has limitations which includes the inability to Filter via Date Hierarchy (Ex. Year, Month, Day).
            
4.  When done, click **Connect**. The SQL Server database dialog will display.
    
5.  With **Database** selected, copy/paste the safely saved SQL Server database **User name** and **Password**. See step 2c of the [**Database Connection**](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/2689433601/Big+Data+Admin#Database-Connection "https://gtpservices.atlassian.net/wiki/spaces/SK/pages/2689433601/Big+Data+Admin#Database-Connection") section for more information.
    
6.  Click **Connect**.
    
7.  After a successful database connection, the **Navigator** dialog will display the list of available SQL data tables available to bring into a Power BI report.
    
    1.  **Note**: Use **<shift> + click** to select the first then last to toggle ON and select all tables, then click **Load** button.
        
    2.  When done, each table will be available in Power BI as a separate data set.
        
8.  The data tables will load into Power BI and are available for report building including:
    
    1.  Default tables and any tables added via the configured reports.
        
    2.  Big Data Updates table which includes the last refreshed date-time. This data table will automatically populate the PowerBI Data when any Big Data update is made such as clicking the **Rebuild Data** button is clicked from Admin > Company > Big Data or when any scheduled update is executed.
        
9.  **Note**: The SQL Server database username and password are stored in Power BI and are used for multiple reports. If credentials need to be purged, in Power BI:
    
    1.  Click **Options and settings**
        
    2.  Click **Data source settings**
        
    3.  Locate the **s-bigdata** source
        
    4.  Click either **Edit Permissions** to change the permissions, or click **Clear Permissions** to purge the permissions.
        

## Data Table Relationship Mapping

After data tables have been published to Power BI, relationships between the data tables must be established prior to creating a report. This section demonstrates common relationship connections between the project, model, and package that you will configure in your data model. Note that this section does not go into detail behind the setup. See the [**Power BI Training Resources**](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/2689433601/Big+Data+Admin#Power-BI-Training-Resources "https://gtpservices.atlassian.net/wiki/spaces/SK/pages/2689433601/Big+Data+Admin#Power-BI-Training-Resources") for more information.

To configure relationships between data tables:

1.  In Power BI, click the **Model View** button on the left side. The data tables will display.
    
2.  Click and drag the data tables below to get them in proximity to each other.
    
3.  Configure the relationship between the Projects and Models data tables.
    
    1.  Within the Projects table, locate the Id property.
        
    2.  In the Models table, locate the Project Id property.
        
    3.  Click the Id property and drag it until it highlights the Project Id property.
        
    4.  The New relationship dialog displays informing that when the property name is Id, like in the Projects table, that it is a unique value in that table. Contrarily, if the property name includes another name like Project and Id, then this is not a unique value. So, in this case, there is one project that can have many models.
        
    5.  Click **Save** when done.
        
    6.  A visual representation of the tables displays the one to many relationship.
        
4.  Continue the process of connecting tables.
    
5.  Below is a table of relationships that should work for all companies.
    

### Common Data Table Relationships

| 
**Table**



 | 

**Column**



 | 

**Cardinality**



 | 

**Table**



 | 

**Column**



 |
| --- | --- | --- | --- | --- |

| 
**Table**



 | 

**Column**



 | 

**Cardinality**



 | 

**Table**



 | 

**Column**



 |
| --- | --- | --- | --- | --- |
| 

Models

 | 

ProjectId

 | 

Many to one

 | 

Projects

 | 

Id

 |
| 

Packages

 | 

ModelId

 | 

Many to one

 | 

Models

 | 

Id

 |
| 

Packages 

 | 

PackageCategoryId

 | 

Many to one

 | 

PackageCategories

 | 

Id

 |
| 

PackageTracking Updates

 | 

PackageId

 | 

Many to one

 | 

Packages

 | 

Id

 |
| 

PackageTracking Updates

 | 

TrackingStatusId

 | 

Many to one

 | 

TrackingStatuses

 | 

Id

 |
| 

Assemblies

 | 

ModelId

 | 

Many to one

 | 

Projects

 | 

Id

 |
| 

Parts

 | 

ModelId

 | 

Many to one

 | 

Projects

 | 

Id

 |

## Power BI Setup from Template

The following was originally posted in the Stratus Community discussion [**Big Data Template!**](https://community.stratus.build/t/big-data-template/1533 "https://community.stratus.build/t/big-data-template/1533")

In an effort to make Big Data and Power BI more accessible, we have created a Power BI Template file with some pre-built visualizations to help get you started. It also comes with most of the relationships already established and even a few custom columns for added flexibility. **Note:** This Template is built with Import instead of DirectQuery so the file may be very large once you bring your data in.

Click the link below to download the Power BI template file.

[**Big Data Template**](https://assets.gtp.one/Templates/big%20data%20PBIX%20template.pbit "https://assets.gtp.one/Templates/big%20data%20PBIX%20template.pbit")

This file is saved as a PBIT, meaning it does not contain any stored data or credentials. Once downloaded, the data source can be modified as needed.

Frank Scott, Onboarding & Implementation, has also built some new columns in to the tracking log. These are used to help you find the latest tracking status and also the date on which a specific tracking status happened. In my example 9, you will want to change this to match your “Fabrication Complete” or “Shipped” tracking status Index.

The goal of these columns is to reduce the number of Fields that you have to create that use the tracking status log since Big Data exports the whole thing for you!

A set of reports has already been created for this template. Your CSM can clone them for your company, or you can generate new reports using your own custom fields

## Convert Existing Power BI (Big Data Alpha) to Big Data SQL Connection

Below is a video of Jonathan Umscheid walking through the steps to convert existing Power BI data table relationships and reports to the newly supported Big Data SQL Connection.

<iframe allowfullscreen="" allowtransparency="true" data-hasbody="false" data-layout="default" data-local-id="d21f95f1-98c6-4b74-b142-34605b837d2b" data-macro-id="099a7cc9a9edff499c2015c586b133d4ba9df79c6a8cb9cfa400d218e96f9b31" data-macro-name="widget" frameborder="0" height="364" mozallowfullscreen="" webkitallowfullscreen="" width="640" src="https://player.vimeo.com/video/1056412182?h=6da04ae195"></iframe>

## Power BI Training Resources

-   [**Microsoft Power BI Learning Path**](https://learn.microsoft.com/en-us/training/powerplatform/power-bi "https://learn.microsoft.com/en-us/training/powerplatform/power-bi")
    
-   [**Microsoft Power BI get started documentation**](https://learn.microsoft.com/en-us/power-bi/fundamentals/ "https://learn.microsoft.com/en-us/power-bi/fundamentals/")
    
-   [**Microsoft Dynamic M query parameters in Power BI Desktop**](https://learn.microsoft.com/en-us/power-bi/connect-data/desktop-dynamic-m-query-parameters "https://learn.microsoft.com/en-us/power-bi/connect-data/desktop-dynamic-m-query-parameters")
    

## Contractor Metrics Recommendations

Many contract agree that focusing Big Data metrics on throughput is the best way to start building out visualizations. It’s a straightforward yet powerful metric that provides immediate insights into your production efficiency.

Below are some getting started metrics contractors have configured:

-   Durations for fab packages - How long each part is in a range of tracking statuses (Office, Shop, Field)
    
-   % complete on any project
    
-   Pipe length by material & size and tracking status
    
-   Duct weight by category, tracking status, etc.
    
-   Package lead time - With tracking status updates being time stamped, you can really see how long things are taking to work their way through the shop. A huge bonus is all the wonderful dimensions you can slice by along the way.
---
created: 2025-06-25T06:27:04 (UTC -04:00)
tags: []
source: https://gtpservices.atlassian.net/wiki/spaces/SK/pages/3408198/Company+Admin
author: 
---

# Company Admin - STRATUS Knowledge Base - Confluence

> ## Excerpt
> Company Admin settings are those which affect all projects and includes user settings as well as all things tracking, reporting, filtering and much more. These are handled through detailed and data driven configurations from within the Company Admin.

---
Company Admin settings are those which affect all projects and includes user settings as well as all things tracking, reporting, filtering and much more. These are handled through detailed and data driven configurations from within the Company Admin.

Here is a dependency tree for the Company Admin.

1.  Click the image to link to a scrollable full screen view.
2.  Use Crtl + mouse wheel to zoom.
3.  To return to this page, click the browser back button.

[![](https://gtpservices.atlassian.net/wiki/download/thumbnails/3408198/Dependencies.jpeg?version=1&modificationDate=1703014634654&cacheVersion=1&api=v2&width=650&height=650)](https://lucid.app/publicSegments/view/b5b52e9d-2029-47aa-aa1a-a3cea9f50d3e/image.jpeg):
---
created: 2025-06-25T06:27:04 (UTC -04:00)
tags: []
source: https://gtpservices.atlassian.net/wiki/spaces/SK/pages/1210417162/Company+Roles+Admin
author: 
---

# Company Roles (Admin) - STRATUS Knowledge Base - Confluence

> ## Excerpt
> Company Roles enables administrators to control which Admin tabs a user can access. For example, some shops have multiple “Admins” but want a role like a Shop Admin to control which Admin tabs can be viewed.

---
## Company Roles (Admin)

___

Company Roles enables administrators to control which Admin tabs a user can access. For example, some shops have multiple “Admins” but want a role like a Shop Admin to control which Admin tabs can be viewed.

-   1 [Configuration](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/1210417162/Company+Roles+Admin#Configuration)

## Configuration

**To add Company Role:**

1.  By default under Admin > Company > Company Roles, all current Administrators will be automatically assigned to the Administrator Company Role and all non-administrators will be assigned to the Standard User Company Role. A Company Admin can create and permission new Company Roles.
    
    ![](blob:https://gtpservices.atlassian.net/486296da-b5e6-4e08-9682-5b8ece657292)
    
2.  Click the **Add Company Role** button and enter a company role (Ex. Shop Admin) and then save.  
    
    ![](blob:https://gtpservices.atlassian.net/964a7b07-dccf-4844-9bbe-f51946ec2657)
    
3.  To configure the new Company Role, click the **Select Roles to Show** button. A Select Roles dialog similar to the following will display.
    
    ![](blob:https://gtpservices.atlassian.net/765e593e-24d8-40a2-8844-049d3ea820c4#media-blob-url=true&id=2e129bf9-66be-423c-ad1d-31530b61f291&collection=contentId-1210417162&contextId=1210417162&mimeType=image%2Fpng&name=image2021-1-29_10-9-35.png&size=12873&width=1435&height=160&alt=)
    
4.  Check the new role and then click Close. The new Company Role will display is ready to be edited.
    
    ![](blob:https://gtpservices.atlassian.net/a057cac5-b8d5-4c91-9ca9-bfcc0cf6d75f#media-blob-url=true&id=43c44e50-b15b-4585-b45b-56eecc12f18e&collection=contentId-1210417162&contextId=1210417162&mimeType=image%2Fpng&name=image2021-1-29_10-10-10.png&size=83996&width=1536&height=753&alt=)
    
5.  Each row represents a tab under Admin > Company. Check the tabs that the role can access.
    
    ![](blob:https://gtpservices.atlassian.net/7c819f83-f962-42df-8338-e09cc3b06b00#media-blob-url=true&id=88d0a9f8-c160-4668-bd40-3f1a437e20b7&collection=contentId-1210417162&contextId=1210417162&mimeType=image%2Fpng&name=image2021-1-29_10-10-43.png&size=71190&width=1541&height=491&alt=)
    
6.  Then, assign the Company Role to individual users under Admin > Company > Users.
    
    ![](https://media-cdn.atlassian.com/file/d460431a-557a-4418-bf9d-08ba1b026c73/image/cdn?allowAnimated=true&client=5f4a70b1-9d9d-47c3-b388-87235680bb54&collection=contentId-1210417162&height=398&max-age=2592000&mode=full-fit&source=mediaCard&token=eyJhbGciOiJIUzI1NiJ9.eyJpc3MiOiI1ZjRhNzBiMS05ZDlkLTQ3YzMtYjM4OC04NzIzNTY4MGJiNTQiLCJhY2Nlc3MiOnsidXJuOmZpbGVzdG9yZTpjb2xsZWN0aW9uOmNvbnRlbnRJZC0xMjEwNDE3MTYyIjpbInJlYWQiXX0sImV4cCI6MTc1MDg0OTgxNCwibmJmIjoxNzUwODQ2OTM0fQ.o78ef0TaK-vO_r3WHawGogbh5kQA8wBZYHSerPm7-V8&width=1528)
    
7.  Next time the user logs in, the tabs selected for the Company Role will display.
    
    ![](blob:https://gtpservices.atlassian.net/461b7896-f902-4294-83fc-6eb8bcededbf)
    

___
---
created: 2025-06-25T06:27:04 (UTC -04:00)
tags: []
source: https://gtpservices.atlassian.net/wiki/spaces/SK/pages/246317057/Containers+Admin
author: 
---

# Containers (Admin) - STRATUS Knowledge Base - Confluence

> ## Excerpt
> A Container represents any container used in the shop, for shipping, and in the field. The Admin > Containers page provides the ability to define containers, either manually or by importing a list of containers. In addition, a Container report label can be printed that will contain information about the container.  See the Containers Dashboard or the Containers Assign article for more information on how to manage Containers.

---
A Container represents any container used in the shop, for shipping, and in the field. The Admin > Containers page provides the ability to define containers, either manually or by importing a list of containers. In addition, a Container report label can be printed that will contain information about the container. See the [**Containers Dashboard**](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/1877573633 "https://gtpservices.atlassian.net/wiki/spaces/SK/pages/1877573633") or the [**Containers Assign**](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/1877574151 "https://gtpservices.atlassian.net/wiki/spaces/SK/pages/1877574151") article for more information on how to manage Containers.

-   1 [Stratus Academy Course Video](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/246317057/Containers+Admin#Stratus-Academy-Course-Video)
-   2 [Configure a Container](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/246317057/Containers+Admin#Configure-a-Container)
    -   2.1 [Manually Define a Container](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/246317057/Containers+Admin#Manually-Define-a-Container)
    -   2.2 [Import CSV](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/246317057/Containers+Admin#Import-CSV)
-   3 [Reports](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/246317057/Containers+Admin#Reports)
    -   3.1 [Container](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/246317057/Containers+Admin#Container)
    -   3.2 [Container Details](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/246317057/Containers+Admin#Container-Details)
    -   3.3 [Container Part, Assembly, or Package Report](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/246317057/Containers+Admin#Container-Part%2C-Assembly%2C-or-Package-Report)
    -   3.4 [Print Container Label](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/246317057/Containers+Admin#Print-Container-Label)
-   4 [Admin: Package Categories > Use Containers](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/246317057/Containers+Admin#Admin%3A-Package-Categories-%3E-Use-Containers)
-   5 [Admin: Tracking Statuses](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/246317057/Containers+Admin#Admin%3A-Tracking-Statuses)
-   6  [Admin: Project Role](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/246317057/Containers+Admin#Admin%3A-Project-Role)
-   7 [Video](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/246317057/Containers+Admin#Video)
    -   7.1 [Stratus 09/10/2020 Implementation Webinar - Containers](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/246317057/Containers+Admin#Stratus-09%2F10%2F2020-Implementation-Webinar---Containers)

## Stratus Academy Course Video

To take the Task Definitions course, login to [**Stratus Academy**](https://academy.stratus.build/ "https://academy.stratus.build/") and locate the course **ADM-518: Task Definitions**.

## Configure a Container

Containers can be configured in two ways:

1.  Manually configure containers on the Admin > Company > Containers page. See the [**Manually Define a Container**](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/246317057/Containers+Admin#Define-Container "https://gtpservices.atlassian.net/wiki/spaces/SK/pages/246317057/Containers+Admin#Define-Container") section.
    
2.  Configure a CSV file and then upload it to the Admin > Company > Containers page. See the [**Import CSV**](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/246317057/Containers+Admin#Upload-Containers-from-a-CSV-File "https://gtpservices.atlassian.net/wiki/spaces/SK/pages/246317057/Containers+Admin#Upload-Containers-from-a-CSV-File") section.
    

## Manually Define a Container

1.  In Stratus, create a new Container under Admin > Company > Containers.
    
2.  Click **New Container**. Below is an example.
    
    1.  **Name (required)** – This is the name that is printed on the container label.
        
    2.  **Description** **(required)** – Clarify the container type and can be used on a label.
        
    3.  **Container Type** **(required)** – Select the container type that best describes the container. Current options include Area, Basket, Box, Cart, Pallet, Rack, Shelf, Shipping, Trailer, or Truck.
        
    4.  **Length (Optional)** – Enter the length of the container as feet/inches. Used for labels or reporting.
        
    5.  **Width (Optional)** – Enter the width of the container as feet/inches. Used for labels or reporting.
        
    6.  **Height (Optional)** – Enter the Height of the container as feet/inches. Used for labels or reporting.
        
    7.  **Location (Optional)** \- Enter the name of the location if this is helpful (Ex. A location on the Jobsite).
        
    8.  **Print Labels** – The Print Labels button is used to print the container label after a) the label **Report** (below) is configured, b) a print Tool is configured (below), and c) the [**GTP Stratus Print**](https://www.dropbox.com/sh/4hftsujfunksicx/AAAlklSQs3ZUbMin3yaMC0-Ia?dl=0 "https://www.dropbox.com/sh/4hftsujfunksicx/AAAlklSQs3ZUbMin3yaMC0-Ia?dl=0") software has been installed, opened, and is pointing to a zebra compatible printer.
        

## Import CSV

A list of containers can be uploaded from a CSV file. Existing containers will either remain the same or be updated and new containers will be added. Containers cannot be deleted using the Import CSV feature.

To upload containers from a CSV file:

1.  Go to Admin > Company > Containers.
    
2.  Click the **CSV** button. Download the file which will be named Containers - Company Admin(1).csv or something similar.
    
3.  With the .CSV file open you can see the required comma-delimited column headings:
    
    1.  **Name (required)** - Special characters can be used. If there is a duplicate name in the .CSV file, the container that is in row 17 will a container that is in row 3, for example.
        
    2.  **Description (required)** \- Enter a description.
        
    3.  **Container Type (required)** - Required and must include one of the following. If the field is blank, it will default to Box in Stratus.
        
        1.  Area
            
        2.  Basket
            
        3.  Box
            
        4.  Cart
            
        5.  Pallet
            
        6.  Rack
            
        7.  Shelf
            
        8.  Shipping
            
        9.  Trailer
            
        10.  Truck
            
    4.  **Length** \- Optional. If this field is blank, it will display 0” in Stratus.
        
    5.  **Width** \- Optional. If this field is blank, it will display 0” in Stratus.
        
    6.  **Height** \- Optional. If this field is blank, it will display 0” in Stratus.
        
4.  With these column headings, you can add or edit containers given the requirements above.
    
5.  Once your comma-delimited .CSV container file is saved, on the Admin > Company > Containers page, click the **Import CSV** button. The Import Containers dialog will display.
    
6.  Browser to locate the .CSV file and then click Open. The Upload Containers CSV File dialog will display.
    
7.  Once the file has uploaded, click the **Close** button.
    
8.  The Import Containers dialog will display. Click **Upload** and then click the **Import** button.
    
9.  The file will process and will display the Import was successful message.
    
10.  The list of CSV containers will display under **Admin** > **Company** > **Containers**.
    

## Reports

## Container

A Container report includes information about the container, not the contents of the container.

A Container Label can be printed from the Containers (Admin) page or from the [**Containers Assign**](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/1877574151 "https://gtpservices.atlassian.net/wiki/spaces/SK/pages/1877574151") page once a container has been selected. Before a Container label can be printed, it must be configured. See the [**Example: Container Label Report**](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/10617393#Reports(Admin)-Example%3AContainerLabelReport "https://gtpservices.atlassian.net/wiki/spaces/SK/pages/10617393#Reports(Admin)-Example%3AContainerLabelReport") section for more information. To Print a Container Label, see the [**Print Container Label**](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/246317057/Containers+Admin#Print-Container-Label "https://gtpservices.atlassian.net/wiki/spaces/SK/pages/246317057/Containers+Admin#Print-Container-Label") section.

## Container Details

A Container Details report includes the contents of a container, not information about the container. A Container Details report is run from the Container’s page. Before a Container report can be generated, it must be configured. See the [**Example: Container Details Report**](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/10617393#Reports(Admin)-Example%3AContainerDetailsReport "https://gtpservices.atlassian.net/wiki/spaces/SK/pages/10617393#Reports(Admin)-Example%3AContainerDetailsReport") section for more information.

## Container Part, Assembly, or Package Report

A Container Part, Assembly, or Package report is targeted to Shop or Field workers to provide them with container information to help locate items. See the [**Example: Container Part, Assembly, or Package Report**](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/10617393#Reports(Admin)-Example%3AContainerPart%2CAssembly%2CorPackageReport "https://gtpservices.atlassian.net/wiki/spaces/SK/pages/10617393#Reports(Admin)-Example%3AContainerPart%2CAssembly%2CorPackageReport") section for more information.

## Print Container Label

A Container Label can be printed from the Containers (Admin) page or from the [**Containers Assign**](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/246317057/Containers+Admin# "#") page once a container has been selected. Before a Container label can be printed, it must be configured. See the [**Example: Container Label Report**](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/10617393#Reports(Admin)-Example%3AContainerLabelReport "https://gtpservices.atlassian.net/wiki/spaces/SK/pages/10617393#Reports(Admin)-Example%3AContainerLabelReport") section for more information.

To print a Container label:

1.  Open the **GTP Stratus Print** application and check that it is pointing to the correct company, tool, and label printer. Download the [**GTP Stratus Print**](https://www.dropbox.com/sh/4hftsujfunksicx/AAAlklSQs3ZUbMin3yaMC0-Ia?dl=0 "https://www.dropbox.com/sh/4hftsujfunksicx/AAAlklSQs3ZUbMin3yaMC0-Ia?dl=0") if it’s not already installed.
    
2.  Print a Container Label from either location below:
    
    1.  Under **Admin** > **Company** > **Containers** click the **Print Labels** button for any container.
        
    2.  Under Containers > Print Label button.
        
3.  You will be prompted to **Select Printer Tool**.
    
    1.  **Select the tool that will be used to print the labels.** See the [**Tools (Admin)**](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/215220225 "https://gtpservices.atlassian.net/wiki/spaces/SK/pages/215220225") article for more information.
        
    2.  **Select the ZPL Container Report with the desired Label Template** – This is the Container Label Report mentioned above.
        
4.  Click **OK**. The label will print. Below is an example.
    

## Admin: Package Categories > Use Containers

Under Admin > Company > Package Categories, the **Use Containers** checkbox tells Stratus whether or not to display the package in Containers > Assign and Containers > Dashboard. See the [**New Package Category (Basic)**](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/166199351#PackageCategories(Admin)-NewPackageCategory(Basic) "https://gtpservices.atlassian.net/wiki/spaces/SK/pages/166199351#PackageCategories(Admin)-NewPackageCategory(Basic)") article more information.

To configure the **Use Containers** checkbox:

1.  **Use Containers** \- Under Admin > Company > Package Categories:
    
    1.  **Unchecked** - When the **Use Containers** checkbox is unchecked, packages created with the Package Category will not display in Containers.
        
    2.  **Checked (Default)** - When the **Use Containers** setting is checked (default), packages created with the Package Category will display in Containers.
        
2.  The setting is initially used in two places:
    
    1.  **Containers Assign Package Display**
        
        1.  **Use Containers checked** - When **User Containers** is checked and a package is created using the associated package category, the package will display in the **Containers > Assign > Package** drop-down.
            
        2.  **Use Containers unchecked** - In the example below, **User Containers** is unchecked for the Default package category.
            
        3.  As a result, a package created using the Default package category, the package will not display in the **Containers > Assign > Package** drop-down.
            
    2.  **Containers > Dashboard Filter for Stratus.Container.Package Report Properties**
        
        1.  When the **Stratus.Container.Package Report Properties** are used in a report they can be used to filter Packages.
            
3.  See the [**STRATUS.Container.\***](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/598868043#STRATUS.*ParametersandProperties-STRATUS.Container.* "https://gtpservices.atlassian.net/wiki/spaces/SK/pages/598868043#STRATUS.*ParametersandProperties-STRATUS.Container.*") section for more information on Container fields.
    

## Admin: Tracking Statuses

When adding a part, assembly, or package to a container, the tracking status of that item will automatically change to the first available tracking status where **Applies to Container** is checked. In the example below, when an item is added to a container it’s Tracking Status will be automatically updated to **Shipping to Jobsite**. In addition, an automated Tracking comment “Stratus Added \[Item\]” is added to the tracking log.

##  Admin: Project Role

Project Role Permissions under Containers > Assign include the **Empty Container** button and the prompts to **Delete Tracking Log**.

1.  **Empty Container**
    
    1.  **Checked** \- When checked the Empty Container and Remove buttons will display.
        
    2.  **Unchecked** \- When unchecked, the Empty Container and Remove buttons will not display.
        
2.  **Delete Tracking Log**
    
    1.  **Checked** \- When checked, after using the **Empty Container** button to empty the container, the following prompt to start a **New Tracking Log** will display.
        
    2.  **Unchecked** \- When unchecked, after using the **Empty Container** button to empty the container, the **New Tracking Log** prompt (see above) will not be presented.
        

## Video

## Stratus 09/10/2020 Implementation Webinar - Containers

<iframe allowfullscreen="" allowtransparency="true" data-hasbody="false" data-layout="default" data-local-id="0247be23-982e-4ed0-aac4-c992315c7be3" data-macro-id="809f9d15-2f03-4c7c-a5cc-bfb07e0137fe" data-macro-name="widget" frameborder="0" height="364" mozallowfullscreen="" webkitallowfullscreen="" width="640" src="https://player.vimeo.com/video/456687290?h=embed"></iframe>

00:16 Containers Introduction  
00:51 Containers Setup - Admin > Company > Containers  
04:15 Containers Module  
07:48 Package Viewer > Filters > Containers  
10:07 Container Contents Report  
11:05 Container within a Container  
14:04 Container and Container Children Tracking Statuses  
17:01 Scan Module  
20:35 How can I ship multi-trade racks?  
20:45 Would I setup a job site as a Container?
---
created: 2025-06-25T06:27:04 (UTC -04:00)
tags: []
source: https://gtpservices.atlassian.net/wiki/spaces/SK/pages/10518700/Cost+Categories+Admin
author: 
---

# Cost Categories (Admin) - STRATUS Knowledge Base - Confluence

> ## Excerpt
> Atlassian uses cookies to improve your browsing experience, perform analytics and research, and conduct advertising. Accept all cookies to indicate that you agree to our use of cookies on your device. Atlassian cookies and tracking notice, (opens new window)

---
Atlassian uses cookies to improve your browsing experience, perform analytics and research, and conduct advertising. Accept all cookies to indicate that you agree to our use of cookies on your device. [Atlassian cookies and tracking notice, (opens new window)](https://www.atlassian.com/legal/cookies)
---
created: 2025-06-25T06:27:04 (UTC -04:00)
tags: []
source: https://gtpservices.atlassian.net/wiki/spaces/SK/pages/10486154/Cost+Types+Admin
author: 
---

# Cost Types (Admin) - STRATUS Knowledge Base - Confluence

> ## Excerpt
> Atlassian uses cookies to improve your browsing experience, perform analytics and research, and conduct advertising. Accept all cookies to indicate that you agree to our use of cookies on your device. Atlassian cookies and tracking notice, (opens new window)

---
Atlassian uses cookies to improve your browsing experience, perform analytics and research, and conduct advertising. Accept all cookies to indicate that you agree to our use of cookies on your device. [Atlassian cookies and tracking notice, (opens new window)](https://www.atlassian.com/legal/cookies)
---
created: 2025-06-25T06:27:04 (UTC -04:00)
tags: []
source: https://gtpservices.atlassian.net/wiki/spaces/SK/pages/255393797/Deliverables+Definitions+Admin
author: 
---

# Deliverables Definitions (Admin) - STRATUS Knowledge Base - Confluence

> ## Excerpt
> A Project Deliverable is a filter that enables you to combine a part or assembly filter with a project area to automatically create package deliverables. A Deliverable Definition is created at the Company level and associates a Deliverable with a Filter. You can look at a Deliverable Definition as how your company breaks down a project for fabrication.

---
A [**Project Deliverable**](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/3211746 "https://gtpservices.atlassian.net/wiki/spaces/SK/pages/3211746") is a filter that enables you to combine a part or assembly filter with a project area to automatically create package deliverables. A Deliverable Definition is created at the Company level and associates a Deliverable with a Filter. You can look at a Deliverable Definition as how your company breaks down a project for fabrication.

-   1 [Stratus Academy Course Video](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/255393797/Deliverables+Definitions+Admin#Stratus-Academy-Course-Video)
-   2 [Create Deliverable Definition](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/255393797/Deliverables+Definitions+Admin#Create-Deliverable-Definition)

## Stratus Academy Course Video

To take the Deliverables for Administrators course, login to [**Stratus Academy**](https://academy.stratus.build/ "https://academy.stratus.build/") and locate the course **ADM-517: Deliverables**.

To take the Deliverables for Managers course, login to [**Stratus Academy**](https://academy.stratus.build/ "https://academy.stratus.build/") and locate the course **MGR-310: Deliverables**.

## Create Deliverable Definition

The first step in creating a project deliverable is to create company level Deliverable Definition under Admin > Company > Deliverable Definition. All projects will use Deliverable Definitions which is where you define your part or assembly filter and standardize the abbreviation used for numbering packages. Notice that Area is not included in this definition as it will be defined under [**Areas (Admin)**](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/103284742 "https://gtpservices.atlassian.net/wiki/spaces/SK/pages/103284742") and joined the Deliverable Definition under [**Deliverables**](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/3211746 "https://gtpservices.atlassian.net/wiki/spaces/SK/pages/3211746")**.**

**To create a new Deliverable Definition:**

1.  Click the **New Deliverable Definition.** A new row will display.  
    
    ![](blob:https://gtpservices.atlassian.net/7380bd92-0d45-4a44-8194-5776deaa43af)
    
    1.  **Name** – Enter the name of the Deliverable Definition.
        
    2.  **Filter** – Select the filter that will be used for this Deliverable Definition. Filters are created under Admin > Company > Filters and must be applied to the Model Viewer.
        
    3.  **Grouping (Optional)** - A Grouping is an additional breakdown level for package deliverables. See the [**Groupings (Admin)**](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/217907389 "https://gtpservices.atlassian.net/wiki/spaces/SK/pages/217907389") article for more information.
        
    4.  **Consider Areas in Groupings**
        
        1.  **Checked (Default)** - When checked and a Grouping value is found during the Generate Deliverables process, Groupings within areas will be considered in the generation of deliverables. As a result, more package deliverables with fewer parts in each will be created.
            
        2.  **Unchecked** - When unchecked, Areas will not be considered in generating deliverables. Rather, the Filter and Grouping will be used to generate the deliverables. As a result, when Deliverables are generated on the Projects > Deliverables page, the Area column will be blank.
            

3.  Once done, see the [**Admin > Projects > Deliverables (Admin)**](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/3211746 "https://gtpservices.atlassian.net/wiki/spaces/SK/pages/3211746") article for more information.
---
created: 2025-06-25T06:27:04 (UTC -04:00)
tags: []
source: https://gtpservices.atlassian.net/wiki/spaces/SK/pages/103317524/Divisions+Admin
author: 
---

# Divisions (Admin) - STRATUS Knowledge Base - Confluence

> ## Excerpt
> A Division is a name for a department, person, or group that processes work packages and is specific to your company’s workflow, and is used to filter data tables. The future vision for Divisions is to use divisions as discreet business units that most closely align to a single cost code or group of cost codes. A Division is required when defining a Station. See the Project Divisions (Admin) article for information about Project-level Divisions.

---
A **Division** is a name for a department, person, or group that processes work packages and is specific to your company’s workflow, and is used to filter data tables. The future vision for Divisions is to use divisions as discreet business units that most closely align to a single cost code or group of cost codes. A Division is required when defining a Station. See the **[Project Divisions (Admin)](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/2038333441/Project+Divisions+Admin)** article for information about Project-level Divisions.

-   1[Configuration](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/103317524/Divisions+Admin#Divisions(Admin)-Configuration)

## Configuration

1.  Define a Division under **Admin > Company > Divisions**.
2.  Click **New Division or edit an existing Division.**  
    ![](https://gtpservices.atlassian.net/wiki/download/thumbnails/103317524/image2022-9-21_11-7-54.png?version=1&modificationDate=1663776475662&cacheVersion=1&api=v2&width=837&height=250)
    1.  **Division** - The name of the Division.
    2.  **Address** - The Country, Address, City, State, and Zip are used to define the address of the Division and will be automatically applied in other parts of STRATUS in the future.
    3.  **Phase** - By default, STRATUS includes Divisions aligned to four project phases, Office, Purchasing, Shop, or Field.  
        ![](https://gtpservices.atlassian.net/wiki/download/thumbnails/103317524/image2022-9-21_11-33-6.png?version=1&modificationDate=1663777987674&cacheVersion=1&api=v2&width=837&height=250)
        1.  The phase is part of the Tracking Statuses configuration.  
            ![](https://gtpservices.atlassian.net/wiki/download/thumbnails/103317524/image2019-11-12_15-44-18.png?version=1&modificationDate=1573595060631&cacheVersion=1&api=v2&width=1100&height=396)
            1.  **Note**: In order for a Division to be selectable for a Tracking Status, the Phase associated with the Division must be checked.  
                For example:
                1.  Since the Issued for Fabrication tracking status does not have Tracking Status Group checked...  
                    ![](https://gtpservices.atlassian.net/wiki/download/attachments/103317524/image2019-12-10_14-29-26.png?version=1&modificationDate=1576009767450&cacheVersion=1&api=v2)
            2.  ...on the Assemblies Viewer page, when the assembly is in the Issued for Fabrication tracking status, a Division cannot be selected.  
                ![](https://gtpservices.atlassian.net/wiki/download/attachments/103317524/image2022-9-21_11-37-50.png?version=1&modificationDate=1663778271175&cacheVersion=1&api=v2)
    4.  **Field Orderz Division** - Not currently used.
    5.  **Notes** - Add notes to better understand the purpose of the Division.
3.  Once done click **Save**.
---
created: 2025-06-25T06:27:04 (UTC -04:00)
tags: []
source: https://gtpservices.atlassian.net/wiki/spaces/SK/pages/166035577/Fields+Admin
author: 
---

# Fields (Admin) - STRATUS Knowledge Base - Confluence

> ## Excerpt
> Fields enable the administrator to write expressions and calculated fields in Excel-like formulas.  A field may refer to a user-editable property or to a calculated field value. A calculated field can be composed of multiple property values. A Stratus.Field can be used in many places including in another Stratus.Field, a Stratus.Alias (Alias), a Filter, in Reports and Dashboards.  Note: Deleting a Field will also delete the field from any report that used it.

---
Fields enable the administrator to write expressions and calculated fields in Excel-like formulas.  A field may refer to a user-editable property or to a calculated field value. A calculated field can be composed of multiple property values. A Stratus.Field can be used in many places including in another Stratus.Field, a Stratus.Alias (Alias), a Filter, in Reports and Dashboards.  Note: Deleting a Field will also delete the field from any report that used it.

This page includes information about all Stratus functions like Average(). Other non-Stratus functions like IsBlank() are documented in the [**Albatross Expression Api**](https://rushuiguan.github.io/expression/ "https://rushuiguan.github.io/expression/") library under Api Documentation and then under Albatross.Expression.Operations.

-   1 [Configure](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/166035577/Fields+Admin#Configure)
-   2 [Examples](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/166035577/Fields+Admin#Examples)
    -   2.1 [Fields Referenced in Report](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/166035577/Fields+Admin#Fields-Referenced-in-Report)
    -   2.2 ["If" Statements](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/166035577/Fields+Admin#%22If%22-Statements)
        -   2.2.1 ["if" Statement](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/166035577/Fields+Admin#%22if%22-Statement)
        -   2.2.2 [Nested "if" Statement](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/166035577/Fields+Admin#Nested-%22if%22-Statement)
    -   2.3 [Concatenated Field](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/166035577/Fields+Admin#Concatenated-Field)
    -   2.4 [Weld Count](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/166035577/Fields+Admin#Weld-Count)
    -   2.5 [Filter to parts that have Pipe Length](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/166035577/Fields+Admin#Filter-to-parts-that-have-Pipe-Length)
    -   2.6 [Filter packages to last 14 days](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/166035577/Fields+Admin#Filter-packages-to-last-14-days)
    -   2.7 [Ancillary Functions](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/166035577/Fields+Admin#Ancillary-Functions)
        -   2.7.1 [ValueFromArray()](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/166035577/Fields+Admin#ValueFromArray())
        -   2.7.2 [TotalFromArray()](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/166035577/Fields+Admin#TotalFromArray())
    -   2.8 [Date Functions](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/166035577/Fields+Admin#Date-Functions)
        -   2.8.1 [Two Parameters - Calculate Difference Between Two Date Fields](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/166035577/Fields+Admin#Two-Parameters---Calculate-Difference-Between-Two-Date-Fields) 
        -   2.8.2 [Three Parameters - Calculate Work Days Remaining Between Two Date Fields](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/166035577/Fields+Admin#Three-Parameters---Calculate-Work-Days-Remaining-Between-Two-Date-Fields)
        -   2.8.3 [DateOffset() Function](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/166035577/Fields+Admin#DateOffset()-Function)
        -   2.8.4 [DayName() Function](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/166035577/Fields+Admin#DayName()-Function) 
        -   2.8.5 [StartOfWeek() Function](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/166035577/Fields+Admin#StartOfWeek()-Function)
        -   2.8.6 [DayOfWeek() Function](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/166035577/Fields+Admin#DayOfWeek()-Function)
    -   2.9 [Tracking Status Functions](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/166035577/Fields+Admin#Tracking-Status-Functions)
        -   2.9.1 [HoursInTrackingStatus() Function](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/166035577/Fields+Admin#HoursInTrackingStatus()-Function)
        -   2.9.2 [TrackingStatusChange() Function](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/166035577/Fields+Admin#TrackingStatusChange()-Function)
            -   2.9.2.1 [Example](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/166035577/Fields+Admin#Example)
            -   2.9.2.2 [Use Cases](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/166035577/Fields+Admin#Use-Cases)
        -   2.9.3 [TrackingStatusDate() Function](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/166035577/Fields+Admin#TrackingStatusDate()-Function)
        -   2.9.4 [TrackingStatusOnDate() Function](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/166035577/Fields+Admin#TrackingStatusOnDate()-Function)
        -   2.9.5 [TrackingStatusBy() Expression Function](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/166035577/Fields+Admin#TrackingStatusBy()-Expression-Function)
        -   2.9.6 [{TrackingStatusLog}](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/166035577/Fields+Admin#%7BTrackingStatusLog%7D)
        -   2.9.7 [{TrackingStatusLogDT}](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/166035577/Fields+Admin#%7BTrackingStatusLogDT%7D)
        -   2.9.8 [{TrackingStatusLogBy}](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/166035577/Fields+Admin#%7BTrackingStatusLogBy%7D)
        -   2.9.9 [{Stratus.\*.TrackingStatusLogStation}](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/166035577/Fields+Admin#%7BStratus.*.TrackingStatusLogStation%7D)
    -   2.10 [String Manipulation and Count Functions](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/166035577/Fields+Admin#String-Manipulation-and-Count-Functions)
        -   2.10.1 [IndexOf() and LastIndexOf()](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/166035577/Fields+Admin#IndexOf()-and-LastIndexOf())
            -   2.10.1.1 [Example](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/166035577/Fields+Admin#Example.1)
        -   2.10.2 [ArrayCount()](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/166035577/Fields+Admin#ArrayCount())
        -   2.10.3 [ArrayMultiply()](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/166035577/Fields+Admin#ArrayMultiply())
        -   2.10.4 [ValueAtIndex()](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/166035577/Fields+Admin#ValueAtIndex())
        -   2.10.5 [MostCommon()](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/166035577/Fields+Admin#MostCommon())
        -   2.10.6 [UniqueValues()](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/166035577/Fields+Admin#UniqueValues())
        -   2.10.7 [Sum()](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/166035577/Fields+Admin#Sum())
        -   2.10.8 [Average()](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/166035577/Fields+Admin#Average())
        -   2.10.9 [Maximum()](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/166035577/Fields+Admin#Maximum())
        -   2.10.10 [Minimum()](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/166035577/Fields+Admin#Minimum())
        -   2.10.11 [Round()](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/166035577/Fields+Admin#Round())
        -   2.10.12 [Absolute Function Abs()](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/166035577/Fields+Admin#Absolute-Function-Abs())
        -   2.10.13 [Split() Function and Fixed Len()](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/166035577/Fields+Admin#Split()-Function-and-Fixed-Len()) 
        -   2.10.14 [AsFeetInch() Function - Expression](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/166035577/Fields+Admin#AsFeetInch()-Function---Expression)
        -   2.10.15 [AsFeetInch() Function - Leading Zero](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/166035577/Fields+Admin#AsFeetInch()-Function---Leading-Zero)
        -   2.10.16 [AsMetric() Function - Expression](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/166035577/Fields+Admin#AsMetric()-Function---Expression)
        -   2.10.17 [Replace() Function](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/166035577/Fields+Admin#Replace()-Function)
        -   2.10.18 [FilterArray() Function](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/166035577/Fields+Admin#FilterArray()-Function)
        -   2.10.19 [Add New Line \\n](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/166035577/Fields+Admin#Add-New-Line-%5Cn)
    -   2.11 [Added Field Expression to Return an Assembly’s First Non-empty Value from Child Parts](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/166035577/Fields+Admin#Added-Field-Expression-to-Return-an-Assembly%E2%80%99s-First-Non-empty-Value-from-Child-Parts)
    -   2.12 [Checkbox](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/166035577/Fields+Admin#Checkbox)
    -   2.13 [Hide Value when Expression is not met](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/166035577/Fields+Admin#Hide-Value-when-Expression-is-not-met)
    -   2.14 [Use Tracking Status Index Number](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/166035577/Fields+Admin#Use-Tracking-Status-Index-Number)
    -   2.15 [Square Root](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/166035577/Fields+Admin#Square-Root)
    -   2.16 [SIMPLE IF STATEMENTS](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/166035577/Fields+Admin#SIMPLE-IF-STATEMENTS)
    -   2.17 [TREATING PARAMETERS AS NUMBERS](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/166035577/Fields+Admin#TREATING-PARAMETERS-AS-NUMBERS)
    -   2.18 [ISBLANK](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/166035577/Fields+Admin#ISBLANK)
    -   2.19 [PASS THROUGH FIELDS](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/166035577/Fields+Admin#PASS-THROUGH-FIELDS)
    -   2.20 [SIMPLE CONCANTENATED FIELDS](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/166035577/Fields+Admin#SIMPLE-CONCANTENATED-FIELDS)
    -   2.21 ["POLISHING FIELD" AND CONCANTENATED](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/166035577/Fields+Admin#%22POLISHING-FIELD%22-AND-CONCANTENATED)
    -   2.22 [MATERIAL TRANSLATION](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/166035577/Fields+Admin#MATERIAL-TRANSLATION)
    -   2.23 [JOINT METHOD](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/166035577/Fields+Admin#JOINT-METHOD)
    -   2.24 [MATERIAL COST](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/166035577/Fields+Admin#MATERIAL-COST)
    -   2.25 [HTML IN FIELDS (NOT SUPPORTED!)](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/166035577/Fields+Admin#HTML-IN-FIELDS-(NOT-SUPPORTED!))
-   3 [Field Syntax Errors](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/166035577/Fields+Admin#Field-Syntax-Errors)
    -   3.1 [Different types encountered within the same operation](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/166035577/Fields+Admin#Different-types-encountered-within-the-same-operation)
-   4 [Videos](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/166035577/Fields+Admin#Videos)
    -   4.1 [08/19/2024 - Stratus Academy: ADM-505: Admin 2 - Fields](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/166035577/Fields+Admin#08%2F19%2F2024---Stratus-Academy%3A-ADM-505%3A-Admin-2---Fields)
    -   4.2 [12/03/2020 - Leveraging your data with Fields](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/166035577/Fields+Admin#12%2F03%2F2020---Leveraging-your-data-with-Fields)
    -   4.3 [04/30/2020 Implementation Webinar - Using Fields in Stratus](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/166035577/Fields+Admin#04%2F30%2F2020-Implementation-Webinar---Using-Fields-in-Stratus)
    -   4.4 [04/25/2019 Implementation Webinar - Write Field Expressions and Calculated Fields](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/166035577/Fields+Admin#04%2F25%2F2019-Implementation-Webinar---Write-Field-Expressions-and-Calculated-Fields) 

## Configure

**To configure a field:**

1.  Under **Admin** > **Company** > **Fields,** click the **New Field** button. The field editor displays.
    
2.  **Field Definitions**
    
    1.  **Name** – Name of the field. Field names cannot contain special characters like **.{}()+-/\***
        
    2.  **Display Name** - The purpose of this column is to use a Field Display Name in reports rather than the full name of the expression. There are rules as to when the Display Name is used, for example if there is not a Report Field header.  See examples below.
        
        1.  **Three Examples:** The screen shot below highlights which column heading will be used and in the order each will be used.  
            
            ![](blob:https://gtpservices.atlassian.net/d2f8a358-a3e2-4fa5-97c8-9fdb44ba6919)
            
            1.  **Report Field Header** under Admin > Company > Report > Report Field > Header.
                
                Example: In Report Fields, the Header = **Total Pipe Length - H** which takes precedence over the Fields Display Name = **Total Pipe Length - F**.
                
            2.  **Field Display Name** under Admin > Company > Fields > Display Name.  
                Example: In Report Fields, there is no Header for the field in row #3, therefore, the Fields Display Name = **Total Pipe Length - F** displays.
                
            3.  **No Field Display Name or Report Field Header**  
                Example: The field does not have a Display Name under Fields, nor does it have a Header under Report Fields. Therefore, the column header uses the Field Name (Ex. **TotalPipeLength\_NoName**).
                
    3.  **Description** – Clarification of the field purpose.
        
    4.  **Part Filter** - The Part Filter column provides administrators with the ability to filter parts before they are processed by the Field Expression. As a result, the Field Expression will process a filtered subset of the model parts rather than the entire model which will result in faster report generation and less complicated Field Expressions. Below is a Pipe Length and an Earned Labor example.
        
        1.  **Example - Pipe Length**
            
            **Old Field Expression** - The top row displays the **Old Field Expression** which had to query for the CID, then query parts, and then query categories to give a result.
            
            **New Part Filter** - The bottom row displays the selected **Part Filter** (see the referenced filter below). Referencing the Part Filter makes for a simpler Field Expression (Ex. {Length}). In many cases, the Filters will have already been written and in used in viewers under Filters > Company. Expressions with a part filter will return an empty result for parts which don't match the filter.
            
            The **Part Filter** referenced above does all the pre-filtering including the ServiceType, CID, Source, Product Name, and Category so that your field expression only has to ask for the {Length}.
            
            As a result, the report (below) includes both the OLD and NEW fields to show they result in the same values.
            
            -   OLD Field (Ex. CSG \_ Pipework \_ Dashboard \_ Total Pipe Length which uses the report field column header Linear Feet Of Pipe (Total))
                
            -   NEW Field (Ex. QA\_CSG \_ Pipework \_ Dashboard \_ Total Pipe Length which uses the report field column header QA\_Linear Feet Of Pipe (Total)
                
        2.  **Example - Earned Labor**
            
            **Old Field Expression** - The top row displays the **Old Field Expression** which had to query for the parts to see if it they were past a certain tracking status.
            
            **New Part Filter** - The bottom row displays the selected **Part Filter** (see the referenced filter below). Referencing the Part Filter makes for a simpler Field Expression.
            
    5.  **Data Type – The following data types can be defined.** Note: Selecting the correct Data Type is directly related to whether or not your Field will function properly.
        
        1.  **String** – Works with Alphanumeric characters and for the results of a concatenated field. See the Concatenated Field example below.
            
        2.  **Integer** \- Used to calculate Numbers or set a Boolean checkbox.
            
            1.  **Boolean** - A Boolean checkbox must have the following:
                
                1.  **Data Type**: Integer or String
                    
                2.  **Default Value**: 
                    
                    1.  **Integer**: 1 = Checked checkbox, or, 0 = Unchecked checkbox
                        
                    2.  **String**: true = Checked checkbox, or, false = Unchecked checkbox
                        
                3.  **Is Editable**: Checked
                    
                4.  **Possible Values**: Not Used  
                    
                5.  Example of all Boolean Field options:
                    
                6.  Example of all Boolean Field option results:
                    
        3.  **Decimal** – Used to calculate Numbers and Decimals.
            
        4.  **Date** – Date and time stamp.
            
        5.  **Array** - The **Array** Data Type generates a semicolon-separated list of values for a property, one value per part, for a package or assembly (Ex. Weight, Services, etc.). A second field should be created which processes the array resulting list of values and utilizes one of the available functions such as Maximum(), Minimum(), Average(), MostCommon(), UniqueValues(), etc. to determine the result.
            
            **Note:** The **Data Type** "Array" should not be used in conjunction with the **Is Total** checkbox being checked. **Array** and **Is Total** are alternative solutions to the same problem.  “Is Total” is the original method while “Array” is the new method to solve the problem.
            
            1.  For example, with Data Type = Array, this Field Expression will list the Service or ServiceAbbreviations for all parts in the package or assembly report.
                
    6.  **Default Value** – The default value, if any, that you want to be entered for this field.
        
    7.  **Is Editable (checked by default)** – When checked, this field can be edited by users.  For example, let’s say you want to add the ability to approve a package or enter an approved date. Create the new field where Is Editable is checked and then add the field to a package report.  Below is an example of editing a Field on the Packages > Dashboard. Users simply click the cell to edit. Once saved, the information will be metadata attached to the package. See the **Possible Values** column for information on setting values for a drop-down option list.
        
    8.  **Possible Values (;)** - The Possible Values column provides the way to set drop-down values for the editable field. When Is Editable is checked, a semi-colon separated list of possible values can be entered and will display in the report. For example:
        
        1.  The values 0.30;0.50;0.70 have been entered in **Possible Values** column for this editable field. **Note**: Emojis can also be entered by pressing the \[Windows key\]+\[.\] keys the emoji popup will display and any selections can be used in the list of Possible Values.  
            
            ![](blob:https://gtpservices.atlassian.net/f913a715-d5ef-4208-96cd-dcf0726e2b39)
            
        2.  **Note**: The default value (0.30) was included and each value includes 2 decimal places since the report will display Decimal and Precision = 2.  
            
            ![](blob:https://gtpservices.atlassian.net/e362e7e4-bee9-40bf-b802-8cf9bd628c6a)
            
        3.  On the Packages Dashboard, the Possible Values will display.  
            
            ![](blob:https://gtpservices.atlassian.net/05062a92-2930-40cd-bda5-7ff71043fd06)
            
    9.  **Is Expression** – Check the **Is Expression** checkbox if you are entering an expression in the **Expression** field. See below for allowable expression variables, operators, and functions.
        
        1.  **Note**: When **Is Editable and Is Expression are both checked**, then the calculated value will be used as the default, but then a user will be allowed to edit the values.
            
        2.  **Tips**:
            
            1.  The Field’s **Data Type** needs to be set to Decimal whenever the value of the Field is used in a **mathematical Expression.**
                
            2.  The Field’s **Is Total** property needs to be checked ON whenever the Field is referenced in a report where Item Type is Package and Package Dashboard is checked (i.e. a Packages Dashboard report) and is used to sum part values for a package (e.g. weight).
                
            3.  Expressions referencing a part property that may not always be filled out or have a valid value should be wrapped with AsNumber()
                
                1.  Example: AsNumber({Gauge}) ), as this will convert unrecognized values to 0.
                    
                2.  Example: AsNumber({Volume}), to get the total for Volume in Packages for pipes.
                    
            4.  When a field references text, it must be enclosed in single quotes. If you are not sure, try it both ways. For example, in this expression:  
                if({CID}='2041' And {Stratus.Part.TrackingStatus}='Ordered', {Length}, if({CID}='2041' And {Stratus.Part.TrackingStatus}='Issued for Fabrication', {Length}, NA))
                
                1.  {CID}='2041' - The CID value is returned as text.
                    
                2.  {Stratus.Part.TrackingStatus}='Ordered' - A Tracking Status will be returned as text.
                    
                3.  {Length} - Length and other measurements will be returned as numbers, so they are not in single quotes.
                    
            5.  When editing an expression, some users have found that using a tool like [Notepad++](https://notepad-plus-plus.org/ "https://notepad-plus-plus.org/") made it is easier to see parentheses and other formatting than the Stratus dialog.
                
    10.  **Is Total** – The **Is Total** field will sum the associated property value from every part in the package. When **Is Total** is checked, the field will return a single value, the total from all parts in the package or assembly, but are limited to only working with numeric values.
        
        **Note:** The **Data Type** "Array" should not be used in conjunction with the **Is Total** checkbox being checked. **Array** and **Is Total** are alternative solutions to the same problem.  “Is Total” is the original method while “Array” is the new method to solve the problem.
        
        1.  **Ex**. Generate a sum of labor hours from all parts within a package.
            
        2.  **Ex**. Generate the total weld diameter inches for pipe welds within a package.
            
        3.  **Ex**. Generate the total weight of all parts within a package.
            
    11.  **Expression** – Enter your expression using the variables, operators, and functions described below. **Note**: If you are using an expression, be sure to check the Is Expression checkbox.
        
    12.  **Unit** - A unit is used for Station metrics on the Shops > Dashboard > Task Velocity column.
        
    13.  **References** - Helps administrators understand where the filters are being referenced. Click the references number to display the references (Type and Name).  
        
        ![](blob:https://gtpservices.atlassian.net/f910ceab-c02f-40ec-bffd-ebcac744db1e)
        
    14.  **Delete** - Click to delete a field. If a user attempts to delete a field that is used a Template, an error message similar to the following will display. This will help prevent accidentally deleting a field and the reports that use the field from failing.  
        
        ![](blob:https://gtpservices.atlassian.net/7038674b-dd65-43be-aee1-bd062742e626)
        
3.  **Variables**
    
    1.  Inside the expression, reference any reportable property name from the item or Stratus using curly brackets. For example:
        
        1.  {Stratus.Package.RequiredDT}
            
        2.  {Stratus.Field.Approved By}
            
        3.  {Length}
            
        4.  {Outside Diameter}
            
        
4.  **Operators and Functions**
    
    1.  The following operators and functions are allowed:
        
        1.  spaces are allowed within expressions
            
        2.  +
            
        3.  \-
            
        4.  /
            
        5.  \*
            
        6.  \=
            
        7.  \> 
            
        8.  < 
            
        9.  <>  which means "does not equal"
            
        10.  \>=
            
        11.  <=
            
        12.  and
            
        13.  or
            
        14.  not
            
        15.  pi or Pi
            
        16.  avg(<comma separated list of values>)
            
        17.  if(<condition>,<true result>,<false result>)
            
            1.  <isBlank({property})
                
        18.  format(<variable>,<C# format string>)
            
        19.  left(<string>,<number of characters>)
            
        20.  Today() - returns UTC date at midnight
            
        21.  Now() - returns UTC date and time
            
        
5.  If an additional field is used on the Packages Dashboard and has been edited manually or via API, the field will display in the Package's Properties tab under Additional Fields.   
    
    ![](blob:https://gtpservices.atlassian.net/377ee444-cbbf-4d41-a5ec-bd7a20584fed)
    

## Examples

## Fields Referenced in Report

When a report is created that uses a Stratus.Fields.X, where X is the name of the field, remember any fields that were used to create the Stratus.Fields.X field must also be included in the list of report fields. For example:

1.  If in the report, a Report Field like Stratus.Field.Fabrication Start Date is referenced;
    
2.  Then, review the field (Ex. Stratus.Field.Fabrication Start Date) and determine what, if any fields, make up the field. In this case it is made up of Stratus.Package.RequiredDT and Stratus.Field.Fabrication Lead Time. As a result, both of these fields must also be included in the list of Report Fields in order for the Stratus.Field.Fabrication Start Date to calculate.
    

## "If" Statements

### "if" Statement

Here is an example of a simple "if" statement:

The syntax of an if statement is:

1.  **Data Type** = Decimal
    
2.  **Is Editable** = Checked
    
3.  **Expression** = if({CID}=2041, {Length}, 0)
    
    1.  This expression says, if the CID value is 2041, return the Length, if not, then it is false and ignore it.
        

### Nested "if" Statement

A nested "If" statement provides flexibility to check for values.  Let's look at an example that has 7 "if" statements:

if({Stratus.Part.TrackingStatus}='Fabrication Complete', {Installation Cost}\*{Stratus.Field.GTP Fabrication Labor Factor},  
if({Stratus.Part.TrackingStatus}='Shipped', {Installation Cost}\*{Stratus.Field.GTP Fabrication Labor Factor},  
if({Stratus.Part.TrackingStatus}='Field Received', {Installation Cost}\*{Stratus.Field.GTP Fabrication Labor Factor},  
if({Stratus.Part.TrackingStatus}='Field Installed', {Installation Cost}\*{Stratus.Field.GTP Fabrication Labor Factor},  
if({Stratus.Part.TrackingStatus}='Tested', {Installation Cost}\*{Stratus.Field.GTP Fabrication Labor Factor},  
if({Stratus.Part.TrackingStatus}='Flushed', {Installation Cost}\*{Stratus.Field.GTP Fabrication Labor Factor},  
if({Stratus.Part.TrackingStatus}='Inspected', {Installation Cost}\*{Stratus.Field.GTP Fabrication Labor Factor}, 0)))))))

This expression says:

1.  If the Tracking Status is Fabrication Complete, give me the results of {Installation Cost}\*{Stratus.Field.GTP Fabrication Labor Factor}
    
2.  If it is not Fabrication Complete, then check to see if the value is Shipped. If so, give me the results of {Installation Cost}\*{Stratus.Field.GTP Fabrication Labor Factor}.
    
3.  And so on until the end and if none of the tracking statuses have returned a value, then return false (i.e. 0).
    

## Concatenated Field

A concatenated field is a good way to bring information from different fields into a single field that can help make a report more meaningful. For example, let's say you have a field for Material and a field for Gauge and want to bring them together in a single field. To concatenate these two fields:

![](blob:https://gtpservices.atlassian.net/0283e077-2515-4db7-9731-dc47253ed46d)

1.  Create a Field where:
    
    1.  **Data Type** = String because concatenated fields always return text.
        
    2.  **Is Expression** = Checked
        
    3.  **Expression** = {MaterialGauge}+" Gauge "+{Material}
        
        1.  The syntax of this expression says, give me the Material Gauge, which is a number, the plus signs let you enter text, so in this case you'll get a space after the Material Gauge, the word Gauge, and then the Material.
            
2.  The result on a report would be a single field with the value of "24 Galvanized", for example.
    

## Weld Count

To count the number of any part, welds in this case, do an expression like this.  

![](blob:https://gtpservices.atlassian.net/dfb09c0c-6fd9-46ec-a826-149d131b326c)

1.  **Data Type** = Integer because it will return numbers.
    
2.  **Is Expression** = Checked
    
3.  **Expression** = if({ServiceType}="Weld", 1, 0)
    
    1.  This expression says, if Service Type is Weld, return a 1, if not return a 0. Add this field as a report field in a report and the 1's will be totaled up in a report.
        

## Filter to parts that have Pipe Length

1.  One way to filter to parts that have Pipe Length is the following expression:  
    if({CID}=2041, {Length}, NA)
    
    1.  This says if, the part includes the parameter CID =2041, then display the Length. If it does not, then don't display anything for the part.
        
2.  This could be used as a report field in an Assemblies Spool BOM report to either display or not display pipe length.
    

## Filter packages to last 14 days

1.  To filter packages to the last 14 days (2 weeks before the Required Date of the package):
    
    1.  {Stratus.Package.RequiredDT} – 14
        
2.  To display a variable that references the property of a part, configure a field like:
    
    1.  {Diameter}
        
    2.  {Fabrication Hours}
        
    3.  {Length}
        
    4.  {Weight}
        
3.  To find the Circumference:
    
    1.  {Diameter} \* pi
        
4.  To find the conduit elbows centerline, create one or more fields to calculate length:
    
    1.  (({radius} + {diameter}) / 2)) \* {angle}
        
5.  To have function1 run for Autocad Fabrication parts and function2 on Revit parts:
    
    1.  if(left({Stratus.Part.CadType},20)="Autodesk.Fabrication", <function1>,<function2>)
        

## Ancillary Functions

The functions ValueFromArray() and TotalFromArray() are helpful when reporting on fabrication ancillary items.

### ValueFromArray()

Returns Value from Array2

ValueFromArray(value1, array1, array2, \[optional\] instance) expects three or four arguments and returns value from array2 at index corresponding to value1 instance position in array1, otherwise empty result.

**Example** 

A user wanted to display the highlighted content, but not the x'ed out content.

![](blob:https://gtpservices.atlassian.net/4bfe3dfa-3116-4f28-bf30-027a42ad66e5)

**Solution**

In this example, there are two ‘Fixing’ entries.  By providing the optional 1-based value for instance, you can get the two values separately:

ValueFromArray(‘Fixing’,{Stratus.Ancillary.Type},{Stratus.Ancillary.Name},1) returns ‘3/8” – 16 GREENE BANG-IT ROD HANGER’.

ValueFromArray(‘Fixing’,{Stratus.Ancillary.Type},{Stratus.Ancillary.Name},2) returns ‘3/8” Hex Nut’.

You could create two new fields, one for Fixing1 and one for Fixing2 and set them equal to the expressions above. Then, if you wanted to look at the values from them and only return the value if it contains the word ‘Nut’, you could add another field and use an expression like this which would return the Nut if one exists:

If(IndexOf(‘Nut’,{Stratus.Field.Fixing1})>-1,{Stratus.Field.Fixing1},If(IndexOf(‘Nut’,{Stratus.Field.Fixing2})>-1,{Stratus.Field.Fixing2},’’),’’)

In fact, you don’t have to create separate fields, rather, you can use the same ValueFromArray() expressions in multiple places.

### TotalFromArray()

Returns Total of All Values from Array2

TotalFromArray(value1, array1, array2, \[optional\] array3) expects three or four arguments and returns total of all values from array2 (or product of array2 and array3 if provided) at indexes corresponding to value1 positions in array1, otherwise zero.

When data is similar to the following:

The following Expressions can extract report data.

## Date Functions

### Two Parameters - Calculate Difference Between Two Date Fields 

The Days() expression function can be used to calculate the integer value difference between two date fields (parameters). This could be used, for example, as a calculation on the Packages Dashboard.

**Syntax:** Days({EndDate}, {StartDate}

To use the Days() expression function:

1.  **Create a new Field** under Admin > Company > Fields where the expression is similar to the following where your two date fields replace the date fields below:  
    Days({Stratus.Package.RequiredDT},{Stratus.Field.Fabrication Start Date})
    
2.  **Data Type = Integer**
    
3.  **Is Expression = Checked**
    
4.  The result on the Packages Dashboard report will be similar to the following where the Days() expression function calculates the difference between the Required Date and the  Fabrication Start Date.
    

### Three Parameters - Calculate Work Days Remaining Between Two Date Fields

By adding a third parameter to the **Days() Field function** it can be used to calculate the work days remaining between two dates and exclude non-working days and holidays. The syntax is the following where the third parameter is 7 values that represent the 7 days of the week. It can either be hard coded in a additional field that passes in the 7 values (Ex. Ex. 0, 1, 1, 1, 1, 1, 0 indicates that 5 of 7 days are work days), or an editable checkbox fields configured that provides more granular control over work days.

**Syntax:** Days({EndDate}, {StartDate}, {NumberOfWeekDays})

1.  Below is a report example where the Fabrication Start Date (Fab Start Date) can be calculated when the Required Date (Req DT) and Fabrication Lead Time (Fab Lead) Time are entered and the days being worked are set. This report is run on the Packages Dashboard.
    
2.  To create this report, the values for the third parameter, which indicate the number of work days in the week, need to be configured.
    
    1.  **Example 1**: The third parameter in this example will set the number of workdays per week to 5 because 5 of 7 variables are “1”.  
        Days({EndDate}, {StartDate}, **0, 1, 1, 1, 1, 1, 0**)
        
    2.  **Example 2**: For more granular settings:
        
        1.  Set the number of days that will be worked with editable checkbox fields.  Notice the default value of 1 will check the checkbox.
            
        2.  Reference the checkbox fields in the Days() function using the third parameter. To automatically skip holidays when counting the number of days in a work week, enter the holiday date in double quotes after the 7 days of week parameters have been entered, add double quotes “2019-10-31”.
            
        3.  Add the fields to a report.
            
        4.  Configure other fields, if needed, like Fabrication Lead Time and Required Date and add them to the report.
            
        5.  Run the report in the Packages Dashboard.
            

### DateOffset() Function

The DateOffset() function calculates a date-time based on the year, day, and hour offset. The DateTime returned can be used in other functions that expect a DateTime argument. 

1.  **Generic Syntax**: DateOffset(DateTime, YearOffset, DayOffset, HourOffset) returns new DateTime
    
2.  **Example will return a 1 or 0**: TrackingStatusChange({Stratus.Package.TrackingStatusLog},'Packaged',{Stratus.Package.TrackingStatusLogDT},DateOffset(Now(),-1,-7,0),'',{Stratus.Package.TrackingStatusLogBy},'Kelly Demo')
    

### DayName() Function 

The DayName() function returns the name of the day for the date. 

Example: DayName({_Stratus.Package.TrackingStatusLogDT_})

### StartOfWeek() Function

The StartOfWeek() Function returns a specific day in the week (Ex. Tuesday).

Example:

StartOfWeek({_Stratus.Package.TrackingStatusLogDT_})

### DayOfWeek() Function

The DayOfWeek(Stratus.) Function returns a day in the week where Sunday starts at 0.

Example:

DayOfWeek(Stratus.Field.Day3)<(RequiredDT)

## Tracking Status Functions

### HoursInTrackingStatus() Function

The Hours Field Expression function (HoursInTrackingStatus) calculates the time an item has been in a tracking status. Below are 2 examples of how the Stratus.Part.TrackingStatusLog and the HoursInTrackingStatus function can be used in a Field Expression.

1.  Calculate how long an item has been in a tracking status. For example:
    
    1.  The field expression below uses the new **HoursInTrackingStatus** function and says look at the part tracking log and then match up the part tracking status date-time for the part, and then calculate the time the part has been in the Issued tracking status.
        
    2.  HoursInTrackingStatus({Stratus.Part.TrackingStatusLog},{Stratus.Part.TrackingStatusLogDT},'Issued')
        
        1.  **Note**: In this example, if Issued is the current tracking status, the clock is still running, meaning the HoursInTrackingStatus function will return the time since the status change was made to the present time.
            
        2.  **Also note**: The value returned is hours. It may make more sense to convert to days by dividing by 24.0, or, in the case you want to report working days, you could divide by 5 and then multiply by 7.
            
2.  Calculate how long it took to move from one tracking status to another. For example:
    
    1.  The field expression below uses the new **HoursInTrackingStatus** function and says look at the assembly tracking log and then match up the assembly tracking status date-time for Packaged and then provide the amount of time it took for the tracking status to change to Shipped, and use Eastern Standard Time.
        
    2.  HoursInTrackingStatus({Stratus.Assembly.TrackingStatusLog},Stratus.Assembly.TrackingStatusLogDT},'Packaged','Shipped','Eastern Standard Time')
        
        1.  **Note**: Eastern Standard Time is the specific way a time zone is referenced by Microsoft. For a list of other time zones, refer to this external article [**List of Timezone IDs**](https://stackoverflow.com/questions/7908343/list-of-timezone-ids-for-use-with-findtimezonebyid-in-c "https://stackoverflow.com/questions/7908343/list-of-timezone-ids-for-use-with-findtimezonebyid-in-c"). The time zone is needed to handle the case where the clock is still running, meaning the assembly has not reached the Shipped status in this example.
            
        2.  **Is Total** - The field’s **Is Total** checkbox should be checked when the report used by the field needs to drill into the part level to total hours.
            

### TrackingStatusChange() Function

The TrackingStatusChange() function can provide report data that answers questions like “How may many feet of pipe cut are cut or spools welded per day, per week, per month?

This function returns a 0 or 1. As a result, it can be determined whether the tracking status has been applied, given the optional filters.  By returning a 0 or 1, it can be multiplied by whatever the desired metric unit is from the part (Ex. Diameter).  By building an integer Field with ‘Is Total’ checked and using an integer field in a package report, totals per package can be summarized.

The following is a list of generic function arguments that provide the following:

-   Tracking status applied
    
-   Timespan to filter (optional)
    
-   User to filter (optional)
    

Generic Syntax: TrackingStatusChange({Stratus.\*.TrackingStatusLog}, TrackingStatus, {Stratus.\*.TrackingStatusLogDT}, StartDT, EndDT, {Stratus.\*.TrackingStatusLogBy}, UserName)

#### Example

Below is an example of a Packages Dashboard report that uses the field expression that will display the total weld inches completed last week (in the last 7 days) by a specific weld station operator (Kelly Demo. 

TrackingStatusChange({_Stratus.Part.TrackingStatusLog_},_'Fabricated'_,{_Stratus.Part.TrackingStatusLogDT_},DateOffset(Now(),0,-7,0),_''_,{_Stratus.Part.TrackingStatusLogBy_}_,'Kelly Demo'_)\*{_Diameter_}

#### Use Cases

There are 4 possible use cases, depending on optional arguments. 

1.  Return 1 if TrackingStatus has ever been applied
    
    1.  **Generic Syntax:** TrackingStatusChange({Stratus.\*.TrackingStatusLog}, TrackingStatus)
        
    2.  **Example:** TrackingStatusChange({Stratus.Package.TrackingStatusLog},'Packaged')
        
2.  Return 1 if TrackingStatus has been applied between StartDT and EndDT. Note: It is acceptable to provide only one of the date arguments, leaving out that date time-bound check.
    
    1.  **Generic Syntax:** TrackingStatusChange({Stratus.\*.TrackingStatusLog}, TrackingStatus, {Stratus.\*.TrackingStatusLogDT}, StartDT, EndDT)
        
    2.  **Example:** TrackingStatusChange({Stratus.Package.TrackingStatusLog},'Packaged',{Stratus.Package.TrackingStatusLogDT},'09/01/2020','09/30/2020')
        
3.  Return 1 if TrackingStatus has ever been applied by a particular station or user name.
    
    1.  **Generic Syntax:** UserNameTrackingStatusChange({Stratus.\*.TrackingStatusLog}, TrackingStatus, '', '', '', {Stratus.\*.TrackingStatusLogBy}, UserName)
        
    2.  **Example:** TrackingStatusChange({Stratus.Package.TrackingStatusLog}, 'Packaged', '', '', '', '', {Stratus.Package.TrackingStatusLogBy}, 'Kelly Demo')
        
4.  Returns 1 if TrackingStatus has been applied between StartDT and EndDT by UserName
    
    1.  **Generic Syntax:** TrackingStatusChange({Stratus.\*.TrackingStatusLog}, TrackingStatus, {Stratus.\*.TrackingStatusLogDT}, StartDT, EndDT, {Stratus.\*.TrackingStatusLogBy}, UserName)
        
    2.  **Example:** TrackingStatusChange({Stratus.Package.TrackingStatusLog}, 'Packaged', {Stratus.Package.TrackingStatusLogDT}, '09/01/20','09/30/20', {Stratus.Package.TrackingStatusLogBy}, 'Kelly Demo')
        

### TrackingStatusDate() Function

The TrackingStatusDate() function is used to determine the date-time of a specific tracking status change.

**Below is an example of TrackingStatusDate():**

**Generic Syntax:** TrackingStatusDate({Stratus.\*.TrackingStatusLog}, 'YourTrackingStatus', {Stratus.\*.TrackingStatusLogDT})

**This example will return the date-time the Package’s Tracking Status changed to Packaged:** TrackingStatusDate({Stratus.Package.TrackingStatusLog}, 'Packaged', {Stratus.Package.TrackingStatusLogDT})

**Field Configuration:**  
Notice the Data Type = String. If Data Type = Date it will only return the date, not the time.

**Report Property Configuration Example:**  
Notice the Format = String. If Format = Date it will only return the date, not the time.

![](blob:https://gtpservices.atlassian.net/1beaea94-fd13-4a09-a3df-6ac101a055bb)

**Packages Dashboard Report Examples**  
The date-time is returned when the Package’s Tracking Status was changed to Packaged.

### TrackingStatusOnDate() Function

The TrackingStatusOnDate() function can be used in a Field Expression to determine the tracking status of a package at a specific time, either Now() or DateOffset(Now()).

1.  **Now()** \- When used with the Now() function, the package’s tracking status at the time the report is run will be returned. Alternatively, the Today() function will return the package’s tracking status at midnight.  
    **Now() syntax example** - TrackingStatusOnDate({Stratus.Package.TrackingStatusLog}, {Stratus.Package.TrackingStatusLogDT}, Now())
    
2.  **DateOffset(Now())** - When used with DateOffset(Now()), the package’s tracking status for x number of days (Ex. -7) in the past can be displayed.  
    **DateOffset(Now()) syntax example** \- {Stratus.Package.TrackingStatusLogDT}, DateOffset(Now(), 0, -7, 0))
    

### TrackingStatusBy() Expression Function

The TrackingStatusBy() function is used to determine the name of the user who made a specific tracking status change.

**Below is an example of TrackingStatusBy():**

**Generic Syntax:** TrackingStatusBy({Stratus.\*.TrackingStatusLog}, TrackingStatus, {Stratus.\*.TrackingStatusLogBy}, UseLastIndex)  
**Note:** UseLastIndex defaults to False which will return the last username that changed the tracking status to the configured tracking status. If it is set to True, it will return the username who first changed the tracking status to Packaged.

**This example will return the UserName who first changed the tracking status to Packaged if found, otherwise empty:**  
TrackingStatusBy({Stratus.Package.TrackingStatusLog}, 'Packaged', {Stratus.Package.TrackingStatusLogBy}, True)

**Field Configuration:**

**Report Property Configuration Example:**

**Packages Dashboard Report Example:**

### {TrackingStatusLog}

The {Stratus.\*.TrackingStatusLog} field returns a semi-colon separated list of tracking status changes. Replace the \* with Part, Package, or Assembly.

### {TrackingStatusLogDT}

The {Stratus.\*.TrackingStatusLogDT} field returns a semi-colon separated list of tracking status change date-times. Replace the \* with Part, Package, or Assembly.

### {TrackingStatusLogBy}

The {Stratus.\*.TrackingStatusLogBy} field returns a semi-colon separated list of user names who made each tracking status change. Replace the \* with Part, Package, or Assembly.

### {Stratus.\*.TrackingStatusLogStation}

The {Stratus.Part.TrackingStatusLogStation} field returns a semi-colon separated list of stations who made each tracking status change to the part. Replace the \* with Part, Package, or Assembly.

Below is an example of **{Stratus.Package.TrackingStatusLogStation}**:

**Generic Syntax:** TrackingStatusChange({Stratus.\*.TrackingStatusLog}, ‘TrackingStatus’, {Stratus.Package.TrackingStatusLogStation}, 'Station')

**Example will return a 1 or 0 if the Signed in station (< 7" Carbon Steel IPS) changes the tracking status to Issued for Fabrication:** TrackingStatusChange({Stratus.Package.TrackingStatusLog},'Issued for Fabrication','','','',{Stratus.Package.TrackingStatusLogStation},'< 7" Carbon Steel IPS')

**Property Name in Report:** The Stratus.Package.TrackingStatusLogStation Property Name can be selected as a report field to display all stations that have changed the tracking status of the package.

**Field Configuration:**  

![](blob:https://gtpservices.atlassian.net/8325f477-a310-4181-8800-05f309a8ac21)

**Report Property Configuration Example:**

You’ll see the following report fields on the Packaged Dashboard report below.

-   Row 12 uses a Field Expression that references the property.
    
-   Row 13 displays the property values.  
    
    ![](blob:https://gtpservices.atlassian.net/984fd125-2576-428a-86e7-b5fdf273bc21)
    

**Packages Dashboard Report Examples**  

![](blob:https://gtpservices.atlassian.net/f1b3fc89-3b3e-439a-b881-4a6fdda3d868)

1.  **Example A**
    
    1.  The **Package Tracking Status Log Station** displays a 1 since the above Field Expression is true, namely, the < 7" Carbon Steel IPS station was Signed in and changed the tracking status to Issued for Fabrication.
        
    2.  The **Stratus.Package.TrackingStatusLogStation** property displays the name(s) of the Signed in Station(s) that have changed the tracking status.
        
2.  **Example B**
    
    1.  The **Package Tracking Status Log Station** displays a 0 since the above Field Expression is false, namely, other stations changed the tracking status and Issued for Fabrication may or may not have been one of the tracking status changes.
        
    2.  The **Stratus.Package.TrackingStatusLogStation** property displays the name(s) of the Signed in station(s) that changed the tracking status.
        

## String Manipulation and Count Functions

### IndexOf() and LastIndexOf()

The IndexOf() and LastIndexOf() functions provide a way to manipulate strings within field expressions. See the Tracking to Packaged most recent change column in the screenshot above. Note: These functions are designed to find the closed parentheses “)” in a string.

-   IndexOf(String1,String2) - Returns the first character index of a search string within another string value or -1 if not found or empty. 
    
-   LastIndexOf(String1,String2) - Returns the last character index of a search string within another string value or -1 if not found or empty.
    

#### Example

To display the date-time for the most recent tracking status change for a package in the Packages Dashboard, create a Field that contains the following Field Expression and then reference the field in a report:

  
If(LastIndexOf(';',{Stratus.Package.TrackingStatusLogDT}) > -1, Right({Stratus.Package.TrackingStatusLogDT}, AsNumber(Len({Stratus.Package.TrackingStatusLogDT})) - LastIndexOf(';',{Stratus.Package.TrackingStatusLogDT}) - 1), {Stratus.Package.TrackingStatusLogDT})

**Note:** To find a single \\ character in a string, the field must look for \\\\ surrounded by single quotes. Example: if(IndexOf('\\\\',...)

### ArrayCount()

The Array Count function expects one argument and returns a count of items found in semi-colon separated list of values, or zero if empty.  
**Syntax:** ArrayCount(array)  
**Example:** ArrayCount({Stratus.Part.TrackingComments})

### ArrayMultiply()

The **ArrayMultiply**() function is used with STRATUS.Ancillary.\* fields for reporting. It returns an array of product results from array1\[0..n\] times array2\[0..n\] in semi-colon separated list of values with provided precision

**Syntax:** ArrayMultiply(array1, array2, precision=0)

**Example:** Field: ArrayMultiply({STRATUS.Ancillary.Quantity},{STRATUS.Ancillary.Length},2)

The STRATUS.Field.Frank Ancillary Part 4 field multiples STRATUS.Ancillary.Quantity x STRATUS.Ancillary.Length and results in the following:

### ValueAtIndex()

The Value At Index function expects two arguments and returns the value from the array at 1-based index, otherwise empty result.  
**Syntax:** ValueAtIndex(array, index)  
**Example:** ValueAtIndex({Stratus.Part.TrackingComments},ArrayCount({Stratus.Part.TrackingComments}))

### MostCommon()

MostCommon(array, \[optional\] ignoreEmpty=true) which takes a list of numeric semicolon-separated values and returns the the most common value with the option to ignore empty values. The MostCommon function displays the most common value from child parts.

**Syntax**: MostCommon(array, \[optional\] ignoreEmpty=true) expects 1 or 2 arguments and returns the most common value found in semicolon separated array of values with option to ignore empty values

**Example**: MostCommon({ServiceAbbreviation}) returns the most common "ServiceAbbreviation" value in the array.

In this example, ServiceAbbreviation is setup as the 'Array’ data type which this means it is intended to process each part and return a value for each one in a list. As a result, the expression specified is going to operate within the context of each part, meaning it is going to say, give me the most common value from part 1, then the most common value from part 2, etc., and combine the results in a semi-colon separated list. When using the ‘Array’ data type and wanting to get a MostCommon() value from the resulting list, you must create a second field that is a string data type and operates on the first field’s resulting array list that will work and give the desired result of the single most common value from the array list of values

### UniqueValues()

UniqueValues(array) expects one argument as a semicolon-separated list of values and returns a semicolon-separated list of each unique value from the original list. An optional second argument can be passed to the function as true if you want the quantity displayed in front of each unique value in the result.

**Example** 1: If listOfValues is: 3.1;3.1;4.2;4.2;4.2;5.3;5.3;5.3;5.3

UniqueValues(listOfValues) will return: 3.1;4.2;5.3

**Example 2 optional second argument:** In the example below, the Parts Description List field results in the description of each part and the UniqueValues() function is applied to it.

![](blob:https://gtpservices.atlassian.net/cb7ec65b-d57f-4e7e-b3b0-51c05d8adb07)

**Results**

### Sum()

Sum(array) which takes a list of semicolon-separated values and returns the sum.

**Syntax**: Sum(array) will total the list of semicolon-separated values

**Example**: Sum(If({Stratus.Part.TrackingStatusIndex}>4{Weight},0))Sum({Weight})\*100

### Average()

Average(array) which takes a list of numeric values and returns the average value.

### Maximum()

Maximum(array) which takes a list of values and returns the maximum numeric value or zero.

### Minimum()

Minimum(array) which takes a list of values and returns the minimum numeric value or zero.

### Round()

The ROUND(<expression>, \[rounding multiple\],\[direction\]) function can be used in formulas for calculated fields. The direction parameter is optional and enables you to force rounding either “UP” or “DOWN” (or “NEAREST”, which is the optional default value).  How you spell ROUND and Field Functions is case insensitive. Precision defaults to 1.

-   **Value** can be a variable such as {CutLength}
    
-   **Precision** is the decimal increment to round to.
    

**Examples**:

-   round({Total Cost}), round({Total Cost},1), round({Total Cost},1,"NEAREST"), and round({Total Cost},,”NEAREST”) yield identical results, rounding to the nearest integer:
    
    -   round(42.35) will result in 42 and round(42.55) will result in 43;
        
-   round({Total Cost},2,"NEAREST") or round({Total Cost},2) will round to the nearest even number:
    
    -   round(43.21,2) will result in 44 ;
        
    -   round(42.75, 2) will result in 42;
        
-   round({Total Cost},2,”UP”) will always round up:
    
    -   round(43.21,2) will result in 44 ;
        
    -   round(42.75, 2) will result in 44;
        
-   round({Total Cost},2,”DOWN”) will always round down:
    
    -   round(43.21,2) will result in 42 ;
        
    -   round(42.75, 2) will result in 42;
        

**Precision Examples:**

Precision can also be a decimal number.

-   round({Total Cost},0.25) will round to the nearest .25, thus:
    
    -   round(22.22,0.25) results in 22.25;
        
    -   round(14.86, 0.25) results in 14.75;
        
-   round({Total Cost},0.25,”UP”) will round up to the next .25, thus:
    
    -   round(315.12,0.25,”UP”) results in 315.25;
        
-   round({Total Cost},0.25,”DOWN”) will round down to the closest .25, thus:
    
    -   round(315.12,0.25,”DOWN”) results in 315.00;
        

You can include a Stratus Field in a report and you can control the display precision within the report definition. An example of a Field For example Round({Total Cost},2)

### Absolute Function Abs()

The Absolute Function Abs() will calculate the absolute value of a number. One use for the Abs() is that displaying a center line offset would result in negative number that could be displayed as a positive number instead.

**Below is example displaying a difference between dates:**

1.  The field below calculates the number of days between a Required Date and the Current Date and results in a negative number.
    
    **Days({Stratus.Package.RequiredDT},{Stratus.Report.CurrentDate})**
    
    ![](blob:https://gtpservices.atlassian.net/fe73873a-6acd-4e58-9564-dd92da9310d4)
    
2.  Adding the Abs () function to this field results in the absolute value of the calculation.  
    **ABS(Days({Stratus.Package.RequiredDT},{Stratus.Report.CurrentDate}))**
    
    ![](blob:https://gtpservices.atlassian.net/c27df28b-a65f-40d1-bdab-ffeb1c16ecfa)
    

### Split() Function and Fixed Len() 

The Split() Function and Len() function.

**Len Example should return ‘2-3-4-5’:**

Right('1-2-3-4-5',Len('1-2-3-4-5')-2)

**Split example should return ‘1;2;3;4;5’:**

Split('1-2-3-4-5','-')

### AsFeetInch() Function - Expression

The AsFeetInch() function provides the ability to format decimal dimension values as feet-inch for display purposes in field expressions. This is useful when you want to format a value that does not use the Report Engine Display Format value, like a bottom of pipe calculation on a sticker, for example, which uses the raw Storage Format value.

**Below is an example of AsFeetInch():**

**Generic Syntax:** AsFeetInch(Feet, Precision (optional, defaults to 8), Format (optional, defaults to 0, 0=feet-inch-fraction, 1=inches-fraction))

**This example will return a formatted string with the feet, precision of 2, as feet-inch fraction:**  
AsFeetInch(Stratus.Field.GTP Linear Feet,2,0)

**Field Configuration:**

**Report Property Configuration Example:**

**Packages Dashboard Report Example:**

### AsFeetInch() Function - Leading Zero

If your company uses AsFeetInch, it was configured as an Expression in a Field. A new optional parameter has been added to the AsFeetInch which can be set to manage the Leading Zero. As a result, the Leading Zero setting under Admin > Company > Settings is ignored.

Below is an example before the new optional leading parameter was available:  
AsFeetInch({Stratus.Field.GTP Linear Feet},4,0)

Below is an example of using the new optional Leading Zero parameter at the end of the expression:

**Syntax:** AsFeetInch(Feet, Precision (optional, defaults to 8), Format (optional, defaults to 0, 0=feet-inch-fraction, 1=inches-fraction), Leading 0’s)

Leading 0’s Optional Settings:

-   Default = 3
    
-   0 = Leading Zero = Feet And Inches; Ex. **AsFeetInch**({**Stratus.Field.GTP Linear Feet**}**,**4**,**0**,**0)
    
-   1 = Leading Zero = Inches; Ex. **AsFeetInch**({**Stratus.Field.GTP Linear Feet**}**,**4**,**0**,**1)
    
-   2 = Leading Zero = Feet; Ex. **AsFeetInch**({**Stratus.Field.GTP Linear Feet**}**,**4**,**0**,**2
    
-   3 = Leading Zero = None; Ex. **AsFeetInch**({**Stratus.Field.GTP Linear Feet**}**,**4**,**0**,**3)
    

Below is an example to display the AsFeetInch expression with the default (3) no leading 0’s:

AsFeetInch({Stratus.Field.GTP Linear Feet},4,0,3)

### AsMetric() Function - Expression

The AsMetric() expression allows caller to convert a numeric value from feet units to metric mm, cm, or m units and also control the number of decimal places displayed in the resulting string.

**Syntax**:

AsMetric({PropertyName}, ‘mm’, 0)

This would convert units to mm and output numeric value with zero decimal places shown.

AsMetric() expects one, two, three, or four arguments:

-   Feet (decimal value from property for calculation)
    
-   Precision (optional number of decimal places, defaults to 0)
    
-   Format (optional, defaults to 0, where 0=mm, 1=cm, 2=m)
    
-   Display Units (optional, defaults to 0, 0=OFF, 1=ON)
    

These arguments return a formatted string result. Examples:  
AsMetric({Length})

AsMetric({Length},2)

AsMetric({Length},2,2)

where the 2nd and 3rd arguments are optional as specified above.

**Trigonometry Functions Syntax**:

The following Trigonometry Functions can be used:

sin, cos, tan, atan, atan2, asin, acos, cot, sec, csc

Most take (value, units as 0=radians (default) or 1=degrees)

atan2 takes (y, x, units (optional))

### Replace() Function

The Replace() expression function can be used to replace one string with another string.

**Syntax:** Replace(inputstring, stringtoreplace, replacewithstring)

-   **inputstring**\- A original list of values.
    
-   **stringtoreplace** \- The string to be replaced.
    
-   **replacewithstring** \- The string to replace with.
    

**Example:** **Replace({Stratus.Part.HoleInfo},";","\\\\&")**

### FilterArray() Function

The FilterArray() expression function can be used to filter results in or out. This could be used, for example, to filter results on the Packages Dashboard.

**Syntax:** FilterArray(inputArray, arrayOfItemsToFilter, boolFilterInclude)

-   **inputArray** \- A semicolon separated list of values to filter
    
-   **arrayOfItemsToFilter** \- A semicolon separated list of values to filter
    
-   **boolFilterInclude** \- The optional third argument, defaulted to false where the arrayOfItemsToFilter are removed, is true if the results should include only the arrayOfItemsToFilter values.
    

**Case 1:** FilterArray({Stratus.Field.Array Example Array Creation},"Filter this text out", false)

**Case 2:** FilterArray({Stratus.Field.Array Example Remove Blanks Case 1},"", false)

**Case 3:** FilterArray({Stratus.Field.Array Example Array Creation},"Filter this text out", false)

### Add New Line \\n

An expression can include new line syntax ”\\n- " that can be used to place data results of each record on a separate line.

Below is an example where ”\\n- " was used.

Syntax: “- " + Replace({STRATUS.Field.asm\_TimeLogArray},”;“,”\\n- ")

Results:

## Added Field Expression to Return an Assembly’s First Non-empty Value from Child Parts

Added the ability to create a Field and a Field Expression where **Is Total** is enabled and **Data Type** is String (non-numeric) which will evaluate each Assembly and return the first non-empty value from its child parts. For example:

1.  Field setup includes:
    
    1.  **Data Type** = String
        
    2.  **Is Expression** = Checked
        
    3.  **Is Total** = Checked
        
2.  Report setup includes:
    
    1.  **Item Type** \= Package Details or Assembly
        
    2.  **Report Field** - Add the field to the report.
        
3.  Run the report. It will return the value for each assembly row.
    

## Checkbox

A checkbox field can be used on a Packages Dashboard report.

**Here’s how to configure the checkbox field:**

1.  Configure a Field where:
    
    1.  **Data Type – The following data types can be defined.** Note: Selecting the correct Data Type is directly related to whether or not your Field will function properly.
        
        1.  **String** – Works with Alphanumeric characters and for the results of a concatenated field. See the Concatenated Field example below.
            
        2.  **Integer** \- Used to calculate Numbers or set a Boolean checkbox.
            
            1.  **Boolean** - A Boolean checkbox must have the following:
                
                1.  **Data Type**: Integer or String
                    
                2.  **Default Value**: 
                    
                    1.  **Integer**: 1 = Checked checkbox, or, 0 = Unchecked checkbox
                        
                    2.  **String**: true = Checked checkbox, or, false = Unchecked checkbox
                        
                3.  **Is Editable**: Checked
                    
                4.  **Possible Values**: Not Used  
                    
                5.  Example of all Boolean Field options:
                    
                6.  Example of all Boolean Field option results:
                    

## Hide Value when Expression is not met

If you have a report, like a length report, that displays all length values, you might want to hide values that don't meet criteria or result "0". For example:

1.  A field can configured to display all lengths (Length All Column in step #3):
    
2.  Or, a field can be configured to display lengths that meet criteria or display blank if the result is "0" (Length NA Column in step #3). **Note:** To display blank if the result is "0", the NA syntax must be exact i.e.    if({CID}=2041, {Length}, NA)
    
3.  Compare the results below:
    

## Use Tracking Status Index Number

A Tracking Status Index number corresponds to the Tracking Status sequence number. This Tracking Status Index number can be used in Reports and Field Expressions that want to compare tracking statuses using greater than or less than nomenclature. An example of a Field Expression:

1.  Determine the Tracking Status Index Number on the Admin > Company > Tracking Status > Sequence column. **Note**: The sequence number can be edited which would impact any Field Expressions you might have created.
    
2.   Create a **Field Expression** that uses the Tracking Status Index number {Stratus.\*.TrackingStatusIndex}.
    
3.  Add the Field Expression to a Report.
    
4.  Run the report. In this case, it is a Packages Dashboard report.  
    
    ![](blob:https://gtpservices.atlassian.net/22335929-236d-46c7-9045-0ea748757a5c)
    

## Square Root

Example

36**^**(1**/**2)

This will return 6, similarly substituting 25 instead of 36 will return 5.

## SIMPLE IF STATEMENTS

if({CID}=2041, {Length}, NA)

If({CID}='2522' And {Install Type}="Welded", 1, 0)

If({CID}='838', 'All Thread Rod', {Item Description})

If(CreateDate(1900,1,1) > {Stratus.Package.RequiredDT}, 0, {Stratus.Package.RequiredDT}-{Stratus.Field.GTP Fabrication Lead Time})

if({Size}='1/2"ø-1/2"ø', '1/2"ø',  
if({Size}='3/4"ø-3/4"ø', '3/4"ø',  
if({Size}='1"ø-1"ø', '1"ø',  
if({Size}='1 1/4"ø-1 1/4"ø', '1 1/4"ø',  
if({Size}='1 1/2"ø-1 1/2"ø', '1 1/2"ø',  
if({Size}='2"ø-2"ø', '2"ø',  
if({Size}='2 1/2"ø-2 1/2"ø', '2 1/2"ø',  
if({Size}='3"ø-3"ø', '3"ø',  
if({Size}='4"ø-4"ø', '4"ø',  
if({Size}='6"ø-6"ø', '6"ø',  
if({Size}='8"ø-8"ø', '8"ø',  
{Size})))))))))))

If({Stratus.Part.TrackingStatusIndex}>10,{Installation Cost}\*{Stratus.Field.GTP Fabrication Labor Factor},0)

OR

If({Stratus.Part.TrackingStatusIndex}=10,({Installation Hours}\*{Stratus.Field.GTP Fabrication Labor Factor}\*.15),  
If({Stratus.Part.TrackingStatusIndex}=11,({Installation Hours}\*{Stratus.Field.GTP Fabrication Labor Factor}\*.6),  
If({Stratus.Part.TrackingStatusIndex}=12,({Installation Hours}\*{Stratus.Field.GTP Fabrication Labor Factor}\*.5),  
If({Stratus.Part.TrackingStatusIndex}=13,({Installation Hours}\*{Stratus.Field.GTP Fabrication Labor Factor}\*.8),  
If({Stratus.Part.TrackingStatusIndex}=14,({Installation Hours}\*{Stratus.Field.GTP Fabrication Labor Factor}\*.9),  
If({Stratus.Part.TrackingStatusIndex}=15,({Installation Hours}\*{Stratus.Field.GTP Fabrication Labor Factor}\*.95),  
If({Stratus.Part.TrackingStatusIndex}=16,({Installation Hours}\*{Stratus.Field.GTP Fabrication Labor Factor}\*.95),  
If({Stratus.Part.TrackingStatusIndex}>16,({Installation Hours}\*{Stratus.Field.GTP Fabrication Labor Factor}\*1),  
0))))))))

If({ALL THREAD TYPE}= '3/8"', '(2) 3/8" Washers',  
If({ALL THREAD TYPE}= '1/2"', '(2) 1/2" Washers',  
If({ALL THREAD TYPE}= '5/8"', '(2) 5/8" Washers',  
If({ALL THREAD TYPE}= '3/4"', '(2) 3/4" Washers',  
'No Washers'))))

if({Stratus.Part.CadType}="Autodesk.Revit.DB.FabricationPart", AsNumber{Stratus.Part.CutLengthAdjustment}\*.0833,if({Stratus.Part.CadType}="Autodesk.Fabrication.Item", AsNumber{Stratus.Part.CutLengthAdjustment}))

if({Hole Side #4}='Front',"Left",if({Hole Side #4}='Back',"Right"),"None")

## TREATING PARAMETERS AS NUMBERS

AsNumber({Stratus.Part.Point.AFF})-{Diameter}\*0.5

## ISBLANK

IsBlank should be used in place of equals to a set of double quotes. This is especially useful for ITM parts when you want to utilize the “Product xxx” Properties in Stratus but some of your parts are missing the data. 

**Before:**  
If({Product Size}= "",{Size},{Product Size})

**After:**  
If(isBlank({Product Size}),{Size},{Product Size})

  
Alternatively you can add the “Not” function before the isblank(). This usage is less common but it will provide the inverse effect so if that property does have data the true result will be returned.

**Example:**  
If(Not(isBlank({Product Size})),{Product Size},{Size})

## PASS THROUGH FIELDS

{Installation Cost}

## SIMPLE CONCANTENATED FIELDS

{C1}+" x "+{C2}

## "POLISHING FIELD" AND CONCANTENATED

if({CID}='2041', {Stratus.Field.GTP C1}+" x "+{Stratus.Field.GTP C2}, " ")

if({C1}="Grooved End", 'GRV',  
if({C1}="Copper Ftg", 'PE',  
if({C1}="Bevel End 37.5", 'BEV',  
if({C1}="NoHub", 'PE',  
{C1}))))

if({C2}="Grooved End", 'GRV',  
if({C2}="Copper Ftg", 'PE',  
if({C2}="Bevel End 37.5", 'BEV',  
if({C2}="NoHub", 'PE',  
{C2}))))

if({CID}='2041', {Item Description}+" "+"("+{Stratus.Field.GTP End Prep}+")", {Item Description})

If({Length A}>0 and {Length A}<24, 24,  
If({Length A}>24 and {Length A}<48, 48,  
If({Length A}>48 and {Length A}<72, 72,  
If({Length A}>72 and {Length A}<96, 96,  
If({Length A}>84 and {Length A}<120, 120,  
If({Length A}>120 and {Length A}<144, 144,  
If({Length A}>120 and {Length A}<144, 144,  
{Length A}))))))

## MATERIAL TRANSLATION

if({Material}="A53", 'Carbon Steel',  
if({Material}="A53 Double Radom", 'Carbon Steel',  
if({Material}="Carbon Steel", 'Carbon Steel',  
if({Material}="Cast Iron", 'Carbon Steel',  
if({Material}="Ductile Iron", 'Carbon Steel',  
if({Material}="Forged Steel", 'Carbon Steel',  
if({Material}="Malleable Iron", 'Carbon Steel',  
if({Material}="Brass", 'Copper',  
if({Material}="Bronze", 'Copper',  
if({Material}="Hard Copper", 'Copper',  
if({Material}="Lead Free Brass", 'Copper',  
if({Material}="Sch 80 PVC", 'PVC',  
if({Material}="None", 'Defined As None',  
if({Material}="Undefined", 'Defined As None',  
if({Material}="Galvanized Carbon Steel", 'Galvanized Carbon Steel',  
if({Material}="Structural Carbon Steel", 'Structural Steel',  
if({Material}="ACR Hard Copper", 'Copper',  
if({Material}="ACR Soft Copper", 'Copper',  
if({Material}="A53\_21", 'Carbon Steel',  
if({Material}="A53 TOE Nipple", 'Carbon Steel',  
if({Material}="304L Stainless Steel", 'Stainless Steel',  
if({Material}="304 Stainless Steel", 'Stainless Steel',  
if({Material}="No Hub Cast Iron", 'Cast Iron',  
if({Material}="PVC", 'PVC',  
if({Material}="CPVC", 'PVC',  
'No Material Defined')))))))))))))))))))))))))

## JOINT METHOD

if({C1}="BE", 'Welded',  
if({C1}="150 FF Flange", 'Flanged',  
if({C1}="MPT", 'Threaded',  
if({C1}="HexEnd FPT", 'Threaded',  
if({C1}="Copp MPT", 'Threaded',  
if({C2}="BW", 'Welded',  
if({C2}="BE", 'Welded',  
if({C2}="SS BE", 'Welded',  
if({C2}="SW", 'Socket Weld',  
if({C2}="WS", 'Socket Weld',  
if({C2}="GE", 'Grooved',  
if({C2}="Vic 77 Coupling", 'Grooved',  
if({C2}="Vic 07 Coupling", 'Grooved',  
if({C2}="741 Flange Washer RF", 'Grooved',  
if({C2}="150 FF Flange", 'Flanged',  
if({C2}="150 RF Flange", 'Flanged',  
if({C2}="150 RF Lug Patt", 'Flanged',  
if({C2}="300 FF Flange", 'Flanged',  
if({C2}="Blind", 'Flanged',  
if({C2}="Copp FPT", 'Threaded',  
if({C2}="Copp MPT", 'Threaded',  
if({C2}="FPT", 'Threaded',  
if({C2}="FPT Bushing", 'Threaded',  
if({C2}="HexEnd FPT", 'Threaded',  
if({C1}="MPT", 'Threaded',  
if({C2}="MPT", 'Threaded',  
if({C2}="MPT Joint", 'Threaded',  
if({C2}="Thermowell FPT", 'Threaded',  
if({C2}="Copp SC", 'Sweat',  
if({C2}="Copper Ftg", 'Sweat',  
if({C2}="Copper Solder Cup", 'Sweat',  
if({C2}="OD Copp SC", 'Sweat',  
if({CID}="2875", 'Welded',  
if({C2}="NoHub", 'No Hub',  
if({C2}="DWV Copp Ftg", 'Sweat',  
if({C2}="Sch40 DWV PVC Plain", 'Solvent',  
'No Joint Defined'))))))))))))))))))))))))))))))))))))

## MATERIAL COST

**Carbon Steel BW**  
if(({Stratus.Field.00GTP Material Translation}="Carbon Steel") And ({Stratus.Field.00GTP Joint Method}="Welded"), {Installation Cost}, 0)

**Carbon Steel FLG**  
if(({Stratus.Field.00GTP Material Translation}="Carbon Steel") And ({Stratus.Field.00GTP Joint Method}="Flanged"), {Installation Cost}, 0)

**Carbon Steel GRV**  
if(({Stratus.Field.00GTP Material Translation}="Carbon Steel") And ({Stratus.Field.00GTP Joint Method}="Grooved"), {Installation Cost}, 0)

**Carbon Steel THD**  
if(({Stratus.Field.00GTP Material Translation}="Carbon Steel") And ({Stratus.Field.00GTP Joint Method}="Threaded"), {Installation Cost}, 0)

**Carbon Steel SW**  
if(({Stratus.Field.00GTP Material Translation}="Carbon Steel") And ({Stratus.Field.00GTP Joint Method}="Socket Weld"), {Installation Cost}, 0)

**Copper SWT**  
if(({Stratus.Field.00GTP Material Translation}="Copper") And ({Stratus.Field.00GTP Joint Method}="Sweat"), {Installation Cost}, 0)

**Copper THD**  
if(({Stratus.Field.00GTP Material Translation}="Copper") And ({Stratus.Field.00GTP Joint Method}="Threaded"), {Installation Cost}, 0)

**Copper Press**  
if(({Stratus.Field.00GTP Material Translation}="Copper") And ({Stratus.Field.00GTP Joint Method}="Press"), {Installation Cost}, 0)

**Copper Grooved**  
if(({Stratus.Field.00GTP Material Translation}="Copper") And ({Stratus.Field.00GTP Joint Method}="Grooved"), {Installation Cost}, 0)

**Stainless Steel BW**  
if(({Stratus.Field.00GTP Material Translation}="Stainless Steel") And ({Stratus.Field.00GTP Joint Method}="Welded"), {Installation Cost}, 0)

**Cast Iron No Hub**  
if(({Stratus.Field.00GTP Material Translation}="Cast Iron") And ({Stratus.Field.00GTP Joint Method}="No Hub"), {Installation Cost}, 0)

**PVC Solvent Weld**  
if(({Stratus.Field.00GTP Material Translation}="PVC") And ({Stratus.Field.00GTP Joint Method}="Solvent"), {Installation Cost}, 0)

**PVC Flanged**  
if(({Stratus.Field.00GTP Material Translation}="PVC") And ({Stratus.Field.00GTP Joint Method}="Flanged"), {Installation Cost}, 0)

## HTML IN FIELDS (NOT SUPPORTED!)

If({Stratus.Field.PMC Projected Hours}>{Stratus.Field.PMC Labor},'<span class="glyphicon glyphicon-exclamation-sign"> </span><span style="background-color:red;color:white;font-weight:bold;">Projected Overrun</span><span class="glyphicon glyphicon-exclamation-sign">', 'Project On Target')

## Field Syntax Errors

## Different types encountered within the same operation

The Different types encountered within the same operation error indicates that a field is being read as a number value instead of a text value.  A quick fix is to use the Text() function to make sure the field is being treated as text.  For example, if the field values were {C1} and {Fabrication Notes}, try replacing them as Text({C1}) and Text({Fabrication Notes}) in the expression.

## Videos

## 08/19/2024 - Stratus Academy: ADM-505: Admin 2 - Fields

To take the Fields course, login to [**Stratus Academy**](https://academy.stratus.build/ "https://academy.stratus.build/") and and locate the course **ADM-505: Admin 2 - Fields**.

## 12/03/2020 - Leveraging your data with Fields

<iframe allowfullscreen="" allowtransparency="true" data-hasbody="false" data-layout="default" data-local-id="21fed2bd-2304-4117-a5e2-92eed5cdc3de" data-macro-id="4ea77eab-9d70-4a56-964b-4677827c1047" data-macro-name="widget" frameborder="0" height="364" mozallowfullscreen="" src="https://player.vimeo.com/video/487375275?h=embed" webkitallowfullscreen="" width="640"></iframe>

## 04/30/2020 Implementation Webinar - Using Fields in Stratus

<iframe allowfullscreen="" allowtransparency="true" data-hasbody="false" data-layout="default" data-local-id="2f2c946d-849a-4e89-b875-bca6e9c2c14f" data-macro-id="ce5525f0-9b0a-4211-88cf-ba9825253bd9" data-macro-name="widget" frameborder="0" height="364" mozallowfullscreen="" src="https://player.vimeo.com/video/414023974?h=embed" webkitallowfullscreen="" width="640"></iframe>

## 04/25/2019 Implementation Webinar - Write Field Expressions and Calculated Fields 

<iframe allowfullscreen="" allowtransparency="true" data-hasbody="false" data-layout="default" data-local-id="684818ce-cae0-44df-bea6-d942f2d63c3e" data-macro-id="6728378a-4f3c-4d8b-b38d-cebe4e1b60b7" data-macro-name="widget" frameborder="0" height="364" mozallowfullscreen="" src="https://player.vimeo.com/video/332685526?h=embed" webkitallowfullscreen="" width="640"></iframe>
---
created: 2025-06-25T06:27:04 (UTC -04:00)
tags: []
source: https://gtpservices.atlassian.net/wiki/spaces/SK/pages/10617224/Filters+Admin
author: 
---

# Filters (Admin) - STRATUS Knowledge Base - Confluence

> ## Excerpt
> A filter is a way to create complex, nested rules based on part properties and is used to group parts that meet the filter criteria.  A rule is defined by looking at a part that you want to be included in a filter or report and then identifying unique property values that will result in a filtered grouping.  Filters can be used in the Model viewer under Company to filter parts displayed or in defined reports.

---
A filter is a way to create complex, nested rules based on part properties and is used to group parts that meet the filter criteria.  A rule is defined by looking at a part that you want to be included in a filter or report and then identifying unique property values that will result in a filtered grouping.  Filters can be used in the Model viewer under Company to filter parts displayed **or** in defined reports.

-   1 [Configuration](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/10617224/Filters+Admin#Configuration)
    -   1.1 [New Filter](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/10617224/Filters+Admin#New-Filter)
        -   1.1.1 [Rules Conditions](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/10617224/Filters+Admin#Rules-Conditions)
    -   1.2 [Clone (Copy) Filters](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/10617224/Filters+Admin#Clone-(Copy)-Filters)
    -   1.3 [Categorize Filters](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/10617224/Filters+Admin#Categorize-Filters)
    -   1.4 [Fabrication Parts Ancillary Filter for Reports](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/10617224/Filters+Admin#Fabrication-Parts-Ancillary-Filter-for-Reports)
    -   1.5 [How to Exclude Parts from Filters and Use Sub Groups](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/10617224/Filters+Admin#How-to-Exclude-Parts-from-Filters-and-Use-Sub-Groups)
-   2 [Videos](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/10617224/Filters+Admin#Videos)
    -   2.1 [08/19/2024 - Stratus Academy: ADM-502: Admin 1 - Filters and Grouping](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/10617224/Filters+Admin#08%2F19%2F2024---Stratus-Academy%3A-ADM-502%3A-Admin-1---Filters-and-Grouping)
    -   2.2 [04/09/21 CSG Webinar: Advanced Filtering](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/10617224/Filters+Admin#04%2F09%2F21-CSG-Webinar%3A-Advanced-Filtering)
    -   2.3 [03/25/2021 CSG Webinar: Leveraging Groupings In Your Filters](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/10617224/Filters+Admin#03%2F25%2F2021-CSG-Webinar%3A-Leveraging-Groupings-In-Your-Filters)
    -   2.4 [05-28-2020 Implementation Webinar - Advanced Filtering (29:50)](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/10617224/Filters+Admin#05-28-2020-Implementation-Webinar---Advanced-Filtering-(29%3A50))
    -   2.5 [04-18-2019 Implementation Webinar - Filters and Grouping (22:12)](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/10617224/Filters+Admin#04-18-2019-Implementation-Webinar---Filters-and-Grouping-(22%3A12))

## Configuration

## New Filter

To create a new filter:

1.  On the Admin > Company > Filters page, click the **New Filter** button. A new row will display highlighted in yellow.
    
    1.  **Name** - The name of the filter. 
        
        1.  If the Model Viewer checkbox is checked, the Filter Name will display in the list of Company filters.
            
        2.  If the Model Viewer checkbox is not checked, the Filter Name will display in drop-down lists that filter data.
            
    2.  **Category** - Enter a Category to categorize filters within the Filters dialog. If you want more than one filter in a Category, copy the Category name from one filter and paste into the Category field of the other filter.
        
    3.  **Model Viewer**
        
        1.  **If Model Viewer is checked**, the Filter Name will display in the list of Company filters.
            
        2.  **If Model Viewer is checked and a Category is entered**, the filter will display under the Category under Model Viewer > Filters.
            
        3.  **If Model Viewer is checked and Category is Empty,** the filter will display in the **Default** Category under Model Viewer > Filters.
            
        4.  **If Model Viewer is not checked**, the filter will only be available in drop-down lists that filter data like Task Workflows.
            
        5.  **If Model Viewer is checked, and if a Category is entered, and if a Grouping is selected**, the filter will display under the Category under and the items will be grouped as defined under the Filter. See the [**Groupings (Admin)**](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/217907389 "https://gtpservices.atlassian.net/wiki/spaces/SK/pages/217907389") article for more information.
            
    4.  **Grouping** - Displays the Groupings entered under Admin > Company > Groupings. For example: 
        
    5.  **References** -  Helps administrators understand where the filters are being referenced. Click the references number to display the references (Type and Name).  
        
        ![](blob:https://gtpservices.atlassian.net/fa0b08d7-f389-4b4d-8451-c0169ccc8f8d)
        
    6.  **Notes** - A note about the filter.
        
2.  Click **Save**.
    
3.  Once the filter is saved, expand the filter to add groups and rules.
    
4.  When adding a **Rule**, decide whether **All** (default) rules must be applied to get results, or, if **Any** of the rules can be applied to get results.
    
5.  Click the **Rule** button. A row will display to define the rule.
    
6.  Click the **Property** field to select any field from your database. **Note**: Any model published to your company will populate the fields available in the Property drop-down. You can type or copy/paste the field name to locate it in the list.
    
7.  Next, select a **Rule**.
    
8.  Then, enter a Value. **Note**: To determine specific values, you can select the part in one of the Stratus viewers, click the Properties tool, and then lookup the value for the property.
    
9.  Add more rules as needed. 
    
    1.  **Note**: Possible Values will not display unless the Populate Possible Values button is clicked. By design, this feature does not support multiple rule select.
        
10.  Once done, look for the filter as described above depending on if Models Viewer is checked, a Category was entered, or a Grouping was selected.
    

### Rules Conditions

Most rule conditions are self-explanatory and the Case Sensitive checkbox can be applied to any. 

![](blob:https://gtpservices.atlassian.net/6343fd3d-0123-47f8-a6d6-a098dbc6806f)

**Regex Note**:  See [https://regex101.com/](https://regex101.com/ "https://regex101.com/") for more information about regex to apply to the **DoesNotRegexMatch** and **RegexMatch** conditions.

## Clone (Copy) Filters

To clone a filter:

1.  On the Admin > Filters button, click the clone button associated with the filter you want to clone.
    
2.  The cloned report will display and will include an incremented number after the name.
    

## Categorize Filters

Categorize and target filters as follows:

1.  Enter a Category name. Then you can sort filters.
    
2.  You can now target a filter for the **Models > Viewer page** which will enable you to distinguish model viewer filters from other report filters.
    
3.  To target a filter for the Models > Viewer page, under **Admin** > **Company** > **Filters**, check the **Model Viewer checkbox** associated with the filter. This checkbox is checked by default.
    
4.  On the **Models** > **Viewer** page under **Filters** > **Company**, you can view filters targeted for this page.
    

## Fabrication Parts Ancillary Filter for Reports

Create a filter on Ancillary Usage to create reports for Connectors, Airturns, Splitters, etc.  Filters are only implemented for “Type” and “Usage”.

Usage can be any of the following:

-   Airturn
    
-   Connector
    
-   Hanger
    
-   Loose
    
-   Seam
    
-   Splitter
    
-   Stiffener
    

If you want a report that filters for Connector ancillary data you would use the Ancillary. Usage contains “Connector”. This would filter out all the Airturn, Hanger, Splitter information and leave Clips, Corners, Ancillary Material, Gasket for the connectors.

Type can be any of the following:

-   AirturnTrack
    
-   AirturnVane
    
-   AncillaryMaterial
    
-   Clip
    
-   Corner
    
-   Fixing
    
-   Gasket
    
-   Isolator
    
-   Sealant
    
-   SeamMaterial
    
-   SupportRod
    
-   TieRod
    
-   SupportSeismic
    
-   Unknown
    

If you want a report containing just the Gasket, you can filter on:  
Ancillary.Type contains “Gasket”

## How to Exclude Parts from Filters and Use Sub Groups

To create a Filter that will exclude specific parts you can use a Sub Group set to **All** and list your **DoesNot** xxx rules. The important thing to remember when using a Filter in this manner is that Filters are always looking for a "True" condition even when using a "DoesNotEqual". What this means is that when you are trying to use multiple **DoesNotEqual** Rules to remove a part, it is counter intuitive compared to how an **Equal** Rule would work. Use the **All** Group Condition instead of **Any** like you would for an inclusion rule.

In the Filter below:

The rules under the Any Condition add parts that are ITM pipework in Revit and RFA content in Revit,

The rules under the All Condition exclude Welds and joints that are ITM or RFA,

As a result, in the model below shows only the pipe and fittings and the welds and joints are removed.

**Recommendation**: With the behavior described above, we recommend using at least one **Sub Group** when creating a new Filter so that in the future, when you need to remove parts from an existing Filter, you do need to rework the current rules to make a new Sub Group work.

## Videos

## 08/19/2024 - Stratus Academy: ADM-502: Admin 1 - Filters and Grouping

To take the Filters and Grouping course, login to [**Stratus Academy**](https://academy.stratus.build/ "https://academy.stratus.build/") and and locate the course **ADM-502: Admin 1 - Filters and Grouping**.

## **04/09/21 CSG Webinar: Advanced Filtering**

<iframe allowfullscreen="" allowtransparency="true" data-hasbody="false" data-layout="default" data-local-id="0320a069-bce6-435f-8e04-d9a320f47f0c" data-macro-id="ba8d07a8-f304-40b5-a131-c15fe1b138e3" data-macro-name="widget" frameborder="0" height="364" mozallowfullscreen="" webkitallowfullscreen="" width="640" src="https://player.vimeo.com/video/536365508?h=embed"></iframe>

00:00 Release Notes Review  
06:40 Filters vs. Groupings  
11:00 Project Data Fixer Filter  
13:30 Filters with Model Viewer Checked  
16:30 Filter Conditions for Mains and Olets

## **03/25/2021 CSG Webinar: Leveraging Groupings In Your Filters**

<iframe allowfullscreen="" allowtransparency="true" data-hasbody="false" data-layout="default" data-local-id="121f14b2-f5a7-475e-abb4-1b9caa0f1b55" data-macro-id="a2cfa2bb-2e75-4d55-9090-20ca39327a7d" data-macro-name="widget" frameborder="0" height="364" mozallowfullscreen="" webkitallowfullscreen="" width="640" src="https://player.vimeo.com/video/530482108?h=embed"></iframe>

00:00 Release Notes Review  
05:40 Groupings Are Applied to Filters  
07:30 Project Fixer Filters  
18:40 Apply Grouping to Filters used in the Models Viewer  
20:00 Grouping Examples

## **05-28-2020 Implementation Webinar - Advanced Filtering (29:50)**

02:00 Overview  
03:00 Groupings  
04:30 Filter Group Conditions and Choosing the Best Filter Property  
11:00 Alias for Size  
12:00 What Format Is Your Filter Property Stored In?  
17:50 Can an Alias be used to combine fields between AutoCAD and Revit? Yes!  
19:10 On the Filters page, can you specify the difference between the Grouping column and the Conditions?  
21:30 The Grouping "order" does matter  
22:45 Use Service Type, Service, and Source, and Product Description for ITM's  
24:40 Project Browser Filters  
28:30 Deliverable Definitions are based on Filters that automate fabrication package generation

<iframe allowfullscreen="" allowtransparency="true" data-hasbody="false" data-layout="default" data-local-id="81c2c60c-b001-4aad-878c-93ec14895509" data-macro-id="15a04c81-269c-4ace-bd96-dfede1d8568c" data-macro-name="widget" frameborder="0" height="364" mozallowfullscreen="" webkitallowfullscreen="" width="640" src="https://player.vimeo.com/video/424047568?h=embed"></iframe>

## **04-18-2019 Implementation Webinar - Filters and Grouping (22:12)**

0:30 Filters and Groupings Overview  
7:20 Create Filter  
15:30 Run Report with Created Filter  
16:20 Apply Grouping to Filter  
18:55 Hanger and Trapeze Filters

<iframe allowfullscreen="" allowtransparency="true" data-hasbody="false" data-layout="default" data-local-id="7d70ca44-4cae-41fb-ac40-eab6ccbf3c60" data-macro-id="fd6e7e39-c774-41cc-a3b2-d691bd504be0" data-macro-name="widget" frameborder="0" height="364" mozallowfullscreen="" webkitallowfullscreen="" width="640" src="https://player.vimeo.com/video/332704173?h=embed"></iframe>
---
created: 2025-06-25T06:27:04 (UTC -04:00)
tags: []
source: https://gtpservices.atlassian.net/wiki/spaces/SK/pages/217907389/Groupings+Admin
author: 
---

# Groupings (Admin) - STRATUS Knowledge Base - Confluence

> ## Excerpt
> Groupings of part properties can be used by Filters for the model viewer and by reports for generating sub-sections. A Grouping can be configured on any part property including Stratus Fields and Aliases.

---
Groupings of part properties can be used by Filters for the model viewer and by reports for generating sub-sections. A Grouping can be configured on any part property including Stratus Fields and Aliases.

-   1 [Configure](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/217907389/Groupings+Admin#Configure)
-   2 [Examples](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/217907389/Groupings+Admin#Examples)
    -   2.1 [Grouping by Conduit Run ID](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/217907389/Groupings+Admin#Grouping-by-Conduit-Run-ID)
-   3 [Videos](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/217907389/Groupings+Admin#Videos)
    -   3.1 [08/19/2024 - Stratus Academy: ADM-502: Admin 1 - Filters and Grouping](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/217907389/Groupings+Admin#08%2F19%2F2024---Stratus-Academy%3A-ADM-502%3A-Admin-1---Filters-and-Grouping)
    -   3.2 [03/25/2021 - CSG Webinar: Leveraging Groupings In Your Filters](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/217907389/Groupings+Admin#03%2F25%2F2021---CSG-Webinar%3A-Leveraging-Groupings-In-Your-Filters)
    -   3.3 [05/28/2020 Implementation Webinar - Advanced Filtering (29:50)](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/217907389/Groupings+Admin#05%2F28%2F2020-Implementation-Webinar---Advanced-Filtering-(29%3A50))

## Configure

**Example of how groupings can be used:**

**To create a Grouping**:

1.  Under **Admin** > **Company** > **Groupings**, click the **New Grouping** button.
    
    1.  **Name** – Grouping name. This will display on the Filters page.
        
    2.  **Property Names** – A comma-separated list of property names.
        
        1.  It is recommended that you copy/paste property names into this list. Entered Property Names are not validated.
            
        
          
        For example
        
        1.  Part Property Example - Material, Size
            
        2.  Part Property Example - Service Type, Size
            
        3.  Alias Example - Stratus.Alias.Diameter
            
        4.  Filter Example - Stratus.Field.Pipe Length
            
2.  Click **Save**.
    

**To configure the Filter that will use the Grouping:**

1.  Under **Admin** \> **Company** \> **Filters**, either create a new filter or select the Grouping for an existing filter and **Save**.
    
2.  **Expand the Filter** and add a **Rule** where the Property is **Material** and Rule is **Exists**.
    

**To use the Grouping Filter:**

1.  Under the **Models > Viewer > Filters > Company**, select the filter category and then the filter name. The model is filtered by the grouping. Grouping items will use the display format set for the Part Template under Admin > Company > Part Templates > Part selected > Property > Display Format.
    

## Examples

## Grouping by Conduit Run ID

Use this grouping in the same way for dynamic line number isolation.

1.  Configure a Filter similar to this:
    
2.  Configure a Grouping similar to this:
    

## Videos

## 08/19/2024 - Stratus Academy: ADM-502: Admin 1 - Filters and Grouping

To take the Filters and Grouping course, login to [**Stratus Academy**](https://academy.stratus.build/ "https://academy.stratus.build/") and and locate the course **ADM-502: Admin 1 - Filters and Grouping**.

## **03/25/2021 - CSG Webinar: Leveraging Groupings In Your Filters**

<iframe allowfullscreen="" allowtransparency="true" data-hasbody="false" data-layout="default" data-local-id="36e7c58c-c221-4cdd-9d36-7b246c340ebd" data-macro-id="a2cfa2bb-2e75-4d55-9090-20ca39327a7d" data-macro-name="widget" frameborder="0" height="364" mozallowfullscreen="" webkitallowfullscreen="" width="640" src="https://player.vimeo.com/video/530482108?h=embed"></iframe>

00:00 Release Notes Review  
05:40 Groupings Are Applied to Filters  
07:30 Project Fixer Filters  
18:40 Apply Grouping to Filters used in the Models Viewer  
20:00 Grouping Examples

## **05/28/2020 Implementation Webinar - Advanced Filtering (29:50)**

02:00 Overview  
03:00 Groupings  
04:30 Filter Group Conditions and Choosing the Best Filter Property  
11:00 Alias for Size  
12:00 What Format Is Your Filter Property Stored In?  
17:50 Can an Alias be used to combine fields between AutoCAD and Revit? Yes!  
19:10 On the Filters page, can you specify the difference between the Grouping column and the Conditions?  
21:30 The Grouping "order" does matter  
22:45 Use Service Type, Service, and Source, and Product Description for ITM's  
24:40 Project Browser Filters  
28:30 Deliverable Definitions are based on Filters that automate fabrication package generation
---
created: 2025-06-25T06:27:04 (UTC -04:00)
tags: []
source: https://gtpservices.atlassian.net/wiki/spaces/SK/pages/170196993/Import+Mappings+Admin
author: 
---

# Import Mappings (Admin) - STRATUS Knowledge Base - Confluence

> ## Excerpt
> An Import Mapping tells STRATUS where data resides in your Revit part family. STRATUS can pull out custom family data to generate a cut list. For example, for a family like a hanger family, the model will need to include data like the type and length of struts and the type and length of rods. This data will be tied to an ID so that when a cut list is generated and is sent to a tool, the parts will have a data relationship with that tool which means the element knows when it was cut and can update STRATUS tracking statuses. Import Mappings provide a framework to recognize CSV and TXT cut list files.

---
An **Import Mapping** tells STRATUS where data resides in your Revit part family. STRATUS can pull out custom family data to generate a cut list. For example, for a family like a hanger family, the model will need to include data like the type and length of struts and the type and length of rods. This data will be tied to an ID so that when a cut list is generated and is sent to a tool, the parts will have a data relationship with that tool which means the element knows when it was cut and can update STRATUS tracking statuses. Import Mappings provide a framework to recognize CSV and TXT cut list files.

-   1[Create New Import Mapping](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/170196993/Import+Mappings+Admin#ImportMappings(Admin)-CreateNewImportMapping)
-   2[Add Custom Properties to Label](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/170196993/Import+Mappings+Admin#ImportMappings(Admin)-AddCustomPropertiestoLabel)
-   3[Videos](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/170196993/Import+Mappings+Admin#ImportMappings(Admin)-Videos)
    -   3.1[STRATUS 08-29-19 Implementation Webinar - Import Mapping (13:14)](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/170196993/Import+Mappings+Admin#ImportMappings(Admin)-STRATUS08-29-19ImplementationWebinar-ImportMapping(13%3A14))

## Create New Import Mapping

1.  Configure cut list Import Mappings under **Admin** > **Company > Import Mappings**.
2.  Click the **New Import Mapping** button, name it, and then save. The Import Mapping can reference shared families or host families. These are the only fields that can be used on labels generated with the Import Mapping workflow.  
    ![](https://gtpservices.atlassian.net/wiki/download/thumbnails/170196993/image2019-8-29_14-31-10.png?version=1&modificationDate=1567107072030&cacheVersion=1&api=v2&width=845&height=250)
3.  In advance of creating an Importing Mapping, before you can identify fields that will be used in the Import Mapping Fields (above) you'll need to create a report that will contain the fields.
    1.  **Filter** - Before you create a report, you'll want to create a Filter that will isolate the elements. For example, if you are creating a Strut import mapping, you might filter to Trapeze hangers or to channel strut. Either could be used to extract the strut length.  
        ![](https://gtpservices.atlassian.net/wiki/download/thumbnails/170196993/image2019-8-29_14-44-15.png?version=1&modificationDate=1567107857044&cacheVersion=1&api=v2&width=664&height=455)
    2.  **Import Mapping Values** - Determine which properties to include in the Import Mapping. In a Viewer, open the STRATUS Properties tool and then select the element. Scroll through the properties to determine properties to use. In this example:
        1.  Attachment Cut Length will be the length of the strut.  
            ![](https://gtpservices.atlassian.net/wiki/download/thumbnails/170196993/image2019-8-29_14-50-9.png?version=1&modificationDate=1567108211589&cacheVersion=1&api=v2&width=664&height=396)
        2.  Attachment 1 provides the type or material of strut.  
            ![](https://gtpservices.atlassian.net/wiki/download/thumbnails/170196993/image2019-8-29_14-52-22.png?version=1&modificationDate=1567108345433&cacheVersion=1&api=v2&width=664&height=396)
    3.  **Report** - Create a report that extracts the data to be used in the Importing Mapping included all required fields and the optional fields you want to include.
        1.  **Format** - CSV
        2.  **Item Type** - Part
        3.  **Part Filter** - The filter you created above.
        4.  **Cut List Import** - Must be checked
        5.  **Report Fields** - Add the report fields add to be used in the Importing Mapping including all required fields and the optional fields you want to include. Here's an example:  
            ![](https://gtpservices.atlassian.net/wiki/download/thumbnails/170196993/image2019-8-29_15-0-11.png?version=1&modificationDate=1567108813539&cacheVersion=1&api=v2&width=881&height=323)
4.  **Seed the Importing Mapping** - To seed the Importing Mapping with the report fields, refresh the Models > Viewer, run the report created above under Actions > Reports, and then click the **Download** button once the report displays.  
    ![](https://gtpservices.atlassian.net/wiki/download/thumbnails/170196993/image2019-8-29_15-39-35.png?version=1&modificationDate=1567111178632&cacheVersion=1&api=v2&width=950&height=171)
5.  **Upload Seed Report to Import Mapping** - Return to the Admin > Company > Import Mappings tab, click the **Browse** button associated with the Import Mapping, locate the report downloaded above, and then upload the file. Note: The display does not show the uploaded file.  
    ![](https://gtpservices.atlassian.net/wiki/download/attachments/170196993/image2019-8-29_15-43-56.png?version=1&modificationDate=1567111440289&cacheVersion=1&api=v2)
6.  Once a Seed Report has been uploaded, expand the row to tell STRATUS about the **Header row**. Once selected, STRATUS will automatically fill-in and save the mapping fields with your Header rows.   
    ![](https://gtpservices.atlassian.net/wiki/download/thumbnails/170196993/image2020-6-1_10-36-27.png?version=1&modificationDate=1591025788804&cacheVersion=1&api=v2&width=1000&height=270)
    1.  **Area (Optional)** - Element Area property.
    2.  **Assembly ID (Optional)** - Element Assembly ID property.
    3.  **CAD ID (Optional)** - Element CAD ID property. Links your report back to the modeled elements inside STRATUS.
    4.  **Description (Optional)** - Element Description property.
    5.  **Item Number (Optional)** - Element Item Number property.
    6.  **Length (Required)** - Element Length property.
    7.  **Length 2 (Optional)** - Element Length 2 property.
    8.  **Level (Optional)** - Element Level property.
    9.  **Material (Required)** - Element Material property.
    10.  **QR Code (Optional)** - Element QR Code property.
    11.  **Quantity (Optional)** - Element Quantity property. Use if the element has a Quantity field or you can use a field generated in a STRATUS report.
    12.  **Size (Required)** - Element Size property.
    13.  **User Data 1 (Optional)** - Element User Data 1 property.
    14.  **User Data 2 (Optional)** - Element User Data 1 property.
    15.  **ProjectID (Optional)** -  
    16.  **ModelID (Optional)** - 
7.  If the Required fields have not been set, during the Import Cut List process on the Package's Cut List Tab, once the Report and the Import Mapping have been selected and Import is clicked, the following message will display which indicates the Seed report was not created.  
    ![](https://gtpservices.atlassian.net/wiki/download/thumbnails/170196993/image2019-12-19_14-6-55.png?version=1&modificationDate=1576786016678&cacheVersion=1&api=v2&width=350&height=482)

## Add Custom Properties to Label

To add any part property to a label for your cut list import mapping:

         **Create D****ata Fields**

1.  Identify the part property you want to add to a label. For example: 
    1.  **Attachment** – type of attachment on a hanger (Ex. Sammy)  
    2.  **System** – the part’s system propertyy 
2.  Under Admin > Company > Reports, create a **R****eport** that includes up 2 additional part properties. ![](https://gtpservices.atlassian.net/wiki/download/attachments/170196993/image2019-5-10_10-20-10.png?version=1&modificationDate=1557501612158&cacheVersion=1&api=v2)
3.  Run the report. 
4.  Download the report file. 
5.  Under Admin > Company > **Import Mappings**, create a **N****ew Import Mapping**. 
6.  Browse to locate the above report file. 
7.  Under the **User Data 1**, select the part property. 
8.  Do the same for the User Data 2 field if your report included a second part property. **Add Field to Tool Label Template**
9.  Under Admin > Company > **Tools**, edit the Label Template to include the User Data 1 field.  The syntax is ^FD{{userData1}}^FS
    1.  Do the same for the User Data 2 field if your report included a second part property. ![](https://gtpservices.atlassian.net/wiki/download/thumbnails/170196993/image2019-5-10_10-22-40.png?version=1&modificationDate=1557501761530&cacheVersion=1&api=v2&width=381&height=393) **Generate a Cut List Report** 
10.  Now that the Import Mapping and Label Template are ready, you can generate a cut list report.  
    
11.  Under Packages > Package > **Attachments**, select the report created in step #2 above. 
    1.  Review the report to make sure it contains valid data in the new fields added to the report. ![](https://gtpservices.atlassian.net/wiki/download/thumbnails/170196993/image2019-5-10_10-25-28.png?version=1&modificationDate=1557501929629&cacheVersion=1&api=v2&width=796&height=249)
12.  Under Packages > Package > **Cut Lists**  
    1.  Click the **Import Cut** **Lists** button.  
        
    2.  Select the **Select the file that contains the cut lists** option. If it does not include your report, make sure that the report above has the Cut List Import checkbox checked.  
        
    3.  Select the report that contains the cut lists and then select the import mapping.  
        ![](https://gtpservices.atlassian.net/wiki/download/thumbnails/170196993/image2019-8-29_16-1-14.png?version=1&modificationDate=1567112477787&cacheVersion=1&api=v2&width=272&height=394) 
    4.  Click **Import** and the cut list will display.
    5.  Select the **Station** and then click the **Send Cut List to Station** button. Access the cut list on the station either at the TigerStop station or under Shops > Shop > Station Name (below).  
        ![](https://gtpservices.atlassian.net/wiki/download/thumbnails/170196993/image2019-8-29_16-5-19.png?version=1&modificationDate=1567112723110&cacheVersion=1&api=v2&width=921&height=250)
        
        **Print Labels** 
13.  To print labels, go to the Packages Dashboard and click the **Print Labels** button for a package to print the labels on your selected label printer. 

## Videos

## STRATUS 08-29-19 Implementation Webinar - Import Mapping (13:14)

**********************************************************<iframe allowfullscreen="" allowtransparency="true" data-hasbody="false" data-macro-id="bef1fa19-10a2-4e6b-95a0-9143b559a497" data-macro-name="widget" frameborder="0" height="364" mozallowfullscreen="" src="https://player.vimeo.com/video/356706901?h=embed" webkitallowfullscreen="" width="640"></iframe>**********************************************************
---
created: 2025-06-25T06:27:05 (UTC -04:00)
tags: []
source: https://gtpservices.atlassian.net/wiki/spaces/SK/pages/215351308/Materials+Admin
author: 
---

# Materials (Admin) - STRATUS Knowledge Base - Confluence

> ## Excerpt
> Defining Materials enables the shop to organize cut lists sent to a Station based on Material and Size.

---
Defining **Materials** enables the shop to organize cut lists sent to a Station based on Material and Size.

-   1 [Videos](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/215351308/Materials+Admin#Videos)
    -   1.1 [08/19/2024 - Stratus Academy: ADM-511: Admin 3 - Materials](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/215351308/Materials+Admin#08%2F19%2F2024---Stratus-Academy%3A-ADM-511%3A-Admin-3---Materials)
    -   1.2 [Stratus - Materials (3:14)](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/215351308/Materials+Admin#Stratus---Materials-(3%3A14))
-   2 [Examples](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/215351308/Materials+Admin#Examples)
    -   2.1 [Automatically Select a Station when a Cut List is Generated](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/215351308/Materials+Admin#Automatically-Select-a-Station-when-a-Cut-List-is-Generated)

## Videos

## 08/19/2024 - Stratus Academy: ADM-511: Admin 3 - Materials

To take the Materials course, login to [**Stratus Academy**](https://academy.stratus.build/ "https://academy.stratus.build/") and and locate the course **ADM-511: Admin 3 - Materials**.

## Stratus - Materials (3:14)

This video demonstrates how to configure a hanger Material, associate it with a Station, and then when a Cut List is generated, the Station will automatically be selected based on the Material and Size.

<iframe allowfullscreen="" allowtransparency="true" data-hasbody="false" data-layout="default" data-local-id="99938790-ab65-4a2a-b6e4-bf86c3a4ff57" data-macro-id="330b33c5-c7d3-4c96-80a6-cb8a4e0987c3" data-macro-name="widget" frameborder="0" height="364" mozallowfullscreen="" webkitallowfullscreen="" width="640" src="https://player.vimeo.com/video/374469851?h=embed"></iframe>

## Examples

## Automatically Select a Station when a Cut List is Generated

In this example, when a cut list is generated the Station will automatically be selected based on the Material and Trade Size. This example can be used to configure one Material and Station, but also demonstrates how to select 2 different stations based on the Material and Trade Size.

**Configure the Materials**

1.  Create a New Material for the larger trade size:
    
    1.  **Name** = Hard Copper
        
    2.  **Description** = Type L Hard Copper 3/4" to 1 ½”
        
    3.  **Material Type** = Pipe
        
2.  **Save**.
    
3.  Expand the Material to enter Material Fields
    
    1.  **Material** = Hard Copper
        
        1.  The Material must match the Material property of the part.
            
            ![](https://media-cdn.atlassian.com/file/9ec4af69-eb40-4444-9153-b500bb229cc9/image/cdn?allowAnimated=true&client=5f4a70b1-9d9d-47c3-b388-87235680bb54&collection=contentId-215351308&height=617&max-age=2592000&mode=full-fit&source=mediaCard&token=eyJhbGciOiJIUzI1NiJ9.eyJpc3MiOiI1ZjRhNzBiMS05ZDlkLTQ3YzMtYjM4OC04NzIzNTY4MGJiNTQiLCJhY2Nlc3MiOnsidXJuOmZpbGVzdG9yZTpjb2xsZWN0aW9uOmNvbnRlbnRJZC0yMTUzNTEzMDgiOlsicmVhZCJdfSwiZXhwIjoxNzUwODQ5ODY1LCJuYmYiOjE3NTA4NDY5ODV9.C2bA0Z31XhSIdcwLTK7zadOioobMdb4VryMfFViNRgU&width=760)
            
    2.  **Material Aliases** (Optional) – None
        
    3.  **Nominal Length** (ft) – 20’
        
        1.  This is the stock length.
            
    4.  **Trade Size** – ¾”
        
    5.  **Max Trade Size** – 1 ½”
        
    6.  Repeat for the smaller trade size.
        
        ![](https://media-cdn.atlassian.com/file/ff5cc73c-7bf9-40b3-bc28-82906b3e32f5/image/cdn?allowAnimated=true&client=5f4a70b1-9d9d-47c3-b388-87235680bb54&collection=contentId-215351308&height=280&max-age=2592000&mode=full-fit&source=mediaCard&token=eyJhbGciOiJIUzI1NiJ9.eyJpc3MiOiI1ZjRhNzBiMS05ZDlkLTQ3YzMtYjM4OC04NzIzNTY4MGJiNTQiLCJhY2Nlc3MiOnsidXJuOmZpbGVzdG9yZTpjb2xsZWN0aW9uOmNvbnRlbnRJZC0yMTUzNTEzMDgiOlsicmVhZCJdfSwiZXhwIjoxNzUwODQ5ODY1LCJuYmYiOjE3NTA4NDY5ODV9.C2bA0Z31XhSIdcwLTK7zadOioobMdb4VryMfFViNRgU&width=760)
        
4.  **Configure a Tool**
    
    1.  Configure a Tool for each station. See the [**Tools**](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/215220225 "https://gtpservices.atlassian.net/wiki/spaces/SK/pages/215220225") article for more information.
        
5.  **Configure the Station**
    
    1.  Configure the station that will receive the larger Hard Copper material.
        
        1.  Click the **New Station** button.
            
        2.  **Name** = Copper - Type L Hard Copper 1 1/2"
            
        3.  **Description** = Copper - Type L Hard Copper 3/4" to 1 1/2"
            
        4.  **Division** = Pipe Shop, or whatever Division is configured to process the material.
            
        5.  **Tool** = Select the Tool configured to handle the large Hard Copper material.
            
        6.  **Save**.
            
        7.  **Edit Materials** – Click the Edit Materials button and select the large material.
            
            ![](https://media-cdn.atlassian.com/file/78e01f0f-e039-4c40-a8e3-539b647420c8/image/cdn?allowAnimated=true&client=5f4a70b1-9d9d-47c3-b388-87235680bb54&collection=contentId-215351308&height=757&max-age=2592000&mode=full-fit&source=mediaCard&token=eyJhbGciOiJIUzI1NiJ9.eyJpc3MiOiI1ZjRhNzBiMS05ZDlkLTQ3YzMtYjM4OC04NzIzNTY4MGJiNTQiLCJhY2Nlc3MiOnsidXJuOmZpbGVzdG9yZTpjb2xsZWN0aW9uOmNvbnRlbnRJZC0yMTUzNTEzMDgiOlsicmVhZCJdfSwiZXhwIjoxNzUwODQ5ODY1LCJuYmYiOjE3NTA4NDY5ODV9.C2bA0Z31XhSIdcwLTK7zadOioobMdb4VryMfFViNRgU&width=760)
            
    2.  Repeat these steps to configure the station that will receive the smaller Hard Copper material.
        
6.  **Generate a Cut List**
    
    1.  Select a package that has one or both sizes of Hard Copper material.
        
    2.  Under Packages > Package > Cut Lists, click the **Generate a Cut List** button.
        
    3.  Locate the material in the cut list. The Station should be automatically selected. Below 2 different Stations have been automatically selected based on the Material and Trade Size.
        

![](https://media-cdn.atlassian.com/file/8181bdcb-7aaf-4fad-b9bf-2e86fabc4326/image/cdn?allowAnimated=true&client=5f4a70b1-9d9d-47c3-b388-87235680bb54&collection=contentId-215351308&height=512&max-age=2592000&mode=full-fit&source=mediaCard&token=eyJhbGciOiJIUzI1NiJ9.eyJpc3MiOiI1ZjRhNzBiMS05ZDlkLTQ3YzMtYjM4OC04NzIzNTY4MGJiNTQiLCJhY2Nlc3MiOnsidXJuOmZpbGVzdG9yZTpjb2xsZWN0aW9uOmNvbnRlbnRJZC0yMTUzNTEzMDgiOlsicmVhZCJdfSwiZXhwIjoxNzUwODQ5ODY1LCJuYmYiOjE3NTA4NDY5ODV9.C2bA0Z31XhSIdcwLTK7zadOioobMdb4VryMfFViNRgU&width=1800)
---
created: 2025-06-25T06:27:04 (UTC -04:00)
tags: []
source: https://gtpservices.atlassian.net/wiki/spaces/SK/pages/164134913/Naming+and+Numbering+Admin
author: Authoring Software Is Right
---

# Naming and Numbering (Admin) - STRATUS Knowledge Base - Confluence

> ## Excerpt
> The Naming and Numbering tab includes sub-tabs: Naming Conventions, Numbering Rules, and Numbering Schemes.

---
The **Naming and Numbering** tab includes sub-tabs: **Naming Conventions**, **Numbering Rules**, and **Numbering Schemes**. 

-   1 [Naming Conventions](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/164134913/Naming+and+Numbering+Admin#Naming-Conventions)
    -   1.1 [Naming Convention Configuration](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/164134913/Naming+and+Numbering+Admin#Naming-Convention-Configuration) 
        -   1.1.1 [Unique Across All Projects (checkbox)](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/164134913/Naming+and+Numbering+Admin#Unique-Across-All-Projects-(checkbox))
        -   1.1.2 [Do Not Use Package Number (checkbox)](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/164134913/Naming+and+Numbering+Admin#Do-Not-Use-Package-Number-(checkbox))
    -   1.2 [Default Value Field Definitions](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/164134913/Naming+and+Numbering+Admin#Default-Value-Field-Definitions)
    -   1.3 [Naming Convention Override](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/164134913/Naming+and+Numbering+Admin#Naming-Convention-Override)
-   2 [Numbering Rules](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/164134913/Naming+and+Numbering+Admin#Numbering-Rules)
    -   2.1 [Stratus Is Always Right](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/164134913/Naming+and+Numbering+Admin#Stratus-Is-Always-Right) 
    -   2.2 [Authoring Software Is Right](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/164134913/Naming+and+Numbering+Admin#Authoring-Software-Is-Right)
-   3 [Numbering Schemes](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/164134913/Naming+and+Numbering+Admin#Numbering-Schemes)
    -   3.1 [Create Numbering Scheme](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/164134913/Naming+and+Numbering+Admin#Create-Numbering-Scheme)
    -   3.2 [Configure Numbering Scheme](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/164134913/Naming+and+Numbering+Admin#Configure-Numbering-Scheme)
        -   3.2.1 [Numbering Scheme Numbering Rules](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/164134913/Naming+and+Numbering+Admin#Numbering-Scheme-Numbering-Rules)
        -   3.2.2 [Numbering Scheme Number Settings (Stratus is Right)](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/164134913/Naming+and+Numbering+Admin#Numbering-Scheme-Number-Settings-(Stratus-is-Right))
            -   3.2.2.1 [Renumber Parts When Creating or Modifying Assemblies](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/164134913/Naming+and+Numbering+Admin#Renumber-Parts-When-Creating-or-Modifying-Assemblies)
        -   3.2.3 [Viewer Tags](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/164134913/Naming+and+Numbering+Admin#Viewer-Tags)
-   4 [Viewer Examples](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/164134913/Naming+and+Numbering+Admin#Viewer-Examples)
    -   4.1 [Example 1 - Couplings, Suffix, Prefix](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/164134913/Naming+and+Numbering+Admin#Example-1---Couplings%2C-Suffix%2C-Prefix)
    -   4.2 [Example 2 - Tag Unassembled Parts for Model Viewer](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/164134913/Naming+and+Numbering+Admin#Example-2---Tag-Unassembled-Parts-for-Model-Viewer)
    -   4.3 [Example 3 - Tag Assembled Parts and Connected Assemblies for Assembly Viewer](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/164134913/Naming+and+Numbering+Admin#Example-3---Tag-Assembled-Parts-and-Connected-Assemblies-for-Assembly-Viewer)
    -   4.4 [Example 4 - Rule Order](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/164134913/Naming+and+Numbering+Admin#Example-4---Rule-Order)
    -   4.5 [Example 5 - Models Viewer: Tag Shapes](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/164134913/Naming+and+Numbering+Admin#Example-5---Models-Viewer%3A-Tag-Shapes)
-   5 [Videos](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/164134913/Naming+and+Numbering+Admin#Videos)
    -   5.1 [08/19/2024 - Stratus Academy: ADM-503: Admin 1 - Naming and Numbering](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/164134913/Naming+and+Numbering+Admin#08%2F19%2F2024---Stratus-Academy%3A-ADM-503%3A-Admin-1---Naming-and-Numbering)
    -   5.2 [02/11/2021 - CSG Webinar: Naming And Numbering (40:40)](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/164134913/Naming+and+Numbering+Admin#02%2F11%2F2021---CSG-Webinar%3A-Naming-And-Numbering-(40%3A40))
    -   5.3 [08/06/2020 - Setting up “Naming And Numbering” for best results! (31:29)](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/164134913/Naming+and+Numbering+Admin#08%2F06%2F2020---Setting-up-%E2%80%9CNaming-And-Numbering%E2%80%9D-for-best-results!-(31%3A29))

## **Naming Conventions**

## **Naming Convention Configuration** 

Naming Conventions provide the ability to standardize how your company names assemblies and packages.  Each naming convention can be configured to standardize the constants and variables to be included in the name. An assembly or package name can be overridden during the create process (see below), on the Assemblies Dashboard, or on the Packages > Properties.

**To configure a naming convention under Admin > Company > Naming Conventions:**

1.  Default fields will already display.
    
2.  Click the **Add a field to naming convention** button to add a field to the right end of the current list of fields
    
     or click the **Remove a field from naming convention** button to remove the far-right field from the list.
    
3.  To select a field value, click the field (Ex. ServiceAbbreviation)
    
4.  The **Naming Convention Component** dialog will display.
    
5.  For each Assembly Naming convention field to be included, you can select **one** value. Below is a summary of these options.
    
    1.  **Default Values** – These values are explained in the Stratus Knowledge Base. See below for value definitions.
        
    2.  **Incrementor**
        
        1.  An **Incrementor** field can be placed anywhere in the Naming Convention string for Package Naming and Package Numbering, not Assembly Naming. When incrementing, all selected options (except static strings) are evaluated and then the incrementor is applied. If the selected options change, then the incremented value will begin at 01 or the Incrementor specified. The incrementor does not increment a specific option, rather it increments the selected options taken as a whole.
            
        2.  The Incrementor includes options for XX, XXX, XXXX, and XXXXX. If the numbering reaches 99, 999, 9999, or 99999 the next item will be numbered 100, 1000, 10000 or 100000 respectively. In each case, the numbering will continue to increment.
            
        3.  **Note:** The incrementor can only occur once in a Naming Convention string (Ex. Package Naming “string”). 
            
        4.  For example:
            
            1.  The **Incrementor XXX** field has been placed to the right of the **Package Category Abbreviation** field.  
                
                ![](blob:https://gtpservices.atlassian.net/66efb4ad-5f62-4cc4-a4ae-cfe87c42c60f)
                
            2.  When creating a new package, the naming convention will display.  
                
                ![](blob:https://gtpservices.atlassian.net/9412a404-4514-41b2-b8ad-5df7708edeef)
                
            3.  Once the package is created, the incrementor will increment the Package Category Abbreviation field since it is left of the Incrementor field in the Naming Convention string.  
                
                ![](blob:https://gtpservices.atlassian.net/be9baa39-99af-43bf-9926-c9ac5d466778)
                
        5.  When using an incrementor to create a new assembly or package name, the incrementor will initialize the incremented value after the assembly or package is saved. Also, the incrementor will add from the highest recent value. For example, if you adjust your first index to 1101, the next increment would be 1102.
            
    3.  **Static Strings** – The static strings you enter on the Naming Conventions page (left) will display in the Static Strings drop-down (right).  Enter any valid character you want to use in your name including separators or constants like “SPL” for spool. A static string cannot be removed if it referenced by a naming scheme. The “:” and other characters that are invalid for file names cannot be used in naming conventions. (dash) is included as a separator by default in the Static String Option section.
        
    4.  **Package Data** (Only included in Assembly Naming) – For those who create Packages and then create Assemblies, you can include the Package Data in the Assembly Name. Otherwise, if you create a new assembly of parts that have not yet been included in a package, this field would be empty. In this example, each Package Category Name has a Package Description, Package Name, and Package Number property.
        
    5.  **Part Parameters** – Any part parameter included in your database.
        
    6.  **Stratus Fields** – Any fields defined under Admin > Company > Fields
        
    7.  **Aliases** – Any aliases defined under Admin > Company > Aliases
        
6.  Changes are automatically saved.
    
7.  **Note**: Removed or added fields only apply to newly created Assembly or Package Names and do not change existing names.
    

### Unique Across All Projects (checkbox)

The **Unique Across All Projects** checkboxes provide a way to increment Package Naming and/or Package Numbering across all projects in the company. It is only associated with the Package Naming and Package Numbering strings.

1.  In the example below, **Package Numbering** is set to number each new package uniquely across all projects, while **Package Naming** can have the same Package Name across multiple projects.
    
    1.  **Checked -** When Checked numbering will be unique across all projects which provides a way to sequentially increment a field like **Package Category Abbreviation** across all projects.
        
    2.  **Unchecked** \- When Unchecked, numbering will not be unique across all projects which means the same name can be used across multiple projects.
        
2.  The result of the above settings is that:
    
    1.  The **Package Number** is unique across all models in this project.  
        
        ![](blob:https://gtpservices.atlassian.net/3da046c3-03b2-417c-8984-68083e89001c)
        
    2.  And the unique **Package Number** continues in this project.  
        
        ![](blob:https://gtpservices.atlassian.net/50dd6d19-cb32-4e41-8847-e4871c49ef8c)
        

### Do Not Use Package Number (checkbox)

The **Do Not Use Package Number** checkbox is only associated with the Package Numbering string.

![](blob:https://gtpservices.atlassian.net/dba7cb3f-4660-4d4f-b149-bb3ce4240350)

1.  **Unchecked** - With the **Do Not Use Package Number** unchecked the Package Numbering string will display during the Package naming process:
    
2.  **Checked** \- With the **Do Not Use Package Number** checked:
    
    1.  The Package Numbering string will not display during the Package naming process.
        
    2.  If a Package Numbering string field exists, it will be removed.
        
    3.  If the **Do Not Use Package Number** checkbox changes from checked to unchecked, at least one field needs to be added to the Package Numbering section in order for it to display for new Packages and to display on the Packages Dashboard.
        

## **Default Value Field Definitions**

1.  **BIM Area** – To use BIM Areas, they must be defined per project under Projects > Areas. For each area or row, you can enter an abbreviation that is used to populate this field in your name.
    
2.  **Date MMDDYY** - Ex. 031418 associated with today’s date
    
3.  **Date MMYYYY** - Ex. 032018 associated with the current month
    
4.  **Date YYYY** - 2018 associated with the current
    
5.  **Date YY** - Ex. 18 associated with the current
    
6.  **Incrementor xxxx, xxx, or xx** - For example, the Incrementor XX will start at 01 and increment to 99. Incrementor xxx will start at 001 and increment to 999. Incrementor xxxx will start at 0001 and increment to 9999. When an incrementor is used, it must be the last sub-string in the assembly and package name.
    
7.  **Level** - The level is extracted from the drawing or model.
    
8.  **Project Name** -  The BIM 360 project name is synchronized in Stratus.
    
9.  **Project Number** - The project number must be entered on a per-project basis under **Admin** > **Company** > **Projects** > **Edit the Number field for the project**.
    
10.  **System/Service** - The System/Services is extracted from the drawing or model.
    

## **Naming Convention Override**

When creating a new assembly or package in Stratus, your naming convention fields will display in the order that they were entered above. You can override any value by clicking the Override Naming Conventions checkbox.  

![](blob:https://gtpservices.atlassian.net/27dc8364-ea5b-4804-8706-36a8e7c6df24)

  

![](blob:https://gtpservices.atlassian.net/ab0a7d65-a7b6-41fe-aa24-4fddf19f7813)

## Numbering Rules

The **Stratus.Part.Number** property is treated consistently across the Stratus platform, similar to how the **Stratus.Part.AssemblyName** property is currently used. This means **Stratus.Part.Number** will be the primary reference for part numbers in all contexts, ensuring that it is always up-to-date.

Numbering Rules define how the Stratus.Part.Number property is populated for each part. Using Numbering Rule Part Filters and configuring Numbering Schemes, administrators control whether numbering in Stratus is right or numbering using the Authoring software is right.

## Stratus Is Always Right 

Stratus.Part.Number is the source property for item numbers in STRAUTS viewers and reports. Parts that match a **Stratus Is Always Right** Part Filter set the Stratus.Part.Number property when the **Renumber Parts** button is clicked. **Note:** The Numbering Scheme order does control numbering when a part matches multiple Part Filters.

**To add a new Stratus Is Always Right Numbering Rule:**

1.  Click the **New Rule** button:
    
    1.  **Name** \- The name will display in the **Numbering Schemes** tab > **Numbering Scheme Numbering Rules** drop-down.
        
    2.  **Part Filter** - A part filter can be configured under Admin > Company > Filters and then applied to a numbering rule. This enables you to selectively apply the filter to specific parts defined by your filter. For example, you may want an item numbering rule specific to welds.
        
    3.  **Prefix** – Adds a prefix to the numbering tag. To edit the Prefix:
        
        1.  Click the link. The Prefix Fields dialog will display where you can enter a Manual Override (like a text box) or a Property Override including Part properties, Stratus.Field.\*, Stratus.Alias.\*, and Stratus.Part.\* properties.  
            
            ![](blob:https://gtpservices.atlassian.net/31ab14cb-c6ac-40d6-a1a9-1b046fd97a89)
            
    4.  **Part Number Format** – Part Number Format can be None, Alphabetic or Numeric.
        
    5.  **Suffix** - Adds a suffix to the numbering tag. To edit the Prefix:
        
        1.  Click the link. The Suffix Fields dialog will display where you can enter a Manual Override (like a text box) or a Property Override including Part properties, Stratus.Field.\*, Stratus.Alias.\*, and Stratus.Part.\* properties.  
            
            ![](blob:https://gtpservices.atlassian.net/22d193fb-f031-480a-904c-145215a336d8)
            
    6.  **Matching Parts Get Same Item Number** - Matching parts can be renumbered either uniquely (unchecked) or the same (checked) depending on the project. The Matching Parts Get Same Item Number works in relation to the Admin > Company > Part Templates > Properties > Item Number setting. See the [**Configure Part Properties**](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/217809750/Part+Templates+Admin#Configure-Part-Properties "https://gtpservices.atlassian.net/wiki/spaces/SK/pages/217809750/Part+Templates+Admin#Configure-Part-Properties") > Item Number which describes how to set properties that need to be identical in order for parts to match.
        
        1.  **Note**:  For straight parts with holes identified using tap connector locations, when matching item numbers are enabled, parts with holes in different locations will get different item numbers. 
            
2.  Once done, click the **Save**
    
3.  The screenshot below displays **Numbering Rule** examples where **Stratus Is Always Right**. 
    

Stratus.Part.Number is the source property for item numbers in STRAUTS viewers and reports. Parts that match an **Authoring Software is Right** Part Filter will set the Stratus.Part.Number property during the publish process to a Revit property defined in the rule. **Note:** The Numbering Scheme order does control numbering when a part matches multiple Part Filters.

**To add a new Authoring Software Is Right Numbering Rule:**

1.  Click the **New Rule** button:
    
    ![](blob:https://gtpservices.atlassian.net/acfa57c6-f64d-4006-aff8-6e1934bb1714)
    
    1.  **Name** \- The name will display in the **Numbering Schemes** tab > **Numbering Scheme Numbering Rules** drop-down.
        
    2.  **Part Filter** - Select the **Part Filter**. These parts will not be numbered when the **Renumber Parts** button is clicked in the viewer. Instead, they will be numbered by the **Property To Map Number From** which will be copied to the Stratus.Part.Number property.
        
    3.  **Property To Map Number From** - The **Property To Map Number From** field is the Revit field that contains the data to be used for the item number. In the example above, the Diffuser rule’s **Property To Map Number From** is Mark, which is a property in Revit (below).  
        
        ![](blob:https://gtpservices.atlassian.net/3333b32b-9943-4234-a489-26b0cf24c5fd)
        
    4.  **Add Rule to a Numbering Scheme (and set order)** \- After any rule has been defined, it must be added to a **Numbering Scheme**. The Order may also need to be changed depending on Part Filters.
        
2.  **Example: Authoring Software Is Right**
    
    1.  In this example, the Diffuser matches the **Authoring Software Is Right** Numbering Rule and correctly sets the Mark value from Revit as the Stratus.Part.Number value in Stratus.
        
        ![](blob:https://gtpservices.atlassian.net/886004fc-5eb2-49a8-b2dd-b1c7c2c697ee)
        
    2.  After clicking **Renumber - All Item Numbers**
        
        1.  The Number and Stratus.Part.Number will be the same.
            
        2.  The Diffuser matches the **Authoring Software Is Right** Numbering Rule and correctly sets the Mark value from Revit (Ex. 33) as the tag in Stratus.  
            
            ![](blob:https://gtpservices.atlassian.net/c6fe1449-57a2-46ee-8403-00f1986ff16b)
            

## Numbering Schemes

Numbering Schemes are used to manage item numbering rules and the tagging routines on each viewer (Models > Viewer, Packages > Viewer, and Assemblies > Viewer).

A numbering scheme will not be applied in Stratus until it is saved to a project under Admin > Project > Settings > Item Numbering Scheme. As a result, you can have unique numbering for each project.

## Create Numbering Scheme

Multiple Numbering Schemes can be created and multiple numbering rules can be set for each numbering scheme.

**Rule Order:** The order for the rules is important because a part can match more than one Numbering Rule Part Filter, in which case the rule it matches first will take precedence. A Default rule can be added to the Numbering Scheme which would number any part that did not match a filter.

**To create a new Numbering Scheme:**

1.  Click the **New Scheme** button to the right of the Numbering Schemes drop-down. All settings will be blank.
    
    1.  **Numbering Scheme** – A Default Item Numbering Scheme is available. To create a new scheme, enter the name in the Name field (below) and then continue configuring the scheme. **Note**: A Company Numbering Scheme is set for each Project under Admin > Project > Settings > Item Numbering Scheme.
        
    2.  **Name** – Name of the Naming Scheme. Enter the name of the new naming scheme.
        
    3.  **Default Numbering Rule** – The Default number rule is the rule that is applied if the criteria for other rules is not met. If you want to create item numbers for parts that do not meet any scheme Part Filters, select the Default as the last rule in the list.
        

## Configure Numbering Scheme

### Numbering Scheme Numbering Rules

**To add a New Rule:**

1.  Click the **Add Rule** button. A new row will display.
    
2.  Click the **Choose a rule** link to display a list of available rules configured on the Numbering Rules tab.
    
    1.  **Order** \- The new rule will be placed last by default. This can be changed after the rule is saved.
        
        1.  **Note:** Parts can match more than one filter. The **Numbering Scheme Numbering Rules** are processed one at a time and the Numbering Rule’s Part Filter that first matches the part will take precedence.
            
            1.  **In Stratus** - When the user clicks the **Renumber - Parts** button in the Stratus viewer:
                
                1.  The **Numbering Scheme Numbering Rules** are processed one at a time.
                    
                2.  For all parts whose first Part Filter match is associated with a Numbering Rule in the **Stratus Is Always Right** table, the Stratus.Part.Number property will be populated according to the Numbering Rule that matches.
                    
                3.  **Note:** Parts will not be renumbered for all parts whose first Part Filter match is associated with a Numbering Rules in the **Authoring Software Is Right** table as the Stratus.Part.Number property is populated from Revit.
                    
            2.  **From Stratus to Revit** - When the Revit model is imported:
                
                1.  The **Numbering Scheme Numbering Rules** are processed one at a time.
                    
                2.  For all parts whose first Part Filter match is associated with a Numbering Rule in the **Stratus Is Always Right** table, the part’s Stratus.Part.Number property will update Revit. The Revit field updated is defined under Admin > Company > Settings > AutoCAD & Revit > Specific to Revit > Property To Map To Item Number.
                    
            3.  **From Revit to Stratus** - When the Revit model is published:
                
                1.  The **Numbering Scheme Numbering Rules** are processed one at a time.
                    
                2.  For all parts whose first Part Filter match is associated with a Numbering Rule in the **Authoring Software Is Right** table, the **Property To Map Number From** field will populate the Stratus.Part.Number property in Stratus.
                    
    2.  **Part Filter** - Select the Part Filter to apply to the rule.
        
    3.  **Rule Type** - The **Rule Type** column informs the user whether the rule is **Authoring Software Is Right** or **Stratus is Right**.
        
    4.  **Tag Shape** - Select the shape of the tag.
        
        1.  Rounded (default)
            
        2.  Rectangle
            
        3.  NONE
            

### Numbering Scheme Number Settings (Stratus is Right)

In viewers, when the **Renumber Parts** button is clicked, the **Numbering Scheme Number Settings** settings are referenced to determine if Assembled Parts and/or Unassembled parts should either have item numbers created or deleted. Control can be determined by Viewer.

**Note**: Whenever a part matches an **Authoring Software is Right** Part Filter rule, the **Numbering Scheme Number Settings** (Number Assembled Parts, Number Unassembled Parts, and Renumber Parts When Creating or Modifying Assemblies) checkbox options do not apply as these are Stratus is Right options.

1.  **Number Assembled Parts**
    
    1.  **Checked** - When **Number Assembled Parts** is checked for any viewer, when the **Renumber Parts** button or the **Delete Part Item Numbers** is clicked within the checked viewer, assembled part item numbers will be created (saved to the Stratus.Part.Number property) based on the Numbering Scheme Numbering Rules or deleted (Stratus.Part.Number property value deleted).
        
    2.  **Unchecked** \- When **Number Assembled Parts** is unchecked for any viewer, when the **Renumber Parts** button or the **Delete Part Item Numbers** button is clicked within the checked viewer, assembled part item numbers will be NOT created or deleted if the parts are included in an assembly. The part items Stratus.Part.Number property value will remain empty.
        
2.  **Number Unassembled Parts**
    
    1.  **Checked** - When **Number Unassembled Parts** is checked for any viewer, when the **Renumber Parts** button or the **Delete Part Item Numbers** is clicked within the checked viewer, unassembled part item numbers will be created (saved to the Stratus.Part.Number property) based on the Numbering Scheme Numbering Rules or deleted (Stratus.Part.Number property value deleted).
        
    2.  **Unchecked** \- When **Number Unassembled Parts** is unchecked for any viewer, when the **Renumber Parts** button or the **Delete Part Item Numbers** button is clicked within the checked viewer, unassembled part item numbers will be NOT created or deleted if the parts are included in an assembly. The part items Stratus.Part.Number property value will remain empty.
        

#### Renumber Parts When Creating or Modifying Assemblies

The **Renumber Parts When Creating or Modifying Assemblies** option provides renumbering automation when assemblies are created or modified.

1.  **Checked** - When checked and one of the following occurs, this option will reference **System Type** part property (Ductwork, Piping, Electrical or Other) of the part and determine if the assembly needs to be renumbered:
    
    1.  A new assembly is created under:
        
        1.  Models > Viewer > Actions > Assemblies > New.
            
        2.  Packages > Viewer > Actions > Assemblies > New.
            
    2.  An existing assembly is modified by adding or removing parts to or from the assembly.
        
2.  **Unchecked** \- When unchecked for a **System Type** property, those system types will not be automatically renumbered when there is a new assembly created or an existing assembly edited.
    

### Viewer Tags

Viewer Tags control which tags display in each viewer and controls the tag shape for assemblies and packages. **Note**: Item Number tag shapes are controlled in the **Numbering Scheme Numbering Rules** section, but whether or not the tag displays in the viewer is controlled in the Viewer Tags section.

**Example:** If under **Assembly Viewer Tags**, the **Assembled Parts** checkbox is unchecked, when in the Assemblies Viewer the user clicks the **Renumber Parts** button, no Assembled Parts would receive a number tag, although they would receive a value in Stratus.Part.Number.

1.  **Model Viewer, Assembly Viewer, Package Viewer Tag Options**
    
    1.  **Assembled Parts** – When checked “Assembled Parts” in the viewer will be tagged.
        
    2.  **Unassembled Parts** – When checked “Unassembled Parts” in the viewer will be tagged.
        
    3.  **Assemblies** – When checked “Assemblies” in the viewer will be tagged and a link to the assembly is provided.
        
        1.  **Tag Shape** - Select the tag shape for the Assemblies tag.
            
    4.  **Packages** - When checked “Packages” in the viewer will be tagged and a link to the package is provided.
        
        1.  **Tag Shape** - Select the tag shape for the Packages tag.
            
    5.  **Connected Assemblies** - When checked “Connected Assemblies” in the Assemblies > Viewer will be tagged and a link to the connected assembly is provided. If, for example, you want to renumber item numbers without displaying the Adjacent spool tag, uncheck the **Tag Connected Assemblies**.
        
        1.  **Tag Shape** - Select the tag shape for the Connected Assemblies tag.
            
    6.  **Tag Shapes**
        
        1.  **Parts**
            
            1.  Determine if a part (Tag Assembles Parts, Tag Unassembled Parts) will be checked or not checked.
                
                1.  **Checked** \- When checked, when parts are numbered in a viewer, Stratus will tag the parts that match the rule. The Tag Shape is determined by the Numbering Rule met first.
                    
                2.  **Unchecked** \- When unchecked, when parts are numbered in a viewer, Stratus will not tag the parts even if they match the rule.
                    
        2.  **Assemblies, Connected Assemblies, and Packages**
            
            1.  **Checked** \- When checked, when tags are displayed in the viewer, Assemblies, Connected Assemblies, and Packages will be tagged and use the selected Tag Shape.
                
            2.  **Unchecked** \- When unchecked, even if tags are displayed In the viewer, Assemblies, Connected Assemblies, and Packages will not be tagged.
                
        3.  **Tag Shapes** include:
            
            1.  Rounded (default)
                
            2.  Rectangle
                
            3.  NONE
                
2.  Settings are saved immediately at the company level, however, they are not saved yet to individual projects. To apply a Numbering Scheme to a project, see Project Settings below or go to Admin > Project > Settings to apply a Numbering Scheme to a project.
    
3.  **To Duplicate** a Numbering Scheme, click the Duplicate
    
4.  **To Delete** a Numbering Scheme, click the Delete button.
    

## Viewer Examples

A company Item Numbering Scheme must be toggled on per project under Admin > Project > Settings > Item Numbering Settings.

Item Numbering Scheme settings are applied to the viewers after you delete or re-engage a tagging tool. For example, if you delete all the item numbers on an assembly, then re-engage the item numbering tool, or just click the **Renumber Parts** button, the displayed tags reflect the recently set scheme settings.

## Example 1 - Couplings, Suffix, Prefix

1.  **Example 1:** If settings are configured as follows:
    
    1.  The **Coupling** rule will apply and label all couplings with a **Prefix** of **Z,** a **Suffix** of **A** and the **Number Format** will be Alphabetic.  
        
    2.  Non-Couplings will be **Numeric** per the **Default** 
        
    3.  Only parts in an Assembly will be numbered.
        
    4.  Assemblies will be tagged. 
        

## Example 2 - Tag Unassembled Parts for Model Viewer

1.  **Example 2:** If the Model Viewer settings (above) are changed to the screenshot below, other settings remain the same, then, when the **Renumber Parts** button is clicked in the Models > Viewer:
    
    1.  All Unassembled Parts (parts not in assemblies) are tagged.
        
    2.  Couplings are still tagged Alphabetically with the prefix and suffix.
        
    3.  Other parts are tagged by Default.
        

## Example 3 - Tag Assembled Parts and Connected Assemblies for Assembly Viewer

1.  Example 3: If the Assembly Viewer settings are set to the screenshot below, other settings remain the same, then, when the **Renumber Parts** button is clicked in the Assemblies > Viewer:
    
    1.  2 connected assemblies will be tagged (see screenshot below)
        
    2.  The parts should be tagged with the Default Rule and the couplings should be tagged with the Coupling Rule
        
    3.  The connecting assembly HWS—0002 will be tagged on the end it is located and will be linkable to the assembly.  
        
        ![](blob:https://gtpservices.atlassian.net/6041cf5d-3fcf-4bdd-987f-1a57c8dbd0c3)
        

## Example 4 - Rule Order

1.  Example 4: Below are 2 rules, one for Couplings and one for Piping Materials. Couplings should be included in both rules while the Piping Materials rule will only apply to pipes.
    
      
    **To see how the order of rules impacts numbering in the Models > Viewer:**
    
    1.  In the **Models** \> **Viewer** \> **Display - Tags and Item Numbers Toolbar** > click the **Delete Part Item Numbers** button.
        
    2.  Then, renumber the items by clicking the **Renumber Parts** button.
        
    3.  All the piping including the couplings are tagged with the **P** prefix.   
        
        ![](blob:https://gtpservices.atlassian.net/825fd094-f20e-408c-b256-428230983b40)
        
    4.  Return to **Admin > Company > Naming and Numbering** and make the Coupling Rule first under **Numbering Scheme Numbering Rules**.   
        
        ![](blob:https://gtpservices.atlassian.net/9e03b6a6-239b-40c5-be3a-6297c5023473)
        
    5.  In the **Models** \> **Viewer** \> **Display - Tags and Item Numbers Toolbar** > click the **Delete Part Item Numbers** button.
        
    6.  Then, renumber the items by clicking the **Renumber Parts** button.
        
    7.  The couplings have changed to the **Z** prefix **Alphabetic A** suffix tags and the other pipe has remained the same.   
        
        ![](blob:https://gtpservices.atlassian.net/9d148a38-aaa2-4235-b257-bdd473b36644)
        

## Example 5 - Models Viewer: Tag Shapes

1.  Go to Admin > Company > Naming and Numbering > Numbering Schemes. Under **Model Viewer** set:
    
    1.  **Tag Assemblies** = Rounded
        
    2.  **Tag Packages** = Rectangle
        
2.  In the Models Viewer that has Packages and Assemblies, click the **Display - Tags and Item Numbers Toolbar** button if tags have been created, or click the **Create Tag**s button. The tags display for:
    
    1.  Packages are using the Rectangle shape and the Package icon.
        
    2.  Assemblies are using the Rounded shape and the Assembly icon.
        

## **Videos**

## 08/19/2024 - Stratus Academy: ADM-503: Admin 1 - Naming and Numbering

To take the **Naming and Numbering** course, login to [**Stratus Academy**](https://academy.stratus.build/ "https://academy.stratus.build/") and locate the course **ADM-503: Admin 1 - Naming and Numbering**.

## **02/11/2021 - CSG Webinar: Naming And Numbering (40:40)**

<iframe allowfullscreen="" allowtransparency="true" data-hasbody="false" data-layout="default" data-local-id="6508cbd7-0620-4872-8259-76f80b249e1e" data-macro-id="b34fce04-723b-4af4-9c7b-ff206a2415f7" data-macro-name="widget" frameborder="0" height="364" mozallowfullscreen="" webkitallowfullscreen="" width="640" src="https://player.vimeo.com/video/511623125?h=embed"></iframe>

00:00 Release Note Review  
05:00 Admin > Company > Naming and Numbering > Naming Conventions  
15:50 Admin > Company > Naming and Numbering > Numbering Rules  
18:30 Admin > Company > Naming and Numbering > Numbering Rules > Matching Parts Get Same Item Number  
21:00 Admin > Company > Naming and Numbering > Numbering Schemes  
28:00 Admin > Project > Settings  
29:30 Questions

## **08/06/2020 - Setting up “Naming And Numbering” for best results! (31:29)**

<iframe allowfullscreen="" allowtransparency="true" data-hasbody="false" data-layout="default" data-local-id="74aa69b9-295f-4556-be3e-b642b47a0388" data-macro-id="e1b899ef-ef5e-4eda-9898-a743bb651369" data-macro-name="widget" frameborder="0" height="364" mozallowfullscreen="" webkitallowfullscreen="" width="640" src="https://player.vimeo.com/video/445688995?h=embed"></iframe>

0:33 Admin > Company > Naming and Numbering  
1:51 Adimn > Company > Settings > Item Numbering  
4:23 Numbering Rules and Part Filters  
10:19 Admin > Company > Part Templates - Matching parts get same number  
14:28 Admin > Company > Naming and Numbering > Naming Conventions  
21:26 Admin > Company > Naming and Numbering > Numbering Schemes  
26:22 Admin > Project > Settings > Item Number to set numbering by project  
27:18 Question: How to not number a part?  
29:46 Question: How to auto-number parts of assemblies created in Revit?
---
created: 2025-06-25T06:27:04 (UTC -04:00)
tags: []
source: https://gtpservices.atlassian.net/wiki/spaces/SK/pages/187662350/Notes+Admin
author: 
---

# Notes (Admin) - STRATUS Knowledge Base - Confluence

> ## Excerpt
> Standardize Notes at the company level and then assign them to any assembly or package.

---
Standardize Notes at the company level and then assign them to any assembly or package.

Notes can be assigned to Packages and Assemblies via their Notes tab. Assembly Notes can also be assigned to a specific part using the Tag feature in the Assembly Viewer.  All of these Notes are available for reporting and filtering using STRATUS.Package.Notes, STRATUS.Assembly.Notes, and STRATUS.Part.Notes.  When more than one note has been assigned, the value will be a semi-colon separated list with each note value combined.

**To create a Note:**

1.  Click **New Note** and enter the text as you want it to display.
    
    ![](https://gtpservices.atlassian.net/wiki/download/thumbnails/187662350/image2018-10-2_16-54-26.png?version=1&modificationDate=1538517268452&cacheVersion=1&api=v2&width=825&height=145)
    

**To add the note to an assembly:**

1.  Click the **Notes** tab.
2.  Click **New Note**.
3.  Click the the **Name field (Empty)** and then click the Specify Name **drop-down**. Your list of company notes will display.
    
    ![](https://gtpservices.atlassian.net/wiki/download/thumbnails/187662350/image2018-10-2_16-57-47.png?version=1&modificationDate=1538517468887&cacheVersion=1&api=v2&width=800&height=284)
    
4.  Select the note and click **Save**. The note will save along with the user name and date-time stamp. In addition, the Notes tab will display how many Notes are associated with the assembly.
    
    ![](https://gtpservices.atlassian.net/wiki/download/thumbnails/187662350/image2018-10-2_17-1-46.png?version=1&modificationDate=1538517707525&cacheVersion=1&api=v2&width=591&height=250)
    

**To add the note to a package:**

1.  Click the **Notes** tab.
2.  Click **New Note**.
3.  Click the the **Name field (Empty)** and either select an existing company-wide Note (Ex. Ship Loose) or enter a new Note (Ex. Buyout).   
    ![](https://gtpservices.atlassian.net/wiki/download/thumbnails/187662350/image2019-5-3_16-17-56.png?version=1&modificationDate=1556918277857&cacheVersion=1&api=v2&width=576&height=131)
4.  Click **Save**. The note will save along with the user name and date-time stamp. In addition, the Notes tab will display how many Notes are associated with the assembly.  
    ![](https://gtpservices.atlassian.net/wiki/download/thumbnails/187662350/image2019-5-3_16-21-35.png?version=1&modificationDate=1556918496893&cacheVersion=1&api=v2&width=845&height=250)
5.  In addition, on the Packages > Viewer tab you can move the Note tag and then when the STRATUS Sheet report is run, the Note’s leader will be placed correctly.  
    ![](https://gtpservices.atlassian.net/wiki/download/thumbnails/187662350/image2019-5-3_16-23-15.png?version=1&modificationDate=1556918596208&cacheVersion=1&api=v2&width=528&height=554)
---
created: 2025-06-25T06:27:05 (UTC -04:00)
tags: []
source: https://gtpservices.atlassian.net/wiki/spaces/SK/pages/166199351/Package+Categories+Admin
author: 
---

# Package Categories (Admin) - STRATUS Knowledge Base - Confluence

> ## Excerpt
> A Package Category provides the ability to create different packages for different purposes like Office, Purchasing, Shop, and Field work. Package categories accommodate workflows where the same part or assembly needs to be included in multiple packages. A part or assembly can not be included in more than one package within the same package category.  A package category is required for all new packages. In addition, company level Package Category Automation is facilitated by using the features Generate on Tracking Status for generating reports when a tracking status changes, Duration Days (M-F) for calculated Start Dates related to scheduling, Shop Hours Estimated to estimate shop hours, and to Configure Company Level BOM Settings for a Package Category.

---
A Package Category provides the ability to create different packages for different purposes like Office, Purchasing, Shop, and Field work. Package categories accommodate workflows where the same part or assembly needs to be included in multiple packages. A part or assembly can not be included in more than one package within the same package category.  A package category is required for all new packages. In addition, company level Package Category Automation is facilitated by using the features **Generate on Tracking Status** for generating reports when a tracking status changes, **Duration Days (M-F)** for calculated Start Dates related to scheduling, **Shop Hours Estimated** to estimate shop hours, and to **Configure Company Level BOM Settings for a Package Category**.

-   1 [New Package Category (Basic)](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/166199351/Package+Categories+Admin#New-Package-Category-(Basic))
-   2 [Generate on Tracking Status (Automation)](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/166199351/Package+Categories+Admin#Generate-on-Tracking-Status-(Automation))
    -   2.1 [Generate on Tracking Status (BOM)](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/166199351/Package+Categories+Admin#Generate-on-Tracking-Status-(BOM))
    -   2.2 [Generate on Tracking Status (Cut Lists)](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/166199351/Package+Categories+Admin#Generate-on-Tracking-Status-(Cut-Lists))
    -   2.3 [Generate on Tracking Status (MAJ)](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/166199351/Package+Categories+Admin#Generate-on-Tracking-Status-(MAJ))
    -   2.4 [Generate on Tracking Status (PCF)](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/166199351/Package+Categories+Admin#Generate-on-Tracking-Status-(PCF))
    -   2.5 [Generate on Tracking Status (Report)](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/166199351/Package+Categories+Admin#Generate-on-Tracking-Status-(Report))
-   3 [Duration Days (M-F) Company Level Configuration (Automation)](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/166199351/Package+Categories+Admin#Duration-Days-(M-F)-Company-Level-Configuration-(Automation))
    -   3.1 [Summary](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/166199351/Package+Categories+Admin#Summary)
    -   3.2 [Edit Duration Days](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/166199351/Package+Categories+Admin#Edit-Duration-Days)
-   4 [Package Reporting](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/166199351/Package+Categories+Admin#Package-Reporting)
    -   4.1 [Package Creation Report](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/166199351/Package+Categories+Admin#Package-Creation-Report)
    -   4.2 [Default Assembly Report](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/166199351/Package+Categories+Admin#Default-Assembly-Report)
-   5 [Estimating and Advanced Estimating](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/166199351/Package+Categories+Admin#Estimating-and-Advanced-Estimating)
    -   5.1 [Estimating](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/166199351/Package+Categories+Admin#Estimating)
    -   5.2 [Advanced Estimating](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/166199351/Package+Categories+Admin#Advanced-Estimating)
        -   5.2.1 [User Data Fields](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/166199351/Package+Categories+Admin#User-Data-Fields)
        -   5.2.2 [Workflow: Advanced Estimating](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/166199351/Package+Categories+Admin#Workflow%3A-Advanced-Estimating)
-   6 [BOM Settings](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/166199351/Package+Categories+Admin#BOM-Settings)
    -   6.1 [Configure Company Level BOM Settings for a Package Category](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/166199351/Package+Categories+Admin#Configure-Company-Level-BOM-Settings-for-a-Package-Category)
    -   6.2 [Override Package Category BOM Settings for an Individual BOM](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/166199351/Package+Categories+Admin#Override-Package-Category-BOM-Settings-for-an-Individual-BOM)
-   7 [MAJ](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/166199351/Package+Categories+Admin#MAJ)
    -   7.1 [MAJ Filters](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/166199351/Package+Categories+Admin#MAJ-Filters)
    -   7.2 [MAJ QR](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/166199351/Package+Categories+Admin#MAJ-QR)

## New Package Category (Basic)

To create a Package Category with basic non-automated values:

1.  Go to **Admin** > **Company** > **Package Categories**. The "basic" package category values are highlighted below. The other columns are described in separate sections.
    
    1.  **Name**– The Package Category name is the name that will display in the Category drop-down list when a new package is created. See the next step for examples.
        
    2.  **Description** (Optional) – A description of the package category to clarify how the category will be used.
        
    3.  **Abbreviation** – The package category abbreviation can be used as part of the automated package naming referenced under Admin > Company > Naming and Numbering > Naming Conventions.
        
    4.  **Use Assemblies** – Stratus understands parts, assemblies, and packages. Different parts and assemblies can be included in one or more packages. For example, design and fabrication packages should include assemblies, but, purchasing would want packages that include individual parts, not assemblies. Let’s say you have a run of pipe that has been packaged.
        
        1.  **When checked** the package will recognize the assemblies and will remove the individual parts from the package.
            
        2.  **When unchecked** the package will recognize the individual parts in the package. As a result, a procurement package can be created for all valves, but other connected parts in the assembly will be ignored.
            
    5.  **Use Containers** - A company doesn't want every package to be exposed to a Container. See the [**Containers Assign**](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/1877574151 "https://gtpservices.atlassian.net/wiki/spaces/SK/pages/1877574151") article for more information.
        
        1.  **When checked** and a package is created using the associated package category, the package will display in the **Containers > Assign > Package** drop-down.
            
        2.  **When unchecked** and a package is created using the associated package category, the package will not display in the **Containers > Assign > Package** drop-down.
            
    6.  **Delete a Package Category** - When deleting a Package Category, a prompt will display to re-assign packages to another Package Category. Note: The new Package Category must have the same “Use Assemblies” settings as the one being deleted.
        
2.  Once created, a Package Category is selected during the package creation process:
    
    1.  Under Models > Viewer > Actions > Packages > New
        
    2.  Under Packages > Dashboard > New Package
        
3.  Package Categories are used to filter packages on the following pages:
    
    1.  Models > Viewer > Display Mode > Packages > Select Package Category (Ex. Fabrication Production).
        
    2.  Click the **Normal** tab when done viewing to return the default color of the viewer.
        
    3.  Packages Dashboard
        
    4.  Packages Schedule
        
    5.  Packages Status Board
        

## Generate on Tracking Status (Automation)

Reports can be defined and generated at the the Company level using Package Categories. The **Generate on Tracking Status** section will generate reports (Ex. MAJ, PCF, or Report (selected) for the associated Package Category when the tracking status changes to a specific tracking status.

## Generate on Tracking Status (BOM)

Continued automation development when a package’s tracking status changes configured on the Admin > Company > Package Categories page. This time a package BOM can be automatically generated.

To generate a **BOM** report for a Package Category when the Tracking Status changes:

1.  For the Package Category (Ex. BOM Trigger) click the associated BOM link. 
    
2.  The **Generate on Tracking Status** drop-down will display.
    
3.  Select a Tracking Status (Ex. Spooled).
    
4.  Change the Tracking Status of any package that uses the associated Package Category (Ex. BOM Trigger) to the selected Tracking Status (Ex. Spooled). This tracking status change can be anywhere a package tracking status can be changed (Ex. Packages > BOM, Packages > Tracking, Packages Dashboard, etc.).
    
5.  A **BOM** will be automatically be generated and will display on the Package’s BOM tab. It will take time to generate the BOM depending on the number of parts.  
    **Note:** This automatically generated BOM only occurs once when no existing BOM has been previously been generated for the package. If a BOM exists for the package and the package’s tracking status is changed to the tracking status that normally triggers a BOM, a new or 2nd BOM will not be generated.
    

## Generate on Tracking Status (Cut Lists)

Continued automation development when a package’s tracking status changes configured on the Admin > Company > Package Categories page. This time a package **Cut List** can be automatically generated.

To generate a **Cut List** report for a Package Category when the Tracking Status changes:

1.  For the Package Category (Ex. Cut List Trigger) click the associated Cut List link. 
    
2.  The **Generate on Tracking Status** drop-down will display.
    
3.  Select a Tracking Status (Ex. Issued for Fabrication).
    
4.  Change the Tracking Status of any package that uses the associated Package Category (Ex. Cut List Trigger) to the selected Tracking Status (Ex. Issued for Fabrication). This tracking status change can be anywhere a package tracking status can be changed (Ex. Packages > Tracking, Packages Dashboard, etc.).
    
5.  A **Cut List** will be automatically be generated and will display on the Package’s **Cut Lists** tab. It will take time to generate the Cut List depending on the number of parts.  
    **Note:** This automatically generated Cut List only occurs once when no existing Cut List has been previously been generated for the package. If a Cut List exists for the package and the package’s tracking status is changed to the tracking status that normally triggers a Cut List, a new or 2nd Cut List will not be generated.
    

## Generate on Tracking Status (MAJ)

To generate a **MAJ** report for a Package Category when the Tracking Status changes:

1.  For the Package Category (Ex. FAB - Mechanical Piping) click the associated MAJ link. 
    
    ![14470a6c-0361-4f11-9360-840968f324f0.png](blob:https://gtpservices.atlassian.net/e1803b82-e988-4f71-ac3a-604c126be518)
    
2.  The **Generate on Tracking Status** drop-down will display.
    
3.  Select a Tracking Status (Ex. Packaged).
    
4.  When the Tracking Status of any package that uses the associated Package Category (Ex. FAB - Mechanical Piping) is changed to the selected Tracking Status (Ex. Packaged), a **MAJ** file will be automatically generated and saved as a package attachment. It will take time to generate the attachment depending on the file size.
    

## Generate on Tracking Status (PCF)

To generate a **PCF** report for a Package Category when the Tracking Status changes:

1.  For the Package Category (Ex. FAB - Mechanical Piping) click the associated PCF link. 
    
2.  The **Generate on Tracking Status** drop-down will display.
    
3.  Select a Tracking Status (Ex. Packaged).
    
4.  When the Tracking Status of any package that uses the associated Package Category (Ex. FAB - Mechanical Piping) is changed to the selected Tracking Status (Ex. Packaged), a **PCF** file will be automatically generated and saved as a package attachment. It will take time to generate the attachment depending on the file size.
    

## Generate on Tracking Status (Report)

To generate one or more **Report** attachments (CSV/PDF/ZPL) for a Package Category when the Tracking Status changes:

1.  For the Package Category (Ex. FAB - Mechanical Piping) click the numeric value associated with the **Report** link.   
    **Note:** The numeric value indicates how many reports are triggered for the associated Package Category.
    
2.  The **Generate Reports for \*Package Category\*** dialog will display.
    
3.  Click the **New Trigger** button. A new row will display.  
    
    ![](blob:https://gtpservices.atlassian.net/176d69ad-4c45-4627-a8ca-f3f316c4f5f5)
    
    1.  Select the **Tracking Status** change that will trigger the report generation for a package using the associated Package Category.
        
    2.  Select a **Report** that will automatically generate and display in the Package’s > Attachments tab.
        
        1.  **Note**: The list of Reports (right) is restricted to Reports whose Package Viewer checkbox is checked (left). Reports whose **Item Type** is Master Report, Package, Package Details, Assembly, or Part and whose **Package Viewer** checkbox is checked will be available.
            
4.  Click **Save**.
    
5.  To auto generate the report from anywhere a package tracking status can be changed, identify a package associated with the Package Category Report Trigger defined above (Ex. Category = Fabrication Production).
    
6.  Change the Tracking Status to the one selected in the Report Trigger (Ex. Cut). Refresh the page until the report display in the package’s attachment tab.
    

## Duration Days (M-F) Company Level Configuration (Automation)

## Summary

The Company level Package Categories Duration Days feature offers calculated initial Start Dates for package phases. For each Package Category, Duration Days can be set for each phase (Office, Purchasing, Shop, and Field). When a new package is created, Stratus will check to see if the selected package category includes Duration dates at the Company level (below), and then at the [**Duration Days Project Level Configuration**](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/217907482/Settings+Project#DurationDaysProjectLevelConfiguration "https://gtpservices.atlassian.net/wiki/spaces/SK/pages/217907482/Settings+Project#DurationDaysProjectLevelConfiguration") (which would override the Company settings). In addition, initial Start Dates can be edited at the package level.

**To configure Duration Days for a package category:**

1.  Under Admin > Company > Package Categories, the Purchasing Days columns will display.
    
    1.  **Phases** - A Duration Day can be set for each Phase and for each Package Category. Phases are also used in [**Division (Admin)**](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/103317524 "https://gtpservices.atlassian.net/wiki/spaces/SK/pages/103317524") and [**Tracking Statuses (Admin)**](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/10485761 "https://gtpservices.atlassian.net/wiki/spaces/SK/pages/10485761"). 
        
        1.  **Office** \- Detailing Start Date
            
        2.  **Purchasing** \- Purchasing Start Date
            
        3.  **Shop** \- Fabrication Start Date
            
        4.  **Field** - Field Date
            
    2.  **Duration Day** - A Duration day is a business day Monday thru Friday. In the current calculation, weekends are excluded while public holidays are included as a business day. For example, if a Start Date for Purchasing Phase is 9/1/2021 and the Duration Day is set to 21, the Start Date for the Shop Phase will be 9/29/2021 where 4 Saturdays and 4 Sundays were excluded, and the public holiday 9/6/2021 was not excluded.
        
2.  Edit the value associated with the phase.
    
3.  For the Duration Day to be applied to a package during the create package process:
    
    1.  **Package Category (required) -** The package category that includes Duration Days for one or more phases must be selected.
        
    2.  **Phase (optional)** - Phase defaults to **On Site**, but can be changed to a particular Phase. Selecting a phase will only denote which Start Date will be set with the Start Date entered (below). Initial Start Dates will populate the other Phases based on the Duration Days calculations.
        
    3.  **Start Date (optional)** - The Start Date is used to set the Start Date of the selected Phase.  If a Start Date is not entered, all Phase Start Dates will be empty.
        
        1.  The meaning of **On Site** is defined by your company.
            
        2.  On the Packages > Dashboard, the **Required Date = On Site** date.
            
    4.  **Note: Duration** - If the Package Category selected includes Duration (days), then those Phase Start Dates will be calculated based on the Start Date of the selected Phase (#2).
        
4.  See the Package [**Planning / Actual**](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/260603982/Package+Properties#PackagePlanning%2FActual "https://gtpservices.atlassian.net/wiki/spaces/SK/pages/260603982/Package+Properties#PackagePlanning%2FActual") article for more information.
    

## Edit Duration Days

The Confirm Save dialog will display when editing Duration Days at the company and project level.

After updating a Package Category > Duration Day:

1.  Click the **Save** button.
    
2.  The **Confirm Save** modal will display.  
    
    ![](blob:https://gtpservices.atlassian.net/71614c35-e9a5-49dd-8696-7a52ac5ed5d9)
    
    1.  **Apply to Existing Packages w/o Duration Days**
        
        1.  This option will recalculate package durations that have at least one “Empty” start/end phase date for the specific Package Category/Planning Phase.
            
        2.  **Note**: For this to trigger and recalculate, their must be at least one start date in the planning phase of the package.
            
    2.  **Apply to All Existing Packages**
        
        1.  This option will recalculate **ALL** existing package durations across the project that have duration days.
            
    3.  **Do Not Apply to Existing Packages**
        
        1.  This option will not recalculate any package durations within the project.
            
3.  Select an option and **Save**.
    

## Package Reporting

## Package Creation Report

**Additional Fields** are used to enter or display package data while creating new packages or viewing existing packages. Additional Fields are Editable Fields that have been added to a report under Report > Report Fields. The report is associated with a Package Category under Admin > Company > Package Categories when it is selected in the **Package Creation Report** column.

**Note:** Prior to this updated feature, these fields were named “Custom Fields” and the criteria for display included all editable fields from all Package Dashboard reports that were not hidden in the report.

See the end of this section for examples of Additional Fields.

To control which Fields display in the Additional Fields section:

1.  **Fields** - Under Admin > Company > Fields, identify or create one or more editable fields. See the **Is Editable** checkbox in the [**Fields (Admin)**](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/166035577 "https://gtpservices.atlassian.net/wiki/spaces/SK/pages/166035577") article for more information.
    
2.  **Report** - Under Admin > Company > Reports, identify or create a report that includes:
    
    1.  **Report Item Type** = Package.
        
    2.  **Editable Fields** - One or more editable fields (step #1).
        
    3.  **Checkbox** - The checkboxes (Model Viewer, Package Viewer, Packages Dashboard) do not need to be checked, but can be checked if the report needs to display.
        
    4.  **Hidden (Unchecked)** \- A Report Field that needs to display as an Additional Field cannot have the **Hidden** checkbox checked for the selected report.
        
    5.  **Sort Index** - The Sort Index is not applied to the fields in the Additional Fields section.
        
3.  **Package Creation Report** - Under Admin > Company > Package Categories, identify a Package Category that will use the fields from step #1 and #2 above. Select the report in the Package Category’s **Package Creation Report** property.
    
    1.  **Note (Empty)** \- For any Package Category whose **Package Creation Report** is Empty, the Additional Fields sections will be populated with Stratus.Field.\* fields that meet all of the following rules:
        
        1.  **Is Editable (Checked)** - Under Admin Company > Fields, the field’s **Is Editable checkbox is checked**.
            
        2.  **Report Item Type = Package** - The fields from above have been added to any report whose Item Type is Package.
            
        3.  **Hidden (Unchecked)** - The fields added to the report(s) above do not have the Hidden checkbox checked.
            
4.  **Examples of Where Additional Fields Display**
    
    1.  **Package Creation** - Package Creation under Models Viewer > Actions > Packages > Selected Package Category (step #3), or, Packages Viewer > Actions > Packages > Selected Package Category (step #3). **Note**: Additional Fields and Estimating Information fields update dynamically as parts are added to the package.
        
    2.  **Package Creation** - Package Creation under Packages > Dashboard > New Package > Selected Package Category (step #3).
        
    3.  **Package > Properties > Additional Fields** \- For a package associated with the Package Category (step #3), open a package’s > Properties tab. The Additional Fields should match the report.
        

## Default Assembly Report

The **Default Assembly Report** option enables administrators to select a default report to display when loading an assembly for the first time in the Assemblies > Viewer. The selected report is associated with a specific Package Category. Therefore the default report will only apply to assemblies included in packages within the Package Category.

To use the **Default Assembly Report**:

1.  **Report** - Under Admin > Company > Reports, identify or create a report that will be the default report when an assembly loads for the first time under Assemblies > Viewer > Parts > Report. The report needs to include:
    
    1.  **Report Item Type** = Part
        
    2.  **Assembly Viewer** = Checked
        
2.  **Default Assembly Report** - Under Admin > Company > Package Categories, identify a Package Category (Ex. Mechanical Piping Fabrication) that will use the report identified in step #1. Select the report (Ex. CSG \_ Pipework \_ Spool BOM) in the Package Category’s **Default Assembly Report** property.
    
3.  Identify a package whose Package Category (Ex. Mechanical Piping Fabrication) was configured in step #2.
    
4.  Open an assembly from that package for the first time. The Assemblies > Viewer > Parts > Report will be the **Default Assembly Report** selected (Ex. CSG \_ Pipework \_ Spool BOM) in step #2. If the user chooses to change the report, the last viewed report for that assembly will display on subsequent page refreshes.
    

For various scenarios, the order of operations is as follows:

1.  Example above - If an assembly is associated with a singular package whose Package Category has the **Use Assemblies** checkbox checked, the assembly will use the **Default Assembly Report** as configured under Admin > Company > Package Categories > **Default Assembly Report**.
    
2.  If an assembly is associated with more than one package whose Package Category has the **Use Assemblies** checkbox checked, it will use the **Default Assembly Report** as configured under Admin > Company > Package Categories > **Default Assembly Report** for the package that it is being opened from.
    
3.  If the assembly is not associated with a package, it will default to current functionality and use the “Assembly Filter” in reports to select which report should be used upon first view.
    

## Estimating and Advanced Estimating

## Estimating

At the Company level, the **Estimating** field column can be configured to display shop data (Ex. estimated hours) when creating a new package and/or in a Package's Properties. An Estimating field cannot be used when Advanced Estimating is enabled for the Package Category.

To automatically estimate hours for other project phases (Office, Purchasing, Field as well as Shop), see the [**Advanced Estimating**](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/166199351#PackageCategories(Admin)-AdvancedEstimating "https://gtpservices.atlassian.net/wiki/spaces/SK/pages/166199351#PackageCategories(Admin)-AdvancedEstimating") section.

To automatically generate estimated hours for the Shop Phase from the model based on the package category and a report field:

1.  Go to Admin > Company > Package Categories.
    
2.  Configure the **Estimating** by selecting an existing Stratus.Field. Do not click the **Advanced** checkbox.  In this example, the field **Stratus.Field.Actual Hours Spent** was selected for the Fabrication Release Package Category.
    
3.  Under Models > Viewer > Actions > Packages, in the create new package dialog, select the configured package category (Ex. Fabrication Release). The **Field** set for **Estimating** (above) correlates to the Shop (below) and will initially be 0 until parts are selected in the model. As parts are selected in the model, the **Estimating** data will be calculated as each part or a group of parts is selected.   
    
    ![](blob:https://gtpservices.atlassian.net/aa131a95-5a03-4a73-a8c1-a0b25df53780)
    
4.  Once saved, the **Estimating** data under Package’s Properties > Planning will display the calculated value. **Note**: The **Hours (Estimated)** for other Phases (Office, Purchasing, Field) can be manually edited and the Total will recalculate.  
    
    ![](blob:https://gtpservices.atlassian.net/1d834b09-103b-4b1b-8fba-a88be35abc80)
    

## Advanced Estimating

At the Company level, the **Advanced Estimating** section provides the ability to automatically calculate estimated values (Hours, Weights, Lengths, etc.) using existing Stratus.Field.\*  for all project phases (Ex. Office, Purchasing, Shop, and Field). Alternatively, the [**Estimating**](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/166199351#PackageCategories(Admin)-Estimating "https://gtpservices.atlassian.net/wiki/spaces/SK/pages/166199351#PackageCategories(Admin)-Estimating") column is tied to the Shop. See the [**Estimating**](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/166199351#PackageCategories(Admin)-Estimating "https://gtpservices.atlassian.net/wiki/spaces/SK/pages/166199351#PackageCategories(Admin)-Estimating") for more information.

1.  Under Admin > Company > Package Categories, for any Package Category, click the **Advanced Estimating** checkbox. The **Advanced Estimating** section will display a column for all four project phases (Ex. Office, Purchasing, Shop, and Field).
    
2.  For any phase or phases, select a Field to calculate the **Advanced Estimating** data to be calculated. In the example below, **Advanced Estimating** is checked for the Mechanical Piping Fabrication Package Category and a Field was selected for each Phase except Office.
    
    1.  **Notes:**
        
        1.  **Empty** - When a Phase is Empty (Ex. Office), it means that data can be manually entered while the package is being created or in the Package’s > Properties > Planning area.
            
        2.  **Advanced** - If an [**Estimating**](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/166199351#PackageCategories(Admin)-Estimating "https://gtpservices.atlassian.net/wiki/spaces/SK/pages/166199351#PackageCategories(Admin)-Estimating") Field had been selected for the Mechanical Piping Fabrication Package Category, now that Advanced Estimating has been selected and a Field has been selected for the Shop Advanced Estimating column, the Estimating column changes to Advanced so that Advanced Estimating settings takes precedence.
            
3.  Once set, under Models > Viewer > Actions > Packages > New:
    
    1.  With the Mechanical Piping Fabrication Package Category selected, **Estimating Information** initially displays 0 for all **Package Phases**.  
        
        ![](blob:https://gtpservices.atlassian.net/6f680f7f-7a9c-44d4-adcd-6ac5f83b8882)
        
    2.  As parts are selected in the model, the Advanced Estimate values are calculated and the Total is recalculated. Similarly, as parts are removed the estimate values are recalculated.
        
4.  Enter a manual estimate (Ex. Purchasing) and the **Total** value will recalculate.
    
5.  Save the package and open the Package’s > Properties tab. The Hours (Estimated) values will display in the Planning table.  
    
    ![](blob:https://gtpservices.atlassian.net/18991b70-af05-4e1b-a283-1e3a357a4a5f)
    

### User Data Fields

15 User Data fields can be added to Advanced Estimating under Admin > Company > Package Categories. These User Data fields display and update dynamically in the package creation dialog.

-   These fields can make information available to the user as they make packages so they can make better decisions about size and scope and preview dashboard report information before the package is created.
    
-   The User Data Field column names use the Display Name under Admin > Company > Fields. If no display name has been entered the full name of the field expression will display.
    
-   The data shown in the User Data fields updates dynamically as parts are selected and removed prior creating the package.
    
-   After the package has been created, any addition or removal of parts forces the User Data fields to recalculate.
    
-   Switching the Package Category after a package has been created forces the User Data fields to recalculate.
    
-   Boolean and “drop-down list” fields (includes Possible Values) can be edited during the package creation process.
    

**To use User Data Fields:**

1.  Under Admin > Company > Package Categories, for any Package Category, click the **Advanced Estimating** checkbox.
    
2.  The **Advanced Estimating** section will display a column for all four project phases and includes the **Add User Data** button. Only package category rows where the **Advanced Estimating** checkbox has been checked can be edited (indicated by the row being highlighted in yellow).
    
3.  Click the **Add User Data** button. The User Data # column will be inserted.
    
4.  Click the User Data drop-down and select a field. Available fields include:
    
    1.  Stratus.Company.\*
        
    2.  Stratus.Project.\*
        
    3.  Stratus.Package.\*
        
    4.  Stratus.Field.\*
        
5.  Continue to add User Data fields as needed. In the example below, there are 3 User Data fields populated for the Package Category = Mechanical Piping Fabrication, but up to15 User Data fields can be added.
    
6.  During the package creation process with the Package Category = Mechanical Piping Fabrication, the User Data fields will display in the **Estimating Information** section.
    
    1.  With no parts added to the package yet, all fields display 0.
        
    2.  **Note**: The “**Estimating Information**” was previously labeled “Hours Estimated” since more than hours can be included.
        
    3.  As parts are added to the package, the User Data fields dynamically populate.
        

### Workflow: Advanced Estimating

With the steps above, if a field like **estimated field install hours** has been configured, once you have added it to Advanced Estimating:

1.  Go to the Models Viewer.
    
2.  Select the parts you want to inquire about.
    
3.  Click Actions > Packages tool. The **estimated field install hours** can be generated without actually creating the package. Then rinse and repeat for any number of generated parts in the Package Category.
    

## BOM Settings

At the Company level, BOM Settings control the BOM report table for each Package BOM including the columns that display, how rows are consolidated, and how data is grouped. With BOM Settings controlled at the company level, a company can standardize how the BOM Report table displays data for each Package Category. These BOM Settings can be overridden within individual Package BOMs.

BOM Settings can be edited in the following areas:

-   Admin > Company > Package Categories > BOM Settings (This article)
    
-   Package’s > BOM > BOM Settings (See the [**BOM Settings**](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/166690857/Package+BOM#BOMSettings "https://gtpservices.atlassian.net/wiki/spaces/SK/pages/166690857/Package+BOM#BOMSettings") article for more information)
    

## Configure Company Level BOM Settings for a Package Category

BOM Settings set here at the Package Category level are the same as those set at the Package Level. See the Package [**BOM Settings**](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/166690857/Package+BOM#BOMSettings "https://gtpservices.atlassian.net/wiki/spaces/SK/pages/166690857/Package+BOM#BOMSettings") article for more information.

**To configure company level BOM Settings for a Package Category:**

1.  Go to Admin > Company > Package Categories.
    
2.  In the **BOM Settings** column, click the settings gear to display the company-level BOM Settings defaults for the selected Package Category.  
    
    ![](blob:https://gtpservices.atlassian.net/a46e0199-515d-4bee-9485-7d54f73e20d7)
    
3.  Initially, the default settings include the following:
    
    1.  **Ignore Zero Quantity Line Items** - Unchecked
        
    2.  **Auto Consolidate** - Checked
        
    3.  **Auto Linear Nest** - Checked
        
    4.  **Ignore Ancillaries** - Checked
        
    5.  **Unconsolidated Units of Measure** - Empty
        
    6.  **Group By** - Empty
        
    7.  **Columns** \- By default, all columns except for Ancillary Type, Ancillary Usage Type, Nominal Stock Length (In), Service Name, and Service Code are checked.
        
4.  When a Package BOM associated with the Package Category is opened under Packages > BOM, the default BOM Settings will be applied unless the Package BOM’s settings have been previously changed.
    

## Override Package Category BOM Settings for an Individual BOM

**To Override Package Category BOM Settings for an Individual BOM:**

2.  Click the **BOM Settings** gear icon button. The package’s current default BOM Settings will display. In this example, the current BOM Settings correspond to the Fabrication Production Package Category default settings.  
    
    ![](blob:https://gtpservices.atlassian.net/2ec16000-67d1-41d0-b7d8-8598166fc7d1)
    
3.  Edit any setting and the dialog title will change to **\[PackageName\] BOM Settings** where PackageName is the name of the selected **Package.** This indicates that the Package Category Default BOM Settings have been uniquely overridden.  
    
    ![](blob:https://gtpservices.atlassian.net/ba32184f-af6c-479b-9f9d-2f2509ca4ff0)
    
4.  Click the **Save** button to save.
    
5.  Open a Package BOM where the BOM Settings have been overridden. In this example, the Not Purchased column does not display in the BOM report table.
    
    1.  Before BOM Setting default override:
        
6.  After BOM Setting default override the **Not Purchased** column does not display.
    

## MAJ

## MAJ Filters

Create package MAJ files based on one or more Filters. With this feature multiple MAJ files can be created based on a filter so that some items can go to the coil line and other items to a plasma table. This eliminates the need to create separate packages. 

1.  Create one or more filters under Admin > Company > Filter. In this example, the 2 filters both use the CutType Property, but the value is DecoiledStraight for one and MachineCut for the other. Note: The filter name will be used to name the generated MAJ file.
    
    ![](blob:https://gtpservices.atlassian.net/f2fb188e-0f99-41c9-aa52-a555aa853889)
    
    1.  Apply the filter to a package category under Admin > Company > Package Categories.
        
        ![](blob:https://gtpservices.atlassian.net/241e432e-585f-4b35-b0b0-18ec81c51906)
        
    2.  Under MAJ Filters, click New MAJ Filter to add one or more filters.  
        
        ![](blob:https://gtpservices.atlassian.net/555c631e-9313-4174-aa3d-26dab40bc312)
        
    3.  If a report is selected for **MAJ** under **Generate on Tracking Status**, the generated reports will apply the MAJ Filters.
        
    4.  When generated, the MAJ files will display in the package’s Attachments tab.
        
        ![](blob:https://gtpservices.atlassian.net/6220b62e-7db0-4101-b9c2-f9ba4fb12d20)
        

## MAJ QR

The intent of this setting is to force QR codes that are imported into either CAMDuct or ESTmep to be assigned based on the package category that is checked in the MAJ QR column of the Package Categories tab of the Company Admin. A use case for this setting is if you create a single package for all sheet metal in an area but then use MAJs to break them out by fabrication type using different package categories. When the import commands run in CAMDuct and ESTmep, this serves to apply the correct package QR code URL to the parts.
---
created: 2025-06-25T06:27:05 (UTC -04:00)
tags: []
source: https://gtpservices.atlassian.net/wiki/spaces/SK/pages/217809750/Part+Templates+Admin
author: How to create a parameter within the authoring software
---

# Part Templates (Admin) - STRATUS Knowledge Base - Confluence

> ## Excerpt
> The Part Templates feature provides the ability to manage part properties for like parts across projects. During the publish process the Fabrication database is interrogated and the units are stored for the model. If a Fabrication database is not loaded the Revit Display Unit system is stored which is Metric or Imperial.

---
The Part Templates feature provides the ability to manage part properties for like parts across projects. During the publish process the Fabrication database is interrogated and the units are stored for the model. If a Fabrication database is not loaded the Revit Display Unit system is stored which is Metric or Imperial.

-   1 [Parts](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/217809750/Part+Templates+Admin#Parts)
    -   1.1 [Part Template Display](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/217809750/Part+Templates+Admin#Part-Template-Display)
    -   1.2 [Parts Table](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/217809750/Part+Templates+Admin#Parts-Table)
    -   1.3 [Select 1 Part vs Multiple Parts](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/217809750/Part+Templates+Admin#Select-1-Part-vs-Multiple-Parts)
-   2 [Properties](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/217809750/Part+Templates+Admin#Properties)
    -   2.1 [Manage Part Properties](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/217809750/Part+Templates+Admin#Manage-Part-Properties)
        -   2.1.1 [Order](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/217809750/Part+Templates+Admin#Order)
        -   2.1.2 [Display Name Override](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/217809750/Part+Templates+Admin#Display-Name-Override)
        -   2.1.3 [Visible](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/217809750/Part+Templates+Admin#Visible)
        -   2.1.4 [Editable](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/217809750/Part+Templates+Admin#Editable)
        -   2.1.5 [Stratus Field](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/217809750/Part+Templates+Admin#Stratus-Field)
        -   2.1.6 [Unit Label](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/217809750/Part+Templates+Admin#Unit-Label)
        -   2.1.7 [Display Format](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/217809750/Part+Templates+Admin#Display-Format)
        -   2.1.8 [Storage Format](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/217809750/Part+Templates+Admin#Storage-Format)
        -   2.1.9 [Item Number](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/217809750/Part+Templates+Admin#Item-Number)
    -   2.2 [How to create a parameter within the authoring software](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/217809750/Part+Templates+Admin#How-to-create-a-parameter-within-the-authoring-software)
        -   2.2.1 [Setup: Revit Property Parameter (Instance)](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/217809750/Part+Templates+Admin#Setup%3A-Revit-Property-Parameter-(Instance))
        -   2.2.2 [Setup: Fab Database](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/217809750/Part+Templates+Admin#Setup%3A-Fab-Database)
    -   2.3 [Exclude Selected Part Properties During Publish](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/217809750/Part+Templates+Admin#Exclude-Selected-Part-Properties-During-Publish)
    -   2.4 [Revit Parts - Build Assembly for Nested Family](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/217809750/Part+Templates+Admin#Revit-Parts---Build-Assembly-for-Nested-Family) 
-   3 [Cut List Mappings](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/217809750/Part+Templates+Admin#Cut-List-Mappings)
    -   3.1 [Configure Cut List Mappings](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/217809750/Part+Templates+Admin#Configure-Cut-List-Mappings)
    -   3.2 [Consider for Single-Axis Cut Lists](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/217809750/Part+Templates+Admin#Consider-for-Single-Axis-Cut-Lists)
    -   3.3 [Consider for Multi-Axis Cut Lists](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/217809750/Part+Templates+Admin#Consider-for-Multi-Axis-Cut-Lists)
        -   3.3.1 [Revit Part Family Property Mappings for End Types](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/217809750/Part+Templates+Admin#Revit-Part-Family-Property-Mappings-for-End-Types) 
            -   3.3.1.1 [Flange](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/217809750/Part+Templates+Admin#Flange)
            -   3.3.1.2 [Threaded Elbow](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/217809750/Part+Templates+Admin#Threaded-Elbow)
            -   3.3.1.3 [Tee](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/217809750/Part+Templates+Admin#Tee)
            -   3.3.1.4 [Buttweld](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/217809750/Part+Templates+Admin#Buttweld)
            -   3.3.1.5 [Threadolet](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/217809750/Part+Templates+Admin#Threadolet)
        -   3.3.2 [Pipe Cuts Settings to Match the End Mating Connectors](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/217809750/Part+Templates+Admin#Pipe-Cuts-Settings-to-Match-the-End-Mating-Connectors)
        -   3.3.3 [End Mating Connectors](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/217809750/Part+Templates+Admin#End-Mating-Connectors)
        -   3.3.4 [End Mating Connectors Corresponding PSVR file](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/217809750/Part+Templates+Admin#End-Mating-Connectors-Corresponding-PSVR-file)
    -   3.4 [Configure Cut List Mappings userData Custom Label Fields](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/217809750/Part+Templates+Admin#Configure-Cut-List-Mappings-userData-Custom-Label-Fields)
    -   3.5 [Configure Cut List Mappings userData Custom Label Fields for Calculated or Concatenated Field Expressions](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/217809750/Part+Templates+Admin#Configure-Cut-List-Mappings-userData-Custom-Label-Fields-for-Calculated-or-Concatenated-Field-Expressions) 
    -   3.6 [Cut List Mapping for Stub-Ins](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/217809750/Part+Templates+Admin#Cut-List-Mapping-for-Stub-Ins)
    -   3.7 [PypeServer Cut List](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/217809750/Part+Templates+Admin#PypeServer-Cut-List)
-   4 [BOM Line Item Mappings](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/217809750/Part+Templates+Admin#BOM-Line-Item-Mappings)
    -   4.1 [Control Data Used for Field Columns](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/217809750/Part+Templates+Admin#Control-Data-Used-for-Field-Columns)
    -   4.2 [Exclude from BOM](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/217809750/Part+Templates+Admin#Exclude-from-BOM)
-   5 [Videos](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/217809750/Part+Templates+Admin#Videos)
    -   5.1 [08/19/2024 - Stratus Academy: ADM-504: Admin 2 - BOM](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/217809750/Part+Templates+Admin#08%2F19%2F2024---Stratus-Academy%3A-ADM-504%3A-Admin-2---BOM)
    -   5.2 [08/19/2024 - Stratus Academy: ADM-510: Admin 3 - Cut List](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/217809750/Part+Templates+Admin#08%2F19%2F2024---Stratus-Academy%3A-ADM-510%3A-Admin-3---Cut-List)
    -   5.3 [08/13/2020 - Using your TigerStop with Stratus!](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/217809750/Part+Templates+Admin#08%2F13%2F2020---Using-your-TigerStop-with-Stratus!)
    -   5.4 [05/14/2020 – Part Templates;  What are they and how are they used?](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/217809750/Part+Templates+Admin#05%2F14%2F2020-%E2%80%93-Part-Templates%3B--What-are-they-and-how-are-they-used%3F)

## Parts

The Parts table displays all Part Templates published to the company database. Different management dialogs will display depending on whether one or multiple Part Templates have been selected.

## Part Template Display

To display a Part Template, either:

1.  Click the Admin > Company > **Part Templates** button to display and locate the part template. Click the parts **Select** checkbox to display the part’s **Properties**.
    
2.  In any Viewer, (Model, Assemblies, Package), with a part selected, click the Toolbar > Properties button to open the Stratus Properties panel and then click the Template Name link. The template name will open the Admin > Company > Part Templates page and populate the Search box with the template name. Click the parts **Select** checkbox to display the part’s **Properties**.
    

## Parts Table

1.  To add a part template to the Parts table, publish a model or drawing. If the part template does not exist it will be added to the table.
    
2.  Once a part template displays in the Parts table, locate and select parts as follows:
    
    1.  **PatNo** - The part number is derived from the model.
        
    2.  **Name** - The Part Template names for fabrication parts follows this pattern:  
        **“Fabrication (ITM) pattern <Pattern Number> from <Authoring Software>”**
        
        Example:  
        **“Fabrication (ITM) pattern 2041 from Revit”**
        
    3.  **Type** - The part type is derived from the model. Examples include:
        
        1.  **Notes:**
            
            -   Revit families (parts without a “PattNo.”) are not be affected by this change.
                
            -   This change does **NOT** affect “PattNo.” 2875 - “PattNo.” 2875 should use the current logic (it is a special case and needs to be handled separately to make the initial setup easier)
                
            -   All fabrication parts that are not “PattNo.” 2875 should use the following format for their “Name”
                
                -   **“Fabrication (ITM) pattern <Pattern Number> from <Authoring Software>”**
                    
    4.  **Category** \- The part category is derived from the model.
        
    5.  **Select All** - Checks the checkbox associated with all parts or all parts filtered by a search.
        
    6.  **Clear Selection** \- Unchecks the Select checkbox for all parts.
        
    7.  **Deleted Selected** - Deletes all selected part templates. See Delete.
        
    8.  **Delete** - Deletes the part template.
        
        1.  **Delete a part template if:**
            
            1.  A part template is duplicated.
                
            2.  A part template needs to be returned to a default state where none of its properties have been edited. The model that includes the deleted part template would need to be published in order for the part template to redisplay.
                
    9.  **Show** – Click the Show drop-down to show more or fewer parts on the page.
        
    10.  **Search** – Searching searches all data columns.
        
    11.  **Sort** – Sort Parts by Name, Type, or Category.
        
    12.  **Filter** – Filter Parts by Type or Category. Multiple filter items can be selected.
        
3.  Select at least one part for the Properties tab to populate.
    

## Select 1 Part vs Multiple Parts

1.  When a single Part Template is selected, the tabs (Ex. Properties, Cut List Mappings, and BOM Mappings) display.
    
2.  When multiple Part Templates are selected the following tabs display. In the first example, **All Properties** is selected. In the second example, **Shared Properties** is selected.
    
    1.  **All Properties** - When the **All Properties** tab is selected, all properties from all selected Part Templates will display. Edits to any Property will be applied to all selected Part Templates.
        
    2.  **Shared Properties** - When the **Shared Properties** tab is selected, only those Properties that are common between the selected Part Templates will display. Edits to any Property will be applied to all selected Part Templates.
        
    3.  **Cut List Mappings** - The **Cut List Mappings** tab is disabled since mappings cannot be made to multiple Part Templates at once.
        
    4.  **BOM Mappings** - The **BOM Mappings** tab is disabled since mappings cannot be made to multiple Part Templates at once.
        
    5.  **Templates** - When multiple Part Templates have been selected, the Templates column displays the number of Part Templates the property can be found in. ALL will display when the property is in all selected templates. In this example, the ALL link is selected and the property popup displays the Part Templates that use the property. Each Part Template includes a link that will open in a separate tab. The Part Template names can be exported using the CSV | Excel buttons.
        

## Properties

The Properties tab provides the ability to manage part properties at a company level across all projects. Part property data is presented in reports and in the Viewers (Models, Package, and Assembly) under the Toolbar > Properties panel. Stratus data can be pushed to certain properties configured in the authoring tool.

## Manage Part Properties

When a part is selected its properties display.

### Order

1.  **Order** works in conjunction with the **Visible** column to display a subset of properties in the **Properties** panel (Viewers) when **All Properties** is unchecked. This provides the administrator with a way to reduce the number of properties that display. See the Visible section below for an example.
    

### Display Name Override

1.  Click the link in the **Display Name Override** column to override the Property display name. This name will display in the Properties panel when a part is selected in any of the Viewers (Models, Assemblies, or Packages). 
    

### Visible

1.  **Visible** works in conjunction with the **Order** column to display a subset of properties within any Viewer on the Tools > **Properties** panel. For a property to display on the Viewer’s Properties panel when **All Properties** is unchecked, **Visible** must be checked and the **Order** number must be set.
    
    1.  **Visible Checked** - When Visible is checked for a property, it will receive the next sequential Order number. The Order number can be manually edited and numbers will adjust automatically.
        
    2.  **Visible Unchecked** - When Visible is unchecked, Order will be set to Empty and Order numbers will adjust automatically.
        
        1.  **Order Empty** - When Order is Empty and a numeric value is entered, Visible will become checked, and the next sequential Order number will be entered.
            
    3.  For example, when Visible is checked for a property, its Order number will determine its display order in any Viewer on the Tools > **Properties** panel when **All Properties** is unchecked.
        

### Editable

1.  When checked, the property value can be edited as follows:
    
    1.  **Properties panel single part selected** - When a single part is selected in a Viewer, editable properties can be edited using the Tools > **Properties** panel.
        
    2.  **Properties panel multiple parts selected** - When multiple parts have been selected in a Viewer, editable properties can be edited using the Tools > **Properties** panel. In this example, the editable value is different between the selected parts:
        
        1.  Select 2 parts in the model that belong to the same Part template.
            
        2.  Since the **Item Description** value for the selected parts is not the same, the value will display as **<varies>**.
            
        3.  To set the value to be the same for all selected parts, click **<varies>, and then enter the value.**
            
        4.  Now all selected parts have the same Item Description. These values will update the drawing or model during the Import process.
            
    3.  **Assemblies Viewer** \- Under Assemblies > Viewer > Parts tab, when a report includes an editable field, the field can be edited.
        
    4.  Edited content can be round-tripped back into the element in the authoring tool. For example:
        
        1.  Check the **Editable** property for the Notes field.
            
        2.  To edit the data for a part in a Stratus viewer, open the Stratus **Properties** dialog, **select the part**, click the **Empty** link, enter a note, and then click the checkbox to **save**.
            
        3.  To view the note in the authoring tool (CADmep in this case), **import** the drawing, **select the edited part**, and then open its **Item properties**. The text entered in Stratus displays.
            
        4.  To update the property data in Stratus, edit the **Item properties** (left) and then publish the model. Open the Stratus **Properties** dialog, **select the part** and the updated text will display (right).
            

### Stratus Field

The Stratus Field column is used to push part-level data and calculations back to the authoring software (Revit/CAD/CAM). These field/property values will be editable in Stratus Properties and Reports and be visible in Filters.

**Note**: Any Stratus.Field (Admin > Company > Fields) will display in the Part Templates > Stratus Field drop-down, however, only those configured as a Revit Instance parameter or a Fab Database Custom Item Data field will be pushed back to the authoring software. See below for authoring software setup instructions below.

**To use the Stratus Field in Part Templates:**

1.  After the [Revit Instance parameter](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/217809750/Part+Templates+Admin#Setup:-Revit-Property-Parameter-(Instance) "https://gtpservices.atlassian.net/wiki/spaces/SK/pages/217809750/Part+Templates+Admin#Setup:-Revit-Property-Parameter-(Instance)") or a [Fab Database Custom Item Data](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/217809750/Part+Templates+Admin#Setup:-Fab-Database "https://gtpservices.atlassian.net/wiki/spaces/SK/pages/217809750/Part+Templates+Admin#Setup:-Fab-Database") field has been published to Stratus (includes using GTP Lighting), it is available as a Stratus.Field.
    
2.  Under Admin > Company > Part Templates, the **Stratus Field** column displays. The **Stratus Field** drop-down is only available for properties whose **Editable** checkbox is checked. All Stratus.Fields display in the **Stratus Field** drop-down. Select a Stratus.Field for the associated Property.
    
3.  **Properties - View / Edit the editable field**
    
    1.  Click on a part whose Part Template was edited above.
        
    2.  The values will display and are editable.
        
    3.  **Note**: The table below describes how editable fields work in the Properties Panel and in the report table.
        

<table data-testid="renderer-table" data-number-column="false" data-table-width="760" data-layout="full-width"><colgroup><col><col><col><col></colgroup><tbody><tr><th rowspan="1" colspan="1" data-colwidth="220" data-cell-background="var(--ds-background-accent-gray-subtlest, #F4F5F7)" aria-sort="none"><div><p data-renderer-start-pos="9660"><strong data-renderer-mark="true">Property is on the</strong><br><strong data-renderer-mark="true">Part Template</strong></p></div></th><th rowspan="1" colspan="1" data-colwidth="137" data-cell-background="var(--ds-background-accent-gray-subtlest, #F4F5F7)" aria-sort="none"><div><p data-renderer-start-pos="9697"><strong data-renderer-mark="true">Property is on the Part</strong></p></div></th><th rowspan="1" colspan="1" data-colwidth="366" data-cell-background="var(--ds-background-accent-gray-subtlest, #F4F5F7)" aria-sort="none"><div><p data-renderer-start-pos="9724"><strong data-renderer-mark="true">Field Behavior</strong></p></div></th><th rowspan="1" colspan="1" data-colwidth="265" data-cell-background="var(--ds-background-accent-gray-subtlest, #F4F5F7)" aria-sort="none"><div><p data-renderer-start-pos="9742"><strong data-renderer-mark="true">Example</strong></p></div></th></tr><tr><td rowspan="1" colspan="1" colorname="" data-colwidth="220"><p data-renderer-start-pos="9755">Yes (Editable)</p></td><td rowspan="1" colspan="1" colorname="" data-colwidth="137"><p data-renderer-start-pos="9773">Yes</p></td><td rowspan="1" colspan="1" colorname="" data-colwidth="366"><p data-renderer-start-pos="9780">Show Empty underline for edit and saves</p></td><td rowspan="1" colspan="1" colorname="" data-colwidth="265"></td></tr><tr><td rowspan="1" colspan="1" colorname="" data-colwidth="220"><p data-renderer-start-pos="9830">Yes (Editable)</p></td><td rowspan="1" colspan="1" colorname="" data-colwidth="137"><p data-renderer-start-pos="9848">No</p></td><td rowspan="1" colspan="1" colorname="" data-colwidth="366"><p data-renderer-start-pos="9854">Property shows as editable. &nbsp;However, when attempting to place a value on the property, an <strong data-renderer-mark="true">Unable to Save Value</strong> message will appear to inform the user the value will not be saved as the property does not exist on the part.</p></td><td rowspan="1" colspan="1" colorname="" data-colwidth="265"><div data-testid="media-card-view" data-test-status="loading-preview" data-test-source="ssr-data" data-test-media-name="image-20231127-220840.png" data-test-progress="1" id="newFileExperienceWrapper" data-media-vc-wrapper="true" data-type="file" data-node-type="mediaSingle" data-width="308" data-height="153" data-id="8bb774e3-3c85-4d05-b8f4-5e68d6725302" data-collection="contentId-217809750" data-file-name="image-20231127-220840.png" data-file-size="14531" data-file-mime-type="image/png" data-alt="" data-renderer-start-pos="10080" data-context-id="217809750" data-width-type="pixel" data-vc="media-single"><p><img data-fileid="8bb774e3-3c85-4d05-b8f4-5e68d6725302" data-filecollection="contentId-217809750" data-resizemode="stretchy-fit" data-source="ssr-data" src="https://media-cdn.atlassian.com/file/8bb774e3-3c85-4d05-b8f4-5e68d6725302/image/cdn?allowAnimated=true&amp;client=5f4a70b1-9d9d-47c3-b388-87235680bb54&amp;collection=contentId-217809750&amp;height=271&amp;max-age=2592000&amp;mode=full-fit&amp;source=mediaCard&amp;token=eyJhbGciOiJIUzI1NiJ9.eyJpc3MiOiI1ZjRhNzBiMS05ZDlkLTQ3YzMtYjM4OC04NzIzNTY4MGJiNTQiLCJhY2Nlc3MiOnsidXJuOmZpbGVzdG9yZTpjb2xsZWN0aW9uOmNvbnRlbnRJZC0yMTc4MDk3NTAiOlsicmVhZCJdfSwiZXhwIjoxNzUwODQ5ODg4LCJuYmYiOjE3NTA4NDcwMDh9.wNBSr5XIVX1me4g_fbFg6RtAYhBH4kdyHX0zPNf0WAI&amp;width=760" alt="" loading="lazy"></p></div></td></tr><tr><td rowspan="1" colspan="1" colorname="" data-colwidth="220"><p data-renderer-start-pos="10090">Yes (Not Editable)</p></td><td rowspan="1" colspan="1" colorname="" data-colwidth="137"><p data-renderer-start-pos="10112">Yes</p></td><td rowspan="1" colspan="1" colorname="" data-colwidth="366"><p data-renderer-start-pos="10119">Shows Read-only value</p></td><td rowspan="1" colspan="1" colorname="" data-colwidth="265"></td></tr><tr><td rowspan="1" colspan="1" colorname="" data-colwidth="220"><p data-renderer-start-pos="10151">Yes (Not Editable)</p></td><td rowspan="1" colspan="1" colorname="" data-colwidth="137"><p data-renderer-start-pos="10173">No</p></td><td rowspan="1" colspan="1" colorname="" data-colwidth="366"><p data-renderer-start-pos="10179">Nothing (Blank)</p></td><td rowspan="1" colspan="1" colorname="" data-colwidth="265"></td></tr><tr><td rowspan="1" colspan="1" colorname="" data-colwidth="220"><p data-renderer-start-pos="10205">No</p></td><td rowspan="1" colspan="1" colorname="" data-colwidth="137"><p data-renderer-start-pos="10211">Yes</p></td><td rowspan="1" colspan="1" colorname="" data-colwidth="366"><p data-renderer-start-pos="10218">Shows Read-only value</p></td><td rowspan="1" colspan="1" colorname="" data-colwidth="265"></td></tr><tr><td rowspan="1" colspan="1" colorname="" data-colwidth="220"><p data-renderer-start-pos="10250">No</p></td><td rowspan="1" colspan="1" colorname="" data-colwidth="137"><p data-renderer-start-pos="10256">No</p></td><td rowspan="1" colspan="1" colorname="" data-colwidth="366"><p data-renderer-start-pos="10262">Nothing (Blank)</p></td><td rowspan="1" colspan="1" colorname="" data-colwidth="265"></td></tr></tbody></table>

5.  **Report - Add a Stratus Field to a Report**
    
    1.  Select a Report Field Property Name that was configured under Part Templates > Stratus Field to be pushed back to the authoring software and set the Report Field Format according to the type of data used in the Property.
        
    2.  Run the report. The values, if they exist, will display.
        
6.  **Filter - Add a Stratus Field to a Filter**
    
    1.  Add a Stratus.Field.XXXX that was configured under Part Templates > Stratus Field to be pushed back to the authoring software to a Filter.
        
    2.  Navigate to any viewer (Ex. Models > Viewer), open Filters > Company and the Stratus Fields will display.
        
7.  **Stratus pushes each qualified Stratus.Field parameter/property data back into the authoring software:**
    
    1.  During import/publish process.
        
    2.  When a MAJ file is generated from Stratus.
        

**Review:** [**How to create a parameter within the authoring software**](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/217809750/Part+Templates+Admin#How-to-create-a-parameter-within-the-authoring-software "https://gtpservices.atlassian.net/wiki/spaces/SK/pages/217809750/Part+Templates+Admin#How-to-create-a-parameter-within-the-authoring-software")

### Unit Label

1.  Control the unit label for the Display format or delete to leave it blank. See the Display Format example below.
    

### Display Format

1.  For any property, the display format can be selected. **Note:**  The Display Format setting is not used by the reporting engine. In each report, you have control over how the data is formatted, which may include a conversion multiplier and unit symbol. It is not safe to assume the report format will always match the property's display format and keeping these separate gives the reporting engine more flexibility.
    
    1.  For example, if the Diameter Display Format is Fraction Feet/Inches:
        
    2.  It will display in Stratus Properties like this. Notice the Unit Label is ft/in. You control this in the Unit Label column.
        
    3.  Change the Diameter Display Format to Fraction Inches:
        
    4.  It will display like this. Notice the Unit Label is **in**. The Unit Label column controls the “in” display after the property value.
        

### Storage Format

1.  A myriad of units can be produced from Revit and AutoCAD and their respective databases of families and ITM’s. The Storage Format is how the unit will be stored in Stratus (Ex. Decimal feet, decimal inches, decimal millimeters, etc.). For example, angles sometimes display in radians rather than degrees, and diameters appear in feet rather than inches. **Note**: The original storage format is also stored and is not editable. This format is used when round-tripping edited values back into the authoring tool.
    

### Item Number

1.  The Item Number checkbox works in relation to the Admin > Company > Naming and Numbering > Numbering Rules > **Matching Parts Get Same Item Number** options that are checked (see below). In Part Template, when **Item Number is checked**, it means that the property will be a criterion used to determine if the part is the same as another part. All checked criteria must be the same in order to be a “Matching Part” and will receive a matching item number. If any criteria are different, the part will get a unique number. When **unchecked**, the property will not be used to determine if it is a Matching Part.
    
    1.  **Note**: By default, the following parameters are excluded when checking for a match: Description, Item Number, Number, and Points.
        
    2.  **Note**: For Revit 2020 and newer identical parts receive matching item numbers for sleeves, saddles, or hangers along a pipe branch.
        
        1.  In this example, prior to the change, the Part Template property used for Item Numbering was Diameter. The 2 pipes (below) were the same diameter, but included sleeves and received non-matching item numbers.
            
        2.  With this change, the sleeves are ignored and the pipes with the same diameter receive matching item numbers.
            

### **Setup: Revit Property Parameter (Instance)**

For any Revit Property Parameter (Instance) published to Stratus, the parameter is exposed in Stratus and can be selected under Admin > Company > Part Templates > Template > Stratus Field and as a result, data can be pushed back into Revit.

1.  In a Revit model under Mange > Project Parameters, create one or more **Instance** parameters.
    
2.  In a Revit model under Mange > Project Parameters, create one or more **Instance** parameters, similar to the following, to be used in a Stratus Part Template.  
    **Note**: This feature will not work with a **Type** parameter.
    
3.  In this example, field parameters have been created for each data type.
    
4.  Once created, these parameters display in Revit.
    
5.  Publish the model so that these parameters are available in Stratus with Reports and Part Templates.
    

### **Setup: Fab Database**

For any Fab Database published to Stratus, the Custom Item Data field is exposed in Stratus and can be selected under Admin > Company > Part Templates > Template > Stratus Field and as a result, data will be pushed back into the Fab Database or be part of the MAJ file generated in Stratus.

1.  Add Custom Item Data fields as needed.
    
2.  Add Custom Item Data fields to the Takeoff > Customize Main Takeoff as needed.
    
3.  Publish the Fab Database using GTP Lightning.
    
4.  Publish the model that includes the Custom Item Data fields.
    

## Exclude Selected Part Properties During Publish

Part Properties can be excluded from being published and from being available in Stratus once they are published. This is especially useful when a third-party software has added hundreds of properties to parts in the model which significantly increases the publish time.

Notes about this feature:

-   Applies to AutoCAD, Revit parts, Fabrication parts in Revit.
    
-   A Part’s Properties are included in Stratus after a model containing the part property is published.
    
-   To prevent a part property from being published to Stratus, move the property to the Excluded list below.
    
-   If a part property has already been published to Stratus, it can be hidden from selection for Part Templates, Filters, Reports, Cut List Mappings, BOM Line Item Mappings, Aliases, and the API by moving the property to the Excluded list below.
    
-   Adding a part property to the Excluded list immediately hides the property in Stratus. If a mistake is made, simply move the part property to the Included list.
    
-   Part properties, like “Length”, cannot be excluded even if they are added to the Excluded list.
    
-   Some part properties, like “CenterLength”, are automatically injected on publish.
    

To use the **Part Property Names** dialog:

1.  Go to Admin > Company > Settings, to the **Part Property Names** dialog.
    
2.  Select any part properties that should not be published or display in Stratus, and then click the arrow that points to the **Excluded** list. Items added to the Excluded list will need to manually be saved by selecting the green Save button, and will then apply immediately in Stratus or on the next Publish.
    
    1.  **Note:**  Part Properties that display in the Included list will be published and will be available in Stratus to add to Part Templates, Filters, Reports, Cut List Mappings, BOM Line Item Mappings, Aliases, and the API. Part Properties that are in the Excluded list will not be published and will be hidden in Stratus.
        

## Revit Parts - Build Assembly for Nested Family 

The **Build Assembly for Nested Family** checkbox only displays when the Part Type selected is **Autodesk.Revit.DB.FamilyInstance**.

**Note:** A model that includes a shared nested family part must be published once before it will display on the Part Templates page. When checked, a published model will generate assemblies. When unchecked, assemblies will not be generated, however, any assemblies that were previously generated, when the checkbox was checked, will not be removed from the model.

For example:

1.  The model below includes the shared nested family GTP Trapeze - 2 Tier - 2 Rod which are not assemblies.
    
2.  After checking the **Build Assembly for Nested Family** button, publish the model again.
    
3.  The shared nested family GTP Trapeze - 2 Tier - 2 Rod has been converted into assemblies.
    

## Cut List Mappings

The Cut List Mappings tab under **Admin > Part Templates > Cut List Mappings** is used to create and manage Cut Lists. The Cut List Mappings tab is only enabled when a single part has been selected in the Parts table. A Cut List can be generated under **Package details > Cut List >** **Generate Cut Lists**. The Cut List Mappings dialog gives the administrator control over which parts are sent to fabrication tools (Ex. TigerStop, PypeServer, etc., and which are bought out.

## Configure Cut List Mappings

To configure a Cut List Mapping and to control the format of the Size and Length column displayed in the Packages > Cut List table:

1.  Go to **Admin > Company Part Templates > Cut List Mappings.**
    
2.  **Select a Part template** in the Parts dialog.
    
3.  Click the **Cut List Mapping tab**.
    
4.  **General**
    
    1.  **Consider for Cut Lists**
        
        1.  **Yes (Default)** – Indicates the selected part should be cut. Review the New Cut List Mapping section below.
            
        2.  **No** – Indicates the selected part will not be sent out as part of a cut list.
            
            1.  Example: Usually sufficient for Copper pipe or any of the Fabrication parts content which is already handled by the Package details > Cut List > Generate Cut List command. However, you can override the parameters used for Material, Size, Length (below).
                
            2.  Example: O-let components are typically purchased so a New Cut List Mapping does not need to be created.
                
5.  **Consider Fitting For Labels (Autodesk.Revit.DB.FamilyInstance Only)**
    
    1.  **Consider Fitting For Labels** is a Revit Part Family option and works in conjunction with the fitting1 and fitting2 Tool Label Template. The fitting1 and fitting2 label fields can be added to the Label Template of a TigerStop Tool and provide data about the next part in the spool when the assembly contains two parts: a straight pipe segment to be cut and a pipe fitting to put on the end of the cut pipe. The Consider Fitting For Labels option only displays when the Part Type is Autodesk.Revit.DB.FamilyInstance.
        
        1.  **Yes** - The part will be considered for labels.
            
        2.  **No** - The **Consider Fitting For Labels** setting needs to be set to “No” for part families like Welds for which you do not want to be included on the label as a next part. As a result, the Weld will be skipped and Stratus will look for the next part in the same assembly to add to the label.
            
    2.  **For example:**
        
        1.  The Tool’s Label Template would be configured for fitting1 and fitting2. See the [**Label Printing for Zebra (ZPL) Compatible Printers**](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/157974545 "https://gtpservices.atlassian.net/wiki/spaces/SK/pages/157974545") article for more information.
            
        2.  Under Admin > Company > **Part Templates**, locate a Part whose Part Type is Revit.DB.FamilyInstance, and then click the **Cut List Mappings** tab.
            
        3.  By default, the **Consider Fitting For Labels** setting is set to **Yes**. As a result, the next part in the assembly will be included on the label when fitting1 and fitting2 are included in the Label Template. If the next part is in the family “Pipe Fittings WeldBend CS SchSTD 90 Long Radius Elbow BWxBW” then it will be included on the label.
            
        4.  To not include a part family on the label as a fitting1 or fitting2 part, like a weld, set **Consider Fitting For Labels** to **No**. As a result, if the “Pipe Fittings WeldBend CS SchSTD Shop Weld Gap 0\_125” part is the next part in the assembly, it will be skipped, and Stratus will look for the next part in the assembly.
            
        5.  Below is an example of a label where Fitting 1 is an Elbow.  
            
            ![](blob:https://gtpservices.atlassian.net/6ff55663-a22a-4a51-a179-350f9d2264e3)
            

## Consider for Single-Axis Cut Lists

Used for tools like TigerStop to override mappings. This is useful when you want the cut list table to display a different property for Material, Size, Length or custom User Data.

1.  Click the **New Cut List Mapping** button if you have determined that a cut list mapping needs to be overridden.
    
    1.  **Material (Required)** – Map to a property name within the part that provides the part’s Material (Ex. Material).
        
    2.  **Size (Required)** - Map to a property name within the part that provides the part’s Size (Ex. Size, Description).
        
    3.  **Length (Required)** - Map to a property name within the part that provides the part’s Length (Ex. Length, Cut Length).
        
2.  Once saved when one of these parts is in a package and the **Generate Cut List** button is clicked on the Package details > Cut List tab:
    
    1.  If **Consider for Cut Lists** was set to **Yes or Default**, the selected part will display as a Cut List row (line item) and will include data associated with the mapped properties above.
        
    2.  If **Consider for Cut Lists** was set to No, the selected part will be filtered out of the Cut List and a row will not be added. Below, O-lets are filtered out.
        
3.  **Note:** For assemblies like a trapeze hanger, which might have 3 components (Rod side A, Rod side B, Strut). Click the **New Cut List Mapping** button to add a mapping for each component that will need to be configured for the part.
    
    **To control the format of the Size and Length column display in the Packages > Cut List table for Revit Family parts:**
    
4.  Select the cut list fields used for Material, Size, and Length.
    
5.  With the part selected, under Company Admin > Part Templates > Properties, set the Display Format for the Size and Length fields used for the Cut List Mapping. Below are 2 examples:
    
    1.  Fraction Feet/Inches
        
    2.  Double Precision Number
        
6.  On the Package's Cut Lists tab, click the **Generate Cut Lists**
    
    1.  Fraction Feet/Inches
        
    2.  Double Precision Number
        

## Consider for Multi-Axis Cut Lists

The part property template mappings for end types can be found in the **Consider for Multi-Axis Cut Lists** section of the **Cut List Mappings** tab under Admin > Company > Part Templates. These mappings are only used with Revit family content. The property mappings allow users to specify a part property that can be queried to determine if an end cut is beveled, grooved, etc. Note that Fabrication parts have the connector names built-in so parameter mappings are not necessary.

To use the mappings:

1.  Select a Part Template (left) and click the **Cut List Mappings** tab. The following will display for Revit family content.
    
2.  Note: \[Not Mapped\] and Default will use default mappings. In most cases, this will be correct.
    
3.  **Consider For Cut Lists** - Yes indicates the selected part will be included in the Cut List and No indicates it will not be included in the Cut List.
    
4.  Under the **Consider for Multi-Axis Cut Lists** section, mappings for Material, Size, Pipe Inside Diameter, Pipe Nominal Diameter, Pipe Outside Diameter, Pipe End 1 Connector Name, and Pipe End 2 Connector Name will allow users to specify names Revit family content.
    
    1.  Note: Single Axis Cut lists pertain to tools like TigerStop, not PypeServer.
        

### Revit Part Family Property Mappings for End Types 

Stratus allows Revit Pipes to “understand” their relative end connection types by querying the connected parts on either end. This is done through the mapping of Pipe Fittings and their connection types. Under the direction below we will be able to drive a pipe with two different connector types to a PypeServer (psvr) file. This can be generated in an assembly by sending the individual pipes to a tool or through the Package Cut List feature set. Below you will find the Revit parts being used in this exercise as well as the associated Part Templates and their End Mating Connector Name mappings:

#### Flange

#### Threaded Elbow

#### Tee

#### Buttweld

#### Threadolet

### Pipe Cuts Settings to Match the End Mating Connectors

The Pipe Cuts settings to match the End Mating Connectors specified in the Part Templates as follows:

### End Mating Connectors

The End Mating Connectors correlate to the connectors in the Pipe Fitting families as follows:

-   End 1 Mating Connector Name = Revit Connector 1
    
-   End 2 Mating Connector Name = Revit Connector 2
    
-   Other Mating Connector Names = Revit Connector 3+
    

### End Mating Connectors Corresponding PSVR file

Use either the Package’s Cut List tab or the Assemblies > Viewer > Send to Tool features to generate the corresponding PSVR file:

**Example 1:**

**Example1 PSVR File:**

**Example 2:**

Example 2 PSVR File - (Notice the indexed offset on the YStart for the hole):

## Configure Cut List Mappings userData Custom Label Fields

The userData1-9 custom data fields can display information on labels. For example, if you want to display a hanger’s offset on a label:

1.  Display the part’s **Properties** and identify the property that contains the data (Ex. Offset).
    
2.  Set userData1 under Admin > Company > Part Templates, select the Part Template, and click the Cut List Mapping tab. Click **New Cut List Mapping** if one does not exist. Click the **User Data 1** drop-down and select the property identified in step 1 (Ex. Offset).
    
3.  Edit the **Tool** template by adding userData1.
    
4.  Click the **Send the Cut List to the Station / Tool** under Packages > Package > Cut Lists. Alternatively, the Cut List labels can be printed by clicking the **Print Labels** button.
    
5.  Cut the part (or Print the Label) and the label displays with userData1 data.
    

## Configure Cut List Mappings userData Custom Label Fields for Calculated or Concatenated Field Expressions 

Field Expressions that include calculated or concatenated values can be used for Cut List Mapping userData1-9 custom data fields. For example, you could concatenate a property that displays the diameter (Ex. Diameter) with the type of hanger (Ex. Fabrication Fitting Description) to make a more concise field.

To concatenate 2 fields to create one custom data field and display the custom data field on a label:

1.  Display the part’s Properties and identify the properties that contain the data. In this case the Diameter and the Fabrication Fitting Description properties.
    
2.  **Create a new field** under Admin > Company > Fields:
    
    1.  **Data Type** = String
        
    2.  **Is Expression** = Checked
        
    3.  **Expression** = {Diameter}+' '+{Fabrication Fitting Description}
        
        1.  **Concatenation Syntax Note**: There is a space between ' '
            
3.  Add the Field to either User Data 1 to User Data 15 under Admin > Company > Part Templates, select the Part Template and click the Cut List Mapping tab. Click **New Cut List Mapping** if one does not exist. Click the User Data 1 or User Data 2 drop-down and select the property identified in step 2.
    
4.  Edit the **Tool** template by adding userData2.
    
5.  Click the **Send the Cut List to the Station / Tool** under Packages > Package > Cut Lists. Alternatively, the Cut List labels can be printed by clicking the **Print Labels** button.
    
6.  Cut the part (or Print the Label) and the label displays with userData2 data.
    
    1.  **Diameter** = 2”
        
    2.  **Fabrication Fitting Description** = Anvil Fig.260 Adjustable Clevis Hanger
        

## Cut List Mapping for Stub-Ins

To populate Stub-In pipe with CutLengthFeetAndInches:

1.  Under Admin > Company > Part Templates Cut List Mapping, select the Stub-In part (Ex. CID 2875)
    
2.  Click the **Cut List Mappings** tab and create (or edit an existing) a New Cut List Mapping in the Consider for Multi-Axis Cut Lists section.
    
    1.  **Size** = Diameter of the Branch
        
    2.  **Nominal Diameter** = Diameter of the Main
        
    3.  **Olet Type** = Saddle (for stub-ins)
        

## PypeServer Cut List

Please note, this section relating to PypeServer functionality is for testing purposes only. This functionality is not officially a part of our commercial offering, we will make a public announcement when it is.

A PypeServer Cut List can be generated as follows:

1.  **Setup PypeServer Tool** under Admin > Company > Tools setup a tool with type PypeServer.
    
2.  **Setup Station to use Tool** under Admin > Company > Station setup a new station to use the PypeServer tool from above.
    
3.  Generate a PypeServer Cut List .PSVR file:
    
    1.  Create a package that includes your PypeServer items.
        
    2.  Under Packages > Package Name > Cut Lists, click the Generate Cut Lists button. A cut list will display.
        
    3.  Change the Station to the PypeServer Shop created above.
        
    4.  Check the check box at the left.
        
    5.  Click **OK** on the Send Cut Lists dialog box.
        
    6.  Go to **Shops**, select the **Name of Station** above, and then click the **Tool**
        
    7.  Click the **Send to Tool** button.
        
    8.  A Save As box will display so that you can choose a save location for the .psvr file to use with PypeServer.
        

## BOM Line Item Mappings

The BOM Line Item Mappings tab controls the fields used to populate the BOM Line Item for each Part Template under Packages > Details > BOM > Generate New BOM. The BOM Line Item Mappings tab is only enabled when a single part has been selected in the Parts table. Changes to a BOM Line Item Mapping are made at the company level and are immediately applied to all projects.

## Control Data Used for Field Columns

To control the data used for the field column:

1.  Access the Company **BOM Line Item Mappings** by one of the following:
    
    1.  From the Packages > Details > BOM > tab, click the **BOM Mappings** gear icon.
        
        1.  A Company BOM Line Item Mappings dialog similar to the following will display. This is the same dialog as the Admin > Company > Part Templates > **BOM Line Item Mapping** tab (below).
            
    2.  Under Admin > Company > **Part Templates**, locate and select the Part, and then click the **BOM Line Item Mapping** tab. This is the same dialog as found under Packages > Details > BOM > tab, and clicking the **BOM Mappings** gear icon (above).
        
2.  Change values as needed to control the data pulled into the BOM for the selected Part Template. For example:
    
    1.  Nominal Stock Length - Enter the value of your nominal stock.
        
    2.  When editing a BOM Line Item Mapping, all line item fields are optional to edit.
        
3.  When done, return to the Packages > Details > BOM and click the Generate BOM button. Your changes will display.
    

## Exclude from BOM

To prevent or exclude items from displaying on the BOM under Packages > Details > BOM tab, do the following:

1.  For the part you want to exclude from the generated BOM, select the part in a viewer, and then click its Template Name.
    
2.  The **Part Template** page will display populated with the Template Name in the Search. Select the Part, click the BOM Mappings tab, and then check the **Exclude from BOM** checkbox.
    
3.  Open a package that contains the part where the Exclude from BOM checkbox was checked.
    
4.  Go to the Packages > Details > BOM tab and click the **Generate New BOM** button. The excluded item will not display in the BOM. Below, the search for hanger resulted in 0 items.
    

## Videos

## 08/19/2024 - Stratus Academy: ADM-504: Admin 2 - BOM

To take the **BOM** course, login to [**Stratus Academy**](https://academy.stratus.build/ "https://academy.stratus.build/") and and locate the course ADM-504: Admin 2 - BOM.

## 08/19/2024 - Stratus Academy: ADM-510: Admin 3 - Cut List

To take the **Cut List** course, login to [**Stratus Academy**](https://academy.stratus.build/ "https://academy.stratus.build/") and and locate the course ADM-510: Admin 3 - Cut List.

## 08/13/2020 - Using your TigerStop with Stratus!

<iframe allowfullscreen="" allowtransparency="true" data-hasbody="false" data-layout="default" data-local-id="847ffbbe-03eb-4b19-8dcf-cd78cb3909c3" data-macro-id="c7292d21-eb4b-42d7-b946-b678c3a3845f" data-macro-name="widget" frameborder="0" height="364" mozallowfullscreen="" webkitallowfullscreen="" width="640" src="https://player.vimeo.com/video/447847147?h=embed"></iframe>

00:00 Cut List Introduction  
01:22 Can Cut Tracking Status  
02:28 Generate Cut List for a Package - Package's Cut List tab  
03:35 Generate Cut List for a Part - Assembly Viewer  
04:29 Pipe - Part Templates > Cut List Mappings  
08:27 Hanger Rod - Part Templates > Cut List Mappings  
12:47 Tool and Station Setup  
13:54 Send Package Cut List to Station  
14:19 TigerStop Station and General Workstation Settings  
25:52 TigerStop Station and Filtering Projects, Models, Packages, Assemblies, Grouping  
24:52 TigerStop Station and TigerStop Workstation Settings  
27:46 Use the TigerStop Workstation for non-TigerStop workflows  
28:54 TigerStop Workstation Dynamic Nesting  
30:09 Labels for Different Tools

## 05/14/2020 – Part Templates;  What are they and how are they used?

<iframe allowfullscreen="" allowtransparency="true" data-hasbody="false" data-layout="default" data-local-id="5cfc6370-e0f2-4536-8aaa-4cea0f6a9017" data-macro-id="eef25d47-376f-4c86-996b-47e6af924aca" data-macro-name="widget" frameborder="0" height="364" mozallowfullscreen="" webkitallowfullscreen="" width="640" src="https://player.vimeo.com/video/418614008?h=embed"></iframe>

1:00 Part Definition Definition Slides  
3:00 Identify Template Name for a part  
3:40 Review a Part Template  
5:20 Configure Properties and Shared Properties  
6:40 Visible and Order  
9:00 Name and Display Name  
10:40 Editable  
11:55 Unit Label  
12:25 Display Format and Storage Format  
13:35 Item Number and Naming and Numbering Settings  
16:20 Cut List Mappings  
17:00 Consider For Cut Lists and Consider Fitting For Labels  
18:10 Consider for Single-Axis Cut Lists  
19:15 Consider for Multi-Axis Cut Lists  
20:10 Threadolet, Weldolet, Saddle and Pipe Cuts
---
created: 2025-06-25T06:27:05 (UTC -04:00)
tags: []
source: https://gtpservices.atlassian.net/wiki/spaces/SK/pages/201490457/Pipe+Cuts+Admin
author: 
---

# Pipe Cuts (Admin) - STRATUS Knowledge Base - Confluence

> ## Excerpt
> Stratus is integrated with PypeServer software and the Watts cutting machine so that a .PSVR file can be generated and exported from Stratus and imported into PypeServer.  PSVR works from the Package's Cut Lists where a separate cut list PSVR file is generated for each material-diameter combination. Configuration of PSVR output relies on Admin > Company > Pipe Cuts settings, where the company's o-let hole sizes, connector bevel angles, etc. are entered. PSVR cut list files are sent to a station configured for the PypeServer tool.  The process of downloading PSVR cut list files happens in the Shops > Station view. See the PypeServer article for more information.

---
Stratus is integrated with PypeServer software and the Watts cutting machine so that a .PSVR file can be generated and exported from Stratus and imported into PypeServer.  PSVR works from the Package's Cut Lists where a separate cut list PSVR file is generated for each material-diameter combination. Configuration of PSVR output relies on Admin > Company > Pipe Cuts settings, where the company's o-let hole sizes, connector bevel angles, etc. are entered. PSVR cut list files are sent to a station configured for the PypeServer tool.  The process of downloading PSVR cut list files happens in the Shops > Station view. See the [**PypeServer**](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/343769394 "https://gtpservices.atlassian.net/wiki/spaces/SK/pages/343769394") article for more information.

Note: PCF output also works with PypeServer, but will always be a manual file export and relies on setting managed on the PypeServer side.

The Pipe Cuts page describes the best practice configuration for AutoCAD and Revit and the Pipe Cuts configuration within Stratus. Pipe Cuts configuration is needed because it is difficult for PypeServer to determine whether a connector needs to be a bevel or plain angle cut. 

-   1 [Video](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/201490457/Pipe+Cuts+Admin#Video)
    -   1.1 [Stratus 09/03/2020 Implementation Webinar - Multi-Axis Pipe Cutter (26:40)](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/201490457/Pipe+Cuts+Admin#Stratus-09%2F03%2F2020-Implementation-Webinar---Multi-Axis-Pipe-Cutter-(26%3A40))
    -   1.2 [Stratus 05/09/19 Implementation Webinar (Pipe Cuts Webinar - 21:00)](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/201490457/Pipe+Cuts+Admin#Stratus-05%2F09%2F19-Implementation-Webinar-(Pipe-Cuts-Webinar---21%3A00))
-   2 [ITM Content Database](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/201490457/Pipe+Cuts+Admin#ITM-Content-Database) 
    -   2.1  [Wall Thickness](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/201490457/Pipe+Cuts+Admin#Wall-Thickness)
    -   2.2 [Precision](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/201490457/Pipe+Cuts+Admin#Precision)
-   3 [Stratus Pipe Cuts](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/201490457/Pipe+Cuts+Admin#Stratus-Pipe-Cuts)
    -   3.1 [Select Division](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/201490457/Pipe+Cuts+Admin#Select-Division)
    -   3.2 [Ends](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/201490457/Pipe+Cuts+Admin#Ends)
    -   3.3 [Saddles](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/201490457/Pipe+Cuts+Admin#Saddles)
    -   3.4 [Olets](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/201490457/Pipe+Cuts+Admin#Olets)

## Video

## Stratus 09/03/2020 Implementation Webinar - Multi-Axis Pipe Cutter (26:40)

<iframe allowfullscreen="" allowtransparency="true" data-hasbody="false" data-layout="default" data-local-id="afc2db19-ded2-4b5f-9437-b44c220c40b0" data-macro-id="6c64b2e2-44a5-4e18-9810-6cecdd631f83" data-macro-name="widget" frameborder="0" height="364" mozallowfullscreen="" webkitallowfullscreen="" width="640" src="https://player.vimeo.com/video/456608140?h=embed"></iframe>

02:05 Database Settings Fabrication CADMep  
04:34 Connectors  
05:28 What do I do if the model is drawn but doesn't have material information? UPDATEFROMSOURCE command  
06:49 Stratus Pipe Cuts  
08:55 RFA and Part Templates > Cut List Mapping  
11:20 Saddles, Olets, Connectors and Part Templates > Cut List Mapping  
16:37 RFA Saddles, Olets, Connectors Saddles  
17:39 Validate .PSVR File Data with [JSON Formatter](https://jsonformatter.curiousconcept.com/ "https://jsonformatter.curiousconcept.com/")  
20:25 Direct Integration .3DPP or PypeServer  
23:30 API Integration

## Stratus 05/09/19 Implementation Webinar (Pipe Cuts Webinar - 21:00)

<iframe allowfullscreen="" allowtransparency="true" data-hasbody="false" data-layout="default" data-local-id="efb29606-1636-48eb-821e-6b5f4b1aa689" data-macro-id="aa69f09c-bee3-4644-8f75-6af59257d554" data-macro-name="widget" frameborder="0" height="364" mozallowfullscreen="" webkitallowfullscreen="" width="640" src="https://player.vimeo.com/video/335229954?h=embed"></iframe>

## ITM Content Database 

For those who use ITM content, review your ITM library content for Wall Thickness and Precision which are required for PypeServer and 3DPP.

##  Wall Thickness

1.  Review a pipe like Std Carbon Steel.  
    
    ![](blob:https://gtpservices.atlassian.net/45c65ab8-b600-4fbe-aed5-f1e6e723418b)
    
2.  Open Piping Materials Specifications. In this example, Pipe OD is defined, but this level of setup does not provide the pipe wall thickness which is needed to drive the Watts or any of your 5-axis cutting machine. The pipe wall thickness is used to set the speed and burn rate of the cutting machine.    
    
    ![](blob:https://gtpservices.atlassian.net/e6f81c6a-a4cc-4d9b-aff8-533a382a2796)
    
3.  To set the pipe wall thickness, under Materials > Carbon Steel, indexing will display.  
    
    ![](blob:https://gtpservices.atlassian.net/90127e45-459c-49f8-a0ad-2707f241053e)
    
4.  Click Sch10, for example, and the Diameter, Pipe OD, and Pipe ID will display. The delta between the Pipe OD and Pipe ID is .5” total wall, .25” wall on 14” pipe. Stratus uses this delta when it generates the .PSVR file.  
    
    ![](blob:https://gtpservices.atlassian.net/4583d746-c903-423e-844c-c9c1f3491026)
    

## Precision

Verify that precision is 3 or higher else rounding will generate a very small inaccuracy in Stratus.

## Stratus Pipe Cuts

## Select Division

Pipe Cut Settings can be configured for more than one Division or shop. See the [**Division (Admin)**](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/103317524/Processor+Admin "https://gtpservices.atlassian.net/wiki/spaces/SK/pages/103317524/Processor+Admin") article for more information. If more than one shop Division has been created, select the Shop and then configure the Pipe Cuts for the shop. 

## Ends

The Ends section is used to determine if the type of connector. The Ends section maps each connector type, size, and and tells PypeServer the angle, root gap, and speed to cut. **Note**: An entry for a size without a connector name can be created which will be used when there is no match on connector name to any of the other entries for the particular size (or size range). If no entry with empty connector name exists, the first pipe cut end matched on size alone (and alphabetized by connector name) will be used for speed and root gap lookup.

**To configure a Connector:** 

1.  Click **New End**. A new row will display with pre-populated data. 
    
2.  **Nominal Size** = Enter the **Nominal Size** of the pipe. 
    
3.  **Connector Names** – Enter one connector name per row.
    
    1.  Determine the name of your Bevel Connectors. 
        
        1.  In Stratus, **select the pipe**, click the **Properties** tool, locate the connector, and then copy/paste this name into the Bevel Connector Names field.   
            
            ![](blob:https://gtpservices.atlassian.net/e6b49336-0ec8-48d4-9055-63475e08be4c)
            
    2.  Or, review your authoring software to determine your Bevel Connector Names. For example, this Butt-Weld is Bevel End 37.5. Copy/paste this name into the Bevel Connector Names field in Stratus.  
        
        ![](blob:https://gtpservices.atlassian.net/b15f7213-9017-4046-9ce8-744c50d2a342)
        
4.  **Angle** – Set the Angle associated with the Nominal Size and Connector Name. 
    
5.  **Root Gap** - The Root Gap is the gap between two connecting pipes and is specified when the gap is not modeled with a part so pipe cutting software can account for it during fabrication. The Root Gap column defaults to 0 and is exported within the PSVR file when the value is greater than zero. Root Gap does not impact cut lengths or reporting in Stratus. Root Gap values greater than 0 will be included in the exported file.
    
6.  **Speed** – For the row, set the appropriate speed for the equipment being used. 
    
7.  **Click Save**. 
    

## Saddles

A saddle is a fabricated tee created by joining two pipes directly together.  The main pipe has a hole cut in its side, the end of the branch pipe is “fish mouthed” (contoured to the shape of the main pipe), and then the two are joined together and welded. Define all nominal sizes in the Saddles section. 

**To configure a Saddle:** 

1.  Click the **New Saddle** button.   
    **Note:** When there are multiple Saddles and all column data is the same except for the Nominal Size, only enter one row that includes the largest Nominal Size. All smaller sizes will inherit the settings.
    
2.  **Nominal Size** = Enter the **Nominal Size** of the pipe. 
    
3.  **Calculated Diameter (Recommended)** – The Calculated Diameter calculation is preset to OD - (2 \* WT). This takes the pipe OD (Outside Diameter) and subtract 2 times the Wall Thickness which will result in the actual diameter to be cut or the ID (Inside Diameter).  
    
4.  **Use Override Diameter** – Leave unchecked if the shop is using the Calculated Diameter. When checked, the Use Override Diameter checkbox will override the Calculated Diameter and will use the Override Diameter value.  
    
5.  **Override Diameter** – Leave at 0 if the shop is using the Calculated Diameter.  For the nominal size, the Override Diameter is the diameter of the hole that needs to be cut into the pipe that it is going to mate into. When the **Use Override Diameter** is checked, the value entered in the Override Diameter will be used instead of reading the Calculated Diameter.  
    
6.  **Click Save**. Below is an example where the Nominal Size (24). All sizes that are “equal to or less than” the Nominal Sizes (Ex. 2.5) will automatically inherit the settings.  
    
    ![](blob:https://gtpservices.atlassian.net/8c396667-be58-41e3-8489-e08749ca8372)
    

## Olets

Olet configurations enable customization of the Threadolet, Sockolet, and Weldolet hole diameters. This way the Anvil hole diameter can be different than a Bonney Forge hole diameter. To provide flexibility, the Olet dialog is used to configure hole diameters used by your shop. 

**To configure an Olet:** 

1.  Click the **New Olet** button.  
    
2.  **Nominal Size** = Enter the **Nominal Size** of the pipe. 
    
3.  **Cooplet Hole Diameter** – Enter the hole diameter that will be cut into the mating pipe. 
    
4.  **Threadolet** **Hole Diameter** – Enter the hole diameter that will be cut into the mating pipe. 
    
5.  **Sockolet** **Hole Diameter** – Enter the hole diameter that will be cut into the mating pipe. 
    
6.  **Weldolet** **Hole Diameter** – Enter the hole diameter that will be cut into the mating pipe. 
    
7.  **Cut Surface** - The Cut Surface is the pipe diameter reference for olet hole cuts and may be either ID (inside diameter) or OD (outside diameter). The Cut Surface column defaults to OD and can be changed to ID. The value will be exported within the PSVR file. The Cut Surface value will be included in the exported file.
    
8.  **Repeat these steps** until all sizes cut in the shop have been listed. Below is an example.  
    
    ![](blob:https://gtpservices.atlassian.net/ee65193d-1743-4c25-ada0-a0076b4b8b80)
---
created: 2025-06-25T06:27:05 (UTC -04:00)
tags: []
source: https://gtpservices.atlassian.net/wiki/spaces/SK/pages/11534527/Project+Roles+Admin
author: 
---

# Project Roles (Admin) - STRATUS Knowledge Base - Confluence

> ## Excerpt
> Project Roles enable granular permissioning of Stratus features including menu items,  Filters, Divisions, Reports, and Tracking Statuses.  In order for a user other than the company administrator to login to Stratus, at least one project needs to be setup. The Project Admin role is configured out-of-the-box with all permissions and can be assigned to anyone. This section only needs to be considered when your company wants to differentiate project roles and permissions.

---
Project Roles enable granular permissioning of Stratus features including menu items,  Filters, Divisions, Reports, and Tracking Statuses.  In order for a user other than the company administrator to login to Stratus, at least one project needs to be setup. The Project Admin role is configured out-of-the-box with all permissions and can be assigned to anyone. This section only needs to be considered when your company wants to differentiate project roles and permissions.

**Note:** The ability for a user to view a package on the Packages Dashboard depends on having the correct Project Role for the Tracking Status, Package Category, and the Division associated with the package.

-   1 [Set Project Role Permissions](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/11534527/Project+Roles+Admin#Set-Project-Role-Permissions)
-   2 [Clone a Project Role](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/11534527/Project+Roles+Admin#Clone-a-Project-Role)
-   3 [Delete a Project Role](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/11534527/Project+Roles+Admin#Delete-a-Project-Role)
-   4 [Set a User's Project Role on a Project Team](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/11534527/Project+Roles+Admin#Set-a-User's-Project-Role-on-a-Project-Team)
-   5 [Summary of All Project Roles](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/11534527/Project+Roles+Admin#Summary-of-All-Project-Roles)
-   6 [Project Role Examples](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/11534527/Project+Roles+Admin#Project-Role-Examples)
    -   6.1 [Assemblies](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/11534527/Project+Roles+Admin#Assemblies)
        -   6.1.1 [Assemblies > Details > Viewer > Toolbar > Dimensioning](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/11534527/Project+Roles+Admin#Assemblies-%3E-Details-%3E-Viewer-%3E-Toolbar-%3E-Dimensioning)
        -   6.1.2 [Assemblies > Details > Viewer > Toolbar > Numbering and Tagging](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/11534527/Project+Roles+Admin#Assemblies-%3E-Details-%3E-Viewer-%3E-Toolbar-%3E-Numbering-and-Tagging)
    -   6.2 [Projects](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/11534527/Project+Roles+Admin#Projects)
        -   6.2.1 [Projects > Dashboard](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/11534527/Project+Roles+Admin#Projects-%3E-Dashboard)
            -   6.2.1.1 [Projects > Dashboard > Edit](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/11534527/Project+Roles+Admin#Projects-%3E-Dashboard-%3E-Edit)
            -   6.2.1.2 [Projects > Dashboard > View](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/11534527/Project+Roles+Admin#Projects-%3E-Dashboard-%3E-View)
    -   6.3 [Models](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/11534527/Project+Roles+Admin#Models)
        -   6.3.1 [Models > Dashboard](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/11534527/Project+Roles+Admin#Models-%3E-Dashboard)
            -   6.3.1.1 [Models > Dashboard > Dashboard](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/11534527/Project+Roles+Admin#Models-%3E-Dashboard-%3E-Dashboard)
            -   6.3.1.2 [Models > Dashboard > Delete Model and Data](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/11534527/Project+Roles+Admin#Models-%3E-Dashboard-%3E-Delete-Model-and-Data)
        -   6.3.2 [Models > Viewer > Actions](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/11534527/Project+Roles+Admin#Models-%3E-Viewer-%3E-Actions)
            -   6.3.2.1 [Models > Viewer > Actions > Areas](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/11534527/Project+Roles+Admin#Models-%3E-Viewer-%3E-Actions-%3E-Areas)
            -   6.3.2.2 [Models > Viewer > Actions > Assemblies](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/11534527/Project+Roles+Admin#Models-%3E-Viewer-%3E-Actions-%3E-Assemblies)
            -   6.3.2.3 [Models > Viewer > Actions > Attachments](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/11534527/Project+Roles+Admin#Models-%3E-Viewer-%3E-Actions-%3E-Attachments)
            -   6.3.2.4 [Models > Viewer > Actions > Categories](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/11534527/Project+Roles+Admin#Models-%3E-Viewer-%3E-Actions-%3E-Categories)
            -   6.3.2.5 [Models > Viewer > Actions > Packages](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/11534527/Project+Roles+Admin#Models-%3E-Viewer-%3E-Actions-%3E-Packages)
            -   6.3.2.6 [Models > Viewer > Actions > Reports](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/11534527/Project+Roles+Admin#Models-%3E-Viewer-%3E-Actions-%3E-Reports)
            -   6.3.2.7 [Models > Viewer > Actions > Tracking](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/11534527/Project+Roles+Admin#Models-%3E-Viewer-%3E-Actions-%3E-Tracking)
        -   6.3.3 [Models > Viewer > Display Mode](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/11534527/Project+Roles+Admin#Models-%3E-Viewer-%3E-Display-Mode)
            -   6.3.3.1 [Models > Viewer > Display Mode > Areas](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/11534527/Project+Roles+Admin#Models-%3E-Viewer-%3E-Display-Mode-%3E-Areas)
            -   6.3.3.2 [Models > Viewer > Display Mode > Assemblies](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/11534527/Project+Roles+Admin#Models-%3E-Viewer-%3E-Display-Mode-%3E-Assemblies)
            -   6.3.3.3 [Models > Viewer > Display Mode > Categories](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/11534527/Project+Roles+Admin#Models-%3E-Viewer-%3E-Display-Mode-%3E-Categories)
            -   6.3.3.4 [Models > Viewer > Display Mode > Containers](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/11534527/Project+Roles+Admin#Models-%3E-Viewer-%3E-Display-Mode-%3E-Containers)
            -   6.3.3.5 [Models > Viewer > Display Mode > Packages](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/11534527/Project+Roles+Admin#Models-%3E-Viewer-%3E-Display-Mode-%3E-Packages)
            -   6.3.3.6 [Models > Viewer > Display Mode > Purchasing](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/11534527/Project+Roles+Admin#Models-%3E-Viewer-%3E-Display-Mode-%3E-Purchasing)
            -   6.3.3.7 [Models > Viewer > Display Mode > Tracking](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/11534527/Project+Roles+Admin#Models-%3E-Viewer-%3E-Display-Mode-%3E-Tracking)
        -   6.3.4 [Models > Viewer > Filters](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/11534527/Project+Roles+Admin#Models-%3E-Viewer-%3E-Filters)
            -   6.3.4.1 [Models > Viewer > Filters  > Areas](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/11534527/Project+Roles+Admin#Models-%3E-Viewer-%3E-Filters--%3E-Areas)
        -   6.3.5 [Models > Viewer > Toolbar](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/11534527/Project+Roles+Admin#Models-%3E-Viewer-%3E-Toolbar)
            -   6.3.5.1 [Models > Viewer > Toolbar > Numbering](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/11534527/Project+Roles+Admin#Models-%3E-Viewer-%3E-Toolbar-%3E-Numbering)
                -   6.3.5.1.1 [Models > Viewer > Toolbar > Numbering > Bulk Delete](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/11534527/Project+Roles+Admin#Models-%3E-Viewer-%3E-Toolbar-%3E-Numbering-%3E-Bulk-Delete)
                -   6.3.5.1.2 [Models > Viewer > Toolbar > Tagging > Display](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/11534527/Project+Roles+Admin#Models-%3E-Viewer-%3E-Toolbar-%3E-Tagging-%3E-Display)
-   7 [Videos](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/11534527/Project+Roles+Admin#Videos)
    -   7.1 [08/19/2024 - Stratus Academy: ADM-512: Admin 3 - Project Roles](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/11534527/Project+Roles+Admin#08%2F19%2F2024---Stratus-Academy%3A-ADM-512%3A-Admin-3---Project-Roles)
    -   7.2 [02/25/2021 CSG Webinar: Setting Up Project Roles](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/11534527/Project+Roles+Admin#02%2F25%2F2021-CSG-Webinar%3A-Setting-Up-Project-Roles)
    -   7.3 [Stratus 07/16/2020 Implementation Webinar - Project Role Setup/Interface (13:15)](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/11534527/Project+Roles+Admin#Stratus-07%2F16%2F2020-Implementation-Webinar---Project-Role-Setup%2FInterface-(13%3A15))

A Project Role is a permission configuration that applies across all company projects. Only a user whose project role is Project Admin can configure project roles. The project role determines which dashboards, pages, features a user can access.  Stratus ships with project roles including Project Admin, Detailer, Project Manager, Shop Manager, Shop Work Field Manager, Field Worker, and each includes default values. These names can be edited, deleted, cloned, and new project roles can be created. Each user is assigned one project role and the Project Admin (project role) can create as many project roles as needed.

## Set Project Role Permissions

To set project role permissions:

1.  Login as a user who has Project Admin permission. **Note**: The user who first sets up a company account has the Project Admin project role by default. This can be changed later.
    
2.  Go to **Admin** > **Company** > **Project Roles**. The Project Roles configuration page displays. By default, no Project Roles will display, but the Project Admin role has access to everything and all other out-of-the-box roles have access to nothing.
    
3.  To display Project Roles, click the **Select Roles to Show (max 15)** button. Default Project Roles and Project Roles defined by your company will display.
    
4.  Check the Project Roles to view.
    
5.  The selected Project Roles will display for anyone who has permission to view this page.
    
6.  Project Roles columns can be moved left/right using the arrow buttons.
    
7.  Click the **Expand/Collapse All** button to Expand all parent/child Project Roles.
    
8.  For each project role, check the checkbox associated with the item to give permission to the item.
    
    1.  For example, if the Project Admin wants to give the Shop Worker access to Models > Viewer > Filters but not Display Mode, he can check Filters and all Filters will be checked, but Display Mode will not.
        
9.  Setting changes immediately impact Stratus users.
    

## Clone a Project Role

Use the Clone option to create a new project role that includes many of the same permissions as an existing project role.

To clone a Project Role:

1.  Under Admin > Company > Project Roles, under the Project Role column name, click the **Clone** button.
    
2.  The cloned column will display with the same name plus a number and includes everything checked in the original column. Move the column using the left right arrows above the project role name.
    
3.  Click the column header to rename the project role.
    

## Delete a Project Role

To delete a Project Role:

1.  Click the Delete button associated with the project role.
    
2.  The Delete dialog will display prompting you to select a role to re-assign users that have been assigned the project role being deleted. Select one and click OK.
    

## Set a User's Project Role on a Project Team

For each project, users of your company need to be added to a project team. And, for each project, each team member is assigned a Project Role. **Tip for managing user's project roles:** Users who have been assigned to a group under Admin > Company > Users can be quickly added to the team with a set project role. See the [**Users (Admin)**](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/201130058 "https://gtpservices.atlassian.net/wiki/spaces/SK/pages/201130058") article for more information.

To assign a user to a project team and set their project role for that team under **Admin** \> **Project** \> **Teams,** see the [**Team (Admin)**](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/217940256 "https://gtpservices.atlassian.net/wiki/spaces/SK/pages/217940256") article for more information.

## Summary of All Project Roles

<style><!--table {mso-displayed-decimal-separator:"\\."; mso-displayed-thousand-separator:"\\,";}@page { mso-header-data:""; mso-footer-data:""; margin:0.75in 0.7in 0.75in 0.7in; mso-header-margin:0.3in; mso-footer-margin:0.3in; mso-page-orientation:Portrait; }tr {mso-height-source:auto; mso-ruby-visibility:none;}col {mso-width-source:auto; mso-ruby-visibility:none;}br {mso-data-placement:same-cell;}ruby {ruby-align:left;}.style0 { mso-number-format:General; text-align:general; vertical-align:bottom; white-space:nowrap; background:auto; mso-pattern:auto; color:#000000; font-size:11pt; font-weight:400; font-style:normal; font-family:"Calibri","sans-serif"; border:none; mso-protection:locked visible; mso-style-name:Normal; mso-style-id:0;}.font0 { color:#000000; font-size:11pt; font-weight:400; font-style:normal; font-family:"Calibri","sans-serif"; }.font1 { color:#000000; font-size:10pt; font-weight:400; font-style:normal; font-family:"Arial","sans-serif"; }.font2 { color:#000000; font-size:11pt; font-weight:700; font-style:normal; font-family:"Calibri","sans-serif"; }td {mso-style-parent:style0; mso-number-format:General; text-align:general; vertical-align:bottom; white-space:nowrap; background:auto; mso-pattern:auto; color:#000000; font-size:11pt; font-weight:400; font-style:normal; font-family:"Calibri","sans-serif"; border:none; mso-protection:locked visible; mso-ignore:padding;}.style0 { text-align:general; vertical-align:bottom; white-space:nowrap; background:auto; mso-pattern:auto; color:#000000; font-size:11pt; font-weight:400; font-style:normal; font-family:"Calibri","sans-serif"; mso-protection:locked visible; mso-style-name:"Normal"; }.style1 { text-align:general; vertical-align:middle; white-space:nowrap; background:auto; mso-pattern:auto; color:#000000; font-size:10pt; font-weight:400; font-style:normal; font-family:"Arial","sans-serif"; mso-protection:locked visible; }.style2 { text-align:general; vertical-align:middle; white-space:nowrap; background:auto; mso-pattern:auto; color:#000000; font-size:10pt; font-weight:400; font-style:normal; font-family:"Arial","sans-serif"; mso-protection:locked visible; }.style3 { text-align:general; vertical-align:middle; white-space:nowrap; background:auto; mso-pattern:auto; color:#000000; font-size:10pt; font-weight:400; font-style:normal; font-family:"Arial","sans-serif"; mso-protection:locked visible; }.style4 { text-align:general; vertical-align:middle; white-space:nowrap; background:auto; mso-pattern:auto; color:#000000; font-size:10pt; font-weight:400; font-style:normal; font-family:"Arial","sans-serif"; mso-protection:locked visible; }.style5 { text-align:general; vertical-align:middle; white-space:nowrap; background:auto; mso-pattern:auto; color:#000000; font-size:10pt; font-weight:400; font-style:normal; font-family:"Arial","sans-serif"; mso-protection:locked visible; }.style6 { text-align:general; vertical-align:middle; white-space:nowrap; background:auto; mso-pattern:auto; color:#000000; font-size:10pt; font-weight:400; font-style:normal; font-family:"Arial","sans-serif"; mso-protection:locked visible; }.style7 { text-align:general; vertical-align:middle; white-space:nowrap; background:auto; mso-pattern:auto; color:#000000; font-size:10pt; font-weight:400; font-style:normal; font-family:"Arial","sans-serif"; mso-protection:locked visible; }.style8 { text-align:general; vertical-align:middle; white-space:nowrap; background:auto; mso-pattern:auto; color:#000000; font-size:10pt; font-weight:400; font-style:normal; font-family:"Arial","sans-serif"; mso-protection:locked visible; }.style9 { text-align:general; vertical-align:middle; white-space:nowrap; background:auto; mso-pattern:auto; color:#000000; font-size:10pt; font-weight:400; font-style:normal; font-family:"Arial","sans-serif"; mso-protection:locked visible; }.style10 { text-align:general; vertical-align:middle; white-space:nowrap; background:auto; mso-pattern:auto; color:#000000; font-size:10pt; font-weight:400; font-style:normal; font-family:"Arial","sans-serif"; mso-protection:locked visible; }.style11 { text-align:general; vertical-align:middle; white-space:nowrap; background:auto; mso-pattern:auto; color:#000000; font-size:10pt; font-weight:400; font-style:normal; font-family:"Arial","sans-serif"; mso-protection:locked visible; }.style12 { text-align:general; vertical-align:middle; white-space:nowrap; background:auto; mso-pattern:auto; color:#000000; font-size:10pt; font-weight:400; font-style:normal; font-family:"Arial","sans-serif"; mso-protection:locked visible; }.style13 { text-align:general; vertical-align:middle; white-space:nowrap; background:auto; mso-pattern:auto; color:#000000; font-size:10pt; font-weight:400; font-style:normal; font-family:"Arial","sans-serif"; mso-protection:locked visible; }.style14 { text-align:general; vertical-align:middle; white-space:nowrap; background:auto; mso-pattern:auto; color:#000000; font-size:10pt; font-weight:400; font-style:normal; font-family:"Arial","sans-serif"; mso-protection:locked visible; }.x15 { mso-style-parent:style0; mso-number-format:General; text-align:general; vertical-align:bottom; white-space:nowrap; background:auto; mso-pattern:auto; color:#000000; font-size:11pt; font-weight:400; font-style:normal; font-family:"Calibri","sans-serif"; mso-protection:locked visible; }.x16 { mso-style-parent:style0; mso-number-format:General; text-align:general; vertical-align:bottom; white-space:nowrap; background:auto; mso-pattern:auto; color:#000000; font-size:11pt; font-weight:400; font-style:normal; font-family:"Calibri","sans-serif"; border-top:1px solid windowtext; border-right:1px solid windowtext; border-bottom:1px solid windowtext; border-left:1px solid windowtext; mso-diagonal-down:none; mso-diagonal-up:none; mso-protection:locked visible; }.x17 { mso-style-parent:style0; mso-number-format:General; text-align:left; vertical-align:middle; white-space:nowrap; mso-char-indent-count:2; padding-left:24px; background:auto; mso-pattern:auto; color:#000000; font-size:11pt; font-weight:400; font-style:normal; font-family:"Calibri","sans-serif"; border-top:1px solid windowtext; border-right:1px solid windowtext; border-bottom:1px solid windowtext; border-left:1px solid windowtext; mso-diagonal-down:none; mso-diagonal-up:none; mso-protection:locked visible; }.x18 { mso-style-parent:style0; mso-number-format:General; text-align:left; vertical-align:middle; white-space:nowrap; mso-char-indent-count:3; padding-left:36px; background:auto; mso-pattern:auto; color:#000000; font-size:11pt; font-weight:400; font-style:normal; font-family:"Calibri","sans-serif"; border-top:1px solid windowtext; border-right:1px solid windowtext; border-bottom:1px solid windowtext; border-left:1px solid windowtext; mso-diagonal-down:none; mso-diagonal-up:none; mso-protection:locked visible; }.x19 { mso-style-parent:style0; mso-number-format:General; text-align:left; vertical-align:middle; white-space:nowrap; mso-char-indent-count:5; padding-left:60px; background:auto; mso-pattern:auto; color:#000000; font-size:11pt; font-weight:400; font-style:normal; font-family:"Calibri","sans-serif"; border-top:1px solid windowtext; border-right:1px solid windowtext; border-bottom:1px solid windowtext; border-left:1px solid windowtext; mso-diagonal-down:none; mso-diagonal-up:none; mso-protection:locked visible; }.x20 { mso-style-parent:style0; mso-number-format:General; text-align:left; vertical-align:middle; white-space:nowrap; mso-char-indent-count:6; padding-left:72px; background:auto; mso-pattern:auto; color:#000000; font-size:11pt; font-weight:400; font-style:normal; font-family:"Calibri","sans-serif"; border-top:1px solid windowtext; border-right:1px solid windowtext; border-bottom:1px solid windowtext; border-left:1px solid windowtext; mso-diagonal-down:none; mso-diagonal-up:none; mso-protection:locked visible; }.x21 { mso-style-parent:style0; mso-number-format:General; text-align:left; vertical-align:middle; white-space:nowrap; mso-char-indent-count:4; padding-left:48px; background:auto; mso-pattern:auto; color:#000000; font-size:11pt; font-weight:400; font-style:normal; font-family:"Calibri","sans-serif"; border-top:1px solid windowtext; border-right:1px solid windowtext; border-bottom:1px solid windowtext; border-left:1px solid windowtext; mso-diagonal-down:none; mso-diagonal-up:none; mso-protection:locked visible; }.x22 { mso-style-parent:style0; mso-number-format:General; text-align:left; vertical-align:middle; white-space:nowrap; mso-char-indent-count:1; padding-left:12px; background:auto; mso-pattern:auto; color:#000000; font-size:11pt; font-weight:400; font-style:normal; font-family:"Calibri","sans-serif"; border-top:1px solid windowtext; border-right:1px solid windowtext; border-bottom:1px solid windowtext; border-left:1px solid windowtext; mso-diagonal-down:none; mso-diagonal-up:none; mso-protection:locked visible; }.x23 { mso-style-parent:style0; mso-number-format:General; text-align:general; vertical-align:bottom; white-space:normal;word-wrap:break-word; background:auto; mso-pattern:auto; color:#000000; font-size:11pt; font-weight:400; font-style:normal; font-family:"Calibri","sans-serif"; border-top:1px solid windowtext; border-right:1px solid windowtext; border-bottom:1px solid windowtext; border-left:1px solid windowtext; mso-diagonal-down:none; mso-diagonal-up:none; mso-protection:locked visible; }.x24 { mso-style-parent:style0; mso-number-format:General; text-align:general; vertical-align:bottom; white-space:normal;word-wrap:break-word; background:auto; mso-pattern:auto; color:#000000; font-size:11pt; font-weight:400; font-style:normal; font-family:"Calibri","sans-serif"; mso-protection:locked visible; }.x25 { mso-style-parent:style0; mso-number-format:General; text-align:center; vertical-align:bottom; white-space:nowrap; background:auto; mso-pattern:auto; color:#000000; font-size:11pt; font-weight:700; font-style:normal; font-family:"Calibri","sans-serif"; border-top:1px solid windowtext; border-right:1px solid windowtext; border-bottom:1px solid windowtext; border-left:1px solid windowtext; mso-diagonal-down:none; mso-diagonal-up:none; mso-protection:locked visible; }.x26 { mso-style-parent:style0; mso-number-format:General; text-align:center; vertical-align:bottom; white-space:normal;word-wrap:break-word; background:auto; mso-pattern:auto; color:#000000; font-size:11pt; font-weight:700; font-style:normal; font-family:"Calibri","sans-serif"; border-top:1px solid windowtext; border-right:1px solid windowtext; border-bottom:1px solid windowtext; border-left:1px solid windowtext; mso-diagonal-down:none; mso-diagonal-up:none; mso-protection:locked visible; }--></style><div class="cells-worksheet" data-sheet-number="0" data-sheet-name="Sheet1"><table border="0" cellpadding="0" cellspacing="0" style="border-collapse:collapse;table-layout:fixed;width:622pt"> <colgroup> <col style="mso-width-source:userset;width:379px"></col> <col class="x24" style="mso-width-source:userset;background:none;width:451px"></col> </colgroup> <tbody> <tr style="mso-height-source:userset;height:15pt" id="r0"> <td class="x25" style="height:13.5pt;width:284.25pt">Project Role</td> <td class="x26" style="width:338.25pt">Checked Checkbox</td> </tr> <tr style="mso-height-source:userset;height:15pt" id="r1"> <td class="x16" style="height:13.5pt">Assemblies </td> <td class="x23">ALL Assemblies </td> </tr> <tr style="mso-height-source:userset;height:15pt" id="r2"> <td class="x16" style="height:13.5pt">Dashboard </td> <td class="x23">ALL Assemblies Dashboard </td> </tr> <tr style="mso-height-source:userset;height:15pt" id="r3"> <td class="x17" style="height:13.5pt">Attachments</td> <td class="x23">Allows Attachements button on dashboard to be visiable </td> </tr> <tr style="mso-height-source:userset;height:15pt" id="r4"> <td class="x17" style="height:13.5pt">Delete</td> <td class="x23">Displays Delete Column</td> </tr> <tr style="mso-height-source:userset;height:15pt" id="r5"> <td class="x17" style="height:13.5pt">Edit Assembly Properties</td> <td class="x23">Edit Assembly Name Column</td> </tr> <tr style="mso-height-source:userset;height:15pt" id="r6"> <td class="x17" style="height:13.5pt">Modify Packages</td> <td class="x23">Edit Packages Column</td> </tr> <tr style="mso-height-source:userset;height:15pt" id="r7"> <td class="x17" style="height:13.5pt">View</td> <td class="x23">Displays Dashboard Table </td> </tr> <tr style="mso-height-source:userset;height:15pt" id="r8"> <td class="x16" style="height:13.5pt">Details </td> <td class="x23">ALL Assemblies Details </td> </tr> <tr style="mso-height-source:userset;height:15pt" id="r9"> <td class="x17" style="height:13.5pt">Attachments</td> <td class="x23">Ability to see attachments tab in assemblies viewer </td> </tr> <tr style="mso-height-source:userset;height:15pt" id="r10"> <td class="x17" style="height:13.5pt">CAD Sheet</td> <td class="x23">Ability to See Cad Sheet in Assemblies Viewer </td> </tr> <tr style="mso-height-source:userset;height:15pt" id="r11"> <td class="x17" style="height:13.5pt">Notes</td> <td class="x23">Ability to See Notes in Assemblies Viewer </td> </tr> <tr style="mso-height-source:userset;height:15pt" id="r12"> <td class="x16" style="height:13.5pt">Parts </td> <td class="x23">Displays the Assemblies &gt; Parts tab.</td> </tr> <tr style="mso-height-source:userset;height:30pt" id="r13"> <td class="x18" style="height:28.5pt">Parts List</td> <td class="x23">Displays the Assemblies &gt; Parts list which includes the Send to Cut List to Tool button for parts.</td> </tr> <tr style="mso-height-source:userset;height:30pt" id="r14"> <td class="x18" style="height:28.5pt">Send Cut List to Tool</td> <td class="x23">Displays the Send to Cut List to Tool button for parts and the Send Checked to Tool button.</td> </tr> <tr style="mso-height-source:userset;height:15pt" id="r15"> <td class="x17" style="height:13.5pt">STRATUS Sheet</td> <td class="x23">Ability to See STRATUS Sheet in Assemblies Viewer </td> </tr> <tr style="mso-height-source:userset;height:15pt" id="r16"> <td class="x17" style="height:13.5pt">Tasks</td> <td class="x23">Ability to See Tasks in Assemblies Viewer </td> </tr> <tr style="mso-height-source:userset;height:15pt" id="r17"> <td class="x17" style="height:13.5pt">Tracking</td> <td class="x23">Ability to See Tasks in Assemblies Viewer </td> </tr> <tr style="mso-height-source:userset;height:15pt" id="r18"> <td class="x16" style="height:13.5pt">Viewer </td> <td class="x23">ALL Assemblies Viewer </td> </tr> <tr style="mso-height-source:userset;height:30pt" id="r19"> <td class="x18" style="height:28.5pt">Change Model View</td> <td class="x23">Allows visibilty to drop down setting to change madel view option in Assemblies view</td> </tr> <tr style="mso-height-source:userset;height:15pt" id="r20"> <td class="x18" style="height:13.5pt">Search and Scan Selector</td> <td class="x23">Controls avility to use search and scan selector </td> </tr> <tr style="mso-height-source:userset;height:15pt" id="r21"> <td class="x16" style="height:13.5pt">Toolbar </td> <td class="x23">ALL Assemblies Toolbar </td> </tr> <tr style="mso-height-source:userset;height:15pt" id="r22"> <td class="x16" style="height:13.5pt">Dimensioning </td> <td class="x23">ALL Assemblies Toolbar Dimensioning </td> </tr> <tr style="mso-height-source:userset;height:30pt" id="r23"> <td class="x19" style="height:28.5pt">Auto-Dimension</td> <td class="x23">The Run Auto-Dimension Routine tool will display and when clicked will dimension the parts in the viewer.</td> </tr> <tr style="mso-height-source:userset;height:30pt" id="r24"> <td class="x19" style="height:28.5pt">Bulk Delete</td> <td class="x23">The Delete All Dimensions tool will display and when clicked any existing dimensions will be deleted.</td> </tr> <tr style="mso-height-source:userset;height:45pt" id="r25"> <td class="x19" style="height:43.5pt">Delete Dimension</td> <td class="x23">The Delete Dimension icon (red x) will display within a dimension. When the mouse hovers over the dimension the user will be able to click the icon and delete the dimension.</td> </tr> <tr style="mso-height-source:userset;height:15pt" id="r26"> <td class="x19" style="height:13.5pt">Display</td> <td class="x23">Mush be checked to Display the Dimensioning tool.</td> </tr> <tr style="mso-height-source:userset;height:15pt" id="r27"> <td class="x19" style="height:13.5pt">Linear Beta</td> <td class="x23">The Linear Beta tool will display.</td> </tr> <tr style="mso-height-source:userset;height:75pt" id="r28"> <td class="x19" style="height:73.5pt">Move</td> <td class="x23">The Move icon (blue +) will display within a dimension. When the mouse hovers over the dimension the user will be able to click the icon and move the dimension. In addition, the Dimension Settings too (green wrench) displays which provides additional Click Detection settings.</td> </tr> <tr style="mso-height-source:userset;height:15pt" id="r29"> <td class="x19" style="height:13.5pt">Place Dimensions</td> <td class="x23">The Place Dimension flyout will display.</td> </tr> <tr style="mso-height-source:userset;height:15pt" id="r30"> <td class="x16" style="height:13.5pt">Display Mode </td> <td class="x23">ALL Assemblies Toolbar<span style="mso-spacerun:yes;font-family:&quot;Times New Roman&quot;">  </span>Display Mode<span style="mso-spacerun:yes;font-family:&quot;Times New Roman&quot;">  </span></td> </tr> <tr style="mso-height-source:userset;height:15pt" id="r31"> <td class="x19" style="height:13.5pt">Areas</td> <td class="x23">Allows Areas to be selected as a display mode </td> </tr> <tr style="mso-height-source:userset;height:30pt" id="r32"> <td class="x19" style="height:28.5pt">Assemblies</td> <td class="x23">This option does literally nothing since assemblies is not a display mode option in the assembly viewer </td> </tr> <tr style="mso-height-source:userset;height:15pt" id="r33"> <td class="x19" style="height:13.5pt">Categories</td> <td class="x23">Allows Catagories to be selected as a display mode </td> </tr> <tr style="mso-height-source:userset;height:15pt" id="r34"> <td class="x19" style="height:13.5pt">Purchasing</td> <td class="x23">Allows Purchasing to be selected as a display mode </td> </tr> <tr style="mso-height-source:userset;height:15pt" id="r35"> <td class="x19" style="height:13.5pt">Tracking</td> <td class="x23">Allows Tracking to be selected as a display mode </td> </tr> <tr style="mso-height-source:userset;height:15pt" id="r36"> <td class="x16" style="height:13.5pt">Filters </td> <td class="x23">ALL Assemblies Toolbar<span style="mso-spacerun:yes;font-family:&quot;Times New Roman&quot;">  </span>Filters </td> </tr> <tr style="mso-height-source:userset;height:15pt" id="r37"> <td class="x19" style="height:13.5pt">Areas</td> <td class="x23">Ability to use and see Areas Filter </td> </tr> <tr style="mso-height-source:userset;height:15pt" id="r38"> <td class="x19" style="height:13.5pt">Categories</td> <td class="x23">Ability to use and see Categories Filter </td> </tr> <tr style="mso-height-source:userset;height:15pt" id="r39"> <td class="x19" style="height:13.5pt">Company</td> <td class="x23">Ability to use and see Company Filter </td> </tr> <tr style="mso-height-source:userset;height:15pt" id="r40"> <td class="x19" style="height:13.5pt">Containers</td> <td class="x23">Ability to use and see Containers Filter </td> </tr> <tr style="mso-height-source:userset;height:15pt" id="r41"> <td class="x19" style="height:13.5pt">Levels</td> <td class="x23">Ability to use and see Levels Filter </td> </tr> <tr style="mso-height-source:userset;height:15pt" id="r42"> <td class="x19" style="height:13.5pt">Packages</td> <td class="x23">Ability to use and see Packages Filter </td> </tr> <tr style="mso-height-source:userset;height:15pt" id="r43"> <td class="x16" style="height:13.5pt">References </td> <td class="x23">ALL Assemblies Toolbar<span style="mso-spacerun:yes;font-family:&quot;Times New Roman&quot;">  </span>Filters References </td> </tr> <tr style="mso-height-source:userset;height:15pt" id="r44"> <td class="x20" style="height:13.5pt">Save</td> <td class="x23">Ability to save Refrences settings</td> </tr> <tr style="mso-height-source:userset;height:15pt" id="r45"> <td class="x20" style="height:13.5pt">View</td> <td class="x23">Ability to use and see Refrences Filter </td> </tr> <tr style="mso-height-source:userset;height:15pt" id="r46"> <td class="x19" style="height:13.5pt">Systems</td> <td class="x23">Ability to use and see Systems Filter </td> </tr> <tr style="mso-height-source:userset;height:15pt" id="r47"> <td class="x19" style="height:13.5pt">Tracking</td> <td class="x23">Ability to use and see Tracking Filter </td> </tr> <tr style="mso-height-source:userset;height:30pt" id="r48"> <td class="x21" style="height:28.5pt">Grid Offset Measurement and Grid Display</td> <td class="x23">Ability to use and see grid display and see/set grid offset measurements </td> </tr> <tr style="mso-height-source:userset;height:15pt" id="r49"> <td class="x16" style="height:13.5pt">Numbering </td> <td class="x23">ALL Assemblies Toolbar Numbering </td> </tr> <tr style="mso-height-source:userset;height:30pt" id="r50"> <td class="x19" style="height:28.5pt">Bulk Delete</td> <td class="x23">The Bulk Edit - Delete All Item Numbers and Tags tool will display and when clicked any existing numbers or tags will be deleted.</td> </tr> <tr style="mso-height-source:userset;height:30pt" id="r51"> <td class="x19" style="height:28.5pt">Custom Tags</td> <td class="x23">The Custom Tags tool will display and when clicked the Annotation Tags dialog will display.</td> </tr> <tr style="mso-height-source:userset;height:45pt" id="r52"> <td class="x19" style="height:43.5pt">Delete</td> <td class="x23">The delete tag icon (red x) will display within a item number or tag. When the mouse hovers over the item number or tag the user will be able to click the icon and delete the item number or tag.</td> </tr> <tr style="mso-height-source:userset;height:15pt" id="r53"> <td class="x19" style="height:13.5pt">Display</td> <td class="x23">Mush be checked to Display the Numbering tool.</td> </tr> <tr style="mso-height-source:userset;height:45pt" id="r54"> <td class="x19" style="height:43.5pt">Move</td> <td class="x23">The move tag icon (blue +) will display within a item number or tag. When the mouse hovers over the item number or tag the user will be able to click the icon and move the item number or tag.</td> </tr> <tr style="mso-height-source:userset;height:30pt" id="r55"> <td class="x19" style="height:28.5pt">Renumber</td> <td class="x23">The Renumber - All Item Numbers tool will display and when clicked any existing item numbers will be renumbered.</td> </tr> <tr style="mso-height-source:userset;height:15pt" id="r56"> <td class="x21" style="height:13.5pt">Properties</td> <td class="x23">Ability to see option to look at part properties </td> </tr> <tr style="mso-height-source:userset;height:15pt" id="r57"> <td class="x21" style="height:13.5pt">Spool Checker</td> <td class="x23">Ability to see and use spool checker </td> </tr> <tr style="mso-height-source:userset;height:15pt" id="r58"> <td class="x16" style="height:13.5pt">Company Filters </td> <td class="x23">ALL Company Filters </td> </tr> <tr style="mso-height-source:userset;height:15pt" id="r59"> <td class="x16" style="height:13.5pt;overflow:hidden">CSG \_ BOM \_ Mechanical Piping And Plumbing (Example)</td> <td class="x23">ALL Company Filters<span style="mso-spacerun:yes;font-family:&quot;Times New Roman&quot;">  </span>for Category </td> </tr> <tr style="mso-height-source:userset;height:15pt" id="r60"> <td class="x17" style="height:13.5pt">CSG \_ BOM \_ Pipework \_ Bolts And Gaskets<span style="mso-spacerun:yes;font-family:&quot;Times New Roman&quot;">  </span>(Example)</td> <td class="x23">Name - One for each Filter</td> </tr> <tr style="mso-height-source:userset;height:15pt" id="r61"> <td class="x16" style="height:13.5pt">Default </td> <td class="x23">ALL Company Filters<span style="mso-spacerun:yes;font-family:&quot;Times New Roman&quot;">  </span>for Category </td> </tr> <tr style="mso-height-source:userset;height:15pt" id="r62"> <td class="x17" style="height:13.5pt">QA\_Spool Present<span style="mso-spacerun:yes;font-family:&quot;Times New Roman&quot;">  </span>(Example)</td> <td class="x23">Name - One for each Filter</td> </tr> <tr style="mso-height-source:userset;height:15pt" id="r63"> <td class="x16" style="height:13.5pt">Containers </td> <td class="x23">ALL Containers </td> </tr> <tr style="mso-height-source:userset;height:15pt" id="r64"> <td class="x16" style="height:13.5pt">Assign </td> <td class="x23">ALL Containers Assign </td> </tr> <tr style="mso-height-source:userset;height:30pt" id="r65"> <td class="x17" style="height:28.5pt">Delete Tracking Log</td> <td class="x23">After using the Empty Container button to empty the container, a prompt will display to Delete and Start a New Tracking Log.</td> </tr> <tr style="mso-height-source:userset;height:30pt" id="r66"> <td class="x17" style="height:28.5pt">Empty Container</td> <td class="x23">Displays the Empty Container icon and the Ability to Empty the Container.</td> </tr> <tr style="mso-height-source:userset;height:15pt" id="r67"> <td class="x17" style="height:13.5pt">View</td> <td class="x23">This permission does not currently do anything.</td> </tr> <tr style="mso-height-source:userset;height:15pt" id="r68"> <td class="x22" style="height:13.5pt">Dashboard</td> <td class="x23">ALL Containers Dashboard </td> </tr> <tr style="mso-height-source:userset;height:15pt" id="r69"> <td class="x16" style="height:13.5pt">Desktop </td> <td class="x23">ALL Desktop </td> </tr> <tr style="mso-height-source:userset;height:15pt" id="r70"> <td class="x22" style="height:13.5pt">Publish</td> <td class="x23">Access to be able to publish on add in </td> </tr> <tr style="mso-height-source:userset;height:15pt" id="r71"> <td class="x16" style="height:13.5pt">Divisions </td> <td class="x23">Displays the Containers Dashboard.</td> </tr> <tr style="mso-height-source:userset;height:15pt" id="r72"> <td class="x22" style="height:13.5pt"> \[No Division\]</td> <td class="x23">Default Division</td> </tr> <tr style="mso-height-source:userset;height:15pt" id="r73"> <td class="x22" style="height:13.5pt"> Shop East (Example)</td> <td class="x23">Name - One for each Division</td> </tr> <tr style="mso-height-source:userset;height:15pt" id="r74"> <td class="x16" style="height:13.5pt">Field </td> <td class="x23">ALL Divisions Field </td> </tr> <tr style="mso-height-source:userset;height:15pt" id="r75"> <td class="x17" style="height:13.5pt">Field - Hangers And Supports<span style="mso-spacerun:yes;font-family:&quot;Times New Roman&quot;">  </span>(Example)</td> <td class="x23">Name - One for each Field &gt; Division</td> </tr> <tr style="mso-height-source:userset;height:15pt" id="r76"> <td class="x16" style="height:13.5pt">Office </td> <td class="x23">ALL Divisions Office </td> </tr> <tr style="mso-height-source:userset;height:15pt" id="r77"> <td class="x17" style="height:13.5pt">Office - Project Management And VDC (Example)</td> <td class="x23">Name - One for each Office &gt; Division</td> </tr> <tr style="mso-height-source:userset;height:15pt" id="r78"> <td class="x16" style="height:13.5pt">Purchasing </td> <td class="x23">ALL Divisions Purchasing<span style="mso-spacerun:yes;white-space:nowrap;font-family:&quot;Times New Roman&quot;">  </span></td> </tr> <tr style="mso-height-source:userset;height:15pt" id="r79"> <td class="x17" style="height:13.5pt">Purchasing - Purchasing (Example)</td> <td class="x23">Name - One for each Purchasing &gt; Division</td> </tr> <tr style="mso-height-source:userset;height:15pt" id="r80"> <td class="x16" style="height:13.5pt">Shop </td> <td class="x23">ALL Divisions Shop </td> </tr> <tr style="mso-height-source:userset;height:15pt" id="r81"> <td class="x17" style="height:13.5pt">Shop - Hangers And Supports (Example)</td> <td class="x23">Name - One for each Shop &gt; Division</td> </tr> <tr style="mso-height-source:userset;height:15pt" id="r82"> <td class="x16" style="height:13.5pt">Jobsites </td> <td class="x23">ALL Jobsites </td> </tr> <tr style="mso-height-source:userset;height:15pt" id="r83"> <td class="x22" style="height:13.5pt">Dashboard</td> <td class="x23">Ability to see jobsite dashboard </td> </tr> <tr style="mso-height-source:userset;height:15pt" id="r84"> <td class="x16" style="height:13.5pt">Station </td> <td class="x23">ALL Jobsites Station </td> </tr> <tr style="mso-height-source:userset;height:15pt" id="r85"> <td class="x17" style="height:13.5pt">Tasks</td> <td class="x23">Ability to access station tasks </td> </tr> <tr style="mso-height-source:userset;height:15pt" id="r86"> <td class="x17" style="height:13.5pt">Tool</td> <td class="x23">Ability to access station tools </td> </tr> <tr style="mso-height-source:userset;height:15pt" id="r87"> <td class="x16" style="height:13.5pt">Models </td> <td class="x23">ALL Models </td> </tr> <tr style="mso-height-source:userset;height:15pt" id="r88"> <td class="x16" style="height:13.5pt">Dashboard </td> <td class="x23">ALL Models Dashboard </td> </tr> <tr style="mso-height-source:userset;height:15pt" id="r89"> <td class="x17" style="height:13.5pt">Dashboard</td> <td class="x23">Permission to view the Models &gt; Dashboard.</td> </tr> <tr style="mso-height-source:userset;height:15pt" id="r90"> <td class="x17" style="height:13.5pt">Delete Model and Data</td> <td class="x23">Permission to Delete the model.</td> </tr> <tr style="mso-height-source:userset;height:15pt" id="r91"> <td class="x16" style="height:13.5pt">Viewer </td> <td class="x23">ALL Models Viewer </td> </tr> <tr style="mso-height-source:userset;height:45pt" id="r92"> <td class="x16" style="height:43.5pt">Actions </td> <td class="x23">ALL Models Viewer Actions<br />Unless one of the following Actions are checked, the Models &gt; Viewer tab will not display.</td> </tr> <tr style="mso-height-source:userset;height:30pt" id="r93"> <td class="x18" style="height:28.5pt">Areas</td> <td class="x23">Toolbar permission for Actions and Window Select. <br />Toolbar permission for Actions &gt; Areas.</td> </tr> <tr style="mso-height-source:userset;height:30pt" id="r94"> <td class="x18" style="height:28.5pt">Assemblies</td> <td class="x23">Toolbar permission for Actions and Window Select. <br />Toolbar permission for Actions &gt; Assemblies.</td> </tr> <tr style="mso-height-source:userset;height:30pt" id="r95"> <td class="x18" style="height:28.5pt">Attachments</td> <td class="x23">Toolbar permission for Actions and Window Select.<br />Toolbar permission for Actions &gt; Attachment.</td> </tr> <tr style="mso-height-source:userset;height:30pt" id="r96"> <td class="x18" style="height:28.5pt">Categories</td> <td class="x23">Toolbar permission for Actions and Window Select.<br />Toolbar permission for Actions &gt; Categories.</td> </tr> <tr style="mso-height-source:userset;height:165pt" id="r97"> <td class="x18" style="height:163.5pt">Packages</td> <td class="x23">Prerequisite Permissions:<br />Category - Permission to one or more more Packages &gt; Categories.<br />Division - Permission to one or more more Divisions, if company is using Divisions.<br />Areas - Permission to Models &gt; Viewer &gt; Actions &gt; Areas to populate and select BIM Areas.<br />Attachments - Permission to Packages &gt; Details &gt; Attachments<br />Properties - Permission to Packages &gt; Details &gt; Items &gt; Properties<br />Gives Permission to:<br />Toolbar permission for Actions and Window Select.<br />Toolbar permission for Actions &gt; Packages.</td> </tr> <tr style="mso-height-source:userset;height:30pt" id="r98"> <td class="x18" style="height:28.5pt">Reports</td> <td class="x23">Toolbar permission for Actions and Window Select.<br />Toolbar permission for Actions &gt; Reports.</td> </tr> <tr style="mso-height-source:userset;height:30pt" id="r99"> <td class="x18" style="height:28.5pt">Tracking</td> <td class="x23">Toolbar permission for Actions and Window Select.<br />Toolbar permission for Actions &gt; Tracking.</td> </tr> <tr style="mso-height-source:userset;height:15pt" id="r100"> <td class="x16" style="height:13.5pt">Display Mode </td> <td class="x23">ALL Models Viewer Display Mode </td> </tr> <tr style="mso-height-source:userset;height:15pt" id="r101"> <td class="x18" style="height:13.5pt">Areas</td> <td class="x23">Access to Areas Display tab</td> </tr> <tr style="mso-height-source:userset;height:15pt" id="r102"> <td class="x18" style="height:13.5pt">Assemblies</td> <td class="x23">Access to Areas Assemblies tab</td> </tr> <tr style="mso-height-source:userset;height:15pt" id="r103"> <td class="x18" style="height:13.5pt">Categories</td> <td class="x23">Access to Areas Categories tab</td> </tr> <tr style="mso-height-source:userset;height:15pt" id="r104"> <td class="x18" style="height:13.5pt">Packages</td> <td class="x23">Access to Areas Packages tab</td> </tr> <tr style="mso-height-source:userset;height:15pt" id="r105"> <td class="x18" style="height:13.5pt">Purchasing</td> <td class="x23">Access to Areas Purchasing tab</td> </tr> <tr style="mso-height-source:userset;height:15pt" id="r106"> <td class="x18" style="height:13.5pt">Tracking</td> <td class="x23">Access to Areas Tracking tab</td> </tr> <tr style="mso-height-source:userset;height:15pt" id="r107"> <td class="x16" style="height:13.5pt">Filters </td> <td class="x23">ALL Models Viewer Filters </td> </tr> <tr style="mso-height-source:userset;height:15pt" id="r108"> <td class="x18" style="height:13.5pt">Areas</td> <td class="x23">Access to Areas Display tab</td> </tr> <tr style="mso-height-source:userset;height:15pt" id="r109"> <td class="x18" style="height:13.5pt">Assemblies</td> <td class="x23">Access to Assemblies Display tab</td> </tr> <tr style="mso-height-source:userset;height:15pt" id="r110"> <td class="x18" style="height:13.5pt">Categories</td> <td class="x23">Access to Categories Display tab</td> </tr> <tr style="mso-height-source:userset;height:15pt" id="r111"> <td class="x18" style="height:13.5pt">Company</td> <td class="x23">Access to Company Display tab</td> </tr> <tr style="mso-height-source:userset;height:15pt" id="r112"> <td class="x18" style="height:13.5pt">Containers</td> <td class="x23">Access to Containers Display tab</td> </tr> <tr style="mso-height-source:userset;height:15pt" id="r113"> <td class="x18" style="height:13.5pt">Levels</td> <td class="x23">Access to levels Display tab</td> </tr> <tr style="mso-height-source:userset;height:15pt" id="r114"> <td class="x18" style="height:13.5pt">Packages</td> <td class="x23">Access to Packages Display tab</td> </tr> <tr style="mso-height-source:userset;height:15pt" id="r115"> <td class="x18" style="height:13.5pt">Purchasing</td> <td class="x23">Access to Purchasing Display tab</td> </tr> <tr style="mso-height-source:userset;height:15pt" id="r116"> <td class="x16" style="height:13.5pt">References </td> <td class="x23">ALL Models Viewer Filters References </td> </tr> <tr style="mso-height-source:userset;height:15pt" id="r117"> <td class="x21" style="height:13.5pt">Save</td> <td class="x23">Ability to make and save refreences </td> </tr> <tr style="mso-height-source:userset;height:15pt" id="r118"> <td class="x21" style="height:13.5pt">View</td> <td class="x23">Ability to see made refrences </td> </tr> <tr style="mso-height-source:userset;height:15pt" id="r119"> <td class="x18" style="height:13.5pt">Systems</td> <td class="x23">Ability to access systems filter</td> </tr> <tr style="mso-height-source:userset;height:15pt" id="r120"> <td class="x18" style="height:13.5pt">Tracking</td> <td class="x23">Ability to access Tracking filter </td> </tr> <tr style="mso-height-source:userset;height:15pt" id="r121"> <td class="x17" style="height:13.5pt">Search and Scan Selector</td> <td class="x23">Ability to see and use search and scan selector </td> </tr> <tr style="mso-height-source:userset;height:15pt" id="r122"> <td class="x16" style="height:13.5pt">Toolbar </td> <td class="x23">ALL Models Toolbar </td> </tr> <tr style="mso-height-source:userset;height:15pt" id="r123"> <td class="x18" style="height:13.5pt">Grid Offset Measurement and Grid Display</td> <td class="x23">Ability to see and use Grid display and offsett measurements </td> </tr> <tr style="mso-height-source:userset;height:15pt" id="r124"> <td class="x16" style="height:13.5pt">Numbering </td> <td class="x23">ALL Models Toolbar Numbering </td> </tr> <tr style="mso-height-source:userset;height:15pt" id="r125"> <td class="x21" style="height:13.5pt">Display</td> <td class="x23">Mush be checked to Display the Numbering tool.</td> </tr> <tr style="mso-height-source:userset;height:30pt" id="r126"> <td class="x21" style="height:28.5pt">Bulk Delete</td> <td class="x23">The Bulk Edit - Delete All Item Numbers and Tags tool will display and when clicked any existing numbers or tags will be deleted.</td> </tr> <tr style="mso-height-source:userset;height:30pt" id="r127"> <td class="x21" style="height:28.5pt">Custom Tags</td> <td class="x23">The Custom Tags tool will display and when clicked the Annotation Tags dialog will display.</td> </tr> <tr style="mso-height-source:userset;height:45pt" id="r128"> <td class="x21" style="height:43.5pt">Delete</td> <td class="x23">The delete tag icon (red x) will display within a item number or tag. When the mouse hovers over the item number or tag the user will be able to click the icon and delete the item number or tag.</td> </tr> <tr style="mso-height-source:userset;height:45pt" id="r129"> <td class="x21" style="height:43.5pt">Move</td> <td class="x23">The move tag icon (blue +) will display within a item number or tag. When the mouse hovers over the item number or tag the user will be able to click the icon and move the item number or tag.</td> </tr> <tr style="mso-height-source:userset;height:30pt" id="r130"> <td class="x21" style="height:28.5pt">Renumber</td> <td class="x23">The Renumber - All Item Numbers tool will display and when clicked any existing item numbers will be renumbered.</td> </tr> <tr style="mso-height-source:userset;height:15pt" id="r131"> <td class="x18" style="height:13.5pt">Properties</td> <td class="x23">to see and use properties on toolbar </td> </tr> <tr style="mso-height-source:userset;height:15pt" id="r132"> <td class="x18" style="height:13.5pt">Select Connected</td> <td class="x23">Ability to see and use select connected on toolbar </td> </tr> <tr style="mso-height-source:userset;height:15pt" id="r133"> <td class="x16" style="height:13.5pt">Packages </td> <td class="x23">ALL Packages </td> </tr> <tr style="mso-height-source:userset;height:15pt" id="r134"> <td class="x16" style="height:13.5pt">Categories </td> <td class="x23">ALL Packages Categories </td> </tr> <tr style="mso-height-source:userset;height:30pt" id="r135"> <td class="x17" style="height:28.5pt">Deck Activities (Example)</td> <td class="x23">Option to select certain package categories to see instead of all of them </td> </tr> <tr style="mso-height-source:userset;height:15pt" id="r136"> <td class="x16" style="height:13.5pt">Dashboard </td> <td class="x23">ALL Packages Dashboard </td> </tr> <tr style="mso-height-source:userset;height:15pt" id="r137"> <td class="x17" style="height:13.5pt">Archive</td> <td class="x23">Able to archive packages in the dashboard</td> </tr> <tr style="mso-height-source:userset;height:15pt" id="r138"> <td class="x17" style="height:13.5pt">Dashboard Table</td> <td class="x23">Access to see dashboard</td> </tr> <tr style="mso-height-source:userset;height:15pt" id="r139"> <td class="x17" style="height:13.5pt">Delete</td> <td class="x23">Ability to delete package from dashboard </td> </tr> <tr style="mso-height-source:userset;height:15pt" id="r140"> <td class="x17" style="height:13.5pt">GenerateMaj</td> <td class="x23">Ability to generate maj from dashboard </td> </tr> <tr style="mso-height-source:userset;height:15pt" id="r141"> <td class="x17" style="height:13.5pt">GeneratePcf</td> <td class="x23">Ability to generate pcf from dashboard </td> </tr> <tr style="mso-height-source:userset;height:30pt" id="r142"> <td class="x17" style="height:28.5pt">New Package</td> <td class="x23">Ability to make new packages with dashbaord new package button also toggles visibility </td> </tr> <tr style="mso-height-source:userset;height:15pt" id="r143"> <td class="x16" style="height:13.5pt">Details </td> <td class="x23">ALL Packages Details </td> </tr> <tr style="mso-height-source:userset;height:15pt" id="r144"> <td class="x17" style="height:13.5pt">Attachments</td> <td class="x23">Ability to add attachments and attachments button visibility </td> </tr> <tr style="mso-height-source:userset;height:15pt" id="r145"> <td class="x16" style="height:13.5pt">Bill of Materials </td> <td class="x23">ALL Packages Details BOM </td> </tr> <tr style="mso-height-source:userset;height:15pt" id="r146"> <td class="x18" style="height:13.5pt">BOM</td> <td class="x23">Access to view BOM </td> </tr> <tr style="mso-height-source:userset;height:15pt" id="r147"> <td class="x18" style="height:13.5pt">BOM &amp; Modify Inline Fields</td> <td class="x23">Ability to View BOM and change items in made BOM</td> </tr> <tr style="mso-height-source:userset;height:15pt" id="r148"> <td class="x17" style="height:13.5pt">CAD Sheet</td> <td class="x23">Access to Cad sheet deatils tab</td> </tr> <tr style="mso-height-source:userset;height:15pt" id="r149"> <td class="x17" style="height:13.5pt">Cut Lists</td> <td class="x23">Access to cut list details tab</td> </tr> <tr style="mso-height-source:userset;height:15pt" id="r150"> <td class="x16" style="height:13.5pt">Items </td> <td class="x23">ALL Packages Details Items </td> </tr> <tr style="mso-height-source:userset;height:30pt" id="r151"> <td class="x18" style="height:28.5pt">Attachments</td> <td class="x23">Ability to add attachments and attachments button visibility on items list </td> </tr> <tr style="mso-height-source:userset;height:15pt" id="r152"> <td class="x18" style="height:13.5pt">Edit</td> <td class="x23">Ability to edit items on items list</td> </tr> <tr style="mso-height-source:userset;height:15pt" id="r153"> <td class="x18" style="height:13.5pt">Lightning Catalog</td> <td class="x23"></td> </tr> <tr style="mso-height-source:userset;height:15pt" id="r154"> <td class="x18" style="height:13.5pt">Modify Packages</td> <td class="x23">Ability to modify packages through items list </td> </tr> <tr style="mso-height-source:userset;height:15pt" id="r155"> <td class="x18" style="height:13.5pt">Remove</td> <td class="x23">Ability to remove items through items list</td> </tr> <tr style="mso-height-source:userset;height:15pt" id="r156"> <td class="x18" style="height:13.5pt">View</td> <td class="x23">Ability to view items tab in details </td> </tr> <tr style="mso-height-source:userset;height:15pt" id="r157"> <td class="x17" style="height:13.5pt">Notes</td> <td class="x23">Ability to view notes </td> </tr> <tr style="mso-height-source:userset;height:15pt" id="r158"> <td class="x17" style="height:13.5pt">Point Lists</td> <td class="x23">Ability to view points list </td> </tr> <tr style="mso-height-source:userset;height:15pt" id="r159"> <td class="x17" style="height:13.5pt">Properties</td> <td class="x23">Ability to view package properties tab</td> </tr> <tr style="mso-height-source:userset;height:15pt" id="r160"> <td class="x16" style="height:13.5pt">Tasks </td> <td class="x23">ALL Packages Details Tasks </td> </tr> <tr style="mso-height-source:userset;height:15pt" id="r161"> <td class="x18" style="height:13.5pt">Delete Tasks</td> <td class="x23">Ability to delete tasks </td> </tr> <tr style="mso-height-source:userset;height:15pt" id="r162"> <td class="x18" style="height:13.5pt">Task Board</td> <td class="x23">Ability to view task board </td> </tr> <tr style="mso-height-source:userset;height:15pt" id="r163"> <td class="x17" style="height:13.5pt">Tracking</td> <td class="x23">Ability to view package tracking </td> </tr> <tr style="mso-height-source:userset;height:15pt" id="r164"> <td class="x16" style="height:13.5pt">Viewer </td> <td class="x23">ALL Packages Details Viewer </td> </tr> <tr style="mso-height-source:userset;height:15pt" id="r165"> <td class="x18" style="height:13.5pt">Change Model View</td> <td class="x23">Ability to change model view from drop down</td> </tr> <tr style="mso-height-source:userset;height:15pt" id="r166"> <td class="x18" style="height:13.5pt">Search and Scan Selector</td> <td class="x23">Ability to use scan and search selector for view </td> </tr> <tr style="mso-height-source:userset;height:15pt" id="r167"> <td class="x18" style="height:13.5pt">STRATUS Sheet</td> <td class="x23">Ability to see STRATUS sheet tab</td> </tr> <tr style="mso-height-source:userset;height:15pt" id="r168"> <td class="x16" style="height:13.5pt">Toolbar </td> <td class="x23">ALL Packages Details Viewer Toolbar </td> </tr> <tr style="mso-height-source:userset;height:15pt" id="r169"> <td class="x16" style="height:13.5pt">Actions </td> <td class="x23">ALL Packages Details Viewer Toolbar Actions </td> </tr> <tr style="mso-height-source:userset;height:30pt" id="r170"> <td class="x19" style="height:28.5pt">Areas</td> <td class="x23">Toolbar permission for Actions and Window Select. <br />Toolbar permission for Actions &gt; Areas.</td> </tr> <tr style="mso-height-source:userset;height:30pt" id="r171"> <td class="x19" style="height:28.5pt">Assemblies</td> <td class="x23">Toolbar permission for Actions and Window Select. <br />Toolbar permission for Actions &gt; Assemblies.</td> </tr> <tr style="mso-height-source:userset;height:30pt" id="r172"> <td class="x19" style="height:28.5pt">Attachments</td> <td class="x23">Toolbar permission for Actions and Window Select.<br />Toolbar permission for Actions &gt; Attachment.</td> </tr> <tr style="mso-height-source:userset;height:30pt" id="r173"> <td class="x19" style="height:28.5pt">Categories</td> <td class="x23">Toolbar permission for Actions and Window Select.<br />Toolbar permission for Actions &gt; Categories.</td> </tr> <tr style="mso-height-source:userset;height:165pt" id="r174"> <td class="x19" style="height:163.5pt">Packages</td> <td class="x23">Prerequisite Permissions:<br />Category - Permission to one or more more Packages &gt; Categories.<br />Division - Permission to one or more more Divisions, if company is using Divisions.<br />Areas - Permission to Models &gt; Viewer &gt; Actions &gt; Areas to populate and select BIM Areas.<br />Attachments - Permission to Packages &gt; Details &gt; Attachments<br />Properties - Permission to Packages &gt; Details &gt; Items &gt; Properties<br />Gives Permission to:<br />Toolbar permission for Actions and Window Select.<br />Toolbar permission for Actions &gt; Packages.</td> </tr> <tr style="mso-height-source:userset;height:30pt" id="r175"> <td class="x19" style="height:28.5pt">Reports</td> <td class="x23">Toolbar permission for Actions and Window Select.<br />Toolbar permission for Actions &gt; Reports.</td> </tr> <tr style="mso-height-source:userset;height:30pt" id="r176"> <td class="x19" style="height:28.5pt">Tracking</td> <td class="x23">Toolbar permission for Actions and Window Select.<br />Toolbar permission for Actions &gt; Tracking.</td> </tr> <tr style="mso-height-source:userset;height:15pt" id="r177"> <td class="x16" style="height:13.5pt">Dimensioning </td> <td class="x23">ALL Packages Details Viewer Toolbar Dimensioning<span style="mso-spacerun:yes;white-space:nowrap;font-family:&quot;Times New Roman&quot;">  </span></td> </tr> <tr style="mso-height-source:userset;height:30pt" id="r178"> <td class="x19" style="height:28.5pt">Auto-Dimension</td> <td class="x23">The Run Auto-Dimension Routine tool will display and when clicked will dimension the parts in the viewer.</td> </tr> <tr style="mso-height-source:userset;height:30pt" id="r179"> <td class="x19" style="height:28.5pt">Bulk Delete</td> <td class="x23">The Delete All Dimensions tool will display and when clicked any existing dimensions will be deleted.</td> </tr> <tr style="mso-height-source:userset;height:45pt" id="r180"> <td class="x19" style="height:43.5pt">Delete Dimension</td> <td class="x23">The Delete Dimension icon (red x) will display within a dimension. When the mouse hovers over the dimension the user will be able to click the icon and delete the dimension.</td> </tr> <tr style="mso-height-source:userset;height:15pt" id="r181"> <td class="x19" style="height:13.5pt">Display</td> <td class="x23">Mush be checked to Display the Dimensioning tool.</td> </tr> <tr style="mso-height-source:userset;height:15pt" id="r182"> <td class="x19" style="height:13.5pt">Linear Beta</td> <td class="x23">The Linear Beta tool will display.</td> </tr> <tr style="mso-height-source:userset;height:75pt" id="r183"> <td class="x19" style="height:73.5pt">Move</td> <td class="x23">The Move icon (blue +) will display within a dimension. When the mouse hovers over the dimension the user will be able to click the icon and move the dimension. In addition, the Dimension Settings too (green wrench) displays which provides additional Click Detection settings.</td> </tr> <tr style="mso-height-source:userset;height:15pt" id="r184"> <td class="x19" style="height:13.5pt">Place Dimensions</td> <td class="x23">The Place Dimension flyout will display.</td> </tr> <tr style="mso-height-source:userset;height:15pt" id="r185"> <td class="x16" style="height:13.5pt">Display Mode </td> <td class="x23">ALL Packages Details Viewer Toolbar Display Mode </td> </tr> <tr style="mso-height-source:userset;height:15pt" id="r186"> <td class="x19" style="height:13.5pt">Areas</td> <td class="x23">Ability to see and use Areas tab in Display Mode </td> </tr> <tr style="mso-height-source:userset;height:15pt" id="r187"> <td class="x19" style="height:13.5pt">Assemblies</td> <td class="x23">Ability to see and use Assemblies tab in Display Mode </td> </tr> <tr style="mso-height-source:userset;height:15pt" id="r188"> <td class="x19" style="height:13.5pt">Categories</td> <td class="x23">Ability to see and use Categories tab in Display Mode </td> </tr> <tr style="mso-height-source:userset;height:15pt" id="r189"> <td class="x19" style="height:13.5pt">Packages</td> <td class="x23">Ability to see and use Packages tab in Display Mode </td> </tr> <tr style="mso-height-source:userset;height:15pt" id="r190"> <td class="x19" style="height:13.5pt">Purchasing</td> <td class="x23">Ability to see and use Purchasing tab in Display Mode </td> </tr> <tr style="mso-height-source:userset;height:15pt" id="r191"> <td class="x19" style="height:13.5pt">Tracking</td> <td class="x23">Ability to see and use Tracking tab in Display Mode </td> </tr> <tr style="mso-height-source:userset;height:15pt" id="r192"> <td class="x16" style="height:13.5pt">Filters </td> <td class="x23">ALL Packages Details Viewer Toolbar Filters </td> </tr> <tr style="mso-height-source:userset;height:15pt" id="r193"> <td class="x19" style="height:13.5pt">Areas</td> <td class="x23">Ability to see and use Areas Filter </td> </tr> <tr style="mso-height-source:userset;height:15pt" id="r194"> <td class="x19" style="height:13.5pt">Assemblies</td> <td class="x23">Ability to see and use Assemblies Filter </td> </tr> <tr style="mso-height-source:userset;height:15pt" id="r195"> <td class="x19" style="height:13.5pt">Categories</td> <td class="x23">Ability to see and use Categories Filter </td> </tr> <tr style="mso-height-source:userset;height:15pt" id="r196"> <td class="x19" style="height:13.5pt">Company</td> <td class="x23">Ability to see and use Company Filter </td> </tr> <tr style="mso-height-source:userset;height:15pt" id="r197"> <td class="x19" style="height:13.5pt">Containers</td> <td class="x23">Ability to see and use Container Filter </td> </tr> <tr style="mso-height-source:userset;height:15pt" id="r198"> <td class="x19" style="height:13.5pt">Levels</td> <td class="x23">Ability to see and use Levels Filter </td> </tr> <tr style="mso-height-source:userset;height:15pt" id="r199"> <td class="x19" style="height:13.5pt">Purchasing</td> <td class="x23">Ability to see and use Purchasing Filter </td> </tr> <tr style="mso-height-source:userset;height:15pt" id="r200"> <td class="x16" style="height:13.5pt">References </td> <td class="x23">ALL Packages Details Viewer Toolbar Filters<span style="mso-spacerun:yes;font-family:&quot;Times New Roman&quot;">  </span>References </td> </tr> <tr style="mso-height-source:userset;height:15pt" id="r201"> <td class="x20" style="height:13.5pt">Save</td> <td class="x23">Ability to set and save refrences </td> </tr> <tr style="mso-height-source:userset;height:15pt" id="r202"> <td class="x20" style="height:13.5pt">View</td> <td class="x23">Ability to view refrences </td> </tr> <tr style="mso-height-source:userset;height:15pt" id="r203"> <td class="x19" style="height:13.5pt">Systems</td> <td class="x23">Ability to see and use Systems Filter </td> </tr> <tr style="mso-height-source:userset;height:15pt" id="r204"> <td class="x19" style="height:13.5pt">Tracking</td> <td class="x23">Ability to see and use tracking Filter </td> </tr> <tr style="mso-height-source:userset;height:15pt" id="r205"> <td class="x21" style="height:13.5pt">Grid Offset Measurement and Grid Display</td> <td class="x23">Ability to see and use grid display and run offset measurements </td> </tr> <tr style="mso-height-source:userset;height:15pt" id="r206"> <td class="x16" style="height:13.5pt">Numbering </td> <td class="x23">ALL Packages Details Viewer Toolbar Numbering </td> </tr> <tr style="mso-height-source:userset;height:30pt" id="r207"> <td class="x19" style="height:28.5pt">Bulk Delete</td> <td class="x23">The Bulk Edit - Delete All Item Numbers and Tags tool will display and when clicked any existing numbers or tags will be deleted.</td> </tr> <tr style="mso-height-source:userset;height:30pt" id="r208"> <td class="x19" style="height:28.5pt">Custom Tags</td> <td class="x23">The Custom Tags tool will display and when clicked the Annotation Tags dialog will display.</td> </tr> <tr style="mso-height-source:userset;height:45pt" id="r209"> <td class="x19" style="height:43.5pt">Delete</td> <td class="x23">The delete tag icon (red x) will display within a item number or tag. When the mouse hovers over the item number or tag the user will be able to click the icon and delete the item number or tag.</td> </tr> <tr style="mso-height-source:userset;height:15pt" id="r210"> <td class="x19" style="height:13.5pt">Display</td> <td class="x23">Mush be checked to Display the Numbering tool.</td> </tr> <tr style="mso-height-source:userset;height:45pt" id="r211"> <td class="x19" style="height:43.5pt">Move</td> <td class="x23">The move tag icon (blue +) will display within a item number or tag. When the mouse hovers over the item number or tag the user will be able to click the icon and move the item number or tag.</td> </tr> <tr style="mso-height-source:userset;height:30pt" id="r212"> <td class="x19" style="height:28.5pt">Renumber</td> <td class="x23">The Renumber - All Item Numbers tool will display and when clicked any existing item numbers will be renumbered.</td> </tr> <tr style="mso-height-source:userset;height:15pt" id="r213"> <td class="x21" style="height:13.5pt">Properties</td> <td class="x23">Ability to see and use propteries tab in toolbar </td> </tr> <tr style="mso-height-source:userset;height:15pt" id="r214"> <td class="x21" style="height:13.5pt">Select Connected</td> <td class="x23">Ability to see and use select connected in toolbar </td> </tr> <tr style="mso-height-source:userset;height:15pt" id="r215"> <td class="x16" style="height:13.5pt">Schedule </td> <td class="x23">ALL Packages Schedule </td> </tr> <tr style="mso-height-source:userset;height:15pt" id="r216"> <td class="x17" style="height:13.5pt">Display</td> <td class="x23">Ability to view Schedule under packages </td> </tr> <tr style="mso-height-source:userset;height:15pt" id="r217"> <td class="x17" style="height:13.5pt">Modify</td> <td class="x23">Ability to modify schedule in packages </td> </tr> <tr style="mso-height-source:userset;height:15pt" id="r218"> <td class="x16" style="height:13.5pt">Status Board </td> <td class="x23">ALL Packages Status Board </td> </tr> <tr style="mso-height-source:userset;height:15pt" id="r219"> <td class="x17" style="height:13.5pt">Display</td> <td class="x23">Ability to see status board under packages </td> </tr> <tr style="mso-height-source:userset;height:30pt" id="r220"> <td class="x17" style="height:28.5pt">Drag &amp; Drop</td> <td class="x23">Ability to change tracking with drag and drop in status board under packages </td> </tr> <tr style="mso-height-source:userset;height:15pt" id="r221"> <td class="x16" style="height:13.5pt">Projects </td> <td class="x23">ALL Projects </td> </tr> <tr style="mso-height-source:userset;height:15pt" id="r222"> <td class="x16" style="height:13.5pt">Areas </td> <td class="x23">ALL Projects Areas</td> </tr> <tr style="mso-height-source:userset;height:15pt" id="r223"> <td class="x17" style="height:13.5pt">Edit</td> <td class="x23">Ability to edit Areas set on a project</td> </tr> <tr style="mso-height-source:userset;height:15pt" id="r224"> <td class="x17" style="height:13.5pt">View</td> <td class="x23">Ability to view areas in a project </td> </tr> <tr style="mso-height-source:userset;height:15pt" id="r225"> <td class="x16" style="height:13.5pt">Dashboard </td> <td class="x23">ALL Projects Dashboard </td> </tr> <tr style="mso-height-source:userset;height:15pt" id="r226"> <td class="x17" style="height:13.5pt">Edit</td> <td class="x23">Permission to change the Status of a Project. </td> </tr> <tr style="mso-height-source:userset;height:15pt" id="r227"> <td class="x17" style="height:13.5pt">View</td> <td class="x23">Permission to view of all company projects.</td> </tr> <tr style="mso-height-source:userset;height:15pt" id="r228"> <td class="x16" style="height:13.5pt">Deliverables </td> <td class="x23">ALL Projects Deliverables<span style="mso-spacerun:yes;white-space:nowrap;font-family:&quot;Times New Roman&quot;">  </span></td> </tr> <tr style="mso-height-source:userset;height:15pt" id="r229"> <td class="x17" style="height:13.5pt">Deliverables Settings</td> <td class="x23">Ability to set deliverable settings </td> </tr> <tr style="mso-height-source:userset;height:15pt" id="r230"> <td class="x17" style="height:13.5pt">Modify Deliverables</td> <td class="x23">Ability to change deliverables </td> </tr> <tr style="mso-height-source:userset;height:15pt" id="r231"> <td class="x17" style="height:13.5pt">Modify Packages</td> <td class="x23">Ability to change packages set to deliverables </td> </tr> <tr style="mso-height-source:userset;height:15pt" id="r232"> <td class="x17" style="height:13.5pt">Viewer</td> <td class="x23">Ability to view deliverables </td> </tr> <tr style="mso-height-source:userset;height:15pt" id="r233"> <td class="x16" style="height:13.5pt">Services </td> <td class="x23">ALL Projects Services<span style="mso-spacerun:yes;white-space:nowrap;font-family:&quot;Times New Roman&quot;">   </span></td> </tr> <tr style="mso-height-source:userset;height:15pt" id="r234"> <td class="x17" style="height:13.5pt">Edit</td> <td class="x23">Ability to edit services </td> </tr> <tr style="mso-height-source:userset;height:15pt" id="r235"> <td class="x17" style="height:13.5pt">View</td> <td class="x23">Ability to see services </td> </tr> <tr style="mso-height-source:userset;height:15pt" id="r236"> <td class="x16" style="height:13.5pt">Shipping Addresses </td> <td class="x23">ALL Projects Shipping Addresses<span style="mso-spacerun:yes;white-space:nowrap;font-family:&quot;Times New Roman&quot;">    </span></td> </tr> <tr style="mso-height-source:userset;height:15pt" id="r237"> <td class="x17" style="height:13.5pt">Edit</td> <td class="x23">abiltiy to edit shipping addresses </td> </tr> <tr style="mso-height-source:userset;height:15pt" id="r238"> <td class="x17" style="height:13.5pt">View</td> <td class="x23">Ability to view shipping addresses </td> </tr> <tr style="mso-height-source:userset;height:15pt" id="r239"> <td class="x16" style="height:13.5pt">Supplier Links </td> <td class="x23">ALL Projects Supplier Links </td> </tr> <tr style="mso-height-source:userset;height:15pt" id="r240"> <td class="x17" style="height:13.5pt">Edit</td> <td class="x23">Ability to make and edit supplier links </td> </tr> <tr style="mso-height-source:userset;height:15pt" id="r241"> <td class="x17" style="height:13.5pt">View</td> <td class="x23">Ability to view supplier links </td> </tr> <tr style="mso-height-source:userset;height:15pt" id="r242"> <td class="x16" style="height:13.5pt">Purchasing </td> <td class="x23">ALL Purchasing </td> </tr> <tr style="mso-height-source:userset;height:15pt" id="r243"> <td class="x22" style="height:13.5pt">View &amp; Modify</td> <td class="x23">Ability to view and modify purchasing options </td> </tr> <tr style="mso-height-source:userset;height:15pt" id="r244"> <td class="x22" style="height:13.5pt">View Only</td> <td class="x23">Ability to view purchasing items </td> </tr> <tr style="mso-height-source:userset;height:15pt" id="r245"> <td class="x16" style="height:13.5pt">Receiving </td> <td class="x23">ALL Receiving<span style="mso-spacerun:yes;white-space:nowrap;font-family:&quot;Times New Roman&quot;">  </span></td> </tr> <tr style="mso-height-source:userset;height:15pt" id="r246"> <td class="x22" style="height:13.5pt">View &amp; Modify</td> <td class="x23">Ability to create and change recieving settings </td> </tr> <tr style="mso-height-source:userset;height:15pt" id="r247"> <td class="x22" style="height:13.5pt">View Only</td> <td class="x23">Ability to see recieving items </td> </tr> <tr style="mso-height-source:userset;height:15pt" id="r248"> <td class="x16" style="height:13.5pt">Reports </td> <td class="x23">ALL Reports<span style="mso-spacerun:yes;white-space:nowrap;font-family:&quot;Times New Roman&quot;">  </span></td> </tr> <tr style="mso-height-source:userset;height:15pt" id="r249"> <td class="x16" style="height:13.5pt">Assembly </td> <td class="x23">ALL Reports Assembly </td> </tr> <tr style="mso-height-source:userset;height:15pt" id="r250"> <td class="x17" style="height:13.5pt">CSG \_ MEP \_ Label \_ Spool(4x6)<span style="mso-spacerun:yes;font-family:&quot;Times New Roman&quot;">  </span>(Example)</td> <td class="x23">Ability to see specific reports that are checked </td> </tr> <tr style="mso-height-source:userset;height:15pt" id="r251"> <td class="x17" style="height:13.5pt">Test Connected</td> <td class="x23"></td> </tr> <tr style="mso-height-source:userset;height:15pt" id="r252"> <td class="x16" style="height:13.5pt">BOM </td> <td class="x23">ALL Reports BOM </td> </tr> <tr style="mso-height-source:userset;height:15pt" id="r253"> <td class="x17" style="height:13.5pt">CSG \_ MEP \_ Material BOM<span style="mso-spacerun:yes;font-family:&quot;Times New Roman&quot;">  </span>(Example)</td> <td class="x23">Ability to see specific reports that are checked </td> </tr> <tr style="mso-height-source:userset;height:15pt" id="r254"> <td class="x16" style="height:13.5pt">Container </td> <td class="x23">ALL Reports Container<span style="mso-spacerun:yes;white-space:nowrap;font-family:&quot;Times New Roman&quot;">  </span></td> </tr> <tr style="mso-height-source:userset;height:15pt" id="r255"> <td class="x17" style="height:13.5pt">CSG \_ MEP \_ Dashboard \_ Containers<span style="mso-spacerun:yes;font-family:&quot;Times New Roman&quot;">  </span>(Example)</td> <td class="x23">Ability to see specific reports that are checked </td> </tr> <tr style="mso-height-source:userset;height:15pt" id="r256"> <td class="x16" style="height:13.5pt">Container Details </td> <td class="x23">ALL Reports Container Details<span style="mso-spacerun:yes;white-space:nowrap;font-family:&quot;Times New Roman&quot;">  </span></td> </tr> <tr style="mso-height-source:userset;height:15pt" id="r257"> <td class="x17" style="height:13.5pt">CSG \_ MEP \_ Dashboard Details \_ Containers</td> <td class="x23">Ability to see specific reports that are checked </td> </tr> <tr style="mso-height-source:userset;height:15pt" id="r258"> <td class="x16" style="height:13.5pt">Master Report </td> <td class="x23">ALL Reports Master Report<span style="mso-spacerun:yes;white-space:nowrap;font-family:&quot;Times New Roman&quot;">  </span></td> </tr> <tr style="mso-height-source:userset;height:15pt" id="r259"> <td class="x17" style="height:13.5pt">CSG \_ Pipework \_ BOM \_ With Labor<span style="mso-spacerun:yes;font-family:&quot;Times New Roman&quot;">  </span>(Example)</td> <td class="x23">Ability to see specific reports that are checked </td> </tr> <tr style="mso-height-source:userset;height:15pt" id="r260"> <td class="x16" style="height:13.5pt">Package </td> <td class="x23">ALL Reports Package<span style="mso-spacerun:yes;white-space:nowrap;font-family:&quot;Times New Roman&quot;">  </span></td> </tr> <tr style="mso-height-source:userset;height:15pt" id="r261"> <td class="x17" style="height:13.5pt;overflow:hidden">CSG \_ Pipework \_ Dashboard \_ Field Progress<span style="mso-spacerun:yes;font-family:&quot;Times New Roman&quot;">  </span>(Example)</td> <td class="x23">Ability to see specific reports that are checked </td> </tr> <tr style="mso-height-source:userset;height:15pt" id="r262"> <td class="x16" style="height:13.5pt">Package Details </td> <td class="x23">ALL Reports Package Details<span style="mso-spacerun:yes;white-space:nowrap;font-family:&quot;Times New Roman&quot;">   </span></td> </tr> <tr style="mso-height-source:userset;height:15pt" id="r263"> <td class="x17" style="height:13.5pt">CSG \_ Hanger And Supports Fabrication<span style="mso-spacerun:yes;font-family:&quot;Times New Roman&quot;">  </span>(Example)</td> <td class="x23">Ability to see specific reports that are checked </td> </tr> <tr style="mso-height-source:userset;height:15pt" id="r264"> <td class="x16" style="height:13.5pt">Part </td> <td class="x23">ALL Reports Part<span style="mso-spacerun:yes;white-space:nowrap;font-family:&quot;Times New Roman&quot;">   </span></td> </tr> <tr style="mso-height-source:userset;height:15pt" id="r265"> <td class="x17" style="height:13.5pt">\[Default Report\]<span style="mso-spacerun:yes;font-family:&quot;Times New Roman&quot;">  </span>(Example)</td> <td class="x23">Ability to see specific reports that are checked </td> </tr> <tr style="mso-height-source:userset;height:15pt" id="r266"> <td class="x17" style="height:13.5pt">CSG \_ Single Rod Hanger Fabrication (Example)</td> <td class="x23">Ability to see specific reports that are checked </td> </tr> <tr style="mso-height-source:userset;height:15pt" id="r267"> <td class="x16" style="height:13.5pt">Scan </td> <td class="x23">ALL Scan</td> </tr> <tr style="mso-height-source:userset;height:15pt" id="r268"> <td class="x22" style="height:13.5pt">Delete Tracking Log</td> <td class="x23">Ability to delete tracking log </td> </tr> <tr style="mso-height-source:userset;height:15pt" id="r269"> <td class="x22" style="height:13.5pt">Empty Container</td> <td class="x23">Ability to empty conatiner through scanner tab</td> </tr> <tr style="mso-height-source:userset;height:15pt" id="r270"> <td class="x22" style="height:13.5pt">View</td> <td class="x23">Ability to view scanner tab</td> </tr> <tr style="mso-height-source:userset;height:15pt" id="r271"> <td class="x16" style="height:13.5pt">Shops </td> <td class="x23">ALL Shops </td> </tr> <tr style="mso-height-source:userset;height:15pt" id="r272"> <td class="x22" style="height:13.5pt">Dashboard</td> <td class="x23">Ability to see and make changes to shops dashboard</td> </tr> <tr style="mso-height-source:userset;height:15pt" id="r273"> <td class="x16" style="height:13.5pt">Items </td> <td class="x23">ALL Shops Items</td> </tr> <tr style="mso-height-source:userset;height:15pt" id="r274"> <td class="x17" style="height:13.5pt">Add Item</td> <td class="x23">Ability to add items to shops </td> </tr> <tr style="mso-height-source:userset;height:15pt" id="r275"> <td class="x17" style="height:13.5pt">Delete Item</td> <td class="x23">Ability to delete items from shop </td> </tr> <tr style="mso-height-source:userset;height:15pt" id="r276"> <td class="x16" style="height:13.5pt">Station </td> <td class="x23">ALL Shops Station </td> </tr> <tr style="mso-height-source:userset;height:15pt" id="r277"> <td class="x17" style="height:13.5pt">Tasks</td> <td class="x23">Ability to set station tasks </td> </tr> <tr style="mso-height-source:userset;height:15pt" id="r278"> <td class="x17" style="height:13.5pt">Tool</td> <td class="x23">Ability to set tools to tasks </td> </tr> <tr style="mso-height-source:userset;height:15pt" id="r279"> <td class="x16" style="height:13.5pt">Tracking Statuses </td> <td class="x23">ALL Tracking Statuses </td> </tr> <tr style="mso-height-source:userset;height:15pt" id="r280"> <td class="x22" style="height:13.5pt">\[1\] Design (Example)</td> <td class="x23">Ability to see specific tracking statuses </td> </tr> <tr style="mso-height-source:userset;height:15pt" id="r281"> <td class="x16" style="height:13.5pt">Help</td> <td class="x23">Ability to view help page </td> </tr> <tr style="mso-height-source:userset;height:15pt" id="r282"> <td class="x16" style="height:13.5pt">Notifications</td> <td class="x23">Ability to get notifications</td> </tr> <tr style="display:none"> <td style="width:284.25pt"></td> <td style="width:338.25pt"></td> </tr> </tbody></table></div>

## Project Role Examples

## Assemblies

Prerequisite Permissions to access Assemblies Dashboard.

-   Assemblies > Dashboard
    
-   Packages > 
    
-   Reports > 
    
-   Tracking Statuses > 
    

### Assemblies > Details > Viewer > Toolbar > Dimensioning

**Dimensioning** - Applies to the following:

1.  Admin > Company > Project Roles > **Packages** > Details > Viewer > Toolbar > Numbering
    
2.  Admin > Company > Project Roles > **Assemblies** > Viewer > Toolbar > Numbering  
    
3.  **None Checked or if Display is not checked** - When no Dimensioning checkboxes are checked or when the Display checkbox is not checked, the **Dimensioning** button will not display.  
    
4.  **Dimensioning (Parent)** \- When **Dimensioning** (Parent) is checked, all child checkboxes will be automatically checked and the **Dimensioning** button will display.
    
5.  **Display (Only)** \-  When checked as the only child checked, the **Dimensioning** button will display and when clicked the dimensions will display if they had been previously generated by a user with sufficient Project Role permissions. In addition, the **Dimensioning Status Toolbar** will display.
    
6.  **Auto-Dimension** - When checked, the **Run Auto-dimension Routine** tool will display and when clicked will dimension the parts in the viewer.
    
7.  **Bulk Delete** - When checked, the **Delete All Dimensions** tool will display and when clicked any existing dimensions will be deleted.  
    
8.  **Delete Dimension** - When checked, the **Delete Dimension** icon (red x) will display within a dimension. When the mouse hovers over the dimension the user will be able to click the icon and delete the dimension.  
    
9.  **Display** - Mush be checked to Display the Dimensioning tool.
    
10.  **Linear Beta** - When checked, the Linear Beta tool will display.
    
11.  **Move** \- When checked, the **Move** icon (blue +) will display within a dimension. When the mouse hovers over the dimension the user will be able to click the icon and move the dimension. In addition, the **Dimension Settings** tool (green wrench) displays which provides additional Click Detection settings.  
    
12.  **Place Dimensions** - When checked, the Place Dimension flyout will display. See the [**Manual Dimensioning**](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/8749081/Assemblies+Viewer#Manual-Dimensioning "https://gtpservices.atlassian.net/wiki/spaces/SK/pages/8749081/Assemblies+Viewer#Manual-Dimensioning") article for more information.
    

### Assemblies > Details > Viewer > Toolbar > Numbering and Tagging

**Numbering and Tagging** - Applies to the following:

1.  Admin > Company > Project Roles > **Models** > Viewer > Toolbar > Numbering or Tagging
    
2.  Admin > Company > Project Roles > **Packages** > Details > Viewer > Toolbar > Numbering or Tagging
    
3.  Admin > Company > Project Roles > **Assemblies** > Details > Viewer > Toolbar > Numbering or Tagging
    
4.  **None Checked or if Display is not checked** - When no Numbering checkboxes are checked or when the Display checkbox is not checked, the **Item Numbers** button will not display.
    
5.  **Numbering (Parent)** \- When **Numbering** (Parent) is checked, all the child checkboxes will be automatically checked, the **Item Numbers** button will display, and the additional options flyout will display.
    
6.  **Display** \- When checked, the **Display - Item Numbers** button will display and when clicked the numbers and tags will display. The fly-out that includes additional edit options will not display.
    
7.  **Bulk Delete** - When **Bulk Delete** is checked the **Bulk Edit - Delete All Item Numbers and Tags** tool will display and when clicked any existing numbers or tags will be deleted.
    
8.  **Custom Tags** - When **Custom Tags** is checked the **Custom Tags** tool will display and when clicked the **Annotation Tags** dialog will display.
    
9.  **Delete** \- When checked, the delete tag icon (red x) will display within a item number or tag. When the mouse hovers over the item number or tag the user will be able to click the icon and delete the item number or tag.
    
10.  **Move** \- When checked, the move tag icon (blue +) will display within a item number or tag. When the mouse hovers over the item number or tag the user will be able to click the icon and move the item number or tag.
    
11.  **Renumber** \- When **Renumber** is checked the **Renumber - All Item Numbers** tool will display and when clicked any existing item numbers will be renumbered.  
    

## Projects

### Projects > Dashboard

#### Projects > Dashboard > Edit

1.  **Checked** - Permission to change the Status of a Project. 
    

#### Projects > Dashboard > View

1.  **Checked** - Permission to view of all company projects. Includes information such as Number, Name, Name Override, #Models, #Packages, and Package Statuses.
    
2.  **Unchecked** - The list of Projects will not display.
    

## Models

### Models > Dashboard

#### Models > Dashboard > Dashboard

1.  **Checked** - Permission to view the Models > Dashboard, a list all published models by Project. Includes model information such as the date Published, Project Level Conflict Resolution (editable) setting, # Packages, # Assemblies, # Parts, and Reports.  
    
2.  **Unchecked** - The list of Models will not display.
    

#### Models > Dashboard > Delete Model and Data

**Required Project Roles:**

-   Models > Dashboard > Dashboard
    

1.  **Checked** - Permission to Delete the model.
    

### Models > Viewer > Actions

Unless one of the following Actions are checked, the Models > Viewer tab will not display.

#### Models > Viewer > Actions > Areas

1.  **Required Checked** 
    
    1.  Models > Viewer > Actions > Areas.
        

#### Models > Viewer > Actions > Assemblies

1.  **Required Checked** 
    
    1.  Models > Viewer > Actions > Assemblies
        

#### Models > Viewer > Actions > Attachments

1.  **Required Checked** 
    
    1.  Models > Viewer > Actions > Attachments
        

#### Models > Viewer > Actions > Categories

1.  **Required Checked** 
    
    1.  Models > Viewer > Actions > Categories
        

#### Models > Viewer > Actions > Packages

1.  **Required Checked** 
    
    1.  Models > Viewer > Actions > Packages
        
    2.  Models > Viewer > Actions > Areas
        
    3.  Packages > Categories - Permission to one or more more Packages
        
    4.  Packages > Details > Attachments
        
    5.  Packages > Details > Items > Properties
        
    6.  Division - Permission to one or more more Divisions, if company is using Divisions
        

#### Models > Viewer > Actions > Reports

1.  **Required Checked** 
    
    1.  Models > Viewer > Actions > Reports
        
    2.  Reports  - Permission to one or more more reports
        

#### Models > Viewer > Actions > Tracking

1.  **Required Checked** 
    
    1.  Models > Viewer > Actions > Tracking
        
    2.  Tracking Statuses - Permission to one or more more Tracking Statuses
        
    3.  Division - Permission to one or more more Divisions, if company is using Divisions
        

### Models > Viewer > Display Mode

Unless one of the following Display Mode options are checked, the Models > Viewer > Display Modes tool will not display.

#### Models > Viewer > Display Mode > Areas

1.  **Required Checked** 
    
    1.  Models > Viewer > Display Modes > Areas.
        
    2.  Models > Viewer > Actions > Tracking
        

#### Models > Viewer > Display Mode > Assemblies

1.  **Required Checked** 
    
    1.  Models > Viewer > Display Modes > Assemblies
        
    2.  Models > Viewer > Actions > Tracking
        

#### Models > Viewer > Display Mode > Categories

1.  **Required Checked** 
    
    1.  Models > Viewer > Display Modes > Categories
        
    2.  Models > Viewer > Actions > Tracking
        

#### Models > Viewer > Display Mode > Containers

1.  **Required Checked** 
    
    1.  Models > Viewer > Display Modes > Containers
        
    2.  Models > Viewer > Filters > Containers
        
    3.  Models > Viewer > Actions > Tracking  
        

#### Models > Viewer > Display Mode > Packages

1.  **Required Checked** 
    
    1.  Models > Viewer > Display Modes > Packages
        
    2.  Models > Viewer > Actions > Tracking
        
    3.  Packages > Categories - Permission to one or more more Packages  
        

#### Models > Viewer > Display Mode > Purchasing

1.  **Required Checked** 
    
    1.  Models > Viewer > Display Modes > Purchasing
        
    2.  Models > Viewer > Actions > Tracking
        
    3.  Packages > Categories - Permission to at least one Package Category
        

#### Models > Viewer > Display Mode > Tracking

1.  **Required Checked** 
    
    1.  Models > Viewer > Display Modes > Tracking
        

### Models > Viewer > Filters

Unless one of the following Filters options are checked, the Models > Viewer > Filters tool will not display.

#### Models > Viewer > Filters  > Areas

1.  **Required Checked** 
    
    1.  Models > Viewer > Display Modes > Areas.  
        

1.  **Models** (Read Only and Editable options) - The Models tab includes the Model Viewer and is the main area to filter, view, and take actions on model items.
    
2.  **Models > Viewer > Filters > \[Filter\]** (Read Only) – The FILTERS options on the left side of the page gives the user different ways to filter the model. Permission can be given to each individual filter or click the Filters checkbox to give access to all filters.
    
3.  **Models > Viewer > Display Mode** (Read Only) - The DISPLAY MODE options in the center of the page gives the user different ways to display the model from a Normal view to a view that displays part colors by either Areas, Categories, or Tracking.
    
4.  **Models > Viewer > Actions** (Editable) - The ACTIONS options on the right side of the page gives the user different actions that update the Stratus database. These actions include adding selected items to an Area, Assembly, Category, Package, or Tracking Status. In addition, Attachments for a selected item can be viewed.
    
5.  **Models > Viewer > Toolbar** (Editable) - The vertical Toolbar on the right side of the viewer gives users access to unique tools including Grid Offset Measurement and Grid Display (Read Only), Select Connected (Read Only), Properties (Read Only), Control Point Display and Panel (Editable).
    
6.  **Packages** (Editable and Read Only) - The Packages tab includes a Dashboard, Schedule, Status Board, Categories, and Package Details for each package. 
    
7.  **Package > Dashboard** (Editable) - The Packages Dashboard tab displays information about each Package in the project / model including the number of assemblies, estimated hours, and tracking status. Permission options include the ability to generate a Cut List, export Points (if available), download a .MAJ file (if available) and delete the Package. Each can be individually permissioned.
    
8.  **Packages > Status Board** (Editable) - The Packages Status Board tab displays package Kanban cards.
    
    1.  Use the Drag & Drop permission to control whether or not a user can “Drag & Drop” a package from one status to another in the Packages Status Board.
        
9.  **Assemblies** (Read Only) - The Assemblies tab includes a Dashboard and Viewer. Creating a new assembly in Stratus can update the Revit model if the modeler imports the model back into Revit and then publishes the changes. Assemblies created in Revit cannot be edited.
    
10.  **Assemblies > Dashboard (Editable) -** The Assemblies Dashboard tab displays a **Dashboard** grid that includes a list assemblies by project, model, type, status, and tracking log. A project role with the Delete permission can delete assemblies.
    
11.  **Assemblies > Viewer (Read Only and Tracking status changes) -** The Assemblies Viewer tab displays a view of the selected assembly on the left and tabbed options (Parts, Sheet, Report, Notes, and Attachments,) on the right. Along with Parts tab comes the permission to Send Cut List to TigerStop or Export to TigerStop the selected parts if TigerStop software has been installed. A project role with the Tracking permission enables users to change the Tracking status of the assembly.
    
12.  **Assemblies > Viewer > Numbering and Dimensioning** - Numbering and Dimensioning permissions can now be set to be visible but not modifiable per project role.
    
13.  **Divisions** - Filter which project roles can access specific Divisions. See [**Divisions (Admin)**](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/103317524/Processor+Admin "https://gtpservices.atlassian.net/wiki/spaces/SK/pages/103317524/Processor+Admin") for more information.
    
14.  **Package Categories** - Filter which project roles can access specific Package Categories. See [**Package Categories (Admin)**](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/166199351 "https://gtpservices.atlassian.net/wiki/spaces/SK/pages/166199351") for more information.
    
15.  **Tracking Statuses** - Filter which project roles can access specific Tracking Statuses. See [**Tracking Statuses (Admin)**](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/10485761 "https://gtpservices.atlassian.net/wiki/spaces/SK/pages/10485761") for more information.
    
16.  **Projects > Deliverables > Viewer** -  The Viewer project role for Project Deliverables is only used to control the display of notifications which impact deliverables (Ex. deliverable definition changes, new model published, bim areas modified, and more). 
    

### Models > Viewer > Toolbar

Unless one of the following Toolbar options are checked, the Models > Viewer > Display - Item Numbers Toolbar will not display.

#### Models > Viewer > Toolbar > Numbering

##### Models > Viewer > Toolbar > Numbering > Bulk Delete

1.  **Required Checked** 
    
    1.  Models > Viewer > Toolbar > Bulk Delete
        

##### Models > Viewer > Toolbar > Tagging > Display

1.  **Required Checked** Display. When any option is checked, Display is automatically checked.
    
2.  Tagging - Checks all tagging options
    
3.  Display - Displays the **Display - Item Numbers Toolbar** button. When clicked, Item Numbers and Tags previously placed by a user with Project Role permissions will display.
    
4.  Bulk Create - Displays the Create icon and when clicked?.
    
5.  **Bulk Delete** - Displays the Delete icon and when clicked, displays the **Delete All Tags** prompt.
    
6.  **Custom Tags** - Displays the **TAG** button and when clicked displays the **Annotation Tags** dialog.
    
7.  **Delete** \- The **Delete** option will display.
    
8.  **Move** \- The **Move** option will display.
    

## **Videos**

## 08/19/2024 - Stratus Academy: ADM-512: Admin 3 - Project Roles

To take the **Project Roles** course, login to [**Stratus Academy**](https://academy.stratus.build/ "https://academy.stratus.build/") and and locate the course **ADM-512: Admin 3 - Project Roles**.

## 02/25/2021 CSG Webinar: Setting Up Project Roles

<iframe allowfullscreen="" allowtransparency="true" data-hasbody="false" data-layout="default" data-local-id="251d5ae3-fdae-49e8-9a3c-d54505426e94" data-macro-id="c3af2900-49e6-4b59-aabe-73037ba447da" data-macro-name="widget" frameborder="0" height="364" mozallowfullscreen="" data-delayed-src="https://player.vimeo.com/video/518248434?h=embed" webkitallowfullscreen="" width="640"></iframe>

00:00 Release Notes Review  
05:00 Project Roles  
20:50 Tracking Status and Divisions

## Stratus 07/16/2020 Implementation Webinar - Project Role Setup/Interface (13:15)

<iframe allowfullscreen="" allowtransparency="true" data-hasbody="false" data-layout="default" data-local-id="c0f37ee9-20f6-4e8b-ac9a-de70e5aa8225" data-macro-id="26660674-0c9e-485d-ae5c-9e6094206f5e" data-macro-name="widget" frameborder="0" height="364" mozallowfullscreen="" data-delayed-src="https://player.vimeo.com/video/439316536?h=embed" webkitallowfullscreen="" width="640"></iframe>

0:21 Admin > Company > Settings > Project Roles  
1:45 Project Roles are assigned to users at the project level  
2:42 Desktop > Publish  
4:24 Models > Viewer > Filters  
5:30 Models > Viewer > Display Modes  
5:43 Assemblies > Dashboard  
6:00 Assemblies > Viewer > Numbering & Dimensions  
6:44 Packages > Categories - High-level permissions as to what a user can see  
8:05 Divisions - High-level permissions as to what a user can do  
9:51 Tracking Statuses - Granular permission as to what a user can view at the assembly and package level.  
12:00 Test project role permissions under Account > Company > Override Project Roles for Testing
---
created: 2025-06-25T06:27:04 (UTC -04:00)
tags: []
source: https://gtpservices.atlassian.net/wiki/spaces/SK/pages/11534406/Projects+Admin
author: 
---

# Projects (Admin) - STRATUS Knowledge Base - Confluence

> ## Excerpt
> The Projects page is used to synchronize BIM 360 projects with STRATUS. Once a project is synchronized the project status can be set to Active. Once team members have been added to an Active project, those team members will be able to see the project and will be able to publish models to the project.

---
The Projects page is used to synchronize BIM 360 projects with STRATUS. Once a project is synchronized the project status can be set to Active. Once team members have been added to an Active project, those team members will be able to see the project and will be able to publish models to the project. 

-   1[Add Projects from Autodesk Construction Cloud](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/11534406/Projects+Admin#Projects(Admin)-AddProjectsfromAutodeskConstructionCloud)
-   2[Activate a Project and Add Team Members](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/11534406/Projects+Admin#Projects(Admin)-ActivateaProjectandAddTeamMembers)
-   3[BIM 360 Root Folder Path](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/11534406/Projects+Admin#Projects(Admin)-BIM360RootFolderPath)
-   4[Projects Table](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/11534406/Projects+Admin#Projects(Admin)-ProjectsTable)
-   5[Projects Hosted on Different Company BIM 360 Docs Hubs](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/11534406/Projects+Admin#Projects(Admin)-ProjectsHostedonDifferentCompanyBIM360DocsHubs)

## Add Projects from Autodesk Construction Cloud

1.  To synchronize new and updated BIM 360 projects with STRATUS, click the **Add Projects from Autodesk Construction Cloud** button. This will link will synchronize each BIM 360 project with STRATUS. ![](https://gtpservices.atlassian.net/wiki/download/attachments/11534406/image2023-11-13_12-0-52.png?version=1&modificationDate=1699898455911&cacheVersion=1&api=v2)
    1.  During the sync process whether the **Add Projects from Autodesk Construction Cloud** or the **Refresh** button (individual project) is clicked, the following BIM 360 Docs project information is updated in STRATUS:  
                  **BIM 360 Docs**                            **STRATUS**   
        1.  Project Job Number                    Number
            
        2.  Address Line 1                            Address 
            
        3.  Address Line 2                            Address
            
        4.  City                                             City
            
        5.  State                                           State
            
        6.  Zip                                              Zip
            
        7.  Project Start Date                       Target Start Date               (only applies if STRATUS Target Start Date has not been edited yet)
        8.  Project End Date                        Target End Date                (only applies if STRATUS Target End Date has not been edited yet)
        9.  Construction Type                      A360 Construction Type
        10.  Project Type                               A360 Project Type
        11.  Business Unit                             A360 Business Unit
            
    2.  If a BIM 360 Docs project has already been synced with STRATUS, then, fields will only be synced to STRATUS when they are empty. STRATUS will not overwrite existing values using the **Refresh** button.
    3.  **Below is an example of BIM 360 Docs project information:  
        ![](https://gtpservices.atlassian.net/wiki/download/thumbnails/11534406/image2021-8-10_9-8-15.png?version=1&modificationDate=1628604496474&cacheVersion=1&api=v2&width=463&height=250)**
    4.  ****Below is an example of BIM 360 Docs information in STRATUS:  
        ![](https://gtpservices.atlassian.net/wiki/download/thumbnails/11534406/image2021-8-10_9-7-57.png?version=1&modificationDate=1628604478915&cacheVersion=1&api=v2&width=1000&height=194)  
        **  
        **
2.  **Confirmation** - When the process has completed one of the following confirmation messages will display:
    1.  Projects added to company: >0  
        ![](https://gtpservices.atlassian.net/wiki/download/attachments/11534406/image2022-4-22_11-3-7.png?version=1&modificationDate=1650643388205&cacheVersion=1&api=v2)
    2.  Projects added to company: 0  
        ![](https://gtpservices.atlassian.net/wiki/download/attachments/11534406/image2022-4-22_11-2-19.png?version=1&modificationDate=1650643340933&cacheVersion=1&api=v2)
3.  **Refresh Project** \- To refresh the project information from an individual BIM 360 project with STRATUS, click the **Refresh** button associated with the project. Content will be updated as described above.

## Activate a Project and Add Team Members

By default, after a project is synchronized with STRATUS for the first time, its status is set to **Active**.

1.  While the project is active, it does not yet have any Team members. See the **[Team (Admin)](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/217940256/Team+Admin)** article for adding team members to the project.
2.  Once team members are added to an Active project, those team members can see the project and can publish models to the project. **Note**: A team member may need to click their **badge** and then the **Refresh Permissions** button for the project to be visible.

## BIM 360 Root Folder Path

The BIM 360 root folder path and A360 Folder Path can be specified when publishing. Currently, the default BIM 360 root folder path is Project Files. Use the Default Company BIM360 Root Folder Path to change the default path for all new projects, or, set the BIM360 Folder Path for individual projects.

For Revit see the **[Configure BIM 360 Publish Folder Path](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/1183383557/Revit+Publish+and+Import#RevitPublishandImport-ConfigureBIM360PublishFolderPath)** article for more details.

For AutoCAD see the **[Configure BIM 360 Publish Folder Path](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/1183384125/AutoCAD+Publish+and+Import#AutoCADPublishandImport-ConfigureBIM360PublishFolderPath)** article for more details.

Below is a summary.

**To set the Default Company BIM360 Root Folder Path:**

1.  To configure the default BIM 360 root folder path click the current path name, Project Files in this example.   
    ![](https://gtpservices.atlassian.net/wiki/download/attachments/11534406/image2021-8-9_11-16-44.png?version=1&modificationDate=1628525805308&cacheVersion=1&api=v2)
    
2.  The **Set default company BIM360 root folder path** dialog will display.
    
    ![](https://gtpservices.atlassian.net/wiki/download/attachments/11534406/image2021-8-9_11-16-58.png?version=1&modificationDate=1628525819270&cacheVersion=1&api=v2)
    
3.  Manually enter the new default company BIM360 root folder path. Project Files must be included in the path.
    
    1.  For example, if the default path will be a subfolder of Project Files, enter the following:  
        Project Files\\subfolder name
        
    2.  **Note**: STRATUS cannot determine if the specified folder path is valid.
        
4.  The Default Company BIM 360 Root Folder Path can be overridden at the project level. See the **A360 Folder Path** section below.

## Projects Table

![](https://gtpservices.atlassian.net/wiki/download/attachments/11534406/image2023-11-13_12-3-58.png?version=1&modificationDate=1699898641151&cacheVersion=1&api=v2)

1.  **Status** - Sets the visible status of the project for users. See the **[Activate a Project and Add Team Members](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/11534406/Projects+Admin#Projects(Admin)-ActivateaProjectandAddTeamMembers)** section for more information.
2.  **Number** - The project job number is initially populated from BIM 360. See the **[Add Projects from BIM 360](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/11534406/Projects+Admin#Projects(Admin)-AddProjectsfromBIM360)** section for more information.
3.  **Name** - The project name.
4.  **Name Override** - The Name Override option enables a company to override the project name imported from BIM 360. This is especially useful to companies who have a BIM 360 project naming standard and would like to use a different project name in STRATUS.
    
    **To initiate a Project Name Override:**
    
    1.  Go to Admin > Company > Projects, click the **Name Override** link associated with the project, and enter a name.
        
        ![](https://gtpservices.atlassian.net/wiki/download/thumbnails/11534406/image2021-8-9_11-20-35.png?version=1&modificationDate=1628526036651&cacheVersion=1&api=v2&width=1023&height=250)
        
    2.  After a page refresh or a newly generated report, the Name Override will be applied wherever the Project Name is referenced.
        
        ![](https://gtpservices.atlassian.net/wiki/download/thumbnails/11534406/image2021-8-9_11-21-30.png?version=1&modificationDate=1628526091787&cacheVersion=1&api=v2&width=600&height=325)
        
5.  **Description** - The project Description will default to "A360" but can be edited.
6.  **A360 Folder Path** - The Default Company BIM 360 Root Folder Path (see the **[BIM 360 Root Folder Path](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/11534406/Projects+Admin#Projects(Admin)-BIM360RootFolderPath)** section for more information), can be overridden at the project level in the **A360 Folder** Path setting. See one of the following article sections for more information.  
    **Warning:** The **A360 Publish Folder Path** can be edited for existing projects, however, any models that have already been published to an **A360 Publish Folder Path** will continue to be published to the same BIM 360 folder path. In other words, a model can only have one **A360 Publish Folder Path**. Only newly published models will use an edited ****A360 Publish Folder Path.****
    1.  **[AutoCAD Configure BIM 360 Publish Folder Path](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/1183384125/AutoCAD+Publish+and+Import#AutoCADPublishandImport-ConfigureBIM360PublishFolderPath)** 
    2.  **[Revit Configure BIM 360 Publish Folder Path](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/1183383557/Revit+Publish+and+Import#RevitPublishandImport-ConfigureBIM360PublishFolderPath)**
7.  **Address** - The project Address can be initially populated from BIM 360. See the **[Add Projects from BIM 360](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/11534406/Projects+Admin#Projects(Admin)-AddProjectsfromBIM360)** section for more information.
8.  **City** - The project City can be initially populated from BIM 360. See the **[Add Projects from BIM 360](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/11534406/Projects+Admin#Projects(Admin)-AddProjectsfromBIM360)** section for more information.
9.  **State** \- The project State can be initially populated from BIM 360. See the **[Add Projects from BIM 360](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/11534406/Projects+Admin#Projects(Admin)-AddProjectsfromBIM360)** section for more information.
10.  **City** - The project Zip can be initially populated from BIM 360. See the **[Add Projects from BIM 360](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/11534406/Projects+Admin#Projects(Admin)-AddProjectsfromBIM360)** section for more information.
11.  **Created** - The date the project was added to STRATUS from BIM 360.
12.  **Target Dates** - The Target Start Date and Target End Date are used to set the Start and End dates on the Packages > Schedules page. See the **[Packages Schedules](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/9044061/Packages+Schedule)** article for more information. 
13.  **Tax-Exempt** - The Tax Exempt checkbox is used by the STRATUS Purchasing features and tells the supplier if they should charge taxes.
    
    1.  (Ignore this option if you are not using the Purchasing and Supplier portal features.)
14.  **Manufacturer Source Type** - The Manufacture Source Type is used by STRATUS Purchasing features. Ignore this option if you are not using the Purchasing and Supplier port features. The Manufacture Source Type tells the supplier if procurement for a project is:
    
    -   Domestic American
    -   Domestic Americas (North and South America)
    -   Foreign
    -   Unspecified
15.  **A360 Construction Type** - The project A360 Construction Type is populated from BIM 360. This field is editable in STRATUS. **Note**: If the project’s **Refresh** button is clicked, non-Empty data from Autodesk BIM 360 will overwrite any edits made in STRATUS. See the **[Add Projects from BIM 360](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/11534406/Projects+Admin#Projects(Admin)-AddProjectsfromBIM360)** section for more information.
16.  **A360 Project Type** - The project A360 Project Type is populated from BIM 360.
    
    1.  This field is editable in STRATUS. **Note**: If the project’s **Refresh** button is clicked, non-Empty data from Autodesk BIM 360 will overwrite any edits made in STRATUS.
    
    See the **[Add Projects from BIM 360](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/11534406/Projects+Admin#Projects(Admin)-AddProjectsfromBIM360)** section for more information.
17.  **A360 Business Unit** - The project A360 Business Unit is populated from BIM 360.
    
    1.  This field is editable in STRATUS. **Note**: If the project’s **Refresh** button is clicked, non-Empty data from Autodesk BIM 360 will overwrite any edits made in STRATUS.
    
    See the **[Add Projects from BIM 360](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/11534406/Projects+Admin#Projects(Admin)-AddProjectsfromBIM360)** section for more information.
18.  **Project Color** - The project color is used on the Packages > Status Board to help identify projects.![](https://gtpservices.atlassian.net/wiki/download/thumbnails/11534406/image2019-2-22_12-5-30.png?version=1&modificationDate=1550858733141&cacheVersion=1&api=v2&width=758&height=413)

## Projects Hosted on Different Company BIM 360 Docs Hubs

Follow these steps when a project is hosted on a different company's BIM 360 Docs hub.

1.  Create the project in your BIM 360 hub, even if you only use that project for STRATUS. There is a one-to-one relationship between Docs and STRATUS companies. This prevents your STRATUS company from seeing another company’s Docs files.
2.  Under Admin > Company > Projects, click the **Add Projects from BIM 360** button in STRATUS. STRATUS will synchronize new Docs projects in STRATUS. Note: The status of these projects will be New. Change them to Active for team members to view them (see steps above).
3.  To publish a model to the project:
    
    1.  Open up the central model hosted on the other company’s site using your normal business procedures. 
        
    2.  Click the **Publish** button. The publish dialogue will display where you will see the list of projects in your Bim 360 Docs hub.
        
    3.  Select the project and proceed with the normal publish process.
---
created: 2025-06-25T06:27:05 (UTC -04:00)
tags: []
source: https://gtpservices.atlassian.net/wiki/spaces/SK/pages/2003402753/Queries+Admin
author: 
---

# Queries (Admin) - STRATUS Knowledge Base - Confluence

> ## Excerpt
> Queries are pre-defined data queries that result in a downloadable list.

---
Queries are pre-defined data queries that result in a downloadable list.

-   1 [Queries](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/2003402753/Queries+Admin#Queries)
    -   1.1 [Query: All Publish Jobs](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/2003402753/Queries+Admin#Query%3A-All-Publish-Jobs)
-   2 [Queries Open API](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/2003402753/Queries+Admin#Queries-Open-API)

## Queries

1.  Click the Query drop-down to view the list of Queries.
    
2.  Select the query, click Run and the downloadable report will display in a separate tab. 
    

Note: If there are too many results, the list of parts can only be viewed after clicking the Download button and opening the file.  

## Query: All Publish Jobs

The All Publish Jobs query provides a better understanding of historical publish metrics from Stratus.

**Note**: The **All Publish Jobs** query includes project and model names instead of just guids, whereas, the **Completed Publish Jobs Since January 2024** query only includes guids.

Some of the data that might be of interest to you are as follows:

-   **MinutesAutodesk**: Time spent in Autodesk model translation
    
-   **MinutesExtract**: Time spent on desktop importing and publishing
    
-   **MinutesLoad**: Time spent corralling the data after model translation has completed
    
-   **MinutesTotal**: Total time spent from the start of desktop publishing to model availability in Stratus
    
-   **MinutesTransform**: Time spent transforming data from desktop data structures and schemas to Stratus data structures and schemas
    
-   **ModelFileSizeBytes**: Model file sizes
    
-   **NumParts**: Total number of parts in the model
    
-   **TotalNumberOfVIews**: Total number of views in the model publish set
    

Some things to note: Autodesk translation kicks off during the extract phase and must be completed to wrap the final stage of the transform phase of publishing. This is when we can then start the load stage.

The number of model parts has the strongest correlation to publish times, followed by model size, and then the number of publish views. What these metrics don’t take into account is the complexity of geometry (e.g. the number of vertices on a part type or the number of properties being extracted), but it should give you some healthy insights into your model progression over time at the very least.

## Queries Open API

Any Admin Company Query can be called from Power BI using the Open API if you want to incorporate the data into a visual chart. Here are the relevant Open API calls:
---
created: 2025-06-25T06:27:05 (UTC -04:00)
tags: []
source: https://gtpservices.atlassian.net/wiki/spaces/SK/pages/10617393/Reports+Admin
author: 
---

# Reports (Admin) - STRATUS Knowledge Base - Confluence

> ## Excerpt
> Reporting is a framework to specify the precise data you want to get out of the model. Using filters you can generate the reports by order, area, level, cost code, or any property you want. Reports can be created for different user roles.  A report can be generated based on any model property or a Stratus filter.  Field expressions work with parameter names that include () or “ in them.

---
Reporting is a framework to specify the precise data you want to get out of the model. Using filters you can generate the reports by order, area, level, cost code, or any property you want. Reports can be created for different user roles.  A report can be generated based on any model property or a Stratus filter.  Field expressions work with parameter names that include () or “ in them.

-   1 [Stratus Academy Course Video](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/10617393/Reports+Admin#Stratus-Academy-Course-Video)
-   2 [Report](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/10617393/Reports+Admin#Report)
    -   2.1 [Report Options](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/10617393/Reports+Admin#Report-Options)
    -   2.2 [Report Fields](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/10617393/Reports+Admin#Report-Fields)
    -   2.3 [Project Role Permission Settings for Reports](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/10617393/Reports+Admin#Project-Role-Permission-Settings-for-Reports)
    -   2.4 [Reportable Stratus Fields (Properties)](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/10617393/Reports+Admin#Reportable-Stratus-Fields-(Properties))
    -   2.5 [Hiding Report Columns](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/10617393/Reports+Admin#Hiding-Report-Columns)
    -   2.6 [Clone a Report](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/10617393/Reports+Admin#Clone-a-Report)
    -   2.7 [Create Master / Sub Reports](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/10617393/Reports+Admin#Create-Master-%2F-Sub-Reports)
    -   2.8 [Report Validation](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/10617393/Reports+Admin#Report-Validation)
    -   2.9 [Assembly Filter Impact on a Part Report](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/10617393/Reports+Admin#Assembly-Filter-Impact-on-a-Part-Report)
-   3 [Configuration Examples](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/10617393/Reports+Admin#Configuration-Examples)
    -   3.1 [Example: Pipe Weld Diameter Inches](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/10617393/Reports+Admin#Example%3A-Pipe-Weld-Diameter-Inches)
    -   3.2 [Example: Flex Duct](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/10617393/Reports+Admin#Example%3A-Flex-Duct)
    -   3.3 [Example: Create a Spool Sheet Report](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/10617393/Reports+Admin#Example%3A-Create-a-Spool-Sheet-Report)
    -   3.4 [Example: Package Dashboard Reports](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/10617393/Reports+Admin#Example%3A-Package-Dashboard-Reports)
    -   3.5 [Example: Package Stratus Sheet](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/10617393/Reports+Admin#%5BinlineExtension%5DExample%3A-Package-Stratus-Sheet)
    -   3.6 [Example: Import Cut List Reports](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/10617393/Reports+Admin#Example%3A-Import-Cut-List-Reports)
    -   3.7 [Example: Label Report](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/10617393/Reports+Admin#Example%3A-Label-Report)
    -   3.8 [Example: Container Label Report](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/10617393/Reports+Admin#Example%3A-Container-Label-Report)
    -   3.9 [Example: Container Details Report](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/10617393/Reports+Admin#Example%3A-Container-Details-Report)
    -   3.10 [Example: Container Part, Assembly, or Package Report](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/10617393/Reports+Admin#Example%3A-Container-Part%2C-Assembly%2C-or-Package-Report)
    -   3.11 [Example: Package Assemblies Batch Report PDF](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/10617393/Reports+Admin#Example%3A-Package-Assemblies-Batch-Report-PDF)
    -   3.12 [Example: Configure an Alias for use inside a report field](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/10617393/Reports+Admin#Example%3A-Configure-an-Alias-for-use-inside-a-report-field)
    -   3.13 [Example: Fab Packet](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/10617393/Reports+Admin#Example%3A-Fab-Packet)
    -   3.14 [Example: Stratus.Assembly.Connected Property](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/10617393/Reports+Admin#Example%3A-Stratus.Assembly.Connected-Property)
    -   3.15 [Example: Extract the X, Y, and Z Coordinates of a Part’s Bounding Box Center](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/10617393/Reports+Admin#Example%3A-Extract-the-X%2C-Y%2C-and-Z-Coordinates-of-a-Part%E2%80%99s-Bounding-Box-Center)
    -   3.16 [Example: Report Average and Sum Hours](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/10617393/Reports+Admin#Example%3A-Report-Average-and-Sum-Hours)
    -   3.17 [Example: Filter and Report on Parent Families that Consist of Only Shared Nested Families](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/10617393/Reports+Admin#Example%3A-Filter-and-Report-on-Parent-Families-that-Consist-of-Only-Shared-Nested-Families)
    -   3.18 [Example: BIM Area Elevation Report Properties XYZ for Part Connectors C1, C2, C3, C4](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/10617393/Reports+Admin#Example%3A-BIM-Area-Elevation-Report-Properties-XYZ-for-Part-Connectors-C1%2C-C2%2C-C3%2C-C4)
    -   3.19 [Example: Hanger Point Report](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/10617393/Reports+Admin#Example%3A-Hanger-Point-Report)
-   4 [Other Report Videos](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/10617393/Reports+Admin#Other-Report-Videos)
    -   4.1 [10-10-19 Implementation Webinar - Trade Specific Reporting (32:31)](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/10617393/Reports+Admin#10-10-19-Implementation-Webinar---Trade-Specific-Reporting-(32%3A31))
    -   4.2 [05-16-19 Implementation Webinar - Pipe Reports (19:54)](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/10617393/Reports+Admin#05-16-19-Implementation-Webinar---Pipe-Reports-(19%3A54)%5BhardBreak%5D)

## Stratus Academy Course Video

To take the Reports course, login to [**Stratus Academy**](https://academy.stratus.build/ "https://academy.stratus.build/") and and locate the course **ADM-507: Admin 2 - Reports**.

## Report

## Report Options

1.  To create a new report, click the **New Report** button. A new row will display in the list of reports.
    
2.  **Report Options**
    
    1.  **Name** (Required) - Enter a report name. When selecting the report to be run, this is the name that will display. It is recommended that this name be descriptive yet short.  
        **Note**: BIM 360 does not allow special characters to be used when generating files.
        
    2.  **Format** - A report can utilize one of the following formats.
        
        1.  **CSV** - Use this format when you only need tabular data.
            
        2.  **PDF** - Use this format when you want to bring together multiple data types (data fields, images, isometric views, QR codes, etc.) and other formatting options
            
        3.  **ZPL** - Use this format if you are creating a report that will be printed on a ZPL compatible printer. See the [**Label Printing for Zebra (ZPL) Compatible Printers**](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/157974545 "https://gtpservices.atlassian.net/wiki/spaces/SK/pages/157974545") article for more information. ZPL format reports will display on any checked Viewer (Assembly, Model, Package). For example, the Package ZPL report will be available in the Models > Viewer under Actions > Reports.
            
    3.  **Item Type** - A report can utilize one of the following Item Types.
        
        1.  **Assembly (Assemblies Dashboard)** - Use this item type when the report will display data about assemblies. 
            
            1.  Report Examples include - Estimated Hours, Spool Label (when combined with the ZPL format).
                
        2.  **BOM** - Use this item type when your report is targeted to display in the report drop-down on the Package's BOM tab. The **Report Fields** will be restricted to those available for the BOM Template Type. Once saved, the report will display on the Packages Dashboard under Report. See the [**Package BOM**](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/166690857 "https://gtpservices.atlassian.net/wiki/spaces/SK/pages/166690857") article for more information.
            
        3.  **Container (Containers Dashboard)** - Use this item type when the report will be used for a Container Label Report which will display information about the container on a label.
            
            1.  When a Container Item Type is combined with a ZPL Format, the resulting report can be used as a Label Template.
                
        4.  **Container Details -** Use this item type for a container's contents. By creating a [**Template**](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/157974589/Templates+Admin "https://gtpservices.atlassian.net/wiki/spaces/SK/pages/157974589/Templates+Admin"), you can choose a specific report format for each type of container. The Container Details Item Type is only available on the Containers page in the Report drop-down. See the [**Containers Assign**](http://gtpservices.atlassian.net/wiki/spaces/SK/pages/1877574151 "http://gtpservices.atlassian.net/wiki/spaces/SK/pages/1877574151") article for more information.
            
        5.  **Invoice** - Only use this type if your company has been configured to use the Purchasing and Supplier options.
            
        6.  **Master Report** - A Master Report can be used to combine multiple sub-reports into a single report.
            
            1.  Report Examples: Master = Pipe BOM; Sub-Reports = Pipe Length, Fittings, Valves
                
            2.  See below for a Fab Packet example.
                
            3.  If a Sub-report of a Master Report often contains no data, the sub-report can be omitted from the report results when Sub-Reports are configured.
                
        7.  **Package (Packages Dashboard)** - Use this item type when your report is targeted to display in the report drop-down on the Package's Report tab. Use this item type when the report will display data about packages. This report time is most often used in conjunction with the Packages Dashboard checkbox to display the report as a custom report on the Packages Dashboard. 
            
            1.  When a Package Item Type is combined with a CSV Format and the Package Dashboard is checked, the resulting report can be used as a custom Packages Dashboard report.
                
            2.  Report Examples: System Package
                
        8.  **Package Details** - Use this item type when your report is targeted to display in the report drop-down on the Package's Report tab. See the [**Package's Stratus Sheet**](https://gtpservices.atlassian.net/wiki/pages/resumedraft.action?draftId=10617393#Reports(Admin)-Reports(Admin)-PackageSTRATUSSheet "https://gtpservices.atlassian.net/wiki/pages/resumedraft.action?draftId=10617393#Reports(Admin)-Reports(Admin)-PackageSTRATUSSheet") article for more information.
            
            1.  Report Examples: Package Sheet
                
        9.  **Part (Assembly Details)** - The Part Item Type is the most frequently used Report Item Type. It is used when the report will display data about parts. It is often combined with a Part Filter.
            
            1.  When a Part Item Type is combined with a PDF Format, the resulting report can be used on a Template.
                
            2.  When a Part Item Type is combined with a CSV Format, the resulting report can be used on the Assembly Viewer or as a Cut List Import. Additionally, if the report is targeted to be displayed on the Assemblies > Viewer, an Assembly Filter can further refine the list of parts.
                
            3.  When a Part Item Type is combined with a ZPL Format, the resulting report can be used as a Label Template.
                
            4.  Report Examples include BOM, Cut List, Pipe, Duct, Conduit, Length, Fittings, Hangers (Rod, Strut), Galvanized Supports, Weld Diameter, Equipment.
                
        10.  **Purchasing** - Only use this type if your company has been configured to use the Purchasing and Supplier options.
            
        11.  **Report and Template Configuration Grid** - Below, the **Reports** column lists the path of where a report can display. The **Report Settings** section (blue) shows the settings (Admin > Company > Reports) needed to display the report. The **Template Types** section (green) shows the areas a template can be used and setting requirements for the template to display. For a larger display, click the image.
            
    4.  **Assembly Filter** 
        
        1.  **Assemblies Filter (Default Parts Report)** - Under Assemblies > Viewer > Parts, the default Report selected on the assembly's first page load, will compare the parts in the assembly with all relevant Assembly Filters. The Assembly Filter that matches the most parts will be selected as the default Report. **Note**: If you select a different report for an assembly, the system will select that same report the next time you view that particular assembly.
            
        2.  **Default Assembly Report in Package Categories Alternative** - Default Assembly Report option was added to Package Categories With the release of v6.3.1, a Default Assembly Report option was added to Package Categories which works well when working with Assemblies that are in Packages. Both of these options are described in the [**Default Assembly Report**](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/2136506865/Viewer+Stratus+Sheet+for+Assemblies+and+Packages#DefaultAssemblyReport "https://gtpservices.atlassian.net/wiki/spaces/SK/pages/2136506865/Viewer+Stratus+Sheet+for+Assemblies+and+Packages#DefaultAssemblyReport") article. 
            
    5.  **Part Filter** - If your report needs to filter part data, select the filter. See [**Filters (Admin)**](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/10617224 "https://gtpservices.atlassian.net/wiki/spaces/SK/pages/10617224") for more information. 
        
    6.  **Assembly Viewer** - Check this option if the report needs to display in the Assemblies > Viewer.
        
    7.  **Model Viewer** - Check this option if the report needs to display in the Models > Viewer.
        
    8.  **Package Viewer** - Check this option if the report needs to display in the Packages > Viewer. The Package Viewer checkbox column is only available to the following Report Item Types:
        
        -   Part
            
        -   Assembly
            
        -   Package
            
        -   Package Details (New - Default Checked)
            
        -   Master
            
    9.  **Assemblies Dashboard** - Check this option when your report is targeted to display in the report drop-down on the Assemblies > Dashboard tab. 
        
    10.  **Containers Dashboard** - Check this option when your report is targeted to display in the report drop-down on the Containers > Dashboard tab. 
        
    11.  **Packages Dashboard** - Check this option when your report is targeted to display in the report drop-down on the Packages > Dashboard tab. See the [**Package Dashboard**](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/8749118 "https://gtpservices.atlassian.net/wiki/spaces/SK/pages/8749118") article for more information.
        
    12.  **Cut List Import** - Check this option when you want to use the report to display cut lists. When checked, the report will display on the Import Cut Lists dialog. See the **Import Cut List - Select the report that contains the cut lists** section of the [**Package Cut Lists**](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/166723746 "https://gtpservices.atlassian.net/wiki/spaces/SK/pages/166723746") article.
        
    13.  **Label Template** - If the report format is ZPL, then the Label Template will be active. The Label Template can be edited.  See the [**Label Printing for Zebra (ZPL) Compatible Printers**](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/157974545 "https://gtpservices.atlassian.net/wiki/spaces/SK/pages/157974545") article for more information.
        
    14.  **Template** -  If you plan to embed the report inside a template, then select a template. See the [**Templates (Admin)**](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/1558249473 "https://gtpservices.atlassian.net/wiki/spaces/SK/pages/1558249473") article for more information.
        
    15.  **Notes** - Add notes to describe the purpose of the report.
        
    16.  **Save, Cancel, or Delete**
        
    17.  **Clone Row** - Clone a report by clicking the Clone Row button. 
        
3.  After the Save button is clicked the following message will inform you that only the Project Admin project role can access the report by default. Give permission to the report to other project roles under **Admin > Company > Project Roles**.
    
4.  **Note**: In order to enforce property rules where specific properties can only be used with specific Item Types, editing the Item Type after a Report is created is prevented. Hover over an Item Type that cannot be edited and the following message will display.
    

## Report Fields

Once a report is defined, add the Fields (properties) that will display on the report. Report Fields (properties) can include:

1.  Revit and/or AutoCAD database fields from all models published to the company.
    
2.  Stratus default fields for parts, assemblies, and packages (Ex. Stratus.Part.CutLength or Stratus Package).
    
3.  Stratus Fields created under Admin > Company > Fields (Ex. Stratus.Field.Pipe Length).
    
4.  Ancillary content (Ex. Stratus.Ancillary.Type).
    

To configure a Report Field (property) the following options are available:

1.  "**#**" - The number column indicates the order in which the report field columns display from left to right.
    
2.  The **Move Up and Move Down arrows** change the order of the report fields in the grid. 
    
3.  **Property Name** - A drop-down selection box which displays all available report fields. Enter characters to alphabetically jump in the list. Click to select a field.
    
4.  **Header** - By default when Empty, the Property Name will display as the column header for the report field. Enter a different value as needed.
    
5.  **Sort Index** - Set the display sort order by report field.
    
6.  **Merge Like Values** - Set Merge Like Values to **Yes** when you want to a total quantity for like values such as 6" Diameter pipe. 
    
7.  For a Report where:
    
    1.  **Item Type** = Part
        
    2.  **Report Field** has **Merge Like Values** set to Yes. **Note**: If any Report Field Property is set to Yes for **Merge Like Values**, then all other properties will get a count (n) added as well.
        
    3.  The following business rules will be applied:
        
        1.  If the quantity counts of a report (the Quantity checkbox) are enabled
            
            1.  Only show the “**(n)**” count on merged data in cells when n **does not equal** the quantity column value in the report.
                
            2.  When n = 1, show “**(1)**”
                
    4.  As a result:
        
        1.  Assemblies > Viewer where all merged parts in the Quantity are the same.
            
    5.  Assemblies > Viewer where merged parts in the Quantity are different, the (n) value will display.
        
    6.  Packages > Viewer > Items where (n) value displays.
        
8.  **Show Quantity** - Show Quantity is enabled when Merge Like Values is set to Yes. When set to Yes, the values will display in the report. 
    
9.  **Aggregate** - Aggregate replaced Total Values on 3/3/21.
    
    1.  **None** - The None option is selected by default and will not apply a sum or average.
        
    2.  The **Sum** option will add a total for numeric values at the bottom of the report. If you are using Merge Like Values, Total Values will provide sub-totals for each merged row.
        
    3.  For reports where the **Packages Dashboard** is checked, Numeric columns (Integer, Decimal, and all the Feet Inch variations) can be totaled when Sum option is selected. The Format and Precision can also be controlled. 
        
    4.  **Average** - The Average option will average the numeric values.
        
10.  **Format** - Select the display Format type for the report field.
    
    1.  **String** - A **String** data format is a sequence of characters, either as a literal constant or as some kind of variable.
        
    2.  **Integer** - An **Integer** data format stores whole numbers, positive or negative.
        
    3.  **Decimal** - A **Decimal** data format stores decimal numbers, which include a fractional part. The precision column controls the number of decimal places.
        
    4.  **FeetInch** - A FeetInch data format displays the value as feet and decimal inches (Ex. 7'-4"). The precision column controls the decimal.
        
    5.  **FeetInchFraction** - A FeetInchFraction data format displays the value as feet and fractional inches (Ex. 7'-3-5/8"). The precision column controls the fraction.
        
    6.  **Inch** - An Inch data format displays the value as inches and decimal inches (Ex. 88"). The precision column controls the decimal.
        
    7.  **InchFraction** - An InchFraction data format displays the value as inches and fractional inches (Ex. 87-5/8"). The precision column controls the fraction.
        
    8.  **Date** - The Date data format stores the value as a date.  
        
    9.  **Boolean** - A Boolean data format can store one of two values: true or false.
        
    10.  **QRCode** - The **QRCode** format is used to render the value of the property as a QR code in the Stratus UI (Ex. Packages > Items > Parts table) and in generated PDFs (Ex. Stratus Sheet, Attachment). **Note:** When the report type is CSV, the value of the property will still be rendered as a string. 
        
11.  **Precision** - Precision is used in relation to the selected Report Field Format (FeetInchFraction, InchFraction, Inch, FeetInch, and Decimal). 
    
    1.  Decimal - If your Format is set to Decimal, you can specify the **Decimal Precision** and the number of decimals after the point (Ex. 1,2,3,4 decimals). **Note**: If the Report Field is a custom Stratus Field and it includes Possible Values for a drop-down list, the precision must be set to include decimals in the Possible Value list.
        
    2.  Below are display examples of 2 different pipe lengths and common precision values for each format type. For a larger display, click the image.
        
12.  **AutoCAD Multiplier** - The AutoCAD Multiplier equals Pi when finding the total circumference of the pipe using the outside diameter.
    
13.  **Revit Multiplier** - If you want to find the total circumference of the pipe, take the outside diameter of the pipe x Pi which gives you a result in linear weld inches. When dealing with Revit, because their units are in feet, you have to do 12 x Pi.
    
14.  **Prefix** - Add text to the beginning of the data in this column.
    
15.  **Suffix** - Add text at the end of the data in this column. For example, you might want to include the word inches in the output, or lbs for total weight.
    
16.  **Possible Values** - A read-only display of possible values for the field.
    
17.  **Hidden** - When checked, the report can use the data of the report field for things like grouping and sorting, but the column will not display in generated reports.
    
18.  **Delete** - Delete the Report Fields from the report. 
    

## Project Role Permission Settings for Reports

Each Report is independently permissioned for a project role. See the [**Project Roles**](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/11534527 "https://gtpservices.atlassian.net/wiki/spaces/SK/pages/11534527") article for more information. When configuring project roles for a report, each report can be selectively visible or hidden per role.

1.  In the following example, those assigned the project role of Administrator or Project Manager can run the highlighted reports. The other reports do not appear as choices for them. **NOTE:** The Project Admin role always has all reports available and this cannot be overridden.
    
2.  When a user whose project role is Administrator or Project Manager attempts to run a report, their options are limited to those reports that have been checked.
    

## Reportable Stratus Fields (Properties)

Below are explanations of selected reportable fields or property names. The list of property names includes all of the fields from all of your published models and Stratus-specific fields.

To access the report fields, click the Expand button associated with the report. 

1.  **Stratus.Assembly.ConnectedAssembly.Single** – This property will only print one label per connected assembly, which may be a better option for a rack. See Example: Stratus.Assembly.Connected Property (below).
    
2.  **Stratus.Assembly.ConnectedAssembly.Multiple** – This property will print a label for each connection. See Example: Stratus.Assembly.Connected Property (below).
    
3.  **Stratus.Part.AssemblyQRCode** \- Add QR code for the parts in an assembly to the report.
    
4.  **Stratus.Part.CutLengthDecimal** - When attempting to build a report using Part Template Cut List Property Mapping and referenced properties (Ex. Stratus.Part.CutLengthDecimal) are included, also included the referenced properties in the report as hidden columns. See the [**Cut List Mappings**](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/166723746 "https://gtpservices.atlassian.net/wiki/spaces/SK/pages/166723746") article for more information.
    
5.  **Stratus.Part.PackageQRCode** \- Add QR code for the parts in a package to the report.
    
6.  **Stratus.Part.Point.X, Stratus.Part.Point.Y, Stratus.Part.Point.Z** - The X, Y, and Z coordinates of a part’s bounding box center can now be extracted. This means that you can use something like a nested rod family in conjunction with control points, a filter, and a report to generate your own point files in whatever configuration you need. See the **Extract the X, Y, and Z Coordinates of a Part’s Bounding Box Center** section below for an example.
    
7.  **Stratus.Part.QRCode** \- Add QR code for the parts to the report.
    
8.  **Stratus.Part.TrackingStatusLog** - When used in a report, the history of part’s tracking statuses will be separated by a semi-colon.  One use case for including this field in a report is to check if the material was ordered for a part, knowing that “Ordered” tracking status may not be the current status. You could either:
    
    1.  Search a report for the tracking status, or,
        
    2.  Configure a Filter that “Contains” the value “Ordered” and assign the filter to a report. Then when the report is run on parts in the model only those that match the filter will be included.
        
9.  **Stratus.Part.TrackingStatus** - Will display the current Stratus tracking status for the part. Clone (Copy) a Report.
    
10.  **Stratus.Part.Point.AFF** (Above Finished Floor) - The parameter Stratus.Part.Point.AFF is reportable and displays in the part’s Properties. In this example on the 4<sup data-renderer-mark="true">th</sup> Level (Floor), the Stratus.Part.Point.Z = 1,358.88 while the Stratus.Part.Point.AFF = 0.63. If there are no levels in the model, Stratus.Part.Point.Z  will equal Stratus.Part.Point.AFF. The AFF point is measured from the part's centroid. The complex process to derive the Stratus.Part.Point.AFF value includes:
    
    1.  Get the part’s origin point by evaluating the following in order and using the first value that is found:
        
        1.  first connector point
            
        2.  first tap connector point
            
        3.  first dimension reference point
            
        4.  then, if not considered a hanger support, will try:
            
            1.  centroid
                
            2.  centerline intersection point
                
            3.  anchor or positioning point
                
    2.  Find a Z elevation to calculate the relative offset value of the point’s Z value, by:
        
        1.  Selecting the property value (which refers to the part’s assigned level name)
            
        2.  Finding a level with a section name and get its Z elevation for reference
            
        3.  if not found, process all model levels in order from highest to lowest and use the first level with an elevation value at or below the part’s origin point
            
    3.  Finally, return the difference between the part’s origin point and the Z elevation reference level.
        
11.  **Stratus.Part.HoleInfo** - This Report Field will display holes in pipe. 
    
    When added to a Stratus Sheet report, the report column will include a list of all holes separated by semi-colons in the following format per hole:
    
    <hole size> <clocking angle from start>d <distance from start> E-C <mating angle from start>d out
    
    **Note**: Clockwise is a positive angle looking downpipe from start to end.
    
12.  **Stratus.Package.XLeadDays** - Replace the X with Office, Purchasing, or Shop to display Start Date Lead Days for packages.
    
13.  **Stratus.Package.XStartDT** - Replace the X with Office, Purchasing, or Shop to display the Start Date for packages.
    

## Hiding Report Columns

To hide report columns so that they do not display on the report:

1.  Select **Admin** > **Company** > **Reports.**
    
2.  **Expand** the definition of the report to be configured.
    
3.  Click the **Hidden** checkbox for the column(s) that will be hidden.
    
4.  Run the report. The columns will not appear. **Note:** Refreshing the report page will not show your changes, rather, regenerate the report.
    

## Clone a Report

To clone a report:

1.  On the Admin > Reports button, click the clone button associated with the report you want to clone.
    
2.  The cloned report will display and will include an incremented number after the name.
    

## Create Master / Sub Reports

Multiple reports can be combined into a single report by creating a Master Report. 

1.  Identify or create a new report that will be the Master Report.
    
2.  Under **Admin > Company > Reports** for a new or existing report click **Item Type** drop-down and select the Master Report option.
    
3.  Once the report is saved, check which viewer the Master Report will be visible in (Ex. Model Viewer or Package Viewer). 
    
4.  To add sub-reports, click the **Expand** button associated with the report. The Sub-Reports section displays.
    
5.  In the Sub-Reports section, click the **+Add Report** button. A new row will display.
    
6.  Click the **Empty** link in the Report field to select one of the sub-reports.
    
    1.  **Omit If Empty** -  When the sub-report is checked and the report is run, if the checked sub-report contains no data, it will be omitted from the report. This is especially useful when a Part Filter sub-report filters out all parts in the model.
        
    2.  **Omit Title** - When checked, if the sub-report has no data, the report Title will not display.
        
    3.  **Omit Column Headings** - When checked, if the sub-report has no data, the report Column Headings will not display.
        
7.  Repeat to select another sub-report.
    
8.  Once saved, the report is ready to run. In the example below, the report was run from Models > Viewer > Actions > Reports > Master (CSV) where Sub-report A and Sub-report B display.
    

**Report Fields**

Once a report is defined, add the fields that will display on the report. Report fields can include:

1.  Database fields from all models published to the company.
    
2.  Stratus default fields for parts, assemblies, and packages (Ex. Stratus.
    

## Report Validation

Reports are validated to ensure, for example, that templates cannot be assigned to CSV reports and that a template has a "matching" template type to the report item type. If, when you click the **Admin** > **Reports** tab you see a warning message like the following, take note and then review the report to correct the issue.

## Assembly Filter Impact on a Part Report

The assembly filter is used to set which report will be the initial report displayed on the Assembly viewer Parts tab. When an assembly is created Stratus will look at all of the part reports set to display on the assembly viewer, find the report that has an assembly filter that contains the most amount of parts for that new assembly and set that report to display the first time the assembly is opened.

For example, if you have a filter to identify ductwork and another to identify pipework you will want to assign the ductwork filter as the assembly filter on your ductwork BOM and assign the piping filter on your pipework BOM (above). The first time you open a newly created ductwork assembly you will get the ductwork BOM report because the Assembly Filter found more duct parts than pipe parts. Similarly, the first time you open the pipework assembly you will get the pipework BOM report because the Assembly Filter found more pipe parts than duct parts.  
**Note**: Once a report is manually changed, when the page is refreshed, the newly selected report will display rather than the report based on the Assembly Filter.

## Configuration Examples

## Example: Pipe Weld Diameter Inches

Below is one way to configure a report on Pipe Weld Diameter Inches.

1.  **Item Type** - This report is run on Parts, not Orders or Assemblies. The list of properties (**Property Names**) will be different depending on whether you are reporting on a Part, Assembly, or Order.
    
2.  **Filter** - For this report, the Filter **Pipe Welds** is applied. This means that only parts defined by the Pipe Welds filter will be included in the output.
    
3.  Other columns are used for formatting, grouping, and ordering data within the report.
    
4.  **Property Names** - This report will have 2 columns (Property Names):  
    Product Material Description and Main Primary Diameter of the Pipe Welds.
    
5.  In this case, you want to know the Material and the outside diameter of the pipe.
    
6.  **Format** – The Diameters will be in FeetInches; the Description will be a String value.
    
7.  Precision = 2
    
8.  **Multiplier** – If you want to find the total circumference of the pipe, take the outside diameter of the pipe x Pi which gives you a result in linear weld inches. When dealing with Revit, because their units are in feet, you have to do 12 x Pi.
    
9.  **Suffix** – You might want to include the word inches in the output…or for a total weight field you might enter lbs.
    

## Example: Flex Duct

Below is one way to configure a report on Flex Duct

1.  **Item Type** – A flex duct report is run on Parts, not Orders or Assemblies. The list of properties (**Property Names**) will be different depending on whether you are reporting on a Part, Assembly, or Order.
    
2.  **Filter** - For this report, the Filter **Flex Duct** is applied. This means that only Flex Duct parts, as defined by the Flex Duct filter will be included in the output.
    
3.  Other columns are used for formatting, grouping, and ordering data within the report.
    
4.  **Property Names** - This report will have 2 columns (Property Names):  
    Diameter and Length
    
5.  For ordering purposes, you want to know the total length … so the Total Values = Yes. AND Merge Like Values is set to Yes on the diameter so that everything that is set to the same diameter will get merged into a single row on the report. AND the Length would get totaled.
    
6.  **Format** – The data is formatted in FeetInch
    

## Example: Create a Spool Sheet Report

Reports can be targeted to the Assemblies > Viewer tab. The Assemblies Viewer does provide a default report, but you will want to customize reports for this tab. A spool sheet report combines a template with a report. 

**To create a printable Spool Sheet report that can be used on the Assemblies > Viewer tab:**

1.  Create a Template - See the [Templates (Admin)](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/157974589/Report+Templates+and+Generate+PDF+Admin "https://gtpservices.atlassian.net/wiki/spaces/SK/pages/157974589/Report+Templates+and+Generate+PDF+Admin") article.  Define the information you want to display on the report like logo, QR code, 3D views, and space for the parts list. 
    
2.  Create a Spool Sheet Report report under **Admin** > **Company** > **Reports** that will be associated with the report template. You can create a new report or clone and modify an existing report. 
    
3.  **Configure the Spool Sheet Report** which will contain the spool's part list:
    
    1.  **Name** - Name of the report (Ex. Pipe Spool Sheet).
        
    2.  **Format**
        
        1.  **PDF** – PDF format means that data, like spool sheet data, might include a logo header, project name, assembly name, list of spool or assembly parts, and assembly views with dimensions can be formatted on a page. 
            
    3.  **Item Type**
        
        1.  **Part** - The Item Type, in this example, is Part since the report data will include assembly parts. 
            
    4.  **Filter** - Your report could utilize a filter, however, with regard to a spool sheet report which is opened from the Assembly Viewer, the spool itself will filter the data.
        
    5.  **Assembly Viewer** - Check the Assembly Viewer option so that this report will be available on the report drop-down list on the Assemblies > Viewer page.
        
    6.  **Template** \- The Template column is used to pair a report with a report template. In this example, I selected the report template Demo A created above.
        
4.  **Configure the Report Fields** for Pipe Spool Sheet report. All reports fields should match fields in your company database. For fields like Diameter, Material, or Length which can reference many different fields in your database, you will probably need to take an extra step and create an alias so that many fields can be funneled into one report field. See the [Aliases (Admin)](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/10518824 "https://gtpservices.atlassian.net/wiki/spaces/SK/pages/10518824") article for more information. Below are report fields used in this example.
    
    1.  Number
        
    2.  Name 
        
    3.  Description
        
    4.  Stratus.Alias.Pipe Diameter 
        
    5.  Stratus.Alias.Pipe Material
        
    6.  Stratus.Alias.Pipe Length
        

## Example: Package Dashboard Reports

Reports can be targeted to the Packages > Dashboard. The Dashboard does provide a default report, but you can create one or more reports to customize how the list of packages is displayed.

**To create a report that can be displayed on the Packages Dashboard:**

1.  Create a new report under Admin > Company > Reports.
    
2.  For the report, select:
    
    1.  **Format** = **CSV**
        
    2.  **Item Type** = **Package**
        
3.  **Save** the report so that the Packages Dashboard checkbox is activated and can be checked.
    
4.  **Check the Packages Dashboard checkbox** and **Save**.
    
5.  Expand the report.
    
6.  Click the **New Report Field** button.
    
7.  Add any of the **Stratus.Package** fields under Property Name and Save.
    
    1.  To Total numeric fields (Integer, Decimal, and all the Feet Inch variations), set Total Values setting to Yes. If the field is a Feet Inch variation, set the Format and the Precision as well.
        

**To view the report on the Packages Dashboard:**

1.  Go to the **Packages** > **Dashboard** page.
    
2.  Click the Report drop-down and select the report. Only reports where the Packages Dashboard checkbox is checked for the report will display here.
    
3.  Once selected your report will display. You can filter the list of packages by selecting the Package Category.
    

To view the column totals:

1.  All Dashboard pages that have more than one page of data will include 2 totals. In this case a subtotal (150.29’) for the packages on the page, followed by the total for all packages (24226.2’) defined by the Project and Model selected.
    
2.  Other column types like Decimal and String can also be totaled.
    

## Example: Package Stratus Sheet

Reports can be targeted to the Packages > Stratus Sheet tab. A default report does not display under Admin > Company > Reports, so you'll need to create a new report if you want a custom report option for this tab. 

**To create a report that can be displayed on the Package's Stratus Sheet tab:**

1.  Create a Template - See the [**Templates (Admin)**](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/157974589/Report+Templates+and+Generate+PDF+Admin "https://gtpservices.atlassian.net/wiki/spaces/SK/pages/157974589/Report+Templates+and+Generate+PDF+Admin") article.
    
2.  Create a new report under **Admin** > **Company** > **Reports** or clone an existing report that may have some of the report fields you want in the new report.
    
3.  For the report, select:
    
    1.  **Format** = **PDF.** In this example, the Reports will pull in various data fields like Package Name, Project Name, Assembly Name, QR Code, and more.
        
    2.  **Item Type** = **Package.** Note: This is the only Item Type that targets the report for the Package Reports page drop-down.
        
    3.  **Filter** = None. The Selected package will filter the report so a separate filter is not needed.
        
    4.  **Template** = a template you have created to display the data fields. In this case, I have created a Package Details template that includes the Report field, Package Name, Project Name, Assembly Name, QR Code, and Isometric image.
        
4.  **Save** the report.
    
5.  Expand the report to add report fields. These fields will display in a table in the templates' Report field.
    
6.  Click the **New Report Field** button. Add any applicable fields under Property Name and Save. Below are some examples.
    
7.  To use the Package Details Report, see the [**Package Report**](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/199884912/Package+Report#PackageReport-PackageDetailsReportPackagesReport "https://gtpservices.atlassian.net/wiki/spaces/SK/pages/199884912/Package+Report#PackageReport-PackageDetailsReportPackagesReport") article. This article includes information about how to enhance the Isometric view of the report by adding features like assembly names, spool names, item numbers, and Display Grid.
    

## Example: Import Cut List Reports

An Import Cut List report can be used to generate a cut list for items like Single Rod Hanger, Trapeze Hanger, Strut, Skids, etc.  When a report is configured with the Import Cut List checkbox checked, the report can be imported as a Cut List on the Packages > Cut Lists tab. This report must also be configured to be used with a mapping under Admin > Import Mappings.

This example will demonstrate how to create a cut list report for single rod hangers.

**Create a report filter** 

1.  The Single Rod Hanger report will require a Filter be configured to isolate the hangers in the model viewer. 
    
2.  Select a single rod hangers in the model and determine which field(s) can best isolate the hangers.
    
3.  Under **Admin** > **Company** > **Filters**, create a new filter and set the rule using the property that will isolate the hangers (Ex. ServiceType = Hanger).  
    

**Create a cut list report** 

1.  Under **Admin** > **Company** > **Reports**, create a report for a cut list, **select the Filter**, **check the Cut List Import checkbox,** and **save**.
    
2.  Add the report fields for the cut list and labels. For example:
    
    1.  **ServiceAbbreviation**
        
    2.  **Size**
        
    3.  **Drop Rod Diameter**; Sort = 1; Format = inchFraction
        
    4.  **Length A**; Sort = 2; Format = inchFraction  
        
3.  Go to the **Models** > **Viewer** and run the report on the whole model or an isolated view under **Actions** > **Reports** > **Select the report**. Check that the report contains the information you want and that it sorts and formats it the way you want.
    
4.  Once done, click the **Download the report**. You'll use this file later when you set up the Import Mapping.
    

**Create an import mapping**

1.  See the [Import Mapping article](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/170196993 "https://gtpservices.atlassian.net/wiki/spaces/SK/pages/170196993") for information on how to configure an import mapping. 
    
2.  If you haven't already, download the report created above.
    
3.  Under **Admin > Company > Import Mapping**, click the **New Import Mapping** button, name it, and then save.
    
4.  **Browse** and upload the downloaded file (.csv). This is a sample file that includes your cut list header rows (Ex. Size, Drop Rod Diameter, Material, Length A) and at least one row of data.
    
5.  Once a sample file has been uploaded, expand the row to tell Stratus which fields to use for the **Header row**. Once selected, Stratus will automatically fill-in and save the mapping fields with your Header rows.
    
6.  The Import Mapping is ready to use with other reports that use the same Import Mapping and the same report.
    

**Import Cut Lists**

1.  In the Models > Viewer, run the cut list report (above) on the whole model or an isolated view under **Actions** > **Reports** > **Select the report.**
    
2.  **Download** the report.
    
3.  Under **Packages** > **Dashboard**, click the **New Package** button, add the package details, and then **save**. For this example, this step assumes that a package containing the cut list parts for the Single Rod Hanger cut list has not been created. If you have a package where you have added the isolated Single Rod Hangers, then go ahead and open that package.
    
4.  Open the package and make sure it set to a tracking status where the "Can Assemble" checkbox is unchecked which indicates that the package can no longer be edited. See the [Tracking Statuses (Admin)](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/10485761 "https://gtpservices.atlassian.net/wiki/spaces/SK/pages/10485761") article for more information.
    
5.  Under **Packages** > **Cut List**, click the **Import Cut List** button.
    
6.  Click **Import**. The Cut List will display.  
    
7.  You can either
    
    1.  Print the labels to a ZPL printer, or,
        
    2.  if you have a TigerStop, select a Station, check one or more cut list rows, and then click the Send Cut List to Station.
        

## Example: Label Report

If you want to print fitting labels to your Zebra printer, you would create a report similar to the following:

1.  Create a filter that either filters out your straights or filters in the fittings. Get this running in the Models Viewer until you are happy with it.
    
2.  Create a report where:
    
    1.  **Format** = ZPL
        
    2.  **Item Type** = Part
        
    3.  **Filter** = the above filter
        
    4.  **Edit the Label** as needed. Note: You can copy/paste the label code from a label you currently use.
        
3.  Add Fields to the report. Example Label Fields, depending on your database, might include:
    
    1.  **Assembly Name**: Stratus.Part.AssemblyName
        
    2.  **Package Name**: Stratus.Part.PackageName
        
    3.  **Item Number**: Number
        
    4.  **Material**: Material
        
    5.  **Diameter**: **Overall** Size
        
    6.  **Description**: Description
        
    7.  **QR Code**: Stratus.Part.QRCode
        
4.  To run the report, go to the **Package Details** > **Attachments** tab. Select the report and click the Create button.
    
5.  The resulting report will have a print option.
    
6.  To print the labels, you’ll need to open and configure the GTP Stratus Workstation Printer to point to your label printer.
    
    1.  Download the [**GTP Stratus Print**](https://www.dropbox.com/sh/4hftsujfunksicx/AAAlklSQs3ZUbMin3yaMC0-Ia?dl=0 "https://www.dropbox.com/sh/4hftsujfunksicx/AAAlklSQs3ZUbMin3yaMC0-Ia?dl=0")**.**
        
7.  Send the Zebra printer identified on the GTP Stratus Workstation Printer.
    
8.  Affixing the label to the right part may be a challenge so you may need a couple of filters so that you only print labels for certain parts.
    

## Example: Container Label Report

To configure a Container report to be used on labels:

1.  Go to **Admin** > **Company** > **Reports**
    
2.  Click **New Report**.
    
    1.  **Name (required)** – The name for your Container Label report.
        
    2.  **Format** – ZPL
        
    3.  **Item Type** – Container  
        
3.  Click **Save**.
    
4.  Expand the report to add **Report Fields**. The following fields are available:
    
    1.  **Stratus.Container.Name** – The Name entered in the [**Define Container**](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/246317057/Containers+Admin#Define-Container "https://gtpservices.atlassian.net/wiki/spaces/SK/pages/246317057/Containers+Admin#Define-Container") section. No additional field columns need to be edited.
        
    2.  **Stratus.Container.QRCode** – A QR code will be included. No additional field columns need to be edited.
        
    3.  **Stratus.Container.Description** - The Description entered in the [**Define Container**](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/246317057/Containers+Admin#Define-Container "https://gtpservices.atlassian.net/wiki/spaces/SK/pages/246317057/Containers+Admin#Define-Container") section.
        
    4.  **Stratus.Container.Id** - Displays the container's unique Container ID
        
    5.  **Stratus.Container.QRCode** - Displays the container's QR Code.
        
    6.  **Stratus.Container.Type** - The Container Type entered in the [**Define Container**](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/246317057/Containers+Admin#Define-Container "https://gtpservices.atlassian.net/wiki/spaces/SK/pages/246317057/Containers+Admin#Define-Container") section.
        
    7.  **Stratus.Container.CompanyName** - Displays the Company name.
        
5.  **Edit Label Template**
    
    1.  By default, the Label Template includes the report fields Stratus.Container.Name and Stratus.Container.QRCode. On the label, this will print the container name and QR code.
        
    2.  If you want to add report fields like Company Name or Container ID, then you’ll need to add them to the Label Template and to the Report Fields. See the [**Label Printing for Zebra (ZPL) Compatible Printers**](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/157974545 "https://gtpservices.atlassian.net/wiki/spaces/SK/pages/157974545") article for more information.
        

## Example: Container Details Report

Use this report item type for a container's bill of contents. By creating a Template, you can choose a specific report format for each type of container. The Container Details Item Type is only available on the Containers page in the Report drop-down. **Note:** When a Container Details report is run, the order of output is sorted as follows:

1.  Loose parts
    
2.  Assemblies (don't list child parts)
    
3.  Packages (do list child assemblies and loose parts)
    
4.  Containers (repeats the list above)
    

To configure a Container Details report:

1.  Under **Admin > Company > Reports**, create a new report where **Item Type is Container Details**, **Format is PDF**, and **Template** can either be empty, in which case the Stratus default Containers template will be used, or, you can configure your own [**template**](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/1558249473 "https://gtpservices.atlassian.net/wiki/spaces/SK/pages/1558249473").
    
2.  Under the report's **Report Fields**, add all the available Report Fields to the report. You can remove fields later.
    
3.  To run the report, go to the **Containers** page and open a container that includes one or more parts, assemblies, or packages. The report will be available in the **Report drop-down**.
    
4.  Once the report is selected, click the **Print** button and the report will generate at the bottom of the page. Below is an example of an out-of-the-box report.  
    
5.  By default, the above report used the default Stratus Container Details Template. You can configure your own template as needed.
    

## Example: Container Part, Assembly, or Package Report

A Container Part, Assembly, or Package report is targeted to Shop or Field workers to provide them with container information to help locate items.

To configure a Container Part, Assembly, or Package Report:

1.  Create a separate **Report** (as needed) to include Parts, Assemblies, and Packages.
    
    1.  To include **Assemblies** in a container report
        
        1.  **Report Field -** Stratus.Assembly.Container
            
        2.  **Format** = CSV
            
        3.  **Item Type** = Assembly
            
    2.  To includes **Parts** in a container report:
        
        1.  **Report Field -** Stratus.Part.Container
            
        2.  **Format** = CSV
            
        3.  **Item Type** = Part
            
    3.  To includes **Packages** in a container report:
        
        1.  **Report Field -** Stratus.Package.Container
            
        2.  **Format** = CSV
            
        3.  **Item Type** = Package
            
2.  Create a **Container** under Admin > Company > Containers. See the [**Containers (Admin)**](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/246317057 "https://gtpservices.atlassian.net/wiki/spaces/SK/pages/246317057") article for more information.
    
3.  Run the report from either the Models or Packages Viewer. Below is an example of a report that includes Assemblies in a Container.
    

## Example: Package Assemblies Batch Report PDF

The report gives you the ability to batch generate spool sheet reports (PDF) for all assemblies in a package. Creating the report is a 2-step process: 1) Create a Template and 2) Create the Report. If you already have a spool report defined for use on the Assemblies > Viewer page, you can skip the setup below and running the report batch from the Package's Attachments tab.

1.  Create the Template. See the [**Templates (Admin)**](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/1558249473 "https://gtpservices.atlassian.net/wiki/spaces/SK/pages/1558249473") article for more information.
    
2.  Identify or create a report where:
    
    1.  **Fomat** = PDF
        
    2.  **Item Type** = Part
        
    3.  **Assembly Viewer** = Checked
        
    4.  **Template** = Includes one of your templates (created on the Templates tab)
        
3.  Add report fields to the report.
    
4.  To run the report, open a package, click the **Attachments** tab, and select the report. See the [Package Assemblies Batch Report PDF](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/200998967/Package+Attachments#PackageAssembliesBatchReportPDF "https://gtpservices.atlassian.net/wiki/spaces/SK/pages/200998967/Package+Attachments#PackageAssembliesBatchReportPDF") section of the [Package Attachments](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/200998967 "https://gtpservices.atlassian.net/wiki/spaces/SK/pages/200998967") article for more information.
    

## Example: Configure an Alias for use inside a report field

To configure an Alias for use inside a report field:

1.  Create an Alias (Duct Width and Duct Depth in the example below):
    
2.  Create a Field under Admin > Company > Fields that uses the Alias in the Expression.
    
3.  Create a Report that includes the Field:
    
4.  Results if the report was an Assembly Viewer report:
    

## Example: Fab Packet

A Master Report (Item Type) can be used to combine reports into a single report. A "Fab Packet" PDF is an example of a Package level report that combines reports (sub-reports) that may also be targeted for the Assembly Viewer and Package Details pages; the result is a report that could include a traveler and all spool sheets in one PDF.

To create a Fab Packet:

1.  Create one or more sub-reports (CSV or PDF) or identify existing reports.
    
    1.  **Format** = CSV or PDF
        
    2.  **Item Type** = **Part**, **Assembly** (PDF), **Package Details** (PDF)
        
    3.  **Filter** – Optional
        
    4.  **Assembly Viewer** – Checked for reports targeted to display on the Assemblies Viewer page.
        
    5.  **Template** – An **Assembly Viewer report** and a **Package Details report** are associated with a Template.
        
2.  **Create a Master report**
    
    1.  **Item Type** = Master (PDF)
        
    2.  Add any of the above report Item Types to the Master report. Reports will display in the order they were entered as sub-reports.  
        **Note:** If an Assembly report is included, the Master report will create an assembly report for each assembly in the package. 
        
3.  Run the Master Report from the **Packages Details > Attachments** page. 
    

## Example: Stratus.Assembly.Connected Property

The Stratus.Assembly.Connected property can be used to print labels or generate reports that identify the connecting assemblies. Using this property to generate a label, one or more labels can be printed and placed on parts to identify the connecting assembly.

To use the Stratus.Assembly.Connected property, you’ll add either a .Single or .Multiple depending on what you want to accomplish.

1.  **Stratus.Assembly.ConnectedAssembly.Single** – This property will only print one label per connected assembly, which may be a better option for a rack.
    
2.  **Stratus.Assembly.ConnectedAssembly.Multiple** – This property will print a label for each connection.
    

**To configure a Report:**

1.  Under **Admin > Company > Reports**, locate or create a report where:
    
    1.  **Format** = ZPL (for a label) or CSV (for a tabular report)
        
    

**For a ZPL Label Format**

1.  Click the **Edit Label Template** button and add one of the properties to the Label Template:
    
    1.  **Stratus.Assembly.ConnectedAssembly.Single**
        
    2.  **Stratus.Assembly.ConnectedAssembly.Multiple**  
        
2.  **Examples based on this assembly:**  
    
    1.  **.Single** - 2 labels should print:
        
        1.  **One for assembly Duct01-01-0001 with attached assembly Duct02-02-0002.**    
            
        2.  **One for assembly Duct02-02-0002 with attached assembly Duct01-01-0001.**  
            
    2.  **.Multiple** – 6 labels should print (not shown)
        
        1.  3 for assembly Duct01-01-0001 with attached assembly Duct02-02-0002
            
        2.  3 for assembly Duct02-02-002with attached assembly Duct01-01-0001
            

**For CSV Report Format**

1.  **.Single Example** \- When a report with the same assembly connected (as above) is run for the CSV format, the report will display the following:
    
2.  **.Multiple Example**  
    
3.  **.Multiple Example when the assembly is connected to 2 other different assemblies.**  
    

## Example: Extract the X, Y, and Z Coordinates of a Part’s Bounding Box Center

The X, Y, and Z coordinates of a part’s bounding box center can now be extracted. This means that you can use something like a nested rod family in conjunction with control points, a filter, and a report to generate your own point files in whatever configuration you need. Stack this with the ability to renumber parts based on properties, schemes, and iterative numbering routines and you may very well be enabled to manage points right inside of Stratus.

The following properties can now be found in reports and used in fields:

Stratus.Part.Point.X

Stratus.Part.Point.Y

Stratus.Part.Point.Z

Below are some examples that demonstrate the X and Y for a rod will always be exactly what you expect them to be, which is the center of the rod. On the other hand, the Z will be halfway down the length of your rod. In most cases, this won’t matter, but if it does you can use a Stratus field to give you the top Z by adding half of the rod length to the Stratus.Part.Point.Z value. \[NewZField = {Stratus.Part.Point.Z} + ((Rod Length)/2)\].

Below is an example of the new properties on a rod:

Below is an example of what that bounding box and point look like from a **front view**:  

Below is an example of what that bounding box and point look like from a **top view**:  

For reports, users can specify which parts are used through filtering on the report. In the example above, a Shared Nested threaded rod family in the hangers was found and their XY data was extracted. Since the rod was symmetric you know that the XY data is going to be the middle of the rod.

This feature also enables users to use the Stratus sPoint or even create your own families to embed for point export utilities.

## Example: Report Average and Sum Hours

Tracking Status hours can be displayed in a report using the new Aggregate Report Field options (Average or Sum). See the [**Added Aggregate Report Column to Include Average**](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/1286569989#Added-Aggregate-Report-Column-to-Include-Average "https://gtpservices.atlassian.net/wiki/spaces/SK/pages/1286569989#Added-Aggregate-Report-Column-to-Include-Average") section for more information. The Aggregate column replaced the previous Total Values column. Report Fields that had Total Values set to Yes have been converted to use the new Sum option.

This example averages leverage the fields:

-   Stratus.Assembly.TrackingStatusLogDT
    
-   Stratus.Package.TrackingStatusLogDT
    

This example also leverages the HoursInTrackingStatus() field expression function.

**Example - Assembly Report to Track Times**

**Example - Package Report to Track Times**

Below are examples:

1.  Family report
    
2.  Shared Nested Parent Family
    

## Example: BIM Area Elevation Report Properties XYZ for Part Connectors C1, C2, C3, C4

BIM Area Elevation report properties XYZ for Part Connectors C1, C2, C3, C4. A workcase example is installing a waste stack where there is a sanitee looking out to a sink and the elevation of the sanitee is needed. Depending on how the object is configured, the elevation can now be from one of the connectors' Z value which would inform the user that the sanitee is 18” above the floor. This eliminates the need to look at an install drawing because the spool drawing can include the install elevation. This value can:

-   Add positioning to sloped pipe labels
    
-   Eliminate the need to look at an install drawing because the spool drawing can include the install elevation
    
-   Provide QA/QC information
    
-   Generate a CSV report to send to a Total Station
    

## Example: Hanger Point Report

Create two (2) sub-reports, one for point 1 and one for point 2, and then a Master report to combine them. In this solution, the report headers in the second report (Ex. Sub Points C2) are ignored so the end result of the master report is correct. In addition, a suffix (Ex. -1 or -2) can be used to distinguish points. In the example below, the Item Number is used as the name but another part identifier can be easily be configured. Below is an example report configuration. **Note**: A part filter may need to be applied to the second hanger point sub-report to only include points for trapeze hangers, filtering out single rod parts like clevis.

**Master Report**

**Sub-report for C2**

**Sub-report for C3**

**Example Report to Download**

## Other Report Videos

## **10-10-19 Implementation Webinar - Trade Specific Reporting (32:31)**

<iframe allowfullscreen="" allowtransparency="true" data-hasbody="false" data-layout="default" data-local-id="a1486e67-3782-4306-90fc-78c8d1874447" data-macro-id="edd0d4c0-0f47-4d63-ad6b-e48a188dfc1b" data-macro-name="widget" frameborder="0" height="364" mozallowfullscreen="" data-delayed-src="https://player.vimeo.com/video/367321434?h=embed" webkitallowfullscreen="" width="640"></iframe>

## **05-16-19 Implementation Webinar - Pipe Reports (19:54)**

This webinar covers how to create a pipe report.

1.  Using the Properties tool to review and select properties to include in the report. 1:23
    
2.  Create a new report (Test – Linear Pipe Length Report) – 2:20
    
3.  Report Format options – 2:40
    
4.  Part Filter - 4:26          
    
5.  Report Fields – 5:23
    
6.  Extract out quantities for pipe fittings – 11:04
    
7.  Create a new report (Test – Pipe Fitting Report) – 12:19
    
8.  Create a Master Report (Test - Pipe Master Report) – 15:02
    
    <iframe allowfullscreen="" allowtransparency="true" data-hasbody="false" data-layout="default" data-local-id="f7040e12-6922-4d16-ab09-f43ed1784fdb" data-macro-id="ec330090-5a2d-438f-8813-6e66498ff843" data-macro-name="widget" frameborder="0" height="364" mozallowfullscreen="" data-delayed-src="https://player.vimeo.com/video/343729479?h=embed" webkitallowfullscreen="" width="640"></iframe>
---
created: 2025-06-25T06:27:05 (UTC -04:00)
tags: []
source: https://gtpservices.atlassian.net/wiki/spaces/SK/pages/1369834103/Service+Templates+Admin
author: 
---

# Service Templates (Admin) - STRATUS Knowledge Base - Confluence

> ## Excerpt
> Service Templates are only used with the GTP Lightning and GTP Field Orderz Plus integrations. GTP Lightning is used to publish the Fabrication database to the company. GTP Field Orderz is a simple digital modeling solution integrated with STRATUS for the field that can leverage the Fabrication database. Once a company has uploaded their Fabrication database, the Service Templates page lists service templates that span all projects and link to Fabrication service templates.

---
Service Templates are only used with the GTP Lightning and [**GTP Field Orderz**](https://www.fieldorderz.com/ "https://www.fieldorderz.com/") Plus integrations. GTP Lightning is used to publish the Fabrication database to the company. [**GTP Field Orderz**](https://www.fieldorderz.com/ "https://www.fieldorderz.com/") is a simple digital modeling solution integrated with STRATUS for the field that can leverage the Fabrication database. Once a company has uploaded their Fabrication database, the Service Templates page lists service templates that span all projects and link to Fabrication service templates.

-   1[Configuration](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/1369834103/Service+Templates+Admin#ServiceTemplates(Admin)-Configuration)

## Configuration

**Editable fields include Group and Code**:

![](https://gtpservices.atlassian.net/wiki/download/thumbnails/1369834103/image2021-3-18_8-24-40.png?version=1&modificationDate=1616073881996&cacheVersion=1&api=v2&width=950&height=337)

1.  **Name** \- The Service Name.
    
2.  **Source** \- Source values are either STRATUS or Fabrication.
    
3.  **Fab Config** - Fab Config is only used by the FieldOrderz Plus integration.
    
4.  **Fab Id** - Fab Id is only used by the FieldOrderz Plus integration.
    
5.  **Group** \- Organize Service Templates by group name.
    
6.  **Code** \- Code only works for customers who have a built-in integration with ESTmep. It will be blank for most companies.
---
created: 2025-06-25T06:30:43 (UTC -04:00)
tags: []
source: https://gtpservices.atlassian.net/wiki/spaces/SK/pages/10518994/Settings+Admin
author: 
---

# Settings (Admin) - STRATUS Knowledge Base - Confluence

> ## Excerpt
> The Settings tab provides: 1) Corporate Settings, 2) Settings that are Common to Revit and AutoCAD, 3) Settings that are Specific to AutoCAD, 4) Settings that are Specific to Revit, 6) How to Configure Custom Data Field in the Fabrication Database, and 7) How to Configure Revit Shared Parameter Property.

---
The Settings tab provides: 1) Corporate Settings, 2) Settings that are Common to Revit and AutoCAD, 3) Settings that are Specific to AutoCAD, 4) Settings that are Specific to Revit, 6) How to Configure Custom Data Field in the Fabrication Database, and 7) How to Configure Revit Shared Parameter Property.

-   1 [Corporate Settings (address, phone, coordinates)](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/10518994/Settings+Admin#Corporate-Settings-(address%2C-phone%2C-coordinates))
    -   1.1 [Units of Imperial Measure](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/10518994/Settings+Admin#Units-of-Imperial-Measure)
        -   1.1.1 [Example: Part Properties](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/10518994/Settings+Admin#Example%3A-Part-Properties)
        -   1.1.2 [Example: AsFeetInch Function](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/10518994/Settings+Admin#Example%3A-AsFeetInch-Function)
    -   1.2 [GTP Quick Pass](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/10518994/Settings+Admin#GTP-Quick-Pass)
    -   1.3 [GPS Coordinates](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/10518994/Settings+Admin#GPS-Coordinates)
-   2 [AutoCAD & Revit (property mapping, conflict resolution)](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/10518994/Settings+Admin#AutoCAD-%26-Revit-(property-mapping%2C-conflict-resolution))
    -   2.1 [Common to AutoCAD, Revit, CAMduct, and ESTmep](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/10518994/Settings+Admin#Common-to-AutoCAD%2C-Revit%2C-CAMduct%2C-and-ESTmep)
        -   2.1.1 [Property To Map To QR Code](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/10518994/Settings+Admin#Property-To-Map-To-QR-Code)
            -   2.1.1.1 [AutoCAD](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/10518994/Settings+Admin#AutoCAD)
            -   2.1.1.2 [Revit](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/10518994/Settings+Admin#Revit)
        -   2.1.2 [Property To Map To Package Name](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/10518994/Settings+Admin#Property-To-Map-To-Package-Name)
            -   2.1.2.1 [AutoCAD](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/10518994/Settings+Admin#AutoCAD.1)
            -   2.1.2.2 [Revit](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/10518994/Settings+Admin#Revit.1)
        -   2.1.3 [Include Package Number Prefix with Name](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/10518994/Settings+Admin#Include-Package-Number-Prefix-with-Name)
        -   2.1.4 [Use Pattern Dimension Names (Available in v7.3)](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/10518994/Settings+Admin#Use-Pattern-Dimension-Names-(Available-in-v7.3))
    -   2.2 [Specific to CAMduct, ESTmep, and MAJ](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/10518994/Settings+Admin#Specific-to-CAMduct%2C-ESTmep%2C-and-MAJ)
        -   2.2.1 [Property for Model Stamp (Required)](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/10518994/Settings+Admin#Property-for-Model-Stamp-(Required))
        -   2.2.2 [Property for Project Number](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/10518994/Settings+Admin#Property-for-Project-Number)
        -   2.2.3 [Property for Project Name](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/10518994/Settings+Admin#Property-for-Project-Name)
            -   2.2.3.1 [Include Project Number Prefix with Name](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/10518994/Settings+Admin#Include-Project-Number-Prefix-with-Name)
        -   2.2.4 [Property for Project Description](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/10518994/Settings+Admin#Property-for-Project-Description)
            -   2.2.4.1 [Set Project Color](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/10518994/Settings+Admin#Set-Project-Color)
        -   2.2.5 [Property for Package Number](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/10518994/Settings+Admin#Property-for-Package-Number)
        -   2.2.6 [Property for Package Name](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/10518994/Settings+Admin#Property-for-Package-Name)
            -   2.2.6.1 [Include Package Number Prefix with Name](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/10518994/Settings+Admin#Include-Package-Number-Prefix-with-Name.1)
        -   2.2.7 [Property for Package Description](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/10518994/Settings+Admin#Property-for-Package-Description)
        -   2.2.8 [Set Package Required Date](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/10518994/Settings+Admin#Set-Package-Required-Date)
    -   2.3 [Part Property Names](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/10518994/Settings+Admin#Part-Property-Names)
    -   2.4 [Specific to AutoCAD](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/10518994/Settings+Admin#Specific-to-AutoCAD)
        -   2.4.1 [Create Spool Drawings During Import](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/10518994/Settings+Admin#Create-Spool-Drawings-During-Import)
        -   2.4.2 [Publish Spool Drawings](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/10518994/Settings+Admin#Publish-Spool-Drawings)
        -   2.4.3 [Assembly Conflict Resolution](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/10518994/Settings+Admin#Assembly-Conflict-Resolution)
            -   2.4.3.1 [Community Discussion: Assembly Conflict Resolution](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/10518994/Settings+Admin#Community-Discussion%3A-Assembly-Conflict-Resolution)
        -   2.4.4 [Point Export Units](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/10518994/Settings+Admin#Point-Export-Units)
    -   2.5 [Specific to Revit](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/10518994/Settings+Admin#Specific-to-Revit)
        -   2.5.1 [Property To Map To Status Name](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/10518994/Settings+Admin#Property-To-Map-To-Status-Name)
        -   2.5.2 [Property To Map To Item Number](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/10518994/Settings+Admin#Property-To-Map-To-Item-Number)
        -   2.5.3 [Exclude Imports into Fabrication "Item Number" Property](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/10518994/Settings+Admin#Exclude-Imports-into-Fabrication-%22Item-Number%22-Property)
        -   2.5.4 [Auto-Generate Assembly Views and Sheets](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/10518994/Settings+Admin#Auto-Generate-Assembly-Views-and-Sheets)
        -   2.5.5 [Publish Conduit Assemblies](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/10518994/Settings+Admin#Publish-Conduit-Assemblies)
        -   2.5.6 [Publish HangerWorks Assemblies](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/10518994/Settings+Admin#Publish-HangerWorks-Assemblies)
        -   2.5.7 [Use Parameter Mapping for Assembly Import and Publish](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/10518994/Settings+Admin#Use-Parameter-Mapping-for-Assembly-Import-and-Publish)
        -   2.5.8 [Property to Map to Assemblies](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/10518994/Settings+Admin#Property-to-Map-to-Assemblies)
        -   2.5.9 [Always Publish Revit Assemblies Checkbox](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/10518994/Settings+Admin#Always-Publish-Revit-Assemblies-Checkbox)
        -   2.5.10 [Property To Associate Sheets With Assemblies](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/10518994/Settings+Admin#Property-To-Associate-Sheets-With-Assemblies)
        -   2.5.11 [Assembly Conflict Resolution](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/10518994/Settings+Admin#Assembly-Conflict-Resolution.1)
            -   2.5.11.1 [Community Discussion: Assembly Conflict Resolution](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/10518994/Settings+Admin#Community-Discussion%3A-Assembly-Conflict-Resolution.1)
        -   2.5.12 [Point Export Units](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/10518994/Settings+Admin#Point-Export-Units.1)
-   3 [Tasks (workflows, definitions)](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/10518994/Settings+Admin#%5BhardBreak%5DTasks-(workflows%2C-definitions))
    -   3.1 [Task Definitions](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/10518994/Settings+Admin#Task-Definitions)
    -   3.2 [Task Workflows](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/10518994/Settings+Admin#Task-Workflows)
-   4 [BOM (default line item mapping)](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/10518994/Settings+Admin#BOM-(default-line-item-mapping))
-   5 [Schedule](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/10518994/Settings+Admin#Schedule)
    -   5.1 [Configure Package Actuals Data Source](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/10518994/Settings+Admin#Configure-Package-Actuals-Data-Source)
    -   5.2 [Example - Progress set to Tracking Status](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/10518994/Settings+Admin#Example---Progress-set-to-Tracking-Status)
    -   5.3 [Example - Hours Report Field](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/10518994/Settings+Admin#Example---Hours-Report-Field)
-   6 [Additional Information](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/10518994/Settings+Admin#Additional-Information)
    -   6.1 [Activities Logging for Publish Setting Changes](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/10518994/Settings+Admin#Activities-Logging-for-Publish-Setting-Changes)
    -   6.2 [How to Configure Custom Data Field in the Fabrication Database](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/10518994/Settings+Admin#How-to-Configure-Custom-Data-Field-in-the-Fabrication-Database) 
    -   6.3 [How to Configure Revit Shared Parameter Property](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/10518994/Settings+Admin#How-to-Configure-Revit-Shared-Parameter-Property)

## Corporate Settings (address, phone, coordinates)

Enter your corporate settings. **GPS Coordinates** are used for those customers using the Stratus Supplier portal. **Units of Imperial Measure** set your Leading Zero preference when a length value is displayed anywhere in Stratus.

## **Units of Imperial Measure**

The **Units of Imperial Measure** setting sets your **Leading Zero** preference when a length value is displayed anywhere in Stratus.

### Example: Part Properties

1.  For Properties, under Admin > Company > Part Templates > Properties, set the **Display Format** for the Length Property for the Part Template to Fraction Feet/inches or Fraction Inches to leverage the Leading Zero setting.
    
2.  In this example, the Leading Zero is set to Feet and Inches and the Part Template’s Display Format is set to Fraction Feet/inches:
    

### Example: AsFeetInch Function

If your company uses **AsFeetInch** function, it was configured as an Expression in a Field. A new optional parameter has been added to the AsFeetInch which can be set to manage the Leading Zero. As a result, the Leading Zero setting under Admin > Company > Settings is ignored.

Below is an example before the new optional leading parameter was available:  
AsFeetInch({Stratus.Field.GTP Linear Feet},4,0)

Below is an example of using the new optional Leading Zero parameter at the end of the expression:

**Syntax:** AsFeetInch(Feet, Precision (optional, defaults to 8), Format (optional, defaults to 0, 0=feet-inch-fraction, 1=inches-fraction), Leading 0’s)

Leading 0’s Optional Settings:

-   Default = 3
    
-   0 = Leading Zero = Feet And Inches; Ex. **AsFeetInch**({**Stratus.Field.GTP Linear Feet**}**,**4**,**0**,**0)
    
-   1 = Leading Zero = Inches; Ex. **AsFeetInch**({**Stratus.Field.GTP Linear Feet**}**,**4**,**0**,**1)
    
-   2 = Leading Zero = Feet; Ex. **AsFeetInch**({**Stratus.Field.GTP Linear Feet**}**,**4**,**0**,**2
    
-   3 = Leading Zero = None; Ex. **AsFeetInch**({**Stratus.Field.GTP Linear Feet**}**,**4**,**0**,**3)
    

Below is an example to display the AsFeetInch expression with the default (3) no leading 0’s:

AsFeetInch({Stratus.Field.GTP Linear Feet},4,0,3)

## GTP Quick Pass

The GTP Quick Pass will only display if the Stratus Service Desk has enabled the option for the company. Contact the [**Stratus Service Desk**](https://gtpservices.atlassian.net/servicedesk/customer/portal/3 "https://gtpservices.atlassian.net/servicedesk/customer/portal/3") for more information.

Once enabled, use the **GTP Quick Pass** section to restrict access to [**GTP Quick Pass**](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/2117828609 "https://gtpservices.atlassian.net/wiki/spaces/SK/pages/2117828609") to an IP address range.

1.  **IP Range**
    
    1.  **Default** - By default, the IP Range is blank or will be 0.0.0.0/0 which will allow the device IP Address to use [**GTP Quick Pass**](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/2117828609 "https://gtpservices.atlassian.net/wiki/spaces/SK/pages/2117828609"). Hover over the information icon to display how to enter the IP Range.
        
    2.  **IP Range** - Enter an IP Range including the mask from 1-32.
        
2.  **Max Failed Attempts per IP Range**
    
    1.  **Blank** - If blank a user attempting to login by scanning their QuickPass will have an infinite number of retries. For each failure, the following message will display.
        
    2.  **Number** - If a number of attempts is entered, a user attempting to login by scanning their QuickPass will have that number of retries. After the final retry, the user’s Status will be set to Disabled under Admin > Company > Users.
        
        1.  Email subject: QuickPass user has been disabled
            
        2.  Email body: QuickPass user FirstName LastName has been disabled due to multiple invalid login attempts from unfamiliar IP Ranges.
            
        3.  **Change Status to Active** - For the user to successfully retry after being Disabled, a Company Administrator will need to change the user’s Status to Active.
            
        4.  The user will have one try to successfully scan to login before being Disabled again.
            
        5.  Once the user successfully scans to login, their number of **Max Failed Attempts per IP Range** is also reset.
            
3.  Once set, any device attempting to access [**GTP Quick Pass**](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/2117828609 "https://gtpservices.atlassian.net/wiki/spaces/SK/pages/2117828609") will need to be within the configured IP Range.
    
4.  Click the **Regenerate Encryption Key** button to reset the encryption key. All current printed GTP Quick Pass QR Codes will be disabled. Users will need to print a new GTP Quick Pass.
    
    1.  The following message will display.
        
    2.  Click **Regenerate**.
        
    3.  Once the page refreshes, the Last Regenerated By will be updated.
        
    4.  Users still using a disabled GTP Quick Pass will see the following on their next action in Stratus.
        

## GPS Coordinates

GPS Coordinates are important for customers who are using GTP Connect to connect with suppliers. Suppliers have a limited service area based on GPS Coordinates. If your company's GPS Coordinates are not within the supplier's service area, then your company will not display in their list of possible customers.

One way to determine your Latitude/Longitude is to:

1.  Open Google Maps at [https://www.google.com/maps/](https://www.google.com/maps/ "https://www.google.com/maps/").
    
2.  Right-click on the road in front of your company. The Latitude and Longitude will display.  
    
    ![](blob:https://gtpservices.atlassian.net/a7f54de9-1068-4994-8686-0b0c73626f2a)
    
3.  Left-click on these coordinates and they will be copied to your clipboard. The left number is Latitude and the right number is Longitude.
    
4.  Paste this into the Latitude field. You will need to delete the comma and the Longitude value.
    
5.  Paste this into the Longitude field. You will need to delete the comma and the Latitude value.
    

## AutoCAD & Revit (property mapping, conflict resolution)

## Common to AutoCAD, Revit, CAMduct, and ESTmep

### Property To Map To QR Code

The **Property To Map To QR Code** property enables you to add the Stratus QR Code to part items in the AutoCAD drawing or to Revit part family parts in your Revit model. 

#### AutoCAD

To use the **Property To Map To QR Code** setting in AutoCAD, enter the parameter name in Stratus Settings and then configure a custom data field in the Fabrication database with the same name. See the **Configure Custom Data Field in the Fabrication Database** below.  When the .dwg is imported, the Stratus QR Code will populate this field for all parts.

#### Revit

To use the **Property To Map To QR Code** setting in Revit, you’ll need to enter the parameter name in settings and then configure a project parameter in Revit with the same name. You can also create a Shared Parameter. When the .rvt is imported, the Stratus QR Code will populate this field for all parts. See the **Configure Revit Shared Parameter Property** example below.

### Property To Map To Package Name

The **Property To Map To Package Name** property enables you to add the Stratus Package Name to part items in the AutoCAD drawing or Revit model.

#### AutoCAD

To use the **Property To Map To Package Name** setting, enter the parameter name in Stratus Settings, and then configure a Custom Data Fields on Fabrication Parts/ITM's n the Fabrication database with the same name. See the **Configure Custom Data Field in the Fabrication Database** below.  When the .dwg is imported, the Stratus QR Code will populate this field for all parts.

#### Revit

To use the **Property To Map To Package Name** setting in Revit, you’ll need to enter the parameter name in settings and then configure a project parameter in Revit with the same name. You can also create a Shared Parameter. When the .rvt is imported, the Stratus Package Name will populate this field for all parts. See the **Configure Revit Shared Parameter Property** example below.

### Include Package Number Prefix with Name

### Use Pattern Dimension Names (Available in v7.3)

When **Use Pattern Dimension Names** is checked, Fabrication item dimension properties will use the default Autodesk dimension names.

## Specific to CAMduct, ESTmep, and MAJ

The setting drop-down options in the **Specific to CAMduct, ESTmep, and MAJ** refer to fields in the Fabrication Database under **Job Information** General and Project subtabs. Options selected in Stratus will display in the corresponding Fabrication Database field with the exception of the recommended CustomerPONumber field used for the **Property for Model Stamp**.

**General**

**Project**

**Stratus Settings**

### Property for Model Stamp (Required)

The **Property for Model Stamp** is set to the **CustomerPONumber** property by default. This setting must be configured which tells Stratus which field can be used within the Fabrication Database to store the model’s unique id. If this ID gets changed within the Fabrication Database, then the Stratus link to the model will no longer exist. For this purpose, there are a fixed number of options that Stratus can use. The **CustomerPONumber** property is recommended as it does not display in most Fabrication Databases under Job Information making it a safe choice. Under Project, a field like Job Project Information is not a good choice as it can be overwritten.

### Property for Project Number

The **Property for Project Number** setting defaults to **None** which means that no Project Number will be imported into the Fabrication Database. If needed, select a Fabrication Database property to store the **Property for Project Number** from Stratus.

### Property for Project Name

The **Property for Project Name** setting defaults to **DescriptionField1** which means that the Project Name from Stratus will be stored in the DescriptionField1 Fabrication Database property.

#### Include Project Number Prefix with Name

-   **Checked (default)** - The **Include Project Number Prefix with Name** is checked by default which means that under Admin > Projects the **Name Override** value will display in the selected Fabrication Database property.
    
-   **Unchecked** - When unchecked, the **Name** field under Admin > Projects will be used which is derived from BIM 360.
    

### Property for Project Description

The **Property for Project Description** setting defaults to **DescriptionField2** which means that the Description under Admin > Projects will be stored in the DescriptionField2 Fabrication Database property.

#### Set Project Color

-   **Checked (default)** - The **Set Project Color** is checked by default which means that under Admin > Projects the **Color** value will display in the Color Fabrication Database property.
    
-   **Unchecked** \- When unchecked, the Stratus project color will not be imported into the Fabrication Database.
    

### Property for Package Number

The **Property for Package Number** setting defaults to **None**. If needed, select a Fabrication Database property.

### Property for Package Name

The **Property for Package Name** setting defaults to **None**. If needed, select a Fabrication Database property.

#### Include Package Number Prefix with Name

The **Include Package Number Prefix with Name** is set by combining the specific package number and package name on the Packages Dashboard.

### Property for Package Description

The **Property for Package Description** setting defaults to **Reference** which will populate the Job Reference Fabrication Database property with the package’s Description under Packages > Package > Properties > General, if any.

### Set Package Required Date

The **Set Package Required Date** setting defaults to **Required** which corresponds to the package’s Required date. This date will populate the the Job Date Fabrication Database property.

## Part Property Names

Part Properties can be excluded from being published and from being available in Stratus once they are published. This is especially useful when a third-party software has added hundreds of properties to parts in the model which significantly increases the publish time. For more information see the [**Exclude Selected Part Properties During Publish**](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/217809750/Part+Templates+Admin#Exclude-Selected-Part-Properties-During-Publish "https://gtpservices.atlassian.net/wiki/spaces/SK/pages/217809750/Part+Templates+Admin#Exclude-Selected-Part-Properties-During-Publish") section of the Part Templates (Admin) article. Locked properties can not be Excluded.

## Specific to AutoCAD

### Create Spool Drawings During Import

**Create Spool Drawings During Import** - When unchecked, AutoCAD assembly drawings will not be created during the import process for AutoCAD drawings. When checked, during the IMPORT command inside AutoCAD, Stratus will create spool assembly DWGs for each new assembly defined in Stratus using the spool drawing template dwg file that exists locally. The purpose of this option when unchecked is to accommodate AutoCAD users who are moving away from creating dedicated 2D spool drawings and instead rely on Stratus 3D spools. 

### Publish Spool Drawings

**Publish Spool Drawings** - Spool drawings published to Stratus using this option display in the Assembly Viewer under the CAD Sheet tab for each assembly. This feature also works when the attached part is not included in the assembly.  An example would be an assembly that contains straight pipe and some (not all) olets tapped into the pipe. Import the data back into AutoCad. The drawing of the assembly is correct.

**Spool Drawings** are backed up and saved if **Spool Drawings During Import** setting under Admin > Company > Settings is enabled.

1.  Older spool drawings will be backed up and renamed with a timestamp and the newest or most current spool drawing will not have a timestamp appended to it keeping the original spool name.                               
    
2.  The Spool Drawing without a timestamp will be the drawing published to Assemblies > CAD Sheets if the Publish Spool Drawings is enabled under Admin > Company > Settings.
    
3.  If the current drawing (the drawing without a timestamp) is open when importing in changes back into AutoCAD the DWG file will not update. Please close this file before importing changes.
    

### Assembly Conflict Resolution

Assembly Conflict Resolution settings are set at the Company level and can be overridden at the Project level.

Under Admin > Company > Settings, the **Assembly Conflict Resolution** setting enables you to determine how Stratus should handle assembly import conflicts. This setting can be set at a company level and overridden at a project level. The options include:

-   **Stratus is always right** - When **Stratus is always right** is selected, any assemblies created in Revit that conflict with an assembly in Stratus will be considered “invalid” and will not be published to Stratus.
    
-   **Revit is always right** - When **Revit is always right** is selected, any assemblies created in Stratus that conflict with an assembly in Revit will be considered “invalid” and will not be imported to the mapped parameter for the assembly. 
    
-   **Prompt User** - When **Prompt User** is selected, the behavior will follow the selected rule above at the time of the prompt.  Any discrepancy between Stratus and Revit requires a prompt.  If the assembly is in Revit and contains only parts that are not in any Stratus assemblies, then, the Prompt will not display.
    

The Stratus Synchronize Data flow diagrams describe how data is synchronized when Revit/AutoCAD is always right and when Stratus is always right.

See the Stratus Community discussion [**Assembly Conflict Resolution (Revit), which do you choose and why?**](https://community.stratus.build/t/assembly-conflict-resolution-revit-which-do-you-choose-and-why/1291 "https://community.stratus.build/t/assembly-conflict-resolution-revit-which-do-you-choose-and-why/1291")

### Point Export Units

Point Export Units can be set for (Feet, Inches, Meters, Millimeters).  Point Export Units can be set here at the Company level and overridden on a per-project basis under Admin > Project Settings. See the [**Project Settings (Admin)**](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/217907482/Project+Settings+Admin "https://gtpservices.atlassian.net/wiki/spaces/SK/pages/217907482/Project+Settings+Admin") article for more information about the settings. See the [**Package Point List**](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/166821968 "https://gtpservices.atlassian.net/wiki/spaces/SK/pages/166821968") article for more information about Point List generated for a Package.

## Specific to Revit

### Property To Map To Status Name

**Property To Map To Status Name** - This property enables you to add the Stratus Status to Revit part family parts in your Revit model. To use the **Property To Map To Status Name** setting in Revit, you’ll need to enter the parameter name in settings and then configure a project parameter in Revit with the same name. You can also create a [**Shared Parameter**](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/10518994/Settings+Admin#How-to-Configure-Revit-Shared-Parameter-Property "https://gtpservices.atlassian.net/wiki/spaces/SK/pages/10518994/Settings+Admin#How-to-Configure-Revit-Shared-Parameter-Property"). When the .rvt is imported, the Stratus Status name will populate this field for all parts.

### Property To Map To Item Number

**Property To Map To Item Number** -  This property enables you to add the Stratus Item Number to Revit part family parts in your Revit model. To use the **Property To Map To Item Number** setting in Revit, you’ll need to enter the parameter name in settings and then configure a project parameter in Revit with the same name. You can also create a Shared Parameter (See below). When the .rvt is imported, the Stratus Item Number will populate this field.

To create a project parameter in Revit, go to **Manage** > **Project Parameters**.

1.  Add the new project parameter (Ex. Stratus Item Number), set the type to Text, and apply it to all Categories or specific categories. You can also add this to a specific group.
    
2.  After using the Stratus Import the Item Numbers will display in the parameter.
    

### Exclude Imports into Fabrication "Item Number" Property

Exclude Imports into Fabrication "Item Number" Property - When checked the Stratus Revit addin will NOT import your Stratus.Part.Number values into the Fabrication Item Number property. This can be useful when using Revit groups as they do not support unique Item Number values on parts contained within them.

### Auto-Generate Assembly Views and Sheets

**Auto-Generate Assembly Views and Sheets** - When checked the Create Assembly and Import commands in Revit will automatically generate multiple views and a sheet for the new Assembly in Revit.  When disabled, only the Assembly object itself will be created by the Create Assembly and Import commands.

### Publish Conduit Assemblies

**Publish Conduit Assemblies** - For companies that publish with a third-party Revit add-in that generates assemblies, under Admin > Company > Settings, the setting **Publish Conduit Assemblies** has been added so that you control whether you want to publish the assemblies (checked) or not (unchecked).

### Publish HangerWorks Assemblies

**Publish HangerWorks Assemblies** - For companies that use HangerWorks, this third-party Revit add-in generates assemblies.  Under Admin > Company > Settings, the setting **Publish Dewalt HangerWorks Assemblies** has been added so that you control whether you want to publish the assemblies (checked) or not (unchecked).

### Use Parameter Mapping for Assembly Import and Publish

Use Parameter Mapping for Assembly Import and Publish - This option provides more control over how Revit assemblies are handled during the Import and Publish process.

**Assembly Nomenclature**

-   _Revit Assembly_ – A true Revit assembly. When published, these are converted in Stratus to a _Stratus Assembly._
    
-   _Stratus Assembly_ – An assembly created in Stratus by either an Action from a viewer or through a publish of a _Revit Assembly_ (historically).
    
-   _Revit Parameter Assembly_ – An assembly in data only, where a group of parts have a common unique value applied to a specified parameter.
    
-   _Custom Assembly_ – An assembly created by the Stratus publish where a _Revit Parameter Assembly_ is converted to a _Custom Assembly._ The _Custom Assembly_ is just the classification of the assembly once in Stratus and there is no change in Revit to the Revit Parameter Assembly.
    
-   _Family Assembly_ - An assembly created by a host family containing shared-nested parts. This creation is controlled in the part templates for individual families and converts in Stratus on the publish of a model after the settings have been applied in the part templates.
    

**Import**

-   **When toggled off**:
    
    -   Stratus Assemblies that are created on the Stratus site will be imported into Revit as a Revit Assembly.
        
-   **When toggled on a Property to Map to Assemblies parameter must be mapped:**
    
    -   _Stratus Assemblies_ that are created on the Stratus site will be imported into Revit as a _Revit Parameter Assembly_. This means the mapped parameter of the parts of the _Stratus Assembly_ will be populated with the _Stratus Assembly_
        

**Publish**

-   **Functionality on publish will be the same whether toggled on or off**:
    
    -   Assemblies in Revit that are of type _Revit Parameter Assembly_ will be published to Stratus as _Custom_
        
    -   Assemblies in Revit that are of type _Revit Assembly_ will be published to Stratus as _Stratus Assemblies._
        
    -   There is a caveat for cases where a publish finds the same part in both a _Revit Assembly_ as well as a _Revit Parameter Assembly_. In these cases, the _Revit Assembly_ will take precedence and is the assembly that will get published to Stratus.
        

**In Revit Create Assembly Command**

-   There is an effect from this setting which comes up when using the Stratus Create Assembly feature in the Revit addin. When the **Use Parameter Mapping for Assembly Import and Publish** setting is checked, the Create Assembly feature in Revit will use the naming convention defined in Stratus to populate the mapped parameter with the assembly name instead of creating a Revit assembly.
    

**Error Message** 

If the **Use Parameter Mapping for Assembly Import and Publish** option is checked and the parameter has not been configured in Revit or is named incorrectly, users will receive the following error and the import process will cancel.  

![](blob:https://gtpservices.atlassian.net/4bed55ac-425d-4ab4-a245-90bf1b6709ca)

### Property to Map to Assemblies

Property to Map to Assemblies property enables you to add the Stratus Assembly Name to Revit parts in your Revit model. You’ll need to enter the parameter name in settings and then configure a project parameter in Revit with the same name. You can also create a [**Shared Parameter**](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/10518994/Settings+Admin#How-to-Configure-Revit-Shared-Parameter-Property "https://gtpservices.atlassian.net/wiki/spaces/SK/pages/10518994/Settings+Admin#How-to-Configure-Revit-Shared-Parameter-Property").

### Always Publish Revit Assemblies Checkbox

Customers who rely on parameter-based assemblies, but also expect Revit assemblies to be published will need to set the **Always Publish Revit Assemblies** checkbox under Admin > Company > Settings. When checked both assembly types will be in Stratus after the import/publish cycle.

### Property To Associate Sheets With Assemblies

**Property To Associate Sheets With Assemblies** - Since sheets can have their own parameters in Revit, the **Property To Associate Sheets With Assemblies** will allow users to assign a parameter name they want to use to map a related assembly to a sheet.

**Note**: Properties set under Admin > Company > Settings must also be configured in Revit under Manage > Project Parameters.

### Assembly Conflict Resolution

Assembly Conflict Resolution settings are set at the Company level and can be overridden at the Project level.

Under Admin > Company > Settings, the **Assembly Conflict Resolution** setting enables you to determine how Stratus should handle assembly import conflicts. This setting can be set at a company level and overridden at a project level. The options include:

-   -   **Stratus is always right** - When **Stratus is always right** is selected, any assemblies created in Revit that conflict with an assembly in Stratus will be considered “invalid” and will not be published to Stratus.
        
    -   **Revit is always right** - When **Revit is always right** is selected, any assemblies created in Stratus that conflict with an assembly in Revit will be considered “invalid” and will be deleted on import. Previously, after a model import, an assembly created in Stratus that conflicted with an assembly created in Revit would not be deleted until after the next model publish which caused confusion.
        
    -   **Prompt User** - When **Prompt User** is selected, the behavior will follow the selected rule above at the time of the prompt.
        

The Stratus Synchronize Data flow diagrams describe how data is synchronized when Revit/AutoCAD is always right and when Stratus is always right.

See the Stratus Community discussion [**Assembly Conflict Resolution (Revit), which do you choose and why?**](https://community.stratus.build/t/assembly-conflict-resolution-revit-which-do-you-choose-and-why/1291 "https://community.stratus.build/t/assembly-conflict-resolution-revit-which-do-you-choose-and-why/1291")

### Point Export Units

Point Export Units can be set for (Feet, Inches, Meters, Millimeters).  Point Export Units can be set here at the Company level and overridden on a per-project basis under Admin > Project Settings. See the [**Project Settings (Admin)**](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/217907482/Project+Settings+Admin "https://gtpservices.atlassian.net/wiki/spaces/SK/pages/217907482/Project+Settings+Admin") article for more information about the settings. See the [**Package Point List**](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/166821968 "https://gtpservices.atlassian.net/wiki/spaces/SK/pages/166821968") article for more information about Point List generated for a Package.

##   
Tasks (workflows, definitions)

If your company uses tasks, set whether you want to use Task Definitions (New) or Task Workflows (Old) or both (not recommended). If neither is checked, no tasks will display.

## Task Definitions

See the [**Task Definitions**](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/217711302 "https://gtpservices.atlassian.net/wiki/spaces/SK/pages/217711302") article for more information.

## Task Workflows

See the [**Task Workflows**](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/240713729 "https://gtpservices.atlassian.net/wiki/spaces/SK/pages/240713729") article for more information.

## BOM (default line item mapping)

The BOM (default line item mapping) enables an Admin to set a default BOM Mappings for ALL Part Templates that exactly match the default line item mapping. After a change is made, it will be applied to new BOMs, not existing BOM's. 

One scenario for using the **BOM (default line item mapping)** setting is to include a consistent description based on fields for all Part Template > BOM Mapping.

Here’s how the **BOM (default line item mapping)** setting works:

1.  All companies have a **BOM (default line item mapping)** setting. Note that all properties are set to Default, None, or 1. Default indicates that the property does not have an override.  
    
    ![](blob:https://gtpservices.atlassian.net/c47d5266-30b0-4780-84e5-ce78395e5644)
    
2.  Review some of your Part Template > BOM Mappings and determine if the mappings are exactly the same as the default line item mapping in the screenshot above.
    
    1.  The Part Templates > BOM Mapping below exactly matches the **BOM (default line item mapping)** setting above. As a result, if the **BOM (default line item mapping)** setting above is changed, the BOM Mapping below will also change.  
        
        ![](blob:https://gtpservices.atlassian.net/f71e783d-53a2-410c-bc57-dd5aa7129156)
        
    2.  The BOM Mapping below does not match the **BOM (default line item mapping)** setting above. As a result, if the **BOM (default line item mapping)** setting above is changed, the BOM Mapping below will not change.  
        
        ![](blob:https://gtpservices.atlassian.net/2e59932e-4b53-4415-b00b-eebd939da487)
        
    3.  The **BOM (default line item mapping)** setting only applies to the first mapping row of the Part Template > BOM Mapping. In the example below, even though row 2 exactly matches the **BOM (default line item mapping)** settings in this example, row 1 does not match. As a result, the **BOM (default line item mapping)** setting would not apply to this Part Template > BOM Mapping. If row 1 and row 2 were switched, then the **BOM (default line item mapping)** setting would apply to this Part Template > BOM Mapping.  
        
        ![](blob:https://gtpservices.atlassian.net/5d09629f-4fb1-437d-83c8-c4b174631852)
        
3.  If you want a Part Template > BOM Mapping to be synced with the **BOM (default line item mapping)** setting, you would need to change the Part Template > BOM Mapping to match the **BOM (default line item mapping)** setting. Then, moving forward, any changes made to the **BOM (default line item mapping)** setting would apply to the Part Template > BOM Mapping.
    
4.  In this example, a Manual Override for the **BOM (default line item mapping)** Description setting will be set Test 45.
    
    1.  As soon as the save check is clicked, the change will be applied to all qualifying Part Template > BOM Mappings in your company. There is no prompt to confirm this change.  
        
        ![](blob:https://gtpservices.atlassian.net/d1726da3-c777-4171-8931-63e10013d023)
        
    2.  The process may take up to a minute.  
        
        ![](blob:https://gtpservices.atlassian.net/edb54789-1015-4022-b086-0c912c52d12a)
        
    3.  Once done, the **BOM (default line item mapping)** setting will be changed to the following:  
        
        ![](blob:https://gtpservices.atlassian.net/3ac85ec4-d9fa-43fa-b3e6-50e1c196c1e9)
        
    4.  Refresh the Part Templates page and check the Part Template > BOM Mapping that exactly matched the **BOM (default line item mapping)** before the change to Test 45 was made now displays Test 45 in the Description.  
        
        ![](blob:https://gtpservices.atlassian.net/0ec52f5a-eb74-4e66-91ad-81e33c0129fb)
        
    5.  Refresh the Part Templates page and check the Part Template > BOM Mapping that did not match the **BOM (default line item mapping)** before the change to Test 45 was made does not display Test 45 in the Description. The Material property is still set and the Description property is still Default.  
        
        ![](blob:https://gtpservices.atlassian.net/aa836663-bef0-4915-b844-64023f021531)
        
    6.  Based on this example, if you wanted to make another change to the **BOM (default line item mapping)** setting, any BOM Mapping that exactly matched the following would also be changed.  
        
        ![](blob:https://gtpservices.atlassian.net/76c5c21e-620e-4c79-8ae4-3a419035c1b8)
        

## Schedule

The Schedule configuration table enables companies to define a package’s actual progress and hours. How the calculation is made is determined by the Method (Tracking Status or Report Field (Ex. A field that calculates MCA hours ). Once configured, the package data is calculated on the Package’s > Properties > Actual section.

### Configure Package Actuals Data Source

1.  To configure actual progress and hours, go to Admin > Company > Settings > Schedule.
    
2.  **Phase** \- For each Package Phase (Office, Purchasing, Shop, Field), the Progress and Hours can be configured.
    
    1.  **Progress** \- All 4 package phases (Office, Purchasing, Shop, Field) are listed.
        
    2.  **Hours** - Select one label:
        
        1.  **Spent Hours** - Defined by your company.
            
        2.  **Earned Hours** - Defined by your company.
            
        3.  **Remaining Hours** - Defined by your company.
            
        4.  **Custom** \- Enter your own label.
            
3.  **Method** \- The method of how the row will be calculated.
    
    1.  **Tracking Status** - When the method is set to Tracking Status, the actual data will use the Phase percent configured for the package’s tracking status under Admin > Company > Tracking Statuses (See Example - Progress set to Tracking Status below).
        
    2.  **Report Field** - When the method is set to Report Field, a report field will be selected in the row’s Source column.
        
    3.  **None** - When the method is set to None, the corresponding cell under Package’s > Properties > Actual will be grayed out.
        
4.  **Source** \- When Report Field is the method, a source (the report field) is selected.
    
5.  **Advanced Reporting**
    
    1.  **Checked** \- When checked, the hours row will display for all phases here in schedules and on the Package’s > Properties > Actual section.
        
    2.  **Unchecked** \- When unchecked, the hours row will **not** display for any phase here in schedules or on the Package’s > Properties > Actual section.
        

### Example - Progress set to Tracking Status

In this example, the following Phase percent complete values will be used.

1.  The Progress Method for all Phases has been set to Tracking Status. As a result, the actual Progress ( % ) will use the Phase percent configured for the package’s tracking status under Admin > Company > Tracking Statuses (see above).
    
2.  In the **Package’s > Properties > Actual** section:
    
    1.  A package has been created and the initial Can Package tracking status is **Issued** which is 20% complete for the Office phase. No other phase has started so 0% displays.
        
    2.  Once the package’s tracking status changes to **Packaged**, the Office Progress ( % ) changes to 60%. No other phase has started so 0% displays.
        
    3.  When the package’s tracking status changes to **Fabrication in Progress**, Office is updated to 100%, Purchasing to 100%, and Shop to 20%.
        

### Example - Hours Report Field

In this example, Shop and Field Earned Hours will be calculated using a Report Field.

1.  Select a field that provides the hours for any given phase.
    
2.  In the Package’s > Properties > Actual section the values, if any, will display. A dash displays if a Report Field has been configured but the calculation resulted in no value.
    

## Additional Information

## Activities Logging for Publish Setting Changes

Publish Setting changes will be logged for the following saved activities:

**Admin > Company > Settings > AutoCAD & Revit**

-   Assembly conflict resolution (Specific to AutoCAD)
    
-   Assembly conflict resolution (Specific to Revit)
    
-   Use Parameter Mapping for Assembly Import and Publish
    
-   Property to Map to Assemblies
    

**Admin > Project > Settings**

-   Assembly conflict resolution (Specific to AutoCAD)
    
-   Assembly conflict resolution (Specific to Revit)
    
-   Use Parameter Mapping for Assembly Import and Publish
    
-   Property to Map to Assemblies
    

## How to Configure Custom Data Field in the Fabrication Database 

Custom Data Fields can be associated with Property to Map fields in Stratus Settings. The field names must be exactly the same. To configure a custom data field in the Fabrication database:

1.  Click the **Edit Main Database** button.
    
2.  In the dialog, click the **Takeoff** tab.
    
3.  Click the **Custom Data** option.
    
4.  And then click the **add Custom Item Data**
    
5.  Enter the name of the custom property (Ex. Stratus Package). 
    
6.  The other columns can remain at their default values.
    
7.  Click **OK** when done adding custom data fields.
    

**Configure Revit Shared Parameter Property Example**

Below is a Revit electrical model example where you can associate Revit assemblies and sheet views in Stratus. You’ll map the **Property To Associate Sheets With Assemblies** and the **Property To Map to Assemblies (formerly Property To Recognize For Assemblies)** Stratus settings to project parameters in Revit and in Stratus.

1.  To create a project parameter in Revit, go to Manage > Project Parameters.
    
    1.  Add the new project parameter Ex. Conduit Prefab ID, set the type to Text, select the **Values can vary by group instance**, and apply it to Conduit Categories.
        
    2.  Add another project parameter Ex. Stratus Sheet, set the type to Text, select the **Values can vary by group instance**, and apply it to the Sheet and Views Categories.
        
2.  In Stratus, under Admin > Company > Settings, enter the project parameter names:
    
    1.  **Property To Map to Assemblies (formerly Property To Recognize For Assemblies)** Stratus = Conduit Prefab ID
        
    2.  **Property To Associate Sheets With Assemblies** = Stratus Sheet
        
    3.  **Auto-Generate Assembly Views and Sheets** – Unchecked as you probably don’t want to auto-generate assembly views and sheets. This still generates the Revit assembly if an assembly is first created in Stratus, just not the assembly views and sheets to go along.
        
3.  In Revit, set each assembly name in the Conduit Prefab ID project parameter and create your sheets.
    
4.  In Revit, under Collaborate > Publish Settings, select the Sheets that need to be published as well as any other 3D Views.
    
5.  Publish the model.
    
6.  The following will be published to Stratus:
    
    1.  In the Models > Viewer, selected assembly displays a link to the assembly.
        
    2.  In the Assemblies > Dashboard, all the assemblies defined using the “Conduit Prefab ID project parameter” display.
        
    3.  The Revit assembly sheet will display.
        
7.  If you create new assemblies in Stratus and then Import the model, you’ll find that:
    
    1.  Currently, the Revit assemblies are created.
        
    2.  In the future, there will be an option to populate the “Conduit Prefab ID project parameter” with the Stratus assembly number.
---
created: 2025-06-25T06:30:43 (UTC -04:00)
tags: []
source: https://gtpservices.atlassian.net/wiki/spaces/SK/pages/215220408/Station+Admin
author: 
---

# Station (Admin) - STRATUS Knowledge Base - Confluence

> ## Excerpt
> A Station can be associated with a person or a tool in your shop (pipe cutting station, a weld station, a plasma table, final assembly, or shipping).

---
A **Station** can be associated with a person or a tool in your shop (pipe cutting station, a weld station, a plasma table, final assembly, or shipping).

A Station can be used in 3 different ways:

1.  **Assign to a Device** - A Station can be assigned to a device and used to filter tasks.
    
2.  **Sign In to a Station** - A user can Sign in to a Station so that tracking metrics can be collected.
    
3.  **Assign to a Device** and **Sign In to a Station** - In this case, a station is both assigned to a device so that tasks can be filtered and a user must Sign in to a station so that metrics are collected.
    

-   1 [Station Configuration](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/215220408/Station+Admin#Station-Configuration)
-   2 [Sign In to Stations](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/215220408/Station+Admin#Sign-In-to-Stations)
    -   2.1 [Sign In to a Jobsite Station](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/215220408/Station+Admin#Sign-In-to-a-Jobsite-Station)
    -   2.2 [Sign In to a Shop Station](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/215220408/Station+Admin#Sign-In-to-a-Shop-Station)
-   3 [Examples](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/215220408/Station+Admin#Examples)
    -   3.1 [Station As Part of the Task Workflow](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/215220408/Station+Admin#Station-As-Part-of-the-Task-Workflow)
    -   3.2 [Station As Part of the Cut List Workflow](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/215220408/Station+Admin#Station-As-Part-of-the-Cut-List-Workflow%5BhardBreak%5D)
-   4 [Videos](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/215220408/Station+Admin#Videos)
    -   4.1 [08/19/2024 - Stratus Academy: ADM-513: Admin 3 - Stations](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/215220408/Station+Admin#08%2F19%2F2024---Stratus-Academy%3A-ADM-513%3A-Admin-3---Stations)
    -   4.2 [11/25/2020 - Hanger And Support Spooling/Fabrication Workflows](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/215220408/Station+Admin#11%2F25%2F2020---Hanger-And-Support-Spooling%2FFabrication-Workflows)
    -   4.3 [11/19/2020 - Electrical Spooling/Fabrication Workflows](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/215220408/Station+Admin#11%2F19%2F2020---Electrical-Spooling%2FFabrication-Workflows)
    -   4.4 [10/08/2020 - Cast Iron NH Spooling/Fabrication Workflows](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/215220408/Station+Admin#10%2F08%2F2020---Cast-Iron-NH-Spooling%2FFabrication-Workflows)
    -   4.5 [08/13/2020 - Using your TigerStop with Stratus!](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/215220408/Station+Admin#08%2F13%2F2020---Using-your-TigerStop-with-Stratus!)

## Station Configuration

1.  Configure a Station under Admin > Company > Stations.
    
    1.  **Image** - When a station is "Assigned to this device" (see below), the station image, if added, will display at the top of the page next to the user's badge. Otherwise, the default image will display. Hover over the image to display the station name. 
        
    2.  **Upload** - Browse to upload the image file from your computer. The image will be used instead of the default image if it is uploaded.
        
    3.  **Name (Required)** - The name of the Station. Tip: Use a standardized naming convention that uses a prefix so that the Stations sort in a logical way. Station names are selected on the Package's Cut Lists tab and the Package's Point Lists tab.
        
    4.  **Description (Required)** - The description can be the same or similar to the Name and is only visible on the Stations page. 
        
    5.  **Taks Definitions** - At each Station, (Ex. Weld Booth Station) a sequence of tasks happen. These are Task Definitions and are configured on the Task Definitions page. Often times, when working on an assembly, station's tasks interact. A Task Definition can be applied to a Part, Assembly, or both. The Task Definitions selected for a Station are the process tasks required for each station when a Task Workflow is applied. See the [**Task Definitions**](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/217711302 "https://gtpservices.atlassian.net/wiki/spaces/SK/pages/217711302") article for more information.
        
        1.  Select tasks the station will perform for a Task Workflow. 
            
        2.  Click the **Add a Task Definition** button 
            
            to select a Task Definition. See the [**Task Definitions (Admin)**](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/217711302 "https://gtpservices.atlassian.net/wiki/spaces/SK/pages/217711302") article for more information.
            
        3.  Click the **Save** button 
            
            to Save selections.
            
        4.  Click the **Remove this Task Definition** button 
            
            to delete the Task Definition from the Station.
            
        5.  Click the Cancel button 
            
            to cancel any new selections.
            
    6.  **Division (Required)** - Select the Division associated with the Station. See the [**Division (Admin)**](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/103317524/Processor+Admin "https://gtpservices.atlassian.net/wiki/spaces/SK/pages/103317524/Processor+Admin") article for more information.
        
    7.  **Tool** - Select the Tool. See the [**Tools (Admin)**](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/215220225 "https://gtpservices.atlassian.net/wiki/spaces/SK/pages/215220225") article for more information.  A Tool cannot be assigned to multiple stations.
        
    8.  **Managed Materials** - After the Station has been configured, a Managed Material can be added. A Managed Material is used when a cut list is generated. In this case, the Station will automatically be selected based on the Material and Trade Size. See the [**Materials (Admin)**](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/215351308 "https://gtpservices.atlassian.net/wiki/spaces/SK/pages/215351308") article for more information. The material selected after using the Edit Material button will display.
        
    9.  **Edit Materials** - Click the **Edit Materials** button and select the material.  
        
        ![](blob:https://gtpservices.atlassian.net/ca9c118d-e14f-4d7d-902b-2e1354af3a87)
        
    10.  **Assign to this device**
        
        1.  Assign to this device is used to filter tasks assigned to a station in a Task Definition or a Task Workflow.
            
        2.  When you (the Admin) are on the device (computer, ipad, tablet) and check the **Assign to this device** checkbox, a cookie is placed on the device that will enable it to receive filtered tasks for the station. For example, for the Task Workflow or Task Definition, the "Clean and Sort" station might be a mechanical piping Division and should only be able to do clean and sort tasks. This station should not be able to see a cutting task. Similarly, you don’t want a "Cutting" station to see a task to clean and sort. 
            
        3.  Once the **Assign to this device** checkbox is checked, the device image will display next to the Stratus badge. Anyone who uses Stratus on the device will have access to the selected station's tasks.  
            
            ![](blob:https://gtpservices.atlassian.net/ededed03-8a06-45e0-acdd-5be5e3651f8e)
            
        4.  When unchecked, the device will not have access to the station's tasks.
            
        5.  While an admin can assign multiple devices to multiple stations, it recommended to only assign one station per device. Assigning multiple devices to multiple stations is most often used during testing.
            
    11.  **Delete** - Delete the station.
        

## Sign In to Stations

To log tracking status changes made by a station for tracking metrics, a user must **Sign in** to the station. After the user has signed in, any tracking status changes the user makes will be logged and can be used in tracking reports. See the [**TrackingStatusChange() Function**](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/166035577/Fields+Admin?src=search#Fields(Admin)-TrackingStatusChange()Function "https://gtpservices.atlassian.net/wiki/spaces/SK/pages/166035577/Fields+Admin?src=search#Fields(Admin)-TrackingStatusChange()Function") section of the Fields article for more information. 

## Sign In to a Jobsite Station

**To Sign in to a Jobsites station:**

1.  Click Jobsites and then click the **Sign in** button associated with the Station.
    
    ![](blob:https://gtpservices.atlassian.net/0bd62b73-2b51-47bb-ac63-025ebb17a661)
    
2.  Once signed in, the user's badge will change to the station icon and the **Sign out** button will display.
    
    ![](blob:https://gtpservices.atlassian.net/18be1f1d-0356-4a29-80be-2ddf5d6f45bd)
    
3.  To Sign in to a different station, click the **Sign in** button associated with the station. The user will be:
    
    1.  Automatically signed out of any station that they are currently Signed in to
        
    2.  Signed in to the selected station
        
    3.  The user’s badge will change to the new station’s icon.
        
        ![](blob:https://gtpservices.atlassian.net/2b36a5d8-2eb2-45d1-bb17-93b3946dd8d3)
        
    4.  In addition, clicking the badge will display the company and station that the user is signed into.  
        
        ![](blob:https://gtpservices.atlassian.net/8910f57e-98ab-4caf-ae83-e979edc24414)
        

## Sign In to a Shop Station

**To Sign in to a Shops station:**

1.  Click the Shops tab and then click the **Sign in** button associated with the Shop.  
    
    ![](blob:https://gtpservices.atlassian.net/83881bab-a734-46bf-9d3f-434adfb832e3)
    
2.  Once signed in, the user's badge will change to the shop icon and the Sign out button will display.  
    
    ![](blob:https://gtpservices.atlassian.net/b8608d8b-1491-4f92-bf0e-367e0a37f31e)
    
3.  To Sign in to a different station, click the **Sign in** button associated with the Shop station. The user will be:
    
    1.  Automatically signed out of any station that they are currently Signed in to
        
    2.  Signed in to the selected station
        
    3.  The user’s badge will change to the new station’s icon.  
        
        ![](blob:https://gtpservices.atlassian.net/bfb8378b-7a56-49f3-80ed-1ecad9da0fb8)
        
4.  In addition, clicking the badge will display the company and station that the user is signed into.  
    
    ![](blob:https://gtpservices.atlassian.net/78ddaa17-ab99-4dd1-aeb5-bdc2da6f875b)
    

## Examples

## Station As Part of the Task Workflow

**\* See the** [**Task Workflows Admin**](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/240713729 "https://gtpservices.atlassian.net/wiki/spaces/SK/pages/240713729") **article for more information on how to configure a Station to be used with a Task Workflow.**

## Station As Part of the Cut List Workflow

To automatically assign a cut list to a station based on material:

1.  **Define a material** under Admin > Company > Materials. If the same material (Ex. Carbon Steel -IPS) will be sent to 2 different stations depending on the trade size, define the material twice and then set a trade size range for each. Be sure the material name is a valid material name. See the [**Materials (Admin)**](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/215351308 "https://gtpservices.atlassian.net/wiki/spaces/SK/pages/215351308") article for more information.
    
2.  **Define a station** under Admin > Company > Stations. If the material will be sent to different stations depending on the trade size, define each station. Once the station is defined, click the **Edit Materials** button to select the material that is sent to the station.
    
3.  To **generate the cut list**, click the **Cut Lists** tab on an open package and then click the **Generate Cut Lists** button. If the package had materials and trade sizes defined above, the Station would be correctly selected.
    

## Videos

## 08/19/2024 - Stratus Academy: ADM-513: Admin 3 - Stations

To take the **Stations** course, login to [**Stratus Academy**](https://academy.stratus.build/ "https://academy.stratus.build/") and and locate the course **ADM-513: Admin 3 - Stations.**

## 11/25/2020 - Hanger And Support Spooling/Fabrication Workflows

<iframe allowfullscreen="" allowtransparency="true" data-hasbody="false" data-layout="default" data-local-id="22154c75-5e7f-4692-87b6-704d59a69e41" data-macro-id="00b23430-8453-4df3-aed3-dd12906c67bd" data-macro-name="widget" frameborder="0" height="364" mozallowfullscreen="" webkitallowfullscreen="" width="640" src="https://player.vimeo.com/video/486491284?h=embed"></iframe>

01:00 Prefabrication Filters and Package  
03:15 Packages Dashboard  
04:00 Renumber Hangers with Filters  
06:00 Part Template Item Number  
12:15 2 Ways to Communicate with the Field 1. Print Drawing 2. Stickers  
12:35 Print Drawing - Package Details Report with QR Codes  
15:45 Package Cut List Grouped by Rod Size Using Field to Determine Cut Length  
21:00 Station Managed Materials  
24:30 Stratus Cutting Workstation (TigerStop) and Sticker  
27:30 Centerline and Bottom Elevation Sticker Data  
30:00 Single Rod Hanger Standard Length Sticker

## 11/19/2020 - Electrical Spooling/Fabrication Workflows

<iframe allowfullscreen="" allowtransparency="true" data-hasbody="false" data-layout="default" data-local-id="72239920-2ec4-44f5-bd04-bfd3402f4dd2" data-macro-id="b6e8c907-3cc5-4a18-b3c9-0e504592bdfc" data-macro-name="widget" frameborder="0" height="364" mozallowfullscreen="" webkitallowfullscreen="" width="640" src="https://player.vimeo.com/video/483127325?h=embed"></iframe>

00:00 Introduction  
05:00 Setting: Use Parameters Mapping for Assembly Import and Publish  
07:30 Groupings and Filters  
13:30 Underground Package  
14:40 Task Definitions  
19:50 Generate Tasks Based on Tracking Status  
22:30 Shops and Tasks Tabs  
30:00 Stations - Assign to Station  
31:00 Package Tasks and Assembly Tasks  
38:00 Settings: Publish Greenlee BendWorks Assemblies  
43:00 Settings: Generate Tasks

## 10/08/2020 - Cast Iron NH Spooling/Fabrication Workflows

<iframe allowfullscreen="" allowtransparency="true" data-hasbody="false" data-layout="default" data-local-id="82a0ebf0-3c6d-4fc7-b62a-d8992eb560ae" data-macro-id="9699508f-663c-4250-8d0a-47aadc71af21" data-macro-name="widget" frameborder="0" height="364" mozallowfullscreen="" webkitallowfullscreen="" width="640" src="https://player.vimeo.com/video/466585278?h=embed"></iframe>

00:25 Methodology: Kit or Spool  
01:14 Method 1: Kit and Send  
04:16 Naming and Numbering  
05:50 Stratus Sheet  
09:29 Method 2: Spool and Assemble  
13:44 Naming, Numbering, and Annotation  
14:20 BOM  
18:33 Cut List  
19:15 Material Alias  
21:51 Automatically apply Material Alias to Cut List at Station  
29:27 Send Cut List to Station - GTP Stratus Workstation (TigerStop App)  
30:40 Label and Connected To Data Shop vs. Field

## **08/13/2020 - Using your TigerStop with Stratus!**

<iframe allowfullscreen="" allowtransparency="true" data-hasbody="false" data-layout="default" data-local-id="d84d10bf-c54a-4bdd-b117-524ca0007b24" data-macro-id="d7443740-2c42-4658-85fb-6741d0ad6f1f" data-macro-name="widget" frameborder="0" height="364" mozallowfullscreen="" webkitallowfullscreen="" width="640" src="https://player.vimeo.com/video/447847147?h=embed"></iframe>

00:00 Cut List Introduction  
01:22 Can Cut Tracking Status  
02:28 Generate Cut List for a Package - Package's Cut List tab  
03:35 Generate Cut List for a Part - Assembly Viewer  
04:29 Pipe - Part Templates > Cut List Mappings  
08:27 Hanger Rod - Part Templates > Cut List Mappings  
12:47 Tool and Station Setup  
13:54 Send Package Cut List to Station  
14:19 TigerStop Station and General Workstation Settings  
25:52 TigerStop Station and Filtering Projects, Models, Packages, Assemblies, Grouping  
24:52 TigerStop Station and TigerStop Workstation Settings  
27:46 Use the TigerStop Workstation for non-TigerStop workflows  
28:54 TigerStop Workstation Dynamic Nesting  
30:09 Labels for Different Tools
---
created: 2025-06-25T06:27:04 (UTC -04:00)
tags: []
source: https://gtpservices.atlassian.net/wiki/spaces/SK/overview?homepageId=33347
author: 
---

# Stratus Knowledge Base - STRATUS Knowledge Base - Confluence

> ## Excerpt
> Atlassian uses cookies to improve your browsing experience, perform analytics and research, and conduct advertising. Accept all cookies to indicate that you agree to our use of cookies on your device. Atlassian cookies and tracking notice, (opens new window)

---
Atlassian uses cookies to improve your browsing experience, perform analytics and research, and conduct advertising. Accept all cookies to indicate that you agree to our use of cookies on your device. [Atlassian cookies and tracking notice, (opens new window)](https://www.atlassian.com/legal/cookies)
---
created: 2025-06-25T06:30:43 (UTC -04:00)
tags: []
source: https://gtpservices.atlassian.net/wiki/spaces/SK/pages/742916097/Suppliers+Admin
author: 
---

# Suppliers (Admin) - STRATUS Knowledge Base - Confluence

> ## Excerpt
> Atlassian uses cookies to improve your browsing experience, perform analytics and research, and conduct advertising. Accept all cookies to indicate that you agree to our use of cookies on your device. Atlassian cookies and tracking notice, (opens new window)

---
Atlassian uses cookies to improve your browsing experience, perform analytics and research, and conduct advertising. Accept all cookies to indicate that you agree to our use of cookies on your device. [Atlassian cookies and tracking notice, (opens new window)](https://www.atlassian.com/legal/cookies)
---
created: 2025-06-25T06:30:43 (UTC -04:00)
tags: []
source: https://gtpservices.atlassian.net/wiki/spaces/SK/pages/166952961/Task+Categories+Admin
author: 
---

# Task Categories (Admin) - STRATUS Knowledge Base - Confluence

> ## Excerpt
> Task Categories are used to categorize Task Definitions like Bending, Cutting, Detailing, Installing, etc.

---
Task Categories are used to categorize Task Definitions like Bending, Cutting, Detailing, Installing, etc.

-   1[Configure Task Categories](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/166952961/Task+Categories+Admin#TaskCategories(Admin)-ConfigureTaskCategories)

## Configure Task Categories

![](https://gtpservices.atlassian.net/wiki/download/thumbnails/166952961/image2019-1-29_11-22-52.png?version=1&modificationDate=1548782573866&cacheVersion=1&api=v2&width=770&height=250)
---
created: 2025-06-25T06:30:43 (UTC -04:00)
tags: []
source: https://gtpservices.atlassian.net/wiki/spaces/SK/pages/217711302/Task+Definitions+Admin
author: 
---

# Task Definitions (Admin) - STRATUS Knowledge Base - Confluence

> ## Excerpt
> A Task Definition is the recommended method to generate work package task items.

---
A Task Definition is the recommended method to generate work package task items. 

-   1 [Stratus Academy Course Video](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/217711302/Task+Definitions+Admin#Stratus-Academy-Course-Video)
-   2 [Transition from Task Workflows to Task Definitions](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/217711302/Task+Definitions+Admin#Transition-from-Task-Workflows-to-Task-Definitions)
-   3 [Configure Task Definitions](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/217711302/Task+Definitions+Admin#Configure-Task-Definitions)
    -   3.1 [Example: Label Printing Triggered by Tasks](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/217711302/Task+Definitions+Admin#Example%3A-Label-Printing-Triggered-by-Tasks)
    -   3.2 [What Task and Label Automation Means For You](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/217711302/Task+Definitions+Admin#What-Task-and-Label-Automation-Means-For-You)

## Stratus Academy Course Video

To take the Task Definitions course, login to [**Stratus Academy**](https://academy.stratus.build/ "https://academy.stratus.build/") and locate the course **ADM-518: Task Definitions**.

## Transition from Task Workflows to Task Definitions

**Note:** If your company has not used Task Workflows, skip to the Configure Task Definitions section.

By default, Task Workflows are used to generate work package task items. Customers are encouraged to transition their Task workflows, which still work, to the Task Definitions workflow. 

To disable a Task Workflow:

1.  Change the Initiated by Tracking Status setting associated with the Task Workflow to Manually Initiated.  
    
2.  Task Definitions and Task Workflows are disabled by default under Admin > Company > Settings. Check either (preferable) or both to generate tasks. 
    
3.  Alternatively, Task Definitions and Task Workflows can be managed at the project level.
    

## Configure Task Definitions

Task Definitions are extensions of Tracking Statuses.

-   Whereas Tracking Statuses capture major milestones within your workflow and can be visually overplayed in the Models Viewer, Task Definitions enable you to automate your tracking status changes at granular checkpoints.
    
-   Task Definitions let you track Shop Productivity and time stamping by person, station, or activity.
    
-   A Task Definition combines a filter, a category, and item type to apply to a tracking status when tasks are started and completed.
    
-   A Task Definition can apply status changes to the Assembly or Package.
    
-   A Task Definition can be triggered manually or automatically by a tracking status change.
    

A Task Definition includes the following:

-   **Sequence** – Implies dependencies between tasks and is used for precedence ordering of tasks. Use this option instead of the **Is Join** setting for most Task Definitions.
    
-   **Name (Required)** - The name of the Task Definition. **Tip**: Use a standardized naming convention that uses a prefix so that the Task Definitions sort in a logical way. The Name is used to select tasks on the Task Workflows page in the Task Sequence column.
    
-   **Description (Required)** - The description can be the same or similar to the Name and is only visible on the Task Definitions page. 
    
-   **Image** - A task image, if added, will display wherever the task displays. If an image is not added to the task, then the Name will be used. 
    
-   **Upload** - Browse to upload the image file from your computer.
    
-   **Assign to (Required)** – Is the task created for a Part or Assembly?
    
    -   **Assembly Task** - When triggered, an assembly task will display:
        
        -   **In the Packages > Viewer > Tasks**
            
        -   **In the Assemblies > Viewer**
            
    -   **Parts Task** - When triggered, a part task will display:
        
        -   **In the Packages > Viewer > Tasks**
            
        -   **In the Assemblies > Viewer > Tasks**
            
-   **Apply using Filters (Required)** – Select one or more Filters to determine which Parts or Assemblies should get this task. See the [**Filters (Admin)**](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/166035577 "https://gtpservices.atlassian.net/wiki/spaces/SK/pages/166035577") article for more information. 
    
-   **Task per Filter** – Option to generate separate tasks for each Part Filter that passes. When checked, a separate task for each filter that passes will be created. When unchecked, a single task will be created when any of the part filters pass.
    
    -   **Example** – If you have a cut task and have a filter for copper straight pipe and a filter for steel pipe, you can create one task if either filter passes, or a task for each filter that passes
        
-   **Is Join** – Is the task joining multiple parts together, like a weld. It Implies dependencies on tasks from connected parts. **Note**: The **Sequence** setting might be a better option to order tasks.
    
-   **Apply to Package Categories** – When a Package Category is selected, a task will only be created for packages in the selected package category. See the [**Package Category (Admin)**](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/166199351 "https://gtpservices.atlassian.net/wiki/spaces/SK/pages/166199351") article for more information.
    
-   **Initiated by Package Tracking Status** – When a Package’s Tracking Status is updated to the selected tracking status, then tasks are created. By default, tasks are Manually Initiated.
    
-   **Auto Complete** (Required) – When checked (default), predecessor tasks based on the **Sequence** value will be automatically completed with tasks with a higher sequence number for the same part are completed. When unchecked, tasks will not be automatically completed and will require manual processing.
    
-   **Task Category (Required)** - Configure Task Categories before Task Definitions. See the [**Task Categories**](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/166952961 "https://gtpservices.atlassian.net/wiki/spaces/SK/pages/166952961") article for more information. Below are some examples:
    
-   **Cost Category (Required)** - Configure Cost Categories before Task Definitions. See the [**Cost Categories**](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/10518700 "https://gtpservices.atlassian.net/wiki/spaces/SK/pages/10518700") article for more information.  Below are some examples:
    
-   **Cost Type** - See the [**Cost Types**](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/10486154 "https://gtpservices.atlassian.net/wiki/spaces/SK/pages/10486154") article for more information. Below are some examples:
    
-   **Apply Tracking Status upon Completion** - The tracking status that will be automatically applied when **Apply Tracking Status to Assembly** and/or **Apply Tracking Status to Package** is checked. See the [**Tracking Statuses**](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/10485761 "https://gtpservices.atlassian.net/wiki/spaces/SK/pages/10485761") article for more information. Below are some examples:
    
-   **Apply Tracking Status to Assembly**
    
    -   When checked, after at least one task in an Assembly has been completed for the associated Task Definition, the tracking status set in the Apply Tracking Status column will be automatically applied to the Assembly.
        
    -   When unchecked, no tracking status will be applied to the assembly.
        
-   **Apply Tracking Status to Package**
    
    -   When checked, after at least one task in a Package has been completed for the associated Task Definition, the tracking status set in the Apply Tracking Status column will be automatically applied to the Package.
        
    -   When unchecked, no tracking status will be applied to the package.
        
-   **Bypass (Update) Tracking Status Dialog**
    
    -   When checked, after each task is completed for the associated Task Definition, the Update Tracking Status dialog will not display.
        
    -   When unchecked, after each task is completed for the associated Task Definition, the Update Tracking Status dialog will display if the Apply Tracking Status value is something other than “No Change”.
        
    -   **Note**: The Update Tracking Status dialog is the only dialog where hours can be entered while work is being done.
        
-   **Unit of  Measure (Optional)** – The Unit of Measure drop-down displays the list of Fields. See the [**Field (Admin)**](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/166035577 "https://gtpservices.atlassian.net/wiki/spaces/SK/pages/166035577") article for more information. For each task, a Field can be selected and used as the Unit of Measure metric for the task (e.g. diameter inches for weld task, or weight for sheet metal task, or length for pipe task). 
    
-   **Velocity (Units per Day per Station) (Optional)** – The Velocity is used for capacity planning and is a numeric value specifying the expected rate of task completion.
    
-   **Report (Optional)** – The Report setting for each task generates helpful data for describing tasks on the task card. See the [**Report (Admin)**](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/10617393 "https://gtpservices.atlassian.net/wiki/spaces/SK/pages/10617393") article for more information.
    
    -   **Example** – Include C1, C2, Diameter, and Service information on the Kanban task card.  
        
        ![](blob:https://gtpservices.atlassian.net/f1012654-7104-49af-8ff0-214c8529dbc2)
        
-   **Color (Required)** – Select a color for the Task Definition.
    
-   **Print Label** - Select the assembly status (Ex. In Progress or Done) that will trigger the assembly task to print an assembly label. See the **Label Report** to select the label report to print. 
    
-   **Label Report** - Select Label Report to be used when the assembly task triggers the assembly label to be printed. See the **Print Label** section to trigger the print.
    
-   **Delete** - Delete the Task Definition. Deleting the Task Definition will delete it from Task Workflows.
    

## Example: Label Printing Triggered by Tasks

Use tasks to trigger part and assembly label printing. This uses the relationships between [Stations](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/215220408 "https://gtpservices.atlassian.net/wiki/spaces/SK/pages/215220408"), [Tools](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/215220225 "https://gtpservices.atlassian.net/wiki/spaces/SK/pages/215220225"), [Task Definitions](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/217711302 "https://gtpservices.atlassian.net/wiki/spaces/SK/pages/217711302"), and [Reports](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/10617393/Reports+Admin#Example:LabelReport "https://gtpservices.atlassian.net/wiki/spaces/SK/pages/10617393/Reports+Admin#Example:LabelReport") to push labels to the [GTP Stratus Print](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/157974545/Label+Printing+for+Zebra+ZPL+Compatible+Printers#Q%3AWhatarethestepstoprinttoaZebra(ZPL)compatibleprinter%3F "https://gtpservices.atlassian.net/wiki/spaces/SK/pages/157974545/Label+Printing+for+Zebra+ZPL+Compatible+Printers#Q%3AWhatarethestepstoprinttoaZebra(ZPL)compatibleprinter%3F") desktop application automatically when tasks are taken into either the In Progress or Done statuses.

**To configure a task to print labels**

1.  _ZPL Report Setup_
    
    1.  Configure a ZPL report that relates the correct property information that you would like included in your label.
        
    2.  Configure the Label Template for the report to the Report Fields in that report.
        
2.  _Task Setup_
    
    1.  For the task that you want to use to trigger label printing, you will need to specify the task status from which to trigger the label generation in the Print Label column of the Task Definitions admin.
        
    2.  To specify which ZPL report to run, you will need to choose it from the Label Report column of the [Task Definitions](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/217711302 "https://gtpservices.atlassian.net/wiki/spaces/SK/pages/217711302") admin.
        
3.  _Tool Setup_
    
    1.  You will need to have a tool set up that is configured with a Type of ZPL Printer.
        
4.  _Station Setup - This builds the relationship between the task and its related report and label template to the printing tool assigned to the station_
    
    1.  You will need to have a tool with a Type of ZPL Printer associated with your station and it will have to be assigned to the device that is connected to the printer.
        
    2.  The station will also need to have the Task Definition associated with it.
        

## **What Task and Label Automation Means For You**
---
created: 2025-06-25T06:30:43 (UTC -04:00)
tags: []
source: https://gtpservices.atlassian.net/wiki/spaces/SK/pages/240713729/Task+Workflows+Admin
author: 
---

# Task Workflows (Admin) - STRATUS Knowledge Base - Confluence

> ## Excerpt
> A Task Workflow is an older feature that has been replaced by Task Definitions.

---
A Task Workflow is an older feature that has been replaced by [**Task Definitions**](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/217711302 "https://gtpservices.atlassian.net/wiki/spaces/SK/pages/217711302").

-   1 [Configure Task Workflow Prerequisites](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/240713729/Task+Workflows+Admin#Configure-Task-Workflow-Prerequisites)
    -   1.1 [Task Categories](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/240713729/Task+Workflows+Admin#Task-Categories)
    -   1.2 [Cost Categories](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/240713729/Task+Workflows+Admin#Cost-Categories)
    -   1.3 [Cost Types](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/240713729/Task+Workflows+Admin#Cost-Types)
    -   1.4 [Task Definitions](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/240713729/Task+Workflows+Admin#Task-Definitions)
-   2 [Task Workflow Configuration](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/240713729/Task+Workflows+Admin#Task-Workflow-Configuration)
    -   2.1 [Define a Task Workflow](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/240713729/Task+Workflows+Admin#Define-a-Task-Workflow)
-   3 [Video](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/240713729/Task+Workflows+Admin#Video)
    -   3.1 [Stratus 06-06-19 Implementation Webinar (Task Workflow 28:06)](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/240713729/Task+Workflows+Admin#Stratus-06-06-19-Implementation-Webinar-(Task-Workflow-28%3A06))

## Configure Task Workflow Prerequisites

Before Task Workflows can be defined, Task Categories, Cost Categories, Cost Types, and Task Definitions must be defined.  Below are some examples.

## Task Categories

Task Categories are used to categorize Task Definitions like Bending, Cutting, Detailing, Installing, etc. Task Categories are large buckets of work that are done in the shop. Examples might be welding activities, grooving activities, trade activities like hangers and supports, mechanical piping, plumbing, process piping, sheet metal, electrical, shipping, and receiving. 

## Cost Categories

A Cost Category is a way to assign a cost category to each part when the model is published. Rules are defined by you to assign parts to each cost category. See the [**Cost Categories**](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/10518700 "https://gtpservices.atlassian.net/wiki/spaces/SK/pages/10518700") article for more information.

## Cost Types

A Cost Type is a way to categorize costs. See the [**Cost Types**](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/10486154 "https://gtpservices.atlassian.net/wiki/spaces/SK/pages/10486154") article for more information.

## Task Definitions

Task Definitions are process tasks. You can make them as detailed or broad as you like. In this example Cut Pipe using TigerStop and saw, Order Materials, and Weld Pipe. Each definition is assigned to a Task Category, Cost Category, Cost Type, and is applied to a Tracking Status which enables items to automatically change to the selected Status (Ex. Fabricated, Materials Received, Fabricated, etc.). Task Definitions display in Stratus as either the Name or the Image. The image will be used if it is uploaded. See the [**Task Definitions**](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/217711302 "https://gtpservices.atlassian.net/wiki/spaces/SK/pages/217711302") article for more information.

## Task Workflow Configuration

## Define a Task Workflow

Define a Task Workflow under **Admin** > **Company** > **Task Workflows**.   

![](blob:https://gtpservices.atlassian.net/b05372c1-d47e-488f-9141-203d7f58cc8a)

1.  To configure a new task workflow, click the **New Task Workflow** button. A new row will display. This example will show an example Weld Pipe Spool task workflow.
    
    1.  **Task Workflow #** - The Workflow number is used in the scenario where several similar task workflows exist, but there is a preference as to which Task Workflow should be applied first. For example, if you want a Task Workflow where Apply to Type = Assembly, the targeted assemblies have both pipe and valves in them, you can write a filter for either one or both. Two or more Task Workflows can return the same number of parts. To break a tie, the sequence number will be used as a priority.
        
    2.  **Move Arrows** - Move Task Workflows up or down.
        
    3.  **Name (Required)** – Enter the short name (Ex. Weld Pipe). This name will display on the Package’s Items tab when selecting the Task Workflow.  
        
        ![](blob:https://gtpservices.atlassian.net/d07f3dc6-3054-4510-9e7b-69f094573094)
        
    4.  **Description (Required)** – Enter a description that could be a longer name since it does not display anywhere. (Ex. Weld Pipe Spool).
        
    5.  **Apply to Type (Required)** – A task workflow can be applied to either a **Part** or an **Assembly**.
        
    6.  **Task Sequence (Required)** – Configure the sequence of tasks that will be used in Stratus. **Tip:** When configuring a Task Sequence, it’s a good idea to have the Task Workflow page and the Task Definition page open side-by-side.
        
        1.  Click the **Add a Task Definition** button to select the first Task Definition in the task sequence (Ex. Cut).
            
        2.  Click the
            
            ![](blob:https://gtpservices.atlassian.net/7444cb69-583b-4475-a2b9-c06299b1faef)
            
             to select the 2<sup data-renderer-mark="true">nd</sup> task definition in the task sequence (Ex. Tack).  
            
            ![](blob:https://gtpservices.atlassian.net/6d0c42f5-4dbe-438e-b571-8c2925ad329b)
            
        3.  Continue as needed.
            
        4.  The Task Sequence will look similar to the following:  
            
            ![](blob:https://gtpservices.atlassian.net/032cb602-6683-4c3a-91c8-8116c30885e6)
            
        5.  You can Remove a Task Definition by clicking the
            
            ![](blob:https://gtpservices.atlassian.net/92d10378-711e-4c8b-a9cf-fabf03a292cd)
            
             button or reorder the tasks using the Move
            
            ![](blob:https://gtpservices.atlassian.net/2df9f1ce-a230-4303-b229-7a17dbcebedb)
            
             buttons.
    7.  **Initiated by Tracking Status (Required)** – Set the **Initiated by Tracking Status** to the Package tracking status that will initiate the task workflow. The drop-down list only includes tracking statuses where the **Can Package** and **Can Assemble** columns have been unchecked, meaning the package or assembly cannot be edited once a task workflow has started. Below is an example.
        
    8.  **Apply to Package Category (Optional)** – Once you are familiar with how the Task Workflow works, you can further refine a Task Workflow by using the **Apply to Package Category** option.  When a package is created, it is assigned to either the **Default** Package Category or a Package Category defined by your administrator. See Package Categories in the Knowledge Base. The **Apply to Package Category** means that Task Workflow can only be kicked off when the package is in the selected Package Category. Using the Apply to Package Category filter to know that only packages in certain categories will go through the workflow.  
        
        ![](blob:https://gtpservices.atlassian.net/8f480487-0a67-4887-b042-c7ed493c2dd1)
        
    9.  **Apply using Filter** -  You could apply any filter. For example, you could use a filter where the material is carbon steel and the end type is beveled, otherwise, the parts won’t have access to workflow targeted to send cuts to a specific station.
        
    10.  **Delete** - Delete the Task Workflow.
        

## Video

## Stratus 06-06-19 Implementation Webinar (Task Workflow 28:06)

<iframe allowfullscreen="" allowtransparency="true" data-hasbody="false" data-layout="default" data-local-id="da35a474-899e-4c9e-a631-34606ee389df" data-macro-id="615326f1-50cf-4c4d-8c1e-85867e402d70" data-macro-name="widget" frameborder="0" height="364" mozallowfullscreen="" webkitallowfullscreen="" width="640" src="https://player.vimeo.com/video/341888740?h=embed"></iframe>
---
created: 2025-06-25T06:30:43 (UTC -04:00)
tags: []
source: https://gtpservices.atlassian.net/wiki/spaces/SK/pages/1558249473/Templates+Admin
author: 
---

# Templates (Admin) - STRATUS Knowledge Base - Confluence

> ## Excerpt
> A Template is used in conjunction with some reports so that the report can be PDF formatted and printed. A report displays data from the model in a tabular format, while a Template can bring together multiple data types (data fields, images, isometric views, QR codes, etc.) and other formatting options.  Examples of report/template combinations include a spool sheet report, a package details report that contains a spool map, a vendor BOM list with your company header, a generic letterhead that includes model data, and more.

---
A Template is used in conjunction with some reports so that the report can be PDF formatted and printed. A report displays data from the model in a tabular format, while a Template can bring together multiple data types (data fields, images, isometric views, QR codes, etc.) and other formatting options.  Examples of report/template combinations include a spool sheet report, a package details report that contains a spool map, a vendor BOM list with your company header, a generic letterhead that includes model data, and more.

-   1 [Create New Template](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/1558249473/Templates+Admin#Create-New-Template)
    -   1.1 [Default Template](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/1558249473/Templates+Admin#Default-Template)
    -   1.2 [Save As and New Template](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/1558249473/Templates+Admin#Save-As-and-New-Template)
    -   1.3 [Template Type](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/1558249473/Templates+Admin#Template-Type)
    -   1.4 [Default Checkbox](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/1558249473/Templates+Admin#Default-Checkbox)
    -   1.5 [Paper Size and Orientation](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/1558249473/Templates+Admin#Paper-Size-and-Orientation)
-   2 [Page Management](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/1558249473/Templates+Admin#Page-Management)
    -   2.1 [Page Summary](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/1558249473/Templates+Admin#Page-Summary)
    -   2.2 [Page Selector](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/1558249473/Templates+Admin#Page-Selector)
    -   2.3 [Add New Page](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/1558249473/Templates+Admin#Add-New-Page)
    -   2.4 [Delete Page](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/1558249473/Templates+Admin#Delete-Page)
    -   2.5 [Cover Page](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/1558249473/Templates+Admin#Cover-Page)
    -   2.6 [Omit page if Report(s) are empty](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/1558249473/Templates+Admin#Omit-page-if-Report(s)-are-empty)
    -   2.7 [Overflow Data](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/1558249473/Templates+Admin#Overflow-Data)
-   3 [Content Elements Defined](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/1558249473/Templates+Admin#Content-Elements-Defined)
    -   3.1 [Report](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/1558249473/Templates+Admin#Report)
    -   3.2 [Secondary Report](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/1558249473/Templates+Admin#Secondary-Report)
    -   3.3 [Insert Image](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/1558249473/Templates+Admin#Insert-Image)
    -   3.4 [Label](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/1558249473/Templates+Admin#Label)
    -   3.5 [Report Field](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/1558249473/Templates+Admin#Report-Field)
        -   3.5.1 [Stratus.Project.\*Role\*](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/1558249473/Templates+Admin#Stratus.Project.*Role*)
    -   3.6 [QR Code](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/1558249473/Templates+Admin#QR-Code)
    -   3.7 [Top View, Front View, Isometric View](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/1558249473/Templates+Admin#Top-View%2C-Front-View%2C-Isometric-View)
    -   3.8 [Line](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/1558249473/Templates+Admin#Line)
    -   3.9 [Rectangle](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/1558249473/Templates+Admin#Rectangle)
-   4 [Working with Content Element Properties](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/1558249473/Templates+Admin#Working-with-Content-Element-Properties)
    -   4.1 [Create an Element in Paper Space](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/1558249473/Templates+Admin#Create-an-Element-in-Paper-Space)
    -   4.2 [Select Element](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/1558249473/Templates+Admin#Select-Element)
    -   4.3 [Page Property Value](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/1558249473/Templates+Admin#Page-Property-Value)
    -   4.4 [Font Size and Alignment](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/1558249473/Templates+Admin#Font-Size-and-Alignment)
    -   4.5 [Size and Position](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/1558249473/Templates+Admin#Size-and-Position)
    -   4.6 [Right-click Commands and Layering](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/1558249473/Templates+Admin#Right-click-Commands-and-Layering)
    -   4.7 [Rotation](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/1558249473/Templates+Admin#Rotation)
-   5 [Videos](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/1558249473/Templates+Admin#Videos)
    -   5.1 [08/19/2024 - Stratus Academy: ADM-508: Admin 2 - Templates](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/1558249473/Templates+Admin#08%2F19%2F2024---Stratus-Academy%3A-ADM-508%3A-Admin-2---Templates)
    -   5.2 [03/18/2021 CSG Webinar: View Styles For PDF Templates](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/1558249473/Templates+Admin#03%2F18%2F2021-CSG-Webinar%3A-View-Styles-For-PDF-Templates)
    -   5.3 [03/11/2021 CSG Webinar: Setting Up PDF Templates](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/1558249473/Templates+Admin#03%2F11%2F2021-CSG-Webinar%3A-Setting-Up-PDF-Templates)

## Create New Template

## Default Template

By default, a new template has one page that includes the [**Report**](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/1558249473#Report "https://gtpservices.atlassian.net/wiki/spaces/SK/pages/1558249473#Report") element and a Page Properties panel.

When an element is selected (Ex. Report) in either paper space or in Page Properties it is:

1.  Highlighted in the paper space (the highlight is blue and blinks)
    
2.  Highlighted in the Page Properties in the Content section
    
3.  The Page number is highlighted in the Page Properties
    
4.  Properties that can be edited display. For the Report element, the position and dimensions can be edited.
    

## Save As and New Template

1.  Under **Admin** > **Company** > **Templates** the templates tab displays.
    
2.  By default, no template is selected, a default template page displays on the left that includes the Report element, and its Page Properties display on the right.
    
      
    **To create a new template:**
    
3.  Click **Save As** to name the new template that only includes the [**Report**](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/1558249473#Report "https://gtpservices.atlassian.net/wiki/spaces/SK/pages/1558249473#Report") element. The Save Template dialog will display where a Template Name can be entered.
    
      
    **To create a new template when an existing template is open:**
    
4.  Click the **New Template** button. By default, the new template will only include the [**Report**](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/1558249473#Report "https://gtpservices.atlassian.net/wiki/spaces/SK/pages/1558249473#Report") element is created. The Save Template dialog will display where a Template Name can be entered.
    
      
    **To save a copy of an existing template:**
    
5.  Open the template and click **Save As** to name a new template that includes the elements contained in the selected template.
    

## Template Type

Each template is associated with one Template Type.

1.  Select a template type early in the template creation process because the Template Type must match the Report Item Type that you intend to use. For example, only a Package BOM Template Type can be associated with a Report whose Item Type is BOM. Below are the template type associations:
    
    1.  **Generic** - The Generic type can be assigned to any report that has a format of PDF. The following functions are hidden for the Generic type:
        
        1.  QR Code
            
        2.  Top View, Front View, Isometric View, 2D Plan View
            
    2.  **Assembly Sheet** \- The Assembly Sheet type can be assigned to any report that has the Item Type set to Assembly.
        
    3.  **Package BOM -** The Package BOM type can be assigned to any report that has the Item Type set to BOM. 
        
    4.  **Container Details** - The Container Details type can be assigned to any report that has the Item Type set to Container Details.
        
    5.  **Package Sheet** \- The Package Sheet type can be assigned to any report that has the Item Type set to Package Details.
        

## Default Checkbox

For each [**Template Type**](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/1558249473#Template-Type "https://gtpservices.atlassian.net/wiki/spaces/SK/pages/1558249473#Template-Type"), there is one default template.

1.  Each report under Admin > Company > Reports whose Format = PDF can specify a template to format the report. When a report does not specify a template the default template associated with the Template Type and Report Item Type is used when the report is run. For example, this report does not have a Template specified.
    
2.  Out-of-the-box templates preceded with the word “Stratus” serve as the default template.
    
3.  As new templates are added, the Admin can choose to make a different template serve as the default template by checking the **Default** checkbox.
    
4.  If a template preceded with the word “Stratus” is edited, it can be reset its out-of-the-box template element content and positions.
    

## Paper Size and Orientation

Each template is constrained by the **Paper Size** which is defined by the Paper Size and Orientation.

1.  Click the Paper Size drop-down to set the paper size. The paper space boundary will be set to the paper size selected.
    
2.  Use the Custom option to set a custom paper size.
    
3.  If you make any changes, click the **Save** button.
    
4.  The **Orientation** can be **Landscape** or **Portrait**.
    
    1.  **Note**: If the template includes elements and then the orientation is changed, the orientation command may automatically resize some elements to fit the new orientation. An Orientation change only is saved after the Save button is clicked.
        
5.  For best results, if you use the **Insert Image** feature to insert an image of an AutoCAD sheet that you saved to a .jpg or .png, the inserted image may be larger than your paper size. In this case, use the **Custom** option to create a size large enough to contain the image, then resize the image so that it fits your sheet. Once the image is sized, change the Paper Size back to the correct size.
    

## Page Management

By default, out-of-the-box Stratus templates start with one page. New pages can be added and the elements on each page can be independently managed. Pages can also be deleted.

## Page Summary

Once the template Paper Size and Orientation have been set, a page will include the following:

1.  **Create Page** - Use the Page Selector to select the page. After clicking the [**+Page**](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/1558249473#Add-New-Page "https://gtpservices.atlassian.net/wiki/spaces/SK/pages/1558249473#Add-New-Page") button, the page will be inserted after the currently selected page. There is no limit to the number of pages that can be created.
    
2.  **Page Selector** - The Page Selector arrows are used to select the active page (currently page 4 of 5).
    
3.  **Delete Page** - Use the Page Selector to select the page to be deleted and then click the **Delete Page** button.
    
4.  **Show in full-screen mode** \- The **Show in full-screen mode** button will display the page in full screen. Neither the Stratus menu nor the Windows taskbar will display. **Note:** If, after exiting full-screen mode, the Page Properties panel is offscreen, go back to full-screen mode, move the panel and then exit full-screen mode until the panel is onscreen.
    
5.  **Paper Space Elements** \- Report elements are placed on the page. Only the default Report element is displaying above. See the [**Report**](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/1558249473#Report "https://gtpservices.atlassian.net/wiki/spaces/SK/pages/1558249473#Report") section for more information.
    
6.  **Page Properties** - Page Properties displays all template elements. See the [**Working with Content Element Properties**](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/1558249473#Working-with-Content-Element-Properties "https://gtpservices.atlassian.net/wiki/spaces/SK/pages/1558249473#Working-with-Content-Element-Properties") for more detailed information.
    
    1.  The element selected in Page Properties can be edited even if it is not on the currently selected page. If the element is on the currently selected page, it will be highlighted in blue and will blink. **Note:** The currently selected element in this example is on page 2 indicated by the check on Page 2. This element could be on multiple pages indicated by checks on other pages.
        
    2.  Elements highlighted in white have been placed on the selected page.
        
    3.  Elements highlighted in gray have not been placed on the selected page.
        
7.  **Zoom** \- The **Zoom In** and **Zoom Out** buttons only zoom the paper space, not the Page properties or the web page in general
    
8.  **Scroll bars** - Sometimes the paper space exceeds the viewable window depending on the template's Size, Orientation, and Zoom settings. The scroll bars will display when needed.
    

## Page Selector

The **Page Selector** arrows are used to select the active page. In the example below there are 5 total pages in the template and page 4 is the currently selected page. When the actual report is run, data extracted to display on either a Report or a Secondary Report element may overflow to one or more subsequent pages, thereby increasing the number of pages of the actual report. See the [**Overflow Data**](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/1558249473#Overflow-Data "https://gtpservices.atlassian.net/wiki/spaces/SK/pages/1558249473#Overflow-Data") section for more information.

## Add New Page

Adding a New Page gives users control over where report elements display.

**To add a new Page:**

1.  Open the template.
    
2.  Use the [**Page Selector**](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/1558249473#Page-Selector "https://gtpservices.atlassian.net/wiki/spaces/SK/pages/1558249473#Page-Selector") to select the page.
    
3.  Click the **+Page** button.
    
4.  The new page will be inserted after the selected page and will bump any existing pages after the newly inserted page number to a new page number. In addition:
    
    1.  the new page will inherit content elements whose [**Page Property Value**](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/1558249473#Page-Property-Value "https://gtpservices.atlassian.net/wiki/spaces/SK/pages/1558249473#Page-Property-Value") is set to **All** as well as the template Paper Size, Orientation, and Template Type.
        
    2.  the new page will be the active page.
        
    3.  the [**Page Selector**](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/1558249473#Page-Selector "https://gtpservices.atlassian.net/wiki/spaces/SK/pages/1558249473#Page-Selector") will indicate that the new page is active.
        
    4.  the [**Page Property Value**](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/1558249473#Page-Property-Value "https://gtpservices.atlassian.net/wiki/spaces/SK/pages/1558249473#Page-Property-Value") will indicate which page is active.
        

## Delete Page

**To delete a page:**

1.  Use the [**Page Selector**](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/1558249473#Page-Selector "https://gtpservices.atlassian.net/wiki/spaces/SK/pages/1558249473#Page-Selector") to select the page and then click the **delete Page** button.
    
2.  In this example, if page 2/3 is selected and the Delete Page button is clicked, Page 2 and all of its elements will be deleted and Page 3 will become Page 2. If any elements are included on other pages, those elements will not be deleted.
    

## Cover Page

A cover page is configured like any other page by defining the elements that are on Page 1 compared to Page 2, etc.

## Omit page if Report(s) are empty

The **Omit page if Report(s) are empty** option under Page Properties. With this option checked, the page will display if any reports configured on the page include data, if not the page will be omitted and not display.

For example:

1.  **Template Setup = CSG \_ MEP \_ Hanger Fabrication** - This template has 2 pages. Each page includes a report and the **Omit page if Report(s) are empty** option under Page Properties. By default the **Omit page if Report(s) are empty** option is unchecked.
    
2.  **Unchecked - Omit page if Report(s) are empty** - When the **Omit page if Report(s) are empty** option is unchecked, the Stratus Sheet will display a page regardless if report data exists.
    
    1.  **Page 1** - includes a secondary report for Single Rod hangers which exist in the selected package.
        
    2.  **Page 2** - includes a secondary report for Trapeze hangers which **do not exist** in the selected package. However, since **Omit page if Report(s) are empty** option is unchecked, the page still displays.
        
3.  **Checked - Omit page if Report(s) are empty** - When the **Omit page if Report(s) are empty** option is checked, the Stratus Sheet will display a page only if report data if it exists (Ex. Page 1), but not if no data exists (Ex. Page 2).
    
    1.  **Page 1** - includes a secondary report for Single Rod hangers which exist in the selected package.
        
    2.  **Page 2** - includes a secondary report for Trapeze hangers which **do not exist** in the selected package. Since **Omit page if Report(s) are empty** option is checked, this page does not display in the Stratus Sheet.
        
4.  If a secondary report is added to Page 2 that includes data from the selected package, then the page will display. So each report placed on page is evaluated to determine if it should be omitted if the report is empty.
    

## Overflow Data

Overflow data will flow to a new page using the same elements as the prior page. Once the overflow data has been placed on a page, the elements configured for the next page number will be used.

For example, below is a 3-page template. The Page 2 template configuration and elements below include 3 different [**Secondary Reports**](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/1558249473/Templates%2BAdmin#Secondary-Report "https://gtpservices.atlassian.net/wiki/spaces/SK/pages/1558249473/Templates%2BAdmin#Secondary-Report"). The data to be included in the PIPE-BOM Secondary Report exceeds what can fit in the height of the element. As a result, the data overflows to the next page using the same page template settings. Once all data for the Secondary Report has been placed on a page, then the following page will use the Page 3 template configuration and elements. As a result, a template may have 4 defined pages, but the actual report could include many more pages.

## Content Elements Defined

Page Content Elements are placed in the paper space. Each element placed in the paper space of a page will also display in the Page Properties panel. Each element includes Properties to size, position, layer, and some elements have additional properties.

## Report

The Report element is used to populate a report with tabular report data defined in existing reports under Admin > Company > Reports. A Report element is configured differently than a [**Secondary Report**](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/1558249473/Templates%2BAdmin#Secondary-Report "https://gtpservices.atlassian.net/wiki/spaces/SK/pages/1558249473/Templates%2BAdmin#Secondary-Report").

1.  The Report element is placed on a new template by default. The Report element cannot be manually added to a page or deleted from a page. The Report element’s [**Page Property Value**](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/1558249473/Templates+Admin#Page-Property-Value "https://gtpservices.atlassian.net/wiki/spaces/SK/pages/1558249473/Templates+Admin#Page-Property-Value") can be set to hide or display the element on each page.
    
2.  When the **Report** element’s [**Page Property Value**](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/1558249473/Templates+Admin#Page-Property-Value "https://gtpservices.atlassian.net/wiki/spaces/SK/pages/1558249473/Templates+Admin#Page-Property-Value") is set to display the element on a page, it means that there will be a report under Admin > Company > Reports, where the **template is selected** (below).
    
    1.  The Templates available for a report depend on the report’s Item Type. Only templates whose Template Type is compatible with the Report Item Type will display. For example, only a Package Details Template Type can be associated with a Report whose Item Type is Package Details. See the [**Template Type**](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/1558249473#Template-Type "https://gtpservices.atlassian.net/wiki/spaces/SK/pages/1558249473#Template-Type") section for more information.
        
    2.  When the report is run, the report title (See Show Report Title below) and the report’s report field data will display within the boundaries of the Report element. See the [**Overflow Data**](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/1558249473#Overflow-Data "https://gtpservices.atlassian.net/wiki/spaces/SK/pages/1558249473#Overflow-Data") section for more information.
        
3.  With the Report element selected, the configuration options include:
    
    1.  [**Page Property Value**](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/1558249473/Templates+Admin#Page-Property-Value "https://gtpservices.atlassian.net/wiki/spaces/SK/pages/1558249473/Templates+Admin#Page-Property-Value") can display the element on All pages or set to Custom to control which page(s) the element displays on.
        
    2.  [**Size and Position**](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/1558249473/Templates%2BAdmin#Size-and-Position "https://gtpservices.atlassian.net/wiki/spaces/SK/pages/1558249473/Templates%2BAdmin#Size-and-Position") can be used to place the element in paper space.
        
    3.  [**Right-click Commands and Layering**](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/1558249473#Right-click-Commands-and-Layering "https://gtpservices.atlassian.net/wiki/spaces/SK/pages/1558249473#Right-click-Commands-and-Layering") can be used to layer the element.
        
    4.  [**Font Size**](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/1558249473#Font-Size "https://gtpservices.atlassian.net/wiki/spaces/SK/pages/1558249473#Font-Size") can be changed under the selected report's Property settings. There are separate font settings for the report Title and the report Body.
        
    5.  **Show Report Title** - The **Show Report Title** checkbox is part of both the Report element and is used to control whether the report title will display on the report or not. See the screenshot above. For example:
        
        1.  **Checked** - When checked, a report run from the Package’s Attachments tab will display the title of the report.
            
        2.  **Unchecked** - When unchecked, the report title will not display.
            

## Secondary Report

A **Secondary Report** element is available on templates whose Template Type is **Generic**, **Assembly Sheet, Package Sheet,** and **Package BOM**. The Secondary Report element is used to populate a report with tabular report data defined in existing reports under Admin > Company > Reports. A Secondary Report element is configured differently than a [**Report**](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/1558249473#Report "https://gtpservices.atlassian.net/wiki/spaces/SK/pages/1558249473#Report").

1.  When any **Secondary Report** element is placed on any template page, it means that when the report associated with the template is run, the selected Secondary Report will also run.
    
    1.  The reports that display in the **Secondary Report** drop-down are those where the report’s Assembly Viewer checkbox is checked under Admin > Company > Reports.
        
    2.  When the secondary report is run, the report title (See Show Report Title below) and the report’s report field data will display within the boundaries of the Secondary Report element. See the [**Overflow Data**](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/1558249473#Overflow-Data "https://gtpservices.atlassian.net/wiki/spaces/SK/pages/1558249473#Overflow-Data") section for more information.
        
2.  To add a **Secondary Report** element to a page:
    
    1.  Click the **Secondary Report** button and then click the drop-down button. A list of reports where the report’s Assembly Viewer checkbox is checked under Admin > Company > Reports will display.
        
    2.  Select one secondary report.
        
    3.  Click the **Add** button. The Secondary Report element using the report’s name will be placed in the top left corner of the selected page’s paper space.
        
3.  With the Secondary Report element selected, the configuration options include:
    
    1.  [**Page Property Value**](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/1558249473/Templates+Admin#Page-Property-Value "https://gtpservices.atlassian.net/wiki/spaces/SK/pages/1558249473/Templates+Admin#Page-Property-Value") can display the element on All pages or set to Custom to control which page(s) the element displays on.
        
    2.  [**Size and Position**](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/1558249473/Templates%2BAdmin#Size-and-Position "https://gtpservices.atlassian.net/wiki/spaces/SK/pages/1558249473/Templates%2BAdmin#Size-and-Position") can be used to place the element in paper space.
        
    3.  [**Right-click Commands and Layering**](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/1558249473#Right-click-Commands-and-Layering "https://gtpservices.atlassian.net/wiki/spaces/SK/pages/1558249473#Right-click-Commands-and-Layering") can be used to layer the element. Notice that a Secondary Report can be deleted.
        
    4.  **Show Report Title** - The **Show Report Title** checkbox is part of both the Report element and is used to control whether the report title will display on the report or not. See screenshot above. For example:
        
        1.  **Checked** - When checked, a report run from the Package’s Attachments tab will display the title of the report.
            
        2.  **Unchecked** - When unchecked, the report title will not display.
            

## Insert Image

Insert Image can be used to insert an image like a company logo or an AutoCAD sheet. Supported file types include gif, .jpg, .jpeg, .png. **Note:** Many company's use the Insert Image feature to insert an image of an AutoCAD sheet that was saved to a .jpg or .png file within the authoring software. The inserted image may be larger than your paper size. In this case, use the Paper Size > Custom option to create a size large enough to contain the image, then resize the image so that it fits your sheet. Once the image is sized, change the Paper Size back to the correct size. Use the [**right-click tools**](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/1558249473#Right-click-Commands-and-Layering "https://gtpservices.atlassian.net/wiki/spaces/SK/pages/1558249473#Right-click-Commands-and-Layering") to control the layering or draw order (Ex. Send to Back, Bring Forward, etc.). 

**To Insert Image:**

1.  Click the **Insert Image** button.
    
2.  Locate the image. The **Insert an Image** dialog will display.
    
3.  Click **Insert**. The image will be placed on the selected page’s paper space in the top left corner.
    
4.  With the element selected, the configuration options include:
    
    1.  [**Page Property Value**](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/1558249473/Templates+Admin#Page-Property-Value "https://gtpservices.atlassian.net/wiki/spaces/SK/pages/1558249473/Templates+Admin#Page-Property-Value") can display the element on All pages or set to Custom to control which page(s) the element displays on.
        
    2.  [**Size and Position**](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/1558249473/Templates%2BAdmin#Size-and-Position "https://gtpservices.atlassian.net/wiki/spaces/SK/pages/1558249473/Templates%2BAdmin#Size-and-Position") can be used to place the element in paper space.
        
    3.  [**Right-click Commands and Layering**](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/1558249473#Right-click-Commands-and-Layering "https://gtpservices.atlassian.net/wiki/spaces/SK/pages/1558249473#Right-click-Commands-and-Layering") can be used to layer the element. Notice that a Secondary Report can be deleted.
        
    4.  **Data** \- Provides a thumbnail of the selected image.
        

## Label

A label element is used to place any formatted text on the page.

**To add a label to paper space:**

1.  Click the **Label** drop-down.
    
2.  Enter the name of a label and then click **Add**. The label will be placed on the selected page’s paper space in the top left corner.
    
3.  With the Report element selected, the configuration options include:
    
    1.  [**Page Property Value**](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/1558249473/Templates+Admin#Page-Property-Value "https://gtpservices.atlassian.net/wiki/spaces/SK/pages/1558249473/Templates+Admin#Page-Property-Value") can display the element on All pages or set to Custom to control which page(s) the element displays on.
        
    2.  [**Size and Position**](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/1558249473/Templates%2BAdmin#Size-and-Position "https://gtpservices.atlassian.net/wiki/spaces/SK/pages/1558249473/Templates%2BAdmin#Size-and-Position") can be used to place the element in paper space.
        
    3.  [**Right-click Commands and Layering**](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/1558249473#Right-click-Commands-and-Layering "https://gtpservices.atlassian.net/wiki/spaces/SK/pages/1558249473#Right-click-Commands-and-Layering") can be used to layer the element.
        
    4.  [**Font Size**](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/1558249473#Font-Size "https://gtpservices.atlassian.net/wiki/spaces/SK/pages/1558249473#Font-Size") can be changed in the right-click menu or under the selected label’s Property settings.
        
    5.  [**Rotation**](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/1558249473/Templates+Admin#Rotation "https://gtpservices.atlassian.net/wiki/spaces/SK/pages/1558249473/Templates+Admin#Rotation") can be used to rotate Label and Report Fields 90 degrees.
        

## Report Field

A **Report Field** element is available on templates whose Template Type is **Generic**, **Assembly Sheet, Package Sheet,** and **Package BOM**. The Report Field drop-down lists report fields that are compatible with the selected template’s Template Type. For example, if the Template Type is Assemblies Sheet, then the drop-down list will be restricted to Stratus.Assembly options. Similarly, if the Template Type is Package Sheet, then the drop-down list will be restricted to Stratus.Field and Stratus.Package options.

**To add a report field:**

1.  Click the **Report Field** button and then click the drop-down button. A list of report fields compatible with the selected template’s Template Type will display.
    
2.  Select one report field.
    
3.  Click the **Add** button. The Report Field element will be placed on the selected page’s paper space in the top left corner.
    
4.  With the Report element selected, the configuration options include:
    
    1.  [**Page Property Value**](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/1558249473/Templates+Admin#Page-Property-Value "https://gtpservices.atlassian.net/wiki/spaces/SK/pages/1558249473/Templates+Admin#Page-Property-Value") can display the element on All pages or set to Custom to control which page(s) the element displays on.
        
    2.  [**Size and Position**](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/1558249473/Templates%2BAdmin#Size-and-Position "https://gtpservices.atlassian.net/wiki/spaces/SK/pages/1558249473/Templates%2BAdmin#Size-and-Position") can be used to place the element in paper space.
        
    3.  [**Right-click Commands and Layering**](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/1558249473#Right-click-Commands-and-Layering "https://gtpservices.atlassian.net/wiki/spaces/SK/pages/1558249473#Right-click-Commands-and-Layering") can be used to layer the element.
        
    4.  [**Font Size**](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/1558249473#Font-Size "https://gtpservices.atlassian.net/wiki/spaces/SK/pages/1558249473#Font-Size") can be changed in the right-click menu or under the selected label’s Property settings.
        
    5.  [**Rotation**](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/1558249473/Templates+Admin#Rotation "https://gtpservices.atlassian.net/wiki/spaces/SK/pages/1558249473/Templates+Admin#Rotation") can be used to rotate Label and Report Fields 90 degrees.
        

### Stratus.Project.\*Role\*

A user’s project role can be added as a report field.

The value(s) for property Stratus.Project.\*, where \* is a project role comes from the Admin > Project > Team > Project Role value for each team member. The Role name check is not case-sensitive, but does need to be an exact match otherwise. For example, when Stratus.Project.ShopForeman is selected below, team member project roles for Shop Foreman or Foreman will display.

PROPERTY: Role(s)

Stratus.Project.Detailer: Detailer, Draftsman  
Stratus.Project.FieldForeman: Field Foreman, Foreman  
Stratus.Project.FieldManager: Field Manager, Foreman  
Stratus.Project.ProjectManager: Project Manager  
Stratus.Project.ShopForeman: Shop Foreman, Foreman  
Stratus.Project.ShopManager: Shop Manager, Foreman

## QR Code

A QR Code can be placed on any page for easy access to the item in Stratus and for tracking updates. The type of QR Code placed on the page pre-configured by the Template Type. Below is a list of Template Types and the resulting QR Code.

-   Assembly Sheet = Assembly QR Code
    
-   Package BOM = Package QR Code
    
-   Container Details = Container QR Code
    
-   Generic - QR Code is not available
    
-   Package Sheet = Package QR Code
    

**To add a QR Code to a Template Type that allows a QR Code:**

1.  Click the **QR Code** button.
    
2.  The QR Code element will be placed on the selected page’s paper space in the top left corner.
    
3.  With the selected, the configuration options include:
    
    1.  [**Page Property Value**](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/1558249473/Templates+Admin#Page-Property-Value "https://gtpservices.atlassian.net/wiki/spaces/SK/pages/1558249473/Templates+Admin#Page-Property-Value") can display the element on All pages or set to Custom to control which page(s) the element displays on.
        
    2.  [**Size and Position**](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/1558249473/Templates%2BAdmin#Size-and-Position "https://gtpservices.atlassian.net/wiki/spaces/SK/pages/1558249473/Templates%2BAdmin#Size-and-Position") can be used to place the element in paper space.
        
    3.  [**Right-click Commands and Layering**](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/1558249473#Right-click-Commands-and-Layering "https://gtpservices.atlassian.net/wiki/spaces/SK/pages/1558249473#Right-click-Commands-and-Layering") can be used to layer the element.
        

## Top View, Front View, Isometric View

A **Top View, Front View, or Isometric View** element is available on templates whose Template Type is **Assembly Sheet, Package Sheet Details,** and **Package BOM**.

**To add a View to a page:**

1.  Click the **Top View**, **Front View**, or **Isometric View** button.
    
2.  The view element will be placed on the selected page’s paper space in the top left corner.
    
3.  With the selected, the configuration options include:
    
    1.  [**Page Property Value**](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/1558249473/Templates+Admin#Page-Property-Value "https://gtpservices.atlassian.net/wiki/spaces/SK/pages/1558249473/Templates+Admin#Page-Property-Value") can display the element on All pages or set to Custom to control which page(s) the element displays on.
        
    2.  [**Size and Position**](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/1558249473/Templates%2BAdmin#Size-and-Position "https://gtpservices.atlassian.net/wiki/spaces/SK/pages/1558249473/Templates%2BAdmin#Size-and-Position") can be used to place the element in paper space.
        
    3.  [**Right-click Commands and Layering**](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/1558249473#Right-click-Commands-and-Layering "https://gtpservices.atlassian.net/wiki/spaces/SK/pages/1558249473#Right-click-Commands-and-Layering") can be used to layer the element.
        
    4.  **Select View Style** - The **Select View Style** option is unique to view elements. When clicked a list of [**View Styles**](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/217711025/View%2BStyles%2BAdmin "https://gtpservices.atlassian.net/wiki/spaces/SK/pages/217711025/View%2BStyles%2BAdmin") configured under Admin > Company > View Styles will display. Select the View Style to be used for the selected view.
        

## Line

To add a Horizontal Line to the template:

1.  Click the **Line** button.
    
2.  The element will be placed on the selected page’s paper space in the top left corner.
    
3.  With the selected, the configuration options include:
    
    1.  [**Page Property Value**](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/1558249473/Templates+Admin#Page-Property-Value "https://gtpservices.atlassian.net/wiki/spaces/SK/pages/1558249473/Templates+Admin#Page-Property-Value") can display the element on All pages or set to Custom to control which page(s) the element displays on.
        
    2.  [**Size and Position**](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/1558249473/Templates%2BAdmin#Size-and-Position "https://gtpservices.atlassian.net/wiki/spaces/SK/pages/1558249473/Templates%2BAdmin#Size-and-Position") can be used to place the element in paper space.
        
    3.  [**Right-click Commands and Layering**](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/1558249473#Right-click-Commands-and-Layering "https://gtpservices.atlassian.net/wiki/spaces/SK/pages/1558249473#Right-click-Commands-and-Layering") can be used to layer the element.
        

## Rectangle

Rectangles can be used to create a border.

**To add a Rectangle element to the template:**

1.  Click the **Rectangle** button.
    
2.  The element will be placed on the selected page’s paper space in the top left corner.
    
3.  With the selected, the configuration options include:
    
    1.  [**Page Property Value**](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/1558249473/Templates+Admin#Page-Property-Value "https://gtpservices.atlassian.net/wiki/spaces/SK/pages/1558249473/Templates+Admin#Page-Property-Value") can display the element on All pages or set to Custom to control which page(s) the element displays on.
        
    2.  [**Size and Position**](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/1558249473/Templates%2BAdmin#Size-and-Position "https://gtpservices.atlassian.net/wiki/spaces/SK/pages/1558249473/Templates%2BAdmin#Size-and-Position") can be used to place the element in paper space.
        
    3.  [**Right-click Commands and Layering**](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/1558249473#Right-click-Commands-and-Layering "https://gtpservices.atlassian.net/wiki/spaces/SK/pages/1558249473#Right-click-Commands-and-Layering") can be used to layer the element.
        

## Working with Content Element Properties

## Create an Element in Paper Space

To place an element on a page’s paper space:

1.  Click an element highlighted below. See specifics on how individual elements are placed in the [**Page Content Elements Defined**](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/1558249473#Page-Content-Elements-Defined "https://gtpservices.atlassian.net/wiki/spaces/SK/pages/1558249473#Page-Content-Elements-Defined") section.
    
2.  In this example, a Label has been initially placed.
    
3.  The element will initially display in the top left corner of the paper space. If there is already an element there, it will look messy. Click and drag the element to place the element. Placement will be constrained by the paper space.
    
4.  Other tools can be used to format the element as needed.
    

## Select Element

1.  When an element is selected (Ex. Report) in either paper space or in Page Properties:
    
    1.  it has a blue border that blinks on/off so that it is easy to locate
        
    2.  it is highlighted in the paper space
        
    3.  it is highlighted in the Page Properties
        
    4.  the Page number is highlighted
        
    5.  the Pages in which the element has been included are checked
        
    6.  Properties that can be edited display. For the Label element, the position and dimensions can be edited
        

## Page Property Value

All elements have a Page Property that controls which pages the selected element will display on. On each page, the element can have a different size and position.

1.  **All** \- When All is selected, the element will display on All template pages. Newly created pages will inherit elements where All is selected.
    
2.  **Custom** \- When Custom is selected, the element will only display on the selected pages.
    

## Font Size and Alignment

**Font Size** and **Font Alignment** for **Label** and **Report Field** elements can be controlled from the **Page Properties** panel. Font Size can also be controlled by **right-clicking the element**.

## Size and Position

An element can be positioned or resized in paper space or in the Page Properties panel.

1.  To **position** any element within the paper boundaries, click/drag the element or, under Page Properties, enter the position into the Top or Left property.
    
2.  To **resize** any element within the paper boundaries, click/drag the bottom right corner handle or, under Page Properties, enter the position into the Width or Height property. When manually entering size values, only positive integers are valid. A decimal is rounded to the nearest integer and a negative number is converted to 0. In this example, Height = 400 (pixels).
    
3.  Note: If the size dimensions of a report are too small to fit the data, a message similar to the following will display when the report is run.
    

## Right-click Commands and Layering

When right-clicking an element in either paper space or in Page Properties, the same commands display.

1.  Right-click the element in paper space.
    
2.  Right-click the element in Page Properties.
    

## Rotation

The Rotation option is available to rotate text fields (Label and Report Field) 90 degrees. **Note**: Word wrap is available for 0 degree but not 90 degree rotation. Also, Left, Center, and Right alignment work for both 0 and 90 degree rotation, but Justify alignment for 90 degree is equivalent to Left align.

To rotate a text field:

1.  Under Admin > Company > Templates, open a template.
    
2.  Select a Label or Report Field text field.
    
3.  Change Rotation from 0 degrees to 90 degrees. The text rotates 90 degrees, but the text field dimensions still needs to be manually adjusted.
    
4.  Adjust the text field dimensions and then Save the template.
    
5.  Run the report and the rotated text will display.
    

## Videos

## 08/19/2024 - Stratus Academy: ADM-508: Admin 2 - Templates

To take the Templates course, login to [**Stratus Academy**](https://academy.stratus.build/ "https://academy.stratus.build/") and and locate the course ADM-508: Admin 2 - Templates.

## 03/18/2021 CSG Webinar: View Styles For PDF Templates

<iframe allowfullscreen="" allowtransparency="true" data-hasbody="false" data-layout="default" data-local-id="c1558c8a-e857-4a57-91d0-0194a792babe" data-macro-id="72b0ab50-f902-4424-8169-7e18366ec9ef" data-macro-name="widget" frameborder="0" height="364" mozallowfullscreen="" webkitallowfullscreen="" width="640" src="https://player.vimeo.com/video/527935047?h=embed"></iframe>

00:00 Release Notes Review  
03:15 View Styles Linked to Templates  
04:30 View Styles Configuration  
05:30 Render, Appearance, Visibility Examples  
12:00 Part, Dimension, Tag Visibility Examples  
18:00 Line Weights, Fonts, Arrowheads  
25:25 Item Number - Leaders, Arrowheads, Background Bubble Color

## 03/11/2021 CSG Webinar: Setting Up PDF Templates

<iframe allowfullscreen="" allowtransparency="true" data-hasbody="false" data-layout="default" data-local-id="af889baf-2cf4-4ae2-b70b-83a4c441849d" data-macro-id="a74891ab-230b-4c84-8d68-2ace04e33c4b" data-macro-name="widget" frameborder="0" height="364" mozallowfullscreen="" webkitallowfullscreen="" width="640" src="https://player.vimeo.com/video/522992170?h=embed"></iframe>

00:00 Introduction  
02:20 Relationship Between a Report and a Template  
4:10 Template Types  
10:15 Assemblies Viewer Template  
14:20 Title Block  
19:50 Multiple Page Templates  
31:30 Questions
---
created: 2025-06-25T06:30:43 (UTC -04:00)
tags: []
source: https://gtpservices.atlassian.net/wiki/spaces/SK/pages/215220225/Tools+Admin
author: 
---

# Tools (Admin) - STRATUS Knowledge Base - Confluence

> ## Excerpt
> A Tool is a software integration where instructions can be sent directly to the tool including cutting machine or cutting software like TigerStop, PypeServer, or NovarcWelder, or printing devices like a ZPL compatible printer. Labels can be defined and printed for certain Tool types. A Tool is used in conjunction with a Station.

---
A **Tool** is a software integration where instructions can be sent directly to the tool including cutting machine or cutting software like TigerStop, PypeServer, or NovarcWelder, or printing devices like a ZPL compatible printer. Labels can be defined and printed for certain Tool types. A Tool is used in conjunction with a [**Station**](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/215220408 "https://gtpservices.atlassian.net/wiki/spaces/SK/pages/215220408").

-   1 [Videos](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/215220225/Tools+Admin#Videos)
    -   1.1 [08/19/2024 - Stratus Academy: ADM-514: Admin 3 - Tools](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/215220225/Tools+Admin#08%2F19%2F2024---Stratus-Academy%3A-ADM-514%3A-Admin-3---Tools)
-   2 [Configure a Tool](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/215220225/Tools+Admin#Configure-a-Tool)

## Videos

## 08/19/2024 - Stratus Academy: ADM-514: Admin 3 - Tools

To take the **Tools** course, login to [**Stratus Academy**](https://academy.stratus.build/ "https://academy.stratus.build/") and and locate the course **ADM-514: Admin 3 - Tools**.

## Configure a Tool

To configure a Tool under Admin > Company > Tools:

![](blob:https://gtpservices.atlassian.net/4b3efe9a-f35c-4616-8ce5-70b77b2accce#media-blob-url=true&id=ca6bbef9-e019-44d4-aa7f-01347fcd5f27&collection=contentId-215220225&contextId=215220225&mimeType=image%2Fpng&name=image2023-3-31_10-22-49.png&size=151760&width=1280&height=614&alt=)

1.  Click the **New Tool** button. A new row displays.
    
    1.  **Name (Required)** - Enter the name of the Tool that will be familiar to Stratus users.
        
    2.  **Location (Required)** \- Enter a Location that is meaningful to Stratus users.
        
    3.  **Type (Required)** - Select a Tool Type
        
        1.  **Cut List** and **Other** \- Tool type provides the ability to send a cut list directly to the GTP Stratus Workstation which includes General/Manual (Other) and TigerStop (Cut Lists) cuts. The Tracking Status in Stratus can be automatically updated after each cut is made. Note: The Cut List tool type was formerly labeled **TigerStop**. All tool type names have been converted to Cut List. See the [**Stratus Workstation**](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/201687060 "https://gtpservices.atlassian.net/wiki/spaces/SK/pages/201687060") article for more information.
            
        2.  **Other** - Select other when sending a Cut List to the General cutting app
            
        3.  **PyperServer** - A CSV export format for PypeServer cut lists.
            
        4.  **T-Drill Cutting** - A CSV export format for T-Drill cut lists. 
            
        5.  **T-Drill Collaring** - A CSV export format for T-Drill cut lists.
            
        6.  **ZPL Printer** - Print labels with a Zebra printer for non-TigerStop cut lists like PypeServer and T-Drill.
            
        7.  **Total Station** - A Total Station tool that can receive CSV points and/or DXF graphics files for hanger and other recognized points scoped out using packages.
            
        8.  **NovarcWelder** - Only works on the Assemblies Viewer page where an operator can select a weld and send it to the Novarc welder.
            
        9.  **Watts 3DPP** - Only works with Watts 3DPP software. The file extension for these output files is \*.Stratus3DPP.
            
    4.  **Enabled** - By default, the tool will be enabled. Disable the tool if you don't want it to display to Stratus users.
        
    5.  **Label Template** - Labels can be defined and printed for certain Tool types like Cut List and ZPL Printer. To define and print labels, see the [**Label Printing for Zebra (ZPL) Compatible Printers**](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/157974545 "https://gtpservices.atlassian.net/wiki/spaces/SK/pages/157974545") topic in the FAQ. After reviewing this article, if you have questions about how to configure the label fields, please submit a [**Stratus Service Desk**](https://gtpservices.atlassian.net/servicedesk/customer/portal/3 "https://gtpservices.atlassian.net/servicedesk/customer/portal/3") request.
        
    6.  **Tracking Status when Done** 
        
        1.  **RazorGauge** - For RazorGauge tools, this value can be edited and will be used by the Tool to update Stratus.
            
        2.  **Non-RazorGauge** - For tools other than RazorGauge, this column is currently **Read Only** and displays the value set in **Stratus Workstation** in the **Apply Tracking Status on Done** setting.
            
            ![](https://media-cdn.atlassian.com/file/c9c5e51a-b357-452a-a50b-6d42cab38877/image/cdn?allowAnimated=true&client=5f4a70b1-9d9d-47c3-b388-87235680bb54&collection=contentId-215220225&height=301&max-age=2592000&mode=full-fit&source=mediaCard&token=eyJhbGciOiJIUzI1NiJ9.eyJpc3MiOiI1ZjRhNzBiMS05ZDlkLTQ3YzMtYjM4OC04NzIzNTY4MGJiNTQiLCJhY2Nlc3MiOnsidXJuOmZpbGVzdG9yZTpjb2xsZWN0aW9uOmNvbnRlbnRJZC0yMTUyMjAyMjUiOlsicmVhZCJdfSwiZXhwIjoxNzUwODUwMjY3LCJuYmYiOjE3NTA4NDczODd9.-Lh4oRLJlg7Mm4YFw5HKYK-vPAWzOulfZ0y3civ9LWY&width=760)
            
    7.  **Max Cut Length (in)** - The purpose of the Max Cut Length (in) settings is to validate cut list length data before it is sent to a station. The Max Cut Length (in) can be edited when Type = Cut List. 
        
        1.  By default, the Max Cut Length (in) = 240.
            
        2.  Set **Max Cut Length (in)** as needed (Ex. 24”).
            
            ![](https://media-cdn.atlassian.com/file/e69c6826-0833-4147-bf86-55e08cf0f745/image/cdn?allowAnimated=true&client=5f4a70b1-9d9d-47c3-b388-87235680bb54&collection=contentId-215220225&height=105&max-age=2592000&mode=full-fit&source=mediaCard&token=eyJhbGciOiJIUzI1NiJ9.eyJpc3MiOiI1ZjRhNzBiMS05ZDlkLTQ3YzMtYjM4OC04NzIzNTY4MGJiNTQiLCJhY2Nlc3MiOnsidXJuOmZpbGVzdG9yZTpjb2xsZWN0aW9uOmNvbnRlbnRJZC0yMTUyMjAyMjUiOlsicmVhZCJdfSwiZXhwIjoxNzUwODUwMjY3LCJuYmYiOjE3NTA4NDczODd9.-Lh4oRLJlg7Mm4YFw5HKYK-vPAWzOulfZ0y3civ9LWY&width=859)
            
        3.  Send a cut list to the Station that exceeds the **Max Cut Length (in)** value.
            
            ![](https://media-cdn.atlassian.com/file/fa1bdb84-45d4-485f-a48f-5b00ff5ac90b/image/cdn?allowAnimated=true&client=5f4a70b1-9d9d-47c3-b388-87235680bb54&collection=contentId-215220225&height=215&max-age=2592000&mode=full-fit&source=mediaCard&token=eyJhbGciOiJIUzI1NiJ9.eyJpc3MiOiI1ZjRhNzBiMS05ZDlkLTQ3YzMtYjM4OC04NzIzNTY4MGJiNTQiLCJhY2Nlc3MiOnsidXJuOmZpbGVzdG9yZTpjb2xsZWN0aW9uOmNvbnRlbnRJZC0yMTUyMjAyMjUiOlsicmVhZCJdfSwiZXhwIjoxNzUwODUwMjY3LCJuYmYiOjE3NTA4NDczODd9.-Lh4oRLJlg7Mm4YFw5HKYK-vPAWzOulfZ0y3civ9LWY&width=760)
            
    8.  **Delete** - To Delete a tool, click the Delete button.
        
2.  Save.
---
created: 2025-06-25T06:30:43 (UTC -04:00)
tags: []
source: https://gtpservices.atlassian.net/wiki/spaces/SK/pages/10485761/Tracking+Statuses+Admin
author: 
---

# Tracking Statuses (Admin) - STRATUS Knowledge Base - Confluence

> ## Excerpt
> A Tracking Statuses is a way to categorize and control parts, assemblies, and packages. The "Can" operation checkboxes control what you can do within a Tracking Status. The "Applies To" settings control what Tracking Statuses can be applied to the Package, Assembly, Part, or Container. The Tracking Status Phases relate to Divisions and % complete calculations.

---
A Tracking Statuses is a way to categorize and control parts, assemblies, and packages. The "Can" operation checkboxes control what you can do within a Tracking Status. The "Applies To" settings control what Tracking Statuses can be applied to the Package, Assembly, Part, or Container. The Tracking Status Phases relate to Divisions and % complete calculations. 

-   1 [Stratus Academy Course Video](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/10485761/Tracking+Statuses+Admin#Stratus-Academy-Course-Video)
-   2 [Configuration](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/10485761/Tracking+Statuses+Admin#Configuration)
-   3 [Warning Tracking Status](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/10485761/Tracking+Statuses+Admin#Warning-Tracking-Status)

## Stratus Academy Course Video

To take the Task Definitions course, login to [**Stratus Academy**](https://academy.stratus.build/ "https://academy.stratus.build/") and locate the course **ADM-522: Tracking Statuses**.

## Configuration

-   **New Tracking Status** \- This button will allow you to add a new tracking status.
    
-   **Order Number "#"** - Each tracking status is associated with a number “#” column with 1 being the lowest.  Set the Tracking Status order by specifying the position number or use the Move Arrow buttons. When applied to an assembly or package, Stratus will display the status of its lowest ordered child.  **Note:** A part is a child of an Assembly or Package, while an Assembly is a child of a Package.
    
-   **Move Arrows** - If you wish to move a tracking status up or down you can do so by clicking the up and down arrows.
    
-   **Name** - This is the tracking status name that will display in Stratus.
    
-   **Can operations -** control what types of edits can be made to a part, assembly, or package.
    
    -   **Can Assemble** - When the **Can Assemble** tracking status option is checked, it means that an assembly can be edited. For example, adding a part to an assembly is an edit operation. An assembly whose tracking status is not Can Assemble will display as locked. 
        
    -   **Can Package** - When the **Can Package** tracking status option is checked, it means a package can be edited. For example, adding parts or assemblies to a package is an edit operation.  When unchecked, it means that the package is not editable. It also means that the package is ready for downstream workflows.
        
    -   **Can Number** - When the **Can Number** tracking status option is checked, it means that an assembly or package can be renumbered using the **Renumber All Item Numbers** tool in the Assemblies > Viewer or the Packages > Viewer.  When an assembly or package is NOT in a Tracking Status where **Can Number** is checked, then the message "Renumbering is not allowed for the current tracking status" will display when the **Renumber All Item Numbers** button is clicked.
        
    -   **Can BOM** - When the **Can BOM** tracking option is checked, it means that the **Package** > **BOM** > **Generate BOM** button will be enabled.
        
    -   **Can Cut List** - When the **Can Cut List** tracking option is checked, it means that the **Package** > **Cut List** > **Generate Cut List** button will be enabled.
        
-   **Applies to settings** -  The Applies to settings tells Stratus that a particular tracking status can or can't be applied to a Part, Assembly, or Package. In other words, when unchecked the tracking status will not be available in the tracking status drop-down.
    
    -   **Applies to Package** 
        
        -   When unchecked, the tracking status cannot be applied to a package.
            
        -   When checked, the tracking status of the package and parts added to the assembly will automatically change to the first Applies to Package tracking status, Packaged in this example.
            
        -   When checked, and a part is assigned to a package where the part's current tracking status is **less than** the first checked “Applies to Package” tracking status, the part's new tracking status will be changed to match the first checked “Applies to Package” tracking status. If the part's current tracking status is **greater than** the first checked “Applies to Package” tracking status, then the part's current tracking status will be retained.
            
    -   **Applies to Assembly**
        
        -   When unchecked, the tracking status cannot be applied to an assembly.
            
        -   When checked, the tracking status of the assembly and parts added to the assembly will automatically change to the first Applies to Assembly tracking status, Assembled in this example.
            
        -   When checked, and a part is assigned to an assembly where the part's current tracking status is **less than** the first checked “Applies to Assembly” tracking status, the part's new tracking status will be changed to match the first checked “Applies to Assembly” tracking status. If the part's current tracking status is **greater than** the first checked “Applies to Assembly” tracking status, then the part's current tracking status will be retained.
            
    -   **Applies to Part** - When unchecked, the tracking status cannot be applied to a part.
        
        -   **Note**: When a model is first published, all parts are assigned to the first checked Applies to Part tracking status, Modeled in this example.
            
    -   **Applies to Container**
        
        -   When unchecked, the tracking status cannot be applied to a container.
            
        -   When checked, the tracking status of parts, assemblies, and packages added to the container will automatically change to the first Applies to Container tracking status, Shipping to Jobsite in this example.
            
-   **Tracking Status Phases** \- A Tracking Status Phase (**Office**, **Purchasing**, **Shop**, **Field**) is a non-editable category used to categorize Divisions under Admin > Company Divisions and to categorize Package **Planning** and **Actual** dates when creating a new package. A tracking status can be applied to multiple phases. There are 2 options for each Tracking Status and Tracking Status Phase intersection:
    
    -   **Checked** - If the checkbox at the intersection of a Tracking Status and a Phase is checked, then the Tracking Status is applicable to the Phase. It will be set to 0% by default.
        
    -   **% Complete** - The approximate percent complete of a package for the Division (the Tracking Status Phase) when the package is in the Tracking Status. This value is used to estimate the percent complete of the Package and Assembly.
        
    -   **Actual Start Date and End Date** - If under Packages > Properties > Actual your company references the Actual section, then the phase column must include 0% that is associated with the phase Start Date and a 100% that is associated with the phase End Date.
        
        -   **0%** - When a package tracking status is changed the tracking status associated with 0%, then the date this occurs is entered as the Actual Start Date. Actual Start Date is not editable. Only the first 0% value listed for a phase will be used. All other percentages are ignored for the Actual table. See the article for more information. 
            
        -   **100%** - When a package tracking status is changed the tracking status associated with 100%, then the date this occurs is entered as the Actual End Date. Actual End Date is not editable.  Only the first 100% value listed for a phase will be used. All other percentages are ignored for the Actual table. See the article for more information. 
            
-   **Description** - You can give a more in-depth tracking status description here.
    
-   **Color** - Assign a color for filtering using Stratus viewer Display Modes
    
-   **Warning** - The **Warning** option provides users with a visual indication of when work on an item has stopped or is on hold. See **Warning Tracking Status** section on this page for more information.
    
-   **Delete** - The trash can button allows you to delete undesired tracking statuses.
    

## Warning Tracking Status

The purpose of the **Warning Tracking Status** option is to provide users with a visual indication of when work on an item has stopped or is on hold. The Warning checkbox can be checked for any tracking status and when the tracking status is applied, the colors of the page background menu bar items will change. As with all tracking status, even if the Warning checkbox is checked you the other options like Can Assemble, Can Package, Can BOM and the percent complete options still apply to the tracking status.  The “Warning’ tracking status works on the following pages:

-   Package details > Tracking
    
-   Assemblies > Viewer
    
-   Landing page when a package QR code is scanned
    
-   Landing page when an assembly QR code is scanned
    
-   Landing page when a part QR code is scanned
    

**To use the Warning Tracking Status:**

1.  Under Admin > Company > **Tracking Statuses**, create new tracking status or identify an existing tracking status.
    
2.  Check the **"Warning" option checkbox** and set the **Color** to a distinguished color (Ex. Bright Yellow) that will be the warning background color when an item displays.
    
3.  On the tracking status check the Warning checkbox. In this example, on the Package details > Items tab, when a package’s tracking status is changed to ON HOLD, the background color changed to bright yellow and the menu bar item text changed to blue due to the Warning checkbox being checked for the ON HOLD tracking status.
    
    ![](blob:https://gtpservices.atlassian.net/f6f2c9ab-a9d2-4d89-a5c8-c2979fd4ff86)
---
created: 2025-06-25T06:30:43 (UTC -04:00)
tags: []
source: https://gtpservices.atlassian.net/wiki/spaces/SK/pages/201130058/Users+Admin
author: 
---

# Users (Admin) - STRATUS Knowledge Base - Confluence

> ## Excerpt
> People in your BIM 360 Docs Member Directory can be automatically added to your Stratus Company by using the Refresh Users from BIM 360 button on the Admin > Company > Users page. Alternatively, people who are not in your BIM 360 Docs Member Directory can be individually added to your Stratus company. People added to your Stratus company are configured by default. The Stratus admin can change each user's Company Role, Group (which makes it easier to add user's to a new project), Status, Default Project Role, and their option to receive software update notifications. Once a person is added to your Stratus company, they need to be added to a Stratus Project Team in order to see the Stratus menus and a project.

---
People in your **BIM 360 Docs Member Directory** can be automatically added to your Stratus Company by using the Refresh Users from BIM 360 button on the Admin > Company > Users page. Alternatively, people who are **not in your BIM 360 Docs Member Directory** can be individually added to your Stratus company. People added to your Stratus company are configured by default. The Stratus admin can change each user's Company Role, Group (which makes it easier to add user's to a new project), Status, Default Project Role, and their option to receive software update notifications. Once a person is added to your Stratus company, they need to be [**added to a Stratus Project Team**](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/217940256 "https://gtpservices.atlassian.net/wiki/spaces/SK/pages/217940256") in order to see the Stratus menus and a project.

-   1 [Videos](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/201130058/Users+Admin#Videos)
    -   1.1 [08/19/2024 - Stratus Academy: ADM-515: Admin 3 - User Role](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/201130058/Users+Admin#08%2F19%2F2024---Stratus-Academy%3A-ADM-515%3A-Admin-3---User-Role)
-   2 [Configuration](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/201130058/Users+Admin#Configuration)
    -   2.1 [Add BIM 360 Docs Member Directory Users to the Stratus Company Users List](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/201130058/Users+Admin#Add-BIM-360-Docs-Member-Directory-Users-to-the-Stratus-Company-Users-List)
    -   2.2 [Company Users Settings](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/201130058/Users+Admin#Company-Users-Settings)
    -   2.3 [Add Individual Users to your Company](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/201130058/Users+Admin#Add-Individual-Users-to-your-Company)
    -   2.4 [Licenses](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/201130058/Users+Admin#Licenses)
    -   2.5 [Cross-Domain (Guest) Licensing](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/201130058/Users+Admin#Cross-Domain-(Guest)-Licensing)

## Videos

## 08/19/2024 - Stratus Academy: ADM-515: Admin 3 - User Role

To take the **User Roles** course, login to [**Stratus Academy**](https://academy.stratus.build/ "https://academy.stratus.build/") and and locate the course ADM-515: Admin 3 - User Role.

## Configuration

## Add BIM 360 Docs Member Directory Users to the Stratus Company Users List

A company administrator adds users to the Stratus company. Using the **Refresh Users from Autodesk Construction Cloud** button will add all **BIM 360 Docs Member Directory** users to the Stratus company users list.  Note: Newly added user(s) will be disabled. As a result, newly added users do not consume a license until their Status is manually changed from Disabled to Active.

1.  Under **Admin** > **Company** > **Users**, click the **Refresh Users from Autodesk Construction Cloud** button.
    
2.  The **A360 User Refresh** dialog will display which prompts you to enter the email domains to include for the users that will be brought into Stratus. When done, click **OK**.
    
3.  Stratus searches for all users defined for the BIM 360 Docs hub that includes the entered email domain and creates any users that don't already exist in Stratus. When the process is complete, the message that BIM 360 Users are being refreshed displays. **Note:** Newly added user(s) will be disabled. As a result, newly added users do not consume a license until their Status is manually changed from Disabled to Active.
    
4.  Click **Close** and any new Stratus company Users will be in the list of users.
    
5.  Review the user's Company User Settings (below).
    
6.  [**Add the user to one or more Stratus Project Teams**](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/217940256 "https://gtpservices.atlassian.net/wiki/spaces/SK/pages/217940256")**.**
    
7.  To login, all new uses must follow the **Stratus Authentication** instructions on the [**Login and Autodesk Sign in**](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/217907209 "https://gtpservices.atlassian.net/wiki/spaces/SK/pages/217907209") article.
    

## Company Users Settings

After a user is added to your Stratus Company, their settings can be changed. 

1.  **Company Role**
    
    1.  **Standard User** - By default, a new user's company role is set to **Standard**. A Standard User cannot access Admin > Company, where all the settings reside.
        
    2.  **Administrator** - The Administrator company role receives email messages that Standard users do not receive. The Administrator company role will receive the Stratus Subscription Expiration email notification. The email will be sent 60 days, 31 days, 14 days, 7 days, 1 day, and on the expiration date to everyone whose Company role is Administrator. The email subject will be similar to:  Stratus Alert - The Stratus subscription for COMPANY A will expire on MM/DD/YY. The email message will be similar to: “The Stratus monitoring system detected that your company's Stratus subscription will expire on MM/DD/YY. Contact Sales at [sales@gogtp.com](mailto:sales@gogtp.com "mailto:sales@gogtp.com") concerning renewal options.”
        
2.  **Group** - A user can be added to a group, which makes it easier to add users to a new project. To use the **Group** feature:
    
    1.  Click the **Group link** associated with the user. The Specify Group dialog will display.
        
    2.  Select an existing group or enter a new group.
        
    3.  To save the group, you must **click the group name** and then **click the save checkbox**.
        
    4.  Then, under **Admin** \> **Project** \> **Teams**, select the Group and Role that the group will have on the selected Team. Any users in the group that have not already been added to the team will be added. See the [**Team (Admin)**](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/217940256 "https://gtpservices.atlassian.net/wiki/spaces/SK/pages/217940256") article for more information.
        
3.  **Status** - A user's status can be:
    
    1.  By default, the Status filter is set to Active users.
        
    2.  **Active** - Active users consume one Stratus license and can access any project under Admin > Project > Teams where the user has been added as a Team Member.
        
    3.  **Disabled** - A Disabled user can no longer access Stratus for the company that disabled the user. The user can still access other companies that have given the user access to Stratus. Stratus retains the disabled user’s records so that their name can be displayed in places where they made changes like tracking status. A Disabled user does not consume a Stratus license.  
        
        1.  **Note**: You are not able to switch out licenses by editing users, as this would eliminate existing audit trails and history of that user. Instead, an unused account can be Disabled which will increase your license count by 1. You can then create a new user with the appropriate name and email, and this will consume a license.
            
4.  **Default Project Role** - The Default Project Role is the way to automatically assign a project role to a user when new projects are added to Stratus from BIM 360 using the **Refresh Users from BIM 360** button. To Add a Default Project Role under Admin > Users:
    
    1.  By default, the Default Project Role for the user’s whose Company Role is:
        
        1.  **Admin** will be Project Admin.
            
        2.  **Other non-Admin roles** will be set to None.
            
            ![](blob:https://gtpservices.atlassian.net/694856a1-c26e-4a68-93f9-12ed11f40c25)
            
    2.  To assign a different Default Project Role to a user, click the drop-down. A list of Projects Roles will display. See the [**Project Roles (Admin)**](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/11534527 "https://gtpservices.atlassian.net/wiki/spaces/SK/pages/11534527") article for more information. When assigned, the user will take on this role automatically when new projects are added to Stratus from BIM 360.
        
    3.  After a change to a user's Default Project Role, the following prompt will display asking if the user should be assigned the new project role to all currently active projects.  
        
        ![](blob:https://gtpservices.atlassian.net/d35b7cd1-ff9d-4a0c-92ab-54199935f9ca)
        
        1.  **Yes** \- If Yes, the user will be added to existing active projects with the specified role only if they did not already have a role on the project. In this case, the user’s existing role specified on the project will remain.
            
            1.  A message similar to the following will display.  
                
                ![](blob:https://gtpservices.atlassian.net/268fe502-0119-4a32-a005-e86a9fc89c9e)
                
            2.  Under Admin > Project, the user will be assigned to the Default Project Role if the project is newly imported from BIM360 or if the user did not have a role defined for the project.
                
                ![](blob:https://gtpservices.atlassian.net/ce30abc2-6ef6-40bb-8a21-a0c474fa28d9)
                
        2.  **No** \- If no the user’s Role will not change on any project under Admin > Project, but will be set for newly imported from BIM360 projects.
            
5.  **Add to New Projects** \- Used to control which users are added to new projects.
    
6.  **Can Book Training** - Can Book Training indicates users who can schedule training with the GTP Customer Success team. By default, **Can Book Training** will be checked for anyone whose Company Role is Administrator.
    
    1.  **Checked** - When checked, the SCHEDULE TRAINING button will display for the user and the user can schedule training with the GTP Customer Success team.  
        
        ![](blob:https://gtpservices.atlassian.net/02c6d3c3-2493-4c33-9799-998581e5ea74)
        
    2.  **Unchecked** - When unchecked, the SCHEDULE TRAINING button will not display for the user, and a message to contact the Stratus company administrator will display.
        
7.  **Notify on Software Update** - A company administrator can specify who should receive software updates and announcements by clicking the **Notify on Software Update** checkbox associated with each user.
    
8.  **User’s Name and Email** 
    
    1.  Click the **Update the user email, first name, and last name** button.
        
    2.  The **Update a User** dialog will display. Edit the user as needed and **Save**.
        

## Add Individual Users to your Company

Alternatively, to add an individual user either from your BIM 360 Docs Member Directory or someone outside of your BIM 360 Docs Member Directory, use the New User option.

To Add Individual Users to your Company:

1.  Click the **\+ New User** button. The Assign New User Role dialog will display.
    
    1.  **First Name (Required)** - This will be the user's display name (First Name).
        
    2.  **Last Name (Required)** - This will be the user's display name (Last Name).
        
    3.  **Email (Required)** - The user's email. This email will be used to sign in to Stratus.
        
    4.  **Company Role** - Set the user's company role.
        
        1.  **Standard User (Default)** - By default, a new user's company role is set to **Standard**. A Standard User cannot access Admin > Company, where all the settings reside.
            
        2.  **Administrator** - The Administrator company role receives email messages that Standard users do not receive. The Administrator company role will receive the Stratus Subscription Expiration email notification. The email will be sent 60 days, 31 days, 14 days, 7 days, 1 day, and on the expiration date to everyone whose Company role is Administrator. The email subject will be similar to:  Stratus Alert - The Stratus subscription for COMPANY A will expire on MM/DD/YY. The email message will be similar to: “The Stratus monitoring system detected that your company's Stratus subscription will expire on MM/DD/YY. Contact Sales at [sales@gogtp.com](mailto:sales@gogtp.com "mailto:sales@gogtp.com") concerning renewal options.”
            
        3.  **Other** - All Company Roles created by the company Administrator under Admin > Company > Company Roles will display in the drop-down.
            
    5.  **Group** \- A user can be added to a group, which makes it easier to add users to a new project. To use the **Group** feature:
        
        1.  Click the **Group link** associated with the user. The Group drop-down will display. This is a list of all default and Custom groups previously added.
            
        2.  Select an existing group or click **Custom** to add a new group.
            
            1.  **Custom** \- To name the **Custom** group finish adding data to the remaining fields and then click the **Next** button. The user will display in the Users data table and the Group will be Custom.
                
            2.  Click the **Custom** text. The Group dialog will display.
                
            3.  Click the drop-down. The Custom link will display.
                
            4.  Click the **Custom blue link**. The word Custom will be highlighted in a text box.
                
            5.  Enter the name of the new group (Ex. Field) and then click the **Save** button.
                
            6.  The new group name will display in the Group dialog drop-down. Click the **Save** button again.
                
            7.  The new field name will display for the user.
                
            8.  Click the **web browser page refresh button** to make the new group available in the Group drop-down for other users moving forward.
                
                ![](blob:https://gtpservices.atlassian.net/95074b25-2c0e-4ca5-b6f0-d3db1bfd6fb9)
                
    6.  **Status** \- A user's status can be:
        
        1.  **Active (Default)** - Active users consume one of your Stratus licenses and can access any project under Admin > Project > Teams where the user has been added as a Team Member.
            
        2.  **Disabled** - A **Disabled** user can no longer access Stratus for the company. The user can still access other companies that have given the user access to Stratus. Stratus retains the disabled user’s records so that their name can be displayed in places where they made changes like tracking status. A Disabled user does not consume a Stratus license.  
            
            1.  **Note**: You are not able to switch out licenses by editing users, as this would eliminate existing audit trails and history of that user. Instead, an unused account can be Disabled which will increase your license count by 1. You can then create a new user with the appropriate name and email, and this will consume a license.
                
    7.  **Default Project Role** \- The **Default Project Role** is the way to automatically assign a project role to a user when new projects are added to Stratus from BIM 360 using the **Refresh Users from BIM 360** button. By default, the Default Project Role is **None**. New Project Roles can be created by an Administrator under Admin > Company > Project Roles. Out-of-the-box Project Roles include the following:
        
    8.  **Add to New Projects** - Used to control which users are added to new projects. By default, the checkbox is unchecked.
        
    9.  **Can Book Training** - **Can Book Training** indicates users who can schedule training with the GTP Customer Success team. By default, **Can Book Training** will be checked for anyone whose Company Role is Administrator.
        
        1.  **Checked** - When checked, the SCHEDULE TRAINING button will display for the user and the user can schedule training with the GTP Customer Success team.
            
        2.  **Unchecked** - When unchecked, the SCHEDULE TRAINING button will not display for the user, and a message to contact the Stratus company administrator will display.
            
    10.  **Notify on Update** - A company administrator can specify who should receive software updates and announcements by clicking the **Notify on Software Update** checkbox associated with each user. By default, the checkbox is unchecked.
        
    11.  **Expiration Date (not editable)** - The **Expiration Date** is set bas
        
2.  Click **Next**. The **Assign New User Role** dialog will display.
    
    1.  Locate or search for the project(s) to add the user to
        
    2.  **Project** - Check the checkbox for each project.
        
    3.  **Role** - Select the user’s Role which are defined under Admin > Company > Project Roles and click the **Save** button in the drop-down.
        
3.  Click the Save button or click the Back button to make additional edits. Edits, except for name and email, can also be made once the new user has been saved.
    
4.  The page will refresh and the new user will display.
    

## Licenses

You are not able to switch out licenses by editing users, as this would eliminate existing audit trails and history of that user. Instead, an unused account can be Archived which will increase your license count by 1. You can then create a new user with the appropriate name and email, and this will consume a license.

## Cross-Domain (Guest) Licensing

Some Stratus customers do business with other Stratus customers. The current problem is that each unique user that is added to a company consumes a license. The cross-domain (guest) license solution enables company A to have a fully provisioned user, which can subsequently be added to company B without consuming a license from company B. There are no Project Role permission restrictions for guest users.

1.  A user is added to company A and consumes a Full license.
    
2.  To use a guest license at company B, the user is added by company B using the **New User** button under Admin > Company > Users using the user’s company A email address. A Guest license is consumed.
    
3.  The company B Admin will set the guest user’s Company Role and Project Role.
    
4.  If the company A Administrator attempts to change a Full licensed user’s Status to Disabled who is also a “guest” at company B, a warning message similar to the following will display:
    
    1.  **Keep User** - Click **Keep User** to retain the the user at company A and consume a Full license.
        
    2.  **Disable User in All Companies** - Click **Disable User in All Companies** to disable the user from company A as well as any company where that user is a Guest. The user’s Full license will be recouped by company A. The guest user will no longer have access to Stratus at company B. If the user needs to use Stratus at company B, company B will have to add the user with the user’s company B email address and consume a Full license.
        
5.  Company A can change the Status of a user’s Full license to Disabled and this user might be a Guest of company B.
    
    1.  As a result of company A disabling the Full license of the Guest, the Guest’s license is disabled in company B.
        
    2.  If the company B Administrator attempts to change a Guest’s Status from Disabled to Active, the following message will display.
---
created: 2025-06-25T06:30:43 (UTC -04:00)
tags: []
source: https://gtpservices.atlassian.net/wiki/spaces/SK/pages/217711025/View+Styles+Admin
author: 
---

# View Styles (Admin) - STRATUS Knowledge Base - Confluence

> ## Excerpt
> The  View Styles settings enable administrators to define styles that are targeted to Isometric, Front, and Top views that display on reports. A style can include settings to render dimensions or not, to include item numbers or not, to limit the view style to a Part Filter, the thickness of a dimension line, arrowhead style and color, and item number bubble background. Once defined, a style is applied to the Template which is used to generate reports like a Spool Sheet report.

---
The  View Styles settings enable administrators to define styles that are targeted to Isometric, Front, and Top views that display on reports. A style can include settings to render dimensions or not, to include item numbers or not, to limit the view style to a Part Filter, the thickness of a dimension line, arrowhead style and color, and item number bubble background. Once defined, a style is applied to the Template which is used to generate reports like a Spool Sheet report.

-   1 [Videos](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/217711025/View+Styles+Admin#Videos)
    -   1.1 [08/19/2024 - Stratus Academy: ADM-509: Admin 2 - View Styles](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/217711025/View+Styles+Admin#08%2F19%2F2024---Stratus-Academy%3A-ADM-509%3A-Admin-2---View-Styles)
    -   1.2 [03/18/2021 CSG Webinar: View Styles For PDF Templates](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/217711025/View+Styles+Admin#03%2F18%2F2021-CSG-Webinar%3A-View-Styles-For-PDF-Templates)
    -   1.3 [03/11/2021 CSG Webinar: Setting Up PDF Templates](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/217711025/View+Styles+Admin#03%2F11%2F2021-CSG-Webinar%3A-Setting-Up-PDF-Templates)
-   2 [Define a View Style](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/217711025/View+Styles+Admin#Define-a-View-Style)
-   3 [Apply a View Style to a Template](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/217711025/View+Styles+Admin#Apply-a-View-Style-to-a-Template)
-   4 [View the Style on a Report](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/217711025/View+Styles+Admin#View-the-Style-on-a-Report)
-   5 [Style Element Definitions](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/217711025/View+Styles+Admin#Style-Element-Definitions)
-   6 [Examples](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/217711025/View+Styles+Admin#Examples)
    -   6.1 [Vic Coupling - Part Visibility Filter and Tag Visibility Filter](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/217711025/View+Styles+Admin#Vic-Coupling---Part-Visibility-Filter-and-Tag-Visibility-Filter)

## Videos

## 08/19/2024 - Stratus Academy: ADM-509: Admin 2 - View Styles

To take the View Styles course, login to [**Stratus Academy**](https://academy.stratus.build/ "https://academy.stratus.build/") and and locate the course **ADM-509: Admin 2 - View Styles**.

## 03/18/2021 CSG Webinar: View Styles For PDF Templates

<iframe allowfullscreen="" allowtransparency="true" data-hasbody="false" data-layout="default" data-local-id="d582e4d7-b543-45d9-a295-1f3c1228333f" data-macro-id="72b0ab50-f902-4424-8169-7e18366ec9ef" data-macro-name="widget" frameborder="0" height="364" mozallowfullscreen="" webkitallowfullscreen="" width="640" src="https://player.vimeo.com/video/527935047?h=embed"></iframe>

00:00 Release Notes Review  
03:15 View Styles Linked to Templates  
04:30 View Styles Configuration  
05:30 Render, Appearance, Visibility Examples  
12:00 Part, Dimension, Tag Visibility Examples  
18:00 Line Weights, Fonts, Arrowheads  
25:25 Item Number - Leaders, Arrowheads, Background Bubble Color

## 03/11/2021 CSG Webinar: Setting Up PDF Templates

<iframe allowfullscreen="" allowtransparency="true" data-hasbody="false" data-layout="default" data-local-id="94ddc1d6-7dff-4c2e-b35e-e8246ab06081" data-macro-id="a74891ab-230b-4c84-8d68-2ace04e33c4b" data-macro-name="widget" frameborder="0" height="364" mozallowfullscreen="" webkitallowfullscreen="" width="640" src="https://player.vimeo.com/video/522992170?h=embed"></iframe>

00:00 Introduction  
02:20 Relationship Between a Report and a Template  
4:10 Template Types  
10:15 Assemblies Viewer Template  
14:20 Title Block  
19:50 Multiple Page Templates  
31:30 Questions

## Define a View Style

This section describes how to define a new view style. See the Style Element Definitions section below for examples of each style element.

1.  To define a View Style, under **Admin** > **Company** > **View Styles**, click the **+New View Style** button.
    
2.  Make whatever changes you would like. See the Style Element Definitions section below for examples of each style element.
    
3.  Scroll to the far right and click the green checkmark to save your changes or the red “x” to discard the new styles.
    

## Apply a View Style to a Template

1.  To apply a View Style to a Template, go to **Admin > Company > Templates**. See the [**Top View, Front View, Isometric View**](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/1558249473/Templates+Admin#Top-View,-Front-View,-Isometric-View "https://gtpservices.atlassian.net/wiki/spaces/SK/pages/1558249473/Templates+Admin#Top-View,-Front-View,-Isometric-View") section in the [**Templates (Admin)**](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/157974589/Templates+Admin "https://gtpservices.atlassian.net/wiki/spaces/SK/pages/157974589/Templates+Admin") article for more information.
    

## View the Style on a Report

**To view the style on a report:**

1.  Make sure your **Template** is associated with a Report like a Spool Sheet report on the **Admin > Company > Reports** page. The report below is targeted as an option on the Assembly Viewer page.
    
2.  Under **Assemblies > Viewer**, open an assembly that would use the above report.
    
3.  Before running the report, set the dimensions or numbering in the viewer as needed. You can modify the orientation later too.
    
4.  Click the Stratus Sheet tab. Your style changes will be visible in the report. See the Style Element Definitions section below for examples of each style element
    

## Style Element Definitions

1.  **Render Dimensions** 
    
    1.  When Render Dimensions is checked the report displays the dimensions and dimension lines. When unchecked the report does not display dimensions or dimension lines.
        
    2.  Render Dimensions checked
        
    3.  Render Dimensions unchecked
        
2.  **Display Decimal Inch**
    
    1.  When checked, the report view associated with the View Style will report decimal inch dimension values instead of fractional inch values.
        
3.  **Render Item Numbers** 
    
    1.  Render Item Numbers determines whether item numbers will be displayed.
        
    2.  Render Item Numbers checked
        
    3.  Render Item Numbers unchecked
        
4.  **Part Appearance** 
    
    1.  The Part Appearance option allows administrators to determine how parts will display including Hidden Line, Color, Realistic, and Shaded. Note: When publishing from CAD, Fabrication parts will display faces. When publishing from Revit, Fabrication parts will not display faces.
        
5.  **Display Mode**
    
    1.  The Display Mode setting can be applied to assembly and package detail reports. The Display Mode setting lists the Display Mode tools' tabs. 
        
        ![](blob:https://gtpservices.atlassian.net/e4323187-ebe6-49c0-b5ee-53702e9df571)
        
    2.  The selected item will apply the Display Mode to the Stratus Sheet. In this example, Assemblies were selected. As a result, each assembly in the Stratus Sheet is the same color as the assembly in the Display Modes > Assemblies tab.
        
        ![](blob:https://gtpservices.atlassian.net/1556f64c-bd91-410e-8f1d-1f3e2b10a380)
        
6.  **Hidden Parts Shaded**
    
    1.  When **Hidden Parts Shaded** is selected, hidden elements (Ex. parts and backgrounds) surrounding the visible elements (Ex. package or assembly or filtered parts) will display. In the example below, the Package is coloring Assemblies like in Display Mode and is showing Hidden Parts Shaded.  
        
        ![](blob:https://gtpservices.atlassian.net/00b500d4-b6d6-4bc4-aa85-8fbc2507e416)
        
7.  **Show Backgrounds**
    
    1.  The **Show Backgrounds** checkbox controls the visibility of non-visible background elements in the report, allowing users to see the shading of Backgrounds.
        
8.  **Part Visibility Filter**
    
    1.  The Part Visibility Filter filters out parts that meet the filter criteria. See the Vic Coupling example on this page.
        
9.  **Dimension Visibility Filter**
    
    1.  The Dimension Visibility Filter leaves the part viewable on the sheet but filters out the dimensions attached to the part.
        
10.  **Tag Visibility Filter**
    
    1.  The Tag Visibility Filter leaves the part viewable on the sheet but filters out the part number associated with the part. See the Vic Coupling example on this page.
        
11.  **Part Filter** 
    
    1.  The Filter option allows administrators to configure views that isolate certain types of components within an assembly or package.  If a filter is applied to a view, any parts that don’t pass the filter, as well as their associated dimensions will be hidden. If a dimension extends from one element to another, and one of the elements is not visible, the dimension will also not be visible. For example, a view can be configured using a Part Filter where item numbers would only display for weld objects.  Configure Filters under Admin > Company > Parts.  Set the Filter as part of a View Style under Admin > Company > View Styles.
        
12.  **Ext. Line Color** 
    
    1.  Ext. Line Color determines the color of extension lines.
        
    
13.  **Dim. Line Color**
    
    1.  Dim. Line Color determines the color of dimension lines
        
    
14.  **Ext. Line Thickness**
    
    1.  Ext. Line Thickness determines the thickness of extension lines.
        
    
15.  **Dim. Line Thickness**
    
    1.  Dim. Line Thickness determines the thickness of dimension lines.
        
    
16.  **Additional Ext. Ln. Length (Px.)** 
    
    1.  Additional Ext. Ln. Length (Px.) determines the additional length (in pixels) inserted at the ends of extension lines.
        
    
17.  **Additional Dim. Ln. Length (Px.)**
    
    1.  Additional Dim. Ln. Length (Px.) determines the additional length (in pixels) inserted at the ends of dimension lines.
        
    
18.  **Label Font** 
    
    1.  Label Font determines the font used to display the labels.
        
    
19.  **Lbl. Font Size (Pt.)**
    
    1.  Lbl. Font Size (Pt.) determines the size of the label font.
        
    
20.  **Lbl. Font Color**
    
    1.  Lbl. Font Color determines the color of the label font.
        
    
21.  **Dimension Arrowhead**
    
    1.  Dimension Arrowhead is used to select whether the arrowhead will be a Tick, Filled or None.
        
    
22.  **Dimension Arrowhead Color**
    
    1.  Dimension Arrowhead Color determines the color of the Dimension arrowhead.
        
    
23.  **Dimension Arrowhead Size**
    
    1.  Dimension Arrowhead Size determines the size of the arrowhead for the dimensions.
        
    
24.  **Dimension Tick Arrowhead Thickness**
    
    1.  Dimension Tick Arrowhead Thickness determines the thickness of the Tick lines for dimensions. This has no effect if Dimension Arrowhead is set to “Filled”, “Open” or “None”.
        
    
25.  **Item Number Arrowhead**
    
    1.  Item Number Arrowhead determines whether there is an arrowhead on the leader for an item number.
        
    
26.  **Item Number Arrowhead Color**
    
    1.  Item Number Arrowhead Color determines the color of the item number arrowhead.
        
    
27.  **Item Number Arrowhead Size**
    
    1.  Item Number Arrowhead Size determines the size of the arrowhead.
        
    
28.  **Item Number Leader Thickness**
    
    1.  Item Number Leader Thickness determines the item number leader thickness.
        
    
29.  **Item Number Leader Color**
    
    1.  Item Number Leader Color determines the item number leader color.
        
    
30.  **Item Number Bubble Background Color**
    
    1.  Item Number Bubble Background Color determines the background color of the “bubble” in which an item number appears.
        
    
    4.  Transparency Option:
        
        1.  Click the color picker drop-down. A palette of colors can be selected. Note the **rgba** configuration for the selected color. The “a” value is used to indicate the transparency where 1 is 0% transparency and 0 is 100% transparency. Decimals between 0 and 1 (0.1, 0.25, 0.50, 0.75, etc.) can be used to set the transparency percent.   
            
            ![](blob:https://gtpservices.atlassian.net/c360aa88-115d-4027-98bc-45fa3c62759f)
            
        2.  In this example, the “a” value has been set to 0.25. Note how the color to the right of the rgba value changes.  
            
            ![](blob:https://gtpservices.atlassian.net/f8459efe-e2bd-401a-a0d0-8fa0db59982c)
            
        3.  When applied to an Stratus Sheet in the Assemblies > Viewer, the transparency displays for the Item Number Bubble Color. With this transparency value set to 0.25, you can see that the other lines can be seen through the bubble color.  
            
            ![](blob:https://gtpservices.atlassian.net/35f87cf3-605c-4fc7-b22e-098addf80b4b)
            
31.  **Item Number Bubble Border Color**
    
    1.  Item Number Bubble Border Color determines the color of the border of the “bubble” in which an item number appears.
        
    
32.  **Item Number Font**
    
    1.  Item Number Font determines the font used for the item number.
        
    
33.  **Item Number Font Size (Pt.)**
    
    1.  Item Number Font Size (Pt.) determines the size of the item number font.
        
    
34.  **Item Number Font Color** 
    
    1.  Item Number Font Color determines the color of the Item Number.
        
    

## Examples

## Vic Coupling - Part Visibility Filter and Tag Visibility Filter

One use case is for those who want to display Vic Couplings in the Assembly Viewer, but don’t want them to be tagged with an item number on your sheets is to use the Part Visibility Filter and Tag Visibility Filter. Here are the steps:

1.  **Filter -** Create a **Vic Coupling** filter where the Property = Source and the Rule = DoesNotContain.
    
2.  **View Style** - Setup a View Style as follows for this example.
    
3.  **Template** - Setup a Template that includes two Iso views 1) where the View style is E – Dimensions Only and 2) where the View Style is D – Numbers Only.
    
4.  **Report** - Setup a Report (or use an existing report) where the above Template is selected in the Template column.
    
5.  In the Assemblies Viewer, tag and dimension a spool and then run the Stratus Sheet with the above Report selected. A Stratus sheet similar to the following will display.
    
    **Notice the following in the above screenshot:**
    
    1.  In the top Iso where the Part Visibility Filter = Vic Couplings, couplings do not display. With Render Dimensions checked the dimensions display.
        
    2.  In the bottom Iso where the Tag Visibility Filter = Vic Couplings, the couplings display and are numbered. None of the other pipe or fittings are numbered.
