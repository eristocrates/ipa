#r "nuget: Prime.Ecs"
open Prime.Ecs



#load @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\Reverse_Domain_Name.fsx"
open Reverse_Domain_Name


[<Struct>]
type IRI_Component =
    { mutable Active: bool
      mutable Value: string }
    interface IRI_Component Component with
        member this.Active
            with get () = this.Active
            and set value = this.Active <- value

let entity_component_system = Ecs()

entity_component_system
    .MakeEntity()
    .Register { Active = true
                Value = org.example.www.iri.as'string }

entity_component_system
    .MakeEntity()
    .Register { Active = true
                Value = com.toscrape.books.iri.as'string }


let iriQuery =
    Query.make<IRI_Component> (
        entity_component_system,
        subqueries = [ Eq(At(Var "IRI_Component", Var "Value"), Val(String "org.example.www.iri")) ]
    )

let matchingEntities = iriQuery.IndexEntities()
let entity = matchingEntities |> Seq.tryHead
