#r "nuget: WebSharper, 9.1.9.621"
open WebSharper.Core

let elementIdentifier = JavaScript.Syntax.Id.New("element")
let elementReference = JavaScript.Syntax.Var elementIdentifier

let outerHTMLPropertyAccess =
    JavaScript.Syntax.Binary(
        elementReference,
        JavaScript.Syntax.BinaryOperator.``.``,
        JavaScript.Syntax.Literal.String "outerHTML"
        |> JavaScript.Syntax.Constant
    )

let outerHTMLFunction =
    JavaScript.Syntax.Lambda(
        None,
        [ elementIdentifier ],
        [ JavaScript.Syntax.Return(Some outerHTMLPropertyAccess) ],
        true
    )

let outerHTMLJavaScript =
    JavaScript.Writer.ExpressionToString JavaScript.Preferences.Readable outerHTMLFunction
