namespace http.www.eclap.eu.schema.eclap.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module eclap =
    let _namespace_iri = Namespace_Iri eclap |> NamespaceIRI
    /// <summary>
    ///   <para>eclap:MediaObject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A multimedia content</para>
    /// labels<para>MediaObject</para></remarks>
    /// <seealso href="http://www.eclap.eu/schema/eclap/MediaObject">http://www.eclap.eu/schema/eclap/MediaObject</seealso>
    let MediaObject = Prefixed_Name(eclap, "MediaObject") |> PrefixedName
    /// <summary>
    ///   <para>eclap:BrailleMusicScore</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A music score written in braille</para>
    /// labels<para>Braille music score</para></remarks>
    /// <seealso href="http://www.eclap.eu/schema/eclap/BrailleMusicScore">http://www.eclap.eu/schema/eclap/BrailleMusicScore</seealso>
    let BrailleMusicScore = Prefixed_Name(eclap, "BrailleMusicScore") |> PrefixedName
    /// <summary>
    ///   <para>eclap:EPub</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An e-pub based content</para>
    /// labels<para>E-pub</para></remarks>
    /// <seealso href="http://www.eclap.eu/schema/eclap/EPub">http://www.eclap.eu/schema/eclap/EPub</seealso>
    let EPub = Prefixed_Name(eclap, "EPub") |> PrefixedName
    /// <summary>
    ///   <para>eclap:3D</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A 3D content</para>
    /// labels<para>3D</para></remarks>
    /// <seealso href="http://www.eclap.eu/schema/eclap/3D">http://www.eclap.eu/schema/eclap/3D</seealso>
    let _3D = Prefixed_Name(eclap, "3D") |> PrefixedName
    /// <summary>
    ///   <para>eclap:Audio</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An audio content</para>
    /// labels<para>Audio</para></remarks>
    /// <seealso href="http://www.eclap.eu/schema/eclap/Audio">http://www.eclap.eu/schema/eclap/Audio</seealso>
    let Audio = Prefixed_Name(eclap, "Audio") |> PrefixedName
    /// <summary>
    ///   <para>eclap:Collection</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A collection of other content</para>
    /// labels<para>Collection</para></remarks>
    /// <seealso href="http://www.eclap.eu/schema/eclap/Collection">http://www.eclap.eu/schema/eclap/Collection</seealso>
    let Collection = Prefixed_Name(eclap, "Collection") |> PrefixedName
    /// <summary>
    ///   <para>eclap:Excel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A spreadsheet based content</para>
    /// labels<para>Excel</para></remarks>
    /// <seealso href="http://www.eclap.eu/schema/eclap/Excel">http://www.eclap.eu/schema/eclap/Excel</seealso>
    let Excel = Prefixed_Name(eclap, "Excel") |> PrefixedName
    /// <summary>
    ///   <para>eclap:Playlist</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A playlist of audio visual content</para>
    /// labels<para>Playlist</para></remarks>
    /// <seealso href="http://www.eclap.eu/schema/eclap/Playlist">http://www.eclap.eu/schema/eclap/Playlist</seealso>
    let Playlist = Prefixed_Name(eclap, "Playlist") |> PrefixedName
    /// <summary>
    ///   <para>eclap:Archive</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An archival content as ZIP, RAR, TAR, etc.</para>
    /// labels<para>Archive</para></remarks>
    /// <seealso href="http://www.eclap.eu/schema/eclap/Archive">http://www.eclap.eu/schema/eclap/Archive</seealso>
    let Archive = Prefixed_Name(eclap, "Archive") |> PrefixedName
    /// <summary>
    ///   <para>eclap:Crossmedia</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A cross media content</para>
    /// labels<para>Crossmedia</para></remarks>
    /// <seealso href="http://www.eclap.eu/schema/eclap/Crossmedia">http://www.eclap.eu/schema/eclap/Crossmedia</seealso>
    let Crossmedia = Prefixed_Name(eclap, "Crossmedia") |> PrefixedName
    /// <summary>
    ///   <para>eclap:Explosive</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An explosive annotation</para>
    /// labels<para>Explosive Annotation</para></remarks>
    /// <seealso href="http://www.eclap.eu/schema/eclap/Explosive">http://www.eclap.eu/schema/eclap/Explosive</seealso>
    let Explosive = Prefixed_Name(eclap, "Explosive") |> PrefixedName
    /// <summary>
    ///   <para>eclap:Image</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An image based content</para>
    /// labels<para>Image</para></remarks>
    /// <seealso href="http://www.eclap.eu/schema/eclap/Image">http://www.eclap.eu/schema/eclap/Image</seealso>
    let Image = Prefixed_Name(eclap, "Image") |> PrefixedName
    /// <summary>
    ///   <para>eclap:AVObject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An audio visual content</para>
    /// labels<para>AVObject</para></remarks>
    /// <seealso href="http://www.eclap.eu/schema/eclap/AVObject">http://www.eclap.eu/schema/eclap/AVObject</seealso>
    let AVObject = Prefixed_Name(eclap, "AVObject") |> PrefixedName
    /// <summary>
    ///   <para>eclap:Document</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A textual document</para>
    /// labels<para>Document</para></remarks>
    /// <seealso href="http://www.eclap.eu/schema/eclap/Document">http://www.eclap.eu/schema/eclap/Document</seealso>
    let Document = Prefixed_Name(eclap, "Document") |> PrefixedName
    /// <summary>
    ///   <para>eclap:Slide</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A Slide based content (e.g. PPT)</para>
    /// labels<para>Slide</para></remarks>
    /// <seealso href="http://www.eclap.eu/schema/eclap/Slide">http://www.eclap.eu/schema/eclap/Slide</seealso>
    let Slide = Prefixed_Name(eclap, "Slide") |> PrefixedName
    /// <summary>
    ///   <para>eclap:Tool</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A tool content (e.g. an executable file)</para>
    /// labels<para>Tool</para></remarks>
    /// <seealso href="http://www.eclap.eu/schema/eclap/Tool">http://www.eclap.eu/schema/eclap/Tool</seealso>
    let Tool = Prefixed_Name(eclap, "Tool") |> PrefixedName
    /// <summary>
    ///   <para>eclap:Video</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A Video content</para>
    /// labels<para>Video</para></remarks>
    /// <seealso href="http://www.eclap.eu/schema/eclap/Video">http://www.eclap.eu/schema/eclap/Video</seealso>
    let Video = Prefixed_Name(eclap, "Video") |> PrefixedName

    /// <summary>
    ///   <para>eclap:performingArtsProfessional</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Indicates a name of a performing arts professional involved in the creation of the creative work</para>
    /// labels<para>performing arts professional</para></remarks>
    /// <seealso href="http://www.eclap.eu/schema/eclap/performingArtsProfessional">http://www.eclap.eu/schema/eclap/performingArtsProfessional</seealso>
    let performingArtsProfessional =
        Prefixed_Name(eclap, "performingArtsProfessional") |> PrefixedName

    /// <summary>
    ///   <para>eclap:artisticMovementAndActingStyle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Indicates the artistic momement and acting style used for the performance depicted/referred in the resource</para>
    /// labels<para>artistic movement and acting style</para></remarks>
    /// <seealso href="http://www.eclap.eu/schema/eclap/artisticMovementAndActingStyle">http://www.eclap.eu/schema/eclap/artisticMovementAndActingStyle</seealso>
    let artisticMovementAndActingStyle =
        Prefixed_Name(eclap, "artisticMovementAndActingStyle") |> PrefixedName

    /// <summary>
    ///   <para>eclap:cast</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Indicates name or names in the cast</para>
    /// labels<para>cast</para></remarks>
    /// <seealso href="http://www.eclap.eu/schema/eclap/cast">http://www.eclap.eu/schema/eclap/cast</seealso>
    let cast = Prefixed_Name(eclap, "cast") |> PrefixedName
    /// <summary>
    ///   <para>eclap:One2One</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An One2One annotation</para>
    /// labels<para>One2One Annotation</para></remarks>
    /// <seealso href="http://www.eclap.eu/schema/eclap/One2One">http://www.eclap.eu/schema/eclap/One2One</seealso>
    let One2One = Prefixed_Name(eclap, "One2One") |> PrefixedName
    /// <summary>
    ///   <para>eclap:User</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An User registered on ECLAP portal</para>
    /// labels<para>User</para></remarks>
    /// <seealso href="http://www.eclap.eu/schema/eclap/User">http://www.eclap.eu/schema/eclap/User</seealso>
    let User = Prefixed_Name(eclap, "User") |> PrefixedName
    /// <summary>
    ///   <para>eclap:actor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Indicates the name of an "actor" involved in life-cycle of the performance depicted/referred in the resource</para>
    /// labels<para>actor</para></remarks>
    /// <seealso href="http://www.eclap.eu/schema/eclap/actor">http://www.eclap.eu/schema/eclap/actor</seealso>
    let actor = Prefixed_Name(eclap, "actor") |> PrefixedName
    /// <summary>
    ///   <para>eclap:acrobat</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Indicates the name of an "acrobat" involved in life-cycle of the performance depicted/referred in the resource</para>
    /// labels<para>acrobat</para></remarks>
    /// <seealso href="http://www.eclap.eu/schema/eclap/acrobat">http://www.eclap.eu/schema/eclap/acrobat</seealso>
    let acrobat = Prefixed_Name(eclap, "acrobat") |> PrefixedName
    /// <summary>
    ///   <para>eclap:adaptator</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Indicates the name of an "adaptor" involved in life-cycle of the performance depicted/referred in the resource</para>
    /// labels<para>adaptor</para></remarks>
    /// <seealso href="http://www.eclap.eu/schema/eclap/adaptator">http://www.eclap.eu/schema/eclap/adaptator</seealso>
    let adaptator = Prefixed_Name(eclap, "adaptator") |> PrefixedName
    /// <summary>
    ///   <para>eclap:assistantDirector</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Indicates the name of an "assistant director" involved in life-cycle of the performance depicted/referred in the resource</para>
    /// labels<para>assistant director</para></remarks>
    /// <seealso href="http://www.eclap.eu/schema/eclap/assistantDirector">http://www.eclap.eu/schema/eclap/assistantDirector</seealso>
    let assistantDirector = Prefixed_Name(eclap, "assistantDirector") |> PrefixedName
    /// <summary>
    ///   <para>eclap:admin</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Indicates the User that is the administrator of a group</para>
    /// labels<para>admin</para></remarks>
    /// <seealso href="http://www.eclap.eu/schema/eclap/admin">http://www.eclap.eu/schema/eclap/admin</seealso>
    let admin = Prefixed_Name(eclap, "admin") |> PrefixedName
    /// <summary>
    ///   <para>eclap:architect</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Indicates the name of an "architect" involved in life-cycle of the performance depicted/referred in the resource</para>
    /// labels<para>architect</para></remarks>
    /// <seealso href="http://www.eclap.eu/schema/eclap/architect">http://www.eclap.eu/schema/eclap/architect</seealso>
    let architect = Prefixed_Name(eclap, "architect") |> PrefixedName
    /// <summary>
    ///   <para>eclap:casting</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Indicates the name of a "casting" involved in life-cycle of the performance depicted/referred in the resource</para>
    /// labels<para>casting</para></remarks>
    /// <seealso href="http://www.eclap.eu/schema/eclap/casting">http://www.eclap.eu/schema/eclap/casting</seealso>
    let casting = Prefixed_Name(eclap, "casting") |> PrefixedName
    /// <summary>
    ///   <para>eclap:choreographer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Indicates the name of an "choreographer" involved in life-cycle of the performance depicted/referred in the resource</para>
    /// labels<para>choreographer</para></remarks>
    /// <seealso href="http://www.eclap.eu/schema/eclap/choreographer">http://www.eclap.eu/schema/eclap/choreographer</seealso>
    let choreographer = Prefixed_Name(eclap, "choreographer") |> PrefixedName
    /// <summary>
    ///   <para>eclap:costumeDesigner</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Indicates the name of a "costume designer" involved in life-cycle of the performance depicted/referred in the resource</para>
    /// labels<para>costume designer</para></remarks>
    /// <seealso href="http://www.eclap.eu/schema/eclap/costumeDesigner">http://www.eclap.eu/schema/eclap/costumeDesigner</seealso>
    let costumeDesigner = Prefixed_Name(eclap, "costumeDesigner") |> PrefixedName
    /// <summary>
    ///   <para>eclap:dancer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Indicates the name of a "dancer" involved in life-cycle of the performance depicted/referred in the resource</para>
    /// labels<para>dancer</para></remarks>
    /// <seealso href="http://www.eclap.eu/schema/eclap/dancer">http://www.eclap.eu/schema/eclap/dancer</seealso>
    let dancer = Prefixed_Name(eclap, "dancer") |> PrefixedName
    /// <summary>
    ///   <para>eclap:performersAndCrew</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Indicates the name or names of performers and crew involved in the creation of the performance depicted/referred in the resource</para>
    /// labels<para>performers and crew</para></remarks>
    /// <seealso href="http://www.eclap.eu/schema/eclap/performersAndCrew">http://www.eclap.eu/schema/eclap/performersAndCrew</seealso>
    let performersAndCrew = Prefixed_Name(eclap, "performersAndCrew") |> PrefixedName
    /// <summary>
    ///   <para>eclap:clown</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Indicates the name of a "clown" involved in life-cycle of the performance depicted/referred in the resource</para>
    /// labels<para>clown</para></remarks>
    /// <seealso href="http://www.eclap.eu/schema/eclap/clown">http://www.eclap.eu/schema/eclap/clown</seealso>
    let clown = Prefixed_Name(eclap, "clown") |> PrefixedName
    /// <summary>
    ///   <para>eclap:createdAnnotation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Indicates an annotation created by an User</para>
    /// labels<para>created annotation</para></remarks>
    /// <seealso href="http://www.eclap.eu/schema/eclap/createdAnnotation">http://www.eclap.eu/schema/eclap/createdAnnotation</seealso>
    let createdAnnotation = Prefixed_Name(eclap, "createdAnnotation") |> PrefixedName
    /// <summary>
    ///   <para>eclap:critic</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Indicates the name of a "critic" involved in life-cycle of the performance depicted/referred in the resource</para>
    /// labels<para>critic</para></remarks>
    /// <seealso href="http://www.eclap.eu/schema/eclap/critic">http://www.eclap.eu/schema/eclap/critic</seealso>
    let critic = Prefixed_Name(eclap, "critic") |> PrefixedName
    /// <summary>
    ///   <para>eclap:director</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Indicates the name of a "director" involved in life-cycle of the performance depicted/referred in the resource</para>
    /// labels<para>director</para></remarks>
    /// <seealso href="http://www.eclap.eu/schema/eclap/director">http://www.eclap.eu/schema/eclap/director</seealso>
    let director = Prefixed_Name(eclap, "director") |> PrefixedName

    /// <summary>
    ///   <para>eclap:firstPerformanceCity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Indicates the city where the first performance (or premiere) of the performance depicted/referred in the resource was held</para>
    /// labels<para>first performance city</para></remarks>
    /// <seealso href="http://www.eclap.eu/schema/eclap/firstPerformanceCity">http://www.eclap.eu/schema/eclap/firstPerformanceCity</seealso>
    let firstPerformanceCity =
        Prefixed_Name(eclap, "firstPerformanceCity") |> PrefixedName

    /// <summary>
    ///   <para>eclap:firstPerformanceDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Indicates the date of the first performance (or premiere) of the performance depicted/referred in the resource</para>
    /// labels<para>first performance date</para></remarks>
    /// <seealso href="http://www.eclap.eu/schema/eclap/firstPerformanceDate">http://www.eclap.eu/schema/eclap/firstPerformanceDate</seealso>
    let firstPerformanceDate =
        Prefixed_Name(eclap, "firstPerformanceDate") |> PrefixedName

    /// <summary>
    ///   <para>eclap:composer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Indicates the name of a "composer" involved in life-cycle of the performance depicted/referred in the resource</para>
    /// labels<para>composer</para></remarks>
    /// <seealso href="http://www.eclap.eu/schema/eclap/composer">http://www.eclap.eu/schema/eclap/composer</seealso>
    let composer = Prefixed_Name(eclap, "composer") |> PrefixedName
    /// <summary>
    ///   <para>eclap:dramaturge</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Indicates the name of a "dramaturge" involved in life-cycle of the performance depicted/referred in the resource</para>
    /// labels<para>dramaturge</para></remarks>
    /// <seealso href="http://www.eclap.eu/schema/eclap/dramaturge">http://www.eclap.eu/schema/eclap/dramaturge</seealso>
    let dramaturge = Prefixed_Name(eclap, "dramaturge") |> PrefixedName

    /// <summary>
    ///   <para>eclap:firstPerformanceCountry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Indicates the country where the first performance (or premiere) of the performance depicted/referred in the resource was held</para>
    /// labels<para>first performance country</para></remarks>
    /// <seealso href="http://www.eclap.eu/schema/eclap/firstPerformanceCountry">http://www.eclap.eu/schema/eclap/firstPerformanceCountry</seealso>
    let firstPerformanceCountry =
        Prefixed_Name(eclap, "firstPerformanceCountry") |> PrefixedName

    /// <summary>
    ///   <para>eclap:conceptOriginator</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Indicates the name of a "concept originator" involved in life-cycle of the performance depicted/referred in the resource</para>
    /// labels<para>concept originator</para></remarks>
    /// <seealso href="http://www.eclap.eu/schema/eclap/conceptOriginator">http://www.eclap.eu/schema/eclap/conceptOriginator</seealso>
    let conceptOriginator = Prefixed_Name(eclap, "conceptOriginator") |> PrefixedName
    /// <summary>
    ///   <para>eclap:genre</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Indicates the genre of the creative work</para>
    /// labels<para>genre</para></remarks>
    /// <seealso href="http://www.eclap.eu/schema/eclap/genre">http://www.eclap.eu/schema/eclap/genre</seealso>
    let genre = Prefixed_Name(eclap, "genre") |> PrefixedName
    /// <summary>
    ///   <para>eclap:hasAnnotation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Indicates the annotation associated with a content</para>
    /// labels<para>has annotation</para></remarks>
    /// <seealso href="http://www.eclap.eu/schema/eclap/hasAnnotation">http://www.eclap.eu/schema/eclap/hasAnnotation</seealso>
    let hasAnnotation = Prefixed_Name(eclap, "hasAnnotation") |> PrefixedName
    /// <summary>
    ///   <para>eclap:hasFeatured</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Indicates that an User has made featured a content</para>
    /// labels<para>has featured</para></remarks>
    /// <seealso href="http://www.eclap.eu/schema/eclap/hasFeatured">http://www.eclap.eu/schema/eclap/hasFeatured</seealso>
    let hasFeatured = Prefixed_Name(eclap, "hasFeatured") |> PrefixedName
    /// <summary>
    ///   <para>eclap:historicaPeriod</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Indicates the historical period</para>
    /// labels<para>historical period</para></remarks>
    /// <seealso href="http://www.eclap.eu/schema/eclap/historicaPeriod">http://www.eclap.eu/schema/eclap/historicaPeriod</seealso>
    let historicaPeriod = Prefixed_Name(eclap, "historicaPeriod") |> PrefixedName

    /// <summary>
    ///   <para>eclap:firstPerformancePlace</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Indicates the place (e.g, the theatre) where the first performance (or premiere) of the performance depicted/referred in the resource was held</para>
    /// labels<para>first performance place</para></remarks>
    /// <seealso href="http://www.eclap.eu/schema/eclap/firstPerformancePlace">http://www.eclap.eu/schema/eclap/firstPerformancePlace</seealso>
    let firstPerformancePlace =
        Prefixed_Name(eclap, "firstPerformancePlace") |> PrefixedName

    /// <summary>
    ///   <para>eclap:isFeaturedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Indicates that a resource is featured by an User</para>
    /// labels<para>is featured by</para></remarks>
    /// <seealso href="http://www.eclap.eu/schema/eclap/isFeaturedBy">http://www.eclap.eu/schema/eclap/isFeaturedBy</seealso>
    let isFeaturedBy = Prefixed_Name(eclap, "isFeaturedBy") |> PrefixedName
    /// <summary>
    ///   <para>eclap:hairdresser</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Indicates the name of a "hairdresser" involved in life-cycle of the performance depicted/referred in the resource</para>
    /// labels<para>hairdresser</para></remarks>
    /// <seealso href="http://www.eclap.eu/schema/eclap/hairdresser">http://www.eclap.eu/schema/eclap/hairdresser</seealso>
    let hairdresser = Prefixed_Name(eclap, "hairdresser") |> PrefixedName
    /// <summary>
    ///   <para>eclap:isFavoriteOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Indicates that a resource is favorite from an User</para>
    /// labels<para>is favorite of</para></remarks>
    /// <seealso href="http://www.eclap.eu/schema/eclap/isFavoriteOf">http://www.eclap.eu/schema/eclap/isFavoriteOf</seealso>
    let isFavoriteOf = Prefixed_Name(eclap, "isFavoriteOf") |> PrefixedName
    /// <summary>
    ///   <para>eclap:isMemberOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Indicates that a User is member of a group, it is the inverse of the foaof:member property</para>
    /// labels<para>isMemberOf</para></remarks>
    /// <seealso href="http://www.eclap.eu/schema/eclap/isMemberOf">http://www.eclap.eu/schema/eclap/isMemberOf</seealso>
    let isMemberOf = Prefixed_Name(eclap, "isMemberOf") |> PrefixedName
    /// <summary>
    ///   <para>eclap:hasFavorite</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Indicates that an User has as favorite a content</para>
    /// labels<para>has favourite</para></remarks>
    /// <seealso href="http://www.eclap.eu/schema/eclap/hasFavorite">http://www.eclap.eu/schema/eclap/hasFavorite</seealso>
    let hasFavorite = Prefixed_Name(eclap, "hasFavorite") |> PrefixedName
    /// <summary>
    ///   <para>eclap:isProvidedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Indicates that a resource is provided by a group</para>
    /// labels<para>is provided by</para></remarks>
    /// <seealso href="http://www.eclap.eu/schema/eclap/isProvidedBy">http://www.eclap.eu/schema/eclap/isProvidedBy</seealso>
    let isProvidedBy = Prefixed_Name(eclap, "isProvidedBy") |> PrefixedName
    /// <summary>
    ///   <para>eclap:lightDesigner</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Indicates the name of a "light designer" involved in life-cycle of the performance depicted/referred in the resource</para>
    /// labels<para>light designer</para></remarks>
    /// <seealso href="http://www.eclap.eu/schema/eclap/lightDesigner">http://www.eclap.eu/schema/eclap/lightDesigner</seealso>
    let lightDesigner = Prefixed_Name(eclap, "lightDesigner") |> PrefixedName
    /// <summary>
    ///   <para>eclap:patron</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Indicates the name of a "patron" involved in life-cycle of the performance depicted/referred in the resource</para>
    /// labels<para>patron</para></remarks>
    /// <seealso href="http://www.eclap.eu/schema/eclap/patron">http://www.eclap.eu/schema/eclap/patron</seealso>
    let patron = Prefixed_Name(eclap, "patron") |> PrefixedName
    /// <summary>
    ///   <para>eclap:performanceCity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Indicates the city where the performance depicted/referred in the resource was held</para>
    /// labels<para>performance city</para></remarks>
    /// <seealso href="http://www.eclap.eu/schema/eclap/performanceCity">http://www.eclap.eu/schema/eclap/performanceCity</seealso>
    let performanceCity = Prefixed_Name(eclap, "performanceCity") |> PrefixedName
    /// <summary>
    ///   <para>eclap:isAdminOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Indicates that an User is the administrator of a group, and it is also a member of the same group.</para>
    /// labels<para>isAdminOf</para></remarks>
    /// <seealso href="http://www.eclap.eu/schema/eclap/isAdminOf">http://www.eclap.eu/schema/eclap/isAdminOf</seealso>
    let isAdminOf = Prefixed_Name(eclap, "isAdminOf") |> PrefixedName
    /// <summary>
    ///   <para>eclap:isSubjectOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Indicates that the concept is the subject of a creative work</para>
    /// labels<para>isSubjectOf</para></remarks>
    /// <seealso href="http://www.eclap.eu/schema/eclap/isSubjectOf">http://www.eclap.eu/schema/eclap/isSubjectOf</seealso>
    let isSubjectOf = Prefixed_Name(eclap, "isSubjectOf") |> PrefixedName
    /// <summary>
    ///   <para>eclap:isUploadedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Indicates that a resource was uploaded by an User</para>
    /// labels<para>is uploaded by</para></remarks>
    /// <seealso href="http://www.eclap.eu/schema/eclap/isUploadedBy">http://www.eclap.eu/schema/eclap/isUploadedBy</seealso>
    let isUploadedBy = Prefixed_Name(eclap, "isUploadedBy") |> PrefixedName

    /// <summary>
    ///   <para>eclap:managementAndOrganization</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Indicates management and organization information associated with the resource</para>
    /// labels<para>management and organization</para></remarks>
    /// <seealso href="http://www.eclap.eu/schema/eclap/managementAndOrganization">http://www.eclap.eu/schema/eclap/managementAndOrganization</seealso>
    let managementAndOrganization =
        Prefixed_Name(eclap, "managementAndOrganization") |> PrefixedName

    /// <summary>
    ///   <para>eclap:maskDesigner</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Indicates the name of a "mask designer" involved in life-cycle of the performance depicted/referred in the resource</para>
    /// labels<para>mask designer</para></remarks>
    /// <seealso href="http://www.eclap.eu/schema/eclap/maskDesigner">http://www.eclap.eu/schema/eclap/maskDesigner</seealso>
    let maskDesigner = Prefixed_Name(eclap, "maskDesigner") |> PrefixedName
    /// <summary>
    ///   <para>eclap:musician</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Indicates the name of a "musician" involved in life-cycle of the performance depicted/referred in the resource</para>
    /// labels<para>musician</para></remarks>
    /// <seealso href="http://www.eclap.eu/schema/eclap/musician">http://www.eclap.eu/schema/eclap/musician</seealso>
    let musician = Prefixed_Name(eclap, "musician") |> PrefixedName
    /// <summary>
    ///   <para>eclap:performanceDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Indicates the date when it was performed the performance depicted in the resource</para>
    /// labels<para>performance date</para></remarks>
    /// <seealso href="http://www.eclap.eu/schema/eclap/performanceDate">http://www.eclap.eu/schema/eclap/performanceDate</seealso>
    let performanceDate = Prefixed_Name(eclap, "performanceDate") |> PrefixedName
    /// <summary>
    ///   <para>eclap:performer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Indicates the name of a "performer" involved in life-cycle of the performance depicted/referred in the resource</para>
    /// labels<para>performer</para></remarks>
    /// <seealso href="http://www.eclap.eu/schema/eclap/performer">http://www.eclap.eu/schema/eclap/performer</seealso>
    let performer = Prefixed_Name(eclap, "performer") |> PrefixedName
    /// <summary>
    ///   <para>eclap:playwright</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Indicates the name of a "playwright" involved in life-cycle of the performance depicted/referred in the resource</para>
    /// labels<para>playwright</para></remarks>
    /// <seealso href="http://www.eclap.eu/schema/eclap/playwright">http://www.eclap.eu/schema/eclap/playwright</seealso>
    let playwright = Prefixed_Name(eclap, "playwright") |> PrefixedName
    /// <summary>
    ///   <para>eclap:provide</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Indicates the resources provided by a Group</para>
    /// labels<para>provide</para></remarks>
    /// <seealso href="http://www.eclap.eu/schema/eclap/provide">http://www.eclap.eu/schema/eclap/provide</seealso>
    let provide = Prefixed_Name(eclap, "provide") |> PrefixedName
    /// <summary>
    ///   <para>eclap:makeUpArtist</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Indicates the name of a "make-up artist" involved in life-cycle of the performance depicted/referred in the resource</para>
    /// labels<para>make-up artist</para></remarks>
    /// <seealso href="http://www.eclap.eu/schema/eclap/makeUpArtist">http://www.eclap.eu/schema/eclap/makeUpArtist</seealso>
    let makeUpArtist = Prefixed_Name(eclap, "makeUpArtist") |> PrefixedName
    /// <summary>
    ///   <para>eclap:mime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Indicates the name of a "mime" involved in life-cycle of the performance depicted/referred in the resource</para>
    /// labels<para>mime</para></remarks>
    /// <seealso href="http://www.eclap.eu/schema/eclap/mime">http://www.eclap.eu/schema/eclap/mime</seealso>
    let mime = Prefixed_Name(eclap, "mime") |> PrefixedName
    /// <summary>
    ///   <para>eclap:marketingManager</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Indicates the name of a "marketing manager" involved in life-cycle of the performance depicted/referred in the resource</para>
    /// labels<para>marketing manager</para></remarks>
    /// <seealso href="http://www.eclap.eu/schema/eclap/marketingManager">http://www.eclap.eu/schema/eclap/marketingManager</seealso>
    let marketingManager = Prefixed_Name(eclap, "marketingManager") |> PrefixedName

    /// <summary>
    ///   <para>eclap:performingArtsGroup</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Indicates the group that was involved in the performance creation</para>
    /// labels<para>performing arts group</para></remarks>
    /// <seealso href="http://www.eclap.eu/schema/eclap/performingArtsGroup">http://www.eclap.eu/schema/eclap/performingArtsGroup</seealso>
    let performingArtsGroup =
        Prefixed_Name(eclap, "performingArtsGroup") |> PrefixedName

    /// <summary>
    ///   <para>eclap:producer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Indicates the name of a "producer" involved in life-cycle of the performance depicted/referred in the resource</para>
    /// labels<para>producer</para></remarks>
    /// <seealso href="http://www.eclap.eu/schema/eclap/producer">http://www.eclap.eu/schema/eclap/producer</seealso>
    let producer = Prefixed_Name(eclap, "producer") |> PrefixedName
    /// <summary>
    ///   <para>eclap:puppetDesigner</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Indicates the name of a "puppet designer" involved in life-cycle of the performance depicted/referred in the resource</para>
    /// labels<para>puppet designer</para></remarks>
    /// <seealso href="http://www.eclap.eu/schema/eclap/puppetDesigner">http://www.eclap.eu/schema/eclap/puppetDesigner</seealso>
    let puppetDesigner = Prefixed_Name(eclap, "puppetDesigner") |> PrefixedName
    /// <summary>
    ///   <para>eclap:seamster</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Indicates the name of a "seamster" involved in life-cycle of the performance depicted/referred in the resource</para>
    /// labels<para>seamster</para></remarks>
    /// <seealso href="http://www.eclap.eu/schema/eclap/seamster">http://www.eclap.eu/schema/eclap/seamster</seealso>
    let seamster = Prefixed_Name(eclap, "seamster") |> PrefixedName
    /// <summary>
    ///   <para>eclap:setDesigner</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Indicates the name of a "set designer" involved in life-cycle of the performance depicted/referred in the resource</para>
    /// labels<para>set designer</para></remarks>
    /// <seealso href="http://www.eclap.eu/schema/eclap/setDesigner">http://www.eclap.eu/schema/eclap/setDesigner</seealso>
    let setDesigner = Prefixed_Name(eclap, "setDesigner") |> PrefixedName
    /// <summary>
    ///   <para>eclap:technician</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Indicates the name of a "technician" involved in life-cycle of the performance depicted/referred in the resource</para>
    /// labels<para>technician</para></remarks>
    /// <seealso href="http://www.eclap.eu/schema/eclap/technician">http://www.eclap.eu/schema/eclap/technician</seealso>
    let technician = Prefixed_Name(eclap, "technician") |> PrefixedName
    /// <summary>
    ///   <para>eclap:theatreManager</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Indicates the name of a "theatre manager" involved in life-cycle of the performance depicted/referred in the resource</para>
    /// labels<para>theatre manager</para></remarks>
    /// <seealso href="http://www.eclap.eu/schema/eclap/theatreManager">http://www.eclap.eu/schema/eclap/theatreManager</seealso>
    let theatreManager = Prefixed_Name(eclap, "theatreManager") |> PrefixedName
    /// <summary>
    ///   <para>eclap:recordingDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Indicates the date of recording of the original audio visual resource</para>
    /// labels<para>recording date</para></remarks>
    /// <seealso href="http://www.eclap.eu/schema/eclap/recordingDate">http://www.eclap.eu/schema/eclap/recordingDate</seealso>
    let recordingDate = Prefixed_Name(eclap, "recordingDate") |> PrefixedName
    /// <summary>
    ///   <para>eclap:setBuilder</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Indicates the name of a "set builder" involved in life-cycle of the performance depicted/referred in the resource</para>
    /// labels<para>set builder</para></remarks>
    /// <seealso href="http://www.eclap.eu/schema/eclap/setBuilder">http://www.eclap.eu/schema/eclap/setBuilder</seealso>
    let setBuilder = Prefixed_Name(eclap, "setBuilder") |> PrefixedName
    /// <summary>
    ///   <para>eclap:soundDesigner</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Indicates the name of a "sound designer" involved in life-cycle of the performance depicted/referred in the resource</para>
    /// labels<para>sound designer</para></remarks>
    /// <seealso href="http://www.eclap.eu/schema/eclap/soundDesigner">http://www.eclap.eu/schema/eclap/soundDesigner</seealso>
    let soundDesigner = Prefixed_Name(eclap, "soundDesigner") |> PrefixedName
    /// <summary>
    ///   <para>eclap:scenographer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Indicates the name of a "scenographer" involved in life-cycle of the performance depicted/referred in the resource</para>
    /// labels<para>scenographer</para></remarks>
    /// <seealso href="http://www.eclap.eu/schema/eclap/scenographer">http://www.eclap.eu/schema/eclap/scenographer</seealso>
    let scenographer = Prefixed_Name(eclap, "scenographer") |> PrefixedName
    /// <summary>
    ///   <para>eclap:stageManager</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Indicates the name of a "stage manager" involved in life-cycle of the performance depicted/referred in the resource</para>
    /// labels<para>stage manager</para></remarks>
    /// <seealso href="http://www.eclap.eu/schema/eclap/stageManager">http://www.eclap.eu/schema/eclap/stageManager</seealso>
    let stageManager = Prefixed_Name(eclap, "stageManager") |> PrefixedName
    /// <summary>
    ///   <para>eclap:translator</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Indicates the name of a "translator" involved in life-cycle of the performance depicted/referred in the resource</para>
    /// labels<para>translator</para></remarks>
    /// <seealso href="http://www.eclap.eu/schema/eclap/translator">http://www.eclap.eu/schema/eclap/translator</seealso>
    let translator = Prefixed_Name(eclap, "translator") |> PrefixedName
    /// <summary>
    ///   <para>eclap:singer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Indicates the name of a "singer" involved in life-cycle of the performance depicted/referred in the resource</para>
    /// labels<para>singer</para></remarks>
    /// <seealso href="http://www.eclap.eu/schema/eclap/singer">http://www.eclap.eu/schema/eclap/singer</seealso>
    let singer = Prefixed_Name(eclap, "singer") |> PrefixedName
    /// <summary>
    ///   <para>eclap:theoretician</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Indicates the name of a "theoretician" involved in life-cycle of the performance depicted/referred in the resource</para>
    /// labels<para>theoretician</para></remarks>
    /// <seealso href="http://www.eclap.eu/schema/eclap/theoretician">http://www.eclap.eu/schema/eclap/theoretician</seealso>
    let theoretician = Prefixed_Name(eclap, "theoretician") |> PrefixedName
    /// <summary>
    ///   <para>eclap:uploaded</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Indicates the media objects uploaded by the user</para>
    /// labels<para>uploaded</para></remarks>
    /// <seealso href="http://www.eclap.eu/schema/eclap/uploaded">http://www.eclap.eu/schema/eclap/uploaded</seealso>
    let uploaded = Prefixed_Name(eclap, "uploaded") |> PrefixedName
    /// <summary>
    ///   <para>eclap:</para>
    /// </summary>
    /// <remarks>
    ///   <para>voaf:Vocabulary</para>
    ///   <para>owl:Ontology</para>
    /// </remarks>
    /// <seealso href="http://www.eclap.eu/schema/eclap/">http://www.eclap.eu/schema/eclap/</seealso>
    let _prefix_iri = Prefixed_Name(eclap, "") |> PrefixedName
    /// <summary>
    ///   <para>eclap:performanceCountry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Indicates the country where the performance depicted/referred in the resource was held</para>
    /// labels<para>performance country</para></remarks>
    /// <seealso href="http://www.eclap.eu/schema/eclap/performanceCountry">http://www.eclap.eu/schema/eclap/performanceCountry</seealso>
    let performanceCountry = Prefixed_Name(eclap, "performanceCountry") |> PrefixedName
    /// <summary>
    ///   <para>eclap:performancePlace</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Indicates the place (e.g., the theatre) where the performance depicted/referred in the resource was held</para>
    /// labels<para>performance place</para></remarks>
    /// <seealso href="http://www.eclap.eu/schema/eclap/performancePlace">http://www.eclap.eu/schema/eclap/performancePlace</seealso>
    let performancePlace = Prefixed_Name(eclap, "performancePlace") |> PrefixedName
    /// <summary>
    ///   <para>eclap:performingArtType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Indicates the type of performing art (e.g. dance, theatre) in the resource</para>
    /// labels<para>performing art type</para></remarks>
    /// <seealso href="http://www.eclap.eu/schema/eclap/performingArtType">http://www.eclap.eu/schema/eclap/performingArtType</seealso>
    let performingArtType = Prefixed_Name(eclap, "performingArtType") |> PrefixedName
    /// <summary>
    ///   <para>eclap:plotSummary</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Indicates the summary of the plot of the performance depicted/referred in the resource</para>
    /// labels<para>plot summary</para></remarks>
    /// <seealso href="http://www.eclap.eu/schema/eclap/plotSummary">http://www.eclap.eu/schema/eclap/plotSummary</seealso>
    let plotSummary = Prefixed_Name(eclap, "plotSummary") |> PrefixedName
