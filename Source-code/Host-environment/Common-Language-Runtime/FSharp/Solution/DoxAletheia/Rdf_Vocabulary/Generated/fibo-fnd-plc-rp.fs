namespace https.spec.edmcouncil.org.fibo.ontology.FND.Places.RealProperty.slash

open DoxAletheia.Rdf_Vocabulary

module fibo_fnd_plc_rp =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/FND/Places/RealProperty/"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/RealProperty/PersonalProperty"></see>
    /// </summary>
    let PersonalProperty =
        Namespaced_IRI.parse _namespace_name "PersonalProperty" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/RealProperty/RealProperty"></see>
    /// </summary>
    let RealProperty =
        Namespaced_IRI.parse _namespace_name "RealProperty" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/RealProperty/PropertyInspection"></see>
    /// </summary>
    let PropertyInspection =
        Namespaced_IRI.parse _namespace_name "PropertyInspection" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/RealProperty/PropertyInspectionReport"></see>
    /// </summary>
    let PropertyInspectionReport =
        Namespaced_IRI.parse _namespace_name "PropertyInspectionReport" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/RealProperty/RealEstate"></see>
    /// </summary>
    let RealEstate = Namespaced_IRI.parse _namespace_name "RealEstate" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/RealProperty/RealPropertyAppraisal"></see>
    /// </summary>
    let RealPropertyAppraisal =
        Namespaced_IRI.parse _namespace_name "RealPropertyAppraisal" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/RealProperty/RealPropertyIdentifier"></see>
    /// </summary>
    let RealPropertyIdentifier =
        Namespaced_IRI.parse _namespace_name "RealPropertyIdentifier" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/RealProperty/TractIdentifier"></see>
    /// </summary>
    let TractIdentifier =
        Namespaced_IRI.parse _namespace_name "TractIdentifier" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/RealProperty/TractOfLand"></see>
    /// </summary>
    let TractOfLand =
        Namespaced_IRI.parse _namespace_name "TractOfLand" |> NamespacedName
