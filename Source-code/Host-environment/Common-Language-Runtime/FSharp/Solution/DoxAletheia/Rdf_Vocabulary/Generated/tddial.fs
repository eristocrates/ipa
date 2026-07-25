namespace https.w3id.org.todo.tododial.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module tddial =
    let _namespace_iri = Namespace_Iri tddial |> NamespaceIRI
    /// <summary>
    ///   <para>tddial:hasTrace</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Establishes the relationship between an element and its Trace.</para>
    /// labels<para>hasTrace</para></remarks>
    /// <seealso href="https://w3id.org/todo/tododial#hasTrace">https://w3id.org/todo/tododial#hasTrace</seealso>
    let hasTrace = Prefixed_Name(tddial, "hasTrace") |> PrefixedName

    /// <summary>
    ///   <para>tddial:hasDialogueProcessStep</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Establishes the DialogueProcessStep corresponding to a DialogueTrace.</para>
    /// labels<para>hasDialogueProcessStep</para></remarks>
    /// <seealso href="https://w3id.org/todo/tododial#hasDialogueProcessStep">https://w3id.org/todo/tododial#hasDialogueProcessStep</seealso>
    let hasDialogueProcessStep =
        Prefixed_Name(tddial, "hasDialogueProcessStep") |> PrefixedName

    /// <summary>
    ///   <para>tddial:isTraceOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Establishes the relationship between a Trace and the element it refers to.</para>
    /// labels<para>isTraceOf</para></remarks>
    /// <seealso href="https://w3id.org/todo/tododial#isTraceOf">https://w3id.org/todo/tododial#isTraceOf</seealso>
    let isTraceOf = Prefixed_Name(tddial, "isTraceOf") |> PrefixedName
