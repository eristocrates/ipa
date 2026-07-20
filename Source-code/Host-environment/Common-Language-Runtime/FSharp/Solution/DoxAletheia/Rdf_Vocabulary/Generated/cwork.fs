namespace http.www.bbc.co.uk.ontologies.creativework.slash

open DoxAletheia

module cwork =
    let _namespace_name = "http://www.bbc.co.uk/ontologies/creativework/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="http://www.bbc.co.uk/ontologies/creativework/1.10"></see>
    /// </summary>
    let ``_1.10`` = _prefix "1.10"
    /// <summary>
    ///   <see href="http://www.bbc.co.uk/ontologies/creativework/1.11"></see>
    /// </summary>
    let ``_1.11`` = _prefix "1.11"
    /// <summary>
    /// Enumerated class of the audiences the BBC creates content for.
    /// <see href="http://www.bbc.co.uk/ontologies/creativework/Audience"></see></summary>
    let Audience = _prefix "Audience"
    /// <summary>
    /// Used to represent that the primary format of a CreativeWork is Audio.
    /// <see href="http://www.bbc.co.uk/ontologies/creativework/AudioFormat"></see></summary>
    let AudioFormat = _prefix "AudioFormat"
    /// <summary>
    /// The primary format of the CreativeWork and it can be one of the five instances. This is needed for selecting the appropriate icon with which to overlay the preview thumbnail of the creative work.
    /// <see href="http://www.bbc.co.uk/ontologies/creativework/Format"></see></summary>
    let Format = _prefix "Format"
    /// <summary>
    /// This is the class of creative works that are associated with particular journalists or correspondents. The analysis, commentary and personal viewpoint of the creator is reflected on the blog post and the blog post is usually associated prominently with the name of the creator. BlogPost can have different types of formats.
    /// <see href="http://www.bbc.co.uk/ontologies/creativework/BlogPost"></see></summary>
    let BlogPost = _prefix "BlogPost"
    /// <summary>
    ///   <see href="http://www.bbc.co.uk/ontologies/creativework/1.4"></see>
    /// </summary>
    let ``_1.4`` = _prefix "1.4"
    /// <summary>
    /// The class of creative works produced by the BBC.
    /// <see href="http://www.bbc.co.uk/ontologies/creativework/CreativeWork"></see></summary>
    let CreativeWork = _prefix "CreativeWork"
    /// <summary>
    /// A class to represent different categorisations of creative works from different clients. This class is instantiated in the clients' application logic models.
    /// <see href="http://www.bbc.co.uk/ontologies/creativework/Category"></see></summary>
    let Category = _prefix "Category"
    /// <summary>
    /// The Clips subclass of programmes produced by the BBC.
    /// <see href="http://www.bbc.co.uk/ontologies/creativework/Clip"></see></summary>
    let Clip = _prefix "Clip"
    /// <summary>
    /// The class of programmes produced by the BBC
    /// <see href="http://www.bbc.co.uk/ontologies/creativework/Programme"></see></summary>
    let Programme = _prefix "Programme"
    /// <summary>
    /// A 16x9 image, focused and zoomed in one part of the image, usually when the standard thumbnail is very small to be meaningful (e.g., in mobile).
    /// <see href="http://www.bbc.co.uk/ontologies/creativework/CloseUpThumbnail"></see></summary>
    let CloseUpThumbnail = _prefix "CloseUpThumbnail"
    /// <summary>
    /// Enumerated class of the allowed thumbnail types
    /// <see href="http://www.bbc.co.uk/ontologies/creativework/ThumbnailType"></see></summary>
    let ThumbnailType = _prefix "ThumbnailType"
    /// <summary>
    /// This class represents short form creative works in the shape of updates. These differ from the other types of creative works because they haven't got independent URLs  as (primaryContentOf) from which they can be retrieved.
    /// <see href="http://www.bbc.co.uk/ontologies/creativework/Commentary"></see></summary>
    let Commentary = _prefix "Commentary"
    /// <summary>
    /// The Episodes subclass of programmes produced by the BBC.
    /// <see href="http://www.bbc.co.uk/ontologies/creativework/Episode"></see></summary>
    let Episode = _prefix "Episode"
    /// <summary>
    /// Fixed size thumbnail
    /// <see href="http://www.bbc.co.uk/ontologies/creativework/FixedSize144Thumbnail"></see></summary>
    let FixedSize144Thumbnail = _prefix "FixedSize144Thumbnail"
    /// <summary>
    /// Fixed size thumbnail
    /// <see href="http://www.bbc.co.uk/ontologies/creativework/FixedSize224Thumbnail"></see></summary>
    let FixedSize224Thumbnail = _prefix "FixedSize224Thumbnail"
    /// <summary>
    /// Fixed size thumbnail
    /// <see href="http://www.bbc.co.uk/ontologies/creativework/FixedSize226Thumbnail"></see></summary>
    let FixedSize226Thumbnail = _prefix "FixedSize226Thumbnail"
    /// <summary>
    /// Fixed size thumbnail
    /// <see href="http://www.bbc.co.uk/ontologies/creativework/FixedSize464Thumbnail"></see></summary>
    let FixedSize464Thumbnail = _prefix "FixedSize464Thumbnail"
    /// <summary>
    /// Fixed size thumbnail
    /// <see href="http://www.bbc.co.uk/ontologies/creativework/FixedSize66Thumbnail"></see></summary>
    let FixedSize66Thumbnail = _prefix "FixedSize66Thumbnail"
    /// <summary>
    /// Used to represent that the primary format of a CreativeWork is Image
    /// <see href="http://www.bbc.co.uk/ontologies/creativework/ImageFormat"></see></summary>
    let ImageFormat = _prefix "ImageFormat"
    /// <summary>
    /// Used to represent that the primary format of a CreativeWork is Interactive
    /// <see href="http://www.bbc.co.uk/ontologies/creativework/InteractiveFormat"></see></summary>
    let InteractiveFormat = _prefix "InteractiveFormat"
    /// <summary>
    /// The international (non UK) audience. The creative works linked to this instance are *only available to the international audience*.
    /// <see href="http://www.bbc.co.uk/ontologies/creativework/InternationalAudience"></see></summary>
    let InternationalAudience = _prefix "InternationalAudience"
    /// <summary>
    /// This class is used to describe that creative works which are coverage of a live event. (Note that this isn't meant to describe the fact that the event is live currently. An example of a Live Coverage creative work is the live event page covering live the England VS Australia cricket match, last saturday's football matches or last year's elections)
    /// <see href="http://www.bbc.co.uk/ontologies/creativework/LiveCoverage"></see></summary>
    let LiveCoverage = _prefix "LiveCoverage"
    /// <summary>
    /// This class is created to support the LiveEventPages from CPS. This will be soon deprecated for the sake of LiveCoverage
    /// <see href="http://www.bbc.co.uk/ontologies/creativework/LiveEventPage"></see></summary>
    let LiveEventPage = _prefix "LiveEventPage"
    /// <summary>
    /// The national audience. The creative works linked to this instance are *only available to the national audience*.
    /// <see href="http://www.bbc.co.uk/ontologies/creativework/NationalAudience"></see></summary>
    let NationalAudience = _prefix "NationalAudience"
    /// <summary>
    /// The class of all news items that the BBC produces. They can be textual articles, or media asset pages (audio or video) or live coverage of events (use the liveCoverage property).
    /// <see href="http://www.bbc.co.uk/ontologies/creativework/NewsItem"></see></summary>
    let NewsItem = _prefix "NewsItem"
    /// <summary>
    /// Used to represent that the primary format of a CreativeWork is of PictureGallery (this is a mid-term solution for the modelling of galleries)
    /// <see href="http://www.bbc.co.uk/ontologies/creativework/PictureGalleryFormat"></see></summary>
    let PictureGalleryFormat = _prefix "PictureGalleryFormat"
    /// <summary>
    /// A 16x9 image used in most occasions
    /// <see href="http://www.bbc.co.uk/ontologies/creativework/StandardThumbnail"></see></summary>
    let StandardThumbnail = _prefix "StandardThumbnail"
    /// <summary>
    /// Used to represent that the primary format of a CreativeWork is Text
    /// <see href="http://www.bbc.co.uk/ontologies/creativework/TextualFormat"></see></summary>
    let TextualFormat = _prefix "TextualFormat"
    /// <summary>
    /// Used to associate a Creative Work with the canonical location of the thumbnail. The URI of each of its instances is the full canonical location of the thumbnail
    /// <see href="http://www.bbc.co.uk/ontologies/creativework/Thumbnail"></see></summary>
    let Thumbnail = _prefix "Thumbnail"
    /// <summary>
    /// This class is used to describe creative works which are Travel Incidents.
    /// <see href="http://www.bbc.co.uk/ontologies/creativework/TravelIncident"></see></summary>
    let TravelIncident = _prefix "TravelIncident"
    /// <summary>
    /// Used to represent that the primary format of a CreativeWork is Video
    /// <see href="http://www.bbc.co.uk/ontologies/creativework/VideoFormat"></see></summary>
    let VideoFormat = _prefix "VideoFormat"
    /// <summary>
    /// This class is used to describe creative works which are Weather Alerts.
    /// <see href="http://www.bbc.co.uk/ontologies/creativework/WeatherAlert"></see></summary>
    let WeatherAlert = _prefix "WeatherAlert"
    /// <summary>
    /// Indicates that the creative work is about a tag concept
    /// <see href="http://www.bbc.co.uk/ontologies/creativework/about"></see></summary>
    let about = _prefix "about"
    /// <summary>
    /// Indicates that the creative work is tagged with tag concept
    /// <see href="http://www.bbc.co.uk/ontologies/creativework/tag"></see></summary>
    let tag = _prefix "tag"
    /// <summary>
    /// The alternative text for a thumbnail in case the URL is not resolved
    /// <see href="http://www.bbc.co.uk/ontologies/creativework/altText"></see></summary>
    let altText = _prefix "altText"
    /// <summary>
    /// Associates the Creative Work with an audience instance
    /// <see href="http://www.bbc.co.uk/ontologies/creativework/audience"></see></summary>
    let audience = _prefix "audience"
    /// <summary>
    /// The category property is another mid term solution for maintaining the functionality supporting individual clients. For example, the type of gossip is something that the sports pal use for the moment. The values of the property are decided by the client teams in collaboration with LDP
    /// <see href="http://www.bbc.co.uk/ontologies/creativework/category"></see></summary>
    let category = _prefix "category"
    /// <summary>
    /// associate a creative work with its creator
    /// <see href="http://www.bbc.co.uk/ontologies/creativework/createdBy"></see></summary>
    let createdBy = _prefix "createdBy"
    /// <summary>
    /// Date created of CreativeWork
    /// <see href="http://www.bbc.co.uk/ontologies/creativework/dateCreated"></see></summary>
    let dateCreated = _prefix "dateCreated"
    /// <summary>
    /// Date modified of CreativeWork
    /// <see href="http://www.bbc.co.uk/ontologies/creativework/dateModified"></see></summary>
    let dateModified = _prefix "dateModified"
    /// <summary>
    /// The description of the Creative Work
    /// <see href="http://www.bbc.co.uk/ontologies/creativework/description"></see></summary>
    let description = _prefix "description"
    /// <summary>
    /// The language of the creative work, please use BCP47 https://tools.ietf.org/html/bcp47
    /// <see href="http://www.bbc.co.uk/ontologies/creativework/language"></see></summary>
    let language = _prefix "language"
    /// <summary>
    /// Indicates that the creative work mentions a tag concept
    /// <see href="http://www.bbc.co.uk/ontologies/creativework/mentions"></see></summary>
    let mentions = _prefix "mentions"
    /// <summary>
    /// Associates the Creative Work with the Primary Format instance
    /// <see href="http://www.bbc.co.uk/ontologies/creativework/primaryFormat"></see></summary>
    let primaryFormat = _prefix "primaryFormat"
    /// <summary>
    /// The sort title of the Creative Work
    /// <see href="http://www.bbc.co.uk/ontologies/creativework/shortTitle"></see></summary>
    let shortTitle = _prefix "shortTitle"
    /// <summary>
    /// Associates the Creative Work with the Thumbnail instance
    /// <see href="http://www.bbc.co.uk/ontologies/creativework/thumbnail"></see></summary>
    let thumbnail = _prefix "thumbnail"
    /// <summary>
    /// Associates the Thumbnail instance with a Thumbnail type
    /// <see href="http://www.bbc.co.uk/ontologies/creativework/thumbnailType"></see></summary>
    let thumbnailType = _prefix "thumbnailType"
    /// <summary>
    /// The title of the Creative Work
    /// <see href="http://www.bbc.co.uk/ontologies/creativework/title"></see></summary>
    let title = _prefix "title"
