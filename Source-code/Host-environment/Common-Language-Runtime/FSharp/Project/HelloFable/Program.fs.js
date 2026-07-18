

export const graphData = {
    links: [{
        predicate: "http://www.w3.org/1999/02/22-rdf-syntax-ns#type",
        source: "https://eristocrates.dev/ontology/sanctuary/yaladre",
        target: "http://xmlns.com/foaf/0.1/Person",
    }, {
        predicate: "http://xmlns.com/foaf/0.1/topic_interest",
        source: "https://eristocrates.dev/ontology/sanctuary/yaladre",
        target: "https://eristocrates.dev/ontology/commonplace/Quest_of_D",
    }, {
        predicate: "http://www.w3.org/1999/02/22-rdf-syntax-ns#type",
        source: "https://eristocrates.dev/ontology/sanctuary/siamesederp",
        target: "http://xmlns.com/foaf/0.1/Person",
    }, {
        predicate: "http://www.w3.org/1999/02/22-rdf-syntax-ns#type",
        source: "https://eristocrates.dev/ontology/sanctuary/regen",
        target: "http://xmlns.com/foaf/0.1/Person",
    }, {
        predicate: "http://www.w3.org/1999/02/22-rdf-syntax-ns#type",
        source: "https://eristocrates.dev/ontology/sanctuary/eristocrates",
        target: "http://xmlns.com/foaf/0.1/Person",
    }, {
        predicate: "http://xmlns.com/foaf/0.1/topic_interest",
        source: "https://eristocrates.dev/ontology/sanctuary/yaladre",
        target: "https://eristocrates.dev/ontology/commonplace/Gitadora",
    }],
    nodes: [{
        id: "https://eristocrates.dev/ontology/sanctuary/yaladre",
    }, {
        id: "http://xmlns.com/foaf/0.1/Person",
    }, {
        id: "https://eristocrates.dev/ontology/commonplace/Quest_of_D",
    }, {
        id: "https://eristocrates.dev/ontology/sanctuary/siamesederp",
    }, {
        id: "https://eristocrates.dev/ontology/sanctuary/regen",
    }, {
        id: "https://eristocrates.dev/ontology/sanctuary/eristocrates",
    }, {
        id: "https://eristocrates.dev/ontology/commonplace/Gitadora",
    }],
};

export const Graph = new ForceGraph()(document.getElementById("graph")).linkDirectionalParticles(2).graphData(graphData);

