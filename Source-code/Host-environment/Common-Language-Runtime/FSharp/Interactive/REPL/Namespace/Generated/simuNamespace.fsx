#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module simu =
    let _prefixId =
        PrefixId.fromNamespaceLabel "https://www.w3id.org/simulation/ontology/" "simu"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:label : Allusion Simulation</para>
    ///   <para>rdfs:comment : A specific kind of simulation in which the simulacrum alludes to the reality counterpart. Is a more subtle symbolic relationship than the normal simulation.</para>
    ///   <a href="https://www.w3id.org/simulation/ontology/AllusionSimulation">simu:AllusionSimulation</a>
    /// </summary>
    let AllusionSimulation = _prefixId.prefix "AllusionSimulation"
    /// <summary>
    ///   <para>rdfs:label : Association Simulation</para>
    ///   <para>rdfs:comment : A simulation in which the simulacrum is associated with the reality counterpart. It is a very general relationship and should be used only when the association is explicitly stated by the source. I.E. in a dictionary of symbols it is written that X "is associated with" Y.</para>
    ///   <a href="https://www.w3id.org/simulation/ontology/AssociationSimulation">simu:AssociationSimulation</a>
    /// </summary>
    let AssociationSimulation = _prefixId.prefix "AssociationSimulation"
    /// <summary>
    ///   <para>rdfs:label : Attribute Simulation</para>
    ///   <para>rdfs:comment : A specific kind of simulation in which the simulacrum is a symbolic attribute of the reality counterpart. Like "keys" as an attribute of Saint Peter.</para>
    ///   <a href="https://www.w3id.org/simulation/ontology/AttributeSimulation">simu:AttributeSimulation</a>
    /// </summary>
    let AttributeSimulation = _prefixId.prefix "AttributeSimulation"
    /// <summary>
    ///   <para>rdfs:label : Context</para>
    ///   <para>rdfs:comment : The context is the setting (either social, historical, cultural etc...) in which a Simulation exists. An ash tree, in the Norse context is a symbol of Odin. On the other hand, a tree in a Celtic context is a symbol of connection.</para>
    ///   <a href="https://www.w3id.org/simulation/ontology/Context">simu:Context</a>
    /// </summary>
    let Context = _prefixId.prefix "Context"
    /// <summary>
    ///   <para>rdfs:label : Correspondence Simulation</para>
    ///   <para>rdfs:comment : A simulation in which the simulacrum corresponds to the reality counterpart. It is a very general relationship and should be used only when the correspondence is explicitly state by the source. I.E. in a dictionary of symbols it is written that X "corresponds to" Y.</para>
    ///   <a href="https://www.w3id.org/simulation/ontology/CorrespondenceSimulation">simu:CorrespondenceSimulation</a>
    /// </summary>
    let CorrespondenceSimulation = _prefixId.prefix "CorrespondenceSimulation"
    /// <summary>
    ///   <para>rdfs:label : Emblematic Simulation</para>
    ///   <para>rdfs:comment : A specific kind of simulation in which the simulacrum is an emblem of the reality counterpart. Emblems are usually used as a graphical representation of something.</para>
    ///   <a href="https://www.w3id.org/simulation/ontology/EmblematicSimulation">simu:EmblematicSimulation</a>
    /// </summary>
    let EmblematicSimulation = _prefixId.prefix "EmblematicSimulation"
    /// <summary>
    ///   <para>rdfs:label : Healing Simulation</para>
    ///   <para>rdfs:comment : A specific kind of simulation in which the simulacrum is a symbolic cure for the reality counterpart. The reality counterpart in this kind of simulation is in fact usually something negative like a disease or a curse.</para>
    ///   <a href="https://www.w3id.org/simulation/ontology/HealingSimulation">simu:HealingSimulation</a>
    /// </summary>
    let HealingSimulation = _prefixId.prefix "HealingSimulation"
    /// <summary>
    ///   <para>rdfs:label : Manifestation Simulation</para>
    ///   <para>rdfs:comment : A simulation in which the simulacrum is a manifestation of the reality counterpart. It is a very general relationship and should be used only when the manifestation is explicitly stated by the source. I.E. in a dictionary of symbols it is written than X "is a manifestation of" Y.</para>
    ///   <a href="https://www.w3id.org/simulation/ontology/ManifestationSimulation">simu:ManifestationSimulation</a>
    /// </summary>
    let ManifestationSimulation = _prefixId.prefix "ManifestationSimulation"
    /// <summary>
    ///   <para>rdfs:label : Protection Simulation</para>
    ///   <para>rdfs:comment : A specific kind of simulation in which the simulacrum is a symbolic protection against the reality counterpart. Like agate as a protection against the evil eye.</para>
    ///   <a href="https://www.w3id.org/simulation/ontology/ProtectionSimulation">simu:ProtectionSimulation</a>
    /// </summary>
    let ProtectionSimulation = _prefixId.prefix "ProtectionSimulation"
    /// <summary>
    ///   <para>rdfs:label : Reality Counterpart</para>
    ///   <para>rdfs:comment : A reality counterpart is the symbolic meaning associated to a simulacrum. It's the element that is symbolically referred by the simulacrum in a simulation. The term is taken from Baudrillard's Simulacra and Simulation theory</para>
    ///   <a href="https://www.w3id.org/simulation/ontology/RealityCounterpart">simu:RealityCounterpart</a>
    /// </summary>
    let RealityCounterpart = _prefixId.prefix "RealityCounterpart"
    /// <summary>
    ///   <para>rdfs:label : Relatedness Simulation</para>
    ///   <para>rdfs:comment : A simulation in which the simulacrum is related to the reality counterpart. It is a very general relationship and should be used only when the relatedness is explicitly stated by the source. I.E. in a dictionary of symbols it is written that X "is related to" Y.</para>
    ///   <a href="https://www.w3id.org/simulation/ontology/RelatednessSimulation">simu:RelatednessSimulation</a>
    /// </summary>
    let RelatednessSimulation = _prefixId.prefix "RelatednessSimulation"
    /// <summary>
    ///   <para>rdfs:label : Simulacrum</para>
    ///   <para>rdfs:comment : A simulacrum is something that carries a secondary meaning (the first being its literal meaning), of symbolic nature. i.e. a skull is the set of bones of a head (literal meaning), but it is also the symbol of death (secondary, symbolic meaning). The term is taken from Baudrillard's Simulacra and Simulation theory. The plural of simulacrum is simulacra.</para>
    ///   <a href="https://www.w3id.org/simulation/ontology/Simulacrum">simu:Simulacrum</a>
    /// </summary>
    let Simulacrum = _prefixId.prefix "Simulacrum"
    /// <summary>
    ///   <para>rdfs:label : Simulation</para>
    ///   <para>rdfs:comment : A simulation is the symbolic relationship that happens between a symbol and its symbolic meaning. The term is taken from Baudrillard's Simulacra and Simulation philosophical theory.</para>
    ///   <a href="https://www.w3id.org/simulation/ontology/Simulation">simu:Simulation</a>
    /// </summary>
    let Simulation = _prefixId.prefix "Simulation"
    let SimulationOntology = _prefixId.prefix "SimulationOntology"
    /// <summary>
    ///   <para>rdfs:label : Source</para>
    ///   <para>rdfs:comment : This class represents the source of a simulation. It is intended as the entity that acknowledges a simulation as a legitimate symbolic relationship. A source can either be a dictionary of symbols or a knowledge graph in which symbolic information are present.</para>
    ///   <a href="https://www.w3id.org/simulation/ontology/Source">simu:Source</a>
    /// </summary>
    let Source = _prefixId.prefix "Source"
    /// <summary>
    ///   <para>rdfs:label : Eased reality counterpart</para>
    ///   <para>rdfs:comment : A specific relationship that links a simulation to a reality counterpart that is symbolically eased by the simulacrum. Like the Onyx, which in Indic-Persian context is believed to symbolically ease childbirth.</para>
    ///   <a href="https://www.w3id.org/simulation/ontology/easedRealityCounterpart">simu:easedRealityCounterpart</a>
    /// </summary>
    let easedRealityCounterpart = _prefixId.prefix "easedRealityCounterpart"
    /// <summary>
    ///   <para>rdfs:label : Elicited reality counterpart</para>
    ///   <para>rdfs:comment : A specific relationship that links a simulation to a reality counterpart that is symbolically elicited by the simulacrum.</para>
    ///   <a href="https://www.w3id.org/simulation/ontology/elicitedRealityCounterpart">simu:elicitedRealityCounterpart</a>
    /// </summary>
    let elicitedRealityCounterpart = _prefixId.prefix "elicitedRealityCounterpart"
    /// <summary>
    ///   <para>rdfs:label : has Context</para>
    ///   <para>rdfs:comment : This property links a Simulation to its context</para>
    ///   <a href="https://www.w3id.org/simulation/ontology/hasContext">simu:hasContext</a>
    /// </summary>
    let hasContext = _prefixId.prefix "hasContext"
    /// <summary>
    ///   <para>rdfs:label : Has personified variant</para>
    ///   <para>rdfs:comment : This property is used when a variant is intended as the personified variant of the other entity. Like "Air" has personified variant "Air personified"</para>
    ///   <a href="https://www.w3id.org/simulation/ontology/hasPersonifiedVariant">simu:hasPersonifiedVariant</a>
    /// </summary>
    let hasPersonifiedVariant = _prefixId.prefix "hasPersonifiedVariant"
    /// <summary>
    ///   <para>rdfs:label : Has reality counterpart</para>
    ///   <para>rdfs:comment : This property links a Simulation to its reality counterpart. More specific relationships between a simulation and its reality counterpart are available as subproperties of this property.</para>
    ///   <a href="https://www.w3id.org/simulation/ontology/hasRealityCounterpart">simu:hasRealityCounterpart</a>
    /// </summary>
    let hasRealityCounterpart = _prefixId.prefix "hasRealityCounterpart"
    /// <summary>
    ///   <para>rdfs:comment : This property links a simulation to its simulacrum.</para>
    ///   <para>rdfs:label : Has simulacrum</para>
    ///   <a href="https://www.w3id.org/simulation/ontology/hasSimulacrum">simu:hasSimulacrum</a>
    /// </summary>
    let hasSimulacrum = _prefixId.prefix "hasSimulacrum"
    /// <summary>
    ///   <para>owl:deprecated : deprecated on the 1.2 version^^xsd:string</para>
    ///   <para>rdfs:label : Has source</para>
    ///   <para>rdfs:comment : This property links a Simulation with its source</para>
    ///   <a href="https://www.w3id.org/simulation/ontology/hasSource">simu:hasSource</a>
    /// </summary>
    let hasSource = _prefixId.prefix "hasSource"
    /// <summary>
    ///   <para>rdfs:label : has variant</para>
    ///   <para>rdfs:comment : This property links a simulacrum or a reality counterpart to a variant of theirs. A variant is intended as a narrower concept than one of those two elements. It is also used to define a set of elements in relation to a single element that is part of that set. I.e. "man and woman" is a variant of "woman", "golden apple" is a variant of "apple".</para>
    ///   <a href="https://www.w3id.org/simulation/ontology/hasVariant">simu:hasVariant</a>
    /// </summary>
    let hasVariant = _prefixId.prefix "hasVariant"
    /// <summary>
    ///   <para>rdfs:label : Healed reality counterpart</para>
    ///   <para>rdfs:comment : A specific relationship that links a simulation (usually a Healing Simulation) to a reality counterpart of which a simulacrum is the symbolic cure.</para>
    ///   <a href="https://www.w3id.org/simulation/ontology/healedRealityCounterpart">simu:healedRealityCounterpart</a>
    /// </summary>
    let healedRealityCounterpart = _prefixId.prefix "healedRealityCounterpart"
    /// <summary>
    ///   <para>rdfs:label : Is context of</para>
    ///   <para>rdfs:comment : inverse property of has context</para>
    ///   <a href="https://www.w3id.org/simulation/ontology/isContextOf">simu:isContextOf</a>
    /// </summary>
    let isContextOf = _prefixId.prefix "isContextOf"
    /// <summary>
    ///   <para>rdfs:label : Is eased reality counterpart of</para>
    ///   <para>rdfs:comment : Inverse property of eased reality counterpart</para>
    ///   <a href="https://www.w3id.org/simulation/ontology/isEasedRealityCounterpartOf">simu:isEasedRealityCounterpartOf</a>
    /// </summary>
    let isEasedRealityCounterpartOf = _prefixId.prefix "isEasedRealityCounterpartOf"

    /// <summary>
    ///   <para>rdfs:label : Is elicited reality counterpart of</para>
    ///   <para>rdfs:comment : Inverse property of elicited reality counterpart</para>
    ///   <a href="https://www.w3id.org/simulation/ontology/isElicitedRealityCounterpartOf">simu:isElicitedRealityCounterpartOf</a>
    /// </summary>
    let isElicitedRealityCounterpartOf =
        _prefixId.prefix "isElicitedRealityCounterpartOf"

    /// <summary>
    ///   <para>rdfs:label : Is healed reality counterpart of</para>
    ///   <para>rdfs:comment : Inverse property of healed reality counterpart</para>
    ///   <a href="https://www.w3id.org/simulation/ontology/isHealedRealityCounterpartOf">simu:isHealedRealityCounterpartOf</a>
    /// </summary>
    let isHealedRealityCounterpartOf = _prefixId.prefix "isHealedRealityCounterpartOf"
    /// <summary>
    ///   <para>rdfs:label : Is personified variant of</para>
    ///   <para>rdfs:comment : Inverse property of has personified variant</para>
    ///   <a href="https://www.w3id.org/simulation/ontology/isPersonifiedVariantOf">simu:isPersonifiedVariantOf</a>
    /// </summary>
    let isPersonifiedVariantOf = _prefixId.prefix "isPersonifiedVariantOf"

    /// <summary>
    ///   <para>rdfs:label : Is prevented reality counterpart of</para>
    ///   <para>rdfs:comment : Inversed property of prevented reality counterpart</para>
    ///   <a href="https://www.w3id.org/simulation/ontology/isPreventedRealityCounterpartOf">simu:isPreventedRealityCounterpartOf</a>
    /// </summary>
    let isPreventedRealityCounterpartOf =
        _prefixId.prefix "isPreventedRealityCounterpartOf"

    /// <summary>
    ///   <para>rdfs:label : Is reality counterpart of</para>
    ///   <para>rdfs:comment : Inversed property of has reality counterpart</para>
    ///   <a href="https://www.w3id.org/simulation/ontology/isRealityCounterpartOf">simu:isRealityCounterpartOf</a>
    /// </summary>
    let isRealityCounterpartOf = _prefixId.prefix "isRealityCounterpartOf"

    /// <summary>
    ///   <para>rdfs:label : Is restored reality counterpart of</para>
    ///   <para>rdfs:comment : Inverse property of restored reality counterpart</para>
    ///   <a href="https://www.w3id.org/simulation/ontology/isRestoredRealityCounterpartOf">simu:isRestoredRealityCounterpartOf</a>
    /// </summary>
    let isRestoredRealityCounterpartOf =
        _prefixId.prefix "isRestoredRealityCounterpartOf"

    /// <summary>
    ///   <para>rdfs:label : Is simulacrum of</para>
    ///   <para>rdfs:comment : Inversed property of has simulacrum</para>
    ///   <a href="https://www.w3id.org/simulation/ontology/isSimulacrumOf">simu:isSimulacrumOf</a>
    /// </summary>
    let isSimulacrumOf = _prefixId.prefix "isSimulacrumOf"
    /// <summary>
    ///   <para>owl:deprecated : deprecated on the 1.2 version^^xsd:string</para>
    ///   <para>rdfs:label : Is source of</para>
    ///   <para>rdfs:comment : Inverse property of has source</para>
    ///   <a href="https://www.w3id.org/simulation/ontology/isSourceOf">simu:isSourceOf</a>
    /// </summary>
    let isSourceOf = _prefixId.prefix "isSourceOf"
    /// <summary>
    ///   <para>rdfs:label : Is symbolic meaning of</para>
    ///   <para>rdfs:comment : Inverse property of symbolic meaning</para>
    ///   <a href="https://www.w3id.org/simulation/ontology/isSymbolicMeaningOf">simu:isSymbolicMeaningOf</a>
    /// </summary>
    let isSymbolicMeaningOf = _prefixId.prefix "isSymbolicMeaningOf"
    /// <summary>
    ///   <para>rdfs:label : Is variant of</para>
    ///   <para>rdfs:comment : Inverse property of has variant</para>
    ///   <a href="https://www.w3id.org/simulation/ontology/isVariantOf">simu:isVariantOf</a>
    /// </summary>
    let isVariantOf = _prefixId.prefix "isVariantOf"
    /// <summary>
    ///   <para>rdfs:label : Prevented reality counterpart</para>
    ///   <para>rdfs:comment : A specific relationship that links a simulation (usually a Protection Simulation) to a reality counterpart that is symbolically prevented by the simulacrum.</para>
    ///   <a href="https://www.w3id.org/simulation/ontology/preventedRealityCounterpart">simu:preventedRealityCounterpart</a>
    /// </summary>
    let preventedRealityCounterpart = _prefixId.prefix "preventedRealityCounterpart"
    /// <summary>
    ///   <para>rdfs:label : Restored reality counterpart</para>
    ///   <para>rdfs:comment : A specific relationship that links a simulation to a reality counterpart that is symbolically restored by the simulacrum. Like the red valerian (simulacrum), which, in flower language, is symbolically believed to restore strenght (restored reality counterpart).</para>
    ///   <a href="https://www.w3id.org/simulation/ontology/restoredRealityCounterpart">simu:restoredRealityCounterpart</a>
    /// </summary>
    let restoredRealityCounterpart = _prefixId.prefix "restoredRealityCounterpart"
    /// <summary>
    ///   <para>rdfs:label : Symbolic Meaning</para>
    ///   <para>rdfs:comment : This property is a chain property that links a simulacrum with its reality counterpart. This direct relationship does not consider neither the context or the source of the simulation</para>
    ///   <a href="https://www.w3id.org/simulation/ontology/symbolicMeaning">simu:symbolicMeaning</a>
    /// </summary>
    let symbolicMeaning = _prefixId.prefix "symbolicMeaning"
