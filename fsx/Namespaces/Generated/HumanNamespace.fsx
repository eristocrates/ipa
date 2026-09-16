#I @"D:\https\com\github\eristocrates\ipa\fsx"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module human =
    let _prefixId = PrefixId.fromNamespaceLabel "http://eulersharp.sourceforge.net/2003/03swap/human#" "human"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:label : administrative female</para>
    ///   <para>skos:definition : Being officially registered as female.</para>
    ///   <para>skos:note : Can differ from the biological gender.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/human#AdministrativeFemale">human:AdministrativeFemale</a>
    /// </summary>
    let AdministrativeFemale = _prefixId.prefix "AdministrativeFemale"
    /// <summary>
    ///   <para>rdfs:label : administrative gender</para>
    ///   <para>skos:definition : Officially registered gender of a human.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/human#AdministrativeGender">human:AdministrativeGender</a>
    /// </summary>
    let AdministrativeGender = _prefixId.prefix "AdministrativeGender"
    /// <summary>
    ///   <para>rdfs:label : administrative male</para>
    ///   <para>skos:definition : Being officially registered as male.</para>
    ///   <para>skos:note : Can differ from the biological gender.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/human#AdministrativeMale">human:AdministrativeMale</a>
    /// </summary>
    let AdministrativeMale = _prefixId.prefix "AdministrativeMale"
    /// <summary>
    ///   <para>rdfs:label : advance directives report</para>
    ///   <para>skos:definition : Report with a person's advance directives about treatment and who can decide in place in case the person cannot decide anymore.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/human#AdvanceDirectivesReport">human:AdvanceDirectivesReport</a>
    /// </summary>
    let AdvanceDirectivesReport = _prefixId.prefix "AdvanceDirectivesReport"
    /// <summary>
    ///   <para>rdfs:label : average linguistic skill</para>
    ///   <para>skos:definition : Average linguistic skill level of a person.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/human#AverageLinguisticSkill">human:AverageLinguisticSkill</a>
    /// </summary>
    let AverageLinguisticSkill = _prefixId.prefix "AverageLinguisticSkill"
    /// <summary>
    ///   <para>rdfs:label : biologically adult human</para>
    ///   <para>skos:definition : Person having attained reproductive ability or evidencing secondary sex characteristics.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/human#BiologicalAdult">human:BiologicalAdult</a>
    /// </summary>
    let BiologicalAdult = _prefixId.prefix "BiologicalAdult"
    let BiologicalFather = _prefixId.prefix "BiologicalFather"
    /// <summary>
    ///   <para>rdfs:label : biological gender</para>
    ///   <para>skos:definition : Biological gender of a human.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/human#BiologicalGender">human:BiologicalGender</a>
    /// </summary>
    let BiologicalGender = _prefixId.prefix "BiologicalGender"
    let BiologicalMother = _prefixId.prefix "BiologicalMother"
    /// <summary>
    ///   <para>rdfs:label : biological human parent</para>
    ///   <para>skos:definition : First grade living ascendant of a human.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/human#BiologicalParent">human:BiologicalParent</a>
    /// </summary>
    let BiologicalParent = _prefixId.prefix "BiologicalParent"
    /// <summary>
    ///   <para>rdfs:label : contact person role</para>
    ///   <para>skos:definition : Person that can be contacted about something.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/human#ContactPerson">human:ContactPerson</a>
    /// </summary>
    let ContactPerson = _prefixId.prefix "ContactPerson"
    /// <summary>
    ///   <para>rdfs:label : human female</para>
    ///   <para>skos:definition : Human of the female biological gender.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/human#Female">human:Female</a>
    /// </summary>
    let Female = _prefixId.prefix "Female"
    /// <summary>
    ///   <para>rdfs:label : human fetus</para>
    ///   <para>skos:definition : Immature human in the uterus after the end of the second month of gestation.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/human#Fetus">human:Fetus</a>
    /// </summary>
    let Fetus = _prefixId.prefix "Fetus"
    /// <summary>
    ///   <para>rdfs:label : fluent linguistic skill</para>
    ///   <para>skos:definition : Fluent linguistic skill level of a person.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/human#FluentLinguisticSkill">human:FluentLinguisticSkill</a>
    /// </summary>
    let FluentLinguisticSkill = _prefixId.prefix "FluentLinguisticSkill"
    /// <summary>
    ///   <para>rdfs:label : good linguistic skill</para>
    ///   <para>skos:definition : Good linguistic skill level of a person.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/human#GoodLinguisticSkill">human:GoodLinguisticSkill</a>
    /// </summary>
    let GoodLinguisticSkill = _prefixId.prefix "GoodLinguisticSkill"
    /// <summary>
    ///   <para>rdfs:label : human</para>
    ///   <para>skos:definition : Member of the subspecies Homo sapiens sapiens.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/human#Human">human:Human</a>
    /// </summary>
    let Human = _prefixId.prefix "Human"
    let Husband = _prefixId.prefix "Husband"
    /// <summary>
    ///   <para>rdfs:label : immature human</para>
    ///   <para>skos:definition : Biologically not full-grown person.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/human#ImmatureHuman">human:ImmatureHuman</a>
    /// </summary>
    let ImmatureHuman = _prefixId.prefix "ImmatureHuman"
    /// <summary>
    ///   <para>rdfs:label : informed consent</para>
    ///   <para>skos:definition : .</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/human#InformedConsent">human:InformedConsent</a>
    /// </summary>
    let InformedConsent = _prefixId.prefix "InformedConsent"
    /// <summary>
    ///   <para>rdfs:label : intersexual</para>
    ///   <para>skos:definition : Human of the intersexual biological gender.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/human#Intersexual">human:Intersexual</a>
    /// </summary>
    let Intersexual = _prefixId.prefix "Intersexual"
    /// <summary>
    ///   <para>rdfs:label : language expressing</para>
    ///   <para>skos:definition : Human expressing a language.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/human#LanguageExpressing">human:LanguageExpressing</a>
    /// </summary>
    let LanguageExpressing = _prefixId.prefix "LanguageExpressing"
    /// <summary>
    ///   <para>rdfs:label : language expression</para>
    ///   <para>skos:definition : Human expression in a language.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/human#LanguageExpression">human:LanguageExpression</a>
    /// </summary>
    let LanguageExpression = _prefixId.prefix "LanguageExpression"
    /// <summary>
    ///   <para>rdfs:label : language expression skill</para>
    ///   <para>skos:definition : Skilled to express in a language.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/human#LanguageExpressionSkill">human:LanguageExpressionSkill</a>
    /// </summary>
    let LanguageExpressionSkill = _prefixId.prefix "LanguageExpressionSkill"
    /// <summary>
    ///   <para>rdfs:label : language signing skill</para>
    ///   <para>skos:definition : Skilled to sign in a language.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/human#LanguageSigningSkill">human:LanguageSigningSkill</a>
    /// </summary>
    let LanguageSigningSkill = _prefixId.prefix "LanguageSigningSkill"
    /// <summary>
    ///   <para>rdfs:label : language speaking skill</para>
    ///   <para>skos:definition : Skilled to speak a language.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/human#LanguageSpeakingSkill">human:LanguageSpeakingSkill</a>
    /// </summary>
    let LanguageSpeakingSkill = _prefixId.prefix "LanguageSpeakingSkill"
    /// <summary>
    ///   <para>rdfs:label : language understanding skill</para>
    ///   <para>skos:definition : Skilled to understand a language.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/human#LanguageUnderstandingSkill">human:LanguageUnderstandingSkill</a>
    /// </summary>
    let LanguageUnderstandingSkill = _prefixId.prefix "LanguageUnderstandingSkill"
    /// <summary>
    ///   <para>rdfs:label : language writing skill</para>
    ///   <para>skos:definition : Skilled to write in a language.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/human#LanguageWritingSkill">human:LanguageWritingSkill</a>
    /// </summary>
    let LanguageWritingSkill = _prefixId.prefix "LanguageWritingSkill"
    /// <summary>
    ///   <para>rdfs:label : legally adult human</para>
    ///   <para>skos:definition : Person being adult as stated by law.</para>
    ///   <para>skos:Note : Further restriction to be given along specific law.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/human#LegalAdult">human:LegalAdult</a>
    /// </summary>
    let LegalAdult = _prefixId.prefix "LegalAdult"
    let LegalFather = _prefixId.prefix "LegalFather"
    let LegalMother = _prefixId.prefix "LegalMother"
    /// <summary>
    ///   <para>rdfs:label : legal human parent</para>
    ///   <para>skos:definition : Parent of a human as stated by law.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/human#LegalParent">human:LegalParent</a>
    /// </summary>
    let LegalParent = _prefixId.prefix "LegalParent"
    /// <summary>
    ///   <para>rdfs:label : human life</para>
    ///   <para>skos:definition : Life of a human.</para>
    ///   <para>skos:note : No satisfying description of onset of a human life.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/human#Life">human:Life</a>
    /// </summary>
    let Life = _prefixId.prefix "Life"
    /// <summary>
    ///   <para>rdfs:label : linguistic skill</para>
    ///   <para>skos:definition : Person's skill concerning a language.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/human#LinguisticSkill">human:LinguisticSkill</a>
    /// </summary>
    let LinguisticSkill = _prefixId.prefix "LinguisticSkill"
    /// <summary>
    ///   <para>rdfs:label : linguistic skill level</para>
    ///   <para>skos:definition : Person's skill level concerning a language.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/human#LinguisticSkillLevel">human:LinguisticSkillLevel</a>
    /// </summary>
    let LinguisticSkillLevel = _prefixId.prefix "LinguisticSkillLevel"
    /// <summary>
    ///   <para>rdfs:label : human male</para>
    ///   <para>skos:definition : Human of the male biological gender.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/human#Male">human:Male</a>
    /// </summary>
    let Male = _prefixId.prefix "Male"
    /// <summary>
    ///   <para>rdfs:label : man</para>
    ///   <para>skos:definition : Adult human male.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/human#Man">human:Man</a>
    /// </summary>
    let Man = _prefixId.prefix "Man"
    /// <summary>
    ///   <para>rdfs:label : men</para>
    ///   <para>skos:definition : Group of which a man is a member.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/human#Men">human:Men</a>
    /// </summary>
    let Men = _prefixId.prefix "Men"
    /// <summary>
    ///   <para>rdfs:label : native linguistic skill</para>
    ///   <para>skos:definition : Linguistic skill level of a person raised in that language.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/human#NativeLinguisticSkill">human:NativeLinguisticSkill</a>
    /// </summary>
    let NativeLinguisticSkill = _prefixId.prefix "NativeLinguisticSkill"
    /// <summary>
    ///   <para>rdfs:label : newborn</para>
    ///   <para>skos:definition : A newborn infant.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/human#Newborn">human:Newborn</a>
    /// </summary>
    let Newborn = _prefixId.prefix "Newborn"
    /// <summary>
    ///   <para>rdfs:label : no linguistic skill</para>
    ///   <para>skos:definition : Linguistic skill level of a person having no knowledge of a language.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/human#NoLinguisticSkill">human:NoLinguisticSkill</a>
    /// </summary>
    let NoLinguisticSkill = _prefixId.prefix "NoLinguisticSkill"
    /// <summary>
    ///   <para>rdfs:label : notices linguistic skill</para>
    ///   <para>skos:definition : Linguistic skill level of a person having only notices of a language.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/human#NoticesLinguisticSkill">human:NoticesLinguisticSkill</a>
    /// </summary>
    let NoticesLinguisticSkill = _prefixId.prefix "NoticesLinguisticSkill"
    /// <summary>
    ///   <para>rdfs:label : human occupation</para>
    ///   <para>skos:definition : Human action serving as one's regular source of livelihood.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/human#Occupation">human:Occupation</a>
    /// </summary>
    let Occupation = _prefixId.prefix "Occupation"
    /// <summary>
    ///   <para>rdfs:label : occupation role</para>
    ///   <para>skos:definition : Role of a person with an occupation.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/human#OccupationRole">human:OccupationRole</a>
    /// </summary>
    let OccupationRole = _prefixId.prefix "OccupationRole"
    /// <summary>
    ///   <para>rdfs:label : occupational status</para>
    ///   <para>skos:definition : State of a person's occupation.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/human#OccupationalStatus">human:OccupationalStatus</a>
    /// </summary>
    let OccupationalStatus = _prefixId.prefix "OccupationalStatus"
    /// <summary>
    ///   <para>rdfs:label : on sick leave</para>
    ///   <para>skos:definition : Occupational status of having stopped working due to a health disorder.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/human#OnSickLeave">human:OnSickLeave</a>
    /// </summary>
    let OnSickLeave = _prefixId.prefix "OnSickLeave"
    let Partner = _prefixId.prefix "Partner"
    /// <summary>
    ///   <para>rdfs:label : person</para>
    ///   <para>skos:definition : A living born human.</para>
    ///   <para>rdfs:comment : human:Human members live and are not necessarily born; foaf:Person members are dead or alive, but born. External conflict: foaf:Person rdfs:subClassOf wordnet:person and wordnet:person wordnet:hyponymOf wordnet:organism, and wordnet:organism wordnet:hyponymOf wordnet:livingThing, but not 'hard coded' since wordnet:hyponymOf used instead of rdfs:subClassOf.</para>
    ///   <para>skos:note : A fetus is not considered as a person, who can have e.g. a health record. The fetus is mentioned in the health record of the mother. The moment the fetus becomes a newborn the fetus part of the record becomes the record of the newborn.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/human#Person">human:Person</a>
    /// </summary>
    let Person = _prefixId.prefix "Person"
    /// <summary>
    ///   <para>rdfs:label : person life</para>
    ///   <para>skos:definition : Life of a person.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/human#PersonLife">human:PersonLife</a>
    /// </summary>
    let PersonLife = _prefixId.prefix "PersonLife"
    /// <summary>
    ///   <para>rdfs:label : person role</para>
    ///   <para>skos:definition : A role a person can play as a social entity.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/human#PersonRole">human:PersonRole</a>
    /// </summary>
    let PersonRole = _prefixId.prefix "PersonRole"
    /// <summary>
    ///   <para>rdfs:label : poor linguistic skill</para>
    ///   <para>skos:definition : Poor linguistic skill level of a person.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/human#PoorLinguisticSkill">human:PoorLinguisticSkill</a>
    /// </summary>
    let PoorLinguisticSkill = _prefixId.prefix "PoorLinguisticSkill"
    /// <summary>
    ///   <para>rdfs:label : pregnant woman</para>
    ///   <para>skos:definition : Woman with offspring developing in her body.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/human#PregnantWoman">human:PregnantWoman</a>
    /// </summary>
    let PregnantWoman = _prefixId.prefix "PregnantWoman"
    /// <summary>
    ///   <para>rdfs:label : retired</para>
    ///   <para>skos:definition : Occupational status of having stopped working.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/human#Retired">human:Retired</a>
    /// </summary>
    let Retired = _prefixId.prefix "Retired"
    /// <summary>
    ///   <para>rdfs:label : human role</para>
    ///   <para>skos:definition : A role a human can play.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/human#Role">human:Role</a>
    /// </summary>
    let Role = _prefixId.prefix "Role"

    /// <summary>
    ///   <para>rdfs:label : signed language understanding skill</para>
    ///   <para>skos:definition : Skilled to understand signed language.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/human#SignedLanguageUnderstandingSkill">human:SignedLanguageUnderstandingSkill</a>
    /// </summary>
    let SignedLanguageUnderstandingSkill = _prefixId.prefix "SignedLanguageUnderstandingSkill"

    /// <summary>
    ///   <para>rdfs:label : spoken language understanding skill</para>
    ///   <para>skos:definition : Skilled to understand spoken language.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/human#SpokenLanguageUnderstandingSkill">human:SpokenLanguageUnderstandingSkill</a>
    /// </summary>
    let SpokenLanguageUnderstandingSkill = _prefixId.prefix "SpokenLanguageUnderstandingSkill"

    let Spouse = _prefixId.prefix "Spouse"
    /// <summary>
    ///   <para>unicore:scientificName : Homo sapiens sapiens</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/human#SubspeciesHomoSapiensSapiens">human:SubspeciesHomoSapiensSapiens</a>
    /// </summary>
    let SubspeciesHomoSapiensSapiens = _prefixId.prefix "SubspeciesHomoSapiensSapiens"
    /// <summary>
    ///   <para>rdfs:label : woman</para>
    ///   <para>skos:definition : Adult human female.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/human#Woman">human:Woman</a>
    /// </summary>
    let Woman = _prefixId.prefix "Woman"
    /// <summary>
    ///   <para>rdfs:label : women</para>
    ///   <para>skos:definition : Group of which a woman is a member.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/human#Women">human:Women</a>
    /// </summary>
    let Women = _prefixId.prefix "Women"
    /// <summary>
    ///   <para>rdfs:label : working</para>
    ///   <para>skos:definition : Occupational status of having a job.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/human#Working">human:Working</a>
    /// </summary>
    let Working = _prefixId.prefix "Working"

    /// <summary>
    ///   <para>rdfs:label : written language understanding skill</para>
    ///   <para>skos:definition : Skilled to understand written language.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/human#WrittenLanguageUnderstandingSkill">human:WrittenLanguageUnderstandingSkill</a>
    /// </summary>
    let WrittenLanguageUnderstandingSkill = _prefixId.prefix "WrittenLanguageUnderstandingSkill"

    /// <summary>
    ///   <para>skos:definition : Specifying something a person can be contacted about.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/human#contactPersonFor">human:contactPersonFor</a>
    /// </summary>
    let contactPersonFor = _prefixId.prefix "contactPersonFor"
    /// <summary>
    ///   <para>skos:definition : Specifying a person having a contact person.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/human#contactPersonOf">human:contactPersonOf</a>
    /// </summary>
    let contactPersonOf = _prefixId.prefix "contactPersonOf"
    /// <summary>
    ///   <para>rdfs:label : humanly female</para>
    ///   <para>skos:definition : Being of a human female gender.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/human#female">human:female</a>
    /// </summary>
    let female = _prefixId.prefix "female"
    /// <summary>
    ///   <para>skos:definition : Specifying a person that can be contacted about something.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/human#forWhichIsContactPerson">human:forWhichIsContactPerson</a>
    /// </summary>
    let forWhichIsContactPerson = _prefixId.prefix "forWhichIsContactPerson"
    /// <summary>
    ///   <para>skos:definition : Specifying the officially registered gender of a person.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/human#hasAdministrativeGender">human:hasAdministrativeGender</a>
    /// </summary>
    let hasAdministrativeGender = _prefixId.prefix "hasAdministrativeGender"
    /// <summary>
    ///   <para>skos:definition : Specifying the biological gender of a human.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/human#hasBiologicalGender">human:hasBiologicalGender</a>
    /// </summary>
    let hasBiologicalGender = _prefixId.prefix "hasBiologicalGender"
    /// <summary>
    ///   <para>skos:definition : Specifying an adult human's body mass index measurement.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/human#hasBodyMassIndex">human:hasBodyMassIndex</a>
    /// </summary>
    let hasBodyMassIndex = _prefixId.prefix "hasBodyMassIndex"
    /// <summary>
    ///   <para>skos:definition : Specifying a contact person of another person.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/human#hasContactPerson">human:hasContactPerson</a>
    /// </summary>
    let hasContactPerson = _prefixId.prefix "hasContactPerson"
    /// <summary>
    ///   <para>skos:definition : Specifying an informed consent of a legally adult human.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/human#hasInformedConsent">human:hasInformedConsent</a>
    /// </summary>
    let hasInformedConsent = _prefixId.prefix "hasInformedConsent"
    /// <summary>
    ///   <para>skos:definition : Specifying a human's length measurement.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/human#hasLength">human:hasLength</a>
    /// </summary>
    let hasLength = _prefixId.prefix "hasLength"
    /// <summary>
    ///   <para>skos:definition : Specifying a status of a person's occupation.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/human#hasOccupationalStatus">human:hasOccupationalStatus</a>
    /// </summary>
    let hasOccupationalStatus = _prefixId.prefix "hasOccupationalStatus"
    /// <summary>
    ///   <para>skos:definition : Specifying a human's surface area measurement.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/human#hasSurfaceArea">human:hasSurfaceArea</a>
    /// </summary>
    let hasSurfaceArea = _prefixId.prefix "hasSurfaceArea"
    /// <summary>
    ///   <para>skos:definition : Specifying a body weight status of a human.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/human#hasWeightStatus">human:hasWeightStatus</a>
    /// </summary>
    let hasWeightStatus = _prefixId.prefix "hasWeightStatus"
    /// <summary>
    ///   <para>skos:definition : Specifying an action a legally adult human informedly consents to.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/human#informedlyConsentsTo">human:informedlyConsentsTo</a>
    /// </summary>
    let informedlyConsentsTo = _prefixId.prefix "informedlyConsentsTo"
    /// <summary>
    ///   <para>rdfs:label : human intersexual</para>
    ///   <para>skos:definition : Being of a gender that is neither male or female, with biological characteristics of both.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/human#intersexual">human:intersexual</a>
    /// </summary>
    let intersexual = _prefixId.prefix "intersexual"
    /// <summary>
    ///   <para>rdfs:label : humanly male</para>
    ///   <para>skos:definition : Being of a human male gender.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/human#male">human:male</a>
    /// </summary>
    let male = _prefixId.prefix "male"
    /// <summary>
    ///   <para>skos:definition : Specifying a human's weight measurement.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/human#weighs">human:weighs</a>
    /// </summary>
    let weighs = _prefixId.prefix "weighs"
    /// <summary>
    ///   <para>skos:definition : Specifying a human's birth weight measurement.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/human#weighsAtBirth">human:weighsAtBirth</a>
    /// </summary>
    let weighsAtBirth = _prefixId.prefix "weighsAtBirth"
