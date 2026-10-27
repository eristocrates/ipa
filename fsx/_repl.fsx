#time on
fsi.PrintLength <- 1
fsi.ShowDeclarationValues <- false
#r "nuget: Newtonsoft.Json, 13.0.0.0"

#I @"D:\https\com\github\eristocrates\ipa\dll"
#I @"D:\https\com\github\eristocrates\ipa\fs\DoxAletheia\src\DoxAletheia.Runtime\bin\Release\net10.0"
#I @"D:\https\com\github\eristocrates\ipa\fsx"
#load "Me.fsx"
#load "Clipboard.fsx"
open Me
open Clipboard
#load @".paket/load/main.group.fsx"
#r "DoxAletheia.Runtime.dll"
open DoxAletheia.Runtime
open type Functional

open Ada.Url
open AngleSharp.Html.Parser
open BrowserApi.Css.Authoring
open canopy
open DoxAletheia
open Dubzer.WhatwgUrl
open System
open System.Reflection
open TypeShape.Core
open Fabulous.AST.Json
open Fli
open Flurl
open FolkerKinzel.MimeTypes
open FSharp.Data.JsonExtensions
open FSharpPlus
open FsHttp
open FsPublicSuffix
open Iana
open IriTools
open Json.More
open Json.Path
open Json.Pointer
open JsonStructure
open Meziantou.Framework
open Microsoft.FSharp.Quotations
open Microsoft.FSharp.Quotations.Patterns
open MimeDetective
open Nager.PublicSuffix
open Nager.PublicSuffix.Models
open Nager.PublicSuffix.RuleParsers
open Nager.PublicSuffix.RuleProviders
open Newtonsoft.Json
open Newtonsoft.Json.Linq
open NJsonSchema
open NLanguageTag
open NuGet
open NuGet.CatalogReader
open NuGet.Common
open NuGet.Protocol
open NuGet.Protocol.Core.Types
open NuGet.Protocol.Resources
open OpenQA.Selenium
open OpenQA.Selenium.Edge
open OpenQA.Selenium.Remote
open ProviderImplementation.ProvidedTypes
open PuppeteerSharp
open PuppeteerSharp.Cdp
open RDFSharp.Model
open ShapeSifter
open System
open System.Collections
open System.Collections.Concurrent
open System.Collections.Generic
open System.ComponentModel.DataAnnotations
open System.Diagnostics
open System.Globalization
open System.IO
open System.Linq
open System.Net
open System.Reflection
open System.Security.Cryptography
open System.Text
open System.Text.Json
open System.Text.Json.Schema
open System.Text.Json.Serialization
open System.Text.RegularExpressions
open System.Threading
open System.Threading.Tasks
open System.Xml
open System.Xml.Linq
open Tavis.UriTemplates
open TypeShape
open TypeShape.Core
open VDS.Common.Tries

open System.Numerics
open WebSharper.Core 

open System
open System.Reflection

open Microsoft.FSharp.Quotations
open Microsoft.FSharp.Quotations.Patterns

open AngleSharp.Attributes
open AngleSharp.Dom

open WebSharper.Core
open System.Xml.XPath

open ShapeSifter.Patterns
open TypeEquality
open HCollections
open Microsoft.FSharp.Reflection
open Microsoft.FSharp.Linq.RuntimeHelpers

open FSharp.Data
open FSharp.Data.JsonPath
open FSharp.Data.JsonSchema
open FSharp.Data.JsonSchema.Core
open FSharp.Data.JsonSchema.OpenApi

type JsonNode = Nodes.JsonNode
type JsonNodeObject = Nodes.JsonObject
type JsonNodeArray = Nodes.JsonArray
type JsonNodeValue = Nodes.JsonValue

open System
open System.Collections.Generic

open Microsoft.FSharp.Linq.RuntimeHelpers
open Microsoft.FSharp.Quotations
open Microsoft.FSharp.Reflection

open ShapeSifter
open ShapeSifter.Patterns

open Nager.PublicSuffix.Models
open FolkerKinzel.MimeTypes

// -----------------------------------------------------------------------------
// Additional type patterns
// -----------------------------------------------------------------------------

let inline (|EnumUnion|_|) (_ : TType<'ValueType>) =
    if typeof<'ValueType>.IsEnum then
        Some ()
    else
        None

// -----------------------------------------------------------------------------
// Projection
//
// This is the result context used when an exact quotation of 'ValueType cannot
// be constructed.
//
// -----------------------------------------------------------------------------
type Projection<'ValueType> =

    /// An F# record whose original nominal value could not be reconstructed.
    | RecordProduct of
        projectionSource : 'ValueType

    /// An ordinary CLR class or struct whose original nominal value could not
    /// be reconstructed.
    | PocoProduct of
        projectionSource : 'ValueType

    /// A tuple whose original tuple could not be reconstructed because one or
    /// more of its elements required projection.
    | TupleProduct of
        projectionSource : 'ValueType

    /// An F# discriminated union whose original nominal value could not be
    /// reconstructed.
    | UnionProduct of
        projectionSource : 'ValueType

    /// An enumerable whose original container could not be reconstructed.
    | EnumerableProduct of
        projectionSource : 'ValueType

    static member projectionSourceType =
        typeof<'ValueType>

    member this.projectionSource =
        match this with
        | RecordProduct projectionSource
        | PocoProduct projectionSource
        | TupleProduct projectionSource
        | UnionProduct projectionSource
        | EnumerableProduct projectionSource ->
            projectionSource

    static member private namedValue
        (name : string)
        (valueExpression : Expr)
        : Expr
        =

        Expr.NewTuple [
            Expr.Value name
            valueExpression
        ]

    /// Represents one structural level as one heterogeneous product.
    ///
    /// Zero values become unit.
    /// One value remains that value.
    /// Multiple values become one n-ary tuple.
    static member private projectedValues
        (expressions : Expr list)
        : Expr
        =

        match expressions with
        | [] ->
            Expr.Value(())

        | [expression] ->
            expression

        | expressions ->
            Expr.NewTuple expressions

    static member private usableMember
        (memberShape : IShapeReadOnlyMember<'SourceType>)
        : bool
        =

        memberShape.IsPublic
        &&
        match memberShape.MemberInfo with
        | :? PropertyInfo as propertyInfo ->
            propertyInfo.GetIndexParameters().Length = 0

        | _ ->
            true

    static member private projectMemberValue
        (projectionSource : 'SourceType)
        (memberShape : IShapeReadOnlyMember<'SourceType>)
        : Expr
        =

        memberShape.Accept {
            new IReadOnlyMemberVisitor<'SourceType, Expr> with

                member _.Visit<'MemberType>
                    (memberShape : ReadOnlyMember<'SourceType, 'MemberType>)
                    =

                    let memberValue : 'MemberType =
                        memberShape.Get projectionSource

                    memberValue
                    |> CodeQuotation<'MemberType>.lift
                    |> CodeQuotation<'MemberType>.lower
        }

    static member private projectMember
        (projectionSource : 'SourceType)
        (memberShape : IShapeReadOnlyMember<'SourceType>)
        : Expr
        =

        let memberExpression =
            Projection<'ValueType>.projectMemberValue
                projectionSource
                memberShape

        Projection<'ValueType>.namedValue
            memberShape.Label
            memberExpression

    static member private projectMembers
        (projectionSource : 'SourceType)
        (members : IShapeReadOnlyMember<'SourceType> array)
        : Expr
        =

        members
        |> Array.filter Projection<'ValueType>.usableMember
        |> Array.map (
            Projection<'ValueType>.projectMember
                projectionSource
        )
        |> Array.toList
        |> Projection<'ValueType>.projectedValues

    static member private projectTupleElements
        (projectionSource : 'SourceType)
        (elements : IShapeReadOnlyMember<'SourceType> array)
        : Expr
        =

        elements
        |> Array.map (
            Projection<'ValueType>.projectMemberValue
                projectionSource
        )
        |> Array.toList
        |> Projection<'ValueType>.projectedValues

    static member private tryNamedPathExpression<'SourceType>
        (projectionSource : 'SourceType)
        (path : string list)
        : Expr option
        =

        match path with
        | [] ->

            projectionSource
            |> CodeQuotation<'SourceType>.lift
            |> CodeQuotation<'SourceType>.lower
            |> Some

        | memberName :: remainingPath ->

            let tryMember
                (members : IShapeReadOnlyMember<'SourceType> array)
                =

                members
                |> Array.filter Projection<'ValueType>.usableMember
                |> Array.tryFind (fun memberShape ->
                    memberShape.Label = memberName
                )
                |> Option.bind (fun memberShape ->

                    memberShape.Accept {
                        new IReadOnlyMemberVisitor<'SourceType, Expr option> with

                            member _.Visit<'MemberType>
                                (memberShape : ReadOnlyMember<'SourceType, 'MemberType>)
                                =

                                let memberValue : 'MemberType =
                                    memberShape.Get projectionSource

                                Projection<'MemberType>.tryNamedPathExpression
                                    memberValue
                                    remainingPath
                    }
                )

            match shapeof<'SourceType> with

            | Shape.FSharpRecord (:? ShapeFSharpRecord<'SourceType> as recordShape) ->

                recordShape.Fields
                |> Array.map (fun field ->
                    field :> IShapeReadOnlyMember<'SourceType>
                )
                |> tryMember

            | Shape.Poco (:? ShapePoco<'SourceType> as pocoShape) ->

                let publicFields : IShapeReadOnlyMember<'SourceType> array =
                    pocoShape.Fields
                    |> Array.map (fun field ->
                        field :> IShapeReadOnlyMember<'SourceType>
                    )

                let properties : IShapeReadOnlyMember<'SourceType> array =
                    pocoShape.Properties

                Array.append
                    publicFields
                    properties
                |> tryMember

            | Shape.FSharpUnion (:? ShapeFSharpUnion<'SourceType> as unionShape) ->

                let caseIndex =
                    unionShape.GetTag projectionSource

                let activeCase =
                    unionShape.UnionCases.[caseIndex]

                if memberName = "$case" then

                    match remainingPath with
                    | [] ->
                        Expr.Value activeCase.CaseInfo.Name
                        |> Some

                    | _ ->
                        None

                else

                    activeCase.Fields
                    |> Array.map (fun field ->
                        field :> IShapeReadOnlyMember<'SourceType>
                    )
                    |> tryMember

            | _ ->
                None

    member this.projectionExpression : Expr =

        let projectionSource =
            this.projectionSource

        match this with

        | RecordProduct _ ->

            match shapeof<'ValueType> with

            | Shape.FSharpRecord (:? ShapeFSharpRecord<'ValueType> as recordShape) ->

                recordShape.Fields
                |> Array.map (fun field ->
                    field :> IShapeReadOnlyMember<'ValueType>
                )
                |> Projection<'ValueType>.projectMembers projectionSource

            | _ ->

                invalidOp
                    $"Projection expected {typeof<'ValueType>.FullName} to be an F# record."

        | PocoProduct _ ->

            match shapeof<'ValueType> with

            | Shape.Poco (:? ShapePoco<'ValueType> as pocoShape) ->

                let publicFields : IShapeReadOnlyMember<'ValueType> array =
                    pocoShape.Fields
                    |> Array.map (fun field ->
                        field :> IShapeReadOnlyMember<'ValueType>
                    )

                let properties : IShapeReadOnlyMember<'ValueType> array =
                    pocoShape.Properties

                Array.append
                    publicFields
                    properties
                |> Projection<'ValueType>.projectMembers projectionSource

            | _ ->

                invalidOp
                    $"Projection expected {typeof<'ValueType>.FullName} to be a POCO."

        | TupleProduct _ ->

            match shapeof<'ValueType> with

            | Shape.Tuple (:? ShapeTuple<'ValueType> as tupleShape) ->

                tupleShape.Elements
                |> Array.map (fun element ->
                    element :> IShapeReadOnlyMember<'ValueType>
                )
                |> Projection<'ValueType>.projectTupleElements projectionSource

            | _ ->

                invalidOp
                    $"Projection expected {typeof<'ValueType>.FullName} to be a tuple."

        | UnionProduct _ ->

            match shapeof<'ValueType> with

            | Shape.FSharpUnion (:? ShapeFSharpUnion<'ValueType> as unionShape) ->

                let caseIndex =
                    unionShape.GetTag projectionSource

                let activeCase =
                    unionShape.UnionCases.[caseIndex]

                let caseExpression =
                    Projection<'ValueType>.namedValue
                        "$case"
                        (Expr.Value activeCase.CaseInfo.Name)

                let fieldExpressions =
                    activeCase.Fields
                    |> Array.map (fun field ->
                        field :> IShapeReadOnlyMember<'ValueType>
                    )
                    |> Array.filter Projection<'ValueType>.usableMember
                    |> Array.map (
                        Projection<'ValueType>.projectMember
                            projectionSource
                    )
                    |> Array.toList

                caseExpression :: fieldExpressions
                |> Projection<'ValueType>.projectedValues

            | _ ->

                invalidOp
                    $"Projection expected {typeof<'ValueType>.FullName} to be an F# union."

        | EnumerableProduct _ ->

            match shapeof<'ValueType> with

            | Shape.Enumerable enumerableShape ->

                enumerableShape.Accept {
                    new IEnumerableVisitor<Expr> with

                        member _.Visit<'Enumerable, 'Element when 'Enumerable :> seq<'Element>>() =

                            let enumerableValue : 'Enumerable =
                                projectionSource
                                |> box
                                |> unbox<'Enumerable>

                            enumerableValue
                            |> Seq.map (fun element ->

                                element
                                |> CodeQuotation<'Element>.lift
                                |> CodeQuotation<'Element>.lower
                            )
                            |> Seq.toList
                            |> Projection<'ValueType>.projectedValues
                }

            | _ ->

                invalidOp
                    $"Projection expected {typeof<'ValueType>.FullName} to be enumerable."

    member this.projectionType =
        this.projectionExpression.Type

    /// Names of the immediate named members represented by this projection.
    ///
    /// Positional projections such as tuples and enumerables have no member
    /// names and therefore return an empty list.
    member this.projectionMemberNames : string list =

        let projectionSource =
            this.projectionSource

        match this with

        | RecordProduct _ ->

            match shapeof<'ValueType> with
            | Shape.FSharpRecord (:? ShapeFSharpRecord<'ValueType> as recordShape) ->

                recordShape.Fields
                |> Array.map (fun field ->
                    field :> IShapeReadOnlyMember<'ValueType>
                )
                |> Array.filter Projection<'ValueType>.usableMember
                |> Array.map _.Label
                |> Array.toList

            | _ ->
                []

        | PocoProduct _ ->

            match shapeof<'ValueType> with
            | Shape.Poco (:? ShapePoco<'ValueType> as pocoShape) ->

                let publicFields : IShapeReadOnlyMember<'ValueType> array =
                    pocoShape.Fields
                    |> Array.map (fun field ->
                        field :> IShapeReadOnlyMember<'ValueType>
                    )

                Array.append
                    publicFields
                    pocoShape.Properties
                |> Array.filter Projection<'ValueType>.usableMember
                |> Array.map _.Label
                |> Array.toList

            | _ ->
                []

        | UnionProduct _ ->

            match shapeof<'ValueType> with
            | Shape.FSharpUnion (:? ShapeFSharpUnion<'ValueType> as unionShape) ->

                let activeCase =
                    unionShape.UnionCases.[unionShape.GetTag projectionSource]

                "$case"
                ::
                (
                    activeCase.Fields
                    |> Array.map (fun field ->
                        field :> IShapeReadOnlyMember<'ValueType>
                    )
                    |> Array.filter Projection<'ValueType>.usableMember
                    |> Array.map _.Label
                    |> Array.toList
                )

            | _ ->
                []

        | TupleProduct _
        | EnumerableProduct _ ->
            []

    /// Retrieves a lowered expression by following named members of the
    /// original structural value.
    ///
    /// This does not inspect or reverse-engineer the evaluated tuple
    /// representation. It traverses the original typed source.
    member this.tryPathExpression
        (path : string list)
        : Expr option
        =

        match path with
        | [] ->
            Some this.projectionExpression

        | path ->
            Projection<'ValueType>.tryNamedPathExpression
                this.projectionSource
                path

    member this.tryMemberExpression
        (memberName : string)
        : Expr option
        =

        this.tryPathExpression [memberName]

    member this.tryPathValueObject
        (path : string list)
        : obj option
        =

        this.tryPathExpression path
        |> Option.map LeafExpressionConverter.EvaluateQuotation

    member this.tryMemberValueObject
        (memberName : string)
        : obj option
        =

        this.tryPathValueObject [memberName]

    static member ofValue
        (projectionSource : 'ValueType)
        : Projection<'ValueType>
        =

        match shapeof<'ValueType> with

        | Shape.FSharpRecord (:? ShapeFSharpRecord<'ValueType>) ->
            RecordProduct projectionSource

        | Shape.Poco (:? ShapePoco<'ValueType>) ->
            PocoProduct projectionSource

        | Shape.Tuple (:? ShapeTuple<'ValueType>) ->
            TupleProduct projectionSource

        | Shape.FSharpUnion (:? ShapeFSharpUnion<'ValueType>) ->
            UnionProduct projectionSource

        | Shape.Enumerable _ ->
            EnumerableProduct projectionSource

        | shape ->

            invalidOp
                $"Projection does not yet support {shape.Type.FullName}"

// -----------------------------------------------------------------------------
// CodeQuotation
// -----------------------------------------------------------------------------

and CodeQuotation<'ValueType> =

    /// The original type can be reconstructed exactly.
    | DirectQuote of Expr<'ValueType>

    /// The original type cannot be reconstructed exactly and therefore needs
    /// to be structurally projected.
    | IndirectQuote of Projection<'ValueType>

    static member  lift
        (value : 'ValueType)
        : CodeQuotation<'ValueType>
        =

        CodeQuotation<'ValueType>.ofValue
            value

    static member  lower (quote:CodeQuotation<'ValueType>) : Expr = 
            match quote with 

            | DirectQuote expression -> expression :> Expr

            | IndirectQuote projection -> projection.projectionExpression

    static member inline tryValue
        (quote : CodeQuotation<'ValueType>)
        : 'ValueType option
        =
            match quote with 

            | DirectQuote expression -> 
                LeafExpressionConverter.EvaluateQuotation( expression )
                    :?> 'ValueType
                    |> Some
                
            | _ -> None
    static member inline project
        (quote : CodeQuotation<'ValueType>)
        : Projection<'ValueType>
        =
            match quote with 

            | DirectQuote expression -> 
                LeafExpressionConverter.EvaluateQuotation( expression )
                    :?> 'ValueType
                    |> Projection<'ValueType>.ofValue
                
            | IndirectQuote projection -> projection
    static member inline valueObject
        (quote : CodeQuotation<'ValueType>)
        : obj
        =
        quote
        |> CodeQuotation<'ValueType>.lower
        |> LeafExpressionConverter.EvaluateQuotation
    member this.lowered = CodeQuotation.lower this
    member this.tryEvaluate = CodeQuotation.tryValue this
    member this.evaluated = CodeQuotation.valueObject this
    member this.projected = CodeQuotation.project this

    // Generic option traversal
    //
    // This is used whenever every constituent must be directly quotable for
    // the enclosing value itself to be directly quotable.
    // -------------------------------------------------------------------------

    static member private traverse<'Input, 'Output>
        (values : seq<'Input>)
        (mapping : 'Input -> 'Output option)
        : 'Output list option
        =

        values
        |> Seq.fold
            (fun state value ->

                match state with
                | None ->
                    None

                | Some results ->
                    match mapping value with
                    | Some result ->
                        Some (result :: results)

                    | None ->
                        None
            )
            (Some [])
        |> Option.map List.rev

    // -------------------------------------------------------------------------
    // Homogeneous structural values
    // -------------------------------------------------------------------------

    static member private ofHomogeneousElements<'Element>
        (elements : seq<'Element>)
        : Expr<'Element array> option
        =

        CodeQuotation<'ValueType>.traverse
            elements
            (fun element ->

                CodeQuotation<'Element>.tryDirect element
                |> Option.map (fun expression ->
                    expression :> Expr
                )
            )
        |> Option.map (fun elementExpressions ->

            Expr.NewArray(
                typeof<'Element>,
                elementExpressions
            )
            |> Expr.Cast<'Element array>
        )

    // -------------------------------------------------------------------------
    // HList
    //
    // Some Expr list means:
    //     every heterogeneous field could be reconstructed exactly.
    //
    // None means:
    //     at least one field requires projection, so anything containing this
    //     HList cannot itself be a DirectQuote.
    // -------------------------------------------------------------------------

    static member private ofHeterogenousList<'Fields>
        (fieldValues : 'Fields HList)
        : Expr list option
        =

        let folder =
            {
                new HListFolder<Expr list option> with

                    member _.Folder<'FieldType>
                        (expressions : Expr list option)
                        (fieldValue : 'FieldType)
                        =

                        match expressions with
                        | None ->
                            None

                        | Some expressions ->

                            match
                                CodeQuotation<'FieldType>.tryDirect
                                    fieldValue
                            with
                            | Some fieldExpression ->
                                Some (
                                    (fieldExpression :> Expr)
                                    :: expressions
                                )

                            | None ->
                                None
            }

        fieldValues
        |> HList.fold folder (Some [])
        |> Option.map List.rev

    // -------------------------------------------------------------------------
    // Union case arguments
    // -------------------------------------------------------------------------

    static member private unionCaseArguments<'Payload>
        (caseInfo : UnionCaseInfo)
        (payload : 'Payload)
        : Expr list option
        =

        let fields =
            caseInfo.GetFields()

        match fields.Length with

        // ShapeSifter represents a zero-field union case with unit,
        // but Expr.NewUnionCase needs no argument expressions.
        | 0 ->
            Some []

        // ShapeSifter represents a one-field union case directly by the
        // field's type.
        | 1 ->

            CodeQuotation<'Payload>.tryDirect payload
            |> Option.map (fun expression ->
                [
                    expression :> Expr
                ]
            )

        // ShapeSifter represents multiple union-case fields as a tuple.
        // Break that tuple back into its individual field expressions.
        | _ ->

            match tType<'Payload> with

            | Tuple tuple ->

                {
                    new TupleConvEvaluator< 'Payload, Expr list option > with

                        member _.Eval<'UnionCaseFields>
                            (
                                _fieldTypes :
                                    TypeList<'UnionCaseFields>
                            )
                            (
                                conversion :
                                    Conv<
                                        'Payload,
                                        'UnionCaseFields HList
                                    >
                            )
                            =

                            let fieldValues :
                                'UnionCaseFields HList
                                =
                                conversion.To payload

                            CodeQuotation<'Payload>
                                .ofHeterogenousList
                                    fieldValues
                }
                |> tuple.Apply

            | _ ->

                invalidOp
                    $"Expected the payload of union case {caseInfo.Name} to be a tuple."

    // -------------------------------------------------------------------------
    // HUnion
    // -------------------------------------------------------------------------

    static member private ofHeterogenousUnion<'Cases>
        (caseIndex : int)
        (caseData : UnionTypeField list)
        (unionValue : 'Cases HUnion)
        : Expr option
        =

        match
            unionValue
            |> HUnion.toTypeList
            |> TypeList.split
        with

        | Choice1Of2 _ ->

            invalidOp
                "A discriminated union cannot have zero cases."

        | Choice2Of2 cons ->

            {
                new TypeListConsEvaluator< 'Cases, Expr option > with

                    member _.Eval<'Payload, 'Tail>
                        (
                            _tailTypes :
                                'Tail TypeList
                        )
                        (
                            typeEquality :
                                Teq<
                                    'Cases,
                                    'Payload -> 'Tail
                                >
                        )
                        =

                        let expandedUnion :
                            ('Payload -> 'Tail) HUnion
                            =
                            unionValue
                            |> Teq.castTo
                                (
                                    HUnion.cong
                                        typeEquality
                                )

                        match HUnion.split expandedUnion with

                        | Choice1Of2 payload ->

                            let caseInfo =
                                caseData
                                |> List.item caseIndex
                                |> fun case ->
                                    case.RawCase

                            CodeQuotation<'ValueType>
                                .unionCaseArguments
                                    caseInfo
                                    payload
                            |> Option.map
                                (fun arguments ->

                                    Expr.NewUnionCase(
                                        caseInfo,
                                        arguments
                                    )
                                )

                        | Choice2Of2 tail ->

                            CodeQuotation<'ValueType>
                                .ofHeterogenousUnion
                                    (caseIndex + 1)
                                    caseData
                                    tail
            }
            |> cons.Apply

    // -------------------------------------------------------------------------
    // Direct quotation
    //
    // This contains the existing ShapeSifter quotation machinery.
    //
    // Crucially:
    //
    //     Some Expr<'ValueType>
    //
    // means the exact nominal type could be reconstructed.
    //
    //     None
    //
    // means exact reconstruction is impossible somewhere in this value's
    // structure and the public operation must return IndirectQuote.
    // -------------------------------------------------------------------------

    static member private tryDirect
        (value : 'ValueType)
        : Expr<'ValueType> option
        =

        let tTldRule =
            tType<TldRule>

        let tMimeType =
            tType<MimeType>

        let expression : Expr option =

            match tType<'ValueType> with

            // -----------------------------------------------------------------
            // Explicit external-type reconstruction
            // -----------------------------------------------------------------

            | Teq tMimeType typeEquality ->

                let mimeType : MimeType =
                    value
                    |> Teq.castTo typeEquality

                match
                    CodeQuotation<string>.tryDirect
                        (mimeType.ToString())
                with

                | Some mimeTypeStringExpression ->

                    <@
                        MimeType.Parse
                            %mimeTypeStringExpression
                    @>
                    :> Expr
                    |> Some

                | None ->
                    None

            | Teq tTldRule typeEquality ->

                let rule : TldRule =
                    value
                    |> Teq.castTo typeEquality

                let ruleData =
                    match rule.Type with

                    | TldRuleType.WildcardException ->
                        "!" + rule.Name

                    | _ ->
                        rule.Name

                match
                    CodeQuotation<string>
                        .tryDirect
                            ruleData,
                    CodeQuotation<TldRuleDivision>
                        .tryDirect
                            rule.Division
                with

                | Some ruleDataExpression,
                  Some divisionExpression ->

                    <@
                        TldRule(
                            %ruleDataExpression,
                            %divisionExpression
                        )
                    @>
                    :> Expr
                    |> Some

                | _ ->
                    None

            // -----------------------------------------------------------------
            // CLR enums
            // -----------------------------------------------------------------

            | EnumUnion ->

                Expr.Value(
                    box value,
                    typeof<'ValueType>
                )
                |> Some

            // -----------------------------------------------------------------
            // Primitive/direct values
            // -----------------------------------------------------------------

            | Bool typeEquality ->

                value
                |> Teq.castTo typeEquality
                |> Expr.Value
                |> Some

            | Int typeEquality ->

                value
                |> Teq.castTo typeEquality
                |> Expr.Value
                |> Some

            | Int64 typeEquality ->

                value
                |> Teq.castTo typeEquality
                |> Expr.Value
                |> Some

            | Float typeEquality ->

                value
                |> Teq.castTo typeEquality
                |> Expr.Value
                |> Some

            | String typeEquality ->

                value
                |> Teq.castTo typeEquality
                |> Expr.Value
                |> Some

            | Unit typeEquality ->

                value
                |> Teq.castTo typeEquality
                |> Expr.Value
                |> Some

            | DateTime typeEquality ->

                value
                |> Teq.castTo typeEquality
                |> Expr.Value
                |> Some

            | TimeSpan typeEquality ->

                value
                |> Teq.castTo typeEquality
                |> Expr.Value
                |> Some

            // -----------------------------------------------------------------
            // Array
            // -----------------------------------------------------------------

            | ShapeSifter.Patterns.Array array ->

                {
                    new ArrayTeqEvaluator< 'ValueType, Expr option > with

                        member _.Eval<'Element>
                            (
                                typeEquality :
                                    Teq<
                                        'ValueType,
                                        'Element array
                                    >
                            )
                            =

                            let arrayValue :
                                'Element array
                                =
                                value
                                |> Teq.castTo
                                    typeEquality

                            CodeQuotation<'ValueType>
                                .ofHomogeneousElements
                                    arrayValue
                            |> Option.map
                                (fun expression ->
                                    expression :> Expr
                                )
                }
                |> array.Apply

            // -----------------------------------------------------------------
            // Seq
            //
            // A seq is materialized into an array expression and then coerced
            // back to seq<'Element>.
            // -----------------------------------------------------------------

            | Seq sequence ->

                {
                    new SeqTeqEvaluator< 'ValueType, Expr option > with

                        member _.Eval<'Element>
                            (
                                typeEquality :
                                    Teq<
                                        'ValueType,
                                        'Element seq
                                    >
                            )
                            =

                            let sequenceValue :
                                'Element seq
                                =
                                value
                                |> Teq.castTo
                                    typeEquality

                            CodeQuotation<'ValueType>
                                .ofHomogeneousElements
                                    sequenceValue
                            |> Option.map
                                (fun arrayExpression ->

                                    Expr.Coerce(
                                        arrayExpression,
                                        typeof<'Element seq>
                                    )
                                )
                }
                |> sequence.Apply

            // -----------------------------------------------------------------
            // ResizeArray
            // -----------------------------------------------------------------

            | ResizeArray resizeArray ->

                {
                    new ResizeArrayTeqEvaluator< 'ValueType, Expr option > with

                        member _.Eval<'Element>
                            (
                                typeEquality :
                                    Teq<
                                        'ValueType,
                                        'Element ResizeArray
                                    >
                            )
                            =

                            let resizeArrayValue :
                                'Element ResizeArray
                                =
                                value
                                |> Teq.castTo
                                    typeEquality

                            CodeQuotation<'ValueType>
                                .ofHomogeneousElements
                                    resizeArrayValue
                            |> Option.map
                                (fun arrayExpression ->

                                    let sequenceExpression :
                                        Expr
                                        =
                                        Expr.Coerce(
                                            arrayExpression,
                                            typeof<'Element seq>
                                        )

                                    let constructor =
                                        typeof< ResizeArray<'Element> > .GetConstructor(
                                                [|
                                                    typeof<
                                                        'Element seq
                                                    >
                                                |]
                                            )

                                    Expr.NewObject(
                                        constructor,
                                        [
                                            sequenceExpression
                                        ]
                                    )
                                )
                }
                |> resizeArray.Apply

            // -----------------------------------------------------------------
            // Set
            // -----------------------------------------------------------------

            | Set set ->

                {
                    new SetTeqEvaluator< 'ValueType, Expr option > with

                        member _.Eval<
                            'Element
                                when 'Element : comparison
                        >
                            (
                                typeEquality :
                                    Teq<
                                        'ValueType,
                                        'Element Set
                                    >
                            )
                            =

                            let setValue :
                                'Element Set
                                =
                                value
                                |> Teq.castTo
                                    typeEquality

                            CodeQuotation<'ValueType>
                                .ofHomogeneousElements
                                    setValue
                            |> Option.map
                                (fun arrayExpression ->

                                    let sequenceExpression :
                                        Expr
                                        =
                                        Expr.Coerce(
                                            arrayExpression,
                                            typeof<'Element seq>
                                        )

                                    let constructor =
                                        typeof< Set<'Element> >
                                            .GetConstructor(
                                                [|
                                                    typeof<
                                                        'Element seq
                                                    >
                                                |]
                                            )

                                    Expr.NewObject(
                                        constructor,
                                        [
                                            sequenceExpression
                                        ]
                                    )
                                )
                }
                |> set.Apply

            // -----------------------------------------------------------------
            // Map
            // -----------------------------------------------------------------

            | Map map ->

                {
                    new MapTeqEvaluator< 'ValueType, Expr option > with

                        member _.Eval<
                            'Key,
                            'Value
                                when 'Key : comparison
                        >
                            (
                                typeEquality :
                                    Teq<
                                        'ValueType,
                                        Map<'Key, 'Value>
                                    >
                            )
                            =

                            let mapValue :
                                Map<'Key, 'Value>
                                =
                                value
                                |> Teq.castTo
                                    typeEquality

                            let pairExpressions =
                                CodeQuotation<'ValueType>
                                    .traverse
                                        mapValue
                                        (fun pair ->

                                            match
                                                CodeQuotation<'Key>
                                                    .tryDirect
                                                        pair.Key,
                                                CodeQuotation<'Value>
                                                    .tryDirect
                                                        pair.Value
                                            with

                                            | Some keyExpression,
                                              Some valueExpression ->

                                                Expr.NewTuple(
                                                    [
                                                        keyExpression
                                                        :> Expr

                                                        valueExpression
                                                        :> Expr
                                                    ]
                                                )
                                                |> Some

                                            | _ ->
                                                None
                                        )

                            pairExpressions
                            |> Option.map
                                (fun pairExpressions ->

                                    let pairType =
                                        typeof<
                                            'Key * 'Value
                                        >

                                    let arrayExpression =
                                        Expr.NewArray(
                                            pairType,
                                            pairExpressions
                                        )

                                    let sequenceExpression =
                                        Expr.Coerce(
                                            arrayExpression,
                                            typeof<
                                                seq<'Key * 'Value>
                                            >
                                        )

                                    let constructor =
                                        typeof< Map<'Key, 'Value> >
                                            .GetConstructor(
                                                [|
                                                    typeof< seq< 'Key * 'Value > >
                                                |]
                                            )

                                    Expr.NewObject(
                                        constructor,
                                        [
                                            sequenceExpression
                                        ]
                                    )
                                )
                }
                |> map.Apply

            // -----------------------------------------------------------------
            // Dictionary
            // -----------------------------------------------------------------

            | Dictionary dictionary ->

                {
                    new DictionaryTeqEvaluator< 'ValueType, Expr option > with

                        member _.Eval<'Key, 'Value>
                            (
                                typeEquality :
                                    Teq<
                                        'ValueType,
                                        Dictionary< 'Key, 'Value > 
                                        >
                            )
                            =

                            let dictionaryValue :
                                Dictionary<'Key, 'Value>
                                =
                                value
                                |> Teq.castTo
                                    typeEquality

                            if
                                not (
                                    obj.ReferenceEquals(
                                        dictionaryValue.Comparer,
                                        EqualityComparer< 'Key >.Default
                                    )
                                )
                            then

                                invalidOp
                                    $"CodeQuotation of Dictionary<{typeof<'Key>.FullName}, {typeof<'Value>.FullName}> with a custom comparer is not yet supported."

                            let keyValuePairConstructor =
                                typeof< KeyValuePair< 'Key, 'Value > >
                                    .GetConstructor(
                                        [|
                                            typeof<'Key>
                                            typeof<'Value>
                                        |]
                                    )

                            let pairExpressions =
                                CodeQuotation<'ValueType>
                                    .traverse
                                        dictionaryValue
                                        (fun pair ->

                                            match
                                                CodeQuotation<'Key>
                                                    .tryDirect
                                                        pair.Key,
                                                CodeQuotation<'Value>
                                                    .tryDirect
                                                        pair.Value
                                            with

                                            | Some keyExpression,
                                              Some valueExpression ->

                                                Expr.NewObject(
                                                    keyValuePairConstructor,
                                                    [
                                                        keyExpression
                                                        :> Expr

                                                        valueExpression
                                                        :> Expr
                                                    ]
                                                )
                                                |> Some

                                            | _ ->
                                                None
                                        )

                            pairExpressions
                            |> Option.map
                                (fun pairExpressions ->

                                    let pairType =
                                        typeof< KeyValuePair< 'Key, 'Value > >

                                    let arrayExpression =
                                        Expr.NewArray(
                                            pairType,
                                            pairExpressions
                                        )

                                    let sequenceType =
                                        typeof< seq< KeyValuePair< 'Key, 'Value > > >

                                    let sequenceExpression =
                                        Expr.Coerce(
                                            arrayExpression,
                                            sequenceType
                                        )

                                    let constructor =
                                        typeof< Dictionary< 'Key, 'Value > >
                                            .GetConstructor(
                                                [|
                                                    sequenceType
                                                |]
                                            )

                                    Expr.NewObject(
                                        constructor,
                                        [
                                            sequenceExpression
                                        ]
                                    )
                                )
                }
                |> dictionary.Apply

            // -----------------------------------------------------------------
            // Fun
            //
            // Deliberately excluded for now.
            // -----------------------------------------------------------------

            // | Fun functionShape ->
            //     ...

            // -----------------------------------------------------------------
            // Tuple
            // -----------------------------------------------------------------

            | Tuple tuple ->

                {
                    new TupleConvEvaluator< 'ValueType, Expr option > with

                        member _.Eval<'TupleFields>
                            (
                                _fieldTypes :
                                    TypeList<'TupleFields>
                            )
                            (
                                conversion :
                                    Conv<
                                        'ValueType,
                                        'TupleFields HList
                                    >
                            )
                            =

                            let fieldValues :
                                'TupleFields HList
                                =
                                conversion.To value

                            CodeQuotation<'ValueType>
                                .ofHeterogenousList
                                    fieldValues
                            |> Option.map
                                Expr.NewTuple
                }
                |> tuple.Apply

            // -----------------------------------------------------------------
            // Record
            // -----------------------------------------------------------------

            | Record record ->

                {
                    new RecordConvEvaluator< 'ValueType, Expr option > with

                        member _.Eval<'RecordFields>
                            (
                                _fieldData :
                                    RecordTypeField list
                            )
                            (
                                _fieldTypes :
                                    TypeList<'RecordFields>
                            )
                            (
                                conversion :
                                    Conv<
                                        'ValueType,
                                        'RecordFields HList
                                    >
                            )
                            =

                            let fieldValues :
                                'RecordFields HList
                                =
                                conversion.To value

                            CodeQuotation<'ValueType>
                                .ofHeterogenousList
                                    fieldValues
                            |> Option.map
                                (fun fieldExpressions ->

                                    Expr.NewRecord(
                                        typeof<'ValueType>,
                                        fieldExpressions
                                    )
                                )
                }
                |> record.Apply

            // -----------------------------------------------------------------
            // Union
            //
            // This also accounts for Option, Choice and List.
            // -----------------------------------------------------------------

            | Union union ->

                {
                    new UnionConvEvaluator< 'ValueType, Expr option > with

                        member _.Eval<'Cases>
                            (
                                caseData :
                                    UnionTypeField list
                            )
                            (
                                _caseTypes :
                                    TypeList<'Cases>
                            )
                            (
                                conversion :
                                    Conv<
                                        'ValueType,
                                        'Cases HUnion
                                    >
                            )
                            =

                            let unionValue :
                                'Cases HUnion
                                =
                                conversion.To value

                            CodeQuotation<'ValueType>
                                .ofHeterogenousUnion
                                    0
                                    caseData
                                    unionValue
                }
                |> union.Apply

            // -----------------------------------------------------------------
            // Exact quotation unavailable.
            //
            // This is no longer an exception.
            // It propagates outward until CodeQuotation.ofValue turns it into
            // IndirectQuote.
            // -----------------------------------------------------------------

            | _ ->
                None

        expression
        |> Option.map
            (fun expression ->
                Expr.Cast<'ValueType>
                    expression
            )

    // -------------------------------------------------------------------------
    // Public quotation operation
    // -------------------------------------------------------------------------

    static member ofValue
        (value : 'ValueType)
        : CodeQuotation<'ValueType>
        =

        match
            CodeQuotation<'ValueType>
                .tryDirect value
        with

        | Some expression ->

            DirectQuote expression

        | None ->

            value
            |> Projection<'ValueType>.ofValue
            |> IndirectQuote

// -----------------------------------------------------------------------------
// Ergonomic operations
// -----------------------------------------------------------------------------

[<RequireQualifiedAccess>]
module CodeQuotation =

    let inline lower
        (expression : Expr<'ValueType>)
        : 'ValueType
        =

        LeafExpressionConverter
            .EvaluateQuotation(
                expression
            )
        :?> 'ValueType

    let lowerUntyped
        (expression : Expr)
        : obj
        =

        LeafExpressionConverter
            .EvaluateQuotation(
                expression
            )

type JavascriptBuilder() =

    let propertyName (propertyInfo: PropertyInfo) =
        propertyInfo.GetCustomAttributes(typeof<DomNameAttribute>, true)
        |> Seq.tryPick (function
            | :? DomNameAttribute as attribute ->
                Some attribute.OfficialName
            | _ ->
                None
        )
        |> Option.defaultValue propertyInfo.Name

    let rec  expression
        (variables: Map<Var, JavaScript.Syntax.Id>)
        (quotation: Expr)
        : JavaScript.Syntax.Expression =

        match quotation with

        // fun element -> ...
        | Lambda(variable, body) ->

            let identifier =
                JavaScript.Syntax.Id.New variable.Name

            let variables =
                variables.Add(variable, identifier)

            let body =
                expression variables body

            JavaScript.Syntax.Lambda(
                None,
                [ identifier ],
                [
                    JavaScript.Syntax.Return(
                        Some body
                    )
                ],
                true
            )

        // element
        | Var variable ->

            match variables.TryFind variable with
            | Some identifier ->
                JavaScript.Syntax.Var identifier

            | None ->
                failwith $"Unknown variable: {variable.Name}"

        // element.OuterHtml
        | PropertyGet(Some target, propertyInfo, []) ->

            let target =
                expression variables target

            let name =
                propertyName propertyInfo

            JavaScript.Syntax.Binary(
                target,
                JavaScript.Syntax.BinaryOperator.``.``,
                JavaScript.Syntax.Constant(
                    JavaScript.Syntax.Literal.String name
                )
            )

        // "hello"
        | Value(:? string as value, _) ->

            JavaScript.Syntax.Constant(
                JavaScript.Syntax.Literal.String value
            )

        // true / false
        | Value(:? bool as value, _) ->
                JavaScript.Syntax.Constant(
                    if value then
                        JavaScript.Syntax.Literal.True 
                    else
                        JavaScript.Syntax.Literal.False
                )
         
        // null
        | Value(null, _) ->

            JavaScript.Syntax.Constant(
                JavaScript.Syntax.Literal.Null
            )

        | unsupported ->
            failwith
                $"""Unsupported F# quotation: {unsupported}"""

    let  compileQuotation (quotation: Expr) =

        let quotation =
            match quotation with

            // javascript { return expression }
            //
            // The quoted computation expression contains the
            // generated call to JavascriptBuilder.Return.
            | Call(_, methodInfo, [ value ])
                when methodInfo.Name = "Return" ->
                    value

            | expression ->
                expression

        quotation
        |> expression Map.empty
        |> JavaScript.Writer.ExpressionToString
            JavaScript.Preferences.Readable
    member _.Return(value: 'T) : 'T =
        value

    member _.Quote(expression: Expr<'T>) =
        expression

    member _.Run(expression: Expr<'T>)  =
        {
            javascriptString = compileQuotation expression
        }

let javascript = JavascriptBuilder()

let javascriptLiteral = 
    javascript {
        return fun (element: IElement) ->
            element.OuterHtml
    }

let CommandPrompt = Fli.Domain.Shells.CMD
let WindowsPowershell = Fli.Domain.Shells.PS
let PowershellCore = Fli.Domain.Shells.PWSH
type SeleniumKey = 
    | Add
    | Alt
    | ArrowDown
    | ArrowLeft
    | ArrowRight
    | ArrowUp
    | Backspace
    | Cancel
    | Clear
    | Command
    | Control
    | Decimal
    | Delete
    | Divide
    | Down
    | End
    | Enter
    | Equal
    | Escape
    | F1
    | F10
    | F11
    | F12
    | F2
    | F3
    | F4
    | F5
    | F6
    | F7
    | F8
    | F9
    | Help
    | Home
    | Insert
    | Left
    | LeftAlt
    | LeftControl
    | LeftShift
    | Meta
    | Multiply
    | Null
    | NumberPad0
    | NumberPad1
    | NumberPad2
    | NumberPad3
    | NumberPad4
    | NumberPad5
    | NumberPad6
    | NumberPad7
    | NumberPad8
    | NumberPad9
    | PageDown
    | PageUp
    | Pause
    | Return
    | Right
    | Semicolon
    | Separator
    | Shift
    | Space
    | Subtract
    | Tab
    | Up
    | ZenkakuHankaku
    static member op_Implicit (key:SeleniumKey) = 
        match key with 
        
        | Add -> OpenQA.Selenium.Keys.Add
        | Alt -> OpenQA.Selenium.Keys.Alt
        | ArrowDown -> OpenQA.Selenium.Keys.ArrowDown
        | ArrowLeft -> OpenQA.Selenium.Keys.ArrowLeft
        | ArrowRight -> OpenQA.Selenium.Keys.ArrowRight
        | ArrowUp -> OpenQA.Selenium.Keys.ArrowUp
        | Backspace -> OpenQA.Selenium.Keys.Backspace
        | Cancel -> OpenQA.Selenium.Keys.Cancel
        | Clear -> OpenQA.Selenium.Keys.Clear
        | Command -> OpenQA.Selenium.Keys.Command
        | Control -> OpenQA.Selenium.Keys.Control
        | Decimal -> OpenQA.Selenium.Keys.Decimal
        | Delete -> OpenQA.Selenium.Keys.Delete
        | Divide -> OpenQA.Selenium.Keys.Divide
        | Down -> OpenQA.Selenium.Keys.Down
        | End -> OpenQA.Selenium.Keys.End
        | Enter -> OpenQA.Selenium.Keys.Enter
        | Equal -> OpenQA.Selenium.Keys.Equal
        | Escape -> OpenQA.Selenium.Keys.Escape
        | F1 -> OpenQA.Selenium.Keys.F1
        | F10 -> OpenQA.Selenium.Keys.F10
        | F11 -> OpenQA.Selenium.Keys.F11
        | F12 -> OpenQA.Selenium.Keys.F12
        | F2 -> OpenQA.Selenium.Keys.F2
        | F3 -> OpenQA.Selenium.Keys.F3
        | F4 -> OpenQA.Selenium.Keys.F4
        | F5 -> OpenQA.Selenium.Keys.F5
        | F6 -> OpenQA.Selenium.Keys.F6
        | F7 -> OpenQA.Selenium.Keys.F7
        | F8 -> OpenQA.Selenium.Keys.F8
        | F9 -> OpenQA.Selenium.Keys.F9
        | Help -> OpenQA.Selenium.Keys.Help
        | Home -> OpenQA.Selenium.Keys.Home
        | Insert -> OpenQA.Selenium.Keys.Insert
        | Left -> OpenQA.Selenium.Keys.Left
        | LeftAlt -> OpenQA.Selenium.Keys.LeftAlt
        | LeftControl -> OpenQA.Selenium.Keys.LeftControl
        | LeftShift -> OpenQA.Selenium.Keys.LeftShift
        | Meta -> OpenQA.Selenium.Keys.Meta
        | Multiply -> OpenQA.Selenium.Keys.Multiply
        | Null -> OpenQA.Selenium.Keys.Null
        | NumberPad0 -> OpenQA.Selenium.Keys.NumberPad0
        | NumberPad1 -> OpenQA.Selenium.Keys.NumberPad1
        | NumberPad2 -> OpenQA.Selenium.Keys.NumberPad2
        | NumberPad3 -> OpenQA.Selenium.Keys.NumberPad3
        | NumberPad4 -> OpenQA.Selenium.Keys.NumberPad4
        | NumberPad5 -> OpenQA.Selenium.Keys.NumberPad5
        | NumberPad6 -> OpenQA.Selenium.Keys.NumberPad6
        | NumberPad7 -> OpenQA.Selenium.Keys.NumberPad7
        | NumberPad8 -> OpenQA.Selenium.Keys.NumberPad8
        | NumberPad9 -> OpenQA.Selenium.Keys.NumberPad9
        | PageDown -> OpenQA.Selenium.Keys.PageDown
        | PageUp -> OpenQA.Selenium.Keys.PageUp
        | Pause -> OpenQA.Selenium.Keys.Pause
        | Return -> OpenQA.Selenium.Keys.Return
        | Right -> OpenQA.Selenium.Keys.Right
        | Semicolon -> OpenQA.Selenium.Keys.Semicolon
        | Separator -> OpenQA.Selenium.Keys.Separator
        | Shift -> OpenQA.Selenium.Keys.Shift
        | Space -> OpenQA.Selenium.Keys.Space
        | Subtract -> OpenQA.Selenium.Keys.Subtract
        | Tab -> OpenQA.Selenium.Keys.Tab
        | Up -> OpenQA.Selenium.Keys.Up
        | ZenkakuHankaku -> OpenQA.Selenium.Keys.ZenkakuHankaku
        member this.press = canopy.classic.press this

type EdgeBrowser = 
    {
        browserStart:Async<Output>
        driverStart:Async<Output>
        cancellationTokenSource:CancellationTokenSource
        driver:RemoteWebDriver
        browser:CdpBrowser
    }
    static member op_Implicit(edge:EdgeBrowser) = edge.driver
    static member op_Implicit(edge:EdgeBrowser) : IWebDriver = edge.driver :> IWebDriver
    static member op_Implicit(edge:EdgeBrowser) = edge.browser
    static member exeFile = FileInfo $"C:\Program Files (x86)\Microsoft\Edge\Application\msedge.exe" 
    static member driverFile = FileInfo $"D:\Program_Files\Microsoft\Edge\Version156.0.4314.42\msedgedriver.exe"
    static member dataDirectory = DirectoryInfo $"D:\Program_Files\Microsoft\Edge\data_dir"
    static member startBrowserCommand = $"& '{EdgeBrowser.exeFile.FullName}' --remote-debugging-port=9222 --user-data-dir={EdgeBrowser.dataDirectory.FullName}"
    static member startDriverCommand = $"& '{EdgeBrowser.driverFile.FullName}' --port=9515"
    static member webDriver = 
            let edgeOptions = EdgeOptions()
            edgeOptions.DebuggerAddress <- "127.0.0.1:9222"
            new RemoteWebDriver(Uri("http://127.0.0.1:9515"), edgeOptions)

    static member Start() =
            let cancellationTokenSource = new CancellationTokenSource()
            let startBrowser = 
                                    Command.executeAsync(
                                        cli {
                                        Shell PowershellCore
                                        Command "edge"
                                        },
                                        cancellationTokenSource.Token
                                    )
            let startDriver = 
                                    Command.executeAsync(
                                        cli {
                                        Shell PowershellCore
                                        Command "edgeDriver"
                                        },
                                        cancellationTokenSource.Token
                                    )
            do Thread.Sleep 1000
            let driver = EdgeBrowser.webDriver
            driver.SwitchTo().Window(driver.CurrentWindowHandle) |> ignore
            canopy.classic.browser <- driver
            
            {
                        browserStart = startBrowser
                        driverStart = startDriver
                        cancellationTokenSource = cancellationTokenSource
                        driver = driver
                        browser = Puppeteer.ConnectAsync(ConnectOptions(BrowserURL = "http://127.0.0.1:9222")).GetAwaiter().GetResult() :?> CdpBrowser
            }
    member this.driverTab() =  this.driver.SwitchTo().Window(this.driver.CurrentWindowHandle)
    member this.driverTab (tabIndex:int) = 
        if tabIndex < 0 then  
            canopy.classic.closeTab (abs tabIndex)
        else
            canopy.classic.switchToTab tabIndex
    member this.driverIrl = canopy.classic.currentUrl () |> Url.Parse |> Irl.ofUrl
    member this.driverTitle = canopy.classic.title ()
    member this.reload() =  canopy.classic.reload()
    member this.navigate(navigation:canopy.parallell.functions.Navigate) = canopy.classic.navigate navigation
    member this.back = this.navigate canopy.parallell.functions.Navigate.Back
    member this.forward = this.navigate canopy.parallell.functions.Navigate.Forward
    member this.irl (irl:Irl) = canopy.classic.url irl
    
    member this.write (text:string) = 
        fun (selector:Selector) -> canopy.classic.(<<) selector.Css  text
    member this.read (selector:Selector) = canopy.classic.read selector.Css
    member this.drag (fromSelector:Selector) =
        fun (ontoSelector:Selector) -> canopy.classic.drag fromSelector.Css ontoSelector.Css this
    member this.click (text:string) = canopy.classic.click text
    member this.click (selector:Selector) = canopy.classic.click selector.Css
    member this.click (element:IWebElement) = canopy.classic.click element
    member this.rightClick (text:string) = canopy.classic.rightClick text
    member this.rightClick (selector:Selector) = canopy.classic.rightClick selector.Css
    member this.rightClick (element:IWebElement) = canopy.classic.rightClick element
    member this.doubleClick (text:string) = canopy.classic.doubleClick text
    member this.doubleClick (selector:Selector) = canopy.classic.doubleClick selector.Css
    member this.doubleClick (element:IWebElement) = canopy.classic.doubleClick element
    member this.ctrlClick (text:string) = canopy.classic.ctrlClick text
    member this.ctrlClick (selector:Selector) = canopy.classic.ctrlClick selector.Css
    member this.ctrlClick (element:IWebElement) = canopy.classic.ctrlClick element
    member this.shiftClick (text:string) = canopy.classic.shiftClick text
    member this.shiftClick (selector:Selector) = canopy.classic.shiftClick selector.Css
    member this.shiftClick (element:IWebElement) = canopy.classic.shiftClick element
    member this.screenshot (file:FileInfo) = canopy.classic.screenshot file.DirectoryName file.Name
    member this.check (text:string) = canopy.classic.check text
    member this.check (selector:Selector) = canopy.classic.check selector.Css
    member this.check (element:IWebElement) = canopy.classic.check element
    member this.uncheck (text:string) = canopy.classic.uncheck text
    member this.uncheck (selector:Selector) = canopy.classic.uncheck selector.Css
    member this.uncheck (element:IWebElement) = canopy.classic.uncheck element
    member this.hover (text:string) = canopy.classic.hover text
    member this.hover (selector:Selector) = canopy.classic.hover selector.Css
    member this.element (text:string) = canopy.classic.element text
    member this.element (selector:Selector) = canopy.classic.element selector.Css
    member this.elementWithText (text:string) (selector:Selector) = canopy.classic.elementWithText selector.Css text
    member this.someElement (text:string) = canopy.classic.someElement text
    member this.someElement (selector:Selector) = canopy.classic.someElement selector.Css
    member this.someElementWithin (text:string) = canopy.classic.someElementWithin text
    member this.someElementWithin (selector:Selector) = canopy.classic.someElementWithin selector.Css
    member this.parent (webElement:IWebElement) = canopy.classic.parent webElement
    member this.someParent (webElement:IWebElement) = canopy.classic.someParent webElement
    member this.elements (text:string) = canopy.classic.elements text
    member this.elements (selector:Selector) = canopy.classic.elements selector.Css
    member this.elementsWithin (text:string) = canopy.classic.elementsWithin text
    member this.elementsWithin (selector:Selector) = canopy.classic.elementsWithin selector.Css
    member this.elementsWithText (text:string) (selector:Selector) = canopy.classic.elementsWithText selector.Css text
    member this.nth (ordinal:int) = 
        fun (selector:Selector) -> canopy.classic.nth ordinal selector.Css
    member this.first (text:string) = canopy.classic.first text
    member this.first (selector:Selector) = canopy.classic.first selector.Css
    member this.last (text:string) = canopy.classic.last text
    member this.last (selector:Selector) = canopy.classic.last selector.Css
    member this.elementText (selector:Selector) = canopy.classic.fastTextFromCSS selector.Css
    member this.resize(x:int) = 
        fun (y:int) -> canopy.classic.resize(x, y)
    member this.rotate() = canopy.classic.rotate()
    member this.js (literal:JavascriptLiteral) = (this.driver :> IJavaScriptExecutor).ExecuteScript(literal.javascriptString ) 
    member this.sleep (seconds:int)= canopy.classic.sleep seconds
    member this.highlight (selector:Selector) = canopy.classic.highlight selector.Css
    member this.waitFor (predicate : unit -> bool) = canopy.classic.waitFor predicate
    member this.waitFor (explanation:string) =
        fun (predicate : unit -> bool) -> canopy.classic.waitFor2 explanation predicate
    member this.waitFor (selector:Selector) = canopy.classic.waitForElement selector.Css
    member this.clear (selector:Selector) = canopy.classic.clear selector.Css
    member this.press (key:SeleniumKey) = canopy.classic.press key 
    member this.alert = canopy.classic.alert()
    member this.acceptAlert = canopy.classic.acceptAlert()
    member this.dismissAlert = canopy.classic.dismissAlert()
    member this.pin (direction:types.direction) = canopy.classic.pin direction
    member this.positionBrowser (leftPercentage:int) = 
        fun (topPercentage:int) ->
            fun (widthPercentage:int) ->
                fun (heightPercentage:int) -> canopy.classic.positionBrowser leftPercentage topPercentage widthPercentage heightPercentage
    member this.css (selector:Selector) = canopy.classic.css selector.Css
    member this.xpath(xpath:XPathExpression) = canopy.classic.xpath xpath.Expression
    member this.jquery jquerySelector = canopy.classic.jquery jquerySelector
    member this.label (label:string) = canopy.classic.label label
    member this.text (text:string) = canopy.classic.text text
    member this.value = canopy.classic.value 
    member this.quitDriver() = 
        this.cancellationTokenSource.Cancel()
        canopy.classic.quit this.driver

type UriSchemes = Iana.RegistryProvider.``Uniform Resource Identifier (URI) Schemes``.``Uniform Resource Identifier (URI) Schemes``
type PublicSuffixes = PublicSuffixList.PublicSuffixProvider
type Mime = Iana.InternetMediaTypeProvider

type String with
    member this.com = PublicSuffixes.com.tld.domain this
    member this.org = PublicSuffixes.org.tld.domain this
    member this.gov = PublicSuffixes.gov.tld.domain this
    member this.net = PublicSuffixes.net.tld.domain this
type EdgeBrowser with 
    member this.https (domain:Domain) = UriSchemes.https.site domain |> this.irl
    member this.www (label:string) =
        fun (suffix:PublicSuffix) -> 
            {
                topLevelDomain = suffix
                secondLevelDomain = label
                subdomainLabels = [ "www" ] 
            }
            |> UriSchemes.https.site
            |> this.irl
    member this.www (domain:Domain) =
            { domain with 
                subdomainLabels = [ "www" ] 
            }
            |> UriSchemes.https.site
            |> this.irl

let rule =
    TldRule(
        "com",
        TldRuleDivision.Unknown
    )

let quotedRule = CodeQuotation.lift rule
let maybeRule = CodeQuotation.tryValue quotedRule
let quotedIriReference = IriReference "https://www.bing.com/" |> CodeQuotation.lift

let projectedIriReference = quotedIriReference.projected
projectedIriReference.tryPathExpression ["uri" ; "Authority"]
quotedIriReference
FSharpValue.GetTupleFields quotedIriReference.evaluated |> Array.item 1 |> FSharpValue.GetTupleFields |> Array.item 1 |> FSharpValue.GetTupleFields |> Array.item 1

let com = PublicSuffixes.com.tld
CodeQuotation.lift com
let google = "google".com

(*

let edge = EdgeBrowser.Start()
edge.driverTab
edge.https "google".com
edge.www "youtube" com

*)
"www" .+ "google".com
type FSharp.Data.HtmlDocument with 
    static member ofWebDriver (webDriver:RemoteWebDriver) = HtmlDocument.Parse webDriver.PageSource
type AngleSharp.Html.Dom.IHtmlDocument with 
    static member ofWebDriver (webDriver:RemoteWebDriver) = HtmlParser().ParseDocument(File.ReadAllText(webDriver.PageSource))
type EdgeBrowser with 
    member this.FSharpHtmlDocument = FSharp.Data.HtmlDocument.ofWebDriver this.driver
    member this.AngleSharpHtmlDocument = AngleSharp.Html.Dom.IHtmlDocument.ofWebDriver this.driver

Mime.application.json.mime.registryIri
let mimeDefinitions = 
    let definitions = new Definitions.ExhaustiveBuilder()
    definitions.UsageType <- Definitions.Licensing.UsageType.PersonalNonCommercial
    definitions.Build()
    |> Seq.toArray

type InternetMediaType with 
    member this.contentDefinitions = mimeDefinitions |> Array.filter (fun definition -> definition.File.MimeType.ToLowerInvariant() = this.contentType )
let mimeInspector = 
        let inspector = new ContentInspectorBuilder()
        inspector.Definitions <- mimeDefinitions
        inspector.Build()

let http = UriSchemes.http
let https = UriSchemes.https

let path =
    @"D:\https\com\github\eristocrates\ipa\fs\DoxAletheia\src\DoxAletheia.Runtime\bin\Release\net10.0\Newtonsoft.Json.dll"

https.host "youtube".com
"www" .+ "youtube".com

//(child :?> JProperty).Name
let schemaSite = https.site "schema".org 
let schemaVocabulary = RdfVocabulary.PREFIX("schemas", schemaSite.identity + "/") 
// schemaVocabulary.localTurtleReference.clip
let jsonldVocabulary = RdfVocabulary.PREFIX("jsonld", "http://www.w3.org/ns/json-ld#")
// jsonldVocabulary.localTurtleReference.clip

(*

let uriSchemes =
    Iana.``Uniform Resource Identifier (URI) Schemes``

type rdf = VocabularyProvider<"http://www.w3.org/1999/02/22-rdf-syntax-ns#", @"D:\http\org\w3\www\1999\02\22-rdf-syntax-ns&num;\text\turtle.ttl">
type xsd = VocabularyProvider<"http://www.w3.org/2001/XMLSchema#", @"D:\http\org\w3\www\2001\XMLSchema&num;\text\turtle.ttl">
type rdfs = VocabularyProvider<"http://www.w3.org/2000/01/rdf-schema#", @"D:\http\org\w3\www\2000\01\rdf-schema&num;\text\turtle.ttl">
type rdfa = VocabularyProvider<"http://www.w3.org/ns/rdfa#", @"D:\http\org\w3\www\ns\rdfa&num;\text\turtle.ttl">
type owl = VocabularyProvider<"http://www.w3.org/2002/07/owl#", @"D:\http\org\w3\www\2002\07\owl&num;\text\turtle.ttl">
type void_ = VocabularyProvider<"http://rdfs.org/ns/void#", @"D:\http\org\rdfs\ns\void&num;\text\turtle.ttl">
type skos = VocabularyProvider<"http://www.w3.org/2004/02/skos/core#", @"D:\http\org\w3\www\2004\02\skos\core&num;\text\turtle.ttl">
type foaf = VocabularyProvider<"http://xmlns.com/foaf/0.1/", @"D:\http\com\xmlns\foaf\0.1&sol;\text\turtle.ttl">
type schemas = VocabularyProvider<"https://schema.org/", @"D:\https\org\schema&sol;\text\turtle.ttl">
type skosxl = VocabularyProvider<"http://www.w3.org/2008/05/skos-xl#", @"D:\http\org\w3\www\2008\05\skos-xl&num;\text\turtle.ttl">
type dc = VocabularyProvider<"http://purl.org/dc/elements/1.1/", @"D:\http\org\purl\dc\elements\1.1&sol;\text\turtle.ttl">
type dcat = VocabularyProvider<"http://www.w3.org/ns/dcat#", @"D:\http\org\w3\www\ns\dcat&num;\text\turtle.ttl">
type dcterms = VocabularyProvider<"http://purl.org/dc/terms/", @"D:\http\org\purl\dc\terms&sol;\text\turtle.ttl">
type time = VocabularyProvider<"http://www.w3.org/2006/time#", @"D:\http\org\w3\www\2006\time&num;\text\turtle.ttl">
type org = VocabularyProvider<"http://www.w3.org/ns/org#", @"D:\http\org\w3\www\ns\org&num;\text\turtle.ttl">
type jsonld = VocabularyProvider<"http://www.w3.org/ns/json-ld#", @"D:\http\org\w3\www\ns\json-ld&num;\text\turtle.ttl">

module governmentjobs =
    let ApplicationsSystemsAnalystI = Iri.ref  "https://www.governmentjobs.com/careers/leoncountyfl/classspecs/1183950" |> foaf.NamedIndividual_.Document

module myfuelmaster =
    let https = Iri.ref "https://myfuelmaster.com/" |> foaf.NamedIndividual_.Document
    let desktop_support_technician = Iri.ref "https://myfuelmaster.com/job/desktop-support-technician-8" |>foaf.NamedIndividual_.Document

type RdfVocabulary with 
    static member ofRDFNamespace (rdfNamespace:RDFNamespace) = RdfVocabulary.PREFIX(rdfNamespace.NamespacePrefix, rdfNamespace.NamespaceUri.OriginalString)
    static member personal (namespacePrefix:string) = 
        RDFNamespaceRegister.ensurePrefix(namespacePrefix, $"https://eristocrates.dev/ontology/{namespacePrefix}/")
        |> RdfVocabulary.ofRDFNamespace
    static member ensurePrefix((namespacePrefix:string), (namespaceName:string)) = RDFNamespaceRegister.ensurePrefix(namespacePrefix, namespaceName) |> RdfVocabulary.ofRDFNamespace

module wellsfargo =
    let _namespace = RdfVocabulary.personal "wellsfargo"
    let everydayChecking = _namespace.curie "everydayChecking"
    let platinumCard = _namespace.curie "platinumCard"
    let installmentLoans = _namespace.curie "installmentLoans"
    let wellsFargoRewards = _namespace.curie "wellsFargoRewards"

    module checking =
        let everyday = Iri.ref "https://www.wellsfargo.com/checking/everyday"
module usaa =
    let _namespace = RdfVocabulary.personal "usaa"
    let checking = _namespace.curie "checking"
    let platinumVisa = _namespace.curie "platinumVisa"
    let usaaSavings = _namespace.curie "usaaSavings"

    module banking =

        let checking = Iri.ref "https://www.usaa.com/banking/checking"
        let savings = Iri.ref "https://www.usaa.com/banking/savings"
module crew =
    let checkingAccountDisclosure = Iri.ref "https://www.trycrew.com/pdfjs/web/viewer?file=%2Fdocs%2Fdeposit-agreement.pdf#h.g82ej3s9bgif"

module gov =
    module leoncountyfl =
        module cms =
            let OfficeofInformationTechnology = Iri.ref "https://cms.leoncountyfl.gov/Government/Departments/Information-and-Technology/Office-of-Information-Technology" |> foaf.NamedIndividual_.Document
module leinfo =
    let _namespace = RdfVocabulary.ensurePrefix ("lei", "http://lei.info/" )
    let _l1 = RdfVocabulary.ensurePrefix ("leiL1", "http://lei.info/voc/l1/" )
    let WellsFargoNationalBank = _namespace.curie "KB1H1DSPRFMYMCUFXT09"
    let USAAFederalSavingsBank = _namespace.curie "C5654JQHZUHN0772B561"
    let BangorSavingsBank = _namespace.curie "549300JEBULFT3BSU682"
module dbug =
    let _namespace = RdfVocabulary.personal "dbug"
    let testIndividual = _namespace.curie "testIndividual" |> NamedIndividualIri |> Individual
    let Bob = _namespace.curie "Bob" |> foaf.NamedIndividual_.Person
    let Alice = _namespace.curie "Alice" |> foaf.NamedIndividual_.Person

module commonplace =
    let _namespace = RdfVocabulary.personal "commonplace"
    let _ontology = OntologyBuilder _namespace.namespaceIri
    let eristocrates = _namespace.curie "eristocrates" |> foaf.NamedIndividual_.Person
    let syrislove = _namespace.curie "syrislove" |> foaf.NamedIndividual_.Person
    let WellsFargoEverydayChecking = _namespace.curie "WellsFargoEverydayChecking"
    let WellsFargoEverydayCheckingAccount = _namespace.curie "WellsFargoEverydayCheckingAccount"
    let WellsFargoEverydayCheckingAccountCurrentBalance = _namespace.curie "WellsFargoEverydayCheckingAccountCurrentBalance"
    let WellsFargoEverydayCheckingAccountAvailableBalance = _namespace.curie "WellsFargoEverydayCheckingAccountAvailableBalance"
    let USAAClassicChecking = _namespace.curie "USAAClassicChecking"
    let USAAClassicCheckingAccount = _namespace.curie "USAAClassicCheckingAccount"
    let USAAClassicCheckingAccountCurrentBalance = _namespace.curie "USAAClassicCheckingAccountCurrentBalance"
    let USAAClassicCheckingAccountAvailableBalance = _namespace.curie "USAAClassicCheckingAccountAvailableBalance"
    let USAAClassicSavings = _namespace.curie "USAAClassicSavings"
    let USAAClassicSavingsAccount = _namespace.curie "USAAClassicSavingsAccount"
    let USAAClassicSavingsAccountCurrentBalance = _namespace.curie "USAAClassicSavingsAccountCurrentBalance"
    let USAAClassicSavingsAccountAvailableBalance = _namespace.curie "USAAClassicSavingsAccountAvailableBalance"
    let CrewFinanceChecking = _namespace.curie "CrewFinanceChecking"
    let CrewFinanceCheckingAccount = _namespace.curie "CrewFinanceCheckingAccount"
    let CrewFinanceCheckingAccountCurrentBalance = _namespace.curie "CrewFinanceCheckingAccountCurrentBalance"
    let CrewFinanceCheckingAccountAvailableBalance = _namespace.curie "CrewFinanceCheckingAccountAvailableBalance"
    let hasCurrentBalance = _namespace.curie "hasCurrentBalance"
    let hasAvailableBalance = _namespace.curie "hasAvailableBalance"
    let CurrentBalance = _namespace.curie "CurrentBalance"
    let AvailableBalance = _namespace.curie "AvailableBalance"

let a = rdf.``type``

let inline (-//)
    (curSubject: ^Subject when ^Subject: (member asSubject: NormativeSubject))
    (predicateObjects: PredicateObject list)
    =
    predicateObjects
    |> List.map (fun predicateObject -> curSubject.asSubject --/ predicateObject)

let (.@) (lexicalForm: string) (languageTag: LanguageTag) =
    { lexicalForm = lexicalForm
      languageTag = languageTag
      baseDirection = None }

let (@@) (lexicalForm: string) (languageTag: LanguageTag, baseDirection: InitialTextDirection) =
    { lexicalForm = lexicalForm
      languageTag = languageTag
      baseDirection = Some baseDirection }

let foafDocumentTriples =
    [ governmentjobs.ApplicationsSystemsAnalystI.Iri
      gov.leoncountyfl.cms.OfficeofInformationTechnology.Iri
      myfuelmaster.desktop_support_technician.Iri
      myfuelmaster.https.Iri ]
    -+/ a /-> foaf.Document

let foafDocumentAssertions =
    foaf.Document.Class
    |> ClassAssertion
        [ governmentjobs.ApplicationsSystemsAnalystI.Individual
          gov.leoncountyfl.cms.OfficeofInformationTechnology.Individual
          myfuelmaster.desktop_support_technician.Individual
          myfuelmaster.https.Individual ]

let foafPersonTriples =
    [ commonplace.eristocrates.Iri; commonplace.syrislove.Iri ]
    -+/ a /-> foaf.Person

let foafPersonAssertions =
    foaf.Person.Class
    |> ClassAssertion [ commonplace.eristocrates.Individual; commonplace.syrislove.Individual ]

let eristocratesTriples =
    commonplace.eristocrates.Iri
    -// [ foaf.firstName /-> myFirstName
          foaf.familyName /-> myLastName
          foaf.lastName /-> myLastName
          foaf.surname /-> myLastName
          foaf.age /-> myBirthday.currentAge
          foaf.nick /-> myUsername
          foaf.knows /-> commonplace.syrislove
          // foaf.workInfoHomepage/-> governmentjobs.ApplicationsSystemsAnalystI
          // foaf.workplaceHomepage/-> gov.leoncountyfl.cms.OfficeofInformationTechnology
          ]

let eristocratesAssertions =
    List.concat
        [ commonplace.eristocrates.Facts
              [ foaf.firstName.Fact myFirstName
                foaf.familyName.Fact myLastName
                foaf.lastName.Fact myLastName
                foaf.surname.Fact myLastName
                foaf.age.Fact myBirthday.currentAge
                foaf.nick.Fact myUsername ]
          commonplace.eristocrates.Facts
              [ foaf.knows.Fact commonplace.syrislove
                // foaf.workInfoHomepage.Fact  governmentjobs.ApplicationsSystemsAnalystI
                // foaf.workplaceHomepage.Fact  gov.leoncountyfl.cms.OfficeofInformationTechnology
                ] ]

let syrisTriples =
    commonplace.syrislove.Iri
    -// [

          foaf.firstName /-> syrisFirstName
          foaf.familyName /-> syrisLastName
          foaf.lastName /-> syrisLastName
          foaf.surname /-> syrisLastName
          foaf.age /-> syrisBirthday.currentAge
          foaf.nick /-> syrisUsername
          foaf.knows /-> commonplace.eristocrates
          // foaf.workInfoHomepage/->myfuelmaster.desktop_support_technician
          // foaf.workplaceHomepage/->myfuelmaster.https
          ]

let syrisAssertions =

    List.concat
        [ commonplace.syrislove.Facts
              [ foaf.firstName.Fact syrisFirstName
                foaf.familyName.Fact syrisLastName
                foaf.lastName.Fact syrisLastName
                foaf.surname.Fact syrisLastName
                foaf.age.Fact syrisBirthday.currentAge
                foaf.nick.Fact syrisUsername ]
          commonplace.syrislove.Facts
              [ foaf.knows.Fact commonplace.eristocrates
                // foaf.workInfoHomepage.Fact  myfuelmaster.desktop_support_technician
                // foaf.workplaceHomepage.Fact  myfuelmaster.https
                ] ]

let ontology =
    OntologyBuilder commonplace._namespace.namespaceIri {

        // yield foafDocumentTriples
        yield foafPersonTriples
        yield eristocratesTriples
        yield syrisTriples
        // yield foafDocumentAssertions
        yield foafPersonAssertions
        yield eristocratesAssertions
        yield syrisAssertions
    }

let ntriples = NTriples.ntriplesDoc ontology

let rdfGraph = RDFGraph.ofNTriples ntriples

type RDFGraph with
    member this.ToTurtle(turtlePath: string) =
        this.ToFileAsync(RDFModelEnums.RDFFormats.Turtle, turtlePath)
        |> Async.AwaitTask
        |> Async.RunSynchronously

rdfGraph.ToTurtle "D:\https\com\github\eristocrates\ipa\scratch\scratch.ttl"

File.WriteAllText(
    "D:\https\com\github\eristocrates\ipa\scratch\scratch.owl",
    LitXml.ElementBuilder.writeToString (Owl.Xml.Ontology ontology)
)

let OWLOntology = OWLSharp.Ontology.OWLOntology.ofOntology ontology
OWLOntology.AssertionAxioms |> Seq.head :?> OWLSharp.Ontology.OWLClassAssertion |> _.IndividualExpression

// Attach to our existing Edge instance.

*)

