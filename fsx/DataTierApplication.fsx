// TODO get other sql schemas
// https://schemas.microsoft.com/sqlserver/

#time on

fsi.PrintLength <- 10
fsi.PrintSize <- 100

// fsi.ShowDeclarationValues <- false
#I @"D:\https\com\github\eristocrates\ipa\dll"
#r "SharedKernel.dll"
#r "StringModule.dll"
#r "Internet.dll"
#r "TopLevelDomain.dll"
#r "IanaScheme.dll"
#r "ResourceIdentification.dll"
#r "ResourceDescription.dll"
#r "Iana.dll"
#r "IanaScheme.dll"
#r "IanaMime.dll"
#r "NetworkMonitor.dll"
#r "Turtle.dll"
#I @"D:\https\com\github\eristocrates\ipa\fsx"
#load "Ast.fsx"
open SharedKernel
open StringModule
open Internet
open ResourceIdentification
open ResourceDescription
open Turtle
open Iana
open NetworkMonitor
#I @"D:\https\com\github\eristocrates\ipa\fsx\Sites"

#load @".paket/load/main.group.fsx"
open PuppeteerSharp
open PuppeteerSharp.Cdp
open FolkerKinzel.MimeTypes
open System.Web
open IriTools
open System.Threading

open System
open System.Text
open CaseConverter

open Humanizer
open System.IO
open System.Linq
open PuppeteerSharp
open PuppeteerSharp.Cdp
open Tavis.UriTemplates
open BrowserApi.Css.Authoring
open BrowserApi.Css
open BrowserApi
open Meziantou.Framework
open System.Threading
open VDS.RDF
open FSharp.Data
open VDS.RDF.Parsing
open Universal.Common
open RDFSharp.Model
open AW.Identifiers
open LSL.DataUri

open System
open System.IO
open System.Threading

open Fabulous.AST
open Fantomas.Core
open FSharp.Data.Sql
open FSharp.Data.Sql.MsSql
open FSharp.Collections.ParallelSeq
// #r "nuget: Microsoft.SqlServer.DacFx"

open Microsoft.SqlServer.Dac
open Microsoft.SqlServer.Dac.Model

module FSharpLiteral = FSharp.Literals.Literal

type DataTierApplication = {
    applicationName: string
    applicationDescription: string
    connectionString: string
    dacpacFilePath: string
    databaseName: string
} with

    static member ModelLoadOptions =
        let options = ModelLoadOptions()
        options.LoadAsScriptBackedModel <- true
        options.ModelStorageType <- DacSchemaModelStorageType.Memory
        options
    static member ModelExtractOptions =
        let options = ModelExtractOptions()
        options.LoadAsScriptBackedModel <- true
        options.Storage <- DacSchemaModelStorageType.Memory
        options
    static member DacExtractOptions =
        let options = DacExtractOptions()
        options.ExtractAllTableData <- false
        options.ExtractReferencedServerScopedElements <- true
        options.ExtractUsageProperties <- true
        options
    static member BacExtractOptions =
        let options = DacExtractOptions()
        options.ExtractAllTableData <- true
        options.ExtractReferencedServerScopedElements <- true
        options.ExtractUsageProperties <- true
        options
    member this.ExtractDac() =
        let dacServices = new DacServices(this.connectionString)
        dacServices.Extract(
            targetPath = this.dacpacFilePath,
            databaseName = this.databaseName,
            applicationName = this.applicationName,
            applicationVersion = Version(0, 0, 1, 0),
            applicationDescription = this.applicationDescription,
            tables = null,
            extractOptions = DataTierApplication.DacExtractOptions,
            cancellationToken = Nullable<CancellationToken>()
        )
    member this.ExtractBac() =
        let dacServices = new DacServices(this.connectionString)
        dacServices.Extract(
            targetPath = this.dacpacFilePath,
            databaseName = this.databaseName,
            applicationName = this.applicationName,
            applicationVersion = Version(0, 0, 1, 0),
            applicationDescription = this.applicationDescription,
            tables = null,
            extractOptions = DataTierApplication.BacExtractOptions,
            cancellationToken = Nullable<CancellationToken>()
        )
    member this.LoadModel() =
        TSqlModel.LoadFromDacpac(this.dacpacFilePath, DataTierApplication.ModelLoadOptions)
    member this.ExtractModel() =
        TSqlModel.LoadFromDatabase(this.connectionString, DataTierApplication.ModelExtractOptions, Nullable<CancellationToken>())
type TSqlModel with

    member this.TableValuedFunctions =
        this.GetObjects(DacQueryScopes.All)
        |> Seq.toArray
        |> Array.Parallel.filter (fun modelObject -> modelObject.ObjectType.Name = "TableValuedFunction")

    member this.ScalarFunctions =
        this.GetObjects(DacQueryScopes.All)
        |> Seq.toArray
        |> Array.Parallel.filter (fun modelObject -> modelObject.ObjectType.Name = "ScalarFunction")

    member this.Indexes =
        this.GetObjects(DacQueryScopes.All)
        |> Seq.toArray
        |> Array.Parallel.filter (fun modelObject -> modelObject.ObjectType.Name = "Index")

    member this.CheckConstraints =
        this.GetObjects(DacQueryScopes.All)
        |> Seq.toArray
        |> Array.Parallel.filter (fun modelObject -> modelObject.ObjectType.Name = "CheckConstraint")

    member this.DatabaseOptionss =
        this.GetObjects(DacQueryScopes.All)
        |> Seq.toArray
        |> Array.Parallel.filter (fun modelObject -> modelObject.ObjectType.Name = "DatabaseOptions")

    member this.DefaultConstraints =
        this.GetObjects(DacQueryScopes.All)
        |> Seq.toArray
        |> Array.Parallel.filter (fun modelObject -> modelObject.ObjectType.Name = "DefaultConstraint")

    member this.DmlTriggers =
        this.GetObjects(DacQueryScopes.All)
        |> Seq.toArray
        |> Array.Parallel.filter (fun modelObject -> modelObject.ObjectType.Name = "DmlTrigger")

    member this.ExtendedPropertys =
        this.GetObjects(DacQueryScopes.All)
        |> Seq.toArray
        |> Array.Parallel.filter (fun modelObject -> modelObject.ObjectType.Name = "ExtendedProperty")

    member this.ForeignKeyConstraints =
        this.GetObjects(DacQueryScopes.All)
        |> Seq.toArray
        |> Array.Parallel.filter (fun modelObject -> modelObject.ObjectType.Name = "ForeignKeyConstraint")

    member this.Logins =
        this.GetObjects(DacQueryScopes.All)
        |> Seq.toArray
        |> Array.Parallel.filter (fun modelObject -> modelObject.ObjectType.Name = "Login")

    member this.PrimaryKeyConstraints =
        this.GetObjects(DacQueryScopes.All)
        |> Seq.toArray
        |> Array.Parallel.filter (fun modelObject -> modelObject.ObjectType.Name = "PrimaryKeyConstraint")

    member this.Procedures =
        this.GetObjects(DacQueryScopes.All)
        |> Seq.toArray
        |> Array.Parallel.filter (fun modelObject -> modelObject.ObjectType.Name = "Procedure")

    member this.Roles =
        this.GetObjects(DacQueryScopes.All)
        |> Seq.toArray
        |> Array.Parallel.filter (fun modelObject -> modelObject.ObjectType.Name = "Role")

    member this.RoleMemberships =
        this.GetObjects(DacQueryScopes.All)
        |> Seq.toArray
        |> Array.Parallel.filter (fun modelObject -> modelObject.ObjectType.Name = "RoleMembership")

    member this.Schemas =
        this.GetObjects(DacQueryScopes.All)
        |> Seq.toArray
        |> Array.Parallel.filter (fun modelObject -> modelObject.ObjectType.Name = "Schema")

    member this.SchemasByName =
        this.Schemas
        |> Array.map (fun table -> table.Name.Parts |> Seq.last, table)
        |> Map.ofArray

    member this.Statisticss =
        this.GetObjects(DacQueryScopes.All)
        |> Seq.toArray
        |> Array.Parallel.filter (fun modelObject -> modelObject.ObjectType.Name = "Statistics")

    member this.Synonyms =
        this.GetObjects(DacQueryScopes.All)
        |> Seq.toArray
        |> Array.Parallel.filter (fun modelObject -> modelObject.ObjectType.Name = "Synonym")

    member this.Tables =
        this.GetObjects(DacQueryScopes.All)
        |> Seq.toArray
        |> Array.Parallel.filter (fun modelObject -> modelObject.ObjectType.Name = "Table")

    member this.TablesByName =
        this.Tables
        |> Array.map (fun table -> table.Name.Parts |> Seq.last, table)
        |> Map.ofArray

    member this.TableTypes =
        this.GetObjects(DacQueryScopes.All)
        |> Seq.toArray
        |> Array.Parallel.filter (fun modelObject -> modelObject.ObjectType.Name = "TableType")

    member this.UniqueConstraints =
        this.GetObjects(DacQueryScopes.All)
        |> Seq.toArray
        |> Array.Parallel.filter (fun modelObject -> modelObject.ObjectType.Name = "UniqueConstraint")

    member this.Users =
        this.GetObjects(DacQueryScopes.All)
        |> Seq.toArray
        |> Array.Parallel.filter (fun modelObject -> modelObject.ObjectType.Name = "User")

    member this.Views =
        this.GetObjects(DacQueryScopes.All)
        |> Seq.toArray
        |> Array.Parallel.filter (fun modelObject -> modelObject.ObjectType.Name = "View")

    member this.ViewsByName =
        this.Views
        |> Array.map (fun table -> table.Name.Parts |> Seq.last, table)
        |> Map.ofArray

type ObjectIdentifier with
    member this.segments = this.Parts |> Seq.toArray

    member this.escapedSegments = this.segments |> Array.map (fun segment -> $"[{segment}]")

    member this.fullyQualified = this.segments |> String.concat "."
    member this.escapedFullyQualified = this.escapedSegments |> String.concat "."

    member this.simple =
        if this.segments.Length > 0 then
            this.segments |> Array.last
        else
            String.Empty

type ModelTypeClass with
    member this.relationships = this.Relationships |> Seq.toArray
    member this.properties = this.Properties |> Seq.toArray
    member this.peerRelationships =
        this.relationships
        |> Array.filter (fun relationship -> relationship.Type = RelationshipType.Peer)
    member this.composingRelationships =
        this.relationships
        |> Array.filter (fun relationship -> relationship.Type = RelationshipType.Composing)
    member this.hierarchicalRelationships =
        this.relationships
        |> Array.filter (fun relationship -> relationship.Type = RelationshipType.Hierarchical)

type Model.TSqlObject with
    member this.children = this.GetChildren() |> Seq.toArray
    member this.referencedRelationships = this.GetReferencedRelationshipInstances() |> Seq.toArray
    member this.referencingRelationships = this.GetReferencingRelationshipInstances() |> Seq.toArray

type Schema.Column with
    member this.asSystemType = Type.GetType(this.TypeMapping.ClrType)
    member this.FSharpType = FSharpLiteral.stringifyTypeDynamic this.asSystemType

[<RequireQualifiedAccess>]
type SqlType =
    | datetime of DateTime
    | datetimeOption of DateTime option
    | sqlint of int
    | sqlintOption of int option
    | smallmoney of decimal
    | smallmoneyOption of decimal option
    | money of decimal
    | moneyOption of decimal option
    | float of float
    | floatOption of float option
    | bit of bool
    | bitOption of bool option
    | nvarchar of string
    | nvarcharOption of string option
    | varchar of string
    | varcharOption of string option
    | unrecognized of obj

    static member asObject(sqlValue: SqlType) : obj =
        match sqlValue with
        | datetime value -> (box value)
        | datetimeOption (Some value) -> (box value)
        | sqlint value -> (box value)
        | sqlintOption (Some value) -> (box value)
        | smallmoney value -> (box value)
        | smallmoneyOption (Some value) -> (box value)
        | money value -> (box value)
        | moneyOption (Some value) -> (box value)
        | float value -> (box value)
        | floatOption (Some value) -> (box value)
        | bit value -> (box value)
        | bitOption (Some value) -> (box value)
        | nvarchar value -> (box value)
        | nvarcharOption (Some value) -> (box value)
        | varchar value -> (box value)
        | varcharOption (Some value) -> (box value)
        | unrecognized value when not (isNull value) -> Some value
        | _ -> None
    static member asDateTime(sqlValue: SqlType) =
        match sqlValue with
        | datetime value -> value
    static member asDateTimeOption(sqlValue: SqlType) =
        match sqlValue with
        | datetimeOption value -> value
    static member asInt32(sqlValue: SqlType) =
        match sqlValue with
        | sqlint value -> value

    static member asInt32Option(sqlValue: SqlType) =
        match sqlValue with
        | sqlintOption value -> value
    static member asDouble(sqlValue: SqlType) =
        match sqlValue with
        | float value -> value
    static member asDoubleOption(sqlValue: SqlType) =
        match sqlValue with
        | floatOption value -> value

    static member asDecimal(sqlValue: SqlType) =
        match sqlValue with
        | smallmoney value -> value
        | money value -> value

    static member asDecimalOption(sqlValue: SqlType) =
        match sqlValue with
        | smallmoneyOption value -> value
        | moneyOption value -> value

    static member asBoolean(sqlValue: SqlType) =
        match sqlValue with
        | bit value -> value

    static member asBooleanOption(sqlValue: SqlType) =
        match sqlValue with
        | bitOption value -> value

    static member asString(sqlValue: SqlType) =
        match sqlValue with
        | nvarchar value -> value
        | varchar value -> value

    static member asStringOption(sqlValue: SqlType) =
        match sqlValue with
        | nvarcharOption value -> value
        | varcharOption value -> value

    static member tryValue<'Value>(valueObject: obj) =
        let maybeValue =
            try
                Option.ofNullOrWhiteSpace valueObject
            with err ->
                printfn "tryValue<%s> %O errored with %s" (typeof<'Value>.Name) valueObject err.Message
                None
        maybeValue |> Option.map (fun valueObj -> unbox<'Value> valueObj)
    static member value<'Value>(valueObject: obj) =
        SqlType.tryValue<'Value> valueObject |> Option.get
module SqlType =
    let Parse (schema: Schema.Column) (isOption: bool) (valueObject: obj) =

        match schema.TypeInfo with
        | ValueSome "datetime" when isOption = true -> SqlType.tryValue<DateTime> valueObject |> SqlType.datetimeOption
        | ValueSome "datetime" when isOption = false -> SqlType.value<DateTime> valueObject |> SqlType.datetime
        | ValueSome "int" when isOption = true -> SqlType.tryValue<int> valueObject |> SqlType.sqlintOption
        | ValueSome "int" when isOption = false -> SqlType.value<int> valueObject |> SqlType.sqlint
        | ValueSome "smallmoney" when isOption = true -> SqlType.tryValue<decimal> valueObject |> SqlType.smallmoneyOption
        | ValueSome "smallmoney" when isOption = false -> SqlType.value<decimal> valueObject |> SqlType.smallmoney
        | ValueSome "money" when isOption = true -> SqlType.tryValue<decimal> valueObject |> SqlType.moneyOption
        | ValueSome "money" when isOption = false -> SqlType.value<decimal> valueObject |> SqlType.money
        | ValueSome "float" when isOption = true -> SqlType.tryValue<float> valueObject |> SqlType.floatOption
        | ValueSome "float" when isOption = false -> SqlType.value<float> valueObject |> SqlType.float
        | ValueSome "float" when isOption = true -> SqlType.tryValue<double> valueObject |> SqlType.floatOption
        | ValueSome "float" when isOption = false -> SqlType.value<double> valueObject |> SqlType.float
        | ValueSome "bit" when isOption = true -> SqlType.tryValue<bool> valueObject |> SqlType.bitOption
        | ValueSome "bit" when isOption = false -> SqlType.value<bool> valueObject |> SqlType.bit
        | ValueSome typeInfo when typeInfo.StartsWith("nvarchar") && isOption = true -> SqlType.tryValue<string> valueObject |> SqlType.nvarcharOption
        | ValueSome typeInfo when typeInfo.StartsWith("nvarchar") && isOption = false -> SqlType.value<string> valueObject |> SqlType.nvarchar
        | ValueSome typeInfo when typeInfo.StartsWith("varchar") && isOption = true -> SqlType.tryValue<string> valueObject |> SqlType.varcharOption
        | ValueSome typeInfo when typeInfo.StartsWith("varchar") && isOption = false -> SqlType.value<string> valueObject |> SqlType.varchar
        | _ -> SqlType.unrecognized valueObject

type Common.SqlEntity with
    member this.columnNames =
        this.ColumnValuesWithDefinition
        |> Seq.map (fun (columnName, columnValue, columnDefinition) -> columnName)
        |> Seq.toArray
    member this.valueByColumnName =
        this.ColumnValuesWithDefinition
        |> Seq.map (fun (columnName, columnValue, columnDefinition) -> columnName, columnValue)
        |> Map.ofSeq
    member this.columnDefinitions =
        this.ColumnValuesWithDefinition
        |> Seq.map (fun (columnName, columnValue, columnDefinition) -> columnDefinition.Value)
        |> Seq.toArray
    member this.valueObjectByColumn =
        this.ColumnValuesWithDefinition
        |> Seq.map (fun (columnName, columnValue, columnDefinition) -> columnName, columnValue)
        |> Map.ofSeq

type SqlColumn = {
    schema: Schema.Column
    isOption: bool
    values: SqlType array
} with

    static member optionExists(valueObjects: obj array) =
        valueObjects
        |> Array.exists (fun valueObject ->
            match Option.ofNullOrWhiteSpace valueObject with
            | None -> true
            | _ -> false)

type SqlTable(schemaName: string, tableName: string, sqlEntities: Common.SqlEntity array) =
    let _columnNames = sqlEntities[0].columnNames
    let _columnDefinitions = sqlEntities[0].columnDefinitions
    let _columnValueObjects =
        _columnNames
        |> Array.Parallel.map (fun columnName ->
            columnName,
            sqlEntities
            |> Array.Parallel.map (fun entity -> entity.valueByColumnName[columnName])
            |> Array.distinctBy (fun valueObject -> string valueObject))
    let _columns = [|
        for columnIndex = 0 to _columnNames.Length - 1 do
            let columnName, valueObjects = _columnValueObjects[columnIndex]
            let columnDefinition = _columnDefinitions[columnIndex]
            let isOption = SqlColumn.optionExists valueObjects
            let values =
                valueObjects
                |> Array.map (fun valueObject -> valueObject |> SqlType.Parse columnDefinition isOption)
            {
                schema = columnDefinition
                values = values
                isOption = isOption

            }
    |]
    member this.schemaName = schemaName
    member this.tableName = tableName
    member this.sqlEntities = sqlEntities
    member this.columnNames = _columnNames
    member this.columnDefinitions = _columnDefinitions
    member this.columnValueObjects = _columnValueObjects
    member this.valueObjectsByColumn = this.columnValueObjects |> Map.ofArray
    member this.columns = _columns
    member this.columnsByName = _columns |> Array.map (fun column -> column.schema.Name, column) |> Map.ofArray
    member this.tryPrimaryKey = this.columns |> Array.tryFind (fun column -> column.schema.IsPrimaryKey)
    member this.nullableColumns = this.columns |> Array.filter (fun column -> column.schema.IsNullable)
    member this.defaultValueColumns = this.columns |> Array.filter (fun column -> column.schema.HasDefault)
    member this.valueOptionColumns = this.columns |> Array.filter (fun column -> column.isOption)
    member this.valueColumns = this.columns |> Array.filter (fun column -> not column.isOption)
    member this.datetimeColumns =
        this.columns
        |> Array.filter (fun column -> column.schema.TypeInfo.Value = "datetime")
    member this.intColumns =
        this.columns
        |> Array.filter (fun column -> column.schema.TypeInfo.Value = "int")
    member this.smallmoneyColumns =
        this.columns
        |> Array.filter (fun column -> column.schema.TypeInfo.Value = "smallmoney")
    member this.moneyColumns =
        this.columns
        |> Array.filter (fun column -> column.schema.TypeInfo.Value = "money")
    member this.floatColumns =
        this.columns
        |> Array.filter (fun column -> column.schema.TypeInfo.Value = "float")
    member this.bitColumns =
        this.columns
        |> Array.filter (fun column -> column.schema.TypeInfo.Value = "bit")
    member this.nvarcharColumns =
        this.columns
        |> Array.filter (fun column -> column.schema.TypeInfo.Value.StartsWith "nvarchar")
    member this.varcharColumns =
        this.columns
        |> Array.filter (fun column -> column.schema.TypeInfo.Value.StartsWith "varchar")
    member this.unrecognizedTypeColumns =
        this.columns
        |> Array.filter (fun column ->
            match column.schema.TypeInfo.Value with
            | "datetime"
            | "int"
            | "smallmoney"
            | "money"
            | "float"
            | "bit" -> false
            | typeInfo when typeInfo.EndsWith("nvarchar") -> false
            | typeInfo when typeInfo.StartsWith("nvarchar") -> false
            | typeInfo when typeInfo.StartsWith("varchar") -> false
            | _ -> true)

    member this.asAstModule =
        let recordName = tableName.Singularize()
        let bindingName = tableName.ToLowerInvariant()
        let entitiesName = $"{recordName.ToLowerInvariant()}Entities"

        let recordExpr =
            Ast.RecordExpr(
                [
                    for column in _columns do
                        let typeName =
                            match column.values[0] with
                            | SqlType.datetime _ -> "DateTime"
                            | SqlType.datetimeOption _ -> "DateTimeOption"
                            | SqlType.sqlint _ -> "Int32"
                            | SqlType.sqlintOption _ -> "Int32Option"
                            | SqlType.smallmoney _ -> "Decimal"
                            | SqlType.smallmoneyOption _ -> "DecimalOption"
                            | SqlType.money _ -> "Decimal"
                            | SqlType.moneyOption _ -> "DecimalOption"
                            | SqlType.float _ -> "Double"
                            | SqlType.floatOption _ -> "DoubleOption"
                            | SqlType.bit _ -> "Boolean"
                            | SqlType.bitOption _ -> "BooleanOption"
                            | SqlType.nvarchar _ -> "String"
                            | SqlType.nvarcharOption _ -> "StringOption"
                            | SqlType.varchar _ -> "String"
                            | SqlType.varcharOption _ -> "StringOption"
                            | _ -> "Object"

                        let columnName = column.schema.Name

                        let expression =
                            $"""sqlEntity.valueObjectByColumn["{columnName}"] |> SqlType.Parse {tableName}Table.columnsByName["{columnName}"].schema {tableName}Table.columnsByName["{columnName}"].isOption |> SqlType.as{typeName}"""

                        Ast.RecordFieldExpr(columnName, expression)
                ]
            )

        let entitiesExpr = Ast.InfixAppExpr(entitiesName, "|>", Ast.AppWithLambdaExpr(Ast.ConstantExpr("Array.map"), [ Ast.ConstantPat("sqlEntity") ], recordExpr))

        Ast.Oak() {
            Ast.AnonymousModule() {
                Ast.Record(recordName) {
                    for column in _columns do
                        let typeName =
                            if column.isOption then
                                $"{column.schema.FSharpType} option"
                            else
                                column.schema.FSharpType

                        Ast.Field(column.schema.Name, typeName)
                }

                Ast.Value(bindingName, entitiesExpr)
            }
        }
        |> Gen.mkOak
        |> Gen.run
