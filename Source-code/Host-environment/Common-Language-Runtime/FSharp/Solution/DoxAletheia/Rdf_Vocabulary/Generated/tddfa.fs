namespace https.w3id.org.todo.tododfa.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module tddfa =
    let _namespace_iri = Namespace_Iri tddfa |> NamespaceIRI
    /// <summary>
    ///   <para>tddfa:Argument</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Participant that is involved in the event described by the Frame. It can be Core (its presence is compulsory to convey the event) or Optional (its presence is not compulsory, but it adds additional information).</para>
    /// labels<para>Argument</para></remarks>
    /// <seealso href="https://w3id.org/todo/tododfa#Argument">https://w3id.org/todo/tododfa#Argument</seealso>
    let Argument = Prefixed_Name(tddfa, "Argument") |> PrefixedName
    /// <summary>
    ///   <para>tddfa:FomaGrammar</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Grammar to be used by Foma to perform Key Element Extraction.</para>
    /// labels<para>FomaGrammar</para></remarks>
    /// <seealso href="https://w3id.org/todo/tododfa#FomaGrammar">https://w3id.org/todo/tododfa#FomaGrammar</seealso>
    let FomaGrammar = Prefixed_Name(tddfa, "FomaGrammar") |> PrefixedName
    /// <summary>
    ///   <para>tddfa:Skill</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Element that makes reference to the capabilities of the target system.</para>
    /// labels<para>Skill</para></remarks>
    /// <seealso href="https://w3id.org/todo/tododfa#Skill">https://w3id.org/todo/tododfa#Skill</seealso>
    let Skill = Prefixed_Name(tddfa, "Skill") |> PrefixedName
    /// <summary>
    ///   <para>tddfa:FrameHead</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Word (or more than one) that evokes a specific situation or event, with its specific participants; that is, a frame. It is represented by one or more LexicalUnits.</para>
    /// labels<para>FrameHead</para></remarks>
    /// <seealso href="https://w3id.org/todo/tododfa#FrameHead">https://w3id.org/todo/tododfa#FrameHead</seealso>
    let FrameHead = Prefixed_Name(tddfa, "FrameHead") |> PrefixedName
    /// <summary>
    ///   <para>tddfa:hasArgumentSet</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Establishes a relation between an Action and the set composed of its Argument(s).</para>
    /// labels<para>hasArgumentSet</para></remarks>
    /// <seealso href="https://w3id.org/todo/tododfa#hasArgumentSet">https://w3id.org/todo/tododfa#hasArgumentSet</seealso>
    let hasArgumentSet = Prefixed_Name(tddfa, "hasArgumentSet") |> PrefixedName
    /// <summary>
    ///   <para>tddfa:hasFrameHead</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:InverseFunctionalProperty</para>
    ///   <para>Establishes a relation between a Frame and its FrameHead.</para>
    /// labels<para>hasFrameHead</para></remarks>
    /// <seealso href="https://w3id.org/todo/tododfa#hasFrameHead">https://w3id.org/todo/tododfa#hasFrameHead</seealso>
    let hasFrameHead = Prefixed_Name(tddfa, "hasFrameHead") |> PrefixedName
    /// <summary>
    ///   <para>tddfa:belongsToIntent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Establishes the relation between an Action and the Intent it belongs to.</para>
    /// labels<para>belongsToIntent</para></remarks>
    /// <seealso href="https://w3id.org/todo/tododfa#belongsToIntent">https://w3id.org/todo/tododfa#belongsToIntent</seealso>
    let belongsToIntent = Prefixed_Name(tddfa, "belongsToIntent") |> PrefixedName
    /// <summary>
    ///   <para>tddfa:isFrameOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>https://w3id.org/todo/tododfa#</para>
    ///   <para>Establishes a relation between a Frame and the Intent it corresponds to.</para>
    /// labels<para>isFrameOf</para></remarks>
    /// <seealso href="https://w3id.org/todo/tododfa#isFrameOf">https://w3id.org/todo/tododfa#isFrameOf</seealso>
    let isFrameOf = Prefixed_Name(tddfa, "isFrameOf") |> PrefixedName
    /// <summary>
    ///   <para>tddfa:belongsToAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Establishes the relation between an Intent and the Action it belongs to.</para>
    /// labels<para>belongsToAction</para></remarks>
    /// <seealso href="https://w3id.org/todo/tododfa#belongsToAction">https://w3id.org/todo/tododfa#belongsToAction</seealso>
    let belongsToAction = Prefixed_Name(tddfa, "belongsToAction") |> PrefixedName
    /// <summary>
    ///   <para>tddfa:hasArgument</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Establishes a relation between an Action and its Argument(s).</para>
    /// labels<para>hasArgument</para></remarks>
    /// <seealso href="https://w3id.org/todo/tododfa#hasArgument">https://w3id.org/todo/tododfa#hasArgument</seealso>
    let hasArgument = Prefixed_Name(tddfa, "hasArgument") |> PrefixedName
    /// <summary>
    ///   <para>tddfa:isArgumentOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Establishes a relation between an Argument and its corresponding Action.</para>
    /// labels<para>isArgumentOf</para></remarks>
    /// <seealso href="https://w3id.org/todo/tododfa#isArgumentOf">https://w3id.org/todo/tododfa#isArgumentOf</seealso>
    let isArgumentOf = Prefixed_Name(tddfa, "isArgumentOf") |> PrefixedName
    /// <summary>
    ///   <para>tddfa:actionTag</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>String that identifies the Action when invoked in a SystemRequest/Response (DomainONT).</para>
    /// labels<para>actionTag</para></remarks>
    /// <seealso href="https://w3id.org/todo/tododfa#actionTag">https://w3id.org/todo/tododfa#actionTag</seealso>
    let actionTag = Prefixed_Name(tddfa, "actionTag") |> PrefixedName
    /// <summary>
    ///   <para>tddfa:argumentTag</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>String that identifies the Argument when invoked in a SystemRequest/Response (DomainONT)</para>
    /// labels<para>argumentTag</para></remarks>
    /// <seealso href="https://w3id.org/todo/tododfa#argumentTag">https://w3id.org/todo/tododfa#argumentTag</seealso>
    let argumentTag = Prefixed_Name(tddfa, "argumentTag") |> PrefixedName
    /// <summary>
    ///   <para>tddfa:isArgumentSetOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:InverseFunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Establishes a relation between an ArgumentSet and the Action it corresponds to.</para>
    /// labels<para>isArgumentSetOf</para></remarks>
    /// <seealso href="https://w3id.org/todo/tododfa#isArgumentSetOf">https://w3id.org/todo/tododfa#isArgumentSetOf</seealso>
    let isArgumentSetOf = Prefixed_Name(tddfa, "isArgumentSetOf") |> PrefixedName
    /// <summary>
    ///   <para>tddfa:isFomaGrammarOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:InverseFunctionalProperty</para>
    ///   <para>Establishes a relation between the FomaGrammar to use to perform Key Element Extraction and a Skill.</para>
    ///   <para>https://w3id.org/todo/tododfa#</para>
    /// labels<para>isFomaGrammarOf</para></remarks>
    /// <seealso href="https://w3id.org/todo/tododfa#isFomaGrammarOf">https://w3id.org/todo/tododfa#isFomaGrammarOf</seealso>
    let isFomaGrammarOf = Prefixed_Name(tddfa, "isFomaGrammarOf") |> PrefixedName
    /// <summary>
    ///   <para>tddfa:isFrameHeadOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>Establishes a relation between a FrameHead and the Frame it applies to.</para>
    ///   <para>https://w3id.org/todo/tododfa#</para>
    /// labels<para>isFrameHeadOf</para></remarks>
    /// <seealso href="https://w3id.org/todo/tododfa#isFrameHeadOf">https://w3id.org/todo/tododfa#isFrameHeadOf</seealso>
    let isFrameHeadOf = Prefixed_Name(tddfa, "isFrameHeadOf") |> PrefixedName
    /// <summary>
    ///   <para>tddfa:hasFrame</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Establishes a relation between an Intent and its corresponding Frame.</para>
    /// labels<para>hasFrame</para></remarks>
    /// <seealso href="https://w3id.org/todo/tododfa#hasFrame">https://w3id.org/todo/tododfa#hasFrame</seealso>
    let hasFrame = Prefixed_Name(tddfa, "hasFrame") |> PrefixedName
    /// <summary>
    ///   <para>tddfa:hasIntent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Establishes a relation between a Skill and its corresponding Intent(s).</para>
    /// labels<para>hasIntent</para></remarks>
    /// <seealso href="https://w3id.org/todo/tododfa#hasIntent">https://w3id.org/todo/tododfa#hasIntent</seealso>
    let hasIntent = Prefixed_Name(tddfa, "hasIntent") |> PrefixedName
    /// <summary>
    ///   <para>tddfa:argumentConnector</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>String that defines the word that acts as a connector between the Argument and the rest of elements in a SystemRequest/Response.</para>
    /// labels<para>argumentConnector</para></remarks>
    /// <seealso href="https://w3id.org/todo/tododfa#argumentConnector">https://w3id.org/todo/tododfa#argumentConnector</seealso>
    let argumentConnector = Prefixed_Name(tddfa, "argumentConnector") |> PrefixedName
    /// <summary>
    ///   <para>tddfa:hasCoreArgument</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Establishes a relation between an Action and its CoreArguments (i.e. the arguments that are compulsory in order to perform the Action).</para>
    /// labels<para>hasCoreArgument</para></remarks>
    /// <seealso href="https://w3id.org/todo/tododfa#hasCoreArgument">https://w3id.org/todo/tododfa#hasCoreArgument</seealso>
    let hasCoreArgument = Prefixed_Name(tddfa, "hasCoreArgument") |> PrefixedName

    /// <summary>
    ///   <para>tddfa:hasOptionalArgument</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Establishes a relation between an Action and its OptionalArguments (i.e. the arguments that are not compulsory in order to perform the Action).</para>
    /// labels<para>hasOptionalArgument</para></remarks>
    /// <seealso href="https://w3id.org/todo/tododfa#hasOptionalArgument">https://w3id.org/todo/tododfa#hasOptionalArgument</seealso>
    let hasOptionalArgument =
        Prefixed_Name(tddfa, "hasOptionalArgument") |> PrefixedName

    /// <summary>
    ///   <para>tddfa:isIntentOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Establishes a relation between an Intent and its corresponding Skill.</para>
    /// labels<para>isIntentOf</para></remarks>
    /// <seealso href="https://w3id.org/todo/tododfa#isIntentOf">https://w3id.org/todo/tododfa#isIntentOf</seealso>
    let isIntentOf = Prefixed_Name(tddfa, "isIntentOf") |> PrefixedName
    /// <summary>
    ///   <para>tddfa:isCoreArgumentOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>https://w3id.org/todo/tododfa#</para>
    ///   <para>Establishes a relation between a CoreArgument (i.e. the arguments that are compulsory in order to perform the Action) and its corresponding Action.</para>
    /// labels<para>isCoreArgumentOf</para></remarks>
    /// <seealso href="https://w3id.org/todo/tododfa#isCoreArgumentOf">https://w3id.org/todo/tododfa#isCoreArgumentOf</seealso>
    let isCoreArgumentOf = Prefixed_Name(tddfa, "isCoreArgumentOf") |> PrefixedName

    /// <summary>
    ///   <para>tddfa:isOptionalArgumentOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Establishes a relation between an Optional Argument (i.e. the arguments that are not compulsory in order to perform the Action) and its corresponding Action.</para>
    /// labels<para>isOptionalArgumentOf</para></remarks>
    /// <seealso href="https://w3id.org/todo/tododfa#isOptionalArgumentOf">https://w3id.org/todo/tododfa#isOptionalArgumentOf</seealso>
    let isOptionalArgumentOf =
        Prefixed_Name(tddfa, "isOptionalArgumentOf") |> PrefixedName

    /// <summary>
    ///   <para>tddfa:hasFomaGrammar</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Establishes a relation between a Skill and the FomaGrammar to use to perform Key Element Extraction.</para>
    /// labels<para>hasFomaGrammar</para></remarks>
    /// <seealso href="https://w3id.org/todo/tododfa#hasFomaGrammar">https://w3id.org/todo/tododfa#hasFomaGrammar</seealso>
    let hasFomaGrammar = Prefixed_Name(tddfa, "hasFomaGrammar") |> PrefixedName
    /// <summary>
    ///   <para>tddfa:Action</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Element that makes reference to the functionalities of the target system.</para>
    /// labels<para>Action</para></remarks>
    /// <seealso href="https://w3id.org/todo/tododfa#Action">https://w3id.org/todo/tododfa#Action</seealso>
    let Action = Prefixed_Name(tddfa, "Action") |> PrefixedName
    /// <summary>
    ///   <para>tddfa:ArgumentSet</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The group of Arguments that belong to a Frame.</para>
    /// labels<para>ArgumentSet</para></remarks>
    /// <seealso href="https://w3id.org/todo/tododfa#ArgumentSet">https://w3id.org/todo/tododfa#ArgumentSet</seealso>
    let ArgumentSet = Prefixed_Name(tddfa, "ArgumentSet") |> PrefixedName
    /// <summary>
    ///   <para>tddfa:Frame</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A specific event or situation evoked by a specific word (FrameHead), along with its participants (Arguments).</para>
    /// labels<para>Frame</para></remarks>
    /// <seealso href="https://w3id.org/todo/tododfa#Frame">https://w3id.org/todo/tododfa#Frame</seealso>
    let Frame = Prefixed_Name(tddfa, "Frame") |> PrefixedName
    /// <summary>
    ///   <para>tddfa:Intent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>User intention when formulating a request.</para>
    /// labels<para>Intent</para></remarks>
    /// <seealso href="https://w3id.org/todo/tododfa#Intent">https://w3id.org/todo/tododfa#Intent</seealso>
    let Intent = Prefixed_Name(tddfa, "Intent") |> PrefixedName
