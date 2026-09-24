#time on

fsi.PrintLength <- 10
fsi.ShowDeclarationValues <- false

#I @"D:\https\com\github\eristocrates\ipa\dll"

#I @"D:\https\com\github\eristocrates\ipa\fsx"
#load "PrettierNaming.fsx"

#load @".paket/load/main.group.fsx"

open System
open Fabulous.AST
open Fantomas.Core

let RecordExprValue (identifier: string) (recordFields: WidgetBuilder<SyntaxOak.RecordFieldNode> array) =
    let variableBinder = PrettierNaming.VariableBinder identifier
    Ast.Value(variableBinder.binding, Ast.RecordExpr(recordFields))

let ArrayExprValue (identifier: string) (mapping: 'Element -> WidgetBuilder<SyntaxOak.Expr>) (elements: 'Element array) =
    let variableBinder = PrettierNaming.VariableBinder identifier
    Ast.Value(
        variableBinder.binding,
        Ast.ArrayExpr(
            [
                for element in elements do
                    mapping element
            ]
        )
    )
