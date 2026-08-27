namespace http.www.w3.org.ns.radion.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module radion =
    let _namespace_iri = Namespace_Iri radion |> NamespaceIRI
    /// <summary>
    ///   <para>radion:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///   <para>"This file specifies the set of RDF classes and properties used in RADion"</para>
    /// labels<para>"Repository Asset Distribution (RADion)"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/radion#">http://www.w3.org/ns/radion#</seealso>
    let _prefix_iri = Prefixed_Name(radion, "") |> PrefixedName
    /// <summary>
    ///   <para>radion:Asset</para>
    /// </summary>
    /// <remarks>
    ///   <para>"An Asset represents the conceptual content of a resource. A particular
    ///     Asset may have zero or more Distributions in different formats."</para>
    /// labels<para>"Asset"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/radion#Asset">http://www.w3.org/ns/radion#Asset</seealso>
    let Asset = Prefixed_Name(radion, "Asset") |> PrefixedName
    /// <summary>
    ///   <para>radion:Distribution</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"A Distribution is a particular representation or concretisation of an
    ///     Asset in the form of a downloadable computer file that implements the intellectual content of an
    ///     Asset. A particular Distribution is typically associated with one Asset."</para>
    /// labels<para>"Distribution"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/radion#Distribution">http://www.w3.org/ns/radion#Distribution</seealso>
    let Distribution = Prefixed_Name(radion, "Distribution") |> PrefixedName
    /// <summary>
    ///   <para>radion:Repository</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"A Repository is a system or service that provides facilities for storage and
    ///     maintenance of descriptions of Assets and Distributions. A Repository will typically contain descriptions
    ///     of several Assets and functionality that allows users to search and access these descriptions. The
    ///     Distributions - the actual files themselves - will typically be available from the Repository or
    ///     elsewhere on the World Wide Web."</para>
    /// labels<para>"Repository"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/radion#Repository">http://www.w3.org/ns/radion#Repository</seealso>
    let Repository = Prefixed_Name(radion, "Repository") |> PrefixedName
    /// <summary>
    ///   <para>radion:distribution</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The distribution relationship associates an Asset (its domain) with a Distribution (its range). It is the inverse of distributionOf"</para>
    /// labels<para>"distribution"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/radion#distribution">http://www.w3.org/ns/radion#distribution</seealso>
    let distribution = Prefixed_Name(radion, "distribution") |> PrefixedName
    /// <summary>
    ///   <para>radion:distributionOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The distributionOf relationship associates a Distribution (its domain) with the Asset (its range) of which it is a Distribution. It is the inverse of distribution"</para>
    /// labels<para>"distributionOf"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/radion#distributionOf">http://www.w3.org/ns/radion#distributionOf</seealso>
    let distributionOf = Prefixed_Name(radion, "distributionOf") |> PrefixedName
    /// <summary>
    ///   <para>radion:keyword</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"A word or phrase used to succinctly descibe the Asset"</para>
    /// labels<para>"keyword"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/radion#keyword">http://www.w3.org/ns/radion#keyword</seealso>
    let keyword = Prefixed_Name(radion, "keyword") |> PrefixedName
    /// <summary>
    ///   <para>radion:version</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The version number or other designation of the Asset; the value should be a free text string"</para>
    /// labels<para>"version"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/radion#version">http://www.w3.org/ns/radion#version</seealso>
    let version = Prefixed_Name(radion, "version") |> PrefixedName
    /// <summary>
    ///   <para>radion:versionNotes</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Notes on the particular version of the Asset."</para>
    /// labels<para>"version notes"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/radion#versionNotes">http://www.w3.org/ns/radion#versionNotes</seealso>
    let versionNotes = Prefixed_Name(radion, "versionNotes") |> PrefixedName
