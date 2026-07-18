namespace http.www.lexinfo.net.ontology._3._0.lexinfo.hash

open DoxAletheia.Rdf_Vocabulary

module lexinfo =
    let _namespace_name = "http://www.lexinfo.net/ontology/3.0/lexinfo#"

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#AbbreviatedForm"></see>
    /// </summary>
    let AbbreviatedForm =
        Namespaced_IRI.parse _namespace_name "AbbreviatedForm" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#TermType"></see>
    /// </summary>
    let TermType = Namespaced_IRI.parse _namespace_name "TermType" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#AccusativePostPositiveArg"></see>
    /// </summary>
    let AccusativePostPositiveArg =
        Namespaced_IRI.parse _namespace_name "AccusativePostPositiveArg" |> NamespacedName

    /// <summary>
    /// Indicates an argument of an adjective indicated by post-positive modification. An example in english would be that "that is something interesting", where the adjective interesting post-postively modifies something
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#PostPositiveArg"></see></summary>
    let PostPositiveArg =
        Namespaced_IRI.parse _namespace_name "PostPositiveArg" |> NamespacedName

    /// <summary>
    /// Case used to indicate direct object.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#accusativeCase"></see></summary>
    let accusativeCase =
        Namespaced_IRI.parse _namespace_name "accusativeCase" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#AdjectivalComplementFrame"></see>
    /// </summary>
    let AdjectivalComplementFrame =
        Namespaced_IRI.parse _namespace_name "AdjectivalComplementFrame" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#VerbFrame"></see>
    /// </summary>
    let VerbFrame = Namespaced_IRI.parse _namespace_name "VerbFrame" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#predicativeAdjective"></see>
    /// </summary>
    let predicativeAdjective =
        Namespaced_IRI.parse _namespace_name "predicativeAdjective" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#Adjective"></see>
    /// </summary>
    let Adjective = Namespaced_IRI.parse _namespace_name "Adjective" |> NamespacedName

    /// <summary>
    /// A category assigned to a word based on its grammatical and semantic properties. // Term used to describe how a particular word is used in a sentence.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#partOfSpeech"></see></summary>
    let partOfSpeech =
        Namespaced_IRI.parse _namespace_name "partOfSpeech" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#AdjectivePOS"></see>
    /// </summary>
    let AdjectivePOS =
        Namespaced_IRI.parse _namespace_name "AdjectivePOS" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#Adjective-i"></see>
    /// </summary>
    let ``Adjective-i`` =
        Namespaced_IRI.parse _namespace_name "Adjective-i" |> NamespacedName

    /// <summary>
    /// Deverbal adjective in Japanese ending with the '-i' suffix in dictionary form
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#adjective-i"></see></summary>
    let ``adjective-i`` =
        Namespaced_IRI.parse _namespace_name "adjective-i" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#Adjective-na"></see>
    /// </summary>
    let ``Adjective-na`` =
        Namespaced_IRI.parse _namespace_name "Adjective-na" |> NamespacedName

    /// <summary>
    /// Denominal adjectives in Japanese formed from a noun plus the particle 'na'
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#adjective-na"></see></summary>
    let ``adjective-na`` =
        Namespaced_IRI.parse _namespace_name "adjective-na" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#AdjectiveAccusativePostPositiveFrame"></see>
    /// </summary>
    let AdjectiveAccusativePostPositiveFrame =
        Namespaced_IRI.parse _namespace_name "AdjectiveAccusativePostPositiveFrame" |> NamespacedName

    /// <summary>
    /// An example of the usage of a frame
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#example"></see></summary>
    let example = Namespaced_IRI.parse _namespace_name "example" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#AdjectivePostPositiveFrame"></see>
    /// </summary>
    let AdjectivePostPositiveFrame =
        Namespaced_IRI.parse _namespace_name "AdjectivePostPositiveFrame" |> NamespacedName

    /// <summary>
    /// Indicates an argument of an adjective indicated by post-positive modification. An example in english would be that "that is something interesting", where the adjective interesting post-postively modifies something
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#postPositiveArg"></see></summary>
    let postPositiveArg =
        Namespaced_IRI.parse _namespace_name "postPositiveArg" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#AdjectiveAttributiveFrame"></see>
    /// </summary>
    let AdjectiveAttributiveFrame =
        Namespaced_IRI.parse _namespace_name "AdjectiveAttributiveFrame" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#AdjectiveFrame"></see>
    /// </summary>
    let AdjectiveFrame =
        Namespaced_IRI.parse _namespace_name "AdjectiveFrame" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#attributiveArg"></see>
    /// </summary>
    let attributiveArg =
        Namespaced_IRI.parse _namespace_name "attributiveArg" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#AdjectiveComparativeFrame"></see>
    /// </summary>
    let AdjectiveComparativeFrame =
        Namespaced_IRI.parse _namespace_name "AdjectiveComparativeFrame" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#comparativeAdjunct"></see>
    /// </summary>
    let comparativeAdjunct =
        Namespaced_IRI.parse _namespace_name "comparativeAdjunct" |> NamespacedName

    /// <summary>
    /// Indicates the subject of a copula construction. It is assumed that by using this the copula construction is not reversible e.g.,
    ///
    /// He is happy/*happy is him
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#copulativeSubject"></see></summary>
    let copulativeSubject =
        Namespaced_IRI.parse _namespace_name "copulativeSubject" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#AdjectiveDativePostPositiveFrame"></see>
    /// </summary>
    let AdjectiveDativePostPositiveFrame =
        Namespaced_IRI.parse _namespace_name "AdjectiveDativePostPositiveFrame" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#DativePostPositiveArg"></see>
    /// </summary>
    let DativePostPositiveArg =
        Namespaced_IRI.parse _namespace_name "DativePostPositiveArg" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#AdjectiveGenitivePostPositiveFrame"></see>
    /// </summary>
    let AdjectiveGenitivePostPositiveFrame =
        Namespaced_IRI.parse _namespace_name "AdjectiveGenitivePostPositiveFrame" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#GenitivePostPositiveArg"></see>
    /// </summary>
    let GenitivePostPositiveArg =
        Namespaced_IRI.parse _namespace_name "GenitivePostPositiveArg" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#AdjectiveImpersonalFrame"></see>
    /// </summary>
    let AdjectiveImpersonalFrame =
        Namespaced_IRI.parse _namespace_name "AdjectiveImpersonalFrame" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#object"></see>
    /// </summary>
    let object = Namespaced_IRI.parse _namespace_name "object" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#PartOfSpeech"></see>
    /// </summary>
    let PartOfSpeech =
        Namespaced_IRI.parse _namespace_name "PartOfSpeech" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#AdjectivePPFrame"></see>
    /// </summary>
    let AdjectivePPFrame =
        Namespaced_IRI.parse _namespace_name "AdjectivePPFrame" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#AdjectivePredicativeFrame"></see>
    /// </summary>
    let AdjectivePredicativeFrame =
        Namespaced_IRI.parse _namespace_name "AdjectivePredicativeFrame" |> NamespacedName

    /// <summary>
    /// Abstract frame for words that take a prepositional phrase as an argument
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#PrepositionalFrame"></see></summary>
    let PrepositionalFrame =
        Namespaced_IRI.parse _namespace_name "PrepositionalFrame" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#AdjectivePhrase"></see>
    /// </summary>
    let AdjectivePhrase =
        Namespaced_IRI.parse _namespace_name "AdjectivePhrase" |> NamespacedName

    /// <summary>
    /// Indicates the head element of a phrase
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#head"></see></summary>
    let head = Namespaced_IRI.parse _namespace_name "head" |> NamespacedName

    /// <summary>
    /// Used with copula constructions. This represents the subject/object in a copula construction. As such constructions are reversible this property is used instead of the usual verb subject/object. E,g.,
    ///
    /// Barack Obama is the president/The president is Barack Obama
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#copulativeArg"></see></summary>
    let copulativeArg =
        Namespaced_IRI.parse _namespace_name "copulativeArg" |> NamespacedName

    /// <summary>
    /// Note this frame should be used when both attributive and predicative use of the adjective is allowed
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#AdjectivePredicateFrame"></see></summary>
    let AdjectivePredicateFrame =
        Namespaced_IRI.parse _namespace_name "AdjectivePredicateFrame" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#AdjectiveScaleFrame"></see>
    /// </summary>
    let AdjectiveScaleFrame =
        Namespaced_IRI.parse _namespace_name "AdjectiveScaleFrame" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#adverbialComplement"></see>
    /// </summary>
    let adverbialComplement =
        Namespaced_IRI.parse _namespace_name "adverbialComplement" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#AdjectiveSuperlativeFrame"></see>
    /// </summary>
    let AdjectiveSuperlativeFrame =
        Namespaced_IRI.parse _namespace_name "AdjectiveSuperlativeFrame" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#superlativeAdjunct"></see>
    /// </summary>
    let superlativeAdjunct =
        Namespaced_IRI.parse _namespace_name "superlativeAdjunct" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#Adjunct"></see>
    /// </summary>
    let Adjunct = Namespaced_IRI.parse _namespace_name "Adjunct" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#Adposition"></see>
    /// </summary>
    let Adposition = Namespaced_IRI.parse _namespace_name "Adposition" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#AdpositionPOS"></see>
    /// </summary>
    let AdpositionPOS =
        Namespaced_IRI.parse _namespace_name "AdpositionPOS" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#AdpositionalObject"></see>
    /// </summary>
    let AdpositionalObject =
        Namespaced_IRI.parse _namespace_name "AdpositionalObject" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#Object"></see>
    /// </summary>
    let Object = Namespaced_IRI.parse _namespace_name "Object" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#Adverb"></see>
    /// </summary>
    let Adverb = Namespaced_IRI.parse _namespace_name "Adverb" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#AdverbPOS"></see>
    /// </summary>
    let AdverbPOS = Namespaced_IRI.parse _namespace_name "AdverbPOS" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#AdverbialComplement"></see>
    /// </summary>
    let AdverbialComplement =
        Namespaced_IRI.parse _namespace_name "AdverbialComplement" |> NamespacedName

    /// <summary>
    /// A noun phrase that follows a copula or similar verb, as for example an idiot in the sentence He is an idiot. - A clause that serves as the subject or direct object of a verb or the direct object of a preposition, as for example that he would be early in the sentence I hoped that he would be early
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#Complement"></see></summary>
    let Complement = Namespaced_IRI.parse _namespace_name "Complement" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#AdverbialComplementFrame"></see>
    /// </summary>
    let AdverbialComplementFrame =
        Namespaced_IRI.parse _namespace_name "AdverbialComplementFrame" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#predicativeAdverb"></see>
    /// </summary>
    let predicativeAdverb =
        Namespaced_IRI.parse _namespace_name "predicativeAdverb" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#AdverbialPronoun"></see>
    /// </summary>
    let AdverbialPronoun =
        Namespaced_IRI.parse _namespace_name "AdverbialPronoun" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#Pronoun"></see>
    /// </summary>
    let Pronoun = Namespaced_IRI.parse _namespace_name "Pronoun" |> NamespacedName

    /// <summary>
    /// ()
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#adverbialPronoun"></see></summary>
    let adverbialPronoun =
        Namespaced_IRI.parse _namespace_name "adverbialPronoun" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#AffirmativeParticle"></see>
    /// </summary>
    let AffirmativeParticle =
        Namespaced_IRI.parse _namespace_name "AffirmativeParticle" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#Particle"></see>
    /// </summary>
    let Particle = Namespaced_IRI.parse _namespace_name "Particle" |> NamespacedName

    /// <summary>
    /// Particle used to express affirmation.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#affirmativeParticle"></see></summary>
    let affirmativeParticle =
        Namespaced_IRI.parse _namespace_name "affirmativeParticle" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#AffixedPersonalPronoun"></see>
    /// </summary>
    let AffixedPersonalPronoun =
        Namespaced_IRI.parse _namespace_name "AffixedPersonalPronoun" |> NamespacedName

    /// <summary>
    /// Personnal pronoun that is affixed, i.e. added as an affix to another word.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#affixedPersonalPronoun"></see></summary>
    let affixedPersonalPronoun =
        Namespaced_IRI.parse _namespace_name "affixedPersonalPronoun" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#AllusivePronoun"></see>
    /// </summary>
    let AllusivePronoun =
        Namespaced_IRI.parse _namespace_name "AllusivePronoun" |> NamespacedName

    /// <summary>
    /// Pronoun that refers to something characterized by allusions.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#allusivePronoun"></see></summary>
    let allusivePronoun =
        Namespaced_IRI.parse _namespace_name "allusivePronoun" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#Animacy"></see>
    /// </summary>
    let Animacy = Namespaced_IRI.parse _namespace_name "Animacy" |> NamespacedName

    /// <summary>
    /// Indicates either the subject or object of the main clause may be the omitted argument of the subclause
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#ArbitraryControl"></see></summary>
    let ArbitraryControl =
        Namespaced_IRI.parse _namespace_name "ArbitraryControl" |> NamespacedName

    /// <summary>
    /// Control indicates how a an argument from a main clause will be utilized in a subclause. This class includes both control structures and raising structures
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#Control"></see></summary>
    let Control = Namespaced_IRI.parse _namespace_name "Control" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#Article"></see>
    /// </summary>
    let Article = Namespaced_IRI.parse _namespace_name "Article" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#Determiner"></see>
    /// </summary>
    let Determiner = Namespaced_IRI.parse _namespace_name "Determiner" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#ArticlePOS"></see>
    /// </summary>
    let ArticlePOS = Namespaced_IRI.parse _namespace_name "ArticlePOS" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#DeterminerPOS"></see>
    /// </summary>
    let DeterminerPOS =
        Namespaced_IRI.parse _namespace_name "DeterminerPOS" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#Aspect"></see>
    /// </summary>
    let Aspect = Namespaced_IRI.parse _namespace_name "Aspect" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#AttributiveArg"></see>
    /// </summary>
    let AttributiveArg =
        Namespaced_IRI.parse _namespace_name "AttributiveArg" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#Auxiliary"></see>
    /// </summary>
    let Auxiliary = Namespaced_IRI.parse _namespace_name "Auxiliary" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#Verb"></see>
    /// </summary>
    let Verb = Namespaced_IRI.parse _namespace_name "Verb" |> NamespacedName
    /// <summary>
    /// a verb that adds functional or grammatical meaning to the clause in which it appears, so as to express tense, aspect, modality, voice, emphasis, etc.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#auxiliary"></see></summary>
    let auxiliary = Namespaced_IRI.parse _namespace_name "auxiliary" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#Bullet"></see>
    /// </summary>
    let Bullet = Namespaced_IRI.parse _namespace_name "Bullet" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#Symbol"></see>
    /// </summary>
    let Symbol = Namespaced_IRI.parse _namespace_name "Symbol" |> NamespacedName
    /// <summary>
    /// Sign used to mark an item in a list.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#bullet"></see></summary>
    let bullet = Namespaced_IRI.parse _namespace_name "bullet" |> NamespacedName

    /// <summary>
    /// A lexical unit in a CJKV language that is represented by at least two CJKV characters.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#CJK_compound"></see></summary>
    let CJK_compound =
        Namespaced_IRI.parse _namespace_name "CJK_compound" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#CardinalNumeral"></see>
    /// </summary>
    let CardinalNumeral =
        Namespaced_IRI.parse _namespace_name "CardinalNumeral" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#Numeral"></see>
    /// </summary>
    let Numeral = Namespaced_IRI.parse _namespace_name "Numeral" |> NamespacedName

    /// <summary>
    /// A word denoting a number.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#cardinalNumeral"></see></summary>
    let cardinalNumeral =
        Namespaced_IRI.parse _namespace_name "cardinalNumeral" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#Case"></see>
    /// </summary>
    let Case = Namespaced_IRI.parse _namespace_name "Case" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#Circumposition"></see>
    /// </summary>
    let Circumposition =
        Namespaced_IRI.parse _namespace_name "Circumposition" |> NamespacedName

    /// <summary>
    /// Adposition which consists of two parts which are positioned ahead and after the adpositional foci.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#circumposition"></see></summary>
    let circumposition =
        Namespaced_IRI.parse _namespace_name "circumposition" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#ClausalArg"></see>
    /// </summary>
    let ClausalArg = Namespaced_IRI.parse _namespace_name "ClausalArg" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#Cliticness"></see>
    /// </summary>
    let Cliticness = Namespaced_IRI.parse _namespace_name "Cliticness" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#CloseParenthesis"></see>
    /// </summary>
    let CloseParenthesis =
        Namespaced_IRI.parse _namespace_name "CloseParenthesis" |> NamespacedName

    /// <summary>
    /// End of a parenthesis pair.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#closeParenthesis"></see></summary>
    let closeParenthesis =
        Namespaced_IRI.parse _namespace_name "closeParenthesis" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#CollectivePronoun"></see>
    /// </summary>
    let CollectivePronoun =
        Namespaced_IRI.parse _namespace_name "CollectivePronoun" |> NamespacedName

    /// <summary>
    /// A pronoun that refers to all elements of a set.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#collectivePronoun"></see></summary>
    let collectivePronoun =
        Namespaced_IRI.parse _namespace_name "collectivePronoun" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#Colon"></see>
    /// </summary>
    let Colon = Namespaced_IRI.parse _namespace_name "Colon" |> NamespacedName
    /// <summary>
    /// Sign with two vertical points that is used in writing and printing to introduce an explanation, example or quotation.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#colon"></see></summary>
    let colon = Namespaced_IRI.parse _namespace_name "colon" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#Comma"></see>
    /// </summary>
    let Comma = Namespaced_IRI.parse _namespace_name "Comma" |> NamespacedName
    /// <summary>
    /// Mark (,) used in writing to show a short pause or to separate items in a list.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#comma"></see></summary>
    let comma = Namespaced_IRI.parse _namespace_name "comma" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#CommonNoun"></see>
    /// </summary>
    let CommonNoun = Namespaced_IRI.parse _namespace_name "CommonNoun" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#Noun"></see>
    /// </summary>
    let Noun = Namespaced_IRI.parse _namespace_name "Noun" |> NamespacedName
    /// <summary>
    /// A noun or adjective denoting a class of objects. // Noun that signifies a non-specific member of a group.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#commonNoun"></see></summary>
    let commonNoun = Namespaced_IRI.parse _namespace_name "commonNoun" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#ComparativeAdjunct"></see>
    /// </summary>
    let ComparativeAdjunct =
        Namespaced_IRI.parse _namespace_name "ComparativeAdjunct" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#PredicativeAdjunct"></see>
    /// </summary>
    let PredicativeAdjunct =
        Namespaced_IRI.parse _namespace_name "PredicativeAdjunct" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#ComparativeParticle"></see>
    /// </summary>
    let ComparativeParticle =
        Namespaced_IRI.parse _namespace_name "ComparativeParticle" |> NamespacedName

    /// <summary>
    /// Particle used to compare.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#comparativeParticle"></see></summary>
    let comparativeParticle =
        Namespaced_IRI.parse _namespace_name "comparativeParticle" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#CompoundPreposition"></see>
    /// </summary>
    let CompoundPreposition =
        Namespaced_IRI.parse _namespace_name "CompoundPreposition" |> NamespacedName

    /// <summary>
    /// Preposition that is a aggregation of words
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#compoundPreposition"></see></summary>
    let compoundPreposition =
        Namespaced_IRI.parse _namespace_name "compoundPreposition" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#ConditionalParticle"></see>
    /// </summary>
    let ConditionalParticle =
        Namespaced_IRI.parse _namespace_name "ConditionalParticle" |> NamespacedName

    /// <summary>
    /// conditional particule
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#conditionalParticle"></see></summary>
    let conditionalParticle =
        Namespaced_IRI.parse _namespace_name "conditionalParticle" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#ConditionalPronoun"></see>
    /// </summary>
    let ConditionalPronoun =
        Namespaced_IRI.parse _namespace_name "ConditionalPronoun" |> NamespacedName

    /// <summary>
    /// conditional pronoun
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#conditionalPronoun"></see></summary>
    let conditionalPronoun =
        Namespaced_IRI.parse _namespace_name "conditionalPronoun" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#Conjunction"></see>
    /// </summary>
    let Conjunction =
        Namespaced_IRI.parse _namespace_name "Conjunction" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#ConjunctionPOS"></see>
    /// </summary>
    let ConjunctionPOS =
        Namespaced_IRI.parse _namespace_name "ConjunctionPOS" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#CoordinatingConjunction"></see>
    /// </summary>
    let CoordinatingConjunction =
        Namespaced_IRI.parse _namespace_name "CoordinatingConjunction" |> NamespacedName

    /// <summary>
    /// Conjunction that links constituents.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#coordinatingConjunction"></see></summary>
    let coordinatingConjunction =
        Namespaced_IRI.parse _namespace_name "coordinatingConjunction" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#CoordinationParticle"></see>
    /// </summary>
    let CoordinationParticle =
        Namespaced_IRI.parse _namespace_name "CoordinationParticle" |> NamespacedName

    /// <summary>
    /// particle for coordination
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#coordinationParticle"></see></summary>
    let coordinationParticle =
        Namespaced_IRI.parse _namespace_name "coordinationParticle" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#Copula"></see>
    /// </summary>
    let Copula = Namespaced_IRI.parse _namespace_name "Copula" |> NamespacedName
    /// <summary>
    /// Special word that combines the subject of a sentence and its description.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#copula"></see></summary>
    let copula = Namespaced_IRI.parse _namespace_name "copula" |> NamespacedName

    /// <summary>
    /// Used with copula constructions. This represents the subject/object in a copula construction. As such constructions are reversible this property is used instead of the usual verb subject/object. E,g.,
    ///
    /// Barack Obama is the president/The president is Barack Obama
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#CopulativeArg"></see></summary>
    let CopulativeArg =
        Namespaced_IRI.parse _namespace_name "CopulativeArg" |> NamespacedName

    /// <summary>
    /// Indicates the subject of a copula construction. It is assumed that by using this the copula construction is not reversible e.g.,
    ///
    /// He is happy/*happy is him
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#CopulativeSubject"></see></summary>
    let CopulativeSubject =
        Namespaced_IRI.parse _namespace_name "CopulativeSubject" |> NamespacedName

    /// <summary>
    /// relation between a phrase and a verb, that represents the person or thing that performs the action or about which something is stated
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#Subject"></see></summary>
    let Subject = Namespaced_IRI.parse _namespace_name "Subject" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#Dating"></see>
    /// </summary>
    let Dating = Namespaced_IRI.parse _namespace_name "Dating" |> NamespacedName
    /// <summary>
    /// Case that expresses an indirect object relationship or a range of meaning similar to that covered by 'to' or 'for' in English; but there is a great deal of variation between languages in the way this case is used.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#dativeCase"></see></summary>
    let dativeCase = Namespaced_IRI.parse _namespace_name "dativeCase" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#DativeTransitiveFrame"></see>
    /// </summary>
    let DativeTransitiveFrame =
        Namespaced_IRI.parse _namespace_name "DativeTransitiveFrame" |> NamespacedName

    /// <summary>
    /// relation between a phrase and a verb, in which the relation is central to the verb
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#directObject"></see></summary>
    let directObject =
        Namespaced_IRI.parse _namespace_name "directObject" |> NamespacedName

    /// <summary>
    /// An indirect object is a grammatical relation that is one means of expressing the semantic role of goal and other similar roles. It is proposed for languages in which the role is distinct from the direct object and the oblique object on the basis of multiple independent syntactic or morphological criteria, such as the following: - Having a particular case marking, commonly dative - Governing an agreement affix on the verb, such as person or number - Being distinct from oblique relations in that it may be relativized
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#indirectObject"></see></summary>
    let indirectObject =
        Namespaced_IRI.parse _namespace_name "indirectObject" |> NamespacedName

    /// <summary>
    /// relation between a phrase and a verb, that represents the person or thing that performs the action or about which something is stated
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#subject"></see></summary>
    let subject = Namespaced_IRI.parse _namespace_name "subject" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#DeclarativeClause"></see>
    /// </summary>
    let DeclarativeClause =
        Namespaced_IRI.parse _namespace_name "DeclarativeClause" |> NamespacedName

    /// <summary>
    /// Declarative frames take a clause as an argument, this argument is marker with the declarative conjunction (&amp;quot;that&amp;quot; in English)
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#DeclarativeFrame"></see></summary>
    let DeclarativeFrame =
        Namespaced_IRI.parse _namespace_name "DeclarativeFrame" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#declarativeClause"></see>
    /// </summary>
    let declarativeClause =
        Namespaced_IRI.parse _namespace_name "declarativeClause" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#DeficientVerb"></see>
    /// </summary>
    let DeficientVerb =
        Namespaced_IRI.parse _namespace_name "DeficientVerb" |> NamespacedName

    /// <summary>
    /// verb lacking certain morphosyntactic properties
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#deficientVerb"></see></summary>
    let deficientVerb =
        Namespaced_IRI.parse _namespace_name "deficientVerb" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#DefiniteArticle"></see>
    /// </summary>
    let DefiniteArticle =
        Namespaced_IRI.parse _namespace_name "DefiniteArticle" |> NamespacedName

    /// <summary>
    /// Article that allows the reference to a specific, identifiable entity (or class of entities).
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#definiteArticle"></see></summary>
    let definiteArticle =
        Namespaced_IRI.parse _namespace_name "definiteArticle" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#Definiteness"></see>
    /// </summary>
    let Definiteness =
        Namespaced_IRI.parse _namespace_name "Definiteness" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#Degree"></see>
    /// </summary>
    let Degree = Namespaced_IRI.parse _namespace_name "Degree" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#DemonstrativeDeterminer"></see>
    /// </summary>
    let DemonstrativeDeterminer =
        Namespaced_IRI.parse _namespace_name "DemonstrativeDeterminer" |> NamespacedName

    /// <summary>
    /// Determiner used to point to an entity in the situation or elsewhere in a sentence.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#demonstrativeDeterminer"></see></summary>
    let demonstrativeDeterminer =
        Namespaced_IRI.parse _namespace_name "demonstrativeDeterminer" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#DemonstrativePronoun"></see>
    /// </summary>
    let DemonstrativePronoun =
        Namespaced_IRI.parse _namespace_name "DemonstrativePronoun" |> NamespacedName

    /// <summary>
    /// Pronoun used to point to an entity in the situation or elsewhere in a sentence.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#demonstrativePronoun"></see></summary>
    let demonstrativePronoun =
        Namespaced_IRI.parse _namespace_name "demonstrativePronoun" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#DiminutiveNoun"></see>
    /// </summary>
    let DiminutiveNoun =
        Namespaced_IRI.parse _namespace_name "DiminutiveNoun" |> NamespacedName

    /// <summary>
    /// diminutive noun
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#diminutiveNoun"></see></summary>
    let diminutiveNoun =
        Namespaced_IRI.parse _namespace_name "diminutiveNoun" |> NamespacedName

    /// <summary>
    /// relation between a phrase and a verb, in which the relation is central to the verb
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#DirectObject"></see></summary>
    let DirectObject =
        Namespaced_IRI.parse _namespace_name "DirectObject" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#DistinctiveParticle"></see>
    /// </summary>
    let DistinctiveParticle =
        Namespaced_IRI.parse _namespace_name "DistinctiveParticle" |> NamespacedName

    /// <summary>
    /// distinctive particle
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#distinctiveParticle"></see></summary>
    let distinctiveParticle =
        Namespaced_IRI.parse _namespace_name "distinctiveParticle" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#DitransitiveDoubleAccusativeFrame"></see>
    /// </summary>
    let DitransitiveDoubleAccusativeFrame =
        Namespaced_IRI.parse _namespace_name "DitransitiveDoubleAccusativeFrame" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#DitransitiveFrame"></see>
    /// </summary>
    let DitransitiveFrame =
        Namespaced_IRI.parse _namespace_name "DitransitiveFrame" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#DitransitiveFrame_For"></see>
    /// </summary>
    let DitransitiveFrame_For =
        Namespaced_IRI.parse _namespace_name "DitransitiveFrame_For" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#languageSpecific"></see>
    /// </summary>
    let languageSpecific =
        Namespaced_IRI.parse _namespace_name "languageSpecific" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#DitransitiveFrame_To"></see>
    /// </summary>
    let DitransitiveFrame_To =
        Namespaced_IRI.parse _namespace_name "DitransitiveFrame_To" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#EmphaticPronoun"></see>
    /// </summary>
    let EmphaticPronoun =
        Namespaced_IRI.parse _namespace_name "EmphaticPronoun" |> NamespacedName

    /// <summary>
    /// An emphatic pronoun is a personal pronoun that is used to emphasize its referent.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#emphaticPronoun"></see></summary>
    let emphaticPronoun =
        Namespaced_IRI.parse _namespace_name "emphaticPronoun" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#ExclamativeDeterminer"></see>
    /// </summary>
    let ExclamativeDeterminer =
        Namespaced_IRI.parse _namespace_name "ExclamativeDeterminer" |> NamespacedName

    /// <summary>
    /// Determiner expressing an emotional utterance and marked with a strong intonation.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#exclamativeDeterminer"></see></summary>
    let exclamativeDeterminer =
        Namespaced_IRI.parse _namespace_name "exclamativeDeterminer" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#ExclamativePoint"></see>
    /// </summary>
    let ExclamativePoint =
        Namespaced_IRI.parse _namespace_name "ExclamativePoint" |> NamespacedName

    /// <summary>
    /// Special sign (!) usually used in writing to mark exclamation.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#exclamativePoint"></see></summary>
    let exclamativePoint =
        Namespaced_IRI.parse _namespace_name "exclamativePoint" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#ExclamativePronoun"></see>
    /// </summary>
    let ExclamativePronoun =
        Namespaced_IRI.parse _namespace_name "ExclamativePronoun" |> NamespacedName

    /// <summary>
    /// Pronoun marked with an emotional utterance and/or a strong intonation.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#exclamativePronoun"></see></summary>
    let exclamativePronoun =
        Namespaced_IRI.parse _namespace_name "exclamativePronoun" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#ExistentialPronoun"></see>
    /// </summary>
    let ExistentialPronoun =
        Namespaced_IRI.parse _namespace_name "ExistentialPronoun" |> NamespacedName

    /// <summary>
    /// pronoun that indicates the existence of something or someone
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#existentialPronoun"></see></summary>
    let existentialPronoun =
        Namespaced_IRI.parse _namespace_name "existentialPronoun" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#Finiteness"></see>
    /// </summary>
    let Finiteness = Namespaced_IRI.parse _namespace_name "Finiteness" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#Frequency"></see>
    /// </summary>
    let Frequency = Namespaced_IRI.parse _namespace_name "Frequency" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#FusedPreposition"></see>
    /// </summary>
    let FusedPreposition =
        Namespaced_IRI.parse _namespace_name "FusedPreposition" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#FusedPrepositionPOS"></see>
    /// </summary>
    let FusedPrepositionPOS =
        Namespaced_IRI.parse _namespace_name "FusedPrepositionPOS" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#FusedPrepositionDeterminer"></see>
    /// </summary>
    let FusedPrepositionDeterminer =
        Namespaced_IRI.parse _namespace_name "FusedPrepositionDeterminer" |> NamespacedName

    /// <summary>
    /// word resulting from the aggregation of a proposition and a determiner
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#fusedPrepositionDeterminer"></see></summary>
    let fusedPrepositionDeterminer =
        Namespaced_IRI.parse _namespace_name "fusedPrepositionDeterminer" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#FusedPrepositionPronoun"></see>
    /// </summary>
    let FusedPrepositionPronoun =
        Namespaced_IRI.parse _namespace_name "FusedPrepositionPronoun" |> NamespacedName

    /// <summary>
    /// word resulting from the aggregation of a preposition and a pronoun
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#fusedPrepositionPronoun"></see></summary>
    let fusedPrepositionPronoun =
        Namespaced_IRI.parse _namespace_name "fusedPrepositionPronoun" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#FusedPronounAuxiliary"></see>
    /// </summary>
    let FusedPronounAuxiliary =
        Namespaced_IRI.parse _namespace_name "FusedPronounAuxiliary" |> NamespacedName

    /// <summary>
    /// word resulting from the aggregation of a pronoun and an auxiliary
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#fusedPronounAuxiliary"></see></summary>
    let fusedPronounAuxiliary =
        Namespaced_IRI.parse _namespace_name "fusedPronounAuxiliary" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#FutureParticle"></see>
    /// </summary>
    let FutureParticle =
        Namespaced_IRI.parse _namespace_name "FutureParticle" |> NamespacedName

    /// <summary>
    /// Particle used in order to express future.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#futureParticle"></see></summary>
    let futureParticle =
        Namespaced_IRI.parse _namespace_name "futureParticle" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#Gender"></see>
    /// </summary>
    let Gender = Namespaced_IRI.parse _namespace_name "Gender" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#GeneralAdverb"></see>
    /// </summary>
    let GeneralAdverb =
        Namespaced_IRI.parse _namespace_name "GeneralAdverb" |> NamespacedName

    /// <summary>
    /// Adverb belonging to the general class of adverbs
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#generalAdverb"></see></summary>
    let generalAdverb =
        Namespaced_IRI.parse _namespace_name "generalAdverb" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#GeneralizationWord"></see>
    /// </summary>
    let GeneralizationWord =
        Namespaced_IRI.parse _namespace_name "GeneralizationWord" |> NamespacedName

    /// <summary>
    /// A word that does not carry its own meaning but generalizes the meaning of a neighboring word, adding the &amp;quot;etc.&amp;quot; sense.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#generalizationWord"></see></summary>
    let generalizationWord =
        Namespaced_IRI.parse _namespace_name "generalizationWord" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#GenericNumeral"></see>
    /// </summary>
    let GenericNumeral =
        Namespaced_IRI.parse _namespace_name "GenericNumeral" |> NamespacedName

    /// <summary>
    /// A numeral used to indicate the number of sets/kinds of objects.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#genericNumeral"></see></summary>
    let genericNumeral =
        Namespaced_IRI.parse _namespace_name "genericNumeral" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#GenitiveDitransitiveFrame"></see>
    /// </summary>
    let GenitiveDitransitiveFrame =
        Namespaced_IRI.parse _namespace_name "GenitiveDitransitiveFrame" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#genitiveObject"></see>
    /// </summary>
    let genitiveObject =
        Namespaced_IRI.parse _namespace_name "genitiveObject" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#GenitiveObject"></see>
    /// </summary>
    let GenitiveObject =
        Namespaced_IRI.parse _namespace_name "GenitiveObject" |> NamespacedName

    /// <summary>
    /// Case which expresses a possessive relationship (e.g. the boy's book) or some other similarly close connection (e.g. a summer's day).
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#genitiveCase"></see></summary>
    let genitiveCase =
        Namespaced_IRI.parse _namespace_name "genitiveCase" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#GenitiveTransitiveFrame"></see>
    /// </summary>
    let GenitiveTransitiveFrame =
        Namespaced_IRI.parse _namespace_name "GenitiveTransitiveFrame" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#GerundACFrame"></see>
    /// </summary>
    let GerundACFrame =
        Namespaced_IRI.parse _namespace_name "GerundACFrame" |> NamespacedName

    /// <summary>
    /// Indicates one of the arguments is a gerund clause
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#GerundFrame"></see></summary>
    let GerundFrame =
        Namespaced_IRI.parse _namespace_name "GerundFrame" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#GerundClause"></see>
    /// </summary>
    let GerundClause =
        Namespaced_IRI.parse _namespace_name "GerundClause" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#GerundOCFrame"></see>
    /// </summary>
    let GerundOCFrame =
        Namespaced_IRI.parse _namespace_name "GerundOCFrame" |> NamespacedName

    /// <summary>
    /// Indicates the object of the main clause is also the (omitted) object of the subclause
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#ObjectControl"></see></summary>
    let ObjectControl =
        Namespaced_IRI.parse _namespace_name "ObjectControl" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#GerundSCFrame"></see>
    /// </summary>
    let GerundSCFrame =
        Namespaced_IRI.parse _namespace_name "GerundSCFrame" |> NamespacedName

    /// <summary>
    /// Indicates the subject of the main clause is the (omitted) subject of the subclause
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#SubjectControl"></see></summary>
    let SubjectControl =
        Namespaced_IRI.parse _namespace_name "SubjectControl" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#ImpersonalFrame"></see>
    /// </summary>
    let ImpersonalFrame =
        Namespaced_IRI.parse _namespace_name "ImpersonalFrame" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#ImpersonalIntransitiveFrame"></see>
    /// </summary>
    let ImpersonalIntransitiveFrame =
        Namespaced_IRI.parse _namespace_name "ImpersonalIntransitiveFrame" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#ImpersonalIntransitivePPFrame"></see>
    /// </summary>
    let ImpersonalIntransitivePPFrame =
        Namespaced_IRI.parse _namespace_name "ImpersonalIntransitivePPFrame" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#ImpersonalPronoun"></see>
    /// </summary>
    let ImpersonalPronoun =
        Namespaced_IRI.parse _namespace_name "ImpersonalPronoun" |> NamespacedName

    /// <summary>
    /// Pronoun lacking person referent.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#impersonalPronoun"></see></summary>
    let impersonalPronoun =
        Namespaced_IRI.parse _namespace_name "impersonalPronoun" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#ImpersonalTransitiveFrame"></see>
    /// </summary>
    let ImpersonalTransitiveFrame =
        Namespaced_IRI.parse _namespace_name "ImpersonalTransitiveFrame" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#IndefiniteArticle"></see>
    /// </summary>
    let IndefiniteArticle =
        Namespaced_IRI.parse _namespace_name "IndefiniteArticle" |> NamespacedName

    /// <summary>
    /// Article not capable of expressing identification.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#indefiniteArticle"></see></summary>
    let indefiniteArticle =
        Namespaced_IRI.parse _namespace_name "indefiniteArticle" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#IndefiniteCardinalNumeral"></see>
    /// </summary>
    let IndefiniteCardinalNumeral =
        Namespaced_IRI.parse _namespace_name "IndefiniteCardinalNumeral" |> NamespacedName

    /// <summary>
    /// A word used to express imprecise quantity.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#indefiniteCardinalNumeral"></see></summary>
    let indefiniteCardinalNumeral =
        Namespaced_IRI.parse _namespace_name "indefiniteCardinalNumeral" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#IndefiniteDeterminer"></see>
    /// </summary>
    let IndefiniteDeterminer =
        Namespaced_IRI.parse _namespace_name "IndefiniteDeterminer" |> NamespacedName

    /// <summary>
    /// Determiner not capable of identification.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#indefiniteDeterminer"></see></summary>
    let indefiniteDeterminer =
        Namespaced_IRI.parse _namespace_name "indefiniteDeterminer" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#IndefiniteMultiplicativeNumeral"></see>
    /// </summary>
    let IndefiniteMultiplicativeNumeral =
        Namespaced_IRI.parse _namespace_name "IndefiniteMultiplicativeNumeral" |> NamespacedName

    /// <summary>
    /// A word indicating imprecise number of times something happened.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#indefiniteMultiplicativeNumeral"></see></summary>
    let indefiniteMultiplicativeNumeral =
        Namespaced_IRI.parse _namespace_name "indefiniteMultiplicativeNumeral" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#IndefiniteOrdinalNumeral"></see>
    /// </summary>
    let IndefiniteOrdinalNumeral =
        Namespaced_IRI.parse _namespace_name "IndefiniteOrdinalNumeral" |> NamespacedName

    /// <summary>
    /// A word used to indicate imprecise rank of an object in a sequence.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#indefiniteOrdinalNumeral"></see></summary>
    let indefiniteOrdinalNumeral =
        Namespaced_IRI.parse _namespace_name "indefiniteOrdinalNumeral" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#IndefinitePronoun"></see>
    /// </summary>
    let IndefinitePronoun =
        Namespaced_IRI.parse _namespace_name "IndefinitePronoun" |> NamespacedName

    /// <summary>
    /// Pronoun that does not allow reference.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#indefinitePronoun"></see></summary>
    let indefinitePronoun =
        Namespaced_IRI.parse _namespace_name "indefinitePronoun" |> NamespacedName

    /// <summary>
    /// An indirect object is a grammatical relation that is one means of expressing the semantic role of goal and other similar roles. It is proposed for languages in which the role is distinct from the direct object and the oblique object on the basis of multiple independent syntactic or morphological criteria, such as the following: - Having a particular case marking, commonly dative - Governing an agreement affix on the verb, such as person or number - Being distinct from oblique relations in that it may be relativized
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#IndirectObject"></see></summary>
    let IndirectObject =
        Namespaced_IRI.parse _namespace_name "IndirectObject" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#InfinitiveClause"></see>
    /// </summary>
    let InfinitiveClause =
        Namespaced_IRI.parse _namespace_name "InfinitiveClause" |> NamespacedName

    /// <summary>
    /// Infinitive frames take an infinitive clause as an argument
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#InfinitiveFrame"></see></summary>
    let InfinitiveFrame =
        Namespaced_IRI.parse _namespace_name "InfinitiveFrame" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#infinitiveClause"></see>
    /// </summary>
    let infinitiveClause =
        Namespaced_IRI.parse _namespace_name "infinitiveClause" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#InfinitiveParticle"></see>
    /// </summary>
    let InfinitiveParticle =
        Namespaced_IRI.parse _namespace_name "InfinitiveParticle" |> NamespacedName

    /// <summary>
    /// Particle used to express infinitive.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#infinitiveParticle"></see></summary>
    let infinitiveParticle =
        Namespaced_IRI.parse _namespace_name "infinitiveParticle" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#Infix"></see>
    /// </summary>
    let Infix = Namespaced_IRI.parse _namespace_name "Infix" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#Interjection"></see>
    /// </summary>
    let Interjection =
        Namespaced_IRI.parse _namespace_name "Interjection" |> NamespacedName

    /// <summary>
    /// Word or sound that expresses an emotion.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#interjection"></see></summary>
    let interjection =
        Namespaced_IRI.parse _namespace_name "interjection" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#InterrogativeCardinalNumeral"></see>
    /// </summary>
    let InterrogativeCardinalNumeral =
        Namespaced_IRI.parse _namespace_name "InterrogativeCardinalNumeral" |> NamespacedName

    /// <summary>
    /// An interrogative/relative word used to ask about quantity.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#interrogativeCardinalNumeral"></see></summary>
    let interrogativeCardinalNumeral =
        Namespaced_IRI.parse _namespace_name "interrogativeCardinalNumeral" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#InterrogativeClause"></see>
    /// </summary>
    let InterrogativeClause =
        Namespaced_IRI.parse _namespace_name "InterrogativeClause" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#InterrogativeDeterminer"></see>
    /// </summary>
    let InterrogativeDeterminer =
        Namespaced_IRI.parse _namespace_name "InterrogativeDeterminer" |> NamespacedName

    /// <summary>
    /// Determiner used to express a question.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#interrogativeDeterminer"></see></summary>
    let interrogativeDeterminer =
        Namespaced_IRI.parse _namespace_name "interrogativeDeterminer" |> NamespacedName

    /// <summary>
    /// Indicates the frame has a subframe indicated with the appropriate interrogative (e.g., &amp;quot;who&amp;quot;, &amp;quot;where&amp;quot;, &amp;quot;how&amp;quot;)
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#InterrogativeFrame"></see></summary>
    let InterrogativeFrame =
        Namespaced_IRI.parse _namespace_name "InterrogativeFrame" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#interrogativeClause"></see>
    /// </summary>
    let interrogativeClause =
        Namespaced_IRI.parse _namespace_name "interrogativeClause" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#InterrogativeInfinitiveClause"></see>
    /// </summary>
    let InterrogativeInfinitiveClause =
        Namespaced_IRI.parse _namespace_name "InterrogativeInfinitiveClause" |> NamespacedName

    /// <summary>
    /// Indicates the frame has an argument that is a clause with both an interrogative and the clause is in the infinitive form
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#InterrogativeInfinitiveFrame"></see></summary>
    let InterrogativeInfinitiveFrame =
        Namespaced_IRI.parse _namespace_name "InterrogativeInfinitiveFrame" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#interrogativeInfinitiveClause"></see>
    /// </summary>
    let interrogativeInfinitiveClause =
        Namespaced_IRI.parse _namespace_name "interrogativeInfinitiveClause" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#InterrogativeMultiplicativeNumeral"></see>
    /// </summary>
    let InterrogativeMultiplicativeNumeral =
        Namespaced_IRI.parse _namespace_name "InterrogativeMultiplicativeNumeral" |> NamespacedName

    /// <summary>
    /// An interrogative/relative word used to ask about the number of times something happened.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#interrogativeMultiplicativeNumeral"></see></summary>
    let interrogativeMultiplicativeNumeral =
        Namespaced_IRI.parse _namespace_name "interrogativeMultiplicativeNumeral" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#InterrogativeOrdinalNumeral"></see>
    /// </summary>
    let InterrogativeOrdinalNumeral =
        Namespaced_IRI.parse _namespace_name "InterrogativeOrdinalNumeral" |> NamespacedName

    /// <summary>
    /// An interrogative/relative word used to ask about numeric ranking.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#interrogativeOrdinalNumeral"></see></summary>
    let interrogativeOrdinalNumeral =
        Namespaced_IRI.parse _namespace_name "interrogativeOrdinalNumeral" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#InterrogativeParticle"></see>
    /// </summary>
    let InterrogativeParticle =
        Namespaced_IRI.parse _namespace_name "InterrogativeParticle" |> NamespacedName

    /// <summary>
    /// Particle used to express a question.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#interrogativeParticle"></see></summary>
    let interrogativeParticle =
        Namespaced_IRI.parse _namespace_name "interrogativeParticle" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#InterrogativePronoun"></see>
    /// </summary>
    let InterrogativePronoun =
        Namespaced_IRI.parse _namespace_name "InterrogativePronoun" |> NamespacedName

    /// <summary>
    /// Pronoun used to express a question.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#interrogativePronoun"></see></summary>
    let interrogativePronoun =
        Namespaced_IRI.parse _namespace_name "interrogativePronoun" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#InterrogativeRelativePronoun"></see>
    /// </summary>
    let InterrogativeRelativePronoun =
        Namespaced_IRI.parse _namespace_name "InterrogativeRelativePronoun" |> NamespacedName

    /// <summary>
    /// pronoun which may act as a relative pronoun or an interrogative one
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#interrogativeRelativePronoun"></see></summary>
    let interrogativeRelativePronoun =
        Namespaced_IRI.parse _namespace_name "interrogativeRelativePronoun" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#IntransitiveAdjectivalComplementFrame"></see>
    /// </summary>
    let IntransitiveAdjectivalComplementFrame =
        Namespaced_IRI.parse _namespace_name "IntransitiveAdjectivalComplementFrame" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#IntransitiveFrame"></see>
    /// </summary>
    let IntransitiveFrame =
        Namespaced_IRI.parse _namespace_name "IntransitiveFrame" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#IntransitiveAdverbialComplementFrame"></see>
    /// </summary>
    let IntransitiveAdverbialComplementFrame =
        Namespaced_IRI.parse _namespace_name "IntransitiveAdverbialComplementFrame" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#IntransitiveDeclarativeFrame"></see>
    /// </summary>
    let IntransitiveDeclarativeFrame =
        Namespaced_IRI.parse _namespace_name "IntransitiveDeclarativeFrame" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#IntransitiveInfinitiveACFrame"></see>
    /// </summary>
    let IntransitiveInfinitiveACFrame =
        Namespaced_IRI.parse _namespace_name "IntransitiveInfinitiveACFrame" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#IntransitiveInfinitiveRSFrame"></see>
    /// </summary>
    let IntransitiveInfinitiveRSFrame =
        Namespaced_IRI.parse _namespace_name "IntransitiveInfinitiveRSFrame" |> NamespacedName

    /// <summary>
    /// Indicates the syntactic subject of the main clause is in fact the subject of the subclause. The main clause should then be interpreted as being impersonal.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#RaisingSubject"></see></summary>
    let RaisingSubject =
        Namespaced_IRI.parse _namespace_name "RaisingSubject" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#IntransitiveInfinitiveSCFrame"></see>
    /// </summary>
    let IntransitiveInfinitiveSCFrame =
        Namespaced_IRI.parse _namespace_name "IntransitiveInfinitiveSCFrame" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#IntransitiveInterrogativeFrame"></see>
    /// </summary>
    let IntransitiveInterrogativeFrame =
        Namespaced_IRI.parse _namespace_name "IntransitiveInterrogativeFrame" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#IntransitiveInterrogativeInfinitiveFrame"></see>
    /// </summary>
    let IntransitiveInterrogativeInfinitiveFrame =
        Namespaced_IRI.parse _namespace_name "IntransitiveInterrogativeInfinitiveFrame" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#IntransitiveNominalComplementFrame"></see>
    /// </summary>
    let IntransitiveNominalComplementFrame =
        Namespaced_IRI.parse _namespace_name "IntransitiveNominalComplementFrame" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#predicativeNominative"></see>
    /// </summary>
    let predicativeNominative =
        Namespaced_IRI.parse _namespace_name "predicativeNominative" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#IntransitivePPDeclarativeFrame"></see>
    /// </summary>
    let IntransitivePPDeclarativeFrame =
        Namespaced_IRI.parse _namespace_name "IntransitivePPDeclarativeFrame" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#IntransitivePPFrame"></see>
    /// </summary>
    let IntransitivePPFrame =
        Namespaced_IRI.parse _namespace_name "IntransitivePPFrame" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#PPFrame"></see>
    /// </summary>
    let PPFrame = Namespaced_IRI.parse _namespace_name "PPFrame" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#IntransitiveSententialFrame"></see>
    /// </summary>
    let IntransitiveSententialFrame =
        Namespaced_IRI.parse _namespace_name "IntransitiveSententialFrame" |> NamespacedName

    /// <summary>
    /// Sentential frames take a clause as argument, no conjunction is used and the syntax of the clause is the same as a main clause
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#SententialFrame"></see></summary>
    let SententialFrame =
        Namespaced_IRI.parse _namespace_name "SententialFrame" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#InvertedComma"></see>
    /// </summary>
    let InvertedComma =
        Namespaced_IRI.parse _namespace_name "InvertedComma" |> NamespacedName

    /// <summary>
    /// Inverted comma.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#invertedComma"></see></summary>
    let invertedComma =
        Namespaced_IRI.parse _namespace_name "invertedComma" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#IrreflexivePersonalPronoun"></see>
    /// </summary>
    let IrreflexivePersonalPronoun =
        Namespaced_IRI.parse _namespace_name "IrreflexivePersonalPronoun" |> NamespacedName

    /// <summary>
    /// personal pronoun which is not reflexive
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#irreflexivePersonalPronoun"></see></summary>
    let irreflexivePersonalPronoun =
        Namespaced_IRI.parse _namespace_name "irreflexivePersonalPronoun" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#Letter"></see>
    /// </summary>
    let Letter = Namespaced_IRI.parse _namespace_name "Letter" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#letter"></see>
    /// </summary>
    let letter = Namespaced_IRI.parse _namespace_name "letter" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#LightVerb"></see>
    /// </summary>
    let LightVerb = Namespaced_IRI.parse _namespace_name "LightVerb" |> NamespacedName
    /// <summary>
    /// verb participating in a complex predication that has little semantic content of its own.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#lightVerb"></see></summary>
    let lightVerb = Namespaced_IRI.parse _namespace_name "lightVerb" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#MainVerb"></see>
    /// </summary>
    let MainVerb = Namespaced_IRI.parse _namespace_name "MainVerb" |> NamespacedName
    /// <summary>
    /// Main verb in contrast to a modal or an auxiliary.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#mainVerb"></see></summary>
    let mainVerb = Namespaced_IRI.parse _namespace_name "mainVerb" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#Modal"></see>
    /// </summary>
    let Modal = Namespaced_IRI.parse _namespace_name "Modal" |> NamespacedName
    /// <summary>
    /// Verb form that is usually used with another verb to express ideas such as possibilities, permission, or intention.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#modal"></see></summary>
    let modal = Namespaced_IRI.parse _namespace_name "modal" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#ModificationType"></see>
    /// </summary>
    let ModificationType =
        Namespaced_IRI.parse _namespace_name "ModificationType" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#Mood"></see>
    /// </summary>
    let Mood = Namespaced_IRI.parse _namespace_name "Mood" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#MultiplicativeNumeral"></see>
    /// </summary>
    let MultiplicativeNumeral =
        Namespaced_IRI.parse _namespace_name "MultiplicativeNumeral" |> NamespacedName

    /// <summary>
    /// A word that expresses the number of times something happened.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#multiplicativeNumeral"></see></summary>
    let multiplicativeNumeral =
        Namespaced_IRI.parse _namespace_name "multiplicativeNumeral" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#Negative"></see>
    /// </summary>
    let Negative = Namespaced_IRI.parse _namespace_name "Negative" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#NegativeParticle"></see>
    /// </summary>
    let NegativeParticle =
        Namespaced_IRI.parse _namespace_name "NegativeParticle" |> NamespacedName

    /// <summary>
    /// Particle used to express negation.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#negativeParticle"></see></summary>
    let negativeParticle =
        Namespaced_IRI.parse _namespace_name "negativeParticle" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#NegativePronoun"></see>
    /// </summary>
    let NegativePronoun =
        Namespaced_IRI.parse _namespace_name "NegativePronoun" |> NamespacedName

    /// <summary>
    /// Pronoun used in a context of a negation or for expressing a negation.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#negativePronoun"></see></summary>
    let negativePronoun =
        Namespaced_IRI.parse _namespace_name "negativePronoun" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#NominalComplementFrame"></see>
    /// </summary>
    let NominalComplementFrame =
        Namespaced_IRI.parse _namespace_name "NominalComplementFrame" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#NormativeAuthorization"></see>
    /// </summary>
    let NormativeAuthorization =
        Namespaced_IRI.parse _namespace_name "NormativeAuthorization" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#NounPOS"></see>
    /// </summary>
    let NounPOS = Namespaced_IRI.parse _namespace_name "NounPOS" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#NounFrame"></see>
    /// </summary>
    let NounFrame = Namespaced_IRI.parse _namespace_name "NounFrame" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#NounPPFrame"></see>
    /// </summary>
    let NounPPFrame =
        Namespaced_IRI.parse _namespace_name "NounPPFrame" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#NounPredicateFrame"></see>
    /// </summary>
    let NounPredicateFrame =
        Namespaced_IRI.parse _namespace_name "NounPredicateFrame" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#NounPhrase"></see>
    /// </summary>
    let NounPhrase = Namespaced_IRI.parse _namespace_name "NounPhrase" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#NounPossessiveFrame"></see>
    /// </summary>
    let NounPossessiveFrame =
        Namespaced_IRI.parse _namespace_name "NounPossessiveFrame" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#PossessiveAdjunct"></see>
    /// </summary>
    let PossessiveAdjunct =
        Namespaced_IRI.parse _namespace_name "PossessiveAdjunct" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#possessiveAdjunct"></see>
    /// </summary>
    let possessiveAdjunct =
        Namespaced_IRI.parse _namespace_name "possessiveAdjunct" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#Number"></see>
    /// </summary>
    let Number = Namespaced_IRI.parse _namespace_name "Number" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#NumeralPOS"></see>
    /// </summary>
    let NumeralPOS = Namespaced_IRI.parse _namespace_name "NumeralPOS" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#NumeralFraction"></see>
    /// </summary>
    let NumeralFraction =
        Namespaced_IRI.parse _namespace_name "NumeralFraction" |> NamespacedName

    /// <summary>
    /// Word used to denote the denominator of a fraction.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#numeralFraction"></see></summary>
    let numeralFraction =
        Namespaced_IRI.parse _namespace_name "numeralFraction" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#ObjectComplement"></see>
    /// </summary>
    let ObjectComplement =
        Namespaced_IRI.parse _namespace_name "ObjectComplement" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#OpenParenthesis"></see>
    /// </summary>
    let OpenParenthesis =
        Namespaced_IRI.parse _namespace_name "OpenParenthesis" |> NamespacedName

    /// <summary>
    /// Beginning of a pair of parenthesis.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#openParenthesis"></see></summary>
    let openParenthesis =
        Namespaced_IRI.parse _namespace_name "openParenthesis" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#OrdinalAdjective"></see>
    /// </summary>
    let OrdinalAdjective =
        Namespaced_IRI.parse _namespace_name "OrdinalAdjective" |> NamespacedName

    /// <summary>
    /// Adjective/numeral/number expressing a numeric ranking.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#ordinalAdjective"></see></summary>
    let ordinalAdjective =
        Namespaced_IRI.parse _namespace_name "ordinalAdjective" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#ParticipleAdjective"></see>
    /// </summary>
    let ParticipleAdjective =
        Namespaced_IRI.parse _namespace_name "ParticipleAdjective" |> NamespacedName

    /// <summary>
    /// Adjective based on a verb.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#participleAdjective"></see></summary>
    let participleAdjective =
        Namespaced_IRI.parse _namespace_name "participleAdjective" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#ParticlePOS"></see>
    /// </summary>
    let ParticlePOS =
        Namespaced_IRI.parse _namespace_name "ParticlePOS" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#PartitiveArticle"></see>
    /// </summary>
    let PartitiveArticle =
        Namespaced_IRI.parse _namespace_name "PartitiveArticle" |> NamespacedName

    /// <summary>
    /// Article expressing a part or quantity.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#partitiveArticle"></see></summary>
    let partitiveArticle =
        Namespaced_IRI.parse _namespace_name "partitiveArticle" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#PastParticipleAdjective"></see>
    /// </summary>
    let PastParticipleAdjective =
        Namespaced_IRI.parse _namespace_name "PastParticipleAdjective" |> NamespacedName

    /// <summary>
    /// Adjective based on a past participle.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#pastParticipleAdjective"></see></summary>
    let pastParticipleAdjective =
        Namespaced_IRI.parse _namespace_name "pastParticipleAdjective" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#Person"></see>
    /// </summary>
    let Person = Namespaced_IRI.parse _namespace_name "Person" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#PersonalPronoun"></see>
    /// </summary>
    let PersonalPronoun =
        Namespaced_IRI.parse _namespace_name "PersonalPronoun" |> NamespacedName

    /// <summary>
    /// Pronoun referring a person.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#personalPronoun"></see></summary>
    let personalPronoun =
        Namespaced_IRI.parse _namespace_name "personalPronoun" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#PlainVerb"></see>
    /// </summary>
    let PlainVerb = Namespaced_IRI.parse _namespace_name "PlainVerb" |> NamespacedName
    /// <summary>
    /// verb which has its own semantics
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#plainVerb"></see></summary>
    let plainVerb = Namespaced_IRI.parse _namespace_name "plainVerb" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#Point"></see>
    /// </summary>
    let Point = Namespaced_IRI.parse _namespace_name "Point" |> NamespacedName
    /// <summary>
    /// Sign (.) used to expresses the end of a sentence or an abbreviation.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#point"></see></summary>
    let point = Namespaced_IRI.parse _namespace_name "point" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#PossessiveAdjective"></see>
    /// </summary>
    let PossessiveAdjective =
        Namespaced_IRI.parse _namespace_name "PossessiveAdjective" |> NamespacedName

    /// <summary>
    /// An adjective derived from a noun and denoting possession by the object described by the noun.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#possessiveAdjective"></see></summary>
    let possessiveAdjective =
        Namespaced_IRI.parse _namespace_name "possessiveAdjective" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#PossessiveDeterminer"></see>
    /// </summary>
    let PossessiveDeterminer =
        Namespaced_IRI.parse _namespace_name "PossessiveDeterminer" |> NamespacedName

    /// <summary>
    /// Determiner that expresses ownership.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#possessiveDeterminer"></see></summary>
    let possessiveDeterminer =
        Namespaced_IRI.parse _namespace_name "possessiveDeterminer" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#PossessiveInfinitiveClause"></see>
    /// </summary>
    let PossessiveInfinitiveClause =
        Namespaced_IRI.parse _namespace_name "PossessiveInfinitiveClause" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#PossessiveParticle"></see>
    /// </summary>
    let PossessiveParticle =
        Namespaced_IRI.parse _namespace_name "PossessiveParticle" |> NamespacedName

    /// <summary>
    /// Particle expressing ownship.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#possessiveParticle"></see></summary>
    let possessiveParticle =
        Namespaced_IRI.parse _namespace_name "possessiveParticle" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#PossessivePronoun"></see>
    /// </summary>
    let PossessivePronoun =
        Namespaced_IRI.parse _namespace_name "PossessivePronoun" |> NamespacedName

    /// <summary>
    /// Pronoun that expresses ownership and relationships like ownership, such as kinship, and other forms of association.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#possessivePronoun"></see></summary>
    let possessivePronoun =
        Namespaced_IRI.parse _namespace_name "possessivePronoun" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#PossessiveRelativePronoun"></see>
    /// </summary>
    let PossessiveRelativePronoun =
        Namespaced_IRI.parse _namespace_name "PossessiveRelativePronoun" |> NamespacedName

    /// <summary>
    /// A relative pronoun whose antecedent is the possessor of the subject or object in the relative clause.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#possessiveRelativePronoun"></see></summary>
    let possessiveRelativePronoun =
        Namespaced_IRI.parse _namespace_name "possessiveRelativePronoun" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#Postposition"></see>
    /// </summary>
    let Postposition =
        Namespaced_IRI.parse _namespace_name "Postposition" |> NamespacedName

    /// <summary>
    /// Adposition that appears at the end of the noun phrase.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#postposition"></see></summary>
    let postposition =
        Namespaced_IRI.parse _namespace_name "postposition" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#PredicativeAdjective"></see>
    /// </summary>
    let PredicativeAdjective =
        Namespaced_IRI.parse _namespace_name "PredicativeAdjective" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#PredicativeAdverb"></see>
    /// </summary>
    let PredicativeAdverb =
        Namespaced_IRI.parse _namespace_name "PredicativeAdverb" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#PredicativeNominative"></see>
    /// </summary>
    let PredicativeNominative =
        Namespaced_IRI.parse _namespace_name "PredicativeNominative" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#Prefix"></see>
    /// </summary>
    let Prefix = Namespaced_IRI.parse _namespace_name "Prefix" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#Preposition"></see>
    /// </summary>
    let Preposition =
        Namespaced_IRI.parse _namespace_name "Preposition" |> NamespacedName

    /// <summary>
    /// Adposition placed at the beginning of a noun phrase.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#preposition"></see></summary>
    let preposition =
        Namespaced_IRI.parse _namespace_name "preposition" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#PrepositionFrame"></see>
    /// </summary>
    let PrepositionFrame =
        Namespaced_IRI.parse _namespace_name "PrepositionFrame" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#PrepositionPhrase"></see>
    /// </summary>
    let PrepositionPhrase =
        Namespaced_IRI.parse _namespace_name "PrepositionPhrase" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#PrepositionalAdjunct"></see>
    /// </summary>
    let PrepositionalAdjunct =
        Namespaced_IRI.parse _namespace_name "PrepositionalAdjunct" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#PrepositionalAdverb"></see>
    /// </summary>
    let PrepositionalAdverb =
        Namespaced_IRI.parse _namespace_name "PrepositionalAdverb" |> NamespacedName

    /// <summary>
    /// adverb which is very similar in its form to a preposition
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#prepositionalAdverb"></see></summary>
    let prepositionalAdverb =
        Namespaced_IRI.parse _namespace_name "prepositionalAdverb" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#prepositionalAdjunct"></see>
    /// </summary>
    let prepositionalAdjunct =
        Namespaced_IRI.parse _namespace_name "prepositionalAdjunct" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#PrepositionalGerundClause"></see>
    /// </summary>
    let PrepositionalGerundClause =
        Namespaced_IRI.parse _namespace_name "PrepositionalGerundClause" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#PrepositionalInterrogativeClause"></see>
    /// </summary>
    let PrepositionalInterrogativeClause =
        Namespaced_IRI.parse _namespace_name "PrepositionalInterrogativeClause" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#PrepositionalInterrogativeFrame"></see>
    /// </summary>
    let PrepositionalInterrogativeFrame =
        Namespaced_IRI.parse _namespace_name "PrepositionalInterrogativeFrame" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#prepositionalInterrogativeClause"></see>
    /// </summary>
    let prepositionalInterrogativeClause =
        Namespaced_IRI.parse _namespace_name "prepositionalInterrogativeClause" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#PrepositionalObject"></see>
    /// </summary>
    let PrepositionalObject =
        Namespaced_IRI.parse _namespace_name "PrepositionalObject" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#PrepositionalPhraseFrame"></see>
    /// </summary>
    let PrepositionalPhraseFrame =
        Namespaced_IRI.parse _namespace_name "PrepositionalPhraseFrame" |> NamespacedName

    /// <summary>
    /// A noun phrase that follows a copula or similar verb, as for example an idiot in the sentence He is an idiot. - A clause that serves as the subject or direct object of a verb or the direct object of a preposition, as for example that he would be early in the sentence I hoped that he would be early
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#complement"></see></summary>
    let complement = Namespaced_IRI.parse _namespace_name "complement" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#PresentParticipleAdjective"></see>
    /// </summary>
    let PresentParticipleAdjective =
        Namespaced_IRI.parse _namespace_name "PresentParticipleAdjective" |> NamespacedName

    /// <summary>
    /// Adjective based on a present participle.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#presentParticipleAdjective"></see></summary>
    let presentParticipleAdjective =
        Namespaced_IRI.parse _namespace_name "presentParticipleAdjective" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#PresentativePronoun"></see>
    /// </summary>
    let PresentativePronoun =
        Namespaced_IRI.parse _namespace_name "PresentativePronoun" |> NamespacedName

    /// <summary>
    /// pronoun that identify the current locative or temporal situation
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#presentativePronoun"></see></summary>
    let presentativePronoun =
        Namespaced_IRI.parse _namespace_name "presentativePronoun" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#PronominalAdverb"></see>
    /// </summary>
    let PronominalAdverb =
        Namespaced_IRI.parse _namespace_name "PronominalAdverb" |> NamespacedName

    /// <summary>
    /// adverb formed in replacement of a preposition and a pronoun
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#pronominalAdverb"></see></summary>
    let pronominalAdverb =
        Namespaced_IRI.parse _namespace_name "pronominalAdverb" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#PronounPOS"></see>
    /// </summary>
    let PronounPOS = Namespaced_IRI.parse _namespace_name "PronounPOS" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#ProperNoun"></see>
    /// </summary>
    let ProperNoun = Namespaced_IRI.parse _namespace_name "ProperNoun" |> NamespacedName
    /// <summary>
    /// A noun or adjective denoting a single object. // Noun that is the name of a specific individual, place, or object.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#properNoun"></see></summary>
    let properNoun = Namespaced_IRI.parse _namespace_name "properNoun" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#Punctuation"></see>
    /// </summary>
    let Punctuation =
        Namespaced_IRI.parse _namespace_name "Punctuation" |> NamespacedName

    /// <summary>
    /// Graphical mark used either at word level to indicate an abbreviation or at a text level to separate phrases or sentences.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#punctuation"></see></summary>
    let punctuation =
        Namespaced_IRI.parse _namespace_name "punctuation" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#QualifierAdjective"></see>
    /// </summary>
    let QualifierAdjective =
        Namespaced_IRI.parse _namespace_name "QualifierAdjective" |> NamespacedName

    /// <summary>
    /// Adjective used to qualify.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#qualifierAdjective"></see></summary>
    let qualifierAdjective =
        Namespaced_IRI.parse _namespace_name "qualifierAdjective" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#QuestionMark"></see>
    /// </summary>
    let QuestionMark =
        Namespaced_IRI.parse _namespace_name "QuestionMark" |> NamespacedName

    /// <summary>
    /// Sign used to express a question.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#questionMark"></see></summary>
    let questionMark =
        Namespaced_IRI.parse _namespace_name "questionMark" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#RaisableArgument"></see>
    /// </summary>
    let RaisableArgument =
        Namespaced_IRI.parse _namespace_name "RaisableArgument" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#RaisableSubject"></see>
    /// </summary>
    let RaisableSubject =
        Namespaced_IRI.parse _namespace_name "RaisableSubject" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#ReciprocalFrame"></see>
    /// </summary>
    let ReciprocalFrame =
        Namespaced_IRI.parse _namespace_name "ReciprocalFrame" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#ReciprocalPronoun"></see>
    /// </summary>
    let ReciprocalPronoun =
        Namespaced_IRI.parse _namespace_name "ReciprocalPronoun" |> NamespacedName

    /// <summary>
    /// Pronoun expressing mutual relationship.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#reciprocalPronoun"></see></summary>
    let reciprocalPronoun =
        Namespaced_IRI.parse _namespace_name "reciprocalPronoun" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#ReferentType"></see>
    /// </summary>
    let ReferentType =
        Namespaced_IRI.parse _namespace_name "ReferentType" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#ReflexiveDativeTransitiveFrame"></see>
    /// </summary>
    let ReflexiveDativeTransitiveFrame =
        Namespaced_IRI.parse _namespace_name "ReflexiveDativeTransitiveFrame" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#ReflexiveFrame"></see>
    /// </summary>
    let ReflexiveFrame =
        Namespaced_IRI.parse _namespace_name "ReflexiveFrame" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#ReflexiveDeterminer"></see>
    /// </summary>
    let ReflexiveDeterminer =
        Namespaced_IRI.parse _namespace_name "ReflexiveDeterminer" |> NamespacedName

    /// <summary>
    /// Determiner that refers to the same entity.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#reflexiveDeterminer"></see></summary>
    let reflexiveDeterminer =
        Namespaced_IRI.parse _namespace_name "reflexiveDeterminer" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#ReflexiveDitransitiveFrame"></see>
    /// </summary>
    let ReflexiveDitransitiveFrame =
        Namespaced_IRI.parse _namespace_name "ReflexiveDitransitiveFrame" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#ReflexiveObject"></see>
    /// </summary>
    let ReflexiveObject =
        Namespaced_IRI.parse _namespace_name "ReflexiveObject" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#ReflexivePersonalPronoun"></see>
    /// </summary>
    let ReflexivePersonalPronoun =
        Namespaced_IRI.parse _namespace_name "ReflexivePersonalPronoun" |> NamespacedName

    /// <summary>
    /// personal pronoun which is reflexive
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#reflexivePersonalPronoun"></see></summary>
    let reflexivePersonalPronoun =
        Namespaced_IRI.parse _namespace_name "reflexivePersonalPronoun" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#ReflexivePossessivePronoun"></see>
    /// </summary>
    let ReflexivePossessivePronoun =
        Namespaced_IRI.parse _namespace_name "ReflexivePossessivePronoun" |> NamespacedName

    /// <summary>
    /// A possessive pronoun that refers to the subject as the possessor.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#reflexivePossessivePronoun"></see></summary>
    let reflexivePossessivePronoun =
        Namespaced_IRI.parse _namespace_name "reflexivePossessivePronoun" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#ReflexiveReciprocalFrame"></see>
    /// </summary>
    let ReflexiveReciprocalFrame =
        Namespaced_IRI.parse _namespace_name "ReflexiveReciprocalFrame" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#ReflexiveTransitiveFrame"></see>
    /// </summary>
    let ReflexiveTransitiveFrame =
        Namespaced_IRI.parse _namespace_name "ReflexiveTransitiveFrame" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#TransitiveFrame"></see>
    /// </summary>
    let TransitiveFrame =
        Namespaced_IRI.parse _namespace_name "TransitiveFrame" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#ReflexiveTransitivePPFrame"></see>
    /// </summary>
    let ReflexiveTransitivePPFrame =
        Namespaced_IRI.parse _namespace_name "ReflexiveTransitivePPFrame" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#TransitivePPFrame"></see>
    /// </summary>
    let TransitivePPFrame =
        Namespaced_IRI.parse _namespace_name "TransitivePPFrame" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#Register"></see>
    /// </summary>
    let Register = Namespaced_IRI.parse _namespace_name "Register" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#RelationNoun"></see>
    /// </summary>
    let RelationNoun =
        Namespaced_IRI.parse _namespace_name "RelationNoun" |> NamespacedName

    /// <summary>
    /// relation noun
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#relationNoun"></see></summary>
    let relationNoun =
        Namespaced_IRI.parse _namespace_name "relationNoun" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#RelativeDeterminer"></see>
    /// </summary>
    let RelativeDeterminer =
        Namespaced_IRI.parse _namespace_name "RelativeDeterminer" |> NamespacedName

    /// <summary>
    /// Determiner related to a referent.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#relativeDeterminer"></see></summary>
    let relativeDeterminer =
        Namespaced_IRI.parse _namespace_name "relativeDeterminer" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#RelativeParticle"></see>
    /// </summary>
    let RelativeParticle =
        Namespaced_IRI.parse _namespace_name "RelativeParticle" |> NamespacedName

    /// <summary>
    /// relative particle
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#relativeParticle"></see></summary>
    let relativeParticle =
        Namespaced_IRI.parse _namespace_name "relativeParticle" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#RelativePronoun"></see>
    /// </summary>
    let RelativePronoun =
        Namespaced_IRI.parse _namespace_name "RelativePronoun" |> NamespacedName

    /// <summary>
    /// Pronoun which introduces a relative clause and refers to something that has been said before.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#relativePronoun"></see></summary>
    let relativePronoun =
        Namespaced_IRI.parse _namespace_name "relativePronoun" |> NamespacedName

    /// <summary>
    /// A root is the portion of a word that (a) is common to a set of derived or inflected forms, (b) is not further analyzable into meaningful elements, and (c) carries the principle portion of meaning of the words in which it functions (as defined by the SIL Glossary of Linguistic Terms, https://glossary.sil.org/term/root).
    /// After publishing OntoLex-Morph, this should be re-defined as a subclass of morph:Morph.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#RootMorph"></see></summary>
    let RootMorph = Namespaced_IRI.parse _namespace_name "RootMorph" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#SemiColon"></see>
    /// </summary>
    let SemiColon = Namespaced_IRI.parse _namespace_name "SemiColon" |> NamespacedName
    /// <summary>
    /// Sign (;) usually used to separate phrases.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#semiColon"></see></summary>
    let semiColon = Namespaced_IRI.parse _namespace_name "semiColon" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#SententialClause"></see>
    /// </summary>
    let SententialClause =
        Namespaced_IRI.parse _namespace_name "SententialClause" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#sententialClause"></see>
    /// </summary>
    let sententialClause =
        Namespaced_IRI.parse _namespace_name "sententialClause" |> NamespacedName

    /// <summary>
    /// A simulfix is a change or replacement of vowels or consonants (usually vowels) which changes the meaning of a word (as defined by the SIL Glossary of Linguistic Terms, https://glossary.sil.org/term/simulfix). Examples include umlaut in Germanic languages, e.g., in the formation of the English plural feet from the singular foot.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#SimulfixMorph"></see></summary>
    let SimulfixMorph =
        Namespaced_IRI.parse _namespace_name "SimulfixMorph" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#Slash"></see>
    /// </summary>
    let Slash = Namespaced_IRI.parse _namespace_name "Slash" |> NamespacedName
    /// <summary>
    /// The punctuation sign /
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#slash"></see></summary>
    let slash = Namespaced_IRI.parse _namespace_name "slash" |> NamespacedName
    /// <summary>
    /// A stem is the root or roots of a word, together with any derivational affixes, to which inflectional affixes are added (as defined by the SIL Glossary of Linguistic Terms, https://glossary.sil.org/term/stem). A stem consists minimally of a root, but may be analyzable into a root plus derivational morphemes.
    /// After publishing OntoLex-Morph, this should be re-defined as subclass of morph:Morph.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#StemMorph"></see></summary>
    let StemMorph = Namespaced_IRI.parse _namespace_name "StemMorph" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#StrongPersonalPronoun"></see>
    /// </summary>
    let StrongPersonalPronoun =
        Namespaced_IRI.parse _namespace_name "StrongPersonalPronoun" |> NamespacedName

    /// <summary>
    /// Personal pronoun that can occupy the position after a preposition and/or reinforce a weak personal pronoun.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#strongPersonalPronoun"></see></summary>
    let strongPersonalPronoun =
        Namespaced_IRI.parse _namespace_name "strongPersonalPronoun" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#SubjectlessFrame"></see>
    /// </summary>
    let SubjectlessFrame =
        Namespaced_IRI.parse _namespace_name "SubjectlessFrame" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#SubjectlessIntransitiveFrame"></see>
    /// </summary>
    let SubjectlessIntransitiveFrame =
        Namespaced_IRI.parse _namespace_name "SubjectlessIntransitiveFrame" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#SubjectlessIntransitivePPFrame"></see>
    /// </summary>
    let SubjectlessIntransitivePPFrame =
        Namespaced_IRI.parse _namespace_name "SubjectlessIntransitivePPFrame" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#SubjectlessTransitiveFrame"></see>
    /// </summary>
    let SubjectlessTransitiveFrame =
        Namespaced_IRI.parse _namespace_name "SubjectlessTransitiveFrame" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#SubjectlessTransitivePPFrame"></see>
    /// </summary>
    let SubjectlessTransitivePPFrame =
        Namespaced_IRI.parse _namespace_name "SubjectlessTransitivePPFrame" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#SubjunctiveClause"></see>
    /// </summary>
    let SubjunctiveClause =
        Namespaced_IRI.parse _namespace_name "SubjunctiveClause" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#SubordinatingConjunction"></see>
    /// </summary>
    let SubordinatingConjunction =
        Namespaced_IRI.parse _namespace_name "SubordinatingConjunction" |> NamespacedName

    /// <summary>
    /// Conjunction that links constructions by making one of them a constituent of another. The subordinating conjunction typically marks the incorporated constituent.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#subordinatingConjunction"></see></summary>
    let subordinatingConjunction =
        Namespaced_IRI.parse _namespace_name "subordinatingConjunction" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#Suffix"></see>
    /// </summary>
    let Suffix = Namespaced_IRI.parse _namespace_name "Suffix" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#SuperlativeAdjunct"></see>
    /// </summary>
    let SuperlativeAdjunct =
        Namespaced_IRI.parse _namespace_name "SuperlativeAdjunct" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#SuperlativeParticle"></see>
    /// </summary>
    let SuperlativeParticle =
        Namespaced_IRI.parse _namespace_name "SuperlativeParticle" |> NamespacedName

    /// <summary>
    /// Particle expressing superlative degree. Superlative is the comparison between more than two entities and contrasts with comparative where only two entities are involved and positive where no comparison is implied.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#superlativeParticle"></see></summary>
    let superlativeParticle =
        Namespaced_IRI.parse _namespace_name "superlativeParticle" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#SuspensionPoints"></see>
    /// </summary>
    let SuspensionPoints =
        Namespaced_IRI.parse _namespace_name "SuspensionPoints" |> NamespacedName

    /// <summary>
    /// Sequence of three dots having the same meaning as &amp;quot;et cetera&amp;quot; (full form) or &amp;quot;etc&amp;quot; (abbreviated form).
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#suspensionPoints"></see></summary>
    let suspensionPoints =
        Namespaced_IRI.parse _namespace_name "suspensionPoints" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#SymbolPOS"></see>
    /// </summary>
    let SymbolPOS = Namespaced_IRI.parse _namespace_name "SymbolPOS" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#TemporalQualifier"></see>
    /// </summary>
    let TemporalQualifier =
        Namespaced_IRI.parse _namespace_name "TemporalQualifier" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#Tense"></see>
    /// </summary>
    let Tense = Namespaced_IRI.parse _namespace_name "Tense" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#TermElement"></see>
    /// </summary>
    let TermElement =
        Namespaced_IRI.parse _namespace_name "TermElement" |> NamespacedName

    /// <summary>
    /// A transfix is a discontinuous affix that disrupts the base to which it is attached. The term is reserved for true single affixes, rather than combinations of an infix with an independent prefix or suffix. (Broselow, E., 2000. Transfixation. In G. Booij, et al. (eds.), Ein internationales Handbuch zur Flexion und Wortbildung. 1. Halbband. Mouton De Gruyter, New York, Berlin, p. 552-557.) Examples include discontinuous affixes inserted into a word root, as in root-and-pattern systems of several Semitic languages, e.g., in the Arabic word kitaba "writing" from the root k-t-b.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#TransfixMorph"></see></summary>
    let TransfixMorph =
        Namespaced_IRI.parse _namespace_name "TransfixMorph" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#TransitiveAdjectivalComplementFrame"></see>
    /// </summary>
    let TransitiveAdjectivalComplementFrame =
        Namespaced_IRI.parse _namespace_name "TransitiveAdjectivalComplementFrame" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#TransitiveAdverbialComplementFrame"></see>
    /// </summary>
    let TransitiveAdverbialComplementFrame =
        Namespaced_IRI.parse _namespace_name "TransitiveAdverbialComplementFrame" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#TransitiveDeclarativeFrame"></see>
    /// </summary>
    let TransitiveDeclarativeFrame =
        Namespaced_IRI.parse _namespace_name "TransitiveDeclarativeFrame" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#TransitiveInfinitiveACFrame"></see>
    /// </summary>
    let TransitiveInfinitiveACFrame =
        Namespaced_IRI.parse _namespace_name "TransitiveInfinitiveACFrame" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#TransitiveInfinitiveOCFrame"></see>
    /// </summary>
    let TransitiveInfinitiveOCFrame =
        Namespaced_IRI.parse _namespace_name "TransitiveInfinitiveOCFrame" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#TransitiveInfinitiveSCFrame"></see>
    /// </summary>
    let TransitiveInfinitiveSCFrame =
        Namespaced_IRI.parse _namespace_name "TransitiveInfinitiveSCFrame" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#TransitiveInterrogativeFrame"></see>
    /// </summary>
    let TransitiveInterrogativeFrame =
        Namespaced_IRI.parse _namespace_name "TransitiveInterrogativeFrame" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#TransitiveInterrogativeInfinitiveFrame"></see>
    /// </summary>
    let TransitiveInterrogativeInfinitiveFrame =
        Namespaced_IRI.parse _namespace_name "TransitiveInterrogativeInfinitiveFrame" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#TransitiveNominalComplementFrame"></see>
    /// </summary>
    let TransitiveNominalComplementFrame =
        Namespaced_IRI.parse _namespace_name "TransitiveNominalComplementFrame" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#TransitiveSententialFrame"></see>
    /// </summary>
    let TransitiveSententialFrame =
        Namespaced_IRI.parse _namespace_name "TransitiveSententialFrame" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#UnclassifiedParticle"></see>
    /// </summary>
    let UnclassifiedParticle =
        Namespaced_IRI.parse _namespace_name "UnclassifiedParticle" |> NamespacedName

    /// <summary>
    /// Particle that is not covered by other sorts of particle definitions.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#unclassifiedParticle"></see></summary>
    let unclassifiedParticle =
        Namespaced_IRI.parse _namespace_name "unclassifiedParticle" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#VerbPOS"></see>
    /// </summary>
    let VerbPOS = Namespaced_IRI.parse _namespace_name "VerbPOS" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#VerbFormMood"></see>
    /// </summary>
    let VerbFormMood =
        Namespaced_IRI.parse _namespace_name "VerbFormMood" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#VerbPhrase"></see>
    /// </summary>
    let VerbPhrase = Namespaced_IRI.parse _namespace_name "VerbPhrase" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#Voice"></see>
    /// </summary>
    let Voice = Namespaced_IRI.parse _namespace_name "Voice" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#WeakPersonalPronoun"></see>
    /// </summary>
    let WeakPersonalPronoun =
        Namespaced_IRI.parse _namespace_name "WeakPersonalPronoun" |> NamespacedName

    /// <summary>
    /// Personal pronoun that cannot occupy the position after a preposition and/or reinforce a strong personal pronoun.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#weakPersonalPronoun"></see></summary>
    let weakPersonalPronoun =
        Namespaced_IRI.parse _namespace_name "weakPersonalPronoun" |> NamespacedName

    /// <summary>
    /// A zero morph is a morph, consisting of no phonetic form, that is proposed in some analyses as an allomorph of a morpheme that is ordinarily realized by a morph having some phonetic form (as defined by the SIL Glossary of Linguistic Terms, https://glossary.sil.org/term/zero-morph). Examples include the English plural sheep along with the singular sheep.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#ZeroMorph"></see></summary>
    let ZeroMorph = Namespaced_IRI.parse _namespace_name "ZeroMorph" |> NamespacedName

    /// <summary>
    /// A term or lexeme resulting from the omission of any part of the full term or lexeme while designating the same concept.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#abbreviatedForm"></see></summary>
    let abbreviatedForm =
        Namespaced_IRI.parse _namespace_name "abbreviatedForm" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#abbreviation"></see>
    /// </summary>
    let abbreviation =
        Namespaced_IRI.parse _namespace_name "abbreviation" |> NamespacedName

    /// <summary>
    /// A linking element used to identify a relation between an abbreviation and its full or expanded form.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#abbreviationFor"></see></summary>
    let abbreviationFor =
        Namespaced_IRI.parse _namespace_name "abbreviationFor" |> NamespacedName

    /// <summary>
    /// The full form that corresponds to a contracted form.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#contractionFor"></see></summary>
    let contractionFor =
        Namespaced_IRI.parse _namespace_name "contractionFor" |> NamespacedName

    /// <summary>
    /// Case that expresses the lack or absence of the referent of the noun it marks.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#abessiveCase"></see></summary>
    let abessiveCase =
        Namespaced_IRI.parse _namespace_name "abessiveCase" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#abessiveCaseForm"></see>
    /// </summary>
    let abessiveCaseForm =
        Namespaced_IRI.parse _namespace_name "abessiveCaseForm" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#formCaseVariant"></see>
    /// </summary>
    let formCaseVariant =
        Namespaced_IRI.parse _namespace_name "formCaseVariant" |> NamespacedName

    /// <summary>
    /// Case used to typically indicate locative or instrumental function.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#ablativeCase"></see></summary>
    let ablativeCase =
        Namespaced_IRI.parse _namespace_name "ablativeCase" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#ablativeCaseForm"></see>
    /// </summary>
    let ablativeCaseForm =
        Namespaced_IRI.parse _namespace_name "ablativeCaseForm" |> NamespacedName

    /// <summary>
    /// Case for nouns in ergative-absolute languages that would generally be the subjects of intransitive verbs or the objects of transitive verbs in the translational equivalents of nominative-accusative languages such as English.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#absolutiveCase"></see></summary>
    let absolutiveCase =
        Namespaced_IRI.parse _namespace_name "absolutiveCase" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#absolutiveCaseForm"></see>
    /// </summary>
    let absolutiveCaseForm =
        Namespaced_IRI.parse _namespace_name "absolutiveCaseForm" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#accusativeCaseForm"></see>
    /// </summary>
    let accusativeCaseForm =
        Namespaced_IRI.parse _namespace_name "accusativeCaseForm" |> NamespacedName

    /// <summary>
    /// An abbreviation made up of the initial letters of the components of the full form of the designation or from syllables of the full form and pronounced syllabically.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#acronym"></see></summary>
    let acronym = Namespaced_IRI.parse _namespace_name "acronym" |> NamespacedName
    /// <summary>
    /// A linking element used to identify a relation between an acronym and its full or expanded form.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#acronymFor"></see></summary>
    let acronymFor = Namespaced_IRI.parse _namespace_name "acronymFor" |> NamespacedName

    /// <summary>
    /// Value that expresses the situation where the grammatical subject is also the semantic actor of the verb.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#activeVoice"></see></summary>
    let activeVoice =
        Namespaced_IRI.parse _namespace_name "activeVoice" |> NamespacedName

    /// <summary>
    /// Case which expresses the meaning of presence 'at' or 'near' a place.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#adessiveCase"></see></summary>
    let adessiveCase =
        Namespaced_IRI.parse _namespace_name "adessiveCase" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#adessiveCaseForm"></see>
    /// </summary>
    let adessiveCaseForm =
        Namespaced_IRI.parse _namespace_name "adessiveCaseForm" |> NamespacedName

    /// <summary>
    /// Case expressing &amp;quot;to&amp;quot; in Basque studies.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#aditiveCase"></see></summary>
    let aditiveCase =
        Namespaced_IRI.parse _namespace_name "aditiveCase" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#aditiveCaseForm"></see>
    /// </summary>
    let aditiveCaseForm =
        Namespaced_IRI.parse _namespace_name "aditiveCaseForm" |> NamespacedName

    /// <summary>
    /// Part of speech related to attributes of noun.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#adjective"></see></summary>
    let adjective = Namespaced_IRI.parse _namespace_name "adjective" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#adjunct"></see>
    /// </summary>
    let adjunct = Namespaced_IRI.parse _namespace_name "adjunct" |> NamespacedName

    /// <summary>
    /// A term rated according to the scale of a term acceptability rating as a synonym for a preferred term.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#admittedTerm"></see></summary>
    let admittedTerm =
        Namespaced_IRI.parse _namespace_name "admittedTerm" |> NamespacedName

    /// <summary>
    /// Part of speech that occurs before/inside/after a complement composed of a noun phrase, noun, pronoun or clause that functions as a noun phrase and form a single structure with the complement to express its grammatical and semantic relation to another unit.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#adposition"></see></summary>
    let adposition = Namespaced_IRI.parse _namespace_name "adposition" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#adpositionalObject"></see>
    /// </summary>
    let adpositionalObject =
        Namespaced_IRI.parse _namespace_name "adpositionalObject" |> NamespacedName

    /// <summary>
    /// Part of speech to refer to an heterogeneous group of words whose most frequent function is to specify the mode of action of the verb.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#adverb"></see></summary>
    let adverb = Namespaced_IRI.parse _namespace_name "adverb" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#affix"></see>
    /// </summary>
    let affix = Namespaced_IRI.parse _namespace_name "affix" |> NamespacedName

    /// <summary>
    /// Case which expresses the meaning of motion 'to' or 'towards' the referent it marks.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#allativeCase"></see></summary>
    let allativeCase =
        Namespaced_IRI.parse _namespace_name "allativeCase" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#allativeCaseForm"></see>
    /// </summary>
    let allativeCaseForm =
        Namespaced_IRI.parse _namespace_name "allativeCaseForm" |> NamespacedName

    /// <summary>
    /// The characteristic of a word indicating that in a given discourse community, its referent is considered to be alive or to possess a quality of volition or consciousness.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#animacy"></see></summary>
    let animacy = Namespaced_IRI.parse _namespace_name "animacy" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#morphosyntacticProperty"></see>
    /// </summary>
    let morphosyntacticProperty =
        Namespaced_IRI.parse _namespace_name "morphosyntacticProperty" |> NamespacedName

    /// <summary>
    /// Perceived as alive.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#animate"></see></summary>
    let animate = Namespaced_IRI.parse _namespace_name "animate" |> NamespacedName
    /// <summary>
    /// A term or lexeme whose concept or sense constitutes the opposite of the concept represented by a second term or lexeme.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#antonym"></see></summary>
    let antonym = Namespaced_IRI.parse _namespace_name "antonym" |> NamespacedName

    /// <summary>
    /// A designation that represents an individual concept.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#appellation"></see></summary>
    let appellation =
        Namespaced_IRI.parse _namespace_name "appellation" |> NamespacedName

    /// <summary>
    /// Property used to qualify something similar but not exactly the same
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#approximate"></see></summary>
    let approximate =
        Namespaced_IRI.parse _namespace_name "approximate" |> NamespacedName

    /// <summary>
    /// A synonym that differs in some minor way
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#approximateSynonym"></see></summary>
    let approximateSynonym =
        Namespaced_IRI.parse _namespace_name "approximateSynonym" |> NamespacedName

    /// <summary>
    /// A term or lexeme no longer in ordinary use, though retained for special purposes.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#archaicForm"></see></summary>
    let archaicForm =
        Namespaced_IRI.parse _namespace_name "archaicForm" |> NamespacedName

    /// <summary>
    /// Term used in the grammatical classification of words referring to a subclass of determiners which displays a primary role in differentiating the uses of nouns.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#article"></see></summary>
    let article = Namespaced_IRI.parse _namespace_name "article" |> NamespacedName
    /// <summary>
    /// Category associated to verbs and referring to the way the grammar marks the duration or type of temporal activity.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#aspect"></see></summary>
    let aspect = Namespaced_IRI.parse _namespace_name "aspect" |> NamespacedName

    /// <summary>
    /// A relation between two concepts having a non-hierarchical thematic connection by virtue of experience.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#associativeRelation"></see></summary>
    let associativeRelation =
        Namespaced_IRI.parse _namespace_name "associativeRelation" |> NamespacedName

    /// <summary>
    /// A term connected to another term by a coordinate or associative relation.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#relatedTerm"></see></summary>
    let relatedTerm =
        Namespaced_IRI.parse _namespace_name "relatedTerm" |> NamespacedName

    /// <summary>
    /// usage marker which identifies the speaker’s subjective point of view, positive or negative, regarding the object referred to by a given lexical unit
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#attitude"></see></summary>
    let attitude = Namespaced_IRI.parse _namespace_name "attitude" |> NamespacedName

    /// <summary>
    /// The root form of a word or term that is used as the formal dictionary entry for the term.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#baseElement"></see></summary>
    let baseElement =
        Namespaced_IRI.parse _namespace_name "baseElement" |> NamespacedName

    /// <summary>
    /// Register of terms used in applications-oriented as opposed to theoretical or academic levels of language. // The register of terms used in applications-oriented as opposed to theoretical or academic levels of language.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#benchLevelRegister"></see></summary>
    let benchLevelRegister =
        Namespaced_IRI.parse _namespace_name "benchLevelRegister" |> NamespacedName

    /// <summary>
    /// Case that expresses that the referent of the noun it marks receives the benefit of the situation expressed by the clause.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#benefactiveCase"></see></summary>
    let benefactiveCase =
        Namespaced_IRI.parse _namespace_name "benefactiveCase" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#benefactiveCaseForm"></see>
    /// </summary>
    let benefactiveCaseForm =
        Namespaced_IRI.parse _namespace_name "benefactiveCaseForm" |> NamespacedName

    /// <summary>
    /// Linked to a particular element.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#bound"></see></summary>
    let bound = Namespaced_IRI.parse _namespace_name "bound" |> NamespacedName
    /// <summary>
    /// In a given sentence, the way in which the form of a word changes in order to express a relationship with one or several words of the sentence. The morphological modification may apply to nouns, pronouns noun phrase constituents, such as adjectives or numerals.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#case"></see></summary>
    let case = Namespaced_IRI.parse _namespace_name "case" |> NamespacedName

    /// <summary>
    /// A concept that is related to another concept by virtue of the fact that it plays a causative role with respect to that concept.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#causallyRelatedConcept"></see></summary>
    let causallyRelatedConcept =
        Namespaced_IRI.parse _namespace_name "causallyRelatedConcept" |> NamespacedName

    /// <summary>
    /// Case which expresses that the referent of the noun it marks is the cause of the situation expressed by the clause.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#causativeCase"></see></summary>
    let causativeCase =
        Namespaced_IRI.parse _namespace_name "causativeCase" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#causativeCaseForm"></see>
    /// </summary>
    let causativeCaseForm =
        Namespaced_IRI.parse _namespace_name "causativeCaseForm" |> NamespacedName

    /// <summary>
    /// Aspect that expresses the cessation of an event or state.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#cessative"></see></summary>
    let cessative = Namespaced_IRI.parse _namespace_name "cessative" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#clausalArg"></see>
    /// </summary>
    let clausalArg = Namespaced_IRI.parse _namespace_name "clausalArg" |> NamespacedName

    /// <summary>
    /// An abbreviation formed by truncating a part of a simple term.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#clippedTerm"></see></summary>
    let clippedTerm =
        Namespaced_IRI.parse _namespace_name "clippedTerm" |> NamespacedName

    /// <summary>
    /// A linking element used to identify a relation between a clipped term and its full or expanded form.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#clippedTermFor"></see></summary>
    let clippedTermFor =
        Namespaced_IRI.parse _namespace_name "clippedTermFor" |> NamespacedName

    /// <summary>
    /// A form that is derived morphosyntactically from another form
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#derivedForm"></see></summary>
    let derivedForm =
        Namespaced_IRI.parse _namespace_name "derivedForm" |> NamespacedName

    /// <summary>
    /// Categorization of the different types of clitics
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#cliticness"></see></summary>
    let cliticness = Namespaced_IRI.parse _namespace_name "cliticness" |> NamespacedName
    /// <summary>
    /// A collective number is a number referring to 'a set of things'. Languages that have this feature can use it to get a phrase like 'flock of sheeps' by using 'sheep' in collective number.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#collective"></see></summary>
    let collective = Namespaced_IRI.parse _namespace_name "collective" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#collectiveNumberForm"></see>
    /// </summary>
    let collectiveNumberForm =
        Namespaced_IRI.parse _namespace_name "collectiveNumberForm" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#formNumberVariant"></see>
    /// </summary>
    let formNumberVariant =
        Namespaced_IRI.parse _namespace_name "formNumberVariant" |> NamespacedName

    /// <summary>
    /// Two terms that occur together far more frequently than chance
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#collocation"></see></summary>
    let collocation =
        Namespaced_IRI.parse _namespace_name "collocation" |> NamespacedName

    /// <summary>
    /// Case which expresses a meaning similar to 'along with' or 'accompagnied by'.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#comitativeCase"></see></summary>
    let comitativeCase =
        Namespaced_IRI.parse _namespace_name "comitativeCase" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#comitativeCaseForm"></see>
    /// </summary>
    let comitativeCaseForm =
        Namespaced_IRI.parse _namespace_name "comitativeCaseForm" |> NamespacedName

    /// <summary>
    /// Indistinguished gender for epicenes.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#commonGender"></see></summary>
    let commonGender =
        Namespaced_IRI.parse _namespace_name "commonGender" |> NamespacedName

    /// <summary>
    /// A synonym for an international scientific term that is used in general discourse in a given language.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#commonName"></see></summary>
    let commonName = Namespaced_IRI.parse _namespace_name "commonName" |> NamespacedName

    /// <summary>
    /// Said of a term that appears frequently.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#commonlyUsed"></see></summary>
    let commonlyUsed =
        Namespaced_IRI.parse _namespace_name "commonlyUsed" |> NamespacedName

    /// <summary>
    /// Comparative is the comparison where only two entites are involved.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#comparative"></see></summary>
    let comparative =
        Namespaced_IRI.parse _namespace_name "comparative" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#predicativeAdjunct"></see>
    /// </summary>
    let predicativeAdjunct =
        Namespaced_IRI.parse _namespace_name "predicativeAdjunct" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#comparativeDegreeForm"></see>
    /// </summary>
    let comparativeDegreeForm =
        Namespaced_IRI.parse _namespace_name "comparativeDegreeForm" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#formDegreeVariant"></see>
    /// </summary>
    let formDegreeVariant =
        Namespaced_IRI.parse _namespace_name "formDegreeVariant" |> NamespacedName

    /// <summary>
    /// A lexical unit that combines two or sometimes more different words, frequently such that the sense of the new lexical unit is not clearly derivable from the combination of its parts.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#compound"></see></summary>
    let compound = Namespaced_IRI.parse _namespace_name "compound" |> NamespacedName

    /// <summary>
    /// A conditional relation is a logical relation in which the illocutionary act employing one of a pair of propositions is expressed or implied to be true or in force if the other proposition is true.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#conditional"></see></summary>
    let conditional =
        Namespaced_IRI.parse _namespace_name "conditional" |> NamespacedName

    /// <summary>
    /// The confidence in a given relationship.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#confidence"></see></summary>
    let confidence = Namespaced_IRI.parse _namespace_name "confidence" |> NamespacedName

    /// <summary>
    /// Word that syntactically links words or constituents, and expresses a semantic relationship between them.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#conjunction"></see></summary>
    let conjunction =
        Namespaced_IRI.parse _namespace_name "conjunction" |> NamespacedName

    /// <summary>
    /// A lexical unit formed by a shortening of a word, syllable, or word group by omission of a sound or letter.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#contraction"></see></summary>
    let contraction =
        Namespaced_IRI.parse _namespace_name "contraction" |> NamespacedName

    /// <summary>
    /// A linking element used to identify a relation between any full form of a term or lexical unit and its abbreviated form.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#fullFormFor"></see></summary>
    let fullFormFor =
        Namespaced_IRI.parse _namespace_name "fullFormFor" |> NamespacedName

    /// <summary>
    /// A subordinate concept having the same nearest superordinate concept and same criterion of subdivision as some other concept in a given concept system.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#coordinateConcept"></see></summary>
    let coordinateConcept =
        Namespaced_IRI.parse _namespace_name "coordinateConcept" |> NamespacedName

    /// <summary>
    /// Indication specifying whether the usage is old or modern.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#dating"></see></summary>
    let dating = Namespaced_IRI.parse _namespace_name "dating" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#dativeCaseForm"></see>
    /// </summary>
    let dativeCaseForm =
        Namespaced_IRI.parse _namespace_name "dativeCaseForm" |> NamespacedName

    /// <summary>
    /// Value referring to the capacity of identification of an entity.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#definite"></see></summary>
    let definite = Namespaced_IRI.parse _namespace_name "definite" |> NamespacedName

    /// <summary>
    /// Property about the possiblity to identify an entity.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#definiteness"></see></summary>
    let definiteness =
        Namespaced_IRI.parse _namespace_name "definiteness" |> NamespacedName

    /// <summary>
    /// Property concerning comparison.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#degree"></see></summary>
    let degree = Namespaced_IRI.parse _namespace_name "degree" |> NamespacedName

    /// <summary>
    /// Case which expresses motion downward from the referent of the noun it marks.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#delativeCase"></see></summary>
    let delativeCase =
        Namespaced_IRI.parse _namespace_name "delativeCase" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#delativeCaseForm"></see>
    /// </summary>
    let delativeCaseForm =
        Namespaced_IRI.parse _namespace_name "delativeCaseForm" |> NamespacedName

    /// <summary>
    /// A term rated according to the scale of a term acceptability rating as undesired.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#deprecatedTerm"></see></summary>
    let deprecatedTerm =
        Namespaced_IRI.parse _namespace_name "deprecatedTerm" |> NamespacedName

    /// <summary>
    /// A description in general prose text of the issues that are indicated by the context. The description field can occur at many different places in a component and profile.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#description"></see></summary>
    let description =
        Namespaced_IRI.parse _namespace_name "description" |> NamespacedName

    /// <summary>
    /// Word or affix that belongs to a class of noun modifiers that expresses the reference, including quantity, of a noun.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#determiner"></see></summary>
    let determiner = Namespaced_IRI.parse _namespace_name "determiner" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#dialectRegister"></see>
    /// </summary>
    let dialectRegister =
        Namespaced_IRI.parse _namespace_name "dialectRegister" |> NamespacedName

    /// <summary>
    /// An unmarked case which covers the single argument of a one-place verb and the agent and patient arguments of a transitive verb.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#directCase"></see></summary>
    let directCase = Namespaced_IRI.parse _namespace_name "directCase" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#directCaseForm"></see>
    /// </summary>
    let directCaseForm =
        Namespaced_IRI.parse _namespace_name "directCaseForm" |> NamespacedName

    /// <summary>
    /// usage marker which identifies the specialized field of knowledge in which a lexical unit is mainly used
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#domain"></see></summary>
    let domain = Namespaced_IRI.parse _namespace_name "domain" |> NamespacedName
    /// <summary>
    /// Form used in some languages to designate two persons or things. // The form used in some languages to designate two persons or things.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#dual"></see></summary>
    let dual = Namespaced_IRI.parse _namespace_name "dual" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#dualNumberForm"></see>
    /// </summary>
    let dualNumberForm =
        Namespaced_IRI.parse _namespace_name "dualNumberForm" |> NamespacedName

    /// <summary>
    /// Case which expresses the meaning of motion 'away from' from the referent of the noun it marks.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#elativeCase"></see></summary>
    let elativeCase =
        Namespaced_IRI.parse _namespace_name "elativeCase" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#elativeCaseForm"></see>
    /// </summary>
    let elativeCaseForm =
        Namespaced_IRI.parse _namespace_name "elativeCaseForm" |> NamespacedName

    /// <summary>
    /// A term that heads a terminological entry.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#entryTerm"></see></summary>
    let entryTerm = Namespaced_IRI.parse _namespace_name "entryTerm" |> NamespacedName
    /// <summary>
    /// An expression used to represent a concept based on a statement that two mathematical expressions are, for instance, equal as identified by the equal sign (=), or assigned to one another by a similar sign.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#equation"></see></summary>
    let equation = Namespaced_IRI.parse _namespace_name "equation" |> NamespacedName

    /// <summary>
    /// Case that expresses likeness or identity to the referent of the noun it marks. It can have meaning, such as: 'as', 'like', or 'in the capacity of'.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#equativeCase"></see></summary>
    let equativeCase =
        Namespaced_IRI.parse _namespace_name "equativeCase" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#equativeCaseForm"></see>
    /// </summary>
    let equativeCaseForm =
        Namespaced_IRI.parse _namespace_name "equativeCaseForm" |> NamespacedName

    /// <summary>
    /// Case assigned to the subject of a transitive verb as opposed to absolutive case.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#ergativeCase"></see></summary>
    let ergativeCase =
        Namespaced_IRI.parse _namespace_name "ergativeCase" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#ergativeCaseForm"></see>
    /// </summary>
    let ergativeCaseForm =
        Namespaced_IRI.parse _namespace_name "ergativeCaseForm" |> NamespacedName

    /// <summary>
    /// Case which expresses a state of being.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#essiveCase"></see></summary>
    let essiveCase = Namespaced_IRI.parse _namespace_name "essiveCase" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#essiveCaseForm"></see>
    /// </summary>
    let essiveCaseForm =
        Namespaced_IRI.parse _namespace_name "essiveCaseForm" |> NamespacedName

    /// <summary>
    /// Morpheme that has a particular status with regards to the word's etymology.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#etymologicalRoot"></see></summary>
    let etymologicalRoot =
        Namespaced_IRI.parse _namespace_name "etymologicalRoot" |> NamespacedName

    /// <summary>
    /// Information on the origin of a word and the development of its meaning.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#etymology"></see></summary>
    let etymology = Namespaced_IRI.parse _namespace_name "etymology" |> NamespacedName
    /// <summary>
    /// Completely equal in every detail
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#exact"></see></summary>
    let exact = Namespaced_IRI.parse _namespace_name "exact" |> NamespacedName

    /// <summary>
    /// A statement that describes and clarifies a concept and makes it understandable, but does not necessarily differentiate it from other concepts.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#explanation"></see></summary>
    let explanation =
        Namespaced_IRI.parse _namespace_name "explanation" |> NamespacedName

    /// <summary>
    /// A significant word or phrase.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#expression"></see></summary>
    let expression = Namespaced_IRI.parse _namespace_name "expression" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#facetiousRegister"></see>
    /// </summary>
    let facetiousRegister =
        Namespaced_IRI.parse _namespace_name "facetiousRegister" |> NamespacedName

    /// <summary>
    /// Of, relating to, or constituting the gender that ordinarily includes most words or grammatical forms referring to females.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#feminine"></see></summary>
    let feminine = Namespaced_IRI.parse _namespace_name "feminine" |> NamespacedName
    /// <summary>
    /// Property applied to a verb form that can occur on its own in an independent sentence.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#finite"></see></summary>
    let finite = Namespaced_IRI.parse _namespace_name "finite" |> NamespacedName
    /// <summary>
    /// Property referring to finite and non-finite status of a verbal form.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#finiteness"></see></summary>
    let finiteness = Namespaced_IRI.parse _namespace_name "finiteness" |> NamespacedName

    /// <summary>
    /// First person deixis is deictic reference that refers to the speaker, or both the speaker and referents grouped with the speaker
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#firstPerson"></see></summary>
    let firstPerson =
        Namespaced_IRI.parse _namespace_name "firstPerson" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#firstPersonForm"></see>
    /// </summary>
    let firstPersonForm =
        Namespaced_IRI.parse _namespace_name "firstPersonForm" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#formPersonVariant"></see>
    /// </summary>
    let formPersonVariant =
        Namespaced_IRI.parse _namespace_name "formPersonVariant" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#formMoodVariant"></see>
    /// </summary>
    let formMoodVariant =
        Namespaced_IRI.parse _namespace_name "formMoodVariant" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#formNegativeVariant"></see>
    /// </summary>
    let formNegativeVariant =
        Namespaced_IRI.parse _namespace_name "formNegativeVariant" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#formTenseVariant"></see>
    /// </summary>
    let formTenseVariant =
        Namespaced_IRI.parse _namespace_name "formTenseVariant" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#formalRegister"></see>
    /// </summary>
    let formalRegister =
        Namespaced_IRI.parse _namespace_name "formalRegister" |> NamespacedName

    /// <summary>
    /// Figures, symbols or the like used to express a concept briefly, such as a mathematical or chemical formula.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#formula"></see></summary>
    let formula = Namespaced_IRI.parse _namespace_name "formula" |> NamespacedName
    /// <summary>
    /// The relative commonness with which a term occurs.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#frequency"></see></summary>
    let frequency = Namespaced_IRI.parse _namespace_name "frequency" |> NamespacedName

    /// <summary>
    /// usage marker which identifies the relative rate of occurrence of a lexical unit in a given textual context
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#frequencyUsage"></see></summary>
    let frequencyUsage =
        Namespaced_IRI.parse _namespace_name "frequencyUsage" |> NamespacedName

    /// <summary>
    /// For definiteness, when a specific form is the syntactic subject of the clause.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#fullArticle"></see></summary>
    let fullArticle =
        Namespaced_IRI.parse _namespace_name "fullArticle" |> NamespacedName

    /// <summary>
    /// The complete presentation of a term or lexeme for which there is an abbreviated form.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#fullForm"></see></summary>
    let fullForm = Namespaced_IRI.parse _namespace_name "fullForm" |> NamespacedName

    /// <summary>
    /// Preposition that is the result of a morphological merge from at least two words.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#fusedPreposition"></see></summary>
    let fusedPreposition =
        Namespaced_IRI.parse _namespace_name "fusedPreposition" |> NamespacedName

    /// <summary>
    /// Verb tense that indicates action or state of being in the future.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#future"></see></summary>
    let future = Namespaced_IRI.parse _namespace_name "future" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#futureTenseForm"></see>
    /// </summary>
    let futureTenseForm =
        Namespaced_IRI.parse _namespace_name "futureTenseForm" |> NamespacedName

    /// <summary>
    /// A grammatical category that indicates grammatical relationships between words in sentences.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#gender"></see></summary>
    let gender = Namespaced_IRI.parse _namespace_name "gender" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#genitiveCaseForm"></see>
    /// </summary>
    let genitiveCaseForm =
        Namespaced_IRI.parse _namespace_name "genitiveCaseForm" |> NamespacedName

    /// <summary>
    /// usage marker which identifies the place or region where a lexical unit is mainly used
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#geographic"></see></summary>
    let geographic = Namespaced_IRI.parse _namespace_name "geographic" |> NamespacedName

    /// <summary>
    /// Description of a specific form used in a certain region as opposed to another form used in another region
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#geographicalVariant"></see></summary>
    let geographicalVariant =
        Namespaced_IRI.parse _namespace_name "geographicalVariant" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#gerundClause"></see>
    /// </summary>
    let gerundClause =
        Namespaced_IRI.parse _namespace_name "gerundClause" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#gerundive"></see>
    /// </summary>
    let gerundive = Namespaced_IRI.parse _namespace_name "gerundive" |> NamespacedName
    /// <summary>
    /// In TEI: A phrase or word used to provide a gloss or definition for some other word or phrase.
    /// In 1951: Any editorial comment.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#gloss"></see></summary>
    let gloss = Namespaced_IRI.parse _namespace_name "gloss" |> NamespacedName
    /// <summary>
    /// usage marker which cannot be classified otherwise
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#hint"></see></summary>
    let hint = Namespaced_IRI.parse _namespace_name "hint" |> NamespacedName

    /// <summary>
    /// Indicates that the referenced element is a part of this object
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#holonymTerm"></see></summary>
    let holonymTerm =
        Namespaced_IRI.parse _namespace_name "holonymTerm" |> NamespacedName

    /// <summary>
    /// A relation between two concepts where one of the concepts constitutes the whole and the other concept a part of that whole.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#partitiveRelation"></see></summary>
    let partitiveRelation =
        Namespaced_IRI.parse _namespace_name "partitiveRelation" |> NamespacedName

    /// <summary>
    /// Indicates this is a part of another concept
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#meronymTerm"></see></summary>
    let meronymTerm =
        Namespaced_IRI.parse _namespace_name "meronymTerm" |> NamespacedName

    /// <summary>
    /// A word that is spelled like another, but that has a different pronunciation, meaning, and/or origin. // Word that is written like another, but that has a different pronunciation, meaning, and/or origin.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#homograph"></see></summary>
    let homograph = Namespaced_IRI.parse _namespace_name "homograph" |> NamespacedName
    /// <summary>
    /// A word that is pronounced like another word and that can be spelled the same way (homograph) or can merely sound the same (homophone). // Word that sounds the same and is written the same as another word but is different in meaning.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#homonym"></see></summary>
    let homonym = Namespaced_IRI.parse _namespace_name "homonym" |> NamespacedName
    /// <summary>
    /// A word that is pronounced in the same way as another word but that is spelled differently. // Word that sounds like another word, but is different in writiing or meaning.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#homophone"></see></summary>
    let homophone = Namespaced_IRI.parse _namespace_name "homophone" |> NamespacedName
    /// <summary>
    /// A term with a broader meaning
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#hypernym"></see></summary>
    let hypernym = Namespaced_IRI.parse _namespace_name "hypernym" |> NamespacedName
    /// <summary>
    /// A term with a narrower meaning
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#hyponym"></see></summary>
    let hyponym = Namespaced_IRI.parse _namespace_name "hyponym" |> NamespacedName
    /// <summary>
    /// A group of words in a fixed order that have a particular meaning that is different from the meanings of each word understood on its own.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#idiom"></see></summary>
    let idiom = Namespaced_IRI.parse _namespace_name "idiom" |> NamespacedName

    /// <summary>
    /// Case which expresses the meaning of 'motion into' or 'direction towards' the referent of the noun it marks.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#illativeCase"></see></summary>
    let illativeCase =
        Namespaced_IRI.parse _namespace_name "illativeCase" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#illativeCaseForm"></see>
    /// </summary>
    let illativeCaseForm =
        Namespaced_IRI.parse _namespace_name "illativeCaseForm" |> NamespacedName

    /// <summary>
    /// Mood used to express an order.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#imperative"></see></summary>
    let imperative = Namespaced_IRI.parse _namespace_name "imperative" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#imperativeMoodForm"></see>
    /// </summary>
    let imperativeMoodForm =
        Namespaced_IRI.parse _namespace_name "imperativeMoodForm" |> NamespacedName

    /// <summary>
    /// Verb tense that refers to action in the past that is incomplete or ongoing.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#imperfect"></see></summary>
    let imperfect = Namespaced_IRI.parse _namespace_name "imperfect" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#imperfectTenseForm"></see>
    /// </summary>
    let imperfectTenseForm =
        Namespaced_IRI.parse _namespace_name "imperfectTenseForm" |> NamespacedName

    /// <summary>
    /// Imperfective aspect is an aspect that expresses an event or state, with respect to its internal structure, instead of expressing it as a simple whole.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#imperfective"></see></summary>
    let imperfective =
        Namespaced_IRI.parse _namespace_name "imperfective" |> NamespacedName

    /// <summary>
    /// Register of terms that are company-specific and not readily recognized outside this environment. // The register of terms that are company-specific and not readily recognized outside this environment.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#inHouseRegister"></see></summary>
    let inHouseRegister =
        Namespaced_IRI.parse _namespace_name "inHouseRegister" |> NamespacedName

    /// <summary>
    /// Perceived as not living.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#inanimate"></see></summary>
    let inanimate = Namespaced_IRI.parse _namespace_name "inanimate" |> NamespacedName
    /// <summary>
    /// Aspect that expresses the beginning of an event or state.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#inchoative"></see></summary>
    let inchoative = Namespaced_IRI.parse _namespace_name "inchoative" |> NamespacedName
    /// <summary>
    /// Value related to an entity in a situation where the identification of this entity is not clear cut.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#indefinite"></see></summary>
    let indefinite = Namespaced_IRI.parse _namespace_name "indefinite" |> NamespacedName
    /// <summary>
    /// Mood value used in the expression of statements and questions.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#indicative"></see></summary>
    let indicative = Namespaced_IRI.parse _namespace_name "indicative" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#indicativeMoodForm"></see>
    /// </summary>
    let indicativeMoodForm =
        Namespaced_IRI.parse _namespace_name "indicativeMoodForm" |> NamespacedName

    /// <summary>
    /// Markup to express that there is not any pertinence.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#indifferent"></see></summary>
    let indifferent =
        Namespaced_IRI.parse _namespace_name "indifferent" |> NamespacedName

    /// <summary>
    /// Case which expresses the meaning of location or position within a place.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#inessiveCase"></see></summary>
    let inessiveCase =
        Namespaced_IRI.parse _namespace_name "inessiveCase" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#inessiveCaseForm"></see>
    /// </summary>
    let inessiveCaseForm =
        Namespaced_IRI.parse _namespace_name "inessiveCaseForm" |> NamespacedName

    /// <summary>
    /// Mood cited as unmarked or base form.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#infinitive"></see></summary>
    let infinitive = Namespaced_IRI.parse _namespace_name "infinitive" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#infix"></see>
    /// </summary>
    let infix = Namespaced_IRI.parse _namespace_name "infix" |> NamespacedName

    /// <summary>
    /// An element of language used to change the form of a word (noun, adjective) by declension, and (verbs) by conjugation.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#inflectionElement"></see></summary>
    let inflectionElement =
        Namespaced_IRI.parse _namespace_name "inflectionElement" |> NamespacedName

    /// <summary>
    /// Said of a term that does not appear frequently.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#infrequentlyUsed"></see></summary>
    let infrequentlyUsed =
        Namespaced_IRI.parse _namespace_name "infrequentlyUsed" |> NamespacedName

    /// <summary>
    /// An abbreviation made up of the initial letters of the components of the full form of the designation or from syllables of the full form and pronounced letter by letter.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#initialism"></see></summary>
    let initialism = Namespaced_IRI.parse _namespace_name "initialism" |> NamespacedName

    /// <summary>
    /// A linking element used to identify a relation between an initialism and its full or expanded form.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#initialismFor"></see></summary>
    let initialismFor =
        Namespaced_IRI.parse _namespace_name "initialismFor" |> NamespacedName

    /// <summary>
    /// Case indicating that the referent of the noun it marks is the means of the accomplishment of the action expressed by the clause.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#instrumentalCase"></see></summary>
    let instrumentalCase =
        Namespaced_IRI.parse _namespace_name "instrumentalCase" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#instrumentalCaseForm"></see>
    /// </summary>
    let instrumentalCaseForm =
        Namespaced_IRI.parse _namespace_name "instrumentalCaseForm" |> NamespacedName

    /// <summary>
    /// A term that is part of an international scientific nomenclature as adopted by an appropriate scientific body.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#internationalScientificTerm"></see></summary>
    let internationalScientificTerm =
        Namespaced_IRI.parse _namespace_name "internationalScientificTerm" |> NamespacedName

    /// <summary>
    /// A term that has the same or nearly identical orthographic or phonemic form in many languages.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#internationalism"></see></summary>
    let internationalism =
        Namespaced_IRI.parse _namespace_name "internationalism" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#ironicRegister"></see>
    /// </summary>
    let ironicRegister =
        Namespaced_IRI.parse _namespace_name "ironicRegister" |> NamespacedName

    /// <summary>
    /// Case which expresses motion to a location.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#lativeCase"></see></summary>
    let lativeCase = Namespaced_IRI.parse _namespace_name "lativeCase" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#lativeCaseForm"></see>
    /// </summary>
    let lativeCaseForm =
        Namespaced_IRI.parse _namespace_name "lativeCaseForm" |> NamespacedName

    /// <summary>
    /// A term that is legally defined and used in legally binding documents.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#legalTerm"></see></summary>
    let legalTerm = Namespaced_IRI.parse _namespace_name "legalTerm" |> NamespacedName

    /// <summary>
    /// Case that indicates a final location of action or a time of the action.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#locativeCase"></see></summary>
    let locativeCase =
        Namespaced_IRI.parse _namespace_name "locativeCase" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#locativeCaseForm"></see>
    /// </summary>
    let locativeCaseForm =
        Namespaced_IRI.parse _namespace_name "locativeCaseForm" |> NamespacedName

    /// <summary>
    /// An expression used to represent a concept based on mathematical or logical relations, such as statements of inequality, set relationships, boolean operations, and the like.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#logicalExpression"></see></summary>
    let logicalExpression =
        Namespaced_IRI.parse _namespace_name "logicalExpression" |> NamespacedName

    /// <summary>
    /// Of, relating to, or constituting the gender that ordinarily includes most words or grammatical forms referring to males.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#masculine"></see></summary>
    let masculine = Namespaced_IRI.parse _namespace_name "masculine" |> NamespacedName
    /// <summary>
    /// Designation of a term or word that is not countable and cannot generally be used with the indefinite article or in the plural.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#massNoun"></see></summary>
    let massNoun = Namespaced_IRI.parse _namespace_name "massNoun" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#massNounNumberForm"></see>
    /// </summary>
    let massNounNumberForm =
        Namespaced_IRI.parse _namespace_name "massNounNumberForm" |> NamespacedName

    /// <summary>
    /// usage marker which identifies a semantic extension of the sense of a given lexical unit
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#meaningType"></see></summary>
    let meaningType =
        Namespaced_IRI.parse _namespace_name "meaningType" |> NamespacedName

    /// <summary>
    /// Indicates the object is a member of this
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#memberHolonym"></see></summary>
    let memberHolonym =
        Namespaced_IRI.parse _namespace_name "memberHolonym" |> NamespacedName

    /// <summary>
    /// Indicates this is an element of the other
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#memberMeronym"></see></summary>
    let memberMeronym =
        Namespaced_IRI.parse _namespace_name "memberMeronym" |> NamespacedName

    /// <summary>
    /// Value for middle voice that expresses that the subject is both the agent and object, or that the subject is separate from the agent or that the receiver is the agent him/herself.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#middleVoice"></see></summary>
    let middleVoice =
        Namespaced_IRI.parse _namespace_name "middleVoice" |> NamespacedName

    /// <summary>
    /// Currently in use.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#modern"></see></summary>
    let modern = Namespaced_IRI.parse _namespace_name "modern" |> NamespacedName

    /// <summary>
    /// Refers to the prenominal or postnominal positions of determiners which distinguish different forms.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#modificationType"></see></summary>
    let modificationType =
        Namespaced_IRI.parse _namespace_name "modificationType" |> NamespacedName

    /// <summary>
    /// In TEI: contains information about the grammatical mood of verbs (e.g. indicative, subjunctive, imperative).
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#mood"></see></summary>
    let mood = Namespaced_IRI.parse _namespace_name "mood" |> NamespacedName

    /// <summary>
    /// Unit resulting from the division of words into their smallest meaningful parts.
    /// Note: moved to lexeme element from being an independent element; note that this is currently an independent element in 12620
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#morphologicalElement"></see></summary>
    let morphologicalElement =
        Namespaced_IRI.parse _namespace_name "morphologicalElement" |> NamespacedName

    /// <summary>
    /// denotes the negation or the absence
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#negative"></see></summary>
    let negative = Namespaced_IRI.parse _namespace_name "negative" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#negativeForm"></see>
    /// </summary>
    let negativeForm =
        Namespaced_IRI.parse _namespace_name "negativeForm" |> NamespacedName

    /// <summary>
    /// Of, relating to, or constituting the gender that ordinarily includes most words or grammatical forms referring to objects that are not characterized as male or female.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#neuter"></see></summary>
    let neuter = Namespaced_IRI.parse _namespace_name "neuter" |> NamespacedName

    /// <summary>
    /// The register appropriate to general texts or discourse.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#neutralRegister"></see></summary>
    let neutralRegister =
        Namespaced_IRI.parse _namespace_name "neutralRegister" |> NamespacedName

    /// <summary>
    /// Value for negation.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#no"></see></summary>
    let no = Namespaced_IRI.parse _namespace_name "no" |> NamespacedName

    /// <summary>
    /// Case used to indicate the subject of a verb.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#nominativeCase"></see></summary>
    let nominativeCase =
        Namespaced_IRI.parse _namespace_name "nominativeCase" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#nominativeCaseForm"></see>
    /// </summary>
    let nominativeCaseForm =
        Namespaced_IRI.parse _namespace_name "nominativeCaseForm" |> NamespacedName

    /// <summary>
    /// Property related for verb forms occurring on their own only in dependent clauses and lacking tense and mood contrasts.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#nonFinite"></see></summary>
    let nonFinite = Namespaced_IRI.parse _namespace_name "nonFinite" |> NamespacedName

    /// <summary>
    /// A term status qualifier assigned by an authoritative body, such as a standards body or a governmental entity with a regulatory function.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#normativeAuthorization"></see></summary>
    let normativeAuthorization =
        Namespaced_IRI.parse _namespace_name "normativeAuthorization" |> NamespacedName

    /// <summary>
    /// usage marker which identifies the use of a given lexical unit which is in some aspect considered to be non-standard or incorrect
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#normativity"></see></summary>
    let normativity =
        Namespaced_IRI.parse _namespace_name "normativity" |> NamespacedName

    /// <summary>
    /// A statement that provides further information on any part of a language resource entry.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#note"></see></summary>
    let note = Namespaced_IRI.parse _namespace_name "note" |> NamespacedName
    /// <summary>
    /// Part of speech used to express the name of a person, place, action or thing.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#noun"></see></summary>
    let noun = Namespaced_IRI.parse _namespace_name "noun" |> NamespacedName
    /// <summary>
    /// The component of a multiword or multi-morphemic compound term that is determined or modified by the other components making up the term.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#nucleus"></see></summary>
    let nucleus = Namespaced_IRI.parse _namespace_name "nucleus" |> NamespacedName
    /// <summary>
    /// Grammatical category for the variation in form of nouns, pronouns, and any words agreeing with them, depending on how many persons or things are referred to. // In many languages, the grammatical distinction that indicates the number of objects referred to by the term or word.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#number"></see></summary>
    let number = Namespaced_IRI.parse _namespace_name "number" |> NamespacedName
    /// <summary>
    /// Part of speech that expresses a number or the relation to a number.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#numeral"></see></summary>
    let numeral = Namespaced_IRI.parse _namespace_name "numeral" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#objectComplement"></see>
    /// </summary>
    let objectComplement =
        Namespaced_IRI.parse _namespace_name "objectComplement" |> NamespacedName

    /// <summary>
    /// Case that is used when a noun is the object of a verb or a proposition, except for nominative and vocative case.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#obliqueCase"></see></summary>
    let obliqueCase =
        Namespaced_IRI.parse _namespace_name "obliqueCase" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#obliqueCaseForm"></see>
    /// </summary>
    let obliqueCaseForm =
        Namespaced_IRI.parse _namespace_name "obliqueCaseForm" |> NamespacedName

    /// <summary>
    /// A term or lexeme which is no longer in common use.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#obsoleteForm"></see></summary>
    let obsoleteForm =
        Namespaced_IRI.parse _namespace_name "obsoleteForm" |> NamespacedName

    /// <summary>
    /// Used in the past.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#old"></see></summary>
    let old = Namespaced_IRI.parse _namespace_name "old" |> NamespacedName

    /// <summary>
    /// 1951: An optional part of a headword.
    /// 1951; examples? The question arises whether these are true options or whether the options reflect synonyms or hyponyms (e.g., barrage, barrage de retenue). The question is not whether 1951 should use this markup, but rather how to map this markup in a global environment.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#optionalElement"></see></summary>
    let optionalElement =
        Namespaced_IRI.parse _namespace_name "optionalElement" |> NamespacedName

    /// <summary>
    /// Perceived as related to animacy, but without specific reference to the previous items.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#otherAnimacy"></see></summary>
    let otherAnimacy =
        Namespaced_IRI.parse _namespace_name "otherAnimacy" |> NamespacedName

    /// <summary>
    /// A grammatical category that indicates grammatical relationships between words in sentences.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#otherGender"></see></summary>
    let otherGender =
        Namespaced_IRI.parse _namespace_name "otherGender" |> NamespacedName

    /// <summary>
    /// Designation used to classify number-related grammatical information that can differ from the standard European classifications cited above.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#otherNumber"></see></summary>
    let otherNumber =
        Namespaced_IRI.parse _namespace_name "otherNumber" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#otherNumberForm"></see>
    /// </summary>
    let otherNumberForm =
        Namespaced_IRI.parse _namespace_name "otherNumberForm" |> NamespacedName

    /// <summary>
    /// A term or lexeme that has fallen from fashion, but the meaning of which is readily recognizable.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#outdatedForm"></see></summary>
    let outdatedForm =
        Namespaced_IRI.parse _namespace_name "outdatedForm" |> NamespacedName

    /// <summary>
    /// Indicates a part of this object
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#partHolonym"></see></summary>
    let partHolonym =
        Namespaced_IRI.parse _namespace_name "partHolonym" |> NamespacedName

    /// <summary>
    /// Indicates this a component of the other concept
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#partMeronym"></see></summary>
    let partMeronym =
        Namespaced_IRI.parse _namespace_name "partMeronym" |> NamespacedName

    /// <summary>
    /// A unique alphanumeric designation assigned to an object in a manufacturing system.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#partNumber"></see></summary>
    let partNumber = Namespaced_IRI.parse _namespace_name "partNumber" |> NamespacedName
    /// <summary>
    /// Term referring to a word derived from a verb and used as an adjective.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#participle"></see></summary>
    let participle = Namespaced_IRI.parse _namespace_name "participle" |> NamespacedName

    /// <summary>
    /// Indicates that one lexical entry is the participle form of another, e.g., the adjective 'reassuring' is the participle of 'to reassure'
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#participleFormOf"></see></summary>
    let participleFormOf =
        Namespaced_IRI.parse _namespace_name "participleFormOf" |> NamespacedName

    /// <summary>
    /// Word that does not belong to one of the main classes of words, is invariable in form, and typically has grammatical or pragmatic meaning.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#particle"></see></summary>
    let particle = Namespaced_IRI.parse _namespace_name "particle" |> NamespacedName

    /// <summary>
    /// Case that expresses the partial nature of the referent of the noun it marks, as opposed to expressing the whole unit or class of which the referent is a part.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#partitiveCase"></see></summary>
    let partitiveCase =
        Namespaced_IRI.parse _namespace_name "partitiveCase" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#partitiveCaseForm"></see>
    /// </summary>
    let partitiveCaseForm =
        Namespaced_IRI.parse _namespace_name "partitiveCaseForm" |> NamespacedName

    /// <summary>
    /// Term referring to a situation where the grammatical subject is typically the recipient or goal of the action denoted by the verb.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#passiveVoice"></see></summary>
    let passiveVoice =
        Namespaced_IRI.parse _namespace_name "passiveVoice" |> NamespacedName

    /// <summary>
    /// Past tense is an absolute tense that refers to a time before the moment of utterance.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#past"></see></summary>
    let past = Namespaced_IRI.parse _namespace_name "past" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#pastTenseForm"></see>
    /// </summary>
    let pastTenseForm =
        Namespaced_IRI.parse _namespace_name "pastTenseForm" |> NamespacedName

    /// <summary>
    /// Number that specifies 'a few' things.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#paucal"></see></summary>
    let paucal = Namespaced_IRI.parse _namespace_name "paucal" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#paucalNumberForm"></see>
    /// </summary>
    let paucalNumberForm =
        Namespaced_IRI.parse _namespace_name "paucalNumberForm" |> NamespacedName

    /// <summary>
    /// Perfective aspect is an aspect that expresses a temporal view of an event or state as a simple whole, apart from the consideration of the internal structure of the time in which it occurs.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#perfective"></see></summary>
    let perfective = Namespaced_IRI.parse _namespace_name "perfective" |> NamespacedName
    /// <summary>
    /// Indication of grammatical person (1st, 2nd, 3rd, etc.) associated with a given inflected form.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#person"></see></summary>
    let person = Namespaced_IRI.parse _namespace_name "person" |> NamespacedName
    /// <summary>
    /// Property that refers to the person.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#personal"></see></summary>
    let personal = Namespaced_IRI.parse _namespace_name "personal" |> NamespacedName
    /// <summary>
    /// Indicates that a term is the adjectival form of a word with a meaning of 'of or pertaining to X'
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#pertainsTo"></see></summary>
    let pertainsTo = Namespaced_IRI.parse _namespace_name "pertainsTo" |> NamespacedName

    /// <summary>
    /// Any group of two or more words that form a unit, the meaning of which frequently cannot be deduced based on the combined sense of the words making up the phrase.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#phraseologicalUnit"></see></summary>
    let phraseologicalUnit =
        Namespaced_IRI.parse _namespace_name "phraseologicalUnit" |> NamespacedName

    /// <summary>
    /// The form of a term or word (usually of a noun) used to designate more than one object. // Value that expresses more than one element.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#plural"></see></summary>
    let plural = Namespaced_IRI.parse _namespace_name "plural" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#pluralNumberForm"></see>
    /// </summary>
    let pluralNumberForm =
        Namespaced_IRI.parse _namespace_name "pluralNumberForm" |> NamespacedName

    /// <summary>
    /// Value used in a comparison relationship when no comparison is involved.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#positive"></see></summary>
    let positive = Namespaced_IRI.parse _namespace_name "positive" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#positiveDegreeForm"></see>
    /// </summary>
    let positiveDegreeForm =
        Namespaced_IRI.parse _namespace_name "positiveDegreeForm" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#positiveForm"></see>
    /// </summary>
    let positiveForm =
        Namespaced_IRI.parse _namespace_name "positiveForm" |> NamespacedName

    /// <summary>
    /// Relative to the possession or association.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#possessive"></see></summary>
    let possessive = Namespaced_IRI.parse _namespace_name "possessive" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#possessiveInfinitiveClause"></see>
    /// </summary>
    let possessiveInfinitiveClause =
        Namespaced_IRI.parse _namespace_name "possessiveInfinitiveClause" |> NamespacedName

    /// <summary>
    /// Situation where the modifier is after the modified.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#postModifier"></see></summary>
    let postModifier =
        Namespaced_IRI.parse _namespace_name "postModifier" |> NamespacedName

    /// <summary>
    /// Situation where the modifier is before the modified.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#preModifier"></see></summary>
    let preModifier =
        Namespaced_IRI.parse _namespace_name "preModifier" |> NamespacedName

    /// <summary>
    /// A term rated according to the scale of a term acceptability rating as the primary term for a given concept.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#preferredTerm"></see></summary>
    let preferredTerm =
        Namespaced_IRI.parse _namespace_name "preferredTerm" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#prefix"></see>
    /// </summary>
    let prefix = Namespaced_IRI.parse _namespace_name "prefix" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#prepositionalGerundClause"></see>
    /// </summary>
    let prepositionalGerundClause =
        Namespaced_IRI.parse _namespace_name "prepositionalGerundClause" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#prepositionalObject"></see>
    /// </summary>
    let prepositionalObject =
        Namespaced_IRI.parse _namespace_name "prepositionalObject" |> NamespacedName

    /// <summary>
    /// Verb tense that indicates action or state of being in the present.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#present"></see></summary>
    let present = Namespaced_IRI.parse _namespace_name "present" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#presentTenseForm"></see>
    /// </summary>
    let presentTenseForm =
        Namespaced_IRI.parse _namespace_name "presentTenseForm" |> NamespacedName

    /// <summary>
    /// The simple past or preterite as distinct from the perfect form, e.g,, "showed" not "shown"
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#preterite"></see></summary>
    let preterite = Namespaced_IRI.parse _namespace_name "preterite" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#preteriteTenseForm"></see>
    /// </summary>
    let preteriteTenseForm =
        Namespaced_IRI.parse _namespace_name "preteriteTenseForm" |> NamespacedName

    /// <summary>
    /// An attribute assigned to a term indicating that that term is the official designator for a product.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#productName"></see></summary>
    let productName =
        Namespaced_IRI.parse _namespace_name "productName" |> NamespacedName

    /// <summary>
    /// Case for a noun or a pronoun that expresses motion within a place or a period of time needed for an event.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#prolativeCase"></see></summary>
    let prolativeCase =
        Namespaced_IRI.parse _namespace_name "prolativeCase" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#prolativeCaseForm"></see>
    /// </summary>
    let prolativeCaseForm =
        Namespaced_IRI.parse _namespace_name "prolativeCaseForm" |> NamespacedName

    /// <summary>
    /// Word used in place of a noun or a noun phrase.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#pronoun"></see></summary>
    let pronoun = Namespaced_IRI.parse _namespace_name "pronoun" |> NamespacedName

    /// <summary>
    /// The representation of the manner by which a term or word is articulated.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#pronunciation"></see></summary>
    let pronunciation =
        Namespaced_IRI.parse _namespace_name "pronunciation" |> NamespacedName

    /// <summary>
    /// A brief popular axiom or saying.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#proverb"></see></summary>
    let proverb = Namespaced_IRI.parse _namespace_name "proverb" |> NamespacedName
    /// <summary>
    /// Property related to four elements.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#quadrial"></see></summary>
    let quadrial = Namespaced_IRI.parse _namespace_name "quadrial" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#quadrialNumberForm"></see>
    /// </summary>
    let quadrialNumberForm =
        Namespaced_IRI.parse _namespace_name "quadrialNumberForm" |> NamespacedName

    /// <summary>
    /// A term that is very similar but with some differences
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#quasiEquivalent"></see></summary>
    let quasiEquivalent =
        Namespaced_IRI.parse _namespace_name "quasiEquivalent" |> NamespacedName

    /// <summary>
    /// A basic identifiable component of every CJKV character, often found on the left side of the character, that sometimes gives a rough indication of meaning and is used for collating lexical and terminological resources.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#radical"></see></summary>
    let radical = Namespaced_IRI.parse _namespace_name "radical" |> NamespacedName
    /// <summary>
    /// Said of a term that is almost never used.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#rarelyUsed"></see></summary>
    let rarelyUsed = Namespaced_IRI.parse _namespace_name "rarelyUsed" |> NamespacedName

    /// <summary>
    /// Type of concrete object or concept (the referent) that an expression represents (the reference).
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#referentType"></see></summary>
    let referentType =
        Namespaced_IRI.parse _namespace_name "referentType" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#reflexiveObject"></see>
    /// </summary>
    let reflexiveObject =
        Namespaced_IRI.parse _namespace_name "reflexiveObject" |> NamespacedName

    /// <summary>
    /// Classification indicating the relative level of language individually assigned to a lexeme or term or to a text type.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#register"></see></summary>
    let register = Namespaced_IRI.parse _namespace_name "register" |> NamespacedName

    /// <summary>
    /// A term defined by law or government regulation.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#regulatedTerm"></see></summary>
    let regulatedTerm =
        Namespaced_IRI.parse _namespace_name "regulatedTerm" |> NamespacedName

    /// <summary>
    /// Transcription or transliteration from non-Latin script into Latin script.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#romanization"></see></summary>
    let romanization =
        Namespaced_IRI.parse _namespace_name "romanization" |> NamespacedName

    /// <summary>
    /// base of a word
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#root"></see></summary>
    let root = Namespaced_IRI.parse _namespace_name "root" |> NamespacedName

    /// <summary>
    /// Second person deixis is deictic reference to a person or persons identified as addressee.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#secondPerson"></see></summary>
    let secondPerson =
        Namespaced_IRI.parse _namespace_name "secondPerson" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#secondPersonForm"></see>
    /// </summary>
    let secondPersonForm =
        Namespaced_IRI.parse _namespace_name "secondPersonForm" |> NamespacedName

    /// <summary>
    /// Specification of the pointers in time or sequence that indicates the segmentation process.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#segmentation"></see></summary>
    let segmentation =
        Namespaced_IRI.parse _namespace_name "segmentation" |> NamespacedName

    /// <summary>
    /// Descriptive material that provides a sample of an object or entity defined in the entry.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#senseExample"></see></summary>
    let senseExample =
        Namespaced_IRI.parse _namespace_name "senseExample" |> NamespacedName

    /// <summary>
    /// A label for this sense in another language
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#senseTranslation"></see></summary>
    let senseTranslation =
        Namespaced_IRI.parse _namespace_name "senseTranslation" |> NamespacedName

    /// <summary>
    /// A fixed, lexicalized phrase.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#setPhrase"></see></summary>
    let setPhrase = Namespaced_IRI.parse _namespace_name "setPhrase" |> NamespacedName

    /// <summary>
    /// For definiteness, when a specific form is not the syntactic subject of the clause.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#shortArticle"></see></summary>
    let shortArticle =
        Namespaced_IRI.parse _namespace_name "shortArticle" |> NamespacedName

    /// <summary>
    /// A variant of a multiword term or lexeme that includes fewer words than the full form.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#shortForm"></see></summary>
    let shortForm = Namespaced_IRI.parse _namespace_name "shortForm" |> NamespacedName

    /// <summary>
    /// A linking element used to identify a relation between a short form and its full or expanded form.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#shortFormFor"></see></summary>
    let shortFormFor =
        Namespaced_IRI.parse _namespace_name "shortFormFor" |> NamespacedName

    /// <summary>
    /// The form of a term or word (usually of a noun) used to designate one object. // Value that expresses one element.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#singular"></see></summary>
    let singular = Namespaced_IRI.parse _namespace_name "singular" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#singularNumberForm"></see>
    /// </summary>
    let singularNumberForm =
        Namespaced_IRI.parse _namespace_name "singularNumberForm" |> NamespacedName

    /// <summary>
    /// An inventory item identified by a unique alphanumeric designation assigned to an object in an inventory control system.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#sku"></see></summary>
    let sku = Namespaced_IRI.parse _namespace_name "sku" |> NamespacedName

    /// <summary>
    /// An extremely informal register of a word, term, or text that is used in spoken and everyday language and less commonly in documents.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#slangRegister"></see></summary>
    let slangRegister =
        Namespaced_IRI.parse _namespace_name "slangRegister" |> NamespacedName

    /// <summary>
    /// Case related to the person in whose company the action is carried out, or to any belongings of people which take part in the action.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#sociativeCase"></see></summary>
    let sociativeCase =
        Namespaced_IRI.parse _namespace_name "sociativeCase" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#sociativeCaseForm"></see>
    /// </summary>
    let sociativeCaseForm =
        Namespaced_IRI.parse _namespace_name "sociativeCaseForm" |> NamespacedName

    /// <summary>
    /// usage marker which identifies the use of a given lexical unit by particular social groups and/or in certain types of communicative situations depending on their level of formality
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#socioCultural"></see></summary>
    let socioCultural =
        Namespaced_IRI.parse _namespace_name "socioCultural" |> NamespacedName

    /// <summary>
    /// A fixed chunk of recurring text.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#standardText"></see></summary>
    let standardText =
        Namespaced_IRI.parse _namespace_name "standardText" |> NamespacedName

    /// <summary>
    /// A term that has been standardized by a standardizing body.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#standardizedTerm"></see></summary>
    let standardizedTerm =
        Namespaced_IRI.parse _namespace_name "standardizedTerm" |> NamespacedName

    /// <summary>
    /// A chunk of text used in a software interface, documentation, help file, or the like.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#string"></see></summary>
    let string = Namespaced_IRI.parse _namespace_name "string" |> NamespacedName

    /// <summary>
    /// A type value assigned to a string.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#stringCategory"></see></summary>
    let stringCategory =
        Namespaced_IRI.parse _namespace_name "stringCategory" |> NamespacedName

    /// <summary>
    /// Mood often used to express uncertainty, whishes or desires.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#subjunctive"></see></summary>
    let subjunctive =
        Namespaced_IRI.parse _namespace_name "subjunctive" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#subjunctiveClause"></see>
    /// </summary>
    let subjunctiveClause =
        Namespaced_IRI.parse _namespace_name "subjunctiveClause" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#subjunctiveMoodForm"></see>
    /// </summary>
    let subjunctiveMoodForm =
        Namespaced_IRI.parse _namespace_name "subjunctiveMoodForm" |> NamespacedName

    /// <summary>
    /// Case for a move of something to the surface of another object.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#sublativeCase"></see></summary>
    let sublativeCase =
        Namespaced_IRI.parse _namespace_name "sublativeCase" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#sublativeCaseForm"></see>
    /// </summary>
    let sublativeCaseForm =
        Namespaced_IRI.parse _namespace_name "sublativeCaseForm" |> NamespacedName

    /// <summary>
    /// Indicates what this is composed of
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#substanceHolonym"></see></summary>
    let substanceHolonym =
        Namespaced_IRI.parse _namespace_name "substanceHolonym" |> NamespacedName

    /// <summary>
    /// Indicates this is a substance that composes the other
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#substanceMeronym"></see></summary>
    let substanceMeronym =
        Namespaced_IRI.parse _namespace_name "substanceMeronym" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#suffix"></see>
    /// </summary>
    let suffix = Namespaced_IRI.parse _namespace_name "suffix" |> NamespacedName

    /// <summary>
    /// Case indicating location on top of something or on the surface of something.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#superessiveCase"></see></summary>
    let superessiveCase =
        Namespaced_IRI.parse _namespace_name "superessiveCase" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#superessiveCaseForm"></see>
    /// </summary>
    let superessiveCaseForm =
        Namespaced_IRI.parse _namespace_name "superessiveCaseForm" |> NamespacedName

    /// <summary>
    /// Value used in a comparison between more than two entities.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#superlative"></see></summary>
    let superlative =
        Namespaced_IRI.parse _namespace_name "superlative" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#superlativeDegreeForm"></see>
    /// </summary>
    let superlativeDegreeForm =
        Namespaced_IRI.parse _namespace_name "superlativeDegreeForm" |> NamespacedName

    /// <summary>
    /// A term that is no longer preferred or admitted.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#supersededTerm"></see></summary>
    let supersededTerm =
        Namespaced_IRI.parse _namespace_name "supersededTerm" |> NamespacedName

    /// <summary>
    /// A unit of spoken language that is next bigger than a speech sound and consists of one or more vowel sounds alone or of a syllabic consonant alone or of either with one or more consonant sounds preceding or following.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#syllable"></see></summary>
    let syllable = Namespaced_IRI.parse _namespace_name "syllable" |> NamespacedName
    /// <summary>
    /// A character or glyph representing an idea, concept or object
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#symbol"></see></summary>
    let symbol = Namespaced_IRI.parse _namespace_name "symbol" |> NamespacedName
    /// <summary>
    /// Indicates the the terms have the same meaning lexicographically
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#synonym"></see></summary>
    let synonym = Namespaced_IRI.parse _namespace_name "synonym" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#tabooRegister"></see>
    /// </summary>
    let tabooRegister =
        Namespaced_IRI.parse _namespace_name "tabooRegister" |> NamespacedName

    /// <summary>
    /// The register appropriate to scientific texts or special languages.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#technicalRegister"></see></summary>
    let technicalRegister =
        Namespaced_IRI.parse _namespace_name "technicalRegister" |> NamespacedName

    /// <summary>
    /// An attribution of a term or lexeme with respect to its use over time.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#temporalQualifier"></see></summary>
    let temporalQualifier =
        Namespaced_IRI.parse _namespace_name "temporalQualifier" |> NamespacedName

    /// <summary>
    /// Property referring to the way the grammar marks the time at which the action denoted by the verb took place.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#tense"></see></summary>
    let tense = Namespaced_IRI.parse _namespace_name "tense" |> NamespacedName

    /// <summary>
    /// Any logically significant portion of a larger term or lexeme.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#termElement"></see></summary>
    let termElement =
        Namespaced_IRI.parse _namespace_name "termElement" |> NamespacedName

    /// <summary>
    /// An attribute assigned to a lexeme or a term.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#termType"></see></summary>
    let termType = Namespaced_IRI.parse _namespace_name "termType" |> NamespacedName

    /// <summary>
    /// Case that indicates to what or where something ends.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#terminativeCase"></see></summary>
    let terminativeCase =
        Namespaced_IRI.parse _namespace_name "terminativeCase" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#terminativeCaseForm"></see>
    /// </summary>
    let terminativeCaseForm =
        Namespaced_IRI.parse _namespace_name "terminativeCaseForm" |> NamespacedName

    /// <summary>
    /// usage marker which identifies the typical use of a lexical unit in a particular discourse type or genre
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#textType"></see></summary>
    let textType = Namespaced_IRI.parse _namespace_name "textType" |> NamespacedName

    /// <summary>
    /// Third person deixis is deictic reference to a referent(s) not identified as the speaker or addressee.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#thirdPerson"></see></summary>
    let thirdPerson =
        Namespaced_IRI.parse _namespace_name "thirdPerson" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#thirdPersonForm"></see>
    /// </summary>
    let thirdPersonForm =
        Namespaced_IRI.parse _namespace_name "thirdPersonForm" |> NamespacedName

    /// <summary>
    /// A form of a term or lexeme resulting from an operation whereby the characters of one writing system are represented by characters from another writing system, taking into account the pronunciation of the characters converted.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#transcribedForm"></see></summary>
    let transcribedForm =
        Namespaced_IRI.parse _namespace_name "transcribedForm" |> NamespacedName

    /// <summary>
    /// Indicates that two terms are translations of one another; this is the same as interlingual synonymy
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#translation"></see></summary>
    let translation =
        Namespaced_IRI.parse _namespace_name "translation" |> NamespacedName

    /// <summary>
    /// The confidence in a given translation.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#translationConfidence"></see></summary>
    let translationConfidence =
        Namespaced_IRI.parse _namespace_name "translationConfidence" |> NamespacedName

    /// <summary>
    /// Case indicating that the referent of the noun, or the quality of the adjective, that it marks is the result of a process of change.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#translativeCase"></see></summary>
    let translativeCase =
        Namespaced_IRI.parse _namespace_name "translativeCase" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#translativeCaseForm"></see>
    /// </summary>
    let translativeCaseForm =
        Namespaced_IRI.parse _namespace_name "translativeCaseForm" |> NamespacedName

    /// <summary>
    /// Form resulting from the conversion of one writing system into another
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#transliteration"></see></summary>
    let transliteration =
        Namespaced_IRI.parse _namespace_name "transliteration" |> NamespacedName

    /// <summary>
    /// Grammatical number referring to 'three things', as opposed to 'singular' and 'plural'.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#trial"></see></summary>
    let trial = Namespaced_IRI.parse _namespace_name "trial" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#trialNumberForm"></see>
    /// </summary>
    let trialNumberForm =
        Namespaced_IRI.parse _namespace_name "trialNumberForm" |> NamespacedName

    /// <summary>
    /// aspect that expresses an event or state that is not finished.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#unaccomplished"></see></summary>
    let unaccomplished =
        Namespaced_IRI.parse _namespace_name "unaccomplished" |> NamespacedName

    /// <summary>
    /// A note containing information on the usage of the associated word or term.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#usageNote"></see></summary>
    let usageNote = Namespaced_IRI.parse _namespace_name "usageNote" |> NamespacedName
    /// <summary>
    /// Element which, singly or in combination with other verbs is used as the minimal predicate of a sentence, co-occurring with a subject. If the predicate contains other elements (e.g. object, complement), then it is the verb which more than any other is the unit which influences the choice and extent of these elements.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#verb"></see></summary>
    let verb = Namespaced_IRI.parse _namespace_name "verb" |> NamespacedName

    /// <summary>
    /// One of a set of distinctive forms that are used to signal modality. Modality is a facet of illocutionary point or general intent of a speaker, or a speaker's degree of commitment to the expressed proposition's believability, obligatoriness, desirability or reality.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#verbFormMood"></see></summary>
    let verbFormMood =
        Namespaced_IRI.parse _namespace_name "verbFormMood" |> NamespacedName

    /// <summary>
    /// Case used to indicate direct address.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#vocativeCase"></see></summary>
    let vocativeCase =
        Namespaced_IRI.parse _namespace_name "vocativeCase" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#vocativeCaseForm"></see>
    /// </summary>
    let vocativeCaseForm =
        Namespaced_IRI.parse _namespace_name "vocativeCaseForm" |> NamespacedName

    /// <summary>
    /// Way sentences may alter the relationship between the subject and object of a verb, without changing the meaning of the sentence.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#voice"></see></summary>
    let voice = Namespaced_IRI.parse _namespace_name "voice" |> NamespacedName

    /// <summary>
    /// Register of a term or text type that can be characterized as profane or socially unacceptable. // The register of a term or text type that can be characterized as profane or socially unacceptable.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#vulgarRegister"></see></summary>
    let vulgarRegister =
        Namespaced_IRI.parse _namespace_name "vulgarRegister" |> NamespacedName

    /// <summary>
    /// Any lexeme element in a compound lexical unit that is itself a word.
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#wordElement"></see></summary>
    let wordElement =
        Namespaced_IRI.parse _namespace_name "wordElement" |> NamespacedName

    /// <summary>
    /// Positive value
    /// <see href="http://www.lexinfo.net/ontology/3.0/lexinfo#yes"></see></summary>
    let yes = Namespaced_IRI.parse _namespace_name "yes" |> NamespacedName
