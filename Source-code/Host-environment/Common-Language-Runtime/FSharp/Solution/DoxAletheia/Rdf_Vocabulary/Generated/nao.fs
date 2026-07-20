namespace http.www.semanticdesktop.org.ontologies._2007._08._15.nao.hash

open DoxAletheia

module nao =
    let _namespace_name = "http://www.semanticdesktop.org/ontologies/2007/08/15/nao#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// An agent is the artificial counterpart to nao:Party. It can be a software component or some service.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/08/15/nao#Agent"></see></summary>
    let Agent = _prefix "Agent"
    /// <summary>
    /// Represents a desktop icon as defined in the FreeDesktop Icon Naming Standard (http://standards.freedesktop.org/icon-naming-spec/icon-naming-spec-latest.html).
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/08/15/nao#FreeDesktopIcon"></see></summary>
    let FreeDesktopIcon = _prefix "FreeDesktopIcon"
    /// <summary>
    /// Represents a symbol, a visual representation of a resource. Typically a local or remote file would be double-typed to be used as a symbol. An alternative is nao:FreeDesktopIcon.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/08/15/nao#Symbol"></see></summary>
    let Symbol = _prefix "Symbol"
    /// <summary>
    /// Represents a single or a group of individuals
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/08/15/nao#Party"></see></summary>
    let Party = _prefix "Party"
    /// <summary>
    /// Represents a generic tag
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/08/15/nao#Tag"></see></summary>
    let Tag = _prefix "Tag"
    /// <summary>
    /// An alternative label alongside the preferred label for a resource
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/08/15/nao#altLabel"></see></summary>
    let altLabel = _prefix "altLabel"
    /// <summary>
    /// An alternative symbol representation for a resource
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/08/15/nao#altSymbol"></see></summary>
    let altSymbol = _prefix "altSymbol"
    /// <summary>
    /// Annotation for a resource in the form of a visual representation. Typically the symbol is a double-typed image file or a nao:FreeDesktopIcon.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/08/15/nao#hasSymbol"></see></summary>
    let hasSymbol = _prefix "hasSymbol"
    /// <summary>
    /// Generic annotation for a resource
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/08/15/nao#annotation"></see></summary>
    let annotation = _prefix "annotation"
    /// <summary>
    /// Refers to a single or a group of individuals that contributed to a resource
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/08/15/nao#contributor"></see></summary>
    let contributor = _prefix "contributor"
    /// <summary>
    /// States the creation, or first modification time for a resource
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/08/15/nao#created"></see></summary>
    let created = _prefix "created"
    /// <summary>
    /// States the modification time for a resource
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/08/15/nao#modified"></see></summary>
    let modified = _prefix "modified"
    /// <summary>
    /// Refers to the single or group of individuals that created the resource
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/08/15/nao#creator"></see></summary>
    let creator = _prefix "creator"
    /// <summary>
    /// If this property is assigned, the subject class, property, or resource, is deprecated and should not be used in production systems any longer. It may be removed without further notice.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/08/15/nao#deprecated"></see></summary>
    let deprecated = _prefix "deprecated"
    /// <summary>
    /// A non-technical textual annotation for a resource
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/08/15/nao#description"></see></summary>
    let description = _prefix "description"
    /// <summary>
    /// A direct trust value assigned to an agent, either manually by a user or semi-/automatically by a system. Allowed values range from 0 (no trust) to 1 (very high trust).
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/08/15/nao#directTrust"></see></summary>
    let directTrust = _prefix "directTrust"
    /// <summary>
    /// A generalised trust level assigned to an agent, based on a combination of direct and network trust values it possesses. Allowed values range from 0 (no trust) to 1 (very high trust).
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/08/15/nao#trustLevel"></see></summary>
    let trustLevel = _prefix "trustLevel"
    /// <summary>
    /// Signifies social endorsment of a resource by a specific agent. Endorsement includes social actions like favouriting, liking, voting for, starring a resource.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/08/15/nao#endorsedBy"></see></summary>
    let endorsedBy = _prefix "endorsedBy"
    /// <summary>
    /// Specifies the engineering tool used to generate the graph
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/08/15/nao#engineeringTool"></see></summary>
    let engineeringTool = _prefix "engineeringTool"
    /// <summary>
    /// An external identifier for a resource that has been retreived from an external source.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/08/15/nao#externalIdentifier"></see></summary>
    let externalIdentifier = _prefix "externalIdentifier"
    /// <summary>
    /// Defines a generic identifier for a resource
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/08/15/nao#identifier"></see></summary>
    let identifier = _prefix "identifier"
    /// <summary>
    /// Signifies social endorsment by an agent, by way of marking the resource as a favourite.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/08/15/nao#favouritedBy"></see></summary>
    let favouritedBy = _prefix "favouritedBy"
    /// <summary>
    /// Links a resource to the graph which contains its metadata. Its typical usage would be to link the file resource to the graph containing its extracted file metadata. This allows for easy maintenance later on. Inverse property of nao:isDataGraphFor.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/08/15/nao#hasDataGraph"></see></summary>
    let hasDataGraph = _prefix "hasDataGraph"
    /// <summary>
    /// Links a named graph to the resource for which it contains metadata. Its typical usage would be to link the graph containing extracted file metadata to the file resource. This allows for easy maintenance later on. Inverse property of nao:hasDataGraph.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/08/15/nao#isDataGraphFor"></see></summary>
    let isDataGraphFor = _prefix "isDataGraphFor"
    /// <summary>
    /// Defines the default static namespace for a graph
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/08/15/nao#hasDefaultNamespace"></see></summary>
    let hasDefaultNamespace = _prefix "hasDefaultNamespace"
    /// <summary>
    /// Defines the default static namespace abbreviation for a graph
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/08/15/nao#hasDefaultNamespaceAbbreviation"></see></summary>
    let hasDefaultNamespaceAbbreviation = _prefix "hasDefaultNamespaceAbbreviation"
    /// <summary>
    /// Defines a relationship between a resource and one or more sub resources. Descriptions of sub-resources are only interpretable when the super-resource exists. Deleting a super-resource should then also delete all sub-resources, and transferring a super-resource (for example, sending it to another user) must also include the sub-resource.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/08/15/nao#hasSubResource"></see></summary>
    let hasSubResource = _prefix "hasSubResource"
    /// <summary>
    /// Defines a relationship between a resource and one or more super resources
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/08/15/nao#hasSuperResource"></see></summary>
    let hasSuperResource = _prefix "hasSuperResource"
    /// <summary>
    /// Defines an annotation for a resource in the form of a relationship between the subject resource and another resource
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/08/15/nao#isRelated"></see></summary>
    let isRelated = _prefix "isRelated"
    /// <summary>
    /// Defines an existing tag for a resource
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/08/15/nao#hasTag"></see></summary>
    let hasTag = _prefix "hasTag"
    /// <summary>
    /// States which resources a tag is associated with
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/08/15/nao#isTagFor"></see></summary>
    let isTagFor = _prefix "isTagFor"
    /// <summary>
    /// Defines a relationship between two resources, where the object is a topic of the subject
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/08/15/nao#hasTopic"></see></summary>
    let hasTopic = _prefix "hasTopic"
    /// <summary>
    /// Defines a relationship between two resources, where the subject is a topic of the object
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/08/15/nao#isTopicOf"></see></summary>
    let isTopicOf = _prefix "isTopicOf"
    /// <summary>
    /// Defines a name for a FreeDesktop Icon as defined in the FreeDesktop Icon Naming Standard
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/08/15/nao#iconName"></see></summary>
    let iconName = _prefix "iconName"
    /// <summary>
    /// States the last modification time for a resource
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/08/15/nao#lastModified"></see></summary>
    let lastModified = _prefix "lastModified"
    /// <summary>
    /// The agent that maintains this resource, ie. created it and knows what to do with it.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/08/15/nao#maintainedBy"></see></summary>
    let maintainedBy = _prefix "maintainedBy"
    /// <summary>
    /// A network-derived trust value assigned to an agent, based on the shared direct trust values for the same agent, as set by participating agents in a network. Allowed values range from 0 (no trust) to 1 (very high trust).
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/08/15/nao#networkTrust"></see></summary>
    let networkTrust = _prefix "networkTrust"
    /// <summary>
    ///  Annotation for a resource in the form of a numeric rating (float value), allowed values are between 1 and 10 whereas 0 is interpreted as not set
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/08/15/nao#numericRating"></see></summary>
    let numericRating = _prefix "numericRating"
    /// <summary>
    /// A marker property to mark selected properties which are input to a mathematical algorithm to generate scores for resources. Properties are marked by being defined as subproperties of this property
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/08/15/nao#scoreParameter"></see></summary>
    let scoreParameter = _prefix "scoreParameter"
    /// <summary>
    /// Annotation for a resource in the form of an unrestricted rating
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/08/15/nao#rating"></see></summary>
    let rating = _prefix "rating"
    /// <summary>
    /// Defines a personal string identifier for a resource
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/08/15/nao#personalIdentifier"></see></summary>
    let personalIdentifier = _prefix "personalIdentifier"
    /// <summary>
    /// The plural form of the preferred label for a resource
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/08/15/nao#pluralPrefLabel"></see></summary>
    let pluralPrefLabel = _prefix "pluralPrefLabel"
    /// <summary>
    /// A preferred label for a resource
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/08/15/nao#prefLabel"></see></summary>
    let prefLabel = _prefix "prefLabel"
    /// <summary>
    /// A unique preferred symbol representation for a resource
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/08/15/nao#prefSymbol"></see></summary>
    let prefSymbol = _prefix "prefSymbol"
    /// <summary>
    /// A privacy level as defined for a resource. Allowed values range from 0 (private) to 1 (public).
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/08/15/nao#privacyLevel"></see></summary>
    let privacyLevel = _prefix "privacyLevel"
    /// <summary>
    /// An authoritative score for an item valued between 0 and 1
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/08/15/nao#score"></see></summary>
    let score = _prefix "score"
    /// <summary>
    /// States the serialization language for a named graph that is represented within a document
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/08/15/nao#serializationLanguage"></see></summary>
    let serializationLanguage = _prefix "serializationLanguage"
    /// <summary>
    /// Specifies the status of a graph, stable, unstable or testing
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/08/15/nao#status"></see></summary>
    let status = _prefix "status"
    /// <summary>
    /// Mark a property, class, or even resource as user visible or not. Non-user-visible entities should never be presented to the user. By default everything is user-visible.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/08/15/nao#userVisible"></see></summary>
    let userVisible = _prefix "userVisible"
    /// <summary>
    /// Specifies the version of a graph, in numeric format
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/08/15/nao#version"></see></summary>
    let version = _prefix "version"
