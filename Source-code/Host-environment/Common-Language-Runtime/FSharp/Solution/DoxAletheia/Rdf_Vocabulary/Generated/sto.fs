namespace https.w3id.org.i40.sto.hash

open DoxAletheia.Rdf_Vocabulary

module sto =
    let _namespace_name = "https://w3id.org/i40/sto#"

    /// <summary>
    ///   <see href="https://w3id.org/i40/sto#IndustryDomain"></see>
    /// </summary>
    let IndustryDomain =
        Namespaced_IRI.parse _namespace_name "IndustryDomain" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/i40/sto#SDO"></see>
    /// </summary>
    let SDO = Namespaced_IRI.parse _namespace_name "SDO" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/i40/sto#Standard"></see>
    /// </summary>
    let Standard = Namespaced_IRI.parse _namespace_name "Standard" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/i40/sto#abbreviation"></see>
    /// </summary>
    let abbreviation =
        Namespaced_IRI.parse _namespace_name "abbreviation" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/i40/sto#formationDate"></see>
    /// </summary>
    let formationDate =
        Namespaced_IRI.parse _namespace_name "formationDate" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/i40/sto#hasDBpediaResource"></see>
    /// </summary>
    let hasDBpediaResource =
        Namespaced_IRI.parse _namespace_name "hasDBpediaResource" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/i40/sto#hasOfficialWebsite"></see>
    /// </summary>
    let hasOfficialWebsite =
        Namespaced_IRI.parse _namespace_name "hasOfficialWebsite" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/i40/sto#hasTag"></see>
    /// </summary>
    let hasTag = Namespaced_IRI.parse _namespace_name "hasTag" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/i40/sto#hasWikidataEntity"></see>
    /// </summary>
    let hasWikidataEntity =
        Namespaced_IRI.parse _namespace_name "hasWikidataEntity" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/i40/sto#hasWikipediaArticle"></see>
    /// </summary>
    let hasWikipediaArticle =
        Namespaced_IRI.parse _namespace_name "hasWikipediaArticle" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/i40/sto#license"></see>
    /// </summary>
    let license = Namespaced_IRI.parse _namespace_name "license" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/i40/sto#motivation"></see>
    /// </summary>
    let motivation = Namespaced_IRI.parse _namespace_name "motivation" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/i40/sto#name"></see>
    /// </summary>
    let name = Namespaced_IRI.parse _namespace_name "name" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/i40/sto#norm"></see>
    /// </summary>
    let norm = Namespaced_IRI.parse _namespace_name "norm" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/i40/sto#published"></see>
    /// </summary>
    let published = Namespaced_IRI.parse _namespace_name "published" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/i40/sto#publisher"></see>
    /// </summary>
    let publisher = Namespaced_IRI.parse _namespace_name "publisher" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/i40/sto#ramiHierarchyLevel"></see>
    /// </summary>
    let ramiHierarchyLevel =
        Namespaced_IRI.parse _namespace_name "ramiHierarchyLevel" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/i40/sto#relatedTo"></see>
    /// </summary>
    let relatedTo = Namespaced_IRI.parse _namespace_name "relatedTo" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/i40/sto#scope"></see>
    /// </summary>
    let scope = Namespaced_IRI.parse _namespace_name "scope" |> NamespacedName
