namespace http.www.bbc.co.uk.ontologies.cms.slash

open DoxAletheia.Rdf_Vocabulary

module bbccms =
    let _namespace_name = "http://www.bbc.co.uk/ontologies/cms/"
    /// <summary>
    ///   <see href="http://www.bbc.co.uk/ontologies/cms/3.6"></see>
    /// </summary>
    let ``_3.6`` = Namespaced_IRI.parse _namespace_name "3.6" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.bbc.co.uk/ontologies/cms/3.7"></see>
    /// </summary>
    let ``_3.7`` = Namespaced_IRI.parse _namespace_name "3.7" |> NamespacedName
    /// <summary>
    /// This locator type is used for creating locators for the Content Publishing System which is largely used to create the News and Sport stories on the website.
    /// <see href="http://www.bbc.co.uk/ontologies/cms/CPSLocator"></see></summary>
    let CPSLocator = Namespaced_IRI.parse _namespace_name "CPSLocator" |> NamespacedName
    /// <summary>
    /// This class represents all identifiers required for locating a representation of the thing in another BBC system. Thing locators usually follow the pattern &lt;urn:LocatorType:localID&gt; for example &lt;urn:sports-stats:11269354&gt; or &lt;urn:cps:7f0da524-08bd-4d7e-848e-f50ccca6d87c&gt; (see the subclasses of Locator for all available locator types) where the last fragment of the URI is the native id of the system.
    /// <see href="http://www.bbc.co.uk/ontologies/cms/Locator"></see></summary>
    let Locator = Namespaced_IRI.parse _namespace_name "Locator" |> NamespacedName

    /// <summary>
    /// This class of locators is used to retrieve things through the Content API.
    /// <see href="http://www.bbc.co.uk/ontologies/cms/ContentApiLocator"></see></summary>
    let ContentApiLocator =
        Namespaced_IRI.parse _namespace_name "ContentApiLocator" |> NamespacedName

    /// <summary>
    /// The identifier for the linked data manager which will be used to denote the ownership of thing-graphs provided to LDP via the LDM.
    /// <see href="http://www.bbc.co.uk/ontologies/cms/LDM"></see></summary>
    let LDM = Namespaced_IRI.parse _namespace_name "LDM" |> NamespacedName
    /// <summary>
    /// This is the class of systems that manage data in the Linked Data Platform.
    /// <see href="http://www.bbc.co.uk/ontologies/cms/System"></see></summary>
    let System = Namespaced_IRI.parse _namespace_name "System" |> NamespacedName

    /// <summary>
    /// The identifier for location services which will be used to denote the ownership of location thing-graphs  provided to LDP via location services ingest.
    /// <see href="http://www.bbc.co.uk/ontologies/cms/LocationServicesIngest"></see></summary>
    let LocationServicesIngest =
        Namespaced_IRI.parse _namespace_name "LocationServicesIngest" |> NamespacedName

    /// <summary>
    /// This is needed to instantiate locators used by the Location Services Ingestion system.
    /// <see href="http://www.bbc.co.uk/ontologies/cms/LocationServicesLocator"></see></summary>
    let LocationServicesLocator =
        Namespaced_IRI.parse _namespace_name "LocationServicesLocator" |> NamespacedName

    /// <summary>
    /// This is the class of things managed by a data management system interfacing with thing graph. Anything declared as a ManagedThing is managed in thing graph as opposed to being managed in a dataset and a thing graph must contain exactly one managed thing.
    /// <see href="http://www.bbc.co.uk/ontologies/cms/ManagedThing"></see></summary>
    let ManagedThing =
        Namespaced_IRI.parse _namespace_name "ManagedThing" |> NamespacedName

    /// <summary>
    /// The identifier for the music artists management system which will be used to denote the ownership of music artists thing-graphs provided to LDP via the music artists ingest.
    /// <see href="http://www.bbc.co.uk/ontologies/cms/MusicArtistsIngest"></see></summary>
    let MusicArtistsIngest =
        Namespaced_IRI.parse _namespace_name "MusicArtistsIngest" |> NamespacedName

    /// <summary>
    /// This types is needed to instantiate locators used by the Music bootstrap service.
    /// <see href="http://www.bbc.co.uk/ontologies/cms/MusicBootstrapLocator"></see></summary>
    let MusicBootstrapLocator =
        Namespaced_IRI.parse _namespace_name "MusicBootstrapLocator" |> NamespacedName

    /// <summary>
    /// The identifier for the news instance data manager which will be used to denote the ownership of news relevant thing-graphs  provided to LDP via the NewsIDM.
    /// <see href="http://www.bbc.co.uk/ontologies/cms/NewsIDM"></see></summary>
    let NewsIDM = Namespaced_IRI.parse _namespace_name "NewsIDM" |> NamespacedName

    /// <summary>
    /// This locator type is used for creating locators for PIPS, the system that manages the Programmes Information Pages.
    /// <see href="http://www.bbc.co.uk/ontologies/cms/PipsLocator"></see></summary>
    let PipsLocator =
        Namespaced_IRI.parse _namespace_name "PipsLocator" |> NamespacedName

    /// <summary>
    /// This locator is used to create locators for Pulsar.
    /// <see href="http://www.bbc.co.uk/ontologies/cms/PulsarLocator"></see></summary>
    let PulsarLocator =
        Namespaced_IRI.parse _namespace_name "PulsarLocator" |> NamespacedName

    /// <summary>
    /// This locator is used to create locators for the sports-data system.
    /// <see href="http://www.bbc.co.uk/ontologies/cms/Sports-DataLocator"></see></summary>
    let ``Sports-DataLocator`` =
        Namespaced_IRI.parse _namespace_name "Sports-DataLocator" |> NamespacedName

    /// <summary>
    /// This locator is used to create locators for the sports-stats system.
    /// <see href="http://www.bbc.co.uk/ontologies/cms/Sports-StatsLocator"></see></summary>
    let ``Sports-StatsLocator`` =
        Namespaced_IRI.parse _namespace_name "Sports-StatsLocator" |> NamespacedName

    /// <summary>
    /// This locator is used to identify categories in the Things To Do API.
    /// <see href="http://www.bbc.co.uk/ontologies/cms/TTDLocator"></see></summary>
    let TTDLocator = Namespaced_IRI.parse _namespace_name "TTDLocator" |> NamespacedName

    /// <summary>
    /// This class of locators is used to retrieve things through the Travel API.
    /// <see href="http://www.bbc.co.uk/ontologies/cms/TravelLocator"></see></summary>
    let TravelLocator =
        Namespaced_IRI.parse _namespace_name "TravelLocator" |> NamespacedName

    /// <summary>
    /// This class of locators is used to retrieve things through the Vivo API.
    /// <see href="http://www.bbc.co.uk/ontologies/cms/VivoApiLocator"></see></summary>
    let VivoApiLocator =
        Namespaced_IRI.parse _namespace_name "VivoApiLocator" |> NamespacedName

    /// <summary>
    /// This class of locators is used to retrieve things through the Weather API.
    /// <see href="http://www.bbc.co.uk/ontologies/cms/WeatherLocator"></see></summary>
    let WeatherLocator =
        Namespaced_IRI.parse _namespace_name "WeatherLocator" |> NamespacedName

    /// <summary>
    /// This locator is used identify content from Knowledge and Learning.
    /// <see href="http://www.bbc.co.uk/ontologies/cms/iKLLocator"></see></summary>
    let iKLLocator = Namespaced_IRI.parse _namespace_name "iKLLocator" |> NamespacedName

    /// <summary>
    /// This class of locators is used to retrieve things sent to LDP from iScript.
    /// <see href="http://www.bbc.co.uk/ontologies/cms/iScriptLocator"></see></summary>
    let iScriptLocator =
        Namespaced_IRI.parse _namespace_name "iScriptLocator" |> NamespacedName

    /// <summary>
    /// This locator is used identify content from iSite.
    /// <see href="http://www.bbc.co.uk/ontologies/cms/iSiteLocator"></see></summary>
    let iSiteLocator =
        Namespaced_IRI.parse _namespace_name "iSiteLocator" |> NamespacedName

    /// <summary>
    /// Associates a thing or creative work with a locator in a CMS.
    /// <see href="http://www.bbc.co.uk/ontologies/cms/locator"></see></summary>
    let locator = Namespaced_IRI.parse _namespace_name "locator" |> NamespacedName

    /// <summary>
    /// This property is needed to express the relationship between a cms:ManagedThing and its graph in the API results. In the triplestore the ThingGraph is implicitly related to the ManagedThing because the ThingGraph contains the ManagedThing metadata. However, we need an explicit relationship to provide this to our API clients and this is the purpose of cms:managedThing.
    /// <see href="http://www.bbc.co.uk/ontologies/cms/managedThing"></see></summary>
    let managedThing =
        Namespaced_IRI.parse _namespace_name "managedThing" |> NamespacedName
