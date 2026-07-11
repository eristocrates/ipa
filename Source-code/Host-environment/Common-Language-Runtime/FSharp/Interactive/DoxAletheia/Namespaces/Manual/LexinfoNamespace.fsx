#load @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\RDFErgonomics.fsx"
open RDFErgonomics

module lexinfo =

    let _prefix = prefix_label "lexinfo"


    let AbbreviatedForm = _prefix "AbbreviatedForm"



    let AccusativePostPositiveArg = _prefix "AccusativePostPositiveArg"



    let AdjectivalComplementFrame = _prefix "AdjectivalComplementFrame"



    let Adjective = _prefix "Adjective"



    let Adjective_i = _prefix "Adjective-i"



    let Adjective_na = _prefix "Adjective-na"



    let AdjectiveAccusativePostPositiveFrame =
        _prefix "AdjectiveAccusativePostPositiveFrame"



    let AdjectiveAttributiveFrame = _prefix "AdjectiveAttributiveFrame"



    let AdjectiveComparativeFrame = _prefix "AdjectiveComparativeFrame"



    let AdjectiveDativePostPositiveFrame = _prefix "AdjectiveDativePostPositiveFrame"



    let AdjectiveFrame = _prefix "AdjectiveFrame"



    let AdjectiveGenitivePostPositiveFrame =
        _prefix "AdjectiveGenitivePostPositiveFrame"



    let AdjectiveImpersonalFrame = _prefix "AdjectiveImpersonalFrame"



    let AdjectivePOS = _prefix "AdjectivePOS"



    let AdjectivePPFrame = _prefix "AdjectivePPFrame"



    let AdjectivePhrase = _prefix "AdjectivePhrase"



    let AdjectivePostPositiveFrame = _prefix "AdjectivePostPositiveFrame"


    /// Note this frame should be used when both attributive and predicative use of the adjective is allowed
    let AdjectivePredicateFrame = _prefix "AdjectivePredicateFrame"



    let AdjectivePredicativeFrame = _prefix "AdjectivePredicativeFrame"



    let AdjectiveScaleFrame = _prefix "AdjectiveScaleFrame"



    let AdjectiveSuperlativeFrame = _prefix "AdjectiveSuperlativeFrame"



    let Adjunct = _prefix "Adjunct"



    let Adposition = _prefix "Adposition"



    let AdpositionPOS = _prefix "AdpositionPOS"



    let AdpositionalObject = _prefix "AdpositionalObject"



    let Adverb = _prefix "Adverb"



    let AdverbPOS = _prefix "AdverbPOS"



    let AdverbialComplement = _prefix "AdverbialComplement"



    let AdverbialComplementFrame = _prefix "AdverbialComplementFrame"



    let AdverbialPronoun = _prefix "AdverbialPronoun"



    let AffirmativeParticle = _prefix "AffirmativeParticle"



    let AffixedPersonalPronoun = _prefix "AffixedPersonalPronoun"



    let AllusivePronoun = _prefix "AllusivePronoun"



    let Animacy = _prefix "Animacy"


    /// Indicates either the subject or object of the main clause may be the omitted argument of the subclause
    let ArbitraryControl = _prefix "ArbitraryControl"



    let Article = _prefix "Article"



    let ArticlePOS = _prefix "ArticlePOS"



    let Aspect = _prefix "Aspect"



    let AttributiveArg = _prefix "AttributiveArg"



    let Auxiliary = _prefix "Auxiliary"



    let Bullet = _prefix "Bullet"


    /// A lexical unit in a CJKV language that is represented by at least two CJKV characters.
    let CJK_compound = _prefix "CJK_compound"



    let CardinalNumeral = _prefix "CardinalNumeral"



    let Case = _prefix "Case"



    let Circumposition = _prefix "Circumposition"



    let ClausalArg = _prefix "ClausalArg"



    let Cliticness = _prefix "Cliticness"



    let CloseParenthesis = _prefix "CloseParenthesis"



    let CollectivePronoun = _prefix "CollectivePronoun"



    let Colon = _prefix "Colon"



    let Comma = _prefix "Comma"



    let CommonNoun = _prefix "CommonNoun"



    let ComparativeAdjunct = _prefix "ComparativeAdjunct"



    let ComparativeParticle = _prefix "ComparativeParticle"


    /// A noun phrase that follows a copula or similar verb, as for example an idiot in the sentence He is an idiot. - A clause that serves as the subject or direct object of a verb or the direct object of a preposition, as for example that he would be early in the sentence I hoped that he would be early
    let Complement = _prefix "Complement"



    let CompoundPreposition = _prefix "CompoundPreposition"



    let ConditionalParticle = _prefix "ConditionalParticle"



    let ConditionalPronoun = _prefix "ConditionalPronoun"



    let Conjunction = _prefix "Conjunction"



    let ConjunctionPOS = _prefix "ConjunctionPOS"


    /// Control indicates how a an argument from a main clause will be utilized in a subclause. This class includes both control structures and raising structures
    let Control = _prefix "Control"



    let CoordinatingConjunction = _prefix "CoordinatingConjunction"



    let CoordinationParticle = _prefix "CoordinationParticle"



    let Copula = _prefix "Copula"


    /// Used with copula constructions. This represents the subject/object in a copula construction. As such constructions are reversible this property is used instead of the usual verb subject/object. E,g.,
    ///
    /// Barack Obama is the president/The president is Barack Obama
    let CopulativeArg = _prefix "CopulativeArg"


    /// Indicates the subject of a copula construction. It is assumed that by using this the copula construction is not reversible e.g.,
    ///
    /// He is happy/*happy is him
    let CopulativeSubject = _prefix "CopulativeSubject"



    let Dating = _prefix "Dating"



    let DativePostPositiveArg = _prefix "DativePostPositiveArg"



    let DativeTransitiveFrame = _prefix "DativeTransitiveFrame"



    let DeclarativeClause = _prefix "DeclarativeClause"


    /// Declarative frames take a clause as an argument, this argument is marker with the declarative conjunction (&quot;that&quot; in English)
    let DeclarativeFrame = _prefix "DeclarativeFrame"



    let DeficientVerb = _prefix "DeficientVerb"



    let DefiniteArticle = _prefix "DefiniteArticle"



    let Definiteness = _prefix "Definiteness"



    let Degree = _prefix "Degree"



    let DemonstrativeDeterminer = _prefix "DemonstrativeDeterminer"



    let DemonstrativePronoun = _prefix "DemonstrativePronoun"



    let Determiner = _prefix "Determiner"



    let DeterminerPOS = _prefix "DeterminerPOS"



    let DiminutiveNoun = _prefix "DiminutiveNoun"


    /// relation between a phrase and a verb, in which the relation is central to the verb
    let DirectObject = _prefix "DirectObject"



    let DistinctiveParticle = _prefix "DistinctiveParticle"



    let DitransitiveDoubleAccusativeFrame = _prefix "DitransitiveDoubleAccusativeFrame"



    let DitransitiveFrame = _prefix "DitransitiveFrame"



    let DitransitiveFrame_For = _prefix "DitransitiveFrame_For"



    let DitransitiveFrame_To = _prefix "DitransitiveFrame_To"



    let EmphaticPronoun = _prefix "EmphaticPronoun"



    let ExclamativeDeterminer = _prefix "ExclamativeDeterminer"



    let ExclamativePoint = _prefix "ExclamativePoint"



    let ExclamativePronoun = _prefix "ExclamativePronoun"



    let ExistentialPronoun = _prefix "ExistentialPronoun"



    let Finiteness = _prefix "Finiteness"



    let Frequency = _prefix "Frequency"



    let FusedPreposition = _prefix "FusedPreposition"



    let FusedPrepositionDeterminer = _prefix "FusedPrepositionDeterminer"



    let FusedPrepositionPOS = _prefix "FusedPrepositionPOS"



    let FusedPrepositionPronoun = _prefix "FusedPrepositionPronoun"



    let FusedPronounAuxiliary = _prefix "FusedPronounAuxiliary"



    let FutureParticle = _prefix "FutureParticle"



    let Gender = _prefix "Gender"



    let GeneralAdverb = _prefix "GeneralAdverb"



    let GeneralizationWord = _prefix "GeneralizationWord"



    let GenericNumeral = _prefix "GenericNumeral"



    let GenitiveDitransitiveFrame = _prefix "GenitiveDitransitiveFrame"



    let GenitiveObject = _prefix "GenitiveObject"



    let GenitivePostPositiveArg = _prefix "GenitivePostPositiveArg"



    let GenitiveTransitiveFrame = _prefix "GenitiveTransitiveFrame"



    let GerundACFrame = _prefix "GerundACFrame"



    let GerundClause = _prefix "GerundClause"


    /// Indicates one of the arguments is a gerund clause
    let GerundFrame = _prefix "GerundFrame"



    let GerundOCFrame = _prefix "GerundOCFrame"



    let GerundSCFrame = _prefix "GerundSCFrame"



    let ImpersonalFrame = _prefix "ImpersonalFrame"



    let ImpersonalIntransitiveFrame = _prefix "ImpersonalIntransitiveFrame"



    let ImpersonalIntransitivePPFrame = _prefix "ImpersonalIntransitivePPFrame"



    let ImpersonalPronoun = _prefix "ImpersonalPronoun"



    let ImpersonalTransitiveFrame = _prefix "ImpersonalTransitiveFrame"



    let IndefiniteArticle = _prefix "IndefiniteArticle"



    let IndefiniteCardinalNumeral = _prefix "IndefiniteCardinalNumeral"



    let IndefiniteDeterminer = _prefix "IndefiniteDeterminer"



    let IndefiniteMultiplicativeNumeral = _prefix "IndefiniteMultiplicativeNumeral"



    let IndefiniteOrdinalNumeral = _prefix "IndefiniteOrdinalNumeral"



    let IndefinitePronoun = _prefix "IndefinitePronoun"


    /// An indirect object is a grammatical relation that is one means of expressing the semantic role of goal and other similar roles. It is proposed for languages in which the role is distinct from the direct object and the oblique object on the basis of multiple independent syntactic or morphological criteria, such as the following: - Having a particular case marking, commonly dative - Governing an agreement affix on the verb, such as person or number - Being distinct from oblique relations in that it may be relativized
    let IndirectObject = _prefix "IndirectObject"



    let InfinitiveClause = _prefix "InfinitiveClause"


    /// Infinitive frames take an infinitive clause as an argument
    let InfinitiveFrame = _prefix "InfinitiveFrame"



    let InfinitiveParticle = _prefix "InfinitiveParticle"



    let Infix = _prefix "Infix"



    let Interjection = _prefix "Interjection"



    let InterrogativeCardinalNumeral = _prefix "InterrogativeCardinalNumeral"



    let InterrogativeClause = _prefix "InterrogativeClause"



    let InterrogativeDeterminer = _prefix "InterrogativeDeterminer"


    /// Indicates the frame has a subframe indicated with the appropriate interrogative (e.g., &quot;who&quot;, &quot;where&quot;, &quot;how&quot;)
    let InterrogativeFrame = _prefix "InterrogativeFrame"



    let InterrogativeInfinitiveClause = _prefix "InterrogativeInfinitiveClause"


    /// Indicates the frame has an argument that is a clause with both an interrogative and the clause is in the infinitive form
    let InterrogativeInfinitiveFrame = _prefix "InterrogativeInfinitiveFrame"



    let InterrogativeMultiplicativeNumeral =
        _prefix "InterrogativeMultiplicativeNumeral"



    let InterrogativeOrdinalNumeral = _prefix "InterrogativeOrdinalNumeral"



    let InterrogativeParticle = _prefix "InterrogativeParticle"



    let InterrogativePronoun = _prefix "InterrogativePronoun"



    let InterrogativeRelativePronoun = _prefix "InterrogativeRelativePronoun"



    let IntransitiveAdjectivalComplementFrame =
        _prefix "IntransitiveAdjectivalComplementFrame"



    let IntransitiveAdverbialComplementFrame =
        _prefix "IntransitiveAdverbialComplementFrame"



    let IntransitiveDeclarativeFrame = _prefix "IntransitiveDeclarativeFrame"



    let IntransitiveFrame = _prefix "IntransitiveFrame"



    let IntransitiveInfinitiveACFrame = _prefix "IntransitiveInfinitiveACFrame"



    let IntransitiveInfinitiveRSFrame = _prefix "IntransitiveInfinitiveRSFrame"



    let IntransitiveInfinitiveSCFrame = _prefix "IntransitiveInfinitiveSCFrame"



    let IntransitiveInterrogativeFrame = _prefix "IntransitiveInterrogativeFrame"



    let IntransitiveInterrogativeInfinitiveFrame =
        _prefix "IntransitiveInterrogativeInfinitiveFrame"



    let IntransitiveNominalComplementFrame =
        _prefix "IntransitiveNominalComplementFrame"



    let IntransitivePPDeclarativeFrame = _prefix "IntransitivePPDeclarativeFrame"



    let IntransitivePPFrame = _prefix "IntransitivePPFrame"



    let IntransitiveSententialFrame = _prefix "IntransitiveSententialFrame"



    let InvertedComma = _prefix "InvertedComma"



    let IrreflexivePersonalPronoun = _prefix "IrreflexivePersonalPronoun"



    let Letter = _prefix "Letter"



    let LightVerb = _prefix "LightVerb"



    let MainVerb = _prefix "MainVerb"



    let Modal = _prefix "Modal"



    let ModificationType = _prefix "ModificationType"



    let Mood = _prefix "Mood"



    let MultiplicativeNumeral = _prefix "MultiplicativeNumeral"



    let Negative = _prefix "Negative"



    let NegativeParticle = _prefix "NegativeParticle"



    let NegativePronoun = _prefix "NegativePronoun"



    let NominalComplementFrame = _prefix "NominalComplementFrame"



    let NormativeAuthorization = _prefix "NormativeAuthorization"



    let Noun = _prefix "Noun"



    let NounFrame = _prefix "NounFrame"



    let NounPOS = _prefix "NounPOS"



    let NounPPFrame = _prefix "NounPPFrame"



    let NounPhrase = _prefix "NounPhrase"



    let NounPossessiveFrame = _prefix "NounPossessiveFrame"



    let NounPredicateFrame = _prefix "NounPredicateFrame"



    let Number = _prefix "Number"



    let Numeral = _prefix "Numeral"



    let NumeralFraction = _prefix "NumeralFraction"



    let NumeralPOS = _prefix "NumeralPOS"



    let Object = _prefix "Object"



    let ObjectComplement = _prefix "ObjectComplement"


    /// Indicates the object of the main clause is also the (omitted) object of the subclause
    let ObjectControl = _prefix "ObjectControl"



    let OpenParenthesis = _prefix "OpenParenthesis"



    let OrdinalAdjective = _prefix "OrdinalAdjective"



    let PPFrame = _prefix "PPFrame"



    let PartOfSpeech = _prefix "PartOfSpeech"



    let ParticipleAdjective = _prefix "ParticipleAdjective"



    let Particle = _prefix "Particle"



    let ParticlePOS = _prefix "ParticlePOS"



    let PartitiveArticle = _prefix "PartitiveArticle"



    let PastParticipleAdjective = _prefix "PastParticipleAdjective"



    let Person = _prefix "Person"



    let PersonalPronoun = _prefix "PersonalPronoun"



    let PlainVerb = _prefix "PlainVerb"



    let Point = _prefix "Point"



    let PossessiveAdjective = _prefix "PossessiveAdjective"



    let PossessiveAdjunct = _prefix "PossessiveAdjunct"



    let PossessiveDeterminer = _prefix "PossessiveDeterminer"



    let PossessiveInfinitiveClause = _prefix "PossessiveInfinitiveClause"



    let PossessiveParticle = _prefix "PossessiveParticle"



    let PossessivePronoun = _prefix "PossessivePronoun"



    let PossessiveRelativePronoun = _prefix "PossessiveRelativePronoun"


    /// Indicates an argument of an adjective indicated by post-positive modification. An example in english would be that "that is something interesting", where the adjective interesting post-postively modifies something
    let PostPositiveArg = _prefix "PostPositiveArg"



    let Postposition = _prefix "Postposition"



    let PredicativeAdjective = _prefix "PredicativeAdjective"



    let PredicativeAdjunct = _prefix "PredicativeAdjunct"



    let PredicativeAdverb = _prefix "PredicativeAdverb"



    let PredicativeNominative = _prefix "PredicativeNominative"



    let Prefix = _prefix "Prefix"



    let Preposition = _prefix "Preposition"



    let PrepositionFrame = _prefix "PrepositionFrame"



    let PrepositionPhrase = _prefix "PrepositionPhrase"



    let PrepositionalAdjunct = _prefix "PrepositionalAdjunct"



    let PrepositionalAdverb = _prefix "PrepositionalAdverb"


    /// Abstract frame for words that take a prepositional phrase as an argument
    let PrepositionalFrame = _prefix "PrepositionalFrame"



    let PrepositionalGerundClause = _prefix "PrepositionalGerundClause"



    let PrepositionalInterrogativeClause = _prefix "PrepositionalInterrogativeClause"



    let PrepositionalInterrogativeFrame = _prefix "PrepositionalInterrogativeFrame"



    let PrepositionalObject = _prefix "PrepositionalObject"



    let PrepositionalPhraseFrame = _prefix "PrepositionalPhraseFrame"



    let PresentParticipleAdjective = _prefix "PresentParticipleAdjective"



    let PresentativePronoun = _prefix "PresentativePronoun"



    let PronominalAdverb = _prefix "PronominalAdverb"



    let Pronoun = _prefix "Pronoun"



    let PronounPOS = _prefix "PronounPOS"



    let ProperNoun = _prefix "ProperNoun"



    let Punctuation = _prefix "Punctuation"



    let QualifierAdjective = _prefix "QualifierAdjective"



    let QuestionMark = _prefix "QuestionMark"



    let RaisableArgument = _prefix "RaisableArgument"



    let RaisableSubject = _prefix "RaisableSubject"


    /// Indicates the syntactic subject of the main clause is in fact the subject of the subclause. The main clause should then be interpreted as being impersonal.
    let RaisingSubject = _prefix "RaisingSubject"



    let ReciprocalFrame = _prefix "ReciprocalFrame"



    let ReciprocalPronoun = _prefix "ReciprocalPronoun"



    let ReferentType = _prefix "ReferentType"



    let ReflexiveDativeTransitiveFrame = _prefix "ReflexiveDativeTransitiveFrame"



    let ReflexiveDeterminer = _prefix "ReflexiveDeterminer"



    let ReflexiveDitransitiveFrame = _prefix "ReflexiveDitransitiveFrame"



    let ReflexiveFrame = _prefix "ReflexiveFrame"



    let ReflexiveObject = _prefix "ReflexiveObject"



    let ReflexivePersonalPronoun = _prefix "ReflexivePersonalPronoun"



    let ReflexivePossessivePronoun = _prefix "ReflexivePossessivePronoun"



    let ReflexiveReciprocalFrame = _prefix "ReflexiveReciprocalFrame"



    let ReflexiveTransitiveFrame = _prefix "ReflexiveTransitiveFrame"



    let ReflexiveTransitivePPFrame = _prefix "ReflexiveTransitivePPFrame"



    let Register = _prefix "Register"



    let RelationNoun = _prefix "RelationNoun"



    let RelativeDeterminer = _prefix "RelativeDeterminer"



    let RelativeParticle = _prefix "RelativeParticle"



    let RelativePronoun = _prefix "RelativePronoun"


    /// A root is the portion of a word that (a) is common to a set of derived or inflected forms, (b) is not further analyzable into meaningful elements, and (c) carries the principle portion of meaning of the words in which it functions (as defined by the SIL Glossary of Linguistic Terms, https://glossary.sil.org/term/root).
    let RootMorph = _prefix "RootMorph"



    let SemiColon = _prefix "SemiColon"



    let SententialClause = _prefix "SententialClause"


    /// Sentential frames take a clause as argument, no conjunction is used and the syntax of the clause is the same as a main clause
    let SententialFrame = _prefix "SententialFrame"


    /// A simulfix is a change or replacement of vowels or consonants (usually vowels) which changes the meaning of a word (as defined by the SIL Glossary of Linguistic Terms, https://glossary.sil.org/term/simulfix). Examples include umlaut in Germanic languages, e.g., in the formation of the English plural feet from the singular foot.
    let SimulfixMorph = _prefix "SimulfixMorph"



    let Slash = _prefix "Slash"


    /// A stem is the root or roots of a word, together with any derivational affixes, to which inflectional affixes are added (as defined by the SIL Glossary of Linguistic Terms, https://glossary.sil.org/term/stem). A stem consists minimally of a root, but may be analyzable into a root plus derivational morphemes.
    let StemMorph = _prefix "StemMorph"



    let StrongPersonalPronoun = _prefix "StrongPersonalPronoun"


    /// relation between a phrase and a verb, that represents the person or thing that performs the action or about which something is stated
    let Subject = _prefix "Subject"


    /// Indicates the subject of the main clause is the (omitted) subject of the subclause
    let SubjectControl = _prefix "SubjectControl"



    let SubjectlessFrame = _prefix "SubjectlessFrame"



    let SubjectlessIntransitiveFrame = _prefix "SubjectlessIntransitiveFrame"



    let SubjectlessIntransitivePPFrame = _prefix "SubjectlessIntransitivePPFrame"



    let SubjectlessTransitiveFrame = _prefix "SubjectlessTransitiveFrame"



    let SubjectlessTransitivePPFrame = _prefix "SubjectlessTransitivePPFrame"



    let SubjunctiveClause = _prefix "SubjunctiveClause"



    let SubordinatingConjunction = _prefix "SubordinatingConjunction"



    let Suffix = _prefix "Suffix"



    let SuperlativeAdjunct = _prefix "SuperlativeAdjunct"



    let SuperlativeParticle = _prefix "SuperlativeParticle"



    let SuspensionPoints = _prefix "SuspensionPoints"



    let Symbol = _prefix "Symbol"



    let SymbolPOS = _prefix "SymbolPOS"



    let TemporalQualifier = _prefix "TemporalQualifier"



    let Tense = _prefix "Tense"



    let TermElement = _prefix "TermElement"



    let TermType = _prefix "TermType"


    /// A transfix is a discontinuous affix that disrupts the base to which it is attached. The term is reserved for true single affixes, rather than combinations of an infix with an independent prefix or suffix. (Broselow, E., 2000. Transfixation. In G. Booij, et al. (eds.), Ein internationales Handbuch zur Flexion und Wortbildung. 1. Halbband. Mouton De Gruyter, New York, Berlin, p. 552-557.) Examples include discontinuous affixes inserted into a word root, as in root-and-pattern systems of several Semitic languages, e.g., in the Arabic word kitaba "writing" from the root k-t-b.
    let TransfixMorph = _prefix "TransfixMorph"



    let TransitiveAdjectivalComplementFrame =
        _prefix "TransitiveAdjectivalComplementFrame"



    let TransitiveAdverbialComplementFrame =
        _prefix "TransitiveAdverbialComplementFrame"



    let TransitiveDeclarativeFrame = _prefix "TransitiveDeclarativeFrame"



    let TransitiveFrame = _prefix "TransitiveFrame"



    let TransitiveInfinitiveACFrame = _prefix "TransitiveInfinitiveACFrame"



    let TransitiveInfinitiveOCFrame = _prefix "TransitiveInfinitiveOCFrame"



    let TransitiveInfinitiveSCFrame = _prefix "TransitiveInfinitiveSCFrame"



    let TransitiveInterrogativeFrame = _prefix "TransitiveInterrogativeFrame"



    let TransitiveInterrogativeInfinitiveFrame =
        _prefix "TransitiveInterrogativeInfinitiveFrame"



    let TransitiveNominalComplementFrame = _prefix "TransitiveNominalComplementFrame"



    let TransitivePPFrame = _prefix "TransitivePPFrame"



    let TransitiveSententialFrame = _prefix "TransitiveSententialFrame"



    let UnclassifiedParticle = _prefix "UnclassifiedParticle"



    let Verb = _prefix "Verb"



    let VerbFormMood = _prefix "VerbFormMood"



    let VerbFrame = _prefix "VerbFrame"



    let VerbPOS = _prefix "VerbPOS"



    let VerbPhrase = _prefix "VerbPhrase"



    let Voice = _prefix "Voice"



    let WeakPersonalPronoun = _prefix "WeakPersonalPronoun"


    /// A zero morph is a morph, consisting of no phonetic form, that is proposed in some analyses as an allomorph of a morpheme that is ordinarily realized by a morph having some phonetic form (as defined by the SIL Glossary of Linguistic Terms, https://glossary.sil.org/term/zero-morph). Examples include the English plural sheep along with the singular sheep.
    let ZeroMorph = _prefix "ZeroMorph"


    /// A term or lexeme resulting from the omission of any part of the full term or lexeme while designating the same concept.
    let abbreviatedForm = _prefix "abbreviatedForm"



    let abbreviation = _prefix "abbreviation"


    /// A linking element used to identify a relation between an abbreviation and its full or expanded form.
    let abbreviationFor = _prefix "abbreviationFor"


    /// Case that expresses the lack or absence of the referent of the noun it marks.
    let abessiveCase = _prefix "abessiveCase"



    let abessiveCaseForm = _prefix "abessiveCaseForm"


    /// Case used to typically indicate locative or instrumental function.
    let ablativeCase = _prefix "ablativeCase"



    let ablativeCaseForm = _prefix "ablativeCaseForm"


    /// Case for nouns in ergative-absolute languages that would generally be the subjects of intransitive verbs or the objects of transitive verbs in the translational equivalents of nominative-accusative languages such as English.
    let absolutiveCase = _prefix "absolutiveCase"



    let absolutiveCaseForm = _prefix "absolutiveCaseForm"


    /// Case used to indicate direct object.
    let accusativeCase = _prefix "accusativeCase"



    let accusativeCaseForm = _prefix "accusativeCaseForm"


    /// An abbreviation made up of the initial letters of the components of the full form of the designation or from syllables of the full form and pronounced syllabically.
    let acronym = _prefix "acronym"


    /// A linking element used to identify a relation between an acronym and its full or expanded form.
    let acronymFor = _prefix "acronymFor"


    /// Value that expresses the situation where the grammatical subject is also the semantic actor of the verb.
    let activeVoice = _prefix "activeVoice"


    /// Case which expresses the meaning of presence 'at' or 'near' a place.
    let adessiveCase = _prefix "adessiveCase"



    let adessiveCaseForm = _prefix "adessiveCaseForm"


    /// Case expressing &quot;to&quot; in Basque studies.
    let aditiveCase = _prefix "aditiveCase"



    let aditiveCaseForm = _prefix "aditiveCaseForm"


    /// Part of speech related to attributes of noun.
    let adjective = _prefix "adjective"


    /// Deverbal adjective in Japanese ending with the '-i' suffix in dictionary form
    let adjective_i = _prefix "adjective-i"


    /// Denominal adjectives in Japanese formed from a noun plus the particle 'na'
    let adjective_na = _prefix "adjective-na"



    let adjunct = _prefix "adjunct"


    /// A term rated according to the scale of a term acceptability rating as a synonym for a preferred term.
    let admittedTerm = _prefix "admittedTerm"


    /// Part of speech that occurs before/inside/after a complement composed of a noun phrase, noun, pronoun or clause that functions as a noun phrase and form a single structure with the complement to express its grammatical and semantic relation to another unit.
    let adposition = _prefix "adposition"



    let adpositionalObject = _prefix "adpositionalObject"


    /// Part of speech to refer to an heterogeneous group of words whose most frequent function is to specify the mode of action of the verb.
    let adverb = _prefix "adverb"



    let adverbialComplement = _prefix "adverbialComplement"


    /// ()
    let adverbialPronoun = _prefix "adverbialPronoun"


    /// Particle used to express affirmation.
    let affirmativeParticle = _prefix "affirmativeParticle"



    let affix = _prefix "affix"


    /// Personnal pronoun that is affixed, i.e. added as an affix to another word.
    let affixedPersonalPronoun = _prefix "affixedPersonalPronoun"


    /// Case which expresses the meaning of motion 'to' or 'towards' the referent it marks.
    let allativeCase = _prefix "allativeCase"



    let allativeCaseForm = _prefix "allativeCaseForm"


    /// Pronoun that refers to something characterized by allusions.
    let allusivePronoun = _prefix "allusivePronoun"


    /// The characteristic of a word indicating that in a given discourse community, its referent is considered to be alive or to possess a quality of volition or consciousness.
    let animacy = _prefix "animacy"


    /// Perceived as alive.
    let animate = _prefix "animate"


    /// A term or lexeme whose concept or sense constitutes the opposite of the concept represented by a second term or lexeme.
    let antonym = _prefix "antonym"


    /// A designation that represents an individual concept.
    let appellation = _prefix "appellation"


    /// Property used to qualify something similar but not exactly the same
    let approximate = _prefix "approximate"


    /// A synonym that differs in some minor way
    let approximateSynonym = _prefix "approximateSynonym"


    /// A term or lexeme no longer in ordinary use, though retained for special purposes.
    let archaicForm = _prefix "archaicForm"


    /// Term used in the grammatical classification of words referring to a subclass of determiners which displays a primary role in differentiating the uses of nouns.
    let article = _prefix "article"


    /// Category associated to verbs and referring to the way the grammar marks the duration or type of temporal activity.
    let aspect = _prefix "aspect"


    /// A relation between two concepts having a non-hierarchical thematic connection by virtue of experience.
    let associativeRelation = _prefix "associativeRelation"


    /// usage marker which identifies the speaker's subjective point of view, positive or negative, regarding the object referred to by a given lexical unit
    let attitude = _prefix "attitude"



    let attributiveArg = _prefix "attributiveArg"


    /// a verb that adds functional or grammatical meaning to the clause in which it appears, so as to express tense, aspect, modality, voice, emphasis, etc.
    let auxiliary = _prefix "auxiliary"


    /// The root form of a word or term that is used as the formal dictionary entry for the term.
    let baseElement = _prefix "baseElement"


    /// Register of terms used in applications-oriented as opposed to theoretical or academic levels of language. // The register of terms used in applications-oriented as opposed to theoretical or academic levels of language.
    let benchLevelRegister = _prefix "benchLevelRegister"


    /// Case that expresses that the referent of the noun it marks receives the benefit of the situation expressed by the clause.
    let benefactiveCase = _prefix "benefactiveCase"



    let benefactiveCaseForm = _prefix "benefactiveCaseForm"


    /// Linked to a particular element.
    let bound = _prefix "bound"


    /// Sign used to mark an item in a list.
    let bullet = _prefix "bullet"


    /// A word denoting a number.
    let cardinalNumeral = _prefix "cardinalNumeral"


    /// In a given sentence, the way in which the form of a word changes in order to express a relationship with one or several words of the sentence. The morphological modification may apply to nouns, pronouns noun phrase constituents, such as adjectives or numerals.
    let case = _prefix "case"


    /// A concept that is related to another concept by virtue of the fact that it plays a causative role with respect to that concept.
    let causallyRelatedConcept = _prefix "causallyRelatedConcept"


    /// Case which expresses that the referent of the noun it marks is the cause of the situation expressed by the clause.
    let causativeCase = _prefix "causativeCase"



    let causativeCaseForm = _prefix "causativeCaseForm"


    /// Aspect that expresses the cessation of an event or state.
    let cessative = _prefix "cessative"


    /// Adposition which consists of two parts which are positioned ahead and after the adpositional foci.
    let circumposition = _prefix "circumposition"



    let clausalArg = _prefix "clausalArg"


    /// An abbreviation formed by truncating a part of a simple term.
    let clippedTerm = _prefix "clippedTerm"


    /// A linking element used to identify a relation between a clipped term and its full or expanded form.
    let clippedTermFor = _prefix "clippedTermFor"


    /// Categorization of the different types of clitics
    let cliticness = _prefix "cliticness"


    /// End of a parenthesis pair.
    let closeParenthesis = _prefix "closeParenthesis"


    /// A collective number is a number referring to 'a set of things'. Languages that have this feature can use it to get a phrase like 'flock of sheeps' by using 'sheep' in collective number.
    let collective = _prefix "collective"



    let collectiveNumberForm = _prefix "collectiveNumberForm"


    /// A pronoun that refers to all elements of a set.
    let collectivePronoun = _prefix "collectivePronoun"


    /// Two terms that occur together far more frequently than chance
    let collocation = _prefix "collocation"


    /// Sign with two vertical points that is used in writing and printing to introduce an explanation, example or quotation.
    let colon = _prefix "colon"


    /// Case which expresses a meaning similar to 'along with' or 'accompagnied by'.
    let comitativeCase = _prefix "comitativeCase"



    let comitativeCaseForm = _prefix "comitativeCaseForm"


    /// Mark (,) used in writing to show a short pause or to separate items in a list.
    let comma = _prefix "comma"


    /// Indistinguished gender for epicenes.
    let commonGender = _prefix "commonGender"


    /// A synonym for an international scientific term that is used in general discourse in a given language.
    let commonName = _prefix "commonName"


    /// A noun or adjective denoting a class of objects. // Noun that signifies a non-specific member of a group.
    let commonNoun = _prefix "commonNoun"


    /// Said of a term that appears frequently.
    let commonlyUsed = _prefix "commonlyUsed"


    /// Comparative is the comparison where only two entites are involved.
    let comparative = _prefix "comparative"



    let comparativeAdjunct = _prefix "comparativeAdjunct"



    let comparativeDegreeForm = _prefix "comparativeDegreeForm"


    /// Particle used to compare.
    let comparativeParticle = _prefix "comparativeParticle"


    /// A noun phrase that follows a copula or similar verb, as for example an idiot in the sentence He is an idiot. - A clause that serves as the subject or direct object of a verb or the direct object of a preposition, as for example that he would be early in the sentence I hoped that he would be early
    let complement = _prefix "complement"


    /// A lexical unit that combines two or sometimes more different words, frequently such that the sense of the new lexical unit is not clearly derivable from the combination of its parts.
    let compound = _prefix "compound"


    /// Preposition that is a aggregation of words
    let compoundPreposition = _prefix "compoundPreposition"


    /// A conditional relation is a logical relation in which the illocutionary act employing one of a pair of propositions is expressed or implied to be true or in force if the other proposition is true.
    let conditional = _prefix "conditional"


    /// conditional particule
    let conditionalParticle = _prefix "conditionalParticle"


    /// conditional pronoun
    let conditionalPronoun = _prefix "conditionalPronoun"


    /// The confidence in a given relationship.
    let confidence = _prefix "confidence"


    /// Word that syntactically links words or constituents, and expresses a semantic relationship between them.
    let conjunction = _prefix "conjunction"


    /// A lexical unit formed by a shortening of a word, syllable, or word group by omission of a sound or letter.
    let contraction = _prefix "contraction"


    /// The full form that corresponds to a contracted form.
    let contractionFor = _prefix "contractionFor"


    /// A subordinate concept having the same nearest superordinate concept and same criterion of subdivision as some other concept in a given concept system.
    let coordinateConcept = _prefix "coordinateConcept"


    /// Conjunction that links constituents.
    let coordinatingConjunction = _prefix "coordinatingConjunction"


    /// particle for coordination
    let coordinationParticle = _prefix "coordinationParticle"


    /// Special word that combines the subject of a sentence and its description.
    let copula = _prefix "copula"


    /// Used with copula constructions. This represents the subject/object in a copula construction. As such constructions are reversible this property is used instead of the usual verb subject/object. E,g.,
    ///
    /// Barack Obama is the president/The president is Barack Obama
    let copulativeArg = _prefix "copulativeArg"


    /// Indicates the subject of a copula construction. It is assumed that by using this the copula construction is not reversible e.g.,
    ///
    /// He is happy/*happy is him
    let copulativeSubject = _prefix "copulativeSubject"


    /// Indication specifying whether the usage is old or modern.
    let dating = _prefix "dating"


    /// Case that expresses an indirect object relationship or a range of meaning similar to that covered by 'to' or 'for' in English; but there is a great deal of variation between languages in the way this case is used.
    let dativeCase = _prefix "dativeCase"



    let dativeCaseForm = _prefix "dativeCaseForm"



    let declarativeClause = _prefix "declarativeClause"


    /// verb lacking certain morphosyntactic properties
    let deficientVerb = _prefix "deficientVerb"


    /// Value referring to the capacity of identification of an entity.
    let definite = _prefix "definite"


    /// Article that allows the reference to a specific, identifiable entity (or class of entities).
    let definiteArticle = _prefix "definiteArticle"


    /// Property about the possiblity to identify an entity.
    let definiteness = _prefix "definiteness"


    /// Property concerning comparison.
    let degree = _prefix "degree"


    /// Case which expresses motion downward from the referent of the noun it marks.
    let delativeCase = _prefix "delativeCase"



    let delativeCaseForm = _prefix "delativeCaseForm"


    /// Determiner used to point to an entity in the situation or elsewhere in a sentence.
    let demonstrativeDeterminer = _prefix "demonstrativeDeterminer"


    /// Pronoun used to point to an entity in the situation or elsewhere in a sentence.
    let demonstrativePronoun = _prefix "demonstrativePronoun"


    /// A term rated according to the scale of a term acceptability rating as undesired.
    let deprecatedTerm = _prefix "deprecatedTerm"


    /// A form that is derived morphosyntactically from another form
    let derivedForm = _prefix "derivedForm"


    /// A description in general prose text of the issues that are indicated by the context. The description field can occur at many different places in a component and profile.
    let description = _prefix "description"


    /// Word or affix that belongs to a class of noun modifiers that expresses the reference, including quantity, of a noun.
    let determiner = _prefix "determiner"



    let dialectRegister = _prefix "dialectRegister"


    /// diminutive noun
    let diminutiveNoun = _prefix "diminutiveNoun"


    /// An unmarked case which covers the single argument of a one-place verb and the agent and patient arguments of a transitive verb.
    let directCase = _prefix "directCase"



    let directCaseForm = _prefix "directCaseForm"


    /// relation between a phrase and a verb, in which the relation is central to the verb
    let directObject = _prefix "directObject"


    /// distinctive particle
    let distinctiveParticle = _prefix "distinctiveParticle"


    /// usage marker which identifies the specialized field of knowledge in which a lexical unit is mainly used
    let domain = _prefix "domain"


    /// Form used in some languages to designate two persons or things. // The form used in some languages to designate two persons or things.
    let dual = _prefix "dual"



    let dualNumberForm = _prefix "dualNumberForm"


    /// Case which expresses the meaning of motion 'away from' from the referent of the noun it marks.
    let elativeCase = _prefix "elativeCase"



    let elativeCaseForm = _prefix "elativeCaseForm"


    /// An emphatic pronoun is a personal pronoun that is used to emphasize its referent.
    let emphaticPronoun = _prefix "emphaticPronoun"


    /// A term that heads a terminological entry.
    let entryTerm = _prefix "entryTerm"


    /// An expression used to represent a concept based on a statement that two mathematical expressions are, for instance, equal as identified by the equal sign (=), or assigned to one another by a similar sign.
    let equation = _prefix "equation"


    /// Case that expresses likeness or identity to the referent of the noun it marks. It can have meaning, such as: 'as', 'like', or 'in the capacity of'.
    let equativeCase = _prefix "equativeCase"



    let equativeCaseForm = _prefix "equativeCaseForm"


    /// Case assigned to the subject of a transitive verb as opposed to absolutive case.
    let ergativeCase = _prefix "ergativeCase"



    let ergativeCaseForm = _prefix "ergativeCaseForm"


    /// Case which expresses a state of being.
    let essiveCase = _prefix "essiveCase"



    let essiveCaseForm = _prefix "essiveCaseForm"


    /// Morpheme that has a particular status with regards to the word's etymology.
    let etymologicalRoot = _prefix "etymologicalRoot"


    /// Information on the origin of a word and the development of its meaning.
    let etymology = _prefix "etymology"


    /// Completely equal in every detail
    let exact = _prefix "exact"


    /// An example of the usage of a frame
    let example = _prefix "example"


    /// Determiner expressing an emotional utterance and marked with a strong intonation.
    let exclamativeDeterminer = _prefix "exclamativeDeterminer"


    /// Special sign (!) usually used in writing to mark exclamation.
    let exclamativePoint = _prefix "exclamativePoint"


    /// Pronoun marked with an emotional utterance and/or a strong intonation.
    let exclamativePronoun = _prefix "exclamativePronoun"


    /// pronoun that indicates the existence of something or someone
    let existentialPronoun = _prefix "existentialPronoun"


    /// A statement that describes and clarifies a concept and makes it understandable, but does not necessarily differentiate it from other concepts.
    let explanation = _prefix "explanation"


    /// A significant word or phrase.
    let expression = _prefix "expression"



    let facetiousRegister = _prefix "facetiousRegister"


    /// Of, relating to, or constituting the gender that ordinarily includes most words or grammatical forms referring to females.
    let feminine = _prefix "feminine"


    /// Property applied to a verb form that can occur on its own in an independent sentence.
    let finite = _prefix "finite"


    /// Property referring to finite and non-finite status of a verbal form.
    let finiteness = _prefix "finiteness"


    /// First person deixis is deictic reference that refers to the speaker, or both the speaker and referents grouped with the speaker
    let firstPerson = _prefix "firstPerson"



    let firstPersonForm = _prefix "firstPersonForm"



    let formCaseVariant = _prefix "formCaseVariant"



    let formDegreeVariant = _prefix "formDegreeVariant"



    let formMoodVariant = _prefix "formMoodVariant"



    let formNegativeVariant = _prefix "formNegativeVariant"



    let formNumberVariant = _prefix "formNumberVariant"



    let formPersonVariant = _prefix "formPersonVariant"



    let formTenseVariant = _prefix "formTenseVariant"



    let formalRegister = _prefix "formalRegister"


    /// Figures, symbols or the like used to express a concept briefly, such as a mathematical or chemical formula.
    let formula = _prefix "formula"


    /// The relative commonness with which a term occurs.
    let frequency = _prefix "frequency"


    /// usage marker which identifies the relative rate of occurrence of a lexical unit in a given textual context
    let frequencyUsage = _prefix "frequencyUsage"


    /// For definiteness, when a specific form is the syntactic subject of the clause.
    let fullArticle = _prefix "fullArticle"


    /// The complete presentation of a term or lexeme for which there is an abbreviated form.
    let fullForm = _prefix "fullForm"


    /// A linking element used to identify a relation between any full form of a term or lexical unit and its abbreviated form.
    let fullFormFor = _prefix "fullFormFor"


    /// Preposition that is the result of a morphological merge from at least two words.
    let fusedPreposition = _prefix "fusedPreposition"


    /// word resulting from the aggregation of a proposition and a determiner
    let fusedPrepositionDeterminer = _prefix "fusedPrepositionDeterminer"


    /// word resulting from the aggregation of a preposition and a pronoun
    let fusedPrepositionPronoun = _prefix "fusedPrepositionPronoun"


    /// word resulting from the aggregation of a pronoun and an auxiliary
    let fusedPronounAuxiliary = _prefix "fusedPronounAuxiliary"


    /// Verb tense that indicates action or state of being in the future.
    let future = _prefix "future"


    /// Particle used in order to express future.
    let futureParticle = _prefix "futureParticle"



    let futureTenseForm = _prefix "futureTenseForm"


    /// A grammatical category that indicates grammatical relationships between words in sentences.
    let gender = _prefix "gender"


    /// Adverb belonging to the general class of adverbs
    let generalAdverb = _prefix "generalAdverb"


    /// A word that does not carry its own meaning but generalizes the meaning of a neighboring word, adding the &quot;etc.&quot; sense.
    let generalizationWord = _prefix "generalizationWord"


    /// A numeral used to indicate the number of sets/kinds of objects.
    let genericNumeral = _prefix "genericNumeral"


    /// Case which expresses a possessive relationship (e.g. the boy's book) or some other similarly close connection (e.g. a summer's day).
    let genitiveCase = _prefix "genitiveCase"



    let genitiveCaseForm = _prefix "genitiveCaseForm"



    let genitiveObject = _prefix "genitiveObject"


    /// usage marker which identifies the place or region where a lexical unit is mainly used
    let geographic = _prefix "geographic"


    /// Description of a specific form used in a certain region as opposed to another form used in another region
    let geographicalVariant = _prefix "geographicalVariant"



    let gerundClause = _prefix "gerundClause"



    let gerundive = _prefix "gerundive"


    /// In TEI: A phrase or word used to provide a gloss or definition for some other word or phrase.
    /// In 1951: Any editorial comment.
    let gloss = _prefix "gloss"


    /// Indicates the head element of a phrase
    let head = _prefix "head"


    /// usage marker which cannot be classified otherwise
    let hint = _prefix "hint"


    /// Indicates that the referenced element is a part of this object
    let holonymTerm = _prefix "holonymTerm"


    /// A word that is spelled like another, but that has a different pronunciation, meaning, and/or origin. // Word that is written like another, but that has a different pronunciation, meaning, and/or origin.
    let homograph = _prefix "homograph"


    /// A word that is pronounced like another word and that can be spelled the same way (homograph) or can merely sound the same (homophone). // Word that sounds the same and is written the same as another word but is different in meaning.
    let homonym = _prefix "homonym"


    /// A word that is pronounced in the same way as another word but that is spelled differently. // Word that sounds like another word, but is different in writiing or meaning.
    let homophone = _prefix "homophone"


    /// A term with a broader meaning
    let hypernym = _prefix "hypernym"


    /// A term with a narrower meaning
    let hyponym = _prefix "hyponym"


    /// A group of words in a fixed order that have a particular meaning that is different from the meanings of each word understood on its own.
    let idiom = _prefix "idiom"


    /// Case which expresses the meaning of 'motion into' or 'direction towards' the referent of the noun it marks.
    let illativeCase = _prefix "illativeCase"



    let illativeCaseForm = _prefix "illativeCaseForm"


    /// Mood used to express an order.
    let imperative = _prefix "imperative"



    let imperativeMoodForm = _prefix "imperativeMoodForm"


    /// Verb tense that refers to action in the past that is incomplete or ongoing.
    let imperfect = _prefix "imperfect"



    let imperfectTenseForm = _prefix "imperfectTenseForm"


    /// Imperfective aspect is an aspect that expresses an event or state, with respect to its internal structure, instead of expressing it as a simple whole.
    let imperfective = _prefix "imperfective"


    /// Pronoun lacking person referent.
    let impersonalPronoun = _prefix "impersonalPronoun"


    /// Register of terms that are company-specific and not readily recognized outside this environment. // The register of terms that are company-specific and not readily recognized outside this environment.
    let inHouseRegister = _prefix "inHouseRegister"


    /// Perceived as not living.
    let inanimate = _prefix "inanimate"


    /// Aspect that expresses the beginning of an event or state.
    let inchoative = _prefix "inchoative"


    /// Value related to an entity in a situation where the identification of this entity is not clear cut.
    let indefinite = _prefix "indefinite"


    /// Article not capable of expressing identification.
    let indefiniteArticle = _prefix "indefiniteArticle"


    /// A word used to express imprecise quantity.
    let indefiniteCardinalNumeral = _prefix "indefiniteCardinalNumeral"


    /// Determiner not capable of identification.
    let indefiniteDeterminer = _prefix "indefiniteDeterminer"


    /// A word indicating imprecise number of times something happened.
    let indefiniteMultiplicativeNumeral = _prefix "indefiniteMultiplicativeNumeral"


    /// A word used to indicate imprecise rank of an object in a sequence.
    let indefiniteOrdinalNumeral = _prefix "indefiniteOrdinalNumeral"


    /// Pronoun that does not allow reference.
    let indefinitePronoun = _prefix "indefinitePronoun"


    /// Mood value used in the expression of statements and questions.
    let indicative = _prefix "indicative"



    let indicativeMoodForm = _prefix "indicativeMoodForm"


    /// Markup to express that there is not any pertinence.
    let indifferent = _prefix "indifferent"


    /// An indirect object is a grammatical relation that is one means of expressing the semantic role of goal and other similar roles. It is proposed for languages in which the role is distinct from the direct object and the oblique object on the basis of multiple independent syntactic or morphological criteria, such as the following: - Having a particular case marking, commonly dative - Governing an agreement affix on the verb, such as person or number - Being distinct from oblique relations in that it may be relativized
    let indirectObject = _prefix "indirectObject"


    /// Case which expresses the meaning of location or position within a place.
    let inessiveCase = _prefix "inessiveCase"



    let inessiveCaseForm = _prefix "inessiveCaseForm"


    /// Mood cited as unmarked or base form.
    let infinitive = _prefix "infinitive"



    let infinitiveClause = _prefix "infinitiveClause"


    /// Particle used to express infinitive.
    let infinitiveParticle = _prefix "infinitiveParticle"



    let infix = _prefix "infix"


    /// An element of language used to change the form of a word (noun, adjective) by declension, and (verbs) by conjugation.
    let inflectionElement = _prefix "inflectionElement"


    /// Said of a term that does not appear frequently.
    let infrequentlyUsed = _prefix "infrequentlyUsed"


    /// An abbreviation made up of the initial letters of the components of the full form of the designation or from syllables of the full form and pronounced letter by letter.
    let initialism = _prefix "initialism"


    /// A linking element used to identify a relation between an initialism and its full or expanded form.
    let initialismFor = _prefix "initialismFor"


    /// Case indicating that the referent of the noun it marks is the means of the accomplishment of the action expressed by the clause.
    let instrumentalCase = _prefix "instrumentalCase"



    let instrumentalCaseForm = _prefix "instrumentalCaseForm"


    /// Word or sound that expresses an emotion.
    let interjection = _prefix "interjection"


    /// A term that is part of an international scientific nomenclature as adopted by an appropriate scientific body.
    let internationalScientificTerm = _prefix "internationalScientificTerm"


    /// A term that has the same or nearly identical orthographic or phonemic form in many languages.
    let internationalism = _prefix "internationalism"


    /// An interrogative/relative word used to ask about quantity.
    let interrogativeCardinalNumeral = _prefix "interrogativeCardinalNumeral"



    let interrogativeClause = _prefix "interrogativeClause"


    /// Determiner used to express a question.
    let interrogativeDeterminer = _prefix "interrogativeDeterminer"



    let interrogativeInfinitiveClause = _prefix "interrogativeInfinitiveClause"


    /// An interrogative/relative word used to ask about the number of times something happened.
    let interrogativeMultiplicativeNumeral =
        _prefix "interrogativeMultiplicativeNumeral"


    /// An interrogative/relative word used to ask about numeric ranking.
    let interrogativeOrdinalNumeral = _prefix "interrogativeOrdinalNumeral"


    /// Particle used to express a question.
    let interrogativeParticle = _prefix "interrogativeParticle"


    /// Pronoun used to express a question.
    let interrogativePronoun = _prefix "interrogativePronoun"


    /// pronoun which may act as a relative pronoun or an interrogative one
    let interrogativeRelativePronoun = _prefix "interrogativeRelativePronoun"


    /// Inverted comma.
    let invertedComma = _prefix "invertedComma"



    let ironicRegister = _prefix "ironicRegister"


    /// personal pronoun which is not reflexive
    let irreflexivePersonalPronoun = _prefix "irreflexivePersonalPronoun"



    let languageSpecific = _prefix "languageSpecific"


    /// Case which expresses motion to a location.
    let lativeCase = _prefix "lativeCase"



    let lativeCaseForm = _prefix "lativeCaseForm"


    /// A term that is legally defined and used in legally binding documents.
    let legalTerm = _prefix "legalTerm"



    let letter = _prefix "letter"


    /// verb participating in a complex predication that has little semantic content of its own.
    let lightVerb = _prefix "lightVerb"


    /// Case that indicates a final location of action or a time of the action.
    let locativeCase = _prefix "locativeCase"



    let locativeCaseForm = _prefix "locativeCaseForm"


    /// An expression used to represent a concept based on mathematical or logical relations, such as statements of inequality, set relationships, boolean operations, and the like.
    let logicalExpression = _prefix "logicalExpression"


    /// Main verb in contrast to a modal or an auxiliary.
    let mainVerb = _prefix "mainVerb"


    /// Of, relating to, or constituting the gender that ordinarily includes most words or grammatical forms referring to males.
    let masculine = _prefix "masculine"


    /// Designation of a term or word that is not countable and cannot generally be used with the indefinite article or in the plural.
    let massNoun = _prefix "massNoun"



    let massNounNumberForm = _prefix "massNounNumberForm"


    /// usage marker which identifies a semantic extension of the sense of a given lexical unit
    let meaningType = _prefix "meaningType"


    /// Indicates the object is a member of this
    let memberHolonym = _prefix "memberHolonym"


    /// Indicates this is an element of the other
    let memberMeronym = _prefix "memberMeronym"


    /// Indicates this is a part of another concept
    let meronymTerm = _prefix "meronymTerm"


    /// Value for middle voice that expresses that the subject is both the agent and object, or that the subject is separate from the agent or that the receiver is the agent him/herself.
    let middleVoice = _prefix "middleVoice"


    /// Verb form that is usually used with another verb to express ideas such as possibilities, permission, or intention.
    let modal = _prefix "modal"


    /// Currently in use.
    let modern = _prefix "modern"


    /// Refers to the prenominal or postnominal positions of determiners which distinguish different forms.
    let modificationType = _prefix "modificationType"


    /// In TEI: contains information about the grammatical mood of verbs (e.g. indicative, subjunctive, imperative).
    let mood = _prefix "mood"


    /// Unit resulting from the division of words into their smallest meaningful parts.
    /// Note: moved to lexeme element from being an independent element; note that this is currently an independent element in 12620
    let morphologicalElement = _prefix "morphologicalElement"



    let morphosyntacticProperty = _prefix "morphosyntacticProperty"


    /// A word that expresses the number of times something happened.
    let multiplicativeNumeral = _prefix "multiplicativeNumeral"


    /// denotes the negation or the absence
    let negative = _prefix "negative"



    let negativeForm = _prefix "negativeForm"


    /// Particle used to express negation.
    let negativeParticle = _prefix "negativeParticle"


    /// Pronoun used in a context of a negation or for expressing a negation.
    let negativePronoun = _prefix "negativePronoun"


    /// Of, relating to, or constituting the gender that ordinarily includes most words or grammatical forms referring to objects that are not characterized as male or female.
    let neuter = _prefix "neuter"


    /// The register appropriate to general texts or discourse.
    let neutralRegister = _prefix "neutralRegister"


    /// Value for negation.
    let no = _prefix "no"


    /// Case used to indicate the subject of a verb.
    let nominativeCase = _prefix "nominativeCase"



    let nominativeCaseForm = _prefix "nominativeCaseForm"


    /// Property related for verb forms occurring on their own only in dependent clauses and lacking tense and mood contrasts.
    let nonFinite = _prefix "nonFinite"


    /// A term status qualifier assigned by an authoritative body, such as a standards body or a governmental entity with a regulatory function.
    let normativeAuthorization = _prefix "normativeAuthorization"


    /// usage marker which identifies the use of a given lexical unit which is in some aspect considered to be non-standard or incorrect
    let normativity = _prefix "normativity"


    /// A statement that provides further information on any part of a language resource entry.
    let note = _prefix "note"


    /// Part of speech used to express the name of a person, place, action or thing.
    let noun = _prefix "noun"


    /// The component of a multiword or multi-morphemic compound term that is determined or modified by the other components making up the term.
    let nucleus = _prefix "nucleus"


    /// Grammatical category for the variation in form of nouns, pronouns, and any words agreeing with them, depending on how many persons or things are referred to. // In many languages, the grammatical distinction that indicates the number of objects referred to by the term or word.
    let number = _prefix "number"


    /// Part of speech that expresses a number or the relation to a number.
    let numeral = _prefix "numeral"


    /// Word used to denote the denominator of a fraction.
    let numeralFraction = _prefix "numeralFraction"



    let object = _prefix "object"



    let objectComplement = _prefix "objectComplement"


    /// Case that is used when a noun is the object of a verb or a proposition, except for nominative and vocative case.
    let obliqueCase = _prefix "obliqueCase"



    let obliqueCaseForm = _prefix "obliqueCaseForm"


    /// A term or lexeme which is no longer in common use.
    let obsoleteForm = _prefix "obsoleteForm"


    /// Used in the past.
    let old = _prefix "old"


    /// Beginning of a pair of parenthesis.
    let openParenthesis = _prefix "openParenthesis"


    /// 1951: An optional part of a headword.
    /// 1951; examples? The question arises whether these are true options or whether the options reflect synonyms or hyponyms (e.g., barrage, barrage de retenue). The question is not whether 1951 should use this markup, but rather how to map this markup in a global environment.
    let optionalElement = _prefix "optionalElement"


    /// Adjective/numeral/number expressing a numeric ranking.
    let ordinalAdjective = _prefix "ordinalAdjective"


    /// Perceived as related to animacy, but without specific reference to the previous items.
    let otherAnimacy = _prefix "otherAnimacy"


    /// A grammatical category that indicates grammatical relationships between words in sentences.
    let otherGender = _prefix "otherGender"


    /// Designation used to classify number-related grammatical information that can differ from the standard European classifications cited above.
    let otherNumber = _prefix "otherNumber"



    let otherNumberForm = _prefix "otherNumberForm"


    /// A term or lexeme that has fallen from fashion, but the meaning of which is readily recognizable.
    let outdatedForm = _prefix "outdatedForm"


    /// Indicates a part of this object
    let partHolonym = _prefix "partHolonym"


    /// Indicates this a component of the other concept
    let partMeronym = _prefix "partMeronym"


    /// A unique alphanumeric designation assigned to an object in a manufacturing system.
    let partNumber = _prefix "partNumber"


    /// A category assigned to a word based on its grammatical and semantic properties. // Term used to describe how a particular word is used in a sentence.
    let partOfSpeech = _prefix "partOfSpeech"


    /// Term referring to a word derived from a verb and used as an adjective.
    let participle = _prefix "participle"


    /// Adjective based on a verb.
    let participleAdjective = _prefix "participleAdjective"


    /// Indicates that one lexical entry is the participle form of another, e.g., the adjective 'reassuring' is the participle of 'to reassure'
    let participleFormOf = _prefix "participleFormOf"


    /// Word that does not belong to one of the main classes of words, is invariable in form, and typically has grammatical or pragmatic meaning.
    let particle = _prefix "particle"


    /// Article expressing a part or quantity.
    let partitiveArticle = _prefix "partitiveArticle"


    /// Case that expresses the partial nature of the referent of the noun it marks, as opposed to expressing the whole unit or class of which the referent is a part.
    let partitiveCase = _prefix "partitiveCase"



    let partitiveCaseForm = _prefix "partitiveCaseForm"


    /// A relation between two concepts where one of the concepts constitutes the whole and the other concept a part of that whole.
    let partitiveRelation = _prefix "partitiveRelation"


    /// Term referring to a situation where the grammatical subject is typically the recipient or goal of the action denoted by the verb.
    let passiveVoice = _prefix "passiveVoice"


    /// Past tense is an absolute tense that refers to a time before the moment of utterance.
    let past = _prefix "past"


    /// Adjective based on a past participle.
    let pastParticipleAdjective = _prefix "pastParticipleAdjective"



    let pastTenseForm = _prefix "pastTenseForm"


    /// Number that specifies 'a few' things.
    let paucal = _prefix "paucal"



    let paucalNumberForm = _prefix "paucalNumberForm"


    /// Perfective aspect is an aspect that expresses a temporal view of an event or state as a simple whole, apart from the consideration of the internal structure of the time in which it occurs.
    let perfective = _prefix "perfective"


    /// Indication of grammatical person (1st, 2nd, 3rd, etc.) associated with a given inflected form.
    let person = _prefix "person"


    /// Property that refers to the person.
    let personal = _prefix "personal"


    /// Pronoun referring a person.
    let personalPronoun = _prefix "personalPronoun"


    /// Indicates that a term is the adjectival form of a word with a meaning of 'of or pertaining to X'
    let pertainsTo = _prefix "pertainsTo"


    /// Any group of two or more words that form a unit, the meaning of which frequently cannot be deduced based on the combined sense of the words making up the phrase.
    let phraseologicalUnit = _prefix "phraseologicalUnit"


    /// verb which has its own semantics
    let plainVerb = _prefix "plainVerb"


    /// The form of a term or word (usually of a noun) used to designate more than one object. // Value that expresses more than one element.
    let plural = _prefix "plural"



    let pluralNumberForm = _prefix "pluralNumberForm"


    /// Sign (.) used to expresses the end of a sentence or an abbreviation.
    let point = _prefix "point"


    /// Value used in a comparison relationship when no comparison is involved.
    let positive = _prefix "positive"



    let positiveDegreeForm = _prefix "positiveDegreeForm"



    let positiveForm = _prefix "positiveForm"


    /// Relative to the possession or association.
    let possessive = _prefix "possessive"


    /// An adjective derived from a noun and denoting possession by the object described by the noun.
    let possessiveAdjective = _prefix "possessiveAdjective"



    let possessiveAdjunct = _prefix "possessiveAdjunct"


    /// Determiner that expresses ownership.
    let possessiveDeterminer = _prefix "possessiveDeterminer"



    let possessiveInfinitiveClause = _prefix "possessiveInfinitiveClause"


    /// Particle expressing ownship.
    let possessiveParticle = _prefix "possessiveParticle"


    /// Pronoun that expresses ownership and relationships like ownership, such as kinship, and other forms of association.
    let possessivePronoun = _prefix "possessivePronoun"


    /// A relative pronoun whose antecedent is the possessor of the subject or object in the relative clause.
    let possessiveRelativePronoun = _prefix "possessiveRelativePronoun"


    /// Situation where the modifier is after the modified.
    let postModifier = _prefix "postModifier"


    /// Indicates an argument of an adjective indicated by post-positive modification. An example in english would be that "that is something interesting", where the adjective interesting post-postively modifies something
    let postPositiveArg = _prefix "postPositiveArg"


    /// Adposition that appears at the end of the noun phrase.
    let postposition = _prefix "postposition"


    /// Situation where the modifier is before the modified.
    let preModifier = _prefix "preModifier"



    let predicativeAdjective = _prefix "predicativeAdjective"



    let predicativeAdjunct = _prefix "predicativeAdjunct"



    let predicativeAdverb = _prefix "predicativeAdverb"



    let predicativeNominative = _prefix "predicativeNominative"


    /// A term rated according to the scale of a term acceptability rating as the primary term for a given concept.
    let preferredTerm = _prefix "preferredTerm"



    let prefix = _prefix "prefix"


    /// Adposition placed at the beginning of a noun phrase.
    let preposition = _prefix "preposition"



    let prepositionalAdjunct = _prefix "prepositionalAdjunct"


    /// adverb which is very similar in its form to a preposition
    let prepositionalAdverb = _prefix "prepositionalAdverb"



    let prepositionalGerundClause = _prefix "prepositionalGerundClause"



    let prepositionalInterrogativeClause = _prefix "prepositionalInterrogativeClause"



    let prepositionalObject = _prefix "prepositionalObject"


    /// Verb tense that indicates action or state of being in the present.
    let present = _prefix "present"


    /// Adjective based on a present participle.
    let presentParticipleAdjective = _prefix "presentParticipleAdjective"



    let presentTenseForm = _prefix "presentTenseForm"


    /// pronoun that identify the current locative or temporal situation
    let presentativePronoun = _prefix "presentativePronoun"


    /// The simple past or preterite as distinct from the perfect form, e.g,, "showed" not "shown"
    let preterite = _prefix "preterite"



    let preteriteTenseForm = _prefix "preteriteTenseForm"


    /// An attribute assigned to a term indicating that that term is the official designator for a product.
    let productName = _prefix "productName"


    /// Case for a noun or a pronoun that expresses motion within a place or a period of time needed for an event.
    let prolativeCase = _prefix "prolativeCase"



    let prolativeCaseForm = _prefix "prolativeCaseForm"


    /// adverb formed in replacement of a preposition and a pronoun
    let pronominalAdverb = _prefix "pronominalAdverb"


    /// Word used in place of a noun or a noun phrase.
    let pronoun = _prefix "pronoun"


    /// The representation of the manner by which a term or word is articulated.
    let pronunciation = _prefix "pronunciation"


    /// A noun or adjective denoting a single object. // Noun that is the name of a specific individual, place, or object.
    let properNoun = _prefix "properNoun"


    /// A brief popular axiom or saying.
    let proverb = _prefix "proverb"


    /// Graphical mark used either at word level to indicate an abbreviation or at a text level to separate phrases or sentences.
    let punctuation = _prefix "punctuation"


    /// Property related to four elements.
    let quadrial = _prefix "quadrial"



    let quadrialNumberForm = _prefix "quadrialNumberForm"


    /// Adjective used to qualify.
    let qualifierAdjective = _prefix "qualifierAdjective"


    /// A term that is very similar but with some differences
    let quasiEquivalent = _prefix "quasiEquivalent"


    /// Sign used to express a question.
    let questionMark = _prefix "questionMark"


    /// A basic identifiable component of every CJKV character, often found on the left side of the character, that sometimes gives a rough indication of meaning and is used for collating lexical and terminological resources.
    let radical = _prefix "radical"


    /// Said of a term that is almost never used.
    let rarelyUsed = _prefix "rarelyUsed"


    /// Pronoun expressing mutual relationship.
    let reciprocalPronoun = _prefix "reciprocalPronoun"


    /// Type of concrete object or concept (the referent) that an expression represents (the reference).
    let referentType = _prefix "referentType"


    /// Determiner that refers to the same entity.
    let reflexiveDeterminer = _prefix "reflexiveDeterminer"



    let reflexiveObject = _prefix "reflexiveObject"


    /// personal pronoun which is reflexive
    let reflexivePersonalPronoun = _prefix "reflexivePersonalPronoun"


    /// A possessive pronoun that refers to the subject as the possessor.
    let reflexivePossessivePronoun = _prefix "reflexivePossessivePronoun"


    /// Classification indicating the relative level of language individually assigned to a lexeme or term or to a text type.
    let register = _prefix "register"


    /// A term defined by law or government regulation.
    let regulatedTerm = _prefix "regulatedTerm"


    /// A term connected to another term by a coordinate or associative relation.
    let relatedTerm = _prefix "relatedTerm"


    /// relation noun
    let relationNoun = _prefix "relationNoun"


    /// Determiner related to a referent.
    let relativeDeterminer = _prefix "relativeDeterminer"


    /// relative particle
    let relativeParticle = _prefix "relativeParticle"


    /// Pronoun which introduces a relative clause and refers to something that has been said before.
    let relativePronoun = _prefix "relativePronoun"


    /// Transcription or transliteration from non-Latin script into Latin script.
    let romanization = _prefix "romanization"


    /// base of a word
    let root = _prefix "root"


    /// Second person deixis is deictic reference to a person or persons identified as addressee.
    let secondPerson = _prefix "secondPerson"



    let secondPersonForm = _prefix "secondPersonForm"


    /// Specification of the pointers in time or sequence that indicates the segmentation process.
    let segmentation = _prefix "segmentation"


    /// Sign (;) usually used to separate phrases.
    let semiColon = _prefix "semiColon"


    /// Descriptive material that provides a sample of an object or entity defined in the entry.
    let senseExample = _prefix "senseExample"


    /// A label for this sense in another language
    let senseTranslation = _prefix "senseTranslation"



    let sententialClause = _prefix "sententialClause"


    /// A fixed, lexicalized phrase.
    let setPhrase = _prefix "setPhrase"


    /// For definiteness, when a specific form is not the syntactic subject of the clause.
    let shortArticle = _prefix "shortArticle"


    /// A variant of a multiword term or lexeme that includes fewer words than the full form.
    let shortForm = _prefix "shortForm"


    /// A linking element used to identify a relation between a short form and its full or expanded form.
    let shortFormFor = _prefix "shortFormFor"


    /// The form of a term or word (usually of a noun) used to designate one object. // Value that expresses one element.
    let singular = _prefix "singular"



    let singularNumberForm = _prefix "singularNumberForm"


    /// An inventory item identified by a unique alphanumeric designation assigned to an object in an inventory control system.
    let sku = _prefix "sku"


    /// An extremely informal register of a word, term, or text that is used in spoken and everyday language and less commonly in documents.
    let slangRegister = _prefix "slangRegister"


    /// The punctuation sign /
    let slash = _prefix "slash"


    /// Case related to the person in whose company the action is carried out, or to any belongings of people which take part in the action.
    let sociativeCase = _prefix "sociativeCase"



    let sociativeCaseForm = _prefix "sociativeCaseForm"


    /// usage marker which identifies the use of a given lexical unit by particular social groups and/or in certain types of communicative situations depending on their level of formality
    let socioCultural = _prefix "socioCultural"


    /// A fixed chunk of recurring text.
    let standardText = _prefix "standardText"


    /// A term that has been standardized by a standardizing body.
    let standardizedTerm = _prefix "standardizedTerm"


    /// A chunk of text used in a software interface, documentation, help file, or the like.
    let string = _prefix "string"


    /// A type value assigned to a string.
    let stringCategory = _prefix "stringCategory"


    /// Personal pronoun that can occupy the position after a preposition and/or reinforce a weak personal pronoun.
    let strongPersonalPronoun = _prefix "strongPersonalPronoun"


    /// relation between a phrase and a verb, that represents the person or thing that performs the action or about which something is stated
    let subject = _prefix "subject"


    /// Mood often used to express uncertainty, whishes or desires.
    let subjunctive = _prefix "subjunctive"



    let subjunctiveClause = _prefix "subjunctiveClause"



    let subjunctiveMoodForm = _prefix "subjunctiveMoodForm"


    /// Case for a move of something to the surface of another object.
    let sublativeCase = _prefix "sublativeCase"



    let sublativeCaseForm = _prefix "sublativeCaseForm"


    /// Conjunction that links constructions by making one of them a constituent of another. The subordinating conjunction typically marks the incorporated constituent.
    let subordinatingConjunction = _prefix "subordinatingConjunction"


    /// Indicates what this is composed of
    let substanceHolonym = _prefix "substanceHolonym"


    /// Indicates this is a substance that composes the other
    let substanceMeronym = _prefix "substanceMeronym"



    let suffix = _prefix "suffix"


    /// Case indicating location on top of something or on the surface of something.
    let superessiveCase = _prefix "superessiveCase"



    let superessiveCaseForm = _prefix "superessiveCaseForm"


    /// Value used in a comparison between more than two entities.
    let superlative = _prefix "superlative"



    let superlativeAdjunct = _prefix "superlativeAdjunct"



    let superlativeDegreeForm = _prefix "superlativeDegreeForm"


    /// Particle expressing superlative degree. Superlative is the comparison between more than two entities and contrasts with comparative where only two entities are involved and positive where no comparison is implied.
    let superlativeParticle = _prefix "superlativeParticle"


    /// A term that is no longer preferred or admitted.
    let supersededTerm = _prefix "supersededTerm"


    /// Sequence of three dots having the same meaning as &quot;et cetera&quot; (full form) or &quot;etc&quot; (abbreviated form).
    let suspensionPoints = _prefix "suspensionPoints"


    /// A unit of spoken language that is next bigger than a speech sound and consists of one or more vowel sounds alone or of a syllabic consonant alone or of either with one or more consonant sounds preceding or following.
    let syllable = _prefix "syllable"


    /// A character or glyph representing an idea, concept or object
    let symbol = _prefix "symbol"


    /// Indicates the the terms have the same meaning lexicographically
    let synonym = _prefix "synonym"



    let tabooRegister = _prefix "tabooRegister"


    /// The register appropriate to scientific texts or special languages.
    let technicalRegister = _prefix "technicalRegister"


    /// An attribution of a term or lexeme with respect to its use over time.
    let temporalQualifier = _prefix "temporalQualifier"


    /// Property referring to the way the grammar marks the time at which the action denoted by the verb took place.
    let tense = _prefix "tense"


    /// Any logically significant portion of a larger term or lexeme.
    let termElement = _prefix "termElement"


    /// An attribute assigned to a lexeme or a term.
    let termType = _prefix "termType"


    /// Case that indicates to what or where something ends.
    let terminativeCase = _prefix "terminativeCase"



    let terminativeCaseForm = _prefix "terminativeCaseForm"


    /// usage marker which identifies the typical use of a lexical unit in a particular discourse type or genre
    let textType = _prefix "textType"


    /// Third person deixis is deictic reference to a referent(s) not identified as the speaker or addressee.
    let thirdPerson = _prefix "thirdPerson"



    let thirdPersonForm = _prefix "thirdPersonForm"


    /// A form of a term or lexeme resulting from an operation whereby the characters of one writing system are represented by characters from another writing system, taking into account the pronunciation of the characters converted.
    let transcribedForm = _prefix "transcribedForm"


    /// Indicates that two terms are translations of one another; this is the same as interlingual synonymy
    let translation = _prefix "translation"


    /// The confidence in a given translation.
    let translationConfidence = _prefix "translationConfidence"


    /// Case indicating that the referent of the noun, or the quality of the adjective, that it marks is the result of a process of change.
    let translativeCase = _prefix "translativeCase"



    let translativeCaseForm = _prefix "translativeCaseForm"


    /// Form resulting from the conversion of one writing system into another
    let transliteration = _prefix "transliteration"


    /// Grammatical number referring to 'three things', as opposed to 'singular' and 'plural'.
    let trial = _prefix "trial"



    let trialNumberForm = _prefix "trialNumberForm"


    /// aspect that expresses an event or state that is not finished.
    let unaccomplished = _prefix "unaccomplished"


    /// Particle that is not covered by other sorts of particle definitions.
    let unclassifiedParticle = _prefix "unclassifiedParticle"


    /// A note containing information on the usage of the associated word or term.
    let usageNote = _prefix "usageNote"


    /// Element which, singly or in combination with other verbs is used as the minimal predicate of a sentence, co-occurring with a subject. If the predicate contains other elements (e.g. object, complement), then it is the verb which more than any other is the unit which influences the choice and extent of these elements.
    let verb = _prefix "verb"


    /// One of a set of distinctive forms that are used to signal modality. Modality is a facet of illocutionary point or general intent of a speaker, or a speaker's degree of commitment to the expressed proposition's believability, obligatoriness, desirability or reality.
    let verbFormMood = _prefix "verbFormMood"


    /// Case used to indicate direct address.
    let vocativeCase = _prefix "vocativeCase"



    let vocativeCaseForm = _prefix "vocativeCaseForm"


    /// Way sentences may alter the relationship between the subject and object of a verb, without changing the meaning of the sentence.
    let voice = _prefix "voice"


    /// Register of a term or text type that can be characterized as profane or socially unacceptable. // The register of a term or text type that can be characterized as profane or socially unacceptable.
    let vulgarRegister = _prefix "vulgarRegister"


    /// Personal pronoun that cannot occupy the position after a preposition and/or reinforce a strong personal pronoun.
    let weakPersonalPronoun = _prefix "weakPersonalPronoun"


    /// Any lexeme element in a compound lexical unit that is itself a word.
    let wordElement = _prefix "wordElement"


    /// Positive value
    let yes = _prefix "yes"
