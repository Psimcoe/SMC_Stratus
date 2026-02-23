

<!-- Start of Define Package - EVOLVE Electrical Help.md -->

---
created: 2025-07-25T08:53:00 (UTC -04:00)
tags: []
source: https://help-electrical.evolvemep.com/evolve-electrical-spooling-prefabrication/create-prefab-package
author: Adam Heon
---

# Define Package - EVOLVE Electrical Help

> ## Excerpt
> Define Package. Summary. Sometimes spools are only a piece of the workflow. Whether it's packaging multi-trade racks or entire electrical rooms, multiple spools often need to be packaged and assemble…

---
-   [Define Package](https://help-electrical.evolvemep.com/evolve-electrical-spooling-prefabrication/create-prefab-package#define_package)
    -   [Summary](https://help-electrical.evolvemep.com/evolve-electrical-spooling-prefabrication/create-prefab-package#summary)
-   [Usage](https://help-electrical.evolvemep.com/evolve-electrical-spooling-prefabrication/create-prefab-package#usage)
    -   [Defining a Package](https://help-electrical.evolvemep.com/evolve-electrical-spooling-prefabrication/create-prefab-package#defining_a_package)
-   [Window Overview](https://help-electrical.evolvemep.com/evolve-electrical-spooling-prefabrication/create-prefab-package#window_overview)
-   [Tips and Tricks](https://help-electrical.evolvemep.com/evolve-electrical-spooling-prefabrication/create-prefab-package#tips_and_tricks)
    -   [Managing Packages](https://help-electrical.evolvemep.com/evolve-electrical-spooling-prefabrication/create-prefab-package#managing_packages)
    -   [Package Template Titleblocks](https://help-electrical.evolvemep.com/evolve-electrical-spooling-prefabrication/create-prefab-package#package_template_titleblocks)
    -   [Naming Packages](https://help-electrical.evolvemep.com/evolve-electrical-spooling-prefabrication/create-prefab-package#naming_packages)
-   [Relevant Articles](https://help-electrical.evolvemep.com/evolve-electrical-spooling-prefabrication/create-prefab-package#relevant_articles)

### Define Package

![](https://files.helpdocs.io/05s9b4gl38/other/1674124021982/line-2000-gray.png)

#### Summary

Sometimes spools are only a piece of the workflow. Whether it's packaging multi-trade racks or entire electrical rooms, multiple spools often need to be packaged and assembled as one. Prefab Packages makes this process seamless by allowing the user to quickly define multiple spools to a package and create deliverables right from the model. 

-   **eVolve** tab ⮞ **Prefabrication** panel ⮞ **Define Package** button ![](https://files.helpdocs.io/05s9b4gl38/articles/e17ux1rqjv/1718899137433/pre-fab-package-32-x-32.png)

![](https://files.helpdocs.io/05s9b4gl38/other/1674124051830/line-2000-gray-dark.png)

### Usage

#### Defining a Package

1.  From the eVolve ribbon, in the **Prefabrication** panel, click **Define Package**.
2.  From the _Create/Define Package_ window, enter a package name, select desired options, and click **OK**.
3.  From the drawing area, using a window selection or crossing window selection, choose the desired elements to include in the package and click **Finish** from the _Options Bar_.
4.  Continue to select elements for other packages or click **Finish** in the _Options Bar_ to complete the session.

![](https://files.helpdocs.io/05s9b4gl38/other/1674124063289/line-2000-gray-dark.png)

### Window Overview

![](https://files.helpdocs.io/05s9b4gl38/articles/e17ux1rqjv/1718902626570/image.png)

**NOTE**: The _Create/Define Package's_ predefined selection filter can be modified via the _Selection Configuration_. Please see the link in the **Relevant Articles** below.

1.  **Package Name** - The value specified will be applied to all elements selected to be included in the package. While the name may be alphanumeric, it must end with a numeric value.
2.  **Prompt for name on each definition** - when enabled, the _Define Package_ window is displayed after defining every package, providing an opportunity to assign a unique name to each package.
3.  **Create Sheets(s) on Finish** - If enabled, eVolve will create the sheets for the defined packages(s) on finish using the title-block defined in step 3. If disabled, the package sheets may be created within the Prefab Manager.
4.  **Title Block** - If **Create Sheet(s) on Finish** is enabled, the selected Title Block will be applied to all defined packages.
5.  **Title Block Type** - If applicable, this field is used to define the type of the selected title block family.
6.  **Open Created Sheet(s)** - if enabled, all created sheets will open after completing the session.
    
    **NOTE**: Packages may be defined and created at the same time, or they may be defined and then created through the _Prefab Manager_.
    

![](https://files.helpdocs.io/05s9b4gl38/other/1674123781789/image.png)

### Tips and Tricks

#### Managing Packages

Once created, there are various ways to monitor and maintain packages within a model.

All package information is contained within shared parameters that are visible from the Revit Properties Panel. This allows for view filters, as well as Element Filters, to quickly be created for finding and displaying package information.

The parameter "eV\_PackageId" is the parameter used by EVOLVE to identify a package. Parameters starting with "eV\_Package..." should not be modified manually.

This information is also available within the Spool Manager.

#### Package Template Titleblocks

1.  Ensure package parameters are unchecked in any view templates used for package title block templates.
2.  Ensure there is not default plan view template in the project. This will override the chosen view template from the prefab sheet.

![](https://files.helpdocs.io/05s9b4gl38/articles/e17ux1rqjv/1722523778514/image.png)

![](https://files.helpdocs.io/uuudojgxkp/articles/gfryznzy1w/1607637615041/image.png)

1.  Remember to stretch schedules to match the size needed on the sheet before saving them as a view template. When modifying a schedule use the **Resize** button to measure the width of the schedule, set the width of the schedule in the corresponding titleblock view window. **Modify Schedule/Quantities** tab ⮞ **Columns** panel ⮞ **Rezise** button.![](https://files.helpdocs.io/05s9b4gl38/articles/e17ux1rqjv/1713272633533/resize-butto.png)

![](https://files.helpdocs.io/05s9b4gl38/articles/e17ux1rqjv/1709638464558/line-2000-gray-very-light-single.png)

#### Naming Packages

Package names may be automatically generated by utilizing the parameters of the elements contained within the package. While users can specify a value to apply to a defined package, the Package Name dialog is also a menu containing Revit and eVolve parameters. The parameters may be appended or chained together to provide a more descriptive name.

The bolded value below will generate the following spool names.

**Electrical Examples**

-   **<eE\_ConduitRun\_System> - <eV\_LBS\_Id> - 01**
    -   Branch - L1A-01
    -   Feeder - L2B -02
    -   Fire Alarm - L3C -03

**Mechanical Examples**

-   **<eM\_Service Name> - <eM\_Service Type> - 01**
    -   Return Air 2wg - Rectangular Duct -01
    -   Return Air 2wg - Rectangular Duct -02
    -   Return Air 2wg - Round Duct -03

![](https://files.helpdocs.io/05s9b4gl38/other/1674123754050/line-2000-gray-dark.png)

### Relevant Articles

-   [Prefab Manager](https://help-electrical.evolvemep.com/article/ylwy5wm71o)
-   [Spool Settings](https://help-electrical.evolvemep.com/article/u284kj922d)
-   [Modify Package](https://help-electrical.evolvemep.com/article/c7qfgasnql)
-   [Remove Package](https://help-electrical.evolvemep.com/article/2aarv0xl1t)
-   [Renumber Settings](https://help-electrical.evolvemep.com/article/pb1nd67hi9)
-   [Using Grids in EVOLVE](https://help-electrical.evolvemep.com/article/vz4fr7q3gn)
-   [Dynamic Values](https://help-electrical.evolvemep.com/article/h77bqavm0z)

___

### How did we do?

___


<!-- Start of Define Spool - EVOLVE Electrical Help.md -->

---
created: 2025-07-25T08:52:47 (UTC -04:00)
tags: []
source: https://help-electrical.evolvemep.com/evolve-electrical-spooling-prefabrication/defining-a-spool
author: Adam Heon
---

# Define Spool - EVOLVE Electrical Help

> ## Excerpt
> Define Spool. Summary. Used to create a Revit assembly for selected components. eVolve tab ⮞ Prefabrication panel ⮞ Define Spool button. Usage. To Define a spool From the eVolve ribbon, click Define…

---
-   [Define Spool](https://help-electrical.evolvemep.com/evolve-electrical-spooling-prefabrication/defining-a-spool#define_spool)
    -   [Summary](https://help-electrical.evolvemep.com/evolve-electrical-spooling-prefabrication/defining-a-spool#summary)
-   [Usage](https://help-electrical.evolvemep.com/evolve-electrical-spooling-prefabrication/defining-a-spool#usage)
-   [Window Overview](https://help-electrical.evolvemep.com/evolve-electrical-spooling-prefabrication/defining-a-spool#window_overview)
-   [Tips and Tricks](https://help-electrical.evolvemep.com/evolve-electrical-spooling-prefabrication/defining-a-spool#tips_and_tricks)
-   [Relevant Articles](https://help-electrical.evolvemep.com/evolve-electrical-spooling-prefabrication/defining-a-spool#relevant_articles)

### Define Spool

![](https://files.helpdocs.io/05s9b4gl38/other/1674124021982/line-2000-gray.png)

#### Summary

Used to create a Revit assembly for selected components.

-   **eVolve** tab ⮞ **Prefabrication** panel ⮞ **Define Spool** button ![](https://files.helpdocs.io/05s9b4gl38/articles/z4v8j4ynju/1718896853733/spool-32-x-32.png)

![](https://files.helpdocs.io/05s9b4gl38/other/1674124051830/line-2000-gray-dark.png)

### Usage

**To Define a spool**

1.  From the eVolve ribbon, click **Define Spool** from the **Prefabrication** panel.
2.  From the _Create/Define Spool_ window, enter a spool name, select the desired option, and click **OK**.
3.  From the drawing area, using a window selection or crossing window selection, choose the desired elements to spool and click **Finish** in the Options Bar.
4.  Continue to select elements to spool or click **Finish** in the Options Bar to complete the session.

![](https://files.helpdocs.io/05s9b4gl38/other/1674124063289/line-2000-gray-dark.png)

### Window Overview

![](https://files.helpdocs.io/05s9b4gl38/articles/z4v8j4ynju/1718902559141/image.png)

**NOTE**: The _Create/Define Spool's_ predefined selection filter can be modified via the _Selection Configuration_. Please see the link in the **Relevant Articles** below.

1.  **Starting Spool Name** - The value specified will be applied to all spools created in the session. While the name may be alphanumeric, it must end with a numeric value.
2.  **Prompt for name on each definition** - when enabled, the _Define Spool_ window is displayed after defining every spool, providing an opportunity to assign a unique name to each spool.
3.  **Create Sheets(s) on Finish** - If enabled, eVolve will create the sheets for the defined spool(s) on finish using the title-block defined in step 3. If disabled, the spool sheets may be created within the Prefab Manager.
4.  **Title Block** - If **Create Sheet(s) on Finish** is enabled, the selected Title Block will be applied to all defined spools.
5.  **Title Block Type** - If applicable, this field defines the selected title block family type.
6.  **Open Created Sheet(s)** - if enabled, all created sheets will open after completing the session.
    
    **TIP**: Spools may be defined and created simultaneously, or they may be defined through the Prefab Manager.
    

![](https://files.helpdocs.io/05s9b4gl38/other/1674123781789/image.png)

### Tips and Tricks

1.  When a new spool is created, the name is initially set by Revit. Any _Parameter Sync_ based rules, including _Colorizer_, will execute against the name Revit assumes should be the next spool if the rule is set to run against new elements of type _Assembly Instance_. The _Revit API_ does not allow changes to the name of the spool until the transaction that creates the spool has been committed. Once the spool is created, EVOLVE applies the name (specified by the user) to the spool. If the rule is set to run on **Existing Element Change** or **Any Update**, then the rule will be triggered to execute against the correct name. The **Allow Multiple Processing** option must be enabled or the rule will only execute on the name initially set by Revit.
2.  When defining multiple spools, the spool number is auto-incremented.
3.  After exiting, the last spool number is remembered and auto incrementation continues when resuming Define Spool.
4.  Spools may be defined from the eVolve Electrical tab or the contextual ribbon.
5.  The **Create Sheet(s) on Finish** checkbox is typically used when generating a few sheets. If generating many sheets, use the Spool Manager.
6.  When defining a spool, existing spools cannot be added to the spool.
7.  When defining a spool:
    1.  Typical Revit selection methods may be used.
    2.  A single click adds all parts and pieces of nested families to a spool.
    3.  The **CTRL** key does not need to be pressed to add elements to the spool.
        1.  When selected, elements are typically highlighted and blue in color. However, after being selected, some elements may not appear to be highlighted. Hover the pointer over an element to verify that the element has been added to the spool.
        2.  When hovering, if an element has not been added a plus symbol (+) appears, click to add the element. If an element has been added, a minus symbol (-) appears, click to remove the element.
8.  Spool names may be automatically generated by utilizing the parameters of the elements contained within the spool. While users can specify a value to apply to defined spools, the Starting Spool Name dialog is also a menu containing Revit and eVolve parameters. The parameters may be appended or chained together for a more descriptive name.  
    The bolded value below will generate the following spool names

**Electrical Examples**

-   **<eE\_ConduitRun\_System> - <eV\_LBS\_Id> - 01**
    -   Branch - L1A-01
    -   Feeder - L2B -02
    -   Fire Alarm - L3C -03

**Mechanical Examples**

-   **<eM\_Service Name> - <eM\_Service Type> - 01**
    -   Return Air 2wg - Rectangular Duct -01
    -   Return Air 2wg - Rectangular Duct -02
    -   Return Air 2wg - Round Duct -03

![](https://files.helpdocs.io/05s9b4gl38/other/1674124256989/line-2000-black-double.png)

### Relevant Articles

-   [Prefab Manager](https://help-electrical.evolvemep.com/article/ylwy5wm71o)
-   [Spool Settings](https://help-electrical.evolvemep.com/article/u284kj922d)
-   [Define Spool](https://help-electrical.evolvemep.com/article/z4v8j4ynju)
-   [Modify Spool](https://help-electrical.evolvemep.com/article/c7qfgasnql)
-   [Delete Spool](https://help-electrical.evolvemep.com/article/8e69lbgk4w)
-   [Define Package](https://help-electrical.evolvemep.com/article/e17ux1rqjv)
-   [Renumber Settings](https://help-electrical.evolvemep.com/article/pb1nd67hi9)
-   [Using Grids in EVOLVE](https://help-electrical.evolvemep.com/article/vz4fr7q3gn)
-   [Dynamic Values](https://help-electrical.evolvemep.com/article/h77bqavm0z)

___

### How did we do?

___


<!-- Start of Delete Spool - EVOLVE Electrical Help.md -->

---
created: 2025-07-25T08:53:07 (UTC -04:00)
tags: []
source: https://help-electrical.evolvemep.com/evolve-electrical-spooling-prefabrication/deleting-a-spool
author: 
---

# Delete Spool - EVOLVE Electrical Help

> ## Excerpt
> Delete Spool. Summary. The delete spool feature replaces the native Revit Disassemble function. This feature will disassemble any selected spools (Revit assemblies). eVolve tab ⮞ Prefabrication panel…

---
-   [Delete Spool](https://help-electrical.evolvemep.com/evolve-electrical-spooling-prefabrication/deleting-a-spool#delete_spool)
    -   [Summary](https://help-electrical.evolvemep.com/evolve-electrical-spooling-prefabrication/deleting-a-spool#summary)
-   [Usage](https://help-electrical.evolvemep.com/evolve-electrical-spooling-prefabrication/deleting-a-spool#usage)
    -   [Pre-Selection](https://help-electrical.evolvemep.com/evolve-electrical-spooling-prefabrication/deleting-a-spool#pre_selection)
    -   [Post-Selection](https://help-electrical.evolvemep.com/evolve-electrical-spooling-prefabrication/deleting-a-spool#post_selection)
-   [Relevant Articles](https://help-electrical.evolvemep.com/evolve-electrical-spooling-prefabrication/deleting-a-spool#relevant_articles)

### Delete Spool

![](https://files.helpdocs.io/05s9b4gl38/other/1674124021982/line-2000-gray.png)

#### Summary

The delete spool feature replaces the native Revit Disassemble function. This feature will disassemble any selected spools (Revit assemblies).

-   **eVolve** tab ⮞ **Prefabrication** panel ⮞ **Delete Spool** button ![](https://files.helpdocs.io/05s9b4gl38/articles/8e69lbgk4w/1718977409889/spool-delete-32-x-32.png)

![](https://files.helpdocs.io/05s9b4gl38/other/1674124051830/line-2000-gray-dark.png)

### Usage

#### Pre-Selection

1.  From the drawing area, select the desired spool(s).
2.  From the eVolve ribbon, in the **Prefabrication** panel, click the _Modify Spool_ menu, and click **Delete Spool**.
3.  From the _Autodesk_ window, click **OK** or **Delete Element(s)** if any views dependent on the spool have been created.

#### Post-Selection

1.  From the eVolve ribbon, in the **Prefabrication** panel, click the _Modify Spool_ menu, and click **Delete Spool**.
2.  From the drawing area, select the desired spool(s) and click the 'Finish' button in the _Options Bar_.
3.  From the _Autodesk_ window, click **OK** or **Delete Element(s)** if any views dependent on the spool have been created.

![](https://files.helpdocs.io/05s9b4gl38/other/1674124256989/line-2000-black-double.png)

### Relevant Articles

-   [Prefab Manager](https://help-electrical.evolvemep.com/article/ylwy5wm71o)
-   [Spool Settings](https://help-electrical.evolvemep.com/article/u284kj922d)
-   [Define Spool](https://help-electrical.evolvemep.com/article/z4v8j4ynju)
-   [Modify Spool](https://help-electrical.evolvemep.com/article/c7qfgasnql)

___

### How did we do?

___


<!-- Start of Modify Package - EVOLVE Electrical Help.md -->

---
created: 2025-07-25T08:52:51 (UTC -04:00)
tags: []
source: https://help-electrical.evolvemep.com/evolve-electrical-spooling-prefabrication/modify-prefab-package
author: Adam Heon
---

# Modify Package - EVOLVE Electrical Help

> ## Excerpt
> Modify Package. Summary. The Modify Package feature gives you the ability to add/remove elements to/from a Package. It also gives you the ability to transfer elements from one Package to another. eVo…

---
-   [Modify Package](https://help-electrical.evolvemep.com/evolve-electrical-spooling-prefabrication/modify-prefab-package#modify_package)
    -   [Summary](https://help-electrical.evolvemep.com/evolve-electrical-spooling-prefabrication/modify-prefab-package#summary)
-   [Usage](https://help-electrical.evolvemep.com/evolve-electrical-spooling-prefabrication/modify-prefab-package#usage)
    -   [Modifying a Package](https://help-electrical.evolvemep.com/evolve-electrical-spooling-prefabrication/modify-prefab-package#modifying_a_package)
-   [Best Practices](https://help-electrical.evolvemep.com/evolve-electrical-spooling-prefabrication/modify-prefab-package#best_practices)
-   [Relevant Articles](https://help-electrical.evolvemep.com/evolve-electrical-spooling-prefabrication/modify-prefab-package#relevant_articles)

### Modify Package

![](https://files.helpdocs.io/05s9b4gl38/other/1674124021982/line-2000-gray.png)

#### Summary

The Modify Package feature gives you the ability to add/remove elements to/from a Package. It also gives you the ability to transfer elements from one Package to another.

-   **eVolve** tab ⮞ **Prefabrication** panel ⮞ _Modify/Remove Package_ menu ⮞ **Modify Package** button ![](https://files.helpdocs.io/05s9b4gl38/articles/c7qfgasnql/1718977480528/prefab-package-modify-32-x-32.png)

![](https://files.helpdocs.io/05s9b4gl38/other/1674124051830/line-2000-gray-dark.png)

### Usage

#### Modifying a Package

1.  From the eVolve ribbon, in the **Prefabrication** panel, click **Modify Package** from the **Package** menu.
2.  In the drawing area, select the desired package by clicking any element that is in the package, then click **Finish**.
    1.  To remove an element, select one of the existing parts within the package, and it will be removed.
    2.  To add an element, click elements that are not already a part of this package.

**TIP**: A plus will appear beside the pointer denoting that the element may be added to the selection. Once selected, when hovering over the same element, a minus symbol appears, indicating the element may be removed from the selection.

1.  After all modifications to the package are complete, from the _Options Bar_, click **Finish**.

![](https://files.helpdocs.io/05s9b4gl38/other/1674123781789/image.png)

### Best Practices

-   When modifying a spool in a package, remove the spool from the package before modifying the spool.

![](https://files.helpdocs.io/05s9b4gl38/other/1674124256989/line-2000-black-double.png)

### Relevant Articles

-   [Prefab Manager](https://help-electrical.evolvemep.com/article/ylwy5wm71o)
-   [Define Package](https://help-electrical.evolvemep.com/article/e17ux1rqjv)
-   [Remove Package](https://help-electrical.evolvemep.com/article/2aarv0xl1t)
-   [Using Grids in EVOLVE](https://help-electrical.evolvemep.com/article/vz4fr7q3gn)
-   [Dynamic Values](https://help-electrical.evolvemep.com/article/h77bqavm0z)

___

### How did we do?

___


<!-- Start of Modify Spool - EVOLVE Electrical Help.md -->

---
created: 2025-07-25T08:52:58 (UTC -04:00)
tags: []
source: https://help-electrical.evolvemep.com/evolve-electrical-spooling-prefabrication/modify-spool
author: Adam Heon
---

# Modify Spool - EVOLVE Electrical Help

> ## Excerpt
> Modify Spool. Summary. The modify spool feature gives users the ability to quickly add or remove elements to an assembly or even combine multiple spools. eVolve tab ⮞ Prefabrication panel ⮞ Modify Sp…

---
-   [Modify Spool](https://help-electrical.evolvemep.com/evolve-electrical-spooling-prefabrication/modify-spool#modify_spool)
    -   [Summary](https://help-electrical.evolvemep.com/evolve-electrical-spooling-prefabrication/modify-spool#summary)
-   [Usage](https://help-electrical.evolvemep.com/evolve-electrical-spooling-prefabrication/modify-spool#usage)
    -   [SHIFT + click Functionality](https://help-electrical.evolvemep.com/evolve-electrical-spooling-prefabrication/modify-spool#shift_click_functionality)
-   [Relevant Articles](https://help-electrical.evolvemep.com/evolve-electrical-spooling-prefabrication/modify-spool#relevant_articles)

### Modify Spool

![](https://files.helpdocs.io/05s9b4gl38/other/1674124021982/line-2000-gray.png)

#### Summary

The modify spool feature gives users the ability to quickly add or remove elements to an assembly or even combine multiple spools.

-   **eVolve** tab ⮞ **Prefabrication** panel ⮞ **Modify Spool** button ![](https://files.helpdocs.io/05s9b4gl38/articles/kejf63i14q/1718977329008/spool-modify-32-x-32.png)

![](https://files.helpdocs.io/05s9b4gl38/other/1674124051830/line-2000-gray-dark.png)

### Usage

**IMPORTANT**: Though available, window selection during this operation will cause a complete redefinition of the spool with only elements you have selected during editing.

1.  From the **eVolve** Ribbon, in the **Spooling** panel, Select **Modify Spool.**
2.  From an active project view, select the spool to be modified.
3.  **Add** or **Remove** parts/spools by hovering over and clicking to select desired elements.
4.  Once all necessary modifications are complete, click **Finish**.

**NOTE**: If sheets were generated for the assemblies prior to modifying the assemblies, you will be prompted to regenerate sheets.

#### SHIFT + click Functionality

Hold SHIFT and click the Modify Spool button to merge multiple spools into one spool. Unlike the standard modify spool actions, holding down shift to activate this command changes the selection from individual parts to whole assemblies.

1.  From the eVolve ribbon, in the Prefab panel, press the SHIFT key when clicking on the **Modify Spool** button.
2.  From the drawing area, select the spool/assembly you wish to edit.
3.  From the drawing area, select other spool assemblies you want to merge into the initial spool.
4.  From the _Options Bar_, click **Finish**.

![](https://files.helpdocs.io/05s9b4gl38/other/1674124256989/line-2000-black-double.png)

### Relevant Articles

-   [Prefab Manager](https://help-electrical.evolvemep.com/article/ylwy5wm71o)
-   [Spool Settings](https://help-electrical.evolvemep.com/article/u284kj922d)
-   [Define Spool](https://help-electrical.evolvemep.com/article/z4v8j4ynju)
-   [Delete Spool](https://help-electrical.evolvemep.com/article/8e69lbgk4w)
-   [Define Package](https://help-electrical.evolvemep.com/article/e17ux1rqjv)
-   [Renumber Settings](https://help-electrical.evolvemep.com/article/pb1nd67hi9)
-   [Using Grids in EVOLVE](https://help-electrical.evolvemep.com/article/vz4fr7q3gn)
-   [Dynamic Values](https://help-electrical.evolvemep.com/article/h77bqavm0z)

___

### How did we do?

___


<!-- Start of Prefab Manager - EVOLVE Electrical Help.md -->

---
created: 2025-07-25T08:52:44 (UTC -04:00)
tags: []
source: https://help-electrical.evolvemep.com/evolve-electrical-spooling-prefabrication/overview-of-the-spool-manager
author: 
---

# Prefab Manager - EVOLVE Electrical Help

> ## Excerpt
> Prefab Manager. Summary. The Prefab Manager displays information for all assemblies(spools) and packages in the current project. This information is conveniently displayed in two tabs. Various action…

---
-   [Prefab Manager](https://help-electrical.evolvemep.com/evolve-electrical-spooling-prefabrication/overview-of-the-spool-manager#prefab_manager)
    -   [Summary](https://help-electrical.evolvemep.com/evolve-electrical-spooling-prefabrication/overview-of-the-spool-manager#summary)
-   [Usage](https://help-electrical.evolvemep.com/evolve-electrical-spooling-prefabrication/overview-of-the-spool-manager#usage)
    -   [Rename Spools](https://help-electrical.evolvemep.com/evolve-electrical-spooling-prefabrication/overview-of-the-spool-manager#rename_spools)
    -   [Rename Spools - Replace and Renumber Existing Values](https://help-electrical.evolvemep.com/evolve-electrical-spooling-prefabrication/overview-of-the-spool-manager#rename_spools_replace_and_renumber_existing_values)
    -   [Rename Spools - Find and Replace](https://help-electrical.evolvemep.com/evolve-electrical-spooling-prefabrication/overview-of-the-spool-manager#rename_spools_find_and_replace)
    -   [Delete Spools](https://help-electrical.evolvemep.com/evolve-electrical-spooling-prefabrication/overview-of-the-spool-manager#delete_spools)
-   [Window Overview](https://help-electrical.evolvemep.com/evolve-electrical-spooling-prefabrication/overview-of-the-spool-manager#window_overview)
    -   [Overview of the Spool tab](https://help-electrical.evolvemep.com/evolve-electrical-spooling-prefabrication/overview-of-the-spool-manager#overview_of_the_spool_tab)
        -   [Tool Palette Buttons](https://help-electrical.evolvemep.com/evolve-electrical-spooling-prefabrication/overview-of-the-spool-manager#tool_palette_buttons)
        -   [Grid Columns](https://help-electrical.evolvemep.com/evolve-electrical-spooling-prefabrication/overview-of-the-spool-manager#grid_columns)
        -   [Data Navigator Buttons](https://help-electrical.evolvemep.com/evolve-electrical-spooling-prefabrication/overview-of-the-spool-manager#data_navigator_buttons)
    -   [Overview of the Pre-Fab Packages tab](https://help-electrical.evolvemep.com/evolve-electrical-spooling-prefabrication/overview-of-the-spool-manager#overview_of_the_pre_fab_packages_tab)
        -   [Tool Palette Buttons](https://help-electrical.evolvemep.com/evolve-electrical-spooling-prefabrication/overview-of-the-spool-manager#tool_palette_buttons_2)
        -   [Grid Columns](https://help-electrical.evolvemep.com/evolve-electrical-spooling-prefabrication/overview-of-the-spool-manager#grid_columns_2)
        -   [Data Navigator Buttons](https://help-electrical.evolvemep.com/evolve-electrical-spooling-prefabrication/overview-of-the-spool-manager#data_navigator_buttons_2)
-   [Relevant Articles](https://help-electrical.evolvemep.com/evolve-electrical-spooling-prefabrication/overview-of-the-spool-manager#relevant_articles)

### Prefab Manager

![](https://files.helpdocs.io/05s9b4gl38/other/1674124021982/line-2000-gray.png)

#### Summary

The Prefab Manager displays information for all assemblies(spools) and packages in the current project. This information is conveniently displayed in two tabs. Various actions may be performed from each tab depending on whether you are working with a spool or package.

-   **eVolve** tab ⮞ **Prefabrication** panel ⮞ **Prefab Manager** button ![](https://files.helpdocs.io/05s9b4gl38/articles/ylwy5wm71o/1718896402883/pre-fab-manager-32-x-32.png)

![](https://files.helpdocs.io/05s9b4gl38/other/1674124037835/line-2000-gray-dark.png)

### Usage

#### Rename Spools

1.  From the eVolve ribbon, in the **Prefabrication** panel, click **Prefab Manager**.
2.  From the _Prefab Manager_ window, in the grid, select the desired spool(s) to rename.
3.  From the tool palette, click **Rename Spools**.

![](https://files.helpdocs.io/05s9b4gl38/articles/ylwy5wm71o/1728990091135/line-2000-gray-light.png)

#### Rename Spools - Replace and Renumber Existing Values

**IMPORTANT**: This option will completely rewrite the spool name.

1.  From the _Rename Spools_ window, ensure the **Replace and renumber existing values** panel radio button is selected.
2.  From the **New Value** dialog box, enter the desired value and click **OK**. The selected spool(s) are renamed, if multiple spools are selected, the end value is incremented.
    
    **NOTE**: Spools names must end in a numerical value.
    

![](https://files.helpdocs.io/05s9b4gl38/articles/ylwy5wm71o/1728990108074/image.png)

#### Rename Spools - Find and Replace

1.  From the _Rename Spools_ window, ensure the **Find and Replace** panel radio button is selected.
2.  From the **Find Text** dialog box, specify the string to search for in the **Spool Name** column.
    
    **NOTE**: If the **Match Case** checkbox is deselected, text matching text is replaced whether or not it is capitalized or lowercase.
    

1.  From the **Replace Text** dialog box, enter the desired value to substitute and click **OK**. Selected spools adhering to the constraints are renamed.

![](https://files.helpdocs.io/05s9b4gl38/articles/ylwy5wm71o/1695310087978/line-2000-gray-light.png)

#### Delete Spools

1.  From the eVolve ribbon, in the **Prefabrication** panel, click **Prefab Manager**.
2.  From the _Prefab Manager_ window, in the grid, select the desired spool(s) to delete.
3.  From the tool palette, click **Delete Spools**.
4.  From the _Please Confirm_ window, click **Yes**.  
    **NOTE**: In Revit terms, the assemble (spool) is being disassembled; the elements within the assemble/spool will not be deleted.
5.  From the _Autodesk Revit_ window, click **Delete Element(s)**. All views and sheets associated with the selected spool(s) are deleted.

![](https://files.helpdocs.io/05s9b4gl38/other/1674124063289/line-2000-gray-dark.png)

### Window Overview

#### Overview of the Spool tab

![](https://files.helpdocs.io/05s9b4gl38/articles/ylwy5wm71o/1725541038784/image.png)

**Display By** menu

-   **Project** - displays spools and packages in the entire project.
-   **Current View** - displays spools and packages that are in the active view.
-   **Current Selection** - displays selected spools and packages.

##### Tool Palette Buttons

-   **Locate Element** - used to locate a single element in the model. If the selected element is in the currently active view, Locate Element will zoom to and display the element in fullscreen. If the selected element is not in the currently active view, Locate Element will allow Revit to find the element.
-   **Rename Spools** - allows for one or multiple spool names to be modified.
-   **Delete Spools** - allows for one or multiple spools(assemblies) to be deleted. Note this function does not delete the elements within the spool, just the association between the elements.
-   **Renumber** - allows spools to be renumbered using the predefined rules within the Renumber feature.
-   **Create Package** - generates an eVolve Package.
-   **Generate Sheets** - creates sheets for selected spools.
-   **Open Selected Sheets** - displays sheets for selected spools if the sheets have been generated.
-   **Create View/Sheet Set** - produces a View/Sheet Set.
-   **Calculate View Rotation** - this function will attempt to calculate a rotation so that the spooled elements are square to the elevation and section views that are created. When running this function, two options will be provided as methods to calculate the proper rotation angle:
    
    1.  "Yes" = EVOLVE will look for a corresponding scope box to calculate the appropriate angle
    2.  "No" = EVOLVE will calculate the rotation angle by the longest straight element within the spool.
    
    Note: Typically, option 2 (selecting No) is the preferred method and provides the best results.
    
    ![](https://files.helpdocs.io/uuudojgxkp/articles/ktwp7l7x7u/1712234938209/image.png)
    

##### Grid Columns

-   **Selection box** - when checked, actions may be performed on the selected row(s). Checking/unchecking the box in the header will either check or uncheck all of the boxes in the grid.
-   **Condition** - displays the current state of the spool.
    -   **Defined** - elements have been designated as a spool, but views/schedules/sheets have NOT been generated.
    -   **Sheet Created** - elements have been designated as a spool, and the views/schedules/sheets have been generated.
-   **Level** - displays the level within the project the spool is associated with.
-   **Spool Name** - displays the name of the spool.
    -   Value assigned to parameter “Type” and “Type Name” of the spool assembly instance.
    -   Value assigned to parameter “Assembly Name” of spool elements.
-   **Package Name** - displays the name of the Prefab Package the spool is contained in.
    -   Value assigned to parameter “eV\_PackageId”
-   **Title Block** - displays the title block used to generate the sheet.
-   **Title Block Type** - displays the title block type used to generate the sheet.
-   **Status** - displays the set Status.
    -   Value assigned to parameter “eVolve\_SpoolStatus”
-   **Phase** - value assigned to parameter “Phase” of the spool assembly instance.
-   **Location** - displays the assigned location of the spool.
    -   Value assigned to parameter “eV\_LBS\_Id”
-   **Weight** - displays the total calculated weight of the spool.
    -   Sum of values assigned to Fabrication parts with the parameter “Weight”
-   **Rotation Angle** - displays the spool's rotation angle (relative to "project north").
    -   Rotates Elevation and Section Assembly views during sheet generation.

##### Data Navigator Buttons

-   **Export Grid** - exports the grid as currently displayed to Excel.
-   **Bulk Update** - allows for the values in multiple fields to be revised at once.
-   **Send to Data Tables** - send all displayed columns and their values to Data Tables.

![](https://files.helpdocs.io/uuudojgxkp/articles/ktwp7l7x7u/1655737869582/line-3.png)

#### Overview of the Pre-Fab Packages tab

![](https://files.helpdocs.io/05s9b4gl38/articles/ylwy5wm71o/1668483016072/image.png)

**Display By** menu

-   **Project** - displays spools and packages in the entire project.
-   **Current View** - displays spools and packages that are in the active view.
-   **Current Selection** - displays selected spools and packages.

##### Tool Palette Buttons

-   **Locate Element** - used to locate a single element in the model. If the selected element is in the currently active view, Locate Element will zoom to and display the element in fullscreen. If the selected element is not in the currently active view, Locate Element will allow Revit to find the element.
-   **Rename Packages** - allows for one or multiple package names to be modified.
-   **Unpack Package** - deletes an eVolve Package; however, the elements are not deleted.
-   **Generate Sheets** - creates sheets for selected spools.
-   **Open Selected Sheets** - displays sheets for selected spools if the sheets have been generated.
-   **Create View/Sheet Set** - produces a View/Sheet Set.

##### Grid Columns

-   **Selection box** - when checked, actions may be performed on the selected row(s). Checking/unchecking the box in the header will either check or uncheck all of the boxes in the grid.
-   **Condition** - displays the current state of the package.
    -   **Defined** - elements have been added to a package, but views/schedules/sheets have NOT been generated.
    -   **Sheet Created** - elements have been added to a package, and the views/schedules/sheets have been generated.
    -   Value assigned to parameter “eV\_PackageCondition”
-   **Package Name** - displays the name of the Prefab Package the spool is contained in.
    -   Value assigned to parameter “eV\_PackageId”
-   **Level** - displays the level within the project the package is associated with.
-   **Title Block** - displays the title block used to generate the sheets.
-   **Title Block Type** - when applicable, the title block type used to generate the sheet is displayed.
-   **Status** - displays the set Status of the package.
    -   Value assigned to parameter “eV\_PackageStatus”

##### Data Navigator Buttons

-   **Export to Excel** - exports the grid as currently displayed to Excel.
-   **Bulk Update** - allows for the values in multiple fields to be revised at once.
-   **Send to Data Tables** - send all displayed columns and their values to Data Tables.

![](https://files.helpdocs.io/05s9b4gl38/other/1674123781789/image.png)

### Relevant Articles

-   [Overview of EVOLVE Titleblocks](https://help-electrical.evolvemep.com/article/6qug30r17v)
-   [Spool Settings](https://help-electrical.evolvemep.com/article/u284kj922d)
-   [Define Spool](https://help-electrical.evolvemep.com/article/z4v8j4ynju)
-   [Modify Spool](https://help-electrical.evolvemep.com/article/c7qfgasnql)
-   [Delete Spool](https://help-electrical.evolvemep.com/article/8e69lbgk4w)
-   [Define Package](https://help-electrical.evolvemep.com/article/e17ux1rqjv)
-   [Renumber Settings](https://help-electrical.evolvemep.com/article/pb1nd67hi9)

___

### How did we do?

___


<!-- Start of Prefabrication - EVOLVE Electrical Help.md -->

---
created: 2025-07-25T08:52:41 (UTC -04:00)
tags: []
source: https://help-electrical.evolvemep.com/evolve-electrical-spooling-prefabrication
author: Updated 8 months ago
---

# Prefabrication - EVOLVE Electrical Help

> ## Excerpt
> Help documentation for EVOLVE Electrical software

---
[Knowledge Base](https://help-electrical.evolvemep.com/) > [User Guides](https://help-electrical.evolvemep.com/evolve-electrical-user-guides)  >  Prefabrication

### Prefabrication

[

### Prefab Manager

Prefab Manager. Summary. The Prefab Manager displays information for all assemblies(spools) and packages in the current project. This information is conveniently displayed in two tabs. Various action…

Updated 8 months ago



](https://help-electrical.evolvemep.com/evolve-electrical-spooling-prefabrication/overview-of-the-spool-manager)

[

### Spool Settings

Spool Settings. Summary. The Spools Settings area allows users to define when and how various options and statuses are applied to spools. eVolve tab ⮞ Resources panel ⮞ Settings menu ⮞ Spool Settings…

![](https://files.helpdocs.io/05s9b4gl38/other/1667838540433/e-volve-profile-logo-150-x-150.png) Updated 1 month ago by Adam Heon



](https://help-electrical.evolvemep.com/evolve-electrical-spooling-prefabrication/spool-settings)

[

### Define Spool

Define Spool. Summary. Used to create a Revit assembly for selected components. eVolve tab ⮞ Prefabrication panel ⮞ Define Spool button. Usage. To Define a spool From the eVolve ribbon, click Define…

![](https://files.helpdocs.io/05s9b4gl38/other/1667838540433/e-volve-profile-logo-150-x-150.png) Updated 8 months ago by Adam Heon



](https://help-electrical.evolvemep.com/evolve-electrical-spooling-prefabrication/defining-a-spool)

[

### Modify Spool

Modify Spool. Summary. The modify spool feature gives users the ability to quickly add or remove elements to an assembly or even combine multiple spools. eVolve tab ⮞ Prefabrication panel ⮞ Modify Sp…

![](https://files.helpdocs.io/05s9b4gl38/other/1667838540433/e-volve-profile-logo-150-x-150.png) Updated 8 months ago by Adam Heon



](https://help-electrical.evolvemep.com/evolve-electrical-spooling-prefabrication/modify-spool)

[

### Delete Spool

Delete Spool. Summary. The delete spool feature replaces the native Revit Disassemble function. This feature will disassemble any selected spools (Revit assemblies). eVolve tab ⮞ Prefabrication panel…

Updated 8 months ago



](https://help-electrical.evolvemep.com/evolve-electrical-spooling-prefabrication/deleting-a-spool)

[

### Define Package

Define Package. Summary. Sometimes spools are only a piece of the workflow. Whether it's packaging multi-trade racks or entire electrical rooms, multiple spools often need to be packaged and assemble…

![](https://files.helpdocs.io/05s9b4gl38/other/1667838540433/e-volve-profile-logo-150-x-150.png) Updated 8 months ago by Adam Heon



](https://help-electrical.evolvemep.com/evolve-electrical-spooling-prefabrication/create-prefab-package)

[

### Modify Package

Modify Package. Summary. The Modify Package feature gives you the ability to add/remove elements to/from a Package. It also gives you the ability to transfer elements from one Package to another. eVo…

![](https://files.helpdocs.io/05s9b4gl38/other/1667838540433/e-volve-profile-logo-150-x-150.png) Updated 1 month ago by Adam Heon



](https://help-electrical.evolvemep.com/evolve-electrical-spooling-prefabrication/modify-prefab-package)

[

### Remove Package

Remove Package. Summary. The Delete Package feature gives you the ability to easily delete a package and its related sheet/views. eVolve tab ⮞ Prefabrication panel ⮞ Modify/Remove Package menu ⮞ Remo…

![](https://files.helpdocs.io/05s9b4gl38/other/1667838540433/e-volve-profile-logo-150-x-150.png) Updated 8 months ago by Adam Heon



](https://help-electrical.evolvemep.com/evolve-electrical-spooling-prefabrication/remove-prefab-package)


<!-- Start of Remove Package - EVOLVE Electrical Help.md -->

---
created: 2025-07-25T08:53:04 (UTC -04:00)
tags: []
source: https://help-electrical.evolvemep.com/evolve-electrical-spooling-prefabrication/remove-prefab-package
author: Adam Heon
---

# Remove Package - EVOLVE Electrical Help

> ## Excerpt
> Remove Package. Summary. The Delete Package feature gives you the ability to easily delete a package and its related sheet/views. eVolve tab ⮞ Prefabrication panel ⮞ Modify/Remove Package menu ⮞ Remo…

---
-   [Remove Package](https://help-electrical.evolvemep.com/evolve-electrical-spooling-prefabrication/remove-prefab-package#remove_package)
    -   [Summary](https://help-electrical.evolvemep.com/evolve-electrical-spooling-prefabrication/remove-prefab-package#summary)
-   [Usage](https://help-electrical.evolvemep.com/evolve-electrical-spooling-prefabrication/remove-prefab-package#usage)
    -   [Removing a Package](https://help-electrical.evolvemep.com/evolve-electrical-spooling-prefabrication/remove-prefab-package#removing_a_package)
-   [Relevant Articles](https://help-electrical.evolvemep.com/evolve-electrical-spooling-prefabrication/remove-prefab-package#relevant_articles)

### Remove Package

![](https://files.helpdocs.io/05s9b4gl38/other/1674124021982/line-2000-gray.png)

#### Summary

The Delete Package feature gives you the ability to easily delete a package and its related sheet/views.

-   **eVolve** tab ⮞ **Prefabrication** panel ⮞ _Modify/Remove Package_ menu ⮞ **Remove Package** button ![](https://files.helpdocs.io/05s9b4gl38/articles/2aarv0xl1t/1718977563035/pre-fab-package-unpack-32-x-32.png)

![](https://files.helpdocs.io/05s9b4gl38/other/1674124037835/line-2000-gray-dark.png)

### Usage

#### Removing a Package

1.  From the eVolve ribbon, in the **Prefabrication** panel, click **Remove Package**.
2.  From the drawing area, click any element in the desired package(s). When hovering, elements in a package are highlighted.  
    **TIP**: A plus will appear beside the pointer denoting that the element may be added to the selection. Once selected, when hovering over the same element, a minus symbol appears indicating the element may be removed from the selection.
3.  After the package(s) have been selected, from the _Options Bar_, click **Finish**.
4.  From the _Remove Package_ window, click **Yes**.

![](https://files.helpdocs.io/05s9b4gl38/other/1674124256989/line-2000-black-double.png)

### Relevant Articles

-   [Prefab Manager](https://help-electrical.evolvemep.com/article/ylwy5wm71o)
-   [Define Package](https://help-electrical.evolvemep.com/article/e17ux1rqjv)
-   [Modify Package](https://help-electrical.evolvemep.com/article/c7qfgasnql)
-   [Using Grids in EVOLVE](https://help-electrical.evolvemep.com/article/vz4fr7q3gn)

___

### How did we do?

___


<!-- Start of Spool Settings - EVOLVE Electrical Help.md -->

---
created: 2025-07-25T08:52:54 (UTC -04:00)
tags: []
source: https://help-electrical.evolvemep.com/evolve-electrical-spooling-prefabrication/spool-settings
author: Adam Heon
---

# Spool Settings - EVOLVE Electrical Help

> ## Excerpt
> Spool Settings. Summary. The Spools Settings area allows users to define when and how various options and statuses are applied to spools. eVolve tab ⮞ Resources panel ⮞ Settings menu ⮞ Spool Settings…

---
-   [Spool Settings](https://help-electrical.evolvemep.com/evolve-electrical-spooling-prefabrication/spool-settings#spool_settings)
    -   [Summary](https://help-electrical.evolvemep.com/evolve-electrical-spooling-prefabrication/spool-settings#summary)
    -   [Window Overview](https://help-electrical.evolvemep.com/evolve-electrical-spooling-prefabrication/spool-settings#window_overview)
    -   [Options Tab](https://help-electrical.evolvemep.com/evolve-electrical-spooling-prefabrication/spool-settings#options_tab)
    -   [Status Tab](https://help-electrical.evolvemep.com/evolve-electrical-spooling-prefabrication/spool-settings#status_tab)
-   [Relevant Articles](https://help-electrical.evolvemep.com/evolve-electrical-spooling-prefabrication/spool-settings#relevant_articles)

### Spool Settings

![](https://files.helpdocs.io/05s9b4gl38/other/1674124021982/line-2000-gray.png)

#### Summary

The Spools Settings area allows users to define when and how various options and statuses are applied to spools.

-   **eVolve** tab ⮞ **Resources** panel ⮞ **Settings** menu ⮞ **Spool Settings** button ![](https://files.helpdocs.io/05s9b4gl38/articles/u284kj922d/1677859012803/spool-settings-32-x-32.png)

![](https://files.helpdocs.io/05s9b4gl38/other/1674124063289/line-2000-gray-dark.png)

#### Window Overview

![](https://files.helpdocs.io/05s9b4gl38/articles/u284kj922d/1731580724446/image.png)

#### Options Tab

-   **Renumber spools when created/modified** checkbox panel - when enabled, this option will use your current renumbering settings to renumber the spooled components when created or modified.
    -   **Renumber Mode** menu
        -   **Last used Renumber Settings** - uses the last radio selection in the **Renumber** panel on _Renumber Settings_ window as the renumber mode.
        -   **Renumber Elements** - runs the rule set against each element in the selection, numbering in no particular order.
        -   **Renumber Elements by Spool** - runs the rule set against each spool in the selection, resetting the starting value with each spool.
-   **Package and Spooling Restrictions** panel
    -   **Disable EVOLVE spooling restrictions** - EVOLVE spooling restrictions prevent users from assigning different elements contained with spools across multiple packages and displays a prompt when changes are made to packages. By disabling this option, all restrictions are removed, and it will be up to the users to assign elements accordingly.
    -   **Disable sheet update** - Disables the prompt to rebuild the spool sheet that appears when an assembly(spool) is modified.  
        
        ![](https://files.helpdocs.io/05s9b4gl38/articles/u284kj922d/1724694742293/image.png)
        

#### Status Tab

-   **Spool and Prefab Package Status** - The Spool and Prefab Package Status grid allows users to add and define any status when a sheet is created. Simply enter a status parameter and select the color to apply that will be visible in the Prefab Manager.
-   **Apply Status**
    -   **Spool Status**
        -   **On Creation** - applies the selected status when a spool is defined.
        -   **On Sheet Creation** - applies the selected status when a spool is generated.
    -   **Pre-Fab Package Status**
        -   **On Creation** - applies the selected status when a package is defined.
        -   **On Sheet Creation** - applies the selected status when a package is generated.
    -   **Assign Spools Status to**
        -   **Spool and all elements** - the spool's current status is applied to the assembly(spool) element and all elements contained within the spool.
        -   **Spool only** - the spool's current status is applied only to the assembly(spool) element.

![](https://files.helpdocs.io/05s9b4gl38/other/1674124256989/line-2000-black-double.png)

### Relevant Articles

-   [Prefab Manager](https://help-electrical.evolvemep.com/article/ylwy5wm71o)
-   [Define Spool](https://help-electrical.evolvemep.com/article/z4v8j4ynju)
-   [Modify Spool](https://help-electrical.evolvemep.com/article/c7qfgasnql)
-   [Delete Spool](https://help-electrical.evolvemep.com/article/8e69lbgk4w)
-   [Define Package](https://help-electrical.evolvemep.com/article/e17ux1rqjv)
-   [Renumber Settings](https://help-electrical.evolvemep.com/article/pb1nd67hi9)
-   [Using Grids in EVOLVE](https://help-electrical.evolvemep.com/article/vz4fr7q3gn)

___

### How did we do?

___
