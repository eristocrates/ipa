namespace https.w3id.org.todo.tododfa.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module tddfa =
    let _namespace_iri = Namespace_Iri tddfa |> NamespaceIRI
    /// <summary>
    ///   <para>w3id:todo/tododfa#Action</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Element that makes reference to the functionalities of the target system."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Action"</para></remarks>
    /// <seealso href="https://w3id.org/todo/tododfa#Action">https://w3id.org/todo/tododfa#Action</seealso>
    let Action = Prefixed_Name(tddfa, "Action") |> PrefixedName
    /// <summary>
    ///   <para>w3id:todo/tododfa#Argument</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Participant that is involved in the event described by the Frame. It can be Core (its presence is compulsory to convey the event) or Optional (its presence is not compulsory, but it adds additional information)."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Argument"</para></remarks>
    /// <seealso href="https://w3id.org/todo/tododfa#Argument">https://w3id.org/todo/tododfa#Argument</seealso>
    let Argument = Prefixed_Name(tddfa, "Argument") |> PrefixedName
    /// <summary>
    ///   <para>w3id:todo/tododfa#ArgumentSet</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The group of Arguments that belong to a Frame."</para>
    /// labels<para>"ArgumentSet"</para></remarks>
    /// <seealso href="https://w3id.org/todo/tododfa#ArgumentSet">https://w3id.org/todo/tododfa#ArgumentSet</seealso>
    let ArgumentSet = Prefixed_Name(tddfa, "ArgumentSet") |> PrefixedName
    /// <summary>
    ///   <para>w3id:todo/tododfa#FomaGrammar</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Grammar to be used by Foma to perform Key Element Extraction."</para>
    /// labels<para>"FomaGrammar"</para></remarks>
    /// <seealso href="https://w3id.org/todo/tododfa#FomaGrammar">https://w3id.org/todo/tododfa#FomaGrammar</seealso>
    let FomaGrammar = Prefixed_Name(tddfa, "FomaGrammar") |> PrefixedName
    /// <summary>
    ///   <para>w3id:todo/tododfa#Frame</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A specific event or situation evoked by a specific word (FrameHead), along with its participants (Arguments)."</para>
    /// labels<para>"Frame"</para></remarks>
    /// <seealso href="https://w3id.org/todo/tododfa#Frame">https://w3id.org/todo/tododfa#Frame</seealso>
    let Frame = Prefixed_Name(tddfa, "Frame") |> PrefixedName
    /// <summary>
    ///   <para>w3id:todo/tododfa#FrameHead</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Word (or more than one) that evokes a specific situation or event, with its specific participants; that is, a frame. It is represented by one or more LexicalUnits."</para>
    /// labels<para>"FrameHead"</para></remarks>
    /// <seealso href="https://w3id.org/todo/tododfa#FrameHead">https://w3id.org/todo/tododfa#FrameHead</seealso>
    let FrameHead = Prefixed_Name(tddfa, "FrameHead") |> PrefixedName
    /// <summary>
    ///   <para>w3id:todo/tododfa#Intent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"User intention when formulating a request."</para>
    /// labels<para>"Intent"</para></remarks>
    /// <seealso href="https://w3id.org/todo/tododfa#Intent">https://w3id.org/todo/tododfa#Intent</seealso>
    let Intent = Prefixed_Name(tddfa, "Intent") |> PrefixedName
    /// <summary>
    ///   <para>w3id:todo/tododfa#Skill</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Element that makes reference to the capabilities of the target system."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Skill"</para></remarks>
    /// <seealso href="https://w3id.org/todo/tododfa#Skill">https://w3id.org/todo/tododfa#Skill</seealso>
    let Skill = Prefixed_Name(tddfa, "Skill") |> PrefixedName
    /// <summary>
    ///   <para>w3id:todo/tododfa#actionTag</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"String that identifies the Action when invoked in a SystemRequest/Response (DomainONT)."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"actionTag"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/todo/tododfa#actionTag">https://w3id.org/todo/tododfa#actionTag</seealso>
    let actionTag = Prefixed_Name(tddfa, "actionTag") |> PrefixedName
    /// <summary>
    ///   <para>w3id:todo/tododfa#argumentConnector</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"String that defines the word that acts as a connector between the Argument and the rest of elements in a SystemRequest/Response."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"argumentConnector"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/todo/tododfa#argumentConnector">https://w3id.org/todo/tododfa#argumentConnector</seealso>
    let argumentConnector = Prefixed_Name(tddfa, "argumentConnector") |> PrefixedName
    /// <summary>
    ///   <para>w3id:todo/tododfa#argumentTag</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"String that identifies the Argument when invoked in a SystemRequest/Response (DomainONT)"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"argumentTag"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/todo/tododfa#argumentTag">https://w3id.org/todo/tododfa#argumentTag</seealso>
    let argumentTag = Prefixed_Name(tddfa, "argumentTag") |> PrefixedName
    /// <summary>
    ///   <para>w3id:todo/tododfa#belongsToAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Establishes the relation between an Intent and the Action it belongs to."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"belongsToAction"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/todo/tododfa#belongsToAction">https://w3id.org/todo/tododfa#belongsToAction</seealso>
    let belongsToAction = Prefixed_Name(tddfa, "belongsToAction") |> PrefixedName
    /// <summary>
    ///   <para>w3id:todo/tododfa#belongsToIntent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Establishes the relation between an Action and the Intent it belongs to."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"belongsToIntent"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/todo/tododfa#belongsToIntent">https://w3id.org/todo/tododfa#belongsToIntent</seealso>
    let belongsToIntent = Prefixed_Name(tddfa, "belongsToIntent") |> PrefixedName
    /// <summary>
    ///   <para>w3id:todo/tododfa#hasArgument</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Establishes a relation between an Action and its Argument(s)."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"hasArgument"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/todo/tododfa#hasArgument">https://w3id.org/todo/tododfa#hasArgument</seealso>
    let hasArgument = Prefixed_Name(tddfa, "hasArgument") |> PrefixedName
    /// <summary>
    ///   <para>w3id:todo/tododfa#hasArgumentSet</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"Establishes a relation between an Action and the set composed of its Argument(s)."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"hasArgumentSet"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/todo/tododfa#hasArgumentSet">https://w3id.org/todo/tododfa#hasArgumentSet</seealso>
    let hasArgumentSet = Prefixed_Name(tddfa, "hasArgumentSet") |> PrefixedName
    /// <summary>
    ///   <para>w3id:todo/tododfa#hasCoreArgument</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Establishes a relation between an Action and its CoreArguments (i.e. the arguments that are compulsory in order to perform the Action)."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"hasCoreArgument"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/todo/tododfa#hasCoreArgument">https://w3id.org/todo/tododfa#hasCoreArgument</seealso>
    let hasCoreArgument = Prefixed_Name(tddfa, "hasCoreArgument") |> PrefixedName
    /// <summary>
    ///   <para>w3id:todo/tododfa#hasFomaGrammar</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"Establishes a relation between a Skill and the FomaGrammar to use to perform Key Element Extraction."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"hasFomaGrammar"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/todo/tododfa#hasFomaGrammar">https://w3id.org/todo/tododfa#hasFomaGrammar</seealso>
    let hasFomaGrammar = Prefixed_Name(tddfa, "hasFomaGrammar") |> PrefixedName
    /// <summary>
    ///   <para>w3id:todo/tododfa#hasFrame</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Establishes a relation between an Intent and its corresponding Frame."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"hasFrame"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/todo/tododfa#hasFrame">https://w3id.org/todo/tododfa#hasFrame</seealso>
    let hasFrame = Prefixed_Name(tddfa, "hasFrame") |> PrefixedName
    /// <summary>
    ///   <para>w3id:todo/tododfa#hasFrameHead</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:InverseFunctionalProperty</para>
    ///   <para>"Establishes a relation between a Frame and its FrameHead."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"hasFrameHead"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/todo/tododfa#hasFrameHead">https://w3id.org/todo/tododfa#hasFrameHead</seealso>
    let hasFrameHead = Prefixed_Name(tddfa, "hasFrameHead") |> PrefixedName
    /// <summary>
    ///   <para>w3id:todo/tododfa#hasIntent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Establishes a relation between a Skill and its corresponding Intent(s)."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"hasIntent"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/todo/tododfa#hasIntent">https://w3id.org/todo/tododfa#hasIntent</seealso>
    let hasIntent = Prefixed_Name(tddfa, "hasIntent") |> PrefixedName

    /// <summary>
    ///   <para>w3id:todo/tododfa#hasOptionalArgument</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Establishes a relation between an Action and its OptionalArguments (i.e. the arguments that are not compulsory in order to perform the Action)."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"hasOptionalArgument"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/todo/tododfa#hasOptionalArgument">https://w3id.org/todo/tododfa#hasOptionalArgument</seealso>
    let hasOptionalArgument =
        Prefixed_Name(tddfa, "hasOptionalArgument") |> PrefixedName

    /// <summary>
    ///   <para>w3id:todo/tododfa#isArgumentOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Establishes a relation between an Argument and its corresponding Action."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"isArgumentOf"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/todo/tododfa#isArgumentOf">https://w3id.org/todo/tododfa#isArgumentOf</seealso>
    let isArgumentOf = Prefixed_Name(tddfa, "isArgumentOf") |> PrefixedName
    /// <summary>
    ///   <para>w3id:todo/tododfa#isArgumentSetOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:InverseFunctionalProperty</para>
    ///   <para>"Establishes a relation between an ArgumentSet and the Action it corresponds to."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"isArgumentSetOf"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/todo/tododfa#isArgumentSetOf">https://w3id.org/todo/tododfa#isArgumentSetOf</seealso>
    let isArgumentSetOf = Prefixed_Name(tddfa, "isArgumentSetOf") |> PrefixedName
    /// <summary>
    ///   <para>w3id:todo/tododfa#isCoreArgumentOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Establishes a relation between a CoreArgument (i.e. the arguments that are compulsory in order to perform the Action) and its corresponding Action."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"https://w3id.org/todo/tododfa#"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"isCoreArgumentOf"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/todo/tododfa#isCoreArgumentOf">https://w3id.org/todo/tododfa#isCoreArgumentOf</seealso>
    let isCoreArgumentOf = Prefixed_Name(tddfa, "isCoreArgumentOf") |> PrefixedName
    /// <summary>
    ///   <para>w3id:todo/tododfa#isFomaGrammarOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:InverseFunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"https://w3id.org/todo/tododfa#"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"Establishes a relation between the FomaGrammar to use to perform Key Element Extraction and a Skill."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"isFomaGrammarOf"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/todo/tododfa#isFomaGrammarOf">https://w3id.org/todo/tododfa#isFomaGrammarOf</seealso>
    let isFomaGrammarOf = Prefixed_Name(tddfa, "isFomaGrammarOf") |> PrefixedName
    /// <summary>
    ///   <para>w3id:todo/tododfa#isFrameHeadOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"Establishes a relation between a FrameHead and the Frame it applies to."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"https://w3id.org/todo/tododfa#"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"isFrameHeadOf"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/todo/tododfa#isFrameHeadOf">https://w3id.org/todo/tododfa#isFrameHeadOf</seealso>
    let isFrameHeadOf = Prefixed_Name(tddfa, "isFrameHeadOf") |> PrefixedName
    /// <summary>
    ///   <para>w3id:todo/tododfa#isFrameOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Establishes a relation between a Frame and the Intent it corresponds to."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"https://w3id.org/todo/tododfa#"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"isFrameOf"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/todo/tododfa#isFrameOf">https://w3id.org/todo/tododfa#isFrameOf</seealso>
    let isFrameOf = Prefixed_Name(tddfa, "isFrameOf") |> PrefixedName
    /// <summary>
    ///   <para>w3id:todo/tododfa#isIntentOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Establishes a relation between an Intent and its corresponding Skill."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"isIntentOf"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/todo/tododfa#isIntentOf">https://w3id.org/todo/tododfa#isIntentOf</seealso>
    let isIntentOf = Prefixed_Name(tddfa, "isIntentOf") |> PrefixedName

    /// <summary>
    ///   <para>w3id:todo/tododfa#isOptionalArgumentOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Establishes a relation between an Optional Argument (i.e. the arguments that are not compulsory in order to perform the Action) and its corresponding Action."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"isOptionalArgumentOf"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/todo/tododfa#isOptionalArgumentOf">https://w3id.org/todo/tododfa#isOptionalArgumentOf</seealso>
    let isOptionalArgumentOf =
        Prefixed_Name(tddfa, "isOptionalArgumentOf") |> PrefixedName
