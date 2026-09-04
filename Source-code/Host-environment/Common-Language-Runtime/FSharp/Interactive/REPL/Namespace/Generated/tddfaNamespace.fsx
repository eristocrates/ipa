#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module tddfa =
    let _prefixId = PrefixId.fromNamespaceLabel "https://w3id.org/todo/tododfa#" "tddfa"
    /// <summary>
    ///   <para>rdfs:comment : Element that makes reference to the functionalities of the target system.^^xsd:string</para>
    ///   <para>rdfs:label : Action</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>skos:example : (For a multipurpose robot) Guide, provide_information, pick, place^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/todo/tododfa#^^xsd:string</para>
    ///   <a href="https://w3id.org/todo/tododfa#Action">tddfa:Action</a>
    /// </summary>
    let Action = _prefixId.prefix "Action"
    /// <summary>
    ///   <para>skos:example : Frame: Losing
    ///
    /// ArgumentSet:
    /// * Owner [Core]
    /// * Possession [Core]
    /// * Place [Optional]
    /// * Time [Optional]
    /// ...
    ///
    /// For the sentence "My mother lost her watch at home":
    /// "[My mother - owner(C)] LOST [her watch - possession(C)] (at home - place (O))"</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Argument</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/todo/tododfa#^^xsd:string</para>
    ///   <para>rdfs:comment : Participant that is involved in the event described by the Frame. It can be Core (its presence is compulsory to convey the event) or Optional (its presence is not compulsory, but it adds additional information).^^xsd:string</para>
    ///   <a href="https://w3id.org/todo/tododfa#Argument">tddfa:Argument</a>
    /// </summary>
    let Argument = _prefixId.prefix "Argument"
    /// <summary>
    ///   <para>skos:example : Frame: Losing
    ///
    /// ArgumentSet:
    /// * Owner [Core]
    /// * Possession [Core]
    /// * Place [Optional]
    /// * Time [Optional]
    /// ...
    ///
    /// For the sentence "My mother lost her watch at home":
    /// "[My mother - owner(C)] LOST [her watch - possession(C)] (at home - place (O))"</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : ArgumentSet</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/todo/tododfa#^^xsd:string</para>
    ///   <para>rdfs:comment : The group of Arguments that belong to a Frame.</para>
    ///   <a href="https://w3id.org/todo/tododfa#ArgumentSet">tddfa:ArgumentSet</a>
    /// </summary>
    let ArgumentSet = _prefixId.prefix "ArgumentSet"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : FomaGrammar</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/todo/tododfa#^^xsd:string</para>
    ///   <para>rdfs:comment : Grammar to be used by Foma to perform Key Element Extraction.</para>
    ///   <a href="https://w3id.org/todo/tododfa#FomaGrammar">tddfa:FomaGrammar</a>
    /// </summary>
    let FomaGrammar = _prefixId.prefix "FomaGrammar"
    /// <summary>
    ///   <para>skos:example : Frame: Losing
    ///
    /// FrameHead: lose (LexicalUnit: lose.v)
    ///
    /// ArgumentSet:
    /// * Owner [Core]
    /// * Possession [Core]
    /// * Place [Optional]
    /// * Time [Optional]
    /// ...
    ///
    /// For the sentence "My mother lost her watch at home":
    /// "[My mother - owner(C)] LOST [her watch - possession(C)] (at home - place (O))"</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Frame</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/todo/tododfa#^^xsd:string</para>
    ///   <para>rdfs:comment : A specific event or situation evoked by a specific word (FrameHead), along with its participants (Arguments).</para>
    ///   <a href="https://w3id.org/todo/tododfa#Frame">tddfa:Frame</a>
    /// </summary>
    let Frame = _prefixId.prefix "Frame"
    /// <summary>
    ///   <para>skos:example : Frame: Losing
    ///
    /// FrameHead: lose (LexicalUnit: lose.v)
    ///
    /// ArgumentSet:
    /// * Owner [Core]
    /// * Possession [Core]
    /// * Place [Optional]
    /// * Time [Optional]
    /// ...
    ///
    /// For the sentence "My mother lost her watch at home":
    /// "[My mother - owner(C)] LOST [her watch - possession(C)] (at home - place (O))"</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : FrameHead</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/todo/tododfa#^^xsd:string</para>
    ///   <para>rdfs:comment : Word (or more than one) that evokes a specific situation or event, with its specific participants; that is, a frame. It is represented by one or more LexicalUnits.</para>
    ///   <a href="https://w3id.org/todo/tododfa#FrameHead">tddfa:FrameHead</a>
    /// </summary>
    let FrameHead = _prefixId.prefix "FrameHead"
    /// <summary>
    ///   <para>skos:example : User request: "I want information about Mona Lisa"
    ///
    /// Intent: receive_information</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Intent</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/todo/tododfa#^^xsd:string</para>
    ///   <para>rdfs:comment : User intention when formulating a request.</para>
    ///   <a href="https://w3id.org/todo/tododfa#Intent">tddfa:Intent</a>
    /// </summary>
    let Intent = _prefixId.prefix "Intent"
    /// <summary>
    ///   <para>skos:example : (For a multipurpose robot) GuideRobot, RoboticArm^^xsd:string</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Skill</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/todo/tododfa#^^xsd:string</para>
    ///   <para>rdfs:comment : Element that makes reference to the capabilities of the target system.^^xsd:string</para>
    ///   <a href="https://w3id.org/todo/tododfa#Skill">tddfa:Skill</a>
    /// </summary>
    let Skill = _prefixId.prefix "Skill"
    /// <summary>
    ///   <para>skos:example : System request: "Do you need me to {argumentTag}?"
    ///
    /// Action: take_guideRobot
    /// actionTag: "take you somewhere"
    ///
    /// Resulting SysRequest: "Do you need me to {take you somewhere}?"skos:example : System request: "Necesitas que {argumentTag}?"
    ///
    /// Action: take_guideRobot
    /// actionTag: "te lleve a algún lugar"
    ///
    /// Resulting SysRequest: "Necesitas que {te lleve}?"</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : actionTag^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/todo/tododfa^^xsd:string</para>
    ///   <para>rdfs:comment : String that identifies the Action when invoked in a SystemRequest/Response (DomainONT).^^xsd:string</para>
    ///   <a href="https://w3id.org/todo/tododfa#actionTag">tddfa:actionTag</a>
    /// </summary>
    let actionTag = _prefixId.prefix "actionTag"
    /// <summary>
    ///   <para>skos:example : SystemRequest: Do you want me {actionTag}{argumentConnector}{WorldElement}?
    ///
    /// Action: take_guideRobot
    /// argumentConnector: "to"
    ///
    /// "Do you want me {to take you}{to}{the restroom}?"skos:example : SystemRequest: ¿Necesitas que {actionTag}{argumentConnector}{WorldElement}?
    ///
    /// Action: take_guideRobot
    /// argumentConnector: "a"
    ///
    /// "¿Necesitas que {te lleve}{a}{la sala}?"</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : argumentConnector^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/todo/tododfa^^xsd:string</para>
    ///   <para>rdfs:comment : String that defines the word that acts as a connector between the Argument and the rest of elements in a SystemRequest/Response.^^xsd:string</para>
    ///   <a href="https://w3id.org/todo/tododfa#argumentConnector">tddfa:argumentConnector</a>
    /// </summary>
    let argumentConnector = _prefixId.prefix "argumentConnector"
    /// <summary>
    ///   <para>skos:example : System request: "I need to know {argumentTag}"
    ///
    /// Argument: destination_guideRobot
    /// argumentTag: "where do you want to go"
    ///
    /// Resulting SysRequest: "I need to know {where do you want to go}"skos:example : System request: "Necesito saber {argumentTag}"
    ///
    /// Argument: destination_guideRobot
    /// argumentTag: "adónde quieres ir"
    ///
    /// Resulting SysRequest: "Necesito saber {adónde quieres ir}"</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : argumentTag^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/todo/tododfa#^^xsd:string</para>
    ///   <para>rdfs:comment : String that identifies the Argument when invoked in a SystemRequest/Response (DomainONT)^^xsd:string</para>
    ///   <a href="https://w3id.org/todo/tododfa#argumentTag">tddfa:argumentTag</a>
    /// </summary>
    let argumentTag = _prefixId.prefix "argumentTag"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : belongsToAction^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/todo/tododfa#^^xsd:string</para>
    ///   <para>rdfs:comment : Establishes the relation between an Intent and the Action it belongs to.^^xsd:string</para>
    ///   <a href="https://w3id.org/todo/tododfa#belongsToAction">tddfa:belongsToAction</a>
    /// </summary>
    let belongsToAction = _prefixId.prefix "belongsToAction"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : belongsToIntent^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/todo/tododfa#^^xsd:string</para>
    ///   <para>rdfs:comment : Establishes the relation between an Action and the Intent it belongs to.^^xsd:string</para>
    ///   <a href="https://w3id.org/todo/tododfa#belongsToIntent">tddfa:belongsToIntent</a>
    /// </summary>
    let belongsToIntent = _prefixId.prefix "belongsToIntent"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : hasArgument^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/todo/tododfa#^^xsd:string</para>
    ///   <para>rdfs:comment : Establishes a relation between an Action and its Argument(s).^^xsd:string</para>
    ///   <a href="https://w3id.org/todo/tododfa#hasArgument">tddfa:hasArgument</a>
    /// </summary>
    let hasArgument = _prefixId.prefix "hasArgument"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : hasArgumentSet^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/todo/tododfa#^^xsd:string</para>
    ///   <para>rdfs:comment : Establishes a relation between an Action and the set composed of its Argument(s).^^xsd:string</para>
    ///   <a href="https://w3id.org/todo/tododfa#hasArgumentSet">tddfa:hasArgumentSet</a>
    /// </summary>
    let hasArgumentSet = _prefixId.prefix "hasArgumentSet"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : hasCoreArgument^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/todo/tododfa#^^xsd:string</para>
    ///   <para>rdfs:comment : Establishes a relation between an Action and its CoreArguments (i.e. the arguments that are compulsory in order to perform the Action).^^xsd:string</para>
    ///   <a href="https://w3id.org/todo/tododfa#hasCoreArgument">tddfa:hasCoreArgument</a>
    /// </summary>
    let hasCoreArgument = _prefixId.prefix "hasCoreArgument"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : hasFomaGrammar^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/todo/tododfa#^^xsd:string</para>
    ///   <para>rdfs:comment : Establishes a relation between a Skill and the FomaGrammar to use to perform Key Element Extraction.^^xsd:string</para>
    ///   <a href="https://w3id.org/todo/tododfa#hasFomaGrammar">tddfa:hasFomaGrammar</a>
    /// </summary>
    let hasFomaGrammar = _prefixId.prefix "hasFomaGrammar"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : hasFrame^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/todo/tododfa#^^xsd:string</para>
    ///   <para>rdfs:comment : Establishes a relation between an Intent and its corresponding Frame.^^xsd:string</para>
    ///   <a href="https://w3id.org/todo/tododfa#hasFrame">tddfa:hasFrame</a>
    /// </summary>
    let hasFrame = _prefixId.prefix "hasFrame"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : hasFrameHead^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/todo/tododfa#^^xsd:string</para>
    ///   <para>rdfs:comment : Establishes a relation between a Frame and its FrameHead.^^xsd:string</para>
    ///   <a href="https://w3id.org/todo/tododfa#hasFrameHead">tddfa:hasFrameHead</a>
    /// </summary>
    let hasFrameHead = _prefixId.prefix "hasFrameHead"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : hasIntent^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/todo/tododfa#^^xsd:string</para>
    ///   <para>rdfs:comment : Establishes a relation between a Skill and its corresponding Intent(s).^^xsd:string</para>
    ///   <a href="https://w3id.org/todo/tododfa#hasIntent">tddfa:hasIntent</a>
    /// </summary>
    let hasIntent = _prefixId.prefix "hasIntent"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : hasOptionalArgument^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/todo/tododfa#^^xsd:string</para>
    ///   <para>rdfs:comment : Establishes a relation between an Action and its OptionalArguments (i.e. the arguments that are not compulsory in order to perform the Action).^^xsd:string</para>
    ///   <a href="https://w3id.org/todo/tododfa#hasOptionalArgument">tddfa:hasOptionalArgument</a>
    /// </summary>
    let hasOptionalArgument = _prefixId.prefix "hasOptionalArgument"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : isArgumentOf^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/todo/tododfa#^^xsd:string</para>
    ///   <para>rdfs:comment : Establishes a relation between an Argument and its corresponding Action.^^xsd:string</para>
    ///   <a href="https://w3id.org/todo/tododfa#isArgumentOf">tddfa:isArgumentOf</a>
    /// </summary>
    let isArgumentOf = _prefixId.prefix "isArgumentOf"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : isArgumentSetOf^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/todo/tododfa#^^xsd:string</para>
    ///   <para>rdfs:comment : Establishes a relation between an ArgumentSet and the Action it corresponds to.^^xsd:string</para>
    ///   <a href="https://w3id.org/todo/tododfa#isArgumentSetOf">tddfa:isArgumentSetOf</a>
    /// </summary>
    let isArgumentSetOf = _prefixId.prefix "isArgumentSetOf"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : isCoreArgumentOf^^xsd:string</para>
    ///   <para>rdfs:comment : Establishes a relation between a CoreArgument (i.e. the arguments that are compulsory in order to perform the Action) and its corresponding Action.^^xsd:stringrdfs:comment : https://w3id.org/todo/tododfa#^^xsd:string</para>
    ///   <a href="https://w3id.org/todo/tododfa#isCoreArgumentOf">tddfa:isCoreArgumentOf</a>
    /// </summary>
    let isCoreArgumentOf = _prefixId.prefix "isCoreArgumentOf"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : isFomaGrammarOf^^xsd:string</para>
    ///   <para>rdfs:comment : Establishes a relation between the FomaGrammar to use to perform Key Element Extraction and a Skill.^^xsd:stringrdfs:comment : https://w3id.org/todo/tododfa#^^xsd:string</para>
    ///   <a href="https://w3id.org/todo/tododfa#isFomaGrammarOf">tddfa:isFomaGrammarOf</a>
    /// </summary>
    let isFomaGrammarOf = _prefixId.prefix "isFomaGrammarOf"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : isFrameHeadOf^^xsd:string</para>
    ///   <para>rdfs:comment : Establishes a relation between a FrameHead and the Frame it applies to.^^xsd:stringrdfs:comment : https://w3id.org/todo/tododfa#^^xsd:string</para>
    ///   <a href="https://w3id.org/todo/tododfa#isFrameHeadOf">tddfa:isFrameHeadOf</a>
    /// </summary>
    let isFrameHeadOf = _prefixId.prefix "isFrameHeadOf"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : isFrameOf^^xsd:string</para>
    ///   <para>rdfs:comment : Establishes a relation between a Frame and the Intent it corresponds to.^^xsd:stringrdfs:comment : https://w3id.org/todo/tododfa#^^xsd:string</para>
    ///   <a href="https://w3id.org/todo/tododfa#isFrameOf">tddfa:isFrameOf</a>
    /// </summary>
    let isFrameOf = _prefixId.prefix "isFrameOf"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : isIntentOf^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/todo/tododfa#^^xsd:string</para>
    ///   <para>rdfs:comment : Establishes a relation between an Intent and its corresponding Skill.^^xsd:string</para>
    ///   <a href="https://w3id.org/todo/tododfa#isIntentOf">tddfa:isIntentOf</a>
    /// </summary>
    let isIntentOf = _prefixId.prefix "isIntentOf"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : isOptionalArgumentOf^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/todo/tododfa#^^xsd:string</para>
    ///   <para>rdfs:comment : Establishes a relation between an Optional Argument (i.e. the arguments that are not compulsory in order to perform the Action) and its corresponding Action.^^xsd:string</para>
    ///   <a href="https://w3id.org/todo/tododfa#isOptionalArgumentOf">tddfa:isOptionalArgumentOf</a>
    /// </summary>
    let isOptionalArgumentOf = _prefixId.prefix "isOptionalArgumentOf"
