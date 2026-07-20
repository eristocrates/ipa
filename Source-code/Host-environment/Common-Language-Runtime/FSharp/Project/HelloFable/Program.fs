open Browser.Dom
open Browser.Types
open Fable.Core
open Fable.Core.JsInterop

[<Emit "fetch($0, { cache: \"no-store\" })\n    .then(response => {\n        if (!response.ok) {\n            throw new Error(\n                \"Failed to load graph JSON: HTTP \"\n                + response.status\n                + \" \"\n                + response.statusText\n            );\n        }\n\n        return response.json();\n    })\n    .then(data =>\n        new ForceGraph()($1)\n            .graphData(data)\n    )">]
let render_graph_from_json_file (json_url: string) (element: HTMLElement) : JS.Promise<obj> = jsNative

let Graph =
    render_graph_from_json_file "./test_graph/test_graph.force-graph.2d.json" (document.getElementById "graph")
