open System

#r "nuget: SQLProvider.MsSql, 1.5.18"

#load @"C:\Secret\InforSecrets.fsx"

open InforSecrets

#load @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\Ergonomics\PowershellErgonomics.fsx"

open PowershellErgonomics

open FSharp.Data.Sql
open FSharp.Data.Sql.MsSql



type InforProdSql =
    SqlDataProvider<ConnectionString=Prod.connection_string, IndividualsAmount=10000, UseOptionTypes=Common.NullableColumnType.OPTION>

let operations = InforProdSql.GetDataContext()

let table_keys =
    query {
        for table in operations.MetaData.Dbtable do
            where (table.Commonid.Value = "Complex")
            select table.Tablekey
    }
    |> Seq.head
