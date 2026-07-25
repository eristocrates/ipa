namespace http.www.bbc.co.uk.ontologies.creativework.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module cwork =
    let _namespace_iri = Namespace_Iri cwork |> NamespaceIRI
    /// <summary>
    ///   <para>cwork:CloseUpThumbnail</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwork:ThumbnailType</para>
    ///   <para>A 16x9 image, focused and zoomed in one part of the image, usually when the standard thumbnail is very small to be meaningful (e.g., in mobile).</para>
    /// labels<para>CloseUpThumbnail</para></remarks>
    /// <seealso href="http://www.bbc.co.uk/ontologies/creativework/CloseUpThumbnail">http://www.bbc.co.uk/ontologies/creativework/CloseUpThumbnail</seealso>
    let CloseUpThumbnail = Prefixed_Name(cwork, "CloseUpThumbnail") |> PrefixedName
    /// <summary>
    ///   <para>cwork:ThumbnailType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Enumerated class of the allowed thumbnail types</para>
    /// labels<para>ThumbnailType</para></remarks>
    /// <seealso href="http://www.bbc.co.uk/ontologies/creativework/ThumbnailType">http://www.bbc.co.uk/ontologies/creativework/ThumbnailType</seealso>
    let ThumbnailType = Prefixed_Name(cwork, "ThumbnailType") |> PrefixedName
    /// <summary>
    ///   <para>cwork:Episode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The Episodes subclass of programmes produced by the BBC.</para>
    /// labels<para>Episode</para></remarks>
    /// <seealso href="http://www.bbc.co.uk/ontologies/creativework/Episode">http://www.bbc.co.uk/ontologies/creativework/Episode</seealso>
    let Episode = Prefixed_Name(cwork, "Episode") |> PrefixedName
    /// <summary>
    ///   <para>cwork:1.10</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.bbc.co.uk/ontologies/creativework/1.10">http://www.bbc.co.uk/ontologies/creativework/1.10</seealso>
    let ``_1.10`` = Prefixed_Name(cwork, "1.10") |> PrefixedName
    /// <summary>
    ///   <para>cwork:NationalAudience</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwork:Audience</para>
    ///   <para>The national audience. The creative works linked to this instance are *only available to the national audience*.</para>
    /// labels<para>NationalAudience</para></remarks>
    /// <seealso href="http://www.bbc.co.uk/ontologies/creativework/NationalAudience">http://www.bbc.co.uk/ontologies/creativework/NationalAudience</seealso>
    let NationalAudience = Prefixed_Name(cwork, "NationalAudience") |> PrefixedName
    /// <summary>
    ///   <para>cwork:TextualFormat</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwork:Format</para>
    ///   <para>Used to represent that the primary format of a CreativeWork is Text</para>
    /// labels<para>TextualFormat</para></remarks>
    /// <seealso href="http://www.bbc.co.uk/ontologies/creativework/TextualFormat">http://www.bbc.co.uk/ontologies/creativework/TextualFormat</seealso>
    let TextualFormat = Prefixed_Name(cwork, "TextualFormat") |> PrefixedName
    /// <summary>
    ///   <para>cwork:Audience</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Enumerated class of the audiences the BBC creates content for.</para>
    /// labels<para>Audience</para></remarks>
    /// <seealso href="http://www.bbc.co.uk/ontologies/creativework/Audience">http://www.bbc.co.uk/ontologies/creativework/Audience</seealso>
    let Audience = Prefixed_Name(cwork, "Audience") |> PrefixedName
    /// <summary>
    ///   <para>cwork:Format</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The primary format of the CreativeWork and it can be one of the five instances. This is needed for selecting the appropriate icon with which to overlay the preview thumbnail of the creative work.</para>
    /// labels<para>Format</para></remarks>
    /// <seealso href="http://www.bbc.co.uk/ontologies/creativework/Format">http://www.bbc.co.uk/ontologies/creativework/Format</seealso>
    let Format = Prefixed_Name(cwork, "Format") |> PrefixedName
    /// <summary>
    ///   <para>cwork:1.4</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.bbc.co.uk/ontologies/creativework/1.4">http://www.bbc.co.uk/ontologies/creativework/1.4</seealso>
    let ``_1.4`` = Prefixed_Name(cwork, "1.4") |> PrefixedName
    /// <summary>
    ///   <para>cwork:AudioFormat</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwork:Format</para>
    ///   <para>Used to represent that the primary format of a CreativeWork is Audio.</para>
    /// labels<para>AudioFormat</para></remarks>
    /// <seealso href="http://www.bbc.co.uk/ontologies/creativework/AudioFormat">http://www.bbc.co.uk/ontologies/creativework/AudioFormat</seealso>
    let AudioFormat = Prefixed_Name(cwork, "AudioFormat") |> PrefixedName
    /// <summary>
    ///   <para>cwork:CreativeWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The class of creative works produced by the BBC.</para>
    /// labels<para>CreativeWork</para></remarks>
    /// <seealso href="http://www.bbc.co.uk/ontologies/creativework/CreativeWork">http://www.bbc.co.uk/ontologies/creativework/CreativeWork</seealso>
    let CreativeWork = Prefixed_Name(cwork, "CreativeWork") |> PrefixedName

    /// <summary>
    ///   <para>cwork:FixedSize144Thumbnail</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwork:ThumbnailType</para>
    ///   <para>Fixed size thumbnail</para>
    /// labels<para>FixedSize144Thumbnail</para></remarks>
    /// <seealso href="http://www.bbc.co.uk/ontologies/creativework/FixedSize144Thumbnail">http://www.bbc.co.uk/ontologies/creativework/FixedSize144Thumbnail</seealso>
    let FixedSize144Thumbnail =
        Prefixed_Name(cwork, "FixedSize144Thumbnail") |> PrefixedName

    /// <summary>
    ///   <para>cwork:FixedSize464Thumbnail</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwork:ThumbnailType</para>
    ///   <para>Fixed size thumbnail</para>
    /// labels<para>FixedSize464Thumbnail</para></remarks>
    /// <seealso href="http://www.bbc.co.uk/ontologies/creativework/FixedSize464Thumbnail">http://www.bbc.co.uk/ontologies/creativework/FixedSize464Thumbnail</seealso>
    let FixedSize464Thumbnail =
        Prefixed_Name(cwork, "FixedSize464Thumbnail") |> PrefixedName

    /// <summary>
    ///   <para>cwork:Clip</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The Clips subclass of programmes produced by the BBC.</para>
    /// labels<para>Clip</para></remarks>
    /// <seealso href="http://www.bbc.co.uk/ontologies/creativework/Clip">http://www.bbc.co.uk/ontologies/creativework/Clip</seealso>
    let Clip = Prefixed_Name(cwork, "Clip") |> PrefixedName
    /// <summary>
    ///   <para>cwork:Category</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A class to represent different categorisations of creative works from different clients. This class is instantiated in the clients' application logic models.</para>
    /// labels<para>Category</para></remarks>
    /// <seealso href="http://www.bbc.co.uk/ontologies/creativework/Category">http://www.bbc.co.uk/ontologies/creativework/Category</seealso>
    let Category = Prefixed_Name(cwork, "Category") |> PrefixedName
    /// <summary>
    ///   <para>cwork:Programme</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The class of programmes produced by the BBC</para>
    /// labels<para>Programme</para></remarks>
    /// <seealso href="http://www.bbc.co.uk/ontologies/creativework/Programme">http://www.bbc.co.uk/ontologies/creativework/Programme</seealso>
    let Programme = Prefixed_Name(cwork, "Programme") |> PrefixedName
    /// <summary>
    ///   <para>cwork:Commentary</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This class represents short form creative works in the shape of updates. These differ from the other types of creative works because they haven't got independent URLs  as (primaryContentOf) from which they can be retrieved.</para>
    /// labels<para>Commentary</para></remarks>
    /// <seealso href="http://www.bbc.co.uk/ontologies/creativework/Commentary">http://www.bbc.co.uk/ontologies/creativework/Commentary</seealso>
    let Commentary = Prefixed_Name(cwork, "Commentary") |> PrefixedName

    /// <summary>
    ///   <para>cwork:FixedSize224Thumbnail</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwork:ThumbnailType</para>
    ///   <para>Fixed size thumbnail</para>
    /// labels<para>FixedSize224Thumbnail</para></remarks>
    /// <seealso href="http://www.bbc.co.uk/ontologies/creativework/FixedSize224Thumbnail">http://www.bbc.co.uk/ontologies/creativework/FixedSize224Thumbnail</seealso>
    let FixedSize224Thumbnail =
        Prefixed_Name(cwork, "FixedSize224Thumbnail") |> PrefixedName

    /// <summary>
    ///   <para>cwork:FixedSize226Thumbnail</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwork:ThumbnailType</para>
    ///   <para>Fixed size thumbnail</para>
    /// labels<para>FixedSize226Thumbnail</para></remarks>
    /// <seealso href="http://www.bbc.co.uk/ontologies/creativework/FixedSize226Thumbnail">http://www.bbc.co.uk/ontologies/creativework/FixedSize226Thumbnail</seealso>
    let FixedSize226Thumbnail =
        Prefixed_Name(cwork, "FixedSize226Thumbnail") |> PrefixedName

    /// <summary>
    ///   <para>cwork:InteractiveFormat</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwork:Format</para>
    ///   <para>Used to represent that the primary format of a CreativeWork is Interactive</para>
    /// labels<para>InteractiveFormat</para></remarks>
    /// <seealso href="http://www.bbc.co.uk/ontologies/creativework/InteractiveFormat">http://www.bbc.co.uk/ontologies/creativework/InteractiveFormat</seealso>
    let InteractiveFormat = Prefixed_Name(cwork, "InteractiveFormat") |> PrefixedName
    /// <summary>
    ///   <para>cwork:LiveCoverage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This class is used to describe that creative works which are coverage of a live event. (Note that this isn't meant to describe the fact that the event is live currently. An example of a Live Coverage creative work is the live event page covering live the England VS Australia cricket match, last saturday's football matches or last year's elections)</para>
    /// labels<para>LiveCoverage</para></remarks>
    /// <seealso href="http://www.bbc.co.uk/ontologies/creativework/LiveCoverage">http://www.bbc.co.uk/ontologies/creativework/LiveCoverage</seealso>
    let LiveCoverage = Prefixed_Name(cwork, "LiveCoverage") |> PrefixedName

    /// <summary>
    ///   <para>cwork:FixedSize66Thumbnail</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwork:ThumbnailType</para>
    ///   <para>Fixed size thumbnail</para>
    /// labels<para>FixedSize66Thumbnail</para></remarks>
    /// <seealso href="http://www.bbc.co.uk/ontologies/creativework/FixedSize66Thumbnail">http://www.bbc.co.uk/ontologies/creativework/FixedSize66Thumbnail</seealso>
    let FixedSize66Thumbnail =
        Prefixed_Name(cwork, "FixedSize66Thumbnail") |> PrefixedName

    /// <summary>
    ///   <para>cwork:InternationalAudience</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwork:Audience</para>
    ///   <para>The international (non UK) audience. The creative works linked to this instance are *only available to the international audience*.</para>
    /// labels<para>InternationalAudience</para></remarks>
    /// <seealso href="http://www.bbc.co.uk/ontologies/creativework/InternationalAudience">http://www.bbc.co.uk/ontologies/creativework/InternationalAudience</seealso>
    let InternationalAudience =
        Prefixed_Name(cwork, "InternationalAudience") |> PrefixedName

    /// <summary>
    ///   <para>cwork:ImageFormat</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwork:Format</para>
    ///   <para>Used to represent that the primary format of a CreativeWork is Image</para>
    /// labels<para>ImageFormat</para></remarks>
    /// <seealso href="http://www.bbc.co.uk/ontologies/creativework/ImageFormat">http://www.bbc.co.uk/ontologies/creativework/ImageFormat</seealso>
    let ImageFormat = Prefixed_Name(cwork, "ImageFormat") |> PrefixedName
    /// <summary>
    ///   <para>cwork:LiveEventPage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This class is created to support the LiveEventPages from CPS. This will be soon deprecated for the sake of LiveCoverage</para>
    /// labels<para>LiveEventPage</para></remarks>
    /// <seealso href="http://www.bbc.co.uk/ontologies/creativework/LiveEventPage">http://www.bbc.co.uk/ontologies/creativework/LiveEventPage</seealso>
    let LiveEventPage = Prefixed_Name(cwork, "LiveEventPage") |> PrefixedName

    /// <summary>
    ///   <para>cwork:PictureGalleryFormat</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwork:Format</para>
    ///   <para>Used to represent that the primary format of a CreativeWork is of PictureGallery (this is a mid-term solution for the modelling of galleries)</para>
    /// labels<para>PictureGalleryFormat</para></remarks>
    /// <seealso href="http://www.bbc.co.uk/ontologies/creativework/PictureGalleryFormat">http://www.bbc.co.uk/ontologies/creativework/PictureGalleryFormat</seealso>
    let PictureGalleryFormat =
        Prefixed_Name(cwork, "PictureGalleryFormat") |> PrefixedName

    /// <summary>
    ///   <para>cwork:StandardThumbnail</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwork:ThumbnailType</para>
    ///   <para>A 16x9 image used in most occasions</para>
    /// labels<para>StandardThumbnail</para></remarks>
    /// <seealso href="http://www.bbc.co.uk/ontologies/creativework/StandardThumbnail">http://www.bbc.co.uk/ontologies/creativework/StandardThumbnail</seealso>
    let StandardThumbnail = Prefixed_Name(cwork, "StandardThumbnail") |> PrefixedName
    /// <summary>
    ///   <para>cwork:NewsItem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The class of all news items that the BBC produces. They can be textual articles, or media asset pages (audio or video) or live coverage of events (use the liveCoverage property).</para>
    /// labels<para>NewsItem</para></remarks>
    /// <seealso href="http://www.bbc.co.uk/ontologies/creativework/NewsItem">http://www.bbc.co.uk/ontologies/creativework/NewsItem</seealso>
    let NewsItem = Prefixed_Name(cwork, "NewsItem") |> PrefixedName
    /// <summary>
    ///   <para>cwork:Thumbnail</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Used to associate a Creative Work with the canonical location of the thumbnail. The URI of each of its instances is the full canonical location of the thumbnail</para>
    /// labels<para>Thumbnail</para></remarks>
    /// <seealso href="http://www.bbc.co.uk/ontologies/creativework/Thumbnail">http://www.bbc.co.uk/ontologies/creativework/Thumbnail</seealso>
    let Thumbnail = Prefixed_Name(cwork, "Thumbnail") |> PrefixedName
    /// <summary>
    ///   <para>cwork:VideoFormat</para>
    /// </summary>
    /// <remarks>
    ///   <para>cwork:Format</para>
    ///   <para>Used to represent that the primary format of a CreativeWork is Video</para>
    /// labels<para>VideoFormat</para></remarks>
    /// <seealso href="http://www.bbc.co.uk/ontologies/creativework/VideoFormat">http://www.bbc.co.uk/ontologies/creativework/VideoFormat</seealso>
    let VideoFormat = Prefixed_Name(cwork, "VideoFormat") |> PrefixedName
    /// <summary>
    ///   <para>cwork:about</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Indicates that the creative work is about a tag concept</para>
    /// labels<para>about</para></remarks>
    /// <seealso href="http://www.bbc.co.uk/ontologies/creativework/about">http://www.bbc.co.uk/ontologies/creativework/about</seealso>
    let about = Prefixed_Name(cwork, "about") |> PrefixedName
    /// <summary>
    ///   <para>cwork:tag</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Indicates that the creative work is tagged with tag concept</para>
    /// labels<para>tag</para></remarks>
    /// <seealso href="http://www.bbc.co.uk/ontologies/creativework/tag">http://www.bbc.co.uk/ontologies/creativework/tag</seealso>
    let tag = Prefixed_Name(cwork, "tag") |> PrefixedName
    /// <summary>
    ///   <para>cwork:category</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The category property is another mid term solution for maintaining the functionality supporting individual clients. For example, the type of gossip is something that the sports pal use for the moment. The values of the property are decided by the client teams in collaboration with LDP</para>
    /// labels<para>category</para></remarks>
    /// <seealso href="http://www.bbc.co.uk/ontologies/creativework/category">http://www.bbc.co.uk/ontologies/creativework/category</seealso>
    let category = Prefixed_Name(cwork, "category") |> PrefixedName
    /// <summary>
    ///   <para>cwork:dateCreated</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Date created of CreativeWork</para>
    /// labels<para>dateCreated</para></remarks>
    /// <seealso href="http://www.bbc.co.uk/ontologies/creativework/dateCreated">http://www.bbc.co.uk/ontologies/creativework/dateCreated</seealso>
    let dateCreated = Prefixed_Name(cwork, "dateCreated") |> PrefixedName
    /// <summary>
    ///   <para>cwork:language</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The language of the creative work, please use BCP47 https://tools.ietf.org/html/bcp47</para>
    /// labels<para>language</para></remarks>
    /// <seealso href="http://www.bbc.co.uk/ontologies/creativework/language">http://www.bbc.co.uk/ontologies/creativework/language</seealso>
    let language = Prefixed_Name(cwork, "language") |> PrefixedName
    /// <summary>
    ///   <para>cwork:primaryFormat</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Associates the Creative Work with the Primary Format instance</para>
    /// labels<para>primaryFormat</para></remarks>
    /// <seealso href="http://www.bbc.co.uk/ontologies/creativework/primaryFormat">http://www.bbc.co.uk/ontologies/creativework/primaryFormat</seealso>
    let primaryFormat = Prefixed_Name(cwork, "primaryFormat") |> PrefixedName
    /// <summary>
    ///   <para>cwork:thumbnail</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Associates the Creative Work with the Thumbnail instance</para>
    /// labels<para>thumbnail</para></remarks>
    /// <seealso href="http://www.bbc.co.uk/ontologies/creativework/thumbnail">http://www.bbc.co.uk/ontologies/creativework/thumbnail</seealso>
    let thumbnail = Prefixed_Name(cwork, "thumbnail") |> PrefixedName
    /// <summary>
    ///   <para>cwork:thumbnailType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Associates the Thumbnail instance with a Thumbnail type</para>
    /// labels<para>thumbnailType</para></remarks>
    /// <seealso href="http://www.bbc.co.uk/ontologies/creativework/thumbnailType">http://www.bbc.co.uk/ontologies/creativework/thumbnailType</seealso>
    let thumbnailType = Prefixed_Name(cwork, "thumbnailType") |> PrefixedName
    /// <summary>
    ///   <para>cwork:TravelIncident</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This class is used to describe creative works which are Travel Incidents.</para>
    /// labels<para>TravelIncident</para></remarks>
    /// <seealso href="http://www.bbc.co.uk/ontologies/creativework/TravelIncident">http://www.bbc.co.uk/ontologies/creativework/TravelIncident</seealso>
    let TravelIncident = Prefixed_Name(cwork, "TravelIncident") |> PrefixedName
    /// <summary>
    ///   <para>cwork:WeatherAlert</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This class is used to describe creative works which are Weather Alerts.</para>
    /// labels<para>WeatherAlert</para></remarks>
    /// <seealso href="http://www.bbc.co.uk/ontologies/creativework/WeatherAlert">http://www.bbc.co.uk/ontologies/creativework/WeatherAlert</seealso>
    let WeatherAlert = Prefixed_Name(cwork, "WeatherAlert") |> PrefixedName
    /// <summary>
    ///   <para>cwork:audience</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Associates the Creative Work with an audience instance</para>
    /// labels<para>audience</para></remarks>
    /// <seealso href="http://www.bbc.co.uk/ontologies/creativework/audience">http://www.bbc.co.uk/ontologies/creativework/audience</seealso>
    let audience = Prefixed_Name(cwork, "audience") |> PrefixedName
    /// <summary>
    ///   <para>cwork:dateModified</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Date modified of CreativeWork</para>
    /// labels<para>dateModified</para></remarks>
    /// <seealso href="http://www.bbc.co.uk/ontologies/creativework/dateModified">http://www.bbc.co.uk/ontologies/creativework/dateModified</seealso>
    let dateModified = Prefixed_Name(cwork, "dateModified") |> PrefixedName
    /// <summary>
    ///   <para>cwork:altText</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The alternative text for a thumbnail in case the URL is not resolved</para>
    /// labels<para>altText</para></remarks>
    /// <seealso href="http://www.bbc.co.uk/ontologies/creativework/altText">http://www.bbc.co.uk/ontologies/creativework/altText</seealso>
    let altText = Prefixed_Name(cwork, "altText") |> PrefixedName
    /// <summary>
    ///   <para>cwork:createdBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>associate a creative work with its creator</para>
    /// labels<para>createdBy</para></remarks>
    /// <seealso href="http://www.bbc.co.uk/ontologies/creativework/createdBy">http://www.bbc.co.uk/ontologies/creativework/createdBy</seealso>
    let createdBy = Prefixed_Name(cwork, "createdBy") |> PrefixedName
    /// <summary>
    ///   <para>cwork:description</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The description of the Creative Work</para>
    /// labels<para>description</para></remarks>
    /// <seealso href="http://www.bbc.co.uk/ontologies/creativework/description">http://www.bbc.co.uk/ontologies/creativework/description</seealso>
    let description = Prefixed_Name(cwork, "description") |> PrefixedName
    /// <summary>
    ///   <para>cwork:mentions</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Indicates that the creative work mentions a tag concept</para>
    /// labels<para>mentions</para></remarks>
    /// <seealso href="http://www.bbc.co.uk/ontologies/creativework/mentions">http://www.bbc.co.uk/ontologies/creativework/mentions</seealso>
    let mentions = Prefixed_Name(cwork, "mentions") |> PrefixedName
    /// <summary>
    ///   <para>cwork:shortTitle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The sort title of the Creative Work</para>
    /// labels<para>shortTitle</para></remarks>
    /// <seealso href="http://www.bbc.co.uk/ontologies/creativework/shortTitle">http://www.bbc.co.uk/ontologies/creativework/shortTitle</seealso>
    let shortTitle = Prefixed_Name(cwork, "shortTitle") |> PrefixedName
    /// <summary>
    ///   <para>cwork:title</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The title of the Creative Work</para>
    /// labels<para>title</para></remarks>
    /// <seealso href="http://www.bbc.co.uk/ontologies/creativework/title">http://www.bbc.co.uk/ontologies/creativework/title</seealso>
    let title = Prefixed_Name(cwork, "title") |> PrefixedName
    /// <summary>
    ///   <para>cwork:1.11</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.bbc.co.uk/ontologies/creativework/1.11">http://www.bbc.co.uk/ontologies/creativework/1.11</seealso>
    let ``_1.11`` = Prefixed_Name(cwork, "1.11") |> PrefixedName
    /// <summary>
    ///   <para>cwork:BlogPost</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This is the class of creative works that are associated with particular journalists or correspondents. The analysis, commentary and personal viewpoint of the creator is reflected on the blog post and the blog post is usually associated prominently with the name of the creator. BlogPost can have different types of formats.</para>
    /// labels<para>BlogPost</para></remarks>
    /// <seealso href="http://www.bbc.co.uk/ontologies/creativework/BlogPost">http://www.bbc.co.uk/ontologies/creativework/BlogPost</seealso>
    let BlogPost = Prefixed_Name(cwork, "BlogPost") |> PrefixedName
