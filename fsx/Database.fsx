#time on
fsi.PrintLength <- 1
fsi.ShowDeclarationValues <- false

#r "nuget: Dapper"
#r "nuget: Dapper.FSharp"
#r "nuget: SqlHydra"
#r "nuget: SqlHydra.Query"
#r "nuget: Microsoft.Data.SqlClient"
#I @"D:\https\com\github\eristocrates\InforSqlHydra\bin\Release\net10.0"
#r "InforSqlHydra.dll"
open System
open System.Data
open SqlHydra
open SqlHydra.Query
open Microsoft.Data.SqlClient
open Dapper.FSharp.MSSQL
Dapper.FSharp.MSSQL.OptionTypes.register ()
open InforTestSql.TestOperations

module InforTest =
    let Connect () =
        let connection =
            new SqlConnection(
                "ApplicationIntent=ReadOnly;Server=InforTestSql;Database=test;Integrated Security=True;TrustServerCertificate=True;MultipleActiveResultSets=True"
            )

        connection.Open()
        connection

let assetFeatures =
    select {
        for asset in table<dbo.lc_stormwater_infrastructure> do
            selectAll
    }
    |> InforTest.Connect().SelectAsync<dbo.lc_stormwater_infrastructure>
    |> Async.AwaitTask
    |> Async.RunSynchronously
