namespace https.spec.edmcouncil.org.fibo.ontology.FND.Arrangements.Lifecycles.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module fibo_fnd_arr_lif =
    let _namespace_iri = Namespace_Iri fibo_fnd_arr_lif |> NamespaceIRI
    /// <summary>
    ///   <para>fibo-fnd-arr-lif:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///
    /// labels<para>"Lifecycles Ontology"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Lifecycles/">https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Lifecycles/</seealso>
    let _prefix_iri = Prefixed_Name(fibo_fnd_arr_lif, "") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fnd-arr-lif:Lifecycle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"lifecycle"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Lifecycles/Lifecycle">https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Lifecycles/Lifecycle</seealso>
    let Lifecycle = Prefixed_Name(fibo_fnd_arr_lif, "Lifecycle") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-arr-lif:LifecycleEvent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"lifecycle event"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Lifecycles/LifecycleEvent">https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Lifecycles/LifecycleEvent</seealso>
    let LifecycleEvent =
        Prefixed_Name(fibo_fnd_arr_lif, "LifecycleEvent") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-arr-lif:LifecycleEventOccurrence</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"lifecycle event occurrence"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Lifecycles/LifecycleEventOccurrence">https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Lifecycles/LifecycleEventOccurrence</seealso>
    let LifecycleEventOccurrence =
        Prefixed_Name(fibo_fnd_arr_lif, "LifecycleEventOccurrence") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-arr-lif:LifecycleOccurrence</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"lifecycle occurrence"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Lifecycles/LifecycleOccurrence">https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Lifecycles/LifecycleOccurrence</seealso>
    let LifecycleOccurrence =
        Prefixed_Name(fibo_fnd_arr_lif, "LifecycleOccurrence") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-arr-lif:LifecycleStage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"lifecycle stage"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Lifecycles/LifecycleStage">https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Lifecycles/LifecycleStage</seealso>
    let LifecycleStage =
        Prefixed_Name(fibo_fnd_arr_lif, "LifecycleStage") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-arr-lif:LifecycleStageOccurrence</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"lifecycle stage occurrence"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Lifecycles/LifecycleStageOccurrence">https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Lifecycles/LifecycleStageOccurrence</seealso>
    let LifecycleStageOccurrence =
        Prefixed_Name(fibo_fnd_arr_lif, "LifecycleStageOccurrence") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-arr-lif:LifecycleStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"lifecycle status"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Lifecycles/LifecycleStatus">https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Lifecycles/LifecycleStatus</seealso>
    let LifecycleStatus =
        Prefixed_Name(fibo_fnd_arr_lif, "LifecycleStatus") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-arr-lif:hasLifecycle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has lifecycle"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Lifecycles/hasLifecycle">https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Lifecycles/hasLifecycle</seealso>
    let hasLifecycle = Prefixed_Name(fibo_fnd_arr_lif, "hasLifecycle") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fnd-arr-lif:hasStage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"has stage"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Lifecycles/hasStage">https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Lifecycles/hasStage</seealso>
    let hasStage = Prefixed_Name(fibo_fnd_arr_lif, "hasStage") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fnd-arr-lif:isLifecycleOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is lifecycle of"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Lifecycles/isLifecycleOf">https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Lifecycles/isLifecycleOf</seealso>
    let isLifecycleOf = Prefixed_Name(fibo_fnd_arr_lif, "isLifecycleOf") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fnd-arr-lif:isStageOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"is stage of"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Lifecycles/isStageOf">https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Lifecycles/isStageOf</seealso>
    let isStageOf = Prefixed_Name(fibo_fnd_arr_lif, "isStageOf") |> PrefixedName
