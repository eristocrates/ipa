namespace https.spec.edmcouncil.org.fibo.ontology.FBC.FunctionalEntities.RegulatoryAgencies.slash

open DoxAletheia.Rdf_Vocabulary

module fibo_fbc_fct_rga =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/RegulatoryAgencies/"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/RegulatoryAgencies/Examiner"></see>
    /// </summary>
    let Examiner = Namespaced_IRI.parse _namespace_name "Examiner" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/RegulatoryAgencies/RegulatoryCapacity"></see>
    /// </summary>
    let RegulatoryCapacity =
        Namespaced_IRI.parse _namespace_name "RegulatoryCapacity" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/RegulatoryAgencies/GovernmentIssuedLicense"></see>
    /// </summary>
    let GovernmentIssuedLicense =
        Namespaced_IRI.parse _namespace_name "GovernmentIssuedLicense" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/RegulatoryAgencies/RegulationIdentificationScheme"></see>
    /// </summary>
    let RegulationIdentificationScheme =
        Namespaced_IRI.parse _namespace_name "RegulationIdentificationScheme" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/RegulatoryAgencies/RegulationIdentifier"></see>
    /// </summary>
    let RegulationIdentifier =
        Namespaced_IRI.parse _namespace_name "RegulationIdentifier" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/RegulatoryAgencies/TaxAuthority"></see>
    /// </summary>
    let TaxAuthority =
        Namespaced_IRI.parse _namespace_name "TaxAuthority" |> NamespacedName
