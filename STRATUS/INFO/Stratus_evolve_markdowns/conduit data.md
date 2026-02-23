

<!-- Start of Assign Run Id - EVOLVE Electrical Help.md -->

---
created: 2025-07-25T09:01:48 (UTC -04:00)
tags: []
source: https://help-electrical.evolvemep.com/conduit-category-data/assign-run-id
author: Adam Heon
---

# Assign Run Id - EVOLVE Electrical Help

> ## Excerpt
> Assign Run Id. Summary. The Assign Run Id feature enables users to quickly assign Conduit Run Schedule values to a conduit run. When applied, the schedule values will synchronize with the eVolve_Cond…

---
### Assign Run Id

![](https://files.helpdocs.io/05s9b4gl38/other/1674124021982/line-2000-gray.png)

#### Summary

The _Assign Run Id_ feature enables users to quickly assign _Conduit Run Schedule_ values to a conduit run. When applied, the schedule values will synchronize with the _eVolve\_ConduitRun\__ shared parameters. Additionally, a Revit schedule can be created using the _eVolve\_ConduitRun_ parameters, and a sample schedule can be found within the eVolve Template file labeled **eE\_Conduit\_Run\_Schedule**.

-   **eVolve** tab ⮞ **Conduit Data** panel ⮞ **Assign Run Id** button ![](https://files.helpdocs.io/05s9b4gl38/articles/qgaxxhxqr7/1707925893451/conduit-schedule-assign-32-x-32.png)

![](https://files.helpdocs.io/05s9b4gl38/other/1674124051830/line-2000-gray-dark.png)

### Usage

1.  From the EVOLVE ribbon, in the **Conduit Data** panel, click the **Assign Run Id** button.
2.  From the active project view, **select an element** that will be assigned the run Id.
3.  When the _Assign Run Id_ window appears, **select a run** from the drop-down menu and click **OK**. The run that was originally selected will inherit this run's parameters.
4.  Continue steps 1-4 for each additional run to be reassigned.

![](https://files.helpdocs.io/05s9b4gl38/other/1674124063289/line-2000-gray-dark.png)

### Window Overview

![](https://files.helpdocs.io/05s9b4gl38/articles/qgaxxhxqr7/1724080137961/image.png)

#### **Assign from Run Schedule** panel

-   **Assign from Run Schedule** radio button - when selected, existing run ids may be associated with selected runs.
-   _Run Id_ menu - displays all runs in the _Conduit Run Schedule_
-   **Only Show Available Runs** checkbox - when checked, the _Run Id menu_ is filtered and only displays runs that have not been assigned a Run Id
-   **Filter by selection** checkbox - when checked, the _Run Id menu_ only displays runs applicable to the selected runs. For example, if two conduit runs are selected, then the Run Id menu will only display runs of the same size and with a parallel quantity of 2.

#### **Create New Run** panel

-   **Create New Run** radio button - when selected, new run ids may be generated from the _Assign Run Id_ window. Note, you may use dynamic naming to generate run ids.
-   **Run Id** menu - used to enter a unique conduit run identifier; the name is written to the _eE\_ConduitRun\_Id_ parameter.  
    
-   **Prompt to define additional parameters** checkbox - when enabled, a prompt will be displayed to enter additional run parameters.  
    

#### Misc

-   **Continuously create/assign run ids** checkbox - when enabled, after selecting parallel runs and/or defining parameters, the _Assign Run Id_ window is displayed to continue assigning/creating run ids.

![](https://files.helpdocs.io/05s9b4gl38/other/1674123781789/image.png)

### Tips and Tricks

#### Adding Run Schedule parameters

**NOTE**: As of 7.4 and higher, the _Column Chooser now includes_ all of the "Run Schedule" fields.

1.  Right-click on a column header and select **Column Chooser**.
2.  From the _Customization_ panel, drag and drop the desired parameters to the _**Run Id**_ _menu grid_.
3.  After the desired parameters have been add, close the _Customization_ panel.

![](https://files.helpdocs.io/05s9b4gl38/articles/qgaxxhxqr7/1707927960165/line-2000-gray-light.png)

#### Grid States

![](https://files.helpdocs.io/05s9b4gl38/other/1674123781789/image.png)

### Best Practices

-   **IMPORTANT -** Always use the _Assign Run Id_ feature to assign run Ids. Manually entering a run Id into the _eE\_ConduitRun\_Id_ parameter does not assign the run Id and will cause unexpected behavior.
-   To make finding the correct run Id easier, take advantage of the **Filter by selection** checkbox.

![](https://files.helpdocs.io/05s9b4gl38/other/1674124256989/line-2000-black-double.png)

### Relevant Articles

-   [Using grids in the eVolve software](https://help-electrical.evolvemep.com/tips-tricks-evolve-electrical/using-dev-express-grids-in-e-volve-software)
-   [Dynamic Values](https://help-electrical.evolvemep.com/tips-tricks-evolve-electrical/dynamic-naming)

___

### How did we do?

___


<!-- Start of Auto Route - EVOLVE Electrical Help.md -->

---
created: 2025-07-25T09:01:48 (UTC -04:00)
tags: []
source: https://help-electrical.evolvemep.com/conduit-category-data/auto-route
author: Kerry Poe
---

# Auto Route - EVOLVE Electrical Help

> ## Excerpt
> Auto Route. Summary. Automatically route conduit runs along a user-defined pathway. This feature requires modeling an EVOLVE Pathway along with Start and Finish elements that align with the project C…

---
-   [Auto Route](https://help-electrical.evolvemep.com/conduit-category-data/auto-route#auto_route)
    -   [Summary](https://help-electrical.evolvemep.com/conduit-category-data/auto-route#summary)
    -   [Prerequisites](https://help-electrical.evolvemep.com/conduit-category-data/auto-route#prerequisites)
-   [Usage](https://help-electrical.evolvemep.com/conduit-category-data/auto-route#usage)
-   [Window Overview](https://help-electrical.evolvemep.com/conduit-category-data/auto-route#window_overview)
    -   [Routing Options panel](https://help-electrical.evolvemep.com/conduit-category-data/auto-route#routing_options_panel)
    -   [Available Runs panel](https://help-electrical.evolvemep.com/conduit-category-data/auto-route#available_runs_panel)
        -   [Grid Columns](https://help-electrical.evolvemep.com/conduit-category-data/auto-route#grid_columns)
-   [Tips and Tricks](https://help-electrical.evolvemep.com/conduit-category-data/auto-route#tips_and_tricks)
-   [Relevant Articles](https://help-electrical.evolvemep.com/conduit-category-data/auto-route#relevant_articles)

### Auto Route

![](https://files.helpdocs.io/05s9b4gl38/other/1674124021982/line-2000-gray.png)

#### Summary

Automatically route conduit runs along a user-defined pathway. This feature requires modeling an EVOLVE Pathway along with Start and Finish elements that align with the project Conduit Run Schedule.

-   **eVolve** tab ⮞ **Conduit Data** panel ⮞ **Auto Route** button ![](https://files.helpdocs.io/05s9b4gl38/articles/wvh6fsawu8/1708963596226/conduit-data-auto-route-32-x-32.png)

![](https://files.helpdocs.io/05s9b4gl38/other/1674124037835/line-2000-gray-dark.png)

#### Prerequisites

-   [Conduit Run Schedule](https://help-electrical.evolvemep.com/conduit-category-data/conduit-run-schedule)
-   [System Families - Pathway](https://help-electrical.evolvemep.com/article/pfzj391wne)

![](https://files.helpdocs.io/05s9b4gl38/other/1674124051830/line-2000-gray-dark.png)

### Usage

1.  Place elements (commonly equipment) corresponding with the **Start** and **Finish** of conduit runs from the Conduit Run Schedule, identifying each element's **Id Parameter**.  
    **Note: Id Parameter** is configured in Auto Route Settings and is set to Equipment\_Id by default.
2.  Create a pathway for conduit runs by utilizing the eE\_PW\_Pathway family. Routing with elbows, tee's, and crosses are supported. Offsetting and vertical rises/falls are also supported.  
    **NOTE:** Load the eE\_PW\_Pathway family from _System Families._
3.  From the **eVolve Electrical** ribbon, in the **Conduit Data** panel, click **Auto Route**.
4.  From the _Auto Route_ window, use the grid to select the desired conduit runs.
5.  Click OK.  
    **NOTE: Start** and **Finish** elements must be within the configured distance configured of the selected pathway. See **Distance From Pathways** in Auto Route Settings.

![](https://files.helpdocs.io/05s9b4gl38/other/1674124063289/line-2000-gray-dark.png)

### Window Overview

![](https://files.helpdocs.io/05s9b4gl38/articles/wvh6fsawu8/1723109527594/image.png)

#### Routing Options panel

-   **Extend to Equipment** checkbox - This option adds an elbow and a straight conduit that extends to the Start and Finish equipment elements.  
    **NOTE:** This option will "stub down" or "stub up" to the equipment from the pathway.

#### Available Runs panel

##### Grid Columns

-   **Selection** - Used to select conduit runs for automatic routing.
-   **Run Id** - Inherited from the _Conduit Run Schedule_, displays the user-defined run identifier.
-   **System** - Inherited from the _Conduit Run Schedule_, displays the systems defined in _Conduit Run Schedule Options_.
-   **Start** - Inherited from the _Conduit Run Schedule_, displays the Equipment Id where the run originates.
-   **Finish** - Inherited from the _Conduit Run Schedule_, displays the Equipment Id where the run terminates.
-   **Parallel Qty** - Inherited from the _Conduit Run Schedule_, displays the number of parallel conduits in a run.
-   **Size** - Inherited from the _Conduit Run Schedule_, displays the conduit size of the run.
-   **Type** - Inherited from **Conduit Standard** in the _Conduit Run Schedule_, displays the conduit standard of the run.

![](https://files.helpdocs.io/05s9b4gl38/other/1674123781789/image.png)

### Tips and Tricks

-   For multi-tier runs use Auto Route to place conduit runs at one elevation, then adjust the pathway to a new elevation and place more Runs.  
    **NOTE:** Runs will be routed at the _Middle Elevation_ of the pathway family.
-   The width of the pathway does not constrain how many conduits can be placed on the pathway.

![](https://files.helpdocs.io/05s9b4gl38/other/1674124256989/line-2000-black-double.png)

### Relevant Articles

-   [Conduit Run Schedule](https://help-electrical.evolvemep.com/conduit-category-data/conduit-run-schedule)
-   [System Families](https://help-electrical.evolvemep.com/settings-category/system-configuration)
-   [Using grids in EVOLVE](https://help-electrical.evolvemep.com/general-information/using-dev-express-grids-in-e-volve-software)
-   [Searching in grids - using the Find feature](https://help-electrical.evolvemep.com/tips-tricks-evolve-electrical/searching-in-grids-using-the-find-feature)
-   [Save Grid States](https://help-electrical.evolvemep.com/tips-tricks-evolve-electrical/save-grid-states)

___

### How did we do?

___


<!-- Start of Clear Run ID - EVOLVE Electrical Help.md -->

---
created: 2025-07-25T09:01:48 (UTC -04:00)
tags: []
source: https://help-electrical.evolvemep.com/conduit-category-data/clear-conduit-run-parameters
author: Adam Heon
---

# Clear Run ID - EVOLVE Electrical Help

> ## Excerpt
> Clear Run Id. This quick, time-saving feature will clear all of the Run Id parameters of the selected connected run(s). From the eVolve ribbon, in the Conduit Data panel, click Clear Run Id. Select o…

---
![](https://files.helpdocs.io/05s9b4gl38/other/1667838540433/e-volve-profile-logo-150-x-150.png) Updated 2 years ago by Adam Heon

### Clear Run Id

This quick, time-saving feature will clear all of the _Run Id_ parameters of the selected connected run(s).

1.  From the _eVolve_ ribbon, in the **Conduit Data** panel, click **Clear Run Id**
2.  Select one part from each desired run to select the entire run(s)
3.  Click **Finish**

![](https://files.helpdocs.io/05s9b4gl38/articles/6dkjkq8fxw/1591679286645/image.png)

![](https://files.helpdocs.io/05s9b4gl38/articles/6dkjkq8fxw/1591679302913/image.png)

___

### How did we do?

___


<!-- Start of Conduit Data - EVOLVE Electrical Help.md -->

---
created: 2025-07-25T09:01:48 (UTC -04:00)
tags: []
source: https://help-electrical.evolvemep.com/conduit-category-data
author: Updated 1 year ago
---

# Conduit Data - EVOLVE Electrical Help

> ## Excerpt
> Help documentation for EVOLVE Electrical software

---
[Knowledge Base](https://help-electrical.evolvemep.com/) > [User Guides](https://help-electrical.evolvemep.com/evolve-electrical-user-guides)  >  Conduit Data

### Conduit Data

[

### Conduit Run Schedule

Conduit Run Schedule. The Conduit Run Schedule is designed to create, modify, and manage conduit run data. Schedule data can be entered manually or loaded from a pre-configured Excel file that is gen…

![](https://files.helpdocs.io/05s9b4gl38/other/1667838540433/e-volve-profile-logo-150-x-150.png) Updated 5 months ago by Adam Heon



](https://help-electrical.evolvemep.com/conduit-category-data/conduit-run-schedule)

[

### Assign Run Id

Assign Run Id. Summary. The Assign Run Id feature enables users to quickly assign Conduit Run Schedule values to a conduit run. When applied, the schedule values will synchronize with the eVolve\_Cond…

![](https://files.helpdocs.io/05s9b4gl38/other/1667838540433/e-volve-profile-logo-150-x-150.png) Updated 8 months ago by Adam Heon



](https://help-electrical.evolvemep.com/conduit-category-data/assign-run-id)

[

### Continue Run

The Continue Run feature is another great time saver from the eVolve Team. When modeling runs, there are many times when sections of conduit are drawn and connected later. Sometimes the pause is for…

![](https://files.helpdocs.io/05s9b4gl38/other/1667838540433/e-volve-profile-logo-150-x-150.png) Updated 2 years ago by Adam Heon



](https://help-electrical.evolvemep.com/conduit-category-data/continue-run)

[

### Clear Run ID

Clear Run Id. This quick, time-saving feature will clear all of the Run Id parameters of the selected connected run(s). From the eVolve ribbon, in the Conduit Data panel, click Clear Run Id. Select o…

![](https://files.helpdocs.io/05s9b4gl38/other/1667838540433/e-volve-profile-logo-150-x-150.png) Updated 2 years ago by Adam Heon



](https://help-electrical.evolvemep.com/conduit-category-data/clear-conduit-run-parameters)

[

### Refresh Conduit Length

The Refresh Conduit Length tool updates conduit lengths when the Enable Conduit Run Schedule Length Calculations option is disabled in Workstation Settings. The Refresh Conduit Length function can up…

![](https://files.helpdocs.io/05s9b4gl38/other/1667838540433/e-volve-profile-logo-150-x-150.png) Updated 2 years ago by Adam Heon



](https://help-electrical.evolvemep.com/conduit-category-data/refresh-conduit-length)

[

### Conduit Quick Bend Total

Quick Bend Total. Summary. The Quick Bend Total feature is used to check the total Bend Angles & Length of a Conduit Run. eVolve tab ⮞ Conduit Data panel ⮞ Quick Bend Total button. Usage. From the eV…

Updated 1 year ago



](https://help-electrical.evolvemep.com/conduit-category-data/conduit-quick-bend-total)

[

### System Colors

System Colors. Show System Colors - Activates the defined eE\_ConduitRun\_System colors within the current view. Clear System Colors - Removes the eE\_ConduitRun\_System colors within the current view. T…

![](https://files.helpdocs.io/05s9b4gl38/other/1667838540433/e-volve-profile-logo-150-x-150.png) Updated 6 months ago by Adam Heon



](https://help-electrical.evolvemep.com/conduit-category-data/enable-system-colors)

[

### Error Check

Conduit Error Check. Analyzes the model for inaccuracies, highlighting mistakes as compared to the Conduit Run Schedule. The Error Check function performs the following checks when selected: Run Id N…

Updated 6 months ago



](https://help-electrical.evolvemep.com/conduit-category-data/error-check)

[

### Reset View

Reset View. If an Error Check has been performed in the project, clicking the Reset View Button will return the highlighted conduit runs to their original state. To reset the view. From the eVolve El…

![](https://files.helpdocs.io/05s9b4gl38/other/1667838540433/e-volve-profile-logo-150-x-150.png) Updated 6 months ago by Adam Heon



](https://help-electrical.evolvemep.com/conduit-category-data/reset-view)

[

### Auto Route

Auto Route. Summary. Automatically route conduit runs along a user-defined pathway. This feature requires modeling an EVOLVE Pathway along with Start and Finish elements that align with the project C…

![](https://files.helpdocs.io/uuudojgxkp/other/1667837364652/e-volve-profile-logo-150-x-150.png) Updated 5 days ago by Kerry Poe



](https://help-electrical.evolvemep.com/conduit-category-data/auto-route)


<!-- Start of Conduit Quick Bend Total - EVOLVE Electrical Help.md -->

---
created: 2025-07-25T09:01:48 (UTC -04:00)
tags: []
source: https://help-electrical.evolvemep.com/conduit-category-data/conduit-quick-bend-total
author: 
---

# Conduit Quick Bend Total - EVOLVE Electrical Help

> ## Excerpt
> Quick Bend Total. Summary. The Quick Bend Total feature is used to check the total Bend Angles & Length of a Conduit Run. eVolve tab ⮞ Conduit Data panel ⮞ Quick Bend Total button. Usage. From the eV…

---
-   [Quick Bend Total](https://help-electrical.evolvemep.com/conduit-category-data/conduit-quick-bend-total#quick_bend_total)
    -   [Summary](https://help-electrical.evolvemep.com/conduit-category-data/conduit-quick-bend-total#summary)
    -   [Usage](https://help-electrical.evolvemep.com/conduit-category-data/conduit-quick-bend-total#usage)
    -   [Window Overview](https://help-electrical.evolvemep.com/conduit-category-data/conduit-quick-bend-total#window_overview)
    -   [Tips and Tricks](https://help-electrical.evolvemep.com/conduit-category-data/conduit-quick-bend-total#tips_and_tricks)
    -   [Videos](https://help-electrical.evolvemep.com/conduit-category-data/conduit-quick-bend-total#videos)
-   [Relevant Articles](https://help-electrical.evolvemep.com/conduit-category-data/conduit-quick-bend-total#relevant_articles)

### Quick Bend Total

![](https://files.helpdocs.io/05s9b4gl38/other/1674124021982/line-2000-gray.png)

#### Summary

The Quick Bend Total feature is used to check the total Bend Angles & Length of a Conduit Run.

-   **eVolve** tab ⮞ **Conduit Data** panel ⮞ **Quick Bend Total** button ![](https://files.helpdocs.io/05s9b4gl38/articles/0s75jf56u0/1677837898088/quick-bend-total-32-x-32.png)

![](https://files.helpdocs.io/05s9b4gl38/other/1674124051830/line-2000-gray-dark.png)

#### Usage

1.  From the eVolve ribbon, in the **Conduit Data** panel, click **Quick Bend Total**.
2.  From the drawing area, select a conduit run. The Quick bend Total window is displayed.

![](https://files.helpdocs.io/05s9b4gl38/other/1674124063289/line-2000-gray-dark.png)

#### Window Overview

![](https://files.helpdocs.io/05s9b4gl38/articles/0s75jf56u0/1677838458150/image.png)

-   **C****onduit Run Id** - displays the Run Id assigned to the selected conduit.
-   **Total Degree Of Bends** - displays the sum total of all bend angles in the selected run.
-   **Run Length** - displays the connected length of the selected conduit run.

![](https://files.helpdocs.io/05s9b4gl38/other/1674123781789/image.png)

#### Tips and Tricks

-   The **Total Degree Of Bends** dialog will highlight red if the selected conduit run's bend angles are over 360 degrees.
-   Clicking **OK** on the _Quick Bend Total_ window will allow the command to stay active, click **Cancel** or close the window to end the command.

![](https://files.helpdocs.io/05s9b4gl38/other/1674123754050/line-2000-gray-dark.png)

#### Videos

<iframe src="https://www.youtube.com/embed/apZn9Eks8gY?feature=oembed" frameborder="0" allow="accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture" allowfullscreen="" aspectratio="0.5625"></iframe>

![](https://files.helpdocs.io/05s9b4gl38/other/1674124256989/line-2000-black-double.png)

### Relevant Articles

-   [Smart Bends](https://help-electrical.evolvemep.com/settings-category/conduit-bend-settings)

___

### How did we do?

___


<!-- Start of Conduit Run Schedule - EVOLVE Electrical Help.md -->

---
created: 2025-07-25T09:01:48 (UTC -04:00)
tags: []
source: https://help-electrical.evolvemep.com/conduit-category-data/conduit-run-schedule
author: Adam Heon
---

# Conduit Run Schedule - EVOLVE Electrical Help

> ## Excerpt
> Conduit Run Schedule. The Conduit Run Schedule is designed to create, modify, and manage conduit run data. Schedule data can be entered manually or loaded from a pre-configured Excel file that is gen…

---
-   [Conduit Run Schedule](https://help-electrical.evolvemep.com/conduit-category-data/conduit-run-schedule#conduit_run_schedule)
-   [Conduit Run Schedule/ Run Schedule tab](https://help-electrical.evolvemep.com/conduit-category-data/conduit-run-schedule#conduit_run_schedule_run_schedule_tab)
    -   [Tool Palette buttons](https://help-electrical.evolvemep.com/conduit-category-data/conduit-run-schedule#tool_palette_buttons)
    -   [Grid Columns](https://help-electrical.evolvemep.com/conduit-category-data/conduit-run-schedule#grid_columns)
    -   [Record Navigator buttons](https://help-electrical.evolvemep.com/conduit-category-data/conduit-run-schedule#record_navigator_buttons)
        -   [To Open the Project Conduit Run Schedule Window](https://help-electrical.evolvemep.com/conduit-category-data/conduit-run-schedule#to_open_the_project_conduit_run_schedule_window)
        -   [Creating a Conduit Run Schedule Manually](https://help-electrical.evolvemep.com/conduit-category-data/conduit-run-schedule#creating_a_conduit_run_schedule_manually)
        -   [Creating a Conduit Run Schedule from an Exported Excel File](https://help-electrical.evolvemep.com/conduit-category-data/conduit-run-schedule#creating_a_conduit_run_schedule_from_an_exported_excel_file)
    -   [Expanding the run record](https://help-electrical.evolvemep.com/conduit-category-data/conduit-run-schedule#expanding_the_run_record)
        -   [Grid Columns](https://help-electrical.evolvemep.com/conduit-category-data/conduit-run-schedule#grid_columns_2)
        -   [To load run data](https://help-electrical.evolvemep.com/conduit-category-data/conduit-run-schedule#to_load_run_data)
-   [Conduit Run Schedule/ Options tab](https://help-electrical.evolvemep.com/conduit-category-data/conduit-run-schedule#conduit_run_schedule_options_tab)
    -   [Error Condition Highlighting panel](https://help-electrical.evolvemep.com/conduit-category-data/conduit-run-schedule#error_condition_highlighting_panel)
    -   [Conduit Fill panel](https://help-electrical.evolvemep.com/conduit-category-data/conduit-run-schedule#conduit_fill_panel)
    -   [Run Options panel](https://help-electrical.evolvemep.com/conduit-category-data/conduit-run-schedule#run_options_panel)
    -   [System Options panel](https://help-electrical.evolvemep.com/conduit-category-data/conduit-run-schedule#system_options_panel)
        -   [Grid Columns](https://help-electrical.evolvemep.com/conduit-category-data/conduit-run-schedule#grid_columns_3)
        -   [Record Navigator buttons](https://help-electrical.evolvemep.com/conduit-category-data/conduit-run-schedule#record_navigator_buttons_2)
    -   [Status panel](https://help-electrical.evolvemep.com/conduit-category-data/conduit-run-schedule#status_panel)
        -   [Grid Columns](https://help-electrical.evolvemep.com/conduit-category-data/conduit-run-schedule#grid_columns_4)
        -   [Record Navigator buttons](https://help-electrical.evolvemep.com/conduit-category-data/conduit-run-schedule#record_navigator_buttons_3)
        -   [To Enable System Colors](https://help-electrical.evolvemep.com/conduit-category-data/conduit-run-schedule#to_enable_system_colors)
        -   [To Utilize eVolve System Colors](https://help-electrical.evolvemep.com/conduit-category-data/conduit-run-schedule#to_utilize_e_volve_system_colors)
-   [Conduit Run Schedule/ Wire Schedule tab](https://help-electrical.evolvemep.com/conduit-category-data/conduit-run-schedule#conduit_run_schedule_wire_schedule_tab)
    -   [Tool Palette buttons](https://help-electrical.evolvemep.com/conduit-category-data/conduit-run-schedule#tool_palette_buttons_2)
    -   [Wire Specification panel](https://help-electrical.evolvemep.com/conduit-category-data/conduit-run-schedule#wire_specification_panel)
    -   [Base Conduit Fill on panel](https://help-electrical.evolvemep.com/conduit-category-data/conduit-run-schedule#base_conduit_fill_on_panel)
    -   [Grid Columns](https://help-electrical.evolvemep.com/conduit-category-data/conduit-run-schedule#grid_columns_5)
    -   [Record Navigator buttons](https://help-electrical.evolvemep.com/conduit-category-data/conduit-run-schedule#record_navigator_buttons_4)
-   [Conduit Run Schedule/ Wire Sizes tab](https://help-electrical.evolvemep.com/conduit-category-data/conduit-run-schedule#conduit_run_schedule_wire_sizes_tab)
    -   [Tool Palette buttons](https://help-electrical.evolvemep.com/conduit-category-data/conduit-run-schedule#tool_palette_buttons_3)
    -   [Grid Columns](https://help-electrical.evolvemep.com/conduit-category-data/conduit-run-schedule#grid_columns_6)
    -   [Record Navigator buttons](https://help-electrical.evolvemep.com/conduit-category-data/conduit-run-schedule#record_navigator_buttons_5)
-   [Tips and Tricks](https://help-electrical.evolvemep.com/conduit-category-data/conduit-run-schedule#tips_and_tricks)
    -   [Custom Columns in the Run Schedule](https://help-electrical.evolvemep.com/conduit-category-data/conduit-run-schedule#relevant_articles)
    -   [Relevant Articles](https://help-electrical.evolvemep.com/conduit-category-data/conduit-run-schedule#relevant_articles_2)

### Conduit Run Schedule

The Conduit Run Schedule is designed to create, modify, and manage conduit run data. Schedule data can be entered manually or loaded from a pre-configured Excel file that is generated directly from eVolve to Excel. Once assigned, each run will appear on a **Conduit Run Schedule** in the _Project Browser_ and can be assessed for several errors with the **Error Check** feature. The Conduit Run Schedule is also where the setup for **System Colors** resides.

### _Conduit Run Schedule_/ **Run Schedule** tab

![](https://files.helpdocs.io/05s9b4gl38/articles/c95h5i2zvg/1668529099627/image.png)

#### Tool Palette buttons

-   **Locate Element** - Used to locate a single element in the model. If the selected element is in the currently active view, Locate Element will zoom to and display the element in fullscreen. If the selected element is not in the currently active view, Locate Element will allow Revit to find the element.
-   **Export to Excel** - exports all data (including hide columns) in an Excel format (.xlsx).
-   **Import from Excel** - imports data from an Excel (.xlxs) file.
-   **Load Runs** - runs a query on the model, getting data that may have been added since the Conduit Run Schedule was opened.

#### Grid Columns

-   **R****un Id** - required, displays the user-defined run identifier.
-   **Start** - used to define the Equipment Id where the run originates.
-   **Finish** - used to define the Equipment Id where the run terminates.
-   **System** menu - displays the systems defined in Options.
-   **Parallel Qty** - used to define the number of parallel conduits in a run. The cell is automatically populated with a value of 1 if left undefined.
-   **Conduit Size** menu - displays a list of available conduit sizes.
-   **Conduit Standard** - displays a list of available standards for the project.
-   **Wire Fil Id** menu - displays a list of available Wire Fill Id for the project.
-   **Material** menu - displays a list of available material types for the project.
-   **Insulation** - displays a list of available insulation types for the project.
-   **Voltage** - displays a list of Revit's Distribution Systems.
-   **Amperage** - displays the amperage associated with the Wire Fill Id.
-   **Wire Description** - displays the phase, neutral, ground, and isolated ground wire size and quantity based on the Wire Fill Id specifications.
-   **Conduit Fill** - Displays the wire and insulation fill percentage in the specified conduit type and size.
-   **Modeled Length** - displays the wire length as currently modeled.
-   **Estimated Length** - displays the approximated wire length defined by the user.
-   **Makeup Length** - displays the additional wire needed in the run defined by the user.
-   **Installed Length** - displays the actual length of wire used as defined by the user.
-   **Wire Length** - displays the combined value of the Modeled Length plus the Makeup Length.
-   **Status** - displays the current Status assigned to the run.
-   **Circuit** - displays the circuit assigned to the run.
-   **Notes** - used to add additional information regarding the run.

#### Record Navigator buttons

-   **Add** - used to add a new row to the grid.
-   **Delete** - used to delete selected row(s).
-   **Export Grid** - exports the grid as currently displayed to Excel.
-   **Bulk Update** - allows for the values in multiple selected rows to be revised at once.
-   **Export to Data Tables** - sends the currently displayed content to a Data Table.

##### To Open the Project Conduit Run Schedule Window

1.       From the **eVolve Electrical** ribbon, in the **Conduit Data** panel, click **Conduit Run Schedule.**

##### Creating a Conduit Run Schedule Manually

From the _Project Conduit Run Schedule_ window, data can be manually entered as needed, with only a Run Id required to generate a schedule. Each run must have its own unique run id to generate a schedule.

##### Creating a Conduit Run Schedule from an Exported Excel File

1.       From the _Project Conduit Run Schedule_ window, in the **Run Schedule** tab, click **Export to Excel**.

2.       Enter a **File Name** and select a **Save Location**. Click **Save** to bring up an Excel file formatted for this feature. Fill out the sheet or save for future use.

3.       From the _Project Conduit Run Schedule_ window, in the **Run Schedule** tab, click **Import from Excel**.

4.       Select the Excel file to load into the project and click **Open**.

5.       Click **Apply** once the schedule generates in the _Project Conduit Run Schedule_ window.

6.       Click on category names to filter each category if needed. Edit data as required.

![](https://files.helpdocs.io/05s9b4gl38/articles/c95h5i2zvg/1708088812926/image.png)

#### Expanding the run record

Expanding a run displays the _bend angle calculations_ reported within the _Conduit Run Schedule_ so that the total angles of each run within the _run schedule_ are displayed. Upon initial inspection, you'll notice that the Bend Angle cells are all set to zero. Traversing runs and calculating bend angles is a timely operation, and many changes may occur between the times the Conduit Run Schedule is opened. Instead of automatically loading all of the changes to the project every time the Conduit Run Schedule is opened, you may choose which runs to load.

![](https://files.helpdocs.io/05s9b4gl38/articles/c95h5i2zvg/1731348706848/image.png)

##### Grid Columns

-   **Parallel Run Id** - Displays the Parallel Run Id assigned to the run.
-   **Parallel Run #** - Defines the parallel run number; the value applied to parameter ‘eE\_ConduitRun\_ParallelId‘.
    -   Once defined, the value is appended to the Parallel Run Id. The values are user-definable alphanumeric that are case insensitive and must be unique. Once defined, the value is appended to the _Parallel Run Id_.
-   **Modeled Length** - Displays the conduit length as currently modeled; the value applied to parameter ‘eE\_ConduitRun\_Length‘.
-   **Status** - Displays the current Status assigned to the parallel run; the value applied to parameter ‘eE\_ConduitRun\_Status‘.
-   **Bend Angle** - Displays the total bend angle for the run.
-   **Segment Qty** - Displays the total number of segments in the run.

##### To load run data

**IMPORTANT**: the **Enable automatic conduit run bend angle calculations** checkbox in **Workstation Settings** must be checked for a conduit run with _eE\_ConduitRun\_Id_ to have its total bend angle stored in **eE\_ConduitRun\_Angle** and each segment total bend angle stored in **eE\_ConduitRun\_SegmentAngle** updated automatically to match the total degrees of bend in the conduit run and segments.

1.  From the _Conduit Run Schedule_ window, in the grid, click each row's **Selection** checkbox for each desired run you would like to update.
2.  From the ribbon, click **Load Run(s)**.

![](https://files.helpdocs.io/05s9b4gl38/articles/c95h5i2zvg/1668538381314/line-3.png)

### _Conduit Run Schedule_/ **Options** tab

![](https://files.helpdocs.io/05s9b4gl38/articles/c95h5i2zvg/1731492614201/image.png)

#### **Error Condition Highlighting** panel

From the _Project Conduit Run Schedule_ window, in the **Options** tab, click on applicable boxes to activate highlighting, select the color for each option, and click **OK**. 

-   **Run Id Not Scheduled-** Highlights conduit where a user entered run data directly into the Properties Palate, which does not appear in the run schedule.
-   **Run Id Not Assigned-** Highlights conduit that is not yet assigned a run id.
-   **Conduit** **Size-** Highlights conduit that was drawn with a different size than listed in the Conduit Run Schedule.
-   **Conduit Standard** - Indicates that the modeled conduit standard does not match the Run Schedule.
-   **Start** - Indicates parameter _eE\_ConduitRun\_Start_ does not match the Run Schedule.
-   **Finish** - Indicates parameter _eE\_ConduitRun\_Finish_ does not match the Run Schedule.
-   **System** - Indicates parameter _eE\_ConduitRun\_System_ does not match the Run Schedule.
-   **Bend Angle** - Indicates parameter _eE\_ConduitRun\_SegmentAngle_ exceeds the value defined for the _Max Bend Angle_ for the assigned System.

#### **Conduit Fill** panel

-   **Maximum Fill** - used to set the fill percentage threshold. When the fill percentage goes above the specified value, the cell is colored red.
-   **Wire Description Format** menu - used to display the _Wire Fill Description_ in the following formats:
    -   3-500, 1-500N, 1-4/0G, 1-4/0IG
    -   3#500 + 1#500N + 1#4/0G + 1#4/0IG
    -   (3)500 + (1)500N + (1)4/0G + (1)4/0IG

#### **Run Options** panel

-   **Automatically Push Run Information** checkbox - when connecting conduits of differing run ids, the selected conduit's **eE\_ConduitRun\_** parameters are pushed to the connecting conduits without prompting. It is recommended that this option remains checked. The assignment can easily be changed with **Assign Run Id**.
-   **Round run length** - rounds the run length up to the nearest selected value.

#### **System Options** panel

-   **Enable System Colors** checkbox - when checked, system colors are applied to runs when a Run Id is assigned or as they are being modeled.

##### Grid Columns

-   **System** - used to define system types. _Systems_ are displayed in the _Run Schedule grid_.
-   **Foreground** - used to set the color and pattern fill of the run's foreground layer.
-   **Background** - used to set the color and pattern fill of the run's background layer.
-   **Material** - used to define the material assigned to the current system. This colorization carries over to Navisworks exports.
-   **Max Bend Angle** - Sets the maximum desired bend for a conduit run.

##### Record Navigator buttons

-   **Add** - used to add a new row to the grid.
-   **Delete** - used to delete selected row(s).
-   **D****uplicate** - used to duplicate selected rows.
-   **Export Grid** - exports the grid as currently displayed to Excel.
-   **Export to Data Tables** - sends the currently displayed content to a Data Table.

#### **Status** panel

-   **On Assign Run Id** menu - the selected status is applied when a _Run Id_ is assigned to a run.

##### Grid Columns

-   **Status** - user-defined condition or state of run.
-   **Color** - defines the color applied to the **Status** cell in the _Run Schedule grid_.
-   **Import Lock** - when checked, the selected status is not overwritten when other statuses are imported.

##### Record Navigator buttons

-   **Add** - used to add a new row to the grid.
-   **Delete** - used to delete selected row(s).
-   **D****uplicate** - used to duplicate selected rows.
-   **Export Grid** - exports the grid as currently displayed to Excel.

##### To Enable System Colors

This feature allows for the assigning of colors, patterns, and materials to conduit runs in a project. The colors can be turned on and off in the Conduit panel of the eVolve ribbon.

##### To Utilize eVolve System Colors

1.  From the _Project Conduit Run Schedule_ window, in the **Options** tab, Click **Enable Systems Colors** to access its setup
2.  Under **System**, Enter the system name of the run that will become colored. The entered text must exactly match one of the Run ids listed in the run schedule tab
3.  Under **Foreground**, Select a **Color** and typically, **Solid Fill**
4.  Select a background (pattern fill) and material if needed
5.  Continue Steps 2-4 as needed to complete setting up the project or what is needed at the time
6.  Click **OK**
7.  **System Colors** can be toggled on and off from the **Conduit** panel in the eVolve ribbon.

![](https://files.helpdocs.io/05s9b4gl38/articles/c95h5i2zvg/1668538381314/line-3.png)

### _Conduit Run Schedule_/ **Wire Schedule** tab

##### Tool Palette buttons

-   **Export to Excel** - exports all data (including hide columns) in an Excel format (.xlsx)
-   **Import from Excel** -imports a data file in an Excel file format (.xlsx)
-   **New Wire Specification** - used to create a wire specification
-   **Edit Wire Specification** - used to modify an existing wire specification
-   **Delete Wire Specification** - removes an existing wire specification

##### **Wire Specification** panel

-   **Wire Specification** menu - displays are existing Wire Specifications contained in the current model
-   **Material** dialog box - displays the material associated with the selected _Wire Specification_

##### **Base Conduit Fill on** panel

-   **Standard** menu - in conjunction with the specified **Insulation** value, both values are used to approximate the _Conduit Fill_ displayed in the grid below.
-   **Insulation** menu - in conjunction with the specified **Standard** value, both values are used to approximate the _Conduit Fill_ displayed in the grid below.

##### Grid Columns

-   **Name** - displays the assigned _Wire Specification_ name
-   **Material** - displays the material associated with the _Wire Specification_
-   **Wire Fill Id** text box - used to assign an Id to the selected _Wire Specification_
-   **Amperage** text box - used to define the _Wire Specification's_ amperage
-   **Phase Qty** text box - used to define the _Wire Specification's_ phase quantity
-   **Phase Size** menu - displays the available sizes as defined on the **Wire Size** tab
-   **Neutral Qty** text box - used to define the _Wire Specification's_ neutral quantity
-   **Neutral Size** menu - displays the available sizes as defined on the **Wire Size** tab
-   **Ground Qty** text box - used to define the _Wire Specification's_ ground quantity
-   **Ground Size** menu - displays the available sizes as defined on the **Wire Size** tab
-   **Iso Ground Qty** text box - used to define the _Wire Specification's_ isolated ground quantity
-   **Iso Ground Size** menu - displays the available sizes as defined on the **Wire Size** tab
-   **Parallel Qty** text box - used to define the _Wire Specification's_ parallel quantity
-   **Conduit Size** menu - displays the available conduit sizes
-   **Conduit Fill** - displays the _Wire Specification's_ approximate conduit fill when the **Standard** and **Insulation** values are selected in the **Base Conduit Fill on** panel.

##### Record Navigator buttons

-   **Add** - used to add a new row to the grid.
-   **Delete** - used to delete selected row(s).
-   **D****uplicate** - used to duplicate selected rows.
-   **Export Grid** - exports the grid as currently displayed to Excel.
-   **Send to Data Tables** - send all displayed columns and their values to Data Tables.

![](https://files.helpdocs.io/05s9b4gl38/articles/c95h5i2zvg/1668538381314/line-3.png)

### _Conduit Run Schedule_/ **Wire Sizes** tab

##### Tool Palette buttons

-   **Export to Excel** - exports all data (including hide columns) in an Excel format (.xlsx)
-   **Import from Excel** -imports a data file in an Excel file format (.xlsx)

##### Grid Columns

-   **AWG** text box - used to define the wire gauge size
-   **Insulation** text box - used to define the material casing the wire
-   **Material** text box - used to define the wire material
-   **Wire Diameter** text box - used to define the diameter of the wire
-   **Ampacity** text box - used to define the maximum current rating of the wire

##### Record Navigator buttons

-   **Add** - used to add a new row to the grid.
-   **Delete** - used to delete selected row(s).
-   **D****uplicate** - used to duplicate selected rows.
-   **Export Grid** - exports the grid as currently displayed to Excel.
-   **Send to Data Tables** - send all displayed columns and their values to Data Tables.

![](https://files.helpdocs.io/05s9b4gl38/articles/f798w5hwo0/1644592051475/image.png)

### Tips and Tricks

#### Custom Columns in the Run Schedule

Custom columns may be added to the **Conduit Run Schedule** using [Parameter Settings](https://help-electrical.evolvemep.com/settings-category/parameter-settings)**.**

Custom columns have the following attributes:

-   Automatically pushed through conduit run with other **Conduit Run Schedule** parameters when a run Id is assigned.
-   Included in **Export to Excel.**
-   When included in the Excel file imported via **Import from Excel,** custom columns are applied to the imported conduit run Id's.

![](https://files.helpdocs.io/05s9b4gl38/articles/f798w5hwo0/1644592051475/image.png)

#### Relevant Articles

[Using grids in the eVolve software](https://help-electrical.evolvemep.com/tips-tricks-evolve-electrical/using-dev-express-grids-in-e-volve-software)

[Data Navigator](https://help-electrical.evolvemep.com/tips-tricks-evolve-electrical/using-dev-express-grids-in-e-volve-software#record_selector)

[Searching in grids - using the Find feature](https://help-electrical.evolvemep.com/tips-tricks-evolve-electrical/searching-in-grids-using-the-find-feature)

[Save Grid States](https://help-electrical.evolvemep.com/tips-tricks-evolve-electrical/save-grid-states)

[Foreground and Background in Revit](https://help.autodesk.com/view/RVT/2021/ENU/?guid=GUID-EBD9E8E6-AF83-4579-8D9A-9B9E23DCAA52)


<!-- Start of Continue Run - EVOLVE Electrical Help.md -->

---
created: 2025-07-25T09:01:48 (UTC -04:00)
tags: []
source: https://help-electrical.evolvemep.com/conduit-category-data/continue-run
author: Adam Heon
---

# Continue Run - EVOLVE Electrical Help

> ## Excerpt
> The Continue Run feature is another great time saver from the eVolve Team. When modeling runs, there are many times when sections of conduit are drawn and connected later. Sometimes the pause is for…

---
The Continue Run feature is another great time saver from the eVolve Team. When modeling runs, there are many times when sections of conduit are drawn and connected later. Sometimes the pause is for a corner, or others it's to go into a pull box. Whatever the reason is, the Continue Run feature allows for the seamless continuation of run data into each added section. The feature only requires the selection of a source run and then the selection of the destination run to continue the data.

#### To Utilize the Continue Run Tool

1.  From the eVolve ribbon, in the **Conduit Data** Panel, click **Continue Run**.
2.  From the drawing area, click to select the **source run**.
3.  From the drawing area, click to select the **destination run**.
4.  Click **Esc** to finish the command.

Once the Continue run command has been completed, all run data will save and act like any other. Clicking on a segment will display all information that was entered in the Conduit Run Schedule, in the Properties Browser. Segment length in addition to the run length will also be shown.

![](https://files.helpdocs.io/05s9b4gl38/articles/970etiiso7/1614652630436/image.png)

#### Isolate Sections

1.  Hold **Shift**
2.  Click **Continue Run**
3.  **Window Select** Runs to Isolate
4.  Select, by clicking the **Source** then **Destination** for each conduit run.
5.  When the final available option has been selected, the isolate function will close out.

___

### How did we do?

___


<!-- Start of Error Check - EVOLVE Electrical Help.md -->

---
created: 2025-07-25T09:01:48 (UTC -04:00)
tags: []
source: https://help-electrical.evolvemep.com/conduit-category-data/error-check
author: 
---

# Error Check - EVOLVE Electrical Help

> ## Excerpt
> Conduit Error Check. Analyzes the model for inaccuracies, highlighting mistakes as compared to the Conduit Run Schedule. The Error Check function performs the following checks when selected: Run Id N…

---
### Conduit Error Check

Analyzes the model for inaccuracies, highlighting mistakes as compared to the Conduit Run Schedule. The Error Check function performs the following checks when selected:

-   **Run Id Not Scheduled** - highlights conduits if there are any conduits in the project that have run id's that are not listed in the schedule. This error can happen if the user enters a run id manually in the family properties rather than using the assign run id function.
-   **Run Id Not Assigned** - highlights conduits if they have not had a run id assigned yet.
-   **Size** - highlights conduits when the value in the **eE\_ConduitRun\_Size** does not match the **Size** value specified in the conduit's Run Specifications.
-   **Start** - highlights conduits when the value in the **eE\_ConduitRun\_Start** does not match the **Start** value specified in the conduit's Run Specifications.
-   **Finish** - highlights conduits when the value in the **eE\_ConduitRun\_Finish** does not match the **Finish** value specified in the conduit's Run Specifications.
-   **Type** - highlights conduits when the value in the **eE\_ConduitRun\_Type** does not match the **Type** value specified in the conduit's Run Specifications.
-   **System** - highlights conduits when the value in the **eE\_ConduitRun\_System** does not match the **System** value specified in the conduit's Run Specifications.

Run Id Not Scheduled, Run Id Not Assigned, and Size are enabled by default.

##### **To Perform an Error Check**

From the **eVolve Electrical** ribbon, in the **Conduit Data** panel, click the **Error Check**.

##### **Modifying Error Conditions**

1.  From the eVolve Electrical ribbon,in the conduit panel, click **Conduit Run Schedule**.
2.  From the _Conduit Run Schedule_ window, click the **Options** tab.
3.  From the **Error Condition Highlighting** panel, check or uncheck the desired conditions and click **OK**.

![](https://files.helpdocs.io/05s9b4gl38/articles/q7lli2kf8l/1594264802577/image.png)

##### **Modifying Highlighting Color**

1.  From the eVolve Electrical ribbon, click the **Conduit** menu and click **Conduit Run Schedule**.
2.  From the _Conduit Run Schedule_ window, click the **Options** tab.
3.  From the **Error Condition Highlighting** panel, click the color drop-down menu, click either the **Custom**, **Web**, or **System** tab, click a color tile to select, and click **OK**.

The error condition must be enabled in order to modify the color.

From the Custom tab in the color drop-down, right-click on any of the tiles in the bottom two rows to define a custom color.

![](https://files.helpdocs.io/05s9b4gl38/articles/u2jd17siyn/1654624211264/image.png)

### Relevant Articles

[Conduit Run Schedule](https://help-electrical.evolvemep.com/conduit-category-data/conduit-run-schedule)

[Reset View](https://help-electrical.evolvemep.com/conduit-category-data/reset-view)

___

### How did we do?

___


<!-- Start of Refresh Conduit Length - EVOLVE Electrical Help.md -->

---
created: 2025-07-25T09:01:48 (UTC -04:00)
tags: []
source: https://help-electrical.evolvemep.com/conduit-category-data/refresh-conduit-length
author: Adam Heon
---

# Refresh Conduit Length - EVOLVE Electrical Help

> ## Excerpt
> The Refresh Conduit Length tool updates conduit lengths when the Enable Conduit Run Schedule Length Calculations option is disabled in Workstation Settings. The Refresh Conduit Length function can up…

---
The _Refresh Conduit Length_ tool updates conduit lengths when the _Enable Conduit Run Schedule Length Calculations_ option is disabled in _Workstation Settings_. The _Refresh Conduit Length_ function can update the length of a single conduit, all conduits in a view, or even the whole project.

![](https://files.helpdocs.io/05s9b4gl38/articles/1nmwxxesqw/1669194652862/image.png)

1.  From the eVolve ribbon, in the **Conduit Data** panel, click **Refresh Conduit Length.**
2.  Select an option from the _Refresh Conduit Length_ window  
    \- **Push to Selection** - will allow for selecting a part to refresh  
    \- **Push to View** - refreshes any adjusted lengths in the current view  
    \- **Push to Entire Project** - refreshes lengths for entire project

**NOTE**: pre-selection is supported if the intent is to use the _Push to Selection_

##### Enable/Disable the _Enable Conduit Run Schedule Lenght Calculations_ option

1.  From the eVolve ribbon, in the **Utilities** panel, click **Settings** and then click **Workstation Settings**.
2.  From the Workstation Settings window, check to enable (un-check to disable) the **Enable Conduit Run Schedule Lenght Calculations** checkbox.

___

### How did we do?

___


<!-- Start of Reset View - EVOLVE Electrical Help.md -->

---
created: 2025-07-25T09:01:48 (UTC -04:00)
tags: []
source: https://help-electrical.evolvemep.com/conduit-category-data/reset-view
author: Adam Heon
---

# Reset View - EVOLVE Electrical Help

> ## Excerpt
> Reset View. If an Error Check has been performed in the project, clicking the Reset View Button will return the highlighted conduit runs to their original state. To reset the view. From the eVolve El…

---
![](https://files.helpdocs.io/05s9b4gl38/other/1667838540433/e-volve-profile-logo-150-x-150.png) Updated 6 months ago by Adam Heon

#### Reset View

If an **Error Check** has been performed in the project, clicking the **Reset View Button** will return the highlighted conduit runs to their original state.

##### To reset the view

From the **eVolve Electrical** ribbon, in the **Conduit Data** panel, click the **Error Check** menu, and from the _Error Check_ menu, click **Reset View**.

![](https://files.helpdocs.io/05s9b4gl38/articles/u2jd17siyn/1654624211264/image.png)

### Relevant Articles

[Conduit Run Schedule](https://help-electrical.evolvemep.com/conduit-category-data/conduit-run-schedule)

[Error Check](https://help-electrical.evolvemep.com/conduit-category-data/error-check)

___

### How did we do?

___


<!-- Start of System Colors - EVOLVE Electrical Help.md -->

---
created: 2025-07-25T09:01:48 (UTC -04:00)
tags: []
source: https://help-electrical.evolvemep.com/conduit-category-data/enable-system-colors
author: Adam Heon
---

# System Colors - EVOLVE Electrical Help

> ## Excerpt
> System Colors. Show System Colors - Activates the defined eE_ConduitRun_System colors within the current view. Clear System Colors - Removes the eE_ConduitRun_System colors within the current view. T…

---
![](https://files.helpdocs.io/05s9b4gl38/other/1667838540433/e-volve-profile-logo-150-x-150.png) Updated 6 months ago by Adam Heon

### System Colors

-   **Show System Colors** \- Activates the defined **eE\_ConduitRun\_System** colors within the current view.
-   **Clear System Colors** \- Removes the **eE\_ConduitRun\_System** colors within the current view.

The _System Colors_ buttons allow users to quickly turn on or shut off the system raceway colors defined in:

_Conduit Run Schedule/Options/Error Conditions Highlighting_.

![](https://files.helpdocs.io/05s9b4gl38/articles/u2jd17siyn/1654624211264/image.png)

### Relevant Articles

[Conduit Run Schedule](https://help-electrical.evolvemep.com/conduit-category-data/conduit-run-schedule)

___

### How did we do?

___
