namespace https.spec.edmcouncil.org.fibo.ontology.FND.Places.Locations.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module fibo_fnd_plc_loc =
    let _namespace_iri = Namespace_Iri fibo_fnd_plc_loc |> NamespaceIRI
    /// <summary>
    ///   <para>fibo-fnd-plc-loc:Municipality</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/Locations/Municipality">https://spec.edmcouncil.org/fibo/ontology/FND/Places/Locations/Municipality</seealso>
    let Municipality = Prefixed_Name(fibo_fnd_plc_loc, "Municipality") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fnd-plc-loc:RealEstate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/Locations/RealEstate">https://spec.edmcouncil.org/fibo/ontology/FND/Places/Locations/RealEstate</seealso>
    let RealEstate = Prefixed_Name(fibo_fnd_plc_loc, "RealEstate") |> PrefixedName
