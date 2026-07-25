namespace http.purl.org.ontology.is.core.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module is =
    let _namespace_iri = Namespace_Iri is |> NamespaceIRI
    /// <summary>
    ///   <para>is:InfoService</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>Extended definition:
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
    /// labels<para>Information Service</para></remarks>
    /// <seealso href="http://purl.org/ontology/is/core#InfoService">http://purl.org/ontology/is/core#InfoService</seealso>
    let InfoService = Prefixed_Name(is, "InfoService") |> PrefixedName
    /// <summary>
    ///   <para>is:main_subject</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This property is for defining the main subject of an is:InfoService instance that means this
    /// info service address mainly this concern.</para>
    /// labels<para>has main subject</para></remarks>
    /// <seealso href="http://purl.org/ontology/is/core#main_subject">http://purl.org/ontology/is/core#main_subject</seealso>
    let main_subject = Prefixed_Name(is, "main_subject") |> PrefixedName

    /// <summary>
    ///   <para>is:InfoServiceContributorType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>dcterms:AgentClass</para>
    ///   <para>This concept is for describing the different contributor types of information services, e.g. expert,
    /// community or mixed. Please feel free to define further information service contributor types.
    /// Please use therefore the namespace "http://purl.org/ontology/is/ctypes/".</para>
    /// labels<para>Information Service Contributor Type</para></remarks>
    /// <seealso href="http://purl.org/ontology/is/core#InfoServiceContributorType">http://purl.org/ontology/is/core#InfoServiceContributorType</seealso>
    let InfoServiceContributorType =
        Prefixed_Name(is, "InfoServiceContributorType") |> PrefixedName

    /// <summary>
    ///   <para>is:InfoServiceQuality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>This concept is for describing specific quality levels or ratings, e.g. good or bad or more detailed ones, of
    /// information services. Please feel free to use this concept as hook for more complex and detailed information service quality description
    /// modellings in sub ontologies. Please use therefore the domain "http://purl.org/ontology/is/quality/". Futhermore, such information
    /// service ratings could be done by different information service rating agencies, so that the customer of such ratings could select
    /// its information service ratings agency of choice.</para>
    /// labels<para>Information Service Quality</para></remarks>
    /// <seealso href="http://purl.org/ontology/is/core#InfoServiceQuality">http://purl.org/ontology/is/core#InfoServiceQuality</seealso>
    let InfoServiceQuality = Prefixed_Name(is, "InfoServiceQuality") |> PrefixedName
    /// <summary>
    ///   <para>is:InfoServiceType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>dcterms:AgentClass</para>
    ///   <para>rdfs:Class</para>
    ///   <para>This concept is for describing the type of an information service, e.g. 'social network service',
    /// 'recommender service' or 'encyclopedia'. Please feel free to define further information service types for categorization.
    /// Please use therefore the namespace "http://purl.org/ontology/is/types/".</para>
    /// labels<para>Information Service Type</para></remarks>
    /// <seealso href="http://purl.org/ontology/is/core#InfoServiceType">http://purl.org/ontology/is/core#InfoServiceType</seealso>
    let InfoServiceType = Prefixed_Name(is, "InfoServiceType") |> PrefixedName

    /// <summary>
    ///   <para>is:info_service_contributor_type</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>With this property it is possible to associate a specific information service contributor type, e.g. expert,
    /// community or mixed, to an is:InfoService instance.</para>
    /// labels<para>has info service contributor type</para></remarks>
    /// <seealso href="http://purl.org/ontology/is/core#info_service_contributor_type">http://purl.org/ontology/is/core#info_service_contributor_type</seealso>
    let info_service_contributor_type =
        Prefixed_Name(is, "info_service_contributor_type") |> PrefixedName

    /// <summary>
    ///   <para>is:info_service_quality</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>With this property it is possible to associate a specific quality level, information service quality rating
    /// or an extended information service quality description to an is:InfoService instance</para>
    /// labels<para>has info service quality</para></remarks>
    /// <seealso href="http://purl.org/ontology/is/core#info_service_quality">http://purl.org/ontology/is/core#info_service_quality</seealso>
    let info_service_quality = Prefixed_Name(is, "info_service_quality") |> PrefixedName
    /// <summary>
    ///   <para>is:info_service_type</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>With this property it is possible to associate a specific information service type, e.g. 'social network service',
    /// 'recommender service' or 'encyclopedia', to an is:InfoService instance. This property could be used multiple times that means an
    /// is:InfoService instance could be for example of the information service type 'social network site' and 'recommender system'.</para>
    /// labels<para>has info service type</para></remarks>
    /// <seealso href="http://purl.org/ontology/is/core#info_service_type">http://purl.org/ontology/is/core#info_service_type</seealso>
    let info_service_type = Prefixed_Name(is, "info_service_type") |> PrefixedName
    /// <summary>
    ///   <para>is:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    /// </remarks>
    /// <seealso href="http://purl.org/ontology/is/core#">http://purl.org/ontology/is/core#</seealso>
    let _prefix_iri = Prefixed_Name(is, "") |> PrefixedName
    /// <summary>
    ///   <para>is:info_service</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>Every subject related by this property is made available by an is:InfoService individual. This property could be used to associate a semantic graph based description or especially a website link, e.g. typed as foaf:Document, to the specific is:InfoService individual. This enables the consumer of this resource to retrieve more information (descriptions, ratings) about the underlying information service of this resource.</para>
    /// labels<para>has info service</para></remarks>
    /// <seealso href="http://purl.org/ontology/is/core#info_service">http://purl.org/ontology/is/core#info_service</seealso>
    let info_service = Prefixed_Name(is, "info_service") |> PrefixedName
