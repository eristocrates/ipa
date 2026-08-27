namespace https.spec.edmcouncil.org.fibo.ontology.FBC.FunctionalEntities.BusinessCenters.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module fibo_fbc_fct_bc =
    let _namespace_iri = Namespace_Iri fibo_fbc_fct_bc |> NamespaceIRI
    /// <summary>
    ///   <para>fibo-fbc-fct-bc:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///
    /// labels<para>"Business Centers Ontology"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessCenters/">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessCenters/</seealso>
    let _prefix_iri = Prefixed_Name(fibo_fbc_fct_bc, "") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-bc:BusinessCenterCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"business center code"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessCenters/BusinessCenterCode">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessCenters/BusinessCenterCode</seealso>
    let BusinessCenterCode =
        Prefixed_Name(fibo_fbc_fct_bc, "BusinessCenterCode") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-bc:BusinessCenterCodeScheme</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"business center code set"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessCenters/BusinessCenterCodeScheme">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessCenters/BusinessCenterCodeScheme</seealso>
    let BusinessCenterCodeScheme =
        Prefixed_Name(fibo_fbc_fct_bc, "BusinessCenterCodeScheme") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-bc:BusinessDayAdjustmentCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"business day adjustment code"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessCenters/BusinessDayAdjustmentCode">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessCenters/BusinessDayAdjustmentCode</seealso>
    let BusinessDayAdjustmentCode =
        Prefixed_Name(fibo_fbc_fct_bc, "BusinessDayAdjustmentCode") |> PrefixedName
