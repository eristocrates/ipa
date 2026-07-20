namespace https.w3id.org.i40.sto.hash

open DoxAletheia

module sto =
    let _namespace_name = "https://w3id.org/i40/sto#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/i40/sto#IndustryDomain"></see>
    /// </summary>
    let IndustryDomain = _prefix "IndustryDomain"
    /// <summary>
    ///   <see href="https://w3id.org/i40/sto#SDO"></see>
    /// </summary>
    let SDO = _prefix "SDO"
    /// <summary>
    ///   <see href="https://w3id.org/i40/sto#Standard"></see>
    /// </summary>
    let Standard = _prefix "Standard"
    /// <summary>
    ///   <see href="https://w3id.org/i40/sto#abbreviation"></see>
    /// </summary>
    let abbreviation = _prefix "abbreviation"
    /// <summary>
    ///   <see href="https://w3id.org/i40/sto#formationDate"></see>
    /// </summary>
    let formationDate = _prefix "formationDate"
    /// <summary>
    ///   <see href="https://w3id.org/i40/sto#hasDBpediaResource"></see>
    /// </summary>
    let hasDBpediaResource = _prefix "hasDBpediaResource"
    /// <summary>
    ///   <see href="https://w3id.org/i40/sto#hasOfficialWebsite"></see>
    /// </summary>
    let hasOfficialWebsite = _prefix "hasOfficialWebsite"
    /// <summary>
    ///   <see href="https://w3id.org/i40/sto#hasTag"></see>
    /// </summary>
    let hasTag = _prefix "hasTag"
    /// <summary>
    ///   <see href="https://w3id.org/i40/sto#hasWikidataEntity"></see>
    /// </summary>
    let hasWikidataEntity = _prefix "hasWikidataEntity"
    /// <summary>
    ///   <see href="https://w3id.org/i40/sto#hasWikipediaArticle"></see>
    /// </summary>
    let hasWikipediaArticle = _prefix "hasWikipediaArticle"
    /// <summary>
    ///   <see href="https://w3id.org/i40/sto#license"></see>
    /// </summary>
    let license = _prefix "license"
    /// <summary>
    ///   <see href="https://w3id.org/i40/sto#motivation"></see>
    /// </summary>
    let motivation = _prefix "motivation"
    /// <summary>
    ///   <see href="https://w3id.org/i40/sto#name"></see>
    /// </summary>
    let name = _prefix "name"
    /// <summary>
    ///   <see href="https://w3id.org/i40/sto#norm"></see>
    /// </summary>
    let norm = _prefix "norm"
    /// <summary>
    ///   <see href="https://w3id.org/i40/sto#published"></see>
    /// </summary>
    let published = _prefix "published"
    /// <summary>
    ///   <see href="https://w3id.org/i40/sto#publisher"></see>
    /// </summary>
    let publisher = _prefix "publisher"
    /// <summary>
    ///   <see href="https://w3id.org/i40/sto#ramiHierarchyLevel"></see>
    /// </summary>
    let ramiHierarchyLevel = _prefix "ramiHierarchyLevel"
    /// <summary>
    ///   <see href="https://w3id.org/i40/sto#relatedTo"></see>
    /// </summary>
    let relatedTo = _prefix "relatedTo"
    /// <summary>
    ///   <see href="https://w3id.org/i40/sto#scope"></see>
    /// </summary>
    let scope = _prefix "scope"
