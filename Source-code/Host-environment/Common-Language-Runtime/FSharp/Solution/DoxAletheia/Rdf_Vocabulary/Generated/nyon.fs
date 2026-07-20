namespace https.w3id.org.def.nyon.hash

open DoxAletheia

module nyon =
    let _namespace_name = "https://w3id.org/def/nyon#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// represnts the judge opinion on the case either with majority, dissent or concurrence
    /// <see href="https://w3id.org/def/nyon#withOpinion"></see></summary>
    let withOpinion = _prefix "withOpinion"
    /// <summary>
    /// specifies the nyon:CourtCase being cited by nyon:CourtCase
    /// <see href="https://w3id.org/def/nyon#citedBy"></see></summary>
    let citedBy = _prefix "citedBy"
    /// <summary>
    /// specifies the nyon:CourtCase is citing another nyon:CourtCase
    /// <see href="https://w3id.org/def/nyon#cites"></see></summary>
    let cites = _prefix "cites"
    /// <summary>
    /// specifies an author (nyon:Author) (any judge (nyon:Judge) from the bench) of the nyon:CourtCase
    /// <see href="https://w3id.org/def/nyon#hasAuthor"></see></summary>
    let hasAuthor = _prefix "hasAuthor"
    /// <summary>
    /// specifies the bench associated with nyon:Bench of the nyon:CourtCase
    /// <see href="https://w3id.org/def/nyon#hasBench"></see></summary>
    let hasBench = _prefix "hasBench"
    /// <summary>
    /// specifies the court official represented with nyon:CourtOfficial connected to the nyon:CourtCase
    /// <see href="https://w3id.org/def/nyon#hasCourtOfficial"></see></summary>
    let hasCourtOfficial = _prefix "hasCourtOfficial"
    /// <summary>
    /// specifies the date of the judgment of the nyon:CourtCase
    /// <see href="https://w3id.org/def/nyon#hasDateOfJudgment"></see></summary>
    let hasDateOfJudgment = _prefix "hasDateOfJudgment"
    /// <summary>
    /// specifies the evidence associated with the nyon:Evidence instance for the nyon:CourtCase
    /// <see href="https://w3id.org/def/nyon#hasEvidence"></see></summary>
    let hasEvidence = _prefix "hasEvidence"
    /// <summary>
    /// specifies the fact associated with nyon:Fact belonging to a specific nyon:CourtCase
    /// <see href="https://w3id.org/def/nyon#hasFact"></see></summary>
    let hasFact = _prefix "hasFact"
    /// <summary>
    /// specifies the final verdict associated with the nyon:CourtCase
    /// <see href="https://w3id.org/def/nyon#hasFinalDecision"></see></summary>
    let hasFinalDecision = _prefix "hasFinalDecision"
    /// <summary>
    /// specifies the type of judgment (nyon:CaseType) for nyon:CourtCase
    /// <see href="https://w3id.org/def/nyon#hasJudgmentType"></see></summary>
    let hasJudgmentType = _prefix "hasJudgmentType"
    /// <summary>
    /// specifies the obiter dicta associated with nyon:ObiterDictum mentioned in nyon:CourtCase
    /// <see href="https://w3id.org/def/nyon#hasObiterDictum"></see></summary>
    let hasObiterDictum = _prefix "hasObiterDictum"
    /// <summary>
    /// specifies the party (nyon:Party) associated with nyon:CourtCase
    /// <see href="https://w3id.org/def/nyon#hasParty"></see></summary>
    let hasParty = _prefix "hasParty"
    /// <summary>
    /// specifies the police officer (nyon:PolicePersonnel) doing mentioned in nyon:CourtCase
    /// <see href="https://w3id.org/def/nyon#hasPolicePersonnel"></see></summary>
    let hasPolicePersonnel = _prefix "hasPolicePersonnel"
    /// <summary>
    /// specifies the judges ratio of decision (nyon:RatioDecidendi) for nyon:CourtCase
    /// <see href="https://w3id.org/def/nyon#hasRatioDecidendi"></see></summary>
    let hasRatioDecidendi = _prefix "hasRatioDecidendi"
    /// <summary>
    /// specifies the ruling (previous judgments nyon:CourtCase) of the lower court (nyon:Court)
    /// <see href="https://w3id.org/def/nyon#hasRulingOf"></see></summary>
    let hasRulingOf = _prefix "hasRulingOf"
    /// <summary>
    /// specifies the statute (nyon:Statute) mentioned in nyon:CourtCase
    /// <see href="https://w3id.org/def/nyon#hasStatue"></see></summary>
    let hasStatue = _prefix "hasStatue"
    /// <summary>
    /// specifies the witness (nyon:Witness) mentioned in nyon:CourtCase
    /// <see href="https://w3id.org/def/nyon#hasWitness"></see></summary>
    let hasWitness = _prefix "hasWitness"
    /// <summary>
    /// specifies the phrases and words (specially nyon:Issue) mentioned in nyon:CourtCase
    /// <see href="https://w3id.org/def/nyon#hasWordPhrase"></see></summary>
    let hasWordPhrase = _prefix "hasWordPhrase"
    /// <summary>
    /// signifies the domain words, facts and issue related words in the case
    /// <see href="https://w3id.org/def/nyon#hasWords"></see></summary>
    let hasWords = _prefix "hasWords"
    /// <summary>
    /// decisions result when a judge agrees with the ultimate conclusion made by the majority of the court but disagrees on how they reached that decision
    /// <see href="https://w3id.org/def/nyon#Concurrence"></see></summary>
    let Concurrence = _prefix "Concurrence"
    /// <summary>
    /// judges who do not agree with the majority of the Court
    /// <see href="https://w3id.org/def/nyon#Dissent"></see></summary>
    let Dissent = _prefix "Dissent"
    /// <summary>
    /// Majority decisions are the ones where a majority of the judges agree
    /// <see href="https://w3id.org/def/nyon#Majority"></see></summary>
    let Majority = _prefix "Majority"
    /// <summary>
    /// specifies the argument made by the respondent (nyon:Respondent) of nyon:CourtCase
    /// <see href="https://w3id.org/def/nyon#respondentArgument"></see></summary>
    let respondentArgument = _prefix "respondentArgument"
    /// <summary>
    /// specifies the judicial body (nyon:Judge) of nyon:CourtCase
    /// <see href="https://w3id.org/def/nyon#hasJudge"></see></summary>
    let hasJudge = _prefix "hasJudge"
    /// <summary>
    /// specifies the judge (nyon:Judge) gives the opinion in majority (nyon:Majority) of the court
    /// <see href="https://w3id.org/def/nyon#withMajority"></see></summary>
    let withMajority = _prefix "withMajority"
    /// <summary>
    /// represents the court judgment given by a court of law
    /// <see href="https://w3id.org/def/nyon#CourtCase"></see></summary>
    let CourtCase = _prefix "CourtCase"
    /// <summary>
    /// one who makes the petition
    /// <see href="https://w3id.org/def/nyon#Petitioner"></see></summary>
    let Petitioner = _prefix "Petitioner"
    /// <summary>
    /// specifies the arguments done in nyon:CourtCase by some party (nyon:Party)
    /// <see href="https://w3id.org/def/nyon#makeArgument"></see></summary>
    let makeArgument = _prefix "makeArgument"
    /// <summary>
    /// Argument made by any of the party
    /// <see href="https://w3id.org/def/nyon#Argument"></see></summary>
    let Argument = _prefix "Argument"
    /// <summary>
    /// lower court at metropolitan level after High Courts for civil cases
    /// <see href="https://w3id.org/def/nyon#City_Civil_Courts"></see></summary>
    let City_Civil_Courts = _prefix "City_Civil_Courts"
    /// <summary>
    /// lowest court after City Civil Courts at metropolitan level for civil cases
    /// <see href="https://w3id.org/def/nyon#Courts_of_Smaller_Causes"></see></summary>
    let Courts_of_Smaller_Causes = _prefix "Courts_of_Smaller_Causes"
    /// <summary>
    /// a term in judicial system in India in which a case is heard and judged by at least 2 judges
    /// <see href="https://w3id.org/def/nyon#District_Court"></see></summary>
    let District_Court = _prefix "District_Court"
    /// <summary>
    /// lowest court in heirarchy for civil ases at district level after Principal Junior Civil Court
    /// <see href="https://w3id.org/def/nyon#Munsif_Court"></see></summary>
    let Munsif_Court = _prefix "Munsif_Court"
    /// <summary>
    /// third lower court in hierarchy at district level for civil cases
    /// <see href="https://w3id.org/def/nyon#Principal_Junior_Civil_Court"></see></summary>
    let Principal_Junior_Civil_Court = _prefix "Principal_Junior_Civil_Court"
    /// <summary>
    /// second lower court in hierarchy at District level for civil cases
    /// <see href="https://w3id.org/def/nyon#Sub_Court"></see></summary>
    let Sub_Court = _prefix "Sub_Court"
    /// <summary>
    /// specifies the past cases (nyon:CourtCase) overruled by the judge in the current case
    /// <see href="https://w3id.org/def/nyon#precedentOverruled"></see></summary>
    let precedentOverruled = _prefix "precedentOverruled"
    /// <summary>
    /// specifies the past cases (nyon:CourtCase) referred by the judge on which the current judgment relies on
    /// <see href="https://w3id.org/def/nyon#precedentReliedUpon"></see></summary>
    let precedentReliedUpon = _prefix "precedentReliedUpon"
    /// <summary>
    /// specifies the previous cases (nyon:CourtCase) referred by the judge on which the case decision does not rely on
    /// <see href="https://w3id.org/def/nyon#precendentNotReliedUpon"></see></summary>
    let precendentNotReliedUpon = _prefix "precendentNotReliedUpon"
    /// <summary>
    /// A country
    /// <see href="https://w3id.org/def/nyon#Country"></see></summary>
    let Country = _prefix "Country"
    /// <summary>
    /// represents district name/location
    /// <see href="https://w3id.org/def/nyon#District"></see></summary>
    let District = _prefix "District"
    /// <summary>
    /// represents state name/location
    /// <see href="https://w3id.org/def/nyon#State"></see></summary>
    let State = _prefix "State"
    /// <summary>
    /// represents taluka name/location
    /// <see href="https://w3id.org/def/nyon#Taluka"></see></summary>
    let Taluka = _prefix "Taluka"
    /// <summary>
    /// jurisdiction type is a advisory jurisdiction
    /// <see href="https://w3id.org/def/nyon#Advisory_Jurisdiction"></see></summary>
    let Advisory_Jurisdiction = _prefix "Advisory_Jurisdiction"
    /// <summary>
    /// jurisdiction type is a appellant jurisdiction
    /// <see href="https://w3id.org/def/nyon#Appellant_Jurisdiction"></see></summary>
    let Appellant_Jurisdiction = _prefix "Appellant_Jurisdiction"
    /// <summary>
    /// jurisdiction type is a original jurisdiction
    /// <see href="https://w3id.org/def/nyon#Original_Jurisdiction"></see></summary>
    let Original_Jurisdiction = _prefix "Original_Jurisdiction"
    /// <summary>
    /// jurisdiction type is a review jurisdiction
    /// <see href="https://w3id.org/def/nyon#Review_Jurisdiction"></see></summary>
    let Review_Jurisdiction = _prefix "Review_Jurisdiction"
    /// <summary>
    /// party called upon to respond or answer a petition, a cliam or a appeal
    /// <see href="https://w3id.org/def/nyon#Respondent"></see></summary>
    let Respondent = _prefix "Respondent"
    /// <summary>
    /// specifies the judge (nyon:Judge) gives the opinion in concurrence (nyon:Concurrence) of the court
    /// <see href="https://w3id.org/def/nyon#withConcurrence"></see></summary>
    let withConcurrence = _prefix "withConcurrence"
    /// <summary>
    /// specifies the argument made by the appellant (nyon:Appellant) of nyon:CourtCase
    /// <see href="https://w3id.org/def/nyon#appellantArgument"></see></summary>
    let appellantArgument = _prefix "appellantArgument"
    /// <summary>
    /// specifies the argument made by the defendant (nyon:Defendant) of nyon:CourtCase
    /// <see href="https://w3id.org/def/nyon#defendentArgument"></see></summary>
    let defendentArgument = _prefix "defendentArgument"
    /// <summary>
    /// specifies the argument made by the Petitioner (nyon:Petitioner) of nyon:CourtCase
    /// <see href="https://w3id.org/def/nyon#petitionerArgument"></see></summary>
    let petitionerArgument = _prefix "petitionerArgument"
    /// <summary>
    /// specifies the argument made by the plaintiff (nyon:Plaintiff) of nyon:CourtCase
    /// <see href="https://w3id.org/def/nyon#plaintiffArgument"></see></summary>
    let plaintiffArgument = _prefix "plaintiffArgument"
    /// <summary>
    /// A police officer is a warranted law employee of a police force
    /// <see href="https://w3id.org/def/nyon#Investigator"></see></summary>
    let Investigator = _prefix "Investigator"
    /// <summary>
    /// represents the judge of the case
    /// <see href="https://w3id.org/def/nyon#Judge"></see></summary>
    let Judge = _prefix "Judge"
    /// <summary>
    /// represents solicitor, learned counsel or laywer of the case
    /// <see href="https://w3id.org/def/nyon#Solicitor"></see></summary>
    let Solicitor = _prefix "Solicitor"
    /// <summary>
    /// party of the case are the group of people on one side against another group of people or individual or state
    /// <see href="https://w3id.org/def/nyon#Group"></see></summary>
    let Group = _prefix "Group"
    /// <summary>
    /// participants of the case are the individual persons
    /// <see href="https://w3id.org/def/nyon#Individual"></see></summary>
    let Individual = _prefix "Individual"
    /// <summary>
    /// specifies the judge (nyon:Judge) gives the opinion in dissent (nyon:Dissent) of the court
    /// <see href="https://w3id.org/def/nyon#withDissent"></see></summary>
    let withDissent = _prefix "withDissent"
    /// <summary>
    /// lower court at metropolitan level after Sessions Court for criminal cases
    /// <see href="https://w3id.org/def/nyon#Chief_Meterpolitan_Court"></see></summary>
    let Chief_Meterpolitan_Court = _prefix "Chief_Meterpolitan_Court"
    /// <summary>
    /// lowest court after Chief Metropolitan Court at metropolitan level for criminal cases
    /// <see href="https://w3id.org/def/nyon#Metropolitan_Magistrate_Courts"></see></summary>
    let Metropolitan_Magistrate_Courts = _prefix "Metropolitan_Magistrate_Courts"
    /// <summary>
    /// lower court at both distrcit and metropolitan level after High Courts specific for criminal cases
    /// <see href="https://w3id.org/def/nyon#Session_Court"></see></summary>
    let Session_Court = _prefix "Session_Court"

    /// <summary>
    /// second lower court at distrcit level after districit level Session Court for criminal cases
    /// <see href="https://w3id.org/def/nyon#Judicial_Magistrate_Court(First_Class)"></see></summary>
    let ``Judicial_Magistrate_Court(First_Class)`` =
        _prefix "Judicial_Magistrate_Court(First_Class)"

    /// <summary>
    /// lowest court after Judicial Magistrate Court (First Class) at distrcit level for criminal cases
    /// <see href="https://w3id.org/def/nyon#Judicial_Magistrate_Court(Second_Class)"></see></summary>
    let ``Judicial_Magistrate_Court(Second_Class)`` =
        _prefix "Judicial_Magistrate_Court(Second_Class)"

    /// <summary>
    ///   <see href="https://w3id.org/def/nyon#hasDate"></see>
    /// </summary>
    let hasDate = _prefix "hasDate"
    /// <summary>
    ///   <see href="https://w3id.org/def/nyon#hasMonth"></see>
    /// </summary>
    let hasMonth = _prefix "hasMonth"
    /// <summary>
    ///   <see href="https://w3id.org/def/nyon#hasYear"></see>
    /// </summary>
    let hasYear = _prefix "hasYear"
    /// <summary>
    ///   <see href="https://w3id.org/def/nyon#argumentSequenceNum"></see>
    /// </summary>
    let argumentSequenceNum = _prefix "argumentSequenceNum"
    /// <summary>
    ///   <see href="https://w3id.org/def/nyon#argumentValue"></see>
    /// </summary>
    let argumentValue = _prefix "argumentValue"
    /// <summary>
    ///   <see href="https://w3id.org/def/nyon#catchwordValue"></see>
    /// </summary>
    let catchwordValue = _prefix "catchwordValue"
    /// <summary>
    ///   <see href="https://w3id.org/def/nyon#courtName"></see>
    /// </summary>
    let courtName = _prefix "courtName"
    /// <summary>
    ///   <see href="https://w3id.org/def/nyon#courtOffName"></see>
    /// </summary>
    let courtOffName = _prefix "courtOffName"
    /// <summary>
    ///   <see href="https://w3id.org/def/nyon#dateOfJudgment"></see>
    /// </summary>
    let dateOfJudgment = _prefix "dateOfJudgment"
    /// <summary>
    ///   <see href="https://w3id.org/def/nyon#evidenceLocation"></see>
    /// </summary>
    let evidenceLocation = _prefix "evidenceLocation"
    /// <summary>
    ///   <see href="https://w3id.org/def/nyon#factSequenceNum"></see>
    /// </summary>
    let factSequenceNum = _prefix "factSequenceNum"
    /// <summary>
    ///   <see href="https://w3id.org/def/nyon#factValue"></see>
    /// </summary>
    let factValue = _prefix "factValue"
    /// <summary>
    ///   <see href="https://w3id.org/def/nyon#finalDecisionValue"></see>
    /// </summary>
    let finalDecisionValue = _prefix "finalDecisionValue"
    /// <summary>
    /// Case has a unique ID
    /// <see href="https://w3id.org/def/nyon#hasCaseID"></see></summary>
    let hasCaseID = _prefix "hasCaseID"
    /// <summary>
    /// represents the name of a case usually contains the name of both the parties
    /// <see href="https://w3id.org/def/nyon#hasCaseName"></see></summary>
    let hasCaseName = _prefix "hasCaseName"
    /// <summary>
    ///   <see href="https://w3id.org/def/nyon#hasDesignation"></see>
    /// </summary>
    let hasDesignation = _prefix "hasDesignation"
    /// <summary>
    /// represents the name of the police personnel involved in the case
    /// <see href="https://w3id.org/def/nyon#hasPolicePersonnelName"></see></summary>
    let hasPolicePersonnelName = _prefix "hasPolicePersonnelName"
    /// <summary>
    ///   <see href="https://w3id.org/def/nyon#issueSequenceNum"></see>
    /// </summary>
    let issueSequenceNum = _prefix "issueSequenceNum"
    /// <summary>
    ///   <see href="https://w3id.org/def/nyon#issueValue"></see>
    /// </summary>
    let issueValue = _prefix "issueValue"
    /// <summary>
    ///   <see href="https://w3id.org/def/nyon#locationName"></see>
    /// </summary>
    let locationName = _prefix "locationName"
    /// <summary>
    ///   <see href="https://w3id.org/def/nyon#obiterDictumSequenceNum"></see>
    /// </summary>
    let obiterDictumSequenceNum = _prefix "obiterDictumSequenceNum"
    /// <summary>
    ///   <see href="https://w3id.org/def/nyon#obiterDictumValue"></see>
    /// </summary>
    let obiterDictumValue = _prefix "obiterDictumValue"
    /// <summary>
    ///   <see href="https://w3id.org/def/nyon#partyName"></see>
    /// </summary>
    let partyName = _prefix "partyName"
    /// <summary>
    ///   <see href="https://w3id.org/def/nyon#ratioDecidendiSequenceNum"></see>
    /// </summary>
    let ratioDecidendiSequenceNum = _prefix "ratioDecidendiSequenceNum"
    /// <summary>
    ///   <see href="https://w3id.org/def/nyon#ratioDecidendiValue"></see>
    /// </summary>
    let ratioDecidendiValue = _prefix "ratioDecidendiValue"
    /// <summary>
    ///   <see href="https://w3id.org/def/nyon#witnessName"></see>
    /// </summary>
    let witnessName = _prefix "witnessName"
    /// <summary>
    ///   <see href="https://w3id.org/def/nyon#witnessStatement"></see>
    /// </summary>
    let witnessStatement = _prefix "witnessStatement"
    /// <summary>
    ///   <see href="https://w3id.org/def/nyon#wordPhraseValue"></see>
    /// </summary>
    let wordPhraseValue = _prefix "wordPhraseValue"
    /// <summary>
    /// represents the types of party involved in the case viz. individual, organization, govt. etc.
    /// <see href="https://w3id.org/def/nyon#Party_Type"></see></summary>
    let Party_Type = _prefix "Party_Type"
    /// <summary>
    /// represents the location of the courts, etc and also used for evidence locations
    /// <see href="https://w3id.org/def/nyon#Location"></see></summary>
    let Location = _prefix "Location"
    /// <summary>
    /// person against whom an allegation has been made that he has committed an offence, or who is charge with an offence
    /// <see href="https://w3id.org/def/nyon#Accussed"></see></summary>
    let Accussed = _prefix "Accussed"
    /// <summary>
    /// case is a criminal case
    /// <see href="https://w3id.org/def/nyon#Criminal"></see></summary>
    let Criminal = _prefix "Criminal"
    /// <summary>
    /// specifies the law domain (nyon:CaseDomain) the court case (nyon:CourtCase) belongs to
    /// <see href="https://w3id.org/def/nyon#OfDomian"></see></summary>
    let OfDomian = _prefix "OfDomian"
    /// <summary>
    /// party or people involved in the case
    /// <see href="https://w3id.org/def/nyon#Party"></see></summary>
    let Party = _prefix "Party"
    /// <summary>
    /// the extent to which a court of law can exercise its authority over any cases filed across a region
    /// <see href="https://w3id.org/def/nyon#Jurisdiction"></see></summary>
    let Jurisdiction = _prefix "Jurisdiction"
    /// <summary>
    /// party who makes an appeal
    /// <see href="https://w3id.org/def/nyon#Appellant"></see></summary>
    let Appellant = _prefix "Appellant"
    /// <summary>
    /// Author (Judge) who is responsible for a creation of case document
    /// <see href="https://w3id.org/def/nyon#Author"></see></summary>
    let Author = _prefix "Author"
    /// <summary>
    /// Defines the bench of the case.
    /// <see href="https://w3id.org/def/nyon#Bench"></see></summary>
    let Bench = _prefix "Bench"
    /// <summary>
    ///   <see href="https://w3id.org/def/nyon#COFirstName"></see>
    /// </summary>
    let COFirstName = _prefix "COFirstName"
    /// <summary>
    /// legal system related people involved in a case
    /// <see href="https://w3id.org/def/nyon#Court_Official"></see></summary>
    let Court_Official = _prefix "Court_Official"
    /// <summary>
    ///   <see href="https://w3id.org/def/nyon#COLastName"></see>
    /// </summary>
    let COLastName = _prefix "COLastName"
    /// <summary>
    /// case belongs to specific proceeding like civil or criminal
    /// <see href="https://w3id.org/def/nyon#CaseDomain"></see></summary>
    let CaseDomain = _prefix "CaseDomain"
    /// <summary>
    /// classification of types of cases
    /// <see href="https://w3id.org/def/nyon#CaseType"></see></summary>
    let CaseType = _prefix "CaseType"
    /// <summary>
    /// Descriptive words or phrases used to categorise the subject matter of a case along with some keywords representing the issues in the case
    /// <see href="https://w3id.org/def/nyon#CatchWord"></see></summary>
    let CatchWord = _prefix "CatchWord"
    /// <summary>
    /// issues in the case arised by the party
    /// <see href="https://w3id.org/def/nyon#Issue"></see></summary>
    let Issue = _prefix "Issue"
    /// <summary>
    /// courts for crimnial cases
    /// <see href="https://w3id.org/def/nyon#Courts_for_Criminal"></see></summary>
    let Courts_for_Criminal = _prefix "Courts_for_Criminal"
    /// <summary>
    /// court for civil cases
    /// <see href="https://w3id.org/def/nyon#Courts_for_Civil"></see></summary>
    let Courts_for_Civil = _prefix "Courts_for_Civil"
    /// <summary>
    /// case is a civil case
    /// <see href="https://w3id.org/def/nyon#Civil"></see></summary>
    let Civil = _prefix "Civil"
    /// <summary>
    /// judge opinion with respect to case or judgment
    /// <see href="https://w3id.org/def/nyon#Opinion"></see></summary>
    let Opinion = _prefix "Opinion"
    /// <summary>
    /// courts in the judicial system
    /// <see href="https://w3id.org/def/nyon#Court"></see></summary>
    let Court = _prefix "Court"
    /// <summary>
    ///   <see href="https://w3id.org/def/nyon#CourtDecision"></see>
    /// </summary>
    let CourtDecision = _prefix "CourtDecision"
    /// <summary>
    /// signifies the final date on which the judgment is given by the court of law
    /// <see href="https://w3id.org/def/nyon#DateOfJudgment"></see></summary>
    let DateOfJudgment = _prefix "DateOfJudgment"
    /// <summary>
    /// formal order issued by the judges
    /// <see href="https://w3id.org/def/nyon#Decree"></see></summary>
    let Decree = _prefix "Decree"
    /// <summary>
    /// a person sued in the court of law
    /// <see href="https://w3id.org/def/nyon#Defendant"></see></summary>
    let Defendant = _prefix "Defendant"
    /// <summary>
    /// a term in judicial system in India in which a case is heard and judged by at least 2 judges
    /// <see href="https://w3id.org/def/nyon#Division_Bench"></see></summary>
    let Division_Bench = _prefix "Division_Bench"
    /// <summary>
    /// evidences presented in front of the court in the case
    /// <see href="https://w3id.org/def/nyon#Evidence"></see></summary>
    let Evidence = _prefix "Evidence"
    /// <summary>
    /// represents factual statements in the case law
    /// <see href="https://w3id.org/def/nyon#Fact"></see></summary>
    let Fact = _prefix "Fact"
    /// <summary>
    /// court at the state level
    /// <see href="https://w3id.org/def/nyon#High_Court"></see></summary>
    let High_Court = _prefix "High_Court"
    /// <summary>
    /// Judgement given by the judge
    /// <see href="https://w3id.org/def/nyon#Judgement"></see></summary>
    let Judgement = _prefix "Judgement"
    /// <summary>
    /// a term in judicial system in India in which a case is heard and judged by three or five judges
    /// <see href="https://w3id.org/def/nyon#Larger_Bench"></see></summary>
    let Larger_Bench = _prefix "Larger_Bench"
    /// <summary>
    /// Lawyer is a term of reference to the attroneys and advocates collectively in litigation
    /// <see href="https://w3id.org/def/nyon#Lawyer"></see></summary>
    let Lawyer = _prefix "Lawyer"
    /// <summary>
    /// Learned counsel is a term of reference to the lawyers and advocates collectively in litigation
    /// <see href="https://w3id.org/def/nyon#LearnedCounsel"></see></summary>
    let LearnedCounsel = _prefix "LearnedCounsel"
    /// <summary>
    /// court for population more than 10 lakh city
    /// <see href="https://w3id.org/def/nyon#Metropolitian_Courts"></see></summary>
    let Metropolitian_Courts = _prefix "Metropolitian_Courts"
    /// <summary>
    /// additional obersvations, remarks, and opinions made by the judge that are not the part of the reason for the decision
    /// <see href="https://w3id.org/def/nyon#ObiterDictum"></see></summary>
    let ObiterDictum = _prefix "ObiterDictum"
    /// <summary>
    /// order given by the court
    /// <see href="https://w3id.org/def/nyon#Order"></see></summary>
    let Order = _prefix "Order"
    /// <summary>
    /// party who brings the suit in the court of law
    /// <see href="https://w3id.org/def/nyon#Plaintiff"></see></summary>
    let Plaintiff = _prefix "Plaintiff"
    /// <summary>
    /// all the past cases referred in the current judgment b ythe judge
    /// <see href="https://w3id.org/def/nyon#Precedent"></see></summary>
    let Precedent = _prefix "Precedent"
    /// <summary>
    /// specifies the previous cases of type nyon:CourtCase
    /// represents past cases referred by the judge in the judgment
    /// <see href="https://w3id.org/def/nyon#hasPrecedent"></see></summary>
    let hasPrecedent = _prefix "hasPrecedent"
    /// <summary>
    /// clause or section number or article number applied/used in the case law
    /// <see href="https://w3id.org/def/nyon#Provision"></see></summary>
    let Provision = _prefix "Provision"
    /// <summary>
    /// the rationale for the decision
    /// <see href="https://w3id.org/def/nyon#RatioDecidendi"></see></summary>
    let RatioDecidendi = _prefix "RatioDecidendi"
    /// <summary>
    /// a case heard and judged by a single judge
    /// <see href="https://w3id.org/def/nyon#Single_Judge"></see></summary>
    let Single_Judge = _prefix "Single_Judge"
    /// <summary>
    /// means the Bench constituted by or under the orders of the Chief Justice to hear a case or particular class of cases
    /// <see href="https://w3id.org/def/nyon#Special_Bench"></see></summary>
    let Special_Bench = _prefix "Special_Bench"
    /// <summary>
    /// includes the acts and norms of the law
    /// <see href="https://w3id.org/def/nyon#Statue"></see></summary>
    let Statue = _prefix "Statue"
    /// <summary>
    /// institutions established for discharging judicial or quasi-judicial duties under the Government of India
    /// <see href="https://w3id.org/def/nyon#Tribunal"></see></summary>
    let Tribunal = _prefix "Tribunal"
    /// <summary>
    /// highest court in the judicial system
    /// <see href="https://w3id.org/def/nyon#SupremeCourt"></see></summary>
    let SupremeCourt = _prefix "SupremeCourt"
    /// <summary>
    /// Bench deals with tribunals cases
    /// <see href="https://w3id.org/def/nyon#Tribunal_Bench"></see></summary>
    let Tribunal_Bench = _prefix "Tribunal_Bench"
    /// <summary>
    /// witness involved/presented in the case
    /// <see href="https://w3id.org/def/nyon#Witness"></see></summary>
    let Witness = _prefix "Witness"
    /// <summary>
    /// words or phrases exctracted from the case to make the search better for the cases or find relevent cases or judgment
    /// <see href="https://w3id.org/def/nyon#WordAndPhrase"></see></summary>
    let WordAndPhrase = _prefix "WordAndPhrase"
    /// <summary>
    /// jurisdiction type is a writ jurisdiction
    /// <see href="https://w3id.org/def/nyon#Writ_Jurisdiction"></see></summary>
    let Writ_Jurisdiction = _prefix "Writ_Jurisdiction"
    /// <summary>
    /// equivalent citations provided by the various law reporters.
    /// <see href="https://w3id.org/def/nyon#equivalentCitation"></see></summary>
    let equivalentCitation = _prefix "equivalentCitation"
    /// <summary>
    /// represents neutral citations given by the court itself
    /// <see href="https://w3id.org/def/nyon#neutralCitations"></see></summary>
    let neutralCitations = _prefix "neutralCitations"
    /// <summary>
    ///   <see href="https://w3id.org/def/nyon#firstName"></see>
    /// </summary>
    let firstName = _prefix "firstName"
    /// <summary>
    ///   <see href="https://w3id.org/def/nyon#lastName"></see>
    /// </summary>
    let lastName = _prefix "lastName"
    /// <summary>
    /// specifies the location of the nyon:Court
    /// <see href="https://w3id.org/def/nyon#hasCourtLoc"></see></summary>
    let hasCourtLoc = _prefix "hasCourtLoc"
    /// <summary>
    /// specifies the evidence location associated with the nyon:Evidence instance for the nyon:CourtCase
    /// <see href="https://w3id.org/def/nyon#hasEvidenceLoc"></see></summary>
    let hasEvidenceLoc = _prefix "hasEvidenceLoc"
    /// <summary>
    /// specifies the issue associated with the nyon:Issue instance mentioned in the nyon:CourtCase
    /// <see href="https://w3id.org/def/nyon#hasIssue"></see></summary>
    let hasIssue = _prefix "hasIssue"
    /// <summary>
    /// specifies the jurisdiction (nyon:Jurisdiction) for nyon:Court
    /// <see href="https://w3id.org/def/nyon#hasJurisdiction"></see></summary>
    let hasJurisdiction = _prefix "hasJurisdiction"
    /// <summary>
    /// specifies the type of party (nyon:PartyType) involved in nyon:CourtCase
    /// <see href="https://w3id.org/def/nyon#hasPartyType"></see></summary>
    let hasPartyType = _prefix "hasPartyType"
    /// <summary>
    /// specifies a clause or norm (nyon:Provision) in a legal instrument or a law
    /// <see href="https://w3id.org/def/nyon#hasProvision"></see></summary>
    let hasProvision = _prefix "hasProvision"
    /// <summary>
    ///   <see href="https://w3id.org/def/nyon#value"></see>
    /// </summary>
    let value = _prefix "value"
    /// <summary>
    ///   <see href="https://w3id.org/def/nyon#wFirstName"></see>
    /// </summary>
    let wFirstName = _prefix "wFirstName"
    /// <summary>
    ///   <see href="https://w3id.org/def/nyon#wLastName"></see>
    /// </summary>
    let wLastName = _prefix "wLastName"
    /// <summary>
    /// specifies the judge (nyon:Judge) working in court (nyon:Court)
    /// <see href="https://w3id.org/def/nyon#worksIn"></see></summary>
    let worksIn = _prefix "worksIn"
