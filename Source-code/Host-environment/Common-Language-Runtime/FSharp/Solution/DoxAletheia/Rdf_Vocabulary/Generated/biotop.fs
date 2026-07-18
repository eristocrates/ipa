namespace http.purl.org.biotop.biotop.owl.hash

open DoxAletheia.Rdf_Vocabulary

module biotop =
    let _namespace_name = "http://purl.org/biotop/biotop.owl#"

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#ImmaterialThreeDimensionalPhysicalEntity"></see>
    /// </summary>
    let ImmaterialThreeDimensionalPhysicalEntity =
        Namespaced_IRI.parse _namespace_name "ImmaterialThreeDimensionalPhysicalEntity" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#OneDimensionalPhysicalEntity"></see>
    /// </summary>
    let OneDimensionalPhysicalEntity =
        Namespaced_IRI.parse _namespace_name "OneDimensionalPhysicalEntity" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#TwoDimensionalPhysicalEntity"></see>
    /// </summary>
    let TwoDimensionalPhysicalEntity =
        Namespaced_IRI.parse _namespace_name "TwoDimensionalPhysicalEntity" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#ImmunologicRole"></see>
    /// </summary>
    let ImmunologicRole =
        Namespaced_IRI.parse _namespace_name "ImmunologicRole" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#SignallingRole"></see>
    /// </summary>
    let SignallingRole =
        Namespaced_IRI.parse _namespace_name "SignallingRole" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#VitaminRole"></see>
    /// </summary>
    let VitaminRole =
        Namespaced_IRI.parse _namespace_name "VitaminRole" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#Alga"></see>
    /// </summary>
    let Alga = Namespaced_IRI.parse _namespace_name "Alga" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#AnimalIncludingHuman"></see>
    /// </summary>
    let AnimalIncludingHuman =
        Namespaced_IRI.parse _namespace_name "AnimalIncludingHuman" |> NamespacedName

    /// <summary>
    /// On fungus organisms
    /// <see href="http://purl.org/biotop/biotop.owl#Fungus"></see></summary>
    let Fungus = Namespaced_IRI.parse _namespace_name "Fungus" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#Plant"></see>
    /// </summary>
    let Plant = Namespaced_IRI.parse _namespace_name "Plant" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#Protist"></see>
    /// </summary>
    let Protist = Namespaced_IRI.parse _namespace_name "Protist" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#GroupInteraction"></see>
    /// </summary>
    let GroupInteraction =
        Namespaced_IRI.parse _namespace_name "GroupInteraction" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#OrganismInteraction"></see>
    /// </summary>
    let OrganismInteraction =
        Namespaced_IRI.parse _namespace_name "OrganismInteraction" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#SubstanceInteraction"></see>
    /// </summary>
    let SubstanceInteraction =
        Namespaced_IRI.parse _namespace_name "SubstanceInteraction" |> NamespacedName

    /// <summary>
    /// EXAMPLE OF TAXON REGION
    /// <see href="http://purl.org/biotop/biotop.owl#KingdomAnimaliaValueRegion"></see></summary>
    let KingdomAnimaliaValueRegion =
        Namespaced_IRI.parse _namespace_name "KingdomAnimaliaValueRegion" |> NamespacedName

    /// <summary>
    /// EXAMPLE OF TAXON REGION
    /// <see href="http://purl.org/biotop/biotop.owl#KingdomArchaeaValueRegion"></see></summary>
    let KingdomArchaeaValueRegion =
        Namespaced_IRI.parse _namespace_name "KingdomArchaeaValueRegion" |> NamespacedName

    /// <summary>
    /// EXAMPLE OF TAXON REGION
    /// <see href="http://purl.org/biotop/biotop.owl#KingdomBacteriaValueRegion"></see></summary>
    let KingdomBacteriaValueRegion =
        Namespaced_IRI.parse _namespace_name "KingdomBacteriaValueRegion" |> NamespacedName

    /// <summary>
    /// EXAMPLE OF TAXON REGION
    /// <see href="http://purl.org/biotop/biotop.owl#KingdomChromistaValueRegion"></see></summary>
    let KingdomChromistaValueRegion =
        Namespaced_IRI.parse _namespace_name "KingdomChromistaValueRegion" |> NamespacedName

    /// <summary>
    /// EXAMPLE OF TAXON REGION
    /// <see href="http://purl.org/biotop/biotop.owl#KingdomFungiValueRegion"></see></summary>
    let KingdomFungiValueRegion =
        Namespaced_IRI.parse _namespace_name "KingdomFungiValueRegion" |> NamespacedName

    /// <summary>
    /// EXAMPLE OF TAXON REGION
    /// <see href="http://purl.org/biotop/biotop.owl#KingdomPlantaeValueRegion"></see></summary>
    let KingdomPlantaeValueRegion =
        Namespaced_IRI.parse _namespace_name "KingdomPlantaeValueRegion" |> NamespacedName

    /// <summary>
    /// EXAMPLE OF TAXON REGION
    /// <see href="http://purl.org/biotop/biotop.owl#KingdomProtozoaValueRegion"></see></summary>
    let KingdomProtozoaValueRegion =
        Namespaced_IRI.parse _namespace_name "KingdomProtozoaValueRegion" |> NamespacedName

    /// <summary>
    /// EXAMPLE OF TAXON REGION
    /// <see href="http://purl.org/biotop/biotop.owl#KingdomVirusesValueRegion"></see></summary>
    let KingdomVirusesValueRegion =
        Namespaced_IRI.parse _namespace_name "KingdomVirusesValueRegion" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#BodySystem"></see>
    /// </summary>
    let BodySystem = Namespaced_IRI.parse _namespace_name "BodySystem" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#Organ"></see>
    /// </summary>
    let Organ = Namespaced_IRI.parse _namespace_name "Organ" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#OrganPart"></see>
    /// </summary>
    let OrganPart = Namespaced_IRI.parse _namespace_name "OrganPart" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#CellMembrane"></see>
    /// </summary>
    let CellMembrane =
        Namespaced_IRI.parse _namespace_name "CellMembrane" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#CellNucleus"></see>
    /// </summary>
    let CellNucleus =
        Namespaced_IRI.parse _namespace_name "CellNucleus" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#Cytoplasm"></see>
    /// </summary>
    let Cytoplasm = Namespaced_IRI.parse _namespace_name "Cytoplasm" |> NamespacedName
    /// <summary>
    /// sum of genetic material in a cell
    /// <see href="http://purl.org/biotop/biotop.owl#Genome"></see></summary>
    let Genome = Namespaced_IRI.parse _namespace_name "Genome" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#EducatorRole"></see>
    /// </summary>
    let EducatorRole =
        Namespaced_IRI.parse _namespace_name "EducatorRole" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#HealthProfessionalRole"></see>
    /// </summary>
    let HealthProfessionalRole =
        Namespaced_IRI.parse _namespace_name "HealthProfessionalRole" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#ResearcherRole"></see>
    /// </summary>
    let ResearcherRole =
        Namespaced_IRI.parse _namespace_name "ResearcherRole" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#FindingRole"></see>
    /// </summary>
    let FindingRole =
        Namespaced_IRI.parse _namespace_name "FindingRole" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#FoodRole"></see>
    /// </summary>
    let FoodRole = Namespaced_IRI.parse _namespace_name "FoodRole" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#PoisonRole"></see>
    /// </summary>
    let PoisonRole = Namespaced_IRI.parse _namespace_name "PoisonRole" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#PreventiveRole"></see>
    /// </summary>
    let PreventiveRole =
        Namespaced_IRI.parse _namespace_name "PreventiveRole" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#SubjectOfCareRole"></see>
    /// </summary>
    let SubjectOfCareRole =
        Namespaced_IRI.parse _namespace_name "SubjectOfCareRole" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#TherapeuticRole"></see>
    /// </summary>
    let TherapeuticRole =
        Namespaced_IRI.parse _namespace_name "TherapeuticRole" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#Electron"></see>
    /// </summary>
    let Electron = Namespaced_IRI.parse _namespace_name "Electron" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#Neutron"></see>
    /// </summary>
    let Neutron = Namespaced_IRI.parse _namespace_name "Neutron" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#Proton"></see>
    /// </summary>
    let Proton = Namespaced_IRI.parse _namespace_name "Proton" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#Disposition"></see>
    /// </summary>
    let Disposition =
        Namespaced_IRI.parse _namespace_name "Disposition" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#ImmaterialObject"></see>
    /// </summary>
    let ImmaterialObject =
        Namespaced_IRI.parse _namespace_name "ImmaterialObject" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#InformationObject"></see>
    /// </summary>
    let InformationObject =
        Namespaced_IRI.parse _namespace_name "InformationObject" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#MaterialObject"></see>
    /// </summary>
    let MaterialObject =
        Namespaced_IRI.parse _namespace_name "MaterialObject" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#Process"></see>
    /// </summary>
    let Process = Namespaced_IRI.parse _namespace_name "Process" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#Quality"></see>
    /// </summary>
    let Quality = Namespaced_IRI.parse _namespace_name "Quality" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#Role"></see>
    /// </summary>
    let Role = Namespaced_IRI.parse _namespace_name "Role" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#Time"></see>
    /// </summary>
    let Time = Namespaced_IRI.parse _namespace_name "Time" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#ValueRegion"></see>
    /// </summary>
    let ValueRegion =
        Namespaced_IRI.parse _namespace_name "ValueRegion" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#AminoAcidOrPeptideMoleculeOrStructure"></see>
    /// </summary>
    let AminoAcidOrPeptideMoleculeOrStructure =
        Namespaced_IRI.parse _namespace_name "AminoAcidOrPeptideMoleculeOrStructure" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#CarbohydrateMoleculeOrResidue"></see>
    /// </summary>
    let CarbohydrateMoleculeOrResidue =
        Namespaced_IRI.parse _namespace_name "CarbohydrateMoleculeOrResidue" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#FattyAcidMoleculeOrResidue"></see>
    /// </summary>
    let FattyAcidMoleculeOrResidue =
        Namespaced_IRI.parse _namespace_name "FattyAcidMoleculeOrResidue" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#HeterocyclicBaseMoleculeOrResidue"></see>
    /// </summary>
    let HeterocyclicBaseMoleculeOrResidue =
        Namespaced_IRI.parse _namespace_name "HeterocyclicBaseMoleculeOrResidue" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#LipidMoleculeOrResidue"></see>
    /// </summary>
    let LipidMoleculeOrResidue =
        Namespaced_IRI.parse _namespace_name "LipidMoleculeOrResidue" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#NucleicAcidNucleotideOrNucleosideMoleculeOrResidue"></see>
    /// </summary>
    let NucleicAcidNucleotideOrNucleosideMoleculeOrResidue =
        Namespaced_IRI.parse _namespace_name "NucleicAcidNucleotideOrNucleosideMoleculeOrResidue" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#BiologicalSizeValueRegion"></see>
    /// </summary>
    let BiologicalSizeValueRegion =
        Namespaced_IRI.parse _namespace_name "BiologicalSizeValueRegion" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#CanonicityValueRegion"></see>
    /// </summary>
    let CanonicityValueRegion =
        Namespaced_IRI.parse _namespace_name "CanonicityValueRegion" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#DevelopmentalValueRegion"></see>
    /// </summary>
    let DevelopmentalValueRegion =
        Namespaced_IRI.parse _namespace_name "DevelopmentalValueRegion" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#StateOfMatterValueRegion"></see>
    /// </summary>
    let StateOfMatterValueRegion =
        Namespaced_IRI.parse _namespace_name "StateOfMatterValueRegion" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#TaxonValueRegion"></see>
    /// </summary>
    let TaxonValueRegion =
        Namespaced_IRI.parse _namespace_name "TaxonValueRegion" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#ChildRole"></see>
    /// </summary>
    let ChildRole = Namespaced_IRI.parse _namespace_name "ChildRole" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#ParentRole"></see>
    /// </summary>
    let ParentRole = Namespaced_IRI.parse _namespace_name "ParentRole" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#SiblingRole"></see>
    /// </summary>
    let SiblingRole =
        Namespaced_IRI.parse _namespace_name "SiblingRole" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#ArtefactRole"></see>
    /// </summary>
    let ArtefactRole =
        Namespaced_IRI.parse _namespace_name "ArtefactRole" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#BiologicalSystemRole"></see>
    /// </summary>
    let BiologicalSystemRole =
        Namespaced_IRI.parse _namespace_name "BiologicalSystemRole" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#ChemicalRole"></see>
    /// </summary>
    let ChemicalRole =
        Namespaced_IRI.parse _namespace_name "ChemicalRole" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#FamilyRole"></see>
    /// </summary>
    let FamilyRole = Namespaced_IRI.parse _namespace_name "FamilyRole" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#HealthRelatedRole"></see>
    /// </summary>
    let HealthRelatedRole =
        Namespaced_IRI.parse _namespace_name "HealthRelatedRole" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#OccupationalRole"></see>
    /// </summary>
    let OccupationalRole =
        Namespaced_IRI.parse _namespace_name "OccupationalRole" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#SpatialReferenceRole"></see>
    /// </summary>
    let SpatialReferenceRole =
        Namespaced_IRI.parse _namespace_name "SpatialReferenceRole" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#NucleicAcidStructure"></see>
    /// </summary>
    let NucleicAcidStructure =
        Namespaced_IRI.parse _namespace_name "NucleicAcidStructure" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#NucleosideMolecule"></see>
    /// </summary>
    let NucleosideMolecule =
        Namespaced_IRI.parse _namespace_name "NucleosideMolecule" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#NucleotideMolecule"></see>
    /// </summary>
    let NucleotideMolecule =
        Namespaced_IRI.parse _namespace_name "NucleotideMolecule" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#Eukaryote"></see>
    /// </summary>
    let Eukaryote = Namespaced_IRI.parse _namespace_name "Eukaryote" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#Prokaryote"></see>
    /// </summary>
    let Prokaryote = Namespaced_IRI.parse _namespace_name "Prokaryote" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#Virus"></see>
    /// </summary>
    let Virus = Namespaced_IRI.parse _namespace_name "Virus" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#Atom"></see>
    /// </summary>
    let Atom = Namespaced_IRI.parse _namespace_name "Atom" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#MonoMolecularEntity"></see>
    /// </summary>
    let MonoMolecularEntity =
        Namespaced_IRI.parse _namespace_name "MonoMolecularEntity" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#PolyMolecularCompositeEntity"></see>
    /// </summary>
    let PolyMolecularCompositeEntity =
        Namespaced_IRI.parse _namespace_name "PolyMolecularCompositeEntity" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#SubatomicParticle"></see>
    /// </summary>
    let SubatomicParticle =
        Namespaced_IRI.parse _namespace_name "SubatomicParticle" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#MoleculeComplex"></see>
    /// </summary>
    let MoleculeComplex =
        Namespaced_IRI.parse _namespace_name "MoleculeComplex" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#StructuredBiologicalEntity"></see>
    /// </summary>
    let StructuredBiologicalEntity =
        Namespaced_IRI.parse _namespace_name "StructuredBiologicalEntity" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#StructuredNonbiologicalCompound"></see>
    /// </summary>
    let StructuredNonbiologicalCompound =
        Namespaced_IRI.parse _namespace_name "StructuredNonbiologicalCompound" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#AgeQuality"></see>
    /// </summary>
    let AgeQuality = Namespaced_IRI.parse _namespace_name "AgeQuality" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#BiologicalSize"></see>
    /// </summary>
    let BiologicalSize =
        Namespaced_IRI.parse _namespace_name "BiologicalSize" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#Canonicity"></see>
    /// </summary>
    let Canonicity = Namespaced_IRI.parse _namespace_name "Canonicity" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#DevelopmentalQuality"></see>
    /// </summary>
    let DevelopmentalQuality =
        Namespaced_IRI.parse _namespace_name "DevelopmentalQuality" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#PhysicalForce"></see>
    /// </summary>
    let PhysicalForce =
        Namespaced_IRI.parse _namespace_name "PhysicalForce" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#PhysicalLength"></see>
    /// </summary>
    let PhysicalLength =
        Namespaced_IRI.parse _namespace_name "PhysicalLength" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#PhysicalMass"></see>
    /// </summary>
    let PhysicalMass =
        Namespaced_IRI.parse _namespace_name "PhysicalMass" |> NamespacedName

    /// <summary>
    /// former name: StateOfAggregation
    /// <see href="http://purl.org/biotop/biotop.owl#PhysicalState"></see></summary>
    let PhysicalState =
        Namespaced_IRI.parse _namespace_name "PhysicalState" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#PhysicalVolume"></see>
    /// </summary>
    let PhysicalVolume =
        Namespaced_IRI.parse _namespace_name "PhysicalVolume" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#StateOfMatter"></see>
    /// </summary>
    let StateOfMatter =
        Namespaced_IRI.parse _namespace_name "StateOfMatter" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#TaxonQuality"></see>
    /// </summary>
    let TaxonQuality =
        Namespaced_IRI.parse _namespace_name "TaxonQuality" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#Amphibian"></see>
    /// </summary>
    let Amphibian = Namespaced_IRI.parse _namespace_name "Amphibian" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#Bird"></see>
    /// </summary>
    let Bird = Namespaced_IRI.parse _namespace_name "Bird" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#Fish"></see>
    /// </summary>
    let Fish = Namespaced_IRI.parse _namespace_name "Fish" |> NamespacedName
    /// <summary>
    /// one mammal
    /// <see href="http://purl.org/biotop/biotop.owl#Mammal"></see></summary>
    let Mammal = Namespaced_IRI.parse _namespace_name "Mammal" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#Reptile"></see>
    /// </summary>
    let Reptile = Namespaced_IRI.parse _namespace_name "Reptile" |> NamespacedName

    /// <summary>
    /// "adult" as the value of a developmental stage. E.g. a 4 year old dog has a quality which has its value located in "adult value region".
    /// <see href="http://purl.org/biotop/biotop.owl#AdultValueRegion"></see></summary>
    let AdultValueRegion =
        Namespaced_IRI.parse _namespace_name "AdultValueRegion" |> NamespacedName

    /// <summary>
    /// "embryonic" as the value of a developmental stage. E.g. a 3 days old mouse embryo has a quality which has its value located in "embryonic value region".
    /// <see href="http://purl.org/biotop/biotop.owl#EmbryonicValueRegion"></see></summary>
    let EmbryonicValueRegion =
        Namespaced_IRI.parse _namespace_name "EmbryonicValueRegion" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#JuvenileValueRegion"></see>
    /// </summary>
    let JuvenileValueRegion =
        Namespaced_IRI.parse _namespace_name "JuvenileValueRegion" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#HormoneRole"></see>
    /// </summary>
    let HormoneRole =
        Namespaced_IRI.parse _namespace_name "HormoneRole" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#NeuroreactiveRole"></see>
    /// </summary>
    let NeuroreactiveRole =
        Namespaced_IRI.parse _namespace_name "NeuroreactiveRole" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#ReceptorRole"></see>
    /// </summary>
    let ReceptorRole =
        Namespaced_IRI.parse _namespace_name "ReceptorRole" |> NamespacedName

    /// <summary>
    /// "gaseous" as the value of a states of matter.  E.g. a portion of air has a quality which has its value located in "gaseous value region"
    /// <see href="http://purl.org/biotop/biotop.owl#GaseousValueRegion"></see></summary>
    let GaseousValueRegion =
        Namespaced_IRI.parse _namespace_name "GaseousValueRegion" |> NamespacedName

    /// <summary>
    /// "liquid" as the value of a states of matter. E.g. a portion of water has a quality which has its value located in "liquid value region"
    /// <see href="http://purl.org/biotop/biotop.owl#LiquidValueRegion"></see></summary>
    let LiquidValueRegion =
        Namespaced_IRI.parse _namespace_name "LiquidValueRegion" |> NamespacedName

    /// <summary>
    /// "solid" as the value of a states of matter. E.g. a stone has a quality which has its value located in "solid value region"
    /// <see href="http://purl.org/biotop/biotop.owl#SolidValueRegion"></see></summary>
    let SolidValueRegion =
        Namespaced_IRI.parse _namespace_name "SolidValueRegion" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#AnimalLanguage"></see>
    /// </summary>
    let AnimalLanguage =
        Namespaced_IRI.parse _namespace_name "AnimalLanguage" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#HumanLanguage"></see>
    /// </summary>
    let HumanLanguage =
        Namespaced_IRI.parse _namespace_name "HumanLanguage" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#MachineLanguage"></see>
    /// </summary>
    let MachineLanguage =
        Namespaced_IRI.parse _namespace_name "MachineLanguage" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#Eicosanoid"></see>
    /// </summary>
    let Eicosanoid = Namespaced_IRI.parse _namespace_name "Eicosanoid" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#NonSteroidLipid"></see>
    /// </summary>
    let NonSteroidLipid =
        Namespaced_IRI.parse _namespace_name "NonSteroidLipid" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#Steroid"></see>
    /// </summary>
    let Steroid = Namespaced_IRI.parse _namespace_name "Steroid" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#CatalyticRole"></see>
    /// </summary>
    let CatalyticRole =
        Namespaced_IRI.parse _namespace_name "CatalyticRole" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#IndicatorRole"></see>
    /// </summary>
    let IndicatorRole =
        Namespaced_IRI.parse _namespace_name "IndicatorRole" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#ReagentRole"></see>
    /// </summary>
    let ReagentRole =
        Namespaced_IRI.parse _namespace_name "ReagentRole" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#AcquiredAbnormalStructure"></see>
    /// </summary>
    let AcquiredAbnormalStructure =
        Namespaced_IRI.parse _namespace_name "AcquiredAbnormalStructure" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#PathologicalStructure"></see>
    /// </summary>
    let PathologicalStructure =
        Namespaced_IRI.parse _namespace_name "PathologicalStructure" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#CongenitalAbnormalStructure"></see>
    /// </summary>
    let CongenitalAbnormalStructure =
        Namespaced_IRI.parse _namespace_name "CongenitalAbnormalStructure" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#AcquiredPathologicalCondition"></see>
    /// </summary>
    let AcquiredPathologicalCondition =
        Namespaced_IRI.parse _namespace_name "AcquiredPathologicalCondition" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#PathologicalValueRegion"></see>
    /// </summary>
    let PathologicalValueRegion =
        Namespaced_IRI.parse _namespace_name "PathologicalValueRegion" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#CongenitalPathologicalCondition"></see>
    /// </summary>
    let CongenitalPathologicalCondition =
        Namespaced_IRI.parse _namespace_name "CongenitalPathologicalCondition" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#AcquiredPathologicalStaticProcessualEntity"></see>
    /// </summary>
    let AcquiredPathologicalStaticProcessualEntity =
        Namespaced_IRI.parse _namespace_name "AcquiredPathologicalStaticProcessualEntity" |> NamespacedName

    /// <summary>
    /// Condition of an organism that deviates from what is considered normal. Often referred to by the terms "disorder", "disease", "syndrome", "sign", or "symptom". None of these denote clearly delineated ontological categories.
    ///
    /// See disease role etc.
    /// <see href="http://purl.org/biotop/biotop.owl#PathologicalStaticProcessualEntity"></see></summary>
    let PathologicalStaticProcessualEntity =
        Namespaced_IRI.parse _namespace_name "PathologicalStaticProcessualEntity" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#qualityLocated"></see>
    /// </summary>
    let qualityLocated =
        Namespaced_IRI.parse _namespace_name "qualityLocated" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#hasProcessQuality"></see>
    /// </summary>
    let hasProcessQuality =
        Namespaced_IRI.parse _namespace_name "hasProcessQuality" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#Action"></see>
    /// </summary>
    let Action = Namespaced_IRI.parse _namespace_name "Action" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#TimeInterval"></see>
    /// </summary>
    let TimeInterval =
        Namespaced_IRI.parse _namespace_name "TimeInterval" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#hasDuration"></see>
    /// </summary>
    let hasDuration =
        Namespaced_IRI.parse _namespace_name "hasDuration" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#Particular"></see>
    /// </summary>
    let Particular = Namespaced_IRI.parse _namespace_name "Particular" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#hasAgent"></see>
    /// </summary>
    let hasAgent = Namespaced_IRI.parse _namespace_name "hasAgent" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#ActionOnBiologicalSystem"></see>
    /// </summary>
    let ActionOnBiologicalSystem =
        Namespaced_IRI.parse _namespace_name "ActionOnBiologicalSystem" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#LivingOrganism"></see>
    /// </summary>
    let LivingOrganism =
        Namespaced_IRI.parse _namespace_name "LivingOrganism" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#properPhysicalPartOf"></see>
    /// </summary>
    let properPhysicalPartOf =
        Namespaced_IRI.parse _namespace_name "properPhysicalPartOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#hasPatient"></see>
    /// </summary>
    let hasPatient = Namespaced_IRI.parse _namespace_name "hasPatient" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#AdultOrganism"></see>
    /// </summary>
    let AdultOrganism =
        Namespaced_IRI.parse _namespace_name "AdultOrganism" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#OrganismByDevelopmentalStagePartition"></see>
    /// </summary>
    let OrganismByDevelopmentalStagePartition =
        Namespaced_IRI.parse _namespace_name "OrganismByDevelopmentalStagePartition" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#EmbryonicOrganism"></see>
    /// </summary>
    let EmbryonicOrganism =
        Namespaced_IRI.parse _namespace_name "EmbryonicOrganism" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#JuvenileOrganism"></see>
    /// </summary>
    let JuvenileOrganism =
        Namespaced_IRI.parse _namespace_name "JuvenileOrganism" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#bearerOf"></see>
    /// </summary>
    let bearerOf = Namespaced_IRI.parse _namespace_name "bearerOf" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#Affecting"></see>
    /// </summary>
    let Affecting = Namespaced_IRI.parse _namespace_name "Affecting" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#inheresIn"></see>
    /// </summary>
    let inheresIn = Namespaced_IRI.parse _namespace_name "inheresIn" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#ObjectQuality"></see>
    /// </summary>
    let ObjectQuality =
        Namespaced_IRI.parse _namespace_name "ObjectQuality" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#AlphaParticle"></see>
    /// </summary>
    let AlphaParticle =
        Namespaced_IRI.parse _namespace_name "AlphaParticle" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#hasProperPhysicalPart"></see>
    /// </summary>
    let hasProperPhysicalPart =
        Namespaced_IRI.parse _namespace_name "hasProperPhysicalPart" |> NamespacedName

    /// <summary>
    /// (QCR) ro:hasPart some CarbonHydrogenSubstructure and ((hasComponent myx 2 CarboxyGroup) and (hasComponent min 1 CarboxyGroup) and (hasComponent exactly 1 AminoGroup)) or ((hasComponent max 2 AminoGroup) and (hasComponent min 1 AminoGroup) and (hasComponent exactly 1 CarboxyGroup))
    /// In chemistry, an amino acid is any molecule that contains both amine and carboxyl functional groups. However, in biochemistry, this more general term is frequently used to refer to alpha amino acids (amino acids in which the amino and carboxylate functionalities are attached to the same carbon, called ?–carbon). Amino Acids have at least one amino and one carboxy group. Those having two carboxy groups have only one amino group and vice versa.
    /// <see href="http://purl.org/biotop/biotop.owl#AminoAcidMoleculeOrResidue"></see></summary>
    let AminoAcidMoleculeOrResidue =
        Namespaced_IRI.parse _namespace_name "AminoAcidMoleculeOrResidue" |> NamespacedName

    /// <summary>
    /// A submolecular group or moiety is a group of covalently bound atoms that occurs only as part of a molecule
    /// <see href="http://purl.org/biotop/biotop.owl#SubmolecularGroup"></see></summary>
    let SubmolecularGroup =
        Namespaced_IRI.parse _namespace_name "SubmolecularGroup" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#hasComponentPart"></see>
    /// </summary>
    let hasComponentPart =
        Namespaced_IRI.parse _namespace_name "hasComponentPart" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#Monomer"></see>
    /// </summary>
    let Monomer = Namespaced_IRI.parse _namespace_name "Monomer" |> NamespacedName

    /// <summary>
    /// Comment: We here use the term peptide in the most general sense, viz. a oligo or polymer made out of amino acids.
    /// <see href="http://purl.org/biotop/biotop.owl#PeptideStructure"></see></summary>
    let PeptideStructure =
        Namespaced_IRI.parse _namespace_name "PeptideStructure" |> NamespacedName

    /// <summary>
    /// Ontologically irrelevant partitioning node. Used for improving ontology housekeeping. Its purpose is to express that all subclasses are mutually disjoint.
    /// <see href="http://purl.org/biotop/biotop.owl#OrganicMolecularEntityPartition"></see></summary>
    let OrganicMolecularEntityPartition =
        Namespaced_IRI.parse _namespace_name "OrganicMolecularEntityPartition" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#AminoAcidSequence"></see>
    /// </summary>
    let AminoAcidSequence =
        Namespaced_IRI.parse _namespace_name "AminoAcidSequence" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#AminoAcidSequenceInformation"></see>
    /// </summary>
    let AminoAcidSequenceInformation =
        Namespaced_IRI.parse _namespace_name "AminoAcidSequenceInformation" |> NamespacedName

    /// <summary>
    /// Place for currently non maintained classes. It should be assured that they are not being referred to by application ontologies that import BioTop
    /// <see href="http://purl.org/biotop/biotop.owl#DEPRECATED"></see></summary>
    let DEPRECATED = Namespaced_IRI.parse _namespace_name "DEPRECATED" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#AmountOfBodySubstance"></see>
    /// </summary>
    let AmountOfBodySubstance =
        Namespaced_IRI.parse _namespace_name "AmountOfBodySubstance" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#CompoundOfCollectiveMaterialEntities"></see>
    /// </summary>
    let CompoundOfCollectiveMaterialEntities =
        Namespaced_IRI.parse _namespace_name "CompoundOfCollectiveMaterialEntities" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#AmountOfPureSubstance"></see>
    /// </summary>
    let AmountOfPureSubstance =
        Namespaced_IRI.parse _namespace_name "AmountOfPureSubstance" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#hasGranularPart"></see>
    /// </summary>
    let hasGranularPart =
        Namespaced_IRI.parse _namespace_name "hasGranularPart" |> NamespacedName

    /// <summary>
    /// The fuzzyness of this class is due to the "same sort" criterion.
    /// <see href="http://purl.org/biotop/biotop.owl#CollectiveMaterialEntity"></see></summary>
    let CollectiveMaterialEntity =
        Namespaced_IRI.parse _namespace_name "CollectiveMaterialEntity" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#PluralityOfOrganisms"></see>
    /// </summary>
    let PluralityOfOrganisms =
        Namespaced_IRI.parse _namespace_name "PluralityOfOrganisms" |> NamespacedName

    /// <summary>
    /// one vertebrate
    /// <see href="http://purl.org/biotop/biotop.owl#Vertebrate"></see></summary>
    let Vertebrate = Namespaced_IRI.parse _namespace_name "Vertebrate" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#Analyzing"></see>
    /// </summary>
    let Analyzing = Namespaced_IRI.parse _namespace_name "Analyzing" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#HumanAction"></see>
    /// </summary>
    let HumanAction =
        Namespaced_IRI.parse _namespace_name "HumanAction" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#AnimalCell"></see>
    /// </summary>
    let AnimalCell = Namespaced_IRI.parse _namespace_name "AnimalCell" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#CellByTaxonPartition"></see>
    /// </summary>
    let CellByTaxonPartition =
        Namespaced_IRI.parse _namespace_name "CellByTaxonPartition" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#BacterialCell"></see>
    /// </summary>
    let BacterialCell =
        Namespaced_IRI.parse _namespace_name "BacterialCell" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#PlantCell"></see>
    /// </summary>
    let PlantCell = Namespaced_IRI.parse _namespace_name "PlantCell" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#Cell"></see>
    /// </summary>
    let Cell = Namespaced_IRI.parse _namespace_name "Cell" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#AnimalExcludingHuman"></see>
    /// </summary>
    let AnimalExcludingHuman =
        Namespaced_IRI.parse _namespace_name "AnimalExcludingHuman" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#Human"></see>
    /// </summary>
    let Human = Namespaced_IRI.parse _namespace_name "Human" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#LanguagePartition"></see>
    /// </summary>
    let LanguagePartition =
        Namespaced_IRI.parse _namespace_name "LanguagePartition" |> NamespacedName

    /// <summary>
    /// EXAMPLE OF POPULATION
    /// <see href="http://purl.org/biotop/biotop.owl#AnimalPopulation"></see></summary>
    let AnimalPopulation =
        Namespaced_IRI.parse _namespace_name "AnimalPopulation" |> NamespacedName

    /// <summary>
    /// all child classes of population are only meant as examples demonstrating how population classes can be postcoordinated
    /// <see href="http://purl.org/biotop/biotop.owl#Population"></see></summary>
    let Population = Namespaced_IRI.parse _namespace_name "Population" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#AntibioticRole"></see>
    /// </summary>
    let AntibioticRole =
        Namespaced_IRI.parse _namespace_name "AntibioticRole" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#DrugRole"></see>
    /// </summary>
    let DrugRole = Namespaced_IRI.parse _namespace_name "DrugRole" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#ArchaebacterialCell"></see>
    /// </summary>
    let ArchaebacterialCell =
        Namespaced_IRI.parse _namespace_name "ArchaebacterialCell" |> NamespacedName

    /// <summary>
    /// one arthropod
    /// <see href="http://purl.org/biotop/biotop.owl#Arthropod"></see></summary>
    let Arthropod = Namespaced_IRI.parse _namespace_name "Arthropod" |> NamespacedName

    /// <summary>
    /// EXAMPLE OF TAXON REGION
    /// <see href="http://purl.org/biotop/biotop.owl#PhylumArthropodaValueRegion"></see></summary>
    let PhylumArthropodaValueRegion =
        Namespaced_IRI.parse _namespace_name "PhylumArthropodaValueRegion" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#Invertebrate"></see>
    /// </summary>
    let Invertebrate =
        Namespaced_IRI.parse _namespace_name "Invertebrate" |> NamespacedName

    /// <summary>
    /// EXAMPLE OF POPULATION
    /// <see href="http://purl.org/biotop/biotop.owl#ArthropodPopulation"></see></summary>
    let ArthropodPopulation =
        Namespaced_IRI.parse _namespace_name "ArthropodPopulation" |> NamespacedName

    /// <summary>
    /// MaterialEntityBySizePartition
    ///
    /// Ontologically irrelevant partitioning node. Used for improving ontology housekeeping. Its purpose is to express that all subclasses are mutually disjoint.
    /// <see href="http://purl.org/biotop/biotop.owl#MaterialEntityBySizePartition"></see></summary>
    let MaterialEntityBySizePartition =
        Namespaced_IRI.parse _namespace_name "MaterialEntityBySizePartition" |> NamespacedName

    /// <summary>
    /// EXAMPLE OF POPULATION
    /// <see href="http://purl.org/biotop/biotop.owl#BacteriaPopulation"></see></summary>
    let BacteriaPopulation =
        Namespaced_IRI.parse _namespace_name "BacteriaPopulation" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#BacterialColony"></see>
    /// </summary>
    let BacterialColony =
        Namespaced_IRI.parse _namespace_name "BacterialColony" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#BiologicalColony"></see>
    /// </summary>
    let BiologicalColony =
        Namespaced_IRI.parse _namespace_name "BiologicalColony" |> NamespacedName

    /// <summary>
    /// one saccharomyces cerevisiae cell
    /// <see href="http://purl.org/biotop/biotop.owl#BakersYeastCell"></see></summary>
    let BakersYeastCell =
        Namespaced_IRI.parse _namespace_name "BakersYeastCell" |> NamespacedName

    /// <summary>
    /// EXAMPLE OF TAXON REGION
    /// <see href="http://purl.org/biotop/biotop.owl#SpeciesSaccharomycesCerevisiaeValueRegion"></see></summary>
    let SpeciesSaccharomycesCerevisiaeValueRegion =
        Namespaced_IRI.parse _namespace_name "SpeciesSaccharomycesCerevisiaeValueRegion" |> NamespacedName

    /// <summary>
    /// Unicellular Fungi.
    /// <see href="http://purl.org/biotop/biotop.owl#YeastCell"></see></summary>
    let YeastCell = Namespaced_IRI.parse _namespace_name "YeastCell" |> NamespacedName

    /// <summary>
    /// One candida albicans cell
    /// <see href="http://purl.org/biotop/biotop.owl#CandidaAlbicansCell"></see></summary>
    let CandidaAlbicansCell =
        Namespaced_IRI.parse _namespace_name "CandidaAlbicansCell" |> NamespacedName

    /// <summary>
    /// EXAMPLE OF POPULATION
    /// <see href="http://purl.org/biotop/biotop.owl#BakersYeastPopulation"></see></summary>
    let BakersYeastPopulation =
        Namespaced_IRI.parse _namespace_name "BakersYeastPopulation" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#Behavior"></see>
    /// </summary>
    let Behavior = Namespaced_IRI.parse _namespace_name "Behavior" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#BioMolecularProcess"></see>
    /// </summary>
    let BioMolecularProcess =
        Namespaced_IRI.parse _namespace_name "BioMolecularProcess" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#BiologicalProcessualEntity"></see>
    /// </summary>
    let BiologicalProcessualEntity =
        Namespaced_IRI.parse _namespace_name "BiologicalProcessualEntity" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#hasParticipant"></see>
    /// </summary>
    let hasParticipant =
        Namespaced_IRI.parse _namespace_name "hasParticipant" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#BioMolecularSequenceInformation"></see>
    /// </summary>
    let BioMolecularSequenceInformation =
        Namespaced_IRI.parse _namespace_name "BioMolecularSequenceInformation" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#BioMolecularSequenceStructure"></see>
    /// </summary>
    let BioMolecularSequenceStructure =
        Namespaced_IRI.parse _namespace_name "BioMolecularSequenceStructure" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#OrganicMolecularEntity"></see>
    /// </summary>
    let OrganicMolecularEntity =
        Namespaced_IRI.parse _namespace_name "OrganicMolecularEntity" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#ChainOfCarbohydrateMonomers"></see>
    /// </summary>
    let ChainOfCarbohydrateMonomers =
        Namespaced_IRI.parse _namespace_name "ChainOfCarbohydrateMonomers" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#ChainOfNucleotideMonomers"></see>
    /// </summary>
    let ChainOfNucleotideMonomers =
        Namespaced_IRI.parse _namespace_name "ChainOfNucleotideMonomers" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#DNAChain"></see>
    /// </summary>
    let DNAChain = Namespaced_IRI.parse _namespace_name "DNAChain" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#RNAChain"></see>
    /// </summary>
    let RNAChain = Namespaced_IRI.parse _namespace_name "RNAChain" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#BiologicalAction"></see>
    /// </summary>
    let BiologicalAction =
        Namespaced_IRI.parse _namespace_name "BiologicalAction" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#BiologicalBoundary"></see>
    /// </summary>
    let BiologicalBoundary =
        Namespaced_IRI.parse _namespace_name "BiologicalBoundary" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#PhysicalBoundary"></see>
    /// </summary>
    let PhysicalBoundary =
        Namespaced_IRI.parse _namespace_name "PhysicalBoundary" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#BiologicalSpace"></see>
    /// </summary>
    let BiologicalSpace =
        Namespaced_IRI.parse _namespace_name "BiologicalSpace" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#physicallyBounds"></see>
    /// </summary>
    let physicallyBounds =
        Namespaced_IRI.parse _namespace_name "physicallyBounds" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#BiologicalFunction"></see>
    /// </summary>
    let BiologicalFunction =
        Namespaced_IRI.parse _namespace_name "BiologicalFunction" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#Function"></see>
    /// </summary>
    let Function = Namespaced_IRI.parse _namespace_name "Function" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#BiologicalLife"></see>
    /// </summary>
    let BiologicalLife =
        Namespaced_IRI.parse _namespace_name "BiologicalLife" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#OrganismProcess"></see>
    /// </summary>
    let OrganismProcess =
        Namespaced_IRI.parse _namespace_name "OrganismProcess" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#PhysicalProcessualEntity"></see>
    /// </summary>
    let PhysicalProcessualEntity =
        Namespaced_IRI.parse _namespace_name "PhysicalProcessualEntity" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#hasLocus"></see>
    /// </summary>
    let hasLocus = Namespaced_IRI.parse _namespace_name "hasLocus" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#physicallyContainedIn"></see>
    /// </summary>
    let physicallyContainedIn =
        Namespaced_IRI.parse _namespace_name "physicallyContainedIn" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#BiomedicalMaterialRole"></see>
    /// </summary>
    let BiomedicalMaterialRole =
        Namespaced_IRI.parse _namespace_name "BiomedicalMaterialRole" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#Biomolecule"></see>
    /// </summary>
    let Biomolecule =
        Namespaced_IRI.parse _namespace_name "Biomolecule" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#originatesFrom"></see>
    /// </summary>
    let originatesFrom =
        Namespaced_IRI.parse _namespace_name "originatesFrom" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#Body"></see>
    /// </summary>
    let Body = Namespaced_IRI.parse _namespace_name "Body" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#BodyLiquid"></see>
    /// </summary>
    let BodyLiquid = Namespaced_IRI.parse _namespace_name "BodyLiquid" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#WaterMolecule"></see>
    /// </summary>
    let WaterMolecule =
        Namespaced_IRI.parse _namespace_name "WaterMolecule" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#PortionOfHeterogenousLiquid"></see>
    /// </summary>
    let PortionOfHeterogenousLiquid =
        Namespaced_IRI.parse _namespace_name "PortionOfHeterogenousLiquid" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#OrganismPart"></see>
    /// </summary>
    let OrganismPart =
        Namespaced_IRI.parse _namespace_name "OrganismPart" |> NamespacedName

    /// <summary>
    /// EXAMPLE OF TAXON REGION
    /// <see href="http://purl.org/biotop/biotop.owl#SpeciesCandidaAlbicansValueRegion"></see></summary>
    let SpeciesCandidaAlbicansValueRegion =
        Namespaced_IRI.parse _namespace_name "SpeciesCandidaAlbicansValueRegion" |> NamespacedName

    /// <summary>
    /// EXAMPLE OF POPULATION
    /// <see href="http://purl.org/biotop/biotop.owl#CandidaAlbicansPopulation"></see></summary>
    let CandidaAlbicansPopulation =
        Namespaced_IRI.parse _namespace_name "CandidaAlbicansPopulation" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#CanonicalProcessualEntity"></see>
    /// </summary>
    let CanonicalProcessualEntity =
        Namespaced_IRI.parse _namespace_name "CanonicalProcessualEntity" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#NoncanonicalProcessualEntity"></see>
    /// </summary>
    let NoncanonicalProcessualEntity =
        Namespaced_IRI.parse _namespace_name "NoncanonicalProcessualEntity" |> NamespacedName

    /// <summary>
    /// abstract region in which the value "canonical" of canonicity is located
    /// <see href="http://purl.org/biotop/biotop.owl#CanonicalValueRegion"></see></summary>
    let CanonicalValueRegion =
        Namespaced_IRI.parse _namespace_name "CanonicalValueRegion" |> NamespacedName

    /// <summary>
    /// a biological state that is considered "normal"
    /// <see href="http://purl.org/biotop/biotop.owl#CanonicalStaticProcessualEntity"></see></summary>
    let CanonicalStaticProcessualEntity =
        Namespaced_IRI.parse _namespace_name "CanonicalStaticProcessualEntity" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#NoncanonicalStaticProcessualEntity"></see>
    /// </summary>
    let NoncanonicalStaticProcessualEntity =
        Namespaced_IRI.parse _namespace_name "NoncanonicalStaticProcessualEntity" |> NamespacedName

    /// <summary>
    /// Static condition as a special case of process in which temporal parts are neglected.
    /// <see href="http://purl.org/biotop/biotop.owl#StaticProcessualEntity"></see></summary>
    let StaticProcessualEntity =
        Namespaced_IRI.parse _namespace_name "StaticProcessualEntity" |> NamespacedName

    /// <summary>
    /// abstract region in which the value "noncanonical" of canonicity is located
    /// <see href="http://purl.org/biotop/biotop.owl#NoncanonicalValueRegion"></see></summary>
    let NoncanonicalValueRegion =
        Namespaced_IRI.parse _namespace_name "NoncanonicalValueRegion" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#qualityLocationOf"></see>
    /// </summary>
    let qualityLocationOf =
        Namespaced_IRI.parse _namespace_name "qualityLocationOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#CarbohydrateMonomer"></see>
    /// </summary>
    let CarbohydrateMonomer =
        Namespaced_IRI.parse _namespace_name "CarbohydrateMonomer" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#CarbohydrateSequenceInformation"></see>
    /// </summary>
    let CarbohydrateSequenceInformation =
        Namespaced_IRI.parse _namespace_name "CarbohydrateSequenceInformation" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#CategorizationSystem"></see>
    /// </summary>
    let CategorizationSystem =
        Namespaced_IRI.parse _namespace_name "CategorizationSystem" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#IntellectualProduct"></see>
    /// </summary>
    let IntellectualProduct =
        Namespaced_IRI.parse _namespace_name "IntellectualProduct" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#RegulationOrLaw"></see>
    /// </summary>
    let RegulationOrLaw =
        Namespaced_IRI.parse _namespace_name "RegulationOrLaw" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#Causing"></see>
    /// </summary>
    let Causing = Namespaced_IRI.parse _namespace_name "Causing" |> NamespacedName

    /// <summary>
    /// StructuredBiologicalCompoundByGranularityPartition
    ///
    /// ontologically irrelevant disjoint partition: structured biological compound by granularity
    /// <see href="http://purl.org/biotop/biotop.owl#StructuredBiologicalCompoundByGranularityPartition"></see></summary>
    let StructuredBiologicalCompoundByGranularityPartition =
        Namespaced_IRI.parse _namespace_name "StructuredBiologicalCompoundByGranularityPartition" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#CellularComponent"></see>
    /// </summary>
    let CellularComponent =
        Namespaced_IRI.parse _namespace_name "CellularComponent" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#Syncytium"></see>
    /// </summary>
    let Syncytium = Namespaced_IRI.parse _namespace_name "Syncytium" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#CellByLocusPartition"></see>
    /// </summary>
    let CellByLocusPartition =
        Namespaced_IRI.parse _namespace_name "CellByLocusPartition" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#CellInVivo"></see>
    /// </summary>
    let CellInVivo = Namespaced_IRI.parse _namespace_name "CellInVivo" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#ModifiedCell"></see>
    /// </summary>
    let ModifiedCell =
        Namespaced_IRI.parse _namespace_name "ModifiedCell" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#CellByTypePartition"></see>
    /// </summary>
    let CellByTypePartition =
        Namespaced_IRI.parse _namespace_name "CellByTypePartition" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#CentralNervousSystem"></see>
    /// </summary>
    let CentralNervousSystem =
        Namespaced_IRI.parse _namespace_name "CentralNervousSystem" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#OrganSystem"></see>
    /// </summary>
    let OrganSystem =
        Namespaced_IRI.parse _namespace_name "OrganSystem" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#ChlamydiaCell"></see>
    /// </summary>
    let ChlamydiaCell =
        Namespaced_IRI.parse _namespace_name "ChlamydiaCell" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#RickettsiaCell"></see>
    /// </summary>
    let RickettsiaCell =
        Namespaced_IRI.parse _namespace_name "RickettsiaCell" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#Chromosome"></see>
    /// </summary>
    let Chromosome = Namespaced_IRI.parse _namespace_name "Chromosome" |> NamespacedName

    /// <summary>
    /// not (properPartOf some MonoMolecularEntity)  REMOVED
    /// <see href="http://purl.org/biotop/biotop.owl#EntireNucleicAcidMolecule"></see></summary>
    let EntireNucleicAcidMolecule =
        Namespaced_IRI.parse _namespace_name "EntireNucleicAcidMolecule" |> NamespacedName

    /// <summary>
    /// EXAMPLE OF TAXON REGION
    /// <see href="http://purl.org/biotop/biotop.owl#ClassGammaProteobacteriaValueRegion"></see></summary>
    let ClassGammaProteobacteriaValueRegion =
        Namespaced_IRI.parse _namespace_name "ClassGammaProteobacteriaValueRegion" |> NamespacedName

    /// <summary>
    /// EXAMPLE OF TAXON REGION
    /// <see href="http://purl.org/biotop/biotop.owl#PhylumProteobacteriaValueRegion"></see></summary>
    let PhylumProteobacteriaValueRegion =
        Namespaced_IRI.parse _namespace_name "PhylumProteobacteriaValueRegion" |> NamespacedName

    /// <summary>
    /// EXAMPLE OF TAXON REGION
    /// <see href="http://purl.org/biotop/biotop.owl#ClassInsectaValueRegion"></see></summary>
    let ClassInsectaValueRegion =
        Namespaced_IRI.parse _namespace_name "ClassInsectaValueRegion" |> NamespacedName

    /// <summary>
    /// EXAMPLE OF TAXON REGION
    /// <see href="http://purl.org/biotop/biotop.owl#ClassMammaliaValueRegion"></see></summary>
    let ClassMammaliaValueRegion =
        Namespaced_IRI.parse _namespace_name "ClassMammaliaValueRegion" |> NamespacedName

    /// <summary>
    /// EXAMPLE OF TAXON REGION
    /// <see href="http://purl.org/biotop/biotop.owl#SubphylumVertebrataValueRegion"></see></summary>
    let SubphylumVertebrataValueRegion =
        Namespaced_IRI.parse _namespace_name "SubphylumVertebrataValueRegion" |> NamespacedName

    /// <summary>
    /// EXAMPLE OF TAXON REGION
    /// <see href="http://purl.org/biotop/biotop.owl#ClassSaccharomycetesValueRegion"></see></summary>
    let ClassSaccharomycetesValueRegion =
        Namespaced_IRI.parse _namespace_name "ClassSaccharomycetesValueRegion" |> NamespacedName

    /// <summary>
    /// EXAMPLE OF TAXON REGION
    /// <see href="http://purl.org/biotop/biotop.owl#SubphylumSaccharomycotinaValueRegion"></see></summary>
    let SubphylumSaccharomycotinaValueRegion =
        Namespaced_IRI.parse _namespace_name "SubphylumSaccharomycotinaValueRegion" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#Complicating"></see>
    /// </summary>
    let Complicating =
        Namespaced_IRI.parse _namespace_name "Complicating" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#Condition"></see>
    /// </summary>
    let Condition = Namespaced_IRI.parse _namespace_name "Condition" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#CongenitalPathologicalStaticProcessualEntity"></see>
    /// </summary>
    let CongenitalPathologicalStaticProcessualEntity =
        Namespaced_IRI.parse _namespace_name "CongenitalPathologicalStaticProcessualEntity" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#DEPRECATED_RELATION"></see>
    /// </summary>
    let DEPRECATED_RELATION =
        Namespaced_IRI.parse _namespace_name "DEPRECATED_RELATION" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#DeadBody"></see>
    /// </summary>
    let DeadBody = Namespaced_IRI.parse _namespace_name "DeadBody" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#LivingBody"></see>
    /// </summary>
    let LivingBody = Namespaced_IRI.parse _namespace_name "LivingBody" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#Death"></see>
    /// </summary>
    let Death = Namespaced_IRI.parse _namespace_name "Death" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#PointInTime"></see>
    /// </summary>
    let PointInTime =
        Namespaced_IRI.parse _namespace_name "PointInTime" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#hasPointInTime"></see>
    /// </summary>
    let hasPointInTime =
        Namespaced_IRI.parse _namespace_name "hasPointInTime" |> NamespacedName

    /// <summary>
    /// (OBI 306)
    /// <see href="http://purl.org/biotop/biotop.owl#DigitalEntity"></see></summary>
    let DigitalEntity =
        Namespaced_IRI.parse _namespace_name "DigitalEntity" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#Disrupting"></see>
    /// </summary>
    let Disrupting = Namespaced_IRI.parse _namespace_name "Disrupting" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#SubatomicEntityByChargePartition"></see>
    /// </summary>
    let SubatomicEntityByChargePartition =
        Namespaced_IRI.parse _namespace_name "SubatomicEntityByChargePartition" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#EmbryonicStructure"></see>
    /// </summary>
    let EmbryonicStructure =
        Namespaced_IRI.parse _namespace_name "EmbryonicStructure" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#EntireCarbohydrateMonomer"></see>
    /// </summary>
    let EntireCarbohydrateMonomer =
        Namespaced_IRI.parse _namespace_name "EntireCarbohydrateMonomer" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#EntireMolecularEntity"></see>
    /// </summary>
    let EntireMolecularEntity =
        Namespaced_IRI.parse _namespace_name "EntireMolecularEntity" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#MolecularEntityByEntiretyPartition"></see>
    /// </summary>
    let MolecularEntityByEntiretyPartition =
        Namespaced_IRI.parse _namespace_name "MolecularEntityByEntiretyPartition" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#MolecularResidue"></see>
    /// </summary>
    let MolecularResidue =
        Namespaced_IRI.parse _namespace_name "MolecularResidue" |> NamespacedName

    /// <summary>
    /// (QCR) Peptide and hasComponent min 101 AminoAcidMonomer and not (ro:properPartOf some MolecularEntity)
    /// <see href="http://purl.org/biotop/biotop.owl#EntireProteinMolecule"></see></summary>
    let EntireProteinMolecule =
        Namespaced_IRI.parse _namespace_name "EntireProteinMolecule" |> NamespacedName

    /// <summary>
    /// The role a peptide plays in accelerating a biochemical reaction
    /// <see href="http://purl.org/biotop/biotop.owl#EnzymeRole"></see></summary>
    let EnzymeRole = Namespaced_IRI.parse _namespace_name "EnzymeRole" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#EpithelialCell"></see>
    /// </summary>
    let EpithelialCell =
        Namespaced_IRI.parse _namespace_name "EpithelialCell" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#EscherichiaColiCell"></see>
    /// </summary>
    let EscherichiaColiCell =
        Namespaced_IRI.parse _namespace_name "EscherichiaColiCell" |> NamespacedName

    /// <summary>
    /// EXAMPLE OF TAXON REGION
    /// <see href="http://purl.org/biotop/biotop.owl#SpeciesEscherichiaColiValueRegion"></see></summary>
    let SpeciesEscherichiaColiValueRegion =
        Namespaced_IRI.parse _namespace_name "SpeciesEscherichiaColiValueRegion" |> NamespacedName

    /// <summary>
    /// EXAMPLE OF POPULATION
    /// <see href="http://purl.org/biotop/biotop.owl#EscherichiaColiPopulation"></see></summary>
    let EscherichiaColiPopulation =
        Namespaced_IRI.parse _namespace_name "EscherichiaColiPopulation" |> NamespacedName

    /// <summary>
    /// Ontologically irrelevant partitioning node. Used for improving ontology housekeeping. Its purpose is to express that all subclasses are mutually disjoint.
    /// <see href="http://purl.org/biotop/biotop.owl#OrganismByTaxonPartition"></see></summary>
    let OrganismByTaxonPartition =
        Namespaced_IRI.parse _namespace_name "OrganismByTaxonPartition" |> NamespacedName

    /// <summary>
    /// EXAMPLE OF POPULATION
    /// <see href="http://purl.org/biotop/biotop.owl#EukaryotePopulation"></see></summary>
    let EukaryotePopulation =
        Namespaced_IRI.parse _namespace_name "EukaryotePopulation" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#Event"></see>
    /// </summary>
    let Event = Namespaced_IRI.parse _namespace_name "Event" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#ExaminationResultRole"></see>
    /// </summary>
    let ExaminationResultRole =
        Namespaced_IRI.parse _namespace_name "ExaminationResultRole" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#SignOrSymptomRole"></see>
    /// </summary>
    let SignOrSymptomRole =
        Namespaced_IRI.parse _namespace_name "SignOrSymptomRole" |> NamespacedName

    /// <summary>
    /// EXAMPLE OF TAXON REGION
    /// <see href="http://purl.org/biotop/biotop.owl#FamilyDrosophilidaeValueRegion"></see></summary>
    let FamilyDrosophilidaeValueRegion =
        Namespaced_IRI.parse _namespace_name "FamilyDrosophilidaeValueRegion" |> NamespacedName

    /// <summary>
    /// EXAMPLE OF TAXON REGION
    /// <see href="http://purl.org/biotop/biotop.owl#OrderDipteraValueRegion"></see></summary>
    let OrderDipteraValueRegion =
        Namespaced_IRI.parse _namespace_name "OrderDipteraValueRegion" |> NamespacedName

    /// <summary>
    /// EXAMPLE OF TAXON REGION
    /// <see href="http://purl.org/biotop/biotop.owl#FamilyEnterobacteriaceaeaValueRegion"></see></summary>
    let FamilyEnterobacteriaceaeaValueRegion =
        Namespaced_IRI.parse _namespace_name "FamilyEnterobacteriaceaeaValueRegion" |> NamespacedName

    /// <summary>
    /// EXAMPLE OF TAXON REGION
    /// <see href="http://purl.org/biotop/biotop.owl#OrderEnterobacterialesValueRegion"></see></summary>
    let OrderEnterobacterialesValueRegion =
        Namespaced_IRI.parse _namespace_name "OrderEnterobacterialesValueRegion" |> NamespacedName

    /// <summary>
    /// EXAMPLE OF TAXON REGION
    /// <see href="http://purl.org/biotop/biotop.owl#FamilyHominidaeValueRegion"></see></summary>
    let FamilyHominidaeValueRegion =
        Namespaced_IRI.parse _namespace_name "FamilyHominidaeValueRegion" |> NamespacedName

    /// <summary>
    /// EXAMPLE OF TAXON REGION
    /// <see href="http://purl.org/biotop/biotop.owl#OrderPrimatesValueRegion"></see></summary>
    let OrderPrimatesValueRegion =
        Namespaced_IRI.parse _namespace_name "OrderPrimatesValueRegion" |> NamespacedName

    /// <summary>
    /// unclear classe. to be revised
    /// <see href="http://purl.org/biotop/biotop.owl#FamilyOfIndividualOrganisms"></see></summary>
    let FamilyOfIndividualOrganisms =
        Namespaced_IRI.parse _namespace_name "FamilyOfIndividualOrganisms" |> NamespacedName

    /// <summary>
    /// EXAMPLE OF TAXON REGION
    /// <see href="http://purl.org/biotop/biotop.owl#FamilySaccharomycetaceaeValueRegion"></see></summary>
    let FamilySaccharomycetaceaeValueRegion =
        Namespaced_IRI.parse _namespace_name "FamilySaccharomycetaceaeValueRegion" |> NamespacedName

    /// <summary>
    /// EXAMPLE OF TAXON REGION
    /// <see href="http://purl.org/biotop/biotop.owl#OrderSaccharomycetalesValueRegion"></see></summary>
    let OrderSaccharomycetalesValueRegion =
        Namespaced_IRI.parse _namespace_name "OrderSaccharomycetalesValueRegion" |> NamespacedName

    /// <summary>
    /// one drosophila melanogaster
    /// <see href="http://purl.org/biotop/biotop.owl#FruitFly"></see></summary>
    let FruitFly = Namespaced_IRI.parse _namespace_name "FruitFly" |> NamespacedName

    /// <summary>
    /// EXAMPLE OF TAXON REGION
    /// <see href="http://purl.org/biotop/biotop.owl#SpeciesDrosophilaMelanogasterValueRegion"></see></summary>
    let SpeciesDrosophilaMelanogasterValueRegion =
        Namespaced_IRI.parse _namespace_name "SpeciesDrosophilaMelanogasterValueRegion" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#Insect"></see>
    /// </summary>
    let Insect = Namespaced_IRI.parse _namespace_name "Insect" |> NamespacedName

    /// <summary>
    /// EXAMPLE OF POPULATION
    /// <see href="http://purl.org/biotop/biotop.owl#FruitFlyPopulation"></see></summary>
    let FruitFlyPopulation =
        Namespaced_IRI.parse _namespace_name "FruitFlyPopulation" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#hasRealization"></see>
    /// </summary>
    let hasRealization =
        Namespaced_IRI.parse _namespace_name "hasRealization" |> NamespacedName

    /// <summary>
    /// EXAMPLE OF POPULATION
    /// <see href="http://purl.org/biotop/biotop.owl#FungusPopulation"></see></summary>
    let FungusPopulation =
        Namespaced_IRI.parse _namespace_name "FungusPopulation" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#Gene"></see>
    /// </summary>
    let Gene = Namespaced_IRI.parse _namespace_name "Gene" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#GeneticInformation"></see>
    /// </summary>
    let GeneticInformation =
        Namespaced_IRI.parse _namespace_name "GeneticInformation" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#GeneInformation"></see>
    /// </summary>
    let GeneInformation =
        Namespaced_IRI.parse _namespace_name "GeneInformation" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#GeneRegion"></see>
    /// </summary>
    let GeneRegion = Namespaced_IRI.parse _namespace_name "GeneRegion" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#GenomeInformation"></see>
    /// </summary>
    let GenomeInformation =
        Namespaced_IRI.parse _namespace_name "GenomeInformation" |> NamespacedName

    /// <summary>
    /// EXAMPLE OF TAXON REGION
    /// <see href="http://purl.org/biotop/biotop.owl#GenusCandidaValueRegion"></see></summary>
    let GenusCandidaValueRegion =
        Namespaced_IRI.parse _namespace_name "GenusCandidaValueRegion" |> NamespacedName

    /// <summary>
    /// EXAMPLE OF TAXON REGION
    /// <see href="http://purl.org/biotop/biotop.owl#GenusSaccharomycesValueRegion"></see></summary>
    let GenusSaccharomycesValueRegion =
        Namespaced_IRI.parse _namespace_name "GenusSaccharomycesValueRegion" |> NamespacedName

    /// <summary>
    /// EXAMPLE OF TAXON REGION
    /// <see href="http://purl.org/biotop/biotop.owl#GenusDrosophilaValueRegion"></see></summary>
    let GenusDrosophilaValueRegion =
        Namespaced_IRI.parse _namespace_name "GenusDrosophilaValueRegion" |> NamespacedName

    /// <summary>
    /// EXAMPLE OF TAXON REGION
    /// <see href="http://purl.org/biotop/biotop.owl#SubfamilyDrosophilinaeValueRegion"></see></summary>
    let SubfamilyDrosophilinaeValueRegion =
        Namespaced_IRI.parse _namespace_name "SubfamilyDrosophilinaeValueRegion" |> NamespacedName

    /// <summary>
    /// EXAMPLE OF TAXON REGION
    /// <see href="http://purl.org/biotop/biotop.owl#GenusEscherichiaValueRegion"></see></summary>
    let GenusEscherichiaValueRegion =
        Namespaced_IRI.parse _namespace_name "GenusEscherichiaValueRegion" |> NamespacedName

    /// <summary>
    /// EXAMPLE OF TAXON REGION
    /// <see href="http://purl.org/biotop/biotop.owl#GenusHomoValueRegion"></see></summary>
    let GenusHomoValueRegion =
        Namespaced_IRI.parse _namespace_name "GenusHomoValueRegion" |> NamespacedName

    /// <summary>
    /// previous name "geographic entity"
    /// <see href="http://purl.org/biotop/biotop.owl#GeographicSurface"></see></summary>
    let GeographicSurface =
        Namespaced_IRI.parse _namespace_name "GeographicSurface" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#Government"></see>
    /// </summary>
    let Government = Namespaced_IRI.parse _namespace_name "Government" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#Organization"></see>
    /// </summary>
    let Organization =
        Namespaced_IRI.parse _namespace_name "Organization" |> NamespacedName

    /// <summary>
    /// one great ape
    /// <see href="http://purl.org/biotop/biotop.owl#GreatApe"></see></summary>
    let GreatApe = Namespaced_IRI.parse _namespace_name "GreatApe" |> NamespacedName

    /// <summary>
    /// EXAMPLE OF POPULATION
    /// <see href="http://purl.org/biotop/biotop.owl#GreatApePopulation"></see></summary>
    let GreatApePopulation =
        Namespaced_IRI.parse _namespace_name "GreatApePopulation" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#LegalEntity"></see>
    /// </summary>
    let LegalEntity =
        Namespaced_IRI.parse _namespace_name "LegalEntity" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#Interacting"></see>
    /// </summary>
    let Interacting =
        Namespaced_IRI.parse _namespace_name "Interacting" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#GrowingProcess"></see>
    /// </summary>
    let GrowingProcess =
        Namespaced_IRI.parse _namespace_name "GrowingProcess" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#TissueProcess"></see>
    /// </summary>
    let TissueProcess =
        Namespaced_IRI.parse _namespace_name "TissueProcess" |> NamespacedName

    /// <summary>
    /// EXAMPLE OF TAXON REGION
    /// <see href="http://purl.org/biotop/biotop.owl#SpeciesHomoSapiensValueRegion"></see></summary>
    let SpeciesHomoSapiensValueRegion =
        Namespaced_IRI.parse _namespace_name "SpeciesHomoSapiensValueRegion" |> NamespacedName

    /// <summary>
    /// one primate
    /// <see href="http://purl.org/biotop/biotop.owl#Primate"></see></summary>
    let Primate = Namespaced_IRI.parse _namespace_name "Primate" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#OrganismAction"></see>
    /// </summary>
    let OrganismAction =
        Namespaced_IRI.parse _namespace_name "OrganismAction" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#HumanEpithelialCell"></see>
    /// </summary>
    let HumanEpithelialCell =
        Namespaced_IRI.parse _namespace_name "HumanEpithelialCell" |> NamespacedName

    /// <summary>
    /// EXAMPLE OF POPULATION
    /// <see href="http://purl.org/biotop/biotop.owl#HumanPopulation"></see></summary>
    let HumanPopulation =
        Namespaced_IRI.parse _namespace_name "HumanPopulation" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#HumanReasoning"></see>
    /// </summary>
    let HumanReasoning =
        Namespaced_IRI.parse _namespace_name "HumanReasoning" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#hasOutcome"></see>
    /// </summary>
    let hasOutcome = Namespaced_IRI.parse _namespace_name "hasOutcome" |> NamespacedName
    /// <summary>
    /// negatively affecting a biological system by using physical force
    /// <see href="http://purl.org/biotop/biotop.owl#Hurting"></see></summary>
    let Hurting = Namespaced_IRI.parse _namespace_name "Hurting" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#ImmaterialNonphysicalEntity"></see>
    /// </summary>
    let ImmaterialNonphysicalEntity =
        Namespaced_IRI.parse _namespace_name "ImmaterialNonphysicalEntity" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#hasPhysicalPart"></see>
    /// </summary>
    let hasPhysicalPart =
        Namespaced_IRI.parse _namespace_name "hasPhysicalPart" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#ImmaterialPhysicalEntity"></see>
    /// </summary>
    let ImmaterialPhysicalEntity =
        Namespaced_IRI.parse _namespace_name "ImmaterialPhysicalEntity" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#ImmaterialProcessualEntity"></see>
    /// </summary>
    let ImmaterialProcessualEntity =
        Namespaced_IRI.parse _namespace_name "ImmaterialProcessualEntity" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#Indicating"></see>
    /// </summary>
    let Indicating = Namespaced_IRI.parse _namespace_name "Indicating" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#IndividualBehavior"></see>
    /// </summary>
    let IndividualBehavior =
        Namespaced_IRI.parse _namespace_name "IndividualBehavior" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#SocialBehavior"></see>
    /// </summary>
    let SocialBehavior =
        Namespaced_IRI.parse _namespace_name "SocialBehavior" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#InformationEntity"></see>
    /// </summary>
    let InformationEntity =
        Namespaced_IRI.parse _namespace_name "InformationEntity" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#InorganicMolecularEntity"></see>
    /// </summary>
    let InorganicMolecularEntity =
        Namespaced_IRI.parse _namespace_name "InorganicMolecularEntity" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#MolecularEntityByOrganicInorganicPartition"></see>
    /// </summary>
    let MolecularEntityByOrganicInorganicPartition =
        Namespaced_IRI.parse _namespace_name "MolecularEntityByOrganicInorganicPartition" |> NamespacedName

    /// <summary>
    /// EXAMPLE OF POPULATION
    /// <see href="http://purl.org/biotop/biotop.owl#InsectPopulation"></see></summary>
    let InsectPopulation =
        Namespaced_IRI.parse _namespace_name "InsectPopulation" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#InstantaneousProcess"></see>
    /// </summary>
    let InstantaneousProcess =
        Namespaced_IRI.parse _namespace_name "InstantaneousProcess" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#patientIn"></see>
    /// </summary>
    let patientIn = Namespaced_IRI.parse _namespace_name "patientIn" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#IntraCellularProcess"></see>
    /// </summary>
    let IntraCellularProcess =
        Namespaced_IRI.parse _namespace_name "IntraCellularProcess" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#Language"></see>
    /// </summary>
    let Language = Namespaced_IRI.parse _namespace_name "Language" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#participatesIn"></see>
    /// </summary>
    let participatesIn =
        Namespaced_IRI.parse _namespace_name "participatesIn" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#MachineAction"></see>
    /// </summary>
    let MachineAction =
        Namespaced_IRI.parse _namespace_name "MachineAction" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#MacroscopicValueRegion"></see>
    /// </summary>
    let MacroscopicValueRegion =
        Namespaced_IRI.parse _namespace_name "MacroscopicValueRegion" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#MicroscopicValueRegion"></see>
    /// </summary>
    let MicroscopicValueRegion =
        Namespaced_IRI.parse _namespace_name "MicroscopicValueRegion" |> NamespacedName

    /// <summary>
    /// EXAMPLE OF POPULATION
    /// <see href="http://purl.org/biotop/biotop.owl#MammalPopulation"></see></summary>
    let MammalPopulation =
        Namespaced_IRI.parse _namespace_name "MammalPopulation" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#ManagingCare"></see>
    /// </summary>
    let ManagingCare =
        Namespaced_IRI.parse _namespace_name "ManagingCare" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#MaterialEntity"></see>
    /// </summary>
    let MaterialEntity =
        Namespaced_IRI.parse _namespace_name "MaterialEntity" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#Measure"></see>
    /// </summary>
    let Measure = Namespaced_IRI.parse _namespace_name "Measure" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#MeasurementMethod"></see>
    /// </summary>
    let MeasurementMethod =
        Namespaced_IRI.parse _namespace_name "MeasurementMethod" |> NamespacedName

    /// <summary>
    /// (OBI 344)
    /// <see href="http://purl.org/biotop/biotop.owl#Plan"></see></summary>
    let Plan = Namespaced_IRI.parse _namespace_name "Plan" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#MeasuringAction"></see>
    /// </summary>
    let MeasuringAction =
        Namespaced_IRI.parse _namespace_name "MeasuringAction" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#Membership"></see>
    /// </summary>
    let Membership = Namespaced_IRI.parse _namespace_name "Membership" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#MentalFunction"></see>
    /// </summary>
    let MentalFunction =
        Namespaced_IRI.parse _namespace_name "MentalFunction" |> NamespacedName

    /// <summary>
    /// process in an organism as a realization of a mental function
    /// <see href="http://purl.org/biotop/biotop.owl#MentalProcess"></see></summary>
    let MentalProcess =
        Namespaced_IRI.parse _namespace_name "MentalProcess" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#Microorganism"></see>
    /// </summary>
    let Microorganism =
        Namespaced_IRI.parse _namespace_name "Microorganism" |> NamespacedName

    /// <summary>
    /// Difficult concept. Better to be expressed by the primitive "mental function"
    /// <see href="http://purl.org/biotop/biotop.owl#Mind"></see></summary>
    let Mind = Namespaced_IRI.parse _namespace_name "Mind" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#derivesFrom"></see>
    /// </summary>
    let derivesFrom =
        Namespaced_IRI.parse _namespace_name "derivesFrom" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#MolecularEntityByGranularityPartition"></see>
    /// </summary>
    let MolecularEntityByGranularityPartition =
        Namespaced_IRI.parse _namespace_name "MolecularEntityByGranularityPartition" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#OligoOrPolymer"></see>
    /// </summary>
    let OligoOrPolymer =
        Namespaced_IRI.parse _namespace_name "OligoOrPolymer" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#MolecularFunction"></see>
    /// </summary>
    let MolecularFunction =
        Namespaced_IRI.parse _namespace_name "MolecularFunction" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#componentPartOf"></see>
    /// </summary>
    let componentPartOf =
        Namespaced_IRI.parse _namespace_name "componentPartOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#MulticellularOrganism"></see>
    /// </summary>
    let MulticellularOrganism =
        Namespaced_IRI.parse _namespace_name "MulticellularOrganism" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#NeoplasticProcess"></see>
    /// </summary>
    let NeoplasticProcess =
        Namespaced_IRI.parse _namespace_name "NeoplasticProcess" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#NucleicAcidRegion"></see>
    /// </summary>
    let NucleicAcidRegion =
        Namespaced_IRI.parse _namespace_name "NucleicAcidRegion" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#NucleotideSequenceInformation"></see>
    /// </summary>
    let NucleotideSequenceInformation =
        Namespaced_IRI.parse _namespace_name "NucleotideSequenceInformation" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#NurseRole"></see>
    /// </summary>
    let NurseRole = Namespaced_IRI.parse _namespace_name "NurseRole" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#PhysicianRole"></see>
    /// </summary>
    let PhysicianRole =
        Namespaced_IRI.parse _namespace_name "PhysicianRole" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#ProcessQuality"></see>
    /// </summary>
    let ProcessQuality =
        Namespaced_IRI.parse _namespace_name "ProcessQuality" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#ObservingAction"></see>
    /// </summary>
    let ObservingAction =
        Namespaced_IRI.parse _namespace_name "ObservingAction" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#OneDimensionalBoundary"></see>
    /// </summary>
    let OneDimensionalBoundary =
        Namespaced_IRI.parse _namespace_name "OneDimensionalBoundary" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#TwoDimensionalBoundary"></see>
    /// </summary>
    let TwoDimensionalBoundary =
        Namespaced_IRI.parse _namespace_name "TwoDimensionalBoundary" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#OrganSystemPart"></see>
    /// </summary>
    let OrganSystemPart =
        Namespaced_IRI.parse _namespace_name "OrganSystemPart" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#Tissue"></see>
    /// </summary>
    let Tissue = Namespaced_IRI.parse _namespace_name "Tissue" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#ParticularEntity"></see>
    /// </summary>
    let ParticularEntity =
        Namespaced_IRI.parse _namespace_name "ParticularEntity" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#PathologicalCondition"></see>
    /// </summary>
    let PathologicalCondition =
        Namespaced_IRI.parse _namespace_name "PathologicalCondition" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#PathologicalDisposition"></see>
    /// </summary>
    let PathologicalDisposition =
        Namespaced_IRI.parse _namespace_name "PathologicalDisposition" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#PathologicalProcess"></see>
    /// </summary>
    let PathologicalProcess =
        Namespaced_IRI.parse _namespace_name "PathologicalProcess" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#StructuredBiologicalCompoundByCanonicityPartition"></see>
    /// </summary>
    let StructuredBiologicalCompoundByCanonicityPartition =
        Namespaced_IRI.parse _namespace_name "StructuredBiologicalCompoundByCanonicityPartition" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#WellFormedBiologicalStructure"></see>
    /// </summary>
    let WellFormedBiologicalStructure =
        Namespaced_IRI.parse _namespace_name "WellFormedBiologicalStructure" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#processQualityOf"></see>
    /// </summary>
    let processQualityOf =
        Namespaced_IRI.parse _namespace_name "processQualityOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#PeptideFunction"></see>
    /// </summary>
    let PeptideFunction =
        Namespaced_IRI.parse _namespace_name "PeptideFunction" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#Phosphate"></see>
    /// </summary>
    let Phosphate = Namespaced_IRI.parse _namespace_name "Phosphate" |> NamespacedName

    /// <summary>
    /// EXAMPLE OF TAXON REGION
    /// <see href="http://purl.org/biotop/biotop.owl#PhylumChordataValueRegion"></see></summary>
    let PhylumChordataValueRegion =
        Namespaced_IRI.parse _namespace_name "PhylumChordataValueRegion" |> NamespacedName

    /// <summary>
    /// EXAMPLE OF TAXON REGION
    /// <see href="http://purl.org/biotop/biotop.owl#PhylumAscomycotaValueRegion"></see></summary>
    let PhylumAscomycotaValueRegion =
        Namespaced_IRI.parse _namespace_name "PhylumAscomycotaValueRegion" |> NamespacedName

    /// <summary>
    /// EXAMPLE OF POPULATION
    /// <see href="http://purl.org/biotop/biotop.owl#PlantPopulation"></see></summary>
    let PlantPopulation =
        Namespaced_IRI.parse _namespace_name "PlantPopulation" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#PluralityOfIdenticalPolymolecularEntities"></see>
    /// </summary>
    let PluralityOfIdenticalPolymolecularEntities =
        Namespaced_IRI.parse _namespace_name "PluralityOfIdenticalPolymolecularEntities" |> NamespacedName

    /// <summary>
    /// negatively affecting the integrity of a biologival system caused by one or more chemical substances
    /// <see href="http://purl.org/biotop/biotop.owl#Poisoning"></see></summary>
    let Poisoning = Namespaced_IRI.parse _namespace_name "Poisoning" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#PortionOfHeterogenousSolid"></see>
    /// </summary>
    let PortionOfHeterogenousSolid =
        Namespaced_IRI.parse _namespace_name "PortionOfHeterogenousSolid" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#PortionOfHomogenousMatter"></see>
    /// </summary>
    let PortionOfHomogenousMatter =
        Namespaced_IRI.parse _namespace_name "PortionOfHomogenousMatter" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#PreventionAction"></see>
    /// </summary>
    let PreventionAction =
        Namespaced_IRI.parse _namespace_name "PreventionAction" |> NamespacedName

    /// <summary>
    /// EXAMPLE OF POPULATION
    /// <see href="http://purl.org/biotop/biotop.owl#PrimatePopulation"></see></summary>
    let PrimatePopulation =
        Namespaced_IRI.parse _namespace_name "PrimatePopulation" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#Producing"></see>
    /// </summary>
    let Producing = Namespaced_IRI.parse _namespace_name "Producing" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#ProteinComplex"></see>
    /// </summary>
    let ProteinComplex =
        Namespaced_IRI.parse _namespace_name "ProteinComplex" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#ProteinDomain"></see>
    /// </summary>
    let ProteinDomain =
        Namespaced_IRI.parse _namespace_name "ProteinDomain" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#ProteinSubstructure"></see>
    /// </summary>
    let ProteinSubstructure =
        Namespaced_IRI.parse _namespace_name "ProteinSubstructure" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#ProteinSubunit"></see>
    /// </summary>
    let ProteinSubunit =
        Namespaced_IRI.parse _namespace_name "ProteinSubunit" |> NamespacedName

    /// <summary>
    /// EXAMPLE OF POPULATION
    /// <see href="http://purl.org/biotop/biotop.owl#ProtistPopulation"></see></summary>
    let ProtistPopulation =
        Namespaced_IRI.parse _namespace_name "ProtistPopulation" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#Radiation"></see>
    /// </summary>
    let Radiation = Namespaced_IRI.parse _namespace_name "Radiation" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#Wave"></see>
    /// </summary>
    let Wave = Namespaced_IRI.parse _namespace_name "Wave" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#RegulatoryBody"></see>
    /// </summary>
    let RegulatoryBody =
        Namespaced_IRI.parse _namespace_name "RegulatoryBody" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#SocialAction"></see>
    /// </summary>
    let SocialAction =
        Namespaced_IRI.parse _namespace_name "SocialAction" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#SpatialRegion"></see>
    /// </summary>
    let SpatialRegion =
        Namespaced_IRI.parse _namespace_name "SpatialRegion" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#TemporalEntity"></see>
    /// </summary>
    let TemporalEntity =
        Namespaced_IRI.parse _namespace_name "TemporalEntity" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#Treating"></see>
    /// </summary>
    let Treating = Namespaced_IRI.parse _namespace_name "Treating" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#TreatingCondition"></see>
    /// </summary>
    let TreatingCondition =
        Namespaced_IRI.parse _namespace_name "TreatingCondition" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#TreatingOrganism"></see>
    /// </summary>
    let TreatingOrganism =
        Namespaced_IRI.parse _namespace_name "TreatingOrganism" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#TwoDimensionalBiologicalEntity"></see>
    /// </summary>
    let TwoDimensionalBiologicalEntity =
        Namespaced_IRI.parse _namespace_name "TwoDimensionalBiologicalEntity" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#UnicellularOrganism"></see>
    /// </summary>
    let UnicellularOrganism =
        Namespaced_IRI.parse _namespace_name "UnicellularOrganism" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#UsingAction"></see>
    /// </summary>
    let UsingAction =
        Namespaced_IRI.parse _namespace_name "UsingAction" |> NamespacedName

    /// <summary>
    /// EXAMPLE OF POPULATION
    /// <see href="http://purl.org/biotop/biotop.owl#VertebratePopulation"></see></summary>
    let VertebratePopulation =
        Namespaced_IRI.parse _namespace_name "VertebratePopulation" |> NamespacedName

    /// <summary>
    /// EXAMPLE OF POPULATION
    /// <see href="http://purl.org/biotop/biotop.owl#VirusPopulation"></see></summary>
    let VirusPopulation =
        Namespaced_IRI.parse _namespace_name "VirusPopulation" |> NamespacedName

    /// <summary>
    /// EXAMPLE OF POPULATION
    /// <see href="http://purl.org/biotop/biotop.owl#YeastPopulation"></see></summary>
    let YeastPopulation =
        Namespaced_IRI.parse _namespace_name "YeastPopulation" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#abstractPartOf"></see>
    /// </summary>
    let abstractPartOf =
        Namespaced_IRI.parse _namespace_name "abstractPartOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#abstractlyRelatedTo"></see>
    /// </summary>
    let abstractlyRelatedTo =
        Namespaced_IRI.parse _namespace_name "abstractlyRelatedTo" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#hasAbstractPart"></see>
    /// </summary>
    let hasAbstractPart =
        Namespaced_IRI.parse _namespace_name "hasAbstractPart" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#agentIn"></see>
    /// </summary>
    let agentIn = Namespaced_IRI.parse _namespace_name "agentIn" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#causes"></see>
    /// </summary>
    let causes = Namespaced_IRI.parse _namespace_name "causes" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#attachedTo"></see>
    /// </summary>
    let attachedTo = Namespaced_IRI.parse _namespace_name "attachedTo" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#contiguousWith"></see>
    /// </summary>
    let contiguousWith =
        Namespaced_IRI.parse _namespace_name "contiguousWith" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#locusOf"></see>
    /// </summary>
    let locusOf = Namespaced_IRI.parse _namespace_name "locusOf" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#branchOf"></see>
    /// </summary>
    let branchOf = Namespaced_IRI.parse _namespace_name "branchOf" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#hasBranch"></see>
    /// </summary>
    let hasBranch = Namespaced_IRI.parse _namespace_name "hasBranch" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#causallyRelatedTo"></see>
    /// </summary>
    let causallyRelatedTo =
        Namespaced_IRI.parse _namespace_name "causallyRelatedTo" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#causedBy"></see>
    /// </summary>
    let causedBy = Namespaced_IRI.parse _namespace_name "causedBy" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#physicallyAdjacentTo"></see>
    /// </summary>
    let physicallyAdjacentTo =
        Namespaced_IRI.parse _namespace_name "physicallyAdjacentTo" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#continuousWith"></see>
    /// </summary>
    let continuousWith =
        Namespaced_IRI.parse _namespace_name "continuousWith" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#cooccurringWith"></see>
    /// </summary>
    let cooccurringWith =
        Namespaced_IRI.parse _namespace_name "cooccurringWith" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#temporallyRelatedTo"></see>
    /// </summary>
    let temporallyRelatedTo =
        Namespaced_IRI.parse _namespace_name "temporallyRelatedTo" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#denotedBy"></see>
    /// </summary>
    let denotedBy = Namespaced_IRI.parse _namespace_name "denotedBy" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#denotes"></see>
    /// </summary>
    let denotes = Namespaced_IRI.parse _namespace_name "denotes" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#derivedInto"></see>
    /// </summary>
    let derivedInto =
        Namespaced_IRI.parse _namespace_name "derivedInto" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#hasOrigin"></see>
    /// </summary>
    let hasOrigin = Namespaced_IRI.parse _namespace_name "hasOrigin" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#encodedBy"></see>
    /// </summary>
    let encodedBy = Namespaced_IRI.parse _namespace_name "encodedBy" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#encodes"></see>
    /// </summary>
    let encodes = Namespaced_IRI.parse _namespace_name "encodes" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#featureOf"></see>
    /// </summary>
    let featureOf = Namespaced_IRI.parse _namespace_name "featureOf" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#hasFeature"></see>
    /// </summary>
    let hasFeature = Namespaced_IRI.parse _namespace_name "hasFeature" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#granularPartOf"></see>
    /// </summary>
    let granularPartOf =
        Namespaced_IRI.parse _namespace_name "granularPartOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#spatiallyRelatedTo"></see>
    /// </summary>
    let spatiallyRelatedTo =
        Namespaced_IRI.parse _namespace_name "spatiallyRelatedTo" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#hasOriginalPart"></see>
    /// </summary>
    let hasOriginalPart =
        Namespaced_IRI.parse _namespace_name "hasOriginalPart" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#originalPartOf"></see>
    /// </summary>
    let originalPartOf =
        Namespaced_IRI.parse _namespace_name "originalPartOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#hasOriginatingPhysicalPart"></see>
    /// </summary>
    let hasOriginatingPhysicalPart =
        Namespaced_IRI.parse _namespace_name "hasOriginatingPhysicalPart" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#originatingPhysicalPartOf"></see>
    /// </summary>
    let originatingPhysicalPartOf =
        Namespaced_IRI.parse _namespace_name "originatingPhysicalPartOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#processuallyRelatedTo"></see>
    /// </summary>
    let processuallyRelatedTo =
        Namespaced_IRI.parse _namespace_name "processuallyRelatedTo" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#physicalLocationOf"></see>
    /// </summary>
    let physicalLocationOf =
        Namespaced_IRI.parse _namespace_name "physicalLocationOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#hasProcessRole"></see>
    /// </summary>
    let hasProcessRole =
        Namespaced_IRI.parse _namespace_name "hasProcessRole" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#hasProcessualPart"></see>
    /// </summary>
    let hasProcessualPart =
        Namespaced_IRI.parse _namespace_name "hasProcessualPart" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#processualPartOf"></see>
    /// </summary>
    let processualPartOf =
        Namespaced_IRI.parse _namespace_name "processualPartOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#realizationOf"></see>
    /// </summary>
    let realizationOf =
        Namespaced_IRI.parse _namespace_name "realizationOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#isAbout"></see>
    /// </summary>
    let isAbout = Namespaced_IRI.parse _namespace_name "isAbout" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#outcomeOf"></see>
    /// </summary>
    let outcomeOf = Namespaced_IRI.parse _namespace_name "outcomeOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#physicallyConnectedTo"></see>
    /// </summary>
    let physicallyConnectedTo =
        Namespaced_IRI.parse _namespace_name "physicallyConnectedTo" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#physicalPartOf"></see>
    /// </summary>
    let physicalPartOf =
        Namespaced_IRI.parse _namespace_name "physicalPartOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#physicallyLocatedIn"></see>
    /// </summary>
    let physicallyLocatedIn =
        Namespaced_IRI.parse _namespace_name "physicallyLocatedIn" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#physicallyBoundedBy"></see>
    /// </summary>
    let physicallyBoundedBy =
        Namespaced_IRI.parse _namespace_name "physicallyBoundedBy" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#physicallyContains"></see>
    /// </summary>
    let physicallyContains =
        Namespaced_IRI.parse _namespace_name "physicallyContains" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#physicallyDisconnectedFrom"></see>
    /// </summary>
    let physicallyDisconnectedFrom =
        Namespaced_IRI.parse _namespace_name "physicallyDisconnectedFrom" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#physicallyInterconnects"></see>
    /// </summary>
    let physicallyInterconnects =
        Namespaced_IRI.parse _namespace_name "physicallyInterconnects" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#physicallySurroundedBy"></see>
    /// </summary>
    let physicallySurroundedBy =
        Namespaced_IRI.parse _namespace_name "physicallySurroundedBy" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#physicallySurrounds"></see>
    /// </summary>
    let physicallySurrounds =
        Namespaced_IRI.parse _namespace_name "physicallySurrounds" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#physicallyTraverses"></see>
    /// </summary>
    let physicallyTraverses =
        Namespaced_IRI.parse _namespace_name "physicallyTraverses" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#precededBy"></see>
    /// </summary>
    let precededBy = Namespaced_IRI.parse _namespace_name "precededBy" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#precedes"></see>
    /// </summary>
    let precedes = Namespaced_IRI.parse _namespace_name "precedes" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#processRoleOf"></see>
    /// </summary>
    let processRoleOf =
        Namespaced_IRI.parse _namespace_name "processRoleOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#ramificationOf"></see>
    /// </summary>
    let ramificationOf =
        Namespaced_IRI.parse _namespace_name "ramificationOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#ramifies"></see>
    /// </summary>
    let ramifies = Namespaced_IRI.parse _namespace_name "ramifies" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#touches"></see>
    /// </summary>
    let touches = Namespaced_IRI.parse _namespace_name "touches" |> NamespacedName
