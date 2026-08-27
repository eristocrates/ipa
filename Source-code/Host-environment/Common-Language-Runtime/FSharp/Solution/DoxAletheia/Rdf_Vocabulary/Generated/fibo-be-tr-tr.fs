namespace https.spec.edmcouncil.org.fibo.ontology.BE.Trusts.Trusts.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module fibo_be_tr_tr =
    let _namespace_iri = Namespace_Iri fibo_be_tr_tr |> NamespaceIRI
    /// <summary>
    ///   <para>fibo-be-tr-tr:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///
    /// labels<para>"Trusts Ontology"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/Trusts/Trusts/">https://spec.edmcouncil.org/fibo/ontology/BE/Trusts/Trusts/</seealso>
    let _prefix_iri = Prefixed_Name(fibo_be_tr_tr, "") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-tr-tr:IrrevocableTrust</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"irrevocable trust"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/Trusts/Trusts/IrrevocableTrust">https://spec.edmcouncil.org/fibo/ontology/BE/Trusts/Trusts/IrrevocableTrust</seealso>
    let IrrevocableTrust =
        Prefixed_Name(fibo_be_tr_tr, "IrrevocableTrust") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-tr-tr:LivingTrust</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"living trust"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/Trusts/Trusts/LivingTrust">https://spec.edmcouncil.org/fibo/ontology/BE/Trusts/Trusts/LivingTrust</seealso>
    let LivingTrust = Prefixed_Name(fibo_be_tr_tr, "LivingTrust") |> PrefixedName
    /// <summary>
    ///   <para>fibo-be-tr-tr:RevocableTrust</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"revocable trust"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/Trusts/Trusts/RevocableTrust">https://spec.edmcouncil.org/fibo/ontology/BE/Trusts/Trusts/RevocableTrust</seealso>
    let RevocableTrust = Prefixed_Name(fibo_be_tr_tr, "RevocableTrust") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-tr-tr:TestamentaryTrust</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"testamentary trust"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/Trusts/Trusts/TestamentaryTrust">https://spec.edmcouncil.org/fibo/ontology/BE/Trusts/Trusts/TestamentaryTrust</seealso>
    let TestamentaryTrust =
        Prefixed_Name(fibo_be_tr_tr, "TestamentaryTrust") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-tr-tr:Trust</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"trust"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/Trusts/Trusts/Trust">https://spec.edmcouncil.org/fibo/ontology/BE/Trusts/Trusts/Trust</seealso>
    let Trust = Prefixed_Name(fibo_be_tr_tr, "Trust") |> PrefixedName
    /// <summary>
    ///   <para>fibo-be-tr-tr:TrustAgreement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"trust agreement"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/Trusts/Trusts/TrustAgreement">https://spec.edmcouncil.org/fibo/ontology/BE/Trusts/Trusts/TrustAgreement</seealso>
    let TrustAgreement = Prefixed_Name(fibo_be_tr_tr, "TrustAgreement") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-tr-tr:TrustBeneficiary</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"trust beneficiary"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/Trusts/Trusts/TrustBeneficiary">https://spec.edmcouncil.org/fibo/ontology/BE/Trusts/Trusts/TrustBeneficiary</seealso>
    let TrustBeneficiary =
        Prefixed_Name(fibo_be_tr_tr, "TrustBeneficiary") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-tr-tr:TrustFundManager</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"trust fund manager"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/Trusts/Trusts/TrustFundManager">https://spec.edmcouncil.org/fibo/ontology/BE/Trusts/Trusts/TrustFundManager</seealso>
    let TrustFundManager =
        Prefixed_Name(fibo_be_tr_tr, "TrustFundManager") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-tr-tr:Trustee</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"trustee"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/Trusts/Trusts/Trustee">https://spec.edmcouncil.org/fibo/ontology/BE/Trusts/Trusts/Trustee</seealso>
    let Trustee = Prefixed_Name(fibo_be_tr_tr, "Trustee") |> PrefixedName
    /// <summary>
    ///   <para>fibo-be-tr-tr:Trustor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"trustor"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/Trusts/Trusts/Trustor">https://spec.edmcouncil.org/fibo/ontology/BE/Trusts/Trusts/Trustor</seealso>
    let Trustor = Prefixed_Name(fibo_be_tr_tr, "Trustor") |> PrefixedName
    /// <summary>
    ///   <para>fibo-be-tr-tr:hasTrustee</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has trustee"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/Trusts/Trusts/hasTrustee">https://spec.edmcouncil.org/fibo/ontology/BE/Trusts/Trusts/hasTrustee</seealso>
    let hasTrustee = Prefixed_Name(fibo_be_tr_tr, "hasTrustee") |> PrefixedName
    /// <summary>
    ///   <para>fibo-be-tr-tr:isTrusteeOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is trustee of"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/Trusts/Trusts/isTrusteeOf">https://spec.edmcouncil.org/fibo/ontology/BE/Trusts/Trusts/isTrusteeOf</seealso>
    let isTrusteeOf = Prefixed_Name(fibo_be_tr_tr, "isTrusteeOf") |> PrefixedName
