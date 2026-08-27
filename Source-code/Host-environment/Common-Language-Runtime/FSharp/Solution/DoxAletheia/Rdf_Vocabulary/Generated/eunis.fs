namespace http.eunis.eea.europa.eu.rdf.species_schema.rdf.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module eunis =
    let _namespace_iri = Namespace_Iri eunis |> NamespaceIRI
    /// <summary>
    ///   <para>eunis:SpeciesSynonym</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://eunis.eea.europa.eu/rdf/species-schema.rdf#SpeciesSynonym">http://eunis.eea.europa.eu/rdf/species-schema.rdf#SpeciesSynonym</seealso>
    let SpeciesSynonym = Prefixed_Name(eunis, "SpeciesSynonym") |> PrefixedName
    /// <summary>
    ///   <para>eunis:authority</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://eunis.eea.europa.eu/rdf/species-schema.rdf#authority">http://eunis.eea.europa.eu/rdf/species-schema.rdf#authority</seealso>
    let authority = Prefixed_Name(eunis, "authority") |> PrefixedName
    /// <summary>
    ///   <para>eunis:scientificName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://eunis.eea.europa.eu/rdf/species-schema.rdf#scientificName">http://eunis.eea.europa.eu/rdf/species-schema.rdf#scientificName</seealso>
    let scientificName = Prefixed_Name(eunis, "scientificName") |> PrefixedName
