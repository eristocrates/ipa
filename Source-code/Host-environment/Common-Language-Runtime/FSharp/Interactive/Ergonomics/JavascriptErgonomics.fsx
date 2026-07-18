#r "nuget: WebSharper.Compiler.FSharp, 10.1.6.676"

open System
open WebSharper.Compiler

open Microsoft.FSharp.Quotations
open WebSharper.Core.Metadata

let expression = <@ 1 + 2 @>

let quotation_compiler = new QuotationCompiler(Info.Empty)

let result = quotation_compiler.CompileExpression(expression)

printfn "%A" result
