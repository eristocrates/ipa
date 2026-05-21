#r "nuget: Iride"

open Iride
open VDS.RDF

let graph = new Graph()
graph.NamespaceMap.AddNamespace("", UriFactory.Create "http://example.org/")
graph.NamespaceMap.AddNamespace("foaf", UriFactory.Create "http://xmlns.com/foaf/0.1/")

#load @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\www.w3.org\1999\02\22-rdf-syntax-ns\hash\rdfTypeProvider.fsx"
#load @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\www.w3.org\2000\01\rdf-schema\hash\rdfsTypeProvider.fsx"
#load @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\www.w3.org\2002\07\owl\hash\owlTypeProvider.fsx"
#load @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\xmlns.com\foaf\0.1\slash\foafTypeProvider.fsx"

type rdf = RdfTypeProvider.Navigator

type rdfs = RdfsTypeProvider.Navigator
rdfs.Class
type owl = OwlTypeProvider.Navigator
let owl'Class = owl.``http://www.w3.org/2002/07/owl#Class``
owl'Class

type foaf = FoafTypeProvider.Navigator

let IrideResource (igraph: IGraph) (qname: string) =
    { Graph = igraph
      Node = igraph.CreateUriNode(qname)

    }

FoafTypeProvider
    .Builder
    .Person(IrideResource graph ":ann")
    .FirstName("Ann")
    .Knows(
        FoafTypeProvider
            .Builder
            .Person(IrideResource graph ":bob")
            .FirstName("Bob")
    )

graph.SaveToFile("people.ttl")


let a = RdfTypeProvider.Uris.``type``




let randomNode = graph.AllNodes |> Seq.randomChoice

randomNode.NodeType
