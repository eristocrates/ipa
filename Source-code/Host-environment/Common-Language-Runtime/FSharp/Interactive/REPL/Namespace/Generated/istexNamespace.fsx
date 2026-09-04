#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module istex =
    let _prefixId =
        PrefixId.fromNamespaceLabel "https://data.istex.fr/ontology/istex#" "istex"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:label : istex:ContentTypeConcept</para>
    ///   <para>rdfs:comment : Décrit la structure conceptuelle des types de contenus représentés dans les documents ISTEX</para>
    ///   <a href="https://data.istex.fr/ontology/istex#ContentTypeConcept">istex:ContentTypeConcept</a>
    /// </summary>
    let ContentTypeConcept = _prefixId.prefix "ContentTypeConcept"
    /// <summary>
    ///   <para>rdfs:label : istex:EnrichmentProcessConcept</para>
    ///   <para>rdfs:comment : Décrit la structure conceptuelle des processus d'enrichissements des documents ISTEX</para>
    ///   <a href="https://data.istex.fr/ontology/istex#EnrichmentProcessConcept">istex:EnrichmentProcessConcept</a>
    /// </summary>
    let EnrichmentProcessConcept = _prefixId.prefix "EnrichmentProcessConcept"
    /// <summary>
    ///   <para>rdfs:label : istex:GeographicConcept</para>
    ///   <para>rdfs:comment : Décrit la structure conceptuelle des entités nommées de nature géographique référencées dans les documents ISTEX</para>
    ///   <a href="https://data.istex.fr/ontology/istex#GeographicConcept">istex:GeographicConcept</a>
    /// </summary>
    let GeographicConcept = _prefixId.prefix "GeographicConcept"
    /// <summary>
    ///   <para>rdfs:label : istex:InistConcept</para>
    ///   <para>rdfs:comment : Décrit la structure conceptuelle des codes de classement Inist (Pascal et Francis)</para>
    ///   <a href="https://data.istex.fr/ontology/istex#InistConcept">istex:InistConcept</a>
    /// </summary>
    let InistConcept = _prefixId.prefix "InistConcept"
    /// <summary>
    ///   <para>rdfs:label : istex:NamedEntityConcept</para>
    ///   <para>rdfs:comment : Décrit la structure conceptuelle des entités nommées en général répertoriées dans les documents ISTEX</para>
    ///   <a href="https://data.istex.fr/ontology/istex#NamedEntityConcept">istex:NamedEntityConcept</a>
    /// </summary>
    let NamedEntityConcept = _prefixId.prefix "NamedEntityConcept"
    /// <summary>
    ///   <para>rdfs:label : istex:OrganizationConcept</para>
    ///   <para>rdfs:comment : Décrit la structure conceptuelle des types d'organisations</para>
    ///   <a href="https://data.istex.fr/ontology/istex#OrganizationConcept">istex:OrganizationConcept</a>
    /// </summary>
    let OrganizationConcept = _prefixId.prefix "OrganizationConcept"
    /// <summary>
    ///   <para>rdfs:label : istex:PlaceConcept</para>
    ///   <para>rdfs:comment : Décrit la structure conceptuelle des entités nommées de type lieux référencées dans les documents ISTEX</para>
    ///   <a href="https://data.istex.fr/ontology/istex#PlaceConcept">istex:PlaceConcept</a>
    /// </summary>
    let PlaceConcept = _prefixId.prefix "PlaceConcept"
    /// <summary>
    ///   <para>rdfs:label : istex:PublicationTypeConcept</para>
    ///   <para>rdfs:comment : Décrit la structure conceptuelle des types de publication représentés dans les documents ISTEX</para>
    ///   <a href="https://data.istex.fr/ontology/istex#PublicationTypeConcept">istex:PublicationTypeConcept</a>
    /// </summary>
    let PublicationTypeConcept = _prefixId.prefix "PublicationTypeConcept"
    /// <summary>
    ///   <para>rdfs:label : istex:PublisherConcept</para>
    ///   <para>rdfs:comment : Décrit la structure conceptuelle des éditeurs (publishers) en lien avec les documents ISTEX</para>
    ///   <a href="https://data.istex.fr/ontology/istex#PublisherConcept">istex:PublisherConcept</a>
    /// </summary>
    let PublisherConcept = _prefixId.prefix "PublisherConcept"
    /// <summary>
    ///   <para>rdfs:label : istex:ScienceMetrixConcept</para>
    ///   <para>rdfs:comment : Décrit la structure conceptuelle des catégories Science Metrix</para>
    ///   <a href="https://data.istex.fr/ontology/istex#ScienceMetrixConcept">istex:ScienceMetrixConcept</a>
    /// </summary>
    let ScienceMetrixConcept = _prefixId.prefix "ScienceMetrixConcept"
    /// <summary>
    ///   <para>rdfs:label : istex:ScientificDomain</para>
    ///   <para>rdfs:comment : Décrit les domaines scientifiques présents sur le site licence nationale.</para>
    ///   <a href="https://data.istex.fr/ontology/istex#ScientificDomain">istex:ScientificDomain</a>
    /// </summary>
    let ScientificDomain = _prefixId.prefix "ScientificDomain"
    /// <summary>
    ///   <para>rdfs:label : istex:ScopusConcept</para>
    ///   <para>rdfs:comment : Décrit la structure conceptuelle des catégories Scopus</para>
    ///   <a href="https://data.istex.fr/ontology/istex#ScopusConcept">istex:ScopusConcept</a>
    /// </summary>
    let ScopusConcept = _prefixId.prefix "ScopusConcept"
    /// <summary>
    ///   <para>rdfs:label : istex:WosConcept</para>
    ///   <para>rdfs:comment : Décrit la structure conceptuelle des catégories Web of Science</para>
    ///   <a href="https://data.istex.fr/ontology/istex#WosConcept">istex:WosConcept</a>
    /// </summary>
    let WosConcept = _prefixId.prefix "WosConcept"
    /// <summary>
    ///   <para>rdfs:label : istex:addresseeWorkrdfs:label : istex:accessURL</para>
    ///   <para>rdfs:comment : Organisme pour lequel est constitué le corpusrdfs:comment : Lien direct vers le document en format PDF</para>
    ///   <a href="https://data.istex.fr/ontology/istex#accessURL">istex:accessURL</a>
    /// </summary>
    let accessURL = _prefixId.prefix "accessURL"
    /// <summary>
    ///   <para>rdfs:label : istex:affiliation</para>
    ///   <para>rdfs:comment : Décrit une affiliation d'un ou de plusieurs auteurs (physique ou moral) du document.</para>
    ///   <a href="https://data.istex.fr/ontology/istex#affiliation">istex:affiliation</a>
    /// </summary>
    let affiliation = _prefixId.prefix "affiliation"
    /// <summary>
    ///   <para>rdfs:label : istex:analysisType</para>
    ///   <para>rdfs:comment : Type d’analyse réalisée sur le corpus par le destinataire</para>
    ///   <a href="https://data.istex.fr/ontology/istex#analysisType">istex:analysisType</a>
    /// </summary>
    let analysisType = _prefixId.prefix "analysisType"
    /// <summary>
    ///   <para>rdfs:label : istex:constraint</para>
    ///   <para>rdfs:comment : Les contraintes d'utilisation du processus d'enrichissement</para>
    ///   <a href="https://data.istex.fr/ontology/istex#constraint">istex:constraint</a>
    /// </summary>
    let constraint_ = _prefixId.prefix "constraint"
    /// <summary>
    ///   <para>rdfs:label : istex:contentType</para>
    ///   <para>rdfs:comment : Type de contenus répertoriés dans les documents ISTEX</para>
    ///   <a href="https://data.istex.fr/ontology/istex#contentType">istex:contentType</a>
    /// </summary>
    let contentType = _prefixId.prefix "contentType"
    /// <summary>
    ///   <para>rdfs:label : istex:eISBN</para>
    ///   <para>rdfs:comment : Identifiant eISBN de l'objet documentaire.</para>
    ///   <a href="https://data.istex.fr/ontology/istex#eISBN">istex:eISBN</a>
    /// </summary>
    let eISBN = _prefixId.prefix "eISBN"
    /// <summary>
    ///   <para>rdfs:label : istex:enrichmentProcess</para>
    ///   <para>rdfs:comment : Processus de fabrication des enrichissements</para>
    ///   <a href="https://data.istex.fr/ontology/istex#enrichmentProcess">istex:enrichmentProcess</a>
    /// </summary>
    let enrichmentProcess = _prefixId.prefix "enrichmentProcess"
    /// <summary>
    ///   <para>rdfs:label : istex:enrichmentType</para>
    ///   <para>rdfs:comment : Indique le type d'enrichissement créé.</para>
    ///   <a href="https://data.istex.fr/ontology/istex#enrichmentType">istex:enrichmentType</a>
    /// </summary>
    let enrichmentType = _prefixId.prefix "enrichmentType"
    /// <summary>
    ///   <para>rdfs:label : istex:extractedEntity</para>
    ///   <para>rdfs:comment : Entité nommée extraite du plein texte des document ISTEX</para>
    ///   <a href="https://data.istex.fr/ontology/istex#extractedEntity">istex:extractedEntity</a>
    /// </summary>
    let extractedEntity = _prefixId.prefix "extractedEntity"
    /// <summary>
    ///   <para>rdfs:label : istex:extractedGeog</para>
    ///   <para>rdfs:comment : Entité géographique physique extraite du plein texte des documents ISTEX</para>
    ///   <a href="https://data.istex.fr/ontology/istex#extractedGeog">istex:extractedGeog</a>
    /// </summary>
    let extractedGeog = _prefixId.prefix "extractedGeog"
    /// <summary>
    ///   <para>rdfs:label : istex:extractedOrganization</para>
    ///   <para>rdfs:comment : Entité organisationnelle extraite du plein texte des documents ISTEX</para>
    ///   <a href="https://data.istex.fr/ontology/istex#extractedOrganization">istex:extractedOrganization</a>
    /// </summary>
    let extractedOrganization = _prefixId.prefix "extractedOrganization"
    /// <summary>
    ///   <para>rdfs:label : istex:extractedPlace</para>
    ///   <para>rdfs:comment : Entité géographique administrative extraite du plein texte des documents ISTEX</para>
    ///   <a href="https://data.istex.fr/ontology/istex#extractedPlace">istex:extractedPlace</a>
    /// </summary>
    let extractedPlace = _prefixId.prefix "extractedPlace"
    /// <summary>
    ///   <para>rdfs:label : istex:idIstex</para>
    ///   <para>rdfs:comment : Identifiant Istex de l'objet documentaire.</para>
    ///   <a href="https://data.istex.fr/ontology/istex#idIstex">istex:idIstex</a>
    /// </summary>
    let idIstex = _prefixId.prefix "idIstex"
    /// <summary>
    ///   <para>rdfs:label : istex:identityProvider</para>
    ///   <para>rdfs:comment : Indique le nom du fournisseur d'identité pour le jeu organization-list</para>
    ///   <a href="https://data.istex.fr/ontology/istex#identityProvider">istex:identityProvider</a>
    /// </summary>
    let identityProvider = _prefixId.prefix "identityProvider"
    /// <summary>
    ///   <para>rdfs:label : istex:publicationTitle</para>
    ///   <para>rdfs:comment : Indique le titre du périodique hébergeant le document</para>
    ///   <a href="https://data.istex.fr/ontology/istex#publicationTitle">istex:publicationTitle</a>
    /// </summary>
    let publicationTitle = _prefixId.prefix "publicationTitle"
    /// <summary>
    ///   <para>rdfs:label : istex:publicationType</para>
    ///   <para>rdfs:comment : Type de publication catégorisé dans les documents ISTEX</para>
    ///   <a href="https://data.istex.fr/ontology/istex#publicationType">istex:publicationType</a>
    /// </summary>
    let publicationType = _prefixId.prefix "publicationType"
    /// <summary>
    ///   <para>rdfs:label : istex:quantityOfItems</para>
    ///   <para>rdfs:comment : Indique le nombre de titres bibliographiques par corpus ISTEX</para>
    ///   <a href="https://data.istex.fr/ontology/istex#quantityOfItems">istex:quantityOfItems</a>
    /// </summary>
    let quantityOfItems = _prefixId.prefix "quantityOfItems"
    /// <summary>
    ///   <para>rdfs:label : istex:query^^xsd:string</para>
    ///   <para>rdfs:comment : Indique la requête (API) à réaliser pour accéder aux documents indexés par le concept décrit. Cette API permet de récupérer les documents et le nombre de documents. Préfixer la requête avec "https://api.istex.fr/document/?q=" pour activer l'API.</para>
    ///   <a href="https://data.istex.fr/ontology/istex#query">istex:query</a>
    /// </summary>
    let query = _prefixId.prefix "query"
    /// <summary>
    ///   <para>rdfs:label : istex:subjectInist</para>
    ///   <para>rdfs:comment : Indique la ou les catégorie(s) Inist du document</para>
    ///   <a href="https://data.istex.fr/ontology/istex#subjectInist">istex:subjectInist</a>
    /// </summary>
    let subjectInist = _prefixId.prefix "subjectInist"
    /// <summary>
    ///   <para>rdfs:label : istex:subjectScienceMetrix</para>
    ///   <para>rdfs:comment : Indique la ou les catégorie(s) Science Metrix du document</para>
    ///   <a href="https://data.istex.fr/ontology/istex#subjectScienceMetrix">istex:subjectScienceMetrix</a>
    /// </summary>
    let subjectScienceMetrix = _prefixId.prefix "subjectScienceMetrix"
    /// <summary>
    ///   <para>rdfs:label : istex:subjectScopus</para>
    ///   <para>rdfs:comment : Indique la ou les catégorie(s) Scopus du document</para>
    ///   <a href="https://data.istex.fr/ontology/istex#subjectScopus">istex:subjectScopus</a>
    /// </summary>
    let subjectScopus = _prefixId.prefix "subjectScopus"
    /// <summary>
    ///   <para>rdfs:label : istex:subjectWos</para>
    ///   <para>rdfs:comment : Indique la ou les catégorie(s) Web of Science du document</para>
    ///   <a href="https://data.istex.fr/ontology/istex#subjectWos">istex:subjectWos</a>
    /// </summary>
    let subjectWos = _prefixId.prefix "subjectWos"
    /// <summary>
    ///   <para>rdfs:label : istex:tool^^xsd:string</para>
    ///   <para>rdfs:comment : Indique le nom de l'outil utilisé dans les processus d'enrichissement d'ISTEX</para>
    ///   <a href="https://data.istex.fr/ontology/istex#tool">istex:tool</a>
    /// </summary>
    let tool = _prefixId.prefix "tool"
