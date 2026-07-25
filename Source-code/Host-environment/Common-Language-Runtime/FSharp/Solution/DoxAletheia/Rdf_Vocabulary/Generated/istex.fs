namespace https.data.istex.fr.ontology.istex.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module istex =
    let _namespace_iri = Namespace_Iri istex |> NamespaceIRI
    /// <summary>
    ///   <para>istex:InistConcept</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Décrit la structure conceptuelle des codes de classement Inist (Pascal et Francis)</para>
    /// labels<para>istex:InistConcept</para></remarks>
    /// <seealso href="https://data.istex.fr/ontology/istex#InistConcept">https://data.istex.fr/ontology/istex#InistConcept</seealso>
    let InistConcept = Prefixed_Name(istex, "InistConcept") |> PrefixedName
    /// <summary>
    ///   <para>istex:ContentTypeConcept</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Décrit la structure conceptuelle des types de contenus représentés dans les documents ISTEX</para>
    /// labels<para>istex:ContentTypeConcept</para></remarks>
    /// <seealso href="https://data.istex.fr/ontology/istex#ContentTypeConcept">https://data.istex.fr/ontology/istex#ContentTypeConcept</seealso>
    let ContentTypeConcept = Prefixed_Name(istex, "ContentTypeConcept") |> PrefixedName

    /// <summary>
    ///   <para>istex:EnrichmentProcessConcept</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Décrit la structure conceptuelle des processus d'enrichissements des documents ISTEX</para>
    /// labels<para>istex:EnrichmentProcessConcept</para></remarks>
    /// <seealso href="https://data.istex.fr/ontology/istex#EnrichmentProcessConcept">https://data.istex.fr/ontology/istex#EnrichmentProcessConcept</seealso>
    let EnrichmentProcessConcept =
        Prefixed_Name(istex, "EnrichmentProcessConcept") |> PrefixedName

    /// <summary>
    ///   <para>istex:PlaceConcept</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Décrit la structure conceptuelle des entités nommées de type lieux référencées dans les documents ISTEX</para>
    /// labels<para>istex:PlaceConcept</para></remarks>
    /// <seealso href="https://data.istex.fr/ontology/istex#PlaceConcept">https://data.istex.fr/ontology/istex#PlaceConcept</seealso>
    let PlaceConcept = Prefixed_Name(istex, "PlaceConcept") |> PrefixedName
    /// <summary>
    ///   <para>istex:PublisherConcept</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Décrit la structure conceptuelle des éditeurs (publishers) en lien avec les documents ISTEX</para>
    /// labels<para>istex:PublisherConcept</para></remarks>
    /// <seealso href="https://data.istex.fr/ontology/istex#PublisherConcept">https://data.istex.fr/ontology/istex#PublisherConcept</seealso>
    let PublisherConcept = Prefixed_Name(istex, "PublisherConcept") |> PrefixedName
    /// <summary>
    ///   <para>istex:ScopusConcept</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Décrit la structure conceptuelle des catégories Scopus</para>
    /// labels<para>istex:ScopusConcept</para></remarks>
    /// <seealso href="https://data.istex.fr/ontology/istex#ScopusConcept">https://data.istex.fr/ontology/istex#ScopusConcept</seealso>
    let ScopusConcept = Prefixed_Name(istex, "ScopusConcept") |> PrefixedName
    /// <summary>
    ///   <para>istex:affiliation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Décrit une affiliation d'un ou de plusieurs auteurs (physique ou moral) du document.</para>
    /// labels<para>istex:affiliation</para></remarks>
    /// <seealso href="https://data.istex.fr/ontology/istex#affiliation">https://data.istex.fr/ontology/istex#affiliation</seealso>
    let affiliation = Prefixed_Name(istex, "affiliation") |> PrefixedName
    /// <summary>
    ///   <para>istex:constraint</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Les contraintes d'utilisation du processus d'enrichissement</para>
    /// labels<para>istex:constraint</para></remarks>
    /// <seealso href="https://data.istex.fr/ontology/istex#constraint">https://data.istex.fr/ontology/istex#constraint</seealso>
    let constraint_ = Prefixed_Name(istex, "constraint") |> PrefixedName
    /// <summary>
    ///   <para>istex:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///   <para>v 1.6 30-01-2018 Ajout de la propriété istex:tool
    ///
    /// v 1.9 17-12-2018 Ajout de la propriété istex:eISBN
    ///
    /// v 1.8 11-10-2018 Ajout de la propriété istex:publicationTitle
    /// Suppression de la propriété istex:bookTitle
    /// Suppression de la propriété istex:databaseTitle
    /// Suppression de la propriété istex:journalTitle
    /// Suppression de la propriété istex:referenceWorksTitle
    /// Suppression de la propriété istex:seriesTitle
    ///
    /// v 1.7 21-09-2018 Ajout de la propriété istex:bookTitle
    /// Ajout de la propriété istex:databaseTitle
    /// Ajout de la propriété istex:journalTitle
    /// Ajout de la propriété istex:referenceWorksTitle
    /// Ajout de la propriété istex:seriesTitle
    ///
    /// v 1.6 22-05-2018 Ajout de la propriété istex:analysisType
    /// Ajout de la propriété istex:addresseeWork
    ///
    /// v 1.5 22-12-2017 Ajout de la propriété istex:subjectScopus
    /// Ajout de la classe istex:ScopusConcept
    ///
    /// v 1.4 16-10-2017 Ajout de la propriété istex:identityProvider
    /// Suppression de istex:catalog
    /// Suppression de istex:SoftwareApplication
    /// Ajout commentaires niveau Classe et Object Properties
    /// Ajout de la classe istex:NamedEntityConcept
    /// Ajout de la classe istex:EnrichmentProcessConcept
    /// Ajout de l'object property istex:enrichmentProcess
    ///
    /// V 1.3 22-09-2017 Ajout de la propriété istex:accessURL
    /// Ajout de la propriété istex:subjectLabel
    /// Ajout de la propriété istex:catalog
    /// Ajout de la Classe istex:SoftwareApplication + ajout range à istex:enrichmentType et istex:constraint
    /// Ajout de la Classe istex:PublisherConcept
    /// Suppression domaine istex:query + ajout range xsd:anyURI au lieu de rdfs:literal
    ///
    /// V 1.2 22-06-2017 Changement uri pour passer à https://data.istex.fr/ontology/istex
    /// Ajouté la propriété istex:query
    /// Ajouté les propriétés  schema:endDate et schema:startDate ainsi que la classe dct:PeriodOfTime et la propriété dct:temporal pour décrire la période de couverture des lots de chargement
    /// Ajouté la propriété istex:affiliation (existe dans MODS XML mais pas dans MODS OWL)
    /// Ajouté la propriété quantityOfItems pour décrire le nombre de titres présents dans chaque corpus ISTEX
    ///
    /// V 1.1 12-04-2017 Ajout de la classe dcterms:LinguisticSystem - les valeurs de dcterms:language sont des instances de la classe LinguisticSystem
    ///
    /// V 1.0 11-04-2017 Première version de l'ontologie basée sur bibo, skos et prov-o</para>
    /// labels<para>Ontologie du projet Istex pour le triple store Triplex</para></remarks>
    /// <seealso href="https://data.istex.fr/ontology/istex#">https://data.istex.fr/ontology/istex#</seealso>
    let _prefix_iri = Prefixed_Name(istex, "") |> PrefixedName
    /// <summary>
    ///   <para>istex:GeographicConcept</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Décrit la structure conceptuelle des entités nommées de nature géographique référencées dans les documents ISTEX</para>
    /// labels<para>istex:GeographicConcept</para></remarks>
    /// <seealso href="https://data.istex.fr/ontology/istex#GeographicConcept">https://data.istex.fr/ontology/istex#GeographicConcept</seealso>
    let GeographicConcept = Prefixed_Name(istex, "GeographicConcept") |> PrefixedName

    /// <summary>
    ///   <para>istex:OrganizationConcept</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Décrit la structure conceptuelle des types d'organisations</para>
    /// labels<para>istex:OrganizationConcept</para></remarks>
    /// <seealso href="https://data.istex.fr/ontology/istex#OrganizationConcept">https://data.istex.fr/ontology/istex#OrganizationConcept</seealso>
    let OrganizationConcept =
        Prefixed_Name(istex, "OrganizationConcept") |> PrefixedName

    /// <summary>
    ///   <para>istex:NamedEntityConcept</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Décrit la structure conceptuelle des entités nommées en général répertoriées dans les documents ISTEX</para>
    /// labels<para>istex:NamedEntityConcept</para></remarks>
    /// <seealso href="https://data.istex.fr/ontology/istex#NamedEntityConcept">https://data.istex.fr/ontology/istex#NamedEntityConcept</seealso>
    let NamedEntityConcept = Prefixed_Name(istex, "NamedEntityConcept") |> PrefixedName

    /// <summary>
    ///   <para>istex:PublicationTypeConcept</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Décrit la structure conceptuelle des types de publication représentés dans les documents ISTEX</para>
    /// labels<para>istex:PublicationTypeConcept</para></remarks>
    /// <seealso href="https://data.istex.fr/ontology/istex#PublicationTypeConcept">https://data.istex.fr/ontology/istex#PublicationTypeConcept</seealso>
    let PublicationTypeConcept =
        Prefixed_Name(istex, "PublicationTypeConcept") |> PrefixedName

    /// <summary>
    ///   <para>istex:ScientificDomain</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Décrit les domaines scientifiques présents sur le site licence nationale.</para>
    /// labels<para>istex:ScientificDomain</para></remarks>
    /// <seealso href="https://data.istex.fr/ontology/istex#ScientificDomain">https://data.istex.fr/ontology/istex#ScientificDomain</seealso>
    let ScientificDomain = Prefixed_Name(istex, "ScientificDomain") |> PrefixedName
    /// <summary>
    ///   <para>istex:accessURL</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Lien direct vers le document en format PDF</para>
    ///   <para>Organisme pour lequel est constitué le corpus</para>
    /// labels<para>istex:addresseeWork</para><para>istex:accessURL</para></remarks>
    /// <seealso href="https://data.istex.fr/ontology/istex#accessURL">https://data.istex.fr/ontology/istex#accessURL</seealso>
    let accessURL = Prefixed_Name(istex, "accessURL") |> PrefixedName

    /// <summary>
    ///   <para>istex:ScienceMetrixConcept</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Décrit la structure conceptuelle des catégories Science Metrix</para>
    /// labels<para>istex:ScienceMetrixConcept</para></remarks>
    /// <seealso href="https://data.istex.fr/ontology/istex#ScienceMetrixConcept">https://data.istex.fr/ontology/istex#ScienceMetrixConcept</seealso>
    let ScienceMetrixConcept =
        Prefixed_Name(istex, "ScienceMetrixConcept") |> PrefixedName

    /// <summary>
    ///   <para>istex:WosConcept</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Décrit la structure conceptuelle des catégories Web of Science</para>
    /// labels<para>istex:WosConcept</para></remarks>
    /// <seealso href="https://data.istex.fr/ontology/istex#WosConcept">https://data.istex.fr/ontology/istex#WosConcept</seealso>
    let WosConcept = Prefixed_Name(istex, "WosConcept") |> PrefixedName
    /// <summary>
    ///   <para>istex:analysisType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Type d’analyse réalisée sur le corpus par le destinataire</para>
    /// labels<para>istex:analysisType</para></remarks>
    /// <seealso href="https://data.istex.fr/ontology/istex#analysisType">https://data.istex.fr/ontology/istex#analysisType</seealso>
    let analysisType = Prefixed_Name(istex, "analysisType") |> PrefixedName
    /// <summary>
    ///   <para>istex:contentType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Type de contenus répertoriés dans les documents ISTEX</para>
    /// labels<para>istex:contentType</para></remarks>
    /// <seealso href="https://data.istex.fr/ontology/istex#contentType">https://data.istex.fr/ontology/istex#contentType</seealso>
    let contentType = Prefixed_Name(istex, "contentType") |> PrefixedName
    /// <summary>
    ///   <para>istex:enrichmentProcess</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Processus de fabrication des enrichissements</para>
    /// labels<para>istex:enrichmentProcess</para></remarks>
    /// <seealso href="https://data.istex.fr/ontology/istex#enrichmentProcess">https://data.istex.fr/ontology/istex#enrichmentProcess</seealso>
    let enrichmentProcess = Prefixed_Name(istex, "enrichmentProcess") |> PrefixedName
    /// <summary>
    ///   <para>istex:eISBN</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Identifiant eISBN de l'objet documentaire.</para>
    /// labels<para>istex:eISBN</para></remarks>
    /// <seealso href="https://data.istex.fr/ontology/istex#eISBN">https://data.istex.fr/ontology/istex#eISBN</seealso>
    let eISBN = Prefixed_Name(istex, "eISBN") |> PrefixedName
    /// <summary>
    ///   <para>istex:extractedEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Entité nommée extraite du plein texte des document ISTEX</para>
    /// labels<para>istex:extractedEntity</para></remarks>
    /// <seealso href="https://data.istex.fr/ontology/istex#extractedEntity">https://data.istex.fr/ontology/istex#extractedEntity</seealso>
    let extractedEntity = Prefixed_Name(istex, "extractedEntity") |> PrefixedName

    /// <summary>
    ///   <para>istex:extractedOrganization</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Entité organisationnelle extraite du plein texte des documents ISTEX</para>
    /// labels<para>istex:extractedOrganization</para></remarks>
    /// <seealso href="https://data.istex.fr/ontology/istex#extractedOrganization">https://data.istex.fr/ontology/istex#extractedOrganization</seealso>
    let extractedOrganization =
        Prefixed_Name(istex, "extractedOrganization") |> PrefixedName

    /// <summary>
    ///   <para>istex:enrichmentType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Indique le type d'enrichissement créé.</para>
    /// labels<para>istex:enrichmentType</para></remarks>
    /// <seealso href="https://data.istex.fr/ontology/istex#enrichmentType">https://data.istex.fr/ontology/istex#enrichmentType</seealso>
    let enrichmentType = Prefixed_Name(istex, "enrichmentType") |> PrefixedName
    /// <summary>
    ///   <para>istex:extractedGeog</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Entité géographique physique extraite du plein texte des documents ISTEX</para>
    /// labels<para>istex:extractedGeog</para></remarks>
    /// <seealso href="https://data.istex.fr/ontology/istex#extractedGeog">https://data.istex.fr/ontology/istex#extractedGeog</seealso>
    let extractedGeog = Prefixed_Name(istex, "extractedGeog") |> PrefixedName
    /// <summary>
    ///   <para>istex:extractedPlace</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Entité géographique administrative extraite du plein texte des documents ISTEX</para>
    /// labels<para>istex:extractedPlace</para></remarks>
    /// <seealso href="https://data.istex.fr/ontology/istex#extractedPlace">https://data.istex.fr/ontology/istex#extractedPlace</seealso>
    let extractedPlace = Prefixed_Name(istex, "extractedPlace") |> PrefixedName
    /// <summary>
    ///   <para>istex:identityProvider</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Indique le nom du fournisseur d'identité pour le jeu organization-list</para>
    /// labels<para>istex:identityProvider</para></remarks>
    /// <seealso href="https://data.istex.fr/ontology/istex#identityProvider">https://data.istex.fr/ontology/istex#identityProvider</seealso>
    let identityProvider = Prefixed_Name(istex, "identityProvider") |> PrefixedName
    /// <summary>
    ///   <para>istex:publicationType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Type de publication catégorisé dans les documents ISTEX</para>
    /// labels<para>istex:publicationType</para></remarks>
    /// <seealso href="https://data.istex.fr/ontology/istex#publicationType">https://data.istex.fr/ontology/istex#publicationType</seealso>
    let publicationType = Prefixed_Name(istex, "publicationType") |> PrefixedName
    /// <summary>
    ///   <para>istex:quantityOfItems</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Indique le nombre de titres bibliographiques par corpus ISTEX</para>
    /// labels<para>istex:quantityOfItems</para></remarks>
    /// <seealso href="https://data.istex.fr/ontology/istex#quantityOfItems">https://data.istex.fr/ontology/istex#quantityOfItems</seealso>
    let quantityOfItems = Prefixed_Name(istex, "quantityOfItems") |> PrefixedName
    /// <summary>
    ///   <para>istex:subjectScopus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Indique la ou les catégorie(s) Scopus du document</para>
    /// labels<para>istex:subjectScopus</para></remarks>
    /// <seealso href="https://data.istex.fr/ontology/istex#subjectScopus">https://data.istex.fr/ontology/istex#subjectScopus</seealso>
    let subjectScopus = Prefixed_Name(istex, "subjectScopus") |> PrefixedName
    /// <summary>
    ///   <para>istex:tool</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Indique le nom de l'outil utilisé dans les processus d'enrichissement d'ISTEX</para>
    /// labels<para>istex:tool</para></remarks>
    /// <seealso href="https://data.istex.fr/ontology/istex#tool">https://data.istex.fr/ontology/istex#tool</seealso>
    let tool = Prefixed_Name(istex, "tool") |> PrefixedName
    /// <summary>
    ///   <para>istex:idIstex</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Identifiant Istex de l'objet documentaire.</para>
    /// labels<para>istex:idIstex</para></remarks>
    /// <seealso href="https://data.istex.fr/ontology/istex#idIstex">https://data.istex.fr/ontology/istex#idIstex</seealso>
    let idIstex = Prefixed_Name(istex, "idIstex") |> PrefixedName
    /// <summary>
    ///   <para>istex:publicationTitle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Indique le titre du périodique hébergeant le document</para>
    /// labels<para>istex:publicationTitle</para></remarks>
    /// <seealso href="https://data.istex.fr/ontology/istex#publicationTitle">https://data.istex.fr/ontology/istex#publicationTitle</seealso>
    let publicationTitle = Prefixed_Name(istex, "publicationTitle") |> PrefixedName
    /// <summary>
    ///   <para>istex:subjectInist</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Indique la ou les catégorie(s) Inist du document</para>
    /// labels<para>istex:subjectInist</para></remarks>
    /// <seealso href="https://data.istex.fr/ontology/istex#subjectInist">https://data.istex.fr/ontology/istex#subjectInist</seealso>
    let subjectInist = Prefixed_Name(istex, "subjectInist") |> PrefixedName

    /// <summary>
    ///   <para>istex:subjectScienceMetrix</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Indique la ou les catégorie(s) Science Metrix du document</para>
    /// labels<para>istex:subjectScienceMetrix</para></remarks>
    /// <seealso href="https://data.istex.fr/ontology/istex#subjectScienceMetrix">https://data.istex.fr/ontology/istex#subjectScienceMetrix</seealso>
    let subjectScienceMetrix =
        Prefixed_Name(istex, "subjectScienceMetrix") |> PrefixedName

    /// <summary>
    ///   <para>istex:query</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Indique la requête (API) à réaliser pour accéder aux documents indexés par le concept décrit. Cette API permet de récupérer les documents et le nombre de documents. Préfixer la requête avec "https://api.istex.fr/document/?q=" pour activer l'API.</para>
    /// labels<para>istex:query</para></remarks>
    /// <seealso href="https://data.istex.fr/ontology/istex#query">https://data.istex.fr/ontology/istex#query</seealso>
    let query = Prefixed_Name(istex, "query") |> PrefixedName
    /// <summary>
    ///   <para>istex:subjectWos</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Indique la ou les catégorie(s) Web of Science du document</para>
    /// labels<para>istex:subjectWos</para></remarks>
    /// <seealso href="https://data.istex.fr/ontology/istex#subjectWos">https://data.istex.fr/ontology/istex#subjectWos</seealso>
    let subjectWos = Prefixed_Name(istex, "subjectWos") |> PrefixedName
