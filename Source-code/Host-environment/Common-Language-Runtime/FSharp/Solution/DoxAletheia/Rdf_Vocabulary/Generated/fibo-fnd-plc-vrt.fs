namespace https.spec.edmcouncil.org.fibo.ontology.FND.Places.VirtualPlaces.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module fibo_fnd_plc_vrt =
    let _namespace_iri = Namespace_Iri fibo_fnd_plc_vrt |> NamespaceIRI
    /// <summary>
    ///   <para>fibo-fnd-plc-vrt:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///
    /// labels<para>"Virtual Places Ontology"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/VirtualPlaces/">https://spec.edmcouncil.org/fibo/ontology/FND/Places/VirtualPlaces/</seealso>
    let _prefix_iri = Prefixed_Name(fibo_fnd_plc_vrt, "") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-plc-vrt:ElectronicMailAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"electronic mail address"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/VirtualPlaces/ElectronicMailAddress">https://spec.edmcouncil.org/fibo/ontology/FND/Places/VirtualPlaces/ElectronicMailAddress</seealso>
    let ElectronicMailAddress =
        Prefixed_Name(fibo_fnd_plc_vrt, "ElectronicMailAddress") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-plc-vrt:NetworkLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"network location"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/VirtualPlaces/NetworkLocation">https://spec.edmcouncil.org/fibo/ontology/FND/Places/VirtualPlaces/NetworkLocation</seealso>
    let NetworkLocation =
        Prefixed_Name(fibo_fnd_plc_vrt, "NetworkLocation") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-plc-vrt:NotionalPlace</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"notional place"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/VirtualPlaces/NotionalPlace">https://spec.edmcouncil.org/fibo/ontology/FND/Places/VirtualPlaces/NotionalPlace</seealso>
    let NotionalPlace = Prefixed_Name(fibo_fnd_plc_vrt, "NotionalPlace") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-plc-vrt:TelephoneNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"telephone number"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/VirtualPlaces/TelephoneNumber">https://spec.edmcouncil.org/fibo/ontology/FND/Places/VirtualPlaces/TelephoneNumber</seealso>
    let TelephoneNumber =
        Prefixed_Name(fibo_fnd_plc_vrt, "TelephoneNumber") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-plc-vrt:hasElectronicMailAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has electronic mail address"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/VirtualPlaces/hasElectronicMailAddress">https://spec.edmcouncil.org/fibo/ontology/FND/Places/VirtualPlaces/hasElectronicMailAddress</seealso>
    let hasElectronicMailAddress =
        Prefixed_Name(fibo_fnd_plc_vrt, "hasElectronicMailAddress") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-plc-vrt:hasTelephoneNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has telephone number"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/VirtualPlaces/hasTelephoneNumber">https://spec.edmcouncil.org/fibo/ontology/FND/Places/VirtualPlaces/hasTelephoneNumber</seealso>
    let hasTelephoneNumber =
        Prefixed_Name(fibo_fnd_plc_vrt, "hasTelephoneNumber") |> PrefixedName
