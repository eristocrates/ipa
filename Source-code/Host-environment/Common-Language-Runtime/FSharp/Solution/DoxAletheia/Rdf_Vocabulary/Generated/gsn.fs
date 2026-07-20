namespace https.w3id.org.OntoGSN.ontology.hash

open DoxAletheia

module gsn =
    let _namespace_name = "https://w3id.org/OntoGSN/ontology#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/OntoGSN/ontology#Solution"></see>
    /// </summary>
    let Solution = _prefix "Solution"
    /// <summary>
    ///   <see href="https://w3id.org/OntoGSN/ontology#A"></see>
    /// </summary>
    let A = _prefix "A"
    /// <summary>
    ///   <see href="https://w3id.org/OntoGSN/ontology#B"></see>
    /// </summary>
    let B = _prefix "B"
    /// <summary>
    ///   <see href="https://w3id.org/OntoGSN/ontology#true"></see>
    /// </summary>
    let true_ = _prefix "true"
    /// <summary>
    ///   <see href="https://w3id.org/OntoGSN/ontology#supportedBy"></see>
    /// </summary>
    let supportedBy = _prefix "supportedBy"
    /// <summary>
    ///   <see href="https://w3id.org/OntoGSN/ontology#C"></see>
    /// </summary>
    let C = _prefix "C"
    /// <summary>
    ///   <see href="https://w3id.org/OntoGSN/ontology#X"></see>
    /// </summary>
    let X = _prefix "X"
    /// <summary>
    ///   <see href="https://w3id.org/OntoGSN/ontology#Goal"></see>
    /// </summary>
    let Goal = _prefix "Goal"
    /// <summary>
    ///   <see href="https://w3id.org/OntoGSN/ontology#valid"></see>
    /// </summary>
    let valid = _prefix "valid"
    /// <summary>
    ///   <see href="https://w3id.org/OntoGSN/ontology#M1"></see>
    /// </summary>
    let M1 = _prefix "M1"
    /// <summary>
    ///   <see href="https://w3id.org/OntoGSN/ontology#R"></see>
    /// </summary>
    let R = _prefix "R"
    /// <summary>
    ///   <see href="https://w3id.org/OntoGSN/ontology#Module"></see>
    /// </summary>
    let Module = _prefix "Module"
    /// <summary>
    ///   <see href="https://w3id.org/OntoGSN/ontology#M2"></see>
    /// </summary>
    let M2 = _prefix "M2"
    /// <summary>
    ///   <see href="https://w3id.org/OntoGSN/ontology#contains"></see>
    /// </summary>
    let contains = _prefix "contains"
    /// <summary>
    ///   <see href="https://w3id.org/OntoGSN/ontology#contract"></see>
    /// </summary>
    let contract = _prefix "contract"
    /// <summary>
    ///   <see href="https://w3id.org/OntoGSN/ontology#M"></see>
    /// </summary>
    let M = _prefix "M"
    /// <summary>
    ///   <see href="https://w3id.org/OntoGSN/ontology#N"></see>
    /// </summary>
    let N = _prefix "N"
    /// <summary>
    ///   <see href="https://w3id.org/OntoGSN/ontology#away"></see>
    /// </summary>
    let away = _prefix "away"
    /// <summary>
    ///   <see href="https://w3id.org/OntoGSN/ontology#G1"></see>
    /// </summary>
    let G1 = _prefix "G1"
    /// <summary>
    ///   <see href="https://w3id.org/OntoGSN/ontology#G2"></see>
    /// </summary>
    let G2 = _prefix "G2"
    /// <summary>
    ///   <see href="https://w3id.org/OntoGSN/ontology#inContextOf"></see>
    /// </summary>
    let inContextOf = _prefix "inContextOf"
    /// <summary>
    ///   <see href="https://w3id.org/OntoGSN/ontology#C1"></see>
    /// </summary>
    let C1 = _prefix "C1"
    /// <summary>
    ///   <see href="https://w3id.org/OntoGSN/ontology#C2"></see>
    /// </summary>
    let C2 = _prefix "C2"
    /// <summary>
    ///   <see href="https://w3id.org/OntoGSN/ontology#Context"></see>
    /// </summary>
    let Context = _prefix "Context"
    /// <summary>
    ///   <see href="https://w3id.org/OntoGSN/ontology#consistentWith"></see>
    /// </summary>
    let consistentWith = _prefix "consistentWith"
    /// <summary>
    ///   <see href="https://w3id.org/OntoGSN/ontology#Assumption"></see>
    /// </summary>
    let Assumption = _prefix "Assumption"
    /// <summary>
    ///   <see href="https://w3id.org/OntoGSN/ontology#M3"></see>
    /// </summary>
    let M3 = _prefix "M3"
    /// <summary>
    ///   <see href="https://w3id.org/OntoGSN/ontology#statement"></see>
    /// </summary>
    let statement = _prefix "statement"
    /// <summary>
    ///   <see href="https://w3id.org/OntoGSN/ontology#E1"></see>
    /// </summary>
    let E1 = _prefix "E1"
    /// <summary>
    ///   <see href="https://w3id.org/OntoGSN/ontology#E2"></see>
    /// </summary>
    let E2 = _prefix "E2"
    /// <summary>
    ///   <see href="https://w3id.org/OntoGSN/ontology#Template"></see>
    /// </summary>
    let Template = _prefix "Template"
    /// <summary>
    ///   <see href="https://w3id.org/OntoGSN/ontology#undeveloped"></see>
    /// </summary>
    let undeveloped = _prefix "undeveloped"
    /// <summary>
    ///   <see href="https://w3id.org/OntoGSN/ontology#published"></see>
    /// </summary>
    let published = _prefix "published"
    /// <summary>
    ///   <see href="https://w3id.org/OntoGSN/ontology#toBeSupportedByContract"></see>
    /// </summary>
    let toBeSupportedByContract = _prefix "toBeSupportedByContract"
    /// <summary>
    ///   <see href="https://w3id.org/OntoGSN/ontology#E"></see>
    /// </summary>
    let E = _prefix "E"
    /// <summary>
    ///   <see href="https://w3id.org/OntoGSN/ontology#relationshipType"></see>
    /// </summary>
    let relationshipType = _prefix "relationshipType"
    /// <summary>
    ///   <see href="https://w3id.org/OntoGSN/ontology#inDoubt"></see>
    /// </summary>
    let inDoubt = _prefix "inDoubt"
    /// <summary>
    ///   <see href="https://w3id.org/OntoGSN/ontology#Relationship"></see>
    /// </summary>
    let Relationship = _prefix "Relationship"
    /// <summary>
    ///   <see href="https://w3id.org/OntoGSN/ontology#defeated"></see>
    /// </summary>
    let defeated = _prefix "defeated"
    /// <summary>
    ///   <see href="https://w3id.org/OntoGSN/ontology#S"></see>
    /// </summary>
    let S = _prefix "S"
    /// <summary>
    ///   <see href="https://w3id.org/OntoGSN/ontology#G3"></see>
    /// </summary>
    let G3 = _prefix "G3"
    /// <summary>
    ///   <see href="https://w3id.org/OntoGSN/ontology#D"></see>
    /// </summary>
    let D = _prefix "D"
    /// <summary>
    ///   <see href="https://w3id.org/OntoGSN/ontology#challenges"></see>
    /// </summary>
    let challenges = _prefix "challenges"
    /// <summary>
    ///   <see href="https://w3id.org/OntoGSN/ontology#Strategy"></see>
    /// </summary>
    let Strategy = _prefix "Strategy"
    /// <summary>
    ///   <see href="https://w3id.org/OntoGSN/ontology#Argument"></see>
    /// </summary>
    let Argument = _prefix "Argument"
    /// <summary>
    ///   <see href="https://w3id.org/OntoGSN/ontology#coreOrExtension"></see>
    /// </summary>
    let coreOrExtension = _prefix "coreOrExtension"
    /// <summary>
    ///   <see href="https://w3id.org/OntoGSN/ontology#Defeater"></see>
    /// </summary>
    let Defeater = _prefix "Defeater"
    /// <summary>
    ///   <see href="https://w3id.org/OntoGSN/ontology#G"></see>
    /// </summary>
    let G = _prefix "G"
    /// <summary>
    ///   <see href="https://w3id.org/OntoGSN/ontology#substitutedBy"></see>
    /// </summary>
    let substitutedBy = _prefix "substitutedBy"
    /// <summary>
    ///   <see href="https://w3id.org/OntoGSN/ontology#J"></see>
    /// </summary>
    let J = _prefix "J"
    /// <summary>
    ///   <see href="https://w3id.org/OntoGSN/ontology#Justification"></see>
    /// </summary>
    let Justification = _prefix "Justification"
    /// <summary>
    ///   <see href="https://w3id.org/OntoGSN/ontology#S2"></see>
    /// </summary>
    let S2 = _prefix "S2"
    /// <summary>
    ///   <see href="https://w3id.org/OntoGSN/ontology#S1"></see>
    /// </summary>
    let S1 = _prefix "S1"
    /// <summary>
    ///   <see href="https://w3id.org/OntoGSN/ontology#R1"></see>
    /// </summary>
    let R1 = _prefix "R1"
    /// <summary>
    ///   <see href="https://w3id.org/OntoGSN/ontology#RelationshipWithConfidence"></see>
    /// </summary>
    let RelationshipWithConfidence = _prefix "RelationshipWithConfidence"
    /// <summary>
    ///   <see href="https://w3id.org/OntoGSN/ontology#R2"></see>
    /// </summary>
    let R2 = _prefix "R2"
    /// <summary>
    ///   <see href="https://w3id.org/OntoGSN/ontology#associatedWith"></see>
    /// </summary>
    let associatedWith = _prefix "associatedWith"
    /// <summary>
    ///   <see href="https://w3id.org/OntoGSN/ontology#assuranceClaimPoint"></see>
    /// </summary>
    let assuranceClaimPoint = _prefix "assuranceClaimPoint"
    /// <summary>
    ///   <see href="https://w3id.org/OntoGSN/ontology#ArtefactReference"></see>
    /// </summary>
    let ArtefactReference = _prefix "ArtefactReference"
    /// <summary>
    ///   <see href="https://w3id.org/OntoGSN/ontology#top"></see>
    /// </summary>
    let top = _prefix "top"
    /// <summary>
    ///   <see href="https://w3id.org/OntoGSN/ontology#R3"></see>
    /// </summary>
    let R3 = _prefix "R3"
    /// <summary>
    ///   <see href="https://w3id.org/OntoGSN/ontology#public"></see>
    /// </summary>
    let public_ = _prefix "public"
    /// <summary>
    ///   <see href="https://w3id.org/OntoGSN/ontology#P"></see>
    /// </summary>
    let P = _prefix "P"
    /// <summary>
    ///   <see href="https://w3id.org/OntoGSN/ontology#ID"></see>
    /// </summary>
    let ID = _prefix "ID"
    /// <summary>
    ///   <see href="https://w3id.org/OntoGSN/ontology#instantiationOf"></see>
    /// </summary>
    let instantiationOf = _prefix "instantiationOf"
    /// <summary>
    ///   <see href="https://w3id.org/OntoGSN/ontology#final"></see>
    /// </summary>
    let final = _prefix "final"
    /// <summary>
    ///   <see href="https://w3id.org/OntoGSN/ontology#Pattern"></see>
    /// </summary>
    let Pattern = _prefix "Pattern"
    /// <summary>
    ///   <see href="https://w3id.org/OntoGSN/ontology#GSNElement"></see>
    /// </summary>
    let GSNElement = _prefix "GSNElement"
    /// <summary>
    ///   <see href="https://w3id.org/OntoGSN/ontology#Artefact"></see>
    /// </summary>
    let Artefact = _prefix "Artefact"
    /// <summary>
    ///   <see href="https://w3id.org/OntoGSN/ontology#renderedAs"></see>
    /// </summary>
    let renderedAs = _prefix "renderedAs"
    /// <summary>
    ///   <see href="https://w3id.org/OntoGSN/ontology#AssuranceCase"></see>
    /// </summary>
    let AssuranceCase = _prefix "AssuranceCase"
    /// <summary>
    ///   <see href="https://w3id.org/OntoGSN/ontology#Catalogue"></see>
    /// </summary>
    let Catalogue = _prefix "Catalogue"
    /// <summary>
    ///   <see href="https://w3id.org/OntoGSN/ontology#InstantiationDataReference"></see>
    /// </summary>
    let InstantiationDataReference = _prefix "InstantiationDataReference"
    /// <summary>
    ///   <see href="https://w3id.org/OntoGSN/ontology#argumentType"></see>
    /// </summary>
    let argumentType = _prefix "argumentType"
    /// <summary>
    ///   <see href="https://w3id.org/OntoGSN/ontology#View"></see>
    /// </summary>
    let View = _prefix "View"
    /// <summary>
    ///   <see href="https://w3id.org/OntoGSN/ontology#applicability"></see>
    /// </summary>
    let applicability = _prefix "applicability"
    /// <summary>
    ///   <see href="https://w3id.org/OntoGSN/ontology#attachedTo"></see>
    /// </summary>
    let attachedTo = _prefix "attachedTo"
    /// <summary>
    ///   <see href="https://w3id.org/OntoGSN/ontology#choice"></see>
    /// </summary>
    let choice = _prefix "choice"
    /// <summary>
    ///   <see href="https://w3id.org/OntoGSN/ontology#collaboration"></see>
    /// </summary>
    let collaboration = _prefix "collaboration"
    /// <summary>
    ///   <see href="https://w3id.org/OntoGSN/ontology#consequences"></see>
    /// </summary>
    let consequences = _prefix "consequences"
    /// <summary>
    ///   <see href="https://w3id.org/OntoGSN/ontology#examples"></see>
    /// </summary>
    let examples = _prefix "examples"
    /// <summary>
    ///   <see href="https://w3id.org/OntoGSN/ontology#implementation"></see>
    /// </summary>
    let implementation = _prefix "implementation"
    /// <summary>
    ///   <see href="https://w3id.org/OntoGSN/ontology#intent"></see>
    /// </summary>
    let intent = _prefix "intent"
    /// <summary>
    ///   <see href="https://w3id.org/OntoGSN/ontology#knownUses"></see>
    /// </summary>
    let knownUses = _prefix "knownUses"
    /// <summary>
    ///   <see href="https://w3id.org/OntoGSN/ontology#maxCardinality"></see>
    /// </summary>
    let maxCardinality = _prefix "maxCardinality"
    /// <summary>
    ///   <see href="https://w3id.org/OntoGSN/ontology#minCardinality"></see>
    /// </summary>
    let minCardinality = _prefix "minCardinality"
    /// <summary>
    ///   <see href="https://w3id.org/OntoGSN/ontology#motivation"></see>
    /// </summary>
    let motivation = _prefix "motivation"
    /// <summary>
    ///   <see href="https://w3id.org/OntoGSN/ontology#multiple"></see>
    /// </summary>
    let multiple = _prefix "multiple"
    /// <summary>
    ///   <see href="https://w3id.org/OntoGSN/ontology#offDiagram"></see>
    /// </summary>
    let offDiagram = _prefix "offDiagram"
    /// <summary>
    ///   <see href="https://w3id.org/OntoGSN/ontology#optional"></see>
    /// </summary>
    let optional = _prefix "optional"
    /// <summary>
    ///   <see href="https://w3id.org/OntoGSN/ontology#participants"></see>
    /// </summary>
    let participants = _prefix "participants"
    /// <summary>
    ///   <see href="https://w3id.org/OntoGSN/ontology#refersTo"></see>
    /// </summary>
    let refersTo = _prefix "refersTo"
    /// <summary>
    ///   <see href="https://w3id.org/OntoGSN/ontology#relatedTo"></see>
    /// </summary>
    let relatedTo = _prefix "relatedTo"
    /// <summary>
    ///   <see href="https://w3id.org/OntoGSN/ontology#structure"></see>
    /// </summary>
    let structure = _prefix "structure"
    /// <summary>
    ///   <see href="https://w3id.org/OntoGSN/ontology#structured"></see>
    /// </summary>
    let structured = _prefix "structured"
    /// <summary>
    ///   <see href="https://w3id.org/OntoGSN/ontology#uninstantiated"></see>
    /// </summary>
    let uninstantiated = _prefix "uninstantiated"
    /// <summary>
    ///   <see href="https://w3id.org/OntoGSN/ontology#viewType"></see>
    /// </summary>
    let viewType = _prefix "viewType"
