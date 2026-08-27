open System
open System.IO
open System.Threading

#r "nuget: FAKE.Core, 5.16.0"
#r "nuget: Fake.Sql.SqlPackage, 6.1.4"

open Fake.Core
open Fake.Sql

#r "nuget: FSharp.Collections.ParallelSeq"
open FSharp.Collections.ParallelSeq
#r "nuget: Microsoft.SqlServer.DacFx"

open Microsoft.SqlServer.Dac
open Microsoft.SqlServer.Dac.Model

#load @"C:\Secret\InforSecrets.fsx"
open InforSecrets

module Database =
    [<Literal>]
    let name = "operations"

    let connectionString = Prod.connection_string


module Dacpac =
    let path = Path.Combine(__SOURCE_DIRECTORY__, $"{Database.name}.dacpac")


module Extraction =

    Target.create "ExportBacpac" (fun _ ->
        let sourceConnection =
            "Data Source=MyServer;Initial Catalog=MySourceDb;Integrated Security=True;"

        let destinationBacpac = "path/to/backup.bacpac"

        SqlPackage.exec (fun args ->
            { args with
                Action = SqlPackage.Action.Export
                Source = sourceConnection
                Destination = destinationBacpac }))


    let extract () =
        let services = new DacServices(Database.connectionString)

        let extractOptions = DacExtractOptions()
        extractOptions.ExtractAllTableData <- true
        extractOptions.ExtractReferencedServerScopedElements <- true
        extractOptions.ExtractUsageProperties <- true

        services.Extract(
            targetPath = Dacpac.path,
            databaseName = Database.name,
            applicationName = Database.name,
            applicationVersion = Version(0, 0, 1, 0),
            applicationDescription = null,
            tables = null,
            extractOptions = extractOptions,
            cancellationToken = Nullable<CancellationToken>()
        )

module Model =

    let from_path () =
        let options = ModelLoadOptions()

        options.LoadAsScriptBackedModel <- true
        options.ModelStorageType <- DacSchemaModelStorageType.Memory

        TSqlModel.LoadFromDacpac(Dacpac.path, options)

    let from_database () =
        let options = ModelExtractOptions()

        options.LoadAsScriptBackedModel <- true
        options.Storage <- DacSchemaModelStorageType.Memory

        TSqlModel.LoadFromDatabase(Database.connectionString, options, Nullable<CancellationToken>())

module Inspection =

    let printObjects (model: TSqlModel) =

        model.GetObjects(DacQueryScopes.UserDefined)
        |> Seq.iter (fun obj ->

            let objectType = obj.ObjectType.Name

            let objectName = string obj.Name

            printfn "%-30s %-60s" objectType objectName

        )




// Extraction.extract ()
let model = Model.from_path ()


let TableValuedFunctions =
    model.GetObjects(DacQueryScopes.All)
    |> PSeq.filter (fun model_object -> model_object.ObjectType.Name = "TableValuedFunction")

let ScalarFunctions =
    model.GetObjects(DacQueryScopes.All)
    |> PSeq.filter (fun model_object -> model_object.ObjectType.Name = "ScalarFunction")

let Indexes =
    model.GetObjects(DacQueryScopes.All)
    |> PSeq.filter (fun model_object -> model_object.ObjectType.Name = "Index")

let CheckConstraints =
    model.GetObjects(DacQueryScopes.All)
    |> PSeq.filter (fun model_object -> model_object.ObjectType.Name = "CheckConstraint")

let DatabaseOptionss =
    model.GetObjects(DacQueryScopes.All)
    |> PSeq.filter (fun model_object -> model_object.ObjectType.Name = "DatabaseOptions")

let DefaultConstraints =
    model.GetObjects(DacQueryScopes.All)
    |> PSeq.filter (fun model_object -> model_object.ObjectType.Name = "DefaultConstraint")

let DmlTriggers =
    model.GetObjects(DacQueryScopes.All)
    |> PSeq.filter (fun model_object -> model_object.ObjectType.Name = "DmlTrigger")

let ExtendedPropertys =
    model.GetObjects(DacQueryScopes.All)
    |> PSeq.filter (fun model_object -> model_object.ObjectType.Name = "ExtendedProperty")

let ForeignKeyConstraints =
    model.GetObjects(DacQueryScopes.All)
    |> PSeq.filter (fun model_object -> model_object.ObjectType.Name = "ForeignKeyConstraint")

let Logins =
    model.GetObjects(DacQueryScopes.All)
    |> PSeq.filter (fun model_object -> model_object.ObjectType.Name = "Login")

let PrimaryKeyConstraints =
    model.GetObjects(DacQueryScopes.All)
    |> PSeq.filter (fun model_object -> model_object.ObjectType.Name = "PrimaryKeyConstraint")

let Procedures =
    model.GetObjects(DacQueryScopes.All)
    |> PSeq.filter (fun model_object -> model_object.ObjectType.Name = "Procedure")

let Roles =
    model.GetObjects(DacQueryScopes.All)
    |> PSeq.filter (fun model_object -> model_object.ObjectType.Name = "Role")

let RoleMemberships =
    model.GetObjects(DacQueryScopes.All)
    |> PSeq.filter (fun model_object -> model_object.ObjectType.Name = "RoleMembership")

let Schemas =
    model.GetObjects(DacQueryScopes.All)
    |> PSeq.filter (fun model_object -> model_object.ObjectType.Name = "Schema")

let Statisticss =
    model.GetObjects(DacQueryScopes.All)
    |> PSeq.filter (fun model_object -> model_object.ObjectType.Name = "Statistics")

let Synonyms =
    model.GetObjects(DacQueryScopes.All)
    |> PSeq.filter (fun model_object -> model_object.ObjectType.Name = "Synonym")

let Tables =
    model.GetObjects(DacQueryScopes.All)
    |> PSeq.filter (fun model_object -> model_object.ObjectType.Name = "Table")

let TableTypes =
    model.GetObjects(DacQueryScopes.All)
    |> PSeq.filter (fun model_object -> model_object.ObjectType.Name = "TableType")

let UniqueConstraints =
    model.GetObjects(DacQueryScopes.All)
    |> PSeq.filter (fun model_object -> model_object.ObjectType.Name = "UniqueConstraint")

let Users =
    model.GetObjects(DacQueryScopes.All)
    |> PSeq.filter (fun model_object -> model_object.ObjectType.Name = "User")

let Views =
    model.GetObjects(DacQueryScopes.All)
    |> PSeq.filter (fun model_object -> model_object.ObjectType.Name = "View")






let employee_constraints =
    ForeignKeyConstraints
    |> PSeq.choose (fun ForeignKeyConstraint ->
        if ForeignKeyConstraint.Name.Parts.Contains("EMPLOYEE") then
            Some ForeignKeyConstraint
        else
            None


    )


module RESOURCES =
    let schema =
        Schemas
        |> Seq.find (fun Schema -> Schema.Name.Parts.Contains("RESOURCES"))

    module EMPLOYEE =


        let table =
            Tables
            |> Seq.find (fun Table -> Table.Name.Parts.Contains("EMPLOYEE"))

        let columns = table.GetChildren()

        let CONTACTKEY =
            columns
            |> Seq.find (fun column -> column.Name.Parts.Contains("CONTACTKEY"))

RESOURCES.EMPLOYEE.columns
|> PSeq.iter (fun column -> printfn "%A" column.Name)

RESOURCES.EMPLOYEE.CONTACTKEY.ObjectType.Properties



let random_child =
    RESOURCES.EMPLOYEE.table.GetChildren(DacQueryScopes.All)
    |> Seq.randomChoice

RESOURCES.EMPLOYEE.CONTACTKEY.ObjectType.Properties
|> Seq.iter (fun property ->
    printfn
        "%A %30s: %O"
        RESOURCES.EMPLOYEE.CONTACTKEY.Name
        property.Name
        (RESOURCES.EMPLOYEE.CONTACTKEY.GetProperty property))

RESOURCES.EMPLOYEE.CONTACTKEY.ObjectType.Relationships
|> Seq.iter (fun relationship ->
    printfn "%A %30s: %A" RESOURCES.EMPLOYEE.CONTACTKEY.Name relationship.Name relationship.Properties)

let random_property =
    random_child.ObjectType.Properties
    |> Seq.randomChoice







model.DisplayServices.GetElementName(RESOURCES.EMPLOYEE.CONTACTKEY, ElementNameStyle.FullyQualifiedName)
RESOURCES.EMPLOYEE.CONTACTKEY.ObjectType.Name
RESOURCES.EMPLOYEE.CONTACTKEY.ObjectType.Properties
RESOURCES.EMPLOYEE.CONTACTKEY.ObjectType.Relationships

model.DisplayServices.GetDisplayName(
    RESOURCES.EMPLOYEE.CONTACTKEY.Name,
    Microsoft.SqlServer.Dac.Model.EscapeStyle.EscapeIfNecessary,
    true
)
