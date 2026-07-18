namespace http.www.eclap.eu.schema.eclap.slash

open DoxAletheia.Rdf_Vocabulary

module eclap =
    let _namespace_name = "http://www.eclap.eu/schema/eclap/"
    /// <summary>
    /// A 3D content
    /// <see href="http://www.eclap.eu/schema/eclap/3D"></see></summary>
    let _3D = Namespaced_IRI.parse _namespace_name "3D" |> NamespacedName

    /// <summary>
    /// A multimedia content
    /// <see href="http://www.eclap.eu/schema/eclap/MediaObject"></see></summary>
    let MediaObject =
        Namespaced_IRI.parse _namespace_name "MediaObject" |> NamespacedName

    /// <summary>
    /// An audio visual content
    /// <see href="http://www.eclap.eu/schema/eclap/AVObject"></see></summary>
    let AVObject = Namespaced_IRI.parse _namespace_name "AVObject" |> NamespacedName
    /// <summary>
    /// An archival content as ZIP, RAR, TAR, etc.
    /// <see href="http://www.eclap.eu/schema/eclap/Archive"></see></summary>
    let Archive = Namespaced_IRI.parse _namespace_name "Archive" |> NamespacedName
    /// <summary>
    /// An audio content
    /// <see href="http://www.eclap.eu/schema/eclap/Audio"></see></summary>
    let Audio = Namespaced_IRI.parse _namespace_name "Audio" |> NamespacedName

    /// <summary>
    /// A music score written in braille
    /// <see href="http://www.eclap.eu/schema/eclap/BrailleMusicScore"></see></summary>
    let BrailleMusicScore =
        Namespaced_IRI.parse _namespace_name "BrailleMusicScore" |> NamespacedName

    /// <summary>
    /// A collection of other content
    /// <see href="http://www.eclap.eu/schema/eclap/Collection"></see></summary>
    let Collection = Namespaced_IRI.parse _namespace_name "Collection" |> NamespacedName
    /// <summary>
    /// A cross media content
    /// <see href="http://www.eclap.eu/schema/eclap/Crossmedia"></see></summary>
    let Crossmedia = Namespaced_IRI.parse _namespace_name "Crossmedia" |> NamespacedName
    /// <summary>
    /// A textual document
    /// <see href="http://www.eclap.eu/schema/eclap/Document"></see></summary>
    let Document = Namespaced_IRI.parse _namespace_name "Document" |> NamespacedName
    /// <summary>
    /// An e-pub based content
    /// <see href="http://www.eclap.eu/schema/eclap/EPub"></see></summary>
    let EPub = Namespaced_IRI.parse _namespace_name "EPub" |> NamespacedName
    /// <summary>
    /// A spreadsheet based content
    /// <see href="http://www.eclap.eu/schema/eclap/Excel"></see></summary>
    let Excel = Namespaced_IRI.parse _namespace_name "Excel" |> NamespacedName
    /// <summary>
    /// An explosive annotation
    /// <see href="http://www.eclap.eu/schema/eclap/Explosive"></see></summary>
    let Explosive = Namespaced_IRI.parse _namespace_name "Explosive" |> NamespacedName
    /// <summary>
    /// An image based content
    /// <see href="http://www.eclap.eu/schema/eclap/Image"></see></summary>
    let Image = Namespaced_IRI.parse _namespace_name "Image" |> NamespacedName
    /// <summary>
    /// An One2One annotation
    /// <see href="http://www.eclap.eu/schema/eclap/One2One"></see></summary>
    let One2One = Namespaced_IRI.parse _namespace_name "One2One" |> NamespacedName
    /// <summary>
    /// A playlist of audio visual content
    /// <see href="http://www.eclap.eu/schema/eclap/Playlist"></see></summary>
    let Playlist = Namespaced_IRI.parse _namespace_name "Playlist" |> NamespacedName
    /// <summary>
    /// A Slide based content (e.g. PPT)
    /// <see href="http://www.eclap.eu/schema/eclap/Slide"></see></summary>
    let Slide = Namespaced_IRI.parse _namespace_name "Slide" |> NamespacedName
    /// <summary>
    /// A tool content (e.g. an executable file)
    /// <see href="http://www.eclap.eu/schema/eclap/Tool"></see></summary>
    let Tool = Namespaced_IRI.parse _namespace_name "Tool" |> NamespacedName
    /// <summary>
    /// An User registered on ECLAP portal
    /// <see href="http://www.eclap.eu/schema/eclap/User"></see></summary>
    let User = Namespaced_IRI.parse _namespace_name "User" |> NamespacedName
    /// <summary>
    /// A Video content
    /// <see href="http://www.eclap.eu/schema/eclap/Video"></see></summary>
    let Video = Namespaced_IRI.parse _namespace_name "Video" |> NamespacedName
    /// <summary>
    /// Indicates the name of an "acrobat" involved in life-cycle of the performance depicted/referred in the resource
    /// <see href="http://www.eclap.eu/schema/eclap/acrobat"></see></summary>
    let acrobat = Namespaced_IRI.parse _namespace_name "acrobat" |> NamespacedName

    /// <summary>
    /// Indicates a name of a performing arts professional involved in the creation of the creative work
    /// <see href="http://www.eclap.eu/schema/eclap/performingArtsProfessional"></see></summary>
    let performingArtsProfessional =
        Namespaced_IRI.parse _namespace_name "performingArtsProfessional" |> NamespacedName

    /// <summary>
    /// Indicates the name of an "actor" involved in life-cycle of the performance depicted/referred in the resource
    /// <see href="http://www.eclap.eu/schema/eclap/actor"></see></summary>
    let actor = Namespaced_IRI.parse _namespace_name "actor" |> NamespacedName
    /// <summary>
    /// Indicates the name of an "adaptor" involved in life-cycle of the performance depicted/referred in the resource
    /// <see href="http://www.eclap.eu/schema/eclap/adaptator"></see></summary>
    let adaptator = Namespaced_IRI.parse _namespace_name "adaptator" |> NamespacedName
    /// <summary>
    /// Indicates the User that is the administrator of a group
    /// <see href="http://www.eclap.eu/schema/eclap/admin"></see></summary>
    let admin = Namespaced_IRI.parse _namespace_name "admin" |> NamespacedName
    /// <summary>
    /// Indicates the name of an "architect" involved in life-cycle of the performance depicted/referred in the resource
    /// <see href="http://www.eclap.eu/schema/eclap/architect"></see></summary>
    let architect = Namespaced_IRI.parse _namespace_name "architect" |> NamespacedName

    /// <summary>
    /// Indicates the artistic momement and acting style used for the performance depicted/referred in the resource
    /// <see href="http://www.eclap.eu/schema/eclap/artisticMovementAndActingStyle"></see></summary>
    let artisticMovementAndActingStyle =
        Namespaced_IRI.parse _namespace_name "artisticMovementAndActingStyle" |> NamespacedName

    /// <summary>
    /// Indicates the name of an "assistant director" involved in life-cycle of the performance depicted/referred in the resource
    /// <see href="http://www.eclap.eu/schema/eclap/assistantDirector"></see></summary>
    let assistantDirector =
        Namespaced_IRI.parse _namespace_name "assistantDirector" |> NamespacedName

    /// <summary>
    /// Indicates name or names in the cast
    /// <see href="http://www.eclap.eu/schema/eclap/cast"></see></summary>
    let cast = Namespaced_IRI.parse _namespace_name "cast" |> NamespacedName

    /// <summary>
    /// Indicates the name or names of performers and crew involved in the creation of the performance depicted/referred in the resource
    /// <see href="http://www.eclap.eu/schema/eclap/performersAndCrew"></see></summary>
    let performersAndCrew =
        Namespaced_IRI.parse _namespace_name "performersAndCrew" |> NamespacedName

    /// <summary>
    /// Indicates the name of a "casting" involved in life-cycle of the performance depicted/referred in the resource
    /// <see href="http://www.eclap.eu/schema/eclap/casting"></see></summary>
    let casting = Namespaced_IRI.parse _namespace_name "casting" |> NamespacedName

    /// <summary>
    /// Indicates the name of an "choreographer" involved in life-cycle of the performance depicted/referred in the resource
    /// <see href="http://www.eclap.eu/schema/eclap/choreographer"></see></summary>
    let choreographer =
        Namespaced_IRI.parse _namespace_name "choreographer" |> NamespacedName

    /// <summary>
    /// Indicates the name of a "clown" involved in life-cycle of the performance depicted/referred in the resource
    /// <see href="http://www.eclap.eu/schema/eclap/clown"></see></summary>
    let clown = Namespaced_IRI.parse _namespace_name "clown" |> NamespacedName
    /// <summary>
    /// Indicates the name of a "composer" involved in life-cycle of the performance depicted/referred in the resource
    /// <see href="http://www.eclap.eu/schema/eclap/composer"></see></summary>
    let composer = Namespaced_IRI.parse _namespace_name "composer" |> NamespacedName

    /// <summary>
    /// Indicates the name of a "concept originator" involved in life-cycle of the performance depicted/referred in the resource
    /// <see href="http://www.eclap.eu/schema/eclap/conceptOriginator"></see></summary>
    let conceptOriginator =
        Namespaced_IRI.parse _namespace_name "conceptOriginator" |> NamespacedName

    /// <summary>
    /// Indicates the name of a "costume designer" involved in life-cycle of the performance depicted/referred in the resource
    /// <see href="http://www.eclap.eu/schema/eclap/costumeDesigner"></see></summary>
    let costumeDesigner =
        Namespaced_IRI.parse _namespace_name "costumeDesigner" |> NamespacedName

    /// <summary>
    /// Indicates an annotation created by an User
    /// <see href="http://www.eclap.eu/schema/eclap/createdAnnotation"></see></summary>
    let createdAnnotation =
        Namespaced_IRI.parse _namespace_name "createdAnnotation" |> NamespacedName

    /// <summary>
    /// Indicates the name of a "critic" involved in life-cycle of the performance depicted/referred in the resource
    /// <see href="http://www.eclap.eu/schema/eclap/critic"></see></summary>
    let critic = Namespaced_IRI.parse _namespace_name "critic" |> NamespacedName
    /// <summary>
    /// Indicates the name of a "dancer" involved in life-cycle of the performance depicted/referred in the resource
    /// <see href="http://www.eclap.eu/schema/eclap/dancer"></see></summary>
    let dancer = Namespaced_IRI.parse _namespace_name "dancer" |> NamespacedName
    /// <summary>
    /// Indicates the name of a "director" involved in life-cycle of the performance depicted/referred in the resource
    /// <see href="http://www.eclap.eu/schema/eclap/director"></see></summary>
    let director = Namespaced_IRI.parse _namespace_name "director" |> NamespacedName
    /// <summary>
    /// Indicates the name of a "dramaturge" involved in life-cycle of the performance depicted/referred in the resource
    /// <see href="http://www.eclap.eu/schema/eclap/dramaturge"></see></summary>
    let dramaturge = Namespaced_IRI.parse _namespace_name "dramaturge" |> NamespacedName

    /// <summary>
    /// Indicates the city where the first performance (or premiere) of the performance depicted/referred in the resource was held
    /// <see href="http://www.eclap.eu/schema/eclap/firstPerformanceCity"></see></summary>
    let firstPerformanceCity =
        Namespaced_IRI.parse _namespace_name "firstPerformanceCity" |> NamespacedName

    /// <summary>
    /// Indicates the country where the first performance (or premiere) of the performance depicted/referred in the resource was held
    /// <see href="http://www.eclap.eu/schema/eclap/firstPerformanceCountry"></see></summary>
    let firstPerformanceCountry =
        Namespaced_IRI.parse _namespace_name "firstPerformanceCountry" |> NamespacedName

    /// <summary>
    /// Indicates the date of the first performance (or premiere) of the performance depicted/referred in the resource
    /// <see href="http://www.eclap.eu/schema/eclap/firstPerformanceDate"></see></summary>
    let firstPerformanceDate =
        Namespaced_IRI.parse _namespace_name "firstPerformanceDate" |> NamespacedName

    /// <summary>
    /// Indicates the place (e.g, the theatre) where the first performance (or premiere) of the performance depicted/referred in the resource was held
    /// <see href="http://www.eclap.eu/schema/eclap/firstPerformancePlace"></see></summary>
    let firstPerformancePlace =
        Namespaced_IRI.parse _namespace_name "firstPerformancePlace" |> NamespacedName

    /// <summary>
    /// Indicates the genre of the creative work
    /// <see href="http://www.eclap.eu/schema/eclap/genre"></see></summary>
    let genre = Namespaced_IRI.parse _namespace_name "genre" |> NamespacedName

    /// <summary>
    /// Indicates the name of a "hairdresser" involved in life-cycle of the performance depicted/referred in the resource
    /// <see href="http://www.eclap.eu/schema/eclap/hairdresser"></see></summary>
    let hairdresser =
        Namespaced_IRI.parse _namespace_name "hairdresser" |> NamespacedName

    /// <summary>
    /// Indicates the annotation associated with a content
    /// <see href="http://www.eclap.eu/schema/eclap/hasAnnotation"></see></summary>
    let hasAnnotation =
        Namespaced_IRI.parse _namespace_name "hasAnnotation" |> NamespacedName

    /// <summary>
    /// Indicates that an User has as favorite a content
    /// <see href="http://www.eclap.eu/schema/eclap/hasFavorite"></see></summary>
    let hasFavorite =
        Namespaced_IRI.parse _namespace_name "hasFavorite" |> NamespacedName

    /// <summary>
    /// Indicates that a resource is favorite from an User
    /// <see href="http://www.eclap.eu/schema/eclap/isFavoriteOf"></see></summary>
    let isFavoriteOf =
        Namespaced_IRI.parse _namespace_name "isFavoriteOf" |> NamespacedName

    /// <summary>
    /// Indicates that an User has made featured a content
    /// <see href="http://www.eclap.eu/schema/eclap/hasFeatured"></see></summary>
    let hasFeatured =
        Namespaced_IRI.parse _namespace_name "hasFeatured" |> NamespacedName

    /// <summary>
    /// Indicates that a resource is featured by an User
    /// <see href="http://www.eclap.eu/schema/eclap/isFeaturedBy"></see></summary>
    let isFeaturedBy =
        Namespaced_IRI.parse _namespace_name "isFeaturedBy" |> NamespacedName

    /// <summary>
    /// Indicates the historical period
    /// <see href="http://www.eclap.eu/schema/eclap/historicaPeriod"></see></summary>
    let historicaPeriod =
        Namespaced_IRI.parse _namespace_name "historicaPeriod" |> NamespacedName

    /// <summary>
    /// Indicates that an User is the administrator of a group, and it is also a member of the same group.
    /// <see href="http://www.eclap.eu/schema/eclap/isAdminOf"></see></summary>
    let isAdminOf = Namespaced_IRI.parse _namespace_name "isAdminOf" |> NamespacedName
    /// <summary>
    /// Indicates that a User is member of a group, it is the inverse of the foaof:member property
    /// <see href="http://www.eclap.eu/schema/eclap/isMemberOf"></see></summary>
    let isMemberOf = Namespaced_IRI.parse _namespace_name "isMemberOf" |> NamespacedName

    /// <summary>
    /// Indicates that a resource is provided by a group
    /// <see href="http://www.eclap.eu/schema/eclap/isProvidedBy"></see></summary>
    let isProvidedBy =
        Namespaced_IRI.parse _namespace_name "isProvidedBy" |> NamespacedName

    /// <summary>
    /// Indicates that the concept is the subject of a creative work
    /// <see href="http://www.eclap.eu/schema/eclap/isSubjectOf"></see></summary>
    let isSubjectOf =
        Namespaced_IRI.parse _namespace_name "isSubjectOf" |> NamespacedName

    /// <summary>
    /// Indicates that a resource was uploaded by an User
    /// <see href="http://www.eclap.eu/schema/eclap/isUploadedBy"></see></summary>
    let isUploadedBy =
        Namespaced_IRI.parse _namespace_name "isUploadedBy" |> NamespacedName

    /// <summary>
    /// Indicates the name of a "light designer" involved in life-cycle of the performance depicted/referred in the resource
    /// <see href="http://www.eclap.eu/schema/eclap/lightDesigner"></see></summary>
    let lightDesigner =
        Namespaced_IRI.parse _namespace_name "lightDesigner" |> NamespacedName

    /// <summary>
    /// Indicates the name of a "make-up artist" involved in life-cycle of the performance depicted/referred in the resource
    /// <see href="http://www.eclap.eu/schema/eclap/makeUpArtist"></see></summary>
    let makeUpArtist =
        Namespaced_IRI.parse _namespace_name "makeUpArtist" |> NamespacedName

    /// <summary>
    /// Indicates management and organization information associated with the resource
    /// <see href="http://www.eclap.eu/schema/eclap/managementAndOrganization"></see></summary>
    let managementAndOrganization =
        Namespaced_IRI.parse _namespace_name "managementAndOrganization" |> NamespacedName

    /// <summary>
    /// Indicates the name of a "marketing manager" involved in life-cycle of the performance depicted/referred in the resource
    /// <see href="http://www.eclap.eu/schema/eclap/marketingManager"></see></summary>
    let marketingManager =
        Namespaced_IRI.parse _namespace_name "marketingManager" |> NamespacedName

    /// <summary>
    /// Indicates the name of a "mask designer" involved in life-cycle of the performance depicted/referred in the resource
    /// <see href="http://www.eclap.eu/schema/eclap/maskDesigner"></see></summary>
    let maskDesigner =
        Namespaced_IRI.parse _namespace_name "maskDesigner" |> NamespacedName

    /// <summary>
    /// Indicates the name of a "mime" involved in life-cycle of the performance depicted/referred in the resource
    /// <see href="http://www.eclap.eu/schema/eclap/mime"></see></summary>
    let mime = Namespaced_IRI.parse _namespace_name "mime" |> NamespacedName
    /// <summary>
    /// Indicates the name of a "musician" involved in life-cycle of the performance depicted/referred in the resource
    /// <see href="http://www.eclap.eu/schema/eclap/musician"></see></summary>
    let musician = Namespaced_IRI.parse _namespace_name "musician" |> NamespacedName
    /// <summary>
    /// Indicates the name of a "patron" involved in life-cycle of the performance depicted/referred in the resource
    /// <see href="http://www.eclap.eu/schema/eclap/patron"></see></summary>
    let patron = Namespaced_IRI.parse _namespace_name "patron" |> NamespacedName

    /// <summary>
    /// Indicates the city where the performance depicted/referred in the resource was held
    /// <see href="http://www.eclap.eu/schema/eclap/performanceCity"></see></summary>
    let performanceCity =
        Namespaced_IRI.parse _namespace_name "performanceCity" |> NamespacedName

    /// <summary>
    /// Indicates the country where the performance depicted/referred in the resource was held
    /// <see href="http://www.eclap.eu/schema/eclap/performanceCountry"></see></summary>
    let performanceCountry =
        Namespaced_IRI.parse _namespace_name "performanceCountry" |> NamespacedName

    /// <summary>
    /// Indicates the date when it was performed the performance depicted in the resource
    /// <see href="http://www.eclap.eu/schema/eclap/performanceDate"></see></summary>
    let performanceDate =
        Namespaced_IRI.parse _namespace_name "performanceDate" |> NamespacedName

    /// <summary>
    /// Indicates the place (e.g., the theatre) where the performance depicted/referred in the resource was held
    /// <see href="http://www.eclap.eu/schema/eclap/performancePlace"></see></summary>
    let performancePlace =
        Namespaced_IRI.parse _namespace_name "performancePlace" |> NamespacedName

    /// <summary>
    /// Indicates the name of a "performer" involved in life-cycle of the performance depicted/referred in the resource
    /// <see href="http://www.eclap.eu/schema/eclap/performer"></see></summary>
    let performer = Namespaced_IRI.parse _namespace_name "performer" |> NamespacedName

    /// <summary>
    /// Indicates the type of performing art (e.g. dance, theatre) in the resource
    /// <see href="http://www.eclap.eu/schema/eclap/performingArtType"></see></summary>
    let performingArtType =
        Namespaced_IRI.parse _namespace_name "performingArtType" |> NamespacedName

    /// <summary>
    /// Indicates the group that was involved in the performance creation
    /// <see href="http://www.eclap.eu/schema/eclap/performingArtsGroup"></see></summary>
    let performingArtsGroup =
        Namespaced_IRI.parse _namespace_name "performingArtsGroup" |> NamespacedName

    /// <summary>
    /// Indicates the name of a "playwright" involved in life-cycle of the performance depicted/referred in the resource
    /// <see href="http://www.eclap.eu/schema/eclap/playwright"></see></summary>
    let playwright = Namespaced_IRI.parse _namespace_name "playwright" |> NamespacedName

    /// <summary>
    /// Indicates the summary of the plot of the performance depicted/referred in the resource
    /// <see href="http://www.eclap.eu/schema/eclap/plotSummary"></see></summary>
    let plotSummary =
        Namespaced_IRI.parse _namespace_name "plotSummary" |> NamespacedName

    /// <summary>
    /// Indicates the name of a "producer" involved in life-cycle of the performance depicted/referred in the resource
    /// <see href="http://www.eclap.eu/schema/eclap/producer"></see></summary>
    let producer = Namespaced_IRI.parse _namespace_name "producer" |> NamespacedName
    /// <summary>
    /// Indicates the resources provided by a Group
    /// <see href="http://www.eclap.eu/schema/eclap/provide"></see></summary>
    let provide = Namespaced_IRI.parse _namespace_name "provide" |> NamespacedName

    /// <summary>
    /// Indicates the name of a "puppet designer" involved in life-cycle of the performance depicted/referred in the resource
    /// <see href="http://www.eclap.eu/schema/eclap/puppetDesigner"></see></summary>
    let puppetDesigner =
        Namespaced_IRI.parse _namespace_name "puppetDesigner" |> NamespacedName

    /// <summary>
    /// Indicates the date of recording of the original audio visual resource
    /// <see href="http://www.eclap.eu/schema/eclap/recordingDate"></see></summary>
    let recordingDate =
        Namespaced_IRI.parse _namespace_name "recordingDate" |> NamespacedName

    /// <summary>
    /// Indicates the name of a "scenographer" involved in life-cycle of the performance depicted/referred in the resource
    /// <see href="http://www.eclap.eu/schema/eclap/scenographer"></see></summary>
    let scenographer =
        Namespaced_IRI.parse _namespace_name "scenographer" |> NamespacedName

    /// <summary>
    /// Indicates the name of a "seamster" involved in life-cycle of the performance depicted/referred in the resource
    /// <see href="http://www.eclap.eu/schema/eclap/seamster"></see></summary>
    let seamster = Namespaced_IRI.parse _namespace_name "seamster" |> NamespacedName
    /// <summary>
    /// Indicates the name of a "set builder" involved in life-cycle of the performance depicted/referred in the resource
    /// <see href="http://www.eclap.eu/schema/eclap/setBuilder"></see></summary>
    let setBuilder = Namespaced_IRI.parse _namespace_name "setBuilder" |> NamespacedName

    /// <summary>
    /// Indicates the name of a "set designer" involved in life-cycle of the performance depicted/referred in the resource
    /// <see href="http://www.eclap.eu/schema/eclap/setDesigner"></see></summary>
    let setDesigner =
        Namespaced_IRI.parse _namespace_name "setDesigner" |> NamespacedName

    /// <summary>
    /// Indicates the name of a "singer" involved in life-cycle of the performance depicted/referred in the resource
    /// <see href="http://www.eclap.eu/schema/eclap/singer"></see></summary>
    let singer = Namespaced_IRI.parse _namespace_name "singer" |> NamespacedName

    /// <summary>
    /// Indicates the name of a "sound designer" involved in life-cycle of the performance depicted/referred in the resource
    /// <see href="http://www.eclap.eu/schema/eclap/soundDesigner"></see></summary>
    let soundDesigner =
        Namespaced_IRI.parse _namespace_name "soundDesigner" |> NamespacedName

    /// <summary>
    /// Indicates the name of a "stage manager" involved in life-cycle of the performance depicted/referred in the resource
    /// <see href="http://www.eclap.eu/schema/eclap/stageManager"></see></summary>
    let stageManager =
        Namespaced_IRI.parse _namespace_name "stageManager" |> NamespacedName

    /// <summary>
    /// Indicates the name of a "technician" involved in life-cycle of the performance depicted/referred in the resource
    /// <see href="http://www.eclap.eu/schema/eclap/technician"></see></summary>
    let technician = Namespaced_IRI.parse _namespace_name "technician" |> NamespacedName

    /// <summary>
    /// Indicates the name of a "theatre manager" involved in life-cycle of the performance depicted/referred in the resource
    /// <see href="http://www.eclap.eu/schema/eclap/theatreManager"></see></summary>
    let theatreManager =
        Namespaced_IRI.parse _namespace_name "theatreManager" |> NamespacedName

    /// <summary>
    /// Indicates the name of a "theoretician" involved in life-cycle of the performance depicted/referred in the resource
    /// <see href="http://www.eclap.eu/schema/eclap/theoretician"></see></summary>
    let theoretician =
        Namespaced_IRI.parse _namespace_name "theoretician" |> NamespacedName

    /// <summary>
    /// Indicates the name of a "translator" involved in life-cycle of the performance depicted/referred in the resource
    /// <see href="http://www.eclap.eu/schema/eclap/translator"></see></summary>
    let translator = Namespaced_IRI.parse _namespace_name "translator" |> NamespacedName
    /// <summary>
    /// Indicates the media objects uploaded by the user
    /// <see href="http://www.eclap.eu/schema/eclap/uploaded"></see></summary>
    let uploaded = Namespaced_IRI.parse _namespace_name "uploaded" |> NamespacedName
