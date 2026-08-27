namespace http.eulersharp.sourceforge.net._2003._03swap.human.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module human =
    let _namespace_iri = Namespace_Iri human |> NamespaceIRI
    /// <summary>
    ///   <para>human:</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/human#">http://eulersharp.sourceforge.net/2003/03swap/human#</seealso>
    let _prefix_iri = Prefixed_Name(human, "") |> PrefixedName

    /// <summary>
    ///   <para>human:AdministrativeFemale</para>
    /// </summary>
    /// <remarks>
    ///   <para>human:AdministrativeGender</para>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>"administrative female"</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/human#AdministrativeFemale">http://eulersharp.sourceforge.net/2003/03swap/human#AdministrativeFemale</seealso>
    let AdministrativeFemale =
        Prefixed_Name(human, "AdministrativeFemale") |> PrefixedName

    /// <summary>
    ///   <para>human:AdministrativeGender</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>"administrative gender"</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/human#AdministrativeGender">http://eulersharp.sourceforge.net/2003/03swap/human#AdministrativeGender</seealso>
    let AdministrativeGender =
        Prefixed_Name(human, "AdministrativeGender") |> PrefixedName

    /// <summary>
    ///   <para>human:AdministrativeMale</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>human:AdministrativeGender</para>
    ///
    /// labels<para>"administrative male"</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/human#AdministrativeMale">http://eulersharp.sourceforge.net/2003/03swap/human#AdministrativeMale</seealso>
    let AdministrativeMale = Prefixed_Name(human, "AdministrativeMale") |> PrefixedName

    /// <summary>
    ///   <para>human:AdvanceDirectivesReport</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>"advance directives report"</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/human#AdvanceDirectivesReport">http://eulersharp.sourceforge.net/2003/03swap/human#AdvanceDirectivesReport</seealso>
    let AdvanceDirectivesReport =
        Prefixed_Name(human, "AdvanceDirectivesReport") |> PrefixedName

    /// <summary>
    ///   <para>human:AverageLinguisticSkill</para>
    /// </summary>
    /// <remarks>
    ///   <para>human:LinguisticSkillLevel</para>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>"average linguistic skill"</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/human#AverageLinguisticSkill">http://eulersharp.sourceforge.net/2003/03swap/human#AverageLinguisticSkill</seealso>
    let AverageLinguisticSkill =
        Prefixed_Name(human, "AverageLinguisticSkill") |> PrefixedName

    /// <summary>
    ///   <para>human:BiologicalAdult</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>"biologically adult human"</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/human#BiologicalAdult">http://eulersharp.sourceforge.net/2003/03swap/human#BiologicalAdult</seealso>
    let BiologicalAdult = Prefixed_Name(human, "BiologicalAdult") |> PrefixedName
    /// <summary>
    ///   <para>human:BiologicalFather</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/human#BiologicalFather">http://eulersharp.sourceforge.net/2003/03swap/human#BiologicalFather</seealso>
    let BiologicalFather = Prefixed_Name(human, "BiologicalFather") |> PrefixedName
    /// <summary>
    ///   <para>human:BiologicalGender</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>"biological gender"</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/human#BiologicalGender">http://eulersharp.sourceforge.net/2003/03swap/human#BiologicalGender</seealso>
    let BiologicalGender = Prefixed_Name(human, "BiologicalGender") |> PrefixedName
    /// <summary>
    ///   <para>human:BiologicalMother</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/human#BiologicalMother">http://eulersharp.sourceforge.net/2003/03swap/human#BiologicalMother</seealso>
    let BiologicalMother = Prefixed_Name(human, "BiologicalMother") |> PrefixedName
    /// <summary>
    ///   <para>human:BiologicalParent</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>"biological human parent"</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/human#BiologicalParent">http://eulersharp.sourceforge.net/2003/03swap/human#BiologicalParent</seealso>
    let BiologicalParent = Prefixed_Name(human, "BiologicalParent") |> PrefixedName
    /// <summary>
    ///   <para>human:ContactPerson</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>"contact person role"</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/human#ContactPerson">http://eulersharp.sourceforge.net/2003/03swap/human#ContactPerson</seealso>
    let ContactPerson = Prefixed_Name(human, "ContactPerson") |> PrefixedName
    /// <summary>
    ///   <para>human:Female</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>"human female"</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/human#Female">http://eulersharp.sourceforge.net/2003/03swap/human#Female</seealso>
    let Female = Prefixed_Name(human, "Female") |> PrefixedName
    /// <summary>
    ///   <para>human:Fetus</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>"human fetus"</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/human#Fetus">http://eulersharp.sourceforge.net/2003/03swap/human#Fetus</seealso>
    let Fetus = Prefixed_Name(human, "Fetus") |> PrefixedName

    /// <summary>
    ///   <para>human:FluentLinguisticSkill</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>human:LinguisticSkillLevel</para>
    ///
    /// labels<para>"fluent linguistic skill"</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/human#FluentLinguisticSkill">http://eulersharp.sourceforge.net/2003/03swap/human#FluentLinguisticSkill</seealso>
    let FluentLinguisticSkill =
        Prefixed_Name(human, "FluentLinguisticSkill") |> PrefixedName

    /// <summary>
    ///   <para>human:GoodLinguisticSkill</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>human:LinguisticSkillLevel</para>
    ///
    /// labels<para>"good linguistic skill"</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/human#GoodLinguisticSkill">http://eulersharp.sourceforge.net/2003/03swap/human#GoodLinguisticSkill</seealso>
    let GoodLinguisticSkill =
        Prefixed_Name(human, "GoodLinguisticSkill") |> PrefixedName

    /// <summary>
    ///   <para>human:Human</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>"human"</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/human#Human">http://eulersharp.sourceforge.net/2003/03swap/human#Human</seealso>
    let Human = Prefixed_Name(human, "Human") |> PrefixedName
    /// <summary>
    ///   <para>human:Husband</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/human#Husband">http://eulersharp.sourceforge.net/2003/03swap/human#Husband</seealso>
    let Husband = Prefixed_Name(human, "Husband") |> PrefixedName
    /// <summary>
    ///   <para>human:ImmatureHuman</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>"immature human"</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/human#ImmatureHuman">http://eulersharp.sourceforge.net/2003/03swap/human#ImmatureHuman</seealso>
    let ImmatureHuman = Prefixed_Name(human, "ImmatureHuman") |> PrefixedName
    /// <summary>
    ///   <para>human:InformedConsent</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>"informed consent"</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/human#InformedConsent">http://eulersharp.sourceforge.net/2003/03swap/human#InformedConsent</seealso>
    let InformedConsent = Prefixed_Name(human, "InformedConsent") |> PrefixedName
    /// <summary>
    ///   <para>human:Intersexual</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>"intersexual"</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/human#Intersexual">http://eulersharp.sourceforge.net/2003/03swap/human#Intersexual</seealso>
    let Intersexual = Prefixed_Name(human, "Intersexual") |> PrefixedName
    /// <summary>
    ///   <para>human:LanguageExpressing</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>"language expressing"</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/human#LanguageExpressing">http://eulersharp.sourceforge.net/2003/03swap/human#LanguageExpressing</seealso>
    let LanguageExpressing = Prefixed_Name(human, "LanguageExpressing") |> PrefixedName
    /// <summary>
    ///   <para>human:LanguageExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>"language expression"</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/human#LanguageExpression">http://eulersharp.sourceforge.net/2003/03swap/human#LanguageExpression</seealso>
    let LanguageExpression = Prefixed_Name(human, "LanguageExpression") |> PrefixedName

    /// <summary>
    ///   <para>human:LanguageExpressionSkill</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>"language expression skill"</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/human#LanguageExpressionSkill">http://eulersharp.sourceforge.net/2003/03swap/human#LanguageExpressionSkill</seealso>
    let LanguageExpressionSkill =
        Prefixed_Name(human, "LanguageExpressionSkill") |> PrefixedName

    /// <summary>
    ///   <para>human:LanguageSigningSkill</para>
    /// </summary>
    /// <remarks>
    ///   <para>human:LanguageExpressionSkill</para>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>"language signing skill"</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/human#LanguageSigningSkill">http://eulersharp.sourceforge.net/2003/03swap/human#LanguageSigningSkill</seealso>
    let LanguageSigningSkill =
        Prefixed_Name(human, "LanguageSigningSkill") |> PrefixedName

    /// <summary>
    ///   <para>human:LanguageSpeakingSkill</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>human:LanguageExpressionSkill</para>
    ///
    /// labels<para>"language speaking skill"</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/human#LanguageSpeakingSkill">http://eulersharp.sourceforge.net/2003/03swap/human#LanguageSpeakingSkill</seealso>
    let LanguageSpeakingSkill =
        Prefixed_Name(human, "LanguageSpeakingSkill") |> PrefixedName

    /// <summary>
    ///   <para>human:LanguageUnderstandingSkill</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>"language understanding skill"</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/human#LanguageUnderstandingSkill">http://eulersharp.sourceforge.net/2003/03swap/human#LanguageUnderstandingSkill</seealso>
    let LanguageUnderstandingSkill =
        Prefixed_Name(human, "LanguageUnderstandingSkill") |> PrefixedName

    /// <summary>
    ///   <para>human:LanguageWritingSkill</para>
    /// </summary>
    /// <remarks>
    ///   <para>human:LanguageExpressionSkill</para>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>"language writing skill"</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/human#LanguageWritingSkill">http://eulersharp.sourceforge.net/2003/03swap/human#LanguageWritingSkill</seealso>
    let LanguageWritingSkill =
        Prefixed_Name(human, "LanguageWritingSkill") |> PrefixedName

    /// <summary>
    ///   <para>human:LegalAdult</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>"legally adult human"</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/human#LegalAdult">http://eulersharp.sourceforge.net/2003/03swap/human#LegalAdult</seealso>
    let LegalAdult = Prefixed_Name(human, "LegalAdult") |> PrefixedName
    /// <summary>
    ///   <para>human:LegalFather</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/human#LegalFather">http://eulersharp.sourceforge.net/2003/03swap/human#LegalFather</seealso>
    let LegalFather = Prefixed_Name(human, "LegalFather") |> PrefixedName
    /// <summary>
    ///   <para>human:LegalMother</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/human#LegalMother">http://eulersharp.sourceforge.net/2003/03swap/human#LegalMother</seealso>
    let LegalMother = Prefixed_Name(human, "LegalMother") |> PrefixedName
    /// <summary>
    ///   <para>human:LegalParent</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>"legal human parent"</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/human#LegalParent">http://eulersharp.sourceforge.net/2003/03swap/human#LegalParent</seealso>
    let LegalParent = Prefixed_Name(human, "LegalParent") |> PrefixedName
    /// <summary>
    ///   <para>human:Life</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>"human life"</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/human#Life">http://eulersharp.sourceforge.net/2003/03swap/human#Life</seealso>
    let Life = Prefixed_Name(human, "Life") |> PrefixedName
    /// <summary>
    ///   <para>human:LinguisticSkill</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>"linguistic skill"</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/human#LinguisticSkill">http://eulersharp.sourceforge.net/2003/03swap/human#LinguisticSkill</seealso>
    let LinguisticSkill = Prefixed_Name(human, "LinguisticSkill") |> PrefixedName

    /// <summary>
    ///   <para>human:LinguisticSkillLevel</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>"linguistic skill level"</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/human#LinguisticSkillLevel">http://eulersharp.sourceforge.net/2003/03swap/human#LinguisticSkillLevel</seealso>
    let LinguisticSkillLevel =
        Prefixed_Name(human, "LinguisticSkillLevel") |> PrefixedName

    /// <summary>
    ///   <para>human:Male</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>"human male"</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/human#Male">http://eulersharp.sourceforge.net/2003/03swap/human#Male</seealso>
    let Male = Prefixed_Name(human, "Male") |> PrefixedName
    /// <summary>
    ///   <para>human:Man</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>"man"</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/human#Man">http://eulersharp.sourceforge.net/2003/03swap/human#Man</seealso>
    let Man = Prefixed_Name(human, "Man") |> PrefixedName
    /// <summary>
    ///   <para>human:Men</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>"men"</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/human#Men">http://eulersharp.sourceforge.net/2003/03swap/human#Men</seealso>
    let Men = Prefixed_Name(human, "Men") |> PrefixedName

    /// <summary>
    ///   <para>human:NativeLinguisticSkill</para>
    /// </summary>
    /// <remarks>
    ///   <para>human:LinguisticSkillLevel</para>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>"native linguistic skill"</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/human#NativeLinguisticSkill">http://eulersharp.sourceforge.net/2003/03swap/human#NativeLinguisticSkill</seealso>
    let NativeLinguisticSkill =
        Prefixed_Name(human, "NativeLinguisticSkill") |> PrefixedName

    /// <summary>
    ///   <para>human:Newborn</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>"newborn"</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/human#Newborn">http://eulersharp.sourceforge.net/2003/03swap/human#Newborn</seealso>
    let Newborn = Prefixed_Name(human, "Newborn") |> PrefixedName
    /// <summary>
    ///   <para>human:NoLinguisticSkill</para>
    /// </summary>
    /// <remarks>
    ///   <para>human:LinguisticSkillLevel</para>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>"no linguistic skill"</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/human#NoLinguisticSkill">http://eulersharp.sourceforge.net/2003/03swap/human#NoLinguisticSkill</seealso>
    let NoLinguisticSkill = Prefixed_Name(human, "NoLinguisticSkill") |> PrefixedName

    /// <summary>
    ///   <para>human:NoticesLinguisticSkill</para>
    /// </summary>
    /// <remarks>
    ///   <para>human:LinguisticSkillLevel</para>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>"notices linguistic skill"</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/human#NoticesLinguisticSkill">http://eulersharp.sourceforge.net/2003/03swap/human#NoticesLinguisticSkill</seealso>
    let NoticesLinguisticSkill =
        Prefixed_Name(human, "NoticesLinguisticSkill") |> PrefixedName

    /// <summary>
    ///   <para>human:Occupation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>"human occupation"</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/human#Occupation">http://eulersharp.sourceforge.net/2003/03swap/human#Occupation</seealso>
    let Occupation = Prefixed_Name(human, "Occupation") |> PrefixedName
    /// <summary>
    ///   <para>human:OccupationRole</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>"occupation role"</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/human#OccupationRole">http://eulersharp.sourceforge.net/2003/03swap/human#OccupationRole</seealso>
    let OccupationRole = Prefixed_Name(human, "OccupationRole") |> PrefixedName
    /// <summary>
    ///   <para>human:OccupationalStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>"occupational status"</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/human#OccupationalStatus">http://eulersharp.sourceforge.net/2003/03swap/human#OccupationalStatus</seealso>
    let OccupationalStatus = Prefixed_Name(human, "OccupationalStatus") |> PrefixedName
    /// <summary>
    ///   <para>human:OnSickLeave</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>human:OccupationalStatus</para>
    ///
    /// labels<para>"on sick leave"</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/human#OnSickLeave">http://eulersharp.sourceforge.net/2003/03swap/human#OnSickLeave</seealso>
    let OnSickLeave = Prefixed_Name(human, "OnSickLeave") |> PrefixedName
    /// <summary>
    ///   <para>human:Partner</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/human#Partner">http://eulersharp.sourceforge.net/2003/03swap/human#Partner</seealso>
    let Partner = Prefixed_Name(human, "Partner") |> PrefixedName
    /// <summary>
    ///   <para>human:Person</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"human:Human members live and are not necessarily born; foaf:Person members are dead or alive, but born. External conflict: foaf:Person rdfs:subClassOf wordnet:person and wordnet:person wordnet:hyponymOf wordnet:organism, and wordnet:organism wordnet:hyponymOf wordnet:livingThing, but not 'hard coded' since wordnet:hyponymOf used instead of rdfs:subClassOf."</para>
    /// labels<para>"person"</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/human#Person">http://eulersharp.sourceforge.net/2003/03swap/human#Person</seealso>
    let Person = Prefixed_Name(human, "Person") |> PrefixedName
    /// <summary>
    ///   <para>human:PersonLife</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>"person life"</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/human#PersonLife">http://eulersharp.sourceforge.net/2003/03swap/human#PersonLife</seealso>
    let PersonLife = Prefixed_Name(human, "PersonLife") |> PrefixedName
    /// <summary>
    ///   <para>human:PersonRole</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>"person role"</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/human#PersonRole">http://eulersharp.sourceforge.net/2003/03swap/human#PersonRole</seealso>
    let PersonRole = Prefixed_Name(human, "PersonRole") |> PrefixedName

    /// <summary>
    ///   <para>human:PoorLinguisticSkill</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>human:LinguisticSkillLevel</para>
    ///
    /// labels<para>"poor linguistic skill"</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/human#PoorLinguisticSkill">http://eulersharp.sourceforge.net/2003/03swap/human#PoorLinguisticSkill</seealso>
    let PoorLinguisticSkill =
        Prefixed_Name(human, "PoorLinguisticSkill") |> PrefixedName

    /// <summary>
    ///   <para>human:PregnantWoman</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>"pregnant woman"</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/human#PregnantWoman">http://eulersharp.sourceforge.net/2003/03swap/human#PregnantWoman</seealso>
    let PregnantWoman = Prefixed_Name(human, "PregnantWoman") |> PrefixedName
    /// <summary>
    ///   <para>human:Retired</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>human:OccupationalStatus</para>
    ///
    /// labels<para>"retired"</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/human#Retired">http://eulersharp.sourceforge.net/2003/03swap/human#Retired</seealso>
    let Retired = Prefixed_Name(human, "Retired") |> PrefixedName
    /// <summary>
    ///   <para>human:Role</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>"human role"</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/human#Role">http://eulersharp.sourceforge.net/2003/03swap/human#Role</seealso>
    let Role = Prefixed_Name(human, "Role") |> PrefixedName

    /// <summary>
    ///   <para>human:SignedLanguageUnderstandingSkill</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>human:LanguageUnderstandingSkill</para>
    ///
    /// labels<para>"signed language understanding skill"</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/human#SignedLanguageUnderstandingSkill">http://eulersharp.sourceforge.net/2003/03swap/human#SignedLanguageUnderstandingSkill</seealso>
    let SignedLanguageUnderstandingSkill =
        Prefixed_Name(human, "SignedLanguageUnderstandingSkill") |> PrefixedName

    /// <summary>
    ///   <para>human:SpokenLanguageUnderstandingSkill</para>
    /// </summary>
    /// <remarks>
    ///   <para>human:LanguageUnderstandingSkill</para>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>"spoken language understanding skill"</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/human#SpokenLanguageUnderstandingSkill">http://eulersharp.sourceforge.net/2003/03swap/human#SpokenLanguageUnderstandingSkill</seealso>
    let SpokenLanguageUnderstandingSkill =
        Prefixed_Name(human, "SpokenLanguageUnderstandingSkill") |> PrefixedName

    /// <summary>
    ///   <para>human:Spouse</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/human#Spouse">http://eulersharp.sourceforge.net/2003/03swap/human#Spouse</seealso>
    let Spouse = Prefixed_Name(human, "Spouse") |> PrefixedName

    /// <summary>
    ///   <para>human:SubspeciesHomoSapiensSapiens</para>
    /// </summary>
    /// <remarks>
    ///   <para>unicore:Taxon</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/human#SubspeciesHomoSapiensSapiens">http://eulersharp.sourceforge.net/2003/03swap/human#SubspeciesHomoSapiensSapiens</seealso>
    let SubspeciesHomoSapiensSapiens =
        Prefixed_Name(human, "SubspeciesHomoSapiensSapiens") |> PrefixedName

    /// <summary>
    ///   <para>human:Woman</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>"woman"</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/human#Woman">http://eulersharp.sourceforge.net/2003/03swap/human#Woman</seealso>
    let Woman = Prefixed_Name(human, "Woman") |> PrefixedName
    /// <summary>
    ///   <para>human:Women</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>"women"</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/human#Women">http://eulersharp.sourceforge.net/2003/03swap/human#Women</seealso>
    let Women = Prefixed_Name(human, "Women") |> PrefixedName
    /// <summary>
    ///   <para>human:Working</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>human:OccupationalStatus</para>
    ///
    /// labels<para>"working"</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/human#Working">http://eulersharp.sourceforge.net/2003/03swap/human#Working</seealso>
    let Working = Prefixed_Name(human, "Working") |> PrefixedName

    /// <summary>
    ///   <para>human:WrittenLanguageUnderstandingSkill</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>human:LanguageUnderstandingSkill</para>
    ///
    /// labels<para>"written language understanding skill"</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/human#WrittenLanguageUnderstandingSkill">http://eulersharp.sourceforge.net/2003/03swap/human#WrittenLanguageUnderstandingSkill</seealso>
    let WrittenLanguageUnderstandingSkill =
        Prefixed_Name(human, "WrittenLanguageUnderstandingSkill") |> PrefixedName

    /// <summary>
    ///   <para>human:contactPersonFor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/human#contactPersonFor">http://eulersharp.sourceforge.net/2003/03swap/human#contactPersonFor</seealso>
    let contactPersonFor = Prefixed_Name(human, "contactPersonFor") |> PrefixedName
    /// <summary>
    ///   <para>human:contactPersonOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/human#contactPersonOf">http://eulersharp.sourceforge.net/2003/03swap/human#contactPersonOf</seealso>
    let contactPersonOf = Prefixed_Name(human, "contactPersonOf") |> PrefixedName
    /// <summary>
    ///   <para>human:female</para>
    /// </summary>
    /// <remarks>
    ///   <para>human:BiologicalGender</para>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>"humanly female"</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/human#female">http://eulersharp.sourceforge.net/2003/03swap/human#female</seealso>
    let female = Prefixed_Name(human, "female") |> PrefixedName

    /// <summary>
    ///   <para>human:forWhichIsContactPerson</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/human#forWhichIsContactPerson">http://eulersharp.sourceforge.net/2003/03swap/human#forWhichIsContactPerson</seealso>
    let forWhichIsContactPerson =
        Prefixed_Name(human, "forWhichIsContactPerson") |> PrefixedName

    /// <summary>
    ///   <para>human:hasAdministrativeGender</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/human#hasAdministrativeGender">http://eulersharp.sourceforge.net/2003/03swap/human#hasAdministrativeGender</seealso>
    let hasAdministrativeGender =
        Prefixed_Name(human, "hasAdministrativeGender") |> PrefixedName

    /// <summary>
    ///   <para>human:hasBiologicalGender</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/human#hasBiologicalGender">http://eulersharp.sourceforge.net/2003/03swap/human#hasBiologicalGender</seealso>
    let hasBiologicalGender =
        Prefixed_Name(human, "hasBiologicalGender") |> PrefixedName

    /// <summary>
    ///   <para>human:hasBodyMassIndex</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/human#hasBodyMassIndex">http://eulersharp.sourceforge.net/2003/03swap/human#hasBodyMassIndex</seealso>
    let hasBodyMassIndex = Prefixed_Name(human, "hasBodyMassIndex") |> PrefixedName
    /// <summary>
    ///   <para>human:hasContactPerson</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/human#hasContactPerson">http://eulersharp.sourceforge.net/2003/03swap/human#hasContactPerson</seealso>
    let hasContactPerson = Prefixed_Name(human, "hasContactPerson") |> PrefixedName
    /// <summary>
    ///   <para>human:hasInformedConsent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/human#hasInformedConsent">http://eulersharp.sourceforge.net/2003/03swap/human#hasInformedConsent</seealso>
    let hasInformedConsent = Prefixed_Name(human, "hasInformedConsent") |> PrefixedName
    /// <summary>
    ///   <para>human:hasLength</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/human#hasLength">http://eulersharp.sourceforge.net/2003/03swap/human#hasLength</seealso>
    let hasLength = Prefixed_Name(human, "hasLength") |> PrefixedName

    /// <summary>
    ///   <para>human:hasOccupationalStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/human#hasOccupationalStatus">http://eulersharp.sourceforge.net/2003/03swap/human#hasOccupationalStatus</seealso>
    let hasOccupationalStatus =
        Prefixed_Name(human, "hasOccupationalStatus") |> PrefixedName

    /// <summary>
    ///   <para>human:hasSurfaceArea</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/human#hasSurfaceArea">http://eulersharp.sourceforge.net/2003/03swap/human#hasSurfaceArea</seealso>
    let hasSurfaceArea = Prefixed_Name(human, "hasSurfaceArea") |> PrefixedName
    /// <summary>
    ///   <para>human:hasWeightStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/human#hasWeightStatus">http://eulersharp.sourceforge.net/2003/03swap/human#hasWeightStatus</seealso>
    let hasWeightStatus = Prefixed_Name(human, "hasWeightStatus") |> PrefixedName

    /// <summary>
    ///   <para>human:informedlyConsentsTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/human#informedlyConsentsTo">http://eulersharp.sourceforge.net/2003/03swap/human#informedlyConsentsTo</seealso>
    let informedlyConsentsTo =
        Prefixed_Name(human, "informedlyConsentsTo") |> PrefixedName

    /// <summary>
    ///   <para>human:intersexual</para>
    /// </summary>
    /// <remarks>
    ///   <para>human:BiologicalGender</para>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>"human intersexual"</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/human#intersexual">http://eulersharp.sourceforge.net/2003/03swap/human#intersexual</seealso>
    let intersexual = Prefixed_Name(human, "intersexual") |> PrefixedName
    /// <summary>
    ///   <para>human:male</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>human:BiologicalGender</para>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>"humanly male"</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/human#male">http://eulersharp.sourceforge.net/2003/03swap/human#male</seealso>
    let male = Prefixed_Name(human, "male") |> PrefixedName
    /// <summary>
    ///   <para>human:weighs</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/human#weighs">http://eulersharp.sourceforge.net/2003/03swap/human#weighs</seealso>
    let weighs = Prefixed_Name(human, "weighs") |> PrefixedName
    /// <summary>
    ///   <para>human:weighsAtBirth</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/human#weighsAtBirth">http://eulersharp.sourceforge.net/2003/03swap/human#weighsAtBirth</seealso>
    let weighsAtBirth = Prefixed_Name(human, "weighsAtBirth") |> PrefixedName
