namespace https.spec.edmcouncil.org.fibo.ontology.FND.Places.RealProperty.slash

open DoxAletheia

module fibo_fnd_plc_rp =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/FND/Places/RealProperty/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/RealProperty/PersonalProperty"></see>
    /// </summary>
    let PersonalProperty = _prefix "PersonalProperty"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/RealProperty/RealProperty"></see>
    /// </summary>
    let RealProperty = _prefix "RealProperty"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/RealProperty/PropertyInspection"></see>
    /// </summary>
    let PropertyInspection = _prefix "PropertyInspection"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/RealProperty/PropertyInspectionReport"></see>
    /// </summary>
    let PropertyInspectionReport = _prefix "PropertyInspectionReport"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/RealProperty/RealEstate"></see>
    /// </summary>
    let RealEstate = _prefix "RealEstate"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/RealProperty/RealPropertyAppraisal"></see>
    /// </summary>
    let RealPropertyAppraisal = _prefix "RealPropertyAppraisal"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/RealProperty/RealPropertyIdentifier"></see>
    /// </summary>
    let RealPropertyIdentifier = _prefix "RealPropertyIdentifier"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/RealProperty/TractIdentifier"></see>
    /// </summary>
    let TractIdentifier = _prefix "TractIdentifier"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/RealProperty/TractOfLand"></see>
    /// </summary>
    let TractOfLand = _prefix "TractOfLand"
