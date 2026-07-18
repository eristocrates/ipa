namespace http.purl.org.ontology.po.slash

open DoxAletheia.Rdf_Vocabulary

module po =
    let _namespace_name = "http://purl.org/ontology/po/"
    /// <summary>
    ///   <see href="http://purl.org/ontology/po/1.0"></see>
    /// </summary>
    let ``_1.0`` = Namespaced_IRI.parse _namespace_name "1.0" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/ontology/po/1.1"></see>
    /// </summary>
    let ``_1.1`` = Namespaced_IRI.parse _namespace_name "1.1" |> NamespacedName

    /// <summary>
    ///
    /// 		A version holding an audio description.
    ///
    /// <see href="http://purl.org/ontology/po/AudioDescribedVersion"></see></summary>
    let AudioDescribedVersion =
        Namespaced_IRI.parse _namespace_name "AudioDescribedVersion" |> NamespacedName

    /// <summary>
    ///
    /// 		A particular version of an episode.
    /// 		Such versions include shortened ones, audio described ones
    /// 		or ones that holds sign language.
    /// 		The version is associated to a timeline.
    ///
    /// <see href="http://purl.org/ontology/po/Version"></see></summary>
    let Version = Namespaced_IRI.parse _namespace_name "Version" |> NamespacedName
    /// <summary>
    ///
    /// 		A brand, e.g. `Top Gear'
    ///
    /// <see href="http://purl.org/ontology/po/Brand"></see></summary>
    let Brand = Namespaced_IRI.parse _namespace_name "Brand" |> NamespacedName
    /// <summary>
    ///
    /// 		A programme, can either be a brand, a series or an episode
    ///
    /// <see href="http://purl.org/ontology/po/Programme"></see></summary>
    let Programme = Namespaced_IRI.parse _namespace_name "Programme" |> NamespacedName
    /// <summary>
    ///
    /// 		A series, e.g. `Top Gear, first season'
    ///
    /// <see href="http://purl.org/ontology/po/Series"></see></summary>
    let Series = Namespaced_IRI.parse _namespace_name "Series" |> NamespacedName
    /// <summary>
    ///
    /// 		A particular episode, e.g. `Top Gear, first episode of the first series' or the film 'A Walk in the Sun' (http://www.bbc.co.uk/programmes/b00gfzdt)
    ///
    /// <see href="http://purl.org/ontology/po/Episode"></see></summary>
    let Episode = Namespaced_IRI.parse _namespace_name "Episode" |> NamespacedName
    /// <summary>
    ///
    ///         A particular clip, e.g. `Clip of Top Gear, first series'
    ///
    /// <see href="http://purl.org/ontology/po/Clip"></see></summary>
    let Clip = Namespaced_IRI.parse _namespace_name "Clip" |> NamespacedName
    /// <summary>
    ///
    /// 		A broadcast event.
    /// 		Subsumes the event concept defined in
    /// 		the Event ontology.
    /// 		A broadcast is associated with a service, and with a
    /// 		particular version of an episode.
    ///
    /// <see href="http://purl.org/ontology/po/Broadcast"></see></summary>
    let Broadcast = Namespaced_IRI.parse _namespace_name "Broadcast" |> NamespacedName

    /// <summary>
    ///
    /// 		An organization responsible of some broadcasting services.
    ///         It can hold a set of services and outlets.
    ///
    /// <see href="http://purl.org/ontology/po/Broadcaster"></see></summary>
    let Broadcaster =
        Namespaced_IRI.parse _namespace_name "Broadcaster" |> NamespacedName

    /// <summary>
    ///
    ///         A category provides a way of classifying a set of programmes. Such classifications
    ///         can be performed according to multiple dimensions and taxonomies, e.g. genre, format, places, people, subjects...
    ///
    /// <see href="http://purl.org/ontology/po/Category"></see></summary>
    let Category = Namespaced_IRI.parse _namespace_name "Category" |> NamespacedName
    /// <summary>
    ///
    ///         A physical channel on which a broadcast occurs.
    ///         A single outlet or service can be associated with multiple channels.
    ///         For example, Radio 4 LW broadcasts on Analogue Long Wave and on Digital
    ///         Satellite.
    ///
    /// <see href="http://purl.org/ontology/po/Channel"></see></summary>
    let Channel = Namespaced_IRI.parse _namespace_name "Channel" |> NamespacedName

    /// <summary>
    ///
    ///         A programme that can have versions, and as such can be broadcast or made available on-demand, e.g. a clip or an episode.
    ///
    /// <see href="http://purl.org/ontology/po/ProgrammeItem"></see></summary>
    let ProgrammeItem =
        Namespaced_IRI.parse _namespace_name "ProgrammeItem" |> NamespacedName

    /// <summary>
    ///
    /// 		Digital Audio Broadcasting
    ///
    /// <see href="http://purl.org/ontology/po/DAB"></see></summary>
    let DAB = Namespaced_IRI.parse _namespace_name "DAB" |> NamespacedName
    /// <summary>
    ///
    /// 		Digital Video Broadcasting
    ///
    /// <see href="http://purl.org/ontology/po/DVB"></see></summary>
    let DVB = Namespaced_IRI.parse _namespace_name "DVB" |> NamespacedName
    /// <summary>
    ///
    /// 		The FM broadcast band
    ///
    /// <see href="http://purl.org/ontology/po/FM"></see></summary>
    let FM = Namespaced_IRI.parse _namespace_name "FM" |> NamespacedName

    /// <summary>
    ///
    /// 		Specifies a broadcast as being the
    /// 		first one of a particular version.
    ///
    /// <see href="http://purl.org/ontology/po/FirstBroadcast"></see></summary>
    let FirstBroadcast =
        Namespaced_IRI.parse _namespace_name "FirstBroadcast" |> NamespacedName

    /// <summary>
    ///
    /// 		Specifies a broadcast as being a
    /// 		repeat.
    ///
    /// <see href="http://purl.org/ontology/po/RepeatBroadcast"></see></summary>
    let RepeatBroadcast =
        Namespaced_IRI.parse _namespace_name "RepeatBroadcast" |> NamespacedName

    /// <summary>
    ///
    ///         Anchor point for format taxonomies, similar to po:Genre for genre taxonomies.
    ///         Instances of this concept include documentaries, talk shows, animation, etc.
    ///
    /// <see href="http://purl.org/ontology/po/Format"></see></summary>
    let Format = Namespaced_IRI.parse _namespace_name "Format" |> NamespacedName
    /// <summary>
    ///
    ///         An anchor point for a programmes' genre taxonomy, e.g. 'Drama'/'Biographical'.
    ///
    /// <see href="http://purl.org/ontology/po/Genre"></see></summary>
    let Genre = Namespaced_IRI.parse _namespace_name "Genre" |> NamespacedName
    /// <summary>
    ///
    /// 		IP stream
    ///
    /// <see href="http://purl.org/ontology/po/IPStream"></see></summary>
    let IPStream = Namespaced_IRI.parse _namespace_name "IPStream" |> NamespacedName
    /// <summary>
    ///
    /// 		The AM broadcast band
    ///
    /// <see href="http://purl.org/ontology/po/LW"></see></summary>
    let LW = Namespaced_IRI.parse _namespace_name "LW" |> NamespacedName
    /// <summary>
    ///
    /// 		Radio services aiming at a local coverage.
    ///
    /// <see href="http://purl.org/ontology/po/LocalRadio"></see></summary>
    let LocalRadio = Namespaced_IRI.parse _namespace_name "LocalRadio" |> NamespacedName
    /// <summary>
    ///
    /// 		Services that use a radio medium.
    ///
    /// <see href="http://purl.org/ontology/po/Radio"></see></summary>
    let Radio = Namespaced_IRI.parse _namespace_name "Radio" |> NamespacedName

    /// <summary>
    ///
    /// 		Radio services aiming at a regional coverage.
    ///
    /// <see href="http://purl.org/ontology/po/RegionalRadio"></see></summary>
    let RegionalRadio =
        Namespaced_IRI.parse _namespace_name "RegionalRadio" |> NamespacedName

    /// <summary>
    ///
    /// 		Radio services aiming at a national coverage.
    ///
    /// <see href="http://purl.org/ontology/po/NationalRadio"></see></summary>
    let NationalRadio =
        Namespaced_IRI.parse _namespace_name "NationalRadio" |> NamespacedName

    /// <summary>
    ///
    /// 		Classification of an episode version's region corresponding to a musical track being played.
    ///
    /// <see href="http://purl.org/ontology/po/MusicSegment"></see></summary>
    let MusicSegment =
        Namespaced_IRI.parse _namespace_name "MusicSegment" |> NamespacedName

    /// <summary>
    ///
    /// 		Classification of an episode version's region, e.g. 'this track was played at that time'.
    ///
    /// <see href="http://purl.org/ontology/po/Segment"></see></summary>
    let Segment = Namespaced_IRI.parse _namespace_name "Segment" |> NamespacedName

    /// <summary>
    ///
    /// 		An `original' version, the legacy version of
    /// 		a particular episode.
    ///
    /// <see href="http://purl.org/ontology/po/OriginalVersion"></see></summary>
    let OriginalVersion =
        Namespaced_IRI.parse _namespace_name "OriginalVersion" |> NamespacedName

    /// <summary>
    ///
    /// 		A shortened version.
    ///
    /// <see href="http://purl.org/ontology/po/ShortenedVersion"></see></summary>
    let ShortenedVersion =
        Namespaced_IRI.parse _namespace_name "ShortenedVersion" |> NamespacedName

    /// <summary>
    ///
    ///         Outlet of a particular service, e.g. Radio 4 LW and FM for Radio 4.
    ///         Outlets are services which do not have variations.
    ///         The criterion for an outlet is its timeline.
    ///         For example, Radio 4 LW broadcasts on Analogue Long Wave, but also on Digital Satellite.
    ///         It corresponds to just one outlet, as they are simulcasts.
    ///         The two physical channels for broadcasts correspond to po:Channel.
    ///
    /// <see href="http://purl.org/ontology/po/Outlet"></see></summary>
    let Outlet = Namespaced_IRI.parse _namespace_name "Outlet" |> NamespacedName
    /// <summary>
    ///
    ///         A broadcasting service.
    /// 		Instances of this concept include BBC Radio Wales, BBC Radio 4, BBC News, etc.
    ///         A service is a collection of outlets which contain common material, but with some variations, e.g. by
    ///         region.
    ///         Hence, a service may have multiple outlets (po:Outlet), e.g. BBC Radio 4 has BBC Radio 4 LW and BBC Radio 4 FM.
    ///         A hierarchy of services types is defined within this ontology, e.g. radio and TV.
    ///         A service that is a master brand only (a service that only commissions programmes, e.g. BBC Switch) should
    ///         be an instance of the top-level po:Service.
    ///
    /// <see href="http://purl.org/ontology/po/Service"></see></summary>
    let Service = Namespaced_IRI.parse _namespace_name "Service" |> NamespacedName
    /// <summary>
    /// A person
    /// <see href="http://purl.org/ontology/po/Person"></see></summary>
    let Person = Namespaced_IRI.parse _namespace_name "Person" |> NamespacedName
    /// <summary>
    /// A physical place
    /// <see href="http://purl.org/ontology/po/Place"></see></summary>
    let Place = Namespaced_IRI.parse _namespace_name "Place" |> NamespacedName
    /// <summary>
    ///
    /// 		Services that use a Web medium.
    ///
    /// <see href="http://purl.org/ontology/po/Web"></see></summary>
    let Web = Namespaced_IRI.parse _namespace_name "Web" |> NamespacedName
    /// <summary>
    ///
    /// 		Services that use a television medium.
    ///
    /// <see href="http://purl.org/ontology/po/TV"></see></summary>
    let TV = Namespaced_IRI.parse _namespace_name "TV" |> NamespacedName
    /// <summary>
    ///
    /// 		A season is a group of broadcasts.
    ///
    /// <see href="http://purl.org/ontology/po/Season"></see></summary>
    let Season = Namespaced_IRI.parse _namespace_name "Season" |> NamespacedName

    /// <summary>
    ///
    /// 		A version holding sign language.
    ///
    /// <see href="http://purl.org/ontology/po/SignedVersion"></see></summary>
    let SignedVersion =
        Namespaced_IRI.parse _namespace_name "SignedVersion" |> NamespacedName

    /// <summary>
    ///
    ///         Classification of an episode version's region holding speech content.
    ///
    /// <see href="http://purl.org/ontology/po/SpeechSegment"></see></summary>
    let SpeechSegment =
        Namespaced_IRI.parse _namespace_name "SpeechSegment" |> NamespacedName

    /// <summary>
    ///
    ///         Anchor point for subject taxonomies.
    ///
    /// <see href="http://purl.org/ontology/po/Subject"></see></summary>
    let Subject = Namespaced_IRI.parse _namespace_name "Subject" |> NamespacedName
    /// <summary>
    ///
    ///         Classification of an episode version's region corresponding to a subtitle being shown.
    ///
    /// <see href="http://purl.org/ontology/po/Subtitle"></see></summary>
    let Subtitle = Namespaced_IRI.parse _namespace_name "Subtitle" |> NamespacedName
    /// <summary>
    /// Relates a programmes to one of its actors - a person who plays the role of a character
    /// <see href="http://purl.org/ontology/po/actor"></see></summary>
    let actor = Namespaced_IRI.parse _namespace_name "actor" |> NamespacedName
    /// <summary>
    /// Relates a programmes to a person who is credited in it
    /// <see href="http://purl.org/ontology/po/credit"></see></summary>
    let credit = Namespaced_IRI.parse _namespace_name "credit" |> NamespacedName
    /// <summary>
    /// A television reporter who coordinates a programme
    /// <see href="http://purl.org/ontology/po/anchor"></see></summary>
    let anchor = Namespaced_IRI.parse _namespace_name "anchor" |> NamespacedName

    /// <summary>
    ///
    /// 		The aspect ration of a particular version.
    ///
    /// <see href="http://purl.org/ontology/po/aspect_ratio"></see></summary>
    let aspect_ratio =
        Namespaced_IRI.parse _namespace_name "aspect_ratio" |> NamespacedName

    /// <summary>
    /// Relates a programme to its author - the person who created the content
    /// <see href="http://purl.org/ontology/po/author"></see></summary>
    let author = Namespaced_IRI.parse _namespace_name "author" |> NamespacedName

    /// <summary>
    ///
    /// 		Relates a particular broadcast to the version being broadcasted.
    /// 		Sub-property of the event:factor one.
    ///
    /// <see href="http://purl.org/ontology/po/broadcast_of"></see></summary>
    let broadcast_of =
        Namespaced_IRI.parse _namespace_name "broadcast_of" |> NamespacedName

    /// <summary>
    ///
    /// 		Relates a particular broadcast to the service or outlet on which it was.
    /// 		Sub-property of the event:factor one.
    ///
    /// <see href="http://purl.org/ontology/po/broadcast_on"></see></summary>
    let broadcast_on =
        Namespaced_IRI.parse _namespace_name "broadcast_on" |> NamespacedName

    /// <summary>
    /// Deprecated property, left here for historical reasons
    /// <see href="http://purl.org/ontology/po/broadcasted_on"></see></summary>
    let broadcasted_on =
        Namespaced_IRI.parse _namespace_name "broadcasted_on" |> NamespacedName

    /// <summary>
    ///
    /// 		Associates a service to a broadcaster
    ///
    /// <see href="http://purl.org/ontology/po/broadcaster"></see></summary>
    let broadcaster =
        Namespaced_IRI.parse _namespace_name "broadcaster" |> NamespacedName

    /// <summary>
    ///
    ///         Relates a programme to a particular category, e.g. genre, format, place...
    ///
    /// <see href="http://purl.org/ontology/po/category"></see></summary>
    let category = Namespaced_IRI.parse _namespace_name "category" |> NamespacedName
    /// <summary>
    ///
    ///         Associates a service to a channel, e.g. Radio 4 LW to Radio 4 LW on Analogue Long Wave.
    ///
    /// <see href="http://purl.org/ontology/po/channel"></see></summary>
    let channel = Namespaced_IRI.parse _namespace_name "channel" |> NamespacedName
    /// <summary>
    ///
    ///         Associates a brand, a series or an episode to a clip.
    ///
    /// <see href="http://purl.org/ontology/po/clip"></see></summary>
    let clip = Namespaced_IRI.parse _namespace_name "clip" |> NamespacedName

    /// <summary>
    /// Relates a programme to one of its commentators
    /// <see href="http://purl.org/ontology/po/commentator"></see></summary>
    let commentator =
        Namespaced_IRI.parse _namespace_name "commentator" |> NamespacedName

    /// <summary>
    /// Relates a programme to its supervisor. Generally refers to the person responsible for all audience-visible components of a program, film, or show, whereas the producer is responsible for the financial and other behind-the-scenes aspects. A director's duties might also include casting, script editing, shot selection, shot composition, and editing
    /// <see href="http://purl.org/ontology/po/director"></see></summary>
    let director = Namespaced_IRI.parse _namespace_name "director" |> NamespacedName
    /// <summary>
    /// The duration of a version, in seconds.
    /// <see href="http://purl.org/ontology/po/duration"></see></summary>
    let duration = Namespaced_IRI.parse _namespace_name "duration" |> NamespacedName
    /// <summary>
    ///
    /// 		Associates a brand or a series to an episode constituting it.
    ///
    /// <see href="http://purl.org/ontology/po/episode"></see></summary>
    let episode = Namespaced_IRI.parse _namespace_name "episode" |> NamespacedName

    /// <summary>
    /// Relates a programme to its executive producer - a producer who is not involved in any technical aspects of the making process, but who is still responsible for the overall production. Typically an executive producer handles business and legal issues
    /// <see href="http://purl.org/ontology/po/executive_producer"></see></summary>
    let executive_producer =
        Namespaced_IRI.parse _namespace_name "executive_producer" |> NamespacedName

    /// <summary>
    ///
    /// 		Relates a programme to a particular format (eg. `Animation', `Documentary', etc.).
    ///
    /// <see href="http://purl.org/ontology/po/format"></see></summary>
    let format = Namespaced_IRI.parse _namespace_name "format" |> NamespacedName
    /// <summary>
    /// Associates a channel to its frequency
    /// <see href="http://purl.org/ontology/po/frequency"></see></summary>
    let frequency = Namespaced_IRI.parse _namespace_name "frequency" |> NamespacedName
    /// <summary>
    ///
    /// 		Relates a programme to a particular genre.
    ///
    /// <see href="http://purl.org/ontology/po/genre"></see></summary>
    let genre = Namespaced_IRI.parse _namespace_name "genre" |> NamespacedName
    /// <summary>
    ///
    /// 		Associates a service to a geographic location,
    /// 		aiming at capturing what this service aims at covering.
    ///
    /// <see href="http://purl.org/ontology/po/location"></see></summary>
    let location = Namespaced_IRI.parse _namespace_name "location" |> NamespacedName

    /// <summary>
    ///
    /// 		A long synopsis of a series, brand or episode.
    /// 		Sub-property of po:synopsis.
    ///
    /// <see href="http://purl.org/ontology/po/long_synopsis"></see></summary>
    let long_synopsis =
        Namespaced_IRI.parse _namespace_name "long_synopsis" |> NamespacedName

    /// <summary>
    ///
    /// 		The synopsis of a series, brand or episode.
    ///
    /// <see href="http://purl.org/ontology/po/synopsis"></see></summary>
    let synopsis = Namespaced_IRI.parse _namespace_name "synopsis" |> NamespacedName

    /// <summary>
    /// Associates a programme with its masterbrand (its commissioner)
    /// <see href="http://purl.org/ontology/po/masterbrand"></see></summary>
    let masterbrand =
        Namespaced_IRI.parse _namespace_name "masterbrand" |> NamespacedName

    /// <summary>
    ///
    /// 		A medium synopsis of a series, brand or episode.
    /// 		Sub-property of po:synopsis.
    ///
    /// <see href="http://purl.org/ontology/po/medium_synopsis"></see></summary>
    let medium_synopsis =
        Namespaced_IRI.parse _namespace_name "medium_synopsis" |> NamespacedName

    /// <summary>
    /// Associates a programme to its microsite. For example http://www.bbc.co.uk/programmes/b00fm04s and http://www.bbc.co.uk/eastenders/
    /// <see href="http://purl.org/ontology/po/microsite"></see></summary>
    let microsite = Namespaced_IRI.parse _namespace_name "microsite" |> NamespacedName

    /// <summary>
    /// Relates a programme to its news reader
    /// <see href="http://purl.org/ontology/po/news_reader"></see></summary>
    let news_reader =
        Namespaced_IRI.parse _namespace_name "news_reader" |> NamespacedName

    /// <summary>
    ///
    /// 		Associates a service to an outlet, e.g. Radio 4 to Radio 4 LW.
    ///
    /// <see href="http://purl.org/ontology/po/outlet"></see></summary>
    let outlet = Namespaced_IRI.parse _namespace_name "outlet" |> NamespacedName

    /// <summary>
    ///
    /// 		Relates a series to a series constituting it (eg. `Waking the dead').
    ///
    /// <see href="http://purl.org/ontology/po/parent_series"></see></summary>
    let parent_series =
        Namespaced_IRI.parse _namespace_name "parent_series" |> NamespacedName

    /// <summary>
    ///
    /// 		Relates a service to another service encapsulating it (eg. `BBC One' and `BBC One South')
    ///
    /// <see href="http://purl.org/ontology/po/parent_service"></see></summary>
    let parent_service =
        Namespaced_IRI.parse _namespace_name "parent_service" |> NamespacedName

    /// <summary>
    /// Relates a programme to one of its participants
    /// <see href="http://purl.org/ontology/po/participant"></see></summary>
    let participant =
        Namespaced_IRI.parse _namespace_name "participant" |> NamespacedName

    /// <summary>
    /// Relates a programme to an entertainer who performs a dramatic or musical work for audience
    /// <see href="http://purl.org/ontology/po/performer"></see></summary>
    let performer = Namespaced_IRI.parse _namespace_name "performer" |> NamespacedName
    /// <summary>
    ///
    ///         Relates a programme to a person
    ///
    /// <see href="http://purl.org/ontology/po/person"></see></summary>
    let person = Namespaced_IRI.parse _namespace_name "person" |> NamespacedName
    /// <summary>
    ///
    ///         Relates a programme to a place (e.g. `London')
    ///
    /// <see href="http://purl.org/ontology/po/place"></see></summary>
    let place = Namespaced_IRI.parse _namespace_name "place" |> NamespacedName
    /// <summary>
    /// The position of a particular series or episode within its containing programme. This property can also be used to give the position of an interval within the containing timeline.
    /// <see href="http://purl.org/ontology/po/position"></see></summary>
    let position = Namespaced_IRI.parse _namespace_name "position" |> NamespacedName
    /// <summary>
    /// Relates a programme to its producer - the manager of an event, show, or other work, usually the individual in charge of finance, personnel, and other non-artistic aspects in the development of commercials, plays, movies, and other works
    /// <see href="http://purl.org/ontology/po/producer"></see></summary>
    let producer = Namespaced_IRI.parse _namespace_name "producer" |> NamespacedName

    /// <summary>
    ///
    /// 		The schedule date of a broadcast event.
    ///
    /// <see href="http://purl.org/ontology/po/schedule_date"></see></summary>
    let schedule_date =
        Namespaced_IRI.parse _namespace_name "schedule_date" |> NamespacedName

    /// <summary>
    /// Associates a season to its constituent broadcasts
    /// <see href="http://purl.org/ontology/po/season_broadcast"></see></summary>
    let season_broadcast =
        Namespaced_IRI.parse _namespace_name "season_broadcast" |> NamespacedName

    /// <summary>
    ///
    /// 		Associates a brand or a series to a series constituting it.
    ///
    /// <see href="http://purl.org/ontology/po/series"></see></summary>
    let series = Namespaced_IRI.parse _namespace_name "series" |> NamespacedName
    /// <summary>
    ///
    /// 		Associate a brand, series or episode to the master brand service.
    ///
    /// <see href="http://purl.org/ontology/po/service"></see></summary>
    let service = Namespaced_IRI.parse _namespace_name "service" |> NamespacedName

    /// <summary>
    ///
    /// 		A short synopsis of a series, brand or episode.
    /// 		Sub-property of po:synopsis.
    ///
    /// <see href="http://purl.org/ontology/po/short_synopsis"></see></summary>
    let short_synopsis =
        Namespaced_IRI.parse _namespace_name "short_synopsis" |> NamespacedName

    /// <summary>
    ///
    /// 		The sound format of a particular version.
    ///
    /// <see href="http://purl.org/ontology/po/sound_format"></see></summary>
    let sound_format =
        Namespaced_IRI.parse _namespace_name "sound_format" |> NamespacedName

    /// <summary>
    ///
    ///         Relates a programme to a subject (e.g. `Easter')
    ///
    /// <see href="http://purl.org/ontology/po/subject"></see></summary>
    let subject = Namespaced_IRI.parse _namespace_name "subject" |> NamespacedName

    /// <summary>
    /// Language of the subtitles embedded in a particular version
    /// <see href="http://purl.org/ontology/po/subtitle_language"></see></summary>
    let subtitle_language =
        Namespaced_IRI.parse _namespace_name "subtitle_language" |> NamespacedName

    /// <summary>
    /// Associates a subtitle event to the corresponding text
    /// <see href="http://purl.org/ontology/po/text"></see></summary>
    let text = Namespaced_IRI.parse _namespace_name "text" |> NamespacedName
    /// <summary>
    /// Associates an episode's version or a version's segment with a temporal interval. This interval can be associated with a timeline, serving as an anchor for further temporal annotations, e.g. subtitles or played track
    /// <see href="http://purl.org/ontology/po/time"></see></summary>
    let time = Namespaced_IRI.parse _namespace_name "time" |> NamespacedName
    /// <summary>
    /// Associates a music segment with a track, as defined in MO
    /// <see href="http://purl.org/ontology/po/track"></see></summary>
    let track = Namespaced_IRI.parse _namespace_name "track" |> NamespacedName
    /// <summary>
    ///
    /// 		Associate an episode to a version of it.
    /// 		Different versions of a same episode can exist (shortened version, version
    /// 		designed for the hearing impaired, etc.).
    ///
    /// <see href="http://purl.org/ontology/po/version"></see></summary>
    let version = Namespaced_IRI.parse _namespace_name "version" |> NamespacedName
