#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module gold =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://purl.org/linguistics/gold/" "gold"

    /// <summary>
    ///   <para>rdfs:comment : AbessiveCase expresses the lack or absence of the referent of the noun it marks. It has the meaning of the English preposition 'without' [Pei and Gaynor 1954: 3, 35].</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : AbessiveCase</para>
    ///   <a href="http://purl.org/linguistics/gold/AbessiveCase">gold:AbessiveCase</a>
    /// </summary>
    let AbessiveCase = _prefixId.prefix "AbessiveCase"
    /// <summary>
    ///   <para>rdfs:comment : AbilitativeModality indicates the capacity of an agent to perform some action, regardless of type or condition. This is also known as the abilitive.</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : AbilitativeModality</para>
    ///   <a href="http://purl.org/linguistics/gold/AbilitativeModality">gold:AbilitativeModality</a>
    /// </summary>
    let AbilitativeModality = _prefixId.prefix "AbilitativeModality"
    /// <summary>
    ///   <para>rdfs:comment : Ablative case denotes the source, agent, means, and occasionally also time or place of an an act or occurence. [Pei and Gaynor 1954: 3]</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : AblativeCase</para>
    ///   <a href="http://purl.org/linguistics/gold/AblativeCase">gold:AblativeCase</a>
    /// </summary>
    let AblativeCase = _prefixId.prefix "AblativeCase"
    /// <summary>
    ///   <para>rdfs:comment : A term used by some Mayanists to refer to an antipassive in which the patient or logical object is supressed or overtly absent. [Klaiman 1991: 232] Dayley states that the absolutive antipassive is used when the patient is unknown or irrelevant, or when the speaker does not wish to mention the patient, or to describe a transitive activity typically performed by some agent. The absolutive antipassive requires a non-specific implied patient, and no specific patient is ever semantically recoverable from the speech context. Only the absolutive antipassive has (as the name implies) absolutive function such that a transitive activity may be discussed without mention of the patient. [Dayley 1985: 345-350] This type of antipassive with an obligatorily unidentified object is also found in Mam, another Mayan language. [Cooreman 1994: 52-53]</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : AbsolutiveAntipassiveVoice</para>
    ///   <a href="http://purl.org/linguistics/gold/AbsolutiveAntipassiveVoice">gold:AbsolutiveAntipassiveVoice</a>
    /// </summary>
    let AbsolutiveAntipassiveVoice = _prefixId.prefix "AbsolutiveAntipassiveVoice"
    /// <summary>
    ///   <para>rdfs:comment : AbsolutiveCase in ergative-absolutive languages marks referents that would generally be the subjects of intransitive verbs or the objects of transitive verbs in the translational equivalents of nominative-accusative languages [Anderson 1985: 181; Crystal 1985: 1; Andrews 1985: 138].</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : AbsolutiveCase</para>
    ///   <a href="http://purl.org/linguistics/gold/AbsolutiveCase">gold:AbsolutiveCase</a>
    /// </summary>
    let AbsolutiveCase = _prefixId.prefix "AbsolutiveCase"
    /// <summary>
    ///   <para>rdfs:comment : Properties or qualities as distinguished from any particular embodiment of the properties/ qualities in a physical medium. Instances of Abstract can be said to exist in the same sense as mathematical objects such as sets and relations, but they cannot exist at a particular place and time without some physical encoding or embodiment. [SUMO 2010]</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : Abstract</para>
    ///   <a href="http://purl.org/linguistics/gold/Abstract">gold:Abstract</a>
    /// </summary>
    let Abstract = _prefixId.prefix "Abstract"
    /// <summary>
    ///   <para>rdfs:comment : AccusativeCase in nominative-accusative languages marks certain syntactic functions, usually direct objects [Hartmann and Stork 1972: 3, 156; Crystal 1980: 11, 246; Andrews 1985: 75; Anderson 1985: 181].</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : AccusativeCase</para>
    ///   <a href="http://purl.org/linguistics/gold/AccusativeCase">gold:AccusativeCase</a>
    /// </summary>
    let AccusativeCase = _prefixId.prefix "AccusativeCase"
    /// <summary>
    ///   <para>rdfs:comment : The class of properties concerning the acoustic nature of speech sounds. [Ladefoged 2000: 161]</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : AcousticProperty</para>
    ///   <a href="http://purl.org/linguistics/gold/AcousticProperty">gold:AcousticProperty</a>
    /// </summary>
    let AcousticProperty = _prefixId.prefix "AcousticProperty"
    /// <summary>
    ///   <para>rdfs:comment : ActionalForce indicates that the speaker or hearer is to undertake some action. Actional force subsumes Imperative, Commissive and Hortatory force.</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : ActionalForce</para>
    ///   <a href="http://purl.org/linguistics/gold/ActionalForce">gold:ActionalForce</a>
    /// </summary>
    let ActionalForce = _prefixId.prefix "ActionalForce"
    /// <summary>
    ///   <para>rdfs:comment : Associated with transitivity, when the action is performed by an agent (subject) on another participant (object) [McIntosh 1984: 108]. It refers to the category of underived verb forms associated with the basic diathesis [Shibatani 1995: 7].</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : ActiveVoice</para>
    ///   <a href="http://purl.org/linguistics/gold/ActiveVoice">gold:ActiveVoice</a>
    /// </summary>
    let ActiveVoice = _prefixId.prefix "ActiveVoice"
    /// <summary>
    ///   <para>rdfs:comment : AdessiveCase expresses that  the referent of the noun it marks is the location near/at which another referent exists. It has the meaning of 'at' or 'near' [Crystal 1997: 8].</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : AdessiveCase</para>
    ///   <a href="http://purl.org/linguistics/gold/AdessiveCase">gold:AdessiveCase</a>
    /// </summary>
    let AdessiveCase = _prefixId.prefix "AdessiveCase"
    /// <summary>
    ///   <para>rdfs:comment : An adjectival, or 'adjective', is a part of speech whose members modify nouns. An adjectival specifies the attributes of a noun referent. Note: this is one case among many. Adjectivals are a class of modifiers. An adjectival may be inflected as comparitive or superlative [Crystal 1997: 8; Payne 1997: 63].</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : Adjectival</para>
    ///   <a href="http://purl.org/linguistics/gold/Adjectival">gold:Adjectival</a>
    /// </summary>
    let Adjectival = _prefixId.prefix "Adjectival"
    /// <summary>
    ///   <para>rdfs:comment : A phrase with an adjective as a head. [Crystal 2003: 11] Adjective phrases may contain complements following the head, and modifiers in either pre-head or post-head position, but for the  most part, complements in adjective phrase structure are optional elements: they qualify as complements by virtue of being licensed by the head rather than  being obligatory. [Huddleston and Pullum 2002: 22-23, 57, 542]</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : AdjectivePhrase</para>
    ///   <a href="http://purl.org/linguistics/gold/AdjectivePhrase">gold:AdjectivePhrase</a>
    /// </summary>
    let AdjectivePhrase = _prefixId.prefix "AdjectivePhrase"
    /// <summary>
    ///   <para>rdfs:comment : A word or phrase which is used to extend the meaning of another word or phrase, but which is not one of the main structural elements of a sentence [Hartmann and Stork 1972: 5]. Adjunct clauses include subordinate clauses (i.e. those with overt subordinating conjunctions).</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : AdjunctSubordinate</para>
    ///   <a href="http://purl.org/linguistics/gold/AdjunctSubordinate">gold:AdjunctSubordinate</a>
    /// </summary>
    let AdjunctSubordinate = _prefixId.prefix "AdjunctSubordinate"
    /// <summary>
    ///   <para>rdfs:comment : An adposition is a part of speech whose members are of a closed set and occur before or after a complement composed of a noun phrase, noun, pronoun, or clause that functions as a noun phrase and forms a single structure with the complement to express its grammatical and semantic relation to another unit within a clause [Comrie 1989: 91; Crystal 1997: 305; Payne 1997: 86].</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : Adposition</para>
    ///   <a href="http://purl.org/linguistics/gold/Adposition">gold:Adposition</a>
    /// </summary>
    let Adposition = _prefixId.prefix "Adposition"
    /// <summary>
    ///   <para>rdfs:comment : An adverbial, or 'adverb', narrowly defined, is a part of speech whose members modify verbs for such categories as time, manner, place, or direction. An adverbal, broadly defined, is a part of speech whose members modify any constituent class of words other than nouns, such as verbs, adjectives, adverbs, phrases, clauses, or sentences. Under this definition, the possible type of modification depends on the class of the constituent being modified [Crystal 1997: 11; Payne 1997: 69].</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : Adverbial</para>
    ///   <a href="http://purl.org/linguistics/gold/Adverbial">gold:Adverbial</a>
    /// </summary>
    let Adverbial = _prefixId.prefix "Adverbial"
    /// <summary>
    ///   <para>rdfs:comment : Marks clauses as having some adverbial function, such as the expression of time, purpose, result, etc. In some languages, many of the words that serve as adverbializers also serve as prepositional or postpositional noun adjuncts. In some languages, an adverbializer in a subordinate clause may be optionally paired with another conjunction occurring in the main clause. There are also cases where an adverbializer in a subordinate clause is obligatorily paired with a conjunction in the main clause. [Schachter 1985: 51-52]rdfs:comment : An adverbializer is a subordinating connective that links a subordinate clause  to a main clause, and indicates that the subordinate clause has an adverbial or interpropositional relation  to the main clause, indicating purpose, condition, time, and location. [SIL International 2004]</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : Adverbializer</para>
    ///   <a href="http://purl.org/linguistics/gold/Adverbializer">gold:Adverbializer</a>
    /// </summary>
    let Adverbializer = _prefixId.prefix "Adverbializer"
    /// <summary>
    ///   <para>rdfs:comment : An affix is a morpheme with an abstract meaning which can only be used when added to a root morpheme.  These are classified in four different ways, depending on their position with reference to the root: suffix, prefix, circumfix and infix. [Haspelmath 2002: 265; Crystal 1980: 17]</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : Affix</para>
    ///   <a href="http://purl.org/linguistics/gold/Affix">gold:Affix</a>
    /// </summary>
    let Affix = _prefixId.prefix "Affix"
    /// <summary>
    ///   <para>rdfs:comment : The object of the active retains its old case-marking in the passive, the subject of the active cannot appear in the passive clause, and the passive tends to be semantically active [Givon 1988: 419].</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : AgentDeletionPassiveVoice</para>
    ///   <a href="http://purl.org/linguistics/gold/AgentDeletionPassiveVoice">gold:AgentDeletionPassiveVoice</a>
    /// </summary>
    let AgentDeletionPassiveVoice = _prefixId.prefix "AgentDeletionPassiveVoice"
    /// <summary>
    ///   <para>rdfs:comment : Refers to the direction of the airstream in speech sound production. In the canonical literature, there are three airstream mechanisms: pulmonic, velaric, and glottalic. Glottalic airstream mechanism is sometimes used to describe the method of production of ejectives and implosives. Ladefoged and Maddieson prefer to regard implosives and ejectives as characterized by a laryngeal parameter of movement rather than an airstream property. [Ladefoged and Maddieson 1996: 372-373]</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : AirstreamProperty</para>
    ///   <a href="http://purl.org/linguistics/gold/AirstreamProperty">gold:AirstreamProperty</a>
    /// </summary>
    let AirstreamProperty = _prefixId.prefix "AirstreamProperty"
    /// <summary>
    ///   <para>rdfs:comment : AllativeCase expresses motion to or toward the referent of the noun it marks [Pei and Gaynor 1954: 6, 9, 216; Lyons 1968: 299; Crystal 1985: 1213].</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : AllativeCase</para>
    ///   <a href="http://purl.org/linguistics/gold/AllativeCase">gold:AllativeCase</a>
    /// </summary>
    let AllativeCase = _prefixId.prefix "AllativeCase"
    /// <summary>
    ///   <para>rdfs:comment : Characterizing sounds produced with the alveolar ridge as the passive articulator [Ladefoged 1997: 598].</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : Alveolar</para>
    ///   <a href="http://purl.org/linguistics/gold/Alveolar">gold:Alveolar</a>
    /// </summary>
    let Alveolar = _prefixId.prefix "Alveolar"
    /// <summary>
    ///   <para>rdfs:comment : A grammatical gender property assigned to a class of nouns with animate denotation. In a given language it may include larger or smaller numbers of nouns which do not meet this semantic criterion. The animate gender may occur in a two-gender system, with the other gender being labeled inanimate. However, the animate gender may also occur in larger inventories (i.e. greater than two values). Examples of these larger systems are found in Bantu languages (where nouns denoting humans are included in the animate gender) and in languages of Daghestan (where the animate gender is typically for non-human animates) [Corbett 1991: 20-32].</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : AnimateGender</para>
    ///   <a href="http://purl.org/linguistics/gold/AnimateGender">gold:AnimateGender</a>
    /// </summary>
    let AnimateGender = _prefixId.prefix "AnimateGender"
    /// <summary>
    ///   <para>rdfs:comment : 'Linguistic annotation' covers any descriptive or analytic notations applied to raw language data. The basic data may be in the form of time functions - audio, video and/or physiological recordings - or it may be textual. The added notations may include transcriptions of all sorts (from phonetic features to discourse structures), part-of-speech and sense tagging, syntactic analysis, 'named entity' identification, co-reference annotation, and so on. [Bird and Liberman 2000: 1]</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : AnnotationProperty</para>
    ///   <a href="http://purl.org/linguistics/gold/AnnotationProperty">gold:AnnotationProperty</a>
    /// </summary>
    let AnnotationProperty = _prefixId.prefix "AnnotationProperty"
    /// <summary>
    ///   <para>rdfs:comment : Properties characterized by focusing on the upper passive articulator on the roof of the mouth [Ladefoged 1997: 597].</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : AnteriorProperty</para>
    ///   <a href="http://purl.org/linguistics/gold/AnteriorProperty">gold:AnteriorProperty</a>
    /// </summary>
    let AnteriorProperty = _prefixId.prefix "AnteriorProperty"
    /// <summary>
    ///   <para>rdfs:comment : An intransitive verb is derived from a basically transitive one with the direct object of the transitive verb corresponding to the subject of the intransitive [Siewierska 1988: 267].</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : AntiCausativeVoice</para>
    ///   <a href="http://purl.org/linguistics/gold/AntiCausativeVoice">gold:AntiCausativeVoice</a>
    /// </summary>
    let AntiCausativeVoice = _prefixId.prefix "AntiCausativeVoice"
    /// <summary>
    ///   <para>rdfs:comment : In the antipassive construction, the patient-like argument is either suppressed (left implicit) or realized as an oblique complement, rather than as a direct object as would be the case in the basic two-place predicate transitive construction. The antipassive voice is most commonly found in ergative languages. In this case, the direct object, which is in the absolutive case in the transitive construction, is no longer marked as absolutive, but is marked as oblique or is supressed entirely. The agent-like argument, marked as ergative in a typical transitive construction, is instead marked as absolutive, making it appear like the agent of an intransitive construction. [Polinsky 2008]</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : AntiPassiveVoice</para>
    ///   <a href="http://purl.org/linguistics/gold/AntiPassiveVoice">gold:AntiPassiveVoice</a>
    /// </summary>
    let AntiPassiveVoice = _prefixId.prefix "AntiPassiveVoice"
    /// <summary>
    ///   <para>rdfs:comment : Characterizing sounds produced by the tip of the tongue [Ladefoged 1997: 596].</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : Apical</para>
    ///   <a href="http://purl.org/linguistics/gold/Apical">gold:Apical</a>
    /// </summary>
    let Apical = _prefixId.prefix "Apical"
    /// <summary>
    ///   <para>rdfs:comment : Properties characterized by focusing on the action of the lower, active articulator, i.e. which part of the tongue is used in articulation [Ladefoged 1997: 597].</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : ApicalityProperty</para>
    ///   <a href="http://purl.org/linguistics/gold/ApicalityProperty">gold:ApicalityProperty</a>
    /// </summary>
    let ApicalityProperty = _prefixId.prefix "ApicalityProperty"
    /// <summary>
    ///   <para>rdfs:comment : The applicative voice is a grammatical voice which promotes an oblique argument of a verb to the (core) patient argument, and indicates the oblique role within the meaning of the verb. Applicatives have a degree of overlap with causatives, and in some languages are realized identically; this isomorphism can be found in Kinyarwanda [Kimenyi 1980: 164], Yagua, Malay, and Dyirbal [Croft 1990: 242].
    ///
    /// While differing from true applicatives, a similar construction known as dative shifting occurs in other languages, including English. Two subtle differences between applicative and dative-shift constructions are: (1) applicatives involve some marking on the verb whereas dative-shift constructions do not; and (2) dative-shift constructions typically allow only recipients and benefactives to become direct objects whereas applicative constructions normally advance instruments and perhaps other obliques. [Payne 1997: 186-192]</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : ApplicativeVoice</para>
    ///   <a href="http://purl.org/linguistics/gold/ApplicativeVoice">gold:ApplicativeVoice</a>
    /// </summary>
    let ApplicativeVoice = _prefixId.prefix "ApplicativeVoice"
    /// <summary>
    ///   <para>rdfs:comment : This term is used to classify sounds based on their manner of articulation.  Sounds possessing this trait are those in which the involved articulators approach one another, but not close enough to produce audible friction. [Crystal 1980: 30]</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : Approximant</para>
    ///   <a href="http://purl.org/linguistics/gold/Approximant">gold:Approximant</a>
    /// </summary>
    let Approximant = _prefixId.prefix "Approximant"
    /// <summary>
    ///   <para>rdfs:comment : A labeling convention for gender categories. Arabic numerals are often used for languages for which there is a descriptive tradition involving use of the term 'noun class' instead of 'gender', in particular in languages of the Caucasus or Bantu languages; If the 'noun classes' are involved in agreement systems, they are gender systems. Arabic numerals may also be used in instances where another label is possible. For instance, in one language the gender to which nouns with human denotation are assigned might be called 'human', whereas in another language nouns with a similar denotation may be assigned to a gender with an arbitrary Arabic numerical label such as '1'. [Kibort and Corbett 2008a]</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : ArabicNumeralGender</para>
    ///   <a href="http://purl.org/linguistics/gold/ArabicNumeralGender">gold:ArabicNumeralGender</a>
    /// </summary>
    let ArabicNumeralGender = _prefixId.prefix "ArabicNumeralGender"
    /// <summary>
    ///   <para>rdfs:comment : An article is a member of a small class of determiners that identify a noun's definite or indefinite reference, and new or given status [Crystal 1997: 26].</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : Article</para>
    ///   <a href="http://purl.org/linguistics/gold/Article">gold:Article</a>
    /// </summary>
    let Article = _prefixId.prefix "Article"
    /// <summary>
    ///   <para>rdfs:comment : The class of properties defining how sounds are produced in the mouth.  [Ladefoged</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : ArticulatoryProperty</para>
    ///   <a href="http://purl.org/linguistics/gold/ArticulatoryProperty">gold:ArticulatoryProperty</a>
    /// </summary>
    let ArticulatoryProperty = _prefixId.prefix "ArticulatoryProperty"
    /// <summary>
    ///   <para>rdfs:comment : The term 'aspect'; designates the perspective taken on the internal temporal organization of the event, and different values of the Aspect Feature distinguish different ways of viewing the internal temporal constituency of the same event [Comrie 1976: 3ff], after [Holt 1943: 6; Bybee 2003: 157]. The 'event' is understood here as a general term covering any situation type (a state, activity, accomplishment, achievement, etc.) as expressed by the verb phrase of the construction. Unlike Tense Feature, which expresses event-external time and is deictic, Aspect Feature is event-internal and non-deictic, as it is not concerned with relating the time of the event to any other time point. [Kibort 2008e]</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : AspectProperty</para>
    ///   <a href="http://purl.org/linguistics/gold/AspectProperty">gold:AspectProperty</a>
    /// </summary>
    let AspectProperty = _prefixId.prefix "AspectProperty"
    /// <summary>
    ///   <para>rdfs:comment : A sound is described as 'aspirated' when it has a greater rate of airflow than occurs in modal voice for a period of time before or after a stricture. It often accompanies a consonant which precedes a vowel, the beginning of which is unvoiced. [Ladefoged</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : Aspirated</para>
    ///   <a href="http://purl.org/linguistics/gold/Aspirated">gold:Aspirated</a>
    /// </summary>
    let Aspirated = _prefixId.prefix "Aspirated"
    /// <summary>
    ///   <para>rdfs:comment : One of the three types of judgment common in languages, that indicates inference from what is generally known. English has the contrast between Deductive and Assumptive, as shown in: 'John must be in his office', 'John'll be in his office'. Schlichter comments that the speaker believes the case to be true…in the case of the Assumptive ‘because of his experience with similar situations, regular patterns, or repeated circumstances common in human life’. It is used when the speaker has prior knowledge about the state of things or about habitual or general 'behavior patterns', but 'only when no information about the state or event is being or has been received'. In that sense it is the negative member of the evidential system, used when no ready evidence is available. [Palmer 2001: 24-25; 30; 51]</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : AssumptiveEvidentiality</para>
    ///   <a href="http://purl.org/linguistics/gold/AssumptiveEvidentiality">gold:AssumptiveEvidentiality</a>
    /// </summary>
    let AssumptiveEvidentiality = _prefixId.prefix "AssumptiveEvidentiality"
    /// <summary>
    ///   <para>rdfs:comment : A linguistic form for which there is evidence of present or past use. Attestation refers to something that is found in actual recorded usage, compared with the hypothetical predictions of grammar or the intuitive (but otherwise unsupported) observations of the linguist.[Crystal 2003: 41]</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : AttestedVariety</para>
    ///   <a href="http://purl.org/linguistics/gold/AttestedVariety">gold:AttestedVariety</a>
    /// </summary>
    let AttestedVariety = _prefixId.prefix "AttestedVariety"
    /// <summary>
    ///   <para>rdfs:comment : AuditoryEvidentiality encodes the fact that the speaker came to believe the content of the expression through direct auditory experience; they heard it. This does not include spoken reported accounts, but only direct sensory evidence, such as the situation of 'hearing a tree fall' [Palmer 2001: 38].</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : AuditoryEvidentiality</para>
    ///   <a href="http://purl.org/linguistics/gold/AuditoryEvidentiality">gold:AuditoryEvidentiality</a>
    /// </summary>
    let AuditoryEvidentiality = _prefixId.prefix "AuditoryEvidentiality"
    /// <summary>
    ///   <para>rdfs:comment : A special form of a noun that signals that the object being referred to is large relative to the usual size of such an object [Crystal 1980: 34].</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : AugmentativeSize</para>
    ///   <a href="http://purl.org/linguistics/gold/AugmentativeSize">gold:AugmentativeSize</a>
    /// </summary>
    let AugmentativeSize = _prefixId.prefix "AugmentativeSize"
    /// <summary>
    ///   <para>rdfs:comment : Auxiliary is a term used to describe verbs which are used in coordination with another verb to express mood, tense or aspect of the action denoted by the main verb.  Marginal auxiliaries share some of these properties, but not all. [Crystal 1985: 28; Pei</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : Auxiliary</para>
    ///   <a href="http://purl.org/linguistics/gold/Auxiliary">gold:Auxiliary</a>
    /// </summary>
    let Auxiliary = _prefixId.prefix "Auxiliary"
    /// <summary>
    ///   <para>rdfs:comment : AversiveCase expresses fear or is literally translated as 'turning from' in some languages [Blake 2001: 156].</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : AversiveCase</para>
    ///   <a href="http://purl.org/linguistics/gold/AversiveCase">gold:AversiveCase</a>
    /// </summary>
    let AversiveCase = _prefixId.prefix "AversiveCase"
    /// <summary>
    ///   <para>rdfs:comment : A vowel sound produced with the tongue retracted towards the back of the oral cavity, e.g. [a:] as in English ‘calm’ or [u:] as in English ‘soon’. [Hartmann and Stork 1972: 25]</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : Back</para>
    ///   <a href="http://purl.org/linguistics/gold/Back">gold:Back</a>
    /// </summary>
    let Back = _prefixId.prefix "Back"
    /// <summary>
    ///   <para>rdfs:comment : A feature of vowel quality that correlates the difference between frequencies of formant two and formant one (overtones corresponding to a resonating frequency of the air in the vocal tract) [Ladefoged 2000: 215, 273]</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : BacknessProperty</para>
    ///   <a href="http://purl.org/linguistics/gold/BacknessProperty">gold:BacknessProperty</a>
    /// </summary>
    let BacknessProperty = _prefixId.prefix "BacknessProperty"
    /// <summary>
    ///   <para>rdfs:comment : BenefactiveCase expresses that the referent of the noun it marks receives the benefit of the situation expressed by the clause [Crystal 1980: 43].</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : BenefactiveCase</para>
    ///   <a href="http://purl.org/linguistics/gold/BenefactiveCase">gold:BenefactiveCase</a>
    /// </summary>
    let BenefactiveCase = _prefixId.prefix "BenefactiveCase"
    /// <summary>
    ///   <para>rdfs:comment : Binary predicates define relationships between keywords. Each binary predicate is viewed as function: given the value of the first argument, it returns the set of values for the second argument that would make the predicate true. [Feldman and Hirsh 1996: 344] BinaryPredicators are the class of syntactic words that require two arguments.</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : BinaryPredicator</para>
    ///   <a href="http://purl.org/linguistics/gold/BinaryPredicator">gold:BinaryPredicator</a>
    /// </summary>
    let BinaryPredicator = _prefixId.prefix "BinaryPredicator"
    /// <summary>
    ///   <para>rdfs:comment : A bound morpheme (or bound form) is one which cannot occur on its own as a separate word, e.g. various affixes de-, -tion, -ize. [Crystal 2003: 56]</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : BoundMorpheme</para>
    ///   <a href="http://purl.org/linguistics/gold/BoundMorpheme">gold:BoundMorpheme</a>
    /// </summary>
    let BoundMorpheme = _prefixId.prefix "BoundMorpheme"
    /// <summary>
    ///   <para>rdfs:comment : With regard to classifications of vocal qualities, this refers to an effect produced by allowing a large amount of air to pass through the partially open glottis.  Some speakers have this as a permanent characteristic of their speech patterns. [Crystal 1985: 38]</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : Breathy</para>
    ///   <a href="http://purl.org/linguistics/gold/Breathy">gold:Breathy</a>
    /// </summary>
    let Breathy = _prefixId.prefix "Breathy"
    /// <summary>
    ///   <para>rdfs:comment : A subclass of place properties roughly referring to positions inside the mouth [Ladefoged 1997: 606].</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : BuccalProperty</para>
    ///   <a href="http://purl.org/linguistics/gold/BuccalProperty">gold:BuccalProperty</a>
    /// </summary>
    let BuccalProperty = _prefixId.prefix "BuccalProperty"
    /// <summary>
    ///   <para>rdfs:comment : A cardinal numeral is a numeral of the class whose members are considered basic in form, are used in counting, and are used in expressing how many objects are referred to [Crystal 1997: 52].</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : CardinalNumeral</para>
    ///   <a href="http://purl.org/linguistics/gold/CardinalNumeral">gold:CardinalNumeral</a>
    /// </summary>
    let CardinalNumeral = _prefixId.prefix "CardinalNumeral"
    /// <summary>
    ///   <para>rdfs:comment : CaseProperty is the class of properties that concerns the grammatical encoding of a noun's relationship (syntactic or semantic) to some other element in the sentence, such as a verb, noun, pronoun, or adposition [Pei and Gaynor 1954: 35; Crystal 1980: 53-54; Anderson 1985: 179-180; Andrews 1985: 7172; Kuno 1973: 45; Blake 2001].</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : CaseProperty</para>
    ///   <a href="http://purl.org/linguistics/gold/CaseProperty">gold:CaseProperty</a>
    /// </summary>
    let CaseProperty = _prefixId.prefix "CaseProperty"
    /// <summary>
    ///   <para>rdfs:comment : CategoryChanger is a cover class for all derivational units that change the syntactic category of the root to which they are attached.</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : CategoryChanger</para>
    ///   <a href="http://purl.org/linguistics/gold/CategoryChanger">gold:CategoryChanger</a>
    /// </summary>
    let CategoryChanger = _prefixId.prefix "CategoryChanger"
    /// <summary>
    ///   <para>rdfs:comment : A construction can be classified as a morphological causative when there is specific morphological encoding of causativity within the verb. Moreover, a causative is associated with an additional core argument, a causer or causal agent, added to the set of core arguments assigned by the corresponding noncausative verb. [Klaiman 1991: 51]</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : CausativeVoice</para>
    ///   <a href="http://purl.org/linguistics/gold/CausativeVoice">gold:CausativeVoice</a>
    /// </summary>
    let CausativeVoice = _prefixId.prefix "CausativeVoice"
    /// <summary>
    ///   <para>rdfs:comment : Characterizing sounds produced with the tongue  near the center of the mouth (along the front-back dimension).</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : Central</para>
    ///   <a href="http://purl.org/linguistics/gold/Central">gold:Central</a>
    /// </summary>
    let Central = _prefixId.prefix "Central"
    /// <summary>
    ///   <para>rdfs:comment : A consonant articulated so that air passes out the center. [Ladefoged  2000: 155]</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : CentralEscape</para>
    ///   <a href="http://purl.org/linguistics/gold/CentralEscape">gold:CentralEscape</a>
    /// </summary>
    let CentralEscape = _prefixId.prefix "CentralEscape"
    /// <summary>
    ///   <para>rdfs:comment : A symbol used in writing, distinguished from others by its meaning, not its specific shape; similar to grapheme. It relates to the domain of orthographies and writing. Specific to the implementation of computers and other information systems. [Lyons, et al. 2001]</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : Character</para>
    ///   <a href="http://purl.org/linguistics/gold/Character">gold:Character</a>
    /// </summary>
    let Character = _prefixId.prefix "Character"
    /// <summary>
    ///   <para>rdfs:comment : A discontinuous affix that occurs on both sides of the base.  [Haspelmath 2002: 267]</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : Circumfix</para>
    ///   <a href="http://purl.org/linguistics/gold/Circumfix">gold:Circumfix</a>
    /// </summary>
    let Circumfix = _prefixId.prefix "Circumfix"
    /// <summary>
    ///   <para>rdfs:comment : The action of citing or quoting any words or written passage from a publication that allows others to locate and identify the original source. Typical details include the title, author's name, the journal title (for articles), publication date and page numbers used in research. [Oxford English Dictionary 2010]
    ///
    /// Note: This concept was included in order to facilitate linking to the bibliographic entries referenced in GOLD.</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : Citation</para>
    ///   <a href="http://purl.org/linguistics/gold/Citation">gold:Citation</a>
    /// </summary>
    let Citation = _prefixId.prefix "Citation"
    /// <summary>
    ///   <para>rdfs:comment : This term refers to a set of entities, be they words, morphemes or otherwise, which share certain formal or semantic properties.  [Crystal 1980: 60]</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : Class</para>
    ///   <a href="http://purl.org/linguistics/gold/Class">gold:Class</a>
    /// </summary>
    let Class = _prefixId.prefix "Class"
    /// <summary>
    ///   <para>rdfs:comment : In grammar, a morpheme whose function is to indicate the formal or semantic class to which items belong are  sometimes called classifiers, e.g. -ly is an adverb classifier, -ess is a 'femininity' classifier. The marking of lexical items as belonging to the same semantic class is an important feature in many languages (e.g. Chinese, Vietnamese, Hopi), and sometimes quite unexpected bases of classification are found, in terms of shape, size, colour, movability, animacy, status and so on. [Crystal 2003: 74]</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : Classifier</para>
    ///   <a href="http://purl.org/linguistics/gold/Classifier">gold:Classifier</a>
    /// </summary>
    let Classifier = _prefixId.prefix "Classifier"
    /// <summary>
    ///   <para>rdfs:comment : A clause is a subdivision of a sentence containing a subject (argument) and predicate.  It is possible to have a word that implies or refers to a predicate rather than one explicitly stated. [Pei</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : Clause</para>
    ///   <a href="http://purl.org/linguistics/gold/Clause">gold:Clause</a>
    /// </summary>
    let Clause = _prefixId.prefix "Clause"
    /// <summary>
    ///   <para>rdfs:comment : Clitic is the class of units which members exhibit syntactic characteristics of a lexical unit, but show evidence of being morphologically bound to another lexical unit, the host, by being unstressed or subject to word-level phonological rules [Crystal 1980: 64; Hartmann and Stork 1972: 38; Anderson 1985: 158; Klavans 1982: xi-xiv, 74-76, 83, 93-95, 100-101; Zwicky 1977: 5].</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : Clitic</para>
    ///   <a href="http://purl.org/linguistics/gold/Clitic">gold:Clitic</a>
    /// </summary>
    let Clitic = _prefixId.prefix "Clitic"
    /// <summary>
    ///   <para>rdfs:comment : In the classification of tongue movement when articulating vowel sounds, this refers to one produced with the tongue in the highest vertical position possible within the mouth without causing audible friction. [Crystal 1980: 64]</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : Close</para>
    ///   <a href="http://purl.org/linguistics/gold/Close">gold:Close</a>
    /// </summary>
    let Close = _prefixId.prefix "Close"
    /// <summary>
    ///   <para>rdfs:comment : Also called ImmediateFutureTense, this grammatical class names an upcoming situation which is to take place shortly after the moment of utterance [Dahl 1985: 121; Comrie 1985: 94; Bybee, Perkins and Pagliuca 1994: 244-245].</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : CloseFutureTense</para>
    ///   <a href="http://purl.org/linguistics/gold/CloseFutureTense">gold:CloseFutureTense</a>
    /// </summary>
    let CloseFutureTense = _prefixId.prefix "CloseFutureTense"
    /// <summary>
    ///   <para>rdfs:comment : A term referring to complex predicates comprised of two verbs; one of these is an auxiliary which contributes some form of meaning in the form of modality, direction, etc.  They serve a similar purpose to adpositions in Indo-European languages, and are almost always translated as such.  Some examples are found in some east and southeast Asian languages, as well as African languages and Hungarian.  [Yang and Kuo 1998: 20]</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : CoVerb</para>
    ///   <a href="http://purl.org/linguistics/gold/CoVerb">gold:CoVerb</a>
    /// </summary>
    let CoVerb = _prefixId.prefix "CoVerb"
    /// <summary>
    ///   <para>rdfs:comment : ComitativeCase expresses accompaniment. It carries the meaning 'with' or 'accompanied by' [Anderson 1985: 186; Pei and Gaynor 1954: 42; Dixon, R. 1972: 12].</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : ComitativeCase</para>
    ///   <a href="http://purl.org/linguistics/gold/ComitativeCase">gold:ComitativeCase</a>
    /// </summary>
    let ComitativeCase = _prefixId.prefix "ComitativeCase"
    /// <summary>
    ///   <para>rdfs:comment : CommisiveForce indicates that the speaker promises or threatens to perform some action [Palmer 2001: 10, 72].</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : CommissiveForce</para>
    ///   <a href="http://purl.org/linguistics/gold/CommissiveForce">gold:CommissiveForce</a>
    /// </summary>
    let CommissiveForce = _prefixId.prefix "CommissiveForce"
    /// <summary>
    ///   <para>rdfs:comment : CommonNouns refer to a class of objects, places, ideas, and so on.  This is in contrast with ProperNoun.  [Brown and Miller 1999: 424]</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : CommonNoun</para>
    ///   <a href="http://purl.org/linguistics/gold/CommonNoun">gold:CommonNoun</a>
    /// </summary>
    let CommonNoun = _prefixId.prefix "CommonNoun"
    /// <summary>
    ///   <para>rdfs:comment : The form of an adjective which expresses that one thing possesses a certain quality or attribute to a greater extent than another thing or in relation to another reference point. [Hartmann and Stork 1972: 60; Pei and Gaynor 1980: 43]</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : ComparativeAdjective</para>
    ///   <a href="http://purl.org/linguistics/gold/ComparativeAdjective">gold:ComparativeAdjective</a>
    /// </summary>
    let ComparativeAdjective = _prefixId.prefix "ComparativeAdjective"
    /// <summary>
    ///   <para>rdfs:comment : A complement, also called a predicative, is a phrase that gives a description of the subject or object via the verb, while the verb itself expresses no adequate thought without being complemented by this addition.  Most typically this is an adjective phrase. [Asher 1994: 4881; Jespersen 2006: 89; Huddleston and Pullam 2002: 251]</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : Complement</para>
    ///   <a href="http://purl.org/linguistics/gold/Complement">gold:Complement</a>
    /// </summary>
    let Complement = _prefixId.prefix "Complement"
    /// <summary>
    ///   <para>rdfs:comment : A subordinate complement clause is an element which is dependent upon the main clause syntactically and as a whole completes the action of the verb. [Brown and Miller 1999: 424; Crystal 1980: 518]</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : ComplementSubordinate</para>
    ///   <a href="http://purl.org/linguistics/gold/ComplementSubordinate">gold:ComplementSubordinate</a>
    /// </summary>
    let ComplementSubordinate = _prefixId.prefix "ComplementSubordinate"
    /// <summary>
    ///   <para>rdfs:comment : A complementizer is a connective which marks a complement clause [Crystal 1997: 75].</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : Complementizer</para>
    ///   <a href="http://purl.org/linguistics/gold/Complementizer">gold:Complementizer</a>
    /// </summary>
    let Complementizer = _prefixId.prefix "Complementizer"
    /// <summary>
    ///   <para>rdfs:comment : A term used to denote verbal aspect that focuses on the conclusion of a process or action.  [Brown and Miller 1999: 424]</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : CompletiveAspect</para>
    ///   <a href="http://purl.org/linguistics/gold/CompletiveAspect">gold:CompletiveAspect</a>
    /// </summary>
    let CompletiveAspect = _prefixId.prefix "CompletiveAspect"
    /// <summary>
    ///   <para>rdfs:comment : A ComplexSpecification is a kind of FeatureSpecification whose value must be a FeatureStructure. This class gives a feature system its recursive properites [Maxwell, Simons and Hayashi 2000].</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : ComplexSpecification</para>
    ///   <a href="http://purl.org/linguistics/gold/ComplexSpecification">gold:ComplexSpecification</a>
    /// </summary>
    let ComplexSpecification = _prefixId.prefix "ComplexSpecification"
    /// <summary>
    ///   <para>rdfs:comment : A term used widely in descriptive linguistic studies to refer to a linguistic unit which is composed of elements that function independently in other circumstances. [Crystal 2003: 92]</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : Compound</para>
    ///   <a href="http://purl.org/linguistics/gold/Compound">gold:Compound</a>
    /// </summary>
    let Compound = _prefixId.prefix "Compound"
    /// <summary>
    ///   <para>rdfs:comment : One of the three types of Labial that can be associated with sounds involving lip compression involving the vertical movement of one lip towards the other. Such a property is associated with a normal bilabial stop.</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : Compressed</para>
    ///   <a href="http://purl.org/linguistics/gold/Compressed">gold:Compressed</a>
    /// </summary>
    let Compressed = _prefixId.prefix "Compressed"
    /// <summary>
    ///   <para>rdfs:comment : When describing verbs, this is a term used to indicate expression of an unreal or unfulfilled condition.  Some languages use grammatical markers or verb forms to separate real and unreal conditions.  [Brown and Miller 1999: 425]</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : ConditionalModality</para>
    ///   <a href="http://purl.org/linguistics/gold/ConditionalModality">gold:ConditionalModality</a>
    /// </summary>
    let ConditionalModality = _prefixId.prefix "ConditionalModality"

    /// <summary>
    ///   <para>rdfs:comment : ConditionalPhysicalAbilitiveModality indicates ability of an agent to perform some action, requiring the presence of conditions external to the agent [Bybee, Perkins and Pagliuca 1994: 177; Palmer 2001: 76].</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : ConditionalPhysicalAbilitiveModality</para>
    ///   <a href="http://purl.org/linguistics/gold/ConditionalPhysicalAbilitiveModality">gold:ConditionalPhysicalAbilitiveModality</a>
    /// </summary>
    let ConditionalPhysicalAbilitiveModality =
        _prefixId.prefix "ConditionalPhysicalAbilitiveModality"

    /// <summary>
    ///   <para>rdfs:comment : A term used in the grammatical classification of words to refer to an item or a process whose primary function is to connect words or other constructions. The conventional subclassification of these 'connective' items distinguishes co-ordinating conjunctions (e.g. and, or, but) and subordinating conjunctions (e.g. because, when, unless) -- also referred to as 'co-ordinators' and 'subordinators' respectively. [Crystal 2008: 101]</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : Conjunction</para>
    ///   <a href="http://purl.org/linguistics/gold/Conjunction">gold:Conjunction</a>
    /// </summary>
    let Conjunction = _prefixId.prefix "Conjunction"
    /// <summary>
    ///   <para>rdfs:comment : Also known as a conjunction, a Connective is a class of parts of speech whose members syntactically link words or larger  constituents, and expresses a semantic relationship between them. A conjunction is positionally fixed relative to one or more of the elements related by it, thus distinguishing it from constituents such as English conjunctive adverbs [Crystal 1997: 81].</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : Connective</para>
    ///   <a href="http://purl.org/linguistics/gold/Connective">gold:Connective</a>
    /// </summary>
    let Connective = _prefixId.prefix "Connective"
    /// <summary>
    ///   <para>rdfs:comment : A type of sound segment defined by closure or constriction of the vocal tract, which produces an audible friction. The vocal tract constriction does not have to result in complete blocking; it can simply be a restriction of air flow. [Crystal 1985: 66]</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : Consonant</para>
    ///   <a href="http://purl.org/linguistics/gold/Consonant">gold:Consonant</a>
    /// </summary>
    let Consonant = _prefixId.prefix "Consonant"
    /// <summary>
    ///   <para>rdfs:comment : ContablativeCase expresses that  the referent of the noun it marks is the location 'from near' which another referent is moving. It has the meaning 'from near'. Kibrik says that Archi (aqc) possesses a nominal spatial form expressing ContablativeCase, namely -raš [Kibrik 1998: 470].</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : ContablativeCase</para>
    ///   <a href="http://purl.org/linguistics/gold/ContablativeCase">gold:ContablativeCase</a>
    /// </summary>
    let ContablativeCase = _prefixId.prefix "ContablativeCase"
    /// <summary>
    ///   <para>rdfs:comment : ContallativeCase expresses that  something is moving toward the vicinity of the referent of the noun it marks. It has the meaning  'towards the vicinity of'. Kibrik says that Archi (aqc) possesses a nominal spatial form expressing ContallativeCase, namely -rši [Kibrik 1998: 470].</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : ContallativeCase</para>
    ///   <a href="http://purl.org/linguistics/gold/ContallativeCase">gold:ContallativeCase</a>
    /// </summary>
    let ContallativeCase = _prefixId.prefix "ContallativeCase"
    /// <summary>
    ///   <para>rdfs:comment : ConterminativeCase expresses the notion of something moving into the vicinity of the referent of the noun it marks, but not through that region. It has the meaning 'moving into the vicinity of'. Kibrik says that Archi (aqc) possesses a nominal spatial form expressing ConterminativeCase, namely -rakana [Kibrik 1998: 470].</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : ConterminativeCase</para>
    ///   <a href="http://purl.org/linguistics/gold/ConterminativeCase">gold:ConterminativeCase</a>
    /// </summary>
    let ConterminativeCase = _prefixId.prefix "ConterminativeCase"
    /// <summary>
    ///   <para>rdfs:comment : ContextOfUseTaxon is the class of taxons whose instances  classify language varieties according to how they are primarily used.</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : ContextOfUseTaxon</para>
    ///   <a href="http://purl.org/linguistics/gold/ContextOfUseTaxon">gold:ContextOfUseTaxon</a>
    /// </summary>
    let ContextOfUseTaxon = _prefixId.prefix "ContextOfUseTaxon"
    /// <summary>
    ///   <para>rdfs:comment : A value of Aspect Property assigned to the designated element in the clause when the meaning selected for the clause is that which indicates that the situation spoken about has internal temporal structure, but the situation cannot be regarded as habitual (i.e. it cannot be regarded as a characteristic feature of a whole period). Hence, continuousness can be defined negatively as imperfectivity that is not habituality [Comrie 1976: 26-32], and it can be regarded as a sub-type of imperfectivity.
    ///
    /// Typically, for an aspect value to be labelled as Continuous, the aspectual meaning has to minimally express continuousness, although it may additionally express other temporal, aspectual, or modal meanings, or actionality distinctions.
    ///
    /// Continuous aspectual meaning can be further subdivided into two types: progressive meaning and nonprogressive meaning. These two aspectual meanings may or may not be grammaticalised as separate aspect values. [Kibort 2008c: 8]</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : ContinuousAspect</para>
    ///   <a href="http://purl.org/linguistics/gold/ContinuousAspect">gold:ContinuousAspect</a>
    /// </summary>
    let ContinuousAspect = _prefixId.prefix "ContinuousAspect"
    /// <summary>
    ///   <para>rdfs:comment : ContlativeCase expresses that  the referent of the noun it marks is the location in the vicinity of which another referent is moving. It has the meaning 'in the vicinity of'. Kibrik says that Archi (aqc) possesses a nominal spatial form expressing ContlativeCase, namely -rak [Kibrik 1998: 470].</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : ContlativeCase</para>
    ///   <a href="http://purl.org/linguistics/gold/ContlativeCase">gold:ContlativeCase</a>
    /// </summary>
    let ContlativeCase = _prefixId.prefix "ContlativeCase"
    /// <summary>
    ///   <para>rdfs:comment : A nonfinite verb form, i.e., lacking specifications for tense, mood, and agreement with their arguments, whose main function is to mark adverbial subordination. Converbal constructions are generally not arguments but modifiers, and they generally modify verbs, clauses or sentences, but not nouns or noun phrases. They are embedded or incorporated into the superordinate clause, and contrast with coordinate constructions. Converbal constructions can often be paraphrased by means of coordinate constructions in languages that allow coordination of clauses, such as in the gloss for the Korean example below. [Haspelmath 1995: 3-8]</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : Converb</para>
    ///   <a href="http://purl.org/linguistics/gold/Converb">gold:Converb</a>
    /// </summary>
    let Converb = _prefixId.prefix "Converb"
    /// <summary>
    ///   <para>rdfs:comment : A coordinating connective is a connective that links constituents without syntactically subordinating one to the other [Crystal 1997: 93].</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : CoordinatingConnective</para>
    ///   <a href="http://purl.org/linguistics/gold/CoordinatingConnective">gold:CoordinatingConnective</a>
    /// </summary>
    let CoordinatingConnective = _prefixId.prefix "CoordinatingConnective"
    /// <summary>
    ///   <para>rdfs:comment : Indicates a relationship of equivalency between the subject and predicate or complement of a clause. Verbal copulas have essentially the same morphosyntactic properties as verbs: English  'be', Spanish  'ser', and Russian  'byt’' are illustrations of this class. Nonverbal copular items include the the pro-copula - a demonstrative or personal pronoun which serves as the linker between subject and predicate nominal, and which is obligatory in nominal predication - and particle copulas, which have their origin in a variety of markers of discourse-oriented phenomena such as topicalization, backgrounding, or contrastive focus for subjects or predicates. Zero copula refers to a construction in which the relation between a subject and a nominal predicate is not marked by an overt item. Zero copula is mandatory in some languages, such as Sinhalese, whereas it is conditional or restricted in other languages, such as Russian. [Stassen 2008]</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : Copula</para>
    ///   <a href="http://purl.org/linguistics/gold/Copula">gold:Copula</a>
    /// </summary>
    let Copula = _prefixId.prefix "Copula"
    /// <summary>
    ///   <para>rdfs:comment : A verb such as 'be', 'seem', 'become', 'look', etc. which relates the subject to the complement, e.g. in 'He is a teacher', 'The policeman seemed not at all satisfied', 'It got worse and and worse'. [Hartmann and Stork 1972: 55]</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : Copulative</para>
    ///   <a href="http://purl.org/linguistics/gold/Copulative">gold:Copulative</a>
    /// </summary>
    let Copulative = _prefixId.prefix "Copulative"
    /// <summary>
    ///   <para>rdfs:comment : Properties of sounds produced with passive articulators either lying on the coronal axis, with the blade of the tongue raised from its neutral position, or in the neutral position (for non-coronal sounds).  [Crystal 1980: 94]</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : CoronalProperty</para>
    ///   <a href="http://purl.org/linguistics/gold/CoronalProperty">gold:CoronalProperty</a>
    /// </summary>
    let CoronalProperty = _prefixId.prefix "CoronalProperty"
    /// <summary>
    ///   <para>rdfs:comment : A correlative connective is either of a pair of  coordinating conjunctions (connectives) used in ordered fashion. Typically, one is used immediately before each member of a pair of constituents [Crystal 1997: 96].</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : CorrelativeConnective</para>
    ///   <a href="http://purl.org/linguistics/gold/CorrelativeConnective">gold:CorrelativeConnective</a>
    /// </summary>
    let CorrelativeConnective = _prefixId.prefix "CorrelativeConnective"
    /// <summary>
    ///   <para>rdfs:comment : A term referring to a vocal quality in phonetic sound classification in which only one end of the vocal cords vibrates, and does so very slowly.  This is a permanent feature of some speakers' voices. [Crystal 1980: 97]</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : Creaky</para>
    ///   <a href="http://purl.org/linguistics/gold/Creaky">gold:Creaky</a>
    /// </summary>
    let Creaky = _prefixId.prefix "Creaky"
    /// <summary>
    ///   <para>rdfs:comment : DativeCase marks 1) Indirect objects (for languages in which they are held to exist) or 2) nouns having the role of recipient (as of things given), beneficiary of an action, or possessor of an item [Crystal 1980: 102].</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : DativeCase</para>
    ///   <a href="http://purl.org/linguistics/gold/DativeCase">gold:DativeCase</a>
    /// </summary>
    let DativeCase = _prefixId.prefix "DativeCase"
    /// <summary>
    ///   <para>rdfs:comment : A term used in the grammatical classification of sentence types, and usually seen in contrast to imperative, interrogative, etc. It refers to verb forms or sentence/clause types typically used in the expression of statements, e.g. 'the man is walking'. The term 'indicative' is also sometimes used in this sense. [Crystal 2003: 124]rdfs:comment : Declarative force marks an unqualified assertion. This form is generally unmarked for modality, and thus may also be seen as Realis, while modal forms are Irrealis. In English, the Declarative is marked by the absence of a modal verb, although it will be marked for the other verbal categories, tense and aspect. [Palmer 2001: 64]</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : DeclarativeForce</para>
    ///   <a href="http://purl.org/linguistics/gold/DeclarativeForce">gold:DeclarativeForce</a>
    /// </summary>
    let DeclarativeForce = _prefixId.prefix "DeclarativeForce"
    /// <summary>
    ///   <para>rdfs:comment : DeductiveEvidentiality encodes the fact that the speaker came to believe the content of the expression through a sound inference procedure. [Palmer 2001: 6-8].</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : DeductiveEvidentiality</para>
    ///   <a href="http://purl.org/linguistics/gold/DeductiveEvidentiality">gold:DeductiveEvidentiality</a>
    /// </summary>
    let DeductiveEvidentiality = _prefixId.prefix "DeductiveEvidentiality"
    /// <summary>
    ///   <para>rdfs:comment : An definite article is a part of speech whose members refer to a specific, identifiable entity (or class of entities) [Crystal 1997: 107].</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : DefiniteArticle</para>
    ///   <a href="http://purl.org/linguistics/gold/DefiniteArticle">gold:DefiniteArticle</a>
    /// </summary>
    let DefiniteArticle = _prefixId.prefix "DefiniteArticle"
    /// <summary>
    ///   <para>rdfs:comment : DelativeCase expresses motion downward from the referent of the noun it marks [Pei and Gaynor 1954: 53].</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : DelativeCase</para>
    ///   <a href="http://purl.org/linguistics/gold/DelativeCase">gold:DelativeCase</a>
    /// </summary>
    let DelativeCase = _prefixId.prefix "DelativeCase"
    /// <summary>
    ///   <para>rdfs:comment : A demonstrative is a determiner that is used deictically to indicate a referent's spatial, temporal, or discourse location. A demonstrative functions as a modifier of a noun, or a pronoun [Crystal 1997: 312].</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : Demonstrative</para>
    ///   <a href="http://purl.org/linguistics/gold/Demonstrative">gold:Demonstrative</a>
    /// </summary>
    let Demonstrative = _prefixId.prefix "Demonstrative"
    /// <summary>
    ///   <para>rdfs:comment : A consonant which involves the teeth, normally the upper teeth, as the passive articulators in its articulation. The tip or apex  of the tongue usually acts as the active articulator. [Hartmann and Stork 1972: 61]</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : Dental</para>
    ///   <a href="http://purl.org/linguistics/gold/Dental">gold:Dental</a>
    /// </summary>
    let Dental = _prefixId.prefix "Dental"
    /// <summary>
    ///   <para>rdfs:comment : Deontic modality is concerned with the necessity or possibility of acts performed by morally responsible agents and is thus associated with the social functions of permission and obligation. Deontic modality focuses on the notions of obligation and permission. It is found in directives that grant permission (‘you may go now’) or impose obligations (‘eat your vegetables!’), as well as in statements that report deontic conditions. Deontic modality fails to distinguish subcategories that are expressed inflectionally from lexical or periphrastic expressions of obligation or permission. Deontic modality as traditionally understood excludes certain semantically related notions such as ability and desire that have linguistic expression similar to that of permission and obligation. [Bybee and Fleischman 1995: 4-5]</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : DeonticModality</para>
    ///   <a href="http://purl.org/linguistics/gold/DeonticModality">gold:DeonticModality</a>
    /// </summary>
    let DeonticModality = _prefixId.prefix "DeonticModality"
    /// <summary>
    ///   <para>rdfs:comment : Action denotes physical/mental disposition of subject. [Siewierska 1988: 257]</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : DeponentMiddleVoice</para>
    ///   <a href="http://purl.org/linguistics/gold/DeponentMiddleVoice">gold:DeponentMiddleVoice</a>
    /// </summary>
    let DeponentMiddleVoice = _prefixId.prefix "DeponentMiddleVoice"
    /// <summary>
    ///   <para>rdfs:comment : DerivationalUnit is the class of functional units whose members function to derive a new lexical unit from an existing one, by systematically changing the meaning and possibly altering the part of speech feature of the root or stem it attaches to [Hartmann and Stork 1972: 62; Crystal 1985: 89; Bybee 1985: 81-82, 99].</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : DerivationalMorpheme</para>
    ///   <a href="http://purl.org/linguistics/gold/DerivationalMorpheme">gold:DerivationalMorpheme</a>
    /// </summary>
    let DerivationalMorpheme = _prefixId.prefix "DerivationalMorpheme"
    /// <summary>
    ///   <para>rdfs:comment : DescribedVariety is the class of  distinct human languages or language varieties as recognized by a linguist or a particular linguistic community, but not necessarily recognized by the ISO 639-3 standard. This category allows a language to be described even though it is not (yet) included in ISO 639-3.</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : DescribedVariety</para>
    ///   <a href="http://purl.org/linguistics/gold/DescribedVariety">gold:DescribedVariety</a>
    /// </summary>
    let DescribedVariety = _prefixId.prefix "DescribedVariety"
    /// <summary>
    ///   <para>rdfs:comment : A Determiner is a part of speech whose members belong to a class of noun modifiers and express the reference, including  quantity, of a noun [Crystal 1997: 112].</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : Determiner</para>
    ///   <a href="http://purl.org/linguistics/gold/Determiner">gold:Determiner</a>
    /// </summary>
    let Determiner = _prefixId.prefix "Determiner"
    /// <summary>
    ///   <para>rdfs:comment : An auxiliary mark or symbol added above, below or after conventional graphic signs to give more information about the pronunciation of the sound represented in writing. Such diacritic marks include acute accent, apostrophe, caret, cedilla, diaeresis or umlaut, grave accent, macron, tilde and circumflex. [Hartmann and Stork 1972: 65]</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : Diacritic</para>
    ///   <a href="http://purl.org/linguistics/gold/Diacritic">gold:Diacritic</a>
    /// </summary>
    let Diacritic = _prefixId.prefix "Diacritic"
    /// <summary>
    ///   <para>rdfs:comment : A regional, temporal or social variety of a language, differing in pronunciation, grammar and vocabulary from the standard language,which is in itself a socially favoured dialect. [Hartmann and Stork 1972: 65]</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : Dialect</para>
    ///   <a href="http://purl.org/linguistics/gold/Dialect">gold:Dialect</a>
    /// </summary>
    let Dialect = _prefixId.prefix "Dialect"
    /// <summary>
    ///   <para>rdfs:comment : A term used in phonetics/phonology and graphics/graphology to refer to a graphic unit in which two symbols have combined to form a single element in a system. In the study of reading and spelling, digraph refers to any sequence of two letters pronounced as a single sound. [Crystal 2003: 139]</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : Digraph</para>
    ///   <a href="http://purl.org/linguistics/gold/Digraph">gold:Digraph</a>
    /// </summary>
    let Digraph = _prefixId.prefix "Digraph"
    /// <summary>
    ///   <para>rdfs:comment : A special form of a noun that signals that the object being referred to is small relative to the usual size of such an object.  In some cases it may be used as a term of endearment [Crystal 1980: 116].</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : DiminuativeSize</para>
    ///   <a href="http://purl.org/linguistics/gold/DiminuativeSize">gold:DiminuativeSize</a>
    /// </summary>
    let DiminuativeSize = _prefixId.prefix "DiminuativeSize"
    /// <summary>
    ///   <para>rdfs:comment : DirectEvidential, also called sensory, encodes the fact that the speaker came to believe the content of the expression by having direct sensory experience of some situation; this does not include hearing about it from someone else [Palmer 2001: 35-36].</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : DirectEvidentiality</para>
    ///   <a href="http://purl.org/linguistics/gold/DirectEvidentiality">gold:DirectEvidentiality</a>
    /// </summary>
    let DirectEvidentiality = _prefixId.prefix "DirectEvidentiality"
    /// <summary>
    ///   <para>rdfs:comment : Direct voice signals that the action proceeds in an ontologically salient way, i.e. that salience is assigned to nominals based on their referent's relative real-world capacities to control situations. [Klaiman 1991: 32]</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : DirectVoice</para>
    ///   <a href="http://purl.org/linguistics/gold/DirectVoice">gold:DirectVoice</a>
    /// </summary>
    let DirectVoice = _prefixId.prefix "DirectVoice"
    /// <summary>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : DiscourseProperty</para>
    ///   <a href="http://purl.org/linguistics/gold/DiscourseProperty">gold:DiscourseProperty</a>
    /// </summary>
    let DiscourseProperty = _prefixId.prefix "DiscourseProperty"
    /// <summary>
    ///   <para>rdfs:comment : Discourse is the name given to stretches of language longer than one sentence, e.g., conversations, narratives, arguments, and speeches. A discourse unit is an identifiable structure within a discourse. The form of a discourse unit is partly determined by genre and partly by its social context. [Aristar-Dry 2010 (p.c.); based on Mills 1997]</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : DiscourseUnit</para>
    ///   <a href="http://purl.org/linguistics/gold/DiscourseUnit">gold:DiscourseUnit</a>
    /// </summary>
    let DiscourseUnit = _prefixId.prefix "DiscourseUnit"
    /// <summary>
    ///   <para>rdfs:comment : Disjunction refers to a process whose primary function is to mark a relationship of contrast or comparison between structures, using such disjunctive items as 'or' and 'but'. [Crystal 1985: 97]</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : Disjunction</para>
    ///   <a href="http://purl.org/linguistics/gold/Disjunction">gold:Disjunction</a>
    /// </summary>
    let Disjunction = _prefixId.prefix "Disjunction"
    /// <summary>
    ///   <para>rdfs:comment : A verbal aspect expressing that the action or state denoted by the verb is performed or experienced simultaneously by more than one individual or object. [Pei and Gaynor 1954: 59]</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : DistributiveAspect</para>
    ///   <a href="http://purl.org/linguistics/gold/DistributiveAspect">gold:DistributiveAspect</a>
    /// </summary>
    let DistributiveAspect = _prefixId.prefix "DistributiveAspect"
    /// <summary>
    ///   <para>rdfs:comment : Most languages also have various series of numerals, whose denotations combine the concept of number with other concepts of a variety of different kinds. The meaning of sentences containing distributive numerals can be described in terms of a binary semantic relationship of distributivity that obtains between an expression containing the distributive numeral, the distributive share, and some other expression in the sentence, the distributive key. [Gill 2005: 222] Distributive numerals are special adnominal numerals that express distributive relations, as in German ‘Die Männer trugen je drei Koffer’, ‘The men carried three suitcases each.’ English lacks distributive numerals, because in a sentence like ‘They carried three suitcases each, the numeral does not form a continuous constituent with the distributive word ‘each’, i.e. ‘three…each’ does not qualify as a numeral. [Michaelis, Maurer, Haspelmath and Huber 2008]</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : DistributiveNumeral</para>
    ///   <a href="http://purl.org/linguistics/gold/DistributiveNumeral">gold:DistributiveNumeral</a>
    /// </summary>
    let DistributiveNumeral = _prefixId.prefix "DistributiveNumeral"
    /// <summary>
    ///   <para>rdfs:comment : A ditransitive verb is a verb that takes two objects [Crystal 1997: 397].</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : DitransitiveVerb</para>
    ///   <a href="http://purl.org/linguistics/gold/DitransitiveVerb">gold:DitransitiveVerb</a>
    /// </summary>
    let DitransitiveVerb = _prefixId.prefix "DitransitiveVerb"
    /// <summary>
    ///   <para>rdfs:comment : The class of properties associated with sounds made with the body of the tongue [Ladefoged 1997: 601]. Almost all vowels can be described using subclasses of this property.</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : DorsalProperty</para>
    ///   <a href="http://purl.org/linguistics/gold/DorsalProperty">gold:DorsalProperty</a>
    /// </summary>
    let DorsalProperty = _prefixId.prefix "DorsalProperty"
    /// <summary>
    ///   <para>rdfs:comment : The dual quantifies the denotation of the nominal element by specifying that there are exactly 'two' (as in Upper Sorbian, see [Corbett 2000: 20] for examples and discussion. Additionally, but not necessarily, this value may be assigned on the basis of the formal properties of the nominal element (as in dualia tantum, e.g. mangautek 'scissors' in the Yukon dialect of Central Alaskan Yupik; [Jacobson 1984: 226]). The use of the dual varies across languages which have this value. In some languages, dual may be used to refer to any two entities, but in others it must refer to a natural pair such as eyes, and still in others it must refer to two items unless they are a natural pair [Corbett 2000]. [Kibort and Corbett 2008b]</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : DualNumber</para>
    ///   <a href="http://purl.org/linguistics/gold/DualNumber">gold:DualNumber</a>
    /// </summary>
    let DualNumber = _prefixId.prefix "DualNumber"
    /// <summary>
    ///   <para>rdfs:comment : DubitiveMood indicates a speaker's doubt or uncertainty about a proposition. [Palmer 2001: 24-25]</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : DubitiveMood</para>
    ///   <a href="http://purl.org/linguistics/gold/DubitiveMood">gold:DubitiveMood</a>
    /// </summary>
    let DubitiveMood = _prefixId.prefix "DubitiveMood"
    /// <summary>
    ///   <para>rdfs:comment : Events which involve some duration [Bhat 1999: 58].</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : DurativeAspect</para>
    ///   <a href="http://purl.org/linguistics/gold/DurativeAspect">gold:DurativeAspect</a>
    /// </summary>
    let DurativeAspect = _prefixId.prefix "DurativeAspect"
    /// <summary>
    ///   <para>rdfs:comment : ElativeCase expresses that the referent of the noun it marks is the location out of which another referent is moving. It has the meaning 'out of' [Lyons 1968: 299; Pei and Gaynor 1954: 64; Crystal 1985: 106].</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : ElativeCase</para>
    ///   <a href="http://purl.org/linguistics/gold/ElativeCase">gold:ElativeCase</a>
    /// </summary>
    let ElativeCase = _prefixId.prefix "ElativeCase"
    /// <summary>
    ///   <para>rdfs:comment : An enclitic is a clitic that is phonologically joined at the end of a preceding lexical unit to form a single phonological unit [Crystal 1980: 64; Pei and Gaynor 1954: 65].</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : Enclitic</para>
    ///   <a href="http://purl.org/linguistics/gold/Enclitic">gold:Enclitic</a>
    /// </summary>
    let Enclitic = _prefixId.prefix "Enclitic"
    /// <summary>
    ///   <para>rdfs:comment : There are a number of ways to categorize language endangerment situations. One useful taxonomy takes into account the relative rate of attrition together with its causes. This taxonomy recognizes four different categories of attrition: sudden, radical, gradual and top to bottom. [Brown and Ogilvie 2009: 321]</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : EndangermentTaxon</para>
    ///   <a href="http://purl.org/linguistics/gold/EndangermentTaxon">gold:EndangermentTaxon</a>
    /// </summary>
    let EndangermentTaxon = _prefixId.prefix "EndangermentTaxon"
    /// <summary>
    ///   <para>rdfs:comment : EpistemicModality indicates that a state of affairs is known to be possible or certain (necessary). [Palmer 2001: 7-8]</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : EpistemicModality</para>
    ///   <a href="http://purl.org/linguistics/gold/EpistemicModality">gold:EpistemicModality</a>
    /// </summary>
    let EpistemicModality = _prefixId.prefix "EpistemicModality"
    /// <summary>
    ///   <para>rdfs:comment : EpistemicNecessityModality indicates that the expressed proposition is known to be true. Also known as CategoricalModality [Palmer 2001: 37, 68-69].</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : EpistemicNecessityModality</para>
    ///   <a href="http://purl.org/linguistics/gold/EpistemicNecessityModality">gold:EpistemicNecessityModality</a>
    /// </summary>
    let EpistemicNecessityModality = _prefixId.prefix "EpistemicNecessityModality"
    /// <summary>
    ///   <para>rdfs:comment : EpistemicPossibilityModality indicates that the designated state of affairs is not known not to be true.</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : EpistemicPossibilityModality</para>
    ///   <a href="http://purl.org/linguistics/gold/EpistemicPossibilityModality">gold:EpistemicPossibilityModality</a>
    /// </summary>
    let EpistemicPossibilityModality = _prefixId.prefix "EpistemicPossibilityModality"
    /// <summary>
    ///   <para>rdfs:comment : ErgativeCase in ergative-absolutive languages generally identifies the subject of transitive verbs in the translation equivalents of nominative-accusative Languages such as English [Crystal 1980: 134; Hartmann and Stork 1972: 78; Pei and Gaynor 1954: 67; Andrews 1985: 138].</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : ErgativeCase</para>
    ///   <a href="http://purl.org/linguistics/gold/ErgativeCase">gold:ErgativeCase</a>
    /// </summary>
    let ErgativeCase = _prefixId.prefix "ErgativeCase"
    /// <summary>
    ///   <para>rdfs:comment : EssiveCase expresses that  the referent of the noun it marks is the location at which another referent exists [Lyons 1968: 299, 301; Crystal 1985: 112; Blake 2001].</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : EssiveCase</para>
    ///   <a href="http://purl.org/linguistics/gold/EssiveCase">gold:EssiveCase</a>
    /// </summary>
    let EssiveCase = _prefixId.prefix "EssiveCase"
    /// <summary>
    ///   <para>rdfs:comment : A term used in semantics for a type of modality where propositions express the speaker’s attitude (e.g. surprise, regret) towards what is being said. [Crystal 2003: 168]</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : EvaluativeProperty</para>
    ///   <a href="http://purl.org/linguistics/gold/EvaluativeProperty">gold:EvaluativeProperty</a>
    /// </summary>
    let EvaluativeProperty = _prefixId.prefix "EvaluativeProperty"
    /// <summary>
    ///   <para>rdfs:comment : Evidentiality denotes the basis that the speaker has for claiming that the event has occurred (or is going to take place). Appear to show a greater number of distinctions in the realis mood (especially in the past tense) than the irrealis mood. [Bhat 1999: 63-64, 70]</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : EvidentialityProperty</para>
    ///   <a href="http://purl.org/linguistics/gold/EvidentialityProperty">gold:EvidentialityProperty</a>
    /// </summary>
    let EvidentialityProperty = _prefixId.prefix "EvidentialityProperty"
    /// <summary>
    ///   <para>rdfs:comment : An existential marker is a syntactic category whose members are found in distinct clause types and which mark a referent's existence [Crystal 1997: 142].</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : ExistentialMarker</para>
    ///   <a href="http://purl.org/linguistics/gold/ExistentialMarker">gold:ExistentialMarker</a>
    /// </summary>
    let ExistentialMarker = _prefixId.prefix "ExistentialMarker"
    /// <summary>
    ///   <para>rdfs:comment : An expletive (also known as a dummy word) is a part of speech whose members have no meaning, but complete a sentence to make it grammatical [Crystal 1997: 127].</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : Expletive</para>
    ///   <a href="http://purl.org/linguistics/gold/Expletive">gold:Expletive</a>
    /// </summary>
    let Expletive = _prefixId.prefix "Expletive"
    /// <summary>
    ///   <para>rdfs:comment : A language no longer used as a medium of oral communication in a speech community, e.g. Latin, Gothic, as opposed to living languages such as English, Japanese. [Hartmann and Stork 1972: 58]</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : ExtinctVariety</para>
    ///   <a href="http://purl.org/linguistics/gold/ExtinctVariety">gold:ExtinctVariety</a>
    /// </summary>
    let ExtinctVariety = _prefixId.prefix "ExtinctVariety"
    /// <summary>
    ///   <para>rdfs:comment : A type of FeatureDistributionSystem; in a given language, it is the system according to which feature values (of a particular feature) are determined for elements through agreement (i.e. where the form of the element is determined by the presence of another element). [Kibort 2008d]</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : FeatureAgreementSystem</para>
    ///   <a href="http://purl.org/linguistics/gold/FeatureAgreementSystem">gold:FeatureAgreementSystem</a>
    /// </summary>
    let FeatureAgreementSystem = _prefixId.prefix "FeatureAgreementSystem"
    /// <summary>
    ///   <para>rdfs:comment : (The term 'assignment') was first used with respect to feature values by Corbett (1991) in his discussion of mechanisms for allotting nouns to different genders. Native speakers have the ability to ‘work out’ the gender of a noun, and models of this ability have been called ‘gender assignment systems’. So far, the concept of ‘assignment of a feature value’ has not been used outside gender. For some features, there may not be as much to say as for gender. However, using the concept of ‘assignment’ with respect to the values of all features is useful to be able to compare the features. Therefore, for this typology I have adopted the following definition: an assignment system is a set of rules that realise the value of a feature on an element. Note, however, that under this definition, a gender value is ‘assigned’ both to nouns, and to targets of agreement in gender with the noun. [Kibort 2008d: 8]</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : FeatureAssignmentSystem</para>
    ///   <a href="http://purl.org/linguistics/gold/FeatureAssignmentSystem">gold:FeatureAssignmentSystem</a>
    /// </summary>
    let FeatureAssignmentSystem = _prefixId.prefix "FeatureAssignmentSystem"
    /// <summary>
    ///   <para>rdfs:comment : A term used in linguistics, and especially in generative grammar, to refer to a condition which restricts the application of a rule, to ensure that the sentences generated are well formed. For example, in generative phonology, a distinction can be made between ‘simulatenous’ and ‘sequential’ constraints: the former states the restrictions on the simulataneous occurrence of features, e.g. a segment cannot be at once [+high] and [+low]; the latter states the restrictions on sequences of features, e.g. whether a language permits consonant clusters. In generative syntax there are also several constraints which have to be imposed in order to prevent the derivation of ill formed phrase-markers, e.g. constraints on the ordering of rules. The notion of constraints takes on a different direction in optimality theory, where it is the principle explanatory device. Here, constraints are ways of characterizing language universals. Each language has its own ranking of constraints (e.g. which determine morpheme position or syllable structure), and differences between these rankings result in the variations observed between languages. [Crystal 2003: 101]</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : FeatureConstraint</para>
    ///   <a href="http://purl.org/linguistics/gold/FeatureConstraint">gold:FeatureConstraint</a>
    /// </summary>
    let FeatureConstraint = _prefixId.prefix "FeatureConstraint"
    /// <summary>
    ///   <para>rdfs:comment : In a given language, the system according to which feature values (of a particular feature) are determined contextually for elements, through agreement or government. FeatureDistributionSystem can have one or two main components: FeatureAgreementSystem, and FeatureGovernmentSystem. [Kibort 2008d]</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : FeatureDistributionSystem</para>
    ///   <a href="http://purl.org/linguistics/gold/FeatureDistributionSystem">gold:FeatureDistributionSystem</a>
    /// </summary>
    let FeatureDistributionSystem = _prefixId.prefix "FeatureDistributionSystem"
    /// <summary>
    ///   <para>rdfs:comment : The feature of case is typically involved in government. A governor does not bear the feature value it requires of its governee. Government is also asymmetric with regard to the possession of the feature specification by the elements. [Kibort 2008d: 1, 6]</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : FeatureGovernmentSystem</para>
    ///   <a href="http://purl.org/linguistics/gold/FeatureGovernmentSystem">gold:FeatureGovernmentSystem</a>
    /// </summary>
    let FeatureGovernmentSystem = _prefixId.prefix "FeatureGovernmentSystem"
    /// <summary>
    ///   <para>rdfs:comment : A FeatureSpecification is a data structure that groups together a linguistic feature with a value [Maxwell, Simons and Hayashi 2000].</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : FeatureSpecification</para>
    ///   <a href="http://purl.org/linguistics/gold/FeatureSpecification">gold:FeatureSpecification</a>
    /// </summary>
    let FeatureSpecification = _prefixId.prefix "FeatureSpecification"
    /// <summary>
    ///   <para>rdfs:comment : A FeatureStructure is a set of one or more FeatureSpecifications. A FeatureStructure is a kind of information structure, a container or data structure, used to group together qualities or features of some object. In a grammatical feature system, a FeatureStructure holds the grammatical information associated with some linguistic unit. In a typed feature system, a FeatureStructure has an associated type, usually a PartOfSpeech. [Shieber 1986; Maxwell, Simons and Hayashi 2000].</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : FeatureStructure</para>
    ///   <a href="http://purl.org/linguistics/gold/FeatureStructure">gold:FeatureStructure</a>
    /// </summary>
    let FeatureStructure = _prefixId.prefix "FeatureStructure"
    /// <summary>
    ///   <para>rdfs:comment : An utterance is divided into parts, which are assigned to word classes and then subclassified in terms of their "accidents" or properties. [Blevins 2006: 390] The properties, also referred to as features or categories, express what is shared by different linguistic elements, as opposed to what is idiosyncratic. [Kibort 2008d: 1]</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : FeatureSystem</para>
    ///   <a href="http://purl.org/linguistics/gold/FeatureSystem">gold:FeatureSystem</a>
    /// </summary>
    let FeatureSystem = _prefixId.prefix "FeatureSystem"
    /// <summary>
    ///   <para>rdfs:comment : A gender property established on the basis of agreement, to which nouns may be assigned if 1) they inherently denote females. Additionally, but not necessarily, nouns may be assigned this value if: 2) their formal properties (morphological or phonological) lead them to be assigned to the same agreement pattern as other nouns within the language that have female denotation. 3) they are arbitrarily assigned to the same agreement pattern as other nouns in the language that have female denotation. [Corbett 1991]</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : FeminineGender</para>
    ///   <a href="http://purl.org/linguistics/gold/FeminineGender">gold:FeminineGender</a>
    /// </summary>
    let FeminineGender = _prefixId.prefix "FeminineGender"
    /// <summary>
    ///   <para>rdfs:comment : First is a  person property that refers minimally to the speaker. It may also refer to the speaker combined with either the addressee or the non-participant or both, allowing for the following subdivisions: a) first person b) first person inclusive c) first person exclusive [Cysouw 2003].</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : FirstPerson</para>
    ///   <a href="http://purl.org/linguistics/gold/FirstPerson">gold:FirstPerson</a>
    /// </summary>
    let FirstPerson = _prefixId.prefix "FirstPerson"
    /// <summary>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : FirstPersonExclusive</para>
    ///   <a href="http://purl.org/linguistics/gold/FirstPersonExclusive">gold:FirstPersonExclusive</a>
    /// </summary>
    let FirstPersonExclusive = _prefixId.prefix "FirstPersonExclusive"
    /// <summary>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : FirstPersonInclusive</para>
    ///   <a href="http://purl.org/linguistics/gold/FirstPersonInclusive">gold:FirstPersonInclusive</a>
    /// </summary>
    let FirstPersonInclusive = _prefixId.prefix "FirstPersonInclusive"
    /// <summary>
    ///   <para>rdfs:comment : Blocks the patient or logical object (basic absolutive) nominal from being assigned Focus salience. Topic salience is available for assignment to various arguments, including the patient, but Focus salience is always assigned to agent, and is therefore inaccessible to the patient or any other nominal. [Klaiman 1991: 236] Dayley describes the focus antipassive as a rearranging voice whose primary function is to indicate that the agent of a transitive sentence is highlighted or in focus. The focus antipassive is used when the agent is in contrastive focus or highly emphatic, when the agent is questioned, and when the agent is relativized. [Dayley 1985: 348]</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : FocusAntipassiveVoice</para>
    ///   <a href="http://purl.org/linguistics/gold/FocusAntipassiveVoice">gold:FocusAntipassiveVoice</a>
    /// </summary>
    let FocusAntipassiveVoice = _prefixId.prefix "FocusAntipassiveVoice"
    /// <summary>
    ///   <para>rdfs:comment : FolkloreEvidentiality encodes the fact that the speaker came to believe the content of the expression through legend, folklore or some other established tradition [Palmer 2001: 40].</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : FolkloreEvidentiality</para>
    ///   <a href="http://purl.org/linguistics/gold/FolkloreEvidentiality">gold:FolkloreEvidentiality</a>
    /// </summary>
    let FolkloreEvidentiality = _prefixId.prefix "FolkloreEvidentiality"
    /// <summary>
    ///   <para>rdfs:comment : Used to describe the unit of rhythm in languages displaying isochrony, i.e. where the stressed syllables fall at approximately regular intervals throughout an utterance. It is an extension of the term used in traditional studies of metrical verse structure, where the many regular patterns of stressed/unstressed syllables were given a detailed classification. In a more general phonological sense, the notion is applied to any utterance in a stress-timed language, not just verse. [Crystal 1985: 123-124]</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : Foot</para>
    ///   <a href="http://purl.org/linguistics/gold/Foot">gold:Foot</a>
    /// </summary>
    let Foot = _prefixId.prefix "Foot"
    /// <summary>
    ///   <para>rdfs:comment : ForceProperty is the class of properties that concern the grammatical encoding of the speech act associated with a proposition. Among the traditionally defined values are Declarative, Imperative and Interrogative. Force is here distinguished from Mood, but there is a close association of Mood with Force values, e.g. between IndicativeMood and DeclarativeForce.</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : ForceProperty</para>
    ///   <a href="http://purl.org/linguistics/gold/ForceProperty">gold:ForceProperty</a>
    /// </summary>
    let ForceProperty = _prefixId.prefix "ForceProperty"
    /// <summary>
    ///   <para>rdfs:comment : Denotes the sensorily perceptible aspect of the linguistic sign. [Bussmann 1996: 169]</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : FormUnit</para>
    ///   <a href="http://purl.org/linguistics/gold/FormUnit">gold:FormUnit</a>
    /// </summary>
    let FormUnit = _prefixId.prefix "FormUnit"
    /// <summary>
    ///   <para>rdfs:comment : One more distinction can be made within both types of inherently assigned feature values: that between formal and semantic assignment. This distinction was proposed by Corbett (1991) to account for the criteria according to which nouns can be allotted to genders. Corbett demonstrates that gender assignment systems in languages can be semantic or semantic-and-formal – that is, the set of rules that determine the assignment of inherent gender values to nouns refer to the meaning of words, or a combination of the meaning of words and the form of words. [Kibort 2008d: 12]</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : FormalAssignmentSystem</para>
    ///   <a href="http://purl.org/linguistics/gold/FormalAssignmentSystem">gold:FormalAssignmentSystem</a>
    /// </summary>
    let FormalAssignmentSystem = _prefixId.prefix "FormalAssignmentSystem"
    /// <summary>
    ///   <para>rdfs:comment : A morpheme which can be used on its own as a word with a distinct meaning, as opposed to a bound morpheme. [Hartmann and Stork 1972: 88]</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : FreeMorpheme</para>
    ///   <a href="http://purl.org/linguistics/gold/FreeMorpheme">gold:FreeMorpheme</a>
    /// </summary>
    let FreeMorpheme = _prefixId.prefix "FreeMorpheme"
    /// <summary>
    ///   <para>rdfs:comment : Events which are frequently repeated, differs from habitual in that it can only be based upon the observation of several occurrences of the event concerned, whereas habitual can be based upon the observation of a single occurrence [Bhat 1999: 53].</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : FrequentiveAspect</para>
    ///   <a href="http://purl.org/linguistics/gold/FrequentiveAspect">gold:FrequentiveAspect</a>
    /// </summary>
    let FrequentiveAspect = _prefixId.prefix "FrequentiveAspect"
    /// <summary>
    ///   <para>rdfs:comment : Fricative sounds are those in which a turbulent airstream is produced within the vocal tract. [Ladefoged and Maddieson 1996: 137]</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : Fricative</para>
    ///   <a href="http://purl.org/linguistics/gold/Fricative">gold:Fricative</a>
    /// </summary>
    let Fricative = _prefixId.prefix "Fricative"
    /// <summary>
    ///   <para>rdfs:comment : The highest point of the tongue is in the front of the mouth. [Ladefoged 2000: 12]rdfs:comment : A sound made with the front part of the tongue, in the area of the hard palate. [Pei and Gaynor 1980: 78]</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : Front</para>
    ///   <a href="http://purl.org/linguistics/gold/Front">gold:Front</a>
    /// </summary>
    let Front = _prefixId.prefix "Front"
    /// <summary>
    ///   <para>rdfs:comment : Functor is the class of syntactic word whose members are neither relation- nor argument-like non-relational [Anderson 1997: 20]. Typical functors include adpositions, subordinators, and complementizers.</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : Functor</para>
    ///   <a href="http://purl.org/linguistics/gold/Functor">gold:Functor</a>
    /// </summary>
    let Functor = _prefixId.prefix "Functor"
    /// <summary>
    ///   <para>rdfs:comment : FutureInFutureTense locates the situation in question in the future, relative to a temporal reference point that itself is located in the future relative to the moment of utterance [Comrie 1985: 128].</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : FutureInFutureTense</para>
    ///   <a href="http://purl.org/linguistics/gold/FutureInFutureTense">gold:FutureInFutureTense</a>
    /// </summary>
    let FutureInFutureTense = _prefixId.prefix "FutureInFutureTense"
    /// <summary>
    ///   <para>rdfs:comment : FutureInPastTense locates the situation in question in the future, relative to a contextually determined temporal reference point that itself must be located in the past relative to the moment of utterance [Comrie 1985: 128].</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : FutureInPastTense</para>
    ///   <a href="http://purl.org/linguistics/gold/FutureInPastTense">gold:FutureInPastTense</a>
    /// </summary>
    let FutureInPastTense = _prefixId.prefix "FutureInPastTense"
    /// <summary>
    ///   <para>rdfs:comment : Describes an event that occurs after the time of speaking but before some reference point in time which also occurs after the time of speaking. This is also known as PastInFutureTense. [Comrie 1985: 126]</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : FuturePerfectTense</para>
    ///   <a href="http://purl.org/linguistics/gold/FuturePerfectTense">gold:FuturePerfectTense</a>
    /// </summary>
    let FuturePerfectTense = _prefixId.prefix "FuturePerfectTense"
    /// <summary>
    ///   <para>rdfs:comment : A value of Tense Property assigned to the designated element in the clause when the meaning selected for the clause is that intended to locate the event spoken about as posterior to the deictic centre of the utterance. Most commonly, this tense meaning is referred to as 'future', because in absolute tense systems the deictic centre is the moment of speech. However, in relative tense systems, where the deictic centre can be moved to any point on the time line, it is more appropriate to refer to this temporal relation as 'posterior'. The posterior temporal relation may obtain either in 'simple' or 'perfect' contexts. Modelling of this distinction originates from [Reichenbach 1947], who suggested using a third point in time, 'reference point', to capture all possible tense distinctions. In all 'simple' temporal relations, the reference point coincides with the location of the event spoken about. 'Perfect' tense meanings are created when the reference point is separated and moved away from the event time, thus altering the viewing of the temporal location of the event even though the event's actual location with respect to the deictic centre remains the same. Posterior temporal relationships obtaining in a 'perfect' context occur when the reference point is moved away from the event time. There are various logical possibilities for locating the reference point with respect to the other two points, though none of them seem to be typically grammaticalised as separate tenses. Typically, for a tense value to be labelled as Future Tense, the tense meaning has to minimally express the posterior temporal relationship, although it may additionally express other temporal, aspectual, or modal meanings. [Kibort 2008c: 5]</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : FutureTense</para>
    ///   <a href="http://purl.org/linguistics/gold/FutureTense">gold:FutureTense</a>
    /// </summary>
    let FutureTense = _prefixId.prefix "FutureTense"
    /// <summary>
    ///   <para>rdfs:comment : GenderProperty is the class of properties that are assigned to nouns on the basis of their inherent properties by an AssignmentSystem and required by the syntax to appear on the target in an AgreementSystem. Gender may but need not be assigned on the basis of sex [Corbett 1991].</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : GenderProperty</para>
    ///   <a href="http://purl.org/linguistics/gold/GenderProperty">gold:GenderProperty</a>
    /// </summary>
    let GenderProperty = _prefixId.prefix "GenderProperty"
    /// <summary>
    ///   <para>rdfs:comment : In some languages for which number is less dominant, the meaning of the noun can be expressed without reference to number. Nouns with this marking are designated as outside of the number system, as they are noncommittal as to the number of the noun that they mark. [Corbett 2000: 9-10]</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : GeneralNumber</para>
    ///   <a href="http://purl.org/linguistics/gold/GeneralNumber">gold:GeneralNumber</a>
    /// </summary>
    let GeneralNumber = _prefixId.prefix "GeneralNumber"
    /// <summary>
    ///   <para>rdfs:comment : GeneticTaxon is the class of all taxons whose members are based on genetic relatedness.</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : GeneticTaxon</para>
    ///   <a href="http://purl.org/linguistics/gold/GeneticTaxon">gold:GeneticTaxon</a>
    /// </summary>
    let GeneticTaxon = _prefixId.prefix "GeneticTaxon"
    /// <summary>
    ///   <para>rdfs:comment : GenitiveCase is used to mark the noun whose referent is the possessor of the referent of another noun [Crystal 1980: 161; Hartmann and Stork 1972: 94-95, 180; Pei and Gaynor 1954: 82, 172; Anderson 1985: 185; Fleming 1988: 10].</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : GenitiveCase</para>
    ///   <a href="http://purl.org/linguistics/gold/GenitiveCase">gold:GenitiveCase</a>
    /// </summary>
    let GenitiveCase = _prefixId.prefix "GenitiveCase"
    /// <summary>
    ///   <para>rdfs:comment : GeographicTaxon is the class of linguistic taxons whose instances are groupings based on where, in general, the language varieties are used, e.g., AustralianLanguage.</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : GeographicTaxon</para>
    ///   <a href="http://purl.org/linguistics/gold/GeographicTaxon">gold:GeographicTaxon</a>
    /// </summary>
    let GeographicTaxon = _prefixId.prefix "GeographicTaxon"
    /// <summary>
    ///   <para>rdfs:comment : A part of speech derived from a verb and used as a noun, usually restricted to non-finite forms of the verb [Crystal 1997: 279].</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : Gerund</para>
    ///   <a href="http://purl.org/linguistics/gold/Gerund">gold:Gerund</a>
    /// </summary>
    let Gerund = _prefixId.prefix "Gerund"
    /// <summary>
    ///   <para>rdfs:comment : A phonation type containing the features 'raising' and 'lowering'. [Ladefoged and Maddieson 1996: 372]</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : GlottalMovementProperty</para>
    ///   <a href="http://purl.org/linguistics/gold/GlottalMovementProperty">gold:GlottalMovementProperty</a>
    /// </summary>
    let GlottalMovementProperty = _prefixId.prefix "GlottalMovementProperty"
    /// <summary>
    ///   <para>rdfs:comment : The three phonation types are part of the five possible values of Glottal Stricture that are used by languages. Sounds can have the vocal cords tightly together, as in a glottal stop, or they can be far apart as in voiceless sounds, or they can have one of the three phonation types: breathy voice, modal voice and creaky voice. Although some phoneticians have shown how terms similar to these may be combinable from the phonetic point of view, the named terms form a set of phonologically mutually exclusive possibilities. These factors point to there being an ordered set of five possibilities: [voiceless], [breathy], [modal voice], [creaky] and [closed]. It is certainly appropriate to consider these glottal states as resulting from two physiological attributes of the vocal cords, their stiffness and their aperture. However from a linguistic point of view, the named values of the feature Glottal Stricture operate as a linearly ordered set of five mutually exclusive possibilities. [Ladefoged 1997: 607-608]</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : GlottalStrictureProperty</para>
    ///   <a href="http://purl.org/linguistics/gold/GlottalStrictureProperty">gold:GlottalStrictureProperty</a>
    /// </summary>
    let GlottalStrictureProperty = _prefixId.prefix "GlottalStrictureProperty"
    /// <summary>
    ///   <para>rdfs:comment : A phonation type containing the features 'aspirated' and 'unaspirated. Aspiration involves matters of relativing timing between laryngeal and oral articulations, and the wider opening can be viewed as an aspect of the control of this timing. There are two ways of interpreting this greather width; it can be seen as the essential aspect of the production of voiceless aspiration, that is, aspiration is an extra-wide opening of the vocal folds [Kim 1965], or it can be seen as a by-product of the mechanism by which a delay between the offset of the oral and glottal gestures is achieved, that is, aspiration is esentially a matter of the timing between speech movements controlling laryngeal setting and oral articulation [Goldstein and Browman 1986]. [Ladefoged and Maddieson 1996: 49-66; 372]</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : GlottalTimingProperty</para>
    ///   <a href="http://purl.org/linguistics/gold/GlottalTimingProperty">gold:GlottalTimingProperty</a>
    /// </summary>
    let GlottalTimingProperty = _prefixId.prefix "GlottalTimingProperty"
    /// <summary>
    ///   <para>rdfs:comment : A shape that is the visual representation of a character. It is a graphic object stored within a font. Glyphs are objects that are recognizably related to particular characters and which are dependent on particular design. Glyphs may or may not correspond to characters in a one-to-one manner. For example, a single character may correspond to multiple glyphs that have complementary distributions based upon context (e.g. final and non-final sigma in Greek), or several characters may correspond to a single glyph known as a ligature. [Lyons, et al. 2001]rdfs:comment : A Glyph is a symbol used in a writing system to represent some kind of linguistic unit, such as a single sound, a  phoneme or an entire word. Glyphs are concatenated in a writing system to form orthographic parts and orthographic words. Consider the printed word 'apple'. This word contains two instances of the 'p' glyph, which is a subclass of Glyph. Instances of a Glyph share a similar shape and can be called 'shapemes'. The class Glyph is not the same as Grapheme. A Grapheme is a contrastive unit within a particular writing system. The notion of a glyph is relevant across writing systems. For instance, consider the symbol 'р' used in a printed instance of a Russian word 'русский'. Now consider the symbol 'p' used in the printed instance of an English word 'pickle'. Both symbols are instances of the same Glyph. They share the same general shape, but do not have the same phonemic value.</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : Glyph</para>
    ///   <a href="http://purl.org/linguistics/gold/Glyph">gold:Glyph</a>
    /// </summary>
    let Glyph = _prefixId.prefix "Glyph"
    /// <summary>
    ///   <para>rdfs:comment : A GrammarUnit is the structural component of the linguistic sign and includes notions such as morpheme, syntactic word, and construction. Grammar units are classified according to their mereology (part-whole and complexity),  morphosyntactic function, and whether they exist in a bound or free forms.</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : GrammarUnit</para>
    ///   <a href="http://purl.org/linguistics/gold/GrammarUnit">gold:GrammarUnit</a>
    /// </summary>
    let GrammarUnit = _prefixId.prefix "GrammarUnit"
    /// <summary>
    ///   <para>rdfs:comment : Crystal defines a grapheme as the minimal contrastive unit in the writing system of a language; usually enclosed in angle brackets. The grapheme &lt;a&gt;, for example, is realized as several allographs A, a, a, etc., which may be seen as units in complementary distribution (e.g. upper case restricted to sentence-initial position, proper names, etc.), or in free variation (as in some styles of handwriting), just as in phonemic analysis. 'Grapheme Analysis' is the main business of graphemics (or graphology). [Crystal 2008: 220]rdfs:comment : A Grapheme is the smallest meaningful contrastive unit in a writing system. A grapheme is an abstraction over a set of like glyphs, the actual images on the  page. That is, a particular grapheme is realized by particular glyphs. More than one glyph can realize the same grapheme. For instance, the letter A  and its cursive equivalent are each realizations of the grapheme Latin Capital Letter A.</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : Grapheme</para>
    ///   <a href="http://purl.org/linguistics/gold/Grapheme">gold:Grapheme</a>
    /// </summary>
    let Grapheme = _prefixId.prefix "Grapheme"
    /// <summary>
    ///   <para>rdfs:comment : GreaterPaucal is a number property that quantifies the denotation of the nominal element so that it specifies that there are a small number of distinct entities, greater than paucalNumber but less than pluralNumber (semantically similar to 'several' in English).</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : GreaterPaucalNumber</para>
    ///   <a href="http://purl.org/linguistics/gold/GreaterPaucalNumber">gold:GreaterPaucalNumber</a>
    /// </summary>
    let GreaterPaucalNumber = _prefixId.prefix "GreaterPaucalNumber"
    /// <summary>
    ///   <para>rdfs:comment : GreaterPlural is a number property that expresses (a) the fact that there is an excessive number of events or entities denoted by the noun or nominal element, or (b) the fact that the noun or nominal denotes all possible instances. [Kibort and Corbett 2008b]</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : GreaterPluralNumber</para>
    ///   <a href="http://purl.org/linguistics/gold/GreaterPluralNumber">gold:GreaterPluralNumber</a>
    /// </summary>
    let GreaterPluralNumber = _prefixId.prefix "GreaterPluralNumber"
    /// <summary>
    ///   <para>rdfs:comment : A term used in Hallidayan grammar to refer to a unit on the rank scale intermediate between clause and word. For example, in the sentence 'The car was parked in the street', 'the car' is a nominal group, 'was parked' is a verbal group, and 'in the street' is an adverbial group. The term Phrase is an equivalent in most other approaches. [Crystal 2008: 22]</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : Group</para>
    ///   <a href="http://purl.org/linguistics/gold/Group">gold:Group</a>
    /// </summary>
    let Group = _prefixId.prefix "Group"
    /// <summary>
    ///   <para>rdfs:comment : A value of Aspect Property assigned to the designated element in the clause when the meaning selected for the clause is that which indicates that the situation spoken about is characteristic of an extended period of time -- so extended that the situation is viewed as characteristic of the whole period. The decision that a situation is characteristic of an extended period of time is not in itself linguistic, but once it has been made, an explicitly habitual form can be used to describe it. Note that the classification of a situation as characteristic of a period of time is not derived directly from the comparison of their length or frequency; hence, the situation may be objectively either long or short, and either frequent or infrequent, with respect to the period it characterises. This is because the way we choose to characterise can involve a component which is objectively small in relation to the whole.
    /// Typically, for an aspect value to be labelled as Habitual, the aspectual meaning has to minimally express habituality, although it may additionally express other temporal, aspectual, or modal meanings, or actionality distinctions. Habituality can in principle be combined with any other semantic aspectual values appropriate to situations that can be protracted in time or iterated [Comrie 1976: 26-32]. Since habituality is concerned with the internal temporal structure of the (extended) event, it can be regarded as a sub-type of imperfectivity. [Kibort 2008c: 7]</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : HabitualAspect</para>
    ///   <a href="http://purl.org/linguistics/gold/HabitualAspect">gold:HabitualAspect</a>
    /// </summary>
    let HabitualAspect = _prefixId.prefix "HabitualAspect"
    /// <summary>
    ///   <para>rdfs:comment : HearsayEvidentiality, also called third hand, encodes the fact that the speaker came to believe the content of the expression from a source generally considered less reliable than with a SecondHandEvidential [Palmer 2001: 40].</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : HearsayEvidentiality</para>
    ///   <a href="http://purl.org/linguistics/gold/HearsayEvidentiality">gold:HearsayEvidentiality</a>
    /// </summary>
    let HearsayEvidentiality = _prefixId.prefix "HearsayEvidentiality"
    /// <summary>
    ///   <para>rdfs:comment : The class of features describing sounds based on the relative vertical position of the tongue. Note, Ladefoged refers to this feature as High.</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : HeightProperty</para>
    ///   <a href="http://purl.org/linguistics/gold/HeightProperty">gold:HeightProperty</a>
    /// </summary>
    let HeightProperty = _prefixId.prefix "HeightProperty"
    /// <summary>
    ///   <para>rdfs:comment : HesternalPastTense locates the situation in question somewhere in the span beginning with the period defined culturally as 'yesterday' and extends back through some period that is considered nonremote [Comrie 1985: 87-88; Dahl 1985: 126].</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : HesternalPastTense</para>
    ///   <a href="http://purl.org/linguistics/gold/HesternalPastTense">gold:HesternalPastTense</a>
    /// </summary>
    let HesternalPastTense = _prefixId.prefix "HesternalPastTense"
    /// <summary>
    ///   <para>rdfs:comment : Description of the actual articulatory characteristics of vowels, and taken to specify the highest point of the tongue. In this view each vowel is characterized in terms of the distance of the highest point of the tongue from the roof of the mouth. [Ladefoged and Maddieson 1996: 282-285]</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : High</para>
    ///   <a href="http://purl.org/linguistics/gold/High">gold:High</a>
    /// </summary>
    let High = _prefixId.prefix "High"
    /// <summary>
    ///   <para>rdfs:comment : HodiernalFutureTense locates the situation in question after the moment of utterance within the span culturally defined as 'today' [Comrie 1985: 86; Bybee, Perkins and Pagliuca 1994: 247].</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : HodiernalFutureTense</para>
    ///   <a href="http://purl.org/linguistics/gold/HodiernalFutureTense">gold:HodiernalFutureTense</a>
    /// </summary>
    let HodiernalFutureTense = _prefixId.prefix "HodiernalFutureTense"
    /// <summary>
    ///   <para>rdfs:comment : HodiernalPastTense locates the situation in question before the moment of utterance within the span culturally defined as 'today' [Comrie 1985: 87; Dahl 1985: 125-126]. Contrasts with PreHodiernalPastTense.</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : HodiernalPastTense</para>
    ///   <a href="http://purl.org/linguistics/gold/HodiernalPastTense">gold:HodiernalPastTense</a>
    /// </summary>
    let HodiernalPastTense = _prefixId.prefix "HodiernalPastTense"
    /// <summary>
    ///   <para>rdfs:comment : A term sometimes used in the grammatical analysis of verbs, to refer to a type of modal meaning in which an exhortation is made. An example of a hortative usage ('a hortative') is the 'let us' construction in English ('let us pray'). [Crystal 2008: 232]</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : HortatoryForce</para>
    ///   <a href="http://purl.org/linguistics/gold/HortatoryForce">gold:HortatoryForce</a>
    /// </summary>
    let HortatoryForce = _prefixId.prefix "HortatoryForce"
    /// <summary>
    ///   <para>rdfs:comment : A grammatical category used for analysis of word-classes displaying such contrasts as masculine/feminine/neuter, animate/inanimate, etc. It is also important to distinguish natural gender, items referring to the sex of real-world entities, and grammatical gender, which does not always correspond to sex, but which has an important role in signaling grammatical relations between words in a sentence. [Crystal 1985: 133]</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : HumanGender</para>
    ///   <a href="http://purl.org/linguistics/gold/HumanGender">gold:HumanGender</a>
    /// </summary>
    let HumanGender = _prefixId.prefix "HumanGender"
    /// <summary>
    ///   <para>rdfs:comment : A term used in sociolinguistics and stylistics to refer to any system of linguistic expression whose use is governed by situational variables. In some cases, the situational distinctiveness of the language may be easily stated, as in many regional and occupational varieties; in other cases, as in studies of social class, the varieties are more difficult to define, involving the intersection of several variables. [Crystal 1997: 408]</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : HumanLanguageVariety</para>
    ///   <a href="http://purl.org/linguistics/gold/HumanLanguageVariety">gold:HumanLanguageVariety</a>
    /// </summary>
    let HumanLanguageVariety = _prefixId.prefix "HumanLanguageVariety"
    /// <summary>
    ///   <para>rdfs:comment : IllativeCase expresses that  the referent of the noun it marks is the location into which another referent is moving. It has the meaning 'into' [Lyons 1968: 299; Crystal 1985: 152].</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : IllativeCase</para>
    ///   <a href="http://purl.org/linguistics/gold/IllativeCase">gold:IllativeCase</a>
    /// </summary>
    let IllativeCase = _prefixId.prefix "IllativeCase"
    /// <summary>
    ///   <para>rdfs:comment : ImmediateFutureTense, also called 'close future', locates the situation in question shortly after the moment of utterance [Dahl 1985: 121; Comrie 1985: 94; Bybee, Perkins and Pagliuca 1994: 244-245].</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : ImmediateFutureTense</para>
    ///   <a href="http://purl.org/linguistics/gold/ImmediateFutureTense">gold:ImmediateFutureTense</a>
    /// </summary>
    let ImmediateFutureTense = _prefixId.prefix "ImmediateFutureTense"
    /// <summary>
    ///   <para>rdfs:comment : ImmediatePastTense locates the situation in question at a time considered very recent in relation to the moment of utterance [Comrie 1985: 87].</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : ImmediatePastTense</para>
    ///   <a href="http://purl.org/linguistics/gold/ImmediatePastTense">gold:ImmediatePastTense</a>
    /// </summary>
    let ImmediatePastTense = _prefixId.prefix "ImmediatePastTense"
    /// <summary>
    ///   <para>rdfs:comment : A term used in the grammatical classification of sentence types, and usually seen in contrast to indicative, interrogative, etc. An imperative usage (‘an imperative’) refers to verb forms or sentence/clause types typically used in the expression of commands, e.g. 'Go away!' [Crystal 2008: 23]</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : ImperativeForce</para>
    ///   <a href="http://purl.org/linguistics/gold/ImperativeForce">gold:ImperativeForce</a>
    /// </summary>
    let ImperativeForce = _prefixId.prefix "ImperativeForce"
    /// <summary>
    ///   <para>rdfs:comment : A value of Aspect Property assigned to the designated element in the clause when the meaning selected for the clause is that which indicates that the event spoken about is to be looked at from inside, from within its temporal boundaries; imperfective aspect is crucially concerned with the internal temporal structure of the event [Comrie 1976: 16ff].
    ///
    /// Typically, for an aspect value to be labelled as Imperfective, the aspectual meaning has to minimally express the imperfective viewpoint, although it may additionally express other temporal, aspectual, or modal meanings, or actionality distinctions.
    ///
    /// Imperfective aspectual meaning can be further subdivided into two types: habitual meaning and continuous meaning. These two aspectual meanings may or may not be grammaticalised as separate aspect values. [Kibort 2008c: 7]</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : ImperfectiveAspect</para>
    ///   <a href="http://purl.org/linguistics/gold/ImperfectiveAspect">gold:ImperfectiveAspect</a>
    /// </summary>
    let ImperfectiveAspect = _prefixId.prefix "ImperfectiveAspect"
    /// <summary>
    ///   <para>rdfs:comment : A Passive that alters the mapping of a nominal to the Subject relation in a basic intransitive structure [Klaiman 1991: 23].</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : ImpersonalPassiveVoice</para>
    ///   <a href="http://purl.org/linguistics/gold/ImpersonalPassiveVoice">gold:ImpersonalPassiveVoice</a>
    /// </summary>
    let ImpersonalPassiveVoice = _prefixId.prefix "ImpersonalPassiveVoice"
    /// <summary>
    ///   <para>rdfs:comment : InablativeCase expresses that  the referent of the noun it marks is the location from within which another referent is moving. It has the meaning 'from within'. Kibrik says that Archi (aqc) possesses a nominal spatial form expressing InablativeCase, namely -aš. He gives the example 'aInš-l-a-š' ('aIns' = 'apple'). [Kibrik 1998: 470-471]</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : InablativeCase</para>
    ///   <a href="http://purl.org/linguistics/gold/InablativeCase">gold:InablativeCase</a>
    /// </summary>
    let InablativeCase = _prefixId.prefix "InablativeCase"
    /// <summary>
    ///   <para>rdfs:comment : InallativeCase expresses that  something is moving toward the region that is inside the referent of the noun it marks. It has the meaning 'towards in(side)'. Kibrik says that Archi (aqc) possesses a nominal spatial form expressing InallativeCase, namely -aši [Kibrik 1998: 470].</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : InallativeCase</para>
    ///   <a href="http://purl.org/linguistics/gold/InallativeCase">gold:InallativeCase</a>
    /// </summary>
    let InallativeCase = _prefixId.prefix "InallativeCase"
    /// <summary>
    ///   <para>rdfs:comment : A grammatical gender property such that membership in the inanimate grammatical class is largely based on meaning, in that non-living things, such as objects of manufacture and natural 'non-living' things are included in it. For example, one of the two grammatical genders, or noun classes, of Nishnaabemwin, the other being animate [Valentine 2001: 114].</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : InanimateGender</para>
    ///   <a href="http://purl.org/linguistics/gold/InanimateGender">gold:InanimateGender</a>
    /// </summary>
    let InanimateGender = _prefixId.prefix "InanimateGender"
    /// <summary>
    ///   <para>rdfs:comment : InceptiveAspect, also called the ingressive, encodes the beginning portion of some event [Bybee 1985: 147, 149; Payne 1997: 240; Bhat 1999: 176].</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : InceptiveAspect</para>
    ///   <a href="http://purl.org/linguistics/gold/InceptiveAspect">gold:InceptiveAspect</a>
    /// </summary>
    let InceptiveAspect = _prefixId.prefix "InceptiveAspect"
    /// <summary>
    ///   <para>rdfs:comment : Blocks the patient or logical object (basic absolutive) nominal from being assigned Focus salience. There is no explicit case marking on the patient, and the patient is invariably nonreferential. This correlates with the patient's morphosyntactic downgrading, whereby it becomes insusceptible to any informational salience assignment. [Klaiman 1991: 232-236]</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : IncorporatingAntipassiveVoice</para>
    ///   <a href="http://purl.org/linguistics/gold/IncorporatingAntipassiveVoice">gold:IncorporatingAntipassiveVoice</a>
    /// </summary>
    let IncorporatingAntipassiveVoice = _prefixId.prefix "IncorporatingAntipassiveVoice"
    /// <summary>
    ///   <para>rdfs:comment : An article is a part of speech whose members are used to refer to an entity (or class of entities) which is not capable of specific identification [Crystal 1997: 193].</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : IndefiniteArticle</para>
    ///   <a href="http://purl.org/linguistics/gold/IndefiniteArticle">gold:IndefiniteArticle</a>
    /// </summary>
    let IndefiniteArticle = _prefixId.prefix "IndefiniteArticle"
    /// <summary>
    ///   <para>rdfs:comment : An indefinite pronoun is a pronoun that belongs to a class whose members indicate  indefinite reference [Crystal 1997: 312].</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : IndefinitePronoun</para>
    ///   <a href="http://purl.org/linguistics/gold/IndefinitePronoun">gold:IndefinitePronoun</a>
    /// </summary>
    let IndefinitePronoun = _prefixId.prefix "IndefinitePronoun"
    /// <summary>
    ///   <para>rdfs:comment : A term used in the grammatical classification of sentence types, and usually seen in contrast to imperative, subjunctive, etc., moods. It refers to verb forms or sentence/clause types used in the expression of statements and questions, e.g. the horse is walking. With reference to statements, the term ‘declarative’ may be used. [Crystal 2008: 242]</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : IndicativeMood</para>
    ///   <a href="http://purl.org/linguistics/gold/IndicativeMood">gold:IndicativeMood</a>
    /// </summary>
    let IndicativeMood = _prefixId.prefix "IndicativeMood"
    /// <summary>
    ///   <para>rdfs:comment : IndirectEvidentiality, also called reported, encodes the fact that the speaker came to believe the content of the expression from a source other than by experiencing the situation directly [Palmer 2001: 40].</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : IndirectEvidentiality</para>
    ///   <a href="http://purl.org/linguistics/gold/IndirectEvidentiality">gold:IndirectEvidentiality</a>
    /// </summary>
    let IndirectEvidentiality = _prefixId.prefix "IndirectEvidentiality"
    /// <summary>
    ///   <para>rdfs:comment : InessiveCase expresses that the referent of the noun it marks is the location within which another referent exists. It has the meaning of 'within' or 'inside' [Lyons 1968: 299; Crystal 1985: 156]. X in Y.</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : InessiveCase</para>
    ///   <a href="http://purl.org/linguistics/gold/InessiveCase">gold:InessiveCase</a>
    /// </summary>
    let InessiveCase = _prefixId.prefix "InessiveCase"
    /// <summary>
    ///   <para>rdfs:comment : InferentialEvidentiality encodes the fact that the speaker came to believe the content of the expression through some kind of internal inference procedure, e.g., deduction, abduction, induction [Palmer 2001: 6-8].</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : InferentialEvidentiality</para>
    ///   <a href="http://purl.org/linguistics/gold/InferentialEvidentiality">gold:InferentialEvidentiality</a>
    /// </summary>
    let InferentialEvidentiality = _prefixId.prefix "InferentialEvidentiality"
    /// <summary>
    ///   <para>rdfs:comment : A term used in morphology referring to an affix which is added within a root or stem. [Crystal 1985: 157]</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : Infix</para>
    ///   <a href="http://purl.org/linguistics/gold/Infix">gold:Infix</a>
    /// </summary>
    let Infix = _prefixId.prefix "Infix"
    /// <summary>
    ///   <para>rdfs:comment : InflectionalUnit is the class of functional units whose members designate such grammatical categories as tense, aspect, mood etc. The various forms of an InflectionalUnit plus the stem forms a grammatical paradigm and express a grammatical contrast that is obligatory for its stem's part of speech in some given grammatical context. An inflectional unit does not alter the part of speech feature of the root or stem it attaches to. It is typically located farther from its Root than a derivational unit and  produces a predictable, nonidiosyncratic change of meaning [Crystal 1980: 184; Hartmann and Stork 1972: 112; Bybee 1985: 2, 99].</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : InflectionalMorpheme</para>
    ///   <a href="http://purl.org/linguistics/gold/InflectionalMorpheme">gold:InflectionalMorpheme</a>
    /// </summary>
    let InflectionalMorpheme = _prefixId.prefix "InflectionalMorpheme"
    /// <summary>
    ///   <para>rdfs:comment : InformationalForce indicates that the hearer is to relate to the informational content of what is expressed. Informational force subsumes Declarative, Speculative and Interrogative force.</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : InformationalForce</para>
    ///   <a href="http://purl.org/linguistics/gold/InformationalForce">gold:InformationalForce</a>
    /// </summary>
    let InformationalForce = _prefixId.prefix "InformationalForce"
    /// <summary>
    ///   <para>rdfs:comment : InstrumentalCase indicates that the referent of the noun it marks is the means of the accomplishment of the action expressed by the clause [Crystal 1980: 187; Hartmann and Stork 1972: 114].</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : InstrumentalCase</para>
    ///   <a href="http://purl.org/linguistics/gold/InstrumentalCase">gold:InstrumentalCase</a>
    /// </summary>
    let InstrumentalCase = _prefixId.prefix "InstrumentalCase"
    /// <summary>
    ///   <para>rdfs:comment : InterablativeCase expresses that  the referent of the noun it marks is the location from between which another referent is moving. It has the meaning 'from in between'. Kibrik says that Archi (aqc) possesses a nominal spatial form expressing InterablativeCase, namely -qIaš [Kibrik 1998: 470].</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : InterablativeCase</para>
    ///   <a href="http://purl.org/linguistics/gold/InterablativeCase">gold:InterablativeCase</a>
    /// </summary>
    let InterablativeCase = _prefixId.prefix "InterablativeCase"
    /// <summary>
    ///   <para>rdfs:comment : InterallativeCase expresses that something is moving toward the region that is in the middle of the referent of the noun it marks. It has the meaning  'towards the middle of'. Kibrik says that Archi (aqc) possesses a nominal spatial form expressing InterallativeCase, namely -qIaši [Kibrik 1998: 470].</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : InterallativeCase</para>
    ///   <a href="http://purl.org/linguistics/gold/InterallativeCase">gold:InterallativeCase</a>
    /// </summary>
    let InterallativeCase = _prefixId.prefix "InterallativeCase"
    /// <summary>
    ///   <para>rdfs:comment : InteressiveCase expresses that  the referent of the noun it marks is the location between which another referent exists. It has the meaning of 'between'. Kibrik says that Archi (aqc) possesses a nominal spatial form expressing InteressiveCase, namely -qI [Kibrik 1998: 470].</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : InteressiveCase</para>
    ///   <a href="http://purl.org/linguistics/gold/InteressiveCase">gold:InteressiveCase</a>
    /// </summary>
    let InteressiveCase = _prefixId.prefix "InteressiveCase"
    /// <summary>
    ///   <para>rdfs:comment : An interjection is a part of speech, typically brief in form, such as one syllable or word, whose members are used most often as exclamations or parts of an exclamation. An interjection, typically expressing an emotional reaction, often with respect to an accompanying sentence, is not syntactically related to other accompanying expressions, and may include a combination of sounds not otherwise found in the language [Crystal 1997: 200].</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : Interjection</para>
    ///   <a href="http://purl.org/linguistics/gold/Interjection">gold:Interjection</a>
    /// </summary>
    let Interjection = _prefixId.prefix "Interjection"
    /// <summary>
    ///   <para>rdfs:comment : InterlativeCase expresses that  the referent of the noun it marks is the location between which another referent is moving. It has the meaning 'to the middle of'. Kibrik says that Archi (aqc) possesses a nominal spatial form expressing InterlativeCase, namely -qIak [Kibrik 1998: 470].</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : InterlativeCase</para>
    ///   <a href="http://purl.org/linguistics/gold/InterlativeCase">gold:InterlativeCase</a>
    /// </summary>
    let InterlativeCase = _prefixId.prefix "InterlativeCase"
    /// <summary>
    ///   <para>rdfs:comment : Interlinear glossed text (IGT) is a linguistic data structure meant to display morphosyntactic structure: morphemes, morpheme boundaries, morpheme types (clitics, prefixes, reduplicated forms), morphosyntactic features/values and part of speech information. At a minimum, an instance of IGT includes a single line of source language followed by a translation line. Often, a second gloss line is included to show detailed morphosyntactic structure using both words and phrases from the target language and various labels, or 'grams', that indicate morphosyntactic features/values, etc. It is possible to include separate lines for the orthographic form, phonetic form, and phonological form. Standards for IGT include the Leipzig Glossing Rules.</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : InterlinearGlossedText</para>
    ///   <a href="http://purl.org/linguistics/gold/InterlinearGlossedText">gold:InterlinearGlossedText</a>
    /// </summary>
    let InterlinearGlossedText = _prefixId.prefix "InterlinearGlossedText"
    /// <summary>
    ///   <para>rdfs:comment : Expresses the notion of something moving into the inside of a reference of the noun it marks. It has the meaning 'into the inside of'. Kibrik says that Archi (aqc) possesses a nominal spatial form expressing InterminativeCase, namely -akana [Kibrik 1998: 470].</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : InterminativeCase</para>
    ///   <a href="http://purl.org/linguistics/gold/InterminativeCase">gold:InterminativeCase</a>
    /// </summary>
    let InterminativeCase = _prefixId.prefix "InterminativeCase"
    /// <summary>
    ///   <para>rdfs:comment : A term used in the grammatical classification of sentence types, and usually seen in contrast to declarative. It refers to verb forms or sentence/clause types typically used in the expression of questions, e.g. the inverted order of 'is he coming?' or the use of an interrogative word (or simple ‘interrogative’), often subclassified as interrogative adjectives (e.g. which), adverbs (e.g. why) and pronouns (e.g. who). [Crystal 2008: 245]</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : InterrogativeForce</para>
    ///   <a href="http://purl.org/linguistics/gold/InterrogativeForce">gold:InterrogativeForce</a>
    /// </summary>
    let InterrogativeForce = _prefixId.prefix "InterrogativeForce"
    /// <summary>
    ///   <para>rdfs:comment : Also referred to as a 'question particle', an interrogative operator is a category whose members signal a yes/no question [Payne 1997: 296].</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : InterrogativeOperator</para>
    ///   <a href="http://purl.org/linguistics/gold/InterrogativeOperator">gold:InterrogativeOperator</a>
    /// </summary>
    let InterrogativeOperator = _prefixId.prefix "InterrogativeOperator"
    /// <summary>
    ///   <para>rdfs:comment : An InterrogativeProform is a Proform that is used in questions to stand for the item questioned. [Schachter 1985: 34]</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : InterrogativeProform</para>
    ///   <a href="http://purl.org/linguistics/gold/InterrogativeProform">gold:InterrogativeProform</a>
    /// </summary>
    let InterrogativeProform = _prefixId.prefix "InterrogativeProform"
    /// <summary>
    ///   <para>rdfs:comment : InterterminativeCase expresses the notion of something moving into the middle of the referent of the noun it marks, but not through it. It has the meaning 'into the middle of'. Kibrik says that Archi (aqc) possesses a nominal spatial form expressing InterterminativeCase, namely -qIakana [Kibrik 1998: 470].</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : InterterminativeCase</para>
    ///   <a href="http://purl.org/linguistics/gold/InterterminativeCase">gold:InterterminativeCase</a>
    /// </summary>
    let InterterminativeCase = _prefixId.prefix "InterterminativeCase"
    /// <summary>
    ///   <para>rdfs:comment : IntertranslativeCase expresses the notion of something moving along a trajectory between the referent of the noun it marks. It has the meaning 'along the in between'. Kibrik says that Archi (aqc) possesses a nominal spatial form expressing IntertranslativeCase, namely -qIaXut [Kibrik 1998: 470].</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : IntertranslativeCase</para>
    ///   <a href="http://purl.org/linguistics/gold/IntertranslativeCase">gold:IntertranslativeCase</a>
    /// </summary>
    let IntertranslativeCase = _prefixId.prefix "IntertranslativeCase"
    /// <summary>
    ///   <para>rdfs:comment : An intransitive verb is a verb that cannot take a direct object, and describes a property, state, or situation involving only one participant [Crystal 1997: 397; Payne 1997: 171].</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : IntransitiveVerb</para>
    ///   <a href="http://purl.org/linguistics/gold/IntransitiveVerb">gold:IntransitiveVerb</a>
    /// </summary>
    let IntransitiveVerb = _prefixId.prefix "IntransitiveVerb"
    /// <summary>
    ///   <para>rdfs:comment : A derivational unit that derives an intransitive verb from a transitive verb. [Hornby 2010 (p.c.)]</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : Intransitivizer</para>
    ///   <a href="http://purl.org/linguistics/gold/Intransitivizer">gold:Intransitivizer</a>
    /// </summary>
    let Intransitivizer = _prefixId.prefix "Intransitivizer"
    /// <summary>
    ///   <para>rdfs:comment : IntranslativeCase expresses the notion of something moving through the referent of the noun it marks. It has the meaning 'along through'. Kibrik says that Archi (aqc) possesses a nominal spatial form expressing IntranslativeCase, namely -aXut [Kibrik 1998: 470].</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : IntranslativeCase</para>
    ///   <a href="http://purl.org/linguistics/gold/IntranslativeCase">gold:IntranslativeCase</a>
    /// </summary>
    let IntranslativeCase = _prefixId.prefix "IntranslativeCase"
    /// <summary>
    ///   <para>rdfs:comment : Signals when actions proceed from ontologically less salient to more salient participants. [Klaiman 1991: 32]</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : InverseVoice</para>
    ///   <a href="http://purl.org/linguistics/gold/InverseVoice">gold:InverseVoice</a>
    /// </summary>
    let InverseVoice = _prefixId.prefix "InverseVoice"
    /// <summary>
    ///   <para>rdfs:comment : Where the proposition is weakly asserted to be true, but the speaker is not ready to support the assertion. Irrealis adverbs include 'maybe' and 'hopefully'. [Crystal 2008: 403]</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : IrrealisMood</para>
    ///   <a href="http://purl.org/linguistics/gold/IrrealisMood">gold:IrrealisMood</a>
    /// </summary>
    let IrrealisMood = _prefixId.prefix "IrrealisMood"
    /// <summary>
    ///   <para>rdfs:comment : Isolate is the class of human language varieties such that there are no other varieties that are genetically related.</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : Isolate</para>
    ///   <a href="http://purl.org/linguistics/gold/Isolate">gold:Isolate</a>
    /// </summary>
    let Isolate = _prefixId.prefix "Isolate"
    /// <summary>
    ///   <para>rdfs:comment : IterativeAspect, also called repetitive, encodes a number of events of the same type that are repeated on a particular occasion. The time interval which is relevant to the iterative is relatively shorter than in the case of the habitual [Bybee 1985: 150; Bybee, Perkins and Pagliuca 1994: 127]. Portrays events repeated on the same occasion (like the iterative knocking on the door) [Bhat 1999: 53].</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : IterativeAspect</para>
    ///   <a href="http://purl.org/linguistics/gold/IterativeAspect">gold:IterativeAspect</a>
    /// </summary>
    let IterativeAspect = _prefixId.prefix "IterativeAspect"
    /// <summary>
    ///   <para>rdfs:comment : The jussive has syntactic force and is directive in that it signals a speaker's command, permission, or agreement that the proposition expressed by his or her utterance be brought about. The jussive is typically applicable in the first and third person. [Chung and Timberlake 1985: 247; Pei and Gaynor 1954: 110; Palmer 1986: 10, 24, 39-40, 96, 110, 113, Schade 2005: 52]</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : JussiveForce</para>
    ///   <a href="http://purl.org/linguistics/gold/JussiveForce">gold:JussiveForce</a>
    /// </summary>
    let JussiveForce = _prefixId.prefix "JussiveForce"
    /// <summary>
    ///   <para>rdfs:comment : Gestures involving the lips are said to be Labial. From the linguistic point of view the places of articulation can usefully be classified into a smaller number of groups based on the articulators they share. If consonants in which either the upper or lower lip is involved as an articulator are classified as Labials then there are three place classes among Labial sounds: the lower lip can articulate with the upper lip (bilabial), or the upper teeth (labiodentals)l and,  the upper lip can also be the target for the tongue (linguo-labial). [Ladefoged and Maddieson 1996: 10; 15-15]</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : LabialProperty</para>
    ///   <a href="http://purl.org/linguistics/gold/LabialProperty">gold:LabialProperty</a>
    /// </summary>
    let LabialProperty = _prefixId.prefix "LabialProperty"
    /// <summary>
    ///   <para>rdfs:comment : Characterizing sounds produced by the blade of the tongue  [Ladefoged 1997: 596].</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : Laminal</para>
    ///   <a href="http://purl.org/linguistics/gold/Laminal">gold:Laminal</a>
    /// </summary>
    let Laminal = _prefixId.prefix "Laminal"
    /// <summary>
    ///   <para>rdfs:comment : The most fundamental means of human communication. Language is a purely human activity, although some animals have communication systems which have certain analogies to human language. All human beings use language to interact with other members of the same speech community. Language is not only used as an instrument of communication, however, but also as a means of individual expression. Language is not instinctive; it has to be learnt as a system of arbitrary conventional symbols. Such symbols are primarily vocal, produced by the so-called organs of speech, but secondary systems such as writing and other codes may complement the vocalsystem. Some linguists, such as F. de Saussure, have stressed the view of language as general patterns in the speech of a community and as the speaking activity of an individual in a particular situation; others, with N.Chomsky, regard language as the innate capability of native speakers to understand and form grammatical sentences as as the actual utterances produced at a given time. [Hartmann and Stork 1972: 123-124]</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : Language</para>
    ///   <a href="http://purl.org/linguistics/gold/Language">gold:Language</a>
    /// </summary>
    let Language = _prefixId.prefix "Language"
    /// <summary>
    ///   <para>rdfs:comment : Group of languages that are genetically related, i.e can be traced to a common proto-language. The ordering of languages into a common language family is usually based on phonological, morphological, and lexical correspondences that stem from the proto-language. ... it refers to the largest spectrum of languages for which a genetic relationship can be demonstrated. [Bussmann 1996: 262]</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : LanguageFamily</para>
    ///   <a href="http://purl.org/linguistics/gold/LanguageFamily">gold:LanguageFamily</a>
    /// </summary>
    let LanguageFamily = _prefixId.prefix "LanguageFamily"
    /// <summary>
    ///   <para>rdfs:comment : A term used for postulated but undemonstrated higher-order, more inclusive families (proposed but as yet unproven distant genetic relationships). [Campbell 1999: 187]</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : LanguageStock</para>
    ///   <a href="http://purl.org/linguistics/gold/LanguageStock">gold:LanguageStock</a>
    /// </summary>
    let LanguageStock = _prefixId.prefix "LanguageStock"
    /// <summary>
    ///   <para>rdfs:comment : LanguageSubfamily (also called subgroup or branch) refers 'to a group of languages within a language family which are more closely related to each other than to other languages of that family.' [Campbell 1999: 187]</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : LanguageSubfamily</para>
    ///   <a href="http://purl.org/linguistics/gold/LanguageSubfamily">gold:LanguageSubfamily</a>
    /// </summary>
    let LanguageSubfamily = _prefixId.prefix "LanguageSubfamily"
    /// <summary>
    ///   <para>rdfs:comment : The laryngeal setting refers to differences in the timing of laryngeal activity in relation to oral articulation. Most languages have phonemic contrasts between classes of stops which differ in the mode of action of the larynx, or in the timing of laryngeal activity. [Ladefoged and Maddieson 1996: 47]</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : LaryngealProperty</para>
    ///   <a href="http://purl.org/linguistics/gold/LaryngealProperty">gold:LaryngealProperty</a>
    /// </summary>
    let LaryngealProperty = _prefixId.prefix "LaryngealProperty"
    /// <summary>
    ///   <para>rdfs:comment : Characterizing sounds produced with a release of air through the sides of the mouth. (Note, [Ladefoged 1997] refers to this as lateral.)</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : LateralEscape</para>
    ///   <a href="http://purl.org/linguistics/gold/LateralEscape">gold:LateralEscape</a>
    /// </summary>
    let LateralEscape = _prefixId.prefix "LateralEscape"
    /// <summary>
    ///   <para>rdfs:comment : Obstruction of the airstream at a point along the center of the oral tract, with complete closure between one or both sides of the tongue and the roof of the mouth. [Ladefoged 2000: 11]</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : LateralProperty</para>
    ///   <a href="http://purl.org/linguistics/gold/LateralProperty">gold:LateralProperty</a>
    /// </summary>
    let LateralProperty = _prefixId.prefix "LateralProperty"
    /// <summary>
    ///   <para>rdfs:comment : LativeCase expresses 'motion up to the location of,' or 'as far as' the referent of the noun it marks [Pei and Gaynor 1954: 121].</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : LativeCase</para>
    ///   <a href="http://purl.org/linguistics/gold/LativeCase">gold:LativeCase</a>
    /// </summary>
    let LativeCase = _prefixId.prefix "LativeCase"
    /// <summary>
    ///   <para>rdfs:comment : A unit of the vocabulary of a language such as a word, phrase or term as listed in a dictionary. It usually has a pronounceable or graphic form, fulfils a grammatical role in a sentence, and carries semantic meaning. [Hartmann and Stork 1972: 128]</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : LexicalItem</para>
    ///   <a href="http://purl.org/linguistics/gold/LexicalItem">gold:LexicalItem</a>
    /// </summary>
    let LexicalItem = _prefixId.prefix "LexicalItem"
    /// <summary>
    ///   <para>rdfs:comment : Grammatical or semantic category expressed by a lexical item, e.g. English 'make' + 'dead' together are lexicalized as 'kill', in German 'tot' + 'machen' &gt; 'töten', or the close linking of lexical items in an idiomatic phrase. [Hartmann and Stork 1972: 129]</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : LexicalizedConcept</para>
    ///   <a href="http://purl.org/linguistics/gold/LexicalizedConcept">gold:LexicalizedConcept</a>
    /// </summary>
    let LexicalizedConcept = _prefixId.prefix "LexicalizedConcept"
    /// <summary>
    ///   <para>rdfs:comment : In its most general sense, the term is synonymous with vocabulary. A dictionary can be seen as a set of lexical entries. The lexicon has a special status in generative grammar, where it refers to the component containing all the information about the structural properties of the lexical items in a language. [Crystal 2008: 278] In linguistics, ... we don't normally speak of the vocabulary of a particular language; instead, we speak of the lexicon, the total store of words available to a speaker. Very commonly, the lexicon is not regarded merely as a long list of words. Rather, we conceive the lexicon as a set of lexical resources, including the morphemes of the languages, plus the processes available in the language for constructing words from those resources. Apart from the lexicon of a language as a whole, psycholinguists are interested in the mental lexicon, the words and lexical resources stored in an individual brain. [Trask 1999: 166-167]</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : Lexicon</para>
    ///   <a href="http://purl.org/linguistics/gold/Lexicon">gold:Lexicon</a>
    /// </summary>
    let Lexicon = _prefixId.prefix "Lexicon"
    /// <summary>
    ///   <para>rdfs:comment : The merging of two or more letters (often for aesthetic reasons) from which a single, independent form is derived. [Bussmann 1996: 281]</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : Ligature</para>
    ///   <a href="http://purl.org/linguistics/gold/Ligature">gold:Ligature</a>
    /// </summary>
    let Ligature = _prefixId.prefix "Ligature"
    /// <summary>
    ///   <para>rdfs:comment : A linguistic data structure is an abstract container for grouping together instances of linguistic data, usually to suit a particular theory or computational implementation. Examples include: feature structures, lexical entries, and paradigms.</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : LinguisticDataStructure</para>
    ///   <a href="http://purl.org/linguistics/gold/LinguisticDataStructure">gold:LinguisticDataStructure</a>
    /// </summary>
    let LinguisticDataStructure = _prefixId.prefix "LinguisticDataStructure"
    /// <summary>
    ///   <para>rdfs:comment : A LinguisticExpression is any physical form (sound, visual image or sequence thereof) used to represent a linguistic unit. A linguistic expression may be spoken, written, or signed. A linguistic expression is distinct form the actual process (speaking, writing, signing) that produces the expression.</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : LinguisticExpression</para>
    ///   <a href="http://purl.org/linguistics/gold/LinguisticExpression">gold:LinguisticExpression</a>
    /// </summary>
    let LinguisticExpression = _prefixId.prefix "LinguisticExpression"
    /// <summary>
    ///   <para>rdfs:comment : LinguisticProperty is the class  of properties that pertain to linguistic units. A unit's properties determine its behavior  in a grammatical system. Specific kinds of properties are relevant to certain types of units. In some language, for example, tense properties may be relevant for verbs. See also Feature and FeatureValue for the corresponding data structure for properties.</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : LinguisticProperty</para>
    ///   <a href="http://purl.org/linguistics/gold/LinguisticProperty">gold:LinguisticProperty</a>
    /// </summary>
    let LinguisticProperty = _prefixId.prefix "LinguisticProperty"
    /// <summary>
    ///   <para>rdfs:comment : A linguistic sign is an abstract structure whose instances participate in a linguistic system, or language. By definition, a linguistic sign must have a form component (whose elements are phonological units), a grammatical component (whose elements are grammatical units), and a meaning component (whose elements are semantic units). The formal structure of a linguistic sign is determined by the grammar of a language. The information value of a linguistic sign, its meaning, is not fixed, but determined by the conventions of the language. The relation of form to meaning is largely arbitrary within a semiotic system. Signs are classified primarily according to what kinds of formal relations they participate in, and, secondly, according to their complexity (whether they are atomic or composed of other signs). Signs range from morphological and syntactic constructions to whole discourse segments [de Saussure 1983; Hervey 1979; Pollard and Sag 1994].</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : LinguisticSign</para>
    ///   <a href="http://purl.org/linguistics/gold/LinguisticSign">gold:LinguisticSign</a>
    /// </summary>
    let LinguisticSign = _prefixId.prefix "LinguisticSign"
    /// <summary>
    ///   <para>rdfs:comment : A term used to describe a language as a whole, with each of its component parts functioning according to an overall convention of usage to enable the members of a speech community to interchange information. Most linguists agree on a 'system of systems', i.e. the arrangement of units on hierarchically ordered and inter-related levels. [Hartmann and Stork 1972: 231]</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : LinguisticSystem</para>
    ///   <a href="http://purl.org/linguistics/gold/LinguisticSystem">gold:LinguisticSystem</a>
    /// </summary>
    let LinguisticSystem = _prefixId.prefix "LinguisticSystem"
    /// <summary>
    ///   <para>rdfs:comment : LinguisticTaxon is the class of  Taxons whose instances are used in the scientific classification language varieties. That is, instances of LinguisticTaxon have instances that are human language varieties.</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : LinguisticTaxon</para>
    ///   <a href="http://purl.org/linguistics/gold/LinguisticTaxon">gold:LinguisticTaxon</a>
    /// </summary>
    let LinguisticTaxon = _prefixId.prefix "LinguisticTaxon"
    /// <summary>
    ///   <para>rdfs:comment : This term is often used in linguistics and phonetics to refer to any entity which constitutes the focus of an enquiry. The unit is the stretch of language that carries grammatical patterns, and within which grammatical choices are made. For example, the unit sentence consists of one or more instances of the unit clause, and so on. [Crystal 2008: 503]</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : LinguisticUnit</para>
    ///   <a href="http://purl.org/linguistics/gold/LinguisticUnit">gold:LinguisticUnit</a>
    /// </summary>
    let LinguisticUnit = _prefixId.prefix "LinguisticUnit"
    /// <summary>
    ///   <para>rdfs:comment : A language which is the current native language of a speech community. [Hartmann and Stork 1972: 133]</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : LivingVariety</para>
    ///   <a href="http://purl.org/linguistics/gold/LivingVariety">gold:LivingVariety</a>
    /// </summary>
    let LivingVariety = _prefixId.prefix "LivingVariety"
    /// <summary>
    ///   <para>rdfs:comment : (adj./n.) In languages which express grammatical relationships by means of inflections, this term refers to the form taken by a noun phrase (often a single noun or pronoun), when it typically expresses the idea of location of an entity or action. Structures which express locational meaning may also be referred to as locative, e.g. in 'The woman was standing at a bus stop', 'at a bus stop' could be called a locative phrase. [Crystal 2008: 288]</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : LocativeCase</para>
    ///   <a href="http://purl.org/linguistics/gold/LocativeCase">gold:LocativeCase</a>
    /// </summary>
    let LocativeCase = _prefixId.prefix "LocativeCase"
    /// <summary>
    ///   <para>rdfs:comment : An oblique locative nominal assumes the subject relation [Klaiman 1991: 17].</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : LocativePassiveVoice</para>
    ///   <a href="http://purl.org/linguistics/gold/LocativePassiveVoice">gold:LocativePassiveVoice</a>
    /// </summary>
    let LocativePassiveVoice = _prefixId.prefix "LocativePassiveVoice"
    /// <summary>
    ///   <para>rdfs:comment : Articulated with the highest point of the tongue more or less maximally distant from the roof of the mouth. In the SPE feature system, a distinctive feature defined as 'articulated with the body of the tongue below the neutral position.' [Trask 1996: 212]</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : Low</para>
    ///   <a href="http://purl.org/linguistics/gold/Low">gold:Low</a>
    /// </summary>
    let Low = _prefixId.prefix "Low"
    /// <summary>
    ///   <para>rdfs:comment : MainClause is the class of clauses that can stand on their own as a  full, independent sentence.  If a sentence contains any embedded clauses, the main clause is understood as the matrix plus the embedded clauses. In the sentence 'John thinks that Mary is sick', 'John thinks that Mary is sick' is the main clause. [Crystal 2001: 231]</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : MainClause</para>
    ///   <a href="http://purl.org/linguistics/gold/MainClause">gold:MainClause</a>
    /// </summary>
    let MainClause = _prefixId.prefix "MainClause"
    /// <summary>
    ///   <para>rdfs:comment : Opposite of BenefactiveCase; used when the marked noun is adversely affected in the clause. [Zúñiga and Kittilä 2010: 5]</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : MalefactiveCase</para>
    ///   <a href="http://purl.org/linguistics/gold/MalefactiveCase">gold:MalefactiveCase</a>
    /// </summary>
    let MalefactiveCase = _prefixId.prefix "MalefactiveCase"
    /// <summary>
    ///   <para>rdfs:comment : A sound property referring to the kind of articulatory process used in a sound's production.  The distinction between vowel and consonant is usually made in terms of manner of articulation.  Within consonants, several articulatory types are recognized based on the type of closure made by the vocal organs.  Within vowels, classification  is based on the number of auditory qualities distinguishable in the sound, the position of the soft palate, and the type of lip position. [Crystal 1997: 232]</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : MannerProperty</para>
    ///   <a href="http://purl.org/linguistics/gold/MannerProperty">gold:MannerProperty</a>
    /// </summary>
    let MannerProperty = _prefixId.prefix "MannerProperty"
    /// <summary>
    ///   <para>rdfs:comment : A gender property established on the basis of agreement, to which nouns may be assigned based on semantic or formal criteria.  In semantic gender systems, nouns belonging to the masculine gender typically denote male humans as well as nouns meeting certain physical criteria.  Some gender systems differentiate masculine nouns from all other nouns (e.g. masculine/other or male human/other), while others differentiate masculine, feminine and neuter nouns or several different gender classes. [Corbett 1991: 30]</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : MasculineGender</para>
    ///   <a href="http://purl.org/linguistics/gold/MasculineGender">gold:MasculineGender</a>
    /// </summary>
    let MasculineGender = _prefixId.prefix "MasculineGender"
    /// <summary>
    ///   <para>rdfs:comment : MentalAbilitiveModality indicates that an agent has the  capacity to perform some mental action [Bybee, Perkins and Pagliuca 1994: 192; Palmer 2001: 77].</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : MentalAbilitiveModality</para>
    ///   <a href="http://purl.org/linguistics/gold/MentalAbilitiveModality">gold:MentalAbilitiveModality</a>
    /// </summary>
    let MentalAbilitiveModality = _prefixId.prefix "MentalAbilitiveModality"
    /// <summary>
    ///   <para>rdfs:comment : Characterizing sounds articulated between the high and low tongue positions. [Crystal 1987: 425]</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : Mid</para>
    ///   <a href="http://purl.org/linguistics/gold/Mid">gold:Mid</a>
    /// </summary>
    let Mid = _prefixId.prefix "Mid"
    /// <summary>
    ///   <para>rdfs:comment : MinusATR (Advanced Tongue Root) characterizes sounds made in which there is no advancement of the tongue root or lowering of the larynx. [Ladefoged 2000: 211]</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : MinusATR</para>
    ///   <a href="http://purl.org/linguistics/gold/MinusATR">gold:MinusATR</a>
    /// </summary>
    let MinusATR = _prefixId.prefix "MinusATR"
    /// <summary>
    ///   <para>rdfs:comment : MinusClick refers to not having the properties of a click.  Clicks are stops in which the essential component is the rarefaction of air enclosed between two articulatory closures formed in the oral cavity, so that a loud transient is produced when the more forward closure is released.  This uses the velaric airstream mechanism, always ingressive, and cannot be used for sounds other than stops and affricates.  [Ladefoged and Maddieson 1996: 246]</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : MinusClick</para>
    ///   <a href="http://purl.org/linguistics/gold/MinusClick">gold:MinusClick</a>
    /// </summary>
    let MinusClick = _prefixId.prefix "MinusClick"
    /// <summary>
    ///   <para>rdfs:comment : MinusFortis refers to a sound made without relatively strong degree of muscular effort and breath force.  [Crystal 1985: 126]</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : MinusFortis</para>
    ///   <a href="http://purl.org/linguistics/gold/MinusFortis">gold:MinusFortis</a>
    /// </summary>
    let MinusFortis = _prefixId.prefix "MinusFortis"
    /// <summary>
    ///   <para>rdfs:comment : Characterizing sounds in which the palatal tensor muscles and the levator palatine muscle raise the velum, preventing air from escaping through the nose. [Kenstowicz 1994: 143; Ladefoged 2000: 274]</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : MinusNasal</para>
    ///   <a href="http://purl.org/linguistics/gold/MinusNasal">gold:MinusNasal</a>
    /// </summary>
    let MinusNasal = _prefixId.prefix "MinusNasal"
    /// <summary>
    ///   <para>rdfs:comment : A part of speech, usually associated with a verbal system, that expresses the concept of necessity and possibility, as well as the subject's attitude toward the factuality or actualization of the situation expressed by the rest of the clause.  Modals can code inception, termination, persistence, success, failure, attempt, intent, obligation or ability vis-a-vis the complement state/event, and the subject of the main clause is obligatorily also the subject of the complement clause. [Palmer 2001: 2; Givon 1984: 533; Huddleston and Pullam 2002: 173]</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : Modal</para>
    ///   <a href="http://purl.org/linguistics/gold/Modal">gold:Modal</a>
    /// </summary>
    let Modal = _prefixId.prefix "Modal"
    /// <summary>
    ///   <para>rdfs:comment : Regular vibrations of the vocal folds at any frequency within the speaker's normal range.  [Ladefoged and Maddieson 1996:  48]</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : ModalVoice</para>
    ///   <a href="http://purl.org/linguistics/gold/ModalVoice">gold:ModalVoice</a>
    /// </summary>
    let ModalVoice = _prefixId.prefix "ModalVoice"
    /// <summary>
    ///   <para>rdfs:comment : ModalityProperty is the class of properties that concern the grammatical encoding of the status of the proposition itself, and not of the event to which the proposition refers, cf. AspectProperty. As a grammatical property, it represents those dimensions in the domains of knowledge (epistemic modality), social relations (deontic modality) and ability (abilitative modality), and possibly others. [Palmer 2001: 1, 7-10]</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : ModalityProperty</para>
    ///   <a href="http://purl.org/linguistics/gold/ModalityProperty">gold:ModalityProperty</a>
    /// </summary>
    let ModalityProperty = _prefixId.prefix "ModalityProperty"
    /// <summary>
    ///   <para>rdfs:comment : MoodProperty is the class of properties that concern the grammatical encoding of mood of a proposition. Among the traditionally defined properties are Declarative, Imperative and Interrogative. This class of properties contains both attitude (e.g. optative, volitive, subjunctive) and speech-act (e.g. imperative, commissive) values.</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : MoodProperty</para>
    ///   <a href="http://purl.org/linguistics/gold/MoodProperty">gold:MoodProperty</a>
    /// </summary>
    let MoodProperty = _prefixId.prefix "MoodProperty"
    /// <summary>
    ///   <para>rdfs:comment : Mora refers to the several parts of the phoneme which may receive divergent tonal treatments [Pei and Gaynor 1980: 138].  A mora also can refer to a minimal unit of metrical time equivalent to a short syllable [Crystal 1985: 198].</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : Mora</para>
    ///   <a href="http://purl.org/linguistics/gold/Mora">gold:Mora</a>
    /// </summary>
    let Mora = _prefixId.prefix "Mora"
    /// <summary>
    ///   <para>rdfs:comment : The smallest functioning unit in the composition of words, and the minimal distinctive unit of grammar.  Morphemes are commonly classified into free forms (morphemes which can occur as separate words) adn bound forms (morphemes which cannot so occur - mainly affixes).  A further distinction may be made between lexical and grammatical morphemes; the former are morphemes used for the construction of new words in a language; the latter are morphemes used to express grammatical relationships between a word and its context. [Crystal 2008: 300]</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : Morpheme</para>
    ///   <a href="http://purl.org/linguistics/gold/Morpheme">gold:Morpheme</a>
    /// </summary>
    let Morpheme = _prefixId.prefix "Morpheme"
    let MorphologicalUnit = _prefixId.prefix "MorphologicalUnit"
    /// <summary>
    ///   <para>rdfs:comment : A property whose values are not involved in agreement or government, but are inherent only. That is, the elements on which the values are found are not controllers of agreement. Because it is not involved in either agreement or government, a morphosemantic feature is not relevant to syntax. [Kibort 2008f]</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : MorphosemanticProperty</para>
    ///   <a href="http://purl.org/linguistics/gold/MorphosemanticProperty">gold:MorphosemanticProperty</a>
    /// </summary>
    let MorphosemanticProperty = _prefixId.prefix "MorphosemanticProperty"
    /// <summary>
    ///   <para>rdfs:comment : MorphosyntacticFeature is the class of linguistic features that govern the grammatical behavior of morphosyntactic units. E.g., two morphosyntactic units can agree according to shared morphosyntactic features. Morphosyntactic features are also called grammatical categories. This class is intended to represent only the formal aspects of morphosyntax; that is, there is no notional component. In a grammatical system, such features occur in contrast to one another other, and are typically expressed in the same fashion. [Crystal 1985: 43-44; Hopper, P. 1992: 81; Bybee 1985: 191]</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : MorphosyntacticProperty</para>
    ///   <a href="http://purl.org/linguistics/gold/MorphosyntacticProperty">gold:MorphosyntacticProperty</a>
    /// </summary>
    let MorphosyntacticProperty = _prefixId.prefix "MorphosyntacticProperty"
    /// <summary>
    ///   <para>rdfs:comment : Multal is a number property that refers to a large number of individuals.</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : MultalNumber</para>
    ///   <a href="http://purl.org/linguistics/gold/MultalNumber">gold:MultalNumber</a>
    /// </summary>
    let MultalNumber = _prefixId.prefix "MultalNumber"
    /// <summary>
    ///   <para>rdfs:comment : A multiplicative numeral is a numeral that expresses how many fold or how many times [Pei and Gaynor 1954: 149; Hartmann and Stork 1972: 147].</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : MultiplicativeNumeral</para>
    ///   <a href="http://purl.org/linguistics/gold/MultiplicativeNumeral">gold:MultiplicativeNumeral</a>
    /// </summary>
    let MultiplicativeNumeral = _prefixId.prefix "MultiplicativeNumeral"
    /// <summary>
    ///   <para>rdfs:comment : The class of properties that describe the degree to which the velum or soft palate is raised or lowered, allowing or prohibiting air from escaping through the nose. [Kenstowicz 1994: 143]</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : NasalityProperty</para>
    ///   <a href="http://purl.org/linguistics/gold/NasalityProperty">gold:NasalityProperty</a>
    /// </summary>
    let NasalityProperty = _prefixId.prefix "NasalityProperty"
    /// <summary>
    ///   <para>rdfs:comment : In languages which distinguish different degrees of remoteness in the future, the near future refers to the least remote future.  [Comrie 1985: 46]</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : NearFutureTense</para>
    ///   <a href="http://purl.org/linguistics/gold/NearFutureTense">gold:NearFutureTense</a>
    /// </summary>
    let NearFutureTense = _prefixId.prefix "NearFutureTense"
    /// <summary>
    ///   <para>rdfs:comment : The class of languages that have relatively few native speakers. A nearly extinct variety is expected to become extrinct in a short time period, e.g., Jebero or Wichita.</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : NearlyExtinctVariety</para>
    ///   <a href="http://purl.org/linguistics/gold/NearlyExtinctVariety">gold:NearlyExtinctVariety</a>
    /// </summary>
    let NearlyExtinctVariety = _prefixId.prefix "NearlyExtinctVariety"
    /// <summary>
    ///   <para>rdfs:comment : A passive in Irish in which the preposition "with" is used, and a semantic meaning of necessity is added [Noonan 1994: 280].</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : NecessitativePassiveVoice</para>
    ///   <a href="http://purl.org/linguistics/gold/NecessitativePassiveVoice">gold:NecessitativePassiveVoice</a>
    /// </summary>
    let NecessitativePassiveVoice = _prefixId.prefix "NecessitativePassiveVoice"
    /// <summary>
    ///   <para>rdfs:comment : NecessityModality indicates that the described state of affairs is necessary [Palmer 2001: 89-90], either directly, or because of a requirement on the part of an agent [Bybee, Perkins and Pagliuca 1994: 177].</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : NecessityModality</para>
    ///   <a href="http://purl.org/linguistics/gold/NecessityModality">gold:NecessityModality</a>
    /// </summary>
    let NecessityModality = _prefixId.prefix "NecessityModality"
    /// <summary>
    ///   <para>rdfs:comment : NegationOperator is a negative-marking phrase located in scope position of the verb (specifier or adjoined position).  Also called a "negation particle", it is normally associated with the main verb of the clause but may also be a clause-level clitic.[Payne 2007:284; Haegeman 1995: 107, 286]</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : NegationOperator</para>
    ///   <a href="http://purl.org/linguistics/gold/NegationOperator">gold:NegationOperator</a>
    /// </summary>
    let NegationOperator = _prefixId.prefix "NegationOperator"
    /// <summary>
    ///   <para>rdfs:comment : A construction that expresses the contradiction of some or all of a proposition [Crystal 1980: 257]. Note: this value is not to be confused with the notion "Negative Polarity Item", which is an expression that occurs in the scope of Negation (i.e. Negative Polarity).</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : NegativePolarity</para>
    ///   <a href="http://purl.org/linguistics/gold/NegativePolarity">gold:NegativePolarity</a>
    /// </summary>
    let NegativePolarity = _prefixId.prefix "NegativePolarity"
    /// <summary>
    ///   <para>rdfs:comment : A gender property established on the basis of agreement, to which nouns may be assigned, either by a semantic rule, if they belong to the semantic residue of the assignment system, or by a formal rule, if assignment depends on inflectional class membership. Typically, this means that the neuter gender may cover some inanimates and possibly some portion of lower order animates. Note: Although in familiar Indo-European languages the term neuter gender may be part of a system with three or less values, it can be used for systems containing more than three gender values (e.g. Bininj Gunwok). [Kibort and Corbett 2008a]</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : NeuterGender</para>
    ///   <a href="http://purl.org/linguistics/gold/NeuterGender">gold:NeuterGender</a>
    /// </summary>
    let NeuterGender = _prefixId.prefix "NeuterGender"
    /// <summary>
    ///   <para>rdfs:comment : A nominal is a partOfSpeech whose members differ grammatically from a substantive but which functions as one [Crystal 1997: 260].</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : Nominal</para>
    ///   <a href="http://purl.org/linguistics/gold/Nominal">gold:Nominal</a>
    /// </summary>
    let Nominal = _prefixId.prefix "Nominal"
    /// <summary>
    ///   <para>rdfs:comment : A classifier used within a system of noun classes where the morphosyntactic loci are adjectives and, rarely, numerals, as modifiers. Nominal classifiers have all the properties of noun class system classifiers with differences regarding the size of the system (bigger); semantics (animacy/sex/shape/size), transparency of semantic basis (may be opaque), variability of assignment (possible), use in multiple classifier systems (possible), and interrelations with other categories (only with number). [Aikhenvald 2003: 68]</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : NominalClassifier</para>
    ///   <a href="http://purl.org/linguistics/gold/NominalClassifier">gold:NominalClassifier</a>
    /// </summary>
    let NominalClassifier = _prefixId.prefix "NominalClassifier"
    /// <summary>
    ///   <para>rdfs:comment : A nominal particle is a member of a closed class of particles that co-occur with nouns.</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : NominalParticle</para>
    ///   <a href="http://purl.org/linguistics/gold/NominalParticle">gold:NominalParticle</a>
    /// </summary>
    let NominalParticle = _prefixId.prefix "NominalParticle"
    /// <summary>
    ///   <para>rdfs:comment : A derivational unit that forms a noun from some other word class. [Crystal 1997: 260]</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : Nominalizer</para>
    ///   <a href="http://purl.org/linguistics/gold/Nominalizer">gold:Nominalizer</a>
    /// </summary>
    let Nominalizer = _prefixId.prefix "Nominalizer"
    /// <summary>
    ///   <para>rdfs:comment : NominativeCase identifies clause subjects in nominative-accusative languages. It is usually the unmarked case. Nouns used in isolation often have this case. [Crystal 1980: 242; Pei and Gaynor 1954: 147; Hartmann and Stork 1972: 224]</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : NominativeCase</para>
    ///   <a href="http://purl.org/linguistics/gold/NominativeCase">gold:NominativeCase</a>
    /// </summary>
    let NominativeCase = _prefixId.prefix "NominativeCase"
    /// <summary>
    ///   <para>rdfs:comment : An Antipassive in which the patient or logical object is not supressed, as is the case in the Absolutive Antipassive, but rather, is overtly downgraded. Some Mayanists distinguish between two types of Non Absolutive Antipassives: the Focus Antipassive and the Incorporating Antipassive. [Klaiman 1991: 232]</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : NonAbsolutiveAntipassiveVoice</para>
    ///   <a href="http://purl.org/linguistics/gold/NonAbsolutiveAntipassiveVoice">gold:NonAbsolutiveAntipassiveVoice</a>
    /// </summary>
    let NonAbsolutiveAntipassiveVoice = _prefixId.prefix "NonAbsolutiveAntipassiveVoice"
    /// <summary>
    ///   <para>rdfs:comment : NonFutureTense locates the situation in question at or before the moment of utterance, and contrasts with a FutureTense [Comrie 1985: 49].</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : NonFutureTense</para>
    ///   <a href="http://purl.org/linguistics/gold/NonFutureTense">gold:NonFutureTense</a>
    /// </summary>
    let NonFutureTense = _prefixId.prefix "NonFutureTense"
    /// <summary>
    ///   <para>rdfs:comment : NonPastTense locates the situation in question at or after the moment of utterance, and contrasts with a past tense [Comrie 1985: 48-49].</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : NonPastTense</para>
    ///   <a href="http://purl.org/linguistics/gold/NonPastTense">gold:NonPastTense</a>
    /// </summary>
    let NonPastTense = _prefixId.prefix "NonPastTense"
    /// <summary>
    ///   <para>rdfs:comment : A value of Aspect Property (also stative aspect) assigned to the designated element in the clause when the meaning selected for the clause is that which indicates that the situation spoken about has internal temporal structure, it cannot be regarded as habitual, but is regarded as a continuing state. Hence, Nonprogressive Aspect can be regarded as a sub-type of continuousness (which, in turn, is a sub-type of imperfectivity). Since languages have different criteria for classifying predicates as stative or not, they may have different rules for determining when explicitly nonprogressive (i.e. explicitly stative) forms can be used.
    ///
    /// Typically, for an aspect value to be labelled as Nonprogressive, the aspectual meaning has to minimally express nonprogressiveness, although it may additionally express other temporal, aspectual, or modal meanings, or actionality distinctions. [Kibort 2008c: 8]</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : NonProgressiveAspect</para>
    ///   <a href="http://purl.org/linguistics/gold/NonProgressiveAspect">gold:NonProgressiveAspect</a>
    /// </summary>
    let NonProgressiveAspect = _prefixId.prefix "NonProgressiveAspect"
    /// <summary>
    ///   <para>rdfs:comment : Involves demotion of the non-topical obviate-agent from subjecthood [Givon 1994: 24].</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : NonPromotionalInverseVoice</para>
    ///   <a href="http://purl.org/linguistics/gold/NonPromotionalInverseVoice">gold:NonPromotionalInverseVoice</a>
    /// </summary>
    let NonPromotionalInverseVoice = _prefixId.prefix "NonPromotionalInverseVoice"
    /// <summary>
    ///   <para>rdfs:comment : A term used in the grammatical classification of words, traditionally defines as the "name of a person, place or thing," but the vagueness associated with the notions of "name" and "thing" (e.g. is 'beauty' a thing?) has led linguistic descriptions to analyze this class in terms of the formal and functional criteria of syntax and morphology.  In linguistic terms, nouns are items which display certain types of inflection (e.g. of case or number), have a specific distribution (e.g. they may follow prepositions but not, say, modals), and perform a specific syntactic function (e.g. as subject or object of a sentence).  Nouns are generally subclassified into common and proper types, and analyzed in terms of number, gender, case and countability. [Crystal 2008: 320]</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : Noun</para>
    ///   <a href="http://purl.org/linguistics/gold/Noun">gold:Noun</a>
    /// </summary>
    let Noun = _prefixId.prefix "Noun"
    /// <summary>
    ///   <para>rdfs:comment : A classifier is a partOfSpeech whose members express the classification of a noun [Crystal 1997: 61; Payne 1997: 107].</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : NounClassifier</para>
    ///   <a href="http://purl.org/linguistics/gold/NounClassifier">gold:NounClassifier</a>
    /// </summary>
    let NounClassifier = _prefixId.prefix "NounClassifier"
    /// <summary>
    ///   <para>rdfs:comment : Also called nominal groups, nouns phrases are the constructions into which nouns most commonly enter and of which they are the head word.  The structure of a noun phrase consists minimally of the noun (or noun substitute, such as a pronoun); the constructions preceding and following the noun are often described under the headings of premodification and postmodification respectively. [Crystal 2008: 320]</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : NounPhrase</para>
    ///   <a href="http://purl.org/linguistics/gold/NounPhrase">gold:NounPhrase</a>
    /// </summary>
    let NounPhrase = _prefixId.prefix "NounPhrase"
    /// <summary>
    ///   <para>rdfs:comment : Object of action belongs to. Moves into, or moves from sphere of subject [Siewierska 1988: 257].</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : NucleonicMiddleVoice</para>
    ///   <a href="http://purl.org/linguistics/gold/NucleonicMiddleVoice">gold:NucleonicMiddleVoice</a>
    /// </summary>
    let NucleonicMiddleVoice = _prefixId.prefix "NucleonicMiddleVoice"
    /// <summary>
    ///   <para>rdfs:comment : NumberProperty is the class of properties that concern the grammatical encoding of quantity. It is often found on nouns, pronouns, and verbs and expresses count distinctions--such as 'one' or 'more than one'. The count distinctions typically, but not always, correspond to the actual count of the referents of the marked noun or Pronoun. [Crystal 1980: 245; Hartmann and Stork 1972: 155]</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : NumberProperty</para>
    ///   <a href="http://purl.org/linguistics/gold/NumberProperty">gold:NumberProperty</a>
    /// </summary>
    let NumberProperty = _prefixId.prefix "NumberProperty"
    /// <summary>
    ///   <para>rdfs:comment : A numeral is a partOfSpeech whose members function most typically as adjectives or pronouns and express a number, or relation to the number, such as one of the following: quantity, sequence, frequency, fraction [Hartmann and Stork 1972: 155; Pei and Gaynor 1954: 149].</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : Numeral</para>
    ///   <a href="http://purl.org/linguistics/gold/Numeral">gold:Numeral</a>
    /// </summary>
    let Numeral = _prefixId.prefix "Numeral"
    /// <summary>
    ///   <para>rdfs:comment : Numeral classifiers are free or bound morphemes that occur in the context of quantification, appearing contiguous to numerals in numeral noun phrases and expressions of quantity. [Aikhenvald 2003: 98; Aikhenvald in Senft 2000: 93]rdfs:comment : Numeral classifiers are a grammatical device that reflects how speakers categorize objects that they count or quantify [Yamamoto 2005: 1].  They are a set of classifiers used in certain languages, e.g., Japanese, to indicate the class to which the noun modified by the numeral belongs [Pei and Gaynor 1980: 23].</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : NumeralClassifier</para>
    ///   <a href="http://purl.org/linguistics/gold/NumeralClassifier">gold:NumeralClassifier</a>
    /// </summary>
    let NumeralClassifier = _prefixId.prefix "NumeralClassifier"
    /// <summary>
    ///   <para>rdfs:comment : Corresponds roughly to the class of ordinary objects. Examples include normal physical objects, geographical regions, and locations of processes, the complement of objects in the physical class. In a 4D ontology, an object is something whose spatiotemporal extent is thought of as dividing into spatial parts roughly parallel to the time-axis. [SUMO 2010]</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : Object</para>
    ///   <a href="http://purl.org/linguistics/gold/Object">gold:Object</a>
    /// </summary>
    let Object = _prefixId.prefix "Object"
    /// <summary>
    ///   <para>rdfs:comment : ObligativeModality indicates that an agent is required to perform the action expressed by the predicate [Bybee, Perkins and Pagliuca 1994: 177; Palmer 2001: 71].</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : ObligativeModality</para>
    ///   <a href="http://purl.org/linguistics/gold/ObligativeModality">gold:ObligativeModality</a>
    /// </summary>
    let ObligativeModality = _prefixId.prefix "ObligativeModality"
    /// <summary>
    ///   <para>rdfs:comment : In a direct/oblique system or in a nominative/oblique system, oblique case is the term for all roles not marked by the direct case or nominative case.  In the phrase 'the oblique cases' it is used to refer to a set of cases excluding the nominative (occasionally the nominative or accusative).  [Bauer 2004: 27]</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : ObliqueCase</para>
    ///   <a href="http://purl.org/linguistics/gold/ObliqueCase">gold:ObliqueCase</a>
    /// </summary>
    let ObliqueCase = _prefixId.prefix "ObliqueCase"
    /// <summary>
    ///   <para>rdfs:comment : A Passive in which a basic Oblique nominal assumes the Subject relation in a corresponding nonbasic configuration.  Can include locative passives, benefactive passives and instrumental passives. [Klaiman 1991: 23]</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : ObliquePassiveVoice</para>
    ///   <a href="http://purl.org/linguistics/gold/ObliquePassiveVoice">gold:ObliquePassiveVoice</a>
    /// </summary>
    let ObliquePassiveVoice = _prefixId.prefix "ObliquePassiveVoice"
    /// <summary>
    ///   <para>rdfs:comment : An explicit specification of a representational vocabulary for a shared domain of discourse.  [Gruber 1993: 199]</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : Ontology</para>
    ///   <a href="http://purl.org/linguistics/gold/Ontology">gold:Ontology</a>
    /// </summary>
    let Ontology = _prefixId.prefix "Ontology"
    /// <summary>
    ///   <para>rdfs:comment : Optative indicates that the speaker wishes or hopes that the expressed proposition be the case [Bybee, Perkins and Pagliuca 1994: 179; Palmer 2001: 204].</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : OptativeMood</para>
    ///   <a href="http://purl.org/linguistics/gold/OptativeMood">gold:OptativeMood</a>
    /// </summary>
    let OptativeMood = _prefixId.prefix "OptativeMood"
    /// <summary>
    ///   <para>rdfs:comment : An ordinal numeral is a numeral belonging to a class whose members designate positions in a sequence [Crystal 1997: 272].</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : OrdinalNumeral</para>
    ///   <a href="http://purl.org/linguistics/gold/OrdinalNumeral">gold:OrdinalNumeral</a>
    /// </summary>
    let OrdinalNumeral = _prefixId.prefix "OrdinalNumeral"
    /// <summary>
    ///   <para>rdfs:comment : An OrthographicPart is a unit of an orthography that is not orthographically independent, that is, not necessarily able to stand alone as an orthographic word set off by whitespace. In the printed instance of the word 'conceive', 'eive' is an instance of orthographic part. Note that an orthographic part is not the same as a single glyph, although, some orthographic parts are single glyphs.</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : OrthographicPart</para>
    ///   <a href="http://purl.org/linguistics/gold/OrthographicPart">gold:OrthographicPart</a>
    /// </summary>
    let OrthographicPart = _prefixId.prefix "OrthographicPart"
    /// <summary>
    ///   <para>rdfs:comment : An OrthographicPhrase is a sequence of orthographic words.</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : OrthographicPhrase</para>
    ///   <a href="http://purl.org/linguistics/gold/OrthographicPhrase">gold:OrthographicPhrase</a>
    /// </summary>
    let OrthographicPhrase = _prefixId.prefix "OrthographicPhrase"
    /// <summary>
    ///   <para>rdfs:comment : An OrthographicSentence is a special type of orthographic phrase, usually representing a clause. In Western writing systems, an orthographic sentence is set off by white space on the left edge and some kind of puncuation, such as a period or question mark, on the right.</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : OrthographicSentence</para>
    ///   <a href="http://purl.org/linguistics/gold/OrthographicSentence">gold:OrthographicSentence</a>
    /// </summary>
    let OrthographicSentence = _prefixId.prefix "OrthographicSentence"
    /// <summary>
    ///   <para>rdfs:comment : A system of the art and rules of spelling according to the accepted standards, i.e., the use of the written characters of a language for forming words and sentences in conformity with the rules conventionally recognized as correct.  [Pei and Gaynor 1980: 155]</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : OrthographicSystem</para>
    ///   <a href="http://purl.org/linguistics/gold/OrthographicSystem">gold:OrthographicSystem</a>
    /// </summary>
    let OrthographicSystem = _prefixId.prefix "OrthographicSystem"
    /// <summary>
    ///   <para>rdfs:comment : An OrthographicWord is a fundamental unit of an orthography, usually set off by white space and dependent on the rules of a writing system.</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : OrthographicWord</para>
    ///   <a href="http://purl.org/linguistics/gold/OrthographicWord">gold:OrthographicWord</a>
    /// </summary>
    let OrthographicWord = _prefixId.prefix "OrthographicWord"
    /// <summary>
    ///   <para>rdfs:comment : An indication that the source of information is someone other than the speaker.  [Aikhenvald 2006: 106]</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : OtherSourceEvidentiality</para>
    ///   <a href="http://purl.org/linguistics/gold/OtherSourceEvidentiality">gold:OtherSourceEvidentiality</a>
    /// </summary>
    let OtherSourceEvidentiality = _prefixId.prefix "OtherSourceEvidentiality"
    /// <summary>
    ///   <para>rdfs:comment : OtherThanVisualEvidentiality encodes the fact that the speaker came to believe the content of the expression directly in a way other than through visual experience; they heard it, smelled it, tasted it, etc. [Palmer 2001: 36, 57].</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : OtherThanVisualEvidentiality</para>
    ///   <a href="http://purl.org/linguistics/gold/OtherThanVisualEvidentiality">gold:OtherThanVisualEvidentiality</a>
    /// </summary>
    let OtherThanVisualEvidentiality = _prefixId.prefix "OtherThanVisualEvidentiality"
    /// <summary>
    ///   <para>rdfs:comment : A Paragraph is a self contained unit in written language composed of a sequence of orthographic sentences. Paragraphs are set off by vertical spacing, indentation or other conventions.</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : Paragraph</para>
    ///   <a href="http://purl.org/linguistics/gold/Paragraph">gold:Paragraph</a>
    /// </summary>
    let Paragraph = _prefixId.prefix "Paragraph"
    /// <summary>
    ///   <para>rdfs:comment : The property that identifies the grammatical class of a word.  The main 'parts of speech' recognized by most school grammars derive from the work of the ancient Greek and Roman grammarians, primarily the noun, pronoun, verb, adverb, adjective, preposition, conjunction and interjection, with article, participle, and others often added.  Because of the inexplicitness with which these terms were traditionally defined and the restricted nature of their definitions, it has become preferable to use such terms as word-class or form-class, where the grouping is based on formal criteria of a more universally applicable kind. [Crystal 1997: 280]</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : PartOfSpeechProperty</para>
    ///   <a href="http://purl.org/linguistics/gold/PartOfSpeechProperty">gold:PartOfSpeechProperty</a>
    /// </summary>
    let PartOfSpeechProperty = _prefixId.prefix "PartOfSpeechProperty"
    /// <summary>
    ///   <para>rdfs:comment : A participle is a word which participates as both a verb (by showing tense) and as an adjective (by showing adjectival inflection).  In modern usage, the term refers to a non-finite part of the verb other than the infinitive (independent of the function of these forms in the sentence).  [Bauer 2004: 82]</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : Participle</para>
    ///   <a href="http://purl.org/linguistics/gold/Participle">gold:Participle</a>
    /// </summary>
    let Participle = _prefixId.prefix "Participle"
    /// <summary>
    ///   <para>rdfs:comment : A term used to refer to an invariable item with grammatical function, especially one which does not readily fit into a standard classification of parts of speech. [Crystal 1997: 279-280]</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : Particle</para>
    ///   <a href="http://purl.org/linguistics/gold/Particle">gold:Particle</a>
    /// </summary>
    let Particle = _prefixId.prefix "Particle"
    /// <summary>
    ///   <para>rdfs:comment : PartitiveCase expresses the partial nature of the referent of the noun it marks, as opposed to expressing the whole unit or class of which the referent is a part. This case may be found in items such as the following: existential clauses, nouns that are accompanied by numerals or units of measure, or predications of material from which something is made. It often has a meaning similar to the English word 'some'. [Pei and Gaynor 1954: 161; Richards, Platt and Weber 1985: 208; Quirk et al. 1985: 249; Sebeok 1946: 1214]</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : PartitiveCase</para>
    ///   <a href="http://purl.org/linguistics/gold/PartitiveCase">gold:PartitiveCase</a>
    /// </summary>
    let PartitiveCase = _prefixId.prefix "PartitiveCase"
    /// <summary>
    ///   <para>rdfs:comment : A partitive numeral is a numeral that expresses a fraction [Pei and Gaynor 1954: 149; Hartmann and Stork 1972: 165].</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : PartitiveNumeral</para>
    ///   <a href="http://purl.org/linguistics/gold/PartitiveNumeral">gold:PartitiveNumeral</a>
    /// </summary>
    let PartitiveNumeral = _prefixId.prefix "PartitiveNumeral"
    /// <summary>
    ///   <para>rdfs:comment : Associated with actions performed on the subject by an unspecified agent [McIntosh 1984: 108]. Refers to the category of verb forms, typically identifies with a specific morphological marking, that encode the derived diatheses in which the agent role is not linked with a subject noun phrase: Diatheis: D1=(X=AgOb)(Y+SUBabs/nom) [Shibatani 1995: 7].</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : PassiveVoice</para>
    ///   <a href="http://purl.org/linguistics/gold/PassiveVoice">gold:PassiveVoice</a>
    /// </summary>
    let PassiveVoice = _prefixId.prefix "PassiveVoice"
    /// <summary>
    ///   <para>rdfs:comment : Locates the situation in question prior to a reference time in the past before the time of the speaking event. This is also known as the PluperfectTense [Comrie 1985: 125].</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : PastInPastTense</para>
    ///   <a href="http://purl.org/linguistics/gold/PastInPastTense">gold:PastInPastTense</a>
    /// </summary>
    let PastInPastTense = _prefixId.prefix "PastInPastTense"
    /// <summary>
    ///   <para>rdfs:comment : A tense in which the event that the speaker is referring to precedes the time of the state of affairs denoted by the sentence.  Also referred to as 'past in past' form.  Past perfect can also be used modally to represent situations as non-factual or counterfactual.  [Michaelis 2006: 223; Depraetere and Reed 2006: 271]</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : PastPerfectTense</para>
    ///   <a href="http://purl.org/linguistics/gold/PastPerfectTense">gold:PastPerfectTense</a>
    /// </summary>
    let PastPerfectTense = _prefixId.prefix "PastPerfectTense"
    /// <summary>
    ///   <para>rdfs:comment : A value of Tense Feature assigned to the designated element in the clause when the meaning selected for the clause is that intended to locate the event spoken about as anterior to the deictic centre of the utterance. Most commonly, this tense meaning is referred to as 'past', because in absolute tense systems the deictic centre is the moment of speech. However, in relative tense systems, where the deictic centre can be moved to any point on the time line, it is more appropriate to refer to this temporal relation as 'anterior'.
    /// The anterior temporal relation may obtain either in 'simple' or 'perfect' contexts. Modelling of this distinction originates from Reichenbach (1947), who suggested using a third point in time, 'reference point', to capture all possible tense distinctions. In all 'simple' temporal relations, the reference point coincides with the location of the event spoken about. 'Perfect' tense meanings are created when the reference point is separated and moved away from the event time, thus altering the viewing of the temporal location of the event even though the event's actual location with respect to the deictic centre remains the same.
    /// A common instance of an anterior temporal relationship obtaining in a 'perfect' context
    /// occurs when the reference point is moved away from the event time and located instead at the moment of speech. The event time is still anterior to the moment of speech, but it is viewed against a stretch of time which began at the event and continues up to the moment of speech --- e.g. the English I have read this book, I have seen John --- hence the interpretation that the event has an effect or is in some way still relevant at the moment of speech. In some languages (e.g. English) this tense meaning is labelled as (one of the uses of the) Present Perfect, in others (e.g. Polish) this meaning may be collapsed with the 'simple' anterior meaning and labelled simply as Past.
    /// Typically, for a tense value to be labelled as Past Tense, the tense meaning has to minimally express the anterior temporal relationship, although it may additionally express other temporal relationships or aspectual and/or modal meanings. For example, when the usage of the Past Tense value is restricted to a semantically defined domain, it is conventional to add a further qualification to the label of the Past Tense value (e.g. Past Imperfective --- when the anterior temporal relationship is necessarily combined with an aspectual meaning of the Imperfective Aspect value, and grammaticalised as a single [Tense-Aspect-Mood (TAM)] category in the language). [Kibort 2008c: 4]</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : PastTense</para>
    ///   <a href="http://purl.org/linguistics/gold/PastTense">gold:PastTense</a>
    /// </summary>
    let PastTense = _prefixId.prefix "PastTense"
    /// <summary>
    ///   <para>rdfs:comment : A category of number denoting the concept 'a few', more than two and usually less than seven, but the exact number varies widely according to context.  Prototypically, it refers to a class of three to five individuals and is always restricted to humans.  [Hartmann and Stork 1972: 166; Corbett 2000: 23]</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : PaucalNumber</para>
    ///   <a href="http://purl.org/linguistics/gold/PaucalNumber">gold:PaucalNumber</a>
    /// </summary>
    let PaucalNumber = _prefixId.prefix "PaucalNumber"
    /// <summary>
    ///   <para>rdfs:comment : An evaluative property of a noun that indicates the speaker regards the person or object being referred to with distaste, contempt, or displeasure [Valentine 2001: 190-193].</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : PejorativeEvaluative</para>
    ///   <a href="http://purl.org/linguistics/gold/PejorativeEvaluative">gold:PejorativeEvaluative</a>
    /// </summary>
    let PejorativeEvaluative = _prefixId.prefix "PejorativeEvaluative"
    /// <summary>
    ///   <para>rdfs:comment : A value of Tense Feature assigned to the designated element in the clause when the meaning selected for the clause is that intended to locate the event spoken about as anterior, simultaneous, or posterior to the deictic centre of the utterance, and additionally the reference point from which this event is viewed is separated and moved away from the event time. This alters the viewing of the temporal location of the event even though the event's actual location with respect to the deictic centre remains the same. 'Perfect' temporal relations contrast with 'simple' temporal relations in which the reference point coincides with the location of the event spoken about. Modelling of this distinction originates from [Reichenbach 1947].
    /// There are two types of 'perfect' context which may lead to separate tense values:
    /// (1) The first type occurs when the reference point is moved away from the event time and instead located after the event time. A common example occurs with an anterior temporal relationship, when the reference point is moved from the event time to the moment of speech. The event time is anterior to the moment of speech, but it is viewed against a stretch of time which began at the event and continues up to the moment of speech --- e.g. the English I have read this book, I have seen John --- hence the interpretation that the event has an effect or is in some way still relevant at the moment of speech. [Note that in some languages (e.g. English) this tense meaning is labelled as (one of the uses of the) Present Perfect, in others (e.g. Polish) this meaning may be collapsed with the 'simple' anterior meaning and labelled simply as Past.] The interpretation of this type of the perfect often includes at least two related but distinguishable uses: the resultative perfect (Someone has stolen my purse) and the experiential perfect (I have read this book before) [Dahl and Velupillai 2005: 271].
    /// (2) The second type occurs when the reference point is moved away from the event time and instead located before the event time. A common example occurs with a simultaneous temporal relationship, when the reference point is moved from the event time and located before the moment of speech. The event time is still simultaneous with the moment of speech, but it is viewed against a stretch of time which began at the reference point and continues up to the moment of speech --- e.g. the English I have lived here [for ten years] --- hence the interpretation that the event which began in the past extends up to the moment of speech. [Note that in some languages (e.g. English) this tense meaning is labelled as (one of the uses of the) Present Perfect, in others (e.g. Polish) this meaning may be collapsed with the 'simple' simultaneous meaning and labelled simply as Present.] The interpretation of this type of the perfect is often referred to as the universal perfect or perfect of persistent situation.
    /// Typically, for a tense value to be labelled as Perfect Tense, the tense meaning has to minimally express the meaning resulting from the separation of the reference point from the event time, although it may additionally express other temporal, aspectual, or modal meanings. [Kibort 2008c: 5-6]</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : PerfectTense</para>
    ///   <a href="http://purl.org/linguistics/gold/PerfectTense">gold:PerfectTense</a>
    /// </summary>
    let PerfectTense = _prefixId.prefix "PerfectTense"
    /// <summary>
    ///   <para>rdfs:comment : A value of Aspect Property assigned to the designated element in the clause when the meaning selected for the clause is that which indicates that the event spoken about is to be viewed as a bounded whole, looked at from outside, without necessarily distinguishing any of its internal structure [Comrie 1976: 16ff].
    ///
    /// Typically, for an aspect value to be labeled as Perfective, the aspectual meaning has to minimally express the perfective viewpoint, although it may additionally express other temporal, aspectual, or modal meanings, or actionality distinctions. [Kibort 2008c: 7]</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : PerfectiveAspect</para>
    ///   <a href="http://purl.org/linguistics/gold/PerfectiveAspect">gold:PerfectiveAspect</a>
    /// </summary>
    let PerfectiveAspect = _prefixId.prefix "PerfectiveAspect"
    /// <summary>
    ///   <para>rdfs:comment : PerlativeCase expresses that something moved 'through','across', or 'along' the referent of the noun that is marked [Blake 2001].</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : PerlativeCase</para>
    ///   <a href="http://purl.org/linguistics/gold/PerlativeCase">gold:PerlativeCase</a>
    /// </summary>
    let PerlativeCase = _prefixId.prefix "PerlativeCase"
    /// <summary>
    ///   <para>rdfs:comment : PermissiveModality indicates that an agent has permission to perform the action expressed by the predicate [Palmer 2001: 10, 71].</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : PermissiveModality</para>
    ///   <a href="http://purl.org/linguistics/gold/PermissiveModality">gold:PermissiveModality</a>
    /// </summary>
    let PermissiveModality = _prefixId.prefix "PermissiveModality"
    /// <summary>
    ///   <para>rdfs:comment : PersonProperty is the class of properties  with a deictic dimension, interpreted relative to the speaker, encoding the participants in a speech situation. Usually a three-way contrast is found: firstPerson (speaker), secondPerson (addressee), and thirdPerson (neither speaker nor addressee). Other distinctions within this feature include: inclusive/exclusive and proximative/obviative. [Crystal 1997: 285-286]</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : PersonProperty</para>
    ///   <a href="http://purl.org/linguistics/gold/PersonProperty">gold:PersonProperty</a>
    /// </summary>
    let PersonProperty = _prefixId.prefix "PersonProperty"
    /// <summary>
    ///   <para>rdfs:comment : A Passive in which the argument mapped to Object in a basic structural configuration assumes the Subject relation in a corresponding nonbasic configuration [Klaiman 1991: 23].</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : PersonalPassiveVoice</para>
    ///   <a href="http://purl.org/linguistics/gold/PersonalPassiveVoice">gold:PersonalPassiveVoice</a>
    /// </summary>
    let PersonalPassiveVoice = _prefixId.prefix "PersonalPassiveVoice"
    /// <summary>
    ///   <para>rdfs:comment : A pronoun used to refer to the speaker, the person spoken to, and other persons and things whose referents are presumed to be clear from the context.  While some personal pronouns in some languages occur in essentially the same sentence position as other nominal expressions, it is rather common for them to show distributional peculiarities.  Personal pronouns may be clitics whose distribution may be consistently distinct from that of non-clitic nominals.  It is also common for the equivalent of personal pronouns to be expressed by affixes on the verb. [Schachter 1985: 25-26]</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : PersonalPronoun</para>
    ///   <a href="http://purl.org/linguistics/gold/PersonalPronoun">gold:PersonalPronoun</a>
    /// </summary>
    let PersonalPronoun = _prefixId.prefix "PersonalPronoun"
    /// <summary>
    ///   <para>rdfs:comment : A set of aspectual distinctions involving relations between a background situation (the reference situation) and a situation located relative to the reference situation (the denoted situation). In English, phasal distinctions are expressed by auxiliary-headed constructions, like the inceptive, progressive, and perfect constructions, whose head verbs express the aspectual class of the denoted situation. The aspectual class of the denoted situation differs from that of the reference situation [Michaelis 1998: xv]. An event may have a beginning and an end, a middle portion (continuing or changing), and also an ensuing result or an altered state. These are considered to be the various "phases" of an event. A speaker may talk about an event from the point of view of any of these individual phases, and his language may have inflectional (or other type of) markers for representing these distinctions. Since such markers indicate distinctions in the temporal structure of an event, we may regard them as belonging to the category of aspect. It has been suggested [Dik 1989: 186] that these may be grouped under a subcategory (or "level") of aspect called "phasal aspect". [Bhat 1999: 49]</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : PhasalAspect</para>
    ///   <a href="http://purl.org/linguistics/gold/PhasalAspect">gold:PhasalAspect</a>
    /// </summary>
    let PhasalAspect = _prefixId.prefix "PhasalAspect"
    /// <summary>
    ///   <para>rdfs:comment : A phoneme is the underlying sound in a set of phonetically distinct sounds that native speakers of a language judge to be identical.   Variants of the underlying sound are the product of systematic rules that modify the segment depending on the phonological context in which it occurs. [Kenstowicz 1994: 65-66]</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : Phoneme</para>
    ///   <a href="http://purl.org/linguistics/gold/Phoneme">gold:Phoneme</a>
    /// </summary>
    let Phoneme = _prefixId.prefix "Phoneme"
    /// <summary>
    ///   <para>rdfs:comment : The class of properties used to describe speech sounds. The properties given here are more or less taken directly from Ladefoged's later works, in particular, the taxonomies of Ladefoged [Ladefoged 1997].</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : PhoneticProperty</para>
    ///   <a href="http://purl.org/linguistics/gold/PhoneticProperty">gold:PhoneticProperty</a>
    /// </summary>
    let PhoneticProperty = _prefixId.prefix "PhoneticProperty"
    /// <summary>
    ///   <para>rdfs:comment : The class of linguistic properties that pertain to phonological units and that are used to describe the sound system of languages [Hartmann and Stork 1972: 174]. Phonological units can be analyzed into complexes of distinctive properties that cross-classify the entire inventory of possible speech sounds into a densely packed network [Kenstowicz 1994: 19].</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : PhonologicalProperty</para>
    ///   <a href="http://purl.org/linguistics/gold/PhonologicalProperty">gold:PhonologicalProperty</a>
    /// </summary>
    let PhonologicalProperty = _prefixId.prefix "PhonologicalProperty"
    /// <summary>
    ///   <para>rdfs:comment : The set of consonant and vowel units that make up the words of a language or language variety, a phonological system is a list of contrastive sounds used in a language that are capable of distinguishing between two words with different meanings together with the ranges of variety each sound has and where those variants are found. [Ball and Mueller 2005: 120]</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : PhonologicalSystem</para>
    ///   <a href="http://purl.org/linguistics/gold/PhonologicalSystem">gold:PhonologicalSystem</a>
    /// </summary>
    let PhonologicalSystem = _prefixId.prefix "PhonologicalSystem"
    /// <summary>
    ///   <para>rdfs:comment : Phrase is the class of syntactic constructions that consist of one or more syntactic words, but lack the subject-predicate organization of a clause. Phrases get their grammatical characteristics according to what word occupies the head position; thus, all phrases have heads. [Crystal 1980: 232-233;  Pei and Gaynor 1954: 169; Pike and Pike 1982: 453]</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : Phrase</para>
    ///   <a href="http://purl.org/linguistics/gold/Phrase">gold:Phrase</a>
    /// </summary>
    let Phrase = _prefixId.prefix "Phrase"
    /// <summary>
    ///   <para>rdfs:comment : PhysicalAbilitiveModality indicates that an agent has the physical capacity to perform some action. [Bybee, Perkins and Pagliuca 1994: 192; Palmer 2001: 77]</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : PhysicalAbilitiveModality</para>
    ///   <a href="http://purl.org/linguistics/gold/PhysicalAbilitiveModality">gold:PhysicalAbilitiveModality</a>
    /// </summary>
    let PhysicalAbilitiveModality = _prefixId.prefix "PhysicalAbilitiveModality"
    /// <summary>
    ///   <para>rdfs:comment : The superclass of properties that specify the location of the articulators [Ladefoged 1997: 594].</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : PlaceProperty</para>
    ///   <a href="http://purl.org/linguistics/gold/PlaceProperty">gold:PlaceProperty</a>
    /// </summary>
    let PlaceProperty = _prefixId.prefix "PlaceProperty"
    /// <summary>
    ///   <para>rdfs:comment : An adjective without any markings for comparative or superlative form, sometimes called "positive" form.  It is that form of an adjective which merely expresses the presence of a quality or condition, without comparing or indicating its degree.  [Pei and Gaynor 1980:  172, Hartmann and Stork 1972: 5]</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : PlainAdjective</para>
    ///   <a href="http://purl.org/linguistics/gold/PlainAdjective">gold:PlainAdjective</a>
    /// </summary>
    let PlainAdjective = _prefixId.prefix "PlainAdjective"
    /// <summary>
    ///   <para>rdfs:comment : Results of action occur to subject [Siewierska 1988: 257].</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : PlainMiddleVoice</para>
    ///   <a href="http://purl.org/linguistics/gold/PlainMiddleVoice">gold:PlainMiddleVoice</a>
    /// </summary>
    let PlainMiddleVoice = _prefixId.prefix "PlainMiddleVoice"
    /// <summary>
    ///   <para>rdfs:comment : PluralNumber is a number property that quantifies the denotation of the nominal element so that: 1) it specifies that there are more than one. In this English example below, plural is shown by both the noun and the verb in (2):
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
    /// nebel-in 'a cock ostrich' ln General ln tíise 'maize cob(s)' ln lássa 'bread' ln nebel 'ostrich(es)' ln [Corbett 2000: 17-18]</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : PluralNumber</para>
    ///   <a href="http://purl.org/linguistics/gold/PluralNumber">gold:PluralNumber</a>
    /// </summary>
    let PluralNumber = _prefixId.prefix "PluralNumber"
    /// <summary>
    ///   <para>rdfs:comment : PlusATR (Advanced Tongue Root) characterizes sounds made with the root of the tongue drawn forward and the larynx lowered so that the part of the vocal tract in the pharynx is considerably enlarged. [Ladefoged 2000: 211]</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : PlusATR</para>
    ///   <a href="http://purl.org/linguistics/gold/PlusATR">gold:PlusATR</a>
    /// </summary>
    let PlusATR = _prefixId.prefix "PlusATR"
    /// <summary>
    ///   <para>rdfs:comment : PlusClick refers to having the properties of a click.  Clicks are stops in which the essential component is the rarefaction of air enclosed between two articulatory closures formed in the oral cavity, so that a loud transient is produced when the more forward closure is released.  This uses the velaric airstream mechanism, always ingressive, and cannot be used for sounds other than stops and affricates.  [Ladefoged and Maddieson 1996: 246]</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : PlusClick</para>
    ///   <a href="http://purl.org/linguistics/gold/PlusClick">gold:PlusClick</a>
    /// </summary>
    let PlusClick = _prefixId.prefix "PlusClick"
    /// <summary>
    ///   <para>rdfs:comment : PlusFortis refers to a sound made with relatively strong degree of muscular effort and breath force.  [Crystal 1985: 126]</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : PlusFortis</para>
    ///   <a href="http://purl.org/linguistics/gold/PlusFortis">gold:PlusFortis</a>
    /// </summary>
    let PlusFortis = _prefixId.prefix "PlusFortis"
    /// <summary>
    ///   <para>rdfs:comment : Characterizing sounds in which the palatorpharyngeal and palatoglossus muscles lower the velum, allowing air to go out through the nose. [Kenstowicz 1994: 143; Ladefoged 2000: 274]</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : PlusNasal</para>
    ///   <a href="http://purl.org/linguistics/gold/PlusNasal">gold:PlusNasal</a>
    /// </summary>
    let PlusNasal = _prefixId.prefix "PlusNasal"
    /// <summary>
    ///   <para>rdfs:comment : The property concerned with encoding the system of positive/negative contrastivity found in a language.  The distinction between 'positive' and 'negative polarity' may be expressed syntactically, morphologically or lexically. [Crystal 1997: 297]</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : PolarityProperty</para>
    ///   <a href="http://purl.org/linguistics/gold/PolarityProperty">gold:PolarityProperty</a>
    /// </summary>
    let PolarityProperty = _prefixId.prefix "PolarityProperty"
    /// <summary>
    ///   <para>rdfs:comment : PoliticalTaxon is the class of taxons whose instances are groupings based on political entities such as states or countries or larger politically defined entities, e.g., CameroonianLanguage.</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : PoliticalTaxon</para>
    ///   <a href="http://purl.org/linguistics/gold/PoliticalTaxon">gold:PoliticalTaxon</a>
    /// </summary>
    let PoliticalTaxon = _prefixId.prefix "PoliticalTaxon"
    /// <summary>
    ///   <para>rdfs:comment : In general, positive polarity refers to an assertion that contains no marker of negation [Crystal 1980:  299].</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : PositivePolarity</para>
    ///   <a href="http://purl.org/linguistics/gold/PositivePolarity">gold:PositivePolarity</a>
    /// </summary>
    let PositivePolarity = _prefixId.prefix "PositivePolarity"
    /// <summary>
    ///   <para>rdfs:comment : PossessedCase is used to mark the noun whose referent is possessed by the referent of another noun.</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : PossessedCase</para>
    ///   <a href="http://purl.org/linguistics/gold/PossessedCase">gold:PossessedCase</a>
    /// </summary>
    let PossessedCase = _prefixId.prefix "PossessedCase"
    /// <summary>
    ///   <para>rdfs:comment : A possessive pronoun is a pronoun that expresses ownership and relationships like ownership, such as kinship, and other forms of association [Crystal 1997: 312].</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : PossessivePronoun</para>
    ///   <a href="http://purl.org/linguistics/gold/PossessivePronoun">gold:PossessivePronoun</a>
    /// </summary>
    let PossessivePronoun = _prefixId.prefix "PossessivePronoun"
    /// <summary>
    ///   <para>rdfs:comment : PossibilityModality indicates that the designated state of affairs is possible [Palmer 2001: 89-90], either directly, or because an agent has the ability or permission to carry it out [Bybee, Perkins and Pagliuca 1994: 177].</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : PossibilityModality</para>
    ///   <a href="http://purl.org/linguistics/gold/PossibilityModality">gold:PossibilityModality</a>
    /// </summary>
    let PossibilityModality = _prefixId.prefix "PossibilityModality"
    /// <summary>
    ///   <para>rdfs:comment : PostHodiernalFutureTense locates the situation in question after the span that is culturally defined as 'today' [Bybee, Perkins and Pagliuca 1994: 247].</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : PostHodiernalFutureTense</para>
    ///   <a href="http://purl.org/linguistics/gold/PostHodiernalFutureTense">gold:PostHodiernalFutureTense</a>
    /// </summary>
    let PostHodiernalFutureTense = _prefixId.prefix "PostHodiernalFutureTense"
    /// <summary>
    ///   <para>rdfs:comment : Characterizing sounds produced with the area just behind the center of the alveolar ridge as the passive articulator [Ladefoged 1997: 597].</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : Postalveolar</para>
    ///   <a href="http://purl.org/linguistics/gold/Postalveolar">gold:Postalveolar</a>
    /// </summary>
    let Postalveolar = _prefixId.prefix "Postalveolar"
    /// <summary>
    ///   <para>rdfs:comment : A postposition is an adposition that occurs after its complement [Crystal 1997: 300; Payne 1997: 86].</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : Postposition</para>
    ///   <a href="http://purl.org/linguistics/gold/Postposition">gold:Postposition</a>
    /// </summary>
    let Postposition = _prefixId.prefix "Postposition"
    /// <summary>
    ///   <para>rdfs:comment : If the agent is more topical than the patient, the direct-active clause is used.  If norm is reversed and the patient is more topical, the inverse clause is used. [Givon 1994: 23]</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : PragmaticInverseVoice</para>
    ///   <a href="http://purl.org/linguistics/gold/PragmaticInverseVoice">gold:PragmaticInverseVoice</a>
    /// </summary>
    let PragmaticInverseVoice = _prefixId.prefix "PragmaticInverseVoice"
    /// <summary>
    ///   <para>rdfs:comment : PreHodiernalPastTense locates the situation in question before that of a contrasting HodiernalPastTense. This category must be defined relative to a HodiernalPastTense. [Bybee, Perkins and Pagliuca 1994: 98]</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : PreHodiernalPastTense</para>
    ///   <a href="http://purl.org/linguistics/gold/PreHodiernalPastTense">gold:PreHodiernalPastTense</a>
    /// </summary>
    let PreHodiernalPastTense = _prefixId.prefix "PreHodiernalPastTense"
    /// <summary>
    ///   <para>rdfs:comment : Predicator is the class of syntactic words that are fundamentally relation inducing. That is, predicators license argument structure [Anderson 1997: 14]. Verbs are quintessential predicators, though other categories, such as determiners and some nouns, are also predicative in nature.</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : Predicator</para>
    ///   <a href="http://purl.org/linguistics/gold/Predicator">gold:Predicator</a>
    /// </summary>
    let Predicator = _prefixId.prefix "Predicator"
    /// <summary>
    ///   <para>rdfs:comment : An evaluative property  of a noun that indicates the speaker regards the person or object being referred to with favor or admiration.</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : PreferredEvaluative</para>
    ///   <a href="http://purl.org/linguistics/gold/PreferredEvaluative">gold:PreferredEvaluative</a>
    /// </summary>
    let PreferredEvaluative = _prefixId.prefix "PreferredEvaluative"
    /// <summary>
    ///   <para>rdfs:comment : An affix which is added to the front of a root or stem.  [Hartmann and Stork 1972: 182]</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : Prefix</para>
    ///   <a href="http://purl.org/linguistics/gold/Prefix">gold:Prefix</a>
    /// </summary>
    let Prefix = _prefixId.prefix "Prefix"
    /// <summary>
    ///   <para>rdfs:comment : An element which may be compounded to the front of a noun to signal information such as size, color, etc. [Valentine 2001: 152-154].</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : Prenoun</para>
    ///   <a href="http://purl.org/linguistics/gold/Prenoun">gold:Prenoun</a>
    /// </summary>
    let Prenoun = _prefixId.prefix "Prenoun"
    /// <summary>
    ///   <para>rdfs:comment : A preposition is an adposition that occurs before its complement [Crystal 1997: 305; Payne 1997: 86].</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : Preposition</para>
    ///   <a href="http://purl.org/linguistics/gold/Preposition">gold:Preposition</a>
    /// </summary>
    let Preposition = _prefixId.prefix "Preposition"
    /// <summary>
    ///   <para>rdfs:comment : A value of Tense Feature assigned to the designated element in the clause when the meaning selected for the clause is that intended to locate the event spoken about as simultaneous with the deictic centre of the utterance. Most commonly, this tense meaning is referred to as 'present', because in absolute tense systems the deictic centre is the moment of speech. However, in relative tense systems, where the deictic centre can be moved to any point on the time line, it is more appropriate to refer to this temporal relation as 'simultaneous'.
    /// The simultaneous temporal relation may obtain either in 'simple' or 'perfect' contexts. Modelling of this distinction originates from [Reichenbach 1947], who suggested using a third point in time, 'reference point', to capture all possible tense distinctions. In all 'simple' temporal relations, the reference point coincides with the location of the event spoken about. 'Perfect' tense meanings are created when the reference point is separated and moved away from the event time, thus altering the viewing of the temporal location of the event even though the event's actual location with respect to the deictic centre remains the same.
    /// A common instance of a simultaneous temporal relationship obtaining in a 'perfect' context occurs when the reference point is moved away from the event time and located instead before the moment of speech. The event time is still simultaneous with the moment of speech, but it is viewed against a stretch of time which began at the reference point and continues up to the moment of speech --- e.g. the English I have lived here [for ten years] --- hence the interpretation that the event which began in the past extends up to the moment of speech. In some languages (e.g. English) this tense meaning is labelled as (one of the uses of the) Present Perfect, in others (e.g. Polish) this meaning may be collapsed with the 'simple' simultaneous meaning and labelled simply as Present. [Kibort 2008c: 4-5]</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : PresentPerfectTense</para>
    ///   <a href="http://purl.org/linguistics/gold/PresentPerfectTense">gold:PresentPerfectTense</a>
    /// </summary>
    let PresentPerfectTense = _prefixId.prefix "PresentPerfectTense"
    /// <summary>
    ///   <para>rdfs:comment : A value of Tense Property assigned to the designated element in the clause when the meaning selected for the clause is that intended to locate the event spoken about as simultaneous with the deictic centre of the utterance. Most commonly, this tense meaning is referred to as 'present', because in absolute tense systems the deictic centre is the moment of speech. However, in relative tense systems, where the deictic centre can be moved to any point on the time line, it is more appropriate to refer to this temporal relation as 'simultaneous'.
    /// It is important to note --- for all tense values, but in particular for the Present Tense --- that the 'times' which are used to locate the event, the deictic centre, and the reference point, may or may not be 'points' on the time line. Conventionally, these concepts are considered neutral with regard to whether they are points or intervals of time longer than a point. In a formal model of tense meanings they could, for example, be represented as sets (of points): in order to capture temporal distinctions, the notion of an event being 'simultaneous with the moment of speech', may be understood as (the set of) event time (points) and (the set of) speech time (points) having a non-empty intersection. Hence, this semantic model of the Present Tense value may include the interpretation of the present as 'universal' or 'generic'.
    /// The simultaneous temporal relation may obtain either in 'simple' or 'perfect' contexts. Modelling of this distinction originates from [Reichenbach 1947], who suggested using a third point in time, 'reference point', to capture all possible tense distinctions. In all 'simple' temporal relations, the reference point coincides with the location of the event spoken about. 'Perfect' tense meanings are created when the reference point is separated and moved away from the event time, thus altering the viewing of the temporal location of the event even though the event's actual location with respect to the deictic centre remains the same.
    /// A common instance of a simultaneous temporal relationship obtaining in a 'perfect' context occurs when the reference point is moved away from the event time and located instead before the moment of speech. The event time is still simultaneous with the moment of speech, but it is viewed against a stretch of time which began at the reference point and continues up to the moment of speech --- e.g. the English I have lived here [for ten years] --- hence the interpretation that the event which began in the past extends up to the moment of speech. In some languages (e.g. English) this tense meaning is labelled as (one of the uses of the) Present Perfect, in others (e.g. Polish) this meaning may be collapsed with the 'simple' simultaneous meaning and labelled simply as Present.
    /// Typically, for a tense value to be labelled as Present Tense, the tense meaning has to minimally express the simultaneous temporal relationship, although it may additionally express other temporal, aspectual, or modal meanings. [Kibort 2008c: 4-5]</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : PresentTense</para>
    ///   <a href="http://purl.org/linguistics/gold/PresentTense">gold:PresentTense</a>
    /// </summary>
    let PresentTense = _prefixId.prefix "PresentTense"
    /// <summary>
    ///   <para>rdfs:comment : An element which may be compounded to the front of a verb, to signal information such as tense, direction, etc. [Valentine 2001: 154-158].</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : Preverb</para>
    ///   <a href="http://purl.org/linguistics/gold/Preverb">gold:Preverb</a>
    /// </summary>
    let Preverb = _prefixId.prefix "Preverb"
    /// <summary>
    ///   <para>rdfs:comment : A ProForm is a partOfSpeech whose members usually substitute for other constituents, including phrases, clauses, or sentences, and whose meaning is recoverable from the linguistic or extralinguistic context [Crystal 1997: 310; Schachter 1985: 24-25].</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : ProForm</para>
    ///   <a href="http://purl.org/linguistics/gold/ProForm">gold:ProForm</a>
    /// </summary>
    let ProForm = _prefixId.prefix "ProForm"
    /// <summary>
    ///   <para>rdfs:comment : A proverb (frequently written "pro-verb") is a ProForm that substitutes for a verb or verb phrase. [Schachter 1985: 34]</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : ProVerb</para>
    ///   <a href="http://purl.org/linguistics/gold/ProVerb">gold:ProVerb</a>
    /// </summary>
    let ProVerb = _prefixId.prefix "ProVerb"
    /// <summary>
    ///   <para>rdfs:comment : A Proadjective is a ProForm that substitutes for an adjective or adjective phrase. [Crystal 1997: 310]</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : Proadjective</para>
    ///   <a href="http://purl.org/linguistics/gold/Proadjective">gold:Proadjective</a>
    /// </summary>
    let Proadjective = _prefixId.prefix "Proadjective"
    /// <summary>
    ///   <para>rdfs:comment : A Proadverb is a Proform that substitutes for an adverb or other expression having an adverbial function. [Crystal 1997: 310]</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : Proadverb</para>
    ///   <a href="http://purl.org/linguistics/gold/Proadverb">gold:Proadverb</a>
    /// </summary>
    let Proadverb = _prefixId.prefix "Proadverb"
    /// <summary>
    ///   <para>rdfs:comment : The class of things that happen and have temporal parts or stages. Examples include extended events like a football match or a race, actions like pursuing and reading, and biological processes. The formal definition is: anything that occurs in time but is not an object. Note that a process may have participants 'inside' it which are objects, such as the players in a football match. In a 4D ontology, a process is something whose spatiotemporal extent is thought of as dividing into temporal stages roughly perpendicular to the time-axis. [SUMO 2010]</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : Process</para>
    ///   <a href="http://purl.org/linguistics/gold/Process">gold:Process</a>
    /// </summary>
    let Process = _prefixId.prefix "Process"
    /// <summary>
    ///   <para>rdfs:comment : A derivational morpheme that derives transitives from other transitives or intransitive verb.</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : Processive</para>
    ///   <a href="http://purl.org/linguistics/gold/Processive">gold:Processive</a>
    /// </summary>
    let Processive = _prefixId.prefix "Processive"
    /// <summary>
    ///   <para>rdfs:comment : A proclitic is a clitic that precedes the lexical unit to which it is phonologically joined [Crystal 1980: 64; Hartmann and Stork 1972: 185; Pei and Gaynor 1954: 176].</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : Proclitic</para>
    ///   <a href="http://purl.org/linguistics/gold/Proclitic">gold:Proclitic</a>
    /// </summary>
    let Proclitic = _prefixId.prefix "Proclitic"
    /// <summary>
    ///   <para>rdfs:comment : A value of Aspect Property (also called Nonstative aspect) assigned to the designated element in the clause when the meaning selected for the clause is that which indicates that the situation spoken about has internal temporal structure, it cannot be regarded as habitual, and reference is made to this situation in progress. Hence, progressiveness can be defined as the combination of progressive meaning with nonstative meaning, and it can be regarded as a sub-type of continuousness (which, in turn, is a sub-type of imperfectivity). Since languages have different criteria for classifying predicates as stative or not, they may have different rules for determining when explicitly progressive forms can be used.
    ///
    /// Typically, for an aspect value to be labelled as Progressive, the aspectual meaning has to minimally express progressiveness, although it may additionally express other temporal, aspectual, or modal meanings, or actionality distinctions. [Kibort 2008c: 8]</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : ProgressiveAspect</para>
    ///   <a href="http://purl.org/linguistics/gold/ProgressiveAspect">gold:ProgressiveAspect</a>
    /// </summary>
    let ProgressiveAspect = _prefixId.prefix "ProgressiveAspect"
    /// <summary>
    ///   <para>rdfs:comment : A passive in Irish  in which the preposition "at" is used, and a semantic meaning of progressive tense is found [Noonan 1994: 280].</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : ProgressivePassiveVoice</para>
    ///   <a href="http://purl.org/linguistics/gold/ProgressivePassiveVoice">gold:ProgressivePassiveVoice</a>
    /// </summary>
    let ProgressivePassiveVoice = _prefixId.prefix "ProgressivePassiveVoice"
    /// <summary>
    ///   <para>rdfs:comment : Prohibitive mood is a directive mood that signals a prohibition. It is distinguished by the use of a negated imperative sentence that employs a negative marker distinct from that used in declarative sentences, or a verb form different from that of the imperative. [SIL International 2004]</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : ProhibitiveMood</para>
    ///   <a href="http://purl.org/linguistics/gold/ProhibitiveMood">gold:ProhibitiveMood</a>
    /// </summary>
    let ProhibitiveMood = _prefixId.prefix "ProhibitiveMood"
    /// <summary>
    ///   <para>rdfs:comment : Involves promotion of the topical proximate-patient to subjecthood [Givon 1994: 24].</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : PromotionalInverseVoice</para>
    ///   <a href="http://purl.org/linguistics/gold/PromotionalInverseVoice">gold:PromotionalInverseVoice</a>
    /// </summary>
    let PromotionalInverseVoice = _prefixId.prefix "PromotionalInverseVoice"
    /// <summary>
    ///   <para>rdfs:comment : A Pronoun is a ProForm which functions like a noun and substitutes for a noun or  noun phrase [Crystal 1997: 312].</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : Pronominal</para>
    ///   <a href="http://purl.org/linguistics/gold/Pronominal">gold:Pronominal</a>
    /// </summary>
    let Pronominal = _prefixId.prefix "Pronominal"
    /// <summary>
    ///   <para>rdfs:comment : ProperNoun, also referred to as proper names, is the class of nouns that are used to address particular persons or culturally significant personages or places. They refer to specific entities and are not usually with articles, modifiers, possessors. [Payne 1997: 39]</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : ProperNoun</para>
    ///   <a href="http://purl.org/linguistics/gold/ProperNoun">gold:ProperNoun</a>
    /// </summary>
    let ProperNoun = _prefixId.prefix "ProperNoun"
    /// <summary>
    ///   <para>rdfs:comment : An articulatory characteristic resulting from protrusion of the lips, often resulting in the appearance of a small labial cavity forward of the teeth and bounded at the front by the inside surfaces of the lips.  Often occurring with lip rounding, the protruded quality modifies the basic articulation by extending the length of the vocal tract and altering its cross-section, resulting in lowered frequencies on all formants.  Back rounded vowels are commonly more protruded than front rounded vowels. [Brosnahan and Malmberg 1976: 43, 67; Clark, Yallop and Fletcher 2007: 26, 64]</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : Protruded</para>
    ///   <a href="http://purl.org/linguistics/gold/Protruded">gold:Protruded</a>
    /// </summary>
    let Protruded = _prefixId.prefix "Protruded"
    /// <summary>
    ///   <para>rdfs:comment : Pulmonic refers to an air-stream mechanism wherein the air is generated in the lungs and pushed out under the control of the respiratory muscles. [Ladefoged 2000: 122]</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : PulmonicProperty</para>
    ///   <a href="http://purl.org/linguistics/gold/PulmonicProperty">gold:PulmonicProperty</a>
    /// </summary>
    let PulmonicProperty = _prefixId.prefix "PulmonicProperty"
    /// <summary>
    ///   <para>rdfs:comment : A speaker may report an event as occurring once only (semelfactive) or several times (iterative); he may view it as a specific event or as part of a general habit of carrying out similar events; he may also differentiate between different degrees of frequency with which the event occurs. The markers that a given language provides for one or more of these meaning distinctions can be grouped under a subcategory called “quantificational aspect”, as all of them refer to the quantitative aspect of the event concerned. [Bhat 1999: 53]</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : QuantificationalAspect</para>
    ///   <a href="http://purl.org/linguistics/gold/QuantificationalAspect">gold:QuantificationalAspect</a>
    /// </summary>
    let QuantificationalAspect = _prefixId.prefix "QuantificationalAspect"
    /// <summary>
    ///   <para>rdfs:comment : A quantifier is a determiner that expresses a referent's definite or indefinite  number or amount. A quantifier functions as a modifier of a noun, or a pronoun. [Crystal 1997: 317]</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : Quantifier</para>
    ///   <a href="http://purl.org/linguistics/gold/Quantifier">gold:Quantifier</a>
    /// </summary>
    let Quantifier = _prefixId.prefix "Quantifier"
    /// <summary>
    ///   <para>rdfs:comment : The class of place  properties used to classifiy articulatory gestures made with the root of the tongue. [Ladefoged 1997: 603]</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : RadicalProperty</para>
    ///   <a href="http://purl.org/linguistics/gold/RadicalProperty">gold:RadicalProperty</a>
    /// </summary>
    let RadicalProperty = _prefixId.prefix "RadicalProperty"
    /// <summary>
    ///   <para>rdfs:comment : Realis modality is a modality that connotes the factuality of a proposition. In its broad usage, the term realis is approximately equivalent in meaning to the term indicative, which in turn is used, narrowly, as a synonym to declarative. [SIL International 2004]</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : RealisMood</para>
    ///   <a href="http://purl.org/linguistics/gold/RealisMood">gold:RealisMood</a>
    /// </summary>
    let RealisMood = _prefixId.prefix "RealisMood"
    /// <summary>
    ///   <para>rdfs:comment : RecentPastTense locates the situation in question prior to the present moment, but by culturally and situationally defined criteria, usually within the span ranging from yesterday to a week or a few months previous [Comrie 1985: 87; Dahl 1985: 121-122].</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : RecentPastTense</para>
    ///   <a href="http://purl.org/linguistics/gold/RecentPastTense">gold:RecentPastTense</a>
    /// </summary>
    let RecentPastTense = _prefixId.prefix "RecentPastTense"
    /// <summary>
    ///   <para>rdfs:comment : Referents of plural subject do action to one another [Siewierska 1988: 257].</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : ReciprocalMiddleVoice</para>
    ///   <a href="http://purl.org/linguistics/gold/ReciprocalMiddleVoice">gold:ReciprocalMiddleVoice</a>
    /// </summary>
    let ReciprocalMiddleVoice = _prefixId.prefix "ReciprocalMiddleVoice"
    /// <summary>
    ///   <para>rdfs:comment : A reciprocal pronoun is a pronoun that expresses a mutual feeling or action among the referents of a plural subject [Crystal 1997: 323].</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : ReciprocalPronoun</para>
    ///   <a href="http://purl.org/linguistics/gold/ReciprocalPronoun">gold:ReciprocalPronoun</a>
    /// </summary>
    let ReciprocalPronoun = _prefixId.prefix "ReciprocalPronoun"
    /// <summary>
    ///   <para>rdfs:comment : ReferentialVoice entails assignment of the absolutive to certain kinds of arguments other than logical subjects (agents) and objects (patients), targeting semantic roles such as dative, benefactive, malefactive and possessor. [Klaiman 1991: 239]</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : ReferentialVoice</para>
    ///   <a href="http://purl.org/linguistics/gold/ReferentialVoice">gold:ReferentialVoice</a>
    /// </summary>
    let ReferentialVoice = _prefixId.prefix "ReferentialVoice"
    /// <summary>
    ///   <para>rdfs:comment : Subjects perform action to self [Siewierska 1988: 257].</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : ReflexiveMiddleVoice</para>
    ///   <a href="http://purl.org/linguistics/gold/ReflexiveMiddleVoice">gold:ReflexiveMiddleVoice</a>
    /// </summary>
    let ReflexiveMiddleVoice = _prefixId.prefix "ReflexiveMiddleVoice"
    /// <summary>
    ///   <para>rdfs:comment : A Passive construction which contains reflexive markings [Siewierska 1988: 257].</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : ReflexivePassiveVoice</para>
    ///   <a href="http://purl.org/linguistics/gold/ReflexivePassiveVoice">gold:ReflexivePassiveVoice</a>
    /// </summary>
    let ReflexivePassiveVoice = _prefixId.prefix "ReflexivePassiveVoice"
    /// <summary>
    ///   <para>rdfs:comment : A pronoun which is interpreted as coreferential with another nominal, usually the subject, of the sentence or clause in which it occurs. [Schachter 1985: 27]</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : ReflexivePronoun</para>
    ///   <a href="http://purl.org/linguistics/gold/ReflexivePronoun">gold:ReflexivePronoun</a>
    /// </summary>
    let ReflexivePronoun = _prefixId.prefix "ReflexivePronoun"
    /// <summary>
    ///   <para>rdfs:comment : RelativeFutureTense locates the situation in question after a contextually determined temporal reference point, regardless of the latter's relation to the moment of utterance [Comrie 1985: 69-71]. Also called FuturePerfectTense.</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : RelativeFutureTense</para>
    ///   <a href="http://purl.org/linguistics/gold/RelativeFutureTense">gold:RelativeFutureTense</a>
    /// </summary>
    let RelativeFutureTense = _prefixId.prefix "RelativeFutureTense"
    /// <summary>
    ///   <para>rdfs:comment : RelativePastTense locates the situation in question before that of a contextually determined temporal reference point [Comrie 1985: 104]. Also called PastPerfectTense.</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : RelativePastTense</para>
    ///   <a href="http://purl.org/linguistics/gold/RelativePastTense">gold:RelativePastTense</a>
    /// </summary>
    let RelativePastTense = _prefixId.prefix "RelativePastTense"
    /// <summary>
    ///   <para>rdfs:comment : A tense that expresses that a situation is simultaneous with the time of some other post-present situation. [Hollebrandse, Holt and Vet 2005: 30]</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : RelativePresentTense</para>
    ///   <a href="http://purl.org/linguistics/gold/RelativePresentTense">gold:RelativePresentTense</a>
    /// </summary>
    let RelativePresentTense = _prefixId.prefix "RelativePresentTense"
    /// <summary>
    ///   <para>rdfs:comment : A relative pronoun is a pronoun that marks a relative clause, functions grammatically within the relative clause, and is coreferential to the word modified by the relative clause [Crystal 1997: 329].</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : RelativePronoun</para>
    ///   <a href="http://purl.org/linguistics/gold/RelativePronoun">gold:RelativePronoun</a>
    /// </summary>
    let RelativePronoun = _prefixId.prefix "RelativePronoun"
    /// <summary>
    ///   <para>rdfs:comment : A relativizer is a subordinating connective that links a relative clause to its head  noun. It is distinguishable from a relative pronoun in that it does not have a nominal function within the relative clause. [Payne 1997: 332]</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : Relativizer</para>
    ///   <a href="http://purl.org/linguistics/gold/Relativizer">gold:Relativizer</a>
    /// </summary>
    let Relativizer = _prefixId.prefix "Relativizer"
    /// <summary>
    ///   <para>rdfs:comment : RemoteFutureTense locates the situation in question at a time that is considered relatively distant. It is characteristically after the span of time culturally defined as 'tomorrow'. [Dahl 1985: 121; Comrie 1985: 94]</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : RemoteFutureTense</para>
    ///   <a href="http://purl.org/linguistics/gold/RemoteFutureTense">gold:RemoteFutureTense</a>
    /// </summary>
    let RemoteFutureTense = _prefixId.prefix "RemoteFutureTense"
    /// <summary>
    ///   <para>rdfs:comment : RemotePastTense locates the situation in question prior to the present moment, usually more than a few days ago [Dahl 1985: 121; Comrie 1985: 88]. Subsumes notion of PreHesternalPast tense, which locates the situation in question before that of an opposing hesternal past tense [Bybee, Perkins, Pagliuca 1994: 98].</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : RemotePastTense</para>
    ///   <a href="http://purl.org/linguistics/gold/RemotePastTense">gold:RemotePastTense</a>
    /// </summary>
    let RemotePastTense = _prefixId.prefix "RemotePastTense"
    /// <summary>
    ///   <para>rdfs:comment : A derivational unit that derives transitives from other transitive or intransitive stems adding the meaning of repetition to the resulting form. [concept mentioned in Kibort 2008c: 9]</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : Repetitive</para>
    ///   <a href="http://purl.org/linguistics/gold/Repetitive">gold:Repetitive</a>
    /// </summary>
    let Repetitive = _prefixId.prefix "Repetitive"
    /// <summary>
    ///   <para>rdfs:comment : A term used in phonetics to refer to the backwards movement of an articulator, especially the back of the tongue towards the velum.  Retracted sounds are heard in velarization, or the centralization of front vowels.  The tongue root may also be retracted. [Crystal 2008: 398]</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : Retracted</para>
    ///   <a href="http://purl.org/linguistics/gold/Retracted">gold:Retracted</a>
    /// </summary>
    let Retracted = _prefixId.prefix "Retracted"
    /// <summary>
    ///   <para>rdfs:comment : A convention for labeling gender values. Roman numerals are often used for languages for which there is a descriptive tradition involving use of the term 'noun class' instead of 'gender', in particular in languages of the Caucasus or Bantu languages, and are particularly useful where the number of genders is large.If the 'noun classes' are involved in agreement systems, they are gender systems. Roman numerals may also be used in instances where another label is possible. In one language the gender to which nouns with male rational denotation are assigned might be called 'masculine', whereas in another language nouns with a similar denotation may be assigned to a gender with an arbitrary Roman numerical label such as 'I'. [Kibort and Corbett 2008a]</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : RomanNumeralGender</para>
    ///   <a href="http://purl.org/linguistics/gold/RomanNumeralGender">gold:RomanNumeralGender</a>
    /// </summary>
    let RomanNumeralGender = _prefixId.prefix "RomanNumeralGender"
    /// <summary>
    ///   <para>rdfs:comment : The base form of a word which cannot be further analyzed without total loss of identity. Roots may be free or bound morphemes and can be classified as simple (i.e. compositionally unanalyzable in terms of morphemes) or complex/compound (i.e. certain combinations of simple root forms), though for the latter, the term 'stem' is often used.  From a semantic point of view, the root generally carried the main component of meaning in a word. [Crystal 1997: 336]</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : Root</para>
    ///   <a href="http://purl.org/linguistics/gold/Root">gold:Root</a>
    /// </summary>
    let Root = _prefixId.prefix "Root"
    /// <summary>
    ///   <para>rdfs:comment : Salience relates to the way in which certain actants present in a situation are seized on by humans as foci of attention, with attention being paid to less salient, less individuated objects subsequently [Comrie 1989: 199]. It has been argued that salience explains the evolution of certain syntactic changes, as well as the predominance of word orders where the subject precedes the object, due to the the salience of the agent in the agent-action-patient situation [Comrie 1989; Timberlake 1977].</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : SalienceProperty</para>
    ///   <a href="http://purl.org/linguistics/gold/SalienceProperty">gold:SalienceProperty</a>
    /// </summary>
    let SalienceProperty = _prefixId.prefix "SalienceProperty"
    /// <summary>
    ///   <para>rdfs:comment : SecondHandEvidentiality, also called the quotative, encodes the fact that the speaker came to believe the content of the expression from communicating with someone else [Palmer 2001: 40].</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : SecondHandEvidentiality</para>
    ///   <a href="http://purl.org/linguistics/gold/SecondHandEvidentiality">gold:SecondHandEvidentiality</a>
    /// </summary>
    let SecondHandEvidentiality = _prefixId.prefix "SecondHandEvidentiality"
    /// <summary>
    ///   <para>rdfs:comment : SecondLanguageOnlyVariant is a language variant that has no mother tongue speakers.  It is only spoken as a a second language. One example would be the case of Callawalla (caw), which is only learned in adolescence.  [Grimes 1992: 16]</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : SecondLanguageOnlyVariety</para>
    ///   <a href="http://purl.org/linguistics/gold/SecondLanguageOnlyVariety">gold:SecondLanguageOnlyVariety</a>
    /// </summary>
    let SecondLanguageOnlyVariety = _prefixId.prefix "SecondLanguageOnlyVariety"
    /// <summary>
    ///   <para>rdfs:comment : SecondPerson is a person property that refers minimally to the addressee [Crystal 1997: 285; Cysouw 2003: 75].</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : SecondPerson</para>
    ///   <a href="http://purl.org/linguistics/gold/SecondPerson">gold:SecondPerson</a>
    /// </summary>
    let SecondPerson = _prefixId.prefix "SecondPerson"
    /// <summary>
    ///   <para>rdfs:comment : A discrete unit that can be identified in the stream of speech, either physically or auditorily. Features that extend over more than one segment, such as pitch or stress, are termed suprasegmentals. [Crystal 2003: 408–409; Hartmann</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : Segment</para>
    ///   <a href="http://purl.org/linguistics/gold/Segment">gold:Segment</a>
    /// </summary>
    let Segment = _prefixId.prefix "Segment"
    /// <summary>
    ///   <para>rdfs:comment : For natural language understanding, the process of fine-grain semantic role assignment is one of the prominent steps, which provides semantic relations between constituents. The sense and sense relations between constituents provide the core meaning of a sentence. Abstract semantic roles include thematic roles, such as agent, theme, and instrument, and secondary roles such as location, time, and manner. [Chen and You 2004: 1]</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : SemanticAssignmentSystem</para>
    ///   <a href="http://purl.org/linguistics/gold/SemanticAssignmentSystem">gold:SemanticAssignmentSystem</a>
    /// </summary>
    let SemanticAssignmentSystem = _prefixId.prefix "SemanticAssignmentSystem"
    /// <summary>
    ///   <para>rdfs:comment : If the agent outranks the patient on the relevant generic topic hierarchy, the direct-active clause is used.  If the relevant norm is reversed and the patient outranks the agent on the relevant hierarchy, the inverse clause is used. [Givon 1994: 23]</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : SemanticInverseVoice</para>
    ///   <a href="http://purl.org/linguistics/gold/SemanticInverseVoice">gold:SemanticInverseVoice</a>
    /// </summary>
    let SemanticInverseVoice = _prefixId.prefix "SemanticInverseVoice"
    /// <summary>
    ///   <para>rdfs:comment : In componential analysis, one of several features which together can be said to make up the semantic meaning of a word or utterance.  Thus 'raining' could be analyzed into the component features 'precipitation', 'liquid' (not 'solid' as in 'hail'), 'average' (not 'light' as /drizzling/ or 'heavy' as /pouring/), etc. [...] Alternative terms: semantic feature, semantic [component], semantic marker. [Hartmann and Stork 1972: 203]rdfs:comment : The class of linguistic properties that pertain to semantic units. The units that underlie our intuitions about literal meaning and are associated with the grammatical structure of a language. [Frawley 1953: 12]</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : SemanticProperty</para>
    ///   <a href="http://purl.org/linguistics/gold/SemanticProperty">gold:SemanticProperty</a>
    /// </summary>
    let SemanticProperty = _prefixId.prefix "SemanticProperty"
    /// <summary>
    ///   <para>rdfs:comment : A SemanticUnit is the class of semantics elements, or units of semantic structure (sometimes called a sememe). Semantic units serve as the meaning component of linguistic signs. A semantic unit is intended for linguistic description and no particular logical representation is implied.</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : SemanticUnit</para>
    ///   <a href="http://purl.org/linguistics/gold/SemanticUnit">gold:SemanticUnit</a>
    /// </summary>
    let SemanticUnit = _prefixId.prefix "SemanticUnit"
    /// <summary>
    ///   <para>rdfs:comment : Momentaneous, without an inherent end-point, as sneeze [Michaelis 1998: xvi].</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : SemelfactiveAspect</para>
    ///   <a href="http://purl.org/linguistics/gold/SemelfactiveAspect">gold:SemelfactiveAspect</a>
    /// </summary>
    let SemelfactiveAspect = _prefixId.prefix "SemelfactiveAspect"
    /// <summary>
    ///   <para>rdfs:comment : SignLanguage or SignSystem is referring to the system of manual communication used by certain groups as an alternative to oral communication. [Crystal 1997: 350]</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : SignedLanguage</para>
    ///   <a href="http://purl.org/linguistics/gold/SignedLanguage">gold:SignedLanguage</a>
    /// </summary>
    let SignedLanguage = _prefixId.prefix "SignedLanguage"
    /// <summary>
    ///   <para>rdfs:comment : A SignedLinguisticExpression is the signed physical form of language as distinct from either written or spoken expressions. Signed expressions are the primary means in which sign languages are tranmitted. A signed expression is  the image sequence that is produced (and perceived) during a signing event.</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : SignedLinguisticExpression</para>
    ///   <a href="http://purl.org/linguistics/gold/SignedLinguisticExpression">gold:SignedLinguisticExpression</a>
    /// </summary>
    let SignedLinguisticExpression = _prefixId.prefix "SignedLinguisticExpression"
    /// <summary>
    ///   <para>rdfs:comment : Future tense assigns a value to the designated element in the clause when the meaning selected for the clause is that intended to locate the event spoken about as posterior to the deictic centre of the utterance. Most commonly, this tense meaning is referred to as 'future', because in absolute tense systems the deictic centre is the moment of speech. However, in relative tense systems, where the deictic centre can be moved to any point on the time line, it is more appropriate to refer to this temporal relation as 'posterior'.
    ///
    /// The posterior temporal relation may obtain either in 'simple' or 'perfect' contexts. Modeling of this distinction originates from [Reichenbach 1947: 288], who suggested using a third point in time, 'reference point', to capture all possible tense distinctions. In all 'simple' temporal relations, the reference point coincides with the location of the event spoken about. [Kibort 2008c: 5]</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : SimpleFutureTense</para>
    ///   <a href="http://purl.org/linguistics/gold/SimpleFutureTense">gold:SimpleFutureTense</a>
    /// </summary>
    let SimpleFutureTense = _prefixId.prefix "SimpleFutureTense"
    /// <summary>
    ///   <para>rdfs:comment : Past tense assigns a value to the designated element in the clause when the meaning selected for the clause is that intended to locate the event spoken about as anterior to the deictic centre of the utterance. Most commonly, this tense meaning is referred to as 'past', because in absolute tense systems the deictic centre is the moment of speech. However, in relative tense systems, where the deictic centre can be moved to any point on the time line, it is more appropriate to refer to this temporal relation as 'anterior'.
    ///
    /// The anterior temporal relation may obtain either in 'simple' or 'perfect' contexts. Modeling of this distinction originates from [Reichenbach  1947: 288], who suggested using a third point in time, 'reference point', to capture all possible tense distinctions. In all 'simple' temporal relations, the reference point coincides with the location of the event spoken about . [Kibort 2008c: 4]</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : SimplePastTense</para>
    ///   <a href="http://purl.org/linguistics/gold/SimplePastTense">gold:SimplePastTense</a>
    /// </summary>
    let SimplePastTense = _prefixId.prefix "SimplePastTense"
    /// <summary>
    ///   <para>rdfs:comment : Present tense assigns a value to the designated element in the clause when the meaning selected for the clause is that intended to locate the event spoken about as simultaneous to the deictic centre of the utterance.
    ///
    /// The simultaneous temporal relation may obtain either in 'simple' or 'perfect' contexts.  Modelling of this distinction originates from [Reichenbach  1947: 288], who suggested using a third point in time, 'reference point', to capture all possible tense distinctions. In all 'simple' temporal relations, the reference point coincides with the location of the event spoken about. [Kibort 2008c: 4-5]</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : SimplePresentTense</para>
    ///   <a href="http://purl.org/linguistics/gold/SimplePresentTense">gold:SimplePresentTense</a>
    /// </summary>
    let SimplePresentTense = _prefixId.prefix "SimplePresentTense"
    /// <summary>
    ///   <para>rdfs:comment : A SimpleSpecification is a kind of FeatureSpecification whose value must be a simple linguistic attribute [Maxwell, Simons and Hayashi 2000].</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : SimpleSpecification</para>
    ///   <a href="http://purl.org/linguistics/gold/SimpleSpecification">gold:SimpleSpecification</a>
    /// </summary>
    let SimpleSpecification = _prefixId.prefix "SimpleSpecification"
    /// <summary>
    ///   <para>rdfs:comment : A temporal relation in which the events or states of proposition(s) are communicated as occurring at the same time. [SIL International 2004]</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : SimultaneousAspect</para>
    ///   <a href="http://purl.org/linguistics/gold/SimultaneousAspect">gold:SimultaneousAspect</a>
    /// </summary>
    let SimultaneousAspect = _prefixId.prefix "SimultaneousAspect"
    /// <summary>
    ///   <para>rdfs:comment : Singular refers to one member of a designated class [Crystal 1980: 245; Hartmann and Stork 1972: 210].</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : SingularNumber</para>
    ///   <a href="http://purl.org/linguistics/gold/SingularNumber">gold:SingularNumber</a>
    /// </summary>
    let SingularNumber = _prefixId.prefix "SingularNumber"
    /// <summary>
    ///   <para>rdfs:comment : SizeProperty is a physical property with two values: large and small. Languages apparently do not encode a middle value of medium, at least not in the grammar. The marking of large size is traditionally called the augmentativem that for small size the diminutive. [Frawley 1992: 126]</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : SizeProperty</para>
    ///   <a href="http://purl.org/linguistics/gold/SizeProperty">gold:SizeProperty</a>
    /// </summary>
    let SizeProperty = _prefixId.prefix "SizeProperty"
    /// <summary>
    ///   <para>rdfs:comment : SpeculativeForce indicates that the speaker considers, or 'entertains', the content of the expression. That is, it is in the realm of possibility, though the speaker does not necessarilty believe it. [Palmer 2001: 6-8, 25]</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : SpeculativeForce</para>
    ///   <a href="http://purl.org/linguistics/gold/SpeculativeForce">gold:SpeculativeForce</a>
    /// </summary>
    let SpeculativeForce = _prefixId.prefix "SpeculativeForce"
    /// <summary>
    ///   <para>rdfs:comment : One of the modes of linguistic communication. As distinct from written language, it is characterized by repetition, hesitation forms, pauses, variations in articulation, lapses, as well as differences in vocabulary and grammar.  The primary importance spoken language in the analysis, description and teaching of languages has been stressed frequently. Alternative terms: speech, conversation. [Hartmann and Stork 1972: 217]</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : SpokenLanguage</para>
    ///   <a href="http://purl.org/linguistics/gold/SpokenLanguage">gold:SpokenLanguage</a>
    /// </summary>
    let SpokenLanguage = _prefixId.prefix "SpokenLanguage"
    /// <summary>
    ///   <para>rdfs:comment : A SpokenLinguisticExpression is the physical sound form of language as distinct from either signed or spoken expressions. A spoken expression is the sound that is produced (and perceived) during a speaking event.</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : SpokenLinguisticExpression</para>
    ///   <a href="http://purl.org/linguistics/gold/SpokenLinguisticExpression">gold:SpokenLinguisticExpression</a>
    /// </summary>
    let SpokenLinguisticExpression = _prefixId.prefix "SpokenLinguisticExpression"
    /// <summary>
    ///   <para>rdfs:comment : Stem is the class of  morphological units that are analyzable into a root and possibly one or more derivational units. Stems can occur alone and are the basis for adding inflectional units. [Lyons 1977: 513, 521-526]</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : Stem</para>
    ///   <a href="http://purl.org/linguistics/gold/Stem">gold:Stem</a>
    /// </summary>
    let Stem = _prefixId.prefix "Stem"
    /// <summary>
    ///   <para>rdfs:comment : StillPresentTense is similar to PresentTense but carries the presupposition that an event or state held before the moment of utterance. In positive declarative clauses, still present tense asserts that the event or state holds at the moment of utterance [Comrie 1985, 54].</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : StillTense</para>
    ///   <a href="http://purl.org/linguistics/gold/StillTense">gold:StillTense</a>
    /// </summary>
    let StillTense = _prefixId.prefix "StillTense"
    /// <summary>
    ///   <para>rdfs:comment : A term used in the phonetic classification of speech sounds on the basis of their manner of articulation.  It refers to any sound which is produced by a complete closure in the vocal tract.  [Crystal 2008: 453]</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : Stop</para>
    ///   <a href="http://purl.org/linguistics/gold/Stop">gold:Stop</a>
    /// </summary>
    let Stop = _prefixId.prefix "Stop"
    /// <summary>
    ///   <para>rdfs:comment : A general term used in Phonetics to refer to an articulation which restricts the airstream to some degree, ranging from a complete closure to a slight narrowing. [Crystal 2008: 456]</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : StrictureProperty</para>
    ///   <a href="http://purl.org/linguistics/gold/StrictureProperty">gold:StrictureProperty</a>
    /// </summary>
    let StrictureProperty = _prefixId.prefix "StrictureProperty"
    /// <summary>
    ///   <para>rdfs:comment : A term used in (esp. classical) transformational grammar to refer to an analysis of a terminal string in terms of a labeled bracketing.  In transformational analysis, the SD identifies the input to a transformational rule: it specifies which phrase-markers are to be affected by the rule.  i.e. which will 'satisfy' or 'meet' the conditions of the rule. The terms structural analysis and structure index are also used. [Crystal 2008: 458]</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : StructuralDescription</para>
    ///   <a href="http://purl.org/linguistics/gold/StructuralDescription">gold:StructuralDescription</a>
    /// </summary>
    let StructuralDescription = _prefixId.prefix "StructuralDescription"
    /// <summary>
    ///   <para>rdfs:comment : SubablativeCase expresses that the referent of the noun it marks is the location from under which another referent is moving. It has the meaning 'from under'. Kibrik says that Archi (aqc) possesses a nominal spatial form expressing SubablativeCase, namely -L´aš [Kibrik 1998: 470].</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : SubablativeCase</para>
    ///   <a href="http://purl.org/linguistics/gold/SubablativeCase">gold:SubablativeCase</a>
    /// </summary>
    let SubablativeCase = _prefixId.prefix "SubablativeCase"
    /// <summary>
    ///   <para>rdfs:comment : SuballativeCase expresses that  something is moving toward the region that is under the referent of the noun it marks. It has the meaning 'towards the region that is under'. Kibrik says that Archi (aqc) possesses a nominal spatial form expressing SuballativeCase, namely -L´aši [Kibrik 1998: 470].</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : SuballativeCase</para>
    ///   <a href="http://purl.org/linguistics/gold/SuballativeCase">gold:SuballativeCase</a>
    /// </summary>
    let SuballativeCase = _prefixId.prefix "SuballativeCase"
    /// <summary>
    ///   <para>rdfs:comment : SubessiveCase expresses that the referent of the noun it marks is the location under which another referent exists. It has the meaning of 'under' or 'beneath'. Kibrik says that Archi (aqc) possesses a nominal spatial form expressing SubessiveCase, namely -L´ [Kibrik 1998: 470].</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : SubessiveCase</para>
    ///   <a href="http://purl.org/linguistics/gold/SubessiveCase">gold:SubessiveCase</a>
    /// </summary>
    let SubessiveCase = _prefixId.prefix "SubessiveCase"
    /// <summary>
    ///   <para>rdfs:comment : SubjunctiveMood is used to express '"states of affairs" whose occurrence could easily be denied or affirmed, but instead is left unasserted.' [Lavandera 1983: 211]</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : SubjunctiveMood</para>
    ///   <a href="http://purl.org/linguistics/gold/SubjunctiveMood">gold:SubjunctiveMood</a>
    /// </summary>
    let SubjunctiveMood = _prefixId.prefix "SubjunctiveMood"
    /// <summary>
    ///   <para>rdfs:comment : Characterizing sounds produced by the underside of the tip of the tongue  [Ladefoged 1997: 596].</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : Sublaminal</para>
    ///   <a href="http://purl.org/linguistics/gold/Sublaminal">gold:Sublaminal</a>
    /// </summary>
    let Sublaminal = _prefixId.prefix "Sublaminal"
    /// <summary>
    ///   <para>rdfs:comment : In certain languages (notably, languages of the Finno-Urgic family), a declensional case having the same denotation as in English the use of the contruction "from below" before a substantive. [Pei and Gaynor 1980: 203-204] Kibrik says that Archi (aqc) possesses a nominal spatial form expressing SublativeCase, namely -L´ak [Kibrik 1998: 470].</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : SublativeCase</para>
    ///   <a href="http://purl.org/linguistics/gold/SublativeCase">gold:SublativeCase</a>
    /// </summary>
    let SublativeCase = _prefixId.prefix "SublativeCase"
    /// <summary>
    ///   <para>rdfs:comment : A clause which does not constitute a complete sentence in itself, but must be connected with or attached to an independent clause. [Pei and Gaynor 1980: 206]</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : SubordinateClause</para>
    ///   <a href="http://purl.org/linguistics/gold/SubordinateClause">gold:SubordinateClause</a>
    /// </summary>
    let SubordinateClause = _prefixId.prefix "SubordinateClause"
    /// <summary>
    ///   <para>rdfs:comment : A subordinating connective is a connective that links constructions by making one of them a constituent of another. The subordinating conjunction typically marks the incorporated constituent. [Crystal 1997: 370]</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : SubordinatingConnective</para>
    ///   <a href="http://purl.org/linguistics/gold/SubordinatingConnective">gold:SubordinatingConnective</a>
    /// </summary>
    let SubordinatingConnective = _prefixId.prefix "SubordinatingConnective"
    /// <summary>
    ///   <para>rdfs:comment : A substantive is a member of the syntactic class in which the names of physical, concrete, relatively unchanging experiences are most typically found whose members may act as subjects and  objects, and most of whose members have inherently determined grammatical  gender (in languages which inflect for gender) [Crystal 1997: 264; Givon 1984: 51-52; Payne 1997: 33].</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : Substantive</para>
    ///   <a href="http://purl.org/linguistics/gold/Substantive">gold:Substantive</a>
    /// </summary>
    let Substantive = _prefixId.prefix "Substantive"
    /// <summary>
    ///   <para>rdfs:comment : SubterminativeCase expresses the notion of something moving into the region under the referent of the noun it marks, but not through that region. It has the meaning 'into the region under'. Kibrik says that Archi (aqc) possesses a nominal spatial form expressing SubterminativeCase, namely -L´akana [Kibrik 1998: 470].</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : SubterminativeCase</para>
    ///   <a href="http://purl.org/linguistics/gold/SubterminativeCase">gold:SubterminativeCase</a>
    /// </summary>
    let SubterminativeCase = _prefixId.prefix "SubterminativeCase"
    /// <summary>
    ///   <para>rdfs:comment : SubtranslativeCase expresses the notion of something moving along a trajectory underneath the referent of the noun it marks. It has the meaning 'along the region underneath'. Kibrik says that Archi (aqc) possesses a nominal spatial form expressing SubtranslativeCase, namely -L´aXut [Kibrik 1998: 470].</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : SubtranslativeCase</para>
    ///   <a href="http://purl.org/linguistics/gold/SubtranslativeCase">gold:SubtranslativeCase</a>
    /// </summary>
    let SubtranslativeCase = _prefixId.prefix "SubtranslativeCase"
    /// <summary>
    ///   <para>rdfs:comment : An affix, consisting of a letter, syllable, or syllables, that follows a stem or word, modifying its meaning. Suffixes may be inflectional or derivational. [Crystal 1987: 431; Hartmann and Stork 1972: 225; Pei and Gaynor 1980: 207]</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : Suffix</para>
    ///   <a href="http://purl.org/linguistics/gold/Suffix">gold:Suffix</a>
    /// </summary>
    let Suffix = _prefixId.prefix "Suffix"
    /// <summary>
    ///   <para>rdfs:comment : Superablative expresses that  the referent of the noun it marks is at the location from over which another referent is moving. It has the meaning 'from over'. Kibrik says that Archi (aqc) possesses a nominal spatial form expressing SuperablativeCase, namely -t:iš. He gives the example 'aInš-li-t:-iš' ('aIns' = 'apple'). [Kibrik 1998: 470-471]</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : SuperablativeCase</para>
    ///   <a href="http://purl.org/linguistics/gold/SuperablativeCase">gold:SuperablativeCase</a>
    /// </summary>
    let SuperablativeCase = _prefixId.prefix "SuperablativeCase"
    /// <summary>
    ///   <para>rdfs:comment : SuperallativeCase expresses that something is moving toward the region that is above the referent of the noun it marks. It has the meaning 'towards the region that is over'. Kibrik says that Archi (aqc) possesses a nominal spatial form expressing SuperallativeCase, namely -t:iši [Kibrik 1998: 470].</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : SuperallativeCase</para>
    ///   <a href="http://purl.org/linguistics/gold/SuperallativeCase">gold:SuperallativeCase</a>
    /// </summary>
    let SuperallativeCase = _prefixId.prefix "SuperallativeCase"
    /// <summary>
    ///   <para>rdfs:comment : SuperessiveCase expresses that  the referent of the noun it marks is the location on which another referent exists. It has the meaning of 'on' or 'upon'. [Pei and Gaynor 1954: 207] Kibrik says that Archi (aqc) possesses a nominal spatial form expressing SuperessiveCase, namely -t. He gives the example 'aInš-li-t' ('aIns' = 'apple'). [Kibrik 1998: 470-471]</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : SuperessiveCase</para>
    ///   <a href="http://purl.org/linguistics/gold/SuperessiveCase">gold:SuperessiveCase</a>
    /// </summary>
    let SuperessiveCase = _prefixId.prefix "SuperessiveCase"
    /// <summary>
    ///   <para>rdfs:comment : That form of an adjective that expresses that the thing to which it refers possesses a certain quality or attribute to a greater extent than any other thing [Hartmann and Stork 1972: 60; Pei and Gaynor 1980: 207].</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : SuperlativeAdjective</para>
    ///   <a href="http://purl.org/linguistics/gold/SuperlativeAdjective">gold:SuperlativeAdjective</a>
    /// </summary>
    let SuperlativeAdjective = _prefixId.prefix "SuperlativeAdjective"
    /// <summary>
    ///   <para>rdfs:comment : SuperlativeCase expresses that  the referent of the noun it marks is the location onto which another referent is moving. It has the meaning of 'onto'. Kibrik says that Archi (aqc) possesses a nominal spatial form expressing SuperlativeCase, namely -t:ik. He gives the example 'aInš-li-t:-ik' ('aIns' = 'apple'). [Kibrik 1998: 470-471] Unfortunate name clash with 'Superlative' as a property of adjectives.</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : SuperlativeCase</para>
    ///   <a href="http://purl.org/linguistics/gold/SuperlativeCase">gold:SuperlativeCase</a>
    /// </summary>
    let SuperlativeCase = _prefixId.prefix "SuperlativeCase"
    /// <summary>
    ///   <para>rdfs:comment : SuperterminativeCase expresses the notion of something moving into the region over the referent of the noun it marks, but not through that region. It has the meaning 'into the region over'. Kibrik says that Archi (aqc) possesses a nominal spatial form expressing SuperterminativeCase, namely -t:ikana [Kibrik 1998: 470].</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : SuperterminativeCase</para>
    ///   <a href="http://purl.org/linguistics/gold/SuperterminativeCase">gold:SuperterminativeCase</a>
    /// </summary>
    let SuperterminativeCase = _prefixId.prefix "SuperterminativeCase"
    /// <summary>
    ///   <para>rdfs:comment : SupertranslativeCase expresses the notion of something moving along a trajectory above the referent of the noun it marks. It has the meaning 'along the region over'. Kibrik says that Archi (aqc) possesses a nominal spatial form expressing SupertranslativeCase, namely -t:iXut [Kibrik 1998: 470].</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : SupertranslativeCase</para>
    ///   <a href="http://purl.org/linguistics/gold/SupertranslativeCase">gold:SupertranslativeCase</a>
    /// </summary>
    let SupertranslativeCase = _prefixId.prefix "SupertranslativeCase"
    /// <summary>
    ///   <para>rdfs:comment : The supralaryngeal node dominates the activity of all of the articulators except stiffening and slacking of the vocal folds. For consonants it can be viewed as the default node which comes into play when the supranasal node below it is deactivated. In the case of sounds produced by an articulator dominated by this node, the only possible segments are those which are traditionally classified as [-consonantal]. It is not necessary to specify manner features for sounds dominated by the supralaryngeal node, because they are redundantly determined. [Keyser and Stevens 1994: 216]</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : SupraLaryngealProperty</para>
    ///   <a href="http://purl.org/linguistics/gold/SupraLaryngealProperty">gold:SupraLaryngealProperty</a>
    /// </summary>
    let SupraLaryngealProperty = _prefixId.prefix "SupraLaryngealProperty"
    /// <summary>
    ///   <para>rdfs:comment : Phonetic features extending over more than one segment, such as stress, length, tone, and intonation, which are not properties of single consonants or vowels [Crystal 1987: 431; Ladefoged 2000: 276].</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : Suprasegmental</para>
    ///   <a href="http://purl.org/linguistics/gold/Suprasegmental">gold:Suprasegmental</a>
    /// </summary>
    let Suprasegmental = _prefixId.prefix "Suprasegmental"
    /// <summary>
    ///   <para>rdfs:comment : Ladefoged contends that there is no satisfactory definition for this unit of speech, but that syllables seem to be necessary units in the mental organization and production of utterances. However, Crystal defines the syllable as an element of speech that acts as a unit of rhythm, consisting of a vowel, syllabic, or vowel/consonant combination. [Crystal 1987: 431; Ladefoged 2000: 276]</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : Syllable</para>
    ///   <a href="http://purl.org/linguistics/gold/Syllable">gold:Syllable</a>
    /// </summary>
    let Syllable = _prefixId.prefix "Syllable"
    /// <summary>
    ///   <para>rdfs:comment : Properties may be stated to be symmetric. If a property is symmetric, then if the pair (x,y) is an instance of the symmetric property P, then the pair (y,x) is also an instance of P. For example, friend may be stated to be a symmetric property. Then a reasoner that is given that Frank is a friend of Deborah can deduce that Deborah is a friend of Frank. [McGuinness</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : SymmetricProperty</para>
    ///   <a href="http://purl.org/linguistics/gold/SymmetricProperty">gold:SymmetricProperty</a>
    /// </summary>
    let SymmetricProperty = _prefixId.prefix "SymmetricProperty"
    /// <summary>
    ///   <para>rdfs:comment : SyntacticArgument is the class of syntactic words that are fundamentally referable and  non-relational [Anderson 1997: 15]. Proper names are the quintessential arguments, though pronouns and nouns possess argument properties.</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : SyntacticArgument</para>
    ///   <a href="http://purl.org/linguistics/gold/SyntacticArgument">gold:SyntacticArgument</a>
    /// </summary>
    let SyntacticArgument = _prefixId.prefix "SyntacticArgument"
    /// <summary>
    ///   <para>rdfs:comment : SyntacticConstruction is the class of grammar units that have syntactic structure, i.e., consisting of more than one syntactic word or construction in a syntactic configuration [Crystal 1980: 85-86].</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : SyntacticConstruction</para>
    ///   <a href="http://purl.org/linguistics/gold/SyntacticConstruction">gold:SyntacticConstruction</a>
    /// </summary>
    let SyntacticConstruction = _prefixId.prefix "SyntacticConstruction"
    /// <summary>
    ///   <para>rdfs:comment : SyntacticUnit (also called constituent) is a 'term in grammatical analysis for a linguistic unit which is a functional component of a larger construction. Based on a combination of intuitive and formal (e.g. distributional) criteria, a sentence can be analysed into a series of constituents, such as subject + predicate, or NP+VP, etc. [Crystal 2003: 99]</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : SyntacticUnit</para>
    ///   <a href="http://purl.org/linguistics/gold/SyntacticUnit">gold:SyntacticUnit</a>
    /// </summary>
    let SyntacticUnit = _prefixId.prefix "SyntacticUnit"
    /// <summary>
    ///   <para>rdfs:comment : It can be moved about in the sentence, or at least its position relative to other constituents can be altered by inserting new material.  It cannot be interrupted or its parts reordered. [Cruse 2000: 87-88]rdfs:comment : SyntacticWord is the class of syntactic units occupying the lowest position in a syntactic construction.  They are the largest units resistant to insertion of new constituents within their boundaries; or they are the smallest constituents that can be moved within a sentence without making the sentence ungrammatical. [SIL International 2004]</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : SyntacticWord</para>
    ///   <a href="http://purl.org/linguistics/gold/SyntacticWord">gold:SyntacticWord</a>
    /// </summary>
    let SyntacticWord = _prefixId.prefix "SyntacticWord"
    /// <summary>
    ///   <para>rdfs:comment : A Tap 'is a sound in which a brief contact between the articulators is made by moving the active articulator directly towards the roof of the mouth.' A tap is 'usually coronal. ... Taps are most typically made by a direct movement of the tongue tip to a contact location in the dental or alveolar region.' [Ladefoged 1996: 231]</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : Tap</para>
    ///   <a href="http://purl.org/linguistics/gold/Tap">gold:Tap</a>
    /// </summary>
    let Tap = _prefixId.prefix "Tap"
    /// <summary>
    ///   <para>rdfs:comment : Taxon is the class of scientific categories used to create a taxonomy and determined according to scientific principles in a given domain, e.g., Biology or Linguistics.</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : Taxon</para>
    ///   <a href="http://purl.org/linguistics/gold/Taxon">gold:Taxon</a>
    /// </summary>
    let Taxon = _prefixId.prefix "Taxon"
    /// <summary>
    ///   <para>rdfs:comment : Following [Comrie 1985: vii], we take tense to be the grammaticalisation of location in time. Tense Property is assigned to clauses on the basis of semantics: a tense value is selected for the clause from the range of tense values available in the given language. Tense Property is typically realised on the verb, but it may be found expressed multiply on different elements in the same clause. For example, tense may be found on more than one element of the verbal complex (e.g. in Kayardild [Evans 2003] or  Paamese [Crowley 2002: 68], or on verbs as well as on certain spatial and temporal adverbs and certain prepositions in the same clause (e.g. in Malagasy [Randriamasimanana 1981: 355-367],  [Keenan and Polinsky 1998: 566-567].
    ///
    /// In the given language, the values of the Tense Property are assigned to the designated elements as a consequence of semantic choice, and all the available options of particular tense values expressing particular tense meanings can be described with a Tense Assignment System for that language. Since no languages have been found for which tense values are assigned by a Tense Distribution System (i.e. contextually, through agreement or government), Tense Property is not a Morphosyntactic Property. Instead, it is a Morphosemantic Property only.</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : TenseProperty</para>
    ///   <a href="http://purl.org/linguistics/gold/TenseProperty">gold:TenseProperty</a>
    /// </summary>
    let TenseProperty = _prefixId.prefix "TenseProperty"
    /// <summary>
    ///   <para>rdfs:comment : A vocabulary item which has a special meaning in a particular subject field, e.g. 'sound' or 'voice' in phonetics, or 'butterfly' in swimming. [Hartmann and Stork 1972: 236]</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : Term</para>
    ///   <a href="http://purl.org/linguistics/gold/Term">gold:Term</a>
    /// </summary>
    let Term = _prefixId.prefix "Term"
    /// <summary>
    ///   <para>rdfs:comment : Denotes the termination of an event [Bhat 1999: 92].</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : TerminativeAspect</para>
    ///   <a href="http://purl.org/linguistics/gold/TerminativeAspect">gold:TerminativeAspect</a>
    /// </summary>
    let TerminativeAspect = _prefixId.prefix "TerminativeAspect"
    /// <summary>
    ///   <para>rdfs:comment : Cases expressing spatial relations (also semantic) can be grouped into four broad directional classes: cases expressing location ('at'), goal ('to'), source ('from'), and path ('through, along'). The basic terms for these are: locative, allative, ablative, and perlative. Additionally, the label terminative is used for a movement that goes all the way to its endpoint, and orientative - for a movement that goes only in the direction of its goal. [Kibort 2008b]</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : TerminativeCase</para>
    ///   <a href="http://purl.org/linguistics/gold/TerminativeCase">gold:TerminativeCase</a>
    /// </summary>
    let TerminativeCase = _prefixId.prefix "TerminativeCase"
    /// <summary>
    ///   <para>rdfs:comment : A set of scientific terms used as part of an annotation system, usually the standard terms from a particular linguistic theory.</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : Termset</para>
    ///   <a href="http://purl.org/linguistics/gold/Termset">gold:Termset</a>
    /// </summary>
    let Termset = _prefixId.prefix "Termset"
    /// <summary>
    ///   <para>rdfs:comment : TertiaryPredicator is the class of syntactic words that take three required arguments.</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : TertiaryPredicator</para>
    ///   <a href="http://purl.org/linguistics/gold/TertiaryPredicator">gold:TertiaryPredicator</a>
    /// </summary>
    let TertiaryPredicator = _prefixId.prefix "TertiaryPredicator"
    /// <summary>
    ///   <para>rdfs:comment : In Web Ontology Language, Thing is the superclass of all classes. The most basic concepts in a domain should correspond to classes that are the roots of various taxonomic trees. Every individual in the OWL world is a member of the class owl:Thing. Thus each user-defined class is implicitly a subclass of owl:Thing. Domain specific root classes are defined by simply declaring a named class. [Smith, Welty and McGuinness 2004]</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : Thing</para>
    ///   <a href="http://purl.org/linguistics/gold/Thing">gold:Thing</a>
    /// </summary>
    let Thing = _prefixId.prefix "Thing"
    /// <summary>
    ///   <para>rdfs:comment : Third Person is a person property that refers to the non-participant (other than the speaker and the addressee) [Crystal 1997: 285].</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : ThirdPerson</para>
    ///   <a href="http://purl.org/linguistics/gold/ThirdPerson">gold:ThirdPerson</a>
    /// </summary>
    let ThirdPerson = _prefixId.prefix "ThirdPerson"
    /// <summary>
    ///   <para>rdfs:comment : ThirdPersonObviative is a person property that  refers to one or more non-participants that are in some way further removed from the speaker than other non-particpants. Contrasts with ThirdPersonProximative. [Kibort 2008a]</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : ThirdPersonObviative</para>
    ///   <a href="http://purl.org/linguistics/gold/ThirdPersonObviative">gold:ThirdPersonObviative</a>
    /// </summary>
    let ThirdPersonObviative = _prefixId.prefix "ThirdPersonObviative"
    /// <summary>
    ///   <para>rdfs:comment : Refers to one or more non-participants that are in some way distinct/closer to the speaker than other non-participants. Third person proximative contrasts with third person obviative. Often called 'Third Person Proximate' or '4th person'. [Kibort 2008a]</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : ThirdPersonProximative</para>
    ///   <a href="http://purl.org/linguistics/gold/ThirdPersonProximative">gold:ThirdPersonProximative</a>
    /// </summary>
    let ThirdPersonProximative = _prefixId.prefix "ThirdPersonProximative"
    /// <summary>
    ///   <para>rdfs:comment : TimitiveMood encodes that the speaker fears something expressed in what is said [Palmer 2001: 13, 22].</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : TimitiveMood</para>
    ///   <a href="http://purl.org/linguistics/gold/TimitiveMood">gold:TimitiveMood</a>
    /// </summary>
    let TimitiveMood = _prefixId.prefix "TimitiveMood"
    /// <summary>
    ///   <para>rdfs:comment : A stress or tonal element which in a tone language distinguishes two otherwise identical words or forms. [Hartmann and Stork 1972: 238; Pei and Gaynor 1980: 218]</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : Toneme</para>
    ///   <a href="http://purl.org/linguistics/gold/Toneme">gold:Toneme</a>
    /// </summary>
    let Toneme = _prefixId.prefix "Toneme"
    /// <summary>
    ///   <para>rdfs:comment : Those grammatical features which are used systematically to express certain relationships between the participants in a communicative situation and the actions, states, or circumstances in which they are involved [Hartmann</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : TransitiveProperty</para>
    ///   <a href="http://purl.org/linguistics/gold/TransitiveProperty">gold:TransitiveProperty</a>
    /// </summary>
    let TransitiveProperty = _prefixId.prefix "TransitiveProperty"
    /// <summary>
    ///   <para>rdfs:comment : A transitive verb is a verb that takes a direct object, and describes a relation between two participants [Crystal 1997: 397; Payne 1997: 171].</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : TransitiveVerb</para>
    ///   <a href="http://purl.org/linguistics/gold/TransitiveVerb">gold:TransitiveVerb</a>
    /// </summary>
    let TransitiveVerb = _prefixId.prefix "TransitiveVerb"
    /// <summary>
    ///   <para>rdfs:comment : A derivational unit that derives transitive verbs from intransitive verb (stems).</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : Transitivizer</para>
    ///   <a href="http://purl.org/linguistics/gold/Transitivizer">gold:Transitivizer</a>
    /// </summary>
    let Transitivizer = _prefixId.prefix "Transitivizer"
    /// <summary>
    ///   <para>rdfs:comment : TranslativeCase expresses that the referent of the noun, or the quality of the adjective, that it marks is the result of a process of change [Lyons 1968: 299-301; Sebeok 1946: 17; Hakulinen 1961: 70]. X along, across Y.</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : TranslativeCase</para>
    ///   <a href="http://purl.org/linguistics/gold/TranslativeCase">gold:TranslativeCase</a>
    /// </summary>
    let TranslativeCase = _prefixId.prefix "TranslativeCase"
    /// <summary>
    ///   <para>rdfs:comment : The trial is for referring to three distinct real world entities. [Corbett 2000: 21]</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : TrialNumber</para>
    ///   <a href="http://purl.org/linguistics/gold/TrialNumber">gold:TrialNumber</a>
    /// </summary>
    let TrialNumber = _prefixId.prefix "TrialNumber"
    /// <summary>
    ///   <para>rdfs:comment : The vibration of one speech organ against another, driven by the aerodynamic conditions. One of the soft moveable parts of the vocal tract is placed close enough to another surface, so that when a current of air of the right strength passes through the aperture created by this configuration, a repeating pattern of closing and opening of the flow channel occurs. [Ladefoged and Maddieson 1996: 217]</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : Trill</para>
    ///   <a href="http://purl.org/linguistics/gold/Trill">gold:Trill</a>
    /// </summary>
    let Trill = _prefixId.prefix "Trill"
    /// <summary>
    ///   <para>rdfs:comment : A term in the phonetic classification of consonant sounds on the basis of their manner of articulation: also known as trilled consonant, or a roll, 'trill' refers to any sound made by the rapid tapping of one organ of articulation against another. [Crystal 2008: 496]</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : TrillProperty</para>
    ///   <a href="http://purl.org/linguistics/gold/TrillProperty">gold:TrillProperty</a>
    /// </summary>
    let TrillProperty = _prefixId.prefix "TrillProperty"
    /// <summary>
    ///   <para>rdfs:comment : UnaryPredicator is the class of syntactic words that take only one required argument.</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : UnaryPredicator</para>
    ///   <a href="http://purl.org/linguistics/gold/UnaryPredicator">gold:UnaryPredicator</a>
    /// </summary>
    let UnaryPredicator = _prefixId.prefix "UnaryPredicator"
    /// <summary>
    ///   <para>rdfs:comment : Unaspirated refers to the configuration of glottal opening, release at the oral stricture, and vocal fold vibration in which the glottal opening gesture begins at the moment that the oral closure is made, but the maximum width of the glottal opening is reached at about the mid-point of the oral closure duration and the vocal folds return to a voicing position at about the moment of release. This typically results in a weak sounding release which lacks the burst of air characteristic of aspirated phonemes. [Ladefoged and Maddieson 1996: 66-70]</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : Unaspirated</para>
    ///   <a href="http://purl.org/linguistics/gold/Unaspirated">gold:Unaspirated</a>
    /// </summary>
    let Unaspirated = _prefixId.prefix "Unaspirated"
    /// <summary>
    ///   <para>rdfs:comment : UnattestedVariety is the class of language varieties that are posited to exist or to have existed. Examples include reconstructed languages, such as Proto-Indo-European.</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : UnattestedVariety</para>
    ///   <a href="http://purl.org/linguistics/gold/UnattestedVariety">gold:UnattestedVariety</a>
    /// </summary>
    let UnattestedVariety = _prefixId.prefix "UnattestedVariety"
    /// <summary>
    ///   <para>rdfs:comment : Vegetable gender refers to inanimates and exists in some four-way gender systems, e.g., masculine, feminine, neuter, and vegetable as in Bininj Gun-wok [Evans 2003: 202].</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : VegetableGender</para>
    ///   <a href="http://purl.org/linguistics/gold/VegetableGender">gold:VegetableGender</a>
    /// </summary>
    let VegetableGender = _prefixId.prefix "VegetableGender"
    /// <summary>
    ///   <para>rdfs:comment : Velaric refers to an air-stream mechanism wherein the air is generated by a closure at the velar position, rather than an air-stream generated by the lungs. The back of the tongue is raised against the velum, and articulations are made farther forward by the lips or front parts of the tongue, drawing air into or pushing air out of the mouth. The clicks of some African languages are produced in this way. In English, they may be heard in the 'tut tut' sound. [Crystal 1985: 325-326; Hartmann and Stork 1972: 8]</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : VelaricProperty</para>
    ///   <a href="http://purl.org/linguistics/gold/VelaricProperty">gold:VelaricProperty</a>
    /// </summary>
    let VelaricProperty = _prefixId.prefix "VelaricProperty"
    /// <summary>
    ///   <para>rdfs:comment : A unit of sentence structure consisting of a verb and the other elements closely linked to it. Traditional grammarians divided a typical sentence into two parts: a subject and a predicate. In our modern elaboration of this, the syntactic category which acts as a subject is a noun phrase, while the category acting as the predicate is a verb phrase. A verb phrase always contains a verb, and it usually contains some other material closely linked to that verb. [Trask 1999: 335] According to the valence of the verb, the number and kind of the obligatory complements may vary; in addition, any number of free complements are possible. The border between obligatory and free complementsis often difficult to draw. [Bussmann 1996: 513]</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : VerbPhrase</para>
    ///   <a href="http://purl.org/linguistics/gold/VerbPhrase">gold:VerbPhrase</a>
    /// </summary>
    let VerbPhrase = _prefixId.prefix "VerbPhrase"
    /// <summary>
    ///   <para>rdfs:comment : A Verbal is a part of speech whose members typically signal events and actions; constitute, singly or in a phrase, a minimal  predicate in a  clause; govern the number and types of other constituents which may occur in the clause; and, in inflectional languages, may be inflected for tense, aspect, voice, modality, or agreement with other constituents in person, number, or grammatical gender  [Crystal 1997: 409; Givon 1984: 52; Payne 1997: 47].</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : Verbal</para>
    ///   <a href="http://purl.org/linguistics/gold/Verbal">gold:Verbal</a>
    /// </summary>
    let Verbal = _prefixId.prefix "Verbal"
    /// <summary>
    ///   <para>rdfs:comment : An adjectival which is closely related in form and or meaning to a verb. For example, -ed and -ing forms in English which are used as adjectives. [Crystal 1985: 326; Hartmann and Stork 1972: 249; Pei and Gaynor 1980: 227]</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : VerbalAdjective</para>
    ///   <a href="http://purl.org/linguistics/gold/VerbalAdjective">gold:VerbalAdjective</a>
    /// </summary>
    let VerbalAdjective = _prefixId.prefix "VerbalAdjective"
    /// <summary>
    ///   <para>rdfs:comment : Verbal particles are a closed class of uninflected words that co-occur with certain verbs. In some cases the verbal particles may have clearly distinguishable locative or directional meanings. In some languages some or all of the verbal particles also occur as (and are historically derived from) adpositions. In other languages, however, for example Ga'anda, the verbal particles are entirely distinct from adpositions. [Schachter 1985: 45-46]</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : VerbalParticle</para>
    ///   <a href="http://purl.org/linguistics/gold/VerbalParticle">gold:VerbalParticle</a>
    /// </summary>
    let VerbalParticle = _prefixId.prefix "VerbalParticle"
    /// <summary>
    ///   <para>rdfs:comment : Verbalizer is the class of category changing units that change nouns into verbs.</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : Verbalizer</para>
    ///   <a href="http://purl.org/linguistics/gold/Verbalizer">gold:Verbalizer</a>
    /// </summary>
    let Verbalizer = _prefixId.prefix "Verbalizer"
    /// <summary>
    ///   <para>rdfs:comment : Versive refers to an intransitive verb, usually derived from an adjective but occasionally from a noun or adverb, with the meaning 'to become X'. [Edmonson 1995: 378]</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : Versive</para>
    ///   <a href="http://purl.org/linguistics/gold/Versive">gold:Versive</a>
    /// </summary>
    let Versive = _prefixId.prefix "Versive"
    /// <summary>
    ///   <para>rdfs:comment : VisualEvidentiality encodes the fact that the speaker came to believe the content of the expression through direct visual experience; they saw it [Palmer 2001: 57].</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : VisualEvidentiality</para>
    ///   <a href="http://purl.org/linguistics/gold/VisualEvidentiality">gold:VisualEvidentiality</a>
    /// </summary>
    let VisualEvidentiality = _prefixId.prefix "VisualEvidentiality"
    /// <summary>
    ///   <para>rdfs:comment : VocativeCase marks a noun whose referent is being addressed [Crystal 1980: 377; Hartmann and Stork 1972: 251; Pei and Gaynor 1954: 228].</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : VocativeCase</para>
    ///   <a href="http://purl.org/linguistics/gold/VocativeCase">gold:VocativeCase</a>
    /// </summary>
    let VocativeCase = _prefixId.prefix "VocativeCase"
    /// <summary>
    ///   <para>rdfs:comment : VoiceProperty is the class of properties that concern the grammatical encoding of the relationship between the verb and the nominals in a subject-predicate configuration. It selects a grammatically prominent syntactic constituent--subject--from the underlying semantic functions. In accusative language, the basic strategy is to select an agent as a subject [Shibatani 1988: 3]. It can be said that all voice systems mark the affectedness/nonaffectedness of sentential subjects [Klaiman 1988: 30].</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : VoiceProperty</para>
    ///   <a href="http://purl.org/linguistics/gold/VoiceProperty">gold:VoiceProperty</a>
    /// </summary>
    let VoiceProperty = _prefixId.prefix "VoiceProperty"
    /// <summary>
    ///   <para>rdfs:comment : A fundamental term used in the phonetic classification of speech sounds, referring to the auditory result of the vibration of the vocal cords. Sounds produced while the vocal cords are vibrating are voiced. [Crystal 1985: 329]</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : Voiced</para>
    ///   <a href="http://purl.org/linguistics/gold/Voiced">gold:Voiced</a>
    /// </summary>
    let Voiced = _prefixId.prefix "Voiced"
    /// <summary>
    ///   <para>rdfs:comment : A fundamental term used in the phonetic classification of speech sounds, referring to the auditory result of the vibration of the vocal cords. Sounds produced while the vocal cords are not vibrating are voiceless. [Crystal 1985: 329]</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : Voiceless</para>
    ///   <a href="http://purl.org/linguistics/gold/Voiceless">gold:Voiceless</a>
    /// </summary>
    let Voiceless = _prefixId.prefix "Voiceless"
    /// <summary>
    ///   <para>rdfs:comment : Refers to the vibratory activity of the vocal folds. Most languages have phonemic contrasts between voiced and voiceless sounds (regular vibration of the vocal folds versus no vibration of the vocal folds respectively). However, Ladefoged and Maddieson recognize five steps in the continuum of modes of vibration in the glottis, going from breathy voice - the most open setting of the vocal folds in which vibration will occur, passing through slack voice, modal voice, and stiff voice, ending with creaky voice - the most constricted setting in which vibration will occur. Each of these modes of voicing may or may not be phonemic in a given language. [Ladefoged and Maddieson 1996: 48-49]</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : VoicingProperty</para>
    ///   <a href="http://purl.org/linguistics/gold/VoicingProperty">gold:VoicingProperty</a>
    /// </summary>
    let VoicingProperty = _prefixId.prefix "VoicingProperty"
    /// <summary>
    ///   <para>rdfs:comment : VolitiveForce indicates that the speaker is willing to perform some action [Palmer 2001: 76].</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : VolitiveForce</para>
    ///   <a href="http://purl.org/linguistics/gold/VolitiveForce">gold:VolitiveForce</a>
    /// </summary>
    let VolitiveForce = _prefixId.prefix "VolitiveForce"
    /// <summary>
    ///   <para>rdfs:comment : One of the two general categories used for the classification of speech sounds, the other being consonant. Phonetically, they are sounds articulated without a complete closure in the mouth that would produce a stop or a degree of narrowing that would create audible friction; the air escapes evenly over the center of the tongue. For oral vowels, air escapes solely through the mouth. If some air is simultaneously released through the nose, the vowel is nasal. The quality of the vowel sound is affected by the shape of the oral resonance chamber, chiefly influenced by the position of the lips and the position of the tongue. [Crystal 1985: 330; Hartmann and Stork 1972: 253]</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : Vowel</para>
    ///   <a href="http://purl.org/linguistics/gold/Vowel">gold:Vowel</a>
    /// </summary>
    let Vowel = _prefixId.prefix "Vowel"
    /// <summary>
    ///   <para>rdfs:comment : WeakObligativeModality indicates that an agent is under a moral obligation to perform the action expressed by the predicate [Bybee, Perkins and Pagliuca 1994: 186-187].</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : WeakObligativeModality</para>
    ///   <a href="http://purl.org/linguistics/gold/WeakObligativeModality">gold:WeakObligativeModality</a>
    /// </summary>
    let WeakObligativeModality = _prefixId.prefix "WeakObligativeModality"
    /// <summary>
    ///   <para>rdfs:comment : One of the means or modes of linguistic communication.  As distinct from spoken language, it does not usually represent all features of speech such as stress and pitch, and lacks the redundancy and lapses of spoken conversation (written dialogue and reading aloud are more akin to written than to spoken language). Also reference orthography. [Hartmann and Stork 1972: 258]</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : WrittenLanguage</para>
    ///   <a href="http://purl.org/linguistics/gold/WrittenLanguage">gold:WrittenLanguage</a>
    /// </summary>
    let WrittenLanguage = _prefixId.prefix "WrittenLanguage"
    /// <summary>
    ///   <para>rdfs:comment : A WrittenLinguisticExpression is the written physical form of language as distinct from either signed or spoken expressions. A written expression is the physical product of the writing process.</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : WrittenLinguisticExpression</para>
    ///   <a href="http://purl.org/linguistics/gold/WrittenLinguisticExpression">gold:WrittenLinguisticExpression</a>
    /// </summary>
    let WrittenLinguisticExpression = _prefixId.prefix "WrittenLinguisticExpression"
    /// <summary>
    ///   <para>rdfs:comment : ZeroPlacePredicator is the class of syntactic words that need not take any arguments, but act as predicators nevertheless.</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : ZeroPlacePredicator</para>
    ///   <a href="http://purl.org/linguistics/gold/ZeroPlacePredicator">gold:ZeroPlacePredicator</a>
    /// </summary>
    let ZeroPlacePredicator = _prefixId.prefix "ZeroPlacePredicator"
    /// <summary>
    ///   <para>rdfs:comment : The abbreviated form representing a scientific term, e.g., ACC, 2, CL.</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : abbreviation</para>
    ///   <a href="http://purl.org/linguistics/gold/abbreviation">gold:abbreviation</a>
    /// </summary>
    let abbreviation = _prefixId.prefix "abbreviation"
    /// <summary>
    ///   <para>rdfs:comment : The relation between some linguistic unit and its corresponding spoken expression.</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : acousticRealization</para>
    ///   <a href="http://purl.org/linguistics/gold/acousticRealization">gold:acousticRealization</a>
    /// </summary>
    let acousticRealization = _prefixId.prefix "acousticRealization"
    /// <summary>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : adjunct</para>
    ///   <a href="http://purl.org/linguistics/gold/adjunct">gold:adjunct</a>
    /// </summary>
    let adjunct = _prefixId.prefix "adjunct"
    /// <summary>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : agent</para>
    ///   <a href="http://purl.org/linguistics/gold/agent">gold:agent</a>
    /// </summary>
    let agent = _prefixId.prefix "agent"
    /// <summary>
    ///   <para>rdfs:comment : A relation holding between syntactic units, often manifesting itself in shared form features. NOTE: this could be better defined once syntactic roles and relations are developed.</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : agrees</para>
    ///   <a href="http://purl.org/linguistics/gold/agrees">gold:agrees</a>
    /// </summary>
    let agrees = _prefixId.prefix "agrees"
    /// <summary>
    ///   <para>rdfs:comment : The relation that holds between a morpheme and one of its morphs, an occurrence of a morpheme in context.</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : allomorph</para>
    ///   <a href="http://purl.org/linguistics/gold/allomorph">gold:allomorph</a>
    /// </summary>
    let allomorph = _prefixId.prefix "allomorph"
    /// <summary>
    ///   <para>rdfs:comment : The relation that holds between a phoneme and one of its phones, an occurrence of a phoneme in context.</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : allophone</para>
    ///   <a href="http://purl.org/linguistics/gold/allophone">gold:allophone</a>
    /// </summary>
    let allophone = _prefixId.prefix "allophone"
    /// <summary>
    ///   <para>rdfs:comment : ancestorVariety is the predicate expressing the basic diachronic relationship  between a language variety that existed some time in the past and a variety existing at a later time  such that the  former has evolved into the latter through regular language change.</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : ancestorVariety</para>
    ///   <a href="http://purl.org/linguistics/gold/ancestorVariety">gold:ancestorVariety</a>
    /// </summary>
    let ancestorVariety = _prefixId.prefix "ancestorVariety"
    /// <summary>
    ///   <para>rdfs:comment : antonym</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : antonym</para>
    ///   <a href="http://purl.org/linguistics/gold/antonym">gold:antonym</a>
    /// </summary>
    let antonym = _prefixId.prefix "antonym"
    /// <summary>
    ///   <para>rdfs:comment : The syntactic entity about which something is predicated.</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : argument</para>
    ///   <a href="http://purl.org/linguistics/gold/argument">gold:argument</a>
    /// </summary>
    let argument = _prefixId.prefix "argument"
    /// <summary>
    ///   <para>rdfs:comment : NOTE: still lacks development. This relation holds between two form units and represents the notion of circumscription in a morphosyntactic system. That is, (circumscribes A B) means that part of A comes before B and part of A comes after B, in the linearization of the units of a language.</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : circumscribes</para>
    ///   <a href="http://purl.org/linguistics/gold/circumscribes">gold:circumscribes</a>
    /// </summary>
    let circumscribes = _prefixId.prefix "circumscribes"
    /// <summary>
    ///   <para>rdfs:comment : The closing segment of a syllable.</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : coda</para>
    ///   <a href="http://purl.org/linguistics/gold/coda">gold:coda</a>
    /// </summary>
    let coda = _prefixId.prefix "coda"
    /// <summary>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : complement</para>
    ///   <a href="http://purl.org/linguistics/gold/complement">gold:complement</a>
    /// </summary>
    let complement = _prefixId.prefix "complement"
    /// <summary>
    ///   <para>rdfs:comment : The relation holding between a linguistic unit and a list (rdf:Seq) of its constituents.</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : constituents</para>
    ///   <a href="http://purl.org/linguistics/gold/constituents">gold:constituents</a>
    /// </summary>
    let constituents = _prefixId.prefix "constituents"
    /// <summary>
    ///   <para>rdfs:comment : This subsumes all structuring relations used for LinguisticDataStructures. As a naming convention to distinguish relations in data structure from other relations, all names of dataStructuringRelations begin with 'has-'.</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : dataStructureRelation</para>
    ///   <a href="http://purl.org/linguistics/gold/dataStructureRelation">gold:dataStructureRelation</a>
    /// </summary>
    let dataStructureRelation = _prefixId.prefix "dataStructureRelation"
    /// <summary>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : derivedForm</para>
    ///   <a href="http://purl.org/linguistics/gold/derivedForm">gold:derivedForm</a>
    /// </summary>
    let derivedForm = _prefixId.prefix "derivedForm"
    /// <summary>
    ///   <para>rdfs:comment : A direct object is a grammatical relation that exhibits a combination of certain independent syntactic properties, such as the following:  the usual grammatical characteristics of the patient of typically  transitive verbs; particular case marking; a particular clause  position; the conditioning of an agreement  affix on the verb; the capability of becoming the clause subject in  passivization; the capability of reflexivization. The identification of the direct object relation may be further confirmed by finding significant overlap with similar direct object relations previously established in other languages. This may be done by analyzing correspondence between  translation equivalents [Crystal 1985, 94; Hartmann and Stork 1972, 155; Comrie 1989, 66; Andrews 1985, 68,120,126; Comrie 1985, 337].</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : directObject</para>
    ///   <a href="http://purl.org/linguistics/gold/directObject">gold:directObject</a>
    /// </summary>
    let directObject = _prefixId.prefix "directObject"
    /// <summary>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : entailedBy</para>
    ///   <a href="http://purl.org/linguistics/gold/entailedBy">gold:entailedBy</a>
    /// </summary>
    let entailedBy = _prefixId.prefix "entailedBy"
    /// <summary>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : entails</para>
    ///   <a href="http://purl.org/linguistics/gold/entails">gold:entails</a>
    /// </summary>
    let entails = _prefixId.prefix "entails"
    /// <summary>
    ///   <para>rdfs:comment : The relation between a linguistic unit and a linguistic feature. A feature inheres in its host. NOTE: this relation is distinct from the hasFeature which pertains to data structures.</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : feature</para>
    ///   <a href="http://purl.org/linguistics/gold/feature">gold:feature</a>
    /// </summary>
    let feature = _prefixId.prefix "feature"
    /// <summary>
    ///   <para>rdfs:comment : This relation holds between two linguistic units and represents the inverse of 'precedes'. That is, (follows A B) means that A comes after B in the linearization of the realization of linguistic signs. The inverse of this relation is 'precedes'.</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : follows</para>
    ///   <a href="http://purl.org/linguistics/gold/follows">gold:follows</a>
    /// </summary>
    let follows = _prefixId.prefix "follows"
    /// <summary>
    ///   <para>rdfs:comment : The relation between an orthographic expression in one language and some orthographic expression in another such that both expressions have exactly the same meaning. The words in the translation may not correspond to the those in the source expression.</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : freeTranslation</para>
    ///   <a href="http://purl.org/linguistics/gold/freeTranslation">gold:freeTranslation</a>
    /// </summary>
    let freeTranslation = _prefixId.prefix "freeTranslation"
    /// <summary>
    ///   <para>rdfs:comment : geneticallyRelated is the basic kinship relation between languages varieties. If two language varieties are genetically related, then this implies that both  varieties are derived from a common  proto-language.</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : geneticallyRelated</para>
    ///   <a href="http://purl.org/linguistics/gold/geneticallyRelated">gold:geneticallyRelated</a>
    /// </summary>
    let geneticallyRelated = _prefixId.prefix "geneticallyRelated"
    /// <summary>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : goal</para>
    ///   <a href="http://purl.org/linguistics/gold/goal">gold:goal</a>
    /// </summary>
    let goal = _prefixId.prefix "goal"
    /// <summary>
    ///   <para>rdfs:comment : This relates a ComplexSpecification to a FeatureStructure, thus giving a FeatureStructure its recursive properties.</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : hasComplexValue</para>
    ///   <a href="http://purl.org/linguistics/gold/hasComplexValue">gold:hasComplexValue</a>
    /// </summary>
    let hasComplexValue = _prefixId.prefix "hasComplexValue"
    /// <summary>
    ///   <para>rdfs:comment : The relation hasConstituent is an abstract partial ordering relation that expresses dominance between two linguistic units. This relation is meant to cover all possible types of linguistic constituency: phonological, morphological, syntactic, etc. constituency.</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : hasConstituent</para>
    ///   <a href="http://purl.org/linguistics/gold/hasConstituent">gold:hasConstituent</a>
    /// </summary>
    let hasConstituent = _prefixId.prefix "hasConstituent"
    /// <summary>
    ///   <para>rdfs:comment : This relates a FeatureSystem to a FeatureContraint.</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : hasConstraint</para>
    ///   <a href="http://purl.org/linguistics/gold/hasConstraint">gold:hasConstraint</a>
    /// </summary>
    let hasConstraint = _prefixId.prefix "hasConstraint"
    /// <summary>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : hasExample</para>
    ///   <a href="http://purl.org/linguistics/gold/hasExample">gold:hasExample</a>
    /// </summary>
    let hasExample = _prefixId.prefix "hasExample"
    /// <summary>
    ///   <para>rdfs:comment : This relates a FeatureSpecification to a type of LinguisticProperty.</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : hasFeature</para>
    ///   <a href="http://purl.org/linguistics/gold/hasFeature">gold:hasFeature</a>
    /// </summary>
    let hasFeature = _prefixId.prefix "hasFeature"
    /// <summary>
    ///   <para>rdfs:comment : The relation that associates some LinguisticSign with its FormUnit.</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : hasForm</para>
    ///   <a href="http://purl.org/linguistics/gold/hasForm">gold:hasForm</a>
    /// </summary>
    let hasForm = _prefixId.prefix "hasForm"
    /// <summary>
    ///   <para>rdfs:comment : The binary relation holding between an instance of interlinear glossed text (IGT) and a sequence of labels or 'grams' used to describe the morphemes of the IGT.</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : hasGlosses</para>
    ///   <a href="http://purl.org/linguistics/gold/hasGlosses">gold:hasGlosses</a>
    /// </summary>
    let hasGlosses = _prefixId.prefix "hasGlosses"
    /// <summary>
    ///   <para>rdfs:comment : The relation that holds between a LinguisticSign and a GrammaticalUnit.</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : hasGrammar</para>
    ///   <a href="http://purl.org/linguistics/gold/hasGrammar">gold:hasGrammar</a>
    /// </summary>
    let hasGrammar = _prefixId.prefix "hasGrammar"
    /// <summary>
    ///   <para>rdfs:comment : The relation between a Lexicon and its contents, instances of LexicalItem. NOTE: this could probably be replaced by the memberOf relation from set theory.</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : hasLexicalItem</para>
    ///   <a href="http://purl.org/linguistics/gold/hasLexicalItem">gold:hasLexicalItem</a>
    /// </summary>
    let hasLexicalItem = _prefixId.prefix "hasLexicalItem"
    /// <summary>
    ///   <para>rdfs:comment : This relates a LexicalItem to a LexicalUnit, those elements commonly represented in a dictionary.</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : hasLexicalUnit</para>
    ///   <a href="http://purl.org/linguistics/gold/hasLexicalUnit">gold:hasLexicalUnit</a>
    /// </summary>
    let hasLexicalUnit = _prefixId.prefix "hasLexicalUnit"
    /// <summary>
    ///   <para>rdfs:comment : The relation that associates some LinguisticSign with a SemanticUnit.</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : hasMeaning</para>
    ///   <a href="http://purl.org/linguistics/gold/hasMeaning">gold:hasMeaning</a>
    /// </summary>
    let hasMeaning = _prefixId.prefix "hasMeaning"
    /// <summary>
    ///   <para>rdfs:comment : The relation hasMorphologicalConstituent is an abstract partial ordering relation that expresses dominance between two morphological units. This relation is meant to cover all possible types of morphological constituency.</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : hasMorphologicalConstituent</para>
    ///   <a href="http://purl.org/linguistics/gold/hasMorphologicalConstituent">gold:hasMorphologicalConstituent</a>
    /// </summary>
    let hasMorphologicalConstituent = _prefixId.prefix "hasMorphologicalConstituent"
    /// <summary>
    ///   <para>rdfs:comment : The relation between a linguistic unit and a linguistic property, e.g., (m1 hasProperty AllativeCase) where m1 is an instance of Morpheme.</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : hasProperty</para>
    ///   <a href="http://purl.org/linguistics/gold/hasProperty">gold:hasProperty</a>
    /// </summary>
    let hasProperty = _prefixId.prefix "hasProperty"
    /// <summary>
    ///   <para>rdfs:comment : The binary relation holding between an instance of interlinear glossed text and a linguistic unit (clause, phrase, etc.) from the source language.</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : hasSourceLine</para>
    ///   <a href="http://purl.org/linguistics/gold/hasSourceLine">gold:hasSourceLine</a>
    /// </summary>
    let hasSourceLine = _prefixId.prefix "hasSourceLine"
    /// <summary>
    ///   <para>rdfs:comment : This relates a FeatureStructure to a FeatureSpecification.</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : hasSpecification</para>
    ///   <a href="http://purl.org/linguistics/gold/hasSpecification">gold:hasSpecification</a>
    /// </summary>
    let hasSpecification = _prefixId.prefix "hasSpecification"
    /// <summary>
    ///   <para>rdfs:comment : The relation hasSyntacticConstituent is an abstract partial ordering relation that expresses dominance between two syntactic units. This relation is meant to cover all possible types of syntactic constituency.</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : hasSyntacticConstituent</para>
    ///   <a href="http://purl.org/linguistics/gold/hasSyntacticConstituent">gold:hasSyntacticConstituent</a>
    /// </summary>
    let hasSyntacticConstituent = _prefixId.prefix "hasSyntacticConstituent"
    /// <summary>
    ///   <para>rdfs:comment : The relation between some Termset and a Term.</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : hasTerm</para>
    ///   <a href="http://purl.org/linguistics/gold/hasTerm">gold:hasTerm</a>
    /// </summary>
    let hasTerm = _prefixId.prefix "hasTerm"
    /// <summary>
    ///   <para>rdfs:comment : The binary relation holding between an instance of interlinear glossed text and a linguistic unit (clause, phrase, etc.) acting as a free translation of the source text from the IGT instance.</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : hasTranslationLine</para>
    ///   <a href="http://purl.org/linguistics/gold/hasTranslationLine">gold:hasTranslationLine</a>
    /// </summary>
    let hasTranslationLine = _prefixId.prefix "hasTranslationLine"
    /// <summary>
    ///   <para>rdfs:comment : This relates either a FeatureStructure or a FeatureConstraint to its type, expressed by an instance of PartOfSpeech.</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : hasType</para>
    ///   <a href="http://purl.org/linguistics/gold/hasType">gold:hasType</a>
    /// </summary>
    let hasType = _prefixId.prefix "hasType"
    /// <summary>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : head</para>
    ///   <a href="http://purl.org/linguistics/gold/head">gold:head</a>
    /// </summary>
    let head = _prefixId.prefix "head"
    /// <summary>
    ///   <para>rdfs:comment : hypernym</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : hypernym</para>
    ///   <a href="http://purl.org/linguistics/gold/hypernym">gold:hypernym</a>
    /// </summary>
    let hypernym = _prefixId.prefix "hypernym"
    /// <summary>
    ///   <para>rdfs:comment : The relation that holds between a LinguisticSign and a Language. The sign is said to be a member or part of that language.</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : inLanguage</para>
    ///   <a href="http://purl.org/linguistics/gold/inLanguage">gold:inLanguage</a>
    /// </summary>
    let inLanguage = _prefixId.prefix "inLanguage"
    /// <summary>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : indirectObject</para>
    ///   <a href="http://purl.org/linguistics/gold/indirectObject">gold:indirectObject</a>
    /// </summary>
    let indirectObject = _prefixId.prefix "indirectObject"
    /// <summary>
    ///   <para>rdfs:comment : infixedIn is the relation between a Lexical- or SublexicalUnit and a Root. The Root is realized as discontinuous, surrounding the inserted Lexical- or SublexicalUnit [Hartmann and Stork 1972, 111].</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : infixedIn</para>
    ///   <a href="http://purl.org/linguistics/gold/infixedIn">gold:infixedIn</a>
    /// </summary>
    let infixedIn = _prefixId.prefix "infixedIn"
    /// <summary>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : inflectedForm</para>
    ///   <a href="http://purl.org/linguistics/gold/inflectedForm">gold:inflectedForm</a>
    /// </summary>
    let inflectedForm = _prefixId.prefix "inflectedForm"
    /// <summary>
    ///   <para>rdfs:comment : This relation names or simply associates some SymbolicString with any Entity.</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : labels</para>
    ///   <a href="http://purl.org/linguistics/gold/labels">gold:labels</a>
    /// </summary>
    let labels = _prefixId.prefix "labels"
    /// <summary>
    ///   <para>rdfs:comment : This is the superclass of common lexical relatations such as synonym, antonym, etc. NOTE: this needs work. Such relations really pertain to meaning and not form units.</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : lexicalRelation</para>
    ///   <a href="http://purl.org/linguistics/gold/lexicalRelation">gold:lexicalRelation</a>
    /// </summary>
    let lexicalRelation = _prefixId.prefix "lexicalRelation"
    /// <summary>
    ///   <para>rdfs:comment : The relation between an orthographic expression in one language and some orthographic expression in another such that the translation is done on a word by word, or morpheme by morpheme, basis without regard for idiomatic usage.</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : literalTranslation</para>
    ///   <a href="http://purl.org/linguistics/gold/literalTranslation">gold:literalTranslation</a>
    /// </summary>
    let literalTranslation = _prefixId.prefix "literalTranslation"
    /// <summary>
    ///   <para>rdfs:comment : meronym</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : meronym</para>
    ///   <a href="http://purl.org/linguistics/gold/meronym">gold:meronym</a>
    /// </summary>
    let meronym = _prefixId.prefix "meronym"
    /// <summary>
    ///   <para>rdfs:comment : A relation holding between morphological units.</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : morphologicalRelation</para>
    ///   <a href="http://purl.org/linguistics/gold/morphologicalRelation">gold:morphologicalRelation</a>
    /// </summary>
    let morphologicalRelation = _prefixId.prefix "morphologicalRelation"
    /// <summary>
    ///   <para>rdfs:comment : mutuallyIntelligible is the binary, symmetric relation holding between two language varieties such that speakers of the first variety can communicate with members of the second with relative ease, and vice versa.</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : mutuallyIntelligible</para>
    ///   <a href="http://purl.org/linguistics/gold/mutuallyIntelligible">gold:mutuallyIntelligible</a>
    /// </summary>
    let mutuallyIntelligible = _prefixId.prefix "mutuallyIntelligible"
    /// <summary>
    ///   <para>rdfs:comment : This semiotic relation associates some OrthographicExpression with some Entity. It differs from 'labels' in that a name is usually considered part of the orthographic system, where a label is not.</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : names</para>
    ///   <a href="http://purl.org/linguistics/gold/names">gold:names</a>
    /// </summary>
    let names = _prefixId.prefix "names"
    /// <summary>
    ///   <para>rdfs:comment : The central segment of a syllable.</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : nucleus</para>
    ///   <a href="http://purl.org/linguistics/gold/nucleus">gold:nucleus</a>
    /// </summary>
    let nucleus = _prefixId.prefix "nucleus"
    /// <summary>
    ///   <para>rdfs:comment : An object, traditionally defined, is either a direct object or an indirect object.An object, in some usages, is any  grammatical relation other than subject [Crystal 1985, 211; Hartmann and Stork 1972, 155-156; Comrie 1989, 66].</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : object</para>
    ///   <a href="http://purl.org/linguistics/gold/object">gold:object</a>
    /// </summary>
    let object = _prefixId.prefix "object"
    /// <summary>
    ///   <para>rdfs:comment : The initial segment of a syllable.</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : onset</para>
    ///   <a href="http://purl.org/linguistics/gold/onset">gold:onset</a>
    /// </summary>
    let onset = _prefixId.prefix "onset"
    /// <summary>
    ///   <para>rdfs:comment : Any relation that establishes a linear ordering of linguistic units.</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : orderingRelation</para>
    ///   <a href="http://purl.org/linguistics/gold/orderingRelation">gold:orderingRelation</a>
    /// </summary>
    let orderingRelation = _prefixId.prefix "orderingRelation"
    /// <summary>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : orthographicRep</para>
    ///   <a href="http://purl.org/linguistics/gold/orthographicRep">gold:orthographicRep</a>
    /// </summary>
    let orthographicRep = _prefixId.prefix "orthographicRep"
    /// <summary>
    ///   <para>rdfs:comment : parentVariety is the  relation of direct genetic relatedness, where there are  no intermediate ancestors between the ancestor and descendant. For example, Old English is the parent variety of Middle English.</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : parentVariety</para>
    ///   <a href="http://purl.org/linguistics/gold/parentVariety">gold:parentVariety</a>
    /// </summary>
    let parentVariety = _prefixId.prefix "parentVariety"
    /// <summary>
    ///   <para>rdfs:comment : A semantic role, often unmarked, that typically does not act with volition, instigate an event, receive something, or experience a sensory impression.  A prototypical patient undergoes a physical, visible change in state. Often the subject of a intransitive verb or the logical complement of a transitive verb. [Payne 1997: 50-51; Pei</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : patient</para>
    ///   <a href="http://purl.org/linguistics/gold/patient">gold:patient</a>
    /// </summary>
    let patient = _prefixId.prefix "patient"
    /// <summary>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : phonemicRep</para>
    ///   <a href="http://purl.org/linguistics/gold/phonemicRep">gold:phonemicRep</a>
    /// </summary>
    let phonemicRep = _prefixId.prefix "phonemicRep"
    /// <summary>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : phoneticRep</para>
    ///   <a href="http://purl.org/linguistics/gold/phoneticRep">gold:phoneticRep</a>
    /// </summary>
    let phoneticRep = _prefixId.prefix "phoneticRep"
    /// <summary>
    ///   <para>rdfs:comment : This relation holds between two linguistic units and represents the notion of precedence in a language. That is, (precedes A B) means that A comes before B in the linearization of the realization of linguistic signs. This inverse of this relation is 'follows'.</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : precedes</para>
    ///   <a href="http://purl.org/linguistics/gold/precedes">gold:precedes</a>
    /// </summary>
    let precedes = _prefixId.prefix "precedes"
    /// <summary>
    ///   <para>rdfs:comment : The predicate is the relation between the Clause and a portion of a  clause, excluding the subject, that expresses something about the subject [Crystal 1980, 280; Hartmann and Stork 1972, 182; Pei and Gaynor 1954, 173; Pike and Pike 1982, 40; Crystal 1985, 241-242].</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : predicate</para>
    ///   <a href="http://purl.org/linguistics/gold/predicate">gold:predicate</a>
    /// </summary>
    let predicate = _prefixId.prefix "predicate"
    /// <summary>
    ///   <para>rdfs:comment : The relation between a morphological unit and the  lexical unit to which it is attached. The LexicalUnit is usually a Root or Stem. The inverse of prefix is suffix [Crystal 1980, 281; Hartmann and Stork 1972, 182].</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : prefix</para>
    ///   <a href="http://purl.org/linguistics/gold/prefix">gold:prefix</a>
    /// </summary>
    let prefix = _prefixId.prefix "prefix"
    /// <summary>
    ///   <para>rdfs:comment : The relation holding between a linguistic unit and its physical form, either a spoken, written or signed expression.</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : realization</para>
    ///   <a href="http://purl.org/linguistics/gold/realization">gold:realization</a>
    /// </summary>
    let realization = _prefixId.prefix "realization"
    /// <summary>
    ///   <para>rdfs:comment : The core of a syllable, consisting of a nucleus and coda.</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : rhyme</para>
    ///   <a href="http://purl.org/linguistics/gold/rhyme">gold:rhyme</a>
    /// </summary>
    let rhyme = _prefixId.prefix "rhyme"
    /// <summary>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : semanticRole</para>
    ///   <a href="http://purl.org/linguistics/gold/semanticRole">gold:semanticRole</a>
    /// </summary>
    let semanticRole = _prefixId.prefix "semanticRole"
    /// <summary>
    ///   <para>rdfs:comment : The relation between some linguistic unit and its corresponding signed expression.</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : signedRealization</para>
    ///   <a href="http://purl.org/linguistics/gold/signedRealization">gold:signedRealization</a>
    /// </summary>
    let signedRealization = _prefixId.prefix "signedRealization"
    /// <summary>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : specifier</para>
    ///   <a href="http://purl.org/linguistics/gold/specifier">gold:specifier</a>
    /// </summary>
    let specifier = _prefixId.prefix "specifier"
    /// <summary>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : stringRep</para>
    ///   <a href="http://purl.org/linguistics/gold/stringRep">gold:stringRep</a>
    /// </summary>
    let stringRep = _prefixId.prefix "stringRep"
    /// <summary>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : subject</para>
    ///   <a href="http://purl.org/linguistics/gold/subject">gold:subject</a>
    /// </summary>
    let subject = _prefixId.prefix "subject"
    /// <summary>
    ///   <para>rdfs:comment : The relation between a morphological unit and the  lexical unit to which it is attached. The LexicalUnit is usually a Root or Stem. The inverse of suffix is 'prefix' [Crystal 1980, 340; Hartmann and Stork 1972, 226].</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : suffix</para>
    ///   <a href="http://purl.org/linguistics/gold/suffix">gold:suffix</a>
    /// </summary>
    let suffix = _prefixId.prefix "suffix"
    /// <summary>
    ///   <para>rdfs:comment : synonym</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : synonym</para>
    ///   <a href="http://purl.org/linguistics/gold/synonym">gold:synonym</a>
    /// </summary>
    let synonym = _prefixId.prefix "synonym"
    /// <summary>
    ///   <para>rdfs:comment : A general category subsuming relations relevant at the level of the Clause, such as predicate and subject.
    /// A grammatical relation is a role of a phrase or  complement clause that determines syntactic behaviors such as the following: word position in a clause; verb agreement; participation and behavior in such operations as  passivization [Comrie 1989, 65-66; Andrews 1985, 66].</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : syntacticRole</para>
    ///   <a href="http://purl.org/linguistics/gold/syntacticRole">gold:syntacticRole</a>
    /// </summary>
    let syntacticRole = _prefixId.prefix "syntacticRole"
    /// <summary>
    ///   <para>rdfs:comment : The relation between an orthographic expression in one language and some orthographic expression in another such that both expressions have the same or roughly the same meaning.</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : translation</para>
    ///   <a href="http://purl.org/linguistics/gold/translation">gold:translation</a>
    /// </summary>
    let translation = _prefixId.prefix "translation"
    /// <summary>
    ///   <para>rdfs:comment : The relation between some linguistic unit and its corresponding written expression.</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/linguistics/gold^^xsd:anyURI</para>
    ///   <para>rdfs:label : writtenRealization</para>
    ///   <a href="http://purl.org/linguistics/gold/writtenRealization">gold:writtenRealization</a>
    /// </summary>
    let writtenRealization = _prefixId.prefix "writtenRealization"
