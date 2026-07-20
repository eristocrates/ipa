namespace http.uri4uri.net.vocab.hash

open DoxAletheia

module uri4uri =
    let _namespace_name = "http://uri4uri.net/vocab#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="http://uri4uri.net/vocab#Domain"></see>
    /// </summary>
    let Domain = _prefix "Domain"
    /// <summary>
    ///   <see href="http://uri4uri.net/vocab#Domain-Invalid"></see>
    /// </summary>
    let ``Domain-Invalid`` = _prefix "Domain-Invalid"
    /// <summary>
    ///   <see href="http://uri4uri.net/vocab#Domain-Valid"></see>
    /// </summary>
    let ``Domain-Valid`` = _prefix "Domain-Valid"
    /// <summary>
    ///   <see href="http://uri4uri.net/vocab#DomainDatatype"></see>
    /// </summary>
    let DomainDatatype = _prefix "DomainDatatype"
    /// <summary>
    ///   <see href="http://uri4uri.net/vocab#Format"></see>
    /// </summary>
    let Format = _prefix "Format"
    /// <summary>
    ///   <see href="http://uri4uri.net/vocab#FragmentURI"></see>
    /// </summary>
    let FragmentURI = _prefix "FragmentURI"
    /// <summary>
    ///   <see href="http://uri4uri.net/vocab#HostPort"></see>
    /// </summary>
    let HostPort = _prefix "HostPort"
    /// <summary>
    ///   <see href="http://uri4uri.net/vocab#IANAPage"></see>
    /// </summary>
    let IANAPage = _prefix "IANAPage"
    /// <summary>
    ///   <see href="http://uri4uri.net/vocab#IANARef"></see>
    /// </summary>
    let IANARef = _prefix "IANARef"
    /// <summary>
    ///   <see href="http://uri4uri.net/vocab#Mimetype"></see>
    /// </summary>
    let Mimetype = _prefix "Mimetype"
    /// <summary>
    ///   <see href="http://uri4uri.net/vocab#MimetypeDatatype"></see>
    /// </summary>
    let MimetypeDatatype = _prefix "MimetypeDatatype"
    /// <summary>
    ///   <see href="http://uri4uri.net/vocab#Query"></see>
    /// </summary>
    let Query = _prefix "Query"
    /// <summary>
    ///   <see href="http://uri4uri.net/vocab#QueryKVP"></see>
    /// </summary>
    let QueryKVP = _prefix "QueryKVP"
    /// <summary>
    ///   <see href="http://uri4uri.net/vocab#QueryKey"></see>
    /// </summary>
    let QueryKey = _prefix "QueryKey"
    /// <summary>
    ///   <see href="http://uri4uri.net/vocab#QueryValue"></see>
    /// </summary>
    let QueryValue = _prefix "QueryValue"
    /// <summary>
    ///   <see href="http://uri4uri.net/vocab#Statement"></see>
    /// </summary>
    let Statement = _prefix "Statement"
    /// <summary>
    ///   <see href="http://uri4uri.net/vocab#Suffix"></see>
    /// </summary>
    let Suffix = _prefix "Suffix"
    /// <summary>
    ///   <see href="http://uri4uri.net/vocab#SuffixDatatype"></see>
    /// </summary>
    let SuffixDatatype = _prefix "SuffixDatatype"
    /// <summary>
    ///   <see href="http://uri4uri.net/vocab#TopLevelDomain"></see>
    /// </summary>
    let TopLevelDomain = _prefix "TopLevelDomain"
    /// <summary>
    ///   <see href="http://uri4uri.net/vocab#TopLevelDomain-CountryCode"></see>
    /// </summary>
    let ``TopLevelDomain-CountryCode`` = _prefix "TopLevelDomain-CountryCode"
    /// <summary>
    ///   <see href="http://uri4uri.net/vocab#TopLevelDomain-Generic"></see>
    /// </summary>
    let ``TopLevelDomain-Generic`` = _prefix "TopLevelDomain-Generic"

    /// <summary>
    ///   <see href="http://uri4uri.net/vocab#TopLevelDomain-GenericRestricted"></see>
    /// </summary>
    let ``TopLevelDomain-GenericRestricted`` =
        _prefix "TopLevelDomain-GenericRestricted"

    /// <summary>
    ///   <see href="http://uri4uri.net/vocab#TopLevelDomain-Infrastructure"></see>
    /// </summary>
    let ``TopLevelDomain-Infrastructure`` = _prefix "TopLevelDomain-Infrastructure"
    /// <summary>
    ///   <see href="http://uri4uri.net/vocab#TopLevelDomain-Sponsored"></see>
    /// </summary>
    let ``TopLevelDomain-Sponsored`` = _prefix "TopLevelDomain-Sponsored"
    /// <summary>
    ///   <see href="http://uri4uri.net/vocab#TopLevelDomain-Test"></see>
    /// </summary>
    let ``TopLevelDomain-Test`` = _prefix "TopLevelDomain-Test"
    /// <summary>
    ///   <see href="http://uri4uri.net/vocab#URI"></see>
    /// </summary>
    let URI = _prefix "URI"
    /// <summary>
    ///   <see href="http://uri4uri.net/vocab#URIDatatype"></see>
    /// </summary>
    let URIDatatype = _prefix "URIDatatype"
    /// <summary>
    ///   <see href="http://uri4uri.net/vocab#URIScheme"></see>
    /// </summary>
    let URIScheme = _prefix "URIScheme"
    /// <summary>
    ///   <see href="http://uri4uri.net/vocab#URISchemeDatatype"></see>
    /// </summary>
    let URISchemeDatatype = _prefix "URISchemeDatatype"
    /// <summary>
    ///   <see href="http://uri4uri.net/vocab#WhoisServer"></see>
    /// </summary>
    let WhoisServer = _prefix "WhoisServer"
    /// <summary>
    ///   <see href="http://uri4uri.net/vocab#account"></see>
    /// </summary>
    let account = _prefix "account"
    /// <summary>
    ///   <see href="http://uri4uri.net/vocab#connectsTo"></see>
    /// </summary>
    let connectsTo = _prefix "connectsTo"
    /// <summary>
    ///   <see href="http://uri4uri.net/vocab#delegationRecordPage"></see>
    /// </summary>
    let delegationRecordPage = _prefix "delegationRecordPage"
    /// <summary>
    ///   <see href="http://uri4uri.net/vocab#filename"></see>
    /// </summary>
    let filename = _prefix "filename"
    /// <summary>
    ///   <see href="http://uri4uri.net/vocab#fragment"></see>
    /// </summary>
    let fragment = _prefix "fragment"
    /// <summary>
    ///   <see href="http://uri4uri.net/vocab#fragmentOf"></see>
    /// </summary>
    let fragmentOf = _prefix "fragmentOf"
    /// <summary>
    ///   <see href="http://uri4uri.net/vocab#hasWhoIsServer"></see>
    /// </summary>
    let hasWhoIsServer = _prefix "hasWhoIsServer"
    /// <summary>
    ///   <see href="http://uri4uri.net/vocab#host"></see>
    /// </summary>
    let host = _prefix "host"
    /// <summary>
    ///   <see href="http://uri4uri.net/vocab#identifiedBy"></see>
    /// </summary>
    let identifiedBy = _prefix "identifiedBy"
    /// <summary>
    ///   <see href="http://uri4uri.net/vocab#key"></see>
    /// </summary>
    let key = _prefix "key"
    /// <summary>
    ///   <see href="http://uri4uri.net/vocab#length"></see>
    /// </summary>
    let length = _prefix "length"
    /// <summary>
    ///   <see href="http://uri4uri.net/vocab#md5"></see>
    /// </summary>
    let md5 = _prefix "md5"
    /// <summary>
    ///   <see href="http://uri4uri.net/vocab#noPortSpecified"></see>
    /// </summary>
    let noPortSpecified = _prefix "noPortSpecified"
    /// <summary>
    ///   <see href="http://uri4uri.net/vocab#object"></see>
    /// </summary>
    let object = _prefix "object"
    /// <summary>
    ///   <see href="http://uri4uri.net/vocab#pass"></see>
    /// </summary>
    let pass = _prefix "pass"
    /// <summary>
    ///   <see href="http://uri4uri.net/vocab#path"></see>
    /// </summary>
    let path = _prefix "path"
    /// <summary>
    ///   <see href="http://uri4uri.net/vocab#port"></see>
    /// </summary>
    let port = _prefix "port"
    /// <summary>
    ///   <see href="http://uri4uri.net/vocab#predicate"></see>
    /// </summary>
    let predicate = _prefix "predicate"
    /// <summary>
    ///   <see href="http://uri4uri.net/vocab#query"></see>
    /// </summary>
    let query = _prefix "query"
    /// <summary>
    ///   <see href="http://uri4uri.net/vocab#queryString"></see>
    /// </summary>
    let queryString = _prefix "queryString"
    /// <summary>
    ///   <see href="http://uri4uri.net/vocab#scheme"></see>
    /// </summary>
    let scheme = _prefix "scheme"
    /// <summary>
    ///   <see href="http://uri4uri.net/vocab#sponsor"></see>
    /// </summary>
    let sponsor = _prefix "sponsor"
    /// <summary>
    ///   <see href="http://uri4uri.net/vocab#subDom"></see>
    /// </summary>
    let subDom = _prefix "subDom"
    /// <summary>
    ///   <see href="http://uri4uri.net/vocab#subject"></see>
    /// </summary>
    let subject = _prefix "subject"
    /// <summary>
    ///   <see href="http://uri4uri.net/vocab#suffix"></see>
    /// </summary>
    let suffix = _prefix "suffix"
    /// <summary>
    ///   <see href="http://uri4uri.net/vocab#trueAt"></see>
    /// </summary>
    let trueAt = _prefix "trueAt"
    /// <summary>
    ///   <see href="http://uri4uri.net/vocab#usedForFormat"></see>
    /// </summary>
    let usedForFormat = _prefix "usedForFormat"
    /// <summary>
    ///   <see href="http://uri4uri.net/vocab#usedForSuffix"></see>
    /// </summary>
    let usedForSuffix = _prefix "usedForSuffix"
    /// <summary>
    ///   <see href="http://uri4uri.net/vocab#user"></see>
    /// </summary>
    let user = _prefix "user"
    /// <summary>
    ///   <see href="http://uri4uri.net/vocab#value"></see>
    /// </summary>
    let value = _prefix "value"
    /// <summary>
    ///   <see href="http://uri4uri.net/vocab#whoIsRecord"></see>
    /// </summary>
    let whoIsRecord = _prefix "whoIsRecord"
