namespace https.w3id.org.def.nyon.hash

open DoxAletheia.Rdf_Vocabulary

module nyon =
    let _namespace_name = "https://w3id.org/def/nyon#"

    /// <summary>
    /// represnts the judge opinion on the case either with majority, dissent or concurrence
    /// <see href="https://w3id.org/def/nyon#withOpinion"></see></summary>
    let withOpinion =
        Namespaced_IRI.parse _namespace_name "withOpinion" |> NamespacedName

    /// <summary>
    /// specifies the nyon:CourtCase being cited by nyon:CourtCase
    /// <see href="https://w3id.org/def/nyon#citedBy"></see></summary>
    let citedBy = Namespaced_IRI.parse _namespace_name "citedBy" |> NamespacedName
    /// <summary>
    /// specifies the nyon:CourtCase is citing another nyon:CourtCase
    /// <see href="https://w3id.org/def/nyon#cites"></see></summary>
    let cites = Namespaced_IRI.parse _namespace_name "cites" |> NamespacedName
    /// <summary>
    /// specifies an author (nyon:Author) (any judge (nyon:Judge) from the bench) of the nyon:CourtCase
    /// <see href="https://w3id.org/def/nyon#hasAuthor"></see></summary>
    let hasAuthor = Namespaced_IRI.parse _namespace_name "hasAuthor" |> NamespacedName
    /// <summary>
    /// specifies the bench associated with nyon:Bench of the nyon:CourtCase
    /// <see href="https://w3id.org/def/nyon#hasBench"></see></summary>
    let hasBench = Namespaced_IRI.parse _namespace_name "hasBench" |> NamespacedName

    /// <summary>
    /// specifies the court official represented with nyon:CourtOfficial connected to the nyon:CourtCase
    /// <see href="https://w3id.org/def/nyon#hasCourtOfficial"></see></summary>
    let hasCourtOfficial =
        Namespaced_IRI.parse _namespace_name "hasCourtOfficial" |> NamespacedName

    /// <summary>
    /// specifies the date of the judgment of the nyon:CourtCase
    /// <see href="https://w3id.org/def/nyon#hasDateOfJudgment"></see></summary>
    let hasDateOfJudgment =
        Namespaced_IRI.parse _namespace_name "hasDateOfJudgment" |> NamespacedName

    /// <summary>
    /// specifies the evidence associated with the nyon:Evidence instance for the nyon:CourtCase
    /// <see href="https://w3id.org/def/nyon#hasEvidence"></see></summary>
    let hasEvidence =
        Namespaced_IRI.parse _namespace_name "hasEvidence" |> NamespacedName

    /// <summary>
    /// specifies the fact associated with nyon:Fact belonging to a specific nyon:CourtCase
    /// <see href="https://w3id.org/def/nyon#hasFact"></see></summary>
    let hasFact = Namespaced_IRI.parse _namespace_name "hasFact" |> NamespacedName

    /// <summary>
    /// specifies the final verdict associated with the nyon:CourtCase
    /// <see href="https://w3id.org/def/nyon#hasFinalDecision"></see></summary>
    let hasFinalDecision =
        Namespaced_IRI.parse _namespace_name "hasFinalDecision" |> NamespacedName

    /// <summary>
    /// specifies the type of judgment (nyon:CaseType) for nyon:CourtCase
    /// <see href="https://w3id.org/def/nyon#hasJudgmentType"></see></summary>
    let hasJudgmentType =
        Namespaced_IRI.parse _namespace_name "hasJudgmentType" |> NamespacedName

    /// <summary>
    /// specifies the obiter dicta associated with nyon:ObiterDictum mentioned in nyon:CourtCase
    /// <see href="https://w3id.org/def/nyon#hasObiterDictum"></see></summary>
    let hasObiterDictum =
        Namespaced_IRI.parse _namespace_name "hasObiterDictum" |> NamespacedName

    /// <summary>
    /// specifies the party (nyon:Party) associated with nyon:CourtCase
    /// <see href="https://w3id.org/def/nyon#hasParty"></see></summary>
    let hasParty = Namespaced_IRI.parse _namespace_name "hasParty" |> NamespacedName

    /// <summary>
    /// specifies the police officer (nyon:PolicePersonnel) doing mentioned in nyon:CourtCase
    /// <see href="https://w3id.org/def/nyon#hasPolicePersonnel"></see></summary>
    let hasPolicePersonnel =
        Namespaced_IRI.parse _namespace_name "hasPolicePersonnel" |> NamespacedName

    /// <summary>
    /// specifies the judges ratio of decision (nyon:RatioDecidendi) for nyon:CourtCase
    /// <see href="https://w3id.org/def/nyon#hasRatioDecidendi"></see></summary>
    let hasRatioDecidendi =
        Namespaced_IRI.parse _namespace_name "hasRatioDecidendi" |> NamespacedName

    /// <summary>
    /// specifies the ruling (previous judgments nyon:CourtCase) of the lower court (nyon:Court)
    /// <see href="https://w3id.org/def/nyon#hasRulingOf"></see></summary>
    let hasRulingOf =
        Namespaced_IRI.parse _namespace_name "hasRulingOf" |> NamespacedName

    /// <summary>
    /// specifies the statute (nyon:Statute) mentioned in nyon:CourtCase
    /// <see href="https://w3id.org/def/nyon#hasStatue"></see></summary>
    let hasStatue = Namespaced_IRI.parse _namespace_name "hasStatue" |> NamespacedName
    /// <summary>
    /// specifies the witness (nyon:Witness) mentioned in nyon:CourtCase
    /// <see href="https://w3id.org/def/nyon#hasWitness"></see></summary>
    let hasWitness = Namespaced_IRI.parse _namespace_name "hasWitness" |> NamespacedName

    /// <summary>
    /// specifies the phrases and words (specially nyon:Issue) mentioned in nyon:CourtCase
    /// <see href="https://w3id.org/def/nyon#hasWordPhrase"></see></summary>
    let hasWordPhrase =
        Namespaced_IRI.parse _namespace_name "hasWordPhrase" |> NamespacedName

    /// <summary>
    /// signifies the domain words, facts and issue related words in the case
    /// <see href="https://w3id.org/def/nyon#hasWords"></see></summary>
    let hasWords = Namespaced_IRI.parse _namespace_name "hasWords" |> NamespacedName

    /// <summary>
    /// decisions result when a judge agrees with the ultimate conclusion made by the majority of the court but disagrees on how they reached that decision
    /// <see href="https://w3id.org/def/nyon#Concurrence"></see></summary>
    let Concurrence =
        Namespaced_IRI.parse _namespace_name "Concurrence" |> NamespacedName

    /// <summary>
    /// judges who do not agree with the majority of the Court
    /// <see href="https://w3id.org/def/nyon#Dissent"></see></summary>
    let Dissent = Namespaced_IRI.parse _namespace_name "Dissent" |> NamespacedName
    /// <summary>
    /// Majority decisions are the ones where a majority of the judges agree
    /// <see href="https://w3id.org/def/nyon#Majority"></see></summary>
    let Majority = Namespaced_IRI.parse _namespace_name "Majority" |> NamespacedName

    /// <summary>
    /// specifies the argument made by the respondent (nyon:Respondent) of nyon:CourtCase
    /// <see href="https://w3id.org/def/nyon#respondentArgument"></see></summary>
    let respondentArgument =
        Namespaced_IRI.parse _namespace_name "respondentArgument" |> NamespacedName

    /// <summary>
    /// specifies the judicial body (nyon:Judge) of nyon:CourtCase
    /// <see href="https://w3id.org/def/nyon#hasJudge"></see></summary>
    let hasJudge = Namespaced_IRI.parse _namespace_name "hasJudge" |> NamespacedName

    /// <summary>
    /// specifies the judge (nyon:Judge) gives the opinion in majority (nyon:Majority) of the court
    /// <see href="https://w3id.org/def/nyon#withMajority"></see></summary>
    let withMajority =
        Namespaced_IRI.parse _namespace_name "withMajority" |> NamespacedName

    /// <summary>
    /// represents the court judgment given by a court of law
    /// <see href="https://w3id.org/def/nyon#CourtCase"></see></summary>
    let CourtCase = Namespaced_IRI.parse _namespace_name "CourtCase" |> NamespacedName
    /// <summary>
    /// one who makes the petition
    /// <see href="https://w3id.org/def/nyon#Petitioner"></see></summary>
    let Petitioner = Namespaced_IRI.parse _namespace_name "Petitioner" |> NamespacedName

    /// <summary>
    /// specifies the arguments done in nyon:CourtCase by some party (nyon:Party)
    /// <see href="https://w3id.org/def/nyon#makeArgument"></see></summary>
    let makeArgument =
        Namespaced_IRI.parse _namespace_name "makeArgument" |> NamespacedName

    /// <summary>
    /// Argument made by any of the party
    /// <see href="https://w3id.org/def/nyon#Argument"></see></summary>
    let Argument = Namespaced_IRI.parse _namespace_name "Argument" |> NamespacedName

    /// <summary>
    /// lower court at metropolitan level after High Courts for civil cases
    /// <see href="https://w3id.org/def/nyon#City_Civil_Courts"></see></summary>
    let City_Civil_Courts =
        Namespaced_IRI.parse _namespace_name "City_Civil_Courts" |> NamespacedName

    /// <summary>
    /// lowest court after City Civil Courts at metropolitan level for civil cases
    /// <see href="https://w3id.org/def/nyon#Courts_of_Smaller_Causes"></see></summary>
    let Courts_of_Smaller_Causes =
        Namespaced_IRI.parse _namespace_name "Courts_of_Smaller_Causes" |> NamespacedName

    /// <summary>
    /// a term in judicial system in India in which a case is heard and judged by at least 2 judges
    /// <see href="https://w3id.org/def/nyon#District_Court"></see></summary>
    let District_Court =
        Namespaced_IRI.parse _namespace_name "District_Court" |> NamespacedName

    /// <summary>
    /// lowest court in heirarchy for civil ases at district level after Principal Junior Civil Court
    /// <see href="https://w3id.org/def/nyon#Munsif_Court"></see></summary>
    let Munsif_Court =
        Namespaced_IRI.parse _namespace_name "Munsif_Court" |> NamespacedName

    /// <summary>
    /// third lower court in hierarchy at district level for civil cases
    /// <see href="https://w3id.org/def/nyon#Principal_Junior_Civil_Court"></see></summary>
    let Principal_Junior_Civil_Court =
        Namespaced_IRI.parse _namespace_name "Principal_Junior_Civil_Court" |> NamespacedName

    /// <summary>
    /// second lower court in hierarchy at District level for civil cases
    /// <see href="https://w3id.org/def/nyon#Sub_Court"></see></summary>
    let Sub_Court = Namespaced_IRI.parse _namespace_name "Sub_Court" |> NamespacedName

    /// <summary>
    /// specifies the past cases (nyon:CourtCase) overruled by the judge in the current case
    /// <see href="https://w3id.org/def/nyon#precedentOverruled"></see></summary>
    let precedentOverruled =
        Namespaced_IRI.parse _namespace_name "precedentOverruled" |> NamespacedName

    /// <summary>
    /// specifies the past cases (nyon:CourtCase) referred by the judge on which the current judgment relies on
    /// <see href="https://w3id.org/def/nyon#precedentReliedUpon"></see></summary>
    let precedentReliedUpon =
        Namespaced_IRI.parse _namespace_name "precedentReliedUpon" |> NamespacedName

    /// <summary>
    /// specifies the previous cases (nyon:CourtCase) referred by the judge on which the case decision does not rely on
    /// <see href="https://w3id.org/def/nyon#precendentNotReliedUpon"></see></summary>
    let precendentNotReliedUpon =
        Namespaced_IRI.parse _namespace_name "precendentNotReliedUpon" |> NamespacedName

    /// <summary>
    /// A country
    /// <see href="https://w3id.org/def/nyon#Country"></see></summary>
    let Country = Namespaced_IRI.parse _namespace_name "Country" |> NamespacedName
    /// <summary>
    /// represents district name/location
    /// <see href="https://w3id.org/def/nyon#District"></see></summary>
    let District = Namespaced_IRI.parse _namespace_name "District" |> NamespacedName
    /// <summary>
    /// represents state name/location
    /// <see href="https://w3id.org/def/nyon#State"></see></summary>
    let State = Namespaced_IRI.parse _namespace_name "State" |> NamespacedName
    /// <summary>
    /// represents taluka name/location
    /// <see href="https://w3id.org/def/nyon#Taluka"></see></summary>
    let Taluka = Namespaced_IRI.parse _namespace_name "Taluka" |> NamespacedName

    /// <summary>
    /// jurisdiction type is a advisory jurisdiction
    /// <see href="https://w3id.org/def/nyon#Advisory_Jurisdiction"></see></summary>
    let Advisory_Jurisdiction =
        Namespaced_IRI.parse _namespace_name "Advisory_Jurisdiction" |> NamespacedName

    /// <summary>
    /// jurisdiction type is a appellant jurisdiction
    /// <see href="https://w3id.org/def/nyon#Appellant_Jurisdiction"></see></summary>
    let Appellant_Jurisdiction =
        Namespaced_IRI.parse _namespace_name "Appellant_Jurisdiction" |> NamespacedName

    /// <summary>
    /// jurisdiction type is a original jurisdiction
    /// <see href="https://w3id.org/def/nyon#Original_Jurisdiction"></see></summary>
    let Original_Jurisdiction =
        Namespaced_IRI.parse _namespace_name "Original_Jurisdiction" |> NamespacedName

    /// <summary>
    /// jurisdiction type is a review jurisdiction
    /// <see href="https://w3id.org/def/nyon#Review_Jurisdiction"></see></summary>
    let Review_Jurisdiction =
        Namespaced_IRI.parse _namespace_name "Review_Jurisdiction" |> NamespacedName

    /// <summary>
    /// party called upon to respond or answer a petition, a cliam or a appeal
    /// <see href="https://w3id.org/def/nyon#Respondent"></see></summary>
    let Respondent = Namespaced_IRI.parse _namespace_name "Respondent" |> NamespacedName

    /// <summary>
    /// specifies the judge (nyon:Judge) gives the opinion in concurrence (nyon:Concurrence) of the court
    /// <see href="https://w3id.org/def/nyon#withConcurrence"></see></summary>
    let withConcurrence =
        Namespaced_IRI.parse _namespace_name "withConcurrence" |> NamespacedName

    /// <summary>
    /// specifies the argument made by the appellant (nyon:Appellant) of nyon:CourtCase
    /// <see href="https://w3id.org/def/nyon#appellantArgument"></see></summary>
    let appellantArgument =
        Namespaced_IRI.parse _namespace_name "appellantArgument" |> NamespacedName

    /// <summary>
    /// specifies the argument made by the defendant (nyon:Defendant) of nyon:CourtCase
    /// <see href="https://w3id.org/def/nyon#defendentArgument"></see></summary>
    let defendentArgument =
        Namespaced_IRI.parse _namespace_name "defendentArgument" |> NamespacedName

    /// <summary>
    /// specifies the argument made by the Petitioner (nyon:Petitioner) of nyon:CourtCase
    /// <see href="https://w3id.org/def/nyon#petitionerArgument"></see></summary>
    let petitionerArgument =
        Namespaced_IRI.parse _namespace_name "petitionerArgument" |> NamespacedName

    /// <summary>
    /// specifies the argument made by the plaintiff (nyon:Plaintiff) of nyon:CourtCase
    /// <see href="https://w3id.org/def/nyon#plaintiffArgument"></see></summary>
    let plaintiffArgument =
        Namespaced_IRI.parse _namespace_name "plaintiffArgument" |> NamespacedName

    /// <summary>
    /// A police officer is a warranted law employee of a police force
    /// <see href="https://w3id.org/def/nyon#Investigator"></see></summary>
    let Investigator =
        Namespaced_IRI.parse _namespace_name "Investigator" |> NamespacedName

    /// <summary>
    /// represents the judge of the case
    /// <see href="https://w3id.org/def/nyon#Judge"></see></summary>
    let Judge = Namespaced_IRI.parse _namespace_name "Judge" |> NamespacedName
    /// <summary>
    /// represents solicitor, learned counsel or laywer of the case
    /// <see href="https://w3id.org/def/nyon#Solicitor"></see></summary>
    let Solicitor = Namespaced_IRI.parse _namespace_name "Solicitor" |> NamespacedName
    /// <summary>
    /// party of the case are the group of people on one side against another group of people or individual or state
    /// <see href="https://w3id.org/def/nyon#Group"></see></summary>
    let Group = Namespaced_IRI.parse _namespace_name "Group" |> NamespacedName
    /// <summary>
    /// participants of the case are the individual persons
    /// <see href="https://w3id.org/def/nyon#Individual"></see></summary>
    let Individual = Namespaced_IRI.parse _namespace_name "Individual" |> NamespacedName

    /// <summary>
    /// specifies the judge (nyon:Judge) gives the opinion in dissent (nyon:Dissent) of the court
    /// <see href="https://w3id.org/def/nyon#withDissent"></see></summary>
    let withDissent =
        Namespaced_IRI.parse _namespace_name "withDissent" |> NamespacedName

    /// <summary>
    /// lower court at metropolitan level after Sessions Court for criminal cases
    /// <see href="https://w3id.org/def/nyon#Chief_Meterpolitan_Court"></see></summary>
    let Chief_Meterpolitan_Court =
        Namespaced_IRI.parse _namespace_name "Chief_Meterpolitan_Court" |> NamespacedName

    /// <summary>
    /// lowest court after Chief Metropolitan Court at metropolitan level for criminal cases
    /// <see href="https://w3id.org/def/nyon#Metropolitan_Magistrate_Courts"></see></summary>
    let Metropolitan_Magistrate_Courts =
        Namespaced_IRI.parse _namespace_name "Metropolitan_Magistrate_Courts" |> NamespacedName

    /// <summary>
    /// lower court at both distrcit and metropolitan level after High Courts specific for criminal cases
    /// <see href="https://w3id.org/def/nyon#Session_Court"></see></summary>
    let Session_Court =
        Namespaced_IRI.parse _namespace_name "Session_Court" |> NamespacedName

    /// <summary>
    /// second lower court at distrcit level after districit level Session Court for criminal cases
    /// <see href="https://w3id.org/def/nyon#Judicial_Magistrate_Court(First_Class)"></see></summary>
    let ``Judicial_Magistrate_Court(First_Class)`` =
        Namespaced_IRI.parse _namespace_name "Judicial_Magistrate_Court(First_Class)" |> NamespacedName

    /// <summary>
    /// lowest court after Judicial Magistrate Court (First Class) at distrcit level for criminal cases
    /// <see href="https://w3id.org/def/nyon#Judicial_Magistrate_Court(Second_Class)"></see></summary>
    let ``Judicial_Magistrate_Court(Second_Class)`` =
        Namespaced_IRI.parse _namespace_name "Judicial_Magistrate_Court(Second_Class)" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/def/nyon#hasDate"></see>
    /// </summary>
    let hasDate = Namespaced_IRI.parse _namespace_name "hasDate" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/def/nyon#hasMonth"></see>
    /// </summary>
    let hasMonth = Namespaced_IRI.parse _namespace_name "hasMonth" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/def/nyon#hasYear"></see>
    /// </summary>
    let hasYear = Namespaced_IRI.parse _namespace_name "hasYear" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/def/nyon#argumentSequenceNum"></see>
    /// </summary>
    let argumentSequenceNum =
        Namespaced_IRI.parse _namespace_name "argumentSequenceNum" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/def/nyon#argumentValue"></see>
    /// </summary>
    let argumentValue =
        Namespaced_IRI.parse _namespace_name "argumentValue" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/def/nyon#catchwordValue"></see>
    /// </summary>
    let catchwordValue =
        Namespaced_IRI.parse _namespace_name "catchwordValue" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/def/nyon#courtName"></see>
    /// </summary>
    let courtName = Namespaced_IRI.parse _namespace_name "courtName" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/def/nyon#courtOffName"></see>
    /// </summary>
    let courtOffName =
        Namespaced_IRI.parse _namespace_name "courtOffName" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/def/nyon#dateOfJudgment"></see>
    /// </summary>
    let dateOfJudgment =
        Namespaced_IRI.parse _namespace_name "dateOfJudgment" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/def/nyon#evidenceLocation"></see>
    /// </summary>
    let evidenceLocation =
        Namespaced_IRI.parse _namespace_name "evidenceLocation" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/def/nyon#factSequenceNum"></see>
    /// </summary>
    let factSequenceNum =
        Namespaced_IRI.parse _namespace_name "factSequenceNum" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/def/nyon#factValue"></see>
    /// </summary>
    let factValue = Namespaced_IRI.parse _namespace_name "factValue" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/def/nyon#finalDecisionValue"></see>
    /// </summary>
    let finalDecisionValue =
        Namespaced_IRI.parse _namespace_name "finalDecisionValue" |> NamespacedName

    /// <summary>
    /// Case has a unique ID
    /// <see href="https://w3id.org/def/nyon#hasCaseID"></see></summary>
    let hasCaseID = Namespaced_IRI.parse _namespace_name "hasCaseID" |> NamespacedName

    /// <summary>
    /// represents the name of a case usually contains the name of both the parties
    /// <see href="https://w3id.org/def/nyon#hasCaseName"></see></summary>
    let hasCaseName =
        Namespaced_IRI.parse _namespace_name "hasCaseName" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/def/nyon#hasDesignation"></see>
    /// </summary>
    let hasDesignation =
        Namespaced_IRI.parse _namespace_name "hasDesignation" |> NamespacedName

    /// <summary>
    /// represents the name of the police personnel involved in the case
    /// <see href="https://w3id.org/def/nyon#hasPolicePersonnelName"></see></summary>
    let hasPolicePersonnelName =
        Namespaced_IRI.parse _namespace_name "hasPolicePersonnelName" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/def/nyon#issueSequenceNum"></see>
    /// </summary>
    let issueSequenceNum =
        Namespaced_IRI.parse _namespace_name "issueSequenceNum" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/def/nyon#issueValue"></see>
    /// </summary>
    let issueValue = Namespaced_IRI.parse _namespace_name "issueValue" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/def/nyon#locationName"></see>
    /// </summary>
    let locationName =
        Namespaced_IRI.parse _namespace_name "locationName" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/def/nyon#obiterDictumSequenceNum"></see>
    /// </summary>
    let obiterDictumSequenceNum =
        Namespaced_IRI.parse _namespace_name "obiterDictumSequenceNum" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/def/nyon#obiterDictumValue"></see>
    /// </summary>
    let obiterDictumValue =
        Namespaced_IRI.parse _namespace_name "obiterDictumValue" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/def/nyon#partyName"></see>
    /// </summary>
    let partyName = Namespaced_IRI.parse _namespace_name "partyName" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/def/nyon#ratioDecidendiSequenceNum"></see>
    /// </summary>
    let ratioDecidendiSequenceNum =
        Namespaced_IRI.parse _namespace_name "ratioDecidendiSequenceNum" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/def/nyon#ratioDecidendiValue"></see>
    /// </summary>
    let ratioDecidendiValue =
        Namespaced_IRI.parse _namespace_name "ratioDecidendiValue" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/def/nyon#witnessName"></see>
    /// </summary>
    let witnessName =
        Namespaced_IRI.parse _namespace_name "witnessName" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/def/nyon#witnessStatement"></see>
    /// </summary>
    let witnessStatement =
        Namespaced_IRI.parse _namespace_name "witnessStatement" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/def/nyon#wordPhraseValue"></see>
    /// </summary>
    let wordPhraseValue =
        Namespaced_IRI.parse _namespace_name "wordPhraseValue" |> NamespacedName

    /// <summary>
    /// represents the types of party involved in the case viz. individual, organization, govt. etc.
    /// <see href="https://w3id.org/def/nyon#Party_Type"></see></summary>
    let Party_Type = Namespaced_IRI.parse _namespace_name "Party_Type" |> NamespacedName
    /// <summary>
    /// represents the location of the courts, etc and also used for evidence locations
    /// <see href="https://w3id.org/def/nyon#Location"></see></summary>
    let Location = Namespaced_IRI.parse _namespace_name "Location" |> NamespacedName
    /// <summary>
    /// person against whom an allegation has been made that he has committed an offence, or who is charge with an offence
    /// <see href="https://w3id.org/def/nyon#Accussed"></see></summary>
    let Accussed = Namespaced_IRI.parse _namespace_name "Accussed" |> NamespacedName
    /// <summary>
    /// case is a criminal case
    /// <see href="https://w3id.org/def/nyon#Criminal"></see></summary>
    let Criminal = Namespaced_IRI.parse _namespace_name "Criminal" |> NamespacedName
    /// <summary>
    /// specifies the law domain (nyon:CaseDomain) the court case (nyon:CourtCase) belongs to
    /// <see href="https://w3id.org/def/nyon#OfDomian"></see></summary>
    let OfDomian = Namespaced_IRI.parse _namespace_name "OfDomian" |> NamespacedName
    /// <summary>
    /// party or people involved in the case
    /// <see href="https://w3id.org/def/nyon#Party"></see></summary>
    let Party = Namespaced_IRI.parse _namespace_name "Party" |> NamespacedName

    /// <summary>
    /// the extent to which a court of law can exercise its authority over any cases filed across a region
    /// <see href="https://w3id.org/def/nyon#Jurisdiction"></see></summary>
    let Jurisdiction =
        Namespaced_IRI.parse _namespace_name "Jurisdiction" |> NamespacedName

    /// <summary>
    /// party who makes an appeal
    /// <see href="https://w3id.org/def/nyon#Appellant"></see></summary>
    let Appellant = Namespaced_IRI.parse _namespace_name "Appellant" |> NamespacedName
    /// <summary>
    /// Author (Judge) who is responsible for a creation of case document
    /// <see href="https://w3id.org/def/nyon#Author"></see></summary>
    let Author = Namespaced_IRI.parse _namespace_name "Author" |> NamespacedName
    /// <summary>
    /// Defines the bench of the case.
    /// <see href="https://w3id.org/def/nyon#Bench"></see></summary>
    let Bench = Namespaced_IRI.parse _namespace_name "Bench" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/def/nyon#COFirstName"></see>
    /// </summary>
    let COFirstName =
        Namespaced_IRI.parse _namespace_name "COFirstName" |> NamespacedName

    /// <summary>
    /// legal system related people involved in a case
    /// <see href="https://w3id.org/def/nyon#Court_Official"></see></summary>
    let Court_Official =
        Namespaced_IRI.parse _namespace_name "Court_Official" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/def/nyon#COLastName"></see>
    /// </summary>
    let COLastName = Namespaced_IRI.parse _namespace_name "COLastName" |> NamespacedName
    /// <summary>
    /// case belongs to specific proceeding like civil or criminal
    /// <see href="https://w3id.org/def/nyon#CaseDomain"></see></summary>
    let CaseDomain = Namespaced_IRI.parse _namespace_name "CaseDomain" |> NamespacedName
    /// <summary>
    /// classification of types of cases
    /// <see href="https://w3id.org/def/nyon#CaseType"></see></summary>
    let CaseType = Namespaced_IRI.parse _namespace_name "CaseType" |> NamespacedName
    /// <summary>
    /// Descriptive words or phrases used to categorise the subject matter of a case along with some keywords representing the issues in the case
    /// <see href="https://w3id.org/def/nyon#CatchWord"></see></summary>
    let CatchWord = Namespaced_IRI.parse _namespace_name "CatchWord" |> NamespacedName
    /// <summary>
    /// issues in the case arised by the party
    /// <see href="https://w3id.org/def/nyon#Issue"></see></summary>
    let Issue = Namespaced_IRI.parse _namespace_name "Issue" |> NamespacedName

    /// <summary>
    /// courts for crimnial cases
    /// <see href="https://w3id.org/def/nyon#Courts_for_Criminal"></see></summary>
    let Courts_for_Criminal =
        Namespaced_IRI.parse _namespace_name "Courts_for_Criminal" |> NamespacedName

    /// <summary>
    /// court for civil cases
    /// <see href="https://w3id.org/def/nyon#Courts_for_Civil"></see></summary>
    let Courts_for_Civil =
        Namespaced_IRI.parse _namespace_name "Courts_for_Civil" |> NamespacedName

    /// <summary>
    /// case is a civil case
    /// <see href="https://w3id.org/def/nyon#Civil"></see></summary>
    let Civil = Namespaced_IRI.parse _namespace_name "Civil" |> NamespacedName
    /// <summary>
    /// judge opinion with respect to case or judgment
    /// <see href="https://w3id.org/def/nyon#Opinion"></see></summary>
    let Opinion = Namespaced_IRI.parse _namespace_name "Opinion" |> NamespacedName
    /// <summary>
    /// courts in the judicial system
    /// <see href="https://w3id.org/def/nyon#Court"></see></summary>
    let Court = Namespaced_IRI.parse _namespace_name "Court" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/def/nyon#CourtDecision"></see>
    /// </summary>
    let CourtDecision =
        Namespaced_IRI.parse _namespace_name "CourtDecision" |> NamespacedName

    /// <summary>
    /// signifies the final date on which the judgment is given by the court of law
    /// <see href="https://w3id.org/def/nyon#DateOfJudgment"></see></summary>
    let DateOfJudgment =
        Namespaced_IRI.parse _namespace_name "DateOfJudgment" |> NamespacedName

    /// <summary>
    /// formal order issued by the judges
    /// <see href="https://w3id.org/def/nyon#Decree"></see></summary>
    let Decree = Namespaced_IRI.parse _namespace_name "Decree" |> NamespacedName
    /// <summary>
    /// a person sued in the court of law
    /// <see href="https://w3id.org/def/nyon#Defendant"></see></summary>
    let Defendant = Namespaced_IRI.parse _namespace_name "Defendant" |> NamespacedName

    /// <summary>
    /// a term in judicial system in India in which a case is heard and judged by at least 2 judges
    /// <see href="https://w3id.org/def/nyon#Division_Bench"></see></summary>
    let Division_Bench =
        Namespaced_IRI.parse _namespace_name "Division_Bench" |> NamespacedName

    /// <summary>
    /// evidences presented in front of the court in the case
    /// <see href="https://w3id.org/def/nyon#Evidence"></see></summary>
    let Evidence = Namespaced_IRI.parse _namespace_name "Evidence" |> NamespacedName
    /// <summary>
    /// represents factual statements in the case law
    /// <see href="https://w3id.org/def/nyon#Fact"></see></summary>
    let Fact = Namespaced_IRI.parse _namespace_name "Fact" |> NamespacedName
    /// <summary>
    /// court at the state level
    /// <see href="https://w3id.org/def/nyon#High_Court"></see></summary>
    let High_Court = Namespaced_IRI.parse _namespace_name "High_Court" |> NamespacedName
    /// <summary>
    /// Judgement given by the judge
    /// <see href="https://w3id.org/def/nyon#Judgement"></see></summary>
    let Judgement = Namespaced_IRI.parse _namespace_name "Judgement" |> NamespacedName

    /// <summary>
    /// a term in judicial system in India in which a case is heard and judged by three or five judges
    /// <see href="https://w3id.org/def/nyon#Larger_Bench"></see></summary>
    let Larger_Bench =
        Namespaced_IRI.parse _namespace_name "Larger_Bench" |> NamespacedName

    /// <summary>
    /// Lawyer is a term of reference to the attroneys and advocates collectively in litigation
    /// <see href="https://w3id.org/def/nyon#Lawyer"></see></summary>
    let Lawyer = Namespaced_IRI.parse _namespace_name "Lawyer" |> NamespacedName

    /// <summary>
    /// Learned counsel is a term of reference to the lawyers and advocates collectively in litigation
    /// <see href="https://w3id.org/def/nyon#LearnedCounsel"></see></summary>
    let LearnedCounsel =
        Namespaced_IRI.parse _namespace_name "LearnedCounsel" |> NamespacedName

    /// <summary>
    /// court for population more than 10 lakh city
    /// <see href="https://w3id.org/def/nyon#Metropolitian_Courts"></see></summary>
    let Metropolitian_Courts =
        Namespaced_IRI.parse _namespace_name "Metropolitian_Courts" |> NamespacedName

    /// <summary>
    /// additional obersvations, remarks, and opinions made by the judge that are not the part of the reason for the decision
    /// <see href="https://w3id.org/def/nyon#ObiterDictum"></see></summary>
    let ObiterDictum =
        Namespaced_IRI.parse _namespace_name "ObiterDictum" |> NamespacedName

    /// <summary>
    /// order given by the court
    /// <see href="https://w3id.org/def/nyon#Order"></see></summary>
    let Order = Namespaced_IRI.parse _namespace_name "Order" |> NamespacedName
    /// <summary>
    /// party who brings the suit in the court of law
    /// <see href="https://w3id.org/def/nyon#Plaintiff"></see></summary>
    let Plaintiff = Namespaced_IRI.parse _namespace_name "Plaintiff" |> NamespacedName
    /// <summary>
    /// all the past cases referred in the current judgment b ythe judge
    /// <see href="https://w3id.org/def/nyon#Precedent"></see></summary>
    let Precedent = Namespaced_IRI.parse _namespace_name "Precedent" |> NamespacedName

    /// <summary>
    /// specifies the previous cases of type nyon:CourtCase
    /// represents past cases referred by the judge in the judgment
    /// <see href="https://w3id.org/def/nyon#hasPrecedent"></see></summary>
    let hasPrecedent =
        Namespaced_IRI.parse _namespace_name "hasPrecedent" |> NamespacedName

    /// <summary>
    /// clause or section number or article number applied/used in the case law
    /// <see href="https://w3id.org/def/nyon#Provision"></see></summary>
    let Provision = Namespaced_IRI.parse _namespace_name "Provision" |> NamespacedName

    /// <summary>
    /// the rationale for the decision
    /// <see href="https://w3id.org/def/nyon#RatioDecidendi"></see></summary>
    let RatioDecidendi =
        Namespaced_IRI.parse _namespace_name "RatioDecidendi" |> NamespacedName

    /// <summary>
    /// a case heard and judged by a single judge
    /// <see href="https://w3id.org/def/nyon#Single_Judge"></see></summary>
    let Single_Judge =
        Namespaced_IRI.parse _namespace_name "Single_Judge" |> NamespacedName

    /// <summary>
    /// means the Bench constituted by or under the orders of the Chief Justice to hear a case or particular class of cases
    /// <see href="https://w3id.org/def/nyon#Special_Bench"></see></summary>
    let Special_Bench =
        Namespaced_IRI.parse _namespace_name "Special_Bench" |> NamespacedName

    /// <summary>
    /// includes the acts and norms of the law
    /// <see href="https://w3id.org/def/nyon#Statue"></see></summary>
    let Statue = Namespaced_IRI.parse _namespace_name "Statue" |> NamespacedName
    /// <summary>
    /// institutions established for discharging judicial or quasi-judicial duties under the Government of India
    /// <see href="https://w3id.org/def/nyon#Tribunal"></see></summary>
    let Tribunal = Namespaced_IRI.parse _namespace_name "Tribunal" |> NamespacedName

    /// <summary>
    /// highest court in the judicial system
    /// <see href="https://w3id.org/def/nyon#SupremeCourt"></see></summary>
    let SupremeCourt =
        Namespaced_IRI.parse _namespace_name "SupremeCourt" |> NamespacedName

    /// <summary>
    /// Bench deals with tribunals cases
    /// <see href="https://w3id.org/def/nyon#Tribunal_Bench"></see></summary>
    let Tribunal_Bench =
        Namespaced_IRI.parse _namespace_name "Tribunal_Bench" |> NamespacedName

    /// <summary>
    /// witness involved/presented in the case
    /// <see href="https://w3id.org/def/nyon#Witness"></see></summary>
    let Witness = Namespaced_IRI.parse _namespace_name "Witness" |> NamespacedName

    /// <summary>
    /// words or phrases exctracted from the case to make the search better for the cases or find relevent cases or judgment
    /// <see href="https://w3id.org/def/nyon#WordAndPhrase"></see></summary>
    let WordAndPhrase =
        Namespaced_IRI.parse _namespace_name "WordAndPhrase" |> NamespacedName

    /// <summary>
    /// jurisdiction type is a writ jurisdiction
    /// <see href="https://w3id.org/def/nyon#Writ_Jurisdiction"></see></summary>
    let Writ_Jurisdiction =
        Namespaced_IRI.parse _namespace_name "Writ_Jurisdiction" |> NamespacedName

    /// <summary>
    /// equivalent citations provided by the various law reporters.
    /// <see href="https://w3id.org/def/nyon#equivalentCitation"></see></summary>
    let equivalentCitation =
        Namespaced_IRI.parse _namespace_name "equivalentCitation" |> NamespacedName

    /// <summary>
    /// represents neutral citations given by the court itself
    /// <see href="https://w3id.org/def/nyon#neutralCitations"></see></summary>
    let neutralCitations =
        Namespaced_IRI.parse _namespace_name "neutralCitations" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/def/nyon#firstName"></see>
    /// </summary>
    let firstName = Namespaced_IRI.parse _namespace_name "firstName" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/def/nyon#lastName"></see>
    /// </summary>
    let lastName = Namespaced_IRI.parse _namespace_name "lastName" |> NamespacedName

    /// <summary>
    /// specifies the location of the nyon:Court
    /// <see href="https://w3id.org/def/nyon#hasCourtLoc"></see></summary>
    let hasCourtLoc =
        Namespaced_IRI.parse _namespace_name "hasCourtLoc" |> NamespacedName

    /// <summary>
    /// specifies the evidence location associated with the nyon:Evidence instance for the nyon:CourtCase
    /// <see href="https://w3id.org/def/nyon#hasEvidenceLoc"></see></summary>
    let hasEvidenceLoc =
        Namespaced_IRI.parse _namespace_name "hasEvidenceLoc" |> NamespacedName

    /// <summary>
    /// specifies the issue associated with the nyon:Issue instance mentioned in the nyon:CourtCase
    /// <see href="https://w3id.org/def/nyon#hasIssue"></see></summary>
    let hasIssue = Namespaced_IRI.parse _namespace_name "hasIssue" |> NamespacedName

    /// <summary>
    /// specifies the jurisdiction (nyon:Jurisdiction) for nyon:Court
    /// <see href="https://w3id.org/def/nyon#hasJurisdiction"></see></summary>
    let hasJurisdiction =
        Namespaced_IRI.parse _namespace_name "hasJurisdiction" |> NamespacedName

    /// <summary>
    /// specifies the type of party (nyon:PartyType) involved in nyon:CourtCase
    /// <see href="https://w3id.org/def/nyon#hasPartyType"></see></summary>
    let hasPartyType =
        Namespaced_IRI.parse _namespace_name "hasPartyType" |> NamespacedName

    /// <summary>
    /// specifies a clause or norm (nyon:Provision) in a legal instrument or a law
    /// <see href="https://w3id.org/def/nyon#hasProvision"></see></summary>
    let hasProvision =
        Namespaced_IRI.parse _namespace_name "hasProvision" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/def/nyon#value"></see>
    /// </summary>
    let value = Namespaced_IRI.parse _namespace_name "value" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/def/nyon#wFirstName"></see>
    /// </summary>
    let wFirstName = Namespaced_IRI.parse _namespace_name "wFirstName" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/def/nyon#wLastName"></see>
    /// </summary>
    let wLastName = Namespaced_IRI.parse _namespace_name "wLastName" |> NamespacedName
    /// <summary>
    /// specifies the judge (nyon:Judge) working in court (nyon:Court)
    /// <see href="https://w3id.org/def/nyon#worksIn"></see></summary>
    let worksIn = Namespaced_IRI.parse _namespace_name "worksIn" |> NamespacedName
