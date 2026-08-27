namespace https.w3id.org.todo.tododial.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module tddial =
    let _namespace_iri = Namespace_Iri tddial |> NamespaceIRI
    /// <summary>
    ///   <para>w3id:todo/tododial#UserRequestTrace</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/todo/tododial#UserRequestTrace">https://w3id.org/todo/tododial#UserRequestTrace</seealso>
    let UserRequestTrace = Prefixed_Name(tddial, "UserRequestTrace") |> PrefixedName

    /// <summary>
    ///   <para>w3id:todo/tododial#hasDialogueProcessStep</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Establishes the DialogueProcessStep corresponding to a DialogueTrace."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"hasDialogueProcessStep"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/todo/tododial#hasDialogueProcessStep">https://w3id.org/todo/tododial#hasDialogueProcessStep</seealso>
    let hasDialogueProcessStep =
        Prefixed_Name(tddial, "hasDialogueProcessStep") |> PrefixedName

    /// <summary>
    ///   <para>w3id:todo/tododial#hasTrace</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Establishes the relationship between an element and its Trace."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"hasTrace"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/todo/tododial#hasTrace">https://w3id.org/todo/tododial#hasTrace</seealso>
    let hasTrace = Prefixed_Name(tddial, "hasTrace") |> PrefixedName
    /// <summary>
    ///   <para>w3id:todo/tododial#isTraceOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Establishes the relationship between a Trace and the element it refers to."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"isTraceOf"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/todo/tododial#isTraceOf">https://w3id.org/todo/tododial#isTraceOf</seealso>
    let isTraceOf = Prefixed_Name(tddial, "isTraceOf") |> PrefixedName
