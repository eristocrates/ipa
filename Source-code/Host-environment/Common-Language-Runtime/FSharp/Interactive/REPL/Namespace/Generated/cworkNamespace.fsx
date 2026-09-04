#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module cwork =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://www.bbc.co.uk/ontologies/creativework/" "cwork"

    let ``_1.10`` = _prefixId.prefix "1.10"
    let ``_1.11`` = _prefixId.prefix "1.11"
    let ``_1.4`` = _prefixId.prefix "1.4"
    /// <summary>
    ///   <para>rdfs:label : Audience</para>
    ///   <para>rdfs:comment : Enumerated class of the audiences the BBC creates content for.</para>
    ///   <a href="http://www.bbc.co.uk/ontologies/creativework/Audience">cwork:Audience</a>
    /// </summary>
    let Audience = _prefixId.prefix "Audience"
    let AudioFormat = _prefixId.prefix "AudioFormat"
    /// <summary>
    ///   <para>owl:deprecated : true^^xsd:boolean</para>
    ///   <para>rdfs:label : BlogPost</para>
    ///   <para>rdfs:comment : This is the class of creative works that are associated with particular journalists or correspondents. The analysis, commentary and personal viewpoint of the creator is reflected on the blog post and the blog post is usually associated prominently with the name of the creator. BlogPost can have different types of formats.</para>
    ///   <a href="http://www.bbc.co.uk/ontologies/creativework/BlogPost">cwork:BlogPost</a>
    /// </summary>
    let BlogPost = _prefixId.prefix "BlogPost"
    /// <summary>
    ///   <para>rdfs:label : Category</para>
    ///   <para>rdfs:comment : A class to represent different categorisations of creative works from different clients. This class is instantiated in the clients' application logic models.</para>
    ///   <a href="http://www.bbc.co.uk/ontologies/creativework/Category">cwork:Category</a>
    /// </summary>
    let Category = _prefixId.prefix "Category"
    /// <summary>
    ///   <para>owl:deprecated : true^^xsd:boolean</para>
    ///   <para>rdfs:label : Clip</para>
    ///   <para>rdfs:comment : The Clips subclass of programmes produced by the BBC.</para>
    ///   <a href="http://www.bbc.co.uk/ontologies/creativework/Clip">cwork:Clip</a>
    /// </summary>
    let Clip = _prefixId.prefix "Clip"
    let CloseUpThumbnail = _prefixId.prefix "CloseUpThumbnail"
    /// <summary>
    ///   <para>owl:deprecated : true^^xsd:boolean</para>
    ///   <para>rdfs:label : Commentary</para>
    ///   <para>rdfs:comment : This class represents short form creative works in the shape of updates. These differ from the other types of creative works because they haven't got independent URLs  as (primaryContentOf) from which they can be retrieved.</para>
    ///   <a href="http://www.bbc.co.uk/ontologies/creativework/Commentary">cwork:Commentary</a>
    /// </summary>
    let Commentary = _prefixId.prefix "Commentary"
    /// <summary>
    ///   <para>rdfs:label : CreativeWork</para>
    ///   <para>rdfs:comment : The class of creative works produced by the BBC.</para>
    ///   <a href="http://www.bbc.co.uk/ontologies/creativework/CreativeWork">cwork:CreativeWork</a>
    /// </summary>
    let CreativeWork = _prefixId.prefix "CreativeWork"
    /// <summary>
    ///   <para>owl:deprecated : true^^xsd:boolean</para>
    ///   <para>rdfs:label : Episode</para>
    ///   <para>rdfs:comment : The Episodes subclass of programmes produced by the BBC.</para>
    ///   <a href="http://www.bbc.co.uk/ontologies/creativework/Episode">cwork:Episode</a>
    /// </summary>
    let Episode = _prefixId.prefix "Episode"
    let FixedSize144Thumbnail = _prefixId.prefix "FixedSize144Thumbnail"
    let FixedSize224Thumbnail = _prefixId.prefix "FixedSize224Thumbnail"
    let FixedSize226Thumbnail = _prefixId.prefix "FixedSize226Thumbnail"
    let FixedSize464Thumbnail = _prefixId.prefix "FixedSize464Thumbnail"
    let FixedSize66Thumbnail = _prefixId.prefix "FixedSize66Thumbnail"
    /// <summary>
    ///   <para>rdfs:label : Format</para>
    ///   <para>rdfs:comment : The primary format of the CreativeWork and it can be one of the five instances. This is needed for selecting the appropriate icon with which to overlay the preview thumbnail of the creative work.</para>
    ///   <a href="http://www.bbc.co.uk/ontologies/creativework/Format">cwork:Format</a>
    /// </summary>
    let Format = _prefixId.prefix "Format"
    let ImageFormat = _prefixId.prefix "ImageFormat"
    let InteractiveFormat = _prefixId.prefix "InteractiveFormat"
    let InternationalAudience = _prefixId.prefix "InternationalAudience"
    /// <summary>
    ///   <para>owl:deprecated : true^^xsd:boolean</para>
    ///   <para>rdfs:label : LiveCoverage</para>
    ///   <para>rdfs:comment : This class is used to describe that creative works which are coverage of a live event. (Note that this isn't meant to describe the fact that the event is live currently. An example of a Live Coverage creative work is the live event page covering live the England VS Australia cricket match, last saturday's football matches or last year's elections)</para>
    ///   <a href="http://www.bbc.co.uk/ontologies/creativework/LiveCoverage">cwork:LiveCoverage</a>
    /// </summary>
    let LiveCoverage = _prefixId.prefix "LiveCoverage"
    /// <summary>
    ///   <para>owl:deprecated : true^^xsd:boolean</para>
    ///   <para>rdfs:label : LiveEventPage</para>
    ///   <para>rdfs:comment : This class is created to support the LiveEventPages from CPS. This will be soon deprecated for the sake of LiveCoverage</para>
    ///   <a href="http://www.bbc.co.uk/ontologies/creativework/LiveEventPage">cwork:LiveEventPage</a>
    /// </summary>
    let LiveEventPage = _prefixId.prefix "LiveEventPage"
    let NationalAudience = _prefixId.prefix "NationalAudience"
    /// <summary>
    ///   <para>owl:deprecated : true^^xsd:boolean</para>
    ///   <para>rdfs:label : NewsItem</para>
    ///   <para>rdfs:comment : The class of all news items that the BBC produces. They can be textual articles, or media asset pages (audio or video) or live coverage of events (use the liveCoverage property).</para>
    ///   <a href="http://www.bbc.co.uk/ontologies/creativework/NewsItem">cwork:NewsItem</a>
    /// </summary>
    let NewsItem = _prefixId.prefix "NewsItem"
    let PictureGalleryFormat = _prefixId.prefix "PictureGalleryFormat"
    /// <summary>
    ///   <para>owl:deprecated : true^^xsd:boolean</para>
    ///   <para>rdfs:label : Programme</para>
    ///   <para>rdfs:comment : The class of programmes produced by the BBC</para>
    ///   <a href="http://www.bbc.co.uk/ontologies/creativework/Programme">cwork:Programme</a>
    /// </summary>
    let Programme = _prefixId.prefix "Programme"
    let StandardThumbnail = _prefixId.prefix "StandardThumbnail"
    let TextualFormat = _prefixId.prefix "TextualFormat"
    /// <summary>
    ///   <para>rdfs:label : Thumbnail</para>
    ///   <para>rdfs:comment : Used to associate a Creative Work with the canonical location of the thumbnail. The URI of each of its instances is the full canonical location of the thumbnail</para>
    ///   <a href="http://www.bbc.co.uk/ontologies/creativework/Thumbnail">cwork:Thumbnail</a>
    /// </summary>
    let Thumbnail = _prefixId.prefix "Thumbnail"
    /// <summary>
    ///   <para>rdfs:label : ThumbnailType</para>
    ///   <para>rdfs:comment : Enumerated class of the allowed thumbnail types</para>
    ///   <a href="http://www.bbc.co.uk/ontologies/creativework/ThumbnailType">cwork:ThumbnailType</a>
    /// </summary>
    let ThumbnailType = _prefixId.prefix "ThumbnailType"
    /// <summary>
    ///   <para>rdfs:label : TravelIncident</para>
    ///   <para>rdfs:comment : This class is used to describe creative works which are Travel Incidents.</para>
    ///   <a href="http://www.bbc.co.uk/ontologies/creativework/TravelIncident">cwork:TravelIncident</a>
    /// </summary>
    let TravelIncident = _prefixId.prefix "TravelIncident"
    let VideoFormat = _prefixId.prefix "VideoFormat"
    /// <summary>
    ///   <para>rdfs:label : WeatherAlert</para>
    ///   <para>rdfs:comment : This class is used to describe creative works which are Weather Alerts.</para>
    ///   <a href="http://www.bbc.co.uk/ontologies/creativework/WeatherAlert">cwork:WeatherAlert</a>
    /// </summary>
    let WeatherAlert = _prefixId.prefix "WeatherAlert"
    /// <summary>
    ///   <para>rdfs:label : about</para>
    ///   <para>rdfs:comment : Indicates that the creative work is about a tag concept</para>
    ///   <a href="http://www.bbc.co.uk/ontologies/creativework/about">cwork:about</a>
    /// </summary>
    let about = _prefixId.prefix "about"
    /// <summary>
    ///   <para>rdfs:label : altText</para>
    ///   <para>rdfs:comment : The alternative text for a thumbnail in case the URL is not resolved</para>
    ///   <a href="http://www.bbc.co.uk/ontologies/creativework/altText">cwork:altText</a>
    /// </summary>
    let altText = _prefixId.prefix "altText"
    /// <summary>
    ///   <para>rdfs:label : audience</para>
    ///   <para>rdfs:comment : Associates the Creative Work with an audience instance</para>
    ///   <a href="http://www.bbc.co.uk/ontologies/creativework/audience">cwork:audience</a>
    /// </summary>
    let audience = _prefixId.prefix "audience"
    /// <summary>
    ///   <para>rdfs:label : category</para>
    ///   <para>rdfs:comment : The category property is another mid term solution for maintaining the functionality supporting individual clients. For example, the type of gossip is something that the sports pal use for the moment. The values of the property are decided by the client teams in collaboration with LDP</para>
    ///   <a href="http://www.bbc.co.uk/ontologies/creativework/category">cwork:category</a>
    /// </summary>
    let category = _prefixId.prefix "category"
    /// <summary>
    ///   <para>rdfs:label : createdBy</para>
    ///   <para>rdfs:comment : associate a creative work with its creator</para>
    ///   <a href="http://www.bbc.co.uk/ontologies/creativework/createdBy">cwork:createdBy</a>
    /// </summary>
    let createdBy = _prefixId.prefix "createdBy"
    /// <summary>
    ///   <para>rdfs:label : dateCreated</para>
    ///   <para>rdfs:comment : Date created of CreativeWork</para>
    ///   <a href="http://www.bbc.co.uk/ontologies/creativework/dateCreated">cwork:dateCreated</a>
    /// </summary>
    let dateCreated = _prefixId.prefix "dateCreated"
    /// <summary>
    ///   <para>rdfs:label : dateModified</para>
    ///   <para>rdfs:comment : Date modified of CreativeWork</para>
    ///   <a href="http://www.bbc.co.uk/ontologies/creativework/dateModified">cwork:dateModified</a>
    /// </summary>
    let dateModified = _prefixId.prefix "dateModified"
    /// <summary>
    ///   <para>rdfs:label : description</para>
    ///   <para>rdfs:comment : The description of the Creative Work</para>
    ///   <a href="http://www.bbc.co.uk/ontologies/creativework/description">cwork:description</a>
    /// </summary>
    let description = _prefixId.prefix "description"
    /// <summary>
    ///   <para>rdfs:label : language</para>
    ///   <para>rdfs:comment : The language of the creative work, please use BCP47 https://tools.ietf.org/html/bcp47</para>
    ///   <a href="http://www.bbc.co.uk/ontologies/creativework/language">cwork:language</a>
    /// </summary>
    let language = _prefixId.prefix "language"
    /// <summary>
    ///   <para>rdfs:label : mentions</para>
    ///   <para>rdfs:comment : Indicates that the creative work mentions a tag concept</para>
    ///   <a href="http://www.bbc.co.uk/ontologies/creativework/mentions">cwork:mentions</a>
    /// </summary>
    let mentions = _prefixId.prefix "mentions"
    /// <summary>
    ///   <para>rdfs:label : primaryFormat</para>
    ///   <para>rdfs:comment : Associates the Creative Work with the Primary Format instance</para>
    ///   <a href="http://www.bbc.co.uk/ontologies/creativework/primaryFormat">cwork:primaryFormat</a>
    /// </summary>
    let primaryFormat = _prefixId.prefix "primaryFormat"
    /// <summary>
    ///   <para>rdfs:label : shortTitle</para>
    ///   <para>rdfs:comment : The sort title of the Creative Work</para>
    ///   <a href="http://www.bbc.co.uk/ontologies/creativework/shortTitle">cwork:shortTitle</a>
    /// </summary>
    let shortTitle = _prefixId.prefix "shortTitle"
    /// <summary>
    ///   <para>rdfs:label : tag</para>
    ///   <para>rdfs:comment : Indicates that the creative work is tagged with tag concept</para>
    ///   <a href="http://www.bbc.co.uk/ontologies/creativework/tag">cwork:tag</a>
    /// </summary>
    let tag = _prefixId.prefix "tag"
    /// <summary>
    ///   <para>rdfs:label : thumbnail</para>
    ///   <para>rdfs:comment : Associates the Creative Work with the Thumbnail instance</para>
    ///   <a href="http://www.bbc.co.uk/ontologies/creativework/thumbnail">cwork:thumbnail</a>
    /// </summary>
    let thumbnail = _prefixId.prefix "thumbnail"
    /// <summary>
    ///   <para>rdfs:label : thumbnailType</para>
    ///   <para>rdfs:comment : Associates the Thumbnail instance with a Thumbnail type</para>
    ///   <a href="http://www.bbc.co.uk/ontologies/creativework/thumbnailType">cwork:thumbnailType</a>
    /// </summary>
    let thumbnailType = _prefixId.prefix "thumbnailType"
    /// <summary>
    ///   <para>rdfs:label : title</para>
    ///   <para>rdfs:comment : The title of the Creative Work</para>
    ///   <a href="http://www.bbc.co.uk/ontologies/creativework/title">cwork:title</a>
    /// </summary>
    let title = _prefixId.prefix "title"
