#time on
fsi.PrintLength <- 10

open System
open System.IO
open System.Xml.Linq
open System.Xml.Linq

#r "nuget: SQLProvider.MsSql, 1.5.18"

open FSharp.Data.Sql
open FSharp.Data.Sql.MsSql

#r "nuget: FSharp.Data"
open FSharp.Data

#load @"C:\Secret\InforSecrets.fsx"

open InforSecrets

#load @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\Ergonomics\PowershellErgonomics.fsx"

open PowershellErgonomics


open System.Linq

#r "nuget: FSharp.Collections.ParallelSeq"
open FSharp.Collections.ParallelSeq


#r "nuget: Microsoft.SqlServer.DacFx"

open Microsoft.SqlServer.Dac
open Microsoft.SqlServer.Dac.Model

#r "nuget: FSharp.Literals, 2.2.15"
module FSharpLiteral = FSharp.Literals.Literal

#r "nuget: Fabulous.AST"

open Fabulous.AST
open Fantomas.Core

type Option<'Type> with
    static member ofNullOrWhiteSpace(value: 'Type) =
        if String.IsNullOrWhiteSpace(string value) then
            None
        else
            Some value

    static member tryNullOrWhiteSpace(maybeValue: 'Type option) =
        match maybeValue with
        | Some value when String.IsNullOrWhiteSpace(string value) -> None
        | None -> None
        | Some value -> Some value

module HansenDataDistribution =
    [<Literal>]
    let xmlFilePath =
        @"D:/Surface/Company/Infor/Download_Center/Product/Operations_and_Regulations/Release/Infor_Public_Sector_2025_04_01/IPS_2025_04_01/Deployment Files/MetaData/MetaData.xml"

    let xmlFile = new FileInfo(xmlFilePath)
    type Provider = XmlProvider<UseOriginalNames=true, Sample=xmlFilePath>

module InforProd =
    module Xml =
        let hansenMetadata =
            HansenDataDistribution.Provider.Load(HansenDataDistribution.xmlFilePath).hansenMetadata

        let productFamilies = hansenMetadata.productFamilies

        let productFamilieByName =
            productFamilies
            |> Array.map (fun productFamily -> productFamily.name, productFamily)
            |> Map.ofArray

        let domainColumns = hansenMetadata.domainColumns

        let domainColumnByName =
            domainColumns
            |> Array.map (fun domainColumn -> domainColumn.name, domainColumn)
            |> Map.ofArray

        let domainColumnByDatabaseName =
            domainColumns
            |> Array.map (fun domainColumn -> domainColumn.databaseName, domainColumn)
            |> Map.ofArray

        let tables =
            productFamilies |> Array.collect (fun productFamily -> productFamily.tables)

        let tableByName =
            tables |> Array.map (fun table -> table.name, table) |> Map.ofArray

        let tableByDatabaseName =
            tables |> Array.map (fun table -> table.databaseName, table) |> Map.ofArray

        let columns = tables |> Array.collect (fun table -> table.columns)

        let columnByName =
            columns |> Array.map (fun column -> column.name, column) |> Map.ofArray

        let columnByDatabaseName =
            columns |> Array.map (fun column -> column.databaseName, column) |> Map.ofArray

    module Sql =
        type Provider =
            SqlDataProvider<
                IndividualsAmount=1000,
                UseOptionTypes=Common.NullableColumnType.OPTION,
                CaseSensitivityChange=Common.CaseSensitivityChange.ORIGINAL,
                SsdtPath=Prod.dapac,
                ConnectionString=Prod.connectionString
             >

        let serverData = Provider.GetDataContext()
        let serverMetadata = Provider.GetReadOnlyDataContext()
        let dataContext = (box serverData) :?> Common.ISqlDataContext

    module TSql =
        let model =
            let options = ModelLoadOptions()

            options.LoadAsScriptBackedModel <- true
            options.ModelStorageType <- DacSchemaModelStorageType.Memory

            TSqlModel.LoadFromDacpac(Prod.dapac, options)

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




(*
type Model.ObjectIdentifier with
    member this.display =
        InforProd.TSql.model.DisplayServices.GetDisplayName(this, Model.EscapeStyle.EscapeIfNecessary, false)

    member this.fullDisplay =
        InforProd.TSql.model.DisplayServices.GetDisplayName(this, Model.EscapeStyle.EscapeIfNecessary, true)

type Model.TSqlObject with
    member this.simpleName =
        InforProd.TSql.model.DisplayServices.GetElementName(this, Model.ElementNameStyle.SimpleName)

    member this.escapedSimpleName =
        InforProd.TSql.model.DisplayServices.GetElementName(this, Model.ElementNameStyle.EscapedSimpleName)

    member this.fullyQualifiedName =
        InforProd.TSql.model.DisplayServices.GetElementName(this, Model.ElementNameStyle.FullyQualifiedName)

    member this.escapedFullyQualifiedName =
        InforProd.TSql.model.DisplayServices.GetElementName(this, Model.ElementNameStyle.EscapedFullyQualifiedName)

*)

type ObjectIdentifier with
    member this.segments = this.Parts |> Seq.toArray

    member this.escapedSegments =
        this.segments |> Array.map (fun segment -> $"[{segment}]")

    member this.fullyQualified = this.segments |> String.concat "."
    member this.escapedFullyQualified = this.escapedSegments |> String.concat "."

    member this.simple =
        if this.segments.Length > 0 then
            this.segments |> Array.last
        else
            String.Empty

    member this.schemaPart =
        match this.segments with
        | [| schema |] -> schema
        | _ -> String.Empty

    member this.tablePart =
        match this.segments with
        | [| schema; table |] -> table
        | _ -> String.Empty

    member this.columnPart =

        match this.segments with
        | [| schema; table; column |] -> column
        | _ -> String.Empty

let nameCounts =
    InforProd.TSql.model.Tables
    |> Array.Parallel.map (fun table -> table.Name.Parts.Count())
    |> Array.distinct

let testTable = InforProd.TSql.model.Tables |> Array.randomChoice
testTable.Name.Parts |> String.concat "."












let clipDistinctAttributes (elementName: string) (attributes: string array) =
    attributes
    |> Array.map (fun attribute ->
        """    sprintf "%s : %s" """
        + $"(nameof({elementName}.{attribute})) (  {elementName}.{attribute}.GetType() |> FSharpLiteral.stringifyTypeDynamic)")
    |> String.concat "\n"
    |> clip
(*

let productFamily = InforProd.Xml.hansenMetadata.productFamilies[0]
[|

    sprintf "%s : %s" (nameof(productFamily.isAgencyEnhancable)) (  productFamily.isAgencyEnhancable.GetType() |> FSharpLiteral.stringifyTypeDynamic)
    sprintf "%s : %s" (nameof(productFamily.isHansen)) (  productFamily.isHansen.GetType() |> FSharpLiteral.stringifyTypeDynamic)
    sprintf "%s : %s" (nameof(productFamily.name)) (  productFamily.name.GetType() |> FSharpLiteral.stringifyTypeDynamic)
    sprintf "%s : %s" (nameof(productFamily.owner)) (  productFamily.owner.GetType() |> FSharpLiteral.stringifyTypeDynamic)
    sprintf "%s : %s" (nameof(productFamily.requiredSystemLicense)) (  productFamily.requiredSystemLicense.GetType() |> FSharpLiteral.stringifyTypeDynamic)
    sprintf "%s : %s" (nameof(productFamily.tables)) (  productFamily.tables.GetType() |> FSharpLiteral.stringifyTypeDynamic)

|]
|> String.concat "\n"
|> clip

*)
type InforProductFamily =
    { isAgencyEnhancable: bool
      isHansen: bool
      name: string
      owner: string
      requiredSystemLicense: InforSystemLicense option }

(*
let systemLicense = InforProd.Xml.hansenMetadata.systemLicenses[0]
[|

    sprintf "%s : %s" (nameof(systemLicense.name)) (  systemLicense.name.GetType() |> FSharpLiteral.stringifyTypeDynamic)
    sprintf "%s : %s" (nameof(systemLicense.description)) (  systemLicense.description.GetType() |> FSharpLiteral.stringifyTypeDynamic)
    sprintf "%s : %s" (nameof(systemLicense.effectiveDateTime)) (  systemLicense.effectiveDateTime.GetType() |> FSharpLiteral.stringifyTypeDynamic)
    sprintf "%s : %s" (nameof(systemLicense.expiredDateTime)) (  systemLicense.expiredDateTime.GetType() |> FSharpLiteral.stringifyTypeDynamic)

|]
|> String.concat "\n"
|> clip

*)

and InforSystemLicense =
    { name: string
      description: option<string>
      effectiveDateTime: option<DateTime>
      expiredDateTime: option<DateTime> }
(*
let tableAttributes = 
    InforProd.Xml.hansenMetadata.productFamilies[0].tables
    |> Array.collect (fun table -> 
        Array.concat [|
            table.XElement.Attributes() |>  Array.map (fun attribute -> attribute.Name.LocalName)
            table.text.XElement.Attributes() |> Seq. Array.map (fun attribute -> $"text.{attribute.Name.LocalName}")
            |]
    )
    |> Array.distinct
    |> Array.map (fun attribute ->  
        match attribute with 
        | "type" -> "``type``"
        | _ -> attribute)

clipDistinctAttributes "table" tableAttributes
let table = InforProd.Xml.hansenMetadata.productFamilies[0].tables[0]
[|

    sprintf "%s : %s" (nameof(table.name)) (  table.name.GetType() |> FSharpLiteral.stringifyTypeDynamic)
    sprintf "%s : %s" (nameof(table.databaseName)) (  table.databaseName.GetType() |> FSharpLiteral.stringifyTypeDynamic)
    sprintf "%s : %s" (nameof(table.hasNullRecord)) (  table.hasNullRecord.GetType() |> FSharpLiteral.stringifyTypeDynamic)
    sprintf "%s : %s" (nameof(table.``type``)) (  table.``type``.GetType() |> FSharpLiteral.stringifyTypeDynamic)
    sprintf "%s : %s" (nameof(table.deploymentStatus)) (  table.deploymentStatus.GetType() |> FSharpLiteral.stringifyTypeDynamic)
    sprintf "%s : %s" (nameof(table.isLicensed)) (  table.isLicensed.GetType() |> FSharpLiteral.stringifyTypeDynamic)
    sprintf "%s : %s" (nameof(table.text.locale)) (  table.text.locale.GetType() |> FSharpLiteral.stringifyTypeDynamic)
    sprintf "%s : %s" (nameof(table.text.description)) (  table.text.description.GetType() |> FSharpLiteral.stringifyTypeDynamic)
    sprintf "%s : %s" (nameof(table.text.remarks)) (  table.text.remarks.GetType() |> FSharpLiteral.stringifyTypeDynamic)


|]
|> String.concat "\n"
|> clip

*)

and InforTable =
    { productFamily: InforProductFamily
      name: string
      databaseName: string
      hasNullRecord: bool
      ``type``: string
      deploymentStatus: string
      isLicensed: bool
      locale: string option
      description: option<string>
      remarks: option<string> }
(*

let columnAttributes = 
    InforProd.Xml.hansenMetadata.productFamilies |> Array.collect (fun productFamily -> 
        productFamily.tables |> Array.collect (fun table -> 
            table.columns |> Array.collect (fun column -> 
            Array.concat [|
                column.XElement.Attributes() |>  Seq.toArray |> Array.map (fun attribute -> attribute.Name.LocalName)
                column.text.XElement.Attributes() |> Seq.toArray |> Array.map (fun attribute -> $"text.{attribute.Name.LocalName}")
                |]
        )
        )
    )
    |> Array.distinct

clipDistinctAttributes "column" columnAttributes

let column = InforProd.Xml.hansenMetadata.productFamilies[0].tables[0].columns[0]
[|
    sprintf "%s : %s" (nameof(column.name)) (  column.name.GetType() |> FSharpLiteral.stringifyTypeDynamic)
    sprintf "%s : %s" (nameof(column.isNullable)) (  column.isNullable.GetType() |> FSharpLiteral.stringifyTypeDynamic)
    sprintf "%s : %s" (nameof(column.databaseName)) (  column.databaseName.GetType() |> FSharpLiteral.stringifyTypeDynamic)
    sprintf "%s : %s" (nameof(column.defaultValue)) (  column.defaultValue.GetType() |> FSharpLiteral.stringifyTypeDynamic)
    sprintf "%s : %s" (nameof(column.length)) (  column.length.GetType() |> FSharpLiteral.stringifyTypeDynamic)
    sprintf "%s : %s" (nameof(column.isRequired)) (  column.isRequired.GetType() |> FSharpLiteral.stringifyTypeDynamic)
    sprintf "%s : %s" (nameof(column.``type``)) (  column.``type``.GetType() |> FSharpLiteral.stringifyTypeDynamic)
    sprintf "%s : %s" (nameof(column.dataScale)) (  column.dataScale.GetType() |> FSharpLiteral.stringifyTypeDynamic)
    sprintf "%s : %s" (nameof(column.dataPrecision)) (  column.dataPrecision.GetType() |> FSharpLiteral.stringifyTypeDynamic)
    sprintf "%s : %s" (nameof(column.showSearchOrder)) (  column.showSearchOrder.GetType() |> FSharpLiteral.stringifyTypeDynamic)
    sprintf "%s : %s" (nameof(column.useSearchOrder)) (  column.useSearchOrder.GetType() |> FSharpLiteral.stringifyTypeDynamic)
    sprintf "%s : %s" (nameof(column.locale)) (  column.locale.GetType() |> FSharpLiteral.stringifyTypeDynamic)
    sprintf "%s : %s" (nameof(column.text.locale)) (  column.text.locale.GetType() |> FSharpLiteral.stringifyTypeDynamic)
    sprintf "%s : %s" (nameof(column.text.description)) (  column.text.description.GetType() |> FSharpLiteral.stringifyTypeDynamic)
    sprintf "%s : %s" (nameof(column.text.remarks)) (  column.text.remarks.GetType() |> FSharpLiteral.stringifyTypeDynamic)
    sprintf "%s : %s" (nameof(column.text.displayDescription)) (  column.text.displayDescription.GetType() |> FSharpLiteral.stringifyTypeDynamic)
    sprintf "%s : %s" (nameof(column.text.displayTitle)) (  column.text.displayTitle.GetType() |> FSharpLiteral.stringifyTypeDynamic)
    sprintf "%s : %s" (nameof(column.text.displayTitleLong)) (  column.text.displayTitleLong.GetType() |> FSharpLiteral.stringifyTypeDynamic)
|]
|> String.concat "\n"
|> clip
*)
and InforColumn =
    { isPrimaryKey: bool
      isDomainColumn: bool
      table: InforTable
      name: string
      isNullable: bool
      databaseName: string
      defaultValue: option<string>
      length: int
      isRequired: bool
      ``type``: string
      dataScale: int
      dataPrecision: int
      showSearchOrder: int
      useSearchOrder: int
      locale: option<string>
      description: option<string>
      remarks: option<string>
      displayDescription: option<string>
      displayTitle: option<string>
      displayTitleLong: option<string>
      schemaColumn: Schema.Column }

and InforDomainColumnReference = unit
and InforEnumerationCheckConstraint = unit
and InforForeignKeyConstraint = unit
and InforIndex = unit
and InforPrimaryKeyConstraint = unit
and InforReferencingConstraint = unit
and InforRequiredSystemLicense = unit
and InforTableCheckConstraint = unit
and InforUniqueConstraint = unit

type InforSystemLicense with
    static member all =
        InforProd.Xml.hansenMetadata.systemLicenses
        |> Array.map (fun systemLicense ->

            { name = systemLicense.name
              description = Option.tryNullOrWhiteSpace systemLicense.description
              effectiveDateTime = Option.tryNullOrWhiteSpace systemLicense.effectiveDateTime
              expiredDateTime =
                match DateTime.TryParse systemLicense.expiredDateTime with
                | true, dateTime -> Some dateTime
                | _ -> None })

    static member fromName =
        InforSystemLicense.all
        |> Array.map (fun systemLicense -> systemLicense.name, systemLicense)
        |> Map.ofArray



type InforProductFamily with


    static member all =
        InforProd.Xml.hansenMetadata.productFamilies
        |> Array.map (fun productFamily ->
            {

              isAgencyEnhancable = productFamily.isAgencyEnhancable
              isHansen = productFamily.isHansen
              name = productFamily.name
              owner = productFamily.owner
              requiredSystemLicense =
                productFamily.requiredSystemLicense
                |> Option.map (fun systemLicense -> InforSystemLicense.fromName[systemLicense.name]) })

    static member byOwner'Name =
        InforProductFamily.all
        |> Array.map (fun productFamily -> (productFamily.owner, productFamily.name), productFamily)
        |> Map.ofArray

    member this.moniker = $"{this.owner}.{this.name}"

    static member byMoniker =
        InforProductFamily.all
        |> Array.map (fun productFamily -> productFamily.moniker, productFamily)
        |> Map.ofArray

    member this.databaseSchema =
        match this.name with
        | "MetaData" -> InforProd.TSql.model.SchemasByName[this.name]
        | _ -> InforProd.TSql.model.SchemasByName[this.name.ToUpperInvariant().Replace('.', '_')]

    static member bySchema =
        InforProductFamily.all
        |> Array.map (fun productFamily -> productFamily.databaseSchema.Name.simple, productFamily)
        |> Map.ofArray

    member this.tables =
        InforProd.Xml.hansenMetadata.productFamilies
        |> Array.filter (fun productFamily -> productFamily.name = this.name)
        |> Array.collect (fun productFamily ->
            productFamily.tables
            |> Array.map (fun table ->

                { productFamily = this
                  name = table.name
                  databaseName = table.databaseName
                  hasNullRecord = table.hasNullRecord
                  ``type`` = table.``type``
                  deploymentStatus = table.deploymentStatus
                  isLicensed = table.isLicensed
                  locale = Option.ofNullOrWhiteSpace table.text.locale
                  description = Option.tryNullOrWhiteSpace table.text.description
                  remarks = Option.tryNullOrWhiteSpace table.text.remarks }))

type InforTable with
    static member all =
        InforProductFamily.all
        |> Array.collect (fun productFamily -> productFamily.tables)

    static member byOwner'ProductFamily'Name =
        InforTable.all
        |> Array.map (fun table -> (table.productFamily.owner, table.productFamily.name, table.name), table)
        |> Map.ofArray

    member this.moniker =
        $"{this.productFamily.owner}.{this.productFamily.name}.{this.name}"

    static member byMoniker =
        InforTable.all |> Array.map (fun table -> table.moniker, table) |> Map.ofArray

    static member bySchema'DatabaseName =
        InforTable.all
        |> Array.map (fun table -> (table.productFamily.databaseSchema.Name.simple, table.databaseName), table)
        |> Map.ofArray
    // member this.columns =
    // member this.domainColumnReferences =
    // member this.enumerationCheckConstraints =
    // member this.foreignKeyConstraints =
    // member this.indexes =
    // member this.primaryKeyConstraints =
    // member this.referencingConstraints =
    // member this.requiredSystemLicenses =
    // member this.tableCheckConstraints =
    // member this.uniqueConstraints =
    member this.tsqlTable = InforProd.TSql.model.TablesByName[this.databaseName]

    member this.sqlEntities =
        InforProd.Sql.dataContext.CreateEntities(this.tsqlTable.Name.fullyQualified)

    member this.rows = this.sqlEntities |> Seq.toArray

    member this.schemaColumns =
        if this.sqlEntities.Count() > 0 then
            this.sqlEntities
            |> Seq.head
            |> _.ColumnValuesWithDefinition
            |> Seq.choose (fun (columnName, columnValue, column) -> column)
            |> Seq.toArray
        else
            [||]


    member this.columns =
        this.schemaColumns
        |> Array.choose (fun schemaColumn ->
            match
                InforProd.Xml.domainColumnByDatabaseName.TryFind schemaColumn.Name,
                InforProd.Xml.columnByDatabaseName.TryFind schemaColumn.Name
            with
            | Some domainColumn, None ->
                Some
                    { name = domainColumn.name
                      table = this
                      databaseName = domainColumn.name
                      isPrimaryKey = false
                      isDomainColumn = true
                      isNullable = domainColumn.isNullable
                      defaultValue = Option.tryNullOrWhiteSpace domainColumn.defaultValue
                      length = domainColumn.length
                      isRequired = domainColumn.isRequired
                      ``type`` = domainColumn.``type``
                      dataScale = domainColumn.dataScale
                      dataPrecision = domainColumn.dataPrecision
                      showSearchOrder = domainColumn.showSearchOrder
                      useSearchOrder = domainColumn.useSearchOrder
                      locale = Option.ofNullOrWhiteSpace domainColumn.locale
                      description = Option.ofNullOrWhiteSpace domainColumn.text.description
                      remarks = Option.tryNullOrWhiteSpace domainColumn.text.remarks
                      displayDescription = Option.tryNullOrWhiteSpace domainColumn.text.displayDescription
                      displayTitle = Option.tryNullOrWhiteSpace domainColumn.text.displayTitle
                      displayTitleLong = Option.tryNullOrWhiteSpace domainColumn.text.displayTitleLong
                      schemaColumn = schemaColumn }
            | None, Some tableColumn ->
                Some
                    { name = tableColumn.name
                      table = this
                      databaseName = schemaColumn.Name
                      isPrimaryKey = schemaColumn.IsPrimaryKey
                      isDomainColumn = false
                      isNullable = schemaColumn.IsNullable
                      defaultValue = Option.tryNullOrWhiteSpace tableColumn.defaultValue
                      length = tableColumn.length
                      isRequired = tableColumn.isRequired
                      ``type`` = tableColumn.``type``
                      dataScale = tableColumn.dataScale
                      dataPrecision = tableColumn.dataPrecision
                      showSearchOrder = tableColumn.showSearchOrder
                      useSearchOrder = tableColumn.useSearchOrder
                      locale = Option.tryNullOrWhiteSpace tableColumn.locale
                      description = Option.tryNullOrWhiteSpace tableColumn.text.description
                      remarks = Option.tryNullOrWhiteSpace tableColumn.text.remarks
                      displayDescription = Option.tryNullOrWhiteSpace tableColumn.text.displayDescription
                      displayTitle = Option.tryNullOrWhiteSpace tableColumn.text.displayTitle
                      displayTitleLong = Option.tryNullOrWhiteSpace tableColumn.text.displayTitleLong
                      schemaColumn = schemaColumn }
            | _, _ -> None


        )

type Schema.Column with
    static member all = InforTable.all |> Array.collect (fun table -> table.schemaColumns)
    member this.asSystemType = Type.GetType(this.TypeMapping.ClrType)
    member this.FSharpType = FSharpLiteral.stringifyTypeDynamic this.asSystemType


type InforColumn with
    static member all = InforTable.all |> Array.collect (fun table -> table.columns)

    static member byOwner'ProductFamily'Table'Name =
        InforColumn.all
        |> Array.map (fun column ->
            (column.table.productFamily.owner, column.table.productFamily.name, column.table.name, column.name), column)
        |> Map.ofArray

    static member byFullyQualifiedDatabaseName =
        InforColumn.all
        |> Array.map (fun column -> $"{column.table.tsqlTable.Name.fullyQualified}.{column.databaseName}", column)
        |> Map.ofArray

    member this.moniker =
        $"{this.table.productFamily.owner}.{this.table.productFamily.name}.{this.table.name}.{this.name}"

    static member byMoniker =
        InforColumn.all
        |> Array.map (fun column -> column.moniker, column)
        |> Map.ofArray

















type BannerOrganization = { Name: string; Code: string }
type BannerSupervisor = { Name: string; ID: string }

type BannerEmployee =
    { ID: string
      FirstName: string
      MI: string
      LastName: string
      HiredDate: DateTime
      EffectiveStartDate: DateTime option
      Rate: decimal option
      Supervisor: BannerSupervisor option
      Position: string
      Email: string option
      Organization: BannerOrganization
      Department: string
      Division: string }


let bannerEmployees =
    query {
        for bannerEmployee in InforProd.Sql.serverData.Dbo.LcSelectAllemployees do
            select
                { ID = bannerEmployee.Id.Value
                  FirstName = bannerEmployee.Firstname.Value
                  MI = bannerEmployee.Middlename
                  LastName = bannerEmployee.Lastname
                  HiredDate = bannerEmployee.Hired
                  EffectiveStartDate = bannerEmployee.Effective
                  Rate = bannerEmployee.Rate
                  Supervisor =
                    if bannerEmployee.Supervisor.IsSome && bannerEmployee.Supervisorid.IsSome then
                        Some
                            { Name = bannerEmployee.Supervisor.Value
                              ID = bannerEmployee.Supervisorid.Value }
                    else
                        None
                  Position = bannerEmployee.Position.Value
                  Email = bannerEmployee.Email
                  Organization =
                    { Name = bannerEmployee.Org.Value
                      Code = bannerEmployee.Orgcode }
                  Department = bannerEmployee.Department.Value
                  Division = bannerEmployee.Division.Value

                }
    }
    |> Seq.toArray







let EmployeeTable =
    InforTable.byOwner'ProductFamily'Name["Hansen", "Resources", "Employee"]




(*


let StormInletTable = InforTable.byOwner'ProductFamily'Name["Hansen", "AssetManagement.Storm", "StormInlet"]
let randomEmployee = EmployeeTable.rows |> Array.randomChoice
randomEmployee.ColumnValuesWithDefinition

//InforTable.all
[|
    EmployeeTable
    StormInletTable
|]
|> Array.Parallel.iter (fun inforTable ->  
Ast.Oak() {
    Ast.AnonymousModule() {
        Ast.Open("System")
        Ast.HashDirective("load",Ast.VerbatimString(@"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\SqlDatabase\Data\SQLProvider\Employees.fsx"))
        Ast.Open("Employees")
        Ast.Module ("Infor") {
            Ast.Module(inforTable.productFamily.name.Replace(".","_")){
                Ast.Record(inforTable.name){
                    for schemaColumn in inforTable.schemaColumns  do 
                        Ast.Field(schemaColumn.Name,schemaColumn.FSharpType)
                }
                Ast.Module(inforTable.name){
                    Ast.Value("all", Ast.RecordExpr([
                    for inforRow in inforTable.rows[1..2] do 
                        for columnName, columnValue, columnDefinition in inforRow.ColumnValuesWithDefinition do
                            Ast.RecordFieldExpr(columnName, string columnValue)
                    ]),
                    $"{inforTable.name} array"
                    )
                }
            }
    }
}
}
|> Gen.mkOak
|> Gen.run
|> fun text -> File.WriteAllText(@$"D:\Artifact\Company\Infor\Codegen\{inforTable.moniker}.fsx", text) )


let testColumn = EmployeeTable.schemaColumns[5]
let hasTestColumn =
    query 
        {
            for employee in EmployeeTable.sqlEntities do 
                select (employee.HasColumn(testColumn.Name) )
        }
        |> Seq.toArray

|> Array.Parallel.map (fun schemaColumn ->  )
EmployeeTable.sqlEntities |> Seq





// TODO figure out automating adding employees (probably via soap)



let bannerEmployeeIds =
    bannerEmployees
    |> Seq.map (fun bannerEmployee -> bannerEmployee.ID)
    |> Set.ofSeq


let testIndividual  = InforProd.Sql.server.Resources.Employee.Individuals.``00000081``




type InforTableTest =
    | SqlEntities of Common.SqlEntity array
    member this.entities = 
        match this with 
        | SqlEntities entities -> entities
    member this.cardinality = this.entities.Length 
    member this.columns = 
        if this.entities.Length > 0 then 
            this.entities[0].ColumnValuesWithDefinition
            |> Seq.choose (fun (columnName, columnValue, column) -> column)
            |> Seq.map (fun column -> 
                { 
                    databaseName = column.Name
                    sqlType = column.TypeInfo.Value
                    clrType = Type.GetType(column.TypeMapping.ClrType)
                    isPrimaryKey = column.IsPrimaryKey
                    isNullable = column.IsNullable
                    isAutonumber = column.IsAutonumber
                    hasDefault = column.HasDefault
                    isComputed = column.IsComputed
                }

                
            )  |> Seq.toArray
        else 
            [||]
    member this.columnDatabaseNames = this.columns |> Array.map (fun column -> column.databaseName)


let EmployeeTable = InforProd.Sql.server.Resources.Employee |> Seq.map (fun entity -> entity :> Common.SqlEntity) |> Seq.toArray |> SqlEntities 

let inforEmployeeIds =

    query {
        for inforEmployee in InforProd.Sql.server.Resources.Employee do
            

            select (inforEmployee.Empid)

    }
    |> Set.ofSeq

let inforActiveEmployeeIds =

    query {
        for inforActiveEmployee in InforProd.Sql.server.Resources.EmployeeviewActive do
            select (inforActiveEmployee.Empid)
    }
    |> Set.ofSeq

let inforInactiveEmployeeIds = inforEmployeeIds - inforActiveEmployeeIds

let missingEmployeeIds = bannerEmployeeIds - inforEmployeeIds




missingEmployeeIds.Count




let missingEmployees =
    bannerEmployees
    |> Array.Parallel.filter (fun bannerEmployee -> missingEmployeeIds.Contains(bannerEmployee.ID))
// TODO next finish solar wind tickets
// TODO investigate api for adding employees
missingEmployees.Length






let targetEmployee =
    missingEmployees
    |> Array.find (fun employee -> employee.FirstName = "Salvador" && employee.LastName = "Mendez")




targetEmployee.ID |> clip
targetEmployee.LastName |> clip
targetEmployee.FirstName |> clip
targetEmployee.Email.Value |> clip
targetEmployee.Supervisor.Value.ID |> clip
targetEmployee.HiredDate.ToShortDateString() |> clip
sprintf "%.2f" targetEmployee.Rate.Value |> clip








let inforEmployeeContactKeys =
    query {
        for inforEmployee in InforProd.Sql.server.Resources.Employee do
            where (
                inforEmployee.Expdate.IsNone
                && not (bannerEmployeeIds.Contains(inforEmployee.Empid))
            )

            select (inforEmployee.Contactkey)
    }

let inforIdKeys =
    query {
        for contact in InforProd.Sql.server.Resources.Contact do
            where (inforEmployeeContactKeys.Contains(contact.Cntctkey))
            where contact.Idkey.IsSome
            select contact.Idkey.Value
    }


let inforEmployees =
    query {
        for contact in InforProd.Sql.server.Resources.Cntctid do
            where (inforIdKeys.Contains(contact.Idkey))
            where (not (contact.Namelast.Contains("EXPIRED")))
            select (contact.Namefirst, contact.Namelast)
    }
    |> Seq.toArray



inforEmployees.Length
let employeeProbe = inforEmployees |> Array.randomSample 10 // |> Array.Parallel.filter (fun employee -> employee.Supervisor.IsNone)

(*


printfn "%d out of %d employees (%.2f%%)"
    employeeProbe.Length
    bannerEmployees.Length
    ((double employeeProbe.Length / double bannerEmployees.Length) *100.0)

*)
*)
