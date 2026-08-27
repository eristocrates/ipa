namespace http.www.bbc.co.uk.ontologies.cms.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module bbccms =
    let _namespace_iri = Namespace_Iri bbccms |> NamespaceIRI
    /// <summary>
    ///   <para>bbccms:3.6</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.bbc.co.uk/ontologies/cms/3.6">http://www.bbc.co.uk/ontologies/cms/3.6</seealso>
    let ``_3.6`` = Prefixed_Name(bbccms, "3.6") |> PrefixedName
    /// <summary>
    ///   <para>bbccms:3.7</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.bbc.co.uk/ontologies/cms/3.7">http://www.bbc.co.uk/ontologies/cms/3.7</seealso>
    let ``_3.7`` = Prefixed_Name(bbccms, "3.7") |> PrefixedName
    /// <summary>
    ///   <para>bbccms:CPSLocator</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This locator type is used for creating locators for the Content Publishing System which is largely used to create the News and Sport stories on the website."</para>
    /// labels<para>"CPSLocator"</para></remarks>
    /// <seealso href="http://www.bbc.co.uk/ontologies/cms/CPSLocator">http://www.bbc.co.uk/ontologies/cms/CPSLocator</seealso>
    let CPSLocator = Prefixed_Name(bbccms, "CPSLocator") |> PrefixedName
    /// <summary>
    ///   <para>bbccms:ContentApiLocator</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class of locators is used to retrieve things through the Content API."</para>
    /// labels<para>"ContentApiLocator"</para></remarks>
    /// <seealso href="http://www.bbc.co.uk/ontologies/cms/ContentApiLocator">http://www.bbc.co.uk/ontologies/cms/ContentApiLocator</seealso>
    let ContentApiLocator = Prefixed_Name(bbccms, "ContentApiLocator") |> PrefixedName
    /// <summary>
    ///   <para>bbccms:LDM</para>
    /// </summary>
    /// <remarks>
    ///   <para>bbccms:System</para>
    ///   <para>"The identifier for the linked data manager which will be used to denote the ownership of thing-graphs provided to LDP via the LDM."</para>
    /// labels<para>"LDM"</para></remarks>
    /// <seealso href="http://www.bbc.co.uk/ontologies/cms/LDM">http://www.bbc.co.uk/ontologies/cms/LDM</seealso>
    let LDM = Prefixed_Name(bbccms, "LDM") |> PrefixedName

    /// <summary>
    ///   <para>bbccms:LocationServicesIngest</para>
    /// </summary>
    /// <remarks>
    ///   <para>bbccms:System</para>
    ///   <para>"The identifier for location services which will be used to denote the ownership of location thing-graphs  provided to LDP via location services ingest."</para>
    /// labels<para>"LocationServicesIngest"</para></remarks>
    /// <seealso href="http://www.bbc.co.uk/ontologies/cms/LocationServicesIngest">http://www.bbc.co.uk/ontologies/cms/LocationServicesIngest</seealso>
    let LocationServicesIngest =
        Prefixed_Name(bbccms, "LocationServicesIngest") |> PrefixedName

    /// <summary>
    ///   <para>bbccms:LocationServicesLocator</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This is needed to instantiate locators used by the Location Services Ingestion system."</para>
    /// labels<para>"LocationServicesLocator"</para></remarks>
    /// <seealso href="http://www.bbc.co.uk/ontologies/cms/LocationServicesLocator">http://www.bbc.co.uk/ontologies/cms/LocationServicesLocator</seealso>
    let LocationServicesLocator =
        Prefixed_Name(bbccms, "LocationServicesLocator") |> PrefixedName

    /// <summary>
    ///   <para>bbccms:Locator</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class represents all identifiers required for locating a representation of the thing in another BBC system. Thing locators usually follow the pattern &lt;urn:LocatorType:localID&gt; for example &lt;urn:sports-stats:11269354&gt; or &lt;urn:cps:7f0da524-08bd-4d7e-848e-f50ccca6d87c&gt; (see the subclasses of Locator for all available locator types) where the last fragment of the URI is the native id of the system."</para>
    /// labels<para>"Locator"</para></remarks>
    /// <seealso href="http://www.bbc.co.uk/ontologies/cms/Locator">http://www.bbc.co.uk/ontologies/cms/Locator</seealso>
    let Locator = Prefixed_Name(bbccms, "Locator") |> PrefixedName
    /// <summary>
    ///   <para>bbccms:ManagedThing</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This is the class of things managed by a data management system interfacing with thing graph. Anything declared as a ManagedThing is managed in thing graph as opposed to being managed in a dataset and a thing graph must contain exactly one managed thing."</para>
    /// labels<para>"ManagedThing"</para></remarks>
    /// <seealso href="http://www.bbc.co.uk/ontologies/cms/ManagedThing">http://www.bbc.co.uk/ontologies/cms/ManagedThing</seealso>
    let ManagedThing = Prefixed_Name(bbccms, "ManagedThing") |> PrefixedName
    /// <summary>
    ///   <para>bbccms:MusicArtistsIngest</para>
    /// </summary>
    /// <remarks>
    ///   <para>bbccms:System</para>
    ///   <para>"The identifier for the music artists management system which will be used to denote the ownership of music artists thing-graphs provided to LDP via the music artists ingest."</para>
    /// labels<para>"MusicArtistsIngest"</para></remarks>
    /// <seealso href="http://www.bbc.co.uk/ontologies/cms/MusicArtistsIngest">http://www.bbc.co.uk/ontologies/cms/MusicArtistsIngest</seealso>
    let MusicArtistsIngest = Prefixed_Name(bbccms, "MusicArtistsIngest") |> PrefixedName

    /// <summary>
    ///   <para>bbccms:MusicBootstrapLocator</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This types is needed to instantiate locators used by the Music bootstrap service."</para>
    /// labels<para>"MusicBootstrapLocator"</para></remarks>
    /// <seealso href="http://www.bbc.co.uk/ontologies/cms/MusicBootstrapLocator">http://www.bbc.co.uk/ontologies/cms/MusicBootstrapLocator</seealso>
    let MusicBootstrapLocator =
        Prefixed_Name(bbccms, "MusicBootstrapLocator") |> PrefixedName

    /// <summary>
    ///   <para>bbccms:NewsIDM</para>
    /// </summary>
    /// <remarks>
    ///   <para>bbccms:System</para>
    ///   <para>"The identifier for the news instance data manager which will be used to denote the ownership of news relevant thing-graphs  provided to LDP via the NewsIDM."</para>
    /// labels<para>"NewsIDM"</para></remarks>
    /// <seealso href="http://www.bbc.co.uk/ontologies/cms/NewsIDM">http://www.bbc.co.uk/ontologies/cms/NewsIDM</seealso>
    let NewsIDM = Prefixed_Name(bbccms, "NewsIDM") |> PrefixedName
    /// <summary>
    ///   <para>bbccms:PipsLocator</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This locator type is used for creating locators for PIPS, the system that manages the Programmes Information Pages."</para>
    /// labels<para>"PipsLocator"</para></remarks>
    /// <seealso href="http://www.bbc.co.uk/ontologies/cms/PipsLocator">http://www.bbc.co.uk/ontologies/cms/PipsLocator</seealso>
    let PipsLocator = Prefixed_Name(bbccms, "PipsLocator") |> PrefixedName
    /// <summary>
    ///   <para>bbccms:PulsarLocator</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This locator is used to create locators for Pulsar."</para>
    /// labels<para>"PulsarLocator"</para></remarks>
    /// <seealso href="http://www.bbc.co.uk/ontologies/cms/PulsarLocator">http://www.bbc.co.uk/ontologies/cms/PulsarLocator</seealso>
    let PulsarLocator = Prefixed_Name(bbccms, "PulsarLocator") |> PrefixedName
    /// <summary>
    ///   <para>bbccms:Sports-DataLocator</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This locator is used to create locators for the sports-data system."</para>
    /// labels<para>"Sports-DataLocator"</para></remarks>
    /// <seealso href="http://www.bbc.co.uk/ontologies/cms/Sports-DataLocator">http://www.bbc.co.uk/ontologies/cms/Sports-DataLocator</seealso>
    let Sports_DataLocator = Prefixed_Name(bbccms, "Sports-DataLocator") |> PrefixedName

    /// <summary>
    ///   <para>bbccms:Sports-StatsLocator</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This locator is used to create locators for the sports-stats system."</para>
    /// labels<para>"Sports-StatsLocator"</para></remarks>
    /// <seealso href="http://www.bbc.co.uk/ontologies/cms/Sports-StatsLocator">http://www.bbc.co.uk/ontologies/cms/Sports-StatsLocator</seealso>
    let Sports_StatsLocator =
        Prefixed_Name(bbccms, "Sports-StatsLocator") |> PrefixedName

    /// <summary>
    ///   <para>bbccms:System</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This is the class of systems that manage data in the Linked Data Platform."</para>
    /// labels<para>"System"</para></remarks>
    /// <seealso href="http://www.bbc.co.uk/ontologies/cms/System">http://www.bbc.co.uk/ontologies/cms/System</seealso>
    let System = Prefixed_Name(bbccms, "System") |> PrefixedName
    /// <summary>
    ///   <para>bbccms:TTDLocator</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This locator is used to identify categories in the Things To Do API."</para>
    /// labels<para>"TTDLocator"</para></remarks>
    /// <seealso href="http://www.bbc.co.uk/ontologies/cms/TTDLocator">http://www.bbc.co.uk/ontologies/cms/TTDLocator</seealso>
    let TTDLocator = Prefixed_Name(bbccms, "TTDLocator") |> PrefixedName
    /// <summary>
    ///   <para>bbccms:TravelLocator</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class of locators is used to retrieve things through the Travel API."</para>
    /// labels<para>"TravelLocator"</para></remarks>
    /// <seealso href="http://www.bbc.co.uk/ontologies/cms/TravelLocator">http://www.bbc.co.uk/ontologies/cms/TravelLocator</seealso>
    let TravelLocator = Prefixed_Name(bbccms, "TravelLocator") |> PrefixedName
    /// <summary>
    ///   <para>bbccms:VivoApiLocator</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class of locators is used to retrieve things through the Vivo API."</para>
    /// labels<para>"VivoApiLocator"</para></remarks>
    /// <seealso href="http://www.bbc.co.uk/ontologies/cms/VivoApiLocator">http://www.bbc.co.uk/ontologies/cms/VivoApiLocator</seealso>
    let VivoApiLocator = Prefixed_Name(bbccms, "VivoApiLocator") |> PrefixedName
    /// <summary>
    ///   <para>bbccms:WeatherLocator</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class of locators is used to retrieve things through the Weather API."</para>
    /// labels<para>"WeatherLocator"</para></remarks>
    /// <seealso href="http://www.bbc.co.uk/ontologies/cms/WeatherLocator">http://www.bbc.co.uk/ontologies/cms/WeatherLocator</seealso>
    let WeatherLocator = Prefixed_Name(bbccms, "WeatherLocator") |> PrefixedName
    /// <summary>
    ///   <para>bbccms:iKLLocator</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This locator is used identify content from Knowledge and Learning."</para>
    /// labels<para>"iKLLocator"</para></remarks>
    /// <seealso href="http://www.bbc.co.uk/ontologies/cms/iKLLocator">http://www.bbc.co.uk/ontologies/cms/iKLLocator</seealso>
    let iKLLocator = Prefixed_Name(bbccms, "iKLLocator") |> PrefixedName
    /// <summary>
    ///   <para>bbccms:iScriptLocator</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class of locators is used to retrieve things sent to LDP from iScript."</para>
    /// labels<para>"iScriptLocator"</para></remarks>
    /// <seealso href="http://www.bbc.co.uk/ontologies/cms/iScriptLocator">http://www.bbc.co.uk/ontologies/cms/iScriptLocator</seealso>
    let iScriptLocator = Prefixed_Name(bbccms, "iScriptLocator") |> PrefixedName
    /// <summary>
    ///   <para>bbccms:iSiteLocator</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This locator is used identify content from iSite."</para>
    /// labels<para>"iSiteLocator"</para></remarks>
    /// <seealso href="http://www.bbc.co.uk/ontologies/cms/iSiteLocator">http://www.bbc.co.uk/ontologies/cms/iSiteLocator</seealso>
    let iSiteLocator = Prefixed_Name(bbccms, "iSiteLocator") |> PrefixedName
    /// <summary>
    ///   <para>bbccms:locator</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Associates a thing or creative work with a locator in a CMS."</para>
    /// labels<para>"locator"</para></remarks>
    /// <seealso href="http://www.bbc.co.uk/ontologies/cms/locator">http://www.bbc.co.uk/ontologies/cms/locator</seealso>
    let locator = Prefixed_Name(bbccms, "locator") |> PrefixedName
    /// <summary>
    ///   <para>bbccms:managedThing</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property is needed to express the relationship between a cms:ManagedThing and its graph in the API results. In the triplestore the ThingGraph is implicitly related to the ManagedThing because the ThingGraph contains the ManagedThing metadata. However, we need an explicit relationship to provide this to our API clients and this is the purpose of cms:managedThing."</para>
    /// labels<para>"managedThing"</para></remarks>
    /// <seealso href="http://www.bbc.co.uk/ontologies/cms/managedThing">http://www.bbc.co.uk/ontologies/cms/managedThing</seealso>
    let managedThing = Prefixed_Name(bbccms, "managedThing") |> PrefixedName
