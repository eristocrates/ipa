namespace https.spec.edmcouncil.org.fibo.ontology.FND.Arrangements.IdentifiersAndIndices.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module fibo_fnd_arr_id =
    let _namespace_iri = Namespace_Iri fibo_fnd_arr_id |> NamespaceIRI
    /// <summary>
    ///   <para>fibo-fnd-arr-id:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///
    /// labels<para>"Identifiers and Indices Ontology"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/IdentifiersAndIndices/">https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/IdentifiersAndIndices/</seealso>
    let _prefix_iri = Prefixed_Name(fibo_fnd_arr_id, "") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fnd-arr-id:Index</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"index"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/IdentifiersAndIndices/Index">https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/IdentifiersAndIndices/Index</seealso>
    let Index = Prefixed_Name(fibo_fnd_arr_id, "Index") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-arr-id:IndexingScheme</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"indexing scheme"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/IdentifiersAndIndices/IndexingScheme">https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/IdentifiersAndIndices/IndexingScheme</seealso>
    let IndexingScheme =
        Prefixed_Name(fibo_fnd_arr_id, "IndexingScheme") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-arr-id:ReassignableIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"reassignable identifier"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/IdentifiersAndIndices/ReassignableIdentifier">https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/IdentifiersAndIndices/ReassignableIdentifier</seealso>
    let ReassignableIdentifier =
        Prefixed_Name(fibo_fnd_arr_id, "ReassignableIdentifier") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-arr-id:constructRegex</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///
    /// labels<para>"construct regex"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/IdentifiersAndIndices/constructRegex">https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/IdentifiersAndIndices/constructRegex</seealso>
    let constructRegex =
        Prefixed_Name(fibo_fnd_arr_id, "constructRegex") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-arr-id:hasAssignmentTerminationDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"has assignment termination date"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/IdentifiersAndIndices/hasAssignmentTerminationDate">https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/IdentifiersAndIndices/hasAssignmentTerminationDate</seealso>
    let hasAssignmentTerminationDate =
        Prefixed_Name(fibo_fnd_arr_id, "hasAssignmentTerminationDate") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-arr-id:hasInitialAssignmentDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"has initial assignment date"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/IdentifiersAndIndices/hasInitialAssignmentDate">https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/IdentifiersAndIndices/hasInitialAssignmentDate</seealso>
    let hasInitialAssignmentDate =
        Prefixed_Name(fibo_fnd_arr_id, "hasInitialAssignmentDate") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-arr-id:isIndexTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is index to"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/IdentifiersAndIndices/isIndexTo">https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/IdentifiersAndIndices/isIndexTo</seealso>
    let isIndexTo = Prefixed_Name(fibo_fnd_arr_id, "isIndexTo") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fnd-arr-id:parseRegex</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///
    /// labels<para>"parse regex"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/IdentifiersAndIndices/parseRegex">https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/IdentifiersAndIndices/parseRegex</seealso>
    let parseRegex = Prefixed_Name(fibo_fnd_arr_id, "parseRegex") |> PrefixedName
