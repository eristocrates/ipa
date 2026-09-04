#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module uri4uri =
    let _prefixId = PrefixId.fromNamespaceLabel "http://uri4uri.net/vocab#" "uri4uri"
    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:label : Internet Domain^^xsd:string</para>
    ///   <a href="http://uri4uri.net/vocab#Domain">uri4uri:Domain</a>
    /// </summary>
    let Domain = _prefixId.prefix "Domain"
    /// <summary>
    ///   <para>rdfs:label : Invalid Internet Domain^^xsd:string</para>
    ///   <a href="http://uri4uri.net/vocab#Domain-Invalid">uri4uri:Domain-Invalid</a>
    /// </summary>
    let Domain_Invalid = _prefixId.prefix "Domain-Invalid"
    /// <summary>
    ///   <para>rdfs:label : Valid Internet Domain^^xsd:string</para>
    ///   <a href="http://uri4uri.net/vocab#Domain-Valid">uri4uri:Domain-Valid</a>
    /// </summary>
    let Domain_Valid = _prefixId.prefix "Domain-Valid"
    let DomainDatatype = _prefixId.prefix "DomainDatatype"
    /// <summary>
    ///   <para>rdfs:label : File Format^^xsd:string</para>
    ///   <a href="http://uri4uri.net/vocab#Format">uri4uri:Format</a>
    /// </summary>
    let Format = _prefixId.prefix "Format"
    /// <summary>
    ///   <para>rdfs:label : URI with Fragement Identifier^^xsd:string</para>
    ///   <a href="http://uri4uri.net/vocab#FragmentURI">uri4uri:FragmentURI</a>
    /// </summary>
    let FragmentURI = _prefixId.prefix "FragmentURI"
    /// <summary>
    ///   <para>rdfs:label : Host and Port^^xsd:string</para>
    ///   <a href="http://uri4uri.net/vocab#HostPort">uri4uri:HostPort</a>
    /// </summary>
    let HostPort = _prefixId.prefix "HostPort"
    /// <summary>
    ///   <para>rdfs:label : IANA page^^xsd:string</para>
    ///   <a href="http://uri4uri.net/vocab#IANAPage">uri4uri:IANAPage</a>
    /// </summary>
    let IANAPage = _prefixId.prefix "IANAPage"
    /// <summary>
    ///   <para>rdfs:label : IANA reference^^xsd:string</para>
    ///   <a href="http://uri4uri.net/vocab#IANARef">uri4uri:IANARef</a>
    /// </summary>
    let IANARef = _prefixId.prefix "IANARef"
    /// <summary>
    ///   <para>rdfs:label : Mimetype^^xsd:string</para>
    ///   <a href="http://uri4uri.net/vocab#Mimetype">uri4uri:Mimetype</a>
    /// </summary>
    let Mimetype = _prefixId.prefix "Mimetype"
    let MimetypeDatatype = _prefixId.prefix "MimetypeDatatype"
    /// <summary>
    ///   <para>rdfs:label : URI Query Part^^xsd:string</para>
    ///   <a href="http://uri4uri.net/vocab#Query">uri4uri:Query</a>
    /// </summary>
    let Query = _prefixId.prefix "Query"
    /// <summary>
    ///   <para>rdfs:label : URI Query Key-Value Pair^^xsd:string</para>
    ///   <a href="http://uri4uri.net/vocab#QueryKVP">uri4uri:QueryKVP</a>
    /// </summary>
    let QueryKVP = _prefixId.prefix "QueryKVP"
    /// <summary>
    ///   <para>rdfs:label : URI Query Key^^xsd:string</para>
    ///   <a href="http://uri4uri.net/vocab#QueryKey">uri4uri:QueryKey</a>
    /// </summary>
    let QueryKey = _prefixId.prefix "QueryKey"
    /// <summary>
    ///   <para>rdfs:label : URI Query Value^^xsd:string</para>
    ///   <a href="http://uri4uri.net/vocab#QueryValue">uri4uri:QueryValue</a>
    /// </summary>
    let QueryValue = _prefixId.prefix "QueryValue"
    /// <summary>
    ///   <para>rdfs:label : Statement (reified)^^xsd:string</para>
    ///   <a href="http://uri4uri.net/vocab#Statement">uri4uri:Statement</a>
    /// </summary>
    let Statement = _prefixId.prefix "Statement"
    /// <summary>
    ///   <para>rdfs:label : Filename Suffix^^xsd:string</para>
    ///   <a href="http://uri4uri.net/vocab#Suffix">uri4uri:Suffix</a>
    /// </summary>
    let Suffix = _prefixId.prefix "Suffix"
    let SuffixDatatype = _prefixId.prefix "SuffixDatatype"
    /// <summary>
    ///   <para>rdfs:label : Top-Level Domain^^xsd:string</para>
    ///   <a href="http://uri4uri.net/vocab#TopLevelDomain">uri4uri:TopLevelDomain</a>
    /// </summary>
    let TopLevelDomain = _prefixId.prefix "TopLevelDomain"
    /// <summary>
    ///   <para>rdfs:label : Country Top-Level Domain^^xsd:string</para>
    ///   <a href="http://uri4uri.net/vocab#TopLevelDomain-CountryCode">uri4uri:TopLevelDomain-CountryCode</a>
    /// </summary>
    let TopLevelDomain_CountryCode = _prefixId.prefix "TopLevelDomain-CountryCode"
    /// <summary>
    ///   <para>rdfs:label : Generic Top-Level Domain^^xsd:string</para>
    ///   <a href="http://uri4uri.net/vocab#TopLevelDomain-Generic">uri4uri:TopLevelDomain-Generic</a>
    /// </summary>
    let TopLevelDomain_Generic = _prefixId.prefix "TopLevelDomain-Generic"

    /// <summary>
    ///   <para>rdfs:label : Restricted Generic Top-Level Domain^^xsd:string</para>
    ///   <a href="http://uri4uri.net/vocab#TopLevelDomain-GenericRestricted">uri4uri:TopLevelDomain-GenericRestricted</a>
    /// </summary>
    let TopLevelDomain_GenericRestricted =
        _prefixId.prefix "TopLevelDomain-GenericRestricted"

    /// <summary>
    ///   <para>rdfs:label : Infrastructure Top-Level Domain^^xsd:string</para>
    ///   <a href="http://uri4uri.net/vocab#TopLevelDomain-Infrastructure">uri4uri:TopLevelDomain-Infrastructure</a>
    /// </summary>
    let TopLevelDomain_Infrastructure = _prefixId.prefix "TopLevelDomain-Infrastructure"
    /// <summary>
    ///   <para>rdfs:label : Sponsored Top-Level Domain^^xsd:string</para>
    ///   <a href="http://uri4uri.net/vocab#TopLevelDomain-Sponsored">uri4uri:TopLevelDomain-Sponsored</a>
    /// </summary>
    let TopLevelDomain_Sponsored = _prefixId.prefix "TopLevelDomain-Sponsored"
    /// <summary>
    ///   <para>rdfs:label : Test Top-Level Domain^^xsd:string</para>
    ///   <a href="http://uri4uri.net/vocab#TopLevelDomain-Test">uri4uri:TopLevelDomain-Test</a>
    /// </summary>
    let TopLevelDomain_Test = _prefixId.prefix "TopLevelDomain-Test"
    /// <summary>
    ///   <para>rdfs:label : URI^^xsd:string</para>
    ///   <a href="http://uri4uri.net/vocab#URI">uri4uri:URI</a>
    /// </summary>
    let URI = _prefixId.prefix "URI"
    let URIDatatype = _prefixId.prefix "URIDatatype"
    /// <summary>
    ///   <para>rdfs:label : URI Scheme^^xsd:string</para>
    ///   <a href="http://uri4uri.net/vocab#URIScheme">uri4uri:URIScheme</a>
    /// </summary>
    let URIScheme = _prefixId.prefix "URIScheme"
    let URISchemeDatatype = _prefixId.prefix "URISchemeDatatype"
    /// <summary>
    ///   <para>rdfs:label : Whois Server^^xsd:string</para>
    ///   <a href="http://uri4uri.net/vocab#WhoisServer">uri4uri:WhoisServer</a>
    /// </summary>
    let WhoisServer = _prefixId.prefix "WhoisServer"
    /// <summary>
    ///   <para>rdfs:label : account^^xsd:string</para>
    ///   <a href="http://uri4uri.net/vocab#account">uri4uri:account</a>
    /// </summary>
    let account = _prefixId.prefix "account"
    /// <summary>
    ///   <para>rdfs:label : connects to^^xsd:string</para>
    ///   <a href="http://uri4uri.net/vocab#connectsTo">uri4uri:connectsTo</a>
    /// </summary>
    let connectsTo = _prefixId.prefix "connectsTo"
    /// <summary>
    ///   <para>rdfs:label : delegation record page^^xsd:string</para>
    ///   <a href="http://uri4uri.net/vocab#delegationRecordPage">uri4uri:delegationRecordPage</a>
    /// </summary>
    let delegationRecordPage = _prefixId.prefix "delegationRecordPage"
    /// <summary>
    ///   <para>rdfs:label : filename^^xsd:string</para>
    ///   <a href="http://uri4uri.net/vocab#filename">uri4uri:filename</a>
    /// </summary>
    let filename = _prefixId.prefix "filename"
    /// <summary>
    ///   <para>rdfs:label : fragment^^xsd:string</para>
    ///   <a href="http://uri4uri.net/vocab#fragment">uri4uri:fragment</a>
    /// </summary>
    let fragment = _prefixId.prefix "fragment"
    /// <summary>
    ///   <para>rdfs:label : fragment of^^xsd:string</para>
    ///   <a href="http://uri4uri.net/vocab#fragmentOf">uri4uri:fragmentOf</a>
    /// </summary>
    let fragmentOf = _prefixId.prefix "fragmentOf"
    /// <summary>
    ///   <para>rdfs:label : whois server^^xsd:string</para>
    ///   <a href="http://uri4uri.net/vocab#hasWhoIsServer">uri4uri:hasWhoIsServer</a>
    /// </summary>
    let hasWhoIsServer = _prefixId.prefix "hasWhoIsServer"
    /// <summary>
    ///   <para>rdfs:label : host^^xsd:string</para>
    ///   <a href="http://uri4uri.net/vocab#host">uri4uri:host</a>
    /// </summary>
    let host = _prefixId.prefix "host"
    /// <summary>
    ///   <para>rdfs:label : identified by URI^^xsd:string</para>
    ///   <a href="http://uri4uri.net/vocab#identifiedBy">uri4uri:identifiedBy</a>
    /// </summary>
    let identifiedBy = _prefixId.prefix "identifiedBy"
    /// <summary>
    ///   <para>rdfs:label : key^^xsd:string</para>
    ///   <a href="http://uri4uri.net/vocab#key">uri4uri:key</a>
    /// </summary>
    let key = _prefixId.prefix "key"
    /// <summary>
    ///   <para>rdfs:label : length^^xsd:string</para>
    ///   <a href="http://uri4uri.net/vocab#length">uri4uri:length</a>
    /// </summary>
    let length = _prefixId.prefix "length"
    /// <summary>
    ///   <para>rdfs:label : md5 hash^^xsd:string</para>
    ///   <a href="http://uri4uri.net/vocab#md5">uri4uri:md5</a>
    /// </summary>
    let md5 = _prefixId.prefix "md5"
    let noPortSpecified = _prefixId.prefix "noPortSpecified"
    /// <summary>
    ///   <para>rdfs:label : object^^xsd:string</para>
    ///   <a href="http://uri4uri.net/vocab#object">uri4uri:object</a>
    /// </summary>
    let object = _prefixId.prefix "object"
    /// <summary>
    ///   <para>rdfs:label : password^^xsd:string</para>
    ///   <a href="http://uri4uri.net/vocab#pass">uri4uri:pass</a>
    /// </summary>
    let pass = _prefixId.prefix "pass"
    /// <summary>
    ///   <para>rdfs:label : path^^xsd:string</para>
    ///   <a href="http://uri4uri.net/vocab#path">uri4uri:path</a>
    /// </summary>
    let path = _prefixId.prefix "path"
    /// <summary>
    ///   <para>rdfs:label : port^^xsd:string</para>
    ///   <a href="http://uri4uri.net/vocab#port">uri4uri:port</a>
    /// </summary>
    let port = _prefixId.prefix "port"
    /// <summary>
    ///   <para>rdfs:label : predicate^^xsd:string</para>
    ///   <a href="http://uri4uri.net/vocab#predicate">uri4uri:predicate</a>
    /// </summary>
    let predicate = _prefixId.prefix "predicate"
    /// <summary>
    ///   <para>rdfs:label : query^^xsd:string</para>
    ///   <a href="http://uri4uri.net/vocab#query">uri4uri:query</a>
    /// </summary>
    let query = _prefixId.prefix "query"
    /// <summary>
    ///   <para>rdfs:label : query string^^xsd:string</para>
    ///   <a href="http://uri4uri.net/vocab#queryString">uri4uri:queryString</a>
    /// </summary>
    let queryString = _prefixId.prefix "queryString"
    /// <summary>
    ///   <para>rdfs:label : URI scheme^^xsd:string</para>
    ///   <a href="http://uri4uri.net/vocab#scheme">uri4uri:scheme</a>
    /// </summary>
    let scheme = _prefixId.prefix "scheme"
    /// <summary>
    ///   <para>rdfs:label : sponsor^^xsd:string</para>
    ///   <a href="http://uri4uri.net/vocab#sponsor">uri4uri:sponsor</a>
    /// </summary>
    let sponsor = _prefixId.prefix "sponsor"
    /// <summary>
    ///   <para>rdfs:label : subdomain^^xsd:string</para>
    ///   <a href="http://uri4uri.net/vocab#subDom">uri4uri:subDom</a>
    /// </summary>
    let subDom = _prefixId.prefix "subDom"
    /// <summary>
    ///   <para>rdfs:label : subject^^xsd:string</para>
    ///   <a href="http://uri4uri.net/vocab#subject">uri4uri:subject</a>
    /// </summary>
    let subject = _prefixId.prefix "subject"
    /// <summary>
    ///   <para>rdfs:label : suffix^^xsd:string</para>
    ///   <a href="http://uri4uri.net/vocab#suffix">uri4uri:suffix</a>
    /// </summary>
    let suffix = _prefixId.prefix "suffix"
    /// <summary>
    ///   <para>rdfs:label : trueAt^^xsd:string</para>
    ///   <a href="http://uri4uri.net/vocab#trueAt">uri4uri:trueAt</a>
    /// </summary>
    let trueAt = _prefixId.prefix "trueAt"
    /// <summary>
    ///   <para>rdfs:label : used for format^^xsd:string</para>
    ///   <a href="http://uri4uri.net/vocab#usedForFormat">uri4uri:usedForFormat</a>
    /// </summary>
    let usedForFormat = _prefixId.prefix "usedForFormat"
    /// <summary>
    ///   <para>rdfs:label : used for suffix^^xsd:string</para>
    ///   <a href="http://uri4uri.net/vocab#usedForSuffix">uri4uri:usedForSuffix</a>
    /// </summary>
    let usedForSuffix = _prefixId.prefix "usedForSuffix"
    /// <summary>
    ///   <para>rdfs:label : user^^xsd:string</para>
    ///   <a href="http://uri4uri.net/vocab#user">uri4uri:user</a>
    /// </summary>
    let user = _prefixId.prefix "user"
    /// <summary>
    ///   <para>rdfs:label : value^^xsd:string</para>
    ///   <a href="http://uri4uri.net/vocab#value">uri4uri:value</a>
    /// </summary>
    let value = _prefixId.prefix "value"
    /// <summary>
    ///   <para>rdfs:label : whois record^^xsd:string</para>
    ///   <a href="http://uri4uri.net/vocab#whoIsRecord">uri4uri:whoIsRecord</a>
    /// </summary>
    let whoIsRecord = _prefixId.prefix "whoIsRecord"
