#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module iol =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#" "iol"

    /// <summary>
    ///   <para>rdfs:comment : An information realization consisting of bodily movements.^^xsd:string</para>
    ///   <para>rdfs:label : Movimento corporeordfs:label : Bodily motion</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#BodilyMotion">iol:BodilyMotion</a>
    /// </summary>
    let BodilyMotion = _prefixId.prefix "BodilyMotion"
    /// <summary>
    ///   <para>rdfs:comment : Any piece of information expressing computational operations, objects, markup, etc.^^xsd:string</para>
    ///   <para>rdfs:label : Codicerdfs:label : Code</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#Code">iol:Code</a>
    /// </summary>
    let Code = _prefixId.prefix "Code"
    /// <summary>
    ///   <para>rdfs:comment : The functions, e.g. defined by Jakobson and by Buhler, which define types of linguistic acts. Jakobson's ones include referential, conative, expressive, phatic, metalinguistic, poetic. Each function has typical roles and tasks that must be played during a linguistic act that achieves the function.^^xsd:string</para>
    ///   <para>rdfs:label : Funzione comunicativardfs:label : Communicative function</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#CommunicativeFunction">iol:CommunicativeFunction</a>
    /// </summary>
    let CommunicativeFunction = _prefixId.prefix "CommunicativeFunction"
    /// <summary>
    ///   <para>rdfs:comment : The text of a contract^^xsd:string</para>
    ///   <para>rdfs:label : Testo di un contrattordfs:label : Contract text</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#ContractText">iol:ContractText</a>
    /// </summary>
    let ContractText = _prefixId.prefix "ContractText"
    /// <summary>
    ///   <para>rdfs:comment : Any conceptual, logical or physical schema for a database.^^xsd:string</para>
    ///   <para>rdfs:label : Schema di base di datirdfs:label : Database schema</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#DBSchema">iol:DBSchema</a>
    /// </summary>
    let DBSchema = _prefixId.prefix "DBSchema"
    /// <summary>
    ///   <para>rdfs:comment : Any data structure, including databases, schemas, lexica, knowledge organizations systems, etc.^^xsd:string</para>
    ///   <para>rdfs:label : Struttura di datirdfs:label : Data structure</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#DataStructure">iol:DataStructure</a>
    /// </summary>
    let DataStructure = _prefixId.prefix "DataStructure"
    /// <summary>
    ///   <para>rdfs:comment : From WordNet: 'an item of factual information derived from measurement or research'^^xsd:string</para>
    ///   <para>rdfs:label : Datordfs:label : Datum</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#Datum">iol:Datum</a>
    /// </summary>
    let Datum = _prefixId.prefix "Datum"
    /// <summary>
    ///   <para>rdfs:comment : An information realization consisting of depicted images/signs of any sort (e.g. graffiti, drawings, inscriptions, pictures, sculptures, etc.), which are inscripted on a medium that lasts longer than the depicting act.
    /// It also includes any early form of inscripted iconic expression, which can be considered as original bodily expressions.^^xsd:string</para>
    ///   <para>rdfs:label : Realizzazione visivardfs:label : Depiction</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#Depiction">iol:Depiction</a>
    /// </summary>
    let Depiction = _prefixId.prefix "Depiction"
    /// <summary>
    ///   <para>rdfs:label : Digital photo</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#DigitalPhoto">iol:DigitalPhoto</a>
    /// </summary>
    let DigitalPhoto = _prefixId.prefix "DigitalPhoto"
    /// <summary>
    ///   <para>rdfs:comment : Any resource that can be computed, e.g. a file, a piece of (implemented) software. This assumes an encoding allowing the computation (e.g. html+http protocol).^^xsd:string</para>
    ///   <para>rdfs:label : Risorsa digitalerdfs:label : Digital resource</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#DigitalResource">iol:DigitalResource</a>
    /// </summary>
    let DigitalResource = _prefixId.prefix "DigitalResource"
    /// <summary>
    ///   <para>rdfs:comment : wn noun: A representation of forms or objects on a surface by means of lines; "drawings of abstract forms"; "he did complicated pen-and-ink drawings like medieval miniatures"^^xsd:string</para>
    ///   <para>rdfs:label : Disegnordfs:label : Drawing</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#Drawing">iol:Drawing</a>
    /// </summary>
    let Drawing = _prefixId.prefix "Drawing"
    /// <summary>
    ///   <para>rdfs:comment : Any information object represented in a FormalLanguage, usually having a formal interpretation by a dul:FormalEntity, and used to formally represent any Entity^^xsd:string</para>
    ///   <para>rdfs:label : Espressione formalerdfs:label : Formal expression</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#FormalExpression">iol:FormalExpression</a>
    /// </summary>
    let FormalExpression = _prefixId.prefix "FormalExpression"
    /// <summary>
    ///   <para>rdfs:comment : A formal language, created by some human, with a fixed grammar, and usually with an explicit formal semantics (i.e. any FormalExpression that is a wff or a valid element of a FormalLanguage has an interpretation wrt to formal entities such as sets, categories, etc.).^^xsd:string</para>
    ///   <para>rdfs:label : Linguaggio formalerdfs:label : Formal language</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#FormalLanguage">iol:FormalLanguage</a>
    /// </summary>
    let FormalLanguage = _prefixId.prefix "FormalLanguage"
    /// <summary>
    ///   <para>rdfs:label : Gestordfs:label : Gesture</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#Gesture">iol:Gesture</a>
    /// </summary>
    let Gesture = _prefixId.prefix "Gesture"
    /// <summary>
    ///   <para>rdfs:comment : A part of a word as it can be realized by Writing
    /// A spoken information realization can be 'about' a grapheme (as in reading), but it does not 'realize' it. Only Phoneme(s) are realized by spoken information (Voicing).
    /// BTW, since spoken realizations are a 'primary' code of communication, the difference between direct and indirect spoken realizations (reading) should be considered relevant.
    /// A grapheme is not necessarily able to express a meaning (a dul:SocialObject), although it can in principle (e.g. 'a' in English).^^xsd:string</para>
    ///   <para>rdfs:label : Grafemardfs:label : Grapheme</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#Grapheme">iol:Grapheme</a>
    /// </summary>
    let Grapheme = _prefixId.prefix "Grapheme"
    /// <summary>
    ///   <para>rdfs:comment : wn noun: The arts of drawing or painting or printmaking^^xsd:string</para>
    ///   <para>rdfs:label : Opera graficardfs:label : Graphic art</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#GraphicArt">iol:GraphicArt</a>
    /// </summary>
    let GraphicArt = _prefixId.prefix "GraphicArt"
    /// <summary>
    ///   <para>rdfs:comment : A language made up of graphical elements. It can be natural, artificial, and even formal.^^xsd:string</para>
    ///   <para>rdfs:label : Linguaggio iconicordfs:label : Iconic language</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#IconicLanguage">iol:IconicLanguage</a>
    /// </summary>
    let IconicLanguage = _prefixId.prefix "IconicLanguage"
    /// <summary>
    ///   <para>rdfs:comment : An information object represented in an IconicLanguage^^xsd:string</para>
    ///   <para>rdfs:label : Oggetto iconicordfs:label : Iconic object</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#IconicObject">iol:IconicObject</a>
    /// </summary>
    let IconicObject = _prefixId.prefix "IconicObject"
    /// <summary>
    ///   <para>rdfs:comment : Knowledge Organization Systems: thesauri, terminologies, classification schemes, subject hierarchies, etc.^^xsd:string</para>
    ///   <para>rdfs:label : Sistema di organizzazione della conoscenzardfs:label : Knowledge organization system</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#KOS">iol:KOS</a>
    /// </summary>
    let KOS = _prefixId.prefix "KOS"
    /// <summary>
    ///   <para>rdfs:comment : A natural or artificial language, provided with an alphabet (or vocabulary) and combinatorial rules. In the case of natural languages, their components are 'temporary' and 'reconstructed' out of actual usage. For example, a grammar for a natural language has the status of a theory for that language, and alternative ones can exist (e.g. generative vs. construction grammars).
    /// Another distinction, between the general (systemic) rules for a language, and the local (contextual) rules for e.g. a certain context, speaker, place, etc., can be made separately.
    /// The most comprehensive classification of languages ha probably been made by Umberto Eco, based on the production modes of the 'signs' that are represented in a certain language. It uses several semiotic dimensions, and will be modeled in a forthcoming ontology.^^xsd:string</para>
    ///   <para>rdfs:label : Linguaggiordfs:label : Language</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#Language">iol:Language</a>
    /// </summary>
    let Language = _prefixId.prefix "Language"
    /// <summary>
    ///   <para>rdfs:comment : Lexical entries for dictionaries, lexica, etc. They are used to create reference forms of words.^^xsd:string</para>
    ///   <para>rdfs:label : Lessemardfs:label : Lexeme</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#Lexeme">iol:Lexeme</a>
    /// </summary>
    let Lexeme = _prefixId.prefix "Lexeme"
    /// <summary>
    ///   <para>rdfs:comment : A collection of lexical items (terms, entries, ...) that are witnessed to have a linguistic relevance.^^xsd:string</para>
    ///   <para>rdfs:label : Lessicordfs:label : Lexicon</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#Lexicon">iol:Lexicon</a>
    /// </summary>
    let Lexicon = _prefixId.prefix "Lexicon"
    /// <summary>
    ///   <para>rdfs:label : Atto linguisticordfs:label : Linguistic act</para>
    ///   <para>rdfs:comment : A communicative situation including linguistic objects, agents, and a set of contexts: physical (informational realizations), conceptual (social objects), and referential (entities).
    /// A linguistic act has an associated CommunicativeFunction that it satisfies.^^xsd:string</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#LinguisticAct">iol:LinguisticAct</a>
    /// </summary>
    let LinguisticAct = _prefixId.prefix "LinguisticAct"
    /// <summary>
    ///   <para>rdfs:comment : Any linguistic function that classifies words according to a LinguisticTheory.
    /// This class includes parts of speech, thematic roles, phrase structure components, verbal aspects, etc. e.g. Subject, Object, Instrument, Stative, etc.
    /// Each linguistic function must be defined in a LinguisticTheory; e.g. a thematic role can be defined either in a generative grammar, or in construction-based theory.^^xsd:string</para>
    ///   <para>rdfs:label : Funzione linguisticardfs:label : Linguistic function</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#LinguisticFunction">iol:LinguisticFunction</a>
    /// </summary>
    let LinguisticFunction = _prefixId.prefix "LinguisticFunction"
    /// <summary>
    ///   <para>rdfs:comment : An information object represented in a NaturalLanguage^^xsd:string</para>
    ///   <para>rdfs:label : Oggetto linguisticordfs:label : Linguistic object</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#LinguisticObject">iol:LinguisticObject</a>
    /// </summary>
    let LinguisticObject = _prefixId.prefix "LinguisticObject"
    /// <summary>
    ///   <para>rdfs:comment : Any theory describing the structure and/or production and understanding of a natural language or a set of natural languages, or a component of one or more natural languages.^^xsd:string</para>
    ///   <para>rdfs:label : Teoria linguisticardfs:label : Linguistic theory</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#LinguisticTheory">iol:LinguisticTheory</a>
    /// </summary>
    let LinguisticTheory = _prefixId.prefix "LinguisticTheory"
    /// <summary>
    ///   <para>rdfs:comment : A part of a word that can express a meaning, which is part of the meaning of the entire word.^^xsd:string</para>
    ///   <para>rdfs:label : Morfemardfs:label : Morpheme</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#Morpheme">iol:Morpheme</a>
    /// </summary>
    let Morpheme = _prefixId.prefix "Morpheme"
    /// <summary>
    ///   <para>rdfs:comment : An information realization that realizes heterogeneous information objects. Examples include audiovisual performances, web pages, etc.^^xsd:string</para>
    ///   <para>rdfs:label : Oggetto multimedialerdfs:label : Multimedia object</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#MultimediaObject">iol:MultimediaObject</a>
    /// </summary>
    let MultimediaObject = _prefixId.prefix "MultimediaObject"
    /// <summary>
    ///   <para>rdfs:comment : A LinguisticObject made up of more than one Word, but distinct from a Phrase, which is a higher syntactic unit.^^xsd:string</para>
    ///   <para>rdfs:label : Lemma polirematicordfs:label : Polyrhematic unit</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#Multiword">iol:Multiword</a>
    /// </summary>
    let Multiword = _prefixId.prefix "Multiword"
    /// <summary>
    ///   <para>rdfs:comment : A natural language, evolved and used in a community across time.
    /// Natural languages components are 'temporary' and 'reconstructed' out of actual usage. For example, a grammar for a (part of a) natural language has the status of a theory for that language, but alternative ones can exist (e.g. generative vs. construction grammars).^^xsd:string</para>
    ///   <para>rdfs:label : Linguaggio naturalerdfs:label : Natural language</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#NaturalLanguage">iol:NaturalLanguage</a>
    /// </summary>
    let NaturalLanguage = _prefixId.prefix "NaturalLanguage"
    /// <summary>
    ///   <para>rdfs:comment : wn noun: Graphic art consisting of an artistic composition made by applying paints to a surface; "a small painting by Picasso"; "he bought the painting as an investment"; "his pictures hang in the Louvre"^^xsd:string</para>
    ///   <para>rdfs:label : Dipintordfs:label : Painting</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#Painting">iol:Painting</a>
    /// </summary>
    let Painting = _prefixId.prefix "Painting"
    /// <summary>
    ///   <para>rdfs:comment : A part of a word as it can be realized by Voicing
    /// A written information realization can be 'about' a phoneme (as in the case of transcription systems), but it does not 'realize' it: only Grapheme(s) are realized by written information (Writing).
    /// A phoneme is not necessarily able to express a meaning (any dul:SocialObject), although it can in principle (e.g. 'a' in English).^^xsd:string</para>
    ///   <para>rdfs:label : Fonemardfs:label : Phoneme</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#Phoneme">iol:Phoneme</a>
    /// </summary>
    let Phoneme = _prefixId.prefix "Phoneme"
    /// <summary>
    ///   <para>rdfs:comment : A composition of Word(s) that can be considered a higher syntactic unit than a Word, and dul:isComponentOf a Sentence^^xsd:string</para>
    ///   <para>rdfs:label : Proposizionerdfs:label : Phrase</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#Phrase">iol:Phrase</a>
    /// </summary>
    let Phrase = _prefixId.prefix "Phrase"
    /// <summary>
    ///   <para>rdfs:comment : wn noun: The arts of shaping or modeling; carving and sculpture^^xsd:string</para>
    ///   <para>rdfs:label : Opera plasticardfs:label : Plastic art</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#PlasticArt">iol:PlasticArt</a>
    /// </summary>
    let PlasticArt = _prefixId.prefix "PlasticArt"
    /// <summary>
    ///   <para>rdfs:comment : wn noun: A three-dimensional work of plastic art^^xsd:string</para>
    ///   <para>rdfs:label : Sculturardfs:label : Sculpture</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#Sculpture">iol:Sculpture</a>
    /// </summary>
    let Sculpture = _prefixId.prefix "Sculpture"
    /// <summary>
    ///   <para>rdfs:comment : A composition of Phrase(s), assumed to express a state of affairs (here modelled as a dul:Situation). Graphically, a period is usually considered its boundary.^^xsd:string</para>
    ///   <para>rdfs:label : Fraserdfs:label : Sentence</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#Sentence">iol:Sentence</a>
    /// </summary>
    let Sentence = _prefixId.prefix "Sentence"
    /// <summary>
    ///   <para>rdfs:comment : An information realization consisting of sound waves.^^xsd:string</para>
    ///   <para>rdfs:label : Sound</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#Sound">iol:Sound</a>
    /// </summary>
    let Sound = _prefixId.prefix "Sound"
    /// <summary>
    ///   <para>rdfs:comment : Conventional sounds realizing explicit communication. Speech is a primary code of communication (primary means that is an original body expression, especially if first learnt).^^xsd:string</para>
    ///   <para>rdfs:label : Discorsordfs:label : Speech</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#Speech">iol:Speech</a>
    /// </summary>
    let Speech = _prefixId.prefix "Speech"
    /// <summary>
    ///   <para>rdfs:comment : wn noun: A sculpture representing a human or animal^^xsd:string</para>
    ///   <para>rdfs:label : Statuardfs:label : Statue</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#Statue">iol:Statue</a>
    /// </summary>
    let Statue = _prefixId.prefix "Statue"
    /// <summary>
    ///   <para>rdfs:comment : A word or multiword that is established in some terminology from a domain of discourse.^^xsd:string</para>
    ///   <para>rdfs:label : Terminerdfs:label : Term</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#Term">iol:Term</a>
    /// </summary>
    let Term = _prefixId.prefix "Term"
    /// <summary>
    ///   <para>rdfs:comment : A LinguisticObject composed of at least one Sentence, and assumed to be realized in written form.^^xsd:string</para>
    ///   <para>rdfs:label : Testordfs:label : Text</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#Text">iol:Text</a>
    /// </summary>
    let Text = _prefixId.prefix "Text"
    /// <summary>
    ///   <para>rdfs:comment : A collection of categories organized according to a specified syntax, typically used to create a controlled terminology in a domain. A useful rdfs encoding of a typical thesaurus syntax is the SKOS schema.^^xsd:string</para>
    ///   <para>rdfs:label : Tesaurordfs:label : Thesaurus</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#Thesaurus">iol:Thesaurus</a>
    /// </summary>
    let Thesaurus = _prefixId.prefix "Thesaurus"
    /// <summary>
    ///   <para>rdfs:comment : An information realization consisting of uttered sounds. In natural agents, it always co-occurs with bodily movements.^^xsd:string</para>
    ///   <para>rdfs:label : Vocalizzazionerdfs:label : Voicing</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#Voicing">iol:Voicing</a>
    /// </summary>
    let Voicing = _prefixId.prefix "Voicing"
    /// <summary>
    ///   <para>rdfs:label : Web page</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#WebPage">iol:WebPage</a>
    /// </summary>
    let WebPage = _prefixId.prefix "WebPage"
    /// <summary>
    ///   <para>rdfs:comment : A linguistic object consisting of a string (independently of its physical realization).
    /// Its topological unity can change according to its physical realization: as a written realization, its boundaries are blank spaces, as a spoken realization, sometimes is silence, sometimes not, and higher order features intervene.
    /// Grammatical notions, such as noun, verb, adjective, etc., are roles defined by a grammar, and words (or larger linguistic objects) can play those roles in a given language. E.g., the word 'share' can play both 'verb' and 'noun' roles in contemporary English, while the word 'come' can only play the 'verb' role in English, and the 'adverb' or 'conjunction' roles in Italian (but if we consider a word as only realized by phonemes, i.e. if we consider the oral realizations of 'come', there is no common word 'come' in the two languages).^^xsd:string</para>
    ///   <para>rdfs:label : Parolardfs:label : Word</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#Word">iol:Word</a>
    /// </summary>
    let Word = _prefixId.prefix "Word"
    /// <summary>
    ///   <para>rdfs:comment : An information realization based on conventional symbols.
    /// It is a secondary code of communication (secondary means that it is about an original bodily expression, i.e. a primary code). Therefore, we are not considering here early forms of iconic expression, which could be considered primary.^^xsd:string</para>
    ///   <para>rdfs:label : Realizzazione scrittardfs:label : Writing</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#Writing">iol:Writing</a>
    /// </summary>
    let Writing = _prefixId.prefix "Writing"
    /// <summary>
    ///   <para>rdfs:comment : Any relation holding between two FormalExpression(s), e.g. a function over formal grammars, boolean operators, syntactic relations defined for the logical vocabulary of a formal language, etc.
    /// Syntactic relations from logical languages have a correspondance to some formal relation.^^xsd:string</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#combinatoriallyRelatedTo">iol:combinatoriallyRelatedTo</a>
    /// </summary>
    let combinatoriallyRelatedTo = _prefixId.prefix "combinatoriallyRelatedTo"
    /// <summary>
    ///   <para>rdfs:label : riproduce digitalmenterdfs:label : digitally reproduces</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#digitallyReproduces">iol:digitallyReproduces</a>
    /// </summary>
    let digitallyReproduces = _prefixId.prefix "digitallyReproduces"
    /// <summary>
    ///   <para>rdfs:comment : Any relation between two information entities, with the first used as an alternative encoding of the second. This encoding can preserve all or part of the informational structure. For example, an XML encoding of a plain text file, a digital scanning of a physical paper document, a reproduction of a painting, etc.
    /// The encoding can be so precise and close to the medium of realization, that distinguishing the maximally encoded object from its realization is superfluous (as in many cases of computer science information entities). For this reason, the relation holds for either dul:InformationObject(s) or dul:InformationRealization(s).
    /// Since the relation holds for either dul:InformationObject(s) or dul:InformationRealization(s), dul:realizes is a subproperty of it.^^xsd:string</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#encodes">iol:encodes</a>
    /// </summary>
    let encodes = _prefixId.prefix "encodes"
    /// <summary>
    ///   <para>rdfs:comment : The relation between formal expressions, and anything that they are supposed to represent.
    /// E.g., 'the predicate 'MariachiInTijuana' formallyRepresents the dul:Collection of all mariachis in Tijuana'; 'the equivalence relation '&lt;=&gt;' formallyRepresents the Concept of two entities having the same properties', 'the constant 'John' formallyRepresents the dul:NaturalPerson 'John'.
    /// Notice that a FormalExpression isAssignmentOf (is formally interpreted by) instances of dul:FormalEntity.
    ///
    /// formallyRepresents is a particular case of 'dul:isAbout', holding only for formal expressions.
    /// Anyway, a formal expression that  dul:expresses a dul:SocialObject is also possible, but treats formal expressions as any other kind of dul:InformationObject that express a 'social' or 'cognitive' semantics, not a formal one.^^xsd:string</para>
    ///   <para>rdfs:label : rappresenta formalmenterdfs:label : formally represents</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#formallyRepresents">iol:formallyRepresents</a>
    /// </summary>
    let formallyRepresents = _prefixId.prefix "formallyRepresents"
    /// <summary>
    ///   <para>rdfs:label : ha come autorerdfs:label : has author</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#hasAuthor">iol:hasAuthor</a>
    /// </summary>
    let hasAuthor = _prefixId.prefix "hasAuthor"
    /// <summary>
    ///   <para>rdfs:label : ha sorgente culturalerdfs:label : has cultural grounding</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#hasCulturalGrounding">iol:hasCulturalGrounding</a>
    /// </summary>
    let hasCulturalGrounding = _prefixId.prefix "hasCulturalGrounding"
    /// <summary>
    ///   <para>rdfs:label : ha una fusione culturale conrdfs:label : has cultural mixing with</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#hasCulturalMixingWith">iol:hasCulturalMixingWith</a>
    /// </summary>
    let hasCulturalMixingWith = _prefixId.prefix "hasCulturalMixingWith"
    /// <summary>
    ///   <para>rdfs:comment : The relation between an InformationObject and a FormalExpression (constant, formula, term, sentence, proposition, axiom, etc.) that it is supposed to be given formal interpretation to formalize the InformationObject.
    /// Notice that FormalExpression(s) only are formal terms for InformationObject(s), not for Concept(s) or other for SocialObject(s). On their turn, information object can 'express' (see) SocialObject(s).
    /// E.g., the predicate (FormalExpression) 'TijuanaMariachi' isFormalTermFor the Term 'the mariachis in Tijuana' (that expresses the Collection of all mariachis in Tijuana); the Term 'equivalence relation' (that expresses the Concept of 'two entities having the same properties') hasFormalTerm the '&lt;=&gt;' symbol.^^xsd:string</para>
    ///   <para>rdfs:label : ha termine formalerdfs:label : has formal term</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#hasFormalTerm">iol:hasFormalTerm</a>
    /// </summary>
    let hasFormalTerm = _prefixId.prefix "hasFormalTerm"
    /// <summary>
    ///   <para>rdfs:comment : A formal entity is grounded in some other entity when it is assumed as the (formal, extensional) interpretation of it, for example, the set Dog can be grounded in the collection of all actual dogs (or in some of them that the modeller intends).^^xsd:string</para>
    ///   <para>rdfs:label : has grounding</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#hasGrounding">iol:hasGrounding</a>
    /// </summary>
    let hasGrounding = _prefixId.prefix "hasGrounding"
    /// <summary>
    ///   <para>rdfs:label : ha linguaggio di rappresentazionerdfs:label : has representation language</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#hasRepresentationLanguage">iol:hasRepresentationLanguage</a>
    /// </summary>
    let hasRepresentationLanguage = _prefixId.prefix "hasRepresentationLanguage"
    /// <summary>
    ///   <para>rdfs:comment : A relation between social objects and schemata that organize them. For example, a Tag hasSchema a Folksonomy, a Lexeme hasSchema a Lexicon, etc.^^xsd:string</para>
    ///   <para>rdfs:label : ha schemardfs:label : has schema</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#hasSchema">iol:hasSchema</a>
    /// </summary>
    let hasSchema = _prefixId.prefix "hasSchema"
    /// <summary>
    ///   <para>rdfs:comment : The relation between a FormalExpression, and an Entity (a FormalEntity in case of classes, relations, etc.) that it is supposed to be the reference of the symbol (FormalExpression) that the Entity is an intepretation of.
    /// In other words, this is the 'formal interpretation' function, by which a logician 'assigns' an Entity to a FormalExpression.
    /// For each type of formal expressions defined in a logical language, an assignment assumption should be indicated, for example, owl:Class should be restricted to: isAssignmentOf allValuesFrom Class. In addition, differently from the general relation formallyRepresents, isAssignmentOf is functional (and its inverse is inverse functional), in order to encode the Tarskian correspondence assumption.
    /// E.g., the Set of 'all mariachis in Tijuana' isAssignedTo the predicate (FormalExpression) 'TijuanaMariachi' (that isFormalTermFor a Term e.g. 'the mariachis in Tijuana').^^xsd:string</para>
    ///   <para>rdfs:label : è assegnata ardfs:label : interpreta formalmente {@it}^^xsd:stringrdfs:label : formally interprets {@en}^^xsd:string</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#isAssignedTo">iol:isAssignedTo</a>
    /// </summary>
    let isAssignedTo = _prefixId.prefix "isAssignedTo"
    /// <summary>
    ///   <para>rdfs:label : è interpretata formalmente comerdfs:label : è assegnazione dirdfs:label : is formally interpreted as</para>
    ///   <para>rdfs:comment : The relation between a FormalExpression, and an Entity (a FormalEntity in case of classes, relations, etc.) that it is supposed to be the reference of the symbol (FormalExpression) that the Entity is an intepretation of.
    /// In other words, this property expresses the 'formal interpretation' function, by which a logician 'assigns' an Entity to a FormalExpression.
    /// For each type of formal expressions defined in a logical language, an assignment assumption should be indicated, for example, owl:Class should be restricted to: isAssignmentOf allValuesFrom Class. In addition, differently from the general relation formallyRepresents, isAssignmentOf is functional (and its inverse is inverse functional), in order to encode the Tarskian correspondence assumption.
    /// E.g., the Set of 'all mariachis in Tijuana' isAssignedTo the predicate (FormalExpression) 'TijuanaMariachi' (that isFormalTermFor a Term e.g. 'the mariachis in Tijuana').^^xsd:string</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#isAssignmentOf">iol:isAssignmentOf</a>
    /// </summary>
    let isAssignmentOf = _prefixId.prefix "isAssignmentOf"
    /// <summary>
    ///   <para>rdfs:label : è autore dirdfs:label : is author of</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#isAuthorOf">iol:isAuthorOf</a>
    /// </summary>
    let isAuthorOf = _prefixId.prefix "isAuthorOf"
    /// <summary>
    ///   <para>rdfs:comment : The original information realization of some copy. Differently from reproductions, copies are not planned to have notable differences from the original. Master copies, author-signed paintings, etc. are examples of originals.^^xsd:string</para>
    ///   <para>rdfs:label : è copia dirdfs:label : is copy of</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#isCopyOf">iol:isCopyOf</a>
    /// </summary>
    let isCopyOf = _prefixId.prefix "isCopyOf"
    /// <summary>
    ///   <para>rdfs:label : è una sorgente culturale perrdfs:label : is cultural grounding for</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#isCulturalGroundingFor">iol:isCulturalGroundingFor</a>
    /// </summary>
    let isCulturalGroundingFor = _prefixId.prefix "isCulturalGroundingFor"
    /// <summary>
    ///   <para>rdfs:label : è digitalmente riprodotto dardfs:label : is digitally reproduced by</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#isDigitallyReproducedBy">iol:isDigitallyReproducedBy</a>
    /// </summary>
    let isDigitallyReproducedBy = _prefixId.prefix "isDigitallyReproducedBy"
    /// <summary>
    ///   <para>rdfs:comment : Any relation between two information entities, with the first used as an alternative encoding of the second. This encoding can preserve all or part of the informational structure. For example, an XML encoding of a plain text file, a digital scanning of a physical paper document, a reproduction of a painting, etc.
    /// The encoding can be so precise and close to the medium of realization, that distinguishing the maximally encoded object from its realization is superfluous (as in many cases of computer science information entities). For this reason, the relation holds for either dul:InformationObject(s) or dul:InformationRealization(s).
    /// Since the relation holds for either dul:InformationObject(s) or dul:InformationRealization(s), dul:realizes is a subproperty of it.^^xsd:string</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#isEncodedBy">iol:isEncodedBy</a>
    /// </summary>
    let isEncodedBy = _prefixId.prefix "isEncodedBy"
    /// <summary>
    ///   <para>rdfs:comment : The relation between an InformationObject and a FormalExpression (constant, formula, term, sentence, proposition, axiom, etc.) that it is supposed to be given formal interpretation to formalize the InformationObject.
    /// Notice that FormalExpression(s) only are formal terms for InformationObject(s), not for Concept(s) or for other SocialObject(s). On their turn, information object can 'express' (see) SocialObject(s).
    /// E.g., the predicate (FormalExpression) 'TijuanaMariachi' isFormalTermFor the Term 'the mariachis in Tijuana' (that expresses the Collection of all mariachis in Tijuana); the Term 'equivalence relation' (that expresses the Concept of 'two entities having the same properties') hasFormalTerm the '&lt;=&gt;' symbol.^^xsd:string</para>
    ///   <para>rdfs:label : è termine formale perrdfs:label : is formal term for</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#isFormalTermFor">iol:isFormalTermFor</a>
    /// </summary>
    let isFormalTermFor = _prefixId.prefix "isFormalTermFor"
    /// <summary>
    ///   <para>rdfs:comment : The relation between formal expressions, and anything that they are supposed to represent.
    /// E.g., 'the predicate 'MariachiInTijuana' formallyRepresents the dul:Collection of all mariachis in Tijuana'; 'the equivalence relation '&lt;=&gt;' formallyRepresents the concept of two entities having the same properties', 'the constant 'John' formallyRepresents the dul:NaturalPerson John.
    /// Notice that formal expressions are formally interpreted by instances of dul:FormalEntity^^xsd:string</para>
    ///   <para>rdfs:label : è rappresentato formalmente inrdfs:label : is formally represented in</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#isFormallyRepresentedIn">iol:isFormallyRepresentedIn</a>
    /// </summary>
    let isFormallyRepresentedIn = _prefixId.prefix "isFormallyRepresentedIn"
    /// <summary>
    ///   <para>rdfs:label : is grounding for</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#isGroundingFor">iol:isGroundingFor</a>
    /// </summary>
    let isGroundingFor = _prefixId.prefix "isGroundingFor"
    /// <summary>
    ///   <para>rdfs:comment : A relation between linguistic objects and other information objects (including other linguistic objects).
    /// For example, 'dog' can lexicalize a picture of a dog, a linguistic description of a dog, or the logical class: 'Dog'.
    /// This relation is a subPropertyOf encodes .
    /// In case of FormalExpression(s), it is not the inverse of isFormalTermFor: formal expressions can be said to 'be formal terms' for a LinguisticObject(s), while, independently, linguistic objects can be said to 'lexicalize' formal expressions. The difference is mainly pragmatic: one can take e.g. the word Dog, and decide to have a logical class 'Dog' for it. Someone else can see the logical class 'Dog', and decide to lexicalize it with the words dog, chien, cane, etc. While the relation seems similar, the pragmatic of using them is very different.^^xsd:string</para>
    ///   <para>rdfs:label : è lessicalizzato dardfs:label : is lexicalized by</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#isLexicalizedBy">iol:isLexicalizedBy</a>
    /// </summary>
    let isLexicalizedBy = _prefixId.prefix "isLexicalizedBy"
    /// <summary>
    ///   <para>rdfs:label : è l'originale dirdfs:label : is original of</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#isOriginalOf">iol:isOriginalOf</a>
    /// </summary>
    let isOriginalOf = _prefixId.prefix "isOriginalOf"
    /// <summary>
    ///   <para>rdfs:label : è il linguaggio di rappresentazione dirdfs:label : is representation language of</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#isRepresentationLanguageOf">iol:isRepresentationLanguageOf</a>
    /// </summary>
    let isRepresentationLanguageOf = _prefixId.prefix "isRepresentationLanguageOf"
    /// <summary>
    ///   <para>rdfs:label : è riprodotto dardfs:label : is reproduced by</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#isReproducedBy">iol:isReproducedBy</a>
    /// </summary>
    let isReproducedBy = _prefixId.prefix "isReproducedBy"
    let isReusedBy = _prefixId.prefix "isReusedBy"
    /// <summary>
    ///   <para>rdfs:comment : A relation between social objects and schemata that organize them. For example, a Tag hasSchema a Folksonomy, a Lexeme hasSchema a Lexicon, etc.^^xsd:string</para>
    ///   <para>rdfs:label : è schema dirdfs:label : is schema of</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#isSchemaOf">iol:isSchemaOf</a>
    /// </summary>
    let isSchemaOf = _prefixId.prefix "isSchemaOf"
    /// <summary>
    ///   <para>rdfs:comment : A relation between linguistic objects and other information objects (including other linguistic objects).
    /// For example, 'dog' can lexicalize a picture of a dog, a linguistic description of a dog, or the logical class: 'Dog'.
    /// This relation is a subPropertyOf encodes .
    /// In case of FormalExpression(s), it is not the inverse of isFormalTermFor: formal expressions can be said to 'be formal terms' for a LinguisticObject(s), while, independently, linguistic objects can be said to 'lexicalize' formal expressions. The difference is mainly pragmatic: one can take e.g. the word Dog, and decide to have a logical class 'Dog' for it. Someone else can see the logical class 'Dog', and decide to lexicalize it with the words dog, chien, cane, etc. While the relation seems similar, the pragmatic of using them is very different.^^xsd:string</para>
    ///   <para>rdfs:label : lessicalizzardfs:label : lexicalizes</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#lexicalizes">iol:lexicalizes</a>
    /// </summary>
    let lexicalizes = _prefixId.prefix "lexicalizes"
    /// <summary>
    ///   <para>rdfs:comment : This property can be used to relate two social objects that are associated by means of a metaphorical blending, e.g. Greek and Aegyptian sphinges.^^xsd:string</para>
    ///   <para>rdfs:label : fusoMetaforicamenteConrdfs:label : metaphorically blends with</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#metaphoricallyBlendsWith">iol:metaphoricallyBlendsWith</a>
    /// </summary>
    let metaphoricallyBlendsWith = _prefixId.prefix "metaphoricallyBlendsWith"
    /// <summary>
    ///   <para>rdfs:label : riproducerdfs:label : reproduces</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#reproduces">iol:reproduces</a>
    /// </summary>
    let reproduces = _prefixId.prefix "reproduces"
    /// <summary>
    ///   <para>rdfs:comment : Any relation between information entities, where the first one reuses (includes, transforms, reengineers, etc.) the second one.^^xsd:string</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#reuses">iol:reuses</a>
    /// </summary>
    let reuses = _prefixId.prefix "reuses"
