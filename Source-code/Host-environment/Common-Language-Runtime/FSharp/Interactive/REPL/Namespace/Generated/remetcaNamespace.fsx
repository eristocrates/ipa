#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module remetca =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://www.purl.org/net/remetca#" "remetca"

    let Accentual_versification = _prefixId.prefix "Accentual_versification"
    /// <summary>
    ///   <para>rdfs:comment : Complete literary work in which one or more poems are inserted^^xsd:string</para>
    ///   <a href="http://www.purl.org/net/remetca#Complete_work">remetca:Complete_work</a>
    /// </summary>
    let Complete_work = _prefixId.prefix "Complete_work"
    /// <summary>
    ///   <para>rdfs:comment : Equivalent to TEI &lt;edition&gt;
    ///             http://www.tei-c.org/release/doc/tei-p5-doc/en/html/ref-edition.html^^xsd:string</para>
    ///   <a href="http://www.purl.org/net/remetca#Edition">remetca:Edition</a>
    /// </summary>
    let Edition = _prefixId.prefix "Edition"
    /// <summary>
    ///   <para>rdfs:comment : Equivalent to TEI &lt;l&gt;
    ///             http://www.tei-c.org/release/doc/tei-p5-doc/en/html/ref-l.html^^xsd:string</para>
    ///   <a href="http://www.purl.org/net/remetca#Line">remetca:Line</a>
    /// </summary>
    let Line = _prefixId.prefix "Line"
    /// <summary>
    ///   <para>rdfs:comment : Equivalent to TEI &lt;idno&gt;
    ///             http://www.tei-c.org/release/doc/tei-p5-doc/en/html/ref-idno.html inside
    ///             &lt;msIdentifier&gt;
    ///             http://www.tei-c.org/release/doc/tei-p5-doc/en/html/ref-msIdentifier.html and inside
    ///             &lt;msDesc&gt;^^xsd:string</para>
    ///   <a href="http://www.purl.org/net/remetca#Manuscript">remetca:Manuscript</a>
    /// </summary>
    let Manuscript = _prefixId.prefix "Manuscript"
    /// <summary>
    ///   <para>rdfs:comment : Equivalent to TEI </para>
    ///   <a href="http://www.purl.org/net/remetca#Poem">remetca:Poem</a>
    /// </summary>
    let Poem = _prefixId.prefix "Poem"
    /// <summary>
    ///   <para>rdfs:comment : Equals to TEI &lt;lg&gt;
    ///             http://www.tei-c.org/release/doc/tei-p5-doc/en/html/ref-lg.html^^xsd:string</para>
    ///   <a href="http://www.purl.org/net/remetca#Stanza">remetca:Stanza</a>
    /// </summary>
    let Stanza = _prefixId.prefix "Stanza"
    let Syllabic_versification = _prefixId.prefix "Syllabic_versification"
    /// <summary>
    ///   <para>rdfs:comment : Equals to TEI &lt;syll&gt;
    ///             http://www.tei-c.org/release/doc/tei-p5-doc/en/html/ref-syll.html or &lt;MetSym&gt;
    ///             http://www.tei-c.org/release/doc/tei-p5-doc/en/html/ref-metSym.html but no exact
    ///             correspondence^^xsd:string</para>
    ///   <a href="http://www.purl.org/net/remetca#Syllable">remetca:Syllable</a>
    /// </summary>
    let Syllable = _prefixId.prefix "Syllable"
    let asonant = _prefixId.prefix "asonant"
    let consonant = _prefixId.prefix "consonant"
    /// <summary>
    ///   <para>rdfs:comment : Related to TEI Attribute: </para>
    ///   <a href="http://www.purl.org/net/remetca#hasLines">remetca:hasLines</a>
    /// </summary>
    let hasLines = _prefixId.prefix "hasLines"
    let hasPoems = _prefixId.prefix "hasPoems"
    let hasStanzas = _prefixId.prefix "hasStanzas"
    let hasSyllables = _prefixId.prefix "hasSyllables"
    let has_caesura = _prefixId.prefix "has_caesura"
    let has_incipit = _prefixId.prefix "has_incipit"
    /// <summary>
    ///   <para>rdfs:comment : TEI attribute met &lt;lg met=””&gt;^^xsd:string</para>
    ///   <a href="http://www.purl.org/net/remetca#has_metrical_scheme">remetca:has_metrical_scheme</a>
    /// </summary>
    let has_metrical_scheme = _prefixId.prefix "has_metrical_scheme"
    let has_musical_notation = _prefixId.prefix "has_musical_notation"
    /// <summary>
    ///   <para>rdfs:comment : Equivalent to TEI attribute &lt;lg subtype=""&gt; de lg type
    ///             “estrofa”/cabeza/estribillo" and populated with the controlled vocabulary of
    ///             http://vocabularios.caicyt.gov.ar/pmc/^^xsd:string</para>
    ///   <a href="http://www.purl.org/net/remetca#has_name_of_stanza">remetca:has_name_of_stanza</a>
    /// </summary>
    let has_name_of_stanza = _prefixId.prefix "has_name_of_stanza"
    let has_number_of_lines = _prefixId.prefix "has_number_of_lines"
    let has_number_of_stanzas = _prefixId.prefix "has_number_of_stanzas"
    let has_number_of_syllables = _prefixId.prefix "has_number_of_syllables"
    /// <summary>
    ///   <para>rdfs:comment : asonancia="asonante/consonante" (not TEI, added by
    ///             ReMetCa)^^xsd:string</para>
    ///   <a href="http://www.purl.org/net/remetca#has_rhyme">remetca:has_rhyme</a>
    /// </summary>
    let has_rhyme = _prefixId.prefix "has_rhyme"
    /// <summary>
    ///   <para>rdfs:comment : Equivalent to TEI attribute &lt;lg rhyme=””&gt;^^xsd:string</para>
    ///   <a href="http://www.purl.org/net/remetca#has_rhymeScheme">remetca:has_rhymeScheme</a>
    /// </summary>
    let has_rhymeScheme = _prefixId.prefix "has_rhymeScheme"
    let has_text = _prefixId.prefix "has_text"
    let has_title = _prefixId.prefix "has_title"
    let isAuthorof = _prefixId.prefix "isAuthorof"
    let versification_System = _prefixId.prefix "versification_System"
