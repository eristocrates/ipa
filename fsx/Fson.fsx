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
open canopy.classic
open DoxAletheia
open Dubzer.WhatwgUrl
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

open FSharp.Data
open FSharp.Data.JsonPath
open FSharp.Data.JsonSchema
open FSharp.Data.JsonSchema.Core
open FSharp.Data.JsonSchema.OpenApi
open System.Numerics
type JsonNode = Nodes.JsonNode
type JsonNodeObject = Nodes.JsonObject
type JsonNodeArray = Nodes.JsonArray
type JsonNodeValue = Nodes.JsonValue

module FsonTraversal =

    let rec descendantsAndSelf
        (children: 'T -> seq<'T>)
        (value: 'T)
        : seq<'T> =

        seq {
            yield value

            for child in children value do
                yield! descendantsAndSelf children child
        }

module Array = 
    let print elements = printf "\n\n%A\n\n\n" elements
type JsonDocument with 
    static member ofJsonLiteral(literal:JsonLiteral) = JsonDocument.Parse literal.jsonString
type Nodes.JsonNode with 
    static member ofJsonLiteral(literal:JsonLiteral) = Nodes.JsonNode.Parse literal.jsonString
type JsonValue with 
    static member ofJsonLiteral(literal:JsonLiteral) = JsonValue.Parse literal.jsonString
type JToken with 
    static member ofJsonLiteral(literal:JsonLiteral) = JToken.Parse literal.jsonString
type JsonLiteral with 
    member this.asJsonDocument = JsonDocument.ofJsonLiteral this
    member this.asJsonNode = Nodes.JsonNode.ofJsonLiteral this
    member this.asJsonValue = JsonValue.ofJsonLiteral this
    member this.asJToken = JToken.ofJsonLiteral this

type JsonPointer with 
    static member ofJsonNode(jsonNode:JsonNode) = 
        jsonNode.GetPointerFromRoot() |> JsonPointer.Parse

    member this.tryMemberName =
        match this.SegmentCount with
        | 0 ->
            None

        | count ->
            Some <| this.GetSegment(count - 1).ToString()

    member this.tryElementName =
        match this.SegmentCount with
        | count when count >= 2 ->
            Some <| this.GetSegment(count - 2).ToString()

        | _ -> None

type JsonPath with 
    static member ofJsonNode(jsonNode:JsonNode) = 
        jsonNode.GetPathFromRoot() |> JsonPath.Parse
    static member ofJsonPointer(pointer:JsonPointer) = 
        "$." + pointer.ToString().Replace("~1", "[") .Replace("~0", "]") .Replace("/", ".") |> JsonPath.Parse

    member this.nearestName =
        this.Segments
        |> Array.rev
        |> Array.tryPick (fun segment ->
            segment.Selectors
            |> Array.tryPick (function
                | :? NameSelector as selector ->
                    Some selector.Name
                | _ ->
                    None
            )
        )
        |> Option.defaultValue "root"
type FsonDocument = 
    {
        pointerMap: Map<string, FsonValue>
        pathMap: Map<string array, FsonValue array>
        nameMap: Map<string, FsonValue array>
    }
    static member ofJsonLiteral(literal: JsonLiteral) =
        let fsonRootValue : FsonValue = FsonValue.ofJsonNode literal.asJsonNode 
        let fsonValues = fsonRootValue.descendantsAndSelf
        {
            pointerMap =
                fsonValues
                |> Array.Parallel.filter (fun fsonValue -> 
                    match fsonValue.pointer.ToString(), fsonValue.instance with 
                    | "", FsonSort(FsonOption None) -> false
                    | _, _ -> true
                    
                    )
                |> Array.Parallel.map (fun fsonValue ->
                    fsonValue.pointer.ToString(), fsonValue
                )
                |> Map.ofArray
            pathMap = 
                fsonValues 
                |> Array.Parallel.groupBy (fun fsonValue -> fsonValue.pathSegments) |> Map.ofArray
            nameMap = 
                fsonValues
                |> Array.Parallel.groupBy (fun fsonValue -> fsonValue.nearestName) |> Map.ofArray

        }
    member this.fsonRoot = this.pointerMap[""]
    member this.fsonValues = 
        this.pointerMap.Values  |> Seq.toArray
    member this.pointers = 
        this.fsonValues
        |> Array.map (fun fsonValue -> fsonValue.pointer)
    member this.tryResolve(pointer: JsonPointer) =
        this.pointerMap
        |> Map.tryFind (pointer.ToString())

    member this.resolve(pointer: JsonPointer) =
        this.pointerMap
        |> Map.find (pointer.ToString())

and FsonInstanceDocument =
    | FsonInstanceDocument of FsonDocument
    member this.fsonDocument = 
        match this with 
        | FsonInstanceDocument fsonDocument -> fsonDocument
and FsonSchemaDocument =
    | FsonSchemaDocument of FsonDocument
    member this.fsonDocument = 
        match this with 
        | FsonSchemaDocument fsonDocument -> fsonDocument
and FsonSchemaInstance = 
    {
        fsonSchema:FsonSchemaDocument
        fsonInstance:FsonInstanceDocument
    }
and FsonValue =
    {   
        nearestName:string
        instance: FsonInstance
        pointer :JsonPointer
        path :JsonPath
    }
    member this.pathSegments =
        this.path.Segments
        |> Array.collect (fun segment ->
            segment.Selectors
            |> Array.choose (function
                | :? NameSelector as selector -> Some selector.Name
                | _ -> None
            )
        )
    static member ofNullPath
        (path: JsonPath) =

        {
            nearestName = path.nearestName
            instance = FsonInstance.ofNull()
            pointer = JsonPointer.Parse(path.AsJsonPointer())
            path = path
        }
    static member ofNull() = 
                    let nullishNode = JsonNode.Parse "[]"
                     
                    {
                        nearestName = "null"
                        instance =  FsonInstance.ofNull()
                        pointer = JsonPointer.ofJsonNode nullishNode
                        path = JsonPath.ofJsonNode nullishNode
                    }
    static member ofNullNode(jsonNode:JsonNode) = 
                    let path = JsonPath.ofJsonNode jsonNode
                    {
                        nearestName = path.nearestName
                        instance =  FsonInstance.ofNull()
                        pointer = JsonPointer.ofJsonNode jsonNode
                        path = path
                    }

    static member ofJsonNode (jsonNode:JsonNode) = 
        match jsonNode with 
        | null -> FsonValue.ofNull()
        | :? Nodes.JsonArray as nodeArray -> 
            let path = JsonPath.ofJsonNode jsonNode
            {
                nearestName = path.nearestName
                instance = FsonArray.toFsonInstance {
                fsonElements =
                    nodeArray
                    |> Seq.toArray
                    |> Array.mapi (fun index child ->
                        match child with
                        | null ->
                            FsonValue.ofNullPath(path.Append(index))
                        | child ->
                            FsonValue.ofJsonNode child
                            )                        
                    }
                pointer = JsonPointer.ofJsonNode jsonNode
                path = path
            }

        | :? Nodes.JsonObject as nodeObject -> 
            let path = JsonPath.ofJsonNode jsonNode
            {
                nearestName = path.nearestName
                instance = FsonObject.ofJsonObject nodeObject |> FsonObject.toFsonInstance  
                pointer = JsonPointer.ofJsonNode jsonNode
                path = path
            }
        | :? Nodes.JsonValue as nodeValue -> 
            match nodeValue.GetValueKind() with 
            | JsonValueKind.String -> 
                let path = JsonPath.ofJsonNode jsonNode
                {
                    nearestName = path.nearestName
                    instance =  FsonInstance.ofString(string jsonNode)
                    pointer = JsonPointer.ofJsonNode jsonNode
                    path = path
                }
            | JsonValueKind.Number ->
                let path = JsonPath.ofJsonNode jsonNode
                let raw = nodeValue.GetValue<JsonElement>().GetRawText()

                let integerSyntax =
                    not (raw.Contains('.')
                         || raw.Contains('e')
                         || raw.Contains('E'))
                let fsonNumber = 

                    if integerSyntax then
                        match Int32.TryParse(raw, NumberStyles.Integer, CultureInfo.InvariantCulture) with
                        | true, value -> FsonInt value
                        | false, _ ->
                            match Int64.TryParse(raw, NumberStyles.Integer, CultureInfo.InvariantCulture) with
                            | true, value -> FsonInt64 value
                            | false, _ ->
                                match BigInteger.TryParse(raw, NumberStyles.Integer, CultureInfo.InvariantCulture) with
                                | true, value -> FsonBigInteger value
                                | false, _ -> FsonRawNumber raw
                    else
                        match Decimal.TryParse(raw, NumberStyles.Float, CultureInfo.InvariantCulture) with
                        | true, value -> FsonDecimal value
                        | false, _ -> FsonRawNumber raw
                    
                {
                    nearestName = path.nearestName
                    instance = FsonNumber fsonNumber |> FsonLiteral
                    pointer = JsonPointer.ofJsonNode jsonNode
                    path = path
                }

            | JsonValueKind.True ->
                let path = JsonPath.ofJsonNode jsonNode
                {
                    nearestName = path.nearestName
                    instance =  FsonInstance.ofBoolean true
                    pointer = JsonPointer.ofJsonNode jsonNode
                    path = path
                }
            | JsonValueKind.False ->
                let path = JsonPath.ofJsonNode jsonNode
                {
                    nearestName = path.nearestName
                    instance =  FsonInstance.ofBoolean false  
                    pointer = JsonPointer.ofJsonNode jsonNode
                    path = path
                }
            | JsonValueKind.Null -> FsonValue.ofNullNode jsonNode

    member this.children : FsonValue array =
        match this.instance with

        | FsonSort (FsonSequence (FsonObject fsonObject)) ->
            fsonObject.Values

        | FsonSort (FsonSequence (FsonArray fsonArray)) ->
            fsonArray.fsonElements

        | _ ->
            [||]
    member this.descendantsAndSelf : FsonValue array =

        let rec traverse (value: FsonValue) =
            [|
                yield value

                for child in value.children do
                    yield! traverse child
            |]

        traverse this

    member this.descendants : FsonValue array =
        this.children
        |> Array.collect _.descendantsAndSelf

    member this.childObjectValues = 
        this.children |> Array.filter (fun childValue ->  
        
            match childValue.instance with 
            | FsonSort (FsonSequence (FsonObject childObject)) -> true
            | _ -> false

        )
    member this.childArrayValues = 
        this.children |> Array.filter (fun childValue ->  
        
            match childValue.instance with 
            | FsonSort (FsonSequence (FsonArray childArray)) -> true
            | _ -> false

        )

    member this.childLiteralValues = 
        this.children |> Array.filter (fun childValue ->  
        
            match childValue.instance with 
            | FsonLiteral childLiteral -> true
            | _ -> false

        )
    // All immediate children
    member this.childNames =
        this.children |> Array.map _.nearestName

    member this.childPointers =
        this.children |> Array.map _.pointer

    member this.childPathSegments =
        this.children |> Array.map _.pathSegments

    // Object children
    member this.childObjectNames =
        this.childObjectValues |> Array.map _.nearestName

    member this.childObjectPointers =
        this.childObjectValues |> Array.map _.pointer

    member this.childObjectPathSegments =
        this.childObjectValues |> Array.map _.pathSegments

    // Array children
    member this.childArrayNames =
        this.childArrayValues |> Array.map _.nearestName

    member this.childArrayPointers =
        this.childArrayValues |> Array.map _.pointer

    member this.childArrayPathSegments =
        this.childArrayValues |> Array.map _.pathSegments

    // Literal children
    member this.childLiteralNames =
        this.childLiteralValues |> Array.map _.nearestName

    member this.childLiteralPointers =
        this.childLiteralValues |> Array.map _.pointer

    member this.childLiteralPathSegments =
        this.childLiteralValues |> Array.map _.pathSegments        
and FsonInstance =
    | FsonLiteral of FsonLiteral
    | FsonSort of FsonSort
    static member ofString (stringValue:string) = FsonString stringValue |> FsonLiteral
    static member ofDecimal (decimalValue:decimal) = FsonDecimal decimalValue |> FsonNumber |> FsonLiteral
    static member ofInt32 (intValue:int) = FsonInt intValue |> FsonNumber |> FsonLiteral
    static member ofBoolean(booleanValue:bool) = FsonBoolean booleanValue |> FsonLiteral
    static member ofNull() = FsonOption None  |> FsonSort
    member this.asString = 
        match this with 
        | FsonLiteral fsonLiteral -> fsonLiteral.asString
        | FsonSort fsonSort -> fsonSort.asString
        
and  FsonLiteral = 
    | FsonString of string
    | FsonNumber of FsonNumber
    | FsonBoolean of bool
    static member tryString (maybeString:string option) = maybeString |> Option.map (fun stringValue -> FsonString stringValue)
    member this.asString = 
        match this with 
        | FsonString stringValue -> stringValue
        | FsonNumber fsonNumber -> fsonNumber.asString
        | FsonBoolean boolValue -> boolValue.ToString().ToLowerInvariant()

and FsonNumber =
    | FsonInt of int
    | FsonInt64 of int64
    | FsonBigInteger of BigInteger
    | FsonDecimal of decimal
    | FsonRawNumber of string
    member this.asString = 
        match this with 
        | FsonInt intValue -> string intValue
        | FsonInt64 intValue -> string intValue
        | FsonBigInteger intValue -> string intValue
        | FsonDecimal decimalValue -> string decimalValue
        | FsonRawNumber numberString -> numberString

and FsonSort = 
    | FsonOption of FsonInstance option
    | FsonMember of FsonMember
    | FsonSequence of FsonSequence
    member this.asString = 
        match this with 
        | FsonOption  (Some fsonInstance) -> fsonInstance.asString
        | FsonOption  None  -> "null"
        | FsonMember  fsonMember -> fsonMember.asString
        | FsonSequence  fsonSequence -> fsonSequence.asString
        
and FsonMember = 
    | FsonProperty of FsonProperty
    | FsonKeyword of FsonKeyword
    member this.asString = 
        match this with 
        | FsonProperty fsonProperty -> fsonProperty.asString
        | FsonKeyword fsonKeyword -> fsonKeyword.asString
        
    static member ofJsonObject(nodeObject: Nodes.JsonObject) =
        let parentPath = JsonPath.ofJsonNode nodeObject

        nodeObject
        |> Seq.map (fun (KeyValue(name, node)) ->

            let value =
                match node with
                | null ->
                    FsonValue.ofNullPath(parentPath.Append(name))
                | node ->
                    FsonValue.ofJsonNode node

            match name with
            | name when name.StartsWith("@") ->
                AtKeyword.ofNameValue(name, value) |> AtKeyword |> FsonKeyword

            | name when name.StartsWith("$") ->
                DollarKeyword.ofNameValue(name, value) |> DollarKeyword |> FsonKeyword

            | name ->
                FsonProperty {
                    propertyName = FsonString name
                    fsonValue = value
                }
        )
        |> Seq.toArray
    member this.Value =
        match this with
        | FsonProperty property ->
            property.fsonValue
        | FsonKeyword keyword ->keyword.fsonValue

and FsonProperty =
    {
        propertyName:FsonLiteral
        fsonValue:FsonValue
    }
    member this.asString = this.fsonValue.instance.asString
and FsonSequence = 
    | FsonArray of FsonArray
    | FsonObject of FsonObject 
    member this.asString = 
        match this with 
            | FsonArray fsonArray -> fsonArray.asString
            | FsonObject fsonObject -> fsonObject.asString 

and  FsonArray = 
    {
        fsonElements : FsonValue array
    }
    member this.asString = 
        sprintf "[ %s ]" (this.fsonElements |> Array.map (fun fsonValue -> fsonValue.instance.asString ) |> String.concat ", ")
    static member toFsonInstance (fsonArray:FsonArray) = FsonArray fsonArray |> FsonSequence |> FsonSort
    // static member ofJsonArray
and FsonObject = 
    {
        fsonMembers : FsonMember array
    }
    member this.asString = 
        sprintf "[ %s ]" (this.fsonMembers |> Array.map (fun fsonMember -> fsonMember.asString ) |> String.concat ", ")
    static member toFsonInstance (fsonObject:FsonObject) = FsonObject fsonObject |> FsonSequence |> FsonSort
    static member ofJsonObject(nodeObject: Nodes.JsonObject) : FsonObject =
        {
            fsonMembers = FsonMember.ofJsonObject nodeObject
        }
    member this.Values =
        this.fsonMembers
        |> Array.map (fun fsonMember -> fsonMember.Value)
and FsonKeyword = 
    | JsonKeyword
    | AtKeyword of AtKeyword
    | DollarKeyword of DollarKeyword
    member this.fsonValue = 
        match this with 
        | AtKeyword keyword -> keyword.fsonValue
        | DollarKeyword keyword -> keyword.fsonValue
    member this.asString = 
        match this with 
        | AtKeyword keyword -> keyword.asString
        | DollarKeyword keyword -> keyword.asString
and JsonSchemaKeywordKind = 
    /// control schema identification through setting a URI for the schema and/or changing how the base URI is determined
    | IdentifierKeyword
    /// produce a boolean result when applied to an instance
    | AssertionKeywrod
    /// attach information to an instance for application use
    | AnnotationKeyword
    /// apply one or more subschemas to a particular location in the instance, and combine or modify their results
    | ApplicatorKeyword
    /// do not directly affect results, but reserve a place for a specific purpose to ensure interoperability
    | ReservedLocationKeyword
and AtKeyword = 
    | RawAtKeyword of string * FsonValue
    static member ofNameValue(name:string,value:FsonValue) = 
        match name[1..] with 
        | _ -> RawAtKeyword(name, value)
    member this.fsonValue = 
        match this with
        | RawAtKeyword(keyword, fsonValue) -> fsonValue
    member this.asString = this.fsonValue.instance.asString

and DollarKeyword = 
    | RefKeyword of RefKeyword
    | RawDollarKeyword of  string * FsonValue
    static member ofNameValue(name:string,value:FsonValue) = 
        match name[1..] with 
        | "ref" -> RefKeyword { 
            refPointer = value.instance.asString.TrimStart('#') |> JsonPointer.Parse
            fsonValue = value
            }
        | _ -> RawDollarKeyword(name, value)
    member this.fsonValue = 
        match this with
        | RefKeyword keyword -> keyword.fsonValue
        | RawDollarKeyword(keyword, fsonValue) -> fsonValue
        
    member this.asString = this.fsonValue.instance.asString
and RefKeyword = 
    {
        refPointer:JsonPointer
        fsonValue:FsonValue
    }
    member this.name = "$ref"
    member this.asString = $"#{this.refPointer.ToString()}"
    // member this.ref (njsonSchemaDocument:FsonInstanceDocument) = njsonSchemaDocument.resolve this.refPointer
    
type JsonLiteral with 
    member this.clip = this.jsonString.clip

let jsonInstanceLiteral = { jsonString = File.ReadAllText @"D:\https\com\github\eristocrates\ipa\fsx\githubEvents.json" }
let jsonSchemaLiteral = { jsonString = (Universal.Common.Json.JsonSchemaInferrer().Infer jsonInstanceLiteral.asJToken).ToJson() }
let njsonSchemaLiteral = { jsonString = NJsonSchema.SampleJsonSchemaGenerator().Generate(jsonInstanceLiteral.jsonString).ActualSchema.ToJson() }
let jsonInstanceDocument = FsonDocument.ofJsonLiteral jsonInstanceLiteral |> FsonInstanceDocument
let jsonSchemaDocument = FsonDocument.ofJsonLiteral jsonSchemaLiteral |> FsonSchemaDocument
let njsonSchemaDocument = FsonDocument.ofJsonLiteral njsonSchemaLiteral |> FsonSchemaDocument
type FsonValue with 
    member this.tryFsonObject = 
        match this.instance with 
        | FsonSort(FsonSequence(FsonObject fsonObject)) -> Some fsonObject
        | _ -> None
type FsonMember with 
    member this.tryRefKeyword = 
        match this with 
        | FsonKeyword(DollarKeyword (RefKeyword keyword)) -> Some keyword
        | _ -> None
module FsonValue =
    let tryChild(name: string) (fsonValue:FsonValue)=
        fsonValue.children
        |> Array.tryFind (fun child ->
            child.nearestName = name
        )
    let tryRef (fsonValue:FsonValue)=
        fsonValue.children
        |> Array.tryPick (fun child -> 
            match child.tryFsonObject with 
            | Some fsonObject -> fsonObject.fsonMembers |> Array.tryPick (fun fsonMember -> fsonMember.tryRefKeyword)
            | _ -> None
        )

    let child(name: string) (fsonValue:FsonValue)=
        fsonValue.children
        |> Array.find (fun child ->
            child.nearestName = name
        )
type JsonPointer with 
    member this.appendSegment (segment:string) = JsonPointer.Parse $"{this.ToString()}/{segment}"
