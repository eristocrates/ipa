namespace https.spec.edmcouncil.org.fibo.ontology.FBC.FunctionalEntities.RegulatoryAgencies.slash

open DoxAletheia

module fibo_fbc_fct_rga =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/RegulatoryAgencies/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/RegulatoryAgencies/Examiner"></see>
    /// </summary>
    let Examiner = _prefix "Examiner"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/RegulatoryAgencies/RegulatoryCapacity"></see>
    /// </summary>
    let RegulatoryCapacity = _prefix "RegulatoryCapacity"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/RegulatoryAgencies/GovernmentIssuedLicense"></see>
    /// </summary>
    let GovernmentIssuedLicense = _prefix "GovernmentIssuedLicense"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/RegulatoryAgencies/RegulationIdentificationScheme"></see>
    /// </summary>
    let RegulationIdentificationScheme = _prefix "RegulationIdentificationScheme"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/RegulatoryAgencies/RegulationIdentifier"></see>
    /// </summary>
    let RegulationIdentifier = _prefix "RegulationIdentifier"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/RegulatoryAgencies/TaxAuthority"></see>
    /// </summary>
    let TaxAuthority = _prefix "TaxAuthority"
