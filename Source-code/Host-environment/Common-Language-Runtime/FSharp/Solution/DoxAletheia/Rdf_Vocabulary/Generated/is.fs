namespace http.purl.org.ontology.is.core.hash

open DoxAletheia

module is =
    let _namespace_name = "http://purl.org/ontology/is/core#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// Extended definition:
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
    /// [1] https://infoserviceonto.wordpress.com/2010/06/23/what-is-an-information-service/
    /// <see href="http://purl.org/ontology/is/core#InfoService"></see></summary>
    let InfoService = _prefix "InfoService"
    /// <summary>
    /// This concept is for describing the different contributor types of information services, e.g. expert,
    /// community or mixed. Please feel free to define further information service contributor types.
    /// Please use therefore the namespace "http://purl.org/ontology/is/ctypes/".
    /// <see href="http://purl.org/ontology/is/core#InfoServiceContributorType"></see></summary>
    let InfoServiceContributorType = _prefix "InfoServiceContributorType"
    /// <summary>
    /// This concept is for describing specific quality levels or ratings, e.g. good or bad or more detailed ones, of
    /// information services. Please feel free to use this concept as hook for more complex and detailed information service quality description
    /// modellings in sub ontologies. Please use therefore the domain "http://purl.org/ontology/is/quality/". Futhermore, such information
    /// service ratings could be done by different information service rating agencies, so that the customer of such ratings could select
    /// its information service ratings agency of choice.
    /// <see href="http://purl.org/ontology/is/core#InfoServiceQuality"></see></summary>
    let InfoServiceQuality = _prefix "InfoServiceQuality"
    /// <summary>
    /// This concept is for describing the type of an information service, e.g. 'social network service',
    /// 'recommender service' or 'encyclopedia'. Please feel free to define further information service types for categorization.
    /// Please use therefore the namespace "http://purl.org/ontology/is/types/".
    /// <see href="http://purl.org/ontology/is/core#InfoServiceType"></see></summary>
    let InfoServiceType = _prefix "InfoServiceType"
    /// <summary>
    /// Every subject related by this property is made available by an is:InfoService individual. This property could be used to associate a semantic graph based description or especially a website link, e.g. typed as foaf:Document, to the specific is:InfoService individual. This enables the consumer of this resource to retrieve more information (descriptions, ratings) about the underlying information service of this resource.
    /// <see href="http://purl.org/ontology/is/core#info_service"></see></summary>
    let info_service = _prefix "info_service"
    /// <summary>
    /// With this property it is possible to associate a specific information service contributor type, e.g. expert,
    /// community or mixed, to an is:InfoService instance.
    /// <see href="http://purl.org/ontology/is/core#info_service_contributor_type"></see></summary>
    let info_service_contributor_type = _prefix "info_service_contributor_type"
    /// <summary>
    /// With this property it is possible to associate a specific quality level, information service quality rating
    /// or an extended information service quality description to an is:InfoService instance
    /// <see href="http://purl.org/ontology/is/core#info_service_quality"></see></summary>
    let info_service_quality = _prefix "info_service_quality"
    /// <summary>
    /// With this property it is possible to associate a specific information service type, e.g. 'social network service',
    /// 'recommender service' or 'encyclopedia', to an is:InfoService instance. This property could be used multiple times that means an
    /// is:InfoService instance could be for example of the information service type 'social network site' and 'recommender system'.
    /// <see href="http://purl.org/ontology/is/core#info_service_type"></see></summary>
    let info_service_type = _prefix "info_service_type"
    /// <summary>
    /// This property is for defining the main subject of an is:InfoService instance that means this
    /// info service address mainly this concern.
    /// <see href="http://purl.org/ontology/is/core#main_subject"></see></summary>
    let main_subject = _prefix "main_subject"
