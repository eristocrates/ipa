namespace http.purl.org.twc.ontology.cdm.owl.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module twcdm =
    let _namespace_iri = Namespace_Iri twcdm |> NamespaceIRI
    /// <summary>
    ///   <para>twcdm:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://purl.org/twc/ontology/cdm.owl#">http://purl.org/twc/ontology/cdm.owl#</seealso>
    let _prefix_iri = Prefixed_Name(twcdm, "") |> PrefixedName
    /// <summary>
    ///   <para>twcdm:conceptual_depth</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.org/twc/ontology/cdm.owl#conceptual_depth">http://purl.org/twc/ontology/cdm.owl#conceptual_depth</seealso>
    let conceptual_depth = Prefixed_Name(twcdm, "conceptual_depth") |> PrefixedName
