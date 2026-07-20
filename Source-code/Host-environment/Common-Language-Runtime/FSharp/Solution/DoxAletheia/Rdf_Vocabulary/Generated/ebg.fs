namespace http.data.businessgraph.io.ontology.hash

open DoxAletheia

module ebg =
    let _namespace_name = "http://data.businessgraph.io/ontology#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="http://data.businessgraph.io/ontology#IdentifierSystem"></see>
    /// </summary>
    let IdentifierSystem = _prefix "IdentifierSystem"
    /// <summary>
    ///   <see href="http://data.businessgraph.io/ontology#IdentifierWebResource"></see>
    /// </summary>
    let IdentifierWebResource = _prefix "IdentifierWebResource"
    /// <summary>
    /// Local Administrative Unit
    /// <see href="http://data.businessgraph.io/ontology#LAURegion"></see></summary>
    let LAURegion = _prefix "LAURegion"
    /// <summary>
    ///   <see href="http://data.businessgraph.io/ontology#WebResource"></see>
    /// </summary>
    let WebResource = _prefix "WebResource"
    /// <summary>
    ///   <see href="http://data.businessgraph.io/ontology#adminUnit"></see>
    /// </summary>
    let adminUnit = _prefix "adminUnit"
    /// <summary>
    /// Global order of a thesaurus concept respecting the hierarchical structure (depth-first traversal)
    /// <see href="http://data.businessgraph.io/ontology#order"></see></summary>
    let order = _prefix "order"
    /// <summary>
    ///   <see href="http://data.businessgraph.io/ontology#adminUnitL3"></see>
    /// </summary>
    let adminUnitL3 = _prefix "adminUnitL3"
    /// <summary>
    ///   <see href="http://data.businessgraph.io/ontology#adminUnitL4"></see>
    /// </summary>
    let adminUnitL4 = _prefix "adminUnitL4"
    /// <summary>
    ///   <see href="http://data.businessgraph.io/ontology#adminUnitL5"></see>
    /// </summary>
    let adminUnitL5 = _prefix "adminUnitL5"
    /// <summary>
    ///   <see href="http://data.businessgraph.io/ontology#adminUnitL6"></see>
    /// </summary>
    let adminUnitL6 = _prefix "adminUnitL6"
    /// <summary>
    ///   <see href="http://data.businessgraph.io/ontology#dissolutionYear"></see>
    /// </summary>
    let dissolutionYear = _prefix "dissolutionYear"
    /// <summary>
    /// Exclusion note of a NACE classification concept
    /// <see href="http://data.businessgraph.io/ontology#exclusionNote"></see></summary>
    let exclusionNote = _prefix "exclusionNote"
    /// <summary>
    ///   <see href="http://data.businessgraph.io/ontology#foundingYear"></see>
    /// </summary>
    let foundingYear = _prefix "foundingYear"
    /// <summary>
    ///   <see href="http://data.businessgraph.io/ontology#geoResolution"></see>
    /// </summary>
    let geoResolution = _prefix "geoResolution"
    /// <summary>
    ///   <see href="http://data.businessgraph.io/ontology#identifierWebResource"></see>
    /// </summary>
    let identifierWebResource = _prefix "identifierWebResource"
    /// <summary>
    ///   <see href="http://data.businessgraph.io/ontology#isEnumerated"></see>
    /// </summary>
    let isEnumerated = _prefix "isEnumerated"
    /// <summary>
    ///   <see href="http://data.businessgraph.io/ontology#isImmutable"></see>
    /// </summary>
    let isImmutable = _prefix "isImmutable"
    /// <summary>
    ///   <see href="http://data.businessgraph.io/ontology#isOfficial"></see>
    /// </summary>
    let isOfficial = _prefix "isOfficial"
    /// <summary>
    ///   <see href="http://data.businessgraph.io/ontology#isPersistent"></see>
    /// </summary>
    let isPersistent = _prefix "isPersistent"
    /// <summary>
    ///   <see href="http://data.businessgraph.io/ontology#isPublic"></see>
    /// </summary>
    let isPublic = _prefix "isPublic"
    /// <summary>
    ///   <see href="http://data.businessgraph.io/ontology#isPubliclyTraded"></see>
    /// </summary>
    let isPubliclyTraded = _prefix "isPubliclyTraded"
    /// <summary>
    ///   <see href="http://data.businessgraph.io/ontology#isSingleValued"></see>
    /// </summary>
    let isSingleValued = _prefix "isSingleValued"
    /// <summary>
    ///   <see href="http://data.businessgraph.io/ontology#isStartup"></see>
    /// </summary>
    let isStartup = _prefix "isStartup"
    /// <summary>
    ///   <see href="http://data.businessgraph.io/ontology#isStateOwned"></see>
    /// </summary>
    let isStateOwned = _prefix "isStateOwned"
    /// <summary>
    ///   <see href="http://data.businessgraph.io/ontology#isUnique"></see>
    /// </summary>
    let isUnique = _prefix "isUnique"
    /// <summary>
    /// Hierarchical level of a thesaurus concept
    /// <see href="http://data.businessgraph.io/ontology#level"></see></summary>
    let level = _prefix "level"
    /// <summary>
    ///   <see href="http://data.businessgraph.io/ontology#numberOfEmployees"></see>
    /// </summary>
    let numberOfEmployees = _prefix "numberOfEmployees"
    /// <summary>
    ///   <see href="http://data.businessgraph.io/ontology#orgActivityText"></see>
    /// </summary>
    let orgActivityText = _prefix "orgActivityText"
    /// <summary>
    ///   <see href="http://data.businessgraph.io/ontology#orgActivityTransitive"></see>
    /// </summary>
    let orgActivityTransitive = _prefix "orgActivityTransitive"
    /// <summary>
    ///   <see href="http://data.businessgraph.io/ontology#orgStatusText"></see>
    /// </summary>
    let orgStatusText = _prefix "orgStatusText"
    /// <summary>
    ///   <see href="http://data.businessgraph.io/ontology#orgTypeText"></see>
    /// </summary>
    let orgTypeText = _prefix "orgTypeText"
    /// <summary>
    ///   <see href="http://data.businessgraph.io/ontology#probabilityOfDefault"></see>
    /// </summary>
    let probabilityOfDefault = _prefix "probabilityOfDefault"
    /// <summary>
    ///   <see href="http://data.businessgraph.io/ontology#ralCode"></see>
    /// </summary>
    let ralCode = _prefix "ralCode"
    /// <summary>
    ///   <see href="http://data.businessgraph.io/ontology#replacementPattern"></see>
    /// </summary>
    let replacementPattern = _prefix "replacementPattern"
    /// <summary>
    ///   <see href="http://data.businessgraph.io/ontology#rolePositionText"></see>
    /// </summary>
    let rolePositionText = _prefix "rolePositionText"
    /// <summary>
    ///   <see href="http://data.businessgraph.io/ontology#urlTemplate"></see>
    /// </summary>
    let urlTemplate = _prefix "urlTemplate"
    /// <summary>
    ///   <see href="http://data.businessgraph.io/ontology#validationRegex"></see>
    /// </summary>
    let validationRegex = _prefix "validationRegex"
    /// <summary>
    ///   <see href="http://data.businessgraph.io/ontology#validationRule"></see>
    /// </summary>
    let validationRule = _prefix "validationRule"
    /// <summary>
    ///   <see href="http://data.businessgraph.io/ontology#webResource"></see>
    /// </summary>
    let webResource = _prefix "webResource"
