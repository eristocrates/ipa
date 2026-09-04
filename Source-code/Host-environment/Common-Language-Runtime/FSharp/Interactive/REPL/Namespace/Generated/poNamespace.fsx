#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module po =
    let _prefixId = PrefixId.fromNamespaceLabel "http://purl.org/ontology/po/" "po"
    let _namespaceIri = _prefixId.prefix ""
    let ``_1.0`` = _prefixId.prefix "1.0"
    let ``_1.1`` = _prefixId.prefix "1.1"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : AudioDescribedVersion^^xsd:string</para>
    ///   <para>rdfs:comment :
    /// 		A version holding an audio description.
    /// 	^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/po/AudioDescribedVersion">po:AudioDescribedVersion</a>
    /// </summary>
    let AudioDescribedVersion = _prefixId.prefix "AudioDescribedVersion"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Brand^^xsd:string</para>
    ///   <para>rdfs:comment :
    /// 		A brand, e.g. `Top Gear'
    /// 	^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/po/Brand">po:Brand</a>
    /// </summary>
    let Brand = _prefixId.prefix "Brand"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Broadcast^^xsd:string</para>
    ///   <para>rdfs:comment :
    /// 		A broadcast event.
    /// 		Subsumes the event concept defined in
    /// 		the Event ontology.
    /// 		A broadcast is associated with a service, and with a
    /// 		particular version of an episode.
    /// 	^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/po/Broadcast">po:Broadcast</a>
    /// </summary>
    let Broadcast = _prefixId.prefix "Broadcast"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Broadcaster^^xsd:string</para>
    ///   <para>rdfs:comment :
    /// 		An organization responsible of some broadcasting services.
    ///         It can hold a set of services and outlets.
    /// 	^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/po/Broadcaster">po:Broadcaster</a>
    /// </summary>
    let Broadcaster = _prefixId.prefix "Broadcaster"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : Category^^xsd:string</para>
    ///   <para>rdfs:comment :
    ///         A category provides a way of classifying a set of programmes. Such classifications
    ///         can be performed according to multiple dimensions and taxonomies, e.g. genre, format, places, people, subjects...
    ///     ^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/po/Category">po:Category</a>
    /// </summary>
    let Category = _prefixId.prefix "Category"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : Channel^^xsd:string</para>
    ///   <para>rdfs:comment :
    ///         A physical channel on which a broadcast occurs.
    ///         A single outlet or service can be associated with multiple channels.
    ///         For example, Radio 4 LW broadcasts on Analogue Long Wave and on Digital
    ///         Satellite.
    ///     ^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/po/Channel">po:Channel</a>
    /// </summary>
    let Channel = _prefixId.prefix "Channel"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : Clip^^xsd:string</para>
    ///   <para>rdfs:comment :
    ///         A particular clip, e.g. `Clip of Top Gear, first series'
    ///     ^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/po/Clip">po:Clip</a>
    /// </summary>
    let Clip = _prefixId.prefix "Clip"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : DAB^^xsd:string</para>
    ///   <para>rdfs:comment :
    /// 		Digital Audio Broadcasting
    /// 	^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/po/DAB">po:DAB</a>
    /// </summary>
    let DAB = _prefixId.prefix "DAB"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : DVB^^xsd:string</para>
    ///   <para>rdfs:comment :
    /// 		Digital Video Broadcasting
    /// 	^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/po/DVB">po:DVB</a>
    /// </summary>
    let DVB = _prefixId.prefix "DVB"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Episode^^xsd:string</para>
    ///   <para>rdfs:comment :
    /// 		A particular episode, e.g. `Top Gear, first episode of the first series' or the film 'A Walk in the Sun' (http://www.bbc.co.uk/programmes/b00gfzdt)
    /// 	^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/po/Episode">po:Episode</a>
    /// </summary>
    let Episode = _prefixId.prefix "Episode"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : FM^^xsd:string</para>
    ///   <para>rdfs:comment :
    /// 		The FM broadcast band
    /// 	^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/po/FM">po:FM</a>
    /// </summary>
    let FM = _prefixId.prefix "FM"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : FirstBroadcast^^xsd:string</para>
    ///   <para>rdfs:comment :
    /// 		Specifies a broadcast as being the
    /// 		first one of a particular version.
    /// 	 ^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/po/FirstBroadcast">po:FirstBroadcast</a>
    /// </summary>
    let FirstBroadcast = _prefixId.prefix "FirstBroadcast"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : Format^^xsd:string</para>
    ///   <para>rdfs:comment :
    ///         Anchor point for format taxonomies, similar to po:Genre for genre taxonomies.
    ///         Instances of this concept include documentaries, talk shows, animation, etc.
    ///     ^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/po/Format">po:Format</a>
    /// </summary>
    let Format = _prefixId.prefix "Format"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : Genre^^xsd:string</para>
    ///   <para>rdfs:comment :
    ///         An anchor point for a programmes' genre taxonomy, e.g. 'Drama'/'Biographical'.
    /// 	^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/po/Genre">po:Genre</a>
    /// </summary>
    let Genre = _prefixId.prefix "Genre"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : IP stream^^xsd:string</para>
    ///   <para>rdfs:comment :
    /// 		IP stream
    /// 	^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/po/IPStream">po:IPStream</a>
    /// </summary>
    let IPStream = _prefixId.prefix "IPStream"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : AM^^xsd:string</para>
    ///   <para>rdfs:comment :
    /// 		The AM broadcast band
    /// 	^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/po/LW">po:LW</a>
    /// </summary>
    let LW = _prefixId.prefix "LW"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : LocalRadio^^xsd:string</para>
    ///   <para>rdfs:comment :
    /// 		Radio services aiming at a local coverage.
    /// 	^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/po/LocalRadio">po:LocalRadio</a>
    /// </summary>
    let LocalRadio = _prefixId.prefix "LocalRadio"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : MusicSegment^^xsd:string</para>
    ///   <para>rdfs:comment :
    /// 		Classification of an episode version's region corresponding to a musical track being played.
    /// 	^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/po/MusicSegment">po:MusicSegment</a>
    /// </summary>
    let MusicSegment = _prefixId.prefix "MusicSegment"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : NationalRadio^^xsd:string</para>
    ///   <para>rdfs:comment :
    /// 		Radio services aiming at a national coverage.
    /// 	^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/po/NationalRadio">po:NationalRadio</a>
    /// </summary>
    let NationalRadio = _prefixId.prefix "NationalRadio"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : OriginalVersion^^xsd:string</para>
    ///   <para>rdfs:comment :
    /// 		An `original' version, the legacy version of
    /// 		a particular episode.
    /// 	^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/po/OriginalVersion">po:OriginalVersion</a>
    /// </summary>
    let OriginalVersion = _prefixId.prefix "OriginalVersion"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : Outlet^^xsd:string</para>
    ///   <para>rdfs:comment :
    ///         Outlet of a particular service, e.g. Radio 4 LW and FM for Radio 4.
    ///         Outlets are services which do not have variations.
    ///         The criterion for an outlet is its timeline.
    ///         For example, Radio 4 LW broadcasts on Analogue Long Wave, but also on Digital Satellite.
    ///         It corresponds to just one outlet, as they are simulcasts.
    ///         The two physical channels for broadcasts correspond to po:Channel.
    ///     ^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/po/Outlet">po:Outlet</a>
    /// </summary>
    let Outlet = _prefixId.prefix "Outlet"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : Person^^xsd:string</para>
    ///   <para>rdfs:comment : A person^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/po/Person">po:Person</a>
    /// </summary>
    let Person = _prefixId.prefix "Person"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : Place^^xsd:string</para>
    ///   <para>rdfs:comment : A physical place^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/po/Place">po:Place</a>
    /// </summary>
    let Place = _prefixId.prefix "Place"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Programme^^xsd:string</para>
    ///   <para>rdfs:comment :
    /// 		A programme, can either be a brand, a series or an episode
    /// 	^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/po/Programme">po:Programme</a>
    /// </summary>
    let Programme = _prefixId.prefix "Programme"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : ProgrammeItem^^xsd:string</para>
    ///   <para>rdfs:comment :
    ///         A programme that can have versions, and as such can be broadcast or made available on-demand, e.g. a clip or an episode.
    ///     ^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/po/ProgrammeItem">po:ProgrammeItem</a>
    /// </summary>
    let ProgrammeItem = _prefixId.prefix "ProgrammeItem"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : Radio^^xsd:string</para>
    ///   <para>rdfs:comment :
    /// 		Services that use a radio medium.
    /// 	^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/po/Radio">po:Radio</a>
    /// </summary>
    let Radio = _prefixId.prefix "Radio"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : RegionalRadio^^xsd:string</para>
    ///   <para>rdfs:comment :
    /// 		Radio services aiming at a regional coverage.
    /// 	^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/po/RegionalRadio">po:RegionalRadio</a>
    /// </summary>
    let RegionalRadio = _prefixId.prefix "RegionalRadio"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : Repeat^^xsd:string</para>
    ///   <para>rdfs:comment :
    /// 		Specifies a broadcast as being a
    /// 		repeat.
    /// 	^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/po/RepeatBroadcast">po:RepeatBroadcast</a>
    /// </summary>
    let RepeatBroadcast = _prefixId.prefix "RepeatBroadcast"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : Season^^xsd:string</para>
    ///   <para>rdfs:comment :
    /// 		A season is a group of broadcasts.
    /// 	^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/po/Season">po:Season</a>
    /// </summary>
    let Season = _prefixId.prefix "Season"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : Segment^^xsd:string</para>
    ///   <para>rdfs:comment :
    /// 		Classification of an episode version's region, e.g. 'this track was played at that time'.
    /// 	^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/po/Segment">po:Segment</a>
    /// </summary>
    let Segment = _prefixId.prefix "Segment"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Series^^xsd:string</para>
    ///   <para>rdfs:comment :
    /// 		A series, e.g. `Top Gear, first season'
    /// 	^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/po/Series">po:Series</a>
    /// </summary>
    let Series = _prefixId.prefix "Series"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Service^^xsd:string</para>
    ///   <para>rdfs:comment :
    ///         A broadcasting service.
    /// 		Instances of this concept include BBC Radio Wales, BBC Radio 4, BBC News, etc.
    ///         A service is a collection of outlets which contain common material, but with some variations, e.g. by
    ///         region.
    ///         Hence, a service may have multiple outlets (po:Outlet), e.g. BBC Radio 4 has BBC Radio 4 LW and BBC Radio 4 FM.
    ///         A hierarchy of services types is defined within this ontology, e.g. radio and TV.
    ///         A service that is a master brand only (a service that only commissions programmes, e.g. BBC Switch) should
    ///         be an instance of the top-level po:Service.
    /// 	^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/po/Service">po:Service</a>
    /// </summary>
    let Service = _prefixId.prefix "Service"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : ShortenedVersion^^xsd:string</para>
    ///   <para>rdfs:comment :
    /// 		A shortened version.
    /// 	^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/po/ShortenedVersion">po:ShortenedVersion</a>
    /// </summary>
    let ShortenedVersion = _prefixId.prefix "ShortenedVersion"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : SignLanguage^^xsd:string</para>
    ///   <para>rdfs:comment :
    /// 		A version holding sign language.
    /// 	^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/po/SignedVersion">po:SignedVersion</a>
    /// </summary>
    let SignedVersion = _prefixId.prefix "SignedVersion"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:comment :
    ///         Classification of an episode version's region holding speech content.
    ///     ^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/po/SpeechSegment">po:SpeechSegment</a>
    /// </summary>
    let SpeechSegment = _prefixId.prefix "SpeechSegment"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : Subject^^xsd:string</para>
    ///   <para>rdfs:comment :
    ///         Anchor point for subject taxonomies.
    ///     ^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/po/Subject">po:Subject</a>
    /// </summary>
    let Subject = _prefixId.prefix "Subject"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : Subtitle^^xsd:string</para>
    ///   <para>rdfs:comment :
    ///         Classification of an episode version's region corresponding to a subtitle being shown.
    ///     ^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/po/Subtitle">po:Subtitle</a>
    /// </summary>
    let Subtitle = _prefixId.prefix "Subtitle"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : TV^^xsd:string</para>
    ///   <para>rdfs:comment :
    /// 		Services that use a television medium.
    /// 	^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/po/TV">po:TV</a>
    /// </summary>
    let TV = _prefixId.prefix "TV"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Version^^xsd:string</para>
    ///   <para>rdfs:comment :
    /// 		A particular version of an episode.
    /// 		Such versions include shortened ones, audio described ones
    /// 		or ones that holds sign language.
    /// 		The version is associated to a timeline.
    /// 	^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/po/Version">po:Version</a>
    /// </summary>
    let Version = _prefixId.prefix "Version"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : Web^^xsd:string</para>
    ///   <para>rdfs:comment :
    /// 		Services that use a Web medium.
    /// 	^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/po/Web">po:Web</a>
    /// </summary>
    let Web = _prefixId.prefix "Web"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : actor^^xsd:string</para>
    ///   <para>rdfs:comment : Relates a programmes to one of its actors - a person who plays the role of a character^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/po/actor">po:actor</a>
    /// </summary>
    let actor = _prefixId.prefix "actor"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : anchor^^xsd:string</para>
    ///   <para>rdfs:comment : A television reporter who coordinates a programme^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/po/anchor">po:anchor</a>
    /// </summary>
    let anchor = _prefixId.prefix "anchor"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : aspect ratio^^xsd:string</para>
    ///   <para>rdfs:comment :
    /// 		The aspect ration of a particular version.
    /// 	^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/po/aspect_ratio">po:aspect_ratio</a>
    /// </summary>
    let aspect_ratio = _prefixId.prefix "aspect_ratio"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : author^^xsd:string</para>
    ///   <para>rdfs:comment : Relates a programme to its author - the person who created the content^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/po/author">po:author</a>
    /// </summary>
    let author = _prefixId.prefix "author"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : broadcast of^^xsd:string</para>
    ///   <para>rdfs:comment :
    /// 		Relates a particular broadcast to the version being broadcasted.
    /// 		Sub-property of the event:factor one.
    /// 	^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/po/broadcast_of">po:broadcast_of</a>
    /// </summary>
    let broadcast_of = _prefixId.prefix "broadcast_of"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : broadcast on^^xsd:string</para>
    ///   <para>rdfs:comment :
    /// 		Relates a particular broadcast to the service or outlet on which it was.
    /// 		Sub-property of the event:factor one.
    /// 	^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/po/broadcast_on">po:broadcast_on</a>
    /// </summary>
    let broadcast_on = _prefixId.prefix "broadcast_on"
    /// <summary>
    ///   <para>rdfs:comment : Deprecated property, left here for historical reasons^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/po/broadcasted_on">po:broadcasted_on</a>
    /// </summary>
    let broadcasted_on = _prefixId.prefix "broadcasted_on"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : broadcaster^^xsd:string</para>
    ///   <para>rdfs:comment :
    /// 		Associates a service to a broadcaster
    /// 	^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/po/broadcaster">po:broadcaster</a>
    /// </summary>
    let broadcaster = _prefixId.prefix "broadcaster"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : category^^xsd:string</para>
    ///   <para>rdfs:comment :
    ///         Relates a programme to a particular category, e.g. genre, format, place...
    ///     ^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/po/category">po:category</a>
    /// </summary>
    let category = _prefixId.prefix "category"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : channel^^xsd:string</para>
    ///   <para>rdfs:comment :
    ///         Associates a service to a channel, e.g. Radio 4 LW to Radio 4 LW on Analogue Long Wave.
    ///     ^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/po/channel">po:channel</a>
    /// </summary>
    let channel = _prefixId.prefix "channel"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : clip^^xsd:string</para>
    ///   <para>rdfs:comment :
    ///         Associates a brand, a series or an episode to a clip.
    ///     ^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/po/clip">po:clip</a>
    /// </summary>
    let clip = _prefixId.prefix "clip"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : commentator^^xsd:string</para>
    ///   <para>rdfs:comment : Relates a programme to one of its commentators^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/po/commentator">po:commentator</a>
    /// </summary>
    let commentator = _prefixId.prefix "commentator"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : credit^^xsd:string</para>
    ///   <para>rdfs:comment : Relates a programmes to a person who is credited in it^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/po/credit">po:credit</a>
    /// </summary>
    let credit = _prefixId.prefix "credit"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : director^^xsd:string</para>
    ///   <para>rdfs:comment : Relates a programme to its supervisor. Generally refers to the person responsible for all audience-visible components of a program, film, or show, whereas the producer is responsible for the financial and other behind-the-scenes aspects. A director's duties might also include casting, script editing, shot selection, shot composition, and editing^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/po/director">po:director</a>
    /// </summary>
    let director = _prefixId.prefix "director"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : duration^^xsd:string</para>
    ///   <para>rdfs:comment : The duration of a version, in seconds.^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/po/duration">po:duration</a>
    /// </summary>
    let duration = _prefixId.prefix "duration"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : episode^^xsd:string</para>
    ///   <para>rdfs:comment :
    /// 		Associates a brand or a series to an episode constituting it.
    /// 	^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/po/episode">po:episode</a>
    /// </summary>
    let episode = _prefixId.prefix "episode"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : executive producer^^xsd:string</para>
    ///   <para>rdfs:comment : Relates a programme to its executive producer - a producer who is not involved in any technical aspects of the making process, but who is still responsible for the overall production. Typically an executive producer handles business and legal issues^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/po/executive_producer">po:executive_producer</a>
    /// </summary>
    let executive_producer = _prefixId.prefix "executive_producer"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : format^^xsd:string</para>
    ///   <para>rdfs:comment :
    /// 		Relates a programme to a particular format (eg. `Animation', `Documentary', etc.).
    /// 	^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/po/format">po:format</a>
    /// </summary>
    let format = _prefixId.prefix "format"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : frequency^^xsd:string</para>
    ///   <para>rdfs:comment : Associates a channel to its frequency^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/po/frequency">po:frequency</a>
    /// </summary>
    let frequency = _prefixId.prefix "frequency"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : genre^^xsd:string</para>
    ///   <para>rdfs:comment :
    /// 		Relates a programme to a particular genre.
    /// 	^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/po/genre">po:genre</a>
    /// </summary>
    let genre = _prefixId.prefix "genre"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : location^^xsd:string</para>
    ///   <para>rdfs:comment :
    /// 		Associates a service to a geographic location,
    /// 		aiming at capturing what this service aims at covering.
    /// 	^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/po/location">po:location</a>
    /// </summary>
    let location = _prefixId.prefix "location"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : long synopsis^^xsd:string</para>
    ///   <para>rdfs:comment :
    /// 		A long synopsis of a series, brand or episode.
    /// 		Sub-property of po:synopsis.
    /// 	^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/po/long_synopsis">po:long_synopsis</a>
    /// </summary>
    let long_synopsis = _prefixId.prefix "long_synopsis"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : masterbrand^^xsd:string</para>
    ///   <para>rdfs:comment : Associates a programme with its masterbrand (its commissioner)^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/po/masterbrand">po:masterbrand</a>
    /// </summary>
    let masterbrand = _prefixId.prefix "masterbrand"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : medium synopsis^^xsd:string</para>
    ///   <para>rdfs:comment :
    /// 		A medium synopsis of a series, brand or episode.
    /// 		Sub-property of po:synopsis.
    /// 	^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/po/medium_synopsis">po:medium_synopsis</a>
    /// </summary>
    let medium_synopsis = _prefixId.prefix "medium_synopsis"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : microsite^^xsd:string</para>
    ///   <para>rdfs:comment : Associates a programme to its microsite. For example http://www.bbc.co.uk/programmes/b00fm04s and http://www.bbc.co.uk/eastenders/^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/po/microsite">po:microsite</a>
    /// </summary>
    let microsite = _prefixId.prefix "microsite"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : news reader^^xsd:string</para>
    ///   <para>rdfs:comment : Relates a programme to its news reader^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/po/news_reader">po:news_reader</a>
    /// </summary>
    let news_reader = _prefixId.prefix "news_reader"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : outlet^^xsd:string</para>
    ///   <para>rdfs:comment :
    /// 		Associates a service to an outlet, e.g. Radio 4 to Radio 4 LW.
    /// 	^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/po/outlet">po:outlet</a>
    /// </summary>
    let outlet = _prefixId.prefix "outlet"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : parent series^^xsd:string</para>
    ///   <para>rdfs:comment :
    /// 		Relates a series to a series constituting it (eg. `Waking the dead').
    /// 	^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/po/parent_series">po:parent_series</a>
    /// </summary>
    let parent_series = _prefixId.prefix "parent_series"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : parent service^^xsd:string</para>
    ///   <para>rdfs:comment :
    /// 		Relates a service to another service encapsulating it (eg. `BBC One' and `BBC One South')
    /// 	^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/po/parent_service">po:parent_service</a>
    /// </summary>
    let parent_service = _prefixId.prefix "parent_service"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : participant^^xsd:string</para>
    ///   <para>rdfs:comment : Relates a programme to one of its participants^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/po/participant">po:participant</a>
    /// </summary>
    let participant = _prefixId.prefix "participant"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : performer^^xsd:string</para>
    ///   <para>rdfs:comment : Relates a programme to an entertainer who performs a dramatic or musical work for audience^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/po/performer">po:performer</a>
    /// </summary>
    let performer = _prefixId.prefix "performer"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : person^^xsd:string</para>
    ///   <para>rdfs:comment :
    ///         Relates a programme to a person
    ///     ^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/po/person">po:person</a>
    /// </summary>
    let person = _prefixId.prefix "person"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : place^^xsd:string</para>
    ///   <para>rdfs:comment :
    ///         Relates a programme to a place (e.g. `London')
    ///     ^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/po/place">po:place</a>
    /// </summary>
    let place = _prefixId.prefix "place"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : position^^xsd:string</para>
    ///   <para>rdfs:comment : The position of a particular series or episode within its containing programme. This property can also be used to give the position of an interval within the containing timeline.^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/po/position">po:position</a>
    /// </summary>
    let position = _prefixId.prefix "position"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : producer^^xsd:string</para>
    ///   <para>rdfs:comment : Relates a programme to its producer - the manager of an event, show, or other work, usually the individual in charge of finance, personnel, and other non-artistic aspects in the development of commercials, plays, movies, and other works^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/po/producer">po:producer</a>
    /// </summary>
    let producer = _prefixId.prefix "producer"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : schedule date^^xsd:string</para>
    ///   <para>rdfs:comment :
    /// 		The schedule date of a broadcast event.
    /// 	^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/po/schedule_date">po:schedule_date</a>
    /// </summary>
    let schedule_date = _prefixId.prefix "schedule_date"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : broadcast^^xsd:string</para>
    ///   <para>rdfs:comment : Associates a season to its constituent broadcasts^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/po/season_broadcast">po:season_broadcast</a>
    /// </summary>
    let season_broadcast = _prefixId.prefix "season_broadcast"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : series^^xsd:string</para>
    ///   <para>rdfs:comment :
    /// 		Associates a brand or a series to a series constituting it.
    /// 	^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/po/series">po:series</a>
    /// </summary>
    let series = _prefixId.prefix "series"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : service^^xsd:string</para>
    ///   <para>rdfs:comment :
    /// 		Associate a brand, series or episode to the master brand service.
    /// 	^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/po/service">po:service</a>
    /// </summary>
    let service = _prefixId.prefix "service"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : short synopsis^^xsd:string</para>
    ///   <para>rdfs:comment :
    /// 		A short synopsis of a series, brand or episode.
    /// 		Sub-property of po:synopsis.
    /// 	^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/po/short_synopsis">po:short_synopsis</a>
    /// </summary>
    let short_synopsis = _prefixId.prefix "short_synopsis"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : sound format^^xsd:string</para>
    ///   <para>rdfs:comment :
    /// 		The sound format of a particular version.
    /// 	^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/po/sound_format">po:sound_format</a>
    /// </summary>
    let sound_format = _prefixId.prefix "sound_format"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : subject^^xsd:string</para>
    ///   <para>rdfs:comment :
    ///         Relates a programme to a subject (e.g. `Easter')
    ///     ^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/po/subject">po:subject</a>
    /// </summary>
    let subject = _prefixId.prefix "subject"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : subtitle language^^xsd:string</para>
    ///   <para>rdfs:comment : Language of the subtitles embedded in a particular version^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/po/subtitle_language">po:subtitle_language</a>
    /// </summary>
    let subtitle_language = _prefixId.prefix "subtitle_language"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : synopsis^^xsd:string</para>
    ///   <para>rdfs:comment :
    /// 		The synopsis of a series, brand or episode.
    /// 	^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/po/synopsis">po:synopsis</a>
    /// </summary>
    let synopsis = _prefixId.prefix "synopsis"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : text^^xsd:string</para>
    ///   <para>rdfs:comment : Associates a subtitle event to the corresponding text^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/po/text">po:text</a>
    /// </summary>
    let text = _prefixId.prefix "text"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : time^^xsd:string</para>
    ///   <para>rdfs:comment : Associates an episode's version or a version's segment with a temporal interval. This interval can be associated with a timeline, serving as an anchor for further temporal annotations, e.g. subtitles or played track^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/po/time">po:time</a>
    /// </summary>
    let time = _prefixId.prefix "time"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : track^^xsd:string</para>
    ///   <para>rdfs:comment : Associates a music segment with a track, as defined in MO^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/po/track">po:track</a>
    /// </summary>
    let track = _prefixId.prefix "track"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : version^^xsd:string</para>
    ///   <para>rdfs:comment :
    /// 		Associate an episode to a version of it.
    /// 		Different versions of a same episode can exist (shortened version, version
    /// 		designed for the hearing impaired, etc.).
    /// 	^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/po/version">po:version</a>
    /// </summary>
    let version = _prefixId.prefix "version"
