#I @"D:\https\com\github\eristocrates\ipa\dll\"
#r @"ResourceDescription.dll"

open ResourceDescription
#r @"Turtle.dll"
open Turtle

#I @"D:\https\com\github\eristocrates\ipa\fsx\"
#I @"D:\https\com\github\eristocrates\ipa\fsx\Namespaces\Generated"

#load @".paket/load/main.group.fsx"

open System
open Tavis.UriTemplates






#load @"foafNamespace.fsx"

open FoafNamespace
open VDS.RDF

module dbug =
    let _namespaceIri =
        personalUriTemplate
            .AddParameters(
                {| namespacePrefix = "dbug"
                   localName = String.Empty |}
            )
            .asIri

    let _prefixedName (localName: string) =
        personalUriTemplate
            .AddParameters(
                {| namespacePrefix = "dbug"
                   localName = localName |}
            )
            .asIri

    let Alice = _prefixedName "Alice"
    let Bob = _prefixedName "Bob"


type IGraph with
    member this.Assert(formula: Formula) =
        this.Assert(formula.triples |> Seq.map (fun triple -> triple.triple))

type INamespaceMapper with
    member this.AddNamespace((prefix: string), (iri: NamedReference)) = this.AddNamespace(prefix, iri.uri)

    member this.AddNamespace((prefix: string), (namespaceName: NamespaceName)) =
        this.AddNamespace(prefix, namespaceName.uri)
let owlNamespace = NamedReference "http://www.w3.org/2002/07/owl#" |> NamespaceName
// TODO run codegen on all ontologies present
let Alice = foaf.Person.NamedIndividual dbug.Alice
let inline (-*+) (draft: Formula) (formula: Formula ) =
    [ draft ] |> formula.addFormulas

let formulaGraph = new ThreadSafeGraph()
formulaGraph.NamespaceMap.AddNamespace("dbug", dbug._namespaceIri)
formulaGraph.NamespaceMap.AddNamespace("foaf", foaf._namespace)
formulaGraph.NamespaceMap.AddNamespace("owl", owlNamespace)
Alice.knows --> dbug.Bob
-*+ Alice.firstName -->= "Alice"
-*+ Alice.age -->= 32
|> formulaGraph.Assert

formulaGraph.SaveToTurtle @"D:\https\com\github\eristocrates\ipa\scratch\scratch.ttl"
