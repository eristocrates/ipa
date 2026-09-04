#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module nyon =
    let _prefixId = PrefixId.fromNamespaceLabel "https://w3id.org/def/nyon#" "nyon"
    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:label : Accused</para>
    ///   <para>rdfs:comment : person against whom an allegation has been made that he has committed an offence, or who is charge with an offence</para>
    ///   <a href="https://w3id.org/def/nyon#Accussed">nyon:Accussed</a>
    /// </summary>
    let Accussed = _prefixId.prefix "Accussed"
    /// <summary>
    ///   <para>rdfs:label : Advisory Jurisdiction</para>
    ///   <para>rdfs:comment : jurisdiction type is a advisory jurisdiction</para>
    ///   <a href="https://w3id.org/def/nyon#Advisory_Jurisdiction">nyon:Advisory_Jurisdiction</a>
    /// </summary>
    let Advisory_Jurisdiction = _prefixId.prefix "Advisory_Jurisdiction"
    /// <summary>
    ///   <para>owl:sameAs : http://lmss.sali.org/R7uigsz85fFCSPszS6B93dN</para>
    ///   <para>rdfs:label : Appellant</para>
    ///   <para>rdfs:comment : party who makes an appeal</para>
    ///   <a href="https://w3id.org/def/nyon#Appellant">nyon:Appellant</a>
    /// </summary>
    let Appellant = _prefixId.prefix "Appellant"
    /// <summary>
    ///   <para>rdfs:label : Appellant Jurisdiction</para>
    ///   <para>rdfs:comment : jurisdiction type is a appellant jurisdiction</para>
    ///   <a href="https://w3id.org/def/nyon#Appellant_Jurisdiction">nyon:Appellant_Jurisdiction</a>
    /// </summary>
    let Appellant_Jurisdiction = _prefixId.prefix "Appellant_Jurisdiction"
    /// <summary>
    ///   <para>rdfs:label : Argument</para>
    ///   <para>rdfs:comment : Argument made by any of the party</para>
    ///   <a href="https://w3id.org/def/nyon#Argument">nyon:Argument</a>
    /// </summary>
    let Argument = _prefixId.prefix "Argument"
    /// <summary>
    ///   <para>owl:sameAs : http://lmss.sali.org/Ra6EHlbqrpUT9rxM2PtwIP</para>
    ///   <para>rdfs:label : Author</para>
    ///   <para>rdfs:comment : Author (Judge) who is responsible for a creation of case document</para>
    ///   <a href="https://w3id.org/def/nyon#Author">nyon:Author</a>
    /// </summary>
    let Author = _prefixId.prefix "Author"
    /// <summary>
    ///   <para>owl:sameAs : http://lmss.sali.org/R8w3kl1tpEaQ2woPVs9N8Kf</para>
    ///   <para>rdfs:label : Bench</para>
    ///   <para>rdfs:comment : Defines the bench of the case.</para>
    ///   <a href="https://w3id.org/def/nyon#Bench">nyon:Bench</a>
    /// </summary>
    let Bench = _prefixId.prefix "Bench"
    /// <summary>
    ///   <para>rdfs:label : COFirstName</para>
    ///   <a href="https://w3id.org/def/nyon#COFirstName">nyon:COFirstName</a>
    /// </summary>
    let COFirstName = _prefixId.prefix "COFirstName"
    /// <summary>
    ///   <para>rdfs:label : COLastName</para>
    ///   <a href="https://w3id.org/def/nyon#COLastName">nyon:COLastName</a>
    /// </summary>
    let COLastName = _prefixId.prefix "COLastName"
    /// <summary>
    ///   <para>rdfs:label : CaseDomain</para>
    ///   <para>rdfs:comment : case belongs to specific proceeding like civil or criminal</para>
    ///   <a href="https://w3id.org/def/nyon#CaseDomain">nyon:CaseDomain</a>
    /// </summary>
    let CaseDomain = _prefixId.prefix "CaseDomain"
    /// <summary>
    ///   <para>rdfs:label : CaseType</para>
    ///   <para>rdfs:comment : classification of types of cases</para>
    ///   <a href="https://w3id.org/def/nyon#CaseType">nyon:CaseType</a>
    /// </summary>
    let CaseType = _prefixId.prefix "CaseType"
    /// <summary>
    ///   <para>rdfs:label : Catchword</para>
    ///   <para>rdfs:comment : Descriptive words or phrases used to categorise the subject matter of a case along with some keywords representing the issues in the case</para>
    ///   <a href="https://w3id.org/def/nyon#CatchWord">nyon:CatchWord</a>
    /// </summary>
    let CatchWord = _prefixId.prefix "CatchWord"
    /// <summary>
    ///   <para>rdfs:label : Chief Meterpolitan Court</para>
    ///   <para>rdfs:comment : lower court at metropolitan level after Sessions Court for criminal cases</para>
    ///   <a href="https://w3id.org/def/nyon#Chief_Meterpolitan_Court">nyon:Chief_Meterpolitan_Court</a>
    /// </summary>
    let Chief_Meterpolitan_Court = _prefixId.prefix "Chief_Meterpolitan_Court"
    /// <summary>
    ///   <para>rdfs:label : City Civil Court</para>
    ///   <para>rdfs:comment : lower court at metropolitan level after High Courts for civil cases</para>
    ///   <a href="https://w3id.org/def/nyon#City_Civil_Courts">nyon:City_Civil_Courts</a>
    /// </summary>
    let City_Civil_Courts = _prefixId.prefix "City_Civil_Courts"
    /// <summary>
    ///   <para>rdfs:label : Civil</para>
    ///   <para>rdfs:comment : case is a civil case</para>
    ///   <a href="https://w3id.org/def/nyon#Civil">nyon:Civil</a>
    /// </summary>
    let Civil = _prefixId.prefix "Civil"
    /// <summary>
    ///   <para>rdfs:label : Concurrence</para>
    ///   <para>rdfs:comment : decisions result when a judge agrees with the ultimate conclusion made by the majority of the court but disagrees on how they reached that decision^^xsd:string</para>
    ///   <a href="https://w3id.org/def/nyon#Concurrence">nyon:Concurrence</a>
    /// </summary>
    let Concurrence = _prefixId.prefix "Concurrence"
    /// <summary>
    ///   <para>owl:sameAs : http://lmss.sali.org/RNrcOpWxQNlCpzR0FTsHNG</para>
    ///   <para>rdfs:label : Country</para>
    ///   <para>rdfs:comment : A country^^xsd:string</para>
    ///   <a href="https://w3id.org/def/nyon#Country">nyon:Country</a>
    /// </summary>
    let Country = _prefixId.prefix "Country"
    /// <summary>
    ///   <para>owl:sameAs : http://lmss.sali.org/Rafw4pSzJ3S3d8sq6quprG</para>
    ///   <para>rdfs:label : Court</para>
    ///   <para>rdfs:comment : courts in the judicial system</para>
    ///   <a href="https://w3id.org/def/nyon#Court">nyon:Court</a>
    /// </summary>
    let Court = _prefixId.prefix "Court"
    /// <summary>
    ///   <para>rdfs:label : CourtCase</para>
    ///   <para>rdfs:comment : represents the court judgment given by a court of law</para>
    ///   <a href="https://w3id.org/def/nyon#CourtCase">nyon:CourtCase</a>
    /// </summary>
    let CourtCase = _prefixId.prefix "CourtCase"
    /// <summary>
    ///   <para>rdfs:label : CourtDecision</para>
    ///   <a href="https://w3id.org/def/nyon#CourtDecision">nyon:CourtDecision</a>
    /// </summary>
    let CourtDecision = _prefixId.prefix "CourtDecision"
    /// <summary>
    ///   <para>rdfs:label : CourtOfficial</para>
    ///   <para>rdfs:comment : legal system related people involved in a case</para>
    ///   <a href="https://w3id.org/def/nyon#Court_Official">nyon:Court_Official</a>
    /// </summary>
    let Court_Official = _prefixId.prefix "Court_Official"
    /// <summary>
    ///   <para>owl:sameAs : http://lmss.sali.org/R9uoItz60Ut8I4l3jEH3mSF</para>
    ///   <para>rdfs:label : Civil Court</para>
    ///   <para>rdfs:comment : court for civil cases</para>
    ///   <a href="https://w3id.org/def/nyon#Courts_for_Civil">nyon:Courts_for_Civil</a>
    /// </summary>
    let Courts_for_Civil = _prefixId.prefix "Courts_for_Civil"
    /// <summary>
    ///   <para>owl:sameAs : http://lmss.sali.org/RihNVfYYtmWzQWciwxquKe</para>
    ///   <para>rdfs:label : Criminal Court</para>
    ///   <para>rdfs:comment : courts for crimnial cases</para>
    ///   <a href="https://w3id.org/def/nyon#Courts_for_Criminal">nyon:Courts_for_Criminal</a>
    /// </summary>
    let Courts_for_Criminal = _prefixId.prefix "Courts_for_Criminal"
    /// <summary>
    ///   <para>owl:sameAs : http://lmss.sali.org/R9Mmy6MnWY16eR6dlLOKnGO</para>
    ///   <para>rdfs:label : Court of Smaller Cause</para>
    ///   <para>rdfs:comment : lowest court after City Civil Courts at metropolitan level for civil cases</para>
    ///   <a href="https://w3id.org/def/nyon#Courts_of_Smaller_Causes">nyon:Courts_of_Smaller_Causes</a>
    /// </summary>
    let Courts_of_Smaller_Causes = _prefixId.prefix "Courts_of_Smaller_Causes"
    /// <summary>
    ///   <para>rdfs:label : Criminal</para>
    ///   <para>rdfs:comment : case is a criminal case</para>
    ///   <a href="https://w3id.org/def/nyon#Criminal">nyon:Criminal</a>
    /// </summary>
    let Criminal = _prefixId.prefix "Criminal"
    /// <summary>
    ///   <para>rdfs:label : DateofJudgment</para>
    ///   <para>rdfs:comment : signifies the final date on which the judgment is given by the court of law</para>
    ///   <a href="https://w3id.org/def/nyon#DateOfJudgment">nyon:DateOfJudgment</a>
    /// </summary>
    let DateOfJudgment = _prefixId.prefix "DateOfJudgment"
    /// <summary>
    ///   <para>rdfs:label : Decree</para>
    ///   <para>rdfs:comment : formal order issued by the judges^^xsd:string</para>
    ///   <a href="https://w3id.org/def/nyon#Decree">nyon:Decree</a>
    /// </summary>
    let Decree = _prefixId.prefix "Decree"
    /// <summary>
    ///   <para>owl:sameAs : http://lmss.sali.org/RijIqw1HEfQF4ctjWUlgnq</para>
    ///   <para>rdfs:label : Defendant</para>
    ///   <para>rdfs:comment : a person sued in the court of law</para>
    ///   <a href="https://w3id.org/def/nyon#Defendant">nyon:Defendant</a>
    /// </summary>
    let Defendant = _prefixId.prefix "Defendant"
    /// <summary>
    ///   <para>rdfs:label : Dissent</para>
    ///   <para>rdfs:comment : judges who do not agree with the majority of the Court^^xsd:string</para>
    ///   <a href="https://w3id.org/def/nyon#Dissent">nyon:Dissent</a>
    /// </summary>
    let Dissent = _prefixId.prefix "Dissent"
    /// <summary>
    ///   <para>rdfs:label : District</para>
    ///   <para>rdfs:comment : represents district name/location</para>
    ///   <a href="https://w3id.org/def/nyon#District">nyon:District</a>
    /// </summary>
    let District = _prefixId.prefix "District"
    /// <summary>
    ///   <para>rdfs:label : District Court</para>
    ///   <para>rdfs:comment : a term in judicial system in India in which a case is heard and judged by at least 2 judges</para>
    ///   <a href="https://w3id.org/def/nyon#District_Court">nyon:District_Court</a>
    /// </summary>
    let District_Court = _prefixId.prefix "District_Court"
    /// <summary>
    ///   <para>rdfs:label : Division Bench</para>
    ///   <para>rdfs:comment : a term in judicial system in India in which a case is heard and judged by at least 2 judges</para>
    ///   <a href="https://w3id.org/def/nyon#Division_Bench">nyon:Division_Bench</a>
    /// </summary>
    let Division_Bench = _prefixId.prefix "Division_Bench"
    /// <summary>
    ///   <para>owl:sameAs : http://lmss.sali.org/R7c1yU31BO5LWM06a7c0Pfd</para>
    ///   <para>rdfs:label : Evidence</para>
    ///   <para>rdfs:comment : evidences presented in front of the court in the case</para>
    ///   <a href="https://w3id.org/def/nyon#Evidence">nyon:Evidence</a>
    /// </summary>
    let Evidence = _prefixId.prefix "Evidence"
    /// <summary>
    ///   <para>owl:sameAs : http://lmss.sali.org/RnKWv1E6U2Ssc5SRsG14NO</para>
    ///   <para>rdfs:label : Fact</para>
    ///   <para>rdfs:comment : represents factual statements in the case law</para>
    ///   <a href="https://w3id.org/def/nyon#Fact">nyon:Fact</a>
    /// </summary>
    let Fact = _prefixId.prefix "Fact"
    /// <summary>
    ///   <para>rdfs:label : Group</para>
    ///   <para>rdfs:comment : party of the case are the group of people on one side against another group of people or individual or state</para>
    ///   <a href="https://w3id.org/def/nyon#Group">nyon:Group</a>
    /// </summary>
    let Group = _prefixId.prefix "Group"
    /// <summary>
    ///   <para>rdfs:label : High Court</para>
    ///   <para>rdfs:comment : court at the state level</para>
    ///   <a href="https://w3id.org/def/nyon#High_Court">nyon:High_Court</a>
    /// </summary>
    let High_Court = _prefixId.prefix "High_Court"
    /// <summary>
    ///   <para>owl:sameAs : http://lmss.sali.org/RDCkFrEclhipkoHPgckuFY6</para>
    ///   <para>rdfs:label : Individual</para>
    ///   <para>rdfs:comment : participants of the case are the individual persons</para>
    ///   <a href="https://w3id.org/def/nyon#Individual">nyon:Individual</a>
    /// </summary>
    let Individual = _prefixId.prefix "Individual"
    /// <summary>
    ///   <para>owl:sameAs : http://lmss.sali.org/RDVQLifN70TJSPCRJJLBgPY</para>
    ///   <para>rdfs:label : PolicePersonnel</para>
    ///   <para>rdfs:comment : A police officer is a warranted law employee of a police force^^xsd:string</para>
    ///   <a href="https://w3id.org/def/nyon#Investigator">nyon:Investigator</a>
    /// </summary>
    let Investigator = _prefixId.prefix "Investigator"
    /// <summary>
    ///   <para>rdfs:label : Issue</para>
    ///   <para>rdfs:comment : issues in the case arised by the party</para>
    ///   <a href="https://w3id.org/def/nyon#Issue">nyon:Issue</a>
    /// </summary>
    let Issue = _prefixId.prefix "Issue"
    /// <summary>
    ///   <para>owl:sameAs : http://lmss.sali.org/RDnLOdTNWmEc4EhZ0SZXDm7</para>
    ///   <para>rdfs:label : Judge</para>
    ///   <para>rdfs:comment : represents the judge of the case</para>
    ///   <a href="https://w3id.org/def/nyon#Judge">nyon:Judge</a>
    /// </summary>
    let Judge = _prefixId.prefix "Judge"
    /// <summary>
    ///   <para>owl:sameAs : http://lmss.sali.org/R9jpIjzc10qdgl78jXOZtfm</para>
    ///   <para>rdfs:label : Judgement</para>
    ///   <para>rdfs:comment : Judgement given by the judge </para>
    ///   <a href="https://w3id.org/def/nyon#Judgement">nyon:Judgement</a>
    /// </summary>
    let Judgement = _prefixId.prefix "Judgement"

    /// <summary>
    ///   <para>rdfs:label : Judicial Magistrate Court (First Class)</para>
    ///   <para>rdfs:comment : second lower court at distrcit level after districit level Session Court for criminal cases</para>
    ///   <a href="https://w3id.org/def/nyon#Judicial_Magistrate_Court(First_Class)">nyon:Judicial_Magistrate_Court(First_Class)</a>
    /// </summary>
    let Judicial_Magistrate_CourtFirst_Class =
        _prefixId.prefix "Judicial_Magistrate_Court(First_Class)"

    /// <summary>
    ///   <para>rdfs:label : Judicial Magistrate Court (Second Class)</para>
    ///   <para>rdfs:comment : lowest court after Judicial Magistrate Court (First Class) at distrcit level for criminal cases</para>
    ///   <a href="https://w3id.org/def/nyon#Judicial_Magistrate_Court(Second_Class)">nyon:Judicial_Magistrate_Court(Second_Class)</a>
    /// </summary>
    let Judicial_Magistrate_CourtSecond_Class =
        _prefixId.prefix "Judicial_Magistrate_Court(Second_Class)"

    /// <summary>
    ///   <para>rdfs:label : Jurisdiction</para>
    ///   <para>rdfs:comment : the extent to which a court of law can exercise its authority over any cases filed across a region</para>
    ///   <a href="https://w3id.org/def/nyon#Jurisdiction">nyon:Jurisdiction</a>
    /// </summary>
    let Jurisdiction = _prefixId.prefix "Jurisdiction"
    /// <summary>
    ///   <para>rdfs:label : Larger Bench</para>
    ///   <para>rdfs:comment : a term in judicial system in India in which a case is heard and judged by three or five judges</para>
    ///   <a href="https://w3id.org/def/nyon#Larger_Bench">nyon:Larger_Bench</a>
    /// </summary>
    let Larger_Bench = _prefixId.prefix "Larger_Bench"
    /// <summary>
    ///   <para>owl:sameAs : http://lmss.sali.org/RcTA2iQmrtqOnX3WrjJIp8</para>
    ///   <para>rdfs:label : Lawyer</para>
    ///   <para>rdfs:comment : Lawyer is a term of reference to the attroneys and advocates collectively in litigation</para>
    ///   <a href="https://w3id.org/def/nyon#Lawyer">nyon:Lawyer</a>
    /// </summary>
    let Lawyer = _prefixId.prefix "Lawyer"
    /// <summary>
    ///   <para>rdfs:label : LearnedCounsel</para>
    ///   <para>rdfs:comment : Learned counsel is a term of reference to the lawyers and advocates collectively in litigation</para>
    ///   <a href="https://w3id.org/def/nyon#LearnedCounsel">nyon:LearnedCounsel</a>
    /// </summary>
    let LearnedCounsel = _prefixId.prefix "LearnedCounsel"
    /// <summary>
    ///   <para>owl:sameAs : http://lmss.sali.org/R9aSzp9cEiBCzObnP92jYFX</para>
    ///   <para>rdfs:label : Location</para>
    ///   <para>rdfs:comment : represents the location of the courts, etc and also used for evidence locations</para>
    ///   <a href="https://w3id.org/def/nyon#Location">nyon:Location</a>
    /// </summary>
    let Location = _prefixId.prefix "Location"
    /// <summary>
    ///   <para>rdfs:label : Majority</para>
    ///   <para>rdfs:comment : Majority decisions are the ones where a majority of the judges agree^^xsd:string</para>
    ///   <a href="https://w3id.org/def/nyon#Majority">nyon:Majority</a>
    /// </summary>
    let Majority = _prefixId.prefix "Majority"

    /// <summary>
    ///   <para>rdfs:label : Metropolitan Magistrate Court</para>
    ///   <para>rdfs:comment : lowest court after Chief Metropolitan Court at metropolitan level for criminal cases</para>
    ///   <a href="https://w3id.org/def/nyon#Metropolitan_Magistrate_Courts">nyon:Metropolitan_Magistrate_Courts</a>
    /// </summary>
    let Metropolitan_Magistrate_Courts =
        _prefixId.prefix "Metropolitan_Magistrate_Courts"

    /// <summary>
    ///   <para>rdfs:label : Metropolitan Court</para>
    ///   <para>rdfs:comment : court for population more than 10 lakh city </para>
    ///   <a href="https://w3id.org/def/nyon#Metropolitian_Courts">nyon:Metropolitian_Courts</a>
    /// </summary>
    let Metropolitian_Courts = _prefixId.prefix "Metropolitian_Courts"
    /// <summary>
    ///   <para>rdfs:label : Munsif Court</para>
    ///   <para>rdfs:comment : lowest court in heirarchy for civil ases at district level after Principal Junior Civil Court</para>
    ///   <a href="https://w3id.org/def/nyon#Munsif_Court">nyon:Munsif_Court</a>
    /// </summary>
    let Munsif_Court = _prefixId.prefix "Munsif_Court"
    /// <summary>
    ///   <para>rdfs:label : Obiter Dictum</para>
    ///   <para>rdfs:comment : additional obersvations, remarks, and opinions made by the judge that are not the part of the reason for the decision</para>
    ///   <a href="https://w3id.org/def/nyon#ObiterDictum">nyon:ObiterDictum</a>
    /// </summary>
    let ObiterDictum = _prefixId.prefix "ObiterDictum"
    /// <summary>
    ///   <para>rdfs:label : OfDomain</para>
    ///   <para>rdfs:comment : specifies the law domain (nyon:CaseDomain) the court case (nyon:CourtCase) belongs to^^xsd:string</para>
    ///   <a href="https://w3id.org/def/nyon#OfDomian">nyon:OfDomian</a>
    /// </summary>
    let OfDomian = _prefixId.prefix "OfDomian"
    /// <summary>
    ///   <para>owl:sameAs : http://lmss.sali.org/RDNaE3PFsXDfIudTq7w3ace</para>
    ///   <para>rdfs:label : Opinion</para>
    ///   <para>rdfs:comment : judge opinion with respect to case or judgment</para>
    ///   <a href="https://w3id.org/def/nyon#Opinion">nyon:Opinion</a>
    /// </summary>
    let Opinion = _prefixId.prefix "Opinion"
    /// <summary>
    ///   <para>owl:sameAs : http://lmss.sali.org/R7ibFsNNncTIYF5AjKUDg7b</para>
    ///   <para>rdfs:label : Order</para>
    ///   <para>rdfs:comment : order given by the court</para>
    ///   <a href="https://w3id.org/def/nyon#Order">nyon:Order</a>
    /// </summary>
    let Order = _prefixId.prefix "Order"
    /// <summary>
    ///   <para>rdfs:label : Original Jurisdiction</para>
    ///   <para>rdfs:comment : jurisdiction type is a original jurisdiction</para>
    ///   <a href="https://w3id.org/def/nyon#Original_Jurisdiction">nyon:Original_Jurisdiction</a>
    /// </summary>
    let Original_Jurisdiction = _prefixId.prefix "Original_Jurisdiction"
    /// <summary>
    ///   <para>rdfs:label : Party</para>
    ///   <para>rdfs:comment : party or people involved in the case</para>
    ///   <a href="https://w3id.org/def/nyon#Party">nyon:Party</a>
    /// </summary>
    let Party = _prefixId.prefix "Party"
    /// <summary>
    ///   <para>rdfs:label : Party Type</para>
    ///   <para>rdfs:comment : represents the types of party involved in the case viz. individual, organization, govt. etc.</para>
    ///   <a href="https://w3id.org/def/nyon#Party_Type">nyon:Party_Type</a>
    /// </summary>
    let Party_Type = _prefixId.prefix "Party_Type"
    /// <summary>
    ///   <para>rdfs:label : Petitioner</para>
    ///   <para>rdfs:comment : one who makes the petition</para>
    ///   <a href="https://w3id.org/def/nyon#Petitioner">nyon:Petitioner</a>
    /// </summary>
    let Petitioner = _prefixId.prefix "Petitioner"
    /// <summary>
    ///   <para>owl:sameAs : http://lmss.sali.org/R9tyJmIM3Lx7OItGji5zPXN</para>
    ///   <para>rdfs:label : Plaintiff</para>
    ///   <para>rdfs:comment : party who brings the suit in the court of law</para>
    ///   <a href="https://w3id.org/def/nyon#Plaintiff">nyon:Plaintiff</a>
    /// </summary>
    let Plaintiff = _prefixId.prefix "Plaintiff"
    /// <summary>
    ///   <para>rdfs:label : Precedent</para>
    ///   <para>rdfs:comment : all the past cases referred in the current judgment b ythe judge</para>
    ///   <a href="https://w3id.org/def/nyon#Precedent">nyon:Precedent</a>
    /// </summary>
    let Precedent = _prefixId.prefix "Precedent"
    /// <summary>
    ///   <para>rdfs:label : Principal Junior Civil Court</para>
    ///   <para>rdfs:comment : third lower court in hierarchy at district level for civil cases</para>
    ///   <a href="https://w3id.org/def/nyon#Principal_Junior_Civil_Court">nyon:Principal_Junior_Civil_Court</a>
    /// </summary>
    let Principal_Junior_Civil_Court = _prefixId.prefix "Principal_Junior_Civil_Court"
    /// <summary>
    ///   <para>rdfs:label : Provision</para>
    ///   <para>rdfs:comment : clause or section number or article number applied/used in the case law</para>
    ///   <a href="https://w3id.org/def/nyon#Provision">nyon:Provision</a>
    /// </summary>
    let Provision = _prefixId.prefix "Provision"
    /// <summary>
    ///   <para>rdfs:label : RatioDecidendi</para>
    ///   <para>rdfs:comment : the rationale for the decision</para>
    ///   <a href="https://w3id.org/def/nyon#RatioDecidendi">nyon:RatioDecidendi</a>
    /// </summary>
    let RatioDecidendi = _prefixId.prefix "RatioDecidendi"
    /// <summary>
    ///   <para>owl:sameAs : http://lmss.sali.org/RDsxHT4FlaoALPmeZmTt8td</para>
    ///   <para>rdfs:label : Respondent</para>
    ///   <para>rdfs:comment : party called upon to respond or answer a petition, a cliam or a appeal</para>
    ///   <a href="https://w3id.org/def/nyon#Respondent">nyon:Respondent</a>
    /// </summary>
    let Respondent = _prefixId.prefix "Respondent"
    /// <summary>
    ///   <para>rdfs:label : Review Jurisdiction</para>
    ///   <para>rdfs:comment : jurisdiction type is a review jurisdiction</para>
    ///   <a href="https://w3id.org/def/nyon#Review_Jurisdiction">nyon:Review_Jurisdiction</a>
    /// </summary>
    let Review_Jurisdiction = _prefixId.prefix "Review_Jurisdiction"
    /// <summary>
    ///   <para>rdfs:label : Sessions Court</para>
    ///   <para>rdfs:comment : lower court at both distrcit and metropolitan level after High Courts specific for criminal cases</para>
    ///   <a href="https://w3id.org/def/nyon#Session_Court">nyon:Session_Court</a>
    /// </summary>
    let Session_Court = _prefixId.prefix "Session_Court"
    /// <summary>
    ///   <para>rdfs:label : Single Judge</para>
    ///   <para>rdfs:comment : a case heard and judged by a single judge</para>
    ///   <a href="https://w3id.org/def/nyon#Single_Judge">nyon:Single_Judge</a>
    /// </summary>
    let Single_Judge = _prefixId.prefix "Single_Judge"
    /// <summary>
    ///   <para>rdfs:label : Solicitor</para>
    ///   <para>rdfs:comment : represents solicitor, learned counsel or laywer of the case</para>
    ///   <a href="https://w3id.org/def/nyon#Solicitor">nyon:Solicitor</a>
    /// </summary>
    let Solicitor = _prefixId.prefix "Solicitor"
    /// <summary>
    ///   <para>rdfs:label : Special Bench</para>
    ///   <para>rdfs:comment : means the Bench constituted by or under the orders of the Chief Justice to hear a case or particular class of cases</para>
    ///   <a href="https://w3id.org/def/nyon#Special_Bench">nyon:Special_Bench</a>
    /// </summary>
    let Special_Bench = _prefixId.prefix "Special_Bench"
    /// <summary>
    ///   <para>rdfs:label : State</para>
    ///   <para>rdfs:comment : represents state name/location</para>
    ///   <a href="https://w3id.org/def/nyon#State">nyon:State</a>
    /// </summary>
    let State = _prefixId.prefix "State"
    /// <summary>
    ///   <para>rdfs:label : Statue</para>
    ///   <para>rdfs:comment : includes the acts and norms of the law</para>
    ///   <a href="https://w3id.org/def/nyon#Statue">nyon:Statue</a>
    /// </summary>
    let Statue = _prefixId.prefix "Statue"
    /// <summary>
    ///   <para>rdfs:label : Sub Court</para>
    ///   <para>rdfs:comment : second lower court in hierarchy at District level for civil cases</para>
    ///   <a href="https://w3id.org/def/nyon#Sub_Court">nyon:Sub_Court</a>
    /// </summary>
    let Sub_Court = _prefixId.prefix "Sub_Court"
    /// <summary>
    ///   <para>rdfs:label : Supreme Court of India</para>
    ///   <para>rdfs:comment : highest court in the judicial system</para>
    ///   <a href="https://w3id.org/def/nyon#SupremeCourt">nyon:SupremeCourt</a>
    /// </summary>
    let SupremeCourt = _prefixId.prefix "SupremeCourt"
    /// <summary>
    ///   <para>rdfs:label : Taluka</para>
    ///   <para>rdfs:comment : represents taluka name/location</para>
    ///   <a href="https://w3id.org/def/nyon#Taluka">nyon:Taluka</a>
    /// </summary>
    let Taluka = _prefixId.prefix "Taluka"
    /// <summary>
    ///   <para>rdfs:label : Tribunal</para>
    ///   <para>rdfs:comment : institutions established for discharging judicial or quasi-judicial duties under the Government of India</para>
    ///   <a href="https://w3id.org/def/nyon#Tribunal">nyon:Tribunal</a>
    /// </summary>
    let Tribunal = _prefixId.prefix "Tribunal"
    /// <summary>
    ///   <para>rdfs:label : Tribunal Bench</para>
    ///   <para>rdfs:comment : Bench deals with tribunals cases</para>
    ///   <a href="https://w3id.org/def/nyon#Tribunal_Bench">nyon:Tribunal_Bench</a>
    /// </summary>
    let Tribunal_Bench = _prefixId.prefix "Tribunal_Bench"
    /// <summary>
    ///   <para>owl:sameAs : http://lmss.sali.org/R9tZFXPrXQJWHbqSgtCQxJF</para>
    ///   <para>rdfs:label : Witness</para>
    ///   <para>rdfs:comment : witness involved/presented in the case</para>
    ///   <a href="https://w3id.org/def/nyon#Witness">nyon:Witness</a>
    /// </summary>
    let Witness = _prefixId.prefix "Witness"
    /// <summary>
    ///   <para>rdfs:label : WordsAndPhrases</para>
    ///   <para>rdfs:comment : words or phrases exctracted from the case to make the search better for the cases or find relevent cases or judgment</para>
    ///   <a href="https://w3id.org/def/nyon#WordAndPhrase">nyon:WordAndPhrase</a>
    /// </summary>
    let WordAndPhrase = _prefixId.prefix "WordAndPhrase"
    /// <summary>
    ///   <para>rdfs:label : Writ Jurisdiction</para>
    ///   <para>rdfs:comment : jurisdiction type is a writ jurisdiction</para>
    ///   <a href="https://w3id.org/def/nyon#Writ_Jurisdiction">nyon:Writ_Jurisdiction</a>
    /// </summary>
    let Writ_Jurisdiction = _prefixId.prefix "Writ_Jurisdiction"
    /// <summary>
    ///   <para>rdfs:label : appellantArgument^^xsd:string</para>
    ///   <para>rdfs:comment : specifies the argument made by the appellant (nyon:Appellant) of nyon:CourtCase^^xsd:string</para>
    ///   <a href="https://w3id.org/def/nyon#appellantArgument">nyon:appellantArgument</a>
    /// </summary>
    let appellantArgument = _prefixId.prefix "appellantArgument"
    /// <summary>
    ///   <para>rdfs:label : argumentSequenceNum</para>
    ///   <a href="https://w3id.org/def/nyon#argumentSequenceNum">nyon:argumentSequenceNum</a>
    /// </summary>
    let argumentSequenceNum = _prefixId.prefix "argumentSequenceNum"
    /// <summary>
    ///   <para>rdfs:label : argumentValue</para>
    ///   <a href="https://w3id.org/def/nyon#argumentValue">nyon:argumentValue</a>
    /// </summary>
    let argumentValue = _prefixId.prefix "argumentValue"
    /// <summary>
    ///   <para>rdfs:label : catchwordValue</para>
    ///   <a href="https://w3id.org/def/nyon#catchwordValue">nyon:catchwordValue</a>
    /// </summary>
    let catchwordValue = _prefixId.prefix "catchwordValue"
    /// <summary>
    ///   <para>rdfs:label : citedBy</para>
    ///   <para>rdfs:comment : specifies the nyon:CourtCase being cited by nyon:CourtCase^^xsd:string</para>
    ///   <a href="https://w3id.org/def/nyon#citedBy">nyon:citedBy</a>
    /// </summary>
    let citedBy = _prefixId.prefix "citedBy"
    /// <summary>
    ///   <para>rdfs:label : cites</para>
    ///   <para>rdfs:comment : specifies the nyon:CourtCase is citing another nyon:CourtCase^^xsd:string</para>
    ///   <a href="https://w3id.org/def/nyon#cites">nyon:cites</a>
    /// </summary>
    let cites = _prefixId.prefix "cites"
    /// <summary>
    ///   <para>rdfs:label : courtName</para>
    ///   <a href="https://w3id.org/def/nyon#courtName">nyon:courtName</a>
    /// </summary>
    let courtName = _prefixId.prefix "courtName"
    /// <summary>
    ///   <para>rdfs:label : courtOffName</para>
    ///   <a href="https://w3id.org/def/nyon#courtOffName">nyon:courtOffName</a>
    /// </summary>
    let courtOffName = _prefixId.prefix "courtOffName"
    /// <summary>
    ///   <para>rdfs:label : dateOfJudgment</para>
    ///   <a href="https://w3id.org/def/nyon#dateOfJudgment">nyon:dateOfJudgment</a>
    /// </summary>
    let dateOfJudgment = _prefixId.prefix "dateOfJudgment"
    /// <summary>
    ///   <para>rdfs:label : defendantArgument^^xsd:string</para>
    ///   <para>rdfs:comment : specifies the argument made by the defendant (nyon:Defendant) of nyon:CourtCase^^xsd:string</para>
    ///   <a href="https://w3id.org/def/nyon#defendentArgument">nyon:defendentArgument</a>
    /// </summary>
    let defendentArgument = _prefixId.prefix "defendentArgument"
    /// <summary>
    ///   <para>rdfs:comment : equivalent citations provided by the various law reporters.</para>
    ///   <a href="https://w3id.org/def/nyon#equivalentCitation">nyon:equivalentCitation</a>
    /// </summary>
    let equivalentCitation = _prefixId.prefix "equivalentCitation"
    /// <summary>
    ///   <para>rdfs:label : evidenceLocation</para>
    ///   <a href="https://w3id.org/def/nyon#evidenceLocation">nyon:evidenceLocation</a>
    /// </summary>
    let evidenceLocation = _prefixId.prefix "evidenceLocation"
    /// <summary>
    ///   <para>rdfs:label : factSequenceNum</para>
    ///   <a href="https://w3id.org/def/nyon#factSequenceNum">nyon:factSequenceNum</a>
    /// </summary>
    let factSequenceNum = _prefixId.prefix "factSequenceNum"
    /// <summary>
    ///   <para>rdfs:label : factValue</para>
    ///   <a href="https://w3id.org/def/nyon#factValue">nyon:factValue</a>
    /// </summary>
    let factValue = _prefixId.prefix "factValue"
    /// <summary>
    ///   <para>rdfs:label : finalDecisionValue</para>
    ///   <a href="https://w3id.org/def/nyon#finalDecisionValue">nyon:finalDecisionValue</a>
    /// </summary>
    let finalDecisionValue = _prefixId.prefix "finalDecisionValue"
    /// <summary>
    ///   <para>rdfs:label : firstName</para>
    ///   <a href="https://w3id.org/def/nyon#firstName">nyon:firstName</a>
    /// </summary>
    let firstName = _prefixId.prefix "firstName"
    /// <summary>
    ///   <para>rdfs:label : hasAuthor</para>
    ///   <para>rdfs:comment : specifies an author (nyon:Author) (any judge (nyon:Judge) from the bench) of the nyon:CourtCase^^xsd:string</para>
    ///   <a href="https://w3id.org/def/nyon#hasAuthor">nyon:hasAuthor</a>
    /// </summary>
    let hasAuthor = _prefixId.prefix "hasAuthor"
    /// <summary>
    ///   <para>rdfs:label : hasBench</para>
    ///   <para>rdfs:comment : specifies the bench associated with nyon:Bench of the nyon:CourtCase^^xsd:string</para>
    ///   <a href="https://w3id.org/def/nyon#hasBench">nyon:hasBench</a>
    /// </summary>
    let hasBench = _prefixId.prefix "hasBench"
    /// <summary>
    ///   <para>rdfs:label : caseID^^xsd:string</para>
    ///   <para>rdfs:comment : Case has a unique ID</para>
    ///   <a href="https://w3id.org/def/nyon#hasCaseID">nyon:hasCaseID</a>
    /// </summary>
    let hasCaseID = _prefixId.prefix "hasCaseID"
    /// <summary>
    ///   <para>rdfs:label : caseName^^xsd:string</para>
    ///   <para>rdfs:comment : represents the name of a case usually contains the name of both the parties</para>
    ///   <a href="https://w3id.org/def/nyon#hasCaseName">nyon:hasCaseName</a>
    /// </summary>
    let hasCaseName = _prefixId.prefix "hasCaseName"
    /// <summary>
    ///   <para>rdfs:label : hasCourtLoc</para>
    ///   <para>rdfs:comment : specifies the location of the nyon:Court^^xsd:string</para>
    ///   <a href="https://w3id.org/def/nyon#hasCourtLoc">nyon:hasCourtLoc</a>
    /// </summary>
    let hasCourtLoc = _prefixId.prefix "hasCourtLoc"
    /// <summary>
    ///   <para>rdfs:label : hasCourtOfficial</para>
    ///   <para>rdfs:comment : specifies the court official represented with nyon:CourtOfficial connected to the nyon:CourtCase^^xsd:string</para>
    ///   <a href="https://w3id.org/def/nyon#hasCourtOfficial">nyon:hasCourtOfficial</a>
    /// </summary>
    let hasCourtOfficial = _prefixId.prefix "hasCourtOfficial"
    /// <summary>
    ///   <para>rdfs:label : hasDate</para>
    ///   <a href="https://w3id.org/def/nyon#hasDate">nyon:hasDate</a>
    /// </summary>
    let hasDate = _prefixId.prefix "hasDate"
    /// <summary>
    ///   <para>rdfs:label : hasDateOfJudgment</para>
    ///   <para>rdfs:comment : specifies the date of the judgment of the nyon:CourtCase^^xsd:string</para>
    ///   <a href="https://w3id.org/def/nyon#hasDateOfJudgment">nyon:hasDateOfJudgment</a>
    /// </summary>
    let hasDateOfJudgment = _prefixId.prefix "hasDateOfJudgment"
    /// <summary>
    ///   <para>rdfs:label : hasDesignation</para>
    ///   <a href="https://w3id.org/def/nyon#hasDesignation">nyon:hasDesignation</a>
    /// </summary>
    let hasDesignation = _prefixId.prefix "hasDesignation"
    /// <summary>
    ///   <para>rdfs:label : hasEvidence</para>
    ///   <para>rdfs:comment : specifies the evidence associated with the nyon:Evidence instance for the nyon:CourtCase^^xsd:string</para>
    ///   <a href="https://w3id.org/def/nyon#hasEvidence">nyon:hasEvidence</a>
    /// </summary>
    let hasEvidence = _prefixId.prefix "hasEvidence"
    /// <summary>
    ///   <para>rdfs:label : hasEvidenceLoc</para>
    ///   <para>rdfs:comment : specifies the evidence location associated with the nyon:Evidence instance for the nyon:CourtCase^^xsd:string</para>
    ///   <a href="https://w3id.org/def/nyon#hasEvidenceLoc">nyon:hasEvidenceLoc</a>
    /// </summary>
    let hasEvidenceLoc = _prefixId.prefix "hasEvidenceLoc"
    /// <summary>
    ///   <para>rdfs:label : hasFact</para>
    ///   <para>rdfs:comment : specifies the fact associated with nyon:Fact belonging to a specific nyon:CourtCase^^xsd:string</para>
    ///   <a href="https://w3id.org/def/nyon#hasFact">nyon:hasFact</a>
    /// </summary>
    let hasFact = _prefixId.prefix "hasFact"
    /// <summary>
    ///   <para>rdfs:label : hasFinalDecision</para>
    ///   <para>rdfs:comment : specifies the final verdict associated with the nyon:CourtCase^^xsd:string</para>
    ///   <a href="https://w3id.org/def/nyon#hasFinalDecision">nyon:hasFinalDecision</a>
    /// </summary>
    let hasFinalDecision = _prefixId.prefix "hasFinalDecision"
    /// <summary>
    ///   <para>rdfs:label : hasIssue</para>
    ///   <para>rdfs:comment : specifies the issue associated with the nyon:Issue instance mentioned in the nyon:CourtCase^^xsd:string</para>
    ///   <a href="https://w3id.org/def/nyon#hasIssue">nyon:hasIssue</a>
    /// </summary>
    let hasIssue = _prefixId.prefix "hasIssue"
    /// <summary>
    ///   <para>rdfs:label : hasJudge</para>
    ///   <para>rdfs:comment : specifies the judicial body (nyon:Judge) of nyon:CourtCase</para>
    ///   <a href="https://w3id.org/def/nyon#hasJudge">nyon:hasJudge</a>
    /// </summary>
    let hasJudge = _prefixId.prefix "hasJudge"
    /// <summary>
    ///   <para>rdfs:label : hasJudgmentType</para>
    ///   <para>rdfs:comment : specifies the type of judgment (nyon:CaseType) for nyon:CourtCase^^xsd:string</para>
    ///   <a href="https://w3id.org/def/nyon#hasJudgmentType">nyon:hasJudgmentType</a>
    /// </summary>
    let hasJudgmentType = _prefixId.prefix "hasJudgmentType"
    /// <summary>
    ///   <para>rdfs:label : hasJurisdiction</para>
    ///   <para>rdfs:comment : specifies the jurisdiction (nyon:Jurisdiction) for nyon:Court^^xsd:string</para>
    ///   <a href="https://w3id.org/def/nyon#hasJurisdiction">nyon:hasJurisdiction</a>
    /// </summary>
    let hasJurisdiction = _prefixId.prefix "hasJurisdiction"
    /// <summary>
    ///   <para>rdfs:label : hasMonth</para>
    ///   <a href="https://w3id.org/def/nyon#hasMonth">nyon:hasMonth</a>
    /// </summary>
    let hasMonth = _prefixId.prefix "hasMonth"
    /// <summary>
    ///   <para>rdfs:label : hasObiterDictum</para>
    ///   <para>rdfs:comment : specifies the obiter dicta associated with nyon:ObiterDictum mentioned in nyon:CourtCase^^xsd:string</para>
    ///   <a href="https://w3id.org/def/nyon#hasObiterDictum">nyon:hasObiterDictum</a>
    /// </summary>
    let hasObiterDictum = _prefixId.prefix "hasObiterDictum"
    /// <summary>
    ///   <para>rdfs:label : hasParty</para>
    ///   <para>rdfs:comment : specifies the party (nyon:Party) associated with nyon:CourtCase^^xsd:string</para>
    ///   <a href="https://w3id.org/def/nyon#hasParty">nyon:hasParty</a>
    /// </summary>
    let hasParty = _prefixId.prefix "hasParty"
    /// <summary>
    ///   <para>rdfs:label : hasPartyType</para>
    ///   <para>rdfs:comment : specifies the type of party (nyon:PartyType) involved in nyon:CourtCase^^xsd:string</para>
    ///   <a href="https://w3id.org/def/nyon#hasPartyType">nyon:hasPartyType</a>
    /// </summary>
    let hasPartyType = _prefixId.prefix "hasPartyType"
    /// <summary>
    ///   <para>rdfs:label : hasPolicePersonnel</para>
    ///   <para>rdfs:comment : specifies the police officer (nyon:PolicePersonnel) doing mentioned in nyon:CourtCase^^xsd:string</para>
    ///   <a href="https://w3id.org/def/nyon#hasPolicePersonnel">nyon:hasPolicePersonnel</a>
    /// </summary>
    let hasPolicePersonnel = _prefixId.prefix "hasPolicePersonnel"
    /// <summary>
    ///   <para>rdfs:label : hasPolicePersonnelName</para>
    ///   <para>rdfs:comment : represents the name of the police personnel involved in the case</para>
    ///   <a href="https://w3id.org/def/nyon#hasPolicePersonnelName">nyon:hasPolicePersonnelName</a>
    /// </summary>
    let hasPolicePersonnelName = _prefixId.prefix "hasPolicePersonnelName"
    /// <summary>
    ///   <para>rdfs:comment : specifies the previous cases of type nyon:CourtCase^^xsd:stringrdfs:comment : represents past cases referred by the judge in the judgment</para>
    ///   <a href="https://w3id.org/def/nyon#hasPrecedent">nyon:hasPrecedent</a>
    /// </summary>
    let hasPrecedent = _prefixId.prefix "hasPrecedent"
    /// <summary>
    ///   <para>rdfs:label : hasProvision</para>
    ///   <para>rdfs:comment : specifies a clause or norm (nyon:Provision) in a legal instrument or a law^^xsd:string</para>
    ///   <a href="https://w3id.org/def/nyon#hasProvision">nyon:hasProvision</a>
    /// </summary>
    let hasProvision = _prefixId.prefix "hasProvision"
    /// <summary>
    ///   <para>rdfs:label : hasRatioDecidendi</para>
    ///   <para>rdfs:comment : specifies the judges ratio of decision (nyon:RatioDecidendi) for nyon:CourtCase^^xsd:string</para>
    ///   <a href="https://w3id.org/def/nyon#hasRatioDecidendi">nyon:hasRatioDecidendi</a>
    /// </summary>
    let hasRatioDecidendi = _prefixId.prefix "hasRatioDecidendi"
    /// <summary>
    ///   <para>rdfs:label : hasRulingOf</para>
    ///   <para>rdfs:comment : specifies the ruling (previous judgments nyon:CourtCase) of the lower court (nyon:Court)^^xsd:string</para>
    ///   <a href="https://w3id.org/def/nyon#hasRulingOf">nyon:hasRulingOf</a>
    /// </summary>
    let hasRulingOf = _prefixId.prefix "hasRulingOf"
    /// <summary>
    ///   <para>rdfs:label : hasStatue</para>
    ///   <para>rdfs:comment : specifies the statute (nyon:Statute) mentioned in nyon:CourtCase^^xsd:string</para>
    ///   <a href="https://w3id.org/def/nyon#hasStatue">nyon:hasStatue</a>
    /// </summary>
    let hasStatue = _prefixId.prefix "hasStatue"
    /// <summary>
    ///   <para>rdfs:label : hasWitness</para>
    ///   <para>rdfs:comment : specifies the witness (nyon:Witness) mentioned in nyon:CourtCase^^xsd:string</para>
    ///   <a href="https://w3id.org/def/nyon#hasWitness">nyon:hasWitness</a>
    /// </summary>
    let hasWitness = _prefixId.prefix "hasWitness"
    /// <summary>
    ///   <para>rdfs:label : hasWordPhrase</para>
    ///   <para>rdfs:comment : specifies the phrases and words (specially nyon:Issue) mentioned in nyon:CourtCase^^xsd:string</para>
    ///   <a href="https://w3id.org/def/nyon#hasWordPhrase">nyon:hasWordPhrase</a>
    /// </summary>
    let hasWordPhrase = _prefixId.prefix "hasWordPhrase"
    /// <summary>
    ///   <para>rdfs:label : hasWords</para>
    ///   <para>rdfs:comment : signifies the domain words, facts and issue related words in the case^^xsd:string</para>
    ///   <a href="https://w3id.org/def/nyon#hasWords">nyon:hasWords</a>
    /// </summary>
    let hasWords = _prefixId.prefix "hasWords"
    /// <summary>
    ///   <para>rdfs:label : hasYear</para>
    ///   <a href="https://w3id.org/def/nyon#hasYear">nyon:hasYear</a>
    /// </summary>
    let hasYear = _prefixId.prefix "hasYear"
    /// <summary>
    ///   <para>rdfs:label : issueSequenceNum</para>
    ///   <a href="https://w3id.org/def/nyon#issueSequenceNum">nyon:issueSequenceNum</a>
    /// </summary>
    let issueSequenceNum = _prefixId.prefix "issueSequenceNum"
    /// <summary>
    ///   <para>rdfs:label : issueValue</para>
    ///   <a href="https://w3id.org/def/nyon#issueValue">nyon:issueValue</a>
    /// </summary>
    let issueValue = _prefixId.prefix "issueValue"
    /// <summary>
    ///   <para>rdfs:label : lastName</para>
    ///   <a href="https://w3id.org/def/nyon#lastName">nyon:lastName</a>
    /// </summary>
    let lastName = _prefixId.prefix "lastName"
    /// <summary>
    ///   <para>rdfs:label : locationName</para>
    ///   <a href="https://w3id.org/def/nyon#locationName">nyon:locationName</a>
    /// </summary>
    let locationName = _prefixId.prefix "locationName"
    /// <summary>
    ///   <para>rdfs:label : makeArgument</para>
    ///   <para>rdfs:comment : specifies the arguments done in nyon:CourtCase by some party (nyon:Party)^^xsd:string</para>
    ///   <a href="https://w3id.org/def/nyon#makeArgument">nyon:makeArgument</a>
    /// </summary>
    let makeArgument = _prefixId.prefix "makeArgument"
    /// <summary>
    ///   <para>rdfs:comment : represents neutral citations given by the court itself</para>
    ///   <a href="https://w3id.org/def/nyon#neutralCitations">nyon:neutralCitations</a>
    /// </summary>
    let neutralCitations = _prefixId.prefix "neutralCitations"
    /// <summary>
    ///   <para>rdfs:label : obiterDictumSequenceNum</para>
    ///   <a href="https://w3id.org/def/nyon#obiterDictumSequenceNum">nyon:obiterDictumSequenceNum</a>
    /// </summary>
    let obiterDictumSequenceNum = _prefixId.prefix "obiterDictumSequenceNum"
    /// <summary>
    ///   <para>rdfs:label : obiterDictumValue</para>
    ///   <a href="https://w3id.org/def/nyon#obiterDictumValue">nyon:obiterDictumValue</a>
    /// </summary>
    let obiterDictumValue = _prefixId.prefix "obiterDictumValue"
    /// <summary>
    ///   <para>rdfs:label : partyName</para>
    ///   <a href="https://w3id.org/def/nyon#partyName">nyon:partyName</a>
    /// </summary>
    let partyName = _prefixId.prefix "partyName"
    /// <summary>
    ///   <para>rdfs:label : petitionerArgument^^xsd:string</para>
    ///   <para>rdfs:comment : specifies the argument made by the Petitioner (nyon:Petitioner) of nyon:CourtCase^^xsd:string</para>
    ///   <a href="https://w3id.org/def/nyon#petitionerArgument">nyon:petitionerArgument</a>
    /// </summary>
    let petitionerArgument = _prefixId.prefix "petitionerArgument"
    /// <summary>
    ///   <para>rdfs:label : plaintiffArgument^^xsd:string</para>
    ///   <para>rdfs:comment : specifies the argument made by the plaintiff (nyon:Plaintiff) of nyon:CourtCase^^xsd:string</para>
    ///   <a href="https://w3id.org/def/nyon#plaintiffArgument">nyon:plaintiffArgument</a>
    /// </summary>
    let plaintiffArgument = _prefixId.prefix "plaintiffArgument"
    /// <summary>
    ///   <para>rdfs:label : precedentOverruled</para>
    ///   <para>rdfs:comment : specifies the past cases (nyon:CourtCase) overruled by the judge in the current case^^xsd:string</para>
    ///   <a href="https://w3id.org/def/nyon#precedentOverruled">nyon:precedentOverruled</a>
    /// </summary>
    let precedentOverruled = _prefixId.prefix "precedentOverruled"
    /// <summary>
    ///   <para>rdfs:label : precedentReliedUpon</para>
    ///   <para>rdfs:comment : specifies the past cases (nyon:CourtCase) referred by the judge on which the current judgment relies on^^xsd:string</para>
    ///   <a href="https://w3id.org/def/nyon#precedentReliedUpon">nyon:precedentReliedUpon</a>
    /// </summary>
    let precedentReliedUpon = _prefixId.prefix "precedentReliedUpon"
    /// <summary>
    ///   <para>rdfs:label : precedentNotReliedUpon</para>
    ///   <para>rdfs:comment : specifies the previous cases (nyon:CourtCase) referred by the judge on which the case decision does not rely on^^xsd:string</para>
    ///   <a href="https://w3id.org/def/nyon#precendentNotReliedUpon">nyon:precendentNotReliedUpon</a>
    /// </summary>
    let precendentNotReliedUpon = _prefixId.prefix "precendentNotReliedUpon"
    /// <summary>
    ///   <para>rdfs:label : ratioDecidendiSequenceNum</para>
    ///   <a href="https://w3id.org/def/nyon#ratioDecidendiSequenceNum">nyon:ratioDecidendiSequenceNum</a>
    /// </summary>
    let ratioDecidendiSequenceNum = _prefixId.prefix "ratioDecidendiSequenceNum"
    /// <summary>
    ///   <para>rdfs:label : ratioDecidendiValue</para>
    ///   <a href="https://w3id.org/def/nyon#ratioDecidendiValue">nyon:ratioDecidendiValue</a>
    /// </summary>
    let ratioDecidendiValue = _prefixId.prefix "ratioDecidendiValue"
    /// <summary>
    ///   <para>rdfs:label : respondentArgument^^xsd:string</para>
    ///   <para>rdfs:comment : specifies the argument made by the respondent (nyon:Respondent) of nyon:CourtCase^^xsd:string</para>
    ///   <a href="https://w3id.org/def/nyon#respondentArgument">nyon:respondentArgument</a>
    /// </summary>
    let respondentArgument = _prefixId.prefix "respondentArgument"
    let value = _prefixId.prefix "value"
    /// <summary>
    ///   <para>rdfs:label : wFirstName</para>
    ///   <a href="https://w3id.org/def/nyon#wFirstName">nyon:wFirstName</a>
    /// </summary>
    let wFirstName = _prefixId.prefix "wFirstName"
    /// <summary>
    ///   <para>rdfs:label : wLastName</para>
    ///   <a href="https://w3id.org/def/nyon#wLastName">nyon:wLastName</a>
    /// </summary>
    let wLastName = _prefixId.prefix "wLastName"
    /// <summary>
    ///   <para>rdfs:label : withConcurrence</para>
    ///   <para>rdfs:comment : specifies the judge (nyon:Judge) gives the opinion in concurrence (nyon:Concurrence) of the court^^xsd:string</para>
    ///   <a href="https://w3id.org/def/nyon#withConcurrence">nyon:withConcurrence</a>
    /// </summary>
    let withConcurrence = _prefixId.prefix "withConcurrence"
    /// <summary>
    ///   <para>rdfs:label : withDissent</para>
    ///   <para>rdfs:comment : specifies the judge (nyon:Judge) gives the opinion in dissent (nyon:Dissent) of the court^^xsd:string</para>
    ///   <a href="https://w3id.org/def/nyon#withDissent">nyon:withDissent</a>
    /// </summary>
    let withDissent = _prefixId.prefix "withDissent"
    /// <summary>
    ///   <para>rdfs:label : withMajority</para>
    ///   <para>rdfs:comment : specifies the judge (nyon:Judge) gives the opinion in majority (nyon:Majority) of the court^^xsd:string</para>
    ///   <a href="https://w3id.org/def/nyon#withMajority">nyon:withMajority</a>
    /// </summary>
    let withMajority = _prefixId.prefix "withMajority"
    /// <summary>
    ///   <para>rdfs:label : withOpinion</para>
    ///   <para>rdfs:comment : represnts the judge opinion on the case either with majority, dissent or concurrence</para>
    ///   <a href="https://w3id.org/def/nyon#withOpinion">nyon:withOpinion</a>
    /// </summary>
    let withOpinion = _prefixId.prefix "withOpinion"
    /// <summary>
    ///   <para>rdfs:label : witnessName</para>
    ///   <a href="https://w3id.org/def/nyon#witnessName">nyon:witnessName</a>
    /// </summary>
    let witnessName = _prefixId.prefix "witnessName"
    /// <summary>
    ///   <para>rdfs:label : witnessStatement</para>
    ///   <a href="https://w3id.org/def/nyon#witnessStatement">nyon:witnessStatement</a>
    /// </summary>
    let witnessStatement = _prefixId.prefix "witnessStatement"
    /// <summary>
    ///   <para>rdfs:label : wordPhraseValue</para>
    ///   <a href="https://w3id.org/def/nyon#wordPhraseValue">nyon:wordPhraseValue</a>
    /// </summary>
    let wordPhraseValue = _prefixId.prefix "wordPhraseValue"
    /// <summary>
    ///   <para>rdfs:label : worksIn</para>
    ///   <para>rdfs:comment : specifies the judge (nyon:Judge) working in court (nyon:Court)^^xsd:string</para>
    ///   <a href="https://w3id.org/def/nyon#worksIn">nyon:worksIn</a>
    /// </summary>
    let worksIn = _prefixId.prefix "worksIn"
