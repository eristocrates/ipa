namespace http.purl.org.coreo.hash

open DoxAletheia.Rdf_Vocabulary

module coreo =
    let _namespace_name = "http://purl.org/coreo#"

    /// <summary>
    /// A gufo:Type whose instances are coreo:Attitude.
    ///
    /// Instances of coreo:AttitudeType are subclasses of coreo:Attitude.
    ///
    /// Examples include the coreo:HumanAttitude "Collaboration"
    /// <see href="http://purl.org/coreo#AttitudeType"></see></summary>
    let AttitudeType =
        Namespaced_IRI.parse _namespace_name "AttitudeType" |> NamespacedName

    /// <summary>
    /// A gufo:Type whose instances are dispositions.
    ///
    /// Instances of coreo:HumanCapabilityType are subclasses of coreo:HumanCapability.
    ///
    /// Examples include the skill type of "Java Programming" and competence type of "Software Development"
    /// <see href="http://purl.org/coreo#HumanCapabilityType"></see></summary>
    let HumanCapabilityType =
        Namespaced_IRI.parse _namespace_name "HumanCapabilityType" |> NamespacedName

    /// <summary>
    /// A gufo:Type whose instances are coreo:Knowledge.
    ///
    /// Instances of coreo:KnowledgeType are subclasses of coreo:Knowledge.
    ///
    /// Examples include the the coreo:KnowledgeType "Quantum Physics"
    /// <see href="http://purl.org/coreo#KnowledgeType"></see></summary>
    let KnowledgeType =
        Namespaced_IRI.parse _namespace_name "KnowledgeType" |> NamespacedName

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
    let Attitude = Namespaced_IRI.parse _namespace_name "Attitude" |> NamespacedName

    /// <summary>
    /// Human ability to perform some task in some situation, inherent to an individual. Includes skills and personal competences.
    /// <see href="http://purl.org/coreo#HumanCapability"></see></summary>
    let HumanCapability =
        Namespaced_IRI.parse _namespace_name "HumanCapability" |> NamespacedName

    /// <summary>
    /// Qualities inherent to a person, e.g. age, gender, height, etc.
    /// <see href="http://purl.org/coreo#HumanQuality"></see></summary>
    let HumanQuality =
        Namespaced_IRI.parse _namespace_name "HumanQuality" |> NamespacedName

    /// <summary>
    /// Traits inherent to an individual, e.g. John's introversion, Paul's interest, Mary's hobbies
    /// <see href="http://purl.org/coreo#HumanTrait"></see></summary>
    let HumanTrait = Namespaced_IRI.parse _namespace_name "HumanTrait" |> NamespacedName
    /// <summary>
    /// Knowledge is typically associated with internal representations of facts, principles, or theories (WESTERA, 2001) by an individual. and that can be manifested through actions.
    ///
    /// E.G., Paul' quantum theory knowledge
    ///
    /// WESTERA, Wim. Competences in education: a confusion of tongues. Journal of Curriculum studies, v. 33, n. 1, p. 75-88, 2001.
    /// <see href="http://purl.org/coreo#Knowledge"></see></summary>
    let Knowledge = Namespaced_IRI.parse _namespace_name "Knowledge" |> NamespacedName
    /// <summary>
    /// Agents are objects that perceive events and perform actions based on their intentions
    /// <see href="http://purl.org/coreo#Agent"></see></summary>
    let Agent = Namespaced_IRI.parse _namespace_name "Agent" |> NamespacedName
    /// <summary>
    /// Human-made object produced, used, or changed in task as a result of human capabilities
    ///
    /// E.G., Web form code (produced by John)
    /// <see href="http://purl.org/coreo#Artifact"></see></summary>
    let Artifact = Namespaced_IRI.parse _namespace_name "Artifact" |> NamespacedName

    /// <summary>
    /// A gufo:Type whose instances are coreo:Artifact.
    ///
    /// Instances of coreo:ArtifactType are subclasses of coreo:Artifact.
    ///
    /// Examples include "Web Form", "Class Diagram", "Painting", a "Sculpture"
    /// <see href="http://purl.org/coreo#ArtifactType"></see></summary>
    let ArtifactType =
        Namespaced_IRI.parse _namespace_name "ArtifactType" |> NamespacedName

    /// <summary>
    /// A gufo:Type whose instances are objects.
    ///
    /// Instances of ObjectType are subclasses of Object.
    ///
    /// Examples include the object kinds "Car", "Person", "Apple"
    /// <see href="http://purl.org/coreo#SubstantialType"></see></summary>
    let SubstantialType =
        Namespaced_IRI.parse _namespace_name "SubstantialType" |> NamespacedName

    /// <summary>
    /// Aspects inherent to an individual. Includes human capabilities (skills and competences), knowledge, attidutes, and other characteristics (human qualities as age, gender, etc and human traits).
    /// <see href="http://purl.org/coreo#HumanAspect"></see></summary>
    let HumanAspect =
        Namespaced_IRI.parse _namespace_name "HumanAspect" |> NamespacedName

    /// <summary>
    /// A gufo:Type whose instances are coreo:HumanAspect.
    ///
    /// Instances of coreo:HumanAspectType are subclasses of coreo:HumanAspect.
    ///
    /// Examples include the coreo:SkillType "Java Programming", the coreo:CompetenceType "Software Development", the coreo:HumanAttitude "Collaboration", the coreo:HumanKnowledge "Quantum Physics", the coreo:HumanCharacteristic "Age", "Gender", and "Interest"
    /// <see href="http://purl.org/coreo#HumanAspectType"></see></summary>
    let HumanAspectType =
        Namespaced_IRI.parse _namespace_name "HumanAspectType" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/coreo#CapabilityContext"></see>
    /// </summary>
    let CapabilityContext =
        Namespaced_IRI.parse _namespace_name "CapabilityContext" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/coreo#CapabilityManifestation"></see>
    /// </summary>
    let CapabilityManifestation =
        Namespaced_IRI.parse _namespace_name "CapabilityManifestation" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/coreo#CapabilityOutcome"></see>
    /// </summary>
    let CapabilityOutcome =
        Namespaced_IRI.parse _namespace_name "CapabilityOutcome" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/coreo#CapabilityRequiringRole"></see>
    /// </summary>
    let CapabilityRequiringRole =
        Namespaced_IRI.parse _namespace_name "CapabilityRequiringRole" |> NamespacedName

    /// <summary>
    /// Physical agent that are human being
    /// <see href="http://purl.org/coreo#Person"></see></summary>
    let Person = Namespaced_IRI.parse _namespace_name "Person" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/coreo#CompetenceContext"></see>
    /// </summary>
    let CompetenceContext =
        Namespaced_IRI.parse _namespace_name "CompetenceContext" |> NamespacedName

    /// <summary>
    /// Event performed by a person as a result of the manifestation of his/her human capabilities
    /// <see href="http://purl.org/coreo#HumanTask"></see></summary>
    let HumanTask = Namespaced_IRI.parse _namespace_name "HumanTask" |> NamespacedName

    /// <summary>
    /// Identifies a coreo:HumanTask that the coreo:CompetenceContext contributed to trigger.
    /// <see href="http://purl.org/coreo#competenceContextContributedToTriggerHumanTask"></see></summary>
    let competenceContextContributedToTriggerHumanTask =
        Namespaced_IRI.parse _namespace_name "competenceContextContributedToTriggerHumanTask" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/coreo#CompetenceOutcome"></see>
    /// </summary>
    let CompetenceOutcome =
        Namespaced_IRI.parse _namespace_name "CompetenceOutcome" |> NamespacedName

    /// <summary>
    /// A gufo:Type whose instances are coreo:PersonalCompetence.
    ///
    /// Instances of coreo:CompetenceType are subclasses of coreo:PersonalCompetence.
    ///
    /// Examples include the competence type of "Software Development"
    /// <see href="http://purl.org/coreo#CompetenceType"></see></summary>
    let CompetenceType =
        Namespaced_IRI.parse _namespace_name "CompetenceType" |> NamespacedName

    /// <summary>
    /// Competence is a human capability inherent to an individual and formed by the combination of perceptible characteristics, such as the ``well-known'' knowledge, skills, and attitudes (KSA) elements.
    ///
    ///
    /// E.G. John's agile software development competence, Ronaldo's football playing competence
    /// <see href="http://purl.org/coreo#PersonalCompetence"></see></summary>
    let PersonalCompetence =
        Namespaced_IRI.parse _namespace_name "PersonalCompetence" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/coreo#EndurantType"></see>
    /// </summary>
    let EndurantType =
        Namespaced_IRI.parse _namespace_name "EndurantType" |> NamespacedName

    /// <summary>
    /// Any object (social or not) used to prove a human capability.
    /// E.G.  John's graduation certification in computer science,  Mary's project participation.
    /// <see href="http://purl.org/coreo#Evidence"></see></summary>
    let Evidence = Namespaced_IRI.parse _namespace_name "Evidence" |> NamespacedName
    /// <summary>
    /// Knowledge Area
    /// <see href="http://purl.org/coreo#Field"></see></summary>
    let Field = Namespaced_IRI.parse _namespace_name "Field" |> NamespacedName

    /// <summary>
    /// relates the coreo:HumanAspect to the correspondent coreo:Person
    /// <see href="http://purl.org/coreo#inheresIn_2"></see></summary>
    let inheresIn_2 =
        Namespaced_IRI.parse _namespace_name "inheresIn_2" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/coreo#HumanAspectPhase"></see>
    /// </summary>
    let HumanAspectPhase =
        Namespaced_IRI.parse _namespace_name "HumanAspectPhase" |> NamespacedName

    /// <summary>
    /// A gufo:Type whose instances are aspects.
    ///
    /// Instances of AspectType are subclasses of gufo:Aspect.
    ///
    /// Examples include the aspect kind "age", "knowledge", and "mariage"
    /// <see href="http://purl.org/coreo#MomentType"></see></summary>
    let MomentType = Namespaced_IRI.parse _namespace_name "MomentType" |> NamespacedName

    /// <summary>
    /// relates the coreo:HumanCapability to the correspondent coreo:Person
    /// <see href="http://purl.org/coreo#inheresIn_1"></see></summary>
    let inheresIn_1 =
        Namespaced_IRI.parse _namespace_name "inheresIn_1" |> NamespacedName

    /// <summary>
    /// Identifies a coreo:HumanTask in which the coreo:HumanCapability is manifested.
    /// <see href="http://purl.org/coreo#wasManifestedIn_1"></see></summary>
    let wasManifestedIn_1 =
        Namespaced_IRI.parse _namespace_name "wasManifestedIn_1" |> NamespacedName

    /// <summary>
    /// Intencity or deepness of a human capability. Can be related to level, degree, score, or other quality.
    /// <see href="http://purl.org/coreo#Proficiency"></see></summary>
    let Proficiency =
        Namespaced_IRI.parse _namespace_name "Proficiency" |> NamespacedName

    /// <summary>
    /// relates a coreo:Proficiency to the correspondent coreo:HumanCapability
    /// <see href="http://purl.org/coreo#inheresIn"></see></summary>
    let inheresIn = Namespaced_IRI.parse _namespace_name "inheresIn" |> NamespacedName
    /// <summary>
    /// Skill is a human capability of an individual to perform a task (discrete unit of work) well (RODRIGUES et al, 2021), not strongly related to a context.
    ///
    /// E.G. John' programming skill, Pelé's kick skill
    ///
    ///
    /// RODRIGUES, Margarida; FERNÁNDEZ-MACÍAS, Enrique; SOSTERO, Matteo. A unified conceptual framework of tasks, skills and competences. JRC Working Papers Series on Labour, Education and Technology, 2021.
    /// <see href="http://purl.org/coreo#Skill"></see></summary>
    let Skill = Namespaced_IRI.parse _namespace_name "Skill" |> NamespacedName

    /// <summary>
    /// Human aspects inherent to an individual used to describe his/her profile, Includes qualities and traits
    /// <see href="http://purl.org/coreo#HumanCharacteristic"></see></summary>
    let HumanCharacteristic =
        Namespaced_IRI.parse _namespace_name "HumanCharacteristic" |> NamespacedName

    /// <summary>
    /// Any object used in a task by a person as manifestation of a human capability
    ///
    /// E.G. John's Integrated Development Environment (IDE)
    /// <see href="http://purl.org/coreo#Resource"></see></summary>
    let Resource = Namespaced_IRI.parse _namespace_name "Resource" |> NamespacedName

    /// <summary>
    /// usage of an object in a human task as a resource
    /// <see href="http://purl.org/coreo#wasUsedIn_1"></see></summary>
    let wasUsedIn_1 =
        Namespaced_IRI.parse _namespace_name "wasUsedIn_1" |> NamespacedName

    /// <summary>
    /// participation of a person in a human task
    /// <see href="http://purl.org/coreo#performed"></see></summary>
    let performed = Namespaced_IRI.parse _namespace_name "performed" |> NamespacedName
    /// <summary>
    /// Artifact created or changed in a task as manifestation of a human capability
    /// <see href="http://purl.org/coreo#TaskOutput"></see></summary>
    let TaskOutput = Namespaced_IRI.parse _namespace_name "TaskOutput" |> NamespacedName

    /// <summary>
    /// output generation from a coreo:HumanTask
    /// <see href="http://purl.org/coreo#wasGeneratedIn"></see></summary>
    let wasGeneratedIn =
        Namespaced_IRI.parse _namespace_name "wasGeneratedIn" |> NamespacedName

    /// <summary>
    /// Identifies a coreo:HumanTask in which the coreo:HumanAspect is manifested.
    /// <see href="http://purl.org/coreo#wasManifestedIn"></see></summary>
    let wasManifestedIn =
        Namespaced_IRI.parse _namespace_name "wasManifestedIn" |> NamespacedName

    /// <summary>
    /// Artifact used in a task as manifestation of a human capability
    /// <see href="http://purl.org/coreo#TaskInput"></see></summary>
    let TaskInput = Namespaced_IRI.parse _namespace_name "TaskInput" |> NamespacedName
    /// <summary>
    /// usage of a artifact in a human task as input
    /// <see href="http://purl.org/coreo#wasUsedIn"></see></summary>
    let wasUsedIn = Namespaced_IRI.parse _namespace_name "wasUsedIn" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/coreo#Object"></see>
    /// </summary>
    let Object = Namespaced_IRI.parse _namespace_name "Object" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/coreo#PerdurantType"></see>
    /// </summary>
    let PerdurantType =
        Namespaced_IRI.parse _namespace_name "PerdurantType" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/coreo#PersonalCompetenceType"></see>
    /// </summary>
    let PersonalCompetenceType =
        Namespaced_IRI.parse _namespace_name "PersonalCompetenceType" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/coreo#Phase"></see>
    /// </summary>
    let Phase = Namespaced_IRI.parse _namespace_name "Phase" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/coreo#PhysicalAgent"></see>
    /// </summary>
    let PhysicalAgent =
        Namespaced_IRI.parse _namespace_name "PhysicalAgent" |> NamespacedName

    /// <summary>
    /// A gufo:Type whose instances are coreo:Resource.
    ///
    /// Instances of coreo:ResourceType are subclasses of coreo:Resource.
    ///
    /// Examples include "Tool", "Software", "Hardware"
    /// <see href="http://purl.org/coreo#ResourceType"></see></summary>
    let ResourceType =
        Namespaced_IRI.parse _namespace_name "ResourceType" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/coreo#Role"></see>
    /// </summary>
    let Role = Namespaced_IRI.parse _namespace_name "Role" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/coreo#SituationType"></see>
    /// </summary>
    let SituationType =
        Namespaced_IRI.parse _namespace_name "SituationType" |> NamespacedName

    /// <summary>
    /// A gufo:Type whose instances are coreo:Skill.
    ///
    /// Instances of coreo:SkillType are subclasses of coreo:Skill.
    ///
    /// Examples include the skill type of "Java Programming"
    /// <see href="http://purl.org/coreo#SkillType"></see></summary>
    let SkillType = Namespaced_IRI.parse _namespace_name "SkillType" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/coreo#SocialAgent"></see>
    /// </summary>
    let SocialAgent =
        Namespaced_IRI.parse _namespace_name "SocialAgent" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/coreo#TaskOutcome"></see>
    /// </summary>
    let TaskOutcome =
        Namespaced_IRI.parse _namespace_name "TaskOutcome" |> NamespacedName

    /// <summary>
    /// A gufo:Type whose instances are coreo:Task.
    ///
    /// Instances of coreo:TaskType are subclasses of coreo:Task.
    ///
    /// Examples include "Develop a Software", "Perform a Interview"
    /// <see href="http://purl.org/coreo#TaskType"></see></summary>
    let TaskType = Namespaced_IRI.parse _namespace_name "TaskType" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/coreo#Type"></see>
    /// </summary>
    let Type = Namespaced_IRI.parse _namespace_name "Type" |> NamespacedName

    /// <summary>
    /// Details the SituationType that a coreo:TaskType can result
    /// <see href="http://purl.org/coreo#bringsAbout"></see></summary>
    let bringsAbout =
        Namespaced_IRI.parse _namespace_name "bringsAbout" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/coreo#broughtAboutHumanTask"></see>
    /// </summary>
    let broughtAboutHumanTask =
        Namespaced_IRI.parse _namespace_name "broughtAboutHumanTask" |> NamespacedName

    /// <summary>
    /// Describes the field of a coreo:CapabilityRequiringRole
    /// <see href="http://purl.org/coreo#capabilityRequiringRoleHasField"></see></summary>
    let capabilityRequiringRoleHasField =
        Namespaced_IRI.parse _namespace_name "capabilityRequiringRoleHasField" |> NamespacedName

    /// <summary>
    /// Relationship used to detail a coreo:ArtifactType
    /// <see href="http://purl.org/coreo#characterizedBy"></see></summary>
    let characterizedBy =
        Namespaced_IRI.parse _namespace_name "characterizedBy" |> NamespacedName

    /// <summary>
    /// Relationship used to detail a type
    /// <see href="http://purl.org/coreo#describedBy"></see></summary>
    let describedBy =
        Namespaced_IRI.parse _namespace_name "describedBy" |> NamespacedName

    /// <summary>
    /// Relationship used to detail a coreo:TaskType
    /// <see href="http://purl.org/coreo#concerns"></see></summary>
    let concerns = Namespaced_IRI.parse _namespace_name "concerns" |> NamespacedName
    /// <summary>
    /// Relationship used to detail a coreo:TaskType
    /// <see href="http://purl.org/coreo#concerns_1"></see></summary>
    let concerns_1 = Namespaced_IRI.parse _namespace_name "concerns_1" |> NamespacedName

    /// <summary>
    /// Describes the constitutive relationship between coreo:HumanAspectTypes manifested as parthood relationships between their instances
    /// <see href="http://purl.org/coreo#constitutes"></see></summary>
    let constitutes =
        Namespaced_IRI.parse _namespace_name "constitutes" |> NamespacedName

    /// <summary>
    /// Describes the constitutive relationship between types manifested as parthood relationships between their instances
    /// <see href="http://purl.org/coreo#constitutesType"></see></summary>
    let constitutesType =
        Namespaced_IRI.parse _namespace_name "constitutesType" |> NamespacedName

    /// <summary>
    /// Describes the contribution relation between a coreo:HumanQuality and a coreo:PersonalCompetence
    /// <see href="http://purl.org/coreo#contributesTo"></see></summary>
    let contributesTo =
        Namespaced_IRI.parse _namespace_name "contributesTo" |> NamespacedName

    /// <summary>
    /// Relationship used to detail a coreo:HumanCapabilityType
    /// <see href="http://purl.org/coreo#definedInTermsOf"></see></summary>
    let definedInTermsOf =
        Namespaced_IRI.parse _namespace_name "definedInTermsOf" |> NamespacedName

    /// <summary>
    /// Describes the dependence relationship between types manifested as dependence relationships between their instances
    /// <see href="http://purl.org/coreo#dependsOn"></see></summary>
    let dependsOn = Namespaced_IRI.parse _namespace_name "dependsOn" |> NamespacedName

    /// <summary>
    /// Describes the dependence relationship between types manifested as dependence relationships between their instances
    /// <see href="http://purl.org/coreo#dependsOnType"></see></summary>
    let dependsOnType =
        Namespaced_IRI.parse _namespace_name "dependsOnType" |> NamespacedName

    /// <summary>
    /// Describes the dependence relationship between types manifested as dependence relationships between their instances
    /// <see href="http://purl.org/coreo#dependsOn_1"></see></summary>
    let dependsOn_1 =
        Namespaced_IRI.parse _namespace_name "dependsOn_1" |> NamespacedName

    /// <summary>
    /// Describes the dependence relationship between types manifested as dependence relationships between their instances
    /// <see href="http://purl.org/coreo#dependsOn_2"></see></summary>
    let dependsOn_2 =
        Namespaced_IRI.parse _namespace_name "dependsOn_2" |> NamespacedName

    /// <summary>
    /// Describes the dependence relationship between types manifested as dependence relationships between their instances
    /// <see href="http://purl.org/coreo#dependsOn_3"></see></summary>
    let dependsOn_3 =
        Namespaced_IRI.parse _namespace_name "dependsOn_3" |> NamespacedName

    /// <summary>
    /// Relationship used to detail types of contexts that activates HumanCapabilityTypes
    /// <see href="http://purl.org/coreo#enables"></see></summary>
    let enables = Namespaced_IRI.parse _namespace_name "enables" |> NamespacedName

    /// <summary>
    /// evidances of a coreo:HumanAspect
    /// <see href="http://purl.org/coreo#evidencedBy"></see></summary>
    let evidencedBy =
        Namespaced_IRI.parse _namespace_name "evidencedBy" |> NamespacedName

    /// <summary>
    /// Relationship used to detail a coreo:HumanCapabilityType
    /// <see href="http://purl.org/coreo#isDefinedBy"></see></summary>
    let isDefinedBy =
        Namespaced_IRI.parse _namespace_name "isDefinedBy" |> NamespacedName

    /// <summary>
    /// parthood relation between a competence and attitude
    /// <see href="http://purl.org/coreo#personalCompetenceHasAttitude"></see></summary>
    let personalCompetenceHasAttitude =
        Namespaced_IRI.parse _namespace_name "personalCompetenceHasAttitude" |> NamespacedName

    /// <summary>
    /// parthood relation between a competence and human aspect
    /// <see href="http://purl.org/coreo#personalCompetenceHasHumanAspect"></see></summary>
    let personalCompetenceHasHumanAspect =
        Namespaced_IRI.parse _namespace_name "personalCompetenceHasHumanAspect" |> NamespacedName

    /// <summary>
    /// parthood relation between a competence and knowledge
    /// <see href="http://purl.org/coreo#personalCompetenceHasKnowledge"></see></summary>
    let personalCompetenceHasKnowledge =
        Namespaced_IRI.parse _namespace_name "personalCompetenceHasKnowledge" |> NamespacedName

    /// <summary>
    /// parthood relation between a competence and other competence
    /// <see href="http://purl.org/coreo#personalCompetenceHasPersonalCompetence"></see></summary>
    let personalCompetenceHasPersonalCompetence =
        Namespaced_IRI.parse _namespace_name "personalCompetenceHasPersonalCompetence" |> NamespacedName

    /// <summary>
    /// parthood relation between a competence and skill
    /// <see href="http://purl.org/coreo#personalCompetenceHasSkill"></see></summary>
    let personalCompetenceHasSkill =
        Namespaced_IRI.parse _namespace_name "personalCompetenceHasSkill" |> NamespacedName

    /// <summary>
    /// specialization relation between types symbolizing the types that are instances of other type
    /// <see href="http://purl.org/coreo#specializes"></see></summary>
    let specializes =
        Namespaced_IRI.parse _namespace_name "specializes" |> NamespacedName

    /// <summary>
    /// specialization relation between types symbolizing the types that are instances of other type
    /// <see href="http://purl.org/coreo#specializes_1"></see></summary>
    let specializes_1 =
        Namespaced_IRI.parse _namespace_name "specializes_1" |> NamespacedName

    /// <summary>
    /// specialization relation between types symbolizing the types that are instances of other type
    /// <see href="http://purl.org/coreo#specializes_2"></see></summary>
    let specializes_2 =
        Namespaced_IRI.parse _namespace_name "specializes_2" |> NamespacedName

    /// <summary>
    /// specialization relation between types symbolizing the types that are instances of other type
    /// <see href="http://purl.org/coreo#specializes_3"></see></summary>
    let specializes_3 =
        Namespaced_IRI.parse _namespace_name "specializes_3" |> NamespacedName

    /// <summary>
    /// specialization relation between types symbolizing the types that are instances of other type
    /// <see href="http://purl.org/coreo#specializes_4"></see></summary>
    let specializes_4 =
        Namespaced_IRI.parse _namespace_name "specializes_4" |> NamespacedName

    /// <summary>
    /// Details the coreo:Resource that stands in a coreo:CompetenceContext
    /// <see href="http://purl.org/coreo#standsIn"></see></summary>
    let standsIn = Namespaced_IRI.parse _namespace_name "standsIn" |> NamespacedName
    /// <summary>
    /// Details the coreo:Artifact that stands in a coreo:CompetenceContext
    /// <see href="http://purl.org/coreo#standsIn_1"></see></summary>
    let standsIn_1 = Namespaced_IRI.parse _namespace_name "standsIn_1" |> NamespacedName
    /// <summary>
    /// Details the coreo:Artifact that stands in a coreo:CompetenceOutcome
    /// <see href="http://purl.org/coreo#standsIn_2"></see></summary>
    let standsIn_2 = Namespaced_IRI.parse _namespace_name "standsIn_2" |> NamespacedName
