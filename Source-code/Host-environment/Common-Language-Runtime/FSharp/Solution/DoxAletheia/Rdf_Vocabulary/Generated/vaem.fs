namespace http.www.linkedmodel.org.schema.vaem.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module vaem =
    let _namespace_iri = Namespace_Iri vaem |> NamespaceIRI
    /// <summary>
    ///   <para>vaem:hasDomain</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>has domain</para></remarks>
    /// <seealso href="http://www.linkedmodel.org/schema/vaem#hasDomain">http://www.linkedmodel.org/schema/vaem#hasDomain</seealso>
    let hasDomain = Prefixed_Name(vaem, "hasDomain") |> PrefixedName
    /// <summary>
    ///   <para>vaem:Viewpoint</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>ViewpointDimension</para></remarks>
    /// <seealso href="http://www.linkedmodel.org/schema/vaem#Viewpoint">http://www.linkedmodel.org/schema/vaem#Viewpoint</seealso>
    let Viewpoint = Prefixed_Name(vaem, "Viewpoint") |> PrefixedName
    /// <summary>
    ///   <para>vaem:hasViewpoint</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>has viewpoint</para></remarks>
    /// <seealso href="http://www.linkedmodel.org/schema/vaem#hasViewpoint">http://www.linkedmodel.org/schema/vaem#hasViewpoint</seealso>
    let hasViewpoint = Prefixed_Name(vaem, "hasViewpoint") |> PrefixedName
    /// <summary>
    ///   <para>vaem:DocumentationGraph</para>
    /// </summary>
    /// <remarks>
    ///   <para>vaem:GraphRole</para>
    ///
    /// labels<para>Documentation graph</para></remarks>
    /// <seealso href="http://www.linkedmodel.org/schema/vaem#DocumentationGraph">http://www.linkedmodel.org/schema/vaem#DocumentationGraph</seealso>
    let DocumentationGraph = Prefixed_Name(vaem, "DocumentationGraph") |> PrefixedName
    /// <summary>
    ///   <para>vaem:Domain</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Domain Dimension</para></remarks>
    /// <seealso href="http://www.linkedmodel.org/schema/vaem#Domain">http://www.linkedmodel.org/schema/vaem#Domain</seealso>
    let Domain = Prefixed_Name(vaem, "Domain") |> PrefixedName
    /// <summary>
    ///   <para>vaem:description</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>description</para></remarks>
    /// <seealso href="http://www.linkedmodel.org/schema/vaem#description">http://www.linkedmodel.org/schema/vaem#description</seealso>
    let description = Prefixed_Name(vaem, "description") |> PrefixedName
    /// <summary>
    ///   <para>vaem:hasGraphRole</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>has graph role</para></remarks>
    /// <seealso href="http://www.linkedmodel.org/schema/vaem#hasGraphRole">http://www.linkedmodel.org/schema/vaem#hasGraphRole</seealso>
    let hasGraphRole = Prefixed_Name(vaem, "hasGraphRole") |> PrefixedName
    /// <summary>
    ///   <para>vaem:intent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>intent</para></remarks>
    /// <seealso href="http://www.linkedmodel.org/schema/vaem#intent">http://www.linkedmodel.org/schema/vaem#intent</seealso>
    let intent = Prefixed_Name(vaem, "intent") |> PrefixedName
    /// <summary>
    ///   <para>vaem:logo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    /// </remarks>
    /// <seealso href="http://www.linkedmodel.org/schema/vaem#logo">http://www.linkedmodel.org/schema/vaem#logo</seealso>
    let logo = Prefixed_Name(vaem, "logo") |> PrefixedName
    /// <summary>
    ///   <para>vaem:namespacePrefix</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>namespace prefix</para></remarks>
    /// <seealso href="http://www.linkedmodel.org/schema/vaem#namespacePrefix">http://www.linkedmodel.org/schema/vaem#namespacePrefix</seealso>
    let namespacePrefix = Prefixed_Name(vaem, "namespacePrefix") |> PrefixedName
    /// <summary>
    ///   <para>vaem:revision</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>revision</para></remarks>
    /// <seealso href="http://www.linkedmodel.org/schema/vaem#revision">http://www.linkedmodel.org/schema/vaem#revision</seealso>
    let revision = Prefixed_Name(vaem, "revision") |> PrefixedName

    /// <summary>
    ///   <para>vaem:usesNonImportedResource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///
    /// labels<para>uses non-imported resource</para></remarks>
    /// <seealso href="http://www.linkedmodel.org/schema/vaem#usesNonImportedResource">http://www.linkedmodel.org/schema/vaem#usesNonImportedResource</seealso>
    let usesNonImportedResource =
        Prefixed_Name(vaem, "usesNonImportedResource") |> PrefixedName

    /// <summary>
    ///   <para>vaem:previousPublishedVersion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>previous published version</para></remarks>
    /// <seealso href="http://www.linkedmodel.org/schema/vaem#previousPublishedVersion">http://www.linkedmodel.org/schema/vaem#previousPublishedVersion</seealso>
    let previousPublishedVersion =
        Prefixed_Name(vaem, "previousPublishedVersion") |> PrefixedName

    /// <summary>
    ///   <para>vaem:hasAspect</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>has aspect</para></remarks>
    /// <seealso href="http://www.linkedmodel.org/schema/vaem#hasAspect">http://www.linkedmodel.org/schema/vaem#hasAspect</seealso>
    let hasAspect = Prefixed_Name(vaem, "hasAspect") |> PrefixedName
    /// <summary>
    ///   <para>vaem:specificity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>specificity</para></remarks>
    /// <seealso href="http://www.linkedmodel.org/schema/vaem#specificity">http://www.linkedmodel.org/schema/vaem#specificity</seealso>
    let specificity = Prefixed_Name(vaem, "specificity") |> PrefixedName
    /// <summary>
    ///   <para>vaem:GMD_VAEM</para>
    /// </summary>
    /// <remarks>
    ///   <para>vaem:GraphMetaData</para>
    ///
    /// labels<para>VAEM Schema Version 2.0 Metadata</para></remarks>
    /// <seealso href="http://www.linkedmodel.org/schema/vaem#GMD_VAEM">http://www.linkedmodel.org/schema/vaem#GMD_VAEM</seealso>
    let GMD_VAEM = Prefixed_Name(vaem, "GMD_VAEM") |> PrefixedName
    /// <summary>
    ///   <para>vaem:CatalogEntry</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.linkedmodel.org/schema/vaem#CatalogEntry">http://www.linkedmodel.org/schema/vaem#CatalogEntry</seealso>
    let CatalogEntry = Prefixed_Name(vaem, "CatalogEntry") |> PrefixedName
    /// <summary>
    ///   <para>vaem:ControllersGraph</para>
    /// </summary>
    /// <remarks>
    ///   <para>vaem:GraphRole</para>
    ///
    /// labels<para>Controllers graph</para></remarks>
    /// <seealso href="http://www.linkedmodel.org/schema/vaem#ControllersGraph">http://www.linkedmodel.org/schema/vaem#ControllersGraph</seealso>
    let ControllersGraph = Prefixed_Name(vaem, "ControllersGraph") |> PrefixedName
    /// <summary>
    ///   <para>vaem:DataGraph</para>
    /// </summary>
    /// <remarks>
    ///   <para>vaem:GraphRole</para>
    ///
    /// labels<para>Data graph</para></remarks>
    /// <seealso href="http://www.linkedmodel.org/schema/vaem#DataGraph">http://www.linkedmodel.org/schema/vaem#DataGraph</seealso>
    let DataGraph = Prefixed_Name(vaem, "DataGraph") |> PrefixedName
    /// <summary>
    ///   <para>vaem:Discipline</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Discipline Dimension</para></remarks>
    /// <seealso href="http://www.linkedmodel.org/schema/vaem#Discipline">http://www.linkedmodel.org/schema/vaem#Discipline</seealso>
    let Discipline = Prefixed_Name(vaem, "Discipline") |> PrefixedName
    /// <summary>
    ///   <para>vaem:hasGraphMetadata</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    /// </remarks>
    /// <seealso href="http://www.linkedmodel.org/schema/vaem#hasGraphMetadata">http://www.linkedmodel.org/schema/vaem#hasGraphMetadata</seealso>
    let hasGraphMetadata = Prefixed_Name(vaem, "hasGraphMetadata") |> PrefixedName
    /// <summary>
    ///   <para>vaem:Aspect</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Aspect Dimension</para></remarks>
    /// <seealso href="http://www.linkedmodel.org/schema/vaem#Aspect">http://www.linkedmodel.org/schema/vaem#Aspect</seealso>
    let Aspect = Prefixed_Name(vaem, "Aspect") |> PrefixedName
    /// <summary>
    ///   <para>vaem:url</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>url</para></remarks>
    /// <seealso href="http://www.linkedmodel.org/schema/vaem#url">http://www.linkedmodel.org/schema/vaem#url</seealso>
    let url = Prefixed_Name(vaem, "url") |> PrefixedName
    /// <summary>
    ///   <para>vaem:ScriptGraph</para>
    /// </summary>
    /// <remarks>
    ///   <para>vaem:GraphRole</para>
    ///
    /// labels<para>Script graph</para></remarks>
    /// <seealso href="http://www.linkedmodel.org/schema/vaem#ScriptGraph">http://www.linkedmodel.org/schema/vaem#ScriptGraph</seealso>
    let ScriptGraph = Prefixed_Name(vaem, "ScriptGraph") |> PrefixedName
    /// <summary>
    ///   <para>vaem:TransformsGraph</para>
    /// </summary>
    /// <remarks>
    ///   <para>vaem:GraphRole</para>
    ///
    /// labels<para>Transforms graph</para></remarks>
    /// <seealso href="http://www.linkedmodel.org/schema/vaem#TransformsGraph">http://www.linkedmodel.org/schema/vaem#TransformsGraph</seealso>
    let TransformsGraph = Prefixed_Name(vaem, "TransformsGraph") |> PrefixedName
    /// <summary>
    ///   <para>vaem:VocabularyGraph</para>
    /// </summary>
    /// <remarks>
    ///   <para>vaem:GraphRole</para>
    ///
    /// labels<para>Vocabulary graph</para></remarks>
    /// <seealso href="http://www.linkedmodel.org/schema/vaem#VocabularyGraph">http://www.linkedmodel.org/schema/vaem#VocabularyGraph</seealso>
    let VocabularyGraph = Prefixed_Name(vaem, "VocabularyGraph") |> PrefixedName
    /// <summary>
    ///   <para>vaem:date</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>date</para></remarks>
    /// <seealso href="http://www.linkedmodel.org/schema/vaem#date">http://www.linkedmodel.org/schema/vaem#date</seealso>
    let date = Prefixed_Name(vaem, "date") |> PrefixedName
    /// <summary>
    ///   <para>vaem:dateCreated</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.linkedmodel.org/schema/vaem#dateCreated">http://www.linkedmodel.org/schema/vaem#dateCreated</seealso>
    let dateCreated = Prefixed_Name(vaem, "dateCreated") |> PrefixedName
    /// <summary>
    ///   <para>vaem:Dimension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Domain</para></remarks>
    /// <seealso href="http://www.linkedmodel.org/schema/vaem#Dimension">http://www.linkedmodel.org/schema/vaem#Dimension</seealso>
    let Dimension = Prefixed_Name(vaem, "Dimension") |> PrefixedName
    /// <summary>
    ///   <para>vaem:GraphRole</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Graph role</para></remarks>
    /// <seealso href="http://www.linkedmodel.org/schema/vaem#GraphRole">http://www.linkedmodel.org/schema/vaem#GraphRole</seealso>
    let GraphRole = Prefixed_Name(vaem, "GraphRole") |> PrefixedName
    /// <summary>
    ///   <para>vaem:filePrefix</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>file prefix</para></remarks>
    /// <seealso href="http://www.linkedmodel.org/schema/vaem#filePrefix">http://www.linkedmodel.org/schema/vaem#filePrefix</seealso>
    let filePrefix = Prefixed_Name(vaem, "filePrefix") |> PrefixedName
    /// <summary>
    ///   <para>vaem:ConstraintsGraph</para>
    /// </summary>
    /// <remarks>
    ///   <para>vaem:GraphRole</para>
    ///
    /// labels<para>Constraints graph</para></remarks>
    /// <seealso href="http://www.linkedmodel.org/schema/vaem#ConstraintsGraph">http://www.linkedmodel.org/schema/vaem#ConstraintsGraph</seealso>
    let ConstraintsGraph = Prefixed_Name(vaem, "ConstraintsGraph") |> PrefixedName
    /// <summary>
    ///   <para>vaem:CurationGraph</para>
    /// </summary>
    /// <remarks>
    ///   <para>vaem:GraphRole</para>
    ///
    /// labels<para>Curation graph</para></remarks>
    /// <seealso href="http://www.linkedmodel.org/schema/vaem#CurationGraph">http://www.linkedmodel.org/schema/vaem#CurationGraph</seealso>
    let CurationGraph = Prefixed_Name(vaem, "CurationGraph") |> PrefixedName
    /// <summary>
    ///   <para>vaem:todo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///
    /// labels<para>todo</para></remarks>
    /// <seealso href="http://www.linkedmodel.org/schema/vaem#todo">http://www.linkedmodel.org/schema/vaem#todo</seealso>
    let todo = Prefixed_Name(vaem, "todo") |> PrefixedName
    /// <summary>
    ///   <para>vaem:reifiableBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>reifiable by</para></remarks>
    /// <seealso href="http://www.linkedmodel.org/schema/vaem#reifiableBy">http://www.linkedmodel.org/schema/vaem#reifiableBy</seealso>
    let reifiableBy = Prefixed_Name(vaem, "reifiableBy") |> PrefixedName
    /// <summary>
    ///   <para>vaem:releaseDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>release date</para></remarks>
    /// <seealso href="http://www.linkedmodel.org/schema/vaem#releaseDate">http://www.linkedmodel.org/schema/vaem#releaseDate</seealso>
    let releaseDate = Prefixed_Name(vaem, "releaseDate") |> PrefixedName
    /// <summary>
    ///   <para>vaem:FunctionsGraph</para>
    /// </summary>
    /// <remarks>
    ///   <para>vaem:GraphRole</para>
    ///
    /// labels<para>Functions graph</para></remarks>
    /// <seealso href="http://www.linkedmodel.org/schema/vaem#FunctionsGraph">http://www.linkedmodel.org/schema/vaem#FunctionsGraph</seealso>
    let FunctionsGraph = Prefixed_Name(vaem, "FunctionsGraph") |> PrefixedName
    /// <summary>
    ///   <para>vaem:SchemaGraph</para>
    /// </summary>
    /// <remarks>
    ///   <para>vaem:GraphRole</para>
    ///
    /// labels<para>Schema graph</para></remarks>
    /// <seealso href="http://www.linkedmodel.org/schema/vaem#SchemaGraph">http://www.linkedmodel.org/schema/vaem#SchemaGraph</seealso>
    let SchemaGraph = Prefixed_Name(vaem, "SchemaGraph") |> PrefixedName
    /// <summary>
    ///   <para>vaem:hasSteward</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>has steward</para></remarks>
    /// <seealso href="http://www.linkedmodel.org/schema/vaem#hasSteward">http://www.linkedmodel.org/schema/vaem#hasSteward</seealso>
    let hasSteward = Prefixed_Name(vaem, "hasSteward") |> PrefixedName

    /// <summary>
    ///   <para>vaem:latestPublishedVersion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>latest published version</para></remarks>
    /// <seealso href="http://www.linkedmodel.org/schema/vaem#latestPublishedVersion">http://www.linkedmodel.org/schema/vaem#latestPublishedVersion</seealso>
    let latestPublishedVersion =
        Prefixed_Name(vaem, "latestPublishedVersion") |> PrefixedName

    /// <summary>
    ///   <para>vaem:rdfxmlFileURL</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>RDF/XML file URL</para></remarks>
    /// <seealso href="http://www.linkedmodel.org/schema/vaem#rdfxmlFileURL">http://www.linkedmodel.org/schema/vaem#rdfxmlFileURL</seealso>
    let rdfxmlFileURL = Prefixed_Name(vaem, "rdfxmlFileURL") |> PrefixedName
    /// <summary>
    ///   <para>vaem:turtleFileURL</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>turtle file URL</para></remarks>
    /// <seealso href="http://www.linkedmodel.org/schema/vaem#turtleFileURL">http://www.linkedmodel.org/schema/vaem#turtleFileURL</seealso>
    let turtleFileURL = Prefixed_Name(vaem, "turtleFileURL") |> PrefixedName
    /// <summary>
    ///   <para>vaem:hasOwner</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>has owner</para></remarks>
    /// <seealso href="http://www.linkedmodel.org/schema/vaem#hasOwner">http://www.linkedmodel.org/schema/vaem#hasOwner</seealso>
    let hasOwner = Prefixed_Name(vaem, "hasOwner") |> PrefixedName
    /// <summary>
    ///   <para>vaem:TopQuadrant</para>
    /// </summary>
    /// <remarks>
    ///   <para>vaem:Party</para>
    ///
    /// labels<para>TopQuadrant</para></remarks>
    /// <seealso href="http://www.linkedmodel.org/schema/vaem#TopQuadrant">http://www.linkedmodel.org/schema/vaem#TopQuadrant</seealso>
    let TopQuadrant = Prefixed_Name(vaem, "TopQuadrant") |> PrefixedName
    /// <summary>
    ///   <para>vaem:name</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>name</para></remarks>
    /// <seealso href="http://www.linkedmodel.org/schema/vaem#name">http://www.linkedmodel.org/schema/vaem#name</seealso>
    let name = Prefixed_Name(vaem, "name") |> PrefixedName
    /// <summary>
    ///   <para>vaem:owner</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>owner</para></remarks>
    /// <seealso href="http://www.linkedmodel.org/schema/vaem#owner">http://www.linkedmodel.org/schema/vaem#owner</seealso>
    let owner = Prefixed_Name(vaem, "owner") |> PrefixedName
    /// <summary>
    ///   <para>vaem:GraphMetaData</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Graph Metadata</para></remarks>
    /// <seealso href="http://www.linkedmodel.org/schema/vaem#GraphMetaData">http://www.linkedmodel.org/schema/vaem#GraphMetaData</seealso>
    let GraphMetaData = Prefixed_Name(vaem, "GraphMetaData") |> PrefixedName
    /// <summary>
    ///   <para>vaem:namespace</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>namespace</para></remarks>
    /// <seealso href="http://www.linkedmodel.org/schema/vaem#namespace">http://www.linkedmodel.org/schema/vaem#namespace</seealso>
    let namespace_ = Prefixed_Name(vaem, "namespace") |> PrefixedName
    /// <summary>
    ///   <para>vaem:title</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>title</para></remarks>
    /// <seealso href="http://www.linkedmodel.org/schema/vaem#title">http://www.linkedmodel.org/schema/vaem#title</seealso>
    let title = Prefixed_Name(vaem, "title") |> PrefixedName
    /// <summary>
    ///   <para>vaem:withAttributionTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///
    /// labels<para>with attribution to</para></remarks>
    /// <seealso href="http://www.linkedmodel.org/schema/vaem#withAttributionTo">http://www.linkedmodel.org/schema/vaem#withAttributionTo</seealso>
    let withAttributionTo = Prefixed_Name(vaem, "withAttributionTo") |> PrefixedName
    /// <summary>
    ///   <para>vaem:hasDiscipline</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>has discipline</para></remarks>
    /// <seealso href="http://www.linkedmodel.org/schema/vaem#hasDiscipline">http://www.linkedmodel.org/schema/vaem#hasDiscipline</seealso>
    let hasDiscipline = Prefixed_Name(vaem, "hasDiscipline") |> PrefixedName
    /// <summary>
    ///   <para>vaem:hasMetadata</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>has metadata</para></remarks>
    /// <seealso href="http://www.linkedmodel.org/schema/vaem#hasMetadata">http://www.linkedmodel.org/schema/vaem#hasMetadata</seealso>
    let hasMetadata = Prefixed_Name(vaem, "hasMetadata") |> PrefixedName
    /// <summary>
    ///   <para>vaem:hasIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>has identifier</para></remarks>
    /// <seealso href="http://www.linkedmodel.org/schema/vaem#hasIdentifier">http://www.linkedmodel.org/schema/vaem#hasIdentifier</seealso>
    let hasIdentifier = Prefixed_Name(vaem, "hasIdentifier") |> PrefixedName
    /// <summary>
    ///   <para>vaem:hasLicenseType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>has license type</para></remarks>
    /// <seealso href="http://www.linkedmodel.org/schema/vaem#hasLicenseType">http://www.linkedmodel.org/schema/vaem#hasLicenseType</seealso>
    let hasLicenseType = Prefixed_Name(vaem, "hasLicenseType") |> PrefixedName
    /// <summary>
    ///   <para>vaem:Party</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Party</para></remarks>
    /// <seealso href="http://www.linkedmodel.org/schema/vaem#Party">http://www.linkedmodel.org/schema/vaem#Party</seealso>
    let Party = Prefixed_Name(vaem, "Party") |> PrefixedName
    /// <summary>
    ///   <para>vaem:LinkSetGraph</para>
    /// </summary>
    /// <remarks>
    ///   <para>vaem:GraphRole</para>
    ///
    /// labels<para>Link Set graph</para></remarks>
    /// <seealso href="http://www.linkedmodel.org/schema/vaem#LinkSetGraph">http://www.linkedmodel.org/schema/vaem#LinkSetGraph</seealso>
    let LinkSetGraph = Prefixed_Name(vaem, "LinkSetGraph") |> PrefixedName
    /// <summary>
    ///   <para>vaem:MappingGraph</para>
    /// </summary>
    /// <remarks>
    ///   <para>vaem:GraphRole</para>
    ///
    /// labels<para>Mapping graph</para></remarks>
    /// <seealso href="http://www.linkedmodel.org/schema/vaem#MappingGraph">http://www.linkedmodel.org/schema/vaem#MappingGraph</seealso>
    let MappingGraph = Prefixed_Name(vaem, "MappingGraph") |> PrefixedName
    /// <summary>
    ///   <para>vaem:id</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>id</para></remarks>
    /// <seealso href="http://www.linkedmodel.org/schema/vaem#id">http://www.linkedmodel.org/schema/vaem#id</seealso>
    let id = Prefixed_Name(vaem, "id") |> PrefixedName
    /// <summary>
    ///   <para>vaem:ProxyGraph</para>
    /// </summary>
    /// <remarks>
    ///   <para>vaem:GraphRole</para>
    ///
    /// labels<para>Proxy graph</para></remarks>
    /// <seealso href="http://www.linkedmodel.org/schema/vaem#ProxyGraph">http://www.linkedmodel.org/schema/vaem#ProxyGraph</seealso>
    let ProxyGraph = Prefixed_Name(vaem, "ProxyGraph") |> PrefixedName
    /// <summary>
    ///   <para>vaem:RulesGraph</para>
    /// </summary>
    /// <remarks>
    ///   <para>vaem:GraphRole</para>
    ///
    /// labels<para>Rules Graph</para></remarks>
    /// <seealso href="http://www.linkedmodel.org/schema/vaem#RulesGraph">http://www.linkedmodel.org/schema/vaem#RulesGraph</seealso>
    let RulesGraph = Prefixed_Name(vaem, "RulesGraph") |> PrefixedName
    /// <summary>
    ///   <para>vaem:ViewGraph</para>
    /// </summary>
    /// <remarks>
    ///   <para>vaem:GraphRole</para>
    ///
    /// labels<para>View graph</para></remarks>
    /// <seealso href="http://www.linkedmodel.org/schema/vaem#ViewGraph">http://www.linkedmodel.org/schema/vaem#ViewGraph</seealso>
    let ViewGraph = Prefixed_Name(vaem, "ViewGraph") |> PrefixedName
    /// <summary>
    ///   <para>vaem:abbreviation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>abbreviation</para></remarks>
    /// <seealso href="http://www.linkedmodel.org/schema/vaem#abbreviation">http://www.linkedmodel.org/schema/vaem#abbreviation</seealso>
    let abbreviation = Prefixed_Name(vaem, "abbreviation") |> PrefixedName
    /// <summary>
    ///   <para>vaem:acronym</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>acronym</para></remarks>
    /// <seealso href="http://www.linkedmodel.org/schema/vaem#acronym">http://www.linkedmodel.org/schema/vaem#acronym</seealso>
    let acronym = Prefixed_Name(vaem, "acronym") |> PrefixedName
    /// <summary>
    ///   <para>vaem:comment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///
    /// labels<para>definition</para></remarks>
    /// <seealso href="http://www.linkedmodel.org/schema/vaem#comment">http://www.linkedmodel.org/schema/vaem#comment</seealso>
    let comment = Prefixed_Name(vaem, "comment") |> PrefixedName
    /// <summary>
    ///   <para>vaem:hasDimension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>has dimension</para></remarks>
    /// <seealso href="http://www.linkedmodel.org/schema/vaem#hasDimension">http://www.linkedmodel.org/schema/vaem#hasDimension</seealso>
    let hasDimension = Prefixed_Name(vaem, "hasDimension") |> PrefixedName
    /// <summary>
    ///   <para>vaem:idString</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.linkedmodel.org/schema/vaem#idString">http://www.linkedmodel.org/schema/vaem#idString</seealso>
    let idString = Prefixed_Name(vaem, "idString") |> PrefixedName
    /// <summary>
    ///   <para>vaem:isElaboratedIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///
    /// labels<para>isDefinedBy</para></remarks>
    /// <seealso href="http://www.linkedmodel.org/schema/vaem#isElaboratedIn">http://www.linkedmodel.org/schema/vaem#isElaboratedIn</seealso>
    let isElaboratedIn = Prefixed_Name(vaem, "isElaboratedIn") |> PrefixedName
    /// <summary>
    ///   <para>vaem:lastUpdated</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.linkedmodel.org/schema/vaem#lastUpdated">http://www.linkedmodel.org/schema/vaem#lastUpdated</seealso>
    let lastUpdated = Prefixed_Name(vaem, "lastUpdated") |> PrefixedName
    /// <summary>
    ///   <para>vaem:ownedBy</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.linkedmodel.org/schema/vaem#ownedBy">http://www.linkedmodel.org/schema/vaem#ownedBy</seealso>
    let ownedBy = Prefixed_Name(vaem, "ownedBy") |> PrefixedName
    /// <summary>
    ///   <para>vaem:owningParty</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.linkedmodel.org/schema/vaem#owningParty">http://www.linkedmodel.org/schema/vaem#owningParty</seealso>
    let owningParty = Prefixed_Name(vaem, "owningParty") |> PrefixedName
    /// <summary>
    ///   <para>vaem:rationale</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>rationale</para></remarks>
    /// <seealso href="http://www.linkedmodel.org/schema/vaem#rationale">http://www.linkedmodel.org/schema/vaem#rationale</seealso>
    let rationale = Prefixed_Name(vaem, "rationale") |> PrefixedName
    /// <summary>
    ///   <para>vaem:CollectionGraph</para>
    /// </summary>
    /// <remarks>
    ///   <para>vaem:GraphRole</para>
    ///
    /// labels<para>Collection graph</para></remarks>
    /// <seealso href="http://www.linkedmodel.org/schema/vaem#CollectionGraph">http://www.linkedmodel.org/schema/vaem#CollectionGraph</seealso>
    let CollectionGraph = Prefixed_Name(vaem, "CollectionGraph") |> PrefixedName
