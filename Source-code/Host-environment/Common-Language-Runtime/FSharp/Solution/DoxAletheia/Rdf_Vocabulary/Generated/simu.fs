namespace https.www.w3id.org.simulation.ontology.slash

open DoxAletheia

module simu =
    let _namespace_name = "https://www.w3id.org/simulation/ontology/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// A specific kind of simulation in which the simulacrum alludes to the reality counterpart. Is a more subtle symbolic relationship than the normal simulation.
    /// <see href="https://www.w3id.org/simulation/ontology/AllusionSimulation"></see></summary>
    let AllusionSimulation = _prefix "AllusionSimulation"
    /// <summary>
    ///   <see href="https://www.w3id.org/simulation/ontology/SimulationOntology"></see>
    /// </summary>
    let SimulationOntology = _prefix "SimulationOntology"
    /// <summary>
    /// A simulation is the symbolic relationship that happens between a symbol and its symbolic meaning. The term is taken from Baudrillard's Simulacra and Simulation philosophical theory.
    /// <see href="https://www.w3id.org/simulation/ontology/Simulation"></see></summary>
    let Simulation = _prefix "Simulation"
    /// <summary>
    /// A simulation in which the simulacrum is associated with the reality counterpart. It is a very general relationship and should be used only when the association is explicitly stated by the source. I.E. in a dictionary of symbols it is written that X "is associated with" Y.
    /// <see href="https://www.w3id.org/simulation/ontology/AssociationSimulation"></see></summary>
    let AssociationSimulation = _prefix "AssociationSimulation"
    /// <summary>
    /// A specific kind of simulation in which the simulacrum is a symbolic attribute of the reality counterpart. Like "keys" as an attribute of Saint Peter.
    /// <see href="https://www.w3id.org/simulation/ontology/AttributeSimulation"></see></summary>
    let AttributeSimulation = _prefix "AttributeSimulation"
    /// <summary>
    /// The context is the setting (either social, historical, cultural etc...) in which a Simulation exists. An ash tree, in the Norse context is a symbol of Odin. On the other hand, a tree in a Celtic context is a symbol of connection.
    /// <see href="https://www.w3id.org/simulation/ontology/Context"></see></summary>
    let Context = _prefix "Context"
    /// <summary>
    /// inverse property of has context
    /// <see href="https://www.w3id.org/simulation/ontology/isContextOf"></see></summary>
    let isContextOf = _prefix "isContextOf"
    /// <summary>
    /// This class represents the source of a simulation. It is intended as the entity that acknowledges a simulation as a legitimate symbolic relationship. A source can either be a dictionary of symbols or a knowledge graph in which symbolic information are present.
    /// <see href="https://www.w3id.org/simulation/ontology/Source"></see></summary>
    let Source = _prefix "Source"
    /// <summary>
    /// A simulation in which the simulacrum corresponds to the reality counterpart. It is a very general relationship and should be used only when the correspondence is explicitly state by the source. I.E. in a dictionary of symbols it is written that X "corresponds to" Y.
    /// <see href="https://www.w3id.org/simulation/ontology/CorrespondenceSimulation"></see></summary>
    let CorrespondenceSimulation = _prefix "CorrespondenceSimulation"
    /// <summary>
    /// A specific kind of simulation in which the simulacrum is an emblem of the reality counterpart. Emblems are usually used as a graphical representation of something.
    /// <see href="https://www.w3id.org/simulation/ontology/EmblematicSimulation"></see></summary>
    let EmblematicSimulation = _prefix "EmblematicSimulation"
    /// <summary>
    /// A specific kind of simulation in which the simulacrum is a symbolic cure for the reality counterpart. The reality counterpart in this kind of simulation is in fact usually something negative like a disease or a curse.
    /// <see href="https://www.w3id.org/simulation/ontology/HealingSimulation"></see></summary>
    let HealingSimulation = _prefix "HealingSimulation"
    /// <summary>
    /// A specific relationship that links a simulation (usually a Healing Simulation) to a reality counterpart of which a simulacrum is the symbolic cure.
    /// <see href="https://www.w3id.org/simulation/ontology/healedRealityCounterpart"></see></summary>
    let healedRealityCounterpart = _prefix "healedRealityCounterpart"
    /// <summary>
    /// A reality counterpart is the symbolic meaning associated to a simulacrum. It's the element that is symbolically referred by the simulacrum in a simulation. The term is taken from Baudrillard's Simulacra and Simulation theory
    /// <see href="https://www.w3id.org/simulation/ontology/RealityCounterpart"></see></summary>
    let RealityCounterpart = _prefix "RealityCounterpart"
    /// <summary>
    /// This property links a simulation to its simulacrum.
    /// <see href="https://www.w3id.org/simulation/ontology/hasSimulacrum"></see></summary>
    let hasSimulacrum = _prefix "hasSimulacrum"
    /// <summary>
    /// A simulation in which the simulacrum is a manifestation of the reality counterpart. It is a very general relationship and should be used only when the manifestation is explicitly stated by the source. I.E. in a dictionary of symbols it is written than X "is a manifestation of" Y.
    /// <see href="https://www.w3id.org/simulation/ontology/ManifestationSimulation"></see></summary>
    let ManifestationSimulation = _prefix "ManifestationSimulation"
    /// <summary>
    /// A specific kind of simulation in which the simulacrum is a symbolic protection against the reality counterpart. Like agate as a protection against the evil eye.
    /// <see href="https://www.w3id.org/simulation/ontology/ProtectionSimulation"></see></summary>
    let ProtectionSimulation = _prefix "ProtectionSimulation"
    /// <summary>
    /// A specific relationship that links a simulation (usually a Protection Simulation) to a reality counterpart that is symbolically prevented by the simulacrum.
    /// <see href="https://www.w3id.org/simulation/ontology/preventedRealityCounterpart"></see></summary>
    let preventedRealityCounterpart = _prefix "preventedRealityCounterpart"
    /// <summary>
    /// Inversed property of has reality counterpart
    /// <see href="https://www.w3id.org/simulation/ontology/isRealityCounterpartOf"></see></summary>
    let isRealityCounterpartOf = _prefix "isRealityCounterpartOf"
    /// <summary>
    /// A simulation in which the simulacrum is related to the reality counterpart. It is a very general relationship and should be used only when the relatedness is explicitly stated by the source. I.E. in a dictionary of symbols it is written that X "is related to" Y.
    /// <see href="https://www.w3id.org/simulation/ontology/RelatednessSimulation"></see></summary>
    let RelatednessSimulation = _prefix "RelatednessSimulation"
    /// <summary>
    /// A simulacrum is something that carries a secondary meaning (the first being its literal meaning), of symbolic nature. i.e. a skull is the set of bones of a head (literal meaning), but it is also the symbol of death (secondary, symbolic meaning). The term is taken from Baudrillard's Simulacra and Simulation theory. The plural of simulacrum is simulacra.
    /// <see href="https://www.w3id.org/simulation/ontology/Simulacrum"></see></summary>
    let Simulacrum = _prefix "Simulacrum"
    /// <summary>
    /// Inversed property of has simulacrum
    /// <see href="https://www.w3id.org/simulation/ontology/isSimulacrumOf"></see></summary>
    let isSimulacrumOf = _prefix "isSimulacrumOf"
    /// <summary>
    /// This property links a Simulation to its reality counterpart. More specific relationships between a simulation and its reality counterpart are available as subproperties of this property.
    /// <see href="https://www.w3id.org/simulation/ontology/hasRealityCounterpart"></see></summary>
    let hasRealityCounterpart = _prefix "hasRealityCounterpart"
    /// <summary>
    /// This property links a Simulation to its context
    /// <see href="https://www.w3id.org/simulation/ontology/hasContext"></see></summary>
    let hasContext = _prefix "hasContext"
    /// <summary>
    /// A specific relationship that links a simulation to a reality counterpart that is symbolically eased by the simulacrum. Like the Onyx, which in Indic-Persian context is believed to symbolically ease childbirth.
    /// <see href="https://www.w3id.org/simulation/ontology/easedRealityCounterpart"></see></summary>
    let easedRealityCounterpart = _prefix "easedRealityCounterpart"
    /// <summary>
    /// Inverse property of eased reality counterpart
    /// <see href="https://www.w3id.org/simulation/ontology/isEasedRealityCounterpartOf"></see></summary>
    let isEasedRealityCounterpartOf = _prefix "isEasedRealityCounterpartOf"
    /// <summary>
    /// A specific relationship that links a simulation to a reality counterpart that is symbolically elicited by the simulacrum.
    /// <see href="https://www.w3id.org/simulation/ontology/elicitedRealityCounterpart"></see></summary>
    let elicitedRealityCounterpart = _prefix "elicitedRealityCounterpart"
    /// <summary>
    /// Inverse property of elicited reality counterpart
    /// <see href="https://www.w3id.org/simulation/ontology/isElicitedRealityCounterpartOf"></see></summary>
    let isElicitedRealityCounterpartOf = _prefix "isElicitedRealityCounterpartOf"
    /// <summary>
    /// This property is used when a variant is intended as the personified variant of the other entity. Like "Air" has personified variant "Air personified"
    /// <see href="https://www.w3id.org/simulation/ontology/hasPersonifiedVariant"></see></summary>
    let hasPersonifiedVariant = _prefix "hasPersonifiedVariant"
    /// <summary>
    /// This property links a simulacrum or a reality counterpart to a variant of theirs. A variant is intended as a narrower concept than one of those two elements. It is also used to define a set of elements in relation to a single element that is part of that set. I.e. "man and woman" is a variant of "woman", "golden apple" is a variant of "apple".
    /// <see href="https://www.w3id.org/simulation/ontology/hasVariant"></see></summary>
    let hasVariant = _prefix "hasVariant"
    /// <summary>
    /// Inverse property of has personified variant
    /// <see href="https://www.w3id.org/simulation/ontology/isPersonifiedVariantOf"></see></summary>
    let isPersonifiedVariantOf = _prefix "isPersonifiedVariantOf"
    /// <summary>
    /// This property links a Simulation with its source
    /// <see href="https://www.w3id.org/simulation/ontology/hasSource"></see></summary>
    let hasSource = _prefix "hasSource"
    /// <summary>
    /// Inverse property of has variant
    /// <see href="https://www.w3id.org/simulation/ontology/isVariantOf"></see></summary>
    let isVariantOf = _prefix "isVariantOf"
    /// <summary>
    /// Inverse property of healed reality counterpart
    /// <see href="https://www.w3id.org/simulation/ontology/isHealedRealityCounterpartOf"></see></summary>
    let isHealedRealityCounterpartOf = _prefix "isHealedRealityCounterpartOf"
    /// <summary>
    /// Inversed property of prevented reality counterpart
    /// <see href="https://www.w3id.org/simulation/ontology/isPreventedRealityCounterpartOf"></see></summary>
    let isPreventedRealityCounterpartOf = _prefix "isPreventedRealityCounterpartOf"
    /// <summary>
    /// Inverse property of restored reality counterpart
    /// <see href="https://www.w3id.org/simulation/ontology/isRestoredRealityCounterpartOf"></see></summary>
    let isRestoredRealityCounterpartOf = _prefix "isRestoredRealityCounterpartOf"
    /// <summary>
    /// A specific relationship that links a simulation to a reality counterpart that is symbolically restored by the simulacrum. Like the red valerian (simulacrum), which, in flower language, is symbolically believed to restore strenght (restored reality counterpart).
    /// <see href="https://www.w3id.org/simulation/ontology/restoredRealityCounterpart"></see></summary>
    let restoredRealityCounterpart = _prefix "restoredRealityCounterpart"
    /// <summary>
    /// Inverse property of has source
    /// <see href="https://www.w3id.org/simulation/ontology/isSourceOf"></see></summary>
    let isSourceOf = _prefix "isSourceOf"
    /// <summary>
    /// Inverse property of symbolic meaning
    /// <see href="https://www.w3id.org/simulation/ontology/isSymbolicMeaningOf"></see></summary>
    let isSymbolicMeaningOf = _prefix "isSymbolicMeaningOf"
    /// <summary>
    /// This property is a chain property that links a simulacrum with its reality counterpart. This direct relationship does not consider neither the context or the source of the simulation
    /// <see href="https://www.w3id.org/simulation/ontology/symbolicMeaning"></see></summary>
    let symbolicMeaning = _prefix "symbolicMeaning"
