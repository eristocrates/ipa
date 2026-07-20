namespace http.www.lexinfo.net.ontology._2._0.lexinfo.hash

open DoxAletheia

module lexinfov2 =
    let _namespace_name = "http://www.lexinfo.net/ontology/2.0/lexinfo#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#AbbreviatedForm"></see>
    /// </summary>
    let AbbreviatedForm = _prefix "AbbreviatedForm"
    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#TermType"></see>
    /// </summary>
    let TermType = _prefix "TermType"
    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#AccusativePostPositiveArgument"></see>
    /// </summary>
    let AccusativePostPositiveArgument = _prefix "AccusativePostPositiveArgument"
    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#PostPositiveArgument"></see>
    /// </summary>
    let PostPositiveArgument = _prefix "PostPositiveArgument"
    /// <summary>
    /// Case used to indicate direct object.
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#accusativeCase"></see></summary>
    let accusativeCase = _prefix "accusativeCase"
    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#AdjectivalComplementFrame"></see>
    /// </summary>
    let AdjectivalComplementFrame = _prefix "AdjectivalComplementFrame"
    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#VerbFrame"></see>
    /// </summary>
    let VerbFrame = _prefix "VerbFrame"
    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#predicativeAdjective"></see>
    /// </summary>
    let predicativeAdjective = _prefix "predicativeAdjective"
    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#Adjective"></see>
    /// </summary>
    let Adjective = _prefix "Adjective"
    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#AdjectiveFrame"></see>
    /// </summary>
    let AdjectiveFrame = _prefix "AdjectiveFrame"
    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#AdjectivePOS"></see>
    /// </summary>
    let AdjectivePOS = _prefix "AdjectivePOS"
    /// <summary>
    /// A category assigned to a word based on its grammatical and semantic properties.
    /// Term used to describe how a particular word is used in a sentence.
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#partOfSpeech"></see></summary>
    let partOfSpeech = _prefix "partOfSpeech"

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#AdjectiveAccusativePostPositiveFrame"></see>
    /// </summary>
    let AdjectiveAccusativePostPositiveFrame =
        _prefix "AdjectiveAccusativePostPositiveFrame"

    /// <summary>
    /// An example of the usage of a frame.
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#example"></see></summary>
    let example = _prefix "example"
    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#AdjectivePostPositiveFrame"></see>
    /// </summary>
    let AdjectivePostPositiveFrame = _prefix "AdjectivePostPositiveFrame"
    /// <summary>
    /// Indicates an argument of an adjective indicated by post-positive modification. An example in english would be that "that is something interesting", where the adjective interesting post-postively modifies something
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#postPositiveArg"></see></summary>
    let postPositiveArg = _prefix "postPositiveArg"
    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#AdjectiveAttributiveFrame"></see>
    /// </summary>
    let AdjectiveAttributiveFrame = _prefix "AdjectiveAttributiveFrame"
    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#attributiveArg"></see>
    /// </summary>
    let attributiveArg = _prefix "attributiveArg"
    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#AdjectiveComparativeFrame"></see>
    /// </summary>
    let AdjectiveComparativeFrame = _prefix "AdjectiveComparativeFrame"
    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#comparativeAdjunct"></see>
    /// </summary>
    let comparativeAdjunct = _prefix "comparativeAdjunct"
    /// <summary>
    /// Indicates the subject of a copula construction. It is assumed that by using this the copula construction is not reversible e.g.,
    ///
    /// He is happy/*happy is him
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#copulativeSubject"></see></summary>
    let copulativeSubject = _prefix "copulativeSubject"
    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#AdjectiveDativePostPositiveFrame"></see>
    /// </summary>
    let AdjectiveDativePostPositiveFrame = _prefix "AdjectiveDativePostPositiveFrame"
    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#DativePostPositiveArgument"></see>
    /// </summary>
    let DativePostPositiveArgument = _prefix "DativePostPositiveArgument"

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#AdjectiveGenitivePostPositiveFrame"></see>
    /// </summary>
    let AdjectiveGenitivePostPositiveFrame =
        _prefix "AdjectiveGenitivePostPositiveFrame"

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#GenitivePostPositiveArgument"></see>
    /// </summary>
    let GenitivePostPositiveArgument = _prefix "GenitivePostPositiveArgument"
    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#AdjectiveImpersonalFrame"></see>
    /// </summary>
    let AdjectiveImpersonalFrame = _prefix "AdjectiveImpersonalFrame"
    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#object"></see>
    /// </summary>
    let object = _prefix "object"
    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#PartOfSpeech"></see>
    /// </summary>
    let PartOfSpeech = _prefix "PartOfSpeech"
    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#AdjectivePPFrame"></see>
    /// </summary>
    let AdjectivePPFrame = _prefix "AdjectivePPFrame"
    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#AdjectivePredicativeFrame"></see>
    /// </summary>
    let AdjectivePredicativeFrame = _prefix "AdjectivePredicativeFrame"
    /// <summary>
    /// Abstract frame for words that take a prepositional phrase as an argument
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#PrepositionalFrame"></see></summary>
    let PrepositionalFrame = _prefix "PrepositionalFrame"
    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#AdjectivePhrase"></see>
    /// </summary>
    let AdjectivePhrase = _prefix "AdjectivePhrase"
    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#head"></see>
    /// </summary>
    let head = _prefix "head"
    /// <summary>
    /// Used with copula constructions. This represents the subject/object in a copula construction. As such constructions are reversible this property is used instead of the usual verb subject/object. E,g.,
    ///
    /// Barack Obama is the president/The president is Barack Obama
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#copulativeArg"></see></summary>
    let copulativeArg = _prefix "copulativeArg"
    /// <summary>
    /// Note this frame should be used when both attributive and predicative use of the adjective is allowed
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#AdjectivePredicateFrame"></see></summary>
    let AdjectivePredicateFrame = _prefix "AdjectivePredicateFrame"
    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#AdjectiveScaleFrame"></see>
    /// </summary>
    let AdjectiveScaleFrame = _prefix "AdjectiveScaleFrame"
    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#adverbialComplement"></see>
    /// </summary>
    let adverbialComplement = _prefix "adverbialComplement"
    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#AdjectiveSuperlativeFrame"></see>
    /// </summary>
    let AdjectiveSuperlativeFrame = _prefix "AdjectiveSuperlativeFrame"
    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#superlativeAdjunct"></see>
    /// </summary>
    let superlativeAdjunct = _prefix "superlativeAdjunct"
    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#Adjunct"></see>
    /// </summary>
    let Adjunct = _prefix "Adjunct"
    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#Adposition"></see>
    /// </summary>
    let Adposition = _prefix "Adposition"
    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#AdpositionPOS"></see>
    /// </summary>
    let AdpositionPOS = _prefix "AdpositionPOS"
    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#AdpositionalObject"></see>
    /// </summary>
    let AdpositionalObject = _prefix "AdpositionalObject"
    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#Object"></see>
    /// </summary>
    let Object = _prefix "Object"
    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#Adverb"></see>
    /// </summary>
    let Adverb = _prefix "Adverb"
    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#AdverbPOS"></see>
    /// </summary>
    let AdverbPOS = _prefix "AdverbPOS"
    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#AdverbialComplementFrame"></see>
    /// </summary>
    let AdverbialComplementFrame = _prefix "AdverbialComplementFrame"
    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#predicativeAdverb"></see>
    /// </summary>
    let predicativeAdverb = _prefix "predicativeAdverb"
    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#Affix"></see>
    /// </summary>
    let Affix = _prefix "Affix"
    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#affix"></see>
    /// </summary>
    let affix = _prefix "affix"
    /// <summary>
    /// Any logically significant portion of a larger term or lexeme.
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#termElement"></see></summary>
    let termElement = _prefix "termElement"
    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#Animacy"></see>
    /// </summary>
    let Animacy = _prefix "Animacy"
    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#MorphosyntacticProperty"></see>
    /// </summary>
    let MorphosyntacticProperty = _prefix "MorphosyntacticProperty"
    /// <summary>
    /// Indicates either the subject or object of the main clause may be the omitted argument of the subclause
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#ArbitraryControl"></see></summary>
    let ArbitraryControl = _prefix "ArbitraryControl"
    /// <summary>
    /// Control indicates how a an argument from a main clause will be utilized in a subclause. This class includes both control structures and raising structures
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#Control"></see></summary>
    let Control = _prefix "Control"
    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#Article"></see>
    /// </summary>
    let Article = _prefix "Article"
    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#Determiner"></see>
    /// </summary>
    let Determiner = _prefix "Determiner"
    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#ArticlePOS"></see>
    /// </summary>
    let ArticlePOS = _prefix "ArticlePOS"
    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#DeterminerPOS"></see>
    /// </summary>
    let DeterminerPOS = _prefix "DeterminerPOS"
    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#Aspect"></see>
    /// </summary>
    let Aspect = _prefix "Aspect"
    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#AttributiveArgument"></see>
    /// </summary>
    let AttributiveArgument = _prefix "AttributiveArgument"
    /// <summary>
    /// A lexical unit in a CJKV language that is represented by at least two CJKV characters.
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#CJK_compound"></see></summary>
    let CJK_compound = _prefix "CJK_compound"
    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#Case"></see>
    /// </summary>
    let Case = _prefix "Case"
    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#ClausalArgument"></see>
    /// </summary>
    let ClausalArgument = _prefix "ClausalArgument"
    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#Cliticness"></see>
    /// </summary>
    let Cliticness = _prefix "Cliticness"
    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#CommonNoun"></see>
    /// </summary>
    let CommonNoun = _prefix "CommonNoun"
    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#Noun"></see>
    /// </summary>
    let Noun = _prefix "Noun"
    /// <summary>
    /// Noun that signifies a non-specific member of a group.
    /// A noun or adjective denoting a class of objects.
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#commonNoun"></see></summary>
    let commonNoun = _prefix "commonNoun"
    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#ComparativeAdjunct"></see>
    /// </summary>
    let ComparativeAdjunct = _prefix "ComparativeAdjunct"
    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#Complement"></see>
    /// </summary>
    let Complement = _prefix "Complement"
    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#Conjunction"></see>
    /// </summary>
    let Conjunction = _prefix "Conjunction"
    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#ConjunctionPOS"></see>
    /// </summary>
    let ConjunctionPOS = _prefix "ConjunctionPOS"
    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#Dating"></see>
    /// </summary>
    let Dating = _prefix "Dating"
    /// <summary>
    /// Case that expresses an indirect object relationship or a range of meaning similar to that covered by 'to' or 'for' in English; but there is a great deal of variation between languages in the way this case is used.
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#dativeCase"></see></summary>
    let dativeCase = _prefix "dativeCase"
    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#DativeTransitiveFrame"></see>
    /// </summary>
    let DativeTransitiveFrame = _prefix "DativeTransitiveFrame"
    /// <summary>
    /// relation between a phrase and a verb, in which the relation is central to the verb
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#directObject"></see></summary>
    let directObject = _prefix "directObject"
    /// <summary>
    /// An indirect object is a grammatical relation that is one means of expressing the semantic role of goal and other similar roles. It is proposed for languages in which the role is distinct from the direct object and the oblique object on the basis of multiple independent syntactic or morphological criteria, such as the following: - Having a particular case marking, commonly dative - Governing an agreement affix on the verb, such as person or number - Being distinct from oblique relations in that it may be relativized
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#indirectObject"></see></summary>
    let indirectObject = _prefix "indirectObject"
    /// <summary>
    /// relation between a phrase and a verb, that represents the person or thing that performs the action or about which something is stated
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#subject"></see></summary>
    let subject = _prefix "subject"
    /// <summary>
    /// A clause beginning with the declarative conjunction ("that" in English)
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#DeclarativeClause"></see></summary>
    let DeclarativeClause = _prefix "DeclarativeClause"
    /// <summary>
    /// Declarative frames take a clause as an argument, this argument is marker with the declarative conjunction ("that" in English)
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#DeclarativeFrame"></see></summary>
    let DeclarativeFrame = _prefix "DeclarativeFrame"
    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#declarativeClause"></see>
    /// </summary>
    let declarativeClause = _prefix "declarativeClause"
    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#Definiteness"></see>
    /// </summary>
    let Definiteness = _prefix "Definiteness"
    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#Degree"></see>
    /// </summary>
    let Degree = _prefix "Degree"
    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#DirectObject"></see>
    /// </summary>
    let DirectObject = _prefix "DirectObject"
    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#DitransitiveDoubleAccusativeFrame"></see>
    /// </summary>
    let DitransitiveDoubleAccusativeFrame = _prefix "DitransitiveDoubleAccusativeFrame"
    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#DitransitiveFrame"></see>
    /// </summary>
    let DitransitiveFrame = _prefix "DitransitiveFrame"
    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#DitransitiveFrame_For"></see>
    /// </summary>
    let DitransitiveFrame_For = _prefix "DitransitiveFrame_For"
    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#languageSpecific"></see>
    /// </summary>
    let languageSpecific = _prefix "languageSpecific"
    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#DitransitiveFrame_To"></see>
    /// </summary>
    let DitransitiveFrame_To = _prefix "DitransitiveFrame_To"
    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#Finiteness"></see>
    /// </summary>
    let Finiteness = _prefix "Finiteness"
    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#Frequency"></see>
    /// </summary>
    let Frequency = _prefix "Frequency"
    /// <summary>
    /// A word that is a fusion of a preposition and some other word... examples include the German words "zum" and "daran"
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#FusedPreposition"></see></summary>
    let FusedPreposition = _prefix "FusedPreposition"
    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#FusedPrepositionPOS"></see>
    /// </summary>
    let FusedPrepositionPOS = _prefix "FusedPrepositionPOS"
    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#Gender"></see>
    /// </summary>
    let Gender = _prefix "Gender"
    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#GenitiveDitransitiveFrame"></see>
    /// </summary>
    let GenitiveDitransitiveFrame = _prefix "GenitiveDitransitiveFrame"
    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#genitiveObject"></see>
    /// </summary>
    let genitiveObject = _prefix "genitiveObject"
    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#GenitiveObject"></see>
    /// </summary>
    let GenitiveObject = _prefix "GenitiveObject"
    /// <summary>
    /// Case which expresses a possessive relationship (e.g. the boy's book) or some other similarly close connection (e.g. a summer's day).
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#genitiveCase"></see></summary>
    let genitiveCase = _prefix "genitiveCase"
    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#GenitiveTransitiveFrame"></see>
    /// </summary>
    let GenitiveTransitiveFrame = _prefix "GenitiveTransitiveFrame"
    /// <summary>
    /// A clause, whose head is a non-finite verb form, which is used in place of an argument. In English these use the "-ing" suffix
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#Gerund"></see></summary>
    let Gerund = _prefix "Gerund"
    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#GerundACFrame"></see>
    /// </summary>
    let GerundACFrame = _prefix "GerundACFrame"
    /// <summary>
    /// Indicates one of the arguments is a gerund clause
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#GerundFrame"></see></summary>
    let GerundFrame = _prefix "GerundFrame"
    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#GerundOCFrame"></see>
    /// </summary>
    let GerundOCFrame = _prefix "GerundOCFrame"
    /// <summary>
    /// Indicates the object of the main clause is also the (omitted) object of the subclause
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#ObjectControl"></see></summary>
    let ObjectControl = _prefix "ObjectControl"
    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#GerundSCFrame"></see>
    /// </summary>
    let GerundSCFrame = _prefix "GerundSCFrame"
    /// <summary>
    /// Indicates the subject of the main clause is the (omitted) subject of the subclause
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#SubjectControl"></see></summary>
    let SubjectControl = _prefix "SubjectControl"
    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#ImpersonalFrame"></see>
    /// </summary>
    let ImpersonalFrame = _prefix "ImpersonalFrame"
    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#ImpersonalIntransitiveFrame"></see>
    /// </summary>
    let ImpersonalIntransitiveFrame = _prefix "ImpersonalIntransitiveFrame"
    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#ImpersonalIntransitivePPFrame"></see>
    /// </summary>
    let ImpersonalIntransitivePPFrame = _prefix "ImpersonalIntransitivePPFrame"
    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#ImpersonalTransitiveFrame"></see>
    /// </summary>
    let ImpersonalTransitiveFrame = _prefix "ImpersonalTransitiveFrame"
    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#IndirectObject"></see>
    /// </summary>
    let IndirectObject = _prefix "IndirectObject"
    /// <summary>
    /// A clause whose main verb is infinitive
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#InfinitiveClause"></see></summary>
    let InfinitiveClause = _prefix "InfinitiveClause"
    /// <summary>
    /// Infinitive frames take an infinitive clause as an argument
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#InfinitiveFrame"></see></summary>
    let InfinitiveFrame = _prefix "InfinitiveFrame"
    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#infinitiveClause"></see>
    /// </summary>
    let infinitiveClause = _prefix "infinitiveClause"
    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#Infix"></see>
    /// </summary>
    let Infix = _prefix "Infix"
    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#Interjection"></see>
    /// </summary>
    let Interjection = _prefix "Interjection"
    /// <summary>
    /// Word or sound that expresses an emotion.
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#interjection"></see></summary>
    let interjection = _prefix "interjection"
    /// <summary>
    /// A subclause that begins interrogative construction ("wh"-word in English)
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#InterrogativeClause"></see></summary>
    let InterrogativeClause = _prefix "InterrogativeClause"
    /// <summary>
    /// Indicates the frame has a subframe indicated with the appropriate interrogative (e.g., "who", "where", "how")
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#InterrogativeFrame"></see></summary>
    let InterrogativeFrame = _prefix "InterrogativeFrame"
    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#interrogativeClause"></see>
    /// </summary>
    let interrogativeClause = _prefix "interrogativeClause"
    /// <summary>
    /// Indicates the frame has an argument that is a clause with both an interrogative and the clause is in the infinitive form
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#InterrogativeInfinitiveFrame"></see></summary>
    let InterrogativeInfinitiveFrame = _prefix "InterrogativeInfinitiveFrame"
    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#interrogativeInfinitiveClause"></see>
    /// </summary>
    let interrogativeInfinitiveClause = _prefix "interrogativeInfinitiveClause"

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#IntransitiveAdjectivalComplementFrame"></see>
    /// </summary>
    let IntransitiveAdjectivalComplementFrame =
        _prefix "IntransitiveAdjectivalComplementFrame"

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#IntransitiveFrame"></see>
    /// </summary>
    let IntransitiveFrame = _prefix "IntransitiveFrame"

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#IntransitiveAdverbialComplementFrame"></see>
    /// </summary>
    let IntransitiveAdverbialComplementFrame =
        _prefix "IntransitiveAdverbialComplementFrame"

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#IntransitiveDeclarativeFrame"></see>
    /// </summary>
    let IntransitiveDeclarativeFrame = _prefix "IntransitiveDeclarativeFrame"
    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#IntransitiveInfinitiveACFrame"></see>
    /// </summary>
    let IntransitiveInfinitiveACFrame = _prefix "IntransitiveInfinitiveACFrame"
    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#IntransitiveInfinitiveRSFrame"></see>
    /// </summary>
    let IntransitiveInfinitiveRSFrame = _prefix "IntransitiveInfinitiveRSFrame"
    /// <summary>
    /// Indicates the syntactic subject of the main clause is in fact the subject of the subclause. The main clause should then be interpreted as being impersonal.
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#RaisingSubject"></see></summary>
    let RaisingSubject = _prefix "RaisingSubject"
    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#IntransitiveInfinitiveSCFrame"></see>
    /// </summary>
    let IntransitiveInfinitiveSCFrame = _prefix "IntransitiveInfinitiveSCFrame"
    /// <summary>
    /// he ASKED [what he should do]
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#IntransitiveInterrogativeFrame"></see></summary>
    let IntransitiveInterrogativeFrame = _prefix "IntransitiveInterrogativeFrame"

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#IntransitiveInterrogativeInfinitiveFrame"></see>
    /// </summary>
    let IntransitiveInterrogativeInfinitiveFrame =
        _prefix "IntransitiveInterrogativeInfinitiveFrame"

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#IntransitiveNominalComplementFrame"></see>
    /// </summary>
    let IntransitiveNominalComplementFrame =
        _prefix "IntransitiveNominalComplementFrame"

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#predicativeNominative"></see>
    /// </summary>
    let predicativeNominative = _prefix "predicativeNominative"
    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#IntransitivePPDeclarativeFrame"></see>
    /// </summary>
    let IntransitivePPDeclarativeFrame = _prefix "IntransitivePPDeclarativeFrame"
    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#IntransitivePPFrame"></see>
    /// </summary>
    let IntransitivePPFrame = _prefix "IntransitivePPFrame"
    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#PPFrame"></see>
    /// </summary>
    let PPFrame = _prefix "PPFrame"
    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#IntransitiveSententialFrame"></see>
    /// </summary>
    let IntransitiveSententialFrame = _prefix "IntransitiveSententialFrame"
    /// <summary>
    /// Sentential frames take a clause as argument, no conjunction is used and the syntax of the clause is the same as a main clause
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#SententialFrame"></see></summary>
    let SententialFrame = _prefix "SententialFrame"
    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#ModificationType"></see>
    /// </summary>
    let ModificationType = _prefix "ModificationType"
    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#Mood"></see>
    /// </summary>
    let Mood = _prefix "Mood"
    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#Negative"></see>
    /// </summary>
    let Negative = _prefix "Negative"
    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#NominalComplementFrame"></see>
    /// </summary>
    let NominalComplementFrame = _prefix "NominalComplementFrame"
    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#NormativeAuthorization"></see>
    /// </summary>
    let NormativeAuthorization = _prefix "NormativeAuthorization"
    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#NounFrame"></see>
    /// </summary>
    let NounFrame = _prefix "NounFrame"
    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#NounPOS"></see>
    /// </summary>
    let NounPOS = _prefix "NounPOS"
    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#NounPPFrame"></see>
    /// </summary>
    let NounPPFrame = _prefix "NounPPFrame"
    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#NounPredicateFrame"></see>
    /// </summary>
    let NounPredicateFrame = _prefix "NounPredicateFrame"
    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#NounPhrase"></see>
    /// </summary>
    let NounPhrase = _prefix "NounPhrase"
    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#NounPossessiveFrame"></see>
    /// </summary>
    let NounPossessiveFrame = _prefix "NounPossessiveFrame"
    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#PossessiveAdjunct"></see>
    /// </summary>
    let PossessiveAdjunct = _prefix "PossessiveAdjunct"
    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#possessiveAdjunct"></see>
    /// </summary>
    let possessiveAdjunct = _prefix "possessiveAdjunct"
    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#Number"></see>
    /// </summary>
    let Number = _prefix "Number"
    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#Numeral"></see>
    /// </summary>
    let Numeral = _prefix "Numeral"
    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#NumeralPOS"></see>
    /// </summary>
    let NumeralPOS = _prefix "NumeralPOS"
    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#ObjectComplement"></see>
    /// </summary>
    let ObjectComplement = _prefix "ObjectComplement"
    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#Particle"></see>
    /// </summary>
    let Particle = _prefix "Particle"
    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#ParticlePOS"></see>
    /// </summary>
    let ParticlePOS = _prefix "ParticlePOS"
    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#Person"></see>
    /// </summary>
    let Person = _prefix "Person"
    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#Postposition"></see>
    /// </summary>
    let Postposition = _prefix "Postposition"
    /// <summary>
    /// Adposition that appears at the end of the noun phrase.
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#postposition"></see></summary>
    let postposition = _prefix "postposition"
    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#PredicativeAdjective"></see>
    /// </summary>
    let PredicativeAdjective = _prefix "PredicativeAdjective"
    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#PredicativeAdverb"></see>
    /// </summary>
    let PredicativeAdverb = _prefix "PredicativeAdverb"
    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#PredicativeNominative"></see>
    /// </summary>
    let PredicativeNominative = _prefix "PredicativeNominative"
    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#Prefix"></see>
    /// </summary>
    let Prefix = _prefix "Prefix"
    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#prefix"></see>
    /// </summary>
    let prefix = _prefix "prefix"
    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#Preposition"></see>
    /// </summary>
    let Preposition = _prefix "Preposition"
    /// <summary>
    /// Adposition placed at the beginning of a noun phrase.
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#preposition"></see></summary>
    let preposition = _prefix "preposition"
    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#PrepositionFrame"></see>
    /// </summary>
    let PrepositionFrame = _prefix "PrepositionFrame"
    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#PrepositionPhrase"></see>
    /// </summary>
    let PrepositionPhrase = _prefix "PrepositionPhrase"
    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#PrepositionalAdjunct"></see>
    /// </summary>
    let PrepositionalAdjunct = _prefix "PrepositionalAdjunct"
    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#prepositionalAdjunct"></see>
    /// </summary>
    let prepositionalAdjunct = _prefix "prepositionalAdjunct"
    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#PrepositionalInterrogativeFrame"></see>
    /// </summary>
    let PrepositionalInterrogativeFrame = _prefix "PrepositionalInterrogativeFrame"
    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#prepositionalInterrogativeClause"></see>
    /// </summary>
    let prepositionalInterrogativeClause = _prefix "prepositionalInterrogativeClause"
    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#PrepositionalObject"></see>
    /// </summary>
    let PrepositionalObject = _prefix "PrepositionalObject"
    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#PrepositionalPhraseFrame"></see>
    /// </summary>
    let PrepositionalPhraseFrame = _prefix "PrepositionalPhraseFrame"
    /// <summary>
    /// A noun phrase that follows a copula or similar verb, as for example an idiot in the sentence He is an idiot. - A clause that serves as the subject or direct object of a verb or the direct object of a preposition, as for example that he would be early in the sentence I hoped that he would be early
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#complement"></see></summary>
    let complement = _prefix "complement"
    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#Pronoun"></see>
    /// </summary>
    let Pronoun = _prefix "Pronoun"
    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#PronounPOS"></see>
    /// </summary>
    let PronounPOS = _prefix "PronounPOS"
    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#ProperNoun"></see>
    /// </summary>
    let ProperNoun = _prefix "ProperNoun"
    /// <summary>
    /// Noun that is the name of a specific individual, place, or object.
    /// A noun or adjective denoting a single object.
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#properNoun"></see></summary>
    let properNoun = _prefix "properNoun"
    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#RaisableSubject"></see>
    /// </summary>
    let RaisableSubject = _prefix "RaisableSubject"
    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#Subject"></see>
    /// </summary>
    let Subject = _prefix "Subject"
    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#ReciprocalFrame"></see>
    /// </summary>
    let ReciprocalFrame = _prefix "ReciprocalFrame"
    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#ReferentType"></see>
    /// </summary>
    let ReferentType = _prefix "ReferentType"
    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#ReflexiveDativeTransitiveFrame"></see>
    /// </summary>
    let ReflexiveDativeTransitiveFrame = _prefix "ReflexiveDativeTransitiveFrame"
    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#ReflexiveFrame"></see>
    /// </summary>
    let ReflexiveFrame = _prefix "ReflexiveFrame"
    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#ReflexiveDitransitiveFrame"></see>
    /// </summary>
    let ReflexiveDitransitiveFrame = _prefix "ReflexiveDitransitiveFrame"
    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#ReflexiveObject"></see>
    /// </summary>
    let ReflexiveObject = _prefix "ReflexiveObject"
    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#ReflexiveReciprocalFrame"></see>
    /// </summary>
    let ReflexiveReciprocalFrame = _prefix "ReflexiveReciprocalFrame"
    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#ReflexiveTransitiveFrame"></see>
    /// </summary>
    let ReflexiveTransitiveFrame = _prefix "ReflexiveTransitiveFrame"
    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#TransitiveFrame"></see>
    /// </summary>
    let TransitiveFrame = _prefix "TransitiveFrame"
    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#ReflexiveTransitivePPFrame"></see>
    /// </summary>
    let ReflexiveTransitivePPFrame = _prefix "ReflexiveTransitivePPFrame"
    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#TransitivePPFrame"></see>
    /// </summary>
    let TransitivePPFrame = _prefix "TransitivePPFrame"
    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#Register"></see>
    /// </summary>
    let Register = _prefix "Register"
    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#sententialClause"></see>
    /// </summary>
    let sententialClause = _prefix "sententialClause"
    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#SubjectlessFrame"></see>
    /// </summary>
    let SubjectlessFrame = _prefix "SubjectlessFrame"
    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#SubjectlessIntransitiveFrame"></see>
    /// </summary>
    let SubjectlessIntransitiveFrame = _prefix "SubjectlessIntransitiveFrame"
    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#SubjectlessIntransitivePPFrame"></see>
    /// </summary>
    let SubjectlessIntransitivePPFrame = _prefix "SubjectlessIntransitivePPFrame"
    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#SubjectlessTransitiveFrame"></see>
    /// </summary>
    let SubjectlessTransitiveFrame = _prefix "SubjectlessTransitiveFrame"
    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#SubjectlessTransitivePPFrame"></see>
    /// </summary>
    let SubjectlessTransitivePPFrame = _prefix "SubjectlessTransitivePPFrame"
    /// <summary>
    /// A subclause that is in the subjunctive mood
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#SubjunctiveClause"></see></summary>
    let SubjunctiveClause = _prefix "SubjunctiveClause"
    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#Suffix"></see>
    /// </summary>
    let Suffix = _prefix "Suffix"
    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#suffix"></see>
    /// </summary>
    let suffix = _prefix "suffix"
    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#SuperlativeAdjunct"></see>
    /// </summary>
    let SuperlativeAdjunct = _prefix "SuperlativeAdjunct"
    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#Symbol"></see>
    /// </summary>
    let Symbol = _prefix "Symbol"
    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#SymbolPOS"></see>
    /// </summary>
    let SymbolPOS = _prefix "SymbolPOS"
    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#TemporalQualifier"></see>
    /// </summary>
    let TemporalQualifier = _prefix "TemporalQualifier"
    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#Tense"></see>
    /// </summary>
    let Tense = _prefix "Tense"
    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#TermElement"></see>
    /// </summary>
    let TermElement = _prefix "TermElement"

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#TransitiveAdjectivalComplementFrame"></see>
    /// </summary>
    let TransitiveAdjectivalComplementFrame =
        _prefix "TransitiveAdjectivalComplementFrame"

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#TransitiveAdverbialComplementFrame"></see>
    /// </summary>
    let TransitiveAdverbialComplementFrame =
        _prefix "TransitiveAdverbialComplementFrame"

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#TransitiveDeclarativeFrame"></see>
    /// </summary>
    let TransitiveDeclarativeFrame = _prefix "TransitiveDeclarativeFrame"
    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#TransitiveInfinitiveACFrame"></see>
    /// </summary>
    let TransitiveInfinitiveACFrame = _prefix "TransitiveInfinitiveACFrame"
    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#TransitiveInfinitiveOCFrame"></see>
    /// </summary>
    let TransitiveInfinitiveOCFrame = _prefix "TransitiveInfinitiveOCFrame"
    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#TransitiveInfinitiveSCFrame"></see>
    /// </summary>
    let TransitiveInfinitiveSCFrame = _prefix "TransitiveInfinitiveSCFrame"
    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#TransitiveInterrogativeFrame"></see>
    /// </summary>
    let TransitiveInterrogativeFrame = _prefix "TransitiveInterrogativeFrame"

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#TransitiveInterrogativeInfinitiveFrame"></see>
    /// </summary>
    let TransitiveInterrogativeInfinitiveFrame =
        _prefix "TransitiveInterrogativeInfinitiveFrame"

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#TransitiveNominalComplementFrame"></see>
    /// </summary>
    let TransitiveNominalComplementFrame = _prefix "TransitiveNominalComplementFrame"
    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#TransitiveSententialFrame"></see>
    /// </summary>
    let TransitiveSententialFrame = _prefix "TransitiveSententialFrame"
    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#Verb"></see>
    /// </summary>
    let Verb = _prefix "Verb"
    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#VerbPOS"></see>
    /// </summary>
    let VerbPOS = _prefix "VerbPOS"
    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#VerbFormMood"></see>
    /// </summary>
    let VerbFormMood = _prefix "VerbFormMood"
    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#VerbPhrase"></see>
    /// </summary>
    let VerbPhrase = _prefix "VerbPhrase"
    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#Voice"></see>
    /// </summary>
    let Voice = _prefix "Voice"
    /// <summary>
    /// A term or lexeme resulting from the omission of any part of the full term or lexeme while designating the same concept.
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#abbreviatedForm"></see></summary>
    let abbreviatedForm = _prefix "abbreviatedForm"
    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#abbreviation"></see>
    /// </summary>
    let abbreviation = _prefix "abbreviation"
    /// <summary>
    /// A linking element used to identify a relation between an abbreviation and its full or expanded form.
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#abbreviationFor"></see></summary>
    let abbreviationFor = _prefix "abbreviationFor"
    /// <summary>
    /// The full form that corresponds to a contracted form.
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#contractionFor"></see></summary>
    let contractionFor = _prefix "contractionFor"
    /// <summary>
    /// Case that expresses the lack or absence of the referent of the noun it marks.
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#abessiveCase"></see></summary>
    let abessiveCase = _prefix "abessiveCase"
    /// <summary>
    /// Case used to typically indicate locative or instrumental function.
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#ablativeCase"></see></summary>
    let ablativeCase = _prefix "ablativeCase"
    /// <summary>
    /// Case for nouns in ergative-absolute languages that would generally be the subjects of intransitive verbs or the objects of transitive verbs in the translational equivalents of nominative-accusative languages such as English.
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#absolutiveCase"></see></summary>
    let absolutiveCase = _prefix "absolutiveCase"
    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#accusativeCaseForm"></see>
    /// </summary>
    let accusativeCaseForm = _prefix "accusativeCaseForm"
    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#formCaseVariant"></see>
    /// </summary>
    let formCaseVariant = _prefix "formCaseVariant"
    /// <summary>
    /// An abbreviation made up of the initial letters of the components of the full form of the designation or from syllables of the full form and pronounced syllabically.
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#acronym"></see></summary>
    let acronym = _prefix "acronym"
    /// <summary>
    /// A linking element used to identify a relation between an acronym and its full or expanded form.
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#acronymFor"></see></summary>
    let acronymFor = _prefix "acronymFor"
    /// <summary>
    /// Value that expresses the situation where the grammatical subject is also the semantic actor of the verb.
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#activeVoice"></see></summary>
    let activeVoice = _prefix "activeVoice"
    /// <summary>
    /// Case which expresses the meaning of presence 'at' or 'near' a place.
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#adessiveCase"></see></summary>
    let adessiveCase = _prefix "adessiveCase"
    /// <summary>
    /// Case expressing &amp;quot;to&amp;quot; in Basque studies.
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#aditiveCase"></see></summary>
    let aditiveCase = _prefix "aditiveCase"
    /// <summary>
    /// Part of speech related to attributes of noun.
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#adjective"></see></summary>
    let adjective = _prefix "adjective"
    /// <summary>
    /// Deverbal adjective in Japanese ending with the '-i' suffix in dictionary form
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#adjective-i"></see></summary>
    let ``adjective-i`` = _prefix "adjective-i"
    /// <summary>
    /// Denominal adjectives in Japanese formed from a noun plus the particle 'na'
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#adjective-na"></see></summary>
    let ``adjective-na`` = _prefix "adjective-na"
    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#adjunct"></see>
    /// </summary>
    let adjunct = _prefix "adjunct"
    /// <summary>
    /// A term rated according to the scale of a term acceptability rating as a synonym for a preferred term.
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#admittedTerm"></see></summary>
    let admittedTerm = _prefix "admittedTerm"
    /// <summary>
    /// Part of speech that occurs before/inside/after a complement composed of a noun phrase, noun, pronoun or clause that functions as a noun phrase and form a single structure with the complement to express its grammatical and semantic relation to another unit.
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#adposition"></see></summary>
    let adposition = _prefix "adposition"
    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#adpositionalObject"></see>
    /// </summary>
    let adpositionalObject = _prefix "adpositionalObject"
    /// <summary>
    /// Part of speech to refer to an heterogeneous group of words whose most frequent function is to specify the mode of action of the verb.
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#adverb"></see></summary>
    let adverb = _prefix "adverb"
    /// <summary>
    /// ()
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#adverbialPronoun"></see></summary>
    let adverbialPronoun = _prefix "adverbialPronoun"
    /// <summary>
    /// Particle used to express affirmation.
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#affirmativeParticle"></see></summary>
    let affirmativeParticle = _prefix "affirmativeParticle"
    /// <summary>
    /// Personnal pronoun that is affixed, i.e. added as an affix to another word.
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#affixedPersonalPronoun"></see></summary>
    let affixedPersonalPronoun = _prefix "affixedPersonalPronoun"
    /// <summary>
    /// Case which expresses the meaning of motion 'to' or 'towards' the referent it marks.
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#allativeCase"></see></summary>
    let allativeCase = _prefix "allativeCase"
    /// <summary>
    /// Pronoun that refers to something characterized by allusions.
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#allusivePronoun"></see></summary>
    let allusivePronoun = _prefix "allusivePronoun"
    /// <summary>
    /// The characteristic of a word indicating that in a given discourse community, its referent is considered to be alive or to possess a quality of volition or consciousness.
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#animacy"></see></summary>
    let animacy = _prefix "animacy"
    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#morphosyntacticProperty"></see>
    /// </summary>
    let morphosyntacticProperty = _prefix "morphosyntacticProperty"
    /// <summary>
    /// Perceived as alive.
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#animate"></see></summary>
    let animate = _prefix "animate"
    /// <summary>
    /// A term or lexeme whose concept or sense constitutes the opposite of the concept represented by a second term or lexeme.
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#antonym"></see></summary>
    let antonym = _prefix "antonym"
    /// <summary>
    /// A designation that represents an individual concept.
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#appellation"></see></summary>
    let appellation = _prefix "appellation"
    /// <summary>
    /// Property used to qualify something similar but not exactly the same
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#approximate"></see></summary>
    let approximate = _prefix "approximate"
    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#approximateSynonym"></see>
    /// </summary>
    let approximateSynonym = _prefix "approximateSynonym"
    /// <summary>
    /// A term or lexeme no longer in ordinary use, though retained for special purposes.
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#archaicForm"></see></summary>
    let archaicForm = _prefix "archaicForm"
    /// <summary>
    /// ...
    /// Term used in the grammatical classification of words referring to a subclass of determiners which displays a primary role in differentiating the uses of nouns.
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#article"></see></summary>
    let article = _prefix "article"
    /// <summary>
    /// Category associated to verbs and referring to the way the grammar marks the duration or type of temporal activity.
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#aspect"></see></summary>
    let aspect = _prefix "aspect"
    /// <summary>
    /// A relation between two concepts having a non-hierarchical thematic connection by virtue of experience.
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#associativeRelation"></see></summary>
    let associativeRelation = _prefix "associativeRelation"
    /// <summary>
    /// A term connected to another term by a coordinate or associative relation.
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#relatedTerm"></see></summary>
    let relatedTerm = _prefix "relatedTerm"
    /// <summary>
    /// The root form of a word or term that is used as the formal dictionary entry for the term.
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#baseElement"></see></summary>
    let baseElement = _prefix "baseElement"
    /// <summary>
    /// Register of terms used in applications-oriented as opposed to theoretical or academic levels of language.
    /// The register of terms used in applications-oriented as opposed to theoretical or academic levels of language.
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#benchLevelRegister"></see></summary>
    let benchLevelRegister = _prefix "benchLevelRegister"
    /// <summary>
    /// Case that expresses that the referent of the noun it marks receives the benefit of the situation expressed by the clause.
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#benefactiveCase"></see></summary>
    let benefactiveCase = _prefix "benefactiveCase"
    /// <summary>
    /// Linked to a particular element.
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#bound"></see></summary>
    let bound = _prefix "bound"
    /// <summary>
    /// Sign used to mark an item in a list.
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#bullet"></see></summary>
    let bullet = _prefix "bullet"
    /// <summary>
    /// A word denoting a number.
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#cardinalNumeral"></see></summary>
    let cardinalNumeral = _prefix "cardinalNumeral"
    /// <summary>
    /// In a given sentence, the way in which the form of a word changes in order to express a relationship with one or several words of the sentence. The morphological modification may apply to nouns, pronouns noun phrase constituents, such as adjectives or numerals.
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#case"></see></summary>
    let case = _prefix "case"
    /// <summary>
    /// A concept that is related to another concept by virtue of the fact that it plays a causative role with respect to that concept.
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#causallyRelatedConcept"></see></summary>
    let causallyRelatedConcept = _prefix "causallyRelatedConcept"
    /// <summary>
    /// Case which expresses that the referent of the noun it marks is the cause of the situation expressed by the clause.
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#causativeCase"></see></summary>
    let causativeCase = _prefix "causativeCase"
    /// <summary>
    /// Aspect that expresses the cessation of an event or state.
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#cessative"></see></summary>
    let cessative = _prefix "cessative"
    /// <summary>
    /// Adposition which consists of two parts which are positioned ahead and after the adpositional foci.
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#circumposition"></see></summary>
    let circumposition = _prefix "circumposition"
    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#clausalArg"></see>
    /// </summary>
    let clausalArg = _prefix "clausalArg"
    /// <summary>
    /// An abbreviation formed by truncating a part of a simple term.
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#clippedTerm"></see></summary>
    let clippedTerm = _prefix "clippedTerm"
    /// <summary>
    /// A linking element used to identify a relation between a clipped term and its full or expanded form.
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#clippedTermFor"></see></summary>
    let clippedTermFor = _prefix "clippedTermFor"
    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#derivedForm"></see>
    /// </summary>
    let derivedForm = _prefix "derivedForm"
    /// <summary>
    /// Categorization of the different types of clitics
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#cliticness"></see></summary>
    let cliticness = _prefix "cliticness"
    /// <summary>
    /// End of a parenthesis pair.
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#closeParenthesis"></see></summary>
    let closeParenthesis = _prefix "closeParenthesis"
    /// <summary>
    /// A collective number is a number referring to 'a set of things'. Languages that have this feature can use it to get a phrase like 'flock of sheeps' by using 'sheep' in collective number.
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#collective"></see></summary>
    let collective = _prefix "collective"
    /// <summary>
    /// A pronoun that refers to all elements of a set.
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#collectivePronoun"></see></summary>
    let collectivePronoun = _prefix "collectivePronoun"
    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#collocation"></see>
    /// </summary>
    let collocation = _prefix "collocation"
    /// <summary>
    /// Sign with two vertical points that is used in writing and printing to introduce an explanation, example or quotation.
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#colon"></see></summary>
    let colon = _prefix "colon"
    /// <summary>
    /// Case which expresses a meaning similar to 'along with' or 'accompagnied by'.
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#comitativeCase"></see></summary>
    let comitativeCase = _prefix "comitativeCase"
    /// <summary>
    /// Mark (,) used in writing to show a short pause or to separate items in a list.
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#comma"></see></summary>
    let comma = _prefix "comma"
    /// <summary>
    /// Indistinguished gender for epicenes.
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#commonGender"></see></summary>
    let commonGender = _prefix "commonGender"
    /// <summary>
    /// A synonym for an international scientific term that is used in general discourse in a given language.
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#commonName"></see></summary>
    let commonName = _prefix "commonName"
    /// <summary>
    /// Said of a term that appears frequently.
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#commonlyUsed"></see></summary>
    let commonlyUsed = _prefix "commonlyUsed"
    /// <summary>
    /// Comparative is the comparison where only two entites are involved.
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#comparative"></see></summary>
    let comparative = _prefix "comparative"
    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#predicativeAdjunct"></see>
    /// </summary>
    let predicativeAdjunct = _prefix "predicativeAdjunct"
    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#comparativeDegreeForm"></see>
    /// </summary>
    let comparativeDegreeForm = _prefix "comparativeDegreeForm"
    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#formDegreeVariant"></see>
    /// </summary>
    let formDegreeVariant = _prefix "formDegreeVariant"
    /// <summary>
    /// Particle used to compare.
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#comparativeParticle"></see></summary>
    let comparativeParticle = _prefix "comparativeParticle"
    /// <summary>
    /// A lexical unit that combines two or sometimes more different words, frequently such that the sense of the new lexical unit is not clearly derivable from the combination of its parts.
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#compound"></see></summary>
    let compound = _prefix "compound"
    /// <summary>
    /// Preposition that is a aggregation of words
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#compoundPreposition"></see></summary>
    let compoundPreposition = _prefix "compoundPreposition"
    /// <summary>
    /// A conditional relation is a logical relation in which the illocutionary act employing one of a pair of propositions is expressed or implied to be true or in force if the other proposition is true.
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#conditional"></see></summary>
    let conditional = _prefix "conditional"
    /// <summary>
    /// conditional particule
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#conditionalParticle"></see></summary>
    let conditionalParticle = _prefix "conditionalParticle"
    /// <summary>
    /// conditional pronoun
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#conditionalPronoun"></see></summary>
    let conditionalPronoun = _prefix "conditionalPronoun"
    /// <summary>
    /// The confidence in a given relationship.
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#confidence"></see></summary>
    let confidence = _prefix "confidence"
    /// <summary>
    /// Word that syntactically links words or constituents, and expresses a semantic relationship between them.
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#conjunction"></see></summary>
    let conjunction = _prefix "conjunction"
    /// <summary>
    /// A lexical unit formed by a shortening of a word, syllable, or word group by omission of a sound or letter.
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#contraction"></see></summary>
    let contraction = _prefix "contraction"
    /// <summary>
    /// A subordinate concept having the same nearest superordinate concept and same criterion of subdivision as some other concept in a given concept system.
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#coordinateConcept"></see></summary>
    let coordinateConcept = _prefix "coordinateConcept"
    /// <summary>
    /// Conjunction that links constituents.
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#coordinatingConjunction"></see></summary>
    let coordinatingConjunction = _prefix "coordinatingConjunction"
    /// <summary>
    /// particle for coordination
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#coordinationParticle"></see></summary>
    let coordinationParticle = _prefix "coordinationParticle"
    /// <summary>
    /// Special word that combines the subject of a sentence and its description.
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#copula"></see></summary>
    let copula = _prefix "copula"
    /// <summary>
    /// Indication specifying whether the usage is old or modern.
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#dating"></see></summary>
    let dating = _prefix "dating"
    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#dativeCaseForm"></see>
    /// </summary>
    let dativeCaseForm = _prefix "dativeCaseForm"
    /// <summary>
    /// verb lacking certain morphosyntactic properties
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#deficientVerb"></see></summary>
    let deficientVerb = _prefix "deficientVerb"
    /// <summary>
    /// Value referring to the capacity of identification of an entity.
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#definite"></see></summary>
    let definite = _prefix "definite"
    /// <summary>
    /// Article that allows the reference to a specific, identifiable entity (or class of entities).
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#definiteArticle"></see></summary>
    let definiteArticle = _prefix "definiteArticle"
    /// <summary>
    /// Property about the possiblity to identify an entity.
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#definiteness"></see></summary>
    let definiteness = _prefix "definiteness"
    /// <summary>
    /// Property concerning comparison.
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#degree"></see></summary>
    let degree = _prefix "degree"
    /// <summary>
    /// Case which expresses motion downward from the referent of the noun it marks.
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#delativeCase"></see></summary>
    let delativeCase = _prefix "delativeCase"
    /// <summary>
    /// Determiner used to point to an entity in the situation or elsewhere in a sentence.
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#demonstrativeDeterminer"></see></summary>
    let demonstrativeDeterminer = _prefix "demonstrativeDeterminer"
    /// <summary>
    /// Pronoun used to point to an entity in the situation or elsewhere in a sentence.
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#demonstrativePronoun"></see></summary>
    let demonstrativePronoun = _prefix "demonstrativePronoun"
    /// <summary>
    /// A term rated according to the scale of a term acceptability rating as undesired.
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#deprecatedTerm"></see></summary>
    let deprecatedTerm = _prefix "deprecatedTerm"
    /// <summary>
    /// A description in general prose text of the issues that are indicated by the context. The description field can occur at many different places in a component and profile.
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#description"></see></summary>
    let description = _prefix "description"
    /// <summary>
    /// Word or affix that belongs to a class of noun modifiers that expresses the reference, including quantity, of a noun.
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#determiner"></see></summary>
    let determiner = _prefix "determiner"
    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#dialectRegister"></see>
    /// </summary>
    let dialectRegister = _prefix "dialectRegister"
    /// <summary>
    /// diminutive noun
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#diminutiveNoun"></see></summary>
    let diminutiveNoun = _prefix "diminutiveNoun"
    /// <summary>
    /// distinctive particle
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#distinctiveParticle"></see></summary>
    let distinctiveParticle = _prefix "distinctiveParticle"
    /// <summary>
    /// Form used in some languages to designate two persons or things.
    /// The form used in some languages to designate two persons or things.
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#dual"></see></summary>
    let dual = _prefix "dual"
    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#dualNumberForm"></see>
    /// </summary>
    let dualNumberForm = _prefix "dualNumberForm"
    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#formNumberVariant"></see>
    /// </summary>
    let formNumberVariant = _prefix "formNumberVariant"
    /// <summary>
    /// Case which expresses the meaning of motion 'away from' from the referent of the noun it marks.
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#elativeCase"></see></summary>
    let elativeCase = _prefix "elativeCase"
    /// <summary>
    /// An emphatic pronoun is a personal pronoun that is used to emphasize its referent.
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#emphaticPronoun"></see></summary>
    let emphaticPronoun = _prefix "emphaticPronoun"
    /// <summary>
    /// A term that heads a terminological entry.
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#entryTerm"></see></summary>
    let entryTerm = _prefix "entryTerm"
    /// <summary>
    /// An expression used to represent a concept based on a statement that two mathematical expressions are, for instance, equal as identified by the equal sign (=), or assigned to one another by a similar sign.
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#equation"></see></summary>
    let equation = _prefix "equation"
    /// <summary>
    /// Case that expresses likeness or identity to the referent of the noun it marks. It can have meaning, such as: 'as', 'like', or 'in the capacity of'.
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#equativeCase"></see></summary>
    let equativeCase = _prefix "equativeCase"
    /// <summary>
    /// Case assigned to the subject of a transitive verb as opposed to absolutive case.
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#ergativeCase"></see></summary>
    let ergativeCase = _prefix "ergativeCase"
    /// <summary>
    /// Case which expresses a state of being.
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#essiveCase"></see></summary>
    let essiveCase = _prefix "essiveCase"
    /// <summary>
    /// Morpheme that has a particular status with regards to the word's etymology.
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#etymologicalRoot"></see></summary>
    let etymologicalRoot = _prefix "etymologicalRoot"
    /// <summary>
    /// Information on the origin of a word and the development of its meaning.
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#etymology"></see></summary>
    let etymology = _prefix "etymology"
    /// <summary>
    /// Completely correct in every detail
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#exact"></see></summary>
    let exact = _prefix "exact"
    /// <summary>
    /// Determiner expressing an emotional utterance and marked with a strong intonation.
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#exclamativeDeterminer"></see></summary>
    let exclamativeDeterminer = _prefix "exclamativeDeterminer"
    /// <summary>
    /// Special sign (!) usually used in writing to mark exclamation.
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#exclamativePoint"></see></summary>
    let exclamativePoint = _prefix "exclamativePoint"
    /// <summary>
    /// Pronoun marked with an emotional utterance and/or a strong intonation.
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#exclamativePronoun"></see></summary>
    let exclamativePronoun = _prefix "exclamativePronoun"
    /// <summary>
    /// pronoun that indicates the existence of something or someone
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#existentialPronoun"></see></summary>
    let existentialPronoun = _prefix "existentialPronoun"
    /// <summary>
    /// A statement that describes and clarifies a concept and makes it understandable, but does not necessarily differentiate it from other concepts.
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#explanation"></see></summary>
    let explanation = _prefix "explanation"
    /// <summary>
    /// A significant word or phrase.
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#expression"></see></summary>
    let expression = _prefix "expression"
    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#facetiousRegister"></see>
    /// </summary>
    let facetiousRegister = _prefix "facetiousRegister"
    /// <summary>
    /// Of, relating to, or constituting the gender that ordinarily includes most words or grammatical forms referring to females.
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#feminine"></see></summary>
    let feminine = _prefix "feminine"
    /// <summary>
    /// Property applied to a verb form that can occur on its own in an independent sentence.
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#finite"></see></summary>
    let finite = _prefix "finite"
    /// <summary>
    /// Property referring to finite and non-finite status of a verbal form.
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#finiteness"></see></summary>
    let finiteness = _prefix "finiteness"
    /// <summary>
    /// First person deixis is deictic reference that refers to the speaker, or both the speaker and referents grouped with the speaker
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#firstPerson"></see></summary>
    let firstPerson = _prefix "firstPerson"
    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#firstPersonForm"></see>
    /// </summary>
    let firstPersonForm = _prefix "firstPersonForm"
    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#formPersonVariant"></see>
    /// </summary>
    let formPersonVariant = _prefix "formPersonVariant"
    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#formMoodVariant"></see>
    /// </summary>
    let formMoodVariant = _prefix "formMoodVariant"
    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#formPositivityVariant"></see>
    /// </summary>
    let formPositivityVariant = _prefix "formPositivityVariant"
    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#formTenseVariant"></see>
    /// </summary>
    let formTenseVariant = _prefix "formTenseVariant"
    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#formalRegister"></see>
    /// </summary>
    let formalRegister = _prefix "formalRegister"
    /// <summary>
    /// Figures, symbols or the like used to express a concept briefly, such as a mathematical or chemical formula.
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#formula"></see></summary>
    let formula = _prefix "formula"
    /// <summary>
    /// The relative commonness with which a term occurs.
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#frequency"></see></summary>
    let frequency = _prefix "frequency"
    /// <summary>
    /// For definiteness, when a specific form is the syntactic subject of the clause.
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#fullArticle"></see></summary>
    let fullArticle = _prefix "fullArticle"
    /// <summary>
    /// The complete presentation of a term or lexeme for which there is an abbreviated form.
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#fullForm"></see></summary>
    let fullForm = _prefix "fullForm"
    /// <summary>
    /// A linking element used to identify a relation between any full form of a term or lexical unit and its abbreviated form.
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#fullFormFor"></see></summary>
    let fullFormFor = _prefix "fullFormFor"
    /// <summary>
    /// Preposition that is the result of a morphological merge from at least two words.
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#fusedPreposition"></see></summary>
    let fusedPreposition = _prefix "fusedPreposition"
    /// <summary>
    /// word resulting from the aggregation of a proposition and a determiner
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#fusedPrepositionDeterminer"></see></summary>
    let fusedPrepositionDeterminer = _prefix "fusedPrepositionDeterminer"
    /// <summary>
    /// word resulting from the aggregation of a preposition and a pronoun
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#fusedPrepositionPronoun"></see></summary>
    let fusedPrepositionPronoun = _prefix "fusedPrepositionPronoun"
    /// <summary>
    /// word resulting from the aggregation of a pronoun and an auxiliary
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#fusedPronounAuxiliary"></see></summary>
    let fusedPronounAuxiliary = _prefix "fusedPronounAuxiliary"
    /// <summary>
    /// Verb tense that indicates action or state of being in the future.
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#future"></see></summary>
    let future = _prefix "future"
    /// <summary>
    /// Particle used in order to express future.
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#futureParticle"></see></summary>
    let futureParticle = _prefix "futureParticle"
    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#futureTenseForm"></see>
    /// </summary>
    let futureTenseForm = _prefix "futureTenseForm"
    /// <summary>
    /// A grammatical category that indicates grammatical relationships between words in sentences.
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#gender"></see></summary>
    let gender = _prefix "gender"
    /// <summary>
    /// Adverb belonging to the general class of adverbs
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#generalAdverb"></see></summary>
    let generalAdverb = _prefix "generalAdverb"
    /// <summary>
    /// A word that does not carry its own meaning but generalizes the meaning of a neighboring word, adding the &amp;quot;etc.&amp;quot; sense.
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#generalizationWord"></see></summary>
    let generalizationWord = _prefix "generalizationWord"
    /// <summary>
    /// A numeral used to indicate the number of sets/kinds of objects.
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#genericNumeral"></see></summary>
    let genericNumeral = _prefix "genericNumeral"
    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#genitiveCaseForm"></see>
    /// </summary>
    let genitiveCaseForm = _prefix "genitiveCaseForm"
    /// <summary>
    /// Description of a specific form used in a certain region as opposed to another form used in another region
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#geographicalVariant"></see></summary>
    let geographicalVariant = _prefix "geographicalVariant"
    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#gerundClause"></see>
    /// </summary>
    let gerundClause = _prefix "gerundClause"
    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#gerundive"></see>
    /// </summary>
    let gerundive = _prefix "gerundive"
    /// <summary>
    /// In TEI: A phrase or word used to provide a gloss or definition for some other word or phrase.
    /// In 1951: Any editorial comment.
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#gloss"></see></summary>
    let gloss = _prefix "gloss"
    /// <summary>
    /// Indicates that the referenced element is a part of this object
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#holonymTerm"></see></summary>
    let holonymTerm = _prefix "holonymTerm"
    /// <summary>
    /// A relation between two concepts where one of the concepts constitutes the whole and the other concept a part of that whole.
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#partitiveRelation"></see></summary>
    let partitiveRelation = _prefix "partitiveRelation"
    /// <summary>
    /// Indicates this is a part of another concept
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#meronymTerm"></see></summary>
    let meronymTerm = _prefix "meronymTerm"
    /// <summary>
    /// A word that is spelled like another, but that has a different pronunciation, meaning, and/or origin.
    /// Word that is written like another, but that has a different pronunciation, meaning, and/or origin.
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#homograph"></see></summary>
    let homograph = _prefix "homograph"
    /// <summary>
    /// A word that is pronounced like another word and that can be spelled the same way (homograph) or can merely sound the same (homophone).
    /// Word that sounds the same and is written the same as another word but is different in meaning.
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#homonym"></see></summary>
    let homonym = _prefix "homonym"
    /// <summary>
    /// A word that is pronounced in the same way as another word but that is spelled differently.
    /// Word that sounds like another word, but is different in writiing or meaning.
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#homophone"></see></summary>
    let homophone = _prefix "homophone"
    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#hypernym"></see>
    /// </summary>
    let hypernym = _prefix "hypernym"
    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#hyponym"></see>
    /// </summary>
    let hyponym = _prefix "hyponym"
    /// <summary>
    /// A group of words in a fixed order that have a particular meaning that is different from the meanings of each word understood on its own.
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#idiom"></see></summary>
    let idiom = _prefix "idiom"
    /// <summary>
    /// Case which expresses the meaning of 'motion into' or 'direction towards' the referent of the noun it marks.
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#illativeCase"></see></summary>
    let illativeCase = _prefix "illativeCase"
    /// <summary>
    /// Mood used to express an order.
    /// ...
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#imperative"></see></summary>
    let imperative = _prefix "imperative"
    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#imperativeMoodForm"></see>
    /// </summary>
    let imperativeMoodForm = _prefix "imperativeMoodForm"
    /// <summary>
    /// Verb tense that refers to action in the past that is incomplete or ongoing.
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#imperfect"></see></summary>
    let imperfect = _prefix "imperfect"
    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#imperfectTenseForm"></see>
    /// </summary>
    let imperfectTenseForm = _prefix "imperfectTenseForm"
    /// <summary>
    /// Imperfective aspect is an aspect that expresses an event or state, with respect to its internal structure, instead of expressing it as a simple whole.
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#imperfective"></see></summary>
    let imperfective = _prefix "imperfective"
    /// <summary>
    /// Pronoun lacking person referent.
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#impersonalPronoun"></see></summary>
    let impersonalPronoun = _prefix "impersonalPronoun"
    /// <summary>
    /// The register of terms that are company-specific and not readily recognized outside this environment.
    /// Register of terms that are company-specific and not readily recognized outside this environment.
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#inHouseRegister"></see></summary>
    let inHouseRegister = _prefix "inHouseRegister"
    /// <summary>
    /// Perceived as not living.
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#inanimate"></see></summary>
    let inanimate = _prefix "inanimate"
    /// <summary>
    /// Aspect that expresses the beginning of an event or state.
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#inchoative"></see></summary>
    let inchoative = _prefix "inchoative"
    /// <summary>
    /// Value related to an entity in a situation where the identification of this entity is not clear cut.
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#indefinite"></see></summary>
    let indefinite = _prefix "indefinite"
    /// <summary>
    /// Article not capable of expressing identification.
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#indefiniteArticle"></see></summary>
    let indefiniteArticle = _prefix "indefiniteArticle"
    /// <summary>
    /// A word used to express imprecise quantity.
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#indefiniteCardinalNumeral"></see></summary>
    let indefiniteCardinalNumeral = _prefix "indefiniteCardinalNumeral"
    /// <summary>
    /// Determiner not capable of identification.
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#indefiniteDeterminer"></see></summary>
    let indefiniteDeterminer = _prefix "indefiniteDeterminer"
    /// <summary>
    /// A word indicating imprecise number of times something happened.
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#indefiniteMultiplicativeNumeral"></see></summary>
    let indefiniteMultiplicativeNumeral = _prefix "indefiniteMultiplicativeNumeral"
    /// <summary>
    /// A word used to indicate imprecise rank of an object in a sequence.
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#indefiniteOrdinalNumeral"></see></summary>
    let indefiniteOrdinalNumeral = _prefix "indefiniteOrdinalNumeral"
    /// <summary>
    /// Pronoun that does not allow reference.
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#indefinitePronoun"></see></summary>
    let indefinitePronoun = _prefix "indefinitePronoun"
    /// <summary>
    /// Mood value used in the expression of statements and questions.
    /// ...
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#indicative"></see></summary>
    let indicative = _prefix "indicative"
    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#indicativeMoodForm"></see>
    /// </summary>
    let indicativeMoodForm = _prefix "indicativeMoodForm"
    /// <summary>
    /// Markup to express that there is not any pertinence.
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#indifferent"></see></summary>
    let indifferent = _prefix "indifferent"
    /// <summary>
    /// Case which expresses the meaning of location or position within a place.
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#inessiveCase"></see></summary>
    let inessiveCase = _prefix "inessiveCase"
    /// <summary>
    /// Mood cited as unmarked or base form.
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#infinitive"></see></summary>
    let infinitive = _prefix "infinitive"
    /// <summary>
    /// Particle used to express infinitive.
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#infinitiveParticle"></see></summary>
    let infinitiveParticle = _prefix "infinitiveParticle"
    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#infix"></see>
    /// </summary>
    let infix = _prefix "infix"
    /// <summary>
    /// An element of language used to change the form of a word (noun, adjective) by declension, and (verbs) by conjugation.
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#inflectionElement"></see></summary>
    let inflectionElement = _prefix "inflectionElement"
    /// <summary>
    /// Said of a term that does not appear frequently.
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#infrequentlyUsed"></see></summary>
    let infrequentlyUsed = _prefix "infrequentlyUsed"
    /// <summary>
    /// An abbreviation made up of the initial letters of the components of the full form of the designation or from syllables of the full form and pronounced letter by letter.
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#initialism"></see></summary>
    let initialism = _prefix "initialism"
    /// <summary>
    /// A linking element used to identify a relation between an initialism and its full or expanded form.
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#initialismFor"></see></summary>
    let initialismFor = _prefix "initialismFor"
    /// <summary>
    /// Case indicating that the referent of the noun it marks is the means of the accomplishment of the action expressed by the clause.
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#instrumentalCase"></see></summary>
    let instrumentalCase = _prefix "instrumentalCase"
    /// <summary>
    /// A term that is part of an international scientific nomenclature as adopted by an appropriate scientific body.
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#internationalScientificTerm"></see></summary>
    let internationalScientificTerm = _prefix "internationalScientificTerm"
    /// <summary>
    /// A term that has the same or nearly identical orthographic or phonemic form in many languages.
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#internationalism"></see></summary>
    let internationalism = _prefix "internationalism"
    /// <summary>
    /// An interrogative/relative word used to ask about quantity.
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#interrogativeCardinalNumeral"></see></summary>
    let interrogativeCardinalNumeral = _prefix "interrogativeCardinalNumeral"
    /// <summary>
    /// Determiner used to express a question.
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#interrogativeDeterminer"></see></summary>
    let interrogativeDeterminer = _prefix "interrogativeDeterminer"

    /// <summary>
    /// An interrogative/relative word used to ask about the number of times something happened.
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#interrogativeMultiplicativeNumeral"></see></summary>
    let interrogativeMultiplicativeNumeral =
        _prefix "interrogativeMultiplicativeNumeral"

    /// <summary>
    /// An interrogative/relative word used to ask about numeric ranking.
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#interrogativeOrdinalNumeral"></see></summary>
    let interrogativeOrdinalNumeral = _prefix "interrogativeOrdinalNumeral"
    /// <summary>
    /// Particle used to express a question.
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#interrogativeParticle"></see></summary>
    let interrogativeParticle = _prefix "interrogativeParticle"
    /// <summary>
    /// Pronoun used to express a question.
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#interrogativePronoun"></see></summary>
    let interrogativePronoun = _prefix "interrogativePronoun"
    /// <summary>
    /// pronoun which may act as a relative pronoun or an interrogative one
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#interrogativeRelativePronoun"></see></summary>
    let interrogativeRelativePronoun = _prefix "interrogativeRelativePronoun"
    /// <summary>
    /// Inverted comma.
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#invertedComma"></see></summary>
    let invertedComma = _prefix "invertedComma"
    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#ironicRegister"></see>
    /// </summary>
    let ironicRegister = _prefix "ironicRegister"
    /// <summary>
    /// personal pronoun which is not reflexive
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#irreflexivePersonalPronoun"></see></summary>
    let irreflexivePersonalPronoun = _prefix "irreflexivePersonalPronoun"
    /// <summary>
    /// Case which expresses motion to a location.
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#lativeCase"></see></summary>
    let lativeCase = _prefix "lativeCase"
    /// <summary>
    /// A term that is legally defined and used in legally binding documents.
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#legalTerm"></see></summary>
    let legalTerm = _prefix "legalTerm"
    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#letter"></see>
    /// </summary>
    let letter = _prefix "letter"
    /// <summary>
    /// verb participating in a complex predication that has little semantic content of its own.
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#lightVerb"></see></summary>
    let lightVerb = _prefix "lightVerb"
    /// <summary>
    /// Case that indicates a final location of action or a time of the action.
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#locativeCase"></see></summary>
    let locativeCase = _prefix "locativeCase"
    /// <summary>
    /// An expression used to represent a concept based on mathematical or logical relations, such as statements of inequality, set relationships, boolean operations, and the like.
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#logicalExpression"></see></summary>
    let logicalExpression = _prefix "logicalExpression"
    /// <summary>
    /// Main verb in contrast to a modal or an auxiliary.
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#mainVerb"></see></summary>
    let mainVerb = _prefix "mainVerb"
    /// <summary>
    /// Of, relating to, or constituting the gender that ordinarily includes most words or grammatical forms referring to males.
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#masculine"></see></summary>
    let masculine = _prefix "masculine"
    /// <summary>
    /// Designation of a term or word that is not countable and cannot generally be used with the indefinite article or in the plural.
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#massNoun"></see></summary>
    let massNoun = _prefix "massNoun"
    /// <summary>
    /// Indicates the object is a member of this
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#memberHolonym"></see></summary>
    let memberHolonym = _prefix "memberHolonym"
    /// <summary>
    /// Indicates this is an element of the other
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#memberMeronym"></see></summary>
    let memberMeronym = _prefix "memberMeronym"
    /// <summary>
    /// Value for middle voice that expresses that the subject is both the agent and object, or that the subject is separate from the agent or that the receiver is the agent him/herself.
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#middleVoice"></see></summary>
    let middleVoice = _prefix "middleVoice"
    /// <summary>
    /// Verb form that is usually used with another verb to express ideas such as possibilities, permission, or intention.
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#modal"></see></summary>
    let modal = _prefix "modal"
    /// <summary>
    /// Currently in use.
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#modern"></see></summary>
    let modern = _prefix "modern"
    /// <summary>
    /// Refers to the prenominal or postnominal positions of determiners which distinguish different forms.
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#modificationType"></see></summary>
    let modificationType = _prefix "modificationType"
    /// <summary>
    /// In TEI: contains information about the grammatical mood of verbs (e.g. indicative, subjunctive, imperative).
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#mood"></see></summary>
    let mood = _prefix "mood"
    /// <summary>
    /// Unit resulting from the division of words into their smallest meaningful parts.
    /// Note: moved to lexeme element from being an independent element; note that this is currently an independent element in 12620
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#morphologicalElement"></see></summary>
    let morphologicalElement = _prefix "morphologicalElement"
    /// <summary>
    /// A word that expresses the number of times something happened.
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#multiplicativeNumeral"></see></summary>
    let multiplicativeNumeral = _prefix "multiplicativeNumeral"
    /// <summary>
    /// denotes the negation or the absence
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#negative"></see></summary>
    let negative = _prefix "negative"
    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#negativeForm"></see>
    /// </summary>
    let negativeForm = _prefix "negativeForm"
    /// <summary>
    /// Particle used to express negation.
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#negativeParticle"></see></summary>
    let negativeParticle = _prefix "negativeParticle"
    /// <summary>
    /// Pronoun used in a context of a negation or for expressing a negation.
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#negativePronoun"></see></summary>
    let negativePronoun = _prefix "negativePronoun"
    /// <summary>
    /// Of, relating to, or constituting the gender that ordinarily includes most words or grammatical forms referring to objects that are not characterized as male or female.
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#neuter"></see></summary>
    let neuter = _prefix "neuter"
    /// <summary>
    /// The register appropriate to general texts or discourse.
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#neutralRegister"></see></summary>
    let neutralRegister = _prefix "neutralRegister"
    /// <summary>
    /// Value for negation.
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#no"></see></summary>
    let no = _prefix "no"
    /// <summary>
    /// Case used to indicate the subject of a verb.
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#nominativeCase"></see></summary>
    let nominativeCase = _prefix "nominativeCase"
    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#nominativeCaseForm"></see>
    /// </summary>
    let nominativeCaseForm = _prefix "nominativeCaseForm"
    /// <summary>
    /// Property related for verb forms occurring on their own only in dependent clauses and lacking tense and mood contrasts.
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#nonFinite"></see></summary>
    let nonFinite = _prefix "nonFinite"
    /// <summary>
    /// A term status qualifier assigned by an authoritative body, such as a standards body or a governmental entity with a regulatory function.
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#normativeAuthorization"></see></summary>
    let normativeAuthorization = _prefix "normativeAuthorization"
    /// <summary>
    /// A statement that provides further information on any part of a language resource entry.
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#note"></see></summary>
    let note = _prefix "note"
    /// <summary>
    /// Part of speech used to express the name of a person, place, action or thing.
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#noun"></see></summary>
    let noun = _prefix "noun"
    /// <summary>
    /// The component of a multiword or multi-morphemic compound term that is determined or modified by the other components making up the term.
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#nucleus"></see></summary>
    let nucleus = _prefix "nucleus"
    /// <summary>
    /// Grammatical category for the variation in form of nouns, pronouns, and any words agreeing with them, depending on how many persons or things are referred to.
    /// In many languages, the grammatical distinction that indicates the number of objects referred to by the term or word.
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#number"></see></summary>
    let number = _prefix "number"
    /// <summary>
    /// Part of speech that expresses a number or the relation to a number.
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#numeral"></see></summary>
    let numeral = _prefix "numeral"
    /// <summary>
    /// Word used to denote the denominator of a fraction.
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#numeralFraction"></see></summary>
    let numeralFraction = _prefix "numeralFraction"
    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#objectComplement"></see>
    /// </summary>
    let objectComplement = _prefix "objectComplement"
    /// <summary>
    /// Case that is used when a noun is the object of a verb or a proposition, except for nominative and vocative case.
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#obliqueCase"></see></summary>
    let obliqueCase = _prefix "obliqueCase"
    /// <summary>
    /// A term or lexeme which is no longer in common use.
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#obsoleteForm"></see></summary>
    let obsoleteForm = _prefix "obsoleteForm"
    /// <summary>
    /// Used in the past.
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#old"></see></summary>
    let old = _prefix "old"
    /// <summary>
    /// Beginning of a pair of parenthesis.
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#openParenthesis"></see></summary>
    let openParenthesis = _prefix "openParenthesis"
    /// <summary>
    /// 1951: An optional part of a headword.
    /// 1951; examples? The question arises whether these are true options or whether the options reflect synonyms or hyponyms (e.g., barrage, barrage de retenue). The question is not whether 1951 should use this markup, but rather how to map this markup in a global environment.
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#optionalElement"></see></summary>
    let optionalElement = _prefix "optionalElement"
    /// <summary>
    /// Adjective/numeral/number expressing a numeric ranking.
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#ordinalAdjective"></see></summary>
    let ordinalAdjective = _prefix "ordinalAdjective"
    /// <summary>
    /// Perceived as related to animacy, but without specific reference to the previous items.
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#otherAnimacy"></see></summary>
    let otherAnimacy = _prefix "otherAnimacy"
    /// <summary>
    /// A grammatical category that indicates grammatical relationships between words in sentences.
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#otherGender"></see></summary>
    let otherGender = _prefix "otherGender"
    /// <summary>
    /// Designation used to classify number-related grammatical information that can differ from the standard European classifications cited above.
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#otherNumber"></see></summary>
    let otherNumber = _prefix "otherNumber"
    /// <summary>
    /// A term or lexeme that has fallen from fashion, but the meaning of which is readily recognizable.
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#outdatedForm"></see></summary>
    let outdatedForm = _prefix "outdatedForm"
    /// <summary>
    /// Indicates a part of this object
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#partHolonym"></see></summary>
    let partHolonym = _prefix "partHolonym"
    /// <summary>
    /// Indicates this a component of the other concept
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#partMeronym"></see></summary>
    let partMeronym = _prefix "partMeronym"
    /// <summary>
    /// A unique alphanumeric designation assigned to an object in a manufacturing system.
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#partNumber"></see></summary>
    let partNumber = _prefix "partNumber"
    /// <summary>
    /// Term referring to a word derived from a verb and used as an adjective.
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#participle"></see></summary>
    let participle = _prefix "participle"
    /// <summary>
    /// Adjective based on a verb.
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#participleAdjective"></see></summary>
    let participleAdjective = _prefix "participleAdjective"
    /// <summary>
    /// Indicates that one lexical entry is the participle form of another, e.g., the adjective 'reassuring' is the participle of 'to reassure'
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#participleFormOf"></see></summary>
    let participleFormOf = _prefix "participleFormOf"
    /// <summary>
    /// Word that does not belong to one of the main classes of words, is invariable in form, and typically has grammatical or pragmatic meaning.
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#particle"></see></summary>
    let particle = _prefix "particle"
    /// <summary>
    /// Article expressing a part or quantity.
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#partitiveArticle"></see></summary>
    let partitiveArticle = _prefix "partitiveArticle"
    /// <summary>
    /// Case that expresses the partial nature of the referent of the noun it marks, as opposed to expressing the whole unit or class of which the referent is a part.
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#partitiveCase"></see></summary>
    let partitiveCase = _prefix "partitiveCase"
    /// <summary>
    /// Term referring to a situation where the grammatical subject is typically the recipient or goal of the action denoted by the verb.
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#passiveVoice"></see></summary>
    let passiveVoice = _prefix "passiveVoice"
    /// <summary>
    /// Past tense is an absolute tense that refers to a time before the moment of utterance.
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#past"></see></summary>
    let past = _prefix "past"
    /// <summary>
    /// Adjective based on a past participle.
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#pastParticipleAdjective"></see></summary>
    let pastParticipleAdjective = _prefix "pastParticipleAdjective"
    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#pastTenseForm"></see>
    /// </summary>
    let pastTenseForm = _prefix "pastTenseForm"
    /// <summary>
    /// Number that specifies 'a few' things.
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#paucal"></see></summary>
    let paucal = _prefix "paucal"
    /// <summary>
    /// Perfective aspect is an aspect that expresses a temporal view of an event or state as a simple whole, apart from the consideration of the internal structure of the time in which it occurs.
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#perfective"></see></summary>
    let perfective = _prefix "perfective"
    /// <summary>
    /// Indication of grammatical person (1st, 2nd, 3rd, etc.) associated with a given inflected form.
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#person"></see></summary>
    let person = _prefix "person"
    /// <summary>
    /// Property that refers to the person.
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#personal"></see></summary>
    let personal = _prefix "personal"
    /// <summary>
    /// Pronoun referring a person.
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#personalPronoun"></see></summary>
    let personalPronoun = _prefix "personalPronoun"
    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#pertainsTo"></see>
    /// </summary>
    let pertainsTo = _prefix "pertainsTo"
    /// <summary>
    /// Any group of two or more words that form a unit, the meaning of which frequently cannot be deduced based on the combined sense of the words making up the phrase.
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#phraseologicalUnit"></see></summary>
    let phraseologicalUnit = _prefix "phraseologicalUnit"
    /// <summary>
    /// verb which has its own semantics
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#plainVerb"></see></summary>
    let plainVerb = _prefix "plainVerb"
    /// <summary>
    /// The form of a term or word (usually of a noun) used to designate more than one object.
    /// Value that expresses more than one element.
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#plural"></see></summary>
    let plural = _prefix "plural"
    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#pluralNumberForm"></see>
    /// </summary>
    let pluralNumberForm = _prefix "pluralNumberForm"
    /// <summary>
    /// Sign (.) used to expresses the end of a sentence or an abbreviation.
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#point"></see></summary>
    let point = _prefix "point"
    /// <summary>
    /// Value used in a comparison relationship when no comparison is involved.
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#positive"></see></summary>
    let positive = _prefix "positive"
    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#positiveDegreeForm"></see>
    /// </summary>
    let positiveDegreeForm = _prefix "positiveDegreeForm"
    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#positiveForm"></see>
    /// </summary>
    let positiveForm = _prefix "positiveForm"
    /// <summary>
    /// Relative to the possession or association.
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#possessive"></see></summary>
    let possessive = _prefix "possessive"
    /// <summary>
    /// An adjective derived from a noun and denoting possession by the object described by the noun.
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#possessiveAdjective"></see></summary>
    let possessiveAdjective = _prefix "possessiveAdjective"
    /// <summary>
    /// Determiner that expresses ownership.
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#possessiveDeterminer"></see></summary>
    let possessiveDeterminer = _prefix "possessiveDeterminer"
    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#possessiveInfinitiveClause"></see>
    /// </summary>
    let possessiveInfinitiveClause = _prefix "possessiveInfinitiveClause"
    /// <summary>
    /// Particle expressing ownship.
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#possessiveParticle"></see></summary>
    let possessiveParticle = _prefix "possessiveParticle"
    /// <summary>
    /// Pronoun that expresses ownership and relationships like ownership, such as kinship, and other forms of association.
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#possessivePronoun"></see></summary>
    let possessivePronoun = _prefix "possessivePronoun"
    /// <summary>
    /// A relative pronoun whose antecedent is the possessor of the subject or object in the relative clause.
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#possessiveRelativePronoun"></see></summary>
    let possessiveRelativePronoun = _prefix "possessiveRelativePronoun"
    /// <summary>
    /// Situation where the modifier is after the modified.
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#postModifier"></see></summary>
    let postModifier = _prefix "postModifier"
    /// <summary>
    /// Situation where the modifier is before the modified.
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#preModifier"></see></summary>
    let preModifier = _prefix "preModifier"
    /// <summary>
    /// A term rated according to the scale of a term acceptability rating as the primary term for a given concept.
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#preferredTerm"></see></summary>
    let preferredTerm = _prefix "preferredTerm"
    /// <summary>
    /// adverb which is very similar in its form to a preposition
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#prepositionalAdverb"></see></summary>
    let prepositionalAdverb = _prefix "prepositionalAdverb"
    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#prepositionalGerundClause"></see>
    /// </summary>
    let prepositionalGerundClause = _prefix "prepositionalGerundClause"
    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#prepositionalObject"></see>
    /// </summary>
    let prepositionalObject = _prefix "prepositionalObject"
    /// <summary>
    /// Verb tense that indicates action or state of being in the present.
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#present"></see></summary>
    let present = _prefix "present"
    /// <summary>
    /// Adjective based on a present participle.
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#presentParticipleAdjective"></see></summary>
    let presentParticipleAdjective = _prefix "presentParticipleAdjective"
    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#presentTenseForm"></see>
    /// </summary>
    let presentTenseForm = _prefix "presentTenseForm"
    /// <summary>
    /// pronoun that identify the current locative or temporal situation
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#presentativePronoun"></see></summary>
    let presentativePronoun = _prefix "presentativePronoun"
    /// <summary>
    /// The simple past or preterite as distinct from the perfect form, e.g,, "showed" not "shown"
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#preterite"></see></summary>
    let preterite = _prefix "preterite"
    /// <summary>
    /// An attribute assigned to a term indicating that that term is the official designator for a product.
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#productName"></see></summary>
    let productName = _prefix "productName"
    /// <summary>
    /// Case for a noun or a pronoun that expresses motion within a place or a period of time needed for an event.
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#prolativeCase"></see></summary>
    let prolativeCase = _prefix "prolativeCase"
    /// <summary>
    /// adverb formed in replacement of a preposition and a pronoun
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#pronominalAdverb"></see></summary>
    let pronominalAdverb = _prefix "pronominalAdverb"
    /// <summary>
    /// Word used in place of a noun or a noun phrase.
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#pronoun"></see></summary>
    let pronoun = _prefix "pronoun"
    /// <summary>
    /// The representation of the manner by which a term or word is articulated.
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#pronunciation"></see></summary>
    let pronunciation = _prefix "pronunciation"
    /// <summary>
    /// A brief popular axiom or saying.
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#proverb"></see></summary>
    let proverb = _prefix "proverb"
    /// <summary>
    /// Graphical mark used either at word level to indicate an abbreviation or at a text level to separate phrases or sentences.
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#punctuation"></see></summary>
    let punctuation = _prefix "punctuation"
    /// <summary>
    /// Property related to four elements.
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#quadrial"></see></summary>
    let quadrial = _prefix "quadrial"
    /// <summary>
    /// Adjective used to qualify.
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#qualifierAdjective"></see></summary>
    let qualifierAdjective = _prefix "qualifierAdjective"
    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#quasiEquivalent"></see>
    /// </summary>
    let quasiEquivalent = _prefix "quasiEquivalent"
    /// <summary>
    /// Sign used to express a question.
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#questionMark"></see></summary>
    let questionMark = _prefix "questionMark"
    /// <summary>
    /// A basic identifiable component of every CJKV character, often found on the left side of the character, that sometimes gives a rough indication of meaning and is used for collating lexical and terminological resources.
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#radical"></see></summary>
    let radical = _prefix "radical"
    /// <summary>
    /// Said of a term that is almost never used.
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#rarelyUsed"></see></summary>
    let rarelyUsed = _prefix "rarelyUsed"
    /// <summary>
    /// Pronoun expressing mutual relationship.
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#reciprocalPronoun"></see></summary>
    let reciprocalPronoun = _prefix "reciprocalPronoun"
    /// <summary>
    /// Type of concrete object or concept (the referent) that an expression represents (the reference).
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#referentType"></see></summary>
    let referentType = _prefix "referentType"
    /// <summary>
    /// Determiner that refers to the same entity.
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#reflexiveDeterminer"></see></summary>
    let reflexiveDeterminer = _prefix "reflexiveDeterminer"
    /// <summary>
    /// personal pronoun which is reflexive
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#reflexivePersonalPronoun"></see></summary>
    let reflexivePersonalPronoun = _prefix "reflexivePersonalPronoun"
    /// <summary>
    /// A possessive pronoun that refers to the subject as the possessor.
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#reflexivePossessivePronoun"></see></summary>
    let reflexivePossessivePronoun = _prefix "reflexivePossessivePronoun"
    /// <summary>
    /// Classification indicating the relative level of language individually assigned to a lexeme or term or to a text type.
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#register"></see></summary>
    let register = _prefix "register"
    /// <summary>
    /// A term defined by law or government regulation.
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#regulatedTerm"></see></summary>
    let regulatedTerm = _prefix "regulatedTerm"
    /// <summary>
    /// relation noun
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#relationNoun"></see></summary>
    let relationNoun = _prefix "relationNoun"
    /// <summary>
    /// Determiner related to a referent.
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#relativeDeterminer"></see></summary>
    let relativeDeterminer = _prefix "relativeDeterminer"
    /// <summary>
    /// relative particle
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#relativeParticle"></see></summary>
    let relativeParticle = _prefix "relativeParticle"
    /// <summary>
    /// Pronoun which introduces a relative clause and refers to something that has been said before.
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#relativePronoun"></see></summary>
    let relativePronoun = _prefix "relativePronoun"
    /// <summary>
    /// Transcription or transliteration from non-Latin script into Latin script.
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#romanization"></see></summary>
    let romanization = _prefix "romanization"
    /// <summary>
    /// base of a word
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#root"></see></summary>
    let root = _prefix "root"
    /// <summary>
    /// Second person deixis is deictic reference to a person or persons identified as addressee.
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#secondPerson"></see></summary>
    let secondPerson = _prefix "secondPerson"
    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#secondPersonForm"></see>
    /// </summary>
    let secondPersonForm = _prefix "secondPersonForm"
    /// <summary>
    /// Specification of the pointers in time or sequence that indicates the segmentation process.
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#segmentation"></see></summary>
    let segmentation = _prefix "segmentation"
    /// <summary>
    /// Sign (;) usually used to separate phrases.
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#semiColon"></see></summary>
    let semiColon = _prefix "semiColon"
    /// <summary>
    /// Descriptive material that provides a sample of an object or entity defined in the entry.
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#senseExample"></see></summary>
    let senseExample = _prefix "senseExample"
    /// <summary>
    /// A fixed, lexicalized phrase.
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#setPhrase"></see></summary>
    let setPhrase = _prefix "setPhrase"
    /// <summary>
    /// For definiteness, when a specific form is not the syntactic subject of the clause.
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#shortArticle"></see></summary>
    let shortArticle = _prefix "shortArticle"
    /// <summary>
    /// A variant of a multiword term or lexeme that includes fewer words than the full form.
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#shortForm"></see></summary>
    let shortForm = _prefix "shortForm"
    /// <summary>
    /// A linking element used to identify a relation between a short form and its full or expanded form.
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#shortFormFor"></see></summary>
    let shortFormFor = _prefix "shortFormFor"
    /// <summary>
    /// Value that expresses one element.
    /// The form of a term or word (usually of a noun) used to designate one object.
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#singular"></see></summary>
    let singular = _prefix "singular"
    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#singularNumberForm"></see>
    /// </summary>
    let singularNumberForm = _prefix "singularNumberForm"
    /// <summary>
    /// An inventory item identified by a unique alphanumeric designation assigned to an object in an inventory control system.
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#sku"></see></summary>
    let sku = _prefix "sku"
    /// <summary>
    /// An extremely informal register of a word, term, or text that is used in spoken and everyday language and less commonly in documents.
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#slangRegister"></see></summary>
    let slangRegister = _prefix "slangRegister"
    /// <summary>
    /// The punctuation sign /
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#slash"></see></summary>
    let slash = _prefix "slash"
    /// <summary>
    /// Case related to the person in whose company the action is carried out, or to any belongings of people which take part in the action.
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#sociativeCase"></see></summary>
    let sociativeCase = _prefix "sociativeCase"
    /// <summary>
    /// A fixed chunk of recurring text.
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#standardText"></see></summary>
    let standardText = _prefix "standardText"
    /// <summary>
    /// A term that has been standardized by a standardizing body.
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#standardizedTerm"></see></summary>
    let standardizedTerm = _prefix "standardizedTerm"
    /// <summary>
    /// A chunk of text used in a software interface, documentation, help file, or the like.
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#string"></see></summary>
    let string = _prefix "string"
    /// <summary>
    /// A type value assigned to a string.
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#stringCategory"></see></summary>
    let stringCategory = _prefix "stringCategory"
    /// <summary>
    /// Personal pronoun that can occupy the position after a preposition and/or reinforce a weak personal pronoun.
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#strongPersonalPronoun"></see></summary>
    let strongPersonalPronoun = _prefix "strongPersonalPronoun"
    /// <summary>
    /// ...
    /// Mood often used to express uncertainty, whishes or desires.
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#subjunctive"></see></summary>
    let subjunctive = _prefix "subjunctive"
    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#subjunctiveClause"></see>
    /// </summary>
    let subjunctiveClause = _prefix "subjunctiveClause"
    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#subjunctiveMoodForm"></see>
    /// </summary>
    let subjunctiveMoodForm = _prefix "subjunctiveMoodForm"
    /// <summary>
    /// Case for a move of something to the surface of another object.
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#sublativeCase"></see></summary>
    let sublativeCase = _prefix "sublativeCase"
    /// <summary>
    /// Conjunction that links constructions by making one of them a constituent of another. The subordinating conjunction typically marks the incorporated constituent.
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#subordinatingConjunction"></see></summary>
    let subordinatingConjunction = _prefix "subordinatingConjunction"
    /// <summary>
    /// Indicates what this is composed of
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#substanceHolonym"></see></summary>
    let substanceHolonym = _prefix "substanceHolonym"
    /// <summary>
    /// Indicates this is a substance that composes the other
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#substanceMeronym"></see></summary>
    let substanceMeronym = _prefix "substanceMeronym"
    /// <summary>
    /// Case indicating location on top of something or on the surface of something.
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#superessiveCase"></see></summary>
    let superessiveCase = _prefix "superessiveCase"
    /// <summary>
    /// Value used in a comparison between more than two entities.
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#superlative"></see></summary>
    let superlative = _prefix "superlative"
    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#superlativeDegreeForm"></see>
    /// </summary>
    let superlativeDegreeForm = _prefix "superlativeDegreeForm"
    /// <summary>
    /// Particle expressing superlative degree. Superlative is the comparison between more than two entities and contrasts with comparative where only two entities are involved and positive where no comparison is implied.
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#superlativeParticle"></see></summary>
    let superlativeParticle = _prefix "superlativeParticle"
    /// <summary>
    /// A term that is no longer preferred or admitted.
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#supersededTerm"></see></summary>
    let supersededTerm = _prefix "supersededTerm"
    /// <summary>
    /// Sequence of three dots having the same meaning as &amp;quot;et cetera&amp;quot; (full form) or &amp;quot;etc&amp;quot; (abbreviated form).
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#suspensionPoints"></see></summary>
    let suspensionPoints = _prefix "suspensionPoints"
    /// <summary>
    /// A unit of spoken language that is next bigger than a speech sound and consists of one or more vowel sounds alone or of a syllabic consonant alone or of either with one or more consonant sounds preceding or following.
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#syllable"></see></summary>
    let syllable = _prefix "syllable"
    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#symbol"></see>
    /// </summary>
    let symbol = _prefix "symbol"
    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#synonym"></see>
    /// </summary>
    let synonym = _prefix "synonym"
    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#tabooRegister"></see>
    /// </summary>
    let tabooRegister = _prefix "tabooRegister"
    /// <summary>
    /// The register appropriate to scientific texts or special languages.
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#technicalRegister"></see></summary>
    let technicalRegister = _prefix "technicalRegister"
    /// <summary>
    /// An attribution of a term or lexeme with respect to its use over time.
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#temporalQualifier"></see></summary>
    let temporalQualifier = _prefix "temporalQualifier"
    /// <summary>
    /// Property referring to the way the grammar marks the time at which the action denoted by the verb took place.
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#tense"></see></summary>
    let tense = _prefix "tense"
    /// <summary>
    /// An attribute assigned to a lexeme or a term.
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#termType"></see></summary>
    let termType = _prefix "termType"
    /// <summary>
    /// Case that indicates to what or where something ends.
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#terminativeCase"></see></summary>
    let terminativeCase = _prefix "terminativeCase"
    /// <summary>
    /// Third person deixis is deictic reference to a referent(s) not identified as the speaker or addressee.
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#thirdPerson"></see></summary>
    let thirdPerson = _prefix "thirdPerson"
    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#thirdPersonForm"></see>
    /// </summary>
    let thirdPersonForm = _prefix "thirdPersonForm"
    /// <summary>
    /// A form of a term or lexeme resulting from an operation whereby the characters of one writing system are represented by characters from another writing system, taking into account the pronunciation of the characters converted.
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#transcribedForm"></see></summary>
    let transcribedForm = _prefix "transcribedForm"
    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#translation"></see>
    /// </summary>
    let translation = _prefix "translation"
    /// <summary>
    /// The confidence in a given translation.
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#translationConfidence"></see></summary>
    let translationConfidence = _prefix "translationConfidence"
    /// <summary>
    /// Case indicating that the referent of the noun, or the quality of the adjective, that it marks is the result of a process of change.
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#translativeCase"></see></summary>
    let translativeCase = _prefix "translativeCase"
    /// <summary>
    /// Form resulting from the conversion of one writing system into another
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#transliteration"></see></summary>
    let transliteration = _prefix "transliteration"
    /// <summary>
    /// Grammatical number referring to 'three things', as opposed to 'singular' and 'plural'.
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#trial"></see></summary>
    let trial = _prefix "trial"
    /// <summary>
    /// aspect that expresses an event or state that is not finished.
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#unaccomplished"></see></summary>
    let unaccomplished = _prefix "unaccomplished"
    /// <summary>
    /// Particle that is not covered by other sorts of particle definitions.
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#unclassifiedParticle"></see></summary>
    let unclassifiedParticle = _prefix "unclassifiedParticle"
    /// <summary>
    /// A note containing information on the usage of the associated word or term.
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#usageNote"></see></summary>
    let usageNote = _prefix "usageNote"
    /// <summary>
    /// Element which, singly or in combination with other verbs is used as the minimal predicate of a sentence, co-occurring with a subject. If the predicate contains other elements (e.g. object, complement), then it is the verb which more than any other is the unit which influences the choice and extent of these elements.
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#verb"></see></summary>
    let verb = _prefix "verb"
    /// <summary>
    /// One of a set of distinctive forms that are used to signal modality. Modality is a facet of illocutionary point or general intent of a speaker, or a speaker's degree of commitment to the expressed proposition's believability, obligatoriness, desirability or reality.
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#verbFormMood"></see></summary>
    let verbFormMood = _prefix "verbFormMood"
    /// <summary>
    /// Case used to indicate direct address.
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#vocativeCase"></see></summary>
    let vocativeCase = _prefix "vocativeCase"
    /// <summary>
    /// Way sentences may alter the relationship between the subject and object of a verb, without changing the meaning of the sentence.
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#voice"></see></summary>
    let voice = _prefix "voice"
    /// <summary>
    /// The register of a term or text type that can be characterized as profane or socially unacceptable.
    /// Register of a term or text type that can be characterized as profane or socially unacceptable.
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#vulgarRegister"></see></summary>
    let vulgarRegister = _prefix "vulgarRegister"
    /// <summary>
    /// Personal pronoun that cannot occupy the position after a preposition and/or reinforce a strong personal pronoun.
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#weakPersonalPronoun"></see></summary>
    let weakPersonalPronoun = _prefix "weakPersonalPronoun"
    /// <summary>
    /// Any lexeme element in a compound lexical unit that is itself a word.
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#wordElement"></see></summary>
    let wordElement = _prefix "wordElement"
    /// <summary>
    /// Positive value
    /// <see href="http://www.lexinfo.net/ontology/2.0/lexinfo#yes"></see></summary>
    let yes = _prefix "yes"
