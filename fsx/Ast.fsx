#time on

fsi.PrintLength <- 10
fsi.ShowDeclarationValues <- false

open System

#load @".paket/load/main.group.fsx"
#I @"D:\https\com\github\eristocrates\ipa\fsx"
#r "Ipa.dll"

open Ipa

#r "FSLang.dll"
open Fabulous.AST
open Fantomas.Core


let RecordExprValue (identifier: string) (recordFields: WidgetBuilder<SyntaxOak.RecordFieldNode> array) =
    let letBinder = FSLang.VariableBinder identifier
    Ast.Value(letBinder.binding, Ast.RecordExpr(recordFields))

let ArrayExprValue (identifier: string) (mapping: 'Element -> WidgetBuilder<SyntaxOak.Expr>) (elements: 'Element array) =
    let letBinder = FSLang.VariableBinder identifier
    Ast.Value(
        letBinder.binding,
        Ast.ArrayExpr(
            [
                for element in elements do
                    mapping element
            ]
        )
    )
