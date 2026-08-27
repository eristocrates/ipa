namespace https.spec.edmcouncil.org.fibo.ontology.FND.Arrangements.ClassificationSchemes.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module fibo_fnd_arr_cls =
    let _namespace_iri = Namespace_Iri fibo_fnd_arr_cls |> NamespaceIRI
    /// <summary>
    ///   <para>fibo-fnd-arr-cls:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///
    /// labels<para>"Classification Schemes Ontology"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/ClassificationSchemes/">https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/ClassificationSchemes/</seealso>
    let _prefix_iri = Prefixed_Name(fibo_fnd_arr_cls, "") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-arr-cls:IndustrySectorClassificationScheme</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"industry sector classification scheme"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/ClassificationSchemes/IndustrySectorClassificationScheme">https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/ClassificationSchemes/IndustrySectorClassificationScheme</seealso>
    let IndustrySectorClassificationScheme =
        Prefixed_Name(fibo_fnd_arr_cls, "IndustrySectorClassificationScheme") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-arr-cls:IndustrySectorClassifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"industry sector classifier"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/ClassificationSchemes/IndustrySectorClassifier">https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/ClassificationSchemes/IndustrySectorClassifier</seealso>
    let IndustrySectorClassifier =
        Prefixed_Name(fibo_fnd_arr_cls, "IndustrySectorClassifier") |> PrefixedName
