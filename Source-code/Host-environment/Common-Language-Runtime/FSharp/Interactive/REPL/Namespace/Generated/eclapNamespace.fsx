#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module eclap =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://www.eclap.eu/schema/eclap/" "eclap"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:comment : A 3D content</para>
    ///   <para>rdfs:label : 3D</para>
    ///   <a href="http://www.eclap.eu/schema/eclap/3D">eclap:3D</a>
    /// </summary>
    let _3D = _prefixId.prefix "3D"
    /// <summary>
    ///   <para>rdfs:comment : An audio visual content</para>
    ///   <para>rdfs:label : AVObject</para>
    ///   <a href="http://www.eclap.eu/schema/eclap/AVObject">eclap:AVObject</a>
    /// </summary>
    let AVObject = _prefixId.prefix "AVObject"
    /// <summary>
    ///   <para>rdfs:comment : An archival content as ZIP, RAR, TAR, etc.</para>
    ///   <para>rdfs:label : Archive</para>
    ///   <a href="http://www.eclap.eu/schema/eclap/Archive">eclap:Archive</a>
    /// </summary>
    let Archive = _prefixId.prefix "Archive"
    /// <summary>
    ///   <para>rdfs:comment : An audio content</para>
    ///   <para>rdfs:label : Audio</para>
    ///   <a href="http://www.eclap.eu/schema/eclap/Audio">eclap:Audio</a>
    /// </summary>
    let Audio = _prefixId.prefix "Audio"
    /// <summary>
    ///   <para>rdfs:comment : A music score written in braille</para>
    ///   <para>rdfs:label : Braille music score</para>
    ///   <a href="http://www.eclap.eu/schema/eclap/BrailleMusicScore">eclap:BrailleMusicScore</a>
    /// </summary>
    let BrailleMusicScore = _prefixId.prefix "BrailleMusicScore"
    /// <summary>
    ///   <para>rdfs:comment : A collection of other content</para>
    ///   <para>rdfs:label : Collection</para>
    ///   <a href="http://www.eclap.eu/schema/eclap/Collection">eclap:Collection</a>
    /// </summary>
    let Collection = _prefixId.prefix "Collection"
    /// <summary>
    ///   <para>rdfs:comment : A cross media content</para>
    ///   <para>rdfs:label : Crossmedia</para>
    ///   <a href="http://www.eclap.eu/schema/eclap/Crossmedia">eclap:Crossmedia</a>
    /// </summary>
    let Crossmedia = _prefixId.prefix "Crossmedia"
    /// <summary>
    ///   <para>rdfs:comment : A textual document</para>
    ///   <para>rdfs:label : Document</para>
    ///   <a href="http://www.eclap.eu/schema/eclap/Document">eclap:Document</a>
    /// </summary>
    let Document = _prefixId.prefix "Document"
    /// <summary>
    ///   <para>rdfs:comment : An e-pub based content</para>
    ///   <para>rdfs:label : E-pub</para>
    ///   <a href="http://www.eclap.eu/schema/eclap/EPub">eclap:EPub</a>
    /// </summary>
    let EPub = _prefixId.prefix "EPub"
    /// <summary>
    ///   <para>rdfs:comment : A spreadsheet based content</para>
    ///   <para>rdfs:label : Excel</para>
    ///   <a href="http://www.eclap.eu/schema/eclap/Excel">eclap:Excel</a>
    /// </summary>
    let Excel = _prefixId.prefix "Excel"
    /// <summary>
    ///   <para>rdfs:comment : An explosive annotation</para>
    ///   <para>rdfs:label : Explosive Annotation</para>
    ///   <a href="http://www.eclap.eu/schema/eclap/Explosive">eclap:Explosive</a>
    /// </summary>
    let Explosive = _prefixId.prefix "Explosive"
    /// <summary>
    ///   <para>rdfs:comment : An image based content</para>
    ///   <para>rdfs:label : Image</para>
    ///   <a href="http://www.eclap.eu/schema/eclap/Image">eclap:Image</a>
    /// </summary>
    let Image = _prefixId.prefix "Image"
    /// <summary>
    ///   <para>rdfs:comment : A multimedia content</para>
    ///   <para>rdfs:label : MediaObject</para>
    ///   <a href="http://www.eclap.eu/schema/eclap/MediaObject">eclap:MediaObject</a>
    /// </summary>
    let MediaObject = _prefixId.prefix "MediaObject"
    /// <summary>
    ///   <para>rdfs:comment : An One2One annotation</para>
    ///   <para>rdfs:label : One2One Annotation</para>
    ///   <a href="http://www.eclap.eu/schema/eclap/One2One">eclap:One2One</a>
    /// </summary>
    let One2One = _prefixId.prefix "One2One"
    /// <summary>
    ///   <para>rdfs:comment : A playlist of audio visual content</para>
    ///   <para>rdfs:label : Playlist</para>
    ///   <a href="http://www.eclap.eu/schema/eclap/Playlist">eclap:Playlist</a>
    /// </summary>
    let Playlist = _prefixId.prefix "Playlist"
    /// <summary>
    ///   <para>rdfs:comment : A Slide based content (e.g. PPT)</para>
    ///   <para>rdfs:label : Slide</para>
    ///   <a href="http://www.eclap.eu/schema/eclap/Slide">eclap:Slide</a>
    /// </summary>
    let Slide = _prefixId.prefix "Slide"
    /// <summary>
    ///   <para>rdfs:comment : A tool content (e.g. an executable file)</para>
    ///   <para>rdfs:label : Tool</para>
    ///   <a href="http://www.eclap.eu/schema/eclap/Tool">eclap:Tool</a>
    /// </summary>
    let Tool = _prefixId.prefix "Tool"
    /// <summary>
    ///   <para>rdfs:comment : An User registered on ECLAP portal</para>
    ///   <para>rdfs:label : User</para>
    ///   <a href="http://www.eclap.eu/schema/eclap/User">eclap:User</a>
    /// </summary>
    let User = _prefixId.prefix "User"
    /// <summary>
    ///   <para>rdfs:comment : A Video content</para>
    ///   <para>rdfs:label : Video</para>
    ///   <a href="http://www.eclap.eu/schema/eclap/Video">eclap:Video</a>
    /// </summary>
    let Video = _prefixId.prefix "Video"
    /// <summary>
    ///   <para>rdfs:comment : Indicates the name of an "acrobat" involved in life-cycle of the performance depicted/referred in the resource</para>
    ///   <para>rdfs:label : acrobat</para>
    ///   <a href="http://www.eclap.eu/schema/eclap/acrobat">eclap:acrobat</a>
    /// </summary>
    let acrobat = _prefixId.prefix "acrobat"
    /// <summary>
    ///   <para>rdfs:comment : Indicates the name of an "actor" involved in life-cycle of the performance depicted/referred in the resource</para>
    ///   <para>rdfs:label : actor</para>
    ///   <a href="http://www.eclap.eu/schema/eclap/actor">eclap:actor</a>
    /// </summary>
    let actor = _prefixId.prefix "actor"
    /// <summary>
    ///   <para>rdfs:comment : Indicates the name of an "adaptor" involved in life-cycle of the performance depicted/referred in the resource</para>
    ///   <para>rdfs:label : adaptor</para>
    ///   <a href="http://www.eclap.eu/schema/eclap/adaptator">eclap:adaptator</a>
    /// </summary>
    let adaptator = _prefixId.prefix "adaptator"
    /// <summary>
    ///   <para>rdfs:comment : Indicates the User that is the administrator of a group</para>
    ///   <para>rdfs:label : admin</para>
    ///   <a href="http://www.eclap.eu/schema/eclap/admin">eclap:admin</a>
    /// </summary>
    let admin = _prefixId.prefix "admin"
    /// <summary>
    ///   <para>rdfs:comment : Indicates the name of an "architect" involved in life-cycle of the performance depicted/referred in the resource</para>
    ///   <para>rdfs:label : architect</para>
    ///   <a href="http://www.eclap.eu/schema/eclap/architect">eclap:architect</a>
    /// </summary>
    let architect = _prefixId.prefix "architect"

    /// <summary>
    ///   <para>rdfs:comment : Indicates the artistic momement and acting style used for the performance depicted/referred in the resource</para>
    ///   <para>rdfs:label : artistic movement and acting style</para>
    ///   <a href="http://www.eclap.eu/schema/eclap/artisticMovementAndActingStyle">eclap:artisticMovementAndActingStyle</a>
    /// </summary>
    let artisticMovementAndActingStyle =
        _prefixId.prefix "artisticMovementAndActingStyle"

    /// <summary>
    ///   <para>rdfs:comment : Indicates the name of an "assistant director" involved in life-cycle of the performance depicted/referred in the resource</para>
    ///   <para>rdfs:label : assistant director</para>
    ///   <a href="http://www.eclap.eu/schema/eclap/assistantDirector">eclap:assistantDirector</a>
    /// </summary>
    let assistantDirector = _prefixId.prefix "assistantDirector"
    /// <summary>
    ///   <para>rdfs:comment : Indicates name or names in the cast</para>
    ///   <para>rdfs:label : cast</para>
    ///   <a href="http://www.eclap.eu/schema/eclap/cast">eclap:cast</a>
    /// </summary>
    let cast = _prefixId.prefix "cast"
    /// <summary>
    ///   <para>rdfs:comment : Indicates the name of a "casting" involved in life-cycle of the performance depicted/referred in the resource</para>
    ///   <para>rdfs:label : casting</para>
    ///   <a href="http://www.eclap.eu/schema/eclap/casting">eclap:casting</a>
    /// </summary>
    let casting = _prefixId.prefix "casting"
    /// <summary>
    ///   <para>rdfs:comment : Indicates the name of an "choreographer" involved in life-cycle of the performance depicted/referred in the resource</para>
    ///   <para>rdfs:label : choreographer</para>
    ///   <a href="http://www.eclap.eu/schema/eclap/choreographer">eclap:choreographer</a>
    /// </summary>
    let choreographer = _prefixId.prefix "choreographer"
    /// <summary>
    ///   <para>rdfs:comment : Indicates the name of a "clown" involved in life-cycle of the performance depicted/referred in the resource</para>
    ///   <para>rdfs:label : clown</para>
    ///   <a href="http://www.eclap.eu/schema/eclap/clown">eclap:clown</a>
    /// </summary>
    let clown = _prefixId.prefix "clown"
    /// <summary>
    ///   <para>rdfs:comment : Indicates the name of a "composer" involved in life-cycle of the performance depicted/referred in the resource</para>
    ///   <para>rdfs:label : composer</para>
    ///   <a href="http://www.eclap.eu/schema/eclap/composer">eclap:composer</a>
    /// </summary>
    let composer = _prefixId.prefix "composer"
    /// <summary>
    ///   <para>rdfs:comment : Indicates the name of a "concept originator" involved in life-cycle of the performance depicted/referred in the resource</para>
    ///   <para>rdfs:label : concept originator</para>
    ///   <a href="http://www.eclap.eu/schema/eclap/conceptOriginator">eclap:conceptOriginator</a>
    /// </summary>
    let conceptOriginator = _prefixId.prefix "conceptOriginator"
    /// <summary>
    ///   <para>rdfs:comment : Indicates the name of a "costume designer" involved in life-cycle of the performance depicted/referred in the resource</para>
    ///   <para>rdfs:label : costume designer</para>
    ///   <a href="http://www.eclap.eu/schema/eclap/costumeDesigner">eclap:costumeDesigner</a>
    /// </summary>
    let costumeDesigner = _prefixId.prefix "costumeDesigner"
    /// <summary>
    ///   <para>rdfs:comment : Indicates an annotation created by an User</para>
    ///   <para>rdfs:label : created annotation</para>
    ///   <a href="http://www.eclap.eu/schema/eclap/createdAnnotation">eclap:createdAnnotation</a>
    /// </summary>
    let createdAnnotation = _prefixId.prefix "createdAnnotation"
    /// <summary>
    ///   <para>rdfs:comment : Indicates the name of a "critic" involved in life-cycle of the performance depicted/referred in the resource</para>
    ///   <para>rdfs:label : critic</para>
    ///   <a href="http://www.eclap.eu/schema/eclap/critic">eclap:critic</a>
    /// </summary>
    let critic = _prefixId.prefix "critic"
    /// <summary>
    ///   <para>rdfs:comment : Indicates the name of a "dancer" involved in life-cycle of the performance depicted/referred in the resource</para>
    ///   <para>rdfs:label : dancer</para>
    ///   <a href="http://www.eclap.eu/schema/eclap/dancer">eclap:dancer</a>
    /// </summary>
    let dancer = _prefixId.prefix "dancer"
    /// <summary>
    ///   <para>rdfs:comment : Indicates the name of a "director" involved in life-cycle of the performance depicted/referred in the resource</para>
    ///   <para>rdfs:label : director</para>
    ///   <a href="http://www.eclap.eu/schema/eclap/director">eclap:director</a>
    /// </summary>
    let director = _prefixId.prefix "director"
    /// <summary>
    ///   <para>rdfs:comment : Indicates the name of a "dramaturge" involved in life-cycle of the performance depicted/referred in the resource</para>
    ///   <para>rdfs:label : dramaturge</para>
    ///   <a href="http://www.eclap.eu/schema/eclap/dramaturge">eclap:dramaturge</a>
    /// </summary>
    let dramaturge = _prefixId.prefix "dramaturge"
    /// <summary>
    ///   <para>rdfs:comment : Indicates the city where the first performance (or premiere) of the performance depicted/referred in the resource was held</para>
    ///   <para>rdfs:label : first performance city</para>
    ///   <a href="http://www.eclap.eu/schema/eclap/firstPerformanceCity">eclap:firstPerformanceCity</a>
    /// </summary>
    let firstPerformanceCity = _prefixId.prefix "firstPerformanceCity"
    /// <summary>
    ///   <para>rdfs:comment : Indicates the country where the first performance (or premiere) of the performance depicted/referred in the resource was held</para>
    ///   <para>rdfs:label : first performance country</para>
    ///   <a href="http://www.eclap.eu/schema/eclap/firstPerformanceCountry">eclap:firstPerformanceCountry</a>
    /// </summary>
    let firstPerformanceCountry = _prefixId.prefix "firstPerformanceCountry"
    /// <summary>
    ///   <para>rdfs:comment : Indicates the date of the first performance (or premiere) of the performance depicted/referred in the resource</para>
    ///   <para>rdfs:label : first performance date</para>
    ///   <a href="http://www.eclap.eu/schema/eclap/firstPerformanceDate">eclap:firstPerformanceDate</a>
    /// </summary>
    let firstPerformanceDate = _prefixId.prefix "firstPerformanceDate"
    /// <summary>
    ///   <para>rdfs:comment : Indicates the place (e.g, the theatre) where the first performance (or premiere) of the performance depicted/referred in the resource was held</para>
    ///   <para>rdfs:label : first performance place</para>
    ///   <a href="http://www.eclap.eu/schema/eclap/firstPerformancePlace">eclap:firstPerformancePlace</a>
    /// </summary>
    let firstPerformancePlace = _prefixId.prefix "firstPerformancePlace"
    /// <summary>
    ///   <para>rdfs:comment : Indicates the genre of the creative work</para>
    ///   <para>rdfs:label : genre</para>
    ///   <a href="http://www.eclap.eu/schema/eclap/genre">eclap:genre</a>
    /// </summary>
    let genre = _prefixId.prefix "genre"
    /// <summary>
    ///   <para>rdfs:comment : Indicates the name of a "hairdresser" involved in life-cycle of the performance depicted/referred in the resource</para>
    ///   <para>rdfs:label : hairdresser</para>
    ///   <a href="http://www.eclap.eu/schema/eclap/hairdresser">eclap:hairdresser</a>
    /// </summary>
    let hairdresser = _prefixId.prefix "hairdresser"
    /// <summary>
    ///   <para>rdfs:comment : Indicates the annotation associated with a content</para>
    ///   <para>rdfs:label : has annotation</para>
    ///   <a href="http://www.eclap.eu/schema/eclap/hasAnnotation">eclap:hasAnnotation</a>
    /// </summary>
    let hasAnnotation = _prefixId.prefix "hasAnnotation"
    /// <summary>
    ///   <para>rdfs:comment : Indicates that an User has as favorite a content</para>
    ///   <para>rdfs:label : has favourite</para>
    ///   <a href="http://www.eclap.eu/schema/eclap/hasFavorite">eclap:hasFavorite</a>
    /// </summary>
    let hasFavorite = _prefixId.prefix "hasFavorite"
    /// <summary>
    ///   <para>rdfs:comment : Indicates that an User has made featured a content</para>
    ///   <para>rdfs:label : has featured</para>
    ///   <a href="http://www.eclap.eu/schema/eclap/hasFeatured">eclap:hasFeatured</a>
    /// </summary>
    let hasFeatured = _prefixId.prefix "hasFeatured"
    /// <summary>
    ///   <para>rdfs:comment : Indicates the historical period</para>
    ///   <para>rdfs:label : historical period</para>
    ///   <a href="http://www.eclap.eu/schema/eclap/historicaPeriod">eclap:historicaPeriod</a>
    /// </summary>
    let historicaPeriod = _prefixId.prefix "historicaPeriod"
    /// <summary>
    ///   <para>rdfs:comment : Indicates that an User is the administrator of a group, and it is also a member of the same group.</para>
    ///   <para>rdfs:label : isAdminOf</para>
    ///   <a href="http://www.eclap.eu/schema/eclap/isAdminOf">eclap:isAdminOf</a>
    /// </summary>
    let isAdminOf = _prefixId.prefix "isAdminOf"
    /// <summary>
    ///   <para>rdfs:comment : Indicates that a resource is favorite from an User</para>
    ///   <para>rdfs:label : is favorite of</para>
    ///   <a href="http://www.eclap.eu/schema/eclap/isFavoriteOf">eclap:isFavoriteOf</a>
    /// </summary>
    let isFavoriteOf = _prefixId.prefix "isFavoriteOf"
    /// <summary>
    ///   <para>rdfs:comment : Indicates that a resource is featured by an User</para>
    ///   <para>rdfs:label : is featured by</para>
    ///   <a href="http://www.eclap.eu/schema/eclap/isFeaturedBy">eclap:isFeaturedBy</a>
    /// </summary>
    let isFeaturedBy = _prefixId.prefix "isFeaturedBy"
    /// <summary>
    ///   <para>rdfs:comment : Indicates that a User is member of a group, it is the inverse of the foaof:member property</para>
    ///   <para>rdfs:label : isMemberOf</para>
    ///   <a href="http://www.eclap.eu/schema/eclap/isMemberOf">eclap:isMemberOf</a>
    /// </summary>
    let isMemberOf = _prefixId.prefix "isMemberOf"
    /// <summary>
    ///   <para>rdfs:comment : Indicates that a resource is provided by a group</para>
    ///   <para>rdfs:label : is provided by</para>
    ///   <a href="http://www.eclap.eu/schema/eclap/isProvidedBy">eclap:isProvidedBy</a>
    /// </summary>
    let isProvidedBy = _prefixId.prefix "isProvidedBy"
    /// <summary>
    ///   <para>rdfs:comment : Indicates that the concept is the subject of a creative work</para>
    ///   <para>rdfs:label : isSubjectOf</para>
    ///   <a href="http://www.eclap.eu/schema/eclap/isSubjectOf">eclap:isSubjectOf</a>
    /// </summary>
    let isSubjectOf = _prefixId.prefix "isSubjectOf"
    /// <summary>
    ///   <para>rdfs:comment : Indicates that a resource was uploaded by an User</para>
    ///   <para>rdfs:label : is uploaded by</para>
    ///   <a href="http://www.eclap.eu/schema/eclap/isUploadedBy">eclap:isUploadedBy</a>
    /// </summary>
    let isUploadedBy = _prefixId.prefix "isUploadedBy"
    /// <summary>
    ///   <para>rdfs:comment : Indicates the name of a "light designer" involved in life-cycle of the performance depicted/referred in the resource</para>
    ///   <para>rdfs:label : light designer</para>
    ///   <a href="http://www.eclap.eu/schema/eclap/lightDesigner">eclap:lightDesigner</a>
    /// </summary>
    let lightDesigner = _prefixId.prefix "lightDesigner"
    /// <summary>
    ///   <para>rdfs:comment : Indicates the name of a "make-up artist" involved in life-cycle of the performance depicted/referred in the resource</para>
    ///   <para>rdfs:label : make-up artist</para>
    ///   <a href="http://www.eclap.eu/schema/eclap/makeUpArtist">eclap:makeUpArtist</a>
    /// </summary>
    let makeUpArtist = _prefixId.prefix "makeUpArtist"
    /// <summary>
    ///   <para>rdfs:comment : Indicates management and organization information associated with the resource</para>
    ///   <para>rdfs:label : management and organization</para>
    ///   <a href="http://www.eclap.eu/schema/eclap/managementAndOrganization">eclap:managementAndOrganization</a>
    /// </summary>
    let managementAndOrganization = _prefixId.prefix "managementAndOrganization"
    /// <summary>
    ///   <para>rdfs:comment : Indicates the name of a "marketing manager" involved in life-cycle of the performance depicted/referred in the resource</para>
    ///   <para>rdfs:label : marketing manager</para>
    ///   <a href="http://www.eclap.eu/schema/eclap/marketingManager">eclap:marketingManager</a>
    /// </summary>
    let marketingManager = _prefixId.prefix "marketingManager"
    /// <summary>
    ///   <para>rdfs:comment : Indicates the name of a "mask designer" involved in life-cycle of the performance depicted/referred in the resource</para>
    ///   <para>rdfs:label : mask designer</para>
    ///   <a href="http://www.eclap.eu/schema/eclap/maskDesigner">eclap:maskDesigner</a>
    /// </summary>
    let maskDesigner = _prefixId.prefix "maskDesigner"
    /// <summary>
    ///   <para>rdfs:comment : Indicates the name of a "mime" involved in life-cycle of the performance depicted/referred in the resource</para>
    ///   <para>rdfs:label : mime</para>
    ///   <a href="http://www.eclap.eu/schema/eclap/mime">eclap:mime</a>
    /// </summary>
    let mime = _prefixId.prefix "mime"
    /// <summary>
    ///   <para>rdfs:comment : Indicates the name of a "musician" involved in life-cycle of the performance depicted/referred in the resource</para>
    ///   <para>rdfs:label : musician</para>
    ///   <a href="http://www.eclap.eu/schema/eclap/musician">eclap:musician</a>
    /// </summary>
    let musician = _prefixId.prefix "musician"
    /// <summary>
    ///   <para>rdfs:comment : Indicates the name of a "patron" involved in life-cycle of the performance depicted/referred in the resource</para>
    ///   <para>rdfs:label : patron</para>
    ///   <a href="http://www.eclap.eu/schema/eclap/patron">eclap:patron</a>
    /// </summary>
    let patron = _prefixId.prefix "patron"
    /// <summary>
    ///   <para>rdfs:comment : Indicates the city where the performance depicted/referred in the resource was held</para>
    ///   <para>rdfs:label : performance city</para>
    ///   <a href="http://www.eclap.eu/schema/eclap/performanceCity">eclap:performanceCity</a>
    /// </summary>
    let performanceCity = _prefixId.prefix "performanceCity"
    /// <summary>
    ///   <para>rdfs:comment : Indicates the country where the performance depicted/referred in the resource was held</para>
    ///   <para>rdfs:label : performance country</para>
    ///   <a href="http://www.eclap.eu/schema/eclap/performanceCountry">eclap:performanceCountry</a>
    /// </summary>
    let performanceCountry = _prefixId.prefix "performanceCountry"
    /// <summary>
    ///   <para>rdfs:comment : Indicates the date when it was performed the performance depicted in the resource</para>
    ///   <para>rdfs:label : performance date</para>
    ///   <a href="http://www.eclap.eu/schema/eclap/performanceDate">eclap:performanceDate</a>
    /// </summary>
    let performanceDate = _prefixId.prefix "performanceDate"
    /// <summary>
    ///   <para>rdfs:comment : Indicates the place (e.g., the theatre) where the performance depicted/referred in the resource was held</para>
    ///   <para>rdfs:label : performance place</para>
    ///   <a href="http://www.eclap.eu/schema/eclap/performancePlace">eclap:performancePlace</a>
    /// </summary>
    let performancePlace = _prefixId.prefix "performancePlace"
    /// <summary>
    ///   <para>rdfs:comment : Indicates the name of a "performer" involved in life-cycle of the performance depicted/referred in the resource</para>
    ///   <para>rdfs:label : performer</para>
    ///   <a href="http://www.eclap.eu/schema/eclap/performer">eclap:performer</a>
    /// </summary>
    let performer = _prefixId.prefix "performer"
    /// <summary>
    ///   <para>rdfs:comment : Indicates the name or names of performers and crew involved in the creation of the performance depicted/referred in the resource</para>
    ///   <para>rdfs:label : performers and crew</para>
    ///   <a href="http://www.eclap.eu/schema/eclap/performersAndCrew">eclap:performersAndCrew</a>
    /// </summary>
    let performersAndCrew = _prefixId.prefix "performersAndCrew"
    /// <summary>
    ///   <para>rdfs:comment : Indicates the type of performing art (e.g. dance, theatre) in the resource</para>
    ///   <para>rdfs:label : performing art type</para>
    ///   <a href="http://www.eclap.eu/schema/eclap/performingArtType">eclap:performingArtType</a>
    /// </summary>
    let performingArtType = _prefixId.prefix "performingArtType"
    /// <summary>
    ///   <para>rdfs:comment : Indicates the group that was involved in the performance creation</para>
    ///   <para>rdfs:label : performing arts group</para>
    ///   <a href="http://www.eclap.eu/schema/eclap/performingArtsGroup">eclap:performingArtsGroup</a>
    /// </summary>
    let performingArtsGroup = _prefixId.prefix "performingArtsGroup"
    /// <summary>
    ///   <para>rdfs:comment : Indicates a name of a performing arts professional involved in the creation of the creative work</para>
    ///   <para>rdfs:label : performing arts professional</para>
    ///   <a href="http://www.eclap.eu/schema/eclap/performingArtsProfessional">eclap:performingArtsProfessional</a>
    /// </summary>
    let performingArtsProfessional = _prefixId.prefix "performingArtsProfessional"
    /// <summary>
    ///   <para>rdfs:comment : Indicates the name of a "playwright" involved in life-cycle of the performance depicted/referred in the resource</para>
    ///   <para>rdfs:label : playwright</para>
    ///   <a href="http://www.eclap.eu/schema/eclap/playwright">eclap:playwright</a>
    /// </summary>
    let playwright = _prefixId.prefix "playwright"
    /// <summary>
    ///   <para>rdfs:comment : Indicates the summary of the plot of the performance depicted/referred in the resource</para>
    ///   <para>rdfs:label : plot summary</para>
    ///   <a href="http://www.eclap.eu/schema/eclap/plotSummary">eclap:plotSummary</a>
    /// </summary>
    let plotSummary = _prefixId.prefix "plotSummary"
    /// <summary>
    ///   <para>rdfs:comment : Indicates the name of a "producer" involved in life-cycle of the performance depicted/referred in the resource</para>
    ///   <para>rdfs:label : producer</para>
    ///   <a href="http://www.eclap.eu/schema/eclap/producer">eclap:producer</a>
    /// </summary>
    let producer = _prefixId.prefix "producer"
    /// <summary>
    ///   <para>rdfs:comment : Indicates the resources provided by a Group</para>
    ///   <para>rdfs:label : provide</para>
    ///   <a href="http://www.eclap.eu/schema/eclap/provide">eclap:provide</a>
    /// </summary>
    let provide = _prefixId.prefix "provide"
    /// <summary>
    ///   <para>rdfs:comment : Indicates the name of a "puppet designer" involved in life-cycle of the performance depicted/referred in the resource</para>
    ///   <para>rdfs:label : puppet designer</para>
    ///   <a href="http://www.eclap.eu/schema/eclap/puppetDesigner">eclap:puppetDesigner</a>
    /// </summary>
    let puppetDesigner = _prefixId.prefix "puppetDesigner"
    /// <summary>
    ///   <para>rdfs:comment : Indicates the date of recording of the original audio visual resource</para>
    ///   <para>rdfs:label : recording date</para>
    ///   <a href="http://www.eclap.eu/schema/eclap/recordingDate">eclap:recordingDate</a>
    /// </summary>
    let recordingDate = _prefixId.prefix "recordingDate"
    /// <summary>
    ///   <para>rdfs:comment : Indicates the name of a "scenographer" involved in life-cycle of the performance depicted/referred in the resource</para>
    ///   <para>rdfs:label : scenographer</para>
    ///   <a href="http://www.eclap.eu/schema/eclap/scenographer">eclap:scenographer</a>
    /// </summary>
    let scenographer = _prefixId.prefix "scenographer"
    /// <summary>
    ///   <para>rdfs:comment : Indicates the name of a "seamster" involved in life-cycle of the performance depicted/referred in the resource</para>
    ///   <para>rdfs:label : seamster</para>
    ///   <a href="http://www.eclap.eu/schema/eclap/seamster">eclap:seamster</a>
    /// </summary>
    let seamster = _prefixId.prefix "seamster"
    /// <summary>
    ///   <para>rdfs:comment : Indicates the name of a "set builder" involved in life-cycle of the performance depicted/referred in the resource</para>
    ///   <para>rdfs:label : set builder</para>
    ///   <a href="http://www.eclap.eu/schema/eclap/setBuilder">eclap:setBuilder</a>
    /// </summary>
    let setBuilder = _prefixId.prefix "setBuilder"
    /// <summary>
    ///   <para>rdfs:comment : Indicates the name of a "set designer" involved in life-cycle of the performance depicted/referred in the resource</para>
    ///   <para>rdfs:label : set designer</para>
    ///   <a href="http://www.eclap.eu/schema/eclap/setDesigner">eclap:setDesigner</a>
    /// </summary>
    let setDesigner = _prefixId.prefix "setDesigner"
    /// <summary>
    ///   <para>rdfs:comment : Indicates the name of a "singer" involved in life-cycle of the performance depicted/referred in the resource</para>
    ///   <para>rdfs:label : singer</para>
    ///   <a href="http://www.eclap.eu/schema/eclap/singer">eclap:singer</a>
    /// </summary>
    let singer = _prefixId.prefix "singer"
    /// <summary>
    ///   <para>rdfs:comment : Indicates the name of a "sound designer" involved in life-cycle of the performance depicted/referred in the resource</para>
    ///   <para>rdfs:label : sound designer</para>
    ///   <a href="http://www.eclap.eu/schema/eclap/soundDesigner">eclap:soundDesigner</a>
    /// </summary>
    let soundDesigner = _prefixId.prefix "soundDesigner"
    /// <summary>
    ///   <para>rdfs:comment : Indicates the name of a "stage manager" involved in life-cycle of the performance depicted/referred in the resource</para>
    ///   <para>rdfs:label : stage manager</para>
    ///   <a href="http://www.eclap.eu/schema/eclap/stageManager">eclap:stageManager</a>
    /// </summary>
    let stageManager = _prefixId.prefix "stageManager"
    /// <summary>
    ///   <para>rdfs:comment : Indicates the name of a "technician" involved in life-cycle of the performance depicted/referred in the resource</para>
    ///   <para>rdfs:label : technician</para>
    ///   <a href="http://www.eclap.eu/schema/eclap/technician">eclap:technician</a>
    /// </summary>
    let technician = _prefixId.prefix "technician"
    /// <summary>
    ///   <para>rdfs:comment : Indicates the name of a "theatre manager" involved in life-cycle of the performance depicted/referred in the resource</para>
    ///   <para>rdfs:label : theatre manager</para>
    ///   <a href="http://www.eclap.eu/schema/eclap/theatreManager">eclap:theatreManager</a>
    /// </summary>
    let theatreManager = _prefixId.prefix "theatreManager"
    /// <summary>
    ///   <para>rdfs:comment : Indicates the name of a "theoretician" involved in life-cycle of the performance depicted/referred in the resource</para>
    ///   <para>rdfs:label : theoretician</para>
    ///   <a href="http://www.eclap.eu/schema/eclap/theoretician">eclap:theoretician</a>
    /// </summary>
    let theoretician = _prefixId.prefix "theoretician"
    /// <summary>
    ///   <para>rdfs:comment : Indicates the name of a "translator" involved in life-cycle of the performance depicted/referred in the resource</para>
    ///   <para>rdfs:label : translator</para>
    ///   <a href="http://www.eclap.eu/schema/eclap/translator">eclap:translator</a>
    /// </summary>
    let translator = _prefixId.prefix "translator"
    /// <summary>
    ///   <para>rdfs:comment : Indicates the media objects uploaded by the user</para>
    ///   <para>rdfs:label : uploaded</para>
    ///   <a href="http://www.eclap.eu/schema/eclap/uploaded">eclap:uploaded</a>
    /// </summary>
    let uploaded = _prefixId.prefix "uploaded"
