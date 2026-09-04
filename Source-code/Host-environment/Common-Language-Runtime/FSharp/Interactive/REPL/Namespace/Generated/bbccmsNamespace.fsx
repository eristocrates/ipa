#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module bbccms =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://www.bbc.co.uk/ontologies/cms/" "bbccms"

    let ``_3.6`` = _prefixId.prefix "3.6"
    let ``_3.7`` = _prefixId.prefix "3.7"
    /// <summary>
    ///   <para>rdfs:label : CPSLocator</para>
    ///   <para>rdfs:comment : This locator type is used for creating locators for the Content Publishing System which is largely used to create the News and Sport stories on the website.</para>
    ///   <a href="http://www.bbc.co.uk/ontologies/cms/CPSLocator">bbccms:CPSLocator</a>
    /// </summary>
    let CPSLocator = _prefixId.prefix "CPSLocator"
    /// <summary>
    ///   <para>rdfs:label : ContentApiLocator</para>
    ///   <para>rdfs:comment : This class of locators is used to retrieve things through the Content API.</para>
    ///   <a href="http://www.bbc.co.uk/ontologies/cms/ContentApiLocator">bbccms:ContentApiLocator</a>
    /// </summary>
    let ContentApiLocator = _prefixId.prefix "ContentApiLocator"
    let LDM = _prefixId.prefix "LDM"
    let LocationServicesIngest = _prefixId.prefix "LocationServicesIngest"
    /// <summary>
    ///   <para>rdfs:label : LocationServicesLocator</para>
    ///   <para>rdfs:comment : This is needed to instantiate locators used by the Location Services Ingestion system.</para>
    ///   <a href="http://www.bbc.co.uk/ontologies/cms/LocationServicesLocator">bbccms:LocationServicesLocator</a>
    /// </summary>
    let LocationServicesLocator = _prefixId.prefix "LocationServicesLocator"
    /// <summary>
    ///   <para>rdfs:label : Locator</para>
    ///   <para>rdfs:comment : This class represents all identifiers required for locating a representation of the thing in another BBC system. Thing locators usually follow the pattern &lt;urn:LocatorType:localID&gt; for example &lt;urn:sports-stats:11269354&gt; or &lt;urn:cps:7f0da524-08bd-4d7e-848e-f50ccca6d87c&gt; (see the subclasses of Locator for all available locator types) where the last fragment of the URI is the native id of the system.</para>
    ///   <a href="http://www.bbc.co.uk/ontologies/cms/Locator">bbccms:Locator</a>
    /// </summary>
    let Locator = _prefixId.prefix "Locator"
    /// <summary>
    ///   <para>rdfs:label : ManagedThing</para>
    ///   <para>rdfs:comment : This is the class of things managed by a data management system interfacing with thing graph. Anything declared as a ManagedThing is managed in thing graph as opposed to being managed in a dataset and a thing graph must contain exactly one managed thing.</para>
    ///   <a href="http://www.bbc.co.uk/ontologies/cms/ManagedThing">bbccms:ManagedThing</a>
    /// </summary>
    let ManagedThing = _prefixId.prefix "ManagedThing"
    let MusicArtistsIngest = _prefixId.prefix "MusicArtistsIngest"
    /// <summary>
    ///   <para>rdfs:label : MusicBootstrapLocator</para>
    ///   <para>rdfs:comment : This types is needed to instantiate locators used by the Music bootstrap service.</para>
    ///   <a href="http://www.bbc.co.uk/ontologies/cms/MusicBootstrapLocator">bbccms:MusicBootstrapLocator</a>
    /// </summary>
    let MusicBootstrapLocator = _prefixId.prefix "MusicBootstrapLocator"
    let NewsIDM = _prefixId.prefix "NewsIDM"
    /// <summary>
    ///   <para>rdfs:label : PipsLocator</para>
    ///   <para>rdfs:comment : This locator type is used for creating locators for PIPS, the system that manages the Programmes Information Pages.</para>
    ///   <a href="http://www.bbc.co.uk/ontologies/cms/PipsLocator">bbccms:PipsLocator</a>
    /// </summary>
    let PipsLocator = _prefixId.prefix "PipsLocator"
    /// <summary>
    ///   <para>rdfs:label : PulsarLocator</para>
    ///   <para>rdfs:comment : This locator is used to create locators for Pulsar.</para>
    ///   <a href="http://www.bbc.co.uk/ontologies/cms/PulsarLocator">bbccms:PulsarLocator</a>
    /// </summary>
    let PulsarLocator = _prefixId.prefix "PulsarLocator"
    /// <summary>
    ///   <para>rdfs:label : Sports-DataLocator</para>
    ///   <para>rdfs:comment : This locator is used to create locators for the sports-data system.</para>
    ///   <a href="http://www.bbc.co.uk/ontologies/cms/Sports-DataLocator">bbccms:Sports-DataLocator</a>
    /// </summary>
    let Sports_DataLocator = _prefixId.prefix "Sports-DataLocator"
    /// <summary>
    ///   <para>rdfs:label : Sports-StatsLocator</para>
    ///   <para>rdfs:comment : This locator is used to create locators for the sports-stats system.</para>
    ///   <a href="http://www.bbc.co.uk/ontologies/cms/Sports-StatsLocator">bbccms:Sports-StatsLocator</a>
    /// </summary>
    let Sports_StatsLocator = _prefixId.prefix "Sports-StatsLocator"
    /// <summary>
    ///   <para>rdfs:label : System</para>
    ///   <para>rdfs:comment : This is the class of systems that manage data in the Linked Data Platform.</para>
    ///   <a href="http://www.bbc.co.uk/ontologies/cms/System">bbccms:System</a>
    /// </summary>
    let System = _prefixId.prefix "System"
    /// <summary>
    ///   <para>rdfs:label : TTDLocator</para>
    ///   <para>rdfs:comment : This locator is used to identify categories in the Things To Do API.</para>
    ///   <a href="http://www.bbc.co.uk/ontologies/cms/TTDLocator">bbccms:TTDLocator</a>
    /// </summary>
    let TTDLocator = _prefixId.prefix "TTDLocator"
    /// <summary>
    ///   <para>rdfs:label : TravelLocator</para>
    ///   <para>rdfs:comment : This class of locators is used to retrieve things through the Travel API.</para>
    ///   <a href="http://www.bbc.co.uk/ontologies/cms/TravelLocator">bbccms:TravelLocator</a>
    /// </summary>
    let TravelLocator = _prefixId.prefix "TravelLocator"
    /// <summary>
    ///   <para>rdfs:label : VivoApiLocator</para>
    ///   <para>rdfs:comment : This class of locators is used to retrieve things through the Vivo API.</para>
    ///   <a href="http://www.bbc.co.uk/ontologies/cms/VivoApiLocator">bbccms:VivoApiLocator</a>
    /// </summary>
    let VivoApiLocator = _prefixId.prefix "VivoApiLocator"
    /// <summary>
    ///   <para>rdfs:label : WeatherLocator</para>
    ///   <para>rdfs:comment : This class of locators is used to retrieve things through the Weather API.</para>
    ///   <a href="http://www.bbc.co.uk/ontologies/cms/WeatherLocator">bbccms:WeatherLocator</a>
    /// </summary>
    let WeatherLocator = _prefixId.prefix "WeatherLocator"
    /// <summary>
    ///   <para>rdfs:label : iKLLocator</para>
    ///   <para>rdfs:comment : This locator is used identify content from Knowledge and Learning.</para>
    ///   <a href="http://www.bbc.co.uk/ontologies/cms/iKLLocator">bbccms:iKLLocator</a>
    /// </summary>
    let iKLLocator = _prefixId.prefix "iKLLocator"
    /// <summary>
    ///   <para>rdfs:label : iScriptLocator</para>
    ///   <para>rdfs:comment : This class of locators is used to retrieve things sent to LDP from iScript.</para>
    ///   <a href="http://www.bbc.co.uk/ontologies/cms/iScriptLocator">bbccms:iScriptLocator</a>
    /// </summary>
    let iScriptLocator = _prefixId.prefix "iScriptLocator"
    /// <summary>
    ///   <para>rdfs:label : iSiteLocator</para>
    ///   <para>rdfs:comment : This locator is used identify content from iSite.</para>
    ///   <a href="http://www.bbc.co.uk/ontologies/cms/iSiteLocator">bbccms:iSiteLocator</a>
    /// </summary>
    let iSiteLocator = _prefixId.prefix "iSiteLocator"
    /// <summary>
    ///   <para>rdfs:label : locator</para>
    ///   <para>rdfs:comment : Associates a thing or creative work with a locator in a CMS.</para>
    ///   <a href="http://www.bbc.co.uk/ontologies/cms/locator">bbccms:locator</a>
    /// </summary>
    let locator = _prefixId.prefix "locator"
    /// <summary>
    ///   <para>rdfs:label : managedThing</para>
    ///   <para>rdfs:comment : This property is needed to express the relationship between a cms:ManagedThing and its graph in the API results. In the triplestore the ThingGraph is implicitly related to the ManagedThing because the ThingGraph contains the ManagedThing metadata. However, we need an explicit relationship to provide this to our API clients and this is the purpose of cms:managedThing.</para>
    ///   <a href="http://www.bbc.co.uk/ontologies/cms/managedThing">bbccms:managedThing</a>
    /// </summary>
    let managedThing = _prefixId.prefix "managedThing"
