##### Converter
# <a name='T-Vsxmd-Converter'></a>Converter

### Namespace

Vsxmd

### Summary

*Inherit from parent.*

#### #ctor
## <a name='M-Vsxmd-Converter--ctor-System-Xml-Linq-XDocument-'></a>#ctor(document)

### Summary

Initializes a new instance of the [Converter](#T-Vsxmd-Converter) class.

### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| document | [System.Xml.Linq.XDocument](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Xml.Linq.XDocument 'System.Xml.Linq.XDocument') | The XML document. |

#### ToMarkdown
## <a name='M-Vsxmd-Converter-ToMarkdown-System-Xml-Linq-XDocument-'></a>ToMarkdown(document)

### Summary

Convert VS XML document to Markdown syntax.

### Returns

The generated Markdown content.

### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| document | [System.Xml.Linq.XDocument](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Xml.Linq.XDocument 'System.Xml.Linq.XDocument') | The XML document. |

#### ToMarkdown
## <a name='M-Vsxmd-Converter-ToMarkdown'></a>ToMarkdown()

### Summary

*Inherit from parent.*

### Parameters

This method has no parameters.

##### IConverter
# <a name='T-Vsxmd-IConverter'></a>IConverter

### Namespace

Vsxmd

### Summary

Converter for XML document to Markdown syntax conversion.

#### ToMarkdown
## <a name='M-Vsxmd-IConverter-ToMarkdown'></a>ToMarkdown()

### Summary

Convert to Markdown syntax.

### Returns

The generated Markdown content.

### Parameters

This method has no parameters.

##### Program
# <a name='T-Vsxmd-Program'></a>Program

### Namespace

Vsxmd

### Summary

Program entry.

### Remarks

Usage syntax:

```csharp
Vsxmd.exe &lt;input-XML-path&gt; [output-Markdown-path]
```

The `input-XML-path` argument is required. It references to the VS generated XML documentation file.

The `output-Markdown-path` argument is optional. It indicates the file path for the Markdown output file. When not specific, it will be a `.md` file with same file name as the XML documentation file, path at the XML documentation folder.

#### Main
## <a name='M-Vsxmd-Program-Main-System-String---'></a>Main(args)

### Summary

Program main function entry.

### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| args | [System.String[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String[] 'System.String[]') | Program arguments. |

### See Also

- [Vsxmd.Program](#T-Vsxmd-Program)

#### #ctor
## <a name='M-Vsxmd-Program-Test--ctor'></a>#ctor()

### Summary

Initializes a new instance of the [Test](#T-Vsxmd-Program-Test) class.

Test constructor without parameters.

See [#ctor](#M-Vsxmd-Program-Test--ctor).

### Parameters

This method has no parameters.

### Permissions

| Name | Description |
| ---- | ----------- |
| [Vsxmd.Program](#T-Vsxmd-Program) | Just for test. |

#### TestParamWithoutDescription
## <a name='M-Vsxmd-Program-Test-TestParamWithoutDescription-System-String-'></a>TestParamWithoutDescription(p)

### Summary

Test a param tag without description.

### Returns

Nothing.

### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| p | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

#### TestGenericReference
## <a name='M-Vsxmd-Program-Test-TestGenericReference'></a>TestGenericReference()

### Summary

Test generic reference type.

See [TestGenericParameter\`\`2](#M-Vsxmd-Program-Test-TestGenericParameter--2-System-Linq-Expressions-Expression-System-Func---0,--1,System-String---).

### Returns

Nothing.

### Parameters

This method has no parameters.

#### TestGenericParameter\`\`2
## <a name='M-Vsxmd-Program-Test-TestGenericParameter--2-System-Linq-Expressions-Expression-System-Func---0,--1,System-String---'></a>TestGenericParameter\`\`2(expression)

### Summary

Test generic parameter type.

See `T1` and `T2`.

### Returns

Nothing.

### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| expression | [System.Linq.Expressions.Expression{System.Func{\`\`0,\`\`1,System.String}}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Linq.Expressions.Expression 'System.Linq.Expressions.Expression{System.Func{``0,``1,System.String}}') | The linq expression. |

### Generic Types

| Name | Description |
| ---- | ----------- |
| T1 | Generic type 1. |
| T2 | Generic type 2. |

#### TestGenericException
## <a name='M-Vsxmd-Program-Test-TestGenericException'></a>TestGenericException()

### Summary

Test generic exception type.

### Returns

Nothing.

### Parameters

This method has no parameters.

### Exceptions

| Name | Description |
| ---- | ----------- |
| [Vsxmd.Program.Test.TestGenericParameter\`\`2](#M-Vsxmd-Program-Test-TestGenericParameter--2-System-Linq-Expressions-Expression-System-Func---0,--1,System-String---) | Just for test. |

#### TestGenericPermission
## <a name='M-Vsxmd-Program-Test-TestGenericPermission'></a>TestGenericPermission()

### Summary

Test generic exception type.

### Returns

Nothing.

### Parameters

This method has no parameters.

### Permissions

| Name | Description |
| ---- | ----------- |
| [Vsxmd.Program.Test.TestGenericParameter\`\`2](#M-Vsxmd-Program-Test-TestGenericParameter--2-System-Linq-Expressions-Expression-System-Func---0,--1,System-String---) | Just for test. |

#### TestBacktickInSummary
## <a name='M-Vsxmd-Program-Test-TestBacktickInSummary'></a>TestBacktickInSummary()

### Summary

Test backtick characters in summary comment.

See \`should not inside code block\`.

See `` `backtick inside code block` ``.

See \``code block inside backtick`\`.

### Returns

Nothing.

### Parameters

This method has no parameters.

#### TestSpaceAfterInlineElements\`\`1
## <a name='M-Vsxmd-Program-Test-TestSpaceAfterInlineElements--1-System-Boolean-'></a>TestSpaceAfterInlineElements\`\`1()

### Summary

Test space after inline elements.

See `code block` should follow a space.

See a value at the end of a `sentence`.

See [TestSpaceAfterInlineElements\`\`1](#M-Vsxmd-Program-Test-TestSpaceAfterInlineElements--1-System-Boolean-) as a link.

See `space` after a param ref.

See `T` after a type param ref.

### Returns

Nothing.

### Parameters

This method has no parameters.

#### TestSeeLangword
## <a name='M-Vsxmd-Program-Test-TestSeeLangword'></a>TestSeeLangword()

### Summary

Test see tag with langword attribute. See `true`.

### Returns

Nothing.

### Parameters

This method has no parameters.

##### Test
# <a name='T-Vsxmd-Program-Test'></a>Test

### Namespace

Vsxmd.Program

##### TestGenericType\`2
# <a name='T-Vsxmd-Program-TestGenericType-2'></a>TestGenericType\`2

### Namespace

Vsxmd.Program

### Summary

Test generic type.

See [TestGenericType\`2](#T-Vsxmd-Program-TestGenericType-2).

### Generic Types

| Name | Description |
| ---- | ----------- |
| T1 | Generic type 1. |
| T2 | Generic type 2. |

#### TestGenericMethod\`\`2
## <a name='M-Vsxmd-Program-TestGenericType-2-TestGenericMethod--2'></a>TestGenericMethod\`\`2()

### Summary

Test generic method.

See [TestGenericMethod\`\`2](#M-Vsxmd-Program-TestGenericType-2-TestGenericMethod--2).

### Returns

Nothing.

### Parameters

This method has no parameters.

### Generic Types

| Name | Description |
| ---- | ----------- |
| T3 | Generic type 3. |
| T4 | Generic type 4. |

##### TableOfContents
# <a name='T-Vsxmd-TableOfContents'></a>TableOfContents

### Namespace

Vsxmd

### Summary

Table of contents.

#### #ctor
## <a name='M-Vsxmd-TableOfContents--ctor-System-Linq-IOrderedEnumerable-Vsxmd-Units-MemberUnit--'></a>#ctor(memberUnits)

### Summary

Initializes a new instance of the [TableOfContents](#T-Vsxmd-TableOfContents) class.

It convert the table of contents from the `memberUnits`.

### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| memberUnits | [System.Linq.IOrderedEnumerable{Vsxmd.Units.MemberUnit}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Linq.IOrderedEnumerable 'System.Linq.IOrderedEnumerable{Vsxmd.Units.MemberUnit}') | The member unit list. |

#### Link
## <a name='P-Vsxmd-TableOfContents-Link'></a>Link

### Summary

Gets the link pointing to the table of contents.

#### ToMarkdown
## <a name='M-Vsxmd-TableOfContents-ToMarkdown'></a>ToMarkdown()

### Summary

Convert the table of contents to Markdown syntax.

### Returns

The table of contents in Markdown syntax.

### Parameters

This method has no parameters.

##### AssemblyUnit
# <a name='T-Vsxmd-Units-AssemblyUnit'></a>AssemblyUnit

### Namespace

Vsxmd.Units

### Summary

Assembly unit.

#### #ctor
## <a name='M-Vsxmd-Units-AssemblyUnit--ctor-System-Xml-Linq-XElement-'></a>#ctor(element)

### Summary

Initializes a new instance of the [AssemblyUnit](#T-Vsxmd-Units-AssemblyUnit) class.

### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| element | [System.Xml.Linq.XElement](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Xml.Linq.XElement 'System.Xml.Linq.XElement') | The assembly XML element. |

### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | Throw if XML element name is not `assembly`. |

#### ToMarkdown
## <a name='M-Vsxmd-Units-AssemblyUnit-ToMarkdown'></a>ToMarkdown()

### Summary

*Inherit from parent.*

### Parameters

This method has no parameters.

##### BaseUnit
# <a name='T-Vsxmd-Units-BaseUnit'></a>BaseUnit

### Namespace

Vsxmd.Units

### Summary

The base unit.

#### #ctor
## <a name='M-Vsxmd-Units-BaseUnit--ctor-System-Xml-Linq-XElement,System-String-'></a>#ctor(element,elementName)

### Summary

Initializes a new instance of the [BaseUnit](#T-Vsxmd-Units-BaseUnit) class.

### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| element | [System.Xml.Linq.XElement](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Xml.Linq.XElement 'System.Xml.Linq.XElement') | The XML element. |
| elementName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The expected XML element name. |

### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | Throw if XML `element` name not matches the expected `elementName`. |

#### Element
## <a name='P-Vsxmd-Units-BaseUnit-Element'></a>Element

### Summary

Gets the XML element.

#### ElementContent
## <a name='P-Vsxmd-Units-BaseUnit-ElementContent'></a>ElementContent

### Summary

Gets the Markdown content representing the element.

#### ToMarkdown
## <a name='M-Vsxmd-Units-BaseUnit-ToMarkdown'></a>ToMarkdown()

### Summary

*Inherit from parent.*

### Parameters

This method has no parameters.

#### GetChild
## <a name='M-Vsxmd-Units-BaseUnit-GetChild-System-Xml-Linq-XName-'></a>GetChild(name)

### Summary

Gets the first (in document order) child element with the specified `name`.

### Returns

A [XName](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Xml.Linq.XName 'System.Xml.Linq.XName') that matches the specified `name`, or `null`.

### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| name | [System.Xml.Linq.XName](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Xml.Linq.XName 'System.Xml.Linq.XName') | The [XName](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Xml.Linq.XName 'System.Xml.Linq.XName') to match. |

#### GetChildren
## <a name='M-Vsxmd-Units-BaseUnit-GetChildren-System-Xml-Linq-XName-'></a>GetChildren(name)

### Summary

Returns a collection of the child elements of this element or document, in document order.
Only elements that have a matching [XName](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Xml.Linq.XName 'System.Xml.Linq.XName') are included in the collection.

### Returns

An [IEnumerable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable`1 'System.Collections.Generic.IEnumerable`1') of [XElement](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Xml.Linq.XElement 'System.Xml.Linq.XElement') containing the children that have a matching [XName](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Xml.Linq.XName 'System.Xml.Linq.XName'), in document order.

### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| name | [System.Xml.Linq.XName](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Xml.Linq.XName 'System.Xml.Linq.XName') | The [XName](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Xml.Linq.XName 'System.Xml.Linq.XName') to match. |

#### GetAttribute
## <a name='M-Vsxmd-Units-BaseUnit-GetAttribute-System-Xml-Linq-XName-'></a>GetAttribute(name)

### Summary

Returns the [XAttribute](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Xml.Linq.XAttribute 'System.Xml.Linq.XAttribute') value of this [XElement](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Xml.Linq.XElement 'System.Xml.Linq.XElement') that has the specified `name`.

### Returns

An [XAttribute](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Xml.Linq.XAttribute 'System.Xml.Linq.XAttribute') value that has the specified `name`; `null` if there is no attribute with the specified `name`.

### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| name | [System.Xml.Linq.XName](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Xml.Linq.XName 'System.Xml.Linq.XName') | The [XName](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Xml.Linq.XName 'System.Xml.Linq.XName') of the [XAttribute](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Xml.Linq.XAttribute 'System.Xml.Linq.XAttribute') to get. |

##### ExampleUnit
# <a name='T-Vsxmd-Units-ExampleUnit'></a>ExampleUnit

### Namespace

Vsxmd.Units

### Summary

Example unit.

#### #ctor
## <a name='M-Vsxmd-Units-ExampleUnit--ctor-System-Xml-Linq-XElement-'></a>#ctor(element)

### Summary

Initializes a new instance of the [ExampleUnit](#T-Vsxmd-Units-ExampleUnit) class.

### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| element | [System.Xml.Linq.XElement](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Xml.Linq.XElement 'System.Xml.Linq.XElement') | The example XML element. |

### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | Throw if XML element name is not `example`. |

#### ToMarkdown
## <a name='M-Vsxmd-Units-ExampleUnit-ToMarkdown'></a>ToMarkdown()

### Summary

*Inherit from parent.*

### Parameters

This method has no parameters.

#### ToMarkdown
## <a name='M-Vsxmd-Units-ExampleUnit-ToMarkdown-System-Xml-Linq-XElement-'></a>ToMarkdown(element)

### Summary

Convert the example XML element to Markdown safely.
If element is `null`, return empty string.

### Returns

The generated Markdown.

### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| element | [System.Xml.Linq.XElement](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Xml.Linq.XElement 'System.Xml.Linq.XElement') | The example XML element. |

##### ExceptionUnit
# <a name='T-Vsxmd-Units-ExceptionUnit'></a>ExceptionUnit

### Namespace

Vsxmd.Units

### Summary

Exception unit.

#### #ctor
## <a name='M-Vsxmd-Units-ExceptionUnit--ctor-System-Xml-Linq-XElement-'></a>#ctor(element)

### Summary

Initializes a new instance of the [ExceptionUnit](#T-Vsxmd-Units-ExceptionUnit) class.

### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| element | [System.Xml.Linq.XElement](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Xml.Linq.XElement 'System.Xml.Linq.XElement') | The exception XML element. |

### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | Throw if XML element name is not `exception`. |

#### ToMarkdown
## <a name='M-Vsxmd-Units-ExceptionUnit-ToMarkdown'></a>ToMarkdown()

### Summary

*Inherit from parent.*

### Parameters

This method has no parameters.

#### ToMarkdown
## <a name='M-Vsxmd-Units-ExceptionUnit-ToMarkdown-System-Collections-Generic-IEnumerable-System-Xml-Linq-XElement--'></a>ToMarkdown(elements)

### Summary

Convert the exception XML element to Markdown safely.
If element is `null`, return empty string.

### Returns

The generated Markdown.

### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| elements | [System.Collections.Generic.IEnumerable{System.Xml.Linq.XElement}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{System.Xml.Linq.XElement}') | The exception XML element list. |

##### Extensions
# <a name='T-Vsxmd-Units-Extensions'></a>Extensions

### Namespace

Vsxmd.Units

### Summary

Extensions helper.

#### ToLowerString
## <a name='M-Vsxmd-Units-Extensions-ToLowerString-Vsxmd-Units-MemberKind-'></a>ToLowerString(memberKind)

### Summary

Convert the [MemberKind](#T-Vsxmd-Units-MemberKind) to its lowercase name.

### Returns

The member kind's lowercase name.

### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| memberKind | [Vsxmd.Units.MemberKind](#T-Vsxmd-Units-MemberKind) | The member kind. |

#### Join
## <a name='M-Vsxmd-Units-Extensions-Join-System-Collections-Generic-IEnumerable-System-String-,System-String-'></a>Join(value,separator)

### Summary

Concatenates the `value`s with the `separator`.

### Returns

The concatenated string.

### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.Collections.Generic.IEnumerable{System.String}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{System.String}') | The string values. |
| separator | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The separator. |

#### Suffix
## <a name='M-Vsxmd-Units-Extensions-Suffix-System-String,System-String-'></a>Suffix(value,suffix)

### Summary

Suffix the `suffix` to the `value`, and generate a new string.

### Returns

The new string.

### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The original string value. |
| suffix | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The suffix string. |

#### Escape
## <a name='M-Vsxmd-Units-Extensions-Escape-System-String-'></a>Escape(content)

### Summary

Escape the content to keep it raw in Markdown syntax.

### Returns

The escaped content.

### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| content | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The content. |

#### ToAnchor
## <a name='M-Vsxmd-Units-Extensions-ToAnchor-System-String-'></a>ToAnchor(href)

### Summary

Generate an anchor for the `href`.

### Returns

The anchor for the `href`.

### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| href | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The href. |

#### ToHereLink
## <a name='M-Vsxmd-Units-Extensions-ToHereLink-System-String-'></a>ToHereLink(href)

### Summary

Generate "to here" link for the `href`.

### Returns

The "to here" link for the `href`.

### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| href | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The href. |

#### ToReferenceLink
## <a name='M-Vsxmd-Units-Extensions-ToReferenceLink-System-String,System-Boolean-'></a>ToReferenceLink(memberName,useShortName)

### Summary

Generate the reference link for the `memberName`.

### Returns

The generated reference link.

### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| memberName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The member name. |
| useShortName | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | Indicate if use short type name. |

### Example

For `T:Vsxmd.Units.MemberUnit`, convert it to `[MemberUnit](#T-Vsxmd.Units.MemberUnit)`.

For `T:System.ArgumentException`, convert it to `[ArgumentException](http://msdn/path/to/System.ArgumentException)`.

#### AsCode
## <a name='M-Vsxmd-Units-Extensions-AsCode-System-String-'></a>AsCode(code)

### Summary

Wrap the `code` into Markdown backtick safely.

The backtick characters inside the `code` reverse as it is.

### Returns

The Markdown code span.

### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| code | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The code span. |

### Remarks

Reference: http://meta.stackexchange.com/questions/55437/how-can-the-backtick-character-be-included-in-code .

#### NthLast\`\`1
## <a name='M-Vsxmd-Units-Extensions-NthLast--1-System-Collections-Generic-IEnumerable---0-,System-Int32-'></a>NthLast\`\`1(source,index)

### Summary

Gets the n-th last element from the `source`.

### Returns

The element at the specified position in the `source` sequence.

### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| source | [System.Collections.Generic.IEnumerable{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{``0}') | The source enumerable. |
| index | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The index for the n-th last. |

### Generic Types

| Name | Description |
| ---- | ----------- |
| TSource | The type of the elements of `source`. |

#### TakeAllButLast\`\`1
## <a name='M-Vsxmd-Units-Extensions-TakeAllButLast--1-System-Collections-Generic-IEnumerable---0-,System-Int32-'></a>TakeAllButLast\`\`1(source,count)

### Summary

Take all element except the last `count`.

### Returns

The generated enumerable.

### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| source | [System.Collections.Generic.IEnumerable{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{``0}') | The source enumerable. |
| count | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The number to except. |

### Generic Types

| Name | Description |
| ---- | ----------- |
| TSource | The type of the elements of `source`. |

#### ToMarkdownText
## <a name='M-Vsxmd-Units-Extensions-ToMarkdownText-System-Xml-Linq-XElement-'></a>ToMarkdownText(element)

### Summary

Convert the inline XML nodes to Markdown text.
For example, it works for `summary` and `returns` elements.

### Returns

The generated Markdown content.

### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| element | [System.Xml.Linq.XElement](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Xml.Linq.XElement 'System.Xml.Linq.XElement') | The XML element. |

### Example

This method converts the following `summary` element.

```csharp
<summary>The <paramref name="element" /> value is <value>null</value>, it throws <c>ArgumentException</c>. For more, see <see cref="M:Vsxmd.Units.Extensions.ToMarkdownText(System.Xml.Linq.XElement)" />.</summary>
```

To the below Markdown content.

```csharp
The `element` value is `null`, it throws `ArgumentException`. For more, see `ToMarkdownText`.
```

##### IUnit
# <a name='T-Vsxmd-Units-IUnit'></a>IUnit

### Namespace

Vsxmd.Units

### Summary

[IUnit](#T-Vsxmd-Units-IUnit) is wrapper to handle XML elements.

#### ToMarkdown
## <a name='M-Vsxmd-Units-IUnit-ToMarkdown'></a>ToMarkdown()

### Summary

Represent the XML element content as Markdown syntax.

### Returns

The generated Markdown content.

### Parameters

This method has no parameters.

##### MemberKind
# <a name='T-Vsxmd-Units-MemberKind'></a>MemberKind

### Namespace

Vsxmd.Units

### Summary

The member kind.

#### NotSupported
## <a name='F-Vsxmd-Units-MemberKind-NotSupported'></a>NotSupported

### Summary

Not supported member kind.

#### Type
## <a name='F-Vsxmd-Units-MemberKind-Type'></a>Type

### Summary

Type.

#### Constants
## <a name='F-Vsxmd-Units-MemberKind-Constants'></a>Constants

### Summary

Constants

#### Constructor
## <a name='F-Vsxmd-Units-MemberKind-Constructor'></a>Constructor

### Summary

Constructor.

#### Property
## <a name='F-Vsxmd-Units-MemberKind-Property'></a>Property

### Summary

Property.

#### Method
## <a name='F-Vsxmd-Units-MemberKind-Method'></a>Method

### Summary

Method.

##### MemberName
# <a name='T-Vsxmd-Units-MemberName'></a>MemberName

### Namespace

Vsxmd.Units

### Summary

Member name.

#### #ctor
## <a name='M-Vsxmd-Units-MemberName--ctor-System-String,System-Collections-Generic-IEnumerable-System-String--'></a>#ctor(name,paramNames)

### Summary

Initializes a new instance of the [MemberName](#T-Vsxmd-Units-MemberName) class.

### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| name | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The raw member name. For example, `T:Vsxmd.Units.MemberName`. |
| paramNames | [System.Collections.Generic.IEnumerable{System.String}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{System.String}') | The parameter names. It is only used when member kind is [Constructor](#F-Vsxmd-Units-MemberKind-Constructor) or [Method](#F-Vsxmd-Units-MemberKind-Method). |

#### #ctor
## <a name='M-Vsxmd-Units-MemberName--ctor-System-String-'></a>#ctor(name)

### Summary

Initializes a new instance of the [MemberName](#T-Vsxmd-Units-MemberName) class.

### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| name | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The raw member name. For example, `T:Vsxmd.Units.MemberName`. |

#### Kind
## <a name='P-Vsxmd-Units-MemberName-Kind'></a>Kind

### Summary

Gets the member kind, one of [MemberKind](#T-Vsxmd-Units-MemberKind).

#### Link
## <a name='P-Vsxmd-Units-MemberName-Link'></a>Link

### Summary

Gets the link pointing to this member unit.

#### Caption
## <a name='P-Vsxmd-Units-MemberName-Caption'></a>Caption

### Summary

Gets the caption representation for this member name.

### Example

For [Type](#F-Vsxmd-Units-MemberKind-Type), show as `## Vsxmd.Units.MemberName [#](#here) [^](#contents)`.

For other kinds, show as `### Vsxmd.Units.MemberName.Caption [#](#here) [^](#contents)`.

#### TypeName
## <a name='P-Vsxmd-Units-MemberName-TypeName'></a>TypeName

### Summary

Gets the type name.

### Example

`Vsxmd.Program`, `Vsxmd.Units.TypeUnit`.

#### Namespace
## <a name='P-Vsxmd-Units-MemberName-Namespace'></a>Namespace

### Summary

Gets the namespace name.

### Example

`System`, `Vsxmd`, `Vsxmd.Units`.

#### CompareTo
## <a name='M-Vsxmd-Units-MemberName-CompareTo-Vsxmd-Units-MemberName-'></a>CompareTo()

### Summary

*Inherit from parent.*

### Parameters

This method has no parameters.

#### GetParamTypes
## <a name='M-Vsxmd-Units-MemberName-GetParamTypes'></a>GetParamTypes()

### Summary

Gets the method parameter type names from the member name.

### Returns

The method parameter type name list.

### Parameters

This method has no parameters.

### Example

It will prepend the type kind character (`T:`) to the type string.

For `(System.String,System.Int32)`, returns `["T:System.String","T:System.Int32"]`.

It also handle generic type.

For `(System.Collections.Generic.IEnumerable{System.String})`, returns `["T:System.Collections.Generic.IEnumerable{System.String}"]`.

#### ToReferenceLink
## <a name='M-Vsxmd-Units-MemberName-ToReferenceLink-System-Boolean-'></a>ToReferenceLink(useShortName)

### Summary

Convert the member name to Markdown reference link.

If then name is under `System` namespace, the link points to MSDN.

Otherwise, the link points to this page anchor.

### Returns

The generated Markdown reference link.

### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| useShortName | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | Indicate if use short type name. |

##### MemberUnit
# <a name='T-Vsxmd-Units-MemberUnit'></a>MemberUnit

### Namespace

Vsxmd.Units

### Summary

Member unit.

#### #ctor
## <a name='M-Vsxmd-Units-MemberUnit--ctor-System-Xml-Linq-XElement-'></a>#ctor(element)

### Summary

Initializes a new instance of the [MemberUnit](#T-Vsxmd-Units-MemberUnit) class.

### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| element | [System.Xml.Linq.XElement](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Xml.Linq.XElement 'System.Xml.Linq.XElement') | The member XML element. |

### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | Throw if XML element name is not `member`. |

#### Comparer
## <a name='P-Vsxmd-Units-MemberUnit-Comparer'></a>Comparer

### Summary

Gets the member unit comparer.

#### TypeName
## <a name='P-Vsxmd-Units-MemberUnit-TypeName'></a>TypeName

### Summary

Gets the type name.

### Example

`Vsxmd.Program`, `Vsxmd.Units.TypeUnit`.

#### Kind
## <a name='P-Vsxmd-Units-MemberUnit-Kind'></a>Kind

### Summary

Gets the member kind, one of [MemberKind](#T-Vsxmd-Units-MemberKind).

#### Link
## <a name='P-Vsxmd-Units-MemberUnit-Link'></a>Link

### Summary

Gets the link pointing to this member unit.

#### ToMarkdown
## <a name='M-Vsxmd-Units-MemberUnit-ToMarkdown'></a>ToMarkdown()

### Summary

*Inherit from parent.*

### Parameters

This method has no parameters.

#### ComplementType
## <a name='M-Vsxmd-Units-MemberUnit-ComplementType-System-Collections-Generic-IEnumerable-Vsxmd-Units-MemberUnit--'></a>ComplementType(group)

### Summary

Complement a type unit if the member unit `group` does not have one.
One member unit group has the same [TypeName](#P-Vsxmd-Units-MemberUnit-TypeName).

### Returns

The complemented member unit group.

### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| group | [System.Collections.Generic.IEnumerable{Vsxmd.Units.MemberUnit}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{Vsxmd.Units.MemberUnit}') | The member unit group. |

#### Compare
## <a name='M-Vsxmd-Units-MemberUnit-MemberUnitComparer-Compare-Vsxmd-Units-MemberUnit,Vsxmd-Units-MemberUnit-'></a>Compare()

### Summary

*Inherit from parent.*

### Parameters

This method has no parameters.

##### MemberUnitComparer
# <a name='T-Vsxmd-Units-MemberUnit-MemberUnitComparer'></a>MemberUnitComparer

### Namespace

Vsxmd.Units.MemberUnit

##### ParamUnit
# <a name='T-Vsxmd-Units-ParamUnit'></a>ParamUnit

### Namespace

Vsxmd.Units

### Summary

Param unit.

#### #ctor
## <a name='M-Vsxmd-Units-ParamUnit--ctor-System-Xml-Linq-XElement,System-String-'></a>#ctor(element,paramType)

### Summary

Initializes a new instance of the [ParamUnit](#T-Vsxmd-Units-ParamUnit) class.

### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| element | [System.Xml.Linq.XElement](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Xml.Linq.XElement 'System.Xml.Linq.XElement') | The param XML element. |
| paramType | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The parameter type corresponding to the param XML element. |

### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | Throw if XML element name is not `param`. |

#### ToMarkdown
## <a name='M-Vsxmd-Units-ParamUnit-ToMarkdown'></a>ToMarkdown()

### Summary

*Inherit from parent.*

### Parameters

This method has no parameters.

#### ToMarkdown
## <a name='M-Vsxmd-Units-ParamUnit-ToMarkdown-System-Collections-Generic-IEnumerable-System-Xml-Linq-XElement-,System-Collections-Generic-IEnumerable-System-String-,Vsxmd-Units-MemberKind-'></a>ToMarkdown(elements,paramTypes,memberKind)

### Summary

Convert the param XML element to Markdown safely.

### Returns

The generated Markdown.

### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| elements | [System.Collections.Generic.IEnumerable{System.Xml.Linq.XElement}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{System.Xml.Linq.XElement}') | The param XML element list. |
| paramTypes | [System.Collections.Generic.IEnumerable{System.String}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{System.String}') | The paramater type names. |
| memberKind | [Vsxmd.Units.MemberKind](#T-Vsxmd-Units-MemberKind) | The member kind of the parent element. |

### Remarks

When the parameter (a.k.a `elements`) list is empty:

If parent element kind is [Constructor](#F-Vsxmd-Units-MemberKind-Constructor) or [Method](#F-Vsxmd-Units-MemberKind-Method), it returns a hint about "no parameters".

If parent element kind is not the value mentioned above, it returns an empty string.

##### PermissionUnit
# <a name='T-Vsxmd-Units-PermissionUnit'></a>PermissionUnit

### Namespace

Vsxmd.Units

### Summary

Permission unit.

#### #ctor
## <a name='M-Vsxmd-Units-PermissionUnit--ctor-System-Xml-Linq-XElement-'></a>#ctor(element)

### Summary

Initializes a new instance of the [PermissionUnit](#T-Vsxmd-Units-PermissionUnit) class.

### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| element | [System.Xml.Linq.XElement](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Xml.Linq.XElement 'System.Xml.Linq.XElement') | The permission XML element. |

### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | Throw if XML element name is not `permission`. |

#### ToMarkdown
## <a name='M-Vsxmd-Units-PermissionUnit-ToMarkdown'></a>ToMarkdown()

### Summary

*Inherit from parent.*

### Parameters

This method has no parameters.

#### ToMarkdown
## <a name='M-Vsxmd-Units-PermissionUnit-ToMarkdown-System-Collections-Generic-IEnumerable-System-Xml-Linq-XElement--'></a>ToMarkdown(elements)

### Summary

Convert the permission XML element to Markdown safely.
If element is `null`, return empty string.

### Returns

The generated Markdown.

### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| elements | [System.Collections.Generic.IEnumerable{System.Xml.Linq.XElement}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{System.Xml.Linq.XElement}') | The permission XML element list. |

##### RemarksUnit
# <a name='T-Vsxmd-Units-RemarksUnit'></a>RemarksUnit

### Namespace

Vsxmd.Units

### Summary

Remarks unit.

#### #ctor
## <a name='M-Vsxmd-Units-RemarksUnit--ctor-System-Xml-Linq-XElement-'></a>#ctor(element)

### Summary

Initializes a new instance of the [RemarksUnit](#T-Vsxmd-Units-RemarksUnit) class.

### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| element | [System.Xml.Linq.XElement](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Xml.Linq.XElement 'System.Xml.Linq.XElement') | The remarks XML element. |

### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | Throw if XML element name is not `remarks`. |

#### ToMarkdown
## <a name='M-Vsxmd-Units-RemarksUnit-ToMarkdown'></a>ToMarkdown()

### Summary

*Inherit from parent.*

### Parameters

This method has no parameters.

#### ToMarkdown
## <a name='M-Vsxmd-Units-RemarksUnit-ToMarkdown-System-Xml-Linq-XElement-'></a>ToMarkdown(element)

### Summary

Convert the remarks XML element to Markdown safely.
If element is `null`, return empty string.

### Returns

The generated Markdown.

### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| element | [System.Xml.Linq.XElement](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Xml.Linq.XElement 'System.Xml.Linq.XElement') | The remarks XML element. |

##### ReturnsUnit
# <a name='T-Vsxmd-Units-ReturnsUnit'></a>ReturnsUnit

### Namespace

Vsxmd.Units

### Summary

Returns unit.

#### #ctor
## <a name='M-Vsxmd-Units-ReturnsUnit--ctor-System-Xml-Linq-XElement-'></a>#ctor(element)

### Summary

Initializes a new instance of the [ReturnsUnit](#T-Vsxmd-Units-ReturnsUnit) class.

### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| element | [System.Xml.Linq.XElement](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Xml.Linq.XElement 'System.Xml.Linq.XElement') | The returns XML element. |

### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | Throw if XML element name is not `returns`. |

#### ToMarkdown
## <a name='M-Vsxmd-Units-ReturnsUnit-ToMarkdown'></a>ToMarkdown()

### Summary

*Inherit from parent.*

### Parameters

This method has no parameters.

#### ToMarkdown
## <a name='M-Vsxmd-Units-ReturnsUnit-ToMarkdown-System-Xml-Linq-XElement-'></a>ToMarkdown(element)

### Summary

Convert the returns XML element to Markdown safely.
If element is `null`, return empty string.

### Returns

The generated Markdown.

### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| element | [System.Xml.Linq.XElement](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Xml.Linq.XElement 'System.Xml.Linq.XElement') | The returns XML element. |

##### SeealsoUnit
# <a name='T-Vsxmd-Units-SeealsoUnit'></a>SeealsoUnit

### Namespace

Vsxmd.Units

### Summary

Seealso unit.

#### #ctor
## <a name='M-Vsxmd-Units-SeealsoUnit--ctor-System-Xml-Linq-XElement-'></a>#ctor(element)

### Summary

Initializes a new instance of the [SeealsoUnit](#T-Vsxmd-Units-SeealsoUnit) class.

### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| element | [System.Xml.Linq.XElement](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Xml.Linq.XElement 'System.Xml.Linq.XElement') | The seealso XML element. |

### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | Throw if XML element name is not `seealso`. |

#### ToMarkdown
## <a name='M-Vsxmd-Units-SeealsoUnit-ToMarkdown'></a>ToMarkdown()

### Summary

*Inherit from parent.*

### Parameters

This method has no parameters.

#### ToMarkdown
## <a name='M-Vsxmd-Units-SeealsoUnit-ToMarkdown-System-Collections-Generic-IEnumerable-System-Xml-Linq-XElement--'></a>ToMarkdown(elements)

### Summary

Convert the seealso XML element to Markdown safely.
If element is `null`, return empty string.

### Returns

The generated Markdown.

### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| elements | [System.Collections.Generic.IEnumerable{System.Xml.Linq.XElement}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{System.Xml.Linq.XElement}') | The seealso XML element list. |

##### SummaryUnit
# <a name='T-Vsxmd-Units-SummaryUnit'></a>SummaryUnit

### Namespace

Vsxmd.Units

### Summary

Summary unit.

#### #ctor
## <a name='M-Vsxmd-Units-SummaryUnit--ctor-System-Xml-Linq-XElement-'></a>#ctor(element)

### Summary

Initializes a new instance of the [SummaryUnit](#T-Vsxmd-Units-SummaryUnit) class.

### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| element | [System.Xml.Linq.XElement](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Xml.Linq.XElement 'System.Xml.Linq.XElement') | The summary XML element. |

### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | Throw if XML element name is not `summary`. |

#### ToMarkdown
## <a name='M-Vsxmd-Units-SummaryUnit-ToMarkdown'></a>ToMarkdown()

### Summary

*Inherit from parent.*

### Parameters

This method has no parameters.

#### ToMarkdown
## <a name='M-Vsxmd-Units-SummaryUnit-ToMarkdown-System-Xml-Linq-XElement-'></a>ToMarkdown(element)

### Summary

Convert the summary XML element to Markdown safely.
If element is `null`, return empty string.

### Returns

The generated Markdown.

### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| element | [System.Xml.Linq.XElement](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Xml.Linq.XElement 'System.Xml.Linq.XElement') | The summary XML element. |

##### TypeparamUnit
# <a name='T-Vsxmd-Units-TypeparamUnit'></a>TypeparamUnit

### Namespace

Vsxmd.Units

### Summary

Typeparam unit.

#### #ctor
## <a name='M-Vsxmd-Units-TypeparamUnit--ctor-System-Xml-Linq-XElement-'></a>#ctor(element)

### Summary

Initializes a new instance of the [TypeparamUnit](#T-Vsxmd-Units-TypeparamUnit) class.

### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| element | [System.Xml.Linq.XElement](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Xml.Linq.XElement 'System.Xml.Linq.XElement') | The typeparam XML element. |

### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | Throw if XML element name is not `typeparam`. |

#### ToMarkdown
## <a name='M-Vsxmd-Units-TypeparamUnit-ToMarkdown'></a>ToMarkdown()

### Summary

*Inherit from parent.*

### Parameters

This method has no parameters.

#### ToMarkdown
## <a name='M-Vsxmd-Units-TypeparamUnit-ToMarkdown-System-Collections-Generic-IEnumerable-System-Xml-Linq-XElement--'></a>ToMarkdown(elements)

### Summary

Convert the param XML element to Markdown safely.
If element is `null`, return empty string.

### Returns

The generated Markdown.

### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| elements | [System.Collections.Generic.IEnumerable{System.Xml.Linq.XElement}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{System.Xml.Linq.XElement}') | The param XML element list. |
