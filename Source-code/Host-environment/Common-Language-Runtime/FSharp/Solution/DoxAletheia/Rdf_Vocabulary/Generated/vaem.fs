namespace http.www.linkedmodel.org.schema.vaem.hash

open DoxAletheia

module vaem =
    let _namespace_name = "http://www.linkedmodel.org/schema/vaem#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="http://www.linkedmodel.org/schema/vaem#hasGraphMetadata"></see>
    /// </summary>
    let hasGraphMetadata = _prefix "hasGraphMetadata"
    /// <summary>
    ///   <see href="http://www.linkedmodel.org/schema/vaem#GMD_VAEM"></see>
    /// </summary>
    let GMD_VAEM = _prefix "GMD_VAEM"
    /// <summary>
    ///   <see href="http://www.linkedmodel.org/schema/vaem#Aspect"></see>
    /// </summary>
    let Aspect = _prefix "Aspect"
    /// <summary>
    ///   <see href="http://www.linkedmodel.org/schema/vaem#Dimension"></see>
    /// </summary>
    let Dimension = _prefix "Dimension"
    /// <summary>
    ///   <see href="http://www.linkedmodel.org/schema/vaem#CatalogEntry"></see>
    /// </summary>
    let CatalogEntry = _prefix "CatalogEntry"
    /// <summary>
    ///   <see href="http://www.linkedmodel.org/schema/vaem#CollectionGraph"></see>
    /// </summary>
    let CollectionGraph = _prefix "CollectionGraph"
    /// <summary>
    ///   <see href="http://www.linkedmodel.org/schema/vaem#filePrefix"></see>
    /// </summary>
    let filePrefix = _prefix "filePrefix"
    /// <summary>
    ///   <see href="http://www.linkedmodel.org/schema/vaem#GraphRole"></see>
    /// </summary>
    let GraphRole = _prefix "GraphRole"
    /// <summary>
    ///   <see href="http://www.linkedmodel.org/schema/vaem#ConstraintsGraph"></see>
    /// </summary>
    let ConstraintsGraph = _prefix "ConstraintsGraph"
    /// <summary>
    ///   <see href="http://www.linkedmodel.org/schema/vaem#ControllersGraph"></see>
    /// </summary>
    let ControllersGraph = _prefix "ControllersGraph"
    /// <summary>
    ///   <see href="http://www.linkedmodel.org/schema/vaem#CurationGraph"></see>
    /// </summary>
    let CurationGraph = _prefix "CurationGraph"
    /// <summary>
    ///   <see href="http://www.linkedmodel.org/schema/vaem#DataGraph"></see>
    /// </summary>
    let DataGraph = _prefix "DataGraph"
    /// <summary>
    ///   <see href="http://www.linkedmodel.org/schema/vaem#Discipline"></see>
    /// </summary>
    let Discipline = _prefix "Discipline"
    /// <summary>
    ///   <see href="http://www.linkedmodel.org/schema/vaem#DocumentationGraph"></see>
    /// </summary>
    let DocumentationGraph = _prefix "DocumentationGraph"
    /// <summary>
    ///   <see href="http://www.linkedmodel.org/schema/vaem#Domain"></see>
    /// </summary>
    let Domain = _prefix "Domain"
    /// <summary>
    ///   <see href="http://www.linkedmodel.org/schema/vaem#FunctionsGraph"></see>
    /// </summary>
    let FunctionsGraph = _prefix "FunctionsGraph"
    /// <summary>
    ///   <see href="http://www.linkedmodel.org/schema/vaem#description"></see>
    /// </summary>
    let description = _prefix "description"
    /// <summary>
    ///   <see href="http://www.linkedmodel.org/schema/vaem#hasGraphRole"></see>
    /// </summary>
    let hasGraphRole = _prefix "hasGraphRole"
    /// <summary>
    ///   <see href="http://www.linkedmodel.org/schema/vaem#SchemaGraph"></see>
    /// </summary>
    let SchemaGraph = _prefix "SchemaGraph"
    /// <summary>
    ///   <see href="http://www.linkedmodel.org/schema/vaem#hasOwner"></see>
    /// </summary>
    let hasOwner = _prefix "hasOwner"
    /// <summary>
    ///   <see href="http://www.linkedmodel.org/schema/vaem#TopQuadrant"></see>
    /// </summary>
    let TopQuadrant = _prefix "TopQuadrant"
    /// <summary>
    ///   <see href="http://www.linkedmodel.org/schema/vaem#hasSteward"></see>
    /// </summary>
    let hasSteward = _prefix "hasSteward"
    /// <summary>
    ///   <see href="http://www.linkedmodel.org/schema/vaem#intent"></see>
    /// </summary>
    let intent = _prefix "intent"
    /// <summary>
    ///   <see href="http://www.linkedmodel.org/schema/vaem#latestPublishedVersion"></see>
    /// </summary>
    let latestPublishedVersion = _prefix "latestPublishedVersion"
    /// <summary>
    ///   <see href="http://www.linkedmodel.org/schema/vaem#logo"></see>
    /// </summary>
    let logo = _prefix "logo"
    /// <summary>
    ///   <see href="http://www.linkedmodel.org/schema/vaem#name"></see>
    /// </summary>
    let name = _prefix "name"
    /// <summary>
    ///   <see href="http://www.linkedmodel.org/schema/vaem#namespace"></see>
    /// </summary>
    let namespace_ = _prefix "namespace"
    /// <summary>
    ///   <see href="http://www.linkedmodel.org/schema/vaem#namespacePrefix"></see>
    /// </summary>
    let namespacePrefix = _prefix "namespacePrefix"
    /// <summary>
    ///   <see href="http://www.linkedmodel.org/schema/vaem#owner"></see>
    /// </summary>
    let owner = _prefix "owner"
    /// <summary>
    ///   <see href="http://www.linkedmodel.org/schema/vaem#previousPublishedVersion"></see>
    /// </summary>
    let previousPublishedVersion = _prefix "previousPublishedVersion"
    /// <summary>
    ///   <see href="http://www.linkedmodel.org/schema/vaem#rdfxmlFileURL"></see>
    /// </summary>
    let rdfxmlFileURL = _prefix "rdfxmlFileURL"
    /// <summary>
    ///   <see href="http://www.linkedmodel.org/schema/vaem#revision"></see>
    /// </summary>
    let revision = _prefix "revision"
    /// <summary>
    ///   <see href="http://www.linkedmodel.org/schema/vaem#title"></see>
    /// </summary>
    let title = _prefix "title"
    /// <summary>
    ///   <see href="http://www.linkedmodel.org/schema/vaem#turtleFileURL"></see>
    /// </summary>
    let turtleFileURL = _prefix "turtleFileURL"
    /// <summary>
    ///   <see href="http://www.linkedmodel.org/schema/vaem#usesNonImportedResource"></see>
    /// </summary>
    let usesNonImportedResource = _prefix "usesNonImportedResource"
    /// <summary>
    ///   <see href="http://www.linkedmodel.org/schema/vaem#withAttributionTo"></see>
    /// </summary>
    let withAttributionTo = _prefix "withAttributionTo"
    /// <summary>
    ///   <see href="http://www.linkedmodel.org/schema/vaem#GraphMetaData"></see>
    /// </summary>
    let GraphMetaData = _prefix "GraphMetaData"
    /// <summary>
    ///   <see href="http://www.linkedmodel.org/schema/vaem#hasAspect"></see>
    /// </summary>
    let hasAspect = _prefix "hasAspect"
    /// <summary>
    ///   <see href="http://www.linkedmodel.org/schema/vaem#hasDomain"></see>
    /// </summary>
    let hasDomain = _prefix "hasDomain"
    /// <summary>
    ///   <see href="http://www.linkedmodel.org/schema/vaem#hasDiscipline"></see>
    /// </summary>
    let hasDiscipline = _prefix "hasDiscipline"
    /// <summary>
    ///   <see href="http://www.linkedmodel.org/schema/vaem#Viewpoint"></see>
    /// </summary>
    let Viewpoint = _prefix "Viewpoint"
    /// <summary>
    ///   <see href="http://www.linkedmodel.org/schema/vaem#hasViewpoint"></see>
    /// </summary>
    let hasViewpoint = _prefix "hasViewpoint"
    /// <summary>
    ///   <see href="http://www.linkedmodel.org/schema/vaem#hasMetadata"></see>
    /// </summary>
    let hasMetadata = _prefix "hasMetadata"
    /// <summary>
    ///   <see href="http://www.linkedmodel.org/schema/vaem#hasIdentifier"></see>
    /// </summary>
    let hasIdentifier = _prefix "hasIdentifier"
    /// <summary>
    ///   <see href="http://www.linkedmodel.org/schema/vaem#hasLicenseType"></see>
    /// </summary>
    let hasLicenseType = _prefix "hasLicenseType"
    /// <summary>
    ///   <see href="http://www.linkedmodel.org/schema/vaem#Party"></see>
    /// </summary>
    let Party = _prefix "Party"
    /// <summary>
    ///   <see href="http://www.linkedmodel.org/schema/vaem#specificity"></see>
    /// </summary>
    let specificity = _prefix "specificity"
    /// <summary>
    ///   <see href="http://www.linkedmodel.org/schema/vaem#LinkSetGraph"></see>
    /// </summary>
    let LinkSetGraph = _prefix "LinkSetGraph"
    /// <summary>
    ///   <see href="http://www.linkedmodel.org/schema/vaem#MappingGraph"></see>
    /// </summary>
    let MappingGraph = _prefix "MappingGraph"
    /// <summary>
    ///   <see href="http://www.linkedmodel.org/schema/vaem#id"></see>
    /// </summary>
    let id = _prefix "id"
    /// <summary>
    ///   <see href="http://www.linkedmodel.org/schema/vaem#url"></see>
    /// </summary>
    let url = _prefix "url"
    /// <summary>
    ///   <see href="http://www.linkedmodel.org/schema/vaem#ProxyGraph"></see>
    /// </summary>
    let ProxyGraph = _prefix "ProxyGraph"
    /// <summary>
    ///   <see href="http://www.linkedmodel.org/schema/vaem#RulesGraph"></see>
    /// </summary>
    let RulesGraph = _prefix "RulesGraph"
    /// <summary>
    ///   <see href="http://www.linkedmodel.org/schema/vaem#ScriptGraph"></see>
    /// </summary>
    let ScriptGraph = _prefix "ScriptGraph"
    /// <summary>
    ///   <see href="http://www.linkedmodel.org/schema/vaem#TransformsGraph"></see>
    /// </summary>
    let TransformsGraph = _prefix "TransformsGraph"
    /// <summary>
    ///   <see href="http://www.linkedmodel.org/schema/vaem#ViewGraph"></see>
    /// </summary>
    let ViewGraph = _prefix "ViewGraph"
    /// <summary>
    ///   <see href="http://www.linkedmodel.org/schema/vaem#VocabularyGraph"></see>
    /// </summary>
    let VocabularyGraph = _prefix "VocabularyGraph"
    /// <summary>
    ///   <see href="http://www.linkedmodel.org/schema/vaem#abbreviation"></see>
    /// </summary>
    let abbreviation = _prefix "abbreviation"
    /// <summary>
    ///   <see href="http://www.linkedmodel.org/schema/vaem#acronym"></see>
    /// </summary>
    let acronym = _prefix "acronym"
    /// <summary>
    ///   <see href="http://www.linkedmodel.org/schema/vaem#comment"></see>
    /// </summary>
    let comment = _prefix "comment"
    /// <summary>
    ///   <see href="http://www.linkedmodel.org/schema/vaem#date"></see>
    /// </summary>
    let date = _prefix "date"
    /// <summary>
    ///   <see href="http://www.linkedmodel.org/schema/vaem#dateCreated"></see>
    /// </summary>
    let dateCreated = _prefix "dateCreated"
    /// <summary>
    ///   <see href="http://www.linkedmodel.org/schema/vaem#hasDimension"></see>
    /// </summary>
    let hasDimension = _prefix "hasDimension"
    /// <summary>
    ///   <see href="http://www.linkedmodel.org/schema/vaem#idString"></see>
    /// </summary>
    let idString = _prefix "idString"
    /// <summary>
    ///   <see href="http://www.linkedmodel.org/schema/vaem#isElaboratedIn"></see>
    /// </summary>
    let isElaboratedIn = _prefix "isElaboratedIn"
    /// <summary>
    ///   <see href="http://www.linkedmodel.org/schema/vaem#lastUpdated"></see>
    /// </summary>
    let lastUpdated = _prefix "lastUpdated"
    /// <summary>
    ///   <see href="http://www.linkedmodel.org/schema/vaem#ownedBy"></see>
    /// </summary>
    let ownedBy = _prefix "ownedBy"
    /// <summary>
    ///   <see href="http://www.linkedmodel.org/schema/vaem#owningParty"></see>
    /// </summary>
    let owningParty = _prefix "owningParty"
    /// <summary>
    ///   <see href="http://www.linkedmodel.org/schema/vaem#rationale"></see>
    /// </summary>
    let rationale = _prefix "rationale"
    /// <summary>
    ///   <see href="http://www.linkedmodel.org/schema/vaem#reifiableBy"></see>
    /// </summary>
    let reifiableBy = _prefix "reifiableBy"
    /// <summary>
    ///   <see href="http://www.linkedmodel.org/schema/vaem#releaseDate"></see>
    /// </summary>
    let releaseDate = _prefix "releaseDate"
    /// <summary>
    ///   <see href="http://www.linkedmodel.org/schema/vaem#todo"></see>
    /// </summary>
    let todo = _prefix "todo"
