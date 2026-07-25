namespace http.www.purl.org.net.remetca.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module remetca =
    let _namespace_iri = Namespace_Iri remetca |> NamespaceIRI
    /// <summary>
    ///   <para>remetca:Poem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Equivalent to TEI </para>
    /// </remarks>
    /// <seealso href="http://www.purl.org/net/remetca#Poem">http://www.purl.org/net/remetca#Poem</seealso>
    let Poem = Prefixed_Name(remetca, "Poem") |> PrefixedName

    /// <summary>
    ///   <para>remetca:versification_System</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.purl.org/net/remetca#versification_System">http://www.purl.org/net/remetca#versification_System</seealso>
    let versification_System =
        Prefixed_Name(remetca, "versification_System") |> PrefixedName

    /// <summary>
    ///   <para>remetca:Edition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Equivalent to TEI &lt;edition&gt;
    ///             http://www.tei-c.org/release/doc/tei-p5-doc/en/html/ref-edition.html</para>
    /// </remarks>
    /// <seealso href="http://www.purl.org/net/remetca#Edition">http://www.purl.org/net/remetca#Edition</seealso>
    let Edition = Prefixed_Name(remetca, "Edition") |> PrefixedName
    /// <summary>
    ///   <para>remetca:Stanza</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Equals to TEI &lt;lg&gt;
    ///             http://www.tei-c.org/release/doc/tei-p5-doc/en/html/ref-lg.html</para>
    /// </remarks>
    /// <seealso href="http://www.purl.org/net/remetca#Stanza">http://www.purl.org/net/remetca#Stanza</seealso>
    let Stanza = Prefixed_Name(remetca, "Stanza") |> PrefixedName

    /// <summary>
    ///   <para>remetca:Syllabic_versification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.purl.org/net/remetca#Syllabic_versification">http://www.purl.org/net/remetca#Syllabic_versification</seealso>
    let Syllabic_versification =
        Prefixed_Name(remetca, "Syllabic_versification") |> PrefixedName

    /// <summary>
    ///   <para>remetca:has_rhyme</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>asonancia="asonante/consonante" (not TEI, added by
    ///             ReMetCa)</para>
    /// </remarks>
    /// <seealso href="http://www.purl.org/net/remetca#has_rhyme">http://www.purl.org/net/remetca#has_rhyme</seealso>
    let has_rhyme = Prefixed_Name(remetca, "has_rhyme") |> PrefixedName
    /// <summary>
    ///   <para>remetca:consonant</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://www.purl.org/net/remetca#consonant">http://www.purl.org/net/remetca#consonant</seealso>
    let consonant = Prefixed_Name(remetca, "consonant") |> PrefixedName
    /// <summary>
    ///   <para>remetca:hasLines</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Related to TEI Attribute: </para>
    /// </remarks>
    /// <seealso href="http://www.purl.org/net/remetca#hasLines">http://www.purl.org/net/remetca#hasLines</seealso>
    let hasLines = Prefixed_Name(remetca, "hasLines") |> PrefixedName
    /// <summary>
    ///   <para>remetca:has_incipit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://www.purl.org/net/remetca#has_incipit">http://www.purl.org/net/remetca#has_incipit</seealso>
    let has_incipit = Prefixed_Name(remetca, "has_incipit") |> PrefixedName

    /// <summary>
    ///   <para>remetca:has_metrical_scheme</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>TEI attribute met &lt;lg met=””&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.purl.org/net/remetca#has_metrical_scheme">http://www.purl.org/net/remetca#has_metrical_scheme</seealso>
    let has_metrical_scheme =
        Prefixed_Name(remetca, "has_metrical_scheme") |> PrefixedName

    /// <summary>
    ///   <para>remetca:has_number_of_stanzas</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://www.purl.org/net/remetca#has_number_of_stanzas">http://www.purl.org/net/remetca#has_number_of_stanzas</seealso>
    let has_number_of_stanzas =
        Prefixed_Name(remetca, "has_number_of_stanzas") |> PrefixedName

    /// <summary>
    ///   <para>remetca:has_number_of_syllables</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://www.purl.org/net/remetca#has_number_of_syllables">http://www.purl.org/net/remetca#has_number_of_syllables</seealso>
    let has_number_of_syllables =
        Prefixed_Name(remetca, "has_number_of_syllables") |> PrefixedName

    /// <summary>
    ///   <para>remetca:has_title</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://www.purl.org/net/remetca#has_title">http://www.purl.org/net/remetca#has_title</seealso>
    let has_title = Prefixed_Name(remetca, "has_title") |> PrefixedName
    /// <summary>
    ///   <para>remetca:isAuthorof</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.purl.org/net/remetca#isAuthorof">http://www.purl.org/net/remetca#isAuthorof</seealso>
    let isAuthorof = Prefixed_Name(remetca, "isAuthorof") |> PrefixedName
    /// <summary>
    ///   <para>remetca:Complete_work</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Complete literary work in which one or more poems are inserted</para>
    /// </remarks>
    /// <seealso href="http://www.purl.org/net/remetca#Complete_work">http://www.purl.org/net/remetca#Complete_work</seealso>
    let Complete_work = Prefixed_Name(remetca, "Complete_work") |> PrefixedName

    /// <summary>
    ///   <para>remetca:Accentual_versification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.purl.org/net/remetca#Accentual_versification">http://www.purl.org/net/remetca#Accentual_versification</seealso>
    let Accentual_versification =
        Prefixed_Name(remetca, "Accentual_versification") |> PrefixedName

    /// <summary>
    ///   <para>remetca:Line</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Equivalent to TEI &lt;l&gt;
    ///             http://www.tei-c.org/release/doc/tei-p5-doc/en/html/ref-l.html</para>
    /// </remarks>
    /// <seealso href="http://www.purl.org/net/remetca#Line">http://www.purl.org/net/remetca#Line</seealso>
    let Line = Prefixed_Name(remetca, "Line") |> PrefixedName
    /// <summary>
    ///   <para>remetca:Manuscript</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Equivalent to TEI &lt;idno&gt;
    ///             http://www.tei-c.org/release/doc/tei-p5-doc/en/html/ref-idno.html inside
    ///             &lt;msIdentifier&gt;
    ///             http://www.tei-c.org/release/doc/tei-p5-doc/en/html/ref-msIdentifier.html and inside
    ///             &lt;msDesc&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.purl.org/net/remetca#Manuscript">http://www.purl.org/net/remetca#Manuscript</seealso>
    let Manuscript = Prefixed_Name(remetca, "Manuscript") |> PrefixedName
    /// <summary>
    ///   <para>remetca:Syllable</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Equals to TEI &lt;syll&gt;
    ///             http://www.tei-c.org/release/doc/tei-p5-doc/en/html/ref-syll.html or &lt;MetSym&gt;
    ///             http://www.tei-c.org/release/doc/tei-p5-doc/en/html/ref-metSym.html but no exact
    ///             correspondence</para>
    /// </remarks>
    /// <seealso href="http://www.purl.org/net/remetca#Syllable">http://www.purl.org/net/remetca#Syllable</seealso>
    let Syllable = Prefixed_Name(remetca, "Syllable") |> PrefixedName
    /// <summary>
    ///   <para>remetca:asonant</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://www.purl.org/net/remetca#asonant">http://www.purl.org/net/remetca#asonant</seealso>
    let asonant = Prefixed_Name(remetca, "asonant") |> PrefixedName
    /// <summary>
    ///   <para>remetca:hasPoems</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.purl.org/net/remetca#hasPoems">http://www.purl.org/net/remetca#hasPoems</seealso>
    let hasPoems = Prefixed_Name(remetca, "hasPoems") |> PrefixedName
    /// <summary>
    ///   <para>remetca:hasStanzas</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.purl.org/net/remetca#hasStanzas">http://www.purl.org/net/remetca#hasStanzas</seealso>
    let hasStanzas = Prefixed_Name(remetca, "hasStanzas") |> PrefixedName
    /// <summary>
    ///   <para>remetca:hasSyllables</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.purl.org/net/remetca#hasSyllables">http://www.purl.org/net/remetca#hasSyllables</seealso>
    let hasSyllables = Prefixed_Name(remetca, "hasSyllables") |> PrefixedName
    /// <summary>
    ///   <para>remetca:has_caesura</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://www.purl.org/net/remetca#has_caesura">http://www.purl.org/net/remetca#has_caesura</seealso>
    let has_caesura = Prefixed_Name(remetca, "has_caesura") |> PrefixedName

    /// <summary>
    ///   <para>remetca:has_musical_notation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://www.purl.org/net/remetca#has_musical_notation">http://www.purl.org/net/remetca#has_musical_notation</seealso>
    let has_musical_notation =
        Prefixed_Name(remetca, "has_musical_notation") |> PrefixedName

    /// <summary>
    ///   <para>remetca:has_name_of_stanza</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Equivalent to TEI attribute &lt;lg subtype=""&gt; de lg type
    ///             “estrofa”/cabeza/estribillo" and populated with the controlled vocabulary of
    ///             http://vocabularios.caicyt.gov.ar/pmc/</para>
    /// </remarks>
    /// <seealso href="http://www.purl.org/net/remetca#has_name_of_stanza">http://www.purl.org/net/remetca#has_name_of_stanza</seealso>
    let has_name_of_stanza =
        Prefixed_Name(remetca, "has_name_of_stanza") |> PrefixedName

    /// <summary>
    ///   <para>remetca:has_number_of_lines</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://www.purl.org/net/remetca#has_number_of_lines">http://www.purl.org/net/remetca#has_number_of_lines</seealso>
    let has_number_of_lines =
        Prefixed_Name(remetca, "has_number_of_lines") |> PrefixedName

    /// <summary>
    ///   <para>remetca:has_rhymeScheme</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Equivalent to TEI attribute &lt;lg rhyme=””&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.purl.org/net/remetca#has_rhymeScheme">http://www.purl.org/net/remetca#has_rhymeScheme</seealso>
    let has_rhymeScheme = Prefixed_Name(remetca, "has_rhymeScheme") |> PrefixedName
    /// <summary>
    ///   <para>remetca:has_text</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://www.purl.org/net/remetca#has_text">http://www.purl.org/net/remetca#has_text</seealso>
    let has_text = Prefixed_Name(remetca, "has_text") |> PrefixedName
