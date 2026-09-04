#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module nao =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://www.semanticdesktop.org/ontologies/2007/08/15/nao#" "nao"

    /// <summary>
    ///   <para>rdfs:comment : An agent is the artificial counterpart to nao:Party. It can be a software component or some service.^^xsd:string</para>
    ///   <para>rdfs:label : agent^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/08/15/nao#Agent">nao:Agent</a>
    /// </summary>
    let Agent = _prefixId.prefix "Agent"
    /// <summary>
    ///   <para>rdfs:comment : Represents a desktop icon as defined in the FreeDesktop Icon Naming Standard (http://standards.freedesktop.org/icon-naming-spec/icon-naming-spec-latest.html).^^xsd:string</para>
    ///   <para>rdfs:label : freedesktopicon^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/08/15/nao#FreeDesktopIcon">nao:FreeDesktopIcon</a>
    /// </summary>
    let FreeDesktopIcon = _prefixId.prefix "FreeDesktopIcon"
    /// <summary>
    ///   <para>rdfs:comment : Represents a single or a group of individuals^^xsd:string</para>
    ///   <para>rdfs:label : party^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/08/15/nao#Party">nao:Party</a>
    /// </summary>
    let Party = _prefixId.prefix "Party"
    /// <summary>
    ///   <para>rdfs:comment : Represents a symbol, a visual representation of a resource. Typically a local or remote file would be double-typed to be used as a symbol. An alternative is nao:FreeDesktopIcon.^^xsd:string</para>
    ///   <para>rdfs:label : symbol^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/08/15/nao#Symbol">nao:Symbol</a>
    /// </summary>
    let Symbol = _prefixId.prefix "Symbol"
    /// <summary>
    ///   <para>rdfs:comment : Represents a generic tag^^xsd:string</para>
    ///   <para>rdfs:label : tag^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/08/15/nao#Tag">nao:Tag</a>
    /// </summary>
    let Tag = _prefixId.prefix "Tag"
    /// <summary>
    ///   <para>rdfs:comment : An alternative label alongside the preferred label for a resource^^xsd:string</para>
    ///   <para>rdfs:label : alternative label^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/08/15/nao#altLabel">nao:altLabel</a>
    /// </summary>
    let altLabel = _prefixId.prefix "altLabel"
    /// <summary>
    ///   <para>rdfs:comment : An alternative symbol representation for a resource^^xsd:string</para>
    ///   <para>rdfs:label : alternative symbol^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/08/15/nao#altSymbol">nao:altSymbol</a>
    /// </summary>
    let altSymbol = _prefixId.prefix "altSymbol"
    /// <summary>
    ///   <para>rdfs:comment : Generic annotation for a resource^^xsd:string</para>
    ///   <para>rdfs:label : annotation^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/08/15/nao#annotation">nao:annotation</a>
    /// </summary>
    let annotation = _prefixId.prefix "annotation"
    /// <summary>
    ///   <para>rdfs:comment : Refers to a single or a group of individuals that contributed to a resource^^xsd:string</para>
    ///   <para>rdfs:label : contributor^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/08/15/nao#contributor">nao:contributor</a>
    /// </summary>
    let contributor = _prefixId.prefix "contributor"
    /// <summary>
    ///   <para>rdfs:comment : States the creation, or first modification time for a resource^^xsd:string</para>
    ///   <para>nrl:maxCardinality : 1^^xsd:nonNegativeInteger</para>
    ///   <para>rdfs:label : created at^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/08/15/nao#created">nao:created</a>
    /// </summary>
    let created = _prefixId.prefix "created"
    /// <summary>
    ///   <para>rdfs:comment : Refers to the single or group of individuals that created the resource^^xsd:string</para>
    ///   <para>nrl:maxCardinality : 1^^xsd:nonNegativeInteger</para>
    ///   <para>rdfs:label : creator^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/08/15/nao#creator">nao:creator</a>
    /// </summary>
    let creator = _prefixId.prefix "creator"
    /// <summary>
    ///   <para>rdfs:comment : If this property is assigned, the subject class, property, or resource, is deprecated and should not be used in production systems any longer. It may be removed without further notice.^^xsd:string</para>
    ///   <para>nrl:maxCardinality : 1^^xsd:nonNegativeInteger</para>
    ///   <para>rdfs:label : deprecated^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/08/15/nao#deprecated">nao:deprecated</a>
    /// </summary>
    let deprecated = _prefixId.prefix "deprecated"
    /// <summary>
    ///   <para>rdfs:comment : A non-technical textual annotation for a resource^^xsd:string</para>
    ///   <para>rdfs:label : description^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/08/15/nao#description">nao:description</a>
    /// </summary>
    let description = _prefixId.prefix "description"
    /// <summary>
    ///   <para>rdfs:comment : A direct trust value assigned to an agent, either manually by a user or semi-/automatically by a system. Allowed values range from 0 (no trust) to 1 (very high trust).^^xsd:string</para>
    ///   <para>rdfs:label : direct trust^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/08/15/nao#directTrust">nao:directTrust</a>
    /// </summary>
    let directTrust = _prefixId.prefix "directTrust"
    /// <summary>
    ///   <para>rdfs:comment : Signifies social endorsment of a resource by a specific agent. Endorsement includes social actions like favouriting, liking, voting for, starring a resource.^^xsd:string</para>
    ///   <para>rdfs:label : endorsed by^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/08/15/nao#endorsedBy">nao:endorsedBy</a>
    /// </summary>
    let endorsedBy = _prefixId.prefix "endorsedBy"
    /// <summary>
    ///   <para>rdfs:comment : Specifies the engineering tool used to generate the graph^^xsd:string</para>
    ///   <para>rdfs:label : engineering tool^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/08/15/nao#engineeringTool">nao:engineeringTool</a>
    /// </summary>
    let engineeringTool = _prefixId.prefix "engineeringTool"
    /// <summary>
    ///   <para>rdfs:comment : An external identifier for a resource that has been retreived from an external source.^^xsd:string</para>
    ///   <para>rdfs:label : external identifier^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/08/15/nao#externalIdentifier">nao:externalIdentifier</a>
    /// </summary>
    let externalIdentifier = _prefixId.prefix "externalIdentifier"
    /// <summary>
    ///   <para>rdfs:comment : Signifies social endorsment by an agent, by way of marking the resource as a favourite.^^xsd:string</para>
    ///   <para>rdfs:label : favourited by^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/08/15/nao#favouritedBy">nao:favouritedBy</a>
    /// </summary>
    let favouritedBy = _prefixId.prefix "favouritedBy"
    /// <summary>
    ///   <para>rdfs:comment : Links a resource to the graph which contains its metadata. Its typical usage would be to link the file resource to the graph containing its extracted file metadata. This allows for easy maintenance later on. Inverse property of nao:isDataGraphFor.^^xsd:string</para>
    ///   <para>rdfs:label : has data graph^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/08/15/nao#hasDataGraph">nao:hasDataGraph</a>
    /// </summary>
    let hasDataGraph = _prefixId.prefix "hasDataGraph"
    /// <summary>
    ///   <para>rdfs:comment : Defines the default static namespace for a graph^^xsd:string</para>
    ///   <para>nrl:maxCardinality : 1^^xsd:nonNegativeInteger</para>
    ///   <para>rdfs:label : has default namespace^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/08/15/nao#hasDefaultNamespace">nao:hasDefaultNamespace</a>
    /// </summary>
    let hasDefaultNamespace = _prefixId.prefix "hasDefaultNamespace"

    /// <summary>
    ///   <para>rdfs:comment : Defines the default static namespace abbreviation for a graph^^xsd:string</para>
    ///   <para>nrl:maxCardinality : 1^^xsd:nonNegativeInteger</para>
    ///   <para>rdfs:label : has default namespace abbreviation^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/08/15/nao#hasDefaultNamespaceAbbreviation">nao:hasDefaultNamespaceAbbreviation</a>
    /// </summary>
    let hasDefaultNamespaceAbbreviation =
        _prefixId.prefix "hasDefaultNamespaceAbbreviation"

    /// <summary>
    ///   <para>rdfs:comment : Defines a relationship between a resource and one or more sub resources. Descriptions of sub-resources are only interpretable when the super-resource exists. Deleting a super-resource should then also delete all sub-resources, and transferring a super-resource (for example, sending it to another user) must also include the sub-resource.^^xsd:string</para>
    ///   <para>rdfs:label : has Subresource^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/08/15/nao#hasSubResource">nao:hasSubResource</a>
    /// </summary>
    let hasSubResource = _prefixId.prefix "hasSubResource"
    /// <summary>
    ///   <para>rdfs:comment : Defines a relationship between a resource and one or more super resources^^xsd:string</para>
    ///   <para>rdfs:label : has Superresource^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/08/15/nao#hasSuperResource">nao:hasSuperResource</a>
    /// </summary>
    let hasSuperResource = _prefixId.prefix "hasSuperResource"
    /// <summary>
    ///   <para>rdfs:comment : Annotation for a resource in the form of a visual representation. Typically the symbol is a double-typed image file or a nao:FreeDesktopIcon.^^xsd:string</para>
    ///   <para>rdfs:label : has symbol^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/08/15/nao#hasSymbol">nao:hasSymbol</a>
    /// </summary>
    let hasSymbol = _prefixId.prefix "hasSymbol"
    /// <summary>
    ///   <para>rdfs:comment : Defines an existing tag for a resource^^xsd:string</para>
    ///   <para>rdfs:label : has tag^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/08/15/nao#hasTag">nao:hasTag</a>
    /// </summary>
    let hasTag = _prefixId.prefix "hasTag"
    /// <summary>
    ///   <para>rdfs:comment : Defines a relationship between two resources, where the object is a topic of the subject^^xsd:string</para>
    ///   <para>rdfs:label : has topic^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/08/15/nao#hasTopic">nao:hasTopic</a>
    /// </summary>
    let hasTopic = _prefixId.prefix "hasTopic"
    /// <summary>
    ///   <para>rdfs:comment : Defines a name for a FreeDesktop Icon as defined in the FreeDesktop Icon Naming Standard^^xsd:string</para>
    ///   <para>nrl:minCardinality : 1^^xsd:nonNegativeInteger</para>
    ///   <para>rdfs:label : iconname^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/08/15/nao#iconName">nao:iconName</a>
    /// </summary>
    let iconName = _prefixId.prefix "iconName"
    /// <summary>
    ///   <para>rdfs:comment : Defines a generic identifier for a resource^^xsd:string</para>
    ///   <para>rdfs:label : identifier^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/08/15/nao#identifier">nao:identifier</a>
    /// </summary>
    let identifier = _prefixId.prefix "identifier"
    /// <summary>
    ///   <para>rdfs:comment : Links a named graph to the resource for which it contains metadata. Its typical usage would be to link the graph containing extracted file metadata to the file resource. This allows for easy maintenance later on. Inverse property of nao:hasDataGraph.^^xsd:string</para>
    ///   <para>rdfs:label : is data graph for^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/08/15/nao#isDataGraphFor">nao:isDataGraphFor</a>
    /// </summary>
    let isDataGraphFor = _prefixId.prefix "isDataGraphFor"
    /// <summary>
    ///   <para>rdfs:comment : Defines an annotation for a resource in the form of a relationship between the subject resource and another resource^^xsd:string</para>
    ///   <para>rdfs:label : is related to^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/08/15/nao#isRelated">nao:isRelated</a>
    /// </summary>
    let isRelated = _prefixId.prefix "isRelated"
    /// <summary>
    ///   <para>rdfs:comment : States which resources a tag is associated with^^xsd:string</para>
    ///   <para>rdfs:label : is tag for^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/08/15/nao#isTagFor">nao:isTagFor</a>
    /// </summary>
    let isTagFor = _prefixId.prefix "isTagFor"
    /// <summary>
    ///   <para>rdfs:comment : Defines a relationship between two resources, where the subject is a topic of the object^^xsd:string</para>
    ///   <para>rdfs:label : is topic of^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/08/15/nao#isTopicOf">nao:isTopicOf</a>
    /// </summary>
    let isTopicOf = _prefixId.prefix "isTopicOf"
    /// <summary>
    ///   <para>rdfs:comment : States the last modification time for a resource^^xsd:string</para>
    ///   <para>nrl:maxCardinality : 1^^xsd:nonNegativeInteger</para>
    ///   <para>rdfs:label : last modified at^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/08/15/nao#lastModified">nao:lastModified</a>
    /// </summary>
    let lastModified = _prefixId.prefix "lastModified"
    /// <summary>
    ///   <para>rdfs:comment : The agent that maintains this resource, ie. created it and knows what to do with it.^^xsd:string</para>
    ///   <para>rdfs:label : maintained by^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/08/15/nao#maintainedBy">nao:maintainedBy</a>
    /// </summary>
    let maintainedBy = _prefixId.prefix "maintainedBy"
    /// <summary>
    ///   <para>rdfs:comment : States the modification time for a resource^^xsd:string</para>
    ///   <para>rdfs:label : modified at^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/08/15/nao#modified">nao:modified</a>
    /// </summary>
    let modified = _prefixId.prefix "modified"
    /// <summary>
    ///   <para>rdfs:comment : A network-derived trust value assigned to an agent, based on the shared direct trust values for the same agent, as set by participating agents in a network. Allowed values range from 0 (no trust) to 1 (very high trust).^^xsd:string</para>
    ///   <para>rdfs:label : network trust^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/08/15/nao#networkTrust">nao:networkTrust</a>
    /// </summary>
    let networkTrust = _prefixId.prefix "networkTrust"
    /// <summary>
    ///   <para>rdfs:comment :  Annotation for a resource in the form of a numeric rating (float value), allowed values are between 1 and 10 whereas 0 is interpreted as not set^^xsd:string</para>
    ///   <para>nrl:maxCardinality : 1^^xsd:nonNegativeInteger</para>
    ///   <para>rdfs:label : numeric rating^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/08/15/nao#numericRating">nao:numericRating</a>
    /// </summary>
    let numericRating = _prefixId.prefix "numericRating"
    /// <summary>
    ///   <para>rdfs:comment : Defines a personal string identifier for a resource^^xsd:string</para>
    ///   <para>rdfs:label : personal identifier^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/08/15/nao#personalIdentifier">nao:personalIdentifier</a>
    /// </summary>
    let personalIdentifier = _prefixId.prefix "personalIdentifier"
    /// <summary>
    ///   <para>rdfs:comment : The plural form of the preferred label for a resource^^xsd:string</para>
    ///   <para>nrl:maxCardinality : 1^^xsd:nonNegativeInteger</para>
    ///   <para>rdfs:label : preferred label plural form^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/08/15/nao#pluralPrefLabel">nao:pluralPrefLabel</a>
    /// </summary>
    let pluralPrefLabel = _prefixId.prefix "pluralPrefLabel"
    /// <summary>
    ///   <para>rdfs:comment : A preferred label for a resource^^xsd:string</para>
    ///   <para>nrl:maxCardinality : 1^^xsd:nonNegativeInteger</para>
    ///   <para>rdfs:label : preferred label^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/08/15/nao#prefLabel">nao:prefLabel</a>
    /// </summary>
    let prefLabel = _prefixId.prefix "prefLabel"
    /// <summary>
    ///   <para>rdfs:comment : A unique preferred symbol representation for a resource^^xsd:string</para>
    ///   <para>nrl:maxCardinality : 1^^xsd:nonNegativeInteger</para>
    ///   <para>rdfs:label : preferred symbol^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/08/15/nao#prefSymbol">nao:prefSymbol</a>
    /// </summary>
    let prefSymbol = _prefixId.prefix "prefSymbol"
    /// <summary>
    ///   <para>rdfs:comment : A privacy level as defined for a resource. Allowed values range from 0 (private) to 1 (public).^^xsd:string</para>
    ///   <para>rdfs:label : privacy level^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/08/15/nao#privacyLevel">nao:privacyLevel</a>
    /// </summary>
    let privacyLevel = _prefixId.prefix "privacyLevel"
    /// <summary>
    ///   <para>rdfs:comment : Annotation for a resource in the form of an unrestricted rating^^xsd:string</para>
    ///   <para>rdfs:label : rating^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/08/15/nao#rating">nao:rating</a>
    /// </summary>
    let rating = _prefixId.prefix "rating"
    /// <summary>
    ///   <para>rdfs:comment : An authoritative score for an item valued between 0 and 1^^xsd:string</para>
    ///   <para>nrl:maxCardinality : 1^^xsd:nonNegativeInteger</para>
    ///   <para>rdfs:label : score^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/08/15/nao#score">nao:score</a>
    /// </summary>
    let score = _prefixId.prefix "score"
    /// <summary>
    ///   <para>rdfs:comment : A marker property to mark selected properties which are input to a mathematical algorithm to generate scores for resources. Properties are marked by being defined as subproperties of this property^^xsd:string</para>
    ///   <para>rdfs:label : scoreparameter^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/08/15/nao#scoreParameter">nao:scoreParameter</a>
    /// </summary>
    let scoreParameter = _prefixId.prefix "scoreParameter"
    /// <summary>
    ///   <para>rdfs:comment : States the serialization language for a named graph that is represented within a document^^xsd:string</para>
    ///   <para>nrl:maxCardinality : 1^^xsd:nonNegativeInteger</para>
    ///   <para>rdfs:label : serialization language^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/08/15/nao#serializationLanguage">nao:serializationLanguage</a>
    /// </summary>
    let serializationLanguage = _prefixId.prefix "serializationLanguage"
    /// <summary>
    ///   <para>rdfs:comment : Specifies the status of a graph, stable, unstable or testing^^xsd:string</para>
    ///   <para>nrl:maxCardinality : 1^^xsd:nonNegativeInteger</para>
    ///   <para>rdfs:label : status^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/08/15/nao#status">nao:status</a>
    /// </summary>
    let status = _prefixId.prefix "status"
    /// <summary>
    ///   <para>rdfs:comment : A generalised trust level assigned to an agent, based on a combination of direct and network trust values it possesses. Allowed values range from 0 (no trust) to 1 (very high trust).^^xsd:string</para>
    ///   <para>rdfs:label : trust level^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/08/15/nao#trustLevel">nao:trustLevel</a>
    /// </summary>
    let trustLevel = _prefixId.prefix "trustLevel"
    /// <summary>
    ///   <para>nao:userVisible : false^^xsd:boolean</para>
    ///   <para>rdfs:comment : Mark a property, class, or even resource as user visible or not. Non-user-visible entities should never be presented to the user. By default everything is user-visible.^^xsd:string</para>
    ///   <para>nrl:maxCardinality : 1^^xsd:integer</para>
    ///   <para>rdfs:label : user visible^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/08/15/nao#userVisible">nao:userVisible</a>
    /// </summary>
    let userVisible = _prefixId.prefix "userVisible"
    /// <summary>
    ///   <para>rdfs:comment : Specifies the version of a graph, in numeric format^^xsd:string</para>
    ///   <para>nrl:maxCardinality : 1^^xsd:nonNegativeInteger</para>
    ///   <para>rdfs:label : version^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/08/15/nao#version">nao:version</a>
    /// </summary>
    let version = _prefixId.prefix "version"
