namespace http.www.purl.org.net.remetca.hash

open DoxAletheia.Rdf_Vocabulary

module remetca =
    let _namespace_name = "http://www.purl.org/net/remetca#"
    /// <summary>
    /// Equivalent to TEI
    /// <see href="http://www.purl.org/net/remetca#Poem"></see></summary>
    let Poem = Namespaced_IRI.parse _namespace_name "Poem" |> NamespacedName

    /// <summary>
    /// Complete literary work in which one or more poems are inserted
    /// <see href="http://www.purl.org/net/remetca#Complete_work"></see></summary>
    let Complete_work =
        Namespaced_IRI.parse _namespace_name "Complete_work" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.purl.org/net/remetca#Accentual_versification"></see>
    /// </summary>
    let Accentual_versification =
        Namespaced_IRI.parse _namespace_name "Accentual_versification" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.purl.org/net/remetca#versification_System"></see>
    /// </summary>
    let versification_System =
        Namespaced_IRI.parse _namespace_name "versification_System" |> NamespacedName

    /// <summary>
    /// Equivalent to TEI &lt;edition&gt;
    ///             http://www.tei-c.org/release/doc/tei-p5-doc/en/html/ref-edition.html
    /// <see href="http://www.purl.org/net/remetca#Edition"></see></summary>
    let Edition = Namespaced_IRI.parse _namespace_name "Edition" |> NamespacedName
    /// <summary>
    /// Equivalent to TEI &lt;l&gt;
    ///             http://www.tei-c.org/release/doc/tei-p5-doc/en/html/ref-l.html
    /// <see href="http://www.purl.org/net/remetca#Line"></see></summary>
    let Line = Namespaced_IRI.parse _namespace_name "Line" |> NamespacedName
    /// <summary>
    /// Equivalent to TEI &lt;idno&gt;
    ///             http://www.tei-c.org/release/doc/tei-p5-doc/en/html/ref-idno.html inside
    ///             &lt;msIdentifier&gt;
    ///             http://www.tei-c.org/release/doc/tei-p5-doc/en/html/ref-msIdentifier.html and inside
    ///             &lt;msDesc&gt;
    /// <see href="http://www.purl.org/net/remetca#Manuscript"></see></summary>
    let Manuscript = Namespaced_IRI.parse _namespace_name "Manuscript" |> NamespacedName
    /// <summary>
    /// Equals to TEI &lt;lg&gt;
    ///             http://www.tei-c.org/release/doc/tei-p5-doc/en/html/ref-lg.html
    /// <see href="http://www.purl.org/net/remetca#Stanza"></see></summary>
    let Stanza = Namespaced_IRI.parse _namespace_name "Stanza" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.purl.org/net/remetca#Syllabic_versification"></see>
    /// </summary>
    let Syllabic_versification =
        Namespaced_IRI.parse _namespace_name "Syllabic_versification" |> NamespacedName

    /// <summary>
    /// Equals to TEI &lt;syll&gt;
    ///             http://www.tei-c.org/release/doc/tei-p5-doc/en/html/ref-syll.html or &lt;MetSym&gt;
    ///             http://www.tei-c.org/release/doc/tei-p5-doc/en/html/ref-metSym.html but no exact
    ///             correspondence
    /// <see href="http://www.purl.org/net/remetca#Syllable"></see></summary>
    let Syllable = Namespaced_IRI.parse _namespace_name "Syllable" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.purl.org/net/remetca#asonant"></see>
    /// </summary>
    let asonant = Namespaced_IRI.parse _namespace_name "asonant" |> NamespacedName
    /// <summary>
    /// asonancia="asonante/consonante" (not TEI, added by
    ///             ReMetCa)
    /// <see href="http://www.purl.org/net/remetca#has_rhyme"></see></summary>
    let has_rhyme = Namespaced_IRI.parse _namespace_name "has_rhyme" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.purl.org/net/remetca#consonant"></see>
    /// </summary>
    let consonant = Namespaced_IRI.parse _namespace_name "consonant" |> NamespacedName
    /// <summary>
    /// Related to TEI Attribute:
    /// <see href="http://www.purl.org/net/remetca#hasLines"></see></summary>
    let hasLines = Namespaced_IRI.parse _namespace_name "hasLines" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.purl.org/net/remetca#hasPoems"></see>
    /// </summary>
    let hasPoems = Namespaced_IRI.parse _namespace_name "hasPoems" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.purl.org/net/remetca#hasStanzas"></see>
    /// </summary>
    let hasStanzas = Namespaced_IRI.parse _namespace_name "hasStanzas" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.purl.org/net/remetca#hasSyllables"></see>
    /// </summary>
    let hasSyllables =
        Namespaced_IRI.parse _namespace_name "hasSyllables" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.purl.org/net/remetca#has_caesura"></see>
    /// </summary>
    let has_caesura =
        Namespaced_IRI.parse _namespace_name "has_caesura" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.purl.org/net/remetca#has_incipit"></see>
    /// </summary>
    let has_incipit =
        Namespaced_IRI.parse _namespace_name "has_incipit" |> NamespacedName

    /// <summary>
    /// TEI attribute met &lt;lg met=””&gt;
    /// <see href="http://www.purl.org/net/remetca#has_metrical_scheme"></see></summary>
    let has_metrical_scheme =
        Namespaced_IRI.parse _namespace_name "has_metrical_scheme" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.purl.org/net/remetca#has_musical_notation"></see>
    /// </summary>
    let has_musical_notation =
        Namespaced_IRI.parse _namespace_name "has_musical_notation" |> NamespacedName

    /// <summary>
    /// Equivalent to TEI attribute &lt;lg subtype=""&gt; de lg type
    ///             “estrofa”/cabeza/estribillo" and populated with the controlled vocabulary of
    ///             http://vocabularios.caicyt.gov.ar/pmc/
    /// <see href="http://www.purl.org/net/remetca#has_name_of_stanza"></see></summary>
    let has_name_of_stanza =
        Namespaced_IRI.parse _namespace_name "has_name_of_stanza" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.purl.org/net/remetca#has_number_of_lines"></see>
    /// </summary>
    let has_number_of_lines =
        Namespaced_IRI.parse _namespace_name "has_number_of_lines" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.purl.org/net/remetca#has_number_of_stanzas"></see>
    /// </summary>
    let has_number_of_stanzas =
        Namespaced_IRI.parse _namespace_name "has_number_of_stanzas" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.purl.org/net/remetca#has_number_of_syllables"></see>
    /// </summary>
    let has_number_of_syllables =
        Namespaced_IRI.parse _namespace_name "has_number_of_syllables" |> NamespacedName

    /// <summary>
    /// Equivalent to TEI attribute &lt;lg rhyme=””&gt;
    /// <see href="http://www.purl.org/net/remetca#has_rhymeScheme"></see></summary>
    let has_rhymeScheme =
        Namespaced_IRI.parse _namespace_name "has_rhymeScheme" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.purl.org/net/remetca#has_text"></see>
    /// </summary>
    let has_text = Namespaced_IRI.parse _namespace_name "has_text" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.purl.org/net/remetca#has_title"></see>
    /// </summary>
    let has_title = Namespaced_IRI.parse _namespace_name "has_title" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.purl.org/net/remetca#isAuthorof"></see>
    /// </summary>
    let isAuthorof = Namespaced_IRI.parse _namespace_name "isAuthorof" |> NamespacedName
