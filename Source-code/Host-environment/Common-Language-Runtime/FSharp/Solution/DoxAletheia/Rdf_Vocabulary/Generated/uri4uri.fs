namespace http.uri4uri.net.vocab.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module uri4uri =
    let _namespace_iri = Namespace_Iri uri4uri |> NamespaceIRI
    /// <summary>
    ///   <para>uri4uri:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    /// </remarks>
    /// <seealso href="http://uri4uri.net/vocab#">http://uri4uri.net/vocab#</seealso>
    let _prefix_iri = Prefixed_Name(uri4uri, "") |> PrefixedName
    /// <summary>
    ///   <para>uri4uri:Domain</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>"Internet Domain"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://uri4uri.net/vocab#Domain">http://uri4uri.net/vocab#Domain</seealso>
    let Domain = Prefixed_Name(uri4uri, "Domain") |> PrefixedName
    /// <summary>
    ///   <para>uri4uri:Domain-Invalid</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>"Invalid Internet Domain"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://uri4uri.net/vocab#Domain-Invalid">http://uri4uri.net/vocab#Domain-Invalid</seealso>
    let Domain_Invalid = Prefixed_Name(uri4uri, "Domain-Invalid") |> PrefixedName
    /// <summary>
    ///   <para>uri4uri:Domain-Valid</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>"Valid Internet Domain"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://uri4uri.net/vocab#Domain-Valid">http://uri4uri.net/vocab#Domain-Valid</seealso>
    let Domain_Valid = Prefixed_Name(uri4uri, "Domain-Valid") |> PrefixedName
    /// <summary>
    ///   <para>uri4uri:DomainDatatype</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"Internet Domain Identifier"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://uri4uri.net/vocab#DomainDatatype">http://uri4uri.net/vocab#DomainDatatype</seealso>
    let DomainDatatype = Prefixed_Name(uri4uri, "DomainDatatype") |> PrefixedName
    /// <summary>
    ///   <para>uri4uri:Format</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>"File Format"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://uri4uri.net/vocab#Format">http://uri4uri.net/vocab#Format</seealso>
    let Format = Prefixed_Name(uri4uri, "Format") |> PrefixedName
    /// <summary>
    ///   <para>uri4uri:FragmentURI</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>"URI with Fragement Identifier"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://uri4uri.net/vocab#FragmentURI">http://uri4uri.net/vocab#FragmentURI</seealso>
    let FragmentURI = Prefixed_Name(uri4uri, "FragmentURI") |> PrefixedName
    /// <summary>
    ///   <para>uri4uri:HostPort</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>"Host and Port"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://uri4uri.net/vocab#HostPort">http://uri4uri.net/vocab#HostPort</seealso>
    let HostPort = Prefixed_Name(uri4uri, "HostPort") |> PrefixedName
    /// <summary>
    ///   <para>uri4uri:IANAPage</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"IANA page"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://uri4uri.net/vocab#IANAPage">http://uri4uri.net/vocab#IANAPage</seealso>
    let IANAPage = Prefixed_Name(uri4uri, "IANAPage") |> PrefixedName
    /// <summary>
    ///   <para>uri4uri:IANARef</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"IANA reference"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://uri4uri.net/vocab#IANARef">http://uri4uri.net/vocab#IANARef</seealso>
    let IANARef = Prefixed_Name(uri4uri, "IANARef") |> PrefixedName
    /// <summary>
    ///   <para>uri4uri:Mimetype</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>"Mimetype"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://uri4uri.net/vocab#Mimetype">http://uri4uri.net/vocab#Mimetype</seealso>
    let Mimetype = Prefixed_Name(uri4uri, "Mimetype") |> PrefixedName
    /// <summary>
    ///   <para>uri4uri:MimetypeDatatype</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"Mimetype Identifier"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://uri4uri.net/vocab#MimetypeDatatype">http://uri4uri.net/vocab#MimetypeDatatype</seealso>
    let MimetypeDatatype = Prefixed_Name(uri4uri, "MimetypeDatatype") |> PrefixedName
    /// <summary>
    ///   <para>uri4uri:Query</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>"URI Query Part"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://uri4uri.net/vocab#Query">http://uri4uri.net/vocab#Query</seealso>
    let Query = Prefixed_Name(uri4uri, "Query") |> PrefixedName
    /// <summary>
    ///   <para>uri4uri:QueryKVP</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>"URI Query Key-Value Pair"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://uri4uri.net/vocab#QueryKVP">http://uri4uri.net/vocab#QueryKVP</seealso>
    let QueryKVP = Prefixed_Name(uri4uri, "QueryKVP") |> PrefixedName
    /// <summary>
    ///   <para>uri4uri:QueryKey</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>"URI Query Key"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://uri4uri.net/vocab#QueryKey">http://uri4uri.net/vocab#QueryKey</seealso>
    let QueryKey = Prefixed_Name(uri4uri, "QueryKey") |> PrefixedName
    /// <summary>
    ///   <para>uri4uri:QueryValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>"URI Query Value"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://uri4uri.net/vocab#QueryValue">http://uri4uri.net/vocab#QueryValue</seealso>
    let QueryValue = Prefixed_Name(uri4uri, "QueryValue") |> PrefixedName
    /// <summary>
    ///   <para>uri4uri:Statement</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>"Statement (reified)"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://uri4uri.net/vocab#Statement">http://uri4uri.net/vocab#Statement</seealso>
    let Statement = Prefixed_Name(uri4uri, "Statement") |> PrefixedName
    /// <summary>
    ///   <para>uri4uri:Suffix</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>"Filename Suffix"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://uri4uri.net/vocab#Suffix">http://uri4uri.net/vocab#Suffix</seealso>
    let Suffix = Prefixed_Name(uri4uri, "Suffix") |> PrefixedName
    /// <summary>
    ///   <para>uri4uri:SuffixDatatype</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"Filename Suffix Identifier"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://uri4uri.net/vocab#SuffixDatatype">http://uri4uri.net/vocab#SuffixDatatype</seealso>
    let SuffixDatatype = Prefixed_Name(uri4uri, "SuffixDatatype") |> PrefixedName
    /// <summary>
    ///   <para>uri4uri:TopLevelDomain</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>"Top-Level Domain"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://uri4uri.net/vocab#TopLevelDomain">http://uri4uri.net/vocab#TopLevelDomain</seealso>
    let TopLevelDomain = Prefixed_Name(uri4uri, "TopLevelDomain") |> PrefixedName

    /// <summary>
    ///   <para>uri4uri:TopLevelDomain-CountryCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>"Country Top-Level Domain"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://uri4uri.net/vocab#TopLevelDomain-CountryCode">http://uri4uri.net/vocab#TopLevelDomain-CountryCode</seealso>
    let TopLevelDomain_CountryCode =
        Prefixed_Name(uri4uri, "TopLevelDomain-CountryCode") |> PrefixedName

    /// <summary>
    ///   <para>uri4uri:TopLevelDomain-Generic</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>"Generic Top-Level Domain"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://uri4uri.net/vocab#TopLevelDomain-Generic">http://uri4uri.net/vocab#TopLevelDomain-Generic</seealso>
    let TopLevelDomain_Generic =
        Prefixed_Name(uri4uri, "TopLevelDomain-Generic") |> PrefixedName

    /// <summary>
    ///   <para>uri4uri:TopLevelDomain-GenericRestricted</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>"Restricted Generic Top-Level Domain"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://uri4uri.net/vocab#TopLevelDomain-GenericRestricted">http://uri4uri.net/vocab#TopLevelDomain-GenericRestricted</seealso>
    let TopLevelDomain_GenericRestricted =
        Prefixed_Name(uri4uri, "TopLevelDomain-GenericRestricted") |> PrefixedName

    /// <summary>
    ///   <para>uri4uri:TopLevelDomain-Infrastructure</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>"Infrastructure Top-Level Domain"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://uri4uri.net/vocab#TopLevelDomain-Infrastructure">http://uri4uri.net/vocab#TopLevelDomain-Infrastructure</seealso>
    let TopLevelDomain_Infrastructure =
        Prefixed_Name(uri4uri, "TopLevelDomain-Infrastructure") |> PrefixedName

    /// <summary>
    ///   <para>uri4uri:TopLevelDomain-Sponsored</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>"Sponsored Top-Level Domain"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://uri4uri.net/vocab#TopLevelDomain-Sponsored">http://uri4uri.net/vocab#TopLevelDomain-Sponsored</seealso>
    let TopLevelDomain_Sponsored =
        Prefixed_Name(uri4uri, "TopLevelDomain-Sponsored") |> PrefixedName

    /// <summary>
    ///   <para>uri4uri:TopLevelDomain-Test</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>"Test Top-Level Domain"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://uri4uri.net/vocab#TopLevelDomain-Test">http://uri4uri.net/vocab#TopLevelDomain-Test</seealso>
    let TopLevelDomain_Test =
        Prefixed_Name(uri4uri, "TopLevelDomain-Test") |> PrefixedName

    /// <summary>
    ///   <para>uri4uri:URI</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>"URI"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://uri4uri.net/vocab#URI">http://uri4uri.net/vocab#URI</seealso>
    let URI = Prefixed_Name(uri4uri, "URI") |> PrefixedName
    /// <summary>
    ///   <para>uri4uri:URIDatatype</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"URI Identifier"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://uri4uri.net/vocab#URIDatatype">http://uri4uri.net/vocab#URIDatatype</seealso>
    let URIDatatype = Prefixed_Name(uri4uri, "URIDatatype") |> PrefixedName
    /// <summary>
    ///   <para>uri4uri:URIScheme</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>"URI Scheme"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://uri4uri.net/vocab#URIScheme">http://uri4uri.net/vocab#URIScheme</seealso>
    let URIScheme = Prefixed_Name(uri4uri, "URIScheme") |> PrefixedName
    /// <summary>
    ///   <para>uri4uri:URISchemeDatatype</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"URI Scheme Identifier"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://uri4uri.net/vocab#URISchemeDatatype">http://uri4uri.net/vocab#URISchemeDatatype</seealso>
    let URISchemeDatatype = Prefixed_Name(uri4uri, "URISchemeDatatype") |> PrefixedName
    /// <summary>
    ///   <para>uri4uri:WhoisServer</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>"Whois Server"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://uri4uri.net/vocab#WhoisServer">http://uri4uri.net/vocab#WhoisServer</seealso>
    let WhoisServer = Prefixed_Name(uri4uri, "WhoisServer") |> PrefixedName
    /// <summary>
    ///   <para>uri4uri:account</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"account"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://uri4uri.net/vocab#account">http://uri4uri.net/vocab#account</seealso>
    let account = Prefixed_Name(uri4uri, "account") |> PrefixedName
    /// <summary>
    ///   <para>uri4uri:connectsTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"connects to"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://uri4uri.net/vocab#connectsTo">http://uri4uri.net/vocab#connectsTo</seealso>
    let connectsTo = Prefixed_Name(uri4uri, "connectsTo") |> PrefixedName

    /// <summary>
    ///   <para>uri4uri:delegationRecordPage</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"delegation record page"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://uri4uri.net/vocab#delegationRecordPage">http://uri4uri.net/vocab#delegationRecordPage</seealso>
    let delegationRecordPage =
        Prefixed_Name(uri4uri, "delegationRecordPage") |> PrefixedName

    /// <summary>
    ///   <para>uri4uri:filename</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"filename"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://uri4uri.net/vocab#filename">http://uri4uri.net/vocab#filename</seealso>
    let filename = Prefixed_Name(uri4uri, "filename") |> PrefixedName
    /// <summary>
    ///   <para>uri4uri:fragment</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"fragment"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://uri4uri.net/vocab#fragment">http://uri4uri.net/vocab#fragment</seealso>
    let fragment = Prefixed_Name(uri4uri, "fragment") |> PrefixedName
    /// <summary>
    ///   <para>uri4uri:fragmentOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"fragment of"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://uri4uri.net/vocab#fragmentOf">http://uri4uri.net/vocab#fragmentOf</seealso>
    let fragmentOf = Prefixed_Name(uri4uri, "fragmentOf") |> PrefixedName
    /// <summary>
    ///   <para>uri4uri:hasWhoIsServer</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"whois server"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://uri4uri.net/vocab#hasWhoIsServer">http://uri4uri.net/vocab#hasWhoIsServer</seealso>
    let hasWhoIsServer = Prefixed_Name(uri4uri, "hasWhoIsServer") |> PrefixedName
    /// <summary>
    ///   <para>uri4uri:host</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"host"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://uri4uri.net/vocab#host">http://uri4uri.net/vocab#host</seealso>
    let host = Prefixed_Name(uri4uri, "host") |> PrefixedName
    /// <summary>
    ///   <para>uri4uri:identifiedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"identified by URI"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://uri4uri.net/vocab#identifiedBy">http://uri4uri.net/vocab#identifiedBy</seealso>
    let identifiedBy = Prefixed_Name(uri4uri, "identifiedBy") |> PrefixedName
    /// <summary>
    ///   <para>uri4uri:key</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"key"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://uri4uri.net/vocab#key">http://uri4uri.net/vocab#key</seealso>
    let key = Prefixed_Name(uri4uri, "key") |> PrefixedName
    /// <summary>
    ///   <para>uri4uri:length</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"length"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://uri4uri.net/vocab#length">http://uri4uri.net/vocab#length</seealso>
    let length = Prefixed_Name(uri4uri, "length") |> PrefixedName
    /// <summary>
    ///   <para>uri4uri:md5</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"md5 hash"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://uri4uri.net/vocab#md5">http://uri4uri.net/vocab#md5</seealso>
    let md5 = Prefixed_Name(uri4uri, "md5") |> PrefixedName
    /// <summary>
    ///   <para>uri4uri:noPortSpecified</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>"No Port Specified"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://uri4uri.net/vocab#noPortSpecified">http://uri4uri.net/vocab#noPortSpecified</seealso>
    let noPortSpecified = Prefixed_Name(uri4uri, "noPortSpecified") |> PrefixedName
    /// <summary>
    ///   <para>uri4uri:object</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"object"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://uri4uri.net/vocab#object">http://uri4uri.net/vocab#object</seealso>
    let object = Prefixed_Name(uri4uri, "object") |> PrefixedName
    /// <summary>
    ///   <para>uri4uri:pass</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"password"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://uri4uri.net/vocab#pass">http://uri4uri.net/vocab#pass</seealso>
    let pass = Prefixed_Name(uri4uri, "pass") |> PrefixedName
    /// <summary>
    ///   <para>uri4uri:path</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"path"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://uri4uri.net/vocab#path">http://uri4uri.net/vocab#path</seealso>
    let path = Prefixed_Name(uri4uri, "path") |> PrefixedName
    /// <summary>
    ///   <para>uri4uri:port</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"port"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://uri4uri.net/vocab#port">http://uri4uri.net/vocab#port</seealso>
    let port = Prefixed_Name(uri4uri, "port") |> PrefixedName
    /// <summary>
    ///   <para>uri4uri:predicate</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"predicate"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://uri4uri.net/vocab#predicate">http://uri4uri.net/vocab#predicate</seealso>
    let predicate = Prefixed_Name(uri4uri, "predicate") |> PrefixedName
    /// <summary>
    ///   <para>uri4uri:query</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"query"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://uri4uri.net/vocab#query">http://uri4uri.net/vocab#query</seealso>
    let query = Prefixed_Name(uri4uri, "query") |> PrefixedName
    /// <summary>
    ///   <para>uri4uri:queryString</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"query string"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://uri4uri.net/vocab#queryString">http://uri4uri.net/vocab#queryString</seealso>
    let queryString = Prefixed_Name(uri4uri, "queryString") |> PrefixedName
    /// <summary>
    ///   <para>uri4uri:scheme</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"URI scheme"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://uri4uri.net/vocab#scheme">http://uri4uri.net/vocab#scheme</seealso>
    let scheme = Prefixed_Name(uri4uri, "scheme") |> PrefixedName
    /// <summary>
    ///   <para>uri4uri:sponsor</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"sponsor"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://uri4uri.net/vocab#sponsor">http://uri4uri.net/vocab#sponsor</seealso>
    let sponsor = Prefixed_Name(uri4uri, "sponsor") |> PrefixedName
    /// <summary>
    ///   <para>uri4uri:subDom</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"subdomain"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://uri4uri.net/vocab#subDom">http://uri4uri.net/vocab#subDom</seealso>
    let subDom = Prefixed_Name(uri4uri, "subDom") |> PrefixedName
    /// <summary>
    ///   <para>uri4uri:subject</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"subject"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://uri4uri.net/vocab#subject">http://uri4uri.net/vocab#subject</seealso>
    let subject = Prefixed_Name(uri4uri, "subject") |> PrefixedName
    /// <summary>
    ///   <para>uri4uri:suffix</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"suffix"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://uri4uri.net/vocab#suffix">http://uri4uri.net/vocab#suffix</seealso>
    let suffix = Prefixed_Name(uri4uri, "suffix") |> PrefixedName
    /// <summary>
    ///   <para>uri4uri:trueAt</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"trueAt"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://uri4uri.net/vocab#trueAt">http://uri4uri.net/vocab#trueAt</seealso>
    let trueAt = Prefixed_Name(uri4uri, "trueAt") |> PrefixedName
    /// <summary>
    ///   <para>uri4uri:usedForFormat</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"used for format"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://uri4uri.net/vocab#usedForFormat">http://uri4uri.net/vocab#usedForFormat</seealso>
    let usedForFormat = Prefixed_Name(uri4uri, "usedForFormat") |> PrefixedName
    /// <summary>
    ///   <para>uri4uri:usedForSuffix</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"used for suffix"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://uri4uri.net/vocab#usedForSuffix">http://uri4uri.net/vocab#usedForSuffix</seealso>
    let usedForSuffix = Prefixed_Name(uri4uri, "usedForSuffix") |> PrefixedName
    /// <summary>
    ///   <para>uri4uri:user</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"user"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://uri4uri.net/vocab#user">http://uri4uri.net/vocab#user</seealso>
    let user = Prefixed_Name(uri4uri, "user") |> PrefixedName
    /// <summary>
    ///   <para>uri4uri:value</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"value"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://uri4uri.net/vocab#value">http://uri4uri.net/vocab#value</seealso>
    let value = Prefixed_Name(uri4uri, "value") |> PrefixedName
    /// <summary>
    ///   <para>uri4uri:whoIsRecord</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"whois record"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://uri4uri.net/vocab#whoIsRecord">http://uri4uri.net/vocab#whoIsRecord</seealso>
    let whoIsRecord = Prefixed_Name(uri4uri, "whoIsRecord") |> PrefixedName
