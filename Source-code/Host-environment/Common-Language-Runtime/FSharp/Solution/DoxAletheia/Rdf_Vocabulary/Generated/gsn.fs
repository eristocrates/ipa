namespace https.w3id.org.OntoGSN.ontology.hash

open DoxAletheia.Rdf_Vocabulary

module gsn =
    let _namespace_name = "https://w3id.org/OntoGSN/ontology#"
    /// <summary>
    ///   <see href="https://w3id.org/OntoGSN/ontology#Solution"></see>
    /// </summary>
    let Solution = Namespaced_IRI.parse _namespace_name "Solution" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/OntoGSN/ontology#A"></see>
    /// </summary>
    let A = Namespaced_IRI.parse _namespace_name "A" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/OntoGSN/ontology#B"></see>
    /// </summary>
    let B = Namespaced_IRI.parse _namespace_name "B" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/OntoGSN/ontology#true"></see>
    /// </summary>
    let true_ = Namespaced_IRI.parse _namespace_name "true" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/OntoGSN/ontology#supportedBy"></see>
    /// </summary>
    let supportedBy =
        Namespaced_IRI.parse _namespace_name "supportedBy" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/OntoGSN/ontology#C"></see>
    /// </summary>
    let C = Namespaced_IRI.parse _namespace_name "C" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/OntoGSN/ontology#X"></see>
    /// </summary>
    let X = Namespaced_IRI.parse _namespace_name "X" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/OntoGSN/ontology#Goal"></see>
    /// </summary>
    let Goal = Namespaced_IRI.parse _namespace_name "Goal" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/OntoGSN/ontology#valid"></see>
    /// </summary>
    let valid = Namespaced_IRI.parse _namespace_name "valid" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/OntoGSN/ontology#M1"></see>
    /// </summary>
    let M1 = Namespaced_IRI.parse _namespace_name "M1" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/OntoGSN/ontology#R"></see>
    /// </summary>
    let R = Namespaced_IRI.parse _namespace_name "R" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/OntoGSN/ontology#Module"></see>
    /// </summary>
    let Module = Namespaced_IRI.parse _namespace_name "Module" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/OntoGSN/ontology#M2"></see>
    /// </summary>
    let M2 = Namespaced_IRI.parse _namespace_name "M2" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/OntoGSN/ontology#contains"></see>
    /// </summary>
    let contains = Namespaced_IRI.parse _namespace_name "contains" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/OntoGSN/ontology#contract"></see>
    /// </summary>
    let contract = Namespaced_IRI.parse _namespace_name "contract" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/OntoGSN/ontology#M"></see>
    /// </summary>
    let M = Namespaced_IRI.parse _namespace_name "M" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/OntoGSN/ontology#N"></see>
    /// </summary>
    let N = Namespaced_IRI.parse _namespace_name "N" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/OntoGSN/ontology#away"></see>
    /// </summary>
    let away = Namespaced_IRI.parse _namespace_name "away" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/OntoGSN/ontology#G1"></see>
    /// </summary>
    let G1 = Namespaced_IRI.parse _namespace_name "G1" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/OntoGSN/ontology#G2"></see>
    /// </summary>
    let G2 = Namespaced_IRI.parse _namespace_name "G2" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/OntoGSN/ontology#inContextOf"></see>
    /// </summary>
    let inContextOf =
        Namespaced_IRI.parse _namespace_name "inContextOf" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/OntoGSN/ontology#C1"></see>
    /// </summary>
    let C1 = Namespaced_IRI.parse _namespace_name "C1" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/OntoGSN/ontology#C2"></see>
    /// </summary>
    let C2 = Namespaced_IRI.parse _namespace_name "C2" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/OntoGSN/ontology#Context"></see>
    /// </summary>
    let Context = Namespaced_IRI.parse _namespace_name "Context" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/OntoGSN/ontology#consistentWith"></see>
    /// </summary>
    let consistentWith =
        Namespaced_IRI.parse _namespace_name "consistentWith" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/OntoGSN/ontology#Assumption"></see>
    /// </summary>
    let Assumption = Namespaced_IRI.parse _namespace_name "Assumption" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/OntoGSN/ontology#M3"></see>
    /// </summary>
    let M3 = Namespaced_IRI.parse _namespace_name "M3" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/OntoGSN/ontology#statement"></see>
    /// </summary>
    let statement = Namespaced_IRI.parse _namespace_name "statement" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/OntoGSN/ontology#E1"></see>
    /// </summary>
    let E1 = Namespaced_IRI.parse _namespace_name "E1" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/OntoGSN/ontology#E2"></see>
    /// </summary>
    let E2 = Namespaced_IRI.parse _namespace_name "E2" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/OntoGSN/ontology#Template"></see>
    /// </summary>
    let Template = Namespaced_IRI.parse _namespace_name "Template" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/OntoGSN/ontology#undeveloped"></see>
    /// </summary>
    let undeveloped =
        Namespaced_IRI.parse _namespace_name "undeveloped" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/OntoGSN/ontology#published"></see>
    /// </summary>
    let published = Namespaced_IRI.parse _namespace_name "published" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/OntoGSN/ontology#toBeSupportedByContract"></see>
    /// </summary>
    let toBeSupportedByContract =
        Namespaced_IRI.parse _namespace_name "toBeSupportedByContract" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/OntoGSN/ontology#E"></see>
    /// </summary>
    let E = Namespaced_IRI.parse _namespace_name "E" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/OntoGSN/ontology#relationshipType"></see>
    /// </summary>
    let relationshipType =
        Namespaced_IRI.parse _namespace_name "relationshipType" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/OntoGSN/ontology#inDoubt"></see>
    /// </summary>
    let inDoubt = Namespaced_IRI.parse _namespace_name "inDoubt" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/OntoGSN/ontology#Relationship"></see>
    /// </summary>
    let Relationship =
        Namespaced_IRI.parse _namespace_name "Relationship" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/OntoGSN/ontology#defeated"></see>
    /// </summary>
    let defeated = Namespaced_IRI.parse _namespace_name "defeated" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/OntoGSN/ontology#S"></see>
    /// </summary>
    let S = Namespaced_IRI.parse _namespace_name "S" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/OntoGSN/ontology#G3"></see>
    /// </summary>
    let G3 = Namespaced_IRI.parse _namespace_name "G3" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/OntoGSN/ontology#D"></see>
    /// </summary>
    let D = Namespaced_IRI.parse _namespace_name "D" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/OntoGSN/ontology#challenges"></see>
    /// </summary>
    let challenges = Namespaced_IRI.parse _namespace_name "challenges" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/OntoGSN/ontology#Strategy"></see>
    /// </summary>
    let Strategy = Namespaced_IRI.parse _namespace_name "Strategy" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/OntoGSN/ontology#Argument"></see>
    /// </summary>
    let Argument = Namespaced_IRI.parse _namespace_name "Argument" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/OntoGSN/ontology#coreOrExtension"></see>
    /// </summary>
    let coreOrExtension =
        Namespaced_IRI.parse _namespace_name "coreOrExtension" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/OntoGSN/ontology#Defeater"></see>
    /// </summary>
    let Defeater = Namespaced_IRI.parse _namespace_name "Defeater" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/OntoGSN/ontology#G"></see>
    /// </summary>
    let G = Namespaced_IRI.parse _namespace_name "G" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/OntoGSN/ontology#substitutedBy"></see>
    /// </summary>
    let substitutedBy =
        Namespaced_IRI.parse _namespace_name "substitutedBy" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/OntoGSN/ontology#J"></see>
    /// </summary>
    let J = Namespaced_IRI.parse _namespace_name "J" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/OntoGSN/ontology#Justification"></see>
    /// </summary>
    let Justification =
        Namespaced_IRI.parse _namespace_name "Justification" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/OntoGSN/ontology#S2"></see>
    /// </summary>
    let S2 = Namespaced_IRI.parse _namespace_name "S2" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/OntoGSN/ontology#S1"></see>
    /// </summary>
    let S1 = Namespaced_IRI.parse _namespace_name "S1" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/OntoGSN/ontology#R1"></see>
    /// </summary>
    let R1 = Namespaced_IRI.parse _namespace_name "R1" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/OntoGSN/ontology#RelationshipWithConfidence"></see>
    /// </summary>
    let RelationshipWithConfidence =
        Namespaced_IRI.parse _namespace_name "RelationshipWithConfidence" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/OntoGSN/ontology#R2"></see>
    /// </summary>
    let R2 = Namespaced_IRI.parse _namespace_name "R2" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/OntoGSN/ontology#associatedWith"></see>
    /// </summary>
    let associatedWith =
        Namespaced_IRI.parse _namespace_name "associatedWith" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/OntoGSN/ontology#assuranceClaimPoint"></see>
    /// </summary>
    let assuranceClaimPoint =
        Namespaced_IRI.parse _namespace_name "assuranceClaimPoint" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/OntoGSN/ontology#ArtefactReference"></see>
    /// </summary>
    let ArtefactReference =
        Namespaced_IRI.parse _namespace_name "ArtefactReference" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/OntoGSN/ontology#top"></see>
    /// </summary>
    let top = Namespaced_IRI.parse _namespace_name "top" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/OntoGSN/ontology#R3"></see>
    /// </summary>
    let R3 = Namespaced_IRI.parse _namespace_name "R3" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/OntoGSN/ontology#public"></see>
    /// </summary>
    let public_ = Namespaced_IRI.parse _namespace_name "public" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/OntoGSN/ontology#P"></see>
    /// </summary>
    let P = Namespaced_IRI.parse _namespace_name "P" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/OntoGSN/ontology#ID"></see>
    /// </summary>
    let ID = Namespaced_IRI.parse _namespace_name "ID" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/OntoGSN/ontology#instantiationOf"></see>
    /// </summary>
    let instantiationOf =
        Namespaced_IRI.parse _namespace_name "instantiationOf" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/OntoGSN/ontology#final"></see>
    /// </summary>
    let final = Namespaced_IRI.parse _namespace_name "final" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/OntoGSN/ontology#Pattern"></see>
    /// </summary>
    let Pattern = Namespaced_IRI.parse _namespace_name "Pattern" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/OntoGSN/ontology#GSNElement"></see>
    /// </summary>
    let GSNElement = Namespaced_IRI.parse _namespace_name "GSNElement" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/OntoGSN/ontology#Artefact"></see>
    /// </summary>
    let Artefact = Namespaced_IRI.parse _namespace_name "Artefact" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/OntoGSN/ontology#renderedAs"></see>
    /// </summary>
    let renderedAs = Namespaced_IRI.parse _namespace_name "renderedAs" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/OntoGSN/ontology#AssuranceCase"></see>
    /// </summary>
    let AssuranceCase =
        Namespaced_IRI.parse _namespace_name "AssuranceCase" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/OntoGSN/ontology#Catalogue"></see>
    /// </summary>
    let Catalogue = Namespaced_IRI.parse _namespace_name "Catalogue" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/OntoGSN/ontology#InstantiationDataReference"></see>
    /// </summary>
    let InstantiationDataReference =
        Namespaced_IRI.parse _namespace_name "InstantiationDataReference" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/OntoGSN/ontology#argumentType"></see>
    /// </summary>
    let argumentType =
        Namespaced_IRI.parse _namespace_name "argumentType" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/OntoGSN/ontology#View"></see>
    /// </summary>
    let View = Namespaced_IRI.parse _namespace_name "View" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/OntoGSN/ontology#applicability"></see>
    /// </summary>
    let applicability =
        Namespaced_IRI.parse _namespace_name "applicability" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/OntoGSN/ontology#attachedTo"></see>
    /// </summary>
    let attachedTo = Namespaced_IRI.parse _namespace_name "attachedTo" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/OntoGSN/ontology#choice"></see>
    /// </summary>
    let choice = Namespaced_IRI.parse _namespace_name "choice" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/OntoGSN/ontology#collaboration"></see>
    /// </summary>
    let collaboration =
        Namespaced_IRI.parse _namespace_name "collaboration" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/OntoGSN/ontology#consequences"></see>
    /// </summary>
    let consequences =
        Namespaced_IRI.parse _namespace_name "consequences" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/OntoGSN/ontology#examples"></see>
    /// </summary>
    let examples = Namespaced_IRI.parse _namespace_name "examples" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/OntoGSN/ontology#implementation"></see>
    /// </summary>
    let implementation =
        Namespaced_IRI.parse _namespace_name "implementation" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/OntoGSN/ontology#intent"></see>
    /// </summary>
    let intent = Namespaced_IRI.parse _namespace_name "intent" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/OntoGSN/ontology#knownUses"></see>
    /// </summary>
    let knownUses = Namespaced_IRI.parse _namespace_name "knownUses" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/OntoGSN/ontology#maxCardinality"></see>
    /// </summary>
    let maxCardinality =
        Namespaced_IRI.parse _namespace_name "maxCardinality" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/OntoGSN/ontology#minCardinality"></see>
    /// </summary>
    let minCardinality =
        Namespaced_IRI.parse _namespace_name "minCardinality" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/OntoGSN/ontology#motivation"></see>
    /// </summary>
    let motivation = Namespaced_IRI.parse _namespace_name "motivation" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/OntoGSN/ontology#multiple"></see>
    /// </summary>
    let multiple = Namespaced_IRI.parse _namespace_name "multiple" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/OntoGSN/ontology#offDiagram"></see>
    /// </summary>
    let offDiagram = Namespaced_IRI.parse _namespace_name "offDiagram" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/OntoGSN/ontology#optional"></see>
    /// </summary>
    let optional = Namespaced_IRI.parse _namespace_name "optional" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/OntoGSN/ontology#participants"></see>
    /// </summary>
    let participants =
        Namespaced_IRI.parse _namespace_name "participants" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/OntoGSN/ontology#refersTo"></see>
    /// </summary>
    let refersTo = Namespaced_IRI.parse _namespace_name "refersTo" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/OntoGSN/ontology#relatedTo"></see>
    /// </summary>
    let relatedTo = Namespaced_IRI.parse _namespace_name "relatedTo" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/OntoGSN/ontology#structure"></see>
    /// </summary>
    let structure = Namespaced_IRI.parse _namespace_name "structure" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/OntoGSN/ontology#structured"></see>
    /// </summary>
    let structured = Namespaced_IRI.parse _namespace_name "structured" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/OntoGSN/ontology#uninstantiated"></see>
    /// </summary>
    let uninstantiated =
        Namespaced_IRI.parse _namespace_name "uninstantiated" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/OntoGSN/ontology#viewType"></see>
    /// </summary>
    let viewType = Namespaced_IRI.parse _namespace_name "viewType" |> NamespacedName
