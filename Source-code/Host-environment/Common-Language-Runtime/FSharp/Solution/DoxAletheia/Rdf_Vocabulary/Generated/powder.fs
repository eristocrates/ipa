namespace http.www.w3.org._2007._05.powder.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module powder =
    let _namespace_iri = Namespace_Iri powder |> NamespaceIRI
    /// <summary>
    ///   <para>powder:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///   <para>"The Web Description Resources (WDR) vocabulary defines a set of classes and properties to be used in order to specify a description of set of resources, and the author responsible of such description."</para>
    /// labels<para>"Protocol for Web Description Resources (POWDER): Web Description Resources (WDR) Vocabulary"</para></remarks>
    /// <seealso href="http://www.w3.org/2007/05/powder#">http://www.w3.org/2007/05/powder#</seealso>
    let _prefix_iri = Prefixed_Name(powder, "") |> PrefixedName
    /// <summary>
    ///   <para>powder:DR</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class denotes a description, the set of resources to which it applies (the DR scope), and the author who created it. Its three components correspond, respectively, to classes wdr:Descriptors, wdr:ResourceSet, and to foaf:agent which is linked by the property foaf:maker. In addition, it is possible to specify the issue, valid from and expiry dates by using dcterms:issued, wdr:validFrom and wdr:validUntil respectively."</para>
    /// labels<para>"Description Resource"</para></remarks>
    /// <seealso href="http://www.w3.org/2007/05/powder#DR">http://www.w3.org/2007/05/powder#DR</seealso>
    let DR = Prefixed_Name(powder, "DR") |> PrefixedName
    /// <summary>
    ///   <para>powder:Descriptors</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class denotes a collection of descriptors that can be specified using RDF/OWL properties defined in any vocabulary. The important difference between this class and rdf:Description is that the properties of the wdr:Descriptors class describe the resources in a Resource Set, not the Description Resource."</para>
    /// labels<para>"Descriptors"</para></remarks>
    /// <seealso href="http://www.w3.org/2007/05/powder#Descriptors">http://www.w3.org/2007/05/powder#Descriptors</seealso>
    let Descriptors = Prefixed_Name(powder, "Descriptors") |> PrefixedName
    /// <summary>
    ///   <para>powder:HttpAnyRedirect</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class denotes either permanent or temporary HTTP redirection, corresponding to HTTP response codes 301, 302, 303, and 307."</para>
    /// labels<para>"HTTP Permanent or Temporary Redirection"</para></remarks>
    /// <seealso href="http://www.w3.org/2007/05/powder#HttpAnyRedirect">http://www.w3.org/2007/05/powder#HttpAnyRedirect</seealso>
    let HttpAnyRedirect = Prefixed_Name(powder, "HttpAnyRedirect") |> PrefixedName
    /// <summary>
    ///   <para>powder:HttpPermRedirect</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class denotes permanent HTTP redirection, corresponding to HTTP response code 301."</para>
    /// labels<para>"HTTP Permanent Redirection"</para></remarks>
    /// <seealso href="http://www.w3.org/2007/05/powder#HttpPermRedirect">http://www.w3.org/2007/05/powder#HttpPermRedirect</seealso>
    let HttpPermRedirect = Prefixed_Name(powder, "HttpPermRedirect") |> PrefixedName
    /// <summary>
    ///   <para>powder:HttpRedirect</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class denotes HTTP redirection, corresponding to HTTP response codes 3xx. It MUST NOT be used directly in a Resource Set definition but is useful in defining cardinality constraints on its sub properties."</para>
    /// labels<para>"HTTP Redirection"</para></remarks>
    /// <seealso href="http://www.w3.org/2007/05/powder#HttpRedirect">http://www.w3.org/2007/05/powder#HttpRedirect</seealso>
    let HttpRedirect = Prefixed_Name(powder, "HttpRedirect") |> PrefixedName
    /// <summary>
    ///   <para>powder:HttpTempRedirect</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class denotes temporary HTTP redirection, corresponding to HTTP response codes 302, 303, and 307."</para>
    /// labels<para>"HTTP Temporary Redirection"</para></remarks>
    /// <seealso href="http://www.w3.org/2007/05/powder#HttpTempRedirect">http://www.w3.org/2007/05/powder#HttpTempRedirect</seealso>
    let HttpTempRedirect = Prefixed_Name(powder, "HttpTempRedirect") |> PrefixedName
    /// <summary>
    ///   <para>powder:Package</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class denotes an ordered, closed collection of Description Resources. A package describes a Resource Set that is the union of the Resource Sets of the DRs within it."</para>
    /// labels<para>"Description Resource Package"</para></remarks>
    /// <seealso href="http://www.w3.org/2007/05/powder#Package">http://www.w3.org/2007/05/powder#Package</seealso>
    let Package = Prefixed_Name(powder, "Package") |> PrefixedName
    /// <summary>
    ///   <para>powder:PropLookUp</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class denotes the characteristics of a set of resources and the method to be used to discover them."</para>
    /// labels<para>"Property Lookup"</para></remarks>
    /// <seealso href="http://www.w3.org/2007/05/powder#PropLookUp">http://www.w3.org/2007/05/powder#PropLookUp</seealso>
    let PropLookUp = Prefixed_Name(powder, "PropLookUp") |> PrefixedName
    /// <summary>
    ///   <para>powder:ResourceSet</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class denotes a set of resources in terms of their address and/or characteristics. It is a potentially complex class and is therefore the subject of its own Recommendation (http://www.w3.org/TR/powder-grouping/)"</para>
    /// labels<para>"Resource Set"</para></remarks>
    /// <seealso href="http://www.w3.org/2007/05/powder#ResourceSet">http://www.w3.org/2007/05/powder#ResourceSet</seealso>
    let ResourceSet = Prefixed_Name(powder, "ResourceSet") |> PrefixedName
    /// <summary>
    ///   <para>powder:aboutHosts</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"This property provides a processing hint about the resources described by the DRs in a Package. As with includeHosts and excludeHosts, the datatype of its range is a white space separated list of URI hosts."</para>
    /// labels<para>"about hosts"</para></remarks>
    /// <seealso href="http://www.w3.org/2007/05/powder#aboutHosts">http://www.w3.org/2007/05/powder#aboutHosts</seealso>
    let aboutHosts = Prefixed_Name(powder, "aboutHosts") |> PrefixedName
    /// <summary>
    ///   <para>powder:addressRestriction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"This property denotes a set of resources in terms of their addresses. It MUST NOT be used directly in a Resource Set definition but is useful in defining cardinality constraints on its sub properties."</para>
    /// labels<para>"address restriction"</para></remarks>
    /// <seealso href="http://www.w3.org/2007/05/powder#addressRestriction">http://www.w3.org/2007/05/powder#addressRestriction</seealso>
    let addressRestriction = Prefixed_Name(powder, "addressRestriction") |> PrefixedName
    /// <summary>
    ///   <para>powder:certifiedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"This property links a DR to a certificate that refers back to the DR. The certificate may in any format."</para>
    /// labels<para>"certified by"</para></remarks>
    /// <seealso href="http://www.w3.org/2007/05/powder#certifiedBy">http://www.w3.org/2007/05/powder#certifiedBy</seealso>
    let certifiedBy = Prefixed_Name(powder, "certifiedBy") |> PrefixedName
    /// <summary>
    ///   <para>powder:describedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property can point from any resource to a DR or a DR Package which should include the resource that pointed to it in its scope."</para>
    /// labels<para>"described by"</para></remarks>
    /// <seealso href="http://www.w3.org/2007/05/powder#describedBy">http://www.w3.org/2007/05/powder#describedBy</seealso>
    let describedBy = Prefixed_Name(powder, "describedBy") |> PrefixedName
    /// <summary>
    ///   <para>powder:drAuthenticate</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"This property links a foaf:Agent class (used to give details of a DR's creator) to a resource that provides information about of how DRs attributed to that creator may be authenticated."</para>
    /// labels<para>"DR authenticate"</para></remarks>
    /// <seealso href="http://www.w3.org/2007/05/powder#drAuthenticate">http://www.w3.org/2007/05/powder#drAuthenticate</seealso>
    let drAuthenticate = Prefixed_Name(powder, "drAuthenticate") |> PrefixedName
    /// <summary>
    ///   <para>powder:excludeConditional</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property links to an RDF resource that in some way conveys the essential characteristics of resources that are elements of a set. Such a set may then be excluded when interpreting a Resource Set definition."</para>
    /// labels<para>"exclude conditional"</para></remarks>
    /// <seealso href="http://www.w3.org/2007/05/powder#excludeConditional">http://www.w3.org/2007/05/powder#excludeConditional</seealso>
    let excludeConditional = Prefixed_Name(powder, "excludeConditional") |> PrefixedName
    /// <summary>
    ///   <para>powder:excludeExactPaths</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"This property defines a set of resources that have a URI path component exactly matching at least one of the values given in a white space separated list, that is to be excluded when interpreting a Resource Set definition."</para>
    /// labels<para>"exclude exact paths"</para></remarks>
    /// <seealso href="http://www.w3.org/2007/05/powder#excludeExactPaths">http://www.w3.org/2007/05/powder#excludeExactPaths</seealso>
    let excludeExactPaths = Prefixed_Name(powder, "excludeExactPaths") |> PrefixedName

    /// <summary>
    ///   <para>powder:excludeExactQueries</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"This property defines a set of resources that have a URI query component exactly matching at least one of the values given in a white space separated list, that is to be excluded when interpreting a Resource Set definition."</para>
    /// labels<para>"exclude exact queries"</para></remarks>
    /// <seealso href="http://www.w3.org/2007/05/powder#excludeExactQueries">http://www.w3.org/2007/05/powder#excludeExactQueries</seealso>
    let excludeExactQueries =
        Prefixed_Name(powder, "excludeExactQueries") |> PrefixedName

    /// <summary>
    ///   <para>powder:excludeExactResponses</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"This property defines a set of resources for which the response from the given look up URI exactly matches at least one of the values given in a white space separated list, that is to be excluded when interpreting a Resource Set definition."</para>
    /// labels<para>"exclude exact responses"</para></remarks>
    /// <seealso href="http://www.w3.org/2007/05/powder#excludeExactResponses">http://www.w3.org/2007/05/powder#excludeExactResponses</seealso>
    let excludeExactResponses =
        Prefixed_Name(powder, "excludeExactResponses") |> PrefixedName

    /// <summary>
    ///   <para>powder:excludeFragments</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"This property defines a set of resources that have a URI fragment component matching at least one of the values given in a white space separated list, that is to be excluded when interpreting a Resource Set definition."</para>
    /// labels<para>"exclude fragments"</para></remarks>
    /// <seealso href="http://www.w3.org/2007/05/powder#excludeFragments">http://www.w3.org/2007/05/powder#excludeFragments</seealso>
    let excludeFragments = Prefixed_Name(powder, "excludeFragments") |> PrefixedName
    /// <summary>
    ///   <para>powder:excludeHosts</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"This property defines a set of resources that have a URI host component matching at least one of the values given in a white space separated list, that is to be excluded when interpreting a Resource Set definition."</para>
    /// labels<para>"exclude hosts"</para></remarks>
    /// <seealso href="http://www.w3.org/2007/05/powder#excludeHosts">http://www.w3.org/2007/05/powder#excludeHosts</seealso>
    let excludeHosts = Prefixed_Name(powder, "excludeHosts") |> PrefixedName
    /// <summary>
    ///   <para>powder:excludeIPs</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"This property defines a set of resources that have an IP address matching at least one of the values given in a white space separated list, that is to be excluded when interpreting a Resource Set definition."</para>
    /// labels<para>"exclude IPs"</para></remarks>
    /// <seealso href="http://www.w3.org/2007/05/powder#excludeIPs">http://www.w3.org/2007/05/powder#excludeIPs</seealso>
    let excludeIPs = Prefixed_Name(powder, "excludeIPs") |> PrefixedName
    /// <summary>
    ///   <para>powder:excludeIpRanges</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"This property defines a set of resources that have an IP address within at least one of the ranges given in a white space separated list of CIDR blocks, that is to be excluded when interpreting a Resource Set definition."</para>
    /// labels<para>"exclude IP ranges"</para></remarks>
    /// <seealso href="http://www.w3.org/2007/05/powder#excludeIpRanges">http://www.w3.org/2007/05/powder#excludeIpRanges</seealso>
    let excludeIpRanges = Prefixed_Name(powder, "excludeIpRanges") |> PrefixedName

    /// <summary>
    ///   <para>powder:excludePathContains</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"This property defines a set of resources that have a URI path component containing at least one of the values given in a white space separated list, that is to be excluded when interpreting a Resource Set definition."</para>
    /// labels<para>"exclude path contains"</para></remarks>
    /// <seealso href="http://www.w3.org/2007/05/powder#excludePathContains">http://www.w3.org/2007/05/powder#excludePathContains</seealso>
    let excludePathContains =
        Prefixed_Name(powder, "excludePathContains") |> PrefixedName

    /// <summary>
    ///   <para>powder:excludePathEndsWith</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"This property defines a set of resources that have a URI path component ending with at least one of the values given in a white space separated list, that is to be excluded when interpreting a Resource Set definition."</para>
    /// labels<para>"exclude path ends with"</para></remarks>
    /// <seealso href="http://www.w3.org/2007/05/powder#excludePathEndsWith">http://www.w3.org/2007/05/powder#excludePathEndsWith</seealso>
    let excludePathEndsWith =
        Prefixed_Name(powder, "excludePathEndsWith") |> PrefixedName

    /// <summary>
    ///   <para>powder:excludePathStartsWith</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"This property defines a set of resources that have a URI path component starting with at least one of the values given in a white space separated list, that is to be excluded when interpreting a Resource Set definition."</para>
    /// labels<para>"exclude path starts with"</para></remarks>
    /// <seealso href="http://www.w3.org/2007/05/powder#excludePathStartsWith">http://www.w3.org/2007/05/powder#excludePathStartsWith</seealso>
    let excludePathStartsWith =
        Prefixed_Name(powder, "excludePathStartsWith") |> PrefixedName

    /// <summary>
    ///   <para>powder:excludePortRanges</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"This property defines a set of resources that have a URI port component within at least one of the ranges given in a white space separated list, that is to be excluded when interpreting a Resource Set definition."</para>
    /// labels<para>"exclude port ranges"</para></remarks>
    /// <seealso href="http://www.w3.org/2007/05/powder#excludePortRanges">http://www.w3.org/2007/05/powder#excludePortRanges</seealso>
    let excludePortRanges = Prefixed_Name(powder, "excludePortRanges") |> PrefixedName
    /// <summary>
    ///   <para>powder:excludePorts</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"This property defines a set of resources that have a URI port component matching at least one of the values given in a white space separated list, that is to be excluded when interpreting a Resource Set definition."</para>
    /// labels<para>"exclude ports"</para></remarks>
    /// <seealso href="http://www.w3.org/2007/05/powder#excludePorts">http://www.w3.org/2007/05/powder#excludePorts</seealso>
    let excludePorts = Prefixed_Name(powder, "excludePorts") |> PrefixedName

    /// <summary>
    ///   <para>powder:excludeQueryContains</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"This property defines a set of resources that have a URI query component containing at least one of the values given in a white space separated list, that is to be excluded when interpreting a Resource Set definition."</para>
    /// labels<para>"exclude query contains"</para></remarks>
    /// <seealso href="http://www.w3.org/2007/05/powder#excludeQueryContains">http://www.w3.org/2007/05/powder#excludeQueryContains</seealso>
    let excludeQueryContains =
        Prefixed_Name(powder, "excludeQueryContains") |> PrefixedName

    /// <summary>
    ///   <para>powder:excludeResources</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"This property defines a set of one or more resources, identified by a white space separated list of their URIs, that are to be excluded from a Resource Set."</para>
    /// labels<para>"exclude resources"</para></remarks>
    /// <seealso href="http://www.w3.org/2007/05/powder#excludeResources">http://www.w3.org/2007/05/powder#excludeResources</seealso>
    let excludeResources = Prefixed_Name(powder, "excludeResources") |> PrefixedName

    /// <summary>
    ///   <para>powder:excludeResponseContains</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"This property defines a set of resources for which the response from the given look up URI contains at least one of the values given in a white space separated list, that is to be excluded when interpreting a Resource Set definition."</para>
    /// labels<para>"exclude response contains"</para></remarks>
    /// <seealso href="http://www.w3.org/2007/05/powder#excludeResponseContains">http://www.w3.org/2007/05/powder#excludeResponseContains</seealso>
    let excludeResponseContains =
        Prefixed_Name(powder, "excludeResponseContains") |> PrefixedName

    /// <summary>
    ///   <para>powder:excludeSchemes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"This property defines a set of resources that have a URI scheme component matching at least one of the values given in a white space separated list, that is to be excluded when interpreting a Resource Set definition."</para>
    /// labels<para>"exclude schemes"</para></remarks>
    /// <seealso href="http://www.w3.org/2007/05/powder#excludeSchemes">http://www.w3.org/2007/05/powder#excludeSchemes</seealso>
    let excludeSchemes = Prefixed_Name(powder, "excludeSchemes") |> PrefixedName
    /// <summary>
    ///   <para>powder:excludeUriPattern</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"This property defines a set of resources, by means of white space separated list of URI-like strings that include wildcards, that is to be excluded when interpreting a Resource Set definition."</para>
    /// labels<para>"exclude URI pattern"</para></remarks>
    /// <seealso href="http://www.w3.org/2007/05/powder#excludeUriPattern">http://www.w3.org/2007/05/powder#excludeUriPattern</seealso>
    let excludeUriPattern = Prefixed_Name(powder, "excludeUriPattern") |> PrefixedName
    /// <summary>
    ///   <para>powder:excludeUriRegEx</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"This property defines a set of resources, by means of a Regular Expression match against their URIs, that is to be excluded when interpreting a Resource Set definition."</para>
    /// labels<para>"exclude URI pattern"</para></remarks>
    /// <seealso href="http://www.w3.org/2007/05/powder#excludeUriRegEx">http://www.w3.org/2007/05/powder#excludeUriRegEx</seealso>
    let excludeUriRegEx = Prefixed_Name(powder, "excludeUriRegEx") |> PrefixedName
    /// <summary>
    ///   <para>powder:excludeUsers</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"This property defines a set of resources that have a URI userinfo component matching at least one of the values given in a white space separated list, that is to be excluded when interpreting a Resource Set definition."</para>
    /// labels<para>"exclude user infos"</para></remarks>
    /// <seealso href="http://www.w3.org/2007/05/powder#excludeUsers">http://www.w3.org/2007/05/powder#excludeUsers</seealso>
    let excludeUsers = Prefixed_Name(powder, "excludeUsers") |> PrefixedName
    /// <summary>
    ///   <para>powder:hasDRs</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property denotes an ordered collection of Description Resources in a Package in which it MUST be present."</para>
    /// labels<para>"has Description Resources"</para></remarks>
    /// <seealso href="http://www.w3.org/2007/05/powder#hasDRs">http://www.w3.org/2007/05/powder#hasDRs</seealso>
    let hasDRs = Prefixed_Name(powder, "hasDRs") |> PrefixedName
    /// <summary>
    ///   <para>powder:hasDescriptors</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property links a Description Resource to a Descriptors class. It MUST be included in Description Resources."</para>
    /// labels<para>"has description"</para></remarks>
    /// <seealso href="http://www.w3.org/2007/05/powder#hasDescriptors">http://www.w3.org/2007/05/powder#hasDescriptors</seealso>
    let hasDescriptors = Prefixed_Name(powder, "hasDescriptors") |> PrefixedName
    /// <summary>
    ///   <para>powder:hasScope</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property links a Description Resource to the set of resources to which it applies. It MUST be included in Description Resources."</para>
    /// labels<para>"has scope"</para></remarks>
    /// <seealso href="http://www.w3.org/2007/05/powder#hasScope">http://www.w3.org/2007/05/powder#hasScope</seealso>
    let hasScope = Prefixed_Name(powder, "hasScope") |> PrefixedName
    /// <summary>
    ///   <para>powder:httpMethod</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property specifies the HTTP method to be used in order to send a request to the lookup service."</para>
    /// labels<para>"HTTP method"</para></remarks>
    /// <seealso href="http://www.w3.org/2007/05/powder#httpMethod">http://www.w3.org/2007/05/powder#httpMethod</seealso>
    let httpMethod = Prefixed_Name(powder, "httpMethod") |> PrefixedName
    /// <summary>
    ///   <para>powder:includeConditional</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property links to an RDF resource that in some way conveys the essential characteristics of resources that are elements of a set. Such a set may then be included when interpreting a Resource Set definition."</para>
    /// labels<para>"include conditional"</para></remarks>
    /// <seealso href="http://www.w3.org/2007/05/powder#includeConditional">http://www.w3.org/2007/05/powder#includeConditional</seealso>
    let includeConditional = Prefixed_Name(powder, "includeConditional") |> PrefixedName
    /// <summary>
    ///   <para>powder:includeExactPaths</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"This property defines a set of resources that have a URI path component exactly matching at least one of the values given in a white space separated list, that is to be included when interpreting a Resource Set definition."</para>
    /// labels<para>"include exact paths"</para></remarks>
    /// <seealso href="http://www.w3.org/2007/05/powder#includeExactPaths">http://www.w3.org/2007/05/powder#includeExactPaths</seealso>
    let includeExactPaths = Prefixed_Name(powder, "includeExactPaths") |> PrefixedName

    /// <summary>
    ///   <para>powder:includeExactQueries</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"This property defines a set of resources that have a URI query component exactly matching at least one of the values given in a white space separated list, that is to be included when interpreting a Resource Set definition."</para>
    /// labels<para>"include exact queries"</para></remarks>
    /// <seealso href="http://www.w3.org/2007/05/powder#includeExactQueries">http://www.w3.org/2007/05/powder#includeExactQueries</seealso>
    let includeExactQueries =
        Prefixed_Name(powder, "includeExactQueries") |> PrefixedName

    /// <summary>
    ///   <para>powder:includeExactResponses</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"This property defines a set of resources for which the response from the given look up URI exactly matches at least one of the values given in a white space separated list, that is to be included when interpreting a Resource Set definition."</para>
    /// labels<para>"include exact responses"</para></remarks>
    /// <seealso href="http://www.w3.org/2007/05/powder#includeExactResponses">http://www.w3.org/2007/05/powder#includeExactResponses</seealso>
    let includeExactResponses =
        Prefixed_Name(powder, "includeExactResponses") |> PrefixedName

    /// <summary>
    ///   <para>powder:includeFragments</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"This property defines a set of resources that have a URI fragment component matching at least one of the values given in a white space separated list, that is to be included when interpreting a Resource Set definition."</para>
    /// labels<para>"include fragments"</para></remarks>
    /// <seealso href="http://www.w3.org/2007/05/powder#includeFragments">http://www.w3.org/2007/05/powder#includeFragments</seealso>
    let includeFragments = Prefixed_Name(powder, "includeFragments") |> PrefixedName
    /// <summary>
    ///   <para>powder:includeHosts</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"This property defines a set of resources that have a URI host component matching at least one of the values given in a white space separated list, that is to be included when interpreting a Resource Set definition."</para>
    /// labels<para>"include hosts"</para></remarks>
    /// <seealso href="http://www.w3.org/2007/05/powder#includeHosts">http://www.w3.org/2007/05/powder#includeHosts</seealso>
    let includeHosts = Prefixed_Name(powder, "includeHosts") |> PrefixedName
    /// <summary>
    ///   <para>powder:includeIPs</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"This property defines a set of resources that have an IP address matching at least one of the values given in a white space separated list, that is to be included when interpreting a Resource Set definition."</para>
    /// labels<para>"include IPs"</para></remarks>
    /// <seealso href="http://www.w3.org/2007/05/powder#includeIPs">http://www.w3.org/2007/05/powder#includeIPs</seealso>
    let includeIPs = Prefixed_Name(powder, "includeIPs") |> PrefixedName
    /// <summary>
    ///   <para>powder:includeIpRanges</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"This property defines a set of resources that have an IP address within at least one of the ranges given in a white space separated list of CIDR blocks, that is to be included when interpreting a Resource Set definition."</para>
    /// labels<para>"include IP ranges"</para></remarks>
    /// <seealso href="http://www.w3.org/2007/05/powder#includeIpRanges">http://www.w3.org/2007/05/powder#includeIpRanges</seealso>
    let includeIpRanges = Prefixed_Name(powder, "includeIpRanges") |> PrefixedName

    /// <summary>
    ///   <para>powder:includePathContains</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"This property defines a set of resources that have a URI path component containing at least one of the values given in a white space separated list, that is to be included when interpreting a Resource Set definition."</para>
    /// labels<para>"include path contains"</para></remarks>
    /// <seealso href="http://www.w3.org/2007/05/powder#includePathContains">http://www.w3.org/2007/05/powder#includePathContains</seealso>
    let includePathContains =
        Prefixed_Name(powder, "includePathContains") |> PrefixedName

    /// <summary>
    ///   <para>powder:includePathEndsWith</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"This property defines a set of resources that have a URI path component ending with at least one of the values given in a white space separated list, that is to be included when interpreting a Resource Set definition."</para>
    /// labels<para>"include path ends with"</para></remarks>
    /// <seealso href="http://www.w3.org/2007/05/powder#includePathEndsWith">http://www.w3.org/2007/05/powder#includePathEndsWith</seealso>
    let includePathEndsWith =
        Prefixed_Name(powder, "includePathEndsWith") |> PrefixedName

    /// <summary>
    ///   <para>powder:includePathStartsWith</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"This property defines a set of resources that have a URI path component starting with at least one of the values given in a white space separated list, that is to be included when interpreting a Resource Set definition."</para>
    /// labels<para>"include path starts with"</para></remarks>
    /// <seealso href="http://www.w3.org/2007/05/powder#includePathStartsWith">http://www.w3.org/2007/05/powder#includePathStartsWith</seealso>
    let includePathStartsWith =
        Prefixed_Name(powder, "includePathStartsWith") |> PrefixedName

    /// <summary>
    ///   <para>powder:includePortRanges</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"This property defines a set of resources that have a URI port component within at least one of the ranges given in a white space separated list, that is to be included when interpreting a Resource Set definition."</para>
    /// labels<para>"include port ranges"</para></remarks>
    /// <seealso href="http://www.w3.org/2007/05/powder#includePortRanges">http://www.w3.org/2007/05/powder#includePortRanges</seealso>
    let includePortRanges = Prefixed_Name(powder, "includePortRanges") |> PrefixedName
    /// <summary>
    ///   <para>powder:includePorts</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"This property defines a set of resources that have a URI port component matching at least one of the values given in a white space separated list, that is to be included when interpreting a Resource Set definition."</para>
    /// labels<para>"include ports"</para></remarks>
    /// <seealso href="http://www.w3.org/2007/05/powder#includePorts">http://www.w3.org/2007/05/powder#includePorts</seealso>
    let includePorts = Prefixed_Name(powder, "includePorts") |> PrefixedName

    /// <summary>
    ///   <para>powder:includeQueryContains</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"This property defines a set of resources that have a URI query component containing at least one of the values given in a white space separated list, that is to be included when interpreting a Resource Set definition."</para>
    /// labels<para>"include query contains"</para></remarks>
    /// <seealso href="http://www.w3.org/2007/05/powder#includeQueryContains">http://www.w3.org/2007/05/powder#includeQueryContains</seealso>
    let includeQueryContains =
        Prefixed_Name(powder, "includeQueryContains") |> PrefixedName

    /// <summary>
    ///   <para>powder:includeRedirection</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property determines whether HTTP-redirected resource are to be included in the Resource Set. Its value can indicate that temporary, permanent or any redirection is allowable."</para>
    /// labels<para>"include redirection"</para></remarks>
    /// <seealso href="http://www.w3.org/2007/05/powder#includeRedirection">http://www.w3.org/2007/05/powder#includeRedirection</seealso>
    let includeRedirection = Prefixed_Name(powder, "includeRedirection") |> PrefixedName
    /// <summary>
    ///   <para>powder:includeResources</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"This property defines a set of one or more resources, identified by a white space separated list of their URIs, that are to be included in a Resource Set."</para>
    /// labels<para>"include resources"</para></remarks>
    /// <seealso href="http://www.w3.org/2007/05/powder#includeResources">http://www.w3.org/2007/05/powder#includeResources</seealso>
    let includeResources = Prefixed_Name(powder, "includeResources") |> PrefixedName

    /// <summary>
    ///   <para>powder:includeResponseContains</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"This property defines a set of resources for which the response from the given look up URI contains at least one of the values given in a white space separated list, that is to be included when interpreting a Resource Set definition."</para>
    /// labels<para>"include response contains"</para></remarks>
    /// <seealso href="http://www.w3.org/2007/05/powder#includeResponseContains">http://www.w3.org/2007/05/powder#includeResponseContains</seealso>
    let includeResponseContains =
        Prefixed_Name(powder, "includeResponseContains") |> PrefixedName

    /// <summary>
    ///   <para>powder:includeSchemes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"This property defines a set of resources that have a URI scheme component matching at least one of the values given in a white space separated list, that is to be included when interpreting a Resource Set definition."</para>
    /// labels<para>"include schemes"</para></remarks>
    /// <seealso href="http://www.w3.org/2007/05/powder#includeSchemes">http://www.w3.org/2007/05/powder#includeSchemes</seealso>
    let includeSchemes = Prefixed_Name(powder, "includeSchemes") |> PrefixedName
    /// <summary>
    ///   <para>powder:includeUriPattern</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"This property defines a set of resources, by means of white space separated list of URI-like strings that include wildcards, that is to be included when interpreting a Resource Set definition."</para>
    /// labels<para>"include URI pattern"</para></remarks>
    /// <seealso href="http://www.w3.org/2007/05/powder#includeUriPattern">http://www.w3.org/2007/05/powder#includeUriPattern</seealso>
    let includeUriPattern = Prefixed_Name(powder, "includeUriPattern") |> PrefixedName
    /// <summary>
    ///   <para>powder:includeUriRegEx</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"This property defines a set of resources, by means of a Regular Expression match against their URIs, that is to be included when interpreting a Resource Set definition."</para>
    /// labels<para>"include URI pattern"</para></remarks>
    /// <seealso href="http://www.w3.org/2007/05/powder#includeUriRegEx">http://www.w3.org/2007/05/powder#includeUriRegEx</seealso>
    let includeUriRegEx = Prefixed_Name(powder, "includeUriRegEx") |> PrefixedName
    /// <summary>
    ///   <para>powder:includeUsers</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"This property defines a set of resources that have a URI userinfo component matching at least one of the values given in a white space separated list, that is to be included when interpreting a Resource Set definition."</para>
    /// labels<para>"include user infos"</para></remarks>
    /// <seealso href="http://www.w3.org/2007/05/powder#includeUsers">http://www.w3.org/2007/05/powder#includeUsers</seealso>
    let includeUsers = Prefixed_Name(powder, "includeUsers") |> PrefixedName
    /// <summary>
    ///   <para>powder:ipRestriction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"This property denotes a set of resources in terms of a set of IP addresses or IP ranges. It MUST NOT be used directly in a Resource Set definition but is useful in defining cardinality constraints on its sub properties."</para>
    /// labels<para>"IP restriction"</para></remarks>
    /// <seealso href="http://www.w3.org/2007/05/powder#ipRestriction">http://www.w3.org/2007/05/powder#ipRestriction</seealso>
    let ipRestriction = Prefixed_Name(powder, "ipRestriction") |> PrefixedName
    /// <summary>
    ///   <para>powder:lookUpURI</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"This property specifies the URI to be resolved in order to discover the characteristics of a candidate resource. It takes a single 'template URI' that will include, or may comprise, the specific string {cURI}. This is to be substituted by the candidate resource's URI before resolution."</para>
    /// labels<para>"lookup URI"</para></remarks>
    /// <seealso href="http://www.w3.org/2007/05/powder#lookUpURI">http://www.w3.org/2007/05/powder#lookUpURI</seealso>
    let lookUpURI = Prefixed_Name(powder, "lookUpURI") |> PrefixedName
    /// <summary>
    ///   <para>powder:mapsTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property links from any kind of descriptive resource to a wdr:Descriptors class that is semantically equivalent."</para>
    /// labels<para>"maps to"</para></remarks>
    /// <seealso href="http://www.w3.org/2007/05/powder#mapsTo">http://www.w3.org/2007/05/powder#mapsTo</seealso>
    let mapsTo = Prefixed_Name(powder, "mapsTo") |> PrefixedName
    /// <summary>
    ///   <para>powder:portRestriction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"This property denotes a set of resources in terms of a list of URI ports or port ranges. It MUST NOT be used directly in a Resource Set definition but is useful in defining cardinality constraints on its sub properties."</para>
    /// labels<para>"port restriction"</para></remarks>
    /// <seealso href="http://www.w3.org/2007/05/powder#portRestriction">http://www.w3.org/2007/05/powder#portRestriction</seealso>
    let portRestriction = Prefixed_Name(powder, "portRestriction") |> PrefixedName

    /// <summary>
    ///   <para>powder:propertyRestriction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property denotes a set of resources in terms of their characteristics. It MUST NOT be used directly in a Resource Set definition but is useful in defining cardinality constraints on its sub properties."</para>
    /// labels<para>"property restriction"</para></remarks>
    /// <seealso href="http://www.w3.org/2007/05/powder#propertyRestriction">http://www.w3.org/2007/05/powder#propertyRestriction</seealso>
    let propertyRestriction =
        Prefixed_Name(powder, "propertyRestriction") |> PrefixedName

    /// <summary>
    ///   <para>powder:responseRestriction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"This property denotes the response provided by a lookup service about the characteristics of a resource. It MUST NOT be used directly in a Resource Set definition but is useful in defining cardinality constraints on its sub properties."</para>
    /// labels<para>"response restriction"</para></remarks>
    /// <seealso href="http://www.w3.org/2007/05/powder#responseRestriction">http://www.w3.org/2007/05/powder#responseRestriction</seealso>
    let responseRestriction =
        Prefixed_Name(powder, "responseRestriction") |> PrefixedName

    /// <summary>
    ///   <para>powder:setDefinition</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"This property denotes a set of resources in terms of their address or characteristics. It MUST NOT be used directly in a Resource Set definition but is useful in defining cardinality constraints on its sub properties."</para>
    /// labels<para>"set definition"</para></remarks>
    /// <seealso href="http://www.w3.org/2007/05/powder#setDefinition">http://www.w3.org/2007/05/powder#setDefinition</seealso>
    let setDefinition = Prefixed_Name(powder, "setDefinition") |> PrefixedName
    /// <summary>
    ///   <para>powder:supportedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"This property links a DR to another data source that supports, i.e. agrees with, the claims and assertions made in the DR. The supporting evidence may in any format."</para>
    /// labels<para>"supported by"</para></remarks>
    /// <seealso href="http://www.w3.org/2007/05/powder#supportedBy">http://www.w3.org/2007/05/powder#supportedBy</seealso>
    let supportedBy = Prefixed_Name(powder, "supportedBy") |> PrefixedName
    /// <summary>
    ///   <para>powder:usePropLookUp</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property links a Description Resource to a Property Lookup Class."</para>
    /// labels<para>"use property lookup"</para></remarks>
    /// <seealso href="http://www.w3.org/2007/05/powder#usePropLookUp">http://www.w3.org/2007/05/powder#usePropLookUp</seealso>
    let usePropLookUp = Prefixed_Name(powder, "usePropLookUp") |> PrefixedName
    /// <summary>
    ///   <para>powder:validFrom</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"This property denotes the date from which a Description Resource is valid. It may post-date the DR's issue date."</para>
    /// labels<para>"valid from"</para></remarks>
    /// <seealso href="http://www.w3.org/2007/05/powder#validFrom">http://www.w3.org/2007/05/powder#validFrom</seealso>
    let validFrom = Prefixed_Name(powder, "validFrom") |> PrefixedName
    /// <summary>
    ///   <para>powder:validUntil</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"This property denotes the expiry date of a Description Resource."</para>
    /// labels<para>"valid until"</para></remarks>
    /// <seealso href="http://www.w3.org/2007/05/powder#validUntil">http://www.w3.org/2007/05/powder#validUntil</seealso>
    let validUntil = Prefixed_Name(powder, "validUntil") |> PrefixedName
