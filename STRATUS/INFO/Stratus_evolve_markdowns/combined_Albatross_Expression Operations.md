---
created: 2025-06-25T06:08:23 (UTC -04:00)
tags: []
source: https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.And.html
author: 
---

# Class And

> ## Excerpt
> Infix AND operation.

---
Infix AND operation.

Operand Count: 2

**Operands**

1.  Operand1 : any
2.  Operand2 : any

The input operands are converted to boolean. See the [ConvertToBoolean(Object)](https://rushuiguan.github.io/expression/api/Albatross.Expression.Extensions.html#Albatross_Expression_Extensions_ConvertToBoolean_System_Object_) method for the conversion logic

Output Type: Boolean

Usage: 3 > 2 and 2 > 1

Precedance: 30

##### Inheritance

System.Object

And

##### Implements

##### Inherited Members

###### **Namespace**: [Albatross.Expression.Operations](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.html)

###### **Assembly**: Albatross.Expression.dll

##### Syntax

```
public class And : InfixOperationToken, IToken
```

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.And.html#properties)Properties

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.And.html#Albatross_Expression_Operations_And_Name)Name

##### Declaration

```
public override string Name { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.String |  |

##### Overrides

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.And.html#Albatross_Expression_Operations_And_Precedence)Precedence

##### Declaration

```
public override int Precedence { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Int32 |  |

##### Overrides

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.And.html#Albatross_Expression_Operations_And_Symbolic)Symbolic

##### Declaration

```
public override bool Symbolic { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |  |

##### Overrides

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.And.html#methods)Methods

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.And.html#Albatross_Expression_Operations_And_EvalValue_System_Func_System_String_System_Object__)EvalValue(Func<String, Object>)

##### Declaration

```
public override object EvalValue(Func<string, object> context)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Func<System.String, System.Object\> | context |  |

##### Returns

| Type | Description |
| --- | --- |
| System.Object |  |

##### Overrides

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.And.html#implements)Implements

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.And.html#extensionmethods)Extension Methods
---
created: 2025-06-25T06:08:23 (UTC -04:00)
tags: []
source: https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Array.html
author: 
---

# Class Array

> ## Excerpt
> Prefix operation that create an object array

---
Prefix operation that create an object array

Operand Count: 0 to infinite

Operand Type: Any

Output Type: System.Collections.Generic.List<T> where T is Object

Usage: @(1, 2, 3, 4, 5)

##### Inheritance

System.Object

Array

##### Implements

##### Inherited Members

###### **Namespace**: [Albatross.Expression.Operations](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.html)

###### **Assembly**: Albatross.Expression.dll

##### Syntax

```
public class Array : PrefixOperationToken, IToken
```

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Array.html#properties)Properties

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Array.html#Albatross_Expression_Operations_Array_MaxOperandCount)MaxOperandCount

##### Declaration

```
public override int MaxOperandCount { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Int32 |  |

##### Overrides

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Array.html#Albatross_Expression_Operations_Array_MinOperandCount)MinOperandCount

##### Declaration

```
public override int MinOperandCount { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Int32 |  |

##### Overrides

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Array.html#Albatross_Expression_Operations_Array_Name)Name

##### Declaration

```
public override string Name { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.String |  |

##### Overrides

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Array.html#Albatross_Expression_Operations_Array_Symbolic)Symbolic

##### Declaration

```
public override bool Symbolic { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |  |

##### Overrides

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Array.html#methods)Methods

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Array.html#Albatross_Expression_Operations_Array_EvalValue_System_Func_System_String_System_Object__)EvalValue(Func<String, Object>)

##### Declaration

```
public override object EvalValue(Func<string, object> context)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Func<System.String, System.Object\> | context |  |

##### Returns

| Type | Description |
| --- | --- |
| System.Object |  |

##### Overrides

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Array.html#implements)Implements

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Array.html#extensionmethods)Extension Methods
---
created: 2025-06-25T06:08:23 (UTC -04:00)
tags: []
source: https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Avg.html
author: 
---

# Class Avg

> ## Excerpt
> Prefix operation that return the average of a set of numbers

---
Prefix operation that return the average of a set of numbers

Operand Count: 0 to infinite

Operand Type: number, if the operand count is 1, it can be an array

Output Type: double

Usage: avg(1, 2, 3, 4, 5) or avg(@(1, 2, 3, 4, 5))

Note: null value will not be counted, therefore avg(null, 2, 2, 2) should be 6/3 = 2 not 6/4 = 1.5; It will return null if the count is 0.

##### Inheritance

System.Object

Avg

##### Implements

##### Inherited Members

###### **Namespace**: [Albatross.Expression.Operations](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.html)

###### **Assembly**: Albatross.Expression.dll

##### Syntax

```
public class Avg : PrefixOperationToken, IToken
```

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Avg.html#properties)Properties

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Avg.html#Albatross_Expression_Operations_Avg_MaxOperandCount)MaxOperandCount

##### Declaration

```
public override int MaxOperandCount { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Int32 |  |

##### Overrides

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Avg.html#Albatross_Expression_Operations_Avg_MinOperandCount)MinOperandCount

##### Declaration

```
public override int MinOperandCount { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Int32 |  |

##### Overrides

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Avg.html#Albatross_Expression_Operations_Avg_Name)Name

##### Declaration

```
public override string Name { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.String |  |

##### Overrides

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Avg.html#Albatross_Expression_Operations_Avg_Symbolic)Symbolic

##### Declaration

```
public override bool Symbolic { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |  |

##### Overrides

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Avg.html#methods)Methods

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Avg.html#Albatross_Expression_Operations_Avg_EvalValue_System_Func_System_String_System_Object__)EvalValue(Func<String, Object>)

##### Declaration

```
public override object EvalValue(Func<string, object> context)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Func<System.String, System.Object\> | context |  |

##### Returns

| Type | Description |
| --- | --- |
| System.Object |  |

##### Overrides

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Avg.html#implements)Implements

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Avg.html#extensionmethods)Extension Methods
---
created: 2025-06-25T06:08:23 (UTC -04:00)
tags: []
source: https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Coalesce.html
author: 
---

# Class Coalesce

> ## Excerpt
> Prefix operation that return the first non null operand

---
Prefix operation that return the first non null operand

Operand Count: 1 to infinite

Operand Type: any

Example: Coalesce(null, 1, 2, 3) will return 1

##### Inheritance

System.Object

Coalesce

##### Implements

##### Inherited Members

###### **Namespace**: [Albatross.Expression.Operations](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.html)

###### **Assembly**: Albatross.Expression.dll

##### Syntax

```
public class Coalesce : PrefixOperationToken, IToken
```

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Coalesce.html#properties)Properties

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Coalesce.html#Albatross_Expression_Operations_Coalesce_MaxOperandCount)MaxOperandCount

##### Declaration

```
public override int MaxOperandCount { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Int32 |  |

##### Overrides

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Coalesce.html#Albatross_Expression_Operations_Coalesce_MinOperandCount)MinOperandCount

##### Declaration

```
public override int MinOperandCount { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Int32 |  |

##### Overrides

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Coalesce.html#Albatross_Expression_Operations_Coalesce_Name)Name

##### Declaration

```
public override string Name { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.String |  |

##### Overrides

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Coalesce.html#Albatross_Expression_Operations_Coalesce_Symbolic)Symbolic

##### Declaration

```
public override bool Symbolic { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |  |

##### Overrides

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Coalesce.html#methods)Methods

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Coalesce.html#Albatross_Expression_Operations_Coalesce_EvalValue_System_Func_System_String_System_Object__)EvalValue(Func<String, Object>)

##### Declaration

```
public override object EvalValue(Func<string, object> context)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Func<System.String, System.Object\> | context |  |

##### Returns

| Type | Description |
| --- | --- |
| System.Object |  |

##### Overrides

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Coalesce.html#implements)Implements

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Coalesce.html#extensionmethods)Extension Methods
---
created: 2025-06-25T06:08:23 (UTC -04:00)
tags: []
source: https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.ComparisonInfixOperation.html
author: 
---

# Class ComparisonInfixOperation

> ## Excerpt
> System.Object

---
##### Inheritance

System.Object

ComparisonInfixOperation

##### Implements

##### Inherited Members

###### **Namespace**: [Albatross.Expression.Operations](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.html)

###### **Assembly**: Albatross.Expression.dll

##### Syntax

```
public abstract class ComparisonInfixOperation : InfixOperationToken, IToken
```

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.ComparisonInfixOperation.html#methods)Methods

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.ComparisonInfixOperation.html#Albatross_Expression_Operations_ComparisonInfixOperation_EvalValue_System_Func_System_String_System_Object__)EvalValue(Func<String, Object>)

##### Declaration

```
public override object EvalValue(Func<string, object> context)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Func<System.String, System.Object\> | context |  |

##### Returns

| Type | Description |
| --- | --- |
| System.Object |  |

##### Overrides

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.ComparisonInfixOperation.html#Albatross_Expression_Operations_ComparisonInfixOperation_interpret_System_Int32_)interpret(Int32)

##### Declaration

```
public abstract bool interpret(int comparisonResult)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | comparisonResult |  |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |  |

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.ComparisonInfixOperation.html#implements)Implements

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.ComparisonInfixOperation.html#extensionmethods)Extension Methods
---
created: 2025-06-25T06:08:23 (UTC -04:00)
tags: []
source: https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.CreateDate.html
author: 
---

# Class CreateDate

> ## Excerpt
> Prefix operation that create an date

---
Prefix operation that create an date

Operand Count: 3

**Operands**

1.  year : double
2.  month : double
3.  day : double

Operand Type: int

Output Type: System.DateTime

Usage: CreateDate(2018, 1, 31)

##### Inheritance

System.Object

CreateDate

##### Implements

##### Inherited Members

###### **Namespace**: [Albatross.Expression.Operations](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.html)

###### **Assembly**: Albatross.Expression.dll

##### Syntax

```
public class CreateDate : PrefixOperationToken, IToken
```

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.CreateDate.html#properties)Properties

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.CreateDate.html#Albatross_Expression_Operations_CreateDate_MaxOperandCount)MaxOperandCount

##### Declaration

```
public override int MaxOperandCount { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Int32 |  |

##### Overrides

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.CreateDate.html#Albatross_Expression_Operations_CreateDate_MinOperandCount)MinOperandCount

##### Declaration

```
public override int MinOperandCount { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Int32 |  |

##### Overrides

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.CreateDate.html#Albatross_Expression_Operations_CreateDate_Name)Name

##### Declaration

```
public override string Name { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.String |  |

##### Overrides

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.CreateDate.html#Albatross_Expression_Operations_CreateDate_Symbolic)Symbolic

##### Declaration

```
public override bool Symbolic { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |  |

##### Overrides

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.CreateDate.html#methods)Methods

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.CreateDate.html#Albatross_Expression_Operations_CreateDate_EvalValue_System_Func_System_String_System_Object__)EvalValue(Func<String, Object>)

##### Declaration

```
public override object EvalValue(Func<string, object> context)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Func<System.String, System.Object\> | context |  |

##### Returns

| Type | Description |
| --- | --- |
| System.Object |  |

##### Overrides

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.CreateDate.html#implements)Implements

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.CreateDate.html#extensionmethods)Extension Methods
---
created: 2025-06-25T06:08:23 (UTC -04:00)
tags: []
source: https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.CurrentApp.html
author: 
---

# Class CurrentApp

> ## Excerpt
> Prefix operation that returns the current app domain friendly name

---
Prefix operation that returns the current app domain friendly name

Operand Count: 0

Output Type: string

##### Inheritance

System.Object

CurrentApp

##### Implements

##### Inherited Members

###### **Namespace**: [Albatross.Expression.Operations](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.html)

###### **Assembly**: Albatross.Expression.dll

##### Syntax

```
public class CurrentApp : PrefixOperationToken, IToken
```

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.CurrentApp.html#properties)Properties

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.CurrentApp.html#Albatross_Expression_Operations_CurrentApp_MaxOperandCount)MaxOperandCount

##### Declaration

```
public override int MaxOperandCount { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Int32 |  |

##### Overrides

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.CurrentApp.html#Albatross_Expression_Operations_CurrentApp_MinOperandCount)MinOperandCount

##### Declaration

```
public override int MinOperandCount { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Int32 |  |

##### Overrides

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.CurrentApp.html#Albatross_Expression_Operations_CurrentApp_Name)Name

##### Declaration

```
public override string Name { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.String |  |

##### Overrides

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.CurrentApp.html#Albatross_Expression_Operations_CurrentApp_Symbolic)Symbolic

##### Declaration

```
public override bool Symbolic { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |  |

##### Overrides

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.CurrentApp.html#methods)Methods

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.CurrentApp.html#Albatross_Expression_Operations_CurrentApp_EvalValue_System_Func_System_String_System_Object__)EvalValue(Func<String, Object>)

##### Declaration

```
public override object EvalValue(Func<string, object> context)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Func<System.String, System.Object\> | context |  |

##### Returns

| Type | Description |
| --- | --- |
| System.Object |  |

##### Overrides

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.CurrentApp.html#implements)Implements

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.CurrentApp.html#extensionmethods)Extension Methods
---
created: 2025-06-25T06:08:23 (UTC -04:00)
tags: []
source: https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.CurrentMachine.html
author: 
---

# Class CurrentMachine

> ## Excerpt
> Prefix operation that returns the current machine host name

---
Prefix operation that returns the current machine host name

Operand Count: 0

Output Type: string

##### Inheritance

System.Object

CurrentMachine

##### Implements

##### Inherited Members

###### **Namespace**: [Albatross.Expression.Operations](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.html)

###### **Assembly**: Albatross.Expression.dll

##### Syntax

```
public class CurrentMachine : PrefixOperationToken, IToken
```

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.CurrentMachine.html#properties)Properties

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.CurrentMachine.html#Albatross_Expression_Operations_CurrentMachine_MaxOperandCount)MaxOperandCount

##### Declaration

```
public override int MaxOperandCount { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Int32 |  |

##### Overrides

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.CurrentMachine.html#Albatross_Expression_Operations_CurrentMachine_MinOperandCount)MinOperandCount

##### Declaration

```
public override int MinOperandCount { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Int32 |  |

##### Overrides

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.CurrentMachine.html#Albatross_Expression_Operations_CurrentMachine_Name)Name

##### Declaration

```
public override string Name { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.String |  |

##### Overrides

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.CurrentMachine.html#Albatross_Expression_Operations_CurrentMachine_Symbolic)Symbolic

##### Declaration

```
public override bool Symbolic { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |  |

##### Overrides

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.CurrentMachine.html#methods)Methods

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.CurrentMachine.html#Albatross_Expression_Operations_CurrentMachine_EvalValue_System_Func_System_String_System_Object__)EvalValue(Func<String, Object>)

##### Declaration

```
public override object EvalValue(Func<string, object> context)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Func<System.String, System.Object\> | context |  |

##### Returns

| Type | Description |
| --- | --- |
| System.Object |  |

##### Overrides

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.CurrentMachine.html#implements)Implements

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.CurrentMachine.html#extensionmethods)Extension Methods
---
created: 2025-06-25T06:08:23 (UTC -04:00)
tags: []
source: https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.CurrentUser.html
author: 
---

# Class CurrentUser

> ## Excerpt
> Prefix operation that returns the current windows user name>

---
Prefix operation that returns the current windows user name>

Operand Count: 0

Output Type: string

##### Inheritance

System.Object

CurrentUser

##### Implements

##### Inherited Members

###### **Namespace**: [Albatross.Expression.Operations](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.html)

###### **Assembly**: Albatross.Expression.dll

##### Syntax

```
public class CurrentUser : PrefixOperationToken, IToken
```

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.CurrentUser.html#properties)Properties

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.CurrentUser.html#Albatross_Expression_Operations_CurrentUser_MaxOperandCount)MaxOperandCount

##### Declaration

```
public override int MaxOperandCount { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Int32 |  |

##### Overrides

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.CurrentUser.html#Albatross_Expression_Operations_CurrentUser_MinOperandCount)MinOperandCount

##### Declaration

```
public override int MinOperandCount { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Int32 |  |

##### Overrides

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.CurrentUser.html#Albatross_Expression_Operations_CurrentUser_Name)Name

##### Declaration

```
public override string Name { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.String |  |

##### Overrides

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.CurrentUser.html#Albatross_Expression_Operations_CurrentUser_Symbolic)Symbolic

##### Declaration

```
public override bool Symbolic { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |  |

##### Overrides

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.CurrentUser.html#methods)Methods

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.CurrentUser.html#Albatross_Expression_Operations_CurrentUser_EvalValue_System_Func_System_String_System_Object__)EvalValue(Func<String, Object>)

##### Declaration

```
public override object EvalValue(Func<string, object> context)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Func<System.String, System.Object\> | context |  |

##### Returns

| Type | Description |
| --- | --- |
| System.Object |  |

##### Overrides

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.CurrentUser.html#implements)Implements

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.CurrentUser.html#extensionmethods)Extension Methods
---
created: 2025-06-25T06:08:23 (UTC -04:00)
tags: []
source: https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Date.html
author: 
---

# Class Date

> ## Excerpt
> Prefix operation that convert input to date.  The operand is converted to text first and parsed to a datetime object

---
Prefix operation that convert input to date. The operand is converted to text first and parsed to a datetime object

Operand Count: 1

**Operands**

1.  input : any

Output Type: System.DateTime

##### Inheritance

System.Object

Date

##### Implements

##### Inherited Members

###### **Namespace**: [Albatross.Expression.Operations](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.html)

###### **Assembly**: Albatross.Expression.dll

##### Syntax

```
public class Date : PrefixOperationToken, IToken
```

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Date.html#properties)Properties

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Date.html#Albatross_Expression_Operations_Date_MaxOperandCount)MaxOperandCount

##### Declaration

```
public override int MaxOperandCount { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Int32 |  |

##### Overrides

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Date.html#Albatross_Expression_Operations_Date_MinOperandCount)MinOperandCount

##### Declaration

```
public override int MinOperandCount { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Int32 |  |

##### Overrides

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Date.html#Albatross_Expression_Operations_Date_Name)Name

##### Declaration

```
public override string Name { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.String |  |

##### Overrides

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Date.html#Albatross_Expression_Operations_Date_Symbolic)Symbolic

##### Declaration

```
public override bool Symbolic { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |  |

##### Overrides

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Date.html#methods)Methods

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Date.html#Albatross_Expression_Operations_Date_EvalValue_System_Func_System_String_System_Object__)EvalValue(Func<String, Object>)

##### Declaration

```
public override object EvalValue(Func<string, object> context)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Func<System.String, System.Object\> | context |  |

##### Returns

| Type | Description |
| --- | --- |
| System.Object |  |

##### Overrides

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Date.html#implements)Implements

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Date.html#extensionmethods)Extension Methods
---
created: 2025-06-25T06:08:23 (UTC -04:00)
tags: []
source: https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Divide.html
author: 
---

# Class Divide

> ## Excerpt
> Infix operation that perform divide

---
Infix operation that perform divide

Operand Count: 2

**Operands**

1.  Operrand1 : double
2.  Operrand2 : double

Output Type: double

##### Inheritance

System.Object

Divide

##### Implements

##### Inherited Members

###### **Namespace**: [Albatross.Expression.Operations](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.html)

###### **Assembly**: Albatross.Expression.dll

##### Syntax

```
public class Divide : InfixOperationToken, IToken
```

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Divide.html#properties)Properties

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Divide.html#Albatross_Expression_Operations_Divide_Name)Name

##### Declaration

```
public override string Name { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.String |  |

##### Overrides

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Divide.html#Albatross_Expression_Operations_Divide_Precedence)Precedence

##### Declaration

```
public override int Precedence { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Int32 |  |

##### Overrides

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Divide.html#Albatross_Expression_Operations_Divide_Symbolic)Symbolic

##### Declaration

```
public override bool Symbolic { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |  |

##### Overrides

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Divide.html#methods)Methods

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Divide.html#Albatross_Expression_Operations_Divide_EvalValue_System_Func_System_String_System_Object__)EvalValue(Func<String, Object>)

##### Declaration

```
public override object EvalValue(Func<string, object> context)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Func<System.String, System.Object\> | context |  |

##### Returns

| Type | Description |
| --- | --- |
| System.Object |  |

##### Overrides

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Divide.html#implements)Implements

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Divide.html#extensionmethods)Extension Methods
---
created: 2025-06-25T06:08:23 (UTC -04:00)
tags: []
source: https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Equal.html
author: 
---

# Class Equal

> ## Excerpt
> Infix operation that perform an equal check

---
Infix operation that perform an equal check

Operand Count: 2

**Operands**

1.  Operrand1 : double
2.  Operrand2 : double

Output Type: double

##### Inheritance

System.Object

Equal

##### Implements

##### Inherited Members

###### **Namespace**: [Albatross.Expression.Operations](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.html)

###### **Assembly**: Albatross.Expression.dll

##### Syntax

```
public class Equal : ComparisonInfixOperation, IToken
```

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Equal.html#properties)Properties

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Equal.html#Albatross_Expression_Operations_Equal_Name)Name

##### Declaration

```
public override string Name { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.String |  |

##### Overrides

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Equal.html#Albatross_Expression_Operations_Equal_Precedence)Precedence

##### Declaration

```
public override int Precedence { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Int32 |  |

##### Overrides

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Equal.html#Albatross_Expression_Operations_Equal_Symbolic)Symbolic

##### Declaration

```
public override bool Symbolic { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |  |

##### Overrides

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Equal.html#methods)Methods

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Equal.html#Albatross_Expression_Operations_Equal_interpret_System_Int32_)interpret(Int32)

##### Declaration

```
public override bool interpret(int comparisonResult)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | comparisonResult |  |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |  |

##### Overrides

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Equal.html#implements)Implements

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Equal.html#extensionmethods)Extension Methods
---
created: 2025-06-25T06:08:23 (UTC -04:00)
tags: []
source: https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Format.html
author: 
---

# Class Format

> ## Excerpt
> Prefix operation that will take an input and C# format string and produced a formatted string

---
Prefix operation that will take an input and C# format string and produced a formatted string

##### Inheritance

System.Object

Format

##### Implements

##### Inherited Members

###### **Namespace**: [Albatross.Expression.Operations](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.html)

###### **Assembly**: Albatross.Expression.dll

##### Syntax

```
public class Format : PrefixOperationToken, IToken
```

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Format.html#properties)Properties

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Format.html#Albatross_Expression_Operations_Format_MaxOperandCount)MaxOperandCount

##### Declaration

```
public override int MaxOperandCount { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Int32 |  |

##### Overrides

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Format.html#Albatross_Expression_Operations_Format_MinOperandCount)MinOperandCount

##### Declaration

```
public override int MinOperandCount { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Int32 |  |

##### Overrides

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Format.html#Albatross_Expression_Operations_Format_Name)Name

##### Declaration

```
public override string Name { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.String |  |

##### Overrides

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Format.html#Albatross_Expression_Operations_Format_Symbolic)Symbolic

##### Declaration

```
public override bool Symbolic { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |  |

##### Overrides

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Format.html#methods)Methods

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Format.html#Albatross_Expression_Operations_Format_EvalValue_System_Func_System_String_System_Object__)EvalValue(Func<String, Object>)

##### Declaration

```
public override object EvalValue(Func<string, object> context)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Func<System.String, System.Object\> | context |  |

##### Returns

| Type | Description |
| --- | --- |
| System.Object |  |

##### Overrides

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Format.html#implements)Implements

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Format.html#extensionmethods)Extension Methods
---
created: 2025-06-25T06:08:23 (UTC -04:00)
tags: []
source: https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.GreaterEqual.html
author: 
---

# Class GreaterEqual

> ## Excerpt
> Infix GreaterEqual operation.

---
Infix GreaterEqual operation.

Operand Count: 2

**Operands**

1.  Operand1 : any
2.  Operand2 : any

Output Type: Boolean

Usage: 3 >= 2

Precedance: 50

##### Inheritance

System.Object

GreaterEqual

##### Implements

##### Inherited Members

###### **Namespace**: [Albatross.Expression.Operations](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.html)

###### **Assembly**: Albatross.Expression.dll

##### Syntax

```
public class GreaterEqual : ComparisonInfixOperation, IToken
```

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.GreaterEqual.html#properties)Properties

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.GreaterEqual.html#Albatross_Expression_Operations_GreaterEqual_Name)Name

##### Declaration

```
public override string Name { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.String |  |

##### Overrides

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.GreaterEqual.html#Albatross_Expression_Operations_GreaterEqual_Precedence)Precedence

##### Declaration

```
public override int Precedence { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Int32 |  |

##### Overrides

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.GreaterEqual.html#Albatross_Expression_Operations_GreaterEqual_Symbolic)Symbolic

##### Declaration

```
public override bool Symbolic { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |  |

##### Overrides

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.GreaterEqual.html#methods)Methods

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.GreaterEqual.html#Albatross_Expression_Operations_GreaterEqual_interpret_System_Int32_)interpret(Int32)

##### Declaration

```
public override bool interpret(int comparisonResult)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | comparisonResult |  |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |  |

##### Overrides

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.GreaterEqual.html#implements)Implements

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.GreaterEqual.html#extensionmethods)Extension Methods
---
created: 2025-06-25T06:08:23 (UTC -04:00)
tags: []
source: https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.GreaterThan.html
author: 
---

# Class GreaterThan

> ## Excerpt
> Infix GreaterThan operation.

---
Infix GreaterThan operation.

Operand Count: 2

**Operands**

1.  Operand1 : any
2.  Operand2 : any

Output Type: Boolean

Usage: 3 > 2

Precedance: 50

##### Inheritance

System.Object

GreaterThan

##### Implements

##### Inherited Members

###### **Namespace**: [Albatross.Expression.Operations](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.html)

###### **Assembly**: Albatross.Expression.dll

##### Syntax

```
public class GreaterThan : ComparisonInfixOperation, IToken
```

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.GreaterThan.html#properties)Properties

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.GreaterThan.html#Albatross_Expression_Operations_GreaterThan_Name)Name

##### Declaration

```
public override string Name { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.String |  |

##### Overrides

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.GreaterThan.html#Albatross_Expression_Operations_GreaterThan_Precedence)Precedence

##### Declaration

```
public override int Precedence { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Int32 |  |

##### Overrides

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.GreaterThan.html#Albatross_Expression_Operations_GreaterThan_Symbolic)Symbolic

##### Declaration

```
public override bool Symbolic { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |  |

##### Overrides

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.GreaterThan.html#methods)Methods

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.GreaterThan.html#Albatross_Expression_Operations_GreaterThan_interpret_System_Int32_)interpret(Int32)

##### Declaration

```
public override bool interpret(int comparisonResult)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | comparisonResult |  |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |  |

##### Overrides

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.GreaterThan.html#Albatross_Expression_Operations_GreaterThan_Match_System_String_System_Int32_System_Int32__)Match(String, Int32, out Int32)

##### Declaration

```
public override bool Match(string expression, int start, out int next)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | expression |  |
| System.Int32 | start |  |
| System.Int32 | next |  |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |  |

##### Overrides

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.GreaterThan.html#implements)Implements

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.GreaterThan.html#extensionmethods)Extension Methods
---
created: 2025-06-25T06:08:23 (UTC -04:00)
tags: []
source: https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.If.html
author: 
---

# Class If

> ## Excerpt
> Prefix if operation

---
Prefix if operation

Operand Count: 2 or 3

**Operands**

1.  condition: any
2.  result when true: any
3.  result when false, if omitted, will be default to null: any

Output Type: any

Usage: if( 3 > 2, "OK", "No")

##### Inheritance

System.Object

If

##### Implements

##### Inherited Members

###### **Namespace**: [Albatross.Expression.Operations](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.html)

###### **Assembly**: Albatross.Expression.dll

##### Syntax

```
public class If : PrefixOperationToken, IToken
```

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.If.html#properties)Properties

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.If.html#Albatross_Expression_Operations_If_MaxOperandCount)MaxOperandCount

##### Declaration

```
public override int MaxOperandCount { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Int32 |  |

##### Overrides

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.If.html#Albatross_Expression_Operations_If_MinOperandCount)MinOperandCount

##### Declaration

```
public override int MinOperandCount { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Int32 |  |

##### Overrides

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.If.html#Albatross_Expression_Operations_If_Name)Name

##### Declaration

```
public override string Name { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.String |  |

##### Overrides

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.If.html#Albatross_Expression_Operations_If_Symbolic)Symbolic

##### Declaration

```
public override bool Symbolic { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |  |

##### Overrides

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.If.html#methods)Methods

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.If.html#Albatross_Expression_Operations_If_EvalValue_System_Func_System_String_System_Object__)EvalValue(Func<String, Object>)

##### Declaration

```
public override object EvalValue(Func<string, object> context)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Func<System.String, System.Object\> | context |  |

##### Returns

| Type | Description |
| --- | --- |
| System.Object |  |

##### Overrides

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.If.html#implements)Implements

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.If.html#extensionmethods)Extension Methods
---
created: 2025-06-25T06:08:23 (UTC -04:00)
tags: []
source: https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.IsBlank.html
author: 
---

# Class IsBlank

> ## Excerpt
> Prefix operation to check if the input IsBlank

---
Prefix operation to check if the input IsBlank

Operand Type: any

Null, empty string and string with only white space are considered as blank

##### Inheritance

System.Object

IsBlank

##### Implements

##### Inherited Members

###### **Namespace**: [Albatross.Expression.Operations](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.html)

###### **Assembly**: Albatross.Expression.dll

##### Syntax

```
public class IsBlank : PrefixOperationToken, IToken
```

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.IsBlank.html#properties)Properties

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.IsBlank.html#Albatross_Expression_Operations_IsBlank_MaxOperandCount)MaxOperandCount

##### Declaration

```
public override int MaxOperandCount { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Int32 |  |

##### Overrides

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.IsBlank.html#Albatross_Expression_Operations_IsBlank_MinOperandCount)MinOperandCount

##### Declaration

```
public override int MinOperandCount { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Int32 |  |

##### Overrides

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.IsBlank.html#Albatross_Expression_Operations_IsBlank_Name)Name

##### Declaration

```
public override string Name { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.String |  |

##### Overrides

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.IsBlank.html#Albatross_Expression_Operations_IsBlank_Symbolic)Symbolic

##### Declaration

```
public override bool Symbolic { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |  |

##### Overrides

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.IsBlank.html#methods)Methods

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.IsBlank.html#Albatross_Expression_Operations_IsBlank_EvalValue_System_Func_System_String_System_Object__)EvalValue(Func<String, Object>)

##### Declaration

```
public override object EvalValue(Func<string, object> context)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Func<System.String, System.Object\> | context |  |

##### Returns

| Type | Description |
| --- | --- |
| System.Object |  |

##### Overrides

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.IsBlank.html#implements)Implements

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.IsBlank.html#extensionmethods)Extension Methods
---
created: 2025-06-25T06:08:24 (UTC -04:00)
tags: []
source: https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Left.html
author: 
---

# Class Left

> ## Excerpt
> Prefix operation that return the substring of the input text with the specified length and start index of 0

---
Prefix operation that return the substring of the input text with the specified length and start index of 0

Operand Count: 2

**Operands**

1.  input: string
2.  count: double

Output Type: string

Usage: Left("test", 1) should return "t"

##### Inheritance

System.Object

Left

##### Implements

##### Inherited Members

###### **Namespace**: [Albatross.Expression.Operations](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.html)

###### **Assembly**: Albatross.Expression.dll

##### Syntax

```
public class Left : PrefixOperationToken, IToken
```

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Left.html#properties)Properties

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Left.html#Albatross_Expression_Operations_Left_MaxOperandCount)MaxOperandCount

##### Declaration

```
public override int MaxOperandCount { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Int32 |  |

##### Overrides

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Left.html#Albatross_Expression_Operations_Left_MinOperandCount)MinOperandCount

##### Declaration

```
public override int MinOperandCount { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Int32 |  |

##### Overrides

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Left.html#Albatross_Expression_Operations_Left_Name)Name

##### Declaration

```
public override string Name { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.String |  |

##### Overrides

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Left.html#Albatross_Expression_Operations_Left_Symbolic)Symbolic

##### Declaration

```
public override bool Symbolic { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |  |

##### Overrides

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Left.html#methods)Methods

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Left.html#Albatross_Expression_Operations_Left_EvalValue_System_Func_System_String_System_Object__)EvalValue(Func<String, Object>)

##### Declaration

```
public override object EvalValue(Func<string, object> context)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Func<System.String, System.Object\> | context |  |

##### Returns

| Type | Description |
| --- | --- |
| System.Object |  |

##### Overrides

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Left.html#implements)Implements

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Left.html#extensionmethods)Extension Methods
---
created: 2025-06-25T06:08:23 (UTC -04:00)
tags: []
source: https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Len.html
author: 
---

# Class Len

> ## Excerpt
> System.Object

---
##### Inheritance

System.Object

Len

##### Implements

##### Inherited Members

###### **Namespace**: [Albatross.Expression.Operations](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.html)

###### **Assembly**: Albatross.Expression.dll

##### Syntax

```
public class Len : PrefixOperationToken, IToken
```

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Len.html#properties)Properties

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Len.html#Albatross_Expression_Operations_Len_MaxOperandCount)MaxOperandCount

##### Declaration

```
public override int MaxOperandCount { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Int32 |  |

##### Overrides

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Len.html#Albatross_Expression_Operations_Len_MinOperandCount)MinOperandCount

##### Declaration

```
public override int MinOperandCount { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Int32 |  |

##### Overrides

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Len.html#Albatross_Expression_Operations_Len_Name)Name

##### Declaration

```
public override string Name { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.String |  |

##### Overrides

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Len.html#Albatross_Expression_Operations_Len_Symbolic)Symbolic

##### Declaration

```
public override bool Symbolic { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |  |

##### Overrides

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Len.html#methods)Methods

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Len.html#Albatross_Expression_Operations_Len_EvalValue_System_Func_System_String_System_Object__)EvalValue(Func<String, Object>)

##### Declaration

```
public override object EvalValue(Func<string, object> context)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Func<System.String, System.Object\> | context |  |

##### Returns

| Type | Description |
| --- | --- |
| System.Object |  |

##### Overrides

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Len.html#implements)Implements

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Len.html#extensionmethods)Extension Methods
---
created: 2025-06-25T06:08:23 (UTC -04:00)
tags: []
source: https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.LessEqual.html
author: 
---

# Class LessEqual

> ## Excerpt
> System.Object

---
##### Inheritance

System.Object

LessEqual

##### Implements

##### Inherited Members

###### **Namespace**: [Albatross.Expression.Operations](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.html)

###### **Assembly**: Albatross.Expression.dll

##### Syntax

```
public class LessEqual : ComparisonInfixOperation, IToken
```

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.LessEqual.html#properties)Properties

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.LessEqual.html#Albatross_Expression_Operations_LessEqual_Name)Name

##### Declaration

```
public override string Name { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.String |  |

##### Overrides

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.LessEqual.html#Albatross_Expression_Operations_LessEqual_Precedence)Precedence

##### Declaration

```
public override int Precedence { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Int32 |  |

##### Overrides

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.LessEqual.html#Albatross_Expression_Operations_LessEqual_Symbolic)Symbolic

##### Declaration

```
public override bool Symbolic { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |  |

##### Overrides

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.LessEqual.html#methods)Methods

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.LessEqual.html#Albatross_Expression_Operations_LessEqual_interpret_System_Int32_)interpret(Int32)

##### Declaration

```
public override bool interpret(int comparisonResult)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | comparisonResult |  |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |  |

##### Overrides

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.LessEqual.html#implements)Implements

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.LessEqual.html#extensionmethods)Extension Methods
---
created: 2025-06-25T06:08:24 (UTC -04:00)
tags: []
source: https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.LessThan.html
author: 
---

# Class LessThan

> ## Excerpt
> System.Object

---
##### Inheritance

System.Object

LessThan

##### Implements

##### Inherited Members

###### **Namespace**: [Albatross.Expression.Operations](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.html)

###### **Assembly**: Albatross.Expression.dll

##### Syntax

```
public class LessThan : ComparisonInfixOperation, IToken
```

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.LessThan.html#properties)Properties

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.LessThan.html#Albatross_Expression_Operations_LessThan_Name)Name

##### Declaration

```
public override string Name { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.String |  |

##### Overrides

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.LessThan.html#Albatross_Expression_Operations_LessThan_Precedence)Precedence

##### Declaration

```
public override int Precedence { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Int32 |  |

##### Overrides

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.LessThan.html#Albatross_Expression_Operations_LessThan_Symbolic)Symbolic

##### Declaration

```
public override bool Symbolic { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |  |

##### Overrides

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.LessThan.html#methods)Methods

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.LessThan.html#Albatross_Expression_Operations_LessThan_interpret_System_Int32_)interpret(Int32)

##### Declaration

```
public override bool interpret(int comparisonResult)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | comparisonResult |  |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |  |

##### Overrides

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.LessThan.html#Albatross_Expression_Operations_LessThan_Match_System_String_System_Int32_System_Int32__)Match(String, Int32, out Int32)

##### Declaration

```
public override bool Match(string expression, int start, out int next)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | expression |  |
| System.Int32 | start |  |
| System.Int32 | next |  |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |  |

##### Overrides

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.LessThan.html#implements)Implements

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.LessThan.html#extensionmethods)Extension Methods
---
created: 2025-06-25T06:08:24 (UTC -04:00)
tags: []
source: https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Max.html
author: 
---

# Class Max

> ## Excerpt
> System.Object

---
##### Inheritance

System.Object

Max

##### Implements

##### Inherited Members

###### **Namespace**: [Albatross.Expression.Operations](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.html)

###### **Assembly**: Albatross.Expression.dll

##### Syntax

```
public class Max : PrefixOperationToken, IToken
```

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Max.html#properties)Properties

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Max.html#Albatross_Expression_Operations_Max_MaxOperandCount)MaxOperandCount

##### Declaration

```
public override int MaxOperandCount { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Int32 |  |

##### Overrides

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Max.html#Albatross_Expression_Operations_Max_MinOperandCount)MinOperandCount

##### Declaration

```
public override int MinOperandCount { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Int32 |  |

##### Overrides

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Max.html#Albatross_Expression_Operations_Max_Name)Name

##### Declaration

```
public override string Name { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.String |  |

##### Overrides

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Max.html#Albatross_Expression_Operations_Max_Symbolic)Symbolic

##### Declaration

```
public override bool Symbolic { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |  |

##### Overrides

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Max.html#methods)Methods

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Max.html#Albatross_Expression_Operations_Max_EvalValue_System_Func_System_String_System_Object__)EvalValue(Func<String, Object>)

##### Declaration

```
public override object EvalValue(Func<string, object> context)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Func<System.String, System.Object\> | context |  |

##### Returns

| Type | Description |
| --- | --- |
| System.Object |  |

##### Overrides

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Max.html#Albatross_Expression_Operations_Max_GetMax__1_System_Collections_IEnumerable_)GetMax<T>(IEnumerable)

##### Declaration

```
public static object GetMax<T>(IEnumerable list)

    where T : struct
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Collections.IEnumerable | list |  |

##### Returns

| Type | Description |
| --- | --- |
| System.Object |  |

##### Type Parameters

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Max.html#Albatross_Expression_Operations_Max_GetMaxString_System_Collections_IEnumerable_)GetMaxString(IEnumerable)

##### Declaration

```
public static object GetMaxString(IEnumerable list)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Collections.IEnumerable | list |  |

##### Returns

| Type | Description |
| --- | --- |
| System.Object |  |

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Max.html#implements)Implements

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Max.html#extensionmethods)Extension Methods
---
created: 2025-06-25T06:08:23 (UTC -04:00)
tags: []
source: https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Min.html
author: 
---

# Class Min

> ## Excerpt
> System.Object

---
##### Inheritance

System.Object

Min

##### Implements

##### Inherited Members

###### **Namespace**: [Albatross.Expression.Operations](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.html)

###### **Assembly**: Albatross.Expression.dll

##### Syntax

```
public class Min : PrefixOperationToken, IToken
```

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Min.html#properties)Properties

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Min.html#Albatross_Expression_Operations_Min_MaxOperandCount)MaxOperandCount

##### Declaration

```
public override int MaxOperandCount { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Int32 |  |

##### Overrides

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Min.html#Albatross_Expression_Operations_Min_MinOperandCount)MinOperandCount

##### Declaration

```
public override int MinOperandCount { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Int32 |  |

##### Overrides

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Min.html#Albatross_Expression_Operations_Min_Name)Name

##### Declaration

```
public override string Name { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.String |  |

##### Overrides

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Min.html#Albatross_Expression_Operations_Min_Symbolic)Symbolic

##### Declaration

```
public override bool Symbolic { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |  |

##### Overrides

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Min.html#methods)Methods

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Min.html#Albatross_Expression_Operations_Min_EvalValue_System_Func_System_String_System_Object__)EvalValue(Func<String, Object>)

##### Declaration

```
public override object EvalValue(Func<string, object> context)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Func<System.String, System.Object\> | context |  |

##### Returns

| Type | Description |
| --- | --- |
| System.Object |  |

##### Overrides

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Min.html#Albatross_Expression_Operations_Min_GetMin__1_System_Collections_IEnumerable_)GetMin<T>(IEnumerable)

##### Declaration

```
public static object GetMin<T>(IEnumerable list)

    where T : struct
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Collections.IEnumerable | list |  |

##### Returns

| Type | Description |
| --- | --- |
| System.Object |  |

##### Type Parameters

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Min.html#Albatross_Expression_Operations_Min_GetMinString_System_Collections_IEnumerable_)GetMinString(IEnumerable)

##### Declaration

```
public static object GetMinString(IEnumerable list)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Collections.IEnumerable | list |  |

##### Returns

| Type | Description |
| --- | --- |
| System.Object |  |

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Min.html#implements)Implements

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Min.html#extensionmethods)Extension Methods
---
created: 2025-06-25T06:08:23 (UTC -04:00)
tags: []
source: https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Minus.html
author: 
---

# Class Minus

> ## Excerpt
> System.Object

---
##### Inheritance

System.Object

Minus

##### Implements

##### Inherited Members

###### **Namespace**: [Albatross.Expression.Operations](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.html)

###### **Assembly**: Albatross.Expression.dll

##### Syntax

```
public class Minus : InfixOperationToken, IToken
```

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Minus.html#properties)Properties

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Minus.html#Albatross_Expression_Operations_Minus_Name)Name

##### Declaration

```
public override string Name { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.String |  |

##### Overrides

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Minus.html#Albatross_Expression_Operations_Minus_Precedence)Precedence

##### Declaration

```
public override int Precedence { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Int32 |  |

##### Overrides

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Minus.html#Albatross_Expression_Operations_Minus_Symbolic)Symbolic

##### Declaration

```
public override bool Symbolic { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |  |

##### Overrides

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Minus.html#methods)Methods

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Minus.html#Albatross_Expression_Operations_Minus_EvalValue_System_Func_System_String_System_Object__)EvalValue(Func<String, Object>)

##### Declaration

```
public override object EvalValue(Func<string, object> context)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Func<System.String, System.Object\> | context |  |

##### Returns

| Type | Description |
| --- | --- |
| System.Object |  |

##### Overrides

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Minus.html#implements)Implements

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Minus.html#extensionmethods)Extension Methods
---
created: 2025-06-25T06:08:24 (UTC -04:00)
tags: []
source: https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Mod.html
author: 
---

# Class Mod

> ## Excerpt
> Infix operation that perform an mod operation

---
Infix operation that perform an mod operation

Operand Count: 2

**Operands**

1.  Operrand1 : double
2.  Operrand2 : double

Output Type: double

##### Inheritance

System.Object

Mod

##### Implements

##### Inherited Members

###### **Namespace**: [Albatross.Expression.Operations](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.html)

###### **Assembly**: Albatross.Expression.dll

##### Syntax

```
public class Mod : InfixOperationToken, IToken
```

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Mod.html#properties)Properties

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Mod.html#Albatross_Expression_Operations_Mod_Name)Name

##### Declaration

```
public override string Name { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.String |  |

##### Overrides

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Mod.html#Albatross_Expression_Operations_Mod_Precedence)Precedence

##### Declaration

```
public override int Precedence { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Int32 |  |

##### Overrides

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Mod.html#Albatross_Expression_Operations_Mod_Symbolic)Symbolic

##### Declaration

```
public override bool Symbolic { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |  |

##### Overrides

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Mod.html#methods)Methods

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Mod.html#Albatross_Expression_Operations_Mod_EvalValue_System_Func_System_String_System_Object__)EvalValue(Func<String, Object>)

##### Declaration

```
public override object EvalValue(Func<string, object> context)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Func<System.String, System.Object\> | context |  |

##### Returns

| Type | Description |
| --- | --- |
| System.Object |  |

##### Overrides

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Mod.html#implements)Implements

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Mod.html#extensionmethods)Extension Methods
---
created: 2025-06-25T06:08:24 (UTC -04:00)
tags: []
source: https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Month.html
author: 
---

# Class Month

> ## Excerpt
> System.Object

---
##### Inheritance

System.Object

Month

##### Implements

##### Inherited Members

###### **Namespace**: [Albatross.Expression.Operations](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.html)

###### **Assembly**: Albatross.Expression.dll

##### Syntax

```
public class Month : PrefixOperationToken, IToken
```

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Month.html#properties)Properties

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Month.html#Albatross_Expression_Operations_Month_MaxOperandCount)MaxOperandCount

##### Declaration

```
public override int MaxOperandCount { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Int32 |  |

##### Overrides

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Month.html#Albatross_Expression_Operations_Month_MinOperandCount)MinOperandCount

##### Declaration

```
public override int MinOperandCount { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Int32 |  |

##### Overrides

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Month.html#Albatross_Expression_Operations_Month_Name)Name

##### Declaration

```
public override string Name { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.String |  |

##### Overrides

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Month.html#Albatross_Expression_Operations_Month_Symbolic)Symbolic

##### Declaration

```
public override bool Symbolic { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |  |

##### Overrides

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Month.html#methods)Methods

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Month.html#Albatross_Expression_Operations_Month_EvalValue_System_Func_System_String_System_Object__)EvalValue(Func<String, Object>)

##### Declaration

```
public override object EvalValue(Func<string, object> context)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Func<System.String, System.Object\> | context |  |

##### Returns

| Type | Description |
| --- | --- |
| System.Object |  |

##### Overrides

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Month.html#implements)Implements

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Month.html#extensionmethods)Extension Methods
---
created: 2025-06-25T06:08:23 (UTC -04:00)
tags: []
source: https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.MonthName.html
author: 
---

# Class MonthName

> ## Excerpt
> System.Object

---
##### Inheritance

System.Object

MonthName

##### Implements

##### Inherited Members

###### **Namespace**: [Albatross.Expression.Operations](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.html)

###### **Assembly**: Albatross.Expression.dll

##### Syntax

```
public class MonthName : PrefixOperationToken, IToken
```

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.MonthName.html#properties)Properties

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.MonthName.html#Albatross_Expression_Operations_MonthName_MaxOperandCount)MaxOperandCount

##### Declaration

```
public override int MaxOperandCount { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Int32 |  |

##### Overrides

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.MonthName.html#Albatross_Expression_Operations_MonthName_MinOperandCount)MinOperandCount

##### Declaration

```
public override int MinOperandCount { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Int32 |  |

##### Overrides

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.MonthName.html#Albatross_Expression_Operations_MonthName_Name)Name

##### Declaration

```
public override string Name { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.String |  |

##### Overrides

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.MonthName.html#Albatross_Expression_Operations_MonthName_Symbolic)Symbolic

##### Declaration

```
public override bool Symbolic { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |  |

##### Overrides

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.MonthName.html#methods)Methods

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.MonthName.html#Albatross_Expression_Operations_MonthName_EvalValue_System_Func_System_String_System_Object__)EvalValue(Func<String, Object>)

##### Declaration

```
public override object EvalValue(Func<string, object> context)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Func<System.String, System.Object\> | context |  |

##### Returns

| Type | Description |
| --- | --- |
| System.Object |  |

##### Overrides

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.MonthName.html#implements)Implements

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.MonthName.html#extensionmethods)Extension Methods
---
created: 2025-06-25T06:08:23 (UTC -04:00)
tags: []
source: https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Multiply.html
author: 
---

# Class Multiply

> ## Excerpt
> Infix operation that perform an multiply operation

---
Infix operation that perform an multiply operation

Operand Count: 2

**Operands**

1.  Operrand1 : double
2.  Operrand2 : double

Output Type: double

##### Inheritance

System.Object

Multiply

##### Implements

##### Inherited Members

###### **Namespace**: [Albatross.Expression.Operations](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.html)

###### **Assembly**: Albatross.Expression.dll

##### Syntax

```
public class Multiply : InfixOperationToken, IToken
```

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Multiply.html#properties)Properties

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Multiply.html#Albatross_Expression_Operations_Multiply_Name)Name

##### Declaration

```
public override string Name { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.String |  |

##### Overrides

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Multiply.html#Albatross_Expression_Operations_Multiply_Precedence)Precedence

##### Declaration

```
public override int Precedence { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Int32 |  |

##### Overrides

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Multiply.html#Albatross_Expression_Operations_Multiply_Symbolic)Symbolic

##### Declaration

```
public override bool Symbolic { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |  |

##### Overrides

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Multiply.html#methods)Methods

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Multiply.html#Albatross_Expression_Operations_Multiply_EvalValue_System_Func_System_String_System_Object__)EvalValue(Func<String, Object>)

##### Declaration

```
public override object EvalValue(Func<string, object> context)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Func<System.String, System.Object\> | context |  |

##### Returns

| Type | Description |
| --- | --- |
| System.Object |  |

##### Overrides

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Multiply.html#implements)Implements

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Multiply.html#extensionmethods)Extension Methods
---
created: 2025-06-25T06:08:24 (UTC -04:00)
tags: []
source: https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Negative.html
author: 
---

# Class Negative

> ## Excerpt
> System.Object

---
##### Inheritance

System.Object

Negative

##### Implements

##### Inherited Members

###### **Namespace**: [Albatross.Expression.Operations](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.html)

###### **Assembly**: Albatross.Expression.dll

##### Syntax

```
public class Negative : PrefixOperationToken, IToken
```

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Negative.html#properties)Properties

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Negative.html#Albatross_Expression_Operations_Negative_MaxOperandCount)MaxOperandCount

##### Declaration

```
public override int MaxOperandCount { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Int32 |  |

##### Overrides

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Negative.html#Albatross_Expression_Operations_Negative_MinOperandCount)MinOperandCount

##### Declaration

```
public override int MinOperandCount { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Int32 |  |

##### Overrides

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Negative.html#Albatross_Expression_Operations_Negative_Name)Name

##### Declaration

```
public override string Name { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.String |  |

##### Overrides

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Negative.html#Albatross_Expression_Operations_Negative_Symbolic)Symbolic

##### Declaration

```
public override bool Symbolic { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |  |

##### Overrides

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Negative.html#methods)Methods

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Negative.html#Albatross_Expression_Operations_Negative_EvalValue_System_Func_System_String_System_Object__)EvalValue(Func<String, Object>)

##### Declaration

```
public override object EvalValue(Func<string, object> context)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Func<System.String, System.Object\> | context |  |

##### Returns

| Type | Description |
| --- | --- |
| System.Object |  |

##### Overrides

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Negative.html#implements)Implements

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Negative.html#extensionmethods)Extension Methods
---
created: 2025-06-25T06:08:24 (UTC -04:00)
tags: []
source: https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Not.html
author: 
---

# Class Not

> ## Excerpt
> System.Object

---
##### Inheritance

System.Object

Not

##### Implements

##### Inherited Members

###### **Namespace**: [Albatross.Expression.Operations](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.html)

###### **Assembly**: Albatross.Expression.dll

##### Syntax

```
public class Not : PrefixOperationToken, IToken
```

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Not.html#properties)Properties

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Not.html#Albatross_Expression_Operations_Not_MaxOperandCount)MaxOperandCount

##### Declaration

```
public override int MaxOperandCount { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Int32 |  |

##### Overrides

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Not.html#Albatross_Expression_Operations_Not_MinOperandCount)MinOperandCount

##### Declaration

```
public override int MinOperandCount { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Int32 |  |

##### Overrides

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Not.html#Albatross_Expression_Operations_Not_Name)Name

##### Declaration

```
public override string Name { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.String |  |

##### Overrides

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Not.html#Albatross_Expression_Operations_Not_Symbolic)Symbolic

##### Declaration

```
public override bool Symbolic { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |  |

##### Overrides

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Not.html#methods)Methods

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Not.html#Albatross_Expression_Operations_Not_EvalValue_System_Func_System_String_System_Object__)EvalValue(Func<String, Object>)

##### Declaration

```
public override object EvalValue(Func<string, object> context)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Func<System.String, System.Object\> | context |  |

##### Returns

| Type | Description |
| --- | --- |
| System.Object |  |

##### Overrides

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Not.html#implements)Implements

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Not.html#extensionmethods)Extension Methods
---
created: 2025-06-25T06:08:24 (UTC -04:00)
tags: []
source: https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.NotEqual.html
author: 
---

# Class NotEqual

> ## Excerpt
> System.Object

---
##### Inheritance

System.Object

NotEqual

##### Implements

##### Inherited Members

###### **Namespace**: [Albatross.Expression.Operations](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.html)

###### **Assembly**: Albatross.Expression.dll

##### Syntax

```
public class NotEqual : ComparisonInfixOperation, IToken
```

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.NotEqual.html#properties)Properties

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.NotEqual.html#Albatross_Expression_Operations_NotEqual_Name)Name

##### Declaration

```
public override string Name { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.String |  |

##### Overrides

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.NotEqual.html#Albatross_Expression_Operations_NotEqual_Precedence)Precedence

##### Declaration

```
public override int Precedence { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Int32 |  |

##### Overrides

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.NotEqual.html#Albatross_Expression_Operations_NotEqual_Symbolic)Symbolic

##### Declaration

```
public override bool Symbolic { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |  |

##### Overrides

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.NotEqual.html#methods)Methods

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.NotEqual.html#Albatross_Expression_Operations_NotEqual_interpret_System_Int32_)interpret(Int32)

##### Declaration

```
public override bool interpret(int comparisonResult)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | comparisonResult |  |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |  |

##### Overrides

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.NotEqual.html#implements)Implements

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.NotEqual.html#extensionmethods)Extension Methods
---
created: 2025-06-25T06:08:23 (UTC -04:00)
tags: []
source: https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Now.html
author: 
---

# Class Now

> ## Excerpt
> System.Object

---
##### Inheritance

System.Object

Now

##### Implements

##### Inherited Members

###### **Namespace**: [Albatross.Expression.Operations](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.html)

###### **Assembly**: Albatross.Expression.dll

##### Syntax

```
public class Now : PrefixOperationToken, IToken
```

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Now.html#properties)Properties

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Now.html#Albatross_Expression_Operations_Now_MaxOperandCount)MaxOperandCount

##### Declaration

```
public override int MaxOperandCount { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Int32 |  |

##### Overrides

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Now.html#Albatross_Expression_Operations_Now_MinOperandCount)MinOperandCount

##### Declaration

```
public override int MinOperandCount { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Int32 |  |

##### Overrides

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Now.html#Albatross_Expression_Operations_Now_Name)Name

##### Declaration

```
public override string Name { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.String |  |

##### Overrides

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Now.html#Albatross_Expression_Operations_Now_Symbolic)Symbolic

##### Declaration

```
public override bool Symbolic { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |  |

##### Overrides

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Now.html#methods)Methods

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Now.html#Albatross_Expression_Operations_Now_EvalValue_System_Func_System_String_System_Object__)EvalValue(Func<String, Object>)

##### Declaration

```
public override object EvalValue(Func<string, object> context)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Func<System.String, System.Object\> | context |  |

##### Returns

| Type | Description |
| --- | --- |
| System.Object |  |

##### Overrides

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Now.html#implements)Implements

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Now.html#extensionmethods)Extension Methods
---
created: 2025-06-25T06:08:24 (UTC -04:00)
tags: []
source: https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Or.html
author: 
---

# Class Or

> ## Excerpt
> Infix OR operation.

---
Infix OR operation.

Operand Count: 2

**Operands**

1.  Operand1 : any
2.  Operand2 : any

Output Type: Boolean

Usage: 3 > 2 or 2 > 1

Precedance: 20

##### Inheritance

System.Object

Or

##### Implements

##### Inherited Members

###### **Namespace**: [Albatross.Expression.Operations](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.html)

###### **Assembly**: Albatross.Expression.dll

##### Syntax

```
public class Or : InfixOperationToken, IToken
```

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Or.html#properties)Properties

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Or.html#Albatross_Expression_Operations_Or_Name)Name

##### Declaration

```
public override string Name { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.String |  |

##### Overrides

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Or.html#Albatross_Expression_Operations_Or_Precedence)Precedence

##### Declaration

```
public override int Precedence { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Int32 |  |

##### Overrides

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Or.html#Albatross_Expression_Operations_Or_Symbolic)Symbolic

##### Declaration

```
public override bool Symbolic { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |  |

##### Overrides

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Or.html#methods)Methods

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Or.html#Albatross_Expression_Operations_Or_EvalValue_System_Func_System_String_System_Object__)EvalValue(Func<String, Object>)

##### Declaration

```
public override object EvalValue(Func<string, object> context)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Func<System.String, System.Object\> | context |  |

##### Returns

| Type | Description |
| --- | --- |
| System.Object |  |

##### Overrides

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Or.html#implements)Implements

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Or.html#extensionmethods)Extension Methods
---
created: 2025-06-25T06:08:24 (UTC -04:00)
tags: []
source: https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.PadLeft.html
author: 
---

# Class PadLeft

> ## Excerpt
> System.Object

---
##### Inheritance

System.Object

PadLeft

##### Implements

##### Inherited Members

###### **Namespace**: [Albatross.Expression.Operations](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.html)

###### **Assembly**: Albatross.Expression.dll

##### Syntax

```
public class PadLeft : PrefixOperationToken, IToken
```

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.PadLeft.html#fields)Fields

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.PadLeft.html#Albatross_Expression_Operations_PadLeft_DefaultPaddingCharacter)DefaultPaddingCharacter

##### Declaration

```
public const char DefaultPaddingCharacter = ' '
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Char |  |

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.PadLeft.html#properties)Properties

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.PadLeft.html#Albatross_Expression_Operations_PadLeft_MaxOperandCount)MaxOperandCount

##### Declaration

```
public override int MaxOperandCount { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Int32 |  |

##### Overrides

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.PadLeft.html#Albatross_Expression_Operations_PadLeft_MinOperandCount)MinOperandCount

##### Declaration

```
public override int MinOperandCount { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Int32 |  |

##### Overrides

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.PadLeft.html#Albatross_Expression_Operations_PadLeft_Name)Name

##### Declaration

```
public override string Name { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.String |  |

##### Overrides

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.PadLeft.html#Albatross_Expression_Operations_PadLeft_Symbolic)Symbolic

##### Declaration

```
public override bool Symbolic { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |  |

##### Overrides

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.PadLeft.html#methods)Methods

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.PadLeft.html#Albatross_Expression_Operations_PadLeft_EvalValue_System_Func_System_String_System_Object__)EvalValue(Func<String, Object>)

##### Declaration

```
public override object EvalValue(Func<string, object> context)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Func<System.String, System.Object\> | context |  |

##### Returns

| Type | Description |
| --- | --- |
| System.Object |  |

##### Overrides

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.PadLeft.html#implements)Implements

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.PadLeft.html#extensionmethods)Extension Methods
---
created: 2025-06-25T06:08:24 (UTC -04:00)
tags: []
source: https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.PadRight.html
author: 
---

# Class PadRight

> ## Excerpt
> System.Object

---
##### Inheritance

System.Object

PadRight

##### Implements

##### Inherited Members

###### **Namespace**: [Albatross.Expression.Operations](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.html)

###### **Assembly**: Albatross.Expression.dll

##### Syntax

```
public class PadRight : PrefixOperationToken, IToken
```

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.PadRight.html#fields)Fields

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.PadRight.html#Albatross_Expression_Operations_PadRight_DefaultPaddingCharacter)DefaultPaddingCharacter

##### Declaration

```
public const char DefaultPaddingCharacter = ' '
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Char |  |

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.PadRight.html#properties)Properties

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.PadRight.html#Albatross_Expression_Operations_PadRight_MaxOperandCount)MaxOperandCount

##### Declaration

```
public override int MaxOperandCount { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Int32 |  |

##### Overrides

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.PadRight.html#Albatross_Expression_Operations_PadRight_MinOperandCount)MinOperandCount

##### Declaration

```
public override int MinOperandCount { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Int32 |  |

##### Overrides

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.PadRight.html#Albatross_Expression_Operations_PadRight_Name)Name

##### Declaration

```
public override string Name { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.String |  |

##### Overrides

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.PadRight.html#Albatross_Expression_Operations_PadRight_Symbolic)Symbolic

##### Declaration

```
public override bool Symbolic { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |  |

##### Overrides

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.PadRight.html#methods)Methods

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.PadRight.html#Albatross_Expression_Operations_PadRight_EvalValue_System_Func_System_String_System_Object__)EvalValue(Func<String, Object>)

##### Declaration

```
public override object EvalValue(Func<string, object> context)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Func<System.String, System.Object\> | context |  |

##### Returns

| Type | Description |
| --- | --- |
| System.Object |  |

##### Overrides

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.PadRight.html#implements)Implements

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.PadRight.html#extensionmethods)Extension Methods
---
created: 2025-06-25T06:08:23 (UTC -04:00)
tags: []
source: https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Pi.html
author: 
---

# Class Pi

> ## Excerpt
> System.Object

---
##### Inheritance

System.Object

Pi

##### Implements

##### Inherited Members

###### **Namespace**: [Albatross.Expression.Operations](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.html)

###### **Assembly**: Albatross.Expression.dll

##### Syntax

```
public class Pi : PrefixOperationToken, IToken
```

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Pi.html#properties)Properties

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Pi.html#Albatross_Expression_Operations_Pi_MaxOperandCount)MaxOperandCount

##### Declaration

```
public override int MaxOperandCount { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Int32 |  |

##### Overrides

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Pi.html#Albatross_Expression_Operations_Pi_MinOperandCount)MinOperandCount

##### Declaration

```
public override int MinOperandCount { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Int32 |  |

##### Overrides

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Pi.html#Albatross_Expression_Operations_Pi_Name)Name

##### Declaration

```
public override string Name { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.String |  |

##### Overrides

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Pi.html#Albatross_Expression_Operations_Pi_Symbolic)Symbolic

##### Declaration

```
public override bool Symbolic { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |  |

##### Overrides

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Pi.html#methods)Methods

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Pi.html#Albatross_Expression_Operations_Pi_EvalValue_System_Func_System_String_System_Object__)EvalValue(Func<String, Object>)

##### Declaration

```
public override object EvalValue(Func<string, object> context)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Func<System.String, System.Object\> | context |  |

##### Returns

| Type | Description |
| --- | --- |
| System.Object |  |

##### Overrides

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Pi.html#implements)Implements

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Pi.html#extensionmethods)Extension Methods
---
created: 2025-06-25T06:08:24 (UTC -04:00)
tags: []
source: https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Plus.html
author: 
---

# Class Plus

> ## Excerpt
> Infix operation that perform an plus operation

---
Infix operation that perform an plus operation

Operand Count: 2

**Operands**

1.  Operrand1 : double
2.  Operrand2 : double

Output Type: double

##### Inheritance

System.Object

Plus

##### Implements

##### Inherited Members

###### **Namespace**: [Albatross.Expression.Operations](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.html)

###### **Assembly**: Albatross.Expression.dll

##### Syntax

```
public class Plus : InfixOperationToken, IToken
```

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Plus.html#properties)Properties

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Plus.html#Albatross_Expression_Operations_Plus_Name)Name

##### Declaration

```
public override string Name { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.String |  |

##### Overrides

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Plus.html#Albatross_Expression_Operations_Plus_Precedence)Precedence

##### Declaration

```
public override int Precedence { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Int32 |  |

##### Overrides

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Plus.html#Albatross_Expression_Operations_Plus_Symbolic)Symbolic

##### Declaration

```
public override bool Symbolic { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |  |

##### Overrides

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Plus.html#methods)Methods

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Plus.html#Albatross_Expression_Operations_Plus_EvalValue_System_Func_System_String_System_Object__)EvalValue(Func<String, Object>)

##### Declaration

```
public override object EvalValue(Func<string, object> context)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Func<System.String, System.Object\> | context |  |

##### Returns

| Type | Description |
| --- | --- |
| System.Object |  |

##### Overrides

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Plus.html#implements)Implements

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Plus.html#extensionmethods)Extension Methods
---
created: 2025-06-25T06:08:24 (UTC -04:00)
tags: []
source: https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Positive.html
author: 
---

# Class Positive

> ## Excerpt
> System.Object

---
##### Inheritance

System.Object

Positive

##### Implements

##### Inherited Members

###### **Namespace**: [Albatross.Expression.Operations](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.html)

###### **Assembly**: Albatross.Expression.dll

##### Syntax

```
public class Positive : PrefixOperationToken, IToken
```

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Positive.html#properties)Properties

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Positive.html#Albatross_Expression_Operations_Positive_MaxOperandCount)MaxOperandCount

##### Declaration

```
public override int MaxOperandCount { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Int32 |  |

##### Overrides

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Positive.html#Albatross_Expression_Operations_Positive_MinOperandCount)MinOperandCount

##### Declaration

```
public override int MinOperandCount { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Int32 |  |

##### Overrides

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Positive.html#Albatross_Expression_Operations_Positive_Name)Name

##### Declaration

```
public override string Name { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.String |  |

##### Overrides

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Positive.html#Albatross_Expression_Operations_Positive_Symbolic)Symbolic

##### Declaration

```
public override bool Symbolic { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |  |

##### Overrides

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Positive.html#methods)Methods

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Positive.html#Albatross_Expression_Operations_Positive_EvalValue_System_Func_System_String_System_Object__)EvalValue(Func<String, Object>)

##### Declaration

```
public override object EvalValue(Func<string, object> context)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Func<System.String, System.Object\> | context |  |

##### Returns

| Type | Description |
| --- | --- |
| System.Object |  |

##### Overrides

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Positive.html#implements)Implements

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Positive.html#extensionmethods)Extension Methods
---
created: 2025-06-25T06:08:24 (UTC -04:00)
tags: []
source: https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Power.html
author: 
---

# Class Power

> ## Excerpt
> Infix operation that perform an power operation

---
Infix operation that perform an power operation

Operand Count: 2

**Operands**

1.  base : double
2.  operand : double

Output Type: double

##### Inheritance

System.Object

Power

##### Implements

##### Inherited Members

###### **Namespace**: [Albatross.Expression.Operations](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.html)

###### **Assembly**: Albatross.Expression.dll

##### Syntax

```
public class Power : InfixOperationToken, IToken
```

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Power.html#properties)Properties

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Power.html#Albatross_Expression_Operations_Power_Name)Name

##### Declaration

```
public override string Name { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.String |  |

##### Overrides

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Power.html#Albatross_Expression_Operations_Power_Precedence)Precedence

##### Declaration

```
public override int Precedence { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Int32 |  |

##### Overrides

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Power.html#Albatross_Expression_Operations_Power_Symbolic)Symbolic

##### Declaration

```
public override bool Symbolic { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |  |

##### Overrides

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Power.html#methods)Methods

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Power.html#Albatross_Expression_Operations_Power_EvalValue_System_Func_System_String_System_Object__)EvalValue(Func<String, Object>)

##### Declaration

```
public override object EvalValue(Func<string, object> context)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Func<System.String, System.Object\> | context |  |

##### Returns

| Type | Description |
| --- | --- |
| System.Object |  |

##### Overrides

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Power.html#implements)Implements

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Power.html#extensionmethods)Extension Methods
---
created: 2025-06-25T06:08:24 (UTC -04:00)
tags: []
source: https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Right.html
author: 
---

# Class Right

> ## Excerpt
> System.Object

---
##### Inheritance

System.Object

Right

##### Implements

##### Inherited Members

###### **Namespace**: [Albatross.Expression.Operations](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.html)

###### **Assembly**: Albatross.Expression.dll

##### Syntax

```
public class Right : PrefixOperationToken, IToken
```

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Right.html#properties)Properties

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Right.html#Albatross_Expression_Operations_Right_MaxOperandCount)MaxOperandCount

##### Declaration

```
public override int MaxOperandCount { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Int32 |  |

##### Overrides

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Right.html#Albatross_Expression_Operations_Right_MinOperandCount)MinOperandCount

##### Declaration

```
public override int MinOperandCount { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Int32 |  |

##### Overrides

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Right.html#Albatross_Expression_Operations_Right_Name)Name

##### Declaration

```
public override string Name { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.String |  |

##### Overrides

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Right.html#Albatross_Expression_Operations_Right_Symbolic)Symbolic

##### Declaration

```
public override bool Symbolic { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |  |

##### Overrides

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Right.html#methods)Methods

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Right.html#Albatross_Expression_Operations_Right_EvalValue_System_Func_System_String_System_Object__)EvalValue(Func<String, Object>)

##### Declaration

```
public override object EvalValue(Func<string, object> context)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Func<System.String, System.Object\> | context |  |

##### Returns

| Type | Description |
| --- | --- |
| System.Object |  |

##### Overrides

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Right.html#implements)Implements

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Right.html#extensionmethods)Extension Methods
---
created: 2025-06-25T06:08:24 (UTC -04:00)
tags: []
source: https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.ShortMonthName.html
author: 
---

# Class ShortMonthName

> ## Excerpt
> System.Object

---
##### Inheritance

System.Object

ShortMonthName

##### Implements

##### Inherited Members

###### **Namespace**: [Albatross.Expression.Operations](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.html)

###### **Assembly**: Albatross.Expression.dll

##### Syntax

```
public class ShortMonthName : PrefixOperationToken, IToken
```

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.ShortMonthName.html#properties)Properties

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.ShortMonthName.html#Albatross_Expression_Operations_ShortMonthName_MaxOperandCount)MaxOperandCount

##### Declaration

```
public override int MaxOperandCount { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Int32 |  |

##### Overrides

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.ShortMonthName.html#Albatross_Expression_Operations_ShortMonthName_MinOperandCount)MinOperandCount

##### Declaration

```
public override int MinOperandCount { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Int32 |  |

##### Overrides

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.ShortMonthName.html#Albatross_Expression_Operations_ShortMonthName_Name)Name

##### Declaration

```
public override string Name { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.String |  |

##### Overrides

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.ShortMonthName.html#Albatross_Expression_Operations_ShortMonthName_Symbolic)Symbolic

##### Declaration

```
public override bool Symbolic { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |  |

##### Overrides

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.ShortMonthName.html#methods)Methods

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.ShortMonthName.html#Albatross_Expression_Operations_ShortMonthName_EvalValue_System_Func_System_String_System_Object__)EvalValue(Func<String, Object>)

##### Declaration

```
public override object EvalValue(Func<string, object> context)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Func<System.String, System.Object\> | context |  |

##### Returns

| Type | Description |
| --- | --- |
| System.Object |  |

##### Overrides

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.ShortMonthName.html#implements)Implements

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.ShortMonthName.html#extensionmethods)Extension Methods
---
created: 2025-06-25T06:08:24 (UTC -04:00)
tags: []
source: https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Text.html
author: 
---

# Class Text

> ## Excerpt
> System.Object

---
##### Inheritance

System.Object

Text

##### Implements

##### Inherited Members

###### **Namespace**: [Albatross.Expression.Operations](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.html)

###### **Assembly**: Albatross.Expression.dll

##### Syntax

```
public class Text : PrefixOperationToken, IToken
```

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Text.html#properties)Properties

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Text.html#Albatross_Expression_Operations_Text_MaxOperandCount)MaxOperandCount

##### Declaration

```
public override int MaxOperandCount { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Int32 |  |

##### Overrides

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Text.html#Albatross_Expression_Operations_Text_MinOperandCount)MinOperandCount

##### Declaration

```
public override int MinOperandCount { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Int32 |  |

##### Overrides

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Text.html#Albatross_Expression_Operations_Text_Name)Name

##### Declaration

```
public override string Name { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.String |  |

##### Overrides

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Text.html#Albatross_Expression_Operations_Text_Symbolic)Symbolic

##### Declaration

```
public override bool Symbolic { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |  |

##### Overrides

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Text.html#methods)Methods

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Text.html#Albatross_Expression_Operations_Text_EvalValue_System_Func_System_String_System_Object__)EvalValue(Func<String, Object>)

##### Declaration

```
public override object EvalValue(Func<string, object> context)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Func<System.String, System.Object\> | context |  |

##### Returns

| Type | Description |
| --- | --- |
| System.Object |  |

##### Overrides

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Text.html#implements)Implements

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Text.html#extensionmethods)Extension Methods
---
created: 2025-06-25T06:08:24 (UTC -04:00)
tags: []
source: https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Today.html
author: 
---

# Class Today

> ## Excerpt
> System.Object

---
##### Inheritance

System.Object

Today

##### Implements

##### Inherited Members

###### **Namespace**: [Albatross.Expression.Operations](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.html)

###### **Assembly**: Albatross.Expression.dll

##### Syntax

```
public class Today : PrefixOperationToken, IToken
```

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Today.html#properties)Properties

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Today.html#Albatross_Expression_Operations_Today_MaxOperandCount)MaxOperandCount

##### Declaration

```
public override int MaxOperandCount { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Int32 |  |

##### Overrides

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Today.html#Albatross_Expression_Operations_Today_MinOperandCount)MinOperandCount

##### Declaration

```
public override int MinOperandCount { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Int32 |  |

##### Overrides

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Today.html#Albatross_Expression_Operations_Today_Name)Name

##### Declaration

```
public override string Name { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.String |  |

##### Overrides

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Today.html#Albatross_Expression_Operations_Today_Symbolic)Symbolic

##### Declaration

```
public override bool Symbolic { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |  |

##### Overrides

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Today.html#methods)Methods

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Today.html#Albatross_Expression_Operations_Today_EvalValue_System_Func_System_String_System_Object__)EvalValue(Func<String, Object>)

##### Declaration

```
public override object EvalValue(Func<string, object> context)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Func<System.String, System.Object\> | context |  |

##### Returns

| Type | Description |
| --- | --- |
| System.Object |  |

##### Overrides

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Today.html#implements)Implements

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Today.html#extensionmethods)Extension Methods
---
created: 2025-06-25T06:08:24 (UTC -04:00)
tags: []
source: https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Year.html
author: 
---

# Class Year

> ## Excerpt
> System.Object

---
##### Inheritance

System.Object

Year

##### Implements

##### Inherited Members

###### **Namespace**: [Albatross.Expression.Operations](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.html)

###### **Assembly**: Albatross.Expression.dll

##### Syntax

```
public class Year : PrefixOperationToken, IToken
```

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Year.html#properties)Properties

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Year.html#Albatross_Expression_Operations_Year_MaxOperandCount)MaxOperandCount

##### Declaration

```
public override int MaxOperandCount { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Int32 |  |

##### Overrides

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Year.html#Albatross_Expression_Operations_Year_MinOperandCount)MinOperandCount

##### Declaration

```
public override int MinOperandCount { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Int32 |  |

##### Overrides

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Year.html#Albatross_Expression_Operations_Year_Name)Name

##### Declaration

```
public override string Name { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.String |  |

##### Overrides

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Year.html#Albatross_Expression_Operations_Year_Symbolic)Symbolic

##### Declaration

```
public override bool Symbolic { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |  |

##### Overrides

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Year.html#methods)Methods

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Year.html#Albatross_Expression_Operations_Year_EvalValue_System_Func_System_String_System_Object__)EvalValue(Func<String, Object>)

##### Declaration

```
public override object EvalValue(Func<string, object> context)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Func<System.String, System.Object\> | context |  |

##### Returns

| Type | Description |
| --- | --- |
| System.Object |  |

##### Overrides

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Year.html#implements)Implements

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Year.html#extensionmethods)Extension Methods
---
created: 2025-06-25T06:08:23 (UTC -04:00)
tags: []
source: https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.html
author: 
---

# Namespace Albatross.Expression.Operations

> ## Excerpt
> Infix AND operation.

---
### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.html#classes)Classes

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.html#and)[And](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.And.html)

Infix AND operation.

Operand Count: 2

**Operands**

1.  Operand1 : any
2.  Operand2 : any

The input operands are converted to boolean. See the [ConvertToBoolean(Object)](https://rushuiguan.github.io/expression/api/Albatross.Expression.Extensions.html#Albatross_Expression_Extensions_ConvertToBoolean_System_Object_) method for the conversion logic

Output Type: Boolean

Usage: 3 > 2 and 2 > 1

Precedance: 30

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.html#array)[Array](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Array.html)

Prefix operation that create an object array

Operand Count: 0 to infinite

Operand Type: Any

Output Type: System.Collections.Generic.List<T> where T is Object

Usage: @(1, 2, 3, 4, 5)

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.html#avg)[Avg](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Avg.html)

Prefix operation that return the average of a set of numbers

Operand Count: 0 to infinite

Operand Type: number, if the operand count is 1, it can be an array

Output Type: double

Usage: avg(1, 2, 3, 4, 5) or avg(@(1, 2, 3, 4, 5))

Note: null value will not be counted, therefore avg(null, 2, 2, 2) should be 6/3 = 2 not 6/4 = 1.5; It will return null if the count is 0.

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.html#coalesce)[Coalesce](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Coalesce.html)

Prefix operation that return the first non null operand

Operand Count: 1 to infinite

Operand Type: any

Example: Coalesce(null, 1, 2, 3) will return 1

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.html#comparisoninfixoperation)[ComparisonInfixOperation](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.ComparisonInfixOperation.html)

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.html#createdate)[CreateDate](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.CreateDate.html)

Prefix operation that create an date

Operand Count: 3

**Operands**

1.  year : double
2.  month : double
3.  day : double

Operand Type: int

Output Type: System.DateTime

Usage: CreateDate(2018, 1, 31)

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.html#currentapp)[CurrentApp](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.CurrentApp.html)

Prefix operation that returns the current app domain friendly name

Operand Count: 0

Output Type: string

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.html#currentmachine)[CurrentMachine](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.CurrentMachine.html)

Prefix operation that returns the current machine host name

Operand Count: 0

Output Type: string

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.html#currentuser)[CurrentUser](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.CurrentUser.html)

Prefix operation that returns the current windows user name>

Operand Count: 0

Output Type: string

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.html#date)[Date](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Date.html)

Prefix operation that convert input to date. The operand is converted to text first and parsed to a datetime object

Operand Count: 1

**Operands**

1.  input : any

Output Type: System.DateTime

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.html#divide)[Divide](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Divide.html)

Infix operation that perform divide

Operand Count: 2

**Operands**

1.  Operrand1 : double
2.  Operrand2 : double

Output Type: double

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.html#equal)[Equal](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Equal.html)

Infix operation that perform an equal check

Operand Count: 2

**Operands**

1.  Operrand1 : double
2.  Operrand2 : double

Output Type: double

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.html#format)[Format](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Format.html)

Prefix operation that will take an input and C# format string and produced a formatted string

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.html#greaterequal)[GreaterEqual](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.GreaterEqual.html)

Infix GreaterEqual operation.

Operand Count: 2

**Operands**

1.  Operand1 : any
2.  Operand2 : any

Output Type: Boolean

Usage: 3 >= 2

Precedance: 50

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.html#greaterthan)[GreaterThan](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.GreaterThan.html)

Infix GreaterThan operation.

Operand Count: 2

**Operands**

1.  Operand1 : any
2.  Operand2 : any

Output Type: Boolean

Usage: 3 > 2

Precedance: 50

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.html#if)[If](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.If.html)

Prefix if operation

Operand Count: 2 or 3

**Operands**

1.  condition: any
2.  result when true: any
3.  result when false, if omitted, will be default to null: any

Output Type: any

Usage: if( 3 > 2, "OK", "No")

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.html#isblank)[IsBlank](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.IsBlank.html)

Prefix operation to check if the input IsBlank

Operand Type: any

Null, empty string and string with only white space are considered as blank

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.html#left)[Left](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Left.html)

Prefix operation that return the substring of the input text with the specified length and start index of 0

Operand Count: 2

**Operands**

1.  input: string
2.  count: double

Output Type: string

Usage: Left("test", 1) should return "t"

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.html#len)[Len](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Len.html)

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.html#lessequal)[LessEqual](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.LessEqual.html)

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.html#lessthan)[LessThan](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.LessThan.html)

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.html#max)[Max](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Max.html)

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.html#min)[Min](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Min.html)

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.html#minus)[Minus](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Minus.html)

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.html#mod)[Mod](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Mod.html)

Infix operation that perform an mod operation

Operand Count: 2

**Operands**

1.  Operrand1 : double
2.  Operrand2 : double

Output Type: double

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.html#month)[Month](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Month.html)

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.html#monthname)[MonthName](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.MonthName.html)

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.html#multiply)[Multiply](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Multiply.html)

Infix operation that perform an multiply operation

Operand Count: 2

**Operands**

1.  Operrand1 : double
2.  Operrand2 : double

Output Type: double

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.html#negative)[Negative](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Negative.html)

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.html#not)[Not](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Not.html)

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.html#notequal)[NotEqual](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.NotEqual.html)

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.html#now)[Now](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Now.html)

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.html#or)[Or](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Or.html)

Infix OR operation.

Operand Count: 2

**Operands**

1.  Operand1 : any
2.  Operand2 : any

Output Type: Boolean

Usage: 3 > 2 or 2 > 1

Precedance: 20

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.html#padleft)[PadLeft](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.PadLeft.html)

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.html#padright)[PadRight](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.PadRight.html)

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.html#pi)[Pi](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Pi.html)

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.html#plus)[Plus](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Plus.html)

Infix operation that perform an plus operation

Operand Count: 2

**Operands**

1.  Operrand1 : double
2.  Operrand2 : double

Output Type: double

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.html#positive)[Positive](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Positive.html)

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.html#power)[Power](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Power.html)

Infix operation that perform an power operation

Operand Count: 2

**Operands**

1.  base : double
2.  operand : double

Output Type: double

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.html#right)[Right](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Right.html)

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.html#shortmonthname)[ShortMonthName](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.ShortMonthName.html)

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.html#text)[Text](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Text.html)

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.html#today)[Today](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Today.html)

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.html#year)[Year](https://rushuiguan.github.io/expression/api/Albatross.Expression.Operations.Year.html)
