---
created: 2025-06-25T05:52:55 (UTC -04:00)
tags: []
source: https://rushuiguan.github.io/expression/api/Albatross.Expression.Tokens.AssignmentToken.html
author: 
---

# Class AssignmentToken

> ## Excerpt
> System.Object

---
##### Inheritance

System.Object

AssignmentToken

##### Implements

###### **Namespace**: [Albatross.Expression.Tokens](https://rushuiguan.github.io/expression/api/Albatross.Expression.Tokens.html)

###### **Assembly**: Albatross.Expression.dll

##### Syntax

```
public class AssignmentToken : IToken
```

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Tokens.AssignmentToken.html#properties)Properties

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Tokens.AssignmentToken.html#Albatross_Expression_Tokens_AssignmentToken_Group)Group

##### Declaration

```
public string Group { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.String |  |

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Tokens.AssignmentToken.html#Albatross_Expression_Tokens_AssignmentToken_Name)Name

##### Declaration

```
public string Name { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.String |  |

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Tokens.AssignmentToken.html#methods)Methods

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Tokens.AssignmentToken.html#Albatross_Expression_Tokens_AssignmentToken_Clone)Clone()

##### Declaration

##### Returns

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Tokens.AssignmentToken.html#Albatross_Expression_Tokens_AssignmentToken_EvalText_System_String_)EvalText(String)

##### Declaration

```
public string EvalText(string format)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | format |  |

##### Returns

| Type | Description |
| --- | --- |
| System.String |  |

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Tokens.AssignmentToken.html#Albatross_Expression_Tokens_AssignmentToken_EvalValue_System_Func_System_String_System_Object__)EvalValue(Func<String, Object>)

##### Declaration

```
public object EvalValue(Func<string, object> context)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Func<System.String, System.Object\> | context |  |

##### Returns

| Type | Description |
| --- | --- |
| System.Object |  |

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Tokens.AssignmentToken.html#Albatross_Expression_Tokens_AssignmentToken_Match_System_String_System_Int32_System_Int32__)Match(String, Int32, out Int32)

##### Declaration

```
public bool Match(string expression, int start, out int next)
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

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Tokens.AssignmentToken.html#Albatross_Expression_Tokens_AssignmentToken_ToString)ToString()

##### Declaration

```
public override string ToString()
```

##### Returns

| Type | Description |
| --- | --- |
| System.String |  |

##### Overrides

System.Object.ToString()

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Tokens.AssignmentToken.html#implements)Implements

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Tokens.AssignmentToken.html#extensionmethods)Extension Methods
---
created: 2025-06-25T05:52:55 (UTC -04:00)
tags: []
source: https://rushuiguan.github.io/expression/api/Albatross.Expression.Tokens.BooleanLiteralToken.html
author: 
---

# Class BooleanLiteralToken

> ## Excerpt
> will only take true or false, case insensitive

---
will only take true or false, case insensitive

##### Inheritance

System.Object

BooleanLiteralToken

##### Implements

###### **Namespace**: [Albatross.Expression.Tokens](https://rushuiguan.github.io/expression/api/Albatross.Expression.Tokens.html)

###### **Assembly**: Albatross.Expression.dll

##### Syntax

```
public class BooleanLiteralToken : IOperandToken, IToken
```

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Tokens.BooleanLiteralToken.html#properties)Properties

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Tokens.BooleanLiteralToken.html#Albatross_Expression_Tokens_BooleanLiteralToken_Group)Group

##### Declaration

```
public string Group { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.String |  |

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Tokens.BooleanLiteralToken.html#Albatross_Expression_Tokens_BooleanLiteralToken_Name)Name

##### Declaration

```
public string Name { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.String |  |

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Tokens.BooleanLiteralToken.html#methods)Methods

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Tokens.BooleanLiteralToken.html#Albatross_Expression_Tokens_BooleanLiteralToken_Clone)Clone()

##### Declaration

##### Returns

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Tokens.BooleanLiteralToken.html#Albatross_Expression_Tokens_BooleanLiteralToken_EvalText_System_String_)EvalText(String)

##### Declaration

```
public string EvalText(string format)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | format |  |

##### Returns

| Type | Description |
| --- | --- |
| System.String |  |

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Tokens.BooleanLiteralToken.html#Albatross_Expression_Tokens_BooleanLiteralToken_EvalValue_System_Func_System_String_System_Object__)EvalValue(Func<String, Object>)

##### Declaration

```
public object EvalValue(Func<string, object> context)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Func<System.String, System.Object\> | context |  |

##### Returns

| Type | Description |
| --- | --- |
| System.Object |  |

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Tokens.BooleanLiteralToken.html#Albatross_Expression_Tokens_BooleanLiteralToken_Match_System_String_System_Int32_System_Int32__)Match(String, Int32, out Int32)

##### Declaration

```
public bool Match(string expression, int start, out int next)
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

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Tokens.BooleanLiteralToken.html#Albatross_Expression_Tokens_BooleanLiteralToken_ToString)ToString()

##### Declaration

```
public override string ToString()
```

##### Returns

| Type | Description |
| --- | --- |
| System.String |  |

##### Overrides

System.Object.ToString()

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Tokens.BooleanLiteralToken.html#implements)Implements

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Tokens.BooleanLiteralToken.html#extensionmethods)Extension Methods
---
created: 2025-06-25T05:51:42 (UTC -04:00)
tags: []
source: https://rushuiguan.github.io/expression/api/Albatross.Expression.Exceptions.CircularReferenceException.html
author: 
---

# Class CircularReferenceException

> ## Excerpt
> System.Object

---
##### Inheritance

System.Object

System.Exception

CircularReferenceException

##### Implements

System.Runtime.Serialization.ISerializable

System.Runtime.InteropServices.\_Exception

###### **Namespace**: [Albatross.Expression.Exceptions](https://rushuiguan.github.io/expression/api/Albatross.Expression.Exceptions.html)

###### **Assembly**: Albatross.Expression.dll

##### Syntax

```
public class CircularReferenceException : Exception, ISerializable, _Exception
```

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Exceptions.CircularReferenceException.html#constructors)Constructors

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Exceptions.CircularReferenceException.html#Albatross_Expression_Exceptions_CircularReferenceException__ctor_System_String_System_String_)CircularReferenceException(String, String)

##### Declaration

```
public CircularReferenceException(string from, string to)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | from |  |
| System.String | to |  |

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Exceptions.CircularReferenceException.html#implements)Implements

System.Runtime.Serialization.ISerializable

System.Runtime.InteropServices.\_Exception

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Exceptions.CircularReferenceException.html#extensionmethods)Extension Methods
---
created: 2025-06-25T05:52:55 (UTC -04:00)
tags: []
source: https://rushuiguan.github.io/expression/api/Albatross.Expression.Tokens.ControlToken.html
author: 
---

# Class ControlToken

> ## Excerpt
> System.Object

---
##### Inheritance

System.Object

ControlToken

##### Implements

###### **Namespace**: [Albatross.Expression.Tokens](https://rushuiguan.github.io/expression/api/Albatross.Expression.Tokens.html)

###### **Assembly**: Albatross.Expression.dll

##### Syntax

```
public class ControlToken : IToken
```

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Tokens.ControlToken.html#fields)Fields

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Tokens.ControlToken.html#Albatross_Expression_Tokens_ControlToken_Comma)Comma

##### Declaration

```
public static readonly ControlToken Comma
```

##### Field Value

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Tokens.ControlToken.html#Albatross_Expression_Tokens_ControlToken_Comma_Text)Comma\_Text

##### Declaration

```
public const string Comma_Text = ","
```

##### Field Value

| Type | Description |
| --- | --- |
| System.String |  |

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Tokens.ControlToken.html#Albatross_Expression_Tokens_ControlToken_FuncParamStart)FuncParamStart

##### Declaration

```
public static readonly ControlToken FuncParamStart
```

##### Field Value

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Tokens.ControlToken.html#Albatross_Expression_Tokens_ControlToken_FuncParamStart_Text)FuncParamStart\_Text

##### Declaration

```
public const string FuncParamStart_Text = "$"
```

##### Field Value

| Type | Description |
| --- | --- |
| System.String |  |

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Tokens.ControlToken.html#Albatross_Expression_Tokens_ControlToken_LeftParenthesis)LeftParenthesis

##### Declaration

```
public static readonly ControlToken LeftParenthesis
```

##### Field Value

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Tokens.ControlToken.html#Albatross_Expression_Tokens_ControlToken_LeftParenthesis_Text)LeftParenthesis\_Text

##### Declaration

```
public const string LeftParenthesis_Text = "("
```

##### Field Value

| Type | Description |
| --- | --- |
| System.String |  |

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Tokens.ControlToken.html#Albatross_Expression_Tokens_ControlToken_RightParenthesis)RightParenthesis

##### Declaration

```
public static readonly ControlToken RightParenthesis
```

##### Field Value

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Tokens.ControlToken.html#Albatross_Expression_Tokens_ControlToken_RightParenthesis_Text)RightParenthesis\_Text

##### Declaration

```
public const string RightParenthesis_Text = ")"
```

##### Field Value

| Type | Description |
| --- | --- |
| System.String |  |

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Tokens.ControlToken.html#properties)Properties

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Tokens.ControlToken.html#Albatross_Expression_Tokens_ControlToken_Group)Group

##### Declaration

```
public string Group { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.String |  |

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Tokens.ControlToken.html#Albatross_Expression_Tokens_ControlToken_Name)Name

##### Declaration

```
public string Name { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.String |  |

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Tokens.ControlToken.html#methods)Methods

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Tokens.ControlToken.html#Albatross_Expression_Tokens_ControlToken_Clone)Clone()

##### Declaration

##### Returns

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Tokens.ControlToken.html#Albatross_Expression_Tokens_ControlToken_EvalText_System_String_)EvalText(String)

##### Declaration

```
public string EvalText(string format)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | format |  |

##### Returns

| Type | Description |
| --- | --- |
| System.String |  |

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Tokens.ControlToken.html#Albatross_Expression_Tokens_ControlToken_EvalValue_System_Func_System_String_System_Object__)EvalValue(Func<String, Object>)

##### Declaration

```
public object EvalValue(Func<string, object> context)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Func<System.String, System.Object\> | context |  |

##### Returns

| Type | Description |
| --- | --- |
| System.Object |  |

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Tokens.ControlToken.html#Albatross_Expression_Tokens_ControlToken_Match_System_String_System_Int32_System_Int32__)Match(String, Int32, out Int32)

##### Declaration

```
public bool Match(string expression, int start, out int next)
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

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Tokens.ControlToken.html#Albatross_Expression_Tokens_ControlToken_ToString)ToString()

##### Declaration

```
public override string ToString()
```

##### Returns

| Type | Description |
| --- | --- |
| System.String |  |

##### Overrides

System.Object.ToString()

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Tokens.ControlToken.html#implements)Implements

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Tokens.ControlToken.html#extensionmethods)Extension Methods
---
created: 2025-06-25T05:52:55 (UTC -04:00)
tags: []
source: https://rushuiguan.github.io/expression/api/Albatross.Expression.Tokens.DoubleQuoteStringLiteralToken.html
author: 
---

# Class DoubleQuoteStringLiteralToken

> ## Excerpt
> will take any string literal enclosed by double quotes.  use back slash to escape.Check the GetStringEscape function for escapable chars

---
will take any string literal enclosed by double quotes. use back slash to escape.  
Check the GetStringEscape function for escapable chars

##### Inheritance

System.Object

DoubleQuoteStringLiteralToken

##### Implements

##### Inherited Members

###### **Namespace**: [Albatross.Expression.Tokens](https://rushuiguan.github.io/expression/api/Albatross.Expression.Tokens.html)

###### **Assembly**: Albatross.Expression.dll

##### Syntax

```
public class DoubleQuoteStringLiteralToken : StringLiteralToken, IOperandToken, IStringLiteralToken, IToken
```

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Tokens.DoubleQuoteStringLiteralToken.html#properties)Properties

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Tokens.DoubleQuoteStringLiteralToken.html#Albatross_Expression_Tokens_DoubleQuoteStringLiteralToken_Boundary)Boundary

##### Declaration

```
public override char Boundary { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Char |  |

##### Overrides

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Tokens.DoubleQuoteStringLiteralToken.html#methods)Methods

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Tokens.DoubleQuoteStringLiteralToken.html#Albatross_Expression_Tokens_DoubleQuoteStringLiteralToken_Clone)Clone()

##### Declaration

```
public override IToken Clone()
```

##### Returns

##### Overrides

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Tokens.DoubleQuoteStringLiteralToken.html#implements)Implements

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Tokens.DoubleQuoteStringLiteralToken.html#extensionmethods)Extension Methods
---
created: 2025-06-25T05:37:38 (UTC -04:00)
tags: []
source: https://rushuiguan.github.io/expression/api/Albatross.Expression.ExecutionContextFactory.html
author: 
---

# Class ExecutionContextFactory

> ## Excerpt
> System.Object

---
##### Inheritance

System.Object

ExecutionContextFactory

##### Implements

###### **Namespace**: [Albatross.Expression](https://rushuiguan.github.io/expression/api/Albatross.Expression.html)

###### **Assembly**: Albatross.Expression.dll

##### Syntax

```
public class ExecutionContextFactory : IExecutionContextFactory<object>
```

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.ExecutionContextFactory.html#constructors)Constructors

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.ExecutionContextFactory.html#Albatross_Expression_ExecutionContextFactory__ctor_Albatross_Expression_IParser_)ExecutionContextFactory(IParser)

##### Declaration

```
public ExecutionContextFactory(IParser parser)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [IParser](https://rushuiguan.github.io/expression/api/Albatross.Expression.IParser.html) | parser |  |

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.ExecutionContextFactory.html#properties)Properties

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.ExecutionContextFactory.html#Albatross_Expression_ExecutionContextFactory_CacheExternalValue)CacheExternalValue

##### Declaration

```
public bool CacheExternalValue { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |  |

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.ExecutionContextFactory.html#Albatross_Expression_ExecutionContextFactory_CaseSensitive)CaseSensitive

##### Declaration

```
public bool CaseSensitive { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |  |

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.ExecutionContextFactory.html#Albatross_Expression_ExecutionContextFactory_DefaultTryGetValueDelegate)DefaultTryGetValueDelegate

##### Declaration

```
public TryGetValueDelegate<object> DefaultTryGetValueDelegate { get; set; }
```

##### Property Value

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.ExecutionContextFactory.html#Albatross_Expression_ExecutionContextFactory_FailWhenMissingVariable)FailWhenMissingVariable

##### Declaration

```
public bool FailWhenMissingVariable { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |  |

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.ExecutionContextFactory.html#methods)Methods

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.ExecutionContextFactory.html#Albatross_Expression_ExecutionContextFactory_Create)Create()

##### Declaration

```
public IExecutionContext<object> Create()
```

##### Returns

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.ExecutionContextFactory.html#Albatross_Expression_ExecutionContextFactory_TryGetExternalValue_System_String_System_Object_System_Object__)TryGetExternalValue(String, Object, out Object)

##### Declaration

```
public bool TryGetExternalValue(string name, object input, out object value)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | name |  |
| System.Object | input |  |
| System.Object | value |  |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |  |

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.ExecutionContextFactory.html#implements)Implements

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.ExecutionContextFactory.html#extensionmethods)Extension Methods
---
created: 2025-06-25T05:37:38 (UTC -04:00)
tags: []
source: https://rushuiguan.github.io/expression/api/Albatross.Expression.ExecutionContext-1.html
author: 
---

# Class ExecutionContext<T>

> ## Excerpt
> System.Object

---
##### Inheritance

System.Object

ExecutionContext<T>

##### Implements

System.Collections.Generic.IEnumerable<[ContextValue](https://rushuiguan.github.io/expression/api/Albatross.Expression.ContextValue.html)\>

System.Collections.IEnumerable

###### **Namespace**: [Albatross.Expression](https://rushuiguan.github.io/expression/api/Albatross.Expression.html)

###### **Assembly**: Albatross.Expression.dll

##### Syntax

```
public class ExecutionContext<T> : IExecutionContext<T>, IEnumerable<ContextValue>, IEnumerable
```

##### Type Parameters

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.ExecutionContext-1.html#constructors)Constructors

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.ExecutionContext-1.html#Albatross_Expression_ExecutionContext_1__ctor_Albatross_Expression_IParser_System_Boolean_System_Boolean_System_Boolean_Albatross_Expression_TryGetValueDelegate__0__)ExecutionContext(IParser, Boolean, Boolean, Boolean, TryGetValueDelegate<T>)

##### Declaration

```
public ExecutionContext(IParser parser, bool caseSensitive, bool cacheExternalValue, bool failWhenMissingVariable, TryGetValueDelegate<T> tryGetValueDelegate)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [IParser](https://rushuiguan.github.io/expression/api/Albatross.Expression.IParser.html) | parser |  |
| System.Boolean | caseSensitive |  |
| System.Boolean | cacheExternalValue |  |
| System.Boolean | failWhenMissingVariable |  |
| [TryGetValueDelegate](https://rushuiguan.github.io/expression/api/Albatross.Expression.TryGetValueDelegate-1.html)<T> | tryGetValueDelegate |  |

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.ExecutionContext-1.html#properties)Properties

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.ExecutionContext-1.html#Albatross_Expression_ExecutionContext_1_CacheExternalValue)CacheExternalValue

##### Declaration

```
public bool CacheExternalValue { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |  |

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.ExecutionContext-1.html#Albatross_Expression_ExecutionContext_1_CaseSensitive)CaseSensitive

##### Declaration

```
public bool CaseSensitive { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |  |

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.ExecutionContext-1.html#Albatross_Expression_ExecutionContext_1_Compiled)Compiled

##### Declaration

```
public bool Compiled { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |  |

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.ExecutionContext-1.html#Albatross_Expression_ExecutionContext_1_FailWhenMissingVariable)FailWhenMissingVariable

##### Declaration

```
public bool FailWhenMissingVariable { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |  |

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.ExecutionContext-1.html#Albatross_Expression_ExecutionContext_1_Parser)Parser

##### Declaration

```
public IParser Parser { get; }
```

##### Property Value

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.ExecutionContext-1.html#Albatross_Expression_ExecutionContext_1_Store)Store

##### Declaration

```
public Dictionary<string, ContextValue> Store { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Collections.Generic.Dictionary<System.String, [ContextValue](https://rushuiguan.github.io/expression/api/Albatross.Expression.ContextValue.html)\> |  |

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.ExecutionContext-1.html#Albatross_Expression_ExecutionContext_1_TryGetExternalData)TryGetExternalData

##### Declaration

```
public TryGetValueDelegate<T> TryGetExternalData { get; }
```

##### Property Value

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.ExecutionContext-1.html#methods)Methods

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.ExecutionContext-1.html#Albatross_Expression_ExecutionContext_1_Build)Build()

##### Declaration

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.ExecutionContext-1.html#Albatross_Expression_ExecutionContext_1_Clear)Clear()

##### Declaration

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.ExecutionContext-1.html#Albatross_Expression_ExecutionContext_1_Eval_System_String__0_System_Type_)Eval(String, T, Type)

##### Declaration

```
public object Eval(string expression, T input, Type outputDataType = null)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | expression |  |
| T | input |  |
| System.Type | outputDataType |  |

##### Returns

| Type | Description |
| --- | --- |
| System.Object |  |

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.ExecutionContext-1.html#Albatross_Expression_ExecutionContext_1_GetEnumerator)GetEnumerator()

##### Declaration

```
public IEnumerator<ContextValue> GetEnumerator()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Collections.Generic.IEnumerator<[ContextValue](https://rushuiguan.github.io/expression/api/Albatross.Expression.ContextValue.html)\> |  |

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.ExecutionContext-1.html#Albatross_Expression_ExecutionContext_1_GetValue_System_String__0_)GetValue(String, T)

##### Declaration

```
public object GetValue(string name, T input)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | name |  |
| T | input |  |

##### Returns

| Type | Description |
| --- | --- |
| System.Object |  |

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.ExecutionContext-1.html#Albatross_Expression_ExecutionContext_1_Set_Albatross_Expression_ContextValue_)Set(ContextValue)

##### Declaration

```
public void Set(ContextValue value)
```

##### Parameters

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.ExecutionContext-1.html#Albatross_Expression_ExecutionContext_1_TryGetValue_System_String__0_System_Object__)TryGetValue(String, T, out Object)

##### Declaration

```
public bool TryGetValue(string name, T input, out object data)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | name |  |
| T | input |  |
| System.Object | data |  |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |  |

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.ExecutionContext-1.html#eii)Explicit Interface Implementations

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.ExecutionContext-1.html#Albatross_Expression_ExecutionContext_1_System_Collections_IEnumerable_GetEnumerator)IEnumerable.GetEnumerator()

##### Declaration

```
IEnumerator IEnumerable.GetEnumerator()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Collections.IEnumerator |  |

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.ExecutionContext-1.html#implements)Implements

System.Collections.Generic.IEnumerable<T>

System.Collections.IEnumerable

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.ExecutionContext-1.html#extensionmethods)Extension Methods
---
created: 2025-06-25T05:37:38 (UTC -04:00)
tags: []
source: https://rushuiguan.github.io/expression/api/Albatross.Expression.ExpressionBuilder.html
author: 
---

# Class ExpressionBuilder

> ## Excerpt
> System.Object

---
##### Inheritance

System.Object

ExpressionBuilder

###### **Namespace**: [Albatross.Expression](https://rushuiguan.github.io/expression/api/Albatross.Expression.html)

###### **Assembly**: Albatross.Expression.dll

##### Syntax

```
[Obsolete]
public class ExpressionBuilder
```

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.ExpressionBuilder.html#constructors)Constructors

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.ExpressionBuilder.html#Albatross_Expression_ExpressionBuilder__ctor_Albatross_Expression_IParser_)ExpressionBuilder(IParser)

##### Declaration

```
public ExpressionBuilder(IParser parser)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [IParser](https://rushuiguan.github.io/expression/api/Albatross.Expression.IParser.html) | parser |  |

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.ExpressionBuilder.html#properties)Properties

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.ExpressionBuilder.html#Albatross_Expression_ExpressionBuilder_Boundary)Boundary

##### Declaration

```
public char Boundary { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Char |  |

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.ExpressionBuilder.html#Albatross_Expression_ExpressionBuilder_Content)Content

##### Declaration

```
public StringBuilder Content { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Text.StringBuilder |  |

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.ExpressionBuilder.html#Albatross_Expression_ExpressionBuilder_Parser)Parser

##### Declaration

```
public IParser Parser { get; }
```

##### Property Value

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.ExpressionBuilder.html#methods)Methods

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.ExpressionBuilder.html#Albatross_Expression_ExpressionBuilder_Expression_System_String_)Expression(String)

##### Declaration

```
public ExpressionBuilder Expression(string value)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | value |  |

##### Returns

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.ExpressionBuilder.html#Albatross_Expression_ExpressionBuilder_Text_System_String_)Text(String)

##### Declaration

```
public ExpressionBuilder Text(string value)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | value |  |

##### Returns

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.ExpressionBuilder.html#Albatross_Expression_ExpressionBuilder_ToString)ToString()

##### Declaration

```
public override string ToString()
```

##### Returns

| Type | Description |
| --- | --- |
| System.String |  |

##### Overrides

System.Object.ToString()

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.ExpressionBuilder.html#extensionmethods)Extension Methods
---
created: 2025-06-25T05:37:38 (UTC -04:00)
tags: []
source: https://rushuiguan.github.io/expression/api/Albatross.Expression.Extensions.html
author: 
---

# Class Extensions

> ## Excerpt
> System.Object

---
##### Inheritance

System.Object

Extensions

###### **Namespace**: [Albatross.Expression](https://rushuiguan.github.io/expression/api/Albatross.Expression.html)

###### **Assembly**: Albatross.Expression.dll

##### Syntax

```
public static class Extensions
```

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Extensions.html#methods)Methods

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Extensions.html#Albatross_Expression_Extensions_Compile_Albatross_Expression_IParser_System_String_)Compile(IParser, String)

##### Declaration

```
public static IToken Compile(this IParser parser, string expression)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [IParser](https://rushuiguan.github.io/expression/api/Albatross.Expression.IParser.html) | parser |  |
| System.String | expression |  |

##### Returns

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Extensions.html#Albatross_Expression_Extensions_ConvertToBoolean_System_Object_)ConvertToBoolean(Object)

##### Declaration

```
public static bool ConvertToBoolean(this object obj)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Object | obj |  |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |  |

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Extensions.html#Albatross_Expression_Extensions_GetValue__1_Albatross_Expression_IExecutionContext___0__System_String___0_)GetValue<T>(IExecutionContext<T>, String, T)

##### Declaration

```
public static object GetValue<T>(this IExecutionContext<T> context, string name, T input)
```

##### Parameters

##### Returns

| Type | Description |
| --- | --- |
| System.Object |  |

##### Type Parameters

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Extensions.html#Albatross_Expression_Extensions_IsVariable_Albatross_Expression_Tokens_IToken_)IsVariable(IToken)

##### Declaration

```
public static bool IsVariable(this IToken token)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [IToken](https://rushuiguan.github.io/expression/api/Albatross.Expression.Tokens.IToken.html) | token |  |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |  |

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Extensions.html#Albatross_Expression_Extensions_Set__1_Albatross_Expression_IExecutionContext___0__System_String_)Set<T>(IExecutionContext<T>, String)

##### Declaration

```
public static ContextValue Set<T>(this IExecutionContext<T> context, string assignmentExpression)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [IExecutionContext](https://rushuiguan.github.io/expression/api/Albatross.Expression.IExecutionContext-1.html)<T> | context |  |
| System.String | assignmentExpression |  |

##### Returns

##### Type Parameters

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Extensions.html#Albatross_Expression_Extensions_SetExpression__1_Albatross_Expression_IExecutionContext___0__System_String_System_String_)SetExpression<T>(IExecutionContext<T>, String, String)

##### Declaration

```
public static void SetExpression<T>(this IExecutionContext<T> context, string name, string expression)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [IExecutionContext](https://rushuiguan.github.io/expression/api/Albatross.Expression.IExecutionContext-1.html)<T> | context |  |
| System.String | name |  |
| System.String | expression |  |

##### Type Parameters

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Extensions.html#Albatross_Expression_Extensions_SetExpression__1_Albatross_Expression_IExecutionContext___0__System_String_System_String_System_Type_)SetExpression<T>(IExecutionContext<T>, String, String, Type)

##### Declaration

```
public static void SetExpression<T>(this IExecutionContext<T> context, string name, string expression, Type dataType)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [IExecutionContext](https://rushuiguan.github.io/expression/api/Albatross.Expression.IExecutionContext-1.html)<T> | context |  |
| System.String | name |  |
| System.String | expression |  |
| System.Type | dataType |  |

##### Type Parameters

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Extensions.html#Albatross_Expression_Extensions_SetValue__1_Albatross_Expression_IExecutionContext___0__System_String_System_Object_)SetValue<T>(IExecutionContext<T>, String, Object)

##### Declaration

```
public static void SetValue<T>(this IExecutionContext<T> context, string name, object value)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [IExecutionContext](https://rushuiguan.github.io/expression/api/Albatross.Expression.IExecutionContext-1.html)<T> | context |  |
| System.String | name |  |
| System.Object | value |  |

##### Type Parameters

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Extensions.html#Albatross_Expression_Extensions_SkipSpace_System_String_System_Int32_)SkipSpace(String, Int32)

Move find the next index that is not a space. This method doesn't perform check of the starting index in any way.

##### Declaration

```
public static int SkipSpace(this string expression, int start)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | expression |  |
| System.Int32 | start | 
The current index

 |

##### Returns

| Type | Description |
| --- | --- |
| System.Int32 |  |
---
created: 2025-06-25T05:37:38 (UTC -04:00)
tags: []
source: https://rushuiguan.github.io/expression/api/Albatross.Expression.Factory.html
author: 
---

# Class Factory

> ## Excerpt
> The default parser factory class.  This class can be accessed using its lazy static instance Instance or by creating a new instance.
The factory class by default will register any class with the ParserOperationAttribute attribute within this assembly.  Additional assemblies
can be registered using the Register(Assembly) function.

---
The default parser factory class. This class can be accessed using its lazy static instance [Instance](https://rushuiguan.github.io/expression/api/Albatross.Expression.Factory.html#Albatross_Expression_Factory_Instance) or by creating a new instance. The factory class by default will register any class with the [ParserOperationAttribute](https://rushuiguan.github.io/expression/api/Albatross.Expression.ParserOperationAttribute.html) attribute within this assembly. Additional assemblies can be registered using the [Register(Assembly)](https://rushuiguan.github.io/expression/api/Albatross.Expression.Factory.html#Albatross_Expression_Factory_Register_System_Reflection_Assembly_) function.  

By default, the factory will use [SingleDoubleQuoteStringLiteralToken](https://rushuiguan.github.io/expression/api/Albatross.Expression.Tokens.SingleDoubleQuoteStringLiteralToken.html) for string literal token and [VariableToken](https://rushuiguan.github.io/expression/api/Albatross.Expression.Tokens.VariableToken.html) for variable token. These defaults can be changed for the factory instance object.

##### Inheritance

System.Object

Factory

##### Implements

System.Collections.Generic.IEnumerable<[IToken](https://rushuiguan.github.io/expression/api/Albatross.Expression.Tokens.IToken.html)\>

System.Collections.IEnumerable

###### **Namespace**: [Albatross.Expression](https://rushuiguan.github.io/expression/api/Albatross.Expression.html)

###### **Assembly**: Albatross.Expression.dll

##### Syntax

```
public class Factory : IEnumerable<IToken>, IEnumerable
```

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Factory.html#constructors)Constructors

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Factory.html#Albatross_Expression_Factory__ctor)Factory()

##### Declaration

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Factory.html#properties)Properties

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Factory.html#Albatross_Expression_Factory_Instance)Instance

##### Declaration

```
public static Factory Instance { get; }
```

##### Property Value

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Factory.html#methods)Methods

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Factory.html#Albatross_Expression_Factory_Create_Albatross_Expression_Tokens_IStringLiteralToken_Albatross_Expression_Tokens_IVariableToken_)Create(IStringLiteralToken, IVariableToken)

##### Declaration

```
public IParser Create(IStringLiteralToken stringLiteralToken = null, IVariableToken variableToken = null)
```

##### Parameters

##### Returns

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Factory.html#Albatross_Expression_Factory_DefaultStringLiteralToken_Albatross_Expression_Tokens_IStringLiteralToken_)DefaultStringLiteralToken(IStringLiteralToken)

##### Declaration

```
public Factory DefaultStringLiteralToken(IStringLiteralToken token)
```

##### Parameters

##### Returns

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Factory.html#Albatross_Expression_Factory_DefaultVariableToken_Albatross_Expression_Tokens_IVariableToken_)DefaultVariableToken(IVariableToken)

##### Declaration

```
public Factory DefaultVariableToken(IVariableToken variableToken)
```

##### Parameters

##### Returns

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Factory.html#Albatross_Expression_Factory_GetEnumerator)GetEnumerator()

##### Declaration

```
public IEnumerator<IToken> GetEnumerator()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Collections.Generic.IEnumerator<[IToken](https://rushuiguan.github.io/expression/api/Albatross.Expression.Tokens.IToken.html)\> |  |

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Factory.html#Albatross_Expression_Factory_Register_System_Collections_Generic_IEnumerable_Albatross_Expression_Tokens_IToken__)Register(IEnumerable<IToken>)

Register instances of tokens/operations

##### Declaration

```
public Factory Register(IEnumerable<IToken> tokens)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Collections.Generic.IEnumerable<[IToken](https://rushuiguan.github.io/expression/api/Albatross.Expression.Tokens.IToken.html)\> | tokens | 
Token/operations instances to register

 |

##### Returns

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Factory.html#Albatross_Expression_Factory_Register_System_Reflection_Assembly_)Register(Assembly)

##### Declaration

```
public Factory Register(Assembly asm)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Reflection.Assembly | asm |  |

##### Returns

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Factory.html#Albatross_Expression_Factory_Replace__2)Replace<T, K>()

##### Declaration

```
public Factory Replace<T, K>()

    where T : IToken where K : IToken, new()
```

##### Returns

##### Type Parameters

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Factory.html#eii)Explicit Interface Implementations

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Factory.html#Albatross_Expression_Factory_System_Collections_IEnumerable_GetEnumerator)IEnumerable.GetEnumerator()

##### Declaration

```
IEnumerator IEnumerable.GetEnumerator()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Collections.IEnumerator |  |

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Factory.html#implements)Implements

System.Collections.Generic.IEnumerable<T>

System.Collections.IEnumerable

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Factory.html#extensionmethods)Extension Methods
---
created: 2025-06-25T05:52:55 (UTC -04:00)
tags: []
source: https://rushuiguan.github.io/expression/api/Albatross.Expression.Tokens.InfixOperationToken.html
author: 
---

# Class InfixOperationToken

> ## Excerpt
> System.Object

---
##### Inheritance

System.Object

InfixOperationToken

##### Implements

###### **Namespace**: [Albatross.Expression.Tokens](https://rushuiguan.github.io/expression/api/Albatross.Expression.Tokens.html)

###### **Assembly**: Albatross.Expression.dll

##### Syntax

```
public abstract class InfixOperationToken : IToken
```

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Tokens.InfixOperationToken.html#properties)Properties

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Tokens.InfixOperationToken.html#Albatross_Expression_Tokens_InfixOperationToken_Name)Name

##### Declaration

```
public abstract string Name { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.String |  |

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Tokens.InfixOperationToken.html#Albatross_Expression_Tokens_InfixOperationToken_Operand1)Operand1

##### Declaration

```
public IToken Operand1 { get; set; }
```

##### Property Value

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Tokens.InfixOperationToken.html#Albatross_Expression_Tokens_InfixOperationToken_Operand2)Operand2

##### Declaration

```
public IToken Operand2 { get; set; }
```

##### Property Value

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Tokens.InfixOperationToken.html#Albatross_Expression_Tokens_InfixOperationToken_Precedence)Precedence

##### Declaration

```
public abstract int Precedence { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Int32 |  |

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Tokens.InfixOperationToken.html#Albatross_Expression_Tokens_InfixOperationToken_Symbolic)Symbolic

##### Declaration

```
public abstract bool Symbolic { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |  |

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Tokens.InfixOperationToken.html#methods)Methods

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Tokens.InfixOperationToken.html#Albatross_Expression_Tokens_InfixOperationToken_Clone)Clone()

##### Declaration

```
public virtual IToken Clone()
```

##### Returns

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Tokens.InfixOperationToken.html#Albatross_Expression_Tokens_InfixOperationToken_EvalText_System_String_)EvalText(String)

##### Declaration

```
public virtual string EvalText(string format)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | format |  |

##### Returns

| Type | Description |
| --- | --- |
| System.String |  |

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Tokens.InfixOperationToken.html#Albatross_Expression_Tokens_InfixOperationToken_EvalValue_System_Func_System_String_System_Object__)EvalValue(Func<String, Object>)

##### Declaration

```
public virtual object EvalValue(Func<string, object> context)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Func<System.String, System.Object\> | context |  |

##### Returns

| Type | Description |
| --- | --- |
| System.Object |  |

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Tokens.InfixOperationToken.html#Albatross_Expression_Tokens_InfixOperationToken_Match_System_String_System_Int32_System_Int32__)Match(String, Int32, out Int32)

##### Declaration

```
public virtual bool Match(string expression, int start, out int next)
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

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Tokens.InfixOperationToken.html#Albatross_Expression_Tokens_InfixOperationToken_ToString)ToString()

##### Declaration

```
public override string ToString()
```

##### Returns

| Type | Description |
| --- | --- |
| System.String |  |

##### Overrides

System.Object.ToString()

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Tokens.InfixOperationToken.html#implements)Implements

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Tokens.InfixOperationToken.html#extensionmethods)Extension Methods
---
created: 2025-06-25T05:51:42 (UTC -04:00)
tags: []
source: https://rushuiguan.github.io/expression/api/Albatross.Expression.Exceptions.MissingVariableException.html
author: 
---

# Class MissingVariableException

> ## Excerpt
> System.Object

---
##### Inheritance

System.Object

System.Exception

MissingVariableException

##### Implements

System.Runtime.Serialization.ISerializable

System.Runtime.InteropServices.\_Exception

###### **Namespace**: [Albatross.Expression.Exceptions](https://rushuiguan.github.io/expression/api/Albatross.Expression.Exceptions.html)

###### **Assembly**: Albatross.Expression.dll

##### Syntax

```
public class MissingVariableException : Exception, ISerializable, _Exception
```

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Exceptions.MissingVariableException.html#constructors)Constructors

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Exceptions.MissingVariableException.html#Albatross_Expression_Exceptions_MissingVariableException__ctor_System_String_)MissingVariableException(String)

##### Declaration

```
public MissingVariableException(string name)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | name |  |

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Exceptions.MissingVariableException.html#properties)Properties

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Exceptions.MissingVariableException.html#Albatross_Expression_Exceptions_MissingVariableException_VariableName)VariableName

##### Declaration

```
public string VariableName { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.String |  |

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Exceptions.MissingVariableException.html#implements)Implements

System.Runtime.Serialization.ISerializable

System.Runtime.InteropServices.\_Exception

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Exceptions.MissingVariableException.html#extensionmethods)Extension Methods
---
created: 2025-06-25T05:52:55 (UTC -04:00)
tags: []
source: https://rushuiguan.github.io/expression/api/Albatross.Expression.Tokens.NumericLiteralToken.html
author: 
---

# Class NumericLiteralToken

> ## Excerpt
> will take any numbers with decimals and without signs.

---
will take any numbers with decimals and without signs.

##### Inheritance

System.Object

NumericLiteralToken

##### Implements

###### **Namespace**: [Albatross.Expression.Tokens](https://rushuiguan.github.io/expression/api/Albatross.Expression.Tokens.html)

###### **Assembly**: Albatross.Expression.dll

##### Syntax

```
public class NumericLiteralToken : IOperandToken, IToken
```

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Tokens.NumericLiteralToken.html#properties)Properties

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Tokens.NumericLiteralToken.html#Albatross_Expression_Tokens_NumericLiteralToken_Group)Group

##### Declaration

```
public string Group { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.String |  |

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Tokens.NumericLiteralToken.html#Albatross_Expression_Tokens_NumericLiteralToken_Name)Name

##### Declaration

```
public string Name { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.String |  |

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Tokens.NumericLiteralToken.html#methods)Methods

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Tokens.NumericLiteralToken.html#Albatross_Expression_Tokens_NumericLiteralToken_Clone)Clone()

##### Declaration

##### Returns

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Tokens.NumericLiteralToken.html#Albatross_Expression_Tokens_NumericLiteralToken_EvalText_System_String_)EvalText(String)

##### Declaration

```
public string EvalText(string format)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | format |  |

##### Returns

| Type | Description |
| --- | --- |
| System.String |  |

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Tokens.NumericLiteralToken.html#Albatross_Expression_Tokens_NumericLiteralToken_EvalValue_System_Func_System_String_System_Object__)EvalValue(Func<String, Object>)

##### Declaration

```
public object EvalValue(Func<string, object> context)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Func<System.String, System.Object\> | context |  |

##### Returns

| Type | Description |
| --- | --- |
| System.Object |  |

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Tokens.NumericLiteralToken.html#Albatross_Expression_Tokens_NumericLiteralToken_Match_System_String_System_Int32_System_Int32__)Match(String, Int32, out Int32)

##### Declaration

```
public bool Match(string expression, int start, out int next)
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

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Tokens.NumericLiteralToken.html#Albatross_Expression_Tokens_NumericLiteralToken_ToString)ToString()

##### Declaration

```
public override string ToString()
```

##### Returns

| Type | Description |
| --- | --- |
| System.String |  |

##### Overrides

System.Object.ToString()

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Tokens.NumericLiteralToken.html#implements)Implements

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Tokens.NumericLiteralToken.html#extensionmethods)Extension Methods
---
created: 2025-06-25T05:51:42 (UTC -04:00)
tags: []
source: https://rushuiguan.github.io/expression/api/Albatross.Expression.Exceptions.OperandException.html
author: 
---

# Class OperandException

> ## Excerpt
> System.Object

---
##### Inheritance

System.Object

System.Exception

OperandException

##### Implements

System.Runtime.Serialization.ISerializable

System.Runtime.InteropServices.\_Exception

###### **Namespace**: [Albatross.Expression.Exceptions](https://rushuiguan.github.io/expression/api/Albatross.Expression.Exceptions.html)

###### **Assembly**: Albatross.Expression.dll

##### Syntax

```
public class OperandException : Exception, ISerializable, _Exception
```

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Exceptions.OperandException.html#constructors)Constructors

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Exceptions.OperandException.html#Albatross_Expression_Exceptions_OperandException__ctor_System_String_)OperandException(String)

##### Declaration

```
public OperandException(string operation)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | operation |  |

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Exceptions.OperandException.html#properties)Properties

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Exceptions.OperandException.html#Albatross_Expression_Exceptions_OperandException_Operation)Operation

##### Declaration

```
public string Operation { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.String |  |

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Exceptions.OperandException.html#implements)Implements

System.Runtime.Serialization.ISerializable

System.Runtime.InteropServices.\_Exception

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Exceptions.OperandException.html#extensionmethods)Extension Methods
---
created: 2025-06-25T05:37:38 (UTC -04:00)
tags: []
source: https://rushuiguan.github.io/expression/api/Albatross.Expression.Parser.html
author: 
---

# Class Parser

> ## Excerpt
> An immutable implementation of the IParser interface.

---
An immutable implementation of the [IParser](https://rushuiguan.github.io/expression/api/Albatross.Expression.IParser.html) interface.

##### Inheritance

System.Object

Parser

##### Implements

###### **Namespace**: [Albatross.Expression](https://rushuiguan.github.io/expression/api/Albatross.Expression.html)

###### **Assembly**: Albatross.Expression.dll

##### Syntax

```
public class Parser : IParser
```

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Parser.html#constructors)Constructors

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Parser.html#Albatross_Expression_Parser__ctor_System_Collections_Generic_IEnumerable_Albatross_Expression_Tokens_IToken__Albatross_Expression_Tokens_IVariableToken_Albatross_Expression_Tokens_IStringLiteralToken_)Parser(IEnumerable<IToken>, IVariableToken, IStringLiteralToken)

##### Declaration

```
public Parser(IEnumerable<IToken> operations, IVariableToken variableToken, IStringLiteralToken stringLiteralToken)
```

##### Parameters

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Parser.html#properties)Properties

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Parser.html#Albatross_Expression_Parser_InfixOperationTokens)InfixOperationTokens

##### Declaration

```
public IEnumerable<InfixOperationToken> InfixOperationTokens { get; }
```

##### Property Value

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Parser.html#Albatross_Expression_Parser_PrefixOperationTokens)PrefixOperationTokens

##### Declaration

```
public IEnumerable<PrefixOperationToken> PrefixOperationTokens { get; }
```

##### Property Value

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Parser.html#methods)Methods

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Parser.html#Albatross_Expression_Parser_BuildStack_System_Collections_Generic_Queue_Albatross_Expression_Tokens_IToken__)BuildStack(Queue<IToken>)

##### Declaration

```
public Stack<IToken> BuildStack(Queue<IToken> queue)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Collections.Generic.Queue<[IToken](https://rushuiguan.github.io/expression/api/Albatross.Expression.Tokens.IToken.html)\> | queue |  |

##### Returns

| Type | Description |
| --- | --- |
| System.Collections.Generic.Stack<[IToken](https://rushuiguan.github.io/expression/api/Albatross.Expression.Tokens.IToken.html)\> |  |

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Parser.html#Albatross_Expression_Parser_CreateTree_System_Collections_Generic_Stack_Albatross_Expression_Tokens_IToken__)CreateTree(Stack<IToken>)

##### Declaration

```
public IToken CreateTree(Stack<IToken> postfix)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Collections.Generic.Stack<[IToken](https://rushuiguan.github.io/expression/api/Albatross.Expression.Tokens.IToken.html)\> | postfix |  |

##### Returns

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Parser.html#Albatross_Expression_Parser_Eval_Albatross_Expression_Tokens_IToken_System_Func_System_String_System_Object__)Eval(IToken, Func<String, Object>)

##### Declaration

```
public object Eval(IToken token, Func<string, object> context)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [IToken](https://rushuiguan.github.io/expression/api/Albatross.Expression.Tokens.IToken.html) | token |  |
| System.Func<System.String, System.Object\> | context |  |

##### Returns

| Type | Description |
| --- | --- |
| System.Object |  |

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Parser.html#Albatross_Expression_Parser_EvalText_Albatross_Expression_Tokens_IToken_System_String_)EvalText(IToken, String)

##### Declaration

```
public string EvalText(IToken token, string format)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [IToken](https://rushuiguan.github.io/expression/api/Albatross.Expression.Tokens.IToken.html) | token |  |
| System.String | format |  |

##### Returns

| Type | Description |
| --- | --- |
| System.String |  |

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Parser.html#Albatross_Expression_Parser_IsValidExpression_System_String_)IsValidExpression(String)

##### Declaration

```
public bool IsValidExpression(string exp)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | exp |  |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |  |

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Parser.html#Albatross_Expression_Parser_Reverse__1_System_Collections_Generic_Stack___0__)Reverse<T>(Stack<T>)

##### Declaration

```
public static Stack<T> Reverse<T>(Stack<T> src)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Collections.Generic.Stack<T> | src |  |

##### Returns

| Type | Description |
| --- | --- |
| System.Collections.Generic.Stack<T> |  |

##### Type Parameters

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Parser.html#Albatross_Expression_Parser_StringLiteralToken)StringLiteralToken()

##### Declaration

```
public IStringLiteralToken StringLiteralToken()
```

##### Returns

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Parser.html#Albatross_Expression_Parser_Tokenize_System_String_)Tokenize(String)

##### Declaration

```
public Queue<IToken> Tokenize(string expression)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | expression |  |

##### Returns

| Type | Description |
| --- | --- |
| System.Collections.Generic.Queue<[IToken](https://rushuiguan.github.io/expression/api/Albatross.Expression.Tokens.IToken.html)\> |  |

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Parser.html#Albatross_Expression_Parser_VariableToken)VariableToken()

##### Declaration

```
public IToken VariableToken()
```

##### Returns

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Parser.html#implements)Implements

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Parser.html#extensionmethods)Extension Methods
---
created: 2025-06-25T05:37:38 (UTC -04:00)
tags: []
source: https://rushuiguan.github.io/expression/api/Albatross.Expression.ParserOperationAttribute.html
author: 
---

# Class ParserOperationAttribute

> ## Excerpt
> System.Object

---
##### Inheritance

System.Object

System.Attribute

ParserOperationAttribute

##### Implements

System.Runtime.InteropServices.\_Attribute

###### **Namespace**: [Albatross.Expression](https://rushuiguan.github.io/expression/api/Albatross.Expression.html)

###### **Assembly**: Albatross.Expression.dll

##### Syntax

```
[AttributeUsage(AttributeTargets.Class)]
public class ParserOperationAttribute : Attribute, _Attribute
```

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.ParserOperationAttribute.html#properties)Properties

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.ParserOperationAttribute.html#Albatross_Expression_ParserOperationAttribute_Description)Description

##### Declaration

```
public string Description { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.String |  |

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.ParserOperationAttribute.html#Albatross_Expression_ParserOperationAttribute_Group)Group

##### Declaration

```
public string Group { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.String |  |

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.ParserOperationAttribute.html#implements)Implements

System.Runtime.InteropServices.\_Attribute

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.ParserOperationAttribute.html#extensionmethods)Extension Methods
---
created: 2025-06-25T05:52:55 (UTC -04:00)
tags: []
source: https://rushuiguan.github.io/expression/api/Albatross.Expression.Tokens.PrefixOperationToken.html
author: 
---

# Class PrefixOperationToken

> ## Excerpt
> System.Object

---
##### Inheritance

System.Object

PrefixOperationToken

##### Implements

###### **Namespace**: [Albatross.Expression.Tokens](https://rushuiguan.github.io/expression/api/Albatross.Expression.Tokens.html)

###### **Assembly**: Albatross.Expression.dll

##### Syntax

```
public abstract class PrefixOperationToken : IToken
```

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Tokens.PrefixOperationToken.html#constructors)Constructors

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Tokens.PrefixOperationToken.html#Albatross_Expression_Tokens_PrefixOperationToken__ctor)PrefixOperationToken()

##### Declaration

```
public PrefixOperationToken()
```

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Tokens.PrefixOperationToken.html#properties)Properties

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Tokens.PrefixOperationToken.html#Albatross_Expression_Tokens_PrefixOperationToken_MaxOperandCount)MaxOperandCount

##### Declaration

```
public abstract int MaxOperandCount { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Int32 |  |

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Tokens.PrefixOperationToken.html#Albatross_Expression_Tokens_PrefixOperationToken_MinOperandCount)MinOperandCount

##### Declaration

```
public abstract int MinOperandCount { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Int32 |  |

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Tokens.PrefixOperationToken.html#Albatross_Expression_Tokens_PrefixOperationToken_Name)Name

##### Declaration

```
public abstract string Name { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.String |  |

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Tokens.PrefixOperationToken.html#Albatross_Expression_Tokens_PrefixOperationToken_Operands)Operands

##### Declaration

```
public List<IToken> Operands { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Collections.Generic.List<[IToken](https://rushuiguan.github.io/expression/api/Albatross.Expression.Tokens.IToken.html)\> |  |

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Tokens.PrefixOperationToken.html#Albatross_Expression_Tokens_PrefixOperationToken_Symbolic)Symbolic

##### Declaration

```
public abstract bool Symbolic { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |  |

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Tokens.PrefixOperationToken.html#methods)Methods

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Tokens.PrefixOperationToken.html#Albatross_Expression_Tokens_PrefixOperationToken_Clone)Clone()

##### Declaration

```
public virtual IToken Clone()
```

##### Returns

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Tokens.PrefixOperationToken.html#Albatross_Expression_Tokens_PrefixOperationToken_EvalText_System_String_)EvalText(String)

##### Declaration

```
public virtual string EvalText(string format)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | format |  |

##### Returns

| Type | Description |
| --- | --- |
| System.String |  |

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Tokens.PrefixOperationToken.html#Albatross_Expression_Tokens_PrefixOperationToken_EvalValue_System_Func_System_String_System_Object__)EvalValue(Func<String, Object>)

##### Declaration

```
public virtual object EvalValue(Func<string, object> context)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Func<System.String, System.Object\> | context |  |

##### Returns

| Type | Description |
| --- | --- |
| System.Object |  |

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Tokens.PrefixOperationToken.html#Albatross_Expression_Tokens_PrefixOperationToken_GetOperands_System_Func_System_String_System_Object__)GetOperands(Func<String, Object>)

##### Declaration

```
protected List<object> GetOperands(Func<string, object> context)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Func<System.String, System.Object\> | context |  |

##### Returns

| Type | Description |
| --- | --- |
| System.Collections.Generic.List<System.Object\> |  |

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Tokens.PrefixOperationToken.html#Albatross_Expression_Tokens_PrefixOperationToken_GetOperands_System_Func_System_String_System_Object__System_Type__)GetOperands(Func<String, Object>, out Type)

##### Declaration

```
protected List<object> GetOperands(Func<string, object> context, out Type firstType)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Func<System.String, System.Object\> | context |  |
| System.Type | firstType |  |

##### Returns

| Type | Description |
| --- | --- |
| System.Collections.Generic.List<System.Object\> |  |

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Tokens.PrefixOperationToken.html#Albatross_Expression_Tokens_PrefixOperationToken_GetOperands__1_System_Func_System_String_System_Object__)GetOperands<T>(Func<String, Object>)

##### Declaration

```
protected List<T> GetOperands<T>(Func<string, object> context)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Func<System.String, System.Object\> | context |  |

##### Returns

| Type | Description |
| --- | --- |
| System.Collections.Generic.List<T> |  |

##### Type Parameters

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Tokens.PrefixOperationToken.html#Albatross_Expression_Tokens_PrefixOperationToken_GetOperandText_System_Object_System_Int32_System_String_)GetOperandText(Object, Int32, String)

##### Declaration

```
protected string[] GetOperandText(object args, int count, string format)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Object | args |  |
| System.Int32 | count |  |
| System.String | format |  |

##### Returns

| Type | Description |
| --- | --- |
| System.String\[\] |  |

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Tokens.PrefixOperationToken.html#Albatross_Expression_Tokens_PrefixOperationToken_GetParamsOperands_System_Func_System_String_System_Object__System_Type__)GetParamsOperands(Func<String, Object>, out Type)

##### Declaration

```
protected IEnumerable GetParamsOperands(Func<string, object> context, out Type firstType)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Func<System.String, System.Object\> | context |  |
| System.Type | firstType |  |

##### Returns

| Type | Description |
| --- | --- |
| System.Collections.IEnumerable |  |

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Tokens.PrefixOperationToken.html#Albatross_Expression_Tokens_PrefixOperationToken_Match_System_String_System_Int32_System_Int32__)Match(String, Int32, out Int32)

##### Declaration

```
public bool Match(string expression, int start, out int next)
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

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Tokens.PrefixOperationToken.html#Albatross_Expression_Tokens_PrefixOperationToken_ToString)ToString()

##### Declaration

```
public override string ToString()
```

##### Returns

| Type | Description |
| --- | --- |
| System.String |  |

##### Overrides

System.Object.ToString()

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Tokens.PrefixOperationToken.html#implements)Implements

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Tokens.PrefixOperationToken.html#extensionmethods)Extension Methods
---
created: 2025-06-25T05:37:38 (UTC -04:00)
tags: []
source: https://rushuiguan.github.io/expression/api/Albatross.Expression.ReflectionExecutionContextFactory-1.html
author: 
---

# Class ReflectionExecutionContextFactory<T>

> ## Excerpt
> System.Object

---
##### Inheritance

System.Object

ReflectionExecutionContextFactory<T>

##### Implements

###### **Namespace**: [Albatross.Expression](https://rushuiguan.github.io/expression/api/Albatross.Expression.html)

###### **Assembly**: Albatross.Expression.dll

##### Syntax

```
public class ReflectionExecutionContextFactory<T> : IExecutionContextFactory<T>
```

##### Type Parameters

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.ReflectionExecutionContextFactory-1.html#constructors)Constructors

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.ReflectionExecutionContextFactory-1.html#Albatross_Expression_ReflectionExecutionContextFactory_1__ctor_Albatross_Expression_IParser_)ReflectionExecutionContextFactory(IParser)

##### Declaration

```
public ReflectionExecutionContextFactory(IParser parser)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [IParser](https://rushuiguan.github.io/expression/api/Albatross.Expression.IParser.html) | parser |  |

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.ReflectionExecutionContextFactory-1.html#properties)Properties

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.ReflectionExecutionContextFactory-1.html#Albatross_Expression_ReflectionExecutionContextFactory_1_CacheExternalValue)CacheExternalValue

##### Declaration

```
public bool CacheExternalValue { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |  |

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.ReflectionExecutionContextFactory-1.html#Albatross_Expression_ReflectionExecutionContextFactory_1_CaseSensitive)CaseSensitive

##### Declaration

```
public bool CaseSensitive { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |  |

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.ReflectionExecutionContextFactory-1.html#Albatross_Expression_ReflectionExecutionContextFactory_1_FailWhenMissingVariable)FailWhenMissingVariable

##### Declaration

```
public bool FailWhenMissingVariable { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |  |

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.ReflectionExecutionContextFactory-1.html#methods)Methods

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.ReflectionExecutionContextFactory-1.html#Albatross_Expression_ReflectionExecutionContextFactory_1_Create)Create()

##### Declaration

```
public IExecutionContext<T> Create()
```

##### Returns

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.ReflectionExecutionContextFactory-1.html#Albatross_Expression_ReflectionExecutionContextFactory_1_TryGetExternalValue_System_String__0_System_Object__)TryGetExternalValue(String, T, out Object)

##### Declaration

```
public bool TryGetExternalValue(string name, T obj, out object value)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | name |  |
| T | obj |  |
| System.Object | value |  |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |  |

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.ReflectionExecutionContextFactory-1.html#implements)Implements

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.ReflectionExecutionContextFactory-1.html#extensionmethods)Extension Methods
---
created: 2025-06-25T05:52:55 (UTC -04:00)
tags: []
source: https://rushuiguan.github.io/expression/api/Albatross.Expression.Tokens.SingleDoubleQuoteStringLiteralToken.html
author: 
---

# Class SingleDoubleQuoteStringLiteralToken

> ## Excerpt
> A string literal token that can use either single quote or double quote as the string boundary.  The Boundary
property is set to double quote by default.  It will be changed to the correct boundary when the expression is parsed.

---
A string literal token that can use either single quote or double quote as the string boundary. The [Boundary](https://rushuiguan.github.io/expression/api/Albatross.Expression.Tokens.SingleDoubleQuoteStringLiteralToken.html#Albatross_Expression_Tokens_SingleDoubleQuoteStringLiteralToken_Boundary) property is set to double quote by default. It will be changed to the correct boundary when the expression is parsed.

##### Inheritance

System.Object

SingleDoubleQuoteStringLiteralToken

##### Implements

##### Inherited Members

###### **Namespace**: [Albatross.Expression.Tokens](https://rushuiguan.github.io/expression/api/Albatross.Expression.Tokens.html)

###### **Assembly**: Albatross.Expression.dll

##### Syntax

```
public class SingleDoubleQuoteStringLiteralToken : StringLiteralToken, IOperandToken, IStringLiteralToken, IToken
```

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Tokens.SingleDoubleQuoteStringLiteralToken.html#properties)Properties

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Tokens.SingleDoubleQuoteStringLiteralToken.html#Albatross_Expression_Tokens_SingleDoubleQuoteStringLiteralToken_Boundary)Boundary

##### Declaration

```
public override char Boundary { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Char |  |

##### Overrides

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Tokens.SingleDoubleQuoteStringLiteralToken.html#methods)Methods

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Tokens.SingleDoubleQuoteStringLiteralToken.html#Albatross_Expression_Tokens_SingleDoubleQuoteStringLiteralToken_Clone)Clone()

##### Declaration

```
public override IToken Clone()
```

##### Returns

##### Overrides

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Tokens.SingleDoubleQuoteStringLiteralToken.html#Albatross_Expression_Tokens_SingleDoubleQuoteStringLiteralToken_Match_System_String_System_Int32_System_Int32__)Match(String, Int32, out Int32)

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

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Tokens.SingleDoubleQuoteStringLiteralToken.html#implements)Implements

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Tokens.SingleDoubleQuoteStringLiteralToken.html#extensionmethods)Extension Methods
---
created: 2025-06-25T05:52:55 (UTC -04:00)
tags: []
source: https://rushuiguan.github.io/expression/api/Albatross.Expression.Tokens.SingleQuoteStringLiteralToken.html
author: 
---

# Class SingleQuoteStringLiteralToken

> ## Excerpt
> will take any string literal enclosed by double quotes.  use back slash to escape.Check the GetStringEscape function for escapable chars

---
will take any string literal enclosed by double quotes. use back slash to escape.  
Check the GetStringEscape function for escapable chars

##### Inheritance

System.Object

SingleQuoteStringLiteralToken

##### Implements

##### Inherited Members

###### **Namespace**: [Albatross.Expression.Tokens](https://rushuiguan.github.io/expression/api/Albatross.Expression.Tokens.html)

###### **Assembly**: Albatross.Expression.dll

##### Syntax

```
public class SingleQuoteStringLiteralToken : StringLiteralToken, IOperandToken, IStringLiteralToken, IToken
```

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Tokens.SingleQuoteStringLiteralToken.html#properties)Properties

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Tokens.SingleQuoteStringLiteralToken.html#Albatross_Expression_Tokens_SingleQuoteStringLiteralToken_Boundary)Boundary

##### Declaration

```
public override char Boundary { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Char |  |

##### Overrides

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Tokens.SingleQuoteStringLiteralToken.html#methods)Methods

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Tokens.SingleQuoteStringLiteralToken.html#Albatross_Expression_Tokens_SingleQuoteStringLiteralToken_Clone)Clone()

##### Declaration

```
public override IToken Clone()
```

##### Returns

##### Overrides

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Tokens.SingleQuoteStringLiteralToken.html#implements)Implements

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Tokens.SingleQuoteStringLiteralToken.html#extensionmethods)Extension Methods
---
created: 2025-06-25T05:51:42 (UTC -04:00)
tags: []
source: https://rushuiguan.github.io/expression/api/Albatross.Expression.Exceptions.StackException.html
author: 
---

# Class StackException

> ## Excerpt
> System.Object

---
##### Inheritance

System.Object

System.Exception

StackException

##### Implements

System.Runtime.Serialization.ISerializable

System.Runtime.InteropServices.\_Exception

###### **Namespace**: [Albatross.Expression.Exceptions](https://rushuiguan.github.io/expression/api/Albatross.Expression.Exceptions.html)

###### **Assembly**: Albatross.Expression.dll

##### Syntax

```
public class StackException : Exception, ISerializable, _Exception
```

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Exceptions.StackException.html#constructors)Constructors

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Exceptions.StackException.html#Albatross_Expression_Exceptions_StackException__ctor_System_String_)StackException(String)

##### Declaration

```
public StackException(string msg)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | msg |  |

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Exceptions.StackException.html#implements)Implements

System.Runtime.Serialization.ISerializable

System.Runtime.InteropServices.\_Exception

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Exceptions.StackException.html#extensionmethods)Extension Methods
---
created: 2025-06-25T05:52:55 (UTC -04:00)
tags: []
source: https://rushuiguan.github.io/expression/api/Albatross.Expression.Tokens.StringLiteralToken.html
author: 
---

# Class StringLiteralToken

> ## Excerpt
> will take any string literal enclosed by double quotes.  use back slash to escape.Check the GetStringEscape function for escapable chars

---
will take any string literal enclosed by double quotes. use back slash to escape.  
Check the GetStringEscape function for escapable chars

##### Inheritance

System.Object

StringLiteralToken

##### Implements

###### **Namespace**: [Albatross.Expression.Tokens](https://rushuiguan.github.io/expression/api/Albatross.Expression.Tokens.html)

###### **Assembly**: Albatross.Expression.dll

##### Syntax

```
public abstract class StringLiteralToken : IOperandToken, IStringLiteralToken, IToken
```

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Tokens.StringLiteralToken.html#fields)Fields

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Tokens.StringLiteralToken.html#Albatross_Expression_Tokens_StringLiteralToken_EscapeChar)EscapeChar

##### Declaration

```
public const char EscapeChar = '\\'
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Char |  |

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Tokens.StringLiteralToken.html#properties)Properties

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Tokens.StringLiteralToken.html#Albatross_Expression_Tokens_StringLiteralToken_Boundary)Boundary

##### Declaration

```
public abstract char Boundary { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Char |  |

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Tokens.StringLiteralToken.html#Albatross_Expression_Tokens_StringLiteralToken_Group)Group

##### Declaration

```
public string Group { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.String |  |

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Tokens.StringLiteralToken.html#Albatross_Expression_Tokens_StringLiteralToken_Name)Name

##### Declaration

```
public string Name { get; protected set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.String |  |

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Tokens.StringLiteralToken.html#methods)Methods

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Tokens.StringLiteralToken.html#Albatross_Expression_Tokens_StringLiteralToken_Clone)Clone()

##### Declaration

```
public abstract IToken Clone()
```

##### Returns

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Tokens.StringLiteralToken.html#Albatross_Expression_Tokens_StringLiteralToken_EvalText_System_String_)EvalText(String)

##### Declaration

```
public string EvalText(string format)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | format |  |

##### Returns

| Type | Description |
| --- | --- |
| System.String |  |

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Tokens.StringLiteralToken.html#Albatross_Expression_Tokens_StringLiteralToken_EvalValue_System_Func_System_String_System_Object__)EvalValue(Func<String, Object>)

##### Declaration

```
public object EvalValue(Func<string, object> context)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Func<System.String, System.Object\> | context |  |

##### Returns

| Type | Description |
| --- | --- |
| System.Object |  |

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Tokens.StringLiteralToken.html#Albatross_Expression_Tokens_StringLiteralToken_Match_System_String_System_Int32_System_Int32__)Match(String, Int32, out Int32)

##### Declaration

```
public virtual bool Match(string expression, int start, out int next)
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

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Tokens.StringLiteralToken.html#Albatross_Expression_Tokens_StringLiteralToken_ToString)ToString()

##### Declaration

```
public override string ToString()
```

##### Returns

| Type | Description |
| --- | --- |
| System.String |  |

##### Overrides

System.Object.ToString()

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Tokens.StringLiteralToken.html#implements)Implements

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Tokens.StringLiteralToken.html#extensionmethods)Extension Methods
---
created: 2025-06-25T05:51:42 (UTC -04:00)
tags: []
source: https://rushuiguan.github.io/expression/api/Albatross.Expression.Exceptions.TokenParsingException.html
author: 
---

# Class TokenParsingException

> ## Excerpt
> System.Object

---
##### Inheritance

System.Object

System.Exception

TokenParsingException

##### Implements

System.Runtime.Serialization.ISerializable

System.Runtime.InteropServices.\_Exception

###### **Namespace**: [Albatross.Expression.Exceptions](https://rushuiguan.github.io/expression/api/Albatross.Expression.Exceptions.html)

###### **Assembly**: Albatross.Expression.dll

##### Syntax

```
public class TokenParsingException : Exception, ISerializable, _Exception
```

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Exceptions.TokenParsingException.html#constructors)Constructors

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Exceptions.TokenParsingException.html#Albatross_Expression_Exceptions_TokenParsingException__ctor_System_String_)TokenParsingException(String)

##### Declaration

```
public TokenParsingException(string msg)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | msg |  |

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Exceptions.TokenParsingException.html#implements)Implements

System.Runtime.Serialization.ISerializable

System.Runtime.InteropServices.\_Exception

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Exceptions.TokenParsingException.html#extensionmethods)Extension Methods
---
created: 2025-06-25T05:51:42 (UTC -04:00)
tags: []
source: https://rushuiguan.github.io/expression/api/Albatross.Expression.Exceptions.UnexpectedTypeException.html
author: 
---

# Class UnexpectedTypeException

> ## Excerpt
> System.Object

---
##### Inheritance

System.Object

System.Exception

UnexpectedTypeException

##### Implements

System.Runtime.Serialization.ISerializable

System.Runtime.InteropServices.\_Exception

###### **Namespace**: [Albatross.Expression.Exceptions](https://rushuiguan.github.io/expression/api/Albatross.Expression.Exceptions.html)

###### **Assembly**: Albatross.Expression.dll

##### Syntax

```
public class UnexpectedTypeException : Exception, ISerializable, _Exception
```

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Exceptions.UnexpectedTypeException.html#constructors)Constructors

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Exceptions.UnexpectedTypeException.html#Albatross_Expression_Exceptions_UnexpectedTypeException__ctor)UnexpectedTypeException()

##### Declaration

```
public UnexpectedTypeException()
```

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Exceptions.UnexpectedTypeException.html#Albatross_Expression_Exceptions_UnexpectedTypeException__ctor_System_String_)UnexpectedTypeException(String)

##### Declaration

```
public UnexpectedTypeException(string msg)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | msg |  |

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Exceptions.UnexpectedTypeException.html#Albatross_Expression_Exceptions_UnexpectedTypeException__ctor_System_Type_)UnexpectedTypeException(Type)

##### Declaration

```
public UnexpectedTypeException(Type type)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Type | type |  |

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Exceptions.UnexpectedTypeException.html#Albatross_Expression_Exceptions_UnexpectedTypeException__ctor_System_Type_System_Type_)UnexpectedTypeException(Type, Type)

##### Declaration

```
public UnexpectedTypeException(Type type1, Type type2)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Type | type1 |  |
| System.Type | type2 |  |

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Exceptions.UnexpectedTypeException.html#implements)Implements

System.Runtime.Serialization.ISerializable

System.Runtime.InteropServices.\_Exception

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Exceptions.UnexpectedTypeException.html#extensionmethods)Extension Methods
---
created: 2025-06-25T05:52:55 (UTC -04:00)
tags: []
source: https://rushuiguan.github.io/expression/api/Albatross.Expression.Tokens.VariableToken.html
author: 
---

# Class VariableToken

> ## Excerpt
> VariableToken class will look for names in the expression string.  It follows the same rule as C# variable names which allows alpha numeric 
and underline characters.  The leading character of a variable cannot be numeric.  In addition, it allows two name to be joined together using a period.  So "name1.name2" is also OK.  However "name1.name2.name3" 
is not allowed.

---
VariableToken class will look for names in the expression string. It follows the same rule as C# variable names which allows alpha numeric and underline characters. The leading character of a variable cannot be numeric. In addition, it allows two name to be joined together using a period. So "name1.name2" is also OK. However "name1.name2.name3" is not allowed.

Note: a variable name cannot be followed by a open parentheses because it will become a function. Please keep that in mind when creating a custom [IVariableToken](https://rushuiguan.github.io/expression/api/Albatross.Expression.Tokens.IVariableToken.html) implementation.

**Legal Variable Names**

-   cat
-   _cat_
-   cat
-   cat0\_
-   field.cat0\_
-   field0.cat0\_

**Illegal Variable Names**

-   test.field0.cat0\_
-   0cat
-   cat.1cat
-   0cat.cat
-   $cat$

##### Inheritance

System.Object

VariableToken

##### Implements

###### **Namespace**: [Albatross.Expression.Tokens](https://rushuiguan.github.io/expression/api/Albatross.Expression.Tokens.html)

###### **Assembly**: Albatross.Expression.dll

##### Syntax

```
public class VariableToken : IVariableToken, IOperandToken, IToken
```

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Tokens.VariableToken.html#properties)Properties

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Tokens.VariableToken.html#Albatross_Expression_Tokens_VariableToken_Calculated)Calculated

##### Declaration

```
public bool Calculated { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |  |

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Tokens.VariableToken.html#Albatross_Expression_Tokens_VariableToken_Group)Group

##### Declaration

```
public string Group { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.String |  |

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Tokens.VariableToken.html#Albatross_Expression_Tokens_VariableToken_Name)Name

##### Declaration

```
public string Name { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.String |  |

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Tokens.VariableToken.html#Albatross_Expression_Tokens_VariableToken_Value)Value

##### Declaration

```
public object Value { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Object |  |

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Tokens.VariableToken.html#methods)Methods

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Tokens.VariableToken.html#Albatross_Expression_Tokens_VariableToken_Clone)Clone()

##### Declaration

##### Returns

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Tokens.VariableToken.html#Albatross_Expression_Tokens_VariableToken_CompareTo_Albatross_Expression_Tokens_IOperandToken_)CompareTo(IOperandToken)

##### Declaration

```
public int CompareTo(IOperandToken other)
```

##### Parameters

##### Returns

| Type | Description |
| --- | --- |
| System.Int32 |  |

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Tokens.VariableToken.html#Albatross_Expression_Tokens_VariableToken_EvalText_System_String_)EvalText(String)

##### Declaration

```
public string EvalText(string format)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | format |  |

##### Returns

| Type | Description |
| --- | --- |
| System.String |  |

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Tokens.VariableToken.html#Albatross_Expression_Tokens_VariableToken_EvalValue_System_Func_System_String_System_Object__)EvalValue(Func<String, Object>)

##### Declaration

```
public object EvalValue(Func<string, object> context)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Func<System.String, System.Object\> | context |  |

##### Returns

| Type | Description |
| --- | --- |
| System.Object |  |

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Tokens.VariableToken.html#Albatross_Expression_Tokens_VariableToken_Match_System_String_System_Int32_System_Int32__)Match(String, Int32, out Int32)

##### Declaration

```
public bool Match(string expression, int start, out int next)
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

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Tokens.VariableToken.html#Albatross_Expression_Tokens_VariableToken_ToString)ToString()

##### Declaration

```
public override string ToString()
```

##### Returns

| Type | Description |
| --- | --- |
| System.String |  |

##### Overrides

System.Object.ToString()

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Tokens.VariableToken.html#implements)Implements

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Tokens.VariableToken.html#extensionmethods)Extension Methods
---
created: 2025-06-25T05:37:38 (UTC -04:00)
tags: []
source: https://rushuiguan.github.io/expression/api/Albatross.Expression.TryGetValueDelegate-1.html
author: 
---

# Delegate TryGetValueDelegate<T>

> ## Excerpt
> Extensions.ConvertToBoolean(Object)

---
###### **Namespace**: [Albatross.Expression](https://rushuiguan.github.io/expression/api/Albatross.Expression.html)

###### **Assembly**: Albatross.Expression.dll

##### Syntax

```
public delegate bool TryGetValueDelegate<T>(string name, T input, out object value);
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | name |  |
| T | input |  |
| System.Object | value |  |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |  |

##### Type Parameters

| Name | Description |
| --- | --- |
| T |  |

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.TryGetValueDelegate-1.html#extensionmethods)Extension Methods

[Extensions.ConvertToBoolean(Object)](https://rushuiguan.github.io/expression/api/Albatross.Expression.Extensions.html#Albatross_Expression_Extensions_ConvertToBoolean_System_Object_)
---
created: 2025-06-25T05:37:38 (UTC -04:00)
tags: []
source: https://rushuiguan.github.io/expression/api/Albatross.Expression.ContextType.html
author: 
---

# Enum ContextType

> ## Excerpt
> 

---
###### **Namespace**: [Albatross.Expression](https://rushuiguan.github.io/expression/api/Albatross.Expression.html)

###### **Assembly**: Albatross.Expression.dll

##### Syntax

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.ContextType.html#fields)Fields

| Name | Description |
| --- | --- |
| Expression |  |
| Value |  |

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.ContextType.html#extensionmethods)Extension Methods
---
created: 2025-06-25T05:37:38 (UTC -04:00)
tags: []
source: https://rushuiguan.github.io/expression/api/Albatross.Expression.IExecutionContextFactory-1.html
author: 
---

# Interface IExecutionContextFactory<T>

> ## Excerpt
> 

---
###### **Namespace**: [Albatross.Expression](https://rushuiguan.github.io/expression/api/Albatross.Expression.html)

###### **Assembly**: Albatross.Expression.dll

##### Syntax

```
public interface IExecutionContextFactory<T>
```

##### Type Parameters

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.IExecutionContextFactory-1.html#properties)Properties

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.IExecutionContextFactory-1.html#Albatross_Expression_IExecutionContextFactory_1_CacheExternalValue)CacheExternalValue

##### Declaration

```
bool CacheExternalValue { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |  |

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.IExecutionContextFactory-1.html#Albatross_Expression_IExecutionContextFactory_1_CaseSensitive)CaseSensitive

##### Declaration

```
bool CaseSensitive { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |  |

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.IExecutionContextFactory-1.html#Albatross_Expression_IExecutionContextFactory_1_FailWhenMissingVariable)FailWhenMissingVariable

##### Declaration

```
bool FailWhenMissingVariable { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |  |

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.IExecutionContextFactory-1.html#methods)Methods

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.IExecutionContextFactory-1.html#Albatross_Expression_IExecutionContextFactory_1_Create)Create()

##### Declaration

```
IExecutionContext<T> Create()
```

##### Returns

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.IExecutionContextFactory-1.html#Albatross_Expression_IExecutionContextFactory_1_TryGetExternalValue_System_String__0_System_Object__)TryGetExternalValue(String, T, out Object)

##### Declaration

```
bool TryGetExternalValue(string name, T input, out object value)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | name |  |
| T | input |  |
| System.Object | value |  |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |  |

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.IExecutionContextFactory-1.html#extensionmethods)Extension Methods
---
created: 2025-06-25T05:37:38 (UTC -04:00)
tags: []
source: https://rushuiguan.github.io/expression/api/Albatross.Expression.IExecutionContext-1.html
author: 
---

# Interface IExecutionContext<T>

> ## Excerpt
> System.Collections.Generic.IEnumerable<Albatross.Expression.ContextValue>.GetEnumerator()

---
##### Inherited Members

System.Collections.Generic.IEnumerable<Albatross.Expression.ContextValue>.GetEnumerator()

###### **Namespace**: [Albatross.Expression](https://rushuiguan.github.io/expression/api/Albatross.Expression.html)

###### **Assembly**: Albatross.Expression.dll

##### Syntax

```
public interface IExecutionContext<T> : IEnumerable<ContextValue>, IEnumerable
```

##### Type Parameters

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.IExecutionContext-1.html#properties)Properties

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.IExecutionContext-1.html#Albatross_Expression_IExecutionContext_1_CacheExternalValue)CacheExternalValue

##### Declaration

```
bool CacheExternalValue { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |  |

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.IExecutionContext-1.html#Albatross_Expression_IExecutionContext_1_CaseSensitive)CaseSensitive

##### Declaration

```
bool CaseSensitive { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |  |

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.IExecutionContext-1.html#Albatross_Expression_IExecutionContext_1_FailWhenMissingVariable)FailWhenMissingVariable

##### Declaration

```
bool FailWhenMissingVariable { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |  |

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.IExecutionContext-1.html#Albatross_Expression_IExecutionContext_1_Parser)Parser

##### Declaration

##### Property Value

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.IExecutionContext-1.html#methods)Methods

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.IExecutionContext-1.html#Albatross_Expression_IExecutionContext_1_Build)Build()

##### Declaration

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.IExecutionContext-1.html#Albatross_Expression_IExecutionContext_1_Clear)Clear()

##### Declaration

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.IExecutionContext-1.html#Albatross_Expression_IExecutionContext_1_Eval_System_String__0_System_Type_)Eval(String, T, Type)

##### Declaration

```
object Eval(string expression, T input, Type outputDataType)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | expression |  |
| T | input |  |
| System.Type | outputDataType |  |

##### Returns

| Type | Description |
| --- | --- |
| System.Object |  |

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.IExecutionContext-1.html#Albatross_Expression_IExecutionContext_1_GetValue_System_String__0_)GetValue(String, T)

##### Declaration

```
object GetValue(string name, T input)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | name |  |
| T | input |  |

##### Returns

| Type | Description |
| --- | --- |
| System.Object |  |

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.IExecutionContext-1.html#Albatross_Expression_IExecutionContext_1_Set_Albatross_Expression_ContextValue_)Set(ContextValue)

##### Declaration

```
void Set(ContextValue value)
```

##### Parameters

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.IExecutionContext-1.html#Albatross_Expression_IExecutionContext_1_TryGetValue_System_String__0_System_Object__)TryGetValue(String, T, out Object)

##### Declaration

```
bool TryGetValue(string name, T input, out object data)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | name |  |
| T | input |  |
| System.Object | data |  |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |  |

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.IExecutionContext-1.html#extensionmethods)Extension Methods
---
created: 2025-06-25T05:52:55 (UTC -04:00)
tags: []
source: https://rushuiguan.github.io/expression/api/Albatross.Expression.Tokens.IOperandToken.html
author: 
---

# Interface IOperandToken

> ## Excerpt
> IToken.Name

---
##### Inherited Members

[IToken.Name](https://rushuiguan.github.io/expression/api/Albatross.Expression.Tokens.IToken.html#Albatross_Expression_Tokens_IToken_Name)

[IToken.Match(String, Int32, Int32)](https://rushuiguan.github.io/expression/api/Albatross.Expression.Tokens.IToken.html#Albatross_Expression_Tokens_IToken_Match_System_String_System_Int32_System_Int32__)

[IToken.EvalText(String)](https://rushuiguan.github.io/expression/api/Albatross.Expression.Tokens.IToken.html#Albatross_Expression_Tokens_IToken_EvalText_System_String_)

[IToken.EvalValue(Func<String, Object>)](https://rushuiguan.github.io/expression/api/Albatross.Expression.Tokens.IToken.html#Albatross_Expression_Tokens_IToken_EvalValue_System_Func_System_String_System_Object__)

[IToken.Clone()](https://rushuiguan.github.io/expression/api/Albatross.Expression.Tokens.IToken.html#Albatross_Expression_Tokens_IToken_Clone)

###### **Namespace**: [Albatross.Expression.Tokens](https://rushuiguan.github.io/expression/api/Albatross.Expression.Tokens.html)

###### **Assembly**: Albatross.Expression.dll

##### Syntax

```
public interface IOperandToken : IToken
```

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Tokens.IOperandToken.html#extensionmethods)Extension Methods

[Extensions.ConvertToBoolean(Object)](https://rushuiguan.github.io/expression/api/Albatross.Expression.Extensions.html#Albatross_Expression_Extensions_ConvertToBoolean_System_Object_)

[Extensions.IsVariable(IToken)](https://rushuiguan.github.io/expression/api/Albatross.Expression.Extensions.html#Albatross_Expression_Extensions_IsVariable_Albatross_Expression_Tokens_IToken_)
---
created: 2025-06-25T05:37:38 (UTC -04:00)
tags: []
source: https://rushuiguan.github.io/expression/api/Albatross.Expression.IParser.html
author: 
---

# Interface IParser

> ## Excerpt
> The interface contains functionalities to process an expression string.

---
The interface contains functionalities to process an expression string.

###### **Namespace**: [Albatross.Expression](https://rushuiguan.github.io/expression/api/Albatross.Expression.html)

###### **Assembly**: Albatross.Expression.dll

##### Syntax

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.IParser.html#methods)Methods

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.IParser.html#Albatross_Expression_IParser_BuildStack_System_Collections_Generic_Queue_Albatross_Expression_Tokens_IToken__)BuildStack(Queue<IToken>)

##### Declaration

```
Stack<IToken> BuildStack(Queue<IToken> queue)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Collections.Generic.Queue<[IToken](https://rushuiguan.github.io/expression/api/Albatross.Expression.Tokens.IToken.html)\> | queue |  |

##### Returns

| Type | Description |
| --- | --- |
| System.Collections.Generic.Stack<[IToken](https://rushuiguan.github.io/expression/api/Albatross.Expression.Tokens.IToken.html)\> |  |

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.IParser.html#Albatross_Expression_IParser_CreateTree_System_Collections_Generic_Stack_Albatross_Expression_Tokens_IToken__)CreateTree(Stack<IToken>)

##### Declaration

```
IToken CreateTree(Stack<IToken> postfix)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Collections.Generic.Stack<[IToken](https://rushuiguan.github.io/expression/api/Albatross.Expression.Tokens.IToken.html)\> | postfix |  |

##### Returns

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.IParser.html#Albatross_Expression_IParser_Eval_Albatross_Expression_Tokens_IToken_System_Func_System_String_System_Object__)Eval(IToken, Func<String, Object>)

##### Declaration

```
object Eval(IToken token, Func<string, object> context)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [IToken](https://rushuiguan.github.io/expression/api/Albatross.Expression.Tokens.IToken.html) | token |  |
| System.Func<System.String, System.Object\> | context |  |

##### Returns

| Type | Description |
| --- | --- |
| System.Object |  |

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.IParser.html#Albatross_Expression_IParser_IsValidExpression_System_String_)IsValidExpression(String)

##### Declaration

```
bool IsValidExpression(string expression)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | expression |  |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |  |

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.IParser.html#Albatross_Expression_IParser_StringLiteralToken)StringLiteralToken()

##### Declaration

```
IStringLiteralToken StringLiteralToken()
```

##### Returns

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.IParser.html#Albatross_Expression_IParser_Tokenize_System_String_)Tokenize(String)

##### Declaration

```
Queue<IToken> Tokenize(string expression)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | expression |  |

##### Returns

| Type | Description |
| --- | --- |
| System.Collections.Generic.Queue<[IToken](https://rushuiguan.github.io/expression/api/Albatross.Expression.Tokens.IToken.html)\> |  |

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.IParser.html#Albatross_Expression_IParser_VariableToken)VariableToken()

##### Declaration

##### Returns

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.IParser.html#extensionmethods)Extension Methods
---
created: 2025-06-25T05:52:55 (UTC -04:00)
tags: []
source: https://rushuiguan.github.io/expression/api/Albatross.Expression.Tokens.IStringLiteralToken.html
author: 
---

# Interface IStringLiteralToken

> ## Excerpt
> IToken.Name

---
##### Inherited Members

[IToken.Name](https://rushuiguan.github.io/expression/api/Albatross.Expression.Tokens.IToken.html#Albatross_Expression_Tokens_IToken_Name)

[IToken.Match(String, Int32, Int32)](https://rushuiguan.github.io/expression/api/Albatross.Expression.Tokens.IToken.html#Albatross_Expression_Tokens_IToken_Match_System_String_System_Int32_System_Int32__)

[IToken.EvalText(String)](https://rushuiguan.github.io/expression/api/Albatross.Expression.Tokens.IToken.html#Albatross_Expression_Tokens_IToken_EvalText_System_String_)

[IToken.EvalValue(Func<String, Object>)](https://rushuiguan.github.io/expression/api/Albatross.Expression.Tokens.IToken.html#Albatross_Expression_Tokens_IToken_EvalValue_System_Func_System_String_System_Object__)

[IToken.Clone()](https://rushuiguan.github.io/expression/api/Albatross.Expression.Tokens.IToken.html#Albatross_Expression_Tokens_IToken_Clone)

###### **Namespace**: [Albatross.Expression.Tokens](https://rushuiguan.github.io/expression/api/Albatross.Expression.Tokens.html)

###### **Assembly**: Albatross.Expression.dll

##### Syntax

```
public interface IStringLiteralToken : IToken
```

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Tokens.IStringLiteralToken.html#properties)Properties

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Tokens.IStringLiteralToken.html#Albatross_Expression_Tokens_IStringLiteralToken_Boundary)Boundary

##### Declaration

```
char Boundary { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Char |  |

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Tokens.IStringLiteralToken.html#extensionmethods)Extension Methods

[Extensions.ConvertToBoolean(Object)](https://rushuiguan.github.io/expression/api/Albatross.Expression.Extensions.html#Albatross_Expression_Extensions_ConvertToBoolean_System_Object_)

[Extensions.IsVariable(IToken)](https://rushuiguan.github.io/expression/api/Albatross.Expression.Extensions.html#Albatross_Expression_Extensions_IsVariable_Albatross_Expression_Tokens_IToken_)
---
created: 2025-06-25T05:52:55 (UTC -04:00)
tags: []
source: https://rushuiguan.github.io/expression/api/Albatross.Expression.Tokens.IToken.html
author: 
---

# Interface IToken

> ## Excerpt
> 

---
###### **Namespace**: [Albatross.Expression.Tokens](https://rushuiguan.github.io/expression/api/Albatross.Expression.Tokens.html)

###### **Assembly**: Albatross.Expression.dll

##### Syntax

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Tokens.IToken.html#properties)Properties

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Tokens.IToken.html#Albatross_Expression_Tokens_IToken_Name)Name

##### Declaration

##### Property Value

| Type | Description |
| --- | --- |
| System.String |  |

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Tokens.IToken.html#methods)Methods

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Tokens.IToken.html#Albatross_Expression_Tokens_IToken_Clone)Clone()

##### Declaration

##### Returns

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Tokens.IToken.html#Albatross_Expression_Tokens_IToken_EvalText_System_String_)EvalText(String)

##### Declaration

```
string EvalText(string format)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | format |  |

##### Returns

| Type | Description |
| --- | --- |
| System.String |  |

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Tokens.IToken.html#Albatross_Expression_Tokens_IToken_EvalValue_System_Func_System_String_System_Object__)EvalValue(Func<String, Object>)

##### Declaration

```
object EvalValue(Func<string, object> context)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Func<System.String, System.Object\> | context |  |

##### Returns

| Type | Description |
| --- | --- |
| System.Object |  |

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Tokens.IToken.html#Albatross_Expression_Tokens_IToken_Match_System_String_System_Int32_System_Int32__)Match(String, Int32, out Int32)

##### Declaration

```
bool Match(string expression, int start, out int next)
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

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Tokens.IToken.html#extensionmethods)Extension Methods
---
created: 2025-06-25T05:52:55 (UTC -04:00)
tags: []
source: https://rushuiguan.github.io/expression/api/Albatross.Expression.Tokens.IVariableToken.html
author: 
---

# Interface IVariableToken

> ## Excerpt
> IToken.Name

---
##### Inherited Members

[IToken.Name](https://rushuiguan.github.io/expression/api/Albatross.Expression.Tokens.IToken.html#Albatross_Expression_Tokens_IToken_Name)

[IToken.Match(String, Int32, Int32)](https://rushuiguan.github.io/expression/api/Albatross.Expression.Tokens.IToken.html#Albatross_Expression_Tokens_IToken_Match_System_String_System_Int32_System_Int32__)

[IToken.EvalText(String)](https://rushuiguan.github.io/expression/api/Albatross.Expression.Tokens.IToken.html#Albatross_Expression_Tokens_IToken_EvalText_System_String_)

[IToken.EvalValue(Func<String, Object>)](https://rushuiguan.github.io/expression/api/Albatross.Expression.Tokens.IToken.html#Albatross_Expression_Tokens_IToken_EvalValue_System_Func_System_String_System_Object__)

[IToken.Clone()](https://rushuiguan.github.io/expression/api/Albatross.Expression.Tokens.IToken.html#Albatross_Expression_Tokens_IToken_Clone)

###### **Namespace**: [Albatross.Expression.Tokens](https://rushuiguan.github.io/expression/api/Albatross.Expression.Tokens.html)

###### **Assembly**: Albatross.Expression.dll

##### Syntax

```
public interface IVariableToken : IOperandToken, IToken
```

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Tokens.IVariableToken.html#extensionmethods)Extension Methods

[Extensions.ConvertToBoolean(Object)](https://rushuiguan.github.io/expression/api/Albatross.Expression.Extensions.html#Albatross_Expression_Extensions_ConvertToBoolean_System_Object_)

[Extensions.IsVariable(IToken)](https://rushuiguan.github.io/expression/api/Albatross.Expression.Extensions.html#Albatross_Expression_Extensions_IsVariable_Albatross_Expression_Tokens_IToken_)
---
created: 2025-06-25T05:51:42 (UTC -04:00)
tags: []
source: https://rushuiguan.github.io/expression/api/Albatross.Expression.Exceptions.html
author: 
---

# Namespace Albatross.Expression.Exceptions

> ## Excerpt
> Back to top
            
            
            Generated by DocFX

---
[Back to top](https://rushuiguan.github.io/expression/api/Albatross.Expression.Exceptions.html#top) Generated by **DocFX**
---
created: 2025-06-25T05:52:55 (UTC -04:00)
tags: []
source: https://rushuiguan.github.io/expression/api/Albatross.Expression.Tokens.html
author: 
---

# Namespace Albatross.Expression.Tokens

> ## Excerpt
> will only take true or false, case insensitive

---
### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Tokens.html#classes)Classes

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Tokens.html#assignmenttoken)[AssignmentToken](https://rushuiguan.github.io/expression/api/Albatross.Expression.Tokens.AssignmentToken.html)

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Tokens.html#booleanliteraltoken)[BooleanLiteralToken](https://rushuiguan.github.io/expression/api/Albatross.Expression.Tokens.BooleanLiteralToken.html)

will only take true or false, case insensitive

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Tokens.html#controltoken)[ControlToken](https://rushuiguan.github.io/expression/api/Albatross.Expression.Tokens.ControlToken.html)

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Tokens.html#doublequotestringliteraltoken)[DoubleQuoteStringLiteralToken](https://rushuiguan.github.io/expression/api/Albatross.Expression.Tokens.DoubleQuoteStringLiteralToken.html)

will take any string literal enclosed by double quotes. use back slash to escape.  
Check the GetStringEscape function for escapable chars

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Tokens.html#infixoperationtoken)[InfixOperationToken](https://rushuiguan.github.io/expression/api/Albatross.Expression.Tokens.InfixOperationToken.html)

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Tokens.html#numericliteraltoken)[NumericLiteralToken](https://rushuiguan.github.io/expression/api/Albatross.Expression.Tokens.NumericLiteralToken.html)

will take any numbers with decimals and without signs.

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Tokens.html#prefixoperationtoken)[PrefixOperationToken](https://rushuiguan.github.io/expression/api/Albatross.Expression.Tokens.PrefixOperationToken.html)

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Tokens.html#singledoublequotestringliteraltoken)[SingleDoubleQuoteStringLiteralToken](https://rushuiguan.github.io/expression/api/Albatross.Expression.Tokens.SingleDoubleQuoteStringLiteralToken.html)

A string literal token that can use either single quote or double quote as the string boundary. The [Boundary](https://rushuiguan.github.io/expression/api/Albatross.Expression.Tokens.SingleDoubleQuoteStringLiteralToken.html#Albatross_Expression_Tokens_SingleDoubleQuoteStringLiteralToken_Boundary) property is set to double quote by default. It will be changed to the correct boundary when the expression is parsed.

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Tokens.html#singlequotestringliteraltoken)[SingleQuoteStringLiteralToken](https://rushuiguan.github.io/expression/api/Albatross.Expression.Tokens.SingleQuoteStringLiteralToken.html)

will take any string literal enclosed by double quotes. use back slash to escape.  
Check the GetStringEscape function for escapable chars

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Tokens.html#stringliteraltoken)[StringLiteralToken](https://rushuiguan.github.io/expression/api/Albatross.Expression.Tokens.StringLiteralToken.html)

will take any string literal enclosed by double quotes. use back slash to escape.  
Check the GetStringEscape function for escapable chars

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Tokens.html#variabletoken)[VariableToken](https://rushuiguan.github.io/expression/api/Albatross.Expression.Tokens.VariableToken.html)

VariableToken class will look for names in the expression string. It follows the same rule as C# variable names which allows alpha numeric and underline characters. The leading character of a variable cannot be numeric. In addition, it allows two name to be joined together using a period. So "name1.name2" is also OK. However "name1.name2.name3" is not allowed.

Note: a variable name cannot be followed by a open parentheses because it will become a function. Please keep that in mind when creating a custom [IVariableToken](https://rushuiguan.github.io/expression/api/Albatross.Expression.Tokens.IVariableToken.html) implementation.

**Legal Variable Names**

-   cat
-   _cat_
-   cat
-   cat0\_
-   field.cat0\_
-   field0.cat0\_

**Illegal Variable Names**

-   test.field0.cat0\_
-   0cat
-   cat.1cat
-   0cat.cat
-   $cat$

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Tokens.html#interfaces)Interfaces

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Tokens.html#ioperandtoken)[IOperandToken](https://rushuiguan.github.io/expression/api/Albatross.Expression.Tokens.IOperandToken.html)

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Tokens.html#istringliteraltoken)[IStringLiteralToken](https://rushuiguan.github.io/expression/api/Albatross.Expression.Tokens.IStringLiteralToken.html)

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Tokens.html#itoken)[IToken](https://rushuiguan.github.io/expression/api/Albatross.Expression.Tokens.IToken.html)

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.Tokens.html#ivariabletoken)[IVariableToken](https://rushuiguan.github.io/expression/api/Albatross.Expression.Tokens.IVariableToken.html)
---
created: 2025-06-25T05:36:03 (UTC -04:00)
tags: []
source: https://rushuiguan.github.io/expression/api/Albatross.Expression.html
author: 
---

# Namespace Albatross.Expression

> ## Excerpt
> The default parser factory class.  This class can be accessed using its lazy static instance Instance or by creating a new instance.
The factory class by default will register any class with the ParserOperationAttribute attribute within this assembly.  Additional assemblies
can be registered using the Register(Assembly) function.

---
### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.html#classes)Classes

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.html#contextvalue)[ContextValue](https://rushuiguan.github.io/expression/api/Albatross.Expression.ContextValue.html)

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.html#datarowexecutioncontextfactory)[DataRowExecutionContextFactory](https://rushuiguan.github.io/expression/api/Albatross.Expression.DataRowExecutionContextFactory.html)

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.html#dictionaryexecutioncontextfactory)[DictionaryExecutionContextFactory](https://rushuiguan.github.io/expression/api/Albatross.Expression.DictionaryExecutionContextFactory.html)

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.html#executioncontext-t)[ExecutionContext<T>](https://rushuiguan.github.io/expression/api/Albatross.Expression.ExecutionContext-1.html)

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.html#executioncontextfactory)[ExecutionContextFactory](https://rushuiguan.github.io/expression/api/Albatross.Expression.ExecutionContextFactory.html)

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.html#expressionbuilder)[ExpressionBuilder](https://rushuiguan.github.io/expression/api/Albatross.Expression.ExpressionBuilder.html)

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.html#extensions)[Extensions](https://rushuiguan.github.io/expression/api/Albatross.Expression.Extensions.html)

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.html#factory)[Factory](https://rushuiguan.github.io/expression/api/Albatross.Expression.Factory.html)

The default parser factory class. This class can be accessed using its lazy static instance [Instance](https://rushuiguan.github.io/expression/api/Albatross.Expression.Factory.html#Albatross_Expression_Factory_Instance) or by creating a new instance. The factory class by default will register any class with the [ParserOperationAttribute](https://rushuiguan.github.io/expression/api/Albatross.Expression.ParserOperationAttribute.html) attribute within this assembly. Additional assemblies can be registered using the [Register(Assembly)](https://rushuiguan.github.io/expression/api/Albatross.Expression.Factory.html#Albatross_Expression_Factory_Register_System_Reflection_Assembly_) function.  

By default, the factory will use [SingleDoubleQuoteStringLiteralToken](https://rushuiguan.github.io/expression/api/Albatross.Expression.Tokens.SingleDoubleQuoteStringLiteralToken.html) for string literal token and [VariableToken](https://rushuiguan.github.io/expression/api/Albatross.Expression.Tokens.VariableToken.html) for variable token. These defaults can be changed for the factory instance object.

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.html#parser)[Parser](https://rushuiguan.github.io/expression/api/Albatross.Expression.Parser.html)

An immutable implementation of the [IParser](https://rushuiguan.github.io/expression/api/Albatross.Expression.IParser.html) interface.

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.html#parseroperationattribute)[ParserOperationAttribute](https://rushuiguan.github.io/expression/api/Albatross.Expression.ParserOperationAttribute.html)

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.html#reflectionexecutioncontextfactory-t)[ReflectionExecutionContextFactory<T>](https://rushuiguan.github.io/expression/api/Albatross.Expression.ReflectionExecutionContextFactory-1.html)

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.html#interfaces)Interfaces

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.html#iexecutioncontext-t)[IExecutionContext<T>](https://rushuiguan.github.io/expression/api/Albatross.Expression.IExecutionContext-1.html)

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.html#iexecutioncontextfactory-t)[IExecutionContextFactory<T>](https://rushuiguan.github.io/expression/api/Albatross.Expression.IExecutionContextFactory-1.html)

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.html#iparser)[IParser](https://rushuiguan.github.io/expression/api/Albatross.Expression.IParser.html)

The interface contains functionalities to process an expression string.

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.html#enums)Enums

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.html#contexttype)[ContextType](https://rushuiguan.github.io/expression/api/Albatross.Expression.ContextType.html)

### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.html#delegates)Delegates

#### [](https://rushuiguan.github.io/expression/api/Albatross.Expression.html#trygetvaluedelegate-t)[TryGetValueDelegate<T>](https://rushuiguan.github.io/expression/api/Albatross.Expression.TryGetValueDelegate-1.html)
