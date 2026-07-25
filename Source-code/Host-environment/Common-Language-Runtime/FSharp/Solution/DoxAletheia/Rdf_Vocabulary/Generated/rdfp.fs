namespace https.w3id.org.rdfp.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module rdfp =
    let _namespace_iri = Namespace_Iri rdfp |> NamespaceIRI

    /// <summary>
    ///   <para>rdfp:RepresentationValidationRule</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The class of representation validation rules resources. Such resources may have various representations:
    ///
    /// - a JSON Schema for JSON representations;
    /// - a XML Schema for XML representations;
    /// - a XPath query that must retrieve an element to validate.</para>
    /// labels<para>Representation Validation Rule</para></remarks>
    /// <seealso href="https://w3id.org/rdfp/RepresentationValidationRule">https://w3id.org/rdfp/RepresentationValidationRule</seealso>
    let RepresentationValidationRule =
        Prefixed_Name(rdfp, "RepresentationValidationRule") |> PrefixedName

    /// <summary>
    ///   <para>rdfp:liftingRule</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Links a graph presentation to a resource that enables to lift documents to RDF.</para>
    /// labels<para>lifting rule</para></remarks>
    /// <seealso href="https://w3id.org/rdfp/liftingRule">https://w3id.org/rdfp/liftingRule</seealso>
    let liftingRule = Prefixed_Name(rdfp, "liftingRule") |> PrefixedName
    /// <summary>
    ///   <para>rdfp:representedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Links a resource to one of its representations. It is expected that the representation has a media type.</para>
    /// labels<para>represented by</para></remarks>
    /// <seealso href="https://w3id.org/rdfp/representedBy">https://w3id.org/rdfp/representedBy</seealso>
    let representedBy = Prefixed_Name(rdfp, "representedBy") |> PrefixedName
    /// <summary>
    ///   <para>rdfp:presentationFor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Links a RDF graph presentation to the description of RDF graphs it may present.</para>
    /// labels<para>presentation for</para></remarks>
    /// <seealso href="https://w3id.org/rdfp/presentationFor">https://w3id.org/rdfp/presentationFor</seealso>
    let presentationFor = Prefixed_Name(rdfp, "presentationFor") |> PrefixedName
    /// <summary>
    ///   <para>rdfp:presentedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Links a RDF graph description to one of its presentation means.</para>
    /// labels<para>presented by</para></remarks>
    /// <seealso href="https://w3id.org/rdfp/presentedBy">https://w3id.org/rdfp/presentedBy</seealso>
    let presentedBy = Prefixed_Name(rdfp, "presentedBy") |> PrefixedName
    /// <summary>
    ///   <para>rdfp:validationRule</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Links a graph description (resp. a presentation) to a validation rule against which graphs conforming to this description (resp. representations conforming to this presentation) should validate. Such resources may have various representations.
    ///
    /// For example, resource identified by `&lt;some_validation_rule&gt;` may have a representation as a [SPARQL ASK query](https://www.w3.org/TR/sparql11-query/#ask), as a [ShEx expression](http://shexspec.github.io/), or as a [SHACL shape](https://www.w3.org/TR/shacl/).</para>
    /// labels<para>validation rule</para></remarks>
    /// <seealso href="https://w3id.org/rdfp/validationRule">https://w3id.org/rdfp/validationRule</seealso>
    let validationRule = Prefixed_Name(rdfp, "validationRule") |> PrefixedName
    /// <summary>
    ///   <para>rdfp:</para>
    /// </summary>
    /// <remarks>
    ///   <para>voaf:Vocabulary</para>
    ///   <para>owl:Ontology</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/rdfp/">https://w3id.org/rdfp/</seealso>
    let _prefix_iri = Prefixed_Name(rdfp, "") |> PrefixedName
    /// <summary>
    ///   <para>rdfp:rdfp-1.0</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/rdfp/rdfp-1.0">https://w3id.org/rdfp/rdfp-1.0</seealso>
    let ``rdfp_1.0`` = Prefixed_Name(rdfp, "rdfp-1.0") |> PrefixedName
    /// <summary>
    ///   <para>rdfp:Graph</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Instances of rdfp:Graph are RDF graph resources that may have several representations.
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
    /// labels<para>Graph</para></remarks>
    /// <seealso href="https://w3id.org/rdfp/Graph">https://w3id.org/rdfp/Graph</seealso>
    let Graph = Prefixed_Name(rdfp, "Graph") |> PrefixedName
    /// <summary>
    ///   <para>rdfp:Resource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The class of web resources, that have one or several representations.</para>
    /// labels<para>Resource</para></remarks>
    /// <seealso href="https://w3id.org/rdfp/Resource">https://w3id.org/rdfp/Resource</seealso>
    let Resource = Prefixed_Name(rdfp, "Resource") |> PrefixedName
    /// <summary>
    ///   <para>rdfp:GraphDescription</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Instances of rdfp:GraphDescription describe RDF Graphs in terms of validation and presentation.
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
    /// labels<para>Graph Description</para></remarks>
    /// <seealso href="https://w3id.org/rdfp/GraphDescription">https://w3id.org/rdfp/GraphDescription</seealso>
    let GraphDescription = Prefixed_Name(rdfp, "GraphDescription") |> PrefixedName
    /// <summary>
    ///   <para>rdfp:GraphPresentation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Instances of rdfp:GraphPresentation describe RDF Graph presentations in terms of lifting, lowering, and validation rules.
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
    /// labels<para>Presentation</para></remarks>
    /// <seealso href="https://w3id.org/rdfp/GraphPresentation">https://w3id.org/rdfp/GraphPresentation</seealso>
    let GraphPresentation = Prefixed_Name(rdfp, "GraphPresentation") |> PrefixedName
    /// <summary>
    ///   <para>rdfp:GraphValidationRule</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The class of graph validation rules resources.
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
    /// labels<para>Graph Validation Rule</para></remarks>
    /// <seealso href="https://w3id.org/rdfp/GraphValidationRule">https://w3id.org/rdfp/GraphValidationRule</seealso>
    let GraphValidationRule = Prefixed_Name(rdfp, "GraphValidationRule") |> PrefixedName
    /// <summary>
    ///   <para>rdfp:LiftingRule</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The class of rules that enable RDF lifting.
    /// Such rules may have various representations, such as a [RML mapping](http://rml.io), a [SPARQL-Generate](https://w3id.org/sparql-generate) or a [XSPARQL query](http://xsparql.deri.org/).</para>
    /// labels<para>Lifting Rule</para></remarks>
    /// <seealso href="https://w3id.org/rdfp/LiftingRule">https://w3id.org/rdfp/LiftingRule</seealso>
    let LiftingRule = Prefixed_Name(rdfp, "LiftingRule") |> PrefixedName
    /// <summary>
    ///   <para>rdfp:LoweringRule</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The class of rules that enable RDF lowering. Such rules may have various representations, such as a [STTL rule](https://ns.inria.fr/sparql-template/).</para>
    /// labels<para>Lowering Rule</para></remarks>
    /// <seealso href="https://w3id.org/rdfp/LoweringRule">https://w3id.org/rdfp/LoweringRule</seealso>
    let LoweringRule = Prefixed_Name(rdfp, "LoweringRule") |> PrefixedName
    /// <summary>
    ///   <para>rdfp:Representation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The class of web representations. A representation is also a resource.</para>
    /// labels<para>Representation</para></remarks>
    /// <seealso href="https://w3id.org/rdfp/Representation">https://w3id.org/rdfp/Representation</seealso>
    let Representation = Prefixed_Name(rdfp, "Representation") |> PrefixedName
    /// <summary>
    ///   <para>rdfp:alias</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Links a representation to one of its aliases.
    ///
    /// According to the Web architecture design principles, there should never be two following rdfp:alias links.</para>
    /// labels<para>alias</para></remarks>
    /// <seealso href="https://w3id.org/rdfp/alias">https://w3id.org/rdfp/alias</seealso>
    let alias = Prefixed_Name(rdfp, "alias") |> PrefixedName
    /// <summary>
    ///   <para>rdfp:describedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Links a RDF graph to its description.</para>
    /// labels<para>described by</para></remarks>
    /// <seealso href="https://w3id.org/rdfp/describedBy">https://w3id.org/rdfp/describedBy</seealso>
    let describedBy = Prefixed_Name(rdfp, "describedBy") |> PrefixedName
    /// <summary>
    ///   <para>rdfp:GraphRepresentation</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/rdfp/GraphRepresentation">https://w3id.org/rdfp/GraphRepresentation</seealso>
    let GraphRepresentation = Prefixed_Name(rdfp, "GraphRepresentation") |> PrefixedName
    /// <summary>
    ///   <para>rdfp:loweringRule</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Links a graph description to a resource that enables to lower a RDF Graph to a document.</para>
    /// labels<para>lowering rule</para></remarks>
    /// <seealso href="https://w3id.org/rdfp/loweringRule">https://w3id.org/rdfp/loweringRule</seealso>
    let loweringRule = Prefixed_Name(rdfp, "loweringRule") |> PrefixedName
    /// <summary>
    ///   <para>rdfp:mediaType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Links a representation to its media type.</para>
    /// labels<para>media type</para></remarks>
    /// <seealso href="https://w3id.org/rdfp/mediaType">https://w3id.org/rdfp/mediaType</seealso>
    let mediaType = Prefixed_Name(rdfp, "mediaType") |> PrefixedName
