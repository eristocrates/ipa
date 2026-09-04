#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module rdfp =
    let _prefixId = PrefixId.fromNamespaceLabel "https://w3id.org/rdfp/" "rdfp"
    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : Graph</para>
    ///   <para>rdfs:comment : Instances of rdfp:Graph are RDF graph resources that may have several representations.
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
    /// </para>
    ///   <a href="https://w3id.org/rdfp/Graph">rdfp:Graph</a>
    /// </summary>
    let Graph = _prefixId.prefix "Graph"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : Graph Description</para>
    ///   <para>rdfs:comment : Instances of rdfp:GraphDescription describe RDF Graphs in terms of validation and presentation.
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
    /// </para>
    ///   <a href="https://w3id.org/rdfp/GraphDescription">rdfp:GraphDescription</a>
    /// </summary>
    let GraphDescription = _prefixId.prefix "GraphDescription"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : Presentation</para>
    ///   <para>rdfs:comment : Instances of rdfp:GraphPresentation describe RDF Graph presentations in terms of lifting, lowering, and validation rules.
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
    ///         rdfp:loweringRule &lt;https://w3id.org/rdfp/example/graph/xml/loweringRule&gt; .</para>
    ///   <a href="https://w3id.org/rdfp/GraphPresentation">rdfp:GraphPresentation</a>
    /// </summary>
    let GraphPresentation = _prefixId.prefix "GraphPresentation"
    let GraphRepresentation = _prefixId.prefix "GraphRepresentation"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : Graph Validation Rule</para>
    ///   <para>rdfs:comment : The class of graph validation rules resources.
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
    /// - If the result is true, then G validates against `&lt;v&gt;`.</para>
    ///   <a href="https://w3id.org/rdfp/GraphValidationRule">rdfp:GraphValidationRule</a>
    /// </summary>
    let GraphValidationRule = _prefixId.prefix "GraphValidationRule"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : Lifting Rule</para>
    ///   <para>rdfs:comment : The class of rules that enable RDF lifting.
    /// Such rules may have various representations, such as a [RML mapping](http://rml.io), a [SPARQL-Generate](https://w3id.org/sparql-generate) or a [XSPARQL query](http://xsparql.deri.org/).</para>
    ///   <a href="https://w3id.org/rdfp/LiftingRule">rdfp:LiftingRule</a>
    /// </summary>
    let LiftingRule = _prefixId.prefix "LiftingRule"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : Lowering Rule</para>
    ///   <para>rdfs:comment : The class of rules that enable RDF lowering. Such rules may have various representations, such as a [STTL rule](https://ns.inria.fr/sparql-template/).</para>
    ///   <a href="https://w3id.org/rdfp/LoweringRule">rdfp:LoweringRule</a>
    /// </summary>
    let LoweringRule = _prefixId.prefix "LoweringRule"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : Representation</para>
    ///   <para>rdfs:comment : The class of web representations. A representation is also a resource.</para>
    ///   <a href="https://w3id.org/rdfp/Representation">rdfp:Representation</a>
    /// </summary>
    let Representation = _prefixId.prefix "Representation"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : Representation Validation Rule</para>
    ///   <para>rdfs:comment : The class of representation validation rules resources. Such resources may have various representations:
    ///
    /// - a JSON Schema for JSON representations;
    /// - a XML Schema for XML representations;
    /// - a XPath query that must retrieve an element to validate.</para>
    ///   <a href="https://w3id.org/rdfp/RepresentationValidationRule">rdfp:RepresentationValidationRule</a>
    /// </summary>
    let RepresentationValidationRule = _prefixId.prefix "RepresentationValidationRule"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : Resource</para>
    ///   <para>rdfs:comment : The class of web resources, that have one or several representations.</para>
    ///   <a href="https://w3id.org/rdfp/Resource">rdfp:Resource</a>
    /// </summary>
    let Resource = _prefixId.prefix "Resource"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : alias</para>
    ///   <para>rdfs:comment : Links a representation to one of its aliases.
    ///
    /// According to the Web architecture design principles, there should never be two following rdfp:alias links.</para>
    ///   <a href="https://w3id.org/rdfp/alias">rdfp:alias</a>
    /// </summary>
    let alias = _prefixId.prefix "alias"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : described by</para>
    ///   <para>rdfs:comment : Links a RDF graph to its description.</para>
    ///   <a href="https://w3id.org/rdfp/describedBy">rdfp:describedBy</a>
    /// </summary>
    let describedBy = _prefixId.prefix "describedBy"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : lifting rule</para>
    ///   <para>rdfs:comment : Links a graph presentation to a resource that enables to lift documents to RDF.</para>
    ///   <a href="https://w3id.org/rdfp/liftingRule">rdfp:liftingRule</a>
    /// </summary>
    let liftingRule = _prefixId.prefix "liftingRule"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : lowering rule</para>
    ///   <para>rdfs:comment : Links a graph description to a resource that enables to lower a RDF Graph to a document.</para>
    ///   <a href="https://w3id.org/rdfp/loweringRule">rdfp:loweringRule</a>
    /// </summary>
    let loweringRule = _prefixId.prefix "loweringRule"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : media type</para>
    ///   <para>rdfs:comment : Links a representation to its media type.</para>
    ///   <a href="https://w3id.org/rdfp/mediaType">rdfp:mediaType</a>
    /// </summary>
    let mediaType = _prefixId.prefix "mediaType"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : presentation for</para>
    ///   <para>rdfs:comment : Links a RDF graph presentation to the description of RDF graphs it may present.</para>
    ///   <a href="https://w3id.org/rdfp/presentationFor">rdfp:presentationFor</a>
    /// </summary>
    let presentationFor = _prefixId.prefix "presentationFor"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : presented by</para>
    ///   <para>rdfs:comment : Links a RDF graph description to one of its presentation means.</para>
    ///   <a href="https://w3id.org/rdfp/presentedBy">rdfp:presentedBy</a>
    /// </summary>
    let presentedBy = _prefixId.prefix "presentedBy"
    let ``rdfp_1.0`` = _prefixId.prefix "rdfp-1.0"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : represented by</para>
    ///   <para>rdfs:comment : Links a resource to one of its representations. It is expected that the representation has a media type.</para>
    ///   <a href="https://w3id.org/rdfp/representedBy">rdfp:representedBy</a>
    /// </summary>
    let representedBy = _prefixId.prefix "representedBy"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : validation rule</para>
    ///   <para>rdfs:comment : Links a graph description (resp. a presentation) to a validation rule against which graphs conforming to this description (resp. representations conforming to this presentation) should validate. Such resources may have various representations.
    ///
    /// For example, resource identified by `&lt;some_validation_rule&gt;` may have a representation as a [SPARQL ASK query](https://www.w3.org/TR/sparql11-query/#ask), as a [ShEx expression](http://shexspec.github.io/), or as a [SHACL shape](https://www.w3.org/TR/shacl/).</para>
    ///   <a href="https://w3id.org/rdfp/validationRule">rdfp:validationRule</a>
    /// </summary>
    let validationRule = _prefixId.prefix "validationRule"
