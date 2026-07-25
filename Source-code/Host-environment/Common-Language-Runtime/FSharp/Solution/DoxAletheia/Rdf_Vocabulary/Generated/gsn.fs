namespace https.w3id.org.OntoGSN.ontology.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module gsn =
    let _namespace_iri = Namespace_Iri gsn |> NamespaceIRI
    /// <summary>
    ///   <para>gsn:Solution</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Solution</para></remarks>
    /// <seealso href="https://w3id.org/OntoGSN/ontology#Solution">https://w3id.org/OntoGSN/ontology#Solution</seealso>
    let Solution = Prefixed_Name(gsn, "Solution") |> PrefixedName
    /// <summary>
    ///   <para>gsn:B</para>
    /// </summary>
    /// <remarks>
    ///   <para>swrl:Variable</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/OntoGSN/ontology#B">https://w3id.org/OntoGSN/ontology#B</seealso>
    let B = Prefixed_Name(gsn, "B") |> PrefixedName
    /// <summary>
    ///   <para>gsn:A</para>
    /// </summary>
    /// <remarks>
    ///   <para>swrl:Variable</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/OntoGSN/ontology#A">https://w3id.org/OntoGSN/ontology#A</seealso>
    let A = Prefixed_Name(gsn, "A") |> PrefixedName
    /// <summary>
    ///   <para>gsn:true</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>true</para></remarks>
    /// <seealso href="https://w3id.org/OntoGSN/ontology#true">https://w3id.org/OntoGSN/ontology#true</seealso>
    let true_ = Prefixed_Name(gsn, "true") |> PrefixedName
    /// <summary>
    ///   <para>gsn:viewType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>view type</para></remarks>
    /// <seealso href="https://w3id.org/OntoGSN/ontology#viewType">https://w3id.org/OntoGSN/ontology#viewType</seealso>
    let viewType = Prefixed_Name(gsn, "viewType") |> PrefixedName
    /// <summary>
    ///   <para>gsn:contains</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>contains</para></remarks>
    /// <seealso href="https://w3id.org/OntoGSN/ontology#contains">https://w3id.org/OntoGSN/ontology#contains</seealso>
    let contains = Prefixed_Name(gsn, "contains") |> PrefixedName
    /// <summary>
    ///   <para>gsn:GSNElement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>GSN Element</para></remarks>
    /// <seealso href="https://w3id.org/OntoGSN/ontology#GSNElement">https://w3id.org/OntoGSN/ontology#GSNElement</seealso>
    let GSNElement = Prefixed_Name(gsn, "GSNElement") |> PrefixedName
    /// <summary>
    ///   <para>gsn:renderedAs</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///
    /// labels<para>rendered as</para></remarks>
    /// <seealso href="https://w3id.org/OntoGSN/ontology#renderedAs">https://w3id.org/OntoGSN/ontology#renderedAs</seealso>
    let renderedAs = Prefixed_Name(gsn, "renderedAs") |> PrefixedName
    /// <summary>
    ///   <para>gsn:AssuranceCase</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Assurance Case</para></remarks>
    /// <seealso href="https://w3id.org/OntoGSN/ontology#AssuranceCase">https://w3id.org/OntoGSN/ontology#AssuranceCase</seealso>
    let AssuranceCase = Prefixed_Name(gsn, "AssuranceCase") |> PrefixedName
    /// <summary>
    ///   <para>gsn:defeated</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>defeated</para></remarks>
    /// <seealso href="https://w3id.org/OntoGSN/ontology#defeated">https://w3id.org/OntoGSN/ontology#defeated</seealso>
    let defeated = Prefixed_Name(gsn, "defeated") |> PrefixedName
    /// <summary>
    ///   <para>gsn:D</para>
    /// </summary>
    /// <remarks>
    ///   <para>swrl:Variable</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/OntoGSN/ontology#D">https://w3id.org/OntoGSN/ontology#D</seealso>
    let D = Prefixed_Name(gsn, "D") |> PrefixedName
    /// <summary>
    ///   <para>gsn:challenges</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>challenges</para></remarks>
    /// <seealso href="https://w3id.org/OntoGSN/ontology#challenges">https://w3id.org/OntoGSN/ontology#challenges</seealso>
    let challenges = Prefixed_Name(gsn, "challenges") |> PrefixedName
    /// <summary>
    ///   <para>gsn:Strategy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Strategy</para></remarks>
    /// <seealso href="https://w3id.org/OntoGSN/ontology#Strategy">https://w3id.org/OntoGSN/ontology#Strategy</seealso>
    let Strategy = Prefixed_Name(gsn, "Strategy") |> PrefixedName
    /// <summary>
    ///   <para>gsn:public</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>public</para></remarks>
    /// <seealso href="https://w3id.org/OntoGSN/ontology#public">https://w3id.org/OntoGSN/ontology#public</seealso>
    let public_ = Prefixed_Name(gsn, "public") |> PrefixedName
    /// <summary>
    ///   <para>gsn:final</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>final</para></remarks>
    /// <seealso href="https://w3id.org/OntoGSN/ontology#final">https://w3id.org/OntoGSN/ontology#final</seealso>
    let final = Prefixed_Name(gsn, "final") |> PrefixedName
    /// <summary>
    ///   <para>gsn:Pattern</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Pattern</para></remarks>
    /// <seealso href="https://w3id.org/OntoGSN/ontology#Pattern">https://w3id.org/OntoGSN/ontology#Pattern</seealso>
    let Pattern = Prefixed_Name(gsn, "Pattern") |> PrefixedName
    /// <summary>
    ///   <para>gsn:attachedTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>attached to</para></remarks>
    /// <seealso href="https://w3id.org/OntoGSN/ontology#attachedTo">https://w3id.org/OntoGSN/ontology#attachedTo</seealso>
    let attachedTo = Prefixed_Name(gsn, "attachedTo") |> PrefixedName
    /// <summary>
    ///   <para>gsn:choice</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>choice</para></remarks>
    /// <seealso href="https://w3id.org/OntoGSN/ontology#choice">https://w3id.org/OntoGSN/ontology#choice</seealso>
    let choice = Prefixed_Name(gsn, "choice") |> PrefixedName
    /// <summary>
    ///   <para>gsn:collaboration</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///
    /// labels<para>collaboration</para></remarks>
    /// <seealso href="https://w3id.org/OntoGSN/ontology#collaboration">https://w3id.org/OntoGSN/ontology#collaboration</seealso>
    let collaboration = Prefixed_Name(gsn, "collaboration") |> PrefixedName
    /// <summary>
    ///   <para>gsn:consequences</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///
    /// labels<para>consequences</para></remarks>
    /// <seealso href="https://w3id.org/OntoGSN/ontology#consequences">https://w3id.org/OntoGSN/ontology#consequences</seealso>
    let consequences = Prefixed_Name(gsn, "consequences") |> PrefixedName
    /// <summary>
    ///   <para>gsn:X</para>
    /// </summary>
    /// <remarks>
    ///   <para>swrl:Variable</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/OntoGSN/ontology#X">https://w3id.org/OntoGSN/ontology#X</seealso>
    let X = Prefixed_Name(gsn, "X") |> PrefixedName
    /// <summary>
    ///   <para>gsn:Goal</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Goal</para></remarks>
    /// <seealso href="https://w3id.org/OntoGSN/ontology#Goal">https://w3id.org/OntoGSN/ontology#Goal</seealso>
    let Goal = Prefixed_Name(gsn, "Goal") |> PrefixedName
    /// <summary>
    ///   <para>gsn:S2</para>
    /// </summary>
    /// <remarks>
    ///   <para>swrl:Variable</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/OntoGSN/ontology#S2">https://w3id.org/OntoGSN/ontology#S2</seealso>
    let S2 = Prefixed_Name(gsn, "S2") |> PrefixedName
    /// <summary>
    ///   <para>gsn:R1</para>
    /// </summary>
    /// <remarks>
    ///   <para>swrl:Variable</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/OntoGSN/ontology#R1">https://w3id.org/OntoGSN/ontology#R1</seealso>
    let R1 = Prefixed_Name(gsn, "R1") |> PrefixedName
    /// <summary>
    ///   <para>gsn:R2</para>
    /// </summary>
    /// <remarks>
    ///   <para>swrl:Variable</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/OntoGSN/ontology#R2">https://w3id.org/OntoGSN/ontology#R2</seealso>
    let R2 = Prefixed_Name(gsn, "R2") |> PrefixedName
    /// <summary>
    ///   <para>gsn:M3</para>
    /// </summary>
    /// <remarks>
    ///   <para>swrl:Variable</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/OntoGSN/ontology#M3">https://w3id.org/OntoGSN/ontology#M3</seealso>
    let M3 = Prefixed_Name(gsn, "M3") |> PrefixedName
    /// <summary>
    ///   <para>gsn:Justification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Justification</para></remarks>
    /// <seealso href="https://w3id.org/OntoGSN/ontology#Justification">https://w3id.org/OntoGSN/ontology#Justification</seealso>
    let Justification = Prefixed_Name(gsn, "Justification") |> PrefixedName
    /// <summary>
    ///   <para>gsn:S1</para>
    /// </summary>
    /// <remarks>
    ///   <para>swrl:Variable</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/OntoGSN/ontology#S1">https://w3id.org/OntoGSN/ontology#S1</seealso>
    let S1 = Prefixed_Name(gsn, "S1") |> PrefixedName

    /// <summary>
    ///   <para>gsn:RelationshipWithConfidence</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Relationship with Confidence</para></remarks>
    /// <seealso href="https://w3id.org/OntoGSN/ontology#RelationshipWithConfidence">https://w3id.org/OntoGSN/ontology#RelationshipWithConfidence</seealso>
    let RelationshipWithConfidence =
        Prefixed_Name(gsn, "RelationshipWithConfidence") |> PrefixedName

    /// <summary>
    ///   <para>gsn:associatedWith</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>associated with</para></remarks>
    /// <seealso href="https://w3id.org/OntoGSN/ontology#associatedWith">https://w3id.org/OntoGSN/ontology#associatedWith</seealso>
    let associatedWith = Prefixed_Name(gsn, "associatedWith") |> PrefixedName
    /// <summary>
    ///   <para>gsn:examples</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///
    /// labels<para>examples</para></remarks>
    /// <seealso href="https://w3id.org/OntoGSN/ontology#examples">https://w3id.org/OntoGSN/ontology#examples</seealso>
    let examples = Prefixed_Name(gsn, "examples") |> PrefixedName
    /// <summary>
    ///   <para>gsn:implementation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///
    /// labels<para>implementation</para></remarks>
    /// <seealso href="https://w3id.org/OntoGSN/ontology#implementation">https://w3id.org/OntoGSN/ontology#implementation</seealso>
    let implementation = Prefixed_Name(gsn, "implementation") |> PrefixedName
    /// <summary>
    ///   <para>gsn:assuranceClaimPoint</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>assurance claim point</para></remarks>
    /// <seealso href="https://w3id.org/OntoGSN/ontology#assuranceClaimPoint">https://w3id.org/OntoGSN/ontology#assuranceClaimPoint</seealso>
    let assuranceClaimPoint = Prefixed_Name(gsn, "assuranceClaimPoint") |> PrefixedName
    /// <summary>
    ///   <para>gsn:statement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>statement</para></remarks>
    /// <seealso href="https://w3id.org/OntoGSN/ontology#statement">https://w3id.org/OntoGSN/ontology#statement</seealso>
    let statement = Prefixed_Name(gsn, "statement") |> PrefixedName
    /// <summary>
    ///   <para>gsn:E1</para>
    /// </summary>
    /// <remarks>
    ///   <para>swrl:Variable</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/OntoGSN/ontology#E1">https://w3id.org/OntoGSN/ontology#E1</seealso>
    let E1 = Prefixed_Name(gsn, "E1") |> PrefixedName
    /// <summary>
    ///   <para>gsn:E2</para>
    /// </summary>
    /// <remarks>
    ///   <para>swrl:Variable</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/OntoGSN/ontology#E2">https://w3id.org/OntoGSN/ontology#E2</seealso>
    let E2 = Prefixed_Name(gsn, "E2") |> PrefixedName
    /// <summary>
    ///   <para>gsn:Template</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Template</para></remarks>
    /// <seealso href="https://w3id.org/OntoGSN/ontology#Template">https://w3id.org/OntoGSN/ontology#Template</seealso>
    let Template = Prefixed_Name(gsn, "Template") |> PrefixedName
    /// <summary>
    ///   <para>gsn:undeveloped</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>undeveloped</para></remarks>
    /// <seealso href="https://w3id.org/OntoGSN/ontology#undeveloped">https://w3id.org/OntoGSN/ontology#undeveloped</seealso>
    let undeveloped = Prefixed_Name(gsn, "undeveloped") |> PrefixedName
    /// <summary>
    ///   <para>gsn:published</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>published</para></remarks>
    /// <seealso href="https://w3id.org/OntoGSN/ontology#published">https://w3id.org/OntoGSN/ontology#published</seealso>
    let published = Prefixed_Name(gsn, "published") |> PrefixedName
    /// <summary>
    ///   <para>gsn:intent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///
    /// labels<para>intent</para></remarks>
    /// <seealso href="https://w3id.org/OntoGSN/ontology#intent">https://w3id.org/OntoGSN/ontology#intent</seealso>
    let intent = Prefixed_Name(gsn, "intent") |> PrefixedName
    /// <summary>
    ///   <para>gsn:knownUses</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///
    /// labels<para>known uses</para></remarks>
    /// <seealso href="https://w3id.org/OntoGSN/ontology#knownUses">https://w3id.org/OntoGSN/ontology#knownUses</seealso>
    let knownUses = Prefixed_Name(gsn, "knownUses") |> PrefixedName
    /// <summary>
    ///   <para>gsn:motivation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///
    /// labels<para>motivation</para></remarks>
    /// <seealso href="https://w3id.org/OntoGSN/ontology#motivation">https://w3id.org/OntoGSN/ontology#motivation</seealso>
    let motivation = Prefixed_Name(gsn, "motivation") |> PrefixedName
    /// <summary>
    ///   <para>gsn:multiple</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>multiple</para></remarks>
    /// <seealso href="https://w3id.org/OntoGSN/ontology#multiple">https://w3id.org/OntoGSN/ontology#multiple</seealso>
    let multiple = Prefixed_Name(gsn, "multiple") |> PrefixedName
    /// <summary>
    ///   <para>gsn:offDiagram</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>off-diagram</para></remarks>
    /// <seealso href="https://w3id.org/OntoGSN/ontology#offDiagram">https://w3id.org/OntoGSN/ontology#offDiagram</seealso>
    let offDiagram = Prefixed_Name(gsn, "offDiagram") |> PrefixedName
    /// <summary>
    ///   <para>gsn:refersTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>refers to</para></remarks>
    /// <seealso href="https://w3id.org/OntoGSN/ontology#refersTo">https://w3id.org/OntoGSN/ontology#refersTo</seealso>
    let refersTo = Prefixed_Name(gsn, "refersTo") |> PrefixedName
    /// <summary>
    ///   <para>gsn:relatedTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>related to</para></remarks>
    /// <seealso href="https://w3id.org/OntoGSN/ontology#relatedTo">https://w3id.org/OntoGSN/ontology#relatedTo</seealso>
    let relatedTo = Prefixed_Name(gsn, "relatedTo") |> PrefixedName
    /// <summary>
    ///   <para>gsn:maxCardinality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>maximum cardinality</para></remarks>
    /// <seealso href="https://w3id.org/OntoGSN/ontology#maxCardinality">https://w3id.org/OntoGSN/ontology#maxCardinality</seealso>
    let maxCardinality = Prefixed_Name(gsn, "maxCardinality") |> PrefixedName
    /// <summary>
    ///   <para>gsn:minCardinality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>minimum cardinality</para></remarks>
    /// <seealso href="https://w3id.org/OntoGSN/ontology#minCardinality">https://w3id.org/OntoGSN/ontology#minCardinality</seealso>
    let minCardinality = Prefixed_Name(gsn, "minCardinality") |> PrefixedName
    /// <summary>
    ///   <para>gsn:optional</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>optional</para></remarks>
    /// <seealso href="https://w3id.org/OntoGSN/ontology#optional">https://w3id.org/OntoGSN/ontology#optional</seealso>
    let optional = Prefixed_Name(gsn, "optional") |> PrefixedName
    /// <summary>
    ///   <para>gsn:participants</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///
    /// labels<para>participants</para></remarks>
    /// <seealso href="https://w3id.org/OntoGSN/ontology#participants">https://w3id.org/OntoGSN/ontology#participants</seealso>
    let participants = Prefixed_Name(gsn, "participants") |> PrefixedName
    /// <summary>
    ///   <para>gsn:valid</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>valid</para></remarks>
    /// <seealso href="https://w3id.org/OntoGSN/ontology#valid">https://w3id.org/OntoGSN/ontology#valid</seealso>
    let valid = Prefixed_Name(gsn, "valid") |> PrefixedName
    /// <summary>
    ///   <para>gsn:R</para>
    /// </summary>
    /// <remarks>
    ///   <para>swrl:Variable</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/OntoGSN/ontology#R">https://w3id.org/OntoGSN/ontology#R</seealso>
    let R = Prefixed_Name(gsn, "R") |> PrefixedName
    /// <summary>
    ///   <para>gsn:Module</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Module</para></remarks>
    /// <seealso href="https://w3id.org/OntoGSN/ontology#Module">https://w3id.org/OntoGSN/ontology#Module</seealso>
    let Module = Prefixed_Name(gsn, "Module") |> PrefixedName
    /// <summary>
    ///   <para>gsn:M2</para>
    /// </summary>
    /// <remarks>
    ///   <para>swrl:Variable</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/OntoGSN/ontology#M2">https://w3id.org/OntoGSN/ontology#M2</seealso>
    let M2 = Prefixed_Name(gsn, "M2") |> PrefixedName
    /// <summary>
    ///   <para>gsn:E</para>
    /// </summary>
    /// <remarks>
    ///   <para>swrl:Variable</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/OntoGSN/ontology#E">https://w3id.org/OntoGSN/ontology#E</seealso>
    let E = Prefixed_Name(gsn, "E") |> PrefixedName
    /// <summary>
    ///   <para>gsn:structure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///
    /// labels<para>structure</para></remarks>
    /// <seealso href="https://w3id.org/OntoGSN/ontology#structure">https://w3id.org/OntoGSN/ontology#structure</seealso>
    let structure = Prefixed_Name(gsn, "structure") |> PrefixedName
    /// <summary>
    ///   <para>gsn:structured</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>structured</para></remarks>
    /// <seealso href="https://w3id.org/OntoGSN/ontology#structured">https://w3id.org/OntoGSN/ontology#structured</seealso>
    let structured = Prefixed_Name(gsn, "structured") |> PrefixedName
    /// <summary>
    ///   <para>gsn:M1</para>
    /// </summary>
    /// <remarks>
    ///   <para>swrl:Variable</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/OntoGSN/ontology#M1">https://w3id.org/OntoGSN/ontology#M1</seealso>
    let M1 = Prefixed_Name(gsn, "M1") |> PrefixedName
    /// <summary>
    ///   <para>gsn:ArtefactReference</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Artefact Reference</para></remarks>
    /// <seealso href="https://w3id.org/OntoGSN/ontology#ArtefactReference">https://w3id.org/OntoGSN/ontology#ArtefactReference</seealso>
    let ArtefactReference = Prefixed_Name(gsn, "ArtefactReference") |> PrefixedName
    /// <summary>
    ///   <para>gsn:top</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>top (goal)</para></remarks>
    /// <seealso href="https://w3id.org/OntoGSN/ontology#top">https://w3id.org/OntoGSN/ontology#top</seealso>
    let top = Prefixed_Name(gsn, "top") |> PrefixedName
    /// <summary>
    ///   <para>gsn:Artefact</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Artefact</para></remarks>
    /// <seealso href="https://w3id.org/OntoGSN/ontology#Artefact">https://w3id.org/OntoGSN/ontology#Artefact</seealso>
    let Artefact = Prefixed_Name(gsn, "Artefact") |> PrefixedName

    /// <summary>
    ///   <para>gsn:toBeSupportedByContract</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>to be supported by contract</para></remarks>
    /// <seealso href="https://w3id.org/OntoGSN/ontology#toBeSupportedByContract">https://w3id.org/OntoGSN/ontology#toBeSupportedByContract</seealso>
    let toBeSupportedByContract =
        Prefixed_Name(gsn, "toBeSupportedByContract") |> PrefixedName

    /// <summary>
    ///   <para>gsn:relationshipType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>relationship type</para></remarks>
    /// <seealso href="https://w3id.org/OntoGSN/ontology#relationshipType">https://w3id.org/OntoGSN/ontology#relationshipType</seealso>
    let relationshipType = Prefixed_Name(gsn, "relationshipType") |> PrefixedName
    /// <summary>
    ///   <para>gsn:uninstantiated</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>uninstantiated</para></remarks>
    /// <seealso href="https://w3id.org/OntoGSN/ontology#uninstantiated">https://w3id.org/OntoGSN/ontology#uninstantiated</seealso>
    let uninstantiated = Prefixed_Name(gsn, "uninstantiated") |> PrefixedName
    /// <summary>
    ///   <para>gsn:inDoubt</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>in doubt</para></remarks>
    /// <seealso href="https://w3id.org/OntoGSN/ontology#inDoubt">https://w3id.org/OntoGSN/ontology#inDoubt</seealso>
    let inDoubt = Prefixed_Name(gsn, "inDoubt") |> PrefixedName
    /// <summary>
    ///   <para>gsn:Relationship</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Relationship</para></remarks>
    /// <seealso href="https://w3id.org/OntoGSN/ontology#Relationship">https://w3id.org/OntoGSN/ontology#Relationship</seealso>
    let Relationship = Prefixed_Name(gsn, "Relationship") |> PrefixedName
    /// <summary>
    ///   <para>gsn:R3</para>
    /// </summary>
    /// <remarks>
    ///   <para>swrl:Variable</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/OntoGSN/ontology#R3">https://w3id.org/OntoGSN/ontology#R3</seealso>
    let R3 = Prefixed_Name(gsn, "R3") |> PrefixedName
    /// <summary>
    ///   <para>gsn:instantiationOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>instantiation of</para></remarks>
    /// <seealso href="https://w3id.org/OntoGSN/ontology#instantiationOf">https://w3id.org/OntoGSN/ontology#instantiationOf</seealso>
    let instantiationOf = Prefixed_Name(gsn, "instantiationOf") |> PrefixedName
    /// <summary>
    ///   <para>gsn:View</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>View</para></remarks>
    /// <seealso href="https://w3id.org/OntoGSN/ontology#View">https://w3id.org/OntoGSN/ontology#View</seealso>
    let View = Prefixed_Name(gsn, "View") |> PrefixedName
    /// <summary>
    ///   <para>gsn:applicability</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///
    /// labels<para>applicability</para></remarks>
    /// <seealso href="https://w3id.org/OntoGSN/ontology#applicability">https://w3id.org/OntoGSN/ontology#applicability</seealso>
    let applicability = Prefixed_Name(gsn, "applicability") |> PrefixedName
    /// <summary>
    ///   <para>gsn:contract</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>contract</para></remarks>
    /// <seealso href="https://w3id.org/OntoGSN/ontology#contract">https://w3id.org/OntoGSN/ontology#contract</seealso>
    let contract = Prefixed_Name(gsn, "contract") |> PrefixedName
    /// <summary>
    ///   <para>gsn:N</para>
    /// </summary>
    /// <remarks>
    ///   <para>swrl:Variable</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/OntoGSN/ontology#N">https://w3id.org/OntoGSN/ontology#N</seealso>
    let N = Prefixed_Name(gsn, "N") |> PrefixedName
    /// <summary>
    ///   <para>gsn:M</para>
    /// </summary>
    /// <remarks>
    ///   <para>swrl:Variable</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/OntoGSN/ontology#M">https://w3id.org/OntoGSN/ontology#M</seealso>
    let M = Prefixed_Name(gsn, "M") |> PrefixedName
    /// <summary>
    ///   <para>gsn:S</para>
    /// </summary>
    /// <remarks>
    ///   <para>swrl:Variable</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/OntoGSN/ontology#S">https://w3id.org/OntoGSN/ontology#S</seealso>
    let S = Prefixed_Name(gsn, "S") |> PrefixedName
    /// <summary>
    ///   <para>gsn:G3</para>
    /// </summary>
    /// <remarks>
    ///   <para>swrl:Variable</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/OntoGSN/ontology#G3">https://w3id.org/OntoGSN/ontology#G3</seealso>
    let G3 = Prefixed_Name(gsn, "G3") |> PrefixedName
    /// <summary>
    ///   <para>gsn:Catalogue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Catalogue</para></remarks>
    /// <seealso href="https://w3id.org/OntoGSN/ontology#Catalogue">https://w3id.org/OntoGSN/ontology#Catalogue</seealso>
    let Catalogue = Prefixed_Name(gsn, "Catalogue") |> PrefixedName
    /// <summary>
    ///   <para>gsn:G1</para>
    /// </summary>
    /// <remarks>
    ///   <para>swrl:Variable</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/OntoGSN/ontology#G1">https://w3id.org/OntoGSN/ontology#G1</seealso>
    let G1 = Prefixed_Name(gsn, "G1") |> PrefixedName
    /// <summary>
    ///   <para>gsn:Argument</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Argument</para></remarks>
    /// <seealso href="https://w3id.org/OntoGSN/ontology#Argument">https://w3id.org/OntoGSN/ontology#Argument</seealso>
    let Argument = Prefixed_Name(gsn, "Argument") |> PrefixedName
    /// <summary>
    ///   <para>gsn:coreOrExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///
    /// labels<para>core or extension</para></remarks>
    /// <seealso href="https://w3id.org/OntoGSN/ontology#coreOrExtension">https://w3id.org/OntoGSN/ontology#coreOrExtension</seealso>
    let coreOrExtension = Prefixed_Name(gsn, "coreOrExtension") |> PrefixedName

    /// <summary>
    ///   <para>gsn:InstantiationDataReference</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Instantiation Data Reference</para></remarks>
    /// <seealso href="https://w3id.org/OntoGSN/ontology#InstantiationDataReference">https://w3id.org/OntoGSN/ontology#InstantiationDataReference</seealso>
    let InstantiationDataReference =
        Prefixed_Name(gsn, "InstantiationDataReference") |> PrefixedName

    /// <summary>
    ///   <para>gsn:away</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>away</para></remarks>
    /// <seealso href="https://w3id.org/OntoGSN/ontology#away">https://w3id.org/OntoGSN/ontology#away</seealso>
    let away = Prefixed_Name(gsn, "away") |> PrefixedName
    /// <summary>
    ///   <para>gsn:G2</para>
    /// </summary>
    /// <remarks>
    ///   <para>swrl:Variable</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/OntoGSN/ontology#G2">https://w3id.org/OntoGSN/ontology#G2</seealso>
    let G2 = Prefixed_Name(gsn, "G2") |> PrefixedName
    /// <summary>
    ///   <para>gsn:inContextOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:IrreflexiveProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:AsymmetricProperty</para>
    ///
    /// labels<para>in context of</para></remarks>
    /// <seealso href="https://w3id.org/OntoGSN/ontology#inContextOf">https://w3id.org/OntoGSN/ontology#inContextOf</seealso>
    let inContextOf = Prefixed_Name(gsn, "inContextOf") |> PrefixedName
    /// <summary>
    ///   <para>gsn:C1</para>
    /// </summary>
    /// <remarks>
    ///   <para>swrl:Variable</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/OntoGSN/ontology#C1">https://w3id.org/OntoGSN/ontology#C1</seealso>
    let C1 = Prefixed_Name(gsn, "C1") |> PrefixedName
    /// <summary>
    ///   <para>gsn:Context</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Context</para></remarks>
    /// <seealso href="https://w3id.org/OntoGSN/ontology#Context">https://w3id.org/OntoGSN/ontology#Context</seealso>
    let Context = Prefixed_Name(gsn, "Context") |> PrefixedName
    /// <summary>
    ///   <para>gsn:consistentWith</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:SymmetricProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>consistent with</para></remarks>
    /// <seealso href="https://w3id.org/OntoGSN/ontology#consistentWith">https://w3id.org/OntoGSN/ontology#consistentWith</seealso>
    let consistentWith = Prefixed_Name(gsn, "consistentWith") |> PrefixedName
    /// <summary>
    ///   <para>gsn:argumentType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>argument type</para></remarks>
    /// <seealso href="https://w3id.org/OntoGSN/ontology#argumentType">https://w3id.org/OntoGSN/ontology#argumentType</seealso>
    let argumentType = Prefixed_Name(gsn, "argumentType") |> PrefixedName
    /// <summary>
    ///   <para>gsn:Defeater</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Defeater</para></remarks>
    /// <seealso href="https://w3id.org/OntoGSN/ontology#Defeater">https://w3id.org/OntoGSN/ontology#Defeater</seealso>
    let Defeater = Prefixed_Name(gsn, "Defeater") |> PrefixedName
    /// <summary>
    ///   <para>gsn:C2</para>
    /// </summary>
    /// <remarks>
    ///   <para>swrl:Variable</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/OntoGSN/ontology#C2">https://w3id.org/OntoGSN/ontology#C2</seealso>
    let C2 = Prefixed_Name(gsn, "C2") |> PrefixedName
    /// <summary>
    ///   <para>gsn:G</para>
    /// </summary>
    /// <remarks>
    ///   <para>swrl:Variable</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/OntoGSN/ontology#G">https://w3id.org/OntoGSN/ontology#G</seealso>
    let G = Prefixed_Name(gsn, "G") |> PrefixedName
    /// <summary>
    ///   <para>gsn:substitutedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>substituted by</para></remarks>
    /// <seealso href="https://w3id.org/OntoGSN/ontology#substitutedBy">https://w3id.org/OntoGSN/ontology#substitutedBy</seealso>
    let substitutedBy = Prefixed_Name(gsn, "substitutedBy") |> PrefixedName
    /// <summary>
    ///   <para>gsn:J</para>
    /// </summary>
    /// <remarks>
    ///   <para>swrl:Variable</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/OntoGSN/ontology#J">https://w3id.org/OntoGSN/ontology#J</seealso>
    let J = Prefixed_Name(gsn, "J") |> PrefixedName
    /// <summary>
    ///   <para>gsn:P</para>
    /// </summary>
    /// <remarks>
    ///   <para>swrl:Variable</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/OntoGSN/ontology#P">https://w3id.org/OntoGSN/ontology#P</seealso>
    let P = Prefixed_Name(gsn, "P") |> PrefixedName
    /// <summary>
    ///   <para>gsn:ID</para>
    /// </summary>
    /// <remarks>
    ///   <para>swrl:Variable</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/OntoGSN/ontology#ID">https://w3id.org/OntoGSN/ontology#ID</seealso>
    let ID = Prefixed_Name(gsn, "ID") |> PrefixedName
    /// <summary>
    ///   <para>gsn:supportedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AsymmetricProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:IrreflexiveProperty</para>
    ///
    /// labels<para>supported by</para></remarks>
    /// <seealso href="https://w3id.org/OntoGSN/ontology#supportedBy">https://w3id.org/OntoGSN/ontology#supportedBy</seealso>
    let supportedBy = Prefixed_Name(gsn, "supportedBy") |> PrefixedName
    /// <summary>
    ///   <para>gsn:C</para>
    /// </summary>
    /// <remarks>
    ///   <para>swrl:Variable</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/OntoGSN/ontology#C">https://w3id.org/OntoGSN/ontology#C</seealso>
    let C = Prefixed_Name(gsn, "C") |> PrefixedName
    /// <summary>
    ///   <para>gsn:Assumption</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Assumption</para></remarks>
    /// <seealso href="https://w3id.org/OntoGSN/ontology#Assumption">https://w3id.org/OntoGSN/ontology#Assumption</seealso>
    let Assumption = Prefixed_Name(gsn, "Assumption") |> PrefixedName
