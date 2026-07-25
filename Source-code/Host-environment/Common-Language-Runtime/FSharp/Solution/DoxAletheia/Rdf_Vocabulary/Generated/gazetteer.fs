namespace http.data.ordnancesurvey.co.uk.ontology._50kGazetteer.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module gazetteer =
    let _namespace_iri = Namespace_Iri gazetteer |> NamespaceIRI
    /// <summary>
    ///   <para>gazetteer:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    /// </remarks>
    /// <seealso href="http://data.ordnancesurvey.co.uk/ontology/50kGazetteer/">http://data.ordnancesurvey.co.uk/ontology/50kGazetteer/</seealso>
    let _prefix_iri = Prefixed_Name(gazetteer, "") |> PrefixedName
