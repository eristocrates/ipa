namespace https.spec.edmcouncil.org.fibo.ontology.FND.Arrangements.MetadataFNDArrangements.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module fibo_fnd_arr_mod =
    let _namespace_iri = Namespace_Iri fibo_fnd_arr_mod |> NamespaceIRI
    /// <summary>
    ///   <para>fibo-fnd-arr-mod:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///
    /// labels<para>"Metadata for the EDMC-FIBO Foundations (FND) Arrangements Module"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/MetadataFNDArrangements/">https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/MetadataFNDArrangements/</seealso>
    let _prefix_iri = Prefixed_Name(fibo_fnd_arr_mod, "") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-arr-mod:ArrangementsModule</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-fnd-utl-av:Module</para>
    ///
    /// labels<para>"arrangements module"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/MetadataFNDArrangements/ArrangementsModule">https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/MetadataFNDArrangements/ArrangementsModule</seealso>
    let ArrangementsModule =
        Prefixed_Name(fibo_fnd_arr_mod, "ArrangementsModule") |> PrefixedName
