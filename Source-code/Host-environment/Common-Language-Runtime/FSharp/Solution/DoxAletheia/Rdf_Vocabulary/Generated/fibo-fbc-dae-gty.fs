namespace https.spec.edmcouncil.org.fibo.ontology.FBC.DebtAndEquities.Guaranty.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module fibo_fbc_dae_gty =
    let _namespace_iri = Namespace_Iri fibo_fbc_dae_gty |> NamespaceIRI
    /// <summary>
    ///   <para>fibo-fbc-dae-gty:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///
    /// labels<para>"Guaranty Ontology"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Guaranty/">https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Guaranty/</seealso>
    let _prefix_iri = Prefixed_Name(fibo_fbc_dae_gty, "") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-dae-gty:CollateralizedGuaranty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"collateralized guaranty"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Guaranty/CollateralizedGuaranty">https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Guaranty/CollateralizedGuaranty</seealso>
    let CollateralizedGuaranty =
        Prefixed_Name(fibo_fbc_dae_gty, "CollateralizedGuaranty") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-dae-gty:GovernmentGuaranty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"government guaranty"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Guaranty/GovernmentGuaranty">https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Guaranty/GovernmentGuaranty</seealso>
    let GovernmentGuaranty =
        Prefixed_Name(fibo_fbc_dae_gty, "GovernmentGuaranty") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-dae-gty:Guarantor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"guarantor"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Guaranty/Guarantor">https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Guaranty/Guarantor</seealso>
    let Guarantor = Prefixed_Name(fibo_fbc_dae_gty, "Guarantor") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fbc-dae-gty:Guaranty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"guaranty"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Guaranty/Guaranty">https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Guaranty/Guaranty</seealso>
    let Guaranty = Prefixed_Name(fibo_fbc_dae_gty, "Guaranty") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-dae-gty:InsuranceBackedGuaranty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"insurance-backed guaranty"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Guaranty/InsuranceBackedGuaranty">https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Guaranty/InsuranceBackedGuaranty</seealso>
    let InsuranceBackedGuaranty =
        Prefixed_Name(fibo_fbc_dae_gty, "InsuranceBackedGuaranty") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-dae-gty:InsurancePolicy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"insurance policy"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Guaranty/InsurancePolicy">https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Guaranty/InsurancePolicy</seealso>
    let InsurancePolicy =
        Prefixed_Name(fibo_fbc_dae_gty, "InsurancePolicy") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-dae-gty:Insurer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"insurer"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Guaranty/Insurer">https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Guaranty/Insurer</seealso>
    let Insurer = Prefixed_Name(fibo_fbc_dae_gty, "Insurer") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fbc-dae-gty:JointGuaranty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"joint guaranty"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Guaranty/JointGuaranty">https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Guaranty/JointGuaranty</seealso>
    let JointGuaranty = Prefixed_Name(fibo_fbc_dae_gty, "JointGuaranty") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-dae-gty:LetterOfCredit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"letter of credit"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Guaranty/LetterOfCredit">https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Guaranty/LetterOfCredit</seealso>
    let LetterOfCredit =
        Prefixed_Name(fibo_fbc_dae_gty, "LetterOfCredit") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-dae-gty:LetterOfCreditGuaranty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"letter of credit guaranty"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Guaranty/LetterOfCreditGuaranty">https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Guaranty/LetterOfCreditGuaranty</seealso>
    let LetterOfCreditGuaranty =
        Prefixed_Name(fibo_fbc_dae_gty, "LetterOfCreditGuaranty") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-dae-gty:NegativePledge</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"negative pledge"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Guaranty/NegativePledge">https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Guaranty/NegativePledge</seealso>
    let NegativePledge =
        Prefixed_Name(fibo_fbc_dae_gty, "NegativePledge") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-dae-gty:Policyholder</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"policyholder"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Guaranty/Policyholder">https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Guaranty/Policyholder</seealso>
    let Policyholder = Prefixed_Name(fibo_fbc_dae_gty, "Policyholder") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fbc-dae-gty:PriorityLevel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"priority level"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Guaranty/PriorityLevel">https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Guaranty/PriorityLevel</seealso>
    let PriorityLevel = Prefixed_Name(fibo_fbc_dae_gty, "PriorityLevel") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-dae-gty:hasGuaranteedAmount</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has guaranteed amount"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Guaranty/hasGuaranteedAmount">https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Guaranty/hasGuaranteedAmount</seealso>
    let hasGuaranteedAmount =
        Prefixed_Name(fibo_fbc_dae_gty, "hasGuaranteedAmount") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-dae-gty:hasGuarantor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has guarantor"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Guaranty/hasGuarantor">https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Guaranty/hasGuarantor</seealso>
    let hasGuarantor = Prefixed_Name(fibo_fbc_dae_gty, "hasGuarantor") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-dae-gty:hasGuarantorParty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has guarantor party"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Guaranty/hasGuarantorParty">https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Guaranty/hasGuarantorParty</seealso>
    let hasGuarantorParty =
        Prefixed_Name(fibo_fbc_dae_gty, "hasGuarantorParty") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-dae-gty:hasPriorityLevel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has priority level"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Guaranty/hasPriorityLevel">https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Guaranty/hasPriorityLevel</seealso>
    let hasPriorityLevel =
        Prefixed_Name(fibo_fbc_dae_gty, "hasPriorityLevel") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-dae-gty:isGuaranteedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is guaranteed by"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Guaranty/isGuaranteedBy">https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Guaranty/isGuaranteedBy</seealso>
    let isGuaranteedBy =
        Prefixed_Name(fibo_fbc_dae_gty, "isGuaranteedBy") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-dae-gty:isGuarantorOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is guarantor of"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Guaranty/isGuarantorOf">https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Guaranty/isGuarantorOf</seealso>
    let isGuarantorOf = Prefixed_Name(fibo_fbc_dae_gty, "isGuarantorOf") |> PrefixedName
