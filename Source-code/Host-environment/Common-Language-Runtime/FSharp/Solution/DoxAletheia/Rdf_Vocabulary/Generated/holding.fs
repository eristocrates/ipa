namespace http.purl.org.ontology.holding.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module holding =
    let _namespace_iri = Namespace_Iri holding |> NamespaceIRI
    /// <summary>
    ///   <para>holding:Agent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Use one of bf:Agent or foaf:Agent</para>
    /// labels<para>Agent</para></remarks>
    /// <seealso href="http://purl.org/ontology/holding#Agent">http://purl.org/ontology/holding#Agent</seealso>
    let Agent = Prefixed_Name(holding, "Agent") |> PrefixedName
    /// <summary>
    ///   <para>holding:narrowerExemplar</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relates a document to an item that is an exemplar of a part of the document.</para>
    /// labels<para>narrower exemplar</para></remarks>
    /// <seealso href="http://purl.org/ontology/holding#narrowerExemplar">http://purl.org/ontology/holding#narrowerExemplar</seealso>
    let narrowerExemplar = Prefixed_Name(holding, "narrowerExemplar") |> PrefixedName
    /// <summary>
    ///   <para>holding:Document</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Use one of bibo:Document, foaf:Document, bf:Work or bf:Instance</para>
    /// labels<para>Document</para></remarks>
    /// <seealso href="http://purl.org/ontology/holding#Document">http://purl.org/ontology/holding#Document</seealso>
    let Document = Prefixed_Name(holding, "Document") |> PrefixedName
    /// <summary>
    ///   <para>holding:broaderExemplar</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relates a document to an item that contains an exemplar of the document as part.</para>
    /// labels<para>broader exemplar</para></remarks>
    /// <seealso href="http://purl.org/ontology/holding#broaderExemplar">http://purl.org/ontology/holding#broaderExemplar</seealso>
    let broaderExemplar = Prefixed_Name(holding, "broaderExemplar") |> PrefixedName
    /// <summary>
    ///   <para>holding:broaderExemplarOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relates an item to a document which is partly exemplified by the item.</para>
    /// labels<para>broader exemplar of</para></remarks>
    /// <seealso href="http://purl.org/ontology/holding#broaderExemplarOf">http://purl.org/ontology/holding#broaderExemplarOf</seealso>
    let broaderExemplarOf = Prefixed_Name(holding, "broaderExemplarOf") |> PrefixedName
    /// <summary>
    ///   <para>holding:Item</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Use one of bf:HeldItem frbr:Item rdac:Item</para>
    /// labels<para>Item</para></remarks>
    /// <seealso href="http://purl.org/ontology/holding#Item">http://purl.org/ontology/holding#Item</seealso>
    let Item = Prefixed_Name(holding, "Item") |> PrefixedName
    /// <summary>
    ///   <para>holding:collectedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relates a document and/or item to an agent who collects it.</para>
    ///   <para>Relates an agent to a document and/or item that is collected by the agent.</para>
    /// labels<para>collected by</para><para>collects</para></remarks>
    /// <seealso href="http://purl.org/ontology/holding#collectedBy">http://purl.org/ontology/holding#collectedBy</seealso>
    let collectedBy = Prefixed_Name(holding, "collectedBy") |> PrefixedName
    /// <summary>
    ///   <para>holding:collects</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.org/ontology/holding#collects">http://purl.org/ontology/holding#collects</seealso>
    let collects = Prefixed_Name(holding, "collects") |> PrefixedName
    /// <summary>
    ///   <para>holding:label</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A call number, shelf mark or similar label of an item</para>
    /// labels<para>label</para></remarks>
    /// <seealso href="http://purl.org/ontology/holding#label">http://purl.org/ontology/holding#label</seealso>
    let label = Prefixed_Name(holding, "label") |> PrefixedName

    /// <summary>
    ///   <para>holding:narrowerExemplarOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relates an item to a document which is partly exemplified by the item.</para>
    /// labels<para>narrower exemplar of</para></remarks>
    /// <seealso href="http://purl.org/ontology/holding#narrowerExemplarOf">http://purl.org/ontology/holding#narrowerExemplarOf</seealso>
    let narrowerExemplarOf =
        Prefixed_Name(holding, "narrowerExemplarOf") |> PrefixedName

    /// <summary>
    ///   <para>holding:exemplar</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relates a document to an item that is an exemplar of the document.</para>
    /// labels<para>has exemplar</para></remarks>
    /// <seealso href="http://purl.org/ontology/holding#exemplar">http://purl.org/ontology/holding#exemplar</seealso>
    let exemplar = Prefixed_Name(holding, "exemplar") |> PrefixedName
    /// <summary>
    ///   <para>holding:exemplarOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relates an item to the document that is exemplified by the item.</para>
    /// labels<para>is examplar of</para></remarks>
    /// <seealso href="http://purl.org/ontology/holding#exemplarOf">http://purl.org/ontology/holding#exemplarOf</seealso>
    let exemplarOf = Prefixed_Name(holding, "exemplarOf") |> PrefixedName
    /// <summary>
    ///   <para>holding:heldBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relates an item to an agent who holds the item.</para>
    /// labels<para>held by</para></remarks>
    /// <seealso href="http://purl.org/ontology/holding#heldBy">http://purl.org/ontology/holding#heldBy</seealso>
    let heldBy = Prefixed_Name(holding, "heldBy") |> PrefixedName
    /// <summary>
    ///   <para>holding:holds</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relates an agent to an item which the agent holds.</para>
    /// labels<para>holds</para></remarks>
    /// <seealso href="http://purl.org/ontology/holding#holds">http://purl.org/ontology/holding#holds</seealso>
    let holds = Prefixed_Name(holding, "holds") |> PrefixedName
