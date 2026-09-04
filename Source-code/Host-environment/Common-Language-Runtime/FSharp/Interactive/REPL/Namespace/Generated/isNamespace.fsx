#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module is =
    let _prefixId = PrefixId.fromNamespaceLabel "http://purl.org/ontology/is/core#" "is"
    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>rdfs:label : Information Service</para>
    ///   <para>rdfs:comment : Extended definition:
    ///
    /// 	"An Information Service is this part of an Information System that serves data/knowledge/information to customers and collects it
    /// 	from its contributors, to manage and store it by optionally using administrators."
    ///
    /// Please refer also this article[1] about the definition of the term 'Information Service'.
    ///
    /// This concept is for linking a piece of information of a specific concept instance (or at least website links or other data representations
    /// of this concept instance), e.g. a foaf:Agent, a mo:Track or a mo:MusicArtist to a related website of a specific information service (modelled
    /// as individual of is:InfoService), e.g. Wikipedia, MySpace, MusicBrainz, Discogs, Last.fm, Pandora, BBC, ... . With this concept it is possible
    /// to describe the underlying information services of that knowledge representation more in detail, so that the client, which consumes that
    /// 'linked data' could choose, which source it likes to use by evaluating the description of the information service of that website link or
    /// other data representation.
    /// Please use for further is:InfoService instances the namespace "http://purl.org/ontology/is/inst/".
    ///
    ///
    /// [1] https://infoserviceonto.wordpress.com/2010/06/23/what-is-an-information-service/</para>
    ///   <a href="http://purl.org/ontology/is/core#InfoService">is:InfoService</a>
    /// </summary>
    let InfoService = _prefixId.prefix "InfoService"
    /// <summary>
    ///   <para>vs:term_status : testing</para>
    ///   <para>rdfs:label : Information Service Contributor Type</para>
    ///   <para>rdfs:comment : This concept is for describing the different contributor types of information services, e.g. expert,
    /// community or mixed. Please feel free to define further information service contributor types.
    /// Please use therefore the namespace "http://purl.org/ontology/is/ctypes/".</para>
    ///   <a href="http://purl.org/ontology/is/core#InfoServiceContributorType">is:InfoServiceContributorType</a>
    /// </summary>
    let InfoServiceContributorType = _prefixId.prefix "InfoServiceContributorType"
    /// <summary>
    ///   <para>vs:term_status : testing</para>
    ///   <para>rdfs:label : Information Service Quality</para>
    ///   <para>rdfs:comment : This concept is for describing specific quality levels or ratings, e.g. good or bad or more detailed ones, of
    /// information services. Please feel free to use this concept as hook for more complex and detailed information service quality description
    /// modellings in sub ontologies. Please use therefore the domain "http://purl.org/ontology/is/quality/". Futhermore, such information
    /// service ratings could be done by different information service rating agencies, so that the customer of such ratings could select
    /// its information service ratings agency of choice.</para>
    ///   <a href="http://purl.org/ontology/is/core#InfoServiceQuality">is:InfoServiceQuality</a>
    /// </summary>
    let InfoServiceQuality = _prefixId.prefix "InfoServiceQuality"
    /// <summary>
    ///   <para>vs:term_status : testing</para>
    ///   <para>rdfs:label : Information Service Type</para>
    ///   <para>rdfs:comment : This concept is for describing the type of an information service, e.g. 'social network service',
    /// 'recommender service' or 'encyclopedia'. Please feel free to define further information service types for categorization.
    /// Please use therefore the namespace "http://purl.org/ontology/is/types/".</para>
    ///   <a href="http://purl.org/ontology/is/core#InfoServiceType">is:InfoServiceType</a>
    /// </summary>
    let InfoServiceType = _prefixId.prefix "InfoServiceType"
    /// <summary>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>rdfs:label : has info service</para>
    ///   <para>rdfs:comment : Every subject related by this property is made available by an is:InfoService individual. This property could be used to associate a semantic graph based description or especially a website link, e.g. typed as foaf:Document, to the specific is:InfoService individual. This enables the consumer of this resource to retrieve more information (descriptions, ratings) about the underlying information service of this resource.</para>
    ///   <a href="http://purl.org/ontology/is/core#info_service">is:info_service</a>
    /// </summary>
    let info_service = _prefixId.prefix "info_service"
    /// <summary>
    ///   <para>rdfs:comment : With this property it is possible to associate a specific information service contributor type, e.g. expert,
    /// community or mixed, to an is:InfoService instance.</para>
    ///   <para>vs:term_status : testing</para>
    ///   <para>rdfs:label : has info service contributor type</para>
    ///   <a href="http://purl.org/ontology/is/core#info_service_contributor_type">is:info_service_contributor_type</a>
    /// </summary>
    let info_service_contributor_type = _prefixId.prefix "info_service_contributor_type"
    /// <summary>
    ///   <para>vs:term_status : testing</para>
    ///   <para>rdfs:label : has info service quality</para>
    ///   <para>rdfs:comment : With this property it is possible to associate a specific quality level, information service quality rating
    /// or an extended information service quality description to an is:InfoService instance</para>
    ///   <a href="http://purl.org/ontology/is/core#info_service_quality">is:info_service_quality</a>
    /// </summary>
    let info_service_quality = _prefixId.prefix "info_service_quality"
    /// <summary>
    ///   <para>rdfs:label : has info service type</para>
    ///   <para>rdfs:comment : With this property it is possible to associate a specific information service type, e.g. 'social network service',
    /// 'recommender service' or 'encyclopedia', to an is:InfoService instance. This property could be used multiple times that means an
    /// is:InfoService instance could be for example of the information service type 'social network site' and 'recommender system'.</para>
    ///   <para>vs:term_status : testing</para>
    ///   <a href="http://purl.org/ontology/is/core#info_service_type">is:info_service_type</a>
    /// </summary>
    let info_service_type = _prefixId.prefix "info_service_type"
    /// <summary>
    ///   <para>vs:term_status : testing</para>
    ///   <para>rdfs:label : has main subject</para>
    ///   <para>rdfs:comment : This property is for defining the main subject of an is:InfoService instance that means this
    /// info service address mainly this concern.</para>
    ///   <a href="http://purl.org/ontology/is/core#main_subject">is:main_subject</a>
    /// </summary>
    let main_subject = _prefixId.prefix "main_subject"
