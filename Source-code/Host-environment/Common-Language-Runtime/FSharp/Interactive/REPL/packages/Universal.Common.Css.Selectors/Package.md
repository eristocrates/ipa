# Universal.Common.Css.Selectors
A comprehensive CSS selector parsing library that supports CSS Selectors Level 4 specification with full type safety and immutable design.

## Classes

### SelectorParser
Parses CSS selector strings into structured selector objects with complete CSS4 support including functional selectors and logical combinators.
```csharp
var parser = new SelectorParser();

// Parse simple selectors
var selectorList = parser.Parse("div.main-content");

// Parse complex selectors with pseudo-classes
var complexSelector = parser.Parse("nav > ul li:nth-child(2n+1):hover");

// Parse multiple selectors
var multipleSelectors = parser.Parse("h1, h2, h3");

// Parse modern CSS4 functional selectors
var functionalSelector = parser.Parse(":not(.hidden):is(.visible, .shown)");
```

### SelectorList
Represents a comma-separated list of selectors with convenient access methods.
```csharp
var selectorList = new SelectorList(selector1, selector2, selector3);
// Access individual selectors
foreach (var selector in selectorList.Selectors)
{
    Console.WriteLine(selector.ToString());
}
```

### Selector
Represents a complete selector chain with specificity calculation and structural analysis.
```csharp
var selector = new Selector(compoundSelector, combinator, compoundSelector);

// Calculate CSS specificity
var (a, b, c) = selector.GetSpecificity();

// Compare specificity with another selector
bool isMoreSpecific = selector.IsMoreSpecificThan(otherSelector);

// Check if selector is complex (contains combinators)
bool isComplex = selector.IsComplex;
```

### CompoundSelector
Represents a sequence of simple selectors (like `div.class#id:hover`) with easy access to different selector types.
```csharp
var compound = new CompoundSelector(
    new TypeSelector("div"),
    new ClassSelector("main"),
    new IdSelector("content")
);

// Access specific selector types
var idSelector = compound.IdSelector;
var classSelectors = compound.ClassSelectors;
var pseudoClasses = compound.PseudoClassSelectors;
```

### Simple Selectors
Type-safe representations of all CSS selector types:

#### Basic Selectors
```csharp
var typeSelector = new TypeSelector("div");           // div
var classSelector = new ClassSelector("main");        // .main
var idSelector = new IdSelector("content");           // #content
var universalSelector = new UniversalSelector();      // *
```

#### Attribute Selectors
```csharp
var hasAttr = new AttributeSelector("data-value");                    // [data-value]
var equals = new AttributeSelector("type", AttributeMatcher.Equal, "text"); // [type="text"]
var contains = new AttributeSelector("class", AttributeMatcher.Includes, "btn"); // [class~="btn"]
```

#### Pseudo-Class Selectors
```csharp
var hover = UserActionPseudoClassSelector.Hover();        // :hover
var checked = FormPseudoClassSelector.Checked();          // :checked
var firstChild = StructuralPseudoClassSelector.FirstChild(); // :first-child
var nthChild = StructuralPseudoClassSelector.NthChild(AnPlusB.Odd()); // :nth-child(odd)
```

#### Functional Selectors
```csharp
var notSelector = FunctionalPseudoClassSelector.Not(selectorList);     // :not(...)
var isSelector = FunctionalPseudoClassSelector.Is(selectorList);       // :is(...)
var whereSelector = FunctionalPseudoClassSelector.Where(selectorList); // :where(...)
var hasSelector = FunctionalPseudoClassSelector.Has(relativeSelectorList); // :has(...)
```

### AnPlusB
Represents the An+B microsyntax used in structural pseudo-classes like `:nth-child()`.
```csharp
var odd = AnPlusB.Odd();                    // odd
var even = AnPlusB.Even();                  // even  
var every3rd = AnPlusB.Linear(3, 0);        // 3n
```

### Combinators
Type-safe representation of CSS combinators with proper enum backing.
```csharp
var childCombinator = new Combinator(CombinatorType.Child);           // >
var descendantCombinator = new Combinator(CombinatorType.Descendant); // (whitespace)
var adjacentCombinator = new Combinator(CombinatorType.NextSibling);  // +
var generalCombinator = new Combinator(CombinatorType.SubsequentSibling); // ~
```