namespace http.www.ontologydesignpatterns.org.ont.dul.IOLite.owl.hash

open DoxAletheia

module iol =
    let _namespace_name = "http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// Any information object represented in a FormalLanguage, usually having a formal interpretation by a dul:FormalEntity, and used to formally represent any Entity
    /// <see href="http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#FormalExpression"></see></summary>
    let FormalExpression = _prefix "FormalExpression"
    /// <summary>
    /// The relation between a FormalExpression, and an Entity (a FormalEntity in case of classes, relations, etc.) that it is supposed to be the reference of the symbol (FormalExpression) that the Entity is an intepretation of.
    /// In other words, this is the 'formal interpretation' function, by which a logician 'assigns' an Entity to a FormalExpression.
    /// For each type of formal expressions defined in a logical language, an assignment assumption should be indicated, for example, owl:Class should be restricted to: isAssignmentOf allValuesFrom Class. In addition, differently from the general relation formallyRepresents, isAssignmentOf is functional (and its inverse is inverse functional), in order to encode the Tarskian correspondence assumption.
    /// E.g., the Set of 'all mariachis in Tijuana' isAssignedTo the predicate (FormalExpression) 'TijuanaMariachi' (that isFormalTermFor a Term e.g. 'the mariachis in Tijuana').
    /// <see href="http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#isAssignedTo"></see></summary>
    let isAssignedTo = _prefix "isAssignedTo"
    /// <summary>
    /// Any relation between two information entities, with the first used as an alternative encoding of the second. This encoding can preserve all or part of the informational structure. For example, an XML encoding of a plain text file, a digital scanning of a physical paper document, a reproduction of a painting, etc.
    /// The encoding can be so precise and close to the medium of realization, that distinguishing the maximally encoded object from its realization is superfluous (as in many cases of computer science information entities). For this reason, the relation holds for either dul:InformationObject(s) or dul:InformationRealization(s).
    /// Since the relation holds for either dul:InformationObject(s) or dul:InformationRealization(s), dul:realizes is a subproperty of it.
    /// <see href="http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#isEncodedBy"></see></summary>
    let isEncodedBy = _prefix "isEncodedBy"
    /// <summary>
    /// Any relation between two information entities, with the first used as an alternative encoding of the second. This encoding can preserve all or part of the informational structure. For example, an XML encoding of a plain text file, a digital scanning of a physical paper document, a reproduction of a painting, etc.
    /// The encoding can be so precise and close to the medium of realization, that distinguishing the maximally encoded object from its realization is superfluous (as in many cases of computer science information entities). For this reason, the relation holds for either dul:InformationObject(s) or dul:InformationRealization(s).
    /// Since the relation holds for either dul:InformationObject(s) or dul:InformationRealization(s), dul:realizes is a subproperty of it.
    /// <see href="http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#encodes"></see></summary>
    let encodes = _prefix "encodes"
    /// <summary>
    /// An information realization consisting of bodily movements.
    /// <see href="http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#BodilyMotion"></see></summary>
    let BodilyMotion = _prefix "BodilyMotion"
    /// <summary>
    /// Any piece of information expressing computational operations, objects, markup, etc.
    /// <see href="http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#Code"></see></summary>
    let Code = _prefix "Code"
    /// <summary>
    /// Any resource that can be computed, e.g. a file, a piece of (implemented) software. This assumes an encoding allowing the computation (e.g. html+http protocol).
    /// <see href="http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#DigitalResource"></see></summary>
    let DigitalResource = _prefix "DigitalResource"
    /// <summary>
    /// The functions, e.g. defined by Jakobson and by Buhler, which define types of linguistic acts. Jakobson's ones include referential, conative, expressive, phatic, metalinguistic, poetic. Each function has typical roles and tasks that must be played during a linguistic act that achieves the function.
    /// <see href="http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#CommunicativeFunction"></see></summary>
    let CommunicativeFunction = _prefix "CommunicativeFunction"
    /// <summary>
    /// The text of a contract
    /// <see href="http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#ContractText"></see></summary>
    let ContractText = _prefix "ContractText"
    /// <summary>
    /// A LinguisticObject composed of at least one Sentence, and assumed to be realized in written form.
    /// <see href="http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#Text"></see></summary>
    let Text = _prefix "Text"
    /// <summary>
    /// Any conceptual, logical or physical schema for a database.
    /// <see href="http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#DBSchema"></see></summary>
    let DBSchema = _prefix "DBSchema"
    /// <summary>
    /// Any data structure, including databases, schemas, lexica, knowledge organizations systems, etc.
    /// <see href="http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#DataStructure"></see></summary>
    let DataStructure = _prefix "DataStructure"
    /// <summary>
    /// From WordNet: 'an item of factual information derived from measurement or research'
    /// <see href="http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#Datum"></see></summary>
    let Datum = _prefix "Datum"
    /// <summary>
    /// An information realization consisting of depicted images/signs of any sort (e.g. graffiti, drawings, inscriptions, pictures, sculptures, etc.), which are inscripted on a medium that lasts longer than the depicting act.
    /// It also includes any early form of inscripted iconic expression, which can be considered as original bodily expressions.
    /// <see href="http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#Depiction"></see></summary>
    let Depiction = _prefix "Depiction"
    /// <summary>
    ///   <see href="http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#DigitalPhoto"></see>
    /// </summary>
    let DigitalPhoto = _prefix "DigitalPhoto"
    /// <summary>
    /// wn noun: A representation of forms or objects on a surface by means of lines; "drawings of abstract forms"; "he did complicated pen-and-ink drawings like medieval miniatures"
    /// <see href="http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#Drawing"></see></summary>
    let Drawing = _prefix "Drawing"
    /// <summary>
    /// A formal language, created by some human, with a fixed grammar, and usually with an explicit formal semantics (i.e. any FormalExpression that is a wff or a valid element of a FormalLanguage has an interpretation wrt to formal entities such as sets, categories, etc.).
    /// <see href="http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#FormalLanguage"></see></summary>
    let FormalLanguage = _prefix "FormalLanguage"
    /// <summary>
    ///   <see href="http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#hasRepresentationLanguage"></see>
    /// </summary>
    let hasRepresentationLanguage = _prefix "hasRepresentationLanguage"
    /// <summary>
    /// The relation between an InformationObject and a FormalExpression (constant, formula, term, sentence, proposition, axiom, etc.) that it is supposed to be given formal interpretation to formalize the InformationObject.
    /// Notice that FormalExpression(s) only are formal terms for InformationObject(s), not for Concept(s) or for other SocialObject(s). On their turn, information object can 'express' (see) SocialObject(s).
    /// E.g., the predicate (FormalExpression) 'TijuanaMariachi' isFormalTermFor the Term 'the mariachis in Tijuana' (that expresses the Collection of all mariachis in Tijuana); the Term 'equivalence relation' (that expresses the Concept of 'two entities having the same properties') hasFormalTerm the '&lt;=&gt;' symbol.
    /// <see href="http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#isFormalTermFor"></see></summary>
    let isFormalTermFor = _prefix "isFormalTermFor"
    /// <summary>
    /// Knowledge Organization Systems: thesauri, terminologies, classification schemes, subject hierarchies, etc.
    /// <see href="http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#KOS"></see></summary>
    let KOS = _prefix "KOS"
    /// <summary>
    /// A natural or artificial language, provided with an alphabet (or vocabulary) and combinatorial rules. In the case of natural languages, their components are 'temporary' and 'reconstructed' out of actual usage. For example, a grammar for a natural language has the status of a theory for that language, and alternative ones can exist (e.g. generative vs. construction grammars).
    /// Another distinction, between the general (systemic) rules for a language, and the local (contextual) rules for e.g. a certain context, speaker, place, etc., can be made separately.
    /// The most comprehensive classification of languages ha probably been made by Umberto Eco, based on the production modes of the 'signs' that are represented in a certain language. It uses several semiotic dimensions, and will be modeled in a forthcoming ontology.
    /// <see href="http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#Language"></see></summary>
    let Language = _prefix "Language"
    /// <summary>
    ///   <see href="http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#Gesture"></see>
    /// </summary>
    let Gesture = _prefix "Gesture"
    /// <summary>
    /// A part of a word as it can be realized by Writing
    /// A spoken information realization can be 'about' a grapheme (as in reading), but it does not 'realize' it. Only Phoneme(s) are realized by spoken information (Voicing).
    /// BTW, since spoken realizations are a 'primary' code of communication, the difference between direct and indirect spoken realizations (reading) should be considered relevant.
    /// A grapheme is not necessarily able to express a meaning (a dul:SocialObject), although it can in principle (e.g. 'a' in English).
    /// <see href="http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#Grapheme"></see></summary>
    let Grapheme = _prefix "Grapheme"
    /// <summary>
    /// An information realization based on conventional symbols.
    /// It is a secondary code of communication (secondary means that it is about an original bodily expression, i.e. a primary code). Therefore, we are not considering here early forms of iconic expression, which could be considered primary.
    /// <see href="http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#Writing"></see></summary>
    let Writing = _prefix "Writing"
    /// <summary>
    /// An information object represented in a NaturalLanguage
    /// <see href="http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#LinguisticObject"></see></summary>
    let LinguisticObject = _prefix "LinguisticObject"
    /// <summary>
    /// wn noun: The arts of drawing or painting or printmaking
    /// <see href="http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#GraphicArt"></see></summary>
    let GraphicArt = _prefix "GraphicArt"
    /// <summary>
    /// A language made up of graphical elements. It can be natural, artificial, and even formal.
    /// <see href="http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#IconicLanguage"></see></summary>
    let IconicLanguage = _prefix "IconicLanguage"
    /// <summary>
    /// An information object represented in an IconicLanguage
    /// <see href="http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#IconicObject"></see></summary>
    let IconicObject = _prefix "IconicObject"
    /// <summary>
    /// Lexical entries for dictionaries, lexica, etc. They are used to create reference forms of words.
    /// <see href="http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#Lexeme"></see></summary>
    let Lexeme = _prefix "Lexeme"
    /// <summary>
    /// A collection of lexical items (terms, entries, ...) that are witnessed to have a linguistic relevance.
    /// <see href="http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#Lexicon"></see></summary>
    let Lexicon = _prefix "Lexicon"
    /// <summary>
    /// A relation between social objects and schemata that organize them. For example, a Tag hasSchema a Folksonomy, a Lexeme hasSchema a Lexicon, etc.
    /// <see href="http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#hasSchema"></see></summary>
    let hasSchema = _prefix "hasSchema"
    /// <summary>
    /// A LinguisticObject made up of more than one Word, but distinct from a Phrase, which is a higher syntactic unit.
    /// <see href="http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#Multiword"></see></summary>
    let Multiword = _prefix "Multiword"
    /// <summary>
    /// A linguistic object consisting of a string (independently of its physical realization).
    /// Its topological unity can change according to its physical realization: as a written realization, its boundaries are blank spaces, as a spoken realization, sometimes is silence, sometimes not, and higher order features intervene.
    /// Grammatical notions, such as noun, verb, adjective, etc., are roles defined by a grammar, and words (or larger linguistic objects) can play those roles in a given language. E.g., the word 'share' can play both 'verb' and 'noun' roles in contemporary English, while the word 'come' can only play the 'verb' role in English, and the 'adverb' or 'conjunction' roles in Italian (but if we consider a word as only realized by phonemes, i.e. if we consider the oral realizations of 'come', there is no common word 'come' in the two languages).
    /// <see href="http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#Word"></see></summary>
    let Word = _prefix "Word"
    /// <summary>
    /// A word or multiword that is established in some terminology from a domain of discourse.
    /// <see href="http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#Term"></see></summary>
    let Term = _prefix "Term"
    /// <summary>
    /// A communicative situation including linguistic objects, agents, and a set of contexts: physical (informational realizations), conceptual (social objects), and referential (entities).
    /// A linguistic act has an associated CommunicativeFunction that it satisfies.
    /// <see href="http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#LinguisticAct"></see></summary>
    let LinguisticAct = _prefix "LinguisticAct"
    /// <summary>
    /// Any linguistic function that classifies words according to a LinguisticTheory.
    /// This class includes parts of speech, thematic roles, phrase structure components, verbal aspects, etc. e.g. Subject, Object, Instrument, Stative, etc.
    /// Each linguistic function must be defined in a LinguisticTheory; e.g. a thematic role can be defined either in a generative grammar, or in construction-based theory.
    /// <see href="http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#LinguisticFunction"></see></summary>
    let LinguisticFunction = _prefix "LinguisticFunction"
    /// <summary>
    /// Any theory describing the structure and/or production and understanding of a natural language or a set of natural languages, or a component of one or more natural languages.
    /// <see href="http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#LinguisticTheory"></see></summary>
    let LinguisticTheory = _prefix "LinguisticTheory"
    /// <summary>
    /// A natural language, evolved and used in a community across time.
    /// Natural languages components are 'temporary' and 'reconstructed' out of actual usage. For example, a grammar for a (part of a) natural language has the status of a theory for that language, but alternative ones can exist (e.g. generative vs. construction grammars).
    /// <see href="http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#NaturalLanguage"></see></summary>
    let NaturalLanguage = _prefix "NaturalLanguage"
    /// <summary>
    /// A part of a word that can express a meaning, which is part of the meaning of the entire word.
    /// <see href="http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#Morpheme"></see></summary>
    let Morpheme = _prefix "Morpheme"
    /// <summary>
    /// An information realization that realizes heterogeneous information objects. Examples include audiovisual performances, web pages, etc.
    /// <see href="http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#MultimediaObject"></see></summary>
    let MultimediaObject = _prefix "MultimediaObject"
    /// <summary>
    /// wn noun: Graphic art consisting of an artistic composition made by applying paints to a surface; "a small painting by Picasso"; "he bought the painting as an investment"; "his pictures hang in the Louvre"
    /// <see href="http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#Painting"></see></summary>
    let Painting = _prefix "Painting"
    /// <summary>
    /// A part of a word as it can be realized by Voicing
    /// A written information realization can be 'about' a phoneme (as in the case of transcription systems), but it does not 'realize' it: only Grapheme(s) are realized by written information (Writing).
    /// A phoneme is not necessarily able to express a meaning (any dul:SocialObject), although it can in principle (e.g. 'a' in English).
    /// <see href="http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#Phoneme"></see></summary>
    let Phoneme = _prefix "Phoneme"
    /// <summary>
    /// An information realization consisting of uttered sounds. In natural agents, it always co-occurs with bodily movements.
    /// <see href="http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#Voicing"></see></summary>
    let Voicing = _prefix "Voicing"
    /// <summary>
    /// A composition of Word(s) that can be considered a higher syntactic unit than a Word, and dul:isComponentOf a Sentence
    /// <see href="http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#Phrase"></see></summary>
    let Phrase = _prefix "Phrase"
    /// <summary>
    /// A composition of Phrase(s), assumed to express a state of affairs (here modelled as a dul:Situation). Graphically, a period is usually considered its boundary.
    /// <see href="http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#Sentence"></see></summary>
    let Sentence = _prefix "Sentence"
    /// <summary>
    /// wn noun: The arts of shaping or modeling; carving and sculpture
    /// <see href="http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#PlasticArt"></see></summary>
    let PlasticArt = _prefix "PlasticArt"
    /// <summary>
    /// wn noun: A three-dimensional work of plastic art
    /// <see href="http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#Sculpture"></see></summary>
    let Sculpture = _prefix "Sculpture"
    /// <summary>
    /// An information realization consisting of sound waves.
    /// <see href="http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#Sound"></see></summary>
    let Sound = _prefix "Sound"
    /// <summary>
    /// Conventional sounds realizing explicit communication. Speech is a primary code of communication (primary means that is an original body expression, especially if first learnt).
    /// <see href="http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#Speech"></see></summary>
    let Speech = _prefix "Speech"
    /// <summary>
    /// wn noun: A sculpture representing a human or animal
    /// <see href="http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#Statue"></see></summary>
    let Statue = _prefix "Statue"
    /// <summary>
    /// A collection of categories organized according to a specified syntax, typically used to create a controlled terminology in a domain. A useful rdfs encoding of a typical thesaurus syntax is the SKOS schema.
    /// <see href="http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#Thesaurus"></see></summary>
    let Thesaurus = _prefix "Thesaurus"
    /// <summary>
    ///   <see href="http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#WebPage"></see>
    /// </summary>
    let WebPage = _prefix "WebPage"
    /// <summary>
    /// Any relation holding between two FormalExpression(s), e.g. a function over formal grammars, boolean operators, syntactic relations defined for the logical vocabulary of a formal language, etc.
    /// Syntactic relations from logical languages have a correspondance to some formal relation.
    /// <see href="http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#combinatoriallyRelatedTo"></see></summary>
    let combinatoriallyRelatedTo = _prefix "combinatoriallyRelatedTo"
    /// <summary>
    ///   <see href="http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#digitallyReproduces"></see>
    /// </summary>
    let digitallyReproduces = _prefix "digitallyReproduces"
    /// <summary>
    ///   <see href="http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#reproduces"></see>
    /// </summary>
    let reproduces = _prefix "reproduces"
    /// <summary>
    /// The relation between formal expressions, and anything that they are supposed to represent.
    /// E.g., 'the predicate 'MariachiInTijuana' formallyRepresents the dul:Collection of all mariachis in Tijuana'; 'the equivalence relation '&lt;=&gt;' formallyRepresents the Concept of two entities having the same properties', 'the constant 'John' formallyRepresents the dul:NaturalPerson 'John'.
    /// Notice that a FormalExpression isAssignmentOf (is formally interpreted by) instances of dul:FormalEntity.
    ///
    /// formallyRepresents is a particular case of 'dul:isAbout', holding only for formal expressions.
    /// Anyway, a formal expression that  dul:expresses a dul:SocialObject is also possible, but treats formal expressions as any other kind of dul:InformationObject that express a 'social' or 'cognitive' semantics, not a formal one.
    /// <see href="http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#formallyRepresents"></see></summary>
    let formallyRepresents = _prefix "formallyRepresents"
    /// <summary>
    ///   <see href="http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#hasAuthor"></see>
    /// </summary>
    let hasAuthor = _prefix "hasAuthor"
    /// <summary>
    ///   <see href="http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#isAuthorOf"></see>
    /// </summary>
    let isAuthorOf = _prefix "isAuthorOf"
    /// <summary>
    ///   <see href="http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#hasCulturalGrounding"></see>
    /// </summary>
    let hasCulturalGrounding = _prefix "hasCulturalGrounding"
    /// <summary>
    ///   <see href="http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#isCulturalGroundingFor"></see>
    /// </summary>
    let isCulturalGroundingFor = _prefix "isCulturalGroundingFor"
    /// <summary>
    ///   <see href="http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#hasCulturalMixingWith"></see>
    /// </summary>
    let hasCulturalMixingWith = _prefix "hasCulturalMixingWith"
    /// <summary>
    /// The relation between an InformationObject and a FormalExpression (constant, formula, term, sentence, proposition, axiom, etc.) that it is supposed to be given formal interpretation to formalize the InformationObject.
    /// Notice that FormalExpression(s) only are formal terms for InformationObject(s), not for Concept(s) or other for SocialObject(s). On their turn, information object can 'express' (see) SocialObject(s).
    /// E.g., the predicate (FormalExpression) 'TijuanaMariachi' isFormalTermFor the Term 'the mariachis in Tijuana' (that expresses the Collection of all mariachis in Tijuana); the Term 'equivalence relation' (that expresses the Concept of 'two entities having the same properties') hasFormalTerm the '&lt;=&gt;' symbol.
    /// <see href="http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#hasFormalTerm"></see></summary>
    let hasFormalTerm = _prefix "hasFormalTerm"
    /// <summary>
    /// A formal entity is grounded in some other entity when it is assumed as the (formal, extensional) interpretation of it, for example, the set Dog can be grounded in the collection of all actual dogs (or in some of them that the modeller intends).
    /// <see href="http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#hasGrounding"></see></summary>
    let hasGrounding = _prefix "hasGrounding"
    /// <summary>
    ///   <see href="http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#isGroundingFor"></see>
    /// </summary>
    let isGroundingFor = _prefix "isGroundingFor"
    /// <summary>
    /// A relation between social objects and schemata that organize them. For example, a Tag hasSchema a Folksonomy, a Lexeme hasSchema a Lexicon, etc.
    /// <see href="http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#isSchemaOf"></see></summary>
    let isSchemaOf = _prefix "isSchemaOf"
    /// <summary>
    /// The relation between formal expressions, and anything that they are supposed to represent.
    /// E.g., 'the predicate 'MariachiInTijuana' formallyRepresents the dul:Collection of all mariachis in Tijuana'; 'the equivalence relation '&lt;=&gt;' formallyRepresents the concept of two entities having the same properties', 'the constant 'John' formallyRepresents the dul:NaturalPerson John.
    /// Notice that formal expressions are formally interpreted by instances of dul:FormalEntity
    /// <see href="http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#isFormallyRepresentedIn"></see></summary>
    let isFormallyRepresentedIn = _prefix "isFormallyRepresentedIn"
    /// <summary>
    /// The relation between a FormalExpression, and an Entity (a FormalEntity in case of classes, relations, etc.) that it is supposed to be the reference of the symbol (FormalExpression) that the Entity is an intepretation of.
    /// In other words, this property expresses the 'formal interpretation' function, by which a logician 'assigns' an Entity to a FormalExpression.
    /// For each type of formal expressions defined in a logical language, an assignment assumption should be indicated, for example, owl:Class should be restricted to: isAssignmentOf allValuesFrom Class. In addition, differently from the general relation formallyRepresents, isAssignmentOf is functional (and its inverse is inverse functional), in order to encode the Tarskian correspondence assumption.
    /// E.g., the Set of 'all mariachis in Tijuana' isAssignedTo the predicate (FormalExpression) 'TijuanaMariachi' (that isFormalTermFor a Term e.g. 'the mariachis in Tijuana').
    /// <see href="http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#isAssignmentOf"></see></summary>
    let isAssignmentOf = _prefix "isAssignmentOf"
    /// <summary>
    /// The original information realization of some copy. Differently from reproductions, copies are not planned to have notable differences from the original. Master copies, author-signed paintings, etc. are examples of originals.
    /// <see href="http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#isCopyOf"></see></summary>
    let isCopyOf = _prefix "isCopyOf"
    /// <summary>
    ///   <see href="http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#isDigitallyReproducedBy"></see>
    /// </summary>
    let isDigitallyReproducedBy = _prefix "isDigitallyReproducedBy"
    /// <summary>
    ///   <see href="http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#isReproducedBy"></see>
    /// </summary>
    let isReproducedBy = _prefix "isReproducedBy"
    /// <summary>
    /// A relation between linguistic objects and other information objects (including other linguistic objects).
    /// For example, 'dog' can lexicalize a picture of a dog, a linguistic description of a dog, or the logical class: 'Dog'.
    /// This relation is a subPropertyOf encodes .
    /// In case of FormalExpression(s), it is not the inverse of isFormalTermFor: formal expressions can be said to 'be formal terms' for a LinguisticObject(s), while, independently, linguistic objects can be said to 'lexicalize' formal expressions. The difference is mainly pragmatic: one can take e.g. the word Dog, and decide to have a logical class 'Dog' for it. Someone else can see the logical class 'Dog', and decide to lexicalize it with the words dog, chien, cane, etc. While the relation seems similar, the pragmatic of using them is very different.
    /// <see href="http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#isLexicalizedBy"></see></summary>
    let isLexicalizedBy = _prefix "isLexicalizedBy"
    /// <summary>
    /// A relation between linguistic objects and other information objects (including other linguistic objects).
    /// For example, 'dog' can lexicalize a picture of a dog, a linguistic description of a dog, or the logical class: 'Dog'.
    /// This relation is a subPropertyOf encodes .
    /// In case of FormalExpression(s), it is not the inverse of isFormalTermFor: formal expressions can be said to 'be formal terms' for a LinguisticObject(s), while, independently, linguistic objects can be said to 'lexicalize' formal expressions. The difference is mainly pragmatic: one can take e.g. the word Dog, and decide to have a logical class 'Dog' for it. Someone else can see the logical class 'Dog', and decide to lexicalize it with the words dog, chien, cane, etc. While the relation seems similar, the pragmatic of using them is very different.
    /// <see href="http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#lexicalizes"></see></summary>
    let lexicalizes = _prefix "lexicalizes"
    /// <summary>
    ///   <see href="http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#isOriginalOf"></see>
    /// </summary>
    let isOriginalOf = _prefix "isOriginalOf"
    /// <summary>
    ///   <see href="http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#isRepresentationLanguageOf"></see>
    /// </summary>
    let isRepresentationLanguageOf = _prefix "isRepresentationLanguageOf"
    /// <summary>
    ///   <see href="http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#isReusedBy"></see>
    /// </summary>
    let isReusedBy = _prefix "isReusedBy"
    /// <summary>
    /// This property can be used to relate two social objects that are associated by means of a metaphorical blending, e.g. Greek and Aegyptian sphinges.
    /// <see href="http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#metaphoricallyBlendsWith"></see></summary>
    let metaphoricallyBlendsWith = _prefix "metaphoricallyBlendsWith"
    /// <summary>
    /// Any relation between information entities, where the first one reuses (includes, transforms, reengineers, etc.) the second one.
    /// <see href="http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#reuses"></see></summary>
    let reuses = _prefix "reuses"
