namespace http.www.semanticdesktop.org.ontologies._2007._08._15.nao.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module nao =
    let _namespace_iri = Namespace_Iri nao |> NamespaceIRI
    /// <summary>
    ///   <para>nao:Agent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An agent is the artificial counterpart to nao:Party. It can be a software component or some service."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"agent"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/08/15/nao#Agent">http://www.semanticdesktop.org/ontologies/2007/08/15/nao#Agent</seealso>
    let Agent = Prefixed_Name(nao, "Agent") |> PrefixedName
    /// <summary>
    ///   <para>nao:FreeDesktopIcon</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Represents a desktop icon as defined in the FreeDesktop Icon Naming Standard (http://standards.freedesktop.org/icon-naming-spec/icon-naming-spec-latest.html)."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"freedesktopicon"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/08/15/nao#FreeDesktopIcon">http://www.semanticdesktop.org/ontologies/2007/08/15/nao#FreeDesktopIcon</seealso>
    let FreeDesktopIcon = Prefixed_Name(nao, "FreeDesktopIcon") |> PrefixedName
    /// <summary>
    ///   <para>nao:Party</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Represents a single or a group of individuals"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"party"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/08/15/nao#Party">http://www.semanticdesktop.org/ontologies/2007/08/15/nao#Party</seealso>
    let Party = Prefixed_Name(nao, "Party") |> PrefixedName
    /// <summary>
    ///   <para>nao:Symbol</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Represents a symbol, a visual representation of a resource. Typically a local or remote file would be double-typed to be used as a symbol. An alternative is nao:FreeDesktopIcon."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"symbol"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/08/15/nao#Symbol">http://www.semanticdesktop.org/ontologies/2007/08/15/nao#Symbol</seealso>
    let Symbol = Prefixed_Name(nao, "Symbol") |> PrefixedName
    /// <summary>
    ///   <para>nao:Tag</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Represents a generic tag"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"tag"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/08/15/nao#Tag">http://www.semanticdesktop.org/ontologies/2007/08/15/nao#Tag</seealso>
    let Tag = Prefixed_Name(nao, "Tag") |> PrefixedName
    /// <summary>
    ///   <para>nao:altLabel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>"An alternative label alongside the preferred label for a resource"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"alternative label"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/08/15/nao#altLabel">http://www.semanticdesktop.org/ontologies/2007/08/15/nao#altLabel</seealso>
    let altLabel = Prefixed_Name(nao, "altLabel") |> PrefixedName
    /// <summary>
    ///   <para>nao:altSymbol</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"An alternative symbol representation for a resource"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"alternative symbol"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/08/15/nao#altSymbol">http://www.semanticdesktop.org/ontologies/2007/08/15/nao#altSymbol</seealso>
    let altSymbol = Prefixed_Name(nao, "altSymbol") |> PrefixedName
    /// <summary>
    ///   <para>nao:annotation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>"Generic annotation for a resource"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"annotation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/08/15/nao#annotation">http://www.semanticdesktop.org/ontologies/2007/08/15/nao#annotation</seealso>
    let annotation = Prefixed_Name(nao, "annotation") |> PrefixedName
    /// <summary>
    ///   <para>nao:contributor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Refers to a single or a group of individuals that contributed to a resource"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"contributor"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/08/15/nao#contributor">http://www.semanticdesktop.org/ontologies/2007/08/15/nao#contributor</seealso>
    let contributor = Prefixed_Name(nao, "contributor") |> PrefixedName
    /// <summary>
    ///   <para>nao:created</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"States the creation, or first modification time for a resource"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"created at"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/08/15/nao#created">http://www.semanticdesktop.org/ontologies/2007/08/15/nao#created</seealso>
    let created = Prefixed_Name(nao, "created") |> PrefixedName
    /// <summary>
    ///   <para>nao:creator</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Refers to the single or group of individuals that created the resource"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"creator"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/08/15/nao#creator">http://www.semanticdesktop.org/ontologies/2007/08/15/nao#creator</seealso>
    let creator = Prefixed_Name(nao, "creator") |> PrefixedName
    /// <summary>
    ///   <para>nao:deprecated</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"If this property is assigned, the subject class, property, or resource, is deprecated and should not be used in production systems any longer. It may be removed without further notice."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"deprecated"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/08/15/nao#deprecated">http://www.semanticdesktop.org/ontologies/2007/08/15/nao#deprecated</seealso>
    let deprecated = Prefixed_Name(nao, "deprecated") |> PrefixedName
    /// <summary>
    ///   <para>nao:description</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>"A non-technical textual annotation for a resource"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"description"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/08/15/nao#description">http://www.semanticdesktop.org/ontologies/2007/08/15/nao#description</seealso>
    let description = Prefixed_Name(nao, "description") |> PrefixedName
    /// <summary>
    ///   <para>nao:directTrust</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>"A direct trust value assigned to an agent, either manually by a user or semi-/automatically by a system. Allowed values range from 0 (no trust) to 1 (very high trust)."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"direct trust"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/08/15/nao#directTrust">http://www.semanticdesktop.org/ontologies/2007/08/15/nao#directTrust</seealso>
    let directTrust = Prefixed_Name(nao, "directTrust") |> PrefixedName
    /// <summary>
    ///   <para>nao:endorsedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Signifies social endorsment of a resource by a specific agent. Endorsement includes social actions like favouriting, liking, voting for, starring a resource."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"endorsed by"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/08/15/nao#endorsedBy">http://www.semanticdesktop.org/ontologies/2007/08/15/nao#endorsedBy</seealso>
    let endorsedBy = Prefixed_Name(nao, "endorsedBy") |> PrefixedName
    /// <summary>
    ///   <para>nao:engineeringTool</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>"Specifies the engineering tool used to generate the graph"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"engineering tool"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/08/15/nao#engineeringTool">http://www.semanticdesktop.org/ontologies/2007/08/15/nao#engineeringTool</seealso>
    let engineeringTool = Prefixed_Name(nao, "engineeringTool") |> PrefixedName
    /// <summary>
    ///   <para>nao:externalIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"An external identifier for a resource that has been retreived from an external source."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"external identifier"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/08/15/nao#externalIdentifier">http://www.semanticdesktop.org/ontologies/2007/08/15/nao#externalIdentifier</seealso>
    let externalIdentifier = Prefixed_Name(nao, "externalIdentifier") |> PrefixedName
    /// <summary>
    ///   <para>nao:favouritedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Signifies social endorsment by an agent, by way of marking the resource as a favourite."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"favourited by"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/08/15/nao#favouritedBy">http://www.semanticdesktop.org/ontologies/2007/08/15/nao#favouritedBy</seealso>
    let favouritedBy = Prefixed_Name(nao, "favouritedBy") |> PrefixedName
    /// <summary>
    ///   <para>nao:hasDataGraph</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Links a resource to the graph which contains its metadata. Its typical usage would be to link the file resource to the graph containing its extracted file metadata. This allows for easy maintenance later on. Inverse property of nao:isDataGraphFor."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"has data graph"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/08/15/nao#hasDataGraph">http://www.semanticdesktop.org/ontologies/2007/08/15/nao#hasDataGraph</seealso>
    let hasDataGraph = Prefixed_Name(nao, "hasDataGraph") |> PrefixedName
    /// <summary>
    ///   <para>nao:hasDefaultNamespace</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Defines the default static namespace for a graph"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"has default namespace"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/08/15/nao#hasDefaultNamespace">http://www.semanticdesktop.org/ontologies/2007/08/15/nao#hasDefaultNamespace</seealso>
    let hasDefaultNamespace = Prefixed_Name(nao, "hasDefaultNamespace") |> PrefixedName

    /// <summary>
    ///   <para>nao:hasDefaultNamespaceAbbreviation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Defines the default static namespace abbreviation for a graph"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"has default namespace abbreviation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/08/15/nao#hasDefaultNamespaceAbbreviation">http://www.semanticdesktop.org/ontologies/2007/08/15/nao#hasDefaultNamespaceAbbreviation</seealso>
    let hasDefaultNamespaceAbbreviation =
        Prefixed_Name(nao, "hasDefaultNamespaceAbbreviation") |> PrefixedName

    /// <summary>
    ///   <para>nao:hasSubResource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Defines a relationship between a resource and one or more sub resources. Descriptions of sub-resources are only interpretable when the super-resource exists. Deleting a super-resource should then also delete all sub-resources, and transferring a super-resource (for example, sending it to another user) must also include the sub-resource."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"has Subresource"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/08/15/nao#hasSubResource">http://www.semanticdesktop.org/ontologies/2007/08/15/nao#hasSubResource</seealso>
    let hasSubResource = Prefixed_Name(nao, "hasSubResource") |> PrefixedName
    /// <summary>
    ///   <para>nao:hasSuperResource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Defines a relationship between a resource and one or more super resources"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"has Superresource"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/08/15/nao#hasSuperResource">http://www.semanticdesktop.org/ontologies/2007/08/15/nao#hasSuperResource</seealso>
    let hasSuperResource = Prefixed_Name(nao, "hasSuperResource") |> PrefixedName
    /// <summary>
    ///   <para>nao:hasSymbol</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Annotation for a resource in the form of a visual representation. Typically the symbol is a double-typed image file or a nao:FreeDesktopIcon."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"has symbol"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/08/15/nao#hasSymbol">http://www.semanticdesktop.org/ontologies/2007/08/15/nao#hasSymbol</seealso>
    let hasSymbol = Prefixed_Name(nao, "hasSymbol") |> PrefixedName
    /// <summary>
    ///   <para>nao:hasTag</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Defines an existing tag for a resource"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"has tag"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/08/15/nao#hasTag">http://www.semanticdesktop.org/ontologies/2007/08/15/nao#hasTag</seealso>
    let hasTag = Prefixed_Name(nao, "hasTag") |> PrefixedName
    /// <summary>
    ///   <para>nao:hasTopic</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Defines a relationship between two resources, where the object is a topic of the subject"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"has topic"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/08/15/nao#hasTopic">http://www.semanticdesktop.org/ontologies/2007/08/15/nao#hasTopic</seealso>
    let hasTopic = Prefixed_Name(nao, "hasTopic") |> PrefixedName
    /// <summary>
    ///   <para>nao:iconName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>"Defines a name for a FreeDesktop Icon as defined in the FreeDesktop Icon Naming Standard"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"iconname"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/08/15/nao#iconName">http://www.semanticdesktop.org/ontologies/2007/08/15/nao#iconName</seealso>
    let iconName = Prefixed_Name(nao, "iconName") |> PrefixedName
    /// <summary>
    ///   <para>nao:identifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>"Defines a generic identifier for a resource"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"identifier"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/08/15/nao#identifier">http://www.semanticdesktop.org/ontologies/2007/08/15/nao#identifier</seealso>
    let identifier = Prefixed_Name(nao, "identifier") |> PrefixedName
    /// <summary>
    ///   <para>nao:isDataGraphFor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Links a named graph to the resource for which it contains metadata. Its typical usage would be to link the graph containing extracted file metadata to the file resource. This allows for easy maintenance later on. Inverse property of nao:hasDataGraph."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"is data graph for"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/08/15/nao#isDataGraphFor">http://www.semanticdesktop.org/ontologies/2007/08/15/nao#isDataGraphFor</seealso>
    let isDataGraphFor = Prefixed_Name(nao, "isDataGraphFor") |> PrefixedName
    /// <summary>
    ///   <para>nao:isRelated</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>nrl:SymmetricProperty</para>
    ///   <para>"Defines an annotation for a resource in the form of a relationship between the subject resource and another resource"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"is related to"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/08/15/nao#isRelated">http://www.semanticdesktop.org/ontologies/2007/08/15/nao#isRelated</seealso>
    let isRelated = Prefixed_Name(nao, "isRelated") |> PrefixedName
    /// <summary>
    ///   <para>nao:isTagFor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>"States which resources a tag is associated with"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"is tag for"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/08/15/nao#isTagFor">http://www.semanticdesktop.org/ontologies/2007/08/15/nao#isTagFor</seealso>
    let isTagFor = Prefixed_Name(nao, "isTagFor") |> PrefixedName
    /// <summary>
    ///   <para>nao:isTopicOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Defines a relationship between two resources, where the subject is a topic of the object"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"is topic of"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/08/15/nao#isTopicOf">http://www.semanticdesktop.org/ontologies/2007/08/15/nao#isTopicOf</seealso>
    let isTopicOf = Prefixed_Name(nao, "isTopicOf") |> PrefixedName
    /// <summary>
    ///   <para>nao:lastModified</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"States the last modification time for a resource"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"last modified at"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/08/15/nao#lastModified">http://www.semanticdesktop.org/ontologies/2007/08/15/nao#lastModified</seealso>
    let lastModified = Prefixed_Name(nao, "lastModified") |> PrefixedName
    /// <summary>
    ///   <para>nao:maintainedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>"The agent that maintains this resource, ie. created it and knows what to do with it."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"maintained by"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/08/15/nao#maintainedBy">http://www.semanticdesktop.org/ontologies/2007/08/15/nao#maintainedBy</seealso>
    let maintainedBy = Prefixed_Name(nao, "maintainedBy") |> PrefixedName
    /// <summary>
    ///   <para>nao:modified</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>"States the modification time for a resource"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"modified at"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/08/15/nao#modified">http://www.semanticdesktop.org/ontologies/2007/08/15/nao#modified</seealso>
    let modified = Prefixed_Name(nao, "modified") |> PrefixedName
    /// <summary>
    ///   <para>nao:networkTrust</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>"A network-derived trust value assigned to an agent, based on the shared direct trust values for the same agent, as set by participating agents in a network. Allowed values range from 0 (no trust) to 1 (very high trust)."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"network trust"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/08/15/nao#networkTrust">http://www.semanticdesktop.org/ontologies/2007/08/15/nao#networkTrust</seealso>
    let networkTrust = Prefixed_Name(nao, "networkTrust") |> PrefixedName
    /// <summary>
    ///   <para>nao:numericRating</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>" Annotation for a resource in the form of a numeric rating (float value), allowed values are between 1 and 10 whereas 0 is interpreted as not set"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"numeric rating"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/08/15/nao#numericRating">http://www.semanticdesktop.org/ontologies/2007/08/15/nao#numericRating</seealso>
    let numericRating = Prefixed_Name(nao, "numericRating") |> PrefixedName
    /// <summary>
    ///   <para>nao:personalIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>nrl:InverseFunctionalProperty</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Defines a personal string identifier for a resource"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"personal identifier"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/08/15/nao#personalIdentifier">http://www.semanticdesktop.org/ontologies/2007/08/15/nao#personalIdentifier</seealso>
    let personalIdentifier = Prefixed_Name(nao, "personalIdentifier") |> PrefixedName
    /// <summary>
    ///   <para>nao:pluralPrefLabel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>"The plural form of the preferred label for a resource"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"preferred label plural form"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/08/15/nao#pluralPrefLabel">http://www.semanticdesktop.org/ontologies/2007/08/15/nao#pluralPrefLabel</seealso>
    let pluralPrefLabel = Prefixed_Name(nao, "pluralPrefLabel") |> PrefixedName
    /// <summary>
    ///   <para>nao:prefLabel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>"A preferred label for a resource"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"preferred label"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/08/15/nao#prefLabel">http://www.semanticdesktop.org/ontologies/2007/08/15/nao#prefLabel</seealso>
    let prefLabel = Prefixed_Name(nao, "prefLabel") |> PrefixedName
    /// <summary>
    ///   <para>nao:prefSymbol</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A unique preferred symbol representation for a resource"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"preferred symbol"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/08/15/nao#prefSymbol">http://www.semanticdesktop.org/ontologies/2007/08/15/nao#prefSymbol</seealso>
    let prefSymbol = Prefixed_Name(nao, "prefSymbol") |> PrefixedName
    /// <summary>
    ///   <para>nao:privacyLevel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>"A privacy level as defined for a resource. Allowed values range from 0 (private) to 1 (public)."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"privacy level"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/08/15/nao#privacyLevel">http://www.semanticdesktop.org/ontologies/2007/08/15/nao#privacyLevel</seealso>
    let privacyLevel = Prefixed_Name(nao, "privacyLevel") |> PrefixedName
    /// <summary>
    ///   <para>nao:rating</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>"Annotation for a resource in the form of an unrestricted rating"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"rating"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/08/15/nao#rating">http://www.semanticdesktop.org/ontologies/2007/08/15/nao#rating</seealso>
    let rating = Prefixed_Name(nao, "rating") |> PrefixedName
    /// <summary>
    ///   <para>nao:score</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"An authoritative score for an item valued between 0 and 1"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"score"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/08/15/nao#score">http://www.semanticdesktop.org/ontologies/2007/08/15/nao#score</seealso>
    let score = Prefixed_Name(nao, "score") |> PrefixedName
    /// <summary>
    ///   <para>nao:scoreParameter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"A marker property to mark selected properties which are input to a mathematical algorithm to generate scores for resources. Properties are marked by being defined as subproperties of this property"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"scoreparameter"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/08/15/nao#scoreParameter">http://www.semanticdesktop.org/ontologies/2007/08/15/nao#scoreParameter</seealso>
    let scoreParameter = Prefixed_Name(nao, "scoreParameter") |> PrefixedName

    /// <summary>
    ///   <para>nao:serializationLanguage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"States the serialization language for a named graph that is represented within a document"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"serialization language"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/08/15/nao#serializationLanguage">http://www.semanticdesktop.org/ontologies/2007/08/15/nao#serializationLanguage</seealso>
    let serializationLanguage =
        Prefixed_Name(nao, "serializationLanguage") |> PrefixedName

    /// <summary>
    ///   <para>nao:status</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Specifies the status of a graph, stable, unstable or testing"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"status"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/08/15/nao#status">http://www.semanticdesktop.org/ontologies/2007/08/15/nao#status</seealso>
    let status = Prefixed_Name(nao, "status") |> PrefixedName
    /// <summary>
    ///   <para>nao:trustLevel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>"A generalised trust level assigned to an agent, based on a combination of direct and network trust values it possesses. Allowed values range from 0 (no trust) to 1 (very high trust)."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"trust level"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/08/15/nao#trustLevel">http://www.semanticdesktop.org/ontologies/2007/08/15/nao#trustLevel</seealso>
    let trustLevel = Prefixed_Name(nao, "trustLevel") |> PrefixedName
    /// <summary>
    ///   <para>nao:updatable</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/08/15/nao#updatable">http://www.semanticdesktop.org/ontologies/2007/08/15/nao#updatable</seealso>
    let updatable = Prefixed_Name(nao, "updatable") |> PrefixedName
    /// <summary>
    ///   <para>nao:userVisible</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Mark a property, class, or even resource as user visible or not. Non-user-visible entities should never be presented to the user. By default everything is user-visible."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"user visible"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/08/15/nao#userVisible">http://www.semanticdesktop.org/ontologies/2007/08/15/nao#userVisible</seealso>
    let userVisible = Prefixed_Name(nao, "userVisible") |> PrefixedName
    /// <summary>
    ///   <para>nao:version</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Specifies the version of a graph, in numeric format"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"version"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/08/15/nao#version">http://www.semanticdesktop.org/ontologies/2007/08/15/nao#version</seealso>
    let version = Prefixed_Name(nao, "version") |> PrefixedName
