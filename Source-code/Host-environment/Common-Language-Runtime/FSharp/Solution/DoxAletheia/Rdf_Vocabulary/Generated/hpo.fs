namespace http.w3id.org.emmo_hpo.hpo.hash

open DoxAletheia.Rdf_Vocabulary

module hpo =
    let _namespace_name = "http://w3id.org/emmo-hpo/hpo#"

    /// <summary>
    /// A polymer obtained through an addition reaction, that is, a reaction involving the creation of a single bond between the atoms of different molecules which are involved in a double or triple bond.
    /// <see href="http://w3id.org/emmo-hpo/hpo#AdditionPolymer"></see></summary>
    let AdditionPolymer =
        Namespaced_IRI.parse _namespace_name "AdditionPolymer" |> NamespacedName

    /// <summary>
    /// A term used for a large number of specialist chemicals which are added to compounds to impart specific properties.
    /// <see href="http://w3id.org/emmo-hpo/hpo#Additive"></see></summary>
    let Additive = Namespaced_IRI.parse _namespace_name "Additive" |> NamespacedName

    /// <summary>
    /// Intermediate mixture to make a formulation that allows formulated resin differentiation.
    /// <see href="http://w3id.org/emmo-hpo/hpo#ResinIngredient"></see></summary>
    let ResinIngredient =
        Namespaced_IRI.parse _namespace_name "ResinIngredient" |> NamespacedName

    /// <summary>
    /// A class of structures characterised by a branched skeleton.
    /// <see href="http://w3id.org/emmo-hpo/hpo#Branched"></see></summary>
    let Branched = Namespaced_IRI.parse _namespace_name "Branched" |> NamespacedName

    /// <summary>
    /// A 2-dimensional representation of chemical structures of organic compounds, showing the chemical bonds as lines, carbon atoms as vertices, and hetero atoms with labels. Hydrogen atoms are omitted in the representation since their presence can be derived from the valence of carbon atoms.
    /// <see href="http://w3id.org/emmo-hpo/hpo#SkeletalFormula"></see></summary>
    let SkeletalFormula =
        Namespaced_IRI.parse _namespace_name "SkeletalFormula" |> NamespacedName

    /// <summary>
    /// A polymer whose molecular structure is characterised by a regular or irregular attachment of side chains to the main backbone chain. .
    /// <see href="http://w3id.org/emmo-hpo/hpo#BranchedChainPolymer"></see></summary>
    let BranchedChainPolymer =
        Namespaced_IRI.parse _namespace_name "BranchedChainPolymer" |> NamespacedName

    /// <summary>
    /// Experimental procedure for resin reactivity measurement.
    /// <see href="http://w3id.org/emmo-hpo/hpo#COMPEVODSCAnalysis"></see></summary>
    let COMPEVODSCAnalysis =
        Namespaced_IRI.parse _namespace_name "COMPEVODSCAnalysis" |> NamespacedName

    /// <summary>
    /// A substance that increases the rate of a reaction without modifying the overall standard Gibbs energy change in the reaction.
    /// <see href="http://w3id.org/emmo-hpo/hpo#Catalyst"></see></summary>
    let Catalyst = Namespaced_IRI.parse _namespace_name "Catalyst" |> NamespacedName

    /// <summary>
    /// Catalyst suppliers trade name for the purchased catalyst formulation.
    /// <see href="http://w3id.org/emmo-hpo/hpo#CatalystCommercialName"></see></summary>
    let CatalystCommercialName =
        Namespaced_IRI.parse _namespace_name "CatalystCommercialName" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/emmo-hpo/hpo#CatalystProperty"></see>
    /// </summary>
    let CatalystProperty =
        Namespaced_IRI.parse _namespace_name "CatalystProperty" |> NamespacedName

    /// <summary>
    /// Mass density of the catalyst.
    /// <see href="http://w3id.org/emmo-hpo/hpo#CatalystDensity"></see></summary>
    let CatalystDensity =
        Namespaced_IRI.parse _namespace_name "CatalystDensity" |> NamespacedName

    /// <summary>
    /// Average molecular weight of the catalyst molecular consituents.
    /// <see href="http://w3id.org/emmo-hpo/hpo#CatalystMolecularWeight"></see></summary>
    let CatalystMolecularWeight =
        Namespaced_IRI.parse _namespace_name "CatalystMolecularWeight" |> NamespacedName

    /// <summary>
    /// Catalyst viscosity at 25°C.
    /// <see href="http://w3id.org/emmo-hpo/hpo#CatalystViscosity"></see></summary>
    let CatalystViscosity =
        Namespaced_IRI.parse _namespace_name "CatalystViscosity" |> NamespacedName

    /// <summary>
    /// A polymer derived from the polymerisation of more than one species of monomer.
    /// <see href="http://w3id.org/emmo-hpo/hpo#CoPolymer"></see></summary>
    let CoPolymer = Namespaced_IRI.parse _namespace_name "CoPolymer" |> NamespacedName

    /// <summary>
    /// The manufacturing of a component made of a composite material.
    /// <see href="http://w3id.org/emmo-hpo/hpo#ComponentManufacturing"></see></summary>
    let ComponentManufacturing =
        Namespaced_IRI.parse _namespace_name "ComponentManufacturing" |> NamespacedName

    /// <summary>
    /// An arrangement of prepreg parts (ply) orientations and material components in a laminate specified with respect to some reference direction.
    /// <see href="http://w3id.org/emmo-hpo/hpo#Stacking"></see></summary>
    let Stacking = Namespaced_IRI.parse _namespace_name "Stacking" |> NamespacedName

    /// <summary>
    /// The process of shaping composite materials into a solid mass of prescribed shape and size, using a mold or tool.
    /// <see href="http://w3id.org/emmo-hpo/hpo#ShapingAndCuring"></see></summary>
    let ShapingAndCuring =
        Namespaced_IRI.parse _namespace_name "ShapingAndCuring" |> NamespacedName

    /// <summary>
    /// A manufacturing line processing a composite material into a component.
    /// <see href="http://w3id.org/emmo-hpo/hpo#ComponentManufacturingLine"></see></summary>
    let ComponentManufacturingLine =
        Namespaced_IRI.parse _namespace_name "ComponentManufacturingLine" |> NamespacedName

    /// <summary>
    /// A lubricant used to prevent a part from sticking to a mold surface.
    /// <see href="http://w3id.org/emmo-hpo/hpo#MouldReleaseLayer"></see></summary>
    let MouldReleaseLayer =
        Namespaced_IRI.parse _namespace_name "MouldReleaseLayer" |> NamespacedName

    /// <summary>
    /// The mold, either one- or two-sided and either open or closed, in or upon which composite material is placed in order to make a part.
    /// <see href="http://w3id.org/emmo-hpo/hpo#CoverTool"></see></summary>
    let CoverTool = Namespaced_IRI.parse _namespace_name "CoverTool" |> NamespacedName

    /// <summary>
    /// A manufacturing line is a set of sequential operations in a factory where materials are processed, assembled, and/or refined to produce a finished product or an intermediate product for further processing.
    /// <see href="http://w3id.org/emmo-hpo/hpo#ManufacturingLine"></see></summary>
    let ManufacturingLine =
        Namespaced_IRI.parse _namespace_name "ManufacturingLine" |> NamespacedName

    /// <summary>
    /// A release layer applied to a cover placed over the laminate.
    /// <see href="http://w3id.org/emmo-hpo/hpo#CoverReleaseLayer"></see></summary>
    let CoverReleaseLayer =
        Namespaced_IRI.parse _namespace_name "CoverReleaseLayer" |> NamespacedName

    /// <summary>
    /// An enclosed cavity or open form from which a composite component takes its shape, size and exterior surface appearance (also known as a tool).
    /// <see href="http://w3id.org/emmo-hpo/hpo#MouldTool"></see></summary>
    let MouldTool = Namespaced_IRI.parse _namespace_name "MouldTool" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/emmo-hpo/hpo#ComponentManufacturingProperty"></see>
    /// </summary>
    let ComponentManufacturingProperty =
        Namespaced_IRI.parse _namespace_name "ComponentManufacturingProperty" |> NamespacedName

    /// <summary>
    /// A material made up of resin and reinforcement (usually fibre).
    /// <see href="http://w3id.org/emmo-hpo/hpo#Composite"></see></summary>
    let Composite = Namespaced_IRI.parse _namespace_name "Composite" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/emmo-hpo/hpo#CompositeLaminate"></see>
    /// </summary>
    let CompositeLaminate =
        Namespaced_IRI.parse _namespace_name "CompositeLaminate" |> NamespacedName

    /// <summary>
    /// Arrangement of ply prepregs in a laminate.
    /// <see href="http://w3id.org/emmo-hpo/hpo#StackedPrepreg"></see></summary>
    let StackedPrepreg =
        Namespaced_IRI.parse _namespace_name "StackedPrepreg" |> NamespacedName

    /// <summary>
    /// The structure resulting from the curing of multiple stacked prepreg plies.
    /// <see href="http://w3id.org/emmo-hpo/hpo#Laminate"></see></summary>
    let Laminate = Namespaced_IRI.parse _namespace_name "Laminate" |> NamespacedName

    /// <summary>
    /// After performing a cross-cut perpendicular to the specimen surface, based on a light microscopy image, the apparent surface area fraction occupied by pores is evaluated.
    /// <see href="http://w3id.org/emmo-hpo/hpo#CompositeLaminateBulkPorosity"></see></summary>
    let CompositeLaminateBulkPorosity =
        Namespaced_IRI.parse _namespace_name "CompositeLaminateBulkPorosity" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/emmo-hpo/hpo#CompositeLaminateProperty"></see>
    /// </summary>
    let CompositeLaminateProperty =
        Namespaced_IRI.parse _namespace_name "CompositeLaminateProperty" |> NamespacedName

    /// <summary>
    /// Based on a light microscopy image of the smoother surface (i.e. the one visible to a user) of the composite laminate, the apparent surface area fraction occupied by pores is evaluated.
    /// <see href="http://w3id.org/emmo-hpo/hpo#CompositeLaminateSurfaceRegionPorosity"></see></summary>
    let CompositeLaminateSurfaceRegionPorosity =
        Namespaced_IRI.parse _namespace_name "CompositeLaminateSurfaceRegionPorosity" |> NamespacedName

    /// <summary>
    /// Using a (set of) specimen illumination settings, the appearance is compared with the appearance of a specified set of (reference) specimens.
    /// <see href="http://w3id.org/emmo-hpo/hpo#CompositeLaminateVisualSurfaceFinish"></see></summary>
    let CompositeLaminateVisualSurfaceFinish =
        Namespaced_IRI.parse _namespace_name "CompositeLaminateVisualSurfaceFinish" |> NamespacedName

    /// <summary>
    /// A polymer obtained through a condensation reaction, that is, where two molecules form a chemical bond by eliminating a small molecule such as water.
    /// <see href="http://w3id.org/emmo-hpo/hpo#CondensationPolymer"></see></summary>
    let CondensationPolymer =
        Namespaced_IRI.parse _namespace_name "CondensationPolymer" |> NamespacedName

    /// <summary>
    /// A specially formulated material placed between the mold and uncured resin/fiber (usually sprayed or painted on the mold surface) to prevent permanent bonding between the two during cure and facilitates demolding after cure.
    /// <see href="http://w3id.org/emmo-hpo/hpo#ReleaseLayer"></see></summary>
    let ReleaseLayer =
        Namespaced_IRI.parse _namespace_name "ReleaseLayer" |> NamespacedName

    /// <summary>
    /// Commercial name of the applied consumable (product), differentiating available product providers and product lots.
    /// <see href="http://w3id.org/emmo-hpo/hpo#CoverReleaseLayerIdentifier"></see></summary>
    let CoverReleaseLayerIdentifier =
        Namespaced_IRI.parse _namespace_name "CoverReleaseLayerIdentifier" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/emmo-hpo/hpo#CoverReleaseLayerProperty"></see>
    /// </summary>
    let CoverReleaseLayerProperty =
        Namespaced_IRI.parse _namespace_name "CoverReleaseLayerProperty" |> NamespacedName

    /// <summary>
    /// Average distance between holes.
    /// <see href="http://w3id.org/emmo-hpo/hpo#CoverToolHoleDistance"></see></summary>
    let CoverToolHoleDistance =
        Namespaced_IRI.parse _namespace_name "CoverToolHoleDistance" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/emmo-hpo/hpo#CoverToolProperty"></see>
    /// </summary>
    let CoverToolProperty =
        Namespaced_IRI.parse _namespace_name "CoverToolProperty" |> NamespacedName

    /// <summary>
    /// Length (contributing to the size of the tool).
    /// <see href="http://w3id.org/emmo-hpo/hpo#CoverToolLength"></see></summary>
    let CoverToolLength =
        Namespaced_IRI.parse _namespace_name "CoverToolLength" |> NamespacedName

    /// <summary>
    /// Amount of holes.
    /// <see href="http://w3id.org/emmo-hpo/hpo#CoverToolNumberOfHoles"></see></summary>
    let CoverToolNumberOfHoles =
        Namespaced_IRI.parse _namespace_name "CoverToolNumberOfHoles" |> NamespacedName

    /// <summary>
    /// Average diameter of holes.
    /// <see href="http://w3id.org/emmo-hpo/hpo#CoverToolSizeOfHoles"></see></summary>
    let CoverToolSizeOfHoles =
        Namespaced_IRI.parse _namespace_name "CoverToolSizeOfHoles" |> NamespacedName

    /// <summary>
    /// Width (contributing to the size of the tool).
    /// <see href="http://w3id.org/emmo-hpo/hpo#CoverToolWidth"></see></summary>
    let CoverToolWidth =
        Namespaced_IRI.parse _namespace_name "CoverToolWidth" |> NamespacedName

    /// <summary>
    /// A class of structures characterised by a bond or a short sequence of bonds connecting different macromolecules.
    /// <see href="http://w3id.org/emmo-hpo/hpo#Crosslinked"></see></summary>
    let Crosslinked =
        Namespaced_IRI.parse _namespace_name "Crosslinked" |> NamespacedName

    /// <summary>
    /// A polymer whose molecular structure is characterised by additional covalent bonds connecting several chains together.
    /// <see href="http://w3id.org/emmo-hpo/hpo#CrosslinkedPolymer"></see></summary>
    let CrosslinkedPolymer =
        Namespaced_IRI.parse _namespace_name "CrosslinkedPolymer" |> NamespacedName

    /// <summary>
    /// Duration of the degassing.
    /// <see href="http://w3id.org/emmo-hpo/hpo#DegassingStepDuration"></see></summary>
    let DegassingStepDuration =
        Namespaced_IRI.parse _namespace_name "DegassingStepDuration" |> NamespacedName

    /// <summary>
    /// A polymer characterised by weak intermolecular forces and viscoelasticity.
    /// <see href="http://w3id.org/emmo-hpo/hpo#Elastomer"></see></summary>
    let Elastomer = Namespaced_IRI.parse _namespace_name "Elastomer" |> NamespacedName

    /// <summary>
    /// Ratio between increased length and initial length after breakage.
    /// <see href="http://w3id.org/emmo-hpo/hpo#ElongationAtBreak"></see></summary>
    let ElongationAtBreak =
        Namespaced_IRI.parse _namespace_name "ElongationAtBreak" |> NamespacedName

    /// <summary>
    /// A polymer characterised by strong intermolecular forces and high tensile strength.
    /// <see href="http://w3id.org/emmo-hpo/hpo#Fibre"></see></summary>
    let Fibre = Namespaced_IRI.parse _namespace_name "Fibre" |> NamespacedName

    /// <summary>
    /// Mass per unit volume of the facbric.
    /// <see href="http://w3id.org/emmo-hpo/hpo#FibreDensity"></see></summary>
    let FibreDensity =
        Namespaced_IRI.parse _namespace_name "FibreDensity" |> NamespacedName

    /// <summary>
    /// A collection of the properties of textile fabrics.
    /// <see href="http://w3id.org/emmo-hpo/hpo#TextileFabricProperty"></see></summary>
    let TextileFabricProperty =
        Namespaced_IRI.parse _namespace_name "TextileFabricProperty" |> NamespacedName

    /// <summary>
    /// Diameter of the fibre composing the fabric.
    /// <see href="http://w3id.org/emmo-hpo/hpo#FibreDiameter"></see></summary>
    let FibreDiameter =
        Namespaced_IRI.parse _namespace_name "FibreDiameter" |> NamespacedName

    /// <summary>
    /// Commercial name of the applied consumable (product), differentiating available product providers and product lots.
    /// <see href="http://w3id.org/emmo-hpo/hpo#FibreIdentifier"></see></summary>
    let FibreIdentifier =
        Namespaced_IRI.parse _namespace_name "FibreIdentifier" |> NamespacedName

    /// <summary>
    /// Ratio between the volume of fibre and the volume of the composite laminate.
    /// <see href="http://w3id.org/emmo-hpo/hpo#FibreVolumeContent"></see></summary>
    let FibreVolumeContent =
        Namespaced_IRI.parse _namespace_name "FibreVolumeContent" |> NamespacedName

    /// <summary>
    /// A material (usually low cost) added to a resin to extend it, or give special properties
    /// <see href="http://w3id.org/emmo-hpo/hpo#Filler"></see></summary>
    let Filler = Namespaced_IRI.parse _namespace_name "Filler" |> NamespacedName

    /// <summary>
    /// Final pressure of the container during step.
    /// <see href="http://w3id.org/emmo-hpo/hpo#FinalStepPressure"></see></summary>
    let FinalStepPressure =
        Namespaced_IRI.parse _namespace_name "FinalStepPressure" |> NamespacedName

    /// <summary>
    /// Final temperature of the container during step.
    /// <see href="http://w3id.org/emmo-hpo/hpo#FinalStepTemperature"></see></summary>
    let FinalStepTemperature =
        Namespaced_IRI.parse _namespace_name "FinalStepTemperature" |> NamespacedName

    /// <summary>
    /// Tangent of the stress-strain curve under flexural stress.
    /// <see href="http://w3id.org/emmo-hpo/hpo#FlexualModulus"></see></summary>
    let FlexualModulus =
        Namespaced_IRI.parse _namespace_name "FlexualModulus" |> NamespacedName

    /// <summary>
    /// Maximum value of the stress-strain curve under flexural stress.
    /// <see href="http://w3id.org/emmo-hpo/hpo#FlexuralStrength"></see></summary>
    let FlexuralStrength =
        Namespaced_IRI.parse _namespace_name "FlexuralStrength" |> NamespacedName

    /// <summary>
    /// A manufactured mixture of a resin and ingredients.
    /// <see href="http://w3id.org/emmo-hpo/hpo#FormulatedResin"></see></summary>
    let FormulatedResin =
        Namespaced_IRI.parse _namespace_name "FormulatedResin" |> NamespacedName

    /// <summary>
    /// Soft solid or highly viscous substance, usually containing prepolymers with reactive groups.
    /// <see href="http://w3id.org/emmo-hpo/hpo#Resin"></see></summary>
    let Resin = Namespaced_IRI.parse _namespace_name "Resin" |> NamespacedName

    /// <summary>
    /// Temperature required to start the process of cure of the resin.
    /// <see href="http://w3id.org/emmo-hpo/hpo#FormulatedResinCuringTemperature"></see></summary>
    let FormulatedResinCuringTemperature =
        Namespaced_IRI.parse _namespace_name "FormulatedResinCuringTemperature" |> NamespacedName

    /// <summary>
    /// A collection of the properties of formulated resins.
    /// <see href="http://w3id.org/emmo-hpo/hpo#FormulatedResinProperty"></see></summary>
    let FormulatedResinProperty =
        Namespaced_IRI.parse _namespace_name "FormulatedResinProperty" |> NamespacedName

    /// <summary>
    /// Time at which the curing temperature must be held to achieve a certain level of cure.
    /// <see href="http://w3id.org/emmo-hpo/hpo#FormulatedResinCuringTime"></see></summary>
    let FormulatedResinCuringTime =
        Namespaced_IRI.parse _namespace_name "FormulatedResinCuringTime" |> NamespacedName

    /// <summary>
    /// Process in which a polymer melt changes on cooling to a polymer glass or a polymer glass changes on heating to a polymer melt.
    /// <see href="http://w3id.org/emmo-hpo/hpo#FormulatedResinGlassTransitionTemperature"></see></summary>
    let FormulatedResinGlassTransitionTemperature =
        Namespaced_IRI.parse _namespace_name "FormulatedResinGlassTransitionTemperature" |> NamespacedName

    /// <summary>
    /// Mass of water released per mass of resin throughout the applied chemical (curing) reaction.
    /// <see href="http://w3id.org/emmo-hpo/hpo#FormulatedResinSpecificCondensateFormation"></see></summary>
    let FormulatedResinSpecificCondensateFormation =
        Namespaced_IRI.parse _namespace_name "FormulatedResinSpecificCondensateFormation" |> NamespacedName

    /// <summary>
    /// Dynamic viscosity of the resin.
    /// <see href="http://w3id.org/emmo-hpo/hpo#FormulatedResinViscosity"></see></summary>
    let FormulatedResinViscosity =
        Namespaced_IRI.parse _namespace_name "FormulatedResinViscosity" |> NamespacedName

    /// <summary>
    /// Weight percentage of (dissolved and freezable) water in the base resin.
    /// <see href="http://w3id.org/emmo-hpo/hpo#FormulatedResinWaterContent"></see></summary>
    let FormulatedResinWaterContent =
        Namespaced_IRI.parse _namespace_name "FormulatedResinWaterContent" |> NamespacedName

    /// <summary>
    /// Temperature for transition from glassy state into a viscous one.
    /// <see href="http://w3id.org/emmo-hpo/hpo#GlassTransitionTemperature"></see></summary>
    let GlassTransitionTemperature =
        Namespaced_IRI.parse _namespace_name "GlassTransitionTemperature" |> NamespacedName

    /// <summary>
    /// Heating rate during step.
    /// <see href="http://w3id.org/emmo-hpo/hpo#HeatingRateDuringStep"></see></summary>
    let HeatingRateDuringStep =
        Namespaced_IRI.parse _namespace_name "HeatingRateDuringStep" |> NamespacedName

    /// <summary>
    /// A polymer derived from the polymerisation of one kind of monomer.
    /// <see href="http://w3id.org/emmo-hpo/hpo#HomoPolymer"></see></summary>
    let HomoPolymer =
        Namespaced_IRI.parse _namespace_name "HomoPolymer" |> NamespacedName

    /// <summary>
    /// Pressure during step.
    /// <see href="http://w3id.org/emmo-hpo/hpo#InitialStepPressure"></see></summary>
    let InitialStepPressure =
        Namespaced_IRI.parse _namespace_name "InitialStepPressure" |> NamespacedName

    /// <summary>
    /// Initial temperature of the container during step.
    /// <see href="http://w3id.org/emmo-hpo/hpo#InitialStepTemperature"></see></summary>
    let InitialStepTemperature =
        Namespaced_IRI.parse _namespace_name "InitialStepTemperature" |> NamespacedName

    /// <summary>
    /// Mechanical property associated with the matrix-fibre interaction.
    /// <see href="http://w3id.org/emmo-hpo/hpo#InterlaminarShearStrength"></see></summary>
    let InterlaminarShearStrength =
        Namespaced_IRI.parse _namespace_name "InterlaminarShearStrength" |> NamespacedName

    /// <summary>
    /// A class of structures characterised by a linear skeleton.
    /// <see href="http://w3id.org/emmo-hpo/hpo#Linear"></see></summary>
    let Linear = Namespaced_IRI.parse _namespace_name "Linear" |> NamespacedName

    /// <summary>
    /// A polymer whose molecular structure is characterised by a linear chain of repeating units.
    /// <see href="http://w3id.org/emmo-hpo/hpo#LinearPolymer"></see></summary>
    let LinearPolymer =
        Namespaced_IRI.parse _namespace_name "LinearPolymer" |> NamespacedName

    /// <summary>
    /// A single molecule that reacts with like or unlike molecules to form a polymer.
    /// <see href="http://w3id.org/emmo-hpo/hpo#Monomer"></see></summary>
    let Monomer = Namespaced_IRI.parse _namespace_name "Monomer" |> NamespacedName

    /// <summary>
    /// Commercial name of the applied consumable (product), differentiating available product providers and product lots.
    /// <see href="http://w3id.org/emmo-hpo/hpo#MouldReleaseLayerIdentifier"></see></summary>
    let MouldReleaseLayerIdentifier =
        Namespaced_IRI.parse _namespace_name "MouldReleaseLayerIdentifier" |> NamespacedName

    /// <summary>
    /// A collection of the properties of the release layer of a mould or tool.
    /// <see href="http://w3id.org/emmo-hpo/hpo#MouldReleaseLayerProperty"></see></summary>
    let MouldReleaseLayerProperty =
        Namespaced_IRI.parse _namespace_name "MouldReleaseLayerProperty" |> NamespacedName

    /// <summary>
    /// Length (contributing to the size of the tool).
    /// <see href="http://w3id.org/emmo-hpo/hpo#MouldToolLength"></see></summary>
    let MouldToolLength =
        Namespaced_IRI.parse _namespace_name "MouldToolLength" |> NamespacedName

    /// <summary>
    /// A collection of the properties of moulds or tools.
    /// <see href="http://w3id.org/emmo-hpo/hpo#MouldToolProperty"></see></summary>
    let MouldToolProperty =
        Namespaced_IRI.parse _namespace_name "MouldToolProperty" |> NamespacedName

    /// <summary>
    /// Arithmetic average of the absolute values of the profile height deviations from the mean line, recorded within the evaluation length.
    /// <see href="http://w3id.org/emmo-hpo/hpo#MouldToolSurfaceRoughness"></see></summary>
    let MouldToolSurfaceRoughness =
        Namespaced_IRI.parse _namespace_name "MouldToolSurfaceRoughness" |> NamespacedName

    /// <summary>
    /// Width (contributing to the size of the tool).
    /// <see href="http://w3id.org/emmo-hpo/hpo#MouldToolWidth"></see></summary>
    let MouldToolWidth =
        Namespaced_IRI.parse _namespace_name "MouldToolWidth" |> NamespacedName

    /// <summary>
    /// A naturally occurring polymer produced by living organisms.
    /// <see href="http://w3id.org/emmo-hpo/hpo#NaturalPolymer"></see></summary>
    let NaturalPolymer =
        Namespaced_IRI.parse _namespace_name "NaturalPolymer" |> NamespacedName

    /// <summary>
    /// Parts manufactured per minute.
    /// <see href="http://w3id.org/emmo-hpo/hpo#PartsTurnover"></see></summary>
    let PartsTurnover =
        Namespaced_IRI.parse _namespace_name "PartsTurnover" |> NamespacedName

    /// <summary>
    /// After cutting a test sample out of the specimen to be tested, gravimetric and volumetric findings are used to calculate an (average) density that is compared to the density of a qualified (reference) “in order (i.o.)” specimen.
    /// <see href="http://w3id.org/emmo-hpo/hpo#PorosityInferredFromDensity"></see></summary>
    let PorosityInferredFromDensity =
        Namespaced_IRI.parse _namespace_name "PorosityInferredFromDensity" |> NamespacedName

    /// <summary>
    /// A factory-made combination of reactive resins and reinforcing fibres, plus other necessary additive chemicals, ready to be moulded.
    /// <see href="http://w3id.org/emmo-hpo/hpo#Prepreg"></see></summary>
    let Prepreg = Namespaced_IRI.parse _namespace_name "Prepreg" |> NamespacedName

    /// <summary>
    /// Percentage of the (feasible) curing (that is no more available for cross-linking reaction(s))
    /// <see href="http://w3id.org/emmo-hpo/hpo#PrepregCuringDegree"></see></summary>
    let PrepregCuringDegree =
        Namespaced_IRI.parse _namespace_name "PrepregCuringDegree" |> NamespacedName

    /// <summary>
    /// A collection of the properties of prepregs.
    /// <see href="http://w3id.org/emmo-hpo/hpo#PrepregProperty"></see></summary>
    let PrepregProperty =
        Namespaced_IRI.parse _namespace_name "PrepregProperty" |> NamespacedName

    /// <summary>
    /// Mass per unit volume of the prepreg.
    /// <see href="http://w3id.org/emmo-hpo/hpo#PrepregDensity"></see></summary>
    let PrepregDensity =
        Namespaced_IRI.parse _namespace_name "PrepregDensity" |> NamespacedName

    /// <summary>
    /// EXPECTED ratio between increased length and initial length after breakage AFTER CURING.
    /// <see href="http://w3id.org/emmo-hpo/hpo#PrepregExpectedElongationAtBreak"></see></summary>
    let PrepregExpectedElongationAtBreak =
        Namespaced_IRI.parse _namespace_name "PrepregExpectedElongationAtBreak" |> NamespacedName

    /// <summary>
    /// EXPECTED Tangent of the stress-strain curve under flexural stress AFTER CURING.
    /// <see href="http://w3id.org/emmo-hpo/hpo#PrepregExpectedFlexualModulus"></see></summary>
    let PrepregExpectedFlexualModulus =
        Namespaced_IRI.parse _namespace_name "PrepregExpectedFlexualModulus" |> NamespacedName

    /// <summary>
    /// EXPECTED Maximum value of the stress-strain curve under flexural stress AFTER CURING.
    /// <see href="http://w3id.org/emmo-hpo/hpo#PrepregExpectedFlexuralStrength"></see></summary>
    let PrepregExpectedFlexuralStrength =
        Namespaced_IRI.parse _namespace_name "PrepregExpectedFlexuralStrength" |> NamespacedName

    /// <summary>
    /// EXPECTED Tangent of the stress-strain curve under tensile stress AFTER CURING.
    /// <see href="http://w3id.org/emmo-hpo/hpo#PrepregExpectedTensileModulus"></see></summary>
    let PrepregExpectedTensileModulus =
        Namespaced_IRI.parse _namespace_name "PrepregExpectedTensileModulus" |> NamespacedName

    /// <summary>
    /// EXPECTED Maximum value of the stress-strain curve under tensile stress AFTER CURING.
    /// <see href="http://w3id.org/emmo-hpo/hpo#PrepregExpectedTensileStrength"></see></summary>
    let PrepregExpectedTensileStrength =
        Namespaced_IRI.parse _namespace_name "PrepregExpectedTensileStrength" |> NamespacedName

    /// <summary>
    /// Ratio between the volume of fibre and the volume of the composite.
    /// <see href="http://w3id.org/emmo-hpo/hpo#PrepregFibreVolumeContent"></see></summary>
    let PrepregFibreVolumeContent =
        Namespaced_IRI.parse _namespace_name "PrepregFibreVolumeContent" |> NamespacedName

    /// <summary>
    /// Characteristic temperature (range) of the process in which a polymer melt changes on cooling to a polymer glass or a polymer glass changes on heating to a polymer melt.
    /// <see href="http://w3id.org/emmo-hpo/hpo#PrepregGlassTransitionTemperature"></see></summary>
    let PrepregGlassTransitionTemperature =
        Namespaced_IRI.parse _namespace_name "PrepregGlassTransitionTemperature" |> NamespacedName

    /// <summary>
    /// A manufacturing line processing a prepreg for later use.
    /// <see href="http://w3id.org/emmo-hpo/hpo#PrepregLine"></see></summary>
    let PrepregLine =
        Namespaced_IRI.parse _namespace_name "PrepregLine" |> NamespacedName

    /// <summary>
    /// A prepreg a piece cut from a prepreg roll, which can be stacked.
    /// <see href="http://w3id.org/emmo-hpo/hpo#PrepregPiece"></see></summary>
    let PrepregPiece =
        Namespaced_IRI.parse _namespace_name "PrepregPiece" |> NamespacedName

    /// <summary>
    /// A roll of prepreg material.
    /// <see href="http://w3id.org/emmo-hpo/hpo#PrepregRoll"></see></summary>
    let PrepregRoll =
        Namespaced_IRI.parse _namespace_name "PrepregRoll" |> NamespacedName

    /// <summary>
    /// A planar textile constructed with fibres (or yarns), which can be either woven (interlaced using a weaving process) or non-woven (not interlaced).
    /// <see href="http://w3id.org/emmo-hpo/hpo#TextileFabric"></see></summary>
    let TextileFabric =
        Namespaced_IRI.parse _namespace_name "TextileFabric" |> NamespacedName

    /// <summary>
    /// Mass of water released per mass of prepreg throughout the applied chemical (curing) reaction.
    /// <see href="http://w3id.org/emmo-hpo/hpo#PrepregSpecificCondensateFormation"></see></summary>
    let PrepregSpecificCondensateFormation =
        Namespaced_IRI.parse _namespace_name "PrepregSpecificCondensateFormation" |> NamespacedName

    /// <summary>
    /// Thickness of the prepreg.
    /// <see href="http://w3id.org/emmo-hpo/hpo#PrepregThickness"></see></summary>
    let PrepregThickness =
        Namespaced_IRI.parse _namespace_name "PrepregThickness" |> NamespacedName

    /// <summary>
    /// Weight percentage of water in the prepreg (that can be dried and is not formed during the curing reaction).
    /// <see href="http://w3id.org/emmo-hpo/hpo#PrepregWaterContent"></see></summary>
    let PrepregWaterContent =
        Namespaced_IRI.parse _namespace_name "PrepregWaterContent" |> NamespacedName

    /// <summary>
    /// Effective and anisotropic proportionality constant between the molar (or mass) flux due to molecular diffusion (out of the prepreg specimen).
    /// <see href="http://w3id.org/emmo-hpo/hpo#PrepregWaterDiffusionCoefficient"></see></summary>
    let PrepregWaterDiffusionCoefficient =
        Namespaced_IRI.parse _namespace_name "PrepregWaterDiffusionCoefficient" |> NamespacedName

    /// <summary>
    /// Width of the prepreg.
    /// <see href="http://w3id.org/emmo-hpo/hpo#PrepregWidth"></see></summary>
    let PrepregWidth =
        Namespaced_IRI.parse _namespace_name "PrepregWidth" |> NamespacedName

    /// <summary>
    /// The process of prepreg manufacturing.
    /// <see href="http://w3id.org/emmo-hpo/hpo#Prepregging"></see></summary>
    let Prepregging =
        Namespaced_IRI.parse _namespace_name "Prepregging" |> NamespacedName

    /// <summary>
    /// A polymer that becomes irreversibly hard by creating an extensive network of cross-linking between the individual chains.
    /// <see href="http://w3id.org/emmo-hpo/hpo#ThermosettingPolymer"></see></summary>
    let ThermosettingPolymer =
        Namespaced_IRI.parse _namespace_name "ThermosettingPolymer" |> NamespacedName

    /// <summary>
    /// Total composition of the resin.
    /// <see href="http://w3id.org/emmo-hpo/hpo#ResinComposition"></see></summary>
    let ResinComposition =
        Namespaced_IRI.parse _namespace_name "ResinComposition" |> NamespacedName

    /// <summary>
    /// A collection of the properties of resins.
    /// <see href="http://w3id.org/emmo-hpo/hpo#ResinProperty"></see></summary>
    let ResinProperty =
        Namespaced_IRI.parse _namespace_name "ResinProperty" |> NamespacedName

    /// <summary>
    /// Mass density of the resin.
    /// <see href="http://w3id.org/emmo-hpo/hpo#ResinDensity"></see></summary>
    let ResinDensity =
        Namespaced_IRI.parse _namespace_name "ResinDensity" |> NamespacedName

    /// <summary>
    /// A batch resin mixer.
    /// <see href="http://w3id.org/emmo-hpo/hpo#ResinMixer"></see></summary>
    let ResinMixer = Namespaced_IRI.parse _namespace_name "ResinMixer" |> NamespacedName

    /// <summary>
    /// Average molecular weight of the main resin molecular consituents.
    /// <see href="http://w3id.org/emmo-hpo/hpo#ResinMolecularWeight"></see></summary>
    let ResinMolecularWeight =
        Namespaced_IRI.parse _namespace_name "ResinMolecularWeight" |> NamespacedName

    /// <summary>
    /// Preparing a resin involves mixing the precursor (monomers) with a hardener or a catalyst, fillers, and additives.
    /// <see href="http://w3id.org/emmo-hpo/hpo#ResinPreparation"></see></summary>
    let ResinPreparation =
        Namespaced_IRI.parse _namespace_name "ResinPreparation" |> NamespacedName

    /// <summary>
    /// Maximum amount of energy released in case of complete conversion.
    /// <see href="http://w3id.org/emmo-hpo/hpo#ResinReactivity"></see></summary>
    let ResinReactivity =
        Namespaced_IRI.parse _namespace_name "ResinReactivity" |> NamespacedName

    /// <summary>
    /// Viscosity at 25°C.
    /// <see href="http://w3id.org/emmo-hpo/hpo#ResinViscosity"></see></summary>
    let ResinViscosity =
        Namespaced_IRI.parse _namespace_name "ResinViscosity" |> NamespacedName

    /// <summary>
    /// Percentage of water in the base resin.
    /// <see href="http://w3id.org/emmo-hpo/hpo#ResinWaterContent"></see></summary>
    let ResinWaterContent =
        Namespaced_IRI.parse _namespace_name "ResinWaterContent" |> NamespacedName

    /// <summary>
    /// pH of the resin.
    /// <see href="http://w3id.org/emmo-hpo/hpo#ResinpH"></see></summary>
    let ResinpH = Namespaced_IRI.parse _namespace_name "ResinpH" |> NamespacedName

    /// <summary>
    /// A polymer synthesised from biomass sources.
    /// <see href="http://w3id.org/emmo-hpo/hpo#SemiSyntheticPolymer"></see></summary>
    let SemiSyntheticPolymer =
        Namespaced_IRI.parse _namespace_name "SemiSyntheticPolymer" |> NamespacedName

    /// <summary>
    /// Length (contributing to the size of the object).
    /// <see href="http://w3id.org/emmo-hpo/hpo#StackedPrepregLength"></see></summary>
    let StackedPrepregLength =
        Namespaced_IRI.parse _namespace_name "StackedPrepregLength" |> NamespacedName

    /// <summary>
    /// A collection of the properties of stacked prepregs.
    /// <see href="http://w3id.org/emmo-hpo/hpo#StackedPrepregProperty"></see></summary>
    let StackedPrepregProperty =
        Namespaced_IRI.parse _namespace_name "StackedPrepregProperty" |> NamespacedName

    /// <summary>
    /// Sum of the thicknesses of prepreg layer.
    /// <see href="http://w3id.org/emmo-hpo/hpo#StackedPrepregNominalThickness"></see></summary>
    let StackedPrepregNominalThickness =
        Namespaced_IRI.parse _namespace_name "StackedPrepregNominalThickness" |> NamespacedName

    /// <summary>
    /// Number of stacked prepreg layers
    /// <see href="http://w3id.org/emmo-hpo/hpo#StackedPrepregNumberOfLayers"></see></summary>
    let StackedPrepregNumberOfLayers =
        Namespaced_IRI.parse _namespace_name "StackedPrepregNumberOfLayers" |> NamespacedName

    /// <summary>
    /// List of the orientation (degreees) of each prepreg layer.
    /// <see href="http://w3id.org/emmo-hpo/hpo#StackedPrepregStackingSequence"></see></summary>
    let StackedPrepregStackingSequence =
        Namespaced_IRI.parse _namespace_name "StackedPrepregStackingSequence" |> NamespacedName

    /// <summary>
    /// Width (contributing to the size of the object).
    /// <see href="http://w3id.org/emmo-hpo/hpo#StackedPrepregWidth"></see></summary>
    let StackedPrepregWidth =
        Namespaced_IRI.parse _namespace_name "StackedPrepregWidth" |> NamespacedName

    /// <summary>
    /// Step duration
    /// <see href="http://w3id.org/emmo-hpo/hpo#StepDuration"></see></summary>
    let StepDuration =
        Namespaced_IRI.parse _namespace_name "StepDuration" |> NamespacedName

    /// <summary>
    /// The storage modulus in viscoelastic materials measure the stored energy representing the elastic portion.
    /// <see href="http://w3id.org/emmo-hpo/hpo#StorageModulus"></see></summary>
    let StorageModulus =
        Namespaced_IRI.parse _namespace_name "StorageModulus" |> NamespacedName

    /// <summary>
    /// A polymer synthesised from other manufactured chemicals.
    /// <see href="http://w3id.org/emmo-hpo/hpo#SyntheticPolymer"></see></summary>
    let SyntheticPolymer =
        Namespaced_IRI.parse _namespace_name "SyntheticPolymer" |> NamespacedName

    /// <summary>
    /// Tangent of the stress-strain curve under tensile stress.
    /// <see href="http://w3id.org/emmo-hpo/hpo#TensileModulus"></see></summary>
    let TensileModulus =
        Namespaced_IRI.parse _namespace_name "TensileModulus" |> NamespacedName

    /// <summary>
    /// Maximum value of the stress-strain curve under tensile stress.
    /// <see href="http://w3id.org/emmo-hpo/hpo#TensileStrength"></see></summary>
    let TensileStrength =
        Namespaced_IRI.parse _namespace_name "TensileStrength" |> NamespacedName

    /// <summary>
    /// Textile fabric thickness
    /// <see href="http://w3id.org/emmo-hpo/hpo#TextileFabricThickness"></see></summary>
    let TextileFabricThickness =
        Namespaced_IRI.parse _namespace_name "TextileFabricThickness" |> NamespacedName

    /// <summary>
    /// Pattern of fibre weaving.
    /// <see href="http://w3id.org/emmo-hpo/hpo#TextileFabricWeaveStyle"></see></summary>
    let TextileFabricWeaveStyle =
        Namespaced_IRI.parse _namespace_name "TextileFabricWeaveStyle" |> NamespacedName

    /// <summary>
    /// Width of the fabric.
    /// <see href="http://w3id.org/emmo-hpo/hpo#TextileFabricWidth"></see></summary>
    let TextileFabricWidth =
        Namespaced_IRI.parse _namespace_name "TextileFabricWidth" |> NamespacedName

    /// <summary>
    /// A polymer that becomes pliable and mouldable (i.e. plastic) above a certain temperature, and that reversibly solidifies upon cooling. Thermoplastics typically have linear chains and high molecular weight, increasing the strength of intermolecular interactions.
    /// <see href="http://w3id.org/emmo-hpo/hpo#ThermoplasticPolymer"></see></summary>
    let ThermoplasticPolymer =
        Namespaced_IRI.parse _namespace_name "ThermoplasticPolymer" |> NamespacedName

    /// <summary>
    /// Solvents, such as water and alcohol, in a sizing or resin formulation that can be vaporized at ambient or slightly elevated temperatures.
    /// <see href="http://w3id.org/emmo-hpo/hpo#Volatile"></see></summary>
    let Volatile = Namespaced_IRI.parse _namespace_name "Volatile" |> NamespacedName

    /// <summary>
    /// List of steps for the mixing process.
    /// <see href="http://w3id.org/emmo-hpo/hpo#WorkingStepsOrder"></see></summary>
    let WorkingStepsOrder =
        Namespaced_IRI.parse _namespace_name "WorkingStepsOrder" |> NamespacedName
