namespace https.spec.edmcouncil.org.fibo.ontology.FND.Arrangements.Arrangements.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module fibo_fnd_arr_arr =
    let _namespace_iri = Namespace_Iri fibo_fnd_arr_arr |> NamespaceIRI
    /// <summary>
    ///   <para>fibo-fnd-arr-arr:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///
    /// labels<para>"Arrangements Ontology"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Arrangements/">https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Arrangements/</seealso>
    let _prefix_iri = Prefixed_Name(fibo_fnd_arr_arr, "") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fnd-arr-arr:Scheme</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"scheme"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Arrangements/Scheme">https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Arrangements/Scheme</seealso>
    let Scheme = Prefixed_Name(fibo_fnd_arr_arr, "Scheme") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-arr-arr:hasCollectionSize</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"has collection size"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Arrangements/hasCollectionSize">https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Arrangements/hasCollectionSize</seealso>
    let hasCollectionSize =
        Prefixed_Name(fibo_fnd_arr_arr, "hasCollectionSize") |> PrefixedName
