namespace https.w3id.org.rdfp.slash

open DoxAletheia.Rdf_Vocabulary

module rdfp =
    let _namespace_name = "https://w3id.org/rdfp/"
    /// <summary>
    ///   <see href="https://w3id.org/rdfp/rdfp-1.0"></see>
    /// </summary>
    let ``rdfp-1.0`` = Namespaced_IRI.parse _namespace_name "rdfp-1.0" |> NamespacedName
    /// <summary>
    /// Instances of rdfp:Graph are RDF graph resources that may have several representations.
    ///
    ///    For example,
    ///
    /// ```
    ///    &lt;https://w3id.org/rdfp/example/input&gt; a rdfp:Graph ;
    ///      rdfp:describedBy &lt;https://w3id.org/rdfp/example/graph&gt; ;
    ///      rdfp:representedBy &lt;some_rdfp_resource&gt; .
    /// ```
    ///
    /// We propose an alignment of this resource with rdfg:Graph, but this is part of [another document](https://w3id.org/rdfp/align/rdfg).
    ///
    /// <see href="https://w3id.org/rdfp/Graph"></see></summary>
    let Graph = Namespaced_IRI.parse _namespace_name "Graph" |> NamespacedName
    /// <summary>
    /// The class of web resources, that have one or several representations.
    /// <see href="https://w3id.org/rdfp/Resource"></see></summary>
    let Resource = Namespaced_IRI.parse _namespace_name "Resource" |> NamespacedName

    /// <summary>
    /// Instances of rdfp:GraphDescription describe RDF Graphs in terms of validation and presentation.
    ///
    ///   A rdfp:GraphDescription may be linked to one or more validation rules.
    ///   A rdfp:GraphDescription may be linked to one or more instances or rdfp:Presentation.
    ///
    ///    For example,
    ///
    /// ```
    ///    &lt;https://w3id.org/rdfp/example/graph&gt; a rdfp:GraphDescription ;
    ///      rdfp:validationRule &lt;some_sparql_ask_rule&gt; ;
    ///      rdfp:presentedBy &lt;some_presentation_description&gt; .
    /// ```
    ///
    /// We propose an alignment of this resource with sd:Graph, but this is part of [another document](https://w3id.org/rdfp/align/sd).
    ///
    /// <see href="https://w3id.org/rdfp/GraphDescription"></see></summary>
    let GraphDescription =
        Namespaced_IRI.parse _namespace_name "GraphDescription" |> NamespacedName

    /// <summary>
    /// Instances of rdfp:GraphPresentation describe RDF Graph presentations in terms of lifting, lowering, and validation rules.
    ///
    ///    - lifting rules can be used to generate a RDF graph from a document, using for instance a RML mapping, a XSPARQL rule, or SPARQL-Generate rule;
    ///    - lowering rules can be used to generate a document from a RDF graph, using for instance a STTL rule (aka. SPARQL-Template).
    ///    - validation rules can be used to validate a document, using for instance a regular expression, a XSD Schema, or a JSON Schema
    ///
    ///    For example,
    ///
    ///     https://w3id.org/rdfp/example/graph/xml&gt; a rdfp:GraphPresentation ;
    ///         rdfp:mediaType "application/xml" ;
    ///         rdfp:liftingRule &lt;https://w3id.org/rdfp/example/graph/xml/lifingRule&gt; ;
    ///         rdfp:loweringRule &lt;https://w3id.org/rdfp/example/graph/xml/loweringRule&gt; .
    /// <see href="https://w3id.org/rdfp/GraphPresentation"></see></summary>
    let GraphPresentation =
        Namespaced_IRI.parse _namespace_name "GraphPresentation" |> NamespacedName

    /// <summary>
    /// The class of graph validation rules resources.
    ///   Such resources may have various representations:
    ///
    /// - a RDF Graph representation that contains SHACL instances;
    /// - a ShEx document;
    /// - a SPARQL ASK rule.
    ///
    /// For example,
    ///
    /// ```
    /// &lt;g&gt; a rdfp:GraphDescription ;
    ///   rdfp:validationRule &lt;v&gt; .
    /// ```
    ///
    /// An RDFP engine willing to validate the conformance of a graph G described by `&lt;g&gt;` with SPARQL ASK queries should follow these steps:
    ///
    /// - operate a GET request at URI `&lt;v&gt;` with accepted media type "application/sparql-query"
    /// - run the retrieved SPARQL ASK query against G.
    /// - If the result is true, then G validates against `&lt;v&gt;`.
    /// <see href="https://w3id.org/rdfp/GraphValidationRule"></see></summary>
    let GraphValidationRule =
        Namespaced_IRI.parse _namespace_name "GraphValidationRule" |> NamespacedName

    /// <summary>
    /// The class of rules that enable RDF lifting.
    /// Such rules may have various representations, such as a [RML mapping](http://rml.io), a [SPARQL-Generate](https://w3id.org/sparql-generate) or a [XSPARQL query](http://xsparql.deri.org/).
    /// <see href="https://w3id.org/rdfp/LiftingRule"></see></summary>
    let LiftingRule =
        Namespaced_IRI.parse _namespace_name "LiftingRule" |> NamespacedName

    /// <summary>
    /// The class of rules that enable RDF lowering. Such rules may have various representations, such as a [STTL rule](https://ns.inria.fr/sparql-template/).
    /// <see href="https://w3id.org/rdfp/LoweringRule"></see></summary>
    let LoweringRule =
        Namespaced_IRI.parse _namespace_name "LoweringRule" |> NamespacedName

    /// <summary>
    /// The class of web representations. A representation is also a resource.
    /// <see href="https://w3id.org/rdfp/Representation"></see></summary>
    let Representation =
        Namespaced_IRI.parse _namespace_name "Representation" |> NamespacedName

    /// <summary>
    /// The class of representation validation rules resources. Such resources may have various representations:
    ///
    /// - a JSON Schema for JSON representations;
    /// - a XML Schema for XML representations;
    /// - a XPath query that must retrieve an element to validate.
    /// <see href="https://w3id.org/rdfp/RepresentationValidationRule"></see></summary>
    let RepresentationValidationRule =
        Namespaced_IRI.parse _namespace_name "RepresentationValidationRule" |> NamespacedName

    /// <summary>
    /// Links a representation to one of its aliases.
    ///
    /// According to the Web architecture design principles, there should never be two following rdfp:alias links.
    /// <see href="https://w3id.org/rdfp/alias"></see></summary>
    let alias = Namespaced_IRI.parse _namespace_name "alias" |> NamespacedName

    /// <summary>
    /// Links a RDF graph to its description.
    /// <see href="https://w3id.org/rdfp/describedBy"></see></summary>
    let describedBy =
        Namespaced_IRI.parse _namespace_name "describedBy" |> NamespacedName

    /// <summary>
    /// Links a graph presentation to a resource that enables to lift documents to RDF.
    /// <see href="https://w3id.org/rdfp/liftingRule"></see></summary>
    let liftingRule =
        Namespaced_IRI.parse _namespace_name "liftingRule" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/rdfp/GraphRepresentation"></see>
    /// </summary>
    let GraphRepresentation =
        Namespaced_IRI.parse _namespace_name "GraphRepresentation" |> NamespacedName

    /// <summary>
    /// Links a graph description to a resource that enables to lower a RDF Graph to a document.
    /// <see href="https://w3id.org/rdfp/loweringRule"></see></summary>
    let loweringRule =
        Namespaced_IRI.parse _namespace_name "loweringRule" |> NamespacedName

    /// <summary>
    /// Links a representation to its media type.
    /// <see href="https://w3id.org/rdfp/mediaType"></see></summary>
    let mediaType = Namespaced_IRI.parse _namespace_name "mediaType" |> NamespacedName

    /// <summary>
    /// Links a RDF graph presentation to the description of RDF graphs it may present.
    /// <see href="https://w3id.org/rdfp/presentationFor"></see></summary>
    let presentationFor =
        Namespaced_IRI.parse _namespace_name "presentationFor" |> NamespacedName

    /// <summary>
    /// Links a RDF graph description to one of its presentation means.
    /// <see href="https://w3id.org/rdfp/presentedBy"></see></summary>
    let presentedBy =
        Namespaced_IRI.parse _namespace_name "presentedBy" |> NamespacedName

    /// <summary>
    /// Links a resource to one of its representations. It is expected that the representation has a media type.
    /// <see href="https://w3id.org/rdfp/representedBy"></see></summary>
    let representedBy =
        Namespaced_IRI.parse _namespace_name "representedBy" |> NamespacedName

    /// <summary>
    /// Links a graph description (resp. a presentation) to a validation rule against which graphs conforming to this description (resp. representations conforming to this presentation) should validate. Such resources may have various representations.
    ///
    /// For example, resource identified by `&lt;some_validation_rule&gt;` may have a representation as a [SPARQL ASK query](https://www.w3.org/TR/sparql11-query/#ask), as a [ShEx expression](http://shexspec.github.io/), or as a [SHACL shape](https://www.w3.org/TR/shacl/).
    /// <see href="https://w3id.org/rdfp/validationRule"></see></summary>
    let validationRule =
        Namespaced_IRI.parse _namespace_name "validationRule" |> NamespacedName
