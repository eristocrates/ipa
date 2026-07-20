namespace http.eulersharp.sourceforge.net._2003._03swap.human.hash

open DoxAletheia

module human =
    let _namespace_name = "http://eulersharp.sourceforge.net/2003/03swap/human#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/human#AdministrativeFemale"></see>
    /// </summary>
    let AdministrativeFemale = _prefix "AdministrativeFemale"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/human#AdministrativeGender"></see>
    /// </summary>
    let AdministrativeGender = _prefix "AdministrativeGender"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/human#AdministrativeMale"></see>
    /// </summary>
    let AdministrativeMale = _prefix "AdministrativeMale"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/human#AdvanceDirectivesReport"></see>
    /// </summary>
    let AdvanceDirectivesReport = _prefix "AdvanceDirectivesReport"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/human#AverageLinguisticSkill"></see>
    /// </summary>
    let AverageLinguisticSkill = _prefix "AverageLinguisticSkill"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/human#LinguisticSkillLevel"></see>
    /// </summary>
    let LinguisticSkillLevel = _prefix "LinguisticSkillLevel"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/human#BiologicalAdult"></see>
    /// </summary>
    let BiologicalAdult = _prefix "BiologicalAdult"
    /// <summary>
    /// human:Human members live and are not necessarily born; foaf:Person members are dead or alive, but born. External conflict: foaf:Person rdfs:subClassOf wordnet:person and wordnet:person wordnet:hyponymOf wordnet:organism, and wordnet:organism wordnet:hyponymOf wordnet:livingThing, but not 'hard coded' since wordnet:hyponymOf used instead of rdfs:subClassOf.
    /// <see href="http://eulersharp.sourceforge.net/2003/03swap/human#Person"></see></summary>
    let Person = _prefix "Person"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/human#BiologicalFather"></see>
    /// </summary>
    let BiologicalFather = _prefix "BiologicalFather"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/human#BiologicalParent"></see>
    /// </summary>
    let BiologicalParent = _prefix "BiologicalParent"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/human#Man"></see>
    /// </summary>
    let Man = _prefix "Man"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/human#BiologicalGender"></see>
    /// </summary>
    let BiologicalGender = _prefix "BiologicalGender"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/human#male"></see>
    /// </summary>
    let male = _prefix "male"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/human#female"></see>
    /// </summary>
    let female = _prefix "female"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/human#intersexual"></see>
    /// </summary>
    let intersexual = _prefix "intersexual"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/human#BiologicalMother"></see>
    /// </summary>
    let BiologicalMother = _prefix "BiologicalMother"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/human#Woman"></see>
    /// </summary>
    let Woman = _prefix "Woman"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/human#ContactPerson"></see>
    /// </summary>
    let ContactPerson = _prefix "ContactPerson"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/human#PersonRole"></see>
    /// </summary>
    let PersonRole = _prefix "PersonRole"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/human#Female"></see>
    /// </summary>
    let Female = _prefix "Female"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/human#Human"></see>
    /// </summary>
    let Human = _prefix "Human"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/human#hasBiologicalGender"></see>
    /// </summary>
    let hasBiologicalGender = _prefix "hasBiologicalGender"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/human#Fetus"></see>
    /// </summary>
    let Fetus = _prefix "Fetus"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/human#FluentLinguisticSkill"></see>
    /// </summary>
    let FluentLinguisticSkill = _prefix "FluentLinguisticSkill"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/human#GoodLinguisticSkill"></see>
    /// </summary>
    let GoodLinguisticSkill = _prefix "GoodLinguisticSkill"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/human#SubspeciesHomoSapiensSapiens"></see>
    /// </summary>
    let SubspeciesHomoSapiensSapiens = _prefix "SubspeciesHomoSapiensSapiens"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/human#Husband"></see>
    /// </summary>
    let Husband = _prefix "Husband"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/human#ImmatureHuman"></see>
    /// </summary>
    let ImmatureHuman = _prefix "ImmatureHuman"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/human#InformedConsent"></see>
    /// </summary>
    let InformedConsent = _prefix "InformedConsent"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/human#Intersexual"></see>
    /// </summary>
    let Intersexual = _prefix "Intersexual"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/human#LanguageExpressing"></see>
    /// </summary>
    let LanguageExpressing = _prefix "LanguageExpressing"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/human#LanguageExpression"></see>
    /// </summary>
    let LanguageExpression = _prefix "LanguageExpression"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/human#LanguageExpressionSkill"></see>
    /// </summary>
    let LanguageExpressionSkill = _prefix "LanguageExpressionSkill"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/human#LinguisticSkill"></see>
    /// </summary>
    let LinguisticSkill = _prefix "LinguisticSkill"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/human#LanguageSigningSkill"></see>
    /// </summary>
    let LanguageSigningSkill = _prefix "LanguageSigningSkill"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/human#LanguageSpeakingSkill"></see>
    /// </summary>
    let LanguageSpeakingSkill = _prefix "LanguageSpeakingSkill"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/human#LanguageUnderstandingSkill"></see>
    /// </summary>
    let LanguageUnderstandingSkill = _prefix "LanguageUnderstandingSkill"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/human#LanguageWritingSkill"></see>
    /// </summary>
    let LanguageWritingSkill = _prefix "LanguageWritingSkill"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/human#LegalAdult"></see>
    /// </summary>
    let LegalAdult = _prefix "LegalAdult"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/human#LegalFather"></see>
    /// </summary>
    let LegalFather = _prefix "LegalFather"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/human#LegalMother"></see>
    /// </summary>
    let LegalMother = _prefix "LegalMother"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/human#LegalParent"></see>
    /// </summary>
    let LegalParent = _prefix "LegalParent"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/human#Life"></see>
    /// </summary>
    let Life = _prefix "Life"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/human#NativeLinguisticSkill"></see>
    /// </summary>
    let NativeLinguisticSkill = _prefix "NativeLinguisticSkill"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/human#PoorLinguisticSkill"></see>
    /// </summary>
    let PoorLinguisticSkill = _prefix "PoorLinguisticSkill"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/human#NoticesLinguisticSkill"></see>
    /// </summary>
    let NoticesLinguisticSkill = _prefix "NoticesLinguisticSkill"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/human#NoLinguisticSkill"></see>
    /// </summary>
    let NoLinguisticSkill = _prefix "NoLinguisticSkill"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/human#Male"></see>
    /// </summary>
    let Male = _prefix "Male"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/human#Men"></see>
    /// </summary>
    let Men = _prefix "Men"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/human#Newborn"></see>
    /// </summary>
    let Newborn = _prefix "Newborn"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/human#weighs"></see>
    /// </summary>
    let weighs = _prefix "weighs"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/human#Occupation"></see>
    /// </summary>
    let Occupation = _prefix "Occupation"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/human#OccupationRole"></see>
    /// </summary>
    let OccupationRole = _prefix "OccupationRole"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/human#OccupationalStatus"></see>
    /// </summary>
    let OccupationalStatus = _prefix "OccupationalStatus"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/human#OnSickLeave"></see>
    /// </summary>
    let OnSickLeave = _prefix "OnSickLeave"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/human#Partner"></see>
    /// </summary>
    let Partner = _prefix "Partner"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/human#PersonLife"></see>
    /// </summary>
    let PersonLife = _prefix "PersonLife"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/human#Role"></see>
    /// </summary>
    let Role = _prefix "Role"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/human#PregnantWoman"></see>
    /// </summary>
    let PregnantWoman = _prefix "PregnantWoman"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/human#Retired"></see>
    /// </summary>
    let Retired = _prefix "Retired"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/human#SignedLanguageUnderstandingSkill"></see>
    /// </summary>
    let SignedLanguageUnderstandingSkill = _prefix "SignedLanguageUnderstandingSkill"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/human#SpokenLanguageUnderstandingSkill"></see>
    /// </summary>
    let SpokenLanguageUnderstandingSkill = _prefix "SpokenLanguageUnderstandingSkill"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/human#Spouse"></see>
    /// </summary>
    let Spouse = _prefix "Spouse"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/human#Women"></see>
    /// </summary>
    let Women = _prefix "Women"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/human#Working"></see>
    /// </summary>
    let Working = _prefix "Working"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/human#WrittenLanguageUnderstandingSkill"></see>
    /// </summary>
    let WrittenLanguageUnderstandingSkill = _prefix "WrittenLanguageUnderstandingSkill"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/human#contactPersonFor"></see>
    /// </summary>
    let contactPersonFor = _prefix "contactPersonFor"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/human#contactPersonOf"></see>
    /// </summary>
    let contactPersonOf = _prefix "contactPersonOf"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/human#forWhichIsContactPerson"></see>
    /// </summary>
    let forWhichIsContactPerson = _prefix "forWhichIsContactPerson"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/human#hasAdministrativeGender"></see>
    /// </summary>
    let hasAdministrativeGender = _prefix "hasAdministrativeGender"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/human#hasBodyMassIndex"></see>
    /// </summary>
    let hasBodyMassIndex = _prefix "hasBodyMassIndex"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/human#hasContactPerson"></see>
    /// </summary>
    let hasContactPerson = _prefix "hasContactPerson"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/human#hasInformedConsent"></see>
    /// </summary>
    let hasInformedConsent = _prefix "hasInformedConsent"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/human#hasLength"></see>
    /// </summary>
    let hasLength = _prefix "hasLength"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/human#hasOccupationalStatus"></see>
    /// </summary>
    let hasOccupationalStatus = _prefix "hasOccupationalStatus"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/human#hasSurfaceArea"></see>
    /// </summary>
    let hasSurfaceArea = _prefix "hasSurfaceArea"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/human#hasWeightStatus"></see>
    /// </summary>
    let hasWeightStatus = _prefix "hasWeightStatus"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/human#informedlyConsentsTo"></see>
    /// </summary>
    let informedlyConsentsTo = _prefix "informedlyConsentsTo"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/human#weighsAtBirth"></see>
    /// </summary>
    let weighsAtBirth = _prefix "weighsAtBirth"
