---
created: 2025-06-25T10:50:40 (UTC -04:00)
tags: []
source: https://gtpservices.atlassian.net/wiki/spaces/SK/pages/201130058/Users+Admin
author: 
---

# Project Admin - STRATUS Knowledge Base - Confluence

> ## Excerpt
> User Access to Admin > Projects:

---
**User Access to Admin > Projects:**

A user has access if they meet **one** of the following conditions:

1.  They have the **Project Administrator** Project Role applied to themselves.
    
2.  They have the **Administrator** Company Role.
    
3.  They have a Company Role that grants **Company > Admin > Users** access.
    

![image-20250221-185031.png](blob:https://gtpservices.atlassian.net/1cabcbf8-709f-4264-b812-2f3cbd36c61d#media-blob-url=true&id=9360aef8-09ee-47df-b1f2-c10723ffb815&collection=contentId-3146088&contextId=3146088&width=1340&height=231&alt=image-20250221-185031.png)

Other project level settings can be individually permissioned by Project Role. See the [**Project Roles (Admin)**](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/11534527 "https://gtpservices.atlassian.net/wiki/spaces/SK/pages/11534527") article for more information.

![](blob:https://gtpservices.atlassian.net/aace6569-df9b-44d6-8929-86acfc1e6610#media-blob-url=true&id=46aaa809-c444-4a0e-8ef5-22effb166531&collection=contentId-3146088&contextId=3146088&width=610&height=375&alt=)
---
created: 2025-06-25T10:50:40 (UTC -04:00)
tags: []
source: https://gtpservices.atlassian.net/wiki/spaces/SK/pages/2038333441/Project+Divisions+Admin
author: 
---

# Project Divisions (Admin) - STRATUS Knowledge Base - Confluence

> ## Excerpt
> Project Divisions are associated with a specific project and will display along with Company Divisions if the project is referenced. See the Divisions (Admin) article for information about Company-level Divisions.

---
**Project Divisions** are associated with a specific project and will display along with Company Divisions if the project is referenced. See the [**Divisions (Admin)**](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/103317524/Divisions+Admin) article for information about Company-level Divisions.  

The Project-level Division will be included in the following pages:

-   Packages > Dashboard
    
-   Assemblies > Dashboard
    
-   Containers > Assign > Tracking
    
-   Scan

Project-level Divisions are not supported in: Tasks, Stations, Shops, and Jobsites.

-   1[Configure](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/2038333441/Project+Divisions+Admin#ProjectDivisions(Admin)-Configure)

## Configure

To configure and use a Project-level Division:

1.  Go to Admin > Project > Divisions, click the new division plus icon, enter the Division name (Ex. Project 38553 Division) and save. The new Project-level Division will display and the only Phase option is Field.
    
    ![](https://gtpservices.atlassian.net/wiki/download/attachments/2038333441/image2023-2-6_12-15-5.png?version=1&modificationDate=1675707307232&cacheVersion=1&api=v2)
    
    1.  **Division (Required)** - The name of the Project-level Division.
        
    2.  **Address (Optional)** - The Country, Address, City, State, and Zip are used to define the address of the Project-level Division.
        
    3.  **Phase** - By default, STRATUS includes Divisions aligned to four project phases, Office, Purchasing, Shop, or Field. A Project-level Division can only be set to Field.
        
    4.  **Field Orderz Division** - Not currently used in STRATUS.
        
    5.  **Notes** - Add notes to better understand the purpose of the Division.
        
2.  Once Saved, the Project-level Division will display if the associated project is selected. Below are some examples:
    
    1.  **Containers**
        
        1.  Project-level Divisions can be used on pages like Containers (Assign), Scan, and Packages. **Note:** Before the Project-level Division (Ex. Project 38553 Division) will display in the Division drop-down, a Status has to be set and a part, assembly, or package (Ex. 38553-DIM-0002) from the project must have been added to the Contents of the Container (Ex. Pallet 03).
            
            ![](https://gtpservices.atlassian.net/wiki/download/attachments/2038333441/image2023-2-6_12-13-29.png?version=1&modificationDate=1675707211089&cacheVersion=1&api=v2)
            
    2.  **Scan**
        
        1.  After an item has been scanned, it’s Project-level Division can be selected.
            
            ![](https://gtpservices.atlassian.net/wiki/download/attachments/2038333441/image2023-2-6_12-14-27.png?version=1&modificationDate=1675707268374&cacheVersion=1&api=v2)
---
created: 2025-06-25T10:50:40 (UTC -04:00)
tags: []
source: https://gtpservices.atlassian.net/wiki/spaces/SK/pages/217907482/Settings+Project
author: 
---

# Settings (Project) - STRATUS Knowledge Base - Confluence

> ## Excerpt
> The Project Settings page, only available to Project Admin project role, provides options to override company settings for Assembly Conflict Resolution, Point Export Units, and Lead Days.  In addition, for Revit models that have a shared coordinate transformation, users have the option to export the CSV and DXF for the Total Station tool using either Shared or Model (Project Internal) coordinates on a per-project basis.

---
The Project Settings page, only available to **Project Admin** project role, provides options to override company settings for **Assembly Conflict Resolution,** **Point Export Units, and Lead Days.**  In addition, for Revit models that have a shared coordinate transformation, users have the option to export the CSV and DXF for the Total Station tool using either Shared or Model (Project Internal) coordinates on a per-project basis.

-   1[Assembly Conflict Resolution](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/217907482/Settings+Project#Settings(Project)-AssemblyConflictResolution)
-   2[Point Export Units](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/217907482/Settings+Project#Settings(Project)-PointExportUnits)
-   3[Use Parameter Mapping for Assembly Import and Publish](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/217907482/Settings+Project#Settings(Project)-UseParameterMappingforAssemblyImportandPublish)
-   4[Coordinate System](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/217907482/Settings+Project#Settings(Project)-CoordinateSystem)
-   5[Item Numbering](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/217907482/Settings+Project#Settings(Project)-ItemNumbering)
-   6[MAJ Files Include Dynamic Holes](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/217907482/Settings+Project#Settings(Project)-MAJFilesIncludeDynamicHoles)
-   7[Task Definitions and Task Workflows](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/217907482/Settings+Project#Settings(Project)-TaskDefinitionsandTaskWorkflows)
-   8[Duration Days Project Level Configuration](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/217907482/Settings+Project#Settings(Project)-DurationDaysProjectLevelConfiguration)
    -   8.1[Example: Project level Settings](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/217907482/Settings+Project#Settings(Project)-Example%3AProjectlevelSettings)

## Assembly Conflict Resolution

**[Company](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/10518994/Settings+Admin)** Assembly Conflict Resolution settings can be overridden on a per-project basis for either AutoCAD or Revit models. Once the **Override Company Option for this Project** checkbox is checked, set how the assembly conflict should be resolved and **Save**.

-   STRATUS is always right
-   Revit is always right
-   Prompt User

![](https://gtpservices.atlassian.net/wiki/download/thumbnails/217907482/image2019-7-1_10-59-29.png?version=1&modificationDate=1561996771138&cacheVersion=1&api=v2&width=642&height=296)

## Point Export Units

**[Company](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/10518994/Settings+Admin)** Point Export Units settings can be overriden on a per project basis for ether AutoCAD or Revit models. Once the **Override Company Option for this Project** checkbox is checked, set the Point Export Units (Feet, Inches, Meters, Millimeters) and **Save**. See the [**Package Point List**](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/166821968/Package+Point+List) article for more information. 

![](https://gtpservices.atlassian.net/wiki/download/thumbnails/217907482/image2019-7-1_11-3-5.png?version=1&modificationDate=1561996986757&cacheVersion=1&api=v2&width=627&height=250)

## Use Parameter Mapping for Assembly Import and Publish

When the **Override Company Option** is checked for the selected Project, the Project Parameter specified (left) will be used rather than the Project Parameter specified under Admin > Company > Settings (right).

 ![](https://gtpservices.atlassian.net/wiki/download/thumbnails/217907482/image2020-7-29_9-58-29.png?version=1&modificationDate=1596034710331&cacheVersion=1&api=v2&width=400&height=458)![](https://gtpservices.atlassian.net/wiki/download/thumbnails/217907482/image2020-7-29_9-58-11.png?version=1&modificationDate=1596034693436&cacheVersion=1&api=v2&width=400&height=329)

## Coordinate System

For Revit models that have a shared coordinate transformation, users have the option to export the CSV and DXF for the Total Station tool using either Shared or Model (Project Internal) coordinates on a per-project basis.

To set the Coordinate System:

1.  Under **Admin** > **Project** > **Settings**, select the **Coordinate System** and **Save**.  
    ![](https://gtpservices.atlassian.net/wiki/download/thumbnails/217907482/image2021-8-9_10-38-11.png?version=1&modificationDate=1628523492563&cacheVersion=1&api=v2&width=324&height=250)
2.  To export the CSV and DXF files for a point list, see the **[Package Point List](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/166821968/Package+Point+List)** article in the Knowledge Base.

## Item Numbering

Set the Item Numbering Scheme to be used by the selected project. See the **[Numbering Schemes](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/164134913/Naming+and+Numbering+Admin#Numbering-Schemes)** article for more information.

![](https://gtpservices.atlassian.net/wiki/download/attachments/217907482/image2024-4-3_14-6-43.png?version=1&modificationDate=1712171205275&cacheVersion=1&api=v2)

## MAJ Files Include Dynamic Holes

As per Autodesk, “The "**MAJ Files Include Dynamic Holes**" setting allows holes to be intelligently cut into rectangular straight developments when positioning taps\\shoes, or any object, to the face of straight duct (CID 866). This eliminates the need to manually edit developments in CAMduct.”

![](https://gtpservices.atlassian.net/wiki/download/thumbnails/217907482/image2022-1-27_11-19-16.png?version=1&modificationDate=1643303957467&cacheVersion=1&api=v2&width=400&height=117)

-   **Checked (Default)** \- Currently, STRATUS includes dynamic hole data when the model is published.
    
    ![](https://gtpservices.atlassian.net/wiki/download/thumbnails/217907482/image2022-1-27_11-20-3.png?version=1&modificationDate=1643304004737&cacheVersion=1&api=v2&width=400&height=325)
    
-   **Unhecked** - Disable dynamic hole data on next publish.
    
    ![](https://gtpservices.atlassian.net/wiki/download/thumbnails/217907482/image2022-1-27_11-20-40.png?version=1&modificationDate=1643304041939&cacheVersion=1&api=v2&width=400&height=332)
    

## Task Definitions and Task Workflows

**[Company-level Task Definitions and Task Workflows](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/10518994/Settings+Admin)** can be overridden at the Project-level. Activating Task Definitions at the Project-level is recommended for testing your definitions.

See the [**Task Definitions**](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/217711302/Task+Definitions+Admin) (recommended) article for more information.

See the [**Task Workflows**](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/240713729/Task+Workflows+Admin) (not recommended) article for more information.

![](https://gtpservices.atlassian.net/wiki/download/attachments/217907482/image2023-1-13_13-25-52.png?version=1&modificationDate=1673637953608&cacheVersion=1&api=v2)

## Duration Days Project Level Configuration

The Project level Package Category Duration Days feature offers calculated initial Start Dates for package phases that override **[Duration Days Company Level Configuration](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/166199351/Package+Categories+Admin#PackageCategories(Admin)-DurationDays)**. Initial Start Dates can be edited at the package level.  
![](https://gtpservices.atlassian.net/wiki/download/attachments/217907482/image2023-6-23_11-23-40.png?version=1&modificationDate=1687537421918&cacheVersion=1&api=v2)

To configure Duration Days for a package category:

1.  **Override Company Options For This Project -** To enable the project override dialog, check **Override Company Options For This Project** option. When checked, this Project option will override Company settings made under **Admin > Company** \> **Package Categories**.
    
2.  At the Project level under Admin > Projects > Settings, the Duration Days (M-F) section displays.  
    1.  **Note**: Company level Duration settings will display in light gray (Ex Rack Hange Rods).
    2.  **Phases** - A Duration Day can be set for each Phase and for each Package Category. Phases are also used in [**Division (Admin)**](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/103317524 "/wiki/spaces/SK/pages/103317524") and [**Tracking Statuses (Admin)**](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/10485761/Tracking+Statuses+Admin). 
        
        1.  **Office** \- Detailing Start Date
            
        2.  **Purchasing** \- Purchasing Start Date
            
        3.  **Shop** \- Fabrication Start Date
            
        4.  **Field** - Field Date
            
    3.  **Duration Day** - A Duration day is a business day Monday thru Friday. In the current calculation, weekends are excluded while public holidays are included as a business day. For example, if a Start Date for Purchasing Phase is 9/1/2021 and the Duration Day is set to 21, the Start Date for the Shop Phase will be 9/29/2021 where 4 Saturdays and 4 Sundays were excluded, and the public holiday 9/6/2021 was not excluded.
        
3.  Edit the value associated with the phase. **Note**: When a day has been updated, the Package Category will highlight, showing there has been a change (Ex. 250).
    1.  The Confirm Save dialog will display when editing Duration Days at the company and project level. After updating a Package Category > Duration Day:
        
        1.  Click the **Save** button.
        2.  The **Confirm Save** modal will display.![](https://gtpservices.atlassian.net/wiki/download/attachments/217907482/image2023-6-23_11-28-46.png?version=1&modificationDate=1687537727957&cacheVersion=1&api=v2)  
            1.  **Apply to Existing Packages w/o Duration Days**
                
                1.  This option will recalculate package durations that have at least one “Empty” start/end phase date for the specific Package Category/Planning Phase.
                    
                2.  **Note**: For this to trigger and recalculate, their must be at least one start date in the planning phase of the package.
                    
                    ![](https://gtpservices.atlassian.net/wiki/download/attachments/217907482/image2023-6-23_11-20-23.png?version=1&modificationDate=1687537762471&cacheVersion=1&api=v2) 
                    
            2.  **Apply to All Existing Packages**
                
                1.  This option will recalculate **ALL** existing package durations across the project that have duration days.
                    
            3.  **Do Not Apply to Existing Packages**
                
                1.  This option will not recalculate any package durations within the project.
                    
        3.  Select an option and **Save**.
4.  For the Duration Day to be applied to a package during the create package process:
    1.  **Package Category (required) -** The package category that includes Duration Days for one or more phases must be selected.
    2.  **Phase (optional)** - Phase defaults to **On Site**, but can be changed to a particular Phase. Selecting a phase will only denote which Start Date will be set with the Start Date entered (below). Initial Start Dates will populate the other Phases based on the Duration Days calculations.
    3.  **Start Date (optional)** - The Start Date is used to set the Start Date of the selected Phase.  If a Start Date is not entered, all Phase Start Dates will be empty.
        1.  The meaning of **On Site** is defined by your company.
        2.  On the Packages > Dashboard, the **Required Date = On Site** date.
    4.  **Note: Duration** - If the Package Category selected includes Duration (days), then those Phase Start Dates will be calculated based on the Start Date of the selected Phase (#2).
5.  **Reset** - Click the Reset blue button in the upper right to set all the data back to Company Settings.
6.  See the Package [**Planning / Actual**](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/260603982/Package+Properties#PackageProperties-PackagePlanning%2FActual) article for more information.

### Example: Project level Settings

Any Duration Day change at the Project level overrides the existing Company level setting for the edited Package Category and Phase.

**To set Duration Days for a Package Category in a project:**

1.  Click the value to change within the table and enter the number of Duration Days for any Package Category. In this example, for the Fabrication Release Package Category, 3, 5, 7, and 9 were entered for Office, Purchasing, Shop, and Field package Phases.  
    ![](https://gtpservices.atlassian.net/wiki/download/thumbnails/217907482/image2022-5-19_14-42-12.png?version=1&modificationDate=1652989333917&cacheVersion=1&api=v2&width=600&height=340)
    
2.  Click **Save**.
    
3.  For a new package:
    
    1.  **Category** \= Rack Hanger Rods
        
    2.  **Phase** \= Shop
        
    3.  **Required Date** = 06/28/2022 
        
        ![](https://gtpservices.atlassian.net/wiki/download/thumbnails/217907482/image2022-5-19_14-45-52.png?version=1&modificationDate=1652989553699&cacheVersion=1&api=v2&width=350&height=591)
        
4.  The resulting **Required Date** (07/01/2022 ) displays on the Packages Dashboard.
    
    ![](https://gtpservices.atlassian.net/wiki/download/thumbnails/217907482/image2022-5-19_14-49-9.png?version=1&modificationDate=1652989750610&cacheVersion=1&api=v2&width=1262&height=250)
    
5.  The Packages > Properties > Planning section will display the Start Dates for the Package Phases based on the Company level Duration Days settings.
    
    ![](https://gtpservices.atlassian.net/wiki/download/thumbnails/217907482/image2022-5-19_14-50-28.png?version=1&modificationDate=1652989829755&cacheVersion=1&api=v2&width=860&height=250)
    
    1.  **Office (Start Date)**\- Calculated to be 06/23/2022, 2 Duration Days before the Purchasing Start Date.
        
    2.  **Purchasing** \- Calculated to be 06/27/2021, 4 Duration Days before the Shop Start Date.
        
    3.  **Shop** \- The Package was created with the Shop Phase selected, therefore, the Required Date (07/01/2022) was used as the Shop Start Date. All other initial calculations were based off this start date.
        
    4.  **On Site** - The On Site date is initially set to be 1 Duration day after the Shop End Date.
    5.  **Field** \- Calculated to be 07/12/2022, 8 Duration Days after the On Site End Date.
        
    6.  **Duration (days)** \- The Package Duration is calculated from the Office Start Date to Field End Date which is 21 business days.
        
6.  **Packages > Schedule** - The Start Date for each phase will display as a row on the Packages > Schedule. See the [**Packages Schedule**](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/9044061/Packages+Schedule) article for more information.
    
    ![](https://gtpservices.atlassian.net/wiki/download/thumbnails/217907482/image2022-5-19_14-59-18.png?version=1&modificationDate=1652990360096&cacheVersion=1&api=v2&width=1200&height=293)
    
    1.  Hover over any phase to display information. Notice the Duration of 8 days corresponds with the Company level Package Category (Mechanical Piping) and its Shop Lead Days setting of 8 days.  
        ![](https://gtpservices.atlassian.net/wiki/download/thumbnails/217907482/image2021-8-9_8-54-18.png?version=1&modificationDate=1628517260450&cacheVersion=1&api=v2&width=1000&height=334)
        
    2.  In this example where only Company level Package Category Duration Days are set, any change to a Start Date, End Date, or Duration is considered a Package level override. See either the [**Package Level Configuration**](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/260603982/Package+Properties#PackageProperties-PackagePlanning%2FActual) section or the [**Packages Schedule**](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/9044061/Packages+Schedule) article for more information.
---
created: 2025-06-25T10:50:40 (UTC -04:00)
tags: []
source: https://gtpservices.atlassian.net/wiki/spaces/SK/pages/1799815169/Supplier+Admin
author: 
---

# Supplier Admin - STRATUS Knowledge Base - Confluence

> ## Excerpt
> Atlassian uses cookies to improve your browsing experience, perform analytics and research, and conduct advertising. Accept all cookies to indicate that you agree to our use of cookies on your device. Atlassian cookies and tracking notice, (opens new window)

---
Atlassian uses cookies to improve your browsing experience, perform analytics and research, and conduct advertising. Accept all cookies to indicate that you agree to our use of cookies on your device. [Atlassian cookies and tracking notice, (opens new window)](https://www.atlassian.com/legal/cookies)
---
created: 2025-06-25T10:50:40 (UTC -04:00)
tags: []
source: https://gtpservices.atlassian.net/wiki/spaces/SK/pages/1799815253/Supplier+Suppliers+Admin
author: 
---

# Supplier Suppliers (Admin) - STRATUS Knowledge Base - Confluence

> ## Excerpt
> Atlassian uses cookies to improve your browsing experience, perform analytics and research, and conduct advertising. Accept all cookies to indicate that you agree to our use of cookies on your device. Atlassian cookies and tracking notice, (opens new window)

---
Atlassian uses cookies to improve your browsing experience, perform analytics and research, and conduct advertising. Accept all cookies to indicate that you agree to our use of cookies on your device. [Atlassian cookies and tracking notice, (opens new window)](https://www.atlassian.com/legal/cookies)
---
created: 2025-06-25T10:50:40 (UTC -04:00)
tags: []
source: https://gtpservices.atlassian.net/wiki/spaces/SK/pages/217940256/Team+Admin
author: 
---

# Team (Admin) - STRATUS Knowledge Base - Confluence

> ## Excerpt
> The Team page is only available to Project Admin project role. For each project, users need to be added to the project team. Each team member is assigned a project role that corresponds to your company's defined Project Roles under Admin > Company > Project Roles. Users who have been assigned to a group under Admin > Company > Users can be quickly added to the team with a set project role.

---
The Team page is only available to **Project Admin** project role. For each project, users need to be added to the project team. Each team member is assigned a project role that corresponds to your company's defined Project Roles under Admin > Company > Project Roles. Users who have been assigned to a group under Admin > Company > Users can be quickly added to the team with a set project role.

-   1[Add an Individual Team Member](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/217940256/Team+Admin#Team(Admin)-AddanIndividualTeamMember) 
-   2[Add/Update Team Members Group](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/217940256/Team+Admin#Team(Admin)-Add%2FUpdateTeamMembersGroup)

## Add an Individual Team Member 

To add an individual Team Member:

1.  Under **Admin** > **Project** > **Team**, click the  **New** button. The Project - Add New Team Member dialog will display![](https://gtpservices.atlassian.net/wiki/download/attachments/217940256/image2023-6-22_13-54-51.png?version=1&modificationDate=1687460096094&cacheVersion=1&api=v2).
2.  Select the user's **Name** from the drop-down list. The user needs to be a company user under **Admin > Company > Users**. See the [**Users (Admin**)](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/201130058/Users+Admin) article for more information. 
3.  **Email** - Their email will display automatically.
4.  Select the user's **Role** on this project. Project Roles and permissions are defined under **Admin > Company > Project Roles**. See the **[Users (Project Role)](https://gtpservices.atlassian.net/wiki/spaces/SK/pages/11534527/Project+Roles+Admin)** article for more information.
5.  Click **Save**. The project will now display for the user. To view the project, the user may need to click their **Refresh Permissions** button under their badge.

## Add/Update Team Members Group

To add a Group of Team Members to a project:

1.  Before the Group option will display on the Team page, users must be assigned to a **Group** under **Admin > Company > Users**.  
    ![](https://gtpservices.atlassian.net/wiki/download/attachments/217940256/image2023-6-22_13-56-4.png?version=1&modificationDate=1687460169235&cacheVersion=1&api=v2)
2.  Under **Admin** > **Project** > **Team**, select the Group and Role that the group will have on the selected Team. Any users in the group that have not already been added to the team will be added. Click the **Add/Update** button to add the group or update the team members of an existing group.  
    ![](https://gtpservices.atlassian.net/wiki/download/attachments/217940256/image2023-6-22_13-57-32.png?version=1&modificationDate=1687460257284&cacheVersion=1&api=v2)
