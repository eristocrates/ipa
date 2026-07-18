namespace http.eulersharp.sourceforge.net._2003._03swap.human.hash

open DoxAletheia.Rdf_Vocabulary

module human =
    let _namespace_name = "http://eulersharp.sourceforge.net/2003/03swap/human#"

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/human#AdministrativeFemale"></see>
    /// </summary>
    let AdministrativeFemale =
        Namespaced_IRI.parse _namespace_name "AdministrativeFemale" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/human#AdministrativeGender"></see>
    /// </summary>
    let AdministrativeGender =
        Namespaced_IRI.parse _namespace_name "AdministrativeGender" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/human#AdministrativeMale"></see>
    /// </summary>
    let AdministrativeMale =
        Namespaced_IRI.parse _namespace_name "AdministrativeMale" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/human#AdvanceDirectivesReport"></see>
    /// </summary>
    let AdvanceDirectivesReport =
        Namespaced_IRI.parse _namespace_name "AdvanceDirectivesReport" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/human#AverageLinguisticSkill"></see>
    /// </summary>
    let AverageLinguisticSkill =
        Namespaced_IRI.parse _namespace_name "AverageLinguisticSkill" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/human#LinguisticSkillLevel"></see>
    /// </summary>
    let LinguisticSkillLevel =
        Namespaced_IRI.parse _namespace_name "LinguisticSkillLevel" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/human#BiologicalAdult"></see>
    /// </summary>
    let BiologicalAdult =
        Namespaced_IRI.parse _namespace_name "BiologicalAdult" |> NamespacedName

    /// <summary>
    /// human:Human members live and are not necessarily born; foaf:Person members are dead or alive, but born. External conflict: foaf:Person rdfs:subClassOf wordnet:person and wordnet:person wordnet:hyponymOf wordnet:organism, and wordnet:organism wordnet:hyponymOf wordnet:livingThing, but not 'hard coded' since wordnet:hyponymOf used instead of rdfs:subClassOf.
    /// <see href="http://eulersharp.sourceforge.net/2003/03swap/human#Person"></see></summary>
    let Person = Namespaced_IRI.parse _namespace_name "Person" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/human#BiologicalFather"></see>
    /// </summary>
    let BiologicalFather =
        Namespaced_IRI.parse _namespace_name "BiologicalFather" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/human#BiologicalParent"></see>
    /// </summary>
    let BiologicalParent =
        Namespaced_IRI.parse _namespace_name "BiologicalParent" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/human#Man"></see>
    /// </summary>
    let Man = Namespaced_IRI.parse _namespace_name "Man" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/human#BiologicalGender"></see>
    /// </summary>
    let BiologicalGender =
        Namespaced_IRI.parse _namespace_name "BiologicalGender" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/human#male"></see>
    /// </summary>
    let male = Namespaced_IRI.parse _namespace_name "male" |> NamespacedName
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/human#female"></see>
    /// </summary>
    let female = Namespaced_IRI.parse _namespace_name "female" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/human#intersexual"></see>
    /// </summary>
    let intersexual =
        Namespaced_IRI.parse _namespace_name "intersexual" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/human#BiologicalMother"></see>
    /// </summary>
    let BiologicalMother =
        Namespaced_IRI.parse _namespace_name "BiologicalMother" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/human#Woman"></see>
    /// </summary>
    let Woman = Namespaced_IRI.parse _namespace_name "Woman" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/human#ContactPerson"></see>
    /// </summary>
    let ContactPerson =
        Namespaced_IRI.parse _namespace_name "ContactPerson" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/human#PersonRole"></see>
    /// </summary>
    let PersonRole = Namespaced_IRI.parse _namespace_name "PersonRole" |> NamespacedName
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/human#Female"></see>
    /// </summary>
    let Female = Namespaced_IRI.parse _namespace_name "Female" |> NamespacedName
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/human#Human"></see>
    /// </summary>
    let Human = Namespaced_IRI.parse _namespace_name "Human" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/human#hasBiologicalGender"></see>
    /// </summary>
    let hasBiologicalGender =
        Namespaced_IRI.parse _namespace_name "hasBiologicalGender" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/human#Fetus"></see>
    /// </summary>
    let Fetus = Namespaced_IRI.parse _namespace_name "Fetus" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/human#FluentLinguisticSkill"></see>
    /// </summary>
    let FluentLinguisticSkill =
        Namespaced_IRI.parse _namespace_name "FluentLinguisticSkill" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/human#GoodLinguisticSkill"></see>
    /// </summary>
    let GoodLinguisticSkill =
        Namespaced_IRI.parse _namespace_name "GoodLinguisticSkill" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/human#SubspeciesHomoSapiensSapiens"></see>
    /// </summary>
    let SubspeciesHomoSapiensSapiens =
        Namespaced_IRI.parse _namespace_name "SubspeciesHomoSapiensSapiens" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/human#Husband"></see>
    /// </summary>
    let Husband = Namespaced_IRI.parse _namespace_name "Husband" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/human#ImmatureHuman"></see>
    /// </summary>
    let ImmatureHuman =
        Namespaced_IRI.parse _namespace_name "ImmatureHuman" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/human#InformedConsent"></see>
    /// </summary>
    let InformedConsent =
        Namespaced_IRI.parse _namespace_name "InformedConsent" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/human#Intersexual"></see>
    /// </summary>
    let Intersexual =
        Namespaced_IRI.parse _namespace_name "Intersexual" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/human#LanguageExpressing"></see>
    /// </summary>
    let LanguageExpressing =
        Namespaced_IRI.parse _namespace_name "LanguageExpressing" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/human#LanguageExpression"></see>
    /// </summary>
    let LanguageExpression =
        Namespaced_IRI.parse _namespace_name "LanguageExpression" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/human#LanguageExpressionSkill"></see>
    /// </summary>
    let LanguageExpressionSkill =
        Namespaced_IRI.parse _namespace_name "LanguageExpressionSkill" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/human#LinguisticSkill"></see>
    /// </summary>
    let LinguisticSkill =
        Namespaced_IRI.parse _namespace_name "LinguisticSkill" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/human#LanguageSigningSkill"></see>
    /// </summary>
    let LanguageSigningSkill =
        Namespaced_IRI.parse _namespace_name "LanguageSigningSkill" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/human#LanguageSpeakingSkill"></see>
    /// </summary>
    let LanguageSpeakingSkill =
        Namespaced_IRI.parse _namespace_name "LanguageSpeakingSkill" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/human#LanguageUnderstandingSkill"></see>
    /// </summary>
    let LanguageUnderstandingSkill =
        Namespaced_IRI.parse _namespace_name "LanguageUnderstandingSkill" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/human#LanguageWritingSkill"></see>
    /// </summary>
    let LanguageWritingSkill =
        Namespaced_IRI.parse _namespace_name "LanguageWritingSkill" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/human#LegalAdult"></see>
    /// </summary>
    let LegalAdult = Namespaced_IRI.parse _namespace_name "LegalAdult" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/human#LegalFather"></see>
    /// </summary>
    let LegalFather =
        Namespaced_IRI.parse _namespace_name "LegalFather" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/human#LegalMother"></see>
    /// </summary>
    let LegalMother =
        Namespaced_IRI.parse _namespace_name "LegalMother" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/human#LegalParent"></see>
    /// </summary>
    let LegalParent =
        Namespaced_IRI.parse _namespace_name "LegalParent" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/human#Life"></see>
    /// </summary>
    let Life = Namespaced_IRI.parse _namespace_name "Life" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/human#NativeLinguisticSkill"></see>
    /// </summary>
    let NativeLinguisticSkill =
        Namespaced_IRI.parse _namespace_name "NativeLinguisticSkill" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/human#PoorLinguisticSkill"></see>
    /// </summary>
    let PoorLinguisticSkill =
        Namespaced_IRI.parse _namespace_name "PoorLinguisticSkill" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/human#NoticesLinguisticSkill"></see>
    /// </summary>
    let NoticesLinguisticSkill =
        Namespaced_IRI.parse _namespace_name "NoticesLinguisticSkill" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/human#NoLinguisticSkill"></see>
    /// </summary>
    let NoLinguisticSkill =
        Namespaced_IRI.parse _namespace_name "NoLinguisticSkill" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/human#Male"></see>
    /// </summary>
    let Male = Namespaced_IRI.parse _namespace_name "Male" |> NamespacedName
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/human#Men"></see>
    /// </summary>
    let Men = Namespaced_IRI.parse _namespace_name "Men" |> NamespacedName
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/human#Newborn"></see>
    /// </summary>
    let Newborn = Namespaced_IRI.parse _namespace_name "Newborn" |> NamespacedName
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/human#weighs"></see>
    /// </summary>
    let weighs = Namespaced_IRI.parse _namespace_name "weighs" |> NamespacedName
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/human#Occupation"></see>
    /// </summary>
    let Occupation = Namespaced_IRI.parse _namespace_name "Occupation" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/human#OccupationRole"></see>
    /// </summary>
    let OccupationRole =
        Namespaced_IRI.parse _namespace_name "OccupationRole" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/human#OccupationalStatus"></see>
    /// </summary>
    let OccupationalStatus =
        Namespaced_IRI.parse _namespace_name "OccupationalStatus" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/human#OnSickLeave"></see>
    /// </summary>
    let OnSickLeave =
        Namespaced_IRI.parse _namespace_name "OnSickLeave" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/human#Partner"></see>
    /// </summary>
    let Partner = Namespaced_IRI.parse _namespace_name "Partner" |> NamespacedName
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/human#PersonLife"></see>
    /// </summary>
    let PersonLife = Namespaced_IRI.parse _namespace_name "PersonLife" |> NamespacedName
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/human#Role"></see>
    /// </summary>
    let Role = Namespaced_IRI.parse _namespace_name "Role" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/human#PregnantWoman"></see>
    /// </summary>
    let PregnantWoman =
        Namespaced_IRI.parse _namespace_name "PregnantWoman" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/human#Retired"></see>
    /// </summary>
    let Retired = Namespaced_IRI.parse _namespace_name "Retired" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/human#SignedLanguageUnderstandingSkill"></see>
    /// </summary>
    let SignedLanguageUnderstandingSkill =
        Namespaced_IRI.parse _namespace_name "SignedLanguageUnderstandingSkill" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/human#SpokenLanguageUnderstandingSkill"></see>
    /// </summary>
    let SpokenLanguageUnderstandingSkill =
        Namespaced_IRI.parse _namespace_name "SpokenLanguageUnderstandingSkill" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/human#Spouse"></see>
    /// </summary>
    let Spouse = Namespaced_IRI.parse _namespace_name "Spouse" |> NamespacedName
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/human#Women"></see>
    /// </summary>
    let Women = Namespaced_IRI.parse _namespace_name "Women" |> NamespacedName
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/human#Working"></see>
    /// </summary>
    let Working = Namespaced_IRI.parse _namespace_name "Working" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/human#WrittenLanguageUnderstandingSkill"></see>
    /// </summary>
    let WrittenLanguageUnderstandingSkill =
        Namespaced_IRI.parse _namespace_name "WrittenLanguageUnderstandingSkill" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/human#contactPersonFor"></see>
    /// </summary>
    let contactPersonFor =
        Namespaced_IRI.parse _namespace_name "contactPersonFor" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/human#contactPersonOf"></see>
    /// </summary>
    let contactPersonOf =
        Namespaced_IRI.parse _namespace_name "contactPersonOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/human#forWhichIsContactPerson"></see>
    /// </summary>
    let forWhichIsContactPerson =
        Namespaced_IRI.parse _namespace_name "forWhichIsContactPerson" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/human#hasAdministrativeGender"></see>
    /// </summary>
    let hasAdministrativeGender =
        Namespaced_IRI.parse _namespace_name "hasAdministrativeGender" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/human#hasBodyMassIndex"></see>
    /// </summary>
    let hasBodyMassIndex =
        Namespaced_IRI.parse _namespace_name "hasBodyMassIndex" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/human#hasContactPerson"></see>
    /// </summary>
    let hasContactPerson =
        Namespaced_IRI.parse _namespace_name "hasContactPerson" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/human#hasInformedConsent"></see>
    /// </summary>
    let hasInformedConsent =
        Namespaced_IRI.parse _namespace_name "hasInformedConsent" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/human#hasLength"></see>
    /// </summary>
    let hasLength = Namespaced_IRI.parse _namespace_name "hasLength" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/human#hasOccupationalStatus"></see>
    /// </summary>
    let hasOccupationalStatus =
        Namespaced_IRI.parse _namespace_name "hasOccupationalStatus" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/human#hasSurfaceArea"></see>
    /// </summary>
    let hasSurfaceArea =
        Namespaced_IRI.parse _namespace_name "hasSurfaceArea" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/human#hasWeightStatus"></see>
    /// </summary>
    let hasWeightStatus =
        Namespaced_IRI.parse _namespace_name "hasWeightStatus" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/human#informedlyConsentsTo"></see>
    /// </summary>
    let informedlyConsentsTo =
        Namespaced_IRI.parse _namespace_name "informedlyConsentsTo" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/human#weighsAtBirth"></see>
    /// </summary>
    let weighsAtBirth =
        Namespaced_IRI.parse _namespace_name "weighsAtBirth" |> NamespacedName
