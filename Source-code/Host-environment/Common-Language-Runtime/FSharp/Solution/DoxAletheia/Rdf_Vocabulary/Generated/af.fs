namespace http.purl.org.ontology.af.slash

open DoxAletheia

module af =
    let _namespace_name = "http://purl.org/ontology/af/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///
    /// 		Result of an amplitude following process
    ///
    /// <see href="http://purl.org/ontology/af/Amplitude"></see></summary>
    let Amplitude = _prefix "Amplitude"
    /// <summary>
    ///
    /// 		A signal-like feature, holding dense data describing another signal.
    /// 		Examples of signal features include chromagrams, spectrograms, onset detection functions etc.
    ///
    /// <see href="http://purl.org/ontology/af/Signal"></see></summary>
    let Signal = _prefix "Signal"
    /// <summary>
    /// A beat event (instantaneous)
    /// <see href="http://purl.org/ontology/af/Beat"></see></summary>
    let Beat = _prefix "Beat"
    /// <summary>
    ///
    /// 		A classifier for instants corresponding to the output of an automatic process---an
    /// 		artificial cognitive agent (should be associated to a time:Instant---DL version).
    ///
    /// <see href="http://purl.org/ontology/af/Point"></see></summary>
    let Point = _prefix "Point"
    /// <summary>
    ///
    /// 		A classifier for chords. Equivalent concept as the one
    /// 		in the Chord ontology.
    ///
    /// <see href="http://purl.org/ontology/af/ChordSegment"></see></summary>
    let ChordSegment = _prefix "ChordSegment"
    /// <summary>
    ///
    /// 		A classifier capturing the notion of an audio segment holding music.
    /// 		This classifier can be subsumed with more specific classifiers.
    ///
    /// <see href="http://purl.org/ontology/af/MusicSegment"></see></summary>
    let MusicSegment = _prefix "MusicSegment"
    /// <summary>
    ///
    /// 		A chromagram feature.
    ///
    /// <see href="http://purl.org/ontology/af/Chromagram"></see></summary>
    let Chromagram = _prefix "Chromagram"
    /// <summary>
    ///
    /// 		A detection function.
    ///
    /// <see href="http://purl.org/ontology/af/DetectionFunction"></see></summary>
    let DetectionFunction = _prefix "DetectionFunction"
    /// <summary>
    ///
    /// 		A classifier for emotional content
    ///
    /// <see href="http://purl.org/ontology/af/EmotionSegment"></see></summary>
    let EmotionSegment = _prefix "EmotionSegment"
    /// <summary>
    ///
    /// 		A classifier capturing the notion of an audio segment holding speech
    /// 		content
    ///
    /// <see href="http://purl.org/ontology/af/SpeechSegment"></see></summary>
    let SpeechSegment = _prefix "SpeechSegment"
    /// <summary>
    ///
    /// 		English idiom
    ///
    /// <see href="http://purl.org/ontology/af/EnglishIdiom"></see></summary>
    let EnglishIdiom = _prefix "EnglishIdiom"
    /// <summary>
    ///
    /// 		German idiom
    ///
    /// <see href="http://purl.org/ontology/af/GermanIdiom"></see></summary>
    let GermanIdiom = _prefix "GermanIdiom"
    /// <summary>
    /// Hungarian idiom
    /// <see href="http://purl.org/ontology/af/HungarianIdiom"></see></summary>
    let HungarianIdiom = _prefix "HungarianIdiom"
    /// <summary>
    ///
    /// 		Idiom (English with Irish accent, Austrian German, etc.)
    ///
    /// <see href="http://purl.org/ontology/af/Idiom"></see></summary>
    let Idiom = _prefix "Idiom"
    /// <summary>
    ///
    /// 		A classifier for recognized idiom (English with Irish accent, etc.)
    ///
    /// <see href="http://purl.org/ontology/af/IdiomSegment"></see></summary>
    let IdiomSegment = _prefix "IdiomSegment"
    /// <summary>
    /// A key change event. The factor of such an event captures the key that holds after that event.
    /// <see href="http://purl.org/ontology/af/KeyChange"></see></summary>
    let KeyChange = _prefix "KeyChange"
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
    let KeySegment = _prefix "KeySegment"
    /// <summary>
    ///
    /// 		A classifier for laugh content
    ///
    /// <see href="http://purl.org/ontology/af/Laugh"></see></summary>
    let Laugh = _prefix "Laugh"
    /// <summary>
    ///
    /// 		Log-frequency spectral centroid
    ///
    /// <see href="http://purl.org/ontology/af/LinearFrequencyCentroid"></see></summary>
    let LinearFrequencyCentroid = _prefix "LinearFrequencyCentroid"
    /// <summary>
    ///
    /// 		Spectral centroid
    ///
    /// <see href="http://purl.org/ontology/af/SpectralCentroid"></see></summary>
    let SpectralCentroid = _prefix "SpectralCentroid"
    /// <summary>
    ///
    /// 		Log-frequency spectral centroid
    ///
    /// <see href="http://purl.org/ontology/af/LogFrequencyCentroid"></see></summary>
    let LogFrequencyCentroid = _prefix "LogFrequencyCentroid"
    /// <summary>
    /// Event holding a loudness value
    /// <see href="http://purl.org/ontology/af/Loudness"></see></summary>
    let Loudness = _prefix "Loudness"
    /// <summary>
    ///
    /// 		A classifier for a major mode region.
    /// 		In case of a "clean cut", instances of such events have one
    ///                 factor. In other cases, this event can have several factors, each associated
    ///                 with a particular confidence using event decomposition.
    ///
    /// <see href="http://purl.org/ontology/af/Major"></see></summary>
    let Major = _prefix "Major"
    /// <summary>
    ///
    /// 		A classifier for a minor mode region.
    /// 		In case of a "clean cut", instances of such events have one
    ///                 factor. In other cases, this event can have several factors, each associated
    ///                 with a particular confidence using event decomposition.
    ///
    /// <see href="http://purl.org/ontology/af/Minor"></see></summary>
    let Minor = _prefix "Minor"
    /// <summary>
    /// A mode change event. The factors of such events include the mode that holds after the event.
    /// <see href="http://purl.org/ontology/af/ModeChange"></see></summary>
    let ModeChange = _prefix "ModeChange"
    /// <summary>
    ///
    /// 		A classifier trying to capture the notion of structure in an audio piece.
    /// 		This classifier should be subsumed by more specific classifiers: speech/music
    /// 		segmentation, structural music segmmentation (intro, verse, chorus, etc.).
    ///
    /// <see href="http://purl.org/ontology/af/StructuralSegment"></see></summary>
    let StructuralSegment = _prefix "StructuralSegment"
    /// <summary>
    ///
    /// 		Classifier capturing the notion of chorus, verse, intro, bridge, phrase, etc.
    ///
    /// <see href="http://purl.org/ontology/af/MusicStructuralSegment"></see></summary>
    let MusicStructuralSegment = _prefix "MusicStructuralSegment"
    /// <summary>
    /// A percussive onset
    /// <see href="http://purl.org/ontology/af/NonTonalOnset"></see></summary>
    let NonTonalOnset = _prefix "NonTonalOnset"
    /// <summary>
    ///
    /// 		A classifier corresponding to the output of an onset detection process.
    ///
    /// <see href="http://purl.org/ontology/af/Onset"></see></summary>
    let Onset = _prefix "Onset"
    /// <summary>
    ///
    /// 		An onset detection function
    ///
    /// <see href="http://purl.org/ontology/af/OnsetDetectionFunction"></see></summary>
    let OnsetDetectionFunction = _prefix "OnsetDetectionFunction"
    /// <summary>
    /// Classifying a temporal region holding a musical ornament
    /// <see href="http://purl.org/ontology/af/Ornament"></see></summary>
    let Ornament = _prefix "Ornament"
    /// <summary>
    ///
    /// 			A classifier associating a FOAF description to a particular segment
    /// 			(to classify genre, recognized speaker, etc.)
    ///
    /// <see href="http://purl.org/ontology/af/PersonSpeaking"></see></summary>
    let PersonSpeaking = _prefix "PersonSpeaking"
    /// <summary>
    /// Associate a point to a particular pitch
    /// Event holding a pitch value (for example coming from a monophonic transcription process)
    /// <see href="http://purl.org/ontology/af/Pitch"></see></summary>
    let Pitch = _prefix "Pitch"
    /// <summary>
    ///
    /// 		A classifier for a temporal region corresponding to the output
    /// 		of an automatic process---an artificial cognitive agent.
    ///
    /// <see href="http://purl.org/ontology/af/Segment"></see></summary>
    let Segment = _prefix "Segment"
    /// <summary>
    /// Event holding a tempo value (120bpm...)
    /// <see href="http://purl.org/ontology/af/Tempo"></see></summary>
    let Tempo = _prefix "Tempo"
    /// <summary>
    ///
    /// 		A tempo detection function
    ///
    /// <see href="http://purl.org/ontology/af/TempoDetectionFunction"></see></summary>
    let TempoDetectionFunction = _prefix "TempoDetectionFunction"
    /// <summary>
    ///
    /// 		A classifier allowing to associate some text to a segment
    ///
    /// <see href="http://purl.org/ontology/af/Text"></see></summary>
    let Text = _prefix "Text"
    /// <summary>
    /// Classifying a temporal region with a particular time signature (what? there is something else than 4/4?? :-)
    /// <see href="http://purl.org/ontology/af/TimeSignature"></see></summary>
    let TimeSignature = _prefix "TimeSignature"
    /// <summary>
    /// A tonal change event.
    /// <see href="http://purl.org/ontology/af/TonalChange"></see></summary>
    let TonalChange = _prefix "TonalChange"
    /// <summary>
    ///
    /// 		A tonal change detection function
    ///
    /// <see href="http://purl.org/ontology/af/TonalChangeDetectionFunction"></see></summary>
    let TonalChangeDetectionFunction = _prefix "TonalChangeDetectionFunction"
    /// <summary>
    ///
    /// 		A 6-D tonal content space
    ///
    /// <see href="http://purl.org/ontology/af/TonalContentSpace"></see></summary>
    let TonalContentSpace = _prefix "TonalContentSpace"
    /// <summary>
    /// A pitched onset
    /// <see href="http://purl.org/ontology/af/TonalOnset"></see></summary>
    let TonalOnset = _prefix "TonalOnset"
    /// <summary>
    /// A tonic change event. The factors of such events include the tonic that holds after the event.
    /// <see href="http://purl.org/ontology/af/TonicChange"></see></summary>
    let TonicChange = _prefix "TonicChange"
    /// <summary>
    ///
    /// 		A classifier for tonics.
    /// 		In case of a "clean cut", instances of such events have one
    /// 		factor. In other cases, this event can have several factors, each associated
    /// 		with a particular confidence using event decomposition.
    ///
    /// <see href="http://purl.org/ontology/af/TonicSegment"></see></summary>
    let TonicSegment = _prefix "TonicSegment"
    /// <summary>
    /// Classifier for a zero-crossing point
    /// <see href="http://purl.org/ontology/af/ZeroCrossing"></see></summary>
    let ZeroCrossing = _prefix "ZeroCrossing"
    /// <summary>
    ///
    /// 		Zero-crossing counts
    ///
    /// <see href="http://purl.org/ontology/af/ZeroCrossingCount"></see></summary>
    let ZeroCrossingCount = _prefix "ZeroCrossingCount"
    /// <summary>
    ///   <see href="http://purl.org/ontology/af/austrian_german"></see>
    /// </summary>
    let austrian_german = _prefix "austrian_german"
    /// <summary>
    ///
    /// 		A really generic property, allowing to associate a confidence to a document or to a particular
    /// 		resource (such as an automatically detected segment)
    ///
    /// <see href="http://purl.org/ontology/af/confidence"></see></summary>
    let confidence = _prefix "confidence"
    /// <summary>
    ///
    /// 		Associates a signal with its dimensions, eg. "12 3546". Equivalent to the mpeg7:dim attribute of the mpeg7:Raw
    /// 		element.
    ///
    /// <see href="http://purl.org/ontology/af/dimensions"></see></summary>
    let dimensions = _prefix "dimensions"
    /// <summary>
    ///
    /// 		Associates an "emotional intensity" value to a
    /// 		segment detected as being "emotional"
    ///
    /// <see href="http://purl.org/ontology/af/emotional_intensity"></see></summary>
    let emotional_intensity = _prefix "emotional_intensity"
    /// <summary>
    ///   <see href="http://purl.org/ontology/af/english_irish_accent"></see>
    /// </summary>
    let english_irish_accent = _prefix "english_irish_accent"
    /// <summary>
    ///   <see href="http://purl.org/ontology/af/english_scottish_accent"></see>
    /// </summary>
    let english_scottish_accent = _prefix "english_scottish_accent"
    /// <summary>
    ///
    /// 		Associates a segment classifying a feature to the actual feature---we should use mpeg7 sort-of datatypes here
    ///
    /// <see href="http://purl.org/ontology/af/feature"></see></summary>
    let feature = _prefix "feature"
    /// <summary>
    ///
    /// 		Associates a segment which classify an idiom (English with Irish accent, etc.) to an actual idiom
    ///
    /// <see href="http://purl.org/ontology/af/idiom"></see></summary>
    let idiom = _prefix "idiom"
    /// <summary>
    /// Associates a key event to the corresponding key
    /// <see href="http://purl.org/ontology/af/key"></see></summary>
    let key = _prefix "key"
    /// <summary>
    /// Associates a key change event to the new key, holding after the change
    /// <see href="http://purl.org/ontology/af/new_key"></see></summary>
    let new_key = _prefix "new_key"
    /// <summary>
    /// Mode that holds after the mode change event
    /// <see href="http://purl.org/ontology/af/new_mode"></see></summary>
    let new_mode = _prefix "new_mode"
    /// <summary>
    ///   <see href="http://purl.org/ontology/af/ModeChangeEvent"></see>
    /// </summary>
    let ModeChangeEvent = _prefix "ModeChangeEvent"
    /// <summary>
    /// Tonic that holds after the tonic change event
    /// <see href="http://purl.org/ontology/af/new_tonic"></see></summary>
    let new_tonic = _prefix "new_tonic"
    /// <summary>
    ///   <see href="http://purl.org/ontology/af/TonicChangeEvent"></see>
    /// </summary>
    let TonicChangeEvent = _prefix "TonicChangeEvent"
    /// <summary>
    ///
    /// 		Associates a segment classified as holding speech content to a FOAF
    /// 		profile (maybe holding information about genre, recognized speaker URI, etc.)
    ///
    /// <see href="http://purl.org/ontology/af/person"></see></summary>
    let person = _prefix "person"
    /// <summary>
    ///   <see href="http://purl.org/ontology/af/PersonSegment"></see>
    /// </summary>
    let PersonSegment = _prefix "PersonSegment"
    /// <summary>
    ///
    /// 		Associates a pitch event to the corresponding pitch
    ///
    /// <see href="http://purl.org/ontology/af/pitch"></see></summary>
    let pitch = _prefix "pitch"
    /// <summary>
    ///
    /// 		Associates an audio signal with a track-level signal feature.
    /// 		eg. a spectrogram, a chromagram, an onset detection function.
    ///
    /// <see href="http://purl.org/ontology/af/signal_feature"></see></summary>
    let signal_feature = _prefix "signal_feature"
    /// <summary>
    ///   <see href="http://purl.org/ontology/af/standard_british_english"></see>
    /// </summary>
    let standard_british_english = _prefix "standard_british_english"
    /// <summary>
    ///   <see href="http://purl.org/ontology/af/standard_german"></see>
    /// </summary>
    let standard_german = _prefix "standard_german"
    /// <summary>
    ///   <see href="http://purl.org/ontology/af/standard_hungarian"></see>
    /// </summary>
    let standard_hungarian = _prefix "standard_hungarian"
    /// <summary>
    ///   <see href="http://purl.org/ontology/af/standard_us_english"></see>
    /// </summary>
    let standard_us_english = _prefix "standard_us_english"
    /// <summary>
    ///   <see href="http://purl.org/ontology/af/swiss_german"></see>
    /// </summary>
    let swiss_german = _prefix "swiss_german"
    /// <summary>
    ///
    /// 		Associates a tempo event to the corresponding tempo value.
    ///
    /// <see href="http://purl.org/ontology/af/tempo"></see></summary>
    let tempo = _prefix "tempo"
    /// <summary>
    ///
    /// 		Relates a Text segment (classifying a time interval that can
    /// 		be associated to some text) to a text string or other literals (number, etc.)
    ///
    /// <see href="http://purl.org/ontology/af/text"></see></summary>
    let text = _prefix "text"
    /// <summary>
    /// Associates a tonic event with the corresponding tonic
    /// <see href="http://purl.org/ontology/af/tonic"></see></summary>
    let tonic = _prefix "tonic"
    /// <summary>
    ///
    /// 		Associates a signal resource as defined in the Music Ontology to a literal: its actual value.
    /// 		For example, it can be used to link an onset detection function to a list of values.
    ///
    /// <see href="http://purl.org/ontology/af/value"></see></summary>
    let value = _prefix "value"
