namespace http.data.businessgraph.io.ontology.hash

open DoxAletheia.Rdf_Vocabulary

module ebg =
    let _namespace_name = "http://data.businessgraph.io/ontology#"

    /// <summary>
    ///   <see href="http://data.businessgraph.io/ontology#IdentifierSystem"></see>
    /// </summary>
    let IdentifierSystem =
        Namespaced_IRI.parse _namespace_name "IdentifierSystem" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.businessgraph.io/ontology#IdentifierWebResource"></see>
    /// </summary>
    let IdentifierWebResource =
        Namespaced_IRI.parse _namespace_name "IdentifierWebResource" |> NamespacedName

    /// <summary>
    /// Local Administrative Unit
    /// <see href="http://data.businessgraph.io/ontology#LAURegion"></see></summary>
    let LAURegion = Namespaced_IRI.parse _namespace_name "LAURegion" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.businessgraph.io/ontology#WebResource"></see>
    /// </summary>
    let WebResource =
        Namespaced_IRI.parse _namespace_name "WebResource" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.businessgraph.io/ontology#adminUnit"></see>
    /// </summary>
    let adminUnit = Namespaced_IRI.parse _namespace_name "adminUnit" |> NamespacedName
    /// <summary>
    /// Global order of a thesaurus concept respecting the hierarchical structure (depth-first traversal)
    /// <see href="http://data.businessgraph.io/ontology#order"></see></summary>
    let order = Namespaced_IRI.parse _namespace_name "order" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.businessgraph.io/ontology#adminUnitL3"></see>
    /// </summary>
    let adminUnitL3 =
        Namespaced_IRI.parse _namespace_name "adminUnitL3" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.businessgraph.io/ontology#adminUnitL4"></see>
    /// </summary>
    let adminUnitL4 =
        Namespaced_IRI.parse _namespace_name "adminUnitL4" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.businessgraph.io/ontology#adminUnitL5"></see>
    /// </summary>
    let adminUnitL5 =
        Namespaced_IRI.parse _namespace_name "adminUnitL5" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.businessgraph.io/ontology#adminUnitL6"></see>
    /// </summary>
    let adminUnitL6 =
        Namespaced_IRI.parse _namespace_name "adminUnitL6" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.businessgraph.io/ontology#dissolutionYear"></see>
    /// </summary>
    let dissolutionYear =
        Namespaced_IRI.parse _namespace_name "dissolutionYear" |> NamespacedName

    /// <summary>
    /// Exclusion note of a NACE classification concept
    /// <see href="http://data.businessgraph.io/ontology#exclusionNote"></see></summary>
    let exclusionNote =
        Namespaced_IRI.parse _namespace_name "exclusionNote" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.businessgraph.io/ontology#foundingYear"></see>
    /// </summary>
    let foundingYear =
        Namespaced_IRI.parse _namespace_name "foundingYear" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.businessgraph.io/ontology#geoResolution"></see>
    /// </summary>
    let geoResolution =
        Namespaced_IRI.parse _namespace_name "geoResolution" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.businessgraph.io/ontology#identifierWebResource"></see>
    /// </summary>
    let identifierWebResource =
        Namespaced_IRI.parse _namespace_name "identifierWebResource" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.businessgraph.io/ontology#isEnumerated"></see>
    /// </summary>
    let isEnumerated =
        Namespaced_IRI.parse _namespace_name "isEnumerated" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.businessgraph.io/ontology#isImmutable"></see>
    /// </summary>
    let isImmutable =
        Namespaced_IRI.parse _namespace_name "isImmutable" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.businessgraph.io/ontology#isOfficial"></see>
    /// </summary>
    let isOfficial = Namespaced_IRI.parse _namespace_name "isOfficial" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.businessgraph.io/ontology#isPersistent"></see>
    /// </summary>
    let isPersistent =
        Namespaced_IRI.parse _namespace_name "isPersistent" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.businessgraph.io/ontology#isPublic"></see>
    /// </summary>
    let isPublic = Namespaced_IRI.parse _namespace_name "isPublic" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.businessgraph.io/ontology#isPubliclyTraded"></see>
    /// </summary>
    let isPubliclyTraded =
        Namespaced_IRI.parse _namespace_name "isPubliclyTraded" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.businessgraph.io/ontology#isSingleValued"></see>
    /// </summary>
    let isSingleValued =
        Namespaced_IRI.parse _namespace_name "isSingleValued" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.businessgraph.io/ontology#isStartup"></see>
    /// </summary>
    let isStartup = Namespaced_IRI.parse _namespace_name "isStartup" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.businessgraph.io/ontology#isStateOwned"></see>
    /// </summary>
    let isStateOwned =
        Namespaced_IRI.parse _namespace_name "isStateOwned" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.businessgraph.io/ontology#isUnique"></see>
    /// </summary>
    let isUnique = Namespaced_IRI.parse _namespace_name "isUnique" |> NamespacedName
    /// <summary>
    /// Hierarchical level of a thesaurus concept
    /// <see href="http://data.businessgraph.io/ontology#level"></see></summary>
    let level = Namespaced_IRI.parse _namespace_name "level" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.businessgraph.io/ontology#numberOfEmployees"></see>
    /// </summary>
    let numberOfEmployees =
        Namespaced_IRI.parse _namespace_name "numberOfEmployees" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.businessgraph.io/ontology#orgActivityText"></see>
    /// </summary>
    let orgActivityText =
        Namespaced_IRI.parse _namespace_name "orgActivityText" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.businessgraph.io/ontology#orgActivityTransitive"></see>
    /// </summary>
    let orgActivityTransitive =
        Namespaced_IRI.parse _namespace_name "orgActivityTransitive" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.businessgraph.io/ontology#orgStatusText"></see>
    /// </summary>
    let orgStatusText =
        Namespaced_IRI.parse _namespace_name "orgStatusText" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.businessgraph.io/ontology#orgTypeText"></see>
    /// </summary>
    let orgTypeText =
        Namespaced_IRI.parse _namespace_name "orgTypeText" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.businessgraph.io/ontology#probabilityOfDefault"></see>
    /// </summary>
    let probabilityOfDefault =
        Namespaced_IRI.parse _namespace_name "probabilityOfDefault" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.businessgraph.io/ontology#ralCode"></see>
    /// </summary>
    let ralCode = Namespaced_IRI.parse _namespace_name "ralCode" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.businessgraph.io/ontology#replacementPattern"></see>
    /// </summary>
    let replacementPattern =
        Namespaced_IRI.parse _namespace_name "replacementPattern" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.businessgraph.io/ontology#rolePositionText"></see>
    /// </summary>
    let rolePositionText =
        Namespaced_IRI.parse _namespace_name "rolePositionText" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.businessgraph.io/ontology#urlTemplate"></see>
    /// </summary>
    let urlTemplate =
        Namespaced_IRI.parse _namespace_name "urlTemplate" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.businessgraph.io/ontology#validationRegex"></see>
    /// </summary>
    let validationRegex =
        Namespaced_IRI.parse _namespace_name "validationRegex" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.businessgraph.io/ontology#validationRule"></see>
    /// </summary>
    let validationRule =
        Namespaced_IRI.parse _namespace_name "validationRule" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.businessgraph.io/ontology#webResource"></see>
    /// </summary>
    let webResource =
        Namespaced_IRI.parse _namespace_name "webResource" |> NamespacedName
