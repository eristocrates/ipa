namespace http.lexvo.org.ontology.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module lexvo =
    let _namespace_iri = Namespace_Iri lexvo |> NamespaceIRI
    /// <summary>
    ///   <para>lexvo:iso639P1Code</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>ISO 639-1 code</para></remarks>
    /// <seealso href="http://lexvo.org/ontology#iso639P1Code">http://lexvo.org/ontology#iso639P1Code</seealso>
    let iso639P1Code = Prefixed_Name(lexvo, "iso639P1Code") |> PrefixedName
    /// <summary>
    ///   <para>lexvo:iso639P2TCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>ISO 639-2 Terminological code</para></remarks>
    /// <seealso href="http://lexvo.org/ontology#iso639P2TCode">http://lexvo.org/ontology#iso639P2TCode</seealso>
    let iso639P2TCode = Prefixed_Name(lexvo, "iso639P2TCode") |> PrefixedName
    /// <summary>
    ///   <para>lexvo:CJKRadical</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A CJK character radical.</para>
    /// labels<para>radical</para></remarks>
    /// <seealso href="http://lexvo.org/ontology#CJKRadical">http://lexvo.org/ontology#CJKRadical</seealso>
    let CJKRadical = Prefixed_Name(lexvo, "CJKRadical") |> PrefixedName
    /// <summary>
    ///   <para>lexvo:Language</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Groups of human language variants that are or were spoken, written, or signed at some point in time.</para>
    /// labels<para>language</para></remarks>
    /// <seealso href="http://lexvo.org/ontology#Language">http://lexvo.org/ontology#Language</seealso>
    let Language = Prefixed_Name(lexvo, "Language") |> PrefixedName
    /// <summary>
    ///   <para>lexvo:Script</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A writing system considered abstractly, i.e. independent
    ///     of language-specific variations.</para>
    /// labels<para>script</para></remarks>
    /// <seealso href="http://lexvo.org/ontology#Script">http://lexvo.org/ontology#Script</seealso>
    let Script = Prefixed_Name(lexvo, "Script") |> PrefixedName
    /// <summary>
    ///   <para>lexvo:representedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>represented by</para></remarks>
    /// <seealso href="http://lexvo.org/ontology#representedBy">http://lexvo.org/ontology#representedBy</seealso>
    let representedBy = Prefixed_Name(lexvo, "representedBy") |> PrefixedName
    /// <summary>
    ///   <para>lexvo:memberOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The property of being a member of a group.</para>
    /// labels<para>member of</para></remarks>
    /// <seealso href="http://lexvo.org/ontology#memberOf">http://lexvo.org/ontology#memberOf</seealso>
    let memberOf = Prefixed_Name(lexvo, "memberOf") |> PrefixedName
    /// <summary>
    ///   <para>lexvo:Character</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>An abstract character as defined by the Unicode Standard,
    ///   Version 5, in Chapter 3.4.</para>
    /// labels<para>character</para></remarks>
    /// <seealso href="http://lexvo.org/ontology#Character">http://lexvo.org/ontology#Character</seealso>
    let Character = Prefixed_Name(lexvo, "Character") |> PrefixedName
    /// <summary>
    ///   <para>lexvo:characterRadical</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The property of a CJK character being conventionally
    ///     associated with a CJK character radical.</para>
    /// labels<para>translation</para></remarks>
    /// <seealso href="http://lexvo.org/ontology#characterRadical">http://lexvo.org/ontology#characterRadical</seealso>
    let characterRadical = Prefixed_Name(lexvo, "characterRadical") |> PrefixedName
    /// <summary>
    ///   <para>lexvo:containsCharacter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The property of a term containing a specific character.</para>
    /// labels<para>contains character</para></remarks>
    /// <seealso href="http://lexvo.org/ontology#containsCharacter">http://lexvo.org/ontology#containsCharacter</seealso>
    let containsCharacter = Prefixed_Name(lexvo, "containsCharacter") |> PrefixedName
    /// <summary>
    ///   <para>lexvo:evokes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The property of conceptually evoking some object.</para>
    /// labels<para>evokes</para></remarks>
    /// <seealso href="http://lexvo.org/ontology#evokes">http://lexvo.org/ontology#evokes</seealso>
    let evokes = Prefixed_Name(lexvo, "evokes") |> PrefixedName
    /// <summary>
    ///   <para>lexvo:broader</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The property of having a broader, more generic concept.</para>
    /// labels<para>broader</para></remarks>
    /// <seealso href="http://lexvo.org/ontology#broader">http://lexvo.org/ontology#broader</seealso>
    let broader = Prefixed_Name(lexvo, "broader") |> PrefixedName

    /// <summary>
    ///   <para>lexvo:hasCharacterComponent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The property of a character being composed of another character.</para>
    /// labels<para>character component</para></remarks>
    /// <seealso href="http://lexvo.org/ontology#hasCharacterComponent">http://lexvo.org/ontology#hasCharacterComponent</seealso>
    let hasCharacterComponent =
        Prefixed_Name(lexvo, "hasCharacterComponent") |> PrefixedName

    /// <summary>
    ///   <para>lexvo:inScript</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The property of a document being written in a specific script,
    ///     or a language being written or having being written in a specific script by a considerable
    ///     group of language users.</para>
    /// labels<para>in script</para></remarks>
    /// <seealso href="http://lexvo.org/ontology#inScript">http://lexvo.org/ontology#inScript</seealso>
    let inScript = Prefixed_Name(lexvo, "inScript") |> PrefixedName
    /// <summary>
    ///   <para>lexvo:involves</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The property of involving some entity, e.g. for semantic participants involved in a semantic frame.</para>
    /// labels<para>involves</para></remarks>
    /// <seealso href="http://lexvo.org/ontology#involves">http://lexvo.org/ontology#involves</seealso>
    let involves = Prefixed_Name(lexvo, "involves") |> PrefixedName
    /// <summary>
    ///   <para>lexvo:hasMember</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The property of having a member.</para>
    /// labels<para>has member</para></remarks>
    /// <seealso href="http://lexvo.org/ontology#hasMember">http://lexvo.org/ontology#hasMember</seealso>
    let hasMember = Prefixed_Name(lexvo, "hasMember") |> PrefixedName
    /// <summary>
    ///   <para>lexvo:involvedIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The property of being involved in something, e.g. for semantic participants' involvement in a semantic frame.</para>
    /// labels<para>involved in</para></remarks>
    /// <seealso href="http://lexvo.org/ontology#involvedIn">http://lexvo.org/ontology#involvedIn</seealso>
    let involvedIn = Prefixed_Name(lexvo, "involvedIn") |> PrefixedName
    /// <summary>
    ///   <para>lexvo:iso15924Alphacode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>ISO 15924 alphabetic code</para></remarks>
    /// <seealso href="http://lexvo.org/ontology#iso15924Alphacode">http://lexvo.org/ontology#iso15924Alphacode</seealso>
    let iso15924Alphacode = Prefixed_Name(lexvo, "iso15924Alphacode") |> PrefixedName
    /// <summary>
    ///   <para>lexvo:iso639P5Code</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>ISO 639-5 code</para></remarks>
    /// <seealso href="http://lexvo.org/ontology#iso639P5Code">http://lexvo.org/ontology#iso639P5Code</seealso>
    let iso639P5Code = Prefixed_Name(lexvo, "iso639P5Code") |> PrefixedName
    /// <summary>
    ///   <para>lexvo:isFocusOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>is focus of</para></remarks>
    /// <seealso href="http://lexvo.org/ontology#isFocusOf">http://lexvo.org/ontology#isFocusOf</seealso>
    let isFocusOf = Prefixed_Name(lexvo, "isFocusOf") |> PrefixedName
    /// <summary>
    ///   <para>lexvo:iso639P2BCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>ISO 639-2 Bibliographical code</para></remarks>
    /// <seealso href="http://lexvo.org/ontology#iso639P2BCode">http://lexvo.org/ontology#iso639P2BCode</seealso>
    let iso639P2BCode = Prefixed_Name(lexvo, "iso639P2BCode") |> PrefixedName
    /// <summary>
    ///   <para>lexvo:iso639P3Code</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>ISO 639-3 code</para></remarks>
    /// <seealso href="http://lexvo.org/ontology#iso639P3Code">http://lexvo.org/ontology#iso639P3Code</seealso>
    let iso639P3Code = Prefixed_Name(lexvo, "iso639P3Code") |> PrefixedName
    /// <summary>
    ///   <para>lexvo:means</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>the semiotic property of a natural language word meaning something, i.e. a
    ///     relationship between words and resources that they represent (or represented) to a considerable number of humans</para>
    /// labels<para>means</para></remarks>
    /// <seealso href="http://lexvo.org/ontology#means">http://lexvo.org/ontology#means</seealso>
    let means = Prefixed_Name(lexvo, "means") |> PrefixedName
    /// <summary>
    ///   <para>lexvo:label</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>the semiotic property of possessing a natural language label (as opposed to artificial identifiers), e.g. the city of Paris is lexicalized in Italian using the Italian term "Parigi".</para>
    ///   <para>If C lvont:Label L and L skosxl:literalForm V, then X rdfs:label V.</para>
    /// labels<para>has label</para></remarks>
    /// <seealso href="http://lexvo.org/ontology#label">http://lexvo.org/ontology#label</seealso>
    let label = Prefixed_Name(lexvo, "label") |> PrefixedName
    /// <summary>
    ///   <para>lexvo:language</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The property of a resource being mainly encoded in a specific language.</para>
    /// labels<para>in language</para></remarks>
    /// <seealso href="http://lexvo.org/ontology#language">http://lexvo.org/ontology#language</seealso>
    let language = Prefixed_Name(lexvo, "language") |> PrefixedName
    /// <summary>
    ///   <para>lexvo:marcCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>MARC 21 / USMARC code</para></remarks>
    /// <seealso href="http://lexvo.org/ontology#marcCode">http://lexvo.org/ontology#marcCode</seealso>
    let marcCode = Prefixed_Name(lexvo, "marcCode") |> PrefixedName
    /// <summary>
    ///   <para>lexvo:lexicalCategory</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A lexical category that a term can be used in.</para>
    /// labels<para>lexical category</para></remarks>
    /// <seealso href="http://lexvo.org/ontology#lexicalCategory">http://lexvo.org/ontology#lexicalCategory</seealso>
    let lexicalCategory = Prefixed_Name(lexvo, "lexicalCategory") |> PrefixedName
    /// <summary>
    ///   <para>lexvo:represents</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>the semiotic property of semantically representing something, i.e. a
    ///     relationship between words and other signs and resources that they represent (or represented) to a considerable number of humans</para>
    /// labels<para>represents</para></remarks>
    /// <seealso href="http://lexvo.org/ontology#represents">http://lexvo.org/ontology#represents</seealso>
    let represents = Prefixed_Name(lexvo, "represents") |> PrefixedName
    /// <summary>
    ///   <para>lexvo:narrower</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The property of having a narrower, less generic concept.</para>
    /// labels<para>narrower</para></remarks>
    /// <seealso href="http://lexvo.org/ontology#narrower">http://lexvo.org/ontology#narrower</seealso>
    let narrower = Prefixed_Name(lexvo, "narrower") |> PrefixedName
    /// <summary>
    ///   <para>lexvo:nearlySameAs</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:SymmetricProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The property of being at least nearly the same as something else. For instance,
    ///     the geographical area comprising the island of Malta is nearly the same as the island of Malta.</para>
    /// labels<para>nearly same as</para></remarks>
    /// <seealso href="http://lexvo.org/ontology#nearlySameAs">http://lexvo.org/ontology#nearlySameAs</seealso>
    let nearlySameAs = Prefixed_Name(lexvo, "nearlySameAs") |> PrefixedName
    /// <summary>
    ///   <para>lexvo:somewhatSameAs</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:SymmetricProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The property of being at least somewhat the same as something else. For instance,
    ///     the City of Los Angeles is somewhat the same as the Greater Los Angeles area.</para>
    /// labels<para>somewhat same as</para></remarks>
    /// <seealso href="http://lexvo.org/ontology#somewhatSameAs">http://lexvo.org/ontology#somewhatSameAs</seealso>
    let somewhatSameAs = Prefixed_Name(lexvo, "somewhatSameAs") |> PrefixedName
    /// <summary>
    ///   <para>lexvo:usesScript</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The property of a language being written or having being written in a specific
    ///     script by a considerable group of language users.</para>
    /// labels<para>uses script</para></remarks>
    /// <seealso href="http://lexvo.org/ontology#usesScript">http://lexvo.org/ontology#usesScript</seealso>
    let usesScript = Prefixed_Name(lexvo, "usesScript") |> PrefixedName
    /// <summary>
    ///   <para>lexvo:strength</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>The strength of an rdf:Statement, given is a value in [0,1].</para>
    /// labels<para>strength</para></remarks>
    /// <seealso href="http://lexvo.org/ontology#strength">http://lexvo.org/ontology#strength</seealso>
    let strength = Prefixed_Name(lexvo, "strength") |> PrefixedName
    /// <summary>
    ///   <para>lexvo:strictlySameAs</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:SymmetricProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The property of genuine identity in the Leibnizian sense.</para>
    /// labels<para>same as</para></remarks>
    /// <seealso href="http://lexvo.org/ontology#strictlySameAs">http://lexvo.org/ontology#strictlySameAs</seealso>
    let strictlySameAs = Prefixed_Name(lexvo, "strictlySameAs") |> PrefixedName
    /// <summary>
    ///   <para>lexvo:usedIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The property of a language or writing system
    ///     being used somewhat extensively in a particular geographical region
    ///     at some point in time.</para>
    /// labels<para>used in</para></remarks>
    /// <seealso href="http://lexvo.org/ontology#usedIn">http://lexvo.org/ontology#usedIn</seealso>
    let usedIn = Prefixed_Name(lexvo, "usedIn") |> PrefixedName
    /// <summary>
    ///   <para>lexvo:nonRadicalStrokes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The property of a character conventionally being
    ///     written with a specific number strokes, excluding the strokes of its radical.</para>
    /// labels<para>non-radical strokes</para></remarks>
    /// <seealso href="http://lexvo.org/ontology#nonRadicalStrokes">http://lexvo.org/ontology#nonRadicalStrokes</seealso>
    let nonRadicalStrokes = Prefixed_Name(lexvo, "nonRadicalStrokes") |> PrefixedName
    /// <summary>
    ///   <para>lexvo:translation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:SymmetricProperty</para>
    ///   <para>translational equivalence between words and other signs
    ///     and resources that they represent to or represented to a considerable number of humans</para>
    /// labels<para>translation</para></remarks>
    /// <seealso href="http://lexvo.org/ontology#translation">http://lexvo.org/ontology#translation</seealso>
    let translation = Prefixed_Name(lexvo, "translation") |> PrefixedName
    /// <summary>
    ///   <para>lexvo:variant</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The property of being a variant of another resource.</para>
    /// labels<para>variant</para></remarks>
    /// <seealso href="http://lexvo.org/ontology#variant">http://lexvo.org/ontology#variant</seealso>
    let variant = Prefixed_Name(lexvo, "variant") |> PrefixedName
    /// <summary>
    ///   <para>lexvo:scriptFor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The property of a script being used for a particular language by
    ///    a considerable of language users (but not necessarily the majority of all language users).</para>
    /// labels<para>script for</para></remarks>
    /// <seealso href="http://lexvo.org/ontology#scriptFor">http://lexvo.org/ontology#scriptFor</seealso>
    let scriptFor = Prefixed_Name(lexvo, "scriptFor") |> PrefixedName
    /// <summary>
    ///   <para>lexvo:GeographicRegion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Geographic regions on Earth or elsewhere.</para>
    /// labels<para>geographic region</para></remarks>
    /// <seealso href="http://lexvo.org/ontology#GeographicRegion">http://lexvo.org/ontology#GeographicRegion</seealso>
    let GeographicRegion = Prefixed_Name(lexvo, "GeographicRegion") |> PrefixedName
    /// <summary>
    ///   <para>lexvo:Term</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A term in a specific language.</para>
    /// labels<para>term</para></remarks>
    /// <seealso href="http://lexvo.org/ontology#Term">http://lexvo.org/ontology#Term</seealso>
    let Term = Prefixed_Name(lexvo, "Term") |> PrefixedName
