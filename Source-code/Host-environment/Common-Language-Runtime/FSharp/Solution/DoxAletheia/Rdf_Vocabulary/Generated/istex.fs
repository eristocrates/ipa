namespace https.data.istex.fr.ontology.istex.hash

open DoxAletheia.Rdf_Vocabulary

module istex =
    let _namespace_name = "https://data.istex.fr/ontology/istex#"

    /// <summary>
    ///   <see href="https://data.istex.fr/ontology/istex#ContentTypeConcept"></see>
    /// </summary>
    let ContentTypeConcept =
        Namespaced_IRI.parse _namespace_name "ContentTypeConcept" |> NamespacedName

    /// <summary>
    ///   <see href="https://data.istex.fr/ontology/istex#EnrichmentProcessConcept"></see>
    /// </summary>
    let EnrichmentProcessConcept =
        Namespaced_IRI.parse _namespace_name "EnrichmentProcessConcept" |> NamespacedName

    /// <summary>
    ///   <see href="https://data.istex.fr/ontology/istex#GeographicConcept"></see>
    /// </summary>
    let GeographicConcept =
        Namespaced_IRI.parse _namespace_name "GeographicConcept" |> NamespacedName

    /// <summary>
    ///   <see href="https://data.istex.fr/ontology/istex#InistConcept"></see>
    /// </summary>
    let InistConcept =
        Namespaced_IRI.parse _namespace_name "InistConcept" |> NamespacedName

    /// <summary>
    ///   <see href="https://data.istex.fr/ontology/istex#NamedEntityConcept"></see>
    /// </summary>
    let NamedEntityConcept =
        Namespaced_IRI.parse _namespace_name "NamedEntityConcept" |> NamespacedName

    /// <summary>
    ///   <see href="https://data.istex.fr/ontology/istex#OrganizationConcept"></see>
    /// </summary>
    let OrganizationConcept =
        Namespaced_IRI.parse _namespace_name "OrganizationConcept" |> NamespacedName

    /// <summary>
    ///   <see href="https://data.istex.fr/ontology/istex#PlaceConcept"></see>
    /// </summary>
    let PlaceConcept =
        Namespaced_IRI.parse _namespace_name "PlaceConcept" |> NamespacedName

    /// <summary>
    ///   <see href="https://data.istex.fr/ontology/istex#PublicationTypeConcept"></see>
    /// </summary>
    let PublicationTypeConcept =
        Namespaced_IRI.parse _namespace_name "PublicationTypeConcept" |> NamespacedName

    /// <summary>
    ///   <see href="https://data.istex.fr/ontology/istex#PublisherConcept"></see>
    /// </summary>
    let PublisherConcept =
        Namespaced_IRI.parse _namespace_name "PublisherConcept" |> NamespacedName

    /// <summary>
    ///   <see href="https://data.istex.fr/ontology/istex#ScienceMetrixConcept"></see>
    /// </summary>
    let ScienceMetrixConcept =
        Namespaced_IRI.parse _namespace_name "ScienceMetrixConcept" |> NamespacedName

    /// <summary>
    ///   <see href="https://data.istex.fr/ontology/istex#ScientificDomain"></see>
    /// </summary>
    let ScientificDomain =
        Namespaced_IRI.parse _namespace_name "ScientificDomain" |> NamespacedName

    /// <summary>
    ///   <see href="https://data.istex.fr/ontology/istex#ScopusConcept"></see>
    /// </summary>
    let ScopusConcept =
        Namespaced_IRI.parse _namespace_name "ScopusConcept" |> NamespacedName

    /// <summary>
    ///   <see href="https://data.istex.fr/ontology/istex#WosConcept"></see>
    /// </summary>
    let WosConcept = Namespaced_IRI.parse _namespace_name "WosConcept" |> NamespacedName
    /// <summary>
    ///   <see href="https://data.istex.fr/ontology/istex#accessURL"></see>
    /// </summary>
    let accessURL = Namespaced_IRI.parse _namespace_name "accessURL" |> NamespacedName

    /// <summary>
    ///   <see href="https://data.istex.fr/ontology/istex#affiliation"></see>
    /// </summary>
    let affiliation =
        Namespaced_IRI.parse _namespace_name "affiliation" |> NamespacedName

    /// <summary>
    ///   <see href="https://data.istex.fr/ontology/istex#analysisType"></see>
    /// </summary>
    let analysisType =
        Namespaced_IRI.parse _namespace_name "analysisType" |> NamespacedName

    /// <summary>
    ///   <see href="https://data.istex.fr/ontology/istex#constraint"></see>
    /// </summary>
    let constraint_ =
        Namespaced_IRI.parse _namespace_name "constraint" |> NamespacedName

    /// <summary>
    ///   <see href="https://data.istex.fr/ontology/istex#contentType"></see>
    /// </summary>
    let contentType =
        Namespaced_IRI.parse _namespace_name "contentType" |> NamespacedName

    /// <summary>
    ///   <see href="https://data.istex.fr/ontology/istex#eISBN"></see>
    /// </summary>
    let eISBN = Namespaced_IRI.parse _namespace_name "eISBN" |> NamespacedName

    /// <summary>
    ///   <see href="https://data.istex.fr/ontology/istex#enrichmentProcess"></see>
    /// </summary>
    let enrichmentProcess =
        Namespaced_IRI.parse _namespace_name "enrichmentProcess" |> NamespacedName

    /// <summary>
    ///   <see href="https://data.istex.fr/ontology/istex#enrichmentType"></see>
    /// </summary>
    let enrichmentType =
        Namespaced_IRI.parse _namespace_name "enrichmentType" |> NamespacedName

    /// <summary>
    ///   <see href="https://data.istex.fr/ontology/istex#extractedEntity"></see>
    /// </summary>
    let extractedEntity =
        Namespaced_IRI.parse _namespace_name "extractedEntity" |> NamespacedName

    /// <summary>
    ///   <see href="https://data.istex.fr/ontology/istex#extractedGeog"></see>
    /// </summary>
    let extractedGeog =
        Namespaced_IRI.parse _namespace_name "extractedGeog" |> NamespacedName

    /// <summary>
    ///   <see href="https://data.istex.fr/ontology/istex#extractedOrganization"></see>
    /// </summary>
    let extractedOrganization =
        Namespaced_IRI.parse _namespace_name "extractedOrganization" |> NamespacedName

    /// <summary>
    ///   <see href="https://data.istex.fr/ontology/istex#extractedPlace"></see>
    /// </summary>
    let extractedPlace =
        Namespaced_IRI.parse _namespace_name "extractedPlace" |> NamespacedName

    /// <summary>
    ///   <see href="https://data.istex.fr/ontology/istex#idIstex"></see>
    /// </summary>
    let idIstex = Namespaced_IRI.parse _namespace_name "idIstex" |> NamespacedName

    /// <summary>
    ///   <see href="https://data.istex.fr/ontology/istex#identityProvider"></see>
    /// </summary>
    let identityProvider =
        Namespaced_IRI.parse _namespace_name "identityProvider" |> NamespacedName

    /// <summary>
    ///   <see href="https://data.istex.fr/ontology/istex#publicationTitle"></see>
    /// </summary>
    let publicationTitle =
        Namespaced_IRI.parse _namespace_name "publicationTitle" |> NamespacedName

    /// <summary>
    ///   <see href="https://data.istex.fr/ontology/istex#publicationType"></see>
    /// </summary>
    let publicationType =
        Namespaced_IRI.parse _namespace_name "publicationType" |> NamespacedName

    /// <summary>
    ///   <see href="https://data.istex.fr/ontology/istex#quantityOfItems"></see>
    /// </summary>
    let quantityOfItems =
        Namespaced_IRI.parse _namespace_name "quantityOfItems" |> NamespacedName

    /// <summary>
    ///   <see href="https://data.istex.fr/ontology/istex#query"></see>
    /// </summary>
    let query = Namespaced_IRI.parse _namespace_name "query" |> NamespacedName

    /// <summary>
    ///   <see href="https://data.istex.fr/ontology/istex#subjectInist"></see>
    /// </summary>
    let subjectInist =
        Namespaced_IRI.parse _namespace_name "subjectInist" |> NamespacedName

    /// <summary>
    ///   <see href="https://data.istex.fr/ontology/istex#subjectScienceMetrix"></see>
    /// </summary>
    let subjectScienceMetrix =
        Namespaced_IRI.parse _namespace_name "subjectScienceMetrix" |> NamespacedName

    /// <summary>
    ///   <see href="https://data.istex.fr/ontology/istex#subjectScopus"></see>
    /// </summary>
    let subjectScopus =
        Namespaced_IRI.parse _namespace_name "subjectScopus" |> NamespacedName

    /// <summary>
    ///   <see href="https://data.istex.fr/ontology/istex#subjectWos"></see>
    /// </summary>
    let subjectWos = Namespaced_IRI.parse _namespace_name "subjectWos" |> NamespacedName
    /// <summary>
    ///   <see href="https://data.istex.fr/ontology/istex#tool"></see>
    /// </summary>
    let tool = Namespaced_IRI.parse _namespace_name "tool" |> NamespacedName
