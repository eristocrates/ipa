
import { map, initialize } from "./fable_modules/fable-library-js.5.6.0/Array.js";
import { toArray } from "./fable_modules/fable-library-js.5.6.0/Seq.js";
import { rangeDouble } from "./fable_modules/fable-library-js.5.6.0/Range.js";

export const N = 300;

export const gData = (() => {
    const nodes = initialize(N, (id) => ({
        id: id,
    }));
    return {
        links: map((id_1) => ({
            source: id_1,
            target: Math.round(Math.random() * (id_1 - 1)),
        }), toArray(rangeDouble(1, 1, N - 1))),
        nodes: nodes,
    };
})();

export const Graph = (() => {
    let graph_1;
    let graph;
    const element = document.getElementById("graph");
    graph = (new ForceGraph()(element));
    graph_1 = graph.linkDirectionalParticles(2);
    return graph_1.graphData(gData);
})();

