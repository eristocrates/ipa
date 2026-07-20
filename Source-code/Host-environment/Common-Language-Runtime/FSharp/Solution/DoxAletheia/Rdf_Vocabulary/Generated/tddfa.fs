namespace https.w3id.org.todo.tododfa.hash

open DoxAletheia

module tddfa =
    let _namespace_name = "https://w3id.org/todo/tododfa#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// Element that makes reference to the functionalities of the target system.
    /// <see href="https://w3id.org/todo/tododfa#Action"></see></summary>
    let Action = _prefix "Action"
    /// <summary>
    /// Participant that is involved in the event described by the Frame. It can be Core (its presence is compulsory to convey the event) or Optional (its presence is not compulsory, but it adds additional information).
    /// <see href="https://w3id.org/todo/tododfa#Argument"></see></summary>
    let Argument = _prefix "Argument"
    /// <summary>
    /// The group of Arguments that belong to a Frame.
    /// <see href="https://w3id.org/todo/tododfa#ArgumentSet"></see></summary>
    let ArgumentSet = _prefix "ArgumentSet"
    /// <summary>
    /// Grammar to be used by Foma to perform Key Element Extraction.
    /// <see href="https://w3id.org/todo/tododfa#FomaGrammar"></see></summary>
    let FomaGrammar = _prefix "FomaGrammar"
    /// <summary>
    /// A specific event or situation evoked by a specific word (FrameHead), along with its participants (Arguments).
    /// <see href="https://w3id.org/todo/tododfa#Frame"></see></summary>
    let Frame = _prefix "Frame"
    /// <summary>
    /// Word (or more than one) that evokes a specific situation or event, with its specific participants; that is, a frame. It is represented by one or more LexicalUnits.
    /// <see href="https://w3id.org/todo/tododfa#FrameHead"></see></summary>
    let FrameHead = _prefix "FrameHead"
    /// <summary>
    /// User intention when formulating a request.
    /// <see href="https://w3id.org/todo/tododfa#Intent"></see></summary>
    let Intent = _prefix "Intent"
    /// <summary>
    /// Element that makes reference to the capabilities of the target system.
    /// <see href="https://w3id.org/todo/tododfa#Skill"></see></summary>
    let Skill = _prefix "Skill"
    /// <summary>
    /// Establishes the relation between an Action and the Intent it belongs to.
    /// <see href="https://w3id.org/todo/tododfa#belongsToIntent"></see></summary>
    let belongsToIntent = _prefix "belongsToIntent"
    /// <summary>
    /// Establishes a relation between an Action and the set composed of its Argument(s).
    /// <see href="https://w3id.org/todo/tododfa#hasArgumentSet"></see></summary>
    let hasArgumentSet = _prefix "hasArgumentSet"
    /// <summary>
    /// Establishes a relation between an Action and its Argument(s).
    /// <see href="https://w3id.org/todo/tododfa#hasArgument"></see></summary>
    let hasArgument = _prefix "hasArgument"
    /// <summary>
    /// String that identifies the Action when invoked in a SystemRequest/Response (DomainONT).
    /// <see href="https://w3id.org/todo/tododfa#actionTag"></see></summary>
    let actionTag = _prefix "actionTag"
    /// <summary>
    /// Establishes a relation between an Argument and its corresponding Action.
    /// <see href="https://w3id.org/todo/tododfa#isArgumentOf"></see></summary>
    let isArgumentOf = _prefix "isArgumentOf"
    /// <summary>
    /// String that identifies the Argument when invoked in a SystemRequest/Response (DomainONT)
    /// <see href="https://w3id.org/todo/tododfa#argumentTag"></see></summary>
    let argumentTag = _prefix "argumentTag"
    /// <summary>
    /// Establishes a relation between an ArgumentSet and the Action it corresponds to.
    /// <see href="https://w3id.org/todo/tododfa#isArgumentSetOf"></see></summary>
    let isArgumentSetOf = _prefix "isArgumentSetOf"
    /// <summary>
    /// Establishes a relation between the FomaGrammar to use to perform Key Element Extraction and a Skill.
    /// https://w3id.org/todo/tododfa#
    /// <see href="https://w3id.org/todo/tododfa#isFomaGrammarOf"></see></summary>
    let isFomaGrammarOf = _prefix "isFomaGrammarOf"
    /// <summary>
    /// Establishes a relation between a Frame and its FrameHead.
    /// <see href="https://w3id.org/todo/tododfa#hasFrameHead"></see></summary>
    let hasFrameHead = _prefix "hasFrameHead"
    /// <summary>
    /// Establishes a relation between a Frame and the Intent it corresponds to.
    /// https://w3id.org/todo/tododfa#
    /// <see href="https://w3id.org/todo/tododfa#isFrameOf"></see></summary>
    let isFrameOf = _prefix "isFrameOf"
    /// <summary>
    /// Establishes a relation between a FrameHead and the Frame it applies to.
    /// https://w3id.org/todo/tododfa#
    /// <see href="https://w3id.org/todo/tododfa#isFrameHeadOf"></see></summary>
    let isFrameHeadOf = _prefix "isFrameHeadOf"
    /// <summary>
    /// Establishes the relation between an Intent and the Action it belongs to.
    /// <see href="https://w3id.org/todo/tododfa#belongsToAction"></see></summary>
    let belongsToAction = _prefix "belongsToAction"
    /// <summary>
    /// Establishes a relation between an Intent and its corresponding Frame.
    /// <see href="https://w3id.org/todo/tododfa#hasFrame"></see></summary>
    let hasFrame = _prefix "hasFrame"
    /// <summary>
    /// Establishes a relation between an Intent and its corresponding Skill.
    /// <see href="https://w3id.org/todo/tododfa#isIntentOf"></see></summary>
    let isIntentOf = _prefix "isIntentOf"
    /// <summary>
    /// Establishes a relation between a Skill and its corresponding Intent(s).
    /// <see href="https://w3id.org/todo/tododfa#hasIntent"></see></summary>
    let hasIntent = _prefix "hasIntent"
    /// <summary>
    /// Establishes a relation between a Skill and the FomaGrammar to use to perform Key Element Extraction.
    /// <see href="https://w3id.org/todo/tododfa#hasFomaGrammar"></see></summary>
    let hasFomaGrammar = _prefix "hasFomaGrammar"
    /// <summary>
    /// String that defines the word that acts as a connector between the Argument and the rest of elements in a SystemRequest/Response.
    /// <see href="https://w3id.org/todo/tododfa#argumentConnector"></see></summary>
    let argumentConnector = _prefix "argumentConnector"
    /// <summary>
    /// Establishes a relation between an Action and its CoreArguments (i.e. the arguments that are compulsory in order to perform the Action).
    /// <see href="https://w3id.org/todo/tododfa#hasCoreArgument"></see></summary>
    let hasCoreArgument = _prefix "hasCoreArgument"
    /// <summary>
    /// Establishes a relation between a CoreArgument (i.e. the arguments that are compulsory in order to perform the Action) and its corresponding Action.
    /// https://w3id.org/todo/tododfa#
    /// <see href="https://w3id.org/todo/tododfa#isCoreArgumentOf"></see></summary>
    let isCoreArgumentOf = _prefix "isCoreArgumentOf"
    /// <summary>
    /// Establishes a relation between an Action and its OptionalArguments (i.e. the arguments that are not compulsory in order to perform the Action).
    /// <see href="https://w3id.org/todo/tododfa#hasOptionalArgument"></see></summary>
    let hasOptionalArgument = _prefix "hasOptionalArgument"
    /// <summary>
    /// Establishes a relation between an Optional Argument (i.e. the arguments that are not compulsory in order to perform the Action) and its corresponding Action.
    /// <see href="https://w3id.org/todo/tododfa#isOptionalArgumentOf"></see></summary>
    let isOptionalArgumentOf = _prefix "isOptionalArgumentOf"
