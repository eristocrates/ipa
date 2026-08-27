namespace https.spec.edmcouncil.org.fibo.ontology.FND.Places.MetadataFNDPlaces.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module fibo_fnd_plc_mod =
    let _namespace_iri = Namespace_Iri fibo_fnd_plc_mod |> NamespaceIRI
    /// <summary>
    ///   <para>fibo-fnd-plc-mod:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///
    /// labels<para>"Metadata for the EDMC-FIBO Foundations (FND) Places Module"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/MetadataFNDPlaces/">https://spec.edmcouncil.org/fibo/ontology/FND/Places/MetadataFNDPlaces/</seealso>
    let _prefix_iri = Prefixed_Name(fibo_fnd_plc_mod, "") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fnd-plc-mod:PlacesModule</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-fnd-utl-av:Module</para>
    ///
    /// labels<para>"places module"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/MetadataFNDPlaces/PlacesModule">https://spec.edmcouncil.org/fibo/ontology/FND/Places/MetadataFNDPlaces/PlacesModule</seealso>
    let PlacesModule = Prefixed_Name(fibo_fnd_plc_mod, "PlacesModule") |> PrefixedName
