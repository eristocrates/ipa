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

operations.Dbo.LcSelectAllemployees
#r "nuget: Microsoft.Data.SqlClient"

open Microsoft.Data.SqlClient

let linked_test () =

    use connection = new SqlConnection(Prod.connection_string)
    connection.Open()

    use command =
        new SqlCommand(
            """
            SELECT TOP (100) *
            FROM [HRORACLEPROD]..[LCAPPS].[V_HANSEN_BOARD_ACTIVE_EMP]
            """,
            connection
        )

    command.CommandTimeout <- 120

    use reader = command.ExecuteReader()

    let column_names =
        [| for index in 0 .. reader.FieldCount - 1 do
               reader.GetName(index) |]

    printfn "%A" column_names

    while reader.Read() do
        let values =
            [| for index in 0 .. reader.FieldCount - 1 do
                   if reader.IsDBNull(index) then
                       null
                   else
                       reader.GetValue(index) |]

        printfn "%A" values

linked_test ()
#r "nuget: Oracle.ManagedDataAccess.Core"

open System
open Oracle.ManagedDataAccess.Client

let data_sources = OracleDataSourceEnumerator().GetDataSources()

printfn "Visible Oracle data-source aliases: %d" data_sources.Rows.Count

for row in data_sources.Rows do
    printfn "%O" row["InstanceName"]



#r "nuget: Oracle.ManagedDataAccess.Core"

open Oracle.ManagedDataAccess.Client


let oracle_test () =




    use connection = new OracleConnection(Prod.oracle)

    // This was missing from the previous test.
    connection.SqlNetAuthenticationServices <- "(NTS)"

    try
        connection.Open()

        printfn "Connected directly through Windows authentication."
        printfn "Server version: %s" connection.ServerVersion

        use command =
            new OracleCommand(
                """
                SELECT
                    SYS_CONTEXT('USERENV', 'SESSION_USER'),
                    SYS_CONTEXT('USERENV', 'AUTHENTICATION_METHOD')
                FROM DUAL
                """,
                connection
            )

        use reader = command.ExecuteReader()

        if reader.Read() then
            printfn "Oracle user: %O" (reader.GetValue(0))
            printfn "Authentication method: %O" (reader.GetValue(1))

    with
    | :? OracleException as exception_value ->
        printfn "Oracle error %d: %s" exception_value.Number exception_value.Message


oracle_test ()
