namespace http.data.press.net.ontology.identifier.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module pni =
    let _namespace_iri = Namespace_Iri pni |> NamespaceIRI
    /// <summary>
    ///   <para>pni:Authority</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The Authority for an Identifier, for example the domain or namespace within which an ID is contained</para>
    /// labels<para>The Authority for an Identifier</para></remarks>
    /// <seealso href="http://data.press.net/ontology/identifier/Authority">http://data.press.net/ontology/identifier/Authority</seealso>
    let Authority = Prefixed_Name(pni, "Authority") |> PrefixedName
    /// <summary>
    ///   <para>pni:authority</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Property defining the containing authority of an Identifier</para>
    /// labels<para>Indicates the ID Authority of an Identifier</para></remarks>
    /// <seealso href="http://data.press.net/ontology/identifier/authority">http://data.press.net/ontology/identifier/authority</seealso>
    let authority = Prefixed_Name(pni, "authority") |> PrefixedName
    /// <summary>
    ///   <para>pni:Identifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An ID for a given resource. For example a literal ID from a legacy system</para>
    /// labels<para>An Identifier for a resource</para></remarks>
    /// <seealso href="http://data.press.net/ontology/identifier/Identifier">http://data.press.net/ontology/identifier/Identifier</seealso>
    let Identifier = Prefixed_Name(pni, "Identifier") |> PrefixedName
    /// <summary>
    ///   <para>pni:value</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Property indicating the literal value of the Identifier</para>
    /// labels<para>the value of the Identifier</para></remarks>
    /// <seealso href="http://data.press.net/ontology/identifier/value">http://data.press.net/ontology/identifier/value</seealso>
    let value = Prefixed_Name(pni, "value") |> PrefixedName
    /// <summary>
    ///   <para>pni:hasIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Associates an Identifier to an Identifiable thing</para>
    /// labels<para>Associates an Identifier to an Identifiable thing</para></remarks>
    /// <seealso href="http://data.press.net/ontology/identifier/hasIdentifier">http://data.press.net/ontology/identifier/hasIdentifier</seealso>
    let hasIdentifier = Prefixed_Name(pni, "hasIdentifier") |> PrefixedName
    /// <summary>
    ///   <para>pni:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///   <para>The Identifier Ontology models non-RDF based Identifiers for resources. The enables us to maintain a mapping between RDF resources identifiers and their equivalent IDs in an alternate, non-RDF based domain.</para>
    /// </remarks>
    /// <seealso href="http://data.press.net/ontology/identifier/">http://data.press.net/ontology/identifier/</seealso>
    let _prefix_iri = Prefixed_Name(pni, "") |> PrefixedName
    /// <summary>
    ///   <para>pni:Identifiable</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An instance that is Identifiable can have an Identifier associated with it.</para>
    /// labels<para>An Identifiable resource type</para></remarks>
    /// <seealso href="http://data.press.net/ontology/identifier/Identifiable">http://data.press.net/ontology/identifier/Identifiable</seealso>
    let Identifiable = Prefixed_Name(pni, "Identifiable") |> PrefixedName
