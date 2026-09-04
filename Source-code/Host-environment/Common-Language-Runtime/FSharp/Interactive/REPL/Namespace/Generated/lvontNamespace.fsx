#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module lvont =
    let _prefixId = PrefixId.fromNamespaceLabel "http://lexvo.org/ontology#" "lvont"
    /// <summary>
    ///   <para>skos:note : CJK radicals are slightly more abstract than characters, because the same radical can be manifested as different
    ///     characters, e.g. radical 4 can take the form of '丿', '乀', or '乁'.</para>
    ///   <para>rdfs:comment : A CJK character radical.</para>
    ///   <para>rdfs:label : radical</para>
    ///   <a href="http://lexvo.org/ontology#CJKRadical">lvont:CJKRadical</a>
    /// </summary>
    let CJKRadical = _prefixId.prefix "CJKRadical"
    /// <summary>
    ///   <para>skos:note : The same abstract character may be rendered in different forms, depending on the language and on typeface characters.</para>
    ///   <para>rdfs:comment : An abstract character as defined by the Unicode Standard,
    ///   Version 5, in Chapter 3.4.</para>
    ///   <para>rdfs:label : character</para>
    ///   <a href="http://lexvo.org/ontology#Character">lvont:Character</a>
    /// </summary>
    let Character = _prefixId.prefix "Character"
    /// <summary>
    ///   <para>rdfs:comment : Geographic regions on Earth or elsewhere.</para>
    ///   <para>rdfs:label : geographic region</para>
    ///   <a href="http://lexvo.org/ontology#GeographicRegion">lvont:GeographicRegion</a>
    /// </summary>
    let GeographicRegion = _prefixId.prefix "GeographicRegion"
    /// <summary>
    ///   <para>skos:note : This definition includes languages, particular language variants (e.g. dialects), and larger groups of language
    ///     variants (e.g. macrolanguages and language families), as the distinction between them is largely conventional.</para>
    ///   <para>rdfs:comment : Groups of human language variants that are or were spoken, written, or signed at some point in time.</para>
    ///   <para>rdfs:label : language</para>
    ///   <a href="http://lexvo.org/ontology#Language">lvont:Language</a>
    /// </summary>
    let Language = _prefixId.prefix "Language"
    /// <summary>
    ///   <para>rdfs:comment : A writing system considered abstractly, i.e. independent
    ///     of language-specific variations.</para>
    ///   <para>rdfs:label : script</para>
    ///   <a href="http://lexvo.org/ontology#Script">lvont:Script</a>
    /// </summary>
    let Script = _prefixId.prefix "Script"
    /// <summary>
    ///   <para>rdfs:comment : A term in a specific language.</para>
    ///   <para>rdfs:label : term</para>
    ///   <a href="http://lexvo.org/ontology#Term">lvont:Term</a>
    /// </summary>
    let Term = _prefixId.prefix "Term"
    /// <summary>
    ///   <para>rdfs:comment : The property of having a broader, more generic concept.</para>
    ///   <para>skos:note : Similar to skos:broader but domain and range are not restricted to skos:Concept instances.</para>
    ///   <para>rdfs:label : broader</para>
    ///   <a href="http://lexvo.org/ontology#broader">lvont:broader</a>
    /// </summary>
    let broader = _prefixId.prefix "broader"
    /// <summary>
    ///   <para>rdfs:comment : The property of a CJK character being conventionally
    ///     associated with a CJK character radical.</para>
    ///   <para>rdfs:label : translation</para>
    ///   <a href="http://lexvo.org/ontology#characterRadical">lvont:characterRadical</a>
    /// </summary>
    let characterRadical = _prefixId.prefix "characterRadical"
    /// <summary>
    ///   <para>rdfs:comment : The property of a term containing a specific character.</para>
    ///   <para>rdfs:label : contains character</para>
    ///   <a href="http://lexvo.org/ontology#containsCharacter">lvont:containsCharacter</a>
    /// </summary>
    let containsCharacter = _prefixId.prefix "containsCharacter"
    /// <summary>
    ///   <para>rdfs:comment : The property of conceptually evoking some object.</para>
    ///   <para>rdfs:label : evokes</para>
    ///   <a href="http://lexvo.org/ontology#evokes">lvont:evokes</a>
    /// </summary>
    let evokes = _prefixId.prefix "evokes"
    /// <summary>
    ///   <para>rdfs:comment : The property of a character being composed of another character.</para>
    ///   <para>skos:note : Especially for CJK characters.</para>
    ///   <para>rdfs:label : character component</para>
    ///   <a href="http://lexvo.org/ontology#hasCharacterComponent">lvont:hasCharacterComponent</a>
    /// </summary>
    let hasCharacterComponent = _prefixId.prefix "hasCharacterComponent"
    /// <summary>
    ///   <para>rdfs:comment : The property of having a member.</para>
    ///   <para>skos:note : For instance for geographic regions.</para>
    ///   <para>rdfs:label : has member</para>
    ///   <a href="http://lexvo.org/ontology#hasMember">lvont:hasMember</a>
    /// </summary>
    let hasMember = _prefixId.prefix "hasMember"
    /// <summary>
    ///   <para>rdfs:comment : The property of a document being written in a specific script,
    ///     or a language being written or having being written in a specific script by a considerable
    ///     group of language users.</para>
    ///   <para>rdfs:label : in script</para>
    ///   <a href="http://lexvo.org/ontology#inScript">lvont:inScript</a>
    /// </summary>
    let inScript = _prefixId.prefix "inScript"
    /// <summary>
    ///   <para>rdfs:comment : The property of being involved in something, e.g. for semantic participants' involvement in a semantic frame.</para>
    ///   <para>rdfs:label : involved in</para>
    ///   <a href="http://lexvo.org/ontology#involvedIn">lvont:involvedIn</a>
    /// </summary>
    let involvedIn = _prefixId.prefix "involvedIn"
    /// <summary>
    ///   <para>rdfs:comment : The property of involving some entity, e.g. for semantic participants involved in a semantic frame.</para>
    ///   <para>rdfs:label : involves</para>
    ///   <a href="http://lexvo.org/ontology#involves">lvont:involves</a>
    /// </summary>
    let involves = _prefixId.prefix "involves"
    /// <summary>
    ///   <para>skos:note : The isFocusOf relates an entity to relevant SKOS concepts
    ///     that are conceptualizations of the same entity. This is the inverse of the
    ///     standard foaf:focus property, which connects a SKOS concept to a relevant
    ///     non-conceptualized entity.</para>
    ///   <para>rdfs:label : is focus of</para>
    ///   <a href="http://lexvo.org/ontology#isFocusOf">lvont:isFocusOf</a>
    /// </summary>
    let isFocusOf = _prefixId.prefix "isFocusOf"
    /// <summary>
    ///   <para>rdfs:label : ISO 15924 alphabetic code</para>
    ///   <a href="http://lexvo.org/ontology#iso15924Alphacode">lvont:iso15924Alphacode</a>
    /// </summary>
    let iso15924Alphacode = _prefixId.prefix "iso15924Alphacode"
    /// <summary>
    ///   <para>rdfs:label : ISO 639-1 code</para>
    ///   <a href="http://lexvo.org/ontology#iso639P1Code">lvont:iso639P1Code</a>
    /// </summary>
    let iso639P1Code = _prefixId.prefix "iso639P1Code"
    /// <summary>
    ///   <para>rdfs:label : ISO 639-2 Bibliographical code</para>
    ///   <a href="http://lexvo.org/ontology#iso639P2BCode">lvont:iso639P2BCode</a>
    /// </summary>
    let iso639P2BCode = _prefixId.prefix "iso639P2BCode"
    /// <summary>
    ///   <para>rdfs:label : ISO 639-2 Terminological code</para>
    ///   <a href="http://lexvo.org/ontology#iso639P2TCode">lvont:iso639P2TCode</a>
    /// </summary>
    let iso639P2TCode = _prefixId.prefix "iso639P2TCode"
    /// <summary>
    ///   <para>rdfs:label : ISO 639-3 code</para>
    ///   <a href="http://lexvo.org/ontology#iso639P3Code">lvont:iso639P3Code</a>
    /// </summary>
    let iso639P3Code = _prefixId.prefix "iso639P3Code"
    /// <summary>
    ///   <para>rdfs:label : ISO 639-5 code</para>
    ///   <a href="http://lexvo.org/ontology#iso639P5Code">lvont:iso639P5Code</a>
    /// </summary>
    let iso639P5Code = _prefixId.prefix "iso639P5Code"
    /// <summary>
    ///   <para>rdfs:comment : the semiotic property of possessing a natural language label (as opposed to artificial identifiers), e.g. the city of Paris is lexicalized in Italian using the Italian term "Parigi".rdfs:comment : If C lvont:Label L and L skosxl:literalForm V, then X rdfs:label V.</para>
    ///   <para>skos:note : This property is more general than skosxl:prefLabel and skosxl:altLabel, as it does not make any normative claims about which labels are preferred. It merely describes
    ///     the fact that a certain label can be used to refer to something.</para>
    ///   <para>rdfs:label : has label</para>
    ///   <a href="http://lexvo.org/ontology#label">lvont:label</a>
    /// </summary>
    let label = _prefixId.prefix "label"
    /// <summary>
    ///   <para>rdfs:comment : The property of a resource being mainly encoded in a specific language.</para>
    ///   <para>rdfs:label : in language</para>
    ///   <a href="http://lexvo.org/ontology#language">lvont:language</a>
    /// </summary>
    let language = _prefixId.prefix "language"
    /// <summary>
    ///   <para>rdfs:comment : A lexical category that a term can be used in.</para>
    ///   <para>skos:note :  For example, the English term "score" can be used as a noun and as a verb.</para>
    ///   <para>rdfs:label : lexical category</para>
    ///   <a href="http://lexvo.org/ontology#lexicalCategory">lvont:lexicalCategory</a>
    /// </summary>
    let lexicalCategory = _prefixId.prefix "lexicalCategory"
    /// <summary>
    ///   <para>rdfs:label : MARC 21 / USMARC code</para>
    ///   <a href="http://lexvo.org/ontology#marcCode">lvont:marcCode</a>
    /// </summary>
    let marcCode = _prefixId.prefix "marcCode"
    /// <summary>
    ///   <para>rdfs:comment : the semiotic property of a natural language word meaning something, i.e. a
    ///     relationship between words and resources that they represent (or represented) to a considerable number of humans</para>
    ///   <para>rdfs:label : means</para>
    ///   <a href="http://lexvo.org/ontology#means">lvont:means</a>
    /// </summary>
    let means = _prefixId.prefix "means"
    /// <summary>
    ///   <para>rdfs:comment : The property of being a member of a group.</para>
    ///   <para>skos:note : For instance for geographic regions.</para>
    ///   <para>rdfs:label : member of</para>
    ///   <a href="http://lexvo.org/ontology#memberOf">lvont:memberOf</a>
    /// </summary>
    let memberOf = _prefixId.prefix "memberOf"
    /// <summary>
    ///   <para>rdfs:comment : The property of having a narrower, less generic concept.</para>
    ///   <para>skos:note : Similar to skos:narrower but domain and range are not restricted to skos:Concept instances.</para>
    ///   <para>rdfs:label : narrower</para>
    ///   <a href="http://lexvo.org/ontology#narrower">lvont:narrower</a>
    /// </summary>
    let narrower = _prefixId.prefix "narrower"
    /// <summary>
    ///   <para>rdfs:comment : The property of being at least nearly the same as something else. For instance,
    ///     the geographical area comprising the island of Malta is nearly the same as the island of Malta.</para>
    ///   <para>rdfs:label : nearly same as</para>
    ///   <a href="http://lexvo.org/ontology#nearlySameAs">lvont:nearlySameAs</a>
    /// </summary>
    let nearlySameAs = _prefixId.prefix "nearlySameAs"
    /// <summary>
    ///   <para>rdfs:comment : The property of a character conventionally being
    ///     written with a specific number strokes, excluding the strokes of its radical.</para>
    ///   <para>skos:note : Especially for CJK characters.</para>
    ///   <para>rdfs:label : non-radical strokes</para>
    ///   <a href="http://lexvo.org/ontology#nonRadicalStrokes">lvont:nonRadicalStrokes</a>
    /// </summary>
    let nonRadicalStrokes = _prefixId.prefix "nonRadicalStrokes"
    /// <summary>
    ///   <para>rdfs:label : represented by</para>
    ///   <a href="http://lexvo.org/ontology#representedBy">lvont:representedBy</a>
    /// </summary>
    let representedBy = _prefixId.prefix "representedBy"
    /// <summary>
    ///   <para>rdfs:comment : the semiotic property of semantically representing something, i.e. a
    ///     relationship between words and other signs and resources that they represent (or represented) to a considerable number of humans</para>
    ///   <para>rdfs:label : represents</para>
    ///   <a href="http://lexvo.org/ontology#represents">lvont:represents</a>
    /// </summary>
    let represents = _prefixId.prefix "represents"
    /// <summary>
    ///   <para>rdfs:comment : The property of a script being used for a particular language by
    ///    a considerable of language users (but not necessarily the majority of all language users).</para>
    ///   <para>rdfs:label : script for</para>
    ///   <a href="http://lexvo.org/ontology#scriptFor">lvont:scriptFor</a>
    /// </summary>
    let scriptFor = _prefixId.prefix "scriptFor"
    /// <summary>
    ///   <para>rdfs:comment : The property of being at least somewhat the same as something else. For instance,
    ///     the City of Los Angeles is somewhat the same as the Greater Los Angeles area.</para>
    ///   <para>rdfs:label : somewhat same as</para>
    ///   <a href="http://lexvo.org/ontology#somewhatSameAs">lvont:somewhatSameAs</a>
    /// </summary>
    let somewhatSameAs = _prefixId.prefix "somewhatSameAs"
    /// <summary>
    ///   <para>rdfs:comment : The strength of an rdf:Statement, given is a value in [0,1].</para>
    ///   <para>rdfs:label : strength</para>
    ///   <a href="http://lexvo.org/ontology#strength">lvont:strength</a>
    /// </summary>
    let strength = _prefixId.prefix "strength"
    /// <summary>
    ///   <para>rdfs:comment : The property of genuine identity in the Leibnizian sense.</para>
    ///   <para>rdfs:label : same as</para>
    ///   <a href="http://lexvo.org/ontology#strictlySameAs">lvont:strictlySameAs</a>
    /// </summary>
    let strictlySameAs = _prefixId.prefix "strictlySameAs"
    /// <summary>
    ///   <para>rdfs:comment : translational equivalence between words and other signs
    ///     and resources that they represent to or represented to a considerable number of humans</para>
    ///   <para>skos:note : Domain and range are usually Term objects, however string literals are acceptable as well for the range.</para>
    ///   <para>rdfs:label : translation</para>
    ///   <a href="http://lexvo.org/ontology#translation">lvont:translation</a>
    /// </summary>
    let translation = _prefixId.prefix "translation"
    /// <summary>
    ///   <para>rdfs:comment : The property of a language or writing system
    ///     being used somewhat extensively in a particular geographical region
    ///     at some point in time.</para>
    ///   <para>rdfs:label : used in</para>
    ///   <a href="http://lexvo.org/ontology#usedIn">lvont:usedIn</a>
    /// </summary>
    let usedIn = _prefixId.prefix "usedIn"
    /// <summary>
    ///   <para>rdfs:comment : The property of a language being written or having being written in a specific
    ///     script by a considerable group of language users.</para>
    ///   <para>rdfs:label : uses script</para>
    ///   <a href="http://lexvo.org/ontology#usesScript">lvont:usesScript</a>
    /// </summary>
    let usesScript = _prefixId.prefix "usesScript"
    /// <summary>
    ///   <para>rdfs:comment : The property of being a variant of another resource.</para>
    ///   <para>skos:note : Especially for terms and characters.</para>
    ///   <para>rdfs:label : variant</para>
    ///   <a href="http://lexvo.org/ontology#variant">lvont:variant</a>
    /// </summary>
    let variant = _prefixId.prefix "variant"
