namespace http.purl.org.biotop.biotop.owl.hash

open DoxAletheia

module biotop =
    let _namespace_name = "http://purl.org/biotop/biotop.owl#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#ImmaterialThreeDimensionalPhysicalEntity"></see>
    /// </summary>
    let ImmaterialThreeDimensionalPhysicalEntity =
        _prefix "ImmaterialThreeDimensionalPhysicalEntity"

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#OneDimensionalPhysicalEntity"></see>
    /// </summary>
    let OneDimensionalPhysicalEntity = _prefix "OneDimensionalPhysicalEntity"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#TwoDimensionalPhysicalEntity"></see>
    /// </summary>
    let TwoDimensionalPhysicalEntity = _prefix "TwoDimensionalPhysicalEntity"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#ImmunologicRole"></see>
    /// </summary>
    let ImmunologicRole = _prefix "ImmunologicRole"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#SignallingRole"></see>
    /// </summary>
    let SignallingRole = _prefix "SignallingRole"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#VitaminRole"></see>
    /// </summary>
    let VitaminRole = _prefix "VitaminRole"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#Alga"></see>
    /// </summary>
    let Alga = _prefix "Alga"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#AnimalIncludingHuman"></see>
    /// </summary>
    let AnimalIncludingHuman = _prefix "AnimalIncludingHuman"
    /// <summary>
    /// On fungus organisms
    /// <see href="http://purl.org/biotop/biotop.owl#Fungus"></see></summary>
    let Fungus = _prefix "Fungus"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#Plant"></see>
    /// </summary>
    let Plant = _prefix "Plant"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#Protist"></see>
    /// </summary>
    let Protist = _prefix "Protist"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#GroupInteraction"></see>
    /// </summary>
    let GroupInteraction = _prefix "GroupInteraction"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#OrganismInteraction"></see>
    /// </summary>
    let OrganismInteraction = _prefix "OrganismInteraction"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#SubstanceInteraction"></see>
    /// </summary>
    let SubstanceInteraction = _prefix "SubstanceInteraction"
    /// <summary>
    /// EXAMPLE OF TAXON REGION
    /// <see href="http://purl.org/biotop/biotop.owl#KingdomAnimaliaValueRegion"></see></summary>
    let KingdomAnimaliaValueRegion = _prefix "KingdomAnimaliaValueRegion"
    /// <summary>
    /// EXAMPLE OF TAXON REGION
    /// <see href="http://purl.org/biotop/biotop.owl#KingdomArchaeaValueRegion"></see></summary>
    let KingdomArchaeaValueRegion = _prefix "KingdomArchaeaValueRegion"
    /// <summary>
    /// EXAMPLE OF TAXON REGION
    /// <see href="http://purl.org/biotop/biotop.owl#KingdomBacteriaValueRegion"></see></summary>
    let KingdomBacteriaValueRegion = _prefix "KingdomBacteriaValueRegion"
    /// <summary>
    /// EXAMPLE OF TAXON REGION
    /// <see href="http://purl.org/biotop/biotop.owl#KingdomChromistaValueRegion"></see></summary>
    let KingdomChromistaValueRegion = _prefix "KingdomChromistaValueRegion"
    /// <summary>
    /// EXAMPLE OF TAXON REGION
    /// <see href="http://purl.org/biotop/biotop.owl#KingdomFungiValueRegion"></see></summary>
    let KingdomFungiValueRegion = _prefix "KingdomFungiValueRegion"
    /// <summary>
    /// EXAMPLE OF TAXON REGION
    /// <see href="http://purl.org/biotop/biotop.owl#KingdomPlantaeValueRegion"></see></summary>
    let KingdomPlantaeValueRegion = _prefix "KingdomPlantaeValueRegion"
    /// <summary>
    /// EXAMPLE OF TAXON REGION
    /// <see href="http://purl.org/biotop/biotop.owl#KingdomProtozoaValueRegion"></see></summary>
    let KingdomProtozoaValueRegion = _prefix "KingdomProtozoaValueRegion"
    /// <summary>
    /// EXAMPLE OF TAXON REGION
    /// <see href="http://purl.org/biotop/biotop.owl#KingdomVirusesValueRegion"></see></summary>
    let KingdomVirusesValueRegion = _prefix "KingdomVirusesValueRegion"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#BodySystem"></see>
    /// </summary>
    let BodySystem = _prefix "BodySystem"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#Organ"></see>
    /// </summary>
    let Organ = _prefix "Organ"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#OrganPart"></see>
    /// </summary>
    let OrganPart = _prefix "OrganPart"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#CellMembrane"></see>
    /// </summary>
    let CellMembrane = _prefix "CellMembrane"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#CellNucleus"></see>
    /// </summary>
    let CellNucleus = _prefix "CellNucleus"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#Cytoplasm"></see>
    /// </summary>
    let Cytoplasm = _prefix "Cytoplasm"
    /// <summary>
    /// sum of genetic material in a cell
    /// <see href="http://purl.org/biotop/biotop.owl#Genome"></see></summary>
    let Genome = _prefix "Genome"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#EducatorRole"></see>
    /// </summary>
    let EducatorRole = _prefix "EducatorRole"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#HealthProfessionalRole"></see>
    /// </summary>
    let HealthProfessionalRole = _prefix "HealthProfessionalRole"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#ResearcherRole"></see>
    /// </summary>
    let ResearcherRole = _prefix "ResearcherRole"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#FindingRole"></see>
    /// </summary>
    let FindingRole = _prefix "FindingRole"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#FoodRole"></see>
    /// </summary>
    let FoodRole = _prefix "FoodRole"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#PoisonRole"></see>
    /// </summary>
    let PoisonRole = _prefix "PoisonRole"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#PreventiveRole"></see>
    /// </summary>
    let PreventiveRole = _prefix "PreventiveRole"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#SubjectOfCareRole"></see>
    /// </summary>
    let SubjectOfCareRole = _prefix "SubjectOfCareRole"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#TherapeuticRole"></see>
    /// </summary>
    let TherapeuticRole = _prefix "TherapeuticRole"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#Electron"></see>
    /// </summary>
    let Electron = _prefix "Electron"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#Neutron"></see>
    /// </summary>
    let Neutron = _prefix "Neutron"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#Proton"></see>
    /// </summary>
    let Proton = _prefix "Proton"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#Disposition"></see>
    /// </summary>
    let Disposition = _prefix "Disposition"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#ImmaterialObject"></see>
    /// </summary>
    let ImmaterialObject = _prefix "ImmaterialObject"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#InformationObject"></see>
    /// </summary>
    let InformationObject = _prefix "InformationObject"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#MaterialObject"></see>
    /// </summary>
    let MaterialObject = _prefix "MaterialObject"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#Process"></see>
    /// </summary>
    let Process = _prefix "Process"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#Quality"></see>
    /// </summary>
    let Quality = _prefix "Quality"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#Role"></see>
    /// </summary>
    let Role = _prefix "Role"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#Time"></see>
    /// </summary>
    let Time = _prefix "Time"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#ValueRegion"></see>
    /// </summary>
    let ValueRegion = _prefix "ValueRegion"

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#AminoAcidOrPeptideMoleculeOrStructure"></see>
    /// </summary>
    let AminoAcidOrPeptideMoleculeOrStructure =
        _prefix "AminoAcidOrPeptideMoleculeOrStructure"

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#CarbohydrateMoleculeOrResidue"></see>
    /// </summary>
    let CarbohydrateMoleculeOrResidue = _prefix "CarbohydrateMoleculeOrResidue"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#FattyAcidMoleculeOrResidue"></see>
    /// </summary>
    let FattyAcidMoleculeOrResidue = _prefix "FattyAcidMoleculeOrResidue"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#HeterocyclicBaseMoleculeOrResidue"></see>
    /// </summary>
    let HeterocyclicBaseMoleculeOrResidue = _prefix "HeterocyclicBaseMoleculeOrResidue"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#LipidMoleculeOrResidue"></see>
    /// </summary>
    let LipidMoleculeOrResidue = _prefix "LipidMoleculeOrResidue"

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#NucleicAcidNucleotideOrNucleosideMoleculeOrResidue"></see>
    /// </summary>
    let NucleicAcidNucleotideOrNucleosideMoleculeOrResidue =
        _prefix "NucleicAcidNucleotideOrNucleosideMoleculeOrResidue"

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#BiologicalSizeValueRegion"></see>
    /// </summary>
    let BiologicalSizeValueRegion = _prefix "BiologicalSizeValueRegion"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#CanonicityValueRegion"></see>
    /// </summary>
    let CanonicityValueRegion = _prefix "CanonicityValueRegion"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#DevelopmentalValueRegion"></see>
    /// </summary>
    let DevelopmentalValueRegion = _prefix "DevelopmentalValueRegion"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#StateOfMatterValueRegion"></see>
    /// </summary>
    let StateOfMatterValueRegion = _prefix "StateOfMatterValueRegion"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#TaxonValueRegion"></see>
    /// </summary>
    let TaxonValueRegion = _prefix "TaxonValueRegion"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#ChildRole"></see>
    /// </summary>
    let ChildRole = _prefix "ChildRole"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#ParentRole"></see>
    /// </summary>
    let ParentRole = _prefix "ParentRole"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#SiblingRole"></see>
    /// </summary>
    let SiblingRole = _prefix "SiblingRole"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#ArtefactRole"></see>
    /// </summary>
    let ArtefactRole = _prefix "ArtefactRole"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#BiologicalSystemRole"></see>
    /// </summary>
    let BiologicalSystemRole = _prefix "BiologicalSystemRole"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#ChemicalRole"></see>
    /// </summary>
    let ChemicalRole = _prefix "ChemicalRole"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#FamilyRole"></see>
    /// </summary>
    let FamilyRole = _prefix "FamilyRole"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#HealthRelatedRole"></see>
    /// </summary>
    let HealthRelatedRole = _prefix "HealthRelatedRole"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#OccupationalRole"></see>
    /// </summary>
    let OccupationalRole = _prefix "OccupationalRole"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#SpatialReferenceRole"></see>
    /// </summary>
    let SpatialReferenceRole = _prefix "SpatialReferenceRole"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#NucleicAcidStructure"></see>
    /// </summary>
    let NucleicAcidStructure = _prefix "NucleicAcidStructure"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#NucleosideMolecule"></see>
    /// </summary>
    let NucleosideMolecule = _prefix "NucleosideMolecule"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#NucleotideMolecule"></see>
    /// </summary>
    let NucleotideMolecule = _prefix "NucleotideMolecule"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#Eukaryote"></see>
    /// </summary>
    let Eukaryote = _prefix "Eukaryote"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#Prokaryote"></see>
    /// </summary>
    let Prokaryote = _prefix "Prokaryote"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#Virus"></see>
    /// </summary>
    let Virus = _prefix "Virus"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#Atom"></see>
    /// </summary>
    let Atom = _prefix "Atom"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#MonoMolecularEntity"></see>
    /// </summary>
    let MonoMolecularEntity = _prefix "MonoMolecularEntity"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#PolyMolecularCompositeEntity"></see>
    /// </summary>
    let PolyMolecularCompositeEntity = _prefix "PolyMolecularCompositeEntity"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#SubatomicParticle"></see>
    /// </summary>
    let SubatomicParticle = _prefix "SubatomicParticle"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#MoleculeComplex"></see>
    /// </summary>
    let MoleculeComplex = _prefix "MoleculeComplex"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#StructuredBiologicalEntity"></see>
    /// </summary>
    let StructuredBiologicalEntity = _prefix "StructuredBiologicalEntity"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#StructuredNonbiologicalCompound"></see>
    /// </summary>
    let StructuredNonbiologicalCompound = _prefix "StructuredNonbiologicalCompound"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#AgeQuality"></see>
    /// </summary>
    let AgeQuality = _prefix "AgeQuality"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#BiologicalSize"></see>
    /// </summary>
    let BiologicalSize = _prefix "BiologicalSize"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#Canonicity"></see>
    /// </summary>
    let Canonicity = _prefix "Canonicity"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#DevelopmentalQuality"></see>
    /// </summary>
    let DevelopmentalQuality = _prefix "DevelopmentalQuality"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#PhysicalForce"></see>
    /// </summary>
    let PhysicalForce = _prefix "PhysicalForce"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#PhysicalLength"></see>
    /// </summary>
    let PhysicalLength = _prefix "PhysicalLength"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#PhysicalMass"></see>
    /// </summary>
    let PhysicalMass = _prefix "PhysicalMass"
    /// <summary>
    /// former name: StateOfAggregation
    /// <see href="http://purl.org/biotop/biotop.owl#PhysicalState"></see></summary>
    let PhysicalState = _prefix "PhysicalState"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#PhysicalVolume"></see>
    /// </summary>
    let PhysicalVolume = _prefix "PhysicalVolume"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#StateOfMatter"></see>
    /// </summary>
    let StateOfMatter = _prefix "StateOfMatter"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#TaxonQuality"></see>
    /// </summary>
    let TaxonQuality = _prefix "TaxonQuality"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#Amphibian"></see>
    /// </summary>
    let Amphibian = _prefix "Amphibian"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#Bird"></see>
    /// </summary>
    let Bird = _prefix "Bird"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#Fish"></see>
    /// </summary>
    let Fish = _prefix "Fish"
    /// <summary>
    /// one mammal
    /// <see href="http://purl.org/biotop/biotop.owl#Mammal"></see></summary>
    let Mammal = _prefix "Mammal"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#Reptile"></see>
    /// </summary>
    let Reptile = _prefix "Reptile"
    /// <summary>
    /// "adult" as the value of a developmental stage. E.g. a 4 year old dog has a quality which has its value located in "adult value region".
    /// <see href="http://purl.org/biotop/biotop.owl#AdultValueRegion"></see></summary>
    let AdultValueRegion = _prefix "AdultValueRegion"
    /// <summary>
    /// "embryonic" as the value of a developmental stage. E.g. a 3 days old mouse embryo has a quality which has its value located in "embryonic value region".
    /// <see href="http://purl.org/biotop/biotop.owl#EmbryonicValueRegion"></see></summary>
    let EmbryonicValueRegion = _prefix "EmbryonicValueRegion"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#JuvenileValueRegion"></see>
    /// </summary>
    let JuvenileValueRegion = _prefix "JuvenileValueRegion"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#HormoneRole"></see>
    /// </summary>
    let HormoneRole = _prefix "HormoneRole"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#NeuroreactiveRole"></see>
    /// </summary>
    let NeuroreactiveRole = _prefix "NeuroreactiveRole"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#ReceptorRole"></see>
    /// </summary>
    let ReceptorRole = _prefix "ReceptorRole"
    /// <summary>
    /// "gaseous" as the value of a states of matter.  E.g. a portion of air has a quality which has its value located in "gaseous value region"
    /// <see href="http://purl.org/biotop/biotop.owl#GaseousValueRegion"></see></summary>
    let GaseousValueRegion = _prefix "GaseousValueRegion"
    /// <summary>
    /// "liquid" as the value of a states of matter. E.g. a portion of water has a quality which has its value located in "liquid value region"
    /// <see href="http://purl.org/biotop/biotop.owl#LiquidValueRegion"></see></summary>
    let LiquidValueRegion = _prefix "LiquidValueRegion"
    /// <summary>
    /// "solid" as the value of a states of matter. E.g. a stone has a quality which has its value located in "solid value region"
    /// <see href="http://purl.org/biotop/biotop.owl#SolidValueRegion"></see></summary>
    let SolidValueRegion = _prefix "SolidValueRegion"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#AnimalLanguage"></see>
    /// </summary>
    let AnimalLanguage = _prefix "AnimalLanguage"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#HumanLanguage"></see>
    /// </summary>
    let HumanLanguage = _prefix "HumanLanguage"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#MachineLanguage"></see>
    /// </summary>
    let MachineLanguage = _prefix "MachineLanguage"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#Eicosanoid"></see>
    /// </summary>
    let Eicosanoid = _prefix "Eicosanoid"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#NonSteroidLipid"></see>
    /// </summary>
    let NonSteroidLipid = _prefix "NonSteroidLipid"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#Steroid"></see>
    /// </summary>
    let Steroid = _prefix "Steroid"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#CatalyticRole"></see>
    /// </summary>
    let CatalyticRole = _prefix "CatalyticRole"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#IndicatorRole"></see>
    /// </summary>
    let IndicatorRole = _prefix "IndicatorRole"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#ReagentRole"></see>
    /// </summary>
    let ReagentRole = _prefix "ReagentRole"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#AcquiredAbnormalStructure"></see>
    /// </summary>
    let AcquiredAbnormalStructure = _prefix "AcquiredAbnormalStructure"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#PathologicalStructure"></see>
    /// </summary>
    let PathologicalStructure = _prefix "PathologicalStructure"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#CongenitalAbnormalStructure"></see>
    /// </summary>
    let CongenitalAbnormalStructure = _prefix "CongenitalAbnormalStructure"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#AcquiredPathologicalCondition"></see>
    /// </summary>
    let AcquiredPathologicalCondition = _prefix "AcquiredPathologicalCondition"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#PathologicalValueRegion"></see>
    /// </summary>
    let PathologicalValueRegion = _prefix "PathologicalValueRegion"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#CongenitalPathologicalCondition"></see>
    /// </summary>
    let CongenitalPathologicalCondition = _prefix "CongenitalPathologicalCondition"

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#AcquiredPathologicalStaticProcessualEntity"></see>
    /// </summary>
    let AcquiredPathologicalStaticProcessualEntity =
        _prefix "AcquiredPathologicalStaticProcessualEntity"

    /// <summary>
    /// Condition of an organism that deviates from what is considered normal. Often referred to by the terms "disorder", "disease", "syndrome", "sign", or "symptom". None of these denote clearly delineated ontological categories.
    ///
    /// See disease role etc.
    /// <see href="http://purl.org/biotop/biotop.owl#PathologicalStaticProcessualEntity"></see></summary>
    let PathologicalStaticProcessualEntity =
        _prefix "PathologicalStaticProcessualEntity"

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#qualityLocated"></see>
    /// </summary>
    let qualityLocated = _prefix "qualityLocated"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#hasProcessQuality"></see>
    /// </summary>
    let hasProcessQuality = _prefix "hasProcessQuality"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#Action"></see>
    /// </summary>
    let Action = _prefix "Action"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#TimeInterval"></see>
    /// </summary>
    let TimeInterval = _prefix "TimeInterval"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#hasDuration"></see>
    /// </summary>
    let hasDuration = _prefix "hasDuration"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#Particular"></see>
    /// </summary>
    let Particular = _prefix "Particular"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#hasAgent"></see>
    /// </summary>
    let hasAgent = _prefix "hasAgent"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#ActionOnBiologicalSystem"></see>
    /// </summary>
    let ActionOnBiologicalSystem = _prefix "ActionOnBiologicalSystem"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#LivingOrganism"></see>
    /// </summary>
    let LivingOrganism = _prefix "LivingOrganism"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#properPhysicalPartOf"></see>
    /// </summary>
    let properPhysicalPartOf = _prefix "properPhysicalPartOf"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#hasPatient"></see>
    /// </summary>
    let hasPatient = _prefix "hasPatient"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#AdultOrganism"></see>
    /// </summary>
    let AdultOrganism = _prefix "AdultOrganism"

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#OrganismByDevelopmentalStagePartition"></see>
    /// </summary>
    let OrganismByDevelopmentalStagePartition =
        _prefix "OrganismByDevelopmentalStagePartition"

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#EmbryonicOrganism"></see>
    /// </summary>
    let EmbryonicOrganism = _prefix "EmbryonicOrganism"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#JuvenileOrganism"></see>
    /// </summary>
    let JuvenileOrganism = _prefix "JuvenileOrganism"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#bearerOf"></see>
    /// </summary>
    let bearerOf = _prefix "bearerOf"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#Affecting"></see>
    /// </summary>
    let Affecting = _prefix "Affecting"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#inheresIn"></see>
    /// </summary>
    let inheresIn = _prefix "inheresIn"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#ObjectQuality"></see>
    /// </summary>
    let ObjectQuality = _prefix "ObjectQuality"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#AlphaParticle"></see>
    /// </summary>
    let AlphaParticle = _prefix "AlphaParticle"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#hasProperPhysicalPart"></see>
    /// </summary>
    let hasProperPhysicalPart = _prefix "hasProperPhysicalPart"
    /// <summary>
    /// (QCR) ro:hasPart some CarbonHydrogenSubstructure and ((hasComponent myx 2 CarboxyGroup) and (hasComponent min 1 CarboxyGroup) and (hasComponent exactly 1 AminoGroup)) or ((hasComponent max 2 AminoGroup) and (hasComponent min 1 AminoGroup) and (hasComponent exactly 1 CarboxyGroup))
    /// In chemistry, an amino acid is any molecule that contains both amine and carboxyl functional groups. However, in biochemistry, this more general term is frequently used to refer to alpha amino acids (amino acids in which the amino and carboxylate functionalities are attached to the same carbon, called ?–carbon). Amino Acids have at least one amino and one carboxy group. Those having two carboxy groups have only one amino group and vice versa.
    /// <see href="http://purl.org/biotop/biotop.owl#AminoAcidMoleculeOrResidue"></see></summary>
    let AminoAcidMoleculeOrResidue = _prefix "AminoAcidMoleculeOrResidue"
    /// <summary>
    /// A submolecular group or moiety is a group of covalently bound atoms that occurs only as part of a molecule
    /// <see href="http://purl.org/biotop/biotop.owl#SubmolecularGroup"></see></summary>
    let SubmolecularGroup = _prefix "SubmolecularGroup"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#hasComponentPart"></see>
    /// </summary>
    let hasComponentPart = _prefix "hasComponentPart"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#Monomer"></see>
    /// </summary>
    let Monomer = _prefix "Monomer"
    /// <summary>
    /// Comment: We here use the term peptide in the most general sense, viz. a oligo or polymer made out of amino acids.
    /// <see href="http://purl.org/biotop/biotop.owl#PeptideStructure"></see></summary>
    let PeptideStructure = _prefix "PeptideStructure"
    /// <summary>
    /// Ontologically irrelevant partitioning node. Used for improving ontology housekeeping. Its purpose is to express that all subclasses are mutually disjoint.
    /// <see href="http://purl.org/biotop/biotop.owl#OrganicMolecularEntityPartition"></see></summary>
    let OrganicMolecularEntityPartition = _prefix "OrganicMolecularEntityPartition"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#AminoAcidSequence"></see>
    /// </summary>
    let AminoAcidSequence = _prefix "AminoAcidSequence"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#AminoAcidSequenceInformation"></see>
    /// </summary>
    let AminoAcidSequenceInformation = _prefix "AminoAcidSequenceInformation"
    /// <summary>
    /// Place for currently non maintained classes. It should be assured that they are not being referred to by application ontologies that import BioTop
    /// <see href="http://purl.org/biotop/biotop.owl#DEPRECATED"></see></summary>
    let DEPRECATED = _prefix "DEPRECATED"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#AmountOfBodySubstance"></see>
    /// </summary>
    let AmountOfBodySubstance = _prefix "AmountOfBodySubstance"

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#CompoundOfCollectiveMaterialEntities"></see>
    /// </summary>
    let CompoundOfCollectiveMaterialEntities =
        _prefix "CompoundOfCollectiveMaterialEntities"

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#AmountOfPureSubstance"></see>
    /// </summary>
    let AmountOfPureSubstance = _prefix "AmountOfPureSubstance"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#hasGranularPart"></see>
    /// </summary>
    let hasGranularPart = _prefix "hasGranularPart"
    /// <summary>
    /// The fuzzyness of this class is due to the "same sort" criterion.
    /// <see href="http://purl.org/biotop/biotop.owl#CollectiveMaterialEntity"></see></summary>
    let CollectiveMaterialEntity = _prefix "CollectiveMaterialEntity"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#PluralityOfOrganisms"></see>
    /// </summary>
    let PluralityOfOrganisms = _prefix "PluralityOfOrganisms"
    /// <summary>
    /// one vertebrate
    /// <see href="http://purl.org/biotop/biotop.owl#Vertebrate"></see></summary>
    let Vertebrate = _prefix "Vertebrate"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#Analyzing"></see>
    /// </summary>
    let Analyzing = _prefix "Analyzing"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#HumanAction"></see>
    /// </summary>
    let HumanAction = _prefix "HumanAction"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#AnimalCell"></see>
    /// </summary>
    let AnimalCell = _prefix "AnimalCell"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#CellByTaxonPartition"></see>
    /// </summary>
    let CellByTaxonPartition = _prefix "CellByTaxonPartition"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#BacterialCell"></see>
    /// </summary>
    let BacterialCell = _prefix "BacterialCell"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#PlantCell"></see>
    /// </summary>
    let PlantCell = _prefix "PlantCell"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#Cell"></see>
    /// </summary>
    let Cell = _prefix "Cell"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#AnimalExcludingHuman"></see>
    /// </summary>
    let AnimalExcludingHuman = _prefix "AnimalExcludingHuman"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#Human"></see>
    /// </summary>
    let Human = _prefix "Human"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#LanguagePartition"></see>
    /// </summary>
    let LanguagePartition = _prefix "LanguagePartition"
    /// <summary>
    /// EXAMPLE OF POPULATION
    /// <see href="http://purl.org/biotop/biotop.owl#AnimalPopulation"></see></summary>
    let AnimalPopulation = _prefix "AnimalPopulation"
    /// <summary>
    /// all child classes of population are only meant as examples demonstrating how population classes can be postcoordinated
    /// <see href="http://purl.org/biotop/biotop.owl#Population"></see></summary>
    let Population = _prefix "Population"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#AntibioticRole"></see>
    /// </summary>
    let AntibioticRole = _prefix "AntibioticRole"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#DrugRole"></see>
    /// </summary>
    let DrugRole = _prefix "DrugRole"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#ArchaebacterialCell"></see>
    /// </summary>
    let ArchaebacterialCell = _prefix "ArchaebacterialCell"
    /// <summary>
    /// one arthropod
    /// <see href="http://purl.org/biotop/biotop.owl#Arthropod"></see></summary>
    let Arthropod = _prefix "Arthropod"
    /// <summary>
    /// EXAMPLE OF TAXON REGION
    /// <see href="http://purl.org/biotop/biotop.owl#PhylumArthropodaValueRegion"></see></summary>
    let PhylumArthropodaValueRegion = _prefix "PhylumArthropodaValueRegion"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#Invertebrate"></see>
    /// </summary>
    let Invertebrate = _prefix "Invertebrate"
    /// <summary>
    /// EXAMPLE OF POPULATION
    /// <see href="http://purl.org/biotop/biotop.owl#ArthropodPopulation"></see></summary>
    let ArthropodPopulation = _prefix "ArthropodPopulation"
    /// <summary>
    /// MaterialEntityBySizePartition
    ///
    /// Ontologically irrelevant partitioning node. Used for improving ontology housekeeping. Its purpose is to express that all subclasses are mutually disjoint.
    /// <see href="http://purl.org/biotop/biotop.owl#MaterialEntityBySizePartition"></see></summary>
    let MaterialEntityBySizePartition = _prefix "MaterialEntityBySizePartition"
    /// <summary>
    /// EXAMPLE OF POPULATION
    /// <see href="http://purl.org/biotop/biotop.owl#BacteriaPopulation"></see></summary>
    let BacteriaPopulation = _prefix "BacteriaPopulation"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#BacterialColony"></see>
    /// </summary>
    let BacterialColony = _prefix "BacterialColony"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#BiologicalColony"></see>
    /// </summary>
    let BiologicalColony = _prefix "BiologicalColony"
    /// <summary>
    /// one saccharomyces cerevisiae cell
    /// <see href="http://purl.org/biotop/biotop.owl#BakersYeastCell"></see></summary>
    let BakersYeastCell = _prefix "BakersYeastCell"

    /// <summary>
    /// EXAMPLE OF TAXON REGION
    /// <see href="http://purl.org/biotop/biotop.owl#SpeciesSaccharomycesCerevisiaeValueRegion"></see></summary>
    let SpeciesSaccharomycesCerevisiaeValueRegion =
        _prefix "SpeciesSaccharomycesCerevisiaeValueRegion"

    /// <summary>
    /// Unicellular Fungi.
    /// <see href="http://purl.org/biotop/biotop.owl#YeastCell"></see></summary>
    let YeastCell = _prefix "YeastCell"
    /// <summary>
    /// One candida albicans cell
    /// <see href="http://purl.org/biotop/biotop.owl#CandidaAlbicansCell"></see></summary>
    let CandidaAlbicansCell = _prefix "CandidaAlbicansCell"
    /// <summary>
    /// EXAMPLE OF POPULATION
    /// <see href="http://purl.org/biotop/biotop.owl#BakersYeastPopulation"></see></summary>
    let BakersYeastPopulation = _prefix "BakersYeastPopulation"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#Behavior"></see>
    /// </summary>
    let Behavior = _prefix "Behavior"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#BioMolecularProcess"></see>
    /// </summary>
    let BioMolecularProcess = _prefix "BioMolecularProcess"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#BiologicalProcessualEntity"></see>
    /// </summary>
    let BiologicalProcessualEntity = _prefix "BiologicalProcessualEntity"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#hasParticipant"></see>
    /// </summary>
    let hasParticipant = _prefix "hasParticipant"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#BioMolecularSequenceInformation"></see>
    /// </summary>
    let BioMolecularSequenceInformation = _prefix "BioMolecularSequenceInformation"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#BioMolecularSequenceStructure"></see>
    /// </summary>
    let BioMolecularSequenceStructure = _prefix "BioMolecularSequenceStructure"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#OrganicMolecularEntity"></see>
    /// </summary>
    let OrganicMolecularEntity = _prefix "OrganicMolecularEntity"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#ChainOfCarbohydrateMonomers"></see>
    /// </summary>
    let ChainOfCarbohydrateMonomers = _prefix "ChainOfCarbohydrateMonomers"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#ChainOfNucleotideMonomers"></see>
    /// </summary>
    let ChainOfNucleotideMonomers = _prefix "ChainOfNucleotideMonomers"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#DNAChain"></see>
    /// </summary>
    let DNAChain = _prefix "DNAChain"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#RNAChain"></see>
    /// </summary>
    let RNAChain = _prefix "RNAChain"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#BiologicalAction"></see>
    /// </summary>
    let BiologicalAction = _prefix "BiologicalAction"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#BiologicalBoundary"></see>
    /// </summary>
    let BiologicalBoundary = _prefix "BiologicalBoundary"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#PhysicalBoundary"></see>
    /// </summary>
    let PhysicalBoundary = _prefix "PhysicalBoundary"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#BiologicalSpace"></see>
    /// </summary>
    let BiologicalSpace = _prefix "BiologicalSpace"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#physicallyBounds"></see>
    /// </summary>
    let physicallyBounds = _prefix "physicallyBounds"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#BiologicalFunction"></see>
    /// </summary>
    let BiologicalFunction = _prefix "BiologicalFunction"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#Function"></see>
    /// </summary>
    let Function = _prefix "Function"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#BiologicalLife"></see>
    /// </summary>
    let BiologicalLife = _prefix "BiologicalLife"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#OrganismProcess"></see>
    /// </summary>
    let OrganismProcess = _prefix "OrganismProcess"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#PhysicalProcessualEntity"></see>
    /// </summary>
    let PhysicalProcessualEntity = _prefix "PhysicalProcessualEntity"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#hasLocus"></see>
    /// </summary>
    let hasLocus = _prefix "hasLocus"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#physicallyContainedIn"></see>
    /// </summary>
    let physicallyContainedIn = _prefix "physicallyContainedIn"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#BiomedicalMaterialRole"></see>
    /// </summary>
    let BiomedicalMaterialRole = _prefix "BiomedicalMaterialRole"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#Biomolecule"></see>
    /// </summary>
    let Biomolecule = _prefix "Biomolecule"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#originatesFrom"></see>
    /// </summary>
    let originatesFrom = _prefix "originatesFrom"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#Body"></see>
    /// </summary>
    let Body = _prefix "Body"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#BodyLiquid"></see>
    /// </summary>
    let BodyLiquid = _prefix "BodyLiquid"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#WaterMolecule"></see>
    /// </summary>
    let WaterMolecule = _prefix "WaterMolecule"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#PortionOfHeterogenousLiquid"></see>
    /// </summary>
    let PortionOfHeterogenousLiquid = _prefix "PortionOfHeterogenousLiquid"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#OrganismPart"></see>
    /// </summary>
    let OrganismPart = _prefix "OrganismPart"
    /// <summary>
    /// EXAMPLE OF TAXON REGION
    /// <see href="http://purl.org/biotop/biotop.owl#SpeciesCandidaAlbicansValueRegion"></see></summary>
    let SpeciesCandidaAlbicansValueRegion = _prefix "SpeciesCandidaAlbicansValueRegion"
    /// <summary>
    /// EXAMPLE OF POPULATION
    /// <see href="http://purl.org/biotop/biotop.owl#CandidaAlbicansPopulation"></see></summary>
    let CandidaAlbicansPopulation = _prefix "CandidaAlbicansPopulation"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#CanonicalProcessualEntity"></see>
    /// </summary>
    let CanonicalProcessualEntity = _prefix "CanonicalProcessualEntity"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#NoncanonicalProcessualEntity"></see>
    /// </summary>
    let NoncanonicalProcessualEntity = _prefix "NoncanonicalProcessualEntity"
    /// <summary>
    /// abstract region in which the value "canonical" of canonicity is located
    /// <see href="http://purl.org/biotop/biotop.owl#CanonicalValueRegion"></see></summary>
    let CanonicalValueRegion = _prefix "CanonicalValueRegion"
    /// <summary>
    /// a biological state that is considered "normal"
    /// <see href="http://purl.org/biotop/biotop.owl#CanonicalStaticProcessualEntity"></see></summary>
    let CanonicalStaticProcessualEntity = _prefix "CanonicalStaticProcessualEntity"

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#NoncanonicalStaticProcessualEntity"></see>
    /// </summary>
    let NoncanonicalStaticProcessualEntity =
        _prefix "NoncanonicalStaticProcessualEntity"

    /// <summary>
    /// Static condition as a special case of process in which temporal parts are neglected.
    /// <see href="http://purl.org/biotop/biotop.owl#StaticProcessualEntity"></see></summary>
    let StaticProcessualEntity = _prefix "StaticProcessualEntity"
    /// <summary>
    /// abstract region in which the value "noncanonical" of canonicity is located
    /// <see href="http://purl.org/biotop/biotop.owl#NoncanonicalValueRegion"></see></summary>
    let NoncanonicalValueRegion = _prefix "NoncanonicalValueRegion"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#qualityLocationOf"></see>
    /// </summary>
    let qualityLocationOf = _prefix "qualityLocationOf"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#CarbohydrateMonomer"></see>
    /// </summary>
    let CarbohydrateMonomer = _prefix "CarbohydrateMonomer"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#CarbohydrateSequenceInformation"></see>
    /// </summary>
    let CarbohydrateSequenceInformation = _prefix "CarbohydrateSequenceInformation"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#CategorizationSystem"></see>
    /// </summary>
    let CategorizationSystem = _prefix "CategorizationSystem"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#IntellectualProduct"></see>
    /// </summary>
    let IntellectualProduct = _prefix "IntellectualProduct"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#RegulationOrLaw"></see>
    /// </summary>
    let RegulationOrLaw = _prefix "RegulationOrLaw"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#Causing"></see>
    /// </summary>
    let Causing = _prefix "Causing"

    /// <summary>
    /// StructuredBiologicalCompoundByGranularityPartition
    ///
    /// ontologically irrelevant disjoint partition: structured biological compound by granularity
    /// <see href="http://purl.org/biotop/biotop.owl#StructuredBiologicalCompoundByGranularityPartition"></see></summary>
    let StructuredBiologicalCompoundByGranularityPartition =
        _prefix "StructuredBiologicalCompoundByGranularityPartition"

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#CellularComponent"></see>
    /// </summary>
    let CellularComponent = _prefix "CellularComponent"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#Syncytium"></see>
    /// </summary>
    let Syncytium = _prefix "Syncytium"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#CellByLocusPartition"></see>
    /// </summary>
    let CellByLocusPartition = _prefix "CellByLocusPartition"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#CellInVivo"></see>
    /// </summary>
    let CellInVivo = _prefix "CellInVivo"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#ModifiedCell"></see>
    /// </summary>
    let ModifiedCell = _prefix "ModifiedCell"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#CellByTypePartition"></see>
    /// </summary>
    let CellByTypePartition = _prefix "CellByTypePartition"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#CentralNervousSystem"></see>
    /// </summary>
    let CentralNervousSystem = _prefix "CentralNervousSystem"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#OrganSystem"></see>
    /// </summary>
    let OrganSystem = _prefix "OrganSystem"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#ChlamydiaCell"></see>
    /// </summary>
    let ChlamydiaCell = _prefix "ChlamydiaCell"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#RickettsiaCell"></see>
    /// </summary>
    let RickettsiaCell = _prefix "RickettsiaCell"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#Chromosome"></see>
    /// </summary>
    let Chromosome = _prefix "Chromosome"
    /// <summary>
    /// not (properPartOf some MonoMolecularEntity)  REMOVED
    /// <see href="http://purl.org/biotop/biotop.owl#EntireNucleicAcidMolecule"></see></summary>
    let EntireNucleicAcidMolecule = _prefix "EntireNucleicAcidMolecule"

    /// <summary>
    /// EXAMPLE OF TAXON REGION
    /// <see href="http://purl.org/biotop/biotop.owl#ClassGammaProteobacteriaValueRegion"></see></summary>
    let ClassGammaProteobacteriaValueRegion =
        _prefix "ClassGammaProteobacteriaValueRegion"

    /// <summary>
    /// EXAMPLE OF TAXON REGION
    /// <see href="http://purl.org/biotop/biotop.owl#PhylumProteobacteriaValueRegion"></see></summary>
    let PhylumProteobacteriaValueRegion = _prefix "PhylumProteobacteriaValueRegion"
    /// <summary>
    /// EXAMPLE OF TAXON REGION
    /// <see href="http://purl.org/biotop/biotop.owl#ClassInsectaValueRegion"></see></summary>
    let ClassInsectaValueRegion = _prefix "ClassInsectaValueRegion"
    /// <summary>
    /// EXAMPLE OF TAXON REGION
    /// <see href="http://purl.org/biotop/biotop.owl#ClassMammaliaValueRegion"></see></summary>
    let ClassMammaliaValueRegion = _prefix "ClassMammaliaValueRegion"
    /// <summary>
    /// EXAMPLE OF TAXON REGION
    /// <see href="http://purl.org/biotop/biotop.owl#SubphylumVertebrataValueRegion"></see></summary>
    let SubphylumVertebrataValueRegion = _prefix "SubphylumVertebrataValueRegion"
    /// <summary>
    /// EXAMPLE OF TAXON REGION
    /// <see href="http://purl.org/biotop/biotop.owl#ClassSaccharomycetesValueRegion"></see></summary>
    let ClassSaccharomycetesValueRegion = _prefix "ClassSaccharomycetesValueRegion"

    /// <summary>
    /// EXAMPLE OF TAXON REGION
    /// <see href="http://purl.org/biotop/biotop.owl#SubphylumSaccharomycotinaValueRegion"></see></summary>
    let SubphylumSaccharomycotinaValueRegion =
        _prefix "SubphylumSaccharomycotinaValueRegion"

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#Complicating"></see>
    /// </summary>
    let Complicating = _prefix "Complicating"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#Condition"></see>
    /// </summary>
    let Condition = _prefix "Condition"

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#CongenitalPathologicalStaticProcessualEntity"></see>
    /// </summary>
    let CongenitalPathologicalStaticProcessualEntity =
        _prefix "CongenitalPathologicalStaticProcessualEntity"

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#DEPRECATED_RELATION"></see>
    /// </summary>
    let DEPRECATED_RELATION = _prefix "DEPRECATED_RELATION"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#DeadBody"></see>
    /// </summary>
    let DeadBody = _prefix "DeadBody"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#LivingBody"></see>
    /// </summary>
    let LivingBody = _prefix "LivingBody"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#Death"></see>
    /// </summary>
    let Death = _prefix "Death"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#PointInTime"></see>
    /// </summary>
    let PointInTime = _prefix "PointInTime"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#hasPointInTime"></see>
    /// </summary>
    let hasPointInTime = _prefix "hasPointInTime"
    /// <summary>
    /// (OBI 306)
    /// <see href="http://purl.org/biotop/biotop.owl#DigitalEntity"></see></summary>
    let DigitalEntity = _prefix "DigitalEntity"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#Disrupting"></see>
    /// </summary>
    let Disrupting = _prefix "Disrupting"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#SubatomicEntityByChargePartition"></see>
    /// </summary>
    let SubatomicEntityByChargePartition = _prefix "SubatomicEntityByChargePartition"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#EmbryonicStructure"></see>
    /// </summary>
    let EmbryonicStructure = _prefix "EmbryonicStructure"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#EntireCarbohydrateMonomer"></see>
    /// </summary>
    let EntireCarbohydrateMonomer = _prefix "EntireCarbohydrateMonomer"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#EntireMolecularEntity"></see>
    /// </summary>
    let EntireMolecularEntity = _prefix "EntireMolecularEntity"

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#MolecularEntityByEntiretyPartition"></see>
    /// </summary>
    let MolecularEntityByEntiretyPartition =
        _prefix "MolecularEntityByEntiretyPartition"

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#MolecularResidue"></see>
    /// </summary>
    let MolecularResidue = _prefix "MolecularResidue"
    /// <summary>
    /// (QCR) Peptide and hasComponent min 101 AminoAcidMonomer and not (ro:properPartOf some MolecularEntity)
    /// <see href="http://purl.org/biotop/biotop.owl#EntireProteinMolecule"></see></summary>
    let EntireProteinMolecule = _prefix "EntireProteinMolecule"
    /// <summary>
    /// The role a peptide plays in accelerating a biochemical reaction
    /// <see href="http://purl.org/biotop/biotop.owl#EnzymeRole"></see></summary>
    let EnzymeRole = _prefix "EnzymeRole"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#EpithelialCell"></see>
    /// </summary>
    let EpithelialCell = _prefix "EpithelialCell"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#EscherichiaColiCell"></see>
    /// </summary>
    let EscherichiaColiCell = _prefix "EscherichiaColiCell"
    /// <summary>
    /// EXAMPLE OF TAXON REGION
    /// <see href="http://purl.org/biotop/biotop.owl#SpeciesEscherichiaColiValueRegion"></see></summary>
    let SpeciesEscherichiaColiValueRegion = _prefix "SpeciesEscherichiaColiValueRegion"
    /// <summary>
    /// EXAMPLE OF POPULATION
    /// <see href="http://purl.org/biotop/biotop.owl#EscherichiaColiPopulation"></see></summary>
    let EscherichiaColiPopulation = _prefix "EscherichiaColiPopulation"
    /// <summary>
    /// Ontologically irrelevant partitioning node. Used for improving ontology housekeeping. Its purpose is to express that all subclasses are mutually disjoint.
    /// <see href="http://purl.org/biotop/biotop.owl#OrganismByTaxonPartition"></see></summary>
    let OrganismByTaxonPartition = _prefix "OrganismByTaxonPartition"
    /// <summary>
    /// EXAMPLE OF POPULATION
    /// <see href="http://purl.org/biotop/biotop.owl#EukaryotePopulation"></see></summary>
    let EukaryotePopulation = _prefix "EukaryotePopulation"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#Event"></see>
    /// </summary>
    let Event = _prefix "Event"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#ExaminationResultRole"></see>
    /// </summary>
    let ExaminationResultRole = _prefix "ExaminationResultRole"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#SignOrSymptomRole"></see>
    /// </summary>
    let SignOrSymptomRole = _prefix "SignOrSymptomRole"
    /// <summary>
    /// EXAMPLE OF TAXON REGION
    /// <see href="http://purl.org/biotop/biotop.owl#FamilyDrosophilidaeValueRegion"></see></summary>
    let FamilyDrosophilidaeValueRegion = _prefix "FamilyDrosophilidaeValueRegion"
    /// <summary>
    /// EXAMPLE OF TAXON REGION
    /// <see href="http://purl.org/biotop/biotop.owl#OrderDipteraValueRegion"></see></summary>
    let OrderDipteraValueRegion = _prefix "OrderDipteraValueRegion"

    /// <summary>
    /// EXAMPLE OF TAXON REGION
    /// <see href="http://purl.org/biotop/biotop.owl#FamilyEnterobacteriaceaeaValueRegion"></see></summary>
    let FamilyEnterobacteriaceaeaValueRegion =
        _prefix "FamilyEnterobacteriaceaeaValueRegion"

    /// <summary>
    /// EXAMPLE OF TAXON REGION
    /// <see href="http://purl.org/biotop/biotop.owl#OrderEnterobacterialesValueRegion"></see></summary>
    let OrderEnterobacterialesValueRegion = _prefix "OrderEnterobacterialesValueRegion"
    /// <summary>
    /// EXAMPLE OF TAXON REGION
    /// <see href="http://purl.org/biotop/biotop.owl#FamilyHominidaeValueRegion"></see></summary>
    let FamilyHominidaeValueRegion = _prefix "FamilyHominidaeValueRegion"
    /// <summary>
    /// EXAMPLE OF TAXON REGION
    /// <see href="http://purl.org/biotop/biotop.owl#OrderPrimatesValueRegion"></see></summary>
    let OrderPrimatesValueRegion = _prefix "OrderPrimatesValueRegion"
    /// <summary>
    /// unclear classe. to be revised
    /// <see href="http://purl.org/biotop/biotop.owl#FamilyOfIndividualOrganisms"></see></summary>
    let FamilyOfIndividualOrganisms = _prefix "FamilyOfIndividualOrganisms"

    /// <summary>
    /// EXAMPLE OF TAXON REGION
    /// <see href="http://purl.org/biotop/biotop.owl#FamilySaccharomycetaceaeValueRegion"></see></summary>
    let FamilySaccharomycetaceaeValueRegion =
        _prefix "FamilySaccharomycetaceaeValueRegion"

    /// <summary>
    /// EXAMPLE OF TAXON REGION
    /// <see href="http://purl.org/biotop/biotop.owl#OrderSaccharomycetalesValueRegion"></see></summary>
    let OrderSaccharomycetalesValueRegion = _prefix "OrderSaccharomycetalesValueRegion"
    /// <summary>
    /// one drosophila melanogaster
    /// <see href="http://purl.org/biotop/biotop.owl#FruitFly"></see></summary>
    let FruitFly = _prefix "FruitFly"

    /// <summary>
    /// EXAMPLE OF TAXON REGION
    /// <see href="http://purl.org/biotop/biotop.owl#SpeciesDrosophilaMelanogasterValueRegion"></see></summary>
    let SpeciesDrosophilaMelanogasterValueRegion =
        _prefix "SpeciesDrosophilaMelanogasterValueRegion"

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#Insect"></see>
    /// </summary>
    let Insect = _prefix "Insect"
    /// <summary>
    /// EXAMPLE OF POPULATION
    /// <see href="http://purl.org/biotop/biotop.owl#FruitFlyPopulation"></see></summary>
    let FruitFlyPopulation = _prefix "FruitFlyPopulation"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#hasRealization"></see>
    /// </summary>
    let hasRealization = _prefix "hasRealization"
    /// <summary>
    /// EXAMPLE OF POPULATION
    /// <see href="http://purl.org/biotop/biotop.owl#FungusPopulation"></see></summary>
    let FungusPopulation = _prefix "FungusPopulation"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#Gene"></see>
    /// </summary>
    let Gene = _prefix "Gene"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#GeneticInformation"></see>
    /// </summary>
    let GeneticInformation = _prefix "GeneticInformation"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#GeneInformation"></see>
    /// </summary>
    let GeneInformation = _prefix "GeneInformation"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#GeneRegion"></see>
    /// </summary>
    let GeneRegion = _prefix "GeneRegion"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#GenomeInformation"></see>
    /// </summary>
    let GenomeInformation = _prefix "GenomeInformation"
    /// <summary>
    /// EXAMPLE OF TAXON REGION
    /// <see href="http://purl.org/biotop/biotop.owl#GenusCandidaValueRegion"></see></summary>
    let GenusCandidaValueRegion = _prefix "GenusCandidaValueRegion"
    /// <summary>
    /// EXAMPLE OF TAXON REGION
    /// <see href="http://purl.org/biotop/biotop.owl#GenusSaccharomycesValueRegion"></see></summary>
    let GenusSaccharomycesValueRegion = _prefix "GenusSaccharomycesValueRegion"
    /// <summary>
    /// EXAMPLE OF TAXON REGION
    /// <see href="http://purl.org/biotop/biotop.owl#GenusDrosophilaValueRegion"></see></summary>
    let GenusDrosophilaValueRegion = _prefix "GenusDrosophilaValueRegion"
    /// <summary>
    /// EXAMPLE OF TAXON REGION
    /// <see href="http://purl.org/biotop/biotop.owl#SubfamilyDrosophilinaeValueRegion"></see></summary>
    let SubfamilyDrosophilinaeValueRegion = _prefix "SubfamilyDrosophilinaeValueRegion"
    /// <summary>
    /// EXAMPLE OF TAXON REGION
    /// <see href="http://purl.org/biotop/biotop.owl#GenusEscherichiaValueRegion"></see></summary>
    let GenusEscherichiaValueRegion = _prefix "GenusEscherichiaValueRegion"
    /// <summary>
    /// EXAMPLE OF TAXON REGION
    /// <see href="http://purl.org/biotop/biotop.owl#GenusHomoValueRegion"></see></summary>
    let GenusHomoValueRegion = _prefix "GenusHomoValueRegion"
    /// <summary>
    /// previous name "geographic entity"
    /// <see href="http://purl.org/biotop/biotop.owl#GeographicSurface"></see></summary>
    let GeographicSurface = _prefix "GeographicSurface"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#Government"></see>
    /// </summary>
    let Government = _prefix "Government"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#Organization"></see>
    /// </summary>
    let Organization = _prefix "Organization"
    /// <summary>
    /// one great ape
    /// <see href="http://purl.org/biotop/biotop.owl#GreatApe"></see></summary>
    let GreatApe = _prefix "GreatApe"
    /// <summary>
    /// EXAMPLE OF POPULATION
    /// <see href="http://purl.org/biotop/biotop.owl#GreatApePopulation"></see></summary>
    let GreatApePopulation = _prefix "GreatApePopulation"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#LegalEntity"></see>
    /// </summary>
    let LegalEntity = _prefix "LegalEntity"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#Interacting"></see>
    /// </summary>
    let Interacting = _prefix "Interacting"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#GrowingProcess"></see>
    /// </summary>
    let GrowingProcess = _prefix "GrowingProcess"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#TissueProcess"></see>
    /// </summary>
    let TissueProcess = _prefix "TissueProcess"
    /// <summary>
    /// EXAMPLE OF TAXON REGION
    /// <see href="http://purl.org/biotop/biotop.owl#SpeciesHomoSapiensValueRegion"></see></summary>
    let SpeciesHomoSapiensValueRegion = _prefix "SpeciesHomoSapiensValueRegion"
    /// <summary>
    /// one primate
    /// <see href="http://purl.org/biotop/biotop.owl#Primate"></see></summary>
    let Primate = _prefix "Primate"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#OrganismAction"></see>
    /// </summary>
    let OrganismAction = _prefix "OrganismAction"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#HumanEpithelialCell"></see>
    /// </summary>
    let HumanEpithelialCell = _prefix "HumanEpithelialCell"
    /// <summary>
    /// EXAMPLE OF POPULATION
    /// <see href="http://purl.org/biotop/biotop.owl#HumanPopulation"></see></summary>
    let HumanPopulation = _prefix "HumanPopulation"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#HumanReasoning"></see>
    /// </summary>
    let HumanReasoning = _prefix "HumanReasoning"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#hasOutcome"></see>
    /// </summary>
    let hasOutcome = _prefix "hasOutcome"
    /// <summary>
    /// negatively affecting a biological system by using physical force
    /// <see href="http://purl.org/biotop/biotop.owl#Hurting"></see></summary>
    let Hurting = _prefix "Hurting"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#ImmaterialNonphysicalEntity"></see>
    /// </summary>
    let ImmaterialNonphysicalEntity = _prefix "ImmaterialNonphysicalEntity"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#hasPhysicalPart"></see>
    /// </summary>
    let hasPhysicalPart = _prefix "hasPhysicalPart"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#ImmaterialPhysicalEntity"></see>
    /// </summary>
    let ImmaterialPhysicalEntity = _prefix "ImmaterialPhysicalEntity"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#ImmaterialProcessualEntity"></see>
    /// </summary>
    let ImmaterialProcessualEntity = _prefix "ImmaterialProcessualEntity"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#Indicating"></see>
    /// </summary>
    let Indicating = _prefix "Indicating"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#IndividualBehavior"></see>
    /// </summary>
    let IndividualBehavior = _prefix "IndividualBehavior"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#SocialBehavior"></see>
    /// </summary>
    let SocialBehavior = _prefix "SocialBehavior"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#InformationEntity"></see>
    /// </summary>
    let InformationEntity = _prefix "InformationEntity"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#InorganicMolecularEntity"></see>
    /// </summary>
    let InorganicMolecularEntity = _prefix "InorganicMolecularEntity"

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#MolecularEntityByOrganicInorganicPartition"></see>
    /// </summary>
    let MolecularEntityByOrganicInorganicPartition =
        _prefix "MolecularEntityByOrganicInorganicPartition"

    /// <summary>
    /// EXAMPLE OF POPULATION
    /// <see href="http://purl.org/biotop/biotop.owl#InsectPopulation"></see></summary>
    let InsectPopulation = _prefix "InsectPopulation"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#InstantaneousProcess"></see>
    /// </summary>
    let InstantaneousProcess = _prefix "InstantaneousProcess"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#patientIn"></see>
    /// </summary>
    let patientIn = _prefix "patientIn"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#IntraCellularProcess"></see>
    /// </summary>
    let IntraCellularProcess = _prefix "IntraCellularProcess"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#Language"></see>
    /// </summary>
    let Language = _prefix "Language"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#participatesIn"></see>
    /// </summary>
    let participatesIn = _prefix "participatesIn"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#MachineAction"></see>
    /// </summary>
    let MachineAction = _prefix "MachineAction"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#MacroscopicValueRegion"></see>
    /// </summary>
    let MacroscopicValueRegion = _prefix "MacroscopicValueRegion"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#MicroscopicValueRegion"></see>
    /// </summary>
    let MicroscopicValueRegion = _prefix "MicroscopicValueRegion"
    /// <summary>
    /// EXAMPLE OF POPULATION
    /// <see href="http://purl.org/biotop/biotop.owl#MammalPopulation"></see></summary>
    let MammalPopulation = _prefix "MammalPopulation"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#ManagingCare"></see>
    /// </summary>
    let ManagingCare = _prefix "ManagingCare"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#MaterialEntity"></see>
    /// </summary>
    let MaterialEntity = _prefix "MaterialEntity"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#Measure"></see>
    /// </summary>
    let Measure = _prefix "Measure"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#MeasurementMethod"></see>
    /// </summary>
    let MeasurementMethod = _prefix "MeasurementMethod"
    /// <summary>
    /// (OBI 344)
    /// <see href="http://purl.org/biotop/biotop.owl#Plan"></see></summary>
    let Plan = _prefix "Plan"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#MeasuringAction"></see>
    /// </summary>
    let MeasuringAction = _prefix "MeasuringAction"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#Membership"></see>
    /// </summary>
    let Membership = _prefix "Membership"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#MentalFunction"></see>
    /// </summary>
    let MentalFunction = _prefix "MentalFunction"
    /// <summary>
    /// process in an organism as a realization of a mental function
    /// <see href="http://purl.org/biotop/biotop.owl#MentalProcess"></see></summary>
    let MentalProcess = _prefix "MentalProcess"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#Microorganism"></see>
    /// </summary>
    let Microorganism = _prefix "Microorganism"
    /// <summary>
    /// Difficult concept. Better to be expressed by the primitive "mental function"
    /// <see href="http://purl.org/biotop/biotop.owl#Mind"></see></summary>
    let Mind = _prefix "Mind"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#derivesFrom"></see>
    /// </summary>
    let derivesFrom = _prefix "derivesFrom"

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#MolecularEntityByGranularityPartition"></see>
    /// </summary>
    let MolecularEntityByGranularityPartition =
        _prefix "MolecularEntityByGranularityPartition"

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#OligoOrPolymer"></see>
    /// </summary>
    let OligoOrPolymer = _prefix "OligoOrPolymer"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#MolecularFunction"></see>
    /// </summary>
    let MolecularFunction = _prefix "MolecularFunction"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#componentPartOf"></see>
    /// </summary>
    let componentPartOf = _prefix "componentPartOf"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#MulticellularOrganism"></see>
    /// </summary>
    let MulticellularOrganism = _prefix "MulticellularOrganism"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#NeoplasticProcess"></see>
    /// </summary>
    let NeoplasticProcess = _prefix "NeoplasticProcess"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#NucleicAcidRegion"></see>
    /// </summary>
    let NucleicAcidRegion = _prefix "NucleicAcidRegion"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#NucleotideSequenceInformation"></see>
    /// </summary>
    let NucleotideSequenceInformation = _prefix "NucleotideSequenceInformation"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#NurseRole"></see>
    /// </summary>
    let NurseRole = _prefix "NurseRole"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#PhysicianRole"></see>
    /// </summary>
    let PhysicianRole = _prefix "PhysicianRole"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#ProcessQuality"></see>
    /// </summary>
    let ProcessQuality = _prefix "ProcessQuality"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#ObservingAction"></see>
    /// </summary>
    let ObservingAction = _prefix "ObservingAction"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#OneDimensionalBoundary"></see>
    /// </summary>
    let OneDimensionalBoundary = _prefix "OneDimensionalBoundary"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#TwoDimensionalBoundary"></see>
    /// </summary>
    let TwoDimensionalBoundary = _prefix "TwoDimensionalBoundary"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#OrganSystemPart"></see>
    /// </summary>
    let OrganSystemPart = _prefix "OrganSystemPart"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#Tissue"></see>
    /// </summary>
    let Tissue = _prefix "Tissue"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#ParticularEntity"></see>
    /// </summary>
    let ParticularEntity = _prefix "ParticularEntity"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#PathologicalCondition"></see>
    /// </summary>
    let PathologicalCondition = _prefix "PathologicalCondition"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#PathologicalDisposition"></see>
    /// </summary>
    let PathologicalDisposition = _prefix "PathologicalDisposition"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#PathologicalProcess"></see>
    /// </summary>
    let PathologicalProcess = _prefix "PathologicalProcess"

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#StructuredBiologicalCompoundByCanonicityPartition"></see>
    /// </summary>
    let StructuredBiologicalCompoundByCanonicityPartition =
        _prefix "StructuredBiologicalCompoundByCanonicityPartition"

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#WellFormedBiologicalStructure"></see>
    /// </summary>
    let WellFormedBiologicalStructure = _prefix "WellFormedBiologicalStructure"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#processQualityOf"></see>
    /// </summary>
    let processQualityOf = _prefix "processQualityOf"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#PeptideFunction"></see>
    /// </summary>
    let PeptideFunction = _prefix "PeptideFunction"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#Phosphate"></see>
    /// </summary>
    let Phosphate = _prefix "Phosphate"
    /// <summary>
    /// EXAMPLE OF TAXON REGION
    /// <see href="http://purl.org/biotop/biotop.owl#PhylumChordataValueRegion"></see></summary>
    let PhylumChordataValueRegion = _prefix "PhylumChordataValueRegion"
    /// <summary>
    /// EXAMPLE OF TAXON REGION
    /// <see href="http://purl.org/biotop/biotop.owl#PhylumAscomycotaValueRegion"></see></summary>
    let PhylumAscomycotaValueRegion = _prefix "PhylumAscomycotaValueRegion"
    /// <summary>
    /// EXAMPLE OF POPULATION
    /// <see href="http://purl.org/biotop/biotop.owl#PlantPopulation"></see></summary>
    let PlantPopulation = _prefix "PlantPopulation"

    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#PluralityOfIdenticalPolymolecularEntities"></see>
    /// </summary>
    let PluralityOfIdenticalPolymolecularEntities =
        _prefix "PluralityOfIdenticalPolymolecularEntities"

    /// <summary>
    /// negatively affecting the integrity of a biologival system caused by one or more chemical substances
    /// <see href="http://purl.org/biotop/biotop.owl#Poisoning"></see></summary>
    let Poisoning = _prefix "Poisoning"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#PortionOfHeterogenousSolid"></see>
    /// </summary>
    let PortionOfHeterogenousSolid = _prefix "PortionOfHeterogenousSolid"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#PortionOfHomogenousMatter"></see>
    /// </summary>
    let PortionOfHomogenousMatter = _prefix "PortionOfHomogenousMatter"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#PreventionAction"></see>
    /// </summary>
    let PreventionAction = _prefix "PreventionAction"
    /// <summary>
    /// EXAMPLE OF POPULATION
    /// <see href="http://purl.org/biotop/biotop.owl#PrimatePopulation"></see></summary>
    let PrimatePopulation = _prefix "PrimatePopulation"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#Producing"></see>
    /// </summary>
    let Producing = _prefix "Producing"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#ProteinComplex"></see>
    /// </summary>
    let ProteinComplex = _prefix "ProteinComplex"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#ProteinDomain"></see>
    /// </summary>
    let ProteinDomain = _prefix "ProteinDomain"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#ProteinSubstructure"></see>
    /// </summary>
    let ProteinSubstructure = _prefix "ProteinSubstructure"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#ProteinSubunit"></see>
    /// </summary>
    let ProteinSubunit = _prefix "ProteinSubunit"
    /// <summary>
    /// EXAMPLE OF POPULATION
    /// <see href="http://purl.org/biotop/biotop.owl#ProtistPopulation"></see></summary>
    let ProtistPopulation = _prefix "ProtistPopulation"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#Radiation"></see>
    /// </summary>
    let Radiation = _prefix "Radiation"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#Wave"></see>
    /// </summary>
    let Wave = _prefix "Wave"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#RegulatoryBody"></see>
    /// </summary>
    let RegulatoryBody = _prefix "RegulatoryBody"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#SocialAction"></see>
    /// </summary>
    let SocialAction = _prefix "SocialAction"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#SpatialRegion"></see>
    /// </summary>
    let SpatialRegion = _prefix "SpatialRegion"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#TemporalEntity"></see>
    /// </summary>
    let TemporalEntity = _prefix "TemporalEntity"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#Treating"></see>
    /// </summary>
    let Treating = _prefix "Treating"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#TreatingCondition"></see>
    /// </summary>
    let TreatingCondition = _prefix "TreatingCondition"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#TreatingOrganism"></see>
    /// </summary>
    let TreatingOrganism = _prefix "TreatingOrganism"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#TwoDimensionalBiologicalEntity"></see>
    /// </summary>
    let TwoDimensionalBiologicalEntity = _prefix "TwoDimensionalBiologicalEntity"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#UnicellularOrganism"></see>
    /// </summary>
    let UnicellularOrganism = _prefix "UnicellularOrganism"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#UsingAction"></see>
    /// </summary>
    let UsingAction = _prefix "UsingAction"
    /// <summary>
    /// EXAMPLE OF POPULATION
    /// <see href="http://purl.org/biotop/biotop.owl#VertebratePopulation"></see></summary>
    let VertebratePopulation = _prefix "VertebratePopulation"
    /// <summary>
    /// EXAMPLE OF POPULATION
    /// <see href="http://purl.org/biotop/biotop.owl#VirusPopulation"></see></summary>
    let VirusPopulation = _prefix "VirusPopulation"
    /// <summary>
    /// EXAMPLE OF POPULATION
    /// <see href="http://purl.org/biotop/biotop.owl#YeastPopulation"></see></summary>
    let YeastPopulation = _prefix "YeastPopulation"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#abstractPartOf"></see>
    /// </summary>
    let abstractPartOf = _prefix "abstractPartOf"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#abstractlyRelatedTo"></see>
    /// </summary>
    let abstractlyRelatedTo = _prefix "abstractlyRelatedTo"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#hasAbstractPart"></see>
    /// </summary>
    let hasAbstractPart = _prefix "hasAbstractPart"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#agentIn"></see>
    /// </summary>
    let agentIn = _prefix "agentIn"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#causes"></see>
    /// </summary>
    let causes = _prefix "causes"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#attachedTo"></see>
    /// </summary>
    let attachedTo = _prefix "attachedTo"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#contiguousWith"></see>
    /// </summary>
    let contiguousWith = _prefix "contiguousWith"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#locusOf"></see>
    /// </summary>
    let locusOf = _prefix "locusOf"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#branchOf"></see>
    /// </summary>
    let branchOf = _prefix "branchOf"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#hasBranch"></see>
    /// </summary>
    let hasBranch = _prefix "hasBranch"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#causallyRelatedTo"></see>
    /// </summary>
    let causallyRelatedTo = _prefix "causallyRelatedTo"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#causedBy"></see>
    /// </summary>
    let causedBy = _prefix "causedBy"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#physicallyAdjacentTo"></see>
    /// </summary>
    let physicallyAdjacentTo = _prefix "physicallyAdjacentTo"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#continuousWith"></see>
    /// </summary>
    let continuousWith = _prefix "continuousWith"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#cooccurringWith"></see>
    /// </summary>
    let cooccurringWith = _prefix "cooccurringWith"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#temporallyRelatedTo"></see>
    /// </summary>
    let temporallyRelatedTo = _prefix "temporallyRelatedTo"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#denotedBy"></see>
    /// </summary>
    let denotedBy = _prefix "denotedBy"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#denotes"></see>
    /// </summary>
    let denotes = _prefix "denotes"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#derivedInto"></see>
    /// </summary>
    let derivedInto = _prefix "derivedInto"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#hasOrigin"></see>
    /// </summary>
    let hasOrigin = _prefix "hasOrigin"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#encodedBy"></see>
    /// </summary>
    let encodedBy = _prefix "encodedBy"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#encodes"></see>
    /// </summary>
    let encodes = _prefix "encodes"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#featureOf"></see>
    /// </summary>
    let featureOf = _prefix "featureOf"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#hasFeature"></see>
    /// </summary>
    let hasFeature = _prefix "hasFeature"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#granularPartOf"></see>
    /// </summary>
    let granularPartOf = _prefix "granularPartOf"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#spatiallyRelatedTo"></see>
    /// </summary>
    let spatiallyRelatedTo = _prefix "spatiallyRelatedTo"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#hasOriginalPart"></see>
    /// </summary>
    let hasOriginalPart = _prefix "hasOriginalPart"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#originalPartOf"></see>
    /// </summary>
    let originalPartOf = _prefix "originalPartOf"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#hasOriginatingPhysicalPart"></see>
    /// </summary>
    let hasOriginatingPhysicalPart = _prefix "hasOriginatingPhysicalPart"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#originatingPhysicalPartOf"></see>
    /// </summary>
    let originatingPhysicalPartOf = _prefix "originatingPhysicalPartOf"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#processuallyRelatedTo"></see>
    /// </summary>
    let processuallyRelatedTo = _prefix "processuallyRelatedTo"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#physicalLocationOf"></see>
    /// </summary>
    let physicalLocationOf = _prefix "physicalLocationOf"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#hasProcessRole"></see>
    /// </summary>
    let hasProcessRole = _prefix "hasProcessRole"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#hasProcessualPart"></see>
    /// </summary>
    let hasProcessualPart = _prefix "hasProcessualPart"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#processualPartOf"></see>
    /// </summary>
    let processualPartOf = _prefix "processualPartOf"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#realizationOf"></see>
    /// </summary>
    let realizationOf = _prefix "realizationOf"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#isAbout"></see>
    /// </summary>
    let isAbout = _prefix "isAbout"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#outcomeOf"></see>
    /// </summary>
    let outcomeOf = _prefix "outcomeOf"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#physicallyConnectedTo"></see>
    /// </summary>
    let physicallyConnectedTo = _prefix "physicallyConnectedTo"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#physicalPartOf"></see>
    /// </summary>
    let physicalPartOf = _prefix "physicalPartOf"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#physicallyLocatedIn"></see>
    /// </summary>
    let physicallyLocatedIn = _prefix "physicallyLocatedIn"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#physicallyBoundedBy"></see>
    /// </summary>
    let physicallyBoundedBy = _prefix "physicallyBoundedBy"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#physicallyContains"></see>
    /// </summary>
    let physicallyContains = _prefix "physicallyContains"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#physicallyDisconnectedFrom"></see>
    /// </summary>
    let physicallyDisconnectedFrom = _prefix "physicallyDisconnectedFrom"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#physicallyInterconnects"></see>
    /// </summary>
    let physicallyInterconnects = _prefix "physicallyInterconnects"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#physicallySurroundedBy"></see>
    /// </summary>
    let physicallySurroundedBy = _prefix "physicallySurroundedBy"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#physicallySurrounds"></see>
    /// </summary>
    let physicallySurrounds = _prefix "physicallySurrounds"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#physicallyTraverses"></see>
    /// </summary>
    let physicallyTraverses = _prefix "physicallyTraverses"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#precededBy"></see>
    /// </summary>
    let precededBy = _prefix "precededBy"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#precedes"></see>
    /// </summary>
    let precedes = _prefix "precedes"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#processRoleOf"></see>
    /// </summary>
    let processRoleOf = _prefix "processRoleOf"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#ramificationOf"></see>
    /// </summary>
    let ramificationOf = _prefix "ramificationOf"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#ramifies"></see>
    /// </summary>
    let ramifies = _prefix "ramifies"
    /// <summary>
    ///   <see href="http://purl.org/biotop/biotop.owl#touches"></see>
    /// </summary>
    let touches = _prefix "touches"
