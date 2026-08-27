namespace http.www.ontologydesignpatterns.org.cp.owl.sequence.owl.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module seq =
    let _namespace_iri = Namespace_Iri seq |> NamespaceIRI
    /// <summary>
    ///   <para>seq:directlyFollows</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The intransitive follows relation. For example, Wednesday directly precedes Thursday. Directness of precedence depends on the designer conceptualization."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"segue direttamente"</para><para>"directly follows"</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/cp/owl/sequence.owl#directlyFollows">http://www.ontologydesignpatterns.org/cp/owl/sequence.owl#directlyFollows</seealso>
    let directlyFollows = Prefixed_Name(seq, "directlyFollows") |> PrefixedName
    /// <summary>
    ///   <para>seq:directlyPrecedes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The intransitive precedes relation. For example, Monday directly precedes Tuesday. Directness of precedence depends on the designer conceptualization."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"directly precedes"</para><para>"precede direttamente"</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/cp/owl/sequence.owl#directlyPrecedes">http://www.ontologydesignpatterns.org/cp/owl/sequence.owl#directlyPrecedes</seealso>
    let directlyPrecedes = Prefixed_Name(seq, "directlyPrecedes") |> PrefixedName
    /// <summary>
    ///   <para>seq:follows</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>"A relation between entities, expressing a 'sequence' schema.
    /// E.g. 'year 2000 follows 1999', 'preparing coffee' follows 'deciding what coffee to use', 'II World War follows I World War', etc.
    /// It can be used between tasks, processes or time intervals, and subproperties would fit best in order to distinguish the different uses."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"segue"</para><para>"follows"</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/cp/owl/sequence.owl#follows">http://www.ontologydesignpatterns.org/cp/owl/sequence.owl#follows</seealso>
    let follows = Prefixed_Name(seq, "follows") |> PrefixedName
    /// <summary>
    ///   <para>seq:precedes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A relation between entities, expressing a 'sequence' schema.
    /// E.g. 'year 1999 precedes 2000', 'deciding what coffee to use' precedes 'preparing coffee', 'World War II follows World War I', 'in the Milan to Rome autoroute, Bologna precedes Florence', etc.
    /// It can then be used between tasks, processes, time intervals, spatially locate objects, situations, etc.
    /// Subproperties can be defined in order to distinguish the different uses."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"precedes"</para><para>"precede"</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/cp/owl/sequence.owl#precedes">http://www.ontologydesignpatterns.org/cp/owl/sequence.owl#precedes</seealso>
    let precedes = Prefixed_Name(seq, "precedes") |> PrefixedName
