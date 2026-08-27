namespace https.spec.edmcouncil.org.fibo.ontology.BE.GovernmentEntities.GovernmentEntities.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module fibo_be_ge_ge =
    let _namespace_iri = Namespace_Iri fibo_be_ge_ge |> NamespaceIRI
    /// <summary>
    ///   <para>fibo-be-ge-ge:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///
    /// labels<para>"Government Entities Ontology"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/GovernmentEntities/">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/GovernmentEntities/</seealso>
    let _prefix_iri = Prefixed_Name(fibo_be_ge_ge, "") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-ge:BranchOfGovernment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"branch of government"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/GovernmentEntities/BranchOfGovernment">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/GovernmentEntities/BranchOfGovernment</seealso>
    let BranchOfGovernment =
        Prefixed_Name(fibo_be_ge_ge, "BranchOfGovernment") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-ge:DevolvedGovernment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"devolved government"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/GovernmentEntities/DevolvedGovernment">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/GovernmentEntities/DevolvedGovernment</seealso>
    let DevolvedGovernment =
        Prefixed_Name(fibo_be_ge_ge, "DevolvedGovernment") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-ge:ExecutiveBranch</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"executive branch"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/GovernmentEntities/ExecutiveBranch">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/GovernmentEntities/ExecutiveBranch</seealso>
    let ExecutiveBranch =
        Prefixed_Name(fibo_be_ge_ge, "ExecutiveBranch") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-ge:FederalGovernment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"federal government"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/GovernmentEntities/FederalGovernment">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/GovernmentEntities/FederalGovernment</seealso>
    let FederalGovernment =
        Prefixed_Name(fibo_be_ge_ge, "FederalGovernment") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-ge:FederatedSovereignty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"federated sovereignty"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/GovernmentEntities/FederatedSovereignty">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/GovernmentEntities/FederatedSovereignty</seealso>
    let FederatedSovereignty =
        Prefixed_Name(fibo_be_ge_ge, "FederatedSovereignty") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-ge:Government</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"government"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/GovernmentEntities/Government">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/GovernmentEntities/Government</seealso>
    let Government = Prefixed_Name(fibo_be_ge_ge, "Government") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-ge:GovernmentAgency</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"government agency"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/GovernmentEntities/GovernmentAgency">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/GovernmentEntities/GovernmentAgency</seealso>
    let GovernmentAgency =
        Prefixed_Name(fibo_be_ge_ge, "GovernmentAgency") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-ge:GovernmentAppointee</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"government appointee"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/GovernmentEntities/GovernmentAppointee">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/GovernmentEntities/GovernmentAppointee</seealso>
    let GovernmentAppointee =
        Prefixed_Name(fibo_be_ge_ge, "GovernmentAppointee") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-ge:GovernmentBody</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"government body"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/GovernmentEntities/GovernmentBody">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/GovernmentEntities/GovernmentBody</seealso>
    let GovernmentBody = Prefixed_Name(fibo_be_ge_ge, "GovernmentBody") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-ge:GovernmentDepartment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"government department"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/GovernmentEntities/GovernmentDepartment">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/GovernmentEntities/GovernmentDepartment</seealso>
    let GovernmentDepartment =
        Prefixed_Name(fibo_be_ge_ge, "GovernmentDepartment") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-ge:GovernmentMinister</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"government minister"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/GovernmentEntities/GovernmentMinister">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/GovernmentEntities/GovernmentMinister</seealso>
    let GovernmentMinister =
        Prefixed_Name(fibo_be_ge_ge, "GovernmentMinister") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-ge:GovernmentOfficial</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"government official"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/GovernmentEntities/GovernmentOfficial">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/GovernmentEntities/GovernmentOfficial</seealso>
    let GovernmentOfficial =
        Prefixed_Name(fibo_be_ge_ge, "GovernmentOfficial") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-ge:Instrumentality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"instrumentality"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/GovernmentEntities/Instrumentality">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/GovernmentEntities/Instrumentality</seealso>
    let Instrumentality =
        Prefixed_Name(fibo_be_ge_ge, "Instrumentality") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-ge:Judiciary</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"judiciary"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/GovernmentEntities/Judiciary">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/GovernmentEntities/Judiciary</seealso>
    let Judiciary = Prefixed_Name(fibo_be_ge_ge, "Judiciary") |> PrefixedName
    /// <summary>
    ///   <para>fibo-be-ge-ge:Legislature</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"legislature"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/GovernmentEntities/Legislature">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/GovernmentEntities/Legislature</seealso>
    let Legislature = Prefixed_Name(fibo_be_ge_ge, "Legislature") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-ge:MunicipalEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"municipal entity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/GovernmentEntities/MunicipalEntity">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/GovernmentEntities/MunicipalEntity</seealso>
    let MunicipalEntity =
        Prefixed_Name(fibo_be_ge_ge, "MunicipalEntity") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-ge:MunicipalGovernment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"municipal government"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/GovernmentEntities/MunicipalGovernment">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/GovernmentEntities/MunicipalGovernment</seealso>
    let MunicipalGovernment =
        Prefixed_Name(fibo_be_ge_ge, "MunicipalGovernment") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-ge:NationalGovernment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"national government"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/GovernmentEntities/NationalGovernment">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/GovernmentEntities/NationalGovernment</seealso>
    let NationalGovernment =
        Prefixed_Name(fibo_be_ge_ge, "NationalGovernment") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-ge:Polity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"polity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/GovernmentEntities/Polity">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/GovernmentEntities/Polity</seealso>
    let Polity = Prefixed_Name(fibo_be_ge_ge, "Polity") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-ge:RegionalGovernment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"regional government"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/GovernmentEntities/RegionalGovernment">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/GovernmentEntities/RegionalGovernment</seealso>
    let RegionalGovernment =
        Prefixed_Name(fibo_be_ge_ge, "RegionalGovernment") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-ge:RegionalSovereignty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"regional sovereignty"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/GovernmentEntities/RegionalSovereignty">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/GovernmentEntities/RegionalSovereignty</seealso>
    let RegionalSovereignty =
        Prefixed_Name(fibo_be_ge_ge, "RegionalSovereignty") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-ge:SovereignState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"sovereign state"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/GovernmentEntities/SovereignState">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/GovernmentEntities/SovereignState</seealso>
    let SovereignState = Prefixed_Name(fibo_be_ge_ge, "SovereignState") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-ge:SupranationalEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"supranational entity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/GovernmentEntities/SupranationalEntity">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/GovernmentEntities/SupranationalEntity</seealso>
    let SupranationalEntity =
        Prefixed_Name(fibo_be_ge_ge, "SupranationalEntity") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-ge:TribalArea</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"tribal area"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/GovernmentEntities/TribalArea">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/GovernmentEntities/TribalArea</seealso>
    let TribalArea = Prefixed_Name(fibo_be_ge_ge, "TribalArea") |> PrefixedName
    /// <summary>
    ///   <para>fibo-be-ge-ge:TribalEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"tribal entity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/GovernmentEntities/TribalEntity">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/GovernmentEntities/TribalEntity</seealso>
    let TribalEntity = Prefixed_Name(fibo_be_ge_ge, "TribalEntity") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-ge:TribalGovernment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"tribal government"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/GovernmentEntities/TribalGovernment">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/GovernmentEntities/TribalGovernment</seealso>
    let TribalGovernment =
        Prefixed_Name(fibo_be_ge_ge, "TribalGovernment") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-ge:hasFullSovereigntyOver</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has full sovereignty over"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/GovernmentEntities/hasFullSovereigntyOver">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/GovernmentEntities/hasFullSovereigntyOver</seealso>
    let hasFullSovereigntyOver =
        Prefixed_Name(fibo_be_ge_ge, "hasFullSovereigntyOver") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-ge:hasSharedSovereigntyOver</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has shared sovereignty over"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/GovernmentEntities/hasSharedSovereigntyOver">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/GovernmentEntities/hasSharedSovereigntyOver</seealso>
    let hasSharedSovereigntyOver =
        Prefixed_Name(fibo_be_ge_ge, "hasSharedSovereigntyOver") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-ge:hasSovereigntyOver</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has sovereignty over"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/GovernmentEntities/hasSovereigntyOver">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/GovernmentEntities/hasSovereigntyOver</seealso>
    let hasSovereigntyOver =
        Prefixed_Name(fibo_be_ge_ge, "hasSovereigntyOver") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-ge:isElectedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is elected by"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/GovernmentEntities/isElectedBy">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/GovernmentEntities/isElectedBy</seealso>
    let isElectedBy = Prefixed_Name(fibo_be_ge_ge, "isElectedBy") |> PrefixedName
    /// <summary>
    ///   <para>fibo-be-ge-ge:isInstrumentOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is an instrument of"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/GovernmentEntities/isInstrumentOf">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/GovernmentEntities/isInstrumentOf</seealso>
    let isInstrumentOf = Prefixed_Name(fibo_be_ge_ge, "isInstrumentOf") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-ge:isRepresentedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is represented by"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/GovernmentEntities/isRepresentedBy">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/GovernmentEntities/isRepresentedBy</seealso>
    let isRepresentedBy =
        Prefixed_Name(fibo_be_ge_ge, "isRepresentedBy") |> PrefixedName
