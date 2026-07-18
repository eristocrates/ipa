namespace http.purl.uniprot.org.core.slash

open DoxAletheia.Rdf_Vocabulary

module uniprot =
    let _namespace_name = "http://purl.uniprot.org/core/"

    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/Inferred_from_Homology_Existence"></see>
    /// </summary>
    let Inferred_from_Homology_Existence =
        Namespaced_IRI.parse _namespace_name "Inferred_from_Homology_Existence" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/Evidence_at_Protein_Level_Existence"></see>
    /// </summary>
    let Evidence_at_Protein_Level_Existence =
        Namespaced_IRI.parse _namespace_name "Evidence_at_Protein_Level_Existence" |> NamespacedName

    /// <summary>
    /// Indicates that the existence of a protein has not been strictly proven but that expression data (such as existence of cDNA(s), RT-PCR or Northern blots) indicate the existence of a transcript.
    /// <see href="http://purl.uniprot.org/core/Evidence_at_Transcript_Level_Existence"></see></summary>
    let Evidence_at_Transcript_Level_Existence =
        Namespaced_IRI.parse _namespace_name "Evidence_at_Transcript_Level_Existence" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/Class"></see>
    /// </summary>
    let Class = Namespaced_IRI.parse _namespace_name "Class" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/Family"></see>
    /// </summary>
    let Family = Namespaced_IRI.parse _namespace_name "Family" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/Subkingdom"></see>
    /// </summary>
    let Subkingdom = Namespaced_IRI.parse _namespace_name "Subkingdom" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/Suborder"></see>
    /// </summary>
    let Suborder = Namespaced_IRI.parse _namespace_name "Suborder" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/Species"></see>
    /// </summary>
    let Species = Namespaced_IRI.parse _namespace_name "Species" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/Subgenus"></see>
    /// </summary>
    let Subgenus = Namespaced_IRI.parse _namespace_name "Subgenus" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/Tribe"></see>
    /// </summary>
    let Tribe = Namespaced_IRI.parse _namespace_name "Tribe" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/Subclass"></see>
    /// </summary>
    let Subclass = Namespaced_IRI.parse _namespace_name "Subclass" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/Genus"></see>
    /// </summary>
    let Genus = Namespaced_IRI.parse _namespace_name "Genus" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/Phylum"></see>
    /// </summary>
    let Phylum = Namespaced_IRI.parse _namespace_name "Phylum" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/Subtribe"></see>
    /// </summary>
    let Subtribe = Namespaced_IRI.parse _namespace_name "Subtribe" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/Superclass"></see>
    /// </summary>
    let Superclass = Namespaced_IRI.parse _namespace_name "Superclass" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/Superfamily"></see>
    /// </summary>
    let Superfamily =
        Namespaced_IRI.parse _namespace_name "Superfamily" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/Superorder"></see>
    /// </summary>
    let Superorder = Namespaced_IRI.parse _namespace_name "Superorder" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/Order"></see>
    /// </summary>
    let Order = Namespaced_IRI.parse _namespace_name "Order" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/Species_Subgroup"></see>
    /// </summary>
    let Species_Subgroup =
        Namespaced_IRI.parse _namespace_name "Species_Subgroup" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/Superkingdom"></see>
    /// </summary>
    let Superkingdom =
        Namespaced_IRI.parse _namespace_name "Superkingdom" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/Subspecies"></see>
    /// </summary>
    let Subspecies = Namespaced_IRI.parse _namespace_name "Subspecies" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/Kingdom"></see>
    /// </summary>
    let Kingdom = Namespaced_IRI.parse _namespace_name "Kingdom" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/Superphylum"></see>
    /// </summary>
    let Superphylum =
        Namespaced_IRI.parse _namespace_name "Superphylum" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/Subfamily"></see>
    /// </summary>
    let Subfamily = Namespaced_IRI.parse _namespace_name "Subfamily" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/Subphylum"></see>
    /// </summary>
    let Subphylum = Namespaced_IRI.parse _namespace_name "Subphylum" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/Forma"></see>
    /// </summary>
    let Forma = Namespaced_IRI.parse _namespace_name "Forma" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/Parvorder"></see>
    /// </summary>
    let Parvorder = Namespaced_IRI.parse _namespace_name "Parvorder" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/Varietas"></see>
    /// </summary>
    let Varietas = Namespaced_IRI.parse _namespace_name "Varietas" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/Species_Group"></see>
    /// </summary>
    let Species_Group =
        Namespaced_IRI.parse _namespace_name "Species_Group" |> NamespacedName

    /// <summary>
    /// This is used for proteins without evidence at protein, transcript, or homology levels.
    /// <see href="http://purl.uniprot.org/core/Predicted_Existence"></see></summary>
    let Predicted_Existence =
        Namespaced_IRI.parse _namespace_name "Predicted_Existence" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/PD"></see>
    /// </summary>
    let PD = Namespaced_IRI.parse _namespace_name "PD" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/FAB"></see>
    /// </summary>
    let FAB = Namespaced_IRI.parse _namespace_name "FAB" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/LSIMS"></see>
    /// </summary>
    let LSIMS = Namespaced_IRI.parse _namespace_name "LSIMS" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/MALDI"></see>
    /// </summary>
    let MALDI = Namespaced_IRI.parse _namespace_name "MALDI" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/SELDI"></see>
    /// </summary>
    let SELDI = Namespaced_IRI.parse _namespace_name "SELDI" |> NamespacedName
    /// <summary>
    /// Mass measurement using Atmospheric Pressure Ionization
    /// <see href="http://purl.uniprot.org/core/API"></see></summary>
    let API = Namespaced_IRI.parse _namespace_name "API" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/ESI"></see>
    /// </summary>
    let ESI = Namespaced_IRI.parse _namespace_name "ESI" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/Fiber_Diffraction"></see>
    /// </summary>
    let Fiber_Diffraction =
        Namespaced_IRI.parse _namespace_name "Fiber_Diffraction" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/Prediction"></see>
    /// </summary>
    let Prediction = Namespaced_IRI.parse _namespace_name "Prediction" |> NamespacedName

    /// <summary>
    /// A technique in crystallography in which the pattern produced by the diffraction of x-rays through the closely spaced lattice of atoms in a crystal is recorded and then analyzed to reveal the nature of that lattice.
    /// <see href="http://purl.uniprot.org/core/X-Ray_Crystallography"></see></summary>
    let ``X-Ray_Crystallography`` =
        Namespaced_IRI.parse _namespace_name "X-Ray_Crystallography" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/Neutron_Diffraction"></see>
    /// </summary>
    let Neutron_Diffraction =
        Namespaced_IRI.parse _namespace_name "Neutron_Diffraction" |> NamespacedName

    /// <summary>
    /// The electron microscope is a microscope that can magnify very small details with high resolving power due to the use of electrons rather than light to scatter off material, magnifying at levels up to 500,000 times.
    /// <see href="http://purl.uniprot.org/core/Electron_Microscopy"></see></summary>
    let Electron_Microscopy =
        Namespaced_IRI.parse _namespace_name "Electron_Microscopy" |> NamespacedName

    /// <summary>
    /// A type of spectroscopy that uses the Infrared portion of the electromagnetic spectrum.
    /// <see href="http://purl.uniprot.org/core/Infrared_Spectroscopy"></see></summary>
    let Infrared_Spectroscopy =
        Namespaced_IRI.parse _namespace_name "Infrared_Spectroscopy" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/NMR_Spectroscopy"></see>
    /// </summary>
    let NMR_Spectroscopy =
        Namespaced_IRI.parse _namespace_name "NMR_Spectroscopy" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/Uncertain_Existence"></see>
    /// </summary>
    let Uncertain_Existence =
        Namespaced_IRI.parse _namespace_name "Uncertain_Existence" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/By_Similarity"></see>
    /// </summary>
    let By_Similarity =
        Namespaced_IRI.parse _namespace_name "By_Similarity" |> NamespacedName

    /// <summary>
    /// indicates that there is some logical or conclusive evidence that the given annotation could apply. This non-experimental qualifier is often used to present results from protein sequence analysis software tools, which are only annotated if the result makes sense in the biological context of a given protein. A typical example is the annotation of N-glycosylation sites in secreted proteins
    /// <see href="http://purl.uniprot.org/core/Potential"></see></summary>
    let Potential = Namespaced_IRI.parse _namespace_name "Potential" |> NamespacedName
    /// <summary>
    /// The status ‘Probable’ indicates stronger evidence than the qualifier ‘Potential’. This qualifier implies that there must be at least some experimental evidence, which indicates, that the information is expected to be found in the natural environment of a protein.
    /// <see href="http://purl.uniprot.org/core/Probable"></see></summary>
    let Probable = Namespaced_IRI.parse _namespace_name "Probable" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/Experimental"></see>
    /// </summary>
    let Experimental =
        Namespaced_IRI.parse _namespace_name "Experimental" |> NamespacedName

    /// <summary>
    /// An experimental method for measuring the mass of a molecule.
    /// <see href="http://purl.uniprot.org/core/Mass_Measurement_Method"></see></summary>
    let Mass_Measurement_Method =
        Namespaced_IRI.parse _namespace_name "Mass_Measurement_Method" |> NamespacedName

    /// <summary>
    /// Indicates the wavelength in nm at which photoreactive proteins such as opsins and DNA photolyases show maximal absorption.
    /// <see href="http://purl.uniprot.org/core/Absorption_Annotation"></see></summary>
    let Absorption_Annotation =
        Namespaced_IRI.parse _namespace_name "Absorption_Annotation" |> NamespacedName

    /// <summary>
    /// Biophysical and physicochemical data such as pH dependence, temperature dependence, kinetic parameters, redox potentials, and maximal absorption.
    /// <see href="http://purl.uniprot.org/core/Biophysicochemical_Annotation"></see></summary>
    let Biophysicochemical_Annotation =
        Namespaced_IRI.parse _namespace_name "Biophysicochemical_Annotation" |> NamespacedName

    /// <summary>
    /// Amino acid(s) involved in the activity of an enzyme.
    /// <see href="http://purl.uniprot.org/core/Active_Site_Annotation"></see></summary>
    let Active_Site_Annotation =
        Namespaced_IRI.parse _namespace_name "Active_Site_Annotation" |> NamespacedName

    /// <summary>
    /// Any interesting single amino-acid site on the sequence, that is not defined by another feature key. It can also apply to an amino acid bond which is represented by the positions of the two flanking amino acids.
    /// <see href="http://purl.uniprot.org/core/Site_Annotation"></see></summary>
    let Site_Annotation =
        Namespaced_IRI.parse _namespace_name "Site_Annotation" |> NamespacedName

    /// <summary>
    /// Information relevant to allergenic proteins.
    /// <see href="http://purl.uniprot.org/core/Allergen_Annotation"></see></summary>
    let Allergen_Annotation =
        Namespaced_IRI.parse _namespace_name "Allergen_Annotation" |> NamespacedName

    /// <summary>
    /// Description of a resource on a specific topic.
    /// <see href="http://purl.uniprot.org/core/Annotation"></see></summary>
    let Annotation = Namespaced_IRI.parse _namespace_name "Annotation" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/Alternative_Initiation_Annotation"></see>
    /// </summary>
    let Alternative_Initiation_Annotation =
        Namespaced_IRI.parse _namespace_name "Alternative_Initiation_Annotation" |> NamespacedName

    /// <summary>
    /// Description of the existence of related protein sequences produced by alternative splicing of the same gene or by the use of alternative initiation codons.
    /// <see href="http://purl.uniprot.org/core/Alternative_Products_Annotation"></see></summary>
    let Alternative_Products_Annotation =
        Namespaced_IRI.parse _namespace_name "Alternative_Products_Annotation" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/Alternative_Promoter_Usage_Annotation"></see>
    /// </summary>
    let Alternative_Promoter_Usage_Annotation =
        Namespaced_IRI.parse _namespace_name "Alternative_Promoter_Usage_Annotation" |> NamespacedName

    /// <summary>
    /// Description of sequence variants produced by alternative splicing.
    /// <see href="http://purl.uniprot.org/core/Alternative_Sequence_Annotation"></see></summary>
    let Alternative_Sequence_Annotation =
        Namespaced_IRI.parse _namespace_name "Alternative_Sequence_Annotation" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/Natural_Variation_Annotation"></see>
    /// </summary>
    let Natural_Variation_Annotation =
        Namespaced_IRI.parse _namespace_name "Natural_Variation_Annotation" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/Alternative_Splicing_Annotation"></see>
    /// </summary>
    let Alternative_Splicing_Annotation =
        Namespaced_IRI.parse _namespace_name "Alternative_Splicing_Annotation" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/Apicoplast"></see>
    /// </summary>
    let Apicoplast = Namespaced_IRI.parse _namespace_name "Apicoplast" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/Organelle"></see>
    /// </summary>
    let Organelle = Namespaced_IRI.parse _namespace_name "Organelle" |> NamespacedName

    /// <summary>
    /// Entity used to attach evidence or provenance to a rdf statement via reification.
    /// <see href="http://purl.uniprot.org/core/Attribution"></see></summary>
    let Attribution =
        Namespaced_IRI.parse _namespace_name "Attribution" |> NamespacedName

    /// <summary>
    /// Beta strand regions within the experimentally determined protein structure
    /// <see href="http://purl.uniprot.org/core/Beta_Strand_Annotation"></see></summary>
    let Beta_Strand_Annotation =
        Namespaced_IRI.parse _namespace_name "Beta_Strand_Annotation" |> NamespacedName

    /// <summary>
    /// Describes the secondary structure of proteins whose tertiary structure is known experimentally.
    /// <see href="http://purl.uniprot.org/core/Secondary_Structure_Annotation"></see></summary>
    let Secondary_Structure_Annotation =
        Namespaced_IRI.parse _namespace_name "Secondary_Structure_Annotation" |> NamespacedName

    /// <summary>
    /// Binding site for any chemical group (co-enzyme, prosthetic group, etc.).
    /// <see href="http://purl.uniprot.org/core/Binding_Site_Annotation"></see></summary>
    let Binding_Site_Annotation =
        Namespaced_IRI.parse _namespace_name "Binding_Site_Annotation" |> NamespacedName

    /// <summary>
    /// Description of the use of a specific protein in a biotechnological process.
    /// <see href="http://purl.uniprot.org/core/Biotechnology_Annotation"></see></summary>
    let Biotechnology_Annotation =
        Namespaced_IRI.parse _namespace_name "Biotechnology_Annotation" |> NamespacedName

    /// <summary>
    /// A chapter from a book.
    /// <see href="http://purl.uniprot.org/core/Book_Citation"></see></summary>
    let Book_Citation =
        Namespaced_IRI.parse _namespace_name "Book_Citation" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/name"></see>
    /// </summary>
    let name = Namespaced_IRI.parse _namespace_name "name" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/Published_Citation"></see>
    /// </summary>
    let Published_Citation =
        Namespaced_IRI.parse _namespace_name "Published_Citation" |> NamespacedName

    /// <summary>
    /// Indicator for the reliability of a piece of information.
    /// <see href="http://purl.uniprot.org/core/Status"></see></summary>
    let Status = Namespaced_IRI.parse _namespace_name "Status" |> NamespacedName

    /// <summary>
    /// Extent of a calcium-binding region.
    /// <see href="http://purl.uniprot.org/core/Calcium_Binding_Annotation"></see></summary>
    let Calcium_Binding_Annotation =
        Namespaced_IRI.parse _namespace_name "Calcium_Binding_Annotation" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/Region_Annotation"></see>
    /// </summary>
    let Region_Annotation =
        Namespaced_IRI.parse _namespace_name "Region_Annotation" |> NamespacedName

    /// <summary>
    /// Description of the reactions catalyzed by an enzyme.
    /// <see href="http://purl.uniprot.org/core/Catalytic_Activity_Annotation"></see></summary>
    let Catalytic_Activity_Annotation =
        Namespaced_IRI.parse _namespace_name "Catalytic_Activity_Annotation" |> NamespacedName

    /// <summary>
    /// Warning about possible errors and/or grounds for confusion.
    /// <see href="http://purl.uniprot.org/core/Caution_Annotation"></see></summary>
    let Caution_Annotation =
        Namespaced_IRI.parse _namespace_name "Caution_Annotation" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/Cellular_Component"></see>
    /// </summary>
    let Cellular_Component =
        Namespaced_IRI.parse _namespace_name "Cellular_Component" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/Subcellular_Location"></see>
    /// </summary>
    let Subcellular_Location =
        Namespaced_IRI.parse _namespace_name "Subcellular_Location" |> NamespacedName

    /// <summary>
    /// Extent of a polypeptide chain in the mature protein.
    /// <see href="http://purl.uniprot.org/core/Chain_Annotation"></see></summary>
    let Chain_Annotation =
        Namespaced_IRI.parse _namespace_name "Chain_Annotation" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/Molecule_Processing_Annotation"></see>
    /// </summary>
    let Molecule_Processing_Annotation =
        Namespaced_IRI.parse _namespace_name "Molecule_Processing_Annotation" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/Chloroplast"></see>
    /// </summary>
    let Chloroplast =
        Namespaced_IRI.parse _namespace_name "Chloroplast" |> NamespacedName

    /// <summary>
    /// Description of a publication from which data was obtained.
    /// <see href="http://purl.uniprot.org/core/Citation"></see></summary>
    let Citation = Namespaced_IRI.parse _namespace_name "Citation" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/date"></see>
    /// </summary>
    let date = Namespaced_IRI.parse _namespace_name "date" |> NamespacedName
    /// <summary>
    /// An amino acid sequence.
    /// <see href="http://purl.uniprot.org/core/Sequence"></see></summary>
    let Sequence = Namespaced_IRI.parse _namespace_name "Sequence" |> NamespacedName
    /// <summary>
    /// A range of amino acids on a protein  sequence.
    /// <see href="http://purl.uniprot.org/core/Range"></see></summary>
    let Range = Namespaced_IRI.parse _namespace_name "Range" |> NamespacedName
    /// <summary>
    /// Description of a protein.
    /// <see href="http://purl.uniprot.org/core/Protein"></see></summary>
    let Protein = Namespaced_IRI.parse _namespace_name "Protein" |> NamespacedName

    /// <summary>
    /// The relationship between a resource and a citation.
    /// <see href="http://purl.uniprot.org/core/Citation_Statement"></see></summary>
    let Citation_Statement =
        Namespaced_IRI.parse _namespace_name "Citation_Statement" |> NamespacedName

    /// <summary>
    /// A strain of a species.
    /// <see href="http://purl.uniprot.org/core/Strain"></see></summary>
    let Strain = Namespaced_IRI.parse _namespace_name "Strain" |> NamespacedName
    /// <summary>
    /// A tissue such as lung or heart.
    /// <see href="http://purl.uniprot.org/core/Tissue"></see></summary>
    let Tissue = Namespaced_IRI.parse _namespace_name "Tissue" |> NamespacedName
    /// <summary>
    /// A transposon
    /// <see href="http://purl.uniprot.org/core/Transposon"></see></summary>
    let Transposon = Namespaced_IRI.parse _namespace_name "Transposon" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/context"></see>
    /// </summary>
    let context = Namespaced_IRI.parse _namespace_name "context" |> NamespacedName
    /// <summary>
    /// A rank of a taxon.
    /// <see href="http://purl.uniprot.org/core/Rank"></see></summary>
    let Rank = Namespaced_IRI.parse _namespace_name "Rank" |> NamespacedName
    /// <summary>
    /// Cluster of proteins with similar sequences.
    /// <see href="http://purl.uniprot.org/core/Cluster"></see></summary>
    let Cluster = Namespaced_IRI.parse _namespace_name "Cluster" |> NamespacedName
    /// <summary>
    /// One of several similar resources.
    /// <see href="http://purl.uniprot.org/core/member"></see></summary>
    let member_ = Namespaced_IRI.parse _namespace_name "member" |> NamespacedName

    /// <summary>
    /// Description of an enzyme cofactor.
    /// <see href="http://purl.uniprot.org/core/Cofactor_Annotation"></see></summary>
    let Cofactor_Annotation =
        Namespaced_IRI.parse _namespace_name "Cofactor_Annotation" |> NamespacedName

    /// <summary>
    /// Extent of a coiled-coil region.
    /// <see href="http://purl.uniprot.org/core/Coiled_Coil_Annotation"></see></summary>
    let Coiled_Coil_Annotation =
        Namespaced_IRI.parse _namespace_name "Coiled_Coil_Annotation" |> NamespacedName

    /// <summary>
    /// Extent of a compositionally biased region.
    /// <see href="http://purl.uniprot.org/core/Compositional_Bias_Annotation"></see></summary>
    let Compositional_Bias_Annotation =
        Namespaced_IRI.parse _namespace_name "Compositional_Bias_Annotation" |> NamespacedName

    /// <summary>
    /// A concept used to classify resources.
    /// <see href="http://purl.uniprot.org/core/Concept"></see></summary>
    let Concept = Namespaced_IRI.parse _namespace_name "Concept" |> NamespacedName
    /// <summary>
    /// A resource that is replaced by this resource.
    /// <see href="http://purl.uniprot.org/core/replaces"></see></summary>
    let replaces = Namespaced_IRI.parse _namespace_name "replaces" |> NamespacedName

    /// <summary>
    /// Posttranslationally formed amino acid bonds.
    /// <see href="http://purl.uniprot.org/core/Cross-link_Annotation"></see></summary>
    let ``Cross-link_Annotation`` =
        Namespaced_IRI.parse _namespace_name "Cross-link_Annotation" |> NamespacedName

    /// <summary>
    /// Describes amino acid modifications, post pre- and post-translational.
    /// <see href="http://purl.uniprot.org/core/Modification_Annotation"></see></summary>
    let Modification_Annotation =
        Namespaced_IRI.parse _namespace_name "Modification_Annotation" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/Cyanelle"></see>
    /// </summary>
    let Cyanelle = Namespaced_IRI.parse _namespace_name "Cyanelle" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/DNA"></see>
    /// </summary>
    let DNA = Namespaced_IRI.parse _namespace_name "DNA" |> NamespacedName
    /// <summary>
    /// A biological molecule.
    /// <see href="http://purl.uniprot.org/core/Molecule"></see></summary>
    let Molecule = Namespaced_IRI.parse _namespace_name "Molecule" |> NamespacedName
    /// <summary>
    /// Metadata for a life science database.
    /// <see href="http://purl.uniprot.org/core/Database"></see></summary>
    let Database = Namespaced_IRI.parse _namespace_name "Database" |> NamespacedName

    /// <summary>
    /// Description of the developmentally-specific expression of a protein.
    /// <see href="http://purl.uniprot.org/core/Developmental_Stage_Annotation"></see></summary>
    let Developmental_Stage_Annotation =
        Namespaced_IRI.parse _namespace_name "Developmental_Stage_Annotation" |> NamespacedName

    /// <summary>
    /// Description of the diseases associated with a deficiency of a protein.
    /// <see href="http://purl.uniprot.org/core/Disease_Annotation"></see></summary>
    let Disease_Annotation =
        Namespaced_IRI.parse _namespace_name "Disease_Annotation" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/Disruption_Phenotype_Annotation"></see>
    /// </summary>
    let Disruption_Phenotype_Annotation =
        Namespaced_IRI.parse _namespace_name "Disruption_Phenotype_Annotation" |> NamespacedName

    /// <summary>
    /// Describes residues which are linked by an intra-chain disulfide bond. If the endpoints are identical, the disulfide bond is an interchain one.
    /// <see href="http://purl.uniprot.org/core/Disulfide_Bond_Annotation"></see></summary>
    let Disulfide_Bond_Annotation =
        Namespaced_IRI.parse _namespace_name "Disulfide_Bond_Annotation" |> NamespacedName

    /// <summary>
    /// Description of the domain structure of a protein.
    /// <see href="http://purl.uniprot.org/core/Domain_Annotation"></see></summary>
    let Domain_Annotation =
        Namespaced_IRI.parse _namespace_name "Domain_Annotation" |> NamespacedName

    /// <summary>
    /// The relationship between a protein and a protein domain.
    /// <see href="http://purl.uniprot.org/core/Domain_Assignment_Statement"></see></summary>
    let Domain_Assignment_Statement =
        Namespaced_IRI.parse _namespace_name "Domain_Assignment_Statement" |> NamespacedName

    /// <summary>
    /// Extent of a domain, which is defined as a specific combination of secondary structures organized into a characteristic three-dimensional structure or fold.
    /// <see href="http://purl.uniprot.org/core/Domain_Extent_Annotation"></see></summary>
    let Domain_Extent_Annotation =
        Namespaced_IRI.parse _namespace_name "Domain_Extent_Annotation" |> NamespacedName

    /// <summary>
    /// An experimental method for determining the 3D structure of a protein.
    /// <see href="http://purl.uniprot.org/core/Structure_Determination_Method"></see></summary>
    let Structure_Determination_Method =
        Namespaced_IRI.parse _namespace_name "Structure_Determination_Method" |> NamespacedName

    /// <summary>
    /// An electronic publication.
    /// <see href="http://purl.uniprot.org/core/Electronic_Citation"></see></summary>
    let Electronic_Citation =
        Namespaced_IRI.parse _namespace_name "Electronic_Citation" |> NamespacedName

    /// <summary>
    /// Metadata for an endpoint of a range on a sequence.
    /// <see href="http://purl.uniprot.org/core/Endpoint_Statement"></see></summary>
    let Endpoint_Statement =
        Namespaced_IRI.parse _namespace_name "Endpoint_Statement" |> NamespacedName

    /// <summary>
    /// A specific catalytic activity, defined by the Enzyme Commission of the Nomenclature Committee of the International Union of Biochemistry and Molecular Biology (IUBMB).
    /// <see href="http://purl.uniprot.org/core/Enzyme"></see></summary>
    let Enzyme = Namespaced_IRI.parse _namespace_name "Enzyme" |> NamespacedName
    /// <summary>
    /// A resource that replaces this resource.
    /// <see href="http://purl.uniprot.org/core/replacedBy"></see></summary>
    let replacedBy = Namespaced_IRI.parse _namespace_name "replacedBy" |> NamespacedName

    /// <summary>
    /// Description of an enzyme regulatory mechanism.
    /// <see href="http://purl.uniprot.org/core/Enzyme_Regulation_Annotation"></see></summary>
    let Enzyme_Regulation_Annotation =
        Namespaced_IRI.parse _namespace_name "Enzyme_Regulation_Annotation" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/Erroneous_Gene_Model_Prediction_Annotation"></see>
    /// </summary>
    let Erroneous_Gene_Model_Prediction_Annotation =
        Namespaced_IRI.parse _namespace_name "Erroneous_Gene_Model_Prediction_Annotation" |> NamespacedName

    /// <summary>
    /// Warning about possible errors related to the protein sequence
    /// <see href="http://purl.uniprot.org/core/Sequence_Caution_Annotation"></see></summary>
    let Sequence_Caution_Annotation =
        Namespaced_IRI.parse _namespace_name "Sequence_Caution_Annotation" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/Erroneous_Initiation_Annotation"></see>
    /// </summary>
    let Erroneous_Initiation_Annotation =
        Namespaced_IRI.parse _namespace_name "Erroneous_Initiation_Annotation" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/Erroneous_Termination_Annotation"></see>
    /// </summary>
    let Erroneous_Termination_Annotation =
        Namespaced_IRI.parse _namespace_name "Erroneous_Termination_Annotation" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/Erroneous_Translation_Annotation"></see>
    /// </summary>
    let Erroneous_Translation_Annotation =
        Namespaced_IRI.parse _namespace_name "Erroneous_Translation_Annotation" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/Protein_Existence"></see>
    /// </summary>
    let Protein_Existence =
        Namespaced_IRI.parse _namespace_name "Protein_Existence" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/Experimental_Information_Annotation"></see>
    /// </summary>
    let Experimental_Information_Annotation =
        Namespaced_IRI.parse _namespace_name "Experimental_Information_Annotation" |> NamespacedName

    /// <summary>
    /// Description of a special region or site in a protein sequence.
    /// <see href="http://purl.uniprot.org/core/Sequence_Annotation"></see></summary>
    let Sequence_Annotation =
        Namespaced_IRI.parse _namespace_name "Sequence_Annotation" |> NamespacedName

    /// <summary>
    /// The protein described in the linked record is an alternative splice form of the same gene product as described in this record. The function between the two isoforms is highly divergent.
    /// <see href="http://purl.uniprot.org/core/External_Sequence"></see></summary>
    let External_Sequence =
        Namespaced_IRI.parse _namespace_name "External_Sequence" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/Known_Sequence"></see>
    /// </summary>
    let Known_Sequence =
        Namespaced_IRI.parse _namespace_name "Known_Sequence" |> NamespacedName

    /// <summary>
    /// The relationship between a protein and a protein family.
    /// <see href="http://purl.uniprot.org/core/Family_Membership_Statement"></see></summary>
    let Family_Membership_Statement =
        Namespaced_IRI.parse _namespace_name "Family_Membership_Statement" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/Frameshift_Annotation"></see>
    /// </summary>
    let Frameshift_Annotation =
        Namespaced_IRI.parse _namespace_name "Frameshift_Annotation" |> NamespacedName

    /// <summary>
    /// General description of the functions of a protein.
    /// <see href="http://purl.uniprot.org/core/Function_Annotation"></see></summary>
    let Function_Annotation =
        Namespaced_IRI.parse _namespace_name "Function_Annotation" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/Gene"></see>
    /// </summary>
    let Gene = Namespaced_IRI.parse _namespace_name "Gene" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/Genomic_DNA"></see>
    /// </summary>
    let Genomic_DNA =
        Namespaced_IRI.parse _namespace_name "Genomic_DNA" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/Genomic_RNA"></see>
    /// </summary>
    let Genomic_RNA =
        Namespaced_IRI.parse _namespace_name "Genomic_RNA" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/RNA"></see>
    /// </summary>
    let RNA = Namespaced_IRI.parse _namespace_name "RNA" |> NamespacedName

    /// <summary>
    /// Describes the occurrence of the attachment of a glycan (mono- or polysaccharide) to a residue of a protein.
    /// <see href="http://purl.uniprot.org/core/Glycosylation_Annotation"></see></summary>
    let Glycosylation_Annotation =
        Namespaced_IRI.parse _namespace_name "Glycosylation_Annotation" |> NamespacedName

    /// <summary>
    /// Helical regions within the experimentally determined protein structure
    /// <see href="http://purl.uniprot.org/core/Helix_Annotation"></see></summary>
    let Helix_Annotation =
        Namespaced_IRI.parse _namespace_name "Helix_Annotation" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/Hydrogenosome"></see>
    /// </summary>
    let Hydrogenosome =
        Namespaced_IRI.parse _namespace_name "Hydrogenosome" |> NamespacedName

    /// <summary>
    /// Description of the compounds or conditions that stimulate the synthesis of a protein.
    /// <see href="http://purl.uniprot.org/core/Induction_Annotation"></see></summary>
    let Induction_Annotation =
        Namespaced_IRI.parse _namespace_name "Induction_Annotation" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/Infraclass"></see>
    /// </summary>
    let Infraclass = Namespaced_IRI.parse _namespace_name "Infraclass" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/Infraorder"></see>
    /// </summary>
    let Infraorder = Namespaced_IRI.parse _namespace_name "Infraorder" |> NamespacedName

    /// <summary>
    /// Indicates that the initiator methionine has been cleaved off and is not shown in the sequence.
    /// <see href="http://purl.uniprot.org/core/Initiator_Methionine_Annotation"></see></summary>
    let Initiator_Methionine_Annotation =
        Namespaced_IRI.parse _namespace_name "Initiator_Methionine_Annotation" |> NamespacedName

    /// <summary>
    /// Description of a protein-protein interaction.
    /// <see href="http://purl.uniprot.org/core/Interaction"></see></summary>
    let Interaction =
        Namespaced_IRI.parse _namespace_name "Interaction" |> NamespacedName

    /// <summary>
    /// Extent of a region located in a membrane without crossing it
    /// <see href="http://purl.uniprot.org/core/Intramembrane_Annotation"></see></summary>
    let Intramembrane_Annotation =
        Namespaced_IRI.parse _namespace_name "Intramembrane_Annotation" |> NamespacedName

    /// <summary>
    /// An article published in a journal.
    /// <see href="http://purl.uniprot.org/core/Journal_Citation"></see></summary>
    let Journal_Citation =
        Namespaced_IRI.parse _namespace_name "Journal_Citation" |> NamespacedName

    /// <summary>
    /// Mentions the Michaelis-Menten constant (KM) and maximal velocity (Vmax) of enzymes.
    /// <see href="http://purl.uniprot.org/core/Kinetics_Annotation"></see></summary>
    let Kinetics_Annotation =
        Namespaced_IRI.parse _namespace_name "Kinetics_Annotation" |> NamespacedName

    /// <summary>
    /// Covalent binding of a lipid moiety.
    /// <see href="http://purl.uniprot.org/core/Lipidation_Annotation"></see></summary>
    let Lipidation_Annotation =
        Namespaced_IRI.parse _namespace_name "Lipidation_Annotation" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/MRNA"></see>
    /// </summary>
    let MRNA = Namespaced_IRI.parse _namespace_name "MRNA" |> NamespacedName
    /// <summary>
    /// An experimental method.
    /// <see href="http://purl.uniprot.org/core/Method"></see></summary>
    let Method = Namespaced_IRI.parse _namespace_name "Method" |> NamespacedName

    /// <summary>
    /// Indicates the mass of a sequence determined by mass spectrometry.
    /// <see href="http://purl.uniprot.org/core/Mass_Spectrometry_Annotation"></see></summary>
    let Mass_Spectrometry_Annotation =
        Namespaced_IRI.parse _namespace_name "Mass_Spectrometry_Annotation" |> NamespacedName

    /// <summary>
    /// The experimental method that was used.
    /// <see href="http://purl.uniprot.org/core/method"></see></summary>
    let method = Namespaced_IRI.parse _namespace_name "method" |> NamespacedName

    /// <summary>
    /// Binding site for a metal ion.
    /// <see href="http://purl.uniprot.org/core/Metal_Binding_Annotation"></see></summary>
    let Metal_Binding_Annotation =
        Namespaced_IRI.parse _namespace_name "Metal_Binding_Annotation" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/Mitochondrion"></see>
    /// </summary>
    let Mitochondrion =
        Namespaced_IRI.parse _namespace_name "Mitochondrion" |> NamespacedName

    /// <summary>
    /// Posttranslational modification of a residue.
    /// <see href="http://purl.uniprot.org/core/Modified_Residue_Annotation"></see></summary>
    let Modified_Residue_Annotation =
        Namespaced_IRI.parse _namespace_name "Modified_Residue_Annotation" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/Modified_Sequence"></see>
    /// </summary>
    let Modified_Sequence =
        Namespaced_IRI.parse _namespace_name "Modified_Sequence" |> NamespacedName

    /// <summary>
    /// A modification of a sequence.
    /// <see href="http://purl.uniprot.org/core/modification"></see></summary>
    let modification =
        Namespaced_IRI.parse _namespace_name "modification" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/Simple_Sequence"></see>
    /// </summary>
    let Simple_Sequence =
        Namespaced_IRI.parse _namespace_name "Simple_Sequence" |> NamespacedName

    /// <summary>
    /// The sequence on which the description of a modified sequence is based.
    /// <see href="http://purl.uniprot.org/core/basedOn"></see></summary>
    let basedOn = Namespaced_IRI.parse _namespace_name "basedOn" |> NamespacedName

    /// <summary>
    /// Short (&lt;=20 amino acids) sequence motif of biological interest.
    /// <see href="http://purl.uniprot.org/core/Motif_Annotation"></see></summary>
    let Motif_Annotation =
        Namespaced_IRI.parse _namespace_name "Motif_Annotation" |> NamespacedName

    /// <summary>
    /// Site which has been experimentally altered.
    /// <see href="http://purl.uniprot.org/core/Mutagenesis_Annotation"></see></summary>
    let Mutagenesis_Annotation =
        Namespaced_IRI.parse _namespace_name "Mutagenesis_Annotation" |> NamespacedName

    /// <summary>
    /// Extent of a nucleotide phosphate-binding region.
    /// <see href="http://purl.uniprot.org/core/NP_Binding_Annotation"></see></summary>
    let NP_Binding_Annotation =
        Namespaced_IRI.parse _namespace_name "NP_Binding_Annotation" |> NamespacedName

    /// <summary>
    /// Authors report that sequence variants exist.
    /// <see href="http://purl.uniprot.org/core/Natural_Variant_Annotation"></see></summary>
    let Natural_Variant_Annotation =
        Namespaced_IRI.parse _namespace_name "Natural_Variant_Annotation" |> NamespacedName

    /// <summary>
    /// Indicates that two residues in a sequence are not consecutive and that there are a number of unsequenced residues between them.
    /// <see href="http://purl.uniprot.org/core/Non-adjacent_Residues_Annotation"></see></summary>
    let ``Non-adjacent_Residues_Annotation`` =
        Namespaced_IRI.parse _namespace_name "Non-adjacent_Residues_Annotation" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/Non-photosynthetic_plastid"></see>
    /// </summary>
    let ``Non-photosynthetic_plastid`` =
        Namespaced_IRI.parse _namespace_name "Non-photosynthetic_plastid" |> NamespacedName

    /// <summary>
    /// Describes the occurrence of a non standard residue in the sequence record.
    /// <see href="http://purl.uniprot.org/core/Non-standard_Residue_Annotation"></see></summary>
    let ``Non-standard_Residue_Annotation`` =
        Namespaced_IRI.parse _namespace_name "Non-standard_Residue_Annotation" |> NamespacedName

    /// <summary>
    /// The residue at an extremity of the sequence is not the terminal residue.
    /// <see href="http://purl.uniprot.org/core/Non-terminal_Residue_Annotation"></see></summary>
    let ``Non-terminal_Residue_Annotation`` =
        Namespaced_IRI.parse _namespace_name "Non-terminal_Residue_Annotation" |> NamespacedName

    /// <summary>
    /// A class introduced to group all records that are currently in the database.
    /// <see href="http://purl.uniprot.org/core/NotObsolete"></see></summary>
    let NotObsolete =
        Namespaced_IRI.parse _namespace_name "NotObsolete" |> NamespacedName

    /// <summary>
    /// The class of all obsolete records in the database (i.e. records that where once published but are now removed).
    /// <see href="http://purl.uniprot.org/core/Obsolete"></see></summary>
    let Obsolete = Namespaced_IRI.parse _namespace_name "Obsolete" |> NamespacedName
    /// <summary>
    /// True if this resource has been replaced or deleted.
    /// <see href="http://purl.uniprot.org/core/obsolete"></see></summary>
    let obsolete = Namespaced_IRI.parse _namespace_name "obsolete" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/NotObsoleteProtein"></see>
    /// </summary>
    let NotObsoleteProtein =
        Namespaced_IRI.parse _namespace_name "NotObsoleteProtein" |> NamespacedName

    /// <summary>
    /// The organism in which a protein occurs.
    /// <see href="http://purl.uniprot.org/core/organism"></see></summary>
    let organism = Namespaced_IRI.parse _namespace_name "organism" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/existence"></see>
    /// </summary>
    let existence = Namespaced_IRI.parse _namespace_name "existence" |> NamespacedName
    /// <summary>
    /// An amino acid sequence.
    /// <see href="http://purl.uniprot.org/core/sequence"></see></summary>
    let sequence = Namespaced_IRI.parse _namespace_name "sequence" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/NotObsoleteTaxon"></see>
    /// </summary>
    let NotObsoleteTaxon =
        Namespaced_IRI.parse _namespace_name "NotObsoleteTaxon" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/scientificName"></see>
    /// </summary>
    let scientificName =
        Namespaced_IRI.parse _namespace_name "scientificName" |> NamespacedName

    /// <summary>
    /// An element of a taxonomy for classifying life forms.
    /// <see href="http://purl.uniprot.org/core/Taxon"></see></summary>
    let Taxon = Namespaced_IRI.parse _namespace_name "Taxon" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/Nucleomorph"></see>
    /// </summary>
    let Nucleomorph =
        Namespaced_IRI.parse _namespace_name "Nucleomorph" |> NamespacedName

    /// <summary>
    /// Extent of a DNA-binding region.
    /// <see href="http://purl.uniprot.org/core/Nucleotide_Binding_Annotation"></see></summary>
    let Nucleotide_Binding_Annotation =
        Namespaced_IRI.parse _namespace_name "Nucleotide_Binding_Annotation" |> NamespacedName

    /// <summary>
    /// The relationship between a protein and a nucleotide sequence.
    /// <see href="http://purl.uniprot.org/core/Nucleotide_Mapping_Statement"></see></summary>
    let Nucleotide_Mapping_Statement =
        Namespaced_IRI.parse _namespace_name "Nucleotide_Mapping_Statement" |> NamespacedName

    /// <summary>
    /// A resource that descripes a nucleotide sequence.
    /// <see href="http://purl.uniprot.org/core/Nucleotide_Resource"></see></summary>
    let Nucleotide_Resource =
        Namespaced_IRI.parse _namespace_name "Nucleotide_Resource" |> NamespacedName

    /// <summary>
    /// A life science resource.
    /// <see href="http://purl.uniprot.org/core/Resource"></see></summary>
    let Resource = Namespaced_IRI.parse _namespace_name "Resource" |> NamespacedName
    /// <summary>
    /// The molecule a this resource is located on.
    /// <see href="http://purl.uniprot.org/core/locatedOn"></see></summary>
    let locatedOn = Namespaced_IRI.parse _namespace_name "locatedOn" |> NamespacedName

    /// <summary>
    /// Citation of an unpublished result.
    /// <see href="http://purl.uniprot.org/core/Observation_Citation"></see></summary>
    let Observation_Citation =
        Namespaced_IRI.parse _namespace_name "Observation_Citation" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/Unpublished_Citation"></see>
    /// </summary>
    let Unpublished_Citation =
        Namespaced_IRI.parse _namespace_name "Unpublished_Citation" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/ObsoleteProtein"></see>
    /// </summary>
    let ObsoleteProtein =
        Namespaced_IRI.parse _namespace_name "ObsoleteProtein" |> NamespacedName

    /// <summary>
    /// Taxa are occasionally removed from the taxonomy database (particularly internal nodes, during a taxonomic revision) – these taxids are deleted, and are not reused.
    /// <see href="http://purl.uniprot.org/core/ObsoleteTaxon"></see></summary>
    let ObsoleteTaxon =
        Namespaced_IRI.parse _namespace_name "ObsoleteTaxon" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/Organellar_chromatophore"></see>
    /// </summary>
    let Organellar_chromatophore =
        Namespaced_IRI.parse _namespace_name "Organellar_chromatophore" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/Orientation"></see>
    /// </summary>
    let Orientation =
        Namespaced_IRI.parse _namespace_name "Orientation" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/Other_DNA"></see>
    /// </summary>
    let Other_DNA = Namespaced_IRI.parse _namespace_name "Other_DNA" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/Other_RNA"></see>
    /// </summary>
    let Other_RNA = Namespaced_IRI.parse _namespace_name "Other_RNA" |> NamespacedName

    /// <summary>
    /// Describes the optimum pH for enzyme activity and/or the variation of enzyme activity with pH variation.
    /// <see href="http://purl.uniprot.org/core/PH_Dependence_Annotation"></see></summary>
    let PH_Dependence_Annotation =
        Namespaced_IRI.parse _namespace_name "PH_Dependence_Annotation" |> NamespacedName

    /// <summary>
    /// Description of a posttranslational modification.
    /// <see href="http://purl.uniprot.org/core/PTM_Annotation"></see></summary>
    let PTM_Annotation =
        Namespaced_IRI.parse _namespace_name "PTM_Annotation" |> NamespacedName

    /// <summary>
    /// Description of a part of a protein.
    /// <see href="http://purl.uniprot.org/core/Part"></see></summary>
    let Part = Namespaced_IRI.parse _namespace_name "Part" |> NamespacedName

    /// <summary>
    /// A participant in a protein-protein interaction.
    /// <see href="http://purl.uniprot.org/core/Participant"></see></summary>
    let Participant =
        Namespaced_IRI.parse _namespace_name "Participant" |> NamespacedName

    /// <summary>
    /// A patent application.
    /// <see href="http://purl.uniprot.org/core/Patent_Citation"></see></summary>
    let Patent_Citation =
        Namespaced_IRI.parse _namespace_name "Patent_Citation" |> NamespacedName

    /// <summary>
    /// A hierarchical discription of a metabolic pathway.
    /// <see href="http://purl.uniprot.org/core/Pathway"></see></summary>
    let Pathway = Namespaced_IRI.parse _namespace_name "Pathway" |> NamespacedName

    /// <summary>
    /// Description of the metabolic pathways with which a protein is associated.
    /// <see href="http://purl.uniprot.org/core/Pathway_Annotation"></see></summary>
    let Pathway_Annotation =
        Namespaced_IRI.parse _namespace_name "Pathway_Annotation" |> NamespacedName

    /// <summary>
    /// Extent of a released active peptide.
    /// <see href="http://purl.uniprot.org/core/Peptide_Annotation"></see></summary>
    let Peptide_Annotation =
        Namespaced_IRI.parse _namespace_name "Peptide_Annotation" |> NamespacedName

    /// <summary>
    /// Description of the use of a protein as a pharmaceutical drug.
    /// <see href="http://purl.uniprot.org/core/Pharmaceutical_Annotation"></see></summary>
    let Pharmaceutical_Annotation =
        Namespaced_IRI.parse _namespace_name "Pharmaceutical_Annotation" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/Plastid"></see>
    /// </summary>
    let Plastid = Namespaced_IRI.parse _namespace_name "Plastid" |> NamespacedName

    /// <summary>
    /// Description of polymorphisms.
    /// <see href="http://purl.uniprot.org/core/Polymorphism_Annotation"></see></summary>
    let Polymorphism_Annotation =
        Namespaced_IRI.parse _namespace_name "Polymorphism_Annotation" |> NamespacedName

    /// <summary>
    /// Extent of a propeptide.
    /// <see href="http://purl.uniprot.org/core/Propeptide_Annotation"></see></summary>
    let Propeptide_Annotation =
        Namespaced_IRI.parse _namespace_name "Propeptide_Annotation" |> NamespacedName

    /// <summary>
    /// Desription of a set of related proteins.
    /// <see href="http://purl.uniprot.org/core/Protein_Family"></see></summary>
    let Protein_Family =
        Namespaced_IRI.parse _namespace_name "Protein_Family" |> NamespacedName

    /// <summary>
    /// Description of any type of RNA editing that leads to one or more amino acid changes.
    /// <see href="http://purl.uniprot.org/core/RNA_Editing_Annotation"></see></summary>
    let RNA_Editing_Annotation =
        Namespaced_IRI.parse _namespace_name "RNA_Editing_Annotation" |> NamespacedName

    /// <summary>
    /// The first position of a range.
    /// <see href="http://purl.uniprot.org/core/begin"></see></summary>
    let begin_ = Namespaced_IRI.parse _namespace_name "begin" |> NamespacedName
    /// <summary>
    /// The last position of a range.
    /// <see href="http://purl.uniprot.org/core/end"></see></summary>
    let end_ = Namespaced_IRI.parse _namespace_name "end" |> NamespacedName

    /// <summary>
    /// Reports the value of the standard (midpoint) oxido-reduction potential(s) for electron transport proteins.
    /// <see href="http://purl.uniprot.org/core/Redox_Potential_Annotation"></see></summary>
    let Redox_Potential_Annotation =
        Namespaced_IRI.parse _namespace_name "Redox_Potential_Annotation" |> NamespacedName

    /// <summary>
    /// Extent of an internal sequence repetition.
    /// <see href="http://purl.uniprot.org/core/Repeat_Annotation"></see></summary>
    let Repeat_Annotation =
        Namespaced_IRI.parse _namespace_name "Repeat_Annotation" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/database"></see>
    /// </summary>
    let database = Namespaced_IRI.parse _namespace_name "database" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/Ribosomal_Frameshifting"></see>
    /// </summary>
    let Ribosomal_Frameshifting =
        Namespaced_IRI.parse _namespace_name "Ribosomal_Frameshifting" |> NamespacedName

    /// <summary>
    /// Different sources report differing sequences.
    /// <see href="http://purl.uniprot.org/core/Sequence_Conflict_Annotation"></see></summary>
    let Sequence_Conflict_Annotation =
        Namespaced_IRI.parse _namespace_name "Sequence_Conflict_Annotation" |> NamespacedName

    /// <summary>
    /// Used to describe region(s) of a sequence for which the authors are unsure about the sequence assignment.
    /// <see href="http://purl.uniprot.org/core/Sequence_Uncertainty_Annotation"></see></summary>
    let Sequence_Uncertainty_Annotation =
        Namespaced_IRI.parse _namespace_name "Sequence_Uncertainty_Annotation" |> NamespacedName

    /// <summary>
    /// Extent of a signal sequence (prepeptide).
    /// <see href="http://purl.uniprot.org/core/Signal_Peptide_Annotation"></see></summary>
    let Signal_Peptide_Annotation =
        Namespaced_IRI.parse _namespace_name "Signal_Peptide_Annotation" |> NamespacedName

    /// <summary>
    /// Description of the similarities (sequence or structural) of a protein with other proteins.
    /// <see href="http://purl.uniprot.org/core/Similarity_Annotation"></see></summary>
    let Similarity_Annotation =
        Namespaced_IRI.parse _namespace_name "Similarity_Annotation" |> NamespacedName

    /// <summary>
    /// The relationship between a protein and a 3D structure.
    /// <see href="http://purl.uniprot.org/core/Structure_Mapping_Statement"></see></summary>
    let Structure_Mapping_Statement =
        Namespaced_IRI.parse _namespace_name "Structure_Mapping_Statement" |> NamespacedName

    /// <summary>
    /// A resource that describes the 3D structure of a protein.
    /// <see href="http://purl.uniprot.org/core/Structure_Resource"></see></summary>
    let Structure_Resource =
        Namespaced_IRI.parse _namespace_name "Structure_Resource" |> NamespacedName

    /// <summary>
    /// A resource that holds a set of the known names for this protein together.
    /// <see href="http://purl.uniprot.org/core/Structured_Name"></see></summary>
    let Structured_Name =
        Namespaced_IRI.parse _namespace_name "Structured_Name" |> NamespacedName

    /// <summary>
    /// Description of the subcellular location of the mature protein.
    /// <see href="http://purl.uniprot.org/core/Subcellular_Location_Annotation"></see></summary>
    let Subcellular_Location_Annotation =
        Namespaced_IRI.parse _namespace_name "Subcellular_Location_Annotation" |> NamespacedName

    /// <summary>
    /// Data that was submitted directly to a database.
    /// <see href="http://purl.uniprot.org/core/Submission_Citation"></see></summary>
    let Submission_Citation =
        Namespaced_IRI.parse _namespace_name "Submission_Citation" |> NamespacedName

    /// <summary>
    /// The database a resource  was submitted to.
    /// <see href="http://purl.uniprot.org/core/submittedTo"></see></summary>
    let submittedTo =
        Namespaced_IRI.parse _namespace_name "submittedTo" |> NamespacedName

    /// <summary>
    /// Description of the quaternary structure of a protein.
    /// <see href="http://purl.uniprot.org/core/Subunit_Annotation"></see></summary>
    let Subunit_Annotation =
        Namespaced_IRI.parse _namespace_name "Subunit_Annotation" |> NamespacedName

    /// <summary>
    /// A easy to remember identifier for a UniProtKB entry, but it is not a stable identifier and should not be used by programs to identify entries.
    /// <see href="http://purl.uniprot.org/core/mnemonic"></see></summary>
    let mnemonic = Namespaced_IRI.parse _namespace_name "mnemonic" |> NamespacedName

    /// <summary>
    /// Indicates the optimum temperature for enzyme activity and/or the variation of enzyme activity with temperature variation; the thermostability/thermolability of the enzyme is also mentioned when it is known.
    /// <see href="http://purl.uniprot.org/core/Temperature_Dependence_Annotation"></see></summary>
    let Temperature_Dependence_Annotation =
        Namespaced_IRI.parse _namespace_name "Temperature_Dependence_Annotation" |> NamespacedName

    /// <summary>
    /// A Ph.D. thesis.
    /// <see href="http://purl.uniprot.org/core/Thesis_Citation"></see></summary>
    let Thesis_Citation =
        Namespaced_IRI.parse _namespace_name "Thesis_Citation" |> NamespacedName

    /// <summary>
    /// The institution at which a thesis was written.
    /// <see href="http://purl.uniprot.org/core/institution"></see></summary>
    let institution =
        Namespaced_IRI.parse _namespace_name "institution" |> NamespacedName

    /// <summary>
    /// Description of the tissue specificity of a protein.
    /// <see href="http://purl.uniprot.org/core/Tissue_Specificity_Annotation"></see></summary>
    let Tissue_Specificity_Annotation =
        Namespaced_IRI.parse _namespace_name "Tissue_Specificity_Annotation" |> NamespacedName

    /// <summary>
    /// A topological domain.
    /// <see href="http://purl.uniprot.org/core/Topological_Domain_Annotation"></see></summary>
    let Topological_Domain_Annotation =
        Namespaced_IRI.parse _namespace_name "Topological_Domain_Annotation" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/Topology"></see>
    /// </summary>
    let Topology = Namespaced_IRI.parse _namespace_name "Topology" |> NamespacedName

    /// <summary>
    /// Information on the LD(50). LD stands for "Lethal Dose". LD(50) is the amount of a toxin, given all at once, which causes the death of 50% (one half) of a group of test animals.
    /// <see href="http://purl.uniprot.org/core/Toxic_Dose_Annotation"></see></summary>
    let Toxic_Dose_Annotation =
        Namespaced_IRI.parse _namespace_name "Toxic_Dose_Annotation" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/Transcribed_RNA"></see>
    /// </summary>
    let Transcribed_RNA =
        Namespaced_IRI.parse _namespace_name "Transcribed_RNA" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/Transcript_Resource"></see>
    /// </summary>
    let Transcript_Resource =
        Namespaced_IRI.parse _namespace_name "Transcript_Resource" |> NamespacedName

    /// <summary>
    /// Extent of a transit peptide (mitochondrion, chloroplast, thylakoid, cyanelle or microbody).
    /// <see href="http://purl.uniprot.org/core/Transit_Peptide_Annotation"></see></summary>
    let Transit_Peptide_Annotation =
        Namespaced_IRI.parse _namespace_name "Transit_Peptide_Annotation" |> NamespacedName

    /// <summary>
    /// Extent of a transmembrane region.
    /// <see href="http://purl.uniprot.org/core/Transmembrane_Annotation"></see></summary>
    let Transmembrane_Annotation =
        Namespaced_IRI.parse _namespace_name "Transmembrane_Annotation" |> NamespacedName

    /// <summary>
    /// Turns within the experimentally determined protein structure.
    /// <see href="http://purl.uniprot.org/core/Turn_Annotation"></see></summary>
    let Turn_Annotation =
        Namespaced_IRI.parse _namespace_name "Turn_Annotation" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/Unassigned_DNA"></see>
    /// </summary>
    let Unassigned_DNA =
        Namespaced_IRI.parse _namespace_name "Unassigned_DNA" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/Unassigned_RNA"></see>
    /// </summary>
    let Unassigned_RNA =
        Namespaced_IRI.parse _namespace_name "Unassigned_RNA" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/Unknown_Sequence"></see>
    /// </summary>
    let Unknown_Sequence =
        Namespaced_IRI.parse _namespace_name "Unknown_Sequence" |> NamespacedName

    /// <summary>
    /// Positive cRNA molecule that is made from from a single stranded genomic RNA.
    /// <see href="http://purl.uniprot.org/core/Viral_cRNA"></see></summary>
    let Viral_cRNA = Namespaced_IRI.parse _namespace_name "Viral_cRNA" |> NamespacedName

    /// <summary>
    /// Extent of a zinc finger region.
    /// <see href="http://purl.uniprot.org/core/Zinc_Finger_Annotation"></see></summary>
    let Zinc_Finger_Annotation =
        Namespaced_IRI.parse _namespace_name "Zinc_Finger_Annotation" |> NamespacedName

    /// <summary>
    /// True if the class does not have any direct instances.
    /// <see href="http://purl.uniprot.org/core/abstract"></see></summary>
    let abstract_ = Namespaced_IRI.parse _namespace_name "abstract" |> NamespacedName
    /// <summary>
    /// The description of a catalytic activity.
    /// <see href="http://purl.uniprot.org/core/activity"></see></summary>
    let activity = Namespaced_IRI.parse _namespace_name "activity" |> NamespacedName
    /// <summary>
    /// An alternative name used in the flat text format.
    /// <see href="http://purl.uniprot.org/core/alias"></see></summary>
    let alias = Namespaced_IRI.parse _namespace_name "alias" |> NamespacedName

    /// <summary>
    /// See http://www.expasy.org/cgi-bin/lists?allergen.txt
    /// <see href="http://purl.uniprot.org/core/allergenName"></see></summary>
    let allergenName =
        Namespaced_IRI.parse _namespace_name "allergenName" |> NamespacedName

    /// <summary>
    /// All names of the protein, from commonly used to obsolete, to used in the literature..
    /// <see href="http://purl.uniprot.org/core/structuredNameType"></see></summary>
    let structuredNameType =
        Namespaced_IRI.parse _namespace_name "structuredNameType" |> NamespacedName

    /// <summary>
    /// A synonym of the recommended name.
    /// <see href="http://purl.uniprot.org/core/alternativeName"></see></summary>
    let alternativeName =
        Namespaced_IRI.parse _namespace_name "alternativeName" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/structuredName"></see>
    /// </summary>
    let structuredName =
        Namespaced_IRI.parse _namespace_name "structuredName" |> NamespacedName

    /// <summary>
    /// Attaches an annotation to a resource.
    /// <see href="http://purl.uniprot.org/core/annotation"></see></summary>
    let annotation = Namespaced_IRI.parse _namespace_name "annotation" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/attribution"></see>
    /// </summary>
    let attribution =
        Namespaced_IRI.parse _namespace_name "attribution" |> NamespacedName

    /// <summary>
    /// True if the protein is divergent in sequence or has mutated functional sites.
    /// <see href="http://purl.uniprot.org/core/atypical"></see></summary>
    let atypical = Namespaced_IRI.parse _namespace_name "atypical" |> NamespacedName
    /// <summary>
    /// The author of a publication.
    /// <see href="http://purl.uniprot.org/core/author"></see></summary>
    let author = Namespaced_IRI.parse _namespace_name "author" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/authorsIncomplete"></see>
    /// </summary>
    let authorsIncomplete =
        Namespaced_IRI.parse _namespace_name "authorsIncomplete" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/base"></see>
    /// </summary>
    let base_ = Namespaced_IRI.parse _namespace_name "base" |> NamespacedName

    /// <summary>
    /// A name used in a biotechnological context.
    /// <see href="http://purl.uniprot.org/core/biotechName"></see></summary>
    let biotechName =
        Namespaced_IRI.parse _namespace_name "biotechName" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/category"></see>
    /// </summary>
    let category = Namespaced_IRI.parse _namespace_name "category" |> NamespacedName

    /// <summary>
    /// A name from the Human Cell Differentiation Molecules (HCDM) nomenclature.
    /// <see href="http://purl.uniprot.org/core/cdAntigenName"></see></summary>
    let cdAntigenName =
        Namespaced_IRI.parse _namespace_name "cdAntigenName" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/cellularComponent"></see>
    /// </summary>
    let cellularComponent =
        Namespaced_IRI.parse _namespace_name "cellularComponent" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/orientation"></see>
    /// </summary>
    let orientation =
        Namespaced_IRI.parse _namespace_name "orientation" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/topology"></see>
    /// </summary>
    let topology = Namespaced_IRI.parse _namespace_name "topology" |> NamespacedName
    /// <summary>
    /// False if there is any uncertainty about a statement.
    /// <see href="http://purl.uniprot.org/core/certain"></see></summary>
    let certain = Namespaced_IRI.parse _namespace_name "certain" |> NamespacedName
    /// <summary>
    /// Maps a series of symbols representing chains of a protein to a range of amino acids.
    /// <see href="http://purl.uniprot.org/core/chain"></see></summary>
    let chain = Namespaced_IRI.parse _namespace_name "chain" |> NamespacedName
    /// <summary>
    /// An caclulated value that is used to detect if there are errors in the sequence as shown due to among others IO errors. Both the crc64 and md5sum have collisions in UniProt data and cannot be used as unique keys.
    /// <see href="http://purl.uniprot.org/core/checksum"></see></summary>
    let checksum = Namespaced_IRI.parse _namespace_name "checksum" |> NamespacedName
    /// <summary>
    /// A publication from which data was extracted, or which contains additional information.
    /// <see href="http://purl.uniprot.org/core/citation"></see></summary>
    let citation = Namespaced_IRI.parse _namespace_name "citation" |> NamespacedName

    /// <summary>
    /// A concept that classifies this resource.
    /// <see href="http://purl.uniprot.org/core/classifiedWith"></see></summary>
    let classifiedWith =
        Namespaced_IRI.parse _namespace_name "classifiedWith" |> NamespacedName

    /// <summary>
    /// A cofactor required for a catalytic activity.
    /// <see href="http://purl.uniprot.org/core/cofactor"></see></summary>
    let cofactor = Namespaced_IRI.parse _namespace_name "cofactor" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/commonName"></see>
    /// </summary>
    let commonName = Namespaced_IRI.parse _namespace_name "commonName" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/commonTaxon"></see>
    /// </summary>
    let commonTaxon =
        Namespaced_IRI.parse _namespace_name "commonTaxon" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/complete"></see>
    /// </summary>
    let complete = Namespaced_IRI.parse _namespace_name "complete" |> NamespacedName
    /// <summary>
    /// A component of a protein.
    /// <see href="http://purl.uniprot.org/core/component"></see></summary>
    let component_ = Namespaced_IRI.parse _namespace_name "component" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/part"></see>
    /// </summary>
    let part = Namespaced_IRI.parse _namespace_name "part" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/conflictingSequence"></see>
    /// </summary>
    let conflictingSequence =
        Namespaced_IRI.parse _namespace_name "conflictingSequence" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/crc64Checksum"></see>
    /// </summary>
    let crc64Checksum =
        Namespaced_IRI.parse _namespace_name "crc64Checksum" |> NamespacedName

    /// <summary>
    /// The date a resource was created.
    /// <see href="http://purl.uniprot.org/core/created"></see></summary>
    let created = Namespaced_IRI.parse _namespace_name "created" |> NamespacedName
    /// <summary>
    /// A domain of a protein.
    /// <see href="http://purl.uniprot.org/core/domain"></see></summary>
    let domain = Namespaced_IRI.parse _namespace_name "domain" |> NamespacedName
    /// <summary>
    /// The number of domains in a protein that correspond to a family. This is almost always 1, but may be 2 if  two identical domains are fused.
    /// <see href="http://purl.uniprot.org/core/domains"></see></summary>
    let domains = Namespaced_IRI.parse _namespace_name "domains" |> NamespacedName
    /// <summary>
    /// The ecName is the enzyme classification associated with a structured name of the protein. Proteins are often named after their enzymatic activity but can have more than one activity leading to multiple names.
    /// <see href="http://purl.uniprot.org/core/ecName"></see></summary>
    let ecName = Namespaced_IRI.parse _namespace_name "ecName" |> NamespacedName
    /// <summary>
    /// The editor of a publication.
    /// <see href="http://purl.uniprot.org/core/editor"></see></summary>
    let editor = Namespaced_IRI.parse _namespace_name "editor" |> NamespacedName
    /// <summary>
    /// The gene by which a protein is encoded.
    /// <see href="http://purl.uniprot.org/core/encodedBy"></see></summary>
    let encodedBy = Namespaced_IRI.parse _namespace_name "encodedBy" |> NamespacedName
    /// <summary>
    /// The subcellular location where a protein is encoded.
    /// <see href="http://purl.uniprot.org/core/encodedIn"></see></summary>
    let encodedIn = Namespaced_IRI.parse _namespace_name "encodedIn" |> NamespacedName
    /// <summary>
    /// The catalytic activity associated with a protein. or part of a protein.
    /// <see href="http://purl.uniprot.org/core/enzyme"></see></summary>
    let enzyme = Namespaced_IRI.parse _namespace_name "enzyme" |> NamespacedName
    /// <summary>
    /// An erratum for a publication.
    /// <see href="http://purl.uniprot.org/core/erratum"></see></summary>
    let erratum = Namespaced_IRI.parse _namespace_name "erratum" |> NamespacedName
    /// <summary>
    /// The publication which an erratum refers to.
    /// <see href="http://purl.uniprot.org/core/erratumFor"></see></summary>
    let erratumFor = Namespaced_IRI.parse _namespace_name "erratumFor" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/experiments"></see>
    /// </summary>
    let experiments =
        Namespaced_IRI.parse _namespace_name "experiments" |> NamespacedName

    /// <summary>
    /// True if a statement is true even though it was not predicted.
    /// <see href="http://purl.uniprot.org/core/falseNegative"></see></summary>
    let falseNegative =
        Namespaced_IRI.parse _namespace_name "falseNegative" |> NamespacedName

    /// <summary>
    /// Indicates if a sequence is complete or consists of one or more fragments.
    /// <see href="http://purl.uniprot.org/core/fragment"></see></summary>
    let fragment = Namespaced_IRI.parse _namespace_name "fragment" |> NamespacedName
    /// <summary>
    /// True if a sequence modification causes a frameshift.
    /// <see href="http://purl.uniprot.org/core/frameshift"></see></summary>
    let frameshift = Namespaced_IRI.parse _namespace_name "frameshift" |> NamespacedName
    /// <summary>
    /// The full name.
    /// <see href="http://purl.uniprot.org/core/fullName"></see></summary>
    let fullName = Namespaced_IRI.parse _namespace_name "fullName" |> NamespacedName
    /// <summary>
    /// True if the rule on which the membership of a protein to a family is based does not cover the entire protein.
    /// <see href="http://purl.uniprot.org/core/fused"></see></summary>
    let fused = Namespaced_IRI.parse _namespace_name "fused" |> NamespacedName
    /// <summary>
    /// The group or consortium that authored a publication.
    /// <see href="http://purl.uniprot.org/core/group"></see></summary>
    let group = Namespaced_IRI.parse _namespace_name "group" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/height"></see>
    /// </summary>
    let height = Namespaced_IRI.parse _namespace_name "height" |> NamespacedName
    /// <summary>
    /// The number of hits found in a sequence.
    /// <see href="http://purl.uniprot.org/core/hits"></see></summary>
    let hits = Namespaced_IRI.parse _namespace_name "hits" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/host"></see>
    /// </summary>
    let host = Namespaced_IRI.parse _namespace_name "host" |> NamespacedName
    /// <summary>
    /// The level of sequence identity in a cluster.
    /// <see href="http://purl.uniprot.org/core/identity"></see></summary>
    let identity = Namespaced_IRI.parse _namespace_name "identity" |> NamespacedName
    /// <summary>
    /// True if existance of this resource can be inferred.
    /// <see href="http://purl.uniprot.org/core/implicit"></see></summary>
    let implicit = Namespaced_IRI.parse _namespace_name "implicit" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/indexable"></see>
    /// </summary>
    let indexable = Namespaced_IRI.parse _namespace_name "indexable" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/interaction"></see>
    /// </summary>
    let interaction =
        Namespaced_IRI.parse _namespace_name "interaction" |> NamespacedName

    /// <summary>
    /// The international nonproprietary name: A generic name for a pharmaceutical substance or active pharmaceutical ingredient that is globally recognized and is a public property.
    /// <see href="http://purl.uniprot.org/core/internationalNonproprietaryName"></see></summary>
    let internationalNonproprietaryName =
        Namespaced_IRI.parse _namespace_name "internationalNonproprietaryName" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/isolatedFrom"></see>
    /// </summary>
    let isolatedFrom =
        Namespaced_IRI.parse _namespace_name "isolatedFrom" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/length"></see>
    /// </summary>
    let length = Namespaced_IRI.parse _namespace_name "length" |> NamespacedName
    /// <summary>
    /// True if the range does not extend beyond the specified endpoint.
    /// <see href="http://purl.uniprot.org/core/limit"></see></summary>
    let limit = Namespaced_IRI.parse _namespace_name "limit" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/locatedIn"></see>
    /// </summary>
    let locatedIn = Namespaced_IRI.parse _namespace_name "locatedIn" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/locator"></see>
    /// </summary>
    let locator = Namespaced_IRI.parse _namespace_name "locator" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/locusName"></see>
    /// </summary>
    let locusName = Namespaced_IRI.parse _namespace_name "locusName" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/manual"></see>
    /// </summary>
    let manual = Namespaced_IRI.parse _namespace_name "manual" |> NamespacedName
    /// <summary>
    /// The mass of a sequence in Daltons.
    /// <see href="http://purl.uniprot.org/core/mass"></see></summary>
    let mass = Namespaced_IRI.parse _namespace_name "mass" |> NamespacedName
    /// <summary>
    /// A maximum value.
    /// <see href="http://purl.uniprot.org/core/maximum"></see></summary>
    let maximum = Namespaced_IRI.parse _namespace_name "maximum" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/md5Checksum"></see>
    /// </summary>
    let md5Checksum =
        Namespaced_IRI.parse _namespace_name "md5Checksum" |> NamespacedName

    /// <summary>
    /// The maximum velocity, Vmax.
    /// <see href="http://purl.uniprot.org/core/measuredActivity"></see></summary>
    let measuredActivity =
        Namespaced_IRI.parse _namespace_name "measuredActivity" |> NamespacedName

    /// <summary>
    /// The Michaelis-Menten constant, Km.
    /// <see href="http://purl.uniprot.org/core/measuredAffinity"></see></summary>
    let measuredAffinity =
        Namespaced_IRI.parse _namespace_name "measuredAffinity" |> NamespacedName

    /// <summary>
    /// The magnitude of the error of a value that was measured.
    /// <see href="http://purl.uniprot.org/core/measuredError"></see></summary>
    let measuredError =
        Namespaced_IRI.parse _namespace_name "measuredError" |> NamespacedName

    /// <summary>
    /// A value that was measured.
    /// <see href="http://purl.uniprot.org/core/measuredValue"></see></summary>
    let measuredValue =
        Namespaced_IRI.parse _namespace_name "measuredValue" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/memberOf"></see>
    /// </summary>
    let memberOf = Namespaced_IRI.parse _namespace_name "memberOf" |> NamespacedName
    /// <summary>
    /// The date a resource was last modified.
    /// <see href="http://purl.uniprot.org/core/modified"></see></summary>
    let modified = Namespaced_IRI.parse _namespace_name "modified" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/negative"></see>
    /// </summary>
    let negative = Namespaced_IRI.parse _namespace_name "negative" |> NamespacedName

    /// <summary>
    /// A mnemonic that is no longer in use for this entry.
    /// <see href="http://purl.uniprot.org/core/oldMnemonic"></see></summary>
    let oldMnemonic =
        Namespaced_IRI.parse _namespace_name "oldMnemonic" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/orfName"></see>
    /// </summary>
    let orfName = Namespaced_IRI.parse _namespace_name "orfName" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/otherName"></see>
    /// </summary>
    let otherName = Namespaced_IRI.parse _namespace_name "otherName" |> NamespacedName
    /// <summary>
    /// The first and last page for a chapter or article.
    /// <see href="http://purl.uniprot.org/core/pages"></see></summary>
    let pages = Namespaced_IRI.parse _namespace_name "pages" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/partOf"></see>
    /// </summary>
    let partOf = Namespaced_IRI.parse _namespace_name "partOf" |> NamespacedName

    /// <summary>
    /// True for taxa that can appear as part of an organism's lineage.
    /// <see href="http://purl.uniprot.org/core/partOfLineage"></see></summary>
    let partOfLineage =
        Namespaced_IRI.parse _namespace_name "partOfLineage" |> NamespacedName

    /// <summary>
    /// True if the pattern or profile on which the domain assignment is based did not detect the sequence because the sequence is not complete and lacks the region on which the pattern or profile is based.
    /// <see href="http://purl.uniprot.org/core/partial"></see></summary>
    let partial = Namespaced_IRI.parse _namespace_name "partial" |> NamespacedName

    /// <summary>
    /// A protein that participates in a protein-protein interaction.
    /// <see href="http://purl.uniprot.org/core/participant"></see></summary>
    let participant =
        Namespaced_IRI.parse _namespace_name "participant" |> NamespacedName

    /// <summary>
    /// A URL pattern, used to generate links by substituting an identifier.
    /// <see href="http://purl.uniprot.org/core/pattern"></see></summary>
    let pattern = Namespaced_IRI.parse _namespace_name "pattern" |> NamespacedName
    /// <summary>
    /// The place where a publication was published. This usually includes a country name.
    /// <see href="http://purl.uniprot.org/core/place"></see></summary>
    let place = Namespaced_IRI.parse _namespace_name "place" |> NamespacedName
    /// <summary>
    /// A position on a sequence.
    /// <see href="http://purl.uniprot.org/core/position"></see></summary>
    let position = Namespaced_IRI.parse _namespace_name "position" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/precursor"></see>
    /// </summary>
    let precursor = Namespaced_IRI.parse _namespace_name "precursor" |> NamespacedName
    /// <summary>
    /// The publisher of a book.
    /// <see href="http://purl.uniprot.org/core/publisher"></see></summary>
    let publisher = Namespaced_IRI.parse _namespace_name "publisher" |> NamespacedName
    /// <summary>
    /// A range of amino acids.
    /// <see href="http://purl.uniprot.org/core/range"></see></summary>
    let range = Namespaced_IRI.parse _namespace_name "range" |> NamespacedName
    /// <summary>
    /// The rank of a taxon.
    /// <see href="http://purl.uniprot.org/core/rank"></see></summary>
    let rank = Namespaced_IRI.parse _namespace_name "rank" |> NamespacedName

    /// <summary>
    /// The name recommended by the UniProt consortium.
    /// <see href="http://purl.uniprot.org/core/recommendedName"></see></summary>
    let recommendedName =
        Namespaced_IRI.parse _namespace_name "recommendedName" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/referenceProteome"></see>
    /// </summary>
    let referenceProteome =
        Namespaced_IRI.parse _namespace_name "referenceProteome" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/relatedLocation"></see>
    /// </summary>
    let relatedLocation =
        Namespaced_IRI.parse _namespace_name "relatedLocation" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/representativeFor"></see>
    /// </summary>
    let representativeFor =
        Namespaced_IRI.parse _namespace_name "representativeFor" |> NamespacedName

    /// <summary>
    /// The resolution of an experiment, in Angstrom.
    /// <see href="http://purl.uniprot.org/core/resolution"></see></summary>
    let resolution = Namespaced_IRI.parse _namespace_name "resolution" |> NamespacedName
    /// <summary>
    /// Indicates whether a resource has been reviewed by a curator.
    /// <see href="http://purl.uniprot.org/core/reviewed"></see></summary>
    let reviewed = Namespaced_IRI.parse _namespace_name "reviewed" |> NamespacedName
    /// <summary>
    /// The extent of the work carried out by the authors of a publication.
    /// <see href="http://purl.uniprot.org/core/scope"></see></summary>
    let scope = Namespaced_IRI.parse _namespace_name "scope" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/seedFor"></see>
    /// </summary>
    let seedFor = Namespaced_IRI.parse _namespace_name "seedFor" |> NamespacedName

    /// <summary>
    /// A resource that describes this sequence.
    /// <see href="http://purl.uniprot.org/core/sequenceFor"></see></summary>
    let sequenceFor =
        Namespaced_IRI.parse _namespace_name "sequenceFor" |> NamespacedName

    /// <summary>
    /// An abbreviation of the full name or an acronym.
    /// <see href="http://purl.uniprot.org/core/shortName"></see></summary>
    let shortName = Namespaced_IRI.parse _namespace_name "shortName" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/source"></see>
    /// </summary>
    let source = Namespaced_IRI.parse _namespace_name "source" |> NamespacedName
    /// <summary>
    /// The reliability of a statement.
    /// <see href="http://purl.uniprot.org/core/status"></see></summary>
    let status = Namespaced_IRI.parse _namespace_name "status" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/strain"></see>
    /// </summary>
    let strain = Namespaced_IRI.parse _namespace_name "strain" |> NamespacedName

    /// <summary>
    /// A name provided by the submitter of the underlying nucleotide sequence.
    /// <see href="http://purl.uniprot.org/core/submittedName"></see></summary>
    let submittedName =
        Namespaced_IRI.parse _namespace_name "submittedName" |> NamespacedName

    /// <summary>
    /// A replacement sequence.
    /// <see href="http://purl.uniprot.org/core/substitution"></see></summary>
    let substitution =
        Namespaced_IRI.parse _namespace_name "substitution" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/synonym"></see>
    /// </summary>
    let synonym = Namespaced_IRI.parse _namespace_name "synonym" |> NamespacedName
    /// <summary>
    /// The title of a publication.
    /// <see href="http://purl.uniprot.org/core/title"></see></summary>
    let title = Namespaced_IRI.parse _namespace_name "title" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/transcribedFrom"></see>
    /// </summary>
    let transcribedFrom =
        Namespaced_IRI.parse _namespace_name "transcribedFrom" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/translatedFrom"></see>
    /// </summary>
    let translatedFrom =
        Namespaced_IRI.parse _namespace_name "translatedFrom" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/translatedTo"></see>
    /// </summary>
    let translatedTo =
        Namespaced_IRI.parse _namespace_name "translatedTo" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/version"></see>
    /// </summary>
    let version = Namespaced_IRI.parse _namespace_name "version" |> NamespacedName
    /// <summary>
    /// The volume a publication is part of.
    /// <see href="http://purl.uniprot.org/core/volume"></see></summary>
    let volume = Namespaced_IRI.parse _namespace_name "volume" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/width"></see>
    /// </summary>
    let width = Namespaced_IRI.parse _namespace_name "width" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.uniprot.org/core/xeno"></see>
    /// </summary>
    let xeno = Namespaced_IRI.parse _namespace_name "xeno" |> NamespacedName
