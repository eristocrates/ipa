#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module chord =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://purl.org/ontology/chord/" "chord"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:label : Chord^^xsd:string</para>
    ///   <para>rdfs:comment : Two or more notes played together.^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/chord/Chord">chord:Chord</a>
    /// </summary>
    let Chord = _prefixId.prefix "Chord"
    /// <summary>
    ///   <para>rdfs:label : ChordEvent^^xsd:string</para>
    ///   <para>rdfs:comment : A chord being played.^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/chord/ChordEvent">chord:ChordEvent</a>
    /// </summary>
    let ChordEvent = _prefixId.prefix "ChordEvent"
    /// <summary>
    ///   <para>rdfs:label : Interval^^xsd:string</para>
    ///   <para>rdfs:comment : An interval above the root of a chord.^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/chord/Interval">chord:Interval</a>
    /// </summary>
    let Interval = _prefixId.prefix "Interval"
    /// <summary>
    ///   <para>rdfs:label : Modifier^^xsd:string</para>
    ///   <para>rdfs:comment : A modifier applied to a note to change its pitch.^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/chord/Modifier">chord:Modifier</a>
    /// </summary>
    let Modifier = _prefixId.prefix "Modifier"
    /// <summary>
    ///   <para>rdfs:label : Natural^^xsd:string</para>
    ///   <para>rdfs:comment : One of the seven natural notes of the Western music system.^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/chord/Natural">chord:Natural</a>
    /// </summary>
    let Natural = _prefixId.prefix "Natural"
    /// <summary>
    ///   <para>rdfs:label : Note^^xsd:string</para>
    ///   <para>rdfs:comment : FIXME^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/chord/Note">chord:Note</a>
    /// </summary>
    let Note = _prefixId.prefix "Note"
    /// <summary>
    ///   <para>rdfs:label : ScaleInterval^^xsd:string</para>
    ///   <para>rdfs:comment : An interval in the root scale, made up of the degree of the scale and optional modifier.^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/chord/ScaleInterval">chord:ScaleInterval</a>
    /// </summary>
    let ScaleInterval = _prefixId.prefix "ScaleInterval"
    /// <summary>
    ///   <para>rdfs:label : SemitoneInterval^^xsd:string</para>
    ///   <para>rdfs:comment : A semitone interval.^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/chord/SemitoneInterval">chord:SemitoneInterval</a>
    /// </summary>
    let SemitoneInterval = _prefixId.prefix "SemitoneInterval"
    let aug = _prefixId.prefix "aug"
    /// <summary>
    ///   <para>rdfs:label : base_chord^^xsd:string</para>
    ///   <para>rdfs:comment : The chord on which this one is based.
    /// 			For example, a C7 chord might have chord:Cmaj as its base chord.^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/chord/base_chord">chord:base_chord</a>
    /// </summary>
    let base_chord = _prefixId.prefix "base_chord"
    /// <summary>
    ///   <para>rdfs:label : bass^^xsd:string</para>
    ///   <para>rdfs:comment : The bass note of the chord (indicates the inversion).^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/chord/bass">chord:bass</a>
    /// </summary>
    let bass = _prefixId.prefix "bass"
    /// <summary>
    ///   <para>rdfs:label : chord^^xsd:string</para>
    ///   <para>rdfs:comment : The chord associated with a chord event.^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/chord/chord">chord:chord</a>
    /// </summary>
    let chord = _prefixId.prefix "chord"
    /// <summary>
    ///   <para>rdfs:label : degree^^xsd:string</para>
    ///   <para>rdfs:comment : The degree of an interval based on the root of a chord.^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/chord/degree">chord:degree</a>
    /// </summary>
    let degree = _prefixId.prefix "degree"
    let dim = _prefixId.prefix "dim"
    let dim7 = _prefixId.prefix "dim7"
    let doubleflat = _prefixId.prefix "doubleflat"
    let doublesharp = _prefixId.prefix "doublesharp"
    let flat = _prefixId.prefix "flat"
    let hdim7 = _prefixId.prefix "hdim7"
    /// <summary>
    ///   <para>rdfs:label : interval^^xsd:string</para>
    ///   <para>rdfs:comment : An interval from the root which is part of the chord.^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/chord/interval">chord:interval</a>
    /// </summary>
    let interval = _prefixId.prefix "interval"
    let maj = _prefixId.prefix "maj"
    let maj6 = _prefixId.prefix "maj6"
    let maj7 = _prefixId.prefix "maj7"
    let maj9 = _prefixId.prefix "maj9"
    let min = _prefixId.prefix "min"
    let min6 = _prefixId.prefix "min6"
    let min7 = _prefixId.prefix "min7"
    let min9 = _prefixId.prefix "min9"
    let minmaj7 = _prefixId.prefix "minmaj7"
    /// <summary>
    ///   <para>rdfs:label : modifier^^xsd:string</para>
    ///   <para>rdfs:comment : A modification to a note's pitch.^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/chord/modifier">chord:modifier</a>
    /// </summary>
    let modifier = _prefixId.prefix "modifier"
    /// <summary>
    ///   <para>rdfs:label : natural^^xsd:string</para>
    ///   <para>rdfs:comment : The natural from which this note is derived.^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/chord/natural">chord:natural</a>
    /// </summary>
    let natural = _prefixId.prefix "natural"
    let ninth = _prefixId.prefix "ninth"
    let noChord = _prefixId.prefix "noChord"
    /// <summary>
    ///   <para>rdfs:label : root^^xsd:string</para>
    ///   <para>rdfs:comment : The root note of the chord.^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/chord/root">chord:root</a>
    /// </summary>
    let root = _prefixId.prefix "root"
    /// <summary>
    ///   <para>rdfs:label : semitone_interval^^xsd:string</para>
    ///   <para>rdfs:comment : An interval measured in semitones.^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/chord/semitone_interval">chord:semitone_interval</a>
    /// </summary>
    let semitone_interval = _prefixId.prefix "semitone_interval"
    let seventh = _prefixId.prefix "seventh"
    let sharp = _prefixId.prefix "sharp"
    let sus2 = _prefixId.prefix "sus2"
    let sus4 = _prefixId.prefix "sus4"
    /// <summary>
    ///   <para>rdfs:label : without_interval^^xsd:string</para>
    ///   <para>rdfs:comment : A degree of the scale expected in the chord but not actually present here.^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/chord/without_interval">chord:without_interval</a>
    /// </summary>
    let without_interval = _prefixId.prefix "without_interval"
