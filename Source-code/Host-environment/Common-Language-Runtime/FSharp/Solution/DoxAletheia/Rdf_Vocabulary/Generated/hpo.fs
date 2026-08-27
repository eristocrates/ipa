namespace http.w3id.org.emmo_hpo.hpo.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module hpo =
    let _namespace_iri = Namespace_Iri hpo |> NamespaceIRI
    /// <summary>
    ///   <para>hpo:AdditionPolymer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A polymer obtained through an addition reaction, that is, a reaction involving the creation of a single bond between the atoms of different molecules which are involved in a double or triple bond."</para>
    /// labels<para>"AdditionPolymer"</para></remarks>
    /// <seealso href="http://w3id.org/emmo-hpo/hpo#AdditionPolymer">http://w3id.org/emmo-hpo/hpo#AdditionPolymer</seealso>
    let AdditionPolymer = Prefixed_Name(hpo, "AdditionPolymer") |> PrefixedName
    /// <summary>
    ///   <para>hpo:Additive</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A term used for a large number of specialist chemicals which are added to compounds to impart specific properties."</para>
    /// labels<para>"Additive"</para></remarks>
    /// <seealso href="http://w3id.org/emmo-hpo/hpo#Additive">http://w3id.org/emmo-hpo/hpo#Additive</seealso>
    let Additive = Prefixed_Name(hpo, "Additive") |> PrefixedName
    /// <summary>
    ///   <para>hpo:Branched</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A class of structures characterised by a branched skeleton."</para>
    /// labels<para>"Branched"</para></remarks>
    /// <seealso href="http://w3id.org/emmo-hpo/hpo#Branched">http://w3id.org/emmo-hpo/hpo#Branched</seealso>
    let Branched = Prefixed_Name(hpo, "Branched") |> PrefixedName

    /// <summary>
    ///   <para>hpo:BranchedChainPolymer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A polymer whose molecular structure is characterised by a regular or irregular attachment of side chains to the main backbone chain. ."</para>
    /// labels<para>"BranchedChainPolymer"</para></remarks>
    /// <seealso href="http://w3id.org/emmo-hpo/hpo#BranchedChainPolymer">http://w3id.org/emmo-hpo/hpo#BranchedChainPolymer</seealso>
    let BranchedChainPolymer =
        Prefixed_Name(hpo, "BranchedChainPolymer") |> PrefixedName

    /// <summary>
    ///   <para>hpo:COMPEVODSCAnalysis</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Experimental procedure for resin reactivity measurement."</para>
    /// labels<para>"COMPEVODSCAnalysis"</para></remarks>
    /// <seealso href="http://w3id.org/emmo-hpo/hpo#COMPEVODSCAnalysis">http://w3id.org/emmo-hpo/hpo#COMPEVODSCAnalysis</seealso>
    let COMPEVODSCAnalysis = Prefixed_Name(hpo, "COMPEVODSCAnalysis") |> PrefixedName
    /// <summary>
    ///   <para>hpo:Catalyst</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A substance that increases the rate of a reaction without modifying the overall standard Gibbs energy change in the reaction."</para>
    /// labels<para>"Catalyst"</para></remarks>
    /// <seealso href="http://w3id.org/emmo-hpo/hpo#Catalyst">http://w3id.org/emmo-hpo/hpo#Catalyst</seealso>
    let Catalyst = Prefixed_Name(hpo, "Catalyst") |> PrefixedName

    /// <summary>
    ///   <para>hpo:CatalystCommercialName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Catalyst suppliers trade name for the purchased catalyst formulation."</para>
    /// labels<para>"CatalystCommercialName"</para></remarks>
    /// <seealso href="http://w3id.org/emmo-hpo/hpo#CatalystCommercialName">http://w3id.org/emmo-hpo/hpo#CatalystCommercialName</seealso>
    let CatalystCommercialName =
        Prefixed_Name(hpo, "CatalystCommercialName") |> PrefixedName

    /// <summary>
    ///   <para>hpo:CatalystDensity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Mass density of the catalyst."</para>
    /// labels<para>"CatalystDensity"</para></remarks>
    /// <seealso href="http://w3id.org/emmo-hpo/hpo#CatalystDensity">http://w3id.org/emmo-hpo/hpo#CatalystDensity</seealso>
    let CatalystDensity = Prefixed_Name(hpo, "CatalystDensity") |> PrefixedName

    /// <summary>
    ///   <para>hpo:CatalystMolecularWeight</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Average molecular weight of the catalyst molecular consituents."</para>
    /// labels<para>"CatalystMolecularWeight"</para></remarks>
    /// <seealso href="http://w3id.org/emmo-hpo/hpo#CatalystMolecularWeight">http://w3id.org/emmo-hpo/hpo#CatalystMolecularWeight</seealso>
    let CatalystMolecularWeight =
        Prefixed_Name(hpo, "CatalystMolecularWeight") |> PrefixedName

    /// <summary>
    ///   <para>hpo:CatalystProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"CatalystProperty"</para></remarks>
    /// <seealso href="http://w3id.org/emmo-hpo/hpo#CatalystProperty">http://w3id.org/emmo-hpo/hpo#CatalystProperty</seealso>
    let CatalystProperty = Prefixed_Name(hpo, "CatalystProperty") |> PrefixedName
    /// <summary>
    ///   <para>hpo:CatalystViscosity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Catalyst viscosity at 25°C."</para>
    /// labels<para>"CatalystViscosity"</para></remarks>
    /// <seealso href="http://w3id.org/emmo-hpo/hpo#CatalystViscosity">http://w3id.org/emmo-hpo/hpo#CatalystViscosity</seealso>
    let CatalystViscosity = Prefixed_Name(hpo, "CatalystViscosity") |> PrefixedName
    /// <summary>
    ///   <para>hpo:CoPolymer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A polymer derived from the polymerisation of more than one species of monomer."</para>
    /// labels<para>"CoPolymer"</para></remarks>
    /// <seealso href="http://w3id.org/emmo-hpo/hpo#CoPolymer">http://w3id.org/emmo-hpo/hpo#CoPolymer</seealso>
    let CoPolymer = Prefixed_Name(hpo, "CoPolymer") |> PrefixedName

    /// <summary>
    ///   <para>hpo:ComponentManufacturing</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The manufacturing of a component made of a composite material."</para>
    /// labels<para>"ComponentManufacturing"</para></remarks>
    /// <seealso href="http://w3id.org/emmo-hpo/hpo#ComponentManufacturing">http://w3id.org/emmo-hpo/hpo#ComponentManufacturing</seealso>
    let ComponentManufacturing =
        Prefixed_Name(hpo, "ComponentManufacturing") |> PrefixedName

    /// <summary>
    ///   <para>hpo:ComponentManufacturingLine</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A manufacturing line processing a composite material into a component."</para>
    /// labels<para>"ComponentManufacturingLine"</para></remarks>
    /// <seealso href="http://w3id.org/emmo-hpo/hpo#ComponentManufacturingLine">http://w3id.org/emmo-hpo/hpo#ComponentManufacturingLine</seealso>
    let ComponentManufacturingLine =
        Prefixed_Name(hpo, "ComponentManufacturingLine") |> PrefixedName

    /// <summary>
    ///   <para>hpo:ComponentManufacturingProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"ComponentManufacturingProperty"</para></remarks>
    /// <seealso href="http://w3id.org/emmo-hpo/hpo#ComponentManufacturingProperty">http://w3id.org/emmo-hpo/hpo#ComponentManufacturingProperty</seealso>
    let ComponentManufacturingProperty =
        Prefixed_Name(hpo, "ComponentManufacturingProperty") |> PrefixedName

    /// <summary>
    ///   <para>hpo:Composite</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A material made up of resin and reinforcement (usually fibre)."</para>
    /// labels<para>"Composite"</para></remarks>
    /// <seealso href="http://w3id.org/emmo-hpo/hpo#Composite">http://w3id.org/emmo-hpo/hpo#Composite</seealso>
    let Composite = Prefixed_Name(hpo, "Composite") |> PrefixedName
    /// <summary>
    ///   <para>hpo:CompositeLaminate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"CompositeLaminate"</para></remarks>
    /// <seealso href="http://w3id.org/emmo-hpo/hpo#CompositeLaminate">http://w3id.org/emmo-hpo/hpo#CompositeLaminate</seealso>
    let CompositeLaminate = Prefixed_Name(hpo, "CompositeLaminate") |> PrefixedName

    /// <summary>
    ///   <para>hpo:CompositeLaminateBulkPorosity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"After performing a cross-cut perpendicular to the specimen surface, based on a light microscopy image, the apparent surface area fraction occupied by pores is evaluated."</para>
    /// labels<para>"CompositeLaminateBulkPorosity"</para></remarks>
    /// <seealso href="http://w3id.org/emmo-hpo/hpo#CompositeLaminateBulkPorosity">http://w3id.org/emmo-hpo/hpo#CompositeLaminateBulkPorosity</seealso>
    let CompositeLaminateBulkPorosity =
        Prefixed_Name(hpo, "CompositeLaminateBulkPorosity") |> PrefixedName

    /// <summary>
    ///   <para>hpo:CompositeLaminateProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"CompositeLaminateProperty"</para></remarks>
    /// <seealso href="http://w3id.org/emmo-hpo/hpo#CompositeLaminateProperty">http://w3id.org/emmo-hpo/hpo#CompositeLaminateProperty</seealso>
    let CompositeLaminateProperty =
        Prefixed_Name(hpo, "CompositeLaminateProperty") |> PrefixedName

    /// <summary>
    ///   <para>hpo:CompositeLaminateSurfaceRegionPorosity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Based on a light microscopy image of the smoother surface (i.e. the one visible to a user) of the composite laminate, the apparent surface area fraction occupied by pores is evaluated."</para>
    /// labels<para>"CompositeLaminateSurfaceRegionPorosity"</para></remarks>
    /// <seealso href="http://w3id.org/emmo-hpo/hpo#CompositeLaminateSurfaceRegionPorosity">http://w3id.org/emmo-hpo/hpo#CompositeLaminateSurfaceRegionPorosity</seealso>
    let CompositeLaminateSurfaceRegionPorosity =
        Prefixed_Name(hpo, "CompositeLaminateSurfaceRegionPorosity") |> PrefixedName

    /// <summary>
    ///   <para>hpo:CompositeLaminateVisualSurfaceFinish</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Using a (set of) specimen illumination settings, the appearance is compared with the appearance of a specified set of (reference) specimens."</para>
    /// labels<para>"CompositeLaminateVisualSurfaceFinish"</para></remarks>
    /// <seealso href="http://w3id.org/emmo-hpo/hpo#CompositeLaminateVisualSurfaceFinish">http://w3id.org/emmo-hpo/hpo#CompositeLaminateVisualSurfaceFinish</seealso>
    let CompositeLaminateVisualSurfaceFinish =
        Prefixed_Name(hpo, "CompositeLaminateVisualSurfaceFinish") |> PrefixedName

    /// <summary>
    ///   <para>hpo:CondensationPolymer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A polymer obtained through a condensation reaction, that is, where two molecules form a chemical bond by eliminating a small molecule such as water."</para>
    /// labels<para>"CondensationPolymer"</para></remarks>
    /// <seealso href="http://w3id.org/emmo-hpo/hpo#CondensationPolymer">http://w3id.org/emmo-hpo/hpo#CondensationPolymer</seealso>
    let CondensationPolymer = Prefixed_Name(hpo, "CondensationPolymer") |> PrefixedName
    /// <summary>
    ///   <para>hpo:CoverReleaseLayer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A release layer applied to a cover placed over the laminate."</para>
    /// labels<para>"CoverReleaseLayer"</para></remarks>
    /// <seealso href="http://w3id.org/emmo-hpo/hpo#CoverReleaseLayer">http://w3id.org/emmo-hpo/hpo#CoverReleaseLayer</seealso>
    let CoverReleaseLayer = Prefixed_Name(hpo, "CoverReleaseLayer") |> PrefixedName

    /// <summary>
    ///   <para>hpo:CoverReleaseLayerIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Commercial name of the applied consumable (product), differentiating available product providers and product lots."</para>
    /// labels<para>"CoverReleaseLayerIdentifier"</para></remarks>
    /// <seealso href="http://w3id.org/emmo-hpo/hpo#CoverReleaseLayerIdentifier">http://w3id.org/emmo-hpo/hpo#CoverReleaseLayerIdentifier</seealso>
    let CoverReleaseLayerIdentifier =
        Prefixed_Name(hpo, "CoverReleaseLayerIdentifier") |> PrefixedName

    /// <summary>
    ///   <para>hpo:CoverReleaseLayerProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"CoverReleaseLayerProperty"</para></remarks>
    /// <seealso href="http://w3id.org/emmo-hpo/hpo#CoverReleaseLayerProperty">http://w3id.org/emmo-hpo/hpo#CoverReleaseLayerProperty</seealso>
    let CoverReleaseLayerProperty =
        Prefixed_Name(hpo, "CoverReleaseLayerProperty") |> PrefixedName

    /// <summary>
    ///   <para>hpo:CoverTool</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The mold, either one- or two-sided and either open or closed, in or upon which composite material is placed in order to make a part."</para>
    /// labels<para>"CoverTool"</para></remarks>
    /// <seealso href="http://w3id.org/emmo-hpo/hpo#CoverTool">http://w3id.org/emmo-hpo/hpo#CoverTool</seealso>
    let CoverTool = Prefixed_Name(hpo, "CoverTool") |> PrefixedName

    /// <summary>
    ///   <para>hpo:CoverToolHoleDistance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Average distance between holes."</para>
    /// labels<para>"CoverToolHoleDistance"</para></remarks>
    /// <seealso href="http://w3id.org/emmo-hpo/hpo#CoverToolHoleDistance">http://w3id.org/emmo-hpo/hpo#CoverToolHoleDistance</seealso>
    let CoverToolHoleDistance =
        Prefixed_Name(hpo, "CoverToolHoleDistance") |> PrefixedName

    /// <summary>
    ///   <para>hpo:CoverToolLength</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Length (contributing to the size of the tool)."</para>
    /// labels<para>"CoverToolLength"</para></remarks>
    /// <seealso href="http://w3id.org/emmo-hpo/hpo#CoverToolLength">http://w3id.org/emmo-hpo/hpo#CoverToolLength</seealso>
    let CoverToolLength = Prefixed_Name(hpo, "CoverToolLength") |> PrefixedName

    /// <summary>
    ///   <para>hpo:CoverToolNumberOfHoles</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Amount of holes."</para>
    /// labels<para>"CoverToolNumberOfHoles"</para></remarks>
    /// <seealso href="http://w3id.org/emmo-hpo/hpo#CoverToolNumberOfHoles">http://w3id.org/emmo-hpo/hpo#CoverToolNumberOfHoles</seealso>
    let CoverToolNumberOfHoles =
        Prefixed_Name(hpo, "CoverToolNumberOfHoles") |> PrefixedName

    /// <summary>
    ///   <para>hpo:CoverToolProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"CoverToolProperty"</para></remarks>
    /// <seealso href="http://w3id.org/emmo-hpo/hpo#CoverToolProperty">http://w3id.org/emmo-hpo/hpo#CoverToolProperty</seealso>
    let CoverToolProperty = Prefixed_Name(hpo, "CoverToolProperty") |> PrefixedName

    /// <summary>
    ///   <para>hpo:CoverToolSizeOfHoles</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Average diameter of holes."</para>
    /// labels<para>"CoverToolSizeOfHoles"</para></remarks>
    /// <seealso href="http://w3id.org/emmo-hpo/hpo#CoverToolSizeOfHoles">http://w3id.org/emmo-hpo/hpo#CoverToolSizeOfHoles</seealso>
    let CoverToolSizeOfHoles =
        Prefixed_Name(hpo, "CoverToolSizeOfHoles") |> PrefixedName

    /// <summary>
    ///   <para>hpo:CoverToolWidth</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Width (contributing to the size of the tool)."</para>
    /// labels<para>"CoverToolWidth"</para></remarks>
    /// <seealso href="http://w3id.org/emmo-hpo/hpo#CoverToolWidth">http://w3id.org/emmo-hpo/hpo#CoverToolWidth</seealso>
    let CoverToolWidth = Prefixed_Name(hpo, "CoverToolWidth") |> PrefixedName
    /// <summary>
    ///   <para>hpo:Crosslinked</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A class of structures characterised by a bond or a short sequence of bonds connecting different macromolecules."</para>
    /// labels<para>"Crosslinked"</para></remarks>
    /// <seealso href="http://w3id.org/emmo-hpo/hpo#Crosslinked">http://w3id.org/emmo-hpo/hpo#Crosslinked</seealso>
    let Crosslinked = Prefixed_Name(hpo, "Crosslinked") |> PrefixedName
    /// <summary>
    ///   <para>hpo:CrosslinkedPolymer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A polymer whose molecular structure is characterised by additional covalent bonds connecting several chains together."</para>
    /// labels<para>"CrosslinkedPolymer"</para></remarks>
    /// <seealso href="http://w3id.org/emmo-hpo/hpo#CrosslinkedPolymer">http://w3id.org/emmo-hpo/hpo#CrosslinkedPolymer</seealso>
    let CrosslinkedPolymer = Prefixed_Name(hpo, "CrosslinkedPolymer") |> PrefixedName

    /// <summary>
    ///   <para>hpo:DegassingStepDuration</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Duration of the degassing."</para>
    /// labels<para>"DegassingStepDuration"</para></remarks>
    /// <seealso href="http://w3id.org/emmo-hpo/hpo#DegassingStepDuration">http://w3id.org/emmo-hpo/hpo#DegassingStepDuration</seealso>
    let DegassingStepDuration =
        Prefixed_Name(hpo, "DegassingStepDuration") |> PrefixedName

    /// <summary>
    ///   <para>hpo:Elastomer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A polymer characterised by weak intermolecular forces and viscoelasticity."</para>
    /// labels<para>"Elastomer"</para></remarks>
    /// <seealso href="http://w3id.org/emmo-hpo/hpo#Elastomer">http://w3id.org/emmo-hpo/hpo#Elastomer</seealso>
    let Elastomer = Prefixed_Name(hpo, "Elastomer") |> PrefixedName
    /// <summary>
    ///   <para>hpo:ElongationAtBreak</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Ratio between increased length and initial length after breakage."</para>
    /// labels<para>"ElongationAtBreak"</para></remarks>
    /// <seealso href="http://w3id.org/emmo-hpo/hpo#ElongationAtBreak">http://w3id.org/emmo-hpo/hpo#ElongationAtBreak</seealso>
    let ElongationAtBreak = Prefixed_Name(hpo, "ElongationAtBreak") |> PrefixedName
    /// <summary>
    ///   <para>hpo:Fibre</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A polymer characterised by strong intermolecular forces and high tensile strength."</para>
    /// labels<para>"Fibre"</para></remarks>
    /// <seealso href="http://w3id.org/emmo-hpo/hpo#Fibre">http://w3id.org/emmo-hpo/hpo#Fibre</seealso>
    let Fibre = Prefixed_Name(hpo, "Fibre") |> PrefixedName
    /// <summary>
    ///   <para>hpo:FibreDensity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Mass per unit volume of the facbric."</para>
    /// labels<para>"FibreDensity"</para></remarks>
    /// <seealso href="http://w3id.org/emmo-hpo/hpo#FibreDensity">http://w3id.org/emmo-hpo/hpo#FibreDensity</seealso>
    let FibreDensity = Prefixed_Name(hpo, "FibreDensity") |> PrefixedName
    /// <summary>
    ///   <para>hpo:FibreDiameter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Diameter of the fibre composing the fabric."</para>
    /// labels<para>"FibreDiameter"</para></remarks>
    /// <seealso href="http://w3id.org/emmo-hpo/hpo#FibreDiameter">http://w3id.org/emmo-hpo/hpo#FibreDiameter</seealso>
    let FibreDiameter = Prefixed_Name(hpo, "FibreDiameter") |> PrefixedName
    /// <summary>
    ///   <para>hpo:FibreIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Commercial name of the applied consumable (product), differentiating available product providers and product lots."</para>
    /// labels<para>"FibreIdentifier"</para></remarks>
    /// <seealso href="http://w3id.org/emmo-hpo/hpo#FibreIdentifier">http://w3id.org/emmo-hpo/hpo#FibreIdentifier</seealso>
    let FibreIdentifier = Prefixed_Name(hpo, "FibreIdentifier") |> PrefixedName
    /// <summary>
    ///   <para>hpo:FibreVolumeContent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Ratio between the volume of fibre and the volume of the composite laminate."</para>
    /// labels<para>"FibreVolumeContent"</para></remarks>
    /// <seealso href="http://w3id.org/emmo-hpo/hpo#FibreVolumeContent">http://w3id.org/emmo-hpo/hpo#FibreVolumeContent</seealso>
    let FibreVolumeContent = Prefixed_Name(hpo, "FibreVolumeContent") |> PrefixedName
    /// <summary>
    ///   <para>hpo:Filler</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A material (usually low cost) added to a resin to extend it, or give special properties"</para>
    /// labels<para>"Filler"</para></remarks>
    /// <seealso href="http://w3id.org/emmo-hpo/hpo#Filler">http://w3id.org/emmo-hpo/hpo#Filler</seealso>
    let Filler = Prefixed_Name(hpo, "Filler") |> PrefixedName
    /// <summary>
    ///   <para>hpo:FinalStepPressure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Final pressure of the container during step."</para>
    /// labels<para>"FinalStepPressure"</para></remarks>
    /// <seealso href="http://w3id.org/emmo-hpo/hpo#FinalStepPressure">http://w3id.org/emmo-hpo/hpo#FinalStepPressure</seealso>
    let FinalStepPressure = Prefixed_Name(hpo, "FinalStepPressure") |> PrefixedName

    /// <summary>
    ///   <para>hpo:FinalStepTemperature</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Final temperature of the container during step."</para>
    /// labels<para>"FinalStepTemperature"</para></remarks>
    /// <seealso href="http://w3id.org/emmo-hpo/hpo#FinalStepTemperature">http://w3id.org/emmo-hpo/hpo#FinalStepTemperature</seealso>
    let FinalStepTemperature =
        Prefixed_Name(hpo, "FinalStepTemperature") |> PrefixedName

    /// <summary>
    ///   <para>hpo:FlexualModulus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Tangent of the stress-strain curve under flexural stress."</para>
    /// labels<para>"FlexualModulus"</para></remarks>
    /// <seealso href="http://w3id.org/emmo-hpo/hpo#FlexualModulus">http://w3id.org/emmo-hpo/hpo#FlexualModulus</seealso>
    let FlexualModulus = Prefixed_Name(hpo, "FlexualModulus") |> PrefixedName
    /// <summary>
    ///   <para>hpo:FlexuralStrength</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Maximum value of the stress-strain curve under flexural stress."</para>
    /// labels<para>"FlexuralStrength"</para></remarks>
    /// <seealso href="http://w3id.org/emmo-hpo/hpo#FlexuralStrength">http://w3id.org/emmo-hpo/hpo#FlexuralStrength</seealso>
    let FlexuralStrength = Prefixed_Name(hpo, "FlexuralStrength") |> PrefixedName
    /// <summary>
    ///   <para>hpo:FormulatedResin</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A manufactured mixture of a resin and ingredients."</para>
    /// labels<para>"FormulatedResin"</para></remarks>
    /// <seealso href="http://w3id.org/emmo-hpo/hpo#FormulatedResin">http://w3id.org/emmo-hpo/hpo#FormulatedResin</seealso>
    let FormulatedResin = Prefixed_Name(hpo, "FormulatedResin") |> PrefixedName

    /// <summary>
    ///   <para>hpo:FormulatedResinCuringTemperature</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Temperature required to start the process of cure of the resin."</para>
    /// labels<para>"FormulatedResinCuringTemperature"</para></remarks>
    /// <seealso href="http://w3id.org/emmo-hpo/hpo#FormulatedResinCuringTemperature">http://w3id.org/emmo-hpo/hpo#FormulatedResinCuringTemperature</seealso>
    let FormulatedResinCuringTemperature =
        Prefixed_Name(hpo, "FormulatedResinCuringTemperature") |> PrefixedName

    /// <summary>
    ///   <para>hpo:FormulatedResinCuringTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Time at which the curing temperature must be held to achieve a certain level of cure."</para>
    /// labels<para>"FormulatedResinCuringTime"</para></remarks>
    /// <seealso href="http://w3id.org/emmo-hpo/hpo#FormulatedResinCuringTime">http://w3id.org/emmo-hpo/hpo#FormulatedResinCuringTime</seealso>
    let FormulatedResinCuringTime =
        Prefixed_Name(hpo, "FormulatedResinCuringTime") |> PrefixedName

    /// <summary>
    ///   <para>hpo:FormulatedResinGlassTransitionTemperature</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Process in which a polymer melt changes on cooling to a polymer glass or a polymer glass changes on heating to a polymer melt."</para>
    /// labels<para>"FormulatedResinGlassTransitionTemperature"</para></remarks>
    /// <seealso href="http://w3id.org/emmo-hpo/hpo#FormulatedResinGlassTransitionTemperature">http://w3id.org/emmo-hpo/hpo#FormulatedResinGlassTransitionTemperature</seealso>
    let FormulatedResinGlassTransitionTemperature =
        Prefixed_Name(hpo, "FormulatedResinGlassTransitionTemperature") |> PrefixedName

    /// <summary>
    ///   <para>hpo:FormulatedResinProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A collection of the properties of formulated resins."</para>
    /// labels<para>"FormulatedResinProperty"</para></remarks>
    /// <seealso href="http://w3id.org/emmo-hpo/hpo#FormulatedResinProperty">http://w3id.org/emmo-hpo/hpo#FormulatedResinProperty</seealso>
    let FormulatedResinProperty =
        Prefixed_Name(hpo, "FormulatedResinProperty") |> PrefixedName

    /// <summary>
    ///   <para>hpo:FormulatedResinSpecificCondensateFormation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Mass of water released per mass of resin throughout the applied chemical (curing) reaction."</para>
    /// labels<para>"FormulatedResinSpecificCondensateFormation"</para></remarks>
    /// <seealso href="http://w3id.org/emmo-hpo/hpo#FormulatedResinSpecificCondensateFormation">http://w3id.org/emmo-hpo/hpo#FormulatedResinSpecificCondensateFormation</seealso>
    let FormulatedResinSpecificCondensateFormation =
        Prefixed_Name(hpo, "FormulatedResinSpecificCondensateFormation") |> PrefixedName

    /// <summary>
    ///   <para>hpo:FormulatedResinViscosity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Dynamic viscosity of the resin."</para>
    /// labels<para>"FormulatedResinViscosity"</para></remarks>
    /// <seealso href="http://w3id.org/emmo-hpo/hpo#FormulatedResinViscosity">http://w3id.org/emmo-hpo/hpo#FormulatedResinViscosity</seealso>
    let FormulatedResinViscosity =
        Prefixed_Name(hpo, "FormulatedResinViscosity") |> PrefixedName

    /// <summary>
    ///   <para>hpo:FormulatedResinWaterContent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Weight percentage of (dissolved and freezable) water in the base resin."</para>
    /// labels<para>"FormulatedResinWaterContent"</para></remarks>
    /// <seealso href="http://w3id.org/emmo-hpo/hpo#FormulatedResinWaterContent">http://w3id.org/emmo-hpo/hpo#FormulatedResinWaterContent</seealso>
    let FormulatedResinWaterContent =
        Prefixed_Name(hpo, "FormulatedResinWaterContent") |> PrefixedName

    /// <summary>
    ///   <para>hpo:GlassTransitionTemperature</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Temperature for transition from glassy state into a viscous one."</para>
    /// labels<para>"GlassTransitionTemperature"</para></remarks>
    /// <seealso href="http://w3id.org/emmo-hpo/hpo#GlassTransitionTemperature">http://w3id.org/emmo-hpo/hpo#GlassTransitionTemperature</seealso>
    let GlassTransitionTemperature =
        Prefixed_Name(hpo, "GlassTransitionTemperature") |> PrefixedName

    /// <summary>
    ///   <para>hpo:HeatingRateDuringStep</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Heating rate during step."</para>
    /// labels<para>"HeatingRateDuringStep"</para></remarks>
    /// <seealso href="http://w3id.org/emmo-hpo/hpo#HeatingRateDuringStep">http://w3id.org/emmo-hpo/hpo#HeatingRateDuringStep</seealso>
    let HeatingRateDuringStep =
        Prefixed_Name(hpo, "HeatingRateDuringStep") |> PrefixedName

    /// <summary>
    ///   <para>hpo:HomoPolymer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A polymer derived from the polymerisation of one kind of monomer."</para>
    /// labels<para>"HomoPolymer"</para></remarks>
    /// <seealso href="http://w3id.org/emmo-hpo/hpo#HomoPolymer">http://w3id.org/emmo-hpo/hpo#HomoPolymer</seealso>
    let HomoPolymer = Prefixed_Name(hpo, "HomoPolymer") |> PrefixedName
    /// <summary>
    ///   <para>hpo:InitialStepPressure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Pressure during step."</para>
    /// labels<para>"InitialStepPressure"</para></remarks>
    /// <seealso href="http://w3id.org/emmo-hpo/hpo#InitialStepPressure">http://w3id.org/emmo-hpo/hpo#InitialStepPressure</seealso>
    let InitialStepPressure = Prefixed_Name(hpo, "InitialStepPressure") |> PrefixedName

    /// <summary>
    ///   <para>hpo:InitialStepTemperature</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Initial temperature of the container during step."</para>
    /// labels<para>"InitialStepTemperature"</para></remarks>
    /// <seealso href="http://w3id.org/emmo-hpo/hpo#InitialStepTemperature">http://w3id.org/emmo-hpo/hpo#InitialStepTemperature</seealso>
    let InitialStepTemperature =
        Prefixed_Name(hpo, "InitialStepTemperature") |> PrefixedName

    /// <summary>
    ///   <para>hpo:InterlaminarShearStrength</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Mechanical property associated with the matrix-fibre interaction."</para>
    /// labels<para>"InterlaminarShearStrength"</para></remarks>
    /// <seealso href="http://w3id.org/emmo-hpo/hpo#InterlaminarShearStrength">http://w3id.org/emmo-hpo/hpo#InterlaminarShearStrength</seealso>
    let InterlaminarShearStrength =
        Prefixed_Name(hpo, "InterlaminarShearStrength") |> PrefixedName

    /// <summary>
    ///   <para>hpo:Laminate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The structure resulting from the curing of multiple stacked prepreg plies."</para>
    /// labels<para>"Laminate"</para></remarks>
    /// <seealso href="http://w3id.org/emmo-hpo/hpo#Laminate">http://w3id.org/emmo-hpo/hpo#Laminate</seealso>
    let Laminate = Prefixed_Name(hpo, "Laminate") |> PrefixedName
    /// <summary>
    ///   <para>hpo:Linear</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A class of structures characterised by a linear skeleton."</para>
    /// labels<para>"Linear"</para></remarks>
    /// <seealso href="http://w3id.org/emmo-hpo/hpo#Linear">http://w3id.org/emmo-hpo/hpo#Linear</seealso>
    let Linear = Prefixed_Name(hpo, "Linear") |> PrefixedName
    /// <summary>
    ///   <para>hpo:LinearPolymer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A polymer whose molecular structure is characterised by a linear chain of repeating units."</para>
    /// labels<para>"LinearPolymer"</para></remarks>
    /// <seealso href="http://w3id.org/emmo-hpo/hpo#LinearPolymer">http://w3id.org/emmo-hpo/hpo#LinearPolymer</seealso>
    let LinearPolymer = Prefixed_Name(hpo, "LinearPolymer") |> PrefixedName
    /// <summary>
    ///   <para>hpo:ManufacturingLine</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A manufacturing line is a set of sequential operations in a factory where materials are processed, assembled, and/or refined to produce a finished product or an intermediate product for further processing."</para>
    /// labels<para>"ManufacturingLine"</para></remarks>
    /// <seealso href="http://w3id.org/emmo-hpo/hpo#ManufacturingLine">http://w3id.org/emmo-hpo/hpo#ManufacturingLine</seealso>
    let ManufacturingLine = Prefixed_Name(hpo, "ManufacturingLine") |> PrefixedName
    /// <summary>
    ///   <para>hpo:Monomer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A single molecule that reacts with like or unlike molecules to form a polymer. "</para>
    /// labels<para>"Monomer"</para></remarks>
    /// <seealso href="http://w3id.org/emmo-hpo/hpo#Monomer">http://w3id.org/emmo-hpo/hpo#Monomer</seealso>
    let Monomer = Prefixed_Name(hpo, "Monomer") |> PrefixedName
    /// <summary>
    ///   <para>hpo:MouldReleaseLayer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A lubricant used to prevent a part from sticking to a mold surface."</para>
    /// labels<para>"MouldReleaseLayer"</para></remarks>
    /// <seealso href="http://w3id.org/emmo-hpo/hpo#MouldReleaseLayer">http://w3id.org/emmo-hpo/hpo#MouldReleaseLayer</seealso>
    let MouldReleaseLayer = Prefixed_Name(hpo, "MouldReleaseLayer") |> PrefixedName

    /// <summary>
    ///   <para>hpo:MouldReleaseLayerIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Commercial name of the applied consumable (product), differentiating available product providers and product lots."</para>
    /// labels<para>"MouldReleaseLayerIdentifier"</para></remarks>
    /// <seealso href="http://w3id.org/emmo-hpo/hpo#MouldReleaseLayerIdentifier">http://w3id.org/emmo-hpo/hpo#MouldReleaseLayerIdentifier</seealso>
    let MouldReleaseLayerIdentifier =
        Prefixed_Name(hpo, "MouldReleaseLayerIdentifier") |> PrefixedName

    /// <summary>
    ///   <para>hpo:MouldReleaseLayerProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A collection of the properties of the release layer of a mould or tool."</para>
    /// labels<para>"MouldReleaseLayerProperty"</para></remarks>
    /// <seealso href="http://w3id.org/emmo-hpo/hpo#MouldReleaseLayerProperty">http://w3id.org/emmo-hpo/hpo#MouldReleaseLayerProperty</seealso>
    let MouldReleaseLayerProperty =
        Prefixed_Name(hpo, "MouldReleaseLayerProperty") |> PrefixedName

    /// <summary>
    ///   <para>hpo:MouldTool</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An enclosed cavity or open form from which a composite component takes its shape, size and exterior surface appearance (also known as a tool)."</para>
    /// labels<para>"MouldTool"</para></remarks>
    /// <seealso href="http://w3id.org/emmo-hpo/hpo#MouldTool">http://w3id.org/emmo-hpo/hpo#MouldTool</seealso>
    let MouldTool = Prefixed_Name(hpo, "MouldTool") |> PrefixedName
    /// <summary>
    ///   <para>hpo:MouldToolLength</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Length (contributing to the size of the tool)."</para>
    /// labels<para>"MouldToolLength"</para></remarks>
    /// <seealso href="http://w3id.org/emmo-hpo/hpo#MouldToolLength">http://w3id.org/emmo-hpo/hpo#MouldToolLength</seealso>
    let MouldToolLength = Prefixed_Name(hpo, "MouldToolLength") |> PrefixedName
    /// <summary>
    ///   <para>hpo:MouldToolProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A collection of the properties of moulds or tools."</para>
    /// labels<para>"MouldToolProperty"</para></remarks>
    /// <seealso href="http://w3id.org/emmo-hpo/hpo#MouldToolProperty">http://w3id.org/emmo-hpo/hpo#MouldToolProperty</seealso>
    let MouldToolProperty = Prefixed_Name(hpo, "MouldToolProperty") |> PrefixedName

    /// <summary>
    ///   <para>hpo:MouldToolSurfaceRoughness</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Arithmetic average of the absolute values of the profile height deviations from the mean line, recorded within the evaluation length."</para>
    /// labels<para>"MouldToolSurfaceRoughness"</para></remarks>
    /// <seealso href="http://w3id.org/emmo-hpo/hpo#MouldToolSurfaceRoughness">http://w3id.org/emmo-hpo/hpo#MouldToolSurfaceRoughness</seealso>
    let MouldToolSurfaceRoughness =
        Prefixed_Name(hpo, "MouldToolSurfaceRoughness") |> PrefixedName

    /// <summary>
    ///   <para>hpo:MouldToolWidth</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Width (contributing to the size of the tool)."</para>
    /// labels<para>"MouldToolWidth"</para></remarks>
    /// <seealso href="http://w3id.org/emmo-hpo/hpo#MouldToolWidth">http://w3id.org/emmo-hpo/hpo#MouldToolWidth</seealso>
    let MouldToolWidth = Prefixed_Name(hpo, "MouldToolWidth") |> PrefixedName
    /// <summary>
    ///   <para>hpo:NaturalPolymer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A naturally occurring polymer produced by living organisms."</para>
    /// labels<para>"NaturalPolymer"</para></remarks>
    /// <seealso href="http://w3id.org/emmo-hpo/hpo#NaturalPolymer">http://w3id.org/emmo-hpo/hpo#NaturalPolymer</seealso>
    let NaturalPolymer = Prefixed_Name(hpo, "NaturalPolymer") |> PrefixedName
    /// <summary>
    ///   <para>hpo:PartsTurnover</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Parts manufactured per minute."</para>
    /// labels<para>"PartsTurnover"</para></remarks>
    /// <seealso href="http://w3id.org/emmo-hpo/hpo#PartsTurnover">http://w3id.org/emmo-hpo/hpo#PartsTurnover</seealso>
    let PartsTurnover = Prefixed_Name(hpo, "PartsTurnover") |> PrefixedName

    /// <summary>
    ///   <para>hpo:PorosityInferredFromDensity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"After cutting a test sample out of the specimen to be tested, gravimetric and volumetric findings are used to calculate an (average) density that is compared to the density of a qualified (reference) “in order (i.o.)” specimen."</para>
    /// labels<para>"PorosityInferredFromDensity"</para></remarks>
    /// <seealso href="http://w3id.org/emmo-hpo/hpo#PorosityInferredFromDensity">http://w3id.org/emmo-hpo/hpo#PorosityInferredFromDensity</seealso>
    let PorosityInferredFromDensity =
        Prefixed_Name(hpo, "PorosityInferredFromDensity") |> PrefixedName

    /// <summary>
    ///   <para>hpo:Prepreg</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A factory-made combination of reactive resins and reinforcing fibres, plus other necessary additive chemicals, ready to be moulded."</para>
    /// labels<para>"Prepreg"</para></remarks>
    /// <seealso href="http://w3id.org/emmo-hpo/hpo#Prepreg">http://w3id.org/emmo-hpo/hpo#Prepreg</seealso>
    let Prepreg = Prefixed_Name(hpo, "Prepreg") |> PrefixedName
    /// <summary>
    ///   <para>hpo:PrepregCuringDegree</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Percentage of the (feasible) curing (that is no more available for cross-linking reaction(s))"</para>
    /// labels<para>"PrepregCuringDegree"</para></remarks>
    /// <seealso href="http://w3id.org/emmo-hpo/hpo#PrepregCuringDegree">http://w3id.org/emmo-hpo/hpo#PrepregCuringDegree</seealso>
    let PrepregCuringDegree = Prefixed_Name(hpo, "PrepregCuringDegree") |> PrefixedName
    /// <summary>
    ///   <para>hpo:PrepregDensity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Mass per unit volume of the prepreg."</para>
    /// labels<para>"PrepregDensity"</para></remarks>
    /// <seealso href="http://w3id.org/emmo-hpo/hpo#PrepregDensity">http://w3id.org/emmo-hpo/hpo#PrepregDensity</seealso>
    let PrepregDensity = Prefixed_Name(hpo, "PrepregDensity") |> PrefixedName

    /// <summary>
    ///   <para>hpo:PrepregExpectedElongationAtBreak</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"EXPECTED ratio between increased length and initial length after breakage AFTER CURING."</para>
    /// labels<para>"PrepregExpectedElongationAtBreak"</para></remarks>
    /// <seealso href="http://w3id.org/emmo-hpo/hpo#PrepregExpectedElongationAtBreak">http://w3id.org/emmo-hpo/hpo#PrepregExpectedElongationAtBreak</seealso>
    let PrepregExpectedElongationAtBreak =
        Prefixed_Name(hpo, "PrepregExpectedElongationAtBreak") |> PrefixedName

    /// <summary>
    ///   <para>hpo:PrepregExpectedFlexualModulus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"EXPECTED Tangent of the stress-strain curve under flexural stress AFTER CURING."</para>
    /// labels<para>"PrepregExpectedFlexualModulus"</para></remarks>
    /// <seealso href="http://w3id.org/emmo-hpo/hpo#PrepregExpectedFlexualModulus">http://w3id.org/emmo-hpo/hpo#PrepregExpectedFlexualModulus</seealso>
    let PrepregExpectedFlexualModulus =
        Prefixed_Name(hpo, "PrepregExpectedFlexualModulus") |> PrefixedName

    /// <summary>
    ///   <para>hpo:PrepregExpectedFlexuralStrength</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"EXPECTED Maximum value of the stress-strain curve under flexural stress AFTER CURING."</para>
    /// labels<para>"PrepregExpectedFlexuralStrength"</para></remarks>
    /// <seealso href="http://w3id.org/emmo-hpo/hpo#PrepregExpectedFlexuralStrength">http://w3id.org/emmo-hpo/hpo#PrepregExpectedFlexuralStrength</seealso>
    let PrepregExpectedFlexuralStrength =
        Prefixed_Name(hpo, "PrepregExpectedFlexuralStrength") |> PrefixedName

    /// <summary>
    ///   <para>hpo:PrepregExpectedTensileModulus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"EXPECTED Tangent of the stress-strain curve under tensile stress AFTER CURING."</para>
    /// labels<para>"PrepregExpectedTensileModulus"</para></remarks>
    /// <seealso href="http://w3id.org/emmo-hpo/hpo#PrepregExpectedTensileModulus">http://w3id.org/emmo-hpo/hpo#PrepregExpectedTensileModulus</seealso>
    let PrepregExpectedTensileModulus =
        Prefixed_Name(hpo, "PrepregExpectedTensileModulus") |> PrefixedName

    /// <summary>
    ///   <para>hpo:PrepregExpectedTensileStrength</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"EXPECTED Maximum value of the stress-strain curve under tensile stress AFTER CURING."</para>
    /// labels<para>"PrepregExpectedTensileStrength"</para></remarks>
    /// <seealso href="http://w3id.org/emmo-hpo/hpo#PrepregExpectedTensileStrength">http://w3id.org/emmo-hpo/hpo#PrepregExpectedTensileStrength</seealso>
    let PrepregExpectedTensileStrength =
        Prefixed_Name(hpo, "PrepregExpectedTensileStrength") |> PrefixedName

    /// <summary>
    ///   <para>hpo:PrepregFibreVolumeContent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Ratio between the volume of fibre and the volume of the composite."</para>
    /// labels<para>"PrepregFibreVolumeContent"</para></remarks>
    /// <seealso href="http://w3id.org/emmo-hpo/hpo#PrepregFibreVolumeContent">http://w3id.org/emmo-hpo/hpo#PrepregFibreVolumeContent</seealso>
    let PrepregFibreVolumeContent =
        Prefixed_Name(hpo, "PrepregFibreVolumeContent") |> PrefixedName

    /// <summary>
    ///   <para>hpo:PrepregGlassTransitionTemperature</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Characteristic temperature (range) of the process in which a polymer melt changes on cooling to a polymer glass or a polymer glass changes on heating to a polymer melt."</para>
    /// labels<para>"PrepregGlassTransitionTemperature"</para></remarks>
    /// <seealso href="http://w3id.org/emmo-hpo/hpo#PrepregGlassTransitionTemperature">http://w3id.org/emmo-hpo/hpo#PrepregGlassTransitionTemperature</seealso>
    let PrepregGlassTransitionTemperature =
        Prefixed_Name(hpo, "PrepregGlassTransitionTemperature") |> PrefixedName

    /// <summary>
    ///   <para>hpo:PrepregLine</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A manufacturing line processing a prepreg for later use."</para>
    /// labels<para>"PrepregLine"</para></remarks>
    /// <seealso href="http://w3id.org/emmo-hpo/hpo#PrepregLine">http://w3id.org/emmo-hpo/hpo#PrepregLine</seealso>
    let PrepregLine = Prefixed_Name(hpo, "PrepregLine") |> PrefixedName
    /// <summary>
    ///   <para>hpo:PrepregPiece</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A prepreg a piece cut from a prepreg roll, which can be stacked."</para>
    /// labels<para>"PrepregPiece"</para></remarks>
    /// <seealso href="http://w3id.org/emmo-hpo/hpo#PrepregPiece">http://w3id.org/emmo-hpo/hpo#PrepregPiece</seealso>
    let PrepregPiece = Prefixed_Name(hpo, "PrepregPiece") |> PrefixedName
    /// <summary>
    ///   <para>hpo:PrepregProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A collection of the properties of prepregs."</para>
    /// labels<para>"PrepregProperty"</para></remarks>
    /// <seealso href="http://w3id.org/emmo-hpo/hpo#PrepregProperty">http://w3id.org/emmo-hpo/hpo#PrepregProperty</seealso>
    let PrepregProperty = Prefixed_Name(hpo, "PrepregProperty") |> PrefixedName
    /// <summary>
    ///   <para>hpo:PrepregRoll</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A roll of prepreg material."</para>
    /// labels<para>"PrepregRoll"</para></remarks>
    /// <seealso href="http://w3id.org/emmo-hpo/hpo#PrepregRoll">http://w3id.org/emmo-hpo/hpo#PrepregRoll</seealso>
    let PrepregRoll = Prefixed_Name(hpo, "PrepregRoll") |> PrefixedName

    /// <summary>
    ///   <para>hpo:PrepregSpecificCondensateFormation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Mass of water released per mass of prepreg throughout the applied chemical (curing) reaction."</para>
    /// labels<para>"PrepregSpecificCondensateFormation"</para></remarks>
    /// <seealso href="http://w3id.org/emmo-hpo/hpo#PrepregSpecificCondensateFormation">http://w3id.org/emmo-hpo/hpo#PrepregSpecificCondensateFormation</seealso>
    let PrepregSpecificCondensateFormation =
        Prefixed_Name(hpo, "PrepregSpecificCondensateFormation") |> PrefixedName

    /// <summary>
    ///   <para>hpo:PrepregThickness</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Thickness of the prepreg."</para>
    /// labels<para>"PrepregThickness"</para></remarks>
    /// <seealso href="http://w3id.org/emmo-hpo/hpo#PrepregThickness">http://w3id.org/emmo-hpo/hpo#PrepregThickness</seealso>
    let PrepregThickness = Prefixed_Name(hpo, "PrepregThickness") |> PrefixedName
    /// <summary>
    ///   <para>hpo:PrepregWaterContent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Weight percentage of water in the prepreg (that can be dried and is not formed during the curing reaction)."</para>
    /// labels<para>"PrepregWaterContent"</para></remarks>
    /// <seealso href="http://w3id.org/emmo-hpo/hpo#PrepregWaterContent">http://w3id.org/emmo-hpo/hpo#PrepregWaterContent</seealso>
    let PrepregWaterContent = Prefixed_Name(hpo, "PrepregWaterContent") |> PrefixedName

    /// <summary>
    ///   <para>hpo:PrepregWaterDiffusionCoefficient</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Effective and anisotropic proportionality constant between the molar (or mass) flux due to molecular diffusion (out of the prepreg specimen)."</para>
    /// labels<para>"PrepregWaterDiffusionCoefficient"</para></remarks>
    /// <seealso href="http://w3id.org/emmo-hpo/hpo#PrepregWaterDiffusionCoefficient">http://w3id.org/emmo-hpo/hpo#PrepregWaterDiffusionCoefficient</seealso>
    let PrepregWaterDiffusionCoefficient =
        Prefixed_Name(hpo, "PrepregWaterDiffusionCoefficient") |> PrefixedName

    /// <summary>
    ///   <para>hpo:PrepregWidth</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Width of the prepreg."</para>
    /// labels<para>"PrepregWidth"</para></remarks>
    /// <seealso href="http://w3id.org/emmo-hpo/hpo#PrepregWidth">http://w3id.org/emmo-hpo/hpo#PrepregWidth</seealso>
    let PrepregWidth = Prefixed_Name(hpo, "PrepregWidth") |> PrefixedName
    /// <summary>
    ///   <para>hpo:Prepregging</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The process of prepreg manufacturing."</para>
    /// labels<para>"Prepregging"</para></remarks>
    /// <seealso href="http://w3id.org/emmo-hpo/hpo#Prepregging">http://w3id.org/emmo-hpo/hpo#Prepregging</seealso>
    let Prepregging = Prefixed_Name(hpo, "Prepregging") |> PrefixedName
    /// <summary>
    ///   <para>hpo:ReleaseLayer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A specially formulated material placed between the mold and uncured resin/fiber (usually sprayed or painted on the mold surface) to prevent permanent bonding between the two during cure and facilitates demolding after cure."</para>
    /// labels<para>"ReleaseLayer"</para></remarks>
    /// <seealso href="http://w3id.org/emmo-hpo/hpo#ReleaseLayer">http://w3id.org/emmo-hpo/hpo#ReleaseLayer</seealso>
    let ReleaseLayer = Prefixed_Name(hpo, "ReleaseLayer") |> PrefixedName
    /// <summary>
    ///   <para>hpo:Resin</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Soft solid or highly viscous substance, usually containing prepolymers with reactive groups."</para>
    /// labels<para>"Resin"</para></remarks>
    /// <seealso href="http://w3id.org/emmo-hpo/hpo#Resin">http://w3id.org/emmo-hpo/hpo#Resin</seealso>
    let Resin = Prefixed_Name(hpo, "Resin") |> PrefixedName
    /// <summary>
    ///   <para>hpo:ResinComposition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Total composition of the resin."</para>
    /// labels<para>"ResinComposition"</para></remarks>
    /// <seealso href="http://w3id.org/emmo-hpo/hpo#ResinComposition">http://w3id.org/emmo-hpo/hpo#ResinComposition</seealso>
    let ResinComposition = Prefixed_Name(hpo, "ResinComposition") |> PrefixedName
    /// <summary>
    ///   <para>hpo:ResinDensity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Mass density of the resin."</para>
    /// labels<para>"ResinDensity"</para></remarks>
    /// <seealso href="http://w3id.org/emmo-hpo/hpo#ResinDensity">http://w3id.org/emmo-hpo/hpo#ResinDensity</seealso>
    let ResinDensity = Prefixed_Name(hpo, "ResinDensity") |> PrefixedName
    /// <summary>
    ///   <para>hpo:ResinIngredient</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Intermediate mixture to make a formulation that allows formulated resin differentiation."</para>
    /// labels<para>"ResinIngredient"</para></remarks>
    /// <seealso href="http://w3id.org/emmo-hpo/hpo#ResinIngredient">http://w3id.org/emmo-hpo/hpo#ResinIngredient</seealso>
    let ResinIngredient = Prefixed_Name(hpo, "ResinIngredient") |> PrefixedName
    /// <summary>
    ///   <para>hpo:ResinMixer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A batch resin mixer."</para>
    /// labels<para>"ResinMixer"</para></remarks>
    /// <seealso href="http://w3id.org/emmo-hpo/hpo#ResinMixer">http://w3id.org/emmo-hpo/hpo#ResinMixer</seealso>
    let ResinMixer = Prefixed_Name(hpo, "ResinMixer") |> PrefixedName

    /// <summary>
    ///   <para>hpo:ResinMolecularWeight</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Average molecular weight of the main resin molecular consituents."</para>
    /// labels<para>"ResinMolecularWeight"</para></remarks>
    /// <seealso href="http://w3id.org/emmo-hpo/hpo#ResinMolecularWeight">http://w3id.org/emmo-hpo/hpo#ResinMolecularWeight</seealso>
    let ResinMolecularWeight =
        Prefixed_Name(hpo, "ResinMolecularWeight") |> PrefixedName

    /// <summary>
    ///   <para>hpo:ResinPreparation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Preparing a resin involves mixing the precursor (monomers) with a hardener or a catalyst, fillers, and additives."</para>
    /// labels<para>"ResinPreparation"</para></remarks>
    /// <seealso href="http://w3id.org/emmo-hpo/hpo#ResinPreparation">http://w3id.org/emmo-hpo/hpo#ResinPreparation</seealso>
    let ResinPreparation = Prefixed_Name(hpo, "ResinPreparation") |> PrefixedName
    /// <summary>
    ///   <para>hpo:ResinProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A collection of the properties of resins."</para>
    /// labels<para>"ResinProperty"</para></remarks>
    /// <seealso href="http://w3id.org/emmo-hpo/hpo#ResinProperty">http://w3id.org/emmo-hpo/hpo#ResinProperty</seealso>
    let ResinProperty = Prefixed_Name(hpo, "ResinProperty") |> PrefixedName
    /// <summary>
    ///   <para>hpo:ResinReactivity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Maximum amount of energy released in case of complete conversion."</para>
    /// labels<para>"ResinReactivity"</para></remarks>
    /// <seealso href="http://w3id.org/emmo-hpo/hpo#ResinReactivity">http://w3id.org/emmo-hpo/hpo#ResinReactivity</seealso>
    let ResinReactivity = Prefixed_Name(hpo, "ResinReactivity") |> PrefixedName
    /// <summary>
    ///   <para>hpo:ResinViscosity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Viscosity at 25°C."</para>
    /// labels<para>"ResinViscosity"</para></remarks>
    /// <seealso href="http://w3id.org/emmo-hpo/hpo#ResinViscosity">http://w3id.org/emmo-hpo/hpo#ResinViscosity</seealso>
    let ResinViscosity = Prefixed_Name(hpo, "ResinViscosity") |> PrefixedName
    /// <summary>
    ///   <para>hpo:ResinWaterContent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Percentage of water in the base resin."</para>
    /// labels<para>"ResinWaterContent"</para></remarks>
    /// <seealso href="http://w3id.org/emmo-hpo/hpo#ResinWaterContent">http://w3id.org/emmo-hpo/hpo#ResinWaterContent</seealso>
    let ResinWaterContent = Prefixed_Name(hpo, "ResinWaterContent") |> PrefixedName
    /// <summary>
    ///   <para>hpo:ResinpH</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"pH of the resin."</para>
    /// labels<para>"ResinpH"</para></remarks>
    /// <seealso href="http://w3id.org/emmo-hpo/hpo#ResinpH">http://w3id.org/emmo-hpo/hpo#ResinpH</seealso>
    let ResinpH = Prefixed_Name(hpo, "ResinpH") |> PrefixedName

    /// <summary>
    ///   <para>hpo:SemiSyntheticPolymer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A polymer synthesised from biomass sources."</para>
    /// labels<para>"SemiSyntheticPolymer"</para></remarks>
    /// <seealso href="http://w3id.org/emmo-hpo/hpo#SemiSyntheticPolymer">http://w3id.org/emmo-hpo/hpo#SemiSyntheticPolymer</seealso>
    let SemiSyntheticPolymer =
        Prefixed_Name(hpo, "SemiSyntheticPolymer") |> PrefixedName

    /// <summary>
    ///   <para>hpo:ShapingAndCuring</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The process of shaping composite materials into a solid mass of prescribed shape and size, using a mold or tool."</para>
    /// labels<para>"ShapingAndCuring"</para></remarks>
    /// <seealso href="http://w3id.org/emmo-hpo/hpo#ShapingAndCuring">http://w3id.org/emmo-hpo/hpo#ShapingAndCuring</seealso>
    let ShapingAndCuring = Prefixed_Name(hpo, "ShapingAndCuring") |> PrefixedName
    /// <summary>
    ///   <para>hpo:SkeletalFormula</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A 2-dimensional representation of chemical structures of organic compounds, showing the chemical bonds as lines, carbon atoms as vertices, and hetero atoms with labels. Hydrogen atoms are omitted in the representation since their presence can be derived from the valence of carbon atoms."</para>
    /// labels<para>"SkeletalFormula"</para></remarks>
    /// <seealso href="http://w3id.org/emmo-hpo/hpo#SkeletalFormula">http://w3id.org/emmo-hpo/hpo#SkeletalFormula</seealso>
    let SkeletalFormula = Prefixed_Name(hpo, "SkeletalFormula") |> PrefixedName
    /// <summary>
    ///   <para>hpo:StackedPrepreg</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Arrangement of ply prepregs in a laminate."</para>
    /// labels<para>"StackedPrepreg"</para></remarks>
    /// <seealso href="http://w3id.org/emmo-hpo/hpo#StackedPrepreg">http://w3id.org/emmo-hpo/hpo#StackedPrepreg</seealso>
    let StackedPrepreg = Prefixed_Name(hpo, "StackedPrepreg") |> PrefixedName

    /// <summary>
    ///   <para>hpo:StackedPrepregLength</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Length (contributing to the size of the object)."</para>
    /// labels<para>"StackedPrepregLength"</para></remarks>
    /// <seealso href="http://w3id.org/emmo-hpo/hpo#StackedPrepregLength">http://w3id.org/emmo-hpo/hpo#StackedPrepregLength</seealso>
    let StackedPrepregLength =
        Prefixed_Name(hpo, "StackedPrepregLength") |> PrefixedName

    /// <summary>
    ///   <para>hpo:StackedPrepregNominalThickness</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Sum of the thicknesses of prepreg layer."</para>
    /// labels<para>"StackedPrepregNominalThickness"</para></remarks>
    /// <seealso href="http://w3id.org/emmo-hpo/hpo#StackedPrepregNominalThickness">http://w3id.org/emmo-hpo/hpo#StackedPrepregNominalThickness</seealso>
    let StackedPrepregNominalThickness =
        Prefixed_Name(hpo, "StackedPrepregNominalThickness") |> PrefixedName

    /// <summary>
    ///   <para>hpo:StackedPrepregNumberOfLayers</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Number of stacked prepreg layers"</para>
    /// labels<para>"StackedPrepregNumberOfLayers"</para></remarks>
    /// <seealso href="http://w3id.org/emmo-hpo/hpo#StackedPrepregNumberOfLayers">http://w3id.org/emmo-hpo/hpo#StackedPrepregNumberOfLayers</seealso>
    let StackedPrepregNumberOfLayers =
        Prefixed_Name(hpo, "StackedPrepregNumberOfLayers") |> PrefixedName

    /// <summary>
    ///   <para>hpo:StackedPrepregProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A collection of the properties of stacked prepregs."</para>
    /// labels<para>"StackedPrepregProperty"</para></remarks>
    /// <seealso href="http://w3id.org/emmo-hpo/hpo#StackedPrepregProperty">http://w3id.org/emmo-hpo/hpo#StackedPrepregProperty</seealso>
    let StackedPrepregProperty =
        Prefixed_Name(hpo, "StackedPrepregProperty") |> PrefixedName

    /// <summary>
    ///   <para>hpo:StackedPrepregStackingSequence</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"List of the orientation (degreees) of each prepreg layer."</para>
    /// labels<para>"StackedPrepregStackingSequence"</para></remarks>
    /// <seealso href="http://w3id.org/emmo-hpo/hpo#StackedPrepregStackingSequence">http://w3id.org/emmo-hpo/hpo#StackedPrepregStackingSequence</seealso>
    let StackedPrepregStackingSequence =
        Prefixed_Name(hpo, "StackedPrepregStackingSequence") |> PrefixedName

    /// <summary>
    ///   <para>hpo:StackedPrepregWidth</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Width (contributing to the size of the object)."</para>
    /// labels<para>"StackedPrepregWidth"</para></remarks>
    /// <seealso href="http://w3id.org/emmo-hpo/hpo#StackedPrepregWidth">http://w3id.org/emmo-hpo/hpo#StackedPrepregWidth</seealso>
    let StackedPrepregWidth = Prefixed_Name(hpo, "StackedPrepregWidth") |> PrefixedName
    /// <summary>
    ///   <para>hpo:Stacking</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An arrangement of prepreg parts (ply) orientations and material components in a laminate specified with respect to some reference direction."</para>
    /// labels<para>"Stacking"</para></remarks>
    /// <seealso href="http://w3id.org/emmo-hpo/hpo#Stacking">http://w3id.org/emmo-hpo/hpo#Stacking</seealso>
    let Stacking = Prefixed_Name(hpo, "Stacking") |> PrefixedName
    /// <summary>
    ///   <para>hpo:StepDuration</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Step duration"</para>
    /// labels<para>"StepDuration"</para></remarks>
    /// <seealso href="http://w3id.org/emmo-hpo/hpo#StepDuration">http://w3id.org/emmo-hpo/hpo#StepDuration</seealso>
    let StepDuration = Prefixed_Name(hpo, "StepDuration") |> PrefixedName
    /// <summary>
    ///   <para>hpo:StorageModulus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The storage modulus in viscoelastic materials measure the stored energy representing the elastic portion."</para>
    /// labels<para>"StorageModulus"</para></remarks>
    /// <seealso href="http://w3id.org/emmo-hpo/hpo#StorageModulus">http://w3id.org/emmo-hpo/hpo#StorageModulus</seealso>
    let StorageModulus = Prefixed_Name(hpo, "StorageModulus") |> PrefixedName
    /// <summary>
    ///   <para>hpo:SyntheticPolymer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A polymer synthesised from other manufactured chemicals."</para>
    /// labels<para>"SyntheticPolymer"</para></remarks>
    /// <seealso href="http://w3id.org/emmo-hpo/hpo#SyntheticPolymer">http://w3id.org/emmo-hpo/hpo#SyntheticPolymer</seealso>
    let SyntheticPolymer = Prefixed_Name(hpo, "SyntheticPolymer") |> PrefixedName
    /// <summary>
    ///   <para>hpo:TensileModulus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Tangent of the stress-strain curve under tensile stress."</para>
    /// labels<para>"TensileModulus"</para></remarks>
    /// <seealso href="http://w3id.org/emmo-hpo/hpo#TensileModulus">http://w3id.org/emmo-hpo/hpo#TensileModulus</seealso>
    let TensileModulus = Prefixed_Name(hpo, "TensileModulus") |> PrefixedName
    /// <summary>
    ///   <para>hpo:TensileStrength</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Maximum value of the stress-strain curve under tensile stress."</para>
    /// labels<para>"TensileStrength"</para></remarks>
    /// <seealso href="http://w3id.org/emmo-hpo/hpo#TensileStrength">http://w3id.org/emmo-hpo/hpo#TensileStrength</seealso>
    let TensileStrength = Prefixed_Name(hpo, "TensileStrength") |> PrefixedName
    /// <summary>
    ///   <para>hpo:TextileFabric</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A planar textile constructed with fibres (or yarns), which can be either woven (interlaced using a weaving process) or non-woven (not interlaced)."</para>
    /// labels<para>"TextileFabric"</para></remarks>
    /// <seealso href="http://w3id.org/emmo-hpo/hpo#TextileFabric">http://w3id.org/emmo-hpo/hpo#TextileFabric</seealso>
    let TextileFabric = Prefixed_Name(hpo, "TextileFabric") |> PrefixedName

    /// <summary>
    ///   <para>hpo:TextileFabricProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A collection of the properties of textile fabrics."</para>
    /// labels<para>"TextileFabricProperty"</para></remarks>
    /// <seealso href="http://w3id.org/emmo-hpo/hpo#TextileFabricProperty">http://w3id.org/emmo-hpo/hpo#TextileFabricProperty</seealso>
    let TextileFabricProperty =
        Prefixed_Name(hpo, "TextileFabricProperty") |> PrefixedName

    /// <summary>
    ///   <para>hpo:TextileFabricThickness</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Textile fabric thickness"</para>
    /// labels<para>"TextileFabricThickness"</para></remarks>
    /// <seealso href="http://w3id.org/emmo-hpo/hpo#TextileFabricThickness">http://w3id.org/emmo-hpo/hpo#TextileFabricThickness</seealso>
    let TextileFabricThickness =
        Prefixed_Name(hpo, "TextileFabricThickness") |> PrefixedName

    /// <summary>
    ///   <para>hpo:TextileFabricWeaveStyle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Pattern of fibre weaving."</para>
    /// labels<para>"TextileFabricWeaveStyle"</para></remarks>
    /// <seealso href="http://w3id.org/emmo-hpo/hpo#TextileFabricWeaveStyle">http://w3id.org/emmo-hpo/hpo#TextileFabricWeaveStyle</seealso>
    let TextileFabricWeaveStyle =
        Prefixed_Name(hpo, "TextileFabricWeaveStyle") |> PrefixedName

    /// <summary>
    ///   <para>hpo:TextileFabricWidth</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Width of the fabric."</para>
    /// labels<para>"TextileFabricWidth"</para></remarks>
    /// <seealso href="http://w3id.org/emmo-hpo/hpo#TextileFabricWidth">http://w3id.org/emmo-hpo/hpo#TextileFabricWidth</seealso>
    let TextileFabricWidth = Prefixed_Name(hpo, "TextileFabricWidth") |> PrefixedName

    /// <summary>
    ///   <para>hpo:ThermoplasticPolymer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A polymer that becomes pliable and mouldable (i.e. plastic) above a certain temperature, and that reversibly solidifies upon cooling. Thermoplastics typically have linear chains and high molecular weight, increasing the strength of intermolecular interactions."</para>
    /// labels<para>"ThermoplasticPolymer"</para></remarks>
    /// <seealso href="http://w3id.org/emmo-hpo/hpo#ThermoplasticPolymer">http://w3id.org/emmo-hpo/hpo#ThermoplasticPolymer</seealso>
    let ThermoplasticPolymer =
        Prefixed_Name(hpo, "ThermoplasticPolymer") |> PrefixedName

    /// <summary>
    ///   <para>hpo:ThermosettingPolymer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A polymer that becomes irreversibly hard by creating an extensive network of cross-linking between the individual chains."</para>
    /// labels<para>"ThermosettingPolymer"</para></remarks>
    /// <seealso href="http://w3id.org/emmo-hpo/hpo#ThermosettingPolymer">http://w3id.org/emmo-hpo/hpo#ThermosettingPolymer</seealso>
    let ThermosettingPolymer =
        Prefixed_Name(hpo, "ThermosettingPolymer") |> PrefixedName

    /// <summary>
    ///   <para>hpo:Volatile</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Solvents, such as water and alcohol, in a sizing or resin formulation that can be vaporized at ambient or slightly elevated temperatures."</para>
    /// labels<para>"Volatile"</para></remarks>
    /// <seealso href="http://w3id.org/emmo-hpo/hpo#Volatile">http://w3id.org/emmo-hpo/hpo#Volatile</seealso>
    let Volatile = Prefixed_Name(hpo, "Volatile") |> PrefixedName
    /// <summary>
    ///   <para>hpo:WorkingStepsOrder</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"List of steps for the mixing process."</para>
    /// labels<para>"WorkingStepsOrder"</para></remarks>
    /// <seealso href="http://w3id.org/emmo-hpo/hpo#WorkingStepsOrder">http://w3id.org/emmo-hpo/hpo#WorkingStepsOrder</seealso>
    let WorkingStepsOrder = Prefixed_Name(hpo, "WorkingStepsOrder") |> PrefixedName
