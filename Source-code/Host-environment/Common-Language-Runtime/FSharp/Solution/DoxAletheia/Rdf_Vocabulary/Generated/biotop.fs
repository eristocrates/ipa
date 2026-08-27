namespace http.purl.org.biotop.biotop.owl.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module biotop =
    let _namespace_iri = Namespace_Iri biotop |> NamespaceIRI

    /// <summary>
    ///   <para>biotop:AcquiredAbnormalStructure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"acquired abnormal structure"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#AcquiredAbnormalStructure">http://purl.org/biotop/biotop.owl#AcquiredAbnormalStructure</seealso>
    let AcquiredAbnormalStructure =
        Prefixed_Name(biotop, "AcquiredAbnormalStructure") |> PrefixedName

    /// <summary>
    ///   <para>biotop:AcquiredPathologicalCondition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"acquired pathological condition"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#AcquiredPathologicalCondition">http://purl.org/biotop/biotop.owl#AcquiredPathologicalCondition</seealso>
    let AcquiredPathologicalCondition =
        Prefixed_Name(biotop, "AcquiredPathologicalCondition") |> PrefixedName

    /// <summary>
    ///   <para>biotop:AcquiredPathologicalStaticProcessualEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"acquired pathological static processual entity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#AcquiredPathologicalStaticProcessualEntity">http://purl.org/biotop/biotop.owl#AcquiredPathologicalStaticProcessualEntity</seealso>
    let AcquiredPathologicalStaticProcessualEntity =
        Prefixed_Name(biotop, "AcquiredPathologicalStaticProcessualEntity") |> PrefixedName

    /// <summary>
    ///   <para>biotop:Action</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"action"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#Action">http://purl.org/biotop/biotop.owl#Action</seealso>
    let Action = Prefixed_Name(biotop, "Action") |> PrefixedName

    /// <summary>
    ///   <para>biotop:ActionOnBiologicalSystem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"action on biological system"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#ActionOnBiologicalSystem">http://purl.org/biotop/biotop.owl#ActionOnBiologicalSystem</seealso>
    let ActionOnBiologicalSystem =
        Prefixed_Name(biotop, "ActionOnBiologicalSystem") |> PrefixedName

    /// <summary>
    ///   <para>biotop:AdultOrganism</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"adult organism"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#AdultOrganism">http://purl.org/biotop/biotop.owl#AdultOrganism</seealso>
    let AdultOrganism = Prefixed_Name(biotop, "AdultOrganism") |> PrefixedName
    /// <summary>
    ///   <para>biotop:AdultValueRegion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>""adult" as the value of a developmental stage. E.g. a 4 year old dog has a quality which has its value located in "adult value region"."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"adult value region"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#AdultValueRegion">http://purl.org/biotop/biotop.owl#AdultValueRegion</seealso>
    let AdultValueRegion = Prefixed_Name(biotop, "AdultValueRegion") |> PrefixedName
    /// <summary>
    ///   <para>biotop:Affecting</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"affecting"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#Affecting">http://purl.org/biotop/biotop.owl#Affecting</seealso>
    let Affecting = Prefixed_Name(biotop, "Affecting") |> PrefixedName
    /// <summary>
    ///   <para>biotop:AgeQuality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"age quality"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#AgeQuality">http://purl.org/biotop/biotop.owl#AgeQuality</seealso>
    let AgeQuality = Prefixed_Name(biotop, "AgeQuality") |> PrefixedName
    /// <summary>
    ///   <para>biotop:Alga</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"alga"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#Alga">http://purl.org/biotop/biotop.owl#Alga</seealso>
    let Alga = Prefixed_Name(biotop, "Alga") |> PrefixedName
    /// <summary>
    ///   <para>biotop:AlphaParticle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"alpha particle"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#AlphaParticle">http://purl.org/biotop/biotop.owl#AlphaParticle</seealso>
    let AlphaParticle = Prefixed_Name(biotop, "AlphaParticle") |> PrefixedName

    /// <summary>
    ///   <para>biotop:AminoAcidMoleculeOrResidue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"(QCR) ro:hasPart some CarbonHydrogenSubstructure and ((hasComponent myx 2 CarboxyGroup) and (hasComponent min 1 CarboxyGroup) and (hasComponent exactly 1 AminoGroup)) or ((hasComponent max 2 AminoGroup) and (hasComponent min 1 AminoGroup) and (hasComponent exactly 1 CarboxyGroup))"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"In chemistry, an amino acid is any molecule that contains both amine and carboxyl functional groups. However, in biochemistry, this more general term is frequently used to refer to alpha amino acids (amino acids in which the amino and carboxylate functionalities are attached to the same carbon, called ?–carbon). Amino Acids have at least one amino and one carboxy group. Those having two carboxy groups have only one amino group and vice versa."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"amino acid molecule or residue"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#AminoAcidMoleculeOrResidue">http://purl.org/biotop/biotop.owl#AminoAcidMoleculeOrResidue</seealso>
    let AminoAcidMoleculeOrResidue =
        Prefixed_Name(biotop, "AminoAcidMoleculeOrResidue") |> PrefixedName

    /// <summary>
    ///   <para>biotop:AminoAcidOrPeptideMoleculeOrStructure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"amino acid or peptide molecule or structure"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#AminoAcidOrPeptideMoleculeOrStructure">http://purl.org/biotop/biotop.owl#AminoAcidOrPeptideMoleculeOrStructure</seealso>
    let AminoAcidOrPeptideMoleculeOrStructure =
        Prefixed_Name(biotop, "AminoAcidOrPeptideMoleculeOrStructure") |> PrefixedName

    /// <summary>
    ///   <para>biotop:AminoAcidSequence</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"amino acid sequence"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#AminoAcidSequence">http://purl.org/biotop/biotop.owl#AminoAcidSequence</seealso>
    let AminoAcidSequence = Prefixed_Name(biotop, "AminoAcidSequence") |> PrefixedName

    /// <summary>
    ///   <para>biotop:AminoAcidSequenceInformation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"amino acid sequence information"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#AminoAcidSequenceInformation">http://purl.org/biotop/biotop.owl#AminoAcidSequenceInformation</seealso>
    let AminoAcidSequenceInformation =
        Prefixed_Name(biotop, "AminoAcidSequenceInformation") |> PrefixedName

    /// <summary>
    ///   <para>biotop:AmountOfBodySubstance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"amount of body substance"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#AmountOfBodySubstance">http://purl.org/biotop/biotop.owl#AmountOfBodySubstance</seealso>
    let AmountOfBodySubstance =
        Prefixed_Name(biotop, "AmountOfBodySubstance") |> PrefixedName

    /// <summary>
    ///   <para>biotop:AmountOfPureSubstance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"amount of pure substance"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#AmountOfPureSubstance">http://purl.org/biotop/biotop.owl#AmountOfPureSubstance</seealso>
    let AmountOfPureSubstance =
        Prefixed_Name(biotop, "AmountOfPureSubstance") |> PrefixedName

    /// <summary>
    ///   <para>biotop:Amphibian</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"amphibian"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#Amphibian">http://purl.org/biotop/biotop.owl#Amphibian</seealso>
    let Amphibian = Prefixed_Name(biotop, "Amphibian") |> PrefixedName
    /// <summary>
    ///   <para>biotop:Analyzing</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"analyzing"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#Analyzing">http://purl.org/biotop/biotop.owl#Analyzing</seealso>
    let Analyzing = Prefixed_Name(biotop, "Analyzing") |> PrefixedName
    /// <summary>
    ///   <para>biotop:AnimalCell</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"animal cell"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#AnimalCell">http://purl.org/biotop/biotop.owl#AnimalCell</seealso>
    let AnimalCell = Prefixed_Name(biotop, "AnimalCell") |> PrefixedName

    /// <summary>
    ///   <para>biotop:AnimalExcludingHuman</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"animal excluding human"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#AnimalExcludingHuman">http://purl.org/biotop/biotop.owl#AnimalExcludingHuman</seealso>
    let AnimalExcludingHuman =
        Prefixed_Name(biotop, "AnimalExcludingHuman") |> PrefixedName

    /// <summary>
    ///   <para>biotop:AnimalIncludingHuman</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"animal including human"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#AnimalIncludingHuman">http://purl.org/biotop/biotop.owl#AnimalIncludingHuman</seealso>
    let AnimalIncludingHuman =
        Prefixed_Name(biotop, "AnimalIncludingHuman") |> PrefixedName

    /// <summary>
    ///   <para>biotop:AnimalLanguage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"animal language"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#AnimalLanguage">http://purl.org/biotop/biotop.owl#AnimalLanguage</seealso>
    let AnimalLanguage = Prefixed_Name(biotop, "AnimalLanguage") |> PrefixedName
    /// <summary>
    ///   <para>biotop:AnimalPopulation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"EXAMPLE OF POPULATION"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"animal population"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#AnimalPopulation">http://purl.org/biotop/biotop.owl#AnimalPopulation</seealso>
    let AnimalPopulation = Prefixed_Name(biotop, "AnimalPopulation") |> PrefixedName
    /// <summary>
    ///   <para>biotop:AntibioticRole</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"antibiotic role"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#AntibioticRole">http://purl.org/biotop/biotop.owl#AntibioticRole</seealso>
    let AntibioticRole = Prefixed_Name(biotop, "AntibioticRole") |> PrefixedName

    /// <summary>
    ///   <para>biotop:ArchaebacterialCell</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"archaebacterial cell"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#ArchaebacterialCell">http://purl.org/biotop/biotop.owl#ArchaebacterialCell</seealso>
    let ArchaebacterialCell =
        Prefixed_Name(biotop, "ArchaebacterialCell") |> PrefixedName

    /// <summary>
    ///   <para>biotop:ArtefactRole</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"artefact role"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#ArtefactRole">http://purl.org/biotop/biotop.owl#ArtefactRole</seealso>
    let ArtefactRole = Prefixed_Name(biotop, "ArtefactRole") |> PrefixedName
    /// <summary>
    ///   <para>biotop:Arthropod</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"one arthropod"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"arthropod"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#Arthropod">http://purl.org/biotop/biotop.owl#Arthropod</seealso>
    let Arthropod = Prefixed_Name(biotop, "Arthropod") |> PrefixedName

    /// <summary>
    ///   <para>biotop:ArthropodPopulation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"EXAMPLE OF POPULATION"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"arthropod population"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#ArthropodPopulation">http://purl.org/biotop/biotop.owl#ArthropodPopulation</seealso>
    let ArthropodPopulation =
        Prefixed_Name(biotop, "ArthropodPopulation") |> PrefixedName

    /// <summary>
    ///   <para>biotop:Atom</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"atom"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#Atom">http://purl.org/biotop/biotop.owl#Atom</seealso>
    let Atom = Prefixed_Name(biotop, "Atom") |> PrefixedName
    /// <summary>
    ///   <para>biotop:BacteriaPopulation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"EXAMPLE OF POPULATION"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"bacteria population"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#BacteriaPopulation">http://purl.org/biotop/biotop.owl#BacteriaPopulation</seealso>
    let BacteriaPopulation = Prefixed_Name(biotop, "BacteriaPopulation") |> PrefixedName
    /// <summary>
    ///   <para>biotop:BacterialCell</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"bacterial cell"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#BacterialCell">http://purl.org/biotop/biotop.owl#BacterialCell</seealso>
    let BacterialCell = Prefixed_Name(biotop, "BacterialCell") |> PrefixedName
    /// <summary>
    ///   <para>biotop:BacterialColony</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"bacterial colony"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#BacterialColony">http://purl.org/biotop/biotop.owl#BacterialColony</seealso>
    let BacterialColony = Prefixed_Name(biotop, "BacterialColony") |> PrefixedName
    /// <summary>
    ///   <para>biotop:BakersYeastCell</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"one saccharomyces cerevisiae cell"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"bakers yeast cell"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#BakersYeastCell">http://purl.org/biotop/biotop.owl#BakersYeastCell</seealso>
    let BakersYeastCell = Prefixed_Name(biotop, "BakersYeastCell") |> PrefixedName

    /// <summary>
    ///   <para>biotop:BakersYeastPopulation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"EXAMPLE OF POPULATION"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"bakers yeast population"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#BakersYeastPopulation">http://purl.org/biotop/biotop.owl#BakersYeastPopulation</seealso>
    let BakersYeastPopulation =
        Prefixed_Name(biotop, "BakersYeastPopulation") |> PrefixedName

    /// <summary>
    ///   <para>biotop:Behavior</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"behavior"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#Behavior">http://purl.org/biotop/biotop.owl#Behavior</seealso>
    let Behavior = Prefixed_Name(biotop, "Behavior") |> PrefixedName

    /// <summary>
    ///   <para>biotop:BioMolecularProcess</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"bio molecular process"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#BioMolecularProcess">http://purl.org/biotop/biotop.owl#BioMolecularProcess</seealso>
    let BioMolecularProcess =
        Prefixed_Name(biotop, "BioMolecularProcess") |> PrefixedName

    /// <summary>
    ///   <para>biotop:BioMolecularSequenceInformation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"bio molecular sequence information"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#BioMolecularSequenceInformation">http://purl.org/biotop/biotop.owl#BioMolecularSequenceInformation</seealso>
    let BioMolecularSequenceInformation =
        Prefixed_Name(biotop, "BioMolecularSequenceInformation") |> PrefixedName

    /// <summary>
    ///   <para>biotop:BioMolecularSequenceStructure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"bio molecular sequence structure"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#BioMolecularSequenceStructure">http://purl.org/biotop/biotop.owl#BioMolecularSequenceStructure</seealso>
    let BioMolecularSequenceStructure =
        Prefixed_Name(biotop, "BioMolecularSequenceStructure") |> PrefixedName

    /// <summary>
    ///   <para>biotop:BiologicalAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"biological action"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#BiologicalAction">http://purl.org/biotop/biotop.owl#BiologicalAction</seealso>
    let BiologicalAction = Prefixed_Name(biotop, "BiologicalAction") |> PrefixedName
    /// <summary>
    ///   <para>biotop:BiologicalBoundary</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"biological boundary"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#BiologicalBoundary">http://purl.org/biotop/biotop.owl#BiologicalBoundary</seealso>
    let BiologicalBoundary = Prefixed_Name(biotop, "BiologicalBoundary") |> PrefixedName
    /// <summary>
    ///   <para>biotop:BiologicalColony</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"biological colony"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#BiologicalColony">http://purl.org/biotop/biotop.owl#BiologicalColony</seealso>
    let BiologicalColony = Prefixed_Name(biotop, "BiologicalColony") |> PrefixedName
    /// <summary>
    ///   <para>biotop:BiologicalFunction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"biological function"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#BiologicalFunction">http://purl.org/biotop/biotop.owl#BiologicalFunction</seealso>
    let BiologicalFunction = Prefixed_Name(biotop, "BiologicalFunction") |> PrefixedName
    /// <summary>
    ///   <para>biotop:BiologicalLife</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"biological life"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#BiologicalLife">http://purl.org/biotop/biotop.owl#BiologicalLife</seealso>
    let BiologicalLife = Prefixed_Name(biotop, "BiologicalLife") |> PrefixedName

    /// <summary>
    ///   <para>biotop:BiologicalProcessualEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"biological processual entity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#BiologicalProcessualEntity">http://purl.org/biotop/biotop.owl#BiologicalProcessualEntity</seealso>
    let BiologicalProcessualEntity =
        Prefixed_Name(biotop, "BiologicalProcessualEntity") |> PrefixedName

    /// <summary>
    ///   <para>biotop:BiologicalSize</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"biological size"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#BiologicalSize">http://purl.org/biotop/biotop.owl#BiologicalSize</seealso>
    let BiologicalSize = Prefixed_Name(biotop, "BiologicalSize") |> PrefixedName

    /// <summary>
    ///   <para>biotop:BiologicalSizeValueRegion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"biological size value region"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#BiologicalSizeValueRegion">http://purl.org/biotop/biotop.owl#BiologicalSizeValueRegion</seealso>
    let BiologicalSizeValueRegion =
        Prefixed_Name(biotop, "BiologicalSizeValueRegion") |> PrefixedName

    /// <summary>
    ///   <para>biotop:BiologicalSpace</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"biological space"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#BiologicalSpace">http://purl.org/biotop/biotop.owl#BiologicalSpace</seealso>
    let BiologicalSpace = Prefixed_Name(biotop, "BiologicalSpace") |> PrefixedName

    /// <summary>
    ///   <para>biotop:BiologicalSystemRole</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"biological system role"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#BiologicalSystemRole">http://purl.org/biotop/biotop.owl#BiologicalSystemRole</seealso>
    let BiologicalSystemRole =
        Prefixed_Name(biotop, "BiologicalSystemRole") |> PrefixedName

    /// <summary>
    ///   <para>biotop:BiomedicalMaterialRole</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"biomedical material role"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#BiomedicalMaterialRole">http://purl.org/biotop/biotop.owl#BiomedicalMaterialRole</seealso>
    let BiomedicalMaterialRole =
        Prefixed_Name(biotop, "BiomedicalMaterialRole") |> PrefixedName

    /// <summary>
    ///   <para>biotop:Biomolecule</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"biomolecule"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#Biomolecule">http://purl.org/biotop/biotop.owl#Biomolecule</seealso>
    let Biomolecule = Prefixed_Name(biotop, "Biomolecule") |> PrefixedName
    /// <summary>
    ///   <para>biotop:Bird</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"bird"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#Bird">http://purl.org/biotop/biotop.owl#Bird</seealso>
    let Bird = Prefixed_Name(biotop, "Bird") |> PrefixedName
    /// <summary>
    ///   <para>biotop:Body</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"body"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#Body">http://purl.org/biotop/biotop.owl#Body</seealso>
    let Body = Prefixed_Name(biotop, "Body") |> PrefixedName
    /// <summary>
    ///   <para>biotop:BodyLiquid</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"body liquid"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#BodyLiquid">http://purl.org/biotop/biotop.owl#BodyLiquid</seealso>
    let BodyLiquid = Prefixed_Name(biotop, "BodyLiquid") |> PrefixedName
    /// <summary>
    ///   <para>biotop:BodySystem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"body system"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#BodySystem">http://purl.org/biotop/biotop.owl#BodySystem</seealso>
    let BodySystem = Prefixed_Name(biotop, "BodySystem") |> PrefixedName

    /// <summary>
    ///   <para>biotop:CandidaAlbicansCell</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"One candida albicans cell"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"candida albicans cell"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#CandidaAlbicansCell">http://purl.org/biotop/biotop.owl#CandidaAlbicansCell</seealso>
    let CandidaAlbicansCell =
        Prefixed_Name(biotop, "CandidaAlbicansCell") |> PrefixedName

    /// <summary>
    ///   <para>biotop:CandidaAlbicansPopulation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"EXAMPLE OF POPULATION"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"candida albicans population"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#CandidaAlbicansPopulation">http://purl.org/biotop/biotop.owl#CandidaAlbicansPopulation</seealso>
    let CandidaAlbicansPopulation =
        Prefixed_Name(biotop, "CandidaAlbicansPopulation") |> PrefixedName

    /// <summary>
    ///   <para>biotop:CanonicalProcessualEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"canonical processual entity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#CanonicalProcessualEntity">http://purl.org/biotop/biotop.owl#CanonicalProcessualEntity</seealso>
    let CanonicalProcessualEntity =
        Prefixed_Name(biotop, "CanonicalProcessualEntity") |> PrefixedName

    /// <summary>
    ///   <para>biotop:CanonicalStaticProcessualEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"a biological state that is considered "normal""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"canonical static processual entity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#CanonicalStaticProcessualEntity">http://purl.org/biotop/biotop.owl#CanonicalStaticProcessualEntity</seealso>
    let CanonicalStaticProcessualEntity =
        Prefixed_Name(biotop, "CanonicalStaticProcessualEntity") |> PrefixedName

    /// <summary>
    ///   <para>biotop:CanonicalValueRegion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"abstract region in which the value "canonical" of canonicity is located"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"canonical value region"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#CanonicalValueRegion">http://purl.org/biotop/biotop.owl#CanonicalValueRegion</seealso>
    let CanonicalValueRegion =
        Prefixed_Name(biotop, "CanonicalValueRegion") |> PrefixedName

    /// <summary>
    ///   <para>biotop:Canonicity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"canonicity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#Canonicity">http://purl.org/biotop/biotop.owl#Canonicity</seealso>
    let Canonicity = Prefixed_Name(biotop, "Canonicity") |> PrefixedName

    /// <summary>
    ///   <para>biotop:CanonicityValueRegion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"canonicity value region"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#CanonicityValueRegion">http://purl.org/biotop/biotop.owl#CanonicityValueRegion</seealso>
    let CanonicityValueRegion =
        Prefixed_Name(biotop, "CanonicityValueRegion") |> PrefixedName

    /// <summary>
    ///   <para>biotop:CarbohydrateMoleculeOrResidue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"carbohydrate molecule or residue"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#CarbohydrateMoleculeOrResidue">http://purl.org/biotop/biotop.owl#CarbohydrateMoleculeOrResidue</seealso>
    let CarbohydrateMoleculeOrResidue =
        Prefixed_Name(biotop, "CarbohydrateMoleculeOrResidue") |> PrefixedName

    /// <summary>
    ///   <para>biotop:CarbohydrateMonomer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"carbohydrate monomer"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#CarbohydrateMonomer">http://purl.org/biotop/biotop.owl#CarbohydrateMonomer</seealso>
    let CarbohydrateMonomer =
        Prefixed_Name(biotop, "CarbohydrateMonomer") |> PrefixedName

    /// <summary>
    ///   <para>biotop:CarbohydrateSequenceInformation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"carbohydrate sequence information"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#CarbohydrateSequenceInformation">http://purl.org/biotop/biotop.owl#CarbohydrateSequenceInformation</seealso>
    let CarbohydrateSequenceInformation =
        Prefixed_Name(biotop, "CarbohydrateSequenceInformation") |> PrefixedName

    /// <summary>
    ///   <para>biotop:CatalyticRole</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"catalytic role"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#CatalyticRole">http://purl.org/biotop/biotop.owl#CatalyticRole</seealso>
    let CatalyticRole = Prefixed_Name(biotop, "CatalyticRole") |> PrefixedName

    /// <summary>
    ///   <para>biotop:CategorizationSystem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"categorization system"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#CategorizationSystem">http://purl.org/biotop/biotop.owl#CategorizationSystem</seealso>
    let CategorizationSystem =
        Prefixed_Name(biotop, "CategorizationSystem") |> PrefixedName

    /// <summary>
    ///   <para>biotop:Causing</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"causing"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#Causing">http://purl.org/biotop/biotop.owl#Causing</seealso>
    let Causing = Prefixed_Name(biotop, "Causing") |> PrefixedName
    /// <summary>
    ///   <para>biotop:Cell</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"cell"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#Cell">http://purl.org/biotop/biotop.owl#Cell</seealso>
    let Cell = Prefixed_Name(biotop, "Cell") |> PrefixedName

    /// <summary>
    ///   <para>biotop:CellByLocusPartition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"*"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#CellByLocusPartition">http://purl.org/biotop/biotop.owl#CellByLocusPartition</seealso>
    let CellByLocusPartition =
        Prefixed_Name(biotop, "CellByLocusPartition") |> PrefixedName

    /// <summary>
    ///   <para>biotop:CellByTaxonPartition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"*"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#CellByTaxonPartition">http://purl.org/biotop/biotop.owl#CellByTaxonPartition</seealso>
    let CellByTaxonPartition =
        Prefixed_Name(biotop, "CellByTaxonPartition") |> PrefixedName

    /// <summary>
    ///   <para>biotop:CellByTypePartition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"*"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#CellByTypePartition">http://purl.org/biotop/biotop.owl#CellByTypePartition</seealso>
    let CellByTypePartition =
        Prefixed_Name(biotop, "CellByTypePartition") |> PrefixedName

    /// <summary>
    ///   <para>biotop:CellInVivo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"cell in vivo"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#CellInVivo">http://purl.org/biotop/biotop.owl#CellInVivo</seealso>
    let CellInVivo = Prefixed_Name(biotop, "CellInVivo") |> PrefixedName
    /// <summary>
    ///   <para>biotop:CellMembrane</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"cell membrane"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#CellMembrane">http://purl.org/biotop/biotop.owl#CellMembrane</seealso>
    let CellMembrane = Prefixed_Name(biotop, "CellMembrane") |> PrefixedName
    /// <summary>
    ///   <para>biotop:CellNucleus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"cell nucleus"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#CellNucleus">http://purl.org/biotop/biotop.owl#CellNucleus</seealso>
    let CellNucleus = Prefixed_Name(biotop, "CellNucleus") |> PrefixedName
    /// <summary>
    ///   <para>biotop:CellularComponent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"cellular component"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#CellularComponent">http://purl.org/biotop/biotop.owl#CellularComponent</seealso>
    let CellularComponent = Prefixed_Name(biotop, "CellularComponent") |> PrefixedName

    /// <summary>
    ///   <para>biotop:CentralNervousSystem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"central nervous system"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#CentralNervousSystem">http://purl.org/biotop/biotop.owl#CentralNervousSystem</seealso>
    let CentralNervousSystem =
        Prefixed_Name(biotop, "CentralNervousSystem") |> PrefixedName

    /// <summary>
    ///   <para>biotop:ChainOfCarbohydrateMonomers</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"chain of carbohydrate monomers"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#ChainOfCarbohydrateMonomers">http://purl.org/biotop/biotop.owl#ChainOfCarbohydrateMonomers</seealso>
    let ChainOfCarbohydrateMonomers =
        Prefixed_Name(biotop, "ChainOfCarbohydrateMonomers") |> PrefixedName

    /// <summary>
    ///   <para>biotop:ChainOfNucleotideMonomers</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"chain of nucleotide monomers"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#ChainOfNucleotideMonomers">http://purl.org/biotop/biotop.owl#ChainOfNucleotideMonomers</seealso>
    let ChainOfNucleotideMonomers =
        Prefixed_Name(biotop, "ChainOfNucleotideMonomers") |> PrefixedName

    /// <summary>
    ///   <para>biotop:ChemicalRole</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"chemical role"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#ChemicalRole">http://purl.org/biotop/biotop.owl#ChemicalRole</seealso>
    let ChemicalRole = Prefixed_Name(biotop, "ChemicalRole") |> PrefixedName
    /// <summary>
    ///   <para>biotop:ChildRole</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"child role"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#ChildRole">http://purl.org/biotop/biotop.owl#ChildRole</seealso>
    let ChildRole = Prefixed_Name(biotop, "ChildRole") |> PrefixedName
    /// <summary>
    ///   <para>biotop:ChlamydiaCell</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"chlamydia cell"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#ChlamydiaCell">http://purl.org/biotop/biotop.owl#ChlamydiaCell</seealso>
    let ChlamydiaCell = Prefixed_Name(biotop, "ChlamydiaCell") |> PrefixedName
    /// <summary>
    ///   <para>biotop:Chromosome</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"chromosome"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#Chromosome">http://purl.org/biotop/biotop.owl#Chromosome</seealso>
    let Chromosome = Prefixed_Name(biotop, "Chromosome") |> PrefixedName

    /// <summary>
    ///   <para>biotop:ClassGammaProteobacteriaValueRegion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"EXAMPLE OF TAXON REGION"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"class gamma proteobacteria value region"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#ClassGammaProteobacteriaValueRegion">http://purl.org/biotop/biotop.owl#ClassGammaProteobacteriaValueRegion</seealso>
    let ClassGammaProteobacteriaValueRegion =
        Prefixed_Name(biotop, "ClassGammaProteobacteriaValueRegion") |> PrefixedName

    /// <summary>
    ///   <para>biotop:ClassInsectaValueRegion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"EXAMPLE OF TAXON REGION"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"class insecta value region"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#ClassInsectaValueRegion">http://purl.org/biotop/biotop.owl#ClassInsectaValueRegion</seealso>
    let ClassInsectaValueRegion =
        Prefixed_Name(biotop, "ClassInsectaValueRegion") |> PrefixedName

    /// <summary>
    ///   <para>biotop:ClassMammaliaValueRegion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"EXAMPLE OF TAXON REGION"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"class mammalia value region"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#ClassMammaliaValueRegion">http://purl.org/biotop/biotop.owl#ClassMammaliaValueRegion</seealso>
    let ClassMammaliaValueRegion =
        Prefixed_Name(biotop, "ClassMammaliaValueRegion") |> PrefixedName

    /// <summary>
    ///   <para>biotop:ClassSaccharomycetesValueRegion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"EXAMPLE OF TAXON REGION"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"class saccharomycetes value region"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#ClassSaccharomycetesValueRegion">http://purl.org/biotop/biotop.owl#ClassSaccharomycetesValueRegion</seealso>
    let ClassSaccharomycetesValueRegion =
        Prefixed_Name(biotop, "ClassSaccharomycetesValueRegion") |> PrefixedName

    /// <summary>
    ///   <para>biotop:CollectiveMaterialEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The fuzzyness of this class is due to the "same sort" criterion."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"collective material entity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#CollectiveMaterialEntity">http://purl.org/biotop/biotop.owl#CollectiveMaterialEntity</seealso>
    let CollectiveMaterialEntity =
        Prefixed_Name(biotop, "CollectiveMaterialEntity") |> PrefixedName

    /// <summary>
    ///   <para>biotop:Complicating</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"complicating"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#Complicating">http://purl.org/biotop/biotop.owl#Complicating</seealso>
    let Complicating = Prefixed_Name(biotop, "Complicating") |> PrefixedName

    /// <summary>
    ///   <para>biotop:CompoundOfCollectiveMaterialEntities</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"compound of collective material entities"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#CompoundOfCollectiveMaterialEntities">http://purl.org/biotop/biotop.owl#CompoundOfCollectiveMaterialEntities</seealso>
    let CompoundOfCollectiveMaterialEntities =
        Prefixed_Name(biotop, "CompoundOfCollectiveMaterialEntities") |> PrefixedName

    /// <summary>
    ///   <para>biotop:Condition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"condition"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#Condition">http://purl.org/biotop/biotop.owl#Condition</seealso>
    let Condition = Prefixed_Name(biotop, "Condition") |> PrefixedName

    /// <summary>
    ///   <para>biotop:CongenitalAbnormalStructure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"congenital abnormal structure"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#CongenitalAbnormalStructure">http://purl.org/biotop/biotop.owl#CongenitalAbnormalStructure</seealso>
    let CongenitalAbnormalStructure =
        Prefixed_Name(biotop, "CongenitalAbnormalStructure") |> PrefixedName

    /// <summary>
    ///   <para>biotop:CongenitalPathologicalCondition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"congenital pathological condition"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#CongenitalPathologicalCondition">http://purl.org/biotop/biotop.owl#CongenitalPathologicalCondition</seealso>
    let CongenitalPathologicalCondition =
        Prefixed_Name(biotop, "CongenitalPathologicalCondition") |> PrefixedName

    /// <summary>
    ///   <para>biotop:CongenitalPathologicalStaticProcessualEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"congenital pathological static processual entity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#CongenitalPathologicalStaticProcessualEntity">http://purl.org/biotop/biotop.owl#CongenitalPathologicalStaticProcessualEntity</seealso>
    let CongenitalPathologicalStaticProcessualEntity =
        Prefixed_Name(biotop, "CongenitalPathologicalStaticProcessualEntity") |> PrefixedName

    /// <summary>
    ///   <para>biotop:Cytoplasm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"cytoplasm"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#Cytoplasm">http://purl.org/biotop/biotop.owl#Cytoplasm</seealso>
    let Cytoplasm = Prefixed_Name(biotop, "Cytoplasm") |> PrefixedName
    /// <summary>
    ///   <para>biotop:DEPRECATED</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Place for currently non maintained classes. It should be assured that they are not being referred to by application ontologies that import BioTop"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#DEPRECATED">http://purl.org/biotop/biotop.owl#DEPRECATED</seealso>
    let DEPRECATED = Prefixed_Name(biotop, "DEPRECATED") |> PrefixedName

    /// <summary>
    ///   <para>biotop:DEPRECATED_RELATION</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#DEPRECATED_RELATION">http://purl.org/biotop/biotop.owl#DEPRECATED_RELATION</seealso>
    let DEPRECATED_RELATION =
        Prefixed_Name(biotop, "DEPRECATED_RELATION") |> PrefixedName

    /// <summary>
    ///   <para>biotop:DNAChain</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"DNA chain"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#DNAChain">http://purl.org/biotop/biotop.owl#DNAChain</seealso>
    let DNAChain = Prefixed_Name(biotop, "DNAChain") |> PrefixedName
    /// <summary>
    ///   <para>biotop:DeadBody</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"dead body"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#DeadBody">http://purl.org/biotop/biotop.owl#DeadBody</seealso>
    let DeadBody = Prefixed_Name(biotop, "DeadBody") |> PrefixedName
    /// <summary>
    ///   <para>biotop:Death</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"death"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#Death">http://purl.org/biotop/biotop.owl#Death</seealso>
    let Death = Prefixed_Name(biotop, "Death") |> PrefixedName

    /// <summary>
    ///   <para>biotop:DevelopmentalQuality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"developmental quality"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#DevelopmentalQuality">http://purl.org/biotop/biotop.owl#DevelopmentalQuality</seealso>
    let DevelopmentalQuality =
        Prefixed_Name(biotop, "DevelopmentalQuality") |> PrefixedName

    /// <summary>
    ///   <para>biotop:DevelopmentalValueRegion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"developmental value region"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#DevelopmentalValueRegion">http://purl.org/biotop/biotop.owl#DevelopmentalValueRegion</seealso>
    let DevelopmentalValueRegion =
        Prefixed_Name(biotop, "DevelopmentalValueRegion") |> PrefixedName

    /// <summary>
    ///   <para>biotop:DigitalEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"(OBI 306)"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"digital entity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#DigitalEntity">http://purl.org/biotop/biotop.owl#DigitalEntity</seealso>
    let DigitalEntity = Prefixed_Name(biotop, "DigitalEntity") |> PrefixedName
    /// <summary>
    ///   <para>biotop:Disposition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"disposition"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#Disposition">http://purl.org/biotop/biotop.owl#Disposition</seealso>
    let Disposition = Prefixed_Name(biotop, "Disposition") |> PrefixedName
    /// <summary>
    ///   <para>biotop:Disrupting</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"disrupting"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#Disrupting">http://purl.org/biotop/biotop.owl#Disrupting</seealso>
    let Disrupting = Prefixed_Name(biotop, "Disrupting") |> PrefixedName
    /// <summary>
    ///   <para>biotop:DrugRole</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"drug role"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#DrugRole">http://purl.org/biotop/biotop.owl#DrugRole</seealso>
    let DrugRole = Prefixed_Name(biotop, "DrugRole") |> PrefixedName
    /// <summary>
    ///   <para>biotop:EducatorRole</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"educator role"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#EducatorRole">http://purl.org/biotop/biotop.owl#EducatorRole</seealso>
    let EducatorRole = Prefixed_Name(biotop, "EducatorRole") |> PrefixedName
    /// <summary>
    ///   <para>biotop:Eicosanoid</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"eicosanoid"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#Eicosanoid">http://purl.org/biotop/biotop.owl#Eicosanoid</seealso>
    let Eicosanoid = Prefixed_Name(biotop, "Eicosanoid") |> PrefixedName
    /// <summary>
    ///   <para>biotop:Electron</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"electron"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#Electron">http://purl.org/biotop/biotop.owl#Electron</seealso>
    let Electron = Prefixed_Name(biotop, "Electron") |> PrefixedName
    /// <summary>
    ///   <para>biotop:EmbryonicOrganism</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"embryonic organism"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#EmbryonicOrganism">http://purl.org/biotop/biotop.owl#EmbryonicOrganism</seealso>
    let EmbryonicOrganism = Prefixed_Name(biotop, "EmbryonicOrganism") |> PrefixedName
    /// <summary>
    ///   <para>biotop:EmbryonicStructure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"embryonic structure"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#EmbryonicStructure">http://purl.org/biotop/biotop.owl#EmbryonicStructure</seealso>
    let EmbryonicStructure = Prefixed_Name(biotop, "EmbryonicStructure") |> PrefixedName

    /// <summary>
    ///   <para>biotop:EmbryonicValueRegion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>""embryonic" as the value of a developmental stage. E.g. a 3 days old mouse embryo has a quality which has its value located in "embryonic value region"."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"embryonic value region"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#EmbryonicValueRegion">http://purl.org/biotop/biotop.owl#EmbryonicValueRegion</seealso>
    let EmbryonicValueRegion =
        Prefixed_Name(biotop, "EmbryonicValueRegion") |> PrefixedName

    /// <summary>
    ///   <para>biotop:EntireCarbohydrateMonomer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"entire carbohydrate monomer"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#EntireCarbohydrateMonomer">http://purl.org/biotop/biotop.owl#EntireCarbohydrateMonomer</seealso>
    let EntireCarbohydrateMonomer =
        Prefixed_Name(biotop, "EntireCarbohydrateMonomer") |> PrefixedName

    /// <summary>
    ///   <para>biotop:EntireMolecularEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"entire molecular entity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#EntireMolecularEntity">http://purl.org/biotop/biotop.owl#EntireMolecularEntity</seealso>
    let EntireMolecularEntity =
        Prefixed_Name(biotop, "EntireMolecularEntity") |> PrefixedName

    /// <summary>
    ///   <para>biotop:EntireNucleicAcidMolecule</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"not (properPartOf some MonoMolecularEntity)  REMOVED"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"entire nucleic acid molecule"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#EntireNucleicAcidMolecule">http://purl.org/biotop/biotop.owl#EntireNucleicAcidMolecule</seealso>
    let EntireNucleicAcidMolecule =
        Prefixed_Name(biotop, "EntireNucleicAcidMolecule") |> PrefixedName

    /// <summary>
    ///   <para>biotop:EntireProteinMolecule</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"(QCR) Peptide and hasComponent min 101 AminoAcidMonomer and not (ro:properPartOf some MolecularEntity)"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"entire protein molecule"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#EntireProteinMolecule">http://purl.org/biotop/biotop.owl#EntireProteinMolecule</seealso>
    let EntireProteinMolecule =
        Prefixed_Name(biotop, "EntireProteinMolecule") |> PrefixedName

    /// <summary>
    ///   <para>biotop:EnzymeRole</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The role a peptide plays in accelerating a biochemical reaction"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"enzyme role"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#EnzymeRole">http://purl.org/biotop/biotop.owl#EnzymeRole</seealso>
    let EnzymeRole = Prefixed_Name(biotop, "EnzymeRole") |> PrefixedName
    /// <summary>
    ///   <para>biotop:EpithelialCell</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"epithelial cell"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#EpithelialCell">http://purl.org/biotop/biotop.owl#EpithelialCell</seealso>
    let EpithelialCell = Prefixed_Name(biotop, "EpithelialCell") |> PrefixedName

    /// <summary>
    ///   <para>biotop:EscherichiaColiCell</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"escherichia coli cell"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#EscherichiaColiCell">http://purl.org/biotop/biotop.owl#EscherichiaColiCell</seealso>
    let EscherichiaColiCell =
        Prefixed_Name(biotop, "EscherichiaColiCell") |> PrefixedName

    /// <summary>
    ///   <para>biotop:EscherichiaColiPopulation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"EXAMPLE OF POPULATION"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"escherichia coli population"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#EscherichiaColiPopulation">http://purl.org/biotop/biotop.owl#EscherichiaColiPopulation</seealso>
    let EscherichiaColiPopulation =
        Prefixed_Name(biotop, "EscherichiaColiPopulation") |> PrefixedName

    /// <summary>
    ///   <para>biotop:Eukaryote</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"eukaryote"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#Eukaryote">http://purl.org/biotop/biotop.owl#Eukaryote</seealso>
    let Eukaryote = Prefixed_Name(biotop, "Eukaryote") |> PrefixedName

    /// <summary>
    ///   <para>biotop:EukaryotePopulation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"EXAMPLE OF POPULATION"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"eukaryote population"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#EukaryotePopulation">http://purl.org/biotop/biotop.owl#EukaryotePopulation</seealso>
    let EukaryotePopulation =
        Prefixed_Name(biotop, "EukaryotePopulation") |> PrefixedName

    /// <summary>
    ///   <para>biotop:Event</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#Event">http://purl.org/biotop/biotop.owl#Event</seealso>
    let Event = Prefixed_Name(biotop, "Event") |> PrefixedName

    /// <summary>
    ///   <para>biotop:ExaminationResultRole</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"examination result role"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#ExaminationResultRole">http://purl.org/biotop/biotop.owl#ExaminationResultRole</seealso>
    let ExaminationResultRole =
        Prefixed_Name(biotop, "ExaminationResultRole") |> PrefixedName

    /// <summary>
    ///   <para>biotop:FamilyDrosophilidaeValueRegion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"EXAMPLE OF TAXON REGION"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"family drosophilidae value region"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#FamilyDrosophilidaeValueRegion">http://purl.org/biotop/biotop.owl#FamilyDrosophilidaeValueRegion</seealso>
    let FamilyDrosophilidaeValueRegion =
        Prefixed_Name(biotop, "FamilyDrosophilidaeValueRegion") |> PrefixedName

    /// <summary>
    ///   <para>biotop:FamilyEnterobacteriaceaeaValueRegion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"EXAMPLE OF TAXON REGION"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"family enterobacteriaceaea value region"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#FamilyEnterobacteriaceaeaValueRegion">http://purl.org/biotop/biotop.owl#FamilyEnterobacteriaceaeaValueRegion</seealso>
    let FamilyEnterobacteriaceaeaValueRegion =
        Prefixed_Name(biotop, "FamilyEnterobacteriaceaeaValueRegion") |> PrefixedName

    /// <summary>
    ///   <para>biotop:FamilyHominidaeValueRegion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"EXAMPLE OF TAXON REGION"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"family hominidae value region"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#FamilyHominidaeValueRegion">http://purl.org/biotop/biotop.owl#FamilyHominidaeValueRegion</seealso>
    let FamilyHominidaeValueRegion =
        Prefixed_Name(biotop, "FamilyHominidaeValueRegion") |> PrefixedName

    /// <summary>
    ///   <para>biotop:FamilyOfIndividualOrganisms</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"unclear classe. to be revised"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"family of individual organisms"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#FamilyOfIndividualOrganisms">http://purl.org/biotop/biotop.owl#FamilyOfIndividualOrganisms</seealso>
    let FamilyOfIndividualOrganisms =
        Prefixed_Name(biotop, "FamilyOfIndividualOrganisms") |> PrefixedName

    /// <summary>
    ///   <para>biotop:FamilyRole</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"family role"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#FamilyRole">http://purl.org/biotop/biotop.owl#FamilyRole</seealso>
    let FamilyRole = Prefixed_Name(biotop, "FamilyRole") |> PrefixedName

    /// <summary>
    ///   <para>biotop:FamilySaccharomycetaceaeValueRegion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"EXAMPLE OF TAXON REGION"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"family saccharomycetaceae value region"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#FamilySaccharomycetaceaeValueRegion">http://purl.org/biotop/biotop.owl#FamilySaccharomycetaceaeValueRegion</seealso>
    let FamilySaccharomycetaceaeValueRegion =
        Prefixed_Name(biotop, "FamilySaccharomycetaceaeValueRegion") |> PrefixedName

    /// <summary>
    ///   <para>biotop:FattyAcidMoleculeOrResidue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"fatty acid molecule or residue"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#FattyAcidMoleculeOrResidue">http://purl.org/biotop/biotop.owl#FattyAcidMoleculeOrResidue</seealso>
    let FattyAcidMoleculeOrResidue =
        Prefixed_Name(biotop, "FattyAcidMoleculeOrResidue") |> PrefixedName

    /// <summary>
    ///   <para>biotop:FindingRole</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"finding role"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#FindingRole">http://purl.org/biotop/biotop.owl#FindingRole</seealso>
    let FindingRole = Prefixed_Name(biotop, "FindingRole") |> PrefixedName
    /// <summary>
    ///   <para>biotop:Fish</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"fish"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#Fish">http://purl.org/biotop/biotop.owl#Fish</seealso>
    let Fish = Prefixed_Name(biotop, "Fish") |> PrefixedName
    /// <summary>
    ///   <para>biotop:FoodRole</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"food role"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#FoodRole">http://purl.org/biotop/biotop.owl#FoodRole</seealso>
    let FoodRole = Prefixed_Name(biotop, "FoodRole") |> PrefixedName
    /// <summary>
    ///   <para>biotop:FruitFly</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"one drosophila melanogaster"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"fruit fly"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#FruitFly">http://purl.org/biotop/biotop.owl#FruitFly</seealso>
    let FruitFly = Prefixed_Name(biotop, "FruitFly") |> PrefixedName
    /// <summary>
    ///   <para>biotop:FruitFlyPopulation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"EXAMPLE OF POPULATION"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"fruit fly population"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#FruitFlyPopulation">http://purl.org/biotop/biotop.owl#FruitFlyPopulation</seealso>
    let FruitFlyPopulation = Prefixed_Name(biotop, "FruitFlyPopulation") |> PrefixedName
    /// <summary>
    ///   <para>biotop:Function</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"function"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#Function">http://purl.org/biotop/biotop.owl#Function</seealso>
    let Function = Prefixed_Name(biotop, "Function") |> PrefixedName
    /// <summary>
    ///   <para>biotop:Fungus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"On fungus organisms"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"fungus"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#Fungus">http://purl.org/biotop/biotop.owl#Fungus</seealso>
    let Fungus = Prefixed_Name(biotop, "Fungus") |> PrefixedName
    /// <summary>
    ///   <para>biotop:FungusPopulation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"EXAMPLE OF POPULATION"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"fungus population"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#FungusPopulation">http://purl.org/biotop/biotop.owl#FungusPopulation</seealso>
    let FungusPopulation = Prefixed_Name(biotop, "FungusPopulation") |> PrefixedName
    /// <summary>
    ///   <para>biotop:GaseousValueRegion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>""gaseous" as the value of a states of matter.  E.g. a portion of air has a quality which has its value located in "gaseous value region""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"gaseous value region"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#GaseousValueRegion">http://purl.org/biotop/biotop.owl#GaseousValueRegion</seealso>
    let GaseousValueRegion = Prefixed_Name(biotop, "GaseousValueRegion") |> PrefixedName
    /// <summary>
    ///   <para>biotop:Gene</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"gene"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#Gene">http://purl.org/biotop/biotop.owl#Gene</seealso>
    let Gene = Prefixed_Name(biotop, "Gene") |> PrefixedName
    /// <summary>
    ///   <para>biotop:GeneInformation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"gene information"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#GeneInformation">http://purl.org/biotop/biotop.owl#GeneInformation</seealso>
    let GeneInformation = Prefixed_Name(biotop, "GeneInformation") |> PrefixedName
    /// <summary>
    ///   <para>biotop:GeneRegion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"gene region"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#GeneRegion">http://purl.org/biotop/biotop.owl#GeneRegion</seealso>
    let GeneRegion = Prefixed_Name(biotop, "GeneRegion") |> PrefixedName
    /// <summary>
    ///   <para>biotop:GeneticInformation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"genetic information"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#GeneticInformation">http://purl.org/biotop/biotop.owl#GeneticInformation</seealso>
    let GeneticInformation = Prefixed_Name(biotop, "GeneticInformation") |> PrefixedName
    /// <summary>
    ///   <para>biotop:Genome</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"sum of genetic material in a cell"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"genome"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#Genome">http://purl.org/biotop/biotop.owl#Genome</seealso>
    let Genome = Prefixed_Name(biotop, "Genome") |> PrefixedName
    /// <summary>
    ///   <para>biotop:GenomeInformation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"genome information"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#GenomeInformation">http://purl.org/biotop/biotop.owl#GenomeInformation</seealso>
    let GenomeInformation = Prefixed_Name(biotop, "GenomeInformation") |> PrefixedName

    /// <summary>
    ///   <para>biotop:GenusCandidaValueRegion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"EXAMPLE OF TAXON REGION"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"genus candida value region"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#GenusCandidaValueRegion">http://purl.org/biotop/biotop.owl#GenusCandidaValueRegion</seealso>
    let GenusCandidaValueRegion =
        Prefixed_Name(biotop, "GenusCandidaValueRegion") |> PrefixedName

    /// <summary>
    ///   <para>biotop:GenusDrosophilaValueRegion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"EXAMPLE OF TAXON REGION"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"genus drosophila value region"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#GenusDrosophilaValueRegion">http://purl.org/biotop/biotop.owl#GenusDrosophilaValueRegion</seealso>
    let GenusDrosophilaValueRegion =
        Prefixed_Name(biotop, "GenusDrosophilaValueRegion") |> PrefixedName

    /// <summary>
    ///   <para>biotop:GenusEscherichiaValueRegion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"EXAMPLE OF TAXON REGION"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"genus escherichia value region"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#GenusEscherichiaValueRegion">http://purl.org/biotop/biotop.owl#GenusEscherichiaValueRegion</seealso>
    let GenusEscherichiaValueRegion =
        Prefixed_Name(biotop, "GenusEscherichiaValueRegion") |> PrefixedName

    /// <summary>
    ///   <para>biotop:GenusHomoValueRegion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"EXAMPLE OF TAXON REGION"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"genus homo value region"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#GenusHomoValueRegion">http://purl.org/biotop/biotop.owl#GenusHomoValueRegion</seealso>
    let GenusHomoValueRegion =
        Prefixed_Name(biotop, "GenusHomoValueRegion") |> PrefixedName

    /// <summary>
    ///   <para>biotop:GenusSaccharomycesValueRegion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"EXAMPLE OF TAXON REGION"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"genus saccharomyces value region"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#GenusSaccharomycesValueRegion">http://purl.org/biotop/biotop.owl#GenusSaccharomycesValueRegion</seealso>
    let GenusSaccharomycesValueRegion =
        Prefixed_Name(biotop, "GenusSaccharomycesValueRegion") |> PrefixedName

    /// <summary>
    ///   <para>biotop:GeographicSurface</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"previous name "geographic entity""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"geographic surface"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#GeographicSurface">http://purl.org/biotop/biotop.owl#GeographicSurface</seealso>
    let GeographicSurface = Prefixed_Name(biotop, "GeographicSurface") |> PrefixedName
    /// <summary>
    ///   <para>biotop:Government</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"government"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#Government">http://purl.org/biotop/biotop.owl#Government</seealso>
    let Government = Prefixed_Name(biotop, "Government") |> PrefixedName
    /// <summary>
    ///   <para>biotop:GreatApe</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"one great ape"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"great ape"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#GreatApe">http://purl.org/biotop/biotop.owl#GreatApe</seealso>
    let GreatApe = Prefixed_Name(biotop, "GreatApe") |> PrefixedName
    /// <summary>
    ///   <para>biotop:GreatApePopulation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"EXAMPLE OF POPULATION"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"great ape population"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#GreatApePopulation">http://purl.org/biotop/biotop.owl#GreatApePopulation</seealso>
    let GreatApePopulation = Prefixed_Name(biotop, "GreatApePopulation") |> PrefixedName
    /// <summary>
    ///   <para>biotop:GroupInteraction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"group interaction"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#GroupInteraction">http://purl.org/biotop/biotop.owl#GroupInteraction</seealso>
    let GroupInteraction = Prefixed_Name(biotop, "GroupInteraction") |> PrefixedName
    /// <summary>
    ///   <para>biotop:GrowingProcess</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"growing process"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#GrowingProcess">http://purl.org/biotop/biotop.owl#GrowingProcess</seealso>
    let GrowingProcess = Prefixed_Name(biotop, "GrowingProcess") |> PrefixedName

    /// <summary>
    ///   <para>biotop:HealthProfessionalRole</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"health professional role"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#HealthProfessionalRole">http://purl.org/biotop/biotop.owl#HealthProfessionalRole</seealso>
    let HealthProfessionalRole =
        Prefixed_Name(biotop, "HealthProfessionalRole") |> PrefixedName

    /// <summary>
    ///   <para>biotop:HealthRelatedRole</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"health related role"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#HealthRelatedRole">http://purl.org/biotop/biotop.owl#HealthRelatedRole</seealso>
    let HealthRelatedRole = Prefixed_Name(biotop, "HealthRelatedRole") |> PrefixedName

    /// <summary>
    ///   <para>biotop:HeterocyclicBaseMoleculeOrResidue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"heterocyclic base molecule or residue"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#HeterocyclicBaseMoleculeOrResidue">http://purl.org/biotop/biotop.owl#HeterocyclicBaseMoleculeOrResidue</seealso>
    let HeterocyclicBaseMoleculeOrResidue =
        Prefixed_Name(biotop, "HeterocyclicBaseMoleculeOrResidue") |> PrefixedName

    /// <summary>
    ///   <para>biotop:HormoneRole</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"hormone role"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#HormoneRole">http://purl.org/biotop/biotop.owl#HormoneRole</seealso>
    let HormoneRole = Prefixed_Name(biotop, "HormoneRole") |> PrefixedName
    /// <summary>
    ///   <para>biotop:Human</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"human"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#Human">http://purl.org/biotop/biotop.owl#Human</seealso>
    let Human = Prefixed_Name(biotop, "Human") |> PrefixedName
    /// <summary>
    ///   <para>biotop:HumanAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"human action"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#HumanAction">http://purl.org/biotop/biotop.owl#HumanAction</seealso>
    let HumanAction = Prefixed_Name(biotop, "HumanAction") |> PrefixedName

    /// <summary>
    ///   <para>biotop:HumanEpithelialCell</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"human epithelial cell"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#HumanEpithelialCell">http://purl.org/biotop/biotop.owl#HumanEpithelialCell</seealso>
    let HumanEpithelialCell =
        Prefixed_Name(biotop, "HumanEpithelialCell") |> PrefixedName

    /// <summary>
    ///   <para>biotop:HumanLanguage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"human language"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#HumanLanguage">http://purl.org/biotop/biotop.owl#HumanLanguage</seealso>
    let HumanLanguage = Prefixed_Name(biotop, "HumanLanguage") |> PrefixedName
    /// <summary>
    ///   <para>biotop:HumanPopulation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"EXAMPLE OF POPULATION"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"human population"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#HumanPopulation">http://purl.org/biotop/biotop.owl#HumanPopulation</seealso>
    let HumanPopulation = Prefixed_Name(biotop, "HumanPopulation") |> PrefixedName
    /// <summary>
    ///   <para>biotop:HumanReasoning</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"human reasoning"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#HumanReasoning">http://purl.org/biotop/biotop.owl#HumanReasoning</seealso>
    let HumanReasoning = Prefixed_Name(biotop, "HumanReasoning") |> PrefixedName
    /// <summary>
    ///   <para>biotop:Hurting</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"negatively affecting a biological system by using physical force"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"hurting"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#Hurting">http://purl.org/biotop/biotop.owl#Hurting</seealso>
    let Hurting = Prefixed_Name(biotop, "Hurting") |> PrefixedName

    /// <summary>
    ///   <para>biotop:ImmaterialNonphysicalEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"immaterial nonphysical entity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#ImmaterialNonphysicalEntity">http://purl.org/biotop/biotop.owl#ImmaterialNonphysicalEntity</seealso>
    let ImmaterialNonphysicalEntity =
        Prefixed_Name(biotop, "ImmaterialNonphysicalEntity") |> PrefixedName

    /// <summary>
    ///   <para>biotop:ImmaterialObject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"immaterial object"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#ImmaterialObject">http://purl.org/biotop/biotop.owl#ImmaterialObject</seealso>
    let ImmaterialObject = Prefixed_Name(biotop, "ImmaterialObject") |> PrefixedName

    /// <summary>
    ///   <para>biotop:ImmaterialPhysicalEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#ImmaterialPhysicalEntity">http://purl.org/biotop/biotop.owl#ImmaterialPhysicalEntity</seealso>
    let ImmaterialPhysicalEntity =
        Prefixed_Name(biotop, "ImmaterialPhysicalEntity") |> PrefixedName

    /// <summary>
    ///   <para>biotop:ImmaterialProcessualEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"immaterial processual entity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#ImmaterialProcessualEntity">http://purl.org/biotop/biotop.owl#ImmaterialProcessualEntity</seealso>
    let ImmaterialProcessualEntity =
        Prefixed_Name(biotop, "ImmaterialProcessualEntity") |> PrefixedName

    /// <summary>
    ///   <para>biotop:ImmaterialThreeDimensionalPhysicalEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"immaterial three dimensional physical entity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#ImmaterialThreeDimensionalPhysicalEntity">http://purl.org/biotop/biotop.owl#ImmaterialThreeDimensionalPhysicalEntity</seealso>
    let ImmaterialThreeDimensionalPhysicalEntity =
        Prefixed_Name(biotop, "ImmaterialThreeDimensionalPhysicalEntity") |> PrefixedName

    /// <summary>
    ///   <para>biotop:ImmunologicRole</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"immunologic role"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#ImmunologicRole">http://purl.org/biotop/biotop.owl#ImmunologicRole</seealso>
    let ImmunologicRole = Prefixed_Name(biotop, "ImmunologicRole") |> PrefixedName
    /// <summary>
    ///   <para>biotop:Indicating</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"indicating"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#Indicating">http://purl.org/biotop/biotop.owl#Indicating</seealso>
    let Indicating = Prefixed_Name(biotop, "Indicating") |> PrefixedName
    /// <summary>
    ///   <para>biotop:IndicatorRole</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"indicator role"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#IndicatorRole">http://purl.org/biotop/biotop.owl#IndicatorRole</seealso>
    let IndicatorRole = Prefixed_Name(biotop, "IndicatorRole") |> PrefixedName
    /// <summary>
    ///   <para>biotop:IndividualBehavior</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"individual behavior"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#IndividualBehavior">http://purl.org/biotop/biotop.owl#IndividualBehavior</seealso>
    let IndividualBehavior = Prefixed_Name(biotop, "IndividualBehavior") |> PrefixedName
    /// <summary>
    ///   <para>biotop:InformationEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#InformationEntity">http://purl.org/biotop/biotop.owl#InformationEntity</seealso>
    let InformationEntity = Prefixed_Name(biotop, "InformationEntity") |> PrefixedName
    /// <summary>
    ///   <para>biotop:InformationObject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"information object"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#InformationObject">http://purl.org/biotop/biotop.owl#InformationObject</seealso>
    let InformationObject = Prefixed_Name(biotop, "InformationObject") |> PrefixedName

    /// <summary>
    ///   <para>biotop:InorganicMolecularEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"inorganic molecular entity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#InorganicMolecularEntity">http://purl.org/biotop/biotop.owl#InorganicMolecularEntity</seealso>
    let InorganicMolecularEntity =
        Prefixed_Name(biotop, "InorganicMolecularEntity") |> PrefixedName

    /// <summary>
    ///   <para>biotop:Insect</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"insect"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#Insect">http://purl.org/biotop/biotop.owl#Insect</seealso>
    let Insect = Prefixed_Name(biotop, "Insect") |> PrefixedName
    /// <summary>
    ///   <para>biotop:InsectPopulation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"EXAMPLE OF POPULATION"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"insect population"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#InsectPopulation">http://purl.org/biotop/biotop.owl#InsectPopulation</seealso>
    let InsectPopulation = Prefixed_Name(biotop, "InsectPopulation") |> PrefixedName

    /// <summary>
    ///   <para>biotop:InstantaneousProcess</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"instantaneous process"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#InstantaneousProcess">http://purl.org/biotop/biotop.owl#InstantaneousProcess</seealso>
    let InstantaneousProcess =
        Prefixed_Name(biotop, "InstantaneousProcess") |> PrefixedName

    /// <summary>
    ///   <para>biotop:IntellectualProduct</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"intellectual product"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#IntellectualProduct">http://purl.org/biotop/biotop.owl#IntellectualProduct</seealso>
    let IntellectualProduct =
        Prefixed_Name(biotop, "IntellectualProduct") |> PrefixedName

    /// <summary>
    ///   <para>biotop:Interacting</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"interacting"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#Interacting">http://purl.org/biotop/biotop.owl#Interacting</seealso>
    let Interacting = Prefixed_Name(biotop, "Interacting") |> PrefixedName

    /// <summary>
    ///   <para>biotop:IntraCellularProcess</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"intra cellular process"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#IntraCellularProcess">http://purl.org/biotop/biotop.owl#IntraCellularProcess</seealso>
    let IntraCellularProcess =
        Prefixed_Name(biotop, "IntraCellularProcess") |> PrefixedName

    /// <summary>
    ///   <para>biotop:Invertebrate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"invertebrate"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#Invertebrate">http://purl.org/biotop/biotop.owl#Invertebrate</seealso>
    let Invertebrate = Prefixed_Name(biotop, "Invertebrate") |> PrefixedName
    /// <summary>
    ///   <para>biotop:JuvenileOrganism</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"juvenile organism"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#JuvenileOrganism">http://purl.org/biotop/biotop.owl#JuvenileOrganism</seealso>
    let JuvenileOrganism = Prefixed_Name(biotop, "JuvenileOrganism") |> PrefixedName

    /// <summary>
    ///   <para>biotop:JuvenileValueRegion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"juvenile value region"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#JuvenileValueRegion">http://purl.org/biotop/biotop.owl#JuvenileValueRegion</seealso>
    let JuvenileValueRegion =
        Prefixed_Name(biotop, "JuvenileValueRegion") |> PrefixedName

    /// <summary>
    ///   <para>biotop:KingdomAnimaliaValueRegion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"EXAMPLE OF TAXON REGION"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"kingdom animalia value region"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#KingdomAnimaliaValueRegion">http://purl.org/biotop/biotop.owl#KingdomAnimaliaValueRegion</seealso>
    let KingdomAnimaliaValueRegion =
        Prefixed_Name(biotop, "KingdomAnimaliaValueRegion") |> PrefixedName

    /// <summary>
    ///   <para>biotop:KingdomArchaeaValueRegion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"EXAMPLE OF TAXON REGION"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"kingdom archaea value region"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#KingdomArchaeaValueRegion">http://purl.org/biotop/biotop.owl#KingdomArchaeaValueRegion</seealso>
    let KingdomArchaeaValueRegion =
        Prefixed_Name(biotop, "KingdomArchaeaValueRegion") |> PrefixedName

    /// <summary>
    ///   <para>biotop:KingdomBacteriaValueRegion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"EXAMPLE OF TAXON REGION"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"kingdom bacteria value region"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#KingdomBacteriaValueRegion">http://purl.org/biotop/biotop.owl#KingdomBacteriaValueRegion</seealso>
    let KingdomBacteriaValueRegion =
        Prefixed_Name(biotop, "KingdomBacteriaValueRegion") |> PrefixedName

    /// <summary>
    ///   <para>biotop:KingdomChromistaValueRegion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"EXAMPLE OF TAXON REGION"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"kingdom chromista value region"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#KingdomChromistaValueRegion">http://purl.org/biotop/biotop.owl#KingdomChromistaValueRegion</seealso>
    let KingdomChromistaValueRegion =
        Prefixed_Name(biotop, "KingdomChromistaValueRegion") |> PrefixedName

    /// <summary>
    ///   <para>biotop:KingdomFungiValueRegion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"EXAMPLE OF TAXON REGION"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"kingdom fungi value region"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#KingdomFungiValueRegion">http://purl.org/biotop/biotop.owl#KingdomFungiValueRegion</seealso>
    let KingdomFungiValueRegion =
        Prefixed_Name(biotop, "KingdomFungiValueRegion") |> PrefixedName

    /// <summary>
    ///   <para>biotop:KingdomPlantaeValueRegion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"EXAMPLE OF TAXON REGION"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"kingdom plantae value region"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#KingdomPlantaeValueRegion">http://purl.org/biotop/biotop.owl#KingdomPlantaeValueRegion</seealso>
    let KingdomPlantaeValueRegion =
        Prefixed_Name(biotop, "KingdomPlantaeValueRegion") |> PrefixedName

    /// <summary>
    ///   <para>biotop:KingdomProtozoaValueRegion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"EXAMPLE OF TAXON REGION"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"kingdom protozoa value region"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#KingdomProtozoaValueRegion">http://purl.org/biotop/biotop.owl#KingdomProtozoaValueRegion</seealso>
    let KingdomProtozoaValueRegion =
        Prefixed_Name(biotop, "KingdomProtozoaValueRegion") |> PrefixedName

    /// <summary>
    ///   <para>biotop:KingdomVirusesValueRegion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"EXAMPLE OF TAXON REGION"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"kingdom viruses value region"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#KingdomVirusesValueRegion">http://purl.org/biotop/biotop.owl#KingdomVirusesValueRegion</seealso>
    let KingdomVirusesValueRegion =
        Prefixed_Name(biotop, "KingdomVirusesValueRegion") |> PrefixedName

    /// <summary>
    ///   <para>biotop:Language</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"language"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#Language">http://purl.org/biotop/biotop.owl#Language</seealso>
    let Language = Prefixed_Name(biotop, "Language") |> PrefixedName
    /// <summary>
    ///   <para>biotop:LanguagePartition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#LanguagePartition">http://purl.org/biotop/biotop.owl#LanguagePartition</seealso>
    let LanguagePartition = Prefixed_Name(biotop, "LanguagePartition") |> PrefixedName
    /// <summary>
    ///   <para>biotop:LegalEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"legal entity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#LegalEntity">http://purl.org/biotop/biotop.owl#LegalEntity</seealso>
    let LegalEntity = Prefixed_Name(biotop, "LegalEntity") |> PrefixedName

    /// <summary>
    ///   <para>biotop:LipidMoleculeOrResidue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"lipid molecule or residue"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#LipidMoleculeOrResidue">http://purl.org/biotop/biotop.owl#LipidMoleculeOrResidue</seealso>
    let LipidMoleculeOrResidue =
        Prefixed_Name(biotop, "LipidMoleculeOrResidue") |> PrefixedName

    /// <summary>
    ///   <para>biotop:LiquidValueRegion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>""liquid" as the value of a states of matter. E.g. a portion of water has a quality which has its value located in "liquid value region""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"liquid value region"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#LiquidValueRegion">http://purl.org/biotop/biotop.owl#LiquidValueRegion</seealso>
    let LiquidValueRegion = Prefixed_Name(biotop, "LiquidValueRegion") |> PrefixedName
    /// <summary>
    ///   <para>biotop:LivingBody</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"living body"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#LivingBody">http://purl.org/biotop/biotop.owl#LivingBody</seealso>
    let LivingBody = Prefixed_Name(biotop, "LivingBody") |> PrefixedName
    /// <summary>
    ///   <para>biotop:LivingOrganism</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"living organism"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#LivingOrganism">http://purl.org/biotop/biotop.owl#LivingOrganism</seealso>
    let LivingOrganism = Prefixed_Name(biotop, "LivingOrganism") |> PrefixedName
    /// <summary>
    ///   <para>biotop:MachineAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"machine action"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#MachineAction">http://purl.org/biotop/biotop.owl#MachineAction</seealso>
    let MachineAction = Prefixed_Name(biotop, "MachineAction") |> PrefixedName
    /// <summary>
    ///   <para>biotop:MachineLanguage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"machine language"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#MachineLanguage">http://purl.org/biotop/biotop.owl#MachineLanguage</seealso>
    let MachineLanguage = Prefixed_Name(biotop, "MachineLanguage") |> PrefixedName

    /// <summary>
    ///   <para>biotop:MacroscopicValueRegion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"macroscopic value region"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#MacroscopicValueRegion">http://purl.org/biotop/biotop.owl#MacroscopicValueRegion</seealso>
    let MacroscopicValueRegion =
        Prefixed_Name(biotop, "MacroscopicValueRegion") |> PrefixedName

    /// <summary>
    ///   <para>biotop:Mammal</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"one mammal"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"mammal"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#Mammal">http://purl.org/biotop/biotop.owl#Mammal</seealso>
    let Mammal = Prefixed_Name(biotop, "Mammal") |> PrefixedName
    /// <summary>
    ///   <para>biotop:MammalPopulation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"EXAMPLE OF POPULATION"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"mammal population"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#MammalPopulation">http://purl.org/biotop/biotop.owl#MammalPopulation</seealso>
    let MammalPopulation = Prefixed_Name(biotop, "MammalPopulation") |> PrefixedName
    /// <summary>
    ///   <para>biotop:ManagingCare</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"managing care"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#ManagingCare">http://purl.org/biotop/biotop.owl#ManagingCare</seealso>
    let ManagingCare = Prefixed_Name(biotop, "ManagingCare") |> PrefixedName
    /// <summary>
    ///   <para>biotop:MaterialEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#MaterialEntity">http://purl.org/biotop/biotop.owl#MaterialEntity</seealso>
    let MaterialEntity = Prefixed_Name(biotop, "MaterialEntity") |> PrefixedName

    /// <summary>
    ///   <para>biotop:MaterialEntityBySizePartition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"MaterialEntityBySizePartition
    ///
    /// Ontologically irrelevant partitioning node. Used for improving ontology housekeeping. Its purpose is to express that all subclasses are mutually disjoint."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"*"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#MaterialEntityBySizePartition">http://purl.org/biotop/biotop.owl#MaterialEntityBySizePartition</seealso>
    let MaterialEntityBySizePartition =
        Prefixed_Name(biotop, "MaterialEntityBySizePartition") |> PrefixedName

    /// <summary>
    ///   <para>biotop:MaterialObject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"material object"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#MaterialObject">http://purl.org/biotop/biotop.owl#MaterialObject</seealso>
    let MaterialObject = Prefixed_Name(biotop, "MaterialObject") |> PrefixedName
    /// <summary>
    ///   <para>biotop:Measure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"measure"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#Measure">http://purl.org/biotop/biotop.owl#Measure</seealso>
    let Measure = Prefixed_Name(biotop, "Measure") |> PrefixedName
    /// <summary>
    ///   <para>biotop:MeasurementMethod</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"measurement method"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#MeasurementMethod">http://purl.org/biotop/biotop.owl#MeasurementMethod</seealso>
    let MeasurementMethod = Prefixed_Name(biotop, "MeasurementMethod") |> PrefixedName
    /// <summary>
    ///   <para>biotop:MeasuringAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"measuring action"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#MeasuringAction">http://purl.org/biotop/biotop.owl#MeasuringAction</seealso>
    let MeasuringAction = Prefixed_Name(biotop, "MeasuringAction") |> PrefixedName
    /// <summary>
    ///   <para>biotop:Membership</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"membership"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#Membership">http://purl.org/biotop/biotop.owl#Membership</seealso>
    let Membership = Prefixed_Name(biotop, "Membership") |> PrefixedName
    /// <summary>
    ///   <para>biotop:MentalFunction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"mental function"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#MentalFunction">http://purl.org/biotop/biotop.owl#MentalFunction</seealso>
    let MentalFunction = Prefixed_Name(biotop, "MentalFunction") |> PrefixedName
    /// <summary>
    ///   <para>biotop:MentalProcess</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"process in an organism as a realization of a mental function"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"mental process"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#MentalProcess">http://purl.org/biotop/biotop.owl#MentalProcess</seealso>
    let MentalProcess = Prefixed_Name(biotop, "MentalProcess") |> PrefixedName
    /// <summary>
    ///   <para>biotop:Microorganism</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"microorganism"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#Microorganism">http://purl.org/biotop/biotop.owl#Microorganism</seealso>
    let Microorganism = Prefixed_Name(biotop, "Microorganism") |> PrefixedName

    /// <summary>
    ///   <para>biotop:MicroscopicValueRegion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"microscopic value region"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#MicroscopicValueRegion">http://purl.org/biotop/biotop.owl#MicroscopicValueRegion</seealso>
    let MicroscopicValueRegion =
        Prefixed_Name(biotop, "MicroscopicValueRegion") |> PrefixedName

    /// <summary>
    ///   <para>biotop:Mind</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Difficult concept. Better to be expressed by the primitive "mental function" "^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"mind"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#Mind">http://purl.org/biotop/biotop.owl#Mind</seealso>
    let Mind = Prefixed_Name(biotop, "Mind") |> PrefixedName
    /// <summary>
    ///   <para>biotop:ModifiedCell</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"modified cell"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#ModifiedCell">http://purl.org/biotop/biotop.owl#ModifiedCell</seealso>
    let ModifiedCell = Prefixed_Name(biotop, "ModifiedCell") |> PrefixedName

    /// <summary>
    ///   <para>biotop:MolecularEntityByEntiretyPartition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"*"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#MolecularEntityByEntiretyPartition">http://purl.org/biotop/biotop.owl#MolecularEntityByEntiretyPartition</seealso>
    let MolecularEntityByEntiretyPartition =
        Prefixed_Name(biotop, "MolecularEntityByEntiretyPartition") |> PrefixedName

    /// <summary>
    ///   <para>biotop:MolecularEntityByGranularityPartition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"*"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#MolecularEntityByGranularityPartition">http://purl.org/biotop/biotop.owl#MolecularEntityByGranularityPartition</seealso>
    let MolecularEntityByGranularityPartition =
        Prefixed_Name(biotop, "MolecularEntityByGranularityPartition") |> PrefixedName

    /// <summary>
    ///   <para>biotop:MolecularEntityByOrganicInorganicPartition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"*"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#MolecularEntityByOrganicInorganicPartition">http://purl.org/biotop/biotop.owl#MolecularEntityByOrganicInorganicPartition</seealso>
    let MolecularEntityByOrganicInorganicPartition =
        Prefixed_Name(biotop, "MolecularEntityByOrganicInorganicPartition") |> PrefixedName

    /// <summary>
    ///   <para>biotop:MolecularFunction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"molecular function"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#MolecularFunction">http://purl.org/biotop/biotop.owl#MolecularFunction</seealso>
    let MolecularFunction = Prefixed_Name(biotop, "MolecularFunction") |> PrefixedName
    /// <summary>
    ///   <para>biotop:MolecularResidue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"molecular residue"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#MolecularResidue">http://purl.org/biotop/biotop.owl#MolecularResidue</seealso>
    let MolecularResidue = Prefixed_Name(biotop, "MolecularResidue") |> PrefixedName
    /// <summary>
    ///   <para>biotop:MoleculeComplex</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"molecule complex"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#MoleculeComplex">http://purl.org/biotop/biotop.owl#MoleculeComplex</seealso>
    let MoleculeComplex = Prefixed_Name(biotop, "MoleculeComplex") |> PrefixedName

    /// <summary>
    ///   <para>biotop:MonoMolecularEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"mono molecular entity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#MonoMolecularEntity">http://purl.org/biotop/biotop.owl#MonoMolecularEntity</seealso>
    let MonoMolecularEntity =
        Prefixed_Name(biotop, "MonoMolecularEntity") |> PrefixedName

    /// <summary>
    ///   <para>biotop:Monomer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"monomer"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#Monomer">http://purl.org/biotop/biotop.owl#Monomer</seealso>
    let Monomer = Prefixed_Name(biotop, "Monomer") |> PrefixedName

    /// <summary>
    ///   <para>biotop:MulticellularOrganism</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"multicellular organism"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#MulticellularOrganism">http://purl.org/biotop/biotop.owl#MulticellularOrganism</seealso>
    let MulticellularOrganism =
        Prefixed_Name(biotop, "MulticellularOrganism") |> PrefixedName

    /// <summary>
    ///   <para>biotop:NeoplasticProcess</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"neoplastic process"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#NeoplasticProcess">http://purl.org/biotop/biotop.owl#NeoplasticProcess</seealso>
    let NeoplasticProcess = Prefixed_Name(biotop, "NeoplasticProcess") |> PrefixedName
    /// <summary>
    ///   <para>biotop:NeuroreactiveRole</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"neuroreactive role"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#NeuroreactiveRole">http://purl.org/biotop/biotop.owl#NeuroreactiveRole</seealso>
    let NeuroreactiveRole = Prefixed_Name(biotop, "NeuroreactiveRole") |> PrefixedName
    /// <summary>
    ///   <para>biotop:Neutron</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"neutron"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#Neutron">http://purl.org/biotop/biotop.owl#Neutron</seealso>
    let Neutron = Prefixed_Name(biotop, "Neutron") |> PrefixedName
    /// <summary>
    ///   <para>biotop:NonSteroidLipid</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"non steroid lipid"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#NonSteroidLipid">http://purl.org/biotop/biotop.owl#NonSteroidLipid</seealso>
    let NonSteroidLipid = Prefixed_Name(biotop, "NonSteroidLipid") |> PrefixedName

    /// <summary>
    ///   <para>biotop:NoncanonicalProcessualEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"noncanonical processual entity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#NoncanonicalProcessualEntity">http://purl.org/biotop/biotop.owl#NoncanonicalProcessualEntity</seealso>
    let NoncanonicalProcessualEntity =
        Prefixed_Name(biotop, "NoncanonicalProcessualEntity") |> PrefixedName

    /// <summary>
    ///   <para>biotop:NoncanonicalStaticProcessualEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"noncanonical static processual entity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#NoncanonicalStaticProcessualEntity">http://purl.org/biotop/biotop.owl#NoncanonicalStaticProcessualEntity</seealso>
    let NoncanonicalStaticProcessualEntity =
        Prefixed_Name(biotop, "NoncanonicalStaticProcessualEntity") |> PrefixedName

    /// <summary>
    ///   <para>biotop:NoncanonicalValueRegion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"abstract region in which the value "noncanonical" of canonicity is located"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"noncanonical value region"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#NoncanonicalValueRegion">http://purl.org/biotop/biotop.owl#NoncanonicalValueRegion</seealso>
    let NoncanonicalValueRegion =
        Prefixed_Name(biotop, "NoncanonicalValueRegion") |> PrefixedName

    /// <summary>
    ///   <para>biotop:NucleicAcidNucleotideOrNucleosideMoleculeOrResidue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"nucleic acid nucleotide or nucleoside molecule or residue"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#NucleicAcidNucleotideOrNucleosideMoleculeOrResidue">http://purl.org/biotop/biotop.owl#NucleicAcidNucleotideOrNucleosideMoleculeOrResidue</seealso>
    let NucleicAcidNucleotideOrNucleosideMoleculeOrResidue =
        Prefixed_Name(biotop, "NucleicAcidNucleotideOrNucleosideMoleculeOrResidue") |> PrefixedName

    /// <summary>
    ///   <para>biotop:NucleicAcidRegion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"nucleic acid region"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#NucleicAcidRegion">http://purl.org/biotop/biotop.owl#NucleicAcidRegion</seealso>
    let NucleicAcidRegion = Prefixed_Name(biotop, "NucleicAcidRegion") |> PrefixedName

    /// <summary>
    ///   <para>biotop:NucleicAcidStructure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"nucleic acid structure"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#NucleicAcidStructure">http://purl.org/biotop/biotop.owl#NucleicAcidStructure</seealso>
    let NucleicAcidStructure =
        Prefixed_Name(biotop, "NucleicAcidStructure") |> PrefixedName

    /// <summary>
    ///   <para>biotop:NucleosideMolecule</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"nucleoside molecule"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#NucleosideMolecule">http://purl.org/biotop/biotop.owl#NucleosideMolecule</seealso>
    let NucleosideMolecule = Prefixed_Name(biotop, "NucleosideMolecule") |> PrefixedName
    /// <summary>
    ///   <para>biotop:NucleotideMolecule</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"nucleotide molecule"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#NucleotideMolecule">http://purl.org/biotop/biotop.owl#NucleotideMolecule</seealso>
    let NucleotideMolecule = Prefixed_Name(biotop, "NucleotideMolecule") |> PrefixedName

    /// <summary>
    ///   <para>biotop:NucleotideSequenceInformation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"nucleotide sequence information"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#NucleotideSequenceInformation">http://purl.org/biotop/biotop.owl#NucleotideSequenceInformation</seealso>
    let NucleotideSequenceInformation =
        Prefixed_Name(biotop, "NucleotideSequenceInformation") |> PrefixedName

    /// <summary>
    ///   <para>biotop:NurseRole</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"nurse role"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#NurseRole">http://purl.org/biotop/biotop.owl#NurseRole</seealso>
    let NurseRole = Prefixed_Name(biotop, "NurseRole") |> PrefixedName
    /// <summary>
    ///   <para>biotop:ObjectQuality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"object quality"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#ObjectQuality">http://purl.org/biotop/biotop.owl#ObjectQuality</seealso>
    let ObjectQuality = Prefixed_Name(biotop, "ObjectQuality") |> PrefixedName
    /// <summary>
    ///   <para>biotop:ObservingAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#ObservingAction">http://purl.org/biotop/biotop.owl#ObservingAction</seealso>
    let ObservingAction = Prefixed_Name(biotop, "ObservingAction") |> PrefixedName
    /// <summary>
    ///   <para>biotop:OccupationalRole</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"occupational role"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#OccupationalRole">http://purl.org/biotop/biotop.owl#OccupationalRole</seealso>
    let OccupationalRole = Prefixed_Name(biotop, "OccupationalRole") |> PrefixedName
    /// <summary>
    ///   <para>biotop:OligoOrPolymer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"oligo or polymer"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#OligoOrPolymer">http://purl.org/biotop/biotop.owl#OligoOrPolymer</seealso>
    let OligoOrPolymer = Prefixed_Name(biotop, "OligoOrPolymer") |> PrefixedName

    /// <summary>
    ///   <para>biotop:OneDimensionalBoundary</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"one dimensional boundary"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#OneDimensionalBoundary">http://purl.org/biotop/biotop.owl#OneDimensionalBoundary</seealso>
    let OneDimensionalBoundary =
        Prefixed_Name(biotop, "OneDimensionalBoundary") |> PrefixedName

    /// <summary>
    ///   <para>biotop:OneDimensionalPhysicalEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"one dimensional physical entity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#OneDimensionalPhysicalEntity">http://purl.org/biotop/biotop.owl#OneDimensionalPhysicalEntity</seealso>
    let OneDimensionalPhysicalEntity =
        Prefixed_Name(biotop, "OneDimensionalPhysicalEntity") |> PrefixedName

    /// <summary>
    ///   <para>biotop:OrderDipteraValueRegion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"EXAMPLE OF TAXON REGION"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"order diptera value region"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#OrderDipteraValueRegion">http://purl.org/biotop/biotop.owl#OrderDipteraValueRegion</seealso>
    let OrderDipteraValueRegion =
        Prefixed_Name(biotop, "OrderDipteraValueRegion") |> PrefixedName

    /// <summary>
    ///   <para>biotop:OrderEnterobacterialesValueRegion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"EXAMPLE OF TAXON REGION"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"order enterobacteriales value region"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#OrderEnterobacterialesValueRegion">http://purl.org/biotop/biotop.owl#OrderEnterobacterialesValueRegion</seealso>
    let OrderEnterobacterialesValueRegion =
        Prefixed_Name(biotop, "OrderEnterobacterialesValueRegion") |> PrefixedName

    /// <summary>
    ///   <para>biotop:OrderPrimatesValueRegion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"EXAMPLE OF TAXON REGION"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"order primates value region"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#OrderPrimatesValueRegion">http://purl.org/biotop/biotop.owl#OrderPrimatesValueRegion</seealso>
    let OrderPrimatesValueRegion =
        Prefixed_Name(biotop, "OrderPrimatesValueRegion") |> PrefixedName

    /// <summary>
    ///   <para>biotop:OrderSaccharomycetalesValueRegion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"EXAMPLE OF TAXON REGION"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"order saccharomycetales value region"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#OrderSaccharomycetalesValueRegion">http://purl.org/biotop/biotop.owl#OrderSaccharomycetalesValueRegion</seealso>
    let OrderSaccharomycetalesValueRegion =
        Prefixed_Name(biotop, "OrderSaccharomycetalesValueRegion") |> PrefixedName

    /// <summary>
    ///   <para>biotop:Organ</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"organ"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#Organ">http://purl.org/biotop/biotop.owl#Organ</seealso>
    let Organ = Prefixed_Name(biotop, "Organ") |> PrefixedName
    /// <summary>
    ///   <para>biotop:OrganPart</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"organ part"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#OrganPart">http://purl.org/biotop/biotop.owl#OrganPart</seealso>
    let OrganPart = Prefixed_Name(biotop, "OrganPart") |> PrefixedName
    /// <summary>
    ///   <para>biotop:OrganSystem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"organ system"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#OrganSystem">http://purl.org/biotop/biotop.owl#OrganSystem</seealso>
    let OrganSystem = Prefixed_Name(biotop, "OrganSystem") |> PrefixedName
    /// <summary>
    ///   <para>biotop:OrganSystemPart</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"organ system part"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#OrganSystemPart">http://purl.org/biotop/biotop.owl#OrganSystemPart</seealso>
    let OrganSystemPart = Prefixed_Name(biotop, "OrganSystemPart") |> PrefixedName

    /// <summary>
    ///   <para>biotop:OrganicMolecularEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"organic molecular entity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#OrganicMolecularEntity">http://purl.org/biotop/biotop.owl#OrganicMolecularEntity</seealso>
    let OrganicMolecularEntity =
        Prefixed_Name(biotop, "OrganicMolecularEntity") |> PrefixedName

    /// <summary>
    ///   <para>biotop:OrganicMolecularEntityPartition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Ontologically irrelevant partitioning node. Used for improving ontology housekeeping. Its purpose is to express that all subclasses are mutually disjoint."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#OrganicMolecularEntityPartition">http://purl.org/biotop/biotop.owl#OrganicMolecularEntityPartition</seealso>
    let OrganicMolecularEntityPartition =
        Prefixed_Name(biotop, "OrganicMolecularEntityPartition") |> PrefixedName

    /// <summary>
    ///   <para>biotop:OrganismAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"organism action"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#OrganismAction">http://purl.org/biotop/biotop.owl#OrganismAction</seealso>
    let OrganismAction = Prefixed_Name(biotop, "OrganismAction") |> PrefixedName

    /// <summary>
    ///   <para>biotop:OrganismByDevelopmentalStagePartition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#OrganismByDevelopmentalStagePartition">http://purl.org/biotop/biotop.owl#OrganismByDevelopmentalStagePartition</seealso>
    let OrganismByDevelopmentalStagePartition =
        Prefixed_Name(biotop, "OrganismByDevelopmentalStagePartition") |> PrefixedName

    /// <summary>
    ///   <para>biotop:OrganismByTaxonPartition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Ontologically irrelevant partitioning node. Used for improving ontology housekeeping. Its purpose is to express that all subclasses are mutually disjoint."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#OrganismByTaxonPartition">http://purl.org/biotop/biotop.owl#OrganismByTaxonPartition</seealso>
    let OrganismByTaxonPartition =
        Prefixed_Name(biotop, "OrganismByTaxonPartition") |> PrefixedName

    /// <summary>
    ///   <para>biotop:OrganismInteraction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"organism interaction"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#OrganismInteraction">http://purl.org/biotop/biotop.owl#OrganismInteraction</seealso>
    let OrganismInteraction =
        Prefixed_Name(biotop, "OrganismInteraction") |> PrefixedName

    /// <summary>
    ///   <para>biotop:OrganismPart</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"organism part"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#OrganismPart">http://purl.org/biotop/biotop.owl#OrganismPart</seealso>
    let OrganismPart = Prefixed_Name(biotop, "OrganismPart") |> PrefixedName
    /// <summary>
    ///   <para>biotop:OrganismProcess</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"organism process"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#OrganismProcess">http://purl.org/biotop/biotop.owl#OrganismProcess</seealso>
    let OrganismProcess = Prefixed_Name(biotop, "OrganismProcess") |> PrefixedName
    /// <summary>
    ///   <para>biotop:Organization</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"organization"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#Organization">http://purl.org/biotop/biotop.owl#Organization</seealso>
    let Organization = Prefixed_Name(biotop, "Organization") |> PrefixedName
    /// <summary>
    ///   <para>biotop:ParentRole</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"parent role"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#ParentRole">http://purl.org/biotop/biotop.owl#ParentRole</seealso>
    let ParentRole = Prefixed_Name(biotop, "ParentRole") |> PrefixedName
    /// <summary>
    ///   <para>biotop:Particular</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#Particular">http://purl.org/biotop/biotop.owl#Particular</seealso>
    let Particular = Prefixed_Name(biotop, "Particular") |> PrefixedName
    /// <summary>
    ///   <para>biotop:ParticularEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#ParticularEntity">http://purl.org/biotop/biotop.owl#ParticularEntity</seealso>
    let ParticularEntity = Prefixed_Name(biotop, "ParticularEntity") |> PrefixedName

    /// <summary>
    ///   <para>biotop:PathologicalCondition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"pathological condition"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#PathologicalCondition">http://purl.org/biotop/biotop.owl#PathologicalCondition</seealso>
    let PathologicalCondition =
        Prefixed_Name(biotop, "PathologicalCondition") |> PrefixedName

    /// <summary>
    ///   <para>biotop:PathologicalDisposition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"pathological disposition"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#PathologicalDisposition">http://purl.org/biotop/biotop.owl#PathologicalDisposition</seealso>
    let PathologicalDisposition =
        Prefixed_Name(biotop, "PathologicalDisposition") |> PrefixedName

    /// <summary>
    ///   <para>biotop:PathologicalProcess</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"pathological process"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#PathologicalProcess">http://purl.org/biotop/biotop.owl#PathologicalProcess</seealso>
    let PathologicalProcess =
        Prefixed_Name(biotop, "PathologicalProcess") |> PrefixedName

    /// <summary>
    ///   <para>biotop:PathologicalStaticProcessualEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Condition of an organism that deviates from what is considered normal. Often referred to by the terms "disorder", "disease", "syndrome", "sign", or "symptom". None of these denote clearly delineated ontological categories.
    ///
    /// See disease role etc."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"pathological static processual entity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#PathologicalStaticProcessualEntity">http://purl.org/biotop/biotop.owl#PathologicalStaticProcessualEntity</seealso>
    let PathologicalStaticProcessualEntity =
        Prefixed_Name(biotop, "PathologicalStaticProcessualEntity") |> PrefixedName

    /// <summary>
    ///   <para>biotop:PathologicalStructure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"pathological structure"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#PathologicalStructure">http://purl.org/biotop/biotop.owl#PathologicalStructure</seealso>
    let PathologicalStructure =
        Prefixed_Name(biotop, "PathologicalStructure") |> PrefixedName

    /// <summary>
    ///   <para>biotop:PathologicalValueRegion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"pathological value region"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#PathologicalValueRegion">http://purl.org/biotop/biotop.owl#PathologicalValueRegion</seealso>
    let PathologicalValueRegion =
        Prefixed_Name(biotop, "PathologicalValueRegion") |> PrefixedName

    /// <summary>
    ///   <para>biotop:PeptideFunction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"peptide function"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#PeptideFunction">http://purl.org/biotop/biotop.owl#PeptideFunction</seealso>
    let PeptideFunction = Prefixed_Name(biotop, "PeptideFunction") |> PrefixedName
    /// <summary>
    ///   <para>biotop:PeptideStructure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Comment: We here use the term peptide in the most general sense, viz. a oligo or polymer made out of amino acids."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"peptide structure"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#PeptideStructure">http://purl.org/biotop/biotop.owl#PeptideStructure</seealso>
    let PeptideStructure = Prefixed_Name(biotop, "PeptideStructure") |> PrefixedName
    /// <summary>
    ///   <para>biotop:Phosphate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"phosphate"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#Phosphate">http://purl.org/biotop/biotop.owl#Phosphate</seealso>
    let Phosphate = Prefixed_Name(biotop, "Phosphate") |> PrefixedName

    /// <summary>
    ///   <para>biotop:PhylumArthropodaValueRegion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"EXAMPLE OF TAXON REGION"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"phylum arthropoda value region"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#PhylumArthropodaValueRegion">http://purl.org/biotop/biotop.owl#PhylumArthropodaValueRegion</seealso>
    let PhylumArthropodaValueRegion =
        Prefixed_Name(biotop, "PhylumArthropodaValueRegion") |> PrefixedName

    /// <summary>
    ///   <para>biotop:PhylumAscomycotaValueRegion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"EXAMPLE OF TAXON REGION"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"phylum ascomycota value region"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#PhylumAscomycotaValueRegion">http://purl.org/biotop/biotop.owl#PhylumAscomycotaValueRegion</seealso>
    let PhylumAscomycotaValueRegion =
        Prefixed_Name(biotop, "PhylumAscomycotaValueRegion") |> PrefixedName

    /// <summary>
    ///   <para>biotop:PhylumChordataValueRegion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"EXAMPLE OF TAXON REGION"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"phylum chordata value region"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#PhylumChordataValueRegion">http://purl.org/biotop/biotop.owl#PhylumChordataValueRegion</seealso>
    let PhylumChordataValueRegion =
        Prefixed_Name(biotop, "PhylumChordataValueRegion") |> PrefixedName

    /// <summary>
    ///   <para>biotop:PhylumProteobacteriaValueRegion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"EXAMPLE OF TAXON REGION"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"phylum proteobacteria value region"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#PhylumProteobacteriaValueRegion">http://purl.org/biotop/biotop.owl#PhylumProteobacteriaValueRegion</seealso>
    let PhylumProteobacteriaValueRegion =
        Prefixed_Name(biotop, "PhylumProteobacteriaValueRegion") |> PrefixedName

    /// <summary>
    ///   <para>biotop:PhysicalBoundary</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"physical boundary"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#PhysicalBoundary">http://purl.org/biotop/biotop.owl#PhysicalBoundary</seealso>
    let PhysicalBoundary = Prefixed_Name(biotop, "PhysicalBoundary") |> PrefixedName
    /// <summary>
    ///   <para>biotop:PhysicalForce</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"physical force"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#PhysicalForce">http://purl.org/biotop/biotop.owl#PhysicalForce</seealso>
    let PhysicalForce = Prefixed_Name(biotop, "PhysicalForce") |> PrefixedName
    /// <summary>
    ///   <para>biotop:PhysicalLength</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"physical length"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#PhysicalLength">http://purl.org/biotop/biotop.owl#PhysicalLength</seealso>
    let PhysicalLength = Prefixed_Name(biotop, "PhysicalLength") |> PrefixedName
    /// <summary>
    ///   <para>biotop:PhysicalMass</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"physical mass"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#PhysicalMass">http://purl.org/biotop/biotop.owl#PhysicalMass</seealso>
    let PhysicalMass = Prefixed_Name(biotop, "PhysicalMass") |> PrefixedName

    /// <summary>
    ///   <para>biotop:PhysicalProcessualEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"physical processual entity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#PhysicalProcessualEntity">http://purl.org/biotop/biotop.owl#PhysicalProcessualEntity</seealso>
    let PhysicalProcessualEntity =
        Prefixed_Name(biotop, "PhysicalProcessualEntity") |> PrefixedName

    /// <summary>
    ///   <para>biotop:PhysicalState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"former name: StateOfAggregation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"physical state"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#PhysicalState">http://purl.org/biotop/biotop.owl#PhysicalState</seealso>
    let PhysicalState = Prefixed_Name(biotop, "PhysicalState") |> PrefixedName
    /// <summary>
    ///   <para>biotop:PhysicalVolume</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"physical volume"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#PhysicalVolume">http://purl.org/biotop/biotop.owl#PhysicalVolume</seealso>
    let PhysicalVolume = Prefixed_Name(biotop, "PhysicalVolume") |> PrefixedName
    /// <summary>
    ///   <para>biotop:PhysicianRole</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"physician role"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#PhysicianRole">http://purl.org/biotop/biotop.owl#PhysicianRole</seealso>
    let PhysicianRole = Prefixed_Name(biotop, "PhysicianRole") |> PrefixedName
    /// <summary>
    ///   <para>biotop:Plan</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"(OBI 344)"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"plan"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#Plan">http://purl.org/biotop/biotop.owl#Plan</seealso>
    let Plan = Prefixed_Name(biotop, "Plan") |> PrefixedName
    /// <summary>
    ///   <para>biotop:Plant</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"plant"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#Plant">http://purl.org/biotop/biotop.owl#Plant</seealso>
    let Plant = Prefixed_Name(biotop, "Plant") |> PrefixedName
    /// <summary>
    ///   <para>biotop:PlantCell</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"plant cell"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#PlantCell">http://purl.org/biotop/biotop.owl#PlantCell</seealso>
    let PlantCell = Prefixed_Name(biotop, "PlantCell") |> PrefixedName
    /// <summary>
    ///   <para>biotop:PlantPopulation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"EXAMPLE OF POPULATION"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"plant population"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#PlantPopulation">http://purl.org/biotop/biotop.owl#PlantPopulation</seealso>
    let PlantPopulation = Prefixed_Name(biotop, "PlantPopulation") |> PrefixedName

    /// <summary>
    ///   <para>biotop:PluralityOfIdenticalPolymolecularEntities</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"plurality of identical polymolecular entities"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#PluralityOfIdenticalPolymolecularEntities">http://purl.org/biotop/biotop.owl#PluralityOfIdenticalPolymolecularEntities</seealso>
    let PluralityOfIdenticalPolymolecularEntities =
        Prefixed_Name(biotop, "PluralityOfIdenticalPolymolecularEntities") |> PrefixedName

    /// <summary>
    ///   <para>biotop:PluralityOfOrganisms</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"plurality of organisms"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#PluralityOfOrganisms">http://purl.org/biotop/biotop.owl#PluralityOfOrganisms</seealso>
    let PluralityOfOrganisms =
        Prefixed_Name(biotop, "PluralityOfOrganisms") |> PrefixedName

    /// <summary>
    ///   <para>biotop:PointInTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"point in time"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#PointInTime">http://purl.org/biotop/biotop.owl#PointInTime</seealso>
    let PointInTime = Prefixed_Name(biotop, "PointInTime") |> PrefixedName
    /// <summary>
    ///   <para>biotop:PoisonRole</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"poison role"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#PoisonRole">http://purl.org/biotop/biotop.owl#PoisonRole</seealso>
    let PoisonRole = Prefixed_Name(biotop, "PoisonRole") |> PrefixedName
    /// <summary>
    ///   <para>biotop:Poisoning</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"negatively affecting the integrity of a biologival system caused by one or more chemical substances"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"poisoning"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#Poisoning">http://purl.org/biotop/biotop.owl#Poisoning</seealso>
    let Poisoning = Prefixed_Name(biotop, "Poisoning") |> PrefixedName

    /// <summary>
    ///   <para>biotop:PolyMolecularCompositeEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"poly molecular composite entity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#PolyMolecularCompositeEntity">http://purl.org/biotop/biotop.owl#PolyMolecularCompositeEntity</seealso>
    let PolyMolecularCompositeEntity =
        Prefixed_Name(biotop, "PolyMolecularCompositeEntity") |> PrefixedName

    /// <summary>
    ///   <para>biotop:Population</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"all child classes of population are only meant as examples demonstrating how population classes can be postcoordinated"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"population"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#Population">http://purl.org/biotop/biotop.owl#Population</seealso>
    let Population = Prefixed_Name(biotop, "Population") |> PrefixedName

    /// <summary>
    ///   <para>biotop:PortionOfHeterogenousLiquid</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"portion of heterogenous liquid"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#PortionOfHeterogenousLiquid">http://purl.org/biotop/biotop.owl#PortionOfHeterogenousLiquid</seealso>
    let PortionOfHeterogenousLiquid =
        Prefixed_Name(biotop, "PortionOfHeterogenousLiquid") |> PrefixedName

    /// <summary>
    ///   <para>biotop:PortionOfHeterogenousSolid</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"portion of heterogenous solid"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#PortionOfHeterogenousSolid">http://purl.org/biotop/biotop.owl#PortionOfHeterogenousSolid</seealso>
    let PortionOfHeterogenousSolid =
        Prefixed_Name(biotop, "PortionOfHeterogenousSolid") |> PrefixedName

    /// <summary>
    ///   <para>biotop:PortionOfHomogenousMatter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"portion of homogenous matter"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#PortionOfHomogenousMatter">http://purl.org/biotop/biotop.owl#PortionOfHomogenousMatter</seealso>
    let PortionOfHomogenousMatter =
        Prefixed_Name(biotop, "PortionOfHomogenousMatter") |> PrefixedName

    /// <summary>
    ///   <para>biotop:PreventionAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"prevention action"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#PreventionAction">http://purl.org/biotop/biotop.owl#PreventionAction</seealso>
    let PreventionAction = Prefixed_Name(biotop, "PreventionAction") |> PrefixedName
    /// <summary>
    ///   <para>biotop:PreventiveRole</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"preventive role"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#PreventiveRole">http://purl.org/biotop/biotop.owl#PreventiveRole</seealso>
    let PreventiveRole = Prefixed_Name(biotop, "PreventiveRole") |> PrefixedName
    /// <summary>
    ///   <para>biotop:Primate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"one primate"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"primate"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#Primate">http://purl.org/biotop/biotop.owl#Primate</seealso>
    let Primate = Prefixed_Name(biotop, "Primate") |> PrefixedName
    /// <summary>
    ///   <para>biotop:PrimatePopulation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"EXAMPLE OF POPULATION"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"primate population"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#PrimatePopulation">http://purl.org/biotop/biotop.owl#PrimatePopulation</seealso>
    let PrimatePopulation = Prefixed_Name(biotop, "PrimatePopulation") |> PrefixedName
    /// <summary>
    ///   <para>biotop:Process</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"process"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#Process">http://purl.org/biotop/biotop.owl#Process</seealso>
    let Process = Prefixed_Name(biotop, "Process") |> PrefixedName
    /// <summary>
    ///   <para>biotop:ProcessQuality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"process quality"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#ProcessQuality">http://purl.org/biotop/biotop.owl#ProcessQuality</seealso>
    let ProcessQuality = Prefixed_Name(biotop, "ProcessQuality") |> PrefixedName
    /// <summary>
    ///   <para>biotop:Producing</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"producing"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#Producing">http://purl.org/biotop/biotop.owl#Producing</seealso>
    let Producing = Prefixed_Name(biotop, "Producing") |> PrefixedName
    /// <summary>
    ///   <para>biotop:Prokaryote</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"prokaryote"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#Prokaryote">http://purl.org/biotop/biotop.owl#Prokaryote</seealso>
    let Prokaryote = Prefixed_Name(biotop, "Prokaryote") |> PrefixedName
    /// <summary>
    ///   <para>biotop:ProteinComplex</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"protein complex"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#ProteinComplex">http://purl.org/biotop/biotop.owl#ProteinComplex</seealso>
    let ProteinComplex = Prefixed_Name(biotop, "ProteinComplex") |> PrefixedName
    /// <summary>
    ///   <para>biotop:ProteinDomain</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"protein domain"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#ProteinDomain">http://purl.org/biotop/biotop.owl#ProteinDomain</seealso>
    let ProteinDomain = Prefixed_Name(biotop, "ProteinDomain") |> PrefixedName

    /// <summary>
    ///   <para>biotop:ProteinSubstructure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"protein substructure"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#ProteinSubstructure">http://purl.org/biotop/biotop.owl#ProteinSubstructure</seealso>
    let ProteinSubstructure =
        Prefixed_Name(biotop, "ProteinSubstructure") |> PrefixedName

    /// <summary>
    ///   <para>biotop:ProteinSubunit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"protein subunit"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#ProteinSubunit">http://purl.org/biotop/biotop.owl#ProteinSubunit</seealso>
    let ProteinSubunit = Prefixed_Name(biotop, "ProteinSubunit") |> PrefixedName
    /// <summary>
    ///   <para>biotop:Protist</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"protist"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#Protist">http://purl.org/biotop/biotop.owl#Protist</seealso>
    let Protist = Prefixed_Name(biotop, "Protist") |> PrefixedName
    /// <summary>
    ///   <para>biotop:ProtistPopulation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"EXAMPLE OF POPULATION"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"protist population"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#ProtistPopulation">http://purl.org/biotop/biotop.owl#ProtistPopulation</seealso>
    let ProtistPopulation = Prefixed_Name(biotop, "ProtistPopulation") |> PrefixedName
    /// <summary>
    ///   <para>biotop:Proton</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"proton"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#Proton">http://purl.org/biotop/biotop.owl#Proton</seealso>
    let Proton = Prefixed_Name(biotop, "Proton") |> PrefixedName
    /// <summary>
    ///   <para>biotop:Quality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Quality"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#Quality">http://purl.org/biotop/biotop.owl#Quality</seealso>
    let Quality = Prefixed_Name(biotop, "Quality") |> PrefixedName
    /// <summary>
    ///   <para>biotop:RNAChain</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"RNA chain"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#RNAChain">http://purl.org/biotop/biotop.owl#RNAChain</seealso>
    let RNAChain = Prefixed_Name(biotop, "RNAChain") |> PrefixedName
    /// <summary>
    ///   <para>biotop:Radiation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"radiation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#Radiation">http://purl.org/biotop/biotop.owl#Radiation</seealso>
    let Radiation = Prefixed_Name(biotop, "Radiation") |> PrefixedName
    /// <summary>
    ///   <para>biotop:ReagentRole</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"reagent role"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#ReagentRole">http://purl.org/biotop/biotop.owl#ReagentRole</seealso>
    let ReagentRole = Prefixed_Name(biotop, "ReagentRole") |> PrefixedName
    /// <summary>
    ///   <para>biotop:ReceptorRole</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"receptor role"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#ReceptorRole">http://purl.org/biotop/biotop.owl#ReceptorRole</seealso>
    let ReceptorRole = Prefixed_Name(biotop, "ReceptorRole") |> PrefixedName
    /// <summary>
    ///   <para>biotop:RegulationOrLaw</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"regulation or law"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#RegulationOrLaw">http://purl.org/biotop/biotop.owl#RegulationOrLaw</seealso>
    let RegulationOrLaw = Prefixed_Name(biotop, "RegulationOrLaw") |> PrefixedName
    /// <summary>
    ///   <para>biotop:RegulatoryBody</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"regulatory body"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#RegulatoryBody">http://purl.org/biotop/biotop.owl#RegulatoryBody</seealso>
    let RegulatoryBody = Prefixed_Name(biotop, "RegulatoryBody") |> PrefixedName
    /// <summary>
    ///   <para>biotop:Reptile</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"reptile"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#Reptile">http://purl.org/biotop/biotop.owl#Reptile</seealso>
    let Reptile = Prefixed_Name(biotop, "Reptile") |> PrefixedName
    /// <summary>
    ///   <para>biotop:ResearcherRole</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"researcher role"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#ResearcherRole">http://purl.org/biotop/biotop.owl#ResearcherRole</seealso>
    let ResearcherRole = Prefixed_Name(biotop, "ResearcherRole") |> PrefixedName
    /// <summary>
    ///   <para>biotop:RickettsiaCell</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"rickettsia cell"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#RickettsiaCell">http://purl.org/biotop/biotop.owl#RickettsiaCell</seealso>
    let RickettsiaCell = Prefixed_Name(biotop, "RickettsiaCell") |> PrefixedName
    /// <summary>
    ///   <para>biotop:Role</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"role"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#Role">http://purl.org/biotop/biotop.owl#Role</seealso>
    let Role = Prefixed_Name(biotop, "Role") |> PrefixedName
    /// <summary>
    ///   <para>biotop:SiblingRole</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"sibling role"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#SiblingRole">http://purl.org/biotop/biotop.owl#SiblingRole</seealso>
    let SiblingRole = Prefixed_Name(biotop, "SiblingRole") |> PrefixedName
    /// <summary>
    ///   <para>biotop:SignOrSymptomRole</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"sign or symptom role"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#SignOrSymptomRole">http://purl.org/biotop/biotop.owl#SignOrSymptomRole</seealso>
    let SignOrSymptomRole = Prefixed_Name(biotop, "SignOrSymptomRole") |> PrefixedName
    /// <summary>
    ///   <para>biotop:SignallingRole</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"signalling role"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#SignallingRole">http://purl.org/biotop/biotop.owl#SignallingRole</seealso>
    let SignallingRole = Prefixed_Name(biotop, "SignallingRole") |> PrefixedName
    /// <summary>
    ///   <para>biotop:SocialAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"social action"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#SocialAction">http://purl.org/biotop/biotop.owl#SocialAction</seealso>
    let SocialAction = Prefixed_Name(biotop, "SocialAction") |> PrefixedName
    /// <summary>
    ///   <para>biotop:SocialBehavior</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"social behavior"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#SocialBehavior">http://purl.org/biotop/biotop.owl#SocialBehavior</seealso>
    let SocialBehavior = Prefixed_Name(biotop, "SocialBehavior") |> PrefixedName
    /// <summary>
    ///   <para>biotop:SolidValueRegion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>""solid" as the value of a states of matter. E.g. a stone has a quality which has its value located in "solid value region""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"solid value region"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#SolidValueRegion">http://purl.org/biotop/biotop.owl#SolidValueRegion</seealso>
    let SolidValueRegion = Prefixed_Name(biotop, "SolidValueRegion") |> PrefixedName

    /// <summary>
    ///   <para>biotop:SpatialReferenceRole</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"spatial reference role"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#SpatialReferenceRole">http://purl.org/biotop/biotop.owl#SpatialReferenceRole</seealso>
    let SpatialReferenceRole =
        Prefixed_Name(biotop, "SpatialReferenceRole") |> PrefixedName

    /// <summary>
    ///   <para>biotop:SpatialRegion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"spatial region"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#SpatialRegion">http://purl.org/biotop/biotop.owl#SpatialRegion</seealso>
    let SpatialRegion = Prefixed_Name(biotop, "SpatialRegion") |> PrefixedName

    /// <summary>
    ///   <para>biotop:SpeciesCandidaAlbicansValueRegion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"EXAMPLE OF TAXON REGION"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"species candida albicans value region"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#SpeciesCandidaAlbicansValueRegion">http://purl.org/biotop/biotop.owl#SpeciesCandidaAlbicansValueRegion</seealso>
    let SpeciesCandidaAlbicansValueRegion =
        Prefixed_Name(biotop, "SpeciesCandidaAlbicansValueRegion") |> PrefixedName

    /// <summary>
    ///   <para>biotop:SpeciesDrosophilaMelanogasterValueRegion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"EXAMPLE OF TAXON REGION"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"species drosophila melanogaster value region"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#SpeciesDrosophilaMelanogasterValueRegion">http://purl.org/biotop/biotop.owl#SpeciesDrosophilaMelanogasterValueRegion</seealso>
    let SpeciesDrosophilaMelanogasterValueRegion =
        Prefixed_Name(biotop, "SpeciesDrosophilaMelanogasterValueRegion") |> PrefixedName

    /// <summary>
    ///   <para>biotop:SpeciesEscherichiaColiValueRegion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"EXAMPLE OF TAXON REGION"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"species escherichia coli value region"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#SpeciesEscherichiaColiValueRegion">http://purl.org/biotop/biotop.owl#SpeciesEscherichiaColiValueRegion</seealso>
    let SpeciesEscherichiaColiValueRegion =
        Prefixed_Name(biotop, "SpeciesEscherichiaColiValueRegion") |> PrefixedName

    /// <summary>
    ///   <para>biotop:SpeciesHomoSapiensValueRegion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"EXAMPLE OF TAXON REGION"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"species homo sapiens value region"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#SpeciesHomoSapiensValueRegion">http://purl.org/biotop/biotop.owl#SpeciesHomoSapiensValueRegion</seealso>
    let SpeciesHomoSapiensValueRegion =
        Prefixed_Name(biotop, "SpeciesHomoSapiensValueRegion") |> PrefixedName

    /// <summary>
    ///   <para>biotop:SpeciesSaccharomycesCerevisiaeValueRegion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"EXAMPLE OF TAXON REGION"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"species saccharomyces cerevisiae value region"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#SpeciesSaccharomycesCerevisiaeValueRegion">http://purl.org/biotop/biotop.owl#SpeciesSaccharomycesCerevisiaeValueRegion</seealso>
    let SpeciesSaccharomycesCerevisiaeValueRegion =
        Prefixed_Name(biotop, "SpeciesSaccharomycesCerevisiaeValueRegion") |> PrefixedName

    /// <summary>
    ///   <para>biotop:StateOfMatter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"state of matter"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#StateOfMatter">http://purl.org/biotop/biotop.owl#StateOfMatter</seealso>
    let StateOfMatter = Prefixed_Name(biotop, "StateOfMatter") |> PrefixedName

    /// <summary>
    ///   <para>biotop:StateOfMatterValueRegion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"state of matter value region"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#StateOfMatterValueRegion">http://purl.org/biotop/biotop.owl#StateOfMatterValueRegion</seealso>
    let StateOfMatterValueRegion =
        Prefixed_Name(biotop, "StateOfMatterValueRegion") |> PrefixedName

    /// <summary>
    ///   <para>biotop:StaticProcessualEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Static condition as a special case of process in which temporal parts are neglected.  "^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"static processual entity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#StaticProcessualEntity">http://purl.org/biotop/biotop.owl#StaticProcessualEntity</seealso>
    let StaticProcessualEntity =
        Prefixed_Name(biotop, "StaticProcessualEntity") |> PrefixedName

    /// <summary>
    ///   <para>biotop:Steroid</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"steroid"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#Steroid">http://purl.org/biotop/biotop.owl#Steroid</seealso>
    let Steroid = Prefixed_Name(biotop, "Steroid") |> PrefixedName

    /// <summary>
    ///   <para>biotop:StructuredBiologicalCompoundByCanonicityPartition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"*"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#StructuredBiologicalCompoundByCanonicityPartition">http://purl.org/biotop/biotop.owl#StructuredBiologicalCompoundByCanonicityPartition</seealso>
    let StructuredBiologicalCompoundByCanonicityPartition =
        Prefixed_Name(biotop, "StructuredBiologicalCompoundByCanonicityPartition") |> PrefixedName

    /// <summary>
    ///   <para>biotop:StructuredBiologicalCompoundByGranularityPartition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"StructuredBiologicalCompoundByGranularityPartition
    ///
    /// ontologically irrelevant disjoint partition: structured biological compound by granularity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"*"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#StructuredBiologicalCompoundByGranularityPartition">http://purl.org/biotop/biotop.owl#StructuredBiologicalCompoundByGranularityPartition</seealso>
    let StructuredBiologicalCompoundByGranularityPartition =
        Prefixed_Name(biotop, "StructuredBiologicalCompoundByGranularityPartition") |> PrefixedName

    /// <summary>
    ///   <para>biotop:StructuredBiologicalEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"structured biological entity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#StructuredBiologicalEntity">http://purl.org/biotop/biotop.owl#StructuredBiologicalEntity</seealso>
    let StructuredBiologicalEntity =
        Prefixed_Name(biotop, "StructuredBiologicalEntity") |> PrefixedName

    /// <summary>
    ///   <para>biotop:StructuredNonbiologicalCompound</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"structured nonbiological compound"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#StructuredNonbiologicalCompound">http://purl.org/biotop/biotop.owl#StructuredNonbiologicalCompound</seealso>
    let StructuredNonbiologicalCompound =
        Prefixed_Name(biotop, "StructuredNonbiologicalCompound") |> PrefixedName

    /// <summary>
    ///   <para>biotop:SubatomicEntityByChargePartition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"*"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#SubatomicEntityByChargePartition">http://purl.org/biotop/biotop.owl#SubatomicEntityByChargePartition</seealso>
    let SubatomicEntityByChargePartition =
        Prefixed_Name(biotop, "SubatomicEntityByChargePartition") |> PrefixedName

    /// <summary>
    ///   <para>biotop:SubatomicParticle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"subatomic particle"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#SubatomicParticle">http://purl.org/biotop/biotop.owl#SubatomicParticle</seealso>
    let SubatomicParticle = Prefixed_Name(biotop, "SubatomicParticle") |> PrefixedName

    /// <summary>
    ///   <para>biotop:SubfamilyDrosophilinaeValueRegion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"EXAMPLE OF TAXON REGION"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"subfamily drosophilinae value region"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#SubfamilyDrosophilinaeValueRegion">http://purl.org/biotop/biotop.owl#SubfamilyDrosophilinaeValueRegion</seealso>
    let SubfamilyDrosophilinaeValueRegion =
        Prefixed_Name(biotop, "SubfamilyDrosophilinaeValueRegion") |> PrefixedName

    /// <summary>
    ///   <para>biotop:SubjectOfCareRole</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"subject of care role"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#SubjectOfCareRole">http://purl.org/biotop/biotop.owl#SubjectOfCareRole</seealso>
    let SubjectOfCareRole = Prefixed_Name(biotop, "SubjectOfCareRole") |> PrefixedName
    /// <summary>
    ///   <para>biotop:SubmolecularGroup</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A submolecular group or moiety is a group of covalently bound atoms that occurs only as part of a molecule"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"submolecular group"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#SubmolecularGroup">http://purl.org/biotop/biotop.owl#SubmolecularGroup</seealso>
    let SubmolecularGroup = Prefixed_Name(biotop, "SubmolecularGroup") |> PrefixedName

    /// <summary>
    ///   <para>biotop:SubphylumSaccharomycotinaValueRegion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"EXAMPLE OF TAXON REGION"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"subphylum saccharomycotina value region"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#SubphylumSaccharomycotinaValueRegion">http://purl.org/biotop/biotop.owl#SubphylumSaccharomycotinaValueRegion</seealso>
    let SubphylumSaccharomycotinaValueRegion =
        Prefixed_Name(biotop, "SubphylumSaccharomycotinaValueRegion") |> PrefixedName

    /// <summary>
    ///   <para>biotop:SubphylumVertebrataValueRegion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"EXAMPLE OF TAXON REGION"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"subphylum vertebrata value region"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#SubphylumVertebrataValueRegion">http://purl.org/biotop/biotop.owl#SubphylumVertebrataValueRegion</seealso>
    let SubphylumVertebrataValueRegion =
        Prefixed_Name(biotop, "SubphylumVertebrataValueRegion") |> PrefixedName

    /// <summary>
    ///   <para>biotop:SubstanceInteraction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"substance interaction"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#SubstanceInteraction">http://purl.org/biotop/biotop.owl#SubstanceInteraction</seealso>
    let SubstanceInteraction =
        Prefixed_Name(biotop, "SubstanceInteraction") |> PrefixedName

    /// <summary>
    ///   <para>biotop:Syncytium</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"syncytium"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#Syncytium">http://purl.org/biotop/biotop.owl#Syncytium</seealso>
    let Syncytium = Prefixed_Name(biotop, "Syncytium") |> PrefixedName
    /// <summary>
    ///   <para>biotop:TaxonQuality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"taxon quality"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#TaxonQuality">http://purl.org/biotop/biotop.owl#TaxonQuality</seealso>
    let TaxonQuality = Prefixed_Name(biotop, "TaxonQuality") |> PrefixedName
    /// <summary>
    ///   <para>biotop:TaxonValueRegion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"taxon value region"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#TaxonValueRegion">http://purl.org/biotop/biotop.owl#TaxonValueRegion</seealso>
    let TaxonValueRegion = Prefixed_Name(biotop, "TaxonValueRegion") |> PrefixedName
    /// <summary>
    ///   <para>biotop:TemporalEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#TemporalEntity">http://purl.org/biotop/biotop.owl#TemporalEntity</seealso>
    let TemporalEntity = Prefixed_Name(biotop, "TemporalEntity") |> PrefixedName
    /// <summary>
    ///   <para>biotop:TherapeuticRole</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"therapeutic role"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#TherapeuticRole">http://purl.org/biotop/biotop.owl#TherapeuticRole</seealso>
    let TherapeuticRole = Prefixed_Name(biotop, "TherapeuticRole") |> PrefixedName
    /// <summary>
    ///   <para>biotop:Time</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"time"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#Time">http://purl.org/biotop/biotop.owl#Time</seealso>
    let Time = Prefixed_Name(biotop, "Time") |> PrefixedName
    /// <summary>
    ///   <para>biotop:TimeInterval</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"time interval"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#TimeInterval">http://purl.org/biotop/biotop.owl#TimeInterval</seealso>
    let TimeInterval = Prefixed_Name(biotop, "TimeInterval") |> PrefixedName
    /// <summary>
    ///   <para>biotop:Tissue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"tissue"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#Tissue">http://purl.org/biotop/biotop.owl#Tissue</seealso>
    let Tissue = Prefixed_Name(biotop, "Tissue") |> PrefixedName
    /// <summary>
    ///   <para>biotop:TissueProcess</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"tissue process"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#TissueProcess">http://purl.org/biotop/biotop.owl#TissueProcess</seealso>
    let TissueProcess = Prefixed_Name(biotop, "TissueProcess") |> PrefixedName
    /// <summary>
    ///   <para>biotop:Treating</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"treating"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#Treating">http://purl.org/biotop/biotop.owl#Treating</seealso>
    let Treating = Prefixed_Name(biotop, "Treating") |> PrefixedName
    /// <summary>
    ///   <para>biotop:TreatingCondition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"treating condition"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#TreatingCondition">http://purl.org/biotop/biotop.owl#TreatingCondition</seealso>
    let TreatingCondition = Prefixed_Name(biotop, "TreatingCondition") |> PrefixedName
    /// <summary>
    ///   <para>biotop:TreatingOrganism</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"treating organism"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#TreatingOrganism">http://purl.org/biotop/biotop.owl#TreatingOrganism</seealso>
    let TreatingOrganism = Prefixed_Name(biotop, "TreatingOrganism") |> PrefixedName

    /// <summary>
    ///   <para>biotop:TwoDimensionalBiologicalEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"two dimensional biological entity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#TwoDimensionalBiologicalEntity">http://purl.org/biotop/biotop.owl#TwoDimensionalBiologicalEntity</seealso>
    let TwoDimensionalBiologicalEntity =
        Prefixed_Name(biotop, "TwoDimensionalBiologicalEntity") |> PrefixedName

    /// <summary>
    ///   <para>biotop:TwoDimensionalBoundary</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"two dimensional boundary"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#TwoDimensionalBoundary">http://purl.org/biotop/biotop.owl#TwoDimensionalBoundary</seealso>
    let TwoDimensionalBoundary =
        Prefixed_Name(biotop, "TwoDimensionalBoundary") |> PrefixedName

    /// <summary>
    ///   <para>biotop:TwoDimensionalPhysicalEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"two dimensional physical entity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#TwoDimensionalPhysicalEntity">http://purl.org/biotop/biotop.owl#TwoDimensionalPhysicalEntity</seealso>
    let TwoDimensionalPhysicalEntity =
        Prefixed_Name(biotop, "TwoDimensionalPhysicalEntity") |> PrefixedName

    /// <summary>
    ///   <para>biotop:UnicellularOrganism</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"unicellular organism"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#UnicellularOrganism">http://purl.org/biotop/biotop.owl#UnicellularOrganism</seealso>
    let UnicellularOrganism =
        Prefixed_Name(biotop, "UnicellularOrganism") |> PrefixedName

    /// <summary>
    ///   <para>biotop:UsingAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"using action"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#UsingAction">http://purl.org/biotop/biotop.owl#UsingAction</seealso>
    let UsingAction = Prefixed_Name(biotop, "UsingAction") |> PrefixedName
    /// <summary>
    ///   <para>biotop:ValueRegion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"value region"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#ValueRegion">http://purl.org/biotop/biotop.owl#ValueRegion</seealso>
    let ValueRegion = Prefixed_Name(biotop, "ValueRegion") |> PrefixedName
    /// <summary>
    ///   <para>biotop:Vertebrate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"one vertebrate"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"vertebrate"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#Vertebrate">http://purl.org/biotop/biotop.owl#Vertebrate</seealso>
    let Vertebrate = Prefixed_Name(biotop, "Vertebrate") |> PrefixedName

    /// <summary>
    ///   <para>biotop:VertebratePopulation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"EXAMPLE OF POPULATION"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"vertebrate population"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#VertebratePopulation">http://purl.org/biotop/biotop.owl#VertebratePopulation</seealso>
    let VertebratePopulation =
        Prefixed_Name(biotop, "VertebratePopulation") |> PrefixedName

    /// <summary>
    ///   <para>biotop:Virus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"virus"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#Virus">http://purl.org/biotop/biotop.owl#Virus</seealso>
    let Virus = Prefixed_Name(biotop, "Virus") |> PrefixedName
    /// <summary>
    ///   <para>biotop:VirusPopulation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"EXAMPLE OF POPULATION"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"virus population"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#VirusPopulation">http://purl.org/biotop/biotop.owl#VirusPopulation</seealso>
    let VirusPopulation = Prefixed_Name(biotop, "VirusPopulation") |> PrefixedName
    /// <summary>
    ///   <para>biotop:VitaminRole</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"vitamin role"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#VitaminRole">http://purl.org/biotop/biotop.owl#VitaminRole</seealso>
    let VitaminRole = Prefixed_Name(biotop, "VitaminRole") |> PrefixedName
    /// <summary>
    ///   <para>biotop:WaterMolecule</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"water molecule"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#WaterMolecule">http://purl.org/biotop/biotop.owl#WaterMolecule</seealso>
    let WaterMolecule = Prefixed_Name(biotop, "WaterMolecule") |> PrefixedName
    /// <summary>
    ///   <para>biotop:Wave</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"wave"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#Wave">http://purl.org/biotop/biotop.owl#Wave</seealso>
    let Wave = Prefixed_Name(biotop, "Wave") |> PrefixedName

    /// <summary>
    ///   <para>biotop:WellFormedBiologicalStructure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"well formed biological structure"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#WellFormedBiologicalStructure">http://purl.org/biotop/biotop.owl#WellFormedBiologicalStructure</seealso>
    let WellFormedBiologicalStructure =
        Prefixed_Name(biotop, "WellFormedBiologicalStructure") |> PrefixedName

    /// <summary>
    ///   <para>biotop:YeastCell</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Unicellular Fungi."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"yeast cell"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#YeastCell">http://purl.org/biotop/biotop.owl#YeastCell</seealso>
    let YeastCell = Prefixed_Name(biotop, "YeastCell") |> PrefixedName
    /// <summary>
    ///   <para>biotop:YeastPopulation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"EXAMPLE OF POPULATION"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"yeast population"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#YeastPopulation">http://purl.org/biotop/biotop.owl#YeastPopulation</seealso>
    let YeastPopulation = Prefixed_Name(biotop, "YeastPopulation") |> PrefixedName
    /// <summary>
    ///   <para>biotop:abstractPartOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"abstract part of"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#abstractPartOf">http://purl.org/biotop/biotop.owl#abstractPartOf</seealso>
    let abstractPartOf = Prefixed_Name(biotop, "abstractPartOf") |> PrefixedName

    /// <summary>
    ///   <para>biotop:abstractlyRelatedTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"abstractly related to"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#abstractlyRelatedTo">http://purl.org/biotop/biotop.owl#abstractlyRelatedTo</seealso>
    let abstractlyRelatedTo =
        Prefixed_Name(biotop, "abstractlyRelatedTo") |> PrefixedName

    /// <summary>
    ///   <para>biotop:agentIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"agent in"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#agentIn">http://purl.org/biotop/biotop.owl#agentIn</seealso>
    let agentIn = Prefixed_Name(biotop, "agentIn") |> PrefixedName
    /// <summary>
    ///   <para>biotop:attachedTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:SymmetricProperty</para>
    ///
    /// labels<para>"attached to"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#attachedTo">http://purl.org/biotop/biotop.owl#attachedTo</seealso>
    let attachedTo = Prefixed_Name(biotop, "attachedTo") |> PrefixedName
    /// <summary>
    ///   <para>biotop:bearerOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"bearer of"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#bearerOf">http://purl.org/biotop/biotop.owl#bearerOf</seealso>
    let bearerOf = Prefixed_Name(biotop, "bearerOf") |> PrefixedName
    /// <summary>
    ///   <para>biotop:branchOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"branch of"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#branchOf">http://purl.org/biotop/biotop.owl#branchOf</seealso>
    let branchOf = Prefixed_Name(biotop, "branchOf") |> PrefixedName
    /// <summary>
    ///   <para>biotop:causallyRelatedTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"causally related to"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#causallyRelatedTo">http://purl.org/biotop/biotop.owl#causallyRelatedTo</seealso>
    let causallyRelatedTo = Prefixed_Name(biotop, "causallyRelatedTo") |> PrefixedName
    /// <summary>
    ///   <para>biotop:causedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"caused by"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#causedBy">http://purl.org/biotop/biotop.owl#causedBy</seealso>
    let causedBy = Prefixed_Name(biotop, "causedBy") |> PrefixedName
    /// <summary>
    ///   <para>biotop:causes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"causes"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#causes">http://purl.org/biotop/biotop.owl#causes</seealso>
    let causes = Prefixed_Name(biotop, "causes") |> PrefixedName
    /// <summary>
    ///   <para>biotop:componentPartOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"component part of"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#componentPartOf">http://purl.org/biotop/biotop.owl#componentPartOf</seealso>
    let componentPartOf = Prefixed_Name(biotop, "componentPartOf") |> PrefixedName
    /// <summary>
    ///   <para>biotop:contiguousWith</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>owl:SymmetricProperty</para>
    ///
    /// labels<para>"contiguous with"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#contiguousWith">http://purl.org/biotop/biotop.owl#contiguousWith</seealso>
    let contiguousWith = Prefixed_Name(biotop, "contiguousWith") |> PrefixedName
    /// <summary>
    ///   <para>biotop:continuousWith</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"continuous with"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#continuousWith">http://purl.org/biotop/biotop.owl#continuousWith</seealso>
    let continuousWith = Prefixed_Name(biotop, "continuousWith") |> PrefixedName
    /// <summary>
    ///   <para>biotop:cooccurringWith</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:SymmetricProperty</para>
    ///
    /// labels<para>"cooccurring with"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#cooccurringWith">http://purl.org/biotop/biotop.owl#cooccurringWith</seealso>
    let cooccurringWith = Prefixed_Name(biotop, "cooccurringWith") |> PrefixedName
    /// <summary>
    ///   <para>biotop:denotedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"denoted by"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#denotedBy">http://purl.org/biotop/biotop.owl#denotedBy</seealso>
    let denotedBy = Prefixed_Name(biotop, "denotedBy") |> PrefixedName
    /// <summary>
    ///   <para>biotop:denotes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"denotes"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#denotes">http://purl.org/biotop/biotop.owl#denotes</seealso>
    let denotes = Prefixed_Name(biotop, "denotes") |> PrefixedName
    /// <summary>
    ///   <para>biotop:derivedInto</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"derived into"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#derivedInto">http://purl.org/biotop/biotop.owl#derivedInto</seealso>
    let derivedInto = Prefixed_Name(biotop, "derivedInto") |> PrefixedName
    /// <summary>
    ///   <para>biotop:derivesFrom</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"derives from"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#derivesFrom">http://purl.org/biotop/biotop.owl#derivesFrom</seealso>
    let derivesFrom = Prefixed_Name(biotop, "derivesFrom") |> PrefixedName
    /// <summary>
    ///   <para>biotop:encodedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"encodedBy"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#encodedBy">http://purl.org/biotop/biotop.owl#encodedBy</seealso>
    let encodedBy = Prefixed_Name(biotop, "encodedBy") |> PrefixedName
    /// <summary>
    ///   <para>biotop:encodes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"encodes"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#encodes">http://purl.org/biotop/biotop.owl#encodes</seealso>
    let encodes = Prefixed_Name(biotop, "encodes") |> PrefixedName
    /// <summary>
    ///   <para>biotop:featureOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"feature of"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#featureOf">http://purl.org/biotop/biotop.owl#featureOf</seealso>
    let featureOf = Prefixed_Name(biotop, "featureOf") |> PrefixedName
    /// <summary>
    ///   <para>biotop:granularPartOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"granular part of"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#granularPartOf">http://purl.org/biotop/biotop.owl#granularPartOf</seealso>
    let granularPartOf = Prefixed_Name(biotop, "granularPartOf") |> PrefixedName
    /// <summary>
    ///   <para>biotop:hasAbstractPart</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has abstract part"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#hasAbstractPart">http://purl.org/biotop/biotop.owl#hasAbstractPart</seealso>
    let hasAbstractPart = Prefixed_Name(biotop, "hasAbstractPart") |> PrefixedName
    /// <summary>
    ///   <para>biotop:hasAgent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has agent"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#hasAgent">http://purl.org/biotop/biotop.owl#hasAgent</seealso>
    let hasAgent = Prefixed_Name(biotop, "hasAgent") |> PrefixedName
    /// <summary>
    ///   <para>biotop:hasBranch</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has branch"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#hasBranch">http://purl.org/biotop/biotop.owl#hasBranch</seealso>
    let hasBranch = Prefixed_Name(biotop, "hasBranch") |> PrefixedName
    /// <summary>
    ///   <para>biotop:hasComponentPart</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"has component part"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#hasComponentPart">http://purl.org/biotop/biotop.owl#hasComponentPart</seealso>
    let hasComponentPart = Prefixed_Name(biotop, "hasComponentPart") |> PrefixedName
    /// <summary>
    ///   <para>biotop:hasDuration</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has duration"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#hasDuration">http://purl.org/biotop/biotop.owl#hasDuration</seealso>
    let hasDuration = Prefixed_Name(biotop, "hasDuration") |> PrefixedName
    /// <summary>
    ///   <para>biotop:hasFeature</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has feature"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#hasFeature">http://purl.org/biotop/biotop.owl#hasFeature</seealso>
    let hasFeature = Prefixed_Name(biotop, "hasFeature") |> PrefixedName
    /// <summary>
    ///   <para>biotop:hasGranularPart</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has granular part"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#hasGranularPart">http://purl.org/biotop/biotop.owl#hasGranularPart</seealso>
    let hasGranularPart = Prefixed_Name(biotop, "hasGranularPart") |> PrefixedName
    /// <summary>
    ///   <para>biotop:hasLocus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"has locus"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#hasLocus">http://purl.org/biotop/biotop.owl#hasLocus</seealso>
    let hasLocus = Prefixed_Name(biotop, "hasLocus") |> PrefixedName
    /// <summary>
    ///   <para>biotop:hasOrigin</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has origin"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#hasOrigin">http://purl.org/biotop/biotop.owl#hasOrigin</seealso>
    let hasOrigin = Prefixed_Name(biotop, "hasOrigin") |> PrefixedName
    /// <summary>
    ///   <para>biotop:hasOriginalPart</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has original part"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#hasOriginalPart">http://purl.org/biotop/biotop.owl#hasOriginalPart</seealso>
    let hasOriginalPart = Prefixed_Name(biotop, "hasOriginalPart") |> PrefixedName

    /// <summary>
    ///   <para>biotop:hasOriginatingPhysicalPart</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:TransitiveProperty</para>
    ///
    /// labels<para>"has originating physical part"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#hasOriginatingPhysicalPart">http://purl.org/biotop/biotop.owl#hasOriginatingPhysicalPart</seealso>
    let hasOriginatingPhysicalPart =
        Prefixed_Name(biotop, "hasOriginatingPhysicalPart") |> PrefixedName

    /// <summary>
    ///   <para>biotop:hasOutcome</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"has outcome"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#hasOutcome">http://purl.org/biotop/biotop.owl#hasOutcome</seealso>
    let hasOutcome = Prefixed_Name(biotop, "hasOutcome") |> PrefixedName
    /// <summary>
    ///   <para>biotop:hasParticipant</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"has participant"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#hasParticipant">http://purl.org/biotop/biotop.owl#hasParticipant</seealso>
    let hasParticipant = Prefixed_Name(biotop, "hasParticipant") |> PrefixedName
    /// <summary>
    ///   <para>biotop:hasPatient</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"has patient"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#hasPatient">http://purl.org/biotop/biotop.owl#hasPatient</seealso>
    let hasPatient = Prefixed_Name(biotop, "hasPatient") |> PrefixedName
    /// <summary>
    ///   <para>biotop:hasPhysicalPart</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:TransitiveProperty</para>
    ///
    /// labels<para>"has physical part"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#hasPhysicalPart">http://purl.org/biotop/biotop.owl#hasPhysicalPart</seealso>
    let hasPhysicalPart = Prefixed_Name(biotop, "hasPhysicalPart") |> PrefixedName
    /// <summary>
    ///   <para>biotop:hasPointInTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has point in time"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#hasPointInTime">http://purl.org/biotop/biotop.owl#hasPointInTime</seealso>
    let hasPointInTime = Prefixed_Name(biotop, "hasPointInTime") |> PrefixedName
    /// <summary>
    ///   <para>biotop:hasProcessQuality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has process quality"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#hasProcessQuality">http://purl.org/biotop/biotop.owl#hasProcessQuality</seealso>
    let hasProcessQuality = Prefixed_Name(biotop, "hasProcessQuality") |> PrefixedName
    /// <summary>
    ///   <para>biotop:hasProcessRole</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has process role"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#hasProcessRole">http://purl.org/biotop/biotop.owl#hasProcessRole</seealso>
    let hasProcessRole = Prefixed_Name(biotop, "hasProcessRole") |> PrefixedName
    /// <summary>
    ///   <para>biotop:hasProcessualPart</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:TransitiveProperty</para>
    ///
    /// labels<para>"has processual part"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#hasProcessualPart">http://purl.org/biotop/biotop.owl#hasProcessualPart</seealso>
    let hasProcessualPart = Prefixed_Name(biotop, "hasProcessualPart") |> PrefixedName

    /// <summary>
    ///   <para>biotop:hasProperPhysicalPart</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>owl:TransitiveProperty</para>
    ///
    /// labels<para>"has proper physical part"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#hasProperPhysicalPart">http://purl.org/biotop/biotop.owl#hasProperPhysicalPart</seealso>
    let hasProperPhysicalPart =
        Prefixed_Name(biotop, "hasProperPhysicalPart") |> PrefixedName

    /// <summary>
    ///   <para>biotop:hasRealization</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has realization"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#hasRealization">http://purl.org/biotop/biotop.owl#hasRealization</seealso>
    let hasRealization = Prefixed_Name(biotop, "hasRealization") |> PrefixedName
    /// <summary>
    ///   <para>biotop:inheresIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"inheres in"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#inheresIn">http://purl.org/biotop/biotop.owl#inheresIn</seealso>
    let inheresIn = Prefixed_Name(biotop, "inheresIn") |> PrefixedName
    /// <summary>
    ///   <para>biotop:isAbout</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is about"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#isAbout">http://purl.org/biotop/biotop.owl#isAbout</seealso>
    let isAbout = Prefixed_Name(biotop, "isAbout") |> PrefixedName
    /// <summary>
    ///   <para>biotop:locusOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"locus of"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#locusOf">http://purl.org/biotop/biotop.owl#locusOf</seealso>
    let locusOf = Prefixed_Name(biotop, "locusOf") |> PrefixedName
    /// <summary>
    ///   <para>biotop:originalPartOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"original part of"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#originalPartOf">http://purl.org/biotop/biotop.owl#originalPartOf</seealso>
    let originalPartOf = Prefixed_Name(biotop, "originalPartOf") |> PrefixedName
    /// <summary>
    ///   <para>biotop:originatesFrom</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"originates from"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#originatesFrom">http://purl.org/biotop/biotop.owl#originatesFrom</seealso>
    let originatesFrom = Prefixed_Name(biotop, "originatesFrom") |> PrefixedName

    /// <summary>
    ///   <para>biotop:originatingPhysicalPartOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"originating physical part of"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#originatingPhysicalPartOf">http://purl.org/biotop/biotop.owl#originatingPhysicalPartOf</seealso>
    let originatingPhysicalPartOf =
        Prefixed_Name(biotop, "originatingPhysicalPartOf") |> PrefixedName

    /// <summary>
    ///   <para>biotop:outcomeOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"outcome of"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#outcomeOf">http://purl.org/biotop/biotop.owl#outcomeOf</seealso>
    let outcomeOf = Prefixed_Name(biotop, "outcomeOf") |> PrefixedName
    /// <summary>
    ///   <para>biotop:participatesIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"participates in"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#participatesIn">http://purl.org/biotop/biotop.owl#participatesIn</seealso>
    let participatesIn = Prefixed_Name(biotop, "participatesIn") |> PrefixedName
    /// <summary>
    ///   <para>biotop:patientIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"patient in"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#patientIn">http://purl.org/biotop/biotop.owl#patientIn</seealso>
    let patientIn = Prefixed_Name(biotop, "patientIn") |> PrefixedName
    /// <summary>
    ///   <para>biotop:physicalLocationOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:TransitiveProperty</para>
    ///
    /// labels<para>"physical location of"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#physicalLocationOf">http://purl.org/biotop/biotop.owl#physicalLocationOf</seealso>
    let physicalLocationOf = Prefixed_Name(biotop, "physicalLocationOf") |> PrefixedName
    /// <summary>
    ///   <para>biotop:physicalPartOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:TransitiveProperty</para>
    ///
    /// labels<para>"physical part of"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#physicalPartOf">http://purl.org/biotop/biotop.owl#physicalPartOf</seealso>
    let physicalPartOf = Prefixed_Name(biotop, "physicalPartOf") |> PrefixedName

    /// <summary>
    ///   <para>biotop:physicallyAdjacentTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:SymmetricProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"physically adjacent to"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#physicallyAdjacentTo">http://purl.org/biotop/biotop.owl#physicallyAdjacentTo</seealso>
    let physicallyAdjacentTo =
        Prefixed_Name(biotop, "physicallyAdjacentTo") |> PrefixedName

    /// <summary>
    ///   <para>biotop:physicallyBoundedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"physically bounded by"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#physicallyBoundedBy">http://purl.org/biotop/biotop.owl#physicallyBoundedBy</seealso>
    let physicallyBoundedBy =
        Prefixed_Name(biotop, "physicallyBoundedBy") |> PrefixedName

    /// <summary>
    ///   <para>biotop:physicallyBounds</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"physically bounds"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#physicallyBounds">http://purl.org/biotop/biotop.owl#physicallyBounds</seealso>
    let physicallyBounds = Prefixed_Name(biotop, "physicallyBounds") |> PrefixedName

    /// <summary>
    ///   <para>biotop:physicallyConnectedTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:SymmetricProperty</para>
    ///
    /// labels<para>"physically connected to"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#physicallyConnectedTo">http://purl.org/biotop/biotop.owl#physicallyConnectedTo</seealso>
    let physicallyConnectedTo =
        Prefixed_Name(biotop, "physicallyConnectedTo") |> PrefixedName

    /// <summary>
    ///   <para>biotop:physicallyContainedIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"physically contained in"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#physicallyContainedIn">http://purl.org/biotop/biotop.owl#physicallyContainedIn</seealso>
    let physicallyContainedIn =
        Prefixed_Name(biotop, "physicallyContainedIn") |> PrefixedName

    /// <summary>
    ///   <para>biotop:physicallyContains</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"physically contains"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#physicallyContains">http://purl.org/biotop/biotop.owl#physicallyContains</seealso>
    let physicallyContains = Prefixed_Name(biotop, "physicallyContains") |> PrefixedName

    /// <summary>
    ///   <para>biotop:physicallyDisconnectedFrom</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:SymmetricProperty</para>
    ///
    /// labels<para>"physically disconnected from"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#physicallyDisconnectedFrom">http://purl.org/biotop/biotop.owl#physicallyDisconnectedFrom</seealso>
    let physicallyDisconnectedFrom =
        Prefixed_Name(biotop, "physicallyDisconnectedFrom") |> PrefixedName

    /// <summary>
    ///   <para>biotop:physicallyInterconnects</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"physically interconnects"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#physicallyInterconnects">http://purl.org/biotop/biotop.owl#physicallyInterconnects</seealso>
    let physicallyInterconnects =
        Prefixed_Name(biotop, "physicallyInterconnects") |> PrefixedName

    /// <summary>
    ///   <para>biotop:physicallyLocatedIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"physically located in"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#physicallyLocatedIn">http://purl.org/biotop/biotop.owl#physicallyLocatedIn</seealso>
    let physicallyLocatedIn =
        Prefixed_Name(biotop, "physicallyLocatedIn") |> PrefixedName

    /// <summary>
    ///   <para>biotop:physicallySurroundedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"physically surrounded by"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#physicallySurroundedBy">http://purl.org/biotop/biotop.owl#physicallySurroundedBy</seealso>
    let physicallySurroundedBy =
        Prefixed_Name(biotop, "physicallySurroundedBy") |> PrefixedName

    /// <summary>
    ///   <para>biotop:physicallySurrounds</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"physically surrounds"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#physicallySurrounds">http://purl.org/biotop/biotop.owl#physicallySurrounds</seealso>
    let physicallySurrounds =
        Prefixed_Name(biotop, "physicallySurrounds") |> PrefixedName

    /// <summary>
    ///   <para>biotop:physicallyTraverses</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"physically traverses"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#physicallyTraverses">http://purl.org/biotop/biotop.owl#physicallyTraverses</seealso>
    let physicallyTraverses =
        Prefixed_Name(biotop, "physicallyTraverses") |> PrefixedName

    /// <summary>
    ///   <para>biotop:precededBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:TransitiveProperty</para>
    ///
    /// labels<para>"preceded by"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#precededBy">http://purl.org/biotop/biotop.owl#precededBy</seealso>
    let precededBy = Prefixed_Name(biotop, "precededBy") |> PrefixedName
    /// <summary>
    ///   <para>biotop:precedes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:TransitiveProperty</para>
    ///
    /// labels<para>"precedes"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#precedes">http://purl.org/biotop/biotop.owl#precedes</seealso>
    let precedes = Prefixed_Name(biotop, "precedes") |> PrefixedName
    /// <summary>
    ///   <para>biotop:processQualityOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"process quality of"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#processQualityOf">http://purl.org/biotop/biotop.owl#processQualityOf</seealso>
    let processQualityOf = Prefixed_Name(biotop, "processQualityOf") |> PrefixedName
    /// <summary>
    ///   <para>biotop:processRoleOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"process role of"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#processRoleOf">http://purl.org/biotop/biotop.owl#processRoleOf</seealso>
    let processRoleOf = Prefixed_Name(biotop, "processRoleOf") |> PrefixedName
    /// <summary>
    ///   <para>biotop:processualPartOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"processual part of"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#processualPartOf">http://purl.org/biotop/biotop.owl#processualPartOf</seealso>
    let processualPartOf = Prefixed_Name(biotop, "processualPartOf") |> PrefixedName

    /// <summary>
    ///   <para>biotop:processuallyRelatedTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"processually related to"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#processuallyRelatedTo">http://purl.org/biotop/biotop.owl#processuallyRelatedTo</seealso>
    let processuallyRelatedTo =
        Prefixed_Name(biotop, "processuallyRelatedTo") |> PrefixedName

    /// <summary>
    ///   <para>biotop:properPhysicalPartOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"proper physical part of"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#properPhysicalPartOf">http://purl.org/biotop/biotop.owl#properPhysicalPartOf</seealso>
    let properPhysicalPartOf =
        Prefixed_Name(biotop, "properPhysicalPartOf") |> PrefixedName

    /// <summary>
    ///   <para>biotop:qualityLocated</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"quality located"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#qualityLocated">http://purl.org/biotop/biotop.owl#qualityLocated</seealso>
    let qualityLocated = Prefixed_Name(biotop, "qualityLocated") |> PrefixedName
    /// <summary>
    ///   <para>biotop:qualityLocationOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"quality location of"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#qualityLocationOf">http://purl.org/biotop/biotop.owl#qualityLocationOf</seealso>
    let qualityLocationOf = Prefixed_Name(biotop, "qualityLocationOf") |> PrefixedName
    /// <summary>
    ///   <para>biotop:ramificationOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"ramification of"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#ramificationOf">http://purl.org/biotop/biotop.owl#ramificationOf</seealso>
    let ramificationOf = Prefixed_Name(biotop, "ramificationOf") |> PrefixedName
    /// <summary>
    ///   <para>biotop:ramifies</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"ramifies"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#ramifies">http://purl.org/biotop/biotop.owl#ramifies</seealso>
    let ramifies = Prefixed_Name(biotop, "ramifies") |> PrefixedName
    /// <summary>
    ///   <para>biotop:realizationOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"realization of"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#realizationOf">http://purl.org/biotop/biotop.owl#realizationOf</seealso>
    let realizationOf = Prefixed_Name(biotop, "realizationOf") |> PrefixedName
    /// <summary>
    ///   <para>biotop:spatiallyRelatedTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:SymmetricProperty</para>
    ///
    /// labels<para>"spatially related to"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#spatiallyRelatedTo">http://purl.org/biotop/biotop.owl#spatiallyRelatedTo</seealso>
    let spatiallyRelatedTo = Prefixed_Name(biotop, "spatiallyRelatedTo") |> PrefixedName

    /// <summary>
    ///   <para>biotop:temporallyRelatedTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:SymmetricProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"temporally related to"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#temporallyRelatedTo">http://purl.org/biotop/biotop.owl#temporallyRelatedTo</seealso>
    let temporallyRelatedTo =
        Prefixed_Name(biotop, "temporallyRelatedTo") |> PrefixedName

    /// <summary>
    ///   <para>biotop:touches</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>owl:SymmetricProperty</para>
    ///
    /// labels<para>"touches"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/biotop/biotop.owl#touches">http://purl.org/biotop/biotop.owl#touches</seealso>
    let touches = Prefixed_Name(biotop, "touches") |> PrefixedName
