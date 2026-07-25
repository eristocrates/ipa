namespace http.www.ontologydesignpatterns.org.ont.dul.IOLite.owl.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module iol =
    let _namespace_iri = Namespace_Iri iol |> NamespaceIRI
    /// <summary>
    ///   <para>iol:isAssignedTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:InverseFunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The relation between a FormalExpression, and an Entity (a FormalEntity in case of classes, relations, etc.) that it is supposed to be the reference of the symbol (FormalExpression) that the Entity is an intepretation of.
    /// In other words, this is the 'formal interpretation' function, by which a logician 'assigns' an Entity to a FormalExpression.
    /// For each type of formal expressions defined in a logical language, an assignment assumption should be indicated, for example, owl:Class should be restricted to: isAssignmentOf allValuesFrom Class. In addition, differently from the general relation formallyRepresents, isAssignmentOf is functional (and its inverse is inverse functional), in order to encode the Tarskian correspondence assumption.
    /// E.g., the Set of 'all mariachis in Tijuana' isAssignedTo the predicate (FormalExpression) 'TijuanaMariachi' (that isFormalTermFor a Term e.g. 'the mariachis in Tijuana').</para>
    /// labels<para>interpreta formalmente {@it}</para><para>formally interprets {@en}</para><para>è assegnata a</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#isAssignedTo">http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#isAssignedTo</seealso>
    let isAssignedTo = Prefixed_Name(iol, "isAssignedTo") |> PrefixedName
    /// <summary>
    ///   <para>iol:encodes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Any relation between two information entities, with the first used as an alternative encoding of the second. This encoding can preserve all or part of the informational structure. For example, an XML encoding of a plain text file, a digital scanning of a physical paper document, a reproduction of a painting, etc.
    /// The encoding can be so precise and close to the medium of realization, that distinguishing the maximally encoded object from its realization is superfluous (as in many cases of computer science information entities). For this reason, the relation holds for either dul:InformationObject(s) or dul:InformationRealization(s).
    /// Since the relation holds for either dul:InformationObject(s) or dul:InformationRealization(s), dul:realizes is a subproperty of it.</para>
    /// </remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#encodes">http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#encodes</seealso>
    let encodes = Prefixed_Name(iol, "encodes") |> PrefixedName
    /// <summary>
    ///   <para>iol:Code</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Any piece of information expressing computational operations, objects, markup, etc.</para>
    /// labels<para>Codice</para><para>Code</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#Code">http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#Code</seealso>
    let Code = Prefixed_Name(iol, "Code") |> PrefixedName

    /// <summary>
    ///   <para>iol:CommunicativeFunction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The functions, e.g. defined by Jakobson and by Buhler, which define types of linguistic acts. Jakobson's ones include referential, conative, expressive, phatic, metalinguistic, poetic. Each function has typical roles and tasks that must be played during a linguistic act that achieves the function.</para>
    /// labels<para>Communicative function</para><para>Funzione comunicativa</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#CommunicativeFunction">http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#CommunicativeFunction</seealso>
    let CommunicativeFunction =
        Prefixed_Name(iol, "CommunicativeFunction") |> PrefixedName

    /// <summary>
    ///   <para>iol:PlasticArt</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>wn noun: The arts of shaping or modeling; carving and sculpture</para>
    /// labels<para>Opera plastica</para><para>Plastic art</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#PlasticArt">http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#PlasticArt</seealso>
    let PlasticArt = Prefixed_Name(iol, "PlasticArt") |> PrefixedName
    /// <summary>
    ///   <para>iol:Sound</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An information realization consisting of sound waves.</para>
    /// labels<para>Sound</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#Sound">http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#Sound</seealso>
    let Sound = Prefixed_Name(iol, "Sound") |> PrefixedName
    /// <summary>
    ///   <para>iol:Statue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>wn noun: A sculpture representing a human or animal</para>
    /// labels<para>Statue</para><para>Statua</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#Statue">http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#Statue</seealso>
    let Statue = Prefixed_Name(iol, "Statue") |> PrefixedName
    /// <summary>
    ///   <para>iol:FormalExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Any information object represented in a FormalLanguage, usually having a formal interpretation by a dul:FormalEntity, and used to formally represent any Entity</para>
    /// labels<para>Espressione formale</para><para>Formal expression</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#FormalExpression">http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#FormalExpression</seealso>
    let FormalExpression = Prefixed_Name(iol, "FormalExpression") |> PrefixedName
    /// <summary>
    ///   <para>iol:isFormalTermFor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The relation between an InformationObject and a FormalExpression (constant, formula, term, sentence, proposition, axiom, etc.) that it is supposed to be given formal interpretation to formalize the InformationObject.
    /// Notice that FormalExpression(s) only are formal terms for InformationObject(s), not for Concept(s) or for other SocialObject(s). On their turn, information object can 'express' (see) SocialObject(s).
    /// E.g., the predicate (FormalExpression) 'TijuanaMariachi' isFormalTermFor the Term 'the mariachis in Tijuana' (that expresses the Collection of all mariachis in Tijuana); the Term 'equivalence relation' (that expresses the Concept of 'two entities having the same properties') hasFormalTerm the '&lt;=&gt;' symbol.</para>
    /// labels<para>è termine formale per</para><para>is formal term for</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#isFormalTermFor">http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#isFormalTermFor</seealso>
    let isFormalTermFor = Prefixed_Name(iol, "isFormalTermFor") |> PrefixedName
    /// <summary>
    ///   <para>iol:Gesture</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Gesture</para><para>Gesto</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#Gesture">http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#Gesture</seealso>
    let Gesture = Prefixed_Name(iol, "Gesture") |> PrefixedName
    /// <summary>
    ///   <para>iol:Writing</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An information realization based on conventional symbols.
    /// It is a secondary code of communication (secondary means that it is about an original bodily expression, i.e. a primary code). Therefore, we are not considering here early forms of iconic expression, which could be considered primary.</para>
    /// labels<para>Realizzazione scritta</para><para>Writing</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#Writing">http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#Writing</seealso>
    let Writing = Prefixed_Name(iol, "Writing") |> PrefixedName
    /// <summary>
    ///   <para>iol:IconicLanguage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A language made up of graphical elements. It can be natural, artificial, and even formal.</para>
    /// labels<para>Linguaggio iconico</para><para>Iconic language</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#IconicLanguage">http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#IconicLanguage</seealso>
    let IconicLanguage = Prefixed_Name(iol, "IconicLanguage") |> PrefixedName
    /// <summary>
    ///   <para>iol:Lexicon</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A collection of lexical items (terms, entries, ...) that are witnessed to have a linguistic relevance.</para>
    /// labels<para>Lessico</para><para>Lexicon</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#Lexicon">http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#Lexicon</seealso>
    let Lexicon = Prefixed_Name(iol, "Lexicon") |> PrefixedName
    /// <summary>
    ///   <para>iol:hasSchema</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A relation between social objects and schemata that organize them. For example, a Tag hasSchema a Folksonomy, a Lexeme hasSchema a Lexicon, etc.</para>
    /// labels<para>has schema</para><para>ha schema</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#hasSchema">http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#hasSchema</seealso>
    let hasSchema = Prefixed_Name(iol, "hasSchema") |> PrefixedName
    /// <summary>
    ///   <para>iol:Term</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A word or multiword that is established in some terminology from a domain of discourse.</para>
    /// labels<para>Termine</para><para>Term</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#Term">http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#Term</seealso>
    let Term = Prefixed_Name(iol, "Term") |> PrefixedName
    /// <summary>
    ///   <para>iol:Datum</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>From WordNet: 'an item of factual information derived from measurement or research'</para>
    /// labels<para>Datum</para><para>Dato</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#Datum">http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#Datum</seealso>
    let Datum = Prefixed_Name(iol, "Datum") |> PrefixedName
    /// <summary>
    ///   <para>iol:DigitalPhoto</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Digital photo</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#DigitalPhoto">http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#DigitalPhoto</seealso>
    let DigitalPhoto = Prefixed_Name(iol, "DigitalPhoto") |> PrefixedName
    /// <summary>
    ///   <para>iol:Drawing</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>wn noun: A representation of forms or objects on a surface by means of lines; "drawings of abstract forms"; "he did complicated pen-and-ink drawings like medieval miniatures"</para>
    /// labels<para>Drawing</para><para>Disegno</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#Drawing">http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#Drawing</seealso>
    let Drawing = Prefixed_Name(iol, "Drawing") |> PrefixedName

    /// <summary>
    ///   <para>iol:hasRepresentationLanguage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>ha linguaggio di rappresentazione</para><para>has representation language</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#hasRepresentationLanguage">http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#hasRepresentationLanguage</seealso>
    let hasRepresentationLanguage =
        Prefixed_Name(iol, "hasRepresentationLanguage") |> PrefixedName

    /// <summary>
    ///   <para>iol:Language</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A natural or artificial language, provided with an alphabet (or vocabulary) and combinatorial rules. In the case of natural languages, their components are 'temporary' and 'reconstructed' out of actual usage. For example, a grammar for a natural language has the status of a theory for that language, and alternative ones can exist (e.g. generative vs. construction grammars).
    /// Another distinction, between the general (systemic) rules for a language, and the local (contextual) rules for e.g. a certain context, speaker, place, etc., can be made separately.
    /// The most comprehensive classification of languages ha probably been made by Umberto Eco, based on the production modes of the 'signs' that are represented in a certain language. It uses several semiotic dimensions, and will be modeled in a forthcoming ontology.</para>
    /// labels<para>Linguaggio</para><para>Language</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#Language">http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#Language</seealso>
    let Language = Prefixed_Name(iol, "Language") |> PrefixedName
    /// <summary>
    ///   <para>iol:Grapheme</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A part of a word as it can be realized by Writing
    /// A spoken information realization can be 'about' a grapheme (as in reading), but it does not 'realize' it. Only Phoneme(s) are realized by spoken information (Voicing).
    /// BTW, since spoken realizations are a 'primary' code of communication, the difference between direct and indirect spoken realizations (reading) should be considered relevant.
    /// A grapheme is not necessarily able to express a meaning (a dul:SocialObject), although it can in principle (e.g. 'a' in English).</para>
    /// labels<para>Grapheme</para><para>Grafema</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#Grapheme">http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#Grapheme</seealso>
    let Grapheme = Prefixed_Name(iol, "Grapheme") |> PrefixedName
    /// <summary>
    ///   <para>iol:LinguisticObject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An information object represented in a NaturalLanguage</para>
    /// labels<para>Oggetto linguistico</para><para>Linguistic object</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#LinguisticObject">http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#LinguisticObject</seealso>
    let LinguisticObject = Prefixed_Name(iol, "LinguisticObject") |> PrefixedName
    /// <summary>
    ///   <para>iol:GraphicArt</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>wn noun: The arts of drawing or painting or printmaking</para>
    /// labels<para>Opera grafica</para><para>Graphic art</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#GraphicArt">http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#GraphicArt</seealso>
    let GraphicArt = Prefixed_Name(iol, "GraphicArt") |> PrefixedName
    /// <summary>
    ///   <para>iol:DigitalResource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Any resource that can be computed, e.g. a file, a piece of (implemented) software. This assumes an encoding allowing the computation (e.g. html+http protocol).</para>
    /// labels<para>Digital resource</para><para>Risorsa digitale</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#DigitalResource">http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#DigitalResource</seealso>
    let DigitalResource = Prefixed_Name(iol, "DigitalResource") |> PrefixedName
    /// <summary>
    ///   <para>iol:hasAuthor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>ha come autore</para><para>has author</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#hasAuthor">http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#hasAuthor</seealso>
    let hasAuthor = Prefixed_Name(iol, "hasAuthor") |> PrefixedName
    /// <summary>
    ///   <para>iol:hasFormalTerm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The relation between an InformationObject and a FormalExpression (constant, formula, term, sentence, proposition, axiom, etc.) that it is supposed to be given formal interpretation to formalize the InformationObject.
    /// Notice that FormalExpression(s) only are formal terms for InformationObject(s), not for Concept(s) or other for SocialObject(s). On their turn, information object can 'express' (see) SocialObject(s).
    /// E.g., the predicate (FormalExpression) 'TijuanaMariachi' isFormalTermFor the Term 'the mariachis in Tijuana' (that expresses the Collection of all mariachis in Tijuana); the Term 'equivalence relation' (that expresses the Concept of 'two entities having the same properties') hasFormalTerm the '&lt;=&gt;' symbol.</para>
    /// labels<para>ha termine formale</para><para>has formal term</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#hasFormalTerm">http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#hasFormalTerm</seealso>
    let hasFormalTerm = Prefixed_Name(iol, "hasFormalTerm") |> PrefixedName
    /// <summary>
    ///   <para>iol:hasGrounding</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A formal entity is grounded in some other entity when it is assumed as the (formal, extensional) interpretation of it, for example, the set Dog can be grounded in the collection of all actual dogs (or in some of them that the modeller intends).</para>
    /// labels<para>has grounding</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#hasGrounding">http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#hasGrounding</seealso>
    let hasGrounding = Prefixed_Name(iol, "hasGrounding") |> PrefixedName
    /// <summary>
    ///   <para>iol:isCopyOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The original information realization of some copy. Differently from reproductions, copies are not planned to have notable differences from the original. Master copies, author-signed paintings, etc. are examples of originals.</para>
    /// labels<para>is copy of</para><para>è copia di</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#isCopyOf">http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#isCopyOf</seealso>
    let isCopyOf = Prefixed_Name(iol, "isCopyOf") |> PrefixedName

    /// <summary>
    ///   <para>iol:isDigitallyReproducedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>è digitalmente riprodotto da</para><para>is digitally reproduced by</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#isDigitallyReproducedBy">http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#isDigitallyReproducedBy</seealso>
    let isDigitallyReproducedBy =
        Prefixed_Name(iol, "isDigitallyReproducedBy") |> PrefixedName

    /// <summary>
    ///   <para>iol:lexicalizes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A relation between linguistic objects and other information objects (including other linguistic objects).
    /// For example, 'dog' can lexicalize a picture of a dog, a linguistic description of a dog, or the logical class: 'Dog'.
    /// This relation is a subPropertyOf encodes .
    /// In case of FormalExpression(s), it is not the inverse of isFormalTermFor: formal expressions can be said to 'be formal terms' for a LinguisticObject(s), while, independently, linguistic objects can be said to 'lexicalize' formal expressions. The difference is mainly pragmatic: one can take e.g. the word Dog, and decide to have a logical class 'Dog' for it. Someone else can see the logical class 'Dog', and decide to lexicalize it with the words dog, chien, cane, etc. While the relation seems similar, the pragmatic of using them is very different.</para>
    /// labels<para>lessicalizza</para><para>lexicalizes</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#lexicalizes">http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#lexicalizes</seealso>
    let lexicalizes = Prefixed_Name(iol, "lexicalizes") |> PrefixedName

    /// <summary>
    ///   <para>iol:isRepresentationLanguageOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>è il linguaggio di rappresentazione di</para><para>is representation language of</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#isRepresentationLanguageOf">http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#isRepresentationLanguageOf</seealso>
    let isRepresentationLanguageOf =
        Prefixed_Name(iol, "isRepresentationLanguageOf") |> PrefixedName

    /// <summary>
    ///   <para>iol:DataStructure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Any data structure, including databases, schemas, lexica, knowledge organizations systems, etc.</para>
    /// labels<para>Struttura di dati</para><para>Data structure</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#DataStructure">http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#DataStructure</seealso>
    let DataStructure = Prefixed_Name(iol, "DataStructure") |> PrefixedName
    /// <summary>
    ///   <para>iol:Depiction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An information realization consisting of depicted images/signs of any sort (e.g. graffiti, drawings, inscriptions, pictures, sculptures, etc.), which are inscripted on a medium that lasts longer than the depicting act.
    /// It also includes any early form of inscripted iconic expression, which can be considered as original bodily expressions.</para>
    /// labels<para>Realizzazione visiva</para><para>Depiction</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#Depiction">http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#Depiction</seealso>
    let Depiction = Prefixed_Name(iol, "Depiction") |> PrefixedName

    /// <summary>
    ///   <para>iol:isFormallyRepresentedIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The relation between formal expressions, and anything that they are supposed to represent.
    /// E.g., 'the predicate 'MariachiInTijuana' formallyRepresents the dul:Collection of all mariachis in Tijuana'; 'the equivalence relation '&lt;=&gt;' formallyRepresents the concept of two entities having the same properties', 'the constant 'John' formallyRepresents the dul:NaturalPerson John.
    /// Notice that formal expressions are formally interpreted by instances of dul:FormalEntity</para>
    /// labels<para>è rappresentato formalmente in</para><para>is formally represented in</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#isFormallyRepresentedIn">http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#isFormallyRepresentedIn</seealso>
    let isFormallyRepresentedIn =
        Prefixed_Name(iol, "isFormallyRepresentedIn") |> PrefixedName

    /// <summary>
    ///   <para>iol:isAssignmentOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The relation between a FormalExpression, and an Entity (a FormalEntity in case of classes, relations, etc.) that it is supposed to be the reference of the symbol (FormalExpression) that the Entity is an intepretation of.
    /// In other words, this property expresses the 'formal interpretation' function, by which a logician 'assigns' an Entity to a FormalExpression.
    /// For each type of formal expressions defined in a logical language, an assignment assumption should be indicated, for example, owl:Class should be restricted to: isAssignmentOf allValuesFrom Class. In addition, differently from the general relation formallyRepresents, isAssignmentOf is functional (and its inverse is inverse functional), in order to encode the Tarskian correspondence assumption.
    /// E.g., the Set of 'all mariachis in Tijuana' isAssignedTo the predicate (FormalExpression) 'TijuanaMariachi' (that isFormalTermFor a Term e.g. 'the mariachis in Tijuana').</para>
    /// labels<para>è interpretata formalmente come</para><para>is formally interpreted as</para><para>è assegnazione di</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#isAssignmentOf">http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#isAssignmentOf</seealso>
    let isAssignmentOf = Prefixed_Name(iol, "isAssignmentOf") |> PrefixedName
    /// <summary>
    ///   <para>iol:isSchemaOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A relation between social objects and schemata that organize them. For example, a Tag hasSchema a Folksonomy, a Lexeme hasSchema a Lexicon, etc.</para>
    /// labels<para>is schema of</para><para>è schema di</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#isSchemaOf">http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#isSchemaOf</seealso>
    let isSchemaOf = Prefixed_Name(iol, "isSchemaOf") |> PrefixedName
    /// <summary>
    ///   <para>iol:isReproducedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>is reproduced by</para><para>è riprodotto da</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#isReproducedBy">http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#isReproducedBy</seealso>
    let isReproducedBy = Prefixed_Name(iol, "isReproducedBy") |> PrefixedName
    /// <summary>
    ///   <para>iol:isLexicalizedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A relation between linguistic objects and other information objects (including other linguistic objects).
    /// For example, 'dog' can lexicalize a picture of a dog, a linguistic description of a dog, or the logical class: 'Dog'.
    /// This relation is a subPropertyOf encodes .
    /// In case of FormalExpression(s), it is not the inverse of isFormalTermFor: formal expressions can be said to 'be formal terms' for a LinguisticObject(s), while, independently, linguistic objects can be said to 'lexicalize' formal expressions. The difference is mainly pragmatic: one can take e.g. the word Dog, and decide to have a logical class 'Dog' for it. Someone else can see the logical class 'Dog', and decide to lexicalize it with the words dog, chien, cane, etc. While the relation seems similar, the pragmatic of using them is very different.</para>
    /// labels<para>è lessicalizzato da</para><para>is lexicalized by</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#isLexicalizedBy">http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#isLexicalizedBy</seealso>
    let isLexicalizedBy = Prefixed_Name(iol, "isLexicalizedBy") |> PrefixedName
    /// <summary>
    ///   <para>iol:isReusedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#isReusedBy">http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#isReusedBy</seealso>
    let isReusedBy = Prefixed_Name(iol, "isReusedBy") |> PrefixedName
    /// <summary>
    ///   <para>iol:FormalLanguage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A formal language, created by some human, with a fixed grammar, and usually with an explicit formal semantics (i.e. any FormalExpression that is a wff or a valid element of a FormalLanguage has an interpretation wrt to formal entities such as sets, categories, etc.).</para>
    /// labels<para>Linguaggio formale</para><para>Formal language</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#FormalLanguage">http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#FormalLanguage</seealso>
    let FormalLanguage = Prefixed_Name(iol, "FormalLanguage") |> PrefixedName
    /// <summary>
    ///   <para>iol:KOS</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Knowledge Organization Systems: thesauri, terminologies, classification schemes, subject hierarchies, etc.</para>
    /// labels<para>Sistema di organizzazione della conoscenza</para><para>Knowledge organization system</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#KOS">http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#KOS</seealso>
    let KOS = Prefixed_Name(iol, "KOS") |> PrefixedName
    /// <summary>
    ///   <para>iol:isOriginalOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>è l'originale di</para><para>is original of</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#isOriginalOf">http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#isOriginalOf</seealso>
    let isOriginalOf = Prefixed_Name(iol, "isOriginalOf") |> PrefixedName

    /// <summary>
    ///   <para>iol:metaphoricallyBlendsWith</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:SymmetricProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This property can be used to relate two social objects that are associated by means of a metaphorical blending, e.g. Greek and Aegyptian sphinges.</para>
    /// labels<para>metaphorically blends with</para><para>fusoMetaforicamenteCon</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#metaphoricallyBlendsWith">http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#metaphoricallyBlendsWith</seealso>
    let metaphoricallyBlendsWith =
        Prefixed_Name(iol, "metaphoricallyBlendsWith") |> PrefixedName

    /// <summary>
    ///   <para>iol:reuses</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Any relation between information entities, where the first one reuses (includes, transforms, reengineers, etc.) the second one.</para>
    /// </remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#reuses">http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#reuses</seealso>
    let reuses = Prefixed_Name(iol, "reuses") |> PrefixedName
    /// <summary>
    ///   <para>iol:IconicObject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An information object represented in an IconicLanguage</para>
    /// labels<para>Oggetto iconico</para><para>Iconic object</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#IconicObject">http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#IconicObject</seealso>
    let IconicObject = Prefixed_Name(iol, "IconicObject") |> PrefixedName
    /// <summary>
    ///   <para>iol:Lexeme</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Lexical entries for dictionaries, lexica, etc. They are used to create reference forms of words.</para>
    /// labels<para>Lessema</para><para>Lexeme</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#Lexeme">http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#Lexeme</seealso>
    let Lexeme = Prefixed_Name(iol, "Lexeme") |> PrefixedName
    /// <summary>
    ///   <para>iol:Multiword</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A LinguisticObject made up of more than one Word, but distinct from a Phrase, which is a higher syntactic unit.</para>
    /// labels<para>Lemma polirematico</para><para>Polyrhematic unit</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#Multiword">http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#Multiword</seealso>
    let Multiword = Prefixed_Name(iol, "Multiword") |> PrefixedName
    /// <summary>
    ///   <para>iol:Word</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A linguistic object consisting of a string (independently of its physical realization).
    /// Its topological unity can change according to its physical realization: as a written realization, its boundaries are blank spaces, as a spoken realization, sometimes is silence, sometimes not, and higher order features intervene.
    /// Grammatical notions, such as noun, verb, adjective, etc., are roles defined by a grammar, and words (or larger linguistic objects) can play those roles in a given language. E.g., the word 'share' can play both 'verb' and 'noun' roles in contemporary English, while the word 'come' can only play the 'verb' role in English, and the 'adverb' or 'conjunction' roles in Italian (but if we consider a word as only realized by phonemes, i.e. if we consider the oral realizations of 'come', there is no common word 'come' in the two languages).</para>
    /// labels<para>Parola</para><para>Word</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#Word">http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#Word</seealso>
    let Word = Prefixed_Name(iol, "Word") |> PrefixedName
    /// <summary>
    ///   <para>iol:LinguisticAct</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A communicative situation including linguistic objects, agents, and a set of contexts: physical (informational realizations), conceptual (social objects), and referential (entities).
    /// A linguistic act has an associated CommunicativeFunction that it satisfies.</para>
    /// labels<para>Atto linguistico</para><para>Linguistic act</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#LinguisticAct">http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#LinguisticAct</seealso>
    let LinguisticAct = Prefixed_Name(iol, "LinguisticAct") |> PrefixedName
    /// <summary>
    ///   <para>iol:LinguisticFunction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Any linguistic function that classifies words according to a LinguisticTheory.
    /// This class includes parts of speech, thematic roles, phrase structure components, verbal aspects, etc. e.g. Subject, Object, Instrument, Stative, etc.
    /// Each linguistic function must be defined in a LinguisticTheory; e.g. a thematic role can be defined either in a generative grammar, or in construction-based theory.</para>
    /// labels<para>Funzione linguistica</para><para>Linguistic function</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#LinguisticFunction">http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#LinguisticFunction</seealso>
    let LinguisticFunction = Prefixed_Name(iol, "LinguisticFunction") |> PrefixedName
    /// <summary>
    ///   <para>iol:LinguisticTheory</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Any theory describing the structure and/or production and understanding of a natural language or a set of natural languages, or a component of one or more natural languages.</para>
    /// labels<para>Teoria linguistica</para><para>Linguistic theory</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#LinguisticTheory">http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#LinguisticTheory</seealso>
    let LinguisticTheory = Prefixed_Name(iol, "LinguisticTheory") |> PrefixedName
    /// <summary>
    ///   <para>iol:NaturalLanguage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A natural language, evolved and used in a community across time.
    /// Natural languages components are 'temporary' and 'reconstructed' out of actual usage. For example, a grammar for a (part of a) natural language has the status of a theory for that language, but alternative ones can exist (e.g. generative vs. construction grammars).</para>
    /// labels<para>Linguaggio naturale</para><para>Natural language</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#NaturalLanguage">http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#NaturalLanguage</seealso>
    let NaturalLanguage = Prefixed_Name(iol, "NaturalLanguage") |> PrefixedName
    /// <summary>
    ///   <para>iol:Morpheme</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A part of a word that can express a meaning, which is part of the meaning of the entire word.</para>
    /// labels<para>Morpheme</para><para>Morfema</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#Morpheme">http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#Morpheme</seealso>
    let Morpheme = Prefixed_Name(iol, "Morpheme") |> PrefixedName
    /// <summary>
    ///   <para>iol:MultimediaObject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An information realization that realizes heterogeneous information objects. Examples include audiovisual performances, web pages, etc.</para>
    /// labels<para>Oggetto multimediale</para><para>Multimedia object</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#MultimediaObject">http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#MultimediaObject</seealso>
    let MultimediaObject = Prefixed_Name(iol, "MultimediaObject") |> PrefixedName
    /// <summary>
    ///   <para>iol:Painting</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>wn noun: Graphic art consisting of an artistic composition made by applying paints to a surface; "a small painting by Picasso"; "he bought the painting as an investment"; "his pictures hang in the Louvre"</para>
    /// labels<para>Painting</para><para>Dipinto</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#Painting">http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#Painting</seealso>
    let Painting = Prefixed_Name(iol, "Painting") |> PrefixedName
    /// <summary>
    ///   <para>iol:Voicing</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An information realization consisting of uttered sounds. In natural agents, it always co-occurs with bodily movements.</para>
    /// labels<para>Vocalizzazione</para><para>Voicing</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#Voicing">http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#Voicing</seealso>
    let Voicing = Prefixed_Name(iol, "Voicing") |> PrefixedName
    /// <summary>
    ///   <para>iol:Phrase</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A composition of Word(s) that can be considered a higher syntactic unit than a Word, and dul:isComponentOf a Sentence</para>
    /// labels<para>Proposizione</para><para>Phrase</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#Phrase">http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#Phrase</seealso>
    let Phrase = Prefixed_Name(iol, "Phrase") |> PrefixedName
    /// <summary>
    ///   <para>iol:Phoneme</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A part of a word as it can be realized by Voicing
    /// A written information realization can be 'about' a phoneme (as in the case of transcription systems), but it does not 'realize' it: only Grapheme(s) are realized by written information (Writing).
    /// A phoneme is not necessarily able to express a meaning (any dul:SocialObject), although it can in principle (e.g. 'a' in English).</para>
    /// labels<para>Phoneme</para><para>Fonema</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#Phoneme">http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#Phoneme</seealso>
    let Phoneme = Prefixed_Name(iol, "Phoneme") |> PrefixedName
    /// <summary>
    ///   <para>iol:Sentence</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A composition of Phrase(s), assumed to express a state of affairs (here modelled as a dul:Situation). Graphically, a period is usually considered its boundary.</para>
    /// labels<para>Sentence</para><para>Frase</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#Sentence">http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#Sentence</seealso>
    let Sentence = Prefixed_Name(iol, "Sentence") |> PrefixedName
    /// <summary>
    ///   <para>iol:Sculpture</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>wn noun: A three-dimensional work of plastic art</para>
    /// labels<para>Sculpture</para><para>Scultura</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#Sculpture">http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#Sculpture</seealso>
    let Sculpture = Prefixed_Name(iol, "Sculpture") |> PrefixedName
    /// <summary>
    ///   <para>iol:Speech</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Conventional sounds realizing explicit communication. Speech is a primary code of communication (primary means that is an original body expression, especially if first learnt).</para>
    /// labels<para>Discorso</para><para>Speech</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#Speech">http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#Speech</seealso>
    let Speech = Prefixed_Name(iol, "Speech") |> PrefixedName
    /// <summary>
    ///   <para>iol:Thesaurus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A collection of categories organized according to a specified syntax, typically used to create a controlled terminology in a domain. A useful rdfs encoding of a typical thesaurus syntax is the SKOS schema.</para>
    /// labels<para>Thesaurus</para><para>Tesauro</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#Thesaurus">http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#Thesaurus</seealso>
    let Thesaurus = Prefixed_Name(iol, "Thesaurus") |> PrefixedName
    /// <summary>
    ///   <para>iol:WebPage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Web page</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#WebPage">http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#WebPage</seealso>
    let WebPage = Prefixed_Name(iol, "WebPage") |> PrefixedName

    /// <summary>
    ///   <para>iol:combinatoriallyRelatedTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:SymmetricProperty</para>
    ///   <para>Any relation holding between two FormalExpression(s), e.g. a function over formal grammars, boolean operators, syntactic relations defined for the logical vocabulary of a formal language, etc.
    /// Syntactic relations from logical languages have a correspondance to some formal relation.</para>
    /// </remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#combinatoriallyRelatedTo">http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#combinatoriallyRelatedTo</seealso>
    let combinatoriallyRelatedTo =
        Prefixed_Name(iol, "combinatoriallyRelatedTo") |> PrefixedName

    /// <summary>
    ///   <para>iol:digitallyReproduces</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>riproduce digitalmente</para><para>digitally reproduces</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#digitallyReproduces">http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#digitallyReproduces</seealso>
    let digitallyReproduces = Prefixed_Name(iol, "digitallyReproduces") |> PrefixedName
    /// <summary>
    ///   <para>iol:reproduces</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>reproduces</para><para>riproduce</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#reproduces">http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#reproduces</seealso>
    let reproduces = Prefixed_Name(iol, "reproduces") |> PrefixedName
    /// <summary>
    ///   <para>iol:formallyRepresents</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The relation between formal expressions, and anything that they are supposed to represent.
    /// E.g., 'the predicate 'MariachiInTijuana' formallyRepresents the dul:Collection of all mariachis in Tijuana'; 'the equivalence relation '&lt;=&gt;' formallyRepresents the Concept of two entities having the same properties', 'the constant 'John' formallyRepresents the dul:NaturalPerson 'John'.
    /// Notice that a FormalExpression isAssignmentOf (is formally interpreted by) instances of dul:FormalEntity.
    ///
    /// formallyRepresents is a particular case of 'dul:isAbout', holding only for formal expressions.
    /// Anyway, a formal expression that  dul:expresses a dul:SocialObject is also possible, but treats formal expressions as any other kind of dul:InformationObject that express a 'social' or 'cognitive' semantics, not a formal one.</para>
    /// labels<para>rappresenta formalmente</para><para>formally represents</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#formallyRepresents">http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#formallyRepresents</seealso>
    let formallyRepresents = Prefixed_Name(iol, "formallyRepresents") |> PrefixedName
    /// <summary>
    ///   <para>iol:isAuthorOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>is author of</para><para>è autore di</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#isAuthorOf">http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#isAuthorOf</seealso>
    let isAuthorOf = Prefixed_Name(iol, "isAuthorOf") |> PrefixedName

    /// <summary>
    ///   <para>iol:hasCulturalGrounding</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>has cultural grounding</para><para>ha sorgente culturale</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#hasCulturalGrounding">http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#hasCulturalGrounding</seealso>
    let hasCulturalGrounding =
        Prefixed_Name(iol, "hasCulturalGrounding") |> PrefixedName

    /// <summary>
    ///   <para>iol:isCulturalGroundingFor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>è una sorgente culturale per</para><para>is cultural grounding for</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#isCulturalGroundingFor">http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#isCulturalGroundingFor</seealso>
    let isCulturalGroundingFor =
        Prefixed_Name(iol, "isCulturalGroundingFor") |> PrefixedName

    /// <summary>
    ///   <para>iol:hasCulturalMixingWith</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:SymmetricProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>ha una fusione culturale con</para><para>has cultural mixing with</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#hasCulturalMixingWith">http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#hasCulturalMixingWith</seealso>
    let hasCulturalMixingWith =
        Prefixed_Name(iol, "hasCulturalMixingWith") |> PrefixedName

    /// <summary>
    ///   <para>iol:isGroundingFor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>is grounding for</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#isGroundingFor">http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#isGroundingFor</seealso>
    let isGroundingFor = Prefixed_Name(iol, "isGroundingFor") |> PrefixedName
    /// <summary>
    ///   <para>iol:isEncodedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Any relation between two information entities, with the first used as an alternative encoding of the second. This encoding can preserve all or part of the informational structure. For example, an XML encoding of a plain text file, a digital scanning of a physical paper document, a reproduction of a painting, etc.
    /// The encoding can be so precise and close to the medium of realization, that distinguishing the maximally encoded object from its realization is superfluous (as in many cases of computer science information entities). For this reason, the relation holds for either dul:InformationObject(s) or dul:InformationRealization(s).
    /// Since the relation holds for either dul:InformationObject(s) or dul:InformationRealization(s), dul:realizes is a subproperty of it.</para>
    /// </remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#isEncodedBy">http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#isEncodedBy</seealso>
    let isEncodedBy = Prefixed_Name(iol, "isEncodedBy") |> PrefixedName
    /// <summary>
    ///   <para>iol:BodilyMotion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An information realization consisting of bodily movements.</para>
    /// labels<para>Movimento corporeo</para><para>Bodily motion</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#BodilyMotion">http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#BodilyMotion</seealso>
    let BodilyMotion = Prefixed_Name(iol, "BodilyMotion") |> PrefixedName
    /// <summary>
    ///   <para>iol:ContractText</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The text of a contract</para>
    /// labels<para>Testo di un contratto</para><para>Contract text</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#ContractText">http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#ContractText</seealso>
    let ContractText = Prefixed_Name(iol, "ContractText") |> PrefixedName
    /// <summary>
    ///   <para>iol:Text</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A LinguisticObject composed of at least one Sentence, and assumed to be realized in written form.</para>
    /// labels<para>Testo</para><para>Text</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#Text">http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#Text</seealso>
    let Text = Prefixed_Name(iol, "Text") |> PrefixedName
    /// <summary>
    ///   <para>iol:DBSchema</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Any conceptual, logical or physical schema for a database.</para>
    /// labels<para>Schema di base di dati</para><para>Database schema</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#DBSchema">http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#DBSchema</seealso>
    let DBSchema = Prefixed_Name(iol, "DBSchema") |> PrefixedName
