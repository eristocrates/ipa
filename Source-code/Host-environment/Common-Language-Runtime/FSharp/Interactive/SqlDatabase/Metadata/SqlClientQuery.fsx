open System
open System.Data

#r "nuget: Microsoft.Data.SqlClient"

open Microsoft.Data.SqlClient
#load @"C:\Secret\InforSecrets.fsx"

open InforSecrets

#load @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\Ergonomics\PowershellErgonomics.fsx"

open PowershellErgonomics




let connectionString = Prod.connection_string

let getSchema collectionName =
    use connection = new SqlConnection(connectionString)
    connection.Open()
    connection.GetSchema(collectionName)

let MetaDataCollections = getSchema "MetaDataCollections"

MetaDataCollections.Rows
|> Seq.cast<DataRow>
|> Seq.iter (fun row -> printfn "%A" row["CollectionName"])

module MetaDataCollection =

    let DataSourceInformation = getSchema "DataSourceInformation"
    let DataTypes = getSchema "DataTypes"
    let Restrictions = getSchema "Restrictions"
    let ReservedWords = getSchema "ReservedWords"
    let Users = getSchema "Users"
    let Databases = getSchema "Databases"
    let Tables = getSchema "Tables"
    let Columns = getSchema "Columns"
    let AllColumns = getSchema "AllColumns"
    let ColumnSetColumns = getSchema "ColumnSetColumns"
    let StructuredTypeMembers = getSchema "StructuredTypeMembers"
    let Views = getSchema "Views"
    let ViewColumns = getSchema "ViewColumns"
    let ProcedureParameters = getSchema "ProcedureParameters"
    let Procedures = getSchema "Procedures"
    let ForeignKeys = getSchema "ForeignKeys"
    let IndexColumns = getSchema "IndexColumns"
    let Indexes = getSchema "Indexes"
    let UserDefinedTypes = getSchema "UserDefinedTypes"





let sprintDataTableShape (data_tabletable: DataTable) =
    data_tabletable.Columns
    |> Seq.cast<DataColumn>
    |> Seq.map (fun data_column -> sprintf "%s : %O" data_column.ColumnName data_column.DataType)
    |> String.concat "\n"

sprintDataTableShape MetaDataCollection.ForeignKeys
|> clip



type DbColumn =
    { TableCatalog: string
      TableSchema: string
      TableName: string
      ColumnName: string
      OrdinalPosition: int
      IsNullable: bool
      DataType: string }

let stringValue (name: string) (row: DataRow) = row[name] :?> string

let intValue (name: string) (row: DataRow) = row[name] :?> int

let boolFromYesNo name (row: DataRow) =
    match stringValue name row with
    | "YES" -> true
    | "NO" -> false
    | other -> failwithf "Unexpected boolean-ish value for %s: %s" name other

let dbColumns =
    MetaDataCollection.Columns.Rows
    |> Seq.cast<DataRow>
    |> Seq.map (fun row ->
        { TableCatalog = stringValue "TABLE_CATALOG" row
          TableSchema = stringValue "TABLE_SCHEMA" row
          TableName = stringValue "TABLE_NAME" row
          ColumnName = stringValue "COLUMN_NAME" row
          OrdinalPosition = intValue "ORDINAL_POSITION" row
          IsNullable = boolFromYesNo "IS_NULLABLE" row
          DataType = stringValue "DATA_TYPE" row })
    |> Seq.toArray
