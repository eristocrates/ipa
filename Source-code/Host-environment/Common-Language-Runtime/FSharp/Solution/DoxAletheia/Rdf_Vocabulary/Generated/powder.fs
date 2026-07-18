namespace http.www.w3.org._2007._05.powder.hash

open DoxAletheia.Rdf_Vocabulary

module powder =
    let _namespace_name = "http://www.w3.org/2007/05/powder#"
    /// <summary>
    /// This class denotes a description, the set of resources to which it applies (the DR scope), and the author who created it. Its three components correspond, respectively, to classes wdr:Descriptors, wdr:ResourceSet, and to foaf:agent which is linked by the property foaf:maker. In addition, it is possible to specify the issue, valid from and expiry dates by using dcterms:issued, wdr:validFrom and wdr:validUntil respectively.
    /// <see href="http://www.w3.org/2007/05/powder#DR"></see></summary>
    let DR = Namespaced_IRI.parse _namespace_name "DR" |> NamespacedName
    /// <summary>
    /// This property links a Description Resource to the set of resources to which it applies. It MUST be included in Description Resources.
    /// <see href="http://www.w3.org/2007/05/powder#hasScope"></see></summary>
    let hasScope = Namespaced_IRI.parse _namespace_name "hasScope" |> NamespacedName

    /// <summary>
    /// This property links a Description Resource to a Descriptors class. It MUST be included in Description Resources.
    /// <see href="http://www.w3.org/2007/05/powder#hasDescriptors"></see></summary>
    let hasDescriptors =
        Namespaced_IRI.parse _namespace_name "hasDescriptors" |> NamespacedName

    /// <summary>
    /// This property denotes the date from which a Description Resource is valid. It may post-date the DR's issue date.
    /// <see href="http://www.w3.org/2007/05/powder#validFrom"></see></summary>
    let validFrom = Namespaced_IRI.parse _namespace_name "validFrom" |> NamespacedName
    /// <summary>
    /// This property denotes the expiry date of a Description Resource.
    /// <see href="http://www.w3.org/2007/05/powder#validUntil"></see></summary>
    let validUntil = Namespaced_IRI.parse _namespace_name "validUntil" |> NamespacedName

    /// <summary>
    /// This class denotes a collection of descriptors that can be specified using RDF/OWL properties defined in any vocabulary. The important difference between this class and rdf:Description is that the properties of the wdr:Descriptors class describe the resources in a Resource Set, not the Description Resource.
    /// <see href="http://www.w3.org/2007/05/powder#Descriptors"></see></summary>
    let Descriptors =
        Namespaced_IRI.parse _namespace_name "Descriptors" |> NamespacedName

    /// <summary>
    /// This class denotes either permanent or temporary HTTP redirection, corresponding to HTTP response codes 301, 302, 303, and 307.
    /// <see href="http://www.w3.org/2007/05/powder#HttpAnyRedirect"></see></summary>
    let HttpAnyRedirect =
        Namespaced_IRI.parse _namespace_name "HttpAnyRedirect" |> NamespacedName

    /// <summary>
    /// This class denotes HTTP redirection, corresponding to HTTP response codes 3xx. It MUST NOT be used directly in a Resource Set definition but is useful in defining cardinality constraints on its sub properties.
    /// <see href="http://www.w3.org/2007/05/powder#HttpRedirect"></see></summary>
    let HttpRedirect =
        Namespaced_IRI.parse _namespace_name "HttpRedirect" |> NamespacedName

    /// <summary>
    /// This class denotes permanent HTTP redirection, corresponding to HTTP response code 301.
    /// <see href="http://www.w3.org/2007/05/powder#HttpPermRedirect"></see></summary>
    let HttpPermRedirect =
        Namespaced_IRI.parse _namespace_name "HttpPermRedirect" |> NamespacedName

    /// <summary>
    /// This class denotes temporary HTTP redirection, corresponding to HTTP response codes 302, 303, and 307.
    /// <see href="http://www.w3.org/2007/05/powder#HttpTempRedirect"></see></summary>
    let HttpTempRedirect =
        Namespaced_IRI.parse _namespace_name "HttpTempRedirect" |> NamespacedName

    /// <summary>
    /// This class denotes an ordered, closed collection of Description Resources. A package describes a Resource Set that is the union of the Resource Sets of the DRs within it.
    /// <see href="http://www.w3.org/2007/05/powder#Package"></see></summary>
    let Package = Namespaced_IRI.parse _namespace_name "Package" |> NamespacedName
    /// <summary>
    /// This property provides a processing hint about the resources described by the DRs in a Package. As with includeHosts and excludeHosts, the datatype of its range is a white space separated list of URI hosts.
    /// <see href="http://www.w3.org/2007/05/powder#aboutHosts"></see></summary>
    let aboutHosts = Namespaced_IRI.parse _namespace_name "aboutHosts" |> NamespacedName
    /// <summary>
    /// This property denotes an ordered collection of Description Resources in a Package in which it MUST be present.
    /// <see href="http://www.w3.org/2007/05/powder#hasDRs"></see></summary>
    let hasDRs = Namespaced_IRI.parse _namespace_name "hasDRs" |> NamespacedName
    /// <summary>
    /// This class denotes the characteristics of a set of resources and the method to be used to discover them.
    /// <see href="http://www.w3.org/2007/05/powder#PropLookUp"></see></summary>
    let PropLookUp = Namespaced_IRI.parse _namespace_name "PropLookUp" |> NamespacedName
    /// <summary>
    /// This property specifies the URI to be resolved in order to discover the characteristics of a candidate resource. It takes a single 'template URI' that will include, or may comprise, the specific string {cURI}. This is to be substituted by the candidate resource's URI before resolution.
    /// <see href="http://www.w3.org/2007/05/powder#lookUpURI"></see></summary>
    let lookUpURI = Namespaced_IRI.parse _namespace_name "lookUpURI" |> NamespacedName
    /// <summary>
    /// This property specifies the HTTP method to be used in order to send a request to the lookup service.
    /// <see href="http://www.w3.org/2007/05/powder#httpMethod"></see></summary>
    let httpMethod = Namespaced_IRI.parse _namespace_name "httpMethod" |> NamespacedName

    /// <summary>
    /// This property denotes the response provided by a lookup service about the characteristics of a resource. It MUST NOT be used directly in a Resource Set definition but is useful in defining cardinality constraints on its sub properties.
    /// <see href="http://www.w3.org/2007/05/powder#responseRestriction"></see></summary>
    let responseRestriction =
        Namespaced_IRI.parse _namespace_name "responseRestriction" |> NamespacedName

    /// <summary>
    /// This property defines a set of resources for which the response from the given look up URI exactly matches at least one of the values given in a white space separated list, that is to be included when interpreting a Resource Set definition.
    /// <see href="http://www.w3.org/2007/05/powder#includeExactResponses"></see></summary>
    let includeExactResponses =
        Namespaced_IRI.parse _namespace_name "includeExactResponses" |> NamespacedName

    /// <summary>
    /// This class denotes a set of resources in terms of their address and/or characteristics. It is a potentially complex class and is therefore the subject of its own Recommendation (http://www.w3.org/TR/powder-grouping/)
    /// <see href="http://www.w3.org/2007/05/powder#ResourceSet"></see></summary>
    let ResourceSet =
        Namespaced_IRI.parse _namespace_name "ResourceSet" |> NamespacedName

    /// <summary>
    /// This property defines a set of one or more resources, identified by a white space separated list of their URIs, that are to be included in a Resource Set.
    /// <see href="http://www.w3.org/2007/05/powder#includeResources"></see></summary>
    let includeResources =
        Namespaced_IRI.parse _namespace_name "includeResources" |> NamespacedName

    /// <summary>
    /// This property defines a set of resources that have a URI scheme component matching at least one of the values given in a white space separated list, that is to be included when interpreting a Resource Set definition.
    /// <see href="http://www.w3.org/2007/05/powder#includeSchemes"></see></summary>
    let includeSchemes =
        Namespaced_IRI.parse _namespace_name "includeSchemes" |> NamespacedName

    /// <summary>
    /// This property defines a set of resources that have a URI userinfo component matching at least one of the values given in a white space separated list, that is to be included when interpreting a Resource Set definition.
    /// <see href="http://www.w3.org/2007/05/powder#includeUsers"></see></summary>
    let includeUsers =
        Namespaced_IRI.parse _namespace_name "includeUsers" |> NamespacedName

    /// <summary>
    /// This property defines a set of resources that have a URI host component matching at least one of the values given in a white space separated list, that is to be included when interpreting a Resource Set definition.
    /// <see href="http://www.w3.org/2007/05/powder#includeHosts"></see></summary>
    let includeHosts =
        Namespaced_IRI.parse _namespace_name "includeHosts" |> NamespacedName

    /// <summary>
    /// This property denotes a set of resources in terms of a list of URI ports or port ranges. It MUST NOT be used directly in a Resource Set definition but is useful in defining cardinality constraints on its sub properties.
    /// <see href="http://www.w3.org/2007/05/powder#portRestriction"></see></summary>
    let portRestriction =
        Namespaced_IRI.parse _namespace_name "portRestriction" |> NamespacedName

    /// <summary>
    /// This property defines a set of resources that have a URI path component exactly matching at least one of the values given in a white space separated list, that is to be included when interpreting a Resource Set definition.
    /// <see href="http://www.w3.org/2007/05/powder#includeExactPaths"></see></summary>
    let includeExactPaths =
        Namespaced_IRI.parse _namespace_name "includeExactPaths" |> NamespacedName

    /// <summary>
    /// This property defines a set of resources that have a URI path component starting with at least one of the values given in a white space separated list, that is to be included when interpreting a Resource Set definition.
    /// <see href="http://www.w3.org/2007/05/powder#includePathStartsWith"></see></summary>
    let includePathStartsWith =
        Namespaced_IRI.parse _namespace_name "includePathStartsWith" |> NamespacedName

    /// <summary>
    /// This property defines a set of resources that have a URI path component ending with at least one of the values given in a white space separated list, that is to be included when interpreting a Resource Set definition.
    /// <see href="http://www.w3.org/2007/05/powder#includePathEndsWith"></see></summary>
    let includePathEndsWith =
        Namespaced_IRI.parse _namespace_name "includePathEndsWith" |> NamespacedName

    /// <summary>
    /// This property defines a set of resources that have a URI query component exactly matching at least one of the values given in a white space separated list, that is to be included when interpreting a Resource Set definition.
    /// <see href="http://www.w3.org/2007/05/powder#includeExactQueries"></see></summary>
    let includeExactQueries =
        Namespaced_IRI.parse _namespace_name "includeExactQueries" |> NamespacedName

    /// <summary>
    /// This property defines a set of resources that have a URI fragment component matching at least one of the values given in a white space separated list, that is to be included when interpreting a Resource Set definition.
    /// <see href="http://www.w3.org/2007/05/powder#includeFragments"></see></summary>
    let includeFragments =
        Namespaced_IRI.parse _namespace_name "includeFragments" |> NamespacedName

    /// <summary>
    /// This property defines a set of resources, by means of a Regular Expression match against their URIs, that is to be included when interpreting a Resource Set definition.
    /// <see href="http://www.w3.org/2007/05/powder#includeUriRegEx"></see></summary>
    let includeUriRegEx =
        Namespaced_IRI.parse _namespace_name "includeUriRegEx" |> NamespacedName

    /// <summary>
    /// This property denotes a set of resources in terms of a set of IP addresses or IP ranges. It MUST NOT be used directly in a Resource Set definition but is useful in defining cardinality constraints on its sub properties.
    /// <see href="http://www.w3.org/2007/05/powder#ipRestriction"></see></summary>
    let ipRestriction =
        Namespaced_IRI.parse _namespace_name "ipRestriction" |> NamespacedName

    /// <summary>
    /// This property determines whether HTTP-redirected resource are to be included in the Resource Set. Its value can indicate that temporary, permanent or any redirection is allowable.
    /// <see href="http://www.w3.org/2007/05/powder#includeRedirection"></see></summary>
    let includeRedirection =
        Namespaced_IRI.parse _namespace_name "includeRedirection" |> NamespacedName

    /// <summary>
    /// This property denotes a set of resources in terms of their address or characteristics. It MUST NOT be used directly in a Resource Set definition but is useful in defining cardinality constraints on its sub properties.
    /// <see href="http://www.w3.org/2007/05/powder#setDefinition"></see></summary>
    let setDefinition =
        Namespaced_IRI.parse _namespace_name "setDefinition" |> NamespacedName

    /// <summary>
    /// This property denotes a set of resources in terms of their addresses. It MUST NOT be used directly in a Resource Set definition but is useful in defining cardinality constraints on its sub properties.
    /// <see href="http://www.w3.org/2007/05/powder#addressRestriction"></see></summary>
    let addressRestriction =
        Namespaced_IRI.parse _namespace_name "addressRestriction" |> NamespacedName

    /// <summary>
    /// This property links a DR to a certificate that refers back to the DR. The certificate may in any format.
    /// <see href="http://www.w3.org/2007/05/powder#certifiedBy"></see></summary>
    let certifiedBy =
        Namespaced_IRI.parse _namespace_name "certifiedBy" |> NamespacedName

    /// <summary>
    /// This property can point from any resource to a DR or a DR Package which should include the resource that pointed to it in its scope.
    /// <see href="http://www.w3.org/2007/05/powder#describedBy"></see></summary>
    let describedBy =
        Namespaced_IRI.parse _namespace_name "describedBy" |> NamespacedName

    /// <summary>
    /// This property links a foaf:Agent class (used to give details of a DR's creator) to a resource that provides information about of how DRs attributed to that creator may be authenticated.
    /// <see href="http://www.w3.org/2007/05/powder#drAuthenticate"></see></summary>
    let drAuthenticate =
        Namespaced_IRI.parse _namespace_name "drAuthenticate" |> NamespacedName

    /// <summary>
    /// This property links to an RDF resource that in some way conveys the essential characteristics of resources that are elements of a set. Such a set may then be excluded when interpreting a Resource Set definition.
    /// <see href="http://www.w3.org/2007/05/powder#excludeConditional"></see></summary>
    let excludeConditional =
        Namespaced_IRI.parse _namespace_name "excludeConditional" |> NamespacedName

    /// <summary>
    /// This property denotes a set of resources in terms of their characteristics. It MUST NOT be used directly in a Resource Set definition but is useful in defining cardinality constraints on its sub properties.
    /// <see href="http://www.w3.org/2007/05/powder#propertyRestriction"></see></summary>
    let propertyRestriction =
        Namespaced_IRI.parse _namespace_name "propertyRestriction" |> NamespacedName

    /// <summary>
    /// This property defines a set of resources that have a URI path component exactly matching at least one of the values given in a white space separated list, that is to be excluded when interpreting a Resource Set definition.
    /// <see href="http://www.w3.org/2007/05/powder#excludeExactPaths"></see></summary>
    let excludeExactPaths =
        Namespaced_IRI.parse _namespace_name "excludeExactPaths" |> NamespacedName

    /// <summary>
    /// This property defines a set of resources that have a URI query component exactly matching at least one of the values given in a white space separated list, that is to be excluded when interpreting a Resource Set definition.
    /// <see href="http://www.w3.org/2007/05/powder#excludeExactQueries"></see></summary>
    let excludeExactQueries =
        Namespaced_IRI.parse _namespace_name "excludeExactQueries" |> NamespacedName

    /// <summary>
    /// This property defines a set of resources for which the response from the given look up URI exactly matches at least one of the values given in a white space separated list, that is to be excluded when interpreting a Resource Set definition.
    /// <see href="http://www.w3.org/2007/05/powder#excludeExactResponses"></see></summary>
    let excludeExactResponses =
        Namespaced_IRI.parse _namespace_name "excludeExactResponses" |> NamespacedName

    /// <summary>
    /// This property defines a set of resources that have a URI fragment component matching at least one of the values given in a white space separated list, that is to be excluded when interpreting a Resource Set definition.
    /// <see href="http://www.w3.org/2007/05/powder#excludeFragments"></see></summary>
    let excludeFragments =
        Namespaced_IRI.parse _namespace_name "excludeFragments" |> NamespacedName

    /// <summary>
    /// This property defines a set of resources that have a URI host component matching at least one of the values given in a white space separated list, that is to be excluded when interpreting a Resource Set definition.
    /// <see href="http://www.w3.org/2007/05/powder#excludeHosts"></see></summary>
    let excludeHosts =
        Namespaced_IRI.parse _namespace_name "excludeHosts" |> NamespacedName

    /// <summary>
    /// This property defines a set of resources that have an IP address matching at least one of the values given in a white space separated list, that is to be excluded when interpreting a Resource Set definition.
    /// <see href="http://www.w3.org/2007/05/powder#excludeIPs"></see></summary>
    let excludeIPs = Namespaced_IRI.parse _namespace_name "excludeIPs" |> NamespacedName

    /// <summary>
    /// This property defines a set of resources that have an IP address within at least one of the ranges given in a white space separated list of CIDR blocks, that is to be excluded when interpreting a Resource Set definition.
    /// <see href="http://www.w3.org/2007/05/powder#excludeIpRanges"></see></summary>
    let excludeIpRanges =
        Namespaced_IRI.parse _namespace_name "excludeIpRanges" |> NamespacedName

    /// <summary>
    /// This property defines a set of resources that have a URI path component containing at least one of the values given in a white space separated list, that is to be excluded when interpreting a Resource Set definition.
    /// <see href="http://www.w3.org/2007/05/powder#excludePathContains"></see></summary>
    let excludePathContains =
        Namespaced_IRI.parse _namespace_name "excludePathContains" |> NamespacedName

    /// <summary>
    /// This property defines a set of resources that have a URI path component ending with at least one of the values given in a white space separated list, that is to be excluded when interpreting a Resource Set definition.
    /// <see href="http://www.w3.org/2007/05/powder#excludePathEndsWith"></see></summary>
    let excludePathEndsWith =
        Namespaced_IRI.parse _namespace_name "excludePathEndsWith" |> NamespacedName

    /// <summary>
    /// This property defines a set of resources that have a URI path component starting with at least one of the values given in a white space separated list, that is to be excluded when interpreting a Resource Set definition.
    /// <see href="http://www.w3.org/2007/05/powder#excludePathStartsWith"></see></summary>
    let excludePathStartsWith =
        Namespaced_IRI.parse _namespace_name "excludePathStartsWith" |> NamespacedName

    /// <summary>
    /// This property defines a set of resources that have a URI port component within at least one of the ranges given in a white space separated list, that is to be excluded when interpreting a Resource Set definition.
    /// <see href="http://www.w3.org/2007/05/powder#excludePortRanges"></see></summary>
    let excludePortRanges =
        Namespaced_IRI.parse _namespace_name "excludePortRanges" |> NamespacedName

    /// <summary>
    /// This property defines a set of resources that have a URI port component matching at least one of the values given in a white space separated list, that is to be excluded when interpreting a Resource Set definition.
    /// <see href="http://www.w3.org/2007/05/powder#excludePorts"></see></summary>
    let excludePorts =
        Namespaced_IRI.parse _namespace_name "excludePorts" |> NamespacedName

    /// <summary>
    /// This property defines a set of resources that have a URI query component containing at least one of the values given in a white space separated list, that is to be excluded when interpreting a Resource Set definition.
    /// <see href="http://www.w3.org/2007/05/powder#excludeQueryContains"></see></summary>
    let excludeQueryContains =
        Namespaced_IRI.parse _namespace_name "excludeQueryContains" |> NamespacedName

    /// <summary>
    /// This property defines a set of one or more resources, identified by a white space separated list of their URIs, that are to be excluded from a Resource Set.
    /// <see href="http://www.w3.org/2007/05/powder#excludeResources"></see></summary>
    let excludeResources =
        Namespaced_IRI.parse _namespace_name "excludeResources" |> NamespacedName

    /// <summary>
    /// This property defines a set of resources for which the response from the given look up URI contains at least one of the values given in a white space separated list, that is to be excluded when interpreting a Resource Set definition.
    /// <see href="http://www.w3.org/2007/05/powder#excludeResponseContains"></see></summary>
    let excludeResponseContains =
        Namespaced_IRI.parse _namespace_name "excludeResponseContains" |> NamespacedName

    /// <summary>
    /// This property defines a set of resources that have a URI scheme component matching at least one of the values given in a white space separated list, that is to be excluded when interpreting a Resource Set definition.
    /// <see href="http://www.w3.org/2007/05/powder#excludeSchemes"></see></summary>
    let excludeSchemes =
        Namespaced_IRI.parse _namespace_name "excludeSchemes" |> NamespacedName

    /// <summary>
    /// This property defines a set of resources, by means of white space separated list of URI-like strings that include wildcards, that is to be excluded when interpreting a Resource Set definition.
    /// <see href="http://www.w3.org/2007/05/powder#excludeUriPattern"></see></summary>
    let excludeUriPattern =
        Namespaced_IRI.parse _namespace_name "excludeUriPattern" |> NamespacedName

    /// <summary>
    /// This property defines a set of resources, by means of a Regular Expression match against their URIs, that is to be excluded when interpreting a Resource Set definition.
    /// <see href="http://www.w3.org/2007/05/powder#excludeUriRegEx"></see></summary>
    let excludeUriRegEx =
        Namespaced_IRI.parse _namespace_name "excludeUriRegEx" |> NamespacedName

    /// <summary>
    /// This property defines a set of resources that have a URI userinfo component matching at least one of the values given in a white space separated list, that is to be excluded when interpreting a Resource Set definition.
    /// <see href="http://www.w3.org/2007/05/powder#excludeUsers"></see></summary>
    let excludeUsers =
        Namespaced_IRI.parse _namespace_name "excludeUsers" |> NamespacedName

    /// <summary>
    /// This property links to an RDF resource that in some way conveys the essential characteristics of resources that are elements of a set. Such a set may then be included when interpreting a Resource Set definition.
    /// <see href="http://www.w3.org/2007/05/powder#includeConditional"></see></summary>
    let includeConditional =
        Namespaced_IRI.parse _namespace_name "includeConditional" |> NamespacedName

    /// <summary>
    /// This property defines a set of resources that have an IP address matching at least one of the values given in a white space separated list, that is to be included when interpreting a Resource Set definition.
    /// <see href="http://www.w3.org/2007/05/powder#includeIPs"></see></summary>
    let includeIPs = Namespaced_IRI.parse _namespace_name "includeIPs" |> NamespacedName

    /// <summary>
    /// This property defines a set of resources that have an IP address within at least one of the ranges given in a white space separated list of CIDR blocks, that is to be included when interpreting a Resource Set definition.
    /// <see href="http://www.w3.org/2007/05/powder#includeIpRanges"></see></summary>
    let includeIpRanges =
        Namespaced_IRI.parse _namespace_name "includeIpRanges" |> NamespacedName

    /// <summary>
    /// This property defines a set of resources that have a URI path component containing at least one of the values given in a white space separated list, that is to be included when interpreting a Resource Set definition.
    /// <see href="http://www.w3.org/2007/05/powder#includePathContains"></see></summary>
    let includePathContains =
        Namespaced_IRI.parse _namespace_name "includePathContains" |> NamespacedName

    /// <summary>
    /// This property defines a set of resources that have a URI port component within at least one of the ranges given in a white space separated list, that is to be included when interpreting a Resource Set definition.
    /// <see href="http://www.w3.org/2007/05/powder#includePortRanges"></see></summary>
    let includePortRanges =
        Namespaced_IRI.parse _namespace_name "includePortRanges" |> NamespacedName

    /// <summary>
    /// This property defines a set of resources that have a URI port component matching at least one of the values given in a white space separated list, that is to be included when interpreting a Resource Set definition.
    /// <see href="http://www.w3.org/2007/05/powder#includePorts"></see></summary>
    let includePorts =
        Namespaced_IRI.parse _namespace_name "includePorts" |> NamespacedName

    /// <summary>
    /// This property defines a set of resources that have a URI query component containing at least one of the values given in a white space separated list, that is to be included when interpreting a Resource Set definition.
    /// <see href="http://www.w3.org/2007/05/powder#includeQueryContains"></see></summary>
    let includeQueryContains =
        Namespaced_IRI.parse _namespace_name "includeQueryContains" |> NamespacedName

    /// <summary>
    /// This property defines a set of resources for which the response from the given look up URI contains at least one of the values given in a white space separated list, that is to be included when interpreting a Resource Set definition.
    /// <see href="http://www.w3.org/2007/05/powder#includeResponseContains"></see></summary>
    let includeResponseContains =
        Namespaced_IRI.parse _namespace_name "includeResponseContains" |> NamespacedName

    /// <summary>
    /// This property defines a set of resources, by means of white space separated list of URI-like strings that include wildcards, that is to be included when interpreting a Resource Set definition.
    /// <see href="http://www.w3.org/2007/05/powder#includeUriPattern"></see></summary>
    let includeUriPattern =
        Namespaced_IRI.parse _namespace_name "includeUriPattern" |> NamespacedName

    /// <summary>
    /// This property links from any kind of descriptive resource to a wdr:Descriptors class that is semantically equivalent.
    /// <see href="http://www.w3.org/2007/05/powder#mapsTo"></see></summary>
    let mapsTo = Namespaced_IRI.parse _namespace_name "mapsTo" |> NamespacedName

    /// <summary>
    /// This property links a DR to another data source that supports, i.e. agrees with, the claims and assertions made in the DR. The supporting evidence may in any format.
    /// <see href="http://www.w3.org/2007/05/powder#supportedBy"></see></summary>
    let supportedBy =
        Namespaced_IRI.parse _namespace_name "supportedBy" |> NamespacedName

    /// <summary>
    /// This property links a Description Resource to a Property Lookup Class.
    /// <see href="http://www.w3.org/2007/05/powder#usePropLookUp"></see></summary>
    let usePropLookUp =
        Namespaced_IRI.parse _namespace_name "usePropLookUp" |> NamespacedName
