namespace http.purl.org.ontology.chord.slash

open DoxAletheia

module chord =
    let _namespace_name = "http://purl.org/ontology/chord/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// Two or more notes played together.
    /// <see href="http://purl.org/ontology/chord/Chord"></see></summary>
    let Chord = _prefix "Chord"
    /// <summary>
    /// A chord being played.
    /// <see href="http://purl.org/ontology/chord/ChordEvent"></see></summary>
    let ChordEvent = _prefix "ChordEvent"
    /// <summary>
    /// An interval above the root of a chord.
    /// <see href="http://purl.org/ontology/chord/Interval"></see></summary>
    let Interval = _prefix "Interval"
    /// <summary>
    /// A modifier applied to a note to change its pitch.
    /// <see href="http://purl.org/ontology/chord/Modifier"></see></summary>
    let Modifier = _prefix "Modifier"
    /// <summary>
    /// One of the seven natural notes of the Western music system.
    /// <see href="http://purl.org/ontology/chord/Natural"></see></summary>
    let Natural = _prefix "Natural"
    /// <summary>
    /// FIXME
    /// <see href="http://purl.org/ontology/chord/Note"></see></summary>
    let Note = _prefix "Note"
    /// <summary>
    /// An interval in the root scale, made up of the degree of the scale and optional modifier.
    /// <see href="http://purl.org/ontology/chord/ScaleInterval"></see></summary>
    let ScaleInterval = _prefix "ScaleInterval"
    /// <summary>
    /// A semitone interval.
    /// <see href="http://purl.org/ontology/chord/SemitoneInterval"></see></summary>
    let SemitoneInterval = _prefix "SemitoneInterval"
    /// <summary>
    /// The degree of an interval based on the root of a chord.
    /// <see href="http://purl.org/ontology/chord/degree"></see></summary>
    let degree = _prefix "degree"
    /// <summary>
    /// An augmented chord.
    /// <see href="http://purl.org/ontology/chord/aug"></see></summary>
    let aug = _prefix "aug"
    /// <summary>
    /// An interval from the root which is part of the chord.
    /// <see href="http://purl.org/ontology/chord/interval"></see></summary>
    let interval = _prefix "interval"
    /// <summary>
    /// A modification to a note's pitch.
    /// <see href="http://purl.org/ontology/chord/modifier"></see></summary>
    let modifier = _prefix "modifier"
    /// <summary>
    ///   <see href="http://purl.org/ontology/chord/sharp"></see>
    /// </summary>
    let sharp = _prefix "sharp"
    /// <summary>
    /// The chord on which this one is based.
    /// 			For example, a C7 chord might have chord:Cmaj as its base chord.
    /// <see href="http://purl.org/ontology/chord/base_chord"></see></summary>
    let base_chord = _prefix "base_chord"
    /// <summary>
    /// The bass note of the chord (indicates the inversion).
    /// <see href="http://purl.org/ontology/chord/bass"></see></summary>
    let bass = _prefix "bass"
    /// <summary>
    /// The chord associated with a chord event.
    /// <see href="http://purl.org/ontology/chord/chord"></see></summary>
    let chord = _prefix "chord"
    /// <summary>
    /// A diminished chord.
    /// <see href="http://purl.org/ontology/chord/dim"></see></summary>
    let dim = _prefix "dim"
    /// <summary>
    ///   <see href="http://purl.org/ontology/chord/flat"></see>
    /// </summary>
    let flat = _prefix "flat"
    /// <summary>
    /// A diminished seventh chord.
    /// <see href="http://purl.org/ontology/chord/dim7"></see></summary>
    let dim7 = _prefix "dim7"
    /// <summary>
    ///   <see href="http://purl.org/ontology/chord/doubleflat"></see>
    /// </summary>
    let doubleflat = _prefix "doubleflat"
    /// <summary>
    ///   <see href="http://purl.org/ontology/chord/doublesharp"></see>
    /// </summary>
    let doublesharp = _prefix "doublesharp"
    /// <summary>
    /// A half-diminished seventh chord.
    /// <see href="http://purl.org/ontology/chord/hdim7"></see></summary>
    let hdim7 = _prefix "hdim7"
    /// <summary>
    /// A major chord.
    /// <see href="http://purl.org/ontology/chord/maj"></see></summary>
    let maj = _prefix "maj"
    /// <summary>
    /// A major sixth chord.
    /// <see href="http://purl.org/ontology/chord/maj6"></see></summary>
    let maj6 = _prefix "maj6"
    /// <summary>
    /// A major seventh chord.
    /// <see href="http://purl.org/ontology/chord/maj7"></see></summary>
    let maj7 = _prefix "maj7"
    /// <summary>
    /// A major ninth chord.
    /// <see href="http://purl.org/ontology/chord/maj9"></see></summary>
    let maj9 = _prefix "maj9"
    /// <summary>
    /// A minor chord.
    /// <see href="http://purl.org/ontology/chord/min"></see></summary>
    let min = _prefix "min"
    /// <summary>
    /// A minor sixth chord.
    /// <see href="http://purl.org/ontology/chord/min6"></see></summary>
    let min6 = _prefix "min6"
    /// <summary>
    /// A minor seventh chord.
    /// <see href="http://purl.org/ontology/chord/min7"></see></summary>
    let min7 = _prefix "min7"
    /// <summary>
    /// A minor ninth chord.
    /// <see href="http://purl.org/ontology/chord/min9"></see></summary>
    let min9 = _prefix "min9"
    /// <summary>
    /// A minor (major 7th) chord.
    /// <see href="http://purl.org/ontology/chord/minmaj7"></see></summary>
    let minmaj7 = _prefix "minmaj7"
    /// <summary>
    /// The natural from which this note is derived.
    /// <see href="http://purl.org/ontology/chord/natural"></see></summary>
    let natural = _prefix "natural"
    /// <summary>
    /// A ninth chord.
    /// <see href="http://purl.org/ontology/chord/ninth"></see></summary>
    let ninth = _prefix "ninth"
    /// <summary>
    /// Indicates that no chord is played.
    /// <see href="http://purl.org/ontology/chord/noChord"></see></summary>
    let noChord = _prefix "noChord"
    /// <summary>
    ///   <see href="http://purl.org/ontology/chord/note/A"></see>
    /// </summary>
    let ``note/A`` = _prefix "note/A"
    /// <summary>
    ///   <see href="http://purl.org/ontology/chord/note/Ab"></see>
    /// </summary>
    let ``note/Ab`` = _prefix "note/Ab"
    /// <summary>
    ///   <see href="http://purl.org/ontology/chord/note/As"></see>
    /// </summary>
    let ``note/As`` = _prefix "note/As"
    /// <summary>
    ///   <see href="http://purl.org/ontology/chord/note/B"></see>
    /// </summary>
    let ``note/B`` = _prefix "note/B"
    /// <summary>
    ///   <see href="http://purl.org/ontology/chord/note/Bb"></see>
    /// </summary>
    let ``note/Bb`` = _prefix "note/Bb"
    /// <summary>
    ///   <see href="http://purl.org/ontology/chord/note/Bs"></see>
    /// </summary>
    let ``note/Bs`` = _prefix "note/Bs"
    /// <summary>
    ///   <see href="http://purl.org/ontology/chord/note/C"></see>
    /// </summary>
    let ``note/C`` = _prefix "note/C"
    /// <summary>
    ///   <see href="http://purl.org/ontology/chord/note/Cb"></see>
    /// </summary>
    let ``note/Cb`` = _prefix "note/Cb"
    /// <summary>
    ///   <see href="http://purl.org/ontology/chord/note/Cs"></see>
    /// </summary>
    let ``note/Cs`` = _prefix "note/Cs"
    /// <summary>
    ///   <see href="http://purl.org/ontology/chord/note/D"></see>
    /// </summary>
    let ``note/D`` = _prefix "note/D"
    /// <summary>
    ///   <see href="http://purl.org/ontology/chord/note/Db"></see>
    /// </summary>
    let ``note/Db`` = _prefix "note/Db"
    /// <summary>
    ///   <see href="http://purl.org/ontology/chord/note/Ds"></see>
    /// </summary>
    let ``note/Ds`` = _prefix "note/Ds"
    /// <summary>
    ///   <see href="http://purl.org/ontology/chord/note/E"></see>
    /// </summary>
    let ``note/E`` = _prefix "note/E"
    /// <summary>
    ///   <see href="http://purl.org/ontology/chord/note/Eb"></see>
    /// </summary>
    let ``note/Eb`` = _prefix "note/Eb"
    /// <summary>
    ///   <see href="http://purl.org/ontology/chord/note/Es"></see>
    /// </summary>
    let ``note/Es`` = _prefix "note/Es"
    /// <summary>
    ///   <see href="http://purl.org/ontology/chord/note/F"></see>
    /// </summary>
    let ``note/F`` = _prefix "note/F"
    /// <summary>
    ///   <see href="http://purl.org/ontology/chord/note/Fb"></see>
    /// </summary>
    let ``note/Fb`` = _prefix "note/Fb"
    /// <summary>
    ///   <see href="http://purl.org/ontology/chord/note/Fs"></see>
    /// </summary>
    let ``note/Fs`` = _prefix "note/Fs"
    /// <summary>
    ///   <see href="http://purl.org/ontology/chord/note/G"></see>
    /// </summary>
    let ``note/G`` = _prefix "note/G"
    /// <summary>
    ///   <see href="http://purl.org/ontology/chord/note/Gb"></see>
    /// </summary>
    let ``note/Gb`` = _prefix "note/Gb"
    /// <summary>
    ///   <see href="http://purl.org/ontology/chord/note/Gs"></see>
    /// </summary>
    let ``note/Gs`` = _prefix "note/Gs"
    /// <summary>
    /// The root note of the chord.
    /// <see href="http://purl.org/ontology/chord/root"></see></summary>
    let root = _prefix "root"
    /// <summary>
    /// An interval measured in semitones.
    /// <see href="http://purl.org/ontology/chord/semitone_interval"></see></summary>
    let semitone_interval = _prefix "semitone_interval"
    /// <summary>
    /// A seventh chord.
    /// <see href="http://purl.org/ontology/chord/seventh"></see></summary>
    let seventh = _prefix "seventh"
    /// <summary>
    /// A suspended fourth chord.
    /// <see href="http://purl.org/ontology/chord/sus2"></see></summary>
    let sus2 = _prefix "sus2"
    /// <summary>
    /// A suspended fourth chord.
    /// <see href="http://purl.org/ontology/chord/sus4"></see></summary>
    let sus4 = _prefix "sus4"
    /// <summary>
    /// A degree of the scale expected in the chord but not actually present here.
    /// <see href="http://purl.org/ontology/chord/without_interval"></see></summary>
    let without_interval = _prefix "without_interval"
