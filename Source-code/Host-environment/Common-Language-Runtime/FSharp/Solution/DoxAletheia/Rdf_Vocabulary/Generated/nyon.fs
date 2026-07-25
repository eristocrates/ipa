namespace https.w3id.org.def.nyon.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module nyon =
    let _namespace_iri = Namespace_Iri nyon |> NamespaceIRI
    /// <summary>
    ///   <para>nyon:withOpinion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>represnts the judge opinion on the case either with majority, dissent or concurrence</para>
    /// labels<para>withOpinion</para></remarks>
    /// <seealso href="https://w3id.org/def/nyon#withOpinion">https://w3id.org/def/nyon#withOpinion</seealso>
    let withOpinion = Prefixed_Name(nyon, "withOpinion") |> PrefixedName
    /// <summary>
    ///   <para>nyon:hasBench</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>specifies the bench associated with nyon:Bench of the nyon:CourtCase</para>
    /// labels<para>hasBench</para></remarks>
    /// <seealso href="https://w3id.org/def/nyon#hasBench">https://w3id.org/def/nyon#hasBench</seealso>
    let hasBench = Prefixed_Name(nyon, "hasBench") |> PrefixedName
    /// <summary>
    ///   <para>nyon:Dissent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>judges who do not agree with the majority of the Court</para>
    /// labels<para>Dissent</para></remarks>
    /// <seealso href="https://w3id.org/def/nyon#Dissent">https://w3id.org/def/nyon#Dissent</seealso>
    let Dissent = Prefixed_Name(nyon, "Dissent") |> PrefixedName
    /// <summary>
    ///   <para>nyon:courtName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>courtName</para></remarks>
    /// <seealso href="https://w3id.org/def/nyon#courtName">https://w3id.org/def/nyon#courtName</seealso>
    let courtName = Prefixed_Name(nyon, "courtName") |> PrefixedName
    /// <summary>
    ///   <para>nyon:factValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>factValue</para></remarks>
    /// <seealso href="https://w3id.org/def/nyon#factValue">https://w3id.org/def/nyon#factValue</seealso>
    let factValue = Prefixed_Name(nyon, "factValue") |> PrefixedName

    /// <summary>
    ///   <para>nyon:hasPolicePersonnelName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>represents the name of the police personnel involved in the case</para>
    /// labels<para>hasPolicePersonnelName</para></remarks>
    /// <seealso href="https://w3id.org/def/nyon#hasPolicePersonnelName">https://w3id.org/def/nyon#hasPolicePersonnelName</seealso>
    let hasPolicePersonnelName =
        Prefixed_Name(nyon, "hasPolicePersonnelName") |> PrefixedName

    /// <summary>
    ///   <para>nyon:issueValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>issueValue</para></remarks>
    /// <seealso href="https://w3id.org/def/nyon#issueValue">https://w3id.org/def/nyon#issueValue</seealso>
    let issueValue = Prefixed_Name(nyon, "issueValue") |> PrefixedName
    /// <summary>
    ///   <para>nyon:obiterDictumValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>obiterDictumValue</para></remarks>
    /// <seealso href="https://w3id.org/def/nyon#obiterDictumValue">https://w3id.org/def/nyon#obiterDictumValue</seealso>
    let obiterDictumValue = Prefixed_Name(nyon, "obiterDictumValue") |> PrefixedName
    /// <summary>
    ///   <para>nyon:partyName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>partyName</para></remarks>
    /// <seealso href="https://w3id.org/def/nyon#partyName">https://w3id.org/def/nyon#partyName</seealso>
    let partyName = Prefixed_Name(nyon, "partyName") |> PrefixedName
    /// <summary>
    ///   <para>nyon:Party_Type</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>represents the types of party involved in the case viz. individual, organization, govt. etc.</para>
    /// labels<para>Party Type</para></remarks>
    /// <seealso href="https://w3id.org/def/nyon#Party_Type">https://w3id.org/def/nyon#Party_Type</seealso>
    let Party_Type = Prefixed_Name(nyon, "Party_Type") |> PrefixedName
    /// <summary>
    ///   <para>nyon:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/def/nyon#">https://w3id.org/def/nyon#</seealso>
    let _prefix_iri = Prefixed_Name(nyon, "") |> PrefixedName
    /// <summary>
    ///   <para>nyon:Accussed</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>person against whom an allegation has been made that he has committed an offence, or who is charge with an offence</para>
    /// labels<para>Accused</para></remarks>
    /// <seealso href="https://w3id.org/def/nyon#Accussed">https://w3id.org/def/nyon#Accussed</seealso>
    let Accussed = Prefixed_Name(nyon, "Accussed") |> PrefixedName
    /// <summary>
    ///   <para>nyon:Criminal</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>case is a criminal case</para>
    /// labels<para>Criminal</para></remarks>
    /// <seealso href="https://w3id.org/def/nyon#Criminal">https://w3id.org/def/nyon#Criminal</seealso>
    let Criminal = Prefixed_Name(nyon, "Criminal") |> PrefixedName
    /// <summary>
    ///   <para>nyon:OfDomian</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>specifies the law domain (nyon:CaseDomain) the court case (nyon:CourtCase) belongs to</para>
    /// labels<para>OfDomain</para></remarks>
    /// <seealso href="https://w3id.org/def/nyon#OfDomian">https://w3id.org/def/nyon#OfDomian</seealso>
    let OfDomian = Prefixed_Name(nyon, "OfDomian") |> PrefixedName
    /// <summary>
    ///   <para>nyon:Jurisdiction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>the extent to which a court of law can exercise its authority over any cases filed across a region</para>
    /// labels<para>Jurisdiction</para></remarks>
    /// <seealso href="https://w3id.org/def/nyon#Jurisdiction">https://w3id.org/def/nyon#Jurisdiction</seealso>
    let Jurisdiction = Prefixed_Name(nyon, "Jurisdiction") |> PrefixedName
    /// <summary>
    ///   <para>nyon:Appellant</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>party who makes an appeal</para>
    /// labels<para>Appellant</para></remarks>
    /// <seealso href="https://w3id.org/def/nyon#Appellant">https://w3id.org/def/nyon#Appellant</seealso>
    let Appellant = Prefixed_Name(nyon, "Appellant") |> PrefixedName
    /// <summary>
    ///   <para>nyon:Bench</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Defines the bench of the case.</para>
    /// labels<para>Bench</para></remarks>
    /// <seealso href="https://w3id.org/def/nyon#Bench">https://w3id.org/def/nyon#Bench</seealso>
    let Bench = Prefixed_Name(nyon, "Bench") |> PrefixedName
    /// <summary>
    ///   <para>nyon:COLastName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>COLastName</para></remarks>
    /// <seealso href="https://w3id.org/def/nyon#COLastName">https://w3id.org/def/nyon#COLastName</seealso>
    let COLastName = Prefixed_Name(nyon, "COLastName") |> PrefixedName
    /// <summary>
    ///   <para>nyon:CaseDomain</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>case belongs to specific proceeding like civil or criminal</para>
    /// labels<para>CaseDomain</para></remarks>
    /// <seealso href="https://w3id.org/def/nyon#CaseDomain">https://w3id.org/def/nyon#CaseDomain</seealso>
    let CaseDomain = Prefixed_Name(nyon, "CaseDomain") |> PrefixedName
    /// <summary>
    ///   <para>nyon:CaseType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>classification of types of cases</para>
    /// labels<para>CaseType</para></remarks>
    /// <seealso href="https://w3id.org/def/nyon#CaseType">https://w3id.org/def/nyon#CaseType</seealso>
    let CaseType = Prefixed_Name(nyon, "CaseType") |> PrefixedName
    /// <summary>
    ///   <para>nyon:Larger_Bench</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>a term in judicial system in India in which a case is heard and judged by three or five judges</para>
    /// labels<para>Larger Bench</para></remarks>
    /// <seealso href="https://w3id.org/def/nyon#Larger_Bench">https://w3id.org/def/nyon#Larger_Bench</seealso>
    let Larger_Bench = Prefixed_Name(nyon, "Larger_Bench") |> PrefixedName
    /// <summary>
    ///   <para>nyon:LearnedCounsel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Learned counsel is a term of reference to the lawyers and advocates collectively in litigation</para>
    /// labels<para>LearnedCounsel</para></remarks>
    /// <seealso href="https://w3id.org/def/nyon#LearnedCounsel">https://w3id.org/def/nyon#LearnedCounsel</seealso>
    let LearnedCounsel = Prefixed_Name(nyon, "LearnedCounsel") |> PrefixedName
    /// <summary>
    ///   <para>nyon:ObiterDictum</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>additional obersvations, remarks, and opinions made by the judge that are not the part of the reason for the decision</para>
    /// labels<para>Obiter Dictum</para></remarks>
    /// <seealso href="https://w3id.org/def/nyon#ObiterDictum">https://w3id.org/def/nyon#ObiterDictum</seealso>
    let ObiterDictum = Prefixed_Name(nyon, "ObiterDictum") |> PrefixedName
    /// <summary>
    ///   <para>nyon:Order</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>order given by the court</para>
    /// labels<para>Order</para></remarks>
    /// <seealso href="https://w3id.org/def/nyon#Order">https://w3id.org/def/nyon#Order</seealso>
    let Order = Prefixed_Name(nyon, "Order") |> PrefixedName
    /// <summary>
    ///   <para>nyon:Plaintiff</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>party who brings the suit in the court of law</para>
    /// labels<para>Plaintiff</para></remarks>
    /// <seealso href="https://w3id.org/def/nyon#Plaintiff">https://w3id.org/def/nyon#Plaintiff</seealso>
    let Plaintiff = Prefixed_Name(nyon, "Plaintiff") |> PrefixedName
    /// <summary>
    ///   <para>nyon:Precedent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>all the past cases referred in the current judgment b ythe judge</para>
    /// labels<para>Precedent</para></remarks>
    /// <seealso href="https://w3id.org/def/nyon#Precedent">https://w3id.org/def/nyon#Precedent</seealso>
    let Precedent = Prefixed_Name(nyon, "Precedent") |> PrefixedName
    /// <summary>
    ///   <para>nyon:hasPrecedent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:ReflexiveProperty</para>
    ///   <para>represents past cases referred by the judge in the judgment</para>
    ///   <para>specifies the previous cases of type nyon:CourtCase</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/def/nyon#hasPrecedent">https://w3id.org/def/nyon#hasPrecedent</seealso>
    let hasPrecedent = Prefixed_Name(nyon, "hasPrecedent") |> PrefixedName
    /// <summary>
    ///   <para>nyon:Provision</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>clause or section number or article number applied/used in the case law</para>
    /// labels<para>Provision</para></remarks>
    /// <seealso href="https://w3id.org/def/nyon#Provision">https://w3id.org/def/nyon#Provision</seealso>
    let Provision = Prefixed_Name(nyon, "Provision") |> PrefixedName
    /// <summary>
    ///   <para>nyon:RatioDecidendi</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>the rationale for the decision</para>
    /// labels<para>RatioDecidendi</para></remarks>
    /// <seealso href="https://w3id.org/def/nyon#RatioDecidendi">https://w3id.org/def/nyon#RatioDecidendi</seealso>
    let RatioDecidendi = Prefixed_Name(nyon, "RatioDecidendi") |> PrefixedName
    /// <summary>
    ///   <para>nyon:Single_Judge</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>a case heard and judged by a single judge</para>
    /// labels<para>Single Judge</para></remarks>
    /// <seealso href="https://w3id.org/def/nyon#Single_Judge">https://w3id.org/def/nyon#Single_Judge</seealso>
    let Single_Judge = Prefixed_Name(nyon, "Single_Judge") |> PrefixedName
    /// <summary>
    ///   <para>nyon:Special_Bench</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>means the Bench constituted by or under the orders of the Chief Justice to hear a case or particular class of cases</para>
    /// labels<para>Special Bench</para></remarks>
    /// <seealso href="https://w3id.org/def/nyon#Special_Bench">https://w3id.org/def/nyon#Special_Bench</seealso>
    let Special_Bench = Prefixed_Name(nyon, "Special_Bench") |> PrefixedName
    /// <summary>
    ///   <para>nyon:Statue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>includes the acts and norms of the law</para>
    /// labels<para>Statue</para></remarks>
    /// <seealso href="https://w3id.org/def/nyon#Statue">https://w3id.org/def/nyon#Statue</seealso>
    let Statue = Prefixed_Name(nyon, "Statue") |> PrefixedName
    /// <summary>
    ///   <para>nyon:Tribunal</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>institutions established for discharging judicial or quasi-judicial duties under the Government of India</para>
    /// labels<para>Tribunal</para></remarks>
    /// <seealso href="https://w3id.org/def/nyon#Tribunal">https://w3id.org/def/nyon#Tribunal</seealso>
    let Tribunal = Prefixed_Name(nyon, "Tribunal") |> PrefixedName
    /// <summary>
    ///   <para>nyon:SupremeCourt</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>highest court in the judicial system</para>
    /// labels<para>Supreme Court of India</para></remarks>
    /// <seealso href="https://w3id.org/def/nyon#SupremeCourt">https://w3id.org/def/nyon#SupremeCourt</seealso>
    let SupremeCourt = Prefixed_Name(nyon, "SupremeCourt") |> PrefixedName
    /// <summary>
    ///   <para>nyon:Tribunal_Bench</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Bench deals with tribunals cases</para>
    /// labels<para>Tribunal Bench</para></remarks>
    /// <seealso href="https://w3id.org/def/nyon#Tribunal_Bench">https://w3id.org/def/nyon#Tribunal_Bench</seealso>
    let Tribunal_Bench = Prefixed_Name(nyon, "Tribunal_Bench") |> PrefixedName
    /// <summary>
    ///   <para>nyon:Writ_Jurisdiction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>jurisdiction type is a writ jurisdiction</para>
    /// labels<para>Writ Jurisdiction</para></remarks>
    /// <seealso href="https://w3id.org/def/nyon#Writ_Jurisdiction">https://w3id.org/def/nyon#Writ_Jurisdiction</seealso>
    let Writ_Jurisdiction = Prefixed_Name(nyon, "Writ_Jurisdiction") |> PrefixedName
    /// <summary>
    ///   <para>nyon:equivalentCitation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>equivalent citations provided by the various law reporters.</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/def/nyon#equivalentCitation">https://w3id.org/def/nyon#equivalentCitation</seealso>
    let equivalentCitation = Prefixed_Name(nyon, "equivalentCitation") |> PrefixedName
    /// <summary>
    ///   <para>nyon:neutralCitations</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>represents neutral citations given by the court itself</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/def/nyon#neutralCitations">https://w3id.org/def/nyon#neutralCitations</seealso>
    let neutralCitations = Prefixed_Name(nyon, "neutralCitations") |> PrefixedName
    /// <summary>
    ///   <para>nyon:firstName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>firstName</para></remarks>
    /// <seealso href="https://w3id.org/def/nyon#firstName">https://w3id.org/def/nyon#firstName</seealso>
    let firstName = Prefixed_Name(nyon, "firstName") |> PrefixedName
    /// <summary>
    ///   <para>nyon:lastName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>lastName</para></remarks>
    /// <seealso href="https://w3id.org/def/nyon#lastName">https://w3id.org/def/nyon#lastName</seealso>
    let lastName = Prefixed_Name(nyon, "lastName") |> PrefixedName
    /// <summary>
    ///   <para>nyon:hasCourtLoc</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>specifies the location of the nyon:Court</para>
    /// labels<para>hasCourtLoc</para></remarks>
    /// <seealso href="https://w3id.org/def/nyon#hasCourtLoc">https://w3id.org/def/nyon#hasCourtLoc</seealso>
    let hasCourtLoc = Prefixed_Name(nyon, "hasCourtLoc") |> PrefixedName
    /// <summary>
    ///   <para>nyon:hasEvidenceLoc</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>specifies the evidence location associated with the nyon:Evidence instance for the nyon:CourtCase</para>
    /// labels<para>hasEvidenceLoc</para></remarks>
    /// <seealso href="https://w3id.org/def/nyon#hasEvidenceLoc">https://w3id.org/def/nyon#hasEvidenceLoc</seealso>
    let hasEvidenceLoc = Prefixed_Name(nyon, "hasEvidenceLoc") |> PrefixedName
    /// <summary>
    ///   <para>nyon:hasIssue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>specifies the issue associated with the nyon:Issue instance mentioned in the nyon:CourtCase</para>
    /// labels<para>hasIssue</para></remarks>
    /// <seealso href="https://w3id.org/def/nyon#hasIssue">https://w3id.org/def/nyon#hasIssue</seealso>
    let hasIssue = Prefixed_Name(nyon, "hasIssue") |> PrefixedName
    /// <summary>
    ///   <para>nyon:hasPartyType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>specifies the type of party (nyon:PartyType) involved in nyon:CourtCase</para>
    /// labels<para>hasPartyType</para></remarks>
    /// <seealso href="https://w3id.org/def/nyon#hasPartyType">https://w3id.org/def/nyon#hasPartyType</seealso>
    let hasPartyType = Prefixed_Name(nyon, "hasPartyType") |> PrefixedName
    /// <summary>
    ///   <para>nyon:hasProvision</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>specifies a clause or norm (nyon:Provision) in a legal instrument or a law</para>
    /// labels<para>hasProvision</para></remarks>
    /// <seealso href="https://w3id.org/def/nyon#hasProvision">https://w3id.org/def/nyon#hasProvision</seealso>
    let hasProvision = Prefixed_Name(nyon, "hasProvision") |> PrefixedName
    /// <summary>
    ///   <para>nyon:value</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/def/nyon#value">https://w3id.org/def/nyon#value</seealso>
    let value = Prefixed_Name(nyon, "value") |> PrefixedName
    /// <summary>
    ///   <para>nyon:wFirstName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>wFirstName</para></remarks>
    /// <seealso href="https://w3id.org/def/nyon#wFirstName">https://w3id.org/def/nyon#wFirstName</seealso>
    let wFirstName = Prefixed_Name(nyon, "wFirstName") |> PrefixedName
    /// <summary>
    ///   <para>nyon:wLastName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>wLastName</para></remarks>
    /// <seealso href="https://w3id.org/def/nyon#wLastName">https://w3id.org/def/nyon#wLastName</seealso>
    let wLastName = Prefixed_Name(nyon, "wLastName") |> PrefixedName
    /// <summary>
    ///   <para>nyon:worksIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>specifies the judge (nyon:Judge) working in court (nyon:Court)</para>
    /// labels<para>worksIn</para></remarks>
    /// <seealso href="https://w3id.org/def/nyon#worksIn">https://w3id.org/def/nyon#worksIn</seealso>
    let worksIn = Prefixed_Name(nyon, "worksIn") |> PrefixedName
    /// <summary>
    ///   <para>nyon:citedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:ReflexiveProperty</para>
    ///   <para>specifies the nyon:CourtCase being cited by nyon:CourtCase</para>
    /// labels<para>citedBy</para></remarks>
    /// <seealso href="https://w3id.org/def/nyon#citedBy">https://w3id.org/def/nyon#citedBy</seealso>
    let citedBy = Prefixed_Name(nyon, "citedBy") |> PrefixedName
    /// <summary>
    ///   <para>nyon:hasParty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>specifies the party (nyon:Party) associated with nyon:CourtCase</para>
    /// labels<para>hasParty</para></remarks>
    /// <seealso href="https://w3id.org/def/nyon#hasParty">https://w3id.org/def/nyon#hasParty</seealso>
    let hasParty = Prefixed_Name(nyon, "hasParty") |> PrefixedName
    /// <summary>
    ///   <para>nyon:hasRulingOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>specifies the ruling (previous judgments nyon:CourtCase) of the lower court (nyon:Court)</para>
    /// labels<para>hasRulingOf</para></remarks>
    /// <seealso href="https://w3id.org/def/nyon#hasRulingOf">https://w3id.org/def/nyon#hasRulingOf</seealso>
    let hasRulingOf = Prefixed_Name(nyon, "hasRulingOf") |> PrefixedName
    /// <summary>
    ///   <para>nyon:hasWitness</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>specifies the witness (nyon:Witness) mentioned in nyon:CourtCase</para>
    /// labels<para>hasWitness</para></remarks>
    /// <seealso href="https://w3id.org/def/nyon#hasWitness">https://w3id.org/def/nyon#hasWitness</seealso>
    let hasWitness = Prefixed_Name(nyon, "hasWitness") |> PrefixedName
    /// <summary>
    ///   <para>nyon:Concurrence</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>decisions result when a judge agrees with the ultimate conclusion made by the majority of the court but disagrees on how they reached that decision</para>
    /// labels<para>Concurrence</para></remarks>
    /// <seealso href="https://w3id.org/def/nyon#Concurrence">https://w3id.org/def/nyon#Concurrence</seealso>
    let Concurrence = Prefixed_Name(nyon, "Concurrence") |> PrefixedName

    /// <summary>
    ///   <para>nyon:precendentNotReliedUpon</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>specifies the previous cases (nyon:CourtCase) referred by the judge on which the case decision does not rely on</para>
    /// labels<para>precedentNotReliedUpon</para></remarks>
    /// <seealso href="https://w3id.org/def/nyon#precendentNotReliedUpon">https://w3id.org/def/nyon#precendentNotReliedUpon</seealso>
    let precendentNotReliedUpon =
        Prefixed_Name(nyon, "precendentNotReliedUpon") |> PrefixedName

    /// <summary>
    ///   <para>nyon:District</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>represents district name/location</para>
    /// labels<para>District</para></remarks>
    /// <seealso href="https://w3id.org/def/nyon#District">https://w3id.org/def/nyon#District</seealso>
    let District = Prefixed_Name(nyon, "District") |> PrefixedName

    /// <summary>
    ///   <para>nyon:Advisory_Jurisdiction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>jurisdiction type is a advisory jurisdiction</para>
    /// labels<para>Advisory Jurisdiction</para></remarks>
    /// <seealso href="https://w3id.org/def/nyon#Advisory_Jurisdiction">https://w3id.org/def/nyon#Advisory_Jurisdiction</seealso>
    let Advisory_Jurisdiction =
        Prefixed_Name(nyon, "Advisory_Jurisdiction") |> PrefixedName

    /// <summary>
    ///   <para>nyon:Original_Jurisdiction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>jurisdiction type is a original jurisdiction</para>
    /// labels<para>Original Jurisdiction</para></remarks>
    /// <seealso href="https://w3id.org/def/nyon#Original_Jurisdiction">https://w3id.org/def/nyon#Original_Jurisdiction</seealso>
    let Original_Jurisdiction =
        Prefixed_Name(nyon, "Original_Jurisdiction") |> PrefixedName

    /// <summary>
    ///   <para>nyon:Respondent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>party called upon to respond or answer a petition, a cliam or a appeal</para>
    /// labels<para>Respondent</para></remarks>
    /// <seealso href="https://w3id.org/def/nyon#Respondent">https://w3id.org/def/nyon#Respondent</seealso>
    let Respondent = Prefixed_Name(nyon, "Respondent") |> PrefixedName
    /// <summary>
    ///   <para>nyon:hasYear</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>hasYear</para></remarks>
    /// <seealso href="https://w3id.org/def/nyon#hasYear">https://w3id.org/def/nyon#hasYear</seealso>
    let hasYear = Prefixed_Name(nyon, "hasYear") |> PrefixedName
    /// <summary>
    ///   <para>nyon:argumentSequenceNum</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>argumentSequenceNum</para></remarks>
    /// <seealso href="https://w3id.org/def/nyon#argumentSequenceNum">https://w3id.org/def/nyon#argumentSequenceNum</seealso>
    let argumentSequenceNum = Prefixed_Name(nyon, "argumentSequenceNum") |> PrefixedName
    /// <summary>
    ///   <para>nyon:courtOffName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>courtOffName</para></remarks>
    /// <seealso href="https://w3id.org/def/nyon#courtOffName">https://w3id.org/def/nyon#courtOffName</seealso>
    let courtOffName = Prefixed_Name(nyon, "courtOffName") |> PrefixedName
    /// <summary>
    ///   <para>nyon:dateOfJudgment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>dateOfJudgment</para></remarks>
    /// <seealso href="https://w3id.org/def/nyon#dateOfJudgment">https://w3id.org/def/nyon#dateOfJudgment</seealso>
    let dateOfJudgment = Prefixed_Name(nyon, "dateOfJudgment") |> PrefixedName
    /// <summary>
    ///   <para>nyon:finalDecisionValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>finalDecisionValue</para></remarks>
    /// <seealso href="https://w3id.org/def/nyon#finalDecisionValue">https://w3id.org/def/nyon#finalDecisionValue</seealso>
    let finalDecisionValue = Prefixed_Name(nyon, "finalDecisionValue") |> PrefixedName
    /// <summary>
    ///   <para>nyon:hasCaseID</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Case has a unique ID</para>
    /// labels<para>caseID</para></remarks>
    /// <seealso href="https://w3id.org/def/nyon#hasCaseID">https://w3id.org/def/nyon#hasCaseID</seealso>
    let hasCaseID = Prefixed_Name(nyon, "hasCaseID") |> PrefixedName
    /// <summary>
    ///   <para>nyon:locationName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>locationName</para></remarks>
    /// <seealso href="https://w3id.org/def/nyon#locationName">https://w3id.org/def/nyon#locationName</seealso>
    let locationName = Prefixed_Name(nyon, "locationName") |> PrefixedName

    /// <summary>
    ///   <para>nyon:obiterDictumSequenceNum</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>obiterDictumSequenceNum</para></remarks>
    /// <seealso href="https://w3id.org/def/nyon#obiterDictumSequenceNum">https://w3id.org/def/nyon#obiterDictumSequenceNum</seealso>
    let obiterDictumSequenceNum =
        Prefixed_Name(nyon, "obiterDictumSequenceNum") |> PrefixedName

    /// <summary>
    ///   <para>nyon:witnessStatement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>witnessStatement</para></remarks>
    /// <seealso href="https://w3id.org/def/nyon#witnessStatement">https://w3id.org/def/nyon#witnessStatement</seealso>
    let witnessStatement = Prefixed_Name(nyon, "witnessStatement") |> PrefixedName
    /// <summary>
    ///   <para>nyon:wordPhraseValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>wordPhraseValue</para></remarks>
    /// <seealso href="https://w3id.org/def/nyon#wordPhraseValue">https://w3id.org/def/nyon#wordPhraseValue</seealso>
    let wordPhraseValue = Prefixed_Name(nyon, "wordPhraseValue") |> PrefixedName
    /// <summary>
    ///   <para>nyon:Court</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>courts in the judicial system</para>
    /// labels<para>Court</para></remarks>
    /// <seealso href="https://w3id.org/def/nyon#Court">https://w3id.org/def/nyon#Court</seealso>
    let Court = Prefixed_Name(nyon, "Court") |> PrefixedName
    /// <summary>
    ///   <para>nyon:DateOfJudgment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>signifies the final date on which the judgment is given by the court of law</para>
    /// labels<para>DateofJudgment</para></remarks>
    /// <seealso href="https://w3id.org/def/nyon#DateOfJudgment">https://w3id.org/def/nyon#DateOfJudgment</seealso>
    let DateOfJudgment = Prefixed_Name(nyon, "DateOfJudgment") |> PrefixedName
    /// <summary>
    ///   <para>nyon:Decree</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>formal order issued by the judges</para>
    /// labels<para>Decree</para></remarks>
    /// <seealso href="https://w3id.org/def/nyon#Decree">https://w3id.org/def/nyon#Decree</seealso>
    let Decree = Prefixed_Name(nyon, "Decree") |> PrefixedName
    /// <summary>
    ///   <para>nyon:Defendant</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>a person sued in the court of law</para>
    /// labels<para>Defendant</para></remarks>
    /// <seealso href="https://w3id.org/def/nyon#Defendant">https://w3id.org/def/nyon#Defendant</seealso>
    let Defendant = Prefixed_Name(nyon, "Defendant") |> PrefixedName
    /// <summary>
    ///   <para>nyon:Division_Bench</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>a term in judicial system in India in which a case is heard and judged by at least 2 judges</para>
    /// labels<para>Division Bench</para></remarks>
    /// <seealso href="https://w3id.org/def/nyon#Division_Bench">https://w3id.org/def/nyon#Division_Bench</seealso>
    let Division_Bench = Prefixed_Name(nyon, "Division_Bench") |> PrefixedName
    /// <summary>
    ///   <para>nyon:Fact</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>represents factual statements in the case law</para>
    /// labels<para>Fact</para></remarks>
    /// <seealso href="https://w3id.org/def/nyon#Fact">https://w3id.org/def/nyon#Fact</seealso>
    let Fact = Prefixed_Name(nyon, "Fact") |> PrefixedName
    /// <summary>
    ///   <para>nyon:Judgement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Judgement given by the judge </para>
    /// labels<para>Judgement</para></remarks>
    /// <seealso href="https://w3id.org/def/nyon#Judgement">https://w3id.org/def/nyon#Judgement</seealso>
    let Judgement = Prefixed_Name(nyon, "Judgement") |> PrefixedName
    /// <summary>
    ///   <para>nyon:Witness</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>witness involved/presented in the case</para>
    /// labels<para>Witness</para></remarks>
    /// <seealso href="https://w3id.org/def/nyon#Witness">https://w3id.org/def/nyon#Witness</seealso>
    let Witness = Prefixed_Name(nyon, "Witness") |> PrefixedName
    /// <summary>
    ///   <para>nyon:WordAndPhrase</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>words or phrases exctracted from the case to make the search better for the cases or find relevent cases or judgment</para>
    /// labels<para>WordsAndPhrases</para></remarks>
    /// <seealso href="https://w3id.org/def/nyon#WordAndPhrase">https://w3id.org/def/nyon#WordAndPhrase</seealso>
    let WordAndPhrase = Prefixed_Name(nyon, "WordAndPhrase") |> PrefixedName
    /// <summary>
    ///   <para>nyon:hasFact</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>specifies the fact associated with nyon:Fact belonging to a specific nyon:CourtCase</para>
    /// labels<para>hasFact</para></remarks>
    /// <seealso href="https://w3id.org/def/nyon#hasFact">https://w3id.org/def/nyon#hasFact</seealso>
    let hasFact = Prefixed_Name(nyon, "hasFact") |> PrefixedName
    /// <summary>
    ///   <para>nyon:hasObiterDictum</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>specifies the obiter dicta associated with nyon:ObiterDictum mentioned in nyon:CourtCase</para>
    /// labels<para>hasObiterDictum</para></remarks>
    /// <seealso href="https://w3id.org/def/nyon#hasObiterDictum">https://w3id.org/def/nyon#hasObiterDictum</seealso>
    let hasObiterDictum = Prefixed_Name(nyon, "hasObiterDictum") |> PrefixedName
    /// <summary>
    ///   <para>nyon:respondentArgument</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>specifies the argument made by the respondent (nyon:Respondent) of nyon:CourtCase</para>
    /// labels<para>respondentArgument</para></remarks>
    /// <seealso href="https://w3id.org/def/nyon#respondentArgument">https://w3id.org/def/nyon#respondentArgument</seealso>
    let respondentArgument = Prefixed_Name(nyon, "respondentArgument") |> PrefixedName

    /// <summary>
    ///   <para>nyon:Judicial_Magistrate_Court(Second_Class)</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>lowest court after Judicial Magistrate Court (First Class) at distrcit level for criminal cases</para>
    /// labels<para>Judicial Magistrate Court (Second Class)</para></remarks>
    /// <seealso href="https://w3id.org/def/nyon#Judicial_Magistrate_Court(Second_Class)">https://w3id.org/def/nyon#Judicial_Magistrate_Court(Second_Class)</seealso>
    let ``Judicial_Magistrate_Court(Second_Class)`` =
        Prefixed_Name(nyon, "Judicial_Magistrate_Court(Second_Class)") |> PrefixedName

    /// <summary>
    ///   <para>nyon:Author</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Author (Judge) who is responsible for a creation of case document</para>
    /// labels<para>Author</para></remarks>
    /// <seealso href="https://w3id.org/def/nyon#Author">https://w3id.org/def/nyon#Author</seealso>
    let Author = Prefixed_Name(nyon, "Author") |> PrefixedName
    /// <summary>
    ///   <para>nyon:COFirstName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>COFirstName</para></remarks>
    /// <seealso href="https://w3id.org/def/nyon#COFirstName">https://w3id.org/def/nyon#COFirstName</seealso>
    let COFirstName = Prefixed_Name(nyon, "COFirstName") |> PrefixedName
    /// <summary>
    ///   <para>nyon:Evidence</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>evidences presented in front of the court in the case</para>
    /// labels<para>Evidence</para></remarks>
    /// <seealso href="https://w3id.org/def/nyon#Evidence">https://w3id.org/def/nyon#Evidence</seealso>
    let Evidence = Prefixed_Name(nyon, "Evidence") |> PrefixedName
    /// <summary>
    ///   <para>nyon:High_Court</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>court at the state level</para>
    /// labels<para>High Court</para></remarks>
    /// <seealso href="https://w3id.org/def/nyon#High_Court">https://w3id.org/def/nyon#High_Court</seealso>
    let High_Court = Prefixed_Name(nyon, "High_Court") |> PrefixedName
    /// <summary>
    ///   <para>nyon:hasStatue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>specifies the statute (nyon:Statute) mentioned in nyon:CourtCase</para>
    /// labels<para>hasStatue</para></remarks>
    /// <seealso href="https://w3id.org/def/nyon#hasStatue">https://w3id.org/def/nyon#hasStatue</seealso>
    let hasStatue = Prefixed_Name(nyon, "hasStatue") |> PrefixedName
    /// <summary>
    ///   <para>nyon:precedentOverruled</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>specifies the past cases (nyon:CourtCase) overruled by the judge in the current case</para>
    /// labels<para>precedentOverruled</para></remarks>
    /// <seealso href="https://w3id.org/def/nyon#precedentOverruled">https://w3id.org/def/nyon#precedentOverruled</seealso>
    let precedentOverruled = Prefixed_Name(nyon, "precedentOverruled") |> PrefixedName
    /// <summary>
    ///   <para>nyon:Country</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A country</para>
    /// labels<para>Country</para></remarks>
    /// <seealso href="https://w3id.org/def/nyon#Country">https://w3id.org/def/nyon#Country</seealso>
    let Country = Prefixed_Name(nyon, "Country") |> PrefixedName
    /// <summary>
    ///   <para>nyon:Taluka</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>represents taluka name/location</para>
    /// labels<para>Taluka</para></remarks>
    /// <seealso href="https://w3id.org/def/nyon#Taluka">https://w3id.org/def/nyon#Taluka</seealso>
    let Taluka = Prefixed_Name(nyon, "Taluka") |> PrefixedName
    /// <summary>
    ///   <para>nyon:withDissent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>specifies the judge (nyon:Judge) gives the opinion in dissent (nyon:Dissent) of the court</para>
    /// labels<para>withDissent</para></remarks>
    /// <seealso href="https://w3id.org/def/nyon#withDissent">https://w3id.org/def/nyon#withDissent</seealso>
    let withDissent = Prefixed_Name(nyon, "withDissent") |> PrefixedName

    /// <summary>
    ///   <para>nyon:Chief_Meterpolitan_Court</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>lower court at metropolitan level after Sessions Court for criminal cases</para>
    /// labels<para>Chief Meterpolitan Court</para></remarks>
    /// <seealso href="https://w3id.org/def/nyon#Chief_Meterpolitan_Court">https://w3id.org/def/nyon#Chief_Meterpolitan_Court</seealso>
    let Chief_Meterpolitan_Court =
        Prefixed_Name(nyon, "Chief_Meterpolitan_Court") |> PrefixedName

    /// <summary>
    ///   <para>nyon:Metropolitan_Magistrate_Courts</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>lowest court after Chief Metropolitan Court at metropolitan level for criminal cases</para>
    /// labels<para>Metropolitan Magistrate Court</para></remarks>
    /// <seealso href="https://w3id.org/def/nyon#Metropolitan_Magistrate_Courts">https://w3id.org/def/nyon#Metropolitan_Magistrate_Courts</seealso>
    let Metropolitan_Magistrate_Courts =
        Prefixed_Name(nyon, "Metropolitan_Magistrate_Courts") |> PrefixedName

    /// <summary>
    ///   <para>nyon:Session_Court</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>lower court at both distrcit and metropolitan level after High Courts specific for criminal cases</para>
    /// labels<para>Sessions Court</para></remarks>
    /// <seealso href="https://w3id.org/def/nyon#Session_Court">https://w3id.org/def/nyon#Session_Court</seealso>
    let Session_Court = Prefixed_Name(nyon, "Session_Court") |> PrefixedName

    /// <summary>
    ///   <para>nyon:Judicial_Magistrate_Court(First_Class)</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>second lower court at distrcit level after districit level Session Court for criminal cases</para>
    /// labels<para>Judicial Magistrate Court (First Class)</para></remarks>
    /// <seealso href="https://w3id.org/def/nyon#Judicial_Magistrate_Court(First_Class)">https://w3id.org/def/nyon#Judicial_Magistrate_Court(First_Class)</seealso>
    let ``Judicial_Magistrate_Court(First_Class)`` =
        Prefixed_Name(nyon, "Judicial_Magistrate_Court(First_Class)") |> PrefixedName

    /// <summary>
    ///   <para>nyon:hasDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>hasDate</para></remarks>
    /// <seealso href="https://w3id.org/def/nyon#hasDate">https://w3id.org/def/nyon#hasDate</seealso>
    let hasDate = Prefixed_Name(nyon, "hasDate") |> PrefixedName
    /// <summary>
    ///   <para>nyon:hasMonth</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>hasMonth</para></remarks>
    /// <seealso href="https://w3id.org/def/nyon#hasMonth">https://w3id.org/def/nyon#hasMonth</seealso>
    let hasMonth = Prefixed_Name(nyon, "hasMonth") |> PrefixedName
    /// <summary>
    ///   <para>nyon:argumentValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>argumentValue</para></remarks>
    /// <seealso href="https://w3id.org/def/nyon#argumentValue">https://w3id.org/def/nyon#argumentValue</seealso>
    let argumentValue = Prefixed_Name(nyon, "argumentValue") |> PrefixedName
    /// <summary>
    ///   <para>nyon:catchwordValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>catchwordValue</para></remarks>
    /// <seealso href="https://w3id.org/def/nyon#catchwordValue">https://w3id.org/def/nyon#catchwordValue</seealso>
    let catchwordValue = Prefixed_Name(nyon, "catchwordValue") |> PrefixedName
    /// <summary>
    ///   <para>nyon:evidenceLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>evidenceLocation</para></remarks>
    /// <seealso href="https://w3id.org/def/nyon#evidenceLocation">https://w3id.org/def/nyon#evidenceLocation</seealso>
    let evidenceLocation = Prefixed_Name(nyon, "evidenceLocation") |> PrefixedName
    /// <summary>
    ///   <para>nyon:factSequenceNum</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>factSequenceNum</para></remarks>
    /// <seealso href="https://w3id.org/def/nyon#factSequenceNum">https://w3id.org/def/nyon#factSequenceNum</seealso>
    let factSequenceNum = Prefixed_Name(nyon, "factSequenceNum") |> PrefixedName
    /// <summary>
    ///   <para>nyon:hasCaseName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>represents the name of a case usually contains the name of both the parties</para>
    /// labels<para>caseName</para></remarks>
    /// <seealso href="https://w3id.org/def/nyon#hasCaseName">https://w3id.org/def/nyon#hasCaseName</seealso>
    let hasCaseName = Prefixed_Name(nyon, "hasCaseName") |> PrefixedName
    /// <summary>
    ///   <para>nyon:hasDesignation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>hasDesignation</para></remarks>
    /// <seealso href="https://w3id.org/def/nyon#hasDesignation">https://w3id.org/def/nyon#hasDesignation</seealso>
    let hasDesignation = Prefixed_Name(nyon, "hasDesignation") |> PrefixedName

    /// <summary>
    ///   <para>nyon:ratioDecidendiSequenceNum</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>ratioDecidendiSequenceNum</para></remarks>
    /// <seealso href="https://w3id.org/def/nyon#ratioDecidendiSequenceNum">https://w3id.org/def/nyon#ratioDecidendiSequenceNum</seealso>
    let ratioDecidendiSequenceNum =
        Prefixed_Name(nyon, "ratioDecidendiSequenceNum") |> PrefixedName

    /// <summary>
    ///   <para>nyon:ratioDecidendiValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>ratioDecidendiValue</para></remarks>
    /// <seealso href="https://w3id.org/def/nyon#ratioDecidendiValue">https://w3id.org/def/nyon#ratioDecidendiValue</seealso>
    let ratioDecidendiValue = Prefixed_Name(nyon, "ratioDecidendiValue") |> PrefixedName
    /// <summary>
    ///   <para>nyon:Court_Official</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>legal system related people involved in a case</para>
    /// labels<para>CourtOfficial</para></remarks>
    /// <seealso href="https://w3id.org/def/nyon#Court_Official">https://w3id.org/def/nyon#Court_Official</seealso>
    let Court_Official = Prefixed_Name(nyon, "Court_Official") |> PrefixedName
    /// <summary>
    ///   <para>nyon:CatchWord</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Descriptive words or phrases used to categorise the subject matter of a case along with some keywords representing the issues in the case</para>
    /// labels<para>Catchword</para></remarks>
    /// <seealso href="https://w3id.org/def/nyon#CatchWord">https://w3id.org/def/nyon#CatchWord</seealso>
    let CatchWord = Prefixed_Name(nyon, "CatchWord") |> PrefixedName
    /// <summary>
    ///   <para>nyon:Courts_for_Criminal</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>courts for crimnial cases</para>
    /// labels<para>Criminal Court</para></remarks>
    /// <seealso href="https://w3id.org/def/nyon#Courts_for_Criminal">https://w3id.org/def/nyon#Courts_for_Criminal</seealso>
    let Courts_for_Criminal = Prefixed_Name(nyon, "Courts_for_Criminal") |> PrefixedName
    /// <summary>
    ///   <para>nyon:Civil</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>case is a civil case</para>
    /// labels<para>Civil</para></remarks>
    /// <seealso href="https://w3id.org/def/nyon#Civil">https://w3id.org/def/nyon#Civil</seealso>
    let Civil = Prefixed_Name(nyon, "Civil") |> PrefixedName
    /// <summary>
    ///   <para>nyon:Opinion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>judge opinion with respect to case or judgment</para>
    /// labels<para>Opinion</para></remarks>
    /// <seealso href="https://w3id.org/def/nyon#Opinion">https://w3id.org/def/nyon#Opinion</seealso>
    let Opinion = Prefixed_Name(nyon, "Opinion") |> PrefixedName
    /// <summary>
    ///   <para>nyon:CourtDecision</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>CourtDecision</para></remarks>
    /// <seealso href="https://w3id.org/def/nyon#CourtDecision">https://w3id.org/def/nyon#CourtDecision</seealso>
    let CourtDecision = Prefixed_Name(nyon, "CourtDecision") |> PrefixedName
    /// <summary>
    ///   <para>nyon:hasJurisdiction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>specifies the jurisdiction (nyon:Jurisdiction) for nyon:Court</para>
    /// labels<para>hasJurisdiction</para></remarks>
    /// <seealso href="https://w3id.org/def/nyon#hasJurisdiction">https://w3id.org/def/nyon#hasJurisdiction</seealso>
    let hasJurisdiction = Prefixed_Name(nyon, "hasJurisdiction") |> PrefixedName

    /// <summary>
    ///   <para>nyon:Courts_of_Smaller_Causes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>lowest court after City Civil Courts at metropolitan level for civil cases</para>
    /// labels<para>Court of Smaller Cause</para></remarks>
    /// <seealso href="https://w3id.org/def/nyon#Courts_of_Smaller_Causes">https://w3id.org/def/nyon#Courts_of_Smaller_Causes</seealso>
    let Courts_of_Smaller_Causes =
        Prefixed_Name(nyon, "Courts_of_Smaller_Causes") |> PrefixedName

    /// <summary>
    ///   <para>nyon:precedentReliedUpon</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>specifies the past cases (nyon:CourtCase) referred by the judge on which the current judgment relies on</para>
    /// labels<para>precedentReliedUpon</para></remarks>
    /// <seealso href="https://w3id.org/def/nyon#precedentReliedUpon">https://w3id.org/def/nyon#precedentReliedUpon</seealso>
    let precedentReliedUpon = Prefixed_Name(nyon, "precedentReliedUpon") |> PrefixedName
    /// <summary>
    ///   <para>nyon:State</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>represents state name/location</para>
    /// labels<para>State</para></remarks>
    /// <seealso href="https://w3id.org/def/nyon#State">https://w3id.org/def/nyon#State</seealso>
    let State = Prefixed_Name(nyon, "State") |> PrefixedName

    /// <summary>
    ///   <para>nyon:Appellant_Jurisdiction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>jurisdiction type is a appellant jurisdiction</para>
    /// labels<para>Appellant Jurisdiction</para></remarks>
    /// <seealso href="https://w3id.org/def/nyon#Appellant_Jurisdiction">https://w3id.org/def/nyon#Appellant_Jurisdiction</seealso>
    let Appellant_Jurisdiction =
        Prefixed_Name(nyon, "Appellant_Jurisdiction") |> PrefixedName

    /// <summary>
    ///   <para>nyon:withMajority</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>specifies the judge (nyon:Judge) gives the opinion in majority (nyon:Majority) of the court</para>
    /// labels<para>withMajority</para></remarks>
    /// <seealso href="https://w3id.org/def/nyon#withMajority">https://w3id.org/def/nyon#withMajority</seealso>
    let withMajority = Prefixed_Name(nyon, "withMajority") |> PrefixedName
    /// <summary>
    ///   <para>nyon:appellantArgument</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>specifies the argument made by the appellant (nyon:Appellant) of nyon:CourtCase</para>
    /// labels<para>appellantArgument</para></remarks>
    /// <seealso href="https://w3id.org/def/nyon#appellantArgument">https://w3id.org/def/nyon#appellantArgument</seealso>
    let appellantArgument = Prefixed_Name(nyon, "appellantArgument") |> PrefixedName
    /// <summary>
    ///   <para>nyon:Investigator</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A police officer is a warranted law employee of a police force</para>
    /// labels<para>PolicePersonnel</para></remarks>
    /// <seealso href="https://w3id.org/def/nyon#Investigator">https://w3id.org/def/nyon#Investigator</seealso>
    let Investigator = Prefixed_Name(nyon, "Investigator") |> PrefixedName
    /// <summary>
    ///   <para>nyon:issueSequenceNum</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>issueSequenceNum</para></remarks>
    /// <seealso href="https://w3id.org/def/nyon#issueSequenceNum">https://w3id.org/def/nyon#issueSequenceNum</seealso>
    let issueSequenceNum = Prefixed_Name(nyon, "issueSequenceNum") |> PrefixedName
    /// <summary>
    ///   <para>nyon:witnessName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>witnessName</para></remarks>
    /// <seealso href="https://w3id.org/def/nyon#witnessName">https://w3id.org/def/nyon#witnessName</seealso>
    let witnessName = Prefixed_Name(nyon, "witnessName") |> PrefixedName
    /// <summary>
    ///   <para>nyon:Issue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>issues in the case arised by the party</para>
    /// labels<para>Issue</para></remarks>
    /// <seealso href="https://w3id.org/def/nyon#Issue">https://w3id.org/def/nyon#Issue</seealso>
    let Issue = Prefixed_Name(nyon, "Issue") |> PrefixedName
    /// <summary>
    ///   <para>nyon:Courts_for_Civil</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>court for civil cases</para>
    /// labels<para>Civil Court</para></remarks>
    /// <seealso href="https://w3id.org/def/nyon#Courts_for_Civil">https://w3id.org/def/nyon#Courts_for_Civil</seealso>
    let Courts_for_Civil = Prefixed_Name(nyon, "Courts_for_Civil") |> PrefixedName
    /// <summary>
    ///   <para>nyon:Lawyer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Lawyer is a term of reference to the attroneys and advocates collectively in litigation</para>
    /// labels<para>Lawyer</para></remarks>
    /// <seealso href="https://w3id.org/def/nyon#Lawyer">https://w3id.org/def/nyon#Lawyer</seealso>
    let Lawyer = Prefixed_Name(nyon, "Lawyer") |> PrefixedName

    /// <summary>
    ///   <para>nyon:Metropolitian_Courts</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>court for population more than 10 lakh city </para>
    /// labels<para>Metropolitan Court</para></remarks>
    /// <seealso href="https://w3id.org/def/nyon#Metropolitian_Courts">https://w3id.org/def/nyon#Metropolitian_Courts</seealso>
    let Metropolitian_Courts =
        Prefixed_Name(nyon, "Metropolitian_Courts") |> PrefixedName

    /// <summary>
    ///   <para>nyon:Location</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>represents the location of the courts, etc and also used for evidence locations</para>
    /// labels<para>Location</para></remarks>
    /// <seealso href="https://w3id.org/def/nyon#Location">https://w3id.org/def/nyon#Location</seealso>
    let Location = Prefixed_Name(nyon, "Location") |> PrefixedName
    /// <summary>
    ///   <para>nyon:Party</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>party or people involved in the case</para>
    /// labels<para>Party</para></remarks>
    /// <seealso href="https://w3id.org/def/nyon#Party">https://w3id.org/def/nyon#Party</seealso>
    let Party = Prefixed_Name(nyon, "Party") |> PrefixedName
    /// <summary>
    ///   <para>nyon:cites</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ReflexiveProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>specifies the nyon:CourtCase is citing another nyon:CourtCase</para>
    /// labels<para>cites</para></remarks>
    /// <seealso href="https://w3id.org/def/nyon#cites">https://w3id.org/def/nyon#cites</seealso>
    let cites = Prefixed_Name(nyon, "cites") |> PrefixedName
    /// <summary>
    ///   <para>nyon:hasAuthor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>specifies an author (nyon:Author) (any judge (nyon:Judge) from the bench) of the nyon:CourtCase</para>
    /// labels<para>hasAuthor</para></remarks>
    /// <seealso href="https://w3id.org/def/nyon#hasAuthor">https://w3id.org/def/nyon#hasAuthor</seealso>
    let hasAuthor = Prefixed_Name(nyon, "hasAuthor") |> PrefixedName
    /// <summary>
    ///   <para>nyon:hasCourtOfficial</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>specifies the court official represented with nyon:CourtOfficial connected to the nyon:CourtCase</para>
    /// labels<para>hasCourtOfficial</para></remarks>
    /// <seealso href="https://w3id.org/def/nyon#hasCourtOfficial">https://w3id.org/def/nyon#hasCourtOfficial</seealso>
    let hasCourtOfficial = Prefixed_Name(nyon, "hasCourtOfficial") |> PrefixedName
    /// <summary>
    ///   <para>nyon:hasDateOfJudgment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>specifies the date of the judgment of the nyon:CourtCase</para>
    /// labels<para>hasDateOfJudgment</para></remarks>
    /// <seealso href="https://w3id.org/def/nyon#hasDateOfJudgment">https://w3id.org/def/nyon#hasDateOfJudgment</seealso>
    let hasDateOfJudgment = Prefixed_Name(nyon, "hasDateOfJudgment") |> PrefixedName
    /// <summary>
    ///   <para>nyon:hasEvidence</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>specifies the evidence associated with the nyon:Evidence instance for the nyon:CourtCase</para>
    /// labels<para>hasEvidence</para></remarks>
    /// <seealso href="https://w3id.org/def/nyon#hasEvidence">https://w3id.org/def/nyon#hasEvidence</seealso>
    let hasEvidence = Prefixed_Name(nyon, "hasEvidence") |> PrefixedName
    /// <summary>
    ///   <para>nyon:hasFinalDecision</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>specifies the final verdict associated with the nyon:CourtCase</para>
    /// labels<para>hasFinalDecision</para></remarks>
    /// <seealso href="https://w3id.org/def/nyon#hasFinalDecision">https://w3id.org/def/nyon#hasFinalDecision</seealso>
    let hasFinalDecision = Prefixed_Name(nyon, "hasFinalDecision") |> PrefixedName
    /// <summary>
    ///   <para>nyon:hasJudgmentType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>specifies the type of judgment (nyon:CaseType) for nyon:CourtCase</para>
    /// labels<para>hasJudgmentType</para></remarks>
    /// <seealso href="https://w3id.org/def/nyon#hasJudgmentType">https://w3id.org/def/nyon#hasJudgmentType</seealso>
    let hasJudgmentType = Prefixed_Name(nyon, "hasJudgmentType") |> PrefixedName
    /// <summary>
    ///   <para>nyon:hasPolicePersonnel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>specifies the police officer (nyon:PolicePersonnel) doing mentioned in nyon:CourtCase</para>
    /// labels<para>hasPolicePersonnel</para></remarks>
    /// <seealso href="https://w3id.org/def/nyon#hasPolicePersonnel">https://w3id.org/def/nyon#hasPolicePersonnel</seealso>
    let hasPolicePersonnel = Prefixed_Name(nyon, "hasPolicePersonnel") |> PrefixedName
    /// <summary>
    ///   <para>nyon:hasRatioDecidendi</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>specifies the judges ratio of decision (nyon:RatioDecidendi) for nyon:CourtCase</para>
    /// labels<para>hasRatioDecidendi</para></remarks>
    /// <seealso href="https://w3id.org/def/nyon#hasRatioDecidendi">https://w3id.org/def/nyon#hasRatioDecidendi</seealso>
    let hasRatioDecidendi = Prefixed_Name(nyon, "hasRatioDecidendi") |> PrefixedName
    /// <summary>
    ///   <para>nyon:hasWordPhrase</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>specifies the phrases and words (specially nyon:Issue) mentioned in nyon:CourtCase</para>
    /// labels<para>hasWordPhrase</para></remarks>
    /// <seealso href="https://w3id.org/def/nyon#hasWordPhrase">https://w3id.org/def/nyon#hasWordPhrase</seealso>
    let hasWordPhrase = Prefixed_Name(nyon, "hasWordPhrase") |> PrefixedName
    /// <summary>
    ///   <para>nyon:hasWords</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>signifies the domain words, facts and issue related words in the case</para>
    /// labels<para>hasWords</para></remarks>
    /// <seealso href="https://w3id.org/def/nyon#hasWords">https://w3id.org/def/nyon#hasWords</seealso>
    let hasWords = Prefixed_Name(nyon, "hasWords") |> PrefixedName
    /// <summary>
    ///   <para>nyon:Majority</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Majority decisions are the ones where a majority of the judges agree</para>
    /// labels<para>Majority</para></remarks>
    /// <seealso href="https://w3id.org/def/nyon#Majority">https://w3id.org/def/nyon#Majority</seealso>
    let Majority = Prefixed_Name(nyon, "Majority") |> PrefixedName
    /// <summary>
    ///   <para>nyon:hasJudge</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>specifies the judicial body (nyon:Judge) of nyon:CourtCase</para>
    /// labels<para>hasJudge</para></remarks>
    /// <seealso href="https://w3id.org/def/nyon#hasJudge">https://w3id.org/def/nyon#hasJudge</seealso>
    let hasJudge = Prefixed_Name(nyon, "hasJudge") |> PrefixedName
    /// <summary>
    ///   <para>nyon:CourtCase</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>represents the court judgment given by a court of law</para>
    /// labels<para>CourtCase</para></remarks>
    /// <seealso href="https://w3id.org/def/nyon#CourtCase">https://w3id.org/def/nyon#CourtCase</seealso>
    let CourtCase = Prefixed_Name(nyon, "CourtCase") |> PrefixedName
    /// <summary>
    ///   <para>nyon:Petitioner</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>one who makes the petition</para>
    /// labels<para>Petitioner</para></remarks>
    /// <seealso href="https://w3id.org/def/nyon#Petitioner">https://w3id.org/def/nyon#Petitioner</seealso>
    let Petitioner = Prefixed_Name(nyon, "Petitioner") |> PrefixedName
    /// <summary>
    ///   <para>nyon:makeArgument</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>specifies the arguments done in nyon:CourtCase by some party (nyon:Party)</para>
    /// labels<para>makeArgument</para></remarks>
    /// <seealso href="https://w3id.org/def/nyon#makeArgument">https://w3id.org/def/nyon#makeArgument</seealso>
    let makeArgument = Prefixed_Name(nyon, "makeArgument") |> PrefixedName
    /// <summary>
    ///   <para>nyon:Argument</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Argument made by any of the party</para>
    /// labels<para>Argument</para></remarks>
    /// <seealso href="https://w3id.org/def/nyon#Argument">https://w3id.org/def/nyon#Argument</seealso>
    let Argument = Prefixed_Name(nyon, "Argument") |> PrefixedName
    /// <summary>
    ///   <para>nyon:City_Civil_Courts</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>lower court at metropolitan level after High Courts for civil cases</para>
    /// labels<para>City Civil Court</para></remarks>
    /// <seealso href="https://w3id.org/def/nyon#City_Civil_Courts">https://w3id.org/def/nyon#City_Civil_Courts</seealso>
    let City_Civil_Courts = Prefixed_Name(nyon, "City_Civil_Courts") |> PrefixedName
    /// <summary>
    ///   <para>nyon:District_Court</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>a term in judicial system in India in which a case is heard and judged by at least 2 judges</para>
    /// labels<para>District Court</para></remarks>
    /// <seealso href="https://w3id.org/def/nyon#District_Court">https://w3id.org/def/nyon#District_Court</seealso>
    let District_Court = Prefixed_Name(nyon, "District_Court") |> PrefixedName
    /// <summary>
    ///   <para>nyon:Munsif_Court</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>lowest court in heirarchy for civil ases at district level after Principal Junior Civil Court</para>
    /// labels<para>Munsif Court</para></remarks>
    /// <seealso href="https://w3id.org/def/nyon#Munsif_Court">https://w3id.org/def/nyon#Munsif_Court</seealso>
    let Munsif_Court = Prefixed_Name(nyon, "Munsif_Court") |> PrefixedName

    /// <summary>
    ///   <para>nyon:Principal_Junior_Civil_Court</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>third lower court in hierarchy at district level for civil cases</para>
    /// labels<para>Principal Junior Civil Court</para></remarks>
    /// <seealso href="https://w3id.org/def/nyon#Principal_Junior_Civil_Court">https://w3id.org/def/nyon#Principal_Junior_Civil_Court</seealso>
    let Principal_Junior_Civil_Court =
        Prefixed_Name(nyon, "Principal_Junior_Civil_Court") |> PrefixedName

    /// <summary>
    ///   <para>nyon:Sub_Court</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>second lower court in hierarchy at District level for civil cases</para>
    /// labels<para>Sub Court</para></remarks>
    /// <seealso href="https://w3id.org/def/nyon#Sub_Court">https://w3id.org/def/nyon#Sub_Court</seealso>
    let Sub_Court = Prefixed_Name(nyon, "Sub_Court") |> PrefixedName
    /// <summary>
    ///   <para>nyon:Review_Jurisdiction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>jurisdiction type is a review jurisdiction</para>
    /// labels<para>Review Jurisdiction</para></remarks>
    /// <seealso href="https://w3id.org/def/nyon#Review_Jurisdiction">https://w3id.org/def/nyon#Review_Jurisdiction</seealso>
    let Review_Jurisdiction = Prefixed_Name(nyon, "Review_Jurisdiction") |> PrefixedName
    /// <summary>
    ///   <para>nyon:withConcurrence</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>specifies the judge (nyon:Judge) gives the opinion in concurrence (nyon:Concurrence) of the court</para>
    /// labels<para>withConcurrence</para></remarks>
    /// <seealso href="https://w3id.org/def/nyon#withConcurrence">https://w3id.org/def/nyon#withConcurrence</seealso>
    let withConcurrence = Prefixed_Name(nyon, "withConcurrence") |> PrefixedName
    /// <summary>
    ///   <para>nyon:defendentArgument</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>specifies the argument made by the defendant (nyon:Defendant) of nyon:CourtCase</para>
    /// labels<para>defendantArgument</para></remarks>
    /// <seealso href="https://w3id.org/def/nyon#defendentArgument">https://w3id.org/def/nyon#defendentArgument</seealso>
    let defendentArgument = Prefixed_Name(nyon, "defendentArgument") |> PrefixedName
    /// <summary>
    ///   <para>nyon:petitionerArgument</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>specifies the argument made by the Petitioner (nyon:Petitioner) of nyon:CourtCase</para>
    /// labels<para>petitionerArgument</para></remarks>
    /// <seealso href="https://w3id.org/def/nyon#petitionerArgument">https://w3id.org/def/nyon#petitionerArgument</seealso>
    let petitionerArgument = Prefixed_Name(nyon, "petitionerArgument") |> PrefixedName
    /// <summary>
    ///   <para>nyon:plaintiffArgument</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>specifies the argument made by the plaintiff (nyon:Plaintiff) of nyon:CourtCase</para>
    /// labels<para>plaintiffArgument</para></remarks>
    /// <seealso href="https://w3id.org/def/nyon#plaintiffArgument">https://w3id.org/def/nyon#plaintiffArgument</seealso>
    let plaintiffArgument = Prefixed_Name(nyon, "plaintiffArgument") |> PrefixedName
    /// <summary>
    ///   <para>nyon:Judge</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>represents the judge of the case</para>
    /// labels<para>Judge</para></remarks>
    /// <seealso href="https://w3id.org/def/nyon#Judge">https://w3id.org/def/nyon#Judge</seealso>
    let Judge = Prefixed_Name(nyon, "Judge") |> PrefixedName
    /// <summary>
    ///   <para>nyon:Solicitor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>represents solicitor, learned counsel or laywer of the case</para>
    /// labels<para>Solicitor</para></remarks>
    /// <seealso href="https://w3id.org/def/nyon#Solicitor">https://w3id.org/def/nyon#Solicitor</seealso>
    let Solicitor = Prefixed_Name(nyon, "Solicitor") |> PrefixedName
    /// <summary>
    ///   <para>nyon:Group</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>party of the case are the group of people on one side against another group of people or individual or state</para>
    /// labels<para>Group</para></remarks>
    /// <seealso href="https://w3id.org/def/nyon#Group">https://w3id.org/def/nyon#Group</seealso>
    let Group = Prefixed_Name(nyon, "Group") |> PrefixedName
    /// <summary>
    ///   <para>nyon:Individual</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>participants of the case are the individual persons</para>
    /// labels<para>Individual</para></remarks>
    /// <seealso href="https://w3id.org/def/nyon#Individual">https://w3id.org/def/nyon#Individual</seealso>
    let Individual = Prefixed_Name(nyon, "Individual") |> PrefixedName
