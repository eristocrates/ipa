namespace http.w3id.org.emmo_hpo.hpo.hash

open DoxAletheia

module hpo =
    let _namespace_name = "http://w3id.org/emmo-hpo/hpo#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// A polymer obtained through an addition reaction, that is, a reaction involving the creation of a single bond between the atoms of different molecules which are involved in a double or triple bond.
    /// <see href="http://w3id.org/emmo-hpo/hpo#AdditionPolymer"></see></summary>
    let AdditionPolymer = _prefix "AdditionPolymer"
    /// <summary>
    /// A term used for a large number of specialist chemicals which are added to compounds to impart specific properties.
    /// <see href="http://w3id.org/emmo-hpo/hpo#Additive"></see></summary>
    let Additive = _prefix "Additive"
    /// <summary>
    /// Intermediate mixture to make a formulation that allows formulated resin differentiation.
    /// <see href="http://w3id.org/emmo-hpo/hpo#ResinIngredient"></see></summary>
    let ResinIngredient = _prefix "ResinIngredient"
    /// <summary>
    /// A class of structures characterised by a branched skeleton.
    /// <see href="http://w3id.org/emmo-hpo/hpo#Branched"></see></summary>
    let Branched = _prefix "Branched"
    /// <summary>
    /// A 2-dimensional representation of chemical structures of organic compounds, showing the chemical bonds as lines, carbon atoms as vertices, and hetero atoms with labels. Hydrogen atoms are omitted in the representation since their presence can be derived from the valence of carbon atoms.
    /// <see href="http://w3id.org/emmo-hpo/hpo#SkeletalFormula"></see></summary>
    let SkeletalFormula = _prefix "SkeletalFormula"
    /// <summary>
    /// A polymer whose molecular structure is characterised by a regular or irregular attachment of side chains to the main backbone chain. .
    /// <see href="http://w3id.org/emmo-hpo/hpo#BranchedChainPolymer"></see></summary>
    let BranchedChainPolymer = _prefix "BranchedChainPolymer"
    /// <summary>
    /// Experimental procedure for resin reactivity measurement.
    /// <see href="http://w3id.org/emmo-hpo/hpo#COMPEVODSCAnalysis"></see></summary>
    let COMPEVODSCAnalysis = _prefix "COMPEVODSCAnalysis"
    /// <summary>
    /// A substance that increases the rate of a reaction without modifying the overall standard Gibbs energy change in the reaction.
    /// <see href="http://w3id.org/emmo-hpo/hpo#Catalyst"></see></summary>
    let Catalyst = _prefix "Catalyst"
    /// <summary>
    /// Catalyst suppliers trade name for the purchased catalyst formulation.
    /// <see href="http://w3id.org/emmo-hpo/hpo#CatalystCommercialName"></see></summary>
    let CatalystCommercialName = _prefix "CatalystCommercialName"
    /// <summary>
    ///   <see href="http://w3id.org/emmo-hpo/hpo#CatalystProperty"></see>
    /// </summary>
    let CatalystProperty = _prefix "CatalystProperty"
    /// <summary>
    /// Mass density of the catalyst.
    /// <see href="http://w3id.org/emmo-hpo/hpo#CatalystDensity"></see></summary>
    let CatalystDensity = _prefix "CatalystDensity"
    /// <summary>
    /// Average molecular weight of the catalyst molecular consituents.
    /// <see href="http://w3id.org/emmo-hpo/hpo#CatalystMolecularWeight"></see></summary>
    let CatalystMolecularWeight = _prefix "CatalystMolecularWeight"
    /// <summary>
    /// Catalyst viscosity at 25°C.
    /// <see href="http://w3id.org/emmo-hpo/hpo#CatalystViscosity"></see></summary>
    let CatalystViscosity = _prefix "CatalystViscosity"
    /// <summary>
    /// A polymer derived from the polymerisation of more than one species of monomer.
    /// <see href="http://w3id.org/emmo-hpo/hpo#CoPolymer"></see></summary>
    let CoPolymer = _prefix "CoPolymer"
    /// <summary>
    /// The manufacturing of a component made of a composite material.
    /// <see href="http://w3id.org/emmo-hpo/hpo#ComponentManufacturing"></see></summary>
    let ComponentManufacturing = _prefix "ComponentManufacturing"
    /// <summary>
    /// An arrangement of prepreg parts (ply) orientations and material components in a laminate specified with respect to some reference direction.
    /// <see href="http://w3id.org/emmo-hpo/hpo#Stacking"></see></summary>
    let Stacking = _prefix "Stacking"
    /// <summary>
    /// The process of shaping composite materials into a solid mass of prescribed shape and size, using a mold or tool.
    /// <see href="http://w3id.org/emmo-hpo/hpo#ShapingAndCuring"></see></summary>
    let ShapingAndCuring = _prefix "ShapingAndCuring"
    /// <summary>
    /// A manufacturing line processing a composite material into a component.
    /// <see href="http://w3id.org/emmo-hpo/hpo#ComponentManufacturingLine"></see></summary>
    let ComponentManufacturingLine = _prefix "ComponentManufacturingLine"
    /// <summary>
    /// A lubricant used to prevent a part from sticking to a mold surface.
    /// <see href="http://w3id.org/emmo-hpo/hpo#MouldReleaseLayer"></see></summary>
    let MouldReleaseLayer = _prefix "MouldReleaseLayer"
    /// <summary>
    /// The mold, either one- or two-sided and either open or closed, in or upon which composite material is placed in order to make a part.
    /// <see href="http://w3id.org/emmo-hpo/hpo#CoverTool"></see></summary>
    let CoverTool = _prefix "CoverTool"
    /// <summary>
    /// A manufacturing line is a set of sequential operations in a factory where materials are processed, assembled, and/or refined to produce a finished product or an intermediate product for further processing.
    /// <see href="http://w3id.org/emmo-hpo/hpo#ManufacturingLine"></see></summary>
    let ManufacturingLine = _prefix "ManufacturingLine"
    /// <summary>
    /// A release layer applied to a cover placed over the laminate.
    /// <see href="http://w3id.org/emmo-hpo/hpo#CoverReleaseLayer"></see></summary>
    let CoverReleaseLayer = _prefix "CoverReleaseLayer"
    /// <summary>
    /// An enclosed cavity or open form from which a composite component takes its shape, size and exterior surface appearance (also known as a tool).
    /// <see href="http://w3id.org/emmo-hpo/hpo#MouldTool"></see></summary>
    let MouldTool = _prefix "MouldTool"
    /// <summary>
    ///   <see href="http://w3id.org/emmo-hpo/hpo#ComponentManufacturingProperty"></see>
    /// </summary>
    let ComponentManufacturingProperty = _prefix "ComponentManufacturingProperty"
    /// <summary>
    /// A material made up of resin and reinforcement (usually fibre).
    /// <see href="http://w3id.org/emmo-hpo/hpo#Composite"></see></summary>
    let Composite = _prefix "Composite"
    /// <summary>
    ///   <see href="http://w3id.org/emmo-hpo/hpo#CompositeLaminate"></see>
    /// </summary>
    let CompositeLaminate = _prefix "CompositeLaminate"
    /// <summary>
    /// Arrangement of ply prepregs in a laminate.
    /// <see href="http://w3id.org/emmo-hpo/hpo#StackedPrepreg"></see></summary>
    let StackedPrepreg = _prefix "StackedPrepreg"
    /// <summary>
    /// The structure resulting from the curing of multiple stacked prepreg plies.
    /// <see href="http://w3id.org/emmo-hpo/hpo#Laminate"></see></summary>
    let Laminate = _prefix "Laminate"
    /// <summary>
    /// After performing a cross-cut perpendicular to the specimen surface, based on a light microscopy image, the apparent surface area fraction occupied by pores is evaluated.
    /// <see href="http://w3id.org/emmo-hpo/hpo#CompositeLaminateBulkPorosity"></see></summary>
    let CompositeLaminateBulkPorosity = _prefix "CompositeLaminateBulkPorosity"
    /// <summary>
    ///   <see href="http://w3id.org/emmo-hpo/hpo#CompositeLaminateProperty"></see>
    /// </summary>
    let CompositeLaminateProperty = _prefix "CompositeLaminateProperty"

    /// <summary>
    /// Based on a light microscopy image of the smoother surface (i.e. the one visible to a user) of the composite laminate, the apparent surface area fraction occupied by pores is evaluated.
    /// <see href="http://w3id.org/emmo-hpo/hpo#CompositeLaminateSurfaceRegionPorosity"></see></summary>
    let CompositeLaminateSurfaceRegionPorosity =
        _prefix "CompositeLaminateSurfaceRegionPorosity"

    /// <summary>
    /// Using a (set of) specimen illumination settings, the appearance is compared with the appearance of a specified set of (reference) specimens.
    /// <see href="http://w3id.org/emmo-hpo/hpo#CompositeLaminateVisualSurfaceFinish"></see></summary>
    let CompositeLaminateVisualSurfaceFinish =
        _prefix "CompositeLaminateVisualSurfaceFinish"

    /// <summary>
    /// A polymer obtained through a condensation reaction, that is, where two molecules form a chemical bond by eliminating a small molecule such as water.
    /// <see href="http://w3id.org/emmo-hpo/hpo#CondensationPolymer"></see></summary>
    let CondensationPolymer = _prefix "CondensationPolymer"
    /// <summary>
    /// A specially formulated material placed between the mold and uncured resin/fiber (usually sprayed or painted on the mold surface) to prevent permanent bonding between the two during cure and facilitates demolding after cure.
    /// <see href="http://w3id.org/emmo-hpo/hpo#ReleaseLayer"></see></summary>
    let ReleaseLayer = _prefix "ReleaseLayer"
    /// <summary>
    /// Commercial name of the applied consumable (product), differentiating available product providers and product lots.
    /// <see href="http://w3id.org/emmo-hpo/hpo#CoverReleaseLayerIdentifier"></see></summary>
    let CoverReleaseLayerIdentifier = _prefix "CoverReleaseLayerIdentifier"
    /// <summary>
    ///   <see href="http://w3id.org/emmo-hpo/hpo#CoverReleaseLayerProperty"></see>
    /// </summary>
    let CoverReleaseLayerProperty = _prefix "CoverReleaseLayerProperty"
    /// <summary>
    /// Average distance between holes.
    /// <see href="http://w3id.org/emmo-hpo/hpo#CoverToolHoleDistance"></see></summary>
    let CoverToolHoleDistance = _prefix "CoverToolHoleDistance"
    /// <summary>
    ///   <see href="http://w3id.org/emmo-hpo/hpo#CoverToolProperty"></see>
    /// </summary>
    let CoverToolProperty = _prefix "CoverToolProperty"
    /// <summary>
    /// Length (contributing to the size of the tool).
    /// <see href="http://w3id.org/emmo-hpo/hpo#CoverToolLength"></see></summary>
    let CoverToolLength = _prefix "CoverToolLength"
    /// <summary>
    /// Amount of holes.
    /// <see href="http://w3id.org/emmo-hpo/hpo#CoverToolNumberOfHoles"></see></summary>
    let CoverToolNumberOfHoles = _prefix "CoverToolNumberOfHoles"
    /// <summary>
    /// Average diameter of holes.
    /// <see href="http://w3id.org/emmo-hpo/hpo#CoverToolSizeOfHoles"></see></summary>
    let CoverToolSizeOfHoles = _prefix "CoverToolSizeOfHoles"
    /// <summary>
    /// Width (contributing to the size of the tool).
    /// <see href="http://w3id.org/emmo-hpo/hpo#CoverToolWidth"></see></summary>
    let CoverToolWidth = _prefix "CoverToolWidth"
    /// <summary>
    /// A class of structures characterised by a bond or a short sequence of bonds connecting different macromolecules.
    /// <see href="http://w3id.org/emmo-hpo/hpo#Crosslinked"></see></summary>
    let Crosslinked = _prefix "Crosslinked"
    /// <summary>
    /// A polymer whose molecular structure is characterised by additional covalent bonds connecting several chains together.
    /// <see href="http://w3id.org/emmo-hpo/hpo#CrosslinkedPolymer"></see></summary>
    let CrosslinkedPolymer = _prefix "CrosslinkedPolymer"
    /// <summary>
    /// Duration of the degassing.
    /// <see href="http://w3id.org/emmo-hpo/hpo#DegassingStepDuration"></see></summary>
    let DegassingStepDuration = _prefix "DegassingStepDuration"
    /// <summary>
    /// A polymer characterised by weak intermolecular forces and viscoelasticity.
    /// <see href="http://w3id.org/emmo-hpo/hpo#Elastomer"></see></summary>
    let Elastomer = _prefix "Elastomer"
    /// <summary>
    /// Ratio between increased length and initial length after breakage.
    /// <see href="http://w3id.org/emmo-hpo/hpo#ElongationAtBreak"></see></summary>
    let ElongationAtBreak = _prefix "ElongationAtBreak"
    /// <summary>
    /// A polymer characterised by strong intermolecular forces and high tensile strength.
    /// <see href="http://w3id.org/emmo-hpo/hpo#Fibre"></see></summary>
    let Fibre = _prefix "Fibre"
    /// <summary>
    /// Mass per unit volume of the facbric.
    /// <see href="http://w3id.org/emmo-hpo/hpo#FibreDensity"></see></summary>
    let FibreDensity = _prefix "FibreDensity"
    /// <summary>
    /// A collection of the properties of textile fabrics.
    /// <see href="http://w3id.org/emmo-hpo/hpo#TextileFabricProperty"></see></summary>
    let TextileFabricProperty = _prefix "TextileFabricProperty"
    /// <summary>
    /// Diameter of the fibre composing the fabric.
    /// <see href="http://w3id.org/emmo-hpo/hpo#FibreDiameter"></see></summary>
    let FibreDiameter = _prefix "FibreDiameter"
    /// <summary>
    /// Commercial name of the applied consumable (product), differentiating available product providers and product lots.
    /// <see href="http://w3id.org/emmo-hpo/hpo#FibreIdentifier"></see></summary>
    let FibreIdentifier = _prefix "FibreIdentifier"
    /// <summary>
    /// Ratio between the volume of fibre and the volume of the composite laminate.
    /// <see href="http://w3id.org/emmo-hpo/hpo#FibreVolumeContent"></see></summary>
    let FibreVolumeContent = _prefix "FibreVolumeContent"
    /// <summary>
    /// A material (usually low cost) added to a resin to extend it, or give special properties
    /// <see href="http://w3id.org/emmo-hpo/hpo#Filler"></see></summary>
    let Filler = _prefix "Filler"
    /// <summary>
    /// Final pressure of the container during step.
    /// <see href="http://w3id.org/emmo-hpo/hpo#FinalStepPressure"></see></summary>
    let FinalStepPressure = _prefix "FinalStepPressure"
    /// <summary>
    /// Final temperature of the container during step.
    /// <see href="http://w3id.org/emmo-hpo/hpo#FinalStepTemperature"></see></summary>
    let FinalStepTemperature = _prefix "FinalStepTemperature"
    /// <summary>
    /// Tangent of the stress-strain curve under flexural stress.
    /// <see href="http://w3id.org/emmo-hpo/hpo#FlexualModulus"></see></summary>
    let FlexualModulus = _prefix "FlexualModulus"
    /// <summary>
    /// Maximum value of the stress-strain curve under flexural stress.
    /// <see href="http://w3id.org/emmo-hpo/hpo#FlexuralStrength"></see></summary>
    let FlexuralStrength = _prefix "FlexuralStrength"
    /// <summary>
    /// A manufactured mixture of a resin and ingredients.
    /// <see href="http://w3id.org/emmo-hpo/hpo#FormulatedResin"></see></summary>
    let FormulatedResin = _prefix "FormulatedResin"
    /// <summary>
    /// Soft solid or highly viscous substance, usually containing prepolymers with reactive groups.
    /// <see href="http://w3id.org/emmo-hpo/hpo#Resin"></see></summary>
    let Resin = _prefix "Resin"
    /// <summary>
    /// Temperature required to start the process of cure of the resin.
    /// <see href="http://w3id.org/emmo-hpo/hpo#FormulatedResinCuringTemperature"></see></summary>
    let FormulatedResinCuringTemperature = _prefix "FormulatedResinCuringTemperature"
    /// <summary>
    /// A collection of the properties of formulated resins.
    /// <see href="http://w3id.org/emmo-hpo/hpo#FormulatedResinProperty"></see></summary>
    let FormulatedResinProperty = _prefix "FormulatedResinProperty"
    /// <summary>
    /// Time at which the curing temperature must be held to achieve a certain level of cure.
    /// <see href="http://w3id.org/emmo-hpo/hpo#FormulatedResinCuringTime"></see></summary>
    let FormulatedResinCuringTime = _prefix "FormulatedResinCuringTime"

    /// <summary>
    /// Process in which a polymer melt changes on cooling to a polymer glass or a polymer glass changes on heating to a polymer melt.
    /// <see href="http://w3id.org/emmo-hpo/hpo#FormulatedResinGlassTransitionTemperature"></see></summary>
    let FormulatedResinGlassTransitionTemperature =
        _prefix "FormulatedResinGlassTransitionTemperature"

    /// <summary>
    /// Mass of water released per mass of resin throughout the applied chemical (curing) reaction.
    /// <see href="http://w3id.org/emmo-hpo/hpo#FormulatedResinSpecificCondensateFormation"></see></summary>
    let FormulatedResinSpecificCondensateFormation =
        _prefix "FormulatedResinSpecificCondensateFormation"

    /// <summary>
    /// Dynamic viscosity of the resin.
    /// <see href="http://w3id.org/emmo-hpo/hpo#FormulatedResinViscosity"></see></summary>
    let FormulatedResinViscosity = _prefix "FormulatedResinViscosity"
    /// <summary>
    /// Weight percentage of (dissolved and freezable) water in the base resin.
    /// <see href="http://w3id.org/emmo-hpo/hpo#FormulatedResinWaterContent"></see></summary>
    let FormulatedResinWaterContent = _prefix "FormulatedResinWaterContent"
    /// <summary>
    /// Temperature for transition from glassy state into a viscous one.
    /// <see href="http://w3id.org/emmo-hpo/hpo#GlassTransitionTemperature"></see></summary>
    let GlassTransitionTemperature = _prefix "GlassTransitionTemperature"
    /// <summary>
    /// Heating rate during step.
    /// <see href="http://w3id.org/emmo-hpo/hpo#HeatingRateDuringStep"></see></summary>
    let HeatingRateDuringStep = _prefix "HeatingRateDuringStep"
    /// <summary>
    /// A polymer derived from the polymerisation of one kind of monomer.
    /// <see href="http://w3id.org/emmo-hpo/hpo#HomoPolymer"></see></summary>
    let HomoPolymer = _prefix "HomoPolymer"
    /// <summary>
    /// Pressure during step.
    /// <see href="http://w3id.org/emmo-hpo/hpo#InitialStepPressure"></see></summary>
    let InitialStepPressure = _prefix "InitialStepPressure"
    /// <summary>
    /// Initial temperature of the container during step.
    /// <see href="http://w3id.org/emmo-hpo/hpo#InitialStepTemperature"></see></summary>
    let InitialStepTemperature = _prefix "InitialStepTemperature"
    /// <summary>
    /// Mechanical property associated with the matrix-fibre interaction.
    /// <see href="http://w3id.org/emmo-hpo/hpo#InterlaminarShearStrength"></see></summary>
    let InterlaminarShearStrength = _prefix "InterlaminarShearStrength"
    /// <summary>
    /// A class of structures characterised by a linear skeleton.
    /// <see href="http://w3id.org/emmo-hpo/hpo#Linear"></see></summary>
    let Linear = _prefix "Linear"
    /// <summary>
    /// A polymer whose molecular structure is characterised by a linear chain of repeating units.
    /// <see href="http://w3id.org/emmo-hpo/hpo#LinearPolymer"></see></summary>
    let LinearPolymer = _prefix "LinearPolymer"
    /// <summary>
    /// A single molecule that reacts with like or unlike molecules to form a polymer.
    /// <see href="http://w3id.org/emmo-hpo/hpo#Monomer"></see></summary>
    let Monomer = _prefix "Monomer"
    /// <summary>
    /// Commercial name of the applied consumable (product), differentiating available product providers and product lots.
    /// <see href="http://w3id.org/emmo-hpo/hpo#MouldReleaseLayerIdentifier"></see></summary>
    let MouldReleaseLayerIdentifier = _prefix "MouldReleaseLayerIdentifier"
    /// <summary>
    /// A collection of the properties of the release layer of a mould or tool.
    /// <see href="http://w3id.org/emmo-hpo/hpo#MouldReleaseLayerProperty"></see></summary>
    let MouldReleaseLayerProperty = _prefix "MouldReleaseLayerProperty"
    /// <summary>
    /// Length (contributing to the size of the tool).
    /// <see href="http://w3id.org/emmo-hpo/hpo#MouldToolLength"></see></summary>
    let MouldToolLength = _prefix "MouldToolLength"
    /// <summary>
    /// A collection of the properties of moulds or tools.
    /// <see href="http://w3id.org/emmo-hpo/hpo#MouldToolProperty"></see></summary>
    let MouldToolProperty = _prefix "MouldToolProperty"
    /// <summary>
    /// Arithmetic average of the absolute values of the profile height deviations from the mean line, recorded within the evaluation length.
    /// <see href="http://w3id.org/emmo-hpo/hpo#MouldToolSurfaceRoughness"></see></summary>
    let MouldToolSurfaceRoughness = _prefix "MouldToolSurfaceRoughness"
    /// <summary>
    /// Width (contributing to the size of the tool).
    /// <see href="http://w3id.org/emmo-hpo/hpo#MouldToolWidth"></see></summary>
    let MouldToolWidth = _prefix "MouldToolWidth"
    /// <summary>
    /// A naturally occurring polymer produced by living organisms.
    /// <see href="http://w3id.org/emmo-hpo/hpo#NaturalPolymer"></see></summary>
    let NaturalPolymer = _prefix "NaturalPolymer"
    /// <summary>
    /// Parts manufactured per minute.
    /// <see href="http://w3id.org/emmo-hpo/hpo#PartsTurnover"></see></summary>
    let PartsTurnover = _prefix "PartsTurnover"
    /// <summary>
    /// After cutting a test sample out of the specimen to be tested, gravimetric and volumetric findings are used to calculate an (average) density that is compared to the density of a qualified (reference) “in order (i.o.)” specimen.
    /// <see href="http://w3id.org/emmo-hpo/hpo#PorosityInferredFromDensity"></see></summary>
    let PorosityInferredFromDensity = _prefix "PorosityInferredFromDensity"
    /// <summary>
    /// A factory-made combination of reactive resins and reinforcing fibres, plus other necessary additive chemicals, ready to be moulded.
    /// <see href="http://w3id.org/emmo-hpo/hpo#Prepreg"></see></summary>
    let Prepreg = _prefix "Prepreg"
    /// <summary>
    /// Percentage of the (feasible) curing (that is no more available for cross-linking reaction(s))
    /// <see href="http://w3id.org/emmo-hpo/hpo#PrepregCuringDegree"></see></summary>
    let PrepregCuringDegree = _prefix "PrepregCuringDegree"
    /// <summary>
    /// A collection of the properties of prepregs.
    /// <see href="http://w3id.org/emmo-hpo/hpo#PrepregProperty"></see></summary>
    let PrepregProperty = _prefix "PrepregProperty"
    /// <summary>
    /// Mass per unit volume of the prepreg.
    /// <see href="http://w3id.org/emmo-hpo/hpo#PrepregDensity"></see></summary>
    let PrepregDensity = _prefix "PrepregDensity"
    /// <summary>
    /// EXPECTED ratio between increased length and initial length after breakage AFTER CURING.
    /// <see href="http://w3id.org/emmo-hpo/hpo#PrepregExpectedElongationAtBreak"></see></summary>
    let PrepregExpectedElongationAtBreak = _prefix "PrepregExpectedElongationAtBreak"
    /// <summary>
    /// EXPECTED Tangent of the stress-strain curve under flexural stress AFTER CURING.
    /// <see href="http://w3id.org/emmo-hpo/hpo#PrepregExpectedFlexualModulus"></see></summary>
    let PrepregExpectedFlexualModulus = _prefix "PrepregExpectedFlexualModulus"
    /// <summary>
    /// EXPECTED Maximum value of the stress-strain curve under flexural stress AFTER CURING.
    /// <see href="http://w3id.org/emmo-hpo/hpo#PrepregExpectedFlexuralStrength"></see></summary>
    let PrepregExpectedFlexuralStrength = _prefix "PrepregExpectedFlexuralStrength"
    /// <summary>
    /// EXPECTED Tangent of the stress-strain curve under tensile stress AFTER CURING.
    /// <see href="http://w3id.org/emmo-hpo/hpo#PrepregExpectedTensileModulus"></see></summary>
    let PrepregExpectedTensileModulus = _prefix "PrepregExpectedTensileModulus"
    /// <summary>
    /// EXPECTED Maximum value of the stress-strain curve under tensile stress AFTER CURING.
    /// <see href="http://w3id.org/emmo-hpo/hpo#PrepregExpectedTensileStrength"></see></summary>
    let PrepregExpectedTensileStrength = _prefix "PrepregExpectedTensileStrength"
    /// <summary>
    /// Ratio between the volume of fibre and the volume of the composite.
    /// <see href="http://w3id.org/emmo-hpo/hpo#PrepregFibreVolumeContent"></see></summary>
    let PrepregFibreVolumeContent = _prefix "PrepregFibreVolumeContent"
    /// <summary>
    /// Characteristic temperature (range) of the process in which a polymer melt changes on cooling to a polymer glass or a polymer glass changes on heating to a polymer melt.
    /// <see href="http://w3id.org/emmo-hpo/hpo#PrepregGlassTransitionTemperature"></see></summary>
    let PrepregGlassTransitionTemperature = _prefix "PrepregGlassTransitionTemperature"
    /// <summary>
    /// A manufacturing line processing a prepreg for later use.
    /// <see href="http://w3id.org/emmo-hpo/hpo#PrepregLine"></see></summary>
    let PrepregLine = _prefix "PrepregLine"
    /// <summary>
    /// A prepreg a piece cut from a prepreg roll, which can be stacked.
    /// <see href="http://w3id.org/emmo-hpo/hpo#PrepregPiece"></see></summary>
    let PrepregPiece = _prefix "PrepregPiece"
    /// <summary>
    /// A roll of prepreg material.
    /// <see href="http://w3id.org/emmo-hpo/hpo#PrepregRoll"></see></summary>
    let PrepregRoll = _prefix "PrepregRoll"
    /// <summary>
    /// A planar textile constructed with fibres (or yarns), which can be either woven (interlaced using a weaving process) or non-woven (not interlaced).
    /// <see href="http://w3id.org/emmo-hpo/hpo#TextileFabric"></see></summary>
    let TextileFabric = _prefix "TextileFabric"

    /// <summary>
    /// Mass of water released per mass of prepreg throughout the applied chemical (curing) reaction.
    /// <see href="http://w3id.org/emmo-hpo/hpo#PrepregSpecificCondensateFormation"></see></summary>
    let PrepregSpecificCondensateFormation =
        _prefix "PrepregSpecificCondensateFormation"

    /// <summary>
    /// Thickness of the prepreg.
    /// <see href="http://w3id.org/emmo-hpo/hpo#PrepregThickness"></see></summary>
    let PrepregThickness = _prefix "PrepregThickness"
    /// <summary>
    /// Weight percentage of water in the prepreg (that can be dried and is not formed during the curing reaction).
    /// <see href="http://w3id.org/emmo-hpo/hpo#PrepregWaterContent"></see></summary>
    let PrepregWaterContent = _prefix "PrepregWaterContent"
    /// <summary>
    /// Effective and anisotropic proportionality constant between the molar (or mass) flux due to molecular diffusion (out of the prepreg specimen).
    /// <see href="http://w3id.org/emmo-hpo/hpo#PrepregWaterDiffusionCoefficient"></see></summary>
    let PrepregWaterDiffusionCoefficient = _prefix "PrepregWaterDiffusionCoefficient"
    /// <summary>
    /// Width of the prepreg.
    /// <see href="http://w3id.org/emmo-hpo/hpo#PrepregWidth"></see></summary>
    let PrepregWidth = _prefix "PrepregWidth"
    /// <summary>
    /// The process of prepreg manufacturing.
    /// <see href="http://w3id.org/emmo-hpo/hpo#Prepregging"></see></summary>
    let Prepregging = _prefix "Prepregging"
    /// <summary>
    /// A polymer that becomes irreversibly hard by creating an extensive network of cross-linking between the individual chains.
    /// <see href="http://w3id.org/emmo-hpo/hpo#ThermosettingPolymer"></see></summary>
    let ThermosettingPolymer = _prefix "ThermosettingPolymer"
    /// <summary>
    /// Total composition of the resin.
    /// <see href="http://w3id.org/emmo-hpo/hpo#ResinComposition"></see></summary>
    let ResinComposition = _prefix "ResinComposition"
    /// <summary>
    /// A collection of the properties of resins.
    /// <see href="http://w3id.org/emmo-hpo/hpo#ResinProperty"></see></summary>
    let ResinProperty = _prefix "ResinProperty"
    /// <summary>
    /// Mass density of the resin.
    /// <see href="http://w3id.org/emmo-hpo/hpo#ResinDensity"></see></summary>
    let ResinDensity = _prefix "ResinDensity"
    /// <summary>
    /// A batch resin mixer.
    /// <see href="http://w3id.org/emmo-hpo/hpo#ResinMixer"></see></summary>
    let ResinMixer = _prefix "ResinMixer"
    /// <summary>
    /// Average molecular weight of the main resin molecular consituents.
    /// <see href="http://w3id.org/emmo-hpo/hpo#ResinMolecularWeight"></see></summary>
    let ResinMolecularWeight = _prefix "ResinMolecularWeight"
    /// <summary>
    /// Preparing a resin involves mixing the precursor (monomers) with a hardener or a catalyst, fillers, and additives.
    /// <see href="http://w3id.org/emmo-hpo/hpo#ResinPreparation"></see></summary>
    let ResinPreparation = _prefix "ResinPreparation"
    /// <summary>
    /// Maximum amount of energy released in case of complete conversion.
    /// <see href="http://w3id.org/emmo-hpo/hpo#ResinReactivity"></see></summary>
    let ResinReactivity = _prefix "ResinReactivity"
    /// <summary>
    /// Viscosity at 25°C.
    /// <see href="http://w3id.org/emmo-hpo/hpo#ResinViscosity"></see></summary>
    let ResinViscosity = _prefix "ResinViscosity"
    /// <summary>
    /// Percentage of water in the base resin.
    /// <see href="http://w3id.org/emmo-hpo/hpo#ResinWaterContent"></see></summary>
    let ResinWaterContent = _prefix "ResinWaterContent"
    /// <summary>
    /// pH of the resin.
    /// <see href="http://w3id.org/emmo-hpo/hpo#ResinpH"></see></summary>
    let ResinpH = _prefix "ResinpH"
    /// <summary>
    /// A polymer synthesised from biomass sources.
    /// <see href="http://w3id.org/emmo-hpo/hpo#SemiSyntheticPolymer"></see></summary>
    let SemiSyntheticPolymer = _prefix "SemiSyntheticPolymer"
    /// <summary>
    /// Length (contributing to the size of the object).
    /// <see href="http://w3id.org/emmo-hpo/hpo#StackedPrepregLength"></see></summary>
    let StackedPrepregLength = _prefix "StackedPrepregLength"
    /// <summary>
    /// A collection of the properties of stacked prepregs.
    /// <see href="http://w3id.org/emmo-hpo/hpo#StackedPrepregProperty"></see></summary>
    let StackedPrepregProperty = _prefix "StackedPrepregProperty"
    /// <summary>
    /// Sum of the thicknesses of prepreg layer.
    /// <see href="http://w3id.org/emmo-hpo/hpo#StackedPrepregNominalThickness"></see></summary>
    let StackedPrepregNominalThickness = _prefix "StackedPrepregNominalThickness"
    /// <summary>
    /// Number of stacked prepreg layers
    /// <see href="http://w3id.org/emmo-hpo/hpo#StackedPrepregNumberOfLayers"></see></summary>
    let StackedPrepregNumberOfLayers = _prefix "StackedPrepregNumberOfLayers"
    /// <summary>
    /// List of the orientation (degreees) of each prepreg layer.
    /// <see href="http://w3id.org/emmo-hpo/hpo#StackedPrepregStackingSequence"></see></summary>
    let StackedPrepregStackingSequence = _prefix "StackedPrepregStackingSequence"
    /// <summary>
    /// Width (contributing to the size of the object).
    /// <see href="http://w3id.org/emmo-hpo/hpo#StackedPrepregWidth"></see></summary>
    let StackedPrepregWidth = _prefix "StackedPrepregWidth"
    /// <summary>
    /// Step duration
    /// <see href="http://w3id.org/emmo-hpo/hpo#StepDuration"></see></summary>
    let StepDuration = _prefix "StepDuration"
    /// <summary>
    /// The storage modulus in viscoelastic materials measure the stored energy representing the elastic portion.
    /// <see href="http://w3id.org/emmo-hpo/hpo#StorageModulus"></see></summary>
    let StorageModulus = _prefix "StorageModulus"
    /// <summary>
    /// A polymer synthesised from other manufactured chemicals.
    /// <see href="http://w3id.org/emmo-hpo/hpo#SyntheticPolymer"></see></summary>
    let SyntheticPolymer = _prefix "SyntheticPolymer"
    /// <summary>
    /// Tangent of the stress-strain curve under tensile stress.
    /// <see href="http://w3id.org/emmo-hpo/hpo#TensileModulus"></see></summary>
    let TensileModulus = _prefix "TensileModulus"
    /// <summary>
    /// Maximum value of the stress-strain curve under tensile stress.
    /// <see href="http://w3id.org/emmo-hpo/hpo#TensileStrength"></see></summary>
    let TensileStrength = _prefix "TensileStrength"
    /// <summary>
    /// Textile fabric thickness
    /// <see href="http://w3id.org/emmo-hpo/hpo#TextileFabricThickness"></see></summary>
    let TextileFabricThickness = _prefix "TextileFabricThickness"
    /// <summary>
    /// Pattern of fibre weaving.
    /// <see href="http://w3id.org/emmo-hpo/hpo#TextileFabricWeaveStyle"></see></summary>
    let TextileFabricWeaveStyle = _prefix "TextileFabricWeaveStyle"
    /// <summary>
    /// Width of the fabric.
    /// <see href="http://w3id.org/emmo-hpo/hpo#TextileFabricWidth"></see></summary>
    let TextileFabricWidth = _prefix "TextileFabricWidth"
    /// <summary>
    /// A polymer that becomes pliable and mouldable (i.e. plastic) above a certain temperature, and that reversibly solidifies upon cooling. Thermoplastics typically have linear chains and high molecular weight, increasing the strength of intermolecular interactions.
    /// <see href="http://w3id.org/emmo-hpo/hpo#ThermoplasticPolymer"></see></summary>
    let ThermoplasticPolymer = _prefix "ThermoplasticPolymer"
    /// <summary>
    /// Solvents, such as water and alcohol, in a sizing or resin formulation that can be vaporized at ambient or slightly elevated temperatures.
    /// <see href="http://w3id.org/emmo-hpo/hpo#Volatile"></see></summary>
    let Volatile = _prefix "Volatile"
    /// <summary>
    /// List of steps for the mixing process.
    /// <see href="http://w3id.org/emmo-hpo/hpo#WorkingStepsOrder"></see></summary>
    let WorkingStepsOrder = _prefix "WorkingStepsOrder"
