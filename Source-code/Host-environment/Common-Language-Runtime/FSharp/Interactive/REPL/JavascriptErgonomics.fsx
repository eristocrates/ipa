#load @".paket/load/main.group.fsx"
#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#r "TaskErgonomics.dll"

open TaskErgonomics
open Lambda2Js
open System.Reflection
open AngleSharp.Attributes
open System.Linq.Expressions
open System


type AngleSharpDomMetadataProvider() =
    inherit JavascriptMetadataProvider()

    let fallback = AttributeJavascriptMetadataProvider()

    override _.GetMemberMetadata(memberInfo: MemberInfo) =

        let domName =
            memberInfo.GetCustomAttributes(typeof<DomNameAttribute>, false)
            |> Seq.tryPick (function
                | :? DomNameAttribute as attribute -> Some attribute.OfficialName
                | _ -> None)

        match domName with
        | Some name -> JavascriptMemberAttribute(MemberName = name) :> IJavascriptMemberMetadata

        | None -> fallback.GetMemberMetadata(memberInfo)


type Javascript private () =

    static let options = JavascriptCompilationOptions(enum<JsCompilationFlags> 0)

    static do options.CustomMetadataProvider <- AngleSharpDomMetadataProvider()

    static member func<'InputType, 'OutputType>(expression: Expression<Func<'InputType, 'OutputType>>) = expression

    static member asText<'InputType, 'OutputType>(expression: Expression<Func<'InputType, 'OutputType>>) =
        expression.CompileToJavascript(options)
