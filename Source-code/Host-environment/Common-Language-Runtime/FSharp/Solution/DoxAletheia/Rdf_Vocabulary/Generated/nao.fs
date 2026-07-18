namespace http.www.semanticdesktop.org.ontologies._2007._08._15.nao.hash

open DoxAletheia.Rdf_Vocabulary

module nao =
    let _namespace_name = "http://www.semanticdesktop.org/ontologies/2007/08/15/nao#"
    /// <summary>
    /// An agent is the artificial counterpart to nao:Party. It can be a software component or some service.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/08/15/nao#Agent"></see></summary>
    let Agent = Namespaced_IRI.parse _namespace_name "Agent" |> NamespacedName

    /// <summary>
    /// Represents a desktop icon as defined in the FreeDesktop Icon Naming Standard (http://standards.freedesktop.org/icon-naming-spec/icon-naming-spec-latest.html).
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/08/15/nao#FreeDesktopIcon"></see></summary>
    let FreeDesktopIcon =
        Namespaced_IRI.parse _namespace_name "FreeDesktopIcon" |> NamespacedName

    /// <summary>
    /// Represents a symbol, a visual representation of a resource. Typically a local or remote file would be double-typed to be used as a symbol. An alternative is nao:FreeDesktopIcon.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/08/15/nao#Symbol"></see></summary>
    let Symbol = Namespaced_IRI.parse _namespace_name "Symbol" |> NamespacedName
    /// <summary>
    /// Represents a single or a group of individuals
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/08/15/nao#Party"></see></summary>
    let Party = Namespaced_IRI.parse _namespace_name "Party" |> NamespacedName
    /// <summary>
    /// Represents a generic tag
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/08/15/nao#Tag"></see></summary>
    let Tag = Namespaced_IRI.parse _namespace_name "Tag" |> NamespacedName
    /// <summary>
    /// An alternative label alongside the preferred label for a resource
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/08/15/nao#altLabel"></see></summary>
    let altLabel = Namespaced_IRI.parse _namespace_name "altLabel" |> NamespacedName
    /// <summary>
    /// An alternative symbol representation for a resource
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/08/15/nao#altSymbol"></see></summary>
    let altSymbol = Namespaced_IRI.parse _namespace_name "altSymbol" |> NamespacedName
    /// <summary>
    /// Annotation for a resource in the form of a visual representation. Typically the symbol is a double-typed image file or a nao:FreeDesktopIcon.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/08/15/nao#hasSymbol"></see></summary>
    let hasSymbol = Namespaced_IRI.parse _namespace_name "hasSymbol" |> NamespacedName
    /// <summary>
    /// Generic annotation for a resource
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/08/15/nao#annotation"></see></summary>
    let annotation = Namespaced_IRI.parse _namespace_name "annotation" |> NamespacedName

    /// <summary>
    /// Refers to a single or a group of individuals that contributed to a resource
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/08/15/nao#contributor"></see></summary>
    let contributor =
        Namespaced_IRI.parse _namespace_name "contributor" |> NamespacedName

    /// <summary>
    /// States the creation, or first modification time for a resource
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/08/15/nao#created"></see></summary>
    let created = Namespaced_IRI.parse _namespace_name "created" |> NamespacedName
    /// <summary>
    /// States the modification time for a resource
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/08/15/nao#modified"></see></summary>
    let modified = Namespaced_IRI.parse _namespace_name "modified" |> NamespacedName
    /// <summary>
    /// Refers to the single or group of individuals that created the resource
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/08/15/nao#creator"></see></summary>
    let creator = Namespaced_IRI.parse _namespace_name "creator" |> NamespacedName
    /// <summary>
    /// If this property is assigned, the subject class, property, or resource, is deprecated and should not be used in production systems any longer. It may be removed without further notice.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/08/15/nao#deprecated"></see></summary>
    let deprecated = Namespaced_IRI.parse _namespace_name "deprecated" |> NamespacedName

    /// <summary>
    /// A non-technical textual annotation for a resource
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/08/15/nao#description"></see></summary>
    let description =
        Namespaced_IRI.parse _namespace_name "description" |> NamespacedName

    /// <summary>
    /// A direct trust value assigned to an agent, either manually by a user or semi-/automatically by a system. Allowed values range from 0 (no trust) to 1 (very high trust).
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/08/15/nao#directTrust"></see></summary>
    let directTrust =
        Namespaced_IRI.parse _namespace_name "directTrust" |> NamespacedName

    /// <summary>
    /// A generalised trust level assigned to an agent, based on a combination of direct and network trust values it possesses. Allowed values range from 0 (no trust) to 1 (very high trust).
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/08/15/nao#trustLevel"></see></summary>
    let trustLevel = Namespaced_IRI.parse _namespace_name "trustLevel" |> NamespacedName
    /// <summary>
    /// Signifies social endorsment of a resource by a specific agent. Endorsement includes social actions like favouriting, liking, voting for, starring a resource.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/08/15/nao#endorsedBy"></see></summary>
    let endorsedBy = Namespaced_IRI.parse _namespace_name "endorsedBy" |> NamespacedName

    /// <summary>
    /// Specifies the engineering tool used to generate the graph
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/08/15/nao#engineeringTool"></see></summary>
    let engineeringTool =
        Namespaced_IRI.parse _namespace_name "engineeringTool" |> NamespacedName

    /// <summary>
    /// An external identifier for a resource that has been retreived from an external source.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/08/15/nao#externalIdentifier"></see></summary>
    let externalIdentifier =
        Namespaced_IRI.parse _namespace_name "externalIdentifier" |> NamespacedName

    /// <summary>
    /// Defines a generic identifier for a resource
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/08/15/nao#identifier"></see></summary>
    let identifier = Namespaced_IRI.parse _namespace_name "identifier" |> NamespacedName

    /// <summary>
    /// Signifies social endorsment by an agent, by way of marking the resource as a favourite.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/08/15/nao#favouritedBy"></see></summary>
    let favouritedBy =
        Namespaced_IRI.parse _namespace_name "favouritedBy" |> NamespacedName

    /// <summary>
    /// Links a resource to the graph which contains its metadata. Its typical usage would be to link the file resource to the graph containing its extracted file metadata. This allows for easy maintenance later on. Inverse property of nao:isDataGraphFor.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/08/15/nao#hasDataGraph"></see></summary>
    let hasDataGraph =
        Namespaced_IRI.parse _namespace_name "hasDataGraph" |> NamespacedName

    /// <summary>
    /// Links a named graph to the resource for which it contains metadata. Its typical usage would be to link the graph containing extracted file metadata to the file resource. This allows for easy maintenance later on. Inverse property of nao:hasDataGraph.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/08/15/nao#isDataGraphFor"></see></summary>
    let isDataGraphFor =
        Namespaced_IRI.parse _namespace_name "isDataGraphFor" |> NamespacedName

    /// <summary>
    /// Defines the default static namespace for a graph
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/08/15/nao#hasDefaultNamespace"></see></summary>
    let hasDefaultNamespace =
        Namespaced_IRI.parse _namespace_name "hasDefaultNamespace" |> NamespacedName

    /// <summary>
    /// Defines the default static namespace abbreviation for a graph
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/08/15/nao#hasDefaultNamespaceAbbreviation"></see></summary>
    let hasDefaultNamespaceAbbreviation =
        Namespaced_IRI.parse _namespace_name "hasDefaultNamespaceAbbreviation" |> NamespacedName

    /// <summary>
    /// Defines a relationship between a resource and one or more sub resources. Descriptions of sub-resources are only interpretable when the super-resource exists. Deleting a super-resource should then also delete all sub-resources, and transferring a super-resource (for example, sending it to another user) must also include the sub-resource.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/08/15/nao#hasSubResource"></see></summary>
    let hasSubResource =
        Namespaced_IRI.parse _namespace_name "hasSubResource" |> NamespacedName

    /// <summary>
    /// Defines a relationship between a resource and one or more super resources
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/08/15/nao#hasSuperResource"></see></summary>
    let hasSuperResource =
        Namespaced_IRI.parse _namespace_name "hasSuperResource" |> NamespacedName

    /// <summary>
    /// Defines an annotation for a resource in the form of a relationship between the subject resource and another resource
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/08/15/nao#isRelated"></see></summary>
    let isRelated = Namespaced_IRI.parse _namespace_name "isRelated" |> NamespacedName
    /// <summary>
    /// Defines an existing tag for a resource
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/08/15/nao#hasTag"></see></summary>
    let hasTag = Namespaced_IRI.parse _namespace_name "hasTag" |> NamespacedName
    /// <summary>
    /// States which resources a tag is associated with
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/08/15/nao#isTagFor"></see></summary>
    let isTagFor = Namespaced_IRI.parse _namespace_name "isTagFor" |> NamespacedName
    /// <summary>
    /// Defines a relationship between two resources, where the object is a topic of the subject
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/08/15/nao#hasTopic"></see></summary>
    let hasTopic = Namespaced_IRI.parse _namespace_name "hasTopic" |> NamespacedName
    /// <summary>
    /// Defines a relationship between two resources, where the subject is a topic of the object
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/08/15/nao#isTopicOf"></see></summary>
    let isTopicOf = Namespaced_IRI.parse _namespace_name "isTopicOf" |> NamespacedName
    /// <summary>
    /// Defines a name for a FreeDesktop Icon as defined in the FreeDesktop Icon Naming Standard
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/08/15/nao#iconName"></see></summary>
    let iconName = Namespaced_IRI.parse _namespace_name "iconName" |> NamespacedName

    /// <summary>
    /// States the last modification time for a resource
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/08/15/nao#lastModified"></see></summary>
    let lastModified =
        Namespaced_IRI.parse _namespace_name "lastModified" |> NamespacedName

    /// <summary>
    /// The agent that maintains this resource, ie. created it and knows what to do with it.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/08/15/nao#maintainedBy"></see></summary>
    let maintainedBy =
        Namespaced_IRI.parse _namespace_name "maintainedBy" |> NamespacedName

    /// <summary>
    /// A network-derived trust value assigned to an agent, based on the shared direct trust values for the same agent, as set by participating agents in a network. Allowed values range from 0 (no trust) to 1 (very high trust).
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/08/15/nao#networkTrust"></see></summary>
    let networkTrust =
        Namespaced_IRI.parse _namespace_name "networkTrust" |> NamespacedName

    /// <summary>
    ///  Annotation for a resource in the form of a numeric rating (float value), allowed values are between 1 and 10 whereas 0 is interpreted as not set
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/08/15/nao#numericRating"></see></summary>
    let numericRating =
        Namespaced_IRI.parse _namespace_name "numericRating" |> NamespacedName

    /// <summary>
    /// A marker property to mark selected properties which are input to a mathematical algorithm to generate scores for resources. Properties are marked by being defined as subproperties of this property
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/08/15/nao#scoreParameter"></see></summary>
    let scoreParameter =
        Namespaced_IRI.parse _namespace_name "scoreParameter" |> NamespacedName

    /// <summary>
    /// Annotation for a resource in the form of an unrestricted rating
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/08/15/nao#rating"></see></summary>
    let rating = Namespaced_IRI.parse _namespace_name "rating" |> NamespacedName

    /// <summary>
    /// Defines a personal string identifier for a resource
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/08/15/nao#personalIdentifier"></see></summary>
    let personalIdentifier =
        Namespaced_IRI.parse _namespace_name "personalIdentifier" |> NamespacedName

    /// <summary>
    /// The plural form of the preferred label for a resource
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/08/15/nao#pluralPrefLabel"></see></summary>
    let pluralPrefLabel =
        Namespaced_IRI.parse _namespace_name "pluralPrefLabel" |> NamespacedName

    /// <summary>
    /// A preferred label for a resource
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/08/15/nao#prefLabel"></see></summary>
    let prefLabel = Namespaced_IRI.parse _namespace_name "prefLabel" |> NamespacedName
    /// <summary>
    /// A unique preferred symbol representation for a resource
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/08/15/nao#prefSymbol"></see></summary>
    let prefSymbol = Namespaced_IRI.parse _namespace_name "prefSymbol" |> NamespacedName

    /// <summary>
    /// A privacy level as defined for a resource. Allowed values range from 0 (private) to 1 (public).
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/08/15/nao#privacyLevel"></see></summary>
    let privacyLevel =
        Namespaced_IRI.parse _namespace_name "privacyLevel" |> NamespacedName

    /// <summary>
    /// An authoritative score for an item valued between 0 and 1
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/08/15/nao#score"></see></summary>
    let score = Namespaced_IRI.parse _namespace_name "score" |> NamespacedName

    /// <summary>
    /// States the serialization language for a named graph that is represented within a document
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/08/15/nao#serializationLanguage"></see></summary>
    let serializationLanguage =
        Namespaced_IRI.parse _namespace_name "serializationLanguage" |> NamespacedName

    /// <summary>
    /// Specifies the status of a graph, stable, unstable or testing
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/08/15/nao#status"></see></summary>
    let status = Namespaced_IRI.parse _namespace_name "status" |> NamespacedName

    /// <summary>
    /// Mark a property, class, or even resource as user visible or not. Non-user-visible entities should never be presented to the user. By default everything is user-visible.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/08/15/nao#userVisible"></see></summary>
    let userVisible =
        Namespaced_IRI.parse _namespace_name "userVisible" |> NamespacedName

    /// <summary>
    /// Specifies the version of a graph, in numeric format
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/08/15/nao#version"></see></summary>
    let version = Namespaced_IRI.parse _namespace_name "version" |> NamespacedName
