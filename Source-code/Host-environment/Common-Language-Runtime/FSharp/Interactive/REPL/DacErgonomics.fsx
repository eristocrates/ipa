#load @".paket/load/main.group.fsx"
#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#r "nuget: Microsoft.SqlServer.DacFx, 162.5.57"

open Microsoft.SqlServer
open FSharp.Collections.ParallelSeq

type Dac.Model.ModelTypeClass with
    member this.metadata = this.Metadata |> Seq.toArray
    member this.properties = this.Properties |> Seq.toArray

type Dac.Model.TSqlObject with
    member this.ast = this.GetAst()
    member this.children = this.GetChildren() |> Seq.toArray
    member this.parent = this.GetParent()
    member this.referenced = this.GetReferenced() |> Seq.toArray

    member this.referencedRelationshipInstances =
        this.GetReferencedRelationshipInstances()
        |> Seq.toArray

    member this.referencing = this.GetReferencing() |> Seq.toArray

    member this.referencingRelationshipInstances =
        this.GetReferencingRelationshipInstances()
        |> Seq.toArray

    member this.script = this.GetScript() |> Seq.toArray
    member this.sourceInformation = this.GetSourceInformation()

type Dac.Model.TSqlModel with
    member this.TableValuedFunctions =
        this.GetObjects(Dac.Model.DacQueryScopes.All)
        |> PSeq.filter (fun model_object -> model_object.ObjectType.Name = "TableValuedFunction")

    member this.ScalarFunctions =
        this.GetObjects(Dac.Model.DacQueryScopes.All)
        |> PSeq.filter (fun model_object -> model_object.ObjectType.Name = "ScalarFunction")

    member this.Indexes =
        this.GetObjects(Dac.Model.DacQueryScopes.All)
        |> PSeq.filter (fun model_object -> model_object.ObjectType.Name = "Index")

    member this.CheckConstraints =
        this.GetObjects(Dac.Model.DacQueryScopes.All)
        |> PSeq.filter (fun model_object -> model_object.ObjectType.Name = "CheckConstraint")

    member this.DatabaseOptions =
        this.GetObjects(Dac.Model.DacQueryScopes.All)
        |> PSeq.filter (fun model_object -> model_object.ObjectType.Name = "DatabaseOptions")

    member this.DefaultConstraints =
        this.GetObjects(Dac.Model.DacQueryScopes.All)
        |> PSeq.filter (fun model_object -> model_object.ObjectType.Name = "DefaultConstraint")

    member this.DmlTriggers =
        this.GetObjects(Dac.Model.DacQueryScopes.All)
        |> PSeq.filter (fun model_object -> model_object.ObjectType.Name = "DmlTrigger")

    member this.ExtendedPropertys =
        this.GetObjects(Dac.Model.DacQueryScopes.All)
        |> PSeq.filter (fun model_object -> model_object.ObjectType.Name = "ExtendedProperty")

    member this.ForeignKeyConstraints =
        this.GetObjects(Dac.Model.DacQueryScopes.All)
        |> PSeq.filter (fun model_object -> model_object.ObjectType.Name = "ForeignKeyConstraint")

    member this.Logins =
        this.GetObjects(Dac.Model.DacQueryScopes.All)
        |> PSeq.filter (fun model_object -> model_object.ObjectType.Name = "Login")

    member this.PrimaryKeyConstraints =
        this.GetObjects(Dac.Model.DacQueryScopes.All)
        |> PSeq.filter (fun model_object -> model_object.ObjectType.Name = "PrimaryKeyConstraint")

    member this.Procedures =
        this.GetObjects(Dac.Model.DacQueryScopes.All)
        |> PSeq.filter (fun model_object -> model_object.ObjectType.Name = "Procedure")

    member this.Roles =
        this.GetObjects(Dac.Model.DacQueryScopes.All)
        |> PSeq.filter (fun model_object -> model_object.ObjectType.Name = "Role")

    member this.RoleMemberships =
        this.GetObjects(Dac.Model.DacQueryScopes.All)
        |> PSeq.filter (fun model_object -> model_object.ObjectType.Name = "RoleMembership")

    member this.Schemas =
        this.GetObjects(Dac.Model.DacQueryScopes.All)
        |> PSeq.filter (fun model_object -> model_object.ObjectType.Name = "Schema")

    member this.Statisticss =
        this.GetObjects(Dac.Model.DacQueryScopes.All)
        |> PSeq.filter (fun model_object -> model_object.ObjectType.Name = "Statistics")

    member this.Synonyms =
        this.GetObjects(Dac.Model.DacQueryScopes.All)
        |> PSeq.filter (fun model_object -> model_object.ObjectType.Name = "Synonym")

    member this.Tables =
        this.GetObjects(Dac.Model.DacQueryScopes.All)
        |> PSeq.filter (fun model_object -> model_object.ObjectType.Name = "Table")

    member this.TableTypes =
        this.GetObjects(Dac.Model.DacQueryScopes.All)
        |> PSeq.filter (fun model_object -> model_object.ObjectType.Name = "TableType")

    member this.UniqueConstraints =
        this.GetObjects(Dac.Model.DacQueryScopes.All)
        |> PSeq.filter (fun model_object -> model_object.ObjectType.Name = "UniqueConstraint")

    member this.Users =
        this.GetObjects(Dac.Model.DacQueryScopes.All)
        |> PSeq.filter (fun model_object -> model_object.ObjectType.Name = "User")

    member this.Views =
        this.GetObjects(Dac.Model.DacQueryScopes.All)
        |> PSeq.filter (fun model_object -> model_object.ObjectType.Name = "View")
