namespace http.purl.org.ontology.po.slash

open DoxAletheia

module po =
    let _namespace_name = "http://purl.org/ontology/po/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/ontology/po/1.0"></see>
    /// </summary>
    let ``_1.0`` = _prefix "1.0"
    /// <summary>
    ///   <see href="http://purl.org/ontology/po/1.1"></see>
    /// </summary>
    let ``_1.1`` = _prefix "1.1"
    /// <summary>
    ///
    /// 		A version holding an audio description.
    ///
    /// <see href="http://purl.org/ontology/po/AudioDescribedVersion"></see></summary>
    let AudioDescribedVersion = _prefix "AudioDescribedVersion"
    /// <summary>
    ///
    /// 		A particular version of an episode.
    /// 		Such versions include shortened ones, audio described ones
    /// 		or ones that holds sign language.
    /// 		The version is associated to a timeline.
    ///
    /// <see href="http://purl.org/ontology/po/Version"></see></summary>
    let Version = _prefix "Version"
    /// <summary>
    ///
    /// 		A brand, e.g. `Top Gear'
    ///
    /// <see href="http://purl.org/ontology/po/Brand"></see></summary>
    let Brand = _prefix "Brand"
    /// <summary>
    ///
    /// 		A programme, can either be a brand, a series or an episode
    ///
    /// <see href="http://purl.org/ontology/po/Programme"></see></summary>
    let Programme = _prefix "Programme"
    /// <summary>
    ///
    /// 		A series, e.g. `Top Gear, first season'
    ///
    /// <see href="http://purl.org/ontology/po/Series"></see></summary>
    let Series = _prefix "Series"
    /// <summary>
    ///
    /// 		A particular episode, e.g. `Top Gear, first episode of the first series' or the film 'A Walk in the Sun' (http://www.bbc.co.uk/programmes/b00gfzdt)
    ///
    /// <see href="http://purl.org/ontology/po/Episode"></see></summary>
    let Episode = _prefix "Episode"
    /// <summary>
    ///
    ///         A particular clip, e.g. `Clip of Top Gear, first series'
    ///
    /// <see href="http://purl.org/ontology/po/Clip"></see></summary>
    let Clip = _prefix "Clip"
    /// <summary>
    ///
    /// 		A broadcast event.
    /// 		Subsumes the event concept defined in
    /// 		the Event ontology.
    /// 		A broadcast is associated with a service, and with a
    /// 		particular version of an episode.
    ///
    /// <see href="http://purl.org/ontology/po/Broadcast"></see></summary>
    let Broadcast = _prefix "Broadcast"
    /// <summary>
    ///
    /// 		An organization responsible of some broadcasting services.
    ///         It can hold a set of services and outlets.
    ///
    /// <see href="http://purl.org/ontology/po/Broadcaster"></see></summary>
    let Broadcaster = _prefix "Broadcaster"
    /// <summary>
    ///
    ///         A category provides a way of classifying a set of programmes. Such classifications
    ///         can be performed according to multiple dimensions and taxonomies, e.g. genre, format, places, people, subjects...
    ///
    /// <see href="http://purl.org/ontology/po/Category"></see></summary>
    let Category = _prefix "Category"
    /// <summary>
    ///
    ///         A physical channel on which a broadcast occurs.
    ///         A single outlet or service can be associated with multiple channels.
    ///         For example, Radio 4 LW broadcasts on Analogue Long Wave and on Digital
    ///         Satellite.
    ///
    /// <see href="http://purl.org/ontology/po/Channel"></see></summary>
    let Channel = _prefix "Channel"
    /// <summary>
    ///
    ///         A programme that can have versions, and as such can be broadcast or made available on-demand, e.g. a clip or an episode.
    ///
    /// <see href="http://purl.org/ontology/po/ProgrammeItem"></see></summary>
    let ProgrammeItem = _prefix "ProgrammeItem"
    /// <summary>
    ///
    /// 		Digital Audio Broadcasting
    ///
    /// <see href="http://purl.org/ontology/po/DAB"></see></summary>
    let DAB = _prefix "DAB"
    /// <summary>
    ///
    /// 		Digital Video Broadcasting
    ///
    /// <see href="http://purl.org/ontology/po/DVB"></see></summary>
    let DVB = _prefix "DVB"
    /// <summary>
    ///
    /// 		The FM broadcast band
    ///
    /// <see href="http://purl.org/ontology/po/FM"></see></summary>
    let FM = _prefix "FM"
    /// <summary>
    ///
    /// 		Specifies a broadcast as being the
    /// 		first one of a particular version.
    ///
    /// <see href="http://purl.org/ontology/po/FirstBroadcast"></see></summary>
    let FirstBroadcast = _prefix "FirstBroadcast"
    /// <summary>
    ///
    /// 		Specifies a broadcast as being a
    /// 		repeat.
    ///
    /// <see href="http://purl.org/ontology/po/RepeatBroadcast"></see></summary>
    let RepeatBroadcast = _prefix "RepeatBroadcast"
    /// <summary>
    ///
    ///         Anchor point for format taxonomies, similar to po:Genre for genre taxonomies.
    ///         Instances of this concept include documentaries, talk shows, animation, etc.
    ///
    /// <see href="http://purl.org/ontology/po/Format"></see></summary>
    let Format = _prefix "Format"
    /// <summary>
    ///
    ///         An anchor point for a programmes' genre taxonomy, e.g. 'Drama'/'Biographical'.
    ///
    /// <see href="http://purl.org/ontology/po/Genre"></see></summary>
    let Genre = _prefix "Genre"
    /// <summary>
    ///
    /// 		IP stream
    ///
    /// <see href="http://purl.org/ontology/po/IPStream"></see></summary>
    let IPStream = _prefix "IPStream"
    /// <summary>
    ///
    /// 		The AM broadcast band
    ///
    /// <see href="http://purl.org/ontology/po/LW"></see></summary>
    let LW = _prefix "LW"
    /// <summary>
    ///
    /// 		Radio services aiming at a local coverage.
    ///
    /// <see href="http://purl.org/ontology/po/LocalRadio"></see></summary>
    let LocalRadio = _prefix "LocalRadio"
    /// <summary>
    ///
    /// 		Services that use a radio medium.
    ///
    /// <see href="http://purl.org/ontology/po/Radio"></see></summary>
    let Radio = _prefix "Radio"
    /// <summary>
    ///
    /// 		Radio services aiming at a regional coverage.
    ///
    /// <see href="http://purl.org/ontology/po/RegionalRadio"></see></summary>
    let RegionalRadio = _prefix "RegionalRadio"
    /// <summary>
    ///
    /// 		Radio services aiming at a national coverage.
    ///
    /// <see href="http://purl.org/ontology/po/NationalRadio"></see></summary>
    let NationalRadio = _prefix "NationalRadio"
    /// <summary>
    ///
    /// 		Classification of an episode version's region corresponding to a musical track being played.
    ///
    /// <see href="http://purl.org/ontology/po/MusicSegment"></see></summary>
    let MusicSegment = _prefix "MusicSegment"
    /// <summary>
    ///
    /// 		Classification of an episode version's region, e.g. 'this track was played at that time'.
    ///
    /// <see href="http://purl.org/ontology/po/Segment"></see></summary>
    let Segment = _prefix "Segment"
    /// <summary>
    ///
    /// 		An `original' version, the legacy version of
    /// 		a particular episode.
    ///
    /// <see href="http://purl.org/ontology/po/OriginalVersion"></see></summary>
    let OriginalVersion = _prefix "OriginalVersion"
    /// <summary>
    ///
    /// 		A shortened version.
    ///
    /// <see href="http://purl.org/ontology/po/ShortenedVersion"></see></summary>
    let ShortenedVersion = _prefix "ShortenedVersion"
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
    let Outlet = _prefix "Outlet"
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
    let Service = _prefix "Service"
    /// <summary>
    /// A person
    /// <see href="http://purl.org/ontology/po/Person"></see></summary>
    let Person = _prefix "Person"
    /// <summary>
    /// A physical place
    /// <see href="http://purl.org/ontology/po/Place"></see></summary>
    let Place = _prefix "Place"
    /// <summary>
    ///
    /// 		Services that use a Web medium.
    ///
    /// <see href="http://purl.org/ontology/po/Web"></see></summary>
    let Web = _prefix "Web"
    /// <summary>
    ///
    /// 		Services that use a television medium.
    ///
    /// <see href="http://purl.org/ontology/po/TV"></see></summary>
    let TV = _prefix "TV"
    /// <summary>
    ///
    /// 		A season is a group of broadcasts.
    ///
    /// <see href="http://purl.org/ontology/po/Season"></see></summary>
    let Season = _prefix "Season"
    /// <summary>
    ///
    /// 		A version holding sign language.
    ///
    /// <see href="http://purl.org/ontology/po/SignedVersion"></see></summary>
    let SignedVersion = _prefix "SignedVersion"
    /// <summary>
    ///
    ///         Classification of an episode version's region holding speech content.
    ///
    /// <see href="http://purl.org/ontology/po/SpeechSegment"></see></summary>
    let SpeechSegment = _prefix "SpeechSegment"
    /// <summary>
    ///
    ///         Anchor point for subject taxonomies.
    ///
    /// <see href="http://purl.org/ontology/po/Subject"></see></summary>
    let Subject = _prefix "Subject"
    /// <summary>
    ///
    ///         Classification of an episode version's region corresponding to a subtitle being shown.
    ///
    /// <see href="http://purl.org/ontology/po/Subtitle"></see></summary>
    let Subtitle = _prefix "Subtitle"
    /// <summary>
    /// Relates a programmes to one of its actors - a person who plays the role of a character
    /// <see href="http://purl.org/ontology/po/actor"></see></summary>
    let actor = _prefix "actor"
    /// <summary>
    /// Relates a programmes to a person who is credited in it
    /// <see href="http://purl.org/ontology/po/credit"></see></summary>
    let credit = _prefix "credit"
    /// <summary>
    /// A television reporter who coordinates a programme
    /// <see href="http://purl.org/ontology/po/anchor"></see></summary>
    let anchor = _prefix "anchor"
    /// <summary>
    ///
    /// 		The aspect ration of a particular version.
    ///
    /// <see href="http://purl.org/ontology/po/aspect_ratio"></see></summary>
    let aspect_ratio = _prefix "aspect_ratio"
    /// <summary>
    /// Relates a programme to its author - the person who created the content
    /// <see href="http://purl.org/ontology/po/author"></see></summary>
    let author = _prefix "author"
    /// <summary>
    ///
    /// 		Relates a particular broadcast to the version being broadcasted.
    /// 		Sub-property of the event:factor one.
    ///
    /// <see href="http://purl.org/ontology/po/broadcast_of"></see></summary>
    let broadcast_of = _prefix "broadcast_of"
    /// <summary>
    ///
    /// 		Relates a particular broadcast to the service or outlet on which it was.
    /// 		Sub-property of the event:factor one.
    ///
    /// <see href="http://purl.org/ontology/po/broadcast_on"></see></summary>
    let broadcast_on = _prefix "broadcast_on"
    /// <summary>
    /// Deprecated property, left here for historical reasons
    /// <see href="http://purl.org/ontology/po/broadcasted_on"></see></summary>
    let broadcasted_on = _prefix "broadcasted_on"
    /// <summary>
    ///
    /// 		Associates a service to a broadcaster
    ///
    /// <see href="http://purl.org/ontology/po/broadcaster"></see></summary>
    let broadcaster = _prefix "broadcaster"
    /// <summary>
    ///
    ///         Relates a programme to a particular category, e.g. genre, format, place...
    ///
    /// <see href="http://purl.org/ontology/po/category"></see></summary>
    let category = _prefix "category"
    /// <summary>
    ///
    ///         Associates a service to a channel, e.g. Radio 4 LW to Radio 4 LW on Analogue Long Wave.
    ///
    /// <see href="http://purl.org/ontology/po/channel"></see></summary>
    let channel = _prefix "channel"
    /// <summary>
    ///
    ///         Associates a brand, a series or an episode to a clip.
    ///
    /// <see href="http://purl.org/ontology/po/clip"></see></summary>
    let clip = _prefix "clip"
    /// <summary>
    /// Relates a programme to one of its commentators
    /// <see href="http://purl.org/ontology/po/commentator"></see></summary>
    let commentator = _prefix "commentator"
    /// <summary>
    /// Relates a programme to its supervisor. Generally refers to the person responsible for all audience-visible components of a program, film, or show, whereas the producer is responsible for the financial and other behind-the-scenes aspects. A director's duties might also include casting, script editing, shot selection, shot composition, and editing
    /// <see href="http://purl.org/ontology/po/director"></see></summary>
    let director = _prefix "director"
    /// <summary>
    /// The duration of a version, in seconds.
    /// <see href="http://purl.org/ontology/po/duration"></see></summary>
    let duration = _prefix "duration"
    /// <summary>
    ///
    /// 		Associates a brand or a series to an episode constituting it.
    ///
    /// <see href="http://purl.org/ontology/po/episode"></see></summary>
    let episode = _prefix "episode"
    /// <summary>
    /// Relates a programme to its executive producer - a producer who is not involved in any technical aspects of the making process, but who is still responsible for the overall production. Typically an executive producer handles business and legal issues
    /// <see href="http://purl.org/ontology/po/executive_producer"></see></summary>
    let executive_producer = _prefix "executive_producer"
    /// <summary>
    ///
    /// 		Relates a programme to a particular format (eg. `Animation', `Documentary', etc.).
    ///
    /// <see href="http://purl.org/ontology/po/format"></see></summary>
    let format = _prefix "format"
    /// <summary>
    /// Associates a channel to its frequency
    /// <see href="http://purl.org/ontology/po/frequency"></see></summary>
    let frequency = _prefix "frequency"
    /// <summary>
    ///
    /// 		Relates a programme to a particular genre.
    ///
    /// <see href="http://purl.org/ontology/po/genre"></see></summary>
    let genre = _prefix "genre"
    /// <summary>
    ///
    /// 		Associates a service to a geographic location,
    /// 		aiming at capturing what this service aims at covering.
    ///
    /// <see href="http://purl.org/ontology/po/location"></see></summary>
    let location = _prefix "location"
    /// <summary>
    ///
    /// 		A long synopsis of a series, brand or episode.
    /// 		Sub-property of po:synopsis.
    ///
    /// <see href="http://purl.org/ontology/po/long_synopsis"></see></summary>
    let long_synopsis = _prefix "long_synopsis"
    /// <summary>
    ///
    /// 		The synopsis of a series, brand or episode.
    ///
    /// <see href="http://purl.org/ontology/po/synopsis"></see></summary>
    let synopsis = _prefix "synopsis"
    /// <summary>
    /// Associates a programme with its masterbrand (its commissioner)
    /// <see href="http://purl.org/ontology/po/masterbrand"></see></summary>
    let masterbrand = _prefix "masterbrand"
    /// <summary>
    ///
    /// 		A medium synopsis of a series, brand or episode.
    /// 		Sub-property of po:synopsis.
    ///
    /// <see href="http://purl.org/ontology/po/medium_synopsis"></see></summary>
    let medium_synopsis = _prefix "medium_synopsis"
    /// <summary>
    /// Associates a programme to its microsite. For example http://www.bbc.co.uk/programmes/b00fm04s and http://www.bbc.co.uk/eastenders/
    /// <see href="http://purl.org/ontology/po/microsite"></see></summary>
    let microsite = _prefix "microsite"
    /// <summary>
    /// Relates a programme to its news reader
    /// <see href="http://purl.org/ontology/po/news_reader"></see></summary>
    let news_reader = _prefix "news_reader"
    /// <summary>
    ///
    /// 		Associates a service to an outlet, e.g. Radio 4 to Radio 4 LW.
    ///
    /// <see href="http://purl.org/ontology/po/outlet"></see></summary>
    let outlet = _prefix "outlet"
    /// <summary>
    ///
    /// 		Relates a series to a series constituting it (eg. `Waking the dead').
    ///
    /// <see href="http://purl.org/ontology/po/parent_series"></see></summary>
    let parent_series = _prefix "parent_series"
    /// <summary>
    ///
    /// 		Relates a service to another service encapsulating it (eg. `BBC One' and `BBC One South')
    ///
    /// <see href="http://purl.org/ontology/po/parent_service"></see></summary>
    let parent_service = _prefix "parent_service"
    /// <summary>
    /// Relates a programme to one of its participants
    /// <see href="http://purl.org/ontology/po/participant"></see></summary>
    let participant = _prefix "participant"
    /// <summary>
    /// Relates a programme to an entertainer who performs a dramatic or musical work for audience
    /// <see href="http://purl.org/ontology/po/performer"></see></summary>
    let performer = _prefix "performer"
    /// <summary>
    ///
    ///         Relates a programme to a person
    ///
    /// <see href="http://purl.org/ontology/po/person"></see></summary>
    let person = _prefix "person"
    /// <summary>
    ///
    ///         Relates a programme to a place (e.g. `London')
    ///
    /// <see href="http://purl.org/ontology/po/place"></see></summary>
    let place = _prefix "place"
    /// <summary>
    /// The position of a particular series or episode within its containing programme. This property can also be used to give the position of an interval within the containing timeline.
    /// <see href="http://purl.org/ontology/po/position"></see></summary>
    let position = _prefix "position"
    /// <summary>
    /// Relates a programme to its producer - the manager of an event, show, or other work, usually the individual in charge of finance, personnel, and other non-artistic aspects in the development of commercials, plays, movies, and other works
    /// <see href="http://purl.org/ontology/po/producer"></see></summary>
    let producer = _prefix "producer"
    /// <summary>
    ///
    /// 		The schedule date of a broadcast event.
    ///
    /// <see href="http://purl.org/ontology/po/schedule_date"></see></summary>
    let schedule_date = _prefix "schedule_date"
    /// <summary>
    /// Associates a season to its constituent broadcasts
    /// <see href="http://purl.org/ontology/po/season_broadcast"></see></summary>
    let season_broadcast = _prefix "season_broadcast"
    /// <summary>
    ///
    /// 		Associates a brand or a series to a series constituting it.
    ///
    /// <see href="http://purl.org/ontology/po/series"></see></summary>
    let series = _prefix "series"
    /// <summary>
    ///
    /// 		Associate a brand, series or episode to the master brand service.
    ///
    /// <see href="http://purl.org/ontology/po/service"></see></summary>
    let service = _prefix "service"
    /// <summary>
    ///
    /// 		A short synopsis of a series, brand or episode.
    /// 		Sub-property of po:synopsis.
    ///
    /// <see href="http://purl.org/ontology/po/short_synopsis"></see></summary>
    let short_synopsis = _prefix "short_synopsis"
    /// <summary>
    ///
    /// 		The sound format of a particular version.
    ///
    /// <see href="http://purl.org/ontology/po/sound_format"></see></summary>
    let sound_format = _prefix "sound_format"
    /// <summary>
    ///
    ///         Relates a programme to a subject (e.g. `Easter')
    ///
    /// <see href="http://purl.org/ontology/po/subject"></see></summary>
    let subject = _prefix "subject"
    /// <summary>
    /// Language of the subtitles embedded in a particular version
    /// <see href="http://purl.org/ontology/po/subtitle_language"></see></summary>
    let subtitle_language = _prefix "subtitle_language"
    /// <summary>
    /// Associates a subtitle event to the corresponding text
    /// <see href="http://purl.org/ontology/po/text"></see></summary>
    let text = _prefix "text"
    /// <summary>
    /// Associates an episode's version or a version's segment with a temporal interval. This interval can be associated with a timeline, serving as an anchor for further temporal annotations, e.g. subtitles or played track
    /// <see href="http://purl.org/ontology/po/time"></see></summary>
    let time = _prefix "time"
    /// <summary>
    /// Associates a music segment with a track, as defined in MO
    /// <see href="http://purl.org/ontology/po/track"></see></summary>
    let track = _prefix "track"
    /// <summary>
    ///
    /// 		Associate an episode to a version of it.
    /// 		Different versions of a same episode can exist (shortened version, version
    /// 		designed for the hearing impaired, etc.).
    ///
    /// <see href="http://purl.org/ontology/po/version"></see></summary>
    let version = _prefix "version"
