#r "nuget: AngleSharp"

open AngleSharp
open System

// 1. Setup a simple HTML document
let htmlContent =
    """
<!DOCTYPE html>
<html>
<head>
    <title>AngleSharp Test</title>
</head>
<body>
    <h1>Hello, World!</h1>
    <p>This is a <em>test</em> of AngleSharp.</p>
</body>
</html>
"""

// 2. Initialize the browsing context and parse the HTML
let config = Configuration.Default
let context = BrowsingContext.New(config)

let document =
    context.OpenAsync(fun req -> req.Content(htmlContent))
        .Result

// 3. Select all elements in document order using a universal selector (*)
let allElements = document.QuerySelectorAll("*")

// 4. Iterate and print information about each element
allElements

|> Seq.iter (fun el -> printfn "Tag: %s | Class: %s | Text: %s" el.TagName el.ClassName (el.TextContent.Trim()))
