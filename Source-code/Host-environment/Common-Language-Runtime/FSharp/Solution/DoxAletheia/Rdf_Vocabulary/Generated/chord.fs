namespace http.purl.org.ontology.chord.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module chord =
    let _namespace_iri = Namespace_Iri chord |> NamespaceIRI
    /// <summary>
    ///   <para>chord:Chord</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>Two or more notes played together.</para>
    /// labels<para>Chord</para></remarks>
    /// <seealso href="http://purl.org/ontology/chord/Chord">http://purl.org/ontology/chord/Chord</seealso>
    let Chord = Prefixed_Name(chord, "Chord") |> PrefixedName
    /// <summary>
    ///   <para>chord:Interval</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>An interval above the root of a chord.</para>
    /// labels<para>Interval</para></remarks>
    /// <seealso href="http://purl.org/ontology/chord/Interval">http://purl.org/ontology/chord/Interval</seealso>
    let Interval = Prefixed_Name(chord, "Interval") |> PrefixedName
    /// <summary>
    ///   <para>chord:interval</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>An interval from the root which is part of the chord.</para>
    /// labels<para>interval</para></remarks>
    /// <seealso href="http://purl.org/ontology/chord/interval">http://purl.org/ontology/chord/interval</seealso>
    let interval = Prefixed_Name(chord, "interval") |> PrefixedName
    /// <summary>
    ///   <para>chord:maj7</para>
    /// </summary>
    /// <remarks>
    ///   <para>chord:Chord</para>
    ///   <para>A major seventh chord.</para>
    /// labels<para>maj7</para></remarks>
    /// <seealso href="http://purl.org/ontology/chord/maj7">http://purl.org/ontology/chord/maj7</seealso>
    let maj7 = Prefixed_Name(chord, "maj7") |> PrefixedName
    /// <summary>
    ///   <para>chord:ChordEvent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>A chord being played.</para>
    /// labels<para>ChordEvent</para></remarks>
    /// <seealso href="http://purl.org/ontology/chord/ChordEvent">http://purl.org/ontology/chord/ChordEvent</seealso>
    let ChordEvent = Prefixed_Name(chord, "ChordEvent") |> PrefixedName
    /// <summary>
    ///   <para>chord:Modifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>A modifier applied to a note to change its pitch.</para>
    /// labels<para>Modifier</para></remarks>
    /// <seealso href="http://purl.org/ontology/chord/Modifier">http://purl.org/ontology/chord/Modifier</seealso>
    let Modifier = Prefixed_Name(chord, "Modifier") |> PrefixedName
    /// <summary>
    ///   <para>chord:Natural</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>One of the seven natural notes of the Western music system.</para>
    /// labels<para>Natural</para></remarks>
    /// <seealso href="http://purl.org/ontology/chord/Natural">http://purl.org/ontology/chord/Natural</seealso>
    let Natural = Prefixed_Name(chord, "Natural") |> PrefixedName
    /// <summary>
    ///   <para>chord:ScaleInterval</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>An interval in the root scale, made up of the degree of the scale and optional modifier.</para>
    /// labels<para>ScaleInterval</para></remarks>
    /// <seealso href="http://purl.org/ontology/chord/ScaleInterval">http://purl.org/ontology/chord/ScaleInterval</seealso>
    let ScaleInterval = Prefixed_Name(chord, "ScaleInterval") |> PrefixedName
    /// <summary>
    ///   <para>chord:SemitoneInterval</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>A semitone interval.</para>
    /// labels<para>SemitoneInterval</para></remarks>
    /// <seealso href="http://purl.org/ontology/chord/SemitoneInterval">http://purl.org/ontology/chord/SemitoneInterval</seealso>
    let SemitoneInterval = Prefixed_Name(chord, "SemitoneInterval") |> PrefixedName
    /// <summary>
    ///   <para>chord:degree</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The degree of an interval based on the root of a chord.</para>
    /// labels<para>degree</para></remarks>
    /// <seealso href="http://purl.org/ontology/chord/degree">http://purl.org/ontology/chord/degree</seealso>
    let degree = Prefixed_Name(chord, "degree") |> PrefixedName
    /// <summary>
    ///   <para>chord:sharp</para>
    /// </summary>
    /// <remarks>
    ///   <para>chord:Modifier</para>
    ///
    /// labels<para>sharp</para></remarks>
    /// <seealso href="http://purl.org/ontology/chord/sharp">http://purl.org/ontology/chord/sharp</seealso>
    let sharp = Prefixed_Name(chord, "sharp") |> PrefixedName
    /// <summary>
    ///   <para>chord:base_chord</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The chord on which this one is based.
    /// 			For example, a C7 chord might have chord:Cmaj as its base chord.</para>
    /// labels<para>base_chord</para></remarks>
    /// <seealso href="http://purl.org/ontology/chord/base_chord">http://purl.org/ontology/chord/base_chord</seealso>
    let base_chord = Prefixed_Name(chord, "base_chord") |> PrefixedName
    /// <summary>
    ///   <para>chord:Note</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>FIXME</para>
    /// labels<para>Note</para></remarks>
    /// <seealso href="http://purl.org/ontology/chord/Note">http://purl.org/ontology/chord/Note</seealso>
    let Note = Prefixed_Name(chord, "Note") |> PrefixedName
    /// <summary>
    ///   <para>chord:modifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A modification to a note's pitch.</para>
    /// labels<para>modifier</para></remarks>
    /// <seealso href="http://purl.org/ontology/chord/modifier">http://purl.org/ontology/chord/modifier</seealso>
    let modifier = Prefixed_Name(chord, "modifier") |> PrefixedName
    /// <summary>
    ///   <para>chord:chord</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The chord associated with a chord event.</para>
    /// labels<para>chord</para></remarks>
    /// <seealso href="http://purl.org/ontology/chord/chord">http://purl.org/ontology/chord/chord</seealso>
    let chord_ = Prefixed_Name(chord, "chord") |> PrefixedName
    /// <summary>
    ///   <para>chord:doubleflat</para>
    /// </summary>
    /// <remarks>
    ///   <para>chord:Modifier</para>
    ///
    /// labels<para>double flat</para></remarks>
    /// <seealso href="http://purl.org/ontology/chord/doubleflat">http://purl.org/ontology/chord/doubleflat</seealso>
    let doubleflat = Prefixed_Name(chord, "doubleflat") |> PrefixedName
    /// <summary>
    ///   <para>chord:bass</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The bass note of the chord (indicates the inversion).</para>
    /// labels<para>bass</para></remarks>
    /// <seealso href="http://purl.org/ontology/chord/bass">http://purl.org/ontology/chord/bass</seealso>
    let bass = Prefixed_Name(chord, "bass") |> PrefixedName
    /// <summary>
    ///   <para>chord:flat</para>
    /// </summary>
    /// <remarks>
    ///   <para>chord:Modifier</para>
    ///
    /// labels<para>flat</para></remarks>
    /// <seealso href="http://purl.org/ontology/chord/flat">http://purl.org/ontology/chord/flat</seealso>
    let flat = Prefixed_Name(chord, "flat") |> PrefixedName
    /// <summary>
    ///   <para>chord:dim7</para>
    /// </summary>
    /// <remarks>
    ///   <para>chord:Chord</para>
    ///   <para>A diminished seventh chord.</para>
    /// labels<para>dim7</para></remarks>
    /// <seealso href="http://purl.org/ontology/chord/dim7">http://purl.org/ontology/chord/dim7</seealso>
    let dim7 = Prefixed_Name(chord, "dim7") |> PrefixedName
    /// <summary>
    ///   <para>chord:dim</para>
    /// </summary>
    /// <remarks>
    ///   <para>chord:Chord</para>
    ///   <para>A diminished chord.</para>
    /// labels<para>dim</para></remarks>
    /// <seealso href="http://purl.org/ontology/chord/dim">http://purl.org/ontology/chord/dim</seealso>
    let dim = Prefixed_Name(chord, "dim") |> PrefixedName
    /// <summary>
    ///   <para>chord:maj</para>
    /// </summary>
    /// <remarks>
    ///   <para>chord:Chord</para>
    ///   <para>A major chord.</para>
    /// labels<para>maj</para></remarks>
    /// <seealso href="http://purl.org/ontology/chord/maj">http://purl.org/ontology/chord/maj</seealso>
    let maj = Prefixed_Name(chord, "maj") |> PrefixedName
    /// <summary>
    ///   <para>chord:maj6</para>
    /// </summary>
    /// <remarks>
    ///   <para>chord:Chord</para>
    ///   <para>A major sixth chord.</para>
    /// labels<para>maj6</para></remarks>
    /// <seealso href="http://purl.org/ontology/chord/maj6">http://purl.org/ontology/chord/maj6</seealso>
    let maj6 = Prefixed_Name(chord, "maj6") |> PrefixedName
    /// <summary>
    ///   <para>chord:doublesharp</para>
    /// </summary>
    /// <remarks>
    ///   <para>chord:Modifier</para>
    ///
    /// labels<para>double sharp</para></remarks>
    /// <seealso href="http://purl.org/ontology/chord/doublesharp">http://purl.org/ontology/chord/doublesharp</seealso>
    let doublesharp = Prefixed_Name(chord, "doublesharp") |> PrefixedName
    /// <summary>
    ///   <para>chord:hdim7</para>
    /// </summary>
    /// <remarks>
    ///   <para>chord:Chord</para>
    ///   <para>A half-diminished seventh chord.</para>
    /// labels<para>hdim7</para></remarks>
    /// <seealso href="http://purl.org/ontology/chord/hdim7">http://purl.org/ontology/chord/hdim7</seealso>
    let hdim7 = Prefixed_Name(chord, "hdim7") |> PrefixedName
    /// <summary>
    ///   <para>chord:maj9</para>
    /// </summary>
    /// <remarks>
    ///   <para>chord:Chord</para>
    ///   <para>A major ninth chord.</para>
    /// labels<para>maj9</para></remarks>
    /// <seealso href="http://purl.org/ontology/chord/maj9">http://purl.org/ontology/chord/maj9</seealso>
    let maj9 = Prefixed_Name(chord, "maj9") |> PrefixedName
    /// <summary>
    ///   <para>chord:min6</para>
    /// </summary>
    /// <remarks>
    ///   <para>chord:Chord</para>
    ///   <para>A minor sixth chord.</para>
    /// labels<para>min6</para></remarks>
    /// <seealso href="http://purl.org/ontology/chord/min6">http://purl.org/ontology/chord/min6</seealso>
    let min6 = Prefixed_Name(chord, "min6") |> PrefixedName
    /// <summary>
    ///   <para>chord:min7</para>
    /// </summary>
    /// <remarks>
    ///   <para>chord:Chord</para>
    ///   <para>A minor seventh chord.</para>
    /// labels<para>min7</para></remarks>
    /// <seealso href="http://purl.org/ontology/chord/min7">http://purl.org/ontology/chord/min7</seealso>
    let min7 = Prefixed_Name(chord, "min7") |> PrefixedName
    /// <summary>
    ///   <para>chord:min9</para>
    /// </summary>
    /// <remarks>
    ///   <para>chord:Chord</para>
    ///   <para>A minor ninth chord.</para>
    /// labels<para>min9</para></remarks>
    /// <seealso href="http://purl.org/ontology/chord/min9">http://purl.org/ontology/chord/min9</seealso>
    let min9 = Prefixed_Name(chord, "min9") |> PrefixedName
    /// <summary>
    ///   <para>chord:minmaj7</para>
    /// </summary>
    /// <remarks>
    ///   <para>chord:Chord</para>
    ///   <para>A minor (major 7th) chord.</para>
    /// labels<para>minmaj7</para></remarks>
    /// <seealso href="http://purl.org/ontology/chord/minmaj7">http://purl.org/ontology/chord/minmaj7</seealso>
    let minmaj7 = Prefixed_Name(chord, "minmaj7") |> PrefixedName
    /// <summary>
    ///   <para>chord:natural</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The natural from which this note is derived.</para>
    /// labels<para>natural</para></remarks>
    /// <seealso href="http://purl.org/ontology/chord/natural">http://purl.org/ontology/chord/natural</seealso>
    let natural = Prefixed_Name(chord, "natural") |> PrefixedName
    /// <summary>
    ///   <para>chord:ninth</para>
    /// </summary>
    /// <remarks>
    ///   <para>chord:Chord</para>
    ///   <para>A ninth chord.</para>
    /// labels<para>9</para></remarks>
    /// <seealso href="http://purl.org/ontology/chord/ninth">http://purl.org/ontology/chord/ninth</seealso>
    let ninth = Prefixed_Name(chord, "ninth") |> PrefixedName
    /// <summary>
    ///   <para>chord:note/As</para>
    /// </summary>
    /// <remarks>
    ///   <para>chord:Note</para>
    ///
    /// labels<para>A#</para></remarks>
    /// <seealso href="http://purl.org/ontology/chord/note/As">http://purl.org/ontology/chord/note/As</seealso>
    let ``note/As`` = Prefixed_Name(chord, "note/As") |> PrefixedName
    /// <summary>
    ///   <para>chord:note/Bb</para>
    /// </summary>
    /// <remarks>
    ///   <para>chord:Note</para>
    ///
    /// labels<para>Bb</para></remarks>
    /// <seealso href="http://purl.org/ontology/chord/note/Bb">http://purl.org/ontology/chord/note/Bb</seealso>
    let ``note/Bb`` = Prefixed_Name(chord, "note/Bb") |> PrefixedName
    /// <summary>
    ///   <para>chord:note/D</para>
    /// </summary>
    /// <remarks>
    ///   <para>chord:Natural</para>
    ///
    /// labels<para>D</para></remarks>
    /// <seealso href="http://purl.org/ontology/chord/note/D">http://purl.org/ontology/chord/note/D</seealso>
    let ``note/D`` = Prefixed_Name(chord, "note/D") |> PrefixedName
    /// <summary>
    ///   <para>chord:note/Eb</para>
    /// </summary>
    /// <remarks>
    ///   <para>chord:Note</para>
    ///
    /// labels<para>Eb</para></remarks>
    /// <seealso href="http://purl.org/ontology/chord/note/Eb">http://purl.org/ontology/chord/note/Eb</seealso>
    let ``note/Eb`` = Prefixed_Name(chord, "note/Eb") |> PrefixedName
    /// <summary>
    ///   <para>chord:note/Fs</para>
    /// </summary>
    /// <remarks>
    ///   <para>chord:Note</para>
    ///
    /// labels<para>F#</para></remarks>
    /// <seealso href="http://purl.org/ontology/chord/note/Fs">http://purl.org/ontology/chord/note/Fs</seealso>
    let ``note/Fs`` = Prefixed_Name(chord, "note/Fs") |> PrefixedName
    /// <summary>
    ///   <para>chord:note/Gs</para>
    /// </summary>
    /// <remarks>
    ///   <para>chord:Note</para>
    ///
    /// labels<para>G#</para></remarks>
    /// <seealso href="http://purl.org/ontology/chord/note/Gs">http://purl.org/ontology/chord/note/Gs</seealso>
    let ``note/Gs`` = Prefixed_Name(chord, "note/Gs") |> PrefixedName
    /// <summary>
    ///   <para>chord:sus4</para>
    /// </summary>
    /// <remarks>
    ///   <para>chord:Chord</para>
    ///   <para>A suspended fourth chord.</para>
    /// labels<para>sus4</para></remarks>
    /// <seealso href="http://purl.org/ontology/chord/sus4">http://purl.org/ontology/chord/sus4</seealso>
    let sus4 = Prefixed_Name(chord, "sus4") |> PrefixedName
    /// <summary>
    ///   <para>chord:noChord</para>
    /// </summary>
    /// <remarks>
    ///   <para>chord:Chord</para>
    ///   <para>Indicates that no chord is played.</para>
    /// labels<para>noChord</para></remarks>
    /// <seealso href="http://purl.org/ontology/chord/noChord">http://purl.org/ontology/chord/noChord</seealso>
    let noChord = Prefixed_Name(chord, "noChord") |> PrefixedName
    /// <summary>
    ///   <para>chord:note/Ab</para>
    /// </summary>
    /// <remarks>
    ///   <para>chord:Note</para>
    ///
    /// labels<para>Ab</para></remarks>
    /// <seealso href="http://purl.org/ontology/chord/note/Ab">http://purl.org/ontology/chord/note/Ab</seealso>
    let ``note/Ab`` = Prefixed_Name(chord, "note/Ab") |> PrefixedName
    /// <summary>
    ///   <para>chord:note/B</para>
    /// </summary>
    /// <remarks>
    ///   <para>chord:Natural</para>
    ///
    /// labels<para>B</para></remarks>
    /// <seealso href="http://purl.org/ontology/chord/note/B">http://purl.org/ontology/chord/note/B</seealso>
    let ``note/B`` = Prefixed_Name(chord, "note/B") |> PrefixedName
    /// <summary>
    ///   <para>chord:note/C</para>
    /// </summary>
    /// <remarks>
    ///   <para>chord:Natural</para>
    ///
    /// labels<para>C</para></remarks>
    /// <seealso href="http://purl.org/ontology/chord/note/C">http://purl.org/ontology/chord/note/C</seealso>
    let ``note/C`` = Prefixed_Name(chord, "note/C") |> PrefixedName
    /// <summary>
    ///   <para>chord:note/Cs</para>
    /// </summary>
    /// <remarks>
    ///   <para>chord:Note</para>
    ///
    /// labels<para>C#</para></remarks>
    /// <seealso href="http://purl.org/ontology/chord/note/Cs">http://purl.org/ontology/chord/note/Cs</seealso>
    let ``note/Cs`` = Prefixed_Name(chord, "note/Cs") |> PrefixedName
    /// <summary>
    ///   <para>chord:note/Db</para>
    /// </summary>
    /// <remarks>
    ///   <para>chord:Note</para>
    ///
    /// labels<para>Db</para></remarks>
    /// <seealso href="http://purl.org/ontology/chord/note/Db">http://purl.org/ontology/chord/note/Db</seealso>
    let ``note/Db`` = Prefixed_Name(chord, "note/Db") |> PrefixedName
    /// <summary>
    ///   <para>chord:note/E</para>
    /// </summary>
    /// <remarks>
    ///   <para>chord:Natural</para>
    ///
    /// labels<para>E</para></remarks>
    /// <seealso href="http://purl.org/ontology/chord/note/E">http://purl.org/ontology/chord/note/E</seealso>
    let ``note/E`` = Prefixed_Name(chord, "note/E") |> PrefixedName
    /// <summary>
    ///   <para>chord:note/F</para>
    /// </summary>
    /// <remarks>
    ///   <para>chord:Natural</para>
    ///
    /// labels<para>F</para></remarks>
    /// <seealso href="http://purl.org/ontology/chord/note/F">http://purl.org/ontology/chord/note/F</seealso>
    let ``note/F`` = Prefixed_Name(chord, "note/F") |> PrefixedName
    /// <summary>
    ///   <para>chord:note/G</para>
    /// </summary>
    /// <remarks>
    ///   <para>chord:Natural</para>
    ///
    /// labels<para>G</para></remarks>
    /// <seealso href="http://purl.org/ontology/chord/note/G">http://purl.org/ontology/chord/note/G</seealso>
    let ``note/G`` = Prefixed_Name(chord, "note/G") |> PrefixedName
    /// <summary>
    ///   <para>chord:root</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The root note of the chord.</para>
    /// labels<para>root</para></remarks>
    /// <seealso href="http://purl.org/ontology/chord/root">http://purl.org/ontology/chord/root</seealso>
    let root = Prefixed_Name(chord, "root") |> PrefixedName
    /// <summary>
    ///   <para>chord:seventh</para>
    /// </summary>
    /// <remarks>
    ///   <para>chord:Chord</para>
    ///   <para>A seventh chord.</para>
    /// labels<para>7</para></remarks>
    /// <seealso href="http://purl.org/ontology/chord/seventh">http://purl.org/ontology/chord/seventh</seealso>
    let seventh = Prefixed_Name(chord, "seventh") |> PrefixedName
    /// <summary>
    ///   <para>chord:note/A</para>
    /// </summary>
    /// <remarks>
    ///   <para>chord:Natural</para>
    ///
    /// labels<para>A</para></remarks>
    /// <seealso href="http://purl.org/ontology/chord/note/A">http://purl.org/ontology/chord/note/A</seealso>
    let ``note/A`` = Prefixed_Name(chord, "note/A") |> PrefixedName
    /// <summary>
    ///   <para>chord:note/Bs</para>
    /// </summary>
    /// <remarks>
    ///   <para>chord:Note</para>
    ///
    /// labels<para>B#</para></remarks>
    /// <seealso href="http://purl.org/ontology/chord/note/Bs">http://purl.org/ontology/chord/note/Bs</seealso>
    let ``note/Bs`` = Prefixed_Name(chord, "note/Bs") |> PrefixedName
    /// <summary>
    ///   <para>chord:note/Cb</para>
    /// </summary>
    /// <remarks>
    ///   <para>chord:Note</para>
    ///
    /// labels<para>Cb</para></remarks>
    /// <seealso href="http://purl.org/ontology/chord/note/Cb">http://purl.org/ontology/chord/note/Cb</seealso>
    let ``note/Cb`` = Prefixed_Name(chord, "note/Cb") |> PrefixedName
    /// <summary>
    ///   <para>chord:note/Ds</para>
    /// </summary>
    /// <remarks>
    ///   <para>chord:Note</para>
    ///
    /// labels<para>D#</para></remarks>
    /// <seealso href="http://purl.org/ontology/chord/note/Ds">http://purl.org/ontology/chord/note/Ds</seealso>
    let ``note/Ds`` = Prefixed_Name(chord, "note/Ds") |> PrefixedName
    /// <summary>
    ///   <para>chord:note/Es</para>
    /// </summary>
    /// <remarks>
    ///   <para>chord:Note</para>
    ///
    /// labels<para>E#</para></remarks>
    /// <seealso href="http://purl.org/ontology/chord/note/Es">http://purl.org/ontology/chord/note/Es</seealso>
    let ``note/Es`` = Prefixed_Name(chord, "note/Es") |> PrefixedName
    /// <summary>
    ///   <para>chord:note/Fb</para>
    /// </summary>
    /// <remarks>
    ///   <para>chord:Note</para>
    ///
    /// labels<para>Fb</para></remarks>
    /// <seealso href="http://purl.org/ontology/chord/note/Fb">http://purl.org/ontology/chord/note/Fb</seealso>
    let ``note/Fb`` = Prefixed_Name(chord, "note/Fb") |> PrefixedName
    /// <summary>
    ///   <para>chord:note/Gb</para>
    /// </summary>
    /// <remarks>
    ///   <para>chord:Note</para>
    ///
    /// labels<para>Gb</para></remarks>
    /// <seealso href="http://purl.org/ontology/chord/note/Gb">http://purl.org/ontology/chord/note/Gb</seealso>
    let ``note/Gb`` = Prefixed_Name(chord, "note/Gb") |> PrefixedName
    /// <summary>
    ///   <para>chord:semitone_interval</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>An interval measured in semitones.</para>
    /// labels<para>semitone_interval</para></remarks>
    /// <seealso href="http://purl.org/ontology/chord/semitone_interval">http://purl.org/ontology/chord/semitone_interval</seealso>
    let semitone_interval = Prefixed_Name(chord, "semitone_interval") |> PrefixedName
    /// <summary>
    ///   <para>chord:sus2</para>
    /// </summary>
    /// <remarks>
    ///   <para>chord:Chord</para>
    ///   <para>A suspended fourth chord.</para>
    /// labels<para>sus2</para></remarks>
    /// <seealso href="http://purl.org/ontology/chord/sus2">http://purl.org/ontology/chord/sus2</seealso>
    let sus2 = Prefixed_Name(chord, "sus2") |> PrefixedName
    /// <summary>
    ///   <para>chord:without_interval</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A degree of the scale expected in the chord but not actually present here.</para>
    /// labels<para>without_interval</para></remarks>
    /// <seealso href="http://purl.org/ontology/chord/without_interval">http://purl.org/ontology/chord/without_interval</seealso>
    let without_interval = Prefixed_Name(chord, "without_interval") |> PrefixedName
    /// <summary>
    ///   <para>chord:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    /// </remarks>
    /// <seealso href="http://purl.org/ontology/chord/">http://purl.org/ontology/chord/</seealso>
    let _prefix_iri = Prefixed_Name(chord, "") |> PrefixedName
    /// <summary>
    ///   <para>chord:aug</para>
    /// </summary>
    /// <remarks>
    ///   <para>chord:Chord</para>
    ///   <para>An augmented chord.</para>
    /// labels<para>aug</para></remarks>
    /// <seealso href="http://purl.org/ontology/chord/aug">http://purl.org/ontology/chord/aug</seealso>
    let aug = Prefixed_Name(chord, "aug") |> PrefixedName
    /// <summary>
    ///   <para>chord:min</para>
    /// </summary>
    /// <remarks>
    ///   <para>chord:Chord</para>
    ///   <para>A minor chord.</para>
    /// labels<para>min</para></remarks>
    /// <seealso href="http://purl.org/ontology/chord/min">http://purl.org/ontology/chord/min</seealso>
    let min = Prefixed_Name(chord, "min") |> PrefixedName
