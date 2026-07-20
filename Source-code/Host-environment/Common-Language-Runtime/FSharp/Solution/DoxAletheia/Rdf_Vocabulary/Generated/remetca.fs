namespace http.www.purl.org.net.remetca.hash

open DoxAletheia

module remetca =
    let _namespace_name = "http://www.purl.org/net/remetca#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// Equivalent to TEI
    /// <see href="http://www.purl.org/net/remetca#Poem"></see></summary>
    let Poem = _prefix "Poem"
    /// <summary>
    /// Complete literary work in which one or more poems are inserted
    /// <see href="http://www.purl.org/net/remetca#Complete_work"></see></summary>
    let Complete_work = _prefix "Complete_work"
    /// <summary>
    ///   <see href="http://www.purl.org/net/remetca#Accentual_versification"></see>
    /// </summary>
    let Accentual_versification = _prefix "Accentual_versification"
    /// <summary>
    ///   <see href="http://www.purl.org/net/remetca#versification_System"></see>
    /// </summary>
    let versification_System = _prefix "versification_System"
    /// <summary>
    /// Equivalent to TEI &lt;edition&gt;
    ///             http://www.tei-c.org/release/doc/tei-p5-doc/en/html/ref-edition.html
    /// <see href="http://www.purl.org/net/remetca#Edition"></see></summary>
    let Edition = _prefix "Edition"
    /// <summary>
    /// Equivalent to TEI &lt;l&gt;
    ///             http://www.tei-c.org/release/doc/tei-p5-doc/en/html/ref-l.html
    /// <see href="http://www.purl.org/net/remetca#Line"></see></summary>
    let Line = _prefix "Line"
    /// <summary>
    /// Equivalent to TEI &lt;idno&gt;
    ///             http://www.tei-c.org/release/doc/tei-p5-doc/en/html/ref-idno.html inside
    ///             &lt;msIdentifier&gt;
    ///             http://www.tei-c.org/release/doc/tei-p5-doc/en/html/ref-msIdentifier.html and inside
    ///             &lt;msDesc&gt;
    /// <see href="http://www.purl.org/net/remetca#Manuscript"></see></summary>
    let Manuscript = _prefix "Manuscript"
    /// <summary>
    /// Equals to TEI &lt;lg&gt;
    ///             http://www.tei-c.org/release/doc/tei-p5-doc/en/html/ref-lg.html
    /// <see href="http://www.purl.org/net/remetca#Stanza"></see></summary>
    let Stanza = _prefix "Stanza"
    /// <summary>
    ///   <see href="http://www.purl.org/net/remetca#Syllabic_versification"></see>
    /// </summary>
    let Syllabic_versification = _prefix "Syllabic_versification"
    /// <summary>
    /// Equals to TEI &lt;syll&gt;
    ///             http://www.tei-c.org/release/doc/tei-p5-doc/en/html/ref-syll.html or &lt;MetSym&gt;
    ///             http://www.tei-c.org/release/doc/tei-p5-doc/en/html/ref-metSym.html but no exact
    ///             correspondence
    /// <see href="http://www.purl.org/net/remetca#Syllable"></see></summary>
    let Syllable = _prefix "Syllable"
    /// <summary>
    ///   <see href="http://www.purl.org/net/remetca#asonant"></see>
    /// </summary>
    let asonant = _prefix "asonant"
    /// <summary>
    /// asonancia="asonante/consonante" (not TEI, added by
    ///             ReMetCa)
    /// <see href="http://www.purl.org/net/remetca#has_rhyme"></see></summary>
    let has_rhyme = _prefix "has_rhyme"
    /// <summary>
    ///   <see href="http://www.purl.org/net/remetca#consonant"></see>
    /// </summary>
    let consonant = _prefix "consonant"
    /// <summary>
    /// Related to TEI Attribute:
    /// <see href="http://www.purl.org/net/remetca#hasLines"></see></summary>
    let hasLines = _prefix "hasLines"
    /// <summary>
    ///   <see href="http://www.purl.org/net/remetca#hasPoems"></see>
    /// </summary>
    let hasPoems = _prefix "hasPoems"
    /// <summary>
    ///   <see href="http://www.purl.org/net/remetca#hasStanzas"></see>
    /// </summary>
    let hasStanzas = _prefix "hasStanzas"
    /// <summary>
    ///   <see href="http://www.purl.org/net/remetca#hasSyllables"></see>
    /// </summary>
    let hasSyllables = _prefix "hasSyllables"
    /// <summary>
    ///   <see href="http://www.purl.org/net/remetca#has_caesura"></see>
    /// </summary>
    let has_caesura = _prefix "has_caesura"
    /// <summary>
    ///   <see href="http://www.purl.org/net/remetca#has_incipit"></see>
    /// </summary>
    let has_incipit = _prefix "has_incipit"
    /// <summary>
    /// TEI attribute met &lt;lg met=””&gt;
    /// <see href="http://www.purl.org/net/remetca#has_metrical_scheme"></see></summary>
    let has_metrical_scheme = _prefix "has_metrical_scheme"
    /// <summary>
    ///   <see href="http://www.purl.org/net/remetca#has_musical_notation"></see>
    /// </summary>
    let has_musical_notation = _prefix "has_musical_notation"
    /// <summary>
    /// Equivalent to TEI attribute &lt;lg subtype=""&gt; de lg type
    ///             “estrofa”/cabeza/estribillo" and populated with the controlled vocabulary of
    ///             http://vocabularios.caicyt.gov.ar/pmc/
    /// <see href="http://www.purl.org/net/remetca#has_name_of_stanza"></see></summary>
    let has_name_of_stanza = _prefix "has_name_of_stanza"
    /// <summary>
    ///   <see href="http://www.purl.org/net/remetca#has_number_of_lines"></see>
    /// </summary>
    let has_number_of_lines = _prefix "has_number_of_lines"
    /// <summary>
    ///   <see href="http://www.purl.org/net/remetca#has_number_of_stanzas"></see>
    /// </summary>
    let has_number_of_stanzas = _prefix "has_number_of_stanzas"
    /// <summary>
    ///   <see href="http://www.purl.org/net/remetca#has_number_of_syllables"></see>
    /// </summary>
    let has_number_of_syllables = _prefix "has_number_of_syllables"
    /// <summary>
    /// Equivalent to TEI attribute &lt;lg rhyme=””&gt;
    /// <see href="http://www.purl.org/net/remetca#has_rhymeScheme"></see></summary>
    let has_rhymeScheme = _prefix "has_rhymeScheme"
    /// <summary>
    ///   <see href="http://www.purl.org/net/remetca#has_text"></see>
    /// </summary>
    let has_text = _prefix "has_text"
    /// <summary>
    ///   <see href="http://www.purl.org/net/remetca#has_title"></see>
    /// </summary>
    let has_title = _prefix "has_title"
    /// <summary>
    ///   <see href="http://www.purl.org/net/remetca#isAuthorof"></see>
    /// </summary>
    let isAuthorof = _prefix "isAuthorof"
