namespace http.purl.org.ontology.chord.slash

open DoxAletheia.Rdf_Vocabulary

module chord =
    let _namespace_name = "http://purl.org/ontology/chord/"
    /// <summary>
    /// Two or more notes played together.
    /// <see href="http://purl.org/ontology/chord/Chord"></see></summary>
    let Chord = Namespaced_IRI.parse _namespace_name "Chord" |> NamespacedName
    /// <summary>
    /// A chord being played.
    /// <see href="http://purl.org/ontology/chord/ChordEvent"></see></summary>
    let ChordEvent = Namespaced_IRI.parse _namespace_name "ChordEvent" |> NamespacedName
    /// <summary>
    /// An interval above the root of a chord.
    /// <see href="http://purl.org/ontology/chord/Interval"></see></summary>
    let Interval = Namespaced_IRI.parse _namespace_name "Interval" |> NamespacedName
    /// <summary>
    /// A modifier applied to a note to change its pitch.
    /// <see href="http://purl.org/ontology/chord/Modifier"></see></summary>
    let Modifier = Namespaced_IRI.parse _namespace_name "Modifier" |> NamespacedName
    /// <summary>
    /// One of the seven natural notes of the Western music system.
    /// <see href="http://purl.org/ontology/chord/Natural"></see></summary>
    let Natural = Namespaced_IRI.parse _namespace_name "Natural" |> NamespacedName
    /// <summary>
    /// FIXME
    /// <see href="http://purl.org/ontology/chord/Note"></see></summary>
    let Note = Namespaced_IRI.parse _namespace_name "Note" |> NamespacedName

    /// <summary>
    /// An interval in the root scale, made up of the degree of the scale and optional modifier.
    /// <see href="http://purl.org/ontology/chord/ScaleInterval"></see></summary>
    let ScaleInterval =
        Namespaced_IRI.parse _namespace_name "ScaleInterval" |> NamespacedName

    /// <summary>
    /// A semitone interval.
    /// <see href="http://purl.org/ontology/chord/SemitoneInterval"></see></summary>
    let SemitoneInterval =
        Namespaced_IRI.parse _namespace_name "SemitoneInterval" |> NamespacedName

    /// <summary>
    /// The degree of an interval based on the root of a chord.
    /// <see href="http://purl.org/ontology/chord/degree"></see></summary>
    let degree = Namespaced_IRI.parse _namespace_name "degree" |> NamespacedName
    /// <summary>
    /// An augmented chord.
    /// <see href="http://purl.org/ontology/chord/aug"></see></summary>
    let aug = Namespaced_IRI.parse _namespace_name "aug" |> NamespacedName
    /// <summary>
    /// An interval from the root which is part of the chord.
    /// <see href="http://purl.org/ontology/chord/interval"></see></summary>
    let interval = Namespaced_IRI.parse _namespace_name "interval" |> NamespacedName
    /// <summary>
    /// A modification to a note's pitch.
    /// <see href="http://purl.org/ontology/chord/modifier"></see></summary>
    let modifier = Namespaced_IRI.parse _namespace_name "modifier" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/ontology/chord/sharp"></see>
    /// </summary>
    let sharp = Namespaced_IRI.parse _namespace_name "sharp" |> NamespacedName
    /// <summary>
    /// The chord on which this one is based.
    /// 			For example, a C7 chord might have chord:Cmaj as its base chord.
    /// <see href="http://purl.org/ontology/chord/base_chord"></see></summary>
    let base_chord = Namespaced_IRI.parse _namespace_name "base_chord" |> NamespacedName
    /// <summary>
    /// The bass note of the chord (indicates the inversion).
    /// <see href="http://purl.org/ontology/chord/bass"></see></summary>
    let bass = Namespaced_IRI.parse _namespace_name "bass" |> NamespacedName
    /// <summary>
    /// The chord associated with a chord event.
    /// <see href="http://purl.org/ontology/chord/chord"></see></summary>
    let chord = Namespaced_IRI.parse _namespace_name "chord" |> NamespacedName
    /// <summary>
    /// A diminished chord.
    /// <see href="http://purl.org/ontology/chord/dim"></see></summary>
    let dim = Namespaced_IRI.parse _namespace_name "dim" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/ontology/chord/flat"></see>
    /// </summary>
    let flat = Namespaced_IRI.parse _namespace_name "flat" |> NamespacedName
    /// <summary>
    /// A diminished seventh chord.
    /// <see href="http://purl.org/ontology/chord/dim7"></see></summary>
    let dim7 = Namespaced_IRI.parse _namespace_name "dim7" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/ontology/chord/doubleflat"></see>
    /// </summary>
    let doubleflat = Namespaced_IRI.parse _namespace_name "doubleflat" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/ontology/chord/doublesharp"></see>
    /// </summary>
    let doublesharp =
        Namespaced_IRI.parse _namespace_name "doublesharp" |> NamespacedName

    /// <summary>
    /// A half-diminished seventh chord.
    /// <see href="http://purl.org/ontology/chord/hdim7"></see></summary>
    let hdim7 = Namespaced_IRI.parse _namespace_name "hdim7" |> NamespacedName
    /// <summary>
    /// A major chord.
    /// <see href="http://purl.org/ontology/chord/maj"></see></summary>
    let maj = Namespaced_IRI.parse _namespace_name "maj" |> NamespacedName
    /// <summary>
    /// A major sixth chord.
    /// <see href="http://purl.org/ontology/chord/maj6"></see></summary>
    let maj6 = Namespaced_IRI.parse _namespace_name "maj6" |> NamespacedName
    /// <summary>
    /// A major seventh chord.
    /// <see href="http://purl.org/ontology/chord/maj7"></see></summary>
    let maj7 = Namespaced_IRI.parse _namespace_name "maj7" |> NamespacedName
    /// <summary>
    /// A major ninth chord.
    /// <see href="http://purl.org/ontology/chord/maj9"></see></summary>
    let maj9 = Namespaced_IRI.parse _namespace_name "maj9" |> NamespacedName
    /// <summary>
    /// A minor chord.
    /// <see href="http://purl.org/ontology/chord/min"></see></summary>
    let min = Namespaced_IRI.parse _namespace_name "min" |> NamespacedName
    /// <summary>
    /// A minor sixth chord.
    /// <see href="http://purl.org/ontology/chord/min6"></see></summary>
    let min6 = Namespaced_IRI.parse _namespace_name "min6" |> NamespacedName
    /// <summary>
    /// A minor seventh chord.
    /// <see href="http://purl.org/ontology/chord/min7"></see></summary>
    let min7 = Namespaced_IRI.parse _namespace_name "min7" |> NamespacedName
    /// <summary>
    /// A minor ninth chord.
    /// <see href="http://purl.org/ontology/chord/min9"></see></summary>
    let min9 = Namespaced_IRI.parse _namespace_name "min9" |> NamespacedName
    /// <summary>
    /// A minor (major 7th) chord.
    /// <see href="http://purl.org/ontology/chord/minmaj7"></see></summary>
    let minmaj7 = Namespaced_IRI.parse _namespace_name "minmaj7" |> NamespacedName
    /// <summary>
    /// The natural from which this note is derived.
    /// <see href="http://purl.org/ontology/chord/natural"></see></summary>
    let natural = Namespaced_IRI.parse _namespace_name "natural" |> NamespacedName
    /// <summary>
    /// A ninth chord.
    /// <see href="http://purl.org/ontology/chord/ninth"></see></summary>
    let ninth = Namespaced_IRI.parse _namespace_name "ninth" |> NamespacedName
    /// <summary>
    /// Indicates that no chord is played.
    /// <see href="http://purl.org/ontology/chord/noChord"></see></summary>
    let noChord = Namespaced_IRI.parse _namespace_name "noChord" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/ontology/chord/note/A"></see>
    /// </summary>
    let ``note/A`` = Namespaced_IRI.parse _namespace_name "note/A" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/ontology/chord/note/Ab"></see>
    /// </summary>
    let ``note/Ab`` = Namespaced_IRI.parse _namespace_name "note/Ab" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/ontology/chord/note/As"></see>
    /// </summary>
    let ``note/As`` = Namespaced_IRI.parse _namespace_name "note/As" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/ontology/chord/note/B"></see>
    /// </summary>
    let ``note/B`` = Namespaced_IRI.parse _namespace_name "note/B" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/ontology/chord/note/Bb"></see>
    /// </summary>
    let ``note/Bb`` = Namespaced_IRI.parse _namespace_name "note/Bb" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/ontology/chord/note/Bs"></see>
    /// </summary>
    let ``note/Bs`` = Namespaced_IRI.parse _namespace_name "note/Bs" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/ontology/chord/note/C"></see>
    /// </summary>
    let ``note/C`` = Namespaced_IRI.parse _namespace_name "note/C" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/ontology/chord/note/Cb"></see>
    /// </summary>
    let ``note/Cb`` = Namespaced_IRI.parse _namespace_name "note/Cb" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/ontology/chord/note/Cs"></see>
    /// </summary>
    let ``note/Cs`` = Namespaced_IRI.parse _namespace_name "note/Cs" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/ontology/chord/note/D"></see>
    /// </summary>
    let ``note/D`` = Namespaced_IRI.parse _namespace_name "note/D" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/ontology/chord/note/Db"></see>
    /// </summary>
    let ``note/Db`` = Namespaced_IRI.parse _namespace_name "note/Db" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/ontology/chord/note/Ds"></see>
    /// </summary>
    let ``note/Ds`` = Namespaced_IRI.parse _namespace_name "note/Ds" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/ontology/chord/note/E"></see>
    /// </summary>
    let ``note/E`` = Namespaced_IRI.parse _namespace_name "note/E" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/ontology/chord/note/Eb"></see>
    /// </summary>
    let ``note/Eb`` = Namespaced_IRI.parse _namespace_name "note/Eb" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/ontology/chord/note/Es"></see>
    /// </summary>
    let ``note/Es`` = Namespaced_IRI.parse _namespace_name "note/Es" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/ontology/chord/note/F"></see>
    /// </summary>
    let ``note/F`` = Namespaced_IRI.parse _namespace_name "note/F" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/ontology/chord/note/Fb"></see>
    /// </summary>
    let ``note/Fb`` = Namespaced_IRI.parse _namespace_name "note/Fb" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/ontology/chord/note/Fs"></see>
    /// </summary>
    let ``note/Fs`` = Namespaced_IRI.parse _namespace_name "note/Fs" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/ontology/chord/note/G"></see>
    /// </summary>
    let ``note/G`` = Namespaced_IRI.parse _namespace_name "note/G" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/ontology/chord/note/Gb"></see>
    /// </summary>
    let ``note/Gb`` = Namespaced_IRI.parse _namespace_name "note/Gb" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/ontology/chord/note/Gs"></see>
    /// </summary>
    let ``note/Gs`` = Namespaced_IRI.parse _namespace_name "note/Gs" |> NamespacedName
    /// <summary>
    /// The root note of the chord.
    /// <see href="http://purl.org/ontology/chord/root"></see></summary>
    let root = Namespaced_IRI.parse _namespace_name "root" |> NamespacedName

    /// <summary>
    /// An interval measured in semitones.
    /// <see href="http://purl.org/ontology/chord/semitone_interval"></see></summary>
    let semitone_interval =
        Namespaced_IRI.parse _namespace_name "semitone_interval" |> NamespacedName

    /// <summary>
    /// A seventh chord.
    /// <see href="http://purl.org/ontology/chord/seventh"></see></summary>
    let seventh = Namespaced_IRI.parse _namespace_name "seventh" |> NamespacedName
    /// <summary>
    /// A suspended fourth chord.
    /// <see href="http://purl.org/ontology/chord/sus2"></see></summary>
    let sus2 = Namespaced_IRI.parse _namespace_name "sus2" |> NamespacedName
    /// <summary>
    /// A suspended fourth chord.
    /// <see href="http://purl.org/ontology/chord/sus4"></see></summary>
    let sus4 = Namespaced_IRI.parse _namespace_name "sus4" |> NamespacedName

    /// <summary>
    /// A degree of the scale expected in the chord but not actually present here.
    /// <see href="http://purl.org/ontology/chord/without_interval"></see></summary>
    let without_interval =
        Namespaced_IRI.parse _namespace_name "without_interval" |> NamespacedName
