namespace https.spec.edmcouncil.org.fibo.ontology.FND.Places.RealProperty.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module fibo_fnd_plc_rp =
    let _namespace_iri = Namespace_Iri fibo_fnd_plc_rp |> NamespaceIRI
    /// <summary>
    ///   <para>fibo-fnd-plc-rp:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///
    /// labels<para>"Real Property Ontology"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/RealProperty/">https://spec.edmcouncil.org/fibo/ontology/FND/Places/RealProperty/</seealso>
    let _prefix_iri = Prefixed_Name(fibo_fnd_plc_rp, "") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-plc-rp:PersonalProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"personal property"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/RealProperty/PersonalProperty">https://spec.edmcouncil.org/fibo/ontology/FND/Places/RealProperty/PersonalProperty</seealso>
    let PersonalProperty =
        Prefixed_Name(fibo_fnd_plc_rp, "PersonalProperty") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-plc-rp:PropertyInspection</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"property inspection"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/RealProperty/PropertyInspection">https://spec.edmcouncil.org/fibo/ontology/FND/Places/RealProperty/PropertyInspection</seealso>
    let PropertyInspection =
        Prefixed_Name(fibo_fnd_plc_rp, "PropertyInspection") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-plc-rp:PropertyInspectionReport</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"property inspection report"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/RealProperty/PropertyInspectionReport">https://spec.edmcouncil.org/fibo/ontology/FND/Places/RealProperty/PropertyInspectionReport</seealso>
    let PropertyInspectionReport =
        Prefixed_Name(fibo_fnd_plc_rp, "PropertyInspectionReport") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-plc-rp:RealEstate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"real estate"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/RealProperty/RealEstate">https://spec.edmcouncil.org/fibo/ontology/FND/Places/RealProperty/RealEstate</seealso>
    let RealEstate = Prefixed_Name(fibo_fnd_plc_rp, "RealEstate") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fnd-plc-rp:RealProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"real property"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/RealProperty/RealProperty">https://spec.edmcouncil.org/fibo/ontology/FND/Places/RealProperty/RealProperty</seealso>
    let RealProperty = Prefixed_Name(fibo_fnd_plc_rp, "RealProperty") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-plc-rp:RealPropertyAppraisal</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"real property appraisal"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/RealProperty/RealPropertyAppraisal">https://spec.edmcouncil.org/fibo/ontology/FND/Places/RealProperty/RealPropertyAppraisal</seealso>
    let RealPropertyAppraisal =
        Prefixed_Name(fibo_fnd_plc_rp, "RealPropertyAppraisal") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-plc-rp:RealPropertyIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"real property identifier"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/RealProperty/RealPropertyIdentifier">https://spec.edmcouncil.org/fibo/ontology/FND/Places/RealProperty/RealPropertyIdentifier</seealso>
    let RealPropertyIdentifier =
        Prefixed_Name(fibo_fnd_plc_rp, "RealPropertyIdentifier") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-plc-rp:TractIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/RealProperty/TractIdentifier">https://spec.edmcouncil.org/fibo/ontology/FND/Places/RealProperty/TractIdentifier</seealso>
    let TractIdentifier =
        Prefixed_Name(fibo_fnd_plc_rp, "TractIdentifier") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-plc-rp:TractOfLand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/RealProperty/TractOfLand">https://spec.edmcouncil.org/fibo/ontology/FND/Places/RealProperty/TractOfLand</seealso>
    let TractOfLand = Prefixed_Name(fibo_fnd_plc_rp, "TractOfLand") |> PrefixedName
