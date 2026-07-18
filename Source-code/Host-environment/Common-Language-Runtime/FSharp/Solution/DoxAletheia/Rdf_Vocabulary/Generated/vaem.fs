namespace http.www.linkedmodel.org.schema.vaem.hash

open DoxAletheia.Rdf_Vocabulary

module vaem =
    let _namespace_name = "http://www.linkedmodel.org/schema/vaem#"

    /// <summary>
    ///   <see href="http://www.linkedmodel.org/schema/vaem#hasGraphMetadata"></see>
    /// </summary>
    let hasGraphMetadata =
        Namespaced_IRI.parse _namespace_name "hasGraphMetadata" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.linkedmodel.org/schema/vaem#GMD_VAEM"></see>
    /// </summary>
    let GMD_VAEM = Namespaced_IRI.parse _namespace_name "GMD_VAEM" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.linkedmodel.org/schema/vaem#Aspect"></see>
    /// </summary>
    let Aspect = Namespaced_IRI.parse _namespace_name "Aspect" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.linkedmodel.org/schema/vaem#Dimension"></see>
    /// </summary>
    let Dimension = Namespaced_IRI.parse _namespace_name "Dimension" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.linkedmodel.org/schema/vaem#CatalogEntry"></see>
    /// </summary>
    let CatalogEntry =
        Namespaced_IRI.parse _namespace_name "CatalogEntry" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.linkedmodel.org/schema/vaem#CollectionGraph"></see>
    /// </summary>
    let CollectionGraph =
        Namespaced_IRI.parse _namespace_name "CollectionGraph" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.linkedmodel.org/schema/vaem#filePrefix"></see>
    /// </summary>
    let filePrefix = Namespaced_IRI.parse _namespace_name "filePrefix" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.linkedmodel.org/schema/vaem#GraphRole"></see>
    /// </summary>
    let GraphRole = Namespaced_IRI.parse _namespace_name "GraphRole" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.linkedmodel.org/schema/vaem#ConstraintsGraph"></see>
    /// </summary>
    let ConstraintsGraph =
        Namespaced_IRI.parse _namespace_name "ConstraintsGraph" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.linkedmodel.org/schema/vaem#ControllersGraph"></see>
    /// </summary>
    let ControllersGraph =
        Namespaced_IRI.parse _namespace_name "ControllersGraph" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.linkedmodel.org/schema/vaem#CurationGraph"></see>
    /// </summary>
    let CurationGraph =
        Namespaced_IRI.parse _namespace_name "CurationGraph" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.linkedmodel.org/schema/vaem#DataGraph"></see>
    /// </summary>
    let DataGraph = Namespaced_IRI.parse _namespace_name "DataGraph" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.linkedmodel.org/schema/vaem#Discipline"></see>
    /// </summary>
    let Discipline = Namespaced_IRI.parse _namespace_name "Discipline" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.linkedmodel.org/schema/vaem#DocumentationGraph"></see>
    /// </summary>
    let DocumentationGraph =
        Namespaced_IRI.parse _namespace_name "DocumentationGraph" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.linkedmodel.org/schema/vaem#Domain"></see>
    /// </summary>
    let Domain = Namespaced_IRI.parse _namespace_name "Domain" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.linkedmodel.org/schema/vaem#FunctionsGraph"></see>
    /// </summary>
    let FunctionsGraph =
        Namespaced_IRI.parse _namespace_name "FunctionsGraph" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.linkedmodel.org/schema/vaem#description"></see>
    /// </summary>
    let description =
        Namespaced_IRI.parse _namespace_name "description" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.linkedmodel.org/schema/vaem#hasGraphRole"></see>
    /// </summary>
    let hasGraphRole =
        Namespaced_IRI.parse _namespace_name "hasGraphRole" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.linkedmodel.org/schema/vaem#SchemaGraph"></see>
    /// </summary>
    let SchemaGraph =
        Namespaced_IRI.parse _namespace_name "SchemaGraph" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.linkedmodel.org/schema/vaem#hasOwner"></see>
    /// </summary>
    let hasOwner = Namespaced_IRI.parse _namespace_name "hasOwner" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.linkedmodel.org/schema/vaem#TopQuadrant"></see>
    /// </summary>
    let TopQuadrant =
        Namespaced_IRI.parse _namespace_name "TopQuadrant" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.linkedmodel.org/schema/vaem#hasSteward"></see>
    /// </summary>
    let hasSteward = Namespaced_IRI.parse _namespace_name "hasSteward" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.linkedmodel.org/schema/vaem#intent"></see>
    /// </summary>
    let intent = Namespaced_IRI.parse _namespace_name "intent" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.linkedmodel.org/schema/vaem#latestPublishedVersion"></see>
    /// </summary>
    let latestPublishedVersion =
        Namespaced_IRI.parse _namespace_name "latestPublishedVersion" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.linkedmodel.org/schema/vaem#logo"></see>
    /// </summary>
    let logo = Namespaced_IRI.parse _namespace_name "logo" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.linkedmodel.org/schema/vaem#name"></see>
    /// </summary>
    let name = Namespaced_IRI.parse _namespace_name "name" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.linkedmodel.org/schema/vaem#namespace"></see>
    /// </summary>
    let namespace_ = Namespaced_IRI.parse _namespace_name "namespace" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.linkedmodel.org/schema/vaem#namespacePrefix"></see>
    /// </summary>
    let namespacePrefix =
        Namespaced_IRI.parse _namespace_name "namespacePrefix" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.linkedmodel.org/schema/vaem#owner"></see>
    /// </summary>
    let owner = Namespaced_IRI.parse _namespace_name "owner" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.linkedmodel.org/schema/vaem#previousPublishedVersion"></see>
    /// </summary>
    let previousPublishedVersion =
        Namespaced_IRI.parse _namespace_name "previousPublishedVersion" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.linkedmodel.org/schema/vaem#rdfxmlFileURL"></see>
    /// </summary>
    let rdfxmlFileURL =
        Namespaced_IRI.parse _namespace_name "rdfxmlFileURL" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.linkedmodel.org/schema/vaem#revision"></see>
    /// </summary>
    let revision = Namespaced_IRI.parse _namespace_name "revision" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.linkedmodel.org/schema/vaem#title"></see>
    /// </summary>
    let title = Namespaced_IRI.parse _namespace_name "title" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.linkedmodel.org/schema/vaem#turtleFileURL"></see>
    /// </summary>
    let turtleFileURL =
        Namespaced_IRI.parse _namespace_name "turtleFileURL" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.linkedmodel.org/schema/vaem#usesNonImportedResource"></see>
    /// </summary>
    let usesNonImportedResource =
        Namespaced_IRI.parse _namespace_name "usesNonImportedResource" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.linkedmodel.org/schema/vaem#withAttributionTo"></see>
    /// </summary>
    let withAttributionTo =
        Namespaced_IRI.parse _namespace_name "withAttributionTo" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.linkedmodel.org/schema/vaem#GraphMetaData"></see>
    /// </summary>
    let GraphMetaData =
        Namespaced_IRI.parse _namespace_name "GraphMetaData" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.linkedmodel.org/schema/vaem#hasAspect"></see>
    /// </summary>
    let hasAspect = Namespaced_IRI.parse _namespace_name "hasAspect" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.linkedmodel.org/schema/vaem#hasDomain"></see>
    /// </summary>
    let hasDomain = Namespaced_IRI.parse _namespace_name "hasDomain" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.linkedmodel.org/schema/vaem#hasDiscipline"></see>
    /// </summary>
    let hasDiscipline =
        Namespaced_IRI.parse _namespace_name "hasDiscipline" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.linkedmodel.org/schema/vaem#Viewpoint"></see>
    /// </summary>
    let Viewpoint = Namespaced_IRI.parse _namespace_name "Viewpoint" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.linkedmodel.org/schema/vaem#hasViewpoint"></see>
    /// </summary>
    let hasViewpoint =
        Namespaced_IRI.parse _namespace_name "hasViewpoint" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.linkedmodel.org/schema/vaem#hasMetadata"></see>
    /// </summary>
    let hasMetadata =
        Namespaced_IRI.parse _namespace_name "hasMetadata" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.linkedmodel.org/schema/vaem#hasIdentifier"></see>
    /// </summary>
    let hasIdentifier =
        Namespaced_IRI.parse _namespace_name "hasIdentifier" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.linkedmodel.org/schema/vaem#hasLicenseType"></see>
    /// </summary>
    let hasLicenseType =
        Namespaced_IRI.parse _namespace_name "hasLicenseType" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.linkedmodel.org/schema/vaem#Party"></see>
    /// </summary>
    let Party = Namespaced_IRI.parse _namespace_name "Party" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.linkedmodel.org/schema/vaem#specificity"></see>
    /// </summary>
    let specificity =
        Namespaced_IRI.parse _namespace_name "specificity" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.linkedmodel.org/schema/vaem#LinkSetGraph"></see>
    /// </summary>
    let LinkSetGraph =
        Namespaced_IRI.parse _namespace_name "LinkSetGraph" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.linkedmodel.org/schema/vaem#MappingGraph"></see>
    /// </summary>
    let MappingGraph =
        Namespaced_IRI.parse _namespace_name "MappingGraph" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.linkedmodel.org/schema/vaem#id"></see>
    /// </summary>
    let id = Namespaced_IRI.parse _namespace_name "id" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.linkedmodel.org/schema/vaem#url"></see>
    /// </summary>
    let url = Namespaced_IRI.parse _namespace_name "url" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.linkedmodel.org/schema/vaem#ProxyGraph"></see>
    /// </summary>
    let ProxyGraph = Namespaced_IRI.parse _namespace_name "ProxyGraph" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.linkedmodel.org/schema/vaem#RulesGraph"></see>
    /// </summary>
    let RulesGraph = Namespaced_IRI.parse _namespace_name "RulesGraph" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.linkedmodel.org/schema/vaem#ScriptGraph"></see>
    /// </summary>
    let ScriptGraph =
        Namespaced_IRI.parse _namespace_name "ScriptGraph" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.linkedmodel.org/schema/vaem#TransformsGraph"></see>
    /// </summary>
    let TransformsGraph =
        Namespaced_IRI.parse _namespace_name "TransformsGraph" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.linkedmodel.org/schema/vaem#ViewGraph"></see>
    /// </summary>
    let ViewGraph = Namespaced_IRI.parse _namespace_name "ViewGraph" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.linkedmodel.org/schema/vaem#VocabularyGraph"></see>
    /// </summary>
    let VocabularyGraph =
        Namespaced_IRI.parse _namespace_name "VocabularyGraph" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.linkedmodel.org/schema/vaem#abbreviation"></see>
    /// </summary>
    let abbreviation =
        Namespaced_IRI.parse _namespace_name "abbreviation" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.linkedmodel.org/schema/vaem#acronym"></see>
    /// </summary>
    let acronym = Namespaced_IRI.parse _namespace_name "acronym" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.linkedmodel.org/schema/vaem#comment"></see>
    /// </summary>
    let comment = Namespaced_IRI.parse _namespace_name "comment" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.linkedmodel.org/schema/vaem#date"></see>
    /// </summary>
    let date = Namespaced_IRI.parse _namespace_name "date" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.linkedmodel.org/schema/vaem#dateCreated"></see>
    /// </summary>
    let dateCreated =
        Namespaced_IRI.parse _namespace_name "dateCreated" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.linkedmodel.org/schema/vaem#hasDimension"></see>
    /// </summary>
    let hasDimension =
        Namespaced_IRI.parse _namespace_name "hasDimension" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.linkedmodel.org/schema/vaem#idString"></see>
    /// </summary>
    let idString = Namespaced_IRI.parse _namespace_name "idString" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.linkedmodel.org/schema/vaem#isElaboratedIn"></see>
    /// </summary>
    let isElaboratedIn =
        Namespaced_IRI.parse _namespace_name "isElaboratedIn" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.linkedmodel.org/schema/vaem#lastUpdated"></see>
    /// </summary>
    let lastUpdated =
        Namespaced_IRI.parse _namespace_name "lastUpdated" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.linkedmodel.org/schema/vaem#ownedBy"></see>
    /// </summary>
    let ownedBy = Namespaced_IRI.parse _namespace_name "ownedBy" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.linkedmodel.org/schema/vaem#owningParty"></see>
    /// </summary>
    let owningParty =
        Namespaced_IRI.parse _namespace_name "owningParty" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.linkedmodel.org/schema/vaem#rationale"></see>
    /// </summary>
    let rationale = Namespaced_IRI.parse _namespace_name "rationale" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.linkedmodel.org/schema/vaem#reifiableBy"></see>
    /// </summary>
    let reifiableBy =
        Namespaced_IRI.parse _namespace_name "reifiableBy" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.linkedmodel.org/schema/vaem#releaseDate"></see>
    /// </summary>
    let releaseDate =
        Namespaced_IRI.parse _namespace_name "releaseDate" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.linkedmodel.org/schema/vaem#todo"></see>
    /// </summary>
    let todo = Namespaced_IRI.parse _namespace_name "todo" |> NamespacedName
