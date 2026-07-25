namespace http.purl.org.ontology.po.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module po =
    let _namespace_iri = Namespace_Iri po |> NamespaceIRI
    /// <summary>
    ///   <para>po:Programme</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>
    /// 		A programme, can either be a brand, a series or an episode
    /// 	</para>
    /// labels<para>Programme</para></remarks>
    /// <seealso href="http://purl.org/ontology/po/Programme">http://purl.org/ontology/po/Programme</seealso>
    let Programme = Prefixed_Name(po, "Programme") |> PrefixedName
    /// <summary>
    ///   <para>po:Series</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>
    /// 		A series, e.g. `Top Gear, first season'
    /// 	</para>
    /// labels<para>Series</para></remarks>
    /// <seealso href="http://purl.org/ontology/po/Series">http://purl.org/ontology/po/Series</seealso>
    let Series = Prefixed_Name(po, "Series") |> PrefixedName
    /// <summary>
    ///   <para>po:Episode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>
    /// 		A particular episode, e.g. `Top Gear, first episode of the first series' or the film 'A Walk in the Sun' (http://www.bbc.co.uk/programmes/b00gfzdt)
    /// 	</para>
    /// labels<para>Episode</para></remarks>
    /// <seealso href="http://purl.org/ontology/po/Episode">http://purl.org/ontology/po/Episode</seealso>
    let Episode = Prefixed_Name(po, "Episode") |> PrefixedName
    /// <summary>
    ///   <para>po:ProgrammeItem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>
    ///         A programme that can have versions, and as such can be broadcast or made available on-demand, e.g. a clip or an episode.
    ///     </para>
    /// labels<para>ProgrammeItem</para></remarks>
    /// <seealso href="http://purl.org/ontology/po/ProgrammeItem">http://purl.org/ontology/po/ProgrammeItem</seealso>
    let ProgrammeItem = Prefixed_Name(po, "ProgrammeItem") |> PrefixedName
    /// <summary>
    ///   <para>po:FM</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>
    /// 		The FM broadcast band
    /// 	</para>
    /// labels<para>FM</para></remarks>
    /// <seealso href="http://purl.org/ontology/po/FM">http://purl.org/ontology/po/FM</seealso>
    let FM = Prefixed_Name(po, "FM") |> PrefixedName
    /// <summary>
    ///   <para>po:RepeatBroadcast</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>
    /// 		Specifies a broadcast as being a
    /// 		repeat.
    /// 	</para>
    /// labels<para>Repeat</para></remarks>
    /// <seealso href="http://purl.org/ontology/po/RepeatBroadcast">http://purl.org/ontology/po/RepeatBroadcast</seealso>
    let RepeatBroadcast = Prefixed_Name(po, "RepeatBroadcast") |> PrefixedName
    /// <summary>
    ///   <para>po:Format</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>
    ///         Anchor point for format taxonomies, similar to po:Genre for genre taxonomies.
    ///         Instances of this concept include documentaries, talk shows, animation, etc.
    ///     </para>
    /// labels<para>Format</para></remarks>
    /// <seealso href="http://purl.org/ontology/po/Format">http://purl.org/ontology/po/Format</seealso>
    let Format = Prefixed_Name(po, "Format") |> PrefixedName
    /// <summary>
    ///   <para>po:IPStream</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>
    /// 		IP stream
    /// 	</para>
    /// labels<para>IP stream</para></remarks>
    /// <seealso href="http://purl.org/ontology/po/IPStream">http://purl.org/ontology/po/IPStream</seealso>
    let IPStream = Prefixed_Name(po, "IPStream") |> PrefixedName
    /// <summary>
    ///   <para>po:LW</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>
    /// 		The AM broadcast band
    /// 	</para>
    /// labels<para>AM</para></remarks>
    /// <seealso href="http://purl.org/ontology/po/LW">http://purl.org/ontology/po/LW</seealso>
    let LW = Prefixed_Name(po, "LW") |> PrefixedName
    /// <summary>
    ///   <para>po:Radio</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>
    /// 		Services that use a radio medium.
    /// 	</para>
    /// labels<para>Radio</para></remarks>
    /// <seealso href="http://purl.org/ontology/po/Radio">http://purl.org/ontology/po/Radio</seealso>
    let Radio = Prefixed_Name(po, "Radio") |> PrefixedName
    /// <summary>
    ///   <para>po:RegionalRadio</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>
    /// 		Radio services aiming at a regional coverage.
    /// 	</para>
    /// labels<para>RegionalRadio</para></remarks>
    /// <seealso href="http://purl.org/ontology/po/RegionalRadio">http://purl.org/ontology/po/RegionalRadio</seealso>
    let RegionalRadio = Prefixed_Name(po, "RegionalRadio") |> PrefixedName
    /// <summary>
    ///   <para>po:NationalRadio</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>
    /// 		Radio services aiming at a national coverage.
    /// 	</para>
    /// labels<para>NationalRadio</para></remarks>
    /// <seealso href="http://purl.org/ontology/po/NationalRadio">http://purl.org/ontology/po/NationalRadio</seealso>
    let NationalRadio = Prefixed_Name(po, "NationalRadio") |> PrefixedName
    /// <summary>
    ///   <para>po:OriginalVersion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>
    /// 		An `original' version, the legacy version of
    /// 		a particular episode.
    /// 	</para>
    /// labels<para>OriginalVersion</para></remarks>
    /// <seealso href="http://purl.org/ontology/po/OriginalVersion">http://purl.org/ontology/po/OriginalVersion</seealso>
    let OriginalVersion = Prefixed_Name(po, "OriginalVersion") |> PrefixedName
    /// <summary>
    ///   <para>po:Person</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A person</para>
    /// labels<para>Person</para></remarks>
    /// <seealso href="http://purl.org/ontology/po/Person">http://purl.org/ontology/po/Person</seealso>
    let Person = Prefixed_Name(po, "Person") |> PrefixedName
    /// <summary>
    ///   <para>po:Web</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>
    /// 		Services that use a Web medium.
    /// 	</para>
    /// labels<para>Web</para></remarks>
    /// <seealso href="http://purl.org/ontology/po/Web">http://purl.org/ontology/po/Web</seealso>
    let Web = Prefixed_Name(po, "Web") |> PrefixedName
    /// <summary>
    ///   <para>po:TV</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>
    /// 		Services that use a television medium.
    /// 	</para>
    /// labels<para>TV</para></remarks>
    /// <seealso href="http://purl.org/ontology/po/TV">http://purl.org/ontology/po/TV</seealso>
    let TV = Prefixed_Name(po, "TV") |> PrefixedName
    /// <summary>
    ///   <para>po:SignedVersion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>
    /// 		A version holding sign language.
    /// 	</para>
    /// labels<para>SignLanguage</para></remarks>
    /// <seealso href="http://purl.org/ontology/po/SignedVersion">http://purl.org/ontology/po/SignedVersion</seealso>
    let SignedVersion = Prefixed_Name(po, "SignedVersion") |> PrefixedName
    /// <summary>
    ///   <para>po:SpeechSegment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>
    ///         Classification of an episode version's region holding speech content.
    ///     </para>
    /// </remarks>
    /// <seealso href="http://purl.org/ontology/po/SpeechSegment">http://purl.org/ontology/po/SpeechSegment</seealso>
    let SpeechSegment = Prefixed_Name(po, "SpeechSegment") |> PrefixedName
    /// <summary>
    ///   <para>po:Subject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>
    ///         Anchor point for subject taxonomies.
    ///     </para>
    /// labels<para>Subject</para></remarks>
    /// <seealso href="http://purl.org/ontology/po/Subject">http://purl.org/ontology/po/Subject</seealso>
    let Subject = Prefixed_Name(po, "Subject") |> PrefixedName
    /// <summary>
    ///   <para>po:Subtitle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>
    ///         Classification of an episode version's region corresponding to a subtitle being shown.
    ///     </para>
    /// labels<para>Subtitle</para></remarks>
    /// <seealso href="http://purl.org/ontology/po/Subtitle">http://purl.org/ontology/po/Subtitle</seealso>
    let Subtitle = Prefixed_Name(po, "Subtitle") |> PrefixedName
    /// <summary>
    ///   <para>po:actor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relates a programmes to one of its actors - a person who plays the role of a character</para>
    /// labels<para>actor</para></remarks>
    /// <seealso href="http://purl.org/ontology/po/actor">http://purl.org/ontology/po/actor</seealso>
    let actor = Prefixed_Name(po, "actor") |> PrefixedName
    /// <summary>
    ///   <para>po:credit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relates a programmes to a person who is credited in it</para>
    /// labels<para>credit</para></remarks>
    /// <seealso href="http://purl.org/ontology/po/credit">http://purl.org/ontology/po/credit</seealso>
    let credit = Prefixed_Name(po, "credit") |> PrefixedName
    /// <summary>
    ///   <para>po:anchor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A television reporter who coordinates a programme</para>
    /// labels<para>anchor</para></remarks>
    /// <seealso href="http://purl.org/ontology/po/anchor">http://purl.org/ontology/po/anchor</seealso>
    let anchor = Prefixed_Name(po, "anchor") |> PrefixedName
    /// <summary>
    ///   <para>po:aspect_ratio</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>
    /// 		The aspect ration of a particular version.
    /// 	</para>
    /// labels<para>aspect ratio</para></remarks>
    /// <seealso href="http://purl.org/ontology/po/aspect_ratio">http://purl.org/ontology/po/aspect_ratio</seealso>
    let aspect_ratio = Prefixed_Name(po, "aspect_ratio") |> PrefixedName
    /// <summary>
    ///   <para>po:broadcast_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>
    /// 		Relates a particular broadcast to the version being broadcasted.
    /// 		Sub-property of the event:factor one.
    /// 	</para>
    /// labels<para>broadcast of</para></remarks>
    /// <seealso href="http://purl.org/ontology/po/broadcast_of">http://purl.org/ontology/po/broadcast_of</seealso>
    let broadcast_of = Prefixed_Name(po, "broadcast_of") |> PrefixedName
    /// <summary>
    ///   <para>po:broadcast_on</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>
    /// 		Relates a particular broadcast to the service or outlet on which it was.
    /// 		Sub-property of the event:factor one.
    /// 	</para>
    /// labels<para>broadcast on</para></remarks>
    /// <seealso href="http://purl.org/ontology/po/broadcast_on">http://purl.org/ontology/po/broadcast_on</seealso>
    let broadcast_on = Prefixed_Name(po, "broadcast_on") |> PrefixedName
    /// <summary>
    ///   <para>po:broadcasted_on</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Deprecated property, left here for historical reasons</para>
    /// </remarks>
    /// <seealso href="http://purl.org/ontology/po/broadcasted_on">http://purl.org/ontology/po/broadcasted_on</seealso>
    let broadcasted_on = Prefixed_Name(po, "broadcasted_on") |> PrefixedName
    /// <summary>
    ///   <para>po:broadcaster</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>
    /// 		Associates a service to a broadcaster
    /// 	</para>
    /// labels<para>broadcaster</para></remarks>
    /// <seealso href="http://purl.org/ontology/po/broadcaster">http://purl.org/ontology/po/broadcaster</seealso>
    let broadcaster = Prefixed_Name(po, "broadcaster") |> PrefixedName
    /// <summary>
    ///   <para>po:category</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>
    ///         Relates a programme to a particular category, e.g. genre, format, place...
    ///     </para>
    /// labels<para>category</para></remarks>
    /// <seealso href="http://purl.org/ontology/po/category">http://purl.org/ontology/po/category</seealso>
    let category = Prefixed_Name(po, "category") |> PrefixedName
    /// <summary>
    ///   <para>po:clip</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>
    ///         Associates a brand, a series or an episode to a clip.
    ///     </para>
    /// labels<para>clip</para></remarks>
    /// <seealso href="http://purl.org/ontology/po/clip">http://purl.org/ontology/po/clip</seealso>
    let clip = Prefixed_Name(po, "clip") |> PrefixedName
    /// <summary>
    ///   <para>po:commentator</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relates a programme to one of its commentators</para>
    /// labels<para>commentator</para></remarks>
    /// <seealso href="http://purl.org/ontology/po/commentator">http://purl.org/ontology/po/commentator</seealso>
    let commentator = Prefixed_Name(po, "commentator") |> PrefixedName
    /// <summary>
    ///   <para>po:director</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relates a programme to its supervisor. Generally refers to the person responsible for all audience-visible components of a program, film, or show, whereas the producer is responsible for the financial and other behind-the-scenes aspects. A director's duties might also include casting, script editing, shot selection, shot composition, and editing</para>
    /// labels<para>director</para></remarks>
    /// <seealso href="http://purl.org/ontology/po/director">http://purl.org/ontology/po/director</seealso>
    let director = Prefixed_Name(po, "director") |> PrefixedName
    /// <summary>
    ///   <para>po:duration</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The duration of a version, in seconds.</para>
    /// labels<para>duration</para></remarks>
    /// <seealso href="http://purl.org/ontology/po/duration">http://purl.org/ontology/po/duration</seealso>
    let duration = Prefixed_Name(po, "duration") |> PrefixedName
    /// <summary>
    ///   <para>po:executive_producer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relates a programme to its executive producer - a producer who is not involved in any technical aspects of the making process, but who is still responsible for the overall production. Typically an executive producer handles business and legal issues</para>
    /// labels<para>executive producer</para></remarks>
    /// <seealso href="http://purl.org/ontology/po/executive_producer">http://purl.org/ontology/po/executive_producer</seealso>
    let executive_producer = Prefixed_Name(po, "executive_producer") |> PrefixedName
    /// <summary>
    ///   <para>po:format</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>
    /// 		Relates a programme to a particular format (eg. `Animation', `Documentary', etc.).
    /// 	</para>
    /// labels<para>format</para></remarks>
    /// <seealso href="http://purl.org/ontology/po/format">http://purl.org/ontology/po/format</seealso>
    let format = Prefixed_Name(po, "format") |> PrefixedName
    /// <summary>
    ///   <para>po:frequency</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Associates a channel to its frequency</para>
    /// labels<para>frequency</para></remarks>
    /// <seealso href="http://purl.org/ontology/po/frequency">http://purl.org/ontology/po/frequency</seealso>
    let frequency = Prefixed_Name(po, "frequency") |> PrefixedName
    /// <summary>
    ///   <para>po:genre</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>
    /// 		Relates a programme to a particular genre.
    /// 	</para>
    /// labels<para>genre</para></remarks>
    /// <seealso href="http://purl.org/ontology/po/genre">http://purl.org/ontology/po/genre</seealso>
    let genre = Prefixed_Name(po, "genre") |> PrefixedName
    /// <summary>
    ///   <para>po:location</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>
    /// 		Associates a service to a geographic location,
    /// 		aiming at capturing what this service aims at covering.
    /// 	</para>
    /// labels<para>location</para></remarks>
    /// <seealso href="http://purl.org/ontology/po/location">http://purl.org/ontology/po/location</seealso>
    let location = Prefixed_Name(po, "location") |> PrefixedName
    /// <summary>
    ///   <para>po:long_synopsis</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>
    /// 		A long synopsis of a series, brand or episode.
    /// 		Sub-property of po:synopsis.
    /// 	</para>
    /// labels<para>long synopsis</para></remarks>
    /// <seealso href="http://purl.org/ontology/po/long_synopsis">http://purl.org/ontology/po/long_synopsis</seealso>
    let long_synopsis = Prefixed_Name(po, "long_synopsis") |> PrefixedName
    /// <summary>
    ///   <para>po:synopsis</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>
    /// 		The synopsis of a series, brand or episode.
    /// 	</para>
    /// labels<para>synopsis</para></remarks>
    /// <seealso href="http://purl.org/ontology/po/synopsis">http://purl.org/ontology/po/synopsis</seealso>
    let synopsis = Prefixed_Name(po, "synopsis") |> PrefixedName
    /// <summary>
    ///   <para>po:masterbrand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Associates a programme with its masterbrand (its commissioner)</para>
    /// labels<para>masterbrand</para></remarks>
    /// <seealso href="http://purl.org/ontology/po/masterbrand">http://purl.org/ontology/po/masterbrand</seealso>
    let masterbrand = Prefixed_Name(po, "masterbrand") |> PrefixedName
    /// <summary>
    ///   <para>po:medium_synopsis</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>
    /// 		A medium synopsis of a series, brand or episode.
    /// 		Sub-property of po:synopsis.
    /// 	</para>
    /// labels<para>medium synopsis</para></remarks>
    /// <seealso href="http://purl.org/ontology/po/medium_synopsis">http://purl.org/ontology/po/medium_synopsis</seealso>
    let medium_synopsis = Prefixed_Name(po, "medium_synopsis") |> PrefixedName
    /// <summary>
    ///   <para>po:microsite</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Associates a programme to its microsite. For example http://www.bbc.co.uk/programmes/b00fm04s and http://www.bbc.co.uk/eastenders/</para>
    /// labels<para>microsite</para></remarks>
    /// <seealso href="http://purl.org/ontology/po/microsite">http://purl.org/ontology/po/microsite</seealso>
    let microsite = Prefixed_Name(po, "microsite") |> PrefixedName
    /// <summary>
    ///   <para>po:parent_series</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>
    /// 		Relates a series to a series constituting it (eg. `Waking the dead').
    /// 	</para>
    /// labels<para>parent series</para></remarks>
    /// <seealso href="http://purl.org/ontology/po/parent_series">http://purl.org/ontology/po/parent_series</seealso>
    let parent_series = Prefixed_Name(po, "parent_series") |> PrefixedName
    /// <summary>
    ///   <para>po:parent_service</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>
    /// 		Relates a service to another service encapsulating it (eg. `BBC One' and `BBC One South')
    /// 	</para>
    /// labels<para>parent service</para></remarks>
    /// <seealso href="http://purl.org/ontology/po/parent_service">http://purl.org/ontology/po/parent_service</seealso>
    let parent_service = Prefixed_Name(po, "parent_service") |> PrefixedName
    /// <summary>
    ///   <para>po:participant</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relates a programme to one of its participants</para>
    /// labels<para>participant</para></remarks>
    /// <seealso href="http://purl.org/ontology/po/participant">http://purl.org/ontology/po/participant</seealso>
    let participant = Prefixed_Name(po, "participant") |> PrefixedName
    /// <summary>
    ///   <para>po:performer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relates a programme to an entertainer who performs a dramatic or musical work for audience</para>
    /// labels<para>performer</para></remarks>
    /// <seealso href="http://purl.org/ontology/po/performer">http://purl.org/ontology/po/performer</seealso>
    let performer = Prefixed_Name(po, "performer") |> PrefixedName
    /// <summary>
    ///   <para>po:person</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>
    ///         Relates a programme to a person
    ///     </para>
    /// labels<para>person</para></remarks>
    /// <seealso href="http://purl.org/ontology/po/person">http://purl.org/ontology/po/person</seealso>
    let person = Prefixed_Name(po, "person") |> PrefixedName
    /// <summary>
    ///   <para>po:position</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The position of a particular series or episode within its containing programme. This property can also be used to give the position of an interval within the containing timeline.</para>
    /// labels<para>position</para></remarks>
    /// <seealso href="http://purl.org/ontology/po/position">http://purl.org/ontology/po/position</seealso>
    let position = Prefixed_Name(po, "position") |> PrefixedName
    /// <summary>
    ///   <para>po:producer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relates a programme to its producer - the manager of an event, show, or other work, usually the individual in charge of finance, personnel, and other non-artistic aspects in the development of commercials, plays, movies, and other works</para>
    /// labels<para>producer</para></remarks>
    /// <seealso href="http://purl.org/ontology/po/producer">http://purl.org/ontology/po/producer</seealso>
    let producer = Prefixed_Name(po, "producer") |> PrefixedName
    /// <summary>
    ///   <para>po:schedule_date</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>
    /// 		The schedule date of a broadcast event.
    /// 	</para>
    /// labels<para>schedule date</para></remarks>
    /// <seealso href="http://purl.org/ontology/po/schedule_date">http://purl.org/ontology/po/schedule_date</seealso>
    let schedule_date = Prefixed_Name(po, "schedule_date") |> PrefixedName
    /// <summary>
    ///   <para>po:season_broadcast</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Associates a season to its constituent broadcasts</para>
    /// labels<para>broadcast</para></remarks>
    /// <seealso href="http://purl.org/ontology/po/season_broadcast">http://purl.org/ontology/po/season_broadcast</seealso>
    let season_broadcast = Prefixed_Name(po, "season_broadcast") |> PrefixedName
    /// <summary>
    ///   <para>po:series</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>
    /// 		Associates a brand or a series to a series constituting it.
    /// 	</para>
    /// labels<para>series</para></remarks>
    /// <seealso href="http://purl.org/ontology/po/series">http://purl.org/ontology/po/series</seealso>
    let series = Prefixed_Name(po, "series") |> PrefixedName
    /// <summary>
    ///   <para>po:service</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>
    /// 		Associate a brand, series or episode to the master brand service.
    /// 	</para>
    /// labels<para>service</para></remarks>
    /// <seealso href="http://purl.org/ontology/po/service">http://purl.org/ontology/po/service</seealso>
    let service = Prefixed_Name(po, "service") |> PrefixedName
    /// <summary>
    ///   <para>po:short_synopsis</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>
    /// 		A short synopsis of a series, brand or episode.
    /// 		Sub-property of po:synopsis.
    /// 	</para>
    /// labels<para>short synopsis</para></remarks>
    /// <seealso href="http://purl.org/ontology/po/short_synopsis">http://purl.org/ontology/po/short_synopsis</seealso>
    let short_synopsis = Prefixed_Name(po, "short_synopsis") |> PrefixedName
    /// <summary>
    ///   <para>po:sound_format</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>
    /// 		The sound format of a particular version.
    /// 	</para>
    /// labels<para>sound format</para></remarks>
    /// <seealso href="http://purl.org/ontology/po/sound_format">http://purl.org/ontology/po/sound_format</seealso>
    let sound_format = Prefixed_Name(po, "sound_format") |> PrefixedName
    /// <summary>
    ///   <para>po:subject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>
    ///         Relates a programme to a subject (e.g. `Easter')
    ///     </para>
    /// labels<para>subject</para></remarks>
    /// <seealso href="http://purl.org/ontology/po/subject">http://purl.org/ontology/po/subject</seealso>
    let subject = Prefixed_Name(po, "subject") |> PrefixedName
    /// <summary>
    ///   <para>po:subtitle_language</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Language of the subtitles embedded in a particular version</para>
    /// labels<para>subtitle language</para></remarks>
    /// <seealso href="http://purl.org/ontology/po/subtitle_language">http://purl.org/ontology/po/subtitle_language</seealso>
    let subtitle_language = Prefixed_Name(po, "subtitle_language") |> PrefixedName
    /// <summary>
    ///   <para>po:time</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Associates an episode's version or a version's segment with a temporal interval. This interval can be associated with a timeline, serving as an anchor for further temporal annotations, e.g. subtitles or played track</para>
    /// labels<para>time</para></remarks>
    /// <seealso href="http://purl.org/ontology/po/time">http://purl.org/ontology/po/time</seealso>
    let time = Prefixed_Name(po, "time") |> PrefixedName
    /// <summary>
    ///   <para>po:track</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Associates a music segment with a track, as defined in MO</para>
    /// labels<para>track</para></remarks>
    /// <seealso href="http://purl.org/ontology/po/track">http://purl.org/ontology/po/track</seealso>
    let track = Prefixed_Name(po, "track") |> PrefixedName
    /// <summary>
    ///   <para>po:version</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:InverseFunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>
    /// 		Associate an episode to a version of it.
    /// 		Different versions of a same episode can exist (shortened version, version
    /// 		designed for the hearing impaired, etc.).
    /// 	</para>
    /// labels<para>version</para></remarks>
    /// <seealso href="http://purl.org/ontology/po/version">http://purl.org/ontology/po/version</seealso>
    let version = Prefixed_Name(po, "version") |> PrefixedName
    /// <summary>
    ///   <para>po:MusicSegment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>
    /// 		Classification of an episode version's region corresponding to a musical track being played.
    /// 	</para>
    /// labels<para>MusicSegment</para></remarks>
    /// <seealso href="http://purl.org/ontology/po/MusicSegment">http://purl.org/ontology/po/MusicSegment</seealso>
    let MusicSegment = Prefixed_Name(po, "MusicSegment") |> PrefixedName
    /// <summary>
    ///   <para>po:Service</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>
    ///         A broadcasting service.
    /// 		Instances of this concept include BBC Radio Wales, BBC Radio 4, BBC News, etc.
    ///         A service is a collection of outlets which contain common material, but with some variations, e.g. by
    ///         region.
    ///         Hence, a service may have multiple outlets (po:Outlet), e.g. BBC Radio 4 has BBC Radio 4 LW and BBC Radio 4 FM.
    ///         A hierarchy of services types is defined within this ontology, e.g. radio and TV.
    ///         A service that is a master brand only (a service that only commissions programmes, e.g. BBC Switch) should
    ///         be an instance of the top-level po:Service.
    /// 	</para>
    /// labels<para>Service</para></remarks>
    /// <seealso href="http://purl.org/ontology/po/Service">http://purl.org/ontology/po/Service</seealso>
    let Service = Prefixed_Name(po, "Service") |> PrefixedName
    /// <summary>
    ///   <para>po:1.1</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.org/ontology/po/1.1">http://purl.org/ontology/po/1.1</seealso>
    let ``_1.1`` = Prefixed_Name(po, "1.1") |> PrefixedName
    /// <summary>
    ///   <para>po:Version</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>
    /// 		A particular version of an episode.
    /// 		Such versions include shortened ones, audio described ones
    /// 		or ones that holds sign language.
    /// 		The version is associated to a timeline.
    /// 	</para>
    /// labels<para>Version</para></remarks>
    /// <seealso href="http://purl.org/ontology/po/Version">http://purl.org/ontology/po/Version</seealso>
    let Version = Prefixed_Name(po, "Version") |> PrefixedName
    /// <summary>
    ///   <para>po:Broadcast</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>
    /// 		A broadcast event.
    /// 		Subsumes the event concept defined in
    /// 		the Event ontology.
    /// 		A broadcast is associated with a service, and with a
    /// 		particular version of an episode.
    /// 	</para>
    /// labels<para>Broadcast</para></remarks>
    /// <seealso href="http://purl.org/ontology/po/Broadcast">http://purl.org/ontology/po/Broadcast</seealso>
    let Broadcast = Prefixed_Name(po, "Broadcast") |> PrefixedName
    /// <summary>
    ///   <para>po:place</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>
    ///         Relates a programme to a place (e.g. `London')
    ///     </para>
    /// labels<para>place</para></remarks>
    /// <seealso href="http://purl.org/ontology/po/place">http://purl.org/ontology/po/place</seealso>
    let place = Prefixed_Name(po, "place") |> PrefixedName
    /// <summary>
    ///   <para>po:1.0</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.org/ontology/po/1.0">http://purl.org/ontology/po/1.0</seealso>
    let ``_1.0`` = Prefixed_Name(po, "1.0") |> PrefixedName

    /// <summary>
    ///   <para>po:AudioDescribedVersion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>
    /// 		A version holding an audio description.
    /// 	</para>
    /// labels<para>AudioDescribedVersion</para></remarks>
    /// <seealso href="http://purl.org/ontology/po/AudioDescribedVersion">http://purl.org/ontology/po/AudioDescribedVersion</seealso>
    let AudioDescribedVersion =
        Prefixed_Name(po, "AudioDescribedVersion") |> PrefixedName

    /// <summary>
    ///   <para>po:Brand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>
    /// 		A brand, e.g. `Top Gear'
    /// 	</para>
    /// labels<para>Brand</para></remarks>
    /// <seealso href="http://purl.org/ontology/po/Brand">http://purl.org/ontology/po/Brand</seealso>
    let Brand = Prefixed_Name(po, "Brand") |> PrefixedName
    /// <summary>
    ///   <para>po:Clip</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>
    ///         A particular clip, e.g. `Clip of Top Gear, first series'
    ///     </para>
    /// labels<para>Clip</para></remarks>
    /// <seealso href="http://purl.org/ontology/po/Clip">http://purl.org/ontology/po/Clip</seealso>
    let Clip = Prefixed_Name(po, "Clip") |> PrefixedName
    /// <summary>
    ///   <para>po:Broadcaster</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>
    /// 		An organization responsible of some broadcasting services.
    ///         It can hold a set of services and outlets.
    /// 	</para>
    /// labels<para>Broadcaster</para></remarks>
    /// <seealso href="http://purl.org/ontology/po/Broadcaster">http://purl.org/ontology/po/Broadcaster</seealso>
    let Broadcaster = Prefixed_Name(po, "Broadcaster") |> PrefixedName
    /// <summary>
    ///   <para>po:author</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relates a programme to its author - the person who created the content</para>
    /// labels<para>author</para></remarks>
    /// <seealso href="http://purl.org/ontology/po/author">http://purl.org/ontology/po/author</seealso>
    let author = Prefixed_Name(po, "author") |> PrefixedName
    /// <summary>
    ///   <para>po:channel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>
    ///         Associates a service to a channel, e.g. Radio 4 LW to Radio 4 LW on Analogue Long Wave.
    ///     </para>
    /// labels<para>channel</para></remarks>
    /// <seealso href="http://purl.org/ontology/po/channel">http://purl.org/ontology/po/channel</seealso>
    let channel = Prefixed_Name(po, "channel") |> PrefixedName
    /// <summary>
    ///   <para>po:Season</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>
    /// 		A season is a group of broadcasts.
    /// 	</para>
    /// labels<para>Season</para></remarks>
    /// <seealso href="http://purl.org/ontology/po/Season">http://purl.org/ontology/po/Season</seealso>
    let Season = Prefixed_Name(po, "Season") |> PrefixedName
    /// <summary>
    ///   <para>po:news_reader</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relates a programme to its news reader</para>
    /// labels<para>news reader</para></remarks>
    /// <seealso href="http://purl.org/ontology/po/news_reader">http://purl.org/ontology/po/news_reader</seealso>
    let news_reader = Prefixed_Name(po, "news_reader") |> PrefixedName
    /// <summary>
    ///   <para>po:outlet</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>
    /// 		Associates a service to an outlet, e.g. Radio 4 to Radio 4 LW.
    /// 	</para>
    /// labels<para>outlet</para></remarks>
    /// <seealso href="http://purl.org/ontology/po/outlet">http://purl.org/ontology/po/outlet</seealso>
    let outlet = Prefixed_Name(po, "outlet") |> PrefixedName
    /// <summary>
    ///   <para>po:Category</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>
    ///         A category provides a way of classifying a set of programmes. Such classifications
    ///         can be performed according to multiple dimensions and taxonomies, e.g. genre, format, places, people, subjects...
    ///     </para>
    /// labels<para>Category</para></remarks>
    /// <seealso href="http://purl.org/ontology/po/Category">http://purl.org/ontology/po/Category</seealso>
    let Category = Prefixed_Name(po, "Category") |> PrefixedName
    /// <summary>
    ///   <para>po:DAB</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>
    /// 		Digital Audio Broadcasting
    /// 	</para>
    /// labels<para>DAB</para></remarks>
    /// <seealso href="http://purl.org/ontology/po/DAB">http://purl.org/ontology/po/DAB</seealso>
    let DAB = Prefixed_Name(po, "DAB") |> PrefixedName
    /// <summary>
    ///   <para>po:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///   <para>bbcprov:Ontology</para>
    ///   <para>
    /// 		A vocabulary for programme data.
    /// 		It defines concepts such as brands, series, episodes, broadcasts, etc.
    /// 	</para>
    /// labels<para>Programmes ontology</para></remarks>
    /// <seealso href="http://purl.org/ontology/po/">http://purl.org/ontology/po/</seealso>
    let _prefix_iri = Prefixed_Name(po, "") |> PrefixedName
    /// <summary>
    ///   <para>po:Channel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>
    ///         A physical channel on which a broadcast occurs.
    ///         A single outlet or service can be associated with multiple channels.
    ///         For example, Radio 4 LW broadcasts on Analogue Long Wave and on Digital
    ///         Satellite.
    ///     </para>
    /// labels<para>Channel</para></remarks>
    /// <seealso href="http://purl.org/ontology/po/Channel">http://purl.org/ontology/po/Channel</seealso>
    let Channel = Prefixed_Name(po, "Channel") |> PrefixedName
    /// <summary>
    ///   <para>po:DVB</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>
    /// 		Digital Video Broadcasting
    /// 	</para>
    /// labels<para>DVB</para></remarks>
    /// <seealso href="http://purl.org/ontology/po/DVB">http://purl.org/ontology/po/DVB</seealso>
    let DVB = Prefixed_Name(po, "DVB") |> PrefixedName
    /// <summary>
    ///   <para>po:FirstBroadcast</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>
    /// 		Specifies a broadcast as being the
    /// 		first one of a particular version.
    /// 	 </para>
    /// labels<para>FirstBroadcast</para></remarks>
    /// <seealso href="http://purl.org/ontology/po/FirstBroadcast">http://purl.org/ontology/po/FirstBroadcast</seealso>
    let FirstBroadcast = Prefixed_Name(po, "FirstBroadcast") |> PrefixedName
    /// <summary>
    ///   <para>po:Genre</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>
    ///         An anchor point for a programmes' genre taxonomy, e.g. 'Drama'/'Biographical'.
    /// 	</para>
    /// labels<para>Genre</para></remarks>
    /// <seealso href="http://purl.org/ontology/po/Genre">http://purl.org/ontology/po/Genre</seealso>
    let Genre = Prefixed_Name(po, "Genre") |> PrefixedName
    /// <summary>
    ///   <para>po:LocalRadio</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>
    /// 		Radio services aiming at a local coverage.
    /// 	</para>
    /// labels<para>LocalRadio</para></remarks>
    /// <seealso href="http://purl.org/ontology/po/LocalRadio">http://purl.org/ontology/po/LocalRadio</seealso>
    let LocalRadio = Prefixed_Name(po, "LocalRadio") |> PrefixedName
    /// <summary>
    ///   <para>po:Segment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>
    /// 		Classification of an episode version's region, e.g. 'this track was played at that time'.
    /// 	</para>
    /// labels<para>Segment</para></remarks>
    /// <seealso href="http://purl.org/ontology/po/Segment">http://purl.org/ontology/po/Segment</seealso>
    let Segment = Prefixed_Name(po, "Segment") |> PrefixedName
    /// <summary>
    ///   <para>po:ShortenedVersion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>
    /// 		A shortened version.
    /// 	</para>
    /// labels<para>ShortenedVersion</para></remarks>
    /// <seealso href="http://purl.org/ontology/po/ShortenedVersion">http://purl.org/ontology/po/ShortenedVersion</seealso>
    let ShortenedVersion = Prefixed_Name(po, "ShortenedVersion") |> PrefixedName
    /// <summary>
    ///   <para>po:Outlet</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>
    ///         Outlet of a particular service, e.g. Radio 4 LW and FM for Radio 4.
    ///         Outlets are services which do not have variations.
    ///         The criterion for an outlet is its timeline.
    ///         For example, Radio 4 LW broadcasts on Analogue Long Wave, but also on Digital Satellite.
    ///         It corresponds to just one outlet, as they are simulcasts.
    ///         The two physical channels for broadcasts correspond to po:Channel.
    ///     </para>
    /// labels<para>Outlet</para></remarks>
    /// <seealso href="http://purl.org/ontology/po/Outlet">http://purl.org/ontology/po/Outlet</seealso>
    let Outlet = Prefixed_Name(po, "Outlet") |> PrefixedName
    /// <summary>
    ///   <para>po:Place</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A physical place</para>
    /// labels<para>Place</para></remarks>
    /// <seealso href="http://purl.org/ontology/po/Place">http://purl.org/ontology/po/Place</seealso>
    let Place = Prefixed_Name(po, "Place") |> PrefixedName
    /// <summary>
    ///   <para>po:episode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>
    /// 		Associates a brand or a series to an episode constituting it.
    /// 	</para>
    /// labels<para>episode</para></remarks>
    /// <seealso href="http://purl.org/ontology/po/episode">http://purl.org/ontology/po/episode</seealso>
    let episode = Prefixed_Name(po, "episode") |> PrefixedName
    /// <summary>
    ///   <para>po:text</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Associates a subtitle event to the corresponding text</para>
    /// labels<para>text</para></remarks>
    /// <seealso href="http://purl.org/ontology/po/text">http://purl.org/ontology/po/text</seealso>
    let text = Prefixed_Name(po, "text") |> PrefixedName
