module DoxAletheia.JsonErgonomics


open Microsoft.FSharp.Reflection




open FSharp.Data
open FSharp.Data.JsonExtensions



open Fabulous.AST
open Fabulous.AST.Json

open type Fabulous.AST.Ast
open Fantomas.FCS.Text





module JsonValue =

    let IsScalar (jsonValue: JsonValue) =
        match jsonValue with
        | JsonValue.String _
        | JsonValue.Number _
        | JsonValue.Float _
        | JsonValue.Boolean _ -> true
        | _ -> false

    let rec ScalarKeys (jsonValue: JsonValue) =
        match jsonValue with
        | JsonValue.Record properties ->
            properties
            |> Array.choose (fun (key, value) ->
                if IsScalar value then
                    Some key
                else
                    None)

        | JsonValue.Array elements ->
            elements
            |> Array.collect ScalarKeys
            |> Array.distinct

        | _ -> [||]

    let rec ScalarValues (jsonValue: JsonValue) =
        match jsonValue with
        | JsonValue.Record properties ->
            properties
            |> Array.choose (fun (key, value) ->
                if IsScalar value then
                    Some value
                else
                    None)

        | JsonValue.Array elements ->
            elements
            |> Array.collect ScalarValues
            |> Array.distinct

        | _ -> [||]

    let rec ScalarKeyValues (jsonValue: JsonValue) =
        match jsonValue with
        | JsonValue.Record properties ->
            properties
            |> Array.choose (fun (key, value) ->
                if IsScalar value then
                    Some(key, value)
                else
                    None)

        | JsonValue.Array elements ->
            elements
            |> Array.collect ScalarKeyValues
            |> Array.distinct

        | _ -> [||]

    let rec PropertyKeys (jsonValue: JsonValue) =
        match jsonValue with
        | JsonValue.Record properties -> properties |> Array.map fst
        | JsonValue.Array elements ->
            elements
            |> Array.collect PropertyKeys
            |> Array.distinct
        | _ -> [||]

    let rec PropertyValues (jsonValue: JsonValue) =
        match jsonValue with
        | JsonValue.Record properties -> properties |> Array.map snd
        | JsonValue.Array elements -> elements |> Array.collect PropertyValues
        | _ -> [||]

    let rec GrandPropertyKeys (jsonValue: JsonValue) =
        match jsonValue with
        | JsonValue.Record properties ->
            properties
            |> Array.map snd
            |> Array.collect PropertyKeys
            |> Array.distinct
        | JsonValue.Array elements ->
            elements
            |> Array.collect GrandPropertyKeys
            |> Array.distinct
        | _ -> [||]

    let Kind (jsonValue: JsonValue) =
        let (caseInfo, _) = FSharpValue.GetUnionFields(jsonValue, typeof<JsonValue>)
        caseInfo.Name

    let rec PropertyArray propertyName jsonValue =
        match jsonValue with
        | JsonValue.Record properties ->
            properties
            |> Array.choose (fun (key, value) ->
                if key = propertyName then
                    Some value
                else
                    None)
        | JsonValue.Array elements ->
            elements
            |> Array.collect (PropertyArray propertyName)
        | _ -> [||]

    let PropertiesArray propertyName jsonValues =
        jsonValues
        |> Array.collect (PropertyArray propertyName)


type JsonValue with

    member this.ScalarKeys = this |> JsonValue.ScalarKeys
    member this.ScalarValues = this |> JsonValue.ScalarValues
    member this.ScalarKeyValues = this |> JsonValue.ScalarKeyValues
    member this.PropertyKeys = this |> JsonValue.PropertyKeys

    member this.PropertyValues = this |> JsonValue.PropertyValues

    member this.GrandPropertyKeys = this |> JsonValue.GrandPropertyKeys

    member this.Kind = this |> JsonValue.Kind

    member this.AsArray =
        match this with
        | JsonValue.Array values -> values
        | _ -> [||]

    member this.AsRecord =
        match this with
        | JsonValue.Record properties -> properties
        | _ -> [||]

    member this.Properties = this.AsRecord

    member this.PropertyArray(propertyName: string) =
        JsonValue.PropertyArray propertyName this



let (?>) (jsonObjects: JsonValue array) (propertyName: string) =
    JsonValue.PropertiesArray propertyName jsonObjects


type 'T ``[]`` with

    member this.ScalarKeys =
        match box this with
        | :? (JsonValue array) as values ->
            values
            |> Array.collect JsonValue.ScalarKeys
            |> Array.distinct
        | _ -> [||]

    member this.ScalarValues =
        match box this with
        | :? (JsonValue array) as values ->
            values
            |> Array.collect JsonValue.ScalarValues
            |> Array.distinct
        | _ -> [||]

    member this.ScalarKeyValues =
        match box this with
        | :? (JsonValue array) as values ->
            values
            |> Array.collect JsonValue.ScalarKeyValues
            |> Array.distinct
        | _ -> [||]

    member this.PropertyKeys =
        match box this with
        | :? (JsonValue array) as values ->
            values
            |> Array.collect JsonValue.PropertyKeys
            |> Array.distinct
        | _ -> [||]

    member this.PropertyValues =
        match box this with
        | :? (JsonValue array) as values -> values |> Array.collect JsonValue.PropertyValues
        | _ -> [||]

    member this.GrandPropertyKeys =
        match box this with
        | :? (JsonValue array) as values ->
            values
            |> Array.collect JsonValue.GrandPropertyKeys
            |> Array.distinct
        | _ -> [||]

    member this.Kinds =
        match box this with
        | :? (JsonValue array) as values ->
            values
            |> Array.map JsonValue.Kind
            |> Array.distinct
        | _ -> [||]




(*

EdgeDevToolsProtocol.protocol.jsonschema.JsonValue.Kind

EdgeDevToolsProtocol.protocol.jsonschema.JsonValue.PropertyKeys
EdgeDevToolsProtocol.protocol.jsonschema.JsonValue?properties?domains.PropertyKeys
EdgeDevToolsProtocol.protocol.jsonschema.JsonValue?properties?domains?items?properties.PropertyKeys


EdgeDevToolsProtocol.protocol.json.JsonValue?domains.PropertyKeys
EdgeDevToolsProtocol.protocol.json.JsonValue?domains.Kind


let types = EdgeDevToolsProtocol.protocol.json.JsonValue?domains.AsArray ?> "types"



types
|> Array.collect JsonValue.PropertyKeys |> Array.distinct



EdgeDevToolsProtocol.protocol.json.JsonValue |> JsonPath.find "$.domains[].types[0].properties[8].name"
EdgeDevToolsProtocol.protocol.jsonschema.JsonValue?properties?domains.AsArray.Keys




EdgeDevToolsProtocol.protocol.json.JsonValue?domains.Keys ?> domain

let domain_items = EdgeDevToolsProtocol.protocol.json.JsonValue?domains.Keys

let domain_items =
    EdgeDevToolsProtocol.protocol.json.JsonValue?domains.JsonValues.Keys

domain_items |> Array.map (fun domain_item -> domain_item.Kind)

// |> Array.filter (fun domain_item -> domain_item.IsRecord)



*)
