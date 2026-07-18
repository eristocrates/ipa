namespace http.purl.org.ontology.af.slash

open DoxAletheia.Rdf_Vocabulary

module af =
    let _namespace_name = "http://purl.org/ontology/af/"
    /// <summary>
    ///
    /// 		Result of an amplitude following process
    ///
    /// <see href="http://purl.org/ontology/af/Amplitude"></see></summary>
    let Amplitude = Namespaced_IRI.parse _namespace_name "Amplitude" |> NamespacedName
    /// <summary>
    ///
    /// 		A signal-like feature, holding dense data describing another signal.
    /// 		Examples of signal features include chromagrams, spectrograms, onset detection functions etc.
    ///
    /// <see href="http://purl.org/ontology/af/Signal"></see></summary>
    let Signal = Namespaced_IRI.parse _namespace_name "Signal" |> NamespacedName
    /// <summary>
    /// A beat event (instantaneous)
    /// <see href="http://purl.org/ontology/af/Beat"></see></summary>
    let Beat = Namespaced_IRI.parse _namespace_name "Beat" |> NamespacedName
    /// <summary>
    ///
    /// 		A classifier for instants corresponding to the output of an automatic process---an
    /// 		artificial cognitive agent (should be associated to a time:Instant---DL version).
    ///
    /// <see href="http://purl.org/ontology/af/Point"></see></summary>
    let Point = Namespaced_IRI.parse _namespace_name "Point" |> NamespacedName

    /// <summary>
    ///
    /// 		A classifier for chords. Equivalent concept as the one
    /// 		in the Chord ontology.
    ///
    /// <see href="http://purl.org/ontology/af/ChordSegment"></see></summary>
    let ChordSegment =
        Namespaced_IRI.parse _namespace_name "ChordSegment" |> NamespacedName

    /// <summary>
    ///
    /// 		A classifier capturing the notion of an audio segment holding music.
    /// 		This classifier can be subsumed with more specific classifiers.
    ///
    /// <see href="http://purl.org/ontology/af/MusicSegment"></see></summary>
    let MusicSegment =
        Namespaced_IRI.parse _namespace_name "MusicSegment" |> NamespacedName

    /// <summary>
    ///
    /// 		A chromagram feature.
    ///
    /// <see href="http://purl.org/ontology/af/Chromagram"></see></summary>
    let Chromagram = Namespaced_IRI.parse _namespace_name "Chromagram" |> NamespacedName

    /// <summary>
    ///
    /// 		A detection function.
    ///
    /// <see href="http://purl.org/ontology/af/DetectionFunction"></see></summary>
    let DetectionFunction =
        Namespaced_IRI.parse _namespace_name "DetectionFunction" |> NamespacedName

    /// <summary>
    ///
    /// 		A classifier for emotional content
    ///
    /// <see href="http://purl.org/ontology/af/EmotionSegment"></see></summary>
    let EmotionSegment =
        Namespaced_IRI.parse _namespace_name "EmotionSegment" |> NamespacedName

    /// <summary>
    ///
    /// 		A classifier capturing the notion of an audio segment holding speech
    /// 		content
    ///
    /// <see href="http://purl.org/ontology/af/SpeechSegment"></see></summary>
    let SpeechSegment =
        Namespaced_IRI.parse _namespace_name "SpeechSegment" |> NamespacedName

    /// <summary>
    ///
    /// 		English idiom
    ///
    /// <see href="http://purl.org/ontology/af/EnglishIdiom"></see></summary>
    let EnglishIdiom =
        Namespaced_IRI.parse _namespace_name "EnglishIdiom" |> NamespacedName

    /// <summary>
    ///
    /// 		German idiom
    ///
    /// <see href="http://purl.org/ontology/af/GermanIdiom"></see></summary>
    let GermanIdiom =
        Namespaced_IRI.parse _namespace_name "GermanIdiom" |> NamespacedName

    /// <summary>
    /// Hungarian idiom
    /// <see href="http://purl.org/ontology/af/HungarianIdiom"></see></summary>
    let HungarianIdiom =
        Namespaced_IRI.parse _namespace_name "HungarianIdiom" |> NamespacedName

    /// <summary>
    ///
    /// 		Idiom (English with Irish accent, Austrian German, etc.)
    ///
    /// <see href="http://purl.org/ontology/af/Idiom"></see></summary>
    let Idiom = Namespaced_IRI.parse _namespace_name "Idiom" |> NamespacedName

    /// <summary>
    ///
    /// 		A classifier for recognized idiom (English with Irish accent, etc.)
    ///
    /// <see href="http://purl.org/ontology/af/IdiomSegment"></see></summary>
    let IdiomSegment =
        Namespaced_IRI.parse _namespace_name "IdiomSegment" |> NamespacedName

    /// <summary>
    /// A key change event. The factor of such an event captures the key that holds after that event.
    /// <see href="http://purl.org/ontology/af/KeyChange"></see></summary>
    let KeyChange = Namespaced_IRI.parse _namespace_name "KeyChange" |> NamespacedName
    /// <summary>
    ///
    /// 		A classifier for keys.
    /// 		In case of a "clean cut", instances of such events
    /// 		should have one factor: the detected key (perhaps using the
    /// 		key ontology at http://purl.org/NET/c4dm/keys.owl).
    /// 		In other cases, we can put several keys as a factor, maybe with different confidence
    /// 		factors, using event decomposition.
    ///
    /// <see href="http://purl.org/ontology/af/KeySegment"></see></summary>
    let KeySegment = Namespaced_IRI.parse _namespace_name "KeySegment" |> NamespacedName
    /// <summary>
    ///
    /// 		A classifier for laugh content
    ///
    /// <see href="http://purl.org/ontology/af/Laugh"></see></summary>
    let Laugh = Namespaced_IRI.parse _namespace_name "Laugh" |> NamespacedName

    /// <summary>
    ///
    /// 		Log-frequency spectral centroid
    ///
    /// <see href="http://purl.org/ontology/af/LinearFrequencyCentroid"></see></summary>
    let LinearFrequencyCentroid =
        Namespaced_IRI.parse _namespace_name "LinearFrequencyCentroid" |> NamespacedName

    /// <summary>
    ///
    /// 		Spectral centroid
    ///
    /// <see href="http://purl.org/ontology/af/SpectralCentroid"></see></summary>
    let SpectralCentroid =
        Namespaced_IRI.parse _namespace_name "SpectralCentroid" |> NamespacedName

    /// <summary>
    ///
    /// 		Log-frequency spectral centroid
    ///
    /// <see href="http://purl.org/ontology/af/LogFrequencyCentroid"></see></summary>
    let LogFrequencyCentroid =
        Namespaced_IRI.parse _namespace_name "LogFrequencyCentroid" |> NamespacedName

    /// <summary>
    /// Event holding a loudness value
    /// <see href="http://purl.org/ontology/af/Loudness"></see></summary>
    let Loudness = Namespaced_IRI.parse _namespace_name "Loudness" |> NamespacedName
    /// <summary>
    ///
    /// 		A classifier for a major mode region.
    /// 		In case of a "clean cut", instances of such events have one
    ///                 factor. In other cases, this event can have several factors, each associated
    ///                 with a particular confidence using event decomposition.
    ///
    /// <see href="http://purl.org/ontology/af/Major"></see></summary>
    let Major = Namespaced_IRI.parse _namespace_name "Major" |> NamespacedName
    /// <summary>
    ///
    /// 		A classifier for a minor mode region.
    /// 		In case of a "clean cut", instances of such events have one
    ///                 factor. In other cases, this event can have several factors, each associated
    ///                 with a particular confidence using event decomposition.
    ///
    /// <see href="http://purl.org/ontology/af/Minor"></see></summary>
    let Minor = Namespaced_IRI.parse _namespace_name "Minor" |> NamespacedName
    /// <summary>
    /// A mode change event. The factors of such events include the mode that holds after the event.
    /// <see href="http://purl.org/ontology/af/ModeChange"></see></summary>
    let ModeChange = Namespaced_IRI.parse _namespace_name "ModeChange" |> NamespacedName

    /// <summary>
    ///
    /// 		A classifier trying to capture the notion of structure in an audio piece.
    /// 		This classifier should be subsumed by more specific classifiers: speech/music
    /// 		segmentation, structural music segmmentation (intro, verse, chorus, etc.).
    ///
    /// <see href="http://purl.org/ontology/af/StructuralSegment"></see></summary>
    let StructuralSegment =
        Namespaced_IRI.parse _namespace_name "StructuralSegment" |> NamespacedName

    /// <summary>
    ///
    /// 		Classifier capturing the notion of chorus, verse, intro, bridge, phrase, etc.
    ///
    /// <see href="http://purl.org/ontology/af/MusicStructuralSegment"></see></summary>
    let MusicStructuralSegment =
        Namespaced_IRI.parse _namespace_name "MusicStructuralSegment" |> NamespacedName

    /// <summary>
    /// A percussive onset
    /// <see href="http://purl.org/ontology/af/NonTonalOnset"></see></summary>
    let NonTonalOnset =
        Namespaced_IRI.parse _namespace_name "NonTonalOnset" |> NamespacedName

    /// <summary>
    ///
    /// 		A classifier corresponding to the output of an onset detection process.
    ///
    /// <see href="http://purl.org/ontology/af/Onset"></see></summary>
    let Onset = Namespaced_IRI.parse _namespace_name "Onset" |> NamespacedName

    /// <summary>
    ///
    /// 		An onset detection function
    ///
    /// <see href="http://purl.org/ontology/af/OnsetDetectionFunction"></see></summary>
    let OnsetDetectionFunction =
        Namespaced_IRI.parse _namespace_name "OnsetDetectionFunction" |> NamespacedName

    /// <summary>
    /// Classifying a temporal region holding a musical ornament
    /// <see href="http://purl.org/ontology/af/Ornament"></see></summary>
    let Ornament = Namespaced_IRI.parse _namespace_name "Ornament" |> NamespacedName

    /// <summary>
    ///
    /// 			A classifier associating a FOAF description to a particular segment
    /// 			(to classify genre, recognized speaker, etc.)
    ///
    /// <see href="http://purl.org/ontology/af/PersonSpeaking"></see></summary>
    let PersonSpeaking =
        Namespaced_IRI.parse _namespace_name "PersonSpeaking" |> NamespacedName

    /// <summary>
    /// Associate a point to a particular pitch
    /// Event holding a pitch value (for example coming from a monophonic transcription process)
    /// <see href="http://purl.org/ontology/af/Pitch"></see></summary>
    let Pitch = Namespaced_IRI.parse _namespace_name "Pitch" |> NamespacedName
    /// <summary>
    ///
    /// 		A classifier for a temporal region corresponding to the output
    /// 		of an automatic process---an artificial cognitive agent.
    ///
    /// <see href="http://purl.org/ontology/af/Segment"></see></summary>
    let Segment = Namespaced_IRI.parse _namespace_name "Segment" |> NamespacedName
    /// <summary>
    /// Event holding a tempo value (120bpm...)
    /// <see href="http://purl.org/ontology/af/Tempo"></see></summary>
    let Tempo = Namespaced_IRI.parse _namespace_name "Tempo" |> NamespacedName

    /// <summary>
    ///
    /// 		A tempo detection function
    ///
    /// <see href="http://purl.org/ontology/af/TempoDetectionFunction"></see></summary>
    let TempoDetectionFunction =
        Namespaced_IRI.parse _namespace_name "TempoDetectionFunction" |> NamespacedName

    /// <summary>
    ///
    /// 		A classifier allowing to associate some text to a segment
    ///
    /// <see href="http://purl.org/ontology/af/Text"></see></summary>
    let Text = Namespaced_IRI.parse _namespace_name "Text" |> NamespacedName

    /// <summary>
    /// Classifying a temporal region with a particular time signature (what? there is something else than 4/4?? :-)
    /// <see href="http://purl.org/ontology/af/TimeSignature"></see></summary>
    let TimeSignature =
        Namespaced_IRI.parse _namespace_name "TimeSignature" |> NamespacedName

    /// <summary>
    /// A tonal change event.
    /// <see href="http://purl.org/ontology/af/TonalChange"></see></summary>
    let TonalChange =
        Namespaced_IRI.parse _namespace_name "TonalChange" |> NamespacedName

    /// <summary>
    ///
    /// 		A tonal change detection function
    ///
    /// <see href="http://purl.org/ontology/af/TonalChangeDetectionFunction"></see></summary>
    let TonalChangeDetectionFunction =
        Namespaced_IRI.parse _namespace_name "TonalChangeDetectionFunction" |> NamespacedName

    /// <summary>
    ///
    /// 		A 6-D tonal content space
    ///
    /// <see href="http://purl.org/ontology/af/TonalContentSpace"></see></summary>
    let TonalContentSpace =
        Namespaced_IRI.parse _namespace_name "TonalContentSpace" |> NamespacedName

    /// <summary>
    /// A pitched onset
    /// <see href="http://purl.org/ontology/af/TonalOnset"></see></summary>
    let TonalOnset = Namespaced_IRI.parse _namespace_name "TonalOnset" |> NamespacedName

    /// <summary>
    /// A tonic change event. The factors of such events include the tonic that holds after the event.
    /// <see href="http://purl.org/ontology/af/TonicChange"></see></summary>
    let TonicChange =
        Namespaced_IRI.parse _namespace_name "TonicChange" |> NamespacedName

    /// <summary>
    ///
    /// 		A classifier for tonics.
    /// 		In case of a "clean cut", instances of such events have one
    /// 		factor. In other cases, this event can have several factors, each associated
    /// 		with a particular confidence using event decomposition.
    ///
    /// <see href="http://purl.org/ontology/af/TonicSegment"></see></summary>
    let TonicSegment =
        Namespaced_IRI.parse _namespace_name "TonicSegment" |> NamespacedName

    /// <summary>
    /// Classifier for a zero-crossing point
    /// <see href="http://purl.org/ontology/af/ZeroCrossing"></see></summary>
    let ZeroCrossing =
        Namespaced_IRI.parse _namespace_name "ZeroCrossing" |> NamespacedName

    /// <summary>
    ///
    /// 		Zero-crossing counts
    ///
    /// <see href="http://purl.org/ontology/af/ZeroCrossingCount"></see></summary>
    let ZeroCrossingCount =
        Namespaced_IRI.parse _namespace_name "ZeroCrossingCount" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/ontology/af/austrian_german"></see>
    /// </summary>
    let austrian_german =
        Namespaced_IRI.parse _namespace_name "austrian_german" |> NamespacedName

    /// <summary>
    ///
    /// 		A really generic property, allowing to associate a confidence to a document or to a particular
    /// 		resource (such as an automatically detected segment)
    ///
    /// <see href="http://purl.org/ontology/af/confidence"></see></summary>
    let confidence = Namespaced_IRI.parse _namespace_name "confidence" |> NamespacedName
    /// <summary>
    ///
    /// 		Associates a signal with its dimensions, eg. "12 3546". Equivalent to the mpeg7:dim attribute of the mpeg7:Raw
    /// 		element.
    ///
    /// <see href="http://purl.org/ontology/af/dimensions"></see></summary>
    let dimensions = Namespaced_IRI.parse _namespace_name "dimensions" |> NamespacedName

    /// <summary>
    ///
    /// 		Associates an "emotional intensity" value to a
    /// 		segment detected as being "emotional"
    ///
    /// <see href="http://purl.org/ontology/af/emotional_intensity"></see></summary>
    let emotional_intensity =
        Namespaced_IRI.parse _namespace_name "emotional_intensity" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/ontology/af/english_irish_accent"></see>
    /// </summary>
    let english_irish_accent =
        Namespaced_IRI.parse _namespace_name "english_irish_accent" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/ontology/af/english_scottish_accent"></see>
    /// </summary>
    let english_scottish_accent =
        Namespaced_IRI.parse _namespace_name "english_scottish_accent" |> NamespacedName

    /// <summary>
    ///
    /// 		Associates a segment classifying a feature to the actual feature---we should use mpeg7 sort-of datatypes here
    ///
    /// <see href="http://purl.org/ontology/af/feature"></see></summary>
    let feature = Namespaced_IRI.parse _namespace_name "feature" |> NamespacedName
    /// <summary>
    ///
    /// 		Associates a segment which classify an idiom (English with Irish accent, etc.) to an actual idiom
    ///
    /// <see href="http://purl.org/ontology/af/idiom"></see></summary>
    let idiom = Namespaced_IRI.parse _namespace_name "idiom" |> NamespacedName
    /// <summary>
    /// Associates a key event to the corresponding key
    /// <see href="http://purl.org/ontology/af/key"></see></summary>
    let key = Namespaced_IRI.parse _namespace_name "key" |> NamespacedName
    /// <summary>
    /// Associates a key change event to the new key, holding after the change
    /// <see href="http://purl.org/ontology/af/new_key"></see></summary>
    let new_key = Namespaced_IRI.parse _namespace_name "new_key" |> NamespacedName
    /// <summary>
    /// Mode that holds after the mode change event
    /// <see href="http://purl.org/ontology/af/new_mode"></see></summary>
    let new_mode = Namespaced_IRI.parse _namespace_name "new_mode" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/ontology/af/ModeChangeEvent"></see>
    /// </summary>
    let ModeChangeEvent =
        Namespaced_IRI.parse _namespace_name "ModeChangeEvent" |> NamespacedName

    /// <summary>
    /// Tonic that holds after the tonic change event
    /// <see href="http://purl.org/ontology/af/new_tonic"></see></summary>
    let new_tonic = Namespaced_IRI.parse _namespace_name "new_tonic" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/ontology/af/TonicChangeEvent"></see>
    /// </summary>
    let TonicChangeEvent =
        Namespaced_IRI.parse _namespace_name "TonicChangeEvent" |> NamespacedName

    /// <summary>
    ///
    /// 		Associates a segment classified as holding speech content to a FOAF
    /// 		profile (maybe holding information about genre, recognized speaker URI, etc.)
    ///
    /// <see href="http://purl.org/ontology/af/person"></see></summary>
    let person = Namespaced_IRI.parse _namespace_name "person" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/ontology/af/PersonSegment"></see>
    /// </summary>
    let PersonSegment =
        Namespaced_IRI.parse _namespace_name "PersonSegment" |> NamespacedName

    /// <summary>
    ///
    /// 		Associates a pitch event to the corresponding pitch
    ///
    /// <see href="http://purl.org/ontology/af/pitch"></see></summary>
    let pitch = Namespaced_IRI.parse _namespace_name "pitch" |> NamespacedName

    /// <summary>
    ///
    /// 		Associates an audio signal with a track-level signal feature.
    /// 		eg. a spectrogram, a chromagram, an onset detection function.
    ///
    /// <see href="http://purl.org/ontology/af/signal_feature"></see></summary>
    let signal_feature =
        Namespaced_IRI.parse _namespace_name "signal_feature" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/ontology/af/standard_british_english"></see>
    /// </summary>
    let standard_british_english =
        Namespaced_IRI.parse _namespace_name "standard_british_english" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/ontology/af/standard_german"></see>
    /// </summary>
    let standard_german =
        Namespaced_IRI.parse _namespace_name "standard_german" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/ontology/af/standard_hungarian"></see>
    /// </summary>
    let standard_hungarian =
        Namespaced_IRI.parse _namespace_name "standard_hungarian" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/ontology/af/standard_us_english"></see>
    /// </summary>
    let standard_us_english =
        Namespaced_IRI.parse _namespace_name "standard_us_english" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/ontology/af/swiss_german"></see>
    /// </summary>
    let swiss_german =
        Namespaced_IRI.parse _namespace_name "swiss_german" |> NamespacedName

    /// <summary>
    ///
    /// 		Associates a tempo event to the corresponding tempo value.
    ///
    /// <see href="http://purl.org/ontology/af/tempo"></see></summary>
    let tempo = Namespaced_IRI.parse _namespace_name "tempo" |> NamespacedName
    /// <summary>
    ///
    /// 		Relates a Text segment (classifying a time interval that can
    /// 		be associated to some text) to a text string or other literals (number, etc.)
    ///
    /// <see href="http://purl.org/ontology/af/text"></see></summary>
    let text = Namespaced_IRI.parse _namespace_name "text" |> NamespacedName
    /// <summary>
    /// Associates a tonic event with the corresponding tonic
    /// <see href="http://purl.org/ontology/af/tonic"></see></summary>
    let tonic = Namespaced_IRI.parse _namespace_name "tonic" |> NamespacedName
    /// <summary>
    ///
    /// 		Associates a signal resource as defined in the Music Ontology to a literal: its actual value.
    /// 		For example, it can be used to link an onset detection function to a list of values.
    ///
    /// <see href="http://purl.org/ontology/af/value"></see></summary>
    let value = Namespaced_IRI.parse _namespace_name "value" |> NamespacedName
