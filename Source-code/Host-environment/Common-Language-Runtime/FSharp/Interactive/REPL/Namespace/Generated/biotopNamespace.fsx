#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module biotop =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://purl.org/biotop/biotop.owl#" "biotop"

    /// <summary>
    ///   <para>ru:definition : biological structure that deviates from what is considered normal and that evolved during lifetime^^xsd:string</para>
    ///   <para>rdfs:label : acquired abnormal structure^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#AcquiredAbnormalStructure">biotop:AcquiredAbnormalStructure</a>
    /// </summary>
    let AcquiredAbnormalStructure = _prefixId.prefix "AcquiredAbnormalStructure"
    /// <summary>
    ///   <para>ru:definition : Ill-formed state of a biological entity,acquired after birth [steschu 20071010]^^xsd:string</para>
    ///   <para>rdfs:label : acquired pathological condition^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#AcquiredPathologicalCondition">biotop:AcquiredPathologicalCondition</a>
    /// </summary>
    let AcquiredPathologicalCondition = _prefixId.prefix "AcquiredPathologicalCondition"

    /// <summary>
    ///   <para>owl:priorVersion : acquired pathological state^^xsd:string</para>
    ///   <para>ru:definition : pathological state acquired during lifetime^^xsd:string</para>
    ///   <para>rdfs:label : acquired pathological static processual entity^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#AcquiredPathologicalStaticProcessualEntity">biotop:AcquiredPathologicalStaticProcessualEntity</a>
    /// </summary>
    let AcquiredPathologicalStaticProcessualEntity =
        _prefixId.prefix "AcquiredPathologicalStaticProcessualEntity"

    /// <summary>
    ///   <para>ru:definition : An action is a processual entity that that is promoted by an agent, having a clear role distinction between agent and patient^^xsd:string</para>
    ///   <para>rdfs:label : action^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#Action">biotop:Action</a>
    /// </summary>
    let Action = _prefixId.prefix "Action"
    /// <summary>
    ///   <para>ru:definition : an action which externally acts upon a biological system^^xsd:string</para>
    ///   <para>rdfs:label : action on biological system^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#ActionOnBiologicalSystem">biotop:ActionOnBiologicalSystem</a>
    /// </summary>
    let ActionOnBiologicalSystem = _prefixId.prefix "ActionOnBiologicalSystem"
    /// <summary>
    ///   <para>ru:definition : organism in reproductive phase^^xsd:string</para>
    ///   <para>rdfs:label : adult organism^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#AdultOrganism">biotop:AdultOrganism</a>
    /// </summary>
    let AdultOrganism = _prefixId.prefix "AdultOrganism"
    /// <summary>
    ///   <para>rdfs:label : adult value region^^xsd:string</para>
    ///   <para>rdfs:comment : "adult" as the value of a developmental stage. E.g. a 4 year old dog has a quality which has its value located in "adult value region".^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#AdultValueRegion">biotop:AdultValueRegion</a>
    /// </summary>
    let AdultValueRegion = _prefixId.prefix "AdultValueRegion"
    /// <summary>
    ///   <para>ru:definition : Producing a direct effect on^^xsd:string</para>
    ///   <para>rdfs:label : affecting^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#Affecting">biotop:Affecting</a>
    /// </summary>
    let Affecting = _prefixId.prefix "Affecting"
    /// <summary>
    ///   <para>ru:definition : the quality of having a livespan^^xsd:string</para>
    ///   <para>rdfs:label : age quality^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#AgeQuality">biotop:AgeQuality</a>
    /// </summary>
    let AgeQuality = _prefixId.prefix "AgeQuality"
    /// <summary>
    ///   <para>rdfs:label : alga^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#Alga">biotop:Alga</a>
    /// </summary>
    let Alga = _prefixId.prefix "Alga"
    /// <summary>
    ///   <para>ru:definition : Positively charged particles composed of two protons and two neutrons, i.e. equivalent to Helium nuclei ^^xsd:string</para>
    ///   <para>rdfs:label : alpha particle^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#AlphaParticle">biotop:AlphaParticle</a>
    /// </summary>
    let AlphaParticle = _prefixId.prefix "AlphaParticle"
    /// <summary>
    ///   <para>ru:definition : Amino Acids molecules or residues (residues as in peptide bonds)^^xsd:string</para>
    ///   <para>rdfs:label : amino acid molecule or residue^^xsd:string</para>
    ///   <para>rdfs:comment : (QCR) ro:hasPart some CarbonHydrogenSubstructure and ((hasComponent myx 2 CarboxyGroup) and (hasComponent min 1 CarboxyGroup) and (hasComponent exactly 1 AminoGroup)) or ((hasComponent max 2 AminoGroup) and (hasComponent min 1 AminoGroup) and (hasComponent exactly 1 CarboxyGroup))^^xsd:stringrdfs:comment : In chemistry, an amino acid is any molecule that contains both amine and carboxyl functional groups. However, in biochemistry, this more general term is frequently used to refer to alpha amino acids (amino acids in which the amino and carboxylate functionalities are attached to the same carbon, called ?–carbon). Amino Acids have at least one amino and one carboxy group. Those having two carboxy groups have only one amino group and vice versa.^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#AminoAcidMoleculeOrResidue">biotop:AminoAcidMoleculeOrResidue</a>
    /// </summary>
    let AminoAcidMoleculeOrResidue = _prefixId.prefix "AminoAcidMoleculeOrResidue"

    /// <summary>
    ///   <para>ru:definition : amino acids as monomers and polymers^^xsd:string</para>
    ///   <para>rdfs:label : amino acid or peptide molecule or structure^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#AminoAcidOrPeptideMoleculeOrStructure">biotop:AminoAcidOrPeptideMoleculeOrStructure</a>
    /// </summary>
    let AminoAcidOrPeptideMoleculeOrStructure =
        _prefixId.prefix "AminoAcidOrPeptideMoleculeOrStructure"

    /// <summary>
    ///   <para>ru:definition : Chain of amino acids, joined by peptide bonds. Folded or unfolded.^^xsd:string</para>
    ///   <para>rdfs:label : amino acid sequence^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#AminoAcidSequence">biotop:AminoAcidSequence</a>
    /// </summary>
    let AminoAcidSequence = _prefixId.prefix "AminoAcidSequence"
    /// <summary>
    ///   <para>ru:definition : The information that describes the make-up of a (physical) amino acid sequence.^^xsd:string</para>
    ///   <para>rdfs:label : amino acid sequence information^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#AminoAcidSequenceInformation">biotop:AminoAcidSequenceInformation</a>
    /// </summary>
    let AminoAcidSequenceInformation = _prefixId.prefix "AminoAcidSequenceInformation"
    /// <summary>
    ///   <para>ru:definition : collection with molecules or atoms as granular parts (but which may have also bigger granular parts) that is produced by a biological system (e.g. blood, urine, ivory)^^xsd:string</para>
    ///   <para>rdfs:label : amount of body substance^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#AmountOfBodySubstance">biotop:AmountOfBodySubstance</a>
    /// </summary>
    let AmountOfBodySubstance = _prefixId.prefix "AmountOfBodySubstance"
    /// <summary>
    ///   <para>ru:definition : collection with molecules or atoms as granular parts of the same sort^^xsd:string</para>
    ///   <para>rdfs:label : amount of pure substance^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#AmountOfPureSubstance">biotop:AmountOfPureSubstance</a>
    /// </summary>
    let AmountOfPureSubstance = _prefixId.prefix "AmountOfPureSubstance"
    /// <summary>
    ///   <para>rdfs:label : amphibian^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#Amphibian">biotop:Amphibian</a>
    /// </summary>
    let Amphibian = _prefixId.prefix "Amphibian"
    /// <summary>
    ///   <para>rdfs:label : analyzing^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#Analyzing">biotop:Analyzing</a>
    /// </summary>
    let Analyzing = _prefixId.prefix "Analyzing"
    /// <summary>
    ///   <para>rdfs:label : animal cell^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#AnimalCell">biotop:AnimalCell</a>
    /// </summary>
    let AnimalCell = _prefixId.prefix "AnimalCell"
    /// <summary>
    ///   <para>rdfs:label : animal excluding human^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#AnimalExcludingHuman">biotop:AnimalExcludingHuman</a>
    /// </summary>
    let AnimalExcludingHuman = _prefixId.prefix "AnimalExcludingHuman"
    /// <summary>
    ///   <para>ru:definition : Multicellular organisms of the kingdom Animalia^^xsd:string</para>
    ///   <para>rdfs:label : animal including human^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#AnimalIncludingHuman">biotop:AnimalIncludingHuman</a>
    /// </summary>
    let AnimalIncludingHuman = _prefixId.prefix "AnimalIncludingHuman"
    /// <summary>
    ///   <para>ru:definition : language used in communication between animals^^xsd:string</para>
    ///   <para>rdfs:label : animal language^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#AnimalLanguage">biotop:AnimalLanguage</a>
    /// </summary>
    let AnimalLanguage = _prefixId.prefix "AnimalLanguage"
    /// <summary>
    ///   <para>rdfs:label : animal population^^xsd:string</para>
    ///   <para>rdfs:comment : EXAMPLE OF POPULATION^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#AnimalPopulation">biotop:AnimalPopulation</a>
    /// </summary>
    let AnimalPopulation = _prefixId.prefix "AnimalPopulation"
    /// <summary>
    ///   <para>ru:definition : the role a chemical plays if used to combat a bacterial infection^^xsd:string</para>
    ///   <para>rdfs:label : antibiotic role^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#AntibioticRole">biotop:AntibioticRole</a>
    /// </summary>
    let AntibioticRole = _prefixId.prefix "AntibioticRole"
    /// <summary>
    ///   <para>ru:synonym : Archaebacterium^^xsd:string</para>
    ///   <para>rdfs:label : archaebacterial cell^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#ArchaebacterialCell">biotop:ArchaebacterialCell</a>
    /// </summary>
    let ArchaebacterialCell = _prefixId.prefix "ArchaebacterialCell"
    /// <summary>
    ///   <para>ru:definition : The role an entity plays when it has been artificially produced. [steschu 20071010]^^xsd:string</para>
    ///   <para>rdfs:label : artefact role^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#ArtefactRole">biotop:ArtefactRole</a>
    /// </summary>
    let ArtefactRole = _prefixId.prefix "ArtefactRole"
    /// <summary>
    ///   <para>rdfs:label : arthropod^^xsd:string</para>
    ///   <para>rdfs:comment : one arthropod^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#Arthropod">biotop:Arthropod</a>
    /// </summary>
    let Arthropod = _prefixId.prefix "Arthropod"
    /// <summary>
    ///   <para>rdfs:label : arthropod population^^xsd:string</para>
    ///   <para>rdfs:comment : EXAMPLE OF POPULATION^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#ArthropodPopulation">biotop:ArthropodPopulation</a>
    /// </summary>
    let ArthropodPopulation = _prefixId.prefix "ArthropodPopulation"
    /// <summary>
    ///   <para>ru:definition : Basic building block of molecules. Particle of discrete types. Biologically important atoms are C, N, H, O, P, S, Na, Ca, K, Mg, Cl, J, Fe, Co, Zn ,... Atoms may be electrically neutral or ionic.^^xsd:string</para>
    ///   <para>rdfs:label : atom^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#Atom">biotop:Atom</a>
    /// </summary>
    let Atom = _prefixId.prefix "Atom"
    /// <summary>
    ///   <para>rdfs:label : bacteria population^^xsd:string</para>
    ///   <para>rdfs:comment : EXAMPLE OF POPULATION^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#BacteriaPopulation">biotop:BacteriaPopulation</a>
    /// </summary>
    let BacteriaPopulation = _prefixId.prefix "BacteriaPopulation"
    /// <summary>
    ///   <para>ru:synonym : Bacterium^^xsd:string</para>
    ///   <para>rdfs:label : bacterial cell^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#BacterialCell">biotop:BacterialCell</a>
    /// </summary>
    let BacterialCell = _prefixId.prefix "BacterialCell"
    /// <summary>
    ///   <para>ru:definition : Cluster of bacteria, usually cultured from a single cell.^^xsd:string</para>
    ///   <para>rdfs:label : bacterial colony^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#BacterialColony">biotop:BacterialColony</a>
    /// </summary>
    let BacterialColony = _prefixId.prefix "BacterialColony"
    /// <summary>
    ///   <para>rdfs:label : bakers yeast cell^^xsd:string</para>
    ///   <para>rdfs:comment : one saccharomyces cerevisiae cell^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#BakersYeastCell">biotop:BakersYeastCell</a>
    /// </summary>
    let BakersYeastCell = _prefixId.prefix "BakersYeastCell"
    /// <summary>
    ///   <para>rdfs:label : bakers yeast population^^xsd:string</para>
    ///   <para>rdfs:comment : EXAMPLE OF POPULATION^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#BakersYeastPopulation">biotop:BakersYeastPopulation</a>
    /// </summary>
    let BakersYeastPopulation = _prefixId.prefix "BakersYeastPopulation"
    /// <summary>
    ///   <para>ru:definition : An (often habitual) action of an organism that is the realization of some disposition^^xsd:string</para>
    ///   <para>rdfs:label : behavior^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#Behavior">biotop:Behavior</a>
    /// </summary>
    let Behavior = _prefixId.prefix "Behavior"
    /// <summary>
    ///   <para>ru:definition : Process occuring on molecular level. It has exclusivly subclasses of MolecularEntity as participants.^^xsd:string</para>
    ///   <para>rdfs:label : bio molecular process^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#BioMolecularProcess">biotop:BioMolecularProcess</a>
    /// </summary>
    let BioMolecularProcess = _prefixId.prefix "BioMolecularProcess"

    /// <summary>
    ///   <para>ru:definition : Sequence as an entity of information. The same sequence can inhere in different biopolymers. Sequence information can be theoretical, therefore a "real" sequence is not implied.^^xsd:string</para>
    ///   <para>rdfs:label : bio molecular sequence information^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#BioMolecularSequenceInformation">biotop:BioMolecularSequenceInformation</a>
    /// </summary>
    let BioMolecularSequenceInformation =
        _prefixId.prefix "BioMolecularSequenceInformation"

    /// <summary>
    ///   <para>ru:definition : chain (segment) of similar monomers such as proteins or nucleotides^^xsd:string</para>
    ///   <para>rdfs:label : bio molecular sequence structure^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#BioMolecularSequenceStructure">biotop:BioMolecularSequenceStructure</a>
    /// </summary>
    let BioMolecularSequenceStructure = _prefixId.prefix "BioMolecularSequenceStructure"
    /// <summary>
    ///   <para>ru:definition : Action that has some biological entity as agent^^xsd:string</para>
    ///   <para>rdfs:label : biological action^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#BiologicalAction">biotop:BiologicalAction</a>
    /// </summary>
    let BiologicalAction = _prefixId.prefix "BiologicalAction"
    /// <summary>
    ///   <para>ru:definition : boundary in or of a biological entity^^xsd:string</para>
    ///   <para>rdfs:label : biological boundary^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#BiologicalBoundary">biotop:BiologicalBoundary</a>
    /// </summary>
    let BiologicalBoundary = _prefixId.prefix "BiologicalBoundary"
    /// <summary>
    ///   <para>ru:definition : Plurality of several individual organisms living closely together, usually for mutual benefit^^xsd:string</para>
    ///   <para>rdfs:label : biological colony^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#BiologicalColony">biotop:BiologicalColony</a>
    /// </summary>
    let BiologicalColony = _prefixId.prefix "BiologicalColony"
    /// <summary>
    ///   <para>ru:definition : a function that inheres in some structured biological entity.^^xsd:string</para>
    ///   <para>rdfs:label : biological function^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#BiologicalFunction">biotop:BiologicalFunction</a>
    /// </summary>
    let BiologicalFunction = _prefixId.prefix "BiologicalFunction"
    /// <summary>
    ///   <para>ru:definition : The whole process from origin to death of an organism^^xsd:string</para>
    ///   <para>rdfs:label : biological life^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#BiologicalLife">biotop:BiologicalLife</a>
    /// </summary>
    let BiologicalLife = _prefixId.prefix "BiologicalLife"
    /// <summary>
    ///   <para>ru:definition : Process specific for biological systems.^^xsd:string</para>
    ///   <para>rdfs:label : biological processual entity^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#BiologicalProcessualEntity">biotop:BiologicalProcessualEntity</a>
    /// </summary>
    let BiologicalProcessualEntity = _prefixId.prefix "BiologicalProcessualEntity"
    /// <summary>
    ///   <para>ru:definition : quality of being visible with or without microscope^^xsd:string</para>
    ///   <para>rdfs:label : biological size^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#BiologicalSize">biotop:BiologicalSize</a>
    /// </summary>
    let BiologicalSize = _prefixId.prefix "BiologicalSize"
    /// <summary>
    ///   <para>ru:definition : values that describe the size of biological entities^^xsd:string</para>
    ///   <para>rdfs:label : biological size value region^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#BiologicalSizeValueRegion">biotop:BiologicalSizeValueRegion</a>
    /// </summary>
    let BiologicalSizeValueRegion = _prefixId.prefix "BiologicalSizeValueRegion"
    /// <summary>
    ///   <para>ru:definition : space that is located inside a biological entity^^xsd:string</para>
    ///   <para>rdfs:label : biological space^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#BiologicalSpace">biotop:BiologicalSpace</a>
    /// </summary>
    let BiologicalSpace = _prefixId.prefix "BiologicalSpace"
    /// <summary>
    ///   <para>ru:definition : A role specific to biological processes^^xsd:string</para>
    ///   <para>rdfs:label : biological system role^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#BiologicalSystemRole">biotop:BiologicalSystemRole</a>
    /// </summary>
    let BiologicalSystemRole = _prefixId.prefix "BiologicalSystemRole"
    /// <summary>
    ///   <para>ru:definition : Role of Non-drug material used for therapeutic Purpose^^xsd:string</para>
    ///   <para>rdfs:label : biomedical material role^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#BiomedicalMaterialRole">biotop:BiomedicalMaterialRole</a>
    /// </summary>
    let BiomedicalMaterialRole = _prefixId.prefix "BiomedicalMaterialRole"
    /// <summary>
    ///   <para>ru:definition : Monomolecular entity that stems from some organism^^xsd:string</para>
    ///   <para>rdfs:label : biomolecule^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#Biomolecule">biotop:Biomolecule</a>
    /// </summary>
    let Biomolecule = _prefixId.prefix "Biomolecule"
    /// <summary>
    ///   <para>rdfs:label : bird^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#Bird">biotop:Bird</a>
    /// </summary>
    let Bird = _prefixId.prefix "Bird"
    /// <summary>
    ///   <para>ru:definition : Entire biological structure that constitutes a (living) organism. A body can be living or dead. Whether a living organism coincides with its body or hasPart its body, is controversial. We use "hasPhysicalPart" for relating organism to body. Being reflexive, this would not be incompatible with a view in which a living organism is a body.^^xsd:string</para>
    ///   <para>rdfs:seeAlso : FMAID:256135 Body^^xsd:string</para>
    ///   <para>rdfs:label : body^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#Body">biotop:Body</a>
    /// </summary>
    let Body = _prefixId.prefix "Body"
    /// <summary>
    ///   <para>ru:definition : Suspension and / or solution of biomolecules, ions, bigger particles in Water.^^xsd:string</para>
    ///   <para>rdfs:label : body liquid^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#BodyLiquid">biotop:BodyLiquid</a>
    /// </summary>
    let BodyLiquid = _prefixId.prefix "BodyLiquid"
    /// <summary>
    ///   <para>ru:definition : Mereological sum of heterogeneous body components that constitute a functional unity^^xsd:string</para>
    ///   <para>rdfs:label : body system^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#BodySystem">biotop:BodySystem</a>
    /// </summary>
    let BodySystem = _prefixId.prefix "BodySystem"
    /// <summary>
    ///   <para>rdfs:label : candida albicans cell^^xsd:string</para>
    ///   <para>rdfs:comment : One candida albicans cell^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#CandidaAlbicansCell">biotop:CandidaAlbicansCell</a>
    /// </summary>
    let CandidaAlbicansCell = _prefixId.prefix "CandidaAlbicansCell"
    /// <summary>
    ///   <para>rdfs:label : candida albicans population^^xsd:string</para>
    ///   <para>rdfs:comment : EXAMPLE OF POPULATION^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#CandidaAlbicansPopulation">biotop:CandidaAlbicansPopulation</a>
    /// </summary>
    let CandidaAlbicansPopulation = _prefixId.prefix "CandidaAlbicansPopulation"
    /// <summary>
    ///   <para>ru:definition : a process that is considered normal^^xsd:string</para>
    ///   <para>rdfs:label : canonical processual entity^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#CanonicalProcessualEntity">biotop:CanonicalProcessualEntity</a>
    /// </summary>
    let CanonicalProcessualEntity = _prefixId.prefix "CanonicalProcessualEntity"

    /// <summary>
    ///   <para>owl:priorVersion : canonical state^^xsd:string</para>
    ///   <para>rdfs:label : canonical static processual entity^^xsd:string</para>
    ///   <para>rdfs:comment : a biological state that is considered "normal"^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#CanonicalStaticProcessualEntity">biotop:CanonicalStaticProcessualEntity</a>
    /// </summary>
    let CanonicalStaticProcessualEntity =
        _prefixId.prefix "CanonicalStaticProcessualEntity"

    /// <summary>
    ///   <para>rdfs:label : canonical value region^^xsd:string</para>
    ///   <para>rdfs:comment : abstract region in which the value "canonical" of canonicity is located^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#CanonicalValueRegion">biotop:CanonicalValueRegion</a>
    /// </summary>
    let CanonicalValueRegion = _prefixId.prefix "CanonicalValueRegion"
    /// <summary>
    ///   <para>ru:definition : The condition of an entity (state, process, function, object) in terms of being well or ill-formed or behaving^^xsd:string</para>
    ///   <para>rdfs:label : canonicity^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#Canonicity">biotop:Canonicity</a>
    /// </summary>
    let Canonicity = _prefixId.prefix "Canonicity"
    /// <summary>
    ///   <para>ru:definition : abstract region in which values of canonicity are located^^xsd:string</para>
    ///   <para>rdfs:label : canonicity value region^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#CanonicityValueRegion">biotop:CanonicityValueRegion</a>
    /// </summary>
    let CanonicityValueRegion = _prefixId.prefix "CanonicityValueRegion"
    /// <summary>
    ///   <para>rdfs:label : carbohydrate molecule or residue^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#CarbohydrateMoleculeOrResidue">biotop:CarbohydrateMoleculeOrResidue</a>
    /// </summary>
    let CarbohydrateMoleculeOrResidue = _prefixId.prefix "CarbohydrateMoleculeOrResidue"
    /// <summary>
    ///   <para>rdfs:label : carbohydrate monomer^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#CarbohydrateMonomer">biotop:CarbohydrateMonomer</a>
    /// </summary>
    let CarbohydrateMonomer = _prefixId.prefix "CarbohydrateMonomer"

    /// <summary>
    ///   <para>ru:definition : The information that describes the make-up of a (physical) carbohydrate sequence.^^xsd:string</para>
    ///   <para>rdfs:label : carbohydrate sequence information^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#CarbohydrateSequenceInformation">biotop:CarbohydrateSequenceInformation</a>
    /// </summary>
    let CarbohydrateSequenceInformation =
        _prefixId.prefix "CarbohydrateSequenceInformation"

    /// <summary>
    ///   <para>ru:definition : The role a substance plays in accelerating a chemical reaction^^xsd:string</para>
    ///   <para>rdfs:label : catalytic role^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#CatalyticRole">biotop:CatalyticRole</a>
    /// </summary>
    let CatalyticRole = _prefixId.prefix "CatalyticRole"
    /// <summary>
    ///   <para>ru:definition : A categorization system is a human artifact that aims at partinioning object classes, denotations, or concepts of a given domain.^^xsd:string</para>
    ///   <para>rdfs:label : categorization system^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#CategorizationSystem">biotop:CategorizationSystem</a>
    /// </summary>
    let CategorizationSystem = _prefixId.prefix "CategorizationSystem"
    /// <summary>
    ///   <para>ru:definition : action that causes an effect^^xsd:string</para>
    ///   <para>rdfs:label : causing^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#Causing">biotop:Causing</a>
    /// </summary>
    let Causing = _prefixId.prefix "Causing"
    /// <summary>
    ///   <para>ru:definition : Constituting unit of an organism. The boundary between cell, syncytium and subcellular fragments such as platelets is problematic. Hence no full definition possible.^^xsd:string</para>
    ///   <para>rdfs:label : cell^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#Cell">biotop:Cell</a>
    /// </summary>
    let Cell = _prefixId.prefix "Cell"
    /// <summary>
    ///   <para>ru:definition :
    /// CellByLocusPartition
    ///
    /// Ontologically irrelevant partitioning node. Used for improving ontology housekeeping. Its purpose is to express that all subclasses are mutually disjoint.^^xsd:string</para>
    ///   <para>rdfs:label : *^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#CellByLocusPartition">biotop:CellByLocusPartition</a>
    /// </summary>
    let CellByLocusPartition = _prefixId.prefix "CellByLocusPartition"
    /// <summary>
    ///   <para>ru:definition : CellByTaxonPartition
    ///
    /// Ontologically irrelevant partitioning node. Used for improving ontology housekeeping. Its purpose is to express that all subclasses are mutually disjoint.^^xsd:string</para>
    ///   <para>rdfs:label : *^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#CellByTaxonPartition">biotop:CellByTaxonPartition</a>
    /// </summary>
    let CellByTaxonPartition = _prefixId.prefix "CellByTaxonPartition"
    /// <summary>
    ///   <para>ru:definition : CellByTypePartition
    ///
    /// Ontologically irrelevant partitioning node. Used for improving ontology housekeeping. Its purpose is to express that all subclasses are mutually disjoint.^^xsd:string</para>
    ///   <para>rdfs:label : *^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#CellByTypePartition">biotop:CellByTypePartition</a>
    /// </summary>
    let CellByTypePartition = _prefixId.prefix "CellByTypePartition"
    /// <summary>
    ///   <para>ru:definition : Living cell that is not removed from a living system^^xsd:string</para>
    ///   <para>rdfs:label : cell in vivo^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#CellInVivo">biotop:CellInVivo</a>
    /// </summary>
    let CellInVivo = _prefixId.prefix "CellInVivo"
    /// <summary>
    ///   <para>ru:definition : Semipermeable lipid bilayer found in all cells.[1] It contains a wide variety of biological molecules, primarily proteins and lipids, which are involved in a vast array of cellular processes, and also serves as the attachment point for both the intracellular cytoskeleton and, if present, the cell wall.^^xsd:string</para>
    ///   <para>rdfs:label : cell membrane^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#CellMembrane">biotop:CellMembrane</a>
    /// </summary>
    let CellMembrane = _prefixId.prefix "CellMembrane"
    /// <summary>
    ///   <para>rdfs:label : cell nucleus^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#CellNucleus">biotop:CellNucleus</a>
    /// </summary>
    let CellNucleus = _prefixId.prefix "CellNucleus"
    /// <summary>
    ///   <para>ru:definition : Components which only can be formed inside living cells but which may survive their host cell.^^xsd:string</para>
    ///   <para>rdfs:label : cellular component^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#CellularComponent">biotop:CellularComponent</a>
    /// </summary>
    let CellularComponent = _prefixId.prefix "CellularComponent"
    /// <summary>
    ///   <para>ru:definition : the central control unit of an organism. Constitutes the brain in higher organisms. ^^xsd:string</para>
    ///   <para>rdfs:label : central nervous system^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#CentralNervousSystem">biotop:CentralNervousSystem</a>
    /// </summary>
    let CentralNervousSystem = _prefixId.prefix "CentralNervousSystem"
    /// <summary>
    ///   <para>rdfs:label : chain of carbohydrate monomers^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#ChainOfCarbohydrateMonomers">biotop:ChainOfCarbohydrateMonomers</a>
    /// </summary>
    let ChainOfCarbohydrateMonomers = _prefixId.prefix "ChainOfCarbohydrateMonomers"
    /// <summary>
    ///   <para>rdfs:label : chain of nucleotide monomers^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#ChainOfNucleotideMonomers">biotop:ChainOfNucleotideMonomers</a>
    /// </summary>
    let ChainOfNucleotideMonomers = _prefixId.prefix "ChainOfNucleotideMonomers"
    /// <summary>
    ///   <para>ru:definition : Any role performed by a chemical substance.^^xsd:string</para>
    ///   <para>rdfs:label : chemical role^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#ChemicalRole">biotop:ChemicalRole</a>
    /// </summary>
    let ChemicalRole = _prefixId.prefix "ChemicalRole"
    /// <summary>
    ///   <para>ru:definition : the role an organism plays in relation to its parent^^xsd:string</para>
    ///   <para>rdfs:label : child role^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#ChildRole">biotop:ChildRole</a>
    /// </summary>
    let ChildRole = _prefixId.prefix "ChildRole"
    /// <summary>
    ///   <para>rdfs:label : chlamydia cell^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#ChlamydiaCell">biotop:ChlamydiaCell</a>
    /// </summary>
    let ChlamydiaCell = _prefixId.prefix "ChlamydiaCell"
    /// <summary>
    ///   <para>ru:definition : Organized form of DNA in cells, containing one very long, continuous piece of DNA, which contains many genes, regulatory elements and other intervening nucleotide sequences. Includes also the DNA-bound proteins which serve to package and manage the DNA.^^xsd:string</para>
    ///   <para>rdfs:label : chromosome^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#Chromosome">biotop:Chromosome</a>
    /// </summary>
    let Chromosome = _prefixId.prefix "Chromosome"

    /// <summary>
    ///   <para>rdfs:label : class gamma proteobacteria value region^^xsd:string</para>
    ///   <para>rdfs:comment : EXAMPLE OF TAXON REGION^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#ClassGammaProteobacteriaValueRegion">biotop:ClassGammaProteobacteriaValueRegion</a>
    /// </summary>
    let ClassGammaProteobacteriaValueRegion =
        _prefixId.prefix "ClassGammaProteobacteriaValueRegion"

    /// <summary>
    ///   <para>rdfs:label : class insecta value region^^xsd:string</para>
    ///   <para>rdfs:comment : EXAMPLE OF TAXON REGION^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#ClassInsectaValueRegion">biotop:ClassInsectaValueRegion</a>
    /// </summary>
    let ClassInsectaValueRegion = _prefixId.prefix "ClassInsectaValueRegion"
    /// <summary>
    ///   <para>rdfs:label : class mammalia value region^^xsd:string</para>
    ///   <para>rdfs:comment : EXAMPLE OF TAXON REGION^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#ClassMammaliaValueRegion">biotop:ClassMammaliaValueRegion</a>
    /// </summary>
    let ClassMammaliaValueRegion = _prefixId.prefix "ClassMammaliaValueRegion"

    /// <summary>
    ///   <para>rdfs:label : class saccharomycetes value region^^xsd:string</para>
    ///   <para>rdfs:comment : EXAMPLE OF TAXON REGION^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#ClassSaccharomycetesValueRegion">biotop:ClassSaccharomycetesValueRegion</a>
    /// </summary>
    let ClassSaccharomycetesValueRegion =
        _prefixId.prefix "ClassSaccharomycetesValueRegion"

    /// <summary>
    ///   <para>ru:definition : Mereological Sum of multiple grains of the same sort without clear identity and unity criteria.
    /// Whether or not the grains are considered of the same sort depends on the view. Therefore this class does not really make a clear categorial distinction, because all matter can be described as a collection of atoms.
    /// As a consequence, these classes are not fully defined.
    ///  ^^xsd:string</para>
    ///   <para>rdfs:label : collective material entity^^xsd:string</para>
    ///   <para>rdfs:comment : The fuzzyness of this class is due to the "same sort" criterion.^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#CollectiveMaterialEntity">biotop:CollectiveMaterialEntity</a>
    /// </summary>
    let CollectiveMaterialEntity = _prefixId.prefix "CollectiveMaterialEntity"
    /// <summary>
    ///   <para>ru:definition : causes to become more severe^^xsd:string</para>
    ///   <para>rdfs:label : complicating^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#Complicating">biotop:Complicating</a>
    /// </summary>
    let Complicating = _prefixId.prefix "Complicating"

    /// <summary>
    ///   <para>ru:definition : Composition of different kinds of collections without clear unity and identity criteria.
    /// Old name: compound of collections.
    /// Practically all naturally occurring substances are of this sort. The different compounds are also called fractions^^xsd:string</para>
    ///   <para>rdfs:label : compound of collective material entities^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#CompoundOfCollectiveMaterialEntities">biotop:CompoundOfCollectiveMaterialEntities</a>
    /// </summary>
    let CompoundOfCollectiveMaterialEntities =
        _prefixId.prefix "CompoundOfCollectiveMaterialEntities"

    /// <summary>
    ///   <para>ru:definition : Union of material entity, process, or disposition. The rationale of this class is to represent the ambiguous nature of what is commonly referred to by health-related condition (not necessarily pathologic)^^xsd:string</para>
    ///   <para>rdfs:label : condition^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#Condition">biotop:Condition</a>
    /// </summary>
    let Condition = _prefixId.prefix "Condition"
    /// <summary>
    ///   <para>ru:definition : biological structure that deviates from what is considered normal and that already existed at birth^^xsd:string</para>
    ///   <para>rdfs:label : congenital abnormal structure^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#CongenitalAbnormalStructure">biotop:CongenitalAbnormalStructure</a>
    /// </summary>
    let CongenitalAbnormalStructure = _prefixId.prefix "CongenitalAbnormalStructure"

    /// <summary>
    ///   <para>ru:definition : Ill-formed state of a biological entity, present from birth [steschu 20071010]^^xsd:string</para>
    ///   <para>rdfs:label : congenital pathological condition^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#CongenitalPathologicalCondition">biotop:CongenitalPathologicalCondition</a>
    /// </summary>
    let CongenitalPathologicalCondition =
        _prefixId.prefix "CongenitalPathologicalCondition"

    /// <summary>
    ///   <para>owl:priorVersion : congenital pathological state^^xsd:string</para>
    ///   <para>ru:definition : pathological state present at birth^^xsd:string</para>
    ///   <para>rdfs:label : congenital pathological static processual entity^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#CongenitalPathologicalStaticProcessualEntity">biotop:CongenitalPathologicalStaticProcessualEntity</a>
    /// </summary>
    let CongenitalPathologicalStaticProcessualEntity =
        _prefixId.prefix "CongenitalPathologicalStaticProcessualEntity"

    /// <summary>
    ///   <para>ru:definition : Gelatinous, semi-transparent fluid that fills most cells. E^^xsd:string</para>
    ///   <para>rdfs:label : cytoplasm^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#Cytoplasm">biotop:Cytoplasm</a>
    /// </summary>
    let Cytoplasm = _prefixId.prefix "Cytoplasm"
    /// <summary>
    ///   <para>rdfs:comment : Place for currently non maintained classes. It should be assured that they are not being referred to by application ontologies that import BioTop^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#DEPRECATED">biotop:DEPRECATED</a>
    /// </summary>
    let DEPRECATED = _prefixId.prefix "DEPRECATED"
    let DEPRECATED_RELATION = _prefixId.prefix "DEPRECATED_RELATION"
    /// <summary>
    ///   <para>ru:definition : A DNA is a complex, high-molecular-weight biochemical macromolecule composed of deoxyribonumcleotide chains that convey genetic information. Any kind of NucleicAcid that is composed of Deoxyribonucleotides is here defined as DNA.^^xsd:string</para>
    ///   <para>rdfs:label : DNA chain^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#DNAChain">biotop:DNAChain</a>
    /// </summary>
    let DNAChain = _prefixId.prefix "DNAChain"
    /// <summary>
    ///   <para>ru:definition : body that is the transformation of a living body after death^^xsd:string</para>
    ///   <para>rdfs:label : dead body^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#DeadBody">biotop:DeadBody</a>
    /// </summary>
    let DeadBody = _prefixId.prefix "DeadBody"
    /// <summary>
    ///   <para>ru:definition : End of live of a biological system^^xsd:string</para>
    ///   <para>rdfs:label : death^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#Death">biotop:Death</a>
    /// </summary>
    let Death = _prefixId.prefix "Death"
    /// <summary>
    ///   <para>ru:definition : Ontogenetic stage^^xsd:string</para>
    ///   <para>rdfs:label : developmental quality^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#DevelopmentalQuality">biotop:DevelopmentalQuality</a>
    /// </summary>
    let DevelopmentalQuality = _prefixId.prefix "DevelopmentalQuality"
    /// <summary>
    ///   <para>ru:definition : abstract region in which the values of developmental stages are located^^xsd:string</para>
    ///   <para>rdfs:label : developmental value region^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#DevelopmentalValueRegion">biotop:DevelopmentalValueRegion</a>
    /// </summary>
    let DevelopmentalValueRegion = _prefixId.prefix "DevelopmentalValueRegion"
    /// <summary>
    ///   <para>ru:definition : any kind of information that is fully expressible by a sequence of binary values.^^xsd:string</para>
    ///   <para>rdfs:label : digital entity^^xsd:string</para>
    ///   <para>rdfs:comment : (OBI 306)^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#DigitalEntity">biotop:DigitalEntity</a>
    /// </summary>
    let DigitalEntity = _prefixId.prefix "DigitalEntity"
    /// <summary>
    ///   <para>ru:definition : A disposition is a realizable entity.
    /// Its manifestation is a process its bearer is involved in virtue of the bearer's physical make-up.^^xsd:string</para>
    ///   <para>rdfs:label : disposition^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#Disposition">biotop:Disposition</a>
    /// </summary>
    let Disposition = _prefixId.prefix "Disposition"
    /// <summary>
    ///   <para>ru:definition : Producing a negative effect on^^xsd:string</para>
    ///   <para>rdfs:label : disrupting^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#Disrupting">biotop:Disrupting</a>
    /// </summary>
    let Disrupting = _prefixId.prefix "Disrupting"
    /// <summary>
    ///   <para>ru:definition : The role of a chemical of biological entity of being deliberately used in virtue of its expected positive impact on a dysfunctional biological system^^xsd:string</para>
    ///   <para>rdfs:label : drug role^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#DrugRole">biotop:DrugRole</a>
    /// </summary>
    let DrugRole = _prefixId.prefix "DrugRole"
    /// <summary>
    ///   <para>ru:definition : The role a person plays that is occupied by educational activities^^xsd:string</para>
    ///   <para>rdfs:label : educator role^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#EducatorRole">biotop:EducatorRole</a>
    /// </summary>
    let EducatorRole = _prefixId.prefix "EducatorRole"
    /// <summary>
    ///   <para>ru:definition : An oxygenated metabolite from polyunsaturated 20 carbon fatty acids including lipoxygenase and cyclooxygenase products and their synthetic analogs. This includes the prostaglandins and thromboxanes. (UMLS SN)^^xsd:string</para>
    ///   <para>rdfs:label : eicosanoid^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#Eicosanoid">biotop:Eicosanoid</a>
    /// </summary>
    let Eicosanoid = _prefixId.prefix "Eicosanoid"
    /// <summary>
    ///   <para>ru:definition : Negatively Charged Particle^^xsd:string</para>
    ///   <para>rdfs:label : electron^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#Electron">biotop:Electron</a>
    /// </summary>
    let Electron = _prefixId.prefix "Electron"
    /// <summary>
    ///   <para>ru:definition : evolving organism before birth, with not yet fully formed organs^^xsd:string</para>
    ///   <para>rdfs:label : embryonic organism^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#EmbryonicOrganism">biotop:EmbryonicOrganism</a>
    /// </summary>
    let EmbryonicOrganism = _prefixId.prefix "EmbryonicOrganism"
    /// <summary>
    ///   <para>ru:definition : An embryo or any structure derived from it. There may be structures derived from an embryo that are no longer considered embryonic ones, hence no full definition.^^xsd:string</para>
    ///   <para>rdfs:label : embryonic structure^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#EmbryonicStructure">biotop:EmbryonicStructure</a>
    /// </summary>
    let EmbryonicStructure = _prefixId.prefix "EmbryonicStructure"
    /// <summary>
    ///   <para>rdfs:label : embryonic value region^^xsd:string</para>
    ///   <para>rdfs:comment : "embryonic" as the value of a developmental stage. E.g. a 3 days old mouse embryo has a quality which has its value located in "embryonic value region".^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#EmbryonicValueRegion">biotop:EmbryonicValueRegion</a>
    /// </summary>
    let EmbryonicValueRegion = _prefixId.prefix "EmbryonicValueRegion"
    /// <summary>
    ///   <para>rdfs:label : entire carbohydrate monomer^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#EntireCarbohydrateMonomer">biotop:EntireCarbohydrateMonomer</a>
    /// </summary>
    let EntireCarbohydrateMonomer = _prefixId.prefix "EntireCarbohydrateMonomer"
    /// <summary>
    ///   <para>ru:definition : Separately distinguishable molecular structure, neither part of nor attached to any other molecular structure. Atoms are not considered molecular structures. The hierarchy of entire entities mirrors the hierarchy of structures.^^xsd:string</para>
    ///   <para>rdfs:label : entire molecular entity^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#EntireMolecularEntity">biotop:EntireMolecularEntity</a>
    /// </summary>
    let EntireMolecularEntity = _prefixId.prefix "EntireMolecularEntity"
    /// <summary>
    ///   <para>rdfs:label : entire nucleic acid molecule^^xsd:string</para>
    ///   <para>rdfs:comment : not (properPartOf some MonoMolecularEntity)  REMOVED^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#EntireNucleicAcidMolecule">biotop:EntireNucleicAcidMolecule</a>
    /// </summary>
    let EntireNucleicAcidMolecule = _prefixId.prefix "EntireNucleicAcidMolecule"
    /// <summary>
    ///   <para>ru:definition : Amino Acid Polymer longer than 100 monomers.^^xsd:string</para>
    ///   <para>rdfs:label : entire protein molecule^^xsd:string</para>
    ///   <para>rdfs:comment : (QCR) Peptide and hasComponent min 101 AminoAcidMonomer and not (ro:properPartOf some MolecularEntity)^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#EntireProteinMolecule">biotop:EntireProteinMolecule</a>
    /// </summary>
    let EntireProteinMolecule = _prefixId.prefix "EntireProteinMolecule"
    /// <summary>
    ///   <para>rdfs:label : enzyme role^^xsd:string</para>
    ///   <para>rdfs:comment : The role a peptide plays in accelerating a biochemical reaction^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#EnzymeRole">biotop:EnzymeRole</a>
    /// </summary>
    let EnzymeRole = _prefixId.prefix "EnzymeRole"
    /// <summary>
    ///   <para>rdfs:label : epithelial cell^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#EpithelialCell">biotop:EpithelialCell</a>
    /// </summary>
    let EpithelialCell = _prefixId.prefix "EpithelialCell"
    /// <summary>
    ///   <para>rdfs:label : escherichia coli cell^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#EscherichiaColiCell">biotop:EscherichiaColiCell</a>
    /// </summary>
    let EscherichiaColiCell = _prefixId.prefix "EscherichiaColiCell"
    /// <summary>
    ///   <para>rdfs:label : escherichia coli population^^xsd:string</para>
    ///   <para>rdfs:comment : EXAMPLE OF POPULATION^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#EscherichiaColiPopulation">biotop:EscherichiaColiPopulation</a>
    /// </summary>
    let EscherichiaColiPopulation = _prefixId.prefix "EscherichiaColiPopulation"
    /// <summary>
    ///   <para>ru:definition : An eukaryote is an organism with a complex cell or cells, in which the genetic material is organized into a membrane-bound nucleus or nuclei. Most Eukaryots are multicellular, haowever, there are some which are always unicellular (protists, some fungi) but there are also unicellular developmental stages (zygotes) of plants and animals.^^xsd:string</para>
    ///   <para>rdfs:label : eukaryote^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#Eukaryote">biotop:Eukaryote</a>
    /// </summary>
    let Eukaryote = _prefixId.prefix "Eukaryote"
    /// <summary>
    ///   <para>rdfs:label : eukaryote population^^xsd:string</para>
    ///   <para>rdfs:comment : EXAMPLE OF POPULATION^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#EukaryotePopulation">biotop:EukaryotePopulation</a>
    /// </summary>
    let EukaryotePopulation = _prefixId.prefix "EukaryotePopulation"
    let Event = _prefixId.prefix "Event"
    /// <summary>
    ///   <para>ru:definition : The role a measurement plays if it has been produced in the context of the quantitative assessment of a biological system^^xsd:string</para>
    ///   <para>rdfs:label : examination result role^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#ExaminationResultRole">biotop:ExaminationResultRole</a>
    /// </summary>
    let ExaminationResultRole = _prefixId.prefix "ExaminationResultRole"

    /// <summary>
    ///   <para>rdfs:label : family drosophilidae value region^^xsd:string</para>
    ///   <para>rdfs:comment : EXAMPLE OF TAXON REGION^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#FamilyDrosophilidaeValueRegion">biotop:FamilyDrosophilidaeValueRegion</a>
    /// </summary>
    let FamilyDrosophilidaeValueRegion =
        _prefixId.prefix "FamilyDrosophilidaeValueRegion"

    /// <summary>
    ///   <para>rdfs:label : family enterobacteriaceaea value region^^xsd:string</para>
    ///   <para>rdfs:comment : EXAMPLE OF TAXON REGION^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#FamilyEnterobacteriaceaeaValueRegion">biotop:FamilyEnterobacteriaceaeaValueRegion</a>
    /// </summary>
    let FamilyEnterobacteriaceaeaValueRegion =
        _prefixId.prefix "FamilyEnterobacteriaceaeaValueRegion"

    /// <summary>
    ///   <para>rdfs:label : family hominidae value region^^xsd:string</para>
    ///   <para>rdfs:comment : EXAMPLE OF TAXON REGION^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#FamilyHominidaeValueRegion">biotop:FamilyHominidaeValueRegion</a>
    /// </summary>
    let FamilyHominidaeValueRegion = _prefixId.prefix "FamilyHominidaeValueRegion"
    /// <summary>
    ///   <para>rdfs:label : family of individual organisms^^xsd:string</para>
    ///   <para>rdfs:comment : unclear classe. to be revised^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#FamilyOfIndividualOrganisms">biotop:FamilyOfIndividualOrganisms</a>
    /// </summary>
    let FamilyOfIndividualOrganisms = _prefixId.prefix "FamilyOfIndividualOrganisms"
    /// <summary>
    ///   <para>rdfs:label : family role^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#FamilyRole">biotop:FamilyRole</a>
    /// </summary>
    let FamilyRole = _prefixId.prefix "FamilyRole"

    /// <summary>
    ///   <para>rdfs:label : family saccharomycetaceae value region^^xsd:string</para>
    ///   <para>rdfs:comment : EXAMPLE OF TAXON REGION^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#FamilySaccharomycetaceaeValueRegion">biotop:FamilySaccharomycetaceaeValueRegion</a>
    /// </summary>
    let FamilySaccharomycetaceaeValueRegion =
        _prefixId.prefix "FamilySaccharomycetaceaeValueRegion"

    /// <summary>
    ///   <para>ru:definition : Carboxylic acid often with a long unbranched aliphatic tail.^^xsd:string</para>
    ///   <para>rdfs:label : fatty acid molecule or residue^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#FattyAcidMoleculeOrResidue">biotop:FattyAcidMoleculeOrResidue</a>
    /// </summary>
    let FattyAcidMoleculeOrResidue = _prefixId.prefix "FattyAcidMoleculeOrResidue"
    /// <summary>
    ///   <para>ru:definition : The role that may inhere in any biological structure, state, or process that is of reportable interest in a diagnostic process.^^xsd:string</para>
    ///   <para>rdfs:label : finding role^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#FindingRole">biotop:FindingRole</a>
    /// </summary>
    let FindingRole = _prefixId.prefix "FindingRole"
    /// <summary>
    ///   <para>rdfs:label : fish^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#Fish">biotop:Fish</a>
    /// </summary>
    let Fish = _prefixId.prefix "Fish"
    /// <summary>
    ///   <para>ru:definition : The role of an entity components of which are used for supplying energy and vital substrates to a biological system^^xsd:string</para>
    ///   <para>rdfs:label : food role^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#FoodRole">biotop:FoodRole</a>
    /// </summary>
    let FoodRole = _prefixId.prefix "FoodRole"
    /// <summary>
    ///   <para>rdfs:label : fruit fly^^xsd:string</para>
    ///   <para>rdfs:comment : one drosophila melanogaster^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#FruitFly">biotop:FruitFly</a>
    /// </summary>
    let FruitFly = _prefixId.prefix "FruitFly"
    /// <summary>
    ///   <para>rdfs:label : fruit fly population^^xsd:string</para>
    ///   <para>rdfs:comment : EXAMPLE OF POPULATION^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#FruitFlyPopulation">biotop:FruitFlyPopulation</a>
    /// </summary>
    let FruitFlyPopulation = _prefixId.prefix "FruitFlyPopulation"
    /// <summary>
    ///   <para>ru:definition : A classical definition of function according to Wright is that the function F of X is Z means that X is there because it Zs, and Z is a consequence of X being there.
    ///
    /// For artefacts, functions are distinguished from dispositions by the purpose they have been built. For example, a hammer has the function to drive in nails, but not to be used as a weapon. However, it has the disposition to be used as a weapon under certain circumstances.
    ///
    /// For biological objects, which developed by evolution, the definition of function is still subject to controversy (e.g. Barry Smith's view of function as pertaining to a canonical life plan, cf.
    /// http://www.slideserve.com/presentation/103450/The-Canonical-Life).
    ///
    /// In BFO "Disposition" and "Function" are siblings, in BioTop Function is more specific.
    ///  ^^xsd:string</para>
    ///   <para>rdfs:label : function^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#Function">biotop:Function</a>
    /// </summary>
    let Function = _prefixId.prefix "Function"
    /// <summary>
    ///   <para>ru:definition : Heterotrophic organisms characterized by a chitinous cell wall.^^xsd:string</para>
    ///   <para>rdfs:label : fungus^^xsd:string</para>
    ///   <para>rdfs:comment : On fungus organisms^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#Fungus">biotop:Fungus</a>
    /// </summary>
    let Fungus = _prefixId.prefix "Fungus"
    /// <summary>
    ///   <para>rdfs:label : fungus population^^xsd:string</para>
    ///   <para>rdfs:comment : EXAMPLE OF POPULATION^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#FungusPopulation">biotop:FungusPopulation</a>
    /// </summary>
    let FungusPopulation = _prefixId.prefix "FungusPopulation"
    /// <summary>
    ///   <para>rdfs:label : gaseous value region^^xsd:string</para>
    ///   <para>rdfs:comment : "gaseous" as the value of a states of matter.  E.g. a portion of air has a quality which has its value located in "gaseous value region"^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#GaseousValueRegion">biotop:GaseousValueRegion</a>
    /// </summary>
    let GaseousValueRegion = _prefixId.prefix "GaseousValueRegion"
    /// <summary>
    ///   <para>owl:versionInfo : TODO: Discuss whether all genes are DNA !^^xsd:string</para>
    ///   <para>ru:definition : region of nucleic acid macromolecule that carry information^^xsd:string</para>
    ///   <para>rdfs:label : gene^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#Gene">biotop:Gene</a>
    /// </summary>
    let Gene = _prefixId.prefix "Gene"
    /// <summary>
    ///   <para>ru:definition : Information that resides on a gene.^^xsd:string</para>
    ///   <para>rdfs:label : gene information^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#GeneInformation">biotop:GeneInformation</a>
    /// </summary>
    let GeneInformation = _prefixId.prefix "GeneInformation"
    /// <summary>
    ///   <para>ru:definition : part of a gene^^xsd:string</para>
    ///   <para>rdfs:label : gene region^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#GeneRegion">biotop:GeneRegion</a>
    /// </summary>
    let GeneRegion = _prefixId.prefix "GeneRegion"
    /// <summary>
    ///   <para>ru:definition : information that can be interpreted by a genetic code^^xsd:string</para>
    ///   <para>rdfs:label : genetic information^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#GeneticInformation">biotop:GeneticInformation</a>
    /// </summary>
    let GeneticInformation = _prefixId.prefix "GeneticInformation"
    /// <summary>
    ///   <para>rdfs:label : genome^^xsd:string</para>
    ///   <para>rdfs:comment : sum of genetic material in a cell^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#Genome">biotop:Genome</a>
    /// </summary>
    let Genome = _prefixId.prefix "Genome"
    /// <summary>
    ///   <para>ru:definition : The totality of hereditary information of an organism^^xsd:string</para>
    ///   <para>rdfs:label : genome information^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#GenomeInformation">biotop:GenomeInformation</a>
    /// </summary>
    let GenomeInformation = _prefixId.prefix "GenomeInformation"
    /// <summary>
    ///   <para>rdfs:label : genus candida value region^^xsd:string</para>
    ///   <para>rdfs:comment : EXAMPLE OF TAXON REGION^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#GenusCandidaValueRegion">biotop:GenusCandidaValueRegion</a>
    /// </summary>
    let GenusCandidaValueRegion = _prefixId.prefix "GenusCandidaValueRegion"
    /// <summary>
    ///   <para>rdfs:label : genus drosophila value region^^xsd:string</para>
    ///   <para>rdfs:comment : EXAMPLE OF TAXON REGION^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#GenusDrosophilaValueRegion">biotop:GenusDrosophilaValueRegion</a>
    /// </summary>
    let GenusDrosophilaValueRegion = _prefixId.prefix "GenusDrosophilaValueRegion"
    /// <summary>
    ///   <para>rdfs:label : genus escherichia value region^^xsd:string</para>
    ///   <para>rdfs:comment : EXAMPLE OF TAXON REGION^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#GenusEscherichiaValueRegion">biotop:GenusEscherichiaValueRegion</a>
    /// </summary>
    let GenusEscherichiaValueRegion = _prefixId.prefix "GenusEscherichiaValueRegion"
    /// <summary>
    ///   <para>rdfs:label : genus homo value region^^xsd:string</para>
    ///   <para>rdfs:comment : EXAMPLE OF TAXON REGION^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#GenusHomoValueRegion">biotop:GenusHomoValueRegion</a>
    /// </summary>
    let GenusHomoValueRegion = _prefixId.prefix "GenusHomoValueRegion"
    /// <summary>
    ///   <para>rdfs:label : genus saccharomyces value region^^xsd:string</para>
    ///   <para>rdfs:comment : EXAMPLE OF TAXON REGION^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#GenusSaccharomycesValueRegion">biotop:GenusSaccharomycesValueRegion</a>
    /// </summary>
    let GenusSaccharomycesValueRegion = _prefixId.prefix "GenusSaccharomycesValueRegion"
    /// <summary>
    ///   <para>ru:definition : delineated surface of a large solid body in space (earth, moon, sun,...)^^xsd:string</para>
    ///   <para>rdfs:label : geographic surface^^xsd:string</para>
    ///   <para>rdfs:comment : previous name "geographic entity"^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#GeographicSurface">biotop:GeographicSurface</a>
    /// </summary>
    let GeographicSurface = _prefixId.prefix "GeographicSurface"
    /// <summary>
    ///   <para>ru:definition : entity governing a defined group of people^^xsd:string</para>
    ///   <para>rdfs:label : government^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#Government">biotop:Government</a>
    /// </summary>
    let Government = _prefixId.prefix "Government"
    /// <summary>
    ///   <para>rdfs:label : great ape^^xsd:string</para>
    ///   <para>rdfs:comment : one great ape^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#GreatApe">biotop:GreatApe</a>
    /// </summary>
    let GreatApe = _prefixId.prefix "GreatApe"
    /// <summary>
    ///   <para>rdfs:label : great ape population^^xsd:string</para>
    ///   <para>rdfs:comment : EXAMPLE OF POPULATION^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#GreatApePopulation">biotop:GreatApePopulation</a>
    /// </summary>
    let GreatApePopulation = _prefixId.prefix "GreatApePopulation"
    /// <summary>
    ///   <para>ru:definition : action in which physical or legal groups interact^^xsd:string</para>
    ///   <para>rdfs:label : group interaction^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#GroupInteraction">biotop:GroupInteraction</a>
    /// </summary>
    let GroupInteraction = _prefixId.prefix "GroupInteraction"
    /// <summary>
    ///   <para>rdfs:label : growing process^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#GrowingProcess">biotop:GrowingProcess</a>
    /// </summary>
    let GrowingProcess = _prefixId.prefix "GrowingProcess"
    /// <summary>
    ///   <para>ru:definition : the role a human plays as active part in a health system^^xsd:string</para>
    ///   <para>rdfs:label : health professional role^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#HealthProfessionalRole">biotop:HealthProfessionalRole</a>
    /// </summary>
    let HealthProfessionalRole = _prefixId.prefix "HealthProfessionalRole"
    /// <summary>
    ///   <para>ru:definition : A role an entity plays as an actor or participant in processes that assess or influence the health status of an organism.^^xsd:string</para>
    ///   <para>rdfs:label : health related role^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#HealthRelatedRole">biotop:HealthRelatedRole</a>
    /// </summary>
    let HealthRelatedRole = _prefixId.prefix "HealthRelatedRole"

    /// <summary>
    ///   <para>ru:definition : Organic compounds that contain a ring structure containing N as proton receptor. Important parts of DNA and RNA molecules.^^xsd:string</para>
    ///   <para>rdfs:label : heterocyclic base molecule or residue^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#HeterocyclicBaseMoleculeOrResidue">biotop:HeterocyclicBaseMoleculeOrResidue</a>
    /// </summary>
    let HeterocyclicBaseMoleculeOrResidue =
        _prefixId.prefix "HeterocyclicBaseMoleculeOrResidue"

    /// <summary>
    ///   <para>ru:definition : The role a biologically active substance plays when it participates in the transmission of messages across a certain distance in an organism.^^xsd:string</para>
    ///   <para>rdfs:label : hormone role^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#HormoneRole">biotop:HormoneRole</a>
    /// </summary>
    let HormoneRole = _prefixId.prefix "HormoneRole"
    /// <summary>
    ///   <para>rdfs:label : human^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#Human">biotop:Human</a>
    /// </summary>
    let Human = _prefixId.prefix "Human"
    /// <summary>
    ///   <para>ru:definition : Action that has some human as agent^^xsd:string</para>
    ///   <para>rdfs:label : human action^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#HumanAction">biotop:HumanAction</a>
    /// </summary>
    let HumanAction = _prefixId.prefix "HumanAction"
    /// <summary>
    ///   <para>rdfs:label : human epithelial cell^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#HumanEpithelialCell">biotop:HumanEpithelialCell</a>
    /// </summary>
    let HumanEpithelialCell = _prefixId.prefix "HumanEpithelialCell"
    /// <summary>
    ///   <para>ru:definition : language used in communication between non-human animals^^xsd:string</para>
    ///   <para>rdfs:label : human language^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#HumanLanguage">biotop:HumanLanguage</a>
    /// </summary>
    let HumanLanguage = _prefixId.prefix "HumanLanguage"
    /// <summary>
    ///   <para>rdfs:label : human population^^xsd:string</para>
    ///   <para>rdfs:comment : EXAMPLE OF POPULATION^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#HumanPopulation">biotop:HumanPopulation</a>
    /// </summary>
    let HumanPopulation = _prefixId.prefix "HumanPopulation"
    /// <summary>
    ///   <para>ru:definition : Process in which a human creates an intellectual product^^xsd:string</para>
    ///   <para>rdfs:label : human reasoning^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#HumanReasoning">biotop:HumanReasoning</a>
    /// </summary>
    let HumanReasoning = _prefixId.prefix "HumanReasoning"
    /// <summary>
    ///   <para>rdfs:label : hurting^^xsd:string</para>
    ///   <para>rdfs:comment : negatively affecting a biological system by using physical force^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#Hurting">biotop:Hurting</a>
    /// </summary>
    let Hurting = _prefixId.prefix "Hurting"
    /// <summary>
    ///   <para>ru:definition : Continuant entity that has neither a mass nor a volume and which do not inhere in other entities.^^xsd:string</para>
    ///   <para>rdfs:label : immaterial nonphysical entity^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#ImmaterialNonphysicalEntity">biotop:ImmaterialNonphysicalEntity</a>
    /// </summary>
    let ImmaterialNonphysicalEntity = _prefixId.prefix "ImmaterialNonphysicalEntity"
    /// <summary>
    ///   <para>owl:priorVersion : immaterial physical entity^^xsd:string</para>
    ///   <para>ru:definition : Physical spaces that have a threedimensional spatial dimension but no mass.
    /// Old name: immaterial anatomical entity^^xsd:string</para>
    ///   <para>rdfs:label : immaterial object^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#ImmaterialObject">biotop:ImmaterialObject</a>
    /// </summary>
    let ImmaterialObject = _prefixId.prefix "ImmaterialObject"
    let ImmaterialPhysicalEntity = _prefixId.prefix "ImmaterialPhysicalEntity"
    /// <summary>
    ///   <para>ru:definition : A process with non-material participants, e.g. legal or organizational entities or information objects^^xsd:string</para>
    ///   <para>rdfs:label : immaterial processual entity^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#ImmaterialProcessualEntity">biotop:ImmaterialProcessualEntity</a>
    /// </summary>
    let ImmaterialProcessualEntity = _prefixId.prefix "ImmaterialProcessualEntity"

    /// <summary>
    ///   <para>ru:definition : three-dimensional space^^xsd:string</para>
    ///   <para>rdfs:label : immaterial three dimensional physical entity^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#ImmaterialThreeDimensionalPhysicalEntity">biotop:ImmaterialThreeDimensionalPhysicalEntity</a>
    /// </summary>
    let ImmaterialThreeDimensionalPhysicalEntity =
        _prefixId.prefix "ImmaterialThreeDimensionalPhysicalEntity"

    /// <summary>
    ///   <para>ru:definition : A role that is played by any biological entity in virtue of the defense of an organism against infective agents^^xsd:string</para>
    ///   <para>rdfs:label : immunologic role^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#ImmunologicRole">biotop:ImmunologicRole</a>
    /// </summary>
    let ImmunologicRole = _prefixId.prefix "ImmunologicRole"
    /// <summary>
    ///   <para>ru:definition : action that indicates something^^xsd:string</para>
    ///   <para>rdfs:label : indicating^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#Indicating">biotop:Indicating</a>
    /// </summary>
    let Indicating = _prefixId.prefix "Indicating"
    /// <summary>
    ///   <para>ru:definition : A role a chemical plays for measuring or analyzing other chemical processes^^xsd:string</para>
    ///   <para>rdfs:label : indicator role^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#IndicatorRole">biotop:IndicatorRole</a>
    /// </summary>
    let IndicatorRole = _prefixId.prefix "IndicatorRole"
    /// <summary>
    ///   <para>ru:definition : Behavior of an individual organism^^xsd:string</para>
    ///   <para>rdfs:label : individual behavior^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#IndividualBehavior">biotop:IndividualBehavior</a>
    /// </summary>
    let IndividualBehavior = _prefixId.prefix "IndividualBehavior"
    let InformationEntity = _prefixId.prefix "InformationEntity"
    /// <summary>
    ///   <para>owl:priorVersion : information entity^^xsd:string</para>
    ///   <para>ru:definition : Piece of information (not necessarily human) , as it exists independently of any potential material carrier.^^xsd:string</para>
    ///   <para>rdfs:label : information object^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#InformationObject">biotop:InformationObject</a>
    /// </summary>
    let InformationObject = _prefixId.prefix "InformationObject"
    /// <summary>
    ///   <para>ru:definition : Substances which do not include carbon and its derivatives as their principal elements. However, carbides, carbonates, cyanides, cyanates and carbon disulfide are included in this class.^^xsd:string</para>
    ///   <para>rdfs:label : inorganic molecular entity^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#InorganicMolecularEntity">biotop:InorganicMolecularEntity</a>
    /// </summary>
    let InorganicMolecularEntity = _prefixId.prefix "InorganicMolecularEntity"
    /// <summary>
    ///   <para>ru:definition : one insect^^xsd:string</para>
    ///   <para>rdfs:label : insect^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#Insect">biotop:Insect</a>
    /// </summary>
    let Insect = _prefixId.prefix "Insect"
    /// <summary>
    ///   <para>rdfs:label : insect population^^xsd:string</para>
    ///   <para>rdfs:comment : EXAMPLE OF POPULATION^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#InsectPopulation">biotop:InsectPopulation</a>
    /// </summary>
    let InsectPopulation = _prefixId.prefix "InsectPopulation"
    /// <summary>
    ///   <para>ru:definition : What happens at one point in time, typically a process boundary.
    /// Name "event" deprecated
    /// ^^xsd:string</para>
    ///   <para>rdfs:label : instantaneous process^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#InstantaneousProcess">biotop:InstantaneousProcess</a>
    /// </summary>
    let InstantaneousProcess = _prefixId.prefix "InstantaneousProcess"
    /// <summary>
    ///   <para>ru:definition : An intellectual product is a piece of information that is the outcome of a human reasoning process^^xsd:string</para>
    ///   <para>rdfs:label : intellectual product^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#IntellectualProduct">biotop:IntellectualProduct</a>
    /// </summary>
    let IntellectualProduct = _prefixId.prefix "IntellectualProduct"
    /// <summary>
    ///   <para>ru:definition : two or more interaction partners exerce a mutual effect that may lead to structural transformation.^^xsd:string</para>
    ///   <para>rdfs:label : interacting^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#Interacting">biotop:Interacting</a>
    /// </summary>
    let Interacting = _prefixId.prefix "Interacting"
    /// <summary>
    ///   <para>ru:definition : Process occuring in a cell.^^xsd:string</para>
    ///   <para>rdfs:label : intra cellular process^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#IntraCellularProcess">biotop:IntraCellularProcess</a>
    /// </summary>
    let IntraCellularProcess = _prefixId.prefix "IntraCellularProcess"
    /// <summary>
    ///   <para>rdfs:label : invertebrate^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#Invertebrate">biotop:Invertebrate</a>
    /// </summary>
    let Invertebrate = _prefixId.prefix "Invertebrate"
    /// <summary>
    ///   <para>ru:definition : born organism, not yet in reproductive age^^xsd:string</para>
    ///   <para>rdfs:label : juvenile organism^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#JuvenileOrganism">biotop:JuvenileOrganism</a>
    /// </summary>
    let JuvenileOrganism = _prefixId.prefix "JuvenileOrganism"
    /// <summary>
    ///   <para>rdfs:label : juvenile value region^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#JuvenileValueRegion">biotop:JuvenileValueRegion</a>
    /// </summary>
    let JuvenileValueRegion = _prefixId.prefix "JuvenileValueRegion"
    /// <summary>
    ///   <para>rdfs:label : kingdom animalia value region^^xsd:string</para>
    ///   <para>rdfs:comment : EXAMPLE OF TAXON REGION^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#KingdomAnimaliaValueRegion">biotop:KingdomAnimaliaValueRegion</a>
    /// </summary>
    let KingdomAnimaliaValueRegion = _prefixId.prefix "KingdomAnimaliaValueRegion"
    /// <summary>
    ///   <para>rdfs:label : kingdom archaea value region^^xsd:string</para>
    ///   <para>rdfs:comment : EXAMPLE OF TAXON REGION^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#KingdomArchaeaValueRegion">biotop:KingdomArchaeaValueRegion</a>
    /// </summary>
    let KingdomArchaeaValueRegion = _prefixId.prefix "KingdomArchaeaValueRegion"
    /// <summary>
    ///   <para>rdfs:label : kingdom bacteria value region^^xsd:string</para>
    ///   <para>rdfs:comment : EXAMPLE OF TAXON REGION^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#KingdomBacteriaValueRegion">biotop:KingdomBacteriaValueRegion</a>
    /// </summary>
    let KingdomBacteriaValueRegion = _prefixId.prefix "KingdomBacteriaValueRegion"
    /// <summary>
    ///   <para>rdfs:label : kingdom chromista value region^^xsd:string</para>
    ///   <para>rdfs:comment : EXAMPLE OF TAXON REGION^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#KingdomChromistaValueRegion">biotop:KingdomChromistaValueRegion</a>
    /// </summary>
    let KingdomChromistaValueRegion = _prefixId.prefix "KingdomChromistaValueRegion"
    /// <summary>
    ///   <para>rdfs:label : kingdom fungi value region^^xsd:string</para>
    ///   <para>rdfs:comment : EXAMPLE OF TAXON REGION^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#KingdomFungiValueRegion">biotop:KingdomFungiValueRegion</a>
    /// </summary>
    let KingdomFungiValueRegion = _prefixId.prefix "KingdomFungiValueRegion"
    /// <summary>
    ///   <para>rdfs:label : kingdom plantae value region^^xsd:string</para>
    ///   <para>rdfs:comment : EXAMPLE OF TAXON REGION^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#KingdomPlantaeValueRegion">biotop:KingdomPlantaeValueRegion</a>
    /// </summary>
    let KingdomPlantaeValueRegion = _prefixId.prefix "KingdomPlantaeValueRegion"
    /// <summary>
    ///   <para>rdfs:label : kingdom protozoa value region^^xsd:string</para>
    ///   <para>rdfs:comment : EXAMPLE OF TAXON REGION^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#KingdomProtozoaValueRegion">biotop:KingdomProtozoaValueRegion</a>
    /// </summary>
    let KingdomProtozoaValueRegion = _prefixId.prefix "KingdomProtozoaValueRegion"
    /// <summary>
    ///   <para>rdfs:label : kingdom viruses value region^^xsd:string</para>
    ///   <para>rdfs:comment : EXAMPLE OF TAXON REGION^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#KingdomVirusesValueRegion">biotop:KingdomVirusesValueRegion</a>
    /// </summary>
    let KingdomVirusesValueRegion = _prefixId.prefix "KingdomVirusesValueRegion"
    /// <summary>
    ///   <para>ru:definition : system of signs used for communication between biological and / or machine agents^^xsd:string</para>
    ///   <para>rdfs:label : language^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#Language">biotop:Language</a>
    /// </summary>
    let Language = _prefixId.prefix "Language"
    /// <summary>
    ///   <para>ru:definition : Ontologically irrelevant partitioning node. Used for improving ontology housekeeping. Its purpose is to express that all subclasses are mutually disjoint.^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#LanguagePartition">biotop:LanguagePartition</a>
    /// </summary>
    let LanguagePartition = _prefixId.prefix "LanguagePartition"
    /// <summary>
    ///   <para>ru:definition : nonmaterial entity that as an existence in a legal system^^xsd:string</para>
    ///   <para>rdfs:label : legal entity^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#LegalEntity">biotop:LegalEntity</a>
    /// </summary>
    let LegalEntity = _prefixId.prefix "LegalEntity"
    /// <summary>
    ///   <para>ru:definition : Fat-soluble (lipophilic), naturally-occurring molecule.^^xsd:string</para>
    ///   <para>rdfs:label : lipid molecule or residue^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#LipidMoleculeOrResidue">biotop:LipidMoleculeOrResidue</a>
    /// </summary>
    let LipidMoleculeOrResidue = _prefixId.prefix "LipidMoleculeOrResidue"
    /// <summary>
    ///   <para>rdfs:label : liquid value region^^xsd:string</para>
    ///   <para>rdfs:comment : "liquid" as the value of a states of matter. E.g. a portion of water has a quality which has its value located in "liquid value region"^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#LiquidValueRegion">biotop:LiquidValueRegion</a>
    /// </summary>
    let LiquidValueRegion = _prefixId.prefix "LiquidValueRegion"
    /// <summary>
    ///   <para>ru:definition : Entirety of the biological structure that constitutes a living organism^^xsd:string</para>
    ///   <para>rdfs:label : living body^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#LivingBody">biotop:LivingBody</a>
    /// </summary>
    let LivingBody = _prefixId.prefix "LivingBody"
    /// <summary>
    ///   <para>owl:priorVersion : organism^^xsd:string</para>
    ///   <para>ru:definition : Living complex biological system which functions as a stable whole. In contrast to colonial organisms their components generally cannot survive on their own. We conceive organisms in a material sense. Therefore we do not assume any ontological difference between a unicellular organism and the cell it is made of. "Colonial Organism" are not considered Organisms. We here include viruses into the category of organisms.
    ///
    /// Organism in an inactive form which are not dead are considered living organisms.
    ///
    /// Whether a living organism coincides with its body or hasPart its body, is controversial. We use "hasPhysicalPart" for relating organism to body. Being reflexive, this would not be incompatible with a view in which a living organism is a body.^^xsd:string</para>
    ///   <para>rdfs:label : living organism^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#LivingOrganism">biotop:LivingOrganism</a>
    /// </summary>
    let LivingOrganism = _prefixId.prefix "LivingOrganism"
    /// <summary>
    ///   <para>ru:definition : An action performed by a machine. A machine is here seen as a non-biological artifact.^^xsd:string</para>
    ///   <para>rdfs:label : machine action^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#MachineAction">biotop:MachineAction</a>
    /// </summary>
    let MachineAction = _prefixId.prefix "MachineAction"
    /// <summary>
    ///   <para>ru:definition : language used for processing by machines^^xsd:string</para>
    ///   <para>rdfs:label : machine language^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#MachineLanguage">biotop:MachineLanguage</a>
    /// </summary>
    let MachineLanguage = _prefixId.prefix "MachineLanguage"
    /// <summary>
    ///   <para>ru:definition : size values of objects that are visible to the naked eye^^xsd:string</para>
    ///   <para>rdfs:label : macroscopic value region^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#MacroscopicValueRegion">biotop:MacroscopicValueRegion</a>
    /// </summary>
    let MacroscopicValueRegion = _prefixId.prefix "MacroscopicValueRegion"
    /// <summary>
    ///   <para>rdfs:label : mammal^^xsd:string</para>
    ///   <para>rdfs:comment : one mammal^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#Mammal">biotop:Mammal</a>
    /// </summary>
    let Mammal = _prefixId.prefix "Mammal"
    /// <summary>
    ///   <para>rdfs:label : mammal population^^xsd:string</para>
    ///   <para>rdfs:comment : EXAMPLE OF POPULATION^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#MammalPopulation">biotop:MammalPopulation</a>
    /// </summary>
    let MammalPopulation = _prefixId.prefix "MammalPopulation"
    /// <summary>
    ///   <para>ru:definition : action in which a subject cares for the well-being of some biological entity^^xsd:string</para>
    ///   <para>rdfs:label : managing care^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#ManagingCare">biotop:ManagingCare</a>
    /// </summary>
    let ManagingCare = _prefixId.prefix "ManagingCare"
    let MaterialEntity = _prefixId.prefix "MaterialEntity"
    /// <summary>
    ///   <para>rdfs:label : *^^xsd:string</para>
    ///   <para>rdfs:comment : MaterialEntityBySizePartition
    ///
    /// Ontologically irrelevant partitioning node. Used for improving ontology housekeeping. Its purpose is to express that all subclasses are mutually disjoint.^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#MaterialEntityBySizePartition">biotop:MaterialEntityBySizePartition</a>
    /// </summary>
    let MaterialEntityBySizePartition = _prefixId.prefix "MaterialEntityBySizePartition"
    /// <summary>
    ///   <para>owl:priorVersion : material entity^^xsd:string</para>
    ///   <para>ru:definition : A material object that has exactly one mass and one volume at a time.  Material objects may have Immaterial nonphysical entities as parts (e.g. Heart and Heart Ventricle). ^^xsd:string</para>
    ///   <para>rdfs:label : material object^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#MaterialObject">biotop:MaterialObject</a>
    /// </summary>
    let MaterialObject = _prefixId.prefix "MaterialObject"
    /// <summary>
    ///   <para>ru:definition : Numeric quantity or cardinality, reference for measurement processes. Example kilogram, hour, ampere.^^xsd:string</para>
    ///   <para>rdfs:label : measure^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#Measure">biotop:Measure</a>
    /// </summary>
    let Measure = _prefixId.prefix "Measure"
    /// <summary>
    ///   <para>ru:definition : Plan that is realized by a measurement process.^^xsd:string</para>
    ///   <para>rdfs:label : measurement method^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#MeasurementMethod">biotop:MeasurementMethod</a>
    /// </summary>
    let MeasurementMethod = _prefixId.prefix "MeasurementMethod"
    /// <summary>
    ///   <para>ru:definition : an action that aims at producing a measurement^^xsd:string</para>
    ///   <para>rdfs:label : measuring action^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#MeasuringAction">biotop:MeasuringAction</a>
    /// </summary>
    let MeasuringAction = _prefixId.prefix "MeasuringAction"
    /// <summary>
    ///   <para>ru:definition : Process that endures while something or some person is part of a legal entity^^xsd:string</para>
    ///   <para>rdfs:label : membership^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#Membership">biotop:Membership</a>
    /// </summary>
    let Membership = _prefixId.prefix "Membership"
    /// <summary>
    ///   <para>ru:definition : biological function ascribed to the behavioral manisfestations of the brain^^xsd:string</para>
    ///   <para>rdfs:label : mental function^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#MentalFunction">biotop:MentalFunction</a>
    /// </summary>
    let MentalFunction = _prefixId.prefix "MentalFunction"
    /// <summary>
    ///   <para>rdfs:label : mental process^^xsd:string</para>
    ///   <para>rdfs:comment : process in an organism as a realization of a mental function^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#MentalProcess">biotop:MentalProcess</a>
    /// </summary>
    let MentalProcess = _prefixId.prefix "MentalProcess"
    /// <summary>
    ///   <para>ru:definition : organism that can be seen only through a microscope^^xsd:string</para>
    ///   <para>rdfs:label : microorganism^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#Microorganism">biotop:Microorganism</a>
    /// </summary>
    let Microorganism = _prefixId.prefix "Microorganism"
    /// <summary>
    ///   <para>ru:definition : size values of objects that are too small to be seen without a microscope^^xsd:string</para>
    ///   <para>rdfs:label : microscopic value region^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#MicroscopicValueRegion">biotop:MicroscopicValueRegion</a>
    /// </summary>
    let MicroscopicValueRegion = _prefixId.prefix "MicroscopicValueRegion"
    /// <summary>
    ///   <para>rdfs:label : mind^^xsd:string</para>
    ///   <para>rdfs:comment : Difficult concept. Better to be expressed by the primitive "mental function" ^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#Mind">biotop:Mind</a>
    /// </summary>
    let Mind = _prefixId.prefix "Mind"
    /// <summary>
    ///   <para>ru:definition : Cells that grow and replicate continuously outside the living organism.^^xsd:string</para>
    ///   <para>rdfs:label : modified cell^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#ModifiedCell">biotop:ModifiedCell</a>
    /// </summary>
    let ModifiedCell = _prefixId.prefix "ModifiedCell"

    /// <summary>
    ///   <para>ru:definition : MolecularEntityByEntiretyPartition
    ///
    /// Ontologically irrelevant partitioning node. Used for improving ontology housekeeping. Its purpose is to express that all subclasses are mutually disjoint.^^xsd:string</para>
    ///   <para>rdfs:label : *^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#MolecularEntityByEntiretyPartition">biotop:MolecularEntityByEntiretyPartition</a>
    /// </summary>
    let MolecularEntityByEntiretyPartition =
        _prefixId.prefix "MolecularEntityByEntiretyPartition"

    /// <summary>
    ///   <para>ru:definition : MolecularEntityByGranularityPartition
    ///
    /// Ontologically irrelevant partitioning node. Used for improving ontology housekeeping. Its purpose is to express that all subclasses are mutually disjoint.^^xsd:string</para>
    ///   <para>rdfs:label : *^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#MolecularEntityByGranularityPartition">biotop:MolecularEntityByGranularityPartition</a>
    /// </summary>
    let MolecularEntityByGranularityPartition =
        _prefixId.prefix "MolecularEntityByGranularityPartition"

    /// <summary>
    ///   <para>ru:definition : MolecularEntityByOrganicInorganicPartition
    ///
    /// Ontologically irrelevant partitioning node. Used for improving ontology housekeeping. Its purpose is to express that all subclasses are mutually disjoint.^^xsd:string</para>
    ///   <para>rdfs:label : *^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#MolecularEntityByOrganicInorganicPartition">biotop:MolecularEntityByOrganicInorganicPartition</a>
    /// </summary>
    let MolecularEntityByOrganicInorganicPartition =
        _prefixId.prefix "MolecularEntityByOrganicInorganicPartition"

    /// <summary>
    ///   <para>ru:definition : Inherent function of a single molecule.^^xsd:string</para>
    ///   <para>rdfs:label : molecular function^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#MolecularFunction">biotop:MolecularFunction</a>
    /// </summary>
    let MolecularFunction = _prefixId.prefix "MolecularFunction"
    /// <summary>
    ///   <para>ru:definition : not self-standing aggregation of atoms which are part of a bigger molecule^^xsd:string</para>
    ///   <para>rdfs:label : molecular residue^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#MolecularResidue">biotop:MolecularResidue</a>
    /// </summary>
    let MolecularResidue = _prefixId.prefix "MolecularResidue"
    /// <summary>
    ///   <para>ru:definition : Particle that consists of entire molecules.^^xsd:string</para>
    ///   <para>rdfs:label : molecule complex^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#MoleculeComplex">biotop:MoleculeComplex</a>
    /// </summary>
    let MoleculeComplex = _prefixId.prefix "MoleculeComplex"
    /// <summary>
    ///   <para>ru:definition : A mono-molecular entity is a self connected compound of two atoms or more which exhibit at least one covalent bound. Molecular entities can be isolated molecules or parts of molecules (groups, residue). They may be electrically neutral or not.
    ///
    /// In biological systems molecular entities generally occur in very high quantities. In text, references to chemicals are often ambiguous. When we state "water has a molecular weight of 18" we refer to single water molecules. However, saying that "water has a density of 1kg/dm³" under certain conditions then we make a statement about pluralities of water molecules each of which has water molecules as "grains"
    /// Old name: molecular entity
    ///
    /// The upper bound of monomolecular entities is shallow. Strictly even a diamond crystal would be a monomolecular entity. One argument against this idea is that a diamond crystal is still a diamond crystal if you take away some portions.
    /// This is not the case with a classical molecule. ^^xsd:string</para>
    ///   <para>rdfs:label : mono molecular entity^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#MonoMolecularEntity">biotop:MonoMolecularEntity</a>
    /// </summary>
    let MonoMolecularEntity = _prefixId.prefix "MonoMolecularEntity"
    /// <summary>
    ///   <para>ru:definition : Monomers can be described as constituted by molecularl groups. They are not repetitive and can constitute the building blocks of Polymers.^^xsd:string</para>
    ///   <para>rdfs:label : monomer^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#Monomer">biotop:Monomer</a>
    /// </summary>
    let Monomer = _prefixId.prefix "Monomer"
    /// <summary>
    ///   <para>ru:definition : Organisms that are composed by more than one cell.^^xsd:string</para>
    ///   <para>rdfs:label : multicellular organism^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#MulticellularOrganism">biotop:MulticellularOrganism</a>
    /// </summary>
    let MulticellularOrganism = _prefixId.prefix "MulticellularOrganism"
    /// <summary>
    ///   <para>rdfs:label : neoplastic process^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#NeoplasticProcess">biotop:NeoplasticProcess</a>
    /// </summary>
    let NeoplasticProcess = _prefixId.prefix "NeoplasticProcess"
    /// <summary>
    ///   <para>ru:definition : A role a molecule plays if it acts as a neurotransmitter^^xsd:string</para>
    ///   <para>rdfs:label : neuroreactive role^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#NeuroreactiveRole">biotop:NeuroreactiveRole</a>
    /// </summary>
    let NeuroreactiveRole = _prefixId.prefix "NeuroreactiveRole"
    /// <summary>
    ///   <para>ru:synonym : Neutral Particle^^xsd:string</para>
    ///   <para>rdfs:label : neutron^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#Neutron">biotop:Neutron</a>
    /// </summary>
    let Neutron = _prefixId.prefix "Neutron"
    /// <summary>
    ///   <para>ru:definition : Lipids that have aliphatic chains and no steroid rings^^xsd:string</para>
    ///   <para>rdfs:label : non steroid lipid^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#NonSteroidLipid">biotop:NonSteroidLipid</a>
    /// </summary>
    let NonSteroidLipid = _prefixId.prefix "NonSteroidLipid"
    /// <summary>
    ///   <para>ru:definition : a process that is considered abnormal^^xsd:string</para>
    ///   <para>rdfs:label : noncanonical processual entity^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#NoncanonicalProcessualEntity">biotop:NoncanonicalProcessualEntity</a>
    /// </summary>
    let NoncanonicalProcessualEntity = _prefixId.prefix "NoncanonicalProcessualEntity"

    /// <summary>
    ///   <para>owl:priorVersion : noncanonical state^^xsd:string</para>
    ///   <para>ru:definition : a biological state that is considered "abnormal"^^xsd:string</para>
    ///   <para>rdfs:label : noncanonical static processual entity^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#NoncanonicalStaticProcessualEntity">biotop:NoncanonicalStaticProcessualEntity</a>
    /// </summary>
    let NoncanonicalStaticProcessualEntity =
        _prefixId.prefix "NoncanonicalStaticProcessualEntity"

    /// <summary>
    ///   <para>rdfs:label : noncanonical value region^^xsd:string</para>
    ///   <para>rdfs:comment : abstract region in which the value "noncanonical" of canonicity is located^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#NoncanonicalValueRegion">biotop:NoncanonicalValueRegion</a>
    /// </summary>
    let NoncanonicalValueRegion = _prefixId.prefix "NoncanonicalValueRegion"

    /// <summary>
    ///   <para>rdfs:label : nucleic acid nucleotide or nucleoside molecule or residue^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#NucleicAcidNucleotideOrNucleosideMoleculeOrResidue">biotop:NucleicAcidNucleotideOrNucleosideMoleculeOrResidue</a>
    /// </summary>
    let NucleicAcidNucleotideOrNucleosideMoleculeOrResidue =
        _prefixId.prefix "NucleicAcidNucleotideOrNucleosideMoleculeOrResidue"

    /// <summary>
    ///   <para>rdfs:label : nucleic acid region^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#NucleicAcidRegion">biotop:NucleicAcidRegion</a>
    /// </summary>
    let NucleicAcidRegion = _prefixId.prefix "NucleicAcidRegion"
    /// <summary>
    ///   <para>ru:definition : A nucleic acid is a complex, high-molecular-weight biochemical macromolecule composed of nucleotide chains that convey genetic information.^^xsd:string</para>
    ///   <para>rdfs:label : nucleic acid structure^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#NucleicAcidStructure">biotop:NucleicAcidStructure</a>
    /// </summary>
    let NucleicAcidStructure = _prefixId.prefix "NucleicAcidStructure"
    /// <summary>
    ///   <para>ru:definition : ^^xsd:string</para>
    ///   <para>rdfs:label : nucleoside molecule^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#NucleosideMolecule">biotop:NucleosideMolecule</a>
    /// </summary>
    let NucleosideMolecule = _prefixId.prefix "NucleosideMolecule"
    /// <summary>
    ///   <para>ru:definition : Comment: (QCR) hasComponent exactly 1 HeterocyclicBase and hasComponent exactly 1 Phosphate and hasComponent only (Phosphate or Ribose or HeterocyclicBase) and hasComponent exactly 1 Pentose^^xsd:string</para>
    ///   <para>rdfs:label : nucleotide molecule^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#NucleotideMolecule">biotop:NucleotideMolecule</a>
    /// </summary>
    let NucleotideMolecule = _prefixId.prefix "NucleotideMolecule"
    /// <summary>
    ///   <para>ru:definition : The information that describes the make-up of a (physical) nucleotide sequence.^^xsd:string</para>
    ///   <para>rdfs:label : nucleotide sequence information^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#NucleotideSequenceInformation">biotop:NucleotideSequenceInformation</a>
    /// </summary>
    let NucleotideSequenceInformation = _prefixId.prefix "NucleotideSequenceInformation"
    /// <summary>
    ///   <para>ru:definition : The role a nurse plays^^xsd:string</para>
    ///   <para>rdfs:label : nurse role^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#NurseRole">biotop:NurseRole</a>
    /// </summary>
    let NurseRole = _prefixId.prefix "NurseRole"
    /// <summary>
    ///   <para>ru:definition : A quality that inheres in some material or immaterial physical object.^^xsd:string</para>
    ///   <para>rdfs:label : object quality^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#ObjectQuality">biotop:ObjectQuality</a>
    /// </summary>
    let ObjectQuality = _prefixId.prefix "ObjectQuality"
    let ObservingAction = _prefixId.prefix "ObservingAction"
    /// <summary>
    ///   <para>ru:definition : The role that determines the occupation that characterizes the daily life of a human being or animal.^^xsd:string</para>
    ///   <para>rdfs:label : occupational role^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#OccupationalRole">biotop:OccupationalRole</a>
    /// </summary>
    let OccupationalRole = _prefixId.prefix "OccupationalRole"
    /// <summary>
    ///   <para>ru:definition : An oligo or polymer macromolecular structure is a molecule of moderate to high relative molecular mass, the structure of which essentially comprises the multiple repetition (n &gt;= 2) of units derived from molecules of low relative molecular mass.^^xsd:string</para>
    ///   <para>rdfs:label : oligo or polymer^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#OligoOrPolymer">biotop:OligoOrPolymer</a>
    /// </summary>
    let OligoOrPolymer = _prefixId.prefix "OligoOrPolymer"
    /// <summary>
    ///   <para>ru:definition : line bounding a two-dimensional biological entity^^xsd:string</para>
    ///   <para>rdfs:label : one dimensional boundary^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#OneDimensionalBoundary">biotop:OneDimensionalBoundary</a>
    /// </summary>
    let OneDimensionalBoundary = _prefixId.prefix "OneDimensionalBoundary"
    /// <summary>
    ///   <para>ru:definition : line or curve^^xsd:string</para>
    ///   <para>rdfs:label : one dimensional physical entity^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#OneDimensionalPhysicalEntity">biotop:OneDimensionalPhysicalEntity</a>
    /// </summary>
    let OneDimensionalPhysicalEntity = _prefixId.prefix "OneDimensionalPhysicalEntity"
    /// <summary>
    ///   <para>rdfs:label : order diptera value region^^xsd:string</para>
    ///   <para>rdfs:comment : EXAMPLE OF TAXON REGION^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#OrderDipteraValueRegion">biotop:OrderDipteraValueRegion</a>
    /// </summary>
    let OrderDipteraValueRegion = _prefixId.prefix "OrderDipteraValueRegion"

    /// <summary>
    ///   <para>rdfs:label : order enterobacteriales value region^^xsd:string</para>
    ///   <para>rdfs:comment : EXAMPLE OF TAXON REGION^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#OrderEnterobacterialesValueRegion">biotop:OrderEnterobacterialesValueRegion</a>
    /// </summary>
    let OrderEnterobacterialesValueRegion =
        _prefixId.prefix "OrderEnterobacterialesValueRegion"

    /// <summary>
    ///   <para>rdfs:label : order primates value region^^xsd:string</para>
    ///   <para>rdfs:comment : EXAMPLE OF TAXON REGION^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#OrderPrimatesValueRegion">biotop:OrderPrimatesValueRegion</a>
    /// </summary>
    let OrderPrimatesValueRegion = _prefixId.prefix "OrderPrimatesValueRegion"

    /// <summary>
    ///   <para>rdfs:label : order saccharomycetales value region^^xsd:string</para>
    ///   <para>rdfs:comment : EXAMPLE OF TAXON REGION^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#OrderSaccharomycetalesValueRegion">biotop:OrderSaccharomycetalesValueRegion</a>
    /// </summary>
    let OrderSaccharomycetalesValueRegion =
        _prefixId.prefix "OrderSaccharomycetalesValueRegion"

    /// <summary>
    ///   <para>ru:definition : Macroscopic, well delimited, functionally and structurally characterized part of an organism. Exact criteria of what an organ is do not exist.^^xsd:string</para>
    ///   <para>rdfs:label : organ^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#Organ">biotop:Organ</a>
    /// </summary>
    let Organ = _prefixId.prefix "Organ"
    /// <summary>
    ///   <para>rdfs:seeAlso : FMAID:82472 Cardinal organ part^^xsd:string</para>
    ///   <para>rdfs:label : organ part^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#OrganPart">biotop:OrganPart</a>
    /// </summary>
    let OrganPart = _prefixId.prefix "OrganPart"
    /// <summary>
    ///   <para>rdfs:seeAlso : FMAID:7149 Organ system^^xsd:string</para>
    ///   <para>rdfs:label : organ system^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#OrganSystem">biotop:OrganSystem</a>
    /// </summary>
    let OrganSystem = _prefixId.prefix "OrganSystem"
    /// <summary>
    ///   <para>rdfs:seeAlso : FMAID:67509  Organ system subdivistion^^xsd:string</para>
    ///   <para>rdfs:label : organ system part^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#OrganSystemPart">biotop:OrganSystemPart</a>
    /// </summary>
    let OrganSystemPart = _prefixId.prefix "OrganSystemPart"
    /// <summary>
    ///   <para>ru:definition : Substances containing carbon and its derivatives as their prinicipal elements, usually combined with itself and with atoms of one or more other element such as hydrogen, oxygen, nitrogen, sulfur, phosphorus, chlorine or fluorine. They exist in either carbon chain or carbon ring form. Excludes carbides, carbonates and carbon oxides.^^xsd:string</para>
    ///   <para>rdfs:label : organic molecular entity^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#OrganicMolecularEntity">biotop:OrganicMolecularEntity</a>
    /// </summary>
    let OrganicMolecularEntity = _prefixId.prefix "OrganicMolecularEntity"

    /// <summary>
    ///   <para>rdfs:comment : Ontologically irrelevant partitioning node. Used for improving ontology housekeeping. Its purpose is to express that all subclasses are mutually disjoint.^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#OrganicMolecularEntityPartition">biotop:OrganicMolecularEntityPartition</a>
    /// </summary>
    let OrganicMolecularEntityPartition =
        _prefixId.prefix "OrganicMolecularEntityPartition"

    /// <summary>
    ///   <para>ru:definition : Action that has some organism as agent^^xsd:string</para>
    ///   <para>rdfs:label : organism action^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#OrganismAction">biotop:OrganismAction</a>
    /// </summary>
    let OrganismAction = _prefixId.prefix "OrganismAction"

    /// <summary>
    ///   <para>ru:definition : Ontologically irrelevant partitioning node. Used for improving ontology housekeeping. Its purpose is to express that all subclasses are mutually disjoint.^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#OrganismByDevelopmentalStagePartition">biotop:OrganismByDevelopmentalStagePartition</a>
    /// </summary>
    let OrganismByDevelopmentalStagePartition =
        _prefixId.prefix "OrganismByDevelopmentalStagePartition"

    /// <summary>
    ///   <para>rdfs:comment : Ontologically irrelevant partitioning node. Used for improving ontology housekeeping. Its purpose is to express that all subclasses are mutually disjoint.^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#OrganismByTaxonPartition">biotop:OrganismByTaxonPartition</a>
    /// </summary>
    let OrganismByTaxonPartition = _prefixId.prefix "OrganismByTaxonPartition"
    /// <summary>
    ///   <para>ru:definition : action in which single biological organisms interact^^xsd:string</para>
    ///   <para>rdfs:label : organism interaction^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#OrganismInteraction">biotop:OrganismInteraction</a>
    /// </summary>
    let OrganismInteraction = _prefixId.prefix "OrganismInteraction"
    /// <summary>
    ///   <para>ru:definition : A well defined and circumscribed subdivision of an organism, not any arbitrary part. Macroscopic organism parts may be delimited mainly by natural boundaries but always exhibit at least small regions of fiat boundaries. An organism part may derive from an organism, i.e. it may continue to exist even when the organism does not exist any longer.^^xsd:string</para>
    ///   <para>rdfs:label : organism part^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#OrganismPart">biotop:OrganismPart</a>
    /// </summary>
    let OrganismPart = _prefixId.prefix "OrganismPart"
    /// <summary>
    ///   <para>ru:definition : any biological process that involves a whole organism^^xsd:string</para>
    ///   <para>rdfs:label : organism process^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#OrganismProcess">biotop:OrganismProcess</a>
    /// </summary>
    let OrganismProcess = _prefixId.prefix "OrganismProcess"
    /// <summary>
    ///   <para>ru:definition : collection of human or legal entities^^xsd:string</para>
    ///   <para>rdfs:label : organization^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#Organization">biotop:Organization</a>
    /// </summary>
    let Organization = _prefixId.prefix "Organization"
    /// <summary>
    ///   <para>ru:definition : the role an organism plays in relation to its children^^xsd:string</para>
    ///   <para>rdfs:label : parent role^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#ParentRole">biotop:ParentRole</a>
    /// </summary>
    let ParentRole = _prefixId.prefix "ParentRole"
    /// <summary>
    ///   <para>owl:priorVersion : particular entity^^xsd:string</para>
    ///   <para>ru:definition : From an universalist point of view most BioTop classes can be considered the extension of universals.
    ///
    /// However, BioTop does not claim that all of its classes are the extension of universals and is agnostic with regard to the existence of universals and the delineation between universals and non-universals.
    /// ^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#Particular">biotop:Particular</a>
    /// </summary>
    let Particular = _prefixId.prefix "Particular"
    let ParticularEntity = _prefixId.prefix "ParticularEntity"
    /// <summary>
    ///   <para>ru:definition : pathological structure, disposition, or process. This disjoint category helps properly represent diseases becauses it is often left open whether they are meant as pathological structure, disposition, or process.
    ///
    /// In case this is to be left open, the relation has_locus should be used to connect them to anatomical entities^^xsd:string</para>
    ///   <para>rdfs:label : pathological condition^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#PathologicalCondition">biotop:PathologicalCondition</a>
    /// </summary>
    let PathologicalCondition = _prefixId.prefix "PathologicalCondition"
    /// <summary>
    ///   <para>owl:priorVersion : prior label "dysfunction"^^xsd:string</para>
    ///   <para>ru:definition : any kind of disposition considered non-canonical. The criteria of canonicity are not further specified.
    /// The classification of certain dispositions as dysfunctional or pathological is dependent on a historic and cultural context. Dysfunction or disease therefore hasn't the status of a universal.^^xsd:string</para>
    ///   <para>rdfs:label : pathological disposition^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#PathologicalDisposition">biotop:PathologicalDisposition</a>
    /// </summary>
    let PathologicalDisposition = _prefixId.prefix "PathologicalDisposition"
    /// <summary>
    ///   <para>ru:definition : a biological process which is non-canonic^^xsd:string</para>
    ///   <para>rdfs:label : pathological process^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#PathologicalProcess">biotop:PathologicalProcess</a>
    /// </summary>
    let PathologicalProcess = _prefixId.prefix "PathologicalProcess"

    /// <summary>
    ///   <para>owl:priorVersion : pathological state^^xsd:string</para>
    ///   <para>rdfs:label : pathological static processual entity^^xsd:string</para>
    ///   <para>rdfs:comment : Condition of an organism that deviates from what is considered normal. Often referred to by the terms "disorder", "disease", "syndrome", "sign", or "symptom". None of these denote clearly delineated ontological categories.
    ///
    /// See disease role etc.^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#PathologicalStaticProcessualEntity">biotop:PathologicalStaticProcessualEntity</a>
    /// </summary>
    let PathologicalStaticProcessualEntity =
        _prefixId.prefix "PathologicalStaticProcessualEntity"

    /// <summary>
    ///   <para>owl:priorVersion : former name: "ill formed biological structure"^^xsd:string</para>
    ///   <para>ru:definition : biological structure that is non-canonic^^xsd:string</para>
    ///   <para>rdfs:label : pathological structure^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#PathologicalStructure">biotop:PathologicalStructure</a>
    /// </summary>
    let PathologicalStructure = _prefixId.prefix "PathologicalStructure"
    /// <summary>
    ///   <para>ru:definition : state of an organism or an organism part requiring therapeutic or palliative intervention^^xsd:string</para>
    ///   <para>rdfs:label : pathological value region^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#PathologicalValueRegion">biotop:PathologicalValueRegion</a>
    /// </summary>
    let PathologicalValueRegion = _prefixId.prefix "PathologicalValueRegion"
    /// <summary>
    ///   <para>ru:definition : Inherent Function of a protein or a part of it.^^xsd:string</para>
    ///   <para>rdfs:label : peptide function^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#PeptideFunction">biotop:PeptideFunction</a>
    /// </summary>
    let PeptideFunction = _prefixId.prefix "PeptideFunction"
    /// <summary>
    ///   <para>rdfs:label : peptide structure^^xsd:string</para>
    ///   <para>rdfs:comment : Comment: We here use the term peptide in the most general sense, viz. a oligo or polymer made out of amino acids.^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#PeptideStructure">biotop:PeptideStructure</a>
    /// </summary>
    let PeptideStructure = _prefixId.prefix "PeptideStructure"
    /// <summary>
    ///   <para>ru:definition : Phosphate is a salt of phosphoric acid or a functional group on organic compounds.^^xsd:string</para>
    ///   <para>rdfs:label : phosphate^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#Phosphate">biotop:Phosphate</a>
    /// </summary>
    let Phosphate = _prefixId.prefix "Phosphate"
    /// <summary>
    ///   <para>rdfs:label : phylum arthropoda value region^^xsd:string</para>
    ///   <para>rdfs:comment : EXAMPLE OF TAXON REGION^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#PhylumArthropodaValueRegion">biotop:PhylumArthropodaValueRegion</a>
    /// </summary>
    let PhylumArthropodaValueRegion = _prefixId.prefix "PhylumArthropodaValueRegion"
    /// <summary>
    ///   <para>rdfs:label : phylum ascomycota value region^^xsd:string</para>
    ///   <para>rdfs:comment : EXAMPLE OF TAXON REGION^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#PhylumAscomycotaValueRegion">biotop:PhylumAscomycotaValueRegion</a>
    /// </summary>
    let PhylumAscomycotaValueRegion = _prefixId.prefix "PhylumAscomycotaValueRegion"
    /// <summary>
    ///   <para>rdfs:label : phylum chordata value region^^xsd:string</para>
    ///   <para>rdfs:comment : EXAMPLE OF TAXON REGION^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#PhylumChordataValueRegion">biotop:PhylumChordataValueRegion</a>
    /// </summary>
    let PhylumChordataValueRegion = _prefixId.prefix "PhylumChordataValueRegion"

    /// <summary>
    ///   <para>rdfs:label : phylum proteobacteria value region^^xsd:string</para>
    ///   <para>rdfs:comment : EXAMPLE OF TAXON REGION^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#PhylumProteobacteriaValueRegion">biotop:PhylumProteobacteriaValueRegion</a>
    /// </summary>
    let PhylumProteobacteriaValueRegion =
        _prefixId.prefix "PhylumProteobacteriaValueRegion"

    /// <summary>
    ///   <para>ru:definition : A independent physical entity that bounds or demarcates some other physical entity. Commonly viewed as a lower-dimensional part, the the notion of physical boundary here also encompasses ill-delimited spaces that fulfill the same function, e.g. biological joints.^^xsd:string</para>
    ///   <para>rdfs:label : physical boundary^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#PhysicalBoundary">biotop:PhysicalBoundary</a>
    /// </summary>
    let PhysicalBoundary = _prefixId.prefix "PhysicalBoundary"
    /// <summary>
    ///   <para>ru:definition : force as defined by physics (mass + acceleration)^^xsd:string</para>
    ///   <para>rdfs:label : physical force^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#PhysicalForce">biotop:PhysicalForce</a>
    /// </summary>
    let PhysicalForce = _prefixId.prefix "PhysicalForce"
    /// <summary>
    ///   <para>ru:definition : physical length (e.g. in meters)^^xsd:string</para>
    ///   <para>rdfs:label : physical length^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#PhysicalLength">biotop:PhysicalLength</a>
    /// </summary>
    let PhysicalLength = _prefixId.prefix "PhysicalLength"
    /// <summary>
    ///   <para>ru:definition : Mass (gravity independent) - not weight. Measured in g, kg, ...^^xsd:string</para>
    ///   <para>rdfs:label : physical mass^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#PhysicalMass">biotop:PhysicalMass</a>
    /// </summary>
    let PhysicalMass = _prefixId.prefix "PhysicalMass"
    /// <summary>
    ///   <para>ru:definition : process that only involves non-biological participants^^xsd:string</para>
    ///   <para>rdfs:label : physical processual entity^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#PhysicalProcessualEntity">biotop:PhysicalProcessualEntity</a>
    /// </summary>
    let PhysicalProcessualEntity = _prefixId.prefix "PhysicalProcessualEntity"
    /// <summary>
    ///   <para>ru:definition : Quality of being solid, liquid, gaseous, ...  [steschu20080127]^^xsd:string</para>
    ///   <para>rdfs:label : physical state^^xsd:string</para>
    ///   <para>rdfs:comment : former name: StateOfAggregation^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#PhysicalState">biotop:PhysicalState</a>
    /// </summary>
    let PhysicalState = _prefixId.prefix "PhysicalState"
    /// <summary>
    ///   <para>ru:definition : Volume of three-dimensional objects - third potency of length^^xsd:string</para>
    ///   <para>rdfs:label : physical volume^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#PhysicalVolume">biotop:PhysicalVolume</a>
    /// </summary>
    let PhysicalVolume = _prefixId.prefix "PhysicalVolume"
    /// <summary>
    ///   <para>ru:definition : The role a physician plays^^xsd:string</para>
    ///   <para>rdfs:label : physician role^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#PhysicianRole">biotop:PhysicianRole</a>
    /// </summary>
    let PhysicianRole = _prefixId.prefix "PhysicianRole"
    /// <summary>
    ///   <para>ru:definition : A plan is an information entity that describes a series of steps to be carried out in order to achiev a goal. Plans can only be realized by processes.^^xsd:string</para>
    ///   <para>rdfs:label : plan^^xsd:string</para>
    ///   <para>rdfs:comment : (OBI 344)^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#Plan">biotop:Plan</a>
    /// </summary>
    let Plan = _prefixId.prefix "Plan"
    /// <summary>
    ///   <para>ru:definition : Organism of the kingdom Plantae.^^xsd:string</para>
    ///   <para>rdfs:label : plant^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#Plant">biotop:Plant</a>
    /// </summary>
    let Plant = _prefixId.prefix "Plant"
    /// <summary>
    ///   <para>rdfs:label : plant cell^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#PlantCell">biotop:PlantCell</a>
    /// </summary>
    let PlantCell = _prefixId.prefix "PlantCell"
    /// <summary>
    ///   <para>rdfs:label : plant population^^xsd:string</para>
    ///   <para>rdfs:comment : EXAMPLE OF POPULATION^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#PlantPopulation">biotop:PlantPopulation</a>
    /// </summary>
    let PlantPopulation = _prefixId.prefix "PlantPopulation"

    /// <summary>
    ///   <para>ru:definition : collection of identical things of the same sort^^xsd:string</para>
    ///   <para>rdfs:label : plurality of identical polymolecular entities^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#PluralityOfIdenticalPolymolecularEntities">biotop:PluralityOfIdenticalPolymolecularEntities</a>
    /// </summary>
    let PluralityOfIdenticalPolymolecularEntities =
        _prefixId.prefix "PluralityOfIdenticalPolymolecularEntities"

    /// <summary>
    ///   <para>ru:definition : Collection of two or more organisms of the same sort.  ^^xsd:string</para>
    ///   <para>rdfs:label : plurality of organisms^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#PluralityOfOrganisms">biotop:PluralityOfOrganisms</a>
    /// </summary>
    let PluralityOfOrganisms = _prefixId.prefix "PluralityOfOrganisms"
    /// <summary>
    ///   <para>ru:definition : typically the boundary of a time interval^^xsd:string</para>
    ///   <para>rdfs:label : point in time^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#PointInTime">biotop:PointInTime</a>
    /// </summary>
    let PointInTime = _prefixId.prefix "PointInTime"
    /// <summary>
    ///   <para>ru:definition : The role of a substance of mixture of substance of a defined amount thereof to be toxic to (parts of) biological organisms^^xsd:string</para>
    ///   <para>rdfs:label : poison role^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#PoisonRole">biotop:PoisonRole</a>
    /// </summary>
    let PoisonRole = _prefixId.prefix "PoisonRole"
    /// <summary>
    ///   <para>rdfs:label : poisoning^^xsd:string</para>
    ///   <para>rdfs:comment : negatively affecting the integrity of a biologival system caused by one or more chemical substances^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#Poisoning">biotop:Poisoning</a>
    /// </summary>
    let Poisoning = _prefixId.prefix "Poisoning"
    /// <summary>
    ///   <para>ru:definition : An object which contains several molecules, has direct parts (components) of different types and which changes its ontological nature if subdivided. It must have clear unity and identity criteria.^^xsd:string</para>
    ///   <para>rdfs:label : poly molecular composite entity^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#PolyMolecularCompositeEntity">biotop:PolyMolecularCompositeEntity</a>
    /// </summary>
    let PolyMolecularCompositeEntity = _prefixId.prefix "PolyMolecularCompositeEntity"
    /// <summary>
    ///   <para>ru:definition : Collection of Organisms of a defined taxon living in a given geographic area. In contrast to the "official" definition ("same species") this definition is broader and corresponds better to the use of the term in some contexts (e.g. "mixed population of 2 species")^^xsd:string</para>
    ///   <para>rdfs:label : population^^xsd:string</para>
    ///   <para>rdfs:comment : all child classes of population are only meant as examples demonstrating how population classes can be postcoordinated^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#Population">biotop:Population</a>
    /// </summary>
    let Population = _prefixId.prefix "Population"
    /// <summary>
    ///   <para>ru:definition : Liquid constituted by different kinds of collectives, e.g. aqueous NaCl solution^^xsd:string</para>
    ///   <para>rdfs:label : portion of heterogenous liquid^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#PortionOfHeterogenousLiquid">biotop:PortionOfHeterogenousLiquid</a>
    /// </summary>
    let PortionOfHeterogenousLiquid = _prefixId.prefix "PortionOfHeterogenousLiquid"
    /// <summary>
    ///   <para>ru:definition : Solid constituted by different kinds of collectives, e.g. a NaCl crystal, granite^^xsd:string</para>
    ///   <para>rdfs:label : portion of heterogenous solid^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#PortionOfHeterogenousSolid">biotop:PortionOfHeterogenousSolid</a>
    /// </summary>
    let PortionOfHeterogenousSolid = _prefixId.prefix "PortionOfHeterogenousSolid"
    /// <summary>
    ///   <para>ru:definition : Composition of granular components of the same kind.^^xsd:string</para>
    ///   <para>rdfs:label : portion of homogenous matter^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#PortionOfHomogenousMatter">biotop:PortionOfHomogenousMatter</a>
    /// </summary>
    let PortionOfHomogenousMatter = _prefixId.prefix "PortionOfHomogenousMatter"
    /// <summary>
    ///   <para>ru:definition : Hinders a  process or the realization of a  function. As the second argument represents sth non-existent, it cannot be expressed in FOL. Hence the special status of this class. (Cf. Condovardi et al. "Preventing Existence, FOIS 2001)^^xsd:string</para>
    ///   <para>rdfs:label : prevention action^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#PreventionAction">biotop:PreventionAction</a>
    /// </summary>
    let PreventionAction = _prefixId.prefix "PreventionAction"
    /// <summary>
    ///   <para>ru:definition : The role an action plays if it is intended to protect an organism against negative external influences.^^xsd:string</para>
    ///   <para>rdfs:label : preventive role^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#PreventiveRole">biotop:PreventiveRole</a>
    /// </summary>
    let PreventiveRole = _prefixId.prefix "PreventiveRole"
    /// <summary>
    ///   <para>rdfs:label : primate^^xsd:string</para>
    ///   <para>rdfs:comment : one primate^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#Primate">biotop:Primate</a>
    /// </summary>
    let Primate = _prefixId.prefix "Primate"
    /// <summary>
    ///   <para>rdfs:label : primate population^^xsd:string</para>
    ///   <para>rdfs:comment : EXAMPLE OF POPULATION^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#PrimatePopulation">biotop:PrimatePopulation</a>
    /// </summary>
    let PrimatePopulation = _prefixId.prefix "PrimatePopulation"
    /// <summary>
    ///   <para>owl:priorVersion : processual entity^^xsd:string</para>
    ///   <para>ru:definition : Process is in BioTop the generic subsumer of anything that "occurs".
    /// Processes can span across time and have temporal parts (i.e. there is no time in which all parts of a process are simultaneously present).
    ///
    /// A special kind of process is the event, which has no temporal extension. It can be regarded as Process Boundary (BFO).
    ///
    ///
    /// Processes have physical or informational entities as participants.^^xsd:string</para>
    ///   <para>rdfs:label : process^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#Process">biotop:Process</a>
    /// </summary>
    let Process = _prefixId.prefix "Process"
    /// <summary>
    ///   <para>ru:definition : A quality that inheres in some process^^xsd:string</para>
    ///   <para>rdfs:label : process quality^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#ProcessQuality">biotop:ProcessQuality</a>
    /// </summary>
    let ProcessQuality = _prefixId.prefix "ProcessQuality"
    /// <summary>
    ///   <para>ru:definition : action in which a new physical or informational entity comes into being^^xsd:string</para>
    ///   <para>rdfs:label : producing^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#Producing">biotop:Producing</a>
    /// </summary>
    let Producing = _prefixId.prefix "Producing"
    /// <summary>
    ///   <para>ru:definition : Cell lacking membrane enclosed organells^^xsd:string</para>
    ///   <para>rdfs:label : prokaryote^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#Prokaryote">biotop:Prokaryote</a>
    /// </summary>
    let Prokaryote = _prefixId.prefix "Prokaryote"
    /// <summary>
    ///   <para>ru:definition : Mostly only proteins but composition with other molecules possible (e.g. Fe -&gt; Hemoglobin) or also lipoproteins^^xsd:string</para>
    ///   <para>rdfs:label : protein complex^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#ProteinComplex">biotop:ProteinComplex</a>
    /// </summary>
    let ProteinComplex = _prefixId.prefix "ProteinComplex"
    /// <summary>
    ///   <para>ru:definition : Structural domain is the smallest element of protein tertiary structure that is self-stabilizing and often folds independently of the rest of the amino acid chain. It may contain one or more structural motives (ProteinSubstructure). A protein domain typically has its own function, the overall function of the protein results from the composition of the functions of all of its structural domains.^^xsd:string</para>
    ///   <para>rdfs:label : protein domain^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#ProteinDomain">biotop:ProteinDomain</a>
    /// </summary>
    let ProteinDomain = _prefixId.prefix "ProteinDomain"
    /// <summary>
    ///   <para>ru:definition : A secondary substructure of a protein (protein Motif)^^xsd:string</para>
    ///   <para>rdfs:label : protein substructure^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#ProteinSubstructure">biotop:ProteinSubstructure</a>
    /// </summary>
    let ProteinSubstructure = _prefixId.prefix "ProteinSubstructure"
    /// <summary>
    ///   <para>ru:definition : A protein molecule that assembles with other protein molecules to form a protein complex. May have its own function. However, most proteinsubunits do not gain functionality until associated with the other subunits.^^xsd:string</para>
    ///   <para>rdfs:label : protein subunit^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#ProteinSubunit">biotop:ProteinSubunit</a>
    /// </summary>
    let ProteinSubunit = _prefixId.prefix "ProteinSubunit"
    /// <summary>
    ///   <para>ru:definition : Organisms of the kingdom Protista^^xsd:string</para>
    ///   <para>rdfs:label : protist^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#Protist">biotop:Protist</a>
    /// </summary>
    let Protist = _prefixId.prefix "Protist"
    /// <summary>
    ///   <para>rdfs:label : protist population^^xsd:string</para>
    ///   <para>rdfs:comment : EXAMPLE OF POPULATION^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#ProtistPopulation">biotop:ProtistPopulation</a>
    /// </summary>
    let ProtistPopulation = _prefixId.prefix "ProtistPopulation"
    /// <summary>
    ///   <para>ru:definition : Positively Charged Particle^^xsd:string</para>
    ///   <para>rdfs:label : proton^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#Proton">biotop:Proton</a>
    /// </summary>
    let Proton = _prefixId.prefix "Proton"
    /// <summary>
    ///   <para>rdfs:label : Quality^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#Quality">biotop:Quality</a>
    /// </summary>
    let Quality = _prefixId.prefix "Quality"
    /// <summary>
    ///   <para>ru:definition : any kind of NucleicAcid that is composed of Ribonucleotides which are not Deoxyribonucleotides^^xsd:string</para>
    ///   <para>rdfs:label : RNA chain^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#RNAChain">biotop:RNAChain</a>
    /// </summary>
    let RNAChain = _prefixId.prefix "RNAChain"
    /// <summary>
    ///   <para>ru:definition : process in which energy-rich particles or electromagnetic waves participate^^xsd:string</para>
    ///   <para>rdfs:label : radiation^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#Radiation">biotop:Radiation</a>
    /// </summary>
    let Radiation = _prefixId.prefix "Radiation"
    /// <summary>
    ///   <para>ru:definition : A role a chemical plays as participant in a chemical reation^^xsd:string</para>
    ///   <para>rdfs:label : reagent role^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#ReagentRole">biotop:ReagentRole</a>
    /// </summary>
    let ReagentRole = _prefixId.prefix "ReagentRole"
    /// <summary>
    ///   <para>ru:definition : The role a (membrane) protein or protein complex plays in acting as a receptor.^^xsd:string</para>
    ///   <para>rdfs:label : receptor role^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#ReceptorRole">biotop:ReceptorRole</a>
    /// </summary>
    let ReceptorRole = _prefixId.prefix "ReceptorRole"
    /// <summary>
    ///   <para>ru:definition : set of rules governing a particular kind of activity (WordNet)^^xsd:string</para>
    ///   <para>rdfs:label : regulation or law^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#RegulationOrLaw">biotop:RegulationOrLaw</a>
    /// </summary>
    let RegulationOrLaw = _prefixId.prefix "RegulationOrLaw"
    /// <summary>
    ///   <para>ru:definition : organization that has the function of issuing regulations or laws^^xsd:string</para>
    ///   <para>rdfs:label : regulatory body^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#RegulatoryBody">biotop:RegulatoryBody</a>
    /// </summary>
    let RegulatoryBody = _prefixId.prefix "RegulatoryBody"
    /// <summary>
    ///   <para>rdfs:label : reptile^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#Reptile">biotop:Reptile</a>
    /// </summary>
    let Reptile = _prefixId.prefix "Reptile"
    /// <summary>
    ///   <para>ru:definition : the role a human plays if he / she is involved in research activities^^xsd:string</para>
    ///   <para>rdfs:label : researcher role^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#ResearcherRole">biotop:ResearcherRole</a>
    /// </summary>
    let ResearcherRole = _prefixId.prefix "ResearcherRole"
    /// <summary>
    ///   <para>rdfs:label : rickettsia cell^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#RickettsiaCell">biotop:RickettsiaCell</a>
    /// </summary>
    let RickettsiaCell = _prefixId.prefix "RickettsiaCell"
    /// <summary>
    ///   <para>ru:definition : A role is a realizable entity the manifestation of which brings about some result or end that is not essential to its bearer in virtue of the kind of thing that it is, but that can be served or participated in by that kind of continuant entity in some kinds of natural, social or institutional
    /// contexts.^^xsd:string</para>
    ///   <para>rdfs:label : role^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#Role">biotop:Role</a>
    /// </summary>
    let Role = _prefixId.prefix "Role"
    /// <summary>
    ///   <para>ru:definition : the role an organism plays in relation to another organism that has the same parents^^xsd:string</para>
    ///   <para>rdfs:label : sibling role^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#SiblingRole">biotop:SiblingRole</a>
    /// </summary>
    let SiblingRole = _prefixId.prefix "SiblingRole"
    /// <summary>
    ///   <para>ru:definition : A role that can inhere in states, processes, or even in certain independent continuants (e.g. in a deformity). This a role is ascribed to an entity in a diagnostic process where the symptom is suspected to indicate a second state or process)^^xsd:string</para>
    ///   <para>rdfs:label : sign or symptom role^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#SignOrSymptomRole">biotop:SignOrSymptomRole</a>
    /// </summary>
    let SignOrSymptomRole = _prefixId.prefix "SignOrSymptomRole"
    /// <summary>
    ///   <para>ru:definition : The role of a biological entity that participates in a biological signalling process.^^xsd:string</para>
    ///   <para>rdfs:label : signalling role^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#SignallingRole">biotop:SignallingRole</a>
    /// </summary>
    let SignallingRole = _prefixId.prefix "SignallingRole"
    /// <summary>
    ///   <para>ru:definition : action that targets a population^^xsd:string</para>
    ///   <para>rdfs:label : social action^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#SocialAction">biotop:SocialAction</a>
    /// </summary>
    let SocialAction = _prefixId.prefix "SocialAction"
    /// <summary>
    ///   <para>ru:definition : Behaviour of a group of organisms^^xsd:string</para>
    ///   <para>rdfs:label : social behavior^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#SocialBehavior">biotop:SocialBehavior</a>
    /// </summary>
    let SocialBehavior = _prefixId.prefix "SocialBehavior"
    /// <summary>
    ///   <para>rdfs:label : solid value region^^xsd:string</para>
    ///   <para>rdfs:comment : "solid" as the value of a states of matter. E.g. a stone has a quality which has its value located in "solid value region"^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#SolidValueRegion">biotop:SolidValueRegion</a>
    /// </summary>
    let SolidValueRegion = _prefixId.prefix "SolidValueRegion"
    /// <summary>
    ///   <para>ru:definition : The role attributed to a - mainly fiat - part of an object that is the site of some process or the location of some object of interest.^^xsd:string</para>
    ///   <para>rdfs:label : spatial reference role^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#SpatialReferenceRole">biotop:SpatialReferenceRole</a>
    /// </summary>
    let SpatialReferenceRole = _prefixId.prefix "SpatialReferenceRole"
    /// <summary>
    ///   <para>ru:definition : An independent continuant entity that is neither a bearer of qualities nor inheres in any other entity (snap:SpatialRegion)^^xsd:string</para>
    ///   <para>rdfs:label : spatial region^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#SpatialRegion">biotop:SpatialRegion</a>
    /// </summary>
    let SpatialRegion = _prefixId.prefix "SpatialRegion"

    /// <summary>
    ///   <para>rdfs:label : species candida albicans value region^^xsd:string</para>
    ///   <para>rdfs:comment : EXAMPLE OF TAXON REGION^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#SpeciesCandidaAlbicansValueRegion">biotop:SpeciesCandidaAlbicansValueRegion</a>
    /// </summary>
    let SpeciesCandidaAlbicansValueRegion =
        _prefixId.prefix "SpeciesCandidaAlbicansValueRegion"

    /// <summary>
    ///   <para>rdfs:label : species drosophila melanogaster value region^^xsd:string</para>
    ///   <para>rdfs:comment : EXAMPLE OF TAXON REGION^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#SpeciesDrosophilaMelanogasterValueRegion">biotop:SpeciesDrosophilaMelanogasterValueRegion</a>
    /// </summary>
    let SpeciesDrosophilaMelanogasterValueRegion =
        _prefixId.prefix "SpeciesDrosophilaMelanogasterValueRegion"

    /// <summary>
    ///   <para>rdfs:label : species escherichia coli value region^^xsd:string</para>
    ///   <para>rdfs:comment : EXAMPLE OF TAXON REGION^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#SpeciesEscherichiaColiValueRegion">biotop:SpeciesEscherichiaColiValueRegion</a>
    /// </summary>
    let SpeciesEscherichiaColiValueRegion =
        _prefixId.prefix "SpeciesEscherichiaColiValueRegion"

    /// <summary>
    ///   <para>rdfs:label : species homo sapiens value region^^xsd:string</para>
    ///   <para>rdfs:comment : EXAMPLE OF TAXON REGION^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#SpeciesHomoSapiensValueRegion">biotop:SpeciesHomoSapiensValueRegion</a>
    /// </summary>
    let SpeciesHomoSapiensValueRegion = _prefixId.prefix "SpeciesHomoSapiensValueRegion"

    /// <summary>
    ///   <para>rdfs:label : species saccharomyces cerevisiae value region^^xsd:string</para>
    ///   <para>rdfs:comment : EXAMPLE OF TAXON REGION^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#SpeciesSaccharomycesCerevisiaeValueRegion">biotop:SpeciesSaccharomycesCerevisiaeValueRegion</a>
    /// </summary>
    let SpeciesSaccharomycesCerevisiaeValueRegion =
        _prefixId.prefix "SpeciesSaccharomycesCerevisiaeValueRegion"

    /// <summary>
    ///   <para>ru:definition : States of matter are the distinct forms that different phases of matter take on.^^xsd:string</para>
    ///   <para>rdfs:label : state of matter^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#StateOfMatter">biotop:StateOfMatter</a>
    /// </summary>
    let StateOfMatter = _prefixId.prefix "StateOfMatter"
    /// <summary>
    ///   <para>ru:definition : Values that a states of matter can have, e.g. liquid, solid.^^xsd:string</para>
    ///   <para>rdfs:label : state of matter value region^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#StateOfMatterValueRegion">biotop:StateOfMatterValueRegion</a>
    /// </summary>
    let StateOfMatterValueRegion = _prefixId.prefix "StateOfMatterValueRegion"
    /// <summary>
    ///   <para>owl:priorVersion : State^^xsd:string</para>
    ///   <para>rdfs:label : static processual entity^^xsd:string</para>
    ///   <para>rdfs:comment : Static condition as a special case of process in which temporal parts are neglected.  ^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#StaticProcessualEntity">biotop:StaticProcessualEntity</a>
    /// </summary>
    let StaticProcessualEntity = _prefixId.prefix "StaticProcessualEntity"
    /// <summary>
    ///   <para>ru:definition : One of a group of polycyclic, 17-carbon-atom, fused-ring compounds occurring both in natural and synthetic forms. Included here are naturally occurring and synthetic steroids, bufanolides, cardanolides, homosteroids, norsteroids, and secosteroids. (UMLS SN)^^xsd:string</para>
    ///   <para>rdfs:label : steroid^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#Steroid">biotop:Steroid</a>
    /// </summary>
    let Steroid = _prefixId.prefix "Steroid"

    /// <summary>
    ///   <para>ru:definition : StructuredBiologicalCompoundByCanonicityPartition
    ///
    /// ontologically irrelevant partition node^^xsd:string</para>
    ///   <para>rdfs:label : *^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#StructuredBiologicalCompoundByCanonicityPartition">biotop:StructuredBiologicalCompoundByCanonicityPartition</a>
    /// </summary>
    let StructuredBiologicalCompoundByCanonicityPartition =
        _prefixId.prefix "StructuredBiologicalCompoundByCanonicityPartition"

    /// <summary>
    ///   <para>rdfs:label : *^^xsd:string</para>
    ///   <para>rdfs:comment : StructuredBiologicalCompoundByGranularityPartition
    ///
    /// ontologically irrelevant disjoint partition: structured biological compound by granularity^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#StructuredBiologicalCompoundByGranularityPartition">biotop:StructuredBiologicalCompoundByGranularityPartition</a>
    /// </summary>
    let StructuredBiologicalCompoundByGranularityPartition =
        _prefixId.prefix "StructuredBiologicalCompoundByGranularityPartition"

    /// <summary>
    ///   <para>ru:definition : Corresponds to FMA anatomical structure but extends to any kind of orgnaism: Material anatomical entity which is generated by coordinated expression of the organism's own genes that guide its morphogenesis; has inherent 3D shape; its parts are connected and spatially related to one another in patterns determined by coordinated gene expression. Examples: heart, right ventricle, mitral valve, myocardium, endothelium, lymphocyte, fibroblast, thorax, cardiovascular system, hemoglobin, T cell receptor.
    /// Old name: anatomical structure^^xsd:string</para>
    ///   <para>rdfs:label : structured biological entity^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#StructuredBiologicalEntity">biotop:StructuredBiologicalEntity</a>
    /// </summary>
    let StructuredBiologicalEntity = _prefixId.prefix "StructuredBiologicalEntity"

    /// <summary>
    ///   <para>ru:definition : All those things that are not identified by belonging to any biological species
    /// Borderline cases are artifacts that use biological substance (a table, a cloth, a house, a meal ...) A criterion to draw the boundary is whether or not the species affiliation has some structural or functional implication.^^xsd:string</para>
    ///   <para>rdfs:label : structured nonbiological compound^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#StructuredNonbiologicalCompound">biotop:StructuredNonbiologicalCompound</a>
    /// </summary>
    let StructuredNonbiologicalCompound =
        _prefixId.prefix "StructuredNonbiologicalCompound"

    /// <summary>
    ///   <para>ru:definition : SubatomicEntityByChargePartition
    ///
    /// ontologically irrelevant node: disjoint partition: subatomic entity by charge^^xsd:string</para>
    ///   <para>rdfs:label : *^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#SubatomicEntityByChargePartition">biotop:SubatomicEntityByChargePartition</a>
    /// </summary>
    let SubatomicEntityByChargePartition =
        _prefixId.prefix "SubatomicEntityByChargePartition"

    /// <summary>
    ///   <para>ru:definition : Parts of Atoms.^^xsd:string</para>
    ///   <para>rdfs:label : subatomic particle^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#SubatomicParticle">biotop:SubatomicParticle</a>
    /// </summary>
    let SubatomicParticle = _prefixId.prefix "SubatomicParticle"

    /// <summary>
    ///   <para>rdfs:label : subfamily drosophilinae value region^^xsd:string</para>
    ///   <para>rdfs:comment : EXAMPLE OF TAXON REGION^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#SubfamilyDrosophilinaeValueRegion">biotop:SubfamilyDrosophilinaeValueRegion</a>
    /// </summary>
    let SubfamilyDrosophilinaeValueRegion =
        _prefixId.prefix "SubfamilyDrosophilinaeValueRegion"

    /// <summary>
    ///   <para>ru:definition : the role an animal or human plays as receiver of health care^^xsd:string</para>
    ///   <para>rdfs:label : subject of care role^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#SubjectOfCareRole">biotop:SubjectOfCareRole</a>
    /// </summary>
    let SubjectOfCareRole = _prefixId.prefix "SubjectOfCareRole"
    /// <summary>
    ///   <para>rdfs:label : submolecular group^^xsd:string</para>
    ///   <para>rdfs:comment : A submolecular group or moiety is a group of covalently bound atoms that occurs only as part of a molecule^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#SubmolecularGroup">biotop:SubmolecularGroup</a>
    /// </summary>
    let SubmolecularGroup = _prefixId.prefix "SubmolecularGroup"

    /// <summary>
    ///   <para>rdfs:label : subphylum saccharomycotina value region^^xsd:string</para>
    ///   <para>rdfs:comment : EXAMPLE OF TAXON REGION^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#SubphylumSaccharomycotinaValueRegion">biotop:SubphylumSaccharomycotinaValueRegion</a>
    /// </summary>
    let SubphylumSaccharomycotinaValueRegion =
        _prefixId.prefix "SubphylumSaccharomycotinaValueRegion"

    /// <summary>
    ///   <para>rdfs:label : subphylum vertebrata value region^^xsd:string</para>
    ///   <para>rdfs:comment : EXAMPLE OF TAXON REGION^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#SubphylumVertebrataValueRegion">biotop:SubphylumVertebrataValueRegion</a>
    /// </summary>
    let SubphylumVertebrataValueRegion =
        _prefixId.prefix "SubphylumVertebrataValueRegion"

    /// <summary>
    ///   <para>ru:definition : action in which molecular entities interact^^xsd:string</para>
    ///   <para>rdfs:label : substance interaction^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#SubstanceInteraction">biotop:SubstanceInteraction</a>
    /// </summary>
    let SubstanceInteraction = _prefixId.prefix "SubstanceInteraction"
    /// <summary>
    ///   <para>ru:definition : Fusion of cells ^^xsd:string</para>
    ///   <para>rdfs:label : syncytium^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#Syncytium">biotop:Syncytium</a>
    /// </summary>
    let Syncytium = _prefixId.prefix "Syncytium"
    /// <summary>
    ///   <para>ru:definition : The quality of one or more biological organisms, as well as of parts of organism of partaining to a biological taxon. [steschu20080127]^^xsd:string</para>
    ///   <para>rdfs:label : taxon quality^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#TaxonQuality">biotop:TaxonQuality</a>
    /// </summary>
    let TaxonQuality = _prefixId.prefix "TaxonQuality"
    /// <summary>
    ///   <para>ru:definition : abstract region in which the values of biological taxa are located (cf. Schulz et.al ISMB 2008). Biological taxa can be ascribed not only to organisms but also to ogranism parts, derivates, as well as populations.
    ///
    /// ^^xsd:string</para>
    ///   <para>rdfs:label : taxon value region^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#TaxonValueRegion">biotop:TaxonValueRegion</a>
    /// </summary>
    let TaxonValueRegion = _prefixId.prefix "TaxonValueRegion"
    let TemporalEntity = _prefixId.prefix "TemporalEntity"
    /// <summary>
    ///   <para>ru:definition : 1. The role of a continuant participating in a process with an expected positive impact on a dysfunctional biological system.
    /// 2. The role of a process with an expected positive impact on a dysfunctional biological system.^^xsd:string</para>
    ///   <para>rdfs:label : therapeutic role^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#TherapeuticRole">biotop:TherapeuticRole</a>
    /// </summary>
    let TherapeuticRole = _prefixId.prefix "TherapeuticRole"
    /// <summary>
    ///   <para>owl:priorVersion : temporal entity^^xsd:string</para>
    ///   <para>ru:definition : Point or interval on the time axis^^xsd:string</para>
    ///   <para>rdfs:label : time^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#Time">biotop:Time</a>
    /// </summary>
    let Time = _prefixId.prefix "Time"
    /// <summary>
    ///   <para>ru:definition : the interval between two time points^^xsd:string</para>
    ///   <para>rdfs:label : time interval^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#TimeInterval">biotop:TimeInterval</a>
    /// </summary>
    let TimeInterval = _prefixId.prefix "TimeInterval"
    /// <summary>
    ///   <para>ru:definition : Aggregate of an arbitrary number of congeneric cells (cells with identical specialized characteristics), embedded into an amount of matter (matrix) that work together to perform a specific function.^^xsd:string</para>
    ///   <para>rdfs:label : tissue^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#Tissue">biotop:Tissue</a>
    /// </summary>
    let Tissue = _prefixId.prefix "Tissue"
    /// <summary>
    ///   <para>ru:definition : process occurring in a tissue^^xsd:string</para>
    ///   <para>rdfs:label : tissue process^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#TissueProcess">biotop:TissueProcess</a>
    /// </summary>
    let TissueProcess = _prefixId.prefix "TissueProcess"
    /// <summary>
    ///   <para>ru:definition : action with the intention to produce a positive effect on a biological organism or in which a malfunctioning is relieved or disrupted.^^xsd:string</para>
    ///   <para>rdfs:label : treating^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#Treating">biotop:Treating</a>
    /// </summary>
    let Treating = _prefixId.prefix "Treating"
    /// <summary>
    ///   <para>ru:definition : action with the intention to relieve or disrupt a malfunctioning of a biological entity^^xsd:string</para>
    ///   <para>rdfs:label : treating condition^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#TreatingCondition">biotop:TreatingCondition</a>
    /// </summary>
    let TreatingCondition = _prefixId.prefix "TreatingCondition"
    /// <summary>
    ///   <para>ru:definition : action with the intention to produce a positive effect on a biological organism^^xsd:string</para>
    ///   <para>rdfs:label : treating organism^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#TreatingOrganism">biotop:TreatingOrganism</a>
    /// </summary>
    let TreatingOrganism = _prefixId.prefix "TreatingOrganism"

    /// <summary>
    ///   <para>ru:definition : surface or plane in a biological entity^^xsd:string</para>
    ///   <para>rdfs:label : two dimensional biological entity^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#TwoDimensionalBiologicalEntity">biotop:TwoDimensionalBiologicalEntity</a>
    /// </summary>
    let TwoDimensionalBiologicalEntity =
        _prefixId.prefix "TwoDimensionalBiologicalEntity"

    /// <summary>
    ///   <para>ru:definition : plane bounding a three-dimensional biological entity^^xsd:string</para>
    ///   <para>rdfs:label : two dimensional boundary^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#TwoDimensionalBoundary">biotop:TwoDimensionalBoundary</a>
    /// </summary>
    let TwoDimensionalBoundary = _prefixId.prefix "TwoDimensionalBoundary"
    /// <summary>
    ///   <para>ru:definition : plane^^xsd:string</para>
    ///   <para>rdfs:label : two dimensional physical entity^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#TwoDimensionalPhysicalEntity">biotop:TwoDimensionalPhysicalEntity</a>
    /// </summary>
    let TwoDimensionalPhysicalEntity = _prefixId.prefix "TwoDimensionalPhysicalEntity"
    /// <summary>
    ///   <para>ru:definition : Organisms that (always or in certain initial stages) consist of a single cell. We conceive organisms in a material sense. Therefore we do not assume any ontological difference between a monocellular organism and the cell it is made of.^^xsd:string</para>
    ///   <para>rdfs:label : unicellular organism^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#UnicellularOrganism">biotop:UnicellularOrganism</a>
    /// </summary>
    let UnicellularOrganism = _prefixId.prefix "UnicellularOrganism"
    /// <summary>
    ///   <para>ru:definition : action that relates a user with an object he/she uses^^xsd:string</para>
    ///   <para>rdfs:label : using action^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#UsingAction">biotop:UsingAction</a>
    /// </summary>
    let UsingAction = _prefixId.prefix "UsingAction"
    /// <summary>
    ///   <para>ru:definition : A value region is an abstract region in which (non quantitative) values of qualities are located.^^xsd:string</para>
    ///   <para>rdfs:label : value region^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#ValueRegion">biotop:ValueRegion</a>
    /// </summary>
    let ValueRegion = _prefixId.prefix "ValueRegion"
    /// <summary>
    ///   <para>rdfs:label : vertebrate^^xsd:string</para>
    ///   <para>rdfs:comment : one vertebrate^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#Vertebrate">biotop:Vertebrate</a>
    /// </summary>
    let Vertebrate = _prefixId.prefix "Vertebrate"
    /// <summary>
    ///   <para>rdfs:label : vertebrate population^^xsd:string</para>
    ///   <para>rdfs:comment : EXAMPLE OF POPULATION^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#VertebratePopulation">biotop:VertebratePopulation</a>
    /// </summary>
    let VertebratePopulation = _prefixId.prefix "VertebratePopulation"
    /// <summary>
    ///   <para>ru:definition : Sub-microscopic agent that requires a host cell to grow and reproduce. Viruses resemble other organisms in that they possess genes, and can evolve in infected cells by natural selection.  We therefore classify viruses as organisms, although there is an open debate.^^xsd:string</para>
    ///   <para>rdfs:label : virus^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#Virus">biotop:Virus</a>
    /// </summary>
    let Virus = _prefixId.prefix "Virus"
    /// <summary>
    ///   <para>rdfs:label : virus population^^xsd:string</para>
    ///   <para>rdfs:comment : EXAMPLE OF POPULATION^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#VirusPopulation">biotop:VirusPopulation</a>
    /// </summary>
    let VirusPopulation = _prefixId.prefix "VirusPopulation"
    /// <summary>
    ///   <para>ru:definition : The role a certain substance can play in an organism. Vitamins are organic compounds that are essential to an organism for metabolic reactions. They are not food. Vitamin does not include essential fatty acids or essential amino acids^^xsd:string</para>
    ///   <para>rdfs:label : vitamin role^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#VitaminRole">biotop:VitaminRole</a>
    /// </summary>
    let VitaminRole = _prefixId.prefix "VitaminRole"
    /// <summary>
    ///   <para>ru:definition : A water molecule is composed by one oxygen molecule and two hydrogen molecules^^xsd:string</para>
    ///   <para>rdfs:label : water molecule^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#WaterMolecule">biotop:WaterMolecule</a>
    /// </summary>
    let WaterMolecule = _prefixId.prefix "WaterMolecule"
    /// <summary>
    ///   <para>ru:definition : (wikipedia) disturbance that propagates through space and time, usually with transference of energy^^xsd:string</para>
    ///   <para>rdfs:label : wave^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#Wave">biotop:Wave</a>
    /// </summary>
    let Wave = _prefixId.prefix "Wave"
    /// <summary>
    ///   <para>rdfs:label : well formed biological structure^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#WellFormedBiologicalStructure">biotop:WellFormedBiologicalStructure</a>
    /// </summary>
    let WellFormedBiologicalStructure = _prefixId.prefix "WellFormedBiologicalStructure"
    /// <summary>
    ///   <para>rdfs:label : yeast cell^^xsd:string</para>
    ///   <para>rdfs:comment : Unicellular Fungi.^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#YeastCell">biotop:YeastCell</a>
    /// </summary>
    let YeastCell = _prefixId.prefix "YeastCell"
    /// <summary>
    ///   <para>rdfs:label : yeast population^^xsd:string</para>
    ///   <para>rdfs:comment : EXAMPLE OF POPULATION^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#YeastPopulation">biotop:YeastPopulation</a>
    /// </summary>
    let YeastPopulation = _prefixId.prefix "YeastPopulation"
    /// <summary>
    ///   <para>ru:definition : abstractPartOf (inverse: hasAbstractPart) Relates parts and wholes of abstract entities. Abstract entities are neither processes, material objects, regions or spaces. Typical abstract entities are pieces of information.
    ///
    /// Example: a header is an abstract part of a jpg file.^^xsd:string</para>
    ///   <para>rdfs:label : abstract part of^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#abstractPartOf">biotop:abstractPartOf</a>
    /// </summary>
    let abstractPartOf = _prefixId.prefix "abstractPartOf"
    /// <summary>
    ///   <para>ru:definition : Relation in which immaterial entities (information entities, roles, qualities) are involved.
    ///
    /// abstractlyRelatedTo is meant as an organizing parent. It should not be asserted.^^xsd:string</para>
    ///   <para>rdfs:label : abstractly related to^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#abstractlyRelatedTo">biotop:abstractlyRelatedTo</a>
    /// </summary>
    let abstractlyRelatedTo = _prefixId.prefix "abstractlyRelatedTo"
    /// <summary>
    ///   <para>ru:definition : agentIn (inverse: hasAgent) relates a participant with a process, with the condition that this participant is causally active in the relevant process.
    /// This is the reason why agentIn is subsumed by the relation causedBy.
    ///
    /// Example: A physician is the agent in a opeeration process; a solvent is the agent in a solving process. ^^xsd:string</para>
    ///   <para>rdfs:label : agent in^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#agentIn">biotop:agentIn</a>
    /// </summary>
    let agentIn = _prefixId.prefix "agentIn"
    /// <summary>
    ///   <para>ru:definition : Contiguous with a clear bona fide boundary between the connected parts.
    /// Schulz S, Hahn U. Towards the ontological foundations of symbolic biological theories.
    /// Artif Intell Med. 2007 Mar;39(3):237-50. PMID: 17321118^^xsd:string</para>
    ///   <para>rdfs:label : attached to^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#attachedTo">biotop:attachedTo</a>
    /// </summary>
    let attachedTo = _prefixId.prefix "attachedTo"
    /// <summary>
    ///   <para>ru:definition : inheresIn (inverse: bearerOf) relates a quality, role, function, disposition, or information object with the physical entity it depends on.
    ///
    /// (Note that for processes there is a separate relation pair "hasProcessQuality" and "processQualityOf")
    ///
    /// Example: a color inheres in a paint, the ability to fly inheres in a bird, or a pdf file inheres in a USB stick.^^xsd:string</para>
    ///   <para>rdfs:label : bearer of^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#bearerOf">biotop:bearerOf</a>
    /// </summary>
    let bearerOf = _prefixId.prefix "bearerOf"
    /// <summary>
    ///   <para>ru:definition : A is a branch of B if it is contiguous with B and if some flow of matter or energy of information flows form B to A.
    /// Schulz S, Hahn U. Towards the ontological foundations of symbolic biological theories.
    /// Artif Intell Med. 2007 Mar;39(3):237-50. PMID: 17321118^^xsd:string</para>
    ///   <para>rdfs:label : branch of^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#branchOf">biotop:branchOf</a>
    /// </summary>
    let branchOf = _prefixId.prefix "branchOf"
    /// <summary>
    ///   <para>ru:definition : Expresses a causal chain between material or processual entities.
    ///
    /// causallyRelatedTo is meant as an organizing parent. It should not be asserted.^^xsd:string</para>
    ///   <para>rdfs:label : causally related to^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#causallyRelatedTo">biotop:causallyRelatedTo</a>
    /// </summary>
    let causallyRelatedTo = _prefixId.prefix "causallyRelatedTo"
    /// <summary>
    ///   <para>ru:definition : Causation of a process is here understood as the disjunction between agency (a continuant causes a process) and as the realization of a disposition, i.e. a disposition is considered the cause of a process.
    ///  ^^xsd:string</para>
    ///   <para>rdfs:label : caused by^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#causedBy">biotop:causedBy</a>
    /// </summary>
    let causedBy = _prefixId.prefix "causedBy"
    /// <summary>
    ///   <para>ru:definition : Causation of a process is here understood as the disjunction between agency (a continuant causes a process) and as the realization of a disposition, i.e. a disposition is considered the cause of a process.
    ///  ^^xsd:string</para>
    ///   <para>rdfs:label : causes^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#causes">biotop:causes</a>
    /// </summary>
    let causes = _prefixId.prefix "causes"
    /// <summary>
    ///   <para>ru:definition : The non-transitive relation hasComponentPart (inverse: componentPartOf) relates components with a compound. Components strictly partition the compound, and the compound is the mereological sum of its components. A loss of some component affects the integrity of the compound, and possibly the type it instantiates, e.g. a complete vs. a defective organism.
    ///
    /// The choice of what is a component of a compound is somewhat arbitrary, because there are several ways to divide a whole into parts. Strictly spoken, this relation should refer to some partition.
    ///
    /// Components should be - at least - partly bona fide parts. The use of this relation also requires the commitment to an underlying granularity level. So could we consider the codons (base triples) as the components of a DNA molecule but also the single nucleotides. Note that components of a compound may also be portions of matter.
    ///
    /// Examples: my liver is a component of my organism, a carboxy group is a component of some organic acid molecule.^^xsd:string</para>
    ///   <para>rdfs:label : component part of^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#componentPartOf">biotop:componentPartOf</a>
    /// </summary>
    let componentPartOf = _prefixId.prefix "componentPartOf"
    /// <summary>
    ///   <para>ru:definition : ContiguousWith describes the connection between two material objects that abut and can transmit forces.
    ///
    ///  ^^xsd:string</para>
    ///   <para>rdfs:label : contiguous with^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#contiguousWith">biotop:contiguousWith</a>
    /// </summary>
    let contiguousWith = _prefixId.prefix "contiguousWith"
    /// <summary>
    ///   <para>ru:definition : Contiguous with a clear bona fide boundary between the connected parts.
    /// Schulz S, Hahn U. Towards the ontological foundations of symbolic biological theories.
    /// Artif Intell Med. 2007 Mar;39(3):237-50. PMID: 17321118 ^^xsd:string</para>
    ///   <para>rdfs:label : continuous with^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#continuousWith">biotop:continuousWith</a>
    /// </summary>
    let continuousWith = _prefixId.prefix "continuousWith"
    /// <summary>
    ///   <para>ru:definition : The relation coocurring with relates two processes if their temporal extensions overlap.^^xsd:string</para>
    ///   <para>rdfs:label : cooccurring with^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#cooccurringWith">biotop:cooccurringWith</a>
    /// </summary>
    let cooccurringWith = _prefixId.prefix "cooccurringWith"
    /// <summary>
    ///   <para>ru:definition : denotedBy (inverse: denotes) relates entities with symbols, which are information entities. In contrast to encoding, the denoted entity is completely independent on the denoting one.
    ///
    /// Example: The inflamation of a sinus is denoted by the word "Sinusitis", as well as by the ICD code "J10"^^xsd:string</para>
    ///   <para>rdfs:label : denoted by^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#denotedBy">biotop:denotedBy</a>
    /// </summary>
    let denotedBy = _prefixId.prefix "denotedBy"
    /// <summary>
    ///   <para>ru:definition : denotedBy (inverse: denotes) relates entities with symbols, which are information entities. In contrast to encoding, the denoted entity is completely independent on the denoting one.
    ///
    /// Example: The inflamation of a sinus is denoted by the word "Sinusitis", as well as by the ICD code "J10"^^xsd:string</para>
    ///   <para>rdfs:label : denotes^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#denotes">biotop:denotes</a>
    /// </summary>
    let denotes = _prefixId.prefix "denotes"
    /// <summary>
    ///   <para>ru:definition : DerivesFrom (inverse: derivedInto) holds between  distinct material objects  when one succeeds the other across a temporal divide in such a way that at least a biologically significant portion of the matter of the earlier object is included into the later.
    ///
    /// There is some instant of time t such that the first object exists only prior to and the second one  only subsequent to t.
    ///
    /// These relations are borrowed from the OBO Relation Ontology
    ///
    /// Example:
    /// "Three simple kinds of instance-level derivation can then be distinguished (Figure 3): first, the succession of one single continuant by another single continuant across a temporal threshold (for example, this blastocyst derives from this zygote); second, the fusion of two or more continuants into one continuant (for example, this zygote derives from this sperm and from this ovum); and third, the fission of an earlier single continuant to create a plurality of later continuants (for example, these promyelocytes derive from this myeoloblast). " from http://genomebiology.com/2005/6/5/R46^^xsd:string</para>
    ///   <para>rdfs:label : derived into^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#derivedInto">biotop:derivedInto</a>
    /// </summary>
    let derivedInto = _prefixId.prefix "derivedInto"
    /// <summary>
    ///   <para>ru:definition : DerivesFrom (inverse: derivedInto) holds between  distinct material objects  when one succeeds the other across a temporal divide in such a way that at least a biologically significant portion of the matter of the earlier object is included into the later.
    ///
    /// There is some instant of time t such that the first object exists only prior to and the second one  only subsequent to t.
    ///
    /// These relations are borrowed from the OBO Relation Ontology
    ///
    /// Example:
    /// "Three simple kinds of instance-level derivation can then be distinguished (Figure 3): first, the succession of one single continuant by another single continuant across a temporal threshold (for example, this blastocyst derives from this zygote); second, the fusion of two or more continuants into one continuant (for example, this zygote derives from this sperm and from this ovum); and third, the fission of an earlier single continuant to create a plurality of later continuants (for example, these promyelocytes derive from this myeoloblast). " from http://genomebiology.com/2005/6/5/R46^^xsd:string</para>
    ///   <para>rdfs:label : derives from^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#derivesFrom">biotop:derivesFrom</a>
    /// </summary>
    let derivesFrom = _prefixId.prefix "derivesFrom"
    /// <summary>
    ///   <para>ru:definition : EncodedBy (inverse: encodes) relates entities with symbols, which are information entities. In contrast to denotation, encoding entails that the makeup of the encoded entity is determined by the code. There is a dependence of the former on the latter. Note that the association of human-made codes with entities (e.g. for coding and classification systems like ICD-10) is nothing more than denotation and is therefore not in the scope of the encodedBy (encodes) relation.
    ///
    /// Example: A material gene sequence is related to a sequence of nucleotide symbols (like ACCGATTGA) ^^xsd:string</para>
    ///   <para>rdfs:label : encodedBy^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#encodedBy">biotop:encodedBy</a>
    /// </summary>
    let encodedBy = _prefixId.prefix "encodedBy"
    /// <summary>
    ///   <para>ru:definition : EncodedBy (inverse: encodes) relates entities with symbols, which are information entities. In contrast to denotation, encoding entails that the makeup of the encoded entity is determined by the code. There is a dependence of the former on the latter. Note that the association of human-made codes with entities (e.g. for coding and classification systems like ICD-10) is nothing more than denotation and is therefore not in the scope of the encodedBy (encodes) relation.
    ///
    /// Example: A material gene sequence is related to a sequence of nucleotide symbols (like ACCGATTGA) ^^xsd:string</para>
    ///   <para>rdfs:label : encodes^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#encodes">biotop:encodes</a>
    /// </summary>
    let encodes = _prefixId.prefix "encodes"
    /// <summary>
    ///   <para>rdfs:label : feature of^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#featureOf">biotop:featureOf</a>
    /// </summary>
    let featureOf = _prefixId.prefix "featureOf"
    /// <summary>
    ///   <para>ru:definition : hasGranularPart (inverse: granularPartOf) relate  Pluralities with their constituents. The constituents are of the same sort.
    ///
    /// Generally pluralities have a high number of grains. The loss of a grain has no effect on the sortality of the identity of the plurality.
    ///
    /// Example: A cow is a granular part of a herd of cows. A water molecule is a granular part of some amount of water^^xsd:string</para>
    ///   <para>rdfs:label : granular part of^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#granularPartOf">biotop:granularPartOf</a>
    /// </summary>
    let granularPartOf = _prefixId.prefix "granularPartOf"
    /// <summary>
    ///   <para>ru:definition : abstractPartOf (inverse: hasAbstractPart) Relates parts and wholes of abstract entities. Abstract entities are neither processes, material objects, regions or spaces. Typical abstract entities are pieces of information.
    ///
    /// For instance, a header is an abstract part of a jpg file.^^xsd:string</para>
    ///   <para>rdfs:label : has abstract part^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#hasAbstractPart">biotop:hasAbstractPart</a>
    /// </summary>
    let hasAbstractPart = _prefixId.prefix "hasAbstractPart"
    /// <summary>
    ///   <para>ru:definition : agentIn (inverse: hasAgent) relates a participant with a process, with the condition that this participant is causally active in the relevant process.
    /// This is the reason why agentIn is subsumed by the relation causedBy.
    ///
    /// Example: A physician is the agent in a opeeration process; a solvent is the agent in a solving process. ^^xsd:string</para>
    ///   <para>rdfs:label : has agent^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#hasAgent">biotop:hasAgent</a>
    /// </summary>
    let hasAgent = _prefixId.prefix "hasAgent"
    /// <summary>
    ///   <para>ru:definition : B hasBranch A if it is contiguous with B and if some flow of matter or energy of information flows form B to A.
    /// Schulz S, Hahn U. Towards the ontological foundations of symbolic biological theories.
    /// Artif Intell Med. 2007 Mar;39(3):237-50. PMID: 17321118^^xsd:string</para>
    ///   <para>rdfs:label : has branch^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#hasBranch">biotop:hasBranch</a>
    /// </summary>
    let hasBranch = _prefixId.prefix "hasBranch"
    /// <summary>
    ///   <para>ru:definition : The non-transitive relation hasComponentPart (inverse: componentPartOf) relates components with a compound. Components strictly partition the compound, and the compound is the mereological sum of its components. A loss of some component affects the integrity of the compound, and possibly the type it instantiates, e.g. a complete vs. a defective organism.
    ///
    /// The choice of what is a component of a compound is somewhat arbitrary, because there are several ways to divide a whole into parts. Strictly spoken, this relation should refer to some partition.
    ///
    /// Components should be - at least - partly bona fide parts. The use of this relation also requires the commitment to an underlying granularity level. So could we consider the codons (base triples) as the components of a DNA molecule but also the single nucleotides. Note that components of a compound may also be portions of matter.
    ///
    /// Examples: my liver is a component of my organism, a carboxy group is a component of some organic acid molecule.^^xsd:string</para>
    ///   <para>rdfs:label : has component part^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#hasComponentPart">biotop:hasComponentPart</a>
    /// </summary>
    let hasComponentPart = _prefixId.prefix "hasComponentPart"
    /// <summary>
    ///   <para>ru:definition : hasDuration relates a process with the time interval it covers.^^xsd:string</para>
    ///   <para>rdfs:label : has duration^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#hasDuration">biotop:hasDuration</a>
    /// </summary>
    let hasDuration = _prefixId.prefix "hasDuration"
    /// <summary>
    ///   <para>rdfs:label : has feature^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#hasFeature">biotop:hasFeature</a>
    /// </summary>
    let hasFeature = _prefixId.prefix "hasFeature"
    /// <summary>
    ///   <para>ru:definition : hasGranularPart (inverse: granularPartOf) relate  Pluralities with their constituents. The constituents are of the same sort.
    ///
    /// Generally pluralities have a high number of grains. The loss of a grain has no effect on the sortality of the identity of the plurality.
    ///
    /// Example: A cow is a granular part of a herd of cows. A water molecule is a granular part of some amount of water^^xsd:string</para>
    ///   <para>rdfs:label : has granular part^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#hasGranularPart">biotop:hasGranularPart</a>
    /// </summary>
    let hasGranularPart = _prefixId.prefix "hasGranularPart"
    /// <summary>
    ///   <para>ru:definition : hasLocus (inverse: locusOf) is a very broad relation which relates an entity with the place it occurs, inheres, or is part of.
    ///
    /// See property chains: a participant of a process at a given time is located where the process is located.
    ///
    /// Example: A heart pumping process is located in a heart. ^^xsd:string</para>
    ///   <para>rdfs:label : has locus^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#hasLocus">biotop:hasLocus</a>
    /// </summary>
    let hasLocus = _prefixId.prefix "hasLocus"
    /// <summary>
    ///   <para>rdfs:label : has origin^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#hasOrigin">biotop:hasOrigin</a>
    /// </summary>
    let hasOrigin = _prefixId.prefix "hasOrigin"
    /// <summary>
    ///   <para>ru:definition : hasOriginalPart (inverse: originalPartOf).
    ///
    /// original parts of A are no longer parts of A but were parts of A when they came into existence.
    ///
    /// Example:
    /// Apples harvested from an apple tree, tissue samples in a lab. ^^xsd:string</para>
    ///   <para>rdfs:label : has original part^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#hasOriginalPart">biotop:hasOriginalPart</a>
    /// </summary>
    let hasOriginalPart = _prefixId.prefix "hasOriginalPart"
    /// <summary>
    ///   <para>ru:definition : originatingPhysicalPartOf (inverse: hasOriginatingPhysicalPart)
    ///
    /// An originating physical part is a proper physical part that has never ceased to be part of the object it is related to.
    ///
    /// Example: my brain is an originating physical part of my body ^^xsd:string</para>
    ///   <para>rdfs:label : has originating physical part^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#hasOriginatingPhysicalPart">biotop:hasOriginatingPhysicalPart</a>
    /// </summary>
    let hasOriginatingPhysicalPart = _prefixId.prefix "hasOriginatingPhysicalPart"
    /// <summary>
    ///   <para>ru:definition : outcomeOf (inverse: hasOutcome) relates a participant to a process. This participant either
    /// - a) comes into being during the process
    /// or - b) undergoes some change during the process, so that it instantiates a different class at the end of the process
    /// and it constitutes (one of) the main result(s) of the process
    ///
    /// Example: a Protein molecule is the outcome of a translation process.^^xsd:string</para>
    ///   <para>rdfs:label : has outcome^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#hasOutcome">biotop:hasOutcome</a>
    /// </summary>
    let hasOutcome = _prefixId.prefix "hasOutcome"
    /// <summary>
    ///   <para>ru:definition : HasParticipant (inverse: participatesIn) relates a process with a non processual entity which plays some role in the process. Process participants may exist during the whole process, remain unchanged or undergo changes; they may come into being or get out of being during the process.
    ///
    /// Process participation is distinguished from process location.
    ///
    /// Example:
    ///
    /// An urea molecule which is excreted in a renal filtration process is participant of this process.
    ///
    /// A person who undergoes an operation is participant of this process.^^xsd:string</para>
    ///   <para>rdfs:label : has participant^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#hasParticipant">biotop:hasParticipant</a>
    /// </summary>
    let hasParticipant = _prefixId.prefix "hasParticipant"
    /// <summary>
    ///   <para>ru:definition : patientIn (inverse: hasPatient) relates a participant with a process, with the condition that that this participant is not causally active.
    ///
    /// Example: A prey is the patient in a hunting process; a solute is the patient in a solving process. ^^xsd:string</para>
    ///   <para>rdfs:label : has patient^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#hasPatient">biotop:hasPatient</a>
    /// </summary>
    let hasPatient = _prefixId.prefix "hasPatient"
    /// <summary>
    ///   <para>ru:definition : hasPhysicalPart (inverse: physicalPartOf) obtains between physical objects. The distinction between parthood and locatedness is complex and does not obey strict criteria.
    /// This relation is reflexive, i.e. every physical object has itself as a physical part.
    ///
    /// Note that for abstract entities like information artefacts there is a separate relation pair "abstractPartOf" and "hasAbstractPart"
    ///
    /// For processes there are the relations "hasProcessualPart" and "processualPartOf"^^xsd:string</para>
    ///   <para>rdfs:label : has physical part^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#hasPhysicalPart">biotop:hasPhysicalPart</a>
    /// </summary>
    let hasPhysicalPart = _prefixId.prefix "hasPhysicalPart"
    /// <summary>
    ///   <para>ru:definition : hasPointInTome relates a processual entity with some point in the interval it occupies.
    /// If there is no temporal extension (process boundary) it relates it to the time it occurs. ^^xsd:string</para>
    ///   <para>rdfs:label : has point in time^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#hasPointInTime">biotop:hasPointInTime</a>
    /// </summary>
    let hasPointInTime = _prefixId.prefix "hasPointInTime"
    /// <summary>
    ///   <para>ru:definition : processQualityOf (abstract: hasProcessQuality) links a quality that further characterizes a process to this process. Process qualities are asserted where the process cannot sufficiently be described by the qualities of its participants only.
    ///
    /// Example: The process of heart beating has the process quality heart rate.^^xsd:string</para>
    ///   <para>rdfs:label : has process quality^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#hasProcessQuality">biotop:hasProcessQuality</a>
    /// </summary>
    let hasProcessQuality = _prefixId.prefix "hasProcessQuality"
    /// <summary>
    ///   <para>ru:definition : processRoleOf (abstract: hasProcessRole) links a role attributed to a process to this process. Process roles are asserted where the process cannot sufficiently be described by the roles of its participants only.
    ///
    /// Example: The process of injuring has the process role "allowed" in case of a surgical intervention agreed by both the patient and the doctor.^^xsd:string</para>
    ///   <para>rdfs:label : has process role^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#hasProcessRole">biotop:hasProcessRole</a>
    /// </summary>
    let hasProcessRole = _prefixId.prefix "hasProcessRole"
    /// <summary>
    ///   <para>ru:definition : hasProcessualPart (inverse: processualPartOf) relates a process with a subprocess (process part).
    ///
    /// Example: G1 phase is a processual part of the process mitosis.^^xsd:string</para>
    ///   <para>rdfs:label : has processual part^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#hasProcessualPart">biotop:hasProcessualPart</a>
    /// </summary>
    let hasProcessualPart = _prefixId.prefix "hasProcessualPart"
    /// <summary>
    ///   <para>ru:definition : hasProperPhysicalPart (inverse: properPhysicalPartOf) obtains between physical objects. The distinction between parthood and locatedness is complex and does not obey strict criteria.
    /// This relation is irreflexive, i.e. a physical object cannot have itself as a physical proper part.
    ///
    /// Note that for abstract entities like information artefacts there is a separate relation pair "abstractPartOf" and "hasAbstractPart"
    ///
    /// For processes there are the relations "hasProcessualPart" and "processualPartOf"
    ///
    /// Examples: my thumb is a proper physical part of my hand, this keyboard is a proper physical part of my computer.^^xsd:string</para>
    ///   <para>rdfs:label : has proper physical part^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#hasProperPhysicalPart">biotop:hasProperPhysicalPart</a>
    /// </summary>
    let hasProperPhysicalPart = _prefixId.prefix "hasProperPhysicalPart"
    /// <summary>
    ///   <para>ru:definition : Realization occurs if a disposition or function manifests itself as a process.
    ///
    /// Example: the disposition of a bird to fly (which exists even when it does not fly) is realized by its process of flying.  ^^xsd:string</para>
    ///   <para>rdfs:label : has realization^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#hasRealization">biotop:hasRealization</a>
    /// </summary>
    let hasRealization = _prefixId.prefix "hasRealization"
    /// <summary>
    ///   <para>ru:definition : inheresIn (inverse: bearerOf) relates a quality, role, function, disposition, or information object with the physical entity it depends on.
    ///
    /// (Note that for processes there is a separate relation pair "hasProcessQuality" and "processQualityOf")
    ///
    /// Example: a color inheres in a paint, the ability to fly inheres in a bird, or a pdf file inheres in a USB stick.^^xsd:string</para>
    ///   <para>rdfs:label : inheres in^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#inheresIn">biotop:inheresIn</a>
    /// </summary>
    let inheresIn = _prefixId.prefix "inheresIn"
    /// <summary>
    ///   <para>ru:definition : replaced by denotes^^xsd:string</para>
    ///   <para>rdfs:label : is about^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#isAbout">biotop:isAbout</a>
    /// </summary>
    let isAbout = _prefixId.prefix "isAbout"
    /// <summary>
    ///   <para>ru:definition : hasLocus (inverse: locusOf) is a very broad relation which relates an entity with the place it occurs, inheres, or is part of.
    ///
    /// See property chains: a participant of a process at a given time is located where the process is located.
    ///
    /// Example: A heart pumping process is located in a heart. ^^xsd:string</para>
    ///   <para>rdfs:label : locus of^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#locusOf">biotop:locusOf</a>
    /// </summary>
    let locusOf = _prefixId.prefix "locusOf"
    /// <summary>
    ///   <para>ru:definition : hasOriginalPart (inverse: originalPartOf).
    ///
    /// original parts of A are no longer parts of A but were parts of A when they came into existence.
    ///
    /// Example:
    /// Apples harvested from an apple tree, tissue samples in a lab. ^^xsd:string</para>
    ///   <para>rdfs:label : original part of^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#originalPartOf">biotop:originalPartOf</a>
    /// </summary>
    let originalPartOf = _prefixId.prefix "originalPartOf"
    /// <summary>
    ///   <para>ru:definition : originatesFrom relates two material objects one of which originates from the other in a very broad sense.
    ///
    /// It includes derivation (in the OBO RO sense), actual actual parts (provided they were always parts), as well as original (historical) parts.
    ///
    /// Examples: see Subrelations^^xsd:string</para>
    ///   <para>rdfs:label : originates from^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#originatesFrom">biotop:originatesFrom</a>
    /// </summary>
    let originatesFrom = _prefixId.prefix "originatesFrom"
    /// <summary>
    ///   <para>ru:definition : originatingPhysicalPartOf (inverse: hasOriginatingPhysicalPart)
    ///
    /// An originating physical part is a proper physical part that has never ceased to be part of the object it is related to.
    ///
    /// Example: my brain is an originating physical part of my body ^^xsd:string</para>
    ///   <para>rdfs:label : originating physical part of^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#originatingPhysicalPartOf">biotop:originatingPhysicalPartOf</a>
    /// </summary>
    let originatingPhysicalPartOf = _prefixId.prefix "originatingPhysicalPartOf"
    /// <summary>
    ///   <para>ru:definition : outcomeOf (inverse: hasOutcome) relates a participant to a process. This participant either
    /// - a) comes into being during the process
    /// or - b) undergoes some change during the process, so that it instantiates a different class at the end of the process
    /// and it constitutes (one of) the main result(s) of the process
    ///
    /// Example: a Protein molecule is the outcome of a translation process.^^xsd:string</para>
    ///   <para>rdfs:label : outcome of^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#outcomeOf">biotop:outcomeOf</a>
    /// </summary>
    let outcomeOf = _prefixId.prefix "outcomeOf"
    /// <summary>
    ///   <para>ru:definition : HasParticipant (inverse: participatesIn) relates a process with a non processual entity which plays some role in the process. Process participants may exist during the whole process, remain unchanged or undergo changes; they may come into being or get out of being during the process.
    ///
    /// Process participation is distinguished from process location.
    ///
    /// Example:
    ///
    /// An urea molecule which is excreted in a renal filtration process is participant of this process.
    ///
    /// A person who undergoes an operation is participant of this process.^^xsd:string</para>
    ///   <para>rdfs:label : participates in^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#participatesIn">biotop:participatesIn</a>
    /// </summary>
    let participatesIn = _prefixId.prefix "participatesIn"
    /// <summary>
    ///   <para>ru:definition : patientIn (inverse: hasPatient) relates a participant with a process, with the condition that that this participant is not causally active.
    ///
    /// Example: A prey is the patient in a hunting process; a solute is the patient in a solving process. ^^xsd:string</para>
    ///   <para>rdfs:label : patient in^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#patientIn">biotop:patientIn</a>
    /// </summary>
    let patientIn = _prefixId.prefix "patientIn"
    /// <summary>
    ///   <para>ru:definition : physicallylocatedIn (inverse: physical location of) relates two physical objects in terms of space. All point in space occupied by the first object are also occupied by the second object.
    ///
    /// Generally, this relation is further specificed in terms of parthood or containment
    ///
    /// Examples: my thumb is physically located in my hand, food is located in my stomach or also in the cavity of my stomach. A 10 Euro bill is located in my wallet. ^^xsd:string</para>
    ///   <para>rdfs:label : physical location of^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#physicalLocationOf">biotop:physicalLocationOf</a>
    /// </summary>
    let physicalLocationOf = _prefixId.prefix "physicalLocationOf"
    /// <summary>
    ///   <para>ru:definition : hasPhysicalPart (inverse: physicalPartOf) obtains between physical objects. The distinction between parthood and locatedness is complex and does not obey strict criteria.
    /// This relation is reflexive, i.e. every physical object has itself as a physical part.
    ///
    /// Note that for abstract entities like information artefacts there is a separate relation pair "abstractPartOf" and "hasAbstractPart"
    ///
    /// For processes there are the relations "hasProcessualPart" and "processualPartOf"^^xsd:string</para>
    ///   <para>rdfs:label : physical part of^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#physicalPartOf">biotop:physicalPartOf</a>
    /// </summary>
    let physicalPartOf = _prefixId.prefix "physicalPartOf"
    /// <summary>
    ///   <para>ru:definition : physicalAdjacentTo relates two physical objects that abut without physical overlap.
    ///
    /// Examples: see subrelations^^xsd:string</para>
    ///   <para>rdfs:label : physically adjacent to^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#physicallyAdjacentTo">biotop:physicallyAdjacentTo</a>
    /// </summary>
    let physicallyAdjacentTo = _prefixId.prefix "physicallyAdjacentTo"
    /// <summary>
    ///   <para>ru:definition : physicallyBounds (inverse: physically boundedBy) relates a three-dimensional physical object with its two dimensional boundary.
    ///
    /// Example: the surface of my liver physically bounds my liver. ^^xsd:string</para>
    ///   <para>rdfs:label : physically bounded by^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#physicallyBoundedBy">biotop:physicallyBoundedBy</a>
    /// </summary>
    let physicallyBoundedBy = _prefixId.prefix "physicallyBoundedBy"
    /// <summary>
    ///   <para>ru:definition : physicallyBounds (inverse: physically boundedBy) relates a three-dimensional physical object with its two dimensional boundary.
    ///
    /// Example: the surface of my liver physically bounds my liver. ^^xsd:string</para>
    ///   <para>rdfs:label : physically bounds^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#physicallyBounds">biotop:physicallyBounds</a>
    /// </summary>
    let physicallyBounds = _prefixId.prefix "physicallyBounds"
    /// <summary>
    ///   <para>ru:definition : physicallyConnectedTo (a symmetric relation) relates two spatially relevant entities (material entities or spaces) which overlap at least one point in space.
    ///
    /// Example: France is connected to Germany, my optic nerve is connected to my eyeball.^^xsd:string</para>
    ///   <para>rdfs:label : physically connected to^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#physicallyConnectedTo">biotop:physicallyConnectedTo</a>
    /// </summary>
    let physicallyConnectedTo = _prefixId.prefix "physicallyConnectedTo"
    /// <summary>
    ///   <para>ru:definition : Containment is location without parthood. E.g. Food is contained in the stomach.
    ///
    /// Schulz S, Hahn U. Towards the ontological foundations of symbolic biological theories.
    /// Artif Intell Med. 2007 Mar;39(3):237-50. PMID: 17321118^^xsd:string</para>
    ///   <para>rdfs:label : physically contained in^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#physicallyContainedIn">biotop:physicallyContainedIn</a>
    /// </summary>
    let physicallyContainedIn = _prefixId.prefix "physicallyContainedIn"
    /// <summary>
    ///   <para>ru:definition : Containment is location without parthood. E.g. Food is contained in the stomach.
    ///
    /// Schulz S, Hahn U. Towards the ontological foundations of symbolic biological theories.
    /// Artif Intell Med. 2007 Mar;39(3):237-50. PMID: 17321118  ^^xsd:string</para>
    ///   <para>rdfs:label : physically contains^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#physicallyContains">biotop:physicallyContains</a>
    /// </summary>
    let physicallyContains = _prefixId.prefix "physicallyContains"
    /// <summary>
    ///   <para>ru:definition : No sharing of parts and no sharing of boundaries.
    ///
    /// Schulz S, Hahn U. Towards the ontological foundations of symbolic biological theories.
    /// Artif Intell Med. 2007 Mar;39(3):237-50. PMID: 17321118^^xsd:string</para>
    ///   <para>rdfs:label : physically disconnected from^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#physicallyDisconnectedFrom">biotop:physicallyDisconnectedFrom</a>
    /// </summary>
    let physicallyDisconnectedFrom = _prefixId.prefix "physicallyDisconnectedFrom"
    /// <summary>
    ///   <para>rdfs:label : physically interconnects^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#physicallyInterconnects">biotop:physicallyInterconnects</a>
    /// </summary>
    let physicallyInterconnects = _prefixId.prefix "physicallyInterconnects"
    /// <summary>
    ///   <para>ru:definition : physicallylocatedIn (inverse: physical location of) relates two physical objects in terms of space. All point in space occupied by the first object are also occupied by the second object.
    ///
    /// Generally, this relation is further specificed in terms of parthood or containment
    ///
    /// Examples: my thumb is physically located in my hand, food is located in my stomach or also in the cavity of my stomach. A 10 Euro bill is located in my wallet. ^^xsd:string</para>
    ///   <para>rdfs:label : physically located in^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#physicallyLocatedIn">biotop:physicallyLocatedIn</a>
    /// </summary>
    let physicallyLocatedIn = _prefixId.prefix "physicallyLocatedIn"
    /// <summary>
    ///   <para>ru:definition : Partly or completely covering from outside (establishing boundaries, enclosing, confining, enclosing, circumscribing)
    /// ^^xsd:string</para>
    ///   <para>rdfs:label : physically surrounded by^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#physicallySurroundedBy">biotop:physicallySurroundedBy</a>
    /// </summary>
    let physicallySurroundedBy = _prefixId.prefix "physicallySurroundedBy"
    /// <summary>
    ///   <para>ru:definition : Partly or completely covering from outside (establishing boundaries, enclosing, confining, enclosing, circumscribing)
    /// ^^xsd:string</para>
    ///   <para>rdfs:label : physically surrounds^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#physicallySurrounds">biotop:physicallySurrounds</a>
    /// </summary>
    let physicallySurrounds = _prefixId.prefix "physicallySurrounds"
    /// <summary>
    ///   <para>ru:definition : crossing over and crossing through^^xsd:string</para>
    ///   <para>rdfs:label : physically traverses^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#physicallyTraverses">biotop:physicallyTraverses</a>
    /// </summary>
    let physicallyTraverses = _prefixId.prefix "physicallyTraverses"
    /// <summary>
    ///   <para>ru:definition : precedes (inverse: precededBy) relates two processes, one of which ends or totally happens before the second one begins.
    ///
    /// Example: fecundation preceeds embryonic development.^^xsd:string</para>
    ///   <para>rdfs:label : preceded by^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#precededBy">biotop:precededBy</a>
    /// </summary>
    let precededBy = _prefixId.prefix "precededBy"
    /// <summary>
    ///   <para>ru:definition : precedes (inverse: precededBy) relates two processes, one of which ends or totally happens before the second one begins.
    ///
    /// Example: fecundation preceeds embryonic development.^^xsd:string</para>
    ///   <para>rdfs:label : precedes^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#precedes">biotop:precedes</a>
    /// </summary>
    let precedes = _prefixId.prefix "precedes"
    /// <summary>
    ///   <para>ru:definition : processQualityOf (abstract: hasProcessQuality) links a quality that further characterizes a process to this process. Process qualities are asserted where the process cannot sufficiently be described by the qualities of its participants only.
    ///
    /// Example: The process of heart beating has the process quality heart rate.^^xsd:string</para>
    ///   <para>rdfs:label : process quality of^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#processQualityOf">biotop:processQualityOf</a>
    /// </summary>
    let processQualityOf = _prefixId.prefix "processQualityOf"
    /// <summary>
    ///   <para>ru:definition : processRoleOf (abstract: hasProcessRole) links a role attributed to a process to this process. Process roles are asserted where the process cannot sufficiently be described by the roles of its participants only.
    ///
    /// Example: The process of injuring has the process role "allowed" in case of a surgical intervention agreed by both the patient and the doctor.^^xsd:string</para>
    ///   <para>rdfs:label : process role of^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#processRoleOf">biotop:processRoleOf</a>
    /// </summary>
    let processRoleOf = _prefixId.prefix "processRoleOf"
    /// <summary>
    ///   <para>ru:definition : hasProcessualPart (inverse: processualPartOf) relates a process with a subprocess (process part).
    ///
    /// Example: G1 phase is a processual part of the process mitosis.^^xsd:string</para>
    ///   <para>rdfs:label : processual part of^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#processualPartOf">biotop:processualPartOf</a>
    /// </summary>
    let processualPartOf = _prefixId.prefix "processualPartOf"
    /// <summary>
    ///   <para>ru:definition : Relations that connect processes with other entities.
    ///
    /// processuallyRelatedTo is meant as an organizing parent. It should not be asserted.^^xsd:string</para>
    ///   <para>rdfs:label : processually related to^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#processuallyRelatedTo">biotop:processuallyRelatedTo</a>
    /// </summary>
    let processuallyRelatedTo = _prefixId.prefix "processuallyRelatedTo"
    /// <summary>
    ///   <para>ru:definition : hasProperPhysicalPart (inverse: properPhysicalPartOf) obtains between physical objects. The distinction between parthood and locatedness is complex and does not obey strict criteria.
    /// This relation is irreflexive, i.e. a physical object cannot have itself as a physical proper part.
    ///
    /// Note that for abstract entities like information artefacts there is a separate relation pair "abstractPartOf" and "hasAbstractPart"
    ///
    /// For processes there are the relations "hasProcessualPart" and "processualPartOf"
    ///
    /// Examples: my thumb is a proper physical part of my hand, this keyboard is a proper physical part of my computer.^^xsd:string</para>
    ///   <para>rdfs:label : proper physical part of^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#properPhysicalPartOf">biotop:properPhysicalPartOf</a>
    /// </summary>
    let properPhysicalPartOf = _prefixId.prefix "properPhysicalPartOf"
    /// <summary>
    ///   <para>ru:definition : qualityLocated (inverse: qualityLocationOf) relates a quality with an abstract value region. The underlying idea, borrowed from the DOLCE ontology, is that the attribute / value distinction - as ubiquitous in information systems - should at least be optionally expressible in ontologies.
    /// Value regions are abstract regions, in which qualitative just as quantitative "values" are located. Like in topographic regions, these entities can overlap or be disjoint.
    ///
    /// Example: "Color" as quality may be refined as "Red Color". It can be fully defined in by "quality located some RedColorRegion"   ^^xsd:string</para>
    ///   <para>rdfs:label : quality located^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#qualityLocated">biotop:qualityLocated</a>
    /// </summary>
    let qualityLocated = _prefixId.prefix "qualityLocated"
    /// <summary>
    ///   <para>ru:definition : qualityLocated (inverse: qualityLocationOf) relates a quality with an abstract value region. The underlying idea, borrowed from the DOLCE ontology, is that the attribute / value distinction - as ubiquitous in information systems - should at least be optionally expressible in ontologies.
    /// Value regions are abstract regions, in which qualitative just as quantitative "values" are located. Like in topographic regions, these entities can overlap or be disjoint.
    ///
    /// Example: "Color" as quality may be refined as "Red Color". It can be fully defined in by "quality located some RedColorRegion"   ^^xsd:string</para>
    ///   <para>rdfs:label : quality location of^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#qualityLocationOf">biotop:qualityLocationOf</a>
    /// </summary>
    let qualityLocationOf = _prefixId.prefix "qualityLocationOf"
    /// <summary>
    ///   <para>dce:source : Schulz S, Hahn U. Towards the ontological foundations of symbolic biological theories.
    /// 			Artif Intell Med. 2007 Mar;39(3):237-50. PMID: 17321118^^xsd:string</para>
    ///   <para>rdfs:label : ramification of^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#ramificationOf">biotop:ramificationOf</a>
    /// </summary>
    let ramificationOf = _prefixId.prefix "ramificationOf"
    /// <summary>
    ///   <para>dce:source : Schulz S, Hahn U. Towards the ontological foundations of symbolic biological theories.
    /// 			Artif Intell Med. 2007 Mar;39(3):237-50. PMID: 17321118^^xsd:string</para>
    ///   <para>rdfs:label : ramifies^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#ramifies">biotop:ramifies</a>
    /// </summary>
    let ramifies = _prefixId.prefix "ramifies"
    /// <summary>
    ///   <para>ru:definition : Realization occurs if a disposition or function manifests itself as a process.
    ///
    /// Example: the disposition of a bird to fly (which exists even when it does not fly) is realized by its process of flying.  ^^xsd:string</para>
    ///   <para>rdfs:label : realization of^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#realizationOf">biotop:realizationOf</a>
    /// </summary>
    let realizationOf = _prefixId.prefix "realizationOf"
    /// <summary>
    ///   <para>ru:definition : Most general relation that relates entities in terms of physical location.
    ///
    /// spatiallyRelatedTo is meant as an organizing parent. It should not be asserted. ^^xsd:string</para>
    ///   <para>rdfs:label : spatially related to^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#spatiallyRelatedTo">biotop:spatiallyRelatedTo</a>
    /// </summary>
    let spatiallyRelatedTo = _prefixId.prefix "spatiallyRelatedTo"
    /// <summary>
    ///   <para>ru:definition : The temporal arrangement of processes, events, durations and temporal measurements.
    ///
    /// temporallyRelatedTo is meant as an organizing parent. It should not be asserted.^^xsd:string</para>
    ///   <para>rdfs:label : temporally related to^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#temporallyRelatedTo">biotop:temporallyRelatedTo</a>
    /// </summary>
    let temporallyRelatedTo = _prefixId.prefix "temporallyRelatedTo"
    /// <summary>
    ///   <para>ru:definition : Abutting without mechanical connection.
    /// Schulz S, Hahn U. Towards the ontological foundations of symbolic biological theories.
    /// Artif Intell Med. 2007 Mar;39(3):237-50. PMID: 17321118 ^^xsd:string</para>
    ///   <para>rdfs:label : touches^^xsd:string</para>
    ///   <a href="http://purl.org/biotop/biotop.owl#touches">biotop:touches</a>
    /// </summary>
    let touches = _prefixId.prefix "touches"
