namespace https.spec.edmcouncil.org.fibo.ontology.FND.Law.LegalCore.slash

open DoxAletheia

module fibo_fnd_law_cor =
    let _namespace_name = "https://spec.edmcouncil.org/fibo/ontology/FND/Law/LegalCore/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Law/LegalCore/Constitution"></see>
    /// </summary>
    let Constitution = _prefix "Constitution"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Law/LegalCore/Law"></see>
    /// </summary>
    let Law = _prefix "Law"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Law/LegalCore/CourtOfLaw"></see>
    /// </summary>
    let CourtOfLaw = _prefix "CourtOfLaw"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Law/LegalCore/StatuteLaw"></see>
    /// </summary>
    let StatuteLaw = _prefix "StatuteLaw"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Law/LegalCore/isInForceIn"></see>
    /// </summary>
    let isInForceIn = _prefix "isInForceIn"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Law/LegalCore/hasInForce"></see>
    /// </summary>
    let hasInForce = _prefix "hasInForce"
