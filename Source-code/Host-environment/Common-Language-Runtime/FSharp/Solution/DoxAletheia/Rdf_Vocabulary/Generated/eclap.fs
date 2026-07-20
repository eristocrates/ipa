namespace http.www.eclap.eu.schema.eclap.slash

open DoxAletheia

module eclap =
    let _namespace_name = "http://www.eclap.eu/schema/eclap/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// A 3D content
    /// <see href="http://www.eclap.eu/schema/eclap/3D"></see></summary>
    let _3D = _prefix "3D"
    /// <summary>
    /// A multimedia content
    /// <see href="http://www.eclap.eu/schema/eclap/MediaObject"></see></summary>
    let MediaObject = _prefix "MediaObject"
    /// <summary>
    /// An audio visual content
    /// <see href="http://www.eclap.eu/schema/eclap/AVObject"></see></summary>
    let AVObject = _prefix "AVObject"
    /// <summary>
    /// An archival content as ZIP, RAR, TAR, etc.
    /// <see href="http://www.eclap.eu/schema/eclap/Archive"></see></summary>
    let Archive = _prefix "Archive"
    /// <summary>
    /// An audio content
    /// <see href="http://www.eclap.eu/schema/eclap/Audio"></see></summary>
    let Audio = _prefix "Audio"
    /// <summary>
    /// A music score written in braille
    /// <see href="http://www.eclap.eu/schema/eclap/BrailleMusicScore"></see></summary>
    let BrailleMusicScore = _prefix "BrailleMusicScore"
    /// <summary>
    /// A collection of other content
    /// <see href="http://www.eclap.eu/schema/eclap/Collection"></see></summary>
    let Collection = _prefix "Collection"
    /// <summary>
    /// A cross media content
    /// <see href="http://www.eclap.eu/schema/eclap/Crossmedia"></see></summary>
    let Crossmedia = _prefix "Crossmedia"
    /// <summary>
    /// A textual document
    /// <see href="http://www.eclap.eu/schema/eclap/Document"></see></summary>
    let Document = _prefix "Document"
    /// <summary>
    /// An e-pub based content
    /// <see href="http://www.eclap.eu/schema/eclap/EPub"></see></summary>
    let EPub = _prefix "EPub"
    /// <summary>
    /// A spreadsheet based content
    /// <see href="http://www.eclap.eu/schema/eclap/Excel"></see></summary>
    let Excel = _prefix "Excel"
    /// <summary>
    /// An explosive annotation
    /// <see href="http://www.eclap.eu/schema/eclap/Explosive"></see></summary>
    let Explosive = _prefix "Explosive"
    /// <summary>
    /// An image based content
    /// <see href="http://www.eclap.eu/schema/eclap/Image"></see></summary>
    let Image = _prefix "Image"
    /// <summary>
    /// An One2One annotation
    /// <see href="http://www.eclap.eu/schema/eclap/One2One"></see></summary>
    let One2One = _prefix "One2One"
    /// <summary>
    /// A playlist of audio visual content
    /// <see href="http://www.eclap.eu/schema/eclap/Playlist"></see></summary>
    let Playlist = _prefix "Playlist"
    /// <summary>
    /// A Slide based content (e.g. PPT)
    /// <see href="http://www.eclap.eu/schema/eclap/Slide"></see></summary>
    let Slide = _prefix "Slide"
    /// <summary>
    /// A tool content (e.g. an executable file)
    /// <see href="http://www.eclap.eu/schema/eclap/Tool"></see></summary>
    let Tool = _prefix "Tool"
    /// <summary>
    /// An User registered on ECLAP portal
    /// <see href="http://www.eclap.eu/schema/eclap/User"></see></summary>
    let User = _prefix "User"
    /// <summary>
    /// A Video content
    /// <see href="http://www.eclap.eu/schema/eclap/Video"></see></summary>
    let Video = _prefix "Video"
    /// <summary>
    /// Indicates the name of an "acrobat" involved in life-cycle of the performance depicted/referred in the resource
    /// <see href="http://www.eclap.eu/schema/eclap/acrobat"></see></summary>
    let acrobat = _prefix "acrobat"
    /// <summary>
    /// Indicates a name of a performing arts professional involved in the creation of the creative work
    /// <see href="http://www.eclap.eu/schema/eclap/performingArtsProfessional"></see></summary>
    let performingArtsProfessional = _prefix "performingArtsProfessional"
    /// <summary>
    /// Indicates the name of an "actor" involved in life-cycle of the performance depicted/referred in the resource
    /// <see href="http://www.eclap.eu/schema/eclap/actor"></see></summary>
    let actor = _prefix "actor"
    /// <summary>
    /// Indicates the name of an "adaptor" involved in life-cycle of the performance depicted/referred in the resource
    /// <see href="http://www.eclap.eu/schema/eclap/adaptator"></see></summary>
    let adaptator = _prefix "adaptator"
    /// <summary>
    /// Indicates the User that is the administrator of a group
    /// <see href="http://www.eclap.eu/schema/eclap/admin"></see></summary>
    let admin = _prefix "admin"
    /// <summary>
    /// Indicates the name of an "architect" involved in life-cycle of the performance depicted/referred in the resource
    /// <see href="http://www.eclap.eu/schema/eclap/architect"></see></summary>
    let architect = _prefix "architect"
    /// <summary>
    /// Indicates the artistic momement and acting style used for the performance depicted/referred in the resource
    /// <see href="http://www.eclap.eu/schema/eclap/artisticMovementAndActingStyle"></see></summary>
    let artisticMovementAndActingStyle = _prefix "artisticMovementAndActingStyle"
    /// <summary>
    /// Indicates the name of an "assistant director" involved in life-cycle of the performance depicted/referred in the resource
    /// <see href="http://www.eclap.eu/schema/eclap/assistantDirector"></see></summary>
    let assistantDirector = _prefix "assistantDirector"
    /// <summary>
    /// Indicates name or names in the cast
    /// <see href="http://www.eclap.eu/schema/eclap/cast"></see></summary>
    let cast = _prefix "cast"
    /// <summary>
    /// Indicates the name or names of performers and crew involved in the creation of the performance depicted/referred in the resource
    /// <see href="http://www.eclap.eu/schema/eclap/performersAndCrew"></see></summary>
    let performersAndCrew = _prefix "performersAndCrew"
    /// <summary>
    /// Indicates the name of a "casting" involved in life-cycle of the performance depicted/referred in the resource
    /// <see href="http://www.eclap.eu/schema/eclap/casting"></see></summary>
    let casting = _prefix "casting"
    /// <summary>
    /// Indicates the name of an "choreographer" involved in life-cycle of the performance depicted/referred in the resource
    /// <see href="http://www.eclap.eu/schema/eclap/choreographer"></see></summary>
    let choreographer = _prefix "choreographer"
    /// <summary>
    /// Indicates the name of a "clown" involved in life-cycle of the performance depicted/referred in the resource
    /// <see href="http://www.eclap.eu/schema/eclap/clown"></see></summary>
    let clown = _prefix "clown"
    /// <summary>
    /// Indicates the name of a "composer" involved in life-cycle of the performance depicted/referred in the resource
    /// <see href="http://www.eclap.eu/schema/eclap/composer"></see></summary>
    let composer = _prefix "composer"
    /// <summary>
    /// Indicates the name of a "concept originator" involved in life-cycle of the performance depicted/referred in the resource
    /// <see href="http://www.eclap.eu/schema/eclap/conceptOriginator"></see></summary>
    let conceptOriginator = _prefix "conceptOriginator"
    /// <summary>
    /// Indicates the name of a "costume designer" involved in life-cycle of the performance depicted/referred in the resource
    /// <see href="http://www.eclap.eu/schema/eclap/costumeDesigner"></see></summary>
    let costumeDesigner = _prefix "costumeDesigner"
    /// <summary>
    /// Indicates an annotation created by an User
    /// <see href="http://www.eclap.eu/schema/eclap/createdAnnotation"></see></summary>
    let createdAnnotation = _prefix "createdAnnotation"
    /// <summary>
    /// Indicates the name of a "critic" involved in life-cycle of the performance depicted/referred in the resource
    /// <see href="http://www.eclap.eu/schema/eclap/critic"></see></summary>
    let critic = _prefix "critic"
    /// <summary>
    /// Indicates the name of a "dancer" involved in life-cycle of the performance depicted/referred in the resource
    /// <see href="http://www.eclap.eu/schema/eclap/dancer"></see></summary>
    let dancer = _prefix "dancer"
    /// <summary>
    /// Indicates the name of a "director" involved in life-cycle of the performance depicted/referred in the resource
    /// <see href="http://www.eclap.eu/schema/eclap/director"></see></summary>
    let director = _prefix "director"
    /// <summary>
    /// Indicates the name of a "dramaturge" involved in life-cycle of the performance depicted/referred in the resource
    /// <see href="http://www.eclap.eu/schema/eclap/dramaturge"></see></summary>
    let dramaturge = _prefix "dramaturge"
    /// <summary>
    /// Indicates the city where the first performance (or premiere) of the performance depicted/referred in the resource was held
    /// <see href="http://www.eclap.eu/schema/eclap/firstPerformanceCity"></see></summary>
    let firstPerformanceCity = _prefix "firstPerformanceCity"
    /// <summary>
    /// Indicates the country where the first performance (or premiere) of the performance depicted/referred in the resource was held
    /// <see href="http://www.eclap.eu/schema/eclap/firstPerformanceCountry"></see></summary>
    let firstPerformanceCountry = _prefix "firstPerformanceCountry"
    /// <summary>
    /// Indicates the date of the first performance (or premiere) of the performance depicted/referred in the resource
    /// <see href="http://www.eclap.eu/schema/eclap/firstPerformanceDate"></see></summary>
    let firstPerformanceDate = _prefix "firstPerformanceDate"
    /// <summary>
    /// Indicates the place (e.g, the theatre) where the first performance (or premiere) of the performance depicted/referred in the resource was held
    /// <see href="http://www.eclap.eu/schema/eclap/firstPerformancePlace"></see></summary>
    let firstPerformancePlace = _prefix "firstPerformancePlace"
    /// <summary>
    /// Indicates the genre of the creative work
    /// <see href="http://www.eclap.eu/schema/eclap/genre"></see></summary>
    let genre = _prefix "genre"
    /// <summary>
    /// Indicates the name of a "hairdresser" involved in life-cycle of the performance depicted/referred in the resource
    /// <see href="http://www.eclap.eu/schema/eclap/hairdresser"></see></summary>
    let hairdresser = _prefix "hairdresser"
    /// <summary>
    /// Indicates the annotation associated with a content
    /// <see href="http://www.eclap.eu/schema/eclap/hasAnnotation"></see></summary>
    let hasAnnotation = _prefix "hasAnnotation"
    /// <summary>
    /// Indicates that an User has as favorite a content
    /// <see href="http://www.eclap.eu/schema/eclap/hasFavorite"></see></summary>
    let hasFavorite = _prefix "hasFavorite"
    /// <summary>
    /// Indicates that a resource is favorite from an User
    /// <see href="http://www.eclap.eu/schema/eclap/isFavoriteOf"></see></summary>
    let isFavoriteOf = _prefix "isFavoriteOf"
    /// <summary>
    /// Indicates that an User has made featured a content
    /// <see href="http://www.eclap.eu/schema/eclap/hasFeatured"></see></summary>
    let hasFeatured = _prefix "hasFeatured"
    /// <summary>
    /// Indicates that a resource is featured by an User
    /// <see href="http://www.eclap.eu/schema/eclap/isFeaturedBy"></see></summary>
    let isFeaturedBy = _prefix "isFeaturedBy"
    /// <summary>
    /// Indicates the historical period
    /// <see href="http://www.eclap.eu/schema/eclap/historicaPeriod"></see></summary>
    let historicaPeriod = _prefix "historicaPeriod"
    /// <summary>
    /// Indicates that an User is the administrator of a group, and it is also a member of the same group.
    /// <see href="http://www.eclap.eu/schema/eclap/isAdminOf"></see></summary>
    let isAdminOf = _prefix "isAdminOf"
    /// <summary>
    /// Indicates that a User is member of a group, it is the inverse of the foaof:member property
    /// <see href="http://www.eclap.eu/schema/eclap/isMemberOf"></see></summary>
    let isMemberOf = _prefix "isMemberOf"
    /// <summary>
    /// Indicates that a resource is provided by a group
    /// <see href="http://www.eclap.eu/schema/eclap/isProvidedBy"></see></summary>
    let isProvidedBy = _prefix "isProvidedBy"
    /// <summary>
    /// Indicates that the concept is the subject of a creative work
    /// <see href="http://www.eclap.eu/schema/eclap/isSubjectOf"></see></summary>
    let isSubjectOf = _prefix "isSubjectOf"
    /// <summary>
    /// Indicates that a resource was uploaded by an User
    /// <see href="http://www.eclap.eu/schema/eclap/isUploadedBy"></see></summary>
    let isUploadedBy = _prefix "isUploadedBy"
    /// <summary>
    /// Indicates the name of a "light designer" involved in life-cycle of the performance depicted/referred in the resource
    /// <see href="http://www.eclap.eu/schema/eclap/lightDesigner"></see></summary>
    let lightDesigner = _prefix "lightDesigner"
    /// <summary>
    /// Indicates the name of a "make-up artist" involved in life-cycle of the performance depicted/referred in the resource
    /// <see href="http://www.eclap.eu/schema/eclap/makeUpArtist"></see></summary>
    let makeUpArtist = _prefix "makeUpArtist"
    /// <summary>
    /// Indicates management and organization information associated with the resource
    /// <see href="http://www.eclap.eu/schema/eclap/managementAndOrganization"></see></summary>
    let managementAndOrganization = _prefix "managementAndOrganization"
    /// <summary>
    /// Indicates the name of a "marketing manager" involved in life-cycle of the performance depicted/referred in the resource
    /// <see href="http://www.eclap.eu/schema/eclap/marketingManager"></see></summary>
    let marketingManager = _prefix "marketingManager"
    /// <summary>
    /// Indicates the name of a "mask designer" involved in life-cycle of the performance depicted/referred in the resource
    /// <see href="http://www.eclap.eu/schema/eclap/maskDesigner"></see></summary>
    let maskDesigner = _prefix "maskDesigner"
    /// <summary>
    /// Indicates the name of a "mime" involved in life-cycle of the performance depicted/referred in the resource
    /// <see href="http://www.eclap.eu/schema/eclap/mime"></see></summary>
    let mime = _prefix "mime"
    /// <summary>
    /// Indicates the name of a "musician" involved in life-cycle of the performance depicted/referred in the resource
    /// <see href="http://www.eclap.eu/schema/eclap/musician"></see></summary>
    let musician = _prefix "musician"
    /// <summary>
    /// Indicates the name of a "patron" involved in life-cycle of the performance depicted/referred in the resource
    /// <see href="http://www.eclap.eu/schema/eclap/patron"></see></summary>
    let patron = _prefix "patron"
    /// <summary>
    /// Indicates the city where the performance depicted/referred in the resource was held
    /// <see href="http://www.eclap.eu/schema/eclap/performanceCity"></see></summary>
    let performanceCity = _prefix "performanceCity"
    /// <summary>
    /// Indicates the country where the performance depicted/referred in the resource was held
    /// <see href="http://www.eclap.eu/schema/eclap/performanceCountry"></see></summary>
    let performanceCountry = _prefix "performanceCountry"
    /// <summary>
    /// Indicates the date when it was performed the performance depicted in the resource
    /// <see href="http://www.eclap.eu/schema/eclap/performanceDate"></see></summary>
    let performanceDate = _prefix "performanceDate"
    /// <summary>
    /// Indicates the place (e.g., the theatre) where the performance depicted/referred in the resource was held
    /// <see href="http://www.eclap.eu/schema/eclap/performancePlace"></see></summary>
    let performancePlace = _prefix "performancePlace"
    /// <summary>
    /// Indicates the name of a "performer" involved in life-cycle of the performance depicted/referred in the resource
    /// <see href="http://www.eclap.eu/schema/eclap/performer"></see></summary>
    let performer = _prefix "performer"
    /// <summary>
    /// Indicates the type of performing art (e.g. dance, theatre) in the resource
    /// <see href="http://www.eclap.eu/schema/eclap/performingArtType"></see></summary>
    let performingArtType = _prefix "performingArtType"
    /// <summary>
    /// Indicates the group that was involved in the performance creation
    /// <see href="http://www.eclap.eu/schema/eclap/performingArtsGroup"></see></summary>
    let performingArtsGroup = _prefix "performingArtsGroup"
    /// <summary>
    /// Indicates the name of a "playwright" involved in life-cycle of the performance depicted/referred in the resource
    /// <see href="http://www.eclap.eu/schema/eclap/playwright"></see></summary>
    let playwright = _prefix "playwright"
    /// <summary>
    /// Indicates the summary of the plot of the performance depicted/referred in the resource
    /// <see href="http://www.eclap.eu/schema/eclap/plotSummary"></see></summary>
    let plotSummary = _prefix "plotSummary"
    /// <summary>
    /// Indicates the name of a "producer" involved in life-cycle of the performance depicted/referred in the resource
    /// <see href="http://www.eclap.eu/schema/eclap/producer"></see></summary>
    let producer = _prefix "producer"
    /// <summary>
    /// Indicates the resources provided by a Group
    /// <see href="http://www.eclap.eu/schema/eclap/provide"></see></summary>
    let provide = _prefix "provide"
    /// <summary>
    /// Indicates the name of a "puppet designer" involved in life-cycle of the performance depicted/referred in the resource
    /// <see href="http://www.eclap.eu/schema/eclap/puppetDesigner"></see></summary>
    let puppetDesigner = _prefix "puppetDesigner"
    /// <summary>
    /// Indicates the date of recording of the original audio visual resource
    /// <see href="http://www.eclap.eu/schema/eclap/recordingDate"></see></summary>
    let recordingDate = _prefix "recordingDate"
    /// <summary>
    /// Indicates the name of a "scenographer" involved in life-cycle of the performance depicted/referred in the resource
    /// <see href="http://www.eclap.eu/schema/eclap/scenographer"></see></summary>
    let scenographer = _prefix "scenographer"
    /// <summary>
    /// Indicates the name of a "seamster" involved in life-cycle of the performance depicted/referred in the resource
    /// <see href="http://www.eclap.eu/schema/eclap/seamster"></see></summary>
    let seamster = _prefix "seamster"
    /// <summary>
    /// Indicates the name of a "set builder" involved in life-cycle of the performance depicted/referred in the resource
    /// <see href="http://www.eclap.eu/schema/eclap/setBuilder"></see></summary>
    let setBuilder = _prefix "setBuilder"
    /// <summary>
    /// Indicates the name of a "set designer" involved in life-cycle of the performance depicted/referred in the resource
    /// <see href="http://www.eclap.eu/schema/eclap/setDesigner"></see></summary>
    let setDesigner = _prefix "setDesigner"
    /// <summary>
    /// Indicates the name of a "singer" involved in life-cycle of the performance depicted/referred in the resource
    /// <see href="http://www.eclap.eu/schema/eclap/singer"></see></summary>
    let singer = _prefix "singer"
    /// <summary>
    /// Indicates the name of a "sound designer" involved in life-cycle of the performance depicted/referred in the resource
    /// <see href="http://www.eclap.eu/schema/eclap/soundDesigner"></see></summary>
    let soundDesigner = _prefix "soundDesigner"
    /// <summary>
    /// Indicates the name of a "stage manager" involved in life-cycle of the performance depicted/referred in the resource
    /// <see href="http://www.eclap.eu/schema/eclap/stageManager"></see></summary>
    let stageManager = _prefix "stageManager"
    /// <summary>
    /// Indicates the name of a "technician" involved in life-cycle of the performance depicted/referred in the resource
    /// <see href="http://www.eclap.eu/schema/eclap/technician"></see></summary>
    let technician = _prefix "technician"
    /// <summary>
    /// Indicates the name of a "theatre manager" involved in life-cycle of the performance depicted/referred in the resource
    /// <see href="http://www.eclap.eu/schema/eclap/theatreManager"></see></summary>
    let theatreManager = _prefix "theatreManager"
    /// <summary>
    /// Indicates the name of a "theoretician" involved in life-cycle of the performance depicted/referred in the resource
    /// <see href="http://www.eclap.eu/schema/eclap/theoretician"></see></summary>
    let theoretician = _prefix "theoretician"
    /// <summary>
    /// Indicates the name of a "translator" involved in life-cycle of the performance depicted/referred in the resource
    /// <see href="http://www.eclap.eu/schema/eclap/translator"></see></summary>
    let translator = _prefix "translator"
    /// <summary>
    /// Indicates the media objects uploaded by the user
    /// <see href="http://www.eclap.eu/schema/eclap/uploaded"></see></summary>
    let uploaded = _prefix "uploaded"
