namespace https.spec.edmcouncil.org.fibo.ontology.BE.FunctionalEntities.FunctionalEntities.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module fibo_be_fct_fct =
    let _namespace_iri = Namespace_Iri fibo_be_fct_fct |> NamespaceIRI
    /// <summary>
    ///   <para>fibo-be-fct-fct:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///
    /// labels<para>"Functional Entities Ontology"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/FunctionalEntities/FunctionalEntities/">https://spec.edmcouncil.org/fibo/ontology/BE/FunctionalEntities/FunctionalEntities/</seealso>
    let _prefix_iri = Prefixed_Name(fibo_be_fct_fct, "") |> PrefixedName
    /// <summary>
    ///   <para>fibo-be-fct-fct:Association</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"association"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/FunctionalEntities/FunctionalEntities/Association">https://spec.edmcouncil.org/fibo/ontology/BE/FunctionalEntities/FunctionalEntities/Association</seealso>
    let Association = Prefixed_Name(fibo_be_fct_fct, "Association") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-fct-fct:CooperativeSociety</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"cooperative society"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/FunctionalEntities/FunctionalEntities/CooperativeSociety">https://spec.edmcouncil.org/fibo/ontology/BE/FunctionalEntities/FunctionalEntities/CooperativeSociety</seealso>
    let CooperativeSociety =
        Prefixed_Name(fibo_be_fct_fct, "CooperativeSociety") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-fct-fct:FamilyOffice</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"family office"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/FunctionalEntities/FunctionalEntities/FamilyOffice">https://spec.edmcouncil.org/fibo/ontology/BE/FunctionalEntities/FunctionalEntities/FamilyOffice</seealso>
    let FamilyOffice = Prefixed_Name(fibo_be_fct_fct, "FamilyOffice") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-fct-fct:FunctionalBusinessEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"functional business entity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/FunctionalEntities/FunctionalEntities/FunctionalBusinessEntity">https://spec.edmcouncil.org/fibo/ontology/BE/FunctionalEntities/FunctionalEntities/FunctionalBusinessEntity</seealso>
    let FunctionalBusinessEntity =
        Prefixed_Name(fibo_be_fct_fct, "FunctionalBusinessEntity") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-fct-fct:FunctionalEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"functional entity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/FunctionalEntities/FunctionalEntities/FunctionalEntity">https://spec.edmcouncil.org/fibo/ontology/BE/FunctionalEntities/FunctionalEntities/FunctionalEntity</seealso>
    let FunctionalEntity =
        Prefixed_Name(fibo_be_fct_fct, "FunctionalEntity") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-fct-fct:Merchant</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"merchant"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/FunctionalEntities/FunctionalEntities/Merchant">https://spec.edmcouncil.org/fibo/ontology/BE/FunctionalEntities/FunctionalEntities/Merchant</seealso>
    let Merchant = Prefixed_Name(fibo_be_fct_fct, "Merchant") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-fct-fct:MerchantCategoryCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"merchant category code"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/FunctionalEntities/FunctionalEntities/MerchantCategoryCode">https://spec.edmcouncil.org/fibo/ontology/BE/FunctionalEntities/FunctionalEntities/MerchantCategoryCode</seealso>
    let MerchantCategoryCode =
        Prefixed_Name(fibo_be_fct_fct, "MerchantCategoryCode") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-fct-fct:MerchantCategoryCodeScheme</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"merchant category code scheme"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/FunctionalEntities/FunctionalEntities/MerchantCategoryCodeScheme">https://spec.edmcouncil.org/fibo/ontology/BE/FunctionalEntities/FunctionalEntities/MerchantCategoryCodeScheme</seealso>
    let MerchantCategoryCodeScheme =
        Prefixed_Name(fibo_be_fct_fct, "MerchantCategoryCodeScheme") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-fct-fct:MerchantIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"merchant identifier"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/FunctionalEntities/FunctionalEntities/MerchantIdentifier">https://spec.edmcouncil.org/fibo/ontology/BE/FunctionalEntities/FunctionalEntities/MerchantIdentifier</seealso>
    let MerchantIdentifier =
        Prefixed_Name(fibo_be_fct_fct, "MerchantIdentifier") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-fct-fct:Syndicate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"syndicate"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/FunctionalEntities/FunctionalEntities/Syndicate">https://spec.edmcouncil.org/fibo/ontology/BE/FunctionalEntities/FunctionalEntities/Syndicate</seealso>
    let Syndicate = Prefixed_Name(fibo_be_fct_fct, "Syndicate") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-fct-fct:SyndicateMember</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"syndicate member"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/FunctionalEntities/FunctionalEntities/SyndicateMember">https://spec.edmcouncil.org/fibo/ontology/BE/FunctionalEntities/FunctionalEntities/SyndicateMember</seealso>
    let SyndicateMember =
        Prefixed_Name(fibo_be_fct_fct, "SyndicateMember") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-fct-fct:hasMerchantCategoryDescription</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"has merchant category description"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/FunctionalEntities/FunctionalEntities/hasMerchantCategoryDescription">https://spec.edmcouncil.org/fibo/ontology/BE/FunctionalEntities/FunctionalEntities/hasMerchantCategoryDescription</seealso>
    let hasMerchantCategoryDescription =
        Prefixed_Name(fibo_be_fct_fct, "hasMerchantCategoryDescription") |> PrefixedName
