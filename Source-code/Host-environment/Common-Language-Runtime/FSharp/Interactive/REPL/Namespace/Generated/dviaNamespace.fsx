#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module dvia =
    let _prefixId = PrefixId.fromNamespaceLabel "http://purl.org/ontology/dvia#" "dvia"
    /// <summary>
    ///   <para>rdfs:label : Applicationrdfs:label : Application</para>
    ///   <para>rdfs:comment : The aplication or the mashup developed for demo-ing or consuming data in LD fashion</para>
    ///   <a href="http://purl.org/ontology/dvia#Application">dvia:Application</a>
    /// </summary>
    let Application = _prefixId.prefix "Application"
    /// <summary>
    ///   <para>rdfs:label : Platformrdfs:label : Plate forme</para>
    ///   <para>rdfs:comment : The platform where to host or use the application, could be on the web (firefox, chrome, IE, etc..) or mobile (android, etc..) or event desktop</para>
    ///   <a href="http://purl.org/ontology/dvia#Platform">dvia:Platform</a>
    /// </summary>
    let Platform = _prefixId.prefix "Platform"
    /// <summary>
    ///   <para>rdfs:label : Outil de visualisationrdfs:label : visual Tool</para>
    ///   <para>rdfs:comment : The tool or library used to build the application</para>
    ///   <a href="http://purl.org/ontology/dvia#VisualTool">dvia:VisualTool</a>
    /// </summary>
    let VisualTool = _prefixId.prefix "VisualTool"
    /// <summary>
    ///   <para>rdfs:label : navigateur alternatifrdfs:label : alternative navigator</para>
    ///   <para>rdfs:comment : The name of the alternate navigator if applicable</para>
    ///   <a href="http://purl.org/ontology/dvia#alternativeNavigator">dvia:alternativeNavigator</a>
    /// </summary>
    let alternativeNavigator = _prefixId.prefix "alternativeNavigator"
    /// <summary>
    ///   <para>rdfs:label : auteurrdfs:label : author</para>
    ///   <para>rdfs:comment : links to the authors of the application or the tools, libraries</para>
    ///   <a href="http://purl.org/ontology/dvia#author">dvia:author</a>
    /// </summary>
    let author = _prefixId.prefix "author"
    /// <summary>
    ///   <para>rdfs:label : valeur commercialerdfs:label : businessValue</para>
    ///   <para>rdfs:comment : The business value of the application; generally could be commercial of free. Also depending on the license</para>
    ///   <a href="http://purl.org/ontology/dvia#businessValue">dvia:businessValue</a>
    /// </summary>
    let businessValue = _prefixId.prefix "businessValue"
    /// <summary>
    ///   <para>rdfs:label : consommerdfs:label : consumes</para>
    ///   <para>rdfs:comment : links to the dataset used to make the application, and could be of different types or formats</para>
    ///   <a href="http://purl.org/ontology/dvia#consumes">dvia:consumes</a>
    /// </summary>
    let consumes = _prefixId.prefix "consumes"
    /// <summary>
    ///   <para>rdfs:label : dataset descriptionrdfs:label : description du jeu de donn�es</para>
    ///   <para>rdfs:comment : Property for a given descriptive informations of the datasets used for making the application. It could be used when no more details are given on the datasets like URL, formats, etc.</para>
    ///   <a href="http://purl.org/ontology/dvia#datasetDescription">dvia:datasetDescription</a>
    /// </summary>
    let datasetDescription = _prefixId.prefix "datasetDescription"
    /// <summary>
    ///   <para>rdfs:label : impl�menter parrdfs:label : design By</para>
    ///   <para>rdfs:comment : links to the organization which builds the application</para>
    ///   <a href="http://purl.org/ontology/dvia#designBy">dvia:designBy</a>
    /// </summary>
    let designBy = _prefixId.prefix "designBy"
    /// <summary>
    ///   <para>rdfs:label : url t�l�chargementrdfs:label : download url</para>
    ///   <para>rdfs:comment : The download url of the tool for visualization.</para>
    ///   <a href="http://purl.org/ontology/dvia#downloadUrl">dvia:downloadUrl</a>
    /// </summary>
    let downloadUrl = _prefixId.prefix "downloadUrl"
    /// <summary>
    ///   <para>rdfs:label : a pour licenserdfs:label : hasLicense</para>
    ///   <para>rdfs:comment : This property links to the license of the application</para>
    ///   <a href="http://purl.org/ontology/dvia#hasLicense">dvia:hasLicense</a>
    /// </summary>
    let hasLicense = _prefixId.prefix "hasLicense"
    /// <summary>
    ///   <para>rdfs:label : mot cl�rdfs:label : keyword</para>
    ///   <para>rdfs:comment : keywords used for the application.</para>
    ///   <a href="http://purl.org/ontology/dvia#keyword">dvia:keyword</a>
    /// </summary>
    let keyword = _prefixId.prefix "keyword"
    /// <summary>
    ///   <para>rdfs:label : url de la librairierdfs:label : library url</para>
    ///   <para>rdfs:comment : The url to the page describing the library or the tool for visualization.</para>
    ///   <a href="http://purl.org/ontology/dvia#libUrl">dvia:libUrl</a>
    /// </summary>
    let libUrl = _prefixId.prefix "libUrl"
    /// <summary>
    ///   <para>rdfs:label : plate formerdfs:label : platform</para>
    ///   <para>rdfs:comment : This property links the application to a platform to actually use the application.</para>
    ///   <a href="http://purl.org/ontology/dvia#platform">dvia:platform</a>
    /// </summary>
    let platform = _prefixId.prefix "platform"
    /// <summary>
    ///   <para>rdfs:label : navigateur pr�f�rr�rdfs:label : preferred navigator</para>
    ///   <para>rdfs:comment : The name of the preferred navigator to be usd by the application</para>
    ///   <a href="http://purl.org/ontology/dvia#preferredNavigator">dvia:preferredNavigator</a>
    /// </summary>
    let preferredNavigator = _prefixId.prefix "preferredNavigator"
    /// <summary>
    ///   <para>rdfs:label : domain d'usagerdfs:label : scope</para>
    ///   <para>rdfs:comment : The scope or domain of the application.</para>
    ///   <a href="http://purl.org/ontology/dvia#scope">dvia:scope</a>
    /// </summary>
    let scope = _prefixId.prefix "scope"
    /// <summary>
    ///   <para>rdfs:label : syst�merdfs:label : system</para>
    ///   <para>rdfs:comment : The operating system where the application runs.</para>
    ///   <a href="http://purl.org/ontology/dvia#system">dvia:system</a>
    /// </summary>
    let system = _prefixId.prefix "system"
    /// <summary>
    ///   <para>rdfs:label : urlrdfs:label : url</para>
    ///   <para>rdfs:comment : the url of the application.</para>
    ///   <a href="http://purl.org/ontology/dvia#url">dvia:url</a>
    /// </summary>
    let url = _prefixId.prefix "url"
    /// <summary>
    ///   <para>rdfs:label : utilise l'outilrdfs:label : uses Tool</para>
    ///   <para>rdfs:comment : This property links to the tools or libraries used for the application</para>
    ///   <a href="http://purl.org/ontology/dvia#usesTool">dvia:usesTool</a>
    /// </summary>
    let usesTool = _prefixId.prefix "usesTool"
    /// <summary>
    ///   <para>rdfs:label : vuerdfs:label : view</para>
    ///   <para>rdfs:comment : The types of view available in the application, such as maps, charts, graphs, etc.</para>
    ///   <a href="http://purl.org/ontology/dvia#view">dvia:view</a>
    /// </summary>
    let view = _prefixId.prefix "view"
