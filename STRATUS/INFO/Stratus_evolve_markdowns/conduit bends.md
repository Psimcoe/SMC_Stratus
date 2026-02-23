

<!-- Start of AddRemove Unions - EVOLVE Electrical Help.md -->

---
created: 2025-07-25T09:00:14 (UTC -04:00)
tags: []
source: https://help-electrical.evolvemep.com/conduit-bends/add-remove-unions
author: Adam Heon
---

# Add/Remove Unions - EVOLVE Electrical Help

> ## Excerpt
> Add/Remove Unions. Summary. The EVOLVE Add/Remove Unions feature allows the insertion of couplings along a selected run of conduit (or any system family). eVolve tab ⮞ Conduit Bends panel ⮞ Add/Remov…

---
-   [Add/Remove Unions](https://help-electrical.evolvemep.com/conduit-bends/add-remove-unions#add_remove_unions)
    -   [Summary](https://help-electrical.evolvemep.com/conduit-bends/add-remove-unions#summary)
    -   [Usage](https://help-electrical.evolvemep.com/conduit-bends/add-remove-unions#usage)
        -   [To place unions](https://help-electrical.evolvemep.com/conduit-bends/add-remove-unions#to_place_unions)
        -   [To delete unions](https://help-electrical.evolvemep.com/conduit-bends/add-remove-unions#to_delete_unions)
    -   [Window Overview](https://help-electrical.evolvemep.com/conduit-bends/add-remove-unions#window_overview)
        -   [Place Union radio button panel](https://help-electrical.evolvemep.com/conduit-bends/add-remove-unions#place_union_radio_button_panel)
        -   [Delete Union radio button panel](https://help-electrical.evolvemep.com/conduit-bends/add-remove-unions#delete_union_radio_button_panel)
    -   [Tips and Tricks](https://help-electrical.evolvemep.com/conduit-bends/add-remove-unions#tips_and_tricks)
-   [Relevant Articles](https://help-electrical.evolvemep.com/conduit-bends/add-remove-unions#relevant_articles)

### Add/Remove Unions

![](https://files.helpdocs.io/05s9b4gl38/other/1674124021982/line-2000-gray.png)

#### Summary

The EVOLVE Add/Remove Unions feature allows the insertion of couplings along a selected run of conduit (or any system family).

-   **eVolve** tab ⮞ **Conduit Bends** panel ⮞ **Add/Remove Unions** button ![](https://files.helpdocs.io/05s9b4gl38/articles/557mells4v/1677520775111/place-couplings-32-x-32.png)

![](https://files.helpdocs.io/05s9b4gl38/other/1674124051830/line-2000-gray-dark.png)

#### Usage

##### To place unions

1.  From the **eVolve** Ribbon, in the **Conduit** panel, click the **Add/Remove Unions** button
2.  From the drawing area, select the run(s) to add unions.
3.  From the _Options Bar_, click **Finish**
4.  From the _Add/Remove Unions_ window, select the desired options in the **Place Unions** panel and click **OK**.
5.  From the drawing area, click toward the left or right of the view to show which direction to implement the change.

##### To delete unions

1.  From the **eVolve** Ribbon, in the **Conduit** panel, click the **Add/Remove Unions** button
2.  From the drawing area, select the run(s) to remove unions.
3.  From the _Options Bar_, click **Finish**
4.  From the _Add/Remove Unions_ window, select the desired traversal option in the **Delete Unions** panel and click **OK**.
5.  From the drawing area, click toward the left or right of the view to show which direction to implement the change.

**NOTE**: The _Add/Remove Unions_' predefined selection filter can be modified via the _Selection Configuration_. Please see the link in the **Relevant Articles** below.

![](https://files.helpdocs.io/05s9b4gl38/other/1674124063289/line-2000-gray-dark.png)

#### Window Overview

![](https://files.helpdocs.io/05s9b4gl38/articles/8lriq90xkj/1692196226665/image.png)

##### Place Union radio button panel

-   **Entire Path -** places unions along the entire run.
-   **Change of Direction -** places unions from the defined starting point and direction until the direction changes, like an elbow, tee, cross, etc.
-   **Single Location -** allows users to point and click to place a union along the run.  
    **NOTE**: when placing a single union, the command will stay active until the **ESC** button is pressed.
-   **Spacing -** used to specify the spacing between unions. The default spacing is 10’ - 0".
-   **Minimum Length** - if the length of the last straight in the run exceeds the _Spacing_ + _Minimum Length_, then the union is moved back to ensure the last straight maintains the defined minimum length. _For example, if the last straight section is 10' - 6" and the defined spacing is 10' - 0", then the union is placed at 9' 6" instead of 10' - 0" to maintain a 1' - 0" minimum length at the end of the run._
-   **Align Unions in Parallel Runs** - when unchecked, each run has unions placed independently from other runs.

##### Delete Union radio button panel

-   **Entire Path -** removes all unions along the entire conduit run
-   **Change of Direction -** removes all unions from the defined starting point and direction until the direction changes, like an elbow, tee, cross, etc.

![](https://files.helpdocs.io/05s9b4gl38/other/1674123781789/image.png)

#### Tips and Tricks

-   When modeling with eVolve Electricals advanced conduit tools, such as optimize bends and auto-couplings, we recommend using the following workflow:
    1.  **Model** conduit runs utilizing our smart bend families. (Without adjusting them)
    2.  Use **Align Conduit** when necessary for conduit spacing
    3.  **Optimize the bends** using Consume Selected End and/or Consume Adjacent Ends commands and make any adjustments
    4.  Use **Align Couplings** to align the bend couplings
    5.  Use **Place Couplings** to place couplings along the run (We recommend using the "Change of Direction" option when using this workflow and using steps 2-5 section by section)
-   Staggering couplings - unchecking the **Align Unions in Parallel Runs** checkbox will stagger the couples so that couplings do not block tools like wrenches when tightening compression couplings.

![](https://files.helpdocs.io/05s9b4gl38/other/1674124256989/line-2000-black-double.png)

### Relevant Articles

-   [Align Couplings](https://help-electrical.evolvemep.com/conduit-bends/conduit-bends-align-couplings)
-   [Align Condui](https://help-electrical.evolvemep.com/quick-tools/align-conduit)
-   [Optimize Bend](https://help-electrical.evolvemep.com/conduit-bends/conduit-bends-optimize-bend)
-   [Selection Configuration](https://help-electrical.evolvemep.com/settings-category/selection-configuration)

___

### How did we do?

___


<!-- Start of Align BendsMaintain Spacing - EVOLVE Electrical Help.md -->

---
created: 2025-07-25T09:00:14 (UTC -04:00)
tags: []
source: https://help-electrical.evolvemep.com/conduit-bends/conduit-align-bends-maintain-spacing
author: Adam Heon
---

# Align Bends/Maintain Spacing - EVOLVE Electrical Help

> ## Excerpt
> When it comes to modelling efficiently, every click counts. To keep the workflow as smooth as possible, we now have the Align Bends and Maintain Spacing commands. The Align Bends tool can align a who…

---
When it comes to modelling efficiently, every click counts. To keep the workflow as smooth as possible, we now have the **Align Bends** and **Maintain Spacing** commands. The Align Bends tool can align a whole group of conduit bends to the same angle and aligned bend centerpoints. On flat parallel bends, the Maintain Spacing tool will make the spacing between bend the same as the spacing of the conduit before and after the bends.

#### **To Align Bends**

1.  From the **Conduit** panel, in the **eVolve Electrical** ribbon, click the **Align Bends** button
2.  **Select a stationary bend** as the reference for the alignment. (Typically the largest diameter)
3.  **Select the moveable bends** that will be aligned to the reference
4.  Click **Finish**

#### **To Use The Maintain Spacing Command**

1.  From the **Conduit** panel, in the **eVolve Electrical** ribbon, while holding **Shift**, click the **Align Bends** button
2.  **Select a stationary bend** for the others to be aligned to (Typically the largest diameter)
3.  **Select the moveable bends** that will be aligned to the reference bend
4.  Click **Finish**

When modeling with eVolve Electricals advanced conduit tools, such as optimize bends and auto-couplings, we recommend using the following workflow:  
**1.)** **Model** conduit runs utilizing our smart bend families. (Without adjusting them)  
**2.)** Use **Align Conduit** when necessary for conduit spacing  
**3.)** **Optimize the bends** using Consume Selected End and/or Consume Adjacent Ends commands and make any adjustments  
**4.)** Use **Align Couplings** to align the bend couplings  
**5.)** Use **Place Couplings** to place couplings along the run (We recommend using the "Change of Direction" option when using this workflow and using **steps 2-5 section by section**)

_"For best results, we encourage users to only work with eVolve Bend Families."_

___

### How did we do?

___


<!-- Start of Align Couplings - EVOLVE Electrical Help.md -->

---
created: 2025-07-25T09:00:14 (UTC -04:00)
tags: []
source: https://help-electrical.evolvemep.com/conduit-bends/conduit-bends-align-couplings
author: Adam Heon
---

# Align Couplings - EVOLVE Electrical Help

> ## Excerpt
> The Optimize Bends features allow for a streamlined workflow for prefab and design optimization, with much less time needed to be spent cleaning up groups of bends. With these new tools, a designer c…

---
The **Optimize Bends** features allow for a streamlined workflow for prefab and design optimization, with much less time needed to be spent cleaning up groups of bends. With these new tools, a designer can draw in all of their conduits and smart bends into the project and come back and quickly adjust the smart bends with just a few clicks. Then, utilize the **Align Coupling** command wherever needed to bring all of the couplings into proper alignment. Now the run is fully optimized to utilize full stick lengths and has aligned couplings.

#### Using the **Align Couplings** feature

1.  From the eVolve ribbon, in the **Conduit Bends** panel, click the **Align Couplings** button
2.  Select a reference coupling/bend from the group that would be best for aligning the other couplings to. (Typically the bend with its coupling closest to the bend)

![](https://files.helpdocs.io/05s9b4gl38/articles/bpkq9qhf8n/1623183159781/image.png)

1.  **Window select** the bends/couplings that will move to the reference
2.  Click **Finish**

![](https://files.helpdocs.io/05s9b4gl38/articles/bpkq9qhf8n/1623184259600/align-couplings.gif)

When modeling with eVolve Electricals advanced conduit tools, such as optimize bends and auto-couplings, we recommend using the following workflow: **1.)** **Model** conduit runs utilizing our smart bend families. (Without adjusting them) **2.)** Use **Align Conduit** when necessary for conduit spacing **3.)** **Optimize the bends** using Consume Selected End and/or Consume Adjacent Ends commands and make any adjustments **4.)** Use **Align Couplings** to align the bend couplings **5.)** Use **Place Couplings** to place couplings along the run (We recommend using the "Change of Direction" option when using this workflow and using **steps 2-5 section by section**)

_"For best results, we_ _encourage_ _users to only work with eVolve Bend Families."_

___

### How did we do?

___


<!-- Start of Concentric Bends - EVOLVE Electrical Help.md -->

---
created: 2025-07-25T09:00:14 (UTC -04:00)
tags: []
source: https://help-electrical.evolvemep.com/conduit-bends/concentric-bends
author: Kerry Poe
---

# Concentric Bends - EVOLVE Electrical Help

> ## Excerpt
> Concentric Bends. Summary. The Concentric Bends function converts modeled Stub 90 bends into concentric bends. eVolve tab ⮞ Conduit Bends panel ⮞ Concentric Bends button. Usage. IMPORTANT : This feat…

---
-   [Concentric Bends](https://help-electrical.evolvemep.com/conduit-bends/concentric-bends#concentric_bends)
    -   [Summary](https://help-electrical.evolvemep.com/conduit-bends/concentric-bends#summary)
-   [Usage](https://help-electrical.evolvemep.com/conduit-bends/concentric-bends#usage)
    -   [To convert (pre-selection)](https://help-electrical.evolvemep.com/conduit-bends/concentric-bends#to_convert_pre_selection)
    -   [To convert](https://help-electrical.evolvemep.com/conduit-bends/concentric-bends#to_convert)
-   [Tips and Tricks](https://help-electrical.evolvemep.com/conduit-bends/concentric-bends#tips_and_tricks)
-   [Relevant Articles](https://help-electrical.evolvemep.com/conduit-bends/concentric-bends#relevant_articles)

### Concentric Bends

![](https://files.helpdocs.io/05s9b4gl38/other/1674124021982/line-2000-gray.png)

#### Summary

The Concentric Bends function converts modeled _Stub 90_ bends into concentric bends.

-   **eVolve** tab ⮞ **Conduit Bends** panel ⮞ **Concentric Bends** button ![](https://files.helpdocs.io/05s9b4gl38/articles/170kxnzjpy/1687274616719/concentric-bends-32-x-32.png)

![](https://files.helpdocs.io/05s9b4gl38/other/1674124037835/line-2000-gray-dark.png)

### Usage

**IMPORTANT**: This feature requires the use of the _eE\_CN\_Stub\_90\_v12_ family or higher.

#### To convert (pre-selection)

1.  From the drawing area, select the desired group of stub 90 bends.
2.  From the _Electrical_ ribbon, in the **Conduit Bends** panel, click **Concentric Bends**.

#### To convert

1.  From the _Electrical_ ribbon, in the **Conduit Bends** panel, click **Concentric Bends**.
2.  From the drawing area, select the desired group of stub 90 bends.
3.  From the options bar, click 'Finish'

![](https://files.helpdocs.io/05s9b4gl38/other/1674123781789/image.png)

### Tips and Tricks

**NOTE**: If some or all of the select bends have been converted, a dialog will appear to either:

-   **Update selection to concentric bends** (used to update bend information due to additional bends being added to the run and/or the parallel spacing has been modified).
-   **Reset bends to standard radii** (used to revert selected bends to the default radii)
-   **Use existing minimum to make concentric** - if the "inside" elbow's radi has been overwritten, all selected elbows will be adjusted to match.

![](https://files.helpdocs.io/05s9b4gl38/other/1674124256989/line-2000-black-double.png)

### Relevant Articles

-   [Content](https://evolveelectrical.helpdocs.io/content)

___

### How did we do?

___


<!-- Start of Conduit Bends - EVOLVE Electrical Help.md -->

---
created: 2025-07-25T09:00:14 (UTC -04:00)
tags: []
source: https://help-electrical.evolvemep.com/conduit-bends
author: Updated 2 years ago
---

# Conduit Bends - EVOLVE Electrical Help

> ## Excerpt
> Help documentation for EVOLVE Electrical software

---
[Knowledge Base](https://help-electrical.evolvemep.com/) > [User Guides](https://help-electrical.evolvemep.com/evolve-electrical-user-guides)  >  Conduit Bends

### Conduit Bends

[

### Smart Bend Multi-Trim

Smart Bend Multi-Trim. Summary. The Smart Bend Multi-Trim feature adds bends families to allow multi-trimming of families not aligned or on different X,Y, and/or Z planes. This feature connects one o…

![](https://files.helpdocs.io/uuudojgxkp/other/1667837364652/e-volve-profile-logo-150-x-150.png) Updated 2 years ago by Kerry Poe



](https://help-electrical.evolvemep.com/conduit-bends/smart-bend-multi-trim)

[

### Optimize Bend - Consume Selected End

Optimize Bend - Consume Selected End. Summary. The Optimize Bends features allow for a streamlined workflow for prefab and design optimization, with less time spent cleaning up groups of bends. With…

Updated 2 years ago



](https://help-electrical.evolvemep.com/conduit-bends/conduit-bends-optimize-bend)

[

### Reset Bends

When modelling with the advanced tools provided in eVolve Electrical, such as our optimize bends tools, the occasion may arise where a bend needs to be reverted to its original state (ex.. swapping t…

![](https://files.helpdocs.io/05s9b4gl38/other/1667838540433/e-volve-profile-logo-150-x-150.png) Updated 2 years ago by Adam Heon



](https://help-electrical.evolvemep.com/conduit-bends/conduit-bends-refresh-bends)

[

### Concentric Bends

Concentric Bends. Summary. The Concentric Bends function converts modeled Stub 90 bends into concentric bends. eVolve tab ⮞ Conduit Bends panel ⮞ Concentric Bends button. Usage. IMPORTANT : This feat…

![](https://files.helpdocs.io/uuudojgxkp/other/1667837364652/e-volve-profile-logo-150-x-150.png) Updated 2 years ago by Kerry Poe



](https://help-electrical.evolvemep.com/conduit-bends/concentric-bends)

[

### Add/Remove Unions

Add/Remove Unions. Summary. The EVOLVE Add/Remove Unions feature allows the insertion of couplings along a selected run of conduit (or any system family). eVolve tab ⮞ Conduit Bends panel ⮞ Add/Remov…

![](https://files.helpdocs.io/05s9b4gl38/other/1667838540433/e-volve-profile-logo-150-x-150.png) Updated 11 months ago by Adam Heon



](https://help-electrical.evolvemep.com/conduit-bends/add-remove-unions)

[

### Align Couplings

The Optimize Bends features allow for a streamlined workflow for prefab and design optimization, with much less time needed to be spent cleaning up groups of bends. With these new tools, a designer c…

![](https://files.helpdocs.io/05s9b4gl38/other/1667838540433/e-volve-profile-logo-150-x-150.png) Updated 2 years ago by Adam Heon



](https://help-electrical.evolvemep.com/conduit-bends/conduit-bends-align-couplings)

[

### Align Bends/Maintain Spacing

When it comes to modelling efficiently, every click counts. To keep the workflow as smooth as possible, we now have the Align Bends and Maintain Spacing commands. The Align Bends tool can align a who…

![](https://files.helpdocs.io/05s9b4gl38/other/1667838540433/e-volve-profile-logo-150-x-150.png) Updated 3 years ago by Adam Heon



](https://help-electrical.evolvemep.com/conduit-bends/conduit-align-bends-maintain-spacing)

[

### Convert to Smart Bend

Convert to Smart Bend. Summary. Replaces a native Revit conduit offset or kick 90 bend with an EVOLVE Electrical smart bend. eVolve tab ⮞ Conduit Bends panel ⮞ Smart Bend menu ⮞ Convert to Smart Bend…

![](https://files.helpdocs.io/uuudojgxkp/other/1667837364652/e-volve-profile-logo-150-x-150.png) Updated 2 years ago by Kerry Poe



](https://help-electrical.evolvemep.com/conduit-bends/convert-to-smart-bend)

[

### Optimize Bend - Move Selected End

Optimize Bend - Move Selected End. Summary. The Optimize Bends features allow for a streamlined workflow for prefab and design optimization, with less time spent cleaning up groups of bends. With the…

![](https://files.helpdocs.io/uuudojgxkp/other/1667837364652/e-volve-profile-logo-150-x-150.png) Updated 2 years ago by Kerry Poe



](https://help-electrical.evolvemep.com/conduit-bends/optimize-bend-consume-and-specify-length)

[

### Optimize Bend - Consume Adjacent

Optimize Bend - Consume Adjacent. Summary. The Optimize Bends features allow for a streamlined workflow for prefab and design optimization, with less time spent cleaning up groups of bends. With thes…

![](https://files.helpdocs.io/uuudojgxkp/other/1667837364652/e-volve-profile-logo-150-x-150.png) Updated 2 years ago by Kerry Poe



](https://help-electrical.evolvemep.com/conduit-bends/optimize-bend-consume-adjacent)

[

### Optimize Bend - Consume And Center

Optimize Bend - Consume And Center. Summary. The Optimize Bends features allow for a streamlined workflow for prefab and design optimization, with less time spent cleaning up groups of bends. With th…

![](https://files.helpdocs.io/uuudojgxkp/other/1667837364652/e-volve-profile-logo-150-x-150.png) Updated 2 years ago by Kerry Poe



](https://help-electrical.evolvemep.com/conduit-bends/optimize-bend-consume-and-center)


<!-- Start of Convert to Smart Bend - EVOLVE Electrical Help.md -->

---
created: 2025-07-25T09:00:14 (UTC -04:00)
tags: []
source: https://help-electrical.evolvemep.com/conduit-bends/convert-to-smart-bend
author: Kerry Poe
---

# Convert to Smart Bend - EVOLVE Electrical Help

> ## Excerpt
> Convert to Smart Bend. Summary. Replaces a native Revit conduit offset or kick 90 bend with an EVOLVE Electrical smart bend. eVolve tab ⮞ Conduit Bends panel ⮞ Smart Bend menu ⮞ Convert to Smart Bend…

---
-   [Convert to Smart Bend](https://help-electrical.evolvemep.com/conduit-bends/convert-to-smart-bend#convert_to_smart_bend)
    -   [Summary](https://help-electrical.evolvemep.com/conduit-bends/convert-to-smart-bend#summary)
-   [Usage](https://help-electrical.evolvemep.com/conduit-bends/convert-to-smart-bend#usage)
-   [Tips and Tricks](https://help-electrical.evolvemep.com/conduit-bends/convert-to-smart-bend#tips_and_tricks)
-   [Relevant Articles](https://help-electrical.evolvemep.com/conduit-bends/convert-to-smart-bend#relevant_articles)

### Convert to Smart Bend

![](https://files.helpdocs.io/05s9b4gl38/other/1674124021982/line-2000-gray.png)

#### Summary

Replaces a native Revit conduit offset or kick 90 bend with an EVOLVE Electrical smart bend.

-   **eVolve** tab ⮞ **Conduit Bends** panel ⮞ **Smart Bend** menu ⮞ **Convert to Smart Bend** button![](https://files.helpdocs.io/05s9b4gl38/articles/979n1kuxbi/1689062730152/convert-to-smart-bend-32-x-32.png)

![](https://files.helpdocs.io/05s9b4gl38/other/1674124051830/line-2000-gray-dark.png)

### Usage

1.  From the eVolve ribbon, in the **Conduit Bend** panel, click **Convert to Smart Bend.**
2.  From the drawing area, select the first conduit fitting which will be the stationary end of the smart bend.
3.  From the drawing area, select the second conduit fitting which will be the pivot end of the smart bend.
4.  EVOLVE Smart bend will replace the selected conduit fittings.

![](https://files.helpdocs.io/05s9b4gl38/other/1674123781789/image.png)

### Tips and Tricks

We encourage users to only work with eVolve Bend Families for the best results. When modeling with eVolve Electrical's advanced conduit tools, such as Optimize Bends and Auto-Couplings, we recommend using the following workflow:

1.  Model conduit runs utilizing our smart bend families. (Without adjusting them)
2.  Use Align Conduit when necessary for conduit spacing
3.  Optimize the bends using Consume Selected End and/or Consume Adjacent Ends commands and make any adjustments
4.  Use Align Couplings to align the bend couplings
5.  Use Place Couplings to place couplings along the run (We recommend using the "Change of Direction" option when using this workflow and using steps 2-5 section by section)

![](https://files.helpdocs.io/05s9b4gl38/other/1674124256989/line-2000-black-double.png)

### Relevant Articles

-   [Optimize Bend - Move Selected End](https://evolveelectrical.helpdocs.io/article/b5in9bdh03)
-   [Optimize Bend - Consume Adjacent](https://evolveelectrical.helpdocs.io/article/fuvpk2tkp8)
-   [Optimize Bend - Consume And Center](https://evolveelectrical.helpdocs.io/article/gyrvxa3nnm)

___

### How did we do?

___


<!-- Start of Optimize Bend - Consume Adjacent - EVOLVE Electrical Help.md -->

---
created: 2025-07-25T09:00:14 (UTC -04:00)
tags: []
source: https://help-electrical.evolvemep.com/conduit-bends/optimize-bend-consume-adjacent
author: Kerry Poe
---

# Optimize Bend - Consume Adjacent - EVOLVE Electrical Help

> ## Excerpt
> Optimize Bend - Consume Adjacent. Summary. The Optimize Bends features allow for a streamlined workflow for prefab and design optimization, with less time spent cleaning up groups of bends. With thes…

---
-   [Optimize Bend - Consume Adjacent](https://help-electrical.evolvemep.com/conduit-bends/optimize-bend-consume-adjacent#optimize_bend_consume_adjacent)
    -   [Summary](https://help-electrical.evolvemep.com/conduit-bends/optimize-bend-consume-adjacent#summary)
-   [Usage](https://help-electrical.evolvemep.com/conduit-bends/optimize-bend-consume-adjacent#usage)
    -   [Consume Adjacent Ends](https://help-electrical.evolvemep.com/conduit-bends/optimize-bend-consume-adjacent#consume_adjacent_ends)
-   [Tips and Tricks](https://help-electrical.evolvemep.com/conduit-bends/optimize-bend-consume-adjacent#tips_and_tricks)
    -   [Single Bend Optimization - Hold Shift](https://help-electrical.evolvemep.com/conduit-bends/optimize-bend-consume-adjacent#single_bend_optimization_hold_shift)
-   [Best Practices](https://help-electrical.evolvemep.com/conduit-bends/optimize-bend-consume-adjacent#best_practices)
-   [Videos](https://help-electrical.evolvemep.com/conduit-bends/optimize-bend-consume-adjacent#videos)
-   [Relevant Articles](https://help-electrical.evolvemep.com/conduit-bends/optimize-bend-consume-adjacent#relevant_articles)

### Optimize Bend - Consume Adjacent

![](https://files.helpdocs.io/05s9b4gl38/other/1674124021982/line-2000-gray.png)

#### Summary

The _Optimize Bends_ features allow for a streamlined workflow for prefab and design optimization, with less time spent cleaning up groups of bends. With these new tools, a designer can draw in all of their conduits and smart bends into the project and come back and quickly adjust the smart bends with just a few clicks. Then use the align coupling command, and the entire conduit run is fully modeled with all bends optimized to use a full stick when possible, and all couplings are aligned.

-   **eVolve** tab ⮞ **Conduit Bends** panel ⮞ **Optimize Bend - Consume Adjacent** menu ![](https://files.helpdocs.io/05s9b4gl38/articles/fuvpk2tkp8/1692680743576/optimize-bends-both-ends-32-x-32.png)

![](https://files.helpdocs.io/05s9b4gl38/other/1674124051830/line-2000-gray-dark.png)

### Usage

#### Consume Adjacent Ends

This command will merge the smart bend family with the conduit before and after it to create a one-piece bend. The bend can be as long as the **Max Conduit Length** parameter in the bend families type properties(default is 10').

**Optimizing Groups of Bends**

1.  From the eVolve ribbon, in the **Conduit Bend** panel, click the **Consume Adjacent** button.
2.  From the drawing area, select the desired bends (using window select will only select the smart bends)
3.  From the _Options Bar_, click '**Finish**'

![](https://files.helpdocs.io/05s9b4gl38/other/1674123781789/image.png)

### Tips and Tricks

#### Single Bend Optimization - Hold Shift

The Optimize Bends commands are intended to work with multiple bends by default. Hold SHIFT while clicking the command to optimize a single bend.

![](https://files.helpdocs.io/05s9b4gl38/other/1674123781789/image.png)

### Best Practices

We encourage users to only work with eVolve Bend Families for the best results. When modeling with eVolve Electrical's advanced conduit tools, such as Optimize Bends and Auto-Couplings, we recommend using the following workflow:

1.  Model conduit runs utilizing our smart bend families. (Without adjusting them)
2.  Use Align Conduit when necessary for conduit spacing
3.  Optimize the bends using Consume Selected End and/or Consume Adjacent Ends commands and make any adjustments
4.  Use Align Couplings to align the bend couplings
5.  Use Place Couplings to place couplings along the run (We recommend using the "Change of Direction" option when using this workflow and using steps 2-5 section by section)

![](https://files.helpdocs.io/05s9b4gl38/other/1674123754050/line-2000-gray-dark.png)

### Videos

<iframe src="https://www.youtube.com/embed/SS-RGuOLQyM?feature=oembed" frameborder="0" allow="accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture" allowfullscreen="" aspectratio="0.5625"></iframe>

<iframe src="https://www.youtube.com/embed/Et7PtWXMIng?feature=oembed" frameborder="0" allow="accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture" allowfullscreen="" aspectratio="0.5625"></iframe>

![](https://files.helpdocs.io/05s9b4gl38/articles/9ib0xhr4fs/1623170556915/consume-bends.gif)

![](https://files.helpdocs.io/05s9b4gl38/other/1674124256989/line-2000-black-double.png)

### Relevant Articles

-   [Optimize Bend - Consume And Center](https://evolveelectrical.helpdocs.io/article/gyrvxa3nnm)
-   [Optimize Bend - Consume Selected End](https://evolveelectrical.helpdocs.io/article/9ib0xhr4fs)
-   [Optimize Bend - Move Selected End](https://evolveelectrical.helpdocs.io/article/b5in9bdh03)

___

### How did we do?

___


<!-- Start of Optimize Bend - Consume And Center - EVOLVE Electrical Help.md -->

---
created: 2025-07-25T09:00:14 (UTC -04:00)
tags: []
source: https://help-electrical.evolvemep.com/conduit-bends/optimize-bend-consume-and-center
author: Kerry Poe
---

# Optimize Bend - Consume And Center - EVOLVE Electrical Help

> ## Excerpt
> Optimize Bend - Consume And Center. Summary. The Optimize Bends features allow for a streamlined workflow for prefab and design optimization, with less time spent cleaning up groups of bends. With th…

---
-   [Optimize Bend - Consume And Center](https://help-electrical.evolvemep.com/conduit-bends/optimize-bend-consume-and-center#optimize_bend_consume_and_center)
    -   [Summary](https://help-electrical.evolvemep.com/conduit-bends/optimize-bend-consume-and-center#summary)
-   [Usage](https://help-electrical.evolvemep.com/conduit-bends/optimize-bend-consume-and-center#usage)
    -   [Consume And Center](https://help-electrical.evolvemep.com/conduit-bends/optimize-bend-consume-and-center#consume_and_center)
-   [Tips and Tricks](https://help-electrical.evolvemep.com/conduit-bends/optimize-bend-consume-and-center#tips_and_tricks)
    -   [Single Bend Optimization - Hold Shift](https://help-electrical.evolvemep.com/conduit-bends/optimize-bend-consume-and-center#single_bend_optimization_hold_shift)
-   [Best Practices](https://help-electrical.evolvemep.com/conduit-bends/optimize-bend-consume-and-center#best_practices)
-   [Videos](https://help-electrical.evolvemep.com/conduit-bends/optimize-bend-consume-and-center#videos)
-   [Relevant Articles](https://help-electrical.evolvemep.com/conduit-bends/optimize-bend-consume-and-center#relevant_articles)

### Optimize Bend - Consume And Center

![](https://files.helpdocs.io/05s9b4gl38/other/1674124021982/line-2000-gray.png)

#### Summary

The _Optimize Bends_ features allow for a streamlined workflow for prefab and design optimization, with less time spent cleaning up groups of bends. With these new tools, a designer can draw in all of their conduits and smart bends into the project and come back and quickly adjust the smart bends with just a few clicks. Then use the align coupling command, and the entire conduit run is fully modeled with all bends optimized to use a full stick when possible, and all couplings are aligned.

-   **eVolve** tab ⮞ **Conduit Bends** panel ⮞ **Optimize Bend - Consume Adjacent** menu ⮞ **Consume And Center** button ![](https://files.helpdocs.io/05s9b4gl38/articles/gyrvxa3nnm/1692681567397/optimize-bends-equal-ends-32-x-32.png)

![](https://files.helpdocs.io/05s9b4gl38/other/1674124051830/line-2000-gray-dark.png)

### Usage

#### Consume And Center

This command will merge the smart bend family with the conduit before and after it to create a one-piece bend. The bend can be as long as the **Max Conduit Length** parameter in the bend families type properties(default is 10').

**Optimizing Groups of Bends**

1.  From the eVolve ribbon, in the **Conduit Bend** panel, click the **Optimze Bend - Consume and Center** button.
2.  From the drawing area, select the desired bends (using window select will only select the smart bends)
3.  From the _Options Bar_, click '**Finish**'

![](https://files.helpdocs.io/05s9b4gl38/other/1674123781789/image.png)

### Tips and Tricks

#### Single Bend Optimization - Hold Shift

The Optimize Bends commands are intended to work with multiple bends by default. Hold SHIFT while clicking the command to optimize a single bend.

![](https://files.helpdocs.io/05s9b4gl38/other/1674123781789/image.png)

### Best Practices

We encourage users to only work with eVolve Bend Families for the best results. When modeling with eVolve Electrical's advanced conduit tools, such as Optimize Bends and Auto-Couplings, we recommend using the following workflow:

1.  Model conduit runs utilizing our smart bend families. (Without adjusting them)
2.  Use Align Conduit when necessary for conduit spacing
3.  Optimize the bends using Consume Selected End and/or Consume Adjacent Ends commands and make any adjustments
4.  Use Align Couplings to align the bend couplings
5.  Use Place Couplings to place couplings along the run (We recommend using the "Change of Direction" option when using this workflow and using steps 2-5 section by section)

![](https://files.helpdocs.io/05s9b4gl38/other/1674123754050/line-2000-gray-dark.png)

### Videos

<iframe src="https://www.youtube.com/embed/SS-RGuOLQyM?feature=oembed" frameborder="0" allow="accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture" allowfullscreen="" aspectratio="0.5625"></iframe>

<iframe src="https://www.youtube.com/embed/Et7PtWXMIng?feature=oembed" frameborder="0" allow="accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture" allowfullscreen="" aspectratio="0.5625"></iframe>

![](https://files.helpdocs.io/05s9b4gl38/articles/9ib0xhr4fs/1623170556915/consume-bends.gif)

![](https://files.helpdocs.io/05s9b4gl38/other/1674124256989/line-2000-black-double.png)

### Relevant Articles

-   [Optimize Bend - Consume Selected End](https://evolveelectrical.helpdocs.io/article/9ib0xhr4fs)
-   [Optimize Bend - Move Selected End](https://evolveelectrical.helpdocs.io/article/b5in9bdh03)
-   [Optimize Bend - Consume Adjacent](https://evolveelectrical.helpdocs.io/article/fuvpk2tkp8)

___

### How did we do?

___


<!-- Start of Optimize Bend - Consume Selected End - EVOLVE Electrical Help.md -->

---
created: 2025-07-25T09:00:14 (UTC -04:00)
tags: []
source: https://help-electrical.evolvemep.com/conduit-bends/conduit-bends-optimize-bend
author: 
---

# Optimize Bend - Consume Selected End - EVOLVE Electrical Help

> ## Excerpt
> Optimize Bend - Consume Selected End. Summary. The Optimize Bends features allow for a streamlined workflow for prefab and design optimization, with less time spent cleaning up groups of bends. With…

---
### Optimize Bend - Consume Selected End

![](https://files.helpdocs.io/05s9b4gl38/other/1674124021982/line-2000-gray.png)

#### Summary

The _Optimize Bends_ features allow for a streamlined workflow for prefab and design optimization, with less time spent cleaning up groups of bends. With these new tools, a designer can draw in all of their conduits and smart bends into the project and come back and quickly adjust the smart bends with just a few clicks. Then use the align coupling command, and the entire conduit run is fully modeled with all bends optimized to use a full stick when possible, and all couplings are aligned.

-   **eVolve** tab ⮞ **Conduit Bends** panel ⮞ **Optimize Bend - Consume Selected End** menu ![](https://files.helpdocs.io/05s9b4gl38/articles/9ib0xhr4fs/1692678982402/optimize-bends-single-end-32-x-32.png)

![](https://files.helpdocs.io/05s9b4gl38/other/1674124051830/line-2000-gray-dark.png)

### Usage

#### Consume Selected End

This command will merge the end of a smart bend family with a selected conduit and create a one-piece bend. The bend can be as long as the **Max Conduit Length** parameter in the bend families type properties(default is 10').

1.  From the eVolve ribbon, in the **Conduit Bend** panel, click the **Consume Selected End** button
2.  From the drawing area, select the desired bends (using window select will only select the smart bends)
3.  From the _Options Bar_, click '**Finish**'
4.  From the drawing area, _select the conduits_ in the direction of the merge
5.  From the _Options Bar_, click '**Finish**'

![](https://files.helpdocs.io/05s9b4gl38/other/1674123781789/image.png)

### Tips and Tricks

#### Single Bend Optimization - Hold Shift

The Optimize Bends commands are intended to work with multiple bends by default. Hold SHIFT while clicking the command to optimize a single bend.

![](https://files.helpdocs.io/05s9b4gl38/other/1674123781789/image.png)

### Best Practices

We encourage users to only work with eVolve Bend Families for the best results. When modeling with eVolve Electrical's advanced conduit tools, such as Optimize Bends and Auto-Couplings, we recommend using the following workflow:

1.  Model conduit runs utilizing our smart bend families. (Without adjusting them)
2.  Use Align Conduit when necessary for conduit spacing
3.  Optimize the bends using Consume Selected End and/or Consume Adjacent Ends commands and make any adjustments
4.  Use Align Couplings to align the bend couplings
5.  Use Place Couplings to place couplings along the run (We recommend using the "Change of Direction" option when using this workflow and using steps 2-5 section by section)

![](https://files.helpdocs.io/05s9b4gl38/other/1674123754050/line-2000-gray-dark.png)

### Videos

<iframe src="https://www.youtube.com/embed/SS-RGuOLQyM?feature=oembed" frameborder="0" allow="accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture" allowfullscreen="" aspectratio="0.5625"></iframe>

<iframe src="https://www.youtube.com/embed/Et7PtWXMIng?feature=oembed" frameborder="0" allow="accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture" allowfullscreen="" aspectratio="0.5625"></iframe>

![](https://files.helpdocs.io/05s9b4gl38/articles/9ib0xhr4fs/1623170556915/consume-bends.gif)

![](https://files.helpdocs.io/05s9b4gl38/other/1674124256989/line-2000-black-double.png)

### Relevant Articles

-   [Optimize Bend - Move Selected End](https://evolveelectrical.helpdocs.io/article/b5in9bdh03)
-   [Optimize Bend - Consume Adjacent](https://evolveelectrical.helpdocs.io/article/fuvpk2tkp8)
-   [Optimize Bend - Consume And Center](https://evolveelectrical.helpdocs.io/article/gyrvxa3nnm)

![](https://files.helpdocs.io/05s9b4gl38/articles/9ib0xhr4fs/1695130944025/image.png)

![](https://files.helpdocs.io/05s9b4gl38/articles/9ib0xhr4fs/1695130950609/image.png)

![](https://files.helpdocs.io/05s9b4gl38/articles/9ib0xhr4fs/1695130940622/image.png)

### Optimize Bends - Legacy

The _Optimize Bends_ features allow for a streamlined workflow for prefab and design optimization, with much less time needed to be spent cleaning up groups of bends. With these new tools, a designer can draw in all of their conduits and smart bends into the project and come back and quickly adjust the smart bends with just a few clicks. Then use the align coupling command and the entire conduit run is now fully modeled with all bends optimized to use a full stick when possible and all couplings are aligned.

#### **Consume Adjacent Ends**

This command will make the smart bend family merge with the conduit before and after it to create a one-piece bend. The bend can be as long as the **Max Conduit Length** parameter in the bend families type properties(default is 10').

**Optimizing Groups of Bends**

1.  From the eVolve ribbon, in the **Conduit Bend** panel, click the **Consume Adjacent** button.
2.  From the drawing area, select the desired bends (using window select will only select the smart bends)
3.  From the _Options Bar_, click '**Finish**'

#### **Consume Selected End**

This command will make the end of a smart bend family merge with a selected conduit and create a one-piece bend. The bend can be as long as the **Max Conduit Length** parameter in the bend families type properties(default is 10').

1.  From the eVolve ribbon, in the **Conduit Bend** panel, click the **Consume Selected End** button.
2.  From the drawing area, select the desired bends (using window select will only select the smart bends)
3.  From the _Options Bar_, click '**Finish**'
4.  From the drawing area, _select the conduits_ in the direction of the merge
5.  From the _Options Bar_, click '**Finish**'

**Single Bend Optimization - Hold Shift**

These optimization commands are defaulted to work with groups of bends. To optimize a single bend with either command, hold **shift** while selecting the command.

When modeling with eVolve Electricals advanced conduit tools, such as optimize bends and auto-couplings, we recommend using the following workflow:  
**1.)** **Model** conduit runs utilizing our smart bend families. (Without adjusting them)  
**2.)** Use **Align Conduit** when necessary for conduit spacing  
**3.)** **Optimize the bends** using Consume Selected End and/or Consume Adjacent Ends commands and make any adjustments  
**4.)** Use **Align Couplings** to align the bend couplings  
**5.)** Use **Place Couplings** to place couplings along the run (We recommend using the "Change of Direction" option when using this workflow and using **steps 2-5 section by section**)

_"For best results, we_ _encourage_ _users to only work with eVolve Bend Families."_

<iframe src="https://www.youtube.com/embed/SS-RGuOLQyM?feature=oembed" frameborder="0" allow="accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture" allowfullscreen="" aspectratio="0.5625"></iframe>

<iframe src="https://www.youtube.com/embed/Et7PtWXMIng?feature=oembed" frameborder="0" allow="accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture" allowfullscreen="" aspectratio="0.5625"></iframe>

![](https://files.helpdocs.io/05s9b4gl38/articles/9ib0xhr4fs/1623170556915/consume-bends.gif)


<!-- Start of Optimize Bend - Move Selected End - EVOLVE Electrical Help.md -->

---
created: 2025-07-25T09:00:14 (UTC -04:00)
tags: []
source: https://help-electrical.evolvemep.com/conduit-bends/optimize-bend-consume-and-specify-length
author: Kerry Poe
---

# Optimize Bend - Move Selected End - EVOLVE Electrical Help

> ## Excerpt
> Optimize Bend - Move Selected End. Summary. The Optimize Bends features allow for a streamlined workflow for prefab and design optimization, with less time spent cleaning up groups of bends. With the…

---
-   [Optimize Bend - Move Selected End](https://help-electrical.evolvemep.com/conduit-bends/optimize-bend-consume-and-specify-length#optimize_bend_move_selected_end)
    -   [Summary](https://help-electrical.evolvemep.com/conduit-bends/optimize-bend-consume-and-specify-length#summary)
-   [Usage](https://help-electrical.evolvemep.com/conduit-bends/optimize-bend-consume-and-specify-length#usage)
    -   [Move Selected End](https://help-electrical.evolvemep.com/conduit-bends/optimize-bend-consume-and-specify-length#move_selected_end)
-   [Tips and Tricks](https://help-electrical.evolvemep.com/conduit-bends/optimize-bend-consume-and-specify-length#tips_and_tricks)
    -   [Single Bend Optimization - Hold Shift](https://help-electrical.evolvemep.com/conduit-bends/optimize-bend-consume-and-specify-length#single_bend_optimization_hold_shift)
-   [Best Practices](https://help-electrical.evolvemep.com/conduit-bends/optimize-bend-consume-and-specify-length#best_practices)
-   [Videos](https://help-electrical.evolvemep.com/conduit-bends/optimize-bend-consume-and-specify-length#videos)
-   [Relevant Articles](https://help-electrical.evolvemep.com/conduit-bends/optimize-bend-consume-and-specify-length#relevant_articles)

### Optimize Bend - Move Selected End

![](https://files.helpdocs.io/05s9b4gl38/other/1674124021982/line-2000-gray.png)

#### Summary

The _Optimize Bends_ features allow for a streamlined workflow for prefab and design optimization, with less time spent cleaning up groups of bends. With these new tools, a designer can draw in all of their conduits and smart bends into the project and come back and quickly adjust the smart bends with just a few clicks. Then use the align coupling command, and the entire conduit run is fully modeled with all bends optimized to use a full stick when possible, and all couplings are aligned.

-   **eVolve** tab ⮞ **Conduit Bends** panel ⮞ **Optimize Bend - Consume Adjacent** menu ⮞ **Move Selected End** button![](https://files.helpdocs.io/05s9b4gl38/articles/b5in9bdh03/1692681194355/optimize-bends-single-end-specify-length-32-x-32.png)

![](https://files.helpdocs.io/05s9b4gl38/other/1674124051830/line-2000-gray-dark.png)

### Usage

#### Move Selected End

This command will move 1 end of a smart bend family based on a user defined value. The bend can be as long as the **Max Conduit Length** parameter in the bend families type properties(default is 10').

1.  From the eVolve ribbon, in the **Conduit Bend** panel, click the **Optimze Bend - Consume Selected** button.
2.  From the drawing area, select the desired bends (using window select will only select the smart bends)
3.  From the _Options Bar_, click '**Finish**'
4.  From the drawing area, select the straight conduit from one end of the bend to be moved.
5.  From the _Options Bar_, click '**Finish**'
6.  Define the specific value to move the end.
    1.  Note, enter a negative value to reduce end.

![](https://files.helpdocs.io/05s9b4gl38/other/1674123781789/image.png)

### Tips and Tricks

#### Single Bend Optimization - Hold Shift

The Optimize Bends commands are intended to work with multiple bends by default. Hold SHIFT while clicking the command to optimize a single bend.

![](https://files.helpdocs.io/05s9b4gl38/other/1674123781789/image.png)

### Best Practices

We encourage users to only work with eVolve Bend Families for the best results. When modeling with eVolve Electrical's advanced conduit tools, such as Optimize Bends and Auto-Couplings, we recommend using the following workflow:

1.  Model conduit runs utilizing our smart bend families. (Without adjusting them)
2.  Use Align Conduit when necessary for conduit spacing
3.  Optimize the bends using Consume Selected End and/or Consume Adjacent Ends commands and make any adjustments
4.  Use Align Couplings to align the bend couplings
5.  Use Place Couplings to place couplings along the run (We recommend using the "Change of Direction" option when using this workflow and using steps 2-5 section by section)

![](https://files.helpdocs.io/05s9b4gl38/other/1674123754050/line-2000-gray-dark.png)

### Videos

<iframe src="https://www.youtube.com/embed/SS-RGuOLQyM?feature=oembed" frameborder="0" allow="accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture" allowfullscreen="" aspectratio="0.5625"></iframe>

<iframe src="https://www.youtube.com/embed/Et7PtWXMIng?feature=oembed" frameborder="0" allow="accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture" allowfullscreen="" aspectratio="0.5625"></iframe>

![](https://files.helpdocs.io/05s9b4gl38/articles/9ib0xhr4fs/1623170556915/consume-bends.gif)

![](https://files.helpdocs.io/05s9b4gl38/other/1674124256989/line-2000-black-double.png)

### Relevant Articles

-   [Optimize Bend - Consume Adjacent](https://evolveelectrical.helpdocs.io/article/fuvpk2tkp8)
-   [Optimize Bend - Consume And Center](https://evolveelectrical.helpdocs.io/article/gyrvxa3nnm)
-   [Optimize Bend - Consume Selected End](https://evolveelectrical.helpdocs.io/article/9ib0xhr4fs)

___

### How did we do?

___


<!-- Start of Reset Bends - EVOLVE Electrical Help.md -->

---
created: 2025-07-25T09:00:14 (UTC -04:00)
tags: []
source: https://help-electrical.evolvemep.com/conduit-bends/conduit-bends-refresh-bends
author: Adam Heon
---

# Reset Bends - EVOLVE Electrical Help

> ## Excerpt
> When modelling with the advanced tools provided in eVolve Electrical, such as our optimize bends tools, the occasion may arise where a bend needs to be reverted to its original state (ex.. swapping t…

---
When modelling with the advanced tools provided in eVolve Electrical, such as our optimize bends tools, the occasion may arise where a bend needs to be reverted to its original state (ex.. swapping types or special adjustments). Typically, this requires a lot of clicks and will cause some undesired moves and effects further down the run. With the reset bends tool, any eVolve smart bend family can be reverted back to its original state with just this one command, and to top it off, eVolve will prevent all of those undesired moves and changes down the run.

#### Using The Reset Bends Command

1.  From the eVolve ribbon, in the **Conduit Bends** panel, click **Reset Bends**
2.  From the drawing area, select the desired bends
3.  From the _Options Bar_, click '**Finish**'

![](https://files.helpdocs.io/05s9b4gl38/articles/6dye3n8m0t/1623186752586/reset-bends.gif)

When modeling with eVolve Electricals advanced conduit tools, such as optimize bends and auto-couplings, we recommend using the following workflow: **1.)** **Model** conduit runs utilizing our smart bend families. (Without adjusting them) **2.)** Use **Align Conduit** when necessary for conduit spacing **3.)** **Optimize the bends** using Consume Selected End and/or Consume Adjacent Ends commands and make any adjustments **4.)** Use **Align Couplings** to align the bend couplings **5.)** Use **Place Couplings** to place couplings along the run (We recommend using the "Change of Direction" option when using this workflow and using **steps 2-5 section by section**)

_"For best results, we_ _encourage_ _users to only work with eVolve Bend Families."_

___

### How did we do?

___


<!-- Start of Smart Bend Multi-Trim - EVOLVE Electrical Help.md -->

---
created: 2025-07-25T09:00:14 (UTC -04:00)
tags: []
source: https://help-electrical.evolvemep.com/conduit-bends/smart-bend-multi-trim
author: Kerry Poe
---

# Smart Bend Multi-Trim - EVOLVE Electrical Help

> ## Excerpt
> Smart Bend Multi-Trim. Summary. The Smart Bend Multi-Trim feature adds bends families to allow multi-trimming of families not aligned or on different X,Y, and/or Z planes. This feature connects one o…

---
-   [Smart Bend Multi-Trim](https://help-electrical.evolvemep.com/conduit-bends/smart-bend-multi-trim#smart_bend_multi_trim)
    -   [Summary](https://help-electrical.evolvemep.com/conduit-bends/smart-bend-multi-trim#summary)
-   [Usage](https://help-electrical.evolvemep.com/conduit-bends/smart-bend-multi-trim#usage)
    -   [Using Smart Bend Multi-Trim](https://help-electrical.evolvemep.com/conduit-bends/smart-bend-multi-trim#using_smart_bend_multi_trim)
-   [Tips and Tricks](https://help-electrical.evolvemep.com/conduit-bends/smart-bend-multi-trim#tips_and_tricks)
-   [Relevant Articles](https://help-electrical.evolvemep.com/conduit-bends/smart-bend-multi-trim#relevant_articles)

### Smart Bend Multi-Trim

![](https://files.helpdocs.io/05s9b4gl38/other/1674124021982/line-2000-gray.png)

#### Summary

The Smart Bend Multi-Trim feature adds bends families to allow multi-trimming of families not aligned or on different X,Y, and/or Z planes. This feature connects one or more conduit runs with eVolve Offset or Kick 90 smart bends.

-   **eVolve** tab ⮞ **Conduit Bends** panel ⮞ **Smart Bend** menu ⮞ **Smart Bend Multi-Trim** button ![](https://files.helpdocs.io/05s9b4gl38/articles/aasbalbkxg/1692685748954/smart-bend-multi-trim-32-x-32.png)

![](https://files.helpdocs.io/05s9b4gl38/other/1674124051830/line-2000-gray-dark.png)

### Usage

#### Using Smart Bend Multi-Trim

Must use the following eVolve bend families v8 or higher

-   **Kick 90** - eE\_CN\_Kick\_90\_v8+
-   **Offset** - eE\_CN\_Offset\_v8+

1.  From the eVolve ribbon, in the **Conduit Bends** panel, click **Smart Bend Multi-Trim**.
2.  From the drawing area, select the first runs to trim/extend and click **Finish** from the _Options Bar_.
3.  From the drawing area, select second runs to trim/extend and click **Finish** from the _Options Bar_.

**NOTE**: This feature will require the use of 2-piece bend families. If eVolve detects that a 2-piece bend family is not loaded, users are prompted to load the proper family.

![](https://files.helpdocs.io/05s9b4gl38/other/1674123781789/image.png)

### Tips and Tricks

-   Hold SHIFT to replace a native Revit conduit offset or kick 90 bend with an eVolve Smart Bend.

![](https://files.helpdocs.io/05s9b4gl38/other/1674124256989/line-2000-black-double.png)

### Relevant Articles

-   [Optimize Bend - Move Selected End](https://evolveelectrical.helpdocs.io/article/b5in9bdh03)
-   [Optimize Bend - Consume Adjacent](https://evolveelectrical.helpdocs.io/article/fuvpk2tkp8)
-   [Optimize Bend - Consume And Center](https://evolveelectrical.helpdocs.io/article/gyrvxa3nnm)
-   [Convert to Smart Bend](https://help-electrical.evolvemep.com/article/979n1kuxbi)

___

### How did we do?

___


<!-- Start of Smart Bends - EVOLVE Electrical Help.md -->

---
created: 2025-07-25T08:49:02 (UTC -04:00)
tags: []
source: https://help-electrical.evolvemep.com/settings-category/conduit-bend-settings#tips_and_tricks
author: Adam Heon
---

# Smart Bends - EVOLVE Electrical Help

> ## Excerpt
> Smart Bends. Summary. To further enhance project efficiency and accuracy, the Smart Bends window allows users to choose from many different conduit benders commonly found in the field and add new or…

---
-   [Smart Bends](https://help-electrical.evolvemep.com/settings-category/conduit-bend-settings#smart_bends)
    -   [Summary](https://help-electrical.evolvemep.com/settings-category/conduit-bend-settings#summary)
    -   [Usage](https://help-electrical.evolvemep.com/settings-category/conduit-bend-settings#usage)
        -   [To Add a New Bender:](https://help-electrical.evolvemep.com/settings-category/conduit-bend-settings#to_add_a_new_bender)
        -   [To Add Multiple Benders:](https://help-electrical.evolvemep.com/settings-category/conduit-bend-settings#to_add_multiple_benders)
        -   [To Assign Benders to Conduit Types:](https://help-electrical.evolvemep.com/settings-category/conduit-bend-settings#to_assign_benders_to_conduit_types)
    -   [Window Overview](https://help-electrical.evolvemep.com/settings-category/conduit-bend-settings#window_overview)
    -   [The Bend Lookup Tab](https://help-electrical.evolvemep.com/settings-category/conduit-bend-settings#the_bend_lookup_tab)
        -   [Column headers and groups](https://help-electrical.evolvemep.com/settings-category/conduit-bend-settings#column_headers_and_groups)
        -   [Record Navigator buttons](https://help-electrical.evolvemep.com/settings-category/conduit-bend-settings#record_navigator_buttons)
    -   [The Bend Configuration Tab](https://help-electrical.evolvemep.com/settings-category/conduit-bend-settings#the_bend_configuration_tab)
        -   [Column headers](https://help-electrical.evolvemep.com/settings-category/conduit-bend-settings#column_headers)
        -   [Settings panel](https://help-electrical.evolvemep.com/settings-category/conduit-bend-settings#settings_panel)
        -   [Record Navigator buttons](https://help-electrical.evolvemep.com/settings-category/conduit-bend-settings#record_navigator_buttons_2)
    -   [Tips and Tricks](https://help-electrical.evolvemep.com/settings-category/conduit-bend-settings#tips_and_tricks)

### Smart Bends

![](https://files.helpdocs.io/05s9b4gl38/other/1674124021982/line-2000-gray.png)

#### Summary

To further enhance project efficiency and accuracy, the Smart Bends window allows users to choose from many different conduit benders commonly found in the field and add new or custom benders to be utilized. Like many other features, this one utilizes our powerful grid menus. These menus are highly customizable and allow for on-the-spot editing of bender data. To make this feature even more efficient. Different benders can be assigned for specific diameters of the available conduit types to make this feature even more efficient. These settings can easily be shared by exporting and importing them into a project.

-   **eVolve** tab ⮞ **Resources** panel ⮞ **Settings** menu ⮞ **Smart Bends** button ![](https://files.helpdocs.io/05s9b4gl38/articles/sy04dsiaag/1677763507115/bend-settings-32-x-32.png)

![](https://files.helpdocs.io/05s9b4gl38/other/1674124051830/line-2000-gray-dark.png)

#### Usage

##### To Add a New Bender:

1.  From the _Smart Bends_ window, on the **Bend Lookup** tab, click **Click here to add a new row** located at the top of the grid.
2.  Name the new bender type, then add the appropriate information into the remaining fields. The specific bend values are located in the bender manuals.
3.  Click **Apply** or **OK** to save the bender data into the project settings.

##### To Add Multiple Benders:

1.  From the _Smart Bends_ window, on the **Bend Lookup** tab, click **Export/Import**.
2.  From the menu, click **Export to File**.
3.  Open the new .xml file, locate a section with similar sizes to the new bender, and copy it onto a blank page. Swap out the name and bend data to the new bender.
4.  Copy and paste that section back into the original .xml as an additional bender and save the file.
5.  From the _Smart Bends_ window, on the **Bend Lookup** tab, click **Export/Import**.
6.  From the menu, click **Import from File**.
7.  Click **Apply** or **Ok** to save the bender data into the project settings.

##### To Assign Benders to Conduit Types:

1.  From the _Smart Bends_ window, click the **Bend Configuration** tab.
2.  Select an available **Conduit Type** from the menu and a drop-down will appear below it with the listed benders and diameters they are assigned to for that type.
3.  To make a change, edit the **Bender Type**/Name next to each diameter. Be sure it matches identically to a bender that is listed in the Bend Lookup menu.
4.  Click **Apply or Ok** to save the bender data into the project settings.

![](https://files.helpdocs.io/05s9b4gl38/other/1674124063289/line-2000-gray-dark.png)

#### Window Overview

![](https://files.helpdocs.io/05s9b4gl38/articles/sy04dsiaag/1669042990068/image.png)

-   **Refresh Current View** - updates all smart bends in the active view after modifications have been made to the _Bends Settings_.
-   **Refresh Full Project** - updates all smart bends in the project after modifications have been made to the _Bends Settings_.

#### The Bend Lookup Tab

When adding a _Bender Type_, the following values must be specified for each _Diameter_ of each _Conduit Type_ the desired bender can accommodate in order for eVolve to calculate the bends properly.

##### Column headers and groups

-   **Bender Type** - used to define the make and model of the conduit bender.
-   **Diameter** - used to define the conduit's width measurement.
-   **Conduit Type** - used to identify the conduit's material classification.
-   **Radius** - used to define the desired bend radius
-   **Mark 1** - the minimum distance a bend can start from the end of a conduit.
-   **Deduct** - a measure of the amount the conduit will shrink in length.
-   **X Value** - only applies to offset bends and is used to calculate the Mark 1 value.
-   **Minimum Bend Spacing** fields- defines the smallest allowable distance between two bends before a smaller angle is required.
-   **Pending Action** - displays any unresolved executions.
-   **Error Message** - will inform if there's been an error within the row

##### Record Navigator buttons

-   **Add** - used to add a new row to the grid.
-   **Delete** - used to delete selected row(s).
-   **Duplicate** - used to duplicate selected rows.
-   **Export Grid** - exports the grid as currently displayed to Excel.
-   **Bulk Update** - allows for the values in multiple selected rows to be revised at once.
-   **Send to Data Tables** - send all displayed columns and their values to Data Tables.

![](https://files.helpdocs.io/05s9b4gl38/articles/sy04dsiaag/1646077024956/line-3.png)

#### The Bend Configuration Tab

In Bend Configuration, different benders can be applied to various diameters of multiple conduit types. When modeled, the bends for each type will automatically be created using the assigned bender data.

![](https://files.helpdocs.io/05s9b4gl38/articles/sy04dsiaag/1677762342048/image.png)

##### Column headers

-   **Bender Type** - used to define the make and model of the conduit bender.
-   **Diameter** - used to define the conduit's width measurement.
-   **Conduit Type** - used to identify the conduit's material classification.

##### **Settings** panel

-   **Bend Data Precision** menu - this option changes the returned precision of the bend information parameters. By increasing the precision, eVolve rounds the bend information parameter values to the nearest value set.  
    **NOTE**: This feature does not impact the modeling aspect of the bend family, only the reporting values. Therefore, based on the precision selected, the modeled bend families may not match the reporting values exactly.
-   **Minimum Leftover Length** field - when using the **Optimize Bend - Consume Adjacent** and **Optimize Bend - Consume Selected End** features sets the minimum length a conduit straight can be reduced to. Setting this value to 0 will consume as much of the conduit straight length as possible based on the selected _Smart Bend_.

##### Record Navigator buttons

-   **Add** - used to add a new row to the grid.
-   **Delete** - used to delete selected row(s).
-   **Duplicate** - used to duplicate selected rows.
-   **Export Grid** - exports the grid as currently displayed to Excel.
-   **Bulk Update** - allows for the values in multiple selected rows to be revised at once.
-   **Send to Data Tables** - send all displayed columns and their values to Data Tables.

![](https://files.helpdocs.io/05s9b4gl38/other/1674123781789/image.png)

#### Tips and Tricks

-   **NOTE**: The location of the bend information for benders is typically in the bender manual, on the bender itself, and on the manufacturer's website. We have included the manuals for the benders that are shipped with eVolve in the eVolve resource folder.  
    **Program Files\\eVolve\\eVolve Electrical for Revit "xxxx"\\Resources\\Content\\Product Data\\Conduit Bends**

![](https://files.helpdocs.io/05s9b4gl38/other/1674124256989/line-2000-black-double.png)

___

### How did we do?

___


<!-- Start of User Guides - EVOLVE Electrical Help.md -->

---
created: 2025-07-25T09:00:14 (UTC -04:00)
tags: []
source: https://help-electrical.evolvemep.com/evolve-electrical-user-guides
author: 
---

# User Guides - EVOLVE Electrical Help

> ## Excerpt
> Access in-depth articles about the features contained within eVolve Electrical.

---
[Knowledge Base](https://help-electrical.evolvemep.com/) > User Guides
