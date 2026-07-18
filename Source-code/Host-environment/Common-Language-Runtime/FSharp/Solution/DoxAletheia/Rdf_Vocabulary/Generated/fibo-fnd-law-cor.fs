namespace https.spec.edmcouncil.org.fibo.ontology.FND.Law.LegalCore.slash

open DoxAletheia.Rdf_Vocabulary

module fibo_fnd_law_cor =
    let _namespace_name = "https://spec.edmcouncil.org/fibo/ontology/FND/Law/LegalCore/"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Law/LegalCore/Constitution"></see>
    /// </summary>
    let Constitution =
        Namespaced_IRI.parse _namespace_name "Constitution" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Law/LegalCore/Law"></see>
    /// </summary>
    let Law = Namespaced_IRI.parse _namespace_name "Law" |> NamespacedName
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Law/LegalCore/CourtOfLaw"></see>
    /// </summary>
    let CourtOfLaw = Namespaced_IRI.parse _namespace_name "CourtOfLaw" |> NamespacedName
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Law/LegalCore/StatuteLaw"></see>
    /// </summary>
    let StatuteLaw = Namespaced_IRI.parse _namespace_name "StatuteLaw" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Law/LegalCore/isInForceIn"></see>
    /// </summary>
    let isInForceIn =
        Namespaced_IRI.parse _namespace_name "isInForceIn" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Law/LegalCore/hasInForce"></see>
    /// </summary>
    let hasInForce = Namespaced_IRI.parse _namespace_name "hasInForce" |> NamespacedName
