namespace http.uri4uri.net.vocab.hash

open DoxAletheia.Rdf_Vocabulary

module uri4uri =
    let _namespace_name = "http://uri4uri.net/vocab#"
    /// <summary>
    ///   <see href="http://uri4uri.net/vocab#Domain"></see>
    /// </summary>
    let Domain = Namespaced_IRI.parse _namespace_name "Domain" |> NamespacedName

    /// <summary>
    ///   <see href="http://uri4uri.net/vocab#Domain-Invalid"></see>
    /// </summary>
    let ``Domain-Invalid`` =
        Namespaced_IRI.parse _namespace_name "Domain-Invalid" |> NamespacedName

    /// <summary>
    ///   <see href="http://uri4uri.net/vocab#Domain-Valid"></see>
    /// </summary>
    let ``Domain-Valid`` =
        Namespaced_IRI.parse _namespace_name "Domain-Valid" |> NamespacedName

    /// <summary>
    ///   <see href="http://uri4uri.net/vocab#DomainDatatype"></see>
    /// </summary>
    let DomainDatatype =
        Namespaced_IRI.parse _namespace_name "DomainDatatype" |> NamespacedName

    /// <summary>
    ///   <see href="http://uri4uri.net/vocab#Format"></see>
    /// </summary>
    let Format = Namespaced_IRI.parse _namespace_name "Format" |> NamespacedName

    /// <summary>
    ///   <see href="http://uri4uri.net/vocab#FragmentURI"></see>
    /// </summary>
    let FragmentURI =
        Namespaced_IRI.parse _namespace_name "FragmentURI" |> NamespacedName

    /// <summary>
    ///   <see href="http://uri4uri.net/vocab#HostPort"></see>
    /// </summary>
    let HostPort = Namespaced_IRI.parse _namespace_name "HostPort" |> NamespacedName
    /// <summary>
    ///   <see href="http://uri4uri.net/vocab#IANAPage"></see>
    /// </summary>
    let IANAPage = Namespaced_IRI.parse _namespace_name "IANAPage" |> NamespacedName
    /// <summary>
    ///   <see href="http://uri4uri.net/vocab#IANARef"></see>
    /// </summary>
    let IANARef = Namespaced_IRI.parse _namespace_name "IANARef" |> NamespacedName
    /// <summary>
    ///   <see href="http://uri4uri.net/vocab#Mimetype"></see>
    /// </summary>
    let Mimetype = Namespaced_IRI.parse _namespace_name "Mimetype" |> NamespacedName

    /// <summary>
    ///   <see href="http://uri4uri.net/vocab#MimetypeDatatype"></see>
    /// </summary>
    let MimetypeDatatype =
        Namespaced_IRI.parse _namespace_name "MimetypeDatatype" |> NamespacedName

    /// <summary>
    ///   <see href="http://uri4uri.net/vocab#Query"></see>
    /// </summary>
    let Query = Namespaced_IRI.parse _namespace_name "Query" |> NamespacedName
    /// <summary>
    ///   <see href="http://uri4uri.net/vocab#QueryKVP"></see>
    /// </summary>
    let QueryKVP = Namespaced_IRI.parse _namespace_name "QueryKVP" |> NamespacedName
    /// <summary>
    ///   <see href="http://uri4uri.net/vocab#QueryKey"></see>
    /// </summary>
    let QueryKey = Namespaced_IRI.parse _namespace_name "QueryKey" |> NamespacedName
    /// <summary>
    ///   <see href="http://uri4uri.net/vocab#QueryValue"></see>
    /// </summary>
    let QueryValue = Namespaced_IRI.parse _namespace_name "QueryValue" |> NamespacedName
    /// <summary>
    ///   <see href="http://uri4uri.net/vocab#Statement"></see>
    /// </summary>
    let Statement = Namespaced_IRI.parse _namespace_name "Statement" |> NamespacedName
    /// <summary>
    ///   <see href="http://uri4uri.net/vocab#Suffix"></see>
    /// </summary>
    let Suffix = Namespaced_IRI.parse _namespace_name "Suffix" |> NamespacedName

    /// <summary>
    ///   <see href="http://uri4uri.net/vocab#SuffixDatatype"></see>
    /// </summary>
    let SuffixDatatype =
        Namespaced_IRI.parse _namespace_name "SuffixDatatype" |> NamespacedName

    /// <summary>
    ///   <see href="http://uri4uri.net/vocab#TopLevelDomain"></see>
    /// </summary>
    let TopLevelDomain =
        Namespaced_IRI.parse _namespace_name "TopLevelDomain" |> NamespacedName

    /// <summary>
    ///   <see href="http://uri4uri.net/vocab#TopLevelDomain-CountryCode"></see>
    /// </summary>
    let ``TopLevelDomain-CountryCode`` =
        Namespaced_IRI.parse _namespace_name "TopLevelDomain-CountryCode" |> NamespacedName

    /// <summary>
    ///   <see href="http://uri4uri.net/vocab#TopLevelDomain-Generic"></see>
    /// </summary>
    let ``TopLevelDomain-Generic`` =
        Namespaced_IRI.parse _namespace_name "TopLevelDomain-Generic" |> NamespacedName

    /// <summary>
    ///   <see href="http://uri4uri.net/vocab#TopLevelDomain-GenericRestricted"></see>
    /// </summary>
    let ``TopLevelDomain-GenericRestricted`` =
        Namespaced_IRI.parse _namespace_name "TopLevelDomain-GenericRestricted" |> NamespacedName

    /// <summary>
    ///   <see href="http://uri4uri.net/vocab#TopLevelDomain-Infrastructure"></see>
    /// </summary>
    let ``TopLevelDomain-Infrastructure`` =
        Namespaced_IRI.parse _namespace_name "TopLevelDomain-Infrastructure" |> NamespacedName

    /// <summary>
    ///   <see href="http://uri4uri.net/vocab#TopLevelDomain-Sponsored"></see>
    /// </summary>
    let ``TopLevelDomain-Sponsored`` =
        Namespaced_IRI.parse _namespace_name "TopLevelDomain-Sponsored" |> NamespacedName

    /// <summary>
    ///   <see href="http://uri4uri.net/vocab#TopLevelDomain-Test"></see>
    /// </summary>
    let ``TopLevelDomain-Test`` =
        Namespaced_IRI.parse _namespace_name "TopLevelDomain-Test" |> NamespacedName

    /// <summary>
    ///   <see href="http://uri4uri.net/vocab#URI"></see>
    /// </summary>
    let URI = Namespaced_IRI.parse _namespace_name "URI" |> NamespacedName

    /// <summary>
    ///   <see href="http://uri4uri.net/vocab#URIDatatype"></see>
    /// </summary>
    let URIDatatype =
        Namespaced_IRI.parse _namespace_name "URIDatatype" |> NamespacedName

    /// <summary>
    ///   <see href="http://uri4uri.net/vocab#URIScheme"></see>
    /// </summary>
    let URIScheme = Namespaced_IRI.parse _namespace_name "URIScheme" |> NamespacedName

    /// <summary>
    ///   <see href="http://uri4uri.net/vocab#URISchemeDatatype"></see>
    /// </summary>
    let URISchemeDatatype =
        Namespaced_IRI.parse _namespace_name "URISchemeDatatype" |> NamespacedName

    /// <summary>
    ///   <see href="http://uri4uri.net/vocab#WhoisServer"></see>
    /// </summary>
    let WhoisServer =
        Namespaced_IRI.parse _namespace_name "WhoisServer" |> NamespacedName

    /// <summary>
    ///   <see href="http://uri4uri.net/vocab#account"></see>
    /// </summary>
    let account = Namespaced_IRI.parse _namespace_name "account" |> NamespacedName
    /// <summary>
    ///   <see href="http://uri4uri.net/vocab#connectsTo"></see>
    /// </summary>
    let connectsTo = Namespaced_IRI.parse _namespace_name "connectsTo" |> NamespacedName

    /// <summary>
    ///   <see href="http://uri4uri.net/vocab#delegationRecordPage"></see>
    /// </summary>
    let delegationRecordPage =
        Namespaced_IRI.parse _namespace_name "delegationRecordPage" |> NamespacedName

    /// <summary>
    ///   <see href="http://uri4uri.net/vocab#filename"></see>
    /// </summary>
    let filename = Namespaced_IRI.parse _namespace_name "filename" |> NamespacedName
    /// <summary>
    ///   <see href="http://uri4uri.net/vocab#fragment"></see>
    /// </summary>
    let fragment = Namespaced_IRI.parse _namespace_name "fragment" |> NamespacedName
    /// <summary>
    ///   <see href="http://uri4uri.net/vocab#fragmentOf"></see>
    /// </summary>
    let fragmentOf = Namespaced_IRI.parse _namespace_name "fragmentOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://uri4uri.net/vocab#hasWhoIsServer"></see>
    /// </summary>
    let hasWhoIsServer =
        Namespaced_IRI.parse _namespace_name "hasWhoIsServer" |> NamespacedName

    /// <summary>
    ///   <see href="http://uri4uri.net/vocab#host"></see>
    /// </summary>
    let host = Namespaced_IRI.parse _namespace_name "host" |> NamespacedName

    /// <summary>
    ///   <see href="http://uri4uri.net/vocab#identifiedBy"></see>
    /// </summary>
    let identifiedBy =
        Namespaced_IRI.parse _namespace_name "identifiedBy" |> NamespacedName

    /// <summary>
    ///   <see href="http://uri4uri.net/vocab#key"></see>
    /// </summary>
    let key = Namespaced_IRI.parse _namespace_name "key" |> NamespacedName
    /// <summary>
    ///   <see href="http://uri4uri.net/vocab#length"></see>
    /// </summary>
    let length = Namespaced_IRI.parse _namespace_name "length" |> NamespacedName
    /// <summary>
    ///   <see href="http://uri4uri.net/vocab#md5"></see>
    /// </summary>
    let md5 = Namespaced_IRI.parse _namespace_name "md5" |> NamespacedName

    /// <summary>
    ///   <see href="http://uri4uri.net/vocab#noPortSpecified"></see>
    /// </summary>
    let noPortSpecified =
        Namespaced_IRI.parse _namespace_name "noPortSpecified" |> NamespacedName

    /// <summary>
    ///   <see href="http://uri4uri.net/vocab#object"></see>
    /// </summary>
    let object = Namespaced_IRI.parse _namespace_name "object" |> NamespacedName
    /// <summary>
    ///   <see href="http://uri4uri.net/vocab#pass"></see>
    /// </summary>
    let pass = Namespaced_IRI.parse _namespace_name "pass" |> NamespacedName
    /// <summary>
    ///   <see href="http://uri4uri.net/vocab#path"></see>
    /// </summary>
    let path = Namespaced_IRI.parse _namespace_name "path" |> NamespacedName
    /// <summary>
    ///   <see href="http://uri4uri.net/vocab#port"></see>
    /// </summary>
    let port = Namespaced_IRI.parse _namespace_name "port" |> NamespacedName
    /// <summary>
    ///   <see href="http://uri4uri.net/vocab#predicate"></see>
    /// </summary>
    let predicate = Namespaced_IRI.parse _namespace_name "predicate" |> NamespacedName
    /// <summary>
    ///   <see href="http://uri4uri.net/vocab#query"></see>
    /// </summary>
    let query = Namespaced_IRI.parse _namespace_name "query" |> NamespacedName

    /// <summary>
    ///   <see href="http://uri4uri.net/vocab#queryString"></see>
    /// </summary>
    let queryString =
        Namespaced_IRI.parse _namespace_name "queryString" |> NamespacedName

    /// <summary>
    ///   <see href="http://uri4uri.net/vocab#scheme"></see>
    /// </summary>
    let scheme = Namespaced_IRI.parse _namespace_name "scheme" |> NamespacedName
    /// <summary>
    ///   <see href="http://uri4uri.net/vocab#sponsor"></see>
    /// </summary>
    let sponsor = Namespaced_IRI.parse _namespace_name "sponsor" |> NamespacedName
    /// <summary>
    ///   <see href="http://uri4uri.net/vocab#subDom"></see>
    /// </summary>
    let subDom = Namespaced_IRI.parse _namespace_name "subDom" |> NamespacedName
    /// <summary>
    ///   <see href="http://uri4uri.net/vocab#subject"></see>
    /// </summary>
    let subject = Namespaced_IRI.parse _namespace_name "subject" |> NamespacedName
    /// <summary>
    ///   <see href="http://uri4uri.net/vocab#suffix"></see>
    /// </summary>
    let suffix = Namespaced_IRI.parse _namespace_name "suffix" |> NamespacedName
    /// <summary>
    ///   <see href="http://uri4uri.net/vocab#trueAt"></see>
    /// </summary>
    let trueAt = Namespaced_IRI.parse _namespace_name "trueAt" |> NamespacedName

    /// <summary>
    ///   <see href="http://uri4uri.net/vocab#usedForFormat"></see>
    /// </summary>
    let usedForFormat =
        Namespaced_IRI.parse _namespace_name "usedForFormat" |> NamespacedName

    /// <summary>
    ///   <see href="http://uri4uri.net/vocab#usedForSuffix"></see>
    /// </summary>
    let usedForSuffix =
        Namespaced_IRI.parse _namespace_name "usedForSuffix" |> NamespacedName

    /// <summary>
    ///   <see href="http://uri4uri.net/vocab#user"></see>
    /// </summary>
    let user = Namespaced_IRI.parse _namespace_name "user" |> NamespacedName
    /// <summary>
    ///   <see href="http://uri4uri.net/vocab#value"></see>
    /// </summary>
    let value = Namespaced_IRI.parse _namespace_name "value" |> NamespacedName

    /// <summary>
    ///   <see href="http://uri4uri.net/vocab#whoIsRecord"></see>
    /// </summary>
    let whoIsRecord =
        Namespaced_IRI.parse _namespace_name "whoIsRecord" |> NamespacedName
