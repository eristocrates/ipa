namespace http.purl.org.coreo.hash

open DoxAletheia

module coreo =
    let _namespace_name = "http://purl.org/coreo#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// A gufo:Type whose instances are coreo:Attitude.
    ///
    /// Instances of coreo:AttitudeType are subclasses of coreo:Attitude.
    ///
    /// Examples include the coreo:HumanAttitude "Collaboration"
    /// <see href="http://purl.org/coreo#AttitudeType"></see></summary>
    let AttitudeType = _prefix "AttitudeType"
    /// <summary>
    /// A gufo:Type whose instances are dispositions.
    ///
    /// Instances of coreo:HumanCapabilityType are subclasses of coreo:HumanCapability.
    ///
    /// Examples include the skill type of "Java Programming" and competence type of "Software Development"
    /// <see href="http://purl.org/coreo#HumanCapabilityType"></see></summary>
    let HumanCapabilityType = _prefix "HumanCapabilityType"
    /// <summary>
    /// A gufo:Type whose instances are coreo:Knowledge.
    ///
    /// Instances of coreo:KnowledgeType are subclasses of coreo:Knowledge.
    ///
    /// Examples include the the coreo:KnowledgeType "Quantum Physics"
    /// <see href="http://purl.org/coreo#KnowledgeType"></see></summary>
    let KnowledgeType = _prefix "KnowledgeType"
    /// <summary>
    /// Attitude is a tendency to act (or feel) in a given situation (Maze, 2011) inherent to an individual, based on assumptions, values, and beliefs (Maze, 2011). In general, definitions of attitude take into account the following characteristics: (i) mental state; (ii) values (beliefs,
    /// emotions); and (iii) predisposition to act or behave (ALTMANN, 2008).
    ///
    /// E.g. John' accuracy, Paul' responsability, Mary' colaboration
    ///
    /// ALTMANN, Tanya K. Attitude: a concept analysis. In: Nursing forum. Malden, USA: Blackwell Publishing Inc, 2008. p. 144-150.
    ///
    /// MAZE, John R. The concept of attitude. In: Realism and Psychology. Brill, 2011. p. 183-230.
    /// <see href="http://purl.org/coreo#Attitude"></see></summary>
    let Attitude = _prefix "Attitude"
    /// <summary>
    /// Human ability to perform some task in some situation, inherent to an individual. Includes skills and personal competences.
    /// <see href="http://purl.org/coreo#HumanCapability"></see></summary>
    let HumanCapability = _prefix "HumanCapability"
    /// <summary>
    /// Qualities inherent to a person, e.g. age, gender, height, etc.
    /// <see href="http://purl.org/coreo#HumanQuality"></see></summary>
    let HumanQuality = _prefix "HumanQuality"
    /// <summary>
    /// Traits inherent to an individual, e.g. John's introversion, Paul's interest, Mary's hobbies
    /// <see href="http://purl.org/coreo#HumanTrait"></see></summary>
    let HumanTrait = _prefix "HumanTrait"
    /// <summary>
    /// Knowledge is typically associated with internal representations of facts, principles, or theories (WESTERA, 2001) by an individual. and that can be manifested through actions.
    ///
    /// E.G., Paul' quantum theory knowledge
    ///
    /// WESTERA, Wim. Competences in education: a confusion of tongues. Journal of Curriculum studies, v. 33, n. 1, p. 75-88, 2001.
    /// <see href="http://purl.org/coreo#Knowledge"></see></summary>
    let Knowledge = _prefix "Knowledge"
    /// <summary>
    /// Agents are objects that perceive events and perform actions based on their intentions
    /// <see href="http://purl.org/coreo#Agent"></see></summary>
    let Agent = _prefix "Agent"
    /// <summary>
    /// Human-made object produced, used, or changed in task as a result of human capabilities
    ///
    /// E.G., Web form code (produced by John)
    /// <see href="http://purl.org/coreo#Artifact"></see></summary>
    let Artifact = _prefix "Artifact"
    /// <summary>
    /// A gufo:Type whose instances are coreo:Artifact.
    ///
    /// Instances of coreo:ArtifactType are subclasses of coreo:Artifact.
    ///
    /// Examples include "Web Form", "Class Diagram", "Painting", a "Sculpture"
    /// <see href="http://purl.org/coreo#ArtifactType"></see></summary>
    let ArtifactType = _prefix "ArtifactType"
    /// <summary>
    /// A gufo:Type whose instances are objects.
    ///
    /// Instances of ObjectType are subclasses of Object.
    ///
    /// Examples include the object kinds "Car", "Person", "Apple"
    /// <see href="http://purl.org/coreo#SubstantialType"></see></summary>
    let SubstantialType = _prefix "SubstantialType"
    /// <summary>
    /// Aspects inherent to an individual. Includes human capabilities (skills and competences), knowledge, attidutes, and other characteristics (human qualities as age, gender, etc and human traits).
    /// <see href="http://purl.org/coreo#HumanAspect"></see></summary>
    let HumanAspect = _prefix "HumanAspect"
    /// <summary>
    /// A gufo:Type whose instances are coreo:HumanAspect.
    ///
    /// Instances of coreo:HumanAspectType are subclasses of coreo:HumanAspect.
    ///
    /// Examples include the coreo:SkillType "Java Programming", the coreo:CompetenceType "Software Development", the coreo:HumanAttitude "Collaboration", the coreo:HumanKnowledge "Quantum Physics", the coreo:HumanCharacteristic "Age", "Gender", and "Interest"
    /// <see href="http://purl.org/coreo#HumanAspectType"></see></summary>
    let HumanAspectType = _prefix "HumanAspectType"
    /// <summary>
    ///   <see href="http://purl.org/coreo#CapabilityContext"></see>
    /// </summary>
    let CapabilityContext = _prefix "CapabilityContext"
    /// <summary>
    ///   <see href="http://purl.org/coreo#CapabilityManifestation"></see>
    /// </summary>
    let CapabilityManifestation = _prefix "CapabilityManifestation"
    /// <summary>
    ///   <see href="http://purl.org/coreo#CapabilityOutcome"></see>
    /// </summary>
    let CapabilityOutcome = _prefix "CapabilityOutcome"
    /// <summary>
    ///   <see href="http://purl.org/coreo#CapabilityRequiringRole"></see>
    /// </summary>
    let CapabilityRequiringRole = _prefix "CapabilityRequiringRole"
    /// <summary>
    /// Physical agent that are human being
    /// <see href="http://purl.org/coreo#Person"></see></summary>
    let Person = _prefix "Person"
    /// <summary>
    ///   <see href="http://purl.org/coreo#CompetenceContext"></see>
    /// </summary>
    let CompetenceContext = _prefix "CompetenceContext"
    /// <summary>
    /// Event performed by a person as a result of the manifestation of his/her human capabilities
    /// <see href="http://purl.org/coreo#HumanTask"></see></summary>
    let HumanTask = _prefix "HumanTask"

    /// <summary>
    /// Identifies a coreo:HumanTask that the coreo:CompetenceContext contributed to trigger.
    /// <see href="http://purl.org/coreo#competenceContextContributedToTriggerHumanTask"></see></summary>
    let competenceContextContributedToTriggerHumanTask =
        _prefix "competenceContextContributedToTriggerHumanTask"

    /// <summary>
    ///   <see href="http://purl.org/coreo#CompetenceOutcome"></see>
    /// </summary>
    let CompetenceOutcome = _prefix "CompetenceOutcome"
    /// <summary>
    /// A gufo:Type whose instances are coreo:PersonalCompetence.
    ///
    /// Instances of coreo:CompetenceType are subclasses of coreo:PersonalCompetence.
    ///
    /// Examples include the competence type of "Software Development"
    /// <see href="http://purl.org/coreo#CompetenceType"></see></summary>
    let CompetenceType = _prefix "CompetenceType"
    /// <summary>
    /// Competence is a human capability inherent to an individual and formed by the combination of perceptible characteristics, such as the ``well-known'' knowledge, skills, and attitudes (KSA) elements.
    ///
    ///
    /// E.G. John's agile software development competence, Ronaldo's football playing competence
    /// <see href="http://purl.org/coreo#PersonalCompetence"></see></summary>
    let PersonalCompetence = _prefix "PersonalCompetence"
    /// <summary>
    ///   <see href="http://purl.org/coreo#EndurantType"></see>
    /// </summary>
    let EndurantType = _prefix "EndurantType"
    /// <summary>
    /// Any object (social or not) used to prove a human capability.
    /// E.G.  John's graduation certification in computer science,  Mary's project participation.
    /// <see href="http://purl.org/coreo#Evidence"></see></summary>
    let Evidence = _prefix "Evidence"
    /// <summary>
    /// Knowledge Area
    /// <see href="http://purl.org/coreo#Field"></see></summary>
    let Field = _prefix "Field"
    /// <summary>
    /// relates the coreo:HumanAspect to the correspondent coreo:Person
    /// <see href="http://purl.org/coreo#inheresIn_2"></see></summary>
    let inheresIn_2 = _prefix "inheresIn_2"
    /// <summary>
    ///   <see href="http://purl.org/coreo#HumanAspectPhase"></see>
    /// </summary>
    let HumanAspectPhase = _prefix "HumanAspectPhase"
    /// <summary>
    /// A gufo:Type whose instances are aspects.
    ///
    /// Instances of AspectType are subclasses of gufo:Aspect.
    ///
    /// Examples include the aspect kind "age", "knowledge", and "mariage"
    /// <see href="http://purl.org/coreo#MomentType"></see></summary>
    let MomentType = _prefix "MomentType"
    /// <summary>
    /// relates the coreo:HumanCapability to the correspondent coreo:Person
    /// <see href="http://purl.org/coreo#inheresIn_1"></see></summary>
    let inheresIn_1 = _prefix "inheresIn_1"
    /// <summary>
    /// Identifies a coreo:HumanTask in which the coreo:HumanCapability is manifested.
    /// <see href="http://purl.org/coreo#wasManifestedIn_1"></see></summary>
    let wasManifestedIn_1 = _prefix "wasManifestedIn_1"
    /// <summary>
    /// Intencity or deepness of a human capability. Can be related to level, degree, score, or other quality.
    /// <see href="http://purl.org/coreo#Proficiency"></see></summary>
    let Proficiency = _prefix "Proficiency"
    /// <summary>
    /// relates a coreo:Proficiency to the correspondent coreo:HumanCapability
    /// <see href="http://purl.org/coreo#inheresIn"></see></summary>
    let inheresIn = _prefix "inheresIn"
    /// <summary>
    /// Skill is a human capability of an individual to perform a task (discrete unit of work) well (RODRIGUES et al, 2021), not strongly related to a context.
    ///
    /// E.G. John' programming skill, Pelé's kick skill
    ///
    ///
    /// RODRIGUES, Margarida; FERNÁNDEZ-MACÍAS, Enrique; SOSTERO, Matteo. A unified conceptual framework of tasks, skills and competences. JRC Working Papers Series on Labour, Education and Technology, 2021.
    /// <see href="http://purl.org/coreo#Skill"></see></summary>
    let Skill = _prefix "Skill"
    /// <summary>
    /// Human aspects inherent to an individual used to describe his/her profile, Includes qualities and traits
    /// <see href="http://purl.org/coreo#HumanCharacteristic"></see></summary>
    let HumanCharacteristic = _prefix "HumanCharacteristic"
    /// <summary>
    /// Any object used in a task by a person as manifestation of a human capability
    ///
    /// E.G. John's Integrated Development Environment (IDE)
    /// <see href="http://purl.org/coreo#Resource"></see></summary>
    let Resource = _prefix "Resource"
    /// <summary>
    /// usage of an object in a human task as a resource
    /// <see href="http://purl.org/coreo#wasUsedIn_1"></see></summary>
    let wasUsedIn_1 = _prefix "wasUsedIn_1"
    /// <summary>
    /// participation of a person in a human task
    /// <see href="http://purl.org/coreo#performed"></see></summary>
    let performed = _prefix "performed"
    /// <summary>
    /// Artifact created or changed in a task as manifestation of a human capability
    /// <see href="http://purl.org/coreo#TaskOutput"></see></summary>
    let TaskOutput = _prefix "TaskOutput"
    /// <summary>
    /// output generation from a coreo:HumanTask
    /// <see href="http://purl.org/coreo#wasGeneratedIn"></see></summary>
    let wasGeneratedIn = _prefix "wasGeneratedIn"
    /// <summary>
    /// Identifies a coreo:HumanTask in which the coreo:HumanAspect is manifested.
    /// <see href="http://purl.org/coreo#wasManifestedIn"></see></summary>
    let wasManifestedIn = _prefix "wasManifestedIn"
    /// <summary>
    /// Artifact used in a task as manifestation of a human capability
    /// <see href="http://purl.org/coreo#TaskInput"></see></summary>
    let TaskInput = _prefix "TaskInput"
    /// <summary>
    /// usage of a artifact in a human task as input
    /// <see href="http://purl.org/coreo#wasUsedIn"></see></summary>
    let wasUsedIn = _prefix "wasUsedIn"
    /// <summary>
    ///   <see href="http://purl.org/coreo#Object"></see>
    /// </summary>
    let Object = _prefix "Object"
    /// <summary>
    ///   <see href="http://purl.org/coreo#PerdurantType"></see>
    /// </summary>
    let PerdurantType = _prefix "PerdurantType"
    /// <summary>
    ///   <see href="http://purl.org/coreo#PersonalCompetenceType"></see>
    /// </summary>
    let PersonalCompetenceType = _prefix "PersonalCompetenceType"
    /// <summary>
    ///   <see href="http://purl.org/coreo#Phase"></see>
    /// </summary>
    let Phase = _prefix "Phase"
    /// <summary>
    ///   <see href="http://purl.org/coreo#PhysicalAgent"></see>
    /// </summary>
    let PhysicalAgent = _prefix "PhysicalAgent"
    /// <summary>
    /// A gufo:Type whose instances are coreo:Resource.
    ///
    /// Instances of coreo:ResourceType are subclasses of coreo:Resource.
    ///
    /// Examples include "Tool", "Software", "Hardware"
    /// <see href="http://purl.org/coreo#ResourceType"></see></summary>
    let ResourceType = _prefix "ResourceType"
    /// <summary>
    ///   <see href="http://purl.org/coreo#Role"></see>
    /// </summary>
    let Role = _prefix "Role"
    /// <summary>
    ///   <see href="http://purl.org/coreo#SituationType"></see>
    /// </summary>
    let SituationType = _prefix "SituationType"
    /// <summary>
    /// A gufo:Type whose instances are coreo:Skill.
    ///
    /// Instances of coreo:SkillType are subclasses of coreo:Skill.
    ///
    /// Examples include the skill type of "Java Programming"
    /// <see href="http://purl.org/coreo#SkillType"></see></summary>
    let SkillType = _prefix "SkillType"
    /// <summary>
    ///   <see href="http://purl.org/coreo#SocialAgent"></see>
    /// </summary>
    let SocialAgent = _prefix "SocialAgent"
    /// <summary>
    ///   <see href="http://purl.org/coreo#TaskOutcome"></see>
    /// </summary>
    let TaskOutcome = _prefix "TaskOutcome"
    /// <summary>
    /// A gufo:Type whose instances are coreo:Task.
    ///
    /// Instances of coreo:TaskType are subclasses of coreo:Task.
    ///
    /// Examples include "Develop a Software", "Perform a Interview"
    /// <see href="http://purl.org/coreo#TaskType"></see></summary>
    let TaskType = _prefix "TaskType"
    /// <summary>
    ///   <see href="http://purl.org/coreo#Type"></see>
    /// </summary>
    let Type = _prefix "Type"
    /// <summary>
    /// Details the SituationType that a coreo:TaskType can result
    /// <see href="http://purl.org/coreo#bringsAbout"></see></summary>
    let bringsAbout = _prefix "bringsAbout"
    /// <summary>
    ///   <see href="http://purl.org/coreo#broughtAboutHumanTask"></see>
    /// </summary>
    let broughtAboutHumanTask = _prefix "broughtAboutHumanTask"
    /// <summary>
    /// Describes the field of a coreo:CapabilityRequiringRole
    /// <see href="http://purl.org/coreo#capabilityRequiringRoleHasField"></see></summary>
    let capabilityRequiringRoleHasField = _prefix "capabilityRequiringRoleHasField"
    /// <summary>
    /// Relationship used to detail a coreo:ArtifactType
    /// <see href="http://purl.org/coreo#characterizedBy"></see></summary>
    let characterizedBy = _prefix "characterizedBy"
    /// <summary>
    /// Relationship used to detail a type
    /// <see href="http://purl.org/coreo#describedBy"></see></summary>
    let describedBy = _prefix "describedBy"
    /// <summary>
    /// Relationship used to detail a coreo:TaskType
    /// <see href="http://purl.org/coreo#concerns"></see></summary>
    let concerns = _prefix "concerns"
    /// <summary>
    /// Relationship used to detail a coreo:TaskType
    /// <see href="http://purl.org/coreo#concerns_1"></see></summary>
    let concerns_1 = _prefix "concerns_1"
    /// <summary>
    /// Describes the constitutive relationship between coreo:HumanAspectTypes manifested as parthood relationships between their instances
    /// <see href="http://purl.org/coreo#constitutes"></see></summary>
    let constitutes = _prefix "constitutes"
    /// <summary>
    /// Describes the constitutive relationship between types manifested as parthood relationships between their instances
    /// <see href="http://purl.org/coreo#constitutesType"></see></summary>
    let constitutesType = _prefix "constitutesType"
    /// <summary>
    /// Describes the contribution relation between a coreo:HumanQuality and a coreo:PersonalCompetence
    /// <see href="http://purl.org/coreo#contributesTo"></see></summary>
    let contributesTo = _prefix "contributesTo"
    /// <summary>
    /// Relationship used to detail a coreo:HumanCapabilityType
    /// <see href="http://purl.org/coreo#definedInTermsOf"></see></summary>
    let definedInTermsOf = _prefix "definedInTermsOf"
    /// <summary>
    /// Describes the dependence relationship between types manifested as dependence relationships between their instances
    /// <see href="http://purl.org/coreo#dependsOn"></see></summary>
    let dependsOn = _prefix "dependsOn"
    /// <summary>
    /// Describes the dependence relationship between types manifested as dependence relationships between their instances
    /// <see href="http://purl.org/coreo#dependsOnType"></see></summary>
    let dependsOnType = _prefix "dependsOnType"
    /// <summary>
    /// Describes the dependence relationship between types manifested as dependence relationships between their instances
    /// <see href="http://purl.org/coreo#dependsOn_1"></see></summary>
    let dependsOn_1 = _prefix "dependsOn_1"
    /// <summary>
    /// Describes the dependence relationship between types manifested as dependence relationships between their instances
    /// <see href="http://purl.org/coreo#dependsOn_2"></see></summary>
    let dependsOn_2 = _prefix "dependsOn_2"
    /// <summary>
    /// Describes the dependence relationship between types manifested as dependence relationships between their instances
    /// <see href="http://purl.org/coreo#dependsOn_3"></see></summary>
    let dependsOn_3 = _prefix "dependsOn_3"
    /// <summary>
    /// Relationship used to detail types of contexts that activates HumanCapabilityTypes
    /// <see href="http://purl.org/coreo#enables"></see></summary>
    let enables = _prefix "enables"
    /// <summary>
    /// evidances of a coreo:HumanAspect
    /// <see href="http://purl.org/coreo#evidencedBy"></see></summary>
    let evidencedBy = _prefix "evidencedBy"
    /// <summary>
    /// Relationship used to detail a coreo:HumanCapabilityType
    /// <see href="http://purl.org/coreo#isDefinedBy"></see></summary>
    let isDefinedBy = _prefix "isDefinedBy"
    /// <summary>
    /// parthood relation between a competence and attitude
    /// <see href="http://purl.org/coreo#personalCompetenceHasAttitude"></see></summary>
    let personalCompetenceHasAttitude = _prefix "personalCompetenceHasAttitude"
    /// <summary>
    /// parthood relation between a competence and human aspect
    /// <see href="http://purl.org/coreo#personalCompetenceHasHumanAspect"></see></summary>
    let personalCompetenceHasHumanAspect = _prefix "personalCompetenceHasHumanAspect"
    /// <summary>
    /// parthood relation between a competence and knowledge
    /// <see href="http://purl.org/coreo#personalCompetenceHasKnowledge"></see></summary>
    let personalCompetenceHasKnowledge = _prefix "personalCompetenceHasKnowledge"

    /// <summary>
    /// parthood relation between a competence and other competence
    /// <see href="http://purl.org/coreo#personalCompetenceHasPersonalCompetence"></see></summary>
    let personalCompetenceHasPersonalCompetence =
        _prefix "personalCompetenceHasPersonalCompetence"

    /// <summary>
    /// parthood relation between a competence and skill
    /// <see href="http://purl.org/coreo#personalCompetenceHasSkill"></see></summary>
    let personalCompetenceHasSkill = _prefix "personalCompetenceHasSkill"
    /// <summary>
    /// specialization relation between types symbolizing the types that are instances of other type
    /// <see href="http://purl.org/coreo#specializes"></see></summary>
    let specializes = _prefix "specializes"
    /// <summary>
    /// specialization relation between types symbolizing the types that are instances of other type
    /// <see href="http://purl.org/coreo#specializes_1"></see></summary>
    let specializes_1 = _prefix "specializes_1"
    /// <summary>
    /// specialization relation between types symbolizing the types that are instances of other type
    /// <see href="http://purl.org/coreo#specializes_2"></see></summary>
    let specializes_2 = _prefix "specializes_2"
    /// <summary>
    /// specialization relation between types symbolizing the types that are instances of other type
    /// <see href="http://purl.org/coreo#specializes_3"></see></summary>
    let specializes_3 = _prefix "specializes_3"
    /// <summary>
    /// specialization relation between types symbolizing the types that are instances of other type
    /// <see href="http://purl.org/coreo#specializes_4"></see></summary>
    let specializes_4 = _prefix "specializes_4"
    /// <summary>
    /// Details the coreo:Resource that stands in a coreo:CompetenceContext
    /// <see href="http://purl.org/coreo#standsIn"></see></summary>
    let standsIn = _prefix "standsIn"
    /// <summary>
    /// Details the coreo:Artifact that stands in a coreo:CompetenceContext
    /// <see href="http://purl.org/coreo#standsIn_1"></see></summary>
    let standsIn_1 = _prefix "standsIn_1"
    /// <summary>
    /// Details the coreo:Artifact that stands in a coreo:CompetenceOutcome
    /// <see href="http://purl.org/coreo#standsIn_2"></see></summary>
    let standsIn_2 = _prefix "standsIn_2"
