namespace https.w3id.org.todo.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module todo =
    let _namespace_iri = Namespace_Iri todo |> NamespaceIRI
    /// <summary>
    ///   <para>w3id:todo#hasActionTrace</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"Establishes the relationship between an Action and its Trace"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"hasActionTrace"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/todo#hasActionTrace">https://w3id.org/todo#hasActionTrace</seealso>
    let hasActionTrace = Prefixed_Name(todo, "hasActionTrace") |> PrefixedName
    /// <summary>
    ///   <para>w3id:todo#hasObtained</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:InverseFunctionalProperty</para>
    ///   <para>"Establishes a relation between a SecondaryDialogue and the information (ActionTrace/ArgumentTrace/WorldElementTrace) that has been obtained thanks to it."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"hasObtained"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/todo#hasObtained">https://w3id.org/todo#hasObtained</seealso>
    let hasObtained = Prefixed_Name(todo, "hasObtained") |> PrefixedName
    /// <summary>
    ///   <para>w3id:todo#isActionTraceOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:InverseFunctionalProperty</para>
    ///   <para>"Establishes the relationship between an ActionTrace and the Action it refers to."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"isActionTraceOf"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/todo#isActionTraceOf">https://w3id.org/todo#isActionTraceOf</seealso>
    let isActionTraceOf = Prefixed_Name(todo, "isActionTraceOf") |> PrefixedName
    /// <summary>
    ///   <para>w3id:todo#obtainedThrough</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Establishes a relation between a Trace (ActionTrace/ArgumentTrace/WorldElementTrace) and the SecondaryDialogue performed to obtain said Trace."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"obtainedThrough"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/todo#obtainedThrough">https://w3id.org/todo#obtainedThrough</seealso>
    let obtainedThrough = Prefixed_Name(todo, "obtainedThrough") |> PrefixedName
