namespace http.purl.uniprot.org.core.slash

open DoxAletheia

module uniprot =
    let _namespace_name = "http://purl.uniprot.org/core/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/Inferred_from_Homology_Existence"></see>
    /// </summary>
    let Inferred_from_Homology_Existence = _prefix "Inferred_from_Homology_Existence"

    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/Evidence_at_Protein_Level_Existence"></see>
    /// </summary>
    let Evidence_at_Protein_Level_Existence =
        _prefix "Evidence_at_Protein_Level_Existence"

    /// <summary>
    /// Indicates that the existence of a protein has not been strictly proven but that expression data (such as existence of cDNA(s), RT-PCR or Northern blots) indicate the existence of a transcript.
    /// <see href="http://purl.uniprot.org/core/Evidence_at_Transcript_Level_Existence"></see></summary>
    let Evidence_at_Transcript_Level_Existence =
        _prefix "Evidence_at_Transcript_Level_Existence"

    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/Class"></see>
    /// </summary>
    let Class = _prefix "Class"
    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/Family"></see>
    /// </summary>
    let Family = _prefix "Family"
    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/Subkingdom"></see>
    /// </summary>
    let Subkingdom = _prefix "Subkingdom"
    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/Suborder"></see>
    /// </summary>
    let Suborder = _prefix "Suborder"
    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/Species"></see>
    /// </summary>
    let Species = _prefix "Species"
    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/Subgenus"></see>
    /// </summary>
    let Subgenus = _prefix "Subgenus"
    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/Tribe"></see>
    /// </summary>
    let Tribe = _prefix "Tribe"
    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/Subclass"></see>
    /// </summary>
    let Subclass = _prefix "Subclass"
    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/Genus"></see>
    /// </summary>
    let Genus = _prefix "Genus"
    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/Phylum"></see>
    /// </summary>
    let Phylum = _prefix "Phylum"
    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/Subtribe"></see>
    /// </summary>
    let Subtribe = _prefix "Subtribe"
    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/Superclass"></see>
    /// </summary>
    let Superclass = _prefix "Superclass"
    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/Superfamily"></see>
    /// </summary>
    let Superfamily = _prefix "Superfamily"
    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/Superorder"></see>
    /// </summary>
    let Superorder = _prefix "Superorder"
    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/Order"></see>
    /// </summary>
    let Order = _prefix "Order"
    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/Species_Subgroup"></see>
    /// </summary>
    let Species_Subgroup = _prefix "Species_Subgroup"
    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/Superkingdom"></see>
    /// </summary>
    let Superkingdom = _prefix "Superkingdom"
    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/Subspecies"></see>
    /// </summary>
    let Subspecies = _prefix "Subspecies"
    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/Kingdom"></see>
    /// </summary>
    let Kingdom = _prefix "Kingdom"
    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/Superphylum"></see>
    /// </summary>
    let Superphylum = _prefix "Superphylum"
    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/Subfamily"></see>
    /// </summary>
    let Subfamily = _prefix "Subfamily"
    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/Subphylum"></see>
    /// </summary>
    let Subphylum = _prefix "Subphylum"
    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/Forma"></see>
    /// </summary>
    let Forma = _prefix "Forma"
    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/Parvorder"></see>
    /// </summary>
    let Parvorder = _prefix "Parvorder"
    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/Varietas"></see>
    /// </summary>
    let Varietas = _prefix "Varietas"
    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/Species_Group"></see>
    /// </summary>
    let Species_Group = _prefix "Species_Group"
    /// <summary>
    /// This is used for proteins without evidence at protein, transcript, or homology levels.
    /// <see href="http://purl.uniprot.org/core/Predicted_Existence"></see></summary>
    let Predicted_Existence = _prefix "Predicted_Existence"
    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/PD"></see>
    /// </summary>
    let PD = _prefix "PD"
    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/FAB"></see>
    /// </summary>
    let FAB = _prefix "FAB"
    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/LSIMS"></see>
    /// </summary>
    let LSIMS = _prefix "LSIMS"
    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/MALDI"></see>
    /// </summary>
    let MALDI = _prefix "MALDI"
    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/SELDI"></see>
    /// </summary>
    let SELDI = _prefix "SELDI"
    /// <summary>
    /// Mass measurement using Atmospheric Pressure Ionization
    /// <see href="http://purl.uniprot.org/core/API"></see></summary>
    let API = _prefix "API"
    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/ESI"></see>
    /// </summary>
    let ESI = _prefix "ESI"
    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/Fiber_Diffraction"></see>
    /// </summary>
    let Fiber_Diffraction = _prefix "Fiber_Diffraction"
    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/Prediction"></see>
    /// </summary>
    let Prediction = _prefix "Prediction"
    /// <summary>
    /// A technique in crystallography in which the pattern produced by the diffraction of x-rays through the closely spaced lattice of atoms in a crystal is recorded and then analyzed to reveal the nature of that lattice.
    /// <see href="http://purl.uniprot.org/core/X-Ray_Crystallography"></see></summary>
    let ``X-Ray_Crystallography`` = _prefix "X-Ray_Crystallography"
    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/Neutron_Diffraction"></see>
    /// </summary>
    let Neutron_Diffraction = _prefix "Neutron_Diffraction"
    /// <summary>
    /// The electron microscope is a microscope that can magnify very small details with high resolving power due to the use of electrons rather than light to scatter off material, magnifying at levels up to 500,000 times.
    /// <see href="http://purl.uniprot.org/core/Electron_Microscopy"></see></summary>
    let Electron_Microscopy = _prefix "Electron_Microscopy"
    /// <summary>
    /// A type of spectroscopy that uses the Infrared portion of the electromagnetic spectrum.
    /// <see href="http://purl.uniprot.org/core/Infrared_Spectroscopy"></see></summary>
    let Infrared_Spectroscopy = _prefix "Infrared_Spectroscopy"
    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/NMR_Spectroscopy"></see>
    /// </summary>
    let NMR_Spectroscopy = _prefix "NMR_Spectroscopy"
    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/Uncertain_Existence"></see>
    /// </summary>
    let Uncertain_Existence = _prefix "Uncertain_Existence"
    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/By_Similarity"></see>
    /// </summary>
    let By_Similarity = _prefix "By_Similarity"
    /// <summary>
    /// indicates that there is some logical or conclusive evidence that the given annotation could apply. This non-experimental qualifier is often used to present results from protein sequence analysis software tools, which are only annotated if the result makes sense in the biological context of a given protein. A typical example is the annotation of N-glycosylation sites in secreted proteins
    /// <see href="http://purl.uniprot.org/core/Potential"></see></summary>
    let Potential = _prefix "Potential"
    /// <summary>
    /// The status ‘Probable’ indicates stronger evidence than the qualifier ‘Potential’. This qualifier implies that there must be at least some experimental evidence, which indicates, that the information is expected to be found in the natural environment of a protein.
    /// <see href="http://purl.uniprot.org/core/Probable"></see></summary>
    let Probable = _prefix "Probable"
    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/Experimental"></see>
    /// </summary>
    let Experimental = _prefix "Experimental"
    /// <summary>
    /// An experimental method for measuring the mass of a molecule.
    /// <see href="http://purl.uniprot.org/core/Mass_Measurement_Method"></see></summary>
    let Mass_Measurement_Method = _prefix "Mass_Measurement_Method"
    /// <summary>
    /// Indicates the wavelength in nm at which photoreactive proteins such as opsins and DNA photolyases show maximal absorption.
    /// <see href="http://purl.uniprot.org/core/Absorption_Annotation"></see></summary>
    let Absorption_Annotation = _prefix "Absorption_Annotation"
    /// <summary>
    /// Biophysical and physicochemical data such as pH dependence, temperature dependence, kinetic parameters, redox potentials, and maximal absorption.
    /// <see href="http://purl.uniprot.org/core/Biophysicochemical_Annotation"></see></summary>
    let Biophysicochemical_Annotation = _prefix "Biophysicochemical_Annotation"
    /// <summary>
    /// Amino acid(s) involved in the activity of an enzyme.
    /// <see href="http://purl.uniprot.org/core/Active_Site_Annotation"></see></summary>
    let Active_Site_Annotation = _prefix "Active_Site_Annotation"
    /// <summary>
    /// Any interesting single amino-acid site on the sequence, that is not defined by another feature key. It can also apply to an amino acid bond which is represented by the positions of the two flanking amino acids.
    /// <see href="http://purl.uniprot.org/core/Site_Annotation"></see></summary>
    let Site_Annotation = _prefix "Site_Annotation"
    /// <summary>
    /// Information relevant to allergenic proteins.
    /// <see href="http://purl.uniprot.org/core/Allergen_Annotation"></see></summary>
    let Allergen_Annotation = _prefix "Allergen_Annotation"
    /// <summary>
    /// Description of a resource on a specific topic.
    /// <see href="http://purl.uniprot.org/core/Annotation"></see></summary>
    let Annotation = _prefix "Annotation"
    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/Alternative_Initiation_Annotation"></see>
    /// </summary>
    let Alternative_Initiation_Annotation = _prefix "Alternative_Initiation_Annotation"
    /// <summary>
    /// Description of the existence of related protein sequences produced by alternative splicing of the same gene or by the use of alternative initiation codons.
    /// <see href="http://purl.uniprot.org/core/Alternative_Products_Annotation"></see></summary>
    let Alternative_Products_Annotation = _prefix "Alternative_Products_Annotation"

    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/Alternative_Promoter_Usage_Annotation"></see>
    /// </summary>
    let Alternative_Promoter_Usage_Annotation =
        _prefix "Alternative_Promoter_Usage_Annotation"

    /// <summary>
    /// Description of sequence variants produced by alternative splicing.
    /// <see href="http://purl.uniprot.org/core/Alternative_Sequence_Annotation"></see></summary>
    let Alternative_Sequence_Annotation = _prefix "Alternative_Sequence_Annotation"
    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/Natural_Variation_Annotation"></see>
    /// </summary>
    let Natural_Variation_Annotation = _prefix "Natural_Variation_Annotation"
    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/Alternative_Splicing_Annotation"></see>
    /// </summary>
    let Alternative_Splicing_Annotation = _prefix "Alternative_Splicing_Annotation"
    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/Apicoplast"></see>
    /// </summary>
    let Apicoplast = _prefix "Apicoplast"
    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/Organelle"></see>
    /// </summary>
    let Organelle = _prefix "Organelle"
    /// <summary>
    /// Entity used to attach evidence or provenance to a rdf statement via reification.
    /// <see href="http://purl.uniprot.org/core/Attribution"></see></summary>
    let Attribution = _prefix "Attribution"
    /// <summary>
    /// Beta strand regions within the experimentally determined protein structure
    /// <see href="http://purl.uniprot.org/core/Beta_Strand_Annotation"></see></summary>
    let Beta_Strand_Annotation = _prefix "Beta_Strand_Annotation"
    /// <summary>
    /// Describes the secondary structure of proteins whose tertiary structure is known experimentally.
    /// <see href="http://purl.uniprot.org/core/Secondary_Structure_Annotation"></see></summary>
    let Secondary_Structure_Annotation = _prefix "Secondary_Structure_Annotation"
    /// <summary>
    /// Binding site for any chemical group (co-enzyme, prosthetic group, etc.).
    /// <see href="http://purl.uniprot.org/core/Binding_Site_Annotation"></see></summary>
    let Binding_Site_Annotation = _prefix "Binding_Site_Annotation"
    /// <summary>
    /// Description of the use of a specific protein in a biotechnological process.
    /// <see href="http://purl.uniprot.org/core/Biotechnology_Annotation"></see></summary>
    let Biotechnology_Annotation = _prefix "Biotechnology_Annotation"
    /// <summary>
    /// A chapter from a book.
    /// <see href="http://purl.uniprot.org/core/Book_Citation"></see></summary>
    let Book_Citation = _prefix "Book_Citation"
    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/name"></see>
    /// </summary>
    let name = _prefix "name"
    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/Published_Citation"></see>
    /// </summary>
    let Published_Citation = _prefix "Published_Citation"
    /// <summary>
    /// Indicator for the reliability of a piece of information.
    /// <see href="http://purl.uniprot.org/core/Status"></see></summary>
    let Status = _prefix "Status"
    /// <summary>
    /// Extent of a calcium-binding region.
    /// <see href="http://purl.uniprot.org/core/Calcium_Binding_Annotation"></see></summary>
    let Calcium_Binding_Annotation = _prefix "Calcium_Binding_Annotation"
    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/Region_Annotation"></see>
    /// </summary>
    let Region_Annotation = _prefix "Region_Annotation"
    /// <summary>
    /// Description of the reactions catalyzed by an enzyme.
    /// <see href="http://purl.uniprot.org/core/Catalytic_Activity_Annotation"></see></summary>
    let Catalytic_Activity_Annotation = _prefix "Catalytic_Activity_Annotation"
    /// <summary>
    /// Warning about possible errors and/or grounds for confusion.
    /// <see href="http://purl.uniprot.org/core/Caution_Annotation"></see></summary>
    let Caution_Annotation = _prefix "Caution_Annotation"
    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/Cellular_Component"></see>
    /// </summary>
    let Cellular_Component = _prefix "Cellular_Component"
    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/Subcellular_Location"></see>
    /// </summary>
    let Subcellular_Location = _prefix "Subcellular_Location"
    /// <summary>
    /// Extent of a polypeptide chain in the mature protein.
    /// <see href="http://purl.uniprot.org/core/Chain_Annotation"></see></summary>
    let Chain_Annotation = _prefix "Chain_Annotation"
    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/Molecule_Processing_Annotation"></see>
    /// </summary>
    let Molecule_Processing_Annotation = _prefix "Molecule_Processing_Annotation"
    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/Chloroplast"></see>
    /// </summary>
    let Chloroplast = _prefix "Chloroplast"
    /// <summary>
    /// Description of a publication from which data was obtained.
    /// <see href="http://purl.uniprot.org/core/Citation"></see></summary>
    let Citation = _prefix "Citation"
    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/date"></see>
    /// </summary>
    let date = _prefix "date"
    /// <summary>
    /// An amino acid sequence.
    /// <see href="http://purl.uniprot.org/core/Sequence"></see></summary>
    let Sequence = _prefix "Sequence"
    /// <summary>
    /// A range of amino acids on a protein  sequence.
    /// <see href="http://purl.uniprot.org/core/Range"></see></summary>
    let Range = _prefix "Range"
    /// <summary>
    /// Description of a protein.
    /// <see href="http://purl.uniprot.org/core/Protein"></see></summary>
    let Protein = _prefix "Protein"
    /// <summary>
    /// The relationship between a resource and a citation.
    /// <see href="http://purl.uniprot.org/core/Citation_Statement"></see></summary>
    let Citation_Statement = _prefix "Citation_Statement"
    /// <summary>
    /// A strain of a species.
    /// <see href="http://purl.uniprot.org/core/Strain"></see></summary>
    let Strain = _prefix "Strain"
    /// <summary>
    /// A tissue such as lung or heart.
    /// <see href="http://purl.uniprot.org/core/Tissue"></see></summary>
    let Tissue = _prefix "Tissue"
    /// <summary>
    /// A transposon
    /// <see href="http://purl.uniprot.org/core/Transposon"></see></summary>
    let Transposon = _prefix "Transposon"
    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/context"></see>
    /// </summary>
    let context = _prefix "context"
    /// <summary>
    /// A rank of a taxon.
    /// <see href="http://purl.uniprot.org/core/Rank"></see></summary>
    let Rank = _prefix "Rank"
    /// <summary>
    /// Cluster of proteins with similar sequences.
    /// <see href="http://purl.uniprot.org/core/Cluster"></see></summary>
    let Cluster = _prefix "Cluster"
    /// <summary>
    /// One of several similar resources.
    /// <see href="http://purl.uniprot.org/core/member"></see></summary>
    let member_ = _prefix "member"
    /// <summary>
    /// Description of an enzyme cofactor.
    /// <see href="http://purl.uniprot.org/core/Cofactor_Annotation"></see></summary>
    let Cofactor_Annotation = _prefix "Cofactor_Annotation"
    /// <summary>
    /// Extent of a coiled-coil region.
    /// <see href="http://purl.uniprot.org/core/Coiled_Coil_Annotation"></see></summary>
    let Coiled_Coil_Annotation = _prefix "Coiled_Coil_Annotation"
    /// <summary>
    /// Extent of a compositionally biased region.
    /// <see href="http://purl.uniprot.org/core/Compositional_Bias_Annotation"></see></summary>
    let Compositional_Bias_Annotation = _prefix "Compositional_Bias_Annotation"
    /// <summary>
    /// A concept used to classify resources.
    /// <see href="http://purl.uniprot.org/core/Concept"></see></summary>
    let Concept = _prefix "Concept"
    /// <summary>
    /// A resource that is replaced by this resource.
    /// <see href="http://purl.uniprot.org/core/replaces"></see></summary>
    let replaces = _prefix "replaces"
    /// <summary>
    /// Posttranslationally formed amino acid bonds.
    /// <see href="http://purl.uniprot.org/core/Cross-link_Annotation"></see></summary>
    let ``Cross-link_Annotation`` = _prefix "Cross-link_Annotation"
    /// <summary>
    /// Describes amino acid modifications, post pre- and post-translational.
    /// <see href="http://purl.uniprot.org/core/Modification_Annotation"></see></summary>
    let Modification_Annotation = _prefix "Modification_Annotation"
    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/Cyanelle"></see>
    /// </summary>
    let Cyanelle = _prefix "Cyanelle"
    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/DNA"></see>
    /// </summary>
    let DNA = _prefix "DNA"
    /// <summary>
    /// A biological molecule.
    /// <see href="http://purl.uniprot.org/core/Molecule"></see></summary>
    let Molecule = _prefix "Molecule"
    /// <summary>
    /// Metadata for a life science database.
    /// <see href="http://purl.uniprot.org/core/Database"></see></summary>
    let Database = _prefix "Database"
    /// <summary>
    /// Description of the developmentally-specific expression of a protein.
    /// <see href="http://purl.uniprot.org/core/Developmental_Stage_Annotation"></see></summary>
    let Developmental_Stage_Annotation = _prefix "Developmental_Stage_Annotation"
    /// <summary>
    /// Description of the diseases associated with a deficiency of a protein.
    /// <see href="http://purl.uniprot.org/core/Disease_Annotation"></see></summary>
    let Disease_Annotation = _prefix "Disease_Annotation"
    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/Disruption_Phenotype_Annotation"></see>
    /// </summary>
    let Disruption_Phenotype_Annotation = _prefix "Disruption_Phenotype_Annotation"
    /// <summary>
    /// Describes residues which are linked by an intra-chain disulfide bond. If the endpoints are identical, the disulfide bond is an interchain one.
    /// <see href="http://purl.uniprot.org/core/Disulfide_Bond_Annotation"></see></summary>
    let Disulfide_Bond_Annotation = _prefix "Disulfide_Bond_Annotation"
    /// <summary>
    /// Description of the domain structure of a protein.
    /// <see href="http://purl.uniprot.org/core/Domain_Annotation"></see></summary>
    let Domain_Annotation = _prefix "Domain_Annotation"
    /// <summary>
    /// The relationship between a protein and a protein domain.
    /// <see href="http://purl.uniprot.org/core/Domain_Assignment_Statement"></see></summary>
    let Domain_Assignment_Statement = _prefix "Domain_Assignment_Statement"
    /// <summary>
    /// Extent of a domain, which is defined as a specific combination of secondary structures organized into a characteristic three-dimensional structure or fold.
    /// <see href="http://purl.uniprot.org/core/Domain_Extent_Annotation"></see></summary>
    let Domain_Extent_Annotation = _prefix "Domain_Extent_Annotation"
    /// <summary>
    /// An experimental method for determining the 3D structure of a protein.
    /// <see href="http://purl.uniprot.org/core/Structure_Determination_Method"></see></summary>
    let Structure_Determination_Method = _prefix "Structure_Determination_Method"
    /// <summary>
    /// An electronic publication.
    /// <see href="http://purl.uniprot.org/core/Electronic_Citation"></see></summary>
    let Electronic_Citation = _prefix "Electronic_Citation"
    /// <summary>
    /// Metadata for an endpoint of a range on a sequence.
    /// <see href="http://purl.uniprot.org/core/Endpoint_Statement"></see></summary>
    let Endpoint_Statement = _prefix "Endpoint_Statement"
    /// <summary>
    /// A specific catalytic activity, defined by the Enzyme Commission of the Nomenclature Committee of the International Union of Biochemistry and Molecular Biology (IUBMB).
    /// <see href="http://purl.uniprot.org/core/Enzyme"></see></summary>
    let Enzyme = _prefix "Enzyme"
    /// <summary>
    /// A resource that replaces this resource.
    /// <see href="http://purl.uniprot.org/core/replacedBy"></see></summary>
    let replacedBy = _prefix "replacedBy"
    /// <summary>
    /// Description of an enzyme regulatory mechanism.
    /// <see href="http://purl.uniprot.org/core/Enzyme_Regulation_Annotation"></see></summary>
    let Enzyme_Regulation_Annotation = _prefix "Enzyme_Regulation_Annotation"

    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/Erroneous_Gene_Model_Prediction_Annotation"></see>
    /// </summary>
    let Erroneous_Gene_Model_Prediction_Annotation =
        _prefix "Erroneous_Gene_Model_Prediction_Annotation"

    /// <summary>
    /// Warning about possible errors related to the protein sequence
    /// <see href="http://purl.uniprot.org/core/Sequence_Caution_Annotation"></see></summary>
    let Sequence_Caution_Annotation = _prefix "Sequence_Caution_Annotation"
    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/Erroneous_Initiation_Annotation"></see>
    /// </summary>
    let Erroneous_Initiation_Annotation = _prefix "Erroneous_Initiation_Annotation"
    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/Erroneous_Termination_Annotation"></see>
    /// </summary>
    let Erroneous_Termination_Annotation = _prefix "Erroneous_Termination_Annotation"
    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/Erroneous_Translation_Annotation"></see>
    /// </summary>
    let Erroneous_Translation_Annotation = _prefix "Erroneous_Translation_Annotation"
    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/Protein_Existence"></see>
    /// </summary>
    let Protein_Existence = _prefix "Protein_Existence"

    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/Experimental_Information_Annotation"></see>
    /// </summary>
    let Experimental_Information_Annotation =
        _prefix "Experimental_Information_Annotation"

    /// <summary>
    /// Description of a special region or site in a protein sequence.
    /// <see href="http://purl.uniprot.org/core/Sequence_Annotation"></see></summary>
    let Sequence_Annotation = _prefix "Sequence_Annotation"
    /// <summary>
    /// The protein described in the linked record is an alternative splice form of the same gene product as described in this record. The function between the two isoforms is highly divergent.
    /// <see href="http://purl.uniprot.org/core/External_Sequence"></see></summary>
    let External_Sequence = _prefix "External_Sequence"
    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/Known_Sequence"></see>
    /// </summary>
    let Known_Sequence = _prefix "Known_Sequence"
    /// <summary>
    /// The relationship between a protein and a protein family.
    /// <see href="http://purl.uniprot.org/core/Family_Membership_Statement"></see></summary>
    let Family_Membership_Statement = _prefix "Family_Membership_Statement"
    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/Frameshift_Annotation"></see>
    /// </summary>
    let Frameshift_Annotation = _prefix "Frameshift_Annotation"
    /// <summary>
    /// General description of the functions of a protein.
    /// <see href="http://purl.uniprot.org/core/Function_Annotation"></see></summary>
    let Function_Annotation = _prefix "Function_Annotation"
    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/Gene"></see>
    /// </summary>
    let Gene = _prefix "Gene"
    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/Genomic_DNA"></see>
    /// </summary>
    let Genomic_DNA = _prefix "Genomic_DNA"
    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/Genomic_RNA"></see>
    /// </summary>
    let Genomic_RNA = _prefix "Genomic_RNA"
    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/RNA"></see>
    /// </summary>
    let RNA = _prefix "RNA"
    /// <summary>
    /// Describes the occurrence of the attachment of a glycan (mono- or polysaccharide) to a residue of a protein.
    /// <see href="http://purl.uniprot.org/core/Glycosylation_Annotation"></see></summary>
    let Glycosylation_Annotation = _prefix "Glycosylation_Annotation"
    /// <summary>
    /// Helical regions within the experimentally determined protein structure
    /// <see href="http://purl.uniprot.org/core/Helix_Annotation"></see></summary>
    let Helix_Annotation = _prefix "Helix_Annotation"
    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/Hydrogenosome"></see>
    /// </summary>
    let Hydrogenosome = _prefix "Hydrogenosome"
    /// <summary>
    /// Description of the compounds or conditions that stimulate the synthesis of a protein.
    /// <see href="http://purl.uniprot.org/core/Induction_Annotation"></see></summary>
    let Induction_Annotation = _prefix "Induction_Annotation"
    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/Infraclass"></see>
    /// </summary>
    let Infraclass = _prefix "Infraclass"
    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/Infraorder"></see>
    /// </summary>
    let Infraorder = _prefix "Infraorder"
    /// <summary>
    /// Indicates that the initiator methionine has been cleaved off and is not shown in the sequence.
    /// <see href="http://purl.uniprot.org/core/Initiator_Methionine_Annotation"></see></summary>
    let Initiator_Methionine_Annotation = _prefix "Initiator_Methionine_Annotation"
    /// <summary>
    /// Description of a protein-protein interaction.
    /// <see href="http://purl.uniprot.org/core/Interaction"></see></summary>
    let Interaction = _prefix "Interaction"
    /// <summary>
    /// Extent of a region located in a membrane without crossing it
    /// <see href="http://purl.uniprot.org/core/Intramembrane_Annotation"></see></summary>
    let Intramembrane_Annotation = _prefix "Intramembrane_Annotation"
    /// <summary>
    /// An article published in a journal.
    /// <see href="http://purl.uniprot.org/core/Journal_Citation"></see></summary>
    let Journal_Citation = _prefix "Journal_Citation"
    /// <summary>
    /// Mentions the Michaelis-Menten constant (KM) and maximal velocity (Vmax) of enzymes.
    /// <see href="http://purl.uniprot.org/core/Kinetics_Annotation"></see></summary>
    let Kinetics_Annotation = _prefix "Kinetics_Annotation"
    /// <summary>
    /// Covalent binding of a lipid moiety.
    /// <see href="http://purl.uniprot.org/core/Lipidation_Annotation"></see></summary>
    let Lipidation_Annotation = _prefix "Lipidation_Annotation"
    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/MRNA"></see>
    /// </summary>
    let MRNA = _prefix "MRNA"
    /// <summary>
    /// An experimental method.
    /// <see href="http://purl.uniprot.org/core/Method"></see></summary>
    let Method = _prefix "Method"
    /// <summary>
    /// Indicates the mass of a sequence determined by mass spectrometry.
    /// <see href="http://purl.uniprot.org/core/Mass_Spectrometry_Annotation"></see></summary>
    let Mass_Spectrometry_Annotation = _prefix "Mass_Spectrometry_Annotation"
    /// <summary>
    /// The experimental method that was used.
    /// <see href="http://purl.uniprot.org/core/method"></see></summary>
    let method = _prefix "method"
    /// <summary>
    /// Binding site for a metal ion.
    /// <see href="http://purl.uniprot.org/core/Metal_Binding_Annotation"></see></summary>
    let Metal_Binding_Annotation = _prefix "Metal_Binding_Annotation"
    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/Mitochondrion"></see>
    /// </summary>
    let Mitochondrion = _prefix "Mitochondrion"
    /// <summary>
    /// Posttranslational modification of a residue.
    /// <see href="http://purl.uniprot.org/core/Modified_Residue_Annotation"></see></summary>
    let Modified_Residue_Annotation = _prefix "Modified_Residue_Annotation"
    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/Modified_Sequence"></see>
    /// </summary>
    let Modified_Sequence = _prefix "Modified_Sequence"
    /// <summary>
    /// A modification of a sequence.
    /// <see href="http://purl.uniprot.org/core/modification"></see></summary>
    let modification = _prefix "modification"
    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/Simple_Sequence"></see>
    /// </summary>
    let Simple_Sequence = _prefix "Simple_Sequence"
    /// <summary>
    /// The sequence on which the description of a modified sequence is based.
    /// <see href="http://purl.uniprot.org/core/basedOn"></see></summary>
    let basedOn = _prefix "basedOn"
    /// <summary>
    /// Short (&lt;=20 amino acids) sequence motif of biological interest.
    /// <see href="http://purl.uniprot.org/core/Motif_Annotation"></see></summary>
    let Motif_Annotation = _prefix "Motif_Annotation"
    /// <summary>
    /// Site which has been experimentally altered.
    /// <see href="http://purl.uniprot.org/core/Mutagenesis_Annotation"></see></summary>
    let Mutagenesis_Annotation = _prefix "Mutagenesis_Annotation"
    /// <summary>
    /// Extent of a nucleotide phosphate-binding region.
    /// <see href="http://purl.uniprot.org/core/NP_Binding_Annotation"></see></summary>
    let NP_Binding_Annotation = _prefix "NP_Binding_Annotation"
    /// <summary>
    /// Authors report that sequence variants exist.
    /// <see href="http://purl.uniprot.org/core/Natural_Variant_Annotation"></see></summary>
    let Natural_Variant_Annotation = _prefix "Natural_Variant_Annotation"

    /// <summary>
    /// Indicates that two residues in a sequence are not consecutive and that there are a number of unsequenced residues between them.
    /// <see href="http://purl.uniprot.org/core/Non-adjacent_Residues_Annotation"></see></summary>
    let ``Non-adjacent_Residues_Annotation`` =
        _prefix "Non-adjacent_Residues_Annotation"

    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/Non-photosynthetic_plastid"></see>
    /// </summary>
    let ``Non-photosynthetic_plastid`` = _prefix "Non-photosynthetic_plastid"
    /// <summary>
    /// Describes the occurrence of a non standard residue in the sequence record.
    /// <see href="http://purl.uniprot.org/core/Non-standard_Residue_Annotation"></see></summary>
    let ``Non-standard_Residue_Annotation`` = _prefix "Non-standard_Residue_Annotation"
    /// <summary>
    /// The residue at an extremity of the sequence is not the terminal residue.
    /// <see href="http://purl.uniprot.org/core/Non-terminal_Residue_Annotation"></see></summary>
    let ``Non-terminal_Residue_Annotation`` = _prefix "Non-terminal_Residue_Annotation"
    /// <summary>
    /// A class introduced to group all records that are currently in the database.
    /// <see href="http://purl.uniprot.org/core/NotObsolete"></see></summary>
    let NotObsolete = _prefix "NotObsolete"
    /// <summary>
    /// The class of all obsolete records in the database (i.e. records that where once published but are now removed).
    /// <see href="http://purl.uniprot.org/core/Obsolete"></see></summary>
    let Obsolete = _prefix "Obsolete"
    /// <summary>
    /// True if this resource has been replaced or deleted.
    /// <see href="http://purl.uniprot.org/core/obsolete"></see></summary>
    let obsolete = _prefix "obsolete"
    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/NotObsoleteProtein"></see>
    /// </summary>
    let NotObsoleteProtein = _prefix "NotObsoleteProtein"
    /// <summary>
    /// The organism in which a protein occurs.
    /// <see href="http://purl.uniprot.org/core/organism"></see></summary>
    let organism = _prefix "organism"
    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/existence"></see>
    /// </summary>
    let existence = _prefix "existence"
    /// <summary>
    /// An amino acid sequence.
    /// <see href="http://purl.uniprot.org/core/sequence"></see></summary>
    let sequence = _prefix "sequence"
    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/NotObsoleteTaxon"></see>
    /// </summary>
    let NotObsoleteTaxon = _prefix "NotObsoleteTaxon"
    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/scientificName"></see>
    /// </summary>
    let scientificName = _prefix "scientificName"
    /// <summary>
    /// An element of a taxonomy for classifying life forms.
    /// <see href="http://purl.uniprot.org/core/Taxon"></see></summary>
    let Taxon = _prefix "Taxon"
    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/Nucleomorph"></see>
    /// </summary>
    let Nucleomorph = _prefix "Nucleomorph"
    /// <summary>
    /// Extent of a DNA-binding region.
    /// <see href="http://purl.uniprot.org/core/Nucleotide_Binding_Annotation"></see></summary>
    let Nucleotide_Binding_Annotation = _prefix "Nucleotide_Binding_Annotation"
    /// <summary>
    /// The relationship between a protein and a nucleotide sequence.
    /// <see href="http://purl.uniprot.org/core/Nucleotide_Mapping_Statement"></see></summary>
    let Nucleotide_Mapping_Statement = _prefix "Nucleotide_Mapping_Statement"
    /// <summary>
    /// A resource that descripes a nucleotide sequence.
    /// <see href="http://purl.uniprot.org/core/Nucleotide_Resource"></see></summary>
    let Nucleotide_Resource = _prefix "Nucleotide_Resource"
    /// <summary>
    /// A life science resource.
    /// <see href="http://purl.uniprot.org/core/Resource"></see></summary>
    let Resource = _prefix "Resource"
    /// <summary>
    /// The molecule a this resource is located on.
    /// <see href="http://purl.uniprot.org/core/locatedOn"></see></summary>
    let locatedOn = _prefix "locatedOn"
    /// <summary>
    /// Citation of an unpublished result.
    /// <see href="http://purl.uniprot.org/core/Observation_Citation"></see></summary>
    let Observation_Citation = _prefix "Observation_Citation"
    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/Unpublished_Citation"></see>
    /// </summary>
    let Unpublished_Citation = _prefix "Unpublished_Citation"
    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/ObsoleteProtein"></see>
    /// </summary>
    let ObsoleteProtein = _prefix "ObsoleteProtein"
    /// <summary>
    /// Taxa are occasionally removed from the taxonomy database (particularly internal nodes, during a taxonomic revision) – these taxids are deleted, and are not reused.
    /// <see href="http://purl.uniprot.org/core/ObsoleteTaxon"></see></summary>
    let ObsoleteTaxon = _prefix "ObsoleteTaxon"
    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/Organellar_chromatophore"></see>
    /// </summary>
    let Organellar_chromatophore = _prefix "Organellar_chromatophore"
    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/Orientation"></see>
    /// </summary>
    let Orientation = _prefix "Orientation"
    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/Other_DNA"></see>
    /// </summary>
    let Other_DNA = _prefix "Other_DNA"
    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/Other_RNA"></see>
    /// </summary>
    let Other_RNA = _prefix "Other_RNA"
    /// <summary>
    /// Describes the optimum pH for enzyme activity and/or the variation of enzyme activity with pH variation.
    /// <see href="http://purl.uniprot.org/core/PH_Dependence_Annotation"></see></summary>
    let PH_Dependence_Annotation = _prefix "PH_Dependence_Annotation"
    /// <summary>
    /// Description of a posttranslational modification.
    /// <see href="http://purl.uniprot.org/core/PTM_Annotation"></see></summary>
    let PTM_Annotation = _prefix "PTM_Annotation"
    /// <summary>
    /// Description of a part of a protein.
    /// <see href="http://purl.uniprot.org/core/Part"></see></summary>
    let Part = _prefix "Part"
    /// <summary>
    /// A participant in a protein-protein interaction.
    /// <see href="http://purl.uniprot.org/core/Participant"></see></summary>
    let Participant = _prefix "Participant"
    /// <summary>
    /// A patent application.
    /// <see href="http://purl.uniprot.org/core/Patent_Citation"></see></summary>
    let Patent_Citation = _prefix "Patent_Citation"
    /// <summary>
    /// A hierarchical discription of a metabolic pathway.
    /// <see href="http://purl.uniprot.org/core/Pathway"></see></summary>
    let Pathway = _prefix "Pathway"
    /// <summary>
    /// Description of the metabolic pathways with which a protein is associated.
    /// <see href="http://purl.uniprot.org/core/Pathway_Annotation"></see></summary>
    let Pathway_Annotation = _prefix "Pathway_Annotation"
    /// <summary>
    /// Extent of a released active peptide.
    /// <see href="http://purl.uniprot.org/core/Peptide_Annotation"></see></summary>
    let Peptide_Annotation = _prefix "Peptide_Annotation"
    /// <summary>
    /// Description of the use of a protein as a pharmaceutical drug.
    /// <see href="http://purl.uniprot.org/core/Pharmaceutical_Annotation"></see></summary>
    let Pharmaceutical_Annotation = _prefix "Pharmaceutical_Annotation"
    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/Plastid"></see>
    /// </summary>
    let Plastid = _prefix "Plastid"
    /// <summary>
    /// Description of polymorphisms.
    /// <see href="http://purl.uniprot.org/core/Polymorphism_Annotation"></see></summary>
    let Polymorphism_Annotation = _prefix "Polymorphism_Annotation"
    /// <summary>
    /// Extent of a propeptide.
    /// <see href="http://purl.uniprot.org/core/Propeptide_Annotation"></see></summary>
    let Propeptide_Annotation = _prefix "Propeptide_Annotation"
    /// <summary>
    /// Desription of a set of related proteins.
    /// <see href="http://purl.uniprot.org/core/Protein_Family"></see></summary>
    let Protein_Family = _prefix "Protein_Family"
    /// <summary>
    /// Description of any type of RNA editing that leads to one or more amino acid changes.
    /// <see href="http://purl.uniprot.org/core/RNA_Editing_Annotation"></see></summary>
    let RNA_Editing_Annotation = _prefix "RNA_Editing_Annotation"
    /// <summary>
    /// The first position of a range.
    /// <see href="http://purl.uniprot.org/core/begin"></see></summary>
    let begin_ = _prefix "begin"
    /// <summary>
    /// The last position of a range.
    /// <see href="http://purl.uniprot.org/core/end"></see></summary>
    let end_ = _prefix "end"
    /// <summary>
    /// Reports the value of the standard (midpoint) oxido-reduction potential(s) for electron transport proteins.
    /// <see href="http://purl.uniprot.org/core/Redox_Potential_Annotation"></see></summary>
    let Redox_Potential_Annotation = _prefix "Redox_Potential_Annotation"
    /// <summary>
    /// Extent of an internal sequence repetition.
    /// <see href="http://purl.uniprot.org/core/Repeat_Annotation"></see></summary>
    let Repeat_Annotation = _prefix "Repeat_Annotation"
    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/database"></see>
    /// </summary>
    let database = _prefix "database"
    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/Ribosomal_Frameshifting"></see>
    /// </summary>
    let Ribosomal_Frameshifting = _prefix "Ribosomal_Frameshifting"
    /// <summary>
    /// Different sources report differing sequences.
    /// <see href="http://purl.uniprot.org/core/Sequence_Conflict_Annotation"></see></summary>
    let Sequence_Conflict_Annotation = _prefix "Sequence_Conflict_Annotation"
    /// <summary>
    /// Used to describe region(s) of a sequence for which the authors are unsure about the sequence assignment.
    /// <see href="http://purl.uniprot.org/core/Sequence_Uncertainty_Annotation"></see></summary>
    let Sequence_Uncertainty_Annotation = _prefix "Sequence_Uncertainty_Annotation"
    /// <summary>
    /// Extent of a signal sequence (prepeptide).
    /// <see href="http://purl.uniprot.org/core/Signal_Peptide_Annotation"></see></summary>
    let Signal_Peptide_Annotation = _prefix "Signal_Peptide_Annotation"
    /// <summary>
    /// Description of the similarities (sequence or structural) of a protein with other proteins.
    /// <see href="http://purl.uniprot.org/core/Similarity_Annotation"></see></summary>
    let Similarity_Annotation = _prefix "Similarity_Annotation"
    /// <summary>
    /// The relationship between a protein and a 3D structure.
    /// <see href="http://purl.uniprot.org/core/Structure_Mapping_Statement"></see></summary>
    let Structure_Mapping_Statement = _prefix "Structure_Mapping_Statement"
    /// <summary>
    /// A resource that describes the 3D structure of a protein.
    /// <see href="http://purl.uniprot.org/core/Structure_Resource"></see></summary>
    let Structure_Resource = _prefix "Structure_Resource"
    /// <summary>
    /// A resource that holds a set of the known names for this protein together.
    /// <see href="http://purl.uniprot.org/core/Structured_Name"></see></summary>
    let Structured_Name = _prefix "Structured_Name"
    /// <summary>
    /// Description of the subcellular location of the mature protein.
    /// <see href="http://purl.uniprot.org/core/Subcellular_Location_Annotation"></see></summary>
    let Subcellular_Location_Annotation = _prefix "Subcellular_Location_Annotation"
    /// <summary>
    /// Data that was submitted directly to a database.
    /// <see href="http://purl.uniprot.org/core/Submission_Citation"></see></summary>
    let Submission_Citation = _prefix "Submission_Citation"
    /// <summary>
    /// The database a resource  was submitted to.
    /// <see href="http://purl.uniprot.org/core/submittedTo"></see></summary>
    let submittedTo = _prefix "submittedTo"
    /// <summary>
    /// Description of the quaternary structure of a protein.
    /// <see href="http://purl.uniprot.org/core/Subunit_Annotation"></see></summary>
    let Subunit_Annotation = _prefix "Subunit_Annotation"
    /// <summary>
    /// A easy to remember identifier for a UniProtKB entry, but it is not a stable identifier and should not be used by programs to identify entries.
    /// <see href="http://purl.uniprot.org/core/mnemonic"></see></summary>
    let mnemonic = _prefix "mnemonic"
    /// <summary>
    /// Indicates the optimum temperature for enzyme activity and/or the variation of enzyme activity with temperature variation; the thermostability/thermolability of the enzyme is also mentioned when it is known.
    /// <see href="http://purl.uniprot.org/core/Temperature_Dependence_Annotation"></see></summary>
    let Temperature_Dependence_Annotation = _prefix "Temperature_Dependence_Annotation"
    /// <summary>
    /// A Ph.D. thesis.
    /// <see href="http://purl.uniprot.org/core/Thesis_Citation"></see></summary>
    let Thesis_Citation = _prefix "Thesis_Citation"
    /// <summary>
    /// The institution at which a thesis was written.
    /// <see href="http://purl.uniprot.org/core/institution"></see></summary>
    let institution = _prefix "institution"
    /// <summary>
    /// Description of the tissue specificity of a protein.
    /// <see href="http://purl.uniprot.org/core/Tissue_Specificity_Annotation"></see></summary>
    let Tissue_Specificity_Annotation = _prefix "Tissue_Specificity_Annotation"
    /// <summary>
    /// A topological domain.
    /// <see href="http://purl.uniprot.org/core/Topological_Domain_Annotation"></see></summary>
    let Topological_Domain_Annotation = _prefix "Topological_Domain_Annotation"
    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/Topology"></see>
    /// </summary>
    let Topology = _prefix "Topology"
    /// <summary>
    /// Information on the LD(50). LD stands for "Lethal Dose". LD(50) is the amount of a toxin, given all at once, which causes the death of 50% (one half) of a group of test animals.
    /// <see href="http://purl.uniprot.org/core/Toxic_Dose_Annotation"></see></summary>
    let Toxic_Dose_Annotation = _prefix "Toxic_Dose_Annotation"
    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/Transcribed_RNA"></see>
    /// </summary>
    let Transcribed_RNA = _prefix "Transcribed_RNA"
    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/Transcript_Resource"></see>
    /// </summary>
    let Transcript_Resource = _prefix "Transcript_Resource"
    /// <summary>
    /// Extent of a transit peptide (mitochondrion, chloroplast, thylakoid, cyanelle or microbody).
    /// <see href="http://purl.uniprot.org/core/Transit_Peptide_Annotation"></see></summary>
    let Transit_Peptide_Annotation = _prefix "Transit_Peptide_Annotation"
    /// <summary>
    /// Extent of a transmembrane region.
    /// <see href="http://purl.uniprot.org/core/Transmembrane_Annotation"></see></summary>
    let Transmembrane_Annotation = _prefix "Transmembrane_Annotation"
    /// <summary>
    /// Turns within the experimentally determined protein structure.
    /// <see href="http://purl.uniprot.org/core/Turn_Annotation"></see></summary>
    let Turn_Annotation = _prefix "Turn_Annotation"
    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/Unassigned_DNA"></see>
    /// </summary>
    let Unassigned_DNA = _prefix "Unassigned_DNA"
    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/Unassigned_RNA"></see>
    /// </summary>
    let Unassigned_RNA = _prefix "Unassigned_RNA"
    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/Unknown_Sequence"></see>
    /// </summary>
    let Unknown_Sequence = _prefix "Unknown_Sequence"
    /// <summary>
    /// Positive cRNA molecule that is made from from a single stranded genomic RNA.
    /// <see href="http://purl.uniprot.org/core/Viral_cRNA"></see></summary>
    let Viral_cRNA = _prefix "Viral_cRNA"
    /// <summary>
    /// Extent of a zinc finger region.
    /// <see href="http://purl.uniprot.org/core/Zinc_Finger_Annotation"></see></summary>
    let Zinc_Finger_Annotation = _prefix "Zinc_Finger_Annotation"
    /// <summary>
    /// True if the class does not have any direct instances.
    /// <see href="http://purl.uniprot.org/core/abstract"></see></summary>
    let abstract_ = _prefix "abstract"
    /// <summary>
    /// The description of a catalytic activity.
    /// <see href="http://purl.uniprot.org/core/activity"></see></summary>
    let activity = _prefix "activity"
    /// <summary>
    /// An alternative name used in the flat text format.
    /// <see href="http://purl.uniprot.org/core/alias"></see></summary>
    let alias = _prefix "alias"
    /// <summary>
    /// See http://www.expasy.org/cgi-bin/lists?allergen.txt
    /// <see href="http://purl.uniprot.org/core/allergenName"></see></summary>
    let allergenName = _prefix "allergenName"
    /// <summary>
    /// All names of the protein, from commonly used to obsolete, to used in the literature..
    /// <see href="http://purl.uniprot.org/core/structuredNameType"></see></summary>
    let structuredNameType = _prefix "structuredNameType"
    /// <summary>
    /// A synonym of the recommended name.
    /// <see href="http://purl.uniprot.org/core/alternativeName"></see></summary>
    let alternativeName = _prefix "alternativeName"
    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/structuredName"></see>
    /// </summary>
    let structuredName = _prefix "structuredName"
    /// <summary>
    /// Attaches an annotation to a resource.
    /// <see href="http://purl.uniprot.org/core/annotation"></see></summary>
    let annotation = _prefix "annotation"
    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/attribution"></see>
    /// </summary>
    let attribution = _prefix "attribution"
    /// <summary>
    /// True if the protein is divergent in sequence or has mutated functional sites.
    /// <see href="http://purl.uniprot.org/core/atypical"></see></summary>
    let atypical = _prefix "atypical"
    /// <summary>
    /// The author of a publication.
    /// <see href="http://purl.uniprot.org/core/author"></see></summary>
    let author = _prefix "author"
    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/authorsIncomplete"></see>
    /// </summary>
    let authorsIncomplete = _prefix "authorsIncomplete"
    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/base"></see>
    /// </summary>
    let base_ = _prefix "base"
    /// <summary>
    /// A name used in a biotechnological context.
    /// <see href="http://purl.uniprot.org/core/biotechName"></see></summary>
    let biotechName = _prefix "biotechName"
    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/category"></see>
    /// </summary>
    let category = _prefix "category"
    /// <summary>
    /// A name from the Human Cell Differentiation Molecules (HCDM) nomenclature.
    /// <see href="http://purl.uniprot.org/core/cdAntigenName"></see></summary>
    let cdAntigenName = _prefix "cdAntigenName"
    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/cellularComponent"></see>
    /// </summary>
    let cellularComponent = _prefix "cellularComponent"
    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/orientation"></see>
    /// </summary>
    let orientation = _prefix "orientation"
    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/topology"></see>
    /// </summary>
    let topology = _prefix "topology"
    /// <summary>
    /// False if there is any uncertainty about a statement.
    /// <see href="http://purl.uniprot.org/core/certain"></see></summary>
    let certain = _prefix "certain"
    /// <summary>
    /// Maps a series of symbols representing chains of a protein to a range of amino acids.
    /// <see href="http://purl.uniprot.org/core/chain"></see></summary>
    let chain = _prefix "chain"
    /// <summary>
    /// An caclulated value that is used to detect if there are errors in the sequence as shown due to among others IO errors. Both the crc64 and md5sum have collisions in UniProt data and cannot be used as unique keys.
    /// <see href="http://purl.uniprot.org/core/checksum"></see></summary>
    let checksum = _prefix "checksum"
    /// <summary>
    /// A publication from which data was extracted, or which contains additional information.
    /// <see href="http://purl.uniprot.org/core/citation"></see></summary>
    let citation = _prefix "citation"
    /// <summary>
    /// A concept that classifies this resource.
    /// <see href="http://purl.uniprot.org/core/classifiedWith"></see></summary>
    let classifiedWith = _prefix "classifiedWith"
    /// <summary>
    /// A cofactor required for a catalytic activity.
    /// <see href="http://purl.uniprot.org/core/cofactor"></see></summary>
    let cofactor = _prefix "cofactor"
    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/commonName"></see>
    /// </summary>
    let commonName = _prefix "commonName"
    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/commonTaxon"></see>
    /// </summary>
    let commonTaxon = _prefix "commonTaxon"
    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/complete"></see>
    /// </summary>
    let complete = _prefix "complete"
    /// <summary>
    /// A component of a protein.
    /// <see href="http://purl.uniprot.org/core/component"></see></summary>
    let component_ = _prefix "component"
    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/part"></see>
    /// </summary>
    let part = _prefix "part"
    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/conflictingSequence"></see>
    /// </summary>
    let conflictingSequence = _prefix "conflictingSequence"
    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/crc64Checksum"></see>
    /// </summary>
    let crc64Checksum = _prefix "crc64Checksum"
    /// <summary>
    /// The date a resource was created.
    /// <see href="http://purl.uniprot.org/core/created"></see></summary>
    let created = _prefix "created"
    /// <summary>
    /// A domain of a protein.
    /// <see href="http://purl.uniprot.org/core/domain"></see></summary>
    let domain = _prefix "domain"
    /// <summary>
    /// The number of domains in a protein that correspond to a family. This is almost always 1, but may be 2 if  two identical domains are fused.
    /// <see href="http://purl.uniprot.org/core/domains"></see></summary>
    let domains = _prefix "domains"
    /// <summary>
    /// The ecName is the enzyme classification associated with a structured name of the protein. Proteins are often named after their enzymatic activity but can have more than one activity leading to multiple names.
    /// <see href="http://purl.uniprot.org/core/ecName"></see></summary>
    let ecName = _prefix "ecName"
    /// <summary>
    /// The editor of a publication.
    /// <see href="http://purl.uniprot.org/core/editor"></see></summary>
    let editor = _prefix "editor"
    /// <summary>
    /// The gene by which a protein is encoded.
    /// <see href="http://purl.uniprot.org/core/encodedBy"></see></summary>
    let encodedBy = _prefix "encodedBy"
    /// <summary>
    /// The subcellular location where a protein is encoded.
    /// <see href="http://purl.uniprot.org/core/encodedIn"></see></summary>
    let encodedIn = _prefix "encodedIn"
    /// <summary>
    /// The catalytic activity associated with a protein. or part of a protein.
    /// <see href="http://purl.uniprot.org/core/enzyme"></see></summary>
    let enzyme = _prefix "enzyme"
    /// <summary>
    /// An erratum for a publication.
    /// <see href="http://purl.uniprot.org/core/erratum"></see></summary>
    let erratum = _prefix "erratum"
    /// <summary>
    /// The publication which an erratum refers to.
    /// <see href="http://purl.uniprot.org/core/erratumFor"></see></summary>
    let erratumFor = _prefix "erratumFor"
    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/experiments"></see>
    /// </summary>
    let experiments = _prefix "experiments"
    /// <summary>
    /// True if a statement is true even though it was not predicted.
    /// <see href="http://purl.uniprot.org/core/falseNegative"></see></summary>
    let falseNegative = _prefix "falseNegative"
    /// <summary>
    /// Indicates if a sequence is complete or consists of one or more fragments.
    /// <see href="http://purl.uniprot.org/core/fragment"></see></summary>
    let fragment = _prefix "fragment"
    /// <summary>
    /// True if a sequence modification causes a frameshift.
    /// <see href="http://purl.uniprot.org/core/frameshift"></see></summary>
    let frameshift = _prefix "frameshift"
    /// <summary>
    /// The full name.
    /// <see href="http://purl.uniprot.org/core/fullName"></see></summary>
    let fullName = _prefix "fullName"
    /// <summary>
    /// True if the rule on which the membership of a protein to a family is based does not cover the entire protein.
    /// <see href="http://purl.uniprot.org/core/fused"></see></summary>
    let fused = _prefix "fused"
    /// <summary>
    /// The group or consortium that authored a publication.
    /// <see href="http://purl.uniprot.org/core/group"></see></summary>
    let group = _prefix "group"
    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/height"></see>
    /// </summary>
    let height = _prefix "height"
    /// <summary>
    /// The number of hits found in a sequence.
    /// <see href="http://purl.uniprot.org/core/hits"></see></summary>
    let hits = _prefix "hits"
    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/host"></see>
    /// </summary>
    let host = _prefix "host"
    /// <summary>
    /// The level of sequence identity in a cluster.
    /// <see href="http://purl.uniprot.org/core/identity"></see></summary>
    let identity = _prefix "identity"
    /// <summary>
    /// True if existance of this resource can be inferred.
    /// <see href="http://purl.uniprot.org/core/implicit"></see></summary>
    let implicit = _prefix "implicit"
    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/indexable"></see>
    /// </summary>
    let indexable = _prefix "indexable"
    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/interaction"></see>
    /// </summary>
    let interaction = _prefix "interaction"
    /// <summary>
    /// The international nonproprietary name: A generic name for a pharmaceutical substance or active pharmaceutical ingredient that is globally recognized and is a public property.
    /// <see href="http://purl.uniprot.org/core/internationalNonproprietaryName"></see></summary>
    let internationalNonproprietaryName = _prefix "internationalNonproprietaryName"
    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/isolatedFrom"></see>
    /// </summary>
    let isolatedFrom = _prefix "isolatedFrom"
    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/length"></see>
    /// </summary>
    let length = _prefix "length"
    /// <summary>
    /// True if the range does not extend beyond the specified endpoint.
    /// <see href="http://purl.uniprot.org/core/limit"></see></summary>
    let limit = _prefix "limit"
    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/locatedIn"></see>
    /// </summary>
    let locatedIn = _prefix "locatedIn"
    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/locator"></see>
    /// </summary>
    let locator = _prefix "locator"
    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/locusName"></see>
    /// </summary>
    let locusName = _prefix "locusName"
    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/manual"></see>
    /// </summary>
    let manual = _prefix "manual"
    /// <summary>
    /// The mass of a sequence in Daltons.
    /// <see href="http://purl.uniprot.org/core/mass"></see></summary>
    let mass = _prefix "mass"
    /// <summary>
    /// A maximum value.
    /// <see href="http://purl.uniprot.org/core/maximum"></see></summary>
    let maximum = _prefix "maximum"
    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/md5Checksum"></see>
    /// </summary>
    let md5Checksum = _prefix "md5Checksum"
    /// <summary>
    /// The maximum velocity, Vmax.
    /// <see href="http://purl.uniprot.org/core/measuredActivity"></see></summary>
    let measuredActivity = _prefix "measuredActivity"
    /// <summary>
    /// The Michaelis-Menten constant, Km.
    /// <see href="http://purl.uniprot.org/core/measuredAffinity"></see></summary>
    let measuredAffinity = _prefix "measuredAffinity"
    /// <summary>
    /// The magnitude of the error of a value that was measured.
    /// <see href="http://purl.uniprot.org/core/measuredError"></see></summary>
    let measuredError = _prefix "measuredError"
    /// <summary>
    /// A value that was measured.
    /// <see href="http://purl.uniprot.org/core/measuredValue"></see></summary>
    let measuredValue = _prefix "measuredValue"
    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/memberOf"></see>
    /// </summary>
    let memberOf = _prefix "memberOf"
    /// <summary>
    /// The date a resource was last modified.
    /// <see href="http://purl.uniprot.org/core/modified"></see></summary>
    let modified = _prefix "modified"
    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/negative"></see>
    /// </summary>
    let negative = _prefix "negative"
    /// <summary>
    /// A mnemonic that is no longer in use for this entry.
    /// <see href="http://purl.uniprot.org/core/oldMnemonic"></see></summary>
    let oldMnemonic = _prefix "oldMnemonic"
    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/orfName"></see>
    /// </summary>
    let orfName = _prefix "orfName"
    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/otherName"></see>
    /// </summary>
    let otherName = _prefix "otherName"
    /// <summary>
    /// The first and last page for a chapter or article.
    /// <see href="http://purl.uniprot.org/core/pages"></see></summary>
    let pages = _prefix "pages"
    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/partOf"></see>
    /// </summary>
    let partOf = _prefix "partOf"
    /// <summary>
    /// True for taxa that can appear as part of an organism's lineage.
    /// <see href="http://purl.uniprot.org/core/partOfLineage"></see></summary>
    let partOfLineage = _prefix "partOfLineage"
    /// <summary>
    /// True if the pattern or profile on which the domain assignment is based did not detect the sequence because the sequence is not complete and lacks the region on which the pattern or profile is based.
    /// <see href="http://purl.uniprot.org/core/partial"></see></summary>
    let partial = _prefix "partial"
    /// <summary>
    /// A protein that participates in a protein-protein interaction.
    /// <see href="http://purl.uniprot.org/core/participant"></see></summary>
    let participant = _prefix "participant"
    /// <summary>
    /// A URL pattern, used to generate links by substituting an identifier.
    /// <see href="http://purl.uniprot.org/core/pattern"></see></summary>
    let pattern = _prefix "pattern"
    /// <summary>
    /// The place where a publication was published. This usually includes a country name.
    /// <see href="http://purl.uniprot.org/core/place"></see></summary>
    let place = _prefix "place"
    /// <summary>
    /// A position on a sequence.
    /// <see href="http://purl.uniprot.org/core/position"></see></summary>
    let position = _prefix "position"
    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/precursor"></see>
    /// </summary>
    let precursor = _prefix "precursor"
    /// <summary>
    /// The publisher of a book.
    /// <see href="http://purl.uniprot.org/core/publisher"></see></summary>
    let publisher = _prefix "publisher"
    /// <summary>
    /// A range of amino acids.
    /// <see href="http://purl.uniprot.org/core/range"></see></summary>
    let range = _prefix "range"
    /// <summary>
    /// The rank of a taxon.
    /// <see href="http://purl.uniprot.org/core/rank"></see></summary>
    let rank = _prefix "rank"
    /// <summary>
    /// The name recommended by the UniProt consortium.
    /// <see href="http://purl.uniprot.org/core/recommendedName"></see></summary>
    let recommendedName = _prefix "recommendedName"
    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/referenceProteome"></see>
    /// </summary>
    let referenceProteome = _prefix "referenceProteome"
    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/relatedLocation"></see>
    /// </summary>
    let relatedLocation = _prefix "relatedLocation"
    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/representativeFor"></see>
    /// </summary>
    let representativeFor = _prefix "representativeFor"
    /// <summary>
    /// The resolution of an experiment, in Angstrom.
    /// <see href="http://purl.uniprot.org/core/resolution"></see></summary>
    let resolution = _prefix "resolution"
    /// <summary>
    /// Indicates whether a resource has been reviewed by a curator.
    /// <see href="http://purl.uniprot.org/core/reviewed"></see></summary>
    let reviewed = _prefix "reviewed"
    /// <summary>
    /// The extent of the work carried out by the authors of a publication.
    /// <see href="http://purl.uniprot.org/core/scope"></see></summary>
    let scope = _prefix "scope"
    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/seedFor"></see>
    /// </summary>
    let seedFor = _prefix "seedFor"
    /// <summary>
    /// A resource that describes this sequence.
    /// <see href="http://purl.uniprot.org/core/sequenceFor"></see></summary>
    let sequenceFor = _prefix "sequenceFor"
    /// <summary>
    /// An abbreviation of the full name or an acronym.
    /// <see href="http://purl.uniprot.org/core/shortName"></see></summary>
    let shortName = _prefix "shortName"
    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/source"></see>
    /// </summary>
    let source = _prefix "source"
    /// <summary>
    /// The reliability of a statement.
    /// <see href="http://purl.uniprot.org/core/status"></see></summary>
    let status = _prefix "status"
    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/strain"></see>
    /// </summary>
    let strain = _prefix "strain"
    /// <summary>
    /// A name provided by the submitter of the underlying nucleotide sequence.
    /// <see href="http://purl.uniprot.org/core/submittedName"></see></summary>
    let submittedName = _prefix "submittedName"
    /// <summary>
    /// A replacement sequence.
    /// <see href="http://purl.uniprot.org/core/substitution"></see></summary>
    let substitution = _prefix "substitution"
    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/synonym"></see>
    /// </summary>
    let synonym = _prefix "synonym"
    /// <summary>
    /// The title of a publication.
    /// <see href="http://purl.uniprot.org/core/title"></see></summary>
    let title = _prefix "title"
    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/transcribedFrom"></see>
    /// </summary>
    let transcribedFrom = _prefix "transcribedFrom"
    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/translatedFrom"></see>
    /// </summary>
    let translatedFrom = _prefix "translatedFrom"
    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/translatedTo"></see>
    /// </summary>
    let translatedTo = _prefix "translatedTo"
    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/version"></see>
    /// </summary>
    let version = _prefix "version"
    /// <summary>
    /// The volume a publication is part of.
    /// <see href="http://purl.uniprot.org/core/volume"></see></summary>
    let volume = _prefix "volume"
    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/width"></see>
    /// </summary>
    let width = _prefix "width"
    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/xeno"></see>
    /// </summary>
    let xeno = _prefix "xeno"
