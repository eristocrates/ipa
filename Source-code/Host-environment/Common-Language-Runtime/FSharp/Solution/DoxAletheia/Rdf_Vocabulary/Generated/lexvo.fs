namespace http.lexvo.org.ontology.hash

open DoxAletheia

module lexvo =
    let _namespace_name = "http://lexvo.org/ontology#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// A CJK character radical.
    /// <see href="http://lexvo.org/ontology#CJKRadical"></see></summary>
    let CJKRadical = _prefix "CJKRadical"
    /// <summary>
    /// An abstract character as defined by the Unicode Standard,
    ///   Version 5, in Chapter 3.4.
    /// <see href="http://lexvo.org/ontology#Character"></see></summary>
    let Character = _prefix "Character"
    /// <summary>
    /// Geographic regions on Earth or elsewhere.
    /// <see href="http://lexvo.org/ontology#GeographicRegion"></see></summary>
    let GeographicRegion = _prefix "GeographicRegion"
    /// <summary>
    /// Groups of human language variants that are or were spoken, written, or signed at some point in time.
    /// <see href="http://lexvo.org/ontology#Language"></see></summary>
    let Language = _prefix "Language"
    /// <summary>
    /// A writing system considered abstractly, i.e. independent
    ///     of language-specific variations.
    /// <see href="http://lexvo.org/ontology#Script"></see></summary>
    let Script = _prefix "Script"
    /// <summary>
    /// A term in a specific language.
    /// <see href="http://lexvo.org/ontology#Term"></see></summary>
    let Term = _prefix "Term"
    /// <summary>
    /// The property of having a broader, more generic concept.
    /// <see href="http://lexvo.org/ontology#broader"></see></summary>
    let broader = _prefix "broader"
    /// <summary>
    /// The property of a CJK character being conventionally
    ///     associated with a CJK character radical.
    /// <see href="http://lexvo.org/ontology#characterRadical"></see></summary>
    let characterRadical = _prefix "characterRadical"
    /// <summary>
    /// The property of a term containing a specific character.
    /// <see href="http://lexvo.org/ontology#containsCharacter"></see></summary>
    let containsCharacter = _prefix "containsCharacter"
    /// <summary>
    /// The property of conceptually evoking some object.
    /// <see href="http://lexvo.org/ontology#evokes"></see></summary>
    let evokes = _prefix "evokes"
    /// <summary>
    /// The property of a character being composed of another character.
    /// <see href="http://lexvo.org/ontology#hasCharacterComponent"></see></summary>
    let hasCharacterComponent = _prefix "hasCharacterComponent"
    /// <summary>
    /// The property of having a member.
    /// <see href="http://lexvo.org/ontology#hasMember"></see></summary>
    let hasMember = _prefix "hasMember"
    /// <summary>
    /// The property of a document being written in a specific script,
    ///     or a language being written or having being written in a specific script by a considerable
    ///     group of language users.
    /// <see href="http://lexvo.org/ontology#inScript"></see></summary>
    let inScript = _prefix "inScript"
    /// <summary>
    /// The property of being involved in something, e.g. for semantic participants' involvement in a semantic frame.
    /// <see href="http://lexvo.org/ontology#involvedIn"></see></summary>
    let involvedIn = _prefix "involvedIn"
    /// <summary>
    /// The property of involving some entity, e.g. for semantic participants involved in a semantic frame.
    /// <see href="http://lexvo.org/ontology#involves"></see></summary>
    let involves = _prefix "involves"
    /// <summary>
    ///   <see href="http://lexvo.org/ontology#isFocusOf"></see>
    /// </summary>
    let isFocusOf = _prefix "isFocusOf"
    /// <summary>
    ///   <see href="http://lexvo.org/ontology#iso15924Alphacode"></see>
    /// </summary>
    let iso15924Alphacode = _prefix "iso15924Alphacode"
    /// <summary>
    ///   <see href="http://lexvo.org/ontology#iso639P1Code"></see>
    /// </summary>
    let iso639P1Code = _prefix "iso639P1Code"
    /// <summary>
    ///   <see href="http://lexvo.org/ontology#iso639P2BCode"></see>
    /// </summary>
    let iso639P2BCode = _prefix "iso639P2BCode"
    /// <summary>
    ///   <see href="http://lexvo.org/ontology#iso639P2TCode"></see>
    /// </summary>
    let iso639P2TCode = _prefix "iso639P2TCode"
    /// <summary>
    ///   <see href="http://lexvo.org/ontology#iso639P3Code"></see>
    /// </summary>
    let iso639P3Code = _prefix "iso639P3Code"
    /// <summary>
    ///   <see href="http://lexvo.org/ontology#iso639P5Code"></see>
    /// </summary>
    let iso639P5Code = _prefix "iso639P5Code"
    /// <summary>
    /// the semiotic property of possessing a natural language label (as opposed to artificial identifiers), e.g. the city of Paris is lexicalized in Italian using the Italian term "Parigi".
    /// If C lvont:Label L and L skosxl:literalForm V, then X rdfs:label V.
    /// <see href="http://lexvo.org/ontology#label"></see></summary>
    let label = _prefix "label"
    /// <summary>
    ///   <see href="http://lexvo.org/ontology#representedBy"></see>
    /// </summary>
    let representedBy = _prefix "representedBy"
    /// <summary>
    /// the semiotic property of a natural language word meaning something, i.e. a
    ///     relationship between words and resources that they represent (or represented) to a considerable number of humans
    /// <see href="http://lexvo.org/ontology#means"></see></summary>
    let means = _prefix "means"
    /// <summary>
    /// The property of a resource being mainly encoded in a specific language.
    /// <see href="http://lexvo.org/ontology#language"></see></summary>
    let language = _prefix "language"
    /// <summary>
    /// A lexical category that a term can be used in.
    /// <see href="http://lexvo.org/ontology#lexicalCategory"></see></summary>
    let lexicalCategory = _prefix "lexicalCategory"
    /// <summary>
    ///   <see href="http://lexvo.org/ontology#marcCode"></see>
    /// </summary>
    let marcCode = _prefix "marcCode"
    /// <summary>
    /// the semiotic property of semantically representing something, i.e. a
    ///     relationship between words and other signs and resources that they represent (or represented) to a considerable number of humans
    /// <see href="http://lexvo.org/ontology#represents"></see></summary>
    let represents = _prefix "represents"
    /// <summary>
    /// The property of being a member of a group.
    /// <see href="http://lexvo.org/ontology#memberOf"></see></summary>
    let memberOf = _prefix "memberOf"
    /// <summary>
    /// The property of having a narrower, less generic concept.
    /// <see href="http://lexvo.org/ontology#narrower"></see></summary>
    let narrower = _prefix "narrower"
    /// <summary>
    /// The property of being at least nearly the same as something else. For instance,
    ///     the geographical area comprising the island of Malta is nearly the same as the island of Malta.
    /// <see href="http://lexvo.org/ontology#nearlySameAs"></see></summary>
    let nearlySameAs = _prefix "nearlySameAs"
    /// <summary>
    /// The property of being at least somewhat the same as something else. For instance,
    ///     the City of Los Angeles is somewhat the same as the Greater Los Angeles area.
    /// <see href="http://lexvo.org/ontology#somewhatSameAs"></see></summary>
    let somewhatSameAs = _prefix "somewhatSameAs"
    /// <summary>
    /// The property of a character conventionally being
    ///     written with a specific number strokes, excluding the strokes of its radical.
    /// <see href="http://lexvo.org/ontology#nonRadicalStrokes"></see></summary>
    let nonRadicalStrokes = _prefix "nonRadicalStrokes"
    /// <summary>
    /// The property of a script being used for a particular language by
    ///    a considerable of language users (but not necessarily the majority of all language users).
    /// <see href="http://lexvo.org/ontology#scriptFor"></see></summary>
    let scriptFor = _prefix "scriptFor"
    /// <summary>
    /// The property of a language being written or having being written in a specific
    ///     script by a considerable group of language users.
    /// <see href="http://lexvo.org/ontology#usesScript"></see></summary>
    let usesScript = _prefix "usesScript"
    /// <summary>
    /// The strength of an rdf:Statement, given is a value in [0,1].
    /// <see href="http://lexvo.org/ontology#strength"></see></summary>
    let strength = _prefix "strength"
    /// <summary>
    /// The property of genuine identity in the Leibnizian sense.
    /// <see href="http://lexvo.org/ontology#strictlySameAs"></see></summary>
    let strictlySameAs = _prefix "strictlySameAs"
    /// <summary>
    /// translational equivalence between words and other signs
    ///     and resources that they represent to or represented to a considerable number of humans
    /// <see href="http://lexvo.org/ontology#translation"></see></summary>
    let translation = _prefix "translation"
    /// <summary>
    /// The property of a language or writing system
    ///     being used somewhat extensively in a particular geographical region
    ///     at some point in time.
    /// <see href="http://lexvo.org/ontology#usedIn"></see></summary>
    let usedIn = _prefix "usedIn"
    /// <summary>
    /// The property of being a variant of another resource.
    /// <see href="http://lexvo.org/ontology#variant"></see></summary>
    let variant = _prefix "variant"
