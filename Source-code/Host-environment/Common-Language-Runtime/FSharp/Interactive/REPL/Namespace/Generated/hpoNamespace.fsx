#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module hpo =
    let _prefixId = PrefixId.fromNamespaceLabel "http://w3id.org/emmo-hpo/hpo#" "hpo"
    /// <summary>
    ///   <para>skos:prefLabel : AdditionPolymer</para>
    ///   <para>rdfs:label : AdditionPolymer</para>
    ///   <para>rdfs:comment : A polymer obtained through an addition reaction, that is, a reaction involving the creation of a single bond between the atoms of different molecules which are involved in a double or triple bond.</para>
    ///   <para>http://w3id.org/emmo#elucidation : A polymer obtained through an addition reaction, that is, a reaction involving the creation of a single bond between the atoms of different molecules which are involved in a double or triple bond.</para>
    ///   <a href="http://w3id.org/emmo-hpo/hpo#AdditionPolymer">hpo:AdditionPolymer</a>
    /// </summary>
    let AdditionPolymer = _prefixId.prefix "AdditionPolymer"
    /// <summary>
    ///   <para>skos:prefLabel : Additive</para>
    ///   <para>rdfs:label : Additive</para>
    ///   <para>rdfs:isDefinedBy : https://compositesuk.co.uk/composite-materials/glossary-terms^^xsd:anyURI</para>
    ///   <para>http://w3id.org/emmo#example : An additive can provide flame retardancy and UV resistance properties to a resin.</para>
    ///   <para>rdfs:comment : A term used for a large number of specialist chemicals which are added to compounds to impart specific properties.</para>
    ///   <para>http://w3id.org/emmo#elucidation : A term used for a large number of specialist chemicals which are added to compounds to impart specific properties.</para>
    ///   <a href="http://w3id.org/emmo-hpo/hpo#Additive">hpo:Additive</a>
    /// </summary>
    let Additive = _prefixId.prefix "Additive"
    /// <summary>
    ///   <para>skos:prefLabel : Branched</para>
    ///   <para>rdfs:label : Branched</para>
    ///   <para>rdfs:comment : A class of structures characterised by a branched skeleton.</para>
    ///   <para>http://w3id.org/emmo#elucidation : A class of structures characterised by a branched skeleton.</para>
    ///   <a href="http://w3id.org/emmo-hpo/hpo#Branched">hpo:Branched</a>
    /// </summary>
    let Branched = _prefixId.prefix "Branched"
    /// <summary>
    ///   <para>skos:prefLabel : BranchedChainPolymer</para>
    ///   <para>rdfs:label : BranchedChainPolymer</para>
    ///   <para>http://w3id.org/emmo#example : Glycogen, Star-polymers.</para>
    ///   <para>rdfs:comment : A polymer whose molecular structure is characterised by a regular or irregular attachment of side chains to the main backbone chain. .</para>
    ///   <para>http://w3id.org/emmo#elucidation : A polymer whose molecular structure is characterised by a regular or irregular attachment of side chains to the main backbone chain. .</para>
    ///   <a href="http://w3id.org/emmo-hpo/hpo#BranchedChainPolymer">hpo:BranchedChainPolymer</a>
    /// </summary>
    let BranchedChainPolymer = _prefixId.prefix "BranchedChainPolymer"
    /// <summary>
    ///   <para>skos:prefLabel : COMPEVODSCAnalysis</para>
    ///   <para>rdfs:label : COMPEVODSCAnalysis</para>
    ///   <para>rdfs:comment : Experimental procedure for resin reactivity measurement.</para>
    ///   <para>http://w3id.org/emmo#elucidation : Experimental procedure for resin reactivity measurement.</para>
    ///   <a href="http://w3id.org/emmo-hpo/hpo#COMPEVODSCAnalysis">hpo:COMPEVODSCAnalysis</a>
    /// </summary>
    let COMPEVODSCAnalysis = _prefixId.prefix "COMPEVODSCAnalysis"
    /// <summary>
    ///   <para>skos:prefLabel : Catalyst</para>
    ///   <para>rdfs:label : Catalyst</para>
    ///   <para>rdfs:seeAlso : https://doi.org/10.1351/goldbook.C00876</para>
    ///   <para>rdfs:comment : A substance that increases the rate of a reaction without modifying the overall standard Gibbs energy change in the reaction.</para>
    ///   <para>http://w3id.org/emmo#elucidation : A substance that increases the rate of a reaction without modifying the overall standard Gibbs energy change in the reaction.</para>
    ///   <a href="http://w3id.org/emmo-hpo/hpo#Catalyst">hpo:Catalyst</a>
    /// </summary>
    let Catalyst = _prefixId.prefix "Catalyst"
    /// <summary>
    ///   <para>skos:prefLabel : CatalystCommercialName</para>
    ///   <para>rdfs:label : CatalystCommercialName</para>
    ///   <para>rdfs:comment : Catalyst suppliers trade name for the purchased catalyst formulation.</para>
    ///   <para>http://w3id.org/emmo#elucidation : Catalyst suppliers trade name for the purchased catalyst formulation.</para>
    ///   <a href="http://w3id.org/emmo-hpo/hpo#CatalystCommercialName">hpo:CatalystCommercialName</a>
    /// </summary>
    let CatalystCommercialName = _prefixId.prefix "CatalystCommercialName"
    /// <summary>
    ///   <para>skos:prefLabel : CatalystDensity</para>
    ///   <para>rdfs:label : CatalystDensity</para>
    ///   <para>rdfs:comment : Mass density of the catalyst.</para>
    ///   <para>http://w3id.org/emmo#elucidation : Mass density of the catalyst.</para>
    ///   <a href="http://w3id.org/emmo-hpo/hpo#CatalystDensity">hpo:CatalystDensity</a>
    /// </summary>
    let CatalystDensity = _prefixId.prefix "CatalystDensity"
    /// <summary>
    ///   <para>skos:prefLabel : CatalystMolecularWeight</para>
    ///   <para>rdfs:label : CatalystMolecularWeight</para>
    ///   <para>rdfs:comment : Average molecular weight of the catalyst molecular consituents.</para>
    ///   <para>http://w3id.org/emmo#elucidation : Average molecular weight of the catalyst molecular consituents.</para>
    ///   <a href="http://w3id.org/emmo-hpo/hpo#CatalystMolecularWeight">hpo:CatalystMolecularWeight</a>
    /// </summary>
    let CatalystMolecularWeight = _prefixId.prefix "CatalystMolecularWeight"
    /// <summary>
    ///   <para>skos:prefLabel : CatalystProperty</para>
    ///   <para>rdfs:label : CatalystProperty</para>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <a href="http://w3id.org/emmo-hpo/hpo#CatalystProperty">hpo:CatalystProperty</a>
    /// </summary>
    let CatalystProperty = _prefixId.prefix "CatalystProperty"
    /// <summary>
    ///   <para>skos:prefLabel : CatalystViscosity</para>
    ///   <para>rdfs:label : CatalystViscosity</para>
    ///   <para>rdfs:comment : Catalyst viscosity at 25°C.</para>
    ///   <para>http://w3id.org/emmo#elucidation : Catalyst viscosity at 25°C.</para>
    ///   <a href="http://w3id.org/emmo-hpo/hpo#CatalystViscosity">hpo:CatalystViscosity</a>
    /// </summary>
    let CatalystViscosity = _prefixId.prefix "CatalystViscosity"
    /// <summary>
    ///   <para>skos:prefLabel : CoPolymer</para>
    ///   <para>rdfs:label : CoPolymer</para>
    ///   <para>rdfs:comment : A polymer derived from the polymerisation of more than one species of monomer.</para>
    ///   <para>http://w3id.org/emmo#elucidation : A polymer derived from the polymerisation of more than one species of monomer.</para>
    ///   <a href="http://w3id.org/emmo-hpo/hpo#CoPolymer">hpo:CoPolymer</a>
    /// </summary>
    let CoPolymer = _prefixId.prefix "CoPolymer"
    /// <summary>
    ///   <para>skos:prefLabel : ComponentManufacturing</para>
    ///   <para>rdfs:label : ComponentManufacturing</para>
    ///   <para>rdfs:comment : The manufacturing of a component made of a composite material.</para>
    ///   <para>http://w3id.org/emmo#elucidation : The manufacturing of a component made of a composite material.</para>
    ///   <a href="http://w3id.org/emmo-hpo/hpo#ComponentManufacturing">hpo:ComponentManufacturing</a>
    /// </summary>
    let ComponentManufacturing = _prefixId.prefix "ComponentManufacturing"
    /// <summary>
    ///   <para>rdfs:comment : A manufacturing line processing a composite material into a component.</para>
    ///   <para>http://w3id.org/emmo#elucidation : A manufacturing line processing a composite material into a component.</para>
    ///   <para>rdfs:label : ComponentManufacturingLine</para>
    ///   <para>skos:prefLabel : ComponentManufacturingLine</para>
    ///   <a href="http://w3id.org/emmo-hpo/hpo#ComponentManufacturingLine">hpo:ComponentManufacturingLine</a>
    /// </summary>
    let ComponentManufacturingLine = _prefixId.prefix "ComponentManufacturingLine"

    /// <summary>
    ///   <para>skos:prefLabel : ComponentManufacturingProperty</para>
    ///   <para>rdfs:label : ComponentManufacturingProperty</para>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <a href="http://w3id.org/emmo-hpo/hpo#ComponentManufacturingProperty">hpo:ComponentManufacturingProperty</a>
    /// </summary>
    let ComponentManufacturingProperty =
        _prefixId.prefix "ComponentManufacturingProperty"

    /// <summary>
    ///   <para>skos:prefLabel : Composite</para>
    ///   <para>rdfs:label : Composite</para>
    ///   <para>rdfs:isDefinedBy : https://compositesuk.co.uk/composite-materials/glossary-terms^^xsd:anyURI</para>
    ///   <para>rdfs:comment : A material made up of resin and reinforcement (usually fibre).</para>
    ///   <para>http://w3id.org/emmo#elucidation : A material made up of resin and reinforcement (usually fibre).</para>
    ///   <a href="http://w3id.org/emmo-hpo/hpo#Composite">hpo:Composite</a>
    /// </summary>
    let Composite = _prefixId.prefix "Composite"
    /// <summary>
    ///   <para>skos:prefLabel : CompositeLaminate</para>
    ///   <para>rdfs:label : CompositeLaminate</para>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <a href="http://w3id.org/emmo-hpo/hpo#CompositeLaminate">hpo:CompositeLaminate</a>
    /// </summary>
    let CompositeLaminate = _prefixId.prefix "CompositeLaminate"
    /// <summary>
    ///   <para>skos:prefLabel : CompositeLaminateBulkPorosity</para>
    ///   <para>rdfs:label : CompositeLaminateBulkPorosity</para>
    ///   <para>rdfs:comment : After performing a cross-cut perpendicular to the specimen surface, based on a light microscopy image, the apparent surface area fraction occupied by pores is evaluated.</para>
    ///   <para>http://w3id.org/emmo#elucidation : After performing a cross-cut perpendicular to the specimen surface, based on a light microscopy image, the apparent surface area fraction occupied by pores is evaluated.</para>
    ///   <a href="http://w3id.org/emmo-hpo/hpo#CompositeLaminateBulkPorosity">hpo:CompositeLaminateBulkPorosity</a>
    /// </summary>
    let CompositeLaminateBulkPorosity = _prefixId.prefix "CompositeLaminateBulkPorosity"
    /// <summary>
    ///   <para>skos:prefLabel : CompositeLaminateProperty</para>
    ///   <para>rdfs:label : CompositeLaminateProperty</para>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <a href="http://w3id.org/emmo-hpo/hpo#CompositeLaminateProperty">hpo:CompositeLaminateProperty</a>
    /// </summary>
    let CompositeLaminateProperty = _prefixId.prefix "CompositeLaminateProperty"

    /// <summary>
    ///   <para>skos:prefLabel : CompositeLaminateSurfaceRegionPorosity</para>
    ///   <para>rdfs:label : CompositeLaminateSurfaceRegionPorosity</para>
    ///   <para>rdfs:comment : Based on a light microscopy image of the smoother surface (i.e. the one visible to a user) of the composite laminate, the apparent surface area fraction occupied by pores is evaluated.</para>
    ///   <para>http://w3id.org/emmo#elucidation : Based on a light microscopy image of the smoother surface (i.e. the one visible to a user) of the composite laminate, the apparent surface area fraction occupied by pores is evaluated.</para>
    ///   <a href="http://w3id.org/emmo-hpo/hpo#CompositeLaminateSurfaceRegionPorosity">hpo:CompositeLaminateSurfaceRegionPorosity</a>
    /// </summary>
    let CompositeLaminateSurfaceRegionPorosity =
        _prefixId.prefix "CompositeLaminateSurfaceRegionPorosity"

    /// <summary>
    ///   <para>skos:prefLabel : CompositeLaminateVisualSurfaceFinish</para>
    ///   <para>rdfs:label : CompositeLaminateVisualSurfaceFinish</para>
    ///   <para>rdfs:comment : Using a (set of) specimen illumination settings, the appearance is compared with the appearance of a specified set of (reference) specimens.</para>
    ///   <para>http://w3id.org/emmo#elucidation : Using a (set of) specimen illumination settings, the appearance is compared with the appearance of a specified set of (reference) specimens.</para>
    ///   <a href="http://w3id.org/emmo-hpo/hpo#CompositeLaminateVisualSurfaceFinish">hpo:CompositeLaminateVisualSurfaceFinish</a>
    /// </summary>
    let CompositeLaminateVisualSurfaceFinish =
        _prefixId.prefix "CompositeLaminateVisualSurfaceFinish"

    /// <summary>
    ///   <para>skos:prefLabel : CondensationPolymer</para>
    ///   <para>rdfs:label : CondensationPolymer</para>
    ///   <para>rdfs:comment : A polymer obtained through a condensation reaction, that is, where two molecules form a chemical bond by eliminating a small molecule such as water.</para>
    ///   <para>http://w3id.org/emmo#elucidation : A polymer obtained through a condensation reaction, that is, where two molecules form a chemical bond by eliminating a small molecule such as water.</para>
    ///   <a href="http://w3id.org/emmo-hpo/hpo#CondensationPolymer">hpo:CondensationPolymer</a>
    /// </summary>
    let CondensationPolymer = _prefixId.prefix "CondensationPolymer"
    /// <summary>
    ///   <para>skos:prefLabel : CoverReleaseLayer</para>
    ///   <para>rdfs:label : CoverReleaseLayer</para>
    ///   <para>rdfs:isDefinedBy : https://www.compositesworld.com/glossary^^xsd:anyURI</para>
    ///   <para>rdfs:comment : A release layer applied to a cover placed over the laminate.</para>
    ///   <para>http://w3id.org/emmo#elucidation : A release layer applied to a cover placed over the laminate.</para>
    ///   <a href="http://w3id.org/emmo-hpo/hpo#CoverReleaseLayer">hpo:CoverReleaseLayer</a>
    /// </summary>
    let CoverReleaseLayer = _prefixId.prefix "CoverReleaseLayer"
    /// <summary>
    ///   <para>skos:prefLabel : CoverReleaseLayerIdentifier</para>
    ///   <para>rdfs:label : CoverReleaseLayerIdentifier</para>
    ///   <para>rdfs:comment : Commercial name of the applied consumable (product), differentiating available product providers and product lots.</para>
    ///   <para>http://w3id.org/emmo#elucidation : Commercial name of the applied consumable (product), differentiating available product providers and product lots.</para>
    ///   <a href="http://w3id.org/emmo-hpo/hpo#CoverReleaseLayerIdentifier">hpo:CoverReleaseLayerIdentifier</a>
    /// </summary>
    let CoverReleaseLayerIdentifier = _prefixId.prefix "CoverReleaseLayerIdentifier"
    /// <summary>
    ///   <para>skos:prefLabel : CoverReleaseLayerProperty</para>
    ///   <para>rdfs:label : CoverReleaseLayerProperty</para>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <a href="http://w3id.org/emmo-hpo/hpo#CoverReleaseLayerProperty">hpo:CoverReleaseLayerProperty</a>
    /// </summary>
    let CoverReleaseLayerProperty = _prefixId.prefix "CoverReleaseLayerProperty"
    /// <summary>
    ///   <para>skos:prefLabel : CoverTool</para>
    ///   <para>rdfs:label : CoverTool</para>
    ///   <para>rdfs:isDefinedBy : https://www.compositesworld.com/glossary^^xsd:anyURI</para>
    ///   <para>rdfs:comment : The mold, either one- or two-sided and either open or closed, in or upon which composite material is placed in order to make a part.</para>
    ///   <para>http://w3id.org/emmo#elucidation : The mold, either one- or two-sided and either open or closed, in or upon which composite material is placed in order to make a part.</para>
    ///   <a href="http://w3id.org/emmo-hpo/hpo#CoverTool">hpo:CoverTool</a>
    /// </summary>
    let CoverTool = _prefixId.prefix "CoverTool"
    /// <summary>
    ///   <para>skos:prefLabel : CoverToolHoleDistance</para>
    ///   <para>rdfs:label : CoverToolHoleDistance</para>
    ///   <para>rdfs:comment : Average distance between holes.</para>
    ///   <para>http://w3id.org/emmo#elucidation : Average distance between holes.</para>
    ///   <a href="http://w3id.org/emmo-hpo/hpo#CoverToolHoleDistance">hpo:CoverToolHoleDistance</a>
    /// </summary>
    let CoverToolHoleDistance = _prefixId.prefix "CoverToolHoleDistance"
    /// <summary>
    ///   <para>skos:prefLabel : CoverToolLength</para>
    ///   <para>rdfs:label : CoverToolLength</para>
    ///   <para>rdfs:comment : Length (contributing to the size of the tool).</para>
    ///   <para>http://w3id.org/emmo#elucidation : Length (contributing to the size of the tool).</para>
    ///   <a href="http://w3id.org/emmo-hpo/hpo#CoverToolLength">hpo:CoverToolLength</a>
    /// </summary>
    let CoverToolLength = _prefixId.prefix "CoverToolLength"
    /// <summary>
    ///   <para>skos:prefLabel : CoverToolNumberOfHoles</para>
    ///   <para>rdfs:label : CoverToolNumberOfHoles</para>
    ///   <para>rdfs:comment : Amount of holes.</para>
    ///   <para>http://w3id.org/emmo#elucidation : Amount of holes.</para>
    ///   <a href="http://w3id.org/emmo-hpo/hpo#CoverToolNumberOfHoles">hpo:CoverToolNumberOfHoles</a>
    /// </summary>
    let CoverToolNumberOfHoles = _prefixId.prefix "CoverToolNumberOfHoles"
    /// <summary>
    ///   <para>skos:prefLabel : CoverToolProperty</para>
    ///   <para>rdfs:label : CoverToolProperty</para>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <a href="http://w3id.org/emmo-hpo/hpo#CoverToolProperty">hpo:CoverToolProperty</a>
    /// </summary>
    let CoverToolProperty = _prefixId.prefix "CoverToolProperty"
    /// <summary>
    ///   <para>skos:prefLabel : CoverToolSizeOfHoles</para>
    ///   <para>rdfs:label : CoverToolSizeOfHoles</para>
    ///   <para>rdfs:comment : Average diameter of holes.</para>
    ///   <para>http://w3id.org/emmo#elucidation : Average diameter of holes.</para>
    ///   <a href="http://w3id.org/emmo-hpo/hpo#CoverToolSizeOfHoles">hpo:CoverToolSizeOfHoles</a>
    /// </summary>
    let CoverToolSizeOfHoles = _prefixId.prefix "CoverToolSizeOfHoles"
    /// <summary>
    ///   <para>skos:prefLabel : CoverToolWidth</para>
    ///   <para>rdfs:label : CoverToolWidth</para>
    ///   <para>rdfs:comment : Width (contributing to the size of the tool).</para>
    ///   <para>http://w3id.org/emmo#elucidation : Width (contributing to the size of the tool).</para>
    ///   <a href="http://w3id.org/emmo-hpo/hpo#CoverToolWidth">hpo:CoverToolWidth</a>
    /// </summary>
    let CoverToolWidth = _prefixId.prefix "CoverToolWidth"
    /// <summary>
    ///   <para>skos:prefLabel : Crosslinked</para>
    ///   <para>rdfs:label : Crosslinked</para>
    ///   <para>rdfs:comment : A class of structures characterised by a bond or a short sequence of bonds connecting different macromolecules.</para>
    ///   <para>http://w3id.org/emmo#elucidation : A class of structures characterised by a bond or a short sequence of bonds connecting different macromolecules.</para>
    ///   <a href="http://w3id.org/emmo-hpo/hpo#Crosslinked">hpo:Crosslinked</a>
    /// </summary>
    let Crosslinked = _prefixId.prefix "Crosslinked"
    /// <summary>
    ///   <para>skos:prefLabel : CrosslinkedPolymer</para>
    ///   <para>rdfs:label : CrosslinkedPolymer</para>
    ///   <para>http://w3id.org/emmo#example : Bakelite, vulcanised rubber.</para>
    ///   <para>rdfs:comment : A polymer whose molecular structure is characterised by additional covalent bonds connecting several chains together.</para>
    ///   <para>http://w3id.org/emmo#elucidation : A polymer whose molecular structure is characterised by additional covalent bonds connecting several chains together.</para>
    ///   <a href="http://w3id.org/emmo-hpo/hpo#CrosslinkedPolymer">hpo:CrosslinkedPolymer</a>
    /// </summary>
    let CrosslinkedPolymer = _prefixId.prefix "CrosslinkedPolymer"
    /// <summary>
    ///   <para>skos:prefLabel : DegassingStepDuration</para>
    ///   <para>rdfs:label : DegassingStepDuration</para>
    ///   <para>rdfs:comment : Duration of the degassing.</para>
    ///   <para>http://w3id.org/emmo#elucidation : Duration of the degassing.</para>
    ///   <a href="http://w3id.org/emmo-hpo/hpo#DegassingStepDuration">hpo:DegassingStepDuration</a>
    /// </summary>
    let DegassingStepDuration = _prefixId.prefix "DegassingStepDuration"
    /// <summary>
    ///   <para>skos:prefLabel : Elastomer</para>
    ///   <para>rdfs:label : Elastomer</para>
    ///   <para>http://w3id.org/emmo#example : Neoprene, rubber.</para>
    ///   <para>rdfs:comment : A polymer characterised by weak intermolecular forces and viscoelasticity.</para>
    ///   <para>http://w3id.org/emmo#elucidation : A polymer characterised by weak intermolecular forces and viscoelasticity.</para>
    ///   <a href="http://w3id.org/emmo-hpo/hpo#Elastomer">hpo:Elastomer</a>
    /// </summary>
    let Elastomer = _prefixId.prefix "Elastomer"
    /// <summary>
    ///   <para>skos:prefLabel : ElongationAtBreak</para>
    ///   <para>rdfs:label : ElongationAtBreak</para>
    ///   <para>rdfs:comment : Ratio between increased length and initial length after breakage.</para>
    ///   <para>http://w3id.org/emmo#elucidation : Ratio between increased length and initial length after breakage.</para>
    ///   <a href="http://w3id.org/emmo-hpo/hpo#ElongationAtBreak">hpo:ElongationAtBreak</a>
    /// </summary>
    let ElongationAtBreak = _prefixId.prefix "ElongationAtBreak"
    /// <summary>
    ///   <para>skos:prefLabel : Fibre</para>
    ///   <para>rdfs:label : Fibre</para>
    ///   <para>http://w3id.org/emmo#example : Cotton, Nylon.</para>
    ///   <para>rdfs:comment : A polymer characterised by strong intermolecular forces and high tensile strength.</para>
    ///   <para>http://w3id.org/emmo#elucidation : A polymer characterised by strong intermolecular forces and high tensile strength.</para>
    ///   <a href="http://w3id.org/emmo-hpo/hpo#Fibre">hpo:Fibre</a>
    /// </summary>
    let Fibre = _prefixId.prefix "Fibre"
    /// <summary>
    ///   <para>skos:prefLabel : FibreDensity</para>
    ///   <para>rdfs:label : FibreDensity</para>
    ///   <para>rdfs:comment : Mass per unit volume of the facbric.</para>
    ///   <para>http://w3id.org/emmo#elucidation : Mass per unit volume of the facbric.</para>
    ///   <a href="http://w3id.org/emmo-hpo/hpo#FibreDensity">hpo:FibreDensity</a>
    /// </summary>
    let FibreDensity = _prefixId.prefix "FibreDensity"
    /// <summary>
    ///   <para>skos:prefLabel : FibreDiameter</para>
    ///   <para>rdfs:label : FibreDiameter</para>
    ///   <para>rdfs:comment : Diameter of the fibre composing the fabric.</para>
    ///   <para>http://w3id.org/emmo#elucidation : Diameter of the fibre composing the fabric.</para>
    ///   <a href="http://w3id.org/emmo-hpo/hpo#FibreDiameter">hpo:FibreDiameter</a>
    /// </summary>
    let FibreDiameter = _prefixId.prefix "FibreDiameter"
    /// <summary>
    ///   <para>skos:prefLabel : FibreIdentifier</para>
    ///   <para>rdfs:label : FibreIdentifier</para>
    ///   <para>rdfs:comment : Commercial name of the applied consumable (product), differentiating available product providers and product lots.</para>
    ///   <para>http://w3id.org/emmo#elucidation : Commercial name of the applied consumable (product), differentiating available product providers and product lots.</para>
    ///   <a href="http://w3id.org/emmo-hpo/hpo#FibreIdentifier">hpo:FibreIdentifier</a>
    /// </summary>
    let FibreIdentifier = _prefixId.prefix "FibreIdentifier"
    /// <summary>
    ///   <para>skos:prefLabel : FibreVolumeContent</para>
    ///   <para>rdfs:label : FibreVolumeContent</para>
    ///   <para>rdfs:comment : Ratio between the volume of fibre and the volume of the composite laminate.</para>
    ///   <para>http://w3id.org/emmo#elucidation : Ratio between the volume of fibre and the volume of the composite laminate.</para>
    ///   <a href="http://w3id.org/emmo-hpo/hpo#FibreVolumeContent">hpo:FibreVolumeContent</a>
    /// </summary>
    let FibreVolumeContent = _prefixId.prefix "FibreVolumeContent"
    /// <summary>
    ///   <para>skos:prefLabel : Filler</para>
    ///   <para>rdfs:label : Filler</para>
    ///   <para>rdfs:isDefinedBy : https://compositesuk.co.uk/composite-materials/glossary-of-terms/^^xsd:anyURI</para>
    ///   <para>rdfs:comment : A material (usually low cost) added to a resin to extend it, or give special properties</para>
    ///   <para>http://w3id.org/emmo#elucidation : A material (usually low cost) added to a resin to extend it, or give special properties</para>
    ///   <a href="http://w3id.org/emmo-hpo/hpo#Filler">hpo:Filler</a>
    /// </summary>
    let Filler = _prefixId.prefix "Filler"
    /// <summary>
    ///   <para>skos:prefLabel : FinalStepPressure</para>
    ///   <para>rdfs:label : FinalStepPressure</para>
    ///   <para>rdfs:comment : Final pressure of the container during step.</para>
    ///   <para>http://w3id.org/emmo#elucidation : Final pressure of the container during step.</para>
    ///   <a href="http://w3id.org/emmo-hpo/hpo#FinalStepPressure">hpo:FinalStepPressure</a>
    /// </summary>
    let FinalStepPressure = _prefixId.prefix "FinalStepPressure"
    /// <summary>
    ///   <para>skos:prefLabel : FinalStepTemperature</para>
    ///   <para>rdfs:label : FinalStepTemperature</para>
    ///   <para>rdfs:comment : Final temperature of the container during step.</para>
    ///   <para>http://w3id.org/emmo#elucidation : Final temperature of the container during step.</para>
    ///   <a href="http://w3id.org/emmo-hpo/hpo#FinalStepTemperature">hpo:FinalStepTemperature</a>
    /// </summary>
    let FinalStepTemperature = _prefixId.prefix "FinalStepTemperature"
    /// <summary>
    ///   <para>skos:prefLabel : FlexualModulus</para>
    ///   <para>rdfs:label : FlexualModulus</para>
    ///   <para>rdfs:comment : Tangent of the stress-strain curve under flexural stress.</para>
    ///   <para>http://w3id.org/emmo#elucidation : Tangent of the stress-strain curve under flexural stress.</para>
    ///   <a href="http://w3id.org/emmo-hpo/hpo#FlexualModulus">hpo:FlexualModulus</a>
    /// </summary>
    let FlexualModulus = _prefixId.prefix "FlexualModulus"
    /// <summary>
    ///   <para>skos:prefLabel : FlexuralStrength</para>
    ///   <para>rdfs:label : FlexuralStrength</para>
    ///   <para>rdfs:comment : Maximum value of the stress-strain curve under flexural stress.</para>
    ///   <para>http://w3id.org/emmo#elucidation : Maximum value of the stress-strain curve under flexural stress.</para>
    ///   <a href="http://w3id.org/emmo-hpo/hpo#FlexuralStrength">hpo:FlexuralStrength</a>
    /// </summary>
    let FlexuralStrength = _prefixId.prefix "FlexuralStrength"
    /// <summary>
    ///   <para>rdfs:label : FormulatedResin</para>
    ///   <para>http://w3id.org/emmo#elucidation : A manufactured mixture of a resin and ingredients.</para>
    ///   <para>rdfs:comment : A manufactured mixture of a resin and ingredients.</para>
    ///   <para>skos:prefLabel : FormulatedResin</para>
    ///   <a href="http://w3id.org/emmo-hpo/hpo#FormulatedResin">hpo:FormulatedResin</a>
    /// </summary>
    let FormulatedResin = _prefixId.prefix "FormulatedResin"

    /// <summary>
    ///   <para>skos:prefLabel : FormulatedResinCuringTemperature</para>
    ///   <para>rdfs:label : FormulatedResinCuringTemperature</para>
    ///   <para>rdfs:comment : Temperature required to start the process of cure of the resin.</para>
    ///   <para>http://w3id.org/emmo#elucidation : Temperature required to start the process of cure of the resin.</para>
    ///   <a href="http://w3id.org/emmo-hpo/hpo#FormulatedResinCuringTemperature">hpo:FormulatedResinCuringTemperature</a>
    /// </summary>
    let FormulatedResinCuringTemperature =
        _prefixId.prefix "FormulatedResinCuringTemperature"

    /// <summary>
    ///   <para>skos:prefLabel : FormulatedResinCuringTime</para>
    ///   <para>rdfs:label : FormulatedResinCuringTime</para>
    ///   <para>rdfs:comment : Time at which the curing temperature must be held to achieve a certain level of cure.</para>
    ///   <para>http://w3id.org/emmo#elucidation : Time at which the curing temperature must be held to achieve a certain level of cure.</para>
    ///   <a href="http://w3id.org/emmo-hpo/hpo#FormulatedResinCuringTime">hpo:FormulatedResinCuringTime</a>
    /// </summary>
    let FormulatedResinCuringTime = _prefixId.prefix "FormulatedResinCuringTime"

    /// <summary>
    ///   <para>skos:prefLabel : FormulatedResinGlassTransitionTemperature</para>
    ///   <para>rdfs:label : FormulatedResinGlassTransitionTemperature</para>
    ///   <para>rdfs:comment : Process in which a polymer melt changes on cooling to a polymer glass or a polymer glass changes on heating to a polymer melt.</para>
    ///   <para>http://w3id.org/emmo#elucidation : Process in which a polymer melt changes on cooling to a polymer glass or a polymer glass changes on heating to a polymer melt.</para>
    ///   <a href="http://w3id.org/emmo-hpo/hpo#FormulatedResinGlassTransitionTemperature">hpo:FormulatedResinGlassTransitionTemperature</a>
    /// </summary>
    let FormulatedResinGlassTransitionTemperature =
        _prefixId.prefix "FormulatedResinGlassTransitionTemperature"

    /// <summary>
    ///   <para>skos:prefLabel : FormulatedResinProperty</para>
    ///   <para>rdfs:label : FormulatedResinProperty</para>
    ///   <para>rdfs:comment : A collection of the properties of formulated resins.</para>
    ///   <para>http://w3id.org/emmo#elucidation : A collection of the properties of formulated resins.</para>
    ///   <a href="http://w3id.org/emmo-hpo/hpo#FormulatedResinProperty">hpo:FormulatedResinProperty</a>
    /// </summary>
    let FormulatedResinProperty = _prefixId.prefix "FormulatedResinProperty"

    /// <summary>
    ///   <para>skos:prefLabel : FormulatedResinSpecificCondensateFormation</para>
    ///   <para>rdfs:label : FormulatedResinSpecificCondensateFormation</para>
    ///   <para>rdfs:comment : Mass of water released per mass of resin throughout the applied chemical (curing) reaction.</para>
    ///   <para>http://w3id.org/emmo#elucidation : Mass of water released per mass of resin throughout the applied chemical (curing) reaction.</para>
    ///   <a href="http://w3id.org/emmo-hpo/hpo#FormulatedResinSpecificCondensateFormation">hpo:FormulatedResinSpecificCondensateFormation</a>
    /// </summary>
    let FormulatedResinSpecificCondensateFormation =
        _prefixId.prefix "FormulatedResinSpecificCondensateFormation"

    /// <summary>
    ///   <para>skos:prefLabel : FormulatedResinViscosity</para>
    ///   <para>rdfs:label : FormulatedResinViscosity</para>
    ///   <para>rdfs:comment : Dynamic viscosity of the resin.</para>
    ///   <para>http://w3id.org/emmo#elucidation : Dynamic viscosity of the resin.</para>
    ///   <a href="http://w3id.org/emmo-hpo/hpo#FormulatedResinViscosity">hpo:FormulatedResinViscosity</a>
    /// </summary>
    let FormulatedResinViscosity = _prefixId.prefix "FormulatedResinViscosity"
    /// <summary>
    ///   <para>skos:prefLabel : FormulatedResinWaterContent</para>
    ///   <para>rdfs:label : FormulatedResinWaterContent</para>
    ///   <para>rdfs:comment : Weight percentage of (dissolved and freezable) water in the base resin.</para>
    ///   <para>http://w3id.org/emmo#elucidation : Weight percentage of (dissolved and freezable) water in the base resin.</para>
    ///   <a href="http://w3id.org/emmo-hpo/hpo#FormulatedResinWaterContent">hpo:FormulatedResinWaterContent</a>
    /// </summary>
    let FormulatedResinWaterContent = _prefixId.prefix "FormulatedResinWaterContent"
    /// <summary>
    ///   <para>skos:prefLabel : GlassTransitionTemperature</para>
    ///   <para>rdfs:label : GlassTransitionTemperature</para>
    ///   <para>rdfs:comment : Temperature for transition from glassy state into a viscous one.</para>
    ///   <para>http://w3id.org/emmo#elucidation : Temperature for transition from glassy state into a viscous one.</para>
    ///   <a href="http://w3id.org/emmo-hpo/hpo#GlassTransitionTemperature">hpo:GlassTransitionTemperature</a>
    /// </summary>
    let GlassTransitionTemperature = _prefixId.prefix "GlassTransitionTemperature"
    /// <summary>
    ///   <para>skos:prefLabel : HeatingRateDuringStep</para>
    ///   <para>rdfs:label : HeatingRateDuringStep</para>
    ///   <para>rdfs:comment : Heating rate during step.</para>
    ///   <para>http://w3id.org/emmo#elucidation : Heating rate during step.</para>
    ///   <a href="http://w3id.org/emmo-hpo/hpo#HeatingRateDuringStep">hpo:HeatingRateDuringStep</a>
    /// </summary>
    let HeatingRateDuringStep = _prefixId.prefix "HeatingRateDuringStep"
    /// <summary>
    ///   <para>skos:prefLabel : HomoPolymer</para>
    ///   <para>rdfs:label : HomoPolymer</para>
    ///   <para>rdfs:comment : A polymer derived from the polymerisation of one kind of monomer.</para>
    ///   <para>http://w3id.org/emmo#elucidation : A polymer derived from the polymerisation of one kind of monomer.</para>
    ///   <a href="http://w3id.org/emmo-hpo/hpo#HomoPolymer">hpo:HomoPolymer</a>
    /// </summary>
    let HomoPolymer = _prefixId.prefix "HomoPolymer"
    /// <summary>
    ///   <para>skos:prefLabel : InitialStepPressure</para>
    ///   <para>rdfs:label : InitialStepPressure</para>
    ///   <para>rdfs:comment : Pressure during step.</para>
    ///   <para>http://w3id.org/emmo#elucidation : Pressure during step.</para>
    ///   <a href="http://w3id.org/emmo-hpo/hpo#InitialStepPressure">hpo:InitialStepPressure</a>
    /// </summary>
    let InitialStepPressure = _prefixId.prefix "InitialStepPressure"
    /// <summary>
    ///   <para>skos:prefLabel : InitialStepTemperature</para>
    ///   <para>rdfs:label : InitialStepTemperature</para>
    ///   <para>rdfs:comment : Initial temperature of the container during step.</para>
    ///   <para>http://w3id.org/emmo#elucidation : Initial temperature of the container during step.</para>
    ///   <a href="http://w3id.org/emmo-hpo/hpo#InitialStepTemperature">hpo:InitialStepTemperature</a>
    /// </summary>
    let InitialStepTemperature = _prefixId.prefix "InitialStepTemperature"
    /// <summary>
    ///   <para>skos:prefLabel : InterlaminarShearStrength</para>
    ///   <para>rdfs:label : InterlaminarShearStrength</para>
    ///   <para>rdfs:comment : Mechanical property associated with the matrix-fibre interaction.</para>
    ///   <para>http://w3id.org/emmo#elucidation : Mechanical property associated with the matrix-fibre interaction.</para>
    ///   <a href="http://w3id.org/emmo-hpo/hpo#InterlaminarShearStrength">hpo:InterlaminarShearStrength</a>
    /// </summary>
    let InterlaminarShearStrength = _prefixId.prefix "InterlaminarShearStrength"
    /// <summary>
    ///   <para>skos:prefLabel : Laminate</para>
    ///   <para>rdfs:label : Laminate</para>
    ///   <para>rdfs:isDefinedBy : https://compositesuk.co.uk/composite-materials/glossary-terms^^xsd:anyURI</para>
    ///   <para>rdfs:comment : The structure resulting from the curing of multiple stacked prepreg plies.</para>
    ///   <para>http://w3id.org/emmo#elucidation : The structure resulting from the curing of multiple stacked prepreg plies.</para>
    ///   <a href="http://w3id.org/emmo-hpo/hpo#Laminate">hpo:Laminate</a>
    /// </summary>
    let Laminate = _prefixId.prefix "Laminate"
    /// <summary>
    ///   <para>skos:prefLabel : Linear</para>
    ///   <para>rdfs:label : Linear</para>
    ///   <para>rdfs:comment : A class of structures characterised by a linear skeleton.</para>
    ///   <para>http://w3id.org/emmo#elucidation : A class of structures characterised by a linear skeleton.</para>
    ///   <a href="http://w3id.org/emmo-hpo/hpo#Linear">hpo:Linear</a>
    /// </summary>
    let Linear = _prefixId.prefix "Linear"
    /// <summary>
    ///   <para>skos:prefLabel : LinearPolymer</para>
    ///   <para>rdfs:label : LinearPolymer</para>
    ///   <para>http://w3id.org/emmo#example : Polyethylene, polystyrene.</para>
    ///   <para>rdfs:comment : A polymer whose molecular structure is characterised by a linear chain of repeating units.</para>
    ///   <para>http://w3id.org/emmo#elucidation : A polymer whose molecular structure is characterised by a linear chain of repeating units.</para>
    ///   <a href="http://w3id.org/emmo-hpo/hpo#LinearPolymer">hpo:LinearPolymer</a>
    /// </summary>
    let LinearPolymer = _prefixId.prefix "LinearPolymer"
    /// <summary>
    ///   <para>skos:prefLabel : ManufacturingLine</para>
    ///   <para>rdfs:label : ManufacturingLine</para>
    ///   <para>rdfs:comment : A manufacturing line is a set of sequential operations in a factory where materials are processed, assembled, and/or refined to produce a finished product or an intermediate product for further processing.</para>
    ///   <para>http://w3id.org/emmo#elucidation : A manufacturing line is a set of sequential operations in a factory where materials are processed, assembled, and/or refined to produce a finished product or an intermediate product for further processing.</para>
    ///   <a href="http://w3id.org/emmo-hpo/hpo#ManufacturingLine">hpo:ManufacturingLine</a>
    /// </summary>
    let ManufacturingLine = _prefixId.prefix "ManufacturingLine"
    /// <summary>
    ///   <para>skos:prefLabel : Monomer</para>
    ///   <para>rdfs:label : Monomer</para>
    ///   <para>rdfs:isDefinedBy : https://www.compositesworld.com/glossary^^xsd:anyURI</para>
    ///   <para>rdfs:comment : A single molecule that reacts with like or unlike molecules to form a polymer. </para>
    ///   <para>http://w3id.org/emmo#elucidation : A single molecule that reacts with like or unlike molecules to form a polymer. </para>
    ///   <a href="http://w3id.org/emmo-hpo/hpo#Monomer">hpo:Monomer</a>
    /// </summary>
    let Monomer = _prefixId.prefix "Monomer"
    /// <summary>
    ///   <para>skos:prefLabel : MouldReleaseLayer</para>
    ///   <para>rdfs:label : MouldReleaseLayer</para>
    ///   <para>rdfs:isDefinedBy : https://www.compositesworld.com/glossary^^xsd:anyURI</para>
    ///   <para>rdfs:comment : A lubricant used to prevent a part from sticking to a mold surface.</para>
    ///   <para>http://w3id.org/emmo#elucidation : A lubricant used to prevent a part from sticking to a mold surface.</para>
    ///   <a href="http://w3id.org/emmo-hpo/hpo#MouldReleaseLayer">hpo:MouldReleaseLayer</a>
    /// </summary>
    let MouldReleaseLayer = _prefixId.prefix "MouldReleaseLayer"
    /// <summary>
    ///   <para>skos:prefLabel : MouldReleaseLayerIdentifier</para>
    ///   <para>rdfs:label : MouldReleaseLayerIdentifier</para>
    ///   <para>rdfs:comment : Commercial name of the applied consumable (product), differentiating available product providers and product lots.</para>
    ///   <para>http://w3id.org/emmo#elucidation : Commercial name of the applied consumable (product), differentiating available product providers and product lots.</para>
    ///   <a href="http://w3id.org/emmo-hpo/hpo#MouldReleaseLayerIdentifier">hpo:MouldReleaseLayerIdentifier</a>
    /// </summary>
    let MouldReleaseLayerIdentifier = _prefixId.prefix "MouldReleaseLayerIdentifier"
    /// <summary>
    ///   <para>skos:prefLabel : MouldReleaseLayerProperty</para>
    ///   <para>rdfs:label : MouldReleaseLayerProperty</para>
    ///   <para>rdfs:comment : A collection of the properties of the release layer of a mould or tool.</para>
    ///   <para>http://w3id.org/emmo#elucidation : A collection of the properties of the release layer of a mould or tool.</para>
    ///   <a href="http://w3id.org/emmo-hpo/hpo#MouldReleaseLayerProperty">hpo:MouldReleaseLayerProperty</a>
    /// </summary>
    let MouldReleaseLayerProperty = _prefixId.prefix "MouldReleaseLayerProperty"
    /// <summary>
    ///   <para>skos:prefLabel : MouldTool</para>
    ///   <para>rdfs:label : MouldTool</para>
    ///   <para>rdfs:isDefinedBy : https://www.compositesworld.com/glossary^^xsd:anyURI</para>
    ///   <para>rdfs:comment : An enclosed cavity or open form from which a composite component takes its shape, size and exterior surface appearance (also known as a tool).</para>
    ///   <para>http://w3id.org/emmo#elucidation : An enclosed cavity or open form from which a composite component takes its shape, size and exterior surface appearance (also known as a tool).</para>
    ///   <a href="http://w3id.org/emmo-hpo/hpo#MouldTool">hpo:MouldTool</a>
    /// </summary>
    let MouldTool = _prefixId.prefix "MouldTool"
    /// <summary>
    ///   <para>skos:prefLabel : MouldToolLength</para>
    ///   <para>rdfs:label : MouldToolLength</para>
    ///   <para>rdfs:comment : Length (contributing to the size of the tool).</para>
    ///   <para>http://w3id.org/emmo#elucidation : Length (contributing to the size of the tool).</para>
    ///   <a href="http://w3id.org/emmo-hpo/hpo#MouldToolLength">hpo:MouldToolLength</a>
    /// </summary>
    let MouldToolLength = _prefixId.prefix "MouldToolLength"
    /// <summary>
    ///   <para>skos:prefLabel : MouldToolProperty</para>
    ///   <para>rdfs:label : MouldToolProperty</para>
    ///   <para>rdfs:comment : A collection of the properties of moulds or tools.</para>
    ///   <para>http://w3id.org/emmo#elucidation : A collection of the properties of moulds or tools.</para>
    ///   <a href="http://w3id.org/emmo-hpo/hpo#MouldToolProperty">hpo:MouldToolProperty</a>
    /// </summary>
    let MouldToolProperty = _prefixId.prefix "MouldToolProperty"
    /// <summary>
    ///   <para>skos:prefLabel : MouldToolSurfaceRoughness</para>
    ///   <para>rdfs:label : MouldToolSurfaceRoughness</para>
    ///   <para>rdfs:comment : Arithmetic average of the absolute values of the profile height deviations from the mean line, recorded within the evaluation length.</para>
    ///   <para>http://w3id.org/emmo#elucidation : Arithmetic average of the absolute values of the profile height deviations from the mean line, recorded within the evaluation length.</para>
    ///   <a href="http://w3id.org/emmo-hpo/hpo#MouldToolSurfaceRoughness">hpo:MouldToolSurfaceRoughness</a>
    /// </summary>
    let MouldToolSurfaceRoughness = _prefixId.prefix "MouldToolSurfaceRoughness"
    /// <summary>
    ///   <para>skos:prefLabel : MouldToolWidth</para>
    ///   <para>rdfs:label : MouldToolWidth</para>
    ///   <para>rdfs:comment : Width (contributing to the size of the tool).</para>
    ///   <para>http://w3id.org/emmo#elucidation : Width (contributing to the size of the tool).</para>
    ///   <a href="http://w3id.org/emmo-hpo/hpo#MouldToolWidth">hpo:MouldToolWidth</a>
    /// </summary>
    let MouldToolWidth = _prefixId.prefix "MouldToolWidth"
    /// <summary>
    ///   <para>skos:prefLabel : NaturalPolymer</para>
    ///   <para>rdfs:label : NaturalPolymer</para>
    ///   <para>http://w3id.org/emmo#example : DNA, cellulose.</para>
    ///   <para>rdfs:comment : A naturally occurring polymer produced by living organisms.</para>
    ///   <para>http://w3id.org/emmo#elucidation : A naturally occurring polymer produced by living organisms.</para>
    ///   <a href="http://w3id.org/emmo-hpo/hpo#NaturalPolymer">hpo:NaturalPolymer</a>
    /// </summary>
    let NaturalPolymer = _prefixId.prefix "NaturalPolymer"
    /// <summary>
    ///   <para>skos:prefLabel : PartsTurnover</para>
    ///   <para>rdfs:label : PartsTurnover</para>
    ///   <para>rdfs:comment : Parts manufactured per minute.</para>
    ///   <para>http://w3id.org/emmo#elucidation : Parts manufactured per minute.</para>
    ///   <a href="http://w3id.org/emmo-hpo/hpo#PartsTurnover">hpo:PartsTurnover</a>
    /// </summary>
    let PartsTurnover = _prefixId.prefix "PartsTurnover"
    /// <summary>
    ///   <para>skos:prefLabel : PorosityInferredFromDensity</para>
    ///   <para>rdfs:label : PorosityInferredFromDensity</para>
    ///   <para>rdfs:comment : After cutting a test sample out of the specimen to be tested, gravimetric and volumetric findings are used to calculate an (average) density that is compared to the density of a qualified (reference) “in order (i.o.)” specimen.</para>
    ///   <para>http://w3id.org/emmo#elucidation : After cutting a test sample out of the specimen to be tested, gravimetric and volumetric findings are used to calculate an (average) density that is compared to the density of a qualified (reference) “in order (i.o.)” specimen.</para>
    ///   <a href="http://w3id.org/emmo-hpo/hpo#PorosityInferredFromDensity">hpo:PorosityInferredFromDensity</a>
    /// </summary>
    let PorosityInferredFromDensity = _prefixId.prefix "PorosityInferredFromDensity"
    /// <summary>
    ///   <para>skos:prefLabel : Prepreg</para>
    ///   <para>rdfs:label : Prepreg</para>
    ///   <para>rdfs:isDefinedBy : https://compositesuk.co.uk/composite-materials/glossary-terms^^xsd:anyURI</para>
    ///   <para>rdfs:comment : A factory-made combination of reactive resins and reinforcing fibres, plus other necessary additive chemicals, ready to be moulded.</para>
    ///   <para>http://w3id.org/emmo#elucidation : A factory-made combination of reactive resins and reinforcing fibres, plus other necessary additive chemicals, ready to be moulded.</para>
    ///   <a href="http://w3id.org/emmo-hpo/hpo#Prepreg">hpo:Prepreg</a>
    /// </summary>
    let Prepreg = _prefixId.prefix "Prepreg"
    /// <summary>
    ///   <para>skos:prefLabel : PrepregCuringDegree</para>
    ///   <para>rdfs:label : PrepregCuringDegree</para>
    ///   <para>rdfs:comment : Percentage of the (feasible) curing (that is no more available for cross-linking reaction(s))</para>
    ///   <para>http://w3id.org/emmo#elucidation : Percentage of the (feasible) curing (that is no more available for cross-linking reaction(s))</para>
    ///   <a href="http://w3id.org/emmo-hpo/hpo#PrepregCuringDegree">hpo:PrepregCuringDegree</a>
    /// </summary>
    let PrepregCuringDegree = _prefixId.prefix "PrepregCuringDegree"
    /// <summary>
    ///   <para>skos:prefLabel : PrepregDensity</para>
    ///   <para>rdfs:label : PrepregDensity</para>
    ///   <para>rdfs:comment : Mass per unit volume of the prepreg.</para>
    ///   <para>http://w3id.org/emmo#elucidation : Mass per unit volume of the prepreg.</para>
    ///   <a href="http://w3id.org/emmo-hpo/hpo#PrepregDensity">hpo:PrepregDensity</a>
    /// </summary>
    let PrepregDensity = _prefixId.prefix "PrepregDensity"

    /// <summary>
    ///   <para>skos:prefLabel : PrepregExpectedElongationAtBreak</para>
    ///   <para>rdfs:label : PrepregExpectedElongationAtBreak</para>
    ///   <para>rdfs:comment : EXPECTED ratio between increased length and initial length after breakage AFTER CURING.</para>
    ///   <para>http://w3id.org/emmo#elucidation : EXPECTED ratio between increased length and initial length after breakage AFTER CURING.</para>
    ///   <a href="http://w3id.org/emmo-hpo/hpo#PrepregExpectedElongationAtBreak">hpo:PrepregExpectedElongationAtBreak</a>
    /// </summary>
    let PrepregExpectedElongationAtBreak =
        _prefixId.prefix "PrepregExpectedElongationAtBreak"

    /// <summary>
    ///   <para>skos:prefLabel : PrepregExpectedFlexualModulus</para>
    ///   <para>rdfs:label : PrepregExpectedFlexualModulus</para>
    ///   <para>rdfs:comment : EXPECTED Tangent of the stress-strain curve under flexural stress AFTER CURING.</para>
    ///   <para>http://w3id.org/emmo#elucidation : EXPECTED Tangent of the stress-strain curve under flexural stress AFTER CURING.</para>
    ///   <a href="http://w3id.org/emmo-hpo/hpo#PrepregExpectedFlexualModulus">hpo:PrepregExpectedFlexualModulus</a>
    /// </summary>
    let PrepregExpectedFlexualModulus = _prefixId.prefix "PrepregExpectedFlexualModulus"

    /// <summary>
    ///   <para>skos:prefLabel : PrepregExpectedFlexuralStrength</para>
    ///   <para>rdfs:label : PrepregExpectedFlexuralStrength</para>
    ///   <para>rdfs:comment : EXPECTED Maximum value of the stress-strain curve under flexural stress AFTER CURING.</para>
    ///   <para>http://w3id.org/emmo#elucidation : EXPECTED Maximum value of the stress-strain curve under flexural stress AFTER CURING.</para>
    ///   <a href="http://w3id.org/emmo-hpo/hpo#PrepregExpectedFlexuralStrength">hpo:PrepregExpectedFlexuralStrength</a>
    /// </summary>
    let PrepregExpectedFlexuralStrength =
        _prefixId.prefix "PrepregExpectedFlexuralStrength"

    /// <summary>
    ///   <para>skos:prefLabel : PrepregExpectedTensileModulus</para>
    ///   <para>rdfs:label : PrepregExpectedTensileModulus</para>
    ///   <para>rdfs:comment : EXPECTED Tangent of the stress-strain curve under tensile stress AFTER CURING.</para>
    ///   <para>http://w3id.org/emmo#elucidation : EXPECTED Tangent of the stress-strain curve under tensile stress AFTER CURING.</para>
    ///   <a href="http://w3id.org/emmo-hpo/hpo#PrepregExpectedTensileModulus">hpo:PrepregExpectedTensileModulus</a>
    /// </summary>
    let PrepregExpectedTensileModulus = _prefixId.prefix "PrepregExpectedTensileModulus"

    /// <summary>
    ///   <para>skos:prefLabel : PrepregExpectedTensileStrength</para>
    ///   <para>rdfs:label : PrepregExpectedTensileStrength</para>
    ///   <para>rdfs:comment : EXPECTED Maximum value of the stress-strain curve under tensile stress AFTER CURING.</para>
    ///   <para>http://w3id.org/emmo#elucidation : EXPECTED Maximum value of the stress-strain curve under tensile stress AFTER CURING.</para>
    ///   <a href="http://w3id.org/emmo-hpo/hpo#PrepregExpectedTensileStrength">hpo:PrepregExpectedTensileStrength</a>
    /// </summary>
    let PrepregExpectedTensileStrength =
        _prefixId.prefix "PrepregExpectedTensileStrength"

    /// <summary>
    ///   <para>skos:prefLabel : PrepregFibreVolumeContent</para>
    ///   <para>rdfs:label : PrepregFibreVolumeContent</para>
    ///   <para>rdfs:comment : Ratio between the volume of fibre and the volume of the composite.</para>
    ///   <para>http://w3id.org/emmo#elucidation : Ratio between the volume of fibre and the volume of the composite.</para>
    ///   <a href="http://w3id.org/emmo-hpo/hpo#PrepregFibreVolumeContent">hpo:PrepregFibreVolumeContent</a>
    /// </summary>
    let PrepregFibreVolumeContent = _prefixId.prefix "PrepregFibreVolumeContent"

    /// <summary>
    ///   <para>skos:prefLabel : PrepregGlassTransitionTemperature</para>
    ///   <para>rdfs:label : PrepregGlassTransitionTemperature</para>
    ///   <para>rdfs:comment : Characteristic temperature (range) of the process in which a polymer melt changes on cooling to a polymer glass or a polymer glass changes on heating to a polymer melt.</para>
    ///   <para>http://w3id.org/emmo#elucidation : Characteristic temperature (range) of the process in which a polymer melt changes on cooling to a polymer glass or a polymer glass changes on heating to a polymer melt.</para>
    ///   <a href="http://w3id.org/emmo-hpo/hpo#PrepregGlassTransitionTemperature">hpo:PrepregGlassTransitionTemperature</a>
    /// </summary>
    let PrepregGlassTransitionTemperature =
        _prefixId.prefix "PrepregGlassTransitionTemperature"

    /// <summary>
    ///   <para>skos:prefLabel : PrepregLine</para>
    ///   <para>rdfs:label : PrepregLine</para>
    ///   <para>rdfs:comment : A manufacturing line processing a prepreg for later use.</para>
    ///   <para>http://w3id.org/emmo#elucidation : A manufacturing line processing a prepreg for later use.</para>
    ///   <a href="http://w3id.org/emmo-hpo/hpo#PrepregLine">hpo:PrepregLine</a>
    /// </summary>
    let PrepregLine = _prefixId.prefix "PrepregLine"
    /// <summary>
    ///   <para>skos:prefLabel : PrepregPiece</para>
    ///   <para>rdfs:label : PrepregPiece</para>
    ///   <para>skos:altLabel : PrepregPartskos:altLabel : Ply</para>
    ///   <para>rdfs:comment : A prepreg a piece cut from a prepreg roll, which can be stacked.</para>
    ///   <para>http://w3id.org/emmo#elucidation : A prepreg a piece cut from a prepreg roll, which can be stacked.</para>
    ///   <a href="http://w3id.org/emmo-hpo/hpo#PrepregPiece">hpo:PrepregPiece</a>
    /// </summary>
    let PrepregPiece = _prefixId.prefix "PrepregPiece"
    /// <summary>
    ///   <para>skos:prefLabel : PrepregProperty</para>
    ///   <para>rdfs:label : PrepregProperty</para>
    ///   <para>rdfs:comment : A collection of the properties of prepregs.</para>
    ///   <para>http://w3id.org/emmo#elucidation : A collection of the properties of prepregs.</para>
    ///   <a href="http://w3id.org/emmo-hpo/hpo#PrepregProperty">hpo:PrepregProperty</a>
    /// </summary>
    let PrepregProperty = _prefixId.prefix "PrepregProperty"
    /// <summary>
    ///   <para>skos:prefLabel : PrepregRoll</para>
    ///   <para>rdfs:label : PrepregRoll</para>
    ///   <para>rdfs:comment : A roll of prepreg material.</para>
    ///   <para>http://w3id.org/emmo#elucidation : A roll of prepreg material.</para>
    ///   <a href="http://w3id.org/emmo-hpo/hpo#PrepregRoll">hpo:PrepregRoll</a>
    /// </summary>
    let PrepregRoll = _prefixId.prefix "PrepregRoll"

    /// <summary>
    ///   <para>skos:prefLabel : PrepregSpecificCondensateFormation</para>
    ///   <para>rdfs:label : PrepregSpecificCondensateFormation</para>
    ///   <para>rdfs:comment : Mass of water released per mass of prepreg throughout the applied chemical (curing) reaction.</para>
    ///   <para>http://w3id.org/emmo#elucidation : Mass of water released per mass of prepreg throughout the applied chemical (curing) reaction.</para>
    ///   <a href="http://w3id.org/emmo-hpo/hpo#PrepregSpecificCondensateFormation">hpo:PrepregSpecificCondensateFormation</a>
    /// </summary>
    let PrepregSpecificCondensateFormation =
        _prefixId.prefix "PrepregSpecificCondensateFormation"

    /// <summary>
    ///   <para>skos:prefLabel : PrepregThickness</para>
    ///   <para>rdfs:label : PrepregThickness</para>
    ///   <para>rdfs:comment : Thickness of the prepreg.</para>
    ///   <para>http://w3id.org/emmo#elucidation : Thickness of the prepreg.</para>
    ///   <a href="http://w3id.org/emmo-hpo/hpo#PrepregThickness">hpo:PrepregThickness</a>
    /// </summary>
    let PrepregThickness = _prefixId.prefix "PrepregThickness"
    /// <summary>
    ///   <para>skos:prefLabel : PrepregWaterContent</para>
    ///   <para>rdfs:label : PrepregWaterContent</para>
    ///   <para>rdfs:comment : Weight percentage of water in the prepreg (that can be dried and is not formed during the curing reaction).</para>
    ///   <para>http://w3id.org/emmo#elucidation : Weight percentage of water in the prepreg (that can be dried and is not formed during the curing reaction).</para>
    ///   <a href="http://w3id.org/emmo-hpo/hpo#PrepregWaterContent">hpo:PrepregWaterContent</a>
    /// </summary>
    let PrepregWaterContent = _prefixId.prefix "PrepregWaterContent"

    /// <summary>
    ///   <para>skos:prefLabel : PrepregWaterDiffusionCoefficient</para>
    ///   <para>rdfs:label : PrepregWaterDiffusionCoefficient</para>
    ///   <para>rdfs:comment : Effective and anisotropic proportionality constant between the molar (or mass) flux due to molecular diffusion (out of the prepreg specimen).</para>
    ///   <para>http://w3id.org/emmo#elucidation : Effective and anisotropic proportionality constant between the molar (or mass) flux due to molecular diffusion (out of the prepreg specimen).</para>
    ///   <a href="http://w3id.org/emmo-hpo/hpo#PrepregWaterDiffusionCoefficient">hpo:PrepregWaterDiffusionCoefficient</a>
    /// </summary>
    let PrepregWaterDiffusionCoefficient =
        _prefixId.prefix "PrepregWaterDiffusionCoefficient"

    /// <summary>
    ///   <para>skos:prefLabel : PrepregWidth</para>
    ///   <para>rdfs:label : PrepregWidth</para>
    ///   <para>rdfs:comment : Width of the prepreg.</para>
    ///   <para>http://w3id.org/emmo#elucidation : Width of the prepreg.</para>
    ///   <a href="http://w3id.org/emmo-hpo/hpo#PrepregWidth">hpo:PrepregWidth</a>
    /// </summary>
    let PrepregWidth = _prefixId.prefix "PrepregWidth"
    /// <summary>
    ///   <para>http://w3id.org/emmo#elucidation : The process of prepreg manufacturing.</para>
    ///   <para>rdfs:label : Prepregging</para>
    ///   <para>rdfs:comment : The process of prepreg manufacturing.</para>
    ///   <para>skos:prefLabel : Prepregging</para>
    ///   <a href="http://w3id.org/emmo-hpo/hpo#Prepregging">hpo:Prepregging</a>
    /// </summary>
    let Prepregging = _prefixId.prefix "Prepregging"
    /// <summary>
    ///   <para>skos:prefLabel : ReleaseLayer</para>
    ///   <para>rdfs:label : ReleaseLayer</para>
    ///   <para>rdfs:isDefinedBy : https://compositesuk.co.uk/composite-materials/glossary-terms^^xsd:anyURI</para>
    ///   <para>rdfs:comment : A specially formulated material placed between the mold and uncured resin/fiber (usually sprayed or painted on the mold surface) to prevent permanent bonding between the two during cure and facilitates demolding after cure.</para>
    ///   <para>http://w3id.org/emmo#elucidation : A specially formulated material placed between the mold and uncured resin/fiber (usually sprayed or painted on the mold surface) to prevent permanent bonding between the two during cure and facilitates demolding after cure.</para>
    ///   <a href="http://w3id.org/emmo-hpo/hpo#ReleaseLayer">hpo:ReleaseLayer</a>
    /// </summary>
    let ReleaseLayer = _prefixId.prefix "ReleaseLayer"
    /// <summary>
    ///   <para>skos:prefLabel : Resin</para>
    ///   <para>rdfs:label : Resin</para>
    ///   <para>rdfs:seeAlso : https://doi.org/10.1351/goldbook.RT07166</para>
    ///   <para>rdfs:comment : Soft solid or highly viscous substance, usually containing prepolymers with reactive groups.</para>
    ///   <para>http://w3id.org/emmo#elucidation : Soft solid or highly viscous substance, usually containing prepolymers with reactive groups.</para>
    ///   <a href="http://w3id.org/emmo-hpo/hpo#Resin">hpo:Resin</a>
    /// </summary>
    let Resin = _prefixId.prefix "Resin"
    /// <summary>
    ///   <para>skos:prefLabel : ResinComposition</para>
    ///   <para>rdfs:label : ResinComposition</para>
    ///   <para>rdfs:comment : Total composition of the resin.</para>
    ///   <para>http://w3id.org/emmo#elucidation : Total composition of the resin.</para>
    ///   <a href="http://w3id.org/emmo-hpo/hpo#ResinComposition">hpo:ResinComposition</a>
    /// </summary>
    let ResinComposition = _prefixId.prefix "ResinComposition"
    /// <summary>
    ///   <para>skos:prefLabel : ResinDensity</para>
    ///   <para>rdfs:label : ResinDensity</para>
    ///   <para>rdfs:comment : Mass density of the resin.</para>
    ///   <para>http://w3id.org/emmo#elucidation : Mass density of the resin.</para>
    ///   <a href="http://w3id.org/emmo-hpo/hpo#ResinDensity">hpo:ResinDensity</a>
    /// </summary>
    let ResinDensity = _prefixId.prefix "ResinDensity"
    /// <summary>
    ///   <para>skos:prefLabel : ResinIngredient</para>
    ///   <para>rdfs:label : ResinIngredient</para>
    ///   <para>rdfs:comment : Intermediate mixture to make a formulation that allows formulated resin differentiation.</para>
    ///   <para>http://w3id.org/emmo#elucidation : Intermediate mixture to make a formulation that allows formulated resin differentiation.</para>
    ///   <a href="http://w3id.org/emmo-hpo/hpo#ResinIngredient">hpo:ResinIngredient</a>
    /// </summary>
    let ResinIngredient = _prefixId.prefix "ResinIngredient"
    /// <summary>
    ///   <para>skos:prefLabel : ResinMixer</para>
    ///   <para>rdfs:label : ResinMixer</para>
    ///   <para>rdfs:comment : A batch resin mixer.</para>
    ///   <para>http://w3id.org/emmo#elucidation : A batch resin mixer.</para>
    ///   <a href="http://w3id.org/emmo-hpo/hpo#ResinMixer">hpo:ResinMixer</a>
    /// </summary>
    let ResinMixer = _prefixId.prefix "ResinMixer"
    /// <summary>
    ///   <para>skos:prefLabel : ResinMolecularWeight</para>
    ///   <para>rdfs:label : ResinMolecularWeight</para>
    ///   <para>rdfs:comment : Average molecular weight of the main resin molecular consituents.</para>
    ///   <para>http://w3id.org/emmo#elucidation : Average molecular weight of the main resin molecular consituents.</para>
    ///   <a href="http://w3id.org/emmo-hpo/hpo#ResinMolecularWeight">hpo:ResinMolecularWeight</a>
    /// </summary>
    let ResinMolecularWeight = _prefixId.prefix "ResinMolecularWeight"
    /// <summary>
    ///   <para>skos:prefLabel : ResinPreparation</para>
    ///   <para>rdfs:comment : Preparing a resin involves mixing the precursor (monomers) with a hardener or a catalyst, fillers, and additives.</para>
    ///   <para>http://w3id.org/emmo#elucidation : Preparing a resin involves mixing the precursor (monomers) with a hardener or a catalyst, fillers, and additives.</para>
    ///   <para>rdfs:label : ResinPreparation</para>
    ///   <a href="http://w3id.org/emmo-hpo/hpo#ResinPreparation">hpo:ResinPreparation</a>
    /// </summary>
    let ResinPreparation = _prefixId.prefix "ResinPreparation"
    /// <summary>
    ///   <para>skos:prefLabel : ResinProperty</para>
    ///   <para>rdfs:label : ResinProperty</para>
    ///   <para>rdfs:comment : A collection of the properties of resins.</para>
    ///   <para>http://w3id.org/emmo#elucidation : A collection of the properties of resins.</para>
    ///   <a href="http://w3id.org/emmo-hpo/hpo#ResinProperty">hpo:ResinProperty</a>
    /// </summary>
    let ResinProperty = _prefixId.prefix "ResinProperty"
    /// <summary>
    ///   <para>skos:prefLabel : ResinReactivity</para>
    ///   <para>rdfs:label : ResinReactivity</para>
    ///   <para>rdfs:comment : Maximum amount of energy released in case of complete conversion.</para>
    ///   <para>http://w3id.org/emmo#elucidation : Maximum amount of energy released in case of complete conversion.</para>
    ///   <a href="http://w3id.org/emmo-hpo/hpo#ResinReactivity">hpo:ResinReactivity</a>
    /// </summary>
    let ResinReactivity = _prefixId.prefix "ResinReactivity"
    /// <summary>
    ///   <para>skos:prefLabel : ResinViscosity</para>
    ///   <para>rdfs:label : ResinViscosity</para>
    ///   <para>rdfs:comment : Viscosity at 25°C.</para>
    ///   <para>http://w3id.org/emmo#elucidation : Viscosity at 25°C.</para>
    ///   <a href="http://w3id.org/emmo-hpo/hpo#ResinViscosity">hpo:ResinViscosity</a>
    /// </summary>
    let ResinViscosity = _prefixId.prefix "ResinViscosity"
    /// <summary>
    ///   <para>skos:prefLabel : ResinWaterContent</para>
    ///   <para>rdfs:label : ResinWaterContent</para>
    ///   <para>rdfs:comment : Percentage of water in the base resin.</para>
    ///   <para>http://w3id.org/emmo#elucidation : Percentage of water in the base resin.</para>
    ///   <a href="http://w3id.org/emmo-hpo/hpo#ResinWaterContent">hpo:ResinWaterContent</a>
    /// </summary>
    let ResinWaterContent = _prefixId.prefix "ResinWaterContent"
    /// <summary>
    ///   <para>skos:prefLabel : ResinpH</para>
    ///   <para>rdfs:label : ResinpH</para>
    ///   <para>rdfs:comment : pH of the resin.</para>
    ///   <para>http://w3id.org/emmo#elucidation : pH of the resin.</para>
    ///   <a href="http://w3id.org/emmo-hpo/hpo#ResinpH">hpo:ResinpH</a>
    /// </summary>
    let ResinpH = _prefixId.prefix "ResinpH"
    /// <summary>
    ///   <para>skos:altLabel : Bioplastics</para>
    ///   <para>rdfs:label : SemiSyntheticPolymer</para>
    ///   <para>http://w3id.org/emmo#elucidation : A polymer synthesised from biomass sources.</para>
    ///   <para>rdfs:comment : A polymer synthesised from biomass sources.</para>
    ///   <para>skos:prefLabel : SemiSyntheticPolymer</para>
    ///   <para>http://w3id.org/emmo#example : Polylactic acid, celluloid.</para>
    ///   <a href="http://w3id.org/emmo-hpo/hpo#SemiSyntheticPolymer">hpo:SemiSyntheticPolymer</a>
    /// </summary>
    let SemiSyntheticPolymer = _prefixId.prefix "SemiSyntheticPolymer"
    /// <summary>
    ///   <para>rdfs:label : ShapingAndCuring</para>
    ///   <para>rdfs:comment : The process of shaping composite materials into a solid mass of prescribed shape and size, using a mold or tool.</para>
    ///   <para>rdfs:isDefinedBy : https://www.compositesworld.com/glossary</para>
    ///   <para>http://w3id.org/emmo#elucidation : The process of shaping composite materials into a solid mass of prescribed shape and size, using a mold or tool.</para>
    ///   <para>skos:prefLabel : ShapingAndCuring</para>
    ///   <para>skos:altLabel : Moulding</para>
    ///   <a href="http://w3id.org/emmo-hpo/hpo#ShapingAndCuring">hpo:ShapingAndCuring</a>
    /// </summary>
    let ShapingAndCuring = _prefixId.prefix "ShapingAndCuring"
    /// <summary>
    ///   <para>skos:prefLabel : SkeletalFormula</para>
    ///   <para>rdfs:label : SkeletalFormula</para>
    ///   <para>rdfs:comment : A 2-dimensional representation of chemical structures of organic compounds, showing the chemical bonds as lines, carbon atoms as vertices, and hetero atoms with labels. Hydrogen atoms are omitted in the representation since their presence can be derived from the valence of carbon atoms.</para>
    ///   <para>http://w3id.org/emmo#elucidation : A 2-dimensional representation of chemical structures of organic compounds, showing the chemical bonds as lines, carbon atoms as vertices, and hetero atoms with labels. Hydrogen atoms are omitted in the representation since their presence can be derived from the valence of carbon atoms.</para>
    ///   <a href="http://w3id.org/emmo-hpo/hpo#SkeletalFormula">hpo:SkeletalFormula</a>
    /// </summary>
    let SkeletalFormula = _prefixId.prefix "SkeletalFormula"
    /// <summary>
    ///   <para>skos:prefLabel : StackedPrepreg</para>
    ///   <para>rdfs:label : StackedPrepreg</para>
    ///   <para>rdfs:isDefinedBy : https://www.compositesworld.com/glossary^^xsd:anyURI</para>
    ///   <para>rdfs:comment : Arrangement of ply prepregs in a laminate.</para>
    ///   <para>http://w3id.org/emmo#elucidation : Arrangement of ply prepregs in a laminate.</para>
    ///   <a href="http://w3id.org/emmo-hpo/hpo#StackedPrepreg">hpo:StackedPrepreg</a>
    /// </summary>
    let StackedPrepreg = _prefixId.prefix "StackedPrepreg"
    /// <summary>
    ///   <para>skos:prefLabel : StackedPrepregLength</para>
    ///   <para>rdfs:label : StackedPrepregLength</para>
    ///   <para>rdfs:comment : Length (contributing to the size of the object).</para>
    ///   <para>http://w3id.org/emmo#elucidation : Length (contributing to the size of the object).</para>
    ///   <a href="http://w3id.org/emmo-hpo/hpo#StackedPrepregLength">hpo:StackedPrepregLength</a>
    /// </summary>
    let StackedPrepregLength = _prefixId.prefix "StackedPrepregLength"

    /// <summary>
    ///   <para>skos:prefLabel : StackedPrepregNominalThickness</para>
    ///   <para>rdfs:label : StackedPrepregNominalThickness</para>
    ///   <para>rdfs:comment : Sum of the thicknesses of prepreg layer.</para>
    ///   <para>http://w3id.org/emmo#elucidation : Sum of the thicknesses of prepreg layer.</para>
    ///   <a href="http://w3id.org/emmo-hpo/hpo#StackedPrepregNominalThickness">hpo:StackedPrepregNominalThickness</a>
    /// </summary>
    let StackedPrepregNominalThickness =
        _prefixId.prefix "StackedPrepregNominalThickness"

    /// <summary>
    ///   <para>skos:prefLabel : StackedPrepregNumberOfLayers</para>
    ///   <para>rdfs:label : StackedPrepregNumberOfLayers</para>
    ///   <para>rdfs:comment : Number of stacked prepreg layers</para>
    ///   <para>http://w3id.org/emmo#elucidation : Number of stacked prepreg layers</para>
    ///   <a href="http://w3id.org/emmo-hpo/hpo#StackedPrepregNumberOfLayers">hpo:StackedPrepregNumberOfLayers</a>
    /// </summary>
    let StackedPrepregNumberOfLayers = _prefixId.prefix "StackedPrepregNumberOfLayers"
    /// <summary>
    ///   <para>skos:prefLabel : StackedPrepregProperty</para>
    ///   <para>rdfs:label : StackedPrepregProperty</para>
    ///   <para>rdfs:comment : A collection of the properties of stacked prepregs.</para>
    ///   <para>http://w3id.org/emmo#elucidation : A collection of the properties of stacked prepregs.</para>
    ///   <a href="http://w3id.org/emmo-hpo/hpo#StackedPrepregProperty">hpo:StackedPrepregProperty</a>
    /// </summary>
    let StackedPrepregProperty = _prefixId.prefix "StackedPrepregProperty"

    /// <summary>
    ///   <para>skos:prefLabel : StackedPrepregStackingSequence</para>
    ///   <para>rdfs:label : StackedPrepregStackingSequence</para>
    ///   <para>rdfs:comment : List of the orientation (degreees) of each prepreg layer.</para>
    ///   <para>http://w3id.org/emmo#elucidation : List of the orientation (degreees) of each prepreg layer.</para>
    ///   <a href="http://w3id.org/emmo-hpo/hpo#StackedPrepregStackingSequence">hpo:StackedPrepregStackingSequence</a>
    /// </summary>
    let StackedPrepregStackingSequence =
        _prefixId.prefix "StackedPrepregStackingSequence"

    /// <summary>
    ///   <para>skos:prefLabel : StackedPrepregWidth</para>
    ///   <para>rdfs:label : StackedPrepregWidth</para>
    ///   <para>rdfs:comment : Width (contributing to the size of the object).</para>
    ///   <para>http://w3id.org/emmo#elucidation : Width (contributing to the size of the object).</para>
    ///   <a href="http://w3id.org/emmo-hpo/hpo#StackedPrepregWidth">hpo:StackedPrepregWidth</a>
    /// </summary>
    let StackedPrepregWidth = _prefixId.prefix "StackedPrepregWidth"
    /// <summary>
    ///   <para>rdfs:isDefinedBy : https://www.compositesworld.com/glossary^^xsd:anyURI</para>
    ///   <para>skos:prefLabel : Stacking</para>
    ///   <para>rdfs:comment : An arrangement of prepreg parts (ply) orientations and material components in a laminate specified with respect to some reference direction.</para>
    ///   <para>rdfs:label : Stacking</para>
    ///   <para>http://w3id.org/emmo#elucidation : An arrangement of prepreg parts (ply) orientations and material components in a laminate specified with respect to some reference direction.</para>
    ///   <a href="http://w3id.org/emmo-hpo/hpo#Stacking">hpo:Stacking</a>
    /// </summary>
    let Stacking = _prefixId.prefix "Stacking"
    /// <summary>
    ///   <para>skos:prefLabel : StepDuration</para>
    ///   <para>rdfs:label : StepDuration</para>
    ///   <para>rdfs:comment : Step duration</para>
    ///   <para>http://w3id.org/emmo#elucidation : Step duration</para>
    ///   <a href="http://w3id.org/emmo-hpo/hpo#StepDuration">hpo:StepDuration</a>
    /// </summary>
    let StepDuration = _prefixId.prefix "StepDuration"
    /// <summary>
    ///   <para>skos:prefLabel : StorageModulus</para>
    ///   <para>rdfs:label : StorageModulus</para>
    ///   <para>rdfs:comment : The storage modulus in viscoelastic materials measure the stored energy representing the elastic portion.</para>
    ///   <para>http://w3id.org/emmo#elucidation : The storage modulus in viscoelastic materials measure the stored energy representing the elastic portion.</para>
    ///   <a href="http://w3id.org/emmo-hpo/hpo#StorageModulus">hpo:StorageModulus</a>
    /// </summary>
    let StorageModulus = _prefixId.prefix "StorageModulus"
    /// <summary>
    ///   <para>skos:prefLabel : SyntheticPolymer</para>
    ///   <para>rdfs:label : SyntheticPolymer</para>
    ///   <para>http://w3id.org/emmo#example : Polyethylene, polystyrene.</para>
    ///   <para>rdfs:comment : A polymer synthesised from other manufactured chemicals.</para>
    ///   <para>http://w3id.org/emmo#elucidation : A polymer synthesised from other manufactured chemicals.</para>
    ///   <a href="http://w3id.org/emmo-hpo/hpo#SyntheticPolymer">hpo:SyntheticPolymer</a>
    /// </summary>
    let SyntheticPolymer = _prefixId.prefix "SyntheticPolymer"
    /// <summary>
    ///   <para>skos:prefLabel : TensileModulus</para>
    ///   <para>rdfs:label : TensileModulus</para>
    ///   <para>rdfs:comment : Tangent of the stress-strain curve under tensile stress.</para>
    ///   <para>http://w3id.org/emmo#elucidation : Tangent of the stress-strain curve under tensile stress.</para>
    ///   <a href="http://w3id.org/emmo-hpo/hpo#TensileModulus">hpo:TensileModulus</a>
    /// </summary>
    let TensileModulus = _prefixId.prefix "TensileModulus"
    /// <summary>
    ///   <para>skos:prefLabel : TensileStrength</para>
    ///   <para>rdfs:label : TensileStrength</para>
    ///   <para>rdfs:comment : Maximum value of the stress-strain curve under tensile stress.</para>
    ///   <para>http://w3id.org/emmo#elucidation : Maximum value of the stress-strain curve under tensile stress.</para>
    ///   <a href="http://w3id.org/emmo-hpo/hpo#TensileStrength">hpo:TensileStrength</a>
    /// </summary>
    let TensileStrength = _prefixId.prefix "TensileStrength"
    /// <summary>
    ///   <para>skos:prefLabel : TextileFabric</para>
    ///   <para>rdfs:label : TextileFabric</para>
    ///   <para>rdfs:comment : A planar textile constructed with fibres (or yarns), which can be either woven (interlaced using a weaving process) or non-woven (not interlaced).</para>
    ///   <para>http://w3id.org/emmo#elucidation : A planar textile constructed with fibres (or yarns), which can be either woven (interlaced using a weaving process) or non-woven (not interlaced).</para>
    ///   <a href="http://w3id.org/emmo-hpo/hpo#TextileFabric">hpo:TextileFabric</a>
    /// </summary>
    let TextileFabric = _prefixId.prefix "TextileFabric"
    /// <summary>
    ///   <para>skos:prefLabel : TextileFabricProperty</para>
    ///   <para>rdfs:label : TextileFabricProperty</para>
    ///   <para>rdfs:comment : A collection of the properties of textile fabrics.</para>
    ///   <para>http://w3id.org/emmo#elucidation : A collection of the properties of textile fabrics.</para>
    ///   <a href="http://w3id.org/emmo-hpo/hpo#TextileFabricProperty">hpo:TextileFabricProperty</a>
    /// </summary>
    let TextileFabricProperty = _prefixId.prefix "TextileFabricProperty"
    /// <summary>
    ///   <para>skos:prefLabel : TextileFabricThickness</para>
    ///   <para>rdfs:label : TextileFabricThickness</para>
    ///   <para>rdfs:comment : Textile fabric thickness</para>
    ///   <para>http://w3id.org/emmo#elucidation : Textile fabric thickness</para>
    ///   <a href="http://w3id.org/emmo-hpo/hpo#TextileFabricThickness">hpo:TextileFabricThickness</a>
    /// </summary>
    let TextileFabricThickness = _prefixId.prefix "TextileFabricThickness"
    /// <summary>
    ///   <para>skos:prefLabel : TextileFabricWeaveStyle</para>
    ///   <para>rdfs:label : TextileFabricWeaveStyle</para>
    ///   <para>skos:altLabel : TextileConstruction</para>
    ///   <para>rdfs:comment : Pattern of fibre weaving.</para>
    ///   <para>http://w3id.org/emmo#elucidation : Pattern of fibre weaving.</para>
    ///   <a href="http://w3id.org/emmo-hpo/hpo#TextileFabricWeaveStyle">hpo:TextileFabricWeaveStyle</a>
    /// </summary>
    let TextileFabricWeaveStyle = _prefixId.prefix "TextileFabricWeaveStyle"
    /// <summary>
    ///   <para>skos:prefLabel : TextileFabricWidth</para>
    ///   <para>rdfs:label : TextileFabricWidth</para>
    ///   <para>rdfs:comment : Width of the fabric.</para>
    ///   <para>http://w3id.org/emmo#elucidation : Width of the fabric.</para>
    ///   <a href="http://w3id.org/emmo-hpo/hpo#TextileFabricWidth">hpo:TextileFabricWidth</a>
    /// </summary>
    let TextileFabricWidth = _prefixId.prefix "TextileFabricWidth"
    /// <summary>
    ///   <para>skos:prefLabel : ThermoplasticPolymer</para>
    ///   <para>rdfs:label : ThermoplasticPolymer</para>
    ///   <para>http://w3id.org/emmo#example : Polyacrylic acids, Polylactic acid, Polycarbonate.</para>
    ///   <para>rdfs:comment : A polymer that becomes pliable and mouldable (i.e. plastic) above a certain temperature, and that reversibly solidifies upon cooling. Thermoplastics typically have linear chains and high molecular weight, increasing the strength of intermolecular interactions.</para>
    ///   <para>http://w3id.org/emmo#elucidation : A polymer that becomes pliable and mouldable (i.e. plastic) above a certain temperature, and that reversibly solidifies upon cooling. Thermoplastics typically have linear chains and high molecular weight, increasing the strength of intermolecular interactions.</para>
    ///   <a href="http://w3id.org/emmo-hpo/hpo#ThermoplasticPolymer">hpo:ThermoplasticPolymer</a>
    /// </summary>
    let ThermoplasticPolymer = _prefixId.prefix "ThermoplasticPolymer"
    /// <summary>
    ///   <para>skos:prefLabel : ThermosettingPolymer</para>
    ///   <para>rdfs:label : ThermosettingPolymer</para>
    ///   <para>http://w3id.org/emmo#example : Epoxy resins, Polyurethanes.</para>
    ///   <para>rdfs:comment : A polymer that becomes irreversibly hard by creating an extensive network of cross-linking between the individual chains.</para>
    ///   <para>http://w3id.org/emmo#elucidation : A polymer that becomes irreversibly hard by creating an extensive network of cross-linking between the individual chains.</para>
    ///   <a href="http://w3id.org/emmo-hpo/hpo#ThermosettingPolymer">hpo:ThermosettingPolymer</a>
    /// </summary>
    let ThermosettingPolymer = _prefixId.prefix "ThermosettingPolymer"
    /// <summary>
    ///   <para>skos:prefLabel : Volatile</para>
    ///   <para>rdfs:label : Volatile</para>
    ///   <para>skos:altLabel : Solvent</para>
    ///   <para>rdfs:isDefinedBy : https://www.compositesworld.com/glossary^^xsd:anyURI</para>
    ///   <para>rdfs:comment : Solvents, such as water and alcohol, in a sizing or resin formulation that can be vaporized at ambient or slightly elevated temperatures.</para>
    ///   <para>http://w3id.org/emmo#elucidation : Solvents, such as water and alcohol, in a sizing or resin formulation that can be vaporized at ambient or slightly elevated temperatures.</para>
    ///   <a href="http://w3id.org/emmo-hpo/hpo#Volatile">hpo:Volatile</a>
    /// </summary>
    let Volatile = _prefixId.prefix "Volatile"
    /// <summary>
    ///   <para>skos:prefLabel : WorkingStepsOrder</para>
    ///   <para>rdfs:label : WorkingStepsOrder</para>
    ///   <para>rdfs:comment : List of steps for the mixing process.</para>
    ///   <para>http://w3id.org/emmo#elucidation : List of steps for the mixing process.</para>
    ///   <a href="http://w3id.org/emmo-hpo/hpo#WorkingStepsOrder">hpo:WorkingStepsOrder</a>
    /// </summary>
    let WorkingStepsOrder = _prefixId.prefix "WorkingStepsOrder"
