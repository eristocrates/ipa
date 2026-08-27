namespace http.voag.linkedmodel.org.voag.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module voagm =
    let _namespace_iri = Namespace_Iri voagm |> NamespaceIRI
    /// <summary>
    ///   <para>voagm:Accredidation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Accredidation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://voag.linkedmodel.org/voag#Accredidation">http://voag.linkedmodel.org/voag#Accredidation</seealso>
    let Accredidation = Prefixed_Name(voagm, "Accredidation") |> PrefixedName

    /// <summary>
    ///   <para>voagm:AdministrativeEvent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Administrative Event"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://voag.linkedmodel.org/voag#AdministrativeEvent">http://voag.linkedmodel.org/voag#AdministrativeEvent</seealso>
    let AdministrativeEvent =
        Prefixed_Name(voagm, "AdministrativeEvent") |> PrefixedName

    /// <summary>
    ///   <para>voagm:Annually</para>
    /// </summary>
    /// <remarks>
    ///   <para>voagm:ChangeFrequency</para>
    ///
    /// labels<para>"Annually"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://voag.linkedmodel.org/voag#Annually">http://voag.linkedmodel.org/voag#Annually</seealso>
    let Annually = Prefixed_Name(voagm, "Annually") |> PrefixedName
    /// <summary>
    ///   <para>voagm:AppendChange</para>
    /// </summary>
    /// <remarks>
    ///   <para>voagm:ChangeType</para>
    ///
    /// labels<para>"Append change"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://voag.linkedmodel.org/voag#AppendChange">http://voag.linkedmodel.org/voag#AppendChange</seealso>
    let AppendChange = Prefixed_Name(voagm, "AppendChange") |> PrefixedName
    /// <summary>
    ///   <para>voagm:ApprovalEvent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Approval Event"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://voag.linkedmodel.org/voag#ApprovalEvent">http://voag.linkedmodel.org/voag#ApprovalEvent</seealso>
    let ApprovalEvent = Prefixed_Name(voagm, "ApprovalEvent") |> PrefixedName
    /// <summary>
    ///   <para>voagm:ApprovalProcess</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Approval Process"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://voag.linkedmodel.org/voag#ApprovalProcess">http://voag.linkedmodel.org/voag#ApprovalProcess</seealso>
    let ApprovalProcess = Prefixed_Name(voagm, "ApprovalProcess") |> PrefixedName
    /// <summary>
    ///   <para>voagm:ApprovedIssue</para>
    /// </summary>
    /// <remarks>
    ///   <para>voagm:IssueStatus</para>
    ///
    /// labels<para>"Approved Issue"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://voag.linkedmodel.org/voag#ApprovedIssue">http://voag.linkedmodel.org/voag#ApprovedIssue</seealso>
    let ApprovedIssue = Prefixed_Name(voagm, "ApprovedIssue") |> PrefixedName
    /// <summary>
    ///   <para>voagm:AssignedRole</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Assigned role"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://voag.linkedmodel.org/voag#AssignedRole">http://voag.linkedmodel.org/voag#AssignedRole</seealso>
    let AssignedRole = Prefixed_Name(voagm, "AssignedRole") |> PrefixedName
    /// <summary>
    ///   <para>voagm:Attribution</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Attributed Source"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://voag.linkedmodel.org/voag#Attribution">http://voag.linkedmodel.org/voag#Attribution</seealso>
    let Attribution = Prefixed_Name(voagm, "Attribution") |> PrefixedName
    /// <summary>
    ///   <para>voagm:AttributionLogo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Attribution logo"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://voag.linkedmodel.org/voag#AttributionLogo">http://voag.linkedmodel.org/voag#AttributionLogo</seealso>
    let AttributionLogo = Prefixed_Name(voagm, "AttributionLogo") |> PrefixedName
    /// <summary>
    ///   <para>voagm:BiMonthly</para>
    /// </summary>
    /// <remarks>
    ///   <para>voagm:ChangeFrequency</para>
    ///
    /// labels<para>"Bi monthly"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://voag.linkedmodel.org/voag#BiMonthly">http://voag.linkedmodel.org/voag#BiMonthly</seealso>
    let BiMonthly = Prefixed_Name(voagm, "BiMonthly") |> PrefixedName
    /// <summary>
    ///   <para>voagm:BiQuarterly</para>
    /// </summary>
    /// <remarks>
    ///   <para>voagm:ChangeFrequency</para>
    ///
    /// labels<para>"Bi quarterly"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://voag.linkedmodel.org/voag#BiQuarterly">http://voag.linkedmodel.org/voag#BiQuarterly</seealso>
    let BiQuarterly = Prefixed_Name(voagm, "BiQuarterly") |> PrefixedName
    /// <summary>
    ///   <para>voagm:BiWeekly</para>
    /// </summary>
    /// <remarks>
    ///   <para>voagm:ChangeFrequency</para>
    ///
    /// labels<para>"Bi-Weekly"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://voag.linkedmodel.org/voag#BiWeekly">http://voag.linkedmodel.org/voag#BiWeekly</seealso>
    let BiWeekly = Prefixed_Name(voagm, "BiWeekly") |> PrefixedName

    /// <summary>
    ///   <para>voagm:BoardDispositionStatus</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://voag.linkedmodel.org/voag#BoardDispositionStatus">http://voag.linkedmodel.org/voag#BoardDispositionStatus</seealso>
    let BoardDispositionStatus =
        Prefixed_Name(voagm, "BoardDispositionStatus") |> PrefixedName

    /// <summary>
    ///   <para>voagm:CC-SHAREALIKE_3PT0-US</para>
    /// </summary>
    /// <remarks>
    ///   <para>voagm:LicenseModel</para>
    ///
    /// labels<para>"Creative Commons Attribution-Share Alike 3.0 United States License"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://voag.linkedmodel.org/voag#CC-SHAREALIKE_3PT0-US">http://voag.linkedmodel.org/voag#CC-SHAREALIKE_3PT0-US</seealso>
    let CC_SHAREALIKE_3PT0_US =
        Prefixed_Name(voagm, "CC-SHAREALIKE_3PT0-US") |> PrefixedName

    /// <summary>
    ///   <para>voagm:CCPH_CommercialUse</para>
    /// </summary>
    /// <remarks>
    ///   <para>voagm:CreativeCommonsProhibition</para>
    ///
    /// labels<para>"Creative Commons Commercial Use"</para></remarks>
    /// <seealso href="http://voag.linkedmodel.org/voag#CCPH_CommercialUse">http://voag.linkedmodel.org/voag#CCPH_CommercialUse</seealso>
    let CCPH_CommercialUse = Prefixed_Name(voagm, "CCPH_CommercialUse") |> PrefixedName

    /// <summary>
    ///   <para>voagm:CCPH_HighIncomeNationUse</para>
    /// </summary>
    /// <remarks>
    ///   <para>voagm:CreativeCommonsProhibition</para>
    ///
    /// labels<para>"Creative Commons High Income Nation Use"</para><para>"High income nation use"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://voag.linkedmodel.org/voag#CCPH_HighIncomeNationUse">http://voag.linkedmodel.org/voag#CCPH_HighIncomeNationUse</seealso>
    let CCPH_HighIncomeNationUse =
        Prefixed_Name(voagm, "CCPH_HighIncomeNationUse") |> PrefixedName

    /// <summary>
    ///   <para>voagm:CCP_DerivativeWorks</para>
    /// </summary>
    /// <remarks>
    ///   <para>voagm:CreativeCommonsPermission</para>
    ///
    /// labels<para>"Derivative works"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"Creative Commons Derivative Works"</para></remarks>
    /// <seealso href="http://voag.linkedmodel.org/voag#CCP_DerivativeWorks">http://voag.linkedmodel.org/voag#CCP_DerivativeWorks</seealso>
    let CCP_DerivativeWorks =
        Prefixed_Name(voagm, "CCP_DerivativeWorks") |> PrefixedName

    /// <summary>
    ///   <para>voagm:CCP_Distribution</para>
    /// </summary>
    /// <remarks>
    ///   <para>voagm:CreativeCommonsPermission</para>
    ///
    /// labels<para>"Distribution"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"Creative Commons Distribution"</para></remarks>
    /// <seealso href="http://voag.linkedmodel.org/voag#CCP_Distribution">http://voag.linkedmodel.org/voag#CCP_Distribution</seealso>
    let CCP_Distribution = Prefixed_Name(voagm, "CCP_Distribution") |> PrefixedName
    /// <summary>
    ///   <para>voagm:CCP_Reproduction</para>
    /// </summary>
    /// <remarks>
    ///   <para>voagm:CreativeCommonsPermission</para>
    ///
    /// labels<para>"Reproduction"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"Creative Commons Reproduction"</para></remarks>
    /// <seealso href="http://voag.linkedmodel.org/voag#CCP_Reproduction">http://voag.linkedmodel.org/voag#CCP_Reproduction</seealso>
    let CCP_Reproduction = Prefixed_Name(voagm, "CCP_Reproduction") |> PrefixedName
    /// <summary>
    ///   <para>voagm:CCP_Sharing</para>
    /// </summary>
    /// <remarks>
    ///   <para>voagm:CreativeCommonsPermission</para>
    ///
    /// labels<para>"Sharing"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"Creative Commons Sharing"</para></remarks>
    /// <seealso href="http://voag.linkedmodel.org/voag#CCP_Sharing">http://voag.linkedmodel.org/voag#CCP_Sharing</seealso>
    let CCP_Sharing = Prefixed_Name(voagm, "CCP_Sharing") |> PrefixedName
    /// <summary>
    ///   <para>voagm:CCR_Attribution</para>
    /// </summary>
    /// <remarks>
    ///   <para>voagm:CreativeCommonsRequirement</para>
    ///
    /// labels<para>"Creative Commons Attribution"</para></remarks>
    /// <seealso href="http://voag.linkedmodel.org/voag#CCR_Attribution">http://voag.linkedmodel.org/voag#CCR_Attribution</seealso>
    let CCR_Attribution = Prefixed_Name(voagm, "CCR_Attribution") |> PrefixedName
    /// <summary>
    ///   <para>voagm:CCR_Copyleft</para>
    /// </summary>
    /// <remarks>
    ///   <para>voagm:CreativeCommonsRequirement</para>
    ///
    /// labels<para>"Creative Commons Copyleft"</para></remarks>
    /// <seealso href="http://voag.linkedmodel.org/voag#CCR_Copyleft">http://voag.linkedmodel.org/voag#CCR_Copyleft</seealso>
    let CCR_Copyleft = Prefixed_Name(voagm, "CCR_Copyleft") |> PrefixedName
    /// <summary>
    ///   <para>voagm:CCR_LesserCopyleft</para>
    /// </summary>
    /// <remarks>
    ///   <para>voagm:CreativeCommonsRequirement</para>
    ///
    /// labels<para>"Creative Commons Lesser Copyleft"</para></remarks>
    /// <seealso href="http://voag.linkedmodel.org/voag#CCR_LesserCopyleft">http://voag.linkedmodel.org/voag#CCR_LesserCopyleft</seealso>
    let CCR_LesserCopyleft = Prefixed_Name(voagm, "CCR_LesserCopyleft") |> PrefixedName
    /// <summary>
    ///   <para>voagm:CCR_Notice</para>
    /// </summary>
    /// <remarks>
    ///   <para>voagm:CreativeCommonsRequirement</para>
    ///
    /// labels<para>"Creative Commons Notice"</para></remarks>
    /// <seealso href="http://voag.linkedmodel.org/voag#CCR_Notice">http://voag.linkedmodel.org/voag#CCR_Notice</seealso>
    let CCR_Notice = Prefixed_Name(voagm, "CCR_Notice") |> PrefixedName
    /// <summary>
    ///   <para>voagm:CCR_ShareAlike</para>
    /// </summary>
    /// <remarks>
    ///   <para>voagm:CreativeCommonsRequirement</para>
    ///
    /// labels<para>"Creative Commons Share Alike"</para></remarks>
    /// <seealso href="http://voag.linkedmodel.org/voag#CCR_ShareAlike">http://voag.linkedmodel.org/voag#CCR_ShareAlike</seealso>
    let CCR_ShareAlike = Prefixed_Name(voagm, "CCR_ShareAlike") |> PrefixedName
    /// <summary>
    ///   <para>voagm:CCR_SourceCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>voagm:CreativeCommonsRequirement</para>
    ///
    /// labels<para>"Creative Commons Source Code"</para></remarks>
    /// <seealso href="http://voag.linkedmodel.org/voag#CCR_SourceCode">http://voag.linkedmodel.org/voag#CCR_SourceCode</seealso>
    let CCR_SourceCode = Prefixed_Name(voagm, "CCR_SourceCode") |> PrefixedName
    /// <summary>
    ///   <para>voagm:CL_None</para>
    /// </summary>
    /// <remarks>
    ///   <para>voagm:ConfidentialityLevel</para>
    ///
    /// labels<para>"None"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://voag.linkedmodel.org/voag#CL_None">http://voag.linkedmodel.org/voag#CL_None</seealso>
    let CL_None = Prefixed_Name(voagm, "CL_None") |> PrefixedName
    /// <summary>
    ///   <para>voagm:CL_Restricted</para>
    /// </summary>
    /// <remarks>
    ///   <para>voagm:ConfidentialityLevel</para>
    ///
    /// labels<para>"Restricted"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://voag.linkedmodel.org/voag#CL_Restricted">http://voag.linkedmodel.org/voag#CL_Restricted</seealso>
    let CL_Restricted = Prefixed_Name(voagm, "CL_Restricted") |> PrefixedName
    /// <summary>
    ///   <para>voagm:CL_Secret</para>
    /// </summary>
    /// <remarks>
    ///   <para>voagm:ConfidentialityLevel</para>
    ///
    /// labels<para>"Secret"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://voag.linkedmodel.org/voag#CL_Secret">http://voag.linkedmodel.org/voag#CL_Secret</seealso>
    let CL_Secret = Prefixed_Name(voagm, "CL_Secret") |> PrefixedName

    /// <summary>
    ///   <para>voagm:CL_SensitiveButUnclassified</para>
    /// </summary>
    /// <remarks>
    ///   <para>voagm:ConfidentialityLevel</para>
    ///
    /// labels<para>"Sensitive but Unclassified"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://voag.linkedmodel.org/voag#CL_SensitiveButUnclassified">http://voag.linkedmodel.org/voag#CL_SensitiveButUnclassified</seealso>
    let CL_SensitiveButUnclassified =
        Prefixed_Name(voagm, "CL_SensitiveButUnclassified") |> PrefixedName

    /// <summary>
    ///   <para>voagm:CL_TopSecret</para>
    /// </summary>
    /// <remarks>
    ///   <para>voagm:ConfidentialityLevel</para>
    ///
    /// labels<para>"Top secret"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://voag.linkedmodel.org/voag#CL_TopSecret">http://voag.linkedmodel.org/voag#CL_TopSecret</seealso>
    let CL_TopSecret = Prefixed_Name(voagm, "CL_TopSecret") |> PrefixedName
    /// <summary>
    ///   <para>voagm:CL_Unclassified</para>
    /// </summary>
    /// <remarks>
    ///   <para>voagm:ConfidentialityLevel</para>
    ///
    /// labels<para>"Unclassified"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://voag.linkedmodel.org/voag#CL_Unclassified">http://voag.linkedmodel.org/voag#CL_Unclassified</seealso>
    let CL_Unclassified = Prefixed_Name(voagm, "CL_Unclassified") |> PrefixedName
    /// <summary>
    ///   <para>voagm:Catalog</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Catalog"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://voag.linkedmodel.org/voag#Catalog">http://voag.linkedmodel.org/voag#Catalog</seealso>
    let Catalog = Prefixed_Name(voagm, "Catalog") |> PrefixedName
    /// <summary>
    ///   <para>voagm:ChangeFrequency</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Change frequency"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://voag.linkedmodel.org/voag#ChangeFrequency">http://voag.linkedmodel.org/voag#ChangeFrequency</seealso>
    let ChangeFrequency = Prefixed_Name(voagm, "ChangeFrequency") |> PrefixedName

    /// <summary>
    ///   <para>voagm:ChangeManagementProcess</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Change Management Process"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://voag.linkedmodel.org/voag#ChangeManagementProcess">http://voag.linkedmodel.org/voag#ChangeManagementProcess</seealso>
    let ChangeManagementProcess =
        Prefixed_Name(voagm, "ChangeManagementProcess") |> PrefixedName

    /// <summary>
    ///   <para>voagm:ChangeType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Change type"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://voag.linkedmodel.org/voag#ChangeType">http://voag.linkedmodel.org/voag#ChangeType</seealso>
    let ChangeType = Prefixed_Name(voagm, "ChangeType") |> PrefixedName
    /// <summary>
    ///   <para>voagm:ClosedIssue</para>
    /// </summary>
    /// <remarks>
    ///   <para>voagm:IssueStatus</para>
    ///
    /// labels<para>"Closed"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://voag.linkedmodel.org/voag#ClosedIssue">http://voag.linkedmodel.org/voag#ClosedIssue</seealso>
    let ClosedIssue = Prefixed_Name(voagm, "ClosedIssue") |> PrefixedName
    /// <summary>
    ///   <para>voagm:ConcurrenceEvent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Concurrence event"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://voag.linkedmodel.org/voag#ConcurrenceEvent">http://voag.linkedmodel.org/voag#ConcurrenceEvent</seealso>
    let ConcurrenceEvent = Prefixed_Name(voagm, "ConcurrenceEvent") |> PrefixedName

    /// <summary>
    ///   <para>voagm:ConfidentialityLevel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Confidentiality level"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://voag.linkedmodel.org/voag#ConfidentialityLevel">http://voag.linkedmodel.org/voag#ConfidentialityLevel</seealso>
    let ConfidentialityLevel =
        Prefixed_Name(voagm, "ConfidentialityLevel") |> PrefixedName

    /// <summary>
    ///   <para>voagm:CreativeCommonsJurisdiction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Creative commons jurisdiction"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"Creative Commons Jurisdiction"</para></remarks>
    /// <seealso href="http://voag.linkedmodel.org/voag#CreativeCommonsJurisdiction">http://voag.linkedmodel.org/voag#CreativeCommonsJurisdiction</seealso>
    let CreativeCommonsJurisdiction =
        Prefixed_Name(voagm, "CreativeCommonsJurisdiction") |> PrefixedName

    /// <summary>
    ///   <para>voagm:CreativeCommonsPermission</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Creative Commons Permission"</para></remarks>
    /// <seealso href="http://voag.linkedmodel.org/voag#CreativeCommonsPermission">http://voag.linkedmodel.org/voag#CreativeCommonsPermission</seealso>
    let CreativeCommonsPermission =
        Prefixed_Name(voagm, "CreativeCommonsPermission") |> PrefixedName

    /// <summary>
    ///   <para>voagm:CreativeCommonsProhibition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Creative Commons Prohibition"</para></remarks>
    /// <seealso href="http://voag.linkedmodel.org/voag#CreativeCommonsProhibition">http://voag.linkedmodel.org/voag#CreativeCommonsProhibition</seealso>
    let CreativeCommonsProhibition =
        Prefixed_Name(voagm, "CreativeCommonsProhibition") |> PrefixedName

    /// <summary>
    ///   <para>voagm:CreativeCommonsRequirement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Requirement"</para></remarks>
    /// <seealso href="http://voag.linkedmodel.org/voag#CreativeCommonsRequirement">http://voag.linkedmodel.org/voag#CreativeCommonsRequirement</seealso>
    let CreativeCommonsRequirement =
        Prefixed_Name(voagm, "CreativeCommonsRequirement") |> PrefixedName

    /// <summary>
    ///   <para>voagm:CreativeCommonsWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Creative commons work"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"Creative Commons Work"</para></remarks>
    /// <seealso href="http://voag.linkedmodel.org/voag#CreativeCommonsWork">http://voag.linkedmodel.org/voag#CreativeCommonsWork</seealso>
    let CreativeCommonsWork =
        Prefixed_Name(voagm, "CreativeCommonsWork") |> PrefixedName

    /// <summary>
    ///   <para>voagm:DTYPE-CatalogEntry</para>
    /// </summary>
    /// <remarks>
    ///   <para>voagm:SchemaGraph</para>
    /// </remarks>
    /// <seealso href="http://voag.linkedmodel.org/voag#DTYPE-CatalogEntry">http://voag.linkedmodel.org/voag#DTYPE-CatalogEntry</seealso>
    let DTYPE_CatalogEntry = Prefixed_Name(voagm, "DTYPE-CatalogEntry") |> PrefixedName
    /// <summary>
    ///   <para>voagm:Daily</para>
    /// </summary>
    /// <remarks>
    ///   <para>voagm:ChangeFrequency</para>
    ///
    /// labels<para>"Daily"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://voag.linkedmodel.org/voag#Daily">http://voag.linkedmodel.org/voag#Daily</seealso>
    let Daily = Prefixed_Name(voagm, "Daily") |> PrefixedName
    /// <summary>
    ///   <para>voagm:DeferredIssue</para>
    /// </summary>
    /// <remarks>
    ///   <para>voagm:IssueStatus</para>
    ///
    /// labels<para>"Deferred"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://voag.linkedmodel.org/voag#DeferredIssue">http://voag.linkedmodel.org/voag#DeferredIssue</seealso>
    let DeferredIssue = Prefixed_Name(voagm, "DeferredIssue") |> PrefixedName
    /// <summary>
    ///   <para>voagm:DeletionEvent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Deletion Event"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://voag.linkedmodel.org/voag#DeletionEvent">http://voag.linkedmodel.org/voag#DeletionEvent</seealso>
    let DeletionEvent = Prefixed_Name(voagm, "DeletionEvent") |> PrefixedName

    /// <summary>
    ///   <para>voagm:DesignatedGovernanceRole</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Designated Governance Role"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://voag.linkedmodel.org/voag#DesignatedGovernanceRole">http://voag.linkedmodel.org/voag#DesignatedGovernanceRole</seealso>
    let DesignatedGovernanceRole =
        Prefixed_Name(voagm, "DesignatedGovernanceRole") |> PrefixedName

    /// <summary>
    ///   <para>voagm:DisapprovedIssue</para>
    /// </summary>
    /// <remarks>
    ///   <para>voagm:IssueStatus</para>
    ///
    /// labels<para>"Disapproved Issue"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://voag.linkedmodel.org/voag#DisapprovedIssue">http://voag.linkedmodel.org/voag#DisapprovedIssue</seealso>
    let DisapprovedIssue = Prefixed_Name(voagm, "DisapprovedIssue") |> PrefixedName
    /// <summary>
    ///   <para>voagm:Document</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Document"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://voag.linkedmodel.org/voag#Document">http://voag.linkedmodel.org/voag#Document</seealso>
    let Document = Prefixed_Name(voagm, "Document") |> PrefixedName

    /// <summary>
    ///   <para>voagm:DocumentationChange</para>
    /// </summary>
    /// <remarks>
    ///   <para>voagm:ChangeType</para>
    ///
    /// labels<para>"Documentation change"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://voag.linkedmodel.org/voag#DocumentationChange">http://voag.linkedmodel.org/voag#DocumentationChange</seealso>
    let DocumentationChange =
        Prefixed_Name(voagm, "DocumentationChange") |> PrefixedName

    /// <summary>
    ///   <para>voagm:EarlyAdoption</para>
    /// </summary>
    /// <remarks>
    ///   <para>voagm:Maturity</para>
    ///
    /// labels<para>"Early adoption"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://voag.linkedmodel.org/voag#EarlyAdoption">http://voag.linkedmodel.org/voag#EarlyAdoption</seealso>
    let EarlyAdoption = Prefixed_Name(voagm, "EarlyAdoption") |> PrefixedName
    /// <summary>
    ///   <para>voagm:EnumeratedValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Metadata Enumerated value"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://voag.linkedmodel.org/voag#EnumeratedValue">http://voag.linkedmodel.org/voag#EnumeratedValue</seealso>
    let EnumeratedValue = Prefixed_Name(voagm, "EnumeratedValue") |> PrefixedName
    /// <summary>
    ///   <para>voagm:Event</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Event"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://voag.linkedmodel.org/voag#Event">http://voag.linkedmodel.org/voag#Event</seealso>
    let Event = Prefixed_Name(voagm, "Event") |> PrefixedName
    /// <summary>
    ///   <para>voagm:Experimental</para>
    /// </summary>
    /// <remarks>
    ///   <para>voagm:Maturity</para>
    ///
    /// labels<para>"Experimental"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://voag.linkedmodel.org/voag#Experimental">http://voag.linkedmodel.org/voag#Experimental</seealso>
    let Experimental = Prefixed_Name(voagm, "Experimental") |> PrefixedName
    /// <summary>
    ///   <para>voagm:Figure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Figure"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://voag.linkedmodel.org/voag#Figure">http://voag.linkedmodel.org/voag#Figure</seealso>
    let Figure = Prefixed_Name(voagm, "Figure") |> PrefixedName
    /// <summary>
    ///   <para>voagm:GR_Authorizer</para>
    /// </summary>
    /// <remarks>
    ///   <para>voagm:GovernanceRole</para>
    ///
    /// labels<para>"Authorizer"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://voag.linkedmodel.org/voag#GR_Authorizer">http://voag.linkedmodel.org/voag#GR_Authorizer</seealso>
    let GR_Authorizer = Prefixed_Name(voagm, "GR_Authorizer") |> PrefixedName
    /// <summary>
    ///   <para>voagm:GR_Steward</para>
    /// </summary>
    /// <remarks>
    ///   <para>voagm:GovernanceRole</para>
    ///
    /// labels<para>"Steward"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://voag.linkedmodel.org/voag#GR_Steward">http://voag.linkedmodel.org/voag#GR_Steward</seealso>
    let GR_Steward = Prefixed_Name(voagm, "GR_Steward") |> PrefixedName
    /// <summary>
    ///   <para>voagm:GR_Submitter</para>
    /// </summary>
    /// <remarks>
    ///   <para>voagm:GovernanceRole</para>
    ///
    /// labels<para>"Submitter"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://voag.linkedmodel.org/voag#GR_Submitter">http://voag.linkedmodel.org/voag#GR_Submitter</seealso>
    let GR_Submitter = Prefixed_Name(voagm, "GR_Submitter") |> PrefixedName
    /// <summary>
    ///   <para>voagm:Governance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Governance"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://voag.linkedmodel.org/voag#Governance">http://voag.linkedmodel.org/voag#Governance</seealso>
    let Governance = Prefixed_Name(voagm, "Governance") |> PrefixedName
    /// <summary>
    ///   <para>voagm:GovernanceEvent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Governance Event"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://voag.linkedmodel.org/voag#GovernanceEvent">http://voag.linkedmodel.org/voag#GovernanceEvent</seealso>
    let GovernanceEvent = Prefixed_Name(voagm, "GovernanceEvent") |> PrefixedName
    /// <summary>
    ///   <para>voagm:GovernanceProcess</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Governance Process"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://voag.linkedmodel.org/voag#GovernanceProcess">http://voag.linkedmodel.org/voag#GovernanceProcess</seealso>
    let GovernanceProcess = Prefixed_Name(voagm, "GovernanceProcess") |> PrefixedName
    /// <summary>
    ///   <para>voagm:GovernanceProtocol</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Governance Protocol"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://voag.linkedmodel.org/voag#GovernanceProtocol">http://voag.linkedmodel.org/voag#GovernanceProtocol</seealso>
    let GovernanceProtocol = Prefixed_Name(voagm, "GovernanceProtocol") |> PrefixedName
    /// <summary>
    ///   <para>voagm:GovernanceRole</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Governance Role"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://voag.linkedmodel.org/voag#GovernanceRole">http://voag.linkedmodel.org/voag#GovernanceRole</seealso>
    let GovernanceRole = Prefixed_Name(voagm, "GovernanceRole") |> PrefixedName
    /// <summary>
    ///   <para>voagm:GovernedObject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Governed Object"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://voag.linkedmodel.org/voag#GovernedObject">http://voag.linkedmodel.org/voag#GovernedObject</seealso>
    let GovernedObject = Prefixed_Name(voagm, "GovernedObject") |> PrefixedName
    /// <summary>
    ///   <para>voagm:GovernedService</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Governed service"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://voag.linkedmodel.org/voag#GovernedService">http://voag.linkedmodel.org/voag#GovernedService</seealso>
    let GovernedService = Prefixed_Name(voagm, "GovernedService") |> PrefixedName
    /// <summary>
    ///   <para>voagm:Graph</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Graph"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://voag.linkedmodel.org/voag#Graph">http://voag.linkedmodel.org/voag#Graph</seealso>
    let Graph = Prefixed_Name(voagm, "Graph") |> PrefixedName
    /// <summary>
    ///   <para>voagm:Icon</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Icon"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://voag.linkedmodel.org/voag#Icon">http://voag.linkedmodel.org/voag#Icon</seealso>
    let Icon = Prefixed_Name(voagm, "Icon") |> PrefixedName
    /// <summary>
    ///   <para>voagm:Image</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Image"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://voag.linkedmodel.org/voag#Image">http://voag.linkedmodel.org/voag#Image</seealso>
    let Image = Prefixed_Name(voagm, "Image") |> PrefixedName
    /// <summary>
    ///   <para>voagm:InDevelopment</para>
    /// </summary>
    /// <remarks>
    ///   <para>voagm:Maturity</para>
    ///
    /// labels<para>"In development"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://voag.linkedmodel.org/voag#InDevelopment">http://voag.linkedmodel.org/voag#InDevelopment</seealso>
    let InDevelopment = Prefixed_Name(voagm, "InDevelopment") |> PrefixedName
    /// <summary>
    ///   <para>voagm:Issue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Issue"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://voag.linkedmodel.org/voag#Issue">http://voag.linkedmodel.org/voag#Issue</seealso>
    let Issue = Prefixed_Name(voagm, "Issue") |> PrefixedName

    /// <summary>
    ///   <para>voagm:IssueResolutionProcess</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Issue Resolution Process"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://voag.linkedmodel.org/voag#IssueResolutionProcess">http://voag.linkedmodel.org/voag#IssueResolutionProcess</seealso>
    let IssueResolutionProcess =
        Prefixed_Name(voagm, "IssueResolutionProcess") |> PrefixedName

    /// <summary>
    ///   <para>voagm:IssueStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Issue Status"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://voag.linkedmodel.org/voag#IssueStatus">http://voag.linkedmodel.org/voag#IssueStatus</seealso>
    let IssueStatus = Prefixed_Name(voagm, "IssueStatus") |> PrefixedName
    /// <summary>
    ///   <para>voagm:LicenseModel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"License Model"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://voag.linkedmodel.org/voag#LicenseModel">http://voag.linkedmodel.org/voag#LicenseModel</seealso>
    let LicenseModel = Prefixed_Name(voagm, "LicenseModel") |> PrefixedName

    /// <summary>
    ///   <para>voagm:LinkedModelLogo-200x80</para>
    /// </summary>
    /// <remarks>
    ///   <para>voagm:Logo</para>
    ///
    /// labels<para>"LinkedModel ICON 200 x 80"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://voag.linkedmodel.org/voag#LinkedModelLogo-200x80">http://voag.linkedmodel.org/voag#LinkedModelLogo-200x80</seealso>
    let LinkedModelLogo_200x80 =
        Prefixed_Name(voagm, "LinkedModelLogo-200x80") |> PrefixedName

    /// <summary>
    ///   <para>voagm:Logo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Logo"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://voag.linkedmodel.org/voag#Logo">http://voag.linkedmodel.org/voag#Logo</seealso>
    let Logo = Prefixed_Name(voagm, "Logo") |> PrefixedName
    /// <summary>
    ///   <para>voagm:Maturity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Maturity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://voag.linkedmodel.org/voag#Maturity">http://voag.linkedmodel.org/voag#Maturity</seealso>
    let Maturity = Prefixed_Name(voagm, "Maturity") |> PrefixedName
    /// <summary>
    ///   <para>voagm:ModificationChange</para>
    /// </summary>
    /// <remarks>
    ///   <para>voagm:ChangeType</para>
    ///
    /// labels<para>"Modification change"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://voag.linkedmodel.org/voag#ModificationChange">http://voag.linkedmodel.org/voag#ModificationChange</seealso>
    let ModificationChange = Prefixed_Name(voagm, "ModificationChange") |> PrefixedName
    /// <summary>
    ///   <para>voagm:Monthly</para>
    /// </summary>
    /// <remarks>
    ///   <para>voagm:ChangeFrequency</para>
    ///
    /// labels<para>"Monthly"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://voag.linkedmodel.org/voag#Monthly">http://voag.linkedmodel.org/voag#Monthly</seealso>
    let Monthly = Prefixed_Name(voagm, "Monthly") |> PrefixedName
    /// <summary>
    ///   <para>voagm:Never</para>
    /// </summary>
    /// <remarks>
    ///   <para>voagm:ChangeFrequency</para>
    ///
    /// labels<para>"Never"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://voag.linkedmodel.org/voag#Never">http://voag.linkedmodel.org/voag#Never</seealso>
    let Never = Prefixed_Name(voagm, "Never") |> PrefixedName

    /// <summary>
    ///   <para>voagm:NoAttributionSpecified</para>
    /// </summary>
    /// <remarks>
    ///   <para>voagm:Attribution</para>
    ///
    /// labels<para>"No attribution specified"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://voag.linkedmodel.org/voag#NoAttributionSpecified">http://voag.linkedmodel.org/voag#NoAttributionSpecified</seealso>
    let NoAttributionSpecified =
        Prefixed_Name(voagm, "NoAttributionSpecified") |> PrefixedName

    /// <summary>
    ///   <para>voagm:NoGovernanceSpecified</para>
    /// </summary>
    /// <remarks>
    ///   <para>voagm:Governance</para>
    ///
    /// labels<para>"No governance specified"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://voag.linkedmodel.org/voag#NoGovernanceSpecified">http://voag.linkedmodel.org/voag#NoGovernanceSpecified</seealso>
    let NoGovernanceSpecified =
        Prefixed_Name(voagm, "NoGovernanceSpecified") |> PrefixedName

    /// <summary>
    ///   <para>voagm:NoPedigreeSpecified</para>
    /// </summary>
    /// <remarks>
    ///   <para>voagm:Pedigree</para>
    ///
    /// labels<para>"No pedigree specified"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://voag.linkedmodel.org/voag#NoPedigreeSpecified">http://voag.linkedmodel.org/voag#NoPedigreeSpecified</seealso>
    let NoPedigreeSpecified =
        Prefixed_Name(voagm, "NoPedigreeSpecified") |> PrefixedName

    /// <summary>
    ///   <para>voagm:NoProvenanceSpecified</para>
    /// </summary>
    /// <remarks>
    ///   <para>voagm:Provenance</para>
    ///
    /// labels<para>"No provenance specified"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://voag.linkedmodel.org/voag#NoProvenanceSpecified">http://voag.linkedmodel.org/voag#NoProvenanceSpecified</seealso>
    let NoProvenanceSpecified =
        Prefixed_Name(voagm, "NoProvenanceSpecified") |> PrefixedName

    /// <summary>
    ///   <para>voagm:NonConcurrenceEvent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Non-Concurrence Event"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://voag.linkedmodel.org/voag#NonConcurrenceEvent">http://voag.linkedmodel.org/voag#NonConcurrenceEvent</seealso>
    let NonConcurrenceEvent =
        Prefixed_Name(voagm, "NonConcurrenceEvent") |> PrefixedName

    /// <summary>
    ///   <para>voagm:NonIssue</para>
    /// </summary>
    /// <remarks>
    ///   <para>voagm:IssueStatus</para>
    ///
    /// labels<para>"Non-issue"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://voag.linkedmodel.org/voag#NonIssue">http://voag.linkedmodel.org/voag#NonIssue</seealso>
    let NonIssue = Prefixed_Name(voagm, "NonIssue") |> PrefixedName
    /// <summary>
    ///   <para>voagm:OpenIssue</para>
    /// </summary>
    /// <remarks>
    ///   <para>voagm:IssueStatus</para>
    ///
    /// labels<para>"Open"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://voag.linkedmodel.org/voag#OpenIssue">http://voag.linkedmodel.org/voag#OpenIssue</seealso>
    let OpenIssue = Prefixed_Name(voagm, "OpenIssue") |> PrefixedName
    /// <summary>
    ///   <para>voagm:Organization</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Organization"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://voag.linkedmodel.org/voag#Organization">http://voag.linkedmodel.org/voag#Organization</seealso>
    let Organization = Prefixed_Name(voagm, "Organization") |> PrefixedName
    /// <summary>
    ///   <para>voagm:OrganizationLogo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Organization logo"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://voag.linkedmodel.org/voag#OrganizationLogo">http://voag.linkedmodel.org/voag#OrganizationLogo</seealso>
    let OrganizationLogo = Prefixed_Name(voagm, "OrganizationLogo") |> PrefixedName
    /// <summary>
    ///   <para>voagm:PS_Draft</para>
    /// </summary>
    /// <remarks>
    ///   <para>voagm:PublicationStatus</para>
    ///
    /// labels<para>"Draft Status"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://voag.linkedmodel.org/voag#PS_Draft">http://voag.linkedmodel.org/voag#PS_Draft</seealso>
    let PS_Draft = Prefixed_Name(voagm, "PS_Draft") |> PrefixedName
    /// <summary>
    ///   <para>voagm:PS_Final</para>
    /// </summary>
    /// <remarks>
    ///   <para>voagm:PublicationStatus</para>
    ///
    /// labels<para>"Final Status"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://voag.linkedmodel.org/voag#PS_Final">http://voag.linkedmodel.org/voag#PS_Final</seealso>
    let PS_Final = Prefixed_Name(voagm, "PS_Final") |> PrefixedName
    /// <summary>
    ///   <para>voagm:PS_Interim</para>
    /// </summary>
    /// <remarks>
    ///   <para>voagm:PublicationStatus</para>
    ///
    /// labels<para>"Interim Status"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://voag.linkedmodel.org/voag#PS_Interim">http://voag.linkedmodel.org/voag#PS_Interim</seealso>
    let PS_Interim = Prefixed_Name(voagm, "PS_Interim") |> PrefixedName
    /// <summary>
    ///   <para>voagm:PS_Obsolete</para>
    /// </summary>
    /// <remarks>
    ///   <para>voagm:PublicationStatus</para>
    ///
    /// labels<para>"Obsolete"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://voag.linkedmodel.org/voag#PS_Obsolete">http://voag.linkedmodel.org/voag#PS_Obsolete</seealso>
    let PS_Obsolete = Prefixed_Name(voagm, "PS_Obsolete") |> PrefixedName
    /// <summary>
    ///   <para>voagm:PS_Review</para>
    /// </summary>
    /// <remarks>
    ///   <para>voagm:PublicationStatus</para>
    ///
    /// labels<para>"Review"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://voag.linkedmodel.org/voag#PS_Review">http://voag.linkedmodel.org/voag#PS_Review</seealso>
    let PS_Review = Prefixed_Name(voagm, "PS_Review") |> PrefixedName
    /// <summary>
    ///   <para>voagm:PS_Unknown</para>
    /// </summary>
    /// <remarks>
    ///   <para>voagm:PublicationStatus</para>
    ///
    /// labels<para>"Unknown Status"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://voag.linkedmodel.org/voag#PS_Unknown">http://voag.linkedmodel.org/voag#PS_Unknown</seealso>
    let PS_Unknown = Prefixed_Name(voagm, "PS_Unknown") |> PrefixedName
    /// <summary>
    ///   <para>voagm:PV_HighPriority</para>
    /// </summary>
    /// <remarks>
    ///   <para>voagm:PriorityValue</para>
    ///
    /// labels<para>"High priority"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://voag.linkedmodel.org/voag#PV_HighPriority">http://voag.linkedmodel.org/voag#PV_HighPriority</seealso>
    let PV_HighPriority = Prefixed_Name(voagm, "PV_HighPriority") |> PrefixedName
    /// <summary>
    ///   <para>voagm:PV_LowPriority</para>
    /// </summary>
    /// <remarks>
    ///   <para>voagm:PriorityValue</para>
    ///
    /// labels<para>"Low priority"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://voag.linkedmodel.org/voag#PV_LowPriority">http://voag.linkedmodel.org/voag#PV_LowPriority</seealso>
    let PV_LowPriority = Prefixed_Name(voagm, "PV_LowPriority") |> PrefixedName
    /// <summary>
    ///   <para>voagm:PV_MediumPriority</para>
    /// </summary>
    /// <remarks>
    ///   <para>voagm:PriorityValue</para>
    ///
    /// labels<para>"Medium priority"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://voag.linkedmodel.org/voag#PV_MediumPriority">http://voag.linkedmodel.org/voag#PV_MediumPriority</seealso>
    let PV_MediumPriority = Prefixed_Name(voagm, "PV_MediumPriority") |> PrefixedName
    /// <summary>
    ///   <para>voagm:PV_NotApplicable</para>
    /// </summary>
    /// <remarks>
    ///   <para>voagm:PriorityValue</para>
    ///
    /// labels<para>"Not Applicable"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://voag.linkedmodel.org/voag#PV_NotApplicable">http://voag.linkedmodel.org/voag#PV_NotApplicable</seealso>
    let PV_NotApplicable = Prefixed_Name(voagm, "PV_NotApplicable") |> PrefixedName
    /// <summary>
    ///   <para>voagm:PV_ToBeDetermined</para>
    /// </summary>
    /// <remarks>
    ///   <para>voagm:PriorityValue</para>
    ///
    /// labels<para>"TBD"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://voag.linkedmodel.org/voag#PV_ToBeDetermined">http://voag.linkedmodel.org/voag#PV_ToBeDetermined</seealso>
    let PV_ToBeDetermined = Prefixed_Name(voagm, "PV_ToBeDetermined") |> PrefixedName
    /// <summary>
    ///   <para>voagm:Party</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Party"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://voag.linkedmodel.org/voag#Party">http://voag.linkedmodel.org/voag#Party</seealso>
    let Party = Prefixed_Name(voagm, "Party") |> PrefixedName
    /// <summary>
    ///   <para>voagm:Pedigree</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Pedigree"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://voag.linkedmodel.org/voag#Pedigree">http://voag.linkedmodel.org/voag#Pedigree</seealso>
    let Pedigree = Prefixed_Name(voagm, "Pedigree") |> PrefixedName
    /// <summary>
    ///   <para>voagm:Person</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Person"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://voag.linkedmodel.org/voag#Person">http://voag.linkedmodel.org/voag#Person</seealso>
    let Person = Prefixed_Name(voagm, "Person") |> PrefixedName
    /// <summary>
    ///   <para>voagm:PriorityValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Priority value"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://voag.linkedmodel.org/voag#PriorityValue">http://voag.linkedmodel.org/voag#PriorityValue</seealso>
    let PriorityValue = Prefixed_Name(voagm, "PriorityValue") |> PrefixedName
    /// <summary>
    ///   <para>voagm:Process</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Process"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://voag.linkedmodel.org/voag#Process">http://voag.linkedmodel.org/voag#Process</seealso>
    let Process = Prefixed_Name(voagm, "Process") |> PrefixedName
    /// <summary>
    ///   <para>voagm:ProductLogo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Product logo"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://voag.linkedmodel.org/voag#ProductLogo">http://voag.linkedmodel.org/voag#ProductLogo</seealso>
    let ProductLogo = Prefixed_Name(voagm, "ProductLogo") |> PrefixedName
    /// <summary>
    ///   <para>voagm:Proposed</para>
    /// </summary>
    /// <remarks>
    ///   <para>voagm:Maturity</para>
    ///
    /// labels<para>"Proposed"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://voag.linkedmodel.org/voag#Proposed">http://voag.linkedmodel.org/voag#Proposed</seealso>
    let Proposed = Prefixed_Name(voagm, "Proposed") |> PrefixedName
    /// <summary>
    ///   <para>voagm:Provenance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Provenance"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://voag.linkedmodel.org/voag#Provenance">http://voag.linkedmodel.org/voag#Provenance</seealso>
    let Provenance = Prefixed_Name(voagm, "Provenance") |> PrefixedName
    /// <summary>
    ///   <para>voagm:PublicationStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Publication Status"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://voag.linkedmodel.org/voag#PublicationStatus">http://voag.linkedmodel.org/voag#PublicationStatus</seealso>
    let PublicationStatus = Prefixed_Name(voagm, "PublicationStatus") |> PrefixedName
    /// <summary>
    ///   <para>voagm:Qualifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Qualifier"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://voag.linkedmodel.org/voag#Qualifier">http://voag.linkedmodel.org/voag#Qualifier</seealso>
    let Qualifier = Prefixed_Name(voagm, "Qualifier") |> PrefixedName
    /// <summary>
    ///   <para>voagm:Quarterly</para>
    /// </summary>
    /// <remarks>
    ///   <para>voagm:ChangeFrequency</para>
    ///
    /// labels<para>"Quarterly"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://voag.linkedmodel.org/voag#Quarterly">http://voag.linkedmodel.org/voag#Quarterly</seealso>
    let Quarterly = Prefixed_Name(voagm, "Quarterly") |> PrefixedName
    /// <summary>
    ///   <para>voagm:RDFIcon-32X35</para>
    /// </summary>
    /// <remarks>
    ///   <para>voagm:Icon</para>
    ///
    /// labels<para>"RDF Icon 32 X 35"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://voag.linkedmodel.org/voag#RDFIcon-32X35">http://voag.linkedmodel.org/voag#RDFIcon-32X35</seealso>
    let RDFIcon_32X35 = Prefixed_Name(voagm, "RDFIcon-32X35") |> PrefixedName
    /// <summary>
    ///   <para>voagm:RefactoringChange</para>
    /// </summary>
    /// <remarks>
    ///   <para>voagm:ChangeType</para>
    ///
    /// labels<para>"Refactoring change"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://voag.linkedmodel.org/voag#RefactoringChange">http://voag.linkedmodel.org/voag#RefactoringChange</seealso>
    let RefactoringChange = Prefixed_Name(voagm, "RefactoringChange") |> PrefixedName
    /// <summary>
    ///   <para>voagm:RejectionEvent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Rejection Event"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://voag.linkedmodel.org/voag#RejectionEvent">http://voag.linkedmodel.org/voag#RejectionEvent</seealso>
    let RejectionEvent = Prefixed_Name(voagm, "RejectionEvent") |> PrefixedName
    /// <summary>
    ///   <para>voagm:ResolvedIssue</para>
    /// </summary>
    /// <remarks>
    ///   <para>voagm:IssueStatus</para>
    ///
    /// labels<para>"Resolved"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://voag.linkedmodel.org/voag#ResolvedIssue">http://voag.linkedmodel.org/voag#ResolvedIssue</seealso>
    let ResolvedIssue = Prefixed_Name(voagm, "ResolvedIssue") |> PrefixedName
    /// <summary>
    ///   <para>voagm:RetreivalEvent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Retreival Event"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://voag.linkedmodel.org/voag#RetreivalEvent">http://voag.linkedmodel.org/voag#RetreivalEvent</seealso>
    let RetreivalEvent = Prefixed_Name(voagm, "RetreivalEvent") |> PrefixedName
    /// <summary>
    ///   <para>voagm:ReviewEvent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Review"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://voag.linkedmodel.org/voag#ReviewEvent">http://voag.linkedmodel.org/voag#ReviewEvent</seealso>
    let ReviewEvent = Prefixed_Name(voagm, "ReviewEvent") |> PrefixedName
    /// <summary>
    ///   <para>voagm:SPARQLIcon-80X15</para>
    /// </summary>
    /// <remarks>
    ///   <para>voagm:Icon</para>
    ///
    /// labels<para>"SPARQL ICON 80 X 15"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://voag.linkedmodel.org/voag#SPARQLIcon-80X15">http://voag.linkedmodel.org/voag#SPARQLIcon-80X15</seealso>
    let SPARQLIcon_80X15 = Prefixed_Name(voagm, "SPARQLIcon-80X15") |> PrefixedName
    /// <summary>
    ///   <para>voagm:SchemaGraph</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Schema graph"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://voag.linkedmodel.org/voag#SchemaGraph">http://voag.linkedmodel.org/voag#SchemaGraph</seealso>
    let SchemaGraph = Prefixed_Name(voagm, "SchemaGraph") |> PrefixedName
    /// <summary>
    ///   <para>voagm:Service</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Service"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://voag.linkedmodel.org/voag#Service">http://voag.linkedmodel.org/voag#Service</seealso>
    let Service = Prefixed_Name(voagm, "Service") |> PrefixedName
    /// <summary>
    ///   <para>voagm:SomeAdoption</para>
    /// </summary>
    /// <remarks>
    ///   <para>voagm:Maturity</para>
    ///
    /// labels<para>"Some adoption"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://voag.linkedmodel.org/voag#SomeAdoption">http://voag.linkedmodel.org/voag#SomeAdoption</seealso>
    let SomeAdoption = Prefixed_Name(voagm, "SomeAdoption") |> PrefixedName
    /// <summary>
    ///   <para>voagm:StakeholderGroup</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Stakeholder Group"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://voag.linkedmodel.org/voag#StakeholderGroup">http://voag.linkedmodel.org/voag#StakeholderGroup</seealso>
    let StakeholderGroup = Prefixed_Name(voagm, "StakeholderGroup") |> PrefixedName
    /// <summary>
    ///   <para>voagm:Standard</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Standard"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://voag.linkedmodel.org/voag#Standard">http://voag.linkedmodel.org/voag#Standard</seealso>
    let Standard = Prefixed_Name(voagm, "Standard") |> PrefixedName

    /// <summary>
    ///   <para>voagm:TopQuadrantAttribution</para>
    /// </summary>
    /// <remarks>
    ///   <para>voagm:Attribution</para>
    ///
    /// labels<para>"TopQuadrant attribution"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://voag.linkedmodel.org/voag#TopQuadrantAttribution">http://voag.linkedmodel.org/voag#TopQuadrantAttribution</seealso>
    let TopQuadrantAttribution =
        Prefixed_Name(voagm, "TopQuadrantAttribution") |> PrefixedName

    /// <summary>
    ///   <para>voagm:TopQuadrantLogo-613x150</para>
    /// </summary>
    /// <remarks>
    ///   <para>voagm:OrganizationLogo</para>
    ///   <para>voagm:AttributionLogo</para>
    ///
    /// labels<para>"TopQuadrant Logo 613 x 150"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://voag.linkedmodel.org/voag#TopQuadrantLogo-613x150">http://voag.linkedmodel.org/voag#TopQuadrantLogo-613x150</seealso>
    let TopQuadrantLogo_613x150 =
        Prefixed_Name(voagm, "TopQuadrantLogo-613x150") |> PrefixedName

    /// <summary>
    ///   <para>voagm:TurtleIcon-32bX35</para>
    /// </summary>
    /// <remarks>
    ///   <para>voagm:Icon</para>
    ///
    /// labels<para>"Turtle Icon 32 X 35"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://voag.linkedmodel.org/voag#TurtleIcon-32bX35">http://voag.linkedmodel.org/voag#TurtleIcon-32bX35</seealso>
    let TurtleIcon_32bX35 = Prefixed_Name(voagm, "TurtleIcon-32bX35") |> PrefixedName
    /// <summary>
    ///   <para>voagm:UncertainFrequency</para>
    /// </summary>
    /// <remarks>
    ///   <para>voagm:ChangeFrequency</para>
    ///
    /// labels<para>"Uncertain frequency"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://voag.linkedmodel.org/voag#UncertainFrequency">http://voag.linkedmodel.org/voag#UncertainFrequency</seealso>
    let UncertainFrequency = Prefixed_Name(voagm, "UncertainFrequency") |> PrefixedName
    /// <summary>
    ///   <para>voagm:UnknownMaturity</para>
    /// </summary>
    /// <remarks>
    ///   <para>voagm:Maturity</para>
    ///
    /// labels<para>"Unknown maturity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://voag.linkedmodel.org/voag#UnknownMaturity">http://voag.linkedmodel.org/voag#UnknownMaturity</seealso>
    let UnknownMaturity = Prefixed_Name(voagm, "UnknownMaturity") |> PrefixedName
    /// <summary>
    ///   <para>voagm:VAEM-CatalogEntry</para>
    /// </summary>
    /// <remarks>
    ///   <para>voagm:SchemaGraph</para>
    /// </remarks>
    /// <seealso href="http://voag.linkedmodel.org/voag#VAEM-CatalogEntry">http://voag.linkedmodel.org/voag#VAEM-CatalogEntry</seealso>
    let VAEM_CatalogEntry = Prefixed_Name(voagm, "VAEM-CatalogEntry") |> PrefixedName

    /// <summary>
    ///   <para>voagm:VAEM-XINA-CatalogEntry</para>
    /// </summary>
    /// <remarks>
    ///   <para>voagm:SchemaGraph</para>
    /// </remarks>
    /// <seealso href="http://voag.linkedmodel.org/voag#VAEM-XINA-CatalogEntry">http://voag.linkedmodel.org/voag#VAEM-XINA-CatalogEntry</seealso>
    let VAEM_XINA_CatalogEntry =
        Prefixed_Name(voagm, "VAEM-XINA-CatalogEntry") |> PrefixedName

    /// <summary>
    ///   <para>voagm:VOAG-CatalogEntry</para>
    /// </summary>
    /// <remarks>
    ///   <para>voagm:SchemaGraph</para>
    ///   <para>vaem:CatalogEntry</para>
    ///
    /// labels<para>"VOAG Catalog Entry"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://voag.linkedmodel.org/voag#VOAG-CatalogEntry">http://voag.linkedmodel.org/voag#VOAG-CatalogEntry</seealso>
    let VOAG_CatalogEntry = Prefixed_Name(voagm, "VOAG-CatalogEntry") |> PrefixedName

    /// <summary>
    ///   <para>voagm:VOAG-OntologyLogo_360x110</para>
    /// </summary>
    /// <remarks>
    ///   <para>voagm:ProductLogo</para>
    ///
    /// labels<para>"VOAG Logo"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://voag.linkedmodel.org/voag#VOAG-OntologyLogo_360x110">http://voag.linkedmodel.org/voag#VOAG-OntologyLogo_360x110</seealso>
    let VOAG_OntologyLogo_360x110 =
        Prefixed_Name(voagm, "VOAG-OntologyLogo_360x110") |> PrefixedName

    /// <summary>
    ///   <para>voagm:VocabGraph</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Vocab graph"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://voag.linkedmodel.org/voag#VocabGraph">http://voag.linkedmodel.org/voag#VocabGraph</seealso>
    let VocabGraph = Prefixed_Name(voagm, "VocabGraph") |> PrefixedName
    /// <summary>
    ///   <para>voagm:Weekly</para>
    /// </summary>
    /// <remarks>
    ///   <para>voagm:ChangeFrequency</para>
    ///
    /// labels<para>"Weekly"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://voag.linkedmodel.org/voag#Weekly">http://voag.linkedmodel.org/voag#Weekly</seealso>
    let Weekly = Prefixed_Name(voagm, "Weekly") |> PrefixedName
    /// <summary>
    ///   <para>voagm:WidelyAdopted</para>
    /// </summary>
    /// <remarks>
    ///   <para>voagm:Maturity</para>
    ///
    /// labels<para>"Widely adopted"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://voag.linkedmodel.org/voag#WidelyAdopted">http://voag.linkedmodel.org/voag#WidelyAdopted</seealso>
    let WidelyAdopted = Prefixed_Name(voagm, "WidelyAdopted") |> PrefixedName
    /// <summary>
    ///   <para>voagm:accountableFor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"accountable for"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://voag.linkedmodel.org/voag#accountableFor">http://voag.linkedmodel.org/voag#accountableFor</seealso>
    let accountableFor = Prefixed_Name(voagm, "accountableFor") |> PrefixedName
    /// <summary>
    ///   <para>voagm:approves</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"approves"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://voag.linkedmodel.org/voag#approves">http://voag.linkedmodel.org/voag#approves</seealso>
    let approves = Prefixed_Name(voagm, "approves") |> PrefixedName
    /// <summary>
    ///   <para>voagm:attributionText</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"attribution text"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://voag.linkedmodel.org/voag#attributionText">http://voag.linkedmodel.org/voag#attributionText</seealso>
    let attributionText = Prefixed_Name(voagm, "attributionText") |> PrefixedName
    /// <summary>
    ///   <para>voagm:caption</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"caption"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://voag.linkedmodel.org/voag#caption">http://voag.linkedmodel.org/voag#caption</seealso>
    let caption = Prefixed_Name(voagm, "caption") |> PrefixedName
    /// <summary>
    ///   <para>voagm:compatibleWith</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:SymmetricProperty</para>
    ///
    /// labels<para>"compatible with"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://voag.linkedmodel.org/voag#compatibleWith">http://voag.linkedmodel.org/voag#compatibleWith</seealso>
    let compatibleWith = Prefixed_Name(voagm, "compatibleWith") |> PrefixedName
    /// <summary>
    ///   <para>voagm:curatedGraphURI</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"curated graph URI"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://voag.linkedmodel.org/voag#curatedGraphURI">http://voag.linkedmodel.org/voag#curatedGraphURI</seealso>
    let curatedGraphURI = Prefixed_Name(voagm, "curatedGraphURI") |> PrefixedName
    /// <summary>
    ///   <para>voagm:deprecated</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"deprecated on"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://voag.linkedmodel.org/voag#deprecated">http://voag.linkedmodel.org/voag#deprecated</seealso>
    let deprecated = Prefixed_Name(voagm, "deprecated") |> PrefixedName
    /// <summary>
    ///   <para>voagm:derivedFrom</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"derived from"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://voag.linkedmodel.org/voag#derivedFrom">http://voag.linkedmodel.org/voag#derivedFrom</seealso>
    let derivedFrom = Prefixed_Name(voagm, "derivedFrom") |> PrefixedName
    /// <summary>
    ///   <para>voagm:disposition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"used to connect to the text describing disposition of something, for example, a disposition of an issue"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"disposition"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://voag.linkedmodel.org/voag#disposition">http://voag.linkedmodel.org/voag#disposition</seealso>
    let disposition = Prefixed_Name(voagm, "disposition") |> PrefixedName
    /// <summary>
    ///   <para>voagm:dispositionStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"disposition status"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://voag.linkedmodel.org/voag#dispositionStatus">http://voag.linkedmodel.org/voag#dispositionStatus</seealso>
    let dispositionStatus = Prefixed_Name(voagm, "dispositionStatus") |> PrefixedName
    /// <summary>
    ///   <para>voagm:documentedAt</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"documented at"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://voag.linkedmodel.org/voag#documentedAt">http://voag.linkedmodel.org/voag#documentedAt</seealso>
    let documentedAt = Prefixed_Name(voagm, "documentedAt") |> PrefixedName
    /// <summary>
    ///   <para>voagm:downloads</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"downloads"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://voag.linkedmodel.org/voag#downloads">http://voag.linkedmodel.org/voag#downloads</seealso>
    let downloads = Prefixed_Name(voagm, "downloads") |> PrefixedName
    /// <summary>
    ///   <para>voagm:endDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"end date"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://voag.linkedmodel.org/voag#endDate">http://voag.linkedmodel.org/voag#endDate</seealso>
    let endDate = Prefixed_Name(voagm, "endDate") |> PrefixedName
    /// <summary>
    ///   <para>voagm:eventDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"event date"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://voag.linkedmodel.org/voag#eventDate">http://voag.linkedmodel.org/voag#eventDate</seealso>
    let eventDate = Prefixed_Name(voagm, "eventDate") |> PrefixedName
    /// <summary>
    ///   <para>voagm:exclude</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///
    /// labels<para>"exclude"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://voag.linkedmodel.org/voag#exclude">http://voag.linkedmodel.org/voag#exclude</seealso>
    let exclude = Prefixed_Name(voagm, "exclude") |> PrefixedName
    /// <summary>
    ///   <para>voagm:frequencyOfChange</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"frequency of change"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://voag.linkedmodel.org/voag#frequencyOfChange">http://voag.linkedmodel.org/voag#frequencyOfChange</seealso>
    let frequencyOfChange = Prefixed_Name(voagm, "frequencyOfChange") |> PrefixedName

    /// <summary>
    ///   <para>voagm:givesConcurrenceFor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"gives concurrence for"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://voag.linkedmodel.org/voag#givesConcurrenceFor">http://voag.linkedmodel.org/voag#givesConcurrenceFor</seealso>
    let givesConcurrenceFor =
        Prefixed_Name(voagm, "givesConcurrenceFor") |> PrefixedName

    /// <summary>
    ///   <para>voagm:governs</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"governs"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://voag.linkedmodel.org/voag#governs">http://voag.linkedmodel.org/voag#governs</seealso>
    let governs = Prefixed_Name(voagm, "governs") |> PrefixedName
    /// <summary>
    ///   <para>voagm:hasAccredidation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has accredidation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://voag.linkedmodel.org/voag#hasAccredidation">http://voag.linkedmodel.org/voag#hasAccredidation</seealso>
    let hasAccredidation = Prefixed_Name(voagm, "hasAccredidation") |> PrefixedName

    /// <summary>
    ///   <para>voagm:hasAnticipatedChangeType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has anticipated change type"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://voag.linkedmodel.org/voag#hasAnticipatedChangeType">http://voag.linkedmodel.org/voag#hasAnticipatedChangeType</seealso>
    let hasAnticipatedChangeType =
        Prefixed_Name(voagm, "hasAnticipatedChangeType") |> PrefixedName

    /// <summary>
    ///   <para>voagm:hasApplicableDocument</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has applicable document"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://voag.linkedmodel.org/voag#hasApplicableDocument">http://voag.linkedmodel.org/voag#hasApplicableDocument</seealso>
    let hasApplicableDocument =
        Prefixed_Name(voagm, "hasApplicableDocument") |> PrefixedName

    /// <summary>
    ///   <para>voagm:hasApprovalProcess</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has approval process"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://voag.linkedmodel.org/voag#hasApprovalProcess">http://voag.linkedmodel.org/voag#hasApprovalProcess</seealso>
    let hasApprovalProcess = Prefixed_Name(voagm, "hasApprovalProcess") |> PrefixedName
    /// <summary>
    ///   <para>voagm:hasApprovalStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has approval status"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://voag.linkedmodel.org/voag#hasApprovalStatus">http://voag.linkedmodel.org/voag#hasApprovalStatus</seealso>
    let hasApprovalStatus = Prefixed_Name(voagm, "hasApprovalStatus") |> PrefixedName
    /// <summary>
    ///   <para>voagm:hasCategory</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has category"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://voag.linkedmodel.org/voag#hasCategory">http://voag.linkedmodel.org/voag#hasCategory</seealso>
    let hasCategory = Prefixed_Name(voagm, "hasCategory") |> PrefixedName

    /// <summary>
    ///   <para>voagm:hasChangeManagementProcess</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has change management process"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://voag.linkedmodel.org/voag#hasChangeManagementProcess">http://voag.linkedmodel.org/voag#hasChangeManagementProcess</seealso>
    let hasChangeManagementProcess =
        Prefixed_Name(voagm, "hasChangeManagementProcess") |> PrefixedName

    /// <summary>
    ///   <para>voagm:hasChangeType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has change type"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://voag.linkedmodel.org/voag#hasChangeType">http://voag.linkedmodel.org/voag#hasChangeType</seealso>
    let hasChangeType = Prefixed_Name(voagm, "hasChangeType") |> PrefixedName
    /// <summary>
    ///   <para>voagm:hasConfidentiality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has confidentiality"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://voag.linkedmodel.org/voag#hasConfidentiality">http://voag.linkedmodel.org/voag#hasConfidentiality</seealso>
    let hasConfidentiality = Prefixed_Name(voagm, "hasConfidentiality") |> PrefixedName
    /// <summary>
    ///   <para>voagm:hasGovernance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has governance"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://voag.linkedmodel.org/voag#hasGovernance">http://voag.linkedmodel.org/voag#hasGovernance</seealso>
    let hasGovernance = Prefixed_Name(voagm, "hasGovernance") |> PrefixedName
    /// <summary>
    ///   <para>voagm:hasGovernanceEvent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has governance event"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://voag.linkedmodel.org/voag#hasGovernanceEvent">http://voag.linkedmodel.org/voag#hasGovernanceEvent</seealso>
    let hasGovernanceEvent = Prefixed_Name(voagm, "hasGovernanceEvent") |> PrefixedName
    /// <summary>
    ///   <para>voagm:hasIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has identifier"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://voag.linkedmodel.org/voag#hasIdentifier">http://voag.linkedmodel.org/voag#hasIdentifier</seealso>
    let hasIdentifier = Prefixed_Name(voagm, "hasIdentifier") |> PrefixedName
    /// <summary>
    ///   <para>voagm:hasIssue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has issue"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://voag.linkedmodel.org/voag#hasIssue">http://voag.linkedmodel.org/voag#hasIssue</seealso>
    let hasIssue = Prefixed_Name(voagm, "hasIssue") |> PrefixedName

    /// <summary>
    ///   <para>voagm:hasIssueResolutionProcess</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has issue resolution process"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://voag.linkedmodel.org/voag#hasIssueResolutionProcess">http://voag.linkedmodel.org/voag#hasIssueResolutionProcess</seealso>
    let hasIssueResolutionProcess =
        Prefixed_Name(voagm, "hasIssueResolutionProcess") |> PrefixedName

    /// <summary>
    ///   <para>voagm:hasLogo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has logo"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://voag.linkedmodel.org/voag#hasLogo">http://voag.linkedmodel.org/voag#hasLogo</seealso>
    let hasLogo = Prefixed_Name(voagm, "hasLogo") |> PrefixedName
    /// <summary>
    ///   <para>voagm:hasMaturity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has maturity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://voag.linkedmodel.org/voag#hasMaturity">http://voag.linkedmodel.org/voag#hasMaturity</seealso>
    let hasMaturity = Prefixed_Name(voagm, "hasMaturity") |> PrefixedName

    /// <summary>
    ///   <para>voagm:hasNormativeDocument</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has normative document"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://voag.linkedmodel.org/voag#hasNormativeDocument">http://voag.linkedmodel.org/voag#hasNormativeDocument</seealso>
    let hasNormativeDocument =
        Prefixed_Name(voagm, "hasNormativeDocument") |> PrefixedName

    /// <summary>
    ///   <para>voagm:hasOntologyArchitectureDiagram</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has ontology architecture diagram"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://voag.linkedmodel.org/voag#hasOntologyArchitectureDiagram">http://voag.linkedmodel.org/voag#hasOntologyArchitectureDiagram</seealso>
    let hasOntologyArchitectureDiagram =
        Prefixed_Name(voagm, "hasOntologyArchitectureDiagram") |> PrefixedName

    /// <summary>
    ///   <para>voagm:hasOwner</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has owner"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://voag.linkedmodel.org/voag#hasOwner">http://voag.linkedmodel.org/voag#hasOwner</seealso>
    let hasOwner = Prefixed_Name(voagm, "hasOwner") |> PrefixedName
    /// <summary>
    ///   <para>voagm:hasPedigree</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has pedigree"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://voag.linkedmodel.org/voag#hasPedigree">http://voag.linkedmodel.org/voag#hasPedigree</seealso>
    let hasPedigree = Prefixed_Name(voagm, "hasPedigree") |> PrefixedName
    /// <summary>
    ///   <para>voagm:hasProcess</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has process"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://voag.linkedmodel.org/voag#hasProcess">http://voag.linkedmodel.org/voag#hasProcess</seealso>
    let hasProcess = Prefixed_Name(voagm, "hasProcess") |> PrefixedName
    /// <summary>
    ///   <para>voagm:hasProtocol</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has protocol"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://voag.linkedmodel.org/voag#hasProtocol">http://voag.linkedmodel.org/voag#hasProtocol</seealso>
    let hasProtocol = Prefixed_Name(voagm, "hasProtocol") |> PrefixedName
    /// <summary>
    ///   <para>voagm:hasProvenance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has provenance"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://voag.linkedmodel.org/voag#hasProvenance">http://voag.linkedmodel.org/voag#hasProvenance</seealso>
    let hasProvenance = Prefixed_Name(voagm, "hasProvenance") |> PrefixedName

    /// <summary>
    ///   <para>voagm:hasReferenceDocument</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has reference document"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://voag.linkedmodel.org/voag#hasReferenceDocument">http://voag.linkedmodel.org/voag#hasReferenceDocument</seealso>
    let hasReferenceDocument =
        Prefixed_Name(voagm, "hasReferenceDocument") |> PrefixedName

    /// <summary>
    ///   <para>voagm:hasStakeholder</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has stakeholder"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://voag.linkedmodel.org/voag#hasStakeholder">http://voag.linkedmodel.org/voag#hasStakeholder</seealso>
    let hasStakeholder = Prefixed_Name(voagm, "hasStakeholder") |> PrefixedName
    /// <summary>
    ///   <para>voagm:hasStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has status"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://voag.linkedmodel.org/voag#hasStatus">http://voag.linkedmodel.org/voag#hasStatus</seealso>
    let hasStatus = Prefixed_Name(voagm, "hasStatus") |> PrefixedName
    /// <summary>
    ///   <para>voagm:hasSteward</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has steward"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://voag.linkedmodel.org/voag#hasSteward">http://voag.linkedmodel.org/voag#hasSteward</seealso>
    let hasSteward = Prefixed_Name(voagm, "hasSteward") |> PrefixedName
    /// <summary>
    ///   <para>voagm:hasValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has value"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://voag.linkedmodel.org/voag#hasValue">http://voag.linkedmodel.org/voag#hasValue</seealso>
    let hasValue = Prefixed_Name(voagm, "hasValue") |> PrefixedName
    /// <summary>
    ///   <para>voagm:height</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"height"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://voag.linkedmodel.org/voag#height">http://voag.linkedmodel.org/voag#height</seealso>
    let height = Prefixed_Name(voagm, "height") |> PrefixedName
    /// <summary>
    ///   <para>voagm:id</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"id"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://voag.linkedmodel.org/voag#id">http://voag.linkedmodel.org/voag#id</seealso>
    let id = Prefixed_Name(voagm, "id") |> PrefixedName
    /// <summary>
    ///   <para>voagm:image</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"image"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://voag.linkedmodel.org/voag#image">http://voag.linkedmodel.org/voag#image</seealso>
    let image = Prefixed_Name(voagm, "image") |> PrefixedName
    /// <summary>
    ///   <para>voagm:imageMap</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"image map"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://voag.linkedmodel.org/voag#imageMap">http://voag.linkedmodel.org/voag#imageMap</seealso>
    let imageMap = Prefixed_Name(voagm, "imageMap") |> PrefixedName
    /// <summary>
    ///   <para>voagm:incompatibleWith</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:SymmetricProperty</para>
    ///
    /// labels<para>"incompatible with"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://voag.linkedmodel.org/voag#incompatibleWith">http://voag.linkedmodel.org/voag#incompatibleWith</seealso>
    let incompatibleWith = Prefixed_Name(voagm, "incompatibleWith") |> PrefixedName
    /// <summary>
    ///   <para>voagm:instigatedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"instigated by"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://voag.linkedmodel.org/voag#instigatedBy">http://voag.linkedmodel.org/voag#instigatedBy</seealso>
    let instigatedBy = Prefixed_Name(voagm, "instigatedBy") |> PrefixedName
    /// <summary>
    ///   <para>voagm:instigatingEvent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"instigating event"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://voag.linkedmodel.org/voag#instigatingEvent">http://voag.linkedmodel.org/voag#instigatingEvent</seealso>
    let instigatingEvent = Prefixed_Name(voagm, "instigatingEvent") |> PrefixedName
    /// <summary>
    ///   <para>voagm:intent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"intent"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://voag.linkedmodel.org/voag#intent">http://voag.linkedmodel.org/voag#intent</seealso>
    let intent = Prefixed_Name(voagm, "intent") |> PrefixedName
    /// <summary>
    ///   <para>voagm:interestIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"interest in"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://voag.linkedmodel.org/voag#interestIn">http://voag.linkedmodel.org/voag#interestIn</seealso>
    let interestIn = Prefixed_Name(voagm, "interestIn") |> PrefixedName
    /// <summary>
    ///   <para>voagm:isApprovedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is approved by"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://voag.linkedmodel.org/voag#isApprovedBy">http://voag.linkedmodel.org/voag#isApprovedBy</seealso>
    let isApprovedBy = Prefixed_Name(voagm, "isApprovedBy") |> PrefixedName
    /// <summary>
    ///   <para>voagm:isFOSS</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"is FOSS"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://voag.linkedmodel.org/voag#isFOSS">http://voag.linkedmodel.org/voag#isFOSS</seealso>
    let isFOSS = Prefixed_Name(voagm, "isFOSS") |> PrefixedName
    /// <summary>
    ///   <para>voagm:isGovernedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is governed by"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://voag.linkedmodel.org/voag#isGovernedBy">http://voag.linkedmodel.org/voag#isGovernedBy</seealso>
    let isGovernedBy = Prefixed_Name(voagm, "isGovernedBy") |> PrefixedName
    /// <summary>
    ///   <para>voagm:isITAR</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DeprecatedProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"is ITAR"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://voag.linkedmodel.org/voag#isITAR">http://voag.linkedmodel.org/voag#isITAR</seealso>
    let isITAR = Prefixed_Name(voagm, "isITAR") |> PrefixedName
    /// <summary>
    ///   <para>voagm:isInterestOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"interest of"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://voag.linkedmodel.org/voag#isInterestOf">http://voag.linkedmodel.org/voag#isInterestOf</seealso>
    let isInterestOf = Prefixed_Name(voagm, "isInterestOf") |> PrefixedName
    /// <summary>
    ///   <para>voagm:jurisdiction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"jurisdiction"</para><para>"jurisdiction"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://voag.linkedmodel.org/voag#jurisdiction">http://voag.linkedmodel.org/voag#jurisdiction</seealso>
    let jurisdiction = Prefixed_Name(voagm, "jurisdiction") |> PrefixedName
    /// <summary>
    ///   <para>voagm:legalcode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"legalcode"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://voag.linkedmodel.org/voag#legalcode">http://voag.linkedmodel.org/voag#legalcode</seealso>
    let legalcode = Prefixed_Name(voagm, "legalcode") |> PrefixedName
    /// <summary>
    ///   <para>voagm:licence</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"licence"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://voag.linkedmodel.org/voag#licence">http://voag.linkedmodel.org/voag#licence</seealso>
    let licence = Prefixed_Name(voagm, "licence") |> PrefixedName

    /// <summary>
    ///   <para>voagm:mayNeedConcurrenceFrom</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"may need concurrence from"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://voag.linkedmodel.org/voag#mayNeedConcurrenceFrom">http://voag.linkedmodel.org/voag#mayNeedConcurrenceFrom</seealso>
    let mayNeedConcurrenceFrom =
        Prefixed_Name(voagm, "mayNeedConcurrenceFrom") |> PrefixedName

    /// <summary>
    ///   <para>voagm:morePermissions</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"more permissions"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://voag.linkedmodel.org/voag#morePermissions">http://voag.linkedmodel.org/voag#morePermissions</seealso>
    let morePermissions = Prefixed_Name(voagm, "morePermissions") |> PrefixedName
    /// <summary>
    ///   <para>voagm:normativeReference</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"normative reference"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://voag.linkedmodel.org/voag#normativeReference">http://voag.linkedmodel.org/voag#normativeReference</seealso>
    let normativeReference = Prefixed_Name(voagm, "normativeReference") |> PrefixedName
    /// <summary>
    ///   <para>voagm:normativeURL</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"normative URL"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://voag.linkedmodel.org/voag#normativeURL">http://voag.linkedmodel.org/voag#normativeURL</seealso>
    let normativeURL = Prefixed_Name(voagm, "normativeURL") |> PrefixedName
    /// <summary>
    ///   <para>voagm:obsoletedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"obsoleted by"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://voag.linkedmodel.org/voag#obsoletedBy">http://voag.linkedmodel.org/voag#obsoletedBy</seealso>
    let obsoletedBy = Prefixed_Name(voagm, "obsoletedBy") |> PrefixedName
    /// <summary>
    ///   <para>voagm:ownedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"owned by"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://voag.linkedmodel.org/voag#ownedBy">http://voag.linkedmodel.org/voag#ownedBy</seealso>
    let ownedBy = Prefixed_Name(voagm, "ownedBy") |> PrefixedName
    /// <summary>
    ///   <para>voagm:owner</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"owner"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://voag.linkedmodel.org/voag#owner">http://voag.linkedmodel.org/voag#owner</seealso>
    let owner = Prefixed_Name(voagm, "owner") |> PrefixedName
    /// <summary>
    ///   <para>voagm:owns</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"owns"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://voag.linkedmodel.org/voag#owns">http://voag.linkedmodel.org/voag#owns</seealso>
    let owns = Prefixed_Name(voagm, "owns") |> PrefixedName
    /// <summary>
    ///   <para>voagm:participant</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"participant"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://voag.linkedmodel.org/voag#participant">http://voag.linkedmodel.org/voag#participant</seealso>
    let participant = Prefixed_Name(voagm, "participant") |> PrefixedName
    /// <summary>
    ///   <para>voagm:performedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"performed by"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://voag.linkedmodel.org/voag#performedBy">http://voag.linkedmodel.org/voag#performedBy</seealso>
    let performedBy = Prefixed_Name(voagm, "performedBy") |> PrefixedName
    /// <summary>
    ///   <para>voagm:permits</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"permits"</para><para>"permits"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://voag.linkedmodel.org/voag#permits">http://voag.linkedmodel.org/voag#permits</seealso>
    let permits = Prefixed_Name(voagm, "permits") |> PrefixedName
    /// <summary>
    ///   <para>voagm:pointOfContact</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"point of contact"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://voag.linkedmodel.org/voag#pointOfContact">http://voag.linkedmodel.org/voag#pointOfContact</seealso>
    let pointOfContact = Prefixed_Name(voagm, "pointOfContact") |> PrefixedName
    /// <summary>
    ///   <para>voagm:preparedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"prepared by"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://voag.linkedmodel.org/voag#preparedBy">http://voag.linkedmodel.org/voag#preparedBy</seealso>
    let preparedBy = Prefixed_Name(voagm, "preparedBy") |> PrefixedName
    /// <summary>
    ///   <para>voagm:priority</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"priority"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://voag.linkedmodel.org/voag#priority">http://voag.linkedmodel.org/voag#priority</seealso>
    let priority = Prefixed_Name(voagm, "priority") |> PrefixedName
    /// <summary>
    ///   <para>voagm:prohibits</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"prohibits"</para><para>"prohibits"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://voag.linkedmodel.org/voag#prohibits">http://voag.linkedmodel.org/voag#prohibits</seealso>
    let prohibits = Prefixed_Name(voagm, "prohibits") |> PrefixedName
    /// <summary>
    ///   <para>voagm:proprietary</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"proprietary"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://voag.linkedmodel.org/voag#proprietary">http://voag.linkedmodel.org/voag#proprietary</seealso>
    let proprietary = Prefixed_Name(voagm, "proprietary") |> PrefixedName
    /// <summary>
    ///   <para>voagm:relatedIssue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property connects two issue events. Issues connected by this property must be about the same subject"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"related issue"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://voag.linkedmodel.org/voag#relatedIssue">http://voag.linkedmodel.org/voag#relatedIssue</seealso>
    let relatedIssue = Prefixed_Name(voagm, "relatedIssue") |> PrefixedName
    /// <summary>
    ///   <para>voagm:relatedTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:SymmetricProperty</para>
    ///
    /// labels<para>"related to"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://voag.linkedmodel.org/voag#relatedTo">http://voag.linkedmodel.org/voag#relatedTo</seealso>
    let relatedTo = Prefixed_Name(voagm, "relatedTo") |> PrefixedName
    /// <summary>
    ///   <para>voagm:releaseDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"release date"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://voag.linkedmodel.org/voag#releaseDate">http://voag.linkedmodel.org/voag#releaseDate</seealso>
    let releaseDate = Prefixed_Name(voagm, "releaseDate") |> PrefixedName
    /// <summary>
    ///   <para>voagm:requires</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"requires"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"requires"</para></remarks>
    /// <seealso href="http://voag.linkedmodel.org/voag#requires">http://voag.linkedmodel.org/voag#requires</seealso>
    let requires = Prefixed_Name(voagm, "requires") |> PrefixedName
    /// <summary>
    ///   <para>voagm:reviewedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"reviewed by"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://voag.linkedmodel.org/voag#reviewedBy">http://voag.linkedmodel.org/voag#reviewedBy</seealso>
    let reviewedBy = Prefixed_Name(voagm, "reviewedBy") |> PrefixedName
    /// <summary>
    ///   <para>voagm:reviews</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"reviews"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://voag.linkedmodel.org/voag#reviews">http://voag.linkedmodel.org/voag#reviews</seealso>
    let reviews = Prefixed_Name(voagm, "reviews") |> PrefixedName
    /// <summary>
    ///   <para>voagm:rights</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"subject"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://voag.linkedmodel.org/voag#rights">http://voag.linkedmodel.org/voag#rights</seealso>
    let rights = Prefixed_Name(voagm, "rights") |> PrefixedName
    /// <summary>
    ///   <para>voagm:source</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"source"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://voag.linkedmodel.org/voag#source">http://voag.linkedmodel.org/voag#source</seealso>
    let source = Prefixed_Name(voagm, "source") |> PrefixedName
    /// <summary>
    ///   <para>voagm:startDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"start date"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://voag.linkedmodel.org/voag#startDate">http://voag.linkedmodel.org/voag#startDate</seealso>
    let startDate = Prefixed_Name(voagm, "startDate") |> PrefixedName
    /// <summary>
    ///   <para>voagm:subject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"subject"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://voag.linkedmodel.org/voag#subject">http://voag.linkedmodel.org/voag#subject</seealso>
    let subject = Prefixed_Name(voagm, "subject") |> PrefixedName
    /// <summary>
    ///   <para>voagm:submittedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"submitted by"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://voag.linkedmodel.org/voag#submittedBy">http://voag.linkedmodel.org/voag#submittedBy</seealso>
    let submittedBy = Prefixed_Name(voagm, "submittedBy") |> PrefixedName
    /// <summary>
    ///   <para>voagm:supercededBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:TransitiveProperty</para>
    ///
    /// labels<para>"superceded by"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://voag.linkedmodel.org/voag#supercededBy">http://voag.linkedmodel.org/voag#supercededBy</seealso>
    let supercededBy = Prefixed_Name(voagm, "supercededBy") |> PrefixedName
    /// <summary>
    ///   <para>voagm:supercedes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:TransitiveProperty</para>
    ///
    /// labels<para>"supercedes"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://voag.linkedmodel.org/voag#supercedes">http://voag.linkedmodel.org/voag#supercedes</seealso>
    let supercedes = Prefixed_Name(voagm, "supercedes") |> PrefixedName
    /// <summary>
    ///   <para>voagm:supervisedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"supervised by"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://voag.linkedmodel.org/voag#supervisedBy">http://voag.linkedmodel.org/voag#supervisedBy</seealso>
    let supervisedBy = Prefixed_Name(voagm, "supervisedBy") |> PrefixedName
    /// <summary>
    ///   <para>voagm:timestamp</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"timestamp"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://voag.linkedmodel.org/voag#timestamp">http://voag.linkedmodel.org/voag#timestamp</seealso>
    let timestamp = Prefixed_Name(voagm, "timestamp") |> PrefixedName
    /// <summary>
    ///   <para>voagm:title</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"title"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://voag.linkedmodel.org/voag#title">http://voag.linkedmodel.org/voag#title</seealso>
    let title = Prefixed_Name(voagm, "title") |> PrefixedName
    /// <summary>
    ///   <para>voagm:url</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"url"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://voag.linkedmodel.org/voag#url">http://voag.linkedmodel.org/voag#url</seealso>
    let url = Prefixed_Name(voagm, "url") |> PrefixedName
    /// <summary>
    ///   <para>voagm:urlForHTML</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"url for HTML"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://voag.linkedmodel.org/voag#urlForHTML">http://voag.linkedmodel.org/voag#urlForHTML</seealso>
    let urlForHTML = Prefixed_Name(voagm, "urlForHTML") |> PrefixedName
    /// <summary>
    ///   <para>voagm:urlOfRDFfile</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"url address of RDF file"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://voag.linkedmodel.org/voag#urlOfRDFfile">http://voag.linkedmodel.org/voag#urlOfRDFfile</seealso>
    let urlOfRDFfile = Prefixed_Name(voagm, "urlOfRDFfile") |> PrefixedName
    /// <summary>
    ///   <para>voagm:urlOfTurtleFile</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"url of turtle file"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://voag.linkedmodel.org/voag#urlOfTurtleFile">http://voag.linkedmodel.org/voag#urlOfTurtleFile</seealso>
    let urlOfTurtleFile = Prefixed_Name(voagm, "urlOfTurtleFile") |> PrefixedName
    /// <summary>
    ///   <para>voagm:usage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"usage"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://voag.linkedmodel.org/voag#usage">http://voag.linkedmodel.org/voag#usage</seealso>
    let usage = Prefixed_Name(voagm, "usage") |> PrefixedName
    /// <summary>
    ///   <para>voagm:useGuidelines</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"use guidelines"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://voag.linkedmodel.org/voag#useGuidelines">http://voag.linkedmodel.org/voag#useGuidelines</seealso>
    let useGuidelines = Prefixed_Name(voagm, "useGuidelines") |> PrefixedName
    /// <summary>
    ///   <para>voagm:usedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"used by"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://voag.linkedmodel.org/voag#usedBy">http://voag.linkedmodel.org/voag#usedBy</seealso>
    let usedBy = Prefixed_Name(voagm, "usedBy") |> PrefixedName
    /// <summary>
    ///   <para>voagm:userID</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"user ID"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://voag.linkedmodel.org/voag#userID">http://voag.linkedmodel.org/voag#userID</seealso>
    let userID = Prefixed_Name(voagm, "userID") |> PrefixedName
    /// <summary>
    ///   <para>voagm:width</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"width"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://voag.linkedmodel.org/voag#width">http://voag.linkedmodel.org/voag#width</seealso>
    let width = Prefixed_Name(voagm, "width") |> PrefixedName
    /// <summary>
    ///   <para>voagm:witnessTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"witness to"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://voag.linkedmodel.org/voag#witnessTo">http://voag.linkedmodel.org/voag#witnessTo</seealso>
    let witnessTo = Prefixed_Name(voagm, "witnessTo") |> PrefixedName
    /// <summary>
    ///   <para>voagm:witnessedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"wintnessed by"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://voag.linkedmodel.org/voag#witnessedBy">http://voag.linkedmodel.org/voag#witnessedBy</seealso>
    let witnessedBy = Prefixed_Name(voagm, "witnessedBy") |> PrefixedName
