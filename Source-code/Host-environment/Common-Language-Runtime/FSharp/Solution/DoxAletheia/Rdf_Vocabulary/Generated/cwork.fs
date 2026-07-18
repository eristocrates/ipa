namespace http.www.bbc.co.uk.ontologies.creativework.slash

open DoxAletheia.Rdf_Vocabulary

module cwork =
    let _namespace_name = "http://www.bbc.co.uk/ontologies/creativework/"
    /// <summary>
    ///   <see href="http://www.bbc.co.uk/ontologies/creativework/1.10"></see>
    /// </summary>
    let ``_1.10`` = Namespaced_IRI.parse _namespace_name "1.10" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.bbc.co.uk/ontologies/creativework/1.11"></see>
    /// </summary>
    let ``_1.11`` = Namespaced_IRI.parse _namespace_name "1.11" |> NamespacedName
    /// <summary>
    /// Enumerated class of the audiences the BBC creates content for.
    /// <see href="http://www.bbc.co.uk/ontologies/creativework/Audience"></see></summary>
    let Audience = Namespaced_IRI.parse _namespace_name "Audience" |> NamespacedName

    /// <summary>
    /// Used to represent that the primary format of a CreativeWork is Audio.
    /// <see href="http://www.bbc.co.uk/ontologies/creativework/AudioFormat"></see></summary>
    let AudioFormat =
        Namespaced_IRI.parse _namespace_name "AudioFormat" |> NamespacedName

    /// <summary>
    /// The primary format of the CreativeWork and it can be one of the five instances. This is needed for selecting the appropriate icon with which to overlay the preview thumbnail of the creative work.
    /// <see href="http://www.bbc.co.uk/ontologies/creativework/Format"></see></summary>
    let Format = Namespaced_IRI.parse _namespace_name "Format" |> NamespacedName
    /// <summary>
    /// This is the class of creative works that are associated with particular journalists or correspondents. The analysis, commentary and personal viewpoint of the creator is reflected on the blog post and the blog post is usually associated prominently with the name of the creator. BlogPost can have different types of formats.
    /// <see href="http://www.bbc.co.uk/ontologies/creativework/BlogPost"></see></summary>
    let BlogPost = Namespaced_IRI.parse _namespace_name "BlogPost" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.bbc.co.uk/ontologies/creativework/1.4"></see>
    /// </summary>
    let ``_1.4`` = Namespaced_IRI.parse _namespace_name "1.4" |> NamespacedName

    /// <summary>
    /// The class of creative works produced by the BBC.
    /// <see href="http://www.bbc.co.uk/ontologies/creativework/CreativeWork"></see></summary>
    let CreativeWork =
        Namespaced_IRI.parse _namespace_name "CreativeWork" |> NamespacedName

    /// <summary>
    /// A class to represent different categorisations of creative works from different clients. This class is instantiated in the clients' application logic models.
    /// <see href="http://www.bbc.co.uk/ontologies/creativework/Category"></see></summary>
    let Category = Namespaced_IRI.parse _namespace_name "Category" |> NamespacedName
    /// <summary>
    /// The Clips subclass of programmes produced by the BBC.
    /// <see href="http://www.bbc.co.uk/ontologies/creativework/Clip"></see></summary>
    let Clip = Namespaced_IRI.parse _namespace_name "Clip" |> NamespacedName
    /// <summary>
    /// The class of programmes produced by the BBC
    /// <see href="http://www.bbc.co.uk/ontologies/creativework/Programme"></see></summary>
    let Programme = Namespaced_IRI.parse _namespace_name "Programme" |> NamespacedName

    /// <summary>
    /// A 16x9 image, focused and zoomed in one part of the image, usually when the standard thumbnail is very small to be meaningful (e.g., in mobile).
    /// <see href="http://www.bbc.co.uk/ontologies/creativework/CloseUpThumbnail"></see></summary>
    let CloseUpThumbnail =
        Namespaced_IRI.parse _namespace_name "CloseUpThumbnail" |> NamespacedName

    /// <summary>
    /// Enumerated class of the allowed thumbnail types
    /// <see href="http://www.bbc.co.uk/ontologies/creativework/ThumbnailType"></see></summary>
    let ThumbnailType =
        Namespaced_IRI.parse _namespace_name "ThumbnailType" |> NamespacedName

    /// <summary>
    /// This class represents short form creative works in the shape of updates. These differ from the other types of creative works because they haven't got independent URLs  as (primaryContentOf) from which they can be retrieved.
    /// <see href="http://www.bbc.co.uk/ontologies/creativework/Commentary"></see></summary>
    let Commentary = Namespaced_IRI.parse _namespace_name "Commentary" |> NamespacedName
    /// <summary>
    /// The Episodes subclass of programmes produced by the BBC.
    /// <see href="http://www.bbc.co.uk/ontologies/creativework/Episode"></see></summary>
    let Episode = Namespaced_IRI.parse _namespace_name "Episode" |> NamespacedName

    /// <summary>
    /// Fixed size thumbnail
    /// <see href="http://www.bbc.co.uk/ontologies/creativework/FixedSize144Thumbnail"></see></summary>
    let FixedSize144Thumbnail =
        Namespaced_IRI.parse _namespace_name "FixedSize144Thumbnail" |> NamespacedName

    /// <summary>
    /// Fixed size thumbnail
    /// <see href="http://www.bbc.co.uk/ontologies/creativework/FixedSize224Thumbnail"></see></summary>
    let FixedSize224Thumbnail =
        Namespaced_IRI.parse _namespace_name "FixedSize224Thumbnail" |> NamespacedName

    /// <summary>
    /// Fixed size thumbnail
    /// <see href="http://www.bbc.co.uk/ontologies/creativework/FixedSize226Thumbnail"></see></summary>
    let FixedSize226Thumbnail =
        Namespaced_IRI.parse _namespace_name "FixedSize226Thumbnail" |> NamespacedName

    /// <summary>
    /// Fixed size thumbnail
    /// <see href="http://www.bbc.co.uk/ontologies/creativework/FixedSize464Thumbnail"></see></summary>
    let FixedSize464Thumbnail =
        Namespaced_IRI.parse _namespace_name "FixedSize464Thumbnail" |> NamespacedName

    /// <summary>
    /// Fixed size thumbnail
    /// <see href="http://www.bbc.co.uk/ontologies/creativework/FixedSize66Thumbnail"></see></summary>
    let FixedSize66Thumbnail =
        Namespaced_IRI.parse _namespace_name "FixedSize66Thumbnail" |> NamespacedName

    /// <summary>
    /// Used to represent that the primary format of a CreativeWork is Image
    /// <see href="http://www.bbc.co.uk/ontologies/creativework/ImageFormat"></see></summary>
    let ImageFormat =
        Namespaced_IRI.parse _namespace_name "ImageFormat" |> NamespacedName

    /// <summary>
    /// Used to represent that the primary format of a CreativeWork is Interactive
    /// <see href="http://www.bbc.co.uk/ontologies/creativework/InteractiveFormat"></see></summary>
    let InteractiveFormat =
        Namespaced_IRI.parse _namespace_name "InteractiveFormat" |> NamespacedName

    /// <summary>
    /// The international (non UK) audience. The creative works linked to this instance are *only available to the international audience*.
    /// <see href="http://www.bbc.co.uk/ontologies/creativework/InternationalAudience"></see></summary>
    let InternationalAudience =
        Namespaced_IRI.parse _namespace_name "InternationalAudience" |> NamespacedName

    /// <summary>
    /// This class is used to describe that creative works which are coverage of a live event. (Note that this isn't meant to describe the fact that the event is live currently. An example of a Live Coverage creative work is the live event page covering live the England VS Australia cricket match, last saturday's football matches or last year's elections)
    /// <see href="http://www.bbc.co.uk/ontologies/creativework/LiveCoverage"></see></summary>
    let LiveCoverage =
        Namespaced_IRI.parse _namespace_name "LiveCoverage" |> NamespacedName

    /// <summary>
    /// This class is created to support the LiveEventPages from CPS. This will be soon deprecated for the sake of LiveCoverage
    /// <see href="http://www.bbc.co.uk/ontologies/creativework/LiveEventPage"></see></summary>
    let LiveEventPage =
        Namespaced_IRI.parse _namespace_name "LiveEventPage" |> NamespacedName

    /// <summary>
    /// The national audience. The creative works linked to this instance are *only available to the national audience*.
    /// <see href="http://www.bbc.co.uk/ontologies/creativework/NationalAudience"></see></summary>
    let NationalAudience =
        Namespaced_IRI.parse _namespace_name "NationalAudience" |> NamespacedName

    /// <summary>
    /// The class of all news items that the BBC produces. They can be textual articles, or media asset pages (audio or video) or live coverage of events (use the liveCoverage property).
    /// <see href="http://www.bbc.co.uk/ontologies/creativework/NewsItem"></see></summary>
    let NewsItem = Namespaced_IRI.parse _namespace_name "NewsItem" |> NamespacedName

    /// <summary>
    /// Used to represent that the primary format of a CreativeWork is of PictureGallery (this is a mid-term solution for the modelling of galleries)
    /// <see href="http://www.bbc.co.uk/ontologies/creativework/PictureGalleryFormat"></see></summary>
    let PictureGalleryFormat =
        Namespaced_IRI.parse _namespace_name "PictureGalleryFormat" |> NamespacedName

    /// <summary>
    /// A 16x9 image used in most occasions
    /// <see href="http://www.bbc.co.uk/ontologies/creativework/StandardThumbnail"></see></summary>
    let StandardThumbnail =
        Namespaced_IRI.parse _namespace_name "StandardThumbnail" |> NamespacedName

    /// <summary>
    /// Used to represent that the primary format of a CreativeWork is Text
    /// <see href="http://www.bbc.co.uk/ontologies/creativework/TextualFormat"></see></summary>
    let TextualFormat =
        Namespaced_IRI.parse _namespace_name "TextualFormat" |> NamespacedName

    /// <summary>
    /// Used to associate a Creative Work with the canonical location of the thumbnail. The URI of each of its instances is the full canonical location of the thumbnail
    /// <see href="http://www.bbc.co.uk/ontologies/creativework/Thumbnail"></see></summary>
    let Thumbnail = Namespaced_IRI.parse _namespace_name "Thumbnail" |> NamespacedName

    /// <summary>
    /// This class is used to describe creative works which are Travel Incidents.
    /// <see href="http://www.bbc.co.uk/ontologies/creativework/TravelIncident"></see></summary>
    let TravelIncident =
        Namespaced_IRI.parse _namespace_name "TravelIncident" |> NamespacedName

    /// <summary>
    /// Used to represent that the primary format of a CreativeWork is Video
    /// <see href="http://www.bbc.co.uk/ontologies/creativework/VideoFormat"></see></summary>
    let VideoFormat =
        Namespaced_IRI.parse _namespace_name "VideoFormat" |> NamespacedName

    /// <summary>
    /// This class is used to describe creative works which are Weather Alerts.
    /// <see href="http://www.bbc.co.uk/ontologies/creativework/WeatherAlert"></see></summary>
    let WeatherAlert =
        Namespaced_IRI.parse _namespace_name "WeatherAlert" |> NamespacedName

    /// <summary>
    /// Indicates that the creative work is about a tag concept
    /// <see href="http://www.bbc.co.uk/ontologies/creativework/about"></see></summary>
    let about = Namespaced_IRI.parse _namespace_name "about" |> NamespacedName
    /// <summary>
    /// Indicates that the creative work is tagged with tag concept
    /// <see href="http://www.bbc.co.uk/ontologies/creativework/tag"></see></summary>
    let tag = Namespaced_IRI.parse _namespace_name "tag" |> NamespacedName
    /// <summary>
    /// The alternative text for a thumbnail in case the URL is not resolved
    /// <see href="http://www.bbc.co.uk/ontologies/creativework/altText"></see></summary>
    let altText = Namespaced_IRI.parse _namespace_name "altText" |> NamespacedName
    /// <summary>
    /// Associates the Creative Work with an audience instance
    /// <see href="http://www.bbc.co.uk/ontologies/creativework/audience"></see></summary>
    let audience = Namespaced_IRI.parse _namespace_name "audience" |> NamespacedName
    /// <summary>
    /// The category property is another mid term solution for maintaining the functionality supporting individual clients. For example, the type of gossip is something that the sports pal use for the moment. The values of the property are decided by the client teams in collaboration with LDP
    /// <see href="http://www.bbc.co.uk/ontologies/creativework/category"></see></summary>
    let category = Namespaced_IRI.parse _namespace_name "category" |> NamespacedName
    /// <summary>
    /// associate a creative work with its creator
    /// <see href="http://www.bbc.co.uk/ontologies/creativework/createdBy"></see></summary>
    let createdBy = Namespaced_IRI.parse _namespace_name "createdBy" |> NamespacedName

    /// <summary>
    /// Date created of CreativeWork
    /// <see href="http://www.bbc.co.uk/ontologies/creativework/dateCreated"></see></summary>
    let dateCreated =
        Namespaced_IRI.parse _namespace_name "dateCreated" |> NamespacedName

    /// <summary>
    /// Date modified of CreativeWork
    /// <see href="http://www.bbc.co.uk/ontologies/creativework/dateModified"></see></summary>
    let dateModified =
        Namespaced_IRI.parse _namespace_name "dateModified" |> NamespacedName

    /// <summary>
    /// The description of the Creative Work
    /// <see href="http://www.bbc.co.uk/ontologies/creativework/description"></see></summary>
    let description =
        Namespaced_IRI.parse _namespace_name "description" |> NamespacedName

    /// <summary>
    /// The language of the creative work, please use BCP47 https://tools.ietf.org/html/bcp47
    /// <see href="http://www.bbc.co.uk/ontologies/creativework/language"></see></summary>
    let language = Namespaced_IRI.parse _namespace_name "language" |> NamespacedName
    /// <summary>
    /// Indicates that the creative work mentions a tag concept
    /// <see href="http://www.bbc.co.uk/ontologies/creativework/mentions"></see></summary>
    let mentions = Namespaced_IRI.parse _namespace_name "mentions" |> NamespacedName

    /// <summary>
    /// Associates the Creative Work with the Primary Format instance
    /// <see href="http://www.bbc.co.uk/ontologies/creativework/primaryFormat"></see></summary>
    let primaryFormat =
        Namespaced_IRI.parse _namespace_name "primaryFormat" |> NamespacedName

    /// <summary>
    /// The sort title of the Creative Work
    /// <see href="http://www.bbc.co.uk/ontologies/creativework/shortTitle"></see></summary>
    let shortTitle = Namespaced_IRI.parse _namespace_name "shortTitle" |> NamespacedName
    /// <summary>
    /// Associates the Creative Work with the Thumbnail instance
    /// <see href="http://www.bbc.co.uk/ontologies/creativework/thumbnail"></see></summary>
    let thumbnail = Namespaced_IRI.parse _namespace_name "thumbnail" |> NamespacedName

    /// <summary>
    /// Associates the Thumbnail instance with a Thumbnail type
    /// <see href="http://www.bbc.co.uk/ontologies/creativework/thumbnailType"></see></summary>
    let thumbnailType =
        Namespaced_IRI.parse _namespace_name "thumbnailType" |> NamespacedName

    /// <summary>
    /// The title of the Creative Work
    /// <see href="http://www.bbc.co.uk/ontologies/creativework/title"></see></summary>
    let title = Namespaced_IRI.parse _namespace_name "title" |> NamespacedName
