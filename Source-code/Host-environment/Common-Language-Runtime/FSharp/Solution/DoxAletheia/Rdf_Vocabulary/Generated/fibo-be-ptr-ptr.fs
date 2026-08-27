namespace https.spec.edmcouncil.org.fibo.ontology.BE.Partnerships.Partnerships.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module fibo_be_ptr_ptr =
    let _namespace_iri = Namespace_Iri fibo_be_ptr_ptr |> NamespaceIRI
    /// <summary>
    ///   <para>fibo-be-ptr-ptr:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///
    /// labels<para>"Partnerships Ontology"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/Partnerships/Partnerships/">https://spec.edmcouncil.org/fibo/ontology/BE/Partnerships/Partnerships/</seealso>
    let _prefix_iri = Prefixed_Name(fibo_be_ptr_ptr, "") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ptr-ptr:GeneralPartner</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"general partner"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/Partnerships/Partnerships/GeneralPartner">https://spec.edmcouncil.org/fibo/ontology/BE/Partnerships/Partnerships/GeneralPartner</seealso>
    let GeneralPartner =
        Prefixed_Name(fibo_be_ptr_ptr, "GeneralPartner") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ptr-ptr:GeneralPartnership</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"general partnership"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/Partnerships/Partnerships/GeneralPartnership">https://spec.edmcouncil.org/fibo/ontology/BE/Partnerships/Partnerships/GeneralPartnership</seealso>
    let GeneralPartnership =
        Prefixed_Name(fibo_be_ptr_ptr, "GeneralPartnership") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ptr-ptr:LimitedLiabilityLimitedPartnership</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"limited liability limited partnership"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/Partnerships/Partnerships/LimitedLiabilityLimitedPartnership">https://spec.edmcouncil.org/fibo/ontology/BE/Partnerships/Partnerships/LimitedLiabilityLimitedPartnership</seealso>
    let LimitedLiabilityLimitedPartnership =
        Prefixed_Name(fibo_be_ptr_ptr, "LimitedLiabilityLimitedPartnership") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ptr-ptr:LimitedLiabilityPartnership</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"limited liability partnership"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/Partnerships/Partnerships/LimitedLiabilityPartnership">https://spec.edmcouncil.org/fibo/ontology/BE/Partnerships/Partnerships/LimitedLiabilityPartnership</seealso>
    let LimitedLiabilityPartnership =
        Prefixed_Name(fibo_be_ptr_ptr, "LimitedLiabilityPartnership") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ptr-ptr:LimitedPartner</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"limited partner"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/Partnerships/Partnerships/LimitedPartner">https://spec.edmcouncil.org/fibo/ontology/BE/Partnerships/Partnerships/LimitedPartner</seealso>
    let LimitedPartner =
        Prefixed_Name(fibo_be_ptr_ptr, "LimitedPartner") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ptr-ptr:LimitedPartnership</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"limited partnership"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/Partnerships/Partnerships/LimitedPartnership">https://spec.edmcouncil.org/fibo/ontology/BE/Partnerships/Partnerships/LimitedPartnership</seealso>
    let LimitedPartnership =
        Prefixed_Name(fibo_be_ptr_ptr, "LimitedPartnership") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ptr-ptr:Partner</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"partner"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/Partnerships/Partnerships/Partner">https://spec.edmcouncil.org/fibo/ontology/BE/Partnerships/Partnerships/Partner</seealso>
    let Partner = Prefixed_Name(fibo_be_ptr_ptr, "Partner") |> PrefixedName
    /// <summary>
    ///   <para>fibo-be-ptr-ptr:Partnership</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"partnership"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/Partnerships/Partnerships/Partnership">https://spec.edmcouncil.org/fibo/ontology/BE/Partnerships/Partnerships/Partnership</seealso>
    let Partnership = Prefixed_Name(fibo_be_ptr_ptr, "Partnership") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ptr-ptr:PartnershipAgreement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"partnership agreement"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/Partnerships/Partnerships/PartnershipAgreement">https://spec.edmcouncil.org/fibo/ontology/BE/Partnerships/Partnerships/PartnershipAgreement</seealso>
    let PartnershipAgreement =
        Prefixed_Name(fibo_be_ptr_ptr, "PartnershipAgreement") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ptr-ptr:hasGeneralPartner</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has general partner"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/Partnerships/Partnerships/hasGeneralPartner">https://spec.edmcouncil.org/fibo/ontology/BE/Partnerships/Partnerships/hasGeneralPartner</seealso>
    let hasGeneralPartner =
        Prefixed_Name(fibo_be_ptr_ptr, "hasGeneralPartner") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ptr-ptr:hasLimitedPartner</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has limited partner"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/Partnerships/Partnerships/hasLimitedPartner">https://spec.edmcouncil.org/fibo/ontology/BE/Partnerships/Partnerships/hasLimitedPartner</seealso>
    let hasLimitedPartner =
        Prefixed_Name(fibo_be_ptr_ptr, "hasLimitedPartner") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ptr-ptr:isGeneralPartnerOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is general partner of"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/Partnerships/Partnerships/isGeneralPartnerOf">https://spec.edmcouncil.org/fibo/ontology/BE/Partnerships/Partnerships/isGeneralPartnerOf</seealso>
    let isGeneralPartnerOf =
        Prefixed_Name(fibo_be_ptr_ptr, "isGeneralPartnerOf") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ptr-ptr:isLimitedPartnerOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is limited partner of"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/Partnerships/Partnerships/isLimitedPartnerOf">https://spec.edmcouncil.org/fibo/ontology/BE/Partnerships/Partnerships/isLimitedPartnerOf</seealso>
    let isLimitedPartnerOf =
        Prefixed_Name(fibo_be_ptr_ptr, "isLimitedPartnerOf") |> PrefixedName
