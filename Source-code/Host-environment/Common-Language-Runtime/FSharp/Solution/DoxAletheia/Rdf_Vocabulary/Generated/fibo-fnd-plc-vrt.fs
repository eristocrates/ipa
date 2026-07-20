namespace https.spec.edmcouncil.org.fibo.ontology.FND.Places.VirtualPlaces.slash

open DoxAletheia

module fibo_fnd_plc_vrt =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/FND/Places/VirtualPlaces/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/VirtualPlaces/ElectronicMailAddress"></see>
    /// </summary>
    let ElectronicMailAddress = _prefix "ElectronicMailAddress"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/VirtualPlaces/NetworkLocation"></see>
    /// </summary>
    let NetworkLocation = _prefix "NetworkLocation"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/VirtualPlaces/NotionalPlace"></see>
    /// </summary>
    let NotionalPlace = _prefix "NotionalPlace"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/VirtualPlaces/TelephoneNumber"></see>
    /// </summary>
    let TelephoneNumber = _prefix "TelephoneNumber"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/VirtualPlaces/hasElectronicMailAddress"></see>
    /// </summary>
    let hasElectronicMailAddress = _prefix "hasElectronicMailAddress"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/VirtualPlaces/hasTelephoneNumber"></see>
    /// </summary>
    let hasTelephoneNumber = _prefix "hasTelephoneNumber"
