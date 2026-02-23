# 📘 Master Index for Stratus GPT Knowledge Base

---

## 1. Stratus Knowledge Base: Five Core Files

- **[combined_STRATUS KB_Company Admin.md](combined_STRATUS%20KB_Company%20Admin.md)**
  - Activities (Admin), Aliases (Admin), App Keys (Admin), Big Data (Admin), Company Roles (Admin), Containers (Admin), Cost Categories (Admin), Cost Types (Admin), Deliverables Definitions (Admin), Divisions (Admin), Fields (Admin), Filters (Admin), Groupings (Admin), Import Mappings (Admin), Materials (Admin), Naming and Numbering (Admin), Notes (Admin), Package Categories (Admin), Part Templates (Admin), Pipe Cuts (Admin), Projects (Admin), Project Roles (Admin), Queries (Admin), Reports (Admin), Service Templates (Admin), Settings (Admin), Station (Admin), Suppliers (Admin), Task Categories (Admin), Task Definitions (Admin), Task Workflows (Admin), Templates (Admin), Tools (Admin), Tracking Statuses (Admin), Users (Admin), View Styles (Admin)

- **[combined_FAQs_General Info_Other.md](combined_FAQs_General%20Info_Other.md)**
  - General User Interface, Issues and Technical How-Tos, Viewer Commonalities, Shop Tool Integrations, Stratus Workstation, RazorGage RG3 and Workstation App, RazorGage RGST, Novarc, HGG ProCAM, PypeServer, PypeServer Connect Cloudinator, Watts 3DPP, T-DRILL, Total Station, Stratus API, SSO for Stratus, Release Notes, Webinars, Stratus FLEX, Stratus Academy, How-to articles, Troubleshooting articles

- **[combined_Project_and_Supplier Admin.md](combined_Project_and_Supplier%20Admin.md)**
  - Project Settings (Project), Team (Admin), Project Divisions (Admin), Supplier Admin

- **[combined_Standard User in Browser.md](combined_Standard%20User%20in%20Browser.md)**
  - Projects, Models, Packages, Assemblies, Containers, Shops, Jobsites, Scan, Help, Account Settings

- **[combined_Stratus Publish Import Addin.md](combined_Stratus%20Publish%20Import%20Addin.md)**
  - Revit Publish and Import, AutoCAD Publish and Import, Publishing Emails, Stratus Lightning, CAMduct / ESTmep Publish and Import

---

## ▶️ Usage Guidance

- **Start by identifying which file contains your topic** (see sub-bullets).
- Each combined file includes a mini-index at the top for fast section navigation (parameters, fields, filters, aliases, reports, settings, etc.).
- For formulas, fields, filters, and scripting, cross-reference with the API & Scripting section of the master index.

---

## 2. eVolve Electrical for Revit (Detailing & Spooling)

- **A. Setup & Workstation**
  - [Installer File Locations & Templates](Evolve_Setup_Templates.md)
  - [Workstation Settings & Options](Evolve_Workstation_Settings.md)

- **B. Best Practices**
  - [eVolve Best Practices](Evolve_Best_Practices.md)

- **C. Containment & Routing**
  - [Creating & Managing Containment](Evolve_Containment_Routing.md)

- **D. Spooling & Fabrication**
  - [Generating Spool Drawings](Evolve_Spool_Drawings.md)

- **E. Publish / Integration Workflow**
  - [Revit ↔ eVolve Synchronization](Evolve_Revit_Evolve_Workflow.md)

- **F. Troubleshooting & Errors**
  - [Spooling & Setup Errors & Fixes](Evolve_Troubleshooting.md)

- **G. Release Notes**
  - [eVolve Electrical Release Notes](Evolve_Release_Notes.md)

---

## 3. API & Scripting

### 3.1 Albatross.Expression Overview
- [Overview & Release Notes](API_Albatross_Overview.md)

### 3.2 Core Types & Builders
- [ExecutionContext (generic)](API_Albatross_ExecutionContext.md)
- [ExecutionContextFactory & ReflectionExecutionContextFactory](API_Albatross_ExecutionContextFactory.md)
- [ExpressionBuilder & Parser](API_Albatross_ExpressionBuilder.md)
- [IParser, Factory, Extensions](API_Albatross_Parser_Factory.md)

### 3.3 Tokens & Delegates
- [Token Interfaces & Assignment Tokens](API_Albatross_Tokens.md)
- [String & Numeric Literal Tokens](API_Albatross_Tokens_Literals.md)
- [TryGetValueDelegate & Variable Tokens](API_Albatross_Variable_Tokens.md)

### 3.4 Exception Types
- [CircularReferenceException & Related Exceptions](API_Albatross_Exceptions.md)

### 3.5 Operations (Formulas / Filters)
- [Boolean, Arithmetic, Date & String Operations](API_Albatross_Operations_Basic.md) – includes formulas/filter guidance
- [Conditional, Array, Coalesce, Comparison Operations](API_Albatross_Operations_Advanced.md)

---

## ▶️ How to Use This Index

When asked a query, Stratus GPT should:

1. Open `INDEX.md` first to find the relevant section.
2. Clearly identify which software (Stratus, eVolve, Revit) and version.
3. Jump to the linked `.md` file for detailed information.
4. If the user asks about formulas, fields or filters, **prioritize** the **Albatross.Expression Operations** section.
5. Provide citations to file names and specific sections (headings) from the docs.
6. If info isn’t found, respond: “I don’t have that info in the knowledge base.”

---