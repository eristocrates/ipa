

export const Graph = fetch("./test_graph/test_graph.force-graph.2d.json", { cache: "no-store" })
    .then(response => {
        if (!response.ok) {
            throw new Error(
                "Failed to load graph JSON: HTTP "
                + response.status
                + " "
                + response.statusText
            );
        }

        return response.json();
    })
    .then(data =>
        new ForceGraph()(document.getElementById("graph"))
            .graphData(data)
    );

