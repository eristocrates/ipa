open Browser.Dom
open Browser.Types
open Fable.Core
open Fable.Core.JsInterop

let graphData =
    {| nodes =
        [| {| id = "https://eristocrates.dev/ontology/sanctuary/yaladre" |}
           {| id = "http://xmlns.com/foaf/0.1/Person" |}
           {| id = "https://eristocrates.dev/ontology/commonplace/Quest_of_D" |}
           {| id = "https://eristocrates.dev/ontology/sanctuary/siamesederp" |}
           {| id = "https://eristocrates.dev/ontology/sanctuary/regen" |}
           {| id = "https://eristocrates.dev/ontology/sanctuary/eristocrates" |}
           {| id = "https://eristocrates.dev/ontology/commonplace/Gitadora" |} |]
       links =
        [| {| source = "https://eristocrates.dev/ontology/sanctuary/yaladre"
              target = "http://xmlns.com/foaf/0.1/Person"
              predicate = "http://www.w3.org/1999/02/22-rdf-syntax-ns#type" |}
           {| source = "https://eristocrates.dev/ontology/sanctuary/yaladre"
              target = "https://eristocrates.dev/ontology/commonplace/Quest_of_D"
              predicate = "http://xmlns.com/foaf/0.1/topic_interest" |}
           {| source = "https://eristocrates.dev/ontology/sanctuary/siamesederp"
              target = "http://xmlns.com/foaf/0.1/Person"
              predicate = "http://www.w3.org/1999/02/22-rdf-syntax-ns#type" |}
           {| source = "https://eristocrates.dev/ontology/sanctuary/regen"
              target = "http://xmlns.com/foaf/0.1/Person"
              predicate = "http://www.w3.org/1999/02/22-rdf-syntax-ns#type" |}
           {| source = "https://eristocrates.dev/ontology/sanctuary/eristocrates"
              target = "http://xmlns.com/foaf/0.1/Person"
              predicate = "http://www.w3.org/1999/02/22-rdf-syntax-ns#type" |}
           {| source = "https://eristocrates.dev/ontology/sanctuary/yaladre"
              target = "https://eristocrates.dev/ontology/commonplace/Gitadora"
              predicate = "http://xmlns.com/foaf/0.1/topic_interest" |} |] |}

[<Emit "new ForceGraph()($0).linkDirectionalParticles(2).graphData($1)">]
let render_graph (element: HTMLElement) (data: obj) : obj = jsNative

let Graph = render_graph (document.getElementById "graph") graphData
