namespace http.purl.org.coreo.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module coreo =
    let _namespace_iri = Namespace_Iri coreo |> NamespaceIRI
    /// <summary>
    ///   <para>coreo:AttitudeType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>A gufo:Type whose instances are coreo:Attitude.
    ///
    /// Instances of coreo:AttitudeType are subclasses of coreo:Attitude.
    ///
    /// Examples include the coreo:HumanAttitude "Collaboration"</para>
    /// labels<para>AttitudeType</para></remarks>
    /// <seealso href="http://purl.org/coreo#AttitudeType">http://purl.org/coreo#AttitudeType</seealso>
    let AttitudeType = Prefixed_Name(coreo, "AttitudeType") |> PrefixedName
    /// <summary>
    ///   <para>coreo:Attitude</para>
    /// </summary>
    /// <remarks>
    ///   <para>gufo:Kind</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>Attitude is a tendency to act (or feel) in a given situation (Maze, 2011) inherent to an individual, based on assumptions, values, and beliefs (Maze, 2011). In general, definitions of attitude take into account the following characteristics: (i) mental state; (ii) values (beliefs,
    /// emotions); and (iii) predisposition to act or behave (ALTMANN, 2008).
    ///
    /// E.g. John' accuracy, Paul' responsability, Mary' colaboration
    ///
    /// ALTMANN, Tanya K. Attitude: a concept analysis. In: Nursing forum. Malden, USA: Blackwell Publishing Inc, 2008. p. 144-150.
    ///
    /// MAZE, John R. The concept of attitude. In: Realism and Psychology. Brill, 2011. p. 183-230.</para>
    /// labels<para>Attitude</para></remarks>
    /// <seealso href="http://purl.org/coreo#Attitude">http://purl.org/coreo#Attitude</seealso>
    let Attitude = Prefixed_Name(coreo, "Attitude") |> PrefixedName
    /// <summary>
    ///   <para>coreo:HumanCapability</para>
    /// </summary>
    /// <remarks>
    ///   <para>gufo:Kind</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>Human ability to perform some task in some situation, inherent to an individual. Includes skills and personal competences.</para>
    /// labels<para>HumanCapability</para></remarks>
    /// <seealso href="http://purl.org/coreo#HumanCapability">http://purl.org/coreo#HumanCapability</seealso>
    let HumanCapability = Prefixed_Name(coreo, "HumanCapability") |> PrefixedName
    /// <summary>
    ///   <para>coreo:HumanQuality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>gufo:Category</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Qualities inherent to a person, e.g. age, gender, height, etc.</para>
    /// labels<para>HumanQuality</para></remarks>
    /// <seealso href="http://purl.org/coreo#HumanQuality">http://purl.org/coreo#HumanQuality</seealso>
    let HumanQuality = Prefixed_Name(coreo, "HumanQuality") |> PrefixedName
    /// <summary>
    ///   <para>coreo:Knowledge</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>gufo:Kind</para>
    ///   <para>owl:Class</para>
    ///   <para>Knowledge is typically associated with internal representations of facts, principles, or theories (WESTERA, 2001) by an individual. and that can be manifested through actions.
    ///
    /// E.G., Paul' quantum theory knowledge
    ///
    /// WESTERA, Wim. Competences in education: a confusion of tongues. Journal of Curriculum studies, v. 33, n. 1, p. 75-88, 2001.</para>
    /// labels<para>Knowledge</para></remarks>
    /// <seealso href="http://purl.org/coreo#Knowledge">http://purl.org/coreo#Knowledge</seealso>
    let Knowledge = Prefixed_Name(coreo, "Knowledge") |> PrefixedName
    /// <summary>
    ///   <para>coreo:dependsOnType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Describes the dependence relationship between types manifested as dependence relationships between their instances</para>
    /// labels<para>dependsOnType</para></remarks>
    /// <seealso href="http://purl.org/coreo#dependsOnType">http://purl.org/coreo#dependsOnType</seealso>
    let dependsOnType = Prefixed_Name(coreo, "dependsOnType") |> PrefixedName
    /// <summary>
    ///   <para>coreo:enables</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relationship used to detail types of contexts that activates HumanCapabilityTypes</para>
    /// labels<para>enablesSituationType</para></remarks>
    /// <seealso href="http://purl.org/coreo#enables">http://purl.org/coreo#enables</seealso>
    let enables = Prefixed_Name(coreo, "enables") |> PrefixedName
    /// <summary>
    ///   <para>coreo:KnowledgeType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>A gufo:Type whose instances are coreo:Knowledge.
    ///
    /// Instances of coreo:KnowledgeType are subclasses of coreo:Knowledge.
    ///
    /// Examples include the the coreo:KnowledgeType "Quantum Physics"</para>
    /// labels<para>KnowledgeType</para></remarks>
    /// <seealso href="http://purl.org/coreo#KnowledgeType">http://purl.org/coreo#KnowledgeType</seealso>
    let KnowledgeType = Prefixed_Name(coreo, "KnowledgeType") |> PrefixedName
    /// <summary>
    ///   <para>coreo:CompetenceContext</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>gufo:SituationType</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Competence Context</para><para>CompetenceContext</para></remarks>
    /// <seealso href="http://purl.org/coreo#CompetenceContext">http://purl.org/coreo#CompetenceContext</seealso>
    let CompetenceContext = Prefixed_Name(coreo, "CompetenceContext") |> PrefixedName

    /// <summary>
    ///   <para>coreo:competenceContextContributedToTriggerHumanTask</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Identifies a coreo:HumanTask that the coreo:CompetenceContext contributed to trigger.</para>
    /// labels<para>activatesTask</para></remarks>
    /// <seealso href="http://purl.org/coreo#competenceContextContributedToTriggerHumanTask">http://purl.org/coreo#competenceContextContributedToTriggerHumanTask</seealso>
    let competenceContextContributedToTriggerHumanTask =
        Prefixed_Name(coreo, "competenceContextContributedToTriggerHumanTask") |> PrefixedName

    /// <summary>
    ///   <para>coreo:EndurantType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://purl.org/coreo#EndurantType">http://purl.org/coreo#EndurantType</seealso>
    let EndurantType = Prefixed_Name(coreo, "EndurantType") |> PrefixedName
    /// <summary>
    ///   <para>coreo:Agent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>gufo:Category</para>
    ///   <para>Agents are objects that perceive events and perform actions based on their intentions</para>
    /// labels<para>Agent</para></remarks>
    /// <seealso href="http://purl.org/coreo#Agent">http://purl.org/coreo#Agent</seealso>
    let Agent = Prefixed_Name(coreo, "Agent") |> PrefixedName
    /// <summary>
    ///   <para>coreo:Artifact</para>
    /// </summary>
    /// <remarks>
    ///   <para>gufo:Category</para>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Human-made object produced, used, or changed in task as a result of human capabilities
    ///
    /// E.G., Web form code (produced by John)</para>
    /// labels<para>Artifact</para></remarks>
    /// <seealso href="http://purl.org/coreo#Artifact">http://purl.org/coreo#Artifact</seealso>
    let Artifact = Prefixed_Name(coreo, "Artifact") |> PrefixedName
    /// <summary>
    ///   <para>coreo:HumanAspect</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>gufo:Category</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Aspects inherent to an individual. Includes human capabilities (skills and competences), knowledge, attidutes, and other characteristics (human qualities as age, gender, etc and human traits).</para>
    /// labels<para>HumanAspect</para></remarks>
    /// <seealso href="http://purl.org/coreo#HumanAspect">http://purl.org/coreo#HumanAspect</seealso>
    let HumanAspect = Prefixed_Name(coreo, "HumanAspect") |> PrefixedName
    /// <summary>
    ///   <para>coreo:HumanTrait</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>gufo:Category</para>
    ///   <para>Traits inherent to an individual, e.g. John's introversion, Paul's interest, Mary's hobbies</para>
    /// labels<para>HumanTrait</para></remarks>
    /// <seealso href="http://purl.org/coreo#HumanTrait">http://purl.org/coreo#HumanTrait</seealso>
    let HumanTrait = Prefixed_Name(coreo, "HumanTrait") |> PrefixedName
    /// <summary>
    ///   <para>coreo:wasManifestedIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Identifies a coreo:HumanTask in which the coreo:HumanAspect is manifested.</para>
    /// labels<para>wasManifestedInTask</para></remarks>
    /// <seealso href="http://purl.org/coreo#wasManifestedIn">http://purl.org/coreo#wasManifestedIn</seealso>
    let wasManifestedIn = Prefixed_Name(coreo, "wasManifestedIn") |> PrefixedName
    /// <summary>
    ///   <para>coreo:Role</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://purl.org/coreo#Role">http://purl.org/coreo#Role</seealso>
    let Role = Prefixed_Name(coreo, "Role") |> PrefixedName
    /// <summary>
    ///   <para>coreo:SituationType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://purl.org/coreo#SituationType">http://purl.org/coreo#SituationType</seealso>
    let SituationType = Prefixed_Name(coreo, "SituationType") |> PrefixedName
    /// <summary>
    ///   <para>coreo:TaskOutcome</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>Task Outcome</para></remarks>
    /// <seealso href="http://purl.org/coreo#TaskOutcome">http://purl.org/coreo#TaskOutcome</seealso>
    let TaskOutcome = Prefixed_Name(coreo, "TaskOutcome") |> PrefixedName
    /// <summary>
    ///   <para>coreo:Type</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://purl.org/coreo#Type">http://purl.org/coreo#Type</seealso>
    let Type = Prefixed_Name(coreo, "Type") |> PrefixedName
    /// <summary>
    ///   <para>coreo:bringsAbout</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Details the SituationType that a coreo:TaskType can result</para>
    /// labels<para>bringsAbout</para></remarks>
    /// <seealso href="http://purl.org/coreo#bringsAbout">http://purl.org/coreo#bringsAbout</seealso>
    let bringsAbout = Prefixed_Name(coreo, "bringsAbout") |> PrefixedName
    /// <summary>
    ///   <para>coreo:characterizedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relationship used to detail a coreo:ArtifactType</para>
    /// labels<para>characterizedBy</para></remarks>
    /// <seealso href="http://purl.org/coreo#characterizedBy">http://purl.org/coreo#characterizedBy</seealso>
    let characterizedBy = Prefixed_Name(coreo, "characterizedBy") |> PrefixedName
    /// <summary>
    ///   <para>coreo:concerns</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relationship used to detail a coreo:TaskType</para>
    /// labels<para>concernsArtifact</para></remarks>
    /// <seealso href="http://purl.org/coreo#concerns">http://purl.org/coreo#concerns</seealso>
    let concerns = Prefixed_Name(coreo, "concerns") |> PrefixedName
    /// <summary>
    ///   <para>coreo:concerns_1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relationship used to detail a coreo:TaskType</para>
    /// labels<para>concernsResource</para></remarks>
    /// <seealso href="http://purl.org/coreo#concerns_1">http://purl.org/coreo#concerns_1</seealso>
    let concerns_1 = Prefixed_Name(coreo, "concerns_1") |> PrefixedName
    /// <summary>
    ///   <para>coreo:constitutesType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Describes the constitutive relationship between types manifested as parthood relationships between their instances</para>
    /// labels<para>constitutesType</para></remarks>
    /// <seealso href="http://purl.org/coreo#constitutesType">http://purl.org/coreo#constitutesType</seealso>
    let constitutesType = Prefixed_Name(coreo, "constitutesType") |> PrefixedName
    /// <summary>
    ///   <para>coreo:dependsOn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Describes the dependence relationship between types manifested as dependence relationships between their instances</para>
    /// labels<para>dependsOnTask</para></remarks>
    /// <seealso href="http://purl.org/coreo#dependsOn">http://purl.org/coreo#dependsOn</seealso>
    let dependsOn = Prefixed_Name(coreo, "dependsOn") |> PrefixedName
    /// <summary>
    ///   <para>coreo:dependsOn_1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Describes the dependence relationship between types manifested as dependence relationships between their instances</para>
    /// labels<para>dependsOnArtifact</para></remarks>
    /// <seealso href="http://purl.org/coreo#dependsOn_1">http://purl.org/coreo#dependsOn_1</seealso>
    let dependsOn_1 = Prefixed_Name(coreo, "dependsOn_1") |> PrefixedName
    /// <summary>
    ///   <para>coreo:dependsOn_2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Describes the dependence relationship between types manifested as dependence relationships between their instances</para>
    /// labels<para>dependsOnHumanAspect</para></remarks>
    /// <seealso href="http://purl.org/coreo#dependsOn_2">http://purl.org/coreo#dependsOn_2</seealso>
    let dependsOn_2 = Prefixed_Name(coreo, "dependsOn_2") |> PrefixedName
    /// <summary>
    ///   <para>coreo:dependsOn_3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Describes the dependence relationship between types manifested as dependence relationships between their instances</para>
    /// labels<para>dependsOnRole</para></remarks>
    /// <seealso href="http://purl.org/coreo#dependsOn_3">http://purl.org/coreo#dependsOn_3</seealso>
    let dependsOn_3 = Prefixed_Name(coreo, "dependsOn_3") |> PrefixedName
    /// <summary>
    ///   <para>coreo:evidencedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>evidances of a coreo:HumanAspect</para>
    /// labels<para>evidencedBy</para></remarks>
    /// <seealso href="http://purl.org/coreo#evidencedBy">http://purl.org/coreo#evidencedBy</seealso>
    let evidencedBy = Prefixed_Name(coreo, "evidencedBy") |> PrefixedName
    /// <summary>
    ///   <para>coreo:SubstantialType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>A gufo:Type whose instances are objects.
    ///
    /// Instances of ObjectType are subclasses of Object.
    ///
    /// Examples include the object kinds "Car", "Person", "Apple"</para>
    /// labels<para>SubstantialType</para><para>ObjectType</para></remarks>
    /// <seealso href="http://purl.org/coreo#SubstantialType">http://purl.org/coreo#SubstantialType</seealso>
    let SubstantialType = Prefixed_Name(coreo, "SubstantialType") |> PrefixedName
    /// <summary>
    ///   <para>coreo:ArtifactType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>A gufo:Type whose instances are coreo:Artifact.
    ///
    /// Instances of coreo:ArtifactType are subclasses of coreo:Artifact.
    ///
    /// Examples include "Web Form", "Class Diagram", "Painting", a "Sculpture"</para>
    /// labels<para>ArtifactType</para></remarks>
    /// <seealso href="http://purl.org/coreo#ArtifactType">http://purl.org/coreo#ArtifactType</seealso>
    let ArtifactType = Prefixed_Name(coreo, "ArtifactType") |> PrefixedName
    /// <summary>
    ///   <para>coreo:HumanAspectType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>A gufo:Type whose instances are coreo:HumanAspect.
    ///
    /// Instances of coreo:HumanAspectType are subclasses of coreo:HumanAspect.
    ///
    /// Examples include the coreo:SkillType "Java Programming", the coreo:CompetenceType "Software Development", the coreo:HumanAttitude "Collaboration", the coreo:HumanKnowledge "Quantum Physics", the coreo:HumanCharacteristic "Age", "Gender", and "Interest"</para>
    /// labels<para>HumanAspectType</para></remarks>
    /// <seealso href="http://purl.org/coreo#HumanAspectType">http://purl.org/coreo#HumanAspectType</seealso>
    let HumanAspectType = Prefixed_Name(coreo, "HumanAspectType") |> PrefixedName
    /// <summary>
    ///   <para>coreo:CapabilityContext</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>Capability Context</para></remarks>
    /// <seealso href="http://purl.org/coreo#CapabilityContext">http://purl.org/coreo#CapabilityContext</seealso>
    let CapabilityContext = Prefixed_Name(coreo, "CapabilityContext") |> PrefixedName
    /// <summary>
    ///   <para>coreo:CapabilityOutcome</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>Capability Outcome</para></remarks>
    /// <seealso href="http://purl.org/coreo#CapabilityOutcome">http://purl.org/coreo#CapabilityOutcome</seealso>
    let CapabilityOutcome = Prefixed_Name(coreo, "CapabilityOutcome") |> PrefixedName
    /// <summary>
    ///   <para>coreo:Person</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>gufo:Kind</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Physical agent that are human being</para>
    /// labels<para>Person</para></remarks>
    /// <seealso href="http://purl.org/coreo#Person">http://purl.org/coreo#Person</seealso>
    let Person = Prefixed_Name(coreo, "Person") |> PrefixedName

    /// <summary>
    ///   <para>coreo:personalCompetenceHasAttitude</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>parthood relation between a competence and attitude</para>
    /// labels<para>hasAttitude</para></remarks>
    /// <seealso href="http://purl.org/coreo#personalCompetenceHasAttitude">http://purl.org/coreo#personalCompetenceHasAttitude</seealso>
    let personalCompetenceHasAttitude =
        Prefixed_Name(coreo, "personalCompetenceHasAttitude") |> PrefixedName

    /// <summary>
    ///   <para>coreo:specializes_1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>specialization relation between types symbolizing the types that are instances of other type</para>
    /// labels<para>specializes</para></remarks>
    /// <seealso href="http://purl.org/coreo#specializes_1">http://purl.org/coreo#specializes_1</seealso>
    let specializes_1 = Prefixed_Name(coreo, "specializes_1") |> PrefixedName

    /// <summary>
    ///   <para>coreo:personalCompetenceHasSkill</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>parthood relation between a competence and skill</para>
    /// labels<para>hasSkill</para></remarks>
    /// <seealso href="http://purl.org/coreo#personalCompetenceHasSkill">http://purl.org/coreo#personalCompetenceHasSkill</seealso>
    let personalCompetenceHasSkill =
        Prefixed_Name(coreo, "personalCompetenceHasSkill") |> PrefixedName

    /// <summary>
    ///   <para>coreo:CapabilityManifestation</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>Capability Manifestation</para></remarks>
    /// <seealso href="http://purl.org/coreo#CapabilityManifestation">http://purl.org/coreo#CapabilityManifestation</seealso>
    let CapabilityManifestation =
        Prefixed_Name(coreo, "CapabilityManifestation") |> PrefixedName

    /// <summary>
    ///   <para>coreo:CapabilityRequiringRole</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>CapabilityRequiringRole</para></remarks>
    /// <seealso href="http://purl.org/coreo#CapabilityRequiringRole">http://purl.org/coreo#CapabilityRequiringRole</seealso>
    let CapabilityRequiringRole =
        Prefixed_Name(coreo, "CapabilityRequiringRole") |> PrefixedName

    /// <summary>
    ///   <para>coreo:CompetenceOutcome</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>gufo:SituationType</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>CompetenceOutcome</para></remarks>
    /// <seealso href="http://purl.org/coreo#CompetenceOutcome">http://purl.org/coreo#CompetenceOutcome</seealso>
    let CompetenceOutcome = Prefixed_Name(coreo, "CompetenceOutcome") |> PrefixedName
    /// <summary>
    ///   <para>coreo:Evidence</para>
    /// </summary>
    /// <remarks>
    ///   <para>gufo:Category</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>Any object (social or not) used to prove a human capability.
    /// E.G.  John's graduation certification in computer science,  Mary's project participation.</para>
    /// labels<para>Evidence</para></remarks>
    /// <seealso href="http://purl.org/coreo#Evidence">http://purl.org/coreo#Evidence</seealso>
    let Evidence = Prefixed_Name(coreo, "Evidence") |> PrefixedName
    /// <summary>
    ///   <para>coreo:HumanTask</para>
    /// </summary>
    /// <remarks>
    ///   <para>gufo:EventType</para>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Event performed by a person as a result of the manifestation of his/her human capabilities</para>
    /// labels<para>HumanTask</para></remarks>
    /// <seealso href="http://purl.org/coreo#HumanTask">http://purl.org/coreo#HumanTask</seealso>
    let HumanTask = Prefixed_Name(coreo, "HumanTask") |> PrefixedName
    /// <summary>
    ///   <para>coreo:CompetenceType</para>
    /// </summary>
    /// <remarks>
    ///   <para>A gufo:Type whose instances are coreo:PersonalCompetence.
    ///
    /// Instances of coreo:CompetenceType are subclasses of coreo:PersonalCompetence.
    ///
    /// Examples include the competence type of "Software Development"</para>
    /// labels<para>CompetenceType</para></remarks>
    /// <seealso href="http://purl.org/coreo#CompetenceType">http://purl.org/coreo#CompetenceType</seealso>
    let CompetenceType = Prefixed_Name(coreo, "CompetenceType") |> PrefixedName
    /// <summary>
    ///   <para>coreo:Field</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Knowledge Area</para>
    /// labels<para>Field</para></remarks>
    /// <seealso href="http://purl.org/coreo#Field">http://purl.org/coreo#Field</seealso>
    let Field = Prefixed_Name(coreo, "Field") |> PrefixedName
    /// <summary>
    ///   <para>coreo:PersonalCompetence</para>
    /// </summary>
    /// <remarks>
    ///   <para>gufo:SubKind</para>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Competence is a human capability inherent to an individual and formed by the combination of perceptible characteristics, such as the ``well-known'' knowledge, skills, and attitudes (KSA) elements.
    ///
    ///
    /// E.G. John's agile software development competence, Ronaldo's football playing competence</para>
    /// labels<para>PersonalCompetence</para></remarks>
    /// <seealso href="http://purl.org/coreo#PersonalCompetence">http://purl.org/coreo#PersonalCompetence</seealso>
    let PersonalCompetence = Prefixed_Name(coreo, "PersonalCompetence") |> PrefixedName
    /// <summary>
    ///   <para>coreo:HumanAspectPhase</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>HumanAspectPhase</para></remarks>
    /// <seealso href="http://purl.org/coreo#HumanAspectPhase">http://purl.org/coreo#HumanAspectPhase</seealso>
    let HumanAspectPhase = Prefixed_Name(coreo, "HumanAspectPhase") |> PrefixedName
    /// <summary>
    ///   <para>coreo:inheresIn_2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AsymmetricProperty</para>
    ///   <para>owl:IrreflexiveProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>relates the coreo:HumanAspect to the correspondent coreo:Person</para>
    /// labels<para>inheresInPerson</para></remarks>
    /// <seealso href="http://purl.org/coreo#inheresIn_2">http://purl.org/coreo#inheresIn_2</seealso>
    let inheresIn_2 = Prefixed_Name(coreo, "inheresIn_2") |> PrefixedName
    /// <summary>
    ///   <para>coreo:MomentType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>A gufo:Type whose instances are aspects.
    ///
    /// Instances of AspectType are subclasses of gufo:Aspect.
    ///
    /// Examples include the aspect kind "age", "knowledge", and "mariage"</para>
    /// labels<para>AspectType</para></remarks>
    /// <seealso href="http://purl.org/coreo#MomentType">http://purl.org/coreo#MomentType</seealso>
    let MomentType = Prefixed_Name(coreo, "MomentType") |> PrefixedName
    /// <summary>
    ///   <para>coreo:inheresIn_1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:IrreflexiveProperty</para>
    ///   <para>owl:AsymmetricProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>relates the coreo:HumanCapability to the correspondent coreo:Person</para>
    /// labels<para>CapabilityInheresInPerson</para></remarks>
    /// <seealso href="http://purl.org/coreo#inheresIn_1">http://purl.org/coreo#inheresIn_1</seealso>
    let inheresIn_1 = Prefixed_Name(coreo, "inheresIn_1") |> PrefixedName
    /// <summary>
    ///   <para>coreo:inheresIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AsymmetricProperty</para>
    ///   <para>owl:IrreflexiveProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>relates a coreo:Proficiency to the correspondent coreo:HumanCapability</para>
    /// labels<para>inheresInHumanCapability</para></remarks>
    /// <seealso href="http://purl.org/coreo#inheresIn">http://purl.org/coreo#inheresIn</seealso>
    let inheresIn = Prefixed_Name(coreo, "inheresIn") |> PrefixedName
    /// <summary>
    ///   <para>coreo:wasManifestedIn_1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Identifies a coreo:HumanTask in which the coreo:HumanCapability is manifested.</para>
    /// labels<para>wasManifestedIn</para></remarks>
    /// <seealso href="http://purl.org/coreo#wasManifestedIn_1">http://purl.org/coreo#wasManifestedIn_1</seealso>
    let wasManifestedIn_1 = Prefixed_Name(coreo, "wasManifestedIn_1") |> PrefixedName
    /// <summary>
    ///   <para>coreo:Proficiency</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>gufo:Kind</para>
    ///   <para>Intencity or deepness of a human capability. Can be related to level, degree, score, or other quality.</para>
    /// labels<para>Proficiency</para></remarks>
    /// <seealso href="http://purl.org/coreo#Proficiency">http://purl.org/coreo#Proficiency</seealso>
    let Proficiency = Prefixed_Name(coreo, "Proficiency") |> PrefixedName

    /// <summary>
    ///   <para>coreo:HumanCharacteristic</para>
    /// </summary>
    /// <remarks>
    ///   <para>Human aspects inherent to an individual used to describe his/her profile, Includes qualities and traits</para>
    /// labels<para>HumanCharacteristic</para></remarks>
    /// <seealso href="http://purl.org/coreo#HumanCharacteristic">http://purl.org/coreo#HumanCharacteristic</seealso>
    let HumanCharacteristic =
        Prefixed_Name(coreo, "HumanCharacteristic") |> PrefixedName

    /// <summary>
    ///   <para>coreo:Resource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>gufo:RoleMixin</para>
    ///   <para>Any object used in a task by a person as manifestation of a human capability
    ///
    /// E.G. John's Integrated Development Environment (IDE)</para>
    /// labels<para>Resource</para></remarks>
    /// <seealso href="http://purl.org/coreo#Resource">http://purl.org/coreo#Resource</seealso>
    let Resource = Prefixed_Name(coreo, "Resource") |> PrefixedName
    /// <summary>
    ///   <para>coreo:wasUsedIn_1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>usage of an object in a human task as a resource</para>
    /// labels<para>wasUsedIn</para></remarks>
    /// <seealso href="http://purl.org/coreo#wasUsedIn_1">http://purl.org/coreo#wasUsedIn_1</seealso>
    let wasUsedIn_1 = Prefixed_Name(coreo, "wasUsedIn_1") |> PrefixedName
    /// <summary>
    ///   <para>coreo:Skill</para>
    /// </summary>
    /// <remarks>
    ///   <para>gufo:SubKind</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>Skill is a human capability of an individual to perform a task (discrete unit of work) well (RODRIGUES et al, 2021), not strongly related to a context.
    ///
    /// E.G. John' programming skill, Pelé's kick skill
    ///
    ///
    /// RODRIGUES, Margarida; FERNÁNDEZ-MACÍAS, Enrique; SOSTERO, Matteo. A unified conceptual framework of tasks, skills and competences. JRC Working Papers Series on Labour, Education and Technology, 2021.</para>
    /// labels<para>Skill</para></remarks>
    /// <seealso href="http://purl.org/coreo#Skill">http://purl.org/coreo#Skill</seealso>
    let Skill = Prefixed_Name(coreo, "Skill") |> PrefixedName
    /// <summary>
    ///   <para>coreo:performed</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>participation of a person in a human task</para>
    /// labels<para>performed</para></remarks>
    /// <seealso href="http://purl.org/coreo#performed">http://purl.org/coreo#performed</seealso>
    let performed = Prefixed_Name(coreo, "performed") |> PrefixedName
    /// <summary>
    ///   <para>coreo:wasGeneratedIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>output generation from a coreo:HumanTask</para>
    /// labels<para>wasGeneratedIn</para></remarks>
    /// <seealso href="http://purl.org/coreo#wasGeneratedIn">http://purl.org/coreo#wasGeneratedIn</seealso>
    let wasGeneratedIn = Prefixed_Name(coreo, "wasGeneratedIn") |> PrefixedName
    /// <summary>
    ///   <para>coreo:TaskInput</para>
    /// </summary>
    /// <remarks>
    ///   <para>gufo:RoleMixin</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>Artifact used in a task as manifestation of a human capability</para>
    /// labels<para>TaskInput</para></remarks>
    /// <seealso href="http://purl.org/coreo#TaskInput">http://purl.org/coreo#TaskInput</seealso>
    let TaskInput = Prefixed_Name(coreo, "TaskInput") |> PrefixedName
    /// <summary>
    ///   <para>coreo:TaskOutput</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>gufo:Category</para>
    ///   <para>owl:Class</para>
    ///   <para>Artifact created or changed in a task as manifestation of a human capability</para>
    /// labels<para>TaskOutput</para></remarks>
    /// <seealso href="http://purl.org/coreo#TaskOutput">http://purl.org/coreo#TaskOutput</seealso>
    let TaskOutput = Prefixed_Name(coreo, "TaskOutput") |> PrefixedName
    /// <summary>
    ///   <para>coreo:Object</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>gufo:Category</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>Object</para></remarks>
    /// <seealso href="http://purl.org/coreo#Object">http://purl.org/coreo#Object</seealso>
    let Object = Prefixed_Name(coreo, "Object") |> PrefixedName
    /// <summary>
    ///   <para>coreo:PerdurantType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://purl.org/coreo#PerdurantType">http://purl.org/coreo#PerdurantType</seealso>
    let PerdurantType = Prefixed_Name(coreo, "PerdurantType") |> PrefixedName

    /// <summary>
    ///   <para>coreo:PersonalCompetenceType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>PersonalCompetenceType</para></remarks>
    /// <seealso href="http://purl.org/coreo#PersonalCompetenceType">http://purl.org/coreo#PersonalCompetenceType</seealso>
    let PersonalCompetenceType =
        Prefixed_Name(coreo, "PersonalCompetenceType") |> PrefixedName

    /// <summary>
    ///   <para>coreo:Phase</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://purl.org/coreo#Phase">http://purl.org/coreo#Phase</seealso>
    let Phase = Prefixed_Name(coreo, "Phase") |> PrefixedName
    /// <summary>
    ///   <para>coreo:PhysicalAgent</para>
    /// </summary>
    /// <remarks>
    ///   <para>gufo:Category</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://purl.org/coreo#PhysicalAgent">http://purl.org/coreo#PhysicalAgent</seealso>
    let PhysicalAgent = Prefixed_Name(coreo, "PhysicalAgent") |> PrefixedName
    /// <summary>
    ///   <para>coreo:SkillType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>A gufo:Type whose instances are coreo:Skill.
    ///
    /// Instances of coreo:SkillType are subclasses of coreo:Skill.
    ///
    /// Examples include the skill type of "Java Programming"</para>
    /// labels<para>SkillType</para></remarks>
    /// <seealso href="http://purl.org/coreo#SkillType">http://purl.org/coreo#SkillType</seealso>
    let SkillType = Prefixed_Name(coreo, "SkillType") |> PrefixedName
    /// <summary>
    ///   <para>coreo:TaskType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>A gufo:Type whose instances are coreo:Task.
    ///
    /// Instances of coreo:TaskType are subclasses of coreo:Task.
    ///
    /// Examples include "Develop a Software", "Perform a Interview"</para>
    /// labels<para>TaskType</para></remarks>
    /// <seealso href="http://purl.org/coreo#TaskType">http://purl.org/coreo#TaskType</seealso>
    let TaskType = Prefixed_Name(coreo, "TaskType") |> PrefixedName

    /// <summary>
    ///   <para>coreo:capabilityRequiringRoleHasField</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Describes the field of a coreo:CapabilityRequiringRole</para>
    /// labels<para>hasField</para></remarks>
    /// <seealso href="http://purl.org/coreo#capabilityRequiringRoleHasField">http://purl.org/coreo#capabilityRequiringRoleHasField</seealso>
    let capabilityRequiringRoleHasField =
        Prefixed_Name(coreo, "capabilityRequiringRoleHasField") |> PrefixedName

    /// <summary>
    ///   <para>coreo:describedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relationship used to detail a type</para>
    /// labels<para>describedBy</para></remarks>
    /// <seealso href="http://purl.org/coreo#describedBy">http://purl.org/coreo#describedBy</seealso>
    let describedBy = Prefixed_Name(coreo, "describedBy") |> PrefixedName
    /// <summary>
    ///   <para>coreo:constitutes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Describes the constitutive relationship between coreo:HumanAspectTypes manifested as parthood relationships between their instances</para>
    /// labels<para>constitutesAspect</para></remarks>
    /// <seealso href="http://purl.org/coreo#constitutes">http://purl.org/coreo#constitutes</seealso>
    let constitutes = Prefixed_Name(coreo, "constitutes") |> PrefixedName
    /// <summary>
    ///   <para>coreo:contributesTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Describes the contribution relation between a coreo:HumanQuality and a coreo:PersonalCompetence</para>
    /// labels<para>contributesTo</para></remarks>
    /// <seealso href="http://purl.org/coreo#contributesTo">http://purl.org/coreo#contributesTo</seealso>
    let contributesTo = Prefixed_Name(coreo, "contributesTo") |> PrefixedName
    /// <summary>
    ///   <para>coreo:definedInTermsOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relationship used to detail a coreo:HumanCapabilityType</para>
    /// labels<para>definedInTermsOf</para></remarks>
    /// <seealso href="http://purl.org/coreo#definedInTermsOf">http://purl.org/coreo#definedInTermsOf</seealso>
    let definedInTermsOf = Prefixed_Name(coreo, "definedInTermsOf") |> PrefixedName
    /// <summary>
    ///   <para>coreo:wasUsedIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>usage of a artifact in a human task as input</para>
    /// labels<para>wasUsedIn</para></remarks>
    /// <seealso href="http://purl.org/coreo#wasUsedIn">http://purl.org/coreo#wasUsedIn</seealso>
    let wasUsedIn = Prefixed_Name(coreo, "wasUsedIn") |> PrefixedName
    /// <summary>
    ///   <para>coreo:ResourceType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>A gufo:Type whose instances are coreo:Resource.
    ///
    /// Instances of coreo:ResourceType are subclasses of coreo:Resource.
    ///
    /// Examples include "Tool", "Software", "Hardware"</para>
    /// labels<para>ResourceType</para></remarks>
    /// <seealso href="http://purl.org/coreo#ResourceType">http://purl.org/coreo#ResourceType</seealso>
    let ResourceType = Prefixed_Name(coreo, "ResourceType") |> PrefixedName
    /// <summary>
    ///   <para>coreo:SocialAgent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>gufo:Category</para>
    /// </remarks>
    /// <seealso href="http://purl.org/coreo#SocialAgent">http://purl.org/coreo#SocialAgent</seealso>
    let SocialAgent = Prefixed_Name(coreo, "SocialAgent") |> PrefixedName

    /// <summary>
    ///   <para>coreo:broughtAboutHumanTask</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para></para></remarks>
    /// <seealso href="http://purl.org/coreo#broughtAboutHumanTask">http://purl.org/coreo#broughtAboutHumanTask</seealso>
    let broughtAboutHumanTask =
        Prefixed_Name(coreo, "broughtAboutHumanTask") |> PrefixedName

    /// <summary>
    ///   <para>coreo:HumanCapabilityType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>A gufo:Type whose instances are dispositions.
    ///
    /// Instances of coreo:HumanCapabilityType are subclasses of coreo:HumanCapability.
    ///
    /// Examples include the skill type of "Java Programming" and competence type of "Software Development"</para>
    /// labels<para>HumanCapabilityType</para></remarks>
    /// <seealso href="http://purl.org/coreo#HumanCapabilityType">http://purl.org/coreo#HumanCapabilityType</seealso>
    let HumanCapabilityType =
        Prefixed_Name(coreo, "HumanCapabilityType") |> PrefixedName

    /// <summary>
    ///   <para>coreo:isDefinedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relationship used to detail a coreo:HumanCapabilityType</para>
    /// labels<para>isDefinedBy</para></remarks>
    /// <seealso href="http://purl.org/coreo#isDefinedBy">http://purl.org/coreo#isDefinedBy</seealso>
    let isDefinedBy = Prefixed_Name(coreo, "isDefinedBy") |> PrefixedName

    /// <summary>
    ///   <para>coreo:personalCompetenceHasHumanAspect</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>parthood relation between a competence and human aspect</para>
    /// labels<para>hasHumanAspect</para></remarks>
    /// <seealso href="http://purl.org/coreo#personalCompetenceHasHumanAspect">http://purl.org/coreo#personalCompetenceHasHumanAspect</seealso>
    let personalCompetenceHasHumanAspect =
        Prefixed_Name(coreo, "personalCompetenceHasHumanAspect") |> PrefixedName

    /// <summary>
    ///   <para>coreo:personalCompetenceHasKnowledge</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>parthood relation between a competence and knowledge</para>
    /// labels<para>hasKnowledge</para></remarks>
    /// <seealso href="http://purl.org/coreo#personalCompetenceHasKnowledge">http://purl.org/coreo#personalCompetenceHasKnowledge</seealso>
    let personalCompetenceHasKnowledge =
        Prefixed_Name(coreo, "personalCompetenceHasKnowledge") |> PrefixedName

    /// <summary>
    ///   <para>coreo:personalCompetenceHasPersonalCompetence</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>parthood relation between a competence and other competence</para>
    /// labels<para>hasCompetence</para></remarks>
    /// <seealso href="http://purl.org/coreo#personalCompetenceHasPersonalCompetence">http://purl.org/coreo#personalCompetenceHasPersonalCompetence</seealso>
    let personalCompetenceHasPersonalCompetence =
        Prefixed_Name(coreo, "personalCompetenceHasPersonalCompetence") |> PrefixedName

    /// <summary>
    ///   <para>coreo:specializes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>specialization relation between types symbolizing the types that are instances of other type</para>
    /// labels<para>specializesArtifact</para></remarks>
    /// <seealso href="http://purl.org/coreo#specializes">http://purl.org/coreo#specializes</seealso>
    let specializes = Prefixed_Name(coreo, "specializes") |> PrefixedName
    /// <summary>
    ///   <para>coreo:specializes_2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>specialization relation between types symbolizing the types that are instances of other type</para>
    /// labels<para>specializesAspect</para></remarks>
    /// <seealso href="http://purl.org/coreo#specializes_2">http://purl.org/coreo#specializes_2</seealso>
    let specializes_2 = Prefixed_Name(coreo, "specializes_2") |> PrefixedName
    /// <summary>
    ///   <para>coreo:specializes_3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>specialization relation between types symbolizing the types that are instances of other type</para>
    /// labels<para>specializesTask</para></remarks>
    /// <seealso href="http://purl.org/coreo#specializes_3">http://purl.org/coreo#specializes_3</seealso>
    let specializes_3 = Prefixed_Name(coreo, "specializes_3") |> PrefixedName
    /// <summary>
    ///   <para>coreo:specializes_4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>specialization relation between types symbolizing the types that are instances of other type</para>
    /// labels<para>specializesRole</para></remarks>
    /// <seealso href="http://purl.org/coreo#specializes_4">http://purl.org/coreo#specializes_4</seealso>
    let specializes_4 = Prefixed_Name(coreo, "specializes_4") |> PrefixedName
    /// <summary>
    ///   <para>coreo:standsIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Details the coreo:Resource that stands in a coreo:CompetenceContext</para>
    /// labels<para>standsInContext</para></remarks>
    /// <seealso href="http://purl.org/coreo#standsIn">http://purl.org/coreo#standsIn</seealso>
    let standsIn = Prefixed_Name(coreo, "standsIn") |> PrefixedName
    /// <summary>
    ///   <para>coreo:standsIn_1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Details the coreo:Artifact that stands in a coreo:CompetenceContext</para>
    /// labels<para>standsInContext</para></remarks>
    /// <seealso href="http://purl.org/coreo#standsIn_1">http://purl.org/coreo#standsIn_1</seealso>
    let standsIn_1 = Prefixed_Name(coreo, "standsIn_1") |> PrefixedName
    /// <summary>
    ///   <para>coreo:standsIn_2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Details the coreo:Artifact that stands in a coreo:CompetenceOutcome</para>
    /// labels<para>standsInOutcome</para></remarks>
    /// <seealso href="http://purl.org/coreo#standsIn_2">http://purl.org/coreo#standsIn_2</seealso>
    let standsIn_2 = Prefixed_Name(coreo, "standsIn_2") |> PrefixedName
