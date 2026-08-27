namespace http.purl.org.linguistics.gold.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module gold =
    let _namespace_iri = Namespace_Iri gold |> NamespaceIRI
    /// <summary>
    ///   <para>gold:AbessiveCase</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"AbessiveCase expresses the lack or absence of the referent of the noun it marks. It has the meaning of the English preposition 'without' [Pei and Gaynor 1954: 3, 35]."</para>
    /// labels<para>"AbessiveCase"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/AbessiveCase">http://purl.org/linguistics/gold/AbessiveCase</seealso>
    let AbessiveCase = Prefixed_Name(gold, "AbessiveCase") |> PrefixedName
    /// <summary>
    ///   <para>gold:AbilitativeModality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"AbilitativeModality indicates the capacity of an agent to perform some action, regardless of type or condition. This is also known as the abilitive."</para>
    /// labels<para>"AbilitativeModality"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/AbilitativeModality">http://purl.org/linguistics/gold/AbilitativeModality</seealso>
    let AbilitativeModality = Prefixed_Name(gold, "AbilitativeModality") |> PrefixedName
    /// <summary>
    ///   <para>gold:AblativeCase</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Ablative case denotes the source, agent, means, and occasionally also time or place of an an act or occurence. [Pei and Gaynor 1954: 3]"</para>
    /// labels<para>"AblativeCase"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/AblativeCase">http://purl.org/linguistics/gold/AblativeCase</seealso>
    let AblativeCase = Prefixed_Name(gold, "AblativeCase") |> PrefixedName

    /// <summary>
    ///   <para>gold:AbsolutiveAntipassiveVoice</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A term used by some Mayanists to refer to an antipassive in which the patient or logical object is supressed or overtly absent. [Klaiman 1991: 232] Dayley states that the absolutive antipassive is used when the patient is unknown or irrelevant, or when the speaker does not wish to mention the patient, or to describe a transitive activity typically performed by some agent. The absolutive antipassive requires a non-specific implied patient, and no specific patient is ever semantically recoverable from the speech context. Only the absolutive antipassive has (as the name implies) absolutive function such that a transitive activity may be discussed without mention of the patient. [Dayley 1985: 345-350] This type of antipassive with an obligatorily unidentified object is also found in Mam, another Mayan language. [Cooreman 1994: 52-53]"</para>
    /// labels<para>"AbsolutiveAntipassiveVoice"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/AbsolutiveAntipassiveVoice">http://purl.org/linguistics/gold/AbsolutiveAntipassiveVoice</seealso>
    let AbsolutiveAntipassiveVoice =
        Prefixed_Name(gold, "AbsolutiveAntipassiveVoice") |> PrefixedName

    /// <summary>
    ///   <para>gold:AbsolutiveCase</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"AbsolutiveCase in ergative-absolutive languages marks referents that would generally be the subjects of intransitive verbs or the objects of transitive verbs in the translational equivalents of nominative-accusative languages [Anderson 1985: 181; Crystal 1985: 1; Andrews 1985: 138]."</para>
    /// labels<para>"AbsolutiveCase"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/AbsolutiveCase">http://purl.org/linguistics/gold/AbsolutiveCase</seealso>
    let AbsolutiveCase = Prefixed_Name(gold, "AbsolutiveCase") |> PrefixedName
    /// <summary>
    ///   <para>gold:Abstract</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Properties or qualities as distinguished from any particular embodiment of the properties/ qualities in a physical medium. Instances of Abstract can be said to exist in the same sense as mathematical objects such as sets and relations, but they cannot exist at a particular place and time without some physical encoding or embodiment. [SUMO 2010]"</para>
    /// labels<para>"Abstract"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/Abstract">http://purl.org/linguistics/gold/Abstract</seealso>
    let Abstract = Prefixed_Name(gold, "Abstract") |> PrefixedName
    /// <summary>
    ///   <para>gold:AccusativeCase</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"AccusativeCase in nominative-accusative languages marks certain syntactic functions, usually direct objects [Hartmann and Stork 1972: 3, 156; Crystal 1980: 11, 246; Andrews 1985: 75; Anderson 1985: 181]."</para>
    /// labels<para>"AccusativeCase"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/AccusativeCase">http://purl.org/linguistics/gold/AccusativeCase</seealso>
    let AccusativeCase = Prefixed_Name(gold, "AccusativeCase") |> PrefixedName
    /// <summary>
    ///   <para>gold:AcousticProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The class of properties concerning the acoustic nature of speech sounds. [Ladefoged 2000: 161]"</para>
    /// labels<para>"AcousticProperty"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/AcousticProperty">http://purl.org/linguistics/gold/AcousticProperty</seealso>
    let AcousticProperty = Prefixed_Name(gold, "AcousticProperty") |> PrefixedName
    /// <summary>
    ///   <para>gold:ActionalForce</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"ActionalForce indicates that the speaker or hearer is to undertake some action. Actional force subsumes Imperative, Commissive and Hortatory force."</para>
    /// labels<para>"ActionalForce"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/ActionalForce">http://purl.org/linguistics/gold/ActionalForce</seealso>
    let ActionalForce = Prefixed_Name(gold, "ActionalForce") |> PrefixedName
    /// <summary>
    ///   <para>gold:ActiveVoice</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Associated with transitivity, when the action is performed by an agent (subject) on another participant (object) [McIntosh 1984: 108]. It refers to the category of underived verb forms associated with the basic diathesis [Shibatani 1995: 7]."</para>
    /// labels<para>"ActiveVoice"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/ActiveVoice">http://purl.org/linguistics/gold/ActiveVoice</seealso>
    let ActiveVoice = Prefixed_Name(gold, "ActiveVoice") |> PrefixedName
    /// <summary>
    ///   <para>gold:AdessiveCase</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"AdessiveCase expresses that  the referent of the noun it marks is the location near/at which another referent exists. It has the meaning of 'at' or 'near' [Crystal 1997: 8]."</para>
    /// labels<para>"AdessiveCase"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/AdessiveCase">http://purl.org/linguistics/gold/AdessiveCase</seealso>
    let AdessiveCase = Prefixed_Name(gold, "AdessiveCase") |> PrefixedName
    /// <summary>
    ///   <para>gold:Adjectival</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An adjectival, or 'adjective', is a part of speech whose members modify nouns. An adjectival specifies the attributes of a noun referent. Note: this is one case among many. Adjectivals are a class of modifiers. An adjectival may be inflected as comparitive or superlative [Crystal 1997: 8; Payne 1997: 63]."</para>
    /// labels<para>"Adjectival"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/Adjectival">http://purl.org/linguistics/gold/Adjectival</seealso>
    let Adjectival = Prefixed_Name(gold, "Adjectival") |> PrefixedName
    /// <summary>
    ///   <para>gold:AdjectivePhrase</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A phrase with an adjective as a head. [Crystal 2003: 11] Adjective phrases may contain complements following the head, and modifiers in either pre-head or post-head position, but for the  most part, complements in adjective phrase structure are optional elements: they qualify as complements by virtue of being licensed by the head rather than  being obligatory. [Huddleston and Pullum 2002: 22-23, 57, 542]"</para>
    /// labels<para>"AdjectivePhrase"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/AdjectivePhrase">http://purl.org/linguistics/gold/AdjectivePhrase</seealso>
    let AdjectivePhrase = Prefixed_Name(gold, "AdjectivePhrase") |> PrefixedName
    /// <summary>
    ///   <para>gold:AdjunctSubordinate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A word or phrase which is used to extend the meaning of another word or phrase, but which is not one of the main structural elements of a sentence [Hartmann and Stork 1972: 5]. Adjunct clauses include subordinate clauses (i.e. those with overt subordinating conjunctions)."</para>
    /// labels<para>"AdjunctSubordinate"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/AdjunctSubordinate">http://purl.org/linguistics/gold/AdjunctSubordinate</seealso>
    let AdjunctSubordinate = Prefixed_Name(gold, "AdjunctSubordinate") |> PrefixedName
    /// <summary>
    ///   <para>gold:Adposition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An adposition is a part of speech whose members are of a closed set and occur before or after a complement composed of a noun phrase, noun, pronoun, or clause that functions as a noun phrase and forms a single structure with the complement to express its grammatical and semantic relation to another unit within a clause [Comrie 1989: 91; Crystal 1997: 305; Payne 1997: 86]."</para>
    /// labels<para>"Adposition"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/Adposition">http://purl.org/linguistics/gold/Adposition</seealso>
    let Adposition = Prefixed_Name(gold, "Adposition") |> PrefixedName
    /// <summary>
    ///   <para>gold:Adverbial</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An adverbial, or 'adverb', narrowly defined, is a part of speech whose members modify verbs for such categories as time, manner, place, or direction. An adverbal, broadly defined, is a part of speech whose members modify any constituent class of words other than nouns, such as verbs, adjectives, adverbs, phrases, clauses, or sentences. Under this definition, the possible type of modification depends on the class of the constituent being modified [Crystal 1997: 11; Payne 1997: 69]."</para>
    /// labels<para>"Adverbial"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/Adverbial">http://purl.org/linguistics/gold/Adverbial</seealso>
    let Adverbial = Prefixed_Name(gold, "Adverbial") |> PrefixedName
    /// <summary>
    ///   <para>gold:Adverbializer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Marks clauses as having some adverbial function, such as the expression of time, purpose, result, etc. In some languages, many of the words that serve as adverbializers also serve as prepositional or postpositional noun adjuncts. In some languages, an adverbializer in a subordinate clause may be optionally paired with another conjunction occurring in the main clause. There are also cases where an adverbializer in a subordinate clause is obligatorily paired with a conjunction in the main clause. [Schachter 1985: 51-52]"</para>
    ///   <para>"An adverbializer is a subordinating connective that links a subordinate clause  to a main clause, and indicates that the subordinate clause has an adverbial or interpropositional relation  to the main clause, indicating purpose, condition, time, and location. [SIL International 2004]"</para>
    /// labels<para>"Adverbializer"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/Adverbializer">http://purl.org/linguistics/gold/Adverbializer</seealso>
    let Adverbializer = Prefixed_Name(gold, "Adverbializer") |> PrefixedName
    /// <summary>
    ///   <para>gold:Affix</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An affix is a morpheme with an abstract meaning which can only be used when added to a root morpheme.  These are classified in four different ways, depending on their position with reference to the root: suffix, prefix, circumfix and infix. [Haspelmath 2002: 265; Crystal 1980: 17]"</para>
    /// labels<para>"Affix"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/Affix">http://purl.org/linguistics/gold/Affix</seealso>
    let Affix = Prefixed_Name(gold, "Affix") |> PrefixedName

    /// <summary>
    ///   <para>gold:AgentDeletionPassiveVoice</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The object of the active retains its old case-marking in the passive, the subject of the active cannot appear in the passive clause, and the passive tends to be semantically active [Givon 1988: 419]."</para>
    /// labels<para>"AgentDeletionPassiveVoice"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/AgentDeletionPassiveVoice">http://purl.org/linguistics/gold/AgentDeletionPassiveVoice</seealso>
    let AgentDeletionPassiveVoice =
        Prefixed_Name(gold, "AgentDeletionPassiveVoice") |> PrefixedName

    /// <summary>
    ///   <para>gold:AirstreamProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Refers to the direction of the airstream in speech sound production. In the canonical literature, there are three airstream mechanisms: pulmonic, velaric, and glottalic. Glottalic airstream mechanism is sometimes used to describe the method of production of ejectives and implosives. Ladefoged and Maddieson prefer to regard implosives and ejectives as characterized by a laryngeal parameter of movement rather than an airstream property. [Ladefoged and Maddieson 1996: 372-373]"</para>
    /// labels<para>"AirstreamProperty"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/AirstreamProperty">http://purl.org/linguistics/gold/AirstreamProperty</seealso>
    let AirstreamProperty = Prefixed_Name(gold, "AirstreamProperty") |> PrefixedName
    /// <summary>
    ///   <para>gold:AllativeCase</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"AllativeCase expresses motion to or toward the referent of the noun it marks [Pei and Gaynor 1954: 6, 9, 216; Lyons 1968: 299; Crystal 1985: 1213]."</para>
    /// labels<para>"AllativeCase"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/AllativeCase">http://purl.org/linguistics/gold/AllativeCase</seealso>
    let AllativeCase = Prefixed_Name(gold, "AllativeCase") |> PrefixedName
    /// <summary>
    ///   <para>gold:Alveolar</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Characterizing sounds produced with the alveolar ridge as the passive articulator [Ladefoged 1997: 598]."</para>
    /// labels<para>"Alveolar"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/Alveolar">http://purl.org/linguistics/gold/Alveolar</seealso>
    let Alveolar = Prefixed_Name(gold, "Alveolar") |> PrefixedName
    /// <summary>
    ///   <para>gold:AnimateGender</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A grammatical gender property assigned to a class of nouns with animate denotation. In a given language it may include larger or smaller numbers of nouns which do not meet this semantic criterion. The animate gender may occur in a two-gender system, with the other gender being labeled inanimate. However, the animate gender may also occur in larger inventories (i.e. greater than two values). Examples of these larger systems are found in Bantu languages (where nouns denoting humans are included in the animate gender) and in languages of Daghestan (where the animate gender is typically for non-human animates) [Corbett 1991: 20-32]."</para>
    /// labels<para>"AnimateGender"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/AnimateGender">http://purl.org/linguistics/gold/AnimateGender</seealso>
    let AnimateGender = Prefixed_Name(gold, "AnimateGender") |> PrefixedName
    /// <summary>
    ///   <para>gold:AnnotationProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"'Linguistic annotation' covers any descriptive or analytic notations applied to raw language data. The basic data may be in the form of time functions - audio, video and/or physiological recordings - or it may be textual. The added notations may include transcriptions of all sorts (from phonetic features to discourse structures), part-of-speech and sense tagging, syntactic analysis, 'named entity' identification, co-reference annotation, and so on. [Bird and Liberman 2000: 1]"</para>
    /// labels<para>"AnnotationProperty"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/AnnotationProperty">http://purl.org/linguistics/gold/AnnotationProperty</seealso>
    let AnnotationProperty = Prefixed_Name(gold, "AnnotationProperty") |> PrefixedName
    /// <summary>
    ///   <para>gold:AnteriorProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Properties characterized by focusing on the upper passive articulator on the roof of the mouth [Ladefoged 1997: 597]."</para>
    /// labels<para>"AnteriorProperty"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/AnteriorProperty">http://purl.org/linguistics/gold/AnteriorProperty</seealso>
    let AnteriorProperty = Prefixed_Name(gold, "AnteriorProperty") |> PrefixedName
    /// <summary>
    ///   <para>gold:AntiCausativeVoice</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An intransitive verb is derived from a basically transitive one with the direct object of the transitive verb corresponding to the subject of the intransitive [Siewierska 1988: 267]."</para>
    /// labels<para>"AntiCausativeVoice"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/AntiCausativeVoice">http://purl.org/linguistics/gold/AntiCausativeVoice</seealso>
    let AntiCausativeVoice = Prefixed_Name(gold, "AntiCausativeVoice") |> PrefixedName
    /// <summary>
    ///   <para>gold:AntiPassiveVoice</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"In the antipassive construction, the patient-like argument is either suppressed (left implicit) or realized as an oblique complement, rather than as a direct object as would be the case in the basic two-place predicate transitive construction. The antipassive voice is most commonly found in ergative languages. In this case, the direct object, which is in the absolutive case in the transitive construction, is no longer marked as absolutive, but is marked as oblique or is supressed entirely. The agent-like argument, marked as ergative in a typical transitive construction, is instead marked as absolutive, making it appear like the agent of an intransitive construction. [Polinsky 2008]"</para>
    /// labels<para>"AntiPassiveVoice"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/AntiPassiveVoice">http://purl.org/linguistics/gold/AntiPassiveVoice</seealso>
    let AntiPassiveVoice = Prefixed_Name(gold, "AntiPassiveVoice") |> PrefixedName
    /// <summary>
    ///   <para>gold:Apical</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Characterizing sounds produced by the tip of the tongue [Ladefoged 1997: 596]."</para>
    /// labels<para>"Apical"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/Apical">http://purl.org/linguistics/gold/Apical</seealso>
    let Apical = Prefixed_Name(gold, "Apical") |> PrefixedName
    /// <summary>
    ///   <para>gold:ApicalityProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Properties characterized by focusing on the action of the lower, active articulator, i.e. which part of the tongue is used in articulation [Ladefoged 1997: 597]."</para>
    /// labels<para>"ApicalityProperty"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/ApicalityProperty">http://purl.org/linguistics/gold/ApicalityProperty</seealso>
    let ApicalityProperty = Prefixed_Name(gold, "ApicalityProperty") |> PrefixedName
    /// <summary>
    ///   <para>gold:ApplicativeVoice</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The applicative voice is a grammatical voice which promotes an oblique argument of a verb to the (core) patient argument, and indicates the oblique role within the meaning of the verb. Applicatives have a degree of overlap with causatives, and in some languages are realized identically; this isomorphism can be found in Kinyarwanda [Kimenyi 1980: 164], Yagua, Malay, and Dyirbal [Croft 1990: 242].
    ///
    /// While differing from true applicatives, a similar construction known as dative shifting occurs in other languages, including English. Two subtle differences between applicative and dative-shift constructions are: (1) applicatives involve some marking on the verb whereas dative-shift constructions do not; and (2) dative-shift constructions typically allow only recipients and benefactives to become direct objects whereas applicative constructions normally advance instruments and perhaps other obliques. [Payne 1997: 186-192]"</para>
    /// labels<para>"ApplicativeVoice"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/ApplicativeVoice">http://purl.org/linguistics/gold/ApplicativeVoice</seealso>
    let ApplicativeVoice = Prefixed_Name(gold, "ApplicativeVoice") |> PrefixedName
    /// <summary>
    ///   <para>gold:Approximant</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This term is used to classify sounds based on their manner of articulation.  Sounds possessing this trait are those in which the involved articulators approach one another, but not close enough to produce audible friction. [Crystal 1980: 30]"</para>
    /// labels<para>"Approximant"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/Approximant">http://purl.org/linguistics/gold/Approximant</seealso>
    let Approximant = Prefixed_Name(gold, "Approximant") |> PrefixedName
    /// <summary>
    ///   <para>gold:ArabicNumeralGender</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A labeling convention for gender categories. Arabic numerals are often used for languages for which there is a descriptive tradition involving use of the term 'noun class' instead of 'gender', in particular in languages of the Caucasus or Bantu languages; If the 'noun classes' are involved in agreement systems, they are gender systems. Arabic numerals may also be used in instances where another label is possible. For instance, in one language the gender to which nouns with human denotation are assigned might be called 'human', whereas in another language nouns with a similar denotation may be assigned to a gender with an arbitrary Arabic numerical label such as '1'. [Kibort and Corbett 2008a]"</para>
    /// labels<para>"ArabicNumeralGender"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/ArabicNumeralGender">http://purl.org/linguistics/gold/ArabicNumeralGender</seealso>
    let ArabicNumeralGender = Prefixed_Name(gold, "ArabicNumeralGender") |> PrefixedName
    /// <summary>
    ///   <para>gold:Article</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An article is a member of a small class of determiners that identify a noun's definite or indefinite reference, and new or given status [Crystal 1997: 26]."</para>
    /// labels<para>"Article"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/Article">http://purl.org/linguistics/gold/Article</seealso>
    let Article = Prefixed_Name(gold, "Article") |> PrefixedName

    /// <summary>
    ///   <para>gold:ArticulatoryProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The class of properties defining how sounds are produced in the mouth.  [Ladefoged"</para>
    /// labels<para>"ArticulatoryProperty"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/ArticulatoryProperty">http://purl.org/linguistics/gold/ArticulatoryProperty</seealso>
    let ArticulatoryProperty =
        Prefixed_Name(gold, "ArticulatoryProperty") |> PrefixedName

    /// <summary>
    ///   <para>gold:AspectProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The term 'aspect'; designates the perspective taken on the internal temporal organization of the event, and different values of the Aspect Feature distinguish different ways of viewing the internal temporal constituency of the same event [Comrie 1976: 3ff], after [Holt 1943: 6; Bybee 2003: 157]. The 'event' is understood here as a general term covering any situation type (a state, activity, accomplishment, achievement, etc.) as expressed by the verb phrase of the construction. Unlike Tense Feature, which expresses event-external time and is deictic, Aspect Feature is event-internal and non-deictic, as it is not concerned with relating the time of the event to any other time point. [Kibort 2008e]"</para>
    /// labels<para>"AspectProperty"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/AspectProperty">http://purl.org/linguistics/gold/AspectProperty</seealso>
    let AspectProperty = Prefixed_Name(gold, "AspectProperty") |> PrefixedName
    /// <summary>
    ///   <para>gold:Aspirated</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A sound is described as 'aspirated' when it has a greater rate of airflow than occurs in modal voice for a period of time before or after a stricture. It often accompanies a consonant which precedes a vowel, the beginning of which is unvoiced. [Ladefoged"</para>
    /// labels<para>"Aspirated"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/Aspirated">http://purl.org/linguistics/gold/Aspirated</seealso>
    let Aspirated = Prefixed_Name(gold, "Aspirated") |> PrefixedName

    /// <summary>
    ///   <para>gold:AssumptiveEvidentiality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"One of the three types of judgment common in languages, that indicates inference from what is generally known. English has the contrast between Deductive and Assumptive, as shown in: 'John must be in his office', 'John'll be in his office'. Schlichter comments that the speaker believes the case to be true…in the case of the Assumptive ‘because of his experience with similar situations, regular patterns, or repeated circumstances common in human life’. It is used when the speaker has prior knowledge about the state of things or about habitual or general 'behavior patterns', but 'only when no information about the state or event is being or has been received'. In that sense it is the negative member of the evidential system, used when no ready evidence is available. [Palmer 2001: 24-25; 30; 51]"</para>
    /// labels<para>"AssumptiveEvidentiality"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/AssumptiveEvidentiality">http://purl.org/linguistics/gold/AssumptiveEvidentiality</seealso>
    let AssumptiveEvidentiality =
        Prefixed_Name(gold, "AssumptiveEvidentiality") |> PrefixedName

    /// <summary>
    ///   <para>gold:AttestedVariety</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A linguistic form for which there is evidence of present or past use. Attestation refers to something that is found in actual recorded usage, compared with the hypothetical predictions of grammar or the intuitive (but otherwise unsupported) observations of the linguist.[Crystal 2003: 41]"</para>
    /// labels<para>"AttestedVariety"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/AttestedVariety">http://purl.org/linguistics/gold/AttestedVariety</seealso>
    let AttestedVariety = Prefixed_Name(gold, "AttestedVariety") |> PrefixedName

    /// <summary>
    ///   <para>gold:AuditoryEvidentiality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"AuditoryEvidentiality encodes the fact that the speaker came to believe the content of the expression through direct auditory experience; they heard it. This does not include spoken reported accounts, but only direct sensory evidence, such as the situation of 'hearing a tree fall' [Palmer 2001: 38]."</para>
    /// labels<para>"AuditoryEvidentiality"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/AuditoryEvidentiality">http://purl.org/linguistics/gold/AuditoryEvidentiality</seealso>
    let AuditoryEvidentiality =
        Prefixed_Name(gold, "AuditoryEvidentiality") |> PrefixedName

    /// <summary>
    ///   <para>gold:AugmentativeSize</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A special form of a noun that signals that the object being referred to is large relative to the usual size of such an object [Crystal 1980: 34]."</para>
    /// labels<para>"AugmentativeSize"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/AugmentativeSize">http://purl.org/linguistics/gold/AugmentativeSize</seealso>
    let AugmentativeSize = Prefixed_Name(gold, "AugmentativeSize") |> PrefixedName
    /// <summary>
    ///   <para>gold:Auxiliary</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Auxiliary is a term used to describe verbs which are used in coordination with another verb to express mood, tense or aspect of the action denoted by the main verb.  Marginal auxiliaries share some of these properties, but not all. [Crystal 1985: 28; Pei"</para>
    /// labels<para>"Auxiliary"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/Auxiliary">http://purl.org/linguistics/gold/Auxiliary</seealso>
    let Auxiliary = Prefixed_Name(gold, "Auxiliary") |> PrefixedName
    /// <summary>
    ///   <para>gold:AversiveCase</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"AversiveCase expresses fear or is literally translated as 'turning from' in some languages [Blake 2001: 156]."</para>
    /// labels<para>"AversiveCase"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/AversiveCase">http://purl.org/linguistics/gold/AversiveCase</seealso>
    let AversiveCase = Prefixed_Name(gold, "AversiveCase") |> PrefixedName
    /// <summary>
    ///   <para>gold:Back</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A vowel sound produced with the tongue retracted towards the back of the oral cavity, e.g. [a:] as in English ‘calm’ or [u:] as in English ‘soon’. [Hartmann and Stork 1972: 25]"</para>
    /// labels<para>"Back"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/Back">http://purl.org/linguistics/gold/Back</seealso>
    let Back = Prefixed_Name(gold, "Back") |> PrefixedName
    /// <summary>
    ///   <para>gold:BacknessProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A feature of vowel quality that correlates the difference between frequencies of formant two and formant one (overtones corresponding to a resonating frequency of the air in the vocal tract) [Ladefoged 2000: 215, 273]"</para>
    /// labels<para>"BacknessProperty"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/BacknessProperty">http://purl.org/linguistics/gold/BacknessProperty</seealso>
    let BacknessProperty = Prefixed_Name(gold, "BacknessProperty") |> PrefixedName
    /// <summary>
    ///   <para>gold:BenefactiveCase</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"BenefactiveCase expresses that the referent of the noun it marks receives the benefit of the situation expressed by the clause [Crystal 1980: 43]."</para>
    /// labels<para>"BenefactiveCase"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/BenefactiveCase">http://purl.org/linguistics/gold/BenefactiveCase</seealso>
    let BenefactiveCase = Prefixed_Name(gold, "BenefactiveCase") |> PrefixedName
    /// <summary>
    ///   <para>gold:BinaryPredicator</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Binary predicates define relationships between keywords. Each binary predicate is viewed as function: given the value of the first argument, it returns the set of values for the second argument that would make the predicate true. [Feldman and Hirsh 1996: 344] BinaryPredicators are the class of syntactic words that require two arguments."</para>
    /// labels<para>"BinaryPredicator"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/BinaryPredicator">http://purl.org/linguistics/gold/BinaryPredicator</seealso>
    let BinaryPredicator = Prefixed_Name(gold, "BinaryPredicator") |> PrefixedName
    /// <summary>
    ///   <para>gold:BoundMorpheme</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A bound morpheme (or bound form) is one which cannot occur on its own as a separate word, e.g. various affixes de-, -tion, -ize. [Crystal 2003: 56]"</para>
    /// labels<para>"BoundMorpheme"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/BoundMorpheme">http://purl.org/linguistics/gold/BoundMorpheme</seealso>
    let BoundMorpheme = Prefixed_Name(gold, "BoundMorpheme") |> PrefixedName
    /// <summary>
    ///   <para>gold:Breathy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"With regard to classifications of vocal qualities, this refers to an effect produced by allowing a large amount of air to pass through the partially open glottis.  Some speakers have this as a permanent characteristic of their speech patterns. [Crystal 1985: 38]"</para>
    /// labels<para>"Breathy"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/Breathy">http://purl.org/linguistics/gold/Breathy</seealso>
    let Breathy = Prefixed_Name(gold, "Breathy") |> PrefixedName
    /// <summary>
    ///   <para>gold:BuccalProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A subclass of place properties roughly referring to positions inside the mouth [Ladefoged 1997: 606]."</para>
    /// labels<para>"BuccalProperty"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/BuccalProperty">http://purl.org/linguistics/gold/BuccalProperty</seealso>
    let BuccalProperty = Prefixed_Name(gold, "BuccalProperty") |> PrefixedName
    /// <summary>
    ///   <para>gold:CardinalNumeral</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A cardinal numeral is a numeral of the class whose members are considered basic in form, are used in counting, and are used in expressing how many objects are referred to [Crystal 1997: 52]."</para>
    /// labels<para>"CardinalNumeral"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/CardinalNumeral">http://purl.org/linguistics/gold/CardinalNumeral</seealso>
    let CardinalNumeral = Prefixed_Name(gold, "CardinalNumeral") |> PrefixedName
    /// <summary>
    ///   <para>gold:CaseProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"CaseProperty is the class of properties that concerns the grammatical encoding of a noun's relationship (syntactic or semantic) to some other element in the sentence, such as a verb, noun, pronoun, or adposition [Pei and Gaynor 1954: 35; Crystal 1980: 53-54; Anderson 1985: 179-180; Andrews 1985: 7172; Kuno 1973: 45; Blake 2001]."</para>
    /// labels<para>"CaseProperty"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/CaseProperty">http://purl.org/linguistics/gold/CaseProperty</seealso>
    let CaseProperty = Prefixed_Name(gold, "CaseProperty") |> PrefixedName
    /// <summary>
    ///   <para>gold:CategoryChanger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"CategoryChanger is a cover class for all derivational units that change the syntactic category of the root to which they are attached."</para>
    /// labels<para>"CategoryChanger"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/CategoryChanger">http://purl.org/linguistics/gold/CategoryChanger</seealso>
    let CategoryChanger = Prefixed_Name(gold, "CategoryChanger") |> PrefixedName
    /// <summary>
    ///   <para>gold:CausativeVoice</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A construction can be classified as a morphological causative when there is specific morphological encoding of causativity within the verb. Moreover, a causative is associated with an additional core argument, a causer or causal agent, added to the set of core arguments assigned by the corresponding noncausative verb. [Klaiman 1991: 51]"</para>
    /// labels<para>"CausativeVoice"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/CausativeVoice">http://purl.org/linguistics/gold/CausativeVoice</seealso>
    let CausativeVoice = Prefixed_Name(gold, "CausativeVoice") |> PrefixedName
    /// <summary>
    ///   <para>gold:Central</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Characterizing sounds produced with the tongue  near the center of the mouth (along the front-back dimension)."</para>
    /// labels<para>"Central"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/Central">http://purl.org/linguistics/gold/Central</seealso>
    let Central = Prefixed_Name(gold, "Central") |> PrefixedName
    /// <summary>
    ///   <para>gold:CentralEscape</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A consonant articulated so that air passes out the center. [Ladefoged  2000: 155]"</para>
    /// labels<para>"CentralEscape"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/CentralEscape">http://purl.org/linguistics/gold/CentralEscape</seealso>
    let CentralEscape = Prefixed_Name(gold, "CentralEscape") |> PrefixedName
    /// <summary>
    ///   <para>gold:Character</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>"A symbol used in writing, distinguished from others by its meaning, not its specific shape; similar to grapheme. It relates to the domain of orthographies and writing. Specific to the implementation of computers and other information systems. [Lyons, et al. 2001]"</para>
    /// labels<para>"Character"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/Character">http://purl.org/linguistics/gold/Character</seealso>
    let Character = Prefixed_Name(gold, "Character") |> PrefixedName
    /// <summary>
    ///   <para>gold:Circumfix</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A discontinuous affix that occurs on both sides of the base.  [Haspelmath 2002: 267]"</para>
    /// labels<para>"Circumfix"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/Circumfix">http://purl.org/linguistics/gold/Circumfix</seealso>
    let Circumfix = Prefixed_Name(gold, "Circumfix") |> PrefixedName
    /// <summary>
    ///   <para>gold:Citation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The action of citing or quoting any words or written passage from a publication that allows others to locate and identify the original source. Typical details include the title, author's name, the journal title (for articles), publication date and page numbers used in research. [Oxford English Dictionary 2010]
    ///
    /// Note: This concept was included in order to facilitate linking to the bibliographic entries referenced in GOLD."</para>
    /// labels<para>"Citation"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/Citation">http://purl.org/linguistics/gold/Citation</seealso>
    let Citation = Prefixed_Name(gold, "Citation") |> PrefixedName
    /// <summary>
    ///   <para>gold:Class</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This term refers to a set of entities, be they words, morphemes or otherwise, which share certain formal or semantic properties.  [Crystal 1980: 60]"</para>
    /// labels<para>"Class"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/Class">http://purl.org/linguistics/gold/Class</seealso>
    let Class = Prefixed_Name(gold, "Class") |> PrefixedName
    /// <summary>
    ///   <para>gold:Classifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"In grammar, a morpheme whose function is to indicate the formal or semantic class to which items belong are  sometimes called classifiers, e.g. -ly is an adverb classifier, -ess is a 'femininity' classifier. The marking of lexical items as belonging to the same semantic class is an important feature in many languages (e.g. Chinese, Vietnamese, Hopi), and sometimes quite unexpected bases of classification are found, in terms of shape, size, colour, movability, animacy, status and so on. [Crystal 2003: 74]"</para>
    /// labels<para>"Classifier"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/Classifier">http://purl.org/linguistics/gold/Classifier</seealso>
    let Classifier = Prefixed_Name(gold, "Classifier") |> PrefixedName
    /// <summary>
    ///   <para>gold:Clause</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A clause is a subdivision of a sentence containing a subject (argument) and predicate.  It is possible to have a word that implies or refers to a predicate rather than one explicitly stated. [Pei"</para>
    /// labels<para>"Clause"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/Clause">http://purl.org/linguistics/gold/Clause</seealso>
    let Clause = Prefixed_Name(gold, "Clause") |> PrefixedName
    /// <summary>
    ///   <para>gold:Clitic</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Clitic is the class of units which members exhibit syntactic characteristics of a lexical unit, but show evidence of being morphologically bound to another lexical unit, the host, by being unstressed or subject to word-level phonological rules [Crystal 1980: 64; Hartmann and Stork 1972: 38; Anderson 1985: 158; Klavans 1982: xi-xiv, 74-76, 83, 93-95, 100-101; Zwicky 1977: 5]."</para>
    /// labels<para>"Clitic"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/Clitic">http://purl.org/linguistics/gold/Clitic</seealso>
    let Clitic = Prefixed_Name(gold, "Clitic") |> PrefixedName
    /// <summary>
    ///   <para>gold:Close</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"In the classification of tongue movement when articulating vowel sounds, this refers to one produced with the tongue in the highest vertical position possible within the mouth without causing audible friction. [Crystal 1980: 64]"</para>
    /// labels<para>"Close"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/Close">http://purl.org/linguistics/gold/Close</seealso>
    let Close = Prefixed_Name(gold, "Close") |> PrefixedName
    /// <summary>
    ///   <para>gold:CloseFutureTense</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Also called ImmediateFutureTense, this grammatical class names an upcoming situation which is to take place shortly after the moment of utterance [Dahl 1985: 121; Comrie 1985: 94; Bybee, Perkins and Pagliuca 1994: 244-245]."</para>
    /// labels<para>"CloseFutureTense"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/CloseFutureTense">http://purl.org/linguistics/gold/CloseFutureTense</seealso>
    let CloseFutureTense = Prefixed_Name(gold, "CloseFutureTense") |> PrefixedName
    /// <summary>
    ///   <para>gold:CoVerb</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A term referring to complex predicates comprised of two verbs; one of these is an auxiliary which contributes some form of meaning in the form of modality, direction, etc.  They serve a similar purpose to adpositions in Indo-European languages, and are almost always translated as such.  Some examples are found in some east and southeast Asian languages, as well as African languages and Hungarian.  [Yang and Kuo 1998: 20]"</para>
    /// labels<para>"CoVerb"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/CoVerb">http://purl.org/linguistics/gold/CoVerb</seealso>
    let CoVerb = Prefixed_Name(gold, "CoVerb") |> PrefixedName
    /// <summary>
    ///   <para>gold:ComitativeCase</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"ComitativeCase expresses accompaniment. It carries the meaning 'with' or 'accompanied by' [Anderson 1985: 186; Pei and Gaynor 1954: 42; Dixon, R. 1972: 12]."</para>
    /// labels<para>"ComitativeCase"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/ComitativeCase">http://purl.org/linguistics/gold/ComitativeCase</seealso>
    let ComitativeCase = Prefixed_Name(gold, "ComitativeCase") |> PrefixedName
    /// <summary>
    ///   <para>gold:CommissiveForce</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"CommisiveForce indicates that the speaker promises or threatens to perform some action [Palmer 2001: 10, 72]."</para>
    /// labels<para>"CommissiveForce"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/CommissiveForce">http://purl.org/linguistics/gold/CommissiveForce</seealso>
    let CommissiveForce = Prefixed_Name(gold, "CommissiveForce") |> PrefixedName
    /// <summary>
    ///   <para>gold:CommonNoun</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"CommonNouns refer to a class of objects, places, ideas, and so on.  This is in contrast with ProperNoun.  [Brown and Miller 1999: 424]"</para>
    /// labels<para>"CommonNoun"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/CommonNoun">http://purl.org/linguistics/gold/CommonNoun</seealso>
    let CommonNoun = Prefixed_Name(gold, "CommonNoun") |> PrefixedName

    /// <summary>
    ///   <para>gold:ComparativeAdjective</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The form of an adjective which expresses that one thing possesses a certain quality or attribute to a greater extent than another thing or in relation to another reference point. [Hartmann and Stork 1972: 60; Pei and Gaynor 1980: 43]"</para>
    /// labels<para>"ComparativeAdjective"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/ComparativeAdjective">http://purl.org/linguistics/gold/ComparativeAdjective</seealso>
    let ComparativeAdjective =
        Prefixed_Name(gold, "ComparativeAdjective") |> PrefixedName

    /// <summary>
    ///   <para>gold:Complement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A complement, also called a predicative, is a phrase that gives a description of the subject or object via the verb, while the verb itself expresses no adequate thought without being complemented by this addition.  Most typically this is an adjective phrase. [Asher 1994: 4881; Jespersen 2006: 89; Huddleston and Pullam 2002: 251]"</para>
    /// labels<para>"Complement"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/Complement">http://purl.org/linguistics/gold/Complement</seealso>
    let Complement = Prefixed_Name(gold, "Complement") |> PrefixedName

    /// <summary>
    ///   <para>gold:ComplementSubordinate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A subordinate complement clause is an element which is dependent upon the main clause syntactically and as a whole completes the action of the verb. [Brown and Miller 1999: 424; Crystal 1980: 518]"</para>
    /// labels<para>"ComplementSubordinate"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/ComplementSubordinate">http://purl.org/linguistics/gold/ComplementSubordinate</seealso>
    let ComplementSubordinate =
        Prefixed_Name(gold, "ComplementSubordinate") |> PrefixedName

    /// <summary>
    ///   <para>gold:Complementizer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A complementizer is a connective which marks a complement clause [Crystal 1997: 75]."</para>
    /// labels<para>"Complementizer"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/Complementizer">http://purl.org/linguistics/gold/Complementizer</seealso>
    let Complementizer = Prefixed_Name(gold, "Complementizer") |> PrefixedName
    /// <summary>
    ///   <para>gold:CompletiveAspect</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A term used to denote verbal aspect that focuses on the conclusion of a process or action.  [Brown and Miller 1999: 424]"</para>
    /// labels<para>"CompletiveAspect"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/CompletiveAspect">http://purl.org/linguistics/gold/CompletiveAspect</seealso>
    let CompletiveAspect = Prefixed_Name(gold, "CompletiveAspect") |> PrefixedName

    /// <summary>
    ///   <para>gold:ComplexSpecification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A ComplexSpecification is a kind of FeatureSpecification whose value must be a FeatureStructure. This class gives a feature system its recursive properites [Maxwell, Simons and Hayashi 2000]."</para>
    /// labels<para>"ComplexSpecification"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/ComplexSpecification">http://purl.org/linguistics/gold/ComplexSpecification</seealso>
    let ComplexSpecification =
        Prefixed_Name(gold, "ComplexSpecification") |> PrefixedName

    /// <summary>
    ///   <para>gold:Compound</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A term used widely in descriptive linguistic studies to refer to a linguistic unit which is composed of elements that function independently in other circumstances. [Crystal 2003: 92]"</para>
    /// labels<para>"Compound"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/Compound">http://purl.org/linguistics/gold/Compound</seealso>
    let Compound = Prefixed_Name(gold, "Compound") |> PrefixedName
    /// <summary>
    ///   <para>gold:Compressed</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"One of the three types of Labial that can be associated with sounds involving lip compression involving the vertical movement of one lip towards the other. Such a property is associated with a normal bilabial stop."</para>
    /// labels<para>"Compressed"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/Compressed">http://purl.org/linguistics/gold/Compressed</seealso>
    let Compressed = Prefixed_Name(gold, "Compressed") |> PrefixedName
    /// <summary>
    ///   <para>gold:ConditionalModality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"When describing verbs, this is a term used to indicate expression of an unreal or unfulfilled condition.  Some languages use grammatical markers or verb forms to separate real and unreal conditions.  [Brown and Miller 1999: 425]"</para>
    /// labels<para>"ConditionalModality"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/ConditionalModality">http://purl.org/linguistics/gold/ConditionalModality</seealso>
    let ConditionalModality = Prefixed_Name(gold, "ConditionalModality") |> PrefixedName

    /// <summary>
    ///   <para>gold:ConditionalPhysicalAbilitiveModality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"ConditionalPhysicalAbilitiveModality indicates ability of an agent to perform some action, requiring the presence of conditions external to the agent [Bybee, Perkins and Pagliuca 1994: 177; Palmer 2001: 76]."</para>
    /// labels<para>"ConditionalPhysicalAbilitiveModality"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/ConditionalPhysicalAbilitiveModality">http://purl.org/linguistics/gold/ConditionalPhysicalAbilitiveModality</seealso>
    let ConditionalPhysicalAbilitiveModality =
        Prefixed_Name(gold, "ConditionalPhysicalAbilitiveModality") |> PrefixedName

    /// <summary>
    ///   <para>gold:Conjunction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A term used in the grammatical classification of words to refer to an item or a process whose primary function is to connect words or other constructions. The conventional subclassification of these 'connective' items distinguishes co-ordinating conjunctions (e.g. and, or, but) and subordinating conjunctions (e.g. because, when, unless) -- also referred to as 'co-ordinators' and 'subordinators' respectively. [Crystal 2008: 101]"</para>
    /// labels<para>"Conjunction"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/Conjunction">http://purl.org/linguistics/gold/Conjunction</seealso>
    let Conjunction = Prefixed_Name(gold, "Conjunction") |> PrefixedName
    /// <summary>
    ///   <para>gold:Connective</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Also known as a conjunction, a Connective is a class of parts of speech whose members syntactically link words or larger  constituents, and expresses a semantic relationship between them. A conjunction is positionally fixed relative to one or more of the elements related by it, thus distinguishing it from constituents such as English conjunctive adverbs [Crystal 1997: 81]."</para>
    /// labels<para>"Connective"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/Connective">http://purl.org/linguistics/gold/Connective</seealso>
    let Connective = Prefixed_Name(gold, "Connective") |> PrefixedName
    /// <summary>
    ///   <para>gold:Consonant</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A type of sound segment defined by closure or constriction of the vocal tract, which produces an audible friction. The vocal tract constriction does not have to result in complete blocking; it can simply be a restriction of air flow. [Crystal 1985: 66]"</para>
    /// labels<para>"Consonant"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/Consonant">http://purl.org/linguistics/gold/Consonant</seealso>
    let Consonant = Prefixed_Name(gold, "Consonant") |> PrefixedName
    /// <summary>
    ///   <para>gold:ContablativeCase</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"ContablativeCase expresses that  the referent of the noun it marks is the location 'from near' which another referent is moving. It has the meaning 'from near'. Kibrik says that Archi (aqc) possesses a nominal spatial form expressing ContablativeCase, namely -raš [Kibrik 1998: 470]."</para>
    /// labels<para>"ContablativeCase"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/ContablativeCase">http://purl.org/linguistics/gold/ContablativeCase</seealso>
    let ContablativeCase = Prefixed_Name(gold, "ContablativeCase") |> PrefixedName
    /// <summary>
    ///   <para>gold:ContallativeCase</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"ContallativeCase expresses that  something is moving toward the vicinity of the referent of the noun it marks. It has the meaning  'towards the vicinity of'. Kibrik says that Archi (aqc) possesses a nominal spatial form expressing ContallativeCase, namely -rši [Kibrik 1998: 470]."</para>
    /// labels<para>"ContallativeCase"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/ContallativeCase">http://purl.org/linguistics/gold/ContallativeCase</seealso>
    let ContallativeCase = Prefixed_Name(gold, "ContallativeCase") |> PrefixedName
    /// <summary>
    ///   <para>gold:ConterminativeCase</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"ConterminativeCase expresses the notion of something moving into the vicinity of the referent of the noun it marks, but not through that region. It has the meaning 'moving into the vicinity of'. Kibrik says that Archi (aqc) possesses a nominal spatial form expressing ConterminativeCase, namely -rakana [Kibrik 1998: 470]."</para>
    /// labels<para>"ConterminativeCase"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/ConterminativeCase">http://purl.org/linguistics/gold/ConterminativeCase</seealso>
    let ConterminativeCase = Prefixed_Name(gold, "ConterminativeCase") |> PrefixedName
    /// <summary>
    ///   <para>gold:ContextOfUseTaxon</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"ContextOfUseTaxon is the class of taxons whose instances  classify language varieties according to how they are primarily used."</para>
    /// labels<para>"ContextOfUseTaxon"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/ContextOfUseTaxon">http://purl.org/linguistics/gold/ContextOfUseTaxon</seealso>
    let ContextOfUseTaxon = Prefixed_Name(gold, "ContextOfUseTaxon") |> PrefixedName
    /// <summary>
    ///   <para>gold:ContinuousAspect</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A value of Aspect Property assigned to the designated element in the clause when the meaning selected for the clause is that which indicates that the situation spoken about has internal temporal structure, but the situation cannot be regarded as habitual (i.e. it cannot be regarded as a characteristic feature of a whole period). Hence, continuousness can be defined negatively as imperfectivity that is not habituality [Comrie 1976: 26-32], and it can be regarded as a sub-type of imperfectivity.
    ///
    /// Typically, for an aspect value to be labelled as Continuous, the aspectual meaning has to minimally express continuousness, although it may additionally express other temporal, aspectual, or modal meanings, or actionality distinctions.
    ///
    /// Continuous aspectual meaning can be further subdivided into two types: progressive meaning and nonprogressive meaning. These two aspectual meanings may or may not be grammaticalised as separate aspect values. [Kibort 2008c: 8]"</para>
    /// labels<para>"ContinuousAspect"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/ContinuousAspect">http://purl.org/linguistics/gold/ContinuousAspect</seealso>
    let ContinuousAspect = Prefixed_Name(gold, "ContinuousAspect") |> PrefixedName
    /// <summary>
    ///   <para>gold:ContlativeCase</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"ContlativeCase expresses that  the referent of the noun it marks is the location in the vicinity of which another referent is moving. It has the meaning 'in the vicinity of'. Kibrik says that Archi (aqc) possesses a nominal spatial form expressing ContlativeCase, namely -rak [Kibrik 1998: 470]."</para>
    /// labels<para>"ContlativeCase"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/ContlativeCase">http://purl.org/linguistics/gold/ContlativeCase</seealso>
    let ContlativeCase = Prefixed_Name(gold, "ContlativeCase") |> PrefixedName
    /// <summary>
    ///   <para>gold:Converb</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A nonfinite verb form, i.e., lacking specifications for tense, mood, and agreement with their arguments, whose main function is to mark adverbial subordination. Converbal constructions are generally not arguments but modifiers, and they generally modify verbs, clauses or sentences, but not nouns or noun phrases. They are embedded or incorporated into the superordinate clause, and contrast with coordinate constructions. Converbal constructions can often be paraphrased by means of coordinate constructions in languages that allow coordination of clauses, such as in the gloss for the Korean example below. [Haspelmath 1995: 3-8]"</para>
    /// labels<para>"Converb"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/Converb">http://purl.org/linguistics/gold/Converb</seealso>
    let Converb = Prefixed_Name(gold, "Converb") |> PrefixedName

    /// <summary>
    ///   <para>gold:CoordinatingConnective</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A coordinating connective is a connective that links constituents without syntactically subordinating one to the other [Crystal 1997: 93]."</para>
    /// labels<para>"CoordinatingConnective"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/CoordinatingConnective">http://purl.org/linguistics/gold/CoordinatingConnective</seealso>
    let CoordinatingConnective =
        Prefixed_Name(gold, "CoordinatingConnective") |> PrefixedName

    /// <summary>
    ///   <para>gold:Copula</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Indicates a relationship of equivalency between the subject and predicate or complement of a clause. Verbal copulas have essentially the same morphosyntactic properties as verbs: English  'be', Spanish  'ser', and Russian  'byt’' are illustrations of this class. Nonverbal copular items include the the pro-copula - a demonstrative or personal pronoun which serves as the linker between subject and predicate nominal, and which is obligatory in nominal predication - and particle copulas, which have their origin in a variety of markers of discourse-oriented phenomena such as topicalization, backgrounding, or contrastive focus for subjects or predicates. Zero copula refers to a construction in which the relation between a subject and a nominal predicate is not marked by an overt item. Zero copula is mandatory in some languages, such as Sinhalese, whereas it is conditional or restricted in other languages, such as Russian. [Stassen 2008]"</para>
    /// labels<para>"Copula"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/Copula">http://purl.org/linguistics/gold/Copula</seealso>
    let Copula = Prefixed_Name(gold, "Copula") |> PrefixedName
    /// <summary>
    ///   <para>gold:Copulative</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A verb such as 'be', 'seem', 'become', 'look', etc. which relates the subject to the complement, e.g. in 'He is a teacher', 'The policeman seemed not at all satisfied', 'It got worse and and worse'. [Hartmann and Stork 1972: 55]"</para>
    /// labels<para>"Copulative"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/Copulative">http://purl.org/linguistics/gold/Copulative</seealso>
    let Copulative = Prefixed_Name(gold, "Copulative") |> PrefixedName
    /// <summary>
    ///   <para>gold:CoronalProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Properties of sounds produced with passive articulators either lying on the coronal axis, with the blade of the tongue raised from its neutral position, or in the neutral position (for non-coronal sounds).  [Crystal 1980: 94]"</para>
    /// labels<para>"CoronalProperty"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/CoronalProperty">http://purl.org/linguistics/gold/CoronalProperty</seealso>
    let CoronalProperty = Prefixed_Name(gold, "CoronalProperty") |> PrefixedName

    /// <summary>
    ///   <para>gold:CorrelativeConnective</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A correlative connective is either of a pair of  coordinating conjunctions (connectives) used in ordered fashion. Typically, one is used immediately before each member of a pair of constituents [Crystal 1997: 96]."</para>
    /// labels<para>"CorrelativeConnective"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/CorrelativeConnective">http://purl.org/linguistics/gold/CorrelativeConnective</seealso>
    let CorrelativeConnective =
        Prefixed_Name(gold, "CorrelativeConnective") |> PrefixedName

    /// <summary>
    ///   <para>gold:Creaky</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A term referring to a vocal quality in phonetic sound classification in which only one end of the vocal cords vibrates, and does so very slowly.  This is a permanent feature of some speakers' voices. [Crystal 1980: 97]"</para>
    /// labels<para>"Creaky"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/Creaky">http://purl.org/linguistics/gold/Creaky</seealso>
    let Creaky = Prefixed_Name(gold, "Creaky") |> PrefixedName
    /// <summary>
    ///   <para>gold:DativeCase</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"DativeCase marks 1) Indirect objects (for languages in which they are held to exist) or 2) nouns having the role of recipient (as of things given), beneficiary of an action, or possessor of an item [Crystal 1980: 102]."</para>
    /// labels<para>"DativeCase"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/DativeCase">http://purl.org/linguistics/gold/DativeCase</seealso>
    let DativeCase = Prefixed_Name(gold, "DativeCase") |> PrefixedName
    /// <summary>
    ///   <para>gold:DeclarativeForce</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Declarative force marks an unqualified assertion. This form is generally unmarked for modality, and thus may also be seen as Realis, while modal forms are Irrealis. In English, the Declarative is marked by the absence of a modal verb, although it will be marked for the other verbal categories, tense and aspect. [Palmer 2001: 64]"</para>
    ///   <para>"A term used in the grammatical classification of sentence types, and usually seen in contrast to imperative, interrogative, etc. It refers to verb forms or sentence/clause types typically used in the expression of statements, e.g. 'the man is walking'. The term 'indicative' is also sometimes used in this sense. [Crystal 2003: 124]"</para>
    /// labels<para>"DeclarativeForce"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/DeclarativeForce">http://purl.org/linguistics/gold/DeclarativeForce</seealso>
    let DeclarativeForce = Prefixed_Name(gold, "DeclarativeForce") |> PrefixedName

    /// <summary>
    ///   <para>gold:DeductiveEvidentiality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"DeductiveEvidentiality encodes the fact that the speaker came to believe the content of the expression through a sound inference procedure. [Palmer 2001: 6-8]."</para>
    /// labels<para>"DeductiveEvidentiality"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/DeductiveEvidentiality">http://purl.org/linguistics/gold/DeductiveEvidentiality</seealso>
    let DeductiveEvidentiality =
        Prefixed_Name(gold, "DeductiveEvidentiality") |> PrefixedName

    /// <summary>
    ///   <para>gold:DefiniteArticle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An definite article is a part of speech whose members refer to a specific, identifiable entity (or class of entities) [Crystal 1997: 107]."</para>
    /// labels<para>"DefiniteArticle"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/DefiniteArticle">http://purl.org/linguistics/gold/DefiniteArticle</seealso>
    let DefiniteArticle = Prefixed_Name(gold, "DefiniteArticle") |> PrefixedName
    /// <summary>
    ///   <para>gold:DelativeCase</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"DelativeCase expresses motion downward from the referent of the noun it marks [Pei and Gaynor 1954: 53]."</para>
    /// labels<para>"DelativeCase"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/DelativeCase">http://purl.org/linguistics/gold/DelativeCase</seealso>
    let DelativeCase = Prefixed_Name(gold, "DelativeCase") |> PrefixedName
    /// <summary>
    ///   <para>gold:Demonstrative</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A demonstrative is a determiner that is used deictically to indicate a referent's spatial, temporal, or discourse location. A demonstrative functions as a modifier of a noun, or a pronoun [Crystal 1997: 312]."</para>
    /// labels<para>"Demonstrative"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/Demonstrative">http://purl.org/linguistics/gold/Demonstrative</seealso>
    let Demonstrative = Prefixed_Name(gold, "Demonstrative") |> PrefixedName
    /// <summary>
    ///   <para>gold:Dental</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A consonant which involves the teeth, normally the upper teeth, as the passive articulators in its articulation. The tip or apex  of the tongue usually acts as the active articulator. [Hartmann and Stork 1972: 61]"</para>
    /// labels<para>"Dental"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/Dental">http://purl.org/linguistics/gold/Dental</seealso>
    let Dental = Prefixed_Name(gold, "Dental") |> PrefixedName
    /// <summary>
    ///   <para>gold:DeonticModality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Deontic modality is concerned with the necessity or possibility of acts performed by morally responsible agents and is thus associated with the social functions of permission and obligation. Deontic modality focuses on the notions of obligation and permission. It is found in directives that grant permission (‘you may go now’) or impose obligations (‘eat your vegetables!’), as well as in statements that report deontic conditions. Deontic modality fails to distinguish subcategories that are expressed inflectionally from lexical or periphrastic expressions of obligation or permission. Deontic modality as traditionally understood excludes certain semantically related notions such as ability and desire that have linguistic expression similar to that of permission and obligation. [Bybee and Fleischman 1995: 4-5]"</para>
    /// labels<para>"DeonticModality"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/DeonticModality">http://purl.org/linguistics/gold/DeonticModality</seealso>
    let DeonticModality = Prefixed_Name(gold, "DeonticModality") |> PrefixedName
    /// <summary>
    ///   <para>gold:DeponentMiddleVoice</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Action denotes physical/mental disposition of subject. [Siewierska 1988: 257]"</para>
    /// labels<para>"DeponentMiddleVoice"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/DeponentMiddleVoice">http://purl.org/linguistics/gold/DeponentMiddleVoice</seealso>
    let DeponentMiddleVoice = Prefixed_Name(gold, "DeponentMiddleVoice") |> PrefixedName

    /// <summary>
    ///   <para>gold:DerivationalMorpheme</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"DerivationalUnit is the class of functional units whose members function to derive a new lexical unit from an existing one, by systematically changing the meaning and possibly altering the part of speech feature of the root or stem it attaches to [Hartmann and Stork 1972: 62; Crystal 1985: 89; Bybee 1985: 81-82, 99]."</para>
    /// labels<para>"DerivationalMorpheme"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/DerivationalMorpheme">http://purl.org/linguistics/gold/DerivationalMorpheme</seealso>
    let DerivationalMorpheme =
        Prefixed_Name(gold, "DerivationalMorpheme") |> PrefixedName

    /// <summary>
    ///   <para>gold:DescribedVariety</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"DescribedVariety is the class of  distinct human languages or language varieties as recognized by a linguist or a particular linguistic community, but not necessarily recognized by the ISO 639-3 standard. This category allows a language to be described even though it is not (yet) included in ISO 639-3."</para>
    /// labels<para>"DescribedVariety"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/DescribedVariety">http://purl.org/linguistics/gold/DescribedVariety</seealso>
    let DescribedVariety = Prefixed_Name(gold, "DescribedVariety") |> PrefixedName
    /// <summary>
    ///   <para>gold:Determiner</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A Determiner is a part of speech whose members belong to a class of noun modifiers and express the reference, including  quantity, of a noun [Crystal 1997: 112]."</para>
    /// labels<para>"Determiner"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/Determiner">http://purl.org/linguistics/gold/Determiner</seealso>
    let Determiner = Prefixed_Name(gold, "Determiner") |> PrefixedName
    /// <summary>
    ///   <para>gold:Diacritic</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An auxiliary mark or symbol added above, below or after conventional graphic signs to give more information about the pronunciation of the sound represented in writing. Such diacritic marks include acute accent, apostrophe, caret, cedilla, diaeresis or umlaut, grave accent, macron, tilde and circumflex. [Hartmann and Stork 1972: 65]"</para>
    /// labels<para>"Diacritic"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/Diacritic">http://purl.org/linguistics/gold/Diacritic</seealso>
    let Diacritic = Prefixed_Name(gold, "Diacritic") |> PrefixedName
    /// <summary>
    ///   <para>gold:Dialect</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A regional, temporal or social variety of a language, differing in pronunciation, grammar and vocabulary from the standard language,which is in itself a socially favoured dialect. [Hartmann and Stork 1972: 65]"</para>
    /// labels<para>"Dialect"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/Dialect">http://purl.org/linguistics/gold/Dialect</seealso>
    let Dialect = Prefixed_Name(gold, "Dialect") |> PrefixedName
    /// <summary>
    ///   <para>gold:Digraph</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A term used in phonetics/phonology and graphics/graphology to refer to a graphic unit in which two symbols have combined to form a single element in a system. In the study of reading and spelling, digraph refers to any sequence of two letters pronounced as a single sound. [Crystal 2003: 139]"</para>
    /// labels<para>"Digraph"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/Digraph">http://purl.org/linguistics/gold/Digraph</seealso>
    let Digraph = Prefixed_Name(gold, "Digraph") |> PrefixedName
    /// <summary>
    ///   <para>gold:DiminuativeSize</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A special form of a noun that signals that the object being referred to is small relative to the usual size of such an object.  In some cases it may be used as a term of endearment [Crystal 1980: 116]."</para>
    /// labels<para>"DiminuativeSize"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/DiminuativeSize">http://purl.org/linguistics/gold/DiminuativeSize</seealso>
    let DiminuativeSize = Prefixed_Name(gold, "DiminuativeSize") |> PrefixedName
    /// <summary>
    ///   <para>gold:DirectEvidentiality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"DirectEvidential, also called sensory, encodes the fact that the speaker came to believe the content of the expression by having direct sensory experience of some situation; this does not include hearing about it from someone else [Palmer 2001: 35-36]."</para>
    /// labels<para>"DirectEvidentiality"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/DirectEvidentiality">http://purl.org/linguistics/gold/DirectEvidentiality</seealso>
    let DirectEvidentiality = Prefixed_Name(gold, "DirectEvidentiality") |> PrefixedName
    /// <summary>
    ///   <para>gold:DirectVoice</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Direct voice signals that the action proceeds in an ontologically salient way, i.e. that salience is assigned to nominals based on their referent's relative real-world capacities to control situations. [Klaiman 1991: 32]"</para>
    /// labels<para>"DirectVoice"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/DirectVoice">http://purl.org/linguistics/gold/DirectVoice</seealso>
    let DirectVoice = Prefixed_Name(gold, "DirectVoice") |> PrefixedName
    /// <summary>
    ///   <para>gold:DiscourseProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"DiscourseProperty"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/DiscourseProperty">http://purl.org/linguistics/gold/DiscourseProperty</seealso>
    let DiscourseProperty = Prefixed_Name(gold, "DiscourseProperty") |> PrefixedName
    /// <summary>
    ///   <para>gold:DiscourseUnit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Discourse is the name given to stretches of language longer than one sentence, e.g., conversations, narratives, arguments, and speeches. A discourse unit is an identifiable structure within a discourse. The form of a discourse unit is partly determined by genre and partly by its social context. [Aristar-Dry 2010 (p.c.); based on Mills 1997]"</para>
    /// labels<para>"DiscourseUnit"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/DiscourseUnit">http://purl.org/linguistics/gold/DiscourseUnit</seealso>
    let DiscourseUnit = Prefixed_Name(gold, "DiscourseUnit") |> PrefixedName
    /// <summary>
    ///   <para>gold:Disjunction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Disjunction refers to a process whose primary function is to mark a relationship of contrast or comparison between structures, using such disjunctive items as 'or' and 'but'. [Crystal 1985: 97]"</para>
    /// labels<para>"Disjunction"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/Disjunction">http://purl.org/linguistics/gold/Disjunction</seealso>
    let Disjunction = Prefixed_Name(gold, "Disjunction") |> PrefixedName
    /// <summary>
    ///   <para>gold:DistributiveAspect</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A verbal aspect expressing that the action or state denoted by the verb is performed or experienced simultaneously by more than one individual or object. [Pei and Gaynor 1954: 59]"</para>
    /// labels<para>"DistributiveAspect"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/DistributiveAspect">http://purl.org/linguistics/gold/DistributiveAspect</seealso>
    let DistributiveAspect = Prefixed_Name(gold, "DistributiveAspect") |> PrefixedName
    /// <summary>
    ///   <para>gold:DistributiveNumeral</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Most languages also have various series of numerals, whose denotations combine the concept of number with other concepts of a variety of different kinds. The meaning of sentences containing distributive numerals can be described in terms of a binary semantic relationship of distributivity that obtains between an expression containing the distributive numeral, the distributive share, and some other expression in the sentence, the distributive key. [Gill 2005: 222] Distributive numerals are special adnominal numerals that express distributive relations, as in German ‘Die Männer trugen je drei Koffer’, ‘The men carried three suitcases each.’ English lacks distributive numerals, because in a sentence like ‘They carried three suitcases each, the numeral does not form a continuous constituent with the distributive word ‘each’, i.e. ‘three…each’ does not qualify as a numeral. [Michaelis, Maurer, Haspelmath and Huber 2008]"</para>
    /// labels<para>"DistributiveNumeral"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/DistributiveNumeral">http://purl.org/linguistics/gold/DistributiveNumeral</seealso>
    let DistributiveNumeral = Prefixed_Name(gold, "DistributiveNumeral") |> PrefixedName
    /// <summary>
    ///   <para>gold:DitransitiveVerb</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A ditransitive verb is a verb that takes two objects [Crystal 1997: 397]."</para>
    /// labels<para>"DitransitiveVerb"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/DitransitiveVerb">http://purl.org/linguistics/gold/DitransitiveVerb</seealso>
    let DitransitiveVerb = Prefixed_Name(gold, "DitransitiveVerb") |> PrefixedName
    /// <summary>
    ///   <para>gold:DorsalProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The class of properties associated with sounds made with the body of the tongue [Ladefoged 1997: 601]. Almost all vowels can be described using subclasses of this property."</para>
    /// labels<para>"DorsalProperty"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/DorsalProperty">http://purl.org/linguistics/gold/DorsalProperty</seealso>
    let DorsalProperty = Prefixed_Name(gold, "DorsalProperty") |> PrefixedName
    /// <summary>
    ///   <para>gold:DualNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The dual quantifies the denotation of the nominal element by specifying that there are exactly 'two' (as in Upper Sorbian, see [Corbett 2000: 20] for examples and discussion. Additionally, but not necessarily, this value may be assigned on the basis of the formal properties of the nominal element (as in dualia tantum, e.g. mangautek 'scissors' in the Yukon dialect of Central Alaskan Yupik; [Jacobson 1984: 226]). The use of the dual varies across languages which have this value. In some languages, dual may be used to refer to any two entities, but in others it must refer to a natural pair such as eyes, and still in others it must refer to two items unless they are a natural pair [Corbett 2000]. [Kibort and Corbett 2008b]"</para>
    /// labels<para>"DualNumber"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/DualNumber">http://purl.org/linguistics/gold/DualNumber</seealso>
    let DualNumber = Prefixed_Name(gold, "DualNumber") |> PrefixedName
    /// <summary>
    ///   <para>gold:DubitiveMood</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"DubitiveMood indicates a speaker's doubt or uncertainty about a proposition. [Palmer 2001: 24-25]"</para>
    /// labels<para>"DubitiveMood"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/DubitiveMood">http://purl.org/linguistics/gold/DubitiveMood</seealso>
    let DubitiveMood = Prefixed_Name(gold, "DubitiveMood") |> PrefixedName
    /// <summary>
    ///   <para>gold:DurativeAspect</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Events which involve some duration [Bhat 1999: 58]."</para>
    /// labels<para>"DurativeAspect"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/DurativeAspect">http://purl.org/linguistics/gold/DurativeAspect</seealso>
    let DurativeAspect = Prefixed_Name(gold, "DurativeAspect") |> PrefixedName
    /// <summary>
    ///   <para>gold:ElativeCase</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"ElativeCase expresses that the referent of the noun it marks is the location out of which another referent is moving. It has the meaning 'out of' [Lyons 1968: 299; Pei and Gaynor 1954: 64; Crystal 1985: 106]."</para>
    /// labels<para>"ElativeCase"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/ElativeCase">http://purl.org/linguistics/gold/ElativeCase</seealso>
    let ElativeCase = Prefixed_Name(gold, "ElativeCase") |> PrefixedName
    /// <summary>
    ///   <para>gold:Enclitic</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An enclitic is a clitic that is phonologically joined at the end of a preceding lexical unit to form a single phonological unit [Crystal 1980: 64; Pei and Gaynor 1954: 65]."</para>
    /// labels<para>"Enclitic"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/Enclitic">http://purl.org/linguistics/gold/Enclitic</seealso>
    let Enclitic = Prefixed_Name(gold, "Enclitic") |> PrefixedName
    /// <summary>
    ///   <para>gold:EndangermentTaxon</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"There are a number of ways to categorize language endangerment situations. One useful taxonomy takes into account the relative rate of attrition together with its causes. This taxonomy recognizes four different categories of attrition: sudden, radical, gradual and top to bottom. [Brown and Ogilvie 2009: 321]"</para>
    /// labels<para>"EndangermentTaxon"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/EndangermentTaxon">http://purl.org/linguistics/gold/EndangermentTaxon</seealso>
    let EndangermentTaxon = Prefixed_Name(gold, "EndangermentTaxon") |> PrefixedName
    /// <summary>
    ///   <para>gold:EpistemicModality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"EpistemicModality indicates that a state of affairs is known to be possible or certain (necessary). [Palmer 2001: 7-8]"</para>
    /// labels<para>"EpistemicModality"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/EpistemicModality">http://purl.org/linguistics/gold/EpistemicModality</seealso>
    let EpistemicModality = Prefixed_Name(gold, "EpistemicModality") |> PrefixedName

    /// <summary>
    ///   <para>gold:EpistemicNecessityModality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"EpistemicNecessityModality indicates that the expressed proposition is known to be true. Also known as CategoricalModality [Palmer 2001: 37, 68-69]."</para>
    /// labels<para>"EpistemicNecessityModality"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/EpistemicNecessityModality">http://purl.org/linguistics/gold/EpistemicNecessityModality</seealso>
    let EpistemicNecessityModality =
        Prefixed_Name(gold, "EpistemicNecessityModality") |> PrefixedName

    /// <summary>
    ///   <para>gold:EpistemicPossibilityModality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"EpistemicPossibilityModality indicates that the designated state of affairs is not known not to be true."</para>
    /// labels<para>"EpistemicPossibilityModality"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/EpistemicPossibilityModality">http://purl.org/linguistics/gold/EpistemicPossibilityModality</seealso>
    let EpistemicPossibilityModality =
        Prefixed_Name(gold, "EpistemicPossibilityModality") |> PrefixedName

    /// <summary>
    ///   <para>gold:ErgativeCase</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"ErgativeCase in ergative-absolutive languages generally identifies the subject of transitive verbs in the translation equivalents of nominative-accusative Languages such as English [Crystal 1980: 134; Hartmann and Stork 1972: 78; Pei and Gaynor 1954: 67; Andrews 1985: 138]."</para>
    /// labels<para>"ErgativeCase"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/ErgativeCase">http://purl.org/linguistics/gold/ErgativeCase</seealso>
    let ErgativeCase = Prefixed_Name(gold, "ErgativeCase") |> PrefixedName
    /// <summary>
    ///   <para>gold:EssiveCase</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"EssiveCase expresses that  the referent of the noun it marks is the location at which another referent exists [Lyons 1968: 299, 301; Crystal 1985: 112; Blake 2001]."</para>
    /// labels<para>"EssiveCase"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/EssiveCase">http://purl.org/linguistics/gold/EssiveCase</seealso>
    let EssiveCase = Prefixed_Name(gold, "EssiveCase") |> PrefixedName
    /// <summary>
    ///   <para>gold:EvaluativeProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A term used in semantics for a type of modality where propositions express the speaker’s attitude (e.g. surprise, regret) towards what is being said. [Crystal 2003: 168]"</para>
    /// labels<para>"EvaluativeProperty"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/EvaluativeProperty">http://purl.org/linguistics/gold/EvaluativeProperty</seealso>
    let EvaluativeProperty = Prefixed_Name(gold, "EvaluativeProperty") |> PrefixedName

    /// <summary>
    ///   <para>gold:EvidentialityProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Evidentiality denotes the basis that the speaker has for claiming that the event has occurred (or is going to take place). Appear to show a greater number of distinctions in the realis mood (especially in the past tense) than the irrealis mood. [Bhat 1999: 63-64, 70]"</para>
    /// labels<para>"EvidentialityProperty"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/EvidentialityProperty">http://purl.org/linguistics/gold/EvidentialityProperty</seealso>
    let EvidentialityProperty =
        Prefixed_Name(gold, "EvidentialityProperty") |> PrefixedName

    /// <summary>
    ///   <para>gold:ExistentialMarker</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An existential marker is a syntactic category whose members are found in distinct clause types and which mark a referent's existence [Crystal 1997: 142]."</para>
    /// labels<para>"ExistentialMarker"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/ExistentialMarker">http://purl.org/linguistics/gold/ExistentialMarker</seealso>
    let ExistentialMarker = Prefixed_Name(gold, "ExistentialMarker") |> PrefixedName
    /// <summary>
    ///   <para>gold:Expletive</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An expletive (also known as a dummy word) is a part of speech whose members have no meaning, but complete a sentence to make it grammatical [Crystal 1997: 127]."</para>
    /// labels<para>"Expletive"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/Expletive">http://purl.org/linguistics/gold/Expletive</seealso>
    let Expletive = Prefixed_Name(gold, "Expletive") |> PrefixedName
    /// <summary>
    ///   <para>gold:ExtinctVariety</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A language no longer used as a medium of oral communication in a speech community, e.g. Latin, Gothic, as opposed to living languages such as English, Japanese. [Hartmann and Stork 1972: 58]"</para>
    /// labels<para>"ExtinctVariety"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/ExtinctVariety">http://purl.org/linguistics/gold/ExtinctVariety</seealso>
    let ExtinctVariety = Prefixed_Name(gold, "ExtinctVariety") |> PrefixedName

    /// <summary>
    ///   <para>gold:FeatureAgreementSystem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A type of FeatureDistributionSystem; in a given language, it is the system according to which feature values (of a particular feature) are determined for elements through agreement (i.e. where the form of the element is determined by the presence of another element). [Kibort 2008d]"</para>
    /// labels<para>"FeatureAgreementSystem"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/FeatureAgreementSystem">http://purl.org/linguistics/gold/FeatureAgreementSystem</seealso>
    let FeatureAgreementSystem =
        Prefixed_Name(gold, "FeatureAgreementSystem") |> PrefixedName

    /// <summary>
    ///   <para>gold:FeatureAssignmentSystem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"(The term 'assignment') was first used with respect to feature values by Corbett (1991) in his discussion of mechanisms for allotting nouns to different genders. Native speakers have the ability to ‘work out’ the gender of a noun, and models of this ability have been called ‘gender assignment systems’. So far, the concept of ‘assignment of a feature value’ has not been used outside gender. For some features, there may not be as much to say as for gender. However, using the concept of ‘assignment’ with respect to the values of all features is useful to be able to compare the features. Therefore, for this typology I have adopted the following definition: an assignment system is a set of rules that realise the value of a feature on an element. Note, however, that under this definition, a gender value is ‘assigned’ both to nouns, and to targets of agreement in gender with the noun. [Kibort 2008d: 8]"</para>
    /// labels<para>"FeatureAssignmentSystem"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/FeatureAssignmentSystem">http://purl.org/linguistics/gold/FeatureAssignmentSystem</seealso>
    let FeatureAssignmentSystem =
        Prefixed_Name(gold, "FeatureAssignmentSystem") |> PrefixedName

    /// <summary>
    ///   <para>gold:FeatureConstraint</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A term used in linguistics, and especially in generative grammar, to refer to a condition which restricts the application of a rule, to ensure that the sentences generated are well formed. For example, in generative phonology, a distinction can be made between ‘simulatenous’ and ‘sequential’ constraints: the former states the restrictions on the simulataneous occurrence of features, e.g. a segment cannot be at once [+high] and [+low]; the latter states the restrictions on sequences of features, e.g. whether a language permits consonant clusters. In generative syntax there are also several constraints which have to be imposed in order to prevent the derivation of ill formed phrase-markers, e.g. constraints on the ordering of rules. The notion of constraints takes on a different direction in optimality theory, where it is the principle explanatory device. Here, constraints are ways of characterizing language universals. Each language has its own ranking of constraints (e.g. which determine morpheme position or syllable structure), and differences between these rankings result in the variations observed between languages. [Crystal 2003: 101]"</para>
    /// labels<para>"FeatureConstraint"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/FeatureConstraint">http://purl.org/linguistics/gold/FeatureConstraint</seealso>
    let FeatureConstraint = Prefixed_Name(gold, "FeatureConstraint") |> PrefixedName

    /// <summary>
    ///   <para>gold:FeatureDistributionSystem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"In a given language, the system according to which feature values (of a particular feature) are determined contextually for elements, through agreement or government. FeatureDistributionSystem can have one or two main components: FeatureAgreementSystem, and FeatureGovernmentSystem. [Kibort 2008d]"</para>
    /// labels<para>"FeatureDistributionSystem"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/FeatureDistributionSystem">http://purl.org/linguistics/gold/FeatureDistributionSystem</seealso>
    let FeatureDistributionSystem =
        Prefixed_Name(gold, "FeatureDistributionSystem") |> PrefixedName

    /// <summary>
    ///   <para>gold:FeatureGovernmentSystem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The feature of case is typically involved in government. A governor does not bear the feature value it requires of its governee. Government is also asymmetric with regard to the possession of the feature specification by the elements. [Kibort 2008d: 1, 6]"</para>
    /// labels<para>"FeatureGovernmentSystem"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/FeatureGovernmentSystem">http://purl.org/linguistics/gold/FeatureGovernmentSystem</seealso>
    let FeatureGovernmentSystem =
        Prefixed_Name(gold, "FeatureGovernmentSystem") |> PrefixedName

    /// <summary>
    ///   <para>gold:FeatureSpecification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A FeatureSpecification is a data structure that groups together a linguistic feature with a value [Maxwell, Simons and Hayashi 2000]."</para>
    /// labels<para>"FeatureSpecification"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/FeatureSpecification">http://purl.org/linguistics/gold/FeatureSpecification</seealso>
    let FeatureSpecification =
        Prefixed_Name(gold, "FeatureSpecification") |> PrefixedName

    /// <summary>
    ///   <para>gold:FeatureStructure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A FeatureStructure is a set of one or more FeatureSpecifications. A FeatureStructure is a kind of information structure, a container or data structure, used to group together qualities or features of some object. In a grammatical feature system, a FeatureStructure holds the grammatical information associated with some linguistic unit. In a typed feature system, a FeatureStructure has an associated type, usually a PartOfSpeech. [Shieber 1986; Maxwell, Simons and Hayashi 2000]."</para>
    /// labels<para>"FeatureStructure"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/FeatureStructure">http://purl.org/linguistics/gold/FeatureStructure</seealso>
    let FeatureStructure = Prefixed_Name(gold, "FeatureStructure") |> PrefixedName
    /// <summary>
    ///   <para>gold:FeatureSystem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An utterance is divided into parts, which are assigned to word classes and then subclassified in terms of their "accidents" or properties. [Blevins 2006: 390] The properties, also referred to as features or categories, express what is shared by different linguistic elements, as opposed to what is idiosyncratic. [Kibort 2008d: 1]"</para>
    /// labels<para>"FeatureSystem"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/FeatureSystem">http://purl.org/linguistics/gold/FeatureSystem</seealso>
    let FeatureSystem = Prefixed_Name(gold, "FeatureSystem") |> PrefixedName
    /// <summary>
    ///   <para>gold:FeminineGender</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A gender property established on the basis of agreement, to which nouns may be assigned if 1) they inherently denote females. Additionally, but not necessarily, nouns may be assigned this value if: 2) their formal properties (morphological or phonological) lead them to be assigned to the same agreement pattern as other nouns within the language that have female denotation. 3) they are arbitrarily assigned to the same agreement pattern as other nouns in the language that have female denotation. [Corbett 1991]"</para>
    /// labels<para>"FeminineGender"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/FeminineGender">http://purl.org/linguistics/gold/FeminineGender</seealso>
    let FeminineGender = Prefixed_Name(gold, "FeminineGender") |> PrefixedName
    /// <summary>
    ///   <para>gold:FirstPerson</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"First is a  person property that refers minimally to the speaker. It may also refer to the speaker combined with either the addressee or the non-participant or both, allowing for the following subdivisions: a) first person b) first person inclusive c) first person exclusive [Cysouw 2003]."</para>
    /// labels<para>"FirstPerson"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/FirstPerson">http://purl.org/linguistics/gold/FirstPerson</seealso>
    let FirstPerson = Prefixed_Name(gold, "FirstPerson") |> PrefixedName

    /// <summary>
    ///   <para>gold:FirstPersonExclusive</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"FirstPersonExclusive"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/FirstPersonExclusive">http://purl.org/linguistics/gold/FirstPersonExclusive</seealso>
    let FirstPersonExclusive =
        Prefixed_Name(gold, "FirstPersonExclusive") |> PrefixedName

    /// <summary>
    ///   <para>gold:FirstPersonInclusive</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"FirstPersonInclusive"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/FirstPersonInclusive">http://purl.org/linguistics/gold/FirstPersonInclusive</seealso>
    let FirstPersonInclusive =
        Prefixed_Name(gold, "FirstPersonInclusive") |> PrefixedName

    /// <summary>
    ///   <para>gold:FocusAntipassiveVoice</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Blocks the patient or logical object (basic absolutive) nominal from being assigned Focus salience. Topic salience is available for assignment to various arguments, including the patient, but Focus salience is always assigned to agent, and is therefore inaccessible to the patient or any other nominal. [Klaiman 1991: 236] Dayley describes the focus antipassive as a rearranging voice whose primary function is to indicate that the agent of a transitive sentence is highlighted or in focus. The focus antipassive is used when the agent is in contrastive focus or highly emphatic, when the agent is questioned, and when the agent is relativized. [Dayley 1985: 348]"</para>
    /// labels<para>"FocusAntipassiveVoice"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/FocusAntipassiveVoice">http://purl.org/linguistics/gold/FocusAntipassiveVoice</seealso>
    let FocusAntipassiveVoice =
        Prefixed_Name(gold, "FocusAntipassiveVoice") |> PrefixedName

    /// <summary>
    ///   <para>gold:FolkloreEvidentiality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"FolkloreEvidentiality encodes the fact that the speaker came to believe the content of the expression through legend, folklore or some other established tradition [Palmer 2001: 40]."</para>
    /// labels<para>"FolkloreEvidentiality"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/FolkloreEvidentiality">http://purl.org/linguistics/gold/FolkloreEvidentiality</seealso>
    let FolkloreEvidentiality =
        Prefixed_Name(gold, "FolkloreEvidentiality") |> PrefixedName

    /// <summary>
    ///   <para>gold:Foot</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Used to describe the unit of rhythm in languages displaying isochrony, i.e. where the stressed syllables fall at approximately regular intervals throughout an utterance. It is an extension of the term used in traditional studies of metrical verse structure, where the many regular patterns of stressed/unstressed syllables were given a detailed classification. In a more general phonological sense, the notion is applied to any utterance in a stress-timed language, not just verse. [Crystal 1985: 123-124]"</para>
    /// labels<para>"Foot"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/Foot">http://purl.org/linguistics/gold/Foot</seealso>
    let Foot = Prefixed_Name(gold, "Foot") |> PrefixedName
    /// <summary>
    ///   <para>gold:ForceProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"ForceProperty is the class of properties that concern the grammatical encoding of the speech act associated with a proposition. Among the traditionally defined values are Declarative, Imperative and Interrogative. Force is here distinguished from Mood, but there is a close association of Mood with Force values, e.g. between IndicativeMood and DeclarativeForce."</para>
    /// labels<para>"ForceProperty"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/ForceProperty">http://purl.org/linguistics/gold/ForceProperty</seealso>
    let ForceProperty = Prefixed_Name(gold, "ForceProperty") |> PrefixedName
    /// <summary>
    ///   <para>gold:FormUnit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Denotes the sensorily perceptible aspect of the linguistic sign. [Bussmann 1996: 169]"</para>
    /// labels<para>"FormUnit"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/FormUnit">http://purl.org/linguistics/gold/FormUnit</seealso>
    let FormUnit = Prefixed_Name(gold, "FormUnit") |> PrefixedName

    /// <summary>
    ///   <para>gold:FormalAssignmentSystem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"One more distinction can be made within both types of inherently assigned feature values: that between formal and semantic assignment. This distinction was proposed by Corbett (1991) to account for the criteria according to which nouns can be allotted to genders. Corbett demonstrates that gender assignment systems in languages can be semantic or semantic-and-formal – that is, the set of rules that determine the assignment of inherent gender values to nouns refer to the meaning of words, or a combination of the meaning of words and the form of words. [Kibort 2008d: 12]"</para>
    /// labels<para>"FormalAssignmentSystem"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/FormalAssignmentSystem">http://purl.org/linguistics/gold/FormalAssignmentSystem</seealso>
    let FormalAssignmentSystem =
        Prefixed_Name(gold, "FormalAssignmentSystem") |> PrefixedName

    /// <summary>
    ///   <para>gold:FreeMorpheme</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A morpheme which can be used on its own as a word with a distinct meaning, as opposed to a bound morpheme. [Hartmann and Stork 1972: 88]"</para>
    /// labels<para>"FreeMorpheme"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/FreeMorpheme">http://purl.org/linguistics/gold/FreeMorpheme</seealso>
    let FreeMorpheme = Prefixed_Name(gold, "FreeMorpheme") |> PrefixedName
    /// <summary>
    ///   <para>gold:FrequentiveAspect</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Events which are frequently repeated, differs from habitual in that it can only be based upon the observation of several occurrences of the event concerned, whereas habitual can be based upon the observation of a single occurrence [Bhat 1999: 53]."</para>
    /// labels<para>"FrequentiveAspect"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/FrequentiveAspect">http://purl.org/linguistics/gold/FrequentiveAspect</seealso>
    let FrequentiveAspect = Prefixed_Name(gold, "FrequentiveAspect") |> PrefixedName
    /// <summary>
    ///   <para>gold:Fricative</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Fricative sounds are those in which a turbulent airstream is produced within the vocal tract. [Ladefoged and Maddieson 1996: 137]"</para>
    /// labels<para>"Fricative"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/Fricative">http://purl.org/linguistics/gold/Fricative</seealso>
    let Fricative = Prefixed_Name(gold, "Fricative") |> PrefixedName
    /// <summary>
    ///   <para>gold:Front</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The highest point of the tongue is in the front of the mouth. [Ladefoged 2000: 12]"</para>
    ///   <para>"A sound made with the front part of the tongue, in the area of the hard palate. [Pei and Gaynor 1980: 78]"</para>
    /// labels<para>"Front"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/Front">http://purl.org/linguistics/gold/Front</seealso>
    let Front = Prefixed_Name(gold, "Front") |> PrefixedName
    /// <summary>
    ///   <para>gold:Functor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Functor is the class of syntactic word whose members are neither relation- nor argument-like non-relational [Anderson 1997: 20]. Typical functors include adpositions, subordinators, and complementizers."</para>
    /// labels<para>"Functor"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/Functor">http://purl.org/linguistics/gold/Functor</seealso>
    let Functor = Prefixed_Name(gold, "Functor") |> PrefixedName
    /// <summary>
    ///   <para>gold:FutureInFutureTense</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"FutureInFutureTense locates the situation in question in the future, relative to a temporal reference point that itself is located in the future relative to the moment of utterance [Comrie 1985: 128]."</para>
    /// labels<para>"FutureInFutureTense"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/FutureInFutureTense">http://purl.org/linguistics/gold/FutureInFutureTense</seealso>
    let FutureInFutureTense = Prefixed_Name(gold, "FutureInFutureTense") |> PrefixedName
    /// <summary>
    ///   <para>gold:FutureInPastTense</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"FutureInPastTense locates the situation in question in the future, relative to a contextually determined temporal reference point that itself must be located in the past relative to the moment of utterance [Comrie 1985: 128]."</para>
    /// labels<para>"FutureInPastTense"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/FutureInPastTense">http://purl.org/linguistics/gold/FutureInPastTense</seealso>
    let FutureInPastTense = Prefixed_Name(gold, "FutureInPastTense") |> PrefixedName
    /// <summary>
    ///   <para>gold:FuturePerfectTense</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Describes an event that occurs after the time of speaking but before some reference point in time which also occurs after the time of speaking. This is also known as PastInFutureTense. [Comrie 1985: 126]"</para>
    /// labels<para>"FuturePerfectTense"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/FuturePerfectTense">http://purl.org/linguistics/gold/FuturePerfectTense</seealso>
    let FuturePerfectTense = Prefixed_Name(gold, "FuturePerfectTense") |> PrefixedName
    /// <summary>
    ///   <para>gold:FutureTense</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A value of Tense Property assigned to the designated element in the clause when the meaning selected for the clause is that intended to locate the event spoken about as posterior to the deictic centre of the utterance. Most commonly, this tense meaning is referred to as 'future', because in absolute tense systems the deictic centre is the moment of speech. However, in relative tense systems, where the deictic centre can be moved to any point on the time line, it is more appropriate to refer to this temporal relation as 'posterior'. The posterior temporal relation may obtain either in 'simple' or 'perfect' contexts. Modelling of this distinction originates from [Reichenbach 1947], who suggested using a third point in time, 'reference point', to capture all possible tense distinctions. In all 'simple' temporal relations, the reference point coincides with the location of the event spoken about. 'Perfect' tense meanings are created when the reference point is separated and moved away from the event time, thus altering the viewing of the temporal location of the event even though the event's actual location with respect to the deictic centre remains the same. Posterior temporal relationships obtaining in a 'perfect' context occur when the reference point is moved away from the event time. There are various logical possibilities for locating the reference point with respect to the other two points, though none of them seem to be typically grammaticalised as separate tenses. Typically, for a tense value to be labelled as Future Tense, the tense meaning has to minimally express the posterior temporal relationship, although it may additionally express other temporal, aspectual, or modal meanings. [Kibort 2008c: 5]"</para>
    /// labels<para>"FutureTense"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/FutureTense">http://purl.org/linguistics/gold/FutureTense</seealso>
    let FutureTense = Prefixed_Name(gold, "FutureTense") |> PrefixedName
    /// <summary>
    ///   <para>gold:GenderProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"GenderProperty is the class of properties that are assigned to nouns on the basis of their inherent properties by an AssignmentSystem and required by the syntax to appear on the target in an AgreementSystem. Gender may but need not be assigned on the basis of sex [Corbett 1991]."</para>
    /// labels<para>"GenderProperty"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/GenderProperty">http://purl.org/linguistics/gold/GenderProperty</seealso>
    let GenderProperty = Prefixed_Name(gold, "GenderProperty") |> PrefixedName
    /// <summary>
    ///   <para>gold:GeneralNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"In some languages for which number is less dominant, the meaning of the noun can be expressed without reference to number. Nouns with this marking are designated as outside of the number system, as they are noncommittal as to the number of the noun that they mark. [Corbett 2000: 9-10]"</para>
    /// labels<para>"GeneralNumber"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/GeneralNumber">http://purl.org/linguistics/gold/GeneralNumber</seealso>
    let GeneralNumber = Prefixed_Name(gold, "GeneralNumber") |> PrefixedName
    /// <summary>
    ///   <para>gold:GeneticTaxon</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"GeneticTaxon is the class of all taxons whose members are based on genetic relatedness."</para>
    /// labels<para>"GeneticTaxon"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/GeneticTaxon">http://purl.org/linguistics/gold/GeneticTaxon</seealso>
    let GeneticTaxon = Prefixed_Name(gold, "GeneticTaxon") |> PrefixedName
    /// <summary>
    ///   <para>gold:GenitiveCase</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"GenitiveCase is used to mark the noun whose referent is the possessor of the referent of another noun [Crystal 1980: 161; Hartmann and Stork 1972: 94-95, 180; Pei and Gaynor 1954: 82, 172; Anderson 1985: 185; Fleming 1988: 10]."</para>
    /// labels<para>"GenitiveCase"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/GenitiveCase">http://purl.org/linguistics/gold/GenitiveCase</seealso>
    let GenitiveCase = Prefixed_Name(gold, "GenitiveCase") |> PrefixedName
    /// <summary>
    ///   <para>gold:GeographicTaxon</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"GeographicTaxon is the class of linguistic taxons whose instances are groupings based on where, in general, the language varieties are used, e.g., AustralianLanguage."</para>
    /// labels<para>"GeographicTaxon"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/GeographicTaxon">http://purl.org/linguistics/gold/GeographicTaxon</seealso>
    let GeographicTaxon = Prefixed_Name(gold, "GeographicTaxon") |> PrefixedName
    /// <summary>
    ///   <para>gold:Gerund</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A part of speech derived from a verb and used as a noun, usually restricted to non-finite forms of the verb [Crystal 1997: 279]."</para>
    /// labels<para>"Gerund"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/Gerund">http://purl.org/linguistics/gold/Gerund</seealso>
    let Gerund = Prefixed_Name(gold, "Gerund") |> PrefixedName

    /// <summary>
    ///   <para>gold:GlottalMovementProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A phonation type containing the features 'raising' and 'lowering'. [Ladefoged and Maddieson 1996: 372]"</para>
    /// labels<para>"GlottalMovementProperty"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/GlottalMovementProperty">http://purl.org/linguistics/gold/GlottalMovementProperty</seealso>
    let GlottalMovementProperty =
        Prefixed_Name(gold, "GlottalMovementProperty") |> PrefixedName

    /// <summary>
    ///   <para>gold:GlottalStrictureProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The three phonation types are part of the five possible values of Glottal Stricture that are used by languages. Sounds can have the vocal cords tightly together, as in a glottal stop, or they can be far apart as in voiceless sounds, or they can have one of the three phonation types: breathy voice, modal voice and creaky voice. Although some phoneticians have shown how terms similar to these may be combinable from the phonetic point of view, the named terms form a set of phonologically mutually exclusive possibilities. These factors point to there being an ordered set of five possibilities: [voiceless], [breathy], [modal voice], [creaky] and [closed]. It is certainly appropriate to consider these glottal states as resulting from two physiological attributes of the vocal cords, their stiffness and their aperture. However from a linguistic point of view, the named values of the feature Glottal Stricture operate as a linearly ordered set of five mutually exclusive possibilities. [Ladefoged 1997: 607-608]"</para>
    /// labels<para>"GlottalStrictureProperty"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/GlottalStrictureProperty">http://purl.org/linguistics/gold/GlottalStrictureProperty</seealso>
    let GlottalStrictureProperty =
        Prefixed_Name(gold, "GlottalStrictureProperty") |> PrefixedName

    /// <summary>
    ///   <para>gold:GlottalTimingProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A phonation type containing the features 'aspirated' and 'unaspirated. Aspiration involves matters of relativing timing between laryngeal and oral articulations, and the wider opening can be viewed as an aspect of the control of this timing. There are two ways of interpreting this greather width; it can be seen as the essential aspect of the production of voiceless aspiration, that is, aspiration is an extra-wide opening of the vocal folds [Kim 1965], or it can be seen as a by-product of the mechanism by which a delay between the offset of the oral and glottal gestures is achieved, that is, aspiration is esentially a matter of the timing between speech movements controlling laryngeal setting and oral articulation [Goldstein and Browman 1986]. [Ladefoged and Maddieson 1996: 49-66; 372]"</para>
    /// labels<para>"GlottalTimingProperty"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/GlottalTimingProperty">http://purl.org/linguistics/gold/GlottalTimingProperty</seealso>
    let GlottalTimingProperty =
        Prefixed_Name(gold, "GlottalTimingProperty") |> PrefixedName

    /// <summary>
    ///   <para>gold:Glyph</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A Glyph is a symbol used in a writing system to represent some kind of linguistic unit, such as a single sound, a  phoneme or an entire word. Glyphs are concatenated in a writing system to form orthographic parts and orthographic words. Consider the printed word 'apple'. This word contains two instances of the 'p' glyph, which is a subclass of Glyph. Instances of a Glyph share a similar shape and can be called 'shapemes'. The class Glyph is not the same as Grapheme. A Grapheme is a contrastive unit within a particular writing system. The notion of a glyph is relevant across writing systems. For instance, consider the symbol 'р' used in a printed instance of a Russian word 'русский'. Now consider the symbol 'p' used in the printed instance of an English word 'pickle'. Both symbols are instances of the same Glyph. They share the same general shape, but do not have the same phonemic value."</para>
    ///   <para>"A shape that is the visual representation of a character. It is a graphic object stored within a font. Glyphs are objects that are recognizably related to particular characters and which are dependent on particular design. Glyphs may or may not correspond to characters in a one-to-one manner. For example, a single character may correspond to multiple glyphs that have complementary distributions based upon context (e.g. final and non-final sigma in Greek), or several characters may correspond to a single glyph known as a ligature. [Lyons, et al. 2001]"</para>
    /// labels<para>"Glyph"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/Glyph">http://purl.org/linguistics/gold/Glyph</seealso>
    let Glyph = Prefixed_Name(gold, "Glyph") |> PrefixedName
    /// <summary>
    ///   <para>gold:GrammarUnit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A GrammarUnit is the structural component of the linguistic sign and includes notions such as morpheme, syntactic word, and construction. Grammar units are classified according to their mereology (part-whole and complexity),  morphosyntactic function, and whether they exist in a bound or free forms."</para>
    /// labels<para>"GrammarUnit"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/GrammarUnit">http://purl.org/linguistics/gold/GrammarUnit</seealso>
    let GrammarUnit = Prefixed_Name(gold, "GrammarUnit") |> PrefixedName
    /// <summary>
    ///   <para>gold:Grapheme</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A Grapheme is the smallest meaningful contrastive unit in a writing system. A grapheme is an abstraction over a set of like glyphs, the actual images on the  page. That is, a particular grapheme is realized by particular glyphs. More than one glyph can realize the same grapheme. For instance, the letter A  and its cursive equivalent are each realizations of the grapheme Latin Capital Letter A."</para>
    ///   <para>"Crystal defines a grapheme as the minimal contrastive unit in the writing system of a language; usually enclosed in angle brackets. The grapheme &lt;a&gt;, for example, is realized as several allographs A, a, a, etc., which may be seen as units in complementary distribution (e.g. upper case restricted to sentence-initial position, proper names, etc.), or in free variation (as in some styles of handwriting), just as in phonemic analysis. 'Grapheme Analysis' is the main business of graphemics (or graphology). [Crystal 2008: 220]"</para>
    /// labels<para>"Grapheme"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/Grapheme">http://purl.org/linguistics/gold/Grapheme</seealso>
    let Grapheme = Prefixed_Name(gold, "Grapheme") |> PrefixedName
    /// <summary>
    ///   <para>gold:GreaterPaucalNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"GreaterPaucal is a number property that quantifies the denotation of the nominal element so that it specifies that there are a small number of distinct entities, greater than paucalNumber but less than pluralNumber (semantically similar to 'several' in English)."</para>
    /// labels<para>"GreaterPaucalNumber"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/GreaterPaucalNumber">http://purl.org/linguistics/gold/GreaterPaucalNumber</seealso>
    let GreaterPaucalNumber = Prefixed_Name(gold, "GreaterPaucalNumber") |> PrefixedName
    /// <summary>
    ///   <para>gold:GreaterPluralNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"GreaterPlural is a number property that expresses (a) the fact that there is an excessive number of events or entities denoted by the noun or nominal element, or (b) the fact that the noun or nominal denotes all possible instances. [Kibort and Corbett 2008b]"</para>
    /// labels<para>"GreaterPluralNumber"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/GreaterPluralNumber">http://purl.org/linguistics/gold/GreaterPluralNumber</seealso>
    let GreaterPluralNumber = Prefixed_Name(gold, "GreaterPluralNumber") |> PrefixedName
    /// <summary>
    ///   <para>gold:Group</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A term used in Hallidayan grammar to refer to a unit on the rank scale intermediate between clause and word. For example, in the sentence 'The car was parked in the street', 'the car' is a nominal group, 'was parked' is a verbal group, and 'in the street' is an adverbial group. The term Phrase is an equivalent in most other approaches. [Crystal 2008: 22]"</para>
    /// labels<para>"Group"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/Group">http://purl.org/linguistics/gold/Group</seealso>
    let Group = Prefixed_Name(gold, "Group") |> PrefixedName
    /// <summary>
    ///   <para>gold:HabitualAspect</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A value of Aspect Property assigned to the designated element in the clause when the meaning selected for the clause is that which indicates that the situation spoken about is characteristic of an extended period of time -- so extended that the situation is viewed as characteristic of the whole period. The decision that a situation is characteristic of an extended period of time is not in itself linguistic, but once it has been made, an explicitly habitual form can be used to describe it. Note that the classification of a situation as characteristic of a period of time is not derived directly from the comparison of their length or frequency; hence, the situation may be objectively either long or short, and either frequent or infrequent, with respect to the period it characterises. This is because the way we choose to characterise can involve a component which is objectively small in relation to the whole.
    /// Typically, for an aspect value to be labelled as Habitual, the aspectual meaning has to minimally express habituality, although it may additionally express other temporal, aspectual, or modal meanings, or actionality distinctions. Habituality can in principle be combined with any other semantic aspectual values appropriate to situations that can be protracted in time or iterated [Comrie 1976: 26-32]. Since habituality is concerned with the internal temporal structure of the (extended) event, it can be regarded as a sub-type of imperfectivity. [Kibort 2008c: 7]"</para>
    /// labels<para>"HabitualAspect"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/HabitualAspect">http://purl.org/linguistics/gold/HabitualAspect</seealso>
    let HabitualAspect = Prefixed_Name(gold, "HabitualAspect") |> PrefixedName

    /// <summary>
    ///   <para>gold:HearsayEvidentiality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"HearsayEvidentiality, also called third hand, encodes the fact that the speaker came to believe the content of the expression from a source generally considered less reliable than with a SecondHandEvidential [Palmer 2001: 40]."</para>
    /// labels<para>"HearsayEvidentiality"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/HearsayEvidentiality">http://purl.org/linguistics/gold/HearsayEvidentiality</seealso>
    let HearsayEvidentiality =
        Prefixed_Name(gold, "HearsayEvidentiality") |> PrefixedName

    /// <summary>
    ///   <para>gold:HeightProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The class of features describing sounds based on the relative vertical position of the tongue. Note, Ladefoged refers to this feature as High."</para>
    /// labels<para>"HeightProperty"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/HeightProperty">http://purl.org/linguistics/gold/HeightProperty</seealso>
    let HeightProperty = Prefixed_Name(gold, "HeightProperty") |> PrefixedName
    /// <summary>
    ///   <para>gold:HesternalPastTense</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"HesternalPastTense locates the situation in question somewhere in the span beginning with the period defined culturally as 'yesterday' and extends back through some period that is considered nonremote [Comrie 1985: 87-88; Dahl 1985: 126]."</para>
    /// labels<para>"HesternalPastTense"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/HesternalPastTense">http://purl.org/linguistics/gold/HesternalPastTense</seealso>
    let HesternalPastTense = Prefixed_Name(gold, "HesternalPastTense") |> PrefixedName
    /// <summary>
    ///   <para>gold:High</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Description of the actual articulatory characteristics of vowels, and taken to specify the highest point of the tongue. In this view each vowel is characterized in terms of the distance of the highest point of the tongue from the roof of the mouth. [Ladefoged and Maddieson 1996: 282-285]"</para>
    /// labels<para>"High"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/High">http://purl.org/linguistics/gold/High</seealso>
    let High = Prefixed_Name(gold, "High") |> PrefixedName

    /// <summary>
    ///   <para>gold:HodiernalFutureTense</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"HodiernalFutureTense locates the situation in question after the moment of utterance within the span culturally defined as 'today' [Comrie 1985: 86; Bybee, Perkins and Pagliuca 1994: 247]."</para>
    /// labels<para>"HodiernalFutureTense"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/HodiernalFutureTense">http://purl.org/linguistics/gold/HodiernalFutureTense</seealso>
    let HodiernalFutureTense =
        Prefixed_Name(gold, "HodiernalFutureTense") |> PrefixedName

    /// <summary>
    ///   <para>gold:HodiernalPastTense</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"HodiernalPastTense locates the situation in question before the moment of utterance within the span culturally defined as 'today' [Comrie 1985: 87; Dahl 1985: 125-126]. Contrasts with PreHodiernalPastTense."</para>
    /// labels<para>"HodiernalPastTense"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/HodiernalPastTense">http://purl.org/linguistics/gold/HodiernalPastTense</seealso>
    let HodiernalPastTense = Prefixed_Name(gold, "HodiernalPastTense") |> PrefixedName
    /// <summary>
    ///   <para>gold:HortatoryForce</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A term sometimes used in the grammatical analysis of verbs, to refer to a type of modal meaning in which an exhortation is made. An example of a hortative usage ('a hortative') is the 'let us' construction in English ('let us pray'). [Crystal 2008: 232]"</para>
    /// labels<para>"HortatoryForce"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/HortatoryForce">http://purl.org/linguistics/gold/HortatoryForce</seealso>
    let HortatoryForce = Prefixed_Name(gold, "HortatoryForce") |> PrefixedName
    /// <summary>
    ///   <para>gold:HumanGender</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A grammatical category used for analysis of word-classes displaying such contrasts as masculine/feminine/neuter, animate/inanimate, etc. It is also important to distinguish natural gender, items referring to the sex of real-world entities, and grammatical gender, which does not always correspond to sex, but which has an important role in signaling grammatical relations between words in a sentence. [Crystal 1985: 133]"</para>
    /// labels<para>"HumanGender"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/HumanGender">http://purl.org/linguistics/gold/HumanGender</seealso>
    let HumanGender = Prefixed_Name(gold, "HumanGender") |> PrefixedName

    /// <summary>
    ///   <para>gold:HumanLanguageVariety</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A term used in sociolinguistics and stylistics to refer to any system of linguistic expression whose use is governed by situational variables. In some cases, the situational distinctiveness of the language may be easily stated, as in many regional and occupational varieties; in other cases, as in studies of social class, the varieties are more difficult to define, involving the intersection of several variables. [Crystal 1997: 408]"</para>
    /// labels<para>"HumanLanguageVariety"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/HumanLanguageVariety">http://purl.org/linguistics/gold/HumanLanguageVariety</seealso>
    let HumanLanguageVariety =
        Prefixed_Name(gold, "HumanLanguageVariety") |> PrefixedName

    /// <summary>
    ///   <para>gold:IllativeCase</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"IllativeCase expresses that  the referent of the noun it marks is the location into which another referent is moving. It has the meaning 'into' [Lyons 1968: 299; Crystal 1985: 152]."</para>
    /// labels<para>"IllativeCase"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/IllativeCase">http://purl.org/linguistics/gold/IllativeCase</seealso>
    let IllativeCase = Prefixed_Name(gold, "IllativeCase") |> PrefixedName

    /// <summary>
    ///   <para>gold:ImmediateFutureTense</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"ImmediateFutureTense, also called 'close future', locates the situation in question shortly after the moment of utterance [Dahl 1985: 121; Comrie 1985: 94; Bybee, Perkins and Pagliuca 1994: 244-245]."</para>
    /// labels<para>"ImmediateFutureTense"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/ImmediateFutureTense">http://purl.org/linguistics/gold/ImmediateFutureTense</seealso>
    let ImmediateFutureTense =
        Prefixed_Name(gold, "ImmediateFutureTense") |> PrefixedName

    /// <summary>
    ///   <para>gold:ImmediatePastTense</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"ImmediatePastTense locates the situation in question at a time considered very recent in relation to the moment of utterance [Comrie 1985: 87]."</para>
    /// labels<para>"ImmediatePastTense"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/ImmediatePastTense">http://purl.org/linguistics/gold/ImmediatePastTense</seealso>
    let ImmediatePastTense = Prefixed_Name(gold, "ImmediatePastTense") |> PrefixedName
    /// <summary>
    ///   <para>gold:ImperativeForce</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A term used in the grammatical classification of sentence types, and usually seen in contrast to indicative, interrogative, etc. An imperative usage (‘an imperative’) refers to verb forms or sentence/clause types typically used in the expression of commands, e.g. 'Go away!' [Crystal 2008: 23]"</para>
    /// labels<para>"ImperativeForce"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/ImperativeForce">http://purl.org/linguistics/gold/ImperativeForce</seealso>
    let ImperativeForce = Prefixed_Name(gold, "ImperativeForce") |> PrefixedName
    /// <summary>
    ///   <para>gold:ImperfectiveAspect</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A value of Aspect Property assigned to the designated element in the clause when the meaning selected for the clause is that which indicates that the event spoken about is to be looked at from inside, from within its temporal boundaries; imperfective aspect is crucially concerned with the internal temporal structure of the event [Comrie 1976: 16ff].
    ///
    /// Typically, for an aspect value to be labelled as Imperfective, the aspectual meaning has to minimally express the imperfective viewpoint, although it may additionally express other temporal, aspectual, or modal meanings, or actionality distinctions.
    ///
    /// Imperfective aspectual meaning can be further subdivided into two types: habitual meaning and continuous meaning. These two aspectual meanings may or may not be grammaticalised as separate aspect values. [Kibort 2008c: 7]"</para>
    /// labels<para>"ImperfectiveAspect"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/ImperfectiveAspect">http://purl.org/linguistics/gold/ImperfectiveAspect</seealso>
    let ImperfectiveAspect = Prefixed_Name(gold, "ImperfectiveAspect") |> PrefixedName

    /// <summary>
    ///   <para>gold:ImpersonalPassiveVoice</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A Passive that alters the mapping of a nominal to the Subject relation in a basic intransitive structure [Klaiman 1991: 23]."</para>
    /// labels<para>"ImpersonalPassiveVoice"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/ImpersonalPassiveVoice">http://purl.org/linguistics/gold/ImpersonalPassiveVoice</seealso>
    let ImpersonalPassiveVoice =
        Prefixed_Name(gold, "ImpersonalPassiveVoice") |> PrefixedName

    /// <summary>
    ///   <para>gold:InablativeCase</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"InablativeCase expresses that  the referent of the noun it marks is the location from within which another referent is moving. It has the meaning 'from within'. Kibrik says that Archi (aqc) possesses a nominal spatial form expressing InablativeCase, namely -aš. He gives the example 'aInš-l-a-š' ('aIns' = 'apple'). [Kibrik 1998: 470-471]"</para>
    /// labels<para>"InablativeCase"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/InablativeCase">http://purl.org/linguistics/gold/InablativeCase</seealso>
    let InablativeCase = Prefixed_Name(gold, "InablativeCase") |> PrefixedName
    /// <summary>
    ///   <para>gold:InallativeCase</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"InallativeCase expresses that  something is moving toward the region that is inside the referent of the noun it marks. It has the meaning 'towards in(side)'. Kibrik says that Archi (aqc) possesses a nominal spatial form expressing InallativeCase, namely -aši [Kibrik 1998: 470]."</para>
    /// labels<para>"InallativeCase"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/InallativeCase">http://purl.org/linguistics/gold/InallativeCase</seealso>
    let InallativeCase = Prefixed_Name(gold, "InallativeCase") |> PrefixedName
    /// <summary>
    ///   <para>gold:InanimateGender</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A grammatical gender property such that membership in the inanimate grammatical class is largely based on meaning, in that non-living things, such as objects of manufacture and natural 'non-living' things are included in it. For example, one of the two grammatical genders, or noun classes, of Nishnaabemwin, the other being animate [Valentine 2001: 114]."</para>
    /// labels<para>"InanimateGender"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/InanimateGender">http://purl.org/linguistics/gold/InanimateGender</seealso>
    let InanimateGender = Prefixed_Name(gold, "InanimateGender") |> PrefixedName
    /// <summary>
    ///   <para>gold:InceptiveAspect</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"InceptiveAspect, also called the ingressive, encodes the beginning portion of some event [Bybee 1985: 147, 149; Payne 1997: 240; Bhat 1999: 176]."</para>
    /// labels<para>"InceptiveAspect"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/InceptiveAspect">http://purl.org/linguistics/gold/InceptiveAspect</seealso>
    let InceptiveAspect = Prefixed_Name(gold, "InceptiveAspect") |> PrefixedName

    /// <summary>
    ///   <para>gold:IncorporatingAntipassiveVoice</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Blocks the patient or logical object (basic absolutive) nominal from being assigned Focus salience. There is no explicit case marking on the patient, and the patient is invariably nonreferential. This correlates with the patient's morphosyntactic downgrading, whereby it becomes insusceptible to any informational salience assignment. [Klaiman 1991: 232-236]"</para>
    /// labels<para>"IncorporatingAntipassiveVoice"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/IncorporatingAntipassiveVoice">http://purl.org/linguistics/gold/IncorporatingAntipassiveVoice</seealso>
    let IncorporatingAntipassiveVoice =
        Prefixed_Name(gold, "IncorporatingAntipassiveVoice") |> PrefixedName

    /// <summary>
    ///   <para>gold:IndefiniteArticle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An article is a part of speech whose members are used to refer to an entity (or class of entities) which is not capable of specific identification [Crystal 1997: 193]."</para>
    /// labels<para>"IndefiniteArticle"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/IndefiniteArticle">http://purl.org/linguistics/gold/IndefiniteArticle</seealso>
    let IndefiniteArticle = Prefixed_Name(gold, "IndefiniteArticle") |> PrefixedName
    /// <summary>
    ///   <para>gold:IndefinitePronoun</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An indefinite pronoun is a pronoun that belongs to a class whose members indicate  indefinite reference [Crystal 1997: 312]."</para>
    /// labels<para>"IndefinitePronoun"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/IndefinitePronoun">http://purl.org/linguistics/gold/IndefinitePronoun</seealso>
    let IndefinitePronoun = Prefixed_Name(gold, "IndefinitePronoun") |> PrefixedName
    /// <summary>
    ///   <para>gold:IndicativeMood</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A term used in the grammatical classification of sentence types, and usually seen in contrast to imperative, subjunctive, etc., moods. It refers to verb forms or sentence/clause types used in the expression of statements and questions, e.g. the horse is walking. With reference to statements, the term ‘declarative’ may be used. [Crystal 2008: 242]"</para>
    /// labels<para>"IndicativeMood"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/IndicativeMood">http://purl.org/linguistics/gold/IndicativeMood</seealso>
    let IndicativeMood = Prefixed_Name(gold, "IndicativeMood") |> PrefixedName

    /// <summary>
    ///   <para>gold:IndirectEvidentiality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"IndirectEvidentiality, also called reported, encodes the fact that the speaker came to believe the content of the expression from a source other than by experiencing the situation directly [Palmer 2001: 40]."</para>
    /// labels<para>"IndirectEvidentiality"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/IndirectEvidentiality">http://purl.org/linguistics/gold/IndirectEvidentiality</seealso>
    let IndirectEvidentiality =
        Prefixed_Name(gold, "IndirectEvidentiality") |> PrefixedName

    /// <summary>
    ///   <para>gold:InessiveCase</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"InessiveCase expresses that the referent of the noun it marks is the location within which another referent exists. It has the meaning of 'within' or 'inside' [Lyons 1968: 299; Crystal 1985: 156]. X in Y."</para>
    /// labels<para>"InessiveCase"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/InessiveCase">http://purl.org/linguistics/gold/InessiveCase</seealso>
    let InessiveCase = Prefixed_Name(gold, "InessiveCase") |> PrefixedName

    /// <summary>
    ///   <para>gold:InferentialEvidentiality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"InferentialEvidentiality encodes the fact that the speaker came to believe the content of the expression through some kind of internal inference procedure, e.g., deduction, abduction, induction [Palmer 2001: 6-8]."</para>
    /// labels<para>"InferentialEvidentiality"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/InferentialEvidentiality">http://purl.org/linguistics/gold/InferentialEvidentiality</seealso>
    let InferentialEvidentiality =
        Prefixed_Name(gold, "InferentialEvidentiality") |> PrefixedName

    /// <summary>
    ///   <para>gold:Infix</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A term used in morphology referring to an affix which is added within a root or stem. [Crystal 1985: 157]"</para>
    /// labels<para>"Infix"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/Infix">http://purl.org/linguistics/gold/Infix</seealso>
    let Infix = Prefixed_Name(gold, "Infix") |> PrefixedName

    /// <summary>
    ///   <para>gold:InflectionalMorpheme</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"InflectionalUnit is the class of functional units whose members designate such grammatical categories as tense, aspect, mood etc. The various forms of an InflectionalUnit plus the stem forms a grammatical paradigm and express a grammatical contrast that is obligatory for its stem's part of speech in some given grammatical context. An inflectional unit does not alter the part of speech feature of the root or stem it attaches to. It is typically located farther from its Root than a derivational unit and  produces a predictable, nonidiosyncratic change of meaning [Crystal 1980: 184; Hartmann and Stork 1972: 112; Bybee 1985: 2, 99]."</para>
    /// labels<para>"InflectionalMorpheme"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/InflectionalMorpheme">http://purl.org/linguistics/gold/InflectionalMorpheme</seealso>
    let InflectionalMorpheme =
        Prefixed_Name(gold, "InflectionalMorpheme") |> PrefixedName

    /// <summary>
    ///   <para>gold:InformationalForce</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"InformationalForce indicates that the hearer is to relate to the informational content of what is expressed. Informational force subsumes Declarative, Speculative and Interrogative force."</para>
    /// labels<para>"InformationalForce"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/InformationalForce">http://purl.org/linguistics/gold/InformationalForce</seealso>
    let InformationalForce = Prefixed_Name(gold, "InformationalForce") |> PrefixedName
    /// <summary>
    ///   <para>gold:InstrumentalCase</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"InstrumentalCase indicates that the referent of the noun it marks is the means of the accomplishment of the action expressed by the clause [Crystal 1980: 187; Hartmann and Stork 1972: 114]."</para>
    /// labels<para>"InstrumentalCase"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/InstrumentalCase">http://purl.org/linguistics/gold/InstrumentalCase</seealso>
    let InstrumentalCase = Prefixed_Name(gold, "InstrumentalCase") |> PrefixedName
    /// <summary>
    ///   <para>gold:InterablativeCase</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"InterablativeCase expresses that  the referent of the noun it marks is the location from between which another referent is moving. It has the meaning 'from in between'. Kibrik says that Archi (aqc) possesses a nominal spatial form expressing InterablativeCase, namely -qIaš [Kibrik 1998: 470]."</para>
    /// labels<para>"InterablativeCase"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/InterablativeCase">http://purl.org/linguistics/gold/InterablativeCase</seealso>
    let InterablativeCase = Prefixed_Name(gold, "InterablativeCase") |> PrefixedName
    /// <summary>
    ///   <para>gold:InterallativeCase</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"InterallativeCase expresses that something is moving toward the region that is in the middle of the referent of the noun it marks. It has the meaning  'towards the middle of'. Kibrik says that Archi (aqc) possesses a nominal spatial form expressing InterallativeCase, namely -qIaši [Kibrik 1998: 470]."</para>
    /// labels<para>"InterallativeCase"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/InterallativeCase">http://purl.org/linguistics/gold/InterallativeCase</seealso>
    let InterallativeCase = Prefixed_Name(gold, "InterallativeCase") |> PrefixedName
    /// <summary>
    ///   <para>gold:InteressiveCase</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"InteressiveCase expresses that  the referent of the noun it marks is the location between which another referent exists. It has the meaning of 'between'. Kibrik says that Archi (aqc) possesses a nominal spatial form expressing InteressiveCase, namely -qI [Kibrik 1998: 470]."</para>
    /// labels<para>"InteressiveCase"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/InteressiveCase">http://purl.org/linguistics/gold/InteressiveCase</seealso>
    let InteressiveCase = Prefixed_Name(gold, "InteressiveCase") |> PrefixedName
    /// <summary>
    ///   <para>gold:Interjection</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An interjection is a part of speech, typically brief in form, such as one syllable or word, whose members are used most often as exclamations or parts of an exclamation. An interjection, typically expressing an emotional reaction, often with respect to an accompanying sentence, is not syntactically related to other accompanying expressions, and may include a combination of sounds not otherwise found in the language [Crystal 1997: 200]."</para>
    /// labels<para>"Interjection"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/Interjection">http://purl.org/linguistics/gold/Interjection</seealso>
    let Interjection = Prefixed_Name(gold, "Interjection") |> PrefixedName
    /// <summary>
    ///   <para>gold:InterlativeCase</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"InterlativeCase expresses that  the referent of the noun it marks is the location between which another referent is moving. It has the meaning 'to the middle of'. Kibrik says that Archi (aqc) possesses a nominal spatial form expressing InterlativeCase, namely -qIak [Kibrik 1998: 470]."</para>
    /// labels<para>"InterlativeCase"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/InterlativeCase">http://purl.org/linguistics/gold/InterlativeCase</seealso>
    let InterlativeCase = Prefixed_Name(gold, "InterlativeCase") |> PrefixedName

    /// <summary>
    ///   <para>gold:InterlinearGlossedText</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Interlinear glossed text (IGT) is a linguistic data structure meant to display morphosyntactic structure: morphemes, morpheme boundaries, morpheme types (clitics, prefixes, reduplicated forms), morphosyntactic features/values and part of speech information. At a minimum, an instance of IGT includes a single line of source language followed by a translation line. Often, a second gloss line is included to show detailed morphosyntactic structure using both words and phrases from the target language and various labels, or 'grams', that indicate morphosyntactic features/values, etc. It is possible to include separate lines for the orthographic form, phonetic form, and phonological form. Standards for IGT include the Leipzig Glossing Rules."</para>
    /// labels<para>"InterlinearGlossedText"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/InterlinearGlossedText">http://purl.org/linguistics/gold/InterlinearGlossedText</seealso>
    let InterlinearGlossedText =
        Prefixed_Name(gold, "InterlinearGlossedText") |> PrefixedName

    /// <summary>
    ///   <para>gold:InterminativeCase</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Expresses the notion of something moving into the inside of a reference of the noun it marks. It has the meaning 'into the inside of'. Kibrik says that Archi (aqc) possesses a nominal spatial form expressing InterminativeCase, namely -akana [Kibrik 1998: 470]."</para>
    /// labels<para>"InterminativeCase"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/InterminativeCase">http://purl.org/linguistics/gold/InterminativeCase</seealso>
    let InterminativeCase = Prefixed_Name(gold, "InterminativeCase") |> PrefixedName
    /// <summary>
    ///   <para>gold:InterrogativeForce</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A term used in the grammatical classification of sentence types, and usually seen in contrast to declarative. It refers to verb forms or sentence/clause types typically used in the expression of questions, e.g. the inverted order of 'is he coming?' or the use of an interrogative word (or simple ‘interrogative’), often subclassified as interrogative adjectives (e.g. which), adverbs (e.g. why) and pronouns (e.g. who). [Crystal 2008: 245]"</para>
    /// labels<para>"InterrogativeForce"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/InterrogativeForce">http://purl.org/linguistics/gold/InterrogativeForce</seealso>
    let InterrogativeForce = Prefixed_Name(gold, "InterrogativeForce") |> PrefixedName

    /// <summary>
    ///   <para>gold:InterrogativeOperator</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Also referred to as a 'question particle', an interrogative operator is a category whose members signal a yes/no question [Payne 1997: 296]."</para>
    /// labels<para>"InterrogativeOperator"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/InterrogativeOperator">http://purl.org/linguistics/gold/InterrogativeOperator</seealso>
    let InterrogativeOperator =
        Prefixed_Name(gold, "InterrogativeOperator") |> PrefixedName

    /// <summary>
    ///   <para>gold:InterrogativeProform</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An InterrogativeProform is a Proform that is used in questions to stand for the item questioned. [Schachter 1985: 34]"</para>
    /// labels<para>"InterrogativeProform"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/InterrogativeProform">http://purl.org/linguistics/gold/InterrogativeProform</seealso>
    let InterrogativeProform =
        Prefixed_Name(gold, "InterrogativeProform") |> PrefixedName

    /// <summary>
    ///   <para>gold:InterterminativeCase</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"InterterminativeCase expresses the notion of something moving into the middle of the referent of the noun it marks, but not through it. It has the meaning 'into the middle of'. Kibrik says that Archi (aqc) possesses a nominal spatial form expressing InterterminativeCase, namely -qIakana [Kibrik 1998: 470]."</para>
    /// labels<para>"InterterminativeCase"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/InterterminativeCase">http://purl.org/linguistics/gold/InterterminativeCase</seealso>
    let InterterminativeCase =
        Prefixed_Name(gold, "InterterminativeCase") |> PrefixedName

    /// <summary>
    ///   <para>gold:IntertranslativeCase</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"IntertranslativeCase expresses the notion of something moving along a trajectory between the referent of the noun it marks. It has the meaning 'along the in between'. Kibrik says that Archi (aqc) possesses a nominal spatial form expressing IntertranslativeCase, namely -qIaXut [Kibrik 1998: 470]."</para>
    /// labels<para>"IntertranslativeCase"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/IntertranslativeCase">http://purl.org/linguistics/gold/IntertranslativeCase</seealso>
    let IntertranslativeCase =
        Prefixed_Name(gold, "IntertranslativeCase") |> PrefixedName

    /// <summary>
    ///   <para>gold:IntransitiveVerb</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An intransitive verb is a verb that cannot take a direct object, and describes a property, state, or situation involving only one participant [Crystal 1997: 397; Payne 1997: 171]."</para>
    /// labels<para>"IntransitiveVerb"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/IntransitiveVerb">http://purl.org/linguistics/gold/IntransitiveVerb</seealso>
    let IntransitiveVerb = Prefixed_Name(gold, "IntransitiveVerb") |> PrefixedName
    /// <summary>
    ///   <para>gold:Intransitivizer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A derivational unit that derives an intransitive verb from a transitive verb. [Hornby 2010 (p.c.)]"</para>
    /// labels<para>"Intransitivizer"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/Intransitivizer">http://purl.org/linguistics/gold/Intransitivizer</seealso>
    let Intransitivizer = Prefixed_Name(gold, "Intransitivizer") |> PrefixedName
    /// <summary>
    ///   <para>gold:IntranslativeCase</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"IntranslativeCase expresses the notion of something moving through the referent of the noun it marks. It has the meaning 'along through'. Kibrik says that Archi (aqc) possesses a nominal spatial form expressing IntranslativeCase, namely -aXut [Kibrik 1998: 470]."</para>
    /// labels<para>"IntranslativeCase"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/IntranslativeCase">http://purl.org/linguistics/gold/IntranslativeCase</seealso>
    let IntranslativeCase = Prefixed_Name(gold, "IntranslativeCase") |> PrefixedName
    /// <summary>
    ///   <para>gold:InverseVoice</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Signals when actions proceed from ontologically less salient to more salient participants. [Klaiman 1991: 32]"</para>
    /// labels<para>"InverseVoice"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/InverseVoice">http://purl.org/linguistics/gold/InverseVoice</seealso>
    let InverseVoice = Prefixed_Name(gold, "InverseVoice") |> PrefixedName
    /// <summary>
    ///   <para>gold:IrrealisMood</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Where the proposition is weakly asserted to be true, but the speaker is not ready to support the assertion. Irrealis adverbs include 'maybe' and 'hopefully'. [Crystal 2008: 403]"</para>
    /// labels<para>"IrrealisMood"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/IrrealisMood">http://purl.org/linguistics/gold/IrrealisMood</seealso>
    let IrrealisMood = Prefixed_Name(gold, "IrrealisMood") |> PrefixedName
    /// <summary>
    ///   <para>gold:Isolate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Isolate is the class of human language varieties such that there are no other varieties that are genetically related."</para>
    /// labels<para>"Isolate"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/Isolate">http://purl.org/linguistics/gold/Isolate</seealso>
    let Isolate = Prefixed_Name(gold, "Isolate") |> PrefixedName
    /// <summary>
    ///   <para>gold:IterativeAspect</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"IterativeAspect, also called repetitive, encodes a number of events of the same type that are repeated on a particular occasion. The time interval which is relevant to the iterative is relatively shorter than in the case of the habitual [Bybee 1985: 150; Bybee, Perkins and Pagliuca 1994: 127]. Portrays events repeated on the same occasion (like the iterative knocking on the door) [Bhat 1999: 53]."</para>
    /// labels<para>"IterativeAspect"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/IterativeAspect">http://purl.org/linguistics/gold/IterativeAspect</seealso>
    let IterativeAspect = Prefixed_Name(gold, "IterativeAspect") |> PrefixedName
    /// <summary>
    ///   <para>gold:JussiveForce</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The jussive has syntactic force and is directive in that it signals a speaker's command, permission, or agreement that the proposition expressed by his or her utterance be brought about. The jussive is typically applicable in the first and third person. [Chung and Timberlake 1985: 247; Pei and Gaynor 1954: 110; Palmer 1986: 10, 24, 39-40, 96, 110, 113, Schade 2005: 52]"</para>
    /// labels<para>"JussiveForce"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/JussiveForce">http://purl.org/linguistics/gold/JussiveForce</seealso>
    let JussiveForce = Prefixed_Name(gold, "JussiveForce") |> PrefixedName
    /// <summary>
    ///   <para>gold:LabialProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Gestures involving the lips are said to be Labial. From the linguistic point of view the places of articulation can usefully be classified into a smaller number of groups based on the articulators they share. If consonants in which either the upper or lower lip is involved as an articulator are classified as Labials then there are three place classes among Labial sounds: the lower lip can articulate with the upper lip (bilabial), or the upper teeth (labiodentals)l and,  the upper lip can also be the target for the tongue (linguo-labial). [Ladefoged and Maddieson 1996: 10; 15-15]"</para>
    /// labels<para>"LabialProperty"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/LabialProperty">http://purl.org/linguistics/gold/LabialProperty</seealso>
    let LabialProperty = Prefixed_Name(gold, "LabialProperty") |> PrefixedName
    /// <summary>
    ///   <para>gold:Laminal</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Characterizing sounds produced by the blade of the tongue  [Ladefoged 1997: 596]."</para>
    /// labels<para>"Laminal"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/Laminal">http://purl.org/linguistics/gold/Laminal</seealso>
    let Laminal = Prefixed_Name(gold, "Laminal") |> PrefixedName
    /// <summary>
    ///   <para>gold:Language</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The most fundamental means of human communication. Language is a purely human activity, although some animals have communication systems which have certain analogies to human language. All human beings use language to interact with other members of the same speech community. Language is not only used as an instrument of communication, however, but also as a means of individual expression. Language is not instinctive; it has to be learnt as a system of arbitrary conventional symbols. Such symbols are primarily vocal, produced by the so-called organs of speech, but secondary systems such as writing and other codes may complement the vocalsystem. Some linguists, such as F. de Saussure, have stressed the view of language as general patterns in the speech of a community and as the speaking activity of an individual in a particular situation; others, with N.Chomsky, regard language as the innate capability of native speakers to understand and form grammatical sentences as as the actual utterances produced at a given time. [Hartmann and Stork 1972: 123-124]"</para>
    /// labels<para>"Language"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/Language">http://purl.org/linguistics/gold/Language</seealso>
    let Language = Prefixed_Name(gold, "Language") |> PrefixedName
    /// <summary>
    ///   <para>gold:LanguageFamily</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Group of languages that are genetically related, i.e can be traced to a common proto-language. The ordering of languages into a common language family is usually based on phonological, morphological, and lexical correspondences that stem from the proto-language. ... it refers to the largest spectrum of languages for which a genetic relationship can be demonstrated. [Bussmann 1996: 262]"</para>
    /// labels<para>"LanguageFamily"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/LanguageFamily">http://purl.org/linguistics/gold/LanguageFamily</seealso>
    let LanguageFamily = Prefixed_Name(gold, "LanguageFamily") |> PrefixedName
    /// <summary>
    ///   <para>gold:LanguageStock</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A term used for postulated but undemonstrated higher-order, more inclusive families (proposed but as yet unproven distant genetic relationships). [Campbell 1999: 187]"</para>
    /// labels<para>"LanguageStock"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/LanguageStock">http://purl.org/linguistics/gold/LanguageStock</seealso>
    let LanguageStock = Prefixed_Name(gold, "LanguageStock") |> PrefixedName
    /// <summary>
    ///   <para>gold:LanguageSubfamily</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"LanguageSubfamily (also called subgroup or branch) refers 'to a group of languages within a language family which are more closely related to each other than to other languages of that family.' [Campbell 1999: 187]"</para>
    /// labels<para>"LanguageSubfamily"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/LanguageSubfamily">http://purl.org/linguistics/gold/LanguageSubfamily</seealso>
    let LanguageSubfamily = Prefixed_Name(gold, "LanguageSubfamily") |> PrefixedName
    /// <summary>
    ///   <para>gold:LaryngealProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The laryngeal setting refers to differences in the timing of laryngeal activity in relation to oral articulation. Most languages have phonemic contrasts between classes of stops which differ in the mode of action of the larynx, or in the timing of laryngeal activity. [Ladefoged and Maddieson 1996: 47]"</para>
    /// labels<para>"LaryngealProperty"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/LaryngealProperty">http://purl.org/linguistics/gold/LaryngealProperty</seealso>
    let LaryngealProperty = Prefixed_Name(gold, "LaryngealProperty") |> PrefixedName
    /// <summary>
    ///   <para>gold:LateralEscape</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Characterizing sounds produced with a release of air through the sides of the mouth. (Note, [Ladefoged 1997] refers to this as lateral.)"</para>
    /// labels<para>"LateralEscape"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/LateralEscape">http://purl.org/linguistics/gold/LateralEscape</seealso>
    let LateralEscape = Prefixed_Name(gold, "LateralEscape") |> PrefixedName
    /// <summary>
    ///   <para>gold:LateralProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Obstruction of the airstream at a point along the center of the oral tract, with complete closure between one or both sides of the tongue and the roof of the mouth. [Ladefoged 2000: 11]"</para>
    /// labels<para>"LateralProperty"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/LateralProperty">http://purl.org/linguistics/gold/LateralProperty</seealso>
    let LateralProperty = Prefixed_Name(gold, "LateralProperty") |> PrefixedName
    /// <summary>
    ///   <para>gold:LativeCase</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"LativeCase expresses 'motion up to the location of,' or 'as far as' the referent of the noun it marks [Pei and Gaynor 1954: 121]."</para>
    /// labels<para>"LativeCase"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/LativeCase">http://purl.org/linguistics/gold/LativeCase</seealso>
    let LativeCase = Prefixed_Name(gold, "LativeCase") |> PrefixedName
    /// <summary>
    ///   <para>gold:LexicalItem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A unit of the vocabulary of a language such as a word, phrase or term as listed in a dictionary. It usually has a pronounceable or graphic form, fulfils a grammatical role in a sentence, and carries semantic meaning. [Hartmann and Stork 1972: 128]"</para>
    /// labels<para>"LexicalItem"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/LexicalItem">http://purl.org/linguistics/gold/LexicalItem</seealso>
    let LexicalItem = Prefixed_Name(gold, "LexicalItem") |> PrefixedName
    /// <summary>
    ///   <para>gold:LexicalizedConcept</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Grammatical or semantic category expressed by a lexical item, e.g. English 'make' + 'dead' together are lexicalized as 'kill', in German 'tot' + 'machen' &gt; 'töten', or the close linking of lexical items in an idiomatic phrase. [Hartmann and Stork 1972: 129]"</para>
    /// labels<para>"LexicalizedConcept"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/LexicalizedConcept">http://purl.org/linguistics/gold/LexicalizedConcept</seealso>
    let LexicalizedConcept = Prefixed_Name(gold, "LexicalizedConcept") |> PrefixedName
    /// <summary>
    ///   <para>gold:Lexicon</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"In its most general sense, the term is synonymous with vocabulary. A dictionary can be seen as a set of lexical entries. The lexicon has a special status in generative grammar, where it refers to the component containing all the information about the structural properties of the lexical items in a language. [Crystal 2008: 278] In linguistics, ... we don't normally speak of the vocabulary of a particular language; instead, we speak of the lexicon, the total store of words available to a speaker. Very commonly, the lexicon is not regarded merely as a long list of words. Rather, we conceive the lexicon as a set of lexical resources, including the morphemes of the languages, plus the processes available in the language for constructing words from those resources. Apart from the lexicon of a language as a whole, psycholinguists are interested in the mental lexicon, the words and lexical resources stored in an individual brain. [Trask 1999: 166-167]"</para>
    /// labels<para>"Lexicon"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/Lexicon">http://purl.org/linguistics/gold/Lexicon</seealso>
    let Lexicon = Prefixed_Name(gold, "Lexicon") |> PrefixedName
    /// <summary>
    ///   <para>gold:Ligature</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The merging of two or more letters (often for aesthetic reasons) from which a single, independent form is derived. [Bussmann 1996: 281]"</para>
    /// labels<para>"Ligature"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/Ligature">http://purl.org/linguistics/gold/Ligature</seealso>
    let Ligature = Prefixed_Name(gold, "Ligature") |> PrefixedName

    /// <summary>
    ///   <para>gold:LinguisticDataStructure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A linguistic data structure is an abstract container for grouping together instances of linguistic data, usually to suit a particular theory or computational implementation. Examples include: feature structures, lexical entries, and paradigms."</para>
    /// labels<para>"LinguisticDataStructure"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/LinguisticDataStructure">http://purl.org/linguistics/gold/LinguisticDataStructure</seealso>
    let LinguisticDataStructure =
        Prefixed_Name(gold, "LinguisticDataStructure") |> PrefixedName

    /// <summary>
    ///   <para>gold:LinguisticExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A LinguisticExpression is any physical form (sound, visual image or sequence thereof) used to represent a linguistic unit. A linguistic expression may be spoken, written, or signed. A linguistic expression is distinct form the actual process (speaking, writing, signing) that produces the expression."</para>
    /// labels<para>"LinguisticExpression"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/LinguisticExpression">http://purl.org/linguistics/gold/LinguisticExpression</seealso>
    let LinguisticExpression =
        Prefixed_Name(gold, "LinguisticExpression") |> PrefixedName

    /// <summary>
    ///   <para>gold:LinguisticProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"LinguisticProperty is the class  of properties that pertain to linguistic units. A unit's properties determine its behavior  in a grammatical system. Specific kinds of properties are relevant to certain types of units. In some language, for example, tense properties may be relevant for verbs. See also Feature and FeatureValue for the corresponding data structure for properties."</para>
    /// labels<para>"LinguisticProperty"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/LinguisticProperty">http://purl.org/linguistics/gold/LinguisticProperty</seealso>
    let LinguisticProperty = Prefixed_Name(gold, "LinguisticProperty") |> PrefixedName
    /// <summary>
    ///   <para>gold:LinguisticSign</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A linguistic sign is an abstract structure whose instances participate in a linguistic system, or language. By definition, a linguistic sign must have a form component (whose elements are phonological units), a grammatical component (whose elements are grammatical units), and a meaning component (whose elements are semantic units). The formal structure of a linguistic sign is determined by the grammar of a language. The information value of a linguistic sign, its meaning, is not fixed, but determined by the conventions of the language. The relation of form to meaning is largely arbitrary within a semiotic system. Signs are classified primarily according to what kinds of formal relations they participate in, and, secondly, according to their complexity (whether they are atomic or composed of other signs). Signs range from morphological and syntactic constructions to whole discourse segments [de Saussure 1983; Hervey 1979; Pollard and Sag 1994]."</para>
    /// labels<para>"LinguisticSign"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/LinguisticSign">http://purl.org/linguistics/gold/LinguisticSign</seealso>
    let LinguisticSign = Prefixed_Name(gold, "LinguisticSign") |> PrefixedName
    /// <summary>
    ///   <para>gold:LinguisticSystem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A term used to describe a language as a whole, with each of its component parts functioning according to an overall convention of usage to enable the members of a speech community to interchange information. Most linguists agree on a 'system of systems', i.e. the arrangement of units on hierarchically ordered and inter-related levels. [Hartmann and Stork 1972: 231]"</para>
    /// labels<para>"LinguisticSystem"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/LinguisticSystem">http://purl.org/linguistics/gold/LinguisticSystem</seealso>
    let LinguisticSystem = Prefixed_Name(gold, "LinguisticSystem") |> PrefixedName
    /// <summary>
    ///   <para>gold:LinguisticTaxon</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"LinguisticTaxon is the class of  Taxons whose instances are used in the scientific classification language varieties. That is, instances of LinguisticTaxon have instances that are human language varieties."</para>
    /// labels<para>"LinguisticTaxon"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/LinguisticTaxon">http://purl.org/linguistics/gold/LinguisticTaxon</seealso>
    let LinguisticTaxon = Prefixed_Name(gold, "LinguisticTaxon") |> PrefixedName
    /// <summary>
    ///   <para>gold:LinguisticUnit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This term is often used in linguistics and phonetics to refer to any entity which constitutes the focus of an enquiry. The unit is the stretch of language that carries grammatical patterns, and within which grammatical choices are made. For example, the unit sentence consists of one or more instances of the unit clause, and so on. [Crystal 2008: 503]"</para>
    /// labels<para>"LinguisticUnit"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/LinguisticUnit">http://purl.org/linguistics/gold/LinguisticUnit</seealso>
    let LinguisticUnit = Prefixed_Name(gold, "LinguisticUnit") |> PrefixedName
    /// <summary>
    ///   <para>gold:LivingVariety</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A language which is the current native language of a speech community. [Hartmann and Stork 1972: 133]"</para>
    /// labels<para>"LivingVariety"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/LivingVariety">http://purl.org/linguistics/gold/LivingVariety</seealso>
    let LivingVariety = Prefixed_Name(gold, "LivingVariety") |> PrefixedName
    /// <summary>
    ///   <para>gold:LocativeCase</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"(adj./n.) In languages which express grammatical relationships by means of inflections, this term refers to the form taken by a noun phrase (often a single noun or pronoun), when it typically expresses the idea of location of an entity or action. Structures which express locational meaning may also be referred to as locative, e.g. in 'The woman was standing at a bus stop', 'at a bus stop' could be called a locative phrase. [Crystal 2008: 288]"</para>
    /// labels<para>"LocativeCase"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/LocativeCase">http://purl.org/linguistics/gold/LocativeCase</seealso>
    let LocativeCase = Prefixed_Name(gold, "LocativeCase") |> PrefixedName

    /// <summary>
    ///   <para>gold:LocativePassiveVoice</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An oblique locative nominal assumes the subject relation [Klaiman 1991: 17]."</para>
    /// labels<para>"LocativePassiveVoice"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/LocativePassiveVoice">http://purl.org/linguistics/gold/LocativePassiveVoice</seealso>
    let LocativePassiveVoice =
        Prefixed_Name(gold, "LocativePassiveVoice") |> PrefixedName

    /// <summary>
    ///   <para>gold:Low</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Articulated with the highest point of the tongue more or less maximally distant from the roof of the mouth. In the SPE feature system, a distinctive feature defined as 'articulated with the body of the tongue below the neutral position.' [Trask 1996: 212]"</para>
    /// labels<para>"Low"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/Low">http://purl.org/linguistics/gold/Low</seealso>
    let Low = Prefixed_Name(gold, "Low") |> PrefixedName
    /// <summary>
    ///   <para>gold:MainClause</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"MainClause is the class of clauses that can stand on their own as a  full, independent sentence.  If a sentence contains any embedded clauses, the main clause is understood as the matrix plus the embedded clauses. In the sentence 'John thinks that Mary is sick', 'John thinks that Mary is sick' is the main clause. [Crystal 2001: 231]"</para>
    /// labels<para>"MainClause"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/MainClause">http://purl.org/linguistics/gold/MainClause</seealso>
    let MainClause = Prefixed_Name(gold, "MainClause") |> PrefixedName
    /// <summary>
    ///   <para>gold:MalefactiveCase</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Opposite of BenefactiveCase; used when the marked noun is adversely affected in the clause. [Zúñiga and Kittilä 2010: 5]"</para>
    /// labels<para>"MalefactiveCase"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/MalefactiveCase">http://purl.org/linguistics/gold/MalefactiveCase</seealso>
    let MalefactiveCase = Prefixed_Name(gold, "MalefactiveCase") |> PrefixedName
    /// <summary>
    ///   <para>gold:MannerProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A sound property referring to the kind of articulatory process used in a sound's production.  The distinction between vowel and consonant is usually made in terms of manner of articulation.  Within consonants, several articulatory types are recognized based on the type of closure made by the vocal organs.  Within vowels, classification  is based on the number of auditory qualities distinguishable in the sound, the position of the soft palate, and the type of lip position. [Crystal 1997: 232]"</para>
    /// labels<para>"MannerProperty"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/MannerProperty">http://purl.org/linguistics/gold/MannerProperty</seealso>
    let MannerProperty = Prefixed_Name(gold, "MannerProperty") |> PrefixedName
    /// <summary>
    ///   <para>gold:MasculineGender</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A gender property established on the basis of agreement, to which nouns may be assigned based on semantic or formal criteria.  In semantic gender systems, nouns belonging to the masculine gender typically denote male humans as well as nouns meeting certain physical criteria.  Some gender systems differentiate masculine nouns from all other nouns (e.g. masculine/other or male human/other), while others differentiate masculine, feminine and neuter nouns or several different gender classes. [Corbett 1991: 30]"</para>
    /// labels<para>"MasculineGender"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/MasculineGender">http://purl.org/linguistics/gold/MasculineGender</seealso>
    let MasculineGender = Prefixed_Name(gold, "MasculineGender") |> PrefixedName

    /// <summary>
    ///   <para>gold:MentalAbilitiveModality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"MentalAbilitiveModality indicates that an agent has the  capacity to perform some mental action [Bybee, Perkins and Pagliuca 1994: 192; Palmer 2001: 77]."</para>
    /// labels<para>"MentalAbilitiveModality"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/MentalAbilitiveModality">http://purl.org/linguistics/gold/MentalAbilitiveModality</seealso>
    let MentalAbilitiveModality =
        Prefixed_Name(gold, "MentalAbilitiveModality") |> PrefixedName

    /// <summary>
    ///   <para>gold:Mid</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Characterizing sounds articulated between the high and low tongue positions. [Crystal 1987: 425]"</para>
    /// labels<para>"Mid"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/Mid">http://purl.org/linguistics/gold/Mid</seealso>
    let Mid = Prefixed_Name(gold, "Mid") |> PrefixedName
    /// <summary>
    ///   <para>gold:MinusATR</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"MinusATR (Advanced Tongue Root) characterizes sounds made in which there is no advancement of the tongue root or lowering of the larynx. [Ladefoged 2000: 211]"</para>
    /// labels<para>"MinusATR"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/MinusATR">http://purl.org/linguistics/gold/MinusATR</seealso>
    let MinusATR = Prefixed_Name(gold, "MinusATR") |> PrefixedName
    /// <summary>
    ///   <para>gold:MinusClick</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"MinusClick refers to not having the properties of a click.  Clicks are stops in which the essential component is the rarefaction of air enclosed between two articulatory closures formed in the oral cavity, so that a loud transient is produced when the more forward closure is released.  This uses the velaric airstream mechanism, always ingressive, and cannot be used for sounds other than stops and affricates.  [Ladefoged and Maddieson 1996: 246]"</para>
    /// labels<para>"MinusClick"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/MinusClick">http://purl.org/linguistics/gold/MinusClick</seealso>
    let MinusClick = Prefixed_Name(gold, "MinusClick") |> PrefixedName
    /// <summary>
    ///   <para>gold:MinusFortis</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"MinusFortis refers to a sound made without relatively strong degree of muscular effort and breath force.  [Crystal 1985: 126]"</para>
    /// labels<para>"MinusFortis"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/MinusFortis">http://purl.org/linguistics/gold/MinusFortis</seealso>
    let MinusFortis = Prefixed_Name(gold, "MinusFortis") |> PrefixedName
    /// <summary>
    ///   <para>gold:MinusNasal</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Characterizing sounds in which the palatal tensor muscles and the levator palatine muscle raise the velum, preventing air from escaping through the nose. [Kenstowicz 1994: 143; Ladefoged 2000: 274]"</para>
    /// labels<para>"MinusNasal"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/MinusNasal">http://purl.org/linguistics/gold/MinusNasal</seealso>
    let MinusNasal = Prefixed_Name(gold, "MinusNasal") |> PrefixedName
    /// <summary>
    ///   <para>gold:Modal</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A part of speech, usually associated with a verbal system, that expresses the concept of necessity and possibility, as well as the subject's attitude toward the factuality or actualization of the situation expressed by the rest of the clause.  Modals can code inception, termination, persistence, success, failure, attempt, intent, obligation or ability vis-a-vis the complement state/event, and the subject of the main clause is obligatorily also the subject of the complement clause. [Palmer 2001: 2; Givon 1984: 533; Huddleston and Pullam 2002: 173]"</para>
    /// labels<para>"Modal"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/Modal">http://purl.org/linguistics/gold/Modal</seealso>
    let Modal = Prefixed_Name(gold, "Modal") |> PrefixedName
    /// <summary>
    ///   <para>gold:ModalVoice</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Regular vibrations of the vocal folds at any frequency within the speaker's normal range.  [Ladefoged and Maddieson 1996:  48]"</para>
    /// labels<para>"ModalVoice"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/ModalVoice">http://purl.org/linguistics/gold/ModalVoice</seealso>
    let ModalVoice = Prefixed_Name(gold, "ModalVoice") |> PrefixedName
    /// <summary>
    ///   <para>gold:ModalityProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"ModalityProperty is the class of properties that concern the grammatical encoding of the status of the proposition itself, and not of the event to which the proposition refers, cf. AspectProperty. As a grammatical property, it represents those dimensions in the domains of knowledge (epistemic modality), social relations (deontic modality) and ability (abilitative modality), and possibly others. [Palmer 2001: 1, 7-10]"</para>
    /// labels<para>"ModalityProperty"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/ModalityProperty">http://purl.org/linguistics/gold/ModalityProperty</seealso>
    let ModalityProperty = Prefixed_Name(gold, "ModalityProperty") |> PrefixedName
    /// <summary>
    ///   <para>gold:MoodProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"MoodProperty is the class of properties that concern the grammatical encoding of mood of a proposition. Among the traditionally defined properties are Declarative, Imperative and Interrogative. This class of properties contains both attitude (e.g. optative, volitive, subjunctive) and speech-act (e.g. imperative, commissive) values."</para>
    /// labels<para>"MoodProperty"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/MoodProperty">http://purl.org/linguistics/gold/MoodProperty</seealso>
    let MoodProperty = Prefixed_Name(gold, "MoodProperty") |> PrefixedName
    /// <summary>
    ///   <para>gold:Mora</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Mora refers to the several parts of the phoneme which may receive divergent tonal treatments [Pei and Gaynor 1980: 138].  A mora also can refer to a minimal unit of metrical time equivalent to a short syllable [Crystal 1985: 198]."</para>
    /// labels<para>"Mora"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/Mora">http://purl.org/linguistics/gold/Mora</seealso>
    let Mora = Prefixed_Name(gold, "Mora") |> PrefixedName
    /// <summary>
    ///   <para>gold:Morpheme</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The smallest functioning unit in the composition of words, and the minimal distinctive unit of grammar.  Morphemes are commonly classified into free forms (morphemes which can occur as separate words) adn bound forms (morphemes which cannot so occur - mainly affixes).  A further distinction may be made between lexical and grammatical morphemes; the former are morphemes used for the construction of new words in a language; the latter are morphemes used to express grammatical relationships between a word and its context. [Crystal 2008: 300]"</para>
    /// labels<para>"Morpheme"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/Morpheme">http://purl.org/linguistics/gold/Morpheme</seealso>
    let Morpheme = Prefixed_Name(gold, "Morpheme") |> PrefixedName
    /// <summary>
    ///   <para>gold:MorphologicalUnit</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/MorphologicalUnit">http://purl.org/linguistics/gold/MorphologicalUnit</seealso>
    let MorphologicalUnit = Prefixed_Name(gold, "MorphologicalUnit") |> PrefixedName

    /// <summary>
    ///   <para>gold:MorphosemanticProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A property whose values are not involved in agreement or government, but are inherent only. That is, the elements on which the values are found are not controllers of agreement. Because it is not involved in either agreement or government, a morphosemantic feature is not relevant to syntax. [Kibort 2008f]"</para>
    /// labels<para>"MorphosemanticProperty"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/MorphosemanticProperty">http://purl.org/linguistics/gold/MorphosemanticProperty</seealso>
    let MorphosemanticProperty =
        Prefixed_Name(gold, "MorphosemanticProperty") |> PrefixedName

    /// <summary>
    ///   <para>gold:MorphosyntacticProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"MorphosyntacticFeature is the class of linguistic features that govern the grammatical behavior of morphosyntactic units. E.g., two morphosyntactic units can agree according to shared morphosyntactic features. Morphosyntactic features are also called grammatical categories. This class is intended to represent only the formal aspects of morphosyntax; that is, there is no notional component. In a grammatical system, such features occur in contrast to one another other, and are typically expressed in the same fashion. [Crystal 1985: 43-44; Hopper, P. 1992: 81; Bybee 1985: 191]"</para>
    /// labels<para>"MorphosyntacticProperty"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/MorphosyntacticProperty">http://purl.org/linguistics/gold/MorphosyntacticProperty</seealso>
    let MorphosyntacticProperty =
        Prefixed_Name(gold, "MorphosyntacticProperty") |> PrefixedName

    /// <summary>
    ///   <para>gold:MultalNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Multal is a number property that refers to a large number of individuals."</para>
    /// labels<para>"MultalNumber"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/MultalNumber">http://purl.org/linguistics/gold/MultalNumber</seealso>
    let MultalNumber = Prefixed_Name(gold, "MultalNumber") |> PrefixedName

    /// <summary>
    ///   <para>gold:MultiplicativeNumeral</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A multiplicative numeral is a numeral that expresses how many fold or how many times [Pei and Gaynor 1954: 149; Hartmann and Stork 1972: 147]."</para>
    /// labels<para>"MultiplicativeNumeral"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/MultiplicativeNumeral">http://purl.org/linguistics/gold/MultiplicativeNumeral</seealso>
    let MultiplicativeNumeral =
        Prefixed_Name(gold, "MultiplicativeNumeral") |> PrefixedName

    /// <summary>
    ///   <para>gold:NasalityProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The class of properties that describe the degree to which the velum or soft palate is raised or lowered, allowing or prohibiting air from escaping through the nose. [Kenstowicz 1994: 143]"</para>
    /// labels<para>"NasalityProperty"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/NasalityProperty">http://purl.org/linguistics/gold/NasalityProperty</seealso>
    let NasalityProperty = Prefixed_Name(gold, "NasalityProperty") |> PrefixedName
    /// <summary>
    ///   <para>gold:NearFutureTense</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"In languages which distinguish different degrees of remoteness in the future, the near future refers to the least remote future.  [Comrie 1985: 46]"</para>
    /// labels<para>"NearFutureTense"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/NearFutureTense">http://purl.org/linguistics/gold/NearFutureTense</seealso>
    let NearFutureTense = Prefixed_Name(gold, "NearFutureTense") |> PrefixedName

    /// <summary>
    ///   <para>gold:NearlyExtinctVariety</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The class of languages that have relatively few native speakers. A nearly extinct variety is expected to become extrinct in a short time period, e.g., Jebero or Wichita."</para>
    /// labels<para>"NearlyExtinctVariety"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/NearlyExtinctVariety">http://purl.org/linguistics/gold/NearlyExtinctVariety</seealso>
    let NearlyExtinctVariety =
        Prefixed_Name(gold, "NearlyExtinctVariety") |> PrefixedName

    /// <summary>
    ///   <para>gold:NecessitativePassiveVoice</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A passive in Irish in which the preposition "with" is used, and a semantic meaning of necessity is added [Noonan 1994: 280]."</para>
    /// labels<para>"NecessitativePassiveVoice"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/NecessitativePassiveVoice">http://purl.org/linguistics/gold/NecessitativePassiveVoice</seealso>
    let NecessitativePassiveVoice =
        Prefixed_Name(gold, "NecessitativePassiveVoice") |> PrefixedName

    /// <summary>
    ///   <para>gold:NecessityModality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"NecessityModality indicates that the described state of affairs is necessary [Palmer 2001: 89-90], either directly, or because of a requirement on the part of an agent [Bybee, Perkins and Pagliuca 1994: 177]."</para>
    /// labels<para>"NecessityModality"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/NecessityModality">http://purl.org/linguistics/gold/NecessityModality</seealso>
    let NecessityModality = Prefixed_Name(gold, "NecessityModality") |> PrefixedName
    /// <summary>
    ///   <para>gold:NegationOperator</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"NegationOperator is a negative-marking phrase located in scope position of the verb (specifier or adjoined position).  Also called a "negation particle", it is normally associated with the main verb of the clause but may also be a clause-level clitic.[Payne 2007:284; Haegeman 1995: 107, 286]"</para>
    /// labels<para>"NegationOperator"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/NegationOperator">http://purl.org/linguistics/gold/NegationOperator</seealso>
    let NegationOperator = Prefixed_Name(gold, "NegationOperator") |> PrefixedName
    /// <summary>
    ///   <para>gold:NegativePolarity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A construction that expresses the contradiction of some or all of a proposition [Crystal 1980: 257]. Note: this value is not to be confused with the notion "Negative Polarity Item", which is an expression that occurs in the scope of Negation (i.e. Negative Polarity)."</para>
    /// labels<para>"NegativePolarity"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/NegativePolarity">http://purl.org/linguistics/gold/NegativePolarity</seealso>
    let NegativePolarity = Prefixed_Name(gold, "NegativePolarity") |> PrefixedName
    /// <summary>
    ///   <para>gold:NeuterGender</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A gender property established on the basis of agreement, to which nouns may be assigned, either by a semantic rule, if they belong to the semantic residue of the assignment system, or by a formal rule, if assignment depends on inflectional class membership. Typically, this means that the neuter gender may cover some inanimates and possibly some portion of lower order animates. Note: Although in familiar Indo-European languages the term neuter gender may be part of a system with three or less values, it can be used for systems containing more than three gender values (e.g. Bininj Gunwok). [Kibort and Corbett 2008a]"</para>
    /// labels<para>"NeuterGender"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/NeuterGender">http://purl.org/linguistics/gold/NeuterGender</seealso>
    let NeuterGender = Prefixed_Name(gold, "NeuterGender") |> PrefixedName
    /// <summary>
    ///   <para>gold:Nominal</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A nominal is a partOfSpeech whose members differ grammatically from a substantive but which functions as one [Crystal 1997: 260]."</para>
    /// labels<para>"Nominal"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/Nominal">http://purl.org/linguistics/gold/Nominal</seealso>
    let Nominal = Prefixed_Name(gold, "Nominal") |> PrefixedName
    /// <summary>
    ///   <para>gold:NominalClassifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A classifier used within a system of noun classes where the morphosyntactic loci are adjectives and, rarely, numerals, as modifiers. Nominal classifiers have all the properties of noun class system classifiers with differences regarding the size of the system (bigger); semantics (animacy/sex/shape/size), transparency of semantic basis (may be opaque), variability of assignment (possible), use in multiple classifier systems (possible), and interrelations with other categories (only with number). [Aikhenvald 2003: 68]"</para>
    /// labels<para>"NominalClassifier"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/NominalClassifier">http://purl.org/linguistics/gold/NominalClassifier</seealso>
    let NominalClassifier = Prefixed_Name(gold, "NominalClassifier") |> PrefixedName
    /// <summary>
    ///   <para>gold:NominalParticle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A nominal particle is a member of a closed class of particles that co-occur with nouns."</para>
    /// labels<para>"NominalParticle"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/NominalParticle">http://purl.org/linguistics/gold/NominalParticle</seealso>
    let NominalParticle = Prefixed_Name(gold, "NominalParticle") |> PrefixedName
    /// <summary>
    ///   <para>gold:Nominalizer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A derivational unit that forms a noun from some other word class. [Crystal 1997: 260]"</para>
    /// labels<para>"Nominalizer"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/Nominalizer">http://purl.org/linguistics/gold/Nominalizer</seealso>
    let Nominalizer = Prefixed_Name(gold, "Nominalizer") |> PrefixedName
    /// <summary>
    ///   <para>gold:NominativeCase</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"NominativeCase identifies clause subjects in nominative-accusative languages. It is usually the unmarked case. Nouns used in isolation often have this case. [Crystal 1980: 242; Pei and Gaynor 1954: 147; Hartmann and Stork 1972: 224]"</para>
    /// labels<para>"NominativeCase"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/NominativeCase">http://purl.org/linguistics/gold/NominativeCase</seealso>
    let NominativeCase = Prefixed_Name(gold, "NominativeCase") |> PrefixedName

    /// <summary>
    ///   <para>gold:NonAbsolutiveAntipassiveVoice</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An Antipassive in which the patient or logical object is not supressed, as is the case in the Absolutive Antipassive, but rather, is overtly downgraded. Some Mayanists distinguish between two types of Non Absolutive Antipassives: the Focus Antipassive and the Incorporating Antipassive. [Klaiman 1991: 232]"</para>
    /// labels<para>"NonAbsolutiveAntipassiveVoice"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/NonAbsolutiveAntipassiveVoice">http://purl.org/linguistics/gold/NonAbsolutiveAntipassiveVoice</seealso>
    let NonAbsolutiveAntipassiveVoice =
        Prefixed_Name(gold, "NonAbsolutiveAntipassiveVoice") |> PrefixedName

    /// <summary>
    ///   <para>gold:NonFutureTense</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"NonFutureTense locates the situation in question at or before the moment of utterance, and contrasts with a FutureTense [Comrie 1985: 49]."</para>
    /// labels<para>"NonFutureTense"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/NonFutureTense">http://purl.org/linguistics/gold/NonFutureTense</seealso>
    let NonFutureTense = Prefixed_Name(gold, "NonFutureTense") |> PrefixedName
    /// <summary>
    ///   <para>gold:NonPastTense</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"NonPastTense locates the situation in question at or after the moment of utterance, and contrasts with a past tense [Comrie 1985: 48-49]."</para>
    /// labels<para>"NonPastTense"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/NonPastTense">http://purl.org/linguistics/gold/NonPastTense</seealso>
    let NonPastTense = Prefixed_Name(gold, "NonPastTense") |> PrefixedName

    /// <summary>
    ///   <para>gold:NonProgressiveAspect</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A value of Aspect Property (also stative aspect) assigned to the designated element in the clause when the meaning selected for the clause is that which indicates that the situation spoken about has internal temporal structure, it cannot be regarded as habitual, but is regarded as a continuing state. Hence, Nonprogressive Aspect can be regarded as a sub-type of continuousness (which, in turn, is a sub-type of imperfectivity). Since languages have different criteria for classifying predicates as stative or not, they may have different rules for determining when explicitly nonprogressive (i.e. explicitly stative) forms can be used.
    ///
    /// Typically, for an aspect value to be labelled as Nonprogressive, the aspectual meaning has to minimally express nonprogressiveness, although it may additionally express other temporal, aspectual, or modal meanings, or actionality distinctions. [Kibort 2008c: 8]"</para>
    /// labels<para>"NonProgressiveAspect"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/NonProgressiveAspect">http://purl.org/linguistics/gold/NonProgressiveAspect</seealso>
    let NonProgressiveAspect =
        Prefixed_Name(gold, "NonProgressiveAspect") |> PrefixedName

    /// <summary>
    ///   <para>gold:NonPromotionalInverseVoice</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Involves demotion of the non-topical obviate-agent from subjecthood [Givon 1994: 24]."</para>
    /// labels<para>"NonPromotionalInverseVoice"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/NonPromotionalInverseVoice">http://purl.org/linguistics/gold/NonPromotionalInverseVoice</seealso>
    let NonPromotionalInverseVoice =
        Prefixed_Name(gold, "NonPromotionalInverseVoice") |> PrefixedName

    /// <summary>
    ///   <para>gold:Noun</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A term used in the grammatical classification of words, traditionally defines as the "name of a person, place or thing," but the vagueness associated with the notions of "name" and "thing" (e.g. is 'beauty' a thing?) has led linguistic descriptions to analyze this class in terms of the formal and functional criteria of syntax and morphology.  In linguistic terms, nouns are items which display certain types of inflection (e.g. of case or number), have a specific distribution (e.g. they may follow prepositions but not, say, modals), and perform a specific syntactic function (e.g. as subject or object of a sentence).  Nouns are generally subclassified into common and proper types, and analyzed in terms of number, gender, case and countability. [Crystal 2008: 320]"</para>
    /// labels<para>"Noun"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/Noun">http://purl.org/linguistics/gold/Noun</seealso>
    let Noun = Prefixed_Name(gold, "Noun") |> PrefixedName
    /// <summary>
    ///   <para>gold:NounClassifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A classifier is a partOfSpeech whose members express the classification of a noun [Crystal 1997: 61; Payne 1997: 107]."</para>
    /// labels<para>"NounClassifier"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/NounClassifier">http://purl.org/linguistics/gold/NounClassifier</seealso>
    let NounClassifier = Prefixed_Name(gold, "NounClassifier") |> PrefixedName
    /// <summary>
    ///   <para>gold:NounPhrase</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Also called nominal groups, nouns phrases are the constructions into which nouns most commonly enter and of which they are the head word.  The structure of a noun phrase consists minimally of the noun (or noun substitute, such as a pronoun); the constructions preceding and following the noun are often described under the headings of premodification and postmodification respectively. [Crystal 2008: 320]"</para>
    /// labels<para>"NounPhrase"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/NounPhrase">http://purl.org/linguistics/gold/NounPhrase</seealso>
    let NounPhrase = Prefixed_Name(gold, "NounPhrase") |> PrefixedName

    /// <summary>
    ///   <para>gold:NucleonicMiddleVoice</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Object of action belongs to. Moves into, or moves from sphere of subject [Siewierska 1988: 257]."</para>
    /// labels<para>"NucleonicMiddleVoice"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/NucleonicMiddleVoice">http://purl.org/linguistics/gold/NucleonicMiddleVoice</seealso>
    let NucleonicMiddleVoice =
        Prefixed_Name(gold, "NucleonicMiddleVoice") |> PrefixedName

    /// <summary>
    ///   <para>gold:NumberProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"NumberProperty is the class of properties that concern the grammatical encoding of quantity. It is often found on nouns, pronouns, and verbs and expresses count distinctions--such as 'one' or 'more than one'. The count distinctions typically, but not always, correspond to the actual count of the referents of the marked noun or Pronoun. [Crystal 1980: 245; Hartmann and Stork 1972: 155]"</para>
    /// labels<para>"NumberProperty"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/NumberProperty">http://purl.org/linguistics/gold/NumberProperty</seealso>
    let NumberProperty = Prefixed_Name(gold, "NumberProperty") |> PrefixedName
    /// <summary>
    ///   <para>gold:Numeral</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A numeral is a partOfSpeech whose members function most typically as adjectives or pronouns and express a number, or relation to the number, such as one of the following: quantity, sequence, frequency, fraction [Hartmann and Stork 1972: 155; Pei and Gaynor 1954: 149]."</para>
    /// labels<para>"Numeral"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/Numeral">http://purl.org/linguistics/gold/Numeral</seealso>
    let Numeral = Prefixed_Name(gold, "Numeral") |> PrefixedName
    /// <summary>
    ///   <para>gold:NumeralClassifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Numeral classifiers are a grammatical device that reflects how speakers categorize objects that they count or quantify [Yamamoto 2005: 1].  They are a set of classifiers used in certain languages, e.g., Japanese, to indicate the class to which the noun modified by the numeral belongs [Pei and Gaynor 1980: 23]."</para>
    ///   <para>"Numeral classifiers are free or bound morphemes that occur in the context of quantification, appearing contiguous to numerals in numeral noun phrases and expressions of quantity. [Aikhenvald 2003: 98; Aikhenvald in Senft 2000: 93]"</para>
    /// labels<para>"NumeralClassifier"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/NumeralClassifier">http://purl.org/linguistics/gold/NumeralClassifier</seealso>
    let NumeralClassifier = Prefixed_Name(gold, "NumeralClassifier") |> PrefixedName
    /// <summary>
    ///   <para>gold:Object</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Corresponds roughly to the class of ordinary objects. Examples include normal physical objects, geographical regions, and locations of processes, the complement of objects in the physical class. In a 4D ontology, an object is something whose spatiotemporal extent is thought of as dividing into spatial parts roughly parallel to the time-axis. [SUMO 2010]"</para>
    /// labels<para>"Object"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/Object">http://purl.org/linguistics/gold/Object</seealso>
    let Object = Prefixed_Name(gold, "Object") |> PrefixedName
    /// <summary>
    ///   <para>gold:ObligativeModality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"ObligativeModality indicates that an agent is required to perform the action expressed by the predicate [Bybee, Perkins and Pagliuca 1994: 177; Palmer 2001: 71]."</para>
    /// labels<para>"ObligativeModality"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/ObligativeModality">http://purl.org/linguistics/gold/ObligativeModality</seealso>
    let ObligativeModality = Prefixed_Name(gold, "ObligativeModality") |> PrefixedName
    /// <summary>
    ///   <para>gold:ObliqueCase</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"In a direct/oblique system or in a nominative/oblique system, oblique case is the term for all roles not marked by the direct case or nominative case.  In the phrase 'the oblique cases' it is used to refer to a set of cases excluding the nominative (occasionally the nominative or accusative).  [Bauer 2004: 27]"</para>
    /// labels<para>"ObliqueCase"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/ObliqueCase">http://purl.org/linguistics/gold/ObliqueCase</seealso>
    let ObliqueCase = Prefixed_Name(gold, "ObliqueCase") |> PrefixedName
    /// <summary>
    ///   <para>gold:ObliquePassiveVoice</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A Passive in which a basic Oblique nominal assumes the Subject relation in a corresponding nonbasic configuration.  Can include locative passives, benefactive passives and instrumental passives. [Klaiman 1991: 23]"</para>
    /// labels<para>"ObliquePassiveVoice"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/ObliquePassiveVoice">http://purl.org/linguistics/gold/ObliquePassiveVoice</seealso>
    let ObliquePassiveVoice = Prefixed_Name(gold, "ObliquePassiveVoice") |> PrefixedName
    /// <summary>
    ///   <para>gold:Ontology</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An explicit specification of a representational vocabulary for a shared domain of discourse.  [Gruber 1993: 199]"</para>
    /// labels<para>"Ontology"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/Ontology">http://purl.org/linguistics/gold/Ontology</seealso>
    let Ontology = Prefixed_Name(gold, "Ontology") |> PrefixedName
    /// <summary>
    ///   <para>gold:OptativeMood</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Optative indicates that the speaker wishes or hopes that the expressed proposition be the case [Bybee, Perkins and Pagliuca 1994: 179; Palmer 2001: 204]."</para>
    /// labels<para>"OptativeMood"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/OptativeMood">http://purl.org/linguistics/gold/OptativeMood</seealso>
    let OptativeMood = Prefixed_Name(gold, "OptativeMood") |> PrefixedName
    /// <summary>
    ///   <para>gold:OrdinalNumeral</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An ordinal numeral is a numeral belonging to a class whose members designate positions in a sequence [Crystal 1997: 272]."</para>
    /// labels<para>"OrdinalNumeral"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/OrdinalNumeral">http://purl.org/linguistics/gold/OrdinalNumeral</seealso>
    let OrdinalNumeral = Prefixed_Name(gold, "OrdinalNumeral") |> PrefixedName
    /// <summary>
    ///   <para>gold:OrthographicPart</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An OrthographicPart is a unit of an orthography that is not orthographically independent, that is, not necessarily able to stand alone as an orthographic word set off by whitespace. In the printed instance of the word 'conceive', 'eive' is an instance of orthographic part. Note that an orthographic part is not the same as a single glyph, although, some orthographic parts are single glyphs."</para>
    /// labels<para>"OrthographicPart"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/OrthographicPart">http://purl.org/linguistics/gold/OrthographicPart</seealso>
    let OrthographicPart = Prefixed_Name(gold, "OrthographicPart") |> PrefixedName
    /// <summary>
    ///   <para>gold:OrthographicPhrase</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An OrthographicPhrase is a sequence of orthographic words."</para>
    /// labels<para>"OrthographicPhrase"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/OrthographicPhrase">http://purl.org/linguistics/gold/OrthographicPhrase</seealso>
    let OrthographicPhrase = Prefixed_Name(gold, "OrthographicPhrase") |> PrefixedName

    /// <summary>
    ///   <para>gold:OrthographicSentence</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An OrthographicSentence is a special type of orthographic phrase, usually representing a clause. In Western writing systems, an orthographic sentence is set off by white space on the left edge and some kind of puncuation, such as a period or question mark, on the right."</para>
    /// labels<para>"OrthographicSentence"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/OrthographicSentence">http://purl.org/linguistics/gold/OrthographicSentence</seealso>
    let OrthographicSentence =
        Prefixed_Name(gold, "OrthographicSentence") |> PrefixedName

    /// <summary>
    ///   <para>gold:OrthographicSystem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A system of the art and rules of spelling according to the accepted standards, i.e., the use of the written characters of a language for forming words and sentences in conformity with the rules conventionally recognized as correct.  [Pei and Gaynor 1980: 155]"</para>
    /// labels<para>"OrthographicSystem"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/OrthographicSystem">http://purl.org/linguistics/gold/OrthographicSystem</seealso>
    let OrthographicSystem = Prefixed_Name(gold, "OrthographicSystem") |> PrefixedName
    /// <summary>
    ///   <para>gold:OrthographicWord</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An OrthographicWord is a fundamental unit of an orthography, usually set off by white space and dependent on the rules of a writing system."</para>
    /// labels<para>"OrthographicWord"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/OrthographicWord">http://purl.org/linguistics/gold/OrthographicWord</seealso>
    let OrthographicWord = Prefixed_Name(gold, "OrthographicWord") |> PrefixedName

    /// <summary>
    ///   <para>gold:OtherSourceEvidentiality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An indication that the source of information is someone other than the speaker.  [Aikhenvald 2006: 106]"</para>
    /// labels<para>"OtherSourceEvidentiality"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/OtherSourceEvidentiality">http://purl.org/linguistics/gold/OtherSourceEvidentiality</seealso>
    let OtherSourceEvidentiality =
        Prefixed_Name(gold, "OtherSourceEvidentiality") |> PrefixedName

    /// <summary>
    ///   <para>gold:OtherThanVisualEvidentiality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"OtherThanVisualEvidentiality encodes the fact that the speaker came to believe the content of the expression directly in a way other than through visual experience; they heard it, smelled it, tasted it, etc. [Palmer 2001: 36, 57]."</para>
    /// labels<para>"OtherThanVisualEvidentiality"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/OtherThanVisualEvidentiality">http://purl.org/linguistics/gold/OtherThanVisualEvidentiality</seealso>
    let OtherThanVisualEvidentiality =
        Prefixed_Name(gold, "OtherThanVisualEvidentiality") |> PrefixedName

    /// <summary>
    ///   <para>gold:Paragraph</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A Paragraph is a self contained unit in written language composed of a sequence of orthographic sentences. Paragraphs are set off by vertical spacing, indentation or other conventions."</para>
    /// labels<para>"Paragraph"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/Paragraph">http://purl.org/linguistics/gold/Paragraph</seealso>
    let Paragraph = Prefixed_Name(gold, "Paragraph") |> PrefixedName

    /// <summary>
    ///   <para>gold:PartOfSpeechProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The property that identifies the grammatical class of a word.  The main 'parts of speech' recognized by most school grammars derive from the work of the ancient Greek and Roman grammarians, primarily the noun, pronoun, verb, adverb, adjective, preposition, conjunction and interjection, with article, participle, and others often added.  Because of the inexplicitness with which these terms were traditionally defined and the restricted nature of their definitions, it has become preferable to use such terms as word-class or form-class, where the grouping is based on formal criteria of a more universally applicable kind. [Crystal 1997: 280]"</para>
    /// labels<para>"PartOfSpeechProperty"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/PartOfSpeechProperty">http://purl.org/linguistics/gold/PartOfSpeechProperty</seealso>
    let PartOfSpeechProperty =
        Prefixed_Name(gold, "PartOfSpeechProperty") |> PrefixedName

    /// <summary>
    ///   <para>gold:Participle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A participle is a word which participates as both a verb (by showing tense) and as an adjective (by showing adjectival inflection).  In modern usage, the term refers to a non-finite part of the verb other than the infinitive (independent of the function of these forms in the sentence).  [Bauer 2004: 82]"</para>
    /// labels<para>"Participle"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/Participle">http://purl.org/linguistics/gold/Participle</seealso>
    let Participle = Prefixed_Name(gold, "Participle") |> PrefixedName
    /// <summary>
    ///   <para>gold:Particle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A term used to refer to an invariable item with grammatical function, especially one which does not readily fit into a standard classification of parts of speech. [Crystal 1997: 279-280]"</para>
    /// labels<para>"Particle"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/Particle">http://purl.org/linguistics/gold/Particle</seealso>
    let Particle = Prefixed_Name(gold, "Particle") |> PrefixedName
    /// <summary>
    ///   <para>gold:PartitiveCase</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"PartitiveCase expresses the partial nature of the referent of the noun it marks, as opposed to expressing the whole unit or class of which the referent is a part. This case may be found in items such as the following: existential clauses, nouns that are accompanied by numerals or units of measure, or predications of material from which something is made. It often has a meaning similar to the English word 'some'. [Pei and Gaynor 1954: 161; Richards, Platt and Weber 1985: 208; Quirk et al. 1985: 249; Sebeok 1946: 1214]"</para>
    /// labels<para>"PartitiveCase"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/PartitiveCase">http://purl.org/linguistics/gold/PartitiveCase</seealso>
    let PartitiveCase = Prefixed_Name(gold, "PartitiveCase") |> PrefixedName
    /// <summary>
    ///   <para>gold:PartitiveNumeral</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A partitive numeral is a numeral that expresses a fraction [Pei and Gaynor 1954: 149; Hartmann and Stork 1972: 165]."</para>
    /// labels<para>"PartitiveNumeral"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/PartitiveNumeral">http://purl.org/linguistics/gold/PartitiveNumeral</seealso>
    let PartitiveNumeral = Prefixed_Name(gold, "PartitiveNumeral") |> PrefixedName
    /// <summary>
    ///   <para>gold:PassiveVoice</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Associated with actions performed on the subject by an unspecified agent [McIntosh 1984: 108]. Refers to the category of verb forms, typically identifies with a specific morphological marking, that encode the derived diatheses in which the agent role is not linked with a subject noun phrase: Diatheis: D1=(X=AgOb)(Y+SUBabs/nom) [Shibatani 1995: 7]."</para>
    /// labels<para>"PassiveVoice"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/PassiveVoice">http://purl.org/linguistics/gold/PassiveVoice</seealso>
    let PassiveVoice = Prefixed_Name(gold, "PassiveVoice") |> PrefixedName
    /// <summary>
    ///   <para>gold:PastInPastTense</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Locates the situation in question prior to a reference time in the past before the time of the speaking event. This is also known as the PluperfectTense [Comrie 1985: 125]."</para>
    /// labels<para>"PastInPastTense"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/PastInPastTense">http://purl.org/linguistics/gold/PastInPastTense</seealso>
    let PastInPastTense = Prefixed_Name(gold, "PastInPastTense") |> PrefixedName
    /// <summary>
    ///   <para>gold:PastPerfectTense</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A tense in which the event that the speaker is referring to precedes the time of the state of affairs denoted by the sentence.  Also referred to as 'past in past' form.  Past perfect can also be used modally to represent situations as non-factual or counterfactual.  [Michaelis 2006: 223; Depraetere and Reed 2006: 271]"</para>
    /// labels<para>"PastPerfectTense"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/PastPerfectTense">http://purl.org/linguistics/gold/PastPerfectTense</seealso>
    let PastPerfectTense = Prefixed_Name(gold, "PastPerfectTense") |> PrefixedName
    /// <summary>
    ///   <para>gold:PastTense</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A value of Tense Feature assigned to the designated element in the clause when the meaning selected for the clause is that intended to locate the event spoken about as anterior to the deictic centre of the utterance. Most commonly, this tense meaning is referred to as 'past', because in absolute tense systems the deictic centre is the moment of speech. However, in relative tense systems, where the deictic centre can be moved to any point on the time line, it is more appropriate to refer to this temporal relation as 'anterior'.
    /// The anterior temporal relation may obtain either in 'simple' or 'perfect' contexts. Modelling of this distinction originates from Reichenbach (1947), who suggested using a third point in time, 'reference point', to capture all possible tense distinctions. In all 'simple' temporal relations, the reference point coincides with the location of the event spoken about. 'Perfect' tense meanings are created when the reference point is separated and moved away from the event time, thus altering the viewing of the temporal location of the event even though the event's actual location with respect to the deictic centre remains the same.
    /// A common instance of an anterior temporal relationship obtaining in a 'perfect' context
    /// occurs when the reference point is moved away from the event time and located instead at the moment of speech. The event time is still anterior to the moment of speech, but it is viewed against a stretch of time which began at the event and continues up to the moment of speech --- e.g. the English I have read this book, I have seen John --- hence the interpretation that the event has an effect or is in some way still relevant at the moment of speech. In some languages (e.g. English) this tense meaning is labelled as (one of the uses of the) Present Perfect, in others (e.g. Polish) this meaning may be collapsed with the 'simple' anterior meaning and labelled simply as Past.
    /// Typically, for a tense value to be labelled as Past Tense, the tense meaning has to minimally express the anterior temporal relationship, although it may additionally express other temporal relationships or aspectual and/or modal meanings. For example, when the usage of the Past Tense value is restricted to a semantically defined domain, it is conventional to add a further qualification to the label of the Past Tense value (e.g. Past Imperfective --- when the anterior temporal relationship is necessarily combined with an aspectual meaning of the Imperfective Aspect value, and grammaticalised as a single [Tense-Aspect-Mood (TAM)] category in the language). [Kibort 2008c: 4]"</para>
    /// labels<para>"PastTense"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/PastTense">http://purl.org/linguistics/gold/PastTense</seealso>
    let PastTense = Prefixed_Name(gold, "PastTense") |> PrefixedName
    /// <summary>
    ///   <para>gold:PaucalNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A category of number denoting the concept 'a few', more than two and usually less than seven, but the exact number varies widely according to context.  Prototypically, it refers to a class of three to five individuals and is always restricted to humans.  [Hartmann and Stork 1972: 166; Corbett 2000: 23]"</para>
    /// labels<para>"PaucalNumber"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/PaucalNumber">http://purl.org/linguistics/gold/PaucalNumber</seealso>
    let PaucalNumber = Prefixed_Name(gold, "PaucalNumber") |> PrefixedName

    /// <summary>
    ///   <para>gold:PejorativeEvaluative</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An evaluative property of a noun that indicates the speaker regards the person or object being referred to with distaste, contempt, or displeasure [Valentine 2001: 190-193]."</para>
    /// labels<para>"PejorativeEvaluative"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/PejorativeEvaluative">http://purl.org/linguistics/gold/PejorativeEvaluative</seealso>
    let PejorativeEvaluative =
        Prefixed_Name(gold, "PejorativeEvaluative") |> PrefixedName

    /// <summary>
    ///   <para>gold:PerfectTense</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A value of Tense Feature assigned to the designated element in the clause when the meaning selected for the clause is that intended to locate the event spoken about as anterior, simultaneous, or posterior to the deictic centre of the utterance, and additionally the reference point from which this event is viewed is separated and moved away from the event time. This alters the viewing of the temporal location of the event even though the event's actual location with respect to the deictic centre remains the same. 'Perfect' temporal relations contrast with 'simple' temporal relations in which the reference point coincides with the location of the event spoken about. Modelling of this distinction originates from [Reichenbach 1947].
    /// There are two types of 'perfect' context which may lead to separate tense values:
    /// (1) The first type occurs when the reference point is moved away from the event time and instead located after the event time. A common example occurs with an anterior temporal relationship, when the reference point is moved from the event time to the moment of speech. The event time is anterior to the moment of speech, but it is viewed against a stretch of time which began at the event and continues up to the moment of speech --- e.g. the English I have read this book, I have seen John --- hence the interpretation that the event has an effect or is in some way still relevant at the moment of speech. [Note that in some languages (e.g. English) this tense meaning is labelled as (one of the uses of the) Present Perfect, in others (e.g. Polish) this meaning may be collapsed with the 'simple' anterior meaning and labelled simply as Past.] The interpretation of this type of the perfect often includes at least two related but distinguishable uses: the resultative perfect (Someone has stolen my purse) and the experiential perfect (I have read this book before) [Dahl and Velupillai 2005: 271].
    /// (2) The second type occurs when the reference point is moved away from the event time and instead located before the event time. A common example occurs with a simultaneous temporal relationship, when the reference point is moved from the event time and located before the moment of speech. The event time is still simultaneous with the moment of speech, but it is viewed against a stretch of time which began at the reference point and continues up to the moment of speech --- e.g. the English I have lived here [for ten years] --- hence the interpretation that the event which began in the past extends up to the moment of speech. [Note that in some languages (e.g. English) this tense meaning is labelled as (one of the uses of the) Present Perfect, in others (e.g. Polish) this meaning may be collapsed with the 'simple' simultaneous meaning and labelled simply as Present.] The interpretation of this type of the perfect is often referred to as the universal perfect or perfect of persistent situation.
    /// Typically, for a tense value to be labelled as Perfect Tense, the tense meaning has to minimally express the meaning resulting from the separation of the reference point from the event time, although it may additionally express other temporal, aspectual, or modal meanings. [Kibort 2008c: 5-6]"</para>
    /// labels<para>"PerfectTense"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/PerfectTense">http://purl.org/linguistics/gold/PerfectTense</seealso>
    let PerfectTense = Prefixed_Name(gold, "PerfectTense") |> PrefixedName
    /// <summary>
    ///   <para>gold:PerfectiveAspect</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A value of Aspect Property assigned to the designated element in the clause when the meaning selected for the clause is that which indicates that the event spoken about is to be viewed as a bounded whole, looked at from outside, without necessarily distinguishing any of its internal structure [Comrie 1976: 16ff].
    ///
    /// Typically, for an aspect value to be labeled as Perfective, the aspectual meaning has to minimally express the perfective viewpoint, although it may additionally express other temporal, aspectual, or modal meanings, or actionality distinctions. [Kibort 2008c: 7]"</para>
    /// labels<para>"PerfectiveAspect"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/PerfectiveAspect">http://purl.org/linguistics/gold/PerfectiveAspect</seealso>
    let PerfectiveAspect = Prefixed_Name(gold, "PerfectiveAspect") |> PrefixedName
    /// <summary>
    ///   <para>gold:PerlativeCase</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"PerlativeCase expresses that something moved 'through','across', or 'along' the referent of the noun that is marked [Blake 2001]."</para>
    /// labels<para>"PerlativeCase"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/PerlativeCase">http://purl.org/linguistics/gold/PerlativeCase</seealso>
    let PerlativeCase = Prefixed_Name(gold, "PerlativeCase") |> PrefixedName
    /// <summary>
    ///   <para>gold:PermissiveModality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"PermissiveModality indicates that an agent has permission to perform the action expressed by the predicate [Palmer 2001: 10, 71]."</para>
    /// labels<para>"PermissiveModality"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/PermissiveModality">http://purl.org/linguistics/gold/PermissiveModality</seealso>
    let PermissiveModality = Prefixed_Name(gold, "PermissiveModality") |> PrefixedName
    /// <summary>
    ///   <para>gold:PersonProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"PersonProperty is the class of properties  with a deictic dimension, interpreted relative to the speaker, encoding the participants in a speech situation. Usually a three-way contrast is found: firstPerson (speaker), secondPerson (addressee), and thirdPerson (neither speaker nor addressee). Other distinctions within this feature include: inclusive/exclusive and proximative/obviative. [Crystal 1997: 285-286]"</para>
    /// labels<para>"PersonProperty"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/PersonProperty">http://purl.org/linguistics/gold/PersonProperty</seealso>
    let PersonProperty = Prefixed_Name(gold, "PersonProperty") |> PrefixedName

    /// <summary>
    ///   <para>gold:PersonalPassiveVoice</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A Passive in which the argument mapped to Object in a basic structural configuration assumes the Subject relation in a corresponding nonbasic configuration [Klaiman 1991: 23]."</para>
    /// labels<para>"PersonalPassiveVoice"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/PersonalPassiveVoice">http://purl.org/linguistics/gold/PersonalPassiveVoice</seealso>
    let PersonalPassiveVoice =
        Prefixed_Name(gold, "PersonalPassiveVoice") |> PrefixedName

    /// <summary>
    ///   <para>gold:PersonalPronoun</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A pronoun used to refer to the speaker, the person spoken to, and other persons and things whose referents are presumed to be clear from the context.  While some personal pronouns in some languages occur in essentially the same sentence position as other nominal expressions, it is rather common for them to show distributional peculiarities.  Personal pronouns may be clitics whose distribution may be consistently distinct from that of non-clitic nominals.  It is also common for the equivalent of personal pronouns to be expressed by affixes on the verb. [Schachter 1985: 25-26]"</para>
    /// labels<para>"PersonalPronoun"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/PersonalPronoun">http://purl.org/linguistics/gold/PersonalPronoun</seealso>
    let PersonalPronoun = Prefixed_Name(gold, "PersonalPronoun") |> PrefixedName
    /// <summary>
    ///   <para>gold:PhasalAspect</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A set of aspectual distinctions involving relations between a background situation (the reference situation) and a situation located relative to the reference situation (the denoted situation). In English, phasal distinctions are expressed by auxiliary-headed constructions, like the inceptive, progressive, and perfect constructions, whose head verbs express the aspectual class of the denoted situation. The aspectual class of the denoted situation differs from that of the reference situation [Michaelis 1998: xv]. An event may have a beginning and an end, a middle portion (continuing or changing), and also an ensuing result or an altered state. These are considered to be the various "phases" of an event. A speaker may talk about an event from the point of view of any of these individual phases, and his language may have inflectional (or other type of) markers for representing these distinctions. Since such markers indicate distinctions in the temporal structure of an event, we may regard them as belonging to the category of aspect. It has been suggested [Dik 1989: 186] that these may be grouped under a subcategory (or "level") of aspect called "phasal aspect". [Bhat 1999: 49]"</para>
    /// labels<para>"PhasalAspect"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/PhasalAspect">http://purl.org/linguistics/gold/PhasalAspect</seealso>
    let PhasalAspect = Prefixed_Name(gold, "PhasalAspect") |> PrefixedName
    /// <summary>
    ///   <para>gold:Phoneme</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A phoneme is the underlying sound in a set of phonetically distinct sounds that native speakers of a language judge to be identical.   Variants of the underlying sound are the product of systematic rules that modify the segment depending on the phonological context in which it occurs. [Kenstowicz 1994: 65-66]"</para>
    /// labels<para>"Phoneme"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/Phoneme">http://purl.org/linguistics/gold/Phoneme</seealso>
    let Phoneme = Prefixed_Name(gold, "Phoneme") |> PrefixedName
    /// <summary>
    ///   <para>gold:PhoneticProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The class of properties used to describe speech sounds. The properties given here are more or less taken directly from Ladefoged's later works, in particular, the taxonomies of Ladefoged [Ladefoged 1997]."</para>
    /// labels<para>"PhoneticProperty"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/PhoneticProperty">http://purl.org/linguistics/gold/PhoneticProperty</seealso>
    let PhoneticProperty = Prefixed_Name(gold, "PhoneticProperty") |> PrefixedName

    /// <summary>
    ///   <para>gold:PhonologicalProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The class of linguistic properties that pertain to phonological units and that are used to describe the sound system of languages [Hartmann and Stork 1972: 174]. Phonological units can be analyzed into complexes of distinctive properties that cross-classify the entire inventory of possible speech sounds into a densely packed network [Kenstowicz 1994: 19]."</para>
    /// labels<para>"PhonologicalProperty"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/PhonologicalProperty">http://purl.org/linguistics/gold/PhonologicalProperty</seealso>
    let PhonologicalProperty =
        Prefixed_Name(gold, "PhonologicalProperty") |> PrefixedName

    /// <summary>
    ///   <para>gold:PhonologicalSystem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The set of consonant and vowel units that make up the words of a language or language variety, a phonological system is a list of contrastive sounds used in a language that are capable of distinguishing between two words with different meanings together with the ranges of variety each sound has and where those variants are found. [Ball and Mueller 2005: 120]"</para>
    /// labels<para>"PhonologicalSystem"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/PhonologicalSystem">http://purl.org/linguistics/gold/PhonologicalSystem</seealso>
    let PhonologicalSystem = Prefixed_Name(gold, "PhonologicalSystem") |> PrefixedName
    /// <summary>
    ///   <para>gold:Phrase</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Phrase is the class of syntactic constructions that consist of one or more syntactic words, but lack the subject-predicate organization of a clause. Phrases get their grammatical characteristics according to what word occupies the head position; thus, all phrases have heads. [Crystal 1980: 232-233;  Pei and Gaynor 1954: 169; Pike and Pike 1982: 453]"</para>
    /// labels<para>"Phrase"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/Phrase">http://purl.org/linguistics/gold/Phrase</seealso>
    let Phrase = Prefixed_Name(gold, "Phrase") |> PrefixedName

    /// <summary>
    ///   <para>gold:PhysicalAbilitiveModality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"PhysicalAbilitiveModality indicates that an agent has the physical capacity to perform some action. [Bybee, Perkins and Pagliuca 1994: 192; Palmer 2001: 77]"</para>
    /// labels<para>"PhysicalAbilitiveModality"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/PhysicalAbilitiveModality">http://purl.org/linguistics/gold/PhysicalAbilitiveModality</seealso>
    let PhysicalAbilitiveModality =
        Prefixed_Name(gold, "PhysicalAbilitiveModality") |> PrefixedName

    /// <summary>
    ///   <para>gold:PlaceProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The superclass of properties that specify the location of the articulators [Ladefoged 1997: 594]."</para>
    /// labels<para>"PlaceProperty"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/PlaceProperty">http://purl.org/linguistics/gold/PlaceProperty</seealso>
    let PlaceProperty = Prefixed_Name(gold, "PlaceProperty") |> PrefixedName
    /// <summary>
    ///   <para>gold:PlainAdjective</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An adjective without any markings for comparative or superlative form, sometimes called "positive" form.  It is that form of an adjective which merely expresses the presence of a quality or condition, without comparing or indicating its degree.  [Pei and Gaynor 1980:  172, Hartmann and Stork 1972: 5]"</para>
    /// labels<para>"PlainAdjective"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/PlainAdjective">http://purl.org/linguistics/gold/PlainAdjective</seealso>
    let PlainAdjective = Prefixed_Name(gold, "PlainAdjective") |> PrefixedName
    /// <summary>
    ///   <para>gold:PlainMiddleVoice</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Results of action occur to subject [Siewierska 1988: 257]."</para>
    /// labels<para>"PlainMiddleVoice"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/PlainMiddleVoice">http://purl.org/linguistics/gold/PlainMiddleVoice</seealso>
    let PlainMiddleVoice = Prefixed_Name(gold, "PlainMiddleVoice") |> PrefixedName
    /// <summary>
    ///   <para>gold:PluralNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"PluralNumber is a number property that quantifies the denotation of the nominal element so that: 1) it specifies that there are more than one. In this English example below, plural is shown by both the noun and the verb in (2):
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
    /// nebel-in 'a cock ostrich' ln General ln tíise 'maize cob(s)' ln lássa 'bread' ln nebel 'ostrich(es)' ln [Corbett 2000: 17-18]"</para>
    /// labels<para>"PluralNumber"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/PluralNumber">http://purl.org/linguistics/gold/PluralNumber</seealso>
    let PluralNumber = Prefixed_Name(gold, "PluralNumber") |> PrefixedName
    /// <summary>
    ///   <para>gold:PlusATR</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"PlusATR (Advanced Tongue Root) characterizes sounds made with the root of the tongue drawn forward and the larynx lowered so that the part of the vocal tract in the pharynx is considerably enlarged. [Ladefoged 2000: 211]"</para>
    /// labels<para>"PlusATR"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/PlusATR">http://purl.org/linguistics/gold/PlusATR</seealso>
    let PlusATR = Prefixed_Name(gold, "PlusATR") |> PrefixedName
    /// <summary>
    ///   <para>gold:PlusClick</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"PlusClick refers to having the properties of a click.  Clicks are stops in which the essential component is the rarefaction of air enclosed between two articulatory closures formed in the oral cavity, so that a loud transient is produced when the more forward closure is released.  This uses the velaric airstream mechanism, always ingressive, and cannot be used for sounds other than stops and affricates.  [Ladefoged and Maddieson 1996: 246]"</para>
    /// labels<para>"PlusClick"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/PlusClick">http://purl.org/linguistics/gold/PlusClick</seealso>
    let PlusClick = Prefixed_Name(gold, "PlusClick") |> PrefixedName
    /// <summary>
    ///   <para>gold:PlusFortis</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"PlusFortis refers to a sound made with relatively strong degree of muscular effort and breath force.  [Crystal 1985: 126]"</para>
    /// labels<para>"PlusFortis"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/PlusFortis">http://purl.org/linguistics/gold/PlusFortis</seealso>
    let PlusFortis = Prefixed_Name(gold, "PlusFortis") |> PrefixedName
    /// <summary>
    ///   <para>gold:PlusNasal</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Characterizing sounds in which the palatorpharyngeal and palatoglossus muscles lower the velum, allowing air to go out through the nose. [Kenstowicz 1994: 143; Ladefoged 2000: 274]"</para>
    /// labels<para>"PlusNasal"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/PlusNasal">http://purl.org/linguistics/gold/PlusNasal</seealso>
    let PlusNasal = Prefixed_Name(gold, "PlusNasal") |> PrefixedName
    /// <summary>
    ///   <para>gold:PolarityProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The property concerned with encoding the system of positive/negative contrastivity found in a language.  The distinction between 'positive' and 'negative polarity' may be expressed syntactically, morphologically or lexically. [Crystal 1997: 297]"</para>
    /// labels<para>"PolarityProperty"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/PolarityProperty">http://purl.org/linguistics/gold/PolarityProperty</seealso>
    let PolarityProperty = Prefixed_Name(gold, "PolarityProperty") |> PrefixedName
    /// <summary>
    ///   <para>gold:PoliticalTaxon</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"PoliticalTaxon is the class of taxons whose instances are groupings based on political entities such as states or countries or larger politically defined entities, e.g., CameroonianLanguage."</para>
    /// labels<para>"PoliticalTaxon"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/PoliticalTaxon">http://purl.org/linguistics/gold/PoliticalTaxon</seealso>
    let PoliticalTaxon = Prefixed_Name(gold, "PoliticalTaxon") |> PrefixedName
    /// <summary>
    ///   <para>gold:PositivePolarity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"In general, positive polarity refers to an assertion that contains no marker of negation [Crystal 1980:  299]."</para>
    /// labels<para>"PositivePolarity"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/PositivePolarity">http://purl.org/linguistics/gold/PositivePolarity</seealso>
    let PositivePolarity = Prefixed_Name(gold, "PositivePolarity") |> PrefixedName
    /// <summary>
    ///   <para>gold:PossessedCase</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"PossessedCase is used to mark the noun whose referent is possessed by the referent of another noun."</para>
    /// labels<para>"PossessedCase"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/PossessedCase">http://purl.org/linguistics/gold/PossessedCase</seealso>
    let PossessedCase = Prefixed_Name(gold, "PossessedCase") |> PrefixedName
    /// <summary>
    ///   <para>gold:PossessivePronoun</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A possessive pronoun is a pronoun that expresses ownership and relationships like ownership, such as kinship, and other forms of association [Crystal 1997: 312]."</para>
    /// labels<para>"PossessivePronoun"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/PossessivePronoun">http://purl.org/linguistics/gold/PossessivePronoun</seealso>
    let PossessivePronoun = Prefixed_Name(gold, "PossessivePronoun") |> PrefixedName
    /// <summary>
    ///   <para>gold:PossibilityModality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"PossibilityModality indicates that the designated state of affairs is possible [Palmer 2001: 89-90], either directly, or because an agent has the ability or permission to carry it out [Bybee, Perkins and Pagliuca 1994: 177]."</para>
    /// labels<para>"PossibilityModality"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/PossibilityModality">http://purl.org/linguistics/gold/PossibilityModality</seealso>
    let PossibilityModality = Prefixed_Name(gold, "PossibilityModality") |> PrefixedName

    /// <summary>
    ///   <para>gold:PostHodiernalFutureTense</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"PostHodiernalFutureTense locates the situation in question after the span that is culturally defined as 'today' [Bybee, Perkins and Pagliuca 1994: 247]."</para>
    /// labels<para>"PostHodiernalFutureTense"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/PostHodiernalFutureTense">http://purl.org/linguistics/gold/PostHodiernalFutureTense</seealso>
    let PostHodiernalFutureTense =
        Prefixed_Name(gold, "PostHodiernalFutureTense") |> PrefixedName

    /// <summary>
    ///   <para>gold:Postalveolar</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Characterizing sounds produced with the area just behind the center of the alveolar ridge as the passive articulator [Ladefoged 1997: 597]."</para>
    /// labels<para>"Postalveolar"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/Postalveolar">http://purl.org/linguistics/gold/Postalveolar</seealso>
    let Postalveolar = Prefixed_Name(gold, "Postalveolar") |> PrefixedName
    /// <summary>
    ///   <para>gold:Postposition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A postposition is an adposition that occurs after its complement [Crystal 1997: 300; Payne 1997: 86]."</para>
    /// labels<para>"Postposition"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/Postposition">http://purl.org/linguistics/gold/Postposition</seealso>
    let Postposition = Prefixed_Name(gold, "Postposition") |> PrefixedName

    /// <summary>
    ///   <para>gold:PragmaticInverseVoice</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"If the agent is more topical than the patient, the direct-active clause is used.  If norm is reversed and the patient is more topical, the inverse clause is used. [Givon 1994: 23]"</para>
    /// labels<para>"PragmaticInverseVoice"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/PragmaticInverseVoice">http://purl.org/linguistics/gold/PragmaticInverseVoice</seealso>
    let PragmaticInverseVoice =
        Prefixed_Name(gold, "PragmaticInverseVoice") |> PrefixedName

    /// <summary>
    ///   <para>gold:PreHodiernalPastTense</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"PreHodiernalPastTense locates the situation in question before that of a contrasting HodiernalPastTense. This category must be defined relative to a HodiernalPastTense. [Bybee, Perkins and Pagliuca 1994: 98]"</para>
    /// labels<para>"PreHodiernalPastTense"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/PreHodiernalPastTense">http://purl.org/linguistics/gold/PreHodiernalPastTense</seealso>
    let PreHodiernalPastTense =
        Prefixed_Name(gold, "PreHodiernalPastTense") |> PrefixedName

    /// <summary>
    ///   <para>gold:Predicator</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Predicator is the class of syntactic words that are fundamentally relation inducing. That is, predicators license argument structure [Anderson 1997: 14]. Verbs are quintessential predicators, though other categories, such as determiners and some nouns, are also predicative in nature."</para>
    /// labels<para>"Predicator"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/Predicator">http://purl.org/linguistics/gold/Predicator</seealso>
    let Predicator = Prefixed_Name(gold, "Predicator") |> PrefixedName
    /// <summary>
    ///   <para>gold:PreferredEvaluative</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An evaluative property  of a noun that indicates the speaker regards the person or object being referred to with favor or admiration."</para>
    /// labels<para>"PreferredEvaluative"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/PreferredEvaluative">http://purl.org/linguistics/gold/PreferredEvaluative</seealso>
    let PreferredEvaluative = Prefixed_Name(gold, "PreferredEvaluative") |> PrefixedName
    /// <summary>
    ///   <para>gold:Prefix</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An affix which is added to the front of a root or stem.  [Hartmann and Stork 1972: 182]"</para>
    /// labels<para>"Prefix"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/Prefix">http://purl.org/linguistics/gold/Prefix</seealso>
    let Prefix = Prefixed_Name(gold, "Prefix") |> PrefixedName
    /// <summary>
    ///   <para>gold:Prenoun</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An element which may be compounded to the front of a noun to signal information such as size, color, etc. [Valentine 2001: 152-154]."</para>
    /// labels<para>"Prenoun"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/Prenoun">http://purl.org/linguistics/gold/Prenoun</seealso>
    let Prenoun = Prefixed_Name(gold, "Prenoun") |> PrefixedName
    /// <summary>
    ///   <para>gold:Preposition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A preposition is an adposition that occurs before its complement [Crystal 1997: 305; Payne 1997: 86]."</para>
    /// labels<para>"Preposition"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/Preposition">http://purl.org/linguistics/gold/Preposition</seealso>
    let Preposition = Prefixed_Name(gold, "Preposition") |> PrefixedName
    /// <summary>
    ///   <para>gold:PresentPerfectTense</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A value of Tense Feature assigned to the designated element in the clause when the meaning selected for the clause is that intended to locate the event spoken about as simultaneous with the deictic centre of the utterance. Most commonly, this tense meaning is referred to as 'present', because in absolute tense systems the deictic centre is the moment of speech. However, in relative tense systems, where the deictic centre can be moved to any point on the time line, it is more appropriate to refer to this temporal relation as 'simultaneous'.
    /// The simultaneous temporal relation may obtain either in 'simple' or 'perfect' contexts. Modelling of this distinction originates from [Reichenbach 1947], who suggested using a third point in time, 'reference point', to capture all possible tense distinctions. In all 'simple' temporal relations, the reference point coincides with the location of the event spoken about. 'Perfect' tense meanings are created when the reference point is separated and moved away from the event time, thus altering the viewing of the temporal location of the event even though the event's actual location with respect to the deictic centre remains the same.
    /// A common instance of a simultaneous temporal relationship obtaining in a 'perfect' context occurs when the reference point is moved away from the event time and located instead before the moment of speech. The event time is still simultaneous with the moment of speech, but it is viewed against a stretch of time which began at the reference point and continues up to the moment of speech --- e.g. the English I have lived here [for ten years] --- hence the interpretation that the event which began in the past extends up to the moment of speech. In some languages (e.g. English) this tense meaning is labelled as (one of the uses of the) Present Perfect, in others (e.g. Polish) this meaning may be collapsed with the 'simple' simultaneous meaning and labelled simply as Present. [Kibort 2008c: 4-5]"</para>
    /// labels<para>"PresentPerfectTense"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/PresentPerfectTense">http://purl.org/linguistics/gold/PresentPerfectTense</seealso>
    let PresentPerfectTense = Prefixed_Name(gold, "PresentPerfectTense") |> PrefixedName
    /// <summary>
    ///   <para>gold:PresentTense</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A value of Tense Property assigned to the designated element in the clause when the meaning selected for the clause is that intended to locate the event spoken about as simultaneous with the deictic centre of the utterance. Most commonly, this tense meaning is referred to as 'present', because in absolute tense systems the deictic centre is the moment of speech. However, in relative tense systems, where the deictic centre can be moved to any point on the time line, it is more appropriate to refer to this temporal relation as 'simultaneous'.
    /// It is important to note --- for all tense values, but in particular for the Present Tense --- that the 'times' which are used to locate the event, the deictic centre, and the reference point, may or may not be 'points' on the time line. Conventionally, these concepts are considered neutral with regard to whether they are points or intervals of time longer than a point. In a formal model of tense meanings they could, for example, be represented as sets (of points): in order to capture temporal distinctions, the notion of an event being 'simultaneous with the moment of speech', may be understood as (the set of) event time (points) and (the set of) speech time (points) having a non-empty intersection. Hence, this semantic model of the Present Tense value may include the interpretation of the present as 'universal' or 'generic'.
    /// The simultaneous temporal relation may obtain either in 'simple' or 'perfect' contexts. Modelling of this distinction originates from [Reichenbach 1947], who suggested using a third point in time, 'reference point', to capture all possible tense distinctions. In all 'simple' temporal relations, the reference point coincides with the location of the event spoken about. 'Perfect' tense meanings are created when the reference point is separated and moved away from the event time, thus altering the viewing of the temporal location of the event even though the event's actual location with respect to the deictic centre remains the same.
    /// A common instance of a simultaneous temporal relationship obtaining in a 'perfect' context occurs when the reference point is moved away from the event time and located instead before the moment of speech. The event time is still simultaneous with the moment of speech, but it is viewed against a stretch of time which began at the reference point and continues up to the moment of speech --- e.g. the English I have lived here [for ten years] --- hence the interpretation that the event which began in the past extends up to the moment of speech. In some languages (e.g. English) this tense meaning is labelled as (one of the uses of the) Present Perfect, in others (e.g. Polish) this meaning may be collapsed with the 'simple' simultaneous meaning and labelled simply as Present.
    /// Typically, for a tense value to be labelled as Present Tense, the tense meaning has to minimally express the simultaneous temporal relationship, although it may additionally express other temporal, aspectual, or modal meanings. [Kibort 2008c: 4-5]"</para>
    /// labels<para>"PresentTense"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/PresentTense">http://purl.org/linguistics/gold/PresentTense</seealso>
    let PresentTense = Prefixed_Name(gold, "PresentTense") |> PrefixedName
    /// <summary>
    ///   <para>gold:Preverb</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An element which may be compounded to the front of a verb, to signal information such as tense, direction, etc. [Valentine 2001: 154-158]."</para>
    /// labels<para>"Preverb"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/Preverb">http://purl.org/linguistics/gold/Preverb</seealso>
    let Preverb = Prefixed_Name(gold, "Preverb") |> PrefixedName
    /// <summary>
    ///   <para>gold:ProForm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A ProForm is a partOfSpeech whose members usually substitute for other constituents, including phrases, clauses, or sentences, and whose meaning is recoverable from the linguistic or extralinguistic context [Crystal 1997: 310; Schachter 1985: 24-25]."</para>
    /// labels<para>"ProForm"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/ProForm">http://purl.org/linguistics/gold/ProForm</seealso>
    let ProForm = Prefixed_Name(gold, "ProForm") |> PrefixedName
    /// <summary>
    ///   <para>gold:ProVerb</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A proverb (frequently written "pro-verb") is a ProForm that substitutes for a verb or verb phrase. [Schachter 1985: 34]"</para>
    /// labels<para>"ProVerb"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/ProVerb">http://purl.org/linguistics/gold/ProVerb</seealso>
    let ProVerb = Prefixed_Name(gold, "ProVerb") |> PrefixedName
    /// <summary>
    ///   <para>gold:Proadjective</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A Proadjective is a ProForm that substitutes for an adjective or adjective phrase. [Crystal 1997: 310]"</para>
    /// labels<para>"Proadjective"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/Proadjective">http://purl.org/linguistics/gold/Proadjective</seealso>
    let Proadjective = Prefixed_Name(gold, "Proadjective") |> PrefixedName
    /// <summary>
    ///   <para>gold:Proadverb</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A Proadverb is a Proform that substitutes for an adverb or other expression having an adverbial function. [Crystal 1997: 310]"</para>
    /// labels<para>"Proadverb"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/Proadverb">http://purl.org/linguistics/gold/Proadverb</seealso>
    let Proadverb = Prefixed_Name(gold, "Proadverb") |> PrefixedName
    /// <summary>
    ///   <para>gold:Process</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The class of things that happen and have temporal parts or stages. Examples include extended events like a football match or a race, actions like pursuing and reading, and biological processes. The formal definition is: anything that occurs in time but is not an object. Note that a process may have participants 'inside' it which are objects, such as the players in a football match. In a 4D ontology, a process is something whose spatiotemporal extent is thought of as dividing into temporal stages roughly perpendicular to the time-axis. [SUMO 2010]"</para>
    /// labels<para>"Process"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/Process">http://purl.org/linguistics/gold/Process</seealso>
    let Process = Prefixed_Name(gold, "Process") |> PrefixedName
    /// <summary>
    ///   <para>gold:Processive</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A derivational morpheme that derives transitives from other transitives or intransitive verb."</para>
    /// labels<para>"Processive"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/Processive">http://purl.org/linguistics/gold/Processive</seealso>
    let Processive = Prefixed_Name(gold, "Processive") |> PrefixedName
    /// <summary>
    ///   <para>gold:Proclitic</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A proclitic is a clitic that precedes the lexical unit to which it is phonologically joined [Crystal 1980: 64; Hartmann and Stork 1972: 185; Pei and Gaynor 1954: 176]."</para>
    /// labels<para>"Proclitic"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/Proclitic">http://purl.org/linguistics/gold/Proclitic</seealso>
    let Proclitic = Prefixed_Name(gold, "Proclitic") |> PrefixedName
    /// <summary>
    ///   <para>gold:ProgressiveAspect</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A value of Aspect Property (also called Nonstative aspect) assigned to the designated element in the clause when the meaning selected for the clause is that which indicates that the situation spoken about has internal temporal structure, it cannot be regarded as habitual, and reference is made to this situation in progress. Hence, progressiveness can be defined as the combination of progressive meaning with nonstative meaning, and it can be regarded as a sub-type of continuousness (which, in turn, is a sub-type of imperfectivity). Since languages have different criteria for classifying predicates as stative or not, they may have different rules for determining when explicitly progressive forms can be used.
    ///
    /// Typically, for an aspect value to be labelled as Progressive, the aspectual meaning has to minimally express progressiveness, although it may additionally express other temporal, aspectual, or modal meanings, or actionality distinctions. [Kibort 2008c: 8]"</para>
    /// labels<para>"ProgressiveAspect"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/ProgressiveAspect">http://purl.org/linguistics/gold/ProgressiveAspect</seealso>
    let ProgressiveAspect = Prefixed_Name(gold, "ProgressiveAspect") |> PrefixedName

    /// <summary>
    ///   <para>gold:ProgressivePassiveVoice</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A passive in Irish  in which the preposition "at" is used, and a semantic meaning of progressive tense is found [Noonan 1994: 280]."</para>
    /// labels<para>"ProgressivePassiveVoice"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/ProgressivePassiveVoice">http://purl.org/linguistics/gold/ProgressivePassiveVoice</seealso>
    let ProgressivePassiveVoice =
        Prefixed_Name(gold, "ProgressivePassiveVoice") |> PrefixedName

    /// <summary>
    ///   <para>gold:ProhibitiveMood</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Prohibitive mood is a directive mood that signals a prohibition. It is distinguished by the use of a negated imperative sentence that employs a negative marker distinct from that used in declarative sentences, or a verb form different from that of the imperative. [SIL International 2004]"</para>
    /// labels<para>"ProhibitiveMood"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/ProhibitiveMood">http://purl.org/linguistics/gold/ProhibitiveMood</seealso>
    let ProhibitiveMood = Prefixed_Name(gold, "ProhibitiveMood") |> PrefixedName

    /// <summary>
    ///   <para>gold:PromotionalInverseVoice</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Involves promotion of the topical proximate-patient to subjecthood [Givon 1994: 24]."</para>
    /// labels<para>"PromotionalInverseVoice"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/PromotionalInverseVoice">http://purl.org/linguistics/gold/PromotionalInverseVoice</seealso>
    let PromotionalInverseVoice =
        Prefixed_Name(gold, "PromotionalInverseVoice") |> PrefixedName

    /// <summary>
    ///   <para>gold:Pronominal</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A Pronoun is a ProForm which functions like a noun and substitutes for a noun or  noun phrase [Crystal 1997: 312]."</para>
    /// labels<para>"Pronominal"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/Pronominal">http://purl.org/linguistics/gold/Pronominal</seealso>
    let Pronominal = Prefixed_Name(gold, "Pronominal") |> PrefixedName
    /// <summary>
    ///   <para>gold:ProperNoun</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"ProperNoun, also referred to as proper names, is the class of nouns that are used to address particular persons or culturally significant personages or places. They refer to specific entities and are not usually with articles, modifiers, possessors. [Payne 1997: 39]"</para>
    /// labels<para>"ProperNoun"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/ProperNoun">http://purl.org/linguistics/gold/ProperNoun</seealso>
    let ProperNoun = Prefixed_Name(gold, "ProperNoun") |> PrefixedName
    /// <summary>
    ///   <para>gold:Protruded</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An articulatory characteristic resulting from protrusion of the lips, often resulting in the appearance of a small labial cavity forward of the teeth and bounded at the front by the inside surfaces of the lips.  Often occurring with lip rounding, the protruded quality modifies the basic articulation by extending the length of the vocal tract and altering its cross-section, resulting in lowered frequencies on all formants.  Back rounded vowels are commonly more protruded than front rounded vowels. [Brosnahan and Malmberg 1976: 43, 67; Clark, Yallop and Fletcher 2007: 26, 64]"</para>
    /// labels<para>"Protruded"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/Protruded">http://purl.org/linguistics/gold/Protruded</seealso>
    let Protruded = Prefixed_Name(gold, "Protruded") |> PrefixedName
    /// <summary>
    ///   <para>gold:PulmonicProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Pulmonic refers to an air-stream mechanism wherein the air is generated in the lungs and pushed out under the control of the respiratory muscles. [Ladefoged 2000: 122]"</para>
    /// labels<para>"PulmonicProperty"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/PulmonicProperty">http://purl.org/linguistics/gold/PulmonicProperty</seealso>
    let PulmonicProperty = Prefixed_Name(gold, "PulmonicProperty") |> PrefixedName

    /// <summary>
    ///   <para>gold:QuantificationalAspect</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A speaker may report an event as occurring once only (semelfactive) or several times (iterative); he may view it as a specific event or as part of a general habit of carrying out similar events; he may also differentiate between different degrees of frequency with which the event occurs. The markers that a given language provides for one or more of these meaning distinctions can be grouped under a subcategory called “quantificational aspect”, as all of them refer to the quantitative aspect of the event concerned. [Bhat 1999: 53]"</para>
    /// labels<para>"QuantificationalAspect"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/QuantificationalAspect">http://purl.org/linguistics/gold/QuantificationalAspect</seealso>
    let QuantificationalAspect =
        Prefixed_Name(gold, "QuantificationalAspect") |> PrefixedName

    /// <summary>
    ///   <para>gold:Quantifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A quantifier is a determiner that expresses a referent's definite or indefinite  number or amount. A quantifier functions as a modifier of a noun, or a pronoun. [Crystal 1997: 317]"</para>
    /// labels<para>"Quantifier"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/Quantifier">http://purl.org/linguistics/gold/Quantifier</seealso>
    let Quantifier = Prefixed_Name(gold, "Quantifier") |> PrefixedName
    /// <summary>
    ///   <para>gold:RadicalProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The class of place  properties used to classifiy articulatory gestures made with the root of the tongue. [Ladefoged 1997: 603]"</para>
    /// labels<para>"RadicalProperty"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/RadicalProperty">http://purl.org/linguistics/gold/RadicalProperty</seealso>
    let RadicalProperty = Prefixed_Name(gold, "RadicalProperty") |> PrefixedName
    /// <summary>
    ///   <para>gold:RealisMood</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Realis modality is a modality that connotes the factuality of a proposition. In its broad usage, the term realis is approximately equivalent in meaning to the term indicative, which in turn is used, narrowly, as a synonym to declarative. [SIL International 2004]"</para>
    /// labels<para>"RealisMood"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/RealisMood">http://purl.org/linguistics/gold/RealisMood</seealso>
    let RealisMood = Prefixed_Name(gold, "RealisMood") |> PrefixedName
    /// <summary>
    ///   <para>gold:RecentPastTense</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"RecentPastTense locates the situation in question prior to the present moment, but by culturally and situationally defined criteria, usually within the span ranging from yesterday to a week or a few months previous [Comrie 1985: 87; Dahl 1985: 121-122]."</para>
    /// labels<para>"RecentPastTense"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/RecentPastTense">http://purl.org/linguistics/gold/RecentPastTense</seealso>
    let RecentPastTense = Prefixed_Name(gold, "RecentPastTense") |> PrefixedName

    /// <summary>
    ///   <para>gold:ReciprocalMiddleVoice</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Referents of plural subject do action to one another [Siewierska 1988: 257]."</para>
    /// labels<para>"ReciprocalMiddleVoice"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/ReciprocalMiddleVoice">http://purl.org/linguistics/gold/ReciprocalMiddleVoice</seealso>
    let ReciprocalMiddleVoice =
        Prefixed_Name(gold, "ReciprocalMiddleVoice") |> PrefixedName

    /// <summary>
    ///   <para>gold:ReciprocalPronoun</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A reciprocal pronoun is a pronoun that expresses a mutual feeling or action among the referents of a plural subject [Crystal 1997: 323]."</para>
    /// labels<para>"ReciprocalPronoun"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/ReciprocalPronoun">http://purl.org/linguistics/gold/ReciprocalPronoun</seealso>
    let ReciprocalPronoun = Prefixed_Name(gold, "ReciprocalPronoun") |> PrefixedName
    /// <summary>
    ///   <para>gold:ReferentialVoice</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"ReferentialVoice entails assignment of the absolutive to certain kinds of arguments other than logical subjects (agents) and objects (patients), targeting semantic roles such as dative, benefactive, malefactive and possessor. [Klaiman 1991: 239]"</para>
    /// labels<para>"ReferentialVoice"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/ReferentialVoice">http://purl.org/linguistics/gold/ReferentialVoice</seealso>
    let ReferentialVoice = Prefixed_Name(gold, "ReferentialVoice") |> PrefixedName

    /// <summary>
    ///   <para>gold:ReflexiveMiddleVoice</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Subjects perform action to self [Siewierska 1988: 257]."</para>
    /// labels<para>"ReflexiveMiddleVoice"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/ReflexiveMiddleVoice">http://purl.org/linguistics/gold/ReflexiveMiddleVoice</seealso>
    let ReflexiveMiddleVoice =
        Prefixed_Name(gold, "ReflexiveMiddleVoice") |> PrefixedName

    /// <summary>
    ///   <para>gold:ReflexivePassiveVoice</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A Passive construction which contains reflexive markings [Siewierska 1988: 257]."</para>
    /// labels<para>"ReflexivePassiveVoice"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/ReflexivePassiveVoice">http://purl.org/linguistics/gold/ReflexivePassiveVoice</seealso>
    let ReflexivePassiveVoice =
        Prefixed_Name(gold, "ReflexivePassiveVoice") |> PrefixedName

    /// <summary>
    ///   <para>gold:ReflexivePronoun</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A pronoun which is interpreted as coreferential with another nominal, usually the subject, of the sentence or clause in which it occurs. [Schachter 1985: 27]"</para>
    /// labels<para>"ReflexivePronoun"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/ReflexivePronoun">http://purl.org/linguistics/gold/ReflexivePronoun</seealso>
    let ReflexivePronoun = Prefixed_Name(gold, "ReflexivePronoun") |> PrefixedName
    /// <summary>
    ///   <para>gold:RelativeFutureTense</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"RelativeFutureTense locates the situation in question after a contextually determined temporal reference point, regardless of the latter's relation to the moment of utterance [Comrie 1985: 69-71]. Also called FuturePerfectTense."</para>
    /// labels<para>"RelativeFutureTense"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/RelativeFutureTense">http://purl.org/linguistics/gold/RelativeFutureTense</seealso>
    let RelativeFutureTense = Prefixed_Name(gold, "RelativeFutureTense") |> PrefixedName
    /// <summary>
    ///   <para>gold:RelativePastTense</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"RelativePastTense locates the situation in question before that of a contextually determined temporal reference point [Comrie 1985: 104]. Also called PastPerfectTense."</para>
    /// labels<para>"RelativePastTense"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/RelativePastTense">http://purl.org/linguistics/gold/RelativePastTense</seealso>
    let RelativePastTense = Prefixed_Name(gold, "RelativePastTense") |> PrefixedName

    /// <summary>
    ///   <para>gold:RelativePresentTense</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A tense that expresses that a situation is simultaneous with the time of some other post-present situation. [Hollebrandse, Holt and Vet 2005: 30]"</para>
    /// labels<para>"RelativePresentTense"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/RelativePresentTense">http://purl.org/linguistics/gold/RelativePresentTense</seealso>
    let RelativePresentTense =
        Prefixed_Name(gold, "RelativePresentTense") |> PrefixedName

    /// <summary>
    ///   <para>gold:RelativePronoun</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A relative pronoun is a pronoun that marks a relative clause, functions grammatically within the relative clause, and is coreferential to the word modified by the relative clause [Crystal 1997: 329]."</para>
    /// labels<para>"RelativePronoun"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/RelativePronoun">http://purl.org/linguistics/gold/RelativePronoun</seealso>
    let RelativePronoun = Prefixed_Name(gold, "RelativePronoun") |> PrefixedName
    /// <summary>
    ///   <para>gold:Relativizer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A relativizer is a subordinating connective that links a relative clause to its head  noun. It is distinguishable from a relative pronoun in that it does not have a nominal function within the relative clause. [Payne 1997: 332]"</para>
    /// labels<para>"Relativizer"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/Relativizer">http://purl.org/linguistics/gold/Relativizer</seealso>
    let Relativizer = Prefixed_Name(gold, "Relativizer") |> PrefixedName
    /// <summary>
    ///   <para>gold:RemoteFutureTense</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"RemoteFutureTense locates the situation in question at a time that is considered relatively distant. It is characteristically after the span of time culturally defined as 'tomorrow'. [Dahl 1985: 121; Comrie 1985: 94]"</para>
    /// labels<para>"RemoteFutureTense"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/RemoteFutureTense">http://purl.org/linguistics/gold/RemoteFutureTense</seealso>
    let RemoteFutureTense = Prefixed_Name(gold, "RemoteFutureTense") |> PrefixedName
    /// <summary>
    ///   <para>gold:RemotePastTense</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"RemotePastTense locates the situation in question prior to the present moment, usually more than a few days ago [Dahl 1985: 121; Comrie 1985: 88]. Subsumes notion of PreHesternalPast tense, which locates the situation in question before that of an opposing hesternal past tense [Bybee, Perkins, Pagliuca 1994: 98]."</para>
    /// labels<para>"RemotePastTense"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/RemotePastTense">http://purl.org/linguistics/gold/RemotePastTense</seealso>
    let RemotePastTense = Prefixed_Name(gold, "RemotePastTense") |> PrefixedName
    /// <summary>
    ///   <para>gold:Repetitive</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A derivational unit that derives transitives from other transitive or intransitive stems adding the meaning of repetition to the resulting form. [concept mentioned in Kibort 2008c: 9]"</para>
    /// labels<para>"Repetitive"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/Repetitive">http://purl.org/linguistics/gold/Repetitive</seealso>
    let Repetitive = Prefixed_Name(gold, "Repetitive") |> PrefixedName
    /// <summary>
    ///   <para>gold:Retracted</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A term used in phonetics to refer to the backwards movement of an articulator, especially the back of the tongue towards the velum.  Retracted sounds are heard in velarization, or the centralization of front vowels.  The tongue root may also be retracted. [Crystal 2008: 398]"</para>
    /// labels<para>"Retracted"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/Retracted">http://purl.org/linguistics/gold/Retracted</seealso>
    let Retracted = Prefixed_Name(gold, "Retracted") |> PrefixedName
    /// <summary>
    ///   <para>gold:RomanNumeralGender</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A convention for labeling gender values. Roman numerals are often used for languages for which there is a descriptive tradition involving use of the term 'noun class' instead of 'gender', in particular in languages of the Caucasus or Bantu languages, and are particularly useful where the number of genders is large.If the 'noun classes' are involved in agreement systems, they are gender systems. Roman numerals may also be used in instances where another label is possible. In one language the gender to which nouns with male rational denotation are assigned might be called 'masculine', whereas in another language nouns with a similar denotation may be assigned to a gender with an arbitrary Roman numerical label such as 'I'. [Kibort and Corbett 2008a]"</para>
    /// labels<para>"RomanNumeralGender"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/RomanNumeralGender">http://purl.org/linguistics/gold/RomanNumeralGender</seealso>
    let RomanNumeralGender = Prefixed_Name(gold, "RomanNumeralGender") |> PrefixedName
    /// <summary>
    ///   <para>gold:Root</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The base form of a word which cannot be further analyzed without total loss of identity. Roots may be free or bound morphemes and can be classified as simple (i.e. compositionally unanalyzable in terms of morphemes) or complex/compound (i.e. certain combinations of simple root forms), though for the latter, the term 'stem' is often used.  From a semantic point of view, the root generally carried the main component of meaning in a word. [Crystal 1997: 336]"</para>
    /// labels<para>"Root"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/Root">http://purl.org/linguistics/gold/Root</seealso>
    let Root = Prefixed_Name(gold, "Root") |> PrefixedName
    /// <summary>
    ///   <para>gold:SalienceProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Salience relates to the way in which certain actants present in a situation are seized on by humans as foci of attention, with attention being paid to less salient, less individuated objects subsequently [Comrie 1989: 199]. It has been argued that salience explains the evolution of certain syntactic changes, as well as the predominance of word orders where the subject precedes the object, due to the the salience of the agent in the agent-action-patient situation [Comrie 1989; Timberlake 1977]."</para>
    /// labels<para>"SalienceProperty"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/SalienceProperty">http://purl.org/linguistics/gold/SalienceProperty</seealso>
    let SalienceProperty = Prefixed_Name(gold, "SalienceProperty") |> PrefixedName

    /// <summary>
    ///   <para>gold:SecondHandEvidentiality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"SecondHandEvidentiality, also called the quotative, encodes the fact that the speaker came to believe the content of the expression from communicating with someone else [Palmer 2001: 40]."</para>
    /// labels<para>"SecondHandEvidentiality"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/SecondHandEvidentiality">http://purl.org/linguistics/gold/SecondHandEvidentiality</seealso>
    let SecondHandEvidentiality =
        Prefixed_Name(gold, "SecondHandEvidentiality") |> PrefixedName

    /// <summary>
    ///   <para>gold:SecondLanguageOnlyVariety</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"SecondLanguageOnlyVariant is a language variant that has no mother tongue speakers.  It is only spoken as a a second language. One example would be the case of Callawalla (caw), which is only learned in adolescence.  [Grimes 1992: 16]"</para>
    /// labels<para>"SecondLanguageOnlyVariety"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/SecondLanguageOnlyVariety">http://purl.org/linguistics/gold/SecondLanguageOnlyVariety</seealso>
    let SecondLanguageOnlyVariety =
        Prefixed_Name(gold, "SecondLanguageOnlyVariety") |> PrefixedName

    /// <summary>
    ///   <para>gold:SecondPerson</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"SecondPerson is a person property that refers minimally to the addressee [Crystal 1997: 285; Cysouw 2003: 75]."</para>
    /// labels<para>"SecondPerson"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/SecondPerson">http://purl.org/linguistics/gold/SecondPerson</seealso>
    let SecondPerson = Prefixed_Name(gold, "SecondPerson") |> PrefixedName
    /// <summary>
    ///   <para>gold:Segment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A discrete unit that can be identified in the stream of speech, either physically or auditorily. Features that extend over more than one segment, such as pitch or stress, are termed suprasegmentals. [Crystal 2003: 408–409; Hartmann"</para>
    /// labels<para>"Segment"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/Segment">http://purl.org/linguistics/gold/Segment</seealso>
    let Segment = Prefixed_Name(gold, "Segment") |> PrefixedName

    /// <summary>
    ///   <para>gold:SemanticAssignmentSystem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"For natural language understanding, the process of fine-grain semantic role assignment is one of the prominent steps, which provides semantic relations between constituents. The sense and sense relations between constituents provide the core meaning of a sentence. Abstract semantic roles include thematic roles, such as agent, theme, and instrument, and secondary roles such as location, time, and manner. [Chen and You 2004: 1]"</para>
    /// labels<para>"SemanticAssignmentSystem"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/SemanticAssignmentSystem">http://purl.org/linguistics/gold/SemanticAssignmentSystem</seealso>
    let SemanticAssignmentSystem =
        Prefixed_Name(gold, "SemanticAssignmentSystem") |> PrefixedName

    /// <summary>
    ///   <para>gold:SemanticInverseVoice</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"If the agent outranks the patient on the relevant generic topic hierarchy, the direct-active clause is used.  If the relevant norm is reversed and the patient outranks the agent on the relevant hierarchy, the inverse clause is used. [Givon 1994: 23]"</para>
    /// labels<para>"SemanticInverseVoice"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/SemanticInverseVoice">http://purl.org/linguistics/gold/SemanticInverseVoice</seealso>
    let SemanticInverseVoice =
        Prefixed_Name(gold, "SemanticInverseVoice") |> PrefixedName

    /// <summary>
    ///   <para>gold:SemanticProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The class of linguistic properties that pertain to semantic units. The units that underlie our intuitions about literal meaning and are associated with the grammatical structure of a language. [Frawley 1953: 12]"</para>
    ///   <para>"In componential analysis, one of several features which together can be said to make up the semantic meaning of a word or utterance.  Thus 'raining' could be analyzed into the component features 'precipitation', 'liquid' (not 'solid' as in 'hail'), 'average' (not 'light' as /drizzling/ or 'heavy' as /pouring/), etc. [...] Alternative terms: semantic feature, semantic [component], semantic marker. [Hartmann and Stork 1972: 203]"</para>
    /// labels<para>"SemanticProperty"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/SemanticProperty">http://purl.org/linguistics/gold/SemanticProperty</seealso>
    let SemanticProperty = Prefixed_Name(gold, "SemanticProperty") |> PrefixedName
    /// <summary>
    ///   <para>gold:SemanticUnit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A SemanticUnit is the class of semantics elements, or units of semantic structure (sometimes called a sememe). Semantic units serve as the meaning component of linguistic signs. A semantic unit is intended for linguistic description and no particular logical representation is implied."</para>
    /// labels<para>"SemanticUnit"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/SemanticUnit">http://purl.org/linguistics/gold/SemanticUnit</seealso>
    let SemanticUnit = Prefixed_Name(gold, "SemanticUnit") |> PrefixedName
    /// <summary>
    ///   <para>gold:SemelfactiveAspect</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Momentaneous, without an inherent end-point, as sneeze [Michaelis 1998: xvi]."</para>
    /// labels<para>"SemelfactiveAspect"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/SemelfactiveAspect">http://purl.org/linguistics/gold/SemelfactiveAspect</seealso>
    let SemelfactiveAspect = Prefixed_Name(gold, "SemelfactiveAspect") |> PrefixedName
    /// <summary>
    ///   <para>gold:SignedLanguage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"SignLanguage or SignSystem is referring to the system of manual communication used by certain groups as an alternative to oral communication. [Crystal 1997: 350]"</para>
    /// labels<para>"SignedLanguage"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/SignedLanguage">http://purl.org/linguistics/gold/SignedLanguage</seealso>
    let SignedLanguage = Prefixed_Name(gold, "SignedLanguage") |> PrefixedName

    /// <summary>
    ///   <para>gold:SignedLinguisticExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A SignedLinguisticExpression is the signed physical form of language as distinct from either written or spoken expressions. Signed expressions are the primary means in which sign languages are tranmitted. A signed expression is  the image sequence that is produced (and perceived) during a signing event."</para>
    /// labels<para>"SignedLinguisticExpression"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/SignedLinguisticExpression">http://purl.org/linguistics/gold/SignedLinguisticExpression</seealso>
    let SignedLinguisticExpression =
        Prefixed_Name(gold, "SignedLinguisticExpression") |> PrefixedName

    /// <summary>
    ///   <para>gold:SimpleFutureTense</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Future tense assigns a value to the designated element in the clause when the meaning selected for the clause is that intended to locate the event spoken about as posterior to the deictic centre of the utterance. Most commonly, this tense meaning is referred to as 'future', because in absolute tense systems the deictic centre is the moment of speech. However, in relative tense systems, where the deictic centre can be moved to any point on the time line, it is more appropriate to refer to this temporal relation as 'posterior'.
    ///
    /// The posterior temporal relation may obtain either in 'simple' or 'perfect' contexts. Modeling of this distinction originates from [Reichenbach 1947: 288], who suggested using a third point in time, 'reference point', to capture all possible tense distinctions. In all 'simple' temporal relations, the reference point coincides with the location of the event spoken about. [Kibort 2008c: 5]"</para>
    /// labels<para>"SimpleFutureTense"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/SimpleFutureTense">http://purl.org/linguistics/gold/SimpleFutureTense</seealso>
    let SimpleFutureTense = Prefixed_Name(gold, "SimpleFutureTense") |> PrefixedName
    /// <summary>
    ///   <para>gold:SimplePastTense</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Past tense assigns a value to the designated element in the clause when the meaning selected for the clause is that intended to locate the event spoken about as anterior to the deictic centre of the utterance. Most commonly, this tense meaning is referred to as 'past', because in absolute tense systems the deictic centre is the moment of speech. However, in relative tense systems, where the deictic centre can be moved to any point on the time line, it is more appropriate to refer to this temporal relation as 'anterior'.
    ///
    /// The anterior temporal relation may obtain either in 'simple' or 'perfect' contexts. Modeling of this distinction originates from [Reichenbach  1947: 288], who suggested using a third point in time, 'reference point', to capture all possible tense distinctions. In all 'simple' temporal relations, the reference point coincides with the location of the event spoken about . [Kibort 2008c: 4]"</para>
    /// labels<para>"SimplePastTense"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/SimplePastTense">http://purl.org/linguistics/gold/SimplePastTense</seealso>
    let SimplePastTense = Prefixed_Name(gold, "SimplePastTense") |> PrefixedName
    /// <summary>
    ///   <para>gold:SimplePresentTense</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Present tense assigns a value to the designated element in the clause when the meaning selected for the clause is that intended to locate the event spoken about as simultaneous to the deictic centre of the utterance.
    ///
    /// The simultaneous temporal relation may obtain either in 'simple' or 'perfect' contexts.  Modelling of this distinction originates from [Reichenbach  1947: 288], who suggested using a third point in time, 'reference point', to capture all possible tense distinctions. In all 'simple' temporal relations, the reference point coincides with the location of the event spoken about. [Kibort 2008c: 4-5]"</para>
    /// labels<para>"SimplePresentTense"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/SimplePresentTense">http://purl.org/linguistics/gold/SimplePresentTense</seealso>
    let SimplePresentTense = Prefixed_Name(gold, "SimplePresentTense") |> PrefixedName
    /// <summary>
    ///   <para>gold:SimpleSpecification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A SimpleSpecification is a kind of FeatureSpecification whose value must be a simple linguistic attribute [Maxwell, Simons and Hayashi 2000]."</para>
    /// labels<para>"SimpleSpecification"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/SimpleSpecification">http://purl.org/linguistics/gold/SimpleSpecification</seealso>
    let SimpleSpecification = Prefixed_Name(gold, "SimpleSpecification") |> PrefixedName
    /// <summary>
    ///   <para>gold:SimultaneousAspect</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A temporal relation in which the events or states of proposition(s) are communicated as occurring at the same time. [SIL International 2004]"</para>
    /// labels<para>"SimultaneousAspect"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/SimultaneousAspect">http://purl.org/linguistics/gold/SimultaneousAspect</seealso>
    let SimultaneousAspect = Prefixed_Name(gold, "SimultaneousAspect") |> PrefixedName
    /// <summary>
    ///   <para>gold:SingularNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Singular refers to one member of a designated class [Crystal 1980: 245; Hartmann and Stork 1972: 210]."</para>
    /// labels<para>"SingularNumber"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/SingularNumber">http://purl.org/linguistics/gold/SingularNumber</seealso>
    let SingularNumber = Prefixed_Name(gold, "SingularNumber") |> PrefixedName
    /// <summary>
    ///   <para>gold:SizeProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"SizeProperty is a physical property with two values: large and small. Languages apparently do not encode a middle value of medium, at least not in the grammar. The marking of large size is traditionally called the augmentativem that for small size the diminutive. [Frawley 1992: 126]"</para>
    /// labels<para>"SizeProperty"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/SizeProperty">http://purl.org/linguistics/gold/SizeProperty</seealso>
    let SizeProperty = Prefixed_Name(gold, "SizeProperty") |> PrefixedName
    /// <summary>
    ///   <para>gold:SpeculativeForce</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"SpeculativeForce indicates that the speaker considers, or 'entertains', the content of the expression. That is, it is in the realm of possibility, though the speaker does not necessarilty believe it. [Palmer 2001: 6-8, 25]"</para>
    /// labels<para>"SpeculativeForce"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/SpeculativeForce">http://purl.org/linguistics/gold/SpeculativeForce</seealso>
    let SpeculativeForce = Prefixed_Name(gold, "SpeculativeForce") |> PrefixedName
    /// <summary>
    ///   <para>gold:SpokenLanguage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"One of the modes of linguistic communication. As distinct from written language, it is characterized by repetition, hesitation forms, pauses, variations in articulation, lapses, as well as differences in vocabulary and grammar.  The primary importance spoken language in the analysis, description and teaching of languages has been stressed frequently. Alternative terms: speech, conversation. [Hartmann and Stork 1972: 217]"</para>
    /// labels<para>"SpokenLanguage"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/SpokenLanguage">http://purl.org/linguistics/gold/SpokenLanguage</seealso>
    let SpokenLanguage = Prefixed_Name(gold, "SpokenLanguage") |> PrefixedName

    /// <summary>
    ///   <para>gold:SpokenLinguisticExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A SpokenLinguisticExpression is the physical sound form of language as distinct from either signed or spoken expressions. A spoken expression is the sound that is produced (and perceived) during a speaking event."</para>
    /// labels<para>"SpokenLinguisticExpression"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/SpokenLinguisticExpression">http://purl.org/linguistics/gold/SpokenLinguisticExpression</seealso>
    let SpokenLinguisticExpression =
        Prefixed_Name(gold, "SpokenLinguisticExpression") |> PrefixedName

    /// <summary>
    ///   <para>gold:Stem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Stem is the class of  morphological units that are analyzable into a root and possibly one or more derivational units. Stems can occur alone and are the basis for adding inflectional units. [Lyons 1977: 513, 521-526]"</para>
    /// labels<para>"Stem"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/Stem">http://purl.org/linguistics/gold/Stem</seealso>
    let Stem = Prefixed_Name(gold, "Stem") |> PrefixedName
    /// <summary>
    ///   <para>gold:StillTense</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"StillPresentTense is similar to PresentTense but carries the presupposition that an event or state held before the moment of utterance. In positive declarative clauses, still present tense asserts that the event or state holds at the moment of utterance [Comrie 1985, 54]."</para>
    /// labels<para>"StillTense"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/StillTense">http://purl.org/linguistics/gold/StillTense</seealso>
    let StillTense = Prefixed_Name(gold, "StillTense") |> PrefixedName
    /// <summary>
    ///   <para>gold:Stop</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A term used in the phonetic classification of speech sounds on the basis of their manner of articulation.  It refers to any sound which is produced by a complete closure in the vocal tract.  [Crystal 2008: 453]"</para>
    /// labels<para>"Stop"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/Stop">http://purl.org/linguistics/gold/Stop</seealso>
    let Stop = Prefixed_Name(gold, "Stop") |> PrefixedName
    /// <summary>
    ///   <para>gold:StrictureProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A general term used in Phonetics to refer to an articulation which restricts the airstream to some degree, ranging from a complete closure to a slight narrowing. [Crystal 2008: 456]"</para>
    /// labels<para>"StrictureProperty"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/StrictureProperty">http://purl.org/linguistics/gold/StrictureProperty</seealso>
    let StrictureProperty = Prefixed_Name(gold, "StrictureProperty") |> PrefixedName

    /// <summary>
    ///   <para>gold:StructuralDescription</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A term used in (esp. classical) transformational grammar to refer to an analysis of a terminal string in terms of a labeled bracketing.  In transformational analysis, the SD identifies the input to a transformational rule: it specifies which phrase-markers are to be affected by the rule.  i.e. which will 'satisfy' or 'meet' the conditions of the rule. The terms structural analysis and structure index are also used. [Crystal 2008: 458]"</para>
    /// labels<para>"StructuralDescription"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/StructuralDescription">http://purl.org/linguistics/gold/StructuralDescription</seealso>
    let StructuralDescription =
        Prefixed_Name(gold, "StructuralDescription") |> PrefixedName

    /// <summary>
    ///   <para>gold:SubablativeCase</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"SubablativeCase expresses that the referent of the noun it marks is the location from under which another referent is moving. It has the meaning 'from under'. Kibrik says that Archi (aqc) possesses a nominal spatial form expressing SubablativeCase, namely -L´aš [Kibrik 1998: 470]."</para>
    /// labels<para>"SubablativeCase"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/SubablativeCase">http://purl.org/linguistics/gold/SubablativeCase</seealso>
    let SubablativeCase = Prefixed_Name(gold, "SubablativeCase") |> PrefixedName
    /// <summary>
    ///   <para>gold:SuballativeCase</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"SuballativeCase expresses that  something is moving toward the region that is under the referent of the noun it marks. It has the meaning 'towards the region that is under'. Kibrik says that Archi (aqc) possesses a nominal spatial form expressing SuballativeCase, namely -L´aši [Kibrik 1998: 470]."</para>
    /// labels<para>"SuballativeCase"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/SuballativeCase">http://purl.org/linguistics/gold/SuballativeCase</seealso>
    let SuballativeCase = Prefixed_Name(gold, "SuballativeCase") |> PrefixedName
    /// <summary>
    ///   <para>gold:SubessiveCase</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"SubessiveCase expresses that the referent of the noun it marks is the location under which another referent exists. It has the meaning of 'under' or 'beneath'. Kibrik says that Archi (aqc) possesses a nominal spatial form expressing SubessiveCase, namely -L´ [Kibrik 1998: 470]."</para>
    /// labels<para>"SubessiveCase"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/SubessiveCase">http://purl.org/linguistics/gold/SubessiveCase</seealso>
    let SubessiveCase = Prefixed_Name(gold, "SubessiveCase") |> PrefixedName
    /// <summary>
    ///   <para>gold:SubjunctiveMood</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"SubjunctiveMood is used to express '"states of affairs" whose occurrence could easily be denied or affirmed, but instead is left unasserted.' [Lavandera 1983: 211]"</para>
    /// labels<para>"SubjunctiveMood"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/SubjunctiveMood">http://purl.org/linguistics/gold/SubjunctiveMood</seealso>
    let SubjunctiveMood = Prefixed_Name(gold, "SubjunctiveMood") |> PrefixedName
    /// <summary>
    ///   <para>gold:Sublaminal</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Characterizing sounds produced by the underside of the tip of the tongue  [Ladefoged 1997: 596]."</para>
    /// labels<para>"Sublaminal"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/Sublaminal">http://purl.org/linguistics/gold/Sublaminal</seealso>
    let Sublaminal = Prefixed_Name(gold, "Sublaminal") |> PrefixedName
    /// <summary>
    ///   <para>gold:SublativeCase</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"In certain languages (notably, languages of the Finno-Urgic family), a declensional case having the same denotation as in English the use of the contruction "from below" before a substantive. [Pei and Gaynor 1980: 203-204] Kibrik says that Archi (aqc) possesses a nominal spatial form expressing SublativeCase, namely -L´ak [Kibrik 1998: 470]."</para>
    /// labels<para>"SublativeCase"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/SublativeCase">http://purl.org/linguistics/gold/SublativeCase</seealso>
    let SublativeCase = Prefixed_Name(gold, "SublativeCase") |> PrefixedName
    /// <summary>
    ///   <para>gold:SubordinateClause</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A clause which does not constitute a complete sentence in itself, but must be connected with or attached to an independent clause. [Pei and Gaynor 1980: 206]"</para>
    /// labels<para>"SubordinateClause"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/SubordinateClause">http://purl.org/linguistics/gold/SubordinateClause</seealso>
    let SubordinateClause = Prefixed_Name(gold, "SubordinateClause") |> PrefixedName

    /// <summary>
    ///   <para>gold:SubordinatingConnective</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A subordinating connective is a connective that links constructions by making one of them a constituent of another. The subordinating conjunction typically marks the incorporated constituent. [Crystal 1997: 370]"</para>
    /// labels<para>"SubordinatingConnective"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/SubordinatingConnective">http://purl.org/linguistics/gold/SubordinatingConnective</seealso>
    let SubordinatingConnective =
        Prefixed_Name(gold, "SubordinatingConnective") |> PrefixedName

    /// <summary>
    ///   <para>gold:Substantive</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A substantive is a member of the syntactic class in which the names of physical, concrete, relatively unchanging experiences are most typically found whose members may act as subjects and  objects, and most of whose members have inherently determined grammatical  gender (in languages which inflect for gender) [Crystal 1997: 264; Givon 1984: 51-52; Payne 1997: 33]."</para>
    /// labels<para>"Substantive"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/Substantive">http://purl.org/linguistics/gold/Substantive</seealso>
    let Substantive = Prefixed_Name(gold, "Substantive") |> PrefixedName
    /// <summary>
    ///   <para>gold:SubterminativeCase</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"SubterminativeCase expresses the notion of something moving into the region under the referent of the noun it marks, but not through that region. It has the meaning 'into the region under'. Kibrik says that Archi (aqc) possesses a nominal spatial form expressing SubterminativeCase, namely -L´akana [Kibrik 1998: 470]."</para>
    /// labels<para>"SubterminativeCase"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/SubterminativeCase">http://purl.org/linguistics/gold/SubterminativeCase</seealso>
    let SubterminativeCase = Prefixed_Name(gold, "SubterminativeCase") |> PrefixedName
    /// <summary>
    ///   <para>gold:SubtranslativeCase</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"SubtranslativeCase expresses the notion of something moving along a trajectory underneath the referent of the noun it marks. It has the meaning 'along the region underneath'. Kibrik says that Archi (aqc) possesses a nominal spatial form expressing SubtranslativeCase, namely -L´aXut [Kibrik 1998: 470]."</para>
    /// labels<para>"SubtranslativeCase"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/SubtranslativeCase">http://purl.org/linguistics/gold/SubtranslativeCase</seealso>
    let SubtranslativeCase = Prefixed_Name(gold, "SubtranslativeCase") |> PrefixedName
    /// <summary>
    ///   <para>gold:Suffix</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An affix, consisting of a letter, syllable, or syllables, that follows a stem or word, modifying its meaning. Suffixes may be inflectional or derivational. [Crystal 1987: 431; Hartmann and Stork 1972: 225; Pei and Gaynor 1980: 207]"</para>
    /// labels<para>"Suffix"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/Suffix">http://purl.org/linguistics/gold/Suffix</seealso>
    let Suffix = Prefixed_Name(gold, "Suffix") |> PrefixedName
    /// <summary>
    ///   <para>gold:SuperablativeCase</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Superablative expresses that  the referent of the noun it marks is at the location from over which another referent is moving. It has the meaning 'from over'. Kibrik says that Archi (aqc) possesses a nominal spatial form expressing SuperablativeCase, namely -t:iš. He gives the example 'aInš-li-t:-iš' ('aIns' = 'apple'). [Kibrik 1998: 470-471]"</para>
    /// labels<para>"SuperablativeCase"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/SuperablativeCase">http://purl.org/linguistics/gold/SuperablativeCase</seealso>
    let SuperablativeCase = Prefixed_Name(gold, "SuperablativeCase") |> PrefixedName
    /// <summary>
    ///   <para>gold:SuperallativeCase</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"SuperallativeCase expresses that something is moving toward the region that is above the referent of the noun it marks. It has the meaning 'towards the region that is over'. Kibrik says that Archi (aqc) possesses a nominal spatial form expressing SuperallativeCase, namely -t:iši [Kibrik 1998: 470]."</para>
    /// labels<para>"SuperallativeCase"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/SuperallativeCase">http://purl.org/linguistics/gold/SuperallativeCase</seealso>
    let SuperallativeCase = Prefixed_Name(gold, "SuperallativeCase") |> PrefixedName
    /// <summary>
    ///   <para>gold:SuperessiveCase</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"SuperessiveCase expresses that  the referent of the noun it marks is the location on which another referent exists. It has the meaning of 'on' or 'upon'. [Pei and Gaynor 1954: 207] Kibrik says that Archi (aqc) possesses a nominal spatial form expressing SuperessiveCase, namely -t. He gives the example 'aInš-li-t' ('aIns' = 'apple'). [Kibrik 1998: 470-471]"</para>
    /// labels<para>"SuperessiveCase"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/SuperessiveCase">http://purl.org/linguistics/gold/SuperessiveCase</seealso>
    let SuperessiveCase = Prefixed_Name(gold, "SuperessiveCase") |> PrefixedName

    /// <summary>
    ///   <para>gold:SuperlativeAdjective</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"That form of an adjective that expresses that the thing to which it refers possesses a certain quality or attribute to a greater extent than any other thing [Hartmann and Stork 1972: 60; Pei and Gaynor 1980: 207]."</para>
    /// labels<para>"SuperlativeAdjective"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/SuperlativeAdjective">http://purl.org/linguistics/gold/SuperlativeAdjective</seealso>
    let SuperlativeAdjective =
        Prefixed_Name(gold, "SuperlativeAdjective") |> PrefixedName

    /// <summary>
    ///   <para>gold:SuperlativeCase</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"SuperlativeCase expresses that  the referent of the noun it marks is the location onto which another referent is moving. It has the meaning of 'onto'. Kibrik says that Archi (aqc) possesses a nominal spatial form expressing SuperlativeCase, namely -t:ik. He gives the example 'aInš-li-t:-ik' ('aIns' = 'apple'). [Kibrik 1998: 470-471] Unfortunate name clash with 'Superlative' as a property of adjectives."</para>
    /// labels<para>"SuperlativeCase"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/SuperlativeCase">http://purl.org/linguistics/gold/SuperlativeCase</seealso>
    let SuperlativeCase = Prefixed_Name(gold, "SuperlativeCase") |> PrefixedName

    /// <summary>
    ///   <para>gold:SuperterminativeCase</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"SuperterminativeCase expresses the notion of something moving into the region over the referent of the noun it marks, but not through that region. It has the meaning 'into the region over'. Kibrik says that Archi (aqc) possesses a nominal spatial form expressing SuperterminativeCase, namely -t:ikana [Kibrik 1998: 470]."</para>
    /// labels<para>"SuperterminativeCase"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/SuperterminativeCase">http://purl.org/linguistics/gold/SuperterminativeCase</seealso>
    let SuperterminativeCase =
        Prefixed_Name(gold, "SuperterminativeCase") |> PrefixedName

    /// <summary>
    ///   <para>gold:SupertranslativeCase</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"SupertranslativeCase expresses the notion of something moving along a trajectory above the referent of the noun it marks. It has the meaning 'along the region over'. Kibrik says that Archi (aqc) possesses a nominal spatial form expressing SupertranslativeCase, namely -t:iXut [Kibrik 1998: 470]."</para>
    /// labels<para>"SupertranslativeCase"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/SupertranslativeCase">http://purl.org/linguistics/gold/SupertranslativeCase</seealso>
    let SupertranslativeCase =
        Prefixed_Name(gold, "SupertranslativeCase") |> PrefixedName

    /// <summary>
    ///   <para>gold:SupraLaryngealProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The supralaryngeal node dominates the activity of all of the articulators except stiffening and slacking of the vocal folds. For consonants it can be viewed as the default node which comes into play when the supranasal node below it is deactivated. In the case of sounds produced by an articulator dominated by this node, the only possible segments are those which are traditionally classified as [-consonantal]. It is not necessary to specify manner features for sounds dominated by the supralaryngeal node, because they are redundantly determined. [Keyser and Stevens 1994: 216]"</para>
    /// labels<para>"SupraLaryngealProperty"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/SupraLaryngealProperty">http://purl.org/linguistics/gold/SupraLaryngealProperty</seealso>
    let SupraLaryngealProperty =
        Prefixed_Name(gold, "SupraLaryngealProperty") |> PrefixedName

    /// <summary>
    ///   <para>gold:Suprasegmental</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Phonetic features extending over more than one segment, such as stress, length, tone, and intonation, which are not properties of single consonants or vowels [Crystal 1987: 431; Ladefoged 2000: 276]."</para>
    /// labels<para>"Suprasegmental"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/Suprasegmental">http://purl.org/linguistics/gold/Suprasegmental</seealso>
    let Suprasegmental = Prefixed_Name(gold, "Suprasegmental") |> PrefixedName
    /// <summary>
    ///   <para>gold:Syllable</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Ladefoged contends that there is no satisfactory definition for this unit of speech, but that syllables seem to be necessary units in the mental organization and production of utterances. However, Crystal defines the syllable as an element of speech that acts as a unit of rhythm, consisting of a vowel, syllabic, or vowel/consonant combination. [Crystal 1987: 431; Ladefoged 2000: 276]"</para>
    /// labels<para>"Syllable"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/Syllable">http://purl.org/linguistics/gold/Syllable</seealso>
    let Syllable = Prefixed_Name(gold, "Syllable") |> PrefixedName
    /// <summary>
    ///   <para>gold:SymmetricProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Properties may be stated to be symmetric. If a property is symmetric, then if the pair (x,y) is an instance of the symmetric property P, then the pair (y,x) is also an instance of P. For example, friend may be stated to be a symmetric property. Then a reasoner that is given that Frank is a friend of Deborah can deduce that Deborah is a friend of Frank. [McGuinness"</para>
    /// labels<para>"SymmetricProperty"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/SymmetricProperty">http://purl.org/linguistics/gold/SymmetricProperty</seealso>
    let SymmetricProperty = Prefixed_Name(gold, "SymmetricProperty") |> PrefixedName
    /// <summary>
    ///   <para>gold:SyntacticArgument</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"SyntacticArgument is the class of syntactic words that are fundamentally referable and  non-relational [Anderson 1997: 15]. Proper names are the quintessential arguments, though pronouns and nouns possess argument properties."</para>
    /// labels<para>"SyntacticArgument"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/SyntacticArgument">http://purl.org/linguistics/gold/SyntacticArgument</seealso>
    let SyntacticArgument = Prefixed_Name(gold, "SyntacticArgument") |> PrefixedName

    /// <summary>
    ///   <para>gold:SyntacticConstruction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"SyntacticConstruction is the class of grammar units that have syntactic structure, i.e., consisting of more than one syntactic word or construction in a syntactic configuration [Crystal 1980: 85-86]."</para>
    /// labels<para>"SyntacticConstruction"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/SyntacticConstruction">http://purl.org/linguistics/gold/SyntacticConstruction</seealso>
    let SyntacticConstruction =
        Prefixed_Name(gold, "SyntacticConstruction") |> PrefixedName

    /// <summary>
    ///   <para>gold:SyntacticUnit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"SyntacticUnit (also called constituent) is a 'term in grammatical analysis for a linguistic unit which is a functional component of a larger construction. Based on a combination of intuitive and formal (e.g. distributional) criteria, a sentence can be analysed into a series of constituents, such as subject + predicate, or NP+VP, etc. [Crystal 2003: 99]"</para>
    /// labels<para>"SyntacticUnit"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/SyntacticUnit">http://purl.org/linguistics/gold/SyntacticUnit</seealso>
    let SyntacticUnit = Prefixed_Name(gold, "SyntacticUnit") |> PrefixedName
    /// <summary>
    ///   <para>gold:SyntacticWord</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"It can be moved about in the sentence, or at least its position relative to other constituents can be altered by inserting new material.  It cannot be interrupted or its parts reordered. [Cruse 2000: 87-88]"</para>
    ///   <para>"SyntacticWord is the class of syntactic units occupying the lowest position in a syntactic construction.  They are the largest units resistant to insertion of new constituents within their boundaries; or they are the smallest constituents that can be moved within a sentence without making the sentence ungrammatical. [SIL International 2004]"</para>
    /// labels<para>"SyntacticWord"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/SyntacticWord">http://purl.org/linguistics/gold/SyntacticWord</seealso>
    let SyntacticWord = Prefixed_Name(gold, "SyntacticWord") |> PrefixedName
    /// <summary>
    ///   <para>gold:Tap</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A Tap 'is a sound in which a brief contact between the articulators is made by moving the active articulator directly towards the roof of the mouth.' A tap is 'usually coronal. ... Taps are most typically made by a direct movement of the tongue tip to a contact location in the dental or alveolar region.' [Ladefoged 1996: 231]"</para>
    /// labels<para>"Tap"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/Tap">http://purl.org/linguistics/gold/Tap</seealso>
    let Tap = Prefixed_Name(gold, "Tap") |> PrefixedName
    /// <summary>
    ///   <para>gold:Taxon</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Taxon is the class of scientific categories used to create a taxonomy and determined according to scientific principles in a given domain, e.g., Biology or Linguistics."</para>
    /// labels<para>"Taxon"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/Taxon">http://purl.org/linguistics/gold/Taxon</seealso>
    let Taxon = Prefixed_Name(gold, "Taxon") |> PrefixedName
    /// <summary>
    ///   <para>gold:TenseProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Following [Comrie 1985: vii], we take tense to be the grammaticalisation of location in time. Tense Property is assigned to clauses on the basis of semantics: a tense value is selected for the clause from the range of tense values available in the given language. Tense Property is typically realised on the verb, but it may be found expressed multiply on different elements in the same clause. For example, tense may be found on more than one element of the verbal complex (e.g. in Kayardild [Evans 2003] or  Paamese [Crowley 2002: 68], or on verbs as well as on certain spatial and temporal adverbs and certain prepositions in the same clause (e.g. in Malagasy [Randriamasimanana 1981: 355-367],  [Keenan and Polinsky 1998: 566-567].
    ///
    /// In the given language, the values of the Tense Property are assigned to the designated elements as a consequence of semantic choice, and all the available options of particular tense values expressing particular tense meanings can be described with a Tense Assignment System for that language. Since no languages have been found for which tense values are assigned by a Tense Distribution System (i.e. contextually, through agreement or government), Tense Property is not a Morphosyntactic Property. Instead, it is a Morphosemantic Property only."</para>
    /// labels<para>"TenseProperty"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/TenseProperty">http://purl.org/linguistics/gold/TenseProperty</seealso>
    let TenseProperty = Prefixed_Name(gold, "TenseProperty") |> PrefixedName
    /// <summary>
    ///   <para>gold:Term</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A vocabulary item which has a special meaning in a particular subject field, e.g. 'sound' or 'voice' in phonetics, or 'butterfly' in swimming. [Hartmann and Stork 1972: 236]"</para>
    /// labels<para>"Term"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/Term">http://purl.org/linguistics/gold/Term</seealso>
    let Term = Prefixed_Name(gold, "Term") |> PrefixedName
    /// <summary>
    ///   <para>gold:TerminativeAspect</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Denotes the termination of an event [Bhat 1999: 92]."</para>
    /// labels<para>"TerminativeAspect"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/TerminativeAspect">http://purl.org/linguistics/gold/TerminativeAspect</seealso>
    let TerminativeAspect = Prefixed_Name(gold, "TerminativeAspect") |> PrefixedName
    /// <summary>
    ///   <para>gold:TerminativeCase</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Cases expressing spatial relations (also semantic) can be grouped into four broad directional classes: cases expressing location ('at'), goal ('to'), source ('from'), and path ('through, along'). The basic terms for these are: locative, allative, ablative, and perlative. Additionally, the label terminative is used for a movement that goes all the way to its endpoint, and orientative - for a movement that goes only in the direction of its goal. [Kibort 2008b]"</para>
    /// labels<para>"TerminativeCase"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/TerminativeCase">http://purl.org/linguistics/gold/TerminativeCase</seealso>
    let TerminativeCase = Prefixed_Name(gold, "TerminativeCase") |> PrefixedName
    /// <summary>
    ///   <para>gold:Termset</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A set of scientific terms used as part of an annotation system, usually the standard terms from a particular linguistic theory."</para>
    /// labels<para>"Termset"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/Termset">http://purl.org/linguistics/gold/Termset</seealso>
    let Termset = Prefixed_Name(gold, "Termset") |> PrefixedName
    /// <summary>
    ///   <para>gold:TertiaryPredicator</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"TertiaryPredicator is the class of syntactic words that take three required arguments."</para>
    /// labels<para>"TertiaryPredicator"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/TertiaryPredicator">http://purl.org/linguistics/gold/TertiaryPredicator</seealso>
    let TertiaryPredicator = Prefixed_Name(gold, "TertiaryPredicator") |> PrefixedName
    /// <summary>
    ///   <para>gold:Thing</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"In Web Ontology Language, Thing is the superclass of all classes. The most basic concepts in a domain should correspond to classes that are the roots of various taxonomic trees. Every individual in the OWL world is a member of the class owl:Thing. Thus each user-defined class is implicitly a subclass of owl:Thing. Domain specific root classes are defined by simply declaring a named class. [Smith, Welty and McGuinness 2004]"</para>
    /// labels<para>"Thing"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/Thing">http://purl.org/linguistics/gold/Thing</seealso>
    let Thing = Prefixed_Name(gold, "Thing") |> PrefixedName
    /// <summary>
    ///   <para>gold:ThirdPerson</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Third Person is a person property that refers to the non-participant (other than the speaker and the addressee) [Crystal 1997: 285]."</para>
    /// labels<para>"ThirdPerson"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/ThirdPerson">http://purl.org/linguistics/gold/ThirdPerson</seealso>
    let ThirdPerson = Prefixed_Name(gold, "ThirdPerson") |> PrefixedName

    /// <summary>
    ///   <para>gold:ThirdPersonObviative</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"ThirdPersonObviative is a person property that  refers to one or more non-participants that are in some way further removed from the speaker than other non-particpants. Contrasts with ThirdPersonProximative. [Kibort 2008a]"</para>
    /// labels<para>"ThirdPersonObviative"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/ThirdPersonObviative">http://purl.org/linguistics/gold/ThirdPersonObviative</seealso>
    let ThirdPersonObviative =
        Prefixed_Name(gold, "ThirdPersonObviative") |> PrefixedName

    /// <summary>
    ///   <para>gold:ThirdPersonProximative</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Refers to one or more non-participants that are in some way distinct/closer to the speaker than other non-participants. Third person proximative contrasts with third person obviative. Often called 'Third Person Proximate' or '4th person'. [Kibort 2008a]"</para>
    /// labels<para>"ThirdPersonProximative"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/ThirdPersonProximative">http://purl.org/linguistics/gold/ThirdPersonProximative</seealso>
    let ThirdPersonProximative =
        Prefixed_Name(gold, "ThirdPersonProximative") |> PrefixedName

    /// <summary>
    ///   <para>gold:TimitiveMood</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"TimitiveMood encodes that the speaker fears something expressed in what is said [Palmer 2001: 13, 22]."</para>
    /// labels<para>"TimitiveMood"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/TimitiveMood">http://purl.org/linguistics/gold/TimitiveMood</seealso>
    let TimitiveMood = Prefixed_Name(gold, "TimitiveMood") |> PrefixedName
    /// <summary>
    ///   <para>gold:Toneme</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A stress or tonal element which in a tone language distinguishes two otherwise identical words or forms. [Hartmann and Stork 1972: 238; Pei and Gaynor 1980: 218]"</para>
    /// labels<para>"Toneme"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/Toneme">http://purl.org/linguistics/gold/Toneme</seealso>
    let Toneme = Prefixed_Name(gold, "Toneme") |> PrefixedName
    /// <summary>
    ///   <para>gold:TransitiveProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Those grammatical features which are used systematically to express certain relationships between the participants in a communicative situation and the actions, states, or circumstances in which they are involved [Hartmann"</para>
    /// labels<para>"TransitiveProperty"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/TransitiveProperty">http://purl.org/linguistics/gold/TransitiveProperty</seealso>
    let TransitiveProperty = Prefixed_Name(gold, "TransitiveProperty") |> PrefixedName
    /// <summary>
    ///   <para>gold:TransitiveVerb</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A transitive verb is a verb that takes a direct object, and describes a relation between two participants [Crystal 1997: 397; Payne 1997: 171]."</para>
    /// labels<para>"TransitiveVerb"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/TransitiveVerb">http://purl.org/linguistics/gold/TransitiveVerb</seealso>
    let TransitiveVerb = Prefixed_Name(gold, "TransitiveVerb") |> PrefixedName
    /// <summary>
    ///   <para>gold:Transitivizer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A derivational unit that derives transitive verbs from intransitive verb (stems)."</para>
    /// labels<para>"Transitivizer"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/Transitivizer">http://purl.org/linguistics/gold/Transitivizer</seealso>
    let Transitivizer = Prefixed_Name(gold, "Transitivizer") |> PrefixedName
    /// <summary>
    ///   <para>gold:TranslativeCase</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"TranslativeCase expresses that the referent of the noun, or the quality of the adjective, that it marks is the result of a process of change [Lyons 1968: 299-301; Sebeok 1946: 17; Hakulinen 1961: 70]. X along, across Y."</para>
    /// labels<para>"TranslativeCase"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/TranslativeCase">http://purl.org/linguistics/gold/TranslativeCase</seealso>
    let TranslativeCase = Prefixed_Name(gold, "TranslativeCase") |> PrefixedName
    /// <summary>
    ///   <para>gold:TrialNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The trial is for referring to three distinct real world entities. [Corbett 2000: 21]"</para>
    /// labels<para>"TrialNumber"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/TrialNumber">http://purl.org/linguistics/gold/TrialNumber</seealso>
    let TrialNumber = Prefixed_Name(gold, "TrialNumber") |> PrefixedName
    /// <summary>
    ///   <para>gold:Trill</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The vibration of one speech organ against another, driven by the aerodynamic conditions. One of the soft moveable parts of the vocal tract is placed close enough to another surface, so that when a current of air of the right strength passes through the aperture created by this configuration, a repeating pattern of closing and opening of the flow channel occurs. [Ladefoged and Maddieson 1996: 217]"</para>
    /// labels<para>"Trill"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/Trill">http://purl.org/linguistics/gold/Trill</seealso>
    let Trill = Prefixed_Name(gold, "Trill") |> PrefixedName
    /// <summary>
    ///   <para>gold:TrillProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A term in the phonetic classification of consonant sounds on the basis of their manner of articulation: also known as trilled consonant, or a roll, 'trill' refers to any sound made by the rapid tapping of one organ of articulation against another. [Crystal 2008: 496]"</para>
    /// labels<para>"TrillProperty"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/TrillProperty">http://purl.org/linguistics/gold/TrillProperty</seealso>
    let TrillProperty = Prefixed_Name(gold, "TrillProperty") |> PrefixedName
    /// <summary>
    ///   <para>gold:UnaryPredicator</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"UnaryPredicator is the class of syntactic words that take only one required argument."</para>
    /// labels<para>"UnaryPredicator"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/UnaryPredicator">http://purl.org/linguistics/gold/UnaryPredicator</seealso>
    let UnaryPredicator = Prefixed_Name(gold, "UnaryPredicator") |> PrefixedName
    /// <summary>
    ///   <para>gold:Unaspirated</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Unaspirated refers to the configuration of glottal opening, release at the oral stricture, and vocal fold vibration in which the glottal opening gesture begins at the moment that the oral closure is made, but the maximum width of the glottal opening is reached at about the mid-point of the oral closure duration and the vocal folds return to a voicing position at about the moment of release. This typically results in a weak sounding release which lacks the burst of air characteristic of aspirated phonemes. [Ladefoged and Maddieson 1996: 66-70]"</para>
    /// labels<para>"Unaspirated"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/Unaspirated">http://purl.org/linguistics/gold/Unaspirated</seealso>
    let Unaspirated = Prefixed_Name(gold, "Unaspirated") |> PrefixedName
    /// <summary>
    ///   <para>gold:UnattestedVariety</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"UnattestedVariety is the class of language varieties that are posited to exist or to have existed. Examples include reconstructed languages, such as Proto-Indo-European."</para>
    /// labels<para>"UnattestedVariety"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/UnattestedVariety">http://purl.org/linguistics/gold/UnattestedVariety</seealso>
    let UnattestedVariety = Prefixed_Name(gold, "UnattestedVariety") |> PrefixedName
    /// <summary>
    ///   <para>gold:VegetableGender</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Vegetable gender refers to inanimates and exists in some four-way gender systems, e.g., masculine, feminine, neuter, and vegetable as in Bininj Gun-wok [Evans 2003: 202]."</para>
    /// labels<para>"VegetableGender"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/VegetableGender">http://purl.org/linguistics/gold/VegetableGender</seealso>
    let VegetableGender = Prefixed_Name(gold, "VegetableGender") |> PrefixedName
    /// <summary>
    ///   <para>gold:VelaricProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Velaric refers to an air-stream mechanism wherein the air is generated by a closure at the velar position, rather than an air-stream generated by the lungs. The back of the tongue is raised against the velum, and articulations are made farther forward by the lips or front parts of the tongue, drawing air into or pushing air out of the mouth. The clicks of some African languages are produced in this way. In English, they may be heard in the 'tut tut' sound. [Crystal 1985: 325-326; Hartmann and Stork 1972: 8]"</para>
    /// labels<para>"VelaricProperty"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/VelaricProperty">http://purl.org/linguistics/gold/VelaricProperty</seealso>
    let VelaricProperty = Prefixed_Name(gold, "VelaricProperty") |> PrefixedName
    /// <summary>
    ///   <para>gold:VerbPhrase</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A unit of sentence structure consisting of a verb and the other elements closely linked to it. Traditional grammarians divided a typical sentence into two parts: a subject and a predicate. In our modern elaboration of this, the syntactic category which acts as a subject is a noun phrase, while the category acting as the predicate is a verb phrase. A verb phrase always contains a verb, and it usually contains some other material closely linked to that verb. [Trask 1999: 335] According to the valence of the verb, the number and kind of the obligatory complements may vary; in addition, any number of free complements are possible. The border between obligatory and free complementsis often difficult to draw. [Bussmann 1996: 513]"</para>
    /// labels<para>"VerbPhrase"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/VerbPhrase">http://purl.org/linguistics/gold/VerbPhrase</seealso>
    let VerbPhrase = Prefixed_Name(gold, "VerbPhrase") |> PrefixedName
    /// <summary>
    ///   <para>gold:Verbal</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A Verbal is a part of speech whose members typically signal events and actions; constitute, singly or in a phrase, a minimal  predicate in a  clause; govern the number and types of other constituents which may occur in the clause; and, in inflectional languages, may be inflected for tense, aspect, voice, modality, or agreement with other constituents in person, number, or grammatical gender  [Crystal 1997: 409; Givon 1984: 52; Payne 1997: 47]."</para>
    /// labels<para>"Verbal"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/Verbal">http://purl.org/linguistics/gold/Verbal</seealso>
    let Verbal = Prefixed_Name(gold, "Verbal") |> PrefixedName
    /// <summary>
    ///   <para>gold:VerbalAdjective</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An adjectival which is closely related in form and or meaning to a verb. For example, -ed and -ing forms in English which are used as adjectives. [Crystal 1985: 326; Hartmann and Stork 1972: 249; Pei and Gaynor 1980: 227]"</para>
    /// labels<para>"VerbalAdjective"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/VerbalAdjective">http://purl.org/linguistics/gold/VerbalAdjective</seealso>
    let VerbalAdjective = Prefixed_Name(gold, "VerbalAdjective") |> PrefixedName
    /// <summary>
    ///   <para>gold:VerbalParticle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Verbal particles are a closed class of uninflected words that co-occur with certain verbs. In some cases the verbal particles may have clearly distinguishable locative or directional meanings. In some languages some or all of the verbal particles also occur as (and are historically derived from) adpositions. In other languages, however, for example Ga'anda, the verbal particles are entirely distinct from adpositions. [Schachter 1985: 45-46]"</para>
    /// labels<para>"VerbalParticle"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/VerbalParticle">http://purl.org/linguistics/gold/VerbalParticle</seealso>
    let VerbalParticle = Prefixed_Name(gold, "VerbalParticle") |> PrefixedName
    /// <summary>
    ///   <para>gold:Verbalizer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Verbalizer is the class of category changing units that change nouns into verbs."</para>
    /// labels<para>"Verbalizer"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/Verbalizer">http://purl.org/linguistics/gold/Verbalizer</seealso>
    let Verbalizer = Prefixed_Name(gold, "Verbalizer") |> PrefixedName
    /// <summary>
    ///   <para>gold:Versive</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Versive refers to an intransitive verb, usually derived from an adjective but occasionally from a noun or adverb, with the meaning 'to become X'. [Edmonson 1995: 378]"</para>
    /// labels<para>"Versive"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/Versive">http://purl.org/linguistics/gold/Versive</seealso>
    let Versive = Prefixed_Name(gold, "Versive") |> PrefixedName
    /// <summary>
    ///   <para>gold:VisualEvidentiality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"VisualEvidentiality encodes the fact that the speaker came to believe the content of the expression through direct visual experience; they saw it [Palmer 2001: 57]."</para>
    /// labels<para>"VisualEvidentiality"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/VisualEvidentiality">http://purl.org/linguistics/gold/VisualEvidentiality</seealso>
    let VisualEvidentiality = Prefixed_Name(gold, "VisualEvidentiality") |> PrefixedName
    /// <summary>
    ///   <para>gold:VocativeCase</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"VocativeCase marks a noun whose referent is being addressed [Crystal 1980: 377; Hartmann and Stork 1972: 251; Pei and Gaynor 1954: 228]."</para>
    /// labels<para>"VocativeCase"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/VocativeCase">http://purl.org/linguistics/gold/VocativeCase</seealso>
    let VocativeCase = Prefixed_Name(gold, "VocativeCase") |> PrefixedName
    /// <summary>
    ///   <para>gold:VoiceProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"VoiceProperty is the class of properties that concern the grammatical encoding of the relationship between the verb and the nominals in a subject-predicate configuration. It selects a grammatically prominent syntactic constituent--subject--from the underlying semantic functions. In accusative language, the basic strategy is to select an agent as a subject [Shibatani 1988: 3]. It can be said that all voice systems mark the affectedness/nonaffectedness of sentential subjects [Klaiman 1988: 30]."</para>
    /// labels<para>"VoiceProperty"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/VoiceProperty">http://purl.org/linguistics/gold/VoiceProperty</seealso>
    let VoiceProperty = Prefixed_Name(gold, "VoiceProperty") |> PrefixedName
    /// <summary>
    ///   <para>gold:Voiced</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A fundamental term used in the phonetic classification of speech sounds, referring to the auditory result of the vibration of the vocal cords. Sounds produced while the vocal cords are vibrating are voiced. [Crystal 1985: 329]"</para>
    /// labels<para>"Voiced"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/Voiced">http://purl.org/linguistics/gold/Voiced</seealso>
    let Voiced = Prefixed_Name(gold, "Voiced") |> PrefixedName
    /// <summary>
    ///   <para>gold:Voiceless</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A fundamental term used in the phonetic classification of speech sounds, referring to the auditory result of the vibration of the vocal cords. Sounds produced while the vocal cords are not vibrating are voiceless. [Crystal 1985: 329]"</para>
    /// labels<para>"Voiceless"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/Voiceless">http://purl.org/linguistics/gold/Voiceless</seealso>
    let Voiceless = Prefixed_Name(gold, "Voiceless") |> PrefixedName
    /// <summary>
    ///   <para>gold:VoicingProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Refers to the vibratory activity of the vocal folds. Most languages have phonemic contrasts between voiced and voiceless sounds (regular vibration of the vocal folds versus no vibration of the vocal folds respectively). However, Ladefoged and Maddieson recognize five steps in the continuum of modes of vibration in the glottis, going from breathy voice - the most open setting of the vocal folds in which vibration will occur, passing through slack voice, modal voice, and stiff voice, ending with creaky voice - the most constricted setting in which vibration will occur. Each of these modes of voicing may or may not be phonemic in a given language. [Ladefoged and Maddieson 1996: 48-49]"</para>
    /// labels<para>"VoicingProperty"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/VoicingProperty">http://purl.org/linguistics/gold/VoicingProperty</seealso>
    let VoicingProperty = Prefixed_Name(gold, "VoicingProperty") |> PrefixedName
    /// <summary>
    ///   <para>gold:VolitiveForce</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"VolitiveForce indicates that the speaker is willing to perform some action [Palmer 2001: 76]."</para>
    /// labels<para>"VolitiveForce"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/VolitiveForce">http://purl.org/linguistics/gold/VolitiveForce</seealso>
    let VolitiveForce = Prefixed_Name(gold, "VolitiveForce") |> PrefixedName
    /// <summary>
    ///   <para>gold:Vowel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"One of the two general categories used for the classification of speech sounds, the other being consonant. Phonetically, they are sounds articulated without a complete closure in the mouth that would produce a stop or a degree of narrowing that would create audible friction; the air escapes evenly over the center of the tongue. For oral vowels, air escapes solely through the mouth. If some air is simultaneously released through the nose, the vowel is nasal. The quality of the vowel sound is affected by the shape of the oral resonance chamber, chiefly influenced by the position of the lips and the position of the tongue. [Crystal 1985: 330; Hartmann and Stork 1972: 253]"</para>
    /// labels<para>"Vowel"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/Vowel">http://purl.org/linguistics/gold/Vowel</seealso>
    let Vowel = Prefixed_Name(gold, "Vowel") |> PrefixedName

    /// <summary>
    ///   <para>gold:WeakObligativeModality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"WeakObligativeModality indicates that an agent is under a moral obligation to perform the action expressed by the predicate [Bybee, Perkins and Pagliuca 1994: 186-187]."</para>
    /// labels<para>"WeakObligativeModality"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/WeakObligativeModality">http://purl.org/linguistics/gold/WeakObligativeModality</seealso>
    let WeakObligativeModality =
        Prefixed_Name(gold, "WeakObligativeModality") |> PrefixedName

    /// <summary>
    ///   <para>gold:WrittenLanguage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"One of the means or modes of linguistic communication.  As distinct from spoken language, it does not usually represent all features of speech such as stress and pitch, and lacks the redundancy and lapses of spoken conversation (written dialogue and reading aloud are more akin to written than to spoken language). Also reference orthography. [Hartmann and Stork 1972: 258]"</para>
    /// labels<para>"WrittenLanguage"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/WrittenLanguage">http://purl.org/linguistics/gold/WrittenLanguage</seealso>
    let WrittenLanguage = Prefixed_Name(gold, "WrittenLanguage") |> PrefixedName

    /// <summary>
    ///   <para>gold:WrittenLinguisticExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A WrittenLinguisticExpression is the written physical form of language as distinct from either signed or spoken expressions. A written expression is the physical product of the writing process."</para>
    /// labels<para>"WrittenLinguisticExpression"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/WrittenLinguisticExpression">http://purl.org/linguistics/gold/WrittenLinguisticExpression</seealso>
    let WrittenLinguisticExpression =
        Prefixed_Name(gold, "WrittenLinguisticExpression") |> PrefixedName

    /// <summary>
    ///   <para>gold:ZeroPlacePredicator</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"ZeroPlacePredicator is the class of syntactic words that need not take any arguments, but act as predicators nevertheless."</para>
    /// labels<para>"ZeroPlacePredicator"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/ZeroPlacePredicator">http://purl.org/linguistics/gold/ZeroPlacePredicator</seealso>
    let ZeroPlacePredicator = Prefixed_Name(gold, "ZeroPlacePredicator") |> PrefixedName
    /// <summary>
    ///   <para>gold:abbreviation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The abbreviated form representing a scientific term, e.g., ACC, 2, CL."</para>
    /// labels<para>"abbreviation"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/abbreviation">http://purl.org/linguistics/gold/abbreviation</seealso>
    let abbreviation = Prefixed_Name(gold, "abbreviation") |> PrefixedName
    /// <summary>
    ///   <para>gold:acousticRealization</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The relation between some linguistic unit and its corresponding spoken expression."</para>
    /// labels<para>"acousticRealization"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/acousticRealization">http://purl.org/linguistics/gold/acousticRealization</seealso>
    let acousticRealization = Prefixed_Name(gold, "acousticRealization") |> PrefixedName
    /// <summary>
    ///   <para>gold:adjunct</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"adjunct"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/adjunct">http://purl.org/linguistics/gold/adjunct</seealso>
    let adjunct = Prefixed_Name(gold, "adjunct") |> PrefixedName
    /// <summary>
    ///   <para>gold:agent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"agent"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/agent">http://purl.org/linguistics/gold/agent</seealso>
    let agent = Prefixed_Name(gold, "agent") |> PrefixedName
    /// <summary>
    ///   <para>gold:agrees</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A relation holding between syntactic units, often manifesting itself in shared form features. NOTE: this could be better defined once syntactic roles and relations are developed."</para>
    /// labels<para>"agrees"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/agrees">http://purl.org/linguistics/gold/agrees</seealso>
    let agrees = Prefixed_Name(gold, "agrees") |> PrefixedName
    /// <summary>
    ///   <para>gold:allomorph</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The relation that holds between a morpheme and one of its morphs, an occurrence of a morpheme in context."</para>
    /// labels<para>"allomorph"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/allomorph">http://purl.org/linguistics/gold/allomorph</seealso>
    let allomorph = Prefixed_Name(gold, "allomorph") |> PrefixedName
    /// <summary>
    ///   <para>gold:allophone</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The relation that holds between a phoneme and one of its phones, an occurrence of a phoneme in context."</para>
    /// labels<para>"allophone"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/allophone">http://purl.org/linguistics/gold/allophone</seealso>
    let allophone = Prefixed_Name(gold, "allophone") |> PrefixedName
    /// <summary>
    ///   <para>gold:ancestorVariety</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"ancestorVariety is the predicate expressing the basic diachronic relationship  between a language variety that existed some time in the past and a variety existing at a later time  such that the  former has evolved into the latter through regular language change."</para>
    /// labels<para>"ancestorVariety"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/ancestorVariety">http://purl.org/linguistics/gold/ancestorVariety</seealso>
    let ancestorVariety = Prefixed_Name(gold, "ancestorVariety") |> PrefixedName
    /// <summary>
    ///   <para>gold:antonym</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"antonym"</para>
    /// labels<para>"antonym"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/antonym">http://purl.org/linguistics/gold/antonym</seealso>
    let antonym = Prefixed_Name(gold, "antonym") |> PrefixedName
    /// <summary>
    ///   <para>gold:argument</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The syntactic entity about which something is predicated."</para>
    /// labels<para>"argument"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/argument">http://purl.org/linguistics/gold/argument</seealso>
    let argument = Prefixed_Name(gold, "argument") |> PrefixedName
    /// <summary>
    ///   <para>gold:circumscribes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"NOTE: still lacks development. This relation holds between two form units and represents the notion of circumscription in a morphosyntactic system. That is, (circumscribes A B) means that part of A comes before B and part of A comes after B, in the linearization of the units of a language."</para>
    /// labels<para>"circumscribes"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/circumscribes">http://purl.org/linguistics/gold/circumscribes</seealso>
    let circumscribes = Prefixed_Name(gold, "circumscribes") |> PrefixedName
    /// <summary>
    ///   <para>gold:coda</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The closing segment of a syllable."</para>
    /// labels<para>"coda"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/coda">http://purl.org/linguistics/gold/coda</seealso>
    let coda = Prefixed_Name(gold, "coda") |> PrefixedName
    /// <summary>
    ///   <para>gold:complement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"complement"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/complement">http://purl.org/linguistics/gold/complement</seealso>
    let complement = Prefixed_Name(gold, "complement") |> PrefixedName
    /// <summary>
    ///   <para>gold:constituents</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The relation holding between a linguistic unit and a list (rdf:Seq) of its constituents."</para>
    /// labels<para>"constituents"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/constituents">http://purl.org/linguistics/gold/constituents</seealso>
    let constituents = Prefixed_Name(gold, "constituents") |> PrefixedName

    /// <summary>
    ///   <para>gold:dataStructureRelation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This subsumes all structuring relations used for LinguisticDataStructures. As a naming convention to distinguish relations in data structure from other relations, all names of dataStructuringRelations begin with 'has-'."</para>
    /// labels<para>"dataStructureRelation"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/dataStructureRelation">http://purl.org/linguistics/gold/dataStructureRelation</seealso>
    let dataStructureRelation =
        Prefixed_Name(gold, "dataStructureRelation") |> PrefixedName

    /// <summary>
    ///   <para>gold:derivedForm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"derivedForm"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/derivedForm">http://purl.org/linguistics/gold/derivedForm</seealso>
    let derivedForm = Prefixed_Name(gold, "derivedForm") |> PrefixedName
    /// <summary>
    ///   <para>gold:directObject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A direct object is a grammatical relation that exhibits a combination of certain independent syntactic properties, such as the following:  the usual grammatical characteristics of the patient of typically  transitive verbs; particular case marking; a particular clause  position; the conditioning of an agreement  affix on the verb; the capability of becoming the clause subject in  passivization; the capability of reflexivization. The identification of the direct object relation may be further confirmed by finding significant overlap with similar direct object relations previously established in other languages. This may be done by analyzing correspondence between  translation equivalents [Crystal 1985, 94; Hartmann and Stork 1972, 155; Comrie 1989, 66; Andrews 1985, 68,120,126; Comrie 1985, 337]."</para>
    /// labels<para>"directObject"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/directObject">http://purl.org/linguistics/gold/directObject</seealso>
    let directObject = Prefixed_Name(gold, "directObject") |> PrefixedName
    /// <summary>
    ///   <para>gold:entailedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"entailedBy"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/entailedBy">http://purl.org/linguistics/gold/entailedBy</seealso>
    let entailedBy = Prefixed_Name(gold, "entailedBy") |> PrefixedName
    /// <summary>
    ///   <para>gold:entails</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"entails"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/entails">http://purl.org/linguistics/gold/entails</seealso>
    let entails = Prefixed_Name(gold, "entails") |> PrefixedName
    /// <summary>
    ///   <para>gold:feature</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The relation between a linguistic unit and a linguistic feature. A feature inheres in its host. NOTE: this relation is distinct from the hasFeature which pertains to data structures."</para>
    /// labels<para>"feature"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/feature">http://purl.org/linguistics/gold/feature</seealso>
    let feature = Prefixed_Name(gold, "feature") |> PrefixedName
    /// <summary>
    ///   <para>gold:follows</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This relation holds between two linguistic units and represents the inverse of 'precedes'. That is, (follows A B) means that A comes after B in the linearization of the realization of linguistic signs. The inverse of this relation is 'precedes'."</para>
    /// labels<para>"follows"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/follows">http://purl.org/linguistics/gold/follows</seealso>
    let follows = Prefixed_Name(gold, "follows") |> PrefixedName
    /// <summary>
    ///   <para>gold:freeTranslation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The relation between an orthographic expression in one language and some orthographic expression in another such that both expressions have exactly the same meaning. The words in the translation may not correspond to the those in the source expression."</para>
    /// labels<para>"freeTranslation"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/freeTranslation">http://purl.org/linguistics/gold/freeTranslation</seealso>
    let freeTranslation = Prefixed_Name(gold, "freeTranslation") |> PrefixedName
    /// <summary>
    ///   <para>gold:geneticallyRelated</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"geneticallyRelated is the basic kinship relation between languages varieties. If two language varieties are genetically related, then this implies that both  varieties are derived from a common  proto-language."</para>
    /// labels<para>"geneticallyRelated"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/geneticallyRelated">http://purl.org/linguistics/gold/geneticallyRelated</seealso>
    let geneticallyRelated = Prefixed_Name(gold, "geneticallyRelated") |> PrefixedName
    /// <summary>
    ///   <para>gold:goal</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"goal"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/goal">http://purl.org/linguistics/gold/goal</seealso>
    let goal = Prefixed_Name(gold, "goal") |> PrefixedName
    /// <summary>
    ///   <para>gold:hasComplexValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This relates a ComplexSpecification to a FeatureStructure, thus giving a FeatureStructure its recursive properties."</para>
    /// labels<para>"hasComplexValue"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/hasComplexValue">http://purl.org/linguistics/gold/hasComplexValue</seealso>
    let hasComplexValue = Prefixed_Name(gold, "hasComplexValue") |> PrefixedName
    /// <summary>
    ///   <para>gold:hasConstituent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The relation hasConstituent is an abstract partial ordering relation that expresses dominance between two linguistic units. This relation is meant to cover all possible types of linguistic constituency: phonological, morphological, syntactic, etc. constituency."</para>
    /// labels<para>"hasConstituent"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/hasConstituent">http://purl.org/linguistics/gold/hasConstituent</seealso>
    let hasConstituent = Prefixed_Name(gold, "hasConstituent") |> PrefixedName
    /// <summary>
    ///   <para>gold:hasConstraint</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This relates a FeatureSystem to a FeatureContraint."</para>
    /// labels<para>"hasConstraint"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/hasConstraint">http://purl.org/linguistics/gold/hasConstraint</seealso>
    let hasConstraint = Prefixed_Name(gold, "hasConstraint") |> PrefixedName
    /// <summary>
    ///   <para>gold:hasExample</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"hasExample"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/hasExample">http://purl.org/linguistics/gold/hasExample</seealso>
    let hasExample = Prefixed_Name(gold, "hasExample") |> PrefixedName
    /// <summary>
    ///   <para>gold:hasFeature</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This relates a FeatureSpecification to a type of LinguisticProperty."</para>
    /// labels<para>"hasFeature"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/hasFeature">http://purl.org/linguistics/gold/hasFeature</seealso>
    let hasFeature = Prefixed_Name(gold, "hasFeature") |> PrefixedName
    /// <summary>
    ///   <para>gold:hasForm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The relation that associates some LinguisticSign with its FormUnit."</para>
    /// labels<para>"hasForm"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/hasForm">http://purl.org/linguistics/gold/hasForm</seealso>
    let hasForm = Prefixed_Name(gold, "hasForm") |> PrefixedName
    /// <summary>
    ///   <para>gold:hasGlosses</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The binary relation holding between an instance of interlinear glossed text (IGT) and a sequence of labels or 'grams' used to describe the morphemes of the IGT."</para>
    /// labels<para>"hasGlosses"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/hasGlosses">http://purl.org/linguistics/gold/hasGlosses</seealso>
    let hasGlosses = Prefixed_Name(gold, "hasGlosses") |> PrefixedName
    /// <summary>
    ///   <para>gold:hasGrammar</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The relation that holds between a LinguisticSign and a GrammaticalUnit."</para>
    /// labels<para>"hasGrammar"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/hasGrammar">http://purl.org/linguistics/gold/hasGrammar</seealso>
    let hasGrammar = Prefixed_Name(gold, "hasGrammar") |> PrefixedName
    /// <summary>
    ///   <para>gold:hasLexicalItem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The relation between a Lexicon and its contents, instances of LexicalItem. NOTE: this could probably be replaced by the memberOf relation from set theory."</para>
    /// labels<para>"hasLexicalItem"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/hasLexicalItem">http://purl.org/linguistics/gold/hasLexicalItem</seealso>
    let hasLexicalItem = Prefixed_Name(gold, "hasLexicalItem") |> PrefixedName
    /// <summary>
    ///   <para>gold:hasLexicalUnit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This relates a LexicalItem to a LexicalUnit, those elements commonly represented in a dictionary."</para>
    /// labels<para>"hasLexicalUnit"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/hasLexicalUnit">http://purl.org/linguistics/gold/hasLexicalUnit</seealso>
    let hasLexicalUnit = Prefixed_Name(gold, "hasLexicalUnit") |> PrefixedName
    /// <summary>
    ///   <para>gold:hasMeaning</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The relation that associates some LinguisticSign with a SemanticUnit."</para>
    /// labels<para>"hasMeaning"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/hasMeaning">http://purl.org/linguistics/gold/hasMeaning</seealso>
    let hasMeaning = Prefixed_Name(gold, "hasMeaning") |> PrefixedName

    /// <summary>
    ///   <para>gold:hasMorphologicalConstituent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The relation hasMorphologicalConstituent is an abstract partial ordering relation that expresses dominance between two morphological units. This relation is meant to cover all possible types of morphological constituency."</para>
    /// labels<para>"hasMorphologicalConstituent"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/hasMorphologicalConstituent">http://purl.org/linguistics/gold/hasMorphologicalConstituent</seealso>
    let hasMorphologicalConstituent =
        Prefixed_Name(gold, "hasMorphologicalConstituent") |> PrefixedName

    /// <summary>
    ///   <para>gold:hasProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The relation between a linguistic unit and a linguistic property, e.g., (m1 hasProperty AllativeCase) where m1 is an instance of Morpheme."</para>
    /// labels<para>"hasProperty"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/hasProperty">http://purl.org/linguistics/gold/hasProperty</seealso>
    let hasProperty = Prefixed_Name(gold, "hasProperty") |> PrefixedName
    /// <summary>
    ///   <para>gold:hasSourceLine</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The binary relation holding between an instance of interlinear glossed text and a linguistic unit (clause, phrase, etc.) from the source language."</para>
    /// labels<para>"hasSourceLine"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/hasSourceLine">http://purl.org/linguistics/gold/hasSourceLine</seealso>
    let hasSourceLine = Prefixed_Name(gold, "hasSourceLine") |> PrefixedName
    /// <summary>
    ///   <para>gold:hasSpecification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This relates a FeatureStructure to a FeatureSpecification."</para>
    /// labels<para>"hasSpecification"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/hasSpecification">http://purl.org/linguistics/gold/hasSpecification</seealso>
    let hasSpecification = Prefixed_Name(gold, "hasSpecification") |> PrefixedName

    /// <summary>
    ///   <para>gold:hasSyntacticConstituent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The relation hasSyntacticConstituent is an abstract partial ordering relation that expresses dominance between two syntactic units. This relation is meant to cover all possible types of syntactic constituency."</para>
    /// labels<para>"hasSyntacticConstituent"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/hasSyntacticConstituent">http://purl.org/linguistics/gold/hasSyntacticConstituent</seealso>
    let hasSyntacticConstituent =
        Prefixed_Name(gold, "hasSyntacticConstituent") |> PrefixedName

    /// <summary>
    ///   <para>gold:hasTerm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The relation between some Termset and a Term."</para>
    /// labels<para>"hasTerm"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/hasTerm">http://purl.org/linguistics/gold/hasTerm</seealso>
    let hasTerm = Prefixed_Name(gold, "hasTerm") |> PrefixedName
    /// <summary>
    ///   <para>gold:hasTranslationLine</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The binary relation holding between an instance of interlinear glossed text and a linguistic unit (clause, phrase, etc.) acting as a free translation of the source text from the IGT instance."</para>
    /// labels<para>"hasTranslationLine"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/hasTranslationLine">http://purl.org/linguistics/gold/hasTranslationLine</seealso>
    let hasTranslationLine = Prefixed_Name(gold, "hasTranslationLine") |> PrefixedName
    /// <summary>
    ///   <para>gold:hasType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This relates either a FeatureStructure or a FeatureConstraint to its type, expressed by an instance of PartOfSpeech."</para>
    /// labels<para>"hasType"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/hasType">http://purl.org/linguistics/gold/hasType</seealso>
    let hasType = Prefixed_Name(gold, "hasType") |> PrefixedName
    /// <summary>
    ///   <para>gold:head</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"head"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/head">http://purl.org/linguistics/gold/head</seealso>
    let head = Prefixed_Name(gold, "head") |> PrefixedName
    /// <summary>
    ///   <para>gold:hypernym</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"hypernym"</para>
    /// labels<para>"hypernym"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/hypernym">http://purl.org/linguistics/gold/hypernym</seealso>
    let hypernym = Prefixed_Name(gold, "hypernym") |> PrefixedName
    /// <summary>
    ///   <para>gold:inLanguage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The relation that holds between a LinguisticSign and a Language. The sign is said to be a member or part of that language."</para>
    /// labels<para>"inLanguage"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/inLanguage">http://purl.org/linguistics/gold/inLanguage</seealso>
    let inLanguage = Prefixed_Name(gold, "inLanguage") |> PrefixedName
    /// <summary>
    ///   <para>gold:indirectObject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"indirectObject"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/indirectObject">http://purl.org/linguistics/gold/indirectObject</seealso>
    let indirectObject = Prefixed_Name(gold, "indirectObject") |> PrefixedName
    /// <summary>
    ///   <para>gold:infixedIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"infixedIn is the relation between a Lexical- or SublexicalUnit and a Root. The Root is realized as discontinuous, surrounding the inserted Lexical- or SublexicalUnit [Hartmann and Stork 1972, 111]."</para>
    /// labels<para>"infixedIn"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/infixedIn">http://purl.org/linguistics/gold/infixedIn</seealso>
    let infixedIn = Prefixed_Name(gold, "infixedIn") |> PrefixedName
    /// <summary>
    ///   <para>gold:inflectedForm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"inflectedForm"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/inflectedForm">http://purl.org/linguistics/gold/inflectedForm</seealso>
    let inflectedForm = Prefixed_Name(gold, "inflectedForm") |> PrefixedName
    /// <summary>
    ///   <para>gold:labels</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This relation names or simply associates some SymbolicString with any Entity."</para>
    /// labels<para>"labels"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/labels">http://purl.org/linguistics/gold/labels</seealso>
    let labels = Prefixed_Name(gold, "labels") |> PrefixedName
    /// <summary>
    ///   <para>gold:lexicalRelation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This is the superclass of common lexical relatations such as synonym, antonym, etc. NOTE: this needs work. Such relations really pertain to meaning and not form units."</para>
    /// labels<para>"lexicalRelation"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/lexicalRelation">http://purl.org/linguistics/gold/lexicalRelation</seealso>
    let lexicalRelation = Prefixed_Name(gold, "lexicalRelation") |> PrefixedName
    /// <summary>
    ///   <para>gold:literalTranslation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The relation between an orthographic expression in one language and some orthographic expression in another such that the translation is done on a word by word, or morpheme by morpheme, basis without regard for idiomatic usage."</para>
    /// labels<para>"literalTranslation"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/literalTranslation">http://purl.org/linguistics/gold/literalTranslation</seealso>
    let literalTranslation = Prefixed_Name(gold, "literalTranslation") |> PrefixedName
    /// <summary>
    ///   <para>gold:meronym</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"meronym"</para>
    /// labels<para>"meronym"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/meronym">http://purl.org/linguistics/gold/meronym</seealso>
    let meronym = Prefixed_Name(gold, "meronym") |> PrefixedName

    /// <summary>
    ///   <para>gold:morphologicalRelation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A relation holding between morphological units."</para>
    /// labels<para>"morphologicalRelation"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/morphologicalRelation">http://purl.org/linguistics/gold/morphologicalRelation</seealso>
    let morphologicalRelation =
        Prefixed_Name(gold, "morphologicalRelation") |> PrefixedName

    /// <summary>
    ///   <para>gold:mutuallyIntelligible</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"mutuallyIntelligible is the binary, symmetric relation holding between two language varieties such that speakers of the first variety can communicate with members of the second with relative ease, and vice versa."</para>
    /// labels<para>"mutuallyIntelligible"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/mutuallyIntelligible">http://purl.org/linguistics/gold/mutuallyIntelligible</seealso>
    let mutuallyIntelligible =
        Prefixed_Name(gold, "mutuallyIntelligible") |> PrefixedName

    /// <summary>
    ///   <para>gold:names</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This semiotic relation associates some OrthographicExpression with some Entity. It differs from 'labels' in that a name is usually considered part of the orthographic system, where a label is not."</para>
    /// labels<para>"names"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/names">http://purl.org/linguistics/gold/names</seealso>
    let names = Prefixed_Name(gold, "names") |> PrefixedName
    /// <summary>
    ///   <para>gold:nucleus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The central segment of a syllable."</para>
    /// labels<para>"nucleus"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/nucleus">http://purl.org/linguistics/gold/nucleus</seealso>
    let nucleus = Prefixed_Name(gold, "nucleus") |> PrefixedName
    /// <summary>
    ///   <para>gold:object</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"An object, traditionally defined, is either a direct object or an indirect object.An object, in some usages, is any  grammatical relation other than subject [Crystal 1985, 211; Hartmann and Stork 1972, 155-156; Comrie 1989, 66]."</para>
    /// labels<para>"object"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/object">http://purl.org/linguistics/gold/object</seealso>
    let object = Prefixed_Name(gold, "object") |> PrefixedName
    /// <summary>
    ///   <para>gold:onset</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The initial segment of a syllable."</para>
    /// labels<para>"onset"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/onset">http://purl.org/linguistics/gold/onset</seealso>
    let onset = Prefixed_Name(gold, "onset") |> PrefixedName
    /// <summary>
    ///   <para>gold:orderingRelation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Any relation that establishes a linear ordering of linguistic units."</para>
    /// labels<para>"orderingRelation"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/orderingRelation">http://purl.org/linguistics/gold/orderingRelation</seealso>
    let orderingRelation = Prefixed_Name(gold, "orderingRelation") |> PrefixedName
    /// <summary>
    ///   <para>gold:orthographicRep</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"orthographicRep"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/orthographicRep">http://purl.org/linguistics/gold/orthographicRep</seealso>
    let orthographicRep = Prefixed_Name(gold, "orthographicRep") |> PrefixedName
    /// <summary>
    ///   <para>gold:parentVariety</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"parentVariety is the  relation of direct genetic relatedness, where there are  no intermediate ancestors between the ancestor and descendant. For example, Old English is the parent variety of Middle English."</para>
    /// labels<para>"parentVariety"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/parentVariety">http://purl.org/linguistics/gold/parentVariety</seealso>
    let parentVariety = Prefixed_Name(gold, "parentVariety") |> PrefixedName
    /// <summary>
    ///   <para>gold:patient</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A semantic role, often unmarked, that typically does not act with volition, instigate an event, receive something, or experience a sensory impression.  A prototypical patient undergoes a physical, visible change in state. Often the subject of a intransitive verb or the logical complement of a transitive verb. [Payne 1997: 50-51; Pei"</para>
    /// labels<para>"patient"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/patient">http://purl.org/linguistics/gold/patient</seealso>
    let patient = Prefixed_Name(gold, "patient") |> PrefixedName
    /// <summary>
    ///   <para>gold:phonemicRep</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"phonemicRep"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/phonemicRep">http://purl.org/linguistics/gold/phonemicRep</seealso>
    let phonemicRep = Prefixed_Name(gold, "phonemicRep") |> PrefixedName
    /// <summary>
    ///   <para>gold:phoneticRep</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"phoneticRep"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/phoneticRep">http://purl.org/linguistics/gold/phoneticRep</seealso>
    let phoneticRep = Prefixed_Name(gold, "phoneticRep") |> PrefixedName
    /// <summary>
    ///   <para>gold:precedes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This relation holds between two linguistic units and represents the notion of precedence in a language. That is, (precedes A B) means that A comes before B in the linearization of the realization of linguistic signs. This inverse of this relation is 'follows'."</para>
    /// labels<para>"precedes"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/precedes">http://purl.org/linguistics/gold/precedes</seealso>
    let precedes = Prefixed_Name(gold, "precedes") |> PrefixedName
    /// <summary>
    ///   <para>gold:predicate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The predicate is the relation between the Clause and a portion of a  clause, excluding the subject, that expresses something about the subject [Crystal 1980, 280; Hartmann and Stork 1972, 182; Pei and Gaynor 1954, 173; Pike and Pike 1982, 40; Crystal 1985, 241-242]."</para>
    /// labels<para>"predicate"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/predicate">http://purl.org/linguistics/gold/predicate</seealso>
    let predicate = Prefixed_Name(gold, "predicate") |> PrefixedName
    /// <summary>
    ///   <para>gold:prefix</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The relation between a morphological unit and the  lexical unit to which it is attached. The LexicalUnit is usually a Root or Stem. The inverse of prefix is suffix [Crystal 1980, 281; Hartmann and Stork 1972, 182]."</para>
    /// labels<para>"prefix"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/prefix">http://purl.org/linguistics/gold/prefix</seealso>
    let prefix = Prefixed_Name(gold, "prefix") |> PrefixedName
    /// <summary>
    ///   <para>gold:realization</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The relation holding between a linguistic unit and its physical form, either a spoken, written or signed expression."</para>
    /// labels<para>"realization"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/realization">http://purl.org/linguistics/gold/realization</seealso>
    let realization = Prefixed_Name(gold, "realization") |> PrefixedName
    /// <summary>
    ///   <para>gold:rhyme</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The core of a syllable, consisting of a nucleus and coda."</para>
    /// labels<para>"rhyme"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/rhyme">http://purl.org/linguistics/gold/rhyme</seealso>
    let rhyme = Prefixed_Name(gold, "rhyme") |> PrefixedName
    /// <summary>
    ///   <para>gold:semanticRole</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"semanticRole"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/semanticRole">http://purl.org/linguistics/gold/semanticRole</seealso>
    let semanticRole = Prefixed_Name(gold, "semanticRole") |> PrefixedName
    /// <summary>
    ///   <para>gold:signedRealization</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The relation between some linguistic unit and its corresponding signed expression."</para>
    /// labels<para>"signedRealization"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/signedRealization">http://purl.org/linguistics/gold/signedRealization</seealso>
    let signedRealization = Prefixed_Name(gold, "signedRealization") |> PrefixedName
    /// <summary>
    ///   <para>gold:specifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"specifier"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/specifier">http://purl.org/linguistics/gold/specifier</seealso>
    let specifier = Prefixed_Name(gold, "specifier") |> PrefixedName
    /// <summary>
    ///   <para>gold:stringRep</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"stringRep"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/stringRep">http://purl.org/linguistics/gold/stringRep</seealso>
    let stringRep = Prefixed_Name(gold, "stringRep") |> PrefixedName
    /// <summary>
    ///   <para>gold:subject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"subject"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/subject">http://purl.org/linguistics/gold/subject</seealso>
    let subject = Prefixed_Name(gold, "subject") |> PrefixedName
    /// <summary>
    ///   <para>gold:suffix</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The relation between a morphological unit and the  lexical unit to which it is attached. The LexicalUnit is usually a Root or Stem. The inverse of suffix is 'prefix' [Crystal 1980, 340; Hartmann and Stork 1972, 226]."</para>
    /// labels<para>"suffix"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/suffix">http://purl.org/linguistics/gold/suffix</seealso>
    let suffix = Prefixed_Name(gold, "suffix") |> PrefixedName
    /// <summary>
    ///   <para>gold:synonym</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"synonym"</para>
    /// labels<para>"synonym"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/synonym">http://purl.org/linguistics/gold/synonym</seealso>
    let synonym = Prefixed_Name(gold, "synonym") |> PrefixedName
    /// <summary>
    ///   <para>gold:syntacticRole</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A general category subsuming relations relevant at the level of the Clause, such as predicate and subject.
    /// A grammatical relation is a role of a phrase or  complement clause that determines syntactic behaviors such as the following: word position in a clause; verb agreement; participation and behavior in such operations as  passivization [Comrie 1989, 65-66; Andrews 1985, 66]."</para>
    /// labels<para>"syntacticRole"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/syntacticRole">http://purl.org/linguistics/gold/syntacticRole</seealso>
    let syntacticRole = Prefixed_Name(gold, "syntacticRole") |> PrefixedName
    /// <summary>
    ///   <para>gold:translation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The relation between an orthographic expression in one language and some orthographic expression in another such that both expressions have the same or roughly the same meaning."</para>
    /// labels<para>"translation"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/translation">http://purl.org/linguistics/gold/translation</seealso>
    let translation = Prefixed_Name(gold, "translation") |> PrefixedName
    /// <summary>
    ///   <para>gold:writtenRealization</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The relation between some linguistic unit and its corresponding written expression."</para>
    /// labels<para>"writtenRealization"</para></remarks>
    /// <seealso href="http://purl.org/linguistics/gold/writtenRealization">http://purl.org/linguistics/gold/writtenRealization</seealso>
    let writtenRealization = Prefixed_Name(gold, "writtenRealization") |> PrefixedName
