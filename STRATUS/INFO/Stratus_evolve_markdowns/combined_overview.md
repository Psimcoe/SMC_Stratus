---
created: 2025-06-25T06:04:52 (UTC -04:00)
tags: []
source: https://rushuiguan.github.io/expression/articles/operations.html
author: 
---

# Built-In Operations

> ## Excerpt
> It is a math expression with an operator in the middle and two operands, one on each side of the operator.  Here are some examples.

---
## [](https://rushuiguan.github.io/expression/articles/operations.html#what-is-an-infix-operation)What is an **Infix operation**?

It is a math expression with an operator in the middle and two operands, one on each side of the operator. Here are some examples.

1.  `1 + 2`
2.  `1 + 2 + 3`
3.  `2 + 5 * 4`
4.  `1 > 2 or 3 > 2`
5.  `(1 + 2) * 3`
6.  `1 * -1`

Infix operation can be chained as the examples shown above. When chained, the precedence of the operator will decide who gets executed first. If two operator has the same precedence, the operator should be executed from left to right. For example `2 + 5 * 4` will execute `5 * 4` first because the `*` operator has a precedence of 200 which is larger than the precedence of the `+` operator. The `+` operator will then execute `2 + 20`. The second operand `20` comes from the output of the `*` operator.

The **parentheses** can be used to supersede the precedence of the operators as show in #5.

A **unary operator** such as the negative sign in #6 will always have precedence over any infix operators.

## [](https://rushuiguan.github.io/expression/articles/operations.html#the-precedence-of-infix-operations)The Precedence of Infix Operations
---
created: 2025-06-25T06:04:52 (UTC -04:00)
tags: []
source: https://rushuiguan.github.io/expression/articles/executionContext.html
author: 
---

# Execution Context

> ## Excerpt
> There isn't much use case for a parser that can only evaluate expressions made of literals.  However by introducing variables, the expressions becomes formulas.  User defined formulas are found in many applications.  For example Microsoft Excel has a complex formula system.  Even though the Parser class can pass the value of variables by calling the EvalValue method with Func<string, object> delegate.  The ExecutionContext class is created to manage the use of formulas.

---
There isn't much use case for a parser that can only evaluate expressions made of literals. However by introducing variables, the expressions becomes formulas. User defined formulas are found in many applications. For example Microsoft Excel has a complex formula system. Even though the [Parser](https://rushuiguan.github.io/expression/api/Albatross.Expression.Parser.html) class can pass the value of variables by calling the [EvalValue](https://rushuiguan.github.io/expression/api/Albatross.Expression.Tokens.IToken.html#Albatross_Expression_Tokens_IToken_EvalValue_System_Func_System_String_System_Object__) method with `Func<string, object>` delegate. The [ExecutionContext](https://rushuiguan.github.io/expression/api/Albatross.Expression.ExecutionContext-1.html) class is created to manage the use of formulas.

## [](https://rushuiguan.github.io/expression/articles/executionContext.html#design)Design

The [ExecutionContext](https://rushuiguan.github.io/expression/api/Albatross.Expression.ExecutionContext-1.html) class is a generic class. The generic type T indicates the type of the input object. The [ExecutionContext](https://rushuiguan.github.io/expression/api/Albatross.Expression.ExecutionContext-1.html) class itself doesn't know how to extract the values of variables from class T. For that, it relies on its factory [IExecutionContextFactory](https://rushuiguan.github.io/expression/api/Albatross.Expression.IExecutionContextFactory-1.html).

## [](https://rushuiguan.github.io/expression/articles/executionContext.html#datarowexecutioncontextfactoryxrefalbatrossexpressiondatarowexecutioncontextfactory)[DataRowExecutionContextFactory](https://rushuiguan.github.io/expression/api/Albatross.Expression.DataRowExecutionContextFactory.html)

## [](https://rushuiguan.github.io/expression/articles/executionContext.html#customization)Customization
---
created: 2025-06-25T06:04:52 (UTC -04:00)
tags: []
source: https://rushuiguan.github.io/expression/articles/intro.html
author: 
---

# Introduction

> ## Excerpt
> Albatross.Expression api is created to process and evaluate text based expression strings.  The api tokenizes the expression text and create a tree model from the tokens.  Using the model, it can evaluate the expression or convert it to a expression of different format.  Some applications revert the process by creating the model first and use it to generate certain expression such as a sql query statement.  The api also contains a useful ExecutionContext class that allows evaluation of expressions with variables.  The variables can be read internally or directly from external objects.

---
Albatross.Expression api is created to process and evaluate text based expression strings. The api tokenizes the expression text and create a tree model from the tokens. Using the model, it can evaluate the expression or convert it to a expression of different format. Some applications revert the process by creating the model first and use it to generate certain expression such as a sql query statement. The api also contains a useful ExecutionContext class that allows evaluation of expressions with variables. The variables can be read internally or directly from external objects.

## Usage

Use the easiest way to use the parser is by calling the default instance of the [Factory](https://rushuiguan.github.io/expression/api/Albatross.Expression.Factory.html) class.

```
var parser = Factory.Instance.Create();
parser.Compile("1 + 5").EvalValue(null);
```

## [](https://rushuiguan.github.io/expression/articles/intro.html#use-of-executioncontexttxrefalbatrossexpressionexecutioncontext1-class-with-variables)Use of [ExecutionContext](https://rushuiguan.github.io/expression/api/Albatross.Expression.ExecutionContext-1.html) class with variables

The evaluation of expressions made of literals is not very helpful and it doesn't have many use cases. The api was created to solve a different problem - the problem of user defined calculations. Here is a code sample:

```
    ExecutionContext context = new ExecutionContext(Factory.Instance, true);
    context.SetValue("a", 1);
    context.SetValue("b", 2);
    var result = context.Eval("a + b", null);
    //the result should be 3;

    context.SetValue("a", 2);
    result = context.Eval("a + b", null);
    //the result should be 4 now.
```

In the code sample above, the context was able to store the value of variable `a` and `b` and use it to calculate expressions that have those variables. It is useful in situations where users are allowed to define custom calculations using a formula and the application is expected to perform the calculation of the dynamically defined formulas.

The [ExecutionContext](https://rushuiguan.github.io/expression/api/Albatross.Expression.ExecutionContext-1.html) class can also reference data of type T externally so that the value of the variables doesn't need to be established in the object itself. It is a nessary feature because when data change, instead of calling the SetValue method, it is more efficient for the context to access the external data directly. Here is a code sample:

```
    public class Program {
        static void Main(string[] args) {
            DataTable table = SetupTable();
            Generate(table);
            DataRowExecutionContextFactory factory = new DataRowExecutionContextFactory(Factory.Instance.Create());
            IExecutionContext<DataRow> context = factory.Create();
            context.SetExpression("age", "Year(Today()) - Year(DOB)");

            foreach (DataRow row in table.Rows) {
                row["age"] = context.GetValue("age", row);
                Console.WriteLine(row["age"]);
            }
        }

        static DataTable SetupTable() {
            DataTable table = new DataTable();
            table.Columns.Add(new DataColumn("FirstName") { DataType = typeof(string), });
            table.Columns.Add(new DataColumn("LastName") { DataType = typeof(string), });
            table.Columns.Add(new DataColumn("DOB") { DataType = typeof(DateTime), });
            table.Columns.Add(new DataColumn("Age") { DataType = typeof(int), });
            return table;
        }


        static void Generate(DataTable table) {
            table.Rows.Add("John", "Doe", new DateTime(1976, 1, 1));
            table.Rows.Add("Jane", "Doe", new DateTime(2000, 5, 8));
        }
    }
```

In this example, the Age column is a user defined column with a formula that needs to be computed dynamically.

## Supported Operations

The api supports three diffent kinds of operations

-   Infix operation
    -   `1 + 1`
    -   `1 + 3 * 7 > 4 and 1 - 4 < 8`
-   Prefix operation
    -   `if (true, "Yes", "No")`
    -   `max(1,2,3)`
    -   `pi()`
    -   `today()`
    -   `left(string, length)`
-   Unary operation
    -   `-1` is negative 1

It supports `string`, `boolean` and `numeric` literals. It treats all numbers as `double`. Reference the [operations](https://rushuiguan.github.io/expression/articles/operations.html) page to see the list of built-in operations.
---
created: 2025-06-25T06:06:11 (UTC -04:00)
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
---
created: 2025-06-25T06:04:52 (UTC -04:00)
tags: []
source: https://rushuiguan.github.io/expression/articles/parser.html
author: 
---

# Parser

> ## Excerpt
> The class Albatross.Expression.Parser implements interface Albatross.Expression.IParser.  It performs the function of processing, evaluating and generating of expressions.

---
The class [Albatross.Expression.Parser](https://rushuiguan.github.io/expression/api/Albatross.Expression.Parser.html) implements interface [Albatross.Expression.IParser](https://rushuiguan.github.io/expression/api/Albatross.Expression.IParser.html). It performs the function of processing, evaluating and generating of expressions.

## [](https://rushuiguan.github.io/expression/articles/parser.html#design)Design

The [Parser](https://rushuiguan.github.io/expression/api/Albatross.Expression.Parser.html) class parses the expression by

1.  Tokenize the text
2.  Build a stack
3.  Create a token tree

Once the token tree is created, the parser can evaluate the result of the expression by evaluating the tree nodes recursively.

The implementation of the design supports the following functionalties:

-   Tokens
    -   String Literal - `"yes"`
    -   Numeric Literal - `100 + 4.0`
        -   The [NumericLiteralToken](https://rushuiguan.github.io/expression/api/Albatross.Expression.Tokens.NumericLiteralToken.html) class handles number and it converts all numeric value to C# type `System.Double`.
    -   Variable - `a + 4`
    -   Parantheses - `4 * (1 + 2)`
-   Infix operation - Operations with two operands and a operator in the middle: `1 + 2`
    -   operation precedence
-   unary operation - Negative sign: `-1`
-   prefix operation - Functions with fixed or optional parameter and a return value: `Now(), Left("Orange", 4)`
-   unlimited optional function parameters - `max(1,2,3,4,5)`
-   Array - Array is a special function that returns an array object: `@(1, 2, 3, 4, 5)`

## [](https://rushuiguan.github.io/expression/articles/parser.html#tokenization)Tokenization

Tokenization reads the expression from left to right. Its function is to recognize individual components (tokens) of an expression. This step will throw [TokenParsingException](https://rushuiguan.github.io/expression/api/Albatross.Expression.Exceptions.TokenParsingException.html) if the expression has errors. The resulting tokens are inserted into a queue. The implementation is in the [Tokenize](https://rushuiguan.github.io/expression/api/Albatross.Expression.Parser.html#Albatross_Expression_Parser_Tokenize_System_String_) method of the [Parser](https://rushuiguan.github.io/expression/api/Albatross.Expression.Parser.html) class.

Here are some examples:

-   Expression: `4 + 5 * 6 - max(7, 1)`
    -   `4`
    -   `+`
    -   `5`
    -   `*`
    -   `6`
    -   `-`
    -   `max`
    -   `(`
    -   `7`
    -   `,`
    -   `1`
    -   `)`
-   Expression: `if (a > b, "Yes", "No")`
    -   `if`
    -   `(`
    -   `a`
    -   `>`
    -   `b`
    -   `,`
    -   `"Yes"`
    -   `,`
    -   `"No"`
    -   `)`

Notice that comma and parentheses are considered as control tokens but the string boundary (double quote) are not. String boundaries are part of the string token and will be stripped and disgarded by the [StringLiteralToken](https://rushuiguan.github.io/expression/api/Albatross.Expression.Tokens.StringLiteralToken.html) class during the evaluation process.

## [](https://rushuiguan.github.io/expression/articles/parser.html#create-a-stack)Create a Stack

This step converts the tokenized queue into a postfix stack using the [Shunting-yard algorithm](https://en.wikipedia.org/wiki/Shunting-yard_algorithm). The implementation is in the [BuildStack](https://rushuiguan.github.io/expression/api/Albatross.Expression.Parser.html#Albatross_Expression_Parser_BuildStack_System_Collections_Generic_Queue_Albatross_Expression_Tokens_IToken__) method of the [Parser](https://rushuiguan.github.io/expression/api/Albatross.Expression.Parser.html) class. A postfix stack is also called a [Reverse polish notion](https://en.wikipedia.org/wiki/Reverse_Polish_notation).

Here are the top popping stack for the example above:

-   Expression: `4 + 5 * 6 - max(7, 1)`
    -   `-`
    -   `max`
    -   `1`
    -   `7`
    -   `$`
    -   `+`
    -   `*`
    -   `6`
    -   `5`
    -   `4`
-   Expression: `if (a > b, "Yes", "No")`
    -   `If`
    -   `"No"`
    -   `"Yes"`
    -   `>`
    -   `b`
    -   `a`
    -   `$`
-   Expression: `Format(Today(), "yyyy-MM-DD")`
    -   `Format`
    -   `"yyyy-MM-DD"`
    -   `Today`
    -   `$`
    -   `$`

A special control token `$` is used to indicate the end of parameters for prefix operations. This allows functions with unknown number of optional parameters. It also simplify the tree creation logic because it doesn't need to know how many parameters the prefix function has.

## [](https://rushuiguan.github.io/expression/articles/parser.html#create-a-tree)Create a Tree

This step is to create a tree from the postfix stack. The process of converting a stack to a tree is the same process of evaluating (popping) the postfix stack. The tree is created so that the expression can be evaluated multiple times without rebuilding the stack. The result object is of type [IToken](https://rushuiguan.github.io/expression/api/Albatross.Expression.Tokens.IToken.html).

Here are the trees for the example above:

-   Expression: `4 + 5 * 6 - max(7, 1)`
    -   `-`
        -   `+`
            -   `4`
            -   `*`
                -   `5`
                -   `6`
        -   `max`
            -   `7`
            -   `1`
-   Expression: `if (a > b, "Yes", "No")`
    -   `If`
        -   `>`
            -   `a`
            -   `b`
        -   `"Yes"`
        -   `"No"`
-   Expression: `Format(Today(), "yyyy-MM-DD")`
    -   `Format`
        -   `Today`
        -   `"yyyy-MM-DD"`

## [](https://rushuiguan.github.io/expression/articles/parser.html#evaluate-a-tree)Evaluate a tree

With a tree built, the evaluation process is a simple recursive call to the [EvalValue](https://rushuiguan.github.io/expression/api/Albatross.Expression.Tokens.IToken.html#Albatross_Expression_Tokens_IToken_EvalValue_System_Func_System_String_System_Object__) function of the [IToken](https://rushuiguan.github.io/expression/api/Albatross.Expression.Tokens.IToken.html) interface.

## [](https://rushuiguan.github.io/expression/articles/parser.html#regenerate-the-expression)Regenerate the expression

Using the same [IToken](https://rushuiguan.github.io/expression/api/Albatross.Expression.Tokens.IToken.html) object, the parser can regenerate the original expression or convert it to an expression of different format by calling the [EvalText](https://rushuiguan.github.io/expression/api/Albatross.Expression.Tokens.IToken.html#Albatross_Expression_Tokens_IToken_EvalText_System_String_) method. The default EvalText method will produce an expression string with equal functionality as the original with consistent spacing and mininum usage of parantheses. For example: if the original expression is `1+(2*3)`, the regenerated expression will be: `1 + 2 * 3`.

## [](https://rushuiguan.github.io/expression/articles/parser.html#use-of-variable-in-an-expression)Use of variable in an expression

When evaluating expressions with variables, the [EvalValue](https://rushuiguan.github.io/expression/api/Albatross.Expression.Tokens.IToken.html#Albatross_Expression_Tokens_IToken_EvalValue_System_Func_System_String_System_Object__) has a second parameter of type `Func<object, string>` that can be used to return the value of a variable. Here is an example:

```
[TestCase("a + b * c", ExpectedResult = 7)]
[TestCase("a + b + c", ExpectedResult =6)]
public object Run(string expression) {
    Func<string, object> func = name => {
        switch (name.ToLower()) {
            case "a":
                return 1;
            case "b":
                return 2;
            case "c":
                return 3;
            default:
                return null;
        }
    };
    IParser parser = Factory.Instance.Create();
    return parser.Compile(expression).EvalValue(func);
}   
```
# Albatross Expression Api

## Summary
Albatross.Expression api is created to process and evaluate text based expression strings.  

## Description
The api tokenizes the expression text and create a tree model from the tokens.  Using the model, it can evaluate the expression or convert it to a expression of different format.  Some applications revert the process by creating the model first and use it to generate certain expression such as a sql query statement.  The api also contains a useful ExecutionContext class that allows evaluation of expressions with variables.  The variables can be read internally or directly from external objects.

## Release
* 2.0.4
	* No breaking changes.
	* License change from GNU GPLv3 to MIT.
	* Allow direct registration of IToken instances in the [Factory](xref:Albatross.Expression.Factory) class.
* 2.0.3
	* Breaking Changes
		* The Add method of the [IParser](xref:Albatross.Expression.IParser) interface has been removed.  Adding new operations to the instance of [Parser](xref:Albatross.Expression.Parser) class will alter its state.  This change will make the [Parser](xref:Albatross.Expression.Parser) class immutable.
		* The Compile method of the [IParser](xref:Albatross.Expression.IParser) interface has been removed.  It is replaced by a extension method - [Compile](xref:Albatross.Expression.Extensions.Compile(Albatross.Expression.IParser,System.String)).  The Compile method is a short hand for the Tokenize, BuildStack and CreateTree process.  It doesn't introduce any functionality therefore it doesn't belong in the interface.
    * New StringTokenLiteral - [SingleDoubleQuoteStringLiteralToken](xref:Albatross.Expression.Tokens.SingleDoubleQuoteStringLiteralToken) class has been created to accept single quote or double quote strings.
    * New ExecutionContextFactory - [ReflectionExecutionContextFactory<T>](xref:Albatross.Expression.ReflectionExecutionContextFactory`1) class has been created to supply variable value from the public instance properties of the input object (of class T) using reflection.  The execution context created by this factory is always case sensitive.
* 2.0.2
    * Breaking Changes
        * Mininum target framework has been changed from net40 to net45.
        * Precedence for ``and, or`` operations has been set to the lowest (30, 20) among all infix operations.  As the result of this change, the following expression will now return true: ``2 > 1 and 3 > 1``.
        * [IParser](xref:Albatross.Expression.IParser) interface no longer has the ``SetVariableToken`` and ``SetStringLiteralToken`` methods.  That means Variabletoken or StringLiteralToken types can no longer be changed after the parser has been created.
        * Change to the constructor of the [Parser](xref:Albatross.Expression.Parser) class to require two additional parameter [IVariableToken](xref:Albatross.Expression.Tokens.IVariableToken) and [IStringLiteralToken](xref:Albatross.Expression.Tokens.IVariableToken).
        * [IExecutionContextFactory](xref:Albatross.Expression.IExecutionContextFactory`1) is now a generic interface.  It requires a type to specify the input data type.
        * [IExecutionContext](xref:Albatross.Expression.IExecutionContext`1) interface is now a generic interface as well.  It has been redefined and reduced so that it is easier to use.
    * [ParserOperationAttribute](xref:Albatross.Expression.ParserOperationAttribute) (new)
        * A custom attribute used to mark the operations so that it will be used by the Factory class when constructing a parser object.
    * [Factory](xref:Albatross.Expression.Factory) class (new)
        * Allow quick creation of a Parser instance.
        * The class can scan an assembly and register any parser operation class with the [ParserOperationAttribute](xref:Albatross.Expression.ParserOperationAttribute) attribute.
    * [DataRowExecutionContextFactory](xref:Albatross.Expression.DataRowExecutionContextFactory) class (new)
        * A prewired execution context factory that works with the external data type System.Data.DataRow.
    * [DictionaryExecutionContextFactory](xref:Albatross.Expression.DictionaryExecutionContextFactory) class (new)
        * A prewired execution context factory that works with the external data type System.Collection.Generic.IDictionary<string, object>
    * [ExpressionBuilder](xref:Albatross.Expression.ExpressionBuilder) is marked as Obsolete.
    * Add additional target framework netstandard2.0
    * Strengthen Unit testing.
    * Add lots of documentation.
* 1.3.6218.36673 - Orignal release
    * Created: 1/10/2017