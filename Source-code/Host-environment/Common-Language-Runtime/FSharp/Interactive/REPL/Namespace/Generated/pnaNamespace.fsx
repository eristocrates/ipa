#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module pna =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://data.press.net/ontology/asset/" "pna"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:comment : Generic News Asset Class</para>
    ///   <para>rdfs:label : Generic Asset Class</para>
    ///   <a href="http://data.press.net/ontology/asset/Asset">pna:Asset</a>
    /// </summary>
    let Asset = _prefixId.prefix "Asset"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:comment : Image Asset Class</para>
    ///   <para>rdfs:label : Image Asset Class</para>
    ///   <a href="http://data.press.net/ontology/asset/Image">pna:Image</a>
    /// </summary>
    let Image = _prefixId.prefix "Image"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:comment : Text Asset Class</para>
    ///   <para>rdfs:label : Text Asset Class</para>
    ///   <a href="http://data.press.net/ontology/asset/Text">pna:Text</a>
    /// </summary>
    let Text = _prefixId.prefix "Text"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:comment : Video Asset Class</para>
    ///   <para>rdfs:label : Video Asset Class</para>
    ///   <a href="http://data.press.net/ontology/asset/Video">pna:Video</a>
    /// </summary>
    let Video = _prefixId.prefix "Video"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:comment : Property that associates one asset with another asset</para>
    ///   <para>rdfs:label : Property that associates one asset with another asset</para>
    ///   <a href="http://data.press.net/ontology/asset/associatedAsset">pna:associatedAsset</a>
    /// </summary>
    let associatedAsset = _prefixId.prefix "associatedAsset"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:comment : The byline of a news Asset</para>
    ///   <para>rdfs:label : Asset byline</para>
    ///   <a href="http://data.press.net/ontology/asset/byline">pna:byline</a>
    /// </summary>
    let byline = _prefixId.prefix "byline"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:comment : The date and time a news Asset was created</para>
    ///   <para>rdfs:label : Asset created dateTime</para>
    ///   <a href="http://data.press.net/ontology/asset/created">pna:created</a>
    /// </summary>
    let created = _prefixId.prefix "created"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:comment : Relates an asset to an asset that it is derived from</para>
    ///   <para>rdfs:label : Relates an asset to an asset that it is derived from</para>
    ///   <a href="http://data.press.net/ontology/asset/derivedFrom">pna:derivedFrom</a>
    /// </summary>
    let derivedFrom = _prefixId.prefix "derivedFrom"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:comment : The date and time a news Asset is embargoedUntil</para>
    ///   <para>rdfs:label : Asset embargoed until dateTime</para>
    ///   <a href="http://data.press.net/ontology/asset/embargoedUntil">pna:embargoedUntil</a>
    /// </summary>
    let embargoedUntil = _prefixId.prefix "embargoedUntil"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:comment : Property that associates a thumbnail image with an asset</para>
    ///   <para>rdfs:label : Property that associates a thumbnail image with an asset</para>
    ///   <a href="http://data.press.net/ontology/asset/hasThumbnail">pna:hasThumbnail</a>
    /// </summary>
    let hasThumbnail = _prefixId.prefix "hasThumbnail"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:comment : Property that associates a Text transcript with a Video</para>
    ///   <para>rdfs:label : The text transcript of a Video</para>
    ///   <a href="http://data.press.net/ontology/asset/hasTranscript">pna:hasTranscript</a>
    /// </summary>
    let hasTranscript = _prefixId.prefix "hasTranscript"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:comment : The date and time a news Asset was modified</para>
    ///   <para>rdfs:label : Asset modified dateTime</para>
    ///   <a href="http://data.press.net/ontology/asset/modified">pna:modified</a>
    /// </summary>
    let modified = _prefixId.prefix "modified"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:comment : The date and time a news Asset was published</para>
    ///   <para>rdfs:label : Asset published dateTime</para>
    ///   <a href="http://data.press.net/ontology/asset/published">pna:published</a>
    /// </summary>
    let published = _prefixId.prefix "published"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:comment : The summary text of a news Asset</para>
    ///   <para>rdfs:label : Asset summary</para>
    ///   <a href="http://data.press.net/ontology/asset/summary">pna:summary</a>
    /// </summary>
    let summary = _prefixId.prefix "summary"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:comment : The title of a news Asset</para>
    ///   <para>rdfs:label : Asset title</para>
    ///   <a href="http://data.press.net/ontology/asset/title">pna:title</a>
    /// </summary>
    let title = _prefixId.prefix "title"
