namespace http.data.businessgraph.io.ontology.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module ebg =
    let _namespace_iri = Namespace_Iri ebg |> NamespaceIRI
    /// <summary>
    ///   <para>ebg:</para>
    /// </summary>
    /// <remarks>
    ///   <para>doap:Project</para>
    ///   <para>nsprov:Activity</para>
    ///   <para>owl:Ontology</para>
    ///   <para>"The euBusinessGraph (`ebg:`) ontology represents companies, type/status/economic classification, addresses, identifiers, company officers (e.g., directors and CEOs), and dataset offerings.
    ///
    /// It uses `schema:domainIncludes/rangeIncludes` (which are polymorphic) to describe which properties are applicable to a class,
    /// rather than `rdfs:domain/range` (which are monomorphic) to prescribe what classes must be applied to each node using a property.
    /// We find that this enables more flexible reuse and combination of different ontologies.
    /// We reuse the following ontologies and nomenclatures, and extend them where appropriate with classes and properties:
    ///
    /// - W3C Org, W3C RegOrg (basic company data),
    ///
    /// - W3C Time (officer membership),
    ///
    /// - W3C Locn (addresses),
    ///
    /// - schema.org (domain/rangeIncludes and various properties)
    ///
    /// - DBpedia ontology (jurisdiction)
    ///
    /// - NGEO and Spatial (NUTS administrative divisions)
    ///
    /// - ADMS (identifiers),
    ///
    /// - FOAF, SIOC (blog posts),
    ///
    /// - RAMON, SKOS (NACE economic classifications and various nomenclatures),
    ///
    /// - VOID (dataset descriptions).
    ///
    /// This is only a reference. See more detail in the [EBG Semantic Model](https://docs.google.com/document/d/1dhMOTlIOC6dOK_jksJRX0CB-GIRoiYY6fWtCnZArUhU/edit) google document, which includes an informative description of classes and properties, gives examples and data provider rules, and provides more schema and instance diagrams.
    ///
    /// ## Overview
    /// The figure below gives an overview of the ontology, depicting the main classes and their relationships (i.e., object properties). The ontology covers the following areas:
    ///
    /// - Registered Organization: To represent a legal company.
    ///
    /// - Identifier System: To represent Identifier Systems. A company can have several Identifiers belonging to different Identifier Systems.
    ///
    /// - Officer: To represent associated company officers, e.g., directors.
    ///
    /// - Dataset: To represent information about datasets that are offered by company data providers.
    ///
    /// ![](https://raw.githubusercontent.com/euBusinessGraph/eubg-data/master/model/images/ontology-overview.png)
    ///
    /// ### Registered Organization (company)
    /// Registered organizations are the main entities for which information is captured in the euBusinessGraph ontology. The ontology is not concerned with unregistered informal groups. Registered organizations gain legal entity status by the act of registration and are distinct from the broader concept of organizations, groups or, in some jurisdictions, sole traders. The figure below shows the classes and properties for representing core data about a registered organization.
    ///
    /// ![](https://raw.githubusercontent.com/euBusinessGraph/eubg-data/master/model/images/ontology-company-classes.png)
    ///
    /// ### Identifier System
    /// Mechanisms to identify companies in various data sources are essential in integration of data about companies across data sources. A proper understanding of what kind of systems of identifiers can be used for companies is thus necessary in this context. We analyzed various types of identifiers commonly used for companies and collected various properties of the systems they are part of. We modelled identifiers and identifier systems explicitly in the ontology as shown in thew figure below.
    ///
    /// ![](https://raw.githubusercontent.com/euBusinessGraph/eubg-data/master/model/images/ontology-identifier-classes.png)
    ///
    /// ### Officer
    /// We use the membership model of the W3C Organization Ontology in a straightforward way to represent officer data as shown in the figure below.
    ///
    /// ![](https://raw.githubusercontent.com/euBusinessGraph/eubg-data/master/model/images/ontology-officer-classes.png)
    ///
    /// ### Dataset Descriptions
    /// Data consumers need to know how many companies are included in a data provider dataset, from which jurisdictions, and what depth of data is included (e.g., which properties, addresses with what geo resolution, etc.). We thus need to express both metadata about the dataset itself, and fine-grained statistics about the content of a dataset, as shown in the figure below.
    ///
    /// ![](https://raw.githubusercontent.com/euBusinessGraph/eubg-data/master/model/images/ontology-dataset-classes.png)
    ///
    /// "^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://data.businessgraph.io/ontology#">http://data.businessgraph.io/ontology#</seealso>
    let _prefix_iri = Prefixed_Name(ebg, "") |> PrefixedName
    /// <summary>
    ///   <para>ebg:IdentifierSystem</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>"Identifier System"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://data.businessgraph.io/ontology#IdentifierSystem">http://data.businessgraph.io/ontology#IdentifierSystem</seealso>
    let IdentifierSystem = Prefixed_Name(ebg, "IdentifierSystem") |> PrefixedName

    /// <summary>
    ///   <para>ebg:IdentifierWebResource</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>"Identifier Web Resource"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://data.businessgraph.io/ontology#IdentifierWebResource">http://data.businessgraph.io/ontology#IdentifierWebResource</seealso>
    let IdentifierWebResource =
        Prefixed_Name(ebg, "IdentifierWebResource") |> PrefixedName

    /// <summary>
    ///   <para>ebg:LAURegion</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"Local Administrative Unit"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"LAU Region"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://data.businessgraph.io/ontology#LAURegion">http://data.businessgraph.io/ontology#LAURegion</seealso>
    let LAURegion = Prefixed_Name(ebg, "LAURegion") |> PrefixedName
    /// <summary>
    ///   <para>ebg:WebResource</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>"Web Resource"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://data.businessgraph.io/ontology#WebResource">http://data.businessgraph.io/ontology#WebResource</seealso>
    let WebResource = Prefixed_Name(ebg, "WebResource") |> PrefixedName
    /// <summary>
    ///   <para>ebg:adminUnit</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.businessgraph.io/ontology#adminUnit">http://data.businessgraph.io/ontology#adminUnit</seealso>
    let adminUnit = Prefixed_Name(ebg, "adminUnit") |> PrefixedName
    /// <summary>
    ///   <para>ebg:adminUnitL3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"admin unit level 3"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://data.businessgraph.io/ontology#adminUnitL3">http://data.businessgraph.io/ontology#adminUnitL3</seealso>
    let adminUnitL3 = Prefixed_Name(ebg, "adminUnitL3") |> PrefixedName
    /// <summary>
    ///   <para>ebg:adminUnitL4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"admin unit level 4"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://data.businessgraph.io/ontology#adminUnitL4">http://data.businessgraph.io/ontology#adminUnitL4</seealso>
    let adminUnitL4 = Prefixed_Name(ebg, "adminUnitL4") |> PrefixedName
    /// <summary>
    ///   <para>ebg:adminUnitL5</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"admin unit level 5"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://data.businessgraph.io/ontology#adminUnitL5">http://data.businessgraph.io/ontology#adminUnitL5</seealso>
    let adminUnitL5 = Prefixed_Name(ebg, "adminUnitL5") |> PrefixedName
    /// <summary>
    ///   <para>ebg:adminUnitL6</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"admin unit level 6"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://data.businessgraph.io/ontology#adminUnitL6">http://data.businessgraph.io/ontology#adminUnitL6</seealso>
    let adminUnitL6 = Prefixed_Name(ebg, "adminUnitL6") |> PrefixedName
    /// <summary>
    ///   <para>ebg:dissolutionYear</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"dissolution year"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://data.businessgraph.io/ontology#dissolutionYear">http://data.businessgraph.io/ontology#dissolutionYear</seealso>
    let dissolutionYear = Prefixed_Name(ebg, "dissolutionYear") |> PrefixedName
    /// <summary>
    ///   <para>ebg:exclusionNote</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Exclusion note of a NACE classification concept"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"exclusion note"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://data.businessgraph.io/ontology#exclusionNote">http://data.businessgraph.io/ontology#exclusionNote</seealso>
    let exclusionNote = Prefixed_Name(ebg, "exclusionNote") |> PrefixedName
    /// <summary>
    ///   <para>ebg:foundingYear</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"founding year"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://data.businessgraph.io/ontology#foundingYear">http://data.businessgraph.io/ontology#foundingYear</seealso>
    let foundingYear = Prefixed_Name(ebg, "foundingYear") |> PrefixedName
    /// <summary>
    ///   <para>ebg:geoResolution</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"geocoordinate resolution"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://data.businessgraph.io/ontology#geoResolution">http://data.businessgraph.io/ontology#geoResolution</seealso>
    let geoResolution = Prefixed_Name(ebg, "geoResolution") |> PrefixedName

    /// <summary>
    ///   <para>ebg:identifierWebResource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"identifier web resource"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://data.businessgraph.io/ontology#identifierWebResource">http://data.businessgraph.io/ontology#identifierWebResource</seealso>
    let identifierWebResource =
        Prefixed_Name(ebg, "identifierWebResource") |> PrefixedName

    /// <summary>
    ///   <para>ebg:isEnumerated</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"has enumerated identifiers"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://data.businessgraph.io/ontology#isEnumerated">http://data.businessgraph.io/ontology#isEnumerated</seealso>
    let isEnumerated = Prefixed_Name(ebg, "isEnumerated") |> PrefixedName
    /// <summary>
    ///   <para>ebg:isImmutable</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"has immutable identifiers"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://data.businessgraph.io/ontology#isImmutable">http://data.businessgraph.io/ontology#isImmutable</seealso>
    let isImmutable = Prefixed_Name(ebg, "isImmutable") |> PrefixedName
    /// <summary>
    ///   <para>ebg:isOfficial</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"is official in jurisdiction"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://data.businessgraph.io/ontology#isOfficial">http://data.businessgraph.io/ontology#isOfficial</seealso>
    let isOfficial = Prefixed_Name(ebg, "isOfficial") |> PrefixedName
    /// <summary>
    ///   <para>ebg:isPersistent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"has persistent identifiers"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://data.businessgraph.io/ontology#isPersistent">http://data.businessgraph.io/ontology#isPersistent</seealso>
    let isPersistent = Prefixed_Name(ebg, "isPersistent") |> PrefixedName
    /// <summary>
    ///   <para>ebg:isPublic</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"is public"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://data.businessgraph.io/ontology#isPublic">http://data.businessgraph.io/ontology#isPublic</seealso>
    let isPublic = Prefixed_Name(ebg, "isPublic") |> PrefixedName
    /// <summary>
    ///   <para>ebg:isPubliclyTraded</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"is publicly traded"</para><para>"is publicly traded"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://data.businessgraph.io/ontology#isPubliclyTraded">http://data.businessgraph.io/ontology#isPubliclyTraded</seealso>
    let isPubliclyTraded = Prefixed_Name(ebg, "isPubliclyTraded") |> PrefixedName
    /// <summary>
    ///   <para>ebg:isSingleValued</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"is single-valued"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://data.businessgraph.io/ontology#isSingleValued">http://data.businessgraph.io/ontology#isSingleValued</seealso>
    let isSingleValued = Prefixed_Name(ebg, "isSingleValued") |> PrefixedName
    /// <summary>
    ///   <para>ebg:isStartup</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"is startup"</para><para>"is startup"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://data.businessgraph.io/ontology#isStartup">http://data.businessgraph.io/ontology#isStartup</seealso>
    let isStartup = Prefixed_Name(ebg, "isStartup") |> PrefixedName
    /// <summary>
    ///   <para>ebg:isStateOwned</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"is state owned"</para><para>"is state owned"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://data.businessgraph.io/ontology#isStateOwned">http://data.businessgraph.io/ontology#isStateOwned</seealso>
    let isStateOwned = Prefixed_Name(ebg, "isStateOwned") |> PrefixedName
    /// <summary>
    ///   <para>ebg:isUnique</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"has unique identifiers"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://data.businessgraph.io/ontology#isUnique">http://data.businessgraph.io/ontology#isUnique</seealso>
    let isUnique = Prefixed_Name(ebg, "isUnique") |> PrefixedName
    /// <summary>
    ///   <para>ebg:level</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Hierarchical level of a thesaurus concept"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"concept level"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://data.businessgraph.io/ontology#level">http://data.businessgraph.io/ontology#level</seealso>
    let level = Prefixed_Name(ebg, "level") |> PrefixedName
    /// <summary>
    ///   <para>ebg:numberOfEmployees</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"number of employees"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://data.businessgraph.io/ontology#numberOfEmployees">http://data.businessgraph.io/ontology#numberOfEmployees</seealso>
    let numberOfEmployees = Prefixed_Name(ebg, "numberOfEmployees") |> PrefixedName
    /// <summary>
    ///   <para>ebg:order</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Global order of a thesaurus concept respecting the hierarchical structure (depth-first traversal)"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"order"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://data.businessgraph.io/ontology#order">http://data.businessgraph.io/ontology#order</seealso>
    let order = Prefixed_Name(ebg, "order") |> PrefixedName
    /// <summary>
    ///   <para>ebg:orgActivityText</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"economic activity text"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://data.businessgraph.io/ontology#orgActivityText">http://data.businessgraph.io/ontology#orgActivityText</seealso>
    let orgActivityText = Prefixed_Name(ebg, "orgActivityText") |> PrefixedName

    /// <summary>
    ///   <para>ebg:orgActivityTransitive</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.businessgraph.io/ontology#orgActivityTransitive">http://data.businessgraph.io/ontology#orgActivityTransitive</seealso>
    let orgActivityTransitive =
        Prefixed_Name(ebg, "orgActivityTransitive") |> PrefixedName

    /// <summary>
    ///   <para>ebg:orgStatusText</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"status text"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://data.businessgraph.io/ontology#orgStatusText">http://data.businessgraph.io/ontology#orgStatusText</seealso>
    let orgStatusText = Prefixed_Name(ebg, "orgStatusText") |> PrefixedName
    /// <summary>
    ///   <para>ebg:orgTypeText</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"type text"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://data.businessgraph.io/ontology#orgTypeText">http://data.businessgraph.io/ontology#orgTypeText</seealso>
    let orgTypeText = Prefixed_Name(ebg, "orgTypeText") |> PrefixedName

    /// <summary>
    ///   <para>ebg:probabilityOfDefault</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.businessgraph.io/ontology#probabilityOfDefault">http://data.businessgraph.io/ontology#probabilityOfDefault</seealso>
    let probabilityOfDefault =
        Prefixed_Name(ebg, "probabilityOfDefault") |> PrefixedName

    /// <summary>
    ///   <para>ebg:ralCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"identifier system RAL code"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://data.businessgraph.io/ontology#ralCode">http://data.businessgraph.io/ontology#ralCode</seealso>
    let ralCode = Prefixed_Name(ebg, "ralCode") |> PrefixedName
    /// <summary>
    ///   <para>ebg:replacementPattern</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"replacement pattern"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://data.businessgraph.io/ontology#replacementPattern">http://data.businessgraph.io/ontology#replacementPattern</seealso>
    let replacementPattern = Prefixed_Name(ebg, "replacementPattern") |> PrefixedName
    /// <summary>
    ///   <para>ebg:rolePositionText</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"role text"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://data.businessgraph.io/ontology#rolePositionText">http://data.businessgraph.io/ontology#rolePositionText</seealso>
    let rolePositionText = Prefixed_Name(ebg, "rolePositionText") |> PrefixedName
    /// <summary>
    ///   <para>ebg:urlTemplate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"URL template"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://data.businessgraph.io/ontology#urlTemplate">http://data.businessgraph.io/ontology#urlTemplate</seealso>
    let urlTemplate = Prefixed_Name(ebg, "urlTemplate") |> PrefixedName
    /// <summary>
    ///   <para>ebg:validationRegex</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"validation regex"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://data.businessgraph.io/ontology#validationRegex">http://data.businessgraph.io/ontology#validationRegex</seealso>
    let validationRegex = Prefixed_Name(ebg, "validationRegex") |> PrefixedName
    /// <summary>
    ///   <para>ebg:validationRule</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"validation rule"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://data.businessgraph.io/ontology#validationRule">http://data.businessgraph.io/ontology#validationRule</seealso>
    let validationRule = Prefixed_Name(ebg, "validationRule") |> PrefixedName
    /// <summary>
    ///   <para>ebg:webResource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"web resource"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://data.businessgraph.io/ontology#webResource">http://data.businessgraph.io/ontology#webResource</seealso>
    let webResource = Prefixed_Name(ebg, "webResource") |> PrefixedName
