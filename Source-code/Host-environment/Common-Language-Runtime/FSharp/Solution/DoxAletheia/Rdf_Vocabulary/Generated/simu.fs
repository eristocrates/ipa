namespace https.www.w3id.org.simulation.ontology.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module simu =
    let _namespace_iri = Namespace_Iri simu |> NamespaceIRI
    /// <summary>
    ///   <para>simu:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///   <para>"This ontology was designed to conceptualize symbolic meanings following Baudrillard's Simulacra and Simulation theory. Symbols, their meaning, the context in which the symbolic meaning (or simulation) exists and the source of the simulation are linked to a N-ary Simulation Class."</para>
    /// labels<para>"Simulation Ontology"</para></remarks>
    /// <seealso href="https://www.w3id.org/simulation/ontology/">https://www.w3id.org/simulation/ontology/</seealso>
    let _prefix_iri = Prefixed_Name(simu, "") |> PrefixedName
    /// <summary>
    ///   <para>simu:AllusionSimulation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A specific kind of simulation in which the simulacrum alludes to the reality counterpart. Is a more subtle symbolic relationship than the normal simulation."</para>
    /// labels<para>"Allusion Simulation"</para></remarks>
    /// <seealso href="https://www.w3id.org/simulation/ontology/AllusionSimulation">https://www.w3id.org/simulation/ontology/AllusionSimulation</seealso>
    let AllusionSimulation = Prefixed_Name(simu, "AllusionSimulation") |> PrefixedName

    /// <summary>
    ///   <para>simu:AssociationSimulation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A simulation in which the simulacrum is associated with the reality counterpart. It is a very general relationship and should be used only when the association is explicitly stated by the source. I.E. in a dictionary of symbols it is written that X "is associated with" Y."</para>
    /// labels<para>"Association Simulation"</para></remarks>
    /// <seealso href="https://www.w3id.org/simulation/ontology/AssociationSimulation">https://www.w3id.org/simulation/ontology/AssociationSimulation</seealso>
    let AssociationSimulation =
        Prefixed_Name(simu, "AssociationSimulation") |> PrefixedName

    /// <summary>
    ///   <para>simu:AttributeSimulation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A specific kind of simulation in which the simulacrum is a symbolic attribute of the reality counterpart. Like "keys" as an attribute of Saint Peter."</para>
    /// labels<para>"Attribute Simulation"</para></remarks>
    /// <seealso href="https://www.w3id.org/simulation/ontology/AttributeSimulation">https://www.w3id.org/simulation/ontology/AttributeSimulation</seealso>
    let AttributeSimulation = Prefixed_Name(simu, "AttributeSimulation") |> PrefixedName
    /// <summary>
    ///   <para>simu:Context</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The context is the setting (either social, historical, cultural etc...) in which a Simulation exists. An ash tree, in the Norse context is a symbol of Odin. On the other hand, a tree in a Celtic context is a symbol of connection."</para>
    /// labels<para>"Context"</para></remarks>
    /// <seealso href="https://www.w3id.org/simulation/ontology/Context">https://www.w3id.org/simulation/ontology/Context</seealso>
    let Context = Prefixed_Name(simu, "Context") |> PrefixedName

    /// <summary>
    ///   <para>simu:CorrespondenceSimulation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A simulation in which the simulacrum corresponds to the reality counterpart. It is a very general relationship and should be used only when the correspondence is explicitly state by the source. I.E. in a dictionary of symbols it is written that X "corresponds to" Y."</para>
    /// labels<para>"Correspondence Simulation"</para></remarks>
    /// <seealso href="https://www.w3id.org/simulation/ontology/CorrespondenceSimulation">https://www.w3id.org/simulation/ontology/CorrespondenceSimulation</seealso>
    let CorrespondenceSimulation =
        Prefixed_Name(simu, "CorrespondenceSimulation") |> PrefixedName

    /// <summary>
    ///   <para>simu:EmblematicSimulation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A specific kind of simulation in which the simulacrum is an emblem of the reality counterpart. Emblems are usually used as a graphical representation of something."</para>
    /// labels<para>"Emblematic Simulation"</para></remarks>
    /// <seealso href="https://www.w3id.org/simulation/ontology/EmblematicSimulation">https://www.w3id.org/simulation/ontology/EmblematicSimulation</seealso>
    let EmblematicSimulation =
        Prefixed_Name(simu, "EmblematicSimulation") |> PrefixedName

    /// <summary>
    ///   <para>simu:HealingSimulation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A specific kind of simulation in which the simulacrum is a symbolic cure for the reality counterpart. The reality counterpart in this kind of simulation is in fact usually something negative like a disease or a curse."</para>
    /// labels<para>"Healing Simulation"</para></remarks>
    /// <seealso href="https://www.w3id.org/simulation/ontology/HealingSimulation">https://www.w3id.org/simulation/ontology/HealingSimulation</seealso>
    let HealingSimulation = Prefixed_Name(simu, "HealingSimulation") |> PrefixedName

    /// <summary>
    ///   <para>simu:ManifestationSimulation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A simulation in which the simulacrum is a manifestation of the reality counterpart. It is a very general relationship and should be used only when the manifestation is explicitly stated by the source. I.E. in a dictionary of symbols it is written than X "is a manifestation of" Y."</para>
    /// labels<para>"Manifestation Simulation"</para></remarks>
    /// <seealso href="https://www.w3id.org/simulation/ontology/ManifestationSimulation">https://www.w3id.org/simulation/ontology/ManifestationSimulation</seealso>
    let ManifestationSimulation =
        Prefixed_Name(simu, "ManifestationSimulation") |> PrefixedName

    /// <summary>
    ///   <para>simu:ProtectionSimulation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A specific kind of simulation in which the simulacrum is a symbolic protection against the reality counterpart. Like agate as a protection against the evil eye."</para>
    /// labels<para>"Protection Simulation"</para></remarks>
    /// <seealso href="https://www.w3id.org/simulation/ontology/ProtectionSimulation">https://www.w3id.org/simulation/ontology/ProtectionSimulation</seealso>
    let ProtectionSimulation =
        Prefixed_Name(simu, "ProtectionSimulation") |> PrefixedName

    /// <summary>
    ///   <para>simu:RealityCounterpart</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A reality counterpart is the symbolic meaning associated to a simulacrum. It's the element that is symbolically referred by the simulacrum in a simulation. The term is taken from Baudrillard's Simulacra and Simulation theory"</para>
    /// labels<para>"Reality Counterpart"</para></remarks>
    /// <seealso href="https://www.w3id.org/simulation/ontology/RealityCounterpart">https://www.w3id.org/simulation/ontology/RealityCounterpart</seealso>
    let RealityCounterpart = Prefixed_Name(simu, "RealityCounterpart") |> PrefixedName

    /// <summary>
    ///   <para>simu:RelatednessSimulation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A simulation in which the simulacrum is related to the reality counterpart. It is a very general relationship and should be used only when the relatedness is explicitly stated by the source. I.E. in a dictionary of symbols it is written that X "is related to" Y."</para>
    /// labels<para>"Relatedness Simulation"</para></remarks>
    /// <seealso href="https://www.w3id.org/simulation/ontology/RelatednessSimulation">https://www.w3id.org/simulation/ontology/RelatednessSimulation</seealso>
    let RelatednessSimulation =
        Prefixed_Name(simu, "RelatednessSimulation") |> PrefixedName

    /// <summary>
    ///   <para>simu:Simulacrum</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A simulacrum is something that carries a secondary meaning (the first being its literal meaning), of symbolic nature. i.e. a skull is the set of bones of a head (literal meaning), but it is also the symbol of death (secondary, symbolic meaning). The term is taken from Baudrillard's Simulacra and Simulation theory. The plural of simulacrum is simulacra."</para>
    /// labels<para>"Simulacrum"</para></remarks>
    /// <seealso href="https://www.w3id.org/simulation/ontology/Simulacrum">https://www.w3id.org/simulation/ontology/Simulacrum</seealso>
    let Simulacrum = Prefixed_Name(simu, "Simulacrum") |> PrefixedName
    /// <summary>
    ///   <para>simu:Simulation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A simulation is the symbolic relationship that happens between a symbol and its symbolic meaning. The term is taken from Baudrillard's Simulacra and Simulation philosophical theory."</para>
    /// labels<para>"Simulation"</para></remarks>
    /// <seealso href="https://www.w3id.org/simulation/ontology/Simulation">https://www.w3id.org/simulation/ontology/Simulation</seealso>
    let Simulation = Prefixed_Name(simu, "Simulation") |> PrefixedName
    /// <summary>
    ///   <para>simu:SimulationOntology</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://www.w3id.org/simulation/ontology/SimulationOntology">https://www.w3id.org/simulation/ontology/SimulationOntology</seealso>
    let SimulationOntology = Prefixed_Name(simu, "SimulationOntology") |> PrefixedName
    /// <summary>
    ///   <para>simu:Source</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class represents the source of a simulation. It is intended as the entity that acknowledges a simulation as a legitimate symbolic relationship. A source can either be a dictionary of symbols or a knowledge graph in which symbolic information are present."</para>
    /// labels<para>"Source"</para></remarks>
    /// <seealso href="https://www.w3id.org/simulation/ontology/Source">https://www.w3id.org/simulation/ontology/Source</seealso>
    let Source = Prefixed_Name(simu, "Source") |> PrefixedName

    /// <summary>
    ///   <para>simu:easedRealityCounterpart</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A specific relationship that links a simulation to a reality counterpart that is symbolically eased by the simulacrum. Like the Onyx, which in Indic-Persian context is believed to symbolically ease childbirth."</para>
    /// labels<para>"Eased reality counterpart"</para></remarks>
    /// <seealso href="https://www.w3id.org/simulation/ontology/easedRealityCounterpart">https://www.w3id.org/simulation/ontology/easedRealityCounterpart</seealso>
    let easedRealityCounterpart =
        Prefixed_Name(simu, "easedRealityCounterpart") |> PrefixedName

    /// <summary>
    ///   <para>simu:elicitedRealityCounterpart</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A specific relationship that links a simulation to a reality counterpart that is symbolically elicited by the simulacrum."</para>
    /// labels<para>"Elicited reality counterpart"</para></remarks>
    /// <seealso href="https://www.w3id.org/simulation/ontology/elicitedRealityCounterpart">https://www.w3id.org/simulation/ontology/elicitedRealityCounterpart</seealso>
    let elicitedRealityCounterpart =
        Prefixed_Name(simu, "elicitedRealityCounterpart") |> PrefixedName

    /// <summary>
    ///   <para>simu:hasContext</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property links a Simulation to its context"</para>
    /// labels<para>"has Context"</para></remarks>
    /// <seealso href="https://www.w3id.org/simulation/ontology/hasContext">https://www.w3id.org/simulation/ontology/hasContext</seealso>
    let hasContext = Prefixed_Name(simu, "hasContext") |> PrefixedName

    /// <summary>
    ///   <para>simu:hasPersonifiedVariant</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property is used when a variant is intended as the personified variant of the other entity. Like "Air" has personified variant "Air personified""</para>
    /// labels<para>"Has personified variant"</para></remarks>
    /// <seealso href="https://www.w3id.org/simulation/ontology/hasPersonifiedVariant">https://www.w3id.org/simulation/ontology/hasPersonifiedVariant</seealso>
    let hasPersonifiedVariant =
        Prefixed_Name(simu, "hasPersonifiedVariant") |> PrefixedName

    /// <summary>
    ///   <para>simu:hasRealityCounterpart</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property links a Simulation to its reality counterpart. More specific relationships between a simulation and its reality counterpart are available as subproperties of this property."</para>
    /// labels<para>"Has reality counterpart"</para></remarks>
    /// <seealso href="https://www.w3id.org/simulation/ontology/hasRealityCounterpart">https://www.w3id.org/simulation/ontology/hasRealityCounterpart</seealso>
    let hasRealityCounterpart =
        Prefixed_Name(simu, "hasRealityCounterpart") |> PrefixedName

    /// <summary>
    ///   <para>simu:hasSimulacrum</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property links a simulation to its simulacrum."</para>
    /// labels<para>"Has simulacrum"</para></remarks>
    /// <seealso href="https://www.w3id.org/simulation/ontology/hasSimulacrum">https://www.w3id.org/simulation/ontology/hasSimulacrum</seealso>
    let hasSimulacrum = Prefixed_Name(simu, "hasSimulacrum") |> PrefixedName
    /// <summary>
    ///   <para>simu:hasSource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property links a Simulation with its source"</para>
    /// labels<para>"Has source"</para></remarks>
    /// <seealso href="https://www.w3id.org/simulation/ontology/hasSource">https://www.w3id.org/simulation/ontology/hasSource</seealso>
    let hasSource = Prefixed_Name(simu, "hasSource") |> PrefixedName
    /// <summary>
    ///   <para>simu:hasVariant</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"This property links a simulacrum or a reality counterpart to a variant of theirs. A variant is intended as a narrower concept than one of those two elements. It is also used to define a set of elements in relation to a single element that is part of that set. I.e. "man and woman" is a variant of "woman", "golden apple" is a variant of "apple"."</para>
    /// labels<para>"has variant"</para></remarks>
    /// <seealso href="https://www.w3id.org/simulation/ontology/hasVariant">https://www.w3id.org/simulation/ontology/hasVariant</seealso>
    let hasVariant = Prefixed_Name(simu, "hasVariant") |> PrefixedName

    /// <summary>
    ///   <para>simu:healedRealityCounterpart</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A specific relationship that links a simulation (usually a Healing Simulation) to a reality counterpart of which a simulacrum is the symbolic cure."</para>
    /// labels<para>"Healed reality counterpart"</para></remarks>
    /// <seealso href="https://www.w3id.org/simulation/ontology/healedRealityCounterpart">https://www.w3id.org/simulation/ontology/healedRealityCounterpart</seealso>
    let healedRealityCounterpart =
        Prefixed_Name(simu, "healedRealityCounterpart") |> PrefixedName

    /// <summary>
    ///   <para>simu:isContextOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"inverse property of has context"</para>
    /// labels<para>"Is context of"</para></remarks>
    /// <seealso href="https://www.w3id.org/simulation/ontology/isContextOf">https://www.w3id.org/simulation/ontology/isContextOf</seealso>
    let isContextOf = Prefixed_Name(simu, "isContextOf") |> PrefixedName

    /// <summary>
    ///   <para>simu:isEasedRealityCounterpartOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Inverse property of eased reality counterpart"</para>
    /// labels<para>"Is eased reality counterpart of"</para></remarks>
    /// <seealso href="https://www.w3id.org/simulation/ontology/isEasedRealityCounterpartOf">https://www.w3id.org/simulation/ontology/isEasedRealityCounterpartOf</seealso>
    let isEasedRealityCounterpartOf =
        Prefixed_Name(simu, "isEasedRealityCounterpartOf") |> PrefixedName

    /// <summary>
    ///   <para>simu:isElicitedRealityCounterpartOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Inverse property of elicited reality counterpart"</para>
    /// labels<para>"Is elicited reality counterpart of"</para></remarks>
    /// <seealso href="https://www.w3id.org/simulation/ontology/isElicitedRealityCounterpartOf">https://www.w3id.org/simulation/ontology/isElicitedRealityCounterpartOf</seealso>
    let isElicitedRealityCounterpartOf =
        Prefixed_Name(simu, "isElicitedRealityCounterpartOf") |> PrefixedName

    /// <summary>
    ///   <para>simu:isHealedRealityCounterpartOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Inverse property of healed reality counterpart"</para>
    /// labels<para>"Is healed reality counterpart of"</para></remarks>
    /// <seealso href="https://www.w3id.org/simulation/ontology/isHealedRealityCounterpartOf">https://www.w3id.org/simulation/ontology/isHealedRealityCounterpartOf</seealso>
    let isHealedRealityCounterpartOf =
        Prefixed_Name(simu, "isHealedRealityCounterpartOf") |> PrefixedName

    /// <summary>
    ///   <para>simu:isPersonifiedVariantOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Inverse property of has personified variant"</para>
    /// labels<para>"Is personified variant of"</para></remarks>
    /// <seealso href="https://www.w3id.org/simulation/ontology/isPersonifiedVariantOf">https://www.w3id.org/simulation/ontology/isPersonifiedVariantOf</seealso>
    let isPersonifiedVariantOf =
        Prefixed_Name(simu, "isPersonifiedVariantOf") |> PrefixedName

    /// <summary>
    ///   <para>simu:isPreventedRealityCounterpartOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Inversed property of prevented reality counterpart"</para>
    /// labels<para>"Is prevented reality counterpart of"</para></remarks>
    /// <seealso href="https://www.w3id.org/simulation/ontology/isPreventedRealityCounterpartOf">https://www.w3id.org/simulation/ontology/isPreventedRealityCounterpartOf</seealso>
    let isPreventedRealityCounterpartOf =
        Prefixed_Name(simu, "isPreventedRealityCounterpartOf") |> PrefixedName

    /// <summary>
    ///   <para>simu:isRealityCounterpartOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Inversed property of has reality counterpart"</para>
    /// labels<para>"Is reality counterpart of"</para></remarks>
    /// <seealso href="https://www.w3id.org/simulation/ontology/isRealityCounterpartOf">https://www.w3id.org/simulation/ontology/isRealityCounterpartOf</seealso>
    let isRealityCounterpartOf =
        Prefixed_Name(simu, "isRealityCounterpartOf") |> PrefixedName

    /// <summary>
    ///   <para>simu:isRestoredRealityCounterpartOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Inverse property of restored reality counterpart"</para>
    /// labels<para>"Is restored reality counterpart of"</para></remarks>
    /// <seealso href="https://www.w3id.org/simulation/ontology/isRestoredRealityCounterpartOf">https://www.w3id.org/simulation/ontology/isRestoredRealityCounterpartOf</seealso>
    let isRestoredRealityCounterpartOf =
        Prefixed_Name(simu, "isRestoredRealityCounterpartOf") |> PrefixedName

    /// <summary>
    ///   <para>simu:isSimulacrumOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Inversed property of has simulacrum"</para>
    /// labels<para>"Is simulacrum of"</para></remarks>
    /// <seealso href="https://www.w3id.org/simulation/ontology/isSimulacrumOf">https://www.w3id.org/simulation/ontology/isSimulacrumOf</seealso>
    let isSimulacrumOf = Prefixed_Name(simu, "isSimulacrumOf") |> PrefixedName
    /// <summary>
    ///   <para>simu:isSourceOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Inverse property of has source"</para>
    /// labels<para>"Is source of"</para></remarks>
    /// <seealso href="https://www.w3id.org/simulation/ontology/isSourceOf">https://www.w3id.org/simulation/ontology/isSourceOf</seealso>
    let isSourceOf = Prefixed_Name(simu, "isSourceOf") |> PrefixedName
    /// <summary>
    ///   <para>simu:isSymbolicMeaningOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Inverse property of symbolic meaning"</para>
    /// labels<para>"Is symbolic meaning of"</para></remarks>
    /// <seealso href="https://www.w3id.org/simulation/ontology/isSymbolicMeaningOf">https://www.w3id.org/simulation/ontology/isSymbolicMeaningOf</seealso>
    let isSymbolicMeaningOf = Prefixed_Name(simu, "isSymbolicMeaningOf") |> PrefixedName
    /// <summary>
    ///   <para>simu:isVariantOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Inverse property of has variant"</para>
    /// labels<para>"Is variant of"</para></remarks>
    /// <seealso href="https://www.w3id.org/simulation/ontology/isVariantOf">https://www.w3id.org/simulation/ontology/isVariantOf</seealso>
    let isVariantOf = Prefixed_Name(simu, "isVariantOf") |> PrefixedName

    /// <summary>
    ///   <para>simu:preventedRealityCounterpart</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A specific relationship that links a simulation (usually a Protection Simulation) to a reality counterpart that is symbolically prevented by the simulacrum."</para>
    /// labels<para>"Prevented reality counterpart"</para></remarks>
    /// <seealso href="https://www.w3id.org/simulation/ontology/preventedRealityCounterpart">https://www.w3id.org/simulation/ontology/preventedRealityCounterpart</seealso>
    let preventedRealityCounterpart =
        Prefixed_Name(simu, "preventedRealityCounterpart") |> PrefixedName

    /// <summary>
    ///   <para>simu:restoredRealityCounterpart</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A specific relationship that links a simulation to a reality counterpart that is symbolically restored by the simulacrum. Like the red valerian (simulacrum), which, in flower language, is symbolically believed to restore strenght (restored reality counterpart)."</para>
    /// labels<para>"Restored reality counterpart"</para></remarks>
    /// <seealso href="https://www.w3id.org/simulation/ontology/restoredRealityCounterpart">https://www.w3id.org/simulation/ontology/restoredRealityCounterpart</seealso>
    let restoredRealityCounterpart =
        Prefixed_Name(simu, "restoredRealityCounterpart") |> PrefixedName

    /// <summary>
    ///   <para>simu:symbolicMeaning</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property is a chain property that links a simulacrum with its reality counterpart. This direct relationship does not consider neither the context or the source of the simulation"</para>
    /// labels<para>"Symbolic Meaning"</para></remarks>
    /// <seealso href="https://www.w3id.org/simulation/ontology/symbolicMeaning">https://www.w3id.org/simulation/ontology/symbolicMeaning</seealso>
    let symbolicMeaning = Prefixed_Name(simu, "symbolicMeaning") |> PrefixedName
