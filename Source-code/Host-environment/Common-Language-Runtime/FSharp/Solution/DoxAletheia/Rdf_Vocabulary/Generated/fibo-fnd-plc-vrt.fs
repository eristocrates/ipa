namespace https.spec.edmcouncil.org.fibo.ontology.FND.Places.VirtualPlaces.slash

open DoxAletheia.Rdf_Vocabulary

module fibo_fnd_plc_vrt =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/FND/Places/VirtualPlaces/"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/VirtualPlaces/ElectronicMailAddress"></see>
    /// </summary>
    let ElectronicMailAddress =
        Namespaced_IRI.parse _namespace_name "ElectronicMailAddress" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/VirtualPlaces/NetworkLocation"></see>
    /// </summary>
    let NetworkLocation =
        Namespaced_IRI.parse _namespace_name "NetworkLocation" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/VirtualPlaces/NotionalPlace"></see>
    /// </summary>
    let NotionalPlace =
        Namespaced_IRI.parse _namespace_name "NotionalPlace" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/VirtualPlaces/TelephoneNumber"></see>
    /// </summary>
    let TelephoneNumber =
        Namespaced_IRI.parse _namespace_name "TelephoneNumber" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/VirtualPlaces/hasElectronicMailAddress"></see>
    /// </summary>
    let hasElectronicMailAddress =
        Namespaced_IRI.parse _namespace_name "hasElectronicMailAddress" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/VirtualPlaces/hasTelephoneNumber"></see>
    /// </summary>
    let hasTelephoneNumber =
        Namespaced_IRI.parse _namespace_name "hasTelephoneNumber" |> NamespacedName
