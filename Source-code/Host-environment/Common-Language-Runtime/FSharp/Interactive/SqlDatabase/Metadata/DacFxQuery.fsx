open System
open System.IO
open System.Threading

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
    open System.Threading

    let extract () =
        let services = new DacServices(Database.connectionString)

        let extractOptions = DacExtractOptions()

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




Extraction.extract ()
let model = Model.from_path ()


let TableValuedFunctions =
    model.GetObjects(DacQueryScopes.UserDefined)
    |> Seq.toArray
    |> Array.Parallel.filter (fun model_object -> model_object.ObjectType.Name = "TableValuedFunction")

let ScalarFunctions =
    model.GetObjects(DacQueryScopes.UserDefined)
    |> Seq.toArray
    |> Array.Parallel.filter (fun model_object -> model_object.ObjectType.Name = "ScalarFunction")

let Indexes =
    model.GetObjects(DacQueryScopes.UserDefined)
    |> Seq.toArray
    |> Array.Parallel.filter (fun model_object -> model_object.ObjectType.Name = "Index")

let CheckConstraints =
    model.GetObjects(DacQueryScopes.UserDefined)
    |> Seq.toArray
    |> Array.Parallel.filter (fun model_object -> model_object.ObjectType.Name = "CheckConstraint")

let DatabaseOptionss =
    model.GetObjects(DacQueryScopes.UserDefined)
    |> Seq.toArray
    |> Array.Parallel.filter (fun model_object -> model_object.ObjectType.Name = "DatabaseOptions")

let DefaultConstraints =
    model.GetObjects(DacQueryScopes.UserDefined)
    |> Seq.toArray
    |> Array.Parallel.filter (fun model_object -> model_object.ObjectType.Name = "DefaultConstraint")

let DmlTriggers =
    model.GetObjects(DacQueryScopes.UserDefined)
    |> Seq.toArray
    |> Array.Parallel.filter (fun model_object -> model_object.ObjectType.Name = "DmlTrigger")

let ExtendedPropertys =
    model.GetObjects(DacQueryScopes.UserDefined)
    |> Seq.toArray
    |> Array.Parallel.filter (fun model_object -> model_object.ObjectType.Name = "ExtendedProperty")

let ForeignKeyConstraints =
    model.GetObjects(DacQueryScopes.UserDefined)
    |> Seq.toArray
    |> Array.Parallel.filter (fun model_object -> model_object.ObjectType.Name = "ForeignKeyConstraint")

let Logins =
    model.GetObjects(DacQueryScopes.UserDefined)
    |> Seq.toArray
    |> Array.Parallel.filter (fun model_object -> model_object.ObjectType.Name = "Login")

let PrimaryKeyConstraints =
    model.GetObjects(DacQueryScopes.UserDefined)
    |> Seq.toArray
    |> Array.Parallel.filter (fun model_object -> model_object.ObjectType.Name = "PrimaryKeyConstraint")

let Procedures =
    model.GetObjects(DacQueryScopes.UserDefined)
    |> Seq.toArray
    |> Array.Parallel.filter (fun model_object -> model_object.ObjectType.Name = "Procedure")

let Roles =
    model.GetObjects(DacQueryScopes.UserDefined)
    |> Seq.toArray
    |> Array.Parallel.filter (fun model_object -> model_object.ObjectType.Name = "Role")

let RoleMemberships =
    model.GetObjects(DacQueryScopes.UserDefined)
    |> Seq.toArray
    |> Array.Parallel.filter (fun model_object -> model_object.ObjectType.Name = "RoleMembership")

let Schemas =
    model.GetObjects(DacQueryScopes.UserDefined)
    |> Seq.toArray
    |> Array.Parallel.filter (fun model_object -> model_object.ObjectType.Name = "Schema")

let Statisticss =
    model.GetObjects(DacQueryScopes.UserDefined)
    |> Seq.toArray
    |> Array.Parallel.filter (fun model_object -> model_object.ObjectType.Name = "Statistics")

let Synonyms =
    model.GetObjects(DacQueryScopes.UserDefined)
    |> Seq.toArray
    |> Array.Parallel.filter (fun model_object -> model_object.ObjectType.Name = "Synonym")

let Tables =
    model.GetObjects(DacQueryScopes.UserDefined)
    |> Seq.toArray
    |> Array.Parallel.filter (fun model_object -> model_object.ObjectType.Name = "Table")

let TableTypes =
    model.GetObjects(DacQueryScopes.UserDefined)
    |> Seq.toArray
    |> Array.Parallel.filter (fun model_object -> model_object.ObjectType.Name = "TableType")

let UniqueConstraints =
    model.GetObjects(DacQueryScopes.UserDefined)
    |> Seq.toArray
    |> Array.Parallel.filter (fun model_object -> model_object.ObjectType.Name = "UniqueConstraint")

let Users =
    model.GetObjects(DacQueryScopes.UserDefined)
    |> Seq.toArray
    |> Array.Parallel.filter (fun model_object -> model_object.ObjectType.Name = "User")

let Views =
    model.GetObjects(DacQueryScopes.UserDefined)
    |> Seq.toArray
    |> Array.Parallel.filter (fun model_object -> model_object.ObjectType.Name = "View")



let random_object = Tables |> Array.randomChoice

let random_child =
    random_object.GetChildren(DacQueryScopes.UserDefined)
    |> Seq.randomChoice

random_child.ObjectType.Properties
|> Seq.iter (fun property -> printfn "%A %30s: %O" random_child.Name property.Name (random_child.GetProperty property))

let random_property =
    random_child.ObjectType.Properties
    |> Seq.randomChoice




model.DisplayServices.GetElementName(random_object, ElementNameStyle.FullyQualifiedName)
random_object.ObjectType.Name
random_object.ObjectType.Properties
random_object.ObjectType.Relationships

model.DisplayServices.GetDisplayName(
    random_object.Name,
    Microsoft.SqlServer.Dac.Model.EscapeStyle.EscapeIfNecessary,
    true
)
