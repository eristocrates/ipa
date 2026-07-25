namespace http.purl.org.ontology.af.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module af =
    let _namespace_iri = Namespace_Iri af |> NamespaceIRI
    /// <summary>
    ///   <para>af:Point</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>
    /// 		A classifier for instants corresponding to the output of an automatic process---an
    /// 		artificial cognitive agent (should be associated to a time:Instant---DL version).
    /// 		</para>
    /// labels<para>Point</para></remarks>
    /// <seealso href="http://purl.org/ontology/af/Point">http://purl.org/ontology/af/Point</seealso>
    let Point = Prefixed_Name(af, "Point") |> PrefixedName
    /// <summary>
    ///   <para>af:Chromagram</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>
    /// 		A chromagram feature.
    /// 	</para>
    /// labels<para>Chromagram</para></remarks>
    /// <seealso href="http://purl.org/ontology/af/Chromagram">http://purl.org/ontology/af/Chromagram</seealso>
    let Chromagram = Prefixed_Name(af, "Chromagram") |> PrefixedName
    /// <summary>
    ///   <para>af:EmotionSegment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>
    /// 		A classifier for emotional content
    /// 		</para>
    /// labels<para>Emotion segment</para></remarks>
    /// <seealso href="http://purl.org/ontology/af/EmotionSegment">http://purl.org/ontology/af/EmotionSegment</seealso>
    let EmotionSegment = Prefixed_Name(af, "EmotionSegment") |> PrefixedName
    /// <summary>
    ///   <para>af:GermanIdiom</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>
    /// 		German idiom
    /// 		</para>
    /// labels<para>German idiom</para></remarks>
    /// <seealso href="http://purl.org/ontology/af/GermanIdiom">http://purl.org/ontology/af/GermanIdiom</seealso>
    let GermanIdiom = Prefixed_Name(af, "GermanIdiom") |> PrefixedName
    /// <summary>
    ///   <para>af:Idiom</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>
    /// 		Idiom (English with Irish accent, Austrian German, etc.)
    /// 		</para>
    /// labels<para>Idiom</para></remarks>
    /// <seealso href="http://purl.org/ontology/af/Idiom">http://purl.org/ontology/af/Idiom</seealso>
    let Idiom = Prefixed_Name(af, "Idiom") |> PrefixedName
    /// <summary>
    ///   <para>af:Signal</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>
    /// 		A signal-like feature, holding dense data describing another signal.
    /// 		Examples of signal features include chromagrams, spectrograms, onset detection functions etc.
    /// 	</para>
    /// labels<para>Signal-level feature</para></remarks>
    /// <seealso href="http://purl.org/ontology/af/Signal">http://purl.org/ontology/af/Signal</seealso>
    let Signal = Prefixed_Name(af, "Signal") |> PrefixedName
    /// <summary>
    ///   <para>af:MusicSegment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>
    /// 		A classifier capturing the notion of an audio segment holding music.
    /// 		This classifier can be subsumed with more specific classifiers.
    /// 		</para>
    /// labels<para>Music</para></remarks>
    /// <seealso href="http://purl.org/ontology/af/MusicSegment">http://purl.org/ontology/af/MusicSegment</seealso>
    let MusicSegment = Prefixed_Name(af, "MusicSegment") |> PrefixedName
    /// <summary>
    ///   <para>af:Major</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>
    /// 		A classifier for a major mode region.
    /// 		In case of a "clean cut", instances of such events have one
    ///                 factor. In other cases, this event can have several factors, each associated
    ///                 with a particular confidence using event decomposition.
    /// 	</para>
    /// labels<para>Major segment</para></remarks>
    /// <seealso href="http://purl.org/ontology/af/Major">http://purl.org/ontology/af/Major</seealso>
    let Major = Prefixed_Name(af, "Major") |> PrefixedName
    /// <summary>
    ///   <para>af:ModeChange</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A mode change event. The factors of such events include the mode that holds after the event.</para>
    /// labels<para>Mode change event</para></remarks>
    /// <seealso href="http://purl.org/ontology/af/ModeChange">http://purl.org/ontology/af/ModeChange</seealso>
    let ModeChange = Prefixed_Name(af, "ModeChange") |> PrefixedName
    /// <summary>
    ///   <para>af:IdiomSegment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>
    /// 		A classifier for recognized idiom (English with Irish accent, etc.)
    /// 		</para>
    /// labels<para>Idiom segment</para></remarks>
    /// <seealso href="http://purl.org/ontology/af/IdiomSegment">http://purl.org/ontology/af/IdiomSegment</seealso>
    let IdiomSegment = Prefixed_Name(af, "IdiomSegment") |> PrefixedName
    /// <summary>
    ///   <para>af:Laugh</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>
    /// 		A classifier for laugh content
    /// 		</para>
    /// labels<para>Laugh</para></remarks>
    /// <seealso href="http://purl.org/ontology/af/Laugh">http://purl.org/ontology/af/Laugh</seealso>
    let Laugh = Prefixed_Name(af, "Laugh") |> PrefixedName
    /// <summary>
    ///   <para>af:new_key</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Associates a key change event to the new key, holding after the change</para>
    /// labels<para>new key</para></remarks>
    /// <seealso href="http://purl.org/ontology/af/new_key">http://purl.org/ontology/af/new_key</seealso>
    let new_key = Prefixed_Name(af, "new_key") |> PrefixedName
    /// <summary>
    ///   <para>af:ModeChangeEvent</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.org/ontology/af/ModeChangeEvent">http://purl.org/ontology/af/ModeChangeEvent</seealso>
    let ModeChangeEvent = Prefixed_Name(af, "ModeChangeEvent") |> PrefixedName
    /// <summary>
    ///   <para>af:person</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>
    /// 		Associates a segment classified as holding speech content to a FOAF
    /// 		profile (maybe holding information about genre, recognized speaker URI, etc.)
    /// 		</para>
    /// labels<para>person</para></remarks>
    /// <seealso href="http://purl.org/ontology/af/person">http://purl.org/ontology/af/person</seealso>
    let person = Prefixed_Name(af, "person") |> PrefixedName
    /// <summary>
    ///   <para>af:signal_feature</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>
    /// 		Associates an audio signal with a track-level signal feature.
    /// 		eg. a spectrogram, a chromagram, an onset detection function.
    /// 	</para>
    /// labels<para>signal-level feature</para></remarks>
    /// <seealso href="http://purl.org/ontology/af/signal_feature">http://purl.org/ontology/af/signal_feature</seealso>
    let signal_feature = Prefixed_Name(af, "signal_feature") |> PrefixedName
    /// <summary>
    ///   <para>af:standard_german</para>
    /// </summary>
    /// <remarks>
    ///   <para>af:GermanIdiom</para>
    /// </remarks>
    /// <seealso href="http://purl.org/ontology/af/standard_german">http://purl.org/ontology/af/standard_german</seealso>
    let standard_german = Prefixed_Name(af, "standard_german") |> PrefixedName
    /// <summary>
    ///   <para>af:standard_us_english</para>
    /// </summary>
    /// <remarks>
    ///   <para>af:EnglishIdiom</para>
    /// </remarks>
    /// <seealso href="http://purl.org/ontology/af/standard_us_english">http://purl.org/ontology/af/standard_us_english</seealso>
    let standard_us_english = Prefixed_Name(af, "standard_us_english") |> PrefixedName
    /// <summary>
    ///   <para>af:tempo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>
    /// 		Associates a tempo event to the corresponding tempo value.
    /// 	</para>
    /// labels<para>tempo</para></remarks>
    /// <seealso href="http://purl.org/ontology/af/tempo">http://purl.org/ontology/af/tempo</seealso>
    let tempo = Prefixed_Name(af, "tempo") |> PrefixedName

    /// <summary>
    ///   <para>af:LinearFrequencyCentroid</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>
    /// 		Log-frequency spectral centroid
    /// 	</para>
    /// labels<para>Linear-frequency spectral centroid</para></remarks>
    /// <seealso href="http://purl.org/ontology/af/LinearFrequencyCentroid">http://purl.org/ontology/af/LinearFrequencyCentroid</seealso>
    let LinearFrequencyCentroid =
        Prefixed_Name(af, "LinearFrequencyCentroid") |> PrefixedName

    /// <summary>
    ///   <para>af:SpectralCentroid</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>
    /// 		Spectral centroid
    /// 	</para>
    /// labels<para>Spectral centroid</para></remarks>
    /// <seealso href="http://purl.org/ontology/af/SpectralCentroid">http://purl.org/ontology/af/SpectralCentroid</seealso>
    let SpectralCentroid = Prefixed_Name(af, "SpectralCentroid") |> PrefixedName
    /// <summary>
    ///   <para>af:Loudness</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Event holding a loudness value</para>
    /// labels<para>Loudness event</para></remarks>
    /// <seealso href="http://purl.org/ontology/af/Loudness">http://purl.org/ontology/af/Loudness</seealso>
    let Loudness = Prefixed_Name(af, "Loudness") |> PrefixedName
    /// <summary>
    ///   <para>af:swiss_german</para>
    /// </summary>
    /// <remarks>
    ///   <para>af:GermanIdiom</para>
    /// </remarks>
    /// <seealso href="http://purl.org/ontology/af/swiss_german">http://purl.org/ontology/af/swiss_german</seealso>
    let swiss_german = Prefixed_Name(af, "swiss_german") |> PrefixedName
    /// <summary>
    ///   <para>af:text</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>
    /// 		Relates a Text segment (classifying a time interval that can
    /// 		be associated to some text) to a text string or other literals (number, etc.)
    /// 		</para>
    /// </remarks>
    /// <seealso href="http://purl.org/ontology/af/text">http://purl.org/ontology/af/text</seealso>
    let text = Prefixed_Name(af, "text") |> PrefixedName
    /// <summary>
    ///   <para>af:LogFrequencyCentroid</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>
    /// 		Log-frequency spectral centroid
    /// 	</para>
    /// labels<para>Log-frequency spectral centroid</para></remarks>
    /// <seealso href="http://purl.org/ontology/af/LogFrequencyCentroid">http://purl.org/ontology/af/LogFrequencyCentroid</seealso>
    let LogFrequencyCentroid = Prefixed_Name(af, "LogFrequencyCentroid") |> PrefixedName

    /// <summary>
    ///   <para>af:standard_british_english</para>
    /// </summary>
    /// <remarks>
    ///   <para>af:EnglishIdiom</para>
    /// </remarks>
    /// <seealso href="http://purl.org/ontology/af/standard_british_english">http://purl.org/ontology/af/standard_british_english</seealso>
    let standard_british_english =
        Prefixed_Name(af, "standard_british_english") |> PrefixedName

    /// <summary>
    ///   <para>af:standard_hungarian</para>
    /// </summary>
    /// <remarks>
    ///   <para>af:HungarianIdiom</para>
    /// </remarks>
    /// <seealso href="http://purl.org/ontology/af/standard_hungarian">http://purl.org/ontology/af/standard_hungarian</seealso>
    let standard_hungarian = Prefixed_Name(af, "standard_hungarian") |> PrefixedName
    /// <summary>
    ///   <para>af:TonicChangeEvent</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.org/ontology/af/TonicChangeEvent">http://purl.org/ontology/af/TonicChangeEvent</seealso>
    let TonicChangeEvent = Prefixed_Name(af, "TonicChangeEvent") |> PrefixedName
    /// <summary>
    ///   <para>af:PersonSegment</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.org/ontology/af/PersonSegment">http://purl.org/ontology/af/PersonSegment</seealso>
    let PersonSegment = Prefixed_Name(af, "PersonSegment") |> PrefixedName
    /// <summary>
    ///   <para>af:pitch</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>
    /// 		Associates a pitch event to the corresponding pitch
    /// 	</para>
    /// labels<para>pitch</para></remarks>
    /// <seealso href="http://purl.org/ontology/af/pitch">http://purl.org/ontology/af/pitch</seealso>
    let pitch = Prefixed_Name(af, "pitch") |> PrefixedName
    /// <summary>
    ///   <para>af:tonic</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Associates a tonic event with the corresponding tonic</para>
    /// labels<para>tonic</para></remarks>
    /// <seealso href="http://purl.org/ontology/af/tonic">http://purl.org/ontology/af/tonic</seealso>
    let tonic = Prefixed_Name(af, "tonic") |> PrefixedName
    /// <summary>
    ///   <para>af:value</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>
    /// 		Associates a signal resource as defined in the Music Ontology to a literal: its actual value.
    /// 		For example, it can be used to link an onset detection function to a list of values.
    /// 	</para>
    /// labels<para>value</para></remarks>
    /// <seealso href="http://purl.org/ontology/af/value">http://purl.org/ontology/af/value</seealso>
    let value = Prefixed_Name(af, "value") |> PrefixedName
    /// <summary>
    ///   <para>af:Minor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>
    /// 		A classifier for a minor mode region.
    /// 		In case of a "clean cut", instances of such events have one
    ///                 factor. In other cases, this event can have several factors, each associated
    ///                 with a particular confidence using event decomposition.
    /// 	</para>
    /// labels<para>Minor segment</para></remarks>
    /// <seealso href="http://purl.org/ontology/af/Minor">http://purl.org/ontology/af/Minor</seealso>
    let Minor = Prefixed_Name(af, "Minor") |> PrefixedName

    /// <summary>
    ///   <para>af:MusicStructuralSegment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>
    /// 		Classifier capturing the notion of chorus, verse, intro, bridge, phrase, etc.
    /// 		</para>
    /// labels<para>Music structural segment</para></remarks>
    /// <seealso href="http://purl.org/ontology/af/MusicStructuralSegment">http://purl.org/ontology/af/MusicStructuralSegment</seealso>
    let MusicStructuralSegment =
        Prefixed_Name(af, "MusicStructuralSegment") |> PrefixedName

    /// <summary>
    ///   <para>af:StructuralSegment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>
    /// 		A classifier trying to capture the notion of structure in an audio piece.
    /// 		This classifier should be subsumed by more specific classifiers: speech/music
    /// 		segmentation, structural music segmmentation (intro, verse, chorus, etc.).
    /// 		</para>
    /// labels<para>Structural Segment</para></remarks>
    /// <seealso href="http://purl.org/ontology/af/StructuralSegment">http://purl.org/ontology/af/StructuralSegment</seealso>
    let StructuralSegment = Prefixed_Name(af, "StructuralSegment") |> PrefixedName
    /// <summary>
    ///   <para>af:NonTonalOnset</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A percussive onset</para>
    /// labels<para>Percussive onset</para></remarks>
    /// <seealso href="http://purl.org/ontology/af/NonTonalOnset">http://purl.org/ontology/af/NonTonalOnset</seealso>
    let NonTonalOnset = Prefixed_Name(af, "NonTonalOnset") |> PrefixedName
    /// <summary>
    ///   <para>af:Ornament</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Classifying a temporal region holding a musical ornament</para>
    /// labels<para>Ornament event</para></remarks>
    /// <seealso href="http://purl.org/ontology/af/Ornament">http://purl.org/ontology/af/Ornament</seealso>
    let Ornament = Prefixed_Name(af, "Ornament") |> PrefixedName
    /// <summary>
    ///   <para>af:Onset</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>
    /// 		A classifier corresponding to the output of an onset detection process.
    /// 		</para>
    /// labels<para>Onset</para></remarks>
    /// <seealso href="http://purl.org/ontology/af/Onset">http://purl.org/ontology/af/Onset</seealso>
    let Onset = Prefixed_Name(af, "Onset") |> PrefixedName
    /// <summary>
    ///   <para>af:PersonSpeaking</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>
    /// 			A classifier associating a FOAF description to a particular segment
    /// 			(to classify genre, recognized speaker, etc.)
    /// 			</para>
    /// labels<para>Person speaking</para></remarks>
    /// <seealso href="http://purl.org/ontology/af/PersonSpeaking">http://purl.org/ontology/af/PersonSpeaking</seealso>
    let PersonSpeaking = Prefixed_Name(af, "PersonSpeaking") |> PrefixedName
    /// <summary>
    ///   <para>af:Segment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>
    /// 		A classifier for a temporal region corresponding to the output
    /// 		of an automatic process---an artificial cognitive agent.
    /// 		</para>
    /// labels<para>Segment</para></remarks>
    /// <seealso href="http://purl.org/ontology/af/Segment">http://purl.org/ontology/af/Segment</seealso>
    let Segment = Prefixed_Name(af, "Segment") |> PrefixedName

    /// <summary>
    ///   <para>af:OnsetDetectionFunction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>
    /// 		An onset detection function
    /// 	</para>
    /// labels<para>Onset detection function</para></remarks>
    /// <seealso href="http://purl.org/ontology/af/OnsetDetectionFunction">http://purl.org/ontology/af/OnsetDetectionFunction</seealso>
    let OnsetDetectionFunction =
        Prefixed_Name(af, "OnsetDetectionFunction") |> PrefixedName

    /// <summary>
    ///   <para>af:Pitch</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Associate a point to a particular pitch</para>
    ///   <para>Event holding a pitch value (for example coming from a monophonic transcription process)</para>
    /// labels<para>Pitch event</para></remarks>
    /// <seealso href="http://purl.org/ontology/af/Pitch">http://purl.org/ontology/af/Pitch</seealso>
    let Pitch = Prefixed_Name(af, "Pitch") |> PrefixedName
    /// <summary>
    ///   <para>af:Tempo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Event holding a tempo value (120bpm...)</para>
    /// labels<para>Tempo event</para></remarks>
    /// <seealso href="http://purl.org/ontology/af/Tempo">http://purl.org/ontology/af/Tempo</seealso>
    let Tempo = Prefixed_Name(af, "Tempo") |> PrefixedName
    /// <summary>
    ///   <para>af:Text</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>
    /// 		A classifier allowing to associate some text to a segment
    /// 		</para>
    /// labels<para>Text</para></remarks>
    /// <seealso href="http://purl.org/ontology/af/Text">http://purl.org/ontology/af/Text</seealso>
    let Text = Prefixed_Name(af, "Text") |> PrefixedName
    /// <summary>
    ///   <para>af:TonalChange</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A tonal change event.</para>
    /// labels<para>Tonal change event</para></remarks>
    /// <seealso href="http://purl.org/ontology/af/TonalChange">http://purl.org/ontology/af/TonalChange</seealso>
    let TonalChange = Prefixed_Name(af, "TonalChange") |> PrefixedName

    /// <summary>
    ///   <para>af:TempoDetectionFunction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>
    /// 		A tempo detection function
    /// 	</para>
    /// labels<para>Tempo detection function</para></remarks>
    /// <seealso href="http://purl.org/ontology/af/TempoDetectionFunction">http://purl.org/ontology/af/TempoDetectionFunction</seealso>
    let TempoDetectionFunction =
        Prefixed_Name(af, "TempoDetectionFunction") |> PrefixedName

    /// <summary>
    ///   <para>af:TimeSignature</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Classifying a temporal region with a particular time signature (what? there is something else than 4/4?? :-)</para>
    /// labels<para>Time signature</para></remarks>
    /// <seealso href="http://purl.org/ontology/af/TimeSignature">http://purl.org/ontology/af/TimeSignature</seealso>
    let TimeSignature = Prefixed_Name(af, "TimeSignature") |> PrefixedName

    /// <summary>
    ///   <para>af:TonalChangeDetectionFunction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>
    /// 		A tonal change detection function
    /// 	</para>
    /// labels<para>Tonal change detection function</para></remarks>
    /// <seealso href="http://purl.org/ontology/af/TonalChangeDetectionFunction">http://purl.org/ontology/af/TonalChangeDetectionFunction</seealso>
    let TonalChangeDetectionFunction =
        Prefixed_Name(af, "TonalChangeDetectionFunction") |> PrefixedName

    /// <summary>
    ///   <para>af:TonalContentSpace</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>
    /// 		A 6-D tonal content space
    /// 	</para>
    /// labels<para>Tonal content space</para></remarks>
    /// <seealso href="http://purl.org/ontology/af/TonalContentSpace">http://purl.org/ontology/af/TonalContentSpace</seealso>
    let TonalContentSpace = Prefixed_Name(af, "TonalContentSpace") |> PrefixedName
    /// <summary>
    ///   <para>af:TonicChange</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A tonic change event. The factors of such events include the tonic that holds after the event.</para>
    /// labels<para>Tonic change event</para></remarks>
    /// <seealso href="http://purl.org/ontology/af/TonicChange">http://purl.org/ontology/af/TonicChange</seealso>
    let TonicChange = Prefixed_Name(af, "TonicChange") |> PrefixedName
    /// <summary>
    ///   <para>af:TonicSegment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>
    /// 		A classifier for tonics.
    /// 		In case of a "clean cut", instances of such events have one
    /// 		factor. In other cases, this event can have several factors, each associated
    /// 		with a particular confidence using event decomposition.
    /// 	</para>
    /// labels<para>Tonic event</para></remarks>
    /// <seealso href="http://purl.org/ontology/af/TonicSegment">http://purl.org/ontology/af/TonicSegment</seealso>
    let TonicSegment = Prefixed_Name(af, "TonicSegment") |> PrefixedName
    /// <summary>
    ///   <para>af:ZeroCrossingCount</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>
    /// 		Zero-crossing counts
    /// 	</para>
    /// labels<para>Zero-crossing counts</para></remarks>
    /// <seealso href="http://purl.org/ontology/af/ZeroCrossingCount">http://purl.org/ontology/af/ZeroCrossingCount</seealso>
    let ZeroCrossingCount = Prefixed_Name(af, "ZeroCrossingCount") |> PrefixedName
    /// <summary>
    ///   <para>af:confidence</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>
    /// 		A really generic property, allowing to associate a confidence to a document or to a particular
    /// 		resource (such as an automatically detected segment)
    /// 		</para>
    /// labels<para>confidence</para></remarks>
    /// <seealso href="http://purl.org/ontology/af/confidence">http://purl.org/ontology/af/confidence</seealso>
    let confidence = Prefixed_Name(af, "confidence") |> PrefixedName
    /// <summary>
    ///   <para>af:TonalOnset</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A pitched onset</para>
    /// labels<para>Pitched onset</para></remarks>
    /// <seealso href="http://purl.org/ontology/af/TonalOnset">http://purl.org/ontology/af/TonalOnset</seealso>
    let TonalOnset = Prefixed_Name(af, "TonalOnset") |> PrefixedName
    /// <summary>
    ///   <para>af:ZeroCrossing</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Classifier for a zero-crossing point</para>
    /// labels<para>Zero crossing</para></remarks>
    /// <seealso href="http://purl.org/ontology/af/ZeroCrossing">http://purl.org/ontology/af/ZeroCrossing</seealso>
    let ZeroCrossing = Prefixed_Name(af, "ZeroCrossing") |> PrefixedName
    /// <summary>
    ///   <para>af:feature</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>
    /// 		Associates a segment classifying a feature to the actual feature---we should use mpeg7 sort-of datatypes here
    /// 		</para>
    /// labels<para>feature</para></remarks>
    /// <seealso href="http://purl.org/ontology/af/feature">http://purl.org/ontology/af/feature</seealso>
    let feature = Prefixed_Name(af, "feature") |> PrefixedName
    /// <summary>
    ///   <para>af:idiom</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>
    /// 		Associates a segment which classify an idiom (English with Irish accent, etc.) to an actual idiom
    /// 		</para>
    /// </remarks>
    /// <seealso href="http://purl.org/ontology/af/idiom">http://purl.org/ontology/af/idiom</seealso>
    let idiom = Prefixed_Name(af, "idiom") |> PrefixedName
    /// <summary>
    ///   <para>af:austrian_german</para>
    /// </summary>
    /// <remarks>
    ///   <para>af:GermanIdiom</para>
    /// </remarks>
    /// <seealso href="http://purl.org/ontology/af/austrian_german">http://purl.org/ontology/af/austrian_german</seealso>
    let austrian_german = Prefixed_Name(af, "austrian_german") |> PrefixedName
    /// <summary>
    ///   <para>af:emotional_intensity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>
    /// 		Associates an "emotional intensity" value to a
    /// 		segment detected as being "emotional"
    /// 		</para>
    /// labels<para>emotional intensity</para></remarks>
    /// <seealso href="http://purl.org/ontology/af/emotional_intensity">http://purl.org/ontology/af/emotional_intensity</seealso>
    let emotional_intensity = Prefixed_Name(af, "emotional_intensity") |> PrefixedName

    /// <summary>
    ///   <para>af:english_scottish_accent</para>
    /// </summary>
    /// <remarks>
    ///   <para>af:EnglishIdiom</para>
    /// </remarks>
    /// <seealso href="http://purl.org/ontology/af/english_scottish_accent">http://purl.org/ontology/af/english_scottish_accent</seealso>
    let english_scottish_accent =
        Prefixed_Name(af, "english_scottish_accent") |> PrefixedName

    /// <summary>
    ///   <para>af:key</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Associates a key event to the corresponding key</para>
    /// labels<para>key</para></remarks>
    /// <seealso href="http://purl.org/ontology/af/key">http://purl.org/ontology/af/key</seealso>
    let key = Prefixed_Name(af, "key") |> PrefixedName
    /// <summary>
    ///   <para>af:new_mode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Mode that holds after the mode change event</para>
    /// labels<para>new mode</para></remarks>
    /// <seealso href="http://purl.org/ontology/af/new_mode">http://purl.org/ontology/af/new_mode</seealso>
    let new_mode = Prefixed_Name(af, "new_mode") |> PrefixedName
    /// <summary>
    ///   <para>af:new_tonic</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Tonic that holds after the tonic change event</para>
    /// labels<para>new tonic</para></remarks>
    /// <seealso href="http://purl.org/ontology/af/new_tonic">http://purl.org/ontology/af/new_tonic</seealso>
    let new_tonic = Prefixed_Name(af, "new_tonic") |> PrefixedName
    /// <summary>
    ///   <para>af:dimensions</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>
    /// 		Associates a signal with its dimensions, eg. "12 3546". Equivalent to the mpeg7:dim attribute of the mpeg7:Raw
    /// 		element.
    /// 	</para>
    /// labels<para>dimensions</para></remarks>
    /// <seealso href="http://purl.org/ontology/af/dimensions">http://purl.org/ontology/af/dimensions</seealso>
    let dimensions = Prefixed_Name(af, "dimensions") |> PrefixedName
    /// <summary>
    ///   <para>af:english_irish_accent</para>
    /// </summary>
    /// <remarks>
    ///   <para>af:EnglishIdiom</para>
    /// </remarks>
    /// <seealso href="http://purl.org/ontology/af/english_irish_accent">http://purl.org/ontology/af/english_irish_accent</seealso>
    let english_irish_accent = Prefixed_Name(af, "english_irish_accent") |> PrefixedName
    /// <summary>
    ///   <para>af:Amplitude</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>
    /// 		Result of an amplitude following process
    /// 	</para>
    /// labels<para>Amplitude</para></remarks>
    /// <seealso href="http://purl.org/ontology/af/Amplitude">http://purl.org/ontology/af/Amplitude</seealso>
    let Amplitude = Prefixed_Name(af, "Amplitude") |> PrefixedName
    /// <summary>
    ///   <para>af:Beat</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A beat event (instantaneous)</para>
    /// labels<para>Beat event</para></remarks>
    /// <seealso href="http://purl.org/ontology/af/Beat">http://purl.org/ontology/af/Beat</seealso>
    let Beat = Prefixed_Name(af, "Beat") |> PrefixedName
    /// <summary>
    ///   <para>af:ChordSegment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>
    /// 		A classifier for chords. Equivalent concept as the one
    /// 		in the Chord ontology.
    /// 	</para>
    /// </remarks>
    /// <seealso href="http://purl.org/ontology/af/ChordSegment">http://purl.org/ontology/af/ChordSegment</seealso>
    let ChordSegment = Prefixed_Name(af, "ChordSegment") |> PrefixedName
    /// <summary>
    ///   <para>af:DetectionFunction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>
    /// 		A detection function.
    /// 	</para>
    /// labels<para>Detection function</para></remarks>
    /// <seealso href="http://purl.org/ontology/af/DetectionFunction">http://purl.org/ontology/af/DetectionFunction</seealso>
    let DetectionFunction = Prefixed_Name(af, "DetectionFunction") |> PrefixedName
    /// <summary>
    ///   <para>af:SpeechSegment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>
    /// 		A classifier capturing the notion of an audio segment holding speech
    /// 		content
    /// 		</para>
    /// labels<para>Speech</para></remarks>
    /// <seealso href="http://purl.org/ontology/af/SpeechSegment">http://purl.org/ontology/af/SpeechSegment</seealso>
    let SpeechSegment = Prefixed_Name(af, "SpeechSegment") |> PrefixedName
    /// <summary>
    ///   <para>af:EnglishIdiom</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>
    /// 		English idiom
    /// 		</para>
    /// labels<para>English idiom</para></remarks>
    /// <seealso href="http://purl.org/ontology/af/EnglishIdiom">http://purl.org/ontology/af/EnglishIdiom</seealso>
    let EnglishIdiom = Prefixed_Name(af, "EnglishIdiom") |> PrefixedName
    /// <summary>
    ///   <para>af:HungarianIdiom</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Hungarian idiom</para>
    /// labels<para>Hungarian idiom</para></remarks>
    /// <seealso href="http://purl.org/ontology/af/HungarianIdiom">http://purl.org/ontology/af/HungarianIdiom</seealso>
    let HungarianIdiom = Prefixed_Name(af, "HungarianIdiom") |> PrefixedName
    /// <summary>
    ///   <para>af:KeyChange</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A key change event. The factor of such an event captures the key that holds after that event.</para>
    /// labels<para>Key change event</para></remarks>
    /// <seealso href="http://purl.org/ontology/af/KeyChange">http://purl.org/ontology/af/KeyChange</seealso>
    let KeyChange = Prefixed_Name(af, "KeyChange") |> PrefixedName
    /// <summary>
    ///   <para>af:KeySegment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>
    /// 		A classifier for keys.
    /// 		In case of a "clean cut", instances of such events
    /// 		should have one factor: the detected key (perhaps using the
    /// 		key ontology at http://purl.org/NET/c4dm/keys.owl).
    /// 		In other cases, we can put several keys as a factor, maybe with different confidence
    /// 		factors, using event decomposition.
    /// 		</para>
    /// labels<para>Key event</para></remarks>
    /// <seealso href="http://purl.org/ontology/af/KeySegment">http://purl.org/ontology/af/KeySegment</seealso>
    let KeySegment = Prefixed_Name(af, "KeySegment") |> PrefixedName
