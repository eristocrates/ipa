namespace https.data.istex.fr.ontology.istex.hash

open DoxAletheia

module istex =
    let _namespace_name = "https://data.istex.fr/ontology/istex#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="https://data.istex.fr/ontology/istex#ContentTypeConcept"></see>
    /// </summary>
    let ContentTypeConcept = _prefix "ContentTypeConcept"
    /// <summary>
    ///   <see href="https://data.istex.fr/ontology/istex#EnrichmentProcessConcept"></see>
    /// </summary>
    let EnrichmentProcessConcept = _prefix "EnrichmentProcessConcept"
    /// <summary>
    ///   <see href="https://data.istex.fr/ontology/istex#GeographicConcept"></see>
    /// </summary>
    let GeographicConcept = _prefix "GeographicConcept"
    /// <summary>
    ///   <see href="https://data.istex.fr/ontology/istex#InistConcept"></see>
    /// </summary>
    let InistConcept = _prefix "InistConcept"
    /// <summary>
    ///   <see href="https://data.istex.fr/ontology/istex#NamedEntityConcept"></see>
    /// </summary>
    let NamedEntityConcept = _prefix "NamedEntityConcept"
    /// <summary>
    ///   <see href="https://data.istex.fr/ontology/istex#OrganizationConcept"></see>
    /// </summary>
    let OrganizationConcept = _prefix "OrganizationConcept"
    /// <summary>
    ///   <see href="https://data.istex.fr/ontology/istex#PlaceConcept"></see>
    /// </summary>
    let PlaceConcept = _prefix "PlaceConcept"
    /// <summary>
    ///   <see href="https://data.istex.fr/ontology/istex#PublicationTypeConcept"></see>
    /// </summary>
    let PublicationTypeConcept = _prefix "PublicationTypeConcept"
    /// <summary>
    ///   <see href="https://data.istex.fr/ontology/istex#PublisherConcept"></see>
    /// </summary>
    let PublisherConcept = _prefix "PublisherConcept"
    /// <summary>
    ///   <see href="https://data.istex.fr/ontology/istex#ScienceMetrixConcept"></see>
    /// </summary>
    let ScienceMetrixConcept = _prefix "ScienceMetrixConcept"
    /// <summary>
    ///   <see href="https://data.istex.fr/ontology/istex#ScientificDomain"></see>
    /// </summary>
    let ScientificDomain = _prefix "ScientificDomain"
    /// <summary>
    ///   <see href="https://data.istex.fr/ontology/istex#ScopusConcept"></see>
    /// </summary>
    let ScopusConcept = _prefix "ScopusConcept"
    /// <summary>
    ///   <see href="https://data.istex.fr/ontology/istex#WosConcept"></see>
    /// </summary>
    let WosConcept = _prefix "WosConcept"
    /// <summary>
    ///   <see href="https://data.istex.fr/ontology/istex#accessURL"></see>
    /// </summary>
    let accessURL = _prefix "accessURL"
    /// <summary>
    ///   <see href="https://data.istex.fr/ontology/istex#affiliation"></see>
    /// </summary>
    let affiliation = _prefix "affiliation"
    /// <summary>
    ///   <see href="https://data.istex.fr/ontology/istex#analysisType"></see>
    /// </summary>
    let analysisType = _prefix "analysisType"
    /// <summary>
    ///   <see href="https://data.istex.fr/ontology/istex#constraint"></see>
    /// </summary>
    let constraint_ = _prefix "constraint"
    /// <summary>
    ///   <see href="https://data.istex.fr/ontology/istex#contentType"></see>
    /// </summary>
    let contentType = _prefix "contentType"
    /// <summary>
    ///   <see href="https://data.istex.fr/ontology/istex#eISBN"></see>
    /// </summary>
    let eISBN = _prefix "eISBN"
    /// <summary>
    ///   <see href="https://data.istex.fr/ontology/istex#enrichmentProcess"></see>
    /// </summary>
    let enrichmentProcess = _prefix "enrichmentProcess"
    /// <summary>
    ///   <see href="https://data.istex.fr/ontology/istex#enrichmentType"></see>
    /// </summary>
    let enrichmentType = _prefix "enrichmentType"
    /// <summary>
    ///   <see href="https://data.istex.fr/ontology/istex#extractedEntity"></see>
    /// </summary>
    let extractedEntity = _prefix "extractedEntity"
    /// <summary>
    ///   <see href="https://data.istex.fr/ontology/istex#extractedGeog"></see>
    /// </summary>
    let extractedGeog = _prefix "extractedGeog"
    /// <summary>
    ///   <see href="https://data.istex.fr/ontology/istex#extractedOrganization"></see>
    /// </summary>
    let extractedOrganization = _prefix "extractedOrganization"
    /// <summary>
    ///   <see href="https://data.istex.fr/ontology/istex#extractedPlace"></see>
    /// </summary>
    let extractedPlace = _prefix "extractedPlace"
    /// <summary>
    ///   <see href="https://data.istex.fr/ontology/istex#idIstex"></see>
    /// </summary>
    let idIstex = _prefix "idIstex"
    /// <summary>
    ///   <see href="https://data.istex.fr/ontology/istex#identityProvider"></see>
    /// </summary>
    let identityProvider = _prefix "identityProvider"
    /// <summary>
    ///   <see href="https://data.istex.fr/ontology/istex#publicationTitle"></see>
    /// </summary>
    let publicationTitle = _prefix "publicationTitle"
    /// <summary>
    ///   <see href="https://data.istex.fr/ontology/istex#publicationType"></see>
    /// </summary>
    let publicationType = _prefix "publicationType"
    /// <summary>
    ///   <see href="https://data.istex.fr/ontology/istex#quantityOfItems"></see>
    /// </summary>
    let quantityOfItems = _prefix "quantityOfItems"
    /// <summary>
    ///   <see href="https://data.istex.fr/ontology/istex#query"></see>
    /// </summary>
    let query = _prefix "query"
    /// <summary>
    ///   <see href="https://data.istex.fr/ontology/istex#subjectInist"></see>
    /// </summary>
    let subjectInist = _prefix "subjectInist"
    /// <summary>
    ///   <see href="https://data.istex.fr/ontology/istex#subjectScienceMetrix"></see>
    /// </summary>
    let subjectScienceMetrix = _prefix "subjectScienceMetrix"
    /// <summary>
    ///   <see href="https://data.istex.fr/ontology/istex#subjectScopus"></see>
    /// </summary>
    let subjectScopus = _prefix "subjectScopus"
    /// <summary>
    ///   <see href="https://data.istex.fr/ontology/istex#subjectWos"></see>
    /// </summary>
    let subjectWos = _prefix "subjectWos"
    /// <summary>
    ///   <see href="https://data.istex.fr/ontology/istex#tool"></see>
    /// </summary>
    let tool = _prefix "tool"
