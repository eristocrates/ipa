#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module coreo =
    let _prefixId = PrefixId.fromNamespaceLabel "http://purl.org/coreo#" "coreo"
    /// <summary>
    ///   <para>rdfs:label : Agent</para>
    ///   <para>rdfs:comment : Agents are objects that perceive events and perform actions based on their intentions</para>
    ///   <a href="http://purl.org/coreo#Agent">coreo:Agent</a>
    /// </summary>
    let Agent = _prefixId.prefix "Agent"
    /// <summary>
    ///   <para>rdfs:label : Artifact</para>
    ///   <para>rdfs:comment : Human-made object produced, used, or changed in task as a result of human capabilities
    ///
    /// E.G., Web form code (produced by John)^^xsd:string</para>
    ///   <a href="http://purl.org/coreo#Artifact">coreo:Artifact</a>
    /// </summary>
    let Artifact = _prefixId.prefix "Artifact"
    /// <summary>
    ///   <para>rdfs:label : ArtifactType</para>
    ///   <para>rdfs:comment : A gufo:Type whose instances are coreo:Artifact.
    ///
    /// Instances of coreo:ArtifactType are subclasses of coreo:Artifact.
    ///
    /// Examples include "Web Form", "Class Diagram", "Painting", a "Sculpture"</para>
    ///   <a href="http://purl.org/coreo#ArtifactType">coreo:ArtifactType</a>
    /// </summary>
    let ArtifactType = _prefixId.prefix "ArtifactType"
    /// <summary>
    ///   <para>rdfs:label : Attitude</para>
    ///   <para>rdfs:comment : Attitude is a tendency to act (or feel) in a given situation (Maze, 2011) inherent to an individual, based on assumptions, values, and beliefs (Maze, 2011). In general, definitions of attitude take into account the following characteristics: (i) mental state; (ii) values (beliefs,
    /// emotions); and (iii) predisposition to act or behave (ALTMANN, 2008).
    ///
    /// E.g. John' accuracy, Paul' responsability, Mary' colaboration
    ///
    /// ALTMANN, Tanya K. Attitude: a concept analysis. In: Nursing forum. Malden, USA: Blackwell Publishing Inc, 2008. p. 144-150.
    ///
    /// MAZE, John R. The concept of attitude. In: Realism and Psychology. Brill, 2011. p. 183-230.</para>
    ///   <a href="http://purl.org/coreo#Attitude">coreo:Attitude</a>
    /// </summary>
    let Attitude = _prefixId.prefix "Attitude"
    /// <summary>
    ///   <para>rdfs:label : AttitudeType</para>
    ///   <para>rdfs:comment : A gufo:Type whose instances are coreo:Attitude.
    ///
    /// Instances of coreo:AttitudeType are subclasses of coreo:Attitude.
    ///
    /// Examples include the coreo:HumanAttitude "Collaboration"</para>
    ///   <a href="http://purl.org/coreo#AttitudeType">coreo:AttitudeType</a>
    /// </summary>
    let AttitudeType = _prefixId.prefix "AttitudeType"
    let CapabilityContext = _prefixId.prefix "CapabilityContext"
    let CapabilityManifestation = _prefixId.prefix "CapabilityManifestation"
    let CapabilityOutcome = _prefixId.prefix "CapabilityOutcome"
    /// <summary>
    ///   <para>rdfs:label : CapabilityRequiringRole</para>
    ///   <a href="http://purl.org/coreo#CapabilityRequiringRole">coreo:CapabilityRequiringRole</a>
    /// </summary>
    let CapabilityRequiringRole = _prefixId.prefix "CapabilityRequiringRole"
    /// <summary>
    ///   <para>rdfs:label : CompetenceContextrdfs:label : Competence Context</para>
    ///   <a href="http://purl.org/coreo#CompetenceContext">coreo:CompetenceContext</a>
    /// </summary>
    let CompetenceContext = _prefixId.prefix "CompetenceContext"
    /// <summary>
    ///   <para>rdfs:label : CompetenceOutcome</para>
    ///   <a href="http://purl.org/coreo#CompetenceOutcome">coreo:CompetenceOutcome</a>
    /// </summary>
    let CompetenceOutcome = _prefixId.prefix "CompetenceOutcome"
    let CompetenceType = _prefixId.prefix "CompetenceType"
    let EndurantType = _prefixId.prefix "EndurantType"
    /// <summary>
    ///   <para>rdfs:label : Evidence</para>
    ///   <para>rdfs:comment : Any object (social or not) used to prove a human capability.
    /// E.G.  John's graduation certification in computer science,  Mary's project participation.</para>
    ///   <a href="http://purl.org/coreo#Evidence">coreo:Evidence</a>
    /// </summary>
    let Evidence = _prefixId.prefix "Evidence"
    /// <summary>
    ///   <para>rdfs:label : Field</para>
    ///   <para>rdfs:comment : Knowledge Area</para>
    ///   <a href="http://purl.org/coreo#Field">coreo:Field</a>
    /// </summary>
    let Field = _prefixId.prefix "Field"
    /// <summary>
    ///   <para>rdfs:label : HumanAspect</para>
    ///   <para>rdfs:comment : Aspects inherent to an individual. Includes human capabilities (skills and competences), knowledge, attidutes, and other characteristics (human qualities as age, gender, etc and human traits).</para>
    ///   <a href="http://purl.org/coreo#HumanAspect">coreo:HumanAspect</a>
    /// </summary>
    let HumanAspect = _prefixId.prefix "HumanAspect"
    /// <summary>
    ///   <para>rdfs:label : HumanAspectPhase</para>
    ///   <a href="http://purl.org/coreo#HumanAspectPhase">coreo:HumanAspectPhase</a>
    /// </summary>
    let HumanAspectPhase = _prefixId.prefix "HumanAspectPhase"
    /// <summary>
    ///   <para>rdfs:label : HumanAspectType</para>
    ///   <para>rdfs:comment : A gufo:Type whose instances are coreo:HumanAspect.
    ///
    /// Instances of coreo:HumanAspectType are subclasses of coreo:HumanAspect.
    ///
    /// Examples include the coreo:SkillType "Java Programming", the coreo:CompetenceType "Software Development", the coreo:HumanAttitude "Collaboration", the coreo:HumanKnowledge "Quantum Physics", the coreo:HumanCharacteristic "Age", "Gender", and "Interest"</para>
    ///   <a href="http://purl.org/coreo#HumanAspectType">coreo:HumanAspectType</a>
    /// </summary>
    let HumanAspectType = _prefixId.prefix "HumanAspectType"
    /// <summary>
    ///   <para>rdfs:label : HumanCapability</para>
    ///   <para>rdfs:comment : Human ability to perform some task in some situation, inherent to an individual. Includes skills and personal competences.</para>
    ///   <a href="http://purl.org/coreo#HumanCapability">coreo:HumanCapability</a>
    /// </summary>
    let HumanCapability = _prefixId.prefix "HumanCapability"
    /// <summary>
    ///   <para>rdfs:label : HumanCapabilityType</para>
    ///   <para>rdfs:comment : A gufo:Type whose instances are dispositions.
    ///
    /// Instances of coreo:HumanCapabilityType are subclasses of coreo:HumanCapability.
    ///
    /// Examples include the skill type of "Java Programming" and competence type of "Software Development"</para>
    ///   <a href="http://purl.org/coreo#HumanCapabilityType">coreo:HumanCapabilityType</a>
    /// </summary>
    let HumanCapabilityType = _prefixId.prefix "HumanCapabilityType"
    let HumanCharacteristic = _prefixId.prefix "HumanCharacteristic"
    /// <summary>
    ///   <para>rdfs:label : HumanQuality</para>
    ///   <para>rdfs:comment : Qualities inherent to a person, e.g. age, gender, height, etc.</para>
    ///   <a href="http://purl.org/coreo#HumanQuality">coreo:HumanQuality</a>
    /// </summary>
    let HumanQuality = _prefixId.prefix "HumanQuality"
    /// <summary>
    ///   <para>rdfs:label : HumanTask</para>
    ///   <para>rdfs:comment : Event performed by a person as a result of the manifestation of his/her human capabilities</para>
    ///   <a href="http://purl.org/coreo#HumanTask">coreo:HumanTask</a>
    /// </summary>
    let HumanTask = _prefixId.prefix "HumanTask"
    /// <summary>
    ///   <para>rdfs:label : HumanTrait</para>
    ///   <para>rdfs:comment : Traits inherent to an individual, e.g. John's introversion, Paul's interest, Mary's hobbies</para>
    ///   <a href="http://purl.org/coreo#HumanTrait">coreo:HumanTrait</a>
    /// </summary>
    let HumanTrait = _prefixId.prefix "HumanTrait"
    /// <summary>
    ///   <para>rdfs:label : Knowledge</para>
    ///   <para>rdfs:comment : Knowledge is typically associated with internal representations of facts, principles, or theories (WESTERA, 2001) by an individual. and that can be manifested through actions.
    ///
    /// E.G., Paul' quantum theory knowledge
    ///
    /// WESTERA, Wim. Competences in education: a confusion of tongues. Journal of Curriculum studies, v. 33, n. 1, p. 75-88, 2001.</para>
    ///   <a href="http://purl.org/coreo#Knowledge">coreo:Knowledge</a>
    /// </summary>
    let Knowledge = _prefixId.prefix "Knowledge"
    /// <summary>
    ///   <para>rdfs:label : KnowledgeType</para>
    ///   <para>rdfs:comment : A gufo:Type whose instances are coreo:Knowledge.
    ///
    /// Instances of coreo:KnowledgeType are subclasses of coreo:Knowledge.
    ///
    /// Examples include the the coreo:KnowledgeType "Quantum Physics"</para>
    ///   <a href="http://purl.org/coreo#KnowledgeType">coreo:KnowledgeType</a>
    /// </summary>
    let KnowledgeType = _prefixId.prefix "KnowledgeType"
    /// <summary>
    ///   <para>rdfs:label : AspectType</para>
    ///   <para>rdfs:comment : A gufo:Type whose instances are aspects.
    ///
    /// Instances of AspectType are subclasses of gufo:Aspect.
    ///
    /// Examples include the aspect kind "age", "knowledge", and "mariage"</para>
    ///   <a href="http://purl.org/coreo#MomentType">coreo:MomentType</a>
    /// </summary>
    let MomentType = _prefixId.prefix "MomentType"
    /// <summary>
    ///   <para>rdfs:label : Object</para>
    ///   <a href="http://purl.org/coreo#Object">coreo:Object</a>
    /// </summary>
    let Object = _prefixId.prefix "Object"
    let PerdurantType = _prefixId.prefix "PerdurantType"
    /// <summary>
    ///   <para>rdfs:label : Person</para>
    ///   <para>rdfs:comment : Physical agent that are human being</para>
    ///   <a href="http://purl.org/coreo#Person">coreo:Person</a>
    /// </summary>
    let Person = _prefixId.prefix "Person"
    /// <summary>
    ///   <para>rdfs:label : PersonalCompetence</para>
    ///   <para>rdfs:comment : Competence is a human capability inherent to an individual and formed by the combination of perceptible characteristics, such as the ``well-known'' knowledge, skills, and attitudes (KSA) elements.
    ///
    ///
    /// E.G. John's agile software development competence, Ronaldo's football playing competence</para>
    ///   <a href="http://purl.org/coreo#PersonalCompetence">coreo:PersonalCompetence</a>
    /// </summary>
    let PersonalCompetence = _prefixId.prefix "PersonalCompetence"
    /// <summary>
    ///   <para>rdfs:label : PersonalCompetenceType</para>
    ///   <a href="http://purl.org/coreo#PersonalCompetenceType">coreo:PersonalCompetenceType</a>
    /// </summary>
    let PersonalCompetenceType = _prefixId.prefix "PersonalCompetenceType"
    let Phase = _prefixId.prefix "Phase"
    let PhysicalAgent = _prefixId.prefix "PhysicalAgent"
    /// <summary>
    ///   <para>rdfs:label : Proficiency</para>
    ///   <para>rdfs:comment : Intencity or deepness of a human capability. Can be related to level, degree, score, or other quality.</para>
    ///   <a href="http://purl.org/coreo#Proficiency">coreo:Proficiency</a>
    /// </summary>
    let Proficiency = _prefixId.prefix "Proficiency"
    /// <summary>
    ///   <para>rdfs:label : Resource</para>
    ///   <para>rdfs:comment : Any object used in a task by a person as manifestation of a human capability
    ///
    /// E.G. John's Integrated Development Environment (IDE)</para>
    ///   <a href="http://purl.org/coreo#Resource">coreo:Resource</a>
    /// </summary>
    let Resource = _prefixId.prefix "Resource"
    /// <summary>
    ///   <para>rdfs:label : ResourceType</para>
    ///   <para>rdfs:comment : A gufo:Type whose instances are coreo:Resource.
    ///
    /// Instances of coreo:ResourceType are subclasses of coreo:Resource.
    ///
    /// Examples include "Tool", "Software", "Hardware"</para>
    ///   <a href="http://purl.org/coreo#ResourceType">coreo:ResourceType</a>
    /// </summary>
    let ResourceType = _prefixId.prefix "ResourceType"
    let Role = _prefixId.prefix "Role"
    let SituationType = _prefixId.prefix "SituationType"
    /// <summary>
    ///   <para>rdfs:label : Skill</para>
    ///   <para>rdfs:comment : Skill is a human capability of an individual to perform a task (discrete unit of work) well (RODRIGUES et al, 2021), not strongly related to a context.
    ///
    /// E.G. John' programming skill, Pelé's kick skill
    ///
    ///
    /// RODRIGUES, Margarida; FERNÁNDEZ-MACÍAS, Enrique; SOSTERO, Matteo. A unified conceptual framework of tasks, skills and competences. JRC Working Papers Series on Labour, Education and Technology, 2021.</para>
    ///   <a href="http://purl.org/coreo#Skill">coreo:Skill</a>
    /// </summary>
    let Skill = _prefixId.prefix "Skill"
    /// <summary>
    ///   <para>rdfs:label : SkillType</para>
    ///   <para>rdfs:comment : A gufo:Type whose instances are coreo:Skill.
    ///
    /// Instances of coreo:SkillType are subclasses of coreo:Skill.
    ///
    /// Examples include the skill type of "Java Programming"</para>
    ///   <a href="http://purl.org/coreo#SkillType">coreo:SkillType</a>
    /// </summary>
    let SkillType = _prefixId.prefix "SkillType"
    let SocialAgent = _prefixId.prefix "SocialAgent"
    /// <summary>
    ///   <para>rdfs:label : ObjectTyperdfs:label : SubstantialType</para>
    ///   <para>rdfs:comment : A gufo:Type whose instances are objects.
    ///
    /// Instances of ObjectType are subclasses of Object.
    ///
    /// Examples include the object kinds "Car", "Person", "Apple"</para>
    ///   <a href="http://purl.org/coreo#SubstantialType">coreo:SubstantialType</a>
    /// </summary>
    let SubstantialType = _prefixId.prefix "SubstantialType"
    /// <summary>
    ///   <para>rdfs:label : TaskInput</para>
    ///   <para>rdfs:comment : Artifact used in a task as manifestation of a human capability</para>
    ///   <a href="http://purl.org/coreo#TaskInput">coreo:TaskInput</a>
    /// </summary>
    let TaskInput = _prefixId.prefix "TaskInput"
    let TaskOutcome = _prefixId.prefix "TaskOutcome"
    /// <summary>
    ///   <para>rdfs:label : TaskOutput</para>
    ///   <para>rdfs:comment : Artifact created or changed in a task as manifestation of a human capability</para>
    ///   <a href="http://purl.org/coreo#TaskOutput">coreo:TaskOutput</a>
    /// </summary>
    let TaskOutput = _prefixId.prefix "TaskOutput"
    /// <summary>
    ///   <para>rdfs:label : TaskType</para>
    ///   <para>rdfs:comment : A gufo:Type whose instances are coreo:Task.
    ///
    /// Instances of coreo:TaskType are subclasses of coreo:Task.
    ///
    /// Examples include "Develop a Software", "Perform a Interview"</para>
    ///   <a href="http://purl.org/coreo#TaskType">coreo:TaskType</a>
    /// </summary>
    let TaskType = _prefixId.prefix "TaskType"
    let Type = _prefixId.prefix "Type"
    /// <summary>
    ///   <para>rdfs:label : bringsAbout</para>
    ///   <para>rdfs:comment : Details the SituationType that a coreo:TaskType can result</para>
    ///   <a href="http://purl.org/coreo#bringsAbout">coreo:bringsAbout</a>
    /// </summary>
    let bringsAbout = _prefixId.prefix "bringsAbout"
    /// <summary>
    ///   <para>rdfs:label : </para>
    ///   <a href="http://purl.org/coreo#broughtAboutHumanTask">coreo:broughtAboutHumanTask</a>
    /// </summary>
    let broughtAboutHumanTask = _prefixId.prefix "broughtAboutHumanTask"

    /// <summary>
    ///   <para>rdfs:label : hasField</para>
    ///   <para>rdfs:comment : Describes the field of a coreo:CapabilityRequiringRole</para>
    ///   <a href="http://purl.org/coreo#capabilityRequiringRoleHasField">coreo:capabilityRequiringRoleHasField</a>
    /// </summary>
    let capabilityRequiringRoleHasField =
        _prefixId.prefix "capabilityRequiringRoleHasField"

    /// <summary>
    ///   <para>rdfs:label : characterizedBy</para>
    ///   <para>rdfs:comment : Relationship used to detail a coreo:ArtifactType</para>
    ///   <a href="http://purl.org/coreo#characterizedBy">coreo:characterizedBy</a>
    /// </summary>
    let characterizedBy = _prefixId.prefix "characterizedBy"

    /// <summary>
    ///   <para>rdfs:label : activatesTask</para>
    ///   <para>rdfs:comment : Identifies a coreo:HumanTask that the coreo:CompetenceContext contributed to trigger.</para>
    ///   <a href="http://purl.org/coreo#competenceContextContributedToTriggerHumanTask">coreo:competenceContextContributedToTriggerHumanTask</a>
    /// </summary>
    let competenceContextContributedToTriggerHumanTask =
        _prefixId.prefix "competenceContextContributedToTriggerHumanTask"

    /// <summary>
    ///   <para>rdfs:label : concernsArtifact</para>
    ///   <para>rdfs:comment : Relationship used to detail a coreo:TaskType</para>
    ///   <a href="http://purl.org/coreo#concerns">coreo:concerns</a>
    /// </summary>
    let concerns = _prefixId.prefix "concerns"
    /// <summary>
    ///   <para>rdfs:label : concernsResource</para>
    ///   <para>rdfs:comment : Relationship used to detail a coreo:TaskType</para>
    ///   <a href="http://purl.org/coreo#concerns_1">coreo:concerns_1</a>
    /// </summary>
    let concerns_1 = _prefixId.prefix "concerns_1"
    /// <summary>
    ///   <para>rdfs:label : constitutesAspect</para>
    ///   <para>rdfs:comment : Describes the constitutive relationship between coreo:HumanAspectTypes manifested as parthood relationships between their instances</para>
    ///   <a href="http://purl.org/coreo#constitutes">coreo:constitutes</a>
    /// </summary>
    let constitutes = _prefixId.prefix "constitutes"
    /// <summary>
    ///   <para>rdfs:label : constitutesType</para>
    ///   <para>rdfs:comment : Describes the constitutive relationship between types manifested as parthood relationships between their instances</para>
    ///   <a href="http://purl.org/coreo#constitutesType">coreo:constitutesType</a>
    /// </summary>
    let constitutesType = _prefixId.prefix "constitutesType"
    /// <summary>
    ///   <para>rdfs:label : contributesTo</para>
    ///   <para>rdfs:comment : Describes the contribution relation between a coreo:HumanQuality and a coreo:PersonalCompetence</para>
    ///   <a href="http://purl.org/coreo#contributesTo">coreo:contributesTo</a>
    /// </summary>
    let contributesTo = _prefixId.prefix "contributesTo"
    /// <summary>
    ///   <para>rdfs:label : definedInTermsOf</para>
    ///   <para>rdfs:comment : Relationship used to detail a coreo:HumanCapabilityType</para>
    ///   <a href="http://purl.org/coreo#definedInTermsOf">coreo:definedInTermsOf</a>
    /// </summary>
    let definedInTermsOf = _prefixId.prefix "definedInTermsOf"
    /// <summary>
    ///   <para>rdfs:label : dependsOnTask</para>
    ///   <para>rdfs:comment : Describes the dependence relationship between types manifested as dependence relationships between their instances</para>
    ///   <a href="http://purl.org/coreo#dependsOn">coreo:dependsOn</a>
    /// </summary>
    let dependsOn = _prefixId.prefix "dependsOn"
    /// <summary>
    ///   <para>rdfs:label : dependsOnType</para>
    ///   <para>rdfs:comment : Describes the dependence relationship between types manifested as dependence relationships between their instances</para>
    ///   <a href="http://purl.org/coreo#dependsOnType">coreo:dependsOnType</a>
    /// </summary>
    let dependsOnType = _prefixId.prefix "dependsOnType"
    /// <summary>
    ///   <para>rdfs:label : dependsOnArtifact</para>
    ///   <para>rdfs:comment : Describes the dependence relationship between types manifested as dependence relationships between their instances</para>
    ///   <a href="http://purl.org/coreo#dependsOn_1">coreo:dependsOn_1</a>
    /// </summary>
    let dependsOn_1 = _prefixId.prefix "dependsOn_1"
    /// <summary>
    ///   <para>rdfs:label : dependsOnHumanAspect</para>
    ///   <para>rdfs:comment : Describes the dependence relationship between types manifested as dependence relationships between their instances</para>
    ///   <a href="http://purl.org/coreo#dependsOn_2">coreo:dependsOn_2</a>
    /// </summary>
    let dependsOn_2 = _prefixId.prefix "dependsOn_2"
    /// <summary>
    ///   <para>rdfs:label : dependsOnRole</para>
    ///   <para>rdfs:comment : Describes the dependence relationship between types manifested as dependence relationships between their instances</para>
    ///   <a href="http://purl.org/coreo#dependsOn_3">coreo:dependsOn_3</a>
    /// </summary>
    let dependsOn_3 = _prefixId.prefix "dependsOn_3"
    /// <summary>
    ///   <para>rdfs:label : describedBy</para>
    ///   <para>rdfs:comment : Relationship used to detail a type</para>
    ///   <a href="http://purl.org/coreo#describedBy">coreo:describedBy</a>
    /// </summary>
    let describedBy = _prefixId.prefix "describedBy"
    /// <summary>
    ///   <para>rdfs:label : enablesSituationType</para>
    ///   <para>rdfs:comment : Relationship used to detail types of contexts that activates HumanCapabilityTypes</para>
    ///   <a href="http://purl.org/coreo#enables">coreo:enables</a>
    /// </summary>
    let enables = _prefixId.prefix "enables"
    /// <summary>
    ///   <para>rdfs:label : evidencedBy</para>
    ///   <para>rdfs:comment : evidances of a coreo:HumanAspect</para>
    ///   <a href="http://purl.org/coreo#evidencedBy">coreo:evidencedBy</a>
    /// </summary>
    let evidencedBy = _prefixId.prefix "evidencedBy"
    /// <summary>
    ///   <para>rdfs:label : inheresInHumanCapability</para>
    ///   <para>rdfs:comment : relates a coreo:Proficiency to the correspondent coreo:HumanCapability</para>
    ///   <a href="http://purl.org/coreo#inheresIn">coreo:inheresIn</a>
    /// </summary>
    let inheresIn = _prefixId.prefix "inheresIn"
    /// <summary>
    ///   <para>rdfs:label : CapabilityInheresInPerson</para>
    ///   <para>rdfs:comment : relates the coreo:HumanCapability to the correspondent coreo:Person</para>
    ///   <a href="http://purl.org/coreo#inheresIn_1">coreo:inheresIn_1</a>
    /// </summary>
    let inheresIn_1 = _prefixId.prefix "inheresIn_1"
    /// <summary>
    ///   <para>rdfs:label : inheresInPerson</para>
    ///   <para>rdfs:comment : relates the coreo:HumanAspect to the correspondent coreo:Person</para>
    ///   <a href="http://purl.org/coreo#inheresIn_2">coreo:inheresIn_2</a>
    /// </summary>
    let inheresIn_2 = _prefixId.prefix "inheresIn_2"
    /// <summary>
    ///   <para>rdfs:label : isDefinedBy</para>
    ///   <para>rdfs:comment : Relationship used to detail a coreo:HumanCapabilityType</para>
    ///   <a href="http://purl.org/coreo#isDefinedBy">coreo:isDefinedBy</a>
    /// </summary>
    let isDefinedBy = _prefixId.prefix "isDefinedBy"
    /// <summary>
    ///   <para>rdfs:label : performed</para>
    ///   <para>rdfs:comment : participation of a person in a human task</para>
    ///   <a href="http://purl.org/coreo#performed">coreo:performed</a>
    /// </summary>
    let performed = _prefixId.prefix "performed"
    /// <summary>
    ///   <para>rdfs:label : hasAttitude</para>
    ///   <para>rdfs:comment : parthood relation between a competence and attitude</para>
    ///   <a href="http://purl.org/coreo#personalCompetenceHasAttitude">coreo:personalCompetenceHasAttitude</a>
    /// </summary>
    let personalCompetenceHasAttitude = _prefixId.prefix "personalCompetenceHasAttitude"

    /// <summary>
    ///   <para>rdfs:label : hasHumanAspect</para>
    ///   <para>rdfs:comment : parthood relation between a competence and human aspect</para>
    ///   <a href="http://purl.org/coreo#personalCompetenceHasHumanAspect">coreo:personalCompetenceHasHumanAspect</a>
    /// </summary>
    let personalCompetenceHasHumanAspect =
        _prefixId.prefix "personalCompetenceHasHumanAspect"

    /// <summary>
    ///   <para>rdfs:label : hasKnowledge</para>
    ///   <para>rdfs:comment : parthood relation between a competence and knowledge</para>
    ///   <a href="http://purl.org/coreo#personalCompetenceHasKnowledge">coreo:personalCompetenceHasKnowledge</a>
    /// </summary>
    let personalCompetenceHasKnowledge =
        _prefixId.prefix "personalCompetenceHasKnowledge"

    /// <summary>
    ///   <para>rdfs:label : hasCompetence</para>
    ///   <para>rdfs:comment : parthood relation between a competence and other competence</para>
    ///   <a href="http://purl.org/coreo#personalCompetenceHasPersonalCompetence">coreo:personalCompetenceHasPersonalCompetence</a>
    /// </summary>
    let personalCompetenceHasPersonalCompetence =
        _prefixId.prefix "personalCompetenceHasPersonalCompetence"

    /// <summary>
    ///   <para>rdfs:label : hasSkill</para>
    ///   <para>rdfs:comment : parthood relation between a competence and skill</para>
    ///   <a href="http://purl.org/coreo#personalCompetenceHasSkill">coreo:personalCompetenceHasSkill</a>
    /// </summary>
    let personalCompetenceHasSkill = _prefixId.prefix "personalCompetenceHasSkill"
    /// <summary>
    ///   <para>rdfs:label : specializesArtifact</para>
    ///   <para>rdfs:comment : specialization relation between types symbolizing the types that are instances of other type</para>
    ///   <a href="http://purl.org/coreo#specializes">coreo:specializes</a>
    /// </summary>
    let specializes = _prefixId.prefix "specializes"
    /// <summary>
    ///   <para>rdfs:label : specializes</para>
    ///   <para>rdfs:comment : specialization relation between types symbolizing the types that are instances of other type</para>
    ///   <a href="http://purl.org/coreo#specializes_1">coreo:specializes_1</a>
    /// </summary>
    let specializes_1 = _prefixId.prefix "specializes_1"
    /// <summary>
    ///   <para>rdfs:label : specializesAspect</para>
    ///   <para>rdfs:comment : specialization relation between types symbolizing the types that are instances of other type</para>
    ///   <a href="http://purl.org/coreo#specializes_2">coreo:specializes_2</a>
    /// </summary>
    let specializes_2 = _prefixId.prefix "specializes_2"
    /// <summary>
    ///   <para>rdfs:label : specializesTask</para>
    ///   <para>rdfs:comment : specialization relation between types symbolizing the types that are instances of other type</para>
    ///   <a href="http://purl.org/coreo#specializes_3">coreo:specializes_3</a>
    /// </summary>
    let specializes_3 = _prefixId.prefix "specializes_3"
    /// <summary>
    ///   <para>rdfs:label : specializesRole</para>
    ///   <para>rdfs:comment : specialization relation between types symbolizing the types that are instances of other type</para>
    ///   <a href="http://purl.org/coreo#specializes_4">coreo:specializes_4</a>
    /// </summary>
    let specializes_4 = _prefixId.prefix "specializes_4"
    /// <summary>
    ///   <para>rdfs:label : standsInContext</para>
    ///   <para>rdfs:comment : Details the coreo:Resource that stands in a coreo:CompetenceContext</para>
    ///   <a href="http://purl.org/coreo#standsIn">coreo:standsIn</a>
    /// </summary>
    let standsIn = _prefixId.prefix "standsIn"
    /// <summary>
    ///   <para>rdfs:label : standsInContext</para>
    ///   <para>rdfs:comment : Details the coreo:Artifact that stands in a coreo:CompetenceContext</para>
    ///   <a href="http://purl.org/coreo#standsIn_1">coreo:standsIn_1</a>
    /// </summary>
    let standsIn_1 = _prefixId.prefix "standsIn_1"
    /// <summary>
    ///   <para>rdfs:label : standsInOutcome</para>
    ///   <para>rdfs:comment : Details the coreo:Artifact that stands in a coreo:CompetenceOutcome</para>
    ///   <a href="http://purl.org/coreo#standsIn_2">coreo:standsIn_2</a>
    /// </summary>
    let standsIn_2 = _prefixId.prefix "standsIn_2"
    /// <summary>
    ///   <para>rdfs:label : wasGeneratedIn</para>
    ///   <para>rdfs:comment : output generation from a coreo:HumanTask</para>
    ///   <a href="http://purl.org/coreo#wasGeneratedIn">coreo:wasGeneratedIn</a>
    /// </summary>
    let wasGeneratedIn = _prefixId.prefix "wasGeneratedIn"
    /// <summary>
    ///   <para>rdfs:label : wasManifestedInTask</para>
    ///   <para>rdfs:comment : Identifies a coreo:HumanTask in which the coreo:HumanAspect is manifested.</para>
    ///   <a href="http://purl.org/coreo#wasManifestedIn">coreo:wasManifestedIn</a>
    /// </summary>
    let wasManifestedIn = _prefixId.prefix "wasManifestedIn"
    /// <summary>
    ///   <para>rdfs:label : wasManifestedIn</para>
    ///   <para>rdfs:comment : Identifies a coreo:HumanTask in which the coreo:HumanCapability is manifested.</para>
    ///   <a href="http://purl.org/coreo#wasManifestedIn_1">coreo:wasManifestedIn_1</a>
    /// </summary>
    let wasManifestedIn_1 = _prefixId.prefix "wasManifestedIn_1"
    /// <summary>
    ///   <para>rdfs:label : wasUsedIn</para>
    ///   <para>rdfs:comment : usage of a artifact in a human task as input</para>
    ///   <a href="http://purl.org/coreo#wasUsedIn">coreo:wasUsedIn</a>
    /// </summary>
    let wasUsedIn = _prefixId.prefix "wasUsedIn"
    /// <summary>
    ///   <para>rdfs:label : wasUsedIn</para>
    ///   <para>rdfs:comment : usage of an object in a human task as a resource</para>
    ///   <a href="http://purl.org/coreo#wasUsedIn_1">coreo:wasUsedIn_1</a>
    /// </summary>
    let wasUsedIn_1 = _prefixId.prefix "wasUsedIn_1"
