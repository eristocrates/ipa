open Browser.Dom
open Browser.Types
open Fable.Core
open Fable.Core.JsInterop

[<Emit @"fetch($0, { cache: 'no-store' })
    .then(response => {
        if (!response.ok) {
            throw new Error(
                'Failed to load graph JSON: HTTP '
                + response.status
                + ' '
                + response.statusText
            );
        }

        return response.json();
    })
    .then(data =>
        new ForceGraph()($1)
            .graphData(data)
    )">]
let render_graph_from_json_file (json_url: string) (element: HTMLElement) : JS.Promise<obj> = jsNative

let Graph =
    render_graph_from_json_file "./test_graph/test_graph.force-graph.2d.json" (document.getElementById "graph")
