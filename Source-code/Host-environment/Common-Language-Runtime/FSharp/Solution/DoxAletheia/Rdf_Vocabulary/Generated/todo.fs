namespace https.w3id.org.todo.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module todo =
    let _namespace_iri = Namespace_Iri todo |> NamespaceIRI
    /// <summary>
    ///   <para>todo:hasActionTrace</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>Establishes the relationship between an Action and its Trace</para>
    /// labels<para>hasActionTrace</para></remarks>
    /// <seealso href="https://w3id.org/todo#hasActionTrace">https://w3id.org/todo#hasActionTrace</seealso>
    let hasActionTrace = Prefixed_Name(todo, "hasActionTrace") |> PrefixedName
    /// <summary>
    ///   <para>todo:obtainedThrough</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>Establishes a relation between a Trace (ActionTrace/ArgumentTrace/WorldElementTrace) and the SecondaryDialogue performed to obtain said Trace.</para>
    /// labels<para>obtainedThrough</para></remarks>
    /// <seealso href="https://w3id.org/todo#obtainedThrough">https://w3id.org/todo#obtainedThrough</seealso>
    let obtainedThrough = Prefixed_Name(todo, "obtainedThrough") |> PrefixedName
    /// <summary>
    ///   <para>todo:hasObtained</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:InverseFunctionalProperty</para>
    ///   <para>Establishes a relation between a SecondaryDialogue and the information (ActionTrace/ArgumentTrace/WorldElementTrace) that has been obtained thanks to it.</para>
    /// labels<para>hasObtained</para></remarks>
    /// <seealso href="https://w3id.org/todo#hasObtained">https://w3id.org/todo#hasObtained</seealso>
    let hasObtained = Prefixed_Name(todo, "hasObtained") |> PrefixedName
    /// <summary>
    ///   <para>todo:isActionTraceOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:InverseFunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Establishes the relationship between an ActionTrace and the Action it refers to.</para>
    /// labels<para>isActionTraceOf</para></remarks>
    /// <seealso href="https://w3id.org/todo#isActionTraceOf">https://w3id.org/todo#isActionTraceOf</seealso>
    let isActionTraceOf = Prefixed_Name(todo, "isActionTraceOf") |> PrefixedName
