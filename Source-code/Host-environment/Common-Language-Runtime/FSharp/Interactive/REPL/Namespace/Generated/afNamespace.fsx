#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module af =
    let _prefixId = PrefixId.fromNamespaceLabel "http://purl.org/ontology/af/" "af"
    /// <summary>
    ///   <para>rdfs:comment :
    /// 		Result of an amplitude following process
    /// 	^^xsd:string</para>
    ///   <para>rdfs:label : Amplitude^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/af/Amplitude">af:Amplitude</a>
    /// </summary>
    let Amplitude = _prefixId.prefix "Amplitude"
    /// <summary>
    ///   <para>rdfs:comment : A beat event (instantaneous)^^xsd:string</para>
    ///   <para>rdfs:label : Beat event^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/af/Beat">af:Beat</a>
    /// </summary>
    let Beat = _prefixId.prefix "Beat"
    /// <summary>
    ///   <para>rdfs:comment :
    /// 		A classifier for chords. Equivalent concept as the one
    /// 		in the Chord ontology.
    /// 	^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/af/ChordSegment">af:ChordSegment</a>
    /// </summary>
    let ChordSegment = _prefixId.prefix "ChordSegment"
    /// <summary>
    ///   <para>rdfs:comment :
    /// 		A chromagram feature.
    /// 	^^xsd:string</para>
    ///   <para>rdfs:label : Chromagram^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/af/Chromagram">af:Chromagram</a>
    /// </summary>
    let Chromagram = _prefixId.prefix "Chromagram"
    /// <summary>
    ///   <para>rdfs:comment :
    /// 		A detection function.
    /// 	^^xsd:string</para>
    ///   <para>rdfs:label : Detection function^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/af/DetectionFunction">af:DetectionFunction</a>
    /// </summary>
    let DetectionFunction = _prefixId.prefix "DetectionFunction"
    /// <summary>
    ///   <para>rdfs:comment :
    /// 		A classifier for emotional content
    /// 		^^xsd:string</para>
    ///   <para>rdfs:label : Emotion segment^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/af/EmotionSegment">af:EmotionSegment</a>
    /// </summary>
    let EmotionSegment = _prefixId.prefix "EmotionSegment"
    /// <summary>
    ///   <para>rdfs:comment :
    /// 		English idiom
    /// 		^^xsd:string</para>
    ///   <para>rdfs:label : English idiom^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/af/EnglishIdiom">af:EnglishIdiom</a>
    /// </summary>
    let EnglishIdiom = _prefixId.prefix "EnglishIdiom"
    /// <summary>
    ///   <para>rdfs:comment :
    /// 		German idiom
    /// 		^^xsd:string</para>
    ///   <para>rdfs:label : German idiom^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/af/GermanIdiom">af:GermanIdiom</a>
    /// </summary>
    let GermanIdiom = _prefixId.prefix "GermanIdiom"
    /// <summary>
    ///   <para>rdfs:comment : Hungarian idiom^^xsd:string</para>
    ///   <para>rdfs:label : Hungarian idiom^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/af/HungarianIdiom">af:HungarianIdiom</a>
    /// </summary>
    let HungarianIdiom = _prefixId.prefix "HungarianIdiom"
    /// <summary>
    ///   <para>rdfs:comment :
    /// 		Idiom (English with Irish accent, Austrian German, etc.)
    /// 		^^xsd:string</para>
    ///   <para>rdfs:label : Idiom^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/af/Idiom">af:Idiom</a>
    /// </summary>
    let Idiom = _prefixId.prefix "Idiom"
    /// <summary>
    ///   <para>rdfs:comment :
    /// 		A classifier for recognized idiom (English with Irish accent, etc.)
    /// 		^^xsd:string</para>
    ///   <para>rdfs:label : Idiom segment^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/af/IdiomSegment">af:IdiomSegment</a>
    /// </summary>
    let IdiomSegment = _prefixId.prefix "IdiomSegment"
    /// <summary>
    ///   <para>rdfs:comment : A key change event. The factor of such an event captures the key that holds after that event.^^xsd:string</para>
    ///   <para>rdfs:label : Key change event^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/af/KeyChange">af:KeyChange</a>
    /// </summary>
    let KeyChange = _prefixId.prefix "KeyChange"
    /// <summary>
    ///   <para>rdfs:label : Key event^^xsd:string</para>
    ///   <para>rdfs:comment :
    /// 		A classifier for keys.
    /// 		In case of a "clean cut", instances of such events
    /// 		should have one factor: the detected key (perhaps using the
    /// 		key ontology at http://purl.org/NET/c4dm/keys.owl).
    /// 		In other cases, we can put several keys as a factor, maybe with different confidence
    /// 		factors, using event decomposition.
    /// 		^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/af/KeySegment">af:KeySegment</a>
    /// </summary>
    let KeySegment = _prefixId.prefix "KeySegment"
    /// <summary>
    ///   <para>rdfs:comment :
    /// 		A classifier for laugh content
    /// 		^^xsd:string</para>
    ///   <para>rdfs:label : Laugh^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/af/Laugh">af:Laugh</a>
    /// </summary>
    let Laugh = _prefixId.prefix "Laugh"
    /// <summary>
    ///   <para>rdfs:comment :
    /// 		Log-frequency spectral centroid
    /// 	^^xsd:string</para>
    ///   <para>rdfs:label : Linear-frequency spectral centroid^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/af/LinearFrequencyCentroid">af:LinearFrequencyCentroid</a>
    /// </summary>
    let LinearFrequencyCentroid = _prefixId.prefix "LinearFrequencyCentroid"
    /// <summary>
    ///   <para>rdfs:comment :
    /// 		Log-frequency spectral centroid
    /// 	^^xsd:string</para>
    ///   <para>rdfs:label : Log-frequency spectral centroid^^xsd:string</para>
    ///   <para>vs:term_Status : testing^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/af/LogFrequencyCentroid">af:LogFrequencyCentroid</a>
    /// </summary>
    let LogFrequencyCentroid = _prefixId.prefix "LogFrequencyCentroid"
    /// <summary>
    ///   <para>rdfs:label : Loudness event^^xsd:string</para>
    ///   <para>rdfs:comment : Event holding a loudness value^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/af/Loudness">af:Loudness</a>
    /// </summary>
    let Loudness = _prefixId.prefix "Loudness"
    /// <summary>
    ///   <para>rdfs:label : Major segment^^xsd:string</para>
    ///   <para>rdfs:comment :
    /// 		A classifier for a major mode region.
    /// 		In case of a "clean cut", instances of such events have one
    ///                 factor. In other cases, this event can have several factors, each associated
    ///                 with a particular confidence using event decomposition.
    /// 	^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/af/Major">af:Major</a>
    /// </summary>
    let Major = _prefixId.prefix "Major"
    /// <summary>
    ///   <para>rdfs:label : Minor segment^^xsd:string</para>
    ///   <para>rdfs:comment :
    /// 		A classifier for a minor mode region.
    /// 		In case of a "clean cut", instances of such events have one
    ///                 factor. In other cases, this event can have several factors, each associated
    ///                 with a particular confidence using event decomposition.
    /// 	^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/af/Minor">af:Minor</a>
    /// </summary>
    let Minor = _prefixId.prefix "Minor"
    /// <summary>
    ///   <para>rdfs:comment : A mode change event. The factors of such events include the mode that holds after the event.^^xsd:string</para>
    ///   <para>rdfs:label : Mode change event^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/af/ModeChange">af:ModeChange</a>
    /// </summary>
    let ModeChange = _prefixId.prefix "ModeChange"
    let ModeChangeEvent = _prefixId.prefix "ModeChangeEvent"
    /// <summary>
    ///   <para>rdfs:comment :
    /// 		A classifier capturing the notion of an audio segment holding music.
    /// 		This classifier can be subsumed with more specific classifiers.
    /// 		^^xsd:string</para>
    ///   <para>rdfs:label : Music^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/af/MusicSegment">af:MusicSegment</a>
    /// </summary>
    let MusicSegment = _prefixId.prefix "MusicSegment"
    /// <summary>
    ///   <para>rdfs:comment :
    /// 		Classifier capturing the notion of chorus, verse, intro, bridge, phrase, etc.
    /// 		^^xsd:string</para>
    ///   <para>rdfs:label : Music structural segment^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/af/MusicStructuralSegment">af:MusicStructuralSegment</a>
    /// </summary>
    let MusicStructuralSegment = _prefixId.prefix "MusicStructuralSegment"
    /// <summary>
    ///   <para>rdfs:comment : A percussive onset^^xsd:string</para>
    ///   <para>rdfs:label : Percussive onset^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/af/NonTonalOnset">af:NonTonalOnset</a>
    /// </summary>
    let NonTonalOnset = _prefixId.prefix "NonTonalOnset"
    /// <summary>
    ///   <para>rdfs:comment :
    /// 		A classifier corresponding to the output of an onset detection process.
    /// 		^^xsd:string</para>
    ///   <para>rdfs:label : Onset^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/af/Onset">af:Onset</a>
    /// </summary>
    let Onset = _prefixId.prefix "Onset"
    /// <summary>
    ///   <para>rdfs:comment :
    /// 		An onset detection function
    /// 	^^xsd:string</para>
    ///   <para>rdfs:label : Onset detection function^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/af/OnsetDetectionFunction">af:OnsetDetectionFunction</a>
    /// </summary>
    let OnsetDetectionFunction = _prefixId.prefix "OnsetDetectionFunction"
    /// <summary>
    ///   <para>rdfs:comment : Classifying a temporal region holding a musical ornament^^xsd:string</para>
    ///   <para>rdfs:label : Ornament event^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/af/Ornament">af:Ornament</a>
    /// </summary>
    let Ornament = _prefixId.prefix "Ornament"
    let PersonSegment = _prefixId.prefix "PersonSegment"
    /// <summary>
    ///   <para>rdfs:comment :
    /// 			A classifier associating a FOAF description to a particular segment
    /// 			(to classify genre, recognized speaker, etc.)
    /// 			^^xsd:string</para>
    ///   <para>rdfs:label : Person speaking^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/af/PersonSpeaking">af:PersonSpeaking</a>
    /// </summary>
    let PersonSpeaking = _prefixId.prefix "PersonSpeaking"
    /// <summary>
    ///   <para>rdfs:comment : Associate a point to a particular pitch^^xsd:stringrdfs:comment : Event holding a pitch value (for example coming from a monophonic transcription process)^^xsd:string</para>
    ///   <para>rdfs:label : Pitch event^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/af/Pitch">af:Pitch</a>
    /// </summary>
    let Pitch = _prefixId.prefix "Pitch"
    /// <summary>
    ///   <para>rdfs:comment :
    /// 		A classifier for instants corresponding to the output of an automatic process---an
    /// 		artificial cognitive agent (should be associated to a time:Instant---DL version).
    /// 		^^xsd:string</para>
    ///   <para>rdfs:label : Point^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/af/Point">af:Point</a>
    /// </summary>
    let Point = _prefixId.prefix "Point"
    /// <summary>
    ///   <para>rdfs:comment :
    /// 		A classifier for a temporal region corresponding to the output
    /// 		of an automatic process---an artificial cognitive agent.
    /// 		^^xsd:string</para>
    ///   <para>rdfs:label : Segment^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/af/Segment">af:Segment</a>
    /// </summary>
    let Segment = _prefixId.prefix "Segment"
    /// <summary>
    ///   <para>rdfs:comment :
    /// 		A signal-like feature, holding dense data describing another signal.
    /// 		Examples of signal features include chromagrams, spectrograms, onset detection functions etc.
    /// 	^^xsd:string</para>
    ///   <para>rdfs:label : Signal-level feature^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/af/Signal">af:Signal</a>
    /// </summary>
    let Signal = _prefixId.prefix "Signal"
    /// <summary>
    ///   <para>rdfs:comment :
    /// 		Spectral centroid
    /// 	^^xsd:string</para>
    ///   <para>rdfs:label : Spectral centroid^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/af/SpectralCentroid">af:SpectralCentroid</a>
    /// </summary>
    let SpectralCentroid = _prefixId.prefix "SpectralCentroid"
    /// <summary>
    ///   <para>rdfs:comment :
    /// 		A classifier capturing the notion of an audio segment holding speech
    /// 		content
    /// 		^^xsd:string</para>
    ///   <para>rdfs:label : Speech^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/af/SpeechSegment">af:SpeechSegment</a>
    /// </summary>
    let SpeechSegment = _prefixId.prefix "SpeechSegment"
    /// <summary>
    ///   <para>rdfs:comment :
    /// 		A classifier trying to capture the notion of structure in an audio piece.
    /// 		This classifier should be subsumed by more specific classifiers: speech/music
    /// 		segmentation, structural music segmmentation (intro, verse, chorus, etc.).
    /// 		^^xsd:string</para>
    ///   <para>rdfs:label : Structural Segment^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/af/StructuralSegment">af:StructuralSegment</a>
    /// </summary>
    let StructuralSegment = _prefixId.prefix "StructuralSegment"
    /// <summary>
    ///   <para>rdfs:label : Tempo event^^xsd:string</para>
    ///   <para>rdfs:comment : Event holding a tempo value (120bpm...)^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/af/Tempo">af:Tempo</a>
    /// </summary>
    let Tempo = _prefixId.prefix "Tempo"
    /// <summary>
    ///   <para>rdfs:comment :
    /// 		A tempo detection function
    /// 	^^xsd:string</para>
    ///   <para>rdfs:label : Tempo detection function^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/af/TempoDetectionFunction">af:TempoDetectionFunction</a>
    /// </summary>
    let TempoDetectionFunction = _prefixId.prefix "TempoDetectionFunction"
    /// <summary>
    ///   <para>rdfs:comment :
    /// 		A classifier allowing to associate some text to a segment
    /// 		^^xsd:string</para>
    ///   <para>rdfs:label : Text^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/af/Text">af:Text</a>
    /// </summary>
    let Text = _prefixId.prefix "Text"
    /// <summary>
    ///   <para>rdfs:comment : Classifying a temporal region with a particular time signature (what? there is something else than 4/4?? :-)^^xsd:string</para>
    ///   <para>rdfs:label : Time signature^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/af/TimeSignature">af:TimeSignature</a>
    /// </summary>
    let TimeSignature = _prefixId.prefix "TimeSignature"
    /// <summary>
    ///   <para>rdfs:comment : A tonal change event.^^xsd:string</para>
    ///   <para>rdfs:label : Tonal change event^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/af/TonalChange">af:TonalChange</a>
    /// </summary>
    let TonalChange = _prefixId.prefix "TonalChange"
    /// <summary>
    ///   <para>rdfs:comment :
    /// 		A tonal change detection function
    /// 	^^xsd:string</para>
    ///   <para>rdfs:label : Tonal change detection function^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/af/TonalChangeDetectionFunction">af:TonalChangeDetectionFunction</a>
    /// </summary>
    let TonalChangeDetectionFunction = _prefixId.prefix "TonalChangeDetectionFunction"
    /// <summary>
    ///   <para>rdfs:comment :
    /// 		A 6-D tonal content space
    /// 	^^xsd:string</para>
    ///   <para>rdfs:label : Tonal content space^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/af/TonalContentSpace">af:TonalContentSpace</a>
    /// </summary>
    let TonalContentSpace = _prefixId.prefix "TonalContentSpace"
    /// <summary>
    ///   <para>rdfs:comment : A pitched onset^^xsd:string</para>
    ///   <para>rdfs:label : Pitched onset^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/af/TonalOnset">af:TonalOnset</a>
    /// </summary>
    let TonalOnset = _prefixId.prefix "TonalOnset"
    /// <summary>
    ///   <para>rdfs:comment : A tonic change event. The factors of such events include the tonic that holds after the event.^^xsd:string</para>
    ///   <para>rdfs:label : Tonic change event^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/af/TonicChange">af:TonicChange</a>
    /// </summary>
    let TonicChange = _prefixId.prefix "TonicChange"
    let TonicChangeEvent = _prefixId.prefix "TonicChangeEvent"
    /// <summary>
    ///   <para>rdfs:label : Tonic event^^xsd:string</para>
    ///   <para>rdfs:comment :
    /// 		A classifier for tonics.
    /// 		In case of a "clean cut", instances of such events have one
    /// 		factor. In other cases, this event can have several factors, each associated
    /// 		with a particular confidence using event decomposition.
    /// 	^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/af/TonicSegment">af:TonicSegment</a>
    /// </summary>
    let TonicSegment = _prefixId.prefix "TonicSegment"
    /// <summary>
    ///   <para>rdfs:comment : Classifier for a zero-crossing point^^xsd:string</para>
    ///   <para>rdfs:label : Zero crossing^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/af/ZeroCrossing">af:ZeroCrossing</a>
    /// </summary>
    let ZeroCrossing = _prefixId.prefix "ZeroCrossing"
    /// <summary>
    ///   <para>rdfs:comment :
    /// 		Zero-crossing counts
    /// 	^^xsd:string</para>
    ///   <para>rdfs:label : Zero-crossing counts^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/af/ZeroCrossingCount">af:ZeroCrossingCount</a>
    /// </summary>
    let ZeroCrossingCount = _prefixId.prefix "ZeroCrossingCount"
    let austrian_german = _prefixId.prefix "austrian_german"
    /// <summary>
    ///   <para>rdfs:label : confidence^^xsd:string</para>
    ///   <para>rdfs:comment :
    /// 		A really generic property, allowing to associate a confidence to a document or to a particular
    /// 		resource (such as an automatically detected segment)
    /// 		^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/af/confidence">af:confidence</a>
    /// </summary>
    let confidence = _prefixId.prefix "confidence"
    /// <summary>
    ///   <para>rdfs:comment :
    /// 		Associates a signal with its dimensions, eg. "12 3546". Equivalent to the mpeg7:dim attribute of the mpeg7:Raw
    /// 		element.
    /// 	^^xsd:string</para>
    ///   <para>rdfs:label : dimensions^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/af/dimensions">af:dimensions</a>
    /// </summary>
    let dimensions = _prefixId.prefix "dimensions"
    /// <summary>
    ///   <para>rdfs:label : emotional intensity^^xsd:string</para>
    ///   <para>rdfs:comment :
    /// 		Associates an "emotional intensity" value to a
    /// 		segment detected as being "emotional"
    /// 		^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/af/emotional_intensity">af:emotional_intensity</a>
    /// </summary>
    let emotional_intensity = _prefixId.prefix "emotional_intensity"
    let english_irish_accent = _prefixId.prefix "english_irish_accent"
    let english_scottish_accent = _prefixId.prefix "english_scottish_accent"
    /// <summary>
    ///   <para>rdfs:label : feature^^xsd:string</para>
    ///   <para>rdfs:comment :
    /// 		Associates a segment classifying a feature to the actual feature---we should use mpeg7 sort-of datatypes here
    /// 		^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/af/feature">af:feature</a>
    /// </summary>
    let feature = _prefixId.prefix "feature"
    /// <summary>
    ///   <para>rdfs:comment :
    /// 		Associates a segment which classify an idiom (English with Irish accent, etc.) to an actual idiom
    /// 		^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/af/idiom">af:idiom</a>
    /// </summary>
    let idiom = _prefixId.prefix "idiom"
    /// <summary>
    ///   <para>rdfs:comment : Associates a key event to the corresponding key^^xsd:string</para>
    ///   <para>rdfs:label : key^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/af/key">af:key</a>
    /// </summary>
    let key = _prefixId.prefix "key"
    /// <summary>
    ///   <para>rdfs:comment : Associates a key change event to the new key, holding after the change^^xsd:string</para>
    ///   <para>rdfs:label : new key^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/af/new_key">af:new_key</a>
    /// </summary>
    let new_key = _prefixId.prefix "new_key"
    /// <summary>
    ///   <para>rdfs:comment : Mode that holds after the mode change event^^xsd:string</para>
    ///   <para>rdfs:label : new mode^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/af/new_mode">af:new_mode</a>
    /// </summary>
    let new_mode = _prefixId.prefix "new_mode"
    /// <summary>
    ///   <para>rdfs:comment : Tonic that holds after the tonic change event^^xsd:string</para>
    ///   <para>rdfs:label : new tonic^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/af/new_tonic">af:new_tonic</a>
    /// </summary>
    let new_tonic = _prefixId.prefix "new_tonic"
    /// <summary>
    ///   <para>rdfs:label : person^^xsd:string</para>
    ///   <para>rdfs:comment :
    /// 		Associates a segment classified as holding speech content to a FOAF
    /// 		profile (maybe holding information about genre, recognized speaker URI, etc.)
    /// 		^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/af/person">af:person</a>
    /// </summary>
    let person = _prefixId.prefix "person"
    /// <summary>
    ///   <para>rdfs:comment :
    /// 		Associates a pitch event to the corresponding pitch
    /// 	^^xsd:string</para>
    ///   <para>rdfs:label : pitch^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/af/pitch">af:pitch</a>
    /// </summary>
    let pitch = _prefixId.prefix "pitch"
    /// <summary>
    ///   <para>rdfs:comment :
    /// 		Associates an audio signal with a track-level signal feature.
    /// 		eg. a spectrogram, a chromagram, an onset detection function.
    /// 	^^xsd:string</para>
    ///   <para>rdfs:label : signal-level feature^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/af/signal_feature">af:signal_feature</a>
    /// </summary>
    let signal_feature = _prefixId.prefix "signal_feature"
    let standard_british_english = _prefixId.prefix "standard_british_english"
    let standard_german = _prefixId.prefix "standard_german"
    let standard_hungarian = _prefixId.prefix "standard_hungarian"
    let standard_us_english = _prefixId.prefix "standard_us_english"
    let swiss_german = _prefixId.prefix "swiss_german"
    /// <summary>
    ///   <para>rdfs:comment :
    /// 		Associates a tempo event to the corresponding tempo value.
    /// 	^^xsd:string</para>
    ///   <para>rdfs:label : tempo^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/af/tempo">af:tempo</a>
    /// </summary>
    let tempo = _prefixId.prefix "tempo"
    /// <summary>
    ///   <para>rdfs:comment :
    /// 		Relates a Text segment (classifying a time interval that can
    /// 		be associated to some text) to a text string or other literals (number, etc.)
    /// 		^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/af/text">af:text</a>
    /// </summary>
    let text = _prefixId.prefix "text"
    /// <summary>
    ///   <para>rdfs:comment : Associates a tonic event with the corresponding tonic^^xsd:string</para>
    ///   <para>rdfs:label : tonic^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/af/tonic">af:tonic</a>
    /// </summary>
    let tonic = _prefixId.prefix "tonic"
    /// <summary>
    ///   <para>rdfs:comment :
    /// 		Associates a signal resource as defined in the Music Ontology to a literal: its actual value.
    /// 		For example, it can be used to link an onset detection function to a list of values.
    /// 	^^xsd:string</para>
    ///   <para>rdfs:label : value^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/af/value">af:value</a>
    /// </summary>
    let value = _prefixId.prefix "value"
