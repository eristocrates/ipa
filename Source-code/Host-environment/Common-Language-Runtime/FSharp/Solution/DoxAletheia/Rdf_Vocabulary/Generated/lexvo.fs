namespace http.lexvo.org.ontology.hash

open DoxAletheia.Rdf_Vocabulary

module lexvo =
    let _namespace_name = "http://lexvo.org/ontology#"
    /// <summary>
    /// A CJK character radical.
    /// <see href="http://lexvo.org/ontology#CJKRadical"></see></summary>
    let CJKRadical = Namespaced_IRI.parse _namespace_name "CJKRadical" |> NamespacedName
    /// <summary>
    /// An abstract character as defined by the Unicode Standard,
    ///   Version 5, in Chapter 3.4.
    /// <see href="http://lexvo.org/ontology#Character"></see></summary>
    let Character = Namespaced_IRI.parse _namespace_name "Character" |> NamespacedName

    /// <summary>
    /// Geographic regions on Earth or elsewhere.
    /// <see href="http://lexvo.org/ontology#GeographicRegion"></see></summary>
    let GeographicRegion =
        Namespaced_IRI.parse _namespace_name "GeographicRegion" |> NamespacedName

    /// <summary>
    /// Groups of human language variants that are or were spoken, written, or signed at some point in time.
    /// <see href="http://lexvo.org/ontology#Language"></see></summary>
    let Language = Namespaced_IRI.parse _namespace_name "Language" |> NamespacedName
    /// <summary>
    /// A writing system considered abstractly, i.e. independent
    ///     of language-specific variations.
    /// <see href="http://lexvo.org/ontology#Script"></see></summary>
    let Script = Namespaced_IRI.parse _namespace_name "Script" |> NamespacedName
    /// <summary>
    /// A term in a specific language.
    /// <see href="http://lexvo.org/ontology#Term"></see></summary>
    let Term = Namespaced_IRI.parse _namespace_name "Term" |> NamespacedName
    /// <summary>
    /// The property of having a broader, more generic concept.
    /// <see href="http://lexvo.org/ontology#broader"></see></summary>
    let broader = Namespaced_IRI.parse _namespace_name "broader" |> NamespacedName

    /// <summary>
    /// The property of a CJK character being conventionally
    ///     associated with a CJK character radical.
    /// <see href="http://lexvo.org/ontology#characterRadical"></see></summary>
    let characterRadical =
        Namespaced_IRI.parse _namespace_name "characterRadical" |> NamespacedName

    /// <summary>
    /// The property of a term containing a specific character.
    /// <see href="http://lexvo.org/ontology#containsCharacter"></see></summary>
    let containsCharacter =
        Namespaced_IRI.parse _namespace_name "containsCharacter" |> NamespacedName

    /// <summary>
    /// The property of conceptually evoking some object.
    /// <see href="http://lexvo.org/ontology#evokes"></see></summary>
    let evokes = Namespaced_IRI.parse _namespace_name "evokes" |> NamespacedName

    /// <summary>
    /// The property of a character being composed of another character.
    /// <see href="http://lexvo.org/ontology#hasCharacterComponent"></see></summary>
    let hasCharacterComponent =
        Namespaced_IRI.parse _namespace_name "hasCharacterComponent" |> NamespacedName

    /// <summary>
    /// The property of having a member.
    /// <see href="http://lexvo.org/ontology#hasMember"></see></summary>
    let hasMember = Namespaced_IRI.parse _namespace_name "hasMember" |> NamespacedName
    /// <summary>
    /// The property of a document being written in a specific script,
    ///     or a language being written or having being written in a specific script by a considerable
    ///     group of language users.
    /// <see href="http://lexvo.org/ontology#inScript"></see></summary>
    let inScript = Namespaced_IRI.parse _namespace_name "inScript" |> NamespacedName
    /// <summary>
    /// The property of being involved in something, e.g. for semantic participants' involvement in a semantic frame.
    /// <see href="http://lexvo.org/ontology#involvedIn"></see></summary>
    let involvedIn = Namespaced_IRI.parse _namespace_name "involvedIn" |> NamespacedName
    /// <summary>
    /// The property of involving some entity, e.g. for semantic participants involved in a semantic frame.
    /// <see href="http://lexvo.org/ontology#involves"></see></summary>
    let involves = Namespaced_IRI.parse _namespace_name "involves" |> NamespacedName
    /// <summary>
    ///   <see href="http://lexvo.org/ontology#isFocusOf"></see>
    /// </summary>
    let isFocusOf = Namespaced_IRI.parse _namespace_name "isFocusOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://lexvo.org/ontology#iso15924Alphacode"></see>
    /// </summary>
    let iso15924Alphacode =
        Namespaced_IRI.parse _namespace_name "iso15924Alphacode" |> NamespacedName

    /// <summary>
    ///   <see href="http://lexvo.org/ontology#iso639P1Code"></see>
    /// </summary>
    let iso639P1Code =
        Namespaced_IRI.parse _namespace_name "iso639P1Code" |> NamespacedName

    /// <summary>
    ///   <see href="http://lexvo.org/ontology#iso639P2BCode"></see>
    /// </summary>
    let iso639P2BCode =
        Namespaced_IRI.parse _namespace_name "iso639P2BCode" |> NamespacedName

    /// <summary>
    ///   <see href="http://lexvo.org/ontology#iso639P2TCode"></see>
    /// </summary>
    let iso639P2TCode =
        Namespaced_IRI.parse _namespace_name "iso639P2TCode" |> NamespacedName

    /// <summary>
    ///   <see href="http://lexvo.org/ontology#iso639P3Code"></see>
    /// </summary>
    let iso639P3Code =
        Namespaced_IRI.parse _namespace_name "iso639P3Code" |> NamespacedName

    /// <summary>
    ///   <see href="http://lexvo.org/ontology#iso639P5Code"></see>
    /// </summary>
    let iso639P5Code =
        Namespaced_IRI.parse _namespace_name "iso639P5Code" |> NamespacedName

    /// <summary>
    /// the semiotic property of possessing a natural language label (as opposed to artificial identifiers), e.g. the city of Paris is lexicalized in Italian using the Italian term "Parigi".
    /// If C lvont:Label L and L skosxl:literalForm V, then X rdfs:label V.
    /// <see href="http://lexvo.org/ontology#label"></see></summary>
    let label = Namespaced_IRI.parse _namespace_name "label" |> NamespacedName

    /// <summary>
    ///   <see href="http://lexvo.org/ontology#representedBy"></see>
    /// </summary>
    let representedBy =
        Namespaced_IRI.parse _namespace_name "representedBy" |> NamespacedName

    /// <summary>
    /// the semiotic property of a natural language word meaning something, i.e. a
    ///     relationship between words and resources that they represent (or represented) to a considerable number of humans
    /// <see href="http://lexvo.org/ontology#means"></see></summary>
    let means = Namespaced_IRI.parse _namespace_name "means" |> NamespacedName
    /// <summary>
    /// The property of a resource being mainly encoded in a specific language.
    /// <see href="http://lexvo.org/ontology#language"></see></summary>
    let language = Namespaced_IRI.parse _namespace_name "language" |> NamespacedName

    /// <summary>
    /// A lexical category that a term can be used in.
    /// <see href="http://lexvo.org/ontology#lexicalCategory"></see></summary>
    let lexicalCategory =
        Namespaced_IRI.parse _namespace_name "lexicalCategory" |> NamespacedName

    /// <summary>
    ///   <see href="http://lexvo.org/ontology#marcCode"></see>
    /// </summary>
    let marcCode = Namespaced_IRI.parse _namespace_name "marcCode" |> NamespacedName
    /// <summary>
    /// the semiotic property of semantically representing something, i.e. a
    ///     relationship between words and other signs and resources that they represent (or represented) to a considerable number of humans
    /// <see href="http://lexvo.org/ontology#represents"></see></summary>
    let represents = Namespaced_IRI.parse _namespace_name "represents" |> NamespacedName
    /// <summary>
    /// The property of being a member of a group.
    /// <see href="http://lexvo.org/ontology#memberOf"></see></summary>
    let memberOf = Namespaced_IRI.parse _namespace_name "memberOf" |> NamespacedName
    /// <summary>
    /// The property of having a narrower, less generic concept.
    /// <see href="http://lexvo.org/ontology#narrower"></see></summary>
    let narrower = Namespaced_IRI.parse _namespace_name "narrower" |> NamespacedName

    /// <summary>
    /// The property of being at least nearly the same as something else. For instance,
    ///     the geographical area comprising the island of Malta is nearly the same as the island of Malta.
    /// <see href="http://lexvo.org/ontology#nearlySameAs"></see></summary>
    let nearlySameAs =
        Namespaced_IRI.parse _namespace_name "nearlySameAs" |> NamespacedName

    /// <summary>
    /// The property of being at least somewhat the same as something else. For instance,
    ///     the City of Los Angeles is somewhat the same as the Greater Los Angeles area.
    /// <see href="http://lexvo.org/ontology#somewhatSameAs"></see></summary>
    let somewhatSameAs =
        Namespaced_IRI.parse _namespace_name "somewhatSameAs" |> NamespacedName

    /// <summary>
    /// The property of a character conventionally being
    ///     written with a specific number strokes, excluding the strokes of its radical.
    /// <see href="http://lexvo.org/ontology#nonRadicalStrokes"></see></summary>
    let nonRadicalStrokes =
        Namespaced_IRI.parse _namespace_name "nonRadicalStrokes" |> NamespacedName

    /// <summary>
    /// The property of a script being used for a particular language by
    ///    a considerable of language users (but not necessarily the majority of all language users).
    /// <see href="http://lexvo.org/ontology#scriptFor"></see></summary>
    let scriptFor = Namespaced_IRI.parse _namespace_name "scriptFor" |> NamespacedName
    /// <summary>
    /// The property of a language being written or having being written in a specific
    ///     script by a considerable group of language users.
    /// <see href="http://lexvo.org/ontology#usesScript"></see></summary>
    let usesScript = Namespaced_IRI.parse _namespace_name "usesScript" |> NamespacedName
    /// <summary>
    /// The strength of an rdf:Statement, given is a value in [0,1].
    /// <see href="http://lexvo.org/ontology#strength"></see></summary>
    let strength = Namespaced_IRI.parse _namespace_name "strength" |> NamespacedName

    /// <summary>
    /// The property of genuine identity in the Leibnizian sense.
    /// <see href="http://lexvo.org/ontology#strictlySameAs"></see></summary>
    let strictlySameAs =
        Namespaced_IRI.parse _namespace_name "strictlySameAs" |> NamespacedName

    /// <summary>
    /// translational equivalence between words and other signs
    ///     and resources that they represent to or represented to a considerable number of humans
    /// <see href="http://lexvo.org/ontology#translation"></see></summary>
    let translation =
        Namespaced_IRI.parse _namespace_name "translation" |> NamespacedName

    /// <summary>
    /// The property of a language or writing system
    ///     being used somewhat extensively in a particular geographical region
    ///     at some point in time.
    /// <see href="http://lexvo.org/ontology#usedIn"></see></summary>
    let usedIn = Namespaced_IRI.parse _namespace_name "usedIn" |> NamespacedName
    /// <summary>
    /// The property of being a variant of another resource.
    /// <see href="http://lexvo.org/ontology#variant"></see></summary>
    let variant = Namespaced_IRI.parse _namespace_name "variant" |> NamespacedName
