#time on

fsi.PrintLength <- 10
fsi.ShowDeclarationValues <- false
// fsi.ShowDeclarationValues <- true


#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\Ergonomics"
#load "CaseConverterErgonomics.fsx"
#load @"C:\Secret\InforSecrets.fsx"
#r "nuget: CaseConverter"
#r "nuget: Deedle"
#r "nuget: Esri.ArcGISRuntime, 300.0.0"
#r "nuget: Fabulous.AST"
#r "nuget: Fli"
#r "nuget: FSharp.Charting"
#r "nuget: FSharp.Collections.ParallelSeq"
#r "nuget: FSharp.Literals, 2.2.15"
#r "nuget: Humanizer.Core"
#r "nuget: SQLProvider.MsSql, 1.5.18"
#r "nuget: TextCopy"
#r "nuget: TypeShape"
#r "nuget: FSharp.Compiler.Service, 43.10.102"
open FSharp.Compiler
open TypeShape.Core
module FSharp_Literal = FSharp.Literals.Literal

open CaseConverter
open CaseConverterErgonomics
open Deedle
open Esri.ArcGISRuntime
open Esri.ArcGISRuntime.ArcGISServices
open Esri.ArcGISRuntime.Data
open Esri.ArcGISRuntime.Geometry
open Esri.ArcGISRuntime.Mapping
open Esri.ArcGISRuntime.Mapping.FeatureForms
open Esri.ArcGISRuntime.Mapping.Popups
open Esri.ArcGISRuntime.Portal
open Esri.ArcGISRuntime.Symbology
open Fabulous.AST
open Fantomas.Core
open Fli
open FSharp
open FSharp_Literal
open FSharp.Charting
open FSharp.Collections.ParallelSeq
open FSharp.Data.Sql
open FSharp.Data.Sql.MsSql
open Humanizer
open InforSecrets
open Microsoft.FSharp.Reflection
open System
open System.Collections
open System.IO
open System.Collections.Generic
open System.Globalization
open System.Reflection
open TextCopy

open System.Reflection
open System
open System.ComponentModel
open System.ComponentModel.Design.Serialization

let clipboard = new Clipboard()
let clip (text:string) = clipboard.SetText text

type InforProdSql = SqlDataProvider<ConnectionString=Prod.connection_string, IndividualsAmount=10000, UseOptionTypes=Common.NullableColumnType.OPTION>
let mapserver_uri = new Uri "https://interraster.leoncountyfl.gov/interraster/rest/services/MapServices/LCPW_OverlayStormwaterInfrastructure_D_WM/MapServer"
ArcGISRuntimeEnvironment.Initialize()
let MapServer = ArcGISMapImageLayer(mapserver_uri)
MapServer.LoadTablesAndLayersAsync()
    |> Async.AwaitTask
    |> Async.RunSynchronously







let excludedProperties = 
    set [
            "ArcGISMapImageLayer", "SublayerContents"
            "ArcGISMapImageLayer", "LayerInfos"
            "ArcGISMapImageLayer", "LoadStatus"
            "ArcGISMapImageLayer", "Renderer"

            "ArcGISMapImageSublayer", "SublayerContents"
            "ArcGISMapImageSublayer", "LoadStatus"
            "ArcGISMapImageSublayer", "LayerInfos"
            "ArcGISMapImageSublayer", "Renderer"
            "ArcGISMapImageSublayer", "LabelDefinitions"

            "ArcGISMapServiceLayerInfo", "DrawingInfo"
            "ArcGISMapServiceSublayerInfo", "DrawingInfo"

            "ServiceFeatureTable", "SublayerContent"
            "ServiceFeatureTable", "ContingentValuesDefinition"

            "FeatureSubtype", "PrototypeAttributes"
            "FeatureSubtype", "FieldOverrides"
            

            "Envelope", "Extent"
    ]


let depthPreservingTypes = 
    set [
        "Field"
        "Domain"
        "Geometry"
        "Attributes"
        "CodedValueDomain"
        "CodedValue"
        "LinearUnit"
        "AngularUnit"
        "ArcGISMapServiceInfo"
        "IdInfo"
        "ArcGISMapServiceSublayerInfo"
        "SpatialReference"
        "Envelope"
        "FeatureType"
        "FeatureSubtype"
        "MapServiceCapabilities"
        "FeatureServiceCapabilities"
        "OwnershipBasedAccessControlInfo"
        
    ]

let isEmptyEnumerable (value: 'ValueType) =
    match box value with
    | :? System.Collections.ICollection as collection ->
        collection.Count = 0

    | :? System.Collections.IEnumerable as enumerable ->
        let enumerator = enumerable.GetEnumerator()
        not (enumerator.MoveNext())

    | _ -> false


type AttributeType =
    | OIDAttribute of string
    | TextAttribute of string
    | GlobalIDAttribute of string
    | Int16Attribute of int16
    | Float64Attribute of double
    | DateAttribute of DateTime
    | Int32Attribute of int
    | UnknownAttribute of obj


type Feature with 
    static member Query = 
            let feature_query = QueryParameters()
            feature_query.WhereClause <- "1 = 1"
            feature_query.ReturnGeometry <- true
            feature_query
    
    member this.attributeSignature = 
        this.Attributes
        |> Seq.toArray
        |> Array.map (|KeyValue|)
        |> Array.filter (fun (key,objValue) -> objValue <> null )
        |> Array.filter (fun (key,objValue) -> not (String.IsNullOrWhiteSpace (string objValue)))
        |> Array.map (fun (key,objValue) ->  key)

type ServiceFeatureTable with
    member this.fields = this.Fields |> Seq.toArray
    member this.domain_fields = this.Fields |> Seq.filter (fun field -> field.Domain <> null) |> Seq.toArray
    member this.nondomain_fields = this.Fields |> Seq.filter (fun field -> field.Domain = null) |> Seq.toArray
    member this.aliased_fields = this.Fields |> Seq.filter (fun field -> field.Name <> field.Alias) |> Seq.toArray
    member this.features = 
        this.QueryFeaturesAsync(
            Feature.Query,
            QueryFeatureFields.LoadAll
        )
        |> Async.AwaitTask
        |> Async.RunSynchronously
        |> Seq.toArray
    member this.featuresByAttributeSignature = this.features |> Array.groupBy(fun feature -> feature.attributeSignature)

type ArcGISMapImageLayer with
    member this.sublayers = this.Sublayers |> Seq.map (fun layer -> layer :?> ArcGISMapImageSublayer) |> Seq.toArray
    member this.sublayer_infos = this.sublayers |> Array.map (fun layer -> layer.MapServiceSublayerInfo) 
    member this.ungrouped_layers = this.sublayers  |> Array.filter (fun layer -> layer.MapServiceSublayerInfo.SublayerType = ArcGISMapServiceSublayerType.FeatureLayer)
    member this.ungrouped_tables = this.ungrouped_layers |> Array.map (fun feature_layer -> feature_layer.Table)
    member this.ungrouped_fields = this.ungrouped_tables |> Array.collect (fun table -> table.Fields |> Seq.toArray)
    member this.ungrouped_layer_infos = this.ungrouped_layers |> Array.map (fun layer -> layer.MapServiceSublayerInfo) 
    member this.ungrouped_layer_infos_by_name (name:string) = this.ungrouped_layer_infos |> Array.filter (fun feature_layer_info -> feature_layer_info.ServiceLayerName = name)
    member this.ungrouped_layer_by_name (name:string) = this.ungrouped_layers |> Array.find (fun ungrouped_layer -> ungrouped_layer.Name = name)
    member this.group_layers = this.sublayers  |> Array.filter (fun layer -> layer.MapServiceSublayerInfo.SublayerType = ArcGISMapServiceSublayerType.GroupLayer)
    member this.group_layer_infos = this.group_layers |> Array.map (fun layer -> layer.MapServiceSublayerInfo) 
    member this.group_layer_infos_by_name (name:string) = this.group_layer_infos |> Array.filter (fun group_layer_info -> group_layer_info.ServiceLayerName = name)
    member this.group_layer_by_name (name:string) = this.group_layers |> Array.find (fun group_layer -> group_layer.Name = name)
    member this.drainage_network_layers = this.group_layers[0].Sublayers |> Seq.map (fun layer -> layer :?> ArcGISMapImageSublayer) |> Seq.toArray 
    member this.drainage_network_sublayer_ids = this.group_layers[0].Sublayers |> Seq.map (fun layer -> layer.Id ) |> Seq.toArray 
    member this.drainage_network_tables = this.drainage_network_layers |> Array.map (fun feature_layer -> feature_layer.Table)
    member this.drainage_network_fields = this.drainage_network_tables |> Array.collect (fun table -> table.Fields |> Seq.toArray)
    member this.drainage_network_layer_infos = this.drainage_network_layers |> Array.map (fun layer -> layer.MapServiceSublayerInfo) 
    member this.drainage_network_layer_infos_by_name (name:string) = this.drainage_network_layer_infos |> Array.filter (fun drainage_network_layer_info -> drainage_network_layer_info.ServiceLayerName = name)
    member this.nondrainage_network_layers = this.group_layers[1].Sublayers |> Seq.map (fun layer -> layer :?> ArcGISMapImageSublayer) |> Seq.toArray 
    member this.nondrainage_network_sublayer_ids = this.group_layers[1].Sublayers |> Seq.map (fun layer -> layer.Id ) |> Seq.toArray 
    member this.nondrainage_network_tables = this.nondrainage_network_layers |> Array.map (fun feature_layer -> feature_layer.Table)
    member this.nondrainage_network_fields = this.nondrainage_network_tables |> Array.collect (fun table -> table.Fields |> Seq.toArray)
    member this.nondrainage_network_layer_infos = this.nondrainage_network_layers |> Array.map (fun layer -> layer.MapServiceSublayerInfo) 
    member this.nondrainage_network_layer_infos_by_name (name:string) = this.nondrainage_network_layer_infos |> Array.filter (fun nondrainage_network_layer_info -> nondrainage_network_layer_info.ServiceLayerName = name)
    member this.feature_layers = 
        Array.concat [|
            this.ungrouped_layers
            this.drainage_network_layers
            this.nondrainage_network_layers
        |]
    member this.feature_layer_infos = 
        Array.concat [|
            this.ungrouped_layer_infos
            this.drainage_network_layer_infos
            this.nondrainage_network_layer_infos
        |]
    member this.feature_layer_infos_by_name (name:string) = this.feature_layer_infos |> Array.filter (fun feature_layer_info -> feature_layer_info.ServiceLayerName = name)
    member this.tables = 
        let tables = 
            Array.concat [|
                this.ungrouped_tables
                this.drainage_network_tables
                this.nondrainage_network_tables
            |]
        tables |> Array.iter (fun table -> table.FeatureRequestMode <- FeatureRequestMode.OnInteractionCache)
        tables
    member this.tables_by_name (name:string) = this.tables |> Array.filter (fun table -> table.LayerInfo.ServiceLayerName = name)
    member this.fields = 
        Array.concat [|
            this.ungrouped_fields
            this.drainage_network_fields
            this.nondrainage_network_fields
        |]
    member this.fields_by_table (table_name:string) = 
        let table = this.tables_by_name table_name  |> Array.exactlyOne 
        table.Fields |> Seq.toArray
    member this.fields_by_qualified_name (table_name:string)(field_name:string) = 
        let table = this.tables_by_name table_name  |> Array.exactlyOne 
        table.Fields |> Seq.find (fun field -> field.Name = field_name) 
    member this.features = this.tables |> Array.collect (fun table -> table.features)
    member this.featuresByAttributeSignature = this.features |> Array.groupBy(fun feature -> feature.attributeSignature)


type ArcGISMapImageSublayer with 
    member this.propertySignature =
        this.GetType().GetProperties()
        |> Array.filter (fun property ->
            property.GetMethod <> null
            && property.GetMethod.IsPublic
        )
        |> Array.choose (fun property ->

            let propertyValue =
                property.GetValue this

            match propertyValue with
            | null ->
                None

            | propertyValue
                when
                    propertyValue :? System.Collections.IEnumerable
                    && not (propertyValue :? string)
                    && isEmptyEnumerable propertyValue ->
                None

            | propertyValue
                when String.IsNullOrWhiteSpace(string propertyValue) ->
                None

            | _ ->
                Some property.Name
        )
        |> Array.sort
        |> Array.toList


type Binder = 
    | TypeBinder of identifier:string
    | CaseBinder of identifier:string
    | ModuleBinder of identifier:string
    | NamespaceBinder of identifier:string
    | VariableBinder of identifier:string
    member this.identifier = 
        match this with 
        | TypeBinder identifier -> identifier
        | CaseBinder identifier -> identifier
        | ModuleBinder identifier -> identifier
        | NamespaceBinder identifier -> identifier
        | VariableBinder identifier -> identifier
    static member BackTickExclusions = 
        [|
            '.'
            '+'
            '$'
            '&'
            '['
            ']'
            '/'
            '\\'
            '*'
            '\"'
            '`'
        |]
    static member IdentKeywords = 
        set [
            "abstract"
            "and"
            "as"
            "assert"
            "base"
            "begin"
            "class"
            "const"
            "default"
            "delegate"
            "do"
            "done"
            "downcast"
            "downto"
            "elif"
            "else"
            "end"
            "exception"
            "extern"
            "false"
            "finally"
            "fixed"
            "for"
            "fun"
            "function"
            "global"
            "if"
            "in"
            "inherit"
            "inline"
            "interface"
            "internal"
            "lazy"
            "let"
            "match"
            "member"
            "module"
            "mutable"
            "namespace"
            "new"
            "null"
            "of"
            "open"
            "or"
            "override"
            "private"
            "public"
            "rec"
            "return"
            "sig"
            "static"
            "struct"
            "then"
            "to"
            "true"
            "try"
            "type"
            "upcast"
            "use"
            "val"
            "void"
            "when"
            "while"
            "with"
            "yield"
            
        ]
    static member OCamlKeywords = 
            set [

              "asr"
              "land"
              "lor"
              "lsl"
              "lsr"
              "lxor"
              "mod"
              "sig"

               ]
    static member ReservedKeywords = 
    
        set [

              "break"
              "checked"
              "component"
              "const"
              "constraint"
              "continue"
              "event"
              "external"
              "include"
              "mixin"
              "parallel"
              "process"
              "protected"
              "pure"
              "sealed"
              "tailcall"
              "trait"
              "virtual"

               ]
    static member KeywordNames = Binder.IdentKeywords + Binder.OCamlKeywords + Binder.ReservedKeywords

    member this.Contains(character:char) = this.identifier.Contains(character)
    member this.isBackTickRestricted =
        match this with 
        | TypeBinder identifier -> true
        | CaseBinder identifier -> true
        | ModuleBinder identifier -> true
        | NamespaceBinder identifier -> true
        | VariableBinder identifier -> false
    static member NormalizeIdentifier (is_restricted:bool) (identifier: string)  =
        match identifier with
        | _ when identifier.Contains(' ') ->
            Converters.ReplaceWhitespace(identifier,  "_")
            |> Binder.NormalizeIdentifier is_restricted
        | _ when identifier.Contains('-') ->
            identifier.Replace("-", "_")
            |> Binder.NormalizeIdentifier is_restricted
        | _ when not (Syntax.PrettyNaming.IsIdentifierFirstCharacter identifier[0]) ->
            "_" + identifier |> Binder.NormalizeIdentifier is_restricted
        | _ when Binder.KeywordNames.Contains(identifier) -> identifier + "_" |> Binder.NormalizeIdentifier is_restricted
        | _ when Syntax.PrettyNaming.DoesIdentifierNeedBackticks identifier && is_restricted  ->
            let backtickableIdentifier = identifier.Replace(Binder.BackTickExclusions,"")
            Syntax.PrettyNaming.NormalizeIdentifierBackticks backtickableIdentifier |> Binder.NormalizeIdentifier is_restricted
        | _ when Syntax.PrettyNaming.DoesIdentifierNeedBackticks identifier   ->
            Syntax.PrettyNaming.NormalizeIdentifierBackticks identifier |> Binder.NormalizeIdentifier is_restricted
        | _ -> identifier
    member this.binding = Binder.NormalizeIdentifier this.isBackTickRestricted this.identifier




























let SomeUnit = Some() // avoid allocating all the time
let inline typeTest<'T> (s : TypeShape) =
    match s with
    | :? TypeShape<'T> -> SomeUnit
    | _ -> None

module Shape = 
    let (|BoolTest|_|) s = typeTest<bool> s
















let wouldEmitEmptyRecord<'ValueType>
    (pocoDepth: int)
    (maximumPocoDepth: int)
    =
    match shapeof<'ValueType> with
    | Shape.BigInt
    | Shape.Bool
    | Shape.Byte
    | Shape.Char
    | Shape.Decimal
    | Shape.Double
    | Shape.Guid
    | Shape.Int16
    | Shape.Int32
    | Shape.Int64
    | Shape.SByte
    | Shape.Single
    | Shape.String
    | Shape.UInt32
    | Shape.UInt64
    | Shape.Unit
    | Shape.Uri
    | Shape.Enum _
    | Shape.TimeSpan
    | Shape.Enumerable _ ->
        false

    | Shape.Poco _ ->
        pocoDepth + 1 >= maximumPocoDepth

    | _ -> false




let rec emitValue<'ValueType>  (pocoDepth: int)(maximumPocoDepth:int)(value: 'ValueType) : WidgetBuilder<SyntaxOak.Expr> =

    let boxedValue =
        box value

    if
        typeof<'ValueType> = typeof<obj>
        && not (isNull boxedValue)
    then
        TypeShape.FromValue boxedValue
        |> fun runtimeShape ->
            runtimeShape.Accept {
                new ITypeVisitor< WidgetBuilder<SyntaxOak.Expr> > with
                    member _.Visit<'RuntimeValueType>() =

                        let runtimeValue =
                            unbox<'RuntimeValueType> boxedValue

                        emitValue
                            pocoDepth
                            maximumPocoDepth
                            runtimeValue
            }
    else
        let projectValue (projection: 'Type -> WidgetBuilder<SyntaxOak.Expr>)
            =
            let project = unbox<'ValueType -> WidgetBuilder<SyntaxOak.Expr>> projection

            project value
        match shapeof<'ValueType> with
        // | Shape.Array -> 
        | Shape.BigInt ->
            projectValue(fun (value: bigint) ->
                stringify value
                |> Ast.ConstantExpr
            )
        | Shape.Bool ->
            projectValue(fun (value: bool) ->
                Ast.Bool(value)
                |> Ast.ConstantExpr
            )
        | Shape.Byte ->
            projectValue(fun (value: byte) ->
            stringify value
            |> Ast.ConstantExpr
            )
        // | Shape.ByteArray -> 
        | Shape.Char ->
            projectValue(fun (value: char) ->
                stringify value
                |> Ast.ConstantExpr
            )
        // | Shape.CliMutable -> 
        // | Shape.Collection -> 
        // | Shape.Comparison -> 
        | Shape.DateTime -> 
            projectValue(fun (value: DateTime) ->
                Ast.ConstantExpr($"DateTime.Parse \"{value.ToString()}\"")
            ) 
        | Shape.DateTimeOffset -> 
            projectValue(fun (value: DateTimeOffset) ->
                Ast.NewExpr(
                    Ast.LongIdent("DateTimeOffset"),
                    Ast.String(value.ToString())
                )
            ) 
        | Shape.Decimal ->
            projectValue(fun (value: decimal) ->
                Ast.Decimal(value)
                |> Ast.ConstantExpr
            )
        // | Shape.DefaultConstructor -> 
        // | Shape.Delegate -> 
        | Shape.Double ->
            projectValue(fun (value: float) ->
                match value with 
                | _ when Double.IsNaN value -> Ast.ConstantExpr("Double.NaN")
                | _ when Double.IsPositiveInfinity value -> Ast.ConstantExpr("Double.PositiveInfinity")
                | _ when Double.IsNegativeInfinity value -> Ast.ConstantExpr("Double.NegativeInfinity")
                | _ when Double.IsNaN value -> Ast.ConstantExpr("Double.NaN")
                | _ -> Ast.Float(value) |> Ast.ConstantExpr
            )
        // | Shape.Equality -> 
        // | Shape.FSharpFunc -> 
        // | Shape.FSharpList -> 
        // | Shape.FSharpMap -> 
        // | Shape.FSharpOption -> 
        // | Shape.FSharpRecord -> 
        // | Shape.FSharpRef -> 
        // | Shape.FSharpSet -> 
        // | Shape.FSharpUnion -> 
        // | Shape.FSharpUnit -> 
        | Shape.Guid ->
            projectValue(fun (value: Guid) ->
                Ast.NewExpr(
                    Ast.LongIdent("Guid"),
                    Ast.String(value.ToString())
                )
            ) 
        // | Shape.HashSet -> 
        | Shape.Int16 ->
            projectValue(fun (value: int16) ->
                stringify value
                |> Ast.ConstantExpr
            )
 
        | Shape.Int32 ->
            projectValue(fun (value: int) ->
                Ast.Int value 
                |> Ast.ConstantExpr
            )
        | Shape.Int64 ->
            projectValue(fun (value: int64) ->
                stringify value
                |> Ast.ConstantExpr
            )
        // | Shape.IntPtr -> 
        // | Shape.ISerializable -> 
        // | Shape.KeyValuePair -> 
        // | Shape.Primitive -> 
        // | Shape.ResizeArray -> 
        | Shape.SByte ->
            projectValue(fun (value: sbyte) ->
                stringify value
                |> Ast.ConstantExpr
            )
 
        | Shape.Single ->
            projectValue(fun (value: single) ->
                match value with
                | value when Single.IsNaN value ->
                    Ast.ConstantExpr("Single.NaN")

                | value when Single.IsPositiveInfinity value ->
                    Ast.ConstantExpr("Single.PositiveInfinity")

                | value when Single.IsNegativeInfinity value ->
                    Ast.ConstantExpr("Single.NegativeInfinity")

                | value ->
                    stringify value
                    |> Ast.ConstantExpr
            )
        | Shape.String ->
            projectValue(fun (value: string) ->
                Ast.String(value)
                |> Ast.ConstantExpr
            )
        // | Shape.Struct -> 
        // | Shape.SystemArray -> 
        // | Shape.Tuple -> 
        // | Shape.UInt16 -> 
        | Shape.UInt32 ->
            projectValue(fun (value: uint32) ->
                stringify value
                |> Ast.ConstantExpr
            )
        | Shape.UInt64 ->
            projectValue(fun (value: uint64) ->
                stringify value
                |> Ast.ConstantExpr
            )
        // | Shape.UIntPtr -> 
        | Shape.Unit ->
            projectValue(fun (value:unit) ->
                Ast.ConstantExpr("()")
            )
        | Shape.Uri ->
            projectValue(fun (value: Uri) ->
                Ast.NewExpr(
                    Ast.LongIdent("Uri"),
                    Ast.String(value.OriginalString)
                )
            )
        | Shape.Enum shape ->
        shape.Accept {
            new IEnumVisitor<WidgetBuilder<SyntaxOak.Expr>> with
                member _.Visit<
                    'Enum,
                    'Underlying
                        when 'Enum : enum<'Underlying>
                        and 'Enum : struct
                        and 'Enum :> ValueType
                        and 'Enum : (new : unit -> 'Enum)
                > () =

                    projectValue(fun (value: 'Enum) ->
                        stringify value
                        |> Ast.ConstantExpr
                    )
        } 
        | Shape.TimeSpan ->
            projectValue(fun (value: TimeSpan) ->
                $"TimeSpan({value.Ticks}L)"
                |> Ast.ConstantExpr
            ) 
        // | Shape.Dictionary -> 
        | Shape.Enumerable shape ->
            shape.Accept {
                new IEnumerableVisitor<WidgetBuilder<SyntaxOak.Expr>> with
                    member _.Visit<
                        'Enumerable,
                        'Element
                            when 'Enumerable :> seq<'Element>
                    > () =

                        projectValue(fun (values: 'Enumerable) ->
                            Ast.ArrayExpr([
                                for value in values do
                                    emitValue pocoDepth maximumPocoDepth value
                            ])
                        )
            } 
        // | Shape.Exception -> 

        | Shape.Poco (:? ShapePoco<'ValueType> as shape) ->
            if not (depthPreservingTypes.Contains(typeof<'ValueType>.Name)) && pocoDepth >= maximumPocoDepth then
                Ast.AnonRecordExpr([])
            else

                let nextPocoDepth =
                        if depthPreservingTypes.Contains(typeof<'ValueType>.Name) then
                            pocoDepth
                        else
                            pocoDepth + 1
                shape.Properties
                |> Array.filter (fun property -> property.IsPublic)
                |> Array.choose (fun property ->

                    match typeof<'ValueType>.Name, property.Label with
                    | typeName, propertyName when excludedProperties.Contains(typeName, propertyName) -> None

                    | _, _ ->
                        property.Accept {
                            new IReadOnlyMemberVisitor< 'ValueType, WidgetBuilder<SyntaxOak.RecordFieldNode> option > with
                                member _.Visit
                                    (
                                        property:
                                            ReadOnlyMember<
                                                'ValueType,
                                                'PropertyType
                                            >
                                    ) =

                                    let propertyValue = property.Get value
                                

                                    match typeof<'ValueType>.Name, typeof<'PropertyType>.Name, shapeof<'PropertyType>, property.Label, box propertyValue  with
                                    | valueTypeName, propertyTypeName, Shape.Enumerable _, propertyIdentifier, propertyBoxedValue when isEmptyEnumerable propertyValue -> None
                                    | valueTypeName, propertyTypeName, propertyTypeShape, propertyIdentifier, null   -> None
                                    | valueTypeName, propertyTypeName, propertyTypeShape, propertyIdentifier, propertyBoxedValue when String.IsNullOrWhiteSpace(string propertyBoxedValue)   -> None
                                    | valueTypeName, propertyTypeName, propertyTypeShape, ("Table" | "FeatureTable"), propertyBoxedValue   -> 
                                                                                    Some(
                                                                                            Ast.RecordFieldExpr(
                                                                                                property.Label,
                                                                                                Ast.ConstantExpr "featureTable"
                                                                                            )
                                                                                        )
                                    | "ServiceFeatureTable", propertyTypeName, propertyTypeShape, "LayerInfo", propertyBoxedValue   -> 
                                                                                    Some(
                                                                                            Ast.RecordFieldExpr(
                                                                                                property.Label,
                                                                                                Ast.ConstantExpr "layerInfo"
                                                                                            )
                                                                                        )
                                    | "ArcGISMapImageLayer", propertyTypeName, propertyTypeShape, "ServiceInfo", propertyBoxedValue   -> 
                                                                                    Some(
                                                                                            Ast.RecordFieldExpr(
                                                                                                property.Label,
                                                                                                Ast.ConstantExpr "serviceInfo"
                                                                                            )
                                                                                        )

                                    | "Field", propertyTypeName, propertyTypeShape, "Domain", propertyBoxedValue   -> 
                                                let codedValueDomain = propertyValue |> box :?> CodedValueDomain
                                                Some(
                                                    Ast.RecordFieldExpr(
                                                        property.Label,
                                                        emitValue nextPocoDepth maximumPocoDepth codedValueDomain
                                                    )
                                                )
                                    | "CodedValue", propertyTypeName, propertyTypeShape, "Code", propertyBoxedValue   -> 
                                                let code = propertyValue |> box |> string 
                                                Some(
                                                    Ast.RecordFieldExpr(
                                                        property.Label,
                                                        emitValue nextPocoDepth maximumPocoDepth code
                                                    )
                                                )

                                                
                                    | "Feature", propertyTypeName, propertyTypeShape, "Attributes", propertyBoxedValue   -> 
                                                let attributeKeyValues =
                                                    propertyBoxedValue :?> IDictionary<string,obj>
                                                    |> Seq.toArray
                                                    |> Array.map (|KeyValue|)
                                                    |> Array.filter (fun (key,objValue) -> objValue <> null )
                                                    |> Array.filter (fun (key,objValue) -> not (String.IsNullOrWhiteSpace (string objValue)))
                                                Some(
                                                    Ast.RecordFieldExpr(
                                                         property.Label,
                                                        Ast.AnonRecordExpr([

                                                                        for attributeKey, attributeValue in attributeKeyValues do
                                                                            Ast.RecordFieldExpr(attributeKey, emitValue nextPocoDepth maximumPocoDepth attributeValue)

                                                        ])
                                                    )
                                                )
                                    | valueTypeName, propertyTypeName, propertyTypeShape, "Fields", propertyBoxedValue   -> 
                                                let fields = 
                                                        propertyBoxedValue :?> IReadOnlyList<Field>
                                                        |> Seq.toArray
                                                let domainFields = 
                                                    fields
                                                    |> Array.filter (fun field -> field.Domain <> null)
                                                let nonDomainFields = 
                                                    fields
                                                    |> Array.filter (fun field -> field.Domain = null)
                                                
                                                match domainFields.Length, nonDomainFields.Length with 
                                                | domainLength, nonDomainLength when domainLength > 0 && nonDomainLength > 0 -> 
                                                        Some(
                                                            Ast.RecordFieldExpr(
                                                                property.Label,
                                                                    Ast.AnonRecordExpr([
                                                                        Ast.RecordFieldExpr("DomainFields",Ast.ArrayExpr([
                                                                            for field in domainFields do
                                                                                emitValue nextPocoDepth maximumPocoDepth field
                                                                        ]))
                                                        
                                                                        Ast.RecordFieldExpr("NonDomainFields",Ast.ArrayExpr([
                                                                            for field in nonDomainFields do
                                                                                emitValue nextPocoDepth maximumPocoDepth field
                                                                        ]))
                                                                ])
                                                            )
                                                        )
                                                | 0, nonDomainLength when nonDomainLength > 0 -> 
                                                        Some(
                                                            Ast.RecordFieldExpr(
                                                                property.Label,
                                                                    Ast.AnonRecordExpr([
                                                                        Ast.RecordFieldExpr("NonDomainFields",Ast.ArrayExpr([
                                                                            for field in nonDomainFields do
                                                                                emitValue nextPocoDepth maximumPocoDepth field
                                                                        ]))
                                                                ])
                                                            )
                                                        )
                                                | domainLength, 0 when domainLength > 0 -> 
                                                        Some(
                                                            Ast.RecordFieldExpr(
                                                                property.Label,
                                                                    Ast.AnonRecordExpr([
                                                                        Ast.RecordFieldExpr("DomainFields",Ast.ArrayExpr([
                                                                            for field in domainFields do
                                                                                emitValue nextPocoDepth maximumPocoDepth field
                                                                        ]))
                                                                ])
                                                            )
                                                        )
                                                | domainLength, nonDomainLength -> None
                                    | valueTypeName, propertyTypeName, propertyTypeShape, "Sublayers", propertyBoxedValue   -> 
                                                let sublayers = 
                                                        propertyBoxedValue :?> IList<ArcGISSublayer>
                                                        |> Seq.map (fun value -> value :?> ArcGISMapImageSublayer)
                                                        |> Seq.toArray
                                                let propertySignatures = 
                                                    sublayers |> Array.groupBy (fun sublayer -> sublayer.propertySignature)
                                                match valueTypeName with 
                                                | "ArcGISMapImageLayer" ->  
                                                    let groupLayers = 
                                                        propertySignatures
                                                        |> Array.pick (fun (properties,sublayers ) -> 
                                                        let tablePropertyExists = properties |> List.exists (fun property -> property = "Table")
                                                        if tablePropertyExists then 
                                                            None
                                                        else 
                                                            Some sublayers
                                                        )
                                                    let ungroupedLayers = 
                                                        propertySignatures
                                                        |> Array.pick (fun (properties,sublayers ) -> 
                                                        let tablePropertyExists = properties |> List.exists (fun property -> property = "Table")
                                                        if tablePropertyExists then 
                                                            Some sublayers
                                                        else 
                                                            None
                                                        )
                                                    let subtypedLayers = 
                                                        ungroupedLayers
                                                        |> Array.filter (fun layer -> layer.Table.DefaultSubtypeCode <> null)
                                                    let untypedLayers =
                                                        ungroupedLayers
                                                        |> Array.filter (fun layer -> layer.Table.DefaultSubtypeCode = null)



                                                    Some(
                                                        Ast.RecordFieldExpr(
                                                            property.Label,
                                                            Ast.AnonRecordExpr([
                                                                Ast.RecordFieldExpr("GroupLayers",Ast.ArrayExpr([
                                                                    for sublayer in groupLayers do
                                                                        let binder = VariableBinder sublayer.Name
                                                                        Ast.ConstantExpr $"{binder.binding}.groupLayer"
                                                                ]))
                                                                Ast.RecordFieldExpr("SubtypedLayers",Ast.ArrayExpr([
                                                                    for sublayer in subtypedLayers do
                                                                        let binder = VariableBinder sublayer.Name
                                                                        Ast.ConstantExpr $"{binder.binding}.featureLayer"
                                                                ]))
                                                                Ast.RecordFieldExpr("UntypedLayers",Ast.ArrayExpr([
                                                                    for sublayer in untypedLayers do
                                                                        let binder = VariableBinder sublayer.Name
                                                                        Ast.ConstantExpr $"{binder.binding}.featureLayer"
                                                                ]))
                                                            ])
                                                        )
                                                    )
                                                | _ -> None
                                    | valueTypeName, propertyTypeName, propertyTypeShape, propertyIdentifier, propertyBoxedValue   -> 
                                                Some(
                                                    Ast.RecordFieldExpr(
                                                        property.Label,
                                                        emitValue nextPocoDepth maximumPocoDepth propertyValue
                                                    )
                                                )
                        }
                )
                |> Array.toList
                |> Ast.AnonRecordExpr
        | shape
            when
                typeof<'ValueType>.IsAbstract
                && not (isNull (box value)) ->

            TypeShape.FromValue(box value)
            |> fun runtimeShape ->
                runtimeShape.Accept {
                    new ITypeVisitor<WidgetBuilder<SyntaxOak.Expr>> with
                        member _.Visit<'RuntimeValueType>() =

                            let runtimeValue =
                                unbox<'RuntimeValueType> (box value)

                            emitValue
                                pocoDepth
                                maximumPocoDepth
                                runtimeValue
                }
        | _ ->
            Ast.VerbatimString(
                sprintf
                    "ERROR: unsupported value of runtime type\t%O ; static type %s"
                    value
                    typeof<'ValueType>.Name
            )
            |> Ast.ConstantExpr

let test_file_path = Path.Combine(__SOURCE_DIRECTORY__, "test.fsx")


    


let emitBinding  (value:'ValueType)(maximumDepth:int) (binder:Binder) = 
            match binder, value with
            | _, _  when String.IsNullOrWhiteSpace (string value) -> Ast.Value(binder.binding, "()").xmlDocs(Ast.Summary("value was unbound"))
            | _, _ -> Ast.Value(binder.binding, emitValue 0 maximumDepth value)
        
    

let collectTypeNamespaces
    (maximumDepth: int)
    (propertyExclusions: Set<string * string>)
    (rootType: Type)
    =

    let visitedTypes =
        HashSet<Type>()

    let rec collect
        (depth: int)
        (clrType: Type)
        : Set<string> =

        if
            depth > maximumDepth
            || not (visitedTypes.Add clrType)
        then
            Set.empty

        else
            let ownNamespace =
                match clrType.Namespace with
                | null ->
                    Set.empty

                | namespaceName ->
                    Set.singleton namespaceName

            let genericArgumentNamespaces =
                clrType.GetGenericArguments()
                |> Array.map (collect depth)
                |> Set.unionMany

            let elementTypeNamespaces =
                match clrType.GetElementType() with
                | null ->
                    Set.empty

                | elementType ->
                    collect depth elementType

            let propertyNamespaces =
                clrType.GetProperties()
                |> Array.filter (fun property ->
                    not (
                        propertyExclusions.Contains(
                            clrType.Name,
                            property.Name
                        )
                    )
                )
                |> Array.map (fun property ->
                    collect
                        (depth + 1)
                        property.PropertyType
                )
                |> Set.unionMany

            Set.unionMany [
                ownNamespace
                genericArgumentNamespaces
                elementTypeNamespaces
                propertyNamespaces
            ]

    collect 0 rootType









MapServer.fields |> Array.randomSample 3










module Folder = 
    let Generated = Directory.CreateDirectory @"C:\Repositories\appsdb\IPS_Sites\integration\StormwaterInfrastructure\Generated"

let recordDepth = 2

let property_namespaces = collectTypeNamespaces 10 Set.empty typeof<ArcGISMapImageLayer>

type Projection = 
    {
        namespaceBinder: Binder
        moduleBinder : Binder
        variableBinder : Binder
    }
    member this.relativePath = this.namespaceBinder.identifier.Split('.') |> String.concat "\\"
    member this.directory = Directory.CreateDirectory(Path.Combine(Folder.Generated.FullName,this.relativePath))
    member this.file = Path.Combine(this.directory.FullName, $"{this.moduleBinder.binding}.fs") |> FileInfo
// TODO deal with feature layer modulesIiIkj
    member this.fileText =
        Ast.Oak() {
            Ast.Namespace($"{this.namespaceBinder.identifier}.{this.moduleBinder.binding}") {
                (*
                Ast.HashDirective(
                    "r",
                    "\"nuget: Esri.ArcGISRuntime, 300.0.0\""
                )
                *)
                for property_namespace in property_namespaces do
                    Ast.Open(property_namespace)

                for sublayer in MapServer.group_layers do
                    let layerModule = ModuleBinder sublayer.Name
                    let sublayers = 
                        match sublayer.Name with 
                        | "Drainage Network" -> MapServer.drainage_network_layers
                        | "Non-Drainage Network" -> MapServer.nondrainage_network_layers

                    Ast.Module(layerModule.binding){
                        for sublayer in sublayers do
                            let layerModule = ModuleBinder sublayer.Name
                            Ast.Module(layerModule.binding){
                                VariableBinder "layerInfo" |> emitBinding sublayer.Table.LayerInfo recordDepth
                                VariableBinder "featureTable" |> emitBinding sublayer.Table recordDepth
                                VariableBinder "featureLayer" |> emitBinding sublayer recordDepth
                                for index = 0 to sublayer.Table.featuresByAttributeSignature.Length - 1 do 
                                    let signature, features = sublayer.Table.featuresByAttributeSignature[index]
                                    VariableBinder $"featureGroup_{index + 1}" |> emitBinding features recordDepth
                            }
                        VariableBinder "groupLayer" |> emitBinding sublayer recordDepth
                    }


                for sublayer in MapServer.ungrouped_layers do
                    let layerModule = ModuleBinder sublayer.Name
                    Ast.Module(layerModule.binding){
                        VariableBinder "layerInfo" |> emitBinding sublayer.Table.LayerInfo recordDepth
                        VariableBinder "featureTable" |> emitBinding sublayer.Table recordDepth
                        VariableBinder "featureLayer" |> emitBinding sublayer recordDepth
                    }
                VariableBinder "serviceInfo" |> emitBinding MapServer.ServiceInfo recordDepth
                VariableBinder "imageLayer" |> emitBinding MapServer recordDepth 

            }|> _.toImplicit()
        }
        |> Gen.mkOak
        |> Gen.run
    member this.WriteAllText() = File.WriteAllText(this.file.FullName,this.fileText)
let namespaceBase = "gov.leoncountyfl.interraster"
let mapServerProjection = 
    {
        namespaceBinder = NamespaceBinder namespaceBase
        moduleBinder = ModuleBinder MapServer.Name
        variableBinder = VariableBinder MapServer.Name
    }
let groupLayerProjections = 
    MapServer.group_layers
    |> Array.map (fun groupLayer -> 
        
            {

                namespaceBinder = NamespaceBinder $"{namespaceBase}.{mapServerProjection.moduleBinder.binding}"
                moduleBinder = ModuleBinder groupLayer.Name
                variableBinder = VariableBinder "groupLayer"

            }
        )
mapServerProjection.WriteAllText()




(*
let projections = 
    Array.concat [|
        groupLayerProjections
    |]
    |> Array.insertAt 0 mapServerProjection
projections |> Array.iter (fun projection -> projection.WriteAllText())

*)
// helpful manual regexes
// \{\|\s+\|\}
// ERROR



(*

Ast.Oak() {
    Ast.Namespace("gov.leoncountyfl.interraster") {

        Ast.HashDirective(
            "r",
            "\"nuget: Esri.ArcGISRuntime, 300.0.0\""
        )
        for property_namespace in property_namespaces do
            Ast.Open(property_namespace)
}|> _.toImplicit()

}
|> Gen.mkOak
|> Gen.run
|> fun fileText -> File.WriteAllText(test_file_path, fileText)



let signatures =  MapServer.sublayers |> Array.groupBy (fun sublayer -> sublayer.propertySignature)
signatures |> Array.iter (fun (signature,sublayers ) -> printfn "%A" signature)
signatures |> Array.iter (fun (signature,sublayers ) -> printfn "%A" (sublayers |> Array.map (fun sublayer -> sublayer.Name)))
MapServer.sublayers[2].Table
MapServer.sublayers[1].Table.FeatureTypes[0].Id

*)
MapServer.drainage_network_layers[2].Table.FeatureSubtypes[0].FieldOverrides.GetType().Name
let DebrisTrapTable = MapServer.tables_by_name "Debris Trap" |> Array.exactlyOne
let debrisTraps = DebrisTrapTable.features |> Array.groupBy (fun feature -> feature.attributeSignature)
