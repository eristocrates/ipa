namespace http.purl.org.linguistics.gold.slash

open DoxAletheia

module gold =
    let _namespace_name = "http://purl.org/linguistics/gold/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// AbessiveCase expresses the lack or absence of the referent of the noun it marks. It has the meaning of the English preposition 'without' [Pei and Gaynor 1954: 3, 35].
    /// <see href="http://purl.org/linguistics/gold/AbessiveCase"></see></summary>
    let AbessiveCase = _prefix "AbessiveCase"
    /// <summary>
    /// CaseProperty is the class of properties that concerns the grammatical encoding of a noun's relationship (syntactic or semantic) to some other element in the sentence, such as a verb, noun, pronoun, or adposition [Pei and Gaynor 1954: 35; Crystal 1980: 53-54; Anderson 1985: 179-180; Andrews 1985: 7172; Kuno 1973: 45; Blake 2001].
    /// <see href="http://purl.org/linguistics/gold/CaseProperty"></see></summary>
    let CaseProperty = _prefix "CaseProperty"
    /// <summary>
    /// AbilitativeModality indicates the capacity of an agent to perform some action, regardless of type or condition. This is also known as the abilitive.
    /// <see href="http://purl.org/linguistics/gold/AbilitativeModality"></see></summary>
    let AbilitativeModality = _prefix "AbilitativeModality"
    /// <summary>
    /// ModalityProperty is the class of properties that concern the grammatical encoding of the status of the proposition itself, and not of the event to which the proposition refers, cf. AspectProperty. As a grammatical property, it represents those dimensions in the domains of knowledge (epistemic modality), social relations (deontic modality) and ability (abilitative modality), and possibly others. [Palmer 2001: 1, 7-10]
    /// <see href="http://purl.org/linguistics/gold/ModalityProperty"></see></summary>
    let ModalityProperty = _prefix "ModalityProperty"
    /// <summary>
    /// Ablative case denotes the source, agent, means, and occasionally also time or place of an an act or occurence. [Pei and Gaynor 1954: 3]
    /// <see href="http://purl.org/linguistics/gold/AblativeCase"></see></summary>
    let AblativeCase = _prefix "AblativeCase"
    /// <summary>
    /// A term used by some Mayanists to refer to an antipassive in which the patient or logical object is supressed or overtly absent. [Klaiman 1991: 232] Dayley states that the absolutive antipassive is used when the patient is unknown or irrelevant, or when the speaker does not wish to mention the patient, or to describe a transitive activity typically performed by some agent. The absolutive antipassive requires a non-specific implied patient, and no specific patient is ever semantically recoverable from the speech context. Only the absolutive antipassive has (as the name implies) absolutive function such that a transitive activity may be discussed without mention of the patient. [Dayley 1985: 345-350] This type of antipassive with an obligatorily unidentified object is also found in Mam, another Mayan language. [Cooreman 1994: 52-53]
    /// <see href="http://purl.org/linguistics/gold/AbsolutiveAntipassiveVoice"></see></summary>
    let AbsolutiveAntipassiveVoice = _prefix "AbsolutiveAntipassiveVoice"
    /// <summary>
    /// VoiceProperty is the class of properties that concern the grammatical encoding of the relationship between the verb and the nominals in a subject-predicate configuration. It selects a grammatically prominent syntactic constituent--subject--from the underlying semantic functions. In accusative language, the basic strategy is to select an agent as a subject [Shibatani 1988: 3]. It can be said that all voice systems mark the affectedness/nonaffectedness of sentential subjects [Klaiman 1988: 30].
    /// <see href="http://purl.org/linguistics/gold/VoiceProperty"></see></summary>
    let VoiceProperty = _prefix "VoiceProperty"
    /// <summary>
    /// AbsolutiveCase in ergative-absolutive languages marks referents that would generally be the subjects of intransitive verbs or the objects of transitive verbs in the translational equivalents of nominative-accusative languages [Anderson 1985: 181; Crystal 1985: 1; Andrews 1985: 138].
    /// <see href="http://purl.org/linguistics/gold/AbsolutiveCase"></see></summary>
    let AbsolutiveCase = _prefix "AbsolutiveCase"
    /// <summary>
    /// Properties or qualities as distinguished from any particular embodiment of the properties/ qualities in a physical medium. Instances of Abstract can be said to exist in the same sense as mathematical objects such as sets and relations, but they cannot exist at a particular place and time without some physical encoding or embodiment. [SUMO 2010]
    /// <see href="http://purl.org/linguistics/gold/Abstract"></see></summary>
    let Abstract = _prefix "Abstract"
    /// <summary>
    /// In Web Ontology Language, Thing is the superclass of all classes. The most basic concepts in a domain should correspond to classes that are the roots of various taxonomic trees. Every individual in the OWL world is a member of the class owl:Thing. Thus each user-defined class is implicitly a subclass of owl:Thing. Domain specific root classes are defined by simply declaring a named class. [Smith, Welty and McGuinness 2004]
    /// <see href="http://purl.org/linguistics/gold/Thing"></see></summary>
    let Thing = _prefix "Thing"
    /// <summary>
    /// AccusativeCase in nominative-accusative languages marks certain syntactic functions, usually direct objects [Hartmann and Stork 1972: 3, 156; Crystal 1980: 11, 246; Andrews 1985: 75; Anderson 1985: 181].
    /// <see href="http://purl.org/linguistics/gold/AccusativeCase"></see></summary>
    let AccusativeCase = _prefix "AccusativeCase"
    /// <summary>
    /// The class of properties concerning the acoustic nature of speech sounds. [Ladefoged 2000: 161]
    /// <see href="http://purl.org/linguistics/gold/AcousticProperty"></see></summary>
    let AcousticProperty = _prefix "AcousticProperty"
    /// <summary>
    /// The class of properties used to describe speech sounds. The properties given here are more or less taken directly from Ladefoged's later works, in particular, the taxonomies of Ladefoged [Ladefoged 1997].
    /// <see href="http://purl.org/linguistics/gold/PhoneticProperty"></see></summary>
    let PhoneticProperty = _prefix "PhoneticProperty"
    /// <summary>
    /// ActionalForce indicates that the speaker or hearer is to undertake some action. Actional force subsumes Imperative, Commissive and Hortatory force.
    /// <see href="http://purl.org/linguistics/gold/ActionalForce"></see></summary>
    let ActionalForce = _prefix "ActionalForce"
    /// <summary>
    /// ForceProperty is the class of properties that concern the grammatical encoding of the speech act associated with a proposition. Among the traditionally defined values are Declarative, Imperative and Interrogative. Force is here distinguished from Mood, but there is a close association of Mood with Force values, e.g. between IndicativeMood and DeclarativeForce.
    /// <see href="http://purl.org/linguistics/gold/ForceProperty"></see></summary>
    let ForceProperty = _prefix "ForceProperty"
    /// <summary>
    /// Associated with transitivity, when the action is performed by an agent (subject) on another participant (object) [McIntosh 1984: 108]. It refers to the category of underived verb forms associated with the basic diathesis [Shibatani 1995: 7].
    /// <see href="http://purl.org/linguistics/gold/ActiveVoice"></see></summary>
    let ActiveVoice = _prefix "ActiveVoice"
    /// <summary>
    /// AdessiveCase expresses that  the referent of the noun it marks is the location near/at which another referent exists. It has the meaning of 'at' or 'near' [Crystal 1997: 8].
    /// <see href="http://purl.org/linguistics/gold/AdessiveCase"></see></summary>
    let AdessiveCase = _prefix "AdessiveCase"
    /// <summary>
    /// An adjectival, or 'adjective', is a part of speech whose members modify nouns. An adjectival specifies the attributes of a noun referent. Note: this is one case among many. Adjectivals are a class of modifiers. An adjectival may be inflected as comparitive or superlative [Crystal 1997: 8; Payne 1997: 63].
    /// <see href="http://purl.org/linguistics/gold/Adjectival"></see></summary>
    let Adjectival = _prefix "Adjectival"
    /// <summary>
    /// Predicator is the class of syntactic words that are fundamentally relation inducing. That is, predicators license argument structure [Anderson 1997: 14]. Verbs are quintessential predicators, though other categories, such as determiners and some nouns, are also predicative in nature.
    /// <see href="http://purl.org/linguistics/gold/Predicator"></see></summary>
    let Predicator = _prefix "Predicator"
    /// <summary>
    /// A phrase with an adjective as a head. [Crystal 2003: 11] Adjective phrases may contain complements following the head, and modifiers in either pre-head or post-head position, but for the  most part, complements in adjective phrase structure are optional elements: they qualify as complements by virtue of being licensed by the head rather than  being obligatory. [Huddleston and Pullum 2002: 22-23, 57, 542]
    /// <see href="http://purl.org/linguistics/gold/AdjectivePhrase"></see></summary>
    let AdjectivePhrase = _prefix "AdjectivePhrase"
    /// <summary>
    /// Phrase is the class of syntactic constructions that consist of one or more syntactic words, but lack the subject-predicate organization of a clause. Phrases get their grammatical characteristics according to what word occupies the head position; thus, all phrases have heads. [Crystal 1980: 232-233;  Pei and Gaynor 1954: 169; Pike and Pike 1982: 453]
    /// <see href="http://purl.org/linguistics/gold/Phrase"></see></summary>
    let Phrase = _prefix "Phrase"
    /// <summary>
    /// A word or phrase which is used to extend the meaning of another word or phrase, but which is not one of the main structural elements of a sentence [Hartmann and Stork 1972: 5]. Adjunct clauses include subordinate clauses (i.e. those with overt subordinating conjunctions).
    /// <see href="http://purl.org/linguistics/gold/AdjunctSubordinate"></see></summary>
    let AdjunctSubordinate = _prefix "AdjunctSubordinate"
    /// <summary>
    /// A clause which does not constitute a complete sentence in itself, but must be connected with or attached to an independent clause. [Pei and Gaynor 1980: 206]
    /// <see href="http://purl.org/linguistics/gold/SubordinateClause"></see></summary>
    let SubordinateClause = _prefix "SubordinateClause"
    /// <summary>
    /// An adposition is a part of speech whose members are of a closed set and occur before or after a complement composed of a noun phrase, noun, pronoun, or clause that functions as a noun phrase and forms a single structure with the complement to express its grammatical and semantic relation to another unit within a clause [Comrie 1989: 91; Crystal 1997: 305; Payne 1997: 86].
    /// <see href="http://purl.org/linguistics/gold/Adposition"></see></summary>
    let Adposition = _prefix "Adposition"
    /// <summary>
    /// Functor is the class of syntactic word whose members are neither relation- nor argument-like non-relational [Anderson 1997: 20]. Typical functors include adpositions, subordinators, and complementizers.
    /// <see href="http://purl.org/linguistics/gold/Functor"></see></summary>
    let Functor = _prefix "Functor"
    /// <summary>
    /// An adverbial, or 'adverb', narrowly defined, is a part of speech whose members modify verbs for such categories as time, manner, place, or direction. An adverbal, broadly defined, is a part of speech whose members modify any constituent class of words other than nouns, such as verbs, adjectives, adverbs, phrases, clauses, or sentences. Under this definition, the possible type of modification depends on the class of the constituent being modified [Crystal 1997: 11; Payne 1997: 69].
    /// <see href="http://purl.org/linguistics/gold/Adverbial"></see></summary>
    let Adverbial = _prefix "Adverbial"
    /// <summary>
    /// Marks clauses as having some adverbial function, such as the expression of time, purpose, result, etc. In some languages, many of the words that serve as adverbializers also serve as prepositional or postpositional noun adjuncts. In some languages, an adverbializer in a subordinate clause may be optionally paired with another conjunction occurring in the main clause. There are also cases where an adverbializer in a subordinate clause is obligatorily paired with a conjunction in the main clause. [Schachter 1985: 51-52]
    /// An adverbializer is a subordinating connective that links a subordinate clause  to a main clause, and indicates that the subordinate clause has an adverbial or interpropositional relation  to the main clause, indicating purpose, condition, time, and location. [SIL International 2004]
    /// <see href="http://purl.org/linguistics/gold/Adverbializer"></see></summary>
    let Adverbializer = _prefix "Adverbializer"
    /// <summary>
    /// A subordinating connective is a connective that links constructions by making one of them a constituent of another. The subordinating conjunction typically marks the incorporated constituent. [Crystal 1997: 370]
    /// <see href="http://purl.org/linguistics/gold/SubordinatingConnective"></see></summary>
    let SubordinatingConnective = _prefix "SubordinatingConnective"
    /// <summary>
    /// An affix is a morpheme with an abstract meaning which can only be used when added to a root morpheme.  These are classified in four different ways, depending on their position with reference to the root: suffix, prefix, circumfix and infix. [Haspelmath 2002: 265; Crystal 1980: 17]
    /// <see href="http://purl.org/linguistics/gold/Affix"></see></summary>
    let Affix = _prefix "Affix"
    /// <summary>
    /// The smallest functioning unit in the composition of words, and the minimal distinctive unit of grammar.  Morphemes are commonly classified into free forms (morphemes which can occur as separate words) adn bound forms (morphemes which cannot so occur - mainly affixes).  A further distinction may be made between lexical and grammatical morphemes; the former are morphemes used for the construction of new words in a language; the latter are morphemes used to express grammatical relationships between a word and its context. [Crystal 2008: 300]
    /// <see href="http://purl.org/linguistics/gold/Morpheme"></see></summary>
    let Morpheme = _prefix "Morpheme"
    /// <summary>
    /// The object of the active retains its old case-marking in the passive, the subject of the active cannot appear in the passive clause, and the passive tends to be semantically active [Givon 1988: 419].
    /// <see href="http://purl.org/linguistics/gold/AgentDeletionPassiveVoice"></see></summary>
    let AgentDeletionPassiveVoice = _prefix "AgentDeletionPassiveVoice"
    /// <summary>
    /// Refers to the direction of the airstream in speech sound production. In the canonical literature, there are three airstream mechanisms: pulmonic, velaric, and glottalic. Glottalic airstream mechanism is sometimes used to describe the method of production of ejectives and implosives. Ladefoged and Maddieson prefer to regard implosives and ejectives as characterized by a laryngeal parameter of movement rather than an airstream property. [Ladefoged and Maddieson 1996: 372-373]
    /// <see href="http://purl.org/linguistics/gold/AirstreamProperty"></see></summary>
    let AirstreamProperty = _prefix "AirstreamProperty"
    /// <summary>
    /// The class of properties defining how sounds are produced in the mouth.  [Ladefoged
    /// <see href="http://purl.org/linguistics/gold/ArticulatoryProperty"></see></summary>
    let ArticulatoryProperty = _prefix "ArticulatoryProperty"
    /// <summary>
    /// AllativeCase expresses motion to or toward the referent of the noun it marks [Pei and Gaynor 1954: 6, 9, 216; Lyons 1968: 299; Crystal 1985: 1213].
    /// <see href="http://purl.org/linguistics/gold/AllativeCase"></see></summary>
    let AllativeCase = _prefix "AllativeCase"
    /// <summary>
    /// Characterizing sounds produced with the alveolar ridge as the passive articulator [Ladefoged 1997: 598].
    /// <see href="http://purl.org/linguistics/gold/Alveolar"></see></summary>
    let Alveolar = _prefix "Alveolar"
    /// <summary>
    /// Properties characterized by focusing on the upper passive articulator on the roof of the mouth [Ladefoged 1997: 597].
    /// <see href="http://purl.org/linguistics/gold/AnteriorProperty"></see></summary>
    let AnteriorProperty = _prefix "AnteriorProperty"
    /// <summary>
    /// A grammatical gender property assigned to a class of nouns with animate denotation. In a given language it may include larger or smaller numbers of nouns which do not meet this semantic criterion. The animate gender may occur in a two-gender system, with the other gender being labeled inanimate. However, the animate gender may also occur in larger inventories (i.e. greater than two values). Examples of these larger systems are found in Bantu languages (where nouns denoting humans are included in the animate gender) and in languages of Daghestan (where the animate gender is typically for non-human animates) [Corbett 1991: 20-32].
    /// <see href="http://purl.org/linguistics/gold/AnimateGender"></see></summary>
    let AnimateGender = _prefix "AnimateGender"
    /// <summary>
    /// GenderProperty is the class of properties that are assigned to nouns on the basis of their inherent properties by an AssignmentSystem and required by the syntax to appear on the target in an AgreementSystem. Gender may but need not be assigned on the basis of sex [Corbett 1991].
    /// <see href="http://purl.org/linguistics/gold/GenderProperty"></see></summary>
    let GenderProperty = _prefix "GenderProperty"
    /// <summary>
    /// 'Linguistic annotation' covers any descriptive or analytic notations applied to raw language data. The basic data may be in the form of time functions - audio, video and/or physiological recordings - or it may be textual. The added notations may include transcriptions of all sorts (from phonetic features to discourse structures), part-of-speech and sense tagging, syntactic analysis, 'named entity' identification, co-reference annotation, and so on. [Bird and Liberman 2000: 1]
    /// <see href="http://purl.org/linguistics/gold/AnnotationProperty"></see></summary>
    let AnnotationProperty = _prefix "AnnotationProperty"
    /// <summary>
    /// Properties of sounds produced with passive articulators either lying on the coronal axis, with the blade of the tongue raised from its neutral position, or in the neutral position (for non-coronal sounds).  [Crystal 1980: 94]
    /// <see href="http://purl.org/linguistics/gold/CoronalProperty"></see></summary>
    let CoronalProperty = _prefix "CoronalProperty"
    /// <summary>
    /// An intransitive verb is derived from a basically transitive one with the direct object of the transitive verb corresponding to the subject of the intransitive [Siewierska 1988: 267].
    /// <see href="http://purl.org/linguistics/gold/AntiCausativeVoice"></see></summary>
    let AntiCausativeVoice = _prefix "AntiCausativeVoice"
    /// <summary>
    /// In the antipassive construction, the patient-like argument is either suppressed (left implicit) or realized as an oblique complement, rather than as a direct object as would be the case in the basic two-place predicate transitive construction. The antipassive voice is most commonly found in ergative languages. In this case, the direct object, which is in the absolutive case in the transitive construction, is no longer marked as absolutive, but is marked as oblique or is supressed entirely. The agent-like argument, marked as ergative in a typical transitive construction, is instead marked as absolutive, making it appear like the agent of an intransitive construction. [Polinsky 2008]
    /// <see href="http://purl.org/linguistics/gold/AntiPassiveVoice"></see></summary>
    let AntiPassiveVoice = _prefix "AntiPassiveVoice"
    /// <summary>
    /// Characterizing sounds produced by the tip of the tongue [Ladefoged 1997: 596].
    /// <see href="http://purl.org/linguistics/gold/Apical"></see></summary>
    let Apical = _prefix "Apical"
    /// <summary>
    /// Properties characterized by focusing on the action of the lower, active articulator, i.e. which part of the tongue is used in articulation [Ladefoged 1997: 597].
    /// <see href="http://purl.org/linguistics/gold/ApicalityProperty"></see></summary>
    let ApicalityProperty = _prefix "ApicalityProperty"
    /// <summary>
    /// The applicative voice is a grammatical voice which promotes an oblique argument of a verb to the (core) patient argument, and indicates the oblique role within the meaning of the verb. Applicatives have a degree of overlap with causatives, and in some languages are realized identically; this isomorphism can be found in Kinyarwanda [Kimenyi 1980: 164], Yagua, Malay, and Dyirbal [Croft 1990: 242].
    ///
    /// While differing from true applicatives, a similar construction known as dative shifting occurs in other languages, including English. Two subtle differences between applicative and dative-shift constructions are: (1) applicatives involve some marking on the verb whereas dative-shift constructions do not; and (2) dative-shift constructions typically allow only recipients and benefactives to become direct objects whereas applicative constructions normally advance instruments and perhaps other obliques. [Payne 1997: 186-192]
    /// <see href="http://purl.org/linguistics/gold/ApplicativeVoice"></see></summary>
    let ApplicativeVoice = _prefix "ApplicativeVoice"
    /// <summary>
    /// This term is used to classify sounds based on their manner of articulation.  Sounds possessing this trait are those in which the involved articulators approach one another, but not close enough to produce audible friction. [Crystal 1980: 30]
    /// <see href="http://purl.org/linguistics/gold/Approximant"></see></summary>
    let Approximant = _prefix "Approximant"
    /// <summary>
    /// A general term used in Phonetics to refer to an articulation which restricts the airstream to some degree, ranging from a complete closure to a slight narrowing. [Crystal 2008: 456]
    /// <see href="http://purl.org/linguistics/gold/StrictureProperty"></see></summary>
    let StrictureProperty = _prefix "StrictureProperty"
    /// <summary>
    /// A labeling convention for gender categories. Arabic numerals are often used for languages for which there is a descriptive tradition involving use of the term 'noun class' instead of 'gender', in particular in languages of the Caucasus or Bantu languages; If the 'noun classes' are involved in agreement systems, they are gender systems. Arabic numerals may also be used in instances where another label is possible. For instance, in one language the gender to which nouns with human denotation are assigned might be called 'human', whereas in another language nouns with a similar denotation may be assigned to a gender with an arbitrary Arabic numerical label such as '1'. [Kibort and Corbett 2008a]
    /// <see href="http://purl.org/linguistics/gold/ArabicNumeralGender"></see></summary>
    let ArabicNumeralGender = _prefix "ArabicNumeralGender"
    /// <summary>
    /// An article is a member of a small class of determiners that identify a noun's definite or indefinite reference, and new or given status [Crystal 1997: 26].
    /// <see href="http://purl.org/linguistics/gold/Article"></see></summary>
    let Article = _prefix "Article"
    /// <summary>
    /// A Determiner is a part of speech whose members belong to a class of noun modifiers and express the reference, including  quantity, of a noun [Crystal 1997: 112].
    /// <see href="http://purl.org/linguistics/gold/Determiner"></see></summary>
    let Determiner = _prefix "Determiner"
    /// <summary>
    /// The term 'aspect'; designates the perspective taken on the internal temporal organization of the event, and different values of the Aspect Feature distinguish different ways of viewing the internal temporal constituency of the same event [Comrie 1976: 3ff], after [Holt 1943: 6; Bybee 2003: 157]. The 'event' is understood here as a general term covering any situation type (a state, activity, accomplishment, achievement, etc.) as expressed by the verb phrase of the construction. Unlike Tense Feature, which expresses event-external time and is deictic, Aspect Feature is event-internal and non-deictic, as it is not concerned with relating the time of the event to any other time point. [Kibort 2008e]
    /// <see href="http://purl.org/linguistics/gold/AspectProperty"></see></summary>
    let AspectProperty = _prefix "AspectProperty"
    /// <summary>
    /// A property whose values are not involved in agreement or government, but are inherent only. That is, the elements on which the values are found are not controllers of agreement. Because it is not involved in either agreement or government, a morphosemantic feature is not relevant to syntax. [Kibort 2008f]
    /// <see href="http://purl.org/linguistics/gold/MorphosemanticProperty"></see></summary>
    let MorphosemanticProperty = _prefix "MorphosemanticProperty"
    /// <summary>
    /// A sound is described as 'aspirated' when it has a greater rate of airflow than occurs in modal voice for a period of time before or after a stricture. It often accompanies a consonant which precedes a vowel, the beginning of which is unvoiced. [Ladefoged
    /// <see href="http://purl.org/linguistics/gold/Aspirated"></see></summary>
    let Aspirated = _prefix "Aspirated"
    /// <summary>
    /// A phonation type containing the features 'aspirated' and 'unaspirated. Aspiration involves matters of relativing timing between laryngeal and oral articulations, and the wider opening can be viewed as an aspect of the control of this timing. There are two ways of interpreting this greather width; it can be seen as the essential aspect of the production of voiceless aspiration, that is, aspiration is an extra-wide opening of the vocal folds [Kim 1965], or it can be seen as a by-product of the mechanism by which a delay between the offset of the oral and glottal gestures is achieved, that is, aspiration is esentially a matter of the timing between speech movements controlling laryngeal setting and oral articulation [Goldstein and Browman 1986]. [Ladefoged and Maddieson 1996: 49-66; 372]
    /// <see href="http://purl.org/linguistics/gold/GlottalTimingProperty"></see></summary>
    let GlottalTimingProperty = _prefix "GlottalTimingProperty"
    /// <summary>
    /// One of the three types of judgment common in languages, that indicates inference from what is generally known. English has the contrast between Deductive and Assumptive, as shown in: 'John must be in his office', 'John'll be in his office'. Schlichter comments that the speaker believes the case to be true…in the case of the Assumptive ‘because of his experience with similar situations, regular patterns, or repeated circumstances common in human life’. It is used when the speaker has prior knowledge about the state of things or about habitual or general 'behavior patterns', but 'only when no information about the state or event is being or has been received'. In that sense it is the negative member of the evidential system, used when no ready evidence is available. [Palmer 2001: 24-25; 30; 51]
    /// <see href="http://purl.org/linguistics/gold/AssumptiveEvidentiality"></see></summary>
    let AssumptiveEvidentiality = _prefix "AssumptiveEvidentiality"
    /// <summary>
    /// Evidentiality denotes the basis that the speaker has for claiming that the event has occurred (or is going to take place). Appear to show a greater number of distinctions in the realis mood (especially in the past tense) than the irrealis mood. [Bhat 1999: 63-64, 70]
    /// <see href="http://purl.org/linguistics/gold/EvidentialityProperty"></see></summary>
    let EvidentialityProperty = _prefix "EvidentialityProperty"
    /// <summary>
    /// A linguistic form for which there is evidence of present or past use. Attestation refers to something that is found in actual recorded usage, compared with the hypothetical predictions of grammar or the intuitive (but otherwise unsupported) observations of the linguist.[Crystal 2003: 41]
    /// <see href="http://purl.org/linguistics/gold/AttestedVariety"></see></summary>
    let AttestedVariety = _prefix "AttestedVariety"
    /// <summary>
    /// A term used in sociolinguistics and stylistics to refer to any system of linguistic expression whose use is governed by situational variables. In some cases, the situational distinctiveness of the language may be easily stated, as in many regional and occupational varieties; in other cases, as in studies of social class, the varieties are more difficult to define, involving the intersection of several variables. [Crystal 1997: 408]
    /// <see href="http://purl.org/linguistics/gold/HumanLanguageVariety"></see></summary>
    let HumanLanguageVariety = _prefix "HumanLanguageVariety"
    /// <summary>
    /// AuditoryEvidentiality encodes the fact that the speaker came to believe the content of the expression through direct auditory experience; they heard it. This does not include spoken reported accounts, but only direct sensory evidence, such as the situation of 'hearing a tree fall' [Palmer 2001: 38].
    /// <see href="http://purl.org/linguistics/gold/AuditoryEvidentiality"></see></summary>
    let AuditoryEvidentiality = _prefix "AuditoryEvidentiality"
    /// <summary>
    /// A special form of a noun that signals that the object being referred to is large relative to the usual size of such an object [Crystal 1980: 34].
    /// <see href="http://purl.org/linguistics/gold/AugmentativeSize"></see></summary>
    let AugmentativeSize = _prefix "AugmentativeSize"
    /// <summary>
    /// SizeProperty is a physical property with two values: large and small. Languages apparently do not encode a middle value of medium, at least not in the grammar. The marking of large size is traditionally called the augmentativem that for small size the diminutive. [Frawley 1992: 126]
    /// <see href="http://purl.org/linguistics/gold/SizeProperty"></see></summary>
    let SizeProperty = _prefix "SizeProperty"
    /// <summary>
    /// Auxiliary is a term used to describe verbs which are used in coordination with another verb to express mood, tense or aspect of the action denoted by the main verb.  Marginal auxiliaries share some of these properties, but not all. [Crystal 1985: 28; Pei
    /// <see href="http://purl.org/linguistics/gold/Auxiliary"></see></summary>
    let Auxiliary = _prefix "Auxiliary"
    /// <summary>
    /// A Verbal is a part of speech whose members typically signal events and actions; constitute, singly or in a phrase, a minimal  predicate in a  clause; govern the number and types of other constituents which may occur in the clause; and, in inflectional languages, may be inflected for tense, aspect, voice, modality, or agreement with other constituents in person, number, or grammatical gender  [Crystal 1997: 409; Givon 1984: 52; Payne 1997: 47].
    /// <see href="http://purl.org/linguistics/gold/Verbal"></see></summary>
    let Verbal = _prefix "Verbal"
    /// <summary>
    /// AversiveCase expresses fear or is literally translated as 'turning from' in some languages [Blake 2001: 156].
    /// <see href="http://purl.org/linguistics/gold/AversiveCase"></see></summary>
    let AversiveCase = _prefix "AversiveCase"
    /// <summary>
    /// A vowel sound produced with the tongue retracted towards the back of the oral cavity, e.g. [a:] as in English ‘calm’ or [u:] as in English ‘soon’. [Hartmann and Stork 1972: 25]
    /// <see href="http://purl.org/linguistics/gold/Back"></see></summary>
    let Back = _prefix "Back"
    /// <summary>
    /// A feature of vowel quality that correlates the difference between frequencies of formant two and formant one (overtones corresponding to a resonating frequency of the air in the vocal tract) [Ladefoged 2000: 215, 273]
    /// <see href="http://purl.org/linguistics/gold/BacknessProperty"></see></summary>
    let BacknessProperty = _prefix "BacknessProperty"
    /// <summary>
    /// The class of properties associated with sounds made with the body of the tongue [Ladefoged 1997: 601]. Almost all vowels can be described using subclasses of this property.
    /// <see href="http://purl.org/linguistics/gold/DorsalProperty"></see></summary>
    let DorsalProperty = _prefix "DorsalProperty"
    /// <summary>
    /// BenefactiveCase expresses that the referent of the noun it marks receives the benefit of the situation expressed by the clause [Crystal 1980: 43].
    /// <see href="http://purl.org/linguistics/gold/BenefactiveCase"></see></summary>
    let BenefactiveCase = _prefix "BenefactiveCase"
    /// <summary>
    /// Binary predicates define relationships between keywords. Each binary predicate is viewed as function: given the value of the first argument, it returns the set of values for the second argument that would make the predicate true. [Feldman and Hirsh 1996: 344] BinaryPredicators are the class of syntactic words that require two arguments.
    /// <see href="http://purl.org/linguistics/gold/BinaryPredicator"></see></summary>
    let BinaryPredicator = _prefix "BinaryPredicator"
    /// <summary>
    /// A bound morpheme (or bound form) is one which cannot occur on its own as a separate word, e.g. various affixes de-, -tion, -ize. [Crystal 2003: 56]
    /// <see href="http://purl.org/linguistics/gold/BoundMorpheme"></see></summary>
    let BoundMorpheme = _prefix "BoundMorpheme"
    /// <summary>
    /// With regard to classifications of vocal qualities, this refers to an effect produced by allowing a large amount of air to pass through the partially open glottis.  Some speakers have this as a permanent characteristic of their speech patterns. [Crystal 1985: 38]
    /// <see href="http://purl.org/linguistics/gold/Breathy"></see></summary>
    let Breathy = _prefix "Breathy"
    /// <summary>
    /// The three phonation types are part of the five possible values of Glottal Stricture that are used by languages. Sounds can have the vocal cords tightly together, as in a glottal stop, or they can be far apart as in voiceless sounds, or they can have one of the three phonation types: breathy voice, modal voice and creaky voice. Although some phoneticians have shown how terms similar to these may be combinable from the phonetic point of view, the named terms form a set of phonologically mutually exclusive possibilities. These factors point to there being an ordered set of five possibilities: [voiceless], [breathy], [modal voice], [creaky] and [closed]. It is certainly appropriate to consider these glottal states as resulting from two physiological attributes of the vocal cords, their stiffness and their aperture. However from a linguistic point of view, the named values of the feature Glottal Stricture operate as a linearly ordered set of five mutually exclusive possibilities. [Ladefoged 1997: 607-608]
    /// <see href="http://purl.org/linguistics/gold/GlottalStrictureProperty"></see></summary>
    let GlottalStrictureProperty = _prefix "GlottalStrictureProperty"
    /// <summary>
    /// A subclass of place properties roughly referring to positions inside the mouth [Ladefoged 1997: 606].
    /// <see href="http://purl.org/linguistics/gold/BuccalProperty"></see></summary>
    let BuccalProperty = _prefix "BuccalProperty"
    /// <summary>
    /// The superclass of properties that specify the location of the articulators [Ladefoged 1997: 594].
    /// <see href="http://purl.org/linguistics/gold/PlaceProperty"></see></summary>
    let PlaceProperty = _prefix "PlaceProperty"
    /// <summary>
    /// A cardinal numeral is a numeral of the class whose members are considered basic in form, are used in counting, and are used in expressing how many objects are referred to [Crystal 1997: 52].
    /// <see href="http://purl.org/linguistics/gold/CardinalNumeral"></see></summary>
    let CardinalNumeral = _prefix "CardinalNumeral"
    /// <summary>
    /// A numeral is a partOfSpeech whose members function most typically as adjectives or pronouns and express a number, or relation to the number, such as one of the following: quantity, sequence, frequency, fraction [Hartmann and Stork 1972: 155; Pei and Gaynor 1954: 149].
    /// <see href="http://purl.org/linguistics/gold/Numeral"></see></summary>
    let Numeral = _prefix "Numeral"
    /// <summary>
    /// MorphosyntacticFeature is the class of linguistic features that govern the grammatical behavior of morphosyntactic units. E.g., two morphosyntactic units can agree according to shared morphosyntactic features. Morphosyntactic features are also called grammatical categories. This class is intended to represent only the formal aspects of morphosyntax; that is, there is no notional component. In a grammatical system, such features occur in contrast to one another other, and are typically expressed in the same fashion. [Crystal 1985: 43-44; Hopper, P. 1992: 81; Bybee 1985: 191]
    /// <see href="http://purl.org/linguistics/gold/MorphosyntacticProperty"></see></summary>
    let MorphosyntacticProperty = _prefix "MorphosyntacticProperty"
    /// <summary>
    /// CategoryChanger is a cover class for all derivational units that change the syntactic category of the root to which they are attached.
    /// <see href="http://purl.org/linguistics/gold/CategoryChanger"></see></summary>
    let CategoryChanger = _prefix "CategoryChanger"
    /// <summary>
    /// DerivationalUnit is the class of functional units whose members function to derive a new lexical unit from an existing one, by systematically changing the meaning and possibly altering the part of speech feature of the root or stem it attaches to [Hartmann and Stork 1972: 62; Crystal 1985: 89; Bybee 1985: 81-82, 99].
    /// <see href="http://purl.org/linguistics/gold/DerivationalMorpheme"></see></summary>
    let DerivationalMorpheme = _prefix "DerivationalMorpheme"
    /// <summary>
    /// A construction can be classified as a morphological causative when there is specific morphological encoding of causativity within the verb. Moreover, a causative is associated with an additional core argument, a causer or causal agent, added to the set of core arguments assigned by the corresponding noncausative verb. [Klaiman 1991: 51]
    /// <see href="http://purl.org/linguistics/gold/CausativeVoice"></see></summary>
    let CausativeVoice = _prefix "CausativeVoice"
    /// <summary>
    /// Characterizing sounds produced with the tongue  near the center of the mouth (along the front-back dimension).
    /// <see href="http://purl.org/linguistics/gold/Central"></see></summary>
    let Central = _prefix "Central"
    /// <summary>
    /// A consonant articulated so that air passes out the center. [Ladefoged  2000: 155]
    /// <see href="http://purl.org/linguistics/gold/CentralEscape"></see></summary>
    let CentralEscape = _prefix "CentralEscape"
    /// <summary>
    /// Obstruction of the airstream at a point along the center of the oral tract, with complete closure between one or both sides of the tongue and the roof of the mouth. [Ladefoged 2000: 11]
    /// <see href="http://purl.org/linguistics/gold/LateralProperty"></see></summary>
    let LateralProperty = _prefix "LateralProperty"
    /// <summary>
    /// A symbol used in writing, distinguished from others by its meaning, not its specific shape; similar to grapheme. It relates to the domain of orthographies and writing. Specific to the implementation of computers and other information systems. [Lyons, et al. 2001]
    /// <see href="http://purl.org/linguistics/gold/Character"></see></summary>
    let Character = _prefix "Character"
    /// <summary>
    /// A discontinuous affix that occurs on both sides of the base.  [Haspelmath 2002: 267]
    /// <see href="http://purl.org/linguistics/gold/Circumfix"></see></summary>
    let Circumfix = _prefix "Circumfix"
    /// <summary>
    /// The action of citing or quoting any words or written passage from a publication that allows others to locate and identify the original source. Typical details include the title, author's name, the journal title (for articles), publication date and page numbers used in research. [Oxford English Dictionary 2010]
    ///
    /// Note: This concept was included in order to facilitate linking to the bibliographic entries referenced in GOLD.
    /// <see href="http://purl.org/linguistics/gold/Citation"></see></summary>
    let Citation = _prefix "Citation"
    /// <summary>
    /// This term refers to a set of entities, be they words, morphemes or otherwise, which share certain formal or semantic properties.  [Crystal 1980: 60]
    /// <see href="http://purl.org/linguistics/gold/Class"></see></summary>
    let Class = _prefix "Class"
    /// <summary>
    /// In grammar, a morpheme whose function is to indicate the formal or semantic class to which items belong are  sometimes called classifiers, e.g. -ly is an adverb classifier, -ess is a 'femininity' classifier. The marking of lexical items as belonging to the same semantic class is an important feature in many languages (e.g. Chinese, Vietnamese, Hopi), and sometimes quite unexpected bases of classification are found, in terms of shape, size, colour, movability, animacy, status and so on. [Crystal 2003: 74]
    /// <see href="http://purl.org/linguistics/gold/Classifier"></see></summary>
    let Classifier = _prefix "Classifier"
    /// <summary>
    /// The property that identifies the grammatical class of a word.  The main 'parts of speech' recognized by most school grammars derive from the work of the ancient Greek and Roman grammarians, primarily the noun, pronoun, verb, adverb, adjective, preposition, conjunction and interjection, with article, participle, and others often added.  Because of the inexplicitness with which these terms were traditionally defined and the restricted nature of their definitions, it has become preferable to use such terms as word-class or form-class, where the grouping is based on formal criteria of a more universally applicable kind. [Crystal 1997: 280]
    /// <see href="http://purl.org/linguistics/gold/PartOfSpeechProperty"></see></summary>
    let PartOfSpeechProperty = _prefix "PartOfSpeechProperty"
    /// <summary>
    /// A clause is a subdivision of a sentence containing a subject (argument) and predicate.  It is possible to have a word that implies or refers to a predicate rather than one explicitly stated. [Pei
    /// <see href="http://purl.org/linguistics/gold/Clause"></see></summary>
    let Clause = _prefix "Clause"
    /// <summary>
    /// SyntacticConstruction is the class of grammar units that have syntactic structure, i.e., consisting of more than one syntactic word or construction in a syntactic configuration [Crystal 1980: 85-86].
    /// <see href="http://purl.org/linguistics/gold/SyntacticConstruction"></see></summary>
    let SyntacticConstruction = _prefix "SyntacticConstruction"
    /// <summary>
    /// Clitic is the class of units which members exhibit syntactic characteristics of a lexical unit, but show evidence of being morphologically bound to another lexical unit, the host, by being unstressed or subject to word-level phonological rules [Crystal 1980: 64; Hartmann and Stork 1972: 38; Anderson 1985: 158; Klavans 1982: xi-xiv, 74-76, 83, 93-95, 100-101; Zwicky 1977: 5].
    /// <see href="http://purl.org/linguistics/gold/Clitic"></see></summary>
    let Clitic = _prefix "Clitic"
    /// <summary>
    /// In the classification of tongue movement when articulating vowel sounds, this refers to one produced with the tongue in the highest vertical position possible within the mouth without causing audible friction. [Crystal 1980: 64]
    /// <see href="http://purl.org/linguistics/gold/Close"></see></summary>
    let Close = _prefix "Close"
    /// <summary>
    /// Also called ImmediateFutureTense, this grammatical class names an upcoming situation which is to take place shortly after the moment of utterance [Dahl 1985: 121; Comrie 1985: 94; Bybee, Perkins and Pagliuca 1994: 244-245].
    /// <see href="http://purl.org/linguistics/gold/CloseFutureTense"></see></summary>
    let CloseFutureTense = _prefix "CloseFutureTense"
    /// <summary>
    /// Following [Comrie 1985: vii], we take tense to be the grammaticalisation of location in time. Tense Property is assigned to clauses on the basis of semantics: a tense value is selected for the clause from the range of tense values available in the given language. Tense Property is typically realised on the verb, but it may be found expressed multiply on different elements in the same clause. For example, tense may be found on more than one element of the verbal complex (e.g. in Kayardild [Evans 2003] or  Paamese [Crowley 2002: 68], or on verbs as well as on certain spatial and temporal adverbs and certain prepositions in the same clause (e.g. in Malagasy [Randriamasimanana 1981: 355-367],  [Keenan and Polinsky 1998: 566-567].
    ///
    /// In the given language, the values of the Tense Property are assigned to the designated elements as a consequence of semantic choice, and all the available options of particular tense values expressing particular tense meanings can be described with a Tense Assignment System for that language. Since no languages have been found for which tense values are assigned by a Tense Distribution System (i.e. contextually, through agreement or government), Tense Property is not a Morphosyntactic Property. Instead, it is a Morphosemantic Property only.
    /// <see href="http://purl.org/linguistics/gold/TenseProperty"></see></summary>
    let TenseProperty = _prefix "TenseProperty"
    /// <summary>
    /// A term referring to complex predicates comprised of two verbs; one of these is an auxiliary which contributes some form of meaning in the form of modality, direction, etc.  They serve a similar purpose to adpositions in Indo-European languages, and are almost always translated as such.  Some examples are found in some east and southeast Asian languages, as well as African languages and Hungarian.  [Yang and Kuo 1998: 20]
    /// <see href="http://purl.org/linguistics/gold/CoVerb"></see></summary>
    let CoVerb = _prefix "CoVerb"
    /// <summary>
    /// ComitativeCase expresses accompaniment. It carries the meaning 'with' or 'accompanied by' [Anderson 1985: 186; Pei and Gaynor 1954: 42; Dixon, R. 1972: 12].
    /// <see href="http://purl.org/linguistics/gold/ComitativeCase"></see></summary>
    let ComitativeCase = _prefix "ComitativeCase"
    /// <summary>
    /// CommisiveForce indicates that the speaker promises or threatens to perform some action [Palmer 2001: 10, 72].
    /// <see href="http://purl.org/linguistics/gold/CommissiveForce"></see></summary>
    let CommissiveForce = _prefix "CommissiveForce"
    /// <summary>
    /// CommonNouns refer to a class of objects, places, ideas, and so on.  This is in contrast with ProperNoun.  [Brown and Miller 1999: 424]
    /// <see href="http://purl.org/linguistics/gold/CommonNoun"></see></summary>
    let CommonNoun = _prefix "CommonNoun"
    /// <summary>
    /// A term used in the grammatical classification of words, traditionally defines as the "name of a person, place or thing," but the vagueness associated with the notions of "name" and "thing" (e.g. is 'beauty' a thing?) has led linguistic descriptions to analyze this class in terms of the formal and functional criteria of syntax and morphology.  In linguistic terms, nouns are items which display certain types of inflection (e.g. of case or number), have a specific distribution (e.g. they may follow prepositions but not, say, modals), and perform a specific syntactic function (e.g. as subject or object of a sentence).  Nouns are generally subclassified into common and proper types, and analyzed in terms of number, gender, case and countability. [Crystal 2008: 320]
    /// <see href="http://purl.org/linguistics/gold/Noun"></see></summary>
    let Noun = _prefix "Noun"
    /// <summary>
    /// The form of an adjective which expresses that one thing possesses a certain quality or attribute to a greater extent than another thing or in relation to another reference point. [Hartmann and Stork 1972: 60; Pei and Gaynor 1980: 43]
    /// <see href="http://purl.org/linguistics/gold/ComparativeAdjective"></see></summary>
    let ComparativeAdjective = _prefix "ComparativeAdjective"
    /// <summary>
    /// A complement, also called a predicative, is a phrase that gives a description of the subject or object via the verb, while the verb itself expresses no adequate thought without being complemented by this addition.  Most typically this is an adjective phrase. [Asher 1994: 4881; Jespersen 2006: 89; Huddleston and Pullam 2002: 251]
    /// <see href="http://purl.org/linguistics/gold/Complement"></see></summary>
    let Complement = _prefix "Complement"
    /// <summary>
    /// A subordinate complement clause is an element which is dependent upon the main clause syntactically and as a whole completes the action of the verb. [Brown and Miller 1999: 424; Crystal 1980: 518]
    /// <see href="http://purl.org/linguistics/gold/ComplementSubordinate"></see></summary>
    let ComplementSubordinate = _prefix "ComplementSubordinate"
    /// <summary>
    /// A complementizer is a connective which marks a complement clause [Crystal 1997: 75].
    /// <see href="http://purl.org/linguistics/gold/Complementizer"></see></summary>
    let Complementizer = _prefix "Complementizer"
    /// <summary>
    /// A term used to denote verbal aspect that focuses on the conclusion of a process or action.  [Brown and Miller 1999: 424]
    /// <see href="http://purl.org/linguistics/gold/CompletiveAspect"></see></summary>
    let CompletiveAspect = _prefix "CompletiveAspect"
    /// <summary>
    /// A ComplexSpecification is a kind of FeatureSpecification whose value must be a FeatureStructure. This class gives a feature system its recursive properites [Maxwell, Simons and Hayashi 2000].
    /// <see href="http://purl.org/linguistics/gold/ComplexSpecification"></see></summary>
    let ComplexSpecification = _prefix "ComplexSpecification"
    /// <summary>
    /// A FeatureSpecification is a data structure that groups together a linguistic feature with a value [Maxwell, Simons and Hayashi 2000].
    /// <see href="http://purl.org/linguistics/gold/FeatureSpecification"></see></summary>
    let FeatureSpecification = _prefix "FeatureSpecification"
    /// <summary>
    /// A term used widely in descriptive linguistic studies to refer to a linguistic unit which is composed of elements that function independently in other circumstances. [Crystal 2003: 92]
    /// <see href="http://purl.org/linguistics/gold/Compound"></see></summary>
    let Compound = _prefix "Compound"
    /// <summary>
    /// One of the three types of Labial that can be associated with sounds involving lip compression involving the vertical movement of one lip towards the other. Such a property is associated with a normal bilabial stop.
    /// <see href="http://purl.org/linguistics/gold/Compressed"></see></summary>
    let Compressed = _prefix "Compressed"
    /// <summary>
    /// Gestures involving the lips are said to be Labial. From the linguistic point of view the places of articulation can usefully be classified into a smaller number of groups based on the articulators they share. If consonants in which either the upper or lower lip is involved as an articulator are classified as Labials then there are three place classes among Labial sounds: the lower lip can articulate with the upper lip (bilabial), or the upper teeth (labiodentals)l and,  the upper lip can also be the target for the tongue (linguo-labial). [Ladefoged and Maddieson 1996: 10; 15-15]
    /// <see href="http://purl.org/linguistics/gold/LabialProperty"></see></summary>
    let LabialProperty = _prefix "LabialProperty"
    /// <summary>
    /// When describing verbs, this is a term used to indicate expression of an unreal or unfulfilled condition.  Some languages use grammatical markers or verb forms to separate real and unreal conditions.  [Brown and Miller 1999: 425]
    /// <see href="http://purl.org/linguistics/gold/ConditionalModality"></see></summary>
    let ConditionalModality = _prefix "ConditionalModality"

    /// <summary>
    /// ConditionalPhysicalAbilitiveModality indicates ability of an agent to perform some action, requiring the presence of conditions external to the agent [Bybee, Perkins and Pagliuca 1994: 177; Palmer 2001: 76].
    /// <see href="http://purl.org/linguistics/gold/ConditionalPhysicalAbilitiveModality"></see></summary>
    let ConditionalPhysicalAbilitiveModality =
        _prefix "ConditionalPhysicalAbilitiveModality"

    /// <summary>
    /// A term used in the grammatical classification of words to refer to an item or a process whose primary function is to connect words or other constructions. The conventional subclassification of these 'connective' items distinguishes co-ordinating conjunctions (e.g. and, or, but) and subordinating conjunctions (e.g. because, when, unless) -- also referred to as 'co-ordinators' and 'subordinators' respectively. [Crystal 2008: 101]
    /// <see href="http://purl.org/linguistics/gold/Conjunction"></see></summary>
    let Conjunction = _prefix "Conjunction"
    /// <summary>
    /// A coordinating connective is a connective that links constituents without syntactically subordinating one to the other [Crystal 1997: 93].
    /// <see href="http://purl.org/linguistics/gold/CoordinatingConnective"></see></summary>
    let CoordinatingConnective = _prefix "CoordinatingConnective"
    /// <summary>
    /// Also known as a conjunction, a Connective is a class of parts of speech whose members syntactically link words or larger  constituents, and expresses a semantic relationship between them. A conjunction is positionally fixed relative to one or more of the elements related by it, thus distinguishing it from constituents such as English conjunctive adverbs [Crystal 1997: 81].
    /// <see href="http://purl.org/linguistics/gold/Connective"></see></summary>
    let Connective = _prefix "Connective"
    /// <summary>
    /// A type of sound segment defined by closure or constriction of the vocal tract, which produces an audible friction. The vocal tract constriction does not have to result in complete blocking; it can simply be a restriction of air flow. [Crystal 1985: 66]
    /// <see href="http://purl.org/linguistics/gold/Consonant"></see></summary>
    let Consonant = _prefix "Consonant"
    /// <summary>
    /// A discrete unit that can be identified in the stream of speech, either physically or auditorily. Features that extend over more than one segment, such as pitch or stress, are termed suprasegmentals. [Crystal 2003: 408–409; Hartmann
    /// <see href="http://purl.org/linguistics/gold/Segment"></see></summary>
    let Segment = _prefix "Segment"
    /// <summary>
    /// ContablativeCase expresses that  the referent of the noun it marks is the location 'from near' which another referent is moving. It has the meaning 'from near'. Kibrik says that Archi (aqc) possesses a nominal spatial form expressing ContablativeCase, namely -raš [Kibrik 1998: 470].
    /// <see href="http://purl.org/linguistics/gold/ContablativeCase"></see></summary>
    let ContablativeCase = _prefix "ContablativeCase"
    /// <summary>
    /// ContallativeCase expresses that  something is moving toward the vicinity of the referent of the noun it marks. It has the meaning  'towards the vicinity of'. Kibrik says that Archi (aqc) possesses a nominal spatial form expressing ContallativeCase, namely -rši [Kibrik 1998: 470].
    /// <see href="http://purl.org/linguistics/gold/ContallativeCase"></see></summary>
    let ContallativeCase = _prefix "ContallativeCase"
    /// <summary>
    /// ConterminativeCase expresses the notion of something moving into the vicinity of the referent of the noun it marks, but not through that region. It has the meaning 'moving into the vicinity of'. Kibrik says that Archi (aqc) possesses a nominal spatial form expressing ConterminativeCase, namely -rakana [Kibrik 1998: 470].
    /// <see href="http://purl.org/linguistics/gold/ConterminativeCase"></see></summary>
    let ConterminativeCase = _prefix "ConterminativeCase"
    /// <summary>
    /// ContextOfUseTaxon is the class of taxons whose instances  classify language varieties according to how they are primarily used.
    /// <see href="http://purl.org/linguistics/gold/ContextOfUseTaxon"></see></summary>
    let ContextOfUseTaxon = _prefix "ContextOfUseTaxon"
    /// <summary>
    /// LinguisticTaxon is the class of  Taxons whose instances are used in the scientific classification language varieties. That is, instances of LinguisticTaxon have instances that are human language varieties.
    /// <see href="http://purl.org/linguistics/gold/LinguisticTaxon"></see></summary>
    let LinguisticTaxon = _prefix "LinguisticTaxon"
    /// <summary>
    /// A value of Aspect Property assigned to the designated element in the clause when the meaning selected for the clause is that which indicates that the situation spoken about has internal temporal structure, but the situation cannot be regarded as habitual (i.e. it cannot be regarded as a characteristic feature of a whole period). Hence, continuousness can be defined negatively as imperfectivity that is not habituality [Comrie 1976: 26-32], and it can be regarded as a sub-type of imperfectivity.
    ///
    /// Typically, for an aspect value to be labelled as Continuous, the aspectual meaning has to minimally express continuousness, although it may additionally express other temporal, aspectual, or modal meanings, or actionality distinctions.
    ///
    /// Continuous aspectual meaning can be further subdivided into two types: progressive meaning and nonprogressive meaning. These two aspectual meanings may or may not be grammaticalised as separate aspect values. [Kibort 2008c: 8]
    /// <see href="http://purl.org/linguistics/gold/ContinuousAspect"></see></summary>
    let ContinuousAspect = _prefix "ContinuousAspect"
    /// <summary>
    /// ContlativeCase expresses that  the referent of the noun it marks is the location in the vicinity of which another referent is moving. It has the meaning 'in the vicinity of'. Kibrik says that Archi (aqc) possesses a nominal spatial form expressing ContlativeCase, namely -rak [Kibrik 1998: 470].
    /// <see href="http://purl.org/linguistics/gold/ContlativeCase"></see></summary>
    let ContlativeCase = _prefix "ContlativeCase"
    /// <summary>
    /// A nonfinite verb form, i.e., lacking specifications for tense, mood, and agreement with their arguments, whose main function is to mark adverbial subordination. Converbal constructions are generally not arguments but modifiers, and they generally modify verbs, clauses or sentences, but not nouns or noun phrases. They are embedded or incorporated into the superordinate clause, and contrast with coordinate constructions. Converbal constructions can often be paraphrased by means of coordinate constructions in languages that allow coordination of clauses, such as in the gloss for the Korean example below. [Haspelmath 1995: 3-8]
    /// <see href="http://purl.org/linguistics/gold/Converb"></see></summary>
    let Converb = _prefix "Converb"
    /// <summary>
    /// Indicates a relationship of equivalency between the subject and predicate or complement of a clause. Verbal copulas have essentially the same morphosyntactic properties as verbs: English  'be', Spanish  'ser', and Russian  'byt’' are illustrations of this class. Nonverbal copular items include the the pro-copula - a demonstrative or personal pronoun which serves as the linker between subject and predicate nominal, and which is obligatory in nominal predication - and particle copulas, which have their origin in a variety of markers of discourse-oriented phenomena such as topicalization, backgrounding, or contrastive focus for subjects or predicates. Zero copula refers to a construction in which the relation between a subject and a nominal predicate is not marked by an overt item. Zero copula is mandatory in some languages, such as Sinhalese, whereas it is conditional or restricted in other languages, such as Russian. [Stassen 2008]
    /// <see href="http://purl.org/linguistics/gold/Copula"></see></summary>
    let Copula = _prefix "Copula"
    /// <summary>
    /// A verb such as 'be', 'seem', 'become', 'look', etc. which relates the subject to the complement, e.g. in 'He is a teacher', 'The policeman seemed not at all satisfied', 'It got worse and and worse'. [Hartmann and Stork 1972: 55]
    /// <see href="http://purl.org/linguistics/gold/Copulative"></see></summary>
    let Copulative = _prefix "Copulative"
    /// <summary>
    /// A correlative connective is either of a pair of  coordinating conjunctions (connectives) used in ordered fashion. Typically, one is used immediately before each member of a pair of constituents [Crystal 1997: 96].
    /// <see href="http://purl.org/linguistics/gold/CorrelativeConnective"></see></summary>
    let CorrelativeConnective = _prefix "CorrelativeConnective"
    /// <summary>
    /// A term referring to a vocal quality in phonetic sound classification in which only one end of the vocal cords vibrates, and does so very slowly.  This is a permanent feature of some speakers' voices. [Crystal 1980: 97]
    /// <see href="http://purl.org/linguistics/gold/Creaky"></see></summary>
    let Creaky = _prefix "Creaky"
    /// <summary>
    /// DativeCase marks 1) Indirect objects (for languages in which they are held to exist) or 2) nouns having the role of recipient (as of things given), beneficiary of an action, or possessor of an item [Crystal 1980: 102].
    /// <see href="http://purl.org/linguistics/gold/DativeCase"></see></summary>
    let DativeCase = _prefix "DativeCase"
    /// <summary>
    /// A term used in the grammatical classification of sentence types, and usually seen in contrast to imperative, interrogative, etc. It refers to verb forms or sentence/clause types typically used in the expression of statements, e.g. 'the man is walking'. The term 'indicative' is also sometimes used in this sense. [Crystal 2003: 124]
    /// Declarative force marks an unqualified assertion. This form is generally unmarked for modality, and thus may also be seen as Realis, while modal forms are Irrealis. In English, the Declarative is marked by the absence of a modal verb, although it will be marked for the other verbal categories, tense and aspect. [Palmer 2001: 64]
    /// <see href="http://purl.org/linguistics/gold/DeclarativeForce"></see></summary>
    let DeclarativeForce = _prefix "DeclarativeForce"
    /// <summary>
    /// DeductiveEvidentiality encodes the fact that the speaker came to believe the content of the expression through a sound inference procedure. [Palmer 2001: 6-8].
    /// <see href="http://purl.org/linguistics/gold/DeductiveEvidentiality"></see></summary>
    let DeductiveEvidentiality = _prefix "DeductiveEvidentiality"
    /// <summary>
    /// An definite article is a part of speech whose members refer to a specific, identifiable entity (or class of entities) [Crystal 1997: 107].
    /// <see href="http://purl.org/linguistics/gold/DefiniteArticle"></see></summary>
    let DefiniteArticle = _prefix "DefiniteArticle"
    /// <summary>
    /// DelativeCase expresses motion downward from the referent of the noun it marks [Pei and Gaynor 1954: 53].
    /// <see href="http://purl.org/linguistics/gold/DelativeCase"></see></summary>
    let DelativeCase = _prefix "DelativeCase"
    /// <summary>
    /// A demonstrative is a determiner that is used deictically to indicate a referent's spatial, temporal, or discourse location. A demonstrative functions as a modifier of a noun, or a pronoun [Crystal 1997: 312].
    /// <see href="http://purl.org/linguistics/gold/Demonstrative"></see></summary>
    let Demonstrative = _prefix "Demonstrative"
    /// <summary>
    /// A Pronoun is a ProForm which functions like a noun and substitutes for a noun or  noun phrase [Crystal 1997: 312].
    /// <see href="http://purl.org/linguistics/gold/Pronominal"></see></summary>
    let Pronominal = _prefix "Pronominal"
    /// <summary>
    /// A consonant which involves the teeth, normally the upper teeth, as the passive articulators in its articulation. The tip or apex  of the tongue usually acts as the active articulator. [Hartmann and Stork 1972: 61]
    /// <see href="http://purl.org/linguistics/gold/Dental"></see></summary>
    let Dental = _prefix "Dental"
    /// <summary>
    /// Deontic modality is concerned with the necessity or possibility of acts performed by morally responsible agents and is thus associated with the social functions of permission and obligation. Deontic modality focuses on the notions of obligation and permission. It is found in directives that grant permission (‘you may go now’) or impose obligations (‘eat your vegetables!’), as well as in statements that report deontic conditions. Deontic modality fails to distinguish subcategories that are expressed inflectionally from lexical or periphrastic expressions of obligation or permission. Deontic modality as traditionally understood excludes certain semantically related notions such as ability and desire that have linguistic expression similar to that of permission and obligation. [Bybee and Fleischman 1995: 4-5]
    /// <see href="http://purl.org/linguistics/gold/DeonticModality"></see></summary>
    let DeonticModality = _prefix "DeonticModality"
    /// <summary>
    /// Action denotes physical/mental disposition of subject. [Siewierska 1988: 257]
    /// <see href="http://purl.org/linguistics/gold/DeponentMiddleVoice"></see></summary>
    let DeponentMiddleVoice = _prefix "DeponentMiddleVoice"
    /// <summary>
    /// DescribedVariety is the class of  distinct human languages or language varieties as recognized by a linguist or a particular linguistic community, but not necessarily recognized by the ISO 639-3 standard. This category allows a language to be described even though it is not (yet) included in ISO 639-3.
    /// <see href="http://purl.org/linguistics/gold/DescribedVariety"></see></summary>
    let DescribedVariety = _prefix "DescribedVariety"
    /// <summary>
    /// An auxiliary mark or symbol added above, below or after conventional graphic signs to give more information about the pronunciation of the sound represented in writing. Such diacritic marks include acute accent, apostrophe, caret, cedilla, diaeresis or umlaut, grave accent, macron, tilde and circumflex. [Hartmann and Stork 1972: 65]
    /// <see href="http://purl.org/linguistics/gold/Diacritic"></see></summary>
    let Diacritic = _prefix "Diacritic"
    /// <summary>
    /// An OrthographicPart is a unit of an orthography that is not orthographically independent, that is, not necessarily able to stand alone as an orthographic word set off by whitespace. In the printed instance of the word 'conceive', 'eive' is an instance of orthographic part. Note that an orthographic part is not the same as a single glyph, although, some orthographic parts are single glyphs.
    /// <see href="http://purl.org/linguistics/gold/OrthographicPart"></see></summary>
    let OrthographicPart = _prefix "OrthographicPart"
    /// <summary>
    /// A regional, temporal or social variety of a language, differing in pronunciation, grammar and vocabulary from the standard language,which is in itself a socially favoured dialect. [Hartmann and Stork 1972: 65]
    /// <see href="http://purl.org/linguistics/gold/Dialect"></see></summary>
    let Dialect = _prefix "Dialect"
    /// <summary>
    /// GeneticTaxon is the class of all taxons whose members are based on genetic relatedness.
    /// <see href="http://purl.org/linguistics/gold/GeneticTaxon"></see></summary>
    let GeneticTaxon = _prefix "GeneticTaxon"
    /// <summary>
    /// A term used in phonetics/phonology and graphics/graphology to refer to a graphic unit in which two symbols have combined to form a single element in a system. In the study of reading and spelling, digraph refers to any sequence of two letters pronounced as a single sound. [Crystal 2003: 139]
    /// <see href="http://purl.org/linguistics/gold/Digraph"></see></summary>
    let Digraph = _prefix "Digraph"
    /// <summary>
    /// A special form of a noun that signals that the object being referred to is small relative to the usual size of such an object.  In some cases it may be used as a term of endearment [Crystal 1980: 116].
    /// <see href="http://purl.org/linguistics/gold/DiminuativeSize"></see></summary>
    let DiminuativeSize = _prefix "DiminuativeSize"
    /// <summary>
    /// DirectEvidential, also called sensory, encodes the fact that the speaker came to believe the content of the expression by having direct sensory experience of some situation; this does not include hearing about it from someone else [Palmer 2001: 35-36].
    /// <see href="http://purl.org/linguistics/gold/DirectEvidentiality"></see></summary>
    let DirectEvidentiality = _prefix "DirectEvidentiality"
    /// <summary>
    /// Direct voice signals that the action proceeds in an ontologically salient way, i.e. that salience is assigned to nominals based on their referent's relative real-world capacities to control situations. [Klaiman 1991: 32]
    /// <see href="http://purl.org/linguistics/gold/DirectVoice"></see></summary>
    let DirectVoice = _prefix "DirectVoice"
    /// <summary>
    ///   <see href="http://purl.org/linguistics/gold/DiscourseProperty"></see>
    /// </summary>
    let DiscourseProperty = _prefix "DiscourseProperty"
    /// <summary>
    /// LinguisticProperty is the class  of properties that pertain to linguistic units. A unit's properties determine its behavior  in a grammatical system. Specific kinds of properties are relevant to certain types of units. In some language, for example, tense properties may be relevant for verbs. See also Feature and FeatureValue for the corresponding data structure for properties.
    /// <see href="http://purl.org/linguistics/gold/LinguisticProperty"></see></summary>
    let LinguisticProperty = _prefix "LinguisticProperty"
    /// <summary>
    /// Discourse is the name given to stretches of language longer than one sentence, e.g., conversations, narratives, arguments, and speeches. A discourse unit is an identifiable structure within a discourse. The form of a discourse unit is partly determined by genre and partly by its social context. [Aristar-Dry 2010 (p.c.); based on Mills 1997]
    /// <see href="http://purl.org/linguistics/gold/DiscourseUnit"></see></summary>
    let DiscourseUnit = _prefix "DiscourseUnit"
    /// <summary>
    /// This term is often used in linguistics and phonetics to refer to any entity which constitutes the focus of an enquiry. The unit is the stretch of language that carries grammatical patterns, and within which grammatical choices are made. For example, the unit sentence consists of one or more instances of the unit clause, and so on. [Crystal 2008: 503]
    /// <see href="http://purl.org/linguistics/gold/LinguisticUnit"></see></summary>
    let LinguisticUnit = _prefix "LinguisticUnit"
    /// <summary>
    /// Disjunction refers to a process whose primary function is to mark a relationship of contrast or comparison between structures, using such disjunctive items as 'or' and 'but'. [Crystal 1985: 97]
    /// <see href="http://purl.org/linguistics/gold/Disjunction"></see></summary>
    let Disjunction = _prefix "Disjunction"
    /// <summary>
    /// A verbal aspect expressing that the action or state denoted by the verb is performed or experienced simultaneously by more than one individual or object. [Pei and Gaynor 1954: 59]
    /// <see href="http://purl.org/linguistics/gold/DistributiveAspect"></see></summary>
    let DistributiveAspect = _prefix "DistributiveAspect"
    /// <summary>
    /// Most languages also have various series of numerals, whose denotations combine the concept of number with other concepts of a variety of different kinds. The meaning of sentences containing distributive numerals can be described in terms of a binary semantic relationship of distributivity that obtains between an expression containing the distributive numeral, the distributive share, and some other expression in the sentence, the distributive key. [Gill 2005: 222] Distributive numerals are special adnominal numerals that express distributive relations, as in German ‘Die Männer trugen je drei Koffer’, ‘The men carried three suitcases each.’ English lacks distributive numerals, because in a sentence like ‘They carried three suitcases each, the numeral does not form a continuous constituent with the distributive word ‘each’, i.e. ‘three…each’ does not qualify as a numeral. [Michaelis, Maurer, Haspelmath and Huber 2008]
    /// <see href="http://purl.org/linguistics/gold/DistributiveNumeral"></see></summary>
    let DistributiveNumeral = _prefix "DistributiveNumeral"
    /// <summary>
    /// A ditransitive verb is a verb that takes two objects [Crystal 1997: 397].
    /// <see href="http://purl.org/linguistics/gold/DitransitiveVerb"></see></summary>
    let DitransitiveVerb = _prefix "DitransitiveVerb"
    /// <summary>
    /// TertiaryPredicator is the class of syntactic words that take three required arguments.
    /// <see href="http://purl.org/linguistics/gold/TertiaryPredicator"></see></summary>
    let TertiaryPredicator = _prefix "TertiaryPredicator"
    /// <summary>
    /// The dual quantifies the denotation of the nominal element by specifying that there are exactly 'two' (as in Upper Sorbian, see [Corbett 2000: 20] for examples and discussion. Additionally, but not necessarily, this value may be assigned on the basis of the formal properties of the nominal element (as in dualia tantum, e.g. mangautek 'scissors' in the Yukon dialect of Central Alaskan Yupik; [Jacobson 1984: 226]). The use of the dual varies across languages which have this value. In some languages, dual may be used to refer to any two entities, but in others it must refer to a natural pair such as eyes, and still in others it must refer to two items unless they are a natural pair [Corbett 2000]. [Kibort and Corbett 2008b]
    /// <see href="http://purl.org/linguistics/gold/DualNumber"></see></summary>
    let DualNumber = _prefix "DualNumber"
    /// <summary>
    /// NumberProperty is the class of properties that concern the grammatical encoding of quantity. It is often found on nouns, pronouns, and verbs and expresses count distinctions--such as 'one' or 'more than one'. The count distinctions typically, but not always, correspond to the actual count of the referents of the marked noun or Pronoun. [Crystal 1980: 245; Hartmann and Stork 1972: 155]
    /// <see href="http://purl.org/linguistics/gold/NumberProperty"></see></summary>
    let NumberProperty = _prefix "NumberProperty"
    /// <summary>
    /// DubitiveMood indicates a speaker's doubt or uncertainty about a proposition. [Palmer 2001: 24-25]
    /// <see href="http://purl.org/linguistics/gold/DubitiveMood"></see></summary>
    let DubitiveMood = _prefix "DubitiveMood"
    /// <summary>
    /// MoodProperty is the class of properties that concern the grammatical encoding of mood of a proposition. Among the traditionally defined properties are Declarative, Imperative and Interrogative. This class of properties contains both attitude (e.g. optative, volitive, subjunctive) and speech-act (e.g. imperative, commissive) values.
    /// <see href="http://purl.org/linguistics/gold/MoodProperty"></see></summary>
    let MoodProperty = _prefix "MoodProperty"
    /// <summary>
    /// Events which involve some duration [Bhat 1999: 58].
    /// <see href="http://purl.org/linguistics/gold/DurativeAspect"></see></summary>
    let DurativeAspect = _prefix "DurativeAspect"
    /// <summary>
    /// ElativeCase expresses that the referent of the noun it marks is the location out of which another referent is moving. It has the meaning 'out of' [Lyons 1968: 299; Pei and Gaynor 1954: 64; Crystal 1985: 106].
    /// <see href="http://purl.org/linguistics/gold/ElativeCase"></see></summary>
    let ElativeCase = _prefix "ElativeCase"
    /// <summary>
    /// An enclitic is a clitic that is phonologically joined at the end of a preceding lexical unit to form a single phonological unit [Crystal 1980: 64; Pei and Gaynor 1954: 65].
    /// <see href="http://purl.org/linguistics/gold/Enclitic"></see></summary>
    let Enclitic = _prefix "Enclitic"
    /// <summary>
    /// There are a number of ways to categorize language endangerment situations. One useful taxonomy takes into account the relative rate of attrition together with its causes. This taxonomy recognizes four different categories of attrition: sudden, radical, gradual and top to bottom. [Brown and Ogilvie 2009: 321]
    /// <see href="http://purl.org/linguistics/gold/EndangermentTaxon"></see></summary>
    let EndangermentTaxon = _prefix "EndangermentTaxon"
    /// <summary>
    /// EpistemicModality indicates that a state of affairs is known to be possible or certain (necessary). [Palmer 2001: 7-8]
    /// <see href="http://purl.org/linguistics/gold/EpistemicModality"></see></summary>
    let EpistemicModality = _prefix "EpistemicModality"
    /// <summary>
    /// EpistemicNecessityModality indicates that the expressed proposition is known to be true. Also known as CategoricalModality [Palmer 2001: 37, 68-69].
    /// <see href="http://purl.org/linguistics/gold/EpistemicNecessityModality"></see></summary>
    let EpistemicNecessityModality = _prefix "EpistemicNecessityModality"
    /// <summary>
    /// EpistemicPossibilityModality indicates that the designated state of affairs is not known not to be true.
    /// <see href="http://purl.org/linguistics/gold/EpistemicPossibilityModality"></see></summary>
    let EpistemicPossibilityModality = _prefix "EpistemicPossibilityModality"
    /// <summary>
    /// ErgativeCase in ergative-absolutive languages generally identifies the subject of transitive verbs in the translation equivalents of nominative-accusative Languages such as English [Crystal 1980: 134; Hartmann and Stork 1972: 78; Pei and Gaynor 1954: 67; Andrews 1985: 138].
    /// <see href="http://purl.org/linguistics/gold/ErgativeCase"></see></summary>
    let ErgativeCase = _prefix "ErgativeCase"
    /// <summary>
    /// EssiveCase expresses that  the referent of the noun it marks is the location at which another referent exists [Lyons 1968: 299, 301; Crystal 1985: 112; Blake 2001].
    /// <see href="http://purl.org/linguistics/gold/EssiveCase"></see></summary>
    let EssiveCase = _prefix "EssiveCase"
    /// <summary>
    /// A term used in semantics for a type of modality where propositions express the speaker’s attitude (e.g. surprise, regret) towards what is being said. [Crystal 2003: 168]
    /// <see href="http://purl.org/linguistics/gold/EvaluativeProperty"></see></summary>
    let EvaluativeProperty = _prefix "EvaluativeProperty"
    /// <summary>
    /// An existential marker is a syntactic category whose members are found in distinct clause types and which mark a referent's existence [Crystal 1997: 142].
    /// <see href="http://purl.org/linguistics/gold/ExistentialMarker"></see></summary>
    let ExistentialMarker = _prefix "ExistentialMarker"
    /// <summary>
    /// An expletive (also known as a dummy word) is a part of speech whose members have no meaning, but complete a sentence to make it grammatical [Crystal 1997: 127].
    /// <see href="http://purl.org/linguistics/gold/Expletive"></see></summary>
    let Expletive = _prefix "Expletive"
    /// <summary>
    /// A language no longer used as a medium of oral communication in a speech community, e.g. Latin, Gothic, as opposed to living languages such as English, Japanese. [Hartmann and Stork 1972: 58]
    /// <see href="http://purl.org/linguistics/gold/ExtinctVariety"></see></summary>
    let ExtinctVariety = _prefix "ExtinctVariety"
    /// <summary>
    /// A type of FeatureDistributionSystem; in a given language, it is the system according to which feature values (of a particular feature) are determined for elements through agreement (i.e. where the form of the element is determined by the presence of another element). [Kibort 2008d]
    /// <see href="http://purl.org/linguistics/gold/FeatureAgreementSystem"></see></summary>
    let FeatureAgreementSystem = _prefix "FeatureAgreementSystem"
    /// <summary>
    /// In a given language, the system according to which feature values (of a particular feature) are determined contextually for elements, through agreement or government. FeatureDistributionSystem can have one or two main components: FeatureAgreementSystem, and FeatureGovernmentSystem. [Kibort 2008d]
    /// <see href="http://purl.org/linguistics/gold/FeatureDistributionSystem"></see></summary>
    let FeatureDistributionSystem = _prefix "FeatureDistributionSystem"
    /// <summary>
    /// (The term 'assignment') was first used with respect to feature values by Corbett (1991) in his discussion of mechanisms for allotting nouns to different genders. Native speakers have the ability to ‘work out’ the gender of a noun, and models of this ability have been called ‘gender assignment systems’. So far, the concept of ‘assignment of a feature value’ has not been used outside gender. For some features, there may not be as much to say as for gender. However, using the concept of ‘assignment’ with respect to the values of all features is useful to be able to compare the features. Therefore, for this typology I have adopted the following definition: an assignment system is a set of rules that realise the value of a feature on an element. Note, however, that under this definition, a gender value is ‘assigned’ both to nouns, and to targets of agreement in gender with the noun. [Kibort 2008d: 8]
    /// <see href="http://purl.org/linguistics/gold/FeatureAssignmentSystem"></see></summary>
    let FeatureAssignmentSystem = _prefix "FeatureAssignmentSystem"
    /// <summary>
    /// A linguistic data structure is an abstract container for grouping together instances of linguistic data, usually to suit a particular theory or computational implementation. Examples include: feature structures, lexical entries, and paradigms.
    /// <see href="http://purl.org/linguistics/gold/LinguisticDataStructure"></see></summary>
    let LinguisticDataStructure = _prefix "LinguisticDataStructure"
    /// <summary>
    /// A term used in linguistics, and especially in generative grammar, to refer to a condition which restricts the application of a rule, to ensure that the sentences generated are well formed. For example, in generative phonology, a distinction can be made between ‘simulatenous’ and ‘sequential’ constraints: the former states the restrictions on the simulataneous occurrence of features, e.g. a segment cannot be at once [+high] and [+low]; the latter states the restrictions on sequences of features, e.g. whether a language permits consonant clusters. In generative syntax there are also several constraints which have to be imposed in order to prevent the derivation of ill formed phrase-markers, e.g. constraints on the ordering of rules. The notion of constraints takes on a different direction in optimality theory, where it is the principle explanatory device. Here, constraints are ways of characterizing language universals. Each language has its own ranking of constraints (e.g. which determine morpheme position or syllable structure), and differences between these rankings result in the variations observed between languages. [Crystal 2003: 101]
    /// <see href="http://purl.org/linguistics/gold/FeatureConstraint"></see></summary>
    let FeatureConstraint = _prefix "FeatureConstraint"
    /// <summary>
    /// The feature of case is typically involved in government. A governor does not bear the feature value it requires of its governee. Government is also asymmetric with regard to the possession of the feature specification by the elements. [Kibort 2008d: 1, 6]
    /// <see href="http://purl.org/linguistics/gold/FeatureGovernmentSystem"></see></summary>
    let FeatureGovernmentSystem = _prefix "FeatureGovernmentSystem"
    /// <summary>
    /// A FeatureStructure is a set of one or more FeatureSpecifications. A FeatureStructure is a kind of information structure, a container or data structure, used to group together qualities or features of some object. In a grammatical feature system, a FeatureStructure holds the grammatical information associated with some linguistic unit. In a typed feature system, a FeatureStructure has an associated type, usually a PartOfSpeech. [Shieber 1986; Maxwell, Simons and Hayashi 2000].
    /// <see href="http://purl.org/linguistics/gold/FeatureStructure"></see></summary>
    let FeatureStructure = _prefix "FeatureStructure"
    /// <summary>
    /// An utterance is divided into parts, which are assigned to word classes and then subclassified in terms of their "accidents" or properties. [Blevins 2006: 390] The properties, also referred to as features or categories, express what is shared by different linguistic elements, as opposed to what is idiosyncratic. [Kibort 2008d: 1]
    /// <see href="http://purl.org/linguistics/gold/FeatureSystem"></see></summary>
    let FeatureSystem = _prefix "FeatureSystem"
    /// <summary>
    /// A gender property established on the basis of agreement, to which nouns may be assigned if 1) they inherently denote females. Additionally, but not necessarily, nouns may be assigned this value if: 2) their formal properties (morphological or phonological) lead them to be assigned to the same agreement pattern as other nouns within the language that have female denotation. 3) they are arbitrarily assigned to the same agreement pattern as other nouns in the language that have female denotation. [Corbett 1991]
    /// <see href="http://purl.org/linguistics/gold/FeminineGender"></see></summary>
    let FeminineGender = _prefix "FeminineGender"
    /// <summary>
    /// First is a  person property that refers minimally to the speaker. It may also refer to the speaker combined with either the addressee or the non-participant or both, allowing for the following subdivisions: a) first person b) first person inclusive c) first person exclusive [Cysouw 2003].
    /// <see href="http://purl.org/linguistics/gold/FirstPerson"></see></summary>
    let FirstPerson = _prefix "FirstPerson"
    /// <summary>
    /// PersonProperty is the class of properties  with a deictic dimension, interpreted relative to the speaker, encoding the participants in a speech situation. Usually a three-way contrast is found: firstPerson (speaker), secondPerson (addressee), and thirdPerson (neither speaker nor addressee). Other distinctions within this feature include: inclusive/exclusive and proximative/obviative. [Crystal 1997: 285-286]
    /// <see href="http://purl.org/linguistics/gold/PersonProperty"></see></summary>
    let PersonProperty = _prefix "PersonProperty"
    /// <summary>
    ///   <see href="http://purl.org/linguistics/gold/FirstPersonExclusive"></see>
    /// </summary>
    let FirstPersonExclusive = _prefix "FirstPersonExclusive"
    /// <summary>
    ///   <see href="http://purl.org/linguistics/gold/FirstPersonInclusive"></see>
    /// </summary>
    let FirstPersonInclusive = _prefix "FirstPersonInclusive"
    /// <summary>
    /// Blocks the patient or logical object (basic absolutive) nominal from being assigned Focus salience. Topic salience is available for assignment to various arguments, including the patient, but Focus salience is always assigned to agent, and is therefore inaccessible to the patient or any other nominal. [Klaiman 1991: 236] Dayley describes the focus antipassive as a rearranging voice whose primary function is to indicate that the agent of a transitive sentence is highlighted or in focus. The focus antipassive is used when the agent is in contrastive focus or highly emphatic, when the agent is questioned, and when the agent is relativized. [Dayley 1985: 348]
    /// <see href="http://purl.org/linguistics/gold/FocusAntipassiveVoice"></see></summary>
    let FocusAntipassiveVoice = _prefix "FocusAntipassiveVoice"
    /// <summary>
    /// FolkloreEvidentiality encodes the fact that the speaker came to believe the content of the expression through legend, folklore or some other established tradition [Palmer 2001: 40].
    /// <see href="http://purl.org/linguistics/gold/FolkloreEvidentiality"></see></summary>
    let FolkloreEvidentiality = _prefix "FolkloreEvidentiality"
    /// <summary>
    /// Used to describe the unit of rhythm in languages displaying isochrony, i.e. where the stressed syllables fall at approximately regular intervals throughout an utterance. It is an extension of the term used in traditional studies of metrical verse structure, where the many regular patterns of stressed/unstressed syllables were given a detailed classification. In a more general phonological sense, the notion is applied to any utterance in a stress-timed language, not just verse. [Crystal 1985: 123-124]
    /// <see href="http://purl.org/linguistics/gold/Foot"></see></summary>
    let Foot = _prefix "Foot"
    /// <summary>
    /// Denotes the sensorily perceptible aspect of the linguistic sign. [Bussmann 1996: 169]
    /// <see href="http://purl.org/linguistics/gold/FormUnit"></see></summary>
    let FormUnit = _prefix "FormUnit"
    /// <summary>
    /// One more distinction can be made within both types of inherently assigned feature values: that between formal and semantic assignment. This distinction was proposed by Corbett (1991) to account for the criteria according to which nouns can be allotted to genders. Corbett demonstrates that gender assignment systems in languages can be semantic or semantic-and-formal – that is, the set of rules that determine the assignment of inherent gender values to nouns refer to the meaning of words, or a combination of the meaning of words and the form of words. [Kibort 2008d: 12]
    /// <see href="http://purl.org/linguistics/gold/FormalAssignmentSystem"></see></summary>
    let FormalAssignmentSystem = _prefix "FormalAssignmentSystem"
    /// <summary>
    /// A morpheme which can be used on its own as a word with a distinct meaning, as opposed to a bound morpheme. [Hartmann and Stork 1972: 88]
    /// <see href="http://purl.org/linguistics/gold/FreeMorpheme"></see></summary>
    let FreeMorpheme = _prefix "FreeMorpheme"
    /// <summary>
    /// Events which are frequently repeated, differs from habitual in that it can only be based upon the observation of several occurrences of the event concerned, whereas habitual can be based upon the observation of a single occurrence [Bhat 1999: 53].
    /// <see href="http://purl.org/linguistics/gold/FrequentiveAspect"></see></summary>
    let FrequentiveAspect = _prefix "FrequentiveAspect"
    /// <summary>
    /// Fricative sounds are those in which a turbulent airstream is produced within the vocal tract. [Ladefoged and Maddieson 1996: 137]
    /// <see href="http://purl.org/linguistics/gold/Fricative"></see></summary>
    let Fricative = _prefix "Fricative"
    /// <summary>
    /// The highest point of the tongue is in the front of the mouth. [Ladefoged 2000: 12]
    /// A sound made with the front part of the tongue, in the area of the hard palate. [Pei and Gaynor 1980: 78]
    /// <see href="http://purl.org/linguistics/gold/Front"></see></summary>
    let Front = _prefix "Front"
    /// <summary>
    /// FutureInFutureTense locates the situation in question in the future, relative to a temporal reference point that itself is located in the future relative to the moment of utterance [Comrie 1985: 128].
    /// <see href="http://purl.org/linguistics/gold/FutureInFutureTense"></see></summary>
    let FutureInFutureTense = _prefix "FutureInFutureTense"
    /// <summary>
    /// FutureInPastTense locates the situation in question in the future, relative to a contextually determined temporal reference point that itself must be located in the past relative to the moment of utterance [Comrie 1985: 128].
    /// <see href="http://purl.org/linguistics/gold/FutureInPastTense"></see></summary>
    let FutureInPastTense = _prefix "FutureInPastTense"
    /// <summary>
    /// Describes an event that occurs after the time of speaking but before some reference point in time which also occurs after the time of speaking. This is also known as PastInFutureTense. [Comrie 1985: 126]
    /// <see href="http://purl.org/linguistics/gold/FuturePerfectTense"></see></summary>
    let FuturePerfectTense = _prefix "FuturePerfectTense"
    /// <summary>
    /// A value of Tense Property assigned to the designated element in the clause when the meaning selected for the clause is that intended to locate the event spoken about as posterior to the deictic centre of the utterance. Most commonly, this tense meaning is referred to as 'future', because in absolute tense systems the deictic centre is the moment of speech. However, in relative tense systems, where the deictic centre can be moved to any point on the time line, it is more appropriate to refer to this temporal relation as 'posterior'. The posterior temporal relation may obtain either in 'simple' or 'perfect' contexts. Modelling of this distinction originates from [Reichenbach 1947], who suggested using a third point in time, 'reference point', to capture all possible tense distinctions. In all 'simple' temporal relations, the reference point coincides with the location of the event spoken about. 'Perfect' tense meanings are created when the reference point is separated and moved away from the event time, thus altering the viewing of the temporal location of the event even though the event's actual location with respect to the deictic centre remains the same. Posterior temporal relationships obtaining in a 'perfect' context occur when the reference point is moved away from the event time. There are various logical possibilities for locating the reference point with respect to the other two points, though none of them seem to be typically grammaticalised as separate tenses. Typically, for a tense value to be labelled as Future Tense, the tense meaning has to minimally express the posterior temporal relationship, although it may additionally express other temporal, aspectual, or modal meanings. [Kibort 2008c: 5]
    /// <see href="http://purl.org/linguistics/gold/FutureTense"></see></summary>
    let FutureTense = _prefix "FutureTense"
    /// <summary>
    /// In some languages for which number is less dominant, the meaning of the noun can be expressed without reference to number. Nouns with this marking are designated as outside of the number system, as they are noncommittal as to the number of the noun that they mark. [Corbett 2000: 9-10]
    /// <see href="http://purl.org/linguistics/gold/GeneralNumber"></see></summary>
    let GeneralNumber = _prefix "GeneralNumber"
    /// <summary>
    /// GenitiveCase is used to mark the noun whose referent is the possessor of the referent of another noun [Crystal 1980: 161; Hartmann and Stork 1972: 94-95, 180; Pei and Gaynor 1954: 82, 172; Anderson 1985: 185; Fleming 1988: 10].
    /// <see href="http://purl.org/linguistics/gold/GenitiveCase"></see></summary>
    let GenitiveCase = _prefix "GenitiveCase"
    /// <summary>
    /// GeographicTaxon is the class of linguistic taxons whose instances are groupings based on where, in general, the language varieties are used, e.g., AustralianLanguage.
    /// <see href="http://purl.org/linguistics/gold/GeographicTaxon"></see></summary>
    let GeographicTaxon = _prefix "GeographicTaxon"
    /// <summary>
    /// A part of speech derived from a verb and used as a noun, usually restricted to non-finite forms of the verb [Crystal 1997: 279].
    /// <see href="http://purl.org/linguistics/gold/Gerund"></see></summary>
    let Gerund = _prefix "Gerund"
    /// <summary>
    /// A phonation type containing the features 'raising' and 'lowering'. [Ladefoged and Maddieson 1996: 372]
    /// <see href="http://purl.org/linguistics/gold/GlottalMovementProperty"></see></summary>
    let GlottalMovementProperty = _prefix "GlottalMovementProperty"
    /// <summary>
    /// The laryngeal setting refers to differences in the timing of laryngeal activity in relation to oral articulation. Most languages have phonemic contrasts between classes of stops which differ in the mode of action of the larynx, or in the timing of laryngeal activity. [Ladefoged and Maddieson 1996: 47]
    /// <see href="http://purl.org/linguistics/gold/LaryngealProperty"></see></summary>
    let LaryngealProperty = _prefix "LaryngealProperty"
    /// <summary>
    /// A shape that is the visual representation of a character. It is a graphic object stored within a font. Glyphs are objects that are recognizably related to particular characters and which are dependent on particular design. Glyphs may or may not correspond to characters in a one-to-one manner. For example, a single character may correspond to multiple glyphs that have complementary distributions based upon context (e.g. final and non-final sigma in Greek), or several characters may correspond to a single glyph known as a ligature. [Lyons, et al. 2001]
    /// A Glyph is a symbol used in a writing system to represent some kind of linguistic unit, such as a single sound, a  phoneme or an entire word. Glyphs are concatenated in a writing system to form orthographic parts and orthographic words. Consider the printed word 'apple'. This word contains two instances of the 'p' glyph, which is a subclass of Glyph. Instances of a Glyph share a similar shape and can be called 'shapemes'. The class Glyph is not the same as Grapheme. A Grapheme is a contrastive unit within a particular writing system. The notion of a glyph is relevant across writing systems. For instance, consider the symbol 'р' used in a printed instance of a Russian word 'русский'. Now consider the symbol 'p' used in the printed instance of an English word 'pickle'. Both symbols are instances of the same Glyph. They share the same general shape, but do not have the same phonemic value.
    /// <see href="http://purl.org/linguistics/gold/Glyph"></see></summary>
    let Glyph = _prefix "Glyph"
    /// <summary>
    /// A GrammarUnit is the structural component of the linguistic sign and includes notions such as morpheme, syntactic word, and construction. Grammar units are classified according to their mereology (part-whole and complexity),  morphosyntactic function, and whether they exist in a bound or free forms.
    /// <see href="http://purl.org/linguistics/gold/GrammarUnit"></see></summary>
    let GrammarUnit = _prefix "GrammarUnit"
    /// <summary>
    /// Crystal defines a grapheme as the minimal contrastive unit in the writing system of a language; usually enclosed in angle brackets. The grapheme &lt;a&gt;, for example, is realized as several allographs A, a, a, etc., which may be seen as units in complementary distribution (e.g. upper case restricted to sentence-initial position, proper names, etc.), or in free variation (as in some styles of handwriting), just as in phonemic analysis. 'Grapheme Analysis' is the main business of graphemics (or graphology). [Crystal 2008: 220]
    /// A Grapheme is the smallest meaningful contrastive unit in a writing system. A grapheme is an abstraction over a set of like glyphs, the actual images on the  page. That is, a particular grapheme is realized by particular glyphs. More than one glyph can realize the same grapheme. For instance, the letter A  and its cursive equivalent are each realizations of the grapheme Latin Capital Letter A.
    /// <see href="http://purl.org/linguistics/gold/Grapheme"></see></summary>
    let Grapheme = _prefix "Grapheme"
    /// <summary>
    /// GreaterPaucal is a number property that quantifies the denotation of the nominal element so that it specifies that there are a small number of distinct entities, greater than paucalNumber but less than pluralNumber (semantically similar to 'several' in English).
    /// <see href="http://purl.org/linguistics/gold/GreaterPaucalNumber"></see></summary>
    let GreaterPaucalNumber = _prefix "GreaterPaucalNumber"
    /// <summary>
    /// GreaterPlural is a number property that expresses (a) the fact that there is an excessive number of events or entities denoted by the noun or nominal element, or (b) the fact that the noun or nominal denotes all possible instances. [Kibort and Corbett 2008b]
    /// <see href="http://purl.org/linguistics/gold/GreaterPluralNumber"></see></summary>
    let GreaterPluralNumber = _prefix "GreaterPluralNumber"
    /// <summary>
    /// A term used in Hallidayan grammar to refer to a unit on the rank scale intermediate between clause and word. For example, in the sentence 'The car was parked in the street', 'the car' is a nominal group, 'was parked' is a verbal group, and 'in the street' is an adverbial group. The term Phrase is an equivalent in most other approaches. [Crystal 2008: 22]
    /// <see href="http://purl.org/linguistics/gold/Group"></see></summary>
    let Group = _prefix "Group"
    /// <summary>
    /// A value of Aspect Property assigned to the designated element in the clause when the meaning selected for the clause is that which indicates that the situation spoken about is characteristic of an extended period of time -- so extended that the situation is viewed as characteristic of the whole period. The decision that a situation is characteristic of an extended period of time is not in itself linguistic, but once it has been made, an explicitly habitual form can be used to describe it. Note that the classification of a situation as characteristic of a period of time is not derived directly from the comparison of their length or frequency; hence, the situation may be objectively either long or short, and either frequent or infrequent, with respect to the period it characterises. This is because the way we choose to characterise can involve a component which is objectively small in relation to the whole.
    /// Typically, for an aspect value to be labelled as Habitual, the aspectual meaning has to minimally express habituality, although it may additionally express other temporal, aspectual, or modal meanings, or actionality distinctions. Habituality can in principle be combined with any other semantic aspectual values appropriate to situations that can be protracted in time or iterated [Comrie 1976: 26-32]. Since habituality is concerned with the internal temporal structure of the (extended) event, it can be regarded as a sub-type of imperfectivity. [Kibort 2008c: 7]
    /// <see href="http://purl.org/linguistics/gold/HabitualAspect"></see></summary>
    let HabitualAspect = _prefix "HabitualAspect"
    /// <summary>
    /// HearsayEvidentiality, also called third hand, encodes the fact that the speaker came to believe the content of the expression from a source generally considered less reliable than with a SecondHandEvidential [Palmer 2001: 40].
    /// <see href="http://purl.org/linguistics/gold/HearsayEvidentiality"></see></summary>
    let HearsayEvidentiality = _prefix "HearsayEvidentiality"
    /// <summary>
    /// The class of features describing sounds based on the relative vertical position of the tongue. Note, Ladefoged refers to this feature as High.
    /// <see href="http://purl.org/linguistics/gold/HeightProperty"></see></summary>
    let HeightProperty = _prefix "HeightProperty"
    /// <summary>
    /// HesternalPastTense locates the situation in question somewhere in the span beginning with the period defined culturally as 'yesterday' and extends back through some period that is considered nonremote [Comrie 1985: 87-88; Dahl 1985: 126].
    /// <see href="http://purl.org/linguistics/gold/HesternalPastTense"></see></summary>
    let HesternalPastTense = _prefix "HesternalPastTense"
    /// <summary>
    /// Description of the actual articulatory characteristics of vowels, and taken to specify the highest point of the tongue. In this view each vowel is characterized in terms of the distance of the highest point of the tongue from the roof of the mouth. [Ladefoged and Maddieson 1996: 282-285]
    /// <see href="http://purl.org/linguistics/gold/High"></see></summary>
    let High = _prefix "High"
    /// <summary>
    /// HodiernalFutureTense locates the situation in question after the moment of utterance within the span culturally defined as 'today' [Comrie 1985: 86; Bybee, Perkins and Pagliuca 1994: 247].
    /// <see href="http://purl.org/linguistics/gold/HodiernalFutureTense"></see></summary>
    let HodiernalFutureTense = _prefix "HodiernalFutureTense"
    /// <summary>
    /// HodiernalPastTense locates the situation in question before the moment of utterance within the span culturally defined as 'today' [Comrie 1985: 87; Dahl 1985: 125-126]. Contrasts with PreHodiernalPastTense.
    /// <see href="http://purl.org/linguistics/gold/HodiernalPastTense"></see></summary>
    let HodiernalPastTense = _prefix "HodiernalPastTense"
    /// <summary>
    /// A term sometimes used in the grammatical analysis of verbs, to refer to a type of modal meaning in which an exhortation is made. An example of a hortative usage ('a hortative') is the 'let us' construction in English ('let us pray'). [Crystal 2008: 232]
    /// <see href="http://purl.org/linguistics/gold/HortatoryForce"></see></summary>
    let HortatoryForce = _prefix "HortatoryForce"
    /// <summary>
    /// A grammatical category used for analysis of word-classes displaying such contrasts as masculine/feminine/neuter, animate/inanimate, etc. It is also important to distinguish natural gender, items referring to the sex of real-world entities, and grammatical gender, which does not always correspond to sex, but which has an important role in signaling grammatical relations between words in a sentence. [Crystal 1985: 133]
    /// <see href="http://purl.org/linguistics/gold/HumanGender"></see></summary>
    let HumanGender = _prefix "HumanGender"
    /// <summary>
    /// A term used to describe a language as a whole, with each of its component parts functioning according to an overall convention of usage to enable the members of a speech community to interchange information. Most linguists agree on a 'system of systems', i.e. the arrangement of units on hierarchically ordered and inter-related levels. [Hartmann and Stork 1972: 231]
    /// <see href="http://purl.org/linguistics/gold/LinguisticSystem"></see></summary>
    let LinguisticSystem = _prefix "LinguisticSystem"
    /// <summary>
    /// IllativeCase expresses that  the referent of the noun it marks is the location into which another referent is moving. It has the meaning 'into' [Lyons 1968: 299; Crystal 1985: 152].
    /// <see href="http://purl.org/linguistics/gold/IllativeCase"></see></summary>
    let IllativeCase = _prefix "IllativeCase"
    /// <summary>
    /// ImmediateFutureTense, also called 'close future', locates the situation in question shortly after the moment of utterance [Dahl 1985: 121; Comrie 1985: 94; Bybee, Perkins and Pagliuca 1994: 244-245].
    /// <see href="http://purl.org/linguistics/gold/ImmediateFutureTense"></see></summary>
    let ImmediateFutureTense = _prefix "ImmediateFutureTense"
    /// <summary>
    /// ImmediatePastTense locates the situation in question at a time considered very recent in relation to the moment of utterance [Comrie 1985: 87].
    /// <see href="http://purl.org/linguistics/gold/ImmediatePastTense"></see></summary>
    let ImmediatePastTense = _prefix "ImmediatePastTense"
    /// <summary>
    /// A term used in the grammatical classification of sentence types, and usually seen in contrast to indicative, interrogative, etc. An imperative usage (‘an imperative’) refers to verb forms or sentence/clause types typically used in the expression of commands, e.g. 'Go away!' [Crystal 2008: 23]
    /// <see href="http://purl.org/linguistics/gold/ImperativeForce"></see></summary>
    let ImperativeForce = _prefix "ImperativeForce"
    /// <summary>
    /// A value of Aspect Property assigned to the designated element in the clause when the meaning selected for the clause is that which indicates that the event spoken about is to be looked at from inside, from within its temporal boundaries; imperfective aspect is crucially concerned with the internal temporal structure of the event [Comrie 1976: 16ff].
    ///
    /// Typically, for an aspect value to be labelled as Imperfective, the aspectual meaning has to minimally express the imperfective viewpoint, although it may additionally express other temporal, aspectual, or modal meanings, or actionality distinctions.
    ///
    /// Imperfective aspectual meaning can be further subdivided into two types: habitual meaning and continuous meaning. These two aspectual meanings may or may not be grammaticalised as separate aspect values. [Kibort 2008c: 7]
    /// <see href="http://purl.org/linguistics/gold/ImperfectiveAspect"></see></summary>
    let ImperfectiveAspect = _prefix "ImperfectiveAspect"
    /// <summary>
    /// A Passive that alters the mapping of a nominal to the Subject relation in a basic intransitive structure [Klaiman 1991: 23].
    /// <see href="http://purl.org/linguistics/gold/ImpersonalPassiveVoice"></see></summary>
    let ImpersonalPassiveVoice = _prefix "ImpersonalPassiveVoice"
    /// <summary>
    /// InablativeCase expresses that  the referent of the noun it marks is the location from within which another referent is moving. It has the meaning 'from within'. Kibrik says that Archi (aqc) possesses a nominal spatial form expressing InablativeCase, namely -aš. He gives the example 'aInš-l-a-š' ('aIns' = 'apple'). [Kibrik 1998: 470-471]
    /// <see href="http://purl.org/linguistics/gold/InablativeCase"></see></summary>
    let InablativeCase = _prefix "InablativeCase"
    /// <summary>
    /// InallativeCase expresses that  something is moving toward the region that is inside the referent of the noun it marks. It has the meaning 'towards in(side)'. Kibrik says that Archi (aqc) possesses a nominal spatial form expressing InallativeCase, namely -aši [Kibrik 1998: 470].
    /// <see href="http://purl.org/linguistics/gold/InallativeCase"></see></summary>
    let InallativeCase = _prefix "InallativeCase"
    /// <summary>
    /// A grammatical gender property such that membership in the inanimate grammatical class is largely based on meaning, in that non-living things, such as objects of manufacture and natural 'non-living' things are included in it. For example, one of the two grammatical genders, or noun classes, of Nishnaabemwin, the other being animate [Valentine 2001: 114].
    /// <see href="http://purl.org/linguistics/gold/InanimateGender"></see></summary>
    let InanimateGender = _prefix "InanimateGender"
    /// <summary>
    /// InceptiveAspect, also called the ingressive, encodes the beginning portion of some event [Bybee 1985: 147, 149; Payne 1997: 240; Bhat 1999: 176].
    /// <see href="http://purl.org/linguistics/gold/InceptiveAspect"></see></summary>
    let InceptiveAspect = _prefix "InceptiveAspect"
    /// <summary>
    /// Blocks the patient or logical object (basic absolutive) nominal from being assigned Focus salience. There is no explicit case marking on the patient, and the patient is invariably nonreferential. This correlates with the patient's morphosyntactic downgrading, whereby it becomes insusceptible to any informational salience assignment. [Klaiman 1991: 232-236]
    /// <see href="http://purl.org/linguistics/gold/IncorporatingAntipassiveVoice"></see></summary>
    let IncorporatingAntipassiveVoice = _prefix "IncorporatingAntipassiveVoice"
    /// <summary>
    /// An article is a part of speech whose members are used to refer to an entity (or class of entities) which is not capable of specific identification [Crystal 1997: 193].
    /// <see href="http://purl.org/linguistics/gold/IndefiniteArticle"></see></summary>
    let IndefiniteArticle = _prefix "IndefiniteArticle"
    /// <summary>
    /// An indefinite pronoun is a pronoun that belongs to a class whose members indicate  indefinite reference [Crystal 1997: 312].
    /// <see href="http://purl.org/linguistics/gold/IndefinitePronoun"></see></summary>
    let IndefinitePronoun = _prefix "IndefinitePronoun"
    /// <summary>
    /// A term used in the grammatical classification of sentence types, and usually seen in contrast to imperative, subjunctive, etc., moods. It refers to verb forms or sentence/clause types used in the expression of statements and questions, e.g. the horse is walking. With reference to statements, the term ‘declarative’ may be used. [Crystal 2008: 242]
    /// <see href="http://purl.org/linguistics/gold/IndicativeMood"></see></summary>
    let IndicativeMood = _prefix "IndicativeMood"
    /// <summary>
    /// IndirectEvidentiality, also called reported, encodes the fact that the speaker came to believe the content of the expression from a source other than by experiencing the situation directly [Palmer 2001: 40].
    /// <see href="http://purl.org/linguistics/gold/IndirectEvidentiality"></see></summary>
    let IndirectEvidentiality = _prefix "IndirectEvidentiality"
    /// <summary>
    /// InessiveCase expresses that the referent of the noun it marks is the location within which another referent exists. It has the meaning of 'within' or 'inside' [Lyons 1968: 299; Crystal 1985: 156]. X in Y.
    /// <see href="http://purl.org/linguistics/gold/InessiveCase"></see></summary>
    let InessiveCase = _prefix "InessiveCase"
    /// <summary>
    /// InferentialEvidentiality encodes the fact that the speaker came to believe the content of the expression through some kind of internal inference procedure, e.g., deduction, abduction, induction [Palmer 2001: 6-8].
    /// <see href="http://purl.org/linguistics/gold/InferentialEvidentiality"></see></summary>
    let InferentialEvidentiality = _prefix "InferentialEvidentiality"
    /// <summary>
    /// A term used in morphology referring to an affix which is added within a root or stem. [Crystal 1985: 157]
    /// <see href="http://purl.org/linguistics/gold/Infix"></see></summary>
    let Infix = _prefix "Infix"
    /// <summary>
    /// InflectionalUnit is the class of functional units whose members designate such grammatical categories as tense, aspect, mood etc. The various forms of an InflectionalUnit plus the stem forms a grammatical paradigm and express a grammatical contrast that is obligatory for its stem's part of speech in some given grammatical context. An inflectional unit does not alter the part of speech feature of the root or stem it attaches to. It is typically located farther from its Root than a derivational unit and  produces a predictable, nonidiosyncratic change of meaning [Crystal 1980: 184; Hartmann and Stork 1972: 112; Bybee 1985: 2, 99].
    /// <see href="http://purl.org/linguistics/gold/InflectionalMorpheme"></see></summary>
    let InflectionalMorpheme = _prefix "InflectionalMorpheme"
    /// <summary>
    /// InformationalForce indicates that the hearer is to relate to the informational content of what is expressed. Informational force subsumes Declarative, Speculative and Interrogative force.
    /// <see href="http://purl.org/linguistics/gold/InformationalForce"></see></summary>
    let InformationalForce = _prefix "InformationalForce"
    /// <summary>
    /// InstrumentalCase indicates that the referent of the noun it marks is the means of the accomplishment of the action expressed by the clause [Crystal 1980: 187; Hartmann and Stork 1972: 114].
    /// <see href="http://purl.org/linguistics/gold/InstrumentalCase"></see></summary>
    let InstrumentalCase = _prefix "InstrumentalCase"
    /// <summary>
    /// InterablativeCase expresses that  the referent of the noun it marks is the location from between which another referent is moving. It has the meaning 'from in between'. Kibrik says that Archi (aqc) possesses a nominal spatial form expressing InterablativeCase, namely -qIaš [Kibrik 1998: 470].
    /// <see href="http://purl.org/linguistics/gold/InterablativeCase"></see></summary>
    let InterablativeCase = _prefix "InterablativeCase"
    /// <summary>
    /// InterallativeCase expresses that something is moving toward the region that is in the middle of the referent of the noun it marks. It has the meaning  'towards the middle of'. Kibrik says that Archi (aqc) possesses a nominal spatial form expressing InterallativeCase, namely -qIaši [Kibrik 1998: 470].
    /// <see href="http://purl.org/linguistics/gold/InterallativeCase"></see></summary>
    let InterallativeCase = _prefix "InterallativeCase"
    /// <summary>
    /// InteressiveCase expresses that  the referent of the noun it marks is the location between which another referent exists. It has the meaning of 'between'. Kibrik says that Archi (aqc) possesses a nominal spatial form expressing InteressiveCase, namely -qI [Kibrik 1998: 470].
    /// <see href="http://purl.org/linguistics/gold/InteressiveCase"></see></summary>
    let InteressiveCase = _prefix "InteressiveCase"
    /// <summary>
    /// An interjection is a part of speech, typically brief in form, such as one syllable or word, whose members are used most often as exclamations or parts of an exclamation. An interjection, typically expressing an emotional reaction, often with respect to an accompanying sentence, is not syntactically related to other accompanying expressions, and may include a combination of sounds not otherwise found in the language [Crystal 1997: 200].
    /// <see href="http://purl.org/linguistics/gold/Interjection"></see></summary>
    let Interjection = _prefix "Interjection"
    /// <summary>
    /// InterlativeCase expresses that  the referent of the noun it marks is the location between which another referent is moving. It has the meaning 'to the middle of'. Kibrik says that Archi (aqc) possesses a nominal spatial form expressing InterlativeCase, namely -qIak [Kibrik 1998: 470].
    /// <see href="http://purl.org/linguistics/gold/InterlativeCase"></see></summary>
    let InterlativeCase = _prefix "InterlativeCase"
    /// <summary>
    /// Interlinear glossed text (IGT) is a linguistic data structure meant to display morphosyntactic structure: morphemes, morpheme boundaries, morpheme types (clitics, prefixes, reduplicated forms), morphosyntactic features/values and part of speech information. At a minimum, an instance of IGT includes a single line of source language followed by a translation line. Often, a second gloss line is included to show detailed morphosyntactic structure using both words and phrases from the target language and various labels, or 'grams', that indicate morphosyntactic features/values, etc. It is possible to include separate lines for the orthographic form, phonetic form, and phonological form. Standards for IGT include the Leipzig Glossing Rules.
    /// <see href="http://purl.org/linguistics/gold/InterlinearGlossedText"></see></summary>
    let InterlinearGlossedText = _prefix "InterlinearGlossedText"
    /// <summary>
    /// Expresses the notion of something moving into the inside of a reference of the noun it marks. It has the meaning 'into the inside of'. Kibrik says that Archi (aqc) possesses a nominal spatial form expressing InterminativeCase, namely -akana [Kibrik 1998: 470].
    /// <see href="http://purl.org/linguistics/gold/InterminativeCase"></see></summary>
    let InterminativeCase = _prefix "InterminativeCase"
    /// <summary>
    /// A term used in the grammatical classification of sentence types, and usually seen in contrast to declarative. It refers to verb forms or sentence/clause types typically used in the expression of questions, e.g. the inverted order of 'is he coming?' or the use of an interrogative word (or simple ‘interrogative’), often subclassified as interrogative adjectives (e.g. which), adverbs (e.g. why) and pronouns (e.g. who). [Crystal 2008: 245]
    /// <see href="http://purl.org/linguistics/gold/InterrogativeForce"></see></summary>
    let InterrogativeForce = _prefix "InterrogativeForce"
    /// <summary>
    /// Also referred to as a 'question particle', an interrogative operator is a category whose members signal a yes/no question [Payne 1997: 296].
    /// <see href="http://purl.org/linguistics/gold/InterrogativeOperator"></see></summary>
    let InterrogativeOperator = _prefix "InterrogativeOperator"
    /// <summary>
    /// An InterrogativeProform is a Proform that is used in questions to stand for the item questioned. [Schachter 1985: 34]
    /// <see href="http://purl.org/linguistics/gold/InterrogativeProform"></see></summary>
    let InterrogativeProform = _prefix "InterrogativeProform"
    /// <summary>
    /// A ProForm is a partOfSpeech whose members usually substitute for other constituents, including phrases, clauses, or sentences, and whose meaning is recoverable from the linguistic or extralinguistic context [Crystal 1997: 310; Schachter 1985: 24-25].
    /// <see href="http://purl.org/linguistics/gold/ProForm"></see></summary>
    let ProForm = _prefix "ProForm"
    /// <summary>
    /// InterterminativeCase expresses the notion of something moving into the middle of the referent of the noun it marks, but not through it. It has the meaning 'into the middle of'. Kibrik says that Archi (aqc) possesses a nominal spatial form expressing InterterminativeCase, namely -qIakana [Kibrik 1998: 470].
    /// <see href="http://purl.org/linguistics/gold/InterterminativeCase"></see></summary>
    let InterterminativeCase = _prefix "InterterminativeCase"
    /// <summary>
    /// IntertranslativeCase expresses the notion of something moving along a trajectory between the referent of the noun it marks. It has the meaning 'along the in between'. Kibrik says that Archi (aqc) possesses a nominal spatial form expressing IntertranslativeCase, namely -qIaXut [Kibrik 1998: 470].
    /// <see href="http://purl.org/linguistics/gold/IntertranslativeCase"></see></summary>
    let IntertranslativeCase = _prefix "IntertranslativeCase"
    /// <summary>
    /// An intransitive verb is a verb that cannot take a direct object, and describes a property, state, or situation involving only one participant [Crystal 1997: 397; Payne 1997: 171].
    /// <see href="http://purl.org/linguistics/gold/IntransitiveVerb"></see></summary>
    let IntransitiveVerb = _prefix "IntransitiveVerb"
    /// <summary>
    /// UnaryPredicator is the class of syntactic words that take only one required argument.
    /// <see href="http://purl.org/linguistics/gold/UnaryPredicator"></see></summary>
    let UnaryPredicator = _prefix "UnaryPredicator"
    /// <summary>
    /// A derivational unit that derives an intransitive verb from a transitive verb. [Hornby 2010 (p.c.)]
    /// <see href="http://purl.org/linguistics/gold/Intransitivizer"></see></summary>
    let Intransitivizer = _prefix "Intransitivizer"
    /// <summary>
    /// IntranslativeCase expresses the notion of something moving through the referent of the noun it marks. It has the meaning 'along through'. Kibrik says that Archi (aqc) possesses a nominal spatial form expressing IntranslativeCase, namely -aXut [Kibrik 1998: 470].
    /// <see href="http://purl.org/linguistics/gold/IntranslativeCase"></see></summary>
    let IntranslativeCase = _prefix "IntranslativeCase"
    /// <summary>
    /// Signals when actions proceed from ontologically less salient to more salient participants. [Klaiman 1991: 32]
    /// <see href="http://purl.org/linguistics/gold/InverseVoice"></see></summary>
    let InverseVoice = _prefix "InverseVoice"
    /// <summary>
    /// Where the proposition is weakly asserted to be true, but the speaker is not ready to support the assertion. Irrealis adverbs include 'maybe' and 'hopefully'. [Crystal 2008: 403]
    /// <see href="http://purl.org/linguistics/gold/IrrealisMood"></see></summary>
    let IrrealisMood = _prefix "IrrealisMood"
    /// <summary>
    /// Isolate is the class of human language varieties such that there are no other varieties that are genetically related.
    /// <see href="http://purl.org/linguistics/gold/Isolate"></see></summary>
    let Isolate = _prefix "Isolate"
    /// <summary>
    /// IterativeAspect, also called repetitive, encodes a number of events of the same type that are repeated on a particular occasion. The time interval which is relevant to the iterative is relatively shorter than in the case of the habitual [Bybee 1985: 150; Bybee, Perkins and Pagliuca 1994: 127]. Portrays events repeated on the same occasion (like the iterative knocking on the door) [Bhat 1999: 53].
    /// <see href="http://purl.org/linguistics/gold/IterativeAspect"></see></summary>
    let IterativeAspect = _prefix "IterativeAspect"
    /// <summary>
    /// The jussive has syntactic force and is directive in that it signals a speaker's command, permission, or agreement that the proposition expressed by his or her utterance be brought about. The jussive is typically applicable in the first and third person. [Chung and Timberlake 1985: 247; Pei and Gaynor 1954: 110; Palmer 1986: 10, 24, 39-40, 96, 110, 113, Schade 2005: 52]
    /// <see href="http://purl.org/linguistics/gold/JussiveForce"></see></summary>
    let JussiveForce = _prefix "JussiveForce"
    /// <summary>
    /// Characterizing sounds produced by the blade of the tongue  [Ladefoged 1997: 596].
    /// <see href="http://purl.org/linguistics/gold/Laminal"></see></summary>
    let Laminal = _prefix "Laminal"
    /// <summary>
    /// The most fundamental means of human communication. Language is a purely human activity, although some animals have communication systems which have certain analogies to human language. All human beings use language to interact with other members of the same speech community. Language is not only used as an instrument of communication, however, but also as a means of individual expression. Language is not instinctive; it has to be learnt as a system of arbitrary conventional symbols. Such symbols are primarily vocal, produced by the so-called organs of speech, but secondary systems such as writing and other codes may complement the vocalsystem. Some linguists, such as F. de Saussure, have stressed the view of language as general patterns in the speech of a community and as the speaking activity of an individual in a particular situation; others, with N.Chomsky, regard language as the innate capability of native speakers to understand and form grammatical sentences as as the actual utterances produced at a given time. [Hartmann and Stork 1972: 123-124]
    /// <see href="http://purl.org/linguistics/gold/Language"></see></summary>
    let Language = _prefix "Language"
    /// <summary>
    /// Group of languages that are genetically related, i.e can be traced to a common proto-language. The ordering of languages into a common language family is usually based on phonological, morphological, and lexical correspondences that stem from the proto-language. ... it refers to the largest spectrum of languages for which a genetic relationship can be demonstrated. [Bussmann 1996: 262]
    /// <see href="http://purl.org/linguistics/gold/LanguageFamily"></see></summary>
    let LanguageFamily = _prefix "LanguageFamily"
    /// <summary>
    /// A term used for postulated but undemonstrated higher-order, more inclusive families (proposed but as yet unproven distant genetic relationships). [Campbell 1999: 187]
    /// <see href="http://purl.org/linguistics/gold/LanguageStock"></see></summary>
    let LanguageStock = _prefix "LanguageStock"
    /// <summary>
    /// LanguageSubfamily (also called subgroup or branch) refers 'to a group of languages within a language family which are more closely related to each other than to other languages of that family.' [Campbell 1999: 187]
    /// <see href="http://purl.org/linguistics/gold/LanguageSubfamily"></see></summary>
    let LanguageSubfamily = _prefix "LanguageSubfamily"
    /// <summary>
    /// Characterizing sounds produced with a release of air through the sides of the mouth. (Note, [Ladefoged 1997] refers to this as lateral.)
    /// <see href="http://purl.org/linguistics/gold/LateralEscape"></see></summary>
    let LateralEscape = _prefix "LateralEscape"
    /// <summary>
    /// LativeCase expresses 'motion up to the location of,' or 'as far as' the referent of the noun it marks [Pei and Gaynor 1954: 121].
    /// <see href="http://purl.org/linguistics/gold/LativeCase"></see></summary>
    let LativeCase = _prefix "LativeCase"
    /// <summary>
    /// A unit of the vocabulary of a language such as a word, phrase or term as listed in a dictionary. It usually has a pronounceable or graphic form, fulfils a grammatical role in a sentence, and carries semantic meaning. [Hartmann and Stork 1972: 128]
    /// <see href="http://purl.org/linguistics/gold/LexicalItem"></see></summary>
    let LexicalItem = _prefix "LexicalItem"
    /// <summary>
    /// Grammatical or semantic category expressed by a lexical item, e.g. English 'make' + 'dead' together are lexicalized as 'kill', in German 'tot' + 'machen' &gt; 'töten', or the close linking of lexical items in an idiomatic phrase. [Hartmann and Stork 1972: 129]
    /// <see href="http://purl.org/linguistics/gold/LexicalizedConcept"></see></summary>
    let LexicalizedConcept = _prefix "LexicalizedConcept"
    /// <summary>
    /// A SemanticUnit is the class of semantics elements, or units of semantic structure (sometimes called a sememe). Semantic units serve as the meaning component of linguistic signs. A semantic unit is intended for linguistic description and no particular logical representation is implied.
    /// <see href="http://purl.org/linguistics/gold/SemanticUnit"></see></summary>
    let SemanticUnit = _prefix "SemanticUnit"
    /// <summary>
    /// In its most general sense, the term is synonymous with vocabulary. A dictionary can be seen as a set of lexical entries. The lexicon has a special status in generative grammar, where it refers to the component containing all the information about the structural properties of the lexical items in a language. [Crystal 2008: 278] In linguistics, ... we don't normally speak of the vocabulary of a particular language; instead, we speak of the lexicon, the total store of words available to a speaker. Very commonly, the lexicon is not regarded merely as a long list of words. Rather, we conceive the lexicon as a set of lexical resources, including the morphemes of the languages, plus the processes available in the language for constructing words from those resources. Apart from the lexicon of a language as a whole, psycholinguists are interested in the mental lexicon, the words and lexical resources stored in an individual brain. [Trask 1999: 166-167]
    /// <see href="http://purl.org/linguistics/gold/Lexicon"></see></summary>
    let Lexicon = _prefix "Lexicon"
    /// <summary>
    /// The merging of two or more letters (often for aesthetic reasons) from which a single, independent form is derived. [Bussmann 1996: 281]
    /// <see href="http://purl.org/linguistics/gold/Ligature"></see></summary>
    let Ligature = _prefix "Ligature"
    /// <summary>
    /// A LinguisticExpression is any physical form (sound, visual image or sequence thereof) used to represent a linguistic unit. A linguistic expression may be spoken, written, or signed. A linguistic expression is distinct form the actual process (speaking, writing, signing) that produces the expression.
    /// <see href="http://purl.org/linguistics/gold/LinguisticExpression"></see></summary>
    let LinguisticExpression = _prefix "LinguisticExpression"
    /// <summary>
    /// Corresponds roughly to the class of ordinary objects. Examples include normal physical objects, geographical regions, and locations of processes, the complement of objects in the physical class. In a 4D ontology, an object is something whose spatiotemporal extent is thought of as dividing into spatial parts roughly parallel to the time-axis. [SUMO 2010]
    /// <see href="http://purl.org/linguistics/gold/Object"></see></summary>
    let Object = _prefix "Object"
    /// <summary>
    /// A linguistic sign is an abstract structure whose instances participate in a linguistic system, or language. By definition, a linguistic sign must have a form component (whose elements are phonological units), a grammatical component (whose elements are grammatical units), and a meaning component (whose elements are semantic units). The formal structure of a linguistic sign is determined by the grammar of a language. The information value of a linguistic sign, its meaning, is not fixed, but determined by the conventions of the language. The relation of form to meaning is largely arbitrary within a semiotic system. Signs are classified primarily according to what kinds of formal relations they participate in, and, secondly, according to their complexity (whether they are atomic or composed of other signs). Signs range from morphological and syntactic constructions to whole discourse segments [de Saussure 1983; Hervey 1979; Pollard and Sag 1994].
    /// <see href="http://purl.org/linguistics/gold/LinguisticSign"></see></summary>
    let LinguisticSign = _prefix "LinguisticSign"
    /// <summary>
    /// Taxon is the class of scientific categories used to create a taxonomy and determined according to scientific principles in a given domain, e.g., Biology or Linguistics.
    /// <see href="http://purl.org/linguistics/gold/Taxon"></see></summary>
    let Taxon = _prefix "Taxon"
    /// <summary>
    /// A language which is the current native language of a speech community. [Hartmann and Stork 1972: 133]
    /// <see href="http://purl.org/linguistics/gold/LivingVariety"></see></summary>
    let LivingVariety = _prefix "LivingVariety"
    /// <summary>
    /// (adj./n.) In languages which express grammatical relationships by means of inflections, this term refers to the form taken by a noun phrase (often a single noun or pronoun), when it typically expresses the idea of location of an entity or action. Structures which express locational meaning may also be referred to as locative, e.g. in 'The woman was standing at a bus stop', 'at a bus stop' could be called a locative phrase. [Crystal 2008: 288]
    /// <see href="http://purl.org/linguistics/gold/LocativeCase"></see></summary>
    let LocativeCase = _prefix "LocativeCase"
    /// <summary>
    /// An oblique locative nominal assumes the subject relation [Klaiman 1991: 17].
    /// <see href="http://purl.org/linguistics/gold/LocativePassiveVoice"></see></summary>
    let LocativePassiveVoice = _prefix "LocativePassiveVoice"
    /// <summary>
    /// Articulated with the highest point of the tongue more or less maximally distant from the roof of the mouth. In the SPE feature system, a distinctive feature defined as 'articulated with the body of the tongue below the neutral position.' [Trask 1996: 212]
    /// <see href="http://purl.org/linguistics/gold/Low"></see></summary>
    let Low = _prefix "Low"
    /// <summary>
    /// MainClause is the class of clauses that can stand on their own as a  full, independent sentence.  If a sentence contains any embedded clauses, the main clause is understood as the matrix plus the embedded clauses. In the sentence 'John thinks that Mary is sick', 'John thinks that Mary is sick' is the main clause. [Crystal 2001: 231]
    /// <see href="http://purl.org/linguistics/gold/MainClause"></see></summary>
    let MainClause = _prefix "MainClause"
    /// <summary>
    /// Opposite of BenefactiveCase; used when the marked noun is adversely affected in the clause. [Zúñiga and Kittilä 2010: 5]
    /// <see href="http://purl.org/linguistics/gold/MalefactiveCase"></see></summary>
    let MalefactiveCase = _prefix "MalefactiveCase"
    /// <summary>
    /// A sound property referring to the kind of articulatory process used in a sound's production.  The distinction between vowel and consonant is usually made in terms of manner of articulation.  Within consonants, several articulatory types are recognized based on the type of closure made by the vocal organs.  Within vowels, classification  is based on the number of auditory qualities distinguishable in the sound, the position of the soft palate, and the type of lip position. [Crystal 1997: 232]
    /// <see href="http://purl.org/linguistics/gold/MannerProperty"></see></summary>
    let MannerProperty = _prefix "MannerProperty"
    /// <summary>
    /// The supralaryngeal node dominates the activity of all of the articulators except stiffening and slacking of the vocal folds. For consonants it can be viewed as the default node which comes into play when the supranasal node below it is deactivated. In the case of sounds produced by an articulator dominated by this node, the only possible segments are those which are traditionally classified as [-consonantal]. It is not necessary to specify manner features for sounds dominated by the supralaryngeal node, because they are redundantly determined. [Keyser and Stevens 1994: 216]
    /// <see href="http://purl.org/linguistics/gold/SupraLaryngealProperty"></see></summary>
    let SupraLaryngealProperty = _prefix "SupraLaryngealProperty"
    /// <summary>
    /// A gender property established on the basis of agreement, to which nouns may be assigned based on semantic or formal criteria.  In semantic gender systems, nouns belonging to the masculine gender typically denote male humans as well as nouns meeting certain physical criteria.  Some gender systems differentiate masculine nouns from all other nouns (e.g. masculine/other or male human/other), while others differentiate masculine, feminine and neuter nouns or several different gender classes. [Corbett 1991: 30]
    /// <see href="http://purl.org/linguistics/gold/MasculineGender"></see></summary>
    let MasculineGender = _prefix "MasculineGender"
    /// <summary>
    /// MentalAbilitiveModality indicates that an agent has the  capacity to perform some mental action [Bybee, Perkins and Pagliuca 1994: 192; Palmer 2001: 77].
    /// <see href="http://purl.org/linguistics/gold/MentalAbilitiveModality"></see></summary>
    let MentalAbilitiveModality = _prefix "MentalAbilitiveModality"
    /// <summary>
    /// Characterizing sounds articulated between the high and low tongue positions. [Crystal 1987: 425]
    /// <see href="http://purl.org/linguistics/gold/Mid"></see></summary>
    let Mid = _prefix "Mid"
    /// <summary>
    /// MinusATR (Advanced Tongue Root) characterizes sounds made in which there is no advancement of the tongue root or lowering of the larynx. [Ladefoged 2000: 211]
    /// <see href="http://purl.org/linguistics/gold/MinusATR"></see></summary>
    let MinusATR = _prefix "MinusATR"
    /// <summary>
    /// The class of place  properties used to classifiy articulatory gestures made with the root of the tongue. [Ladefoged 1997: 603]
    /// <see href="http://purl.org/linguistics/gold/RadicalProperty"></see></summary>
    let RadicalProperty = _prefix "RadicalProperty"
    /// <summary>
    /// MinusClick refers to not having the properties of a click.  Clicks are stops in which the essential component is the rarefaction of air enclosed between two articulatory closures formed in the oral cavity, so that a loud transient is produced when the more forward closure is released.  This uses the velaric airstream mechanism, always ingressive, and cannot be used for sounds other than stops and affricates.  [Ladefoged and Maddieson 1996: 246]
    /// <see href="http://purl.org/linguistics/gold/MinusClick"></see></summary>
    let MinusClick = _prefix "MinusClick"
    /// <summary>
    /// Velaric refers to an air-stream mechanism wherein the air is generated by a closure at the velar position, rather than an air-stream generated by the lungs. The back of the tongue is raised against the velum, and articulations are made farther forward by the lips or front parts of the tongue, drawing air into or pushing air out of the mouth. The clicks of some African languages are produced in this way. In English, they may be heard in the 'tut tut' sound. [Crystal 1985: 325-326; Hartmann and Stork 1972: 8]
    /// <see href="http://purl.org/linguistics/gold/VelaricProperty"></see></summary>
    let VelaricProperty = _prefix "VelaricProperty"
    /// <summary>
    /// MinusFortis refers to a sound made without relatively strong degree of muscular effort and breath force.  [Crystal 1985: 126]
    /// <see href="http://purl.org/linguistics/gold/MinusFortis"></see></summary>
    let MinusFortis = _prefix "MinusFortis"
    /// <summary>
    /// Pulmonic refers to an air-stream mechanism wherein the air is generated in the lungs and pushed out under the control of the respiratory muscles. [Ladefoged 2000: 122]
    /// <see href="http://purl.org/linguistics/gold/PulmonicProperty"></see></summary>
    let PulmonicProperty = _prefix "PulmonicProperty"
    /// <summary>
    /// Characterizing sounds in which the palatal tensor muscles and the levator palatine muscle raise the velum, preventing air from escaping through the nose. [Kenstowicz 1994: 143; Ladefoged 2000: 274]
    /// <see href="http://purl.org/linguistics/gold/MinusNasal"></see></summary>
    let MinusNasal = _prefix "MinusNasal"
    /// <summary>
    /// The class of properties that describe the degree to which the velum or soft palate is raised or lowered, allowing or prohibiting air from escaping through the nose. [Kenstowicz 1994: 143]
    /// <see href="http://purl.org/linguistics/gold/NasalityProperty"></see></summary>
    let NasalityProperty = _prefix "NasalityProperty"
    /// <summary>
    /// A part of speech, usually associated with a verbal system, that expresses the concept of necessity and possibility, as well as the subject's attitude toward the factuality or actualization of the situation expressed by the rest of the clause.  Modals can code inception, termination, persistence, success, failure, attempt, intent, obligation or ability vis-a-vis the complement state/event, and the subject of the main clause is obligatorily also the subject of the complement clause. [Palmer 2001: 2; Givon 1984: 533; Huddleston and Pullam 2002: 173]
    /// <see href="http://purl.org/linguistics/gold/Modal"></see></summary>
    let Modal = _prefix "Modal"
    /// <summary>
    /// Regular vibrations of the vocal folds at any frequency within the speaker's normal range.  [Ladefoged and Maddieson 1996:  48]
    /// <see href="http://purl.org/linguistics/gold/ModalVoice"></see></summary>
    let ModalVoice = _prefix "ModalVoice"
    /// <summary>
    /// Mora refers to the several parts of the phoneme which may receive divergent tonal treatments [Pei and Gaynor 1980: 138].  A mora also can refer to a minimal unit of metrical time equivalent to a short syllable [Crystal 1985: 198].
    /// <see href="http://purl.org/linguistics/gold/Mora"></see></summary>
    let Mora = _prefix "Mora"
    /// <summary>
    /// Multal is a number property that refers to a large number of individuals.
    /// <see href="http://purl.org/linguistics/gold/MultalNumber"></see></summary>
    let MultalNumber = _prefix "MultalNumber"
    /// <summary>
    /// A multiplicative numeral is a numeral that expresses how many fold or how many times [Pei and Gaynor 1954: 149; Hartmann and Stork 1972: 147].
    /// <see href="http://purl.org/linguistics/gold/MultiplicativeNumeral"></see></summary>
    let MultiplicativeNumeral = _prefix "MultiplicativeNumeral"
    /// <summary>
    /// In languages which distinguish different degrees of remoteness in the future, the near future refers to the least remote future.  [Comrie 1985: 46]
    /// <see href="http://purl.org/linguistics/gold/NearFutureTense"></see></summary>
    let NearFutureTense = _prefix "NearFutureTense"
    /// <summary>
    /// The class of languages that have relatively few native speakers. A nearly extinct variety is expected to become extrinct in a short time period, e.g., Jebero or Wichita.
    /// <see href="http://purl.org/linguistics/gold/NearlyExtinctVariety"></see></summary>
    let NearlyExtinctVariety = _prefix "NearlyExtinctVariety"
    /// <summary>
    /// A passive in Irish in which the preposition "with" is used, and a semantic meaning of necessity is added [Noonan 1994: 280].
    /// <see href="http://purl.org/linguistics/gold/NecessitativePassiveVoice"></see></summary>
    let NecessitativePassiveVoice = _prefix "NecessitativePassiveVoice"
    /// <summary>
    /// NecessityModality indicates that the described state of affairs is necessary [Palmer 2001: 89-90], either directly, or because of a requirement on the part of an agent [Bybee, Perkins and Pagliuca 1994: 177].
    /// <see href="http://purl.org/linguistics/gold/NecessityModality"></see></summary>
    let NecessityModality = _prefix "NecessityModality"
    /// <summary>
    /// NegationOperator is a negative-marking phrase located in scope position of the verb (specifier or adjoined position).  Also called a "negation particle", it is normally associated with the main verb of the clause but may also be a clause-level clitic.[Payne 2007:284; Haegeman 1995: 107, 286]
    /// <see href="http://purl.org/linguistics/gold/NegationOperator"></see></summary>
    let NegationOperator = _prefix "NegationOperator"
    /// <summary>
    /// A construction that expresses the contradiction of some or all of a proposition [Crystal 1980: 257]. Note: this value is not to be confused with the notion "Negative Polarity Item", which is an expression that occurs in the scope of Negation (i.e. Negative Polarity).
    /// <see href="http://purl.org/linguistics/gold/NegativePolarity"></see></summary>
    let NegativePolarity = _prefix "NegativePolarity"
    /// <summary>
    /// The property concerned with encoding the system of positive/negative contrastivity found in a language.  The distinction between 'positive' and 'negative polarity' may be expressed syntactically, morphologically or lexically. [Crystal 1997: 297]
    /// <see href="http://purl.org/linguistics/gold/PolarityProperty"></see></summary>
    let PolarityProperty = _prefix "PolarityProperty"
    /// <summary>
    /// A gender property established on the basis of agreement, to which nouns may be assigned, either by a semantic rule, if they belong to the semantic residue of the assignment system, or by a formal rule, if assignment depends on inflectional class membership. Typically, this means that the neuter gender may cover some inanimates and possibly some portion of lower order animates. Note: Although in familiar Indo-European languages the term neuter gender may be part of a system with three or less values, it can be used for systems containing more than three gender values (e.g. Bininj Gunwok). [Kibort and Corbett 2008a]
    /// <see href="http://purl.org/linguistics/gold/NeuterGender"></see></summary>
    let NeuterGender = _prefix "NeuterGender"
    /// <summary>
    /// A nominal is a partOfSpeech whose members differ grammatically from a substantive but which functions as one [Crystal 1997: 260].
    /// <see href="http://purl.org/linguistics/gold/Nominal"></see></summary>
    let Nominal = _prefix "Nominal"
    /// <summary>
    /// A classifier used within a system of noun classes where the morphosyntactic loci are adjectives and, rarely, numerals, as modifiers. Nominal classifiers have all the properties of noun class system classifiers with differences regarding the size of the system (bigger); semantics (animacy/sex/shape/size), transparency of semantic basis (may be opaque), variability of assignment (possible), use in multiple classifier systems (possible), and interrelations with other categories (only with number). [Aikhenvald 2003: 68]
    /// <see href="http://purl.org/linguistics/gold/NominalClassifier"></see></summary>
    let NominalClassifier = _prefix "NominalClassifier"
    /// <summary>
    /// A nominal particle is a member of a closed class of particles that co-occur with nouns.
    /// <see href="http://purl.org/linguistics/gold/NominalParticle"></see></summary>
    let NominalParticle = _prefix "NominalParticle"
    /// <summary>
    /// A term used to refer to an invariable item with grammatical function, especially one which does not readily fit into a standard classification of parts of speech. [Crystal 1997: 279-280]
    /// <see href="http://purl.org/linguistics/gold/Particle"></see></summary>
    let Particle = _prefix "Particle"
    /// <summary>
    /// A derivational unit that forms a noun from some other word class. [Crystal 1997: 260]
    /// <see href="http://purl.org/linguistics/gold/Nominalizer"></see></summary>
    let Nominalizer = _prefix "Nominalizer"
    /// <summary>
    /// NominativeCase identifies clause subjects in nominative-accusative languages. It is usually the unmarked case. Nouns used in isolation often have this case. [Crystal 1980: 242; Pei and Gaynor 1954: 147; Hartmann and Stork 1972: 224]
    /// <see href="http://purl.org/linguistics/gold/NominativeCase"></see></summary>
    let NominativeCase = _prefix "NominativeCase"
    /// <summary>
    /// An Antipassive in which the patient or logical object is not supressed, as is the case in the Absolutive Antipassive, but rather, is overtly downgraded. Some Mayanists distinguish between two types of Non Absolutive Antipassives: the Focus Antipassive and the Incorporating Antipassive. [Klaiman 1991: 232]
    /// <see href="http://purl.org/linguistics/gold/NonAbsolutiveAntipassiveVoice"></see></summary>
    let NonAbsolutiveAntipassiveVoice = _prefix "NonAbsolutiveAntipassiveVoice"
    /// <summary>
    /// NonFutureTense locates the situation in question at or before the moment of utterance, and contrasts with a FutureTense [Comrie 1985: 49].
    /// <see href="http://purl.org/linguistics/gold/NonFutureTense"></see></summary>
    let NonFutureTense = _prefix "NonFutureTense"
    /// <summary>
    /// NonPastTense locates the situation in question at or after the moment of utterance, and contrasts with a past tense [Comrie 1985: 48-49].
    /// <see href="http://purl.org/linguistics/gold/NonPastTense"></see></summary>
    let NonPastTense = _prefix "NonPastTense"
    /// <summary>
    /// A value of Aspect Property (also stative aspect) assigned to the designated element in the clause when the meaning selected for the clause is that which indicates that the situation spoken about has internal temporal structure, it cannot be regarded as habitual, but is regarded as a continuing state. Hence, Nonprogressive Aspect can be regarded as a sub-type of continuousness (which, in turn, is a sub-type of imperfectivity). Since languages have different criteria for classifying predicates as stative or not, they may have different rules for determining when explicitly nonprogressive (i.e. explicitly stative) forms can be used.
    ///
    /// Typically, for an aspect value to be labelled as Nonprogressive, the aspectual meaning has to minimally express nonprogressiveness, although it may additionally express other temporal, aspectual, or modal meanings, or actionality distinctions. [Kibort 2008c: 8]
    /// <see href="http://purl.org/linguistics/gold/NonProgressiveAspect"></see></summary>
    let NonProgressiveAspect = _prefix "NonProgressiveAspect"
    /// <summary>
    /// Involves demotion of the non-topical obviate-agent from subjecthood [Givon 1994: 24].
    /// <see href="http://purl.org/linguistics/gold/NonPromotionalInverseVoice"></see></summary>
    let NonPromotionalInverseVoice = _prefix "NonPromotionalInverseVoice"
    /// <summary>
    /// A classifier is a partOfSpeech whose members express the classification of a noun [Crystal 1997: 61; Payne 1997: 107].
    /// <see href="http://purl.org/linguistics/gold/NounClassifier"></see></summary>
    let NounClassifier = _prefix "NounClassifier"
    /// <summary>
    /// Also called nominal groups, nouns phrases are the constructions into which nouns most commonly enter and of which they are the head word.  The structure of a noun phrase consists minimally of the noun (or noun substitute, such as a pronoun); the constructions preceding and following the noun are often described under the headings of premodification and postmodification respectively. [Crystal 2008: 320]
    /// <see href="http://purl.org/linguistics/gold/NounPhrase"></see></summary>
    let NounPhrase = _prefix "NounPhrase"
    /// <summary>
    /// Object of action belongs to. Moves into, or moves from sphere of subject [Siewierska 1988: 257].
    /// <see href="http://purl.org/linguistics/gold/NucleonicMiddleVoice"></see></summary>
    let NucleonicMiddleVoice = _prefix "NucleonicMiddleVoice"
    /// <summary>
    /// A quantifier is a determiner that expresses a referent's definite or indefinite  number or amount. A quantifier functions as a modifier of a noun, or a pronoun. [Crystal 1997: 317]
    /// <see href="http://purl.org/linguistics/gold/Quantifier"></see></summary>
    let Quantifier = _prefix "Quantifier"
    /// <summary>
    /// Numeral classifiers are free or bound morphemes that occur in the context of quantification, appearing contiguous to numerals in numeral noun phrases and expressions of quantity. [Aikhenvald 2003: 98; Aikhenvald in Senft 2000: 93]
    /// Numeral classifiers are a grammatical device that reflects how speakers categorize objects that they count or quantify [Yamamoto 2005: 1].  They are a set of classifiers used in certain languages, e.g., Japanese, to indicate the class to which the noun modified by the numeral belongs [Pei and Gaynor 1980: 23].
    /// <see href="http://purl.org/linguistics/gold/NumeralClassifier"></see></summary>
    let NumeralClassifier = _prefix "NumeralClassifier"
    /// <summary>
    /// ObligativeModality indicates that an agent is required to perform the action expressed by the predicate [Bybee, Perkins and Pagliuca 1994: 177; Palmer 2001: 71].
    /// <see href="http://purl.org/linguistics/gold/ObligativeModality"></see></summary>
    let ObligativeModality = _prefix "ObligativeModality"
    /// <summary>
    /// In a direct/oblique system or in a nominative/oblique system, oblique case is the term for all roles not marked by the direct case or nominative case.  In the phrase 'the oblique cases' it is used to refer to a set of cases excluding the nominative (occasionally the nominative or accusative).  [Bauer 2004: 27]
    /// <see href="http://purl.org/linguistics/gold/ObliqueCase"></see></summary>
    let ObliqueCase = _prefix "ObliqueCase"
    /// <summary>
    /// A Passive in which a basic Oblique nominal assumes the Subject relation in a corresponding nonbasic configuration.  Can include locative passives, benefactive passives and instrumental passives. [Klaiman 1991: 23]
    /// <see href="http://purl.org/linguistics/gold/ObliquePassiveVoice"></see></summary>
    let ObliquePassiveVoice = _prefix "ObliquePassiveVoice"
    /// <summary>
    /// An explicit specification of a representational vocabulary for a shared domain of discourse.  [Gruber 1993: 199]
    /// <see href="http://purl.org/linguistics/gold/Ontology"></see></summary>
    let Ontology = _prefix "Ontology"
    /// <summary>
    /// Optative indicates that the speaker wishes or hopes that the expressed proposition be the case [Bybee, Perkins and Pagliuca 1994: 179; Palmer 2001: 204].
    /// <see href="http://purl.org/linguistics/gold/OptativeMood"></see></summary>
    let OptativeMood = _prefix "OptativeMood"
    /// <summary>
    /// An ordinal numeral is a numeral belonging to a class whose members designate positions in a sequence [Crystal 1997: 272].
    /// <see href="http://purl.org/linguistics/gold/OrdinalNumeral"></see></summary>
    let OrdinalNumeral = _prefix "OrdinalNumeral"
    /// <summary>
    /// A WrittenLinguisticExpression is the written physical form of language as distinct from either signed or spoken expressions. A written expression is the physical product of the writing process.
    /// <see href="http://purl.org/linguistics/gold/WrittenLinguisticExpression"></see></summary>
    let WrittenLinguisticExpression = _prefix "WrittenLinguisticExpression"
    /// <summary>
    /// An OrthographicPhrase is a sequence of orthographic words.
    /// <see href="http://purl.org/linguistics/gold/OrthographicPhrase"></see></summary>
    let OrthographicPhrase = _prefix "OrthographicPhrase"
    /// <summary>
    /// An OrthographicSentence is a special type of orthographic phrase, usually representing a clause. In Western writing systems, an orthographic sentence is set off by white space on the left edge and some kind of puncuation, such as a period or question mark, on the right.
    /// <see href="http://purl.org/linguistics/gold/OrthographicSentence"></see></summary>
    let OrthographicSentence = _prefix "OrthographicSentence"
    /// <summary>
    /// A system of the art and rules of spelling according to the accepted standards, i.e., the use of the written characters of a language for forming words and sentences in conformity with the rules conventionally recognized as correct.  [Pei and Gaynor 1980: 155]
    /// <see href="http://purl.org/linguistics/gold/OrthographicSystem"></see></summary>
    let OrthographicSystem = _prefix "OrthographicSystem"
    /// <summary>
    /// An OrthographicWord is a fundamental unit of an orthography, usually set off by white space and dependent on the rules of a writing system.
    /// <see href="http://purl.org/linguistics/gold/OrthographicWord"></see></summary>
    let OrthographicWord = _prefix "OrthographicWord"
    /// <summary>
    /// An indication that the source of information is someone other than the speaker.  [Aikhenvald 2006: 106]
    /// <see href="http://purl.org/linguistics/gold/OtherSourceEvidentiality"></see></summary>
    let OtherSourceEvidentiality = _prefix "OtherSourceEvidentiality"
    /// <summary>
    /// OtherThanVisualEvidentiality encodes the fact that the speaker came to believe the content of the expression directly in a way other than through visual experience; they heard it, smelled it, tasted it, etc. [Palmer 2001: 36, 57].
    /// <see href="http://purl.org/linguistics/gold/OtherThanVisualEvidentiality"></see></summary>
    let OtherThanVisualEvidentiality = _prefix "OtherThanVisualEvidentiality"
    /// <summary>
    /// A Paragraph is a self contained unit in written language composed of a sequence of orthographic sentences. Paragraphs are set off by vertical spacing, indentation or other conventions.
    /// <see href="http://purl.org/linguistics/gold/Paragraph"></see></summary>
    let Paragraph = _prefix "Paragraph"
    /// <summary>
    /// A participle is a word which participates as both a verb (by showing tense) and as an adjective (by showing adjectival inflection).  In modern usage, the term refers to a non-finite part of the verb other than the infinitive (independent of the function of these forms in the sentence).  [Bauer 2004: 82]
    /// <see href="http://purl.org/linguistics/gold/Participle"></see></summary>
    let Participle = _prefix "Participle"
    /// <summary>
    /// PartitiveCase expresses the partial nature of the referent of the noun it marks, as opposed to expressing the whole unit or class of which the referent is a part. This case may be found in items such as the following: existential clauses, nouns that are accompanied by numerals or units of measure, or predications of material from which something is made. It often has a meaning similar to the English word 'some'. [Pei and Gaynor 1954: 161; Richards, Platt and Weber 1985: 208; Quirk et al. 1985: 249; Sebeok 1946: 1214]
    /// <see href="http://purl.org/linguistics/gold/PartitiveCase"></see></summary>
    let PartitiveCase = _prefix "PartitiveCase"
    /// <summary>
    /// A partitive numeral is a numeral that expresses a fraction [Pei and Gaynor 1954: 149; Hartmann and Stork 1972: 165].
    /// <see href="http://purl.org/linguistics/gold/PartitiveNumeral"></see></summary>
    let PartitiveNumeral = _prefix "PartitiveNumeral"
    /// <summary>
    /// Associated with actions performed on the subject by an unspecified agent [McIntosh 1984: 108]. Refers to the category of verb forms, typically identifies with a specific morphological marking, that encode the derived diatheses in which the agent role is not linked with a subject noun phrase: Diatheis: D1=(X=AgOb)(Y+SUBabs/nom) [Shibatani 1995: 7].
    /// <see href="http://purl.org/linguistics/gold/PassiveVoice"></see></summary>
    let PassiveVoice = _prefix "PassiveVoice"
    /// <summary>
    /// Locates the situation in question prior to a reference time in the past before the time of the speaking event. This is also known as the PluperfectTense [Comrie 1985: 125].
    /// <see href="http://purl.org/linguistics/gold/PastInPastTense"></see></summary>
    let PastInPastTense = _prefix "PastInPastTense"
    /// <summary>
    /// A tense in which the event that the speaker is referring to precedes the time of the state of affairs denoted by the sentence.  Also referred to as 'past in past' form.  Past perfect can also be used modally to represent situations as non-factual or counterfactual.  [Michaelis 2006: 223; Depraetere and Reed 2006: 271]
    /// <see href="http://purl.org/linguistics/gold/PastPerfectTense"></see></summary>
    let PastPerfectTense = _prefix "PastPerfectTense"
    /// <summary>
    /// A value of Tense Feature assigned to the designated element in the clause when the meaning selected for the clause is that intended to locate the event spoken about as anterior to the deictic centre of the utterance. Most commonly, this tense meaning is referred to as 'past', because in absolute tense systems the deictic centre is the moment of speech. However, in relative tense systems, where the deictic centre can be moved to any point on the time line, it is more appropriate to refer to this temporal relation as 'anterior'.
    /// The anterior temporal relation may obtain either in 'simple' or 'perfect' contexts. Modelling of this distinction originates from Reichenbach (1947), who suggested using a third point in time, 'reference point', to capture all possible tense distinctions. In all 'simple' temporal relations, the reference point coincides with the location of the event spoken about. 'Perfect' tense meanings are created when the reference point is separated and moved away from the event time, thus altering the viewing of the temporal location of the event even though the event's actual location with respect to the deictic centre remains the same.
    /// A common instance of an anterior temporal relationship obtaining in a 'perfect' context
    /// occurs when the reference point is moved away from the event time and located instead at the moment of speech. The event time is still anterior to the moment of speech, but it is viewed against a stretch of time which began at the event and continues up to the moment of speech --- e.g. the English I have read this book, I have seen John --- hence the interpretation that the event has an effect or is in some way still relevant at the moment of speech. In some languages (e.g. English) this tense meaning is labelled as (one of the uses of the) Present Perfect, in others (e.g. Polish) this meaning may be collapsed with the 'simple' anterior meaning and labelled simply as Past.
    /// Typically, for a tense value to be labelled as Past Tense, the tense meaning has to minimally express the anterior temporal relationship, although it may additionally express other temporal relationships or aspectual and/or modal meanings. For example, when the usage of the Past Tense value is restricted to a semantically defined domain, it is conventional to add a further qualification to the label of the Past Tense value (e.g. Past Imperfective --- when the anterior temporal relationship is necessarily combined with an aspectual meaning of the Imperfective Aspect value, and grammaticalised as a single [Tense-Aspect-Mood (TAM)] category in the language). [Kibort 2008c: 4]
    /// <see href="http://purl.org/linguistics/gold/PastTense"></see></summary>
    let PastTense = _prefix "PastTense"
    /// <summary>
    /// A category of number denoting the concept 'a few', more than two and usually less than seven, but the exact number varies widely according to context.  Prototypically, it refers to a class of three to five individuals and is always restricted to humans.  [Hartmann and Stork 1972: 166; Corbett 2000: 23]
    /// <see href="http://purl.org/linguistics/gold/PaucalNumber"></see></summary>
    let PaucalNumber = _prefix "PaucalNumber"
    /// <summary>
    /// An evaluative property of a noun that indicates the speaker regards the person or object being referred to with distaste, contempt, or displeasure [Valentine 2001: 190-193].
    /// <see href="http://purl.org/linguistics/gold/PejorativeEvaluative"></see></summary>
    let PejorativeEvaluative = _prefix "PejorativeEvaluative"
    /// <summary>
    /// A value of Tense Feature assigned to the designated element in the clause when the meaning selected for the clause is that intended to locate the event spoken about as anterior, simultaneous, or posterior to the deictic centre of the utterance, and additionally the reference point from which this event is viewed is separated and moved away from the event time. This alters the viewing of the temporal location of the event even though the event's actual location with respect to the deictic centre remains the same. 'Perfect' temporal relations contrast with 'simple' temporal relations in which the reference point coincides with the location of the event spoken about. Modelling of this distinction originates from [Reichenbach 1947].
    /// There are two types of 'perfect' context which may lead to separate tense values:
    /// (1) The first type occurs when the reference point is moved away from the event time and instead located after the event time. A common example occurs with an anterior temporal relationship, when the reference point is moved from the event time to the moment of speech. The event time is anterior to the moment of speech, but it is viewed against a stretch of time which began at the event and continues up to the moment of speech --- e.g. the English I have read this book, I have seen John --- hence the interpretation that the event has an effect or is in some way still relevant at the moment of speech. [Note that in some languages (e.g. English) this tense meaning is labelled as (one of the uses of the) Present Perfect, in others (e.g. Polish) this meaning may be collapsed with the 'simple' anterior meaning and labelled simply as Past.] The interpretation of this type of the perfect often includes at least two related but distinguishable uses: the resultative perfect (Someone has stolen my purse) and the experiential perfect (I have read this book before) [Dahl and Velupillai 2005: 271].
    /// (2) The second type occurs when the reference point is moved away from the event time and instead located before the event time. A common example occurs with a simultaneous temporal relationship, when the reference point is moved from the event time and located before the moment of speech. The event time is still simultaneous with the moment of speech, but it is viewed against a stretch of time which began at the reference point and continues up to the moment of speech --- e.g. the English I have lived here [for ten years] --- hence the interpretation that the event which began in the past extends up to the moment of speech. [Note that in some languages (e.g. English) this tense meaning is labelled as (one of the uses of the) Present Perfect, in others (e.g. Polish) this meaning may be collapsed with the 'simple' simultaneous meaning and labelled simply as Present.] The interpretation of this type of the perfect is often referred to as the universal perfect or perfect of persistent situation.
    /// Typically, for a tense value to be labelled as Perfect Tense, the tense meaning has to minimally express the meaning resulting from the separation of the reference point from the event time, although it may additionally express other temporal, aspectual, or modal meanings. [Kibort 2008c: 5-6]
    /// <see href="http://purl.org/linguistics/gold/PerfectTense"></see></summary>
    let PerfectTense = _prefix "PerfectTense"
    /// <summary>
    /// A value of Aspect Property assigned to the designated element in the clause when the meaning selected for the clause is that which indicates that the event spoken about is to be viewed as a bounded whole, looked at from outside, without necessarily distinguishing any of its internal structure [Comrie 1976: 16ff].
    ///
    /// Typically, for an aspect value to be labeled as Perfective, the aspectual meaning has to minimally express the perfective viewpoint, although it may additionally express other temporal, aspectual, or modal meanings, or actionality distinctions. [Kibort 2008c: 7]
    /// <see href="http://purl.org/linguistics/gold/PerfectiveAspect"></see></summary>
    let PerfectiveAspect = _prefix "PerfectiveAspect"
    /// <summary>
    /// PerlativeCase expresses that something moved 'through','across', or 'along' the referent of the noun that is marked [Blake 2001].
    /// <see href="http://purl.org/linguistics/gold/PerlativeCase"></see></summary>
    let PerlativeCase = _prefix "PerlativeCase"
    /// <summary>
    /// PermissiveModality indicates that an agent has permission to perform the action expressed by the predicate [Palmer 2001: 10, 71].
    /// <see href="http://purl.org/linguistics/gold/PermissiveModality"></see></summary>
    let PermissiveModality = _prefix "PermissiveModality"
    /// <summary>
    /// A Passive in which the argument mapped to Object in a basic structural configuration assumes the Subject relation in a corresponding nonbasic configuration [Klaiman 1991: 23].
    /// <see href="http://purl.org/linguistics/gold/PersonalPassiveVoice"></see></summary>
    let PersonalPassiveVoice = _prefix "PersonalPassiveVoice"
    /// <summary>
    /// A pronoun used to refer to the speaker, the person spoken to, and other persons and things whose referents are presumed to be clear from the context.  While some personal pronouns in some languages occur in essentially the same sentence position as other nominal expressions, it is rather common for them to show distributional peculiarities.  Personal pronouns may be clitics whose distribution may be consistently distinct from that of non-clitic nominals.  It is also common for the equivalent of personal pronouns to be expressed by affixes on the verb. [Schachter 1985: 25-26]
    /// <see href="http://purl.org/linguistics/gold/PersonalPronoun"></see></summary>
    let PersonalPronoun = _prefix "PersonalPronoun"
    /// <summary>
    /// A set of aspectual distinctions involving relations between a background situation (the reference situation) and a situation located relative to the reference situation (the denoted situation). In English, phasal distinctions are expressed by auxiliary-headed constructions, like the inceptive, progressive, and perfect constructions, whose head verbs express the aspectual class of the denoted situation. The aspectual class of the denoted situation differs from that of the reference situation [Michaelis 1998: xv]. An event may have a beginning and an end, a middle portion (continuing or changing), and also an ensuing result or an altered state. These are considered to be the various "phases" of an event. A speaker may talk about an event from the point of view of any of these individual phases, and his language may have inflectional (or other type of) markers for representing these distinctions. Since such markers indicate distinctions in the temporal structure of an event, we may regard them as belonging to the category of aspect. It has been suggested [Dik 1989: 186] that these may be grouped under a subcategory (or "level") of aspect called "phasal aspect". [Bhat 1999: 49]
    /// <see href="http://purl.org/linguistics/gold/PhasalAspect"></see></summary>
    let PhasalAspect = _prefix "PhasalAspect"
    /// <summary>
    /// A phoneme is the underlying sound in a set of phonetically distinct sounds that native speakers of a language judge to be identical.   Variants of the underlying sound are the product of systematic rules that modify the segment depending on the phonological context in which it occurs. [Kenstowicz 1994: 65-66]
    /// <see href="http://purl.org/linguistics/gold/Phoneme"></see></summary>
    let Phoneme = _prefix "Phoneme"
    /// <summary>
    /// The class of linguistic properties that pertain to phonological units and that are used to describe the sound system of languages [Hartmann and Stork 1972: 174]. Phonological units can be analyzed into complexes of distinctive properties that cross-classify the entire inventory of possible speech sounds into a densely packed network [Kenstowicz 1994: 19].
    /// <see href="http://purl.org/linguistics/gold/PhonologicalProperty"></see></summary>
    let PhonologicalProperty = _prefix "PhonologicalProperty"
    /// <summary>
    /// The set of consonant and vowel units that make up the words of a language or language variety, a phonological system is a list of contrastive sounds used in a language that are capable of distinguishing between two words with different meanings together with the ranges of variety each sound has and where those variants are found. [Ball and Mueller 2005: 120]
    /// <see href="http://purl.org/linguistics/gold/PhonologicalSystem"></see></summary>
    let PhonologicalSystem = _prefix "PhonologicalSystem"
    /// <summary>
    /// PhysicalAbilitiveModality indicates that an agent has the physical capacity to perform some action. [Bybee, Perkins and Pagliuca 1994: 192; Palmer 2001: 77]
    /// <see href="http://purl.org/linguistics/gold/PhysicalAbilitiveModality"></see></summary>
    let PhysicalAbilitiveModality = _prefix "PhysicalAbilitiveModality"
    /// <summary>
    /// An adjective without any markings for comparative or superlative form, sometimes called "positive" form.  It is that form of an adjective which merely expresses the presence of a quality or condition, without comparing or indicating its degree.  [Pei and Gaynor 1980:  172, Hartmann and Stork 1972: 5]
    /// <see href="http://purl.org/linguistics/gold/PlainAdjective"></see></summary>
    let PlainAdjective = _prefix "PlainAdjective"
    /// <summary>
    /// Results of action occur to subject [Siewierska 1988: 257].
    /// <see href="http://purl.org/linguistics/gold/PlainMiddleVoice"></see></summary>
    let PlainMiddleVoice = _prefix "PlainMiddleVoice"
    /// <summary>
    /// PluralNumber is a number property that quantifies the denotation of the nominal element so that: 1) it specifies that there are more than one. In this English example below, plural is shown by both the noun and the verb in (2):
    ///
    /// (1) my dog watches television
    /// (2) my dogs watch television
    ///
    /// [Corbett 2000: 5]
    ///
    /// 2) additionally, but not necessarily, pluralNumber may be assigned on the basis of formal properties (e.g. pluralia tantum, or measles / *measle). 3) if pluralNumber functions as generalNumber, it may specify a lack of commitment with regard to quantification ([Corbett 2000: 17] notes this system does not exist in pure form, that is, no language employs it as the normal case).
    ///
    /// Some Cushitic languages, generalNumber can be the same as singularNumber for some nouns, but the same as pluralNumber for other nouns. For example, in Arbore (arv), generalNumber may contrast with the singular in the absence of a distinct plural form: Ln Singular Ln tiis-in 'a maize cob' Ln lasa-n 'a loaf'
    ///
    /// nebel-in 'a cock ostrich' ln General ln tíise 'maize cob(s)' ln lássa 'bread' ln nebel 'ostrich(es)' ln [Corbett 2000: 17-18]
    /// <see href="http://purl.org/linguistics/gold/PluralNumber"></see></summary>
    let PluralNumber = _prefix "PluralNumber"
    /// <summary>
    /// PlusATR (Advanced Tongue Root) characterizes sounds made with the root of the tongue drawn forward and the larynx lowered so that the part of the vocal tract in the pharynx is considerably enlarged. [Ladefoged 2000: 211]
    /// <see href="http://purl.org/linguistics/gold/PlusATR"></see></summary>
    let PlusATR = _prefix "PlusATR"
    /// <summary>
    /// PlusClick refers to having the properties of a click.  Clicks are stops in which the essential component is the rarefaction of air enclosed between two articulatory closures formed in the oral cavity, so that a loud transient is produced when the more forward closure is released.  This uses the velaric airstream mechanism, always ingressive, and cannot be used for sounds other than stops and affricates.  [Ladefoged and Maddieson 1996: 246]
    /// <see href="http://purl.org/linguistics/gold/PlusClick"></see></summary>
    let PlusClick = _prefix "PlusClick"
    /// <summary>
    /// PlusFortis refers to a sound made with relatively strong degree of muscular effort and breath force.  [Crystal 1985: 126]
    /// <see href="http://purl.org/linguistics/gold/PlusFortis"></see></summary>
    let PlusFortis = _prefix "PlusFortis"
    /// <summary>
    /// Characterizing sounds in which the palatorpharyngeal and palatoglossus muscles lower the velum, allowing air to go out through the nose. [Kenstowicz 1994: 143; Ladefoged 2000: 274]
    /// <see href="http://purl.org/linguistics/gold/PlusNasal"></see></summary>
    let PlusNasal = _prefix "PlusNasal"
    /// <summary>
    /// PoliticalTaxon is the class of taxons whose instances are groupings based on political entities such as states or countries or larger politically defined entities, e.g., CameroonianLanguage.
    /// <see href="http://purl.org/linguistics/gold/PoliticalTaxon"></see></summary>
    let PoliticalTaxon = _prefix "PoliticalTaxon"
    /// <summary>
    /// In general, positive polarity refers to an assertion that contains no marker of negation [Crystal 1980:  299].
    /// <see href="http://purl.org/linguistics/gold/PositivePolarity"></see></summary>
    let PositivePolarity = _prefix "PositivePolarity"
    /// <summary>
    /// PossessedCase is used to mark the noun whose referent is possessed by the referent of another noun.
    /// <see href="http://purl.org/linguistics/gold/PossessedCase"></see></summary>
    let PossessedCase = _prefix "PossessedCase"
    /// <summary>
    /// A possessive pronoun is a pronoun that expresses ownership and relationships like ownership, such as kinship, and other forms of association [Crystal 1997: 312].
    /// <see href="http://purl.org/linguistics/gold/PossessivePronoun"></see></summary>
    let PossessivePronoun = _prefix "PossessivePronoun"
    /// <summary>
    /// PossibilityModality indicates that the designated state of affairs is possible [Palmer 2001: 89-90], either directly, or because an agent has the ability or permission to carry it out [Bybee, Perkins and Pagliuca 1994: 177].
    /// <see href="http://purl.org/linguistics/gold/PossibilityModality"></see></summary>
    let PossibilityModality = _prefix "PossibilityModality"
    /// <summary>
    /// PostHodiernalFutureTense locates the situation in question after the span that is culturally defined as 'today' [Bybee, Perkins and Pagliuca 1994: 247].
    /// <see href="http://purl.org/linguistics/gold/PostHodiernalFutureTense"></see></summary>
    let PostHodiernalFutureTense = _prefix "PostHodiernalFutureTense"
    /// <summary>
    /// Characterizing sounds produced with the area just behind the center of the alveolar ridge as the passive articulator [Ladefoged 1997: 597].
    /// <see href="http://purl.org/linguistics/gold/Postalveolar"></see></summary>
    let Postalveolar = _prefix "Postalveolar"
    /// <summary>
    /// A postposition is an adposition that occurs after its complement [Crystal 1997: 300; Payne 1997: 86].
    /// <see href="http://purl.org/linguistics/gold/Postposition"></see></summary>
    let Postposition = _prefix "Postposition"
    /// <summary>
    /// If the agent is more topical than the patient, the direct-active clause is used.  If norm is reversed and the patient is more topical, the inverse clause is used. [Givon 1994: 23]
    /// <see href="http://purl.org/linguistics/gold/PragmaticInverseVoice"></see></summary>
    let PragmaticInverseVoice = _prefix "PragmaticInverseVoice"
    /// <summary>
    /// PreHodiernalPastTense locates the situation in question before that of a contrasting HodiernalPastTense. This category must be defined relative to a HodiernalPastTense. [Bybee, Perkins and Pagliuca 1994: 98]
    /// <see href="http://purl.org/linguistics/gold/PreHodiernalPastTense"></see></summary>
    let PreHodiernalPastTense = _prefix "PreHodiernalPastTense"
    /// <summary>
    /// An evaluative property  of a noun that indicates the speaker regards the person or object being referred to with favor or admiration.
    /// <see href="http://purl.org/linguistics/gold/PreferredEvaluative"></see></summary>
    let PreferredEvaluative = _prefix "PreferredEvaluative"
    /// <summary>
    /// An affix which is added to the front of a root or stem.  [Hartmann and Stork 1972: 182]
    /// <see href="http://purl.org/linguistics/gold/Prefix"></see></summary>
    let Prefix = _prefix "Prefix"
    /// <summary>
    /// An element which may be compounded to the front of a noun to signal information such as size, color, etc. [Valentine 2001: 152-154].
    /// <see href="http://purl.org/linguistics/gold/Prenoun"></see></summary>
    let Prenoun = _prefix "Prenoun"
    /// <summary>
    /// A preposition is an adposition that occurs before its complement [Crystal 1997: 305; Payne 1997: 86].
    /// <see href="http://purl.org/linguistics/gold/Preposition"></see></summary>
    let Preposition = _prefix "Preposition"
    /// <summary>
    /// A value of Tense Feature assigned to the designated element in the clause when the meaning selected for the clause is that intended to locate the event spoken about as simultaneous with the deictic centre of the utterance. Most commonly, this tense meaning is referred to as 'present', because in absolute tense systems the deictic centre is the moment of speech. However, in relative tense systems, where the deictic centre can be moved to any point on the time line, it is more appropriate to refer to this temporal relation as 'simultaneous'.
    /// The simultaneous temporal relation may obtain either in 'simple' or 'perfect' contexts. Modelling of this distinction originates from [Reichenbach 1947], who suggested using a third point in time, 'reference point', to capture all possible tense distinctions. In all 'simple' temporal relations, the reference point coincides with the location of the event spoken about. 'Perfect' tense meanings are created when the reference point is separated and moved away from the event time, thus altering the viewing of the temporal location of the event even though the event's actual location with respect to the deictic centre remains the same.
    /// A common instance of a simultaneous temporal relationship obtaining in a 'perfect' context occurs when the reference point is moved away from the event time and located instead before the moment of speech. The event time is still simultaneous with the moment of speech, but it is viewed against a stretch of time which began at the reference point and continues up to the moment of speech --- e.g. the English I have lived here [for ten years] --- hence the interpretation that the event which began in the past extends up to the moment of speech. In some languages (e.g. English) this tense meaning is labelled as (one of the uses of the) Present Perfect, in others (e.g. Polish) this meaning may be collapsed with the 'simple' simultaneous meaning and labelled simply as Present. [Kibort 2008c: 4-5]
    /// <see href="http://purl.org/linguistics/gold/PresentPerfectTense"></see></summary>
    let PresentPerfectTense = _prefix "PresentPerfectTense"
    /// <summary>
    /// A value of Tense Property assigned to the designated element in the clause when the meaning selected for the clause is that intended to locate the event spoken about as simultaneous with the deictic centre of the utterance. Most commonly, this tense meaning is referred to as 'present', because in absolute tense systems the deictic centre is the moment of speech. However, in relative tense systems, where the deictic centre can be moved to any point on the time line, it is more appropriate to refer to this temporal relation as 'simultaneous'.
    /// It is important to note --- for all tense values, but in particular for the Present Tense --- that the 'times' which are used to locate the event, the deictic centre, and the reference point, may or may not be 'points' on the time line. Conventionally, these concepts are considered neutral with regard to whether they are points or intervals of time longer than a point. In a formal model of tense meanings they could, for example, be represented as sets (of points): in order to capture temporal distinctions, the notion of an event being 'simultaneous with the moment of speech', may be understood as (the set of) event time (points) and (the set of) speech time (points) having a non-empty intersection. Hence, this semantic model of the Present Tense value may include the interpretation of the present as 'universal' or 'generic'.
    /// The simultaneous temporal relation may obtain either in 'simple' or 'perfect' contexts. Modelling of this distinction originates from [Reichenbach 1947], who suggested using a third point in time, 'reference point', to capture all possible tense distinctions. In all 'simple' temporal relations, the reference point coincides with the location of the event spoken about. 'Perfect' tense meanings are created when the reference point is separated and moved away from the event time, thus altering the viewing of the temporal location of the event even though the event's actual location with respect to the deictic centre remains the same.
    /// A common instance of a simultaneous temporal relationship obtaining in a 'perfect' context occurs when the reference point is moved away from the event time and located instead before the moment of speech. The event time is still simultaneous with the moment of speech, but it is viewed against a stretch of time which began at the reference point and continues up to the moment of speech --- e.g. the English I have lived here [for ten years] --- hence the interpretation that the event which began in the past extends up to the moment of speech. In some languages (e.g. English) this tense meaning is labelled as (one of the uses of the) Present Perfect, in others (e.g. Polish) this meaning may be collapsed with the 'simple' simultaneous meaning and labelled simply as Present.
    /// Typically, for a tense value to be labelled as Present Tense, the tense meaning has to minimally express the simultaneous temporal relationship, although it may additionally express other temporal, aspectual, or modal meanings. [Kibort 2008c: 4-5]
    /// <see href="http://purl.org/linguistics/gold/PresentTense"></see></summary>
    let PresentTense = _prefix "PresentTense"
    /// <summary>
    /// An element which may be compounded to the front of a verb, to signal information such as tense, direction, etc. [Valentine 2001: 154-158].
    /// <see href="http://purl.org/linguistics/gold/Preverb"></see></summary>
    let Preverb = _prefix "Preverb"
    /// <summary>
    /// A proverb (frequently written "pro-verb") is a ProForm that substitutes for a verb or verb phrase. [Schachter 1985: 34]
    /// <see href="http://purl.org/linguistics/gold/ProVerb"></see></summary>
    let ProVerb = _prefix "ProVerb"
    /// <summary>
    /// A Proadjective is a ProForm that substitutes for an adjective or adjective phrase. [Crystal 1997: 310]
    /// <see href="http://purl.org/linguistics/gold/Proadjective"></see></summary>
    let Proadjective = _prefix "Proadjective"
    /// <summary>
    /// A Proadverb is a Proform that substitutes for an adverb or other expression having an adverbial function. [Crystal 1997: 310]
    /// <see href="http://purl.org/linguistics/gold/Proadverb"></see></summary>
    let Proadverb = _prefix "Proadverb"
    /// <summary>
    /// The class of things that happen and have temporal parts or stages. Examples include extended events like a football match or a race, actions like pursuing and reading, and biological processes. The formal definition is: anything that occurs in time but is not an object. Note that a process may have participants 'inside' it which are objects, such as the players in a football match. In a 4D ontology, a process is something whose spatiotemporal extent is thought of as dividing into temporal stages roughly perpendicular to the time-axis. [SUMO 2010]
    /// <see href="http://purl.org/linguistics/gold/Process"></see></summary>
    let Process = _prefix "Process"
    /// <summary>
    /// A derivational morpheme that derives transitives from other transitives or intransitive verb.
    /// <see href="http://purl.org/linguistics/gold/Processive"></see></summary>
    let Processive = _prefix "Processive"
    /// <summary>
    /// A proclitic is a clitic that precedes the lexical unit to which it is phonologically joined [Crystal 1980: 64; Hartmann and Stork 1972: 185; Pei and Gaynor 1954: 176].
    /// <see href="http://purl.org/linguistics/gold/Proclitic"></see></summary>
    let Proclitic = _prefix "Proclitic"
    /// <summary>
    /// A value of Aspect Property (also called Nonstative aspect) assigned to the designated element in the clause when the meaning selected for the clause is that which indicates that the situation spoken about has internal temporal structure, it cannot be regarded as habitual, and reference is made to this situation in progress. Hence, progressiveness can be defined as the combination of progressive meaning with nonstative meaning, and it can be regarded as a sub-type of continuousness (which, in turn, is a sub-type of imperfectivity). Since languages have different criteria for classifying predicates as stative or not, they may have different rules for determining when explicitly progressive forms can be used.
    ///
    /// Typically, for an aspect value to be labelled as Progressive, the aspectual meaning has to minimally express progressiveness, although it may additionally express other temporal, aspectual, or modal meanings, or actionality distinctions. [Kibort 2008c: 8]
    /// <see href="http://purl.org/linguistics/gold/ProgressiveAspect"></see></summary>
    let ProgressiveAspect = _prefix "ProgressiveAspect"
    /// <summary>
    /// A passive in Irish  in which the preposition "at" is used, and a semantic meaning of progressive tense is found [Noonan 1994: 280].
    /// <see href="http://purl.org/linguistics/gold/ProgressivePassiveVoice"></see></summary>
    let ProgressivePassiveVoice = _prefix "ProgressivePassiveVoice"
    /// <summary>
    /// Prohibitive mood is a directive mood that signals a prohibition. It is distinguished by the use of a negated imperative sentence that employs a negative marker distinct from that used in declarative sentences, or a verb form different from that of the imperative. [SIL International 2004]
    /// <see href="http://purl.org/linguistics/gold/ProhibitiveMood"></see></summary>
    let ProhibitiveMood = _prefix "ProhibitiveMood"
    /// <summary>
    /// Involves promotion of the topical proximate-patient to subjecthood [Givon 1994: 24].
    /// <see href="http://purl.org/linguistics/gold/PromotionalInverseVoice"></see></summary>
    let PromotionalInverseVoice = _prefix "PromotionalInverseVoice"
    /// <summary>
    /// ProperNoun, also referred to as proper names, is the class of nouns that are used to address particular persons or culturally significant personages or places. They refer to specific entities and are not usually with articles, modifiers, possessors. [Payne 1997: 39]
    /// <see href="http://purl.org/linguistics/gold/ProperNoun"></see></summary>
    let ProperNoun = _prefix "ProperNoun"
    /// <summary>
    /// An articulatory characteristic resulting from protrusion of the lips, often resulting in the appearance of a small labial cavity forward of the teeth and bounded at the front by the inside surfaces of the lips.  Often occurring with lip rounding, the protruded quality modifies the basic articulation by extending the length of the vocal tract and altering its cross-section, resulting in lowered frequencies on all formants.  Back rounded vowels are commonly more protruded than front rounded vowels. [Brosnahan and Malmberg 1976: 43, 67; Clark, Yallop and Fletcher 2007: 26, 64]
    /// <see href="http://purl.org/linguistics/gold/Protruded"></see></summary>
    let Protruded = _prefix "Protruded"
    /// <summary>
    /// A speaker may report an event as occurring once only (semelfactive) or several times (iterative); he may view it as a specific event or as part of a general habit of carrying out similar events; he may also differentiate between different degrees of frequency with which the event occurs. The markers that a given language provides for one or more of these meaning distinctions can be grouped under a subcategory called “quantificational aspect”, as all of them refer to the quantitative aspect of the event concerned. [Bhat 1999: 53]
    /// <see href="http://purl.org/linguistics/gold/QuantificationalAspect"></see></summary>
    let QuantificationalAspect = _prefix "QuantificationalAspect"
    /// <summary>
    /// Realis modality is a modality that connotes the factuality of a proposition. In its broad usage, the term realis is approximately equivalent in meaning to the term indicative, which in turn is used, narrowly, as a synonym to declarative. [SIL International 2004]
    /// <see href="http://purl.org/linguistics/gold/RealisMood"></see></summary>
    let RealisMood = _prefix "RealisMood"
    /// <summary>
    /// RecentPastTense locates the situation in question prior to the present moment, but by culturally and situationally defined criteria, usually within the span ranging from yesterday to a week or a few months previous [Comrie 1985: 87; Dahl 1985: 121-122].
    /// <see href="http://purl.org/linguistics/gold/RecentPastTense"></see></summary>
    let RecentPastTense = _prefix "RecentPastTense"
    /// <summary>
    /// Referents of plural subject do action to one another [Siewierska 1988: 257].
    /// <see href="http://purl.org/linguistics/gold/ReciprocalMiddleVoice"></see></summary>
    let ReciprocalMiddleVoice = _prefix "ReciprocalMiddleVoice"
    /// <summary>
    /// A reciprocal pronoun is a pronoun that expresses a mutual feeling or action among the referents of a plural subject [Crystal 1997: 323].
    /// <see href="http://purl.org/linguistics/gold/ReciprocalPronoun"></see></summary>
    let ReciprocalPronoun = _prefix "ReciprocalPronoun"
    /// <summary>
    /// ReferentialVoice entails assignment of the absolutive to certain kinds of arguments other than logical subjects (agents) and objects (patients), targeting semantic roles such as dative, benefactive, malefactive and possessor. [Klaiman 1991: 239]
    /// <see href="http://purl.org/linguistics/gold/ReferentialVoice"></see></summary>
    let ReferentialVoice = _prefix "ReferentialVoice"
    /// <summary>
    /// Subjects perform action to self [Siewierska 1988: 257].
    /// <see href="http://purl.org/linguistics/gold/ReflexiveMiddleVoice"></see></summary>
    let ReflexiveMiddleVoice = _prefix "ReflexiveMiddleVoice"
    /// <summary>
    /// A Passive construction which contains reflexive markings [Siewierska 1988: 257].
    /// <see href="http://purl.org/linguistics/gold/ReflexivePassiveVoice"></see></summary>
    let ReflexivePassiveVoice = _prefix "ReflexivePassiveVoice"
    /// <summary>
    /// A pronoun which is interpreted as coreferential with another nominal, usually the subject, of the sentence or clause in which it occurs. [Schachter 1985: 27]
    /// <see href="http://purl.org/linguistics/gold/ReflexivePronoun"></see></summary>
    let ReflexivePronoun = _prefix "ReflexivePronoun"
    /// <summary>
    /// RelativeFutureTense locates the situation in question after a contextually determined temporal reference point, regardless of the latter's relation to the moment of utterance [Comrie 1985: 69-71]. Also called FuturePerfectTense.
    /// <see href="http://purl.org/linguistics/gold/RelativeFutureTense"></see></summary>
    let RelativeFutureTense = _prefix "RelativeFutureTense"
    /// <summary>
    /// RelativePastTense locates the situation in question before that of a contextually determined temporal reference point [Comrie 1985: 104]. Also called PastPerfectTense.
    /// <see href="http://purl.org/linguistics/gold/RelativePastTense"></see></summary>
    let RelativePastTense = _prefix "RelativePastTense"
    /// <summary>
    /// A tense that expresses that a situation is simultaneous with the time of some other post-present situation. [Hollebrandse, Holt and Vet 2005: 30]
    /// <see href="http://purl.org/linguistics/gold/RelativePresentTense"></see></summary>
    let RelativePresentTense = _prefix "RelativePresentTense"
    /// <summary>
    /// A relative pronoun is a pronoun that marks a relative clause, functions grammatically within the relative clause, and is coreferential to the word modified by the relative clause [Crystal 1997: 329].
    /// <see href="http://purl.org/linguistics/gold/RelativePronoun"></see></summary>
    let RelativePronoun = _prefix "RelativePronoun"
    /// <summary>
    /// A relativizer is a subordinating connective that links a relative clause to its head  noun. It is distinguishable from a relative pronoun in that it does not have a nominal function within the relative clause. [Payne 1997: 332]
    /// <see href="http://purl.org/linguistics/gold/Relativizer"></see></summary>
    let Relativizer = _prefix "Relativizer"
    /// <summary>
    /// RemoteFutureTense locates the situation in question at a time that is considered relatively distant. It is characteristically after the span of time culturally defined as 'tomorrow'. [Dahl 1985: 121; Comrie 1985: 94]
    /// <see href="http://purl.org/linguistics/gold/RemoteFutureTense"></see></summary>
    let RemoteFutureTense = _prefix "RemoteFutureTense"
    /// <summary>
    /// RemotePastTense locates the situation in question prior to the present moment, usually more than a few days ago [Dahl 1985: 121; Comrie 1985: 88]. Subsumes notion of PreHesternalPast tense, which locates the situation in question before that of an opposing hesternal past tense [Bybee, Perkins, Pagliuca 1994: 98].
    /// <see href="http://purl.org/linguistics/gold/RemotePastTense"></see></summary>
    let RemotePastTense = _prefix "RemotePastTense"
    /// <summary>
    /// A derivational unit that derives transitives from other transitive or intransitive stems adding the meaning of repetition to the resulting form. [concept mentioned in Kibort 2008c: 9]
    /// <see href="http://purl.org/linguistics/gold/Repetitive"></see></summary>
    let Repetitive = _prefix "Repetitive"
    /// <summary>
    /// A term used in phonetics to refer to the backwards movement of an articulator, especially the back of the tongue towards the velum.  Retracted sounds are heard in velarization, or the centralization of front vowels.  The tongue root may also be retracted. [Crystal 2008: 398]
    /// <see href="http://purl.org/linguistics/gold/Retracted"></see></summary>
    let Retracted = _prefix "Retracted"
    /// <summary>
    /// A convention for labeling gender values. Roman numerals are often used for languages for which there is a descriptive tradition involving use of the term 'noun class' instead of 'gender', in particular in languages of the Caucasus or Bantu languages, and are particularly useful where the number of genders is large.If the 'noun classes' are involved in agreement systems, they are gender systems. Roman numerals may also be used in instances where another label is possible. In one language the gender to which nouns with male rational denotation are assigned might be called 'masculine', whereas in another language nouns with a similar denotation may be assigned to a gender with an arbitrary Roman numerical label such as 'I'. [Kibort and Corbett 2008a]
    /// <see href="http://purl.org/linguistics/gold/RomanNumeralGender"></see></summary>
    let RomanNumeralGender = _prefix "RomanNumeralGender"
    /// <summary>
    /// The base form of a word which cannot be further analyzed without total loss of identity. Roots may be free or bound morphemes and can be classified as simple (i.e. compositionally unanalyzable in terms of morphemes) or complex/compound (i.e. certain combinations of simple root forms), though for the latter, the term 'stem' is often used.  From a semantic point of view, the root generally carried the main component of meaning in a word. [Crystal 1997: 336]
    /// <see href="http://purl.org/linguistics/gold/Root"></see></summary>
    let Root = _prefix "Root"
    /// <summary>
    /// Salience relates to the way in which certain actants present in a situation are seized on by humans as foci of attention, with attention being paid to less salient, less individuated objects subsequently [Comrie 1989: 199]. It has been argued that salience explains the evolution of certain syntactic changes, as well as the predominance of word orders where the subject precedes the object, due to the the salience of the agent in the agent-action-patient situation [Comrie 1989; Timberlake 1977].
    /// <see href="http://purl.org/linguistics/gold/SalienceProperty"></see></summary>
    let SalienceProperty = _prefix "SalienceProperty"
    /// <summary>
    /// SecondHandEvidentiality, also called the quotative, encodes the fact that the speaker came to believe the content of the expression from communicating with someone else [Palmer 2001: 40].
    /// <see href="http://purl.org/linguistics/gold/SecondHandEvidentiality"></see></summary>
    let SecondHandEvidentiality = _prefix "SecondHandEvidentiality"
    /// <summary>
    /// SecondLanguageOnlyVariant is a language variant that has no mother tongue speakers.  It is only spoken as a a second language. One example would be the case of Callawalla (caw), which is only learned in adolescence.  [Grimes 1992: 16]
    /// <see href="http://purl.org/linguistics/gold/SecondLanguageOnlyVariety"></see></summary>
    let SecondLanguageOnlyVariety = _prefix "SecondLanguageOnlyVariety"
    /// <summary>
    /// SecondPerson is a person property that refers minimally to the addressee [Crystal 1997: 285; Cysouw 2003: 75].
    /// <see href="http://purl.org/linguistics/gold/SecondPerson"></see></summary>
    let SecondPerson = _prefix "SecondPerson"
    /// <summary>
    /// For natural language understanding, the process of fine-grain semantic role assignment is one of the prominent steps, which provides semantic relations between constituents. The sense and sense relations between constituents provide the core meaning of a sentence. Abstract semantic roles include thematic roles, such as agent, theme, and instrument, and secondary roles such as location, time, and manner. [Chen and You 2004: 1]
    /// <see href="http://purl.org/linguistics/gold/SemanticAssignmentSystem"></see></summary>
    let SemanticAssignmentSystem = _prefix "SemanticAssignmentSystem"
    /// <summary>
    /// If the agent outranks the patient on the relevant generic topic hierarchy, the direct-active clause is used.  If the relevant norm is reversed and the patient outranks the agent on the relevant hierarchy, the inverse clause is used. [Givon 1994: 23]
    /// <see href="http://purl.org/linguistics/gold/SemanticInverseVoice"></see></summary>
    let SemanticInverseVoice = _prefix "SemanticInverseVoice"
    /// <summary>
    /// In componential analysis, one of several features which together can be said to make up the semantic meaning of a word or utterance.  Thus 'raining' could be analyzed into the component features 'precipitation', 'liquid' (not 'solid' as in 'hail'), 'average' (not 'light' as /drizzling/ or 'heavy' as /pouring/), etc. [...] Alternative terms: semantic feature, semantic [component], semantic marker. [Hartmann and Stork 1972: 203]
    /// The class of linguistic properties that pertain to semantic units. The units that underlie our intuitions about literal meaning and are associated with the grammatical structure of a language. [Frawley 1953: 12]
    /// <see href="http://purl.org/linguistics/gold/SemanticProperty"></see></summary>
    let SemanticProperty = _prefix "SemanticProperty"
    /// <summary>
    /// Momentaneous, without an inherent end-point, as sneeze [Michaelis 1998: xvi].
    /// <see href="http://purl.org/linguistics/gold/SemelfactiveAspect"></see></summary>
    let SemelfactiveAspect = _prefix "SemelfactiveAspect"
    /// <summary>
    /// SignLanguage or SignSystem is referring to the system of manual communication used by certain groups as an alternative to oral communication. [Crystal 1997: 350]
    /// <see href="http://purl.org/linguistics/gold/SignedLanguage"></see></summary>
    let SignedLanguage = _prefix "SignedLanguage"
    /// <summary>
    /// A SignedLinguisticExpression is the signed physical form of language as distinct from either written or spoken expressions. Signed expressions are the primary means in which sign languages are tranmitted. A signed expression is  the image sequence that is produced (and perceived) during a signing event.
    /// <see href="http://purl.org/linguistics/gold/SignedLinguisticExpression"></see></summary>
    let SignedLinguisticExpression = _prefix "SignedLinguisticExpression"
    /// <summary>
    /// Future tense assigns a value to the designated element in the clause when the meaning selected for the clause is that intended to locate the event spoken about as posterior to the deictic centre of the utterance. Most commonly, this tense meaning is referred to as 'future', because in absolute tense systems the deictic centre is the moment of speech. However, in relative tense systems, where the deictic centre can be moved to any point on the time line, it is more appropriate to refer to this temporal relation as 'posterior'.
    ///
    /// The posterior temporal relation may obtain either in 'simple' or 'perfect' contexts. Modeling of this distinction originates from [Reichenbach 1947: 288], who suggested using a third point in time, 'reference point', to capture all possible tense distinctions. In all 'simple' temporal relations, the reference point coincides with the location of the event spoken about. [Kibort 2008c: 5]
    /// <see href="http://purl.org/linguistics/gold/SimpleFutureTense"></see></summary>
    let SimpleFutureTense = _prefix "SimpleFutureTense"
    /// <summary>
    /// Past tense assigns a value to the designated element in the clause when the meaning selected for the clause is that intended to locate the event spoken about as anterior to the deictic centre of the utterance. Most commonly, this tense meaning is referred to as 'past', because in absolute tense systems the deictic centre is the moment of speech. However, in relative tense systems, where the deictic centre can be moved to any point on the time line, it is more appropriate to refer to this temporal relation as 'anterior'.
    ///
    /// The anterior temporal relation may obtain either in 'simple' or 'perfect' contexts. Modeling of this distinction originates from [Reichenbach  1947: 288], who suggested using a third point in time, 'reference point', to capture all possible tense distinctions. In all 'simple' temporal relations, the reference point coincides with the location of the event spoken about . [Kibort 2008c: 4]
    /// <see href="http://purl.org/linguistics/gold/SimplePastTense"></see></summary>
    let SimplePastTense = _prefix "SimplePastTense"
    /// <summary>
    /// Present tense assigns a value to the designated element in the clause when the meaning selected for the clause is that intended to locate the event spoken about as simultaneous to the deictic centre of the utterance.
    ///
    /// The simultaneous temporal relation may obtain either in 'simple' or 'perfect' contexts.  Modelling of this distinction originates from [Reichenbach  1947: 288], who suggested using a third point in time, 'reference point', to capture all possible tense distinctions. In all 'simple' temporal relations, the reference point coincides with the location of the event spoken about. [Kibort 2008c: 4-5]
    /// <see href="http://purl.org/linguistics/gold/SimplePresentTense"></see></summary>
    let SimplePresentTense = _prefix "SimplePresentTense"
    /// <summary>
    /// A SimpleSpecification is a kind of FeatureSpecification whose value must be a simple linguistic attribute [Maxwell, Simons and Hayashi 2000].
    /// <see href="http://purl.org/linguistics/gold/SimpleSpecification"></see></summary>
    let SimpleSpecification = _prefix "SimpleSpecification"
    /// <summary>
    /// A temporal relation in which the events or states of proposition(s) are communicated as occurring at the same time. [SIL International 2004]
    /// <see href="http://purl.org/linguistics/gold/SimultaneousAspect"></see></summary>
    let SimultaneousAspect = _prefix "SimultaneousAspect"
    /// <summary>
    /// Singular refers to one member of a designated class [Crystal 1980: 245; Hartmann and Stork 1972: 210].
    /// <see href="http://purl.org/linguistics/gold/SingularNumber"></see></summary>
    let SingularNumber = _prefix "SingularNumber"
    /// <summary>
    /// SpeculativeForce indicates that the speaker considers, or 'entertains', the content of the expression. That is, it is in the realm of possibility, though the speaker does not necessarilty believe it. [Palmer 2001: 6-8, 25]
    /// <see href="http://purl.org/linguistics/gold/SpeculativeForce"></see></summary>
    let SpeculativeForce = _prefix "SpeculativeForce"
    /// <summary>
    /// One of the modes of linguistic communication. As distinct from written language, it is characterized by repetition, hesitation forms, pauses, variations in articulation, lapses, as well as differences in vocabulary and grammar.  The primary importance spoken language in the analysis, description and teaching of languages has been stressed frequently. Alternative terms: speech, conversation. [Hartmann and Stork 1972: 217]
    /// <see href="http://purl.org/linguistics/gold/SpokenLanguage"></see></summary>
    let SpokenLanguage = _prefix "SpokenLanguage"
    /// <summary>
    /// A SpokenLinguisticExpression is the physical sound form of language as distinct from either signed or spoken expressions. A spoken expression is the sound that is produced (and perceived) during a speaking event.
    /// <see href="http://purl.org/linguistics/gold/SpokenLinguisticExpression"></see></summary>
    let SpokenLinguisticExpression = _prefix "SpokenLinguisticExpression"
    /// <summary>
    /// Stem is the class of  morphological units that are analyzable into a root and possibly one or more derivational units. Stems can occur alone and are the basis for adding inflectional units. [Lyons 1977: 513, 521-526]
    /// <see href="http://purl.org/linguistics/gold/Stem"></see></summary>
    let Stem = _prefix "Stem"
    /// <summary>
    /// StillPresentTense is similar to PresentTense but carries the presupposition that an event or state held before the moment of utterance. In positive declarative clauses, still present tense asserts that the event or state holds at the moment of utterance [Comrie 1985, 54].
    /// <see href="http://purl.org/linguistics/gold/StillTense"></see></summary>
    let StillTense = _prefix "StillTense"
    /// <summary>
    /// A term used in the phonetic classification of speech sounds on the basis of their manner of articulation.  It refers to any sound which is produced by a complete closure in the vocal tract.  [Crystal 2008: 453]
    /// <see href="http://purl.org/linguistics/gold/Stop"></see></summary>
    let Stop = _prefix "Stop"
    /// <summary>
    /// A term used in (esp. classical) transformational grammar to refer to an analysis of a terminal string in terms of a labeled bracketing.  In transformational analysis, the SD identifies the input to a transformational rule: it specifies which phrase-markers are to be affected by the rule.  i.e. which will 'satisfy' or 'meet' the conditions of the rule. The terms structural analysis and structure index are also used. [Crystal 2008: 458]
    /// <see href="http://purl.org/linguistics/gold/StructuralDescription"></see></summary>
    let StructuralDescription = _prefix "StructuralDescription"
    /// <summary>
    /// SubablativeCase expresses that the referent of the noun it marks is the location from under which another referent is moving. It has the meaning 'from under'. Kibrik says that Archi (aqc) possesses a nominal spatial form expressing SubablativeCase, namely -L´aš [Kibrik 1998: 470].
    /// <see href="http://purl.org/linguistics/gold/SubablativeCase"></see></summary>
    let SubablativeCase = _prefix "SubablativeCase"
    /// <summary>
    /// SuballativeCase expresses that  something is moving toward the region that is under the referent of the noun it marks. It has the meaning 'towards the region that is under'. Kibrik says that Archi (aqc) possesses a nominal spatial form expressing SuballativeCase, namely -L´aši [Kibrik 1998: 470].
    /// <see href="http://purl.org/linguistics/gold/SuballativeCase"></see></summary>
    let SuballativeCase = _prefix "SuballativeCase"
    /// <summary>
    /// SubessiveCase expresses that the referent of the noun it marks is the location under which another referent exists. It has the meaning of 'under' or 'beneath'. Kibrik says that Archi (aqc) possesses a nominal spatial form expressing SubessiveCase, namely -L´ [Kibrik 1998: 470].
    /// <see href="http://purl.org/linguistics/gold/SubessiveCase"></see></summary>
    let SubessiveCase = _prefix "SubessiveCase"
    /// <summary>
    /// SubjunctiveMood is used to express '"states of affairs" whose occurrence could easily be denied or affirmed, but instead is left unasserted.' [Lavandera 1983: 211]
    /// <see href="http://purl.org/linguistics/gold/SubjunctiveMood"></see></summary>
    let SubjunctiveMood = _prefix "SubjunctiveMood"
    /// <summary>
    /// Characterizing sounds produced by the underside of the tip of the tongue  [Ladefoged 1997: 596].
    /// <see href="http://purl.org/linguistics/gold/Sublaminal"></see></summary>
    let Sublaminal = _prefix "Sublaminal"
    /// <summary>
    /// In certain languages (notably, languages of the Finno-Urgic family), a declensional case having the same denotation as in English the use of the contruction "from below" before a substantive. [Pei and Gaynor 1980: 203-204] Kibrik says that Archi (aqc) possesses a nominal spatial form expressing SublativeCase, namely -L´ak [Kibrik 1998: 470].
    /// <see href="http://purl.org/linguistics/gold/SublativeCase"></see></summary>
    let SublativeCase = _prefix "SublativeCase"
    /// <summary>
    /// A substantive is a member of the syntactic class in which the names of physical, concrete, relatively unchanging experiences are most typically found whose members may act as subjects and  objects, and most of whose members have inherently determined grammatical  gender (in languages which inflect for gender) [Crystal 1997: 264; Givon 1984: 51-52; Payne 1997: 33].
    /// <see href="http://purl.org/linguistics/gold/Substantive"></see></summary>
    let Substantive = _prefix "Substantive"
    /// <summary>
    /// SubterminativeCase expresses the notion of something moving into the region under the referent of the noun it marks, but not through that region. It has the meaning 'into the region under'. Kibrik says that Archi (aqc) possesses a nominal spatial form expressing SubterminativeCase, namely -L´akana [Kibrik 1998: 470].
    /// <see href="http://purl.org/linguistics/gold/SubterminativeCase"></see></summary>
    let SubterminativeCase = _prefix "SubterminativeCase"
    /// <summary>
    /// SubtranslativeCase expresses the notion of something moving along a trajectory underneath the referent of the noun it marks. It has the meaning 'along the region underneath'. Kibrik says that Archi (aqc) possesses a nominal spatial form expressing SubtranslativeCase, namely -L´aXut [Kibrik 1998: 470].
    /// <see href="http://purl.org/linguistics/gold/SubtranslativeCase"></see></summary>
    let SubtranslativeCase = _prefix "SubtranslativeCase"
    /// <summary>
    /// An affix, consisting of a letter, syllable, or syllables, that follows a stem or word, modifying its meaning. Suffixes may be inflectional or derivational. [Crystal 1987: 431; Hartmann and Stork 1972: 225; Pei and Gaynor 1980: 207]
    /// <see href="http://purl.org/linguistics/gold/Suffix"></see></summary>
    let Suffix = _prefix "Suffix"
    /// <summary>
    /// Superablative expresses that  the referent of the noun it marks is at the location from over which another referent is moving. It has the meaning 'from over'. Kibrik says that Archi (aqc) possesses a nominal spatial form expressing SuperablativeCase, namely -t:iš. He gives the example 'aInš-li-t:-iš' ('aIns' = 'apple'). [Kibrik 1998: 470-471]
    /// <see href="http://purl.org/linguistics/gold/SuperablativeCase"></see></summary>
    let SuperablativeCase = _prefix "SuperablativeCase"
    /// <summary>
    /// SuperallativeCase expresses that something is moving toward the region that is above the referent of the noun it marks. It has the meaning 'towards the region that is over'. Kibrik says that Archi (aqc) possesses a nominal spatial form expressing SuperallativeCase, namely -t:iši [Kibrik 1998: 470].
    /// <see href="http://purl.org/linguistics/gold/SuperallativeCase"></see></summary>
    let SuperallativeCase = _prefix "SuperallativeCase"
    /// <summary>
    /// SuperessiveCase expresses that  the referent of the noun it marks is the location on which another referent exists. It has the meaning of 'on' or 'upon'. [Pei and Gaynor 1954: 207] Kibrik says that Archi (aqc) possesses a nominal spatial form expressing SuperessiveCase, namely -t. He gives the example 'aInš-li-t' ('aIns' = 'apple'). [Kibrik 1998: 470-471]
    /// <see href="http://purl.org/linguistics/gold/SuperessiveCase"></see></summary>
    let SuperessiveCase = _prefix "SuperessiveCase"
    /// <summary>
    /// That form of an adjective that expresses that the thing to which it refers possesses a certain quality or attribute to a greater extent than any other thing [Hartmann and Stork 1972: 60; Pei and Gaynor 1980: 207].
    /// <see href="http://purl.org/linguistics/gold/SuperlativeAdjective"></see></summary>
    let SuperlativeAdjective = _prefix "SuperlativeAdjective"
    /// <summary>
    /// SuperlativeCase expresses that  the referent of the noun it marks is the location onto which another referent is moving. It has the meaning of 'onto'. Kibrik says that Archi (aqc) possesses a nominal spatial form expressing SuperlativeCase, namely -t:ik. He gives the example 'aInš-li-t:-ik' ('aIns' = 'apple'). [Kibrik 1998: 470-471] Unfortunate name clash with 'Superlative' as a property of adjectives.
    /// <see href="http://purl.org/linguistics/gold/SuperlativeCase"></see></summary>
    let SuperlativeCase = _prefix "SuperlativeCase"
    /// <summary>
    /// SuperterminativeCase expresses the notion of something moving into the region over the referent of the noun it marks, but not through that region. It has the meaning 'into the region over'. Kibrik says that Archi (aqc) possesses a nominal spatial form expressing SuperterminativeCase, namely -t:ikana [Kibrik 1998: 470].
    /// <see href="http://purl.org/linguistics/gold/SuperterminativeCase"></see></summary>
    let SuperterminativeCase = _prefix "SuperterminativeCase"
    /// <summary>
    /// SupertranslativeCase expresses the notion of something moving along a trajectory above the referent of the noun it marks. It has the meaning 'along the region over'. Kibrik says that Archi (aqc) possesses a nominal spatial form expressing SupertranslativeCase, namely -t:iXut [Kibrik 1998: 470].
    /// <see href="http://purl.org/linguistics/gold/SupertranslativeCase"></see></summary>
    let SupertranslativeCase = _prefix "SupertranslativeCase"
    /// <summary>
    /// Phonetic features extending over more than one segment, such as stress, length, tone, and intonation, which are not properties of single consonants or vowels [Crystal 1987: 431; Ladefoged 2000: 276].
    /// <see href="http://purl.org/linguistics/gold/Suprasegmental"></see></summary>
    let Suprasegmental = _prefix "Suprasegmental"
    /// <summary>
    /// Ladefoged contends that there is no satisfactory definition for this unit of speech, but that syllables seem to be necessary units in the mental organization and production of utterances. However, Crystal defines the syllable as an element of speech that acts as a unit of rhythm, consisting of a vowel, syllabic, or vowel/consonant combination. [Crystal 1987: 431; Ladefoged 2000: 276]
    /// <see href="http://purl.org/linguistics/gold/Syllable"></see></summary>
    let Syllable = _prefix "Syllable"
    /// <summary>
    /// Properties may be stated to be symmetric. If a property is symmetric, then if the pair (x,y) is an instance of the symmetric property P, then the pair (y,x) is also an instance of P. For example, friend may be stated to be a symmetric property. Then a reasoner that is given that Frank is a friend of Deborah can deduce that Deborah is a friend of Frank. [McGuinness
    /// <see href="http://purl.org/linguistics/gold/SymmetricProperty"></see></summary>
    let SymmetricProperty = _prefix "SymmetricProperty"
    /// <summary>
    /// SyntacticArgument is the class of syntactic words that are fundamentally referable and  non-relational [Anderson 1997: 15]. Proper names are the quintessential arguments, though pronouns and nouns possess argument properties.
    /// <see href="http://purl.org/linguistics/gold/SyntacticArgument"></see></summary>
    let SyntacticArgument = _prefix "SyntacticArgument"
    /// <summary>
    /// SyntacticUnit (also called constituent) is a 'term in grammatical analysis for a linguistic unit which is a functional component of a larger construction. Based on a combination of intuitive and formal (e.g. distributional) criteria, a sentence can be analysed into a series of constituents, such as subject + predicate, or NP+VP, etc. [Crystal 2003: 99]
    /// <see href="http://purl.org/linguistics/gold/SyntacticUnit"></see></summary>
    let SyntacticUnit = _prefix "SyntacticUnit"
    /// <summary>
    /// It can be moved about in the sentence, or at least its position relative to other constituents can be altered by inserting new material.  It cannot be interrupted or its parts reordered. [Cruse 2000: 87-88]
    /// SyntacticWord is the class of syntactic units occupying the lowest position in a syntactic construction.  They are the largest units resistant to insertion of new constituents within their boundaries; or they are the smallest constituents that can be moved within a sentence without making the sentence ungrammatical. [SIL International 2004]
    /// <see href="http://purl.org/linguistics/gold/SyntacticWord"></see></summary>
    let SyntacticWord = _prefix "SyntacticWord"
    /// <summary>
    /// A Tap 'is a sound in which a brief contact between the articulators is made by moving the active articulator directly towards the roof of the mouth.' A tap is 'usually coronal. ... Taps are most typically made by a direct movement of the tongue tip to a contact location in the dental or alveolar region.' [Ladefoged 1996: 231]
    /// <see href="http://purl.org/linguistics/gold/Tap"></see></summary>
    let Tap = _prefix "Tap"
    /// <summary>
    /// A term in the phonetic classification of consonant sounds on the basis of their manner of articulation: also known as trilled consonant, or a roll, 'trill' refers to any sound made by the rapid tapping of one organ of articulation against another. [Crystal 2008: 496]
    /// <see href="http://purl.org/linguistics/gold/TrillProperty"></see></summary>
    let TrillProperty = _prefix "TrillProperty"
    /// <summary>
    /// A vocabulary item which has a special meaning in a particular subject field, e.g. 'sound' or 'voice' in phonetics, or 'butterfly' in swimming. [Hartmann and Stork 1972: 236]
    /// <see href="http://purl.org/linguistics/gold/Term"></see></summary>
    let Term = _prefix "Term"
    /// <summary>
    /// Denotes the termination of an event [Bhat 1999: 92].
    /// <see href="http://purl.org/linguistics/gold/TerminativeAspect"></see></summary>
    let TerminativeAspect = _prefix "TerminativeAspect"
    /// <summary>
    /// Cases expressing spatial relations (also semantic) can be grouped into four broad directional classes: cases expressing location ('at'), goal ('to'), source ('from'), and path ('through, along'). The basic terms for these are: locative, allative, ablative, and perlative. Additionally, the label terminative is used for a movement that goes all the way to its endpoint, and orientative - for a movement that goes only in the direction of its goal. [Kibort 2008b]
    /// <see href="http://purl.org/linguistics/gold/TerminativeCase"></see></summary>
    let TerminativeCase = _prefix "TerminativeCase"
    /// <summary>
    /// A set of scientific terms used as part of an annotation system, usually the standard terms from a particular linguistic theory.
    /// <see href="http://purl.org/linguistics/gold/Termset"></see></summary>
    let Termset = _prefix "Termset"
    /// <summary>
    /// Third Person is a person property that refers to the non-participant (other than the speaker and the addressee) [Crystal 1997: 285].
    /// <see href="http://purl.org/linguistics/gold/ThirdPerson"></see></summary>
    let ThirdPerson = _prefix "ThirdPerson"
    /// <summary>
    /// ThirdPersonObviative is a person property that  refers to one or more non-participants that are in some way further removed from the speaker than other non-particpants. Contrasts with ThirdPersonProximative. [Kibort 2008a]
    /// <see href="http://purl.org/linguistics/gold/ThirdPersonObviative"></see></summary>
    let ThirdPersonObviative = _prefix "ThirdPersonObviative"
    /// <summary>
    /// Refers to one or more non-participants that are in some way distinct/closer to the speaker than other non-participants. Third person proximative contrasts with third person obviative. Often called 'Third Person Proximate' or '4th person'. [Kibort 2008a]
    /// <see href="http://purl.org/linguistics/gold/ThirdPersonProximative"></see></summary>
    let ThirdPersonProximative = _prefix "ThirdPersonProximative"
    /// <summary>
    /// TimitiveMood encodes that the speaker fears something expressed in what is said [Palmer 2001: 13, 22].
    /// <see href="http://purl.org/linguistics/gold/TimitiveMood"></see></summary>
    let TimitiveMood = _prefix "TimitiveMood"
    /// <summary>
    /// A stress or tonal element which in a tone language distinguishes two otherwise identical words or forms. [Hartmann and Stork 1972: 238; Pei and Gaynor 1980: 218]
    /// <see href="http://purl.org/linguistics/gold/Toneme"></see></summary>
    let Toneme = _prefix "Toneme"
    /// <summary>
    /// Those grammatical features which are used systematically to express certain relationships between the participants in a communicative situation and the actions, states, or circumstances in which they are involved [Hartmann
    /// <see href="http://purl.org/linguistics/gold/TransitiveProperty"></see></summary>
    let TransitiveProperty = _prefix "TransitiveProperty"
    /// <summary>
    /// A transitive verb is a verb that takes a direct object, and describes a relation between two participants [Crystal 1997: 397; Payne 1997: 171].
    /// <see href="http://purl.org/linguistics/gold/TransitiveVerb"></see></summary>
    let TransitiveVerb = _prefix "TransitiveVerb"
    /// <summary>
    /// A derivational unit that derives transitive verbs from intransitive verb (stems).
    /// <see href="http://purl.org/linguistics/gold/Transitivizer"></see></summary>
    let Transitivizer = _prefix "Transitivizer"
    /// <summary>
    /// TranslativeCase expresses that the referent of the noun, or the quality of the adjective, that it marks is the result of a process of change [Lyons 1968: 299-301; Sebeok 1946: 17; Hakulinen 1961: 70]. X along, across Y.
    /// <see href="http://purl.org/linguistics/gold/TranslativeCase"></see></summary>
    let TranslativeCase = _prefix "TranslativeCase"
    /// <summary>
    /// The trial is for referring to three distinct real world entities. [Corbett 2000: 21]
    /// <see href="http://purl.org/linguistics/gold/TrialNumber"></see></summary>
    let TrialNumber = _prefix "TrialNumber"
    /// <summary>
    /// The vibration of one speech organ against another, driven by the aerodynamic conditions. One of the soft moveable parts of the vocal tract is placed close enough to another surface, so that when a current of air of the right strength passes through the aperture created by this configuration, a repeating pattern of closing and opening of the flow channel occurs. [Ladefoged and Maddieson 1996: 217]
    /// <see href="http://purl.org/linguistics/gold/Trill"></see></summary>
    let Trill = _prefix "Trill"
    /// <summary>
    /// Unaspirated refers to the configuration of glottal opening, release at the oral stricture, and vocal fold vibration in which the glottal opening gesture begins at the moment that the oral closure is made, but the maximum width of the glottal opening is reached at about the mid-point of the oral closure duration and the vocal folds return to a voicing position at about the moment of release. This typically results in a weak sounding release which lacks the burst of air characteristic of aspirated phonemes. [Ladefoged and Maddieson 1996: 66-70]
    /// <see href="http://purl.org/linguistics/gold/Unaspirated"></see></summary>
    let Unaspirated = _prefix "Unaspirated"
    /// <summary>
    /// UnattestedVariety is the class of language varieties that are posited to exist or to have existed. Examples include reconstructed languages, such as Proto-Indo-European.
    /// <see href="http://purl.org/linguistics/gold/UnattestedVariety"></see></summary>
    let UnattestedVariety = _prefix "UnattestedVariety"
    /// <summary>
    /// Vegetable gender refers to inanimates and exists in some four-way gender systems, e.g., masculine, feminine, neuter, and vegetable as in Bininj Gun-wok [Evans 2003: 202].
    /// <see href="http://purl.org/linguistics/gold/VegetableGender"></see></summary>
    let VegetableGender = _prefix "VegetableGender"
    /// <summary>
    /// A unit of sentence structure consisting of a verb and the other elements closely linked to it. Traditional grammarians divided a typical sentence into two parts: a subject and a predicate. In our modern elaboration of this, the syntactic category which acts as a subject is a noun phrase, while the category acting as the predicate is a verb phrase. A verb phrase always contains a verb, and it usually contains some other material closely linked to that verb. [Trask 1999: 335] According to the valence of the verb, the number and kind of the obligatory complements may vary; in addition, any number of free complements are possible. The border between obligatory and free complementsis often difficult to draw. [Bussmann 1996: 513]
    /// <see href="http://purl.org/linguistics/gold/VerbPhrase"></see></summary>
    let VerbPhrase = _prefix "VerbPhrase"
    /// <summary>
    /// An adjectival which is closely related in form and or meaning to a verb. For example, -ed and -ing forms in English which are used as adjectives. [Crystal 1985: 326; Hartmann and Stork 1972: 249; Pei and Gaynor 1980: 227]
    /// <see href="http://purl.org/linguistics/gold/VerbalAdjective"></see></summary>
    let VerbalAdjective = _prefix "VerbalAdjective"
    /// <summary>
    /// Verbal particles are a closed class of uninflected words that co-occur with certain verbs. In some cases the verbal particles may have clearly distinguishable locative or directional meanings. In some languages some or all of the verbal particles also occur as (and are historically derived from) adpositions. In other languages, however, for example Ga'anda, the verbal particles are entirely distinct from adpositions. [Schachter 1985: 45-46]
    /// <see href="http://purl.org/linguistics/gold/VerbalParticle"></see></summary>
    let VerbalParticle = _prefix "VerbalParticle"
    /// <summary>
    /// Verbalizer is the class of category changing units that change nouns into verbs.
    /// <see href="http://purl.org/linguistics/gold/Verbalizer"></see></summary>
    let Verbalizer = _prefix "Verbalizer"
    /// <summary>
    /// Versive refers to an intransitive verb, usually derived from an adjective but occasionally from a noun or adverb, with the meaning 'to become X'. [Edmonson 1995: 378]
    /// <see href="http://purl.org/linguistics/gold/Versive"></see></summary>
    let Versive = _prefix "Versive"
    /// <summary>
    /// VisualEvidentiality encodes the fact that the speaker came to believe the content of the expression through direct visual experience; they saw it [Palmer 2001: 57].
    /// <see href="http://purl.org/linguistics/gold/VisualEvidentiality"></see></summary>
    let VisualEvidentiality = _prefix "VisualEvidentiality"
    /// <summary>
    /// VocativeCase marks a noun whose referent is being addressed [Crystal 1980: 377; Hartmann and Stork 1972: 251; Pei and Gaynor 1954: 228].
    /// <see href="http://purl.org/linguistics/gold/VocativeCase"></see></summary>
    let VocativeCase = _prefix "VocativeCase"
    /// <summary>
    /// A fundamental term used in the phonetic classification of speech sounds, referring to the auditory result of the vibration of the vocal cords. Sounds produced while the vocal cords are vibrating are voiced. [Crystal 1985: 329]
    /// <see href="http://purl.org/linguistics/gold/Voiced"></see></summary>
    let Voiced = _prefix "Voiced"
    /// <summary>
    /// Refers to the vibratory activity of the vocal folds. Most languages have phonemic contrasts between voiced and voiceless sounds (regular vibration of the vocal folds versus no vibration of the vocal folds respectively). However, Ladefoged and Maddieson recognize five steps in the continuum of modes of vibration in the glottis, going from breathy voice - the most open setting of the vocal folds in which vibration will occur, passing through slack voice, modal voice, and stiff voice, ending with creaky voice - the most constricted setting in which vibration will occur. Each of these modes of voicing may or may not be phonemic in a given language. [Ladefoged and Maddieson 1996: 48-49]
    /// <see href="http://purl.org/linguistics/gold/VoicingProperty"></see></summary>
    let VoicingProperty = _prefix "VoicingProperty"
    /// <summary>
    /// A fundamental term used in the phonetic classification of speech sounds, referring to the auditory result of the vibration of the vocal cords. Sounds produced while the vocal cords are not vibrating are voiceless. [Crystal 1985: 329]
    /// <see href="http://purl.org/linguistics/gold/Voiceless"></see></summary>
    let Voiceless = _prefix "Voiceless"
    /// <summary>
    /// VolitiveForce indicates that the speaker is willing to perform some action [Palmer 2001: 76].
    /// <see href="http://purl.org/linguistics/gold/VolitiveForce"></see></summary>
    let VolitiveForce = _prefix "VolitiveForce"
    /// <summary>
    /// One of the two general categories used for the classification of speech sounds, the other being consonant. Phonetically, they are sounds articulated without a complete closure in the mouth that would produce a stop or a degree of narrowing that would create audible friction; the air escapes evenly over the center of the tongue. For oral vowels, air escapes solely through the mouth. If some air is simultaneously released through the nose, the vowel is nasal. The quality of the vowel sound is affected by the shape of the oral resonance chamber, chiefly influenced by the position of the lips and the position of the tongue. [Crystal 1985: 330; Hartmann and Stork 1972: 253]
    /// <see href="http://purl.org/linguistics/gold/Vowel"></see></summary>
    let Vowel = _prefix "Vowel"
    /// <summary>
    /// WeakObligativeModality indicates that an agent is under a moral obligation to perform the action expressed by the predicate [Bybee, Perkins and Pagliuca 1994: 186-187].
    /// <see href="http://purl.org/linguistics/gold/WeakObligativeModality"></see></summary>
    let WeakObligativeModality = _prefix "WeakObligativeModality"
    /// <summary>
    /// One of the means or modes of linguistic communication.  As distinct from spoken language, it does not usually represent all features of speech such as stress and pitch, and lacks the redundancy and lapses of spoken conversation (written dialogue and reading aloud are more akin to written than to spoken language). Also reference orthography. [Hartmann and Stork 1972: 258]
    /// <see href="http://purl.org/linguistics/gold/WrittenLanguage"></see></summary>
    let WrittenLanguage = _prefix "WrittenLanguage"
    /// <summary>
    /// ZeroPlacePredicator is the class of syntactic words that need not take any arguments, but act as predicators nevertheless.
    /// <see href="http://purl.org/linguistics/gold/ZeroPlacePredicator"></see></summary>
    let ZeroPlacePredicator = _prefix "ZeroPlacePredicator"
    /// <summary>
    /// The abbreviated form representing a scientific term, e.g., ACC, 2, CL.
    /// <see href="http://purl.org/linguistics/gold/abbreviation"></see></summary>
    let abbreviation = _prefix "abbreviation"
    /// <summary>
    /// The relation between some linguistic unit and its corresponding spoken expression.
    /// <see href="http://purl.org/linguistics/gold/acousticRealization"></see></summary>
    let acousticRealization = _prefix "acousticRealization"
    /// <summary>
    /// The relation holding between a linguistic unit and its physical form, either a spoken, written or signed expression.
    /// <see href="http://purl.org/linguistics/gold/realization"></see></summary>
    let realization = _prefix "realization"
    /// <summary>
    ///   <see href="http://purl.org/linguistics/gold/adjunct"></see>
    /// </summary>
    let adjunct = _prefix "adjunct"
    /// <summary>
    /// The relation hasSyntacticConstituent is an abstract partial ordering relation that expresses dominance between two syntactic units. This relation is meant to cover all possible types of syntactic constituency.
    /// <see href="http://purl.org/linguistics/gold/hasSyntacticConstituent"></see></summary>
    let hasSyntacticConstituent = _prefix "hasSyntacticConstituent"
    /// <summary>
    ///   <see href="http://purl.org/linguistics/gold/agent"></see>
    /// </summary>
    let agent = _prefix "agent"
    /// <summary>
    ///   <see href="http://purl.org/linguistics/gold/semanticRole"></see>
    /// </summary>
    let semanticRole = _prefix "semanticRole"
    /// <summary>
    /// A relation holding between syntactic units, often manifesting itself in shared form features. NOTE: this could be better defined once syntactic roles and relations are developed.
    /// <see href="http://purl.org/linguistics/gold/agrees"></see></summary>
    let agrees = _prefix "agrees"
    /// <summary>
    /// The relation that holds between a morpheme and one of its morphs, an occurrence of a morpheme in context.
    /// <see href="http://purl.org/linguistics/gold/allomorph"></see></summary>
    let allomorph = _prefix "allomorph"
    /// <summary>
    /// The relation that holds between a phoneme and one of its phones, an occurrence of a phoneme in context.
    /// <see href="http://purl.org/linguistics/gold/allophone"></see></summary>
    let allophone = _prefix "allophone"
    /// <summary>
    /// ancestorVariety is the predicate expressing the basic diachronic relationship  between a language variety that existed some time in the past and a variety existing at a later time  such that the  former has evolved into the latter through regular language change.
    /// <see href="http://purl.org/linguistics/gold/ancestorVariety"></see></summary>
    let ancestorVariety = _prefix "ancestorVariety"
    /// <summary>
    /// antonym
    /// <see href="http://purl.org/linguistics/gold/antonym"></see></summary>
    let antonym = _prefix "antonym"
    /// <summary>
    /// This is the superclass of common lexical relatations such as synonym, antonym, etc. NOTE: this needs work. Such relations really pertain to meaning and not form units.
    /// <see href="http://purl.org/linguistics/gold/lexicalRelation"></see></summary>
    let lexicalRelation = _prefix "lexicalRelation"
    /// <summary>
    /// The syntactic entity about which something is predicated.
    /// <see href="http://purl.org/linguistics/gold/argument"></see></summary>
    let argument = _prefix "argument"
    /// <summary>
    /// A general category subsuming relations relevant at the level of the Clause, such as predicate and subject.
    /// A grammatical relation is a role of a phrase or  complement clause that determines syntactic behaviors such as the following: word position in a clause; verb agreement; participation and behavior in such operations as  passivization [Comrie 1989, 65-66; Andrews 1985, 66].
    /// <see href="http://purl.org/linguistics/gold/syntacticRole"></see></summary>
    let syntacticRole = _prefix "syntacticRole"
    /// <summary>
    /// NOTE: still lacks development. This relation holds between two form units and represents the notion of circumscription in a morphosyntactic system. That is, (circumscribes A B) means that part of A comes before B and part of A comes after B, in the linearization of the units of a language.
    /// <see href="http://purl.org/linguistics/gold/circumscribes"></see></summary>
    let circumscribes = _prefix "circumscribes"
    /// <summary>
    /// A relation holding between morphological units.
    /// <see href="http://purl.org/linguistics/gold/morphologicalRelation"></see></summary>
    let morphologicalRelation = _prefix "morphologicalRelation"
    /// <summary>
    /// The closing segment of a syllable.
    /// <see href="http://purl.org/linguistics/gold/coda"></see></summary>
    let coda = _prefix "coda"
    /// <summary>
    ///   <see href="http://purl.org/linguistics/gold/complement"></see>
    /// </summary>
    let complement = _prefix "complement"
    /// <summary>
    /// The relation holding between a linguistic unit and a list (rdf:Seq) of its constituents.
    /// <see href="http://purl.org/linguistics/gold/constituents"></see></summary>
    let constituents = _prefix "constituents"
    /// <summary>
    /// This subsumes all structuring relations used for LinguisticDataStructures. As a naming convention to distinguish relations in data structure from other relations, all names of dataStructuringRelations begin with 'has-'.
    /// <see href="http://purl.org/linguistics/gold/dataStructureRelation"></see></summary>
    let dataStructureRelation = _prefix "dataStructureRelation"
    /// <summary>
    ///   <see href="http://purl.org/linguistics/gold/derivedForm"></see>
    /// </summary>
    let derivedForm = _prefix "derivedForm"
    /// <summary>
    /// A direct object is a grammatical relation that exhibits a combination of certain independent syntactic properties, such as the following:  the usual grammatical characteristics of the patient of typically  transitive verbs; particular case marking; a particular clause  position; the conditioning of an agreement  affix on the verb; the capability of becoming the clause subject in  passivization; the capability of reflexivization. The identification of the direct object relation may be further confirmed by finding significant overlap with similar direct object relations previously established in other languages. This may be done by analyzing correspondence between  translation equivalents [Crystal 1985, 94; Hartmann and Stork 1972, 155; Comrie 1989, 66; Andrews 1985, 68,120,126; Comrie 1985, 337].
    /// <see href="http://purl.org/linguistics/gold/directObject"></see></summary>
    let directObject = _prefix "directObject"
    /// <summary>
    /// An object, traditionally defined, is either a direct object or an indirect object.An object, in some usages, is any  grammatical relation other than subject [Crystal 1985, 211; Hartmann and Stork 1972, 155-156; Comrie 1989, 66].
    /// <see href="http://purl.org/linguistics/gold/object"></see></summary>
    let object = _prefix "object"
    /// <summary>
    ///   <see href="http://purl.org/linguistics/gold/entailedBy"></see>
    /// </summary>
    let entailedBy = _prefix "entailedBy"
    /// <summary>
    ///   <see href="http://purl.org/linguistics/gold/entails"></see>
    /// </summary>
    let entails = _prefix "entails"
    /// <summary>
    /// The relation between a linguistic unit and a linguistic feature. A feature inheres in its host. NOTE: this relation is distinct from the hasFeature which pertains to data structures.
    /// <see href="http://purl.org/linguistics/gold/feature"></see></summary>
    let feature = _prefix "feature"
    /// <summary>
    /// This relation holds between two linguistic units and represents the inverse of 'precedes'. That is, (follows A B) means that A comes after B in the linearization of the realization of linguistic signs. The inverse of this relation is 'precedes'.
    /// <see href="http://purl.org/linguistics/gold/follows"></see></summary>
    let follows = _prefix "follows"
    /// <summary>
    /// Any relation that establishes a linear ordering of linguistic units.
    /// <see href="http://purl.org/linguistics/gold/orderingRelation"></see></summary>
    let orderingRelation = _prefix "orderingRelation"
    /// <summary>
    /// The relation between an orthographic expression in one language and some orthographic expression in another such that both expressions have exactly the same meaning. The words in the translation may not correspond to the those in the source expression.
    /// <see href="http://purl.org/linguistics/gold/freeTranslation"></see></summary>
    let freeTranslation = _prefix "freeTranslation"
    /// <summary>
    /// The relation between an orthographic expression in one language and some orthographic expression in another such that both expressions have the same or roughly the same meaning.
    /// <see href="http://purl.org/linguistics/gold/translation"></see></summary>
    let translation = _prefix "translation"
    /// <summary>
    /// geneticallyRelated is the basic kinship relation between languages varieties. If two language varieties are genetically related, then this implies that both  varieties are derived from a common  proto-language.
    /// <see href="http://purl.org/linguistics/gold/geneticallyRelated"></see></summary>
    let geneticallyRelated = _prefix "geneticallyRelated"
    /// <summary>
    ///   <see href="http://purl.org/linguistics/gold/goal"></see>
    /// </summary>
    let goal = _prefix "goal"
    /// <summary>
    /// This relates a ComplexSpecification to a FeatureStructure, thus giving a FeatureStructure its recursive properties.
    /// <see href="http://purl.org/linguistics/gold/hasComplexValue"></see></summary>
    let hasComplexValue = _prefix "hasComplexValue"
    /// <summary>
    /// The relation hasConstituent is an abstract partial ordering relation that expresses dominance between two linguistic units. This relation is meant to cover all possible types of linguistic constituency: phonological, morphological, syntactic, etc. constituency.
    /// <see href="http://purl.org/linguistics/gold/hasConstituent"></see></summary>
    let hasConstituent = _prefix "hasConstituent"
    /// <summary>
    /// This relates a FeatureSystem to a FeatureContraint.
    /// <see href="http://purl.org/linguistics/gold/hasConstraint"></see></summary>
    let hasConstraint = _prefix "hasConstraint"
    /// <summary>
    ///   <see href="http://purl.org/linguistics/gold/hasExample"></see>
    /// </summary>
    let hasExample = _prefix "hasExample"
    /// <summary>
    /// This relates a FeatureSpecification to a type of LinguisticProperty.
    /// <see href="http://purl.org/linguistics/gold/hasFeature"></see></summary>
    let hasFeature = _prefix "hasFeature"
    /// <summary>
    /// The relation that associates some LinguisticSign with its FormUnit.
    /// <see href="http://purl.org/linguistics/gold/hasForm"></see></summary>
    let hasForm = _prefix "hasForm"
    /// <summary>
    /// The binary relation holding between an instance of interlinear glossed text (IGT) and a sequence of labels or 'grams' used to describe the morphemes of the IGT.
    /// <see href="http://purl.org/linguistics/gold/hasGlosses"></see></summary>
    let hasGlosses = _prefix "hasGlosses"
    /// <summary>
    /// The relation that holds between a LinguisticSign and a GrammaticalUnit.
    /// <see href="http://purl.org/linguistics/gold/hasGrammar"></see></summary>
    let hasGrammar = _prefix "hasGrammar"
    /// <summary>
    /// The relation between a Lexicon and its contents, instances of LexicalItem. NOTE: this could probably be replaced by the memberOf relation from set theory.
    /// <see href="http://purl.org/linguistics/gold/hasLexicalItem"></see></summary>
    let hasLexicalItem = _prefix "hasLexicalItem"
    /// <summary>
    /// This relates a LexicalItem to a LexicalUnit, those elements commonly represented in a dictionary.
    /// <see href="http://purl.org/linguistics/gold/hasLexicalUnit"></see></summary>
    let hasLexicalUnit = _prefix "hasLexicalUnit"
    /// <summary>
    /// The relation that associates some LinguisticSign with a SemanticUnit.
    /// <see href="http://purl.org/linguistics/gold/hasMeaning"></see></summary>
    let hasMeaning = _prefix "hasMeaning"
    /// <summary>
    /// The relation hasMorphologicalConstituent is an abstract partial ordering relation that expresses dominance between two morphological units. This relation is meant to cover all possible types of morphological constituency.
    /// <see href="http://purl.org/linguistics/gold/hasMorphologicalConstituent"></see></summary>
    let hasMorphologicalConstituent = _prefix "hasMorphologicalConstituent"
    /// <summary>
    ///   <see href="http://purl.org/linguistics/gold/MorphologicalUnit"></see>
    /// </summary>
    let MorphologicalUnit = _prefix "MorphologicalUnit"
    /// <summary>
    /// The relation between a linguistic unit and a linguistic property, e.g., (m1 hasProperty AllativeCase) where m1 is an instance of Morpheme.
    /// <see href="http://purl.org/linguistics/gold/hasProperty"></see></summary>
    let hasProperty = _prefix "hasProperty"
    /// <summary>
    /// The binary relation holding between an instance of interlinear glossed text and a linguistic unit (clause, phrase, etc.) from the source language.
    /// <see href="http://purl.org/linguistics/gold/hasSourceLine"></see></summary>
    let hasSourceLine = _prefix "hasSourceLine"
    /// <summary>
    /// This relates a FeatureStructure to a FeatureSpecification.
    /// <see href="http://purl.org/linguistics/gold/hasSpecification"></see></summary>
    let hasSpecification = _prefix "hasSpecification"
    /// <summary>
    /// The relation between some Termset and a Term.
    /// <see href="http://purl.org/linguistics/gold/hasTerm"></see></summary>
    let hasTerm = _prefix "hasTerm"
    /// <summary>
    /// The binary relation holding between an instance of interlinear glossed text and a linguistic unit (clause, phrase, etc.) acting as a free translation of the source text from the IGT instance.
    /// <see href="http://purl.org/linguistics/gold/hasTranslationLine"></see></summary>
    let hasTranslationLine = _prefix "hasTranslationLine"
    /// <summary>
    /// This relates either a FeatureStructure or a FeatureConstraint to its type, expressed by an instance of PartOfSpeech.
    /// <see href="http://purl.org/linguistics/gold/hasType"></see></summary>
    let hasType = _prefix "hasType"
    /// <summary>
    ///   <see href="http://purl.org/linguistics/gold/head"></see>
    /// </summary>
    let head = _prefix "head"
    /// <summary>
    /// hypernym
    /// <see href="http://purl.org/linguistics/gold/hypernym"></see></summary>
    let hypernym = _prefix "hypernym"
    /// <summary>
    /// The relation that holds between a LinguisticSign and a Language. The sign is said to be a member or part of that language.
    /// <see href="http://purl.org/linguistics/gold/inLanguage"></see></summary>
    let inLanguage = _prefix "inLanguage"
    /// <summary>
    ///   <see href="http://purl.org/linguistics/gold/indirectObject"></see>
    /// </summary>
    let indirectObject = _prefix "indirectObject"
    /// <summary>
    /// infixedIn is the relation between a Lexical- or SublexicalUnit and a Root. The Root is realized as discontinuous, surrounding the inserted Lexical- or SublexicalUnit [Hartmann and Stork 1972, 111].
    /// <see href="http://purl.org/linguistics/gold/infixedIn"></see></summary>
    let infixedIn = _prefix "infixedIn"
    /// <summary>
    ///   <see href="http://purl.org/linguistics/gold/inflectedForm"></see>
    /// </summary>
    let inflectedForm = _prefix "inflectedForm"
    /// <summary>
    /// This relation names or simply associates some SymbolicString with any Entity.
    /// <see href="http://purl.org/linguistics/gold/labels"></see></summary>
    let labels = _prefix "labels"
    /// <summary>
    /// The relation between an orthographic expression in one language and some orthographic expression in another such that the translation is done on a word by word, or morpheme by morpheme, basis without regard for idiomatic usage.
    /// <see href="http://purl.org/linguistics/gold/literalTranslation"></see></summary>
    let literalTranslation = _prefix "literalTranslation"
    /// <summary>
    /// meronym
    /// <see href="http://purl.org/linguistics/gold/meronym"></see></summary>
    let meronym = _prefix "meronym"
    /// <summary>
    /// mutuallyIntelligible is the binary, symmetric relation holding between two language varieties such that speakers of the first variety can communicate with members of the second with relative ease, and vice versa.
    /// <see href="http://purl.org/linguistics/gold/mutuallyIntelligible"></see></summary>
    let mutuallyIntelligible = _prefix "mutuallyIntelligible"
    /// <summary>
    /// This semiotic relation associates some OrthographicExpression with some Entity. It differs from 'labels' in that a name is usually considered part of the orthographic system, where a label is not.
    /// <see href="http://purl.org/linguistics/gold/names"></see></summary>
    let names = _prefix "names"
    /// <summary>
    /// The central segment of a syllable.
    /// <see href="http://purl.org/linguistics/gold/nucleus"></see></summary>
    let nucleus = _prefix "nucleus"
    /// <summary>
    /// The initial segment of a syllable.
    /// <see href="http://purl.org/linguistics/gold/onset"></see></summary>
    let onset = _prefix "onset"
    /// <summary>
    ///   <see href="http://purl.org/linguistics/gold/orthographicRep"></see>
    /// </summary>
    let orthographicRep = _prefix "orthographicRep"
    /// <summary>
    ///   <see href="http://purl.org/linguistics/gold/stringRep"></see>
    /// </summary>
    let stringRep = _prefix "stringRep"
    /// <summary>
    /// parentVariety is the  relation of direct genetic relatedness, where there are  no intermediate ancestors between the ancestor and descendant. For example, Old English is the parent variety of Middle English.
    /// <see href="http://purl.org/linguistics/gold/parentVariety"></see></summary>
    let parentVariety = _prefix "parentVariety"
    /// <summary>
    /// A semantic role, often unmarked, that typically does not act with volition, instigate an event, receive something, or experience a sensory impression.  A prototypical patient undergoes a physical, visible change in state. Often the subject of a intransitive verb or the logical complement of a transitive verb. [Payne 1997: 50-51; Pei
    /// <see href="http://purl.org/linguistics/gold/patient"></see></summary>
    let patient = _prefix "patient"
    /// <summary>
    ///   <see href="http://purl.org/linguistics/gold/phonemicRep"></see>
    /// </summary>
    let phonemicRep = _prefix "phonemicRep"
    /// <summary>
    ///   <see href="http://purl.org/linguistics/gold/phoneticRep"></see>
    /// </summary>
    let phoneticRep = _prefix "phoneticRep"
    /// <summary>
    /// This relation holds between two linguistic units and represents the notion of precedence in a language. That is, (precedes A B) means that A comes before B in the linearization of the realization of linguistic signs. This inverse of this relation is 'follows'.
    /// <see href="http://purl.org/linguistics/gold/precedes"></see></summary>
    let precedes = _prefix "precedes"
    /// <summary>
    /// The predicate is the relation between the Clause and a portion of a  clause, excluding the subject, that expresses something about the subject [Crystal 1980, 280; Hartmann and Stork 1972, 182; Pei and Gaynor 1954, 173; Pike and Pike 1982, 40; Crystal 1985, 241-242].
    /// <see href="http://purl.org/linguistics/gold/predicate"></see></summary>
    let predicate = _prefix "predicate"
    /// <summary>
    /// The relation between a morphological unit and the  lexical unit to which it is attached. The LexicalUnit is usually a Root or Stem. The inverse of prefix is suffix [Crystal 1980, 281; Hartmann and Stork 1972, 182].
    /// <see href="http://purl.org/linguistics/gold/prefix"></see></summary>
    let prefix = _prefix "prefix"
    /// <summary>
    /// The core of a syllable, consisting of a nucleus and coda.
    /// <see href="http://purl.org/linguistics/gold/rhyme"></see></summary>
    let rhyme = _prefix "rhyme"
    /// <summary>
    /// The relation between some linguistic unit and its corresponding signed expression.
    /// <see href="http://purl.org/linguistics/gold/signedRealization"></see></summary>
    let signedRealization = _prefix "signedRealization"
    /// <summary>
    ///   <see href="http://purl.org/linguistics/gold/specifier"></see>
    /// </summary>
    let specifier = _prefix "specifier"
    /// <summary>
    ///   <see href="http://purl.org/linguistics/gold/subject"></see>
    /// </summary>
    let subject = _prefix "subject"
    /// <summary>
    /// The relation between a morphological unit and the  lexical unit to which it is attached. The LexicalUnit is usually a Root or Stem. The inverse of suffix is 'prefix' [Crystal 1980, 340; Hartmann and Stork 1972, 226].
    /// <see href="http://purl.org/linguistics/gold/suffix"></see></summary>
    let suffix = _prefix "suffix"
    /// <summary>
    /// synonym
    /// <see href="http://purl.org/linguistics/gold/synonym"></see></summary>
    let synonym = _prefix "synonym"
    /// <summary>
    /// The relation between some linguistic unit and its corresponding written expression.
    /// <see href="http://purl.org/linguistics/gold/writtenRealization"></see></summary>
    let writtenRealization = _prefix "writtenRealization"
