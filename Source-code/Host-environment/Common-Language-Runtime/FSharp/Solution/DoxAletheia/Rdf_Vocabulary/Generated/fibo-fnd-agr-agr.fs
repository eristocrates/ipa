namespace https.spec.edmcouncil.org.fibo.ontology.FND.Agreements.Agreements.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module fibo_fnd_agr_agr =
    let _namespace_iri = Namespace_Iri fibo_fnd_agr_agr |> NamespaceIRI
    /// <summary>
    ///   <para>fibo-fnd-agr-agr:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///
    /// labels<para>"Agreements Ontology"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Agreements/">https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Agreements/</seealso>
    let _prefix_iri = Prefixed_Name(fibo_fnd_agr_agr, "") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fnd-agr-agr:Agreement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"agreement"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Agreements/Agreement">https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Agreements/Agreement</seealso>
    let Agreement = Prefixed_Name(fibo_fnd_agr_agr, "Agreement") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fnd-agr-agr:Beneficiary</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"beneficiary"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Agreements/Beneficiary">https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Agreements/Beneficiary</seealso>
    let Beneficiary = Prefixed_Name(fibo_fnd_agr_agr, "Beneficiary") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-agr-agr:BilateralAgreement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"bilateral agreement"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Agreements/BilateralAgreement">https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Agreements/BilateralAgreement</seealso>
    let BilateralAgreement =
        Prefixed_Name(fibo_fnd_agr_agr, "BilateralAgreement") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-agr-agr:Commitment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"commitment"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Agreements/Commitment">https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Agreements/Commitment</seealso>
    let Commitment = Prefixed_Name(fibo_fnd_agr_agr, "Commitment") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-agr-agr:CommitmentAtLarge</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"commitment at large"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Agreements/CommitmentAtLarge">https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Agreements/CommitmentAtLarge</seealso>
    let CommitmentAtLarge =
        Prefixed_Name(fibo_fnd_agr_agr, "CommitmentAtLarge") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-agr-agr:MultilateralAgreement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"multilateral agreement"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Agreements/MultilateralAgreement">https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Agreements/MultilateralAgreement</seealso>
    let MultilateralAgreement =
        Prefixed_Name(fibo_fnd_agr_agr, "MultilateralAgreement") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-agr-agr:Obligee</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"obligee"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Agreements/Obligee">https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Agreements/Obligee</seealso>
    let Obligee = Prefixed_Name(fibo_fnd_agr_agr, "Obligee") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fnd-agr-agr:Obligor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"obligor"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Agreements/Obligor">https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Agreements/Obligor</seealso>
    let Obligor = Prefixed_Name(fibo_fnd_agr_agr, "Obligor") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-agr-agr:UnilateralCommitment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"unilateral commitment"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Agreements/UnilateralCommitment">https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Agreements/UnilateralCommitment</seealso>
    let UnilateralCommitment =
        Prefixed_Name(fibo_fnd_agr_agr, "UnilateralCommitment") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-agr-agr:hasObligation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has obligation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Agreements/hasObligation">https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Agreements/hasObligation</seealso>
    let hasObligation = Prefixed_Name(fibo_fnd_agr_agr, "hasObligation") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-agr-agr:isObligationOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is obligation of"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Agreements/isObligationOf">https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Agreements/isObligationOf</seealso>
    let isObligationOf =
        Prefixed_Name(fibo_fnd_agr_agr, "isObligationOf") |> PrefixedName
