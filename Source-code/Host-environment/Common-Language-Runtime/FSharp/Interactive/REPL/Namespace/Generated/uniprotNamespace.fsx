#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module uniprot =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://purl.uniprot.org/core/" "uniprot"

    let _namespaceIri = _prefixId.prefix ""
    let API = _prefixId.prefix "API"
    /// <summary>
    ///   <para>rdfs:comment : Indicates the wavelength in nm at which photoreactive proteins such as opsins and DNA photolyases show maximal absorption.^^xsd:string</para>
    ///   <para>rdfs:label : Absorption^^xsd:string</para>
    ///   <a href="http://purl.uniprot.org/core/Absorption_Annotation">uniprot:Absorption_Annotation</a>
    /// </summary>
    let Absorption_Annotation = _prefixId.prefix "Absorption_Annotation"
    /// <summary>
    ///   <para>rdfs:seeAlso : http://www.uniprot.org/manual/act_site^^xsd:anyURI</para>
    ///   <para>rdfs:comment : Amino acid(s) involved in the activity of an enzyme.^^xsd:string</para>
    ///   <para>rdfs:label : Active Site^^xsd:string</para>
    ///   <a href="http://purl.uniprot.org/core/Active_Site_Annotation">uniprot:Active_Site_Annotation</a>
    /// </summary>
    let Active_Site_Annotation = _prefixId.prefix "Active_Site_Annotation"
    /// <summary>
    ///   <para>rdfs:seeAlso : http://www.uniprot.org/manual/allergenic_properties^^xsd:anyURI</para>
    ///   <para>rdfs:comment : Information relevant to allergenic proteins.^^xsd:string</para>
    ///   <para>rdfs:label : Allergen^^xsd:string</para>
    ///   <a href="http://purl.uniprot.org/core/Allergen_Annotation">uniprot:Allergen_Annotation</a>
    /// </summary>
    let Allergen_Annotation = _prefixId.prefix "Allergen_Annotation"

    /// <summary>
    ///   <para>rdfs:label : Alternative Initiation^^xsd:string</para>
    ///   <a href="http://purl.uniprot.org/core/Alternative_Initiation_Annotation">uniprot:Alternative_Initiation_Annotation</a>
    /// </summary>
    let Alternative_Initiation_Annotation =
        _prefixId.prefix "Alternative_Initiation_Annotation"

    /// <summary>
    ///   <para>rdfs:seeAlso : http://www.uniprot.org/manual/alternative_products^^xsd:anyURI</para>
    ///   <para>rdfs:comment : Description of the existence of related protein sequences produced by alternative splicing of the same gene or by the use of alternative initiation codons.^^xsd:string</para>
    ///   <para>rdfs:label : Alternative Products^^xsd:string</para>
    ///   <a href="http://purl.uniprot.org/core/Alternative_Products_Annotation">uniprot:Alternative_Products_Annotation</a>
    /// </summary>
    let Alternative_Products_Annotation =
        _prefixId.prefix "Alternative_Products_Annotation"

    /// <summary>
    ///   <para>rdfs:label : Alternative Promoter Usage^^xsd:string</para>
    ///   <a href="http://purl.uniprot.org/core/Alternative_Promoter_Usage_Annotation">uniprot:Alternative_Promoter_Usage_Annotation</a>
    /// </summary>
    let Alternative_Promoter_Usage_Annotation =
        _prefixId.prefix "Alternative_Promoter_Usage_Annotation"

    /// <summary>
    ///   <para>rdfs:seeAlso : http://www.uniprot.org/manual/var_seq^^xsd:anyURI</para>
    ///   <para>rdfs:comment : Description of sequence variants produced by alternative splicing.^^xsd:string</para>
    ///   <para>rdfs:label : Splice Variant^^xsd:string</para>
    ///   <a href="http://purl.uniprot.org/core/Alternative_Sequence_Annotation">uniprot:Alternative_Sequence_Annotation</a>
    /// </summary>
    let Alternative_Sequence_Annotation =
        _prefixId.prefix "Alternative_Sequence_Annotation"

    /// <summary>
    ///   <para>rdfs:label : Alternative Splicing^^xsd:string</para>
    ///   <a href="http://purl.uniprot.org/core/Alternative_Splicing_Annotation">uniprot:Alternative_Splicing_Annotation</a>
    /// </summary>
    let Alternative_Splicing_Annotation =
        _prefixId.prefix "Alternative_Splicing_Annotation"

    /// <summary>
    ///   <para>rdfs:comment : Description of a resource on a specific topic.^^xsd:string</para>
    ///   <a href="http://purl.uniprot.org/core/Annotation">uniprot:Annotation</a>
    /// </summary>
    let Annotation = _prefixId.prefix "Annotation"
    let Apicoplast = _prefixId.prefix "Apicoplast"
    /// <summary>
    ///   <para>rdfs:comment : Entity used to attach evidence or provenance to a rdf statement via reification.</para>
    ///   <a href="http://purl.uniprot.org/core/Attribution">uniprot:Attribution</a>
    /// </summary>
    let Attribution = _prefixId.prefix "Attribution"
    /// <summary>
    ///   <para>rdfs:seeAlso : http://www.uniprot.org/manual/strand^^xsd:anyURI</para>
    ///   <para>rdfs:comment : Beta strand regions within the experimentally determined protein structure^^xsd:string</para>
    ///   <para>rdfs:label : Strand^^xsd:string</para>
    ///   <a href="http://purl.uniprot.org/core/Beta_Strand_Annotation">uniprot:Beta_Strand_Annotation</a>
    /// </summary>
    let Beta_Strand_Annotation = _prefixId.prefix "Beta_Strand_Annotation"
    /// <summary>
    ///   <para>rdfs:seeAlso : http://www.uniprot.org/manual/binding^^xsd:anyURI</para>
    ///   <para>rdfs:comment : Binding site for any chemical group (co-enzyme, prosthetic group, etc.).^^xsd:string</para>
    ///   <para>rdfs:label : Binding Site^^xsd:string</para>
    ///   <a href="http://purl.uniprot.org/core/Binding_Site_Annotation">uniprot:Binding_Site_Annotation</a>
    /// </summary>
    let Binding_Site_Annotation = _prefixId.prefix "Binding_Site_Annotation"
    /// <summary>
    ///   <para>rdfs:seeAlso : http://purl.uniprot.org/core/biophysicochemical_properties^^xsd:anyURI</para>
    ///   <para>rdfs:comment : Biophysical and physicochemical data such as pH dependence, temperature dependence, kinetic parameters, redox potentials, and maximal absorption.^^xsd:string</para>
    ///   <para>rdfs:label : Biophysicochemical Property^^xsd:string</para>
    ///   <a href="http://purl.uniprot.org/core/Biophysicochemical_Annotation">uniprot:Biophysicochemical_Annotation</a>
    /// </summary>
    let Biophysicochemical_Annotation = _prefixId.prefix "Biophysicochemical_Annotation"
    /// <summary>
    ///   <para>rdfs:seeAlso : http://www.uniprot.org/manual/biotechnological_use^^xsd:anyURI</para>
    ///   <para>rdfs:comment : Description of the use of a specific protein in a biotechnological process.^^xsd:string</para>
    ///   <para>rdfs:label : Biotechnology^^xsd:string</para>
    ///   <a href="http://purl.uniprot.org/core/Biotechnology_Annotation">uniprot:Biotechnology_Annotation</a>
    /// </summary>
    let Biotechnology_Annotation = _prefixId.prefix "Biotechnology_Annotation"
    /// <summary>
    ///   <para>rdfs:comment : A chapter from a book.^^xsd:string</para>
    ///   <para>rdfs:label : Book Citation^^xsd:string</para>
    ///   <a href="http://purl.uniprot.org/core/Book_Citation">uniprot:Book_Citation</a>
    /// </summary>
    let Book_Citation = _prefixId.prefix "Book_Citation"
    let By_Similarity = _prefixId.prefix "By_Similarity"
    /// <summary>
    ///   <para>rdfs:seeAlso : http://www.uniprot.org/manual/ca_bind^^xsd:anyURI</para>
    ///   <para>rdfs:comment : Extent of a calcium-binding region.^^xsd:string</para>
    ///   <para>rdfs:label : Calcium Binding^^xsd:string</para>
    ///   <a href="http://purl.uniprot.org/core/Calcium_Binding_Annotation">uniprot:Calcium_Binding_Annotation</a>
    /// </summary>
    let Calcium_Binding_Annotation = _prefixId.prefix "Calcium_Binding_Annotation"
    /// <summary>
    ///   <para>rdfs:seeAlso : http://www.uniprot.org/manual/catalytic_activity^^xsd:anyURI</para>
    ///   <para>rdfs:comment : Description of the reactions catalyzed by an enzyme.^^xsd:string</para>
    ///   <para>rdfs:label : Catalytic Activity^^xsd:string</para>
    ///   <a href="http://purl.uniprot.org/core/Catalytic_Activity_Annotation">uniprot:Catalytic_Activity_Annotation</a>
    /// </summary>
    let Catalytic_Activity_Annotation = _prefixId.prefix "Catalytic_Activity_Annotation"
    /// <summary>
    ///   <para>rdfs:seeAlso : http://www.uniprot.org/manual/caution^^xsd:anyURI</para>
    ///   <para>rdfs:comment : Warning about possible errors and/or grounds for confusion.^^xsd:string</para>
    ///   <para>rdfs:label : Caution^^xsd:string</para>
    ///   <a href="http://purl.uniprot.org/core/Caution_Annotation">uniprot:Caution_Annotation</a>
    /// </summary>
    let Caution_Annotation = _prefixId.prefix "Caution_Annotation"
    /// <summary>
    ///   <para>rdfs:label : Cellular Component^^xsd:string</para>
    ///   <a href="http://purl.uniprot.org/core/Cellular_Component">uniprot:Cellular_Component</a>
    /// </summary>
    let Cellular_Component = _prefixId.prefix "Cellular_Component"
    /// <summary>
    ///   <para>rdfs:seeAlso : http://www.uniprot.org/manual/chain^^xsd:anyURI</para>
    ///   <para>rdfs:comment : Extent of a polypeptide chain in the mature protein.^^xsd:string</para>
    ///   <para>rdfs:label : Chain^^xsd:string</para>
    ///   <a href="http://purl.uniprot.org/core/Chain_Annotation">uniprot:Chain_Annotation</a>
    /// </summary>
    let Chain_Annotation = _prefixId.prefix "Chain_Annotation"
    let Chloroplast = _prefixId.prefix "Chloroplast"
    /// <summary>
    ///   <para>rdfs:seeAlso : http://www.uniprot.org/manual/references^^xsd:anyURI</para>
    ///   <para>rdfs:comment : Description of a publication from which data was obtained.^^xsd:string</para>
    ///   <a href="http://purl.uniprot.org/core/Citation">uniprot:Citation</a>
    /// </summary>
    let Citation = _prefixId.prefix "Citation"
    /// <summary>
    ///   <para>rdfs:comment : The relationship between a resource and a citation.^^xsd:string</para>
    ///   <para>rdfs:label : Citation Statement^^xsd:string</para>
    ///   <a href="http://purl.uniprot.org/core/Citation_Statement">uniprot:Citation_Statement</a>
    /// </summary>
    let Citation_Statement = _prefixId.prefix "Citation_Statement"
    let Class = _prefixId.prefix "Class"
    /// <summary>
    ///   <para>rdfs:seeAlso : http://www.uniprot.org/uniref/^^xsd:anyURI</para>
    ///   <para>rdfs:comment : Cluster of proteins with similar sequences.^^xsd:string</para>
    ///   <a href="http://purl.uniprot.org/core/Cluster">uniprot:Cluster</a>
    /// </summary>
    let Cluster = _prefixId.prefix "Cluster"
    /// <summary>
    ///   <para>rdfs:seeAlso : http://www.uniprot.org/manual/cofactor^^xsd:anyURI</para>
    ///   <para>rdfs:comment : Description of an enzyme cofactor.^^xsd:string</para>
    ///   <para>rdfs:label : Cofactor^^xsd:string</para>
    ///   <a href="http://purl.uniprot.org/core/Cofactor_Annotation">uniprot:Cofactor_Annotation</a>
    /// </summary>
    let Cofactor_Annotation = _prefixId.prefix "Cofactor_Annotation"
    /// <summary>
    ///   <para>rdfs:seeAlso : http://www.uniprot.org/manual/coiled^^xsd:anyURI</para>
    ///   <para>rdfs:comment : Extent of a coiled-coil region.^^xsd:string</para>
    ///   <para>rdfs:label : Coiled-Coil^^xsd:string</para>
    ///   <a href="http://purl.uniprot.org/core/Coiled_Coil_Annotation">uniprot:Coiled_Coil_Annotation</a>
    /// </summary>
    let Coiled_Coil_Annotation = _prefixId.prefix "Coiled_Coil_Annotation"
    /// <summary>
    ///   <para>rdfs:seeAlso : http://www.uniprot.org/manual/compbias^^xsd:anyURI</para>
    ///   <para>rdfs:comment : Extent of a compositionally biased region.^^xsd:string</para>
    ///   <para>rdfs:label : Compositionally Biased Region^^xsd:string</para>
    ///   <a href="http://purl.uniprot.org/core/Compositional_Bias_Annotation">uniprot:Compositional_Bias_Annotation</a>
    /// </summary>
    let Compositional_Bias_Annotation = _prefixId.prefix "Compositional_Bias_Annotation"
    /// <summary>
    ///   <para>rdfs:comment : A concept used to classify resources.^^xsd:string</para>
    ///   <para>rdfs:label : Concept^^xsd:string</para>
    ///   <a href="http://purl.uniprot.org/core/Concept">uniprot:Concept</a>
    /// </summary>
    let Concept = _prefixId.prefix "Concept"
    /// <summary>
    ///   <para>rdfs:seeAlso : http://www.uniprot.org/manual/crosslnk^^xsd:anyURI</para>
    ///   <para>rdfs:comment : Posttranslationally formed amino acid bonds.^^xsd:string</para>
    ///   <para>rdfs:label : Crosslink^^xsd:string</para>
    ///   <a href="http://purl.uniprot.org/core/Cross-link_Annotation">uniprot:Cross-link_Annotation</a>
    /// </summary>
    let Cross_link_Annotation = _prefixId.prefix "Cross-link_Annotation"
    let Cyanelle = _prefixId.prefix "Cyanelle"
    let DNA = _prefixId.prefix "DNA"
    /// <summary>
    ///   <para>rdfs:seeAlso : http://www.uniprot.org/manual/cross_references^^xsd:anyURI</para>
    ///   <para>rdfs:comment : Metadata for a life science database.^^xsd:string</para>
    ///   <a href="http://purl.uniprot.org/core/Database">uniprot:Database</a>
    /// </summary>
    let Database = _prefixId.prefix "Database"

    /// <summary>
    ///   <para>rdfs:seeAlso : http://www.uniprot.org/manual/developmental_stage^^xsd:anyURI</para>
    ///   <para>rdfs:comment : Description of the developmentally-specific expression of a protein.^^xsd:string</para>
    ///   <para>rdfs:label : Developmental Stage^^xsd:string</para>
    ///   <a href="http://purl.uniprot.org/core/Developmental_Stage_Annotation">uniprot:Developmental_Stage_Annotation</a>
    /// </summary>
    let Developmental_Stage_Annotation =
        _prefixId.prefix "Developmental_Stage_Annotation"

    /// <summary>
    ///   <para>rdfs:seeAlso : http://www.uniprot.org/manual/involvement_in_disease^^xsd:anyURI</para>
    ///   <para>rdfs:comment : Description of the diseases associated with a deficiency of a protein.^^xsd:string</para>
    ///   <para>rdfs:label : Disease^^xsd:string</para>
    ///   <a href="http://purl.uniprot.org/core/Disease_Annotation">uniprot:Disease_Annotation</a>
    /// </summary>
    let Disease_Annotation = _prefixId.prefix "Disease_Annotation"

    /// <summary>
    ///   <para>rdfs:seeAlso : http://www.uniprot.org/manual/disruption_phenotype^^xsd:anyURI</para>
    ///   <para>rdfs:label : Disruption Phenotype^^xsd:string</para>
    ///   <a href="http://purl.uniprot.org/core/Disruption_Phenotype_Annotation">uniprot:Disruption_Phenotype_Annotation</a>
    /// </summary>
    let Disruption_Phenotype_Annotation =
        _prefixId.prefix "Disruption_Phenotype_Annotation"

    /// <summary>
    ///   <para>rdfs:seeAlso : http://www.uniprot.org/manual/disulfid^^xsd:anyURI</para>
    ///   <para>rdfs:comment : Describes residues which are linked by an intra-chain disulfide bond. If the endpoints are identical, the disulfide bond is an interchain one.^^xsd:string</para>
    ///   <para>rdfs:label : Disulfide Bond^^xsd:string</para>
    ///   <a href="http://purl.uniprot.org/core/Disulfide_Bond_Annotation">uniprot:Disulfide_Bond_Annotation</a>
    /// </summary>
    let Disulfide_Bond_Annotation = _prefixId.prefix "Disulfide_Bond_Annotation"
    /// <summary>
    ///   <para>rdfs:seeAlso : http://www.uniprot.org/manual/domain_cc^^xsd:anyURI</para>
    ///   <para>rdfs:comment : Description of the domain structure of a protein.^^xsd:string</para>
    ///   <para>rdfs:label : Domain^^xsd:string</para>
    ///   <a href="http://purl.uniprot.org/core/Domain_Annotation">uniprot:Domain_Annotation</a>
    /// </summary>
    let Domain_Annotation = _prefixId.prefix "Domain_Annotation"
    /// <summary>
    ///   <para>rdfs:comment : The relationship between a protein and a protein domain.^^xsd:string</para>
    ///   <para>rdfs:label : Domain Assignment Statement^^xsd:string</para>
    ///   <a href="http://purl.uniprot.org/core/Domain_Assignment_Statement">uniprot:Domain_Assignment_Statement</a>
    /// </summary>
    let Domain_Assignment_Statement = _prefixId.prefix "Domain_Assignment_Statement"
    /// <summary>
    ///   <para>rdfs:seeAlso : http://www.uniprot.org/manual/domain^^xsd:anyURI</para>
    ///   <para>rdfs:comment : Extent of a domain, which is defined as a specific combination of secondary structures organized into a characteristic three-dimensional structure or fold.^^xsd:string</para>
    ///   <para>rdfs:label : Domain Extent^^xsd:string</para>
    ///   <a href="http://purl.uniprot.org/core/Domain_Extent_Annotation">uniprot:Domain_Extent_Annotation</a>
    /// </summary>
    let Domain_Extent_Annotation = _prefixId.prefix "Domain_Extent_Annotation"
    let ESI = _prefixId.prefix "ESI"
    let Electron_Microscopy = _prefixId.prefix "Electron_Microscopy"
    /// <summary>
    ///   <para>rdfs:comment : An electronic publication.^^xsd:string</para>
    ///   <para>rdfs:label : Electronic Citation^^xsd:string</para>
    ///   <a href="http://purl.uniprot.org/core/Electronic_Citation">uniprot:Electronic_Citation</a>
    /// </summary>
    let Electronic_Citation = _prefixId.prefix "Electronic_Citation"
    /// <summary>
    ///   <para>rdfs:comment : Metadata for an endpoint of a range on a sequence.^^xsd:string</para>
    ///   <para>rdfs:label : Endpoint Statement^^xsd:string</para>
    ///   <a href="http://purl.uniprot.org/core/Endpoint_Statement">uniprot:Endpoint_Statement</a>
    /// </summary>
    let Endpoint_Statement = _prefixId.prefix "Endpoint_Statement"
    /// <summary>
    ///   <para>rdfs:seeAlso : http://www.expasy.org/enzyme/^^xsd:anyURI</para>
    ///   <para>rdfs:comment : A specific catalytic activity, defined by the Enzyme Commission of the Nomenclature Committee of the International Union of Biochemistry and Molecular Biology (IUBMB).^^xsd:string</para>
    ///   <para>rdfs:label : Enzyme^^xsd:string</para>
    ///   <a href="http://purl.uniprot.org/core/Enzyme">uniprot:Enzyme</a>
    /// </summary>
    let Enzyme = _prefixId.prefix "Enzyme"
    /// <summary>
    ///   <para>rdfs:seeAlso : http://www.uniprot.org/manual/enzyme_regulation^^xsd:anyURI</para>
    ///   <para>rdfs:comment : Description of an enzyme regulatory mechanism.^^xsd:string</para>
    ///   <para>rdfs:label : Enzyme Regulation^^xsd:string</para>
    ///   <a href="http://purl.uniprot.org/core/Enzyme_Regulation_Annotation">uniprot:Enzyme_Regulation_Annotation</a>
    /// </summary>
    let Enzyme_Regulation_Annotation = _prefixId.prefix "Enzyme_Regulation_Annotation"

    /// <summary>
    ///   <para>rdfs:label : Erroneous Gene Model Prediction^^xsd:string</para>
    ///   <a href="http://purl.uniprot.org/core/Erroneous_Gene_Model_Prediction_Annotation">uniprot:Erroneous_Gene_Model_Prediction_Annotation</a>
    /// </summary>
    let Erroneous_Gene_Model_Prediction_Annotation =
        _prefixId.prefix "Erroneous_Gene_Model_Prediction_Annotation"

    /// <summary>
    ///   <para>rdfs:label : Erroneous Initiation^^xsd:string</para>
    ///   <a href="http://purl.uniprot.org/core/Erroneous_Initiation_Annotation">uniprot:Erroneous_Initiation_Annotation</a>
    /// </summary>
    let Erroneous_Initiation_Annotation =
        _prefixId.prefix "Erroneous_Initiation_Annotation"

    /// <summary>
    ///   <para>rdfs:label : Erroneous Termination^^xsd:string</para>
    ///   <a href="http://purl.uniprot.org/core/Erroneous_Termination_Annotation">uniprot:Erroneous_Termination_Annotation</a>
    /// </summary>
    let Erroneous_Termination_Annotation =
        _prefixId.prefix "Erroneous_Termination_Annotation"

    /// <summary>
    ///   <para>rdfs:label : Erroneous Translation^^xsd:string</para>
    ///   <a href="http://purl.uniprot.org/core/Erroneous_Translation_Annotation">uniprot:Erroneous_Translation_Annotation</a>
    /// </summary>
    let Erroneous_Translation_Annotation =
        _prefixId.prefix "Erroneous_Translation_Annotation"

    let Evidence_at_Protein_Level_Existence =
        _prefixId.prefix "Evidence_at_Protein_Level_Existence"

    let Evidence_at_Transcript_Level_Existence =
        _prefixId.prefix "Evidence_at_Transcript_Level_Existence"

    let Experimental = _prefixId.prefix "Experimental"

    /// <summary>
    ///   <para>rdfs:label : Experimental Information^^xsd:string</para>
    ///   <a href="http://purl.uniprot.org/core/Experimental_Information_Annotation">uniprot:Experimental_Information_Annotation</a>
    /// </summary>
    let Experimental_Information_Annotation =
        _prefixId.prefix "Experimental_Information_Annotation"

    /// <summary>
    ///   <para>rdfs:seeAlso : http://www.uniprot.org/manual/alternative_products^^xsd:anyURI</para>
    ///   <para>rdfs:comment : The protein described in the linked record is an alternative splice form of the same gene product as described in this record. The function between the two isoforms is highly divergent.^^xsd:string</para>
    ///   <para>rdfs:label : External Sequence^^xsd:string</para>
    ///   <a href="http://purl.uniprot.org/core/External_Sequence">uniprot:External_Sequence</a>
    /// </summary>
    let External_Sequence = _prefixId.prefix "External_Sequence"
    let FAB = _prefixId.prefix "FAB"
    let Family = _prefixId.prefix "Family"
    /// <summary>
    ///   <para>rdfs:comment : The relationship between a protein and a protein family.^^xsd:string</para>
    ///   <para>rdfs:label : Family Membership Statement^^xsd:string</para>
    ///   <a href="http://purl.uniprot.org/core/Family_Membership_Statement">uniprot:Family_Membership_Statement</a>
    /// </summary>
    let Family_Membership_Statement = _prefixId.prefix "Family_Membership_Statement"
    let Fiber_Diffraction = _prefixId.prefix "Fiber_Diffraction"
    let Forma = _prefixId.prefix "Forma"
    /// <summary>
    ///   <para>rdfs:label : Frameshift^^xsd:string</para>
    ///   <a href="http://purl.uniprot.org/core/Frameshift_Annotation">uniprot:Frameshift_Annotation</a>
    /// </summary>
    let Frameshift_Annotation = _prefixId.prefix "Frameshift_Annotation"
    /// <summary>
    ///   <para>rdfs:seeAlso : http://www.uniprot.org/manual/function^^xsd:anyURI</para>
    ///   <para>rdfs:comment : General description of the functions of a protein.^^xsd:string</para>
    ///   <para>rdfs:label : Function^^xsd:string</para>
    ///   <a href="http://purl.uniprot.org/core/Function_Annotation">uniprot:Function_Annotation</a>
    /// </summary>
    let Function_Annotation = _prefixId.prefix "Function_Annotation"
    let Gene = _prefixId.prefix "Gene"
    /// <summary>
    ///   <para>rdfs:label : Genomic DNA^^xsd:string</para>
    ///   <a href="http://purl.uniprot.org/core/Genomic_DNA">uniprot:Genomic_DNA</a>
    /// </summary>
    let Genomic_DNA = _prefixId.prefix "Genomic_DNA"
    /// <summary>
    ///   <para>rdfs:label : Genomic RNA^^xsd:string</para>
    ///   <a href="http://purl.uniprot.org/core/Genomic_RNA">uniprot:Genomic_RNA</a>
    /// </summary>
    let Genomic_RNA = _prefixId.prefix "Genomic_RNA"
    let Genus = _prefixId.prefix "Genus"
    /// <summary>
    ///   <para>rdfs:seeAlso : http://www.uniprot.org/manual/carbohyd^^xsd:anyURI</para>
    ///   <para>rdfs:comment : Describes the occurrence of the attachment of a glycan (mono- or polysaccharide) to a residue of a protein.^^xsd:string</para>
    ///   <para>rdfs:label : Glycosylation Site^^xsd:string</para>
    ///   <a href="http://purl.uniprot.org/core/Glycosylation_Annotation">uniprot:Glycosylation_Annotation</a>
    /// </summary>
    let Glycosylation_Annotation = _prefixId.prefix "Glycosylation_Annotation"
    /// <summary>
    ///   <para>rdfs:seeAlso : http://www.uniprot.org/manual/helix^^xsd:anyURI</para>
    ///   <para>rdfs:comment : Helical regions within the experimentally determined protein structure^^xsd:string</para>
    ///   <para>rdfs:label : Helix^^xsd:string</para>
    ///   <a href="http://purl.uniprot.org/core/Helix_Annotation">uniprot:Helix_Annotation</a>
    /// </summary>
    let Helix_Annotation = _prefixId.prefix "Helix_Annotation"
    let Hydrogenosome = _prefixId.prefix "Hydrogenosome"
    /// <summary>
    ///   <para>rdfs:seeAlso : http://www.uniprot.org/manual/induction^^xsd:anyURI</para>
    ///   <para>rdfs:comment : Description of the compounds or conditions that stimulate the synthesis of a protein.^^xsd:string</para>
    ///   <para>rdfs:label : Induction^^xsd:string</para>
    ///   <a href="http://purl.uniprot.org/core/Induction_Annotation">uniprot:Induction_Annotation</a>
    /// </summary>
    let Induction_Annotation = _prefixId.prefix "Induction_Annotation"

    let Inferred_from_Homology_Existence =
        _prefixId.prefix "Inferred_from_Homology_Existence"

    let Infraclass = _prefixId.prefix "Infraclass"
    let Infraorder = _prefixId.prefix "Infraorder"
    let Infrared_Spectroscopy = _prefixId.prefix "Infrared_Spectroscopy"

    /// <summary>
    ///   <para>rdfs:seeAlso : http://www.uniprot.org/manual/init_met^^xsd:anyURI</para>
    ///   <para>rdfs:comment : Indicates that the initiator methionine has been cleaved off and is not shown in the sequence.^^xsd:string</para>
    ///   <para>rdfs:label : Initiator Methionine^^xsd:string</para>
    ///   <a href="http://purl.uniprot.org/core/Initiator_Methionine_Annotation">uniprot:Initiator_Methionine_Annotation</a>
    /// </summary>
    let Initiator_Methionine_Annotation =
        _prefixId.prefix "Initiator_Methionine_Annotation"

    /// <summary>
    ///   <para>rdfs:seeAlso : http://www.uniprot.org/manual/binary_interactions^^xsd:anyURI</para>
    ///   <para>rdfs:comment : Description of a protein-protein interaction.^^xsd:string</para>
    ///   <a href="http://purl.uniprot.org/core/Interaction">uniprot:Interaction</a>
    /// </summary>
    let Interaction = _prefixId.prefix "Interaction"
    /// <summary>
    ///   <para>rdfs:seeAlso : http://www.uniprot.org/manual/Intramembrane^^xsd:anyURI</para>
    ///   <para>rdfs:comment : Extent of a region located in a membrane without crossing it^^xsd:string</para>
    ///   <para>rdfs:label : INTRAMEM^^xsd:string</para>
    ///   <a href="http://purl.uniprot.org/core/Intramembrane_Annotation">uniprot:Intramembrane_Annotation</a>
    /// </summary>
    let Intramembrane_Annotation = _prefixId.prefix "Intramembrane_Annotation"
    /// <summary>
    ///   <para>rdfs:comment : An article published in a journal.^^xsd:string</para>
    ///   <para>rdfs:label : Journal Citation^^xsd:string</para>
    ///   <a href="http://purl.uniprot.org/core/Journal_Citation">uniprot:Journal_Citation</a>
    /// </summary>
    let Journal_Citation = _prefixId.prefix "Journal_Citation"
    /// <summary>
    ///   <para>rdfs:comment : Mentions the Michaelis-Menten constant (KM) and maximal velocity (Vmax) of enzymes.^^xsd:string</para>
    ///   <para>rdfs:label : Kinetics^^xsd:string</para>
    ///   <a href="http://purl.uniprot.org/core/Kinetics_Annotation">uniprot:Kinetics_Annotation</a>
    /// </summary>
    let Kinetics_Annotation = _prefixId.prefix "Kinetics_Annotation"
    let Kingdom = _prefixId.prefix "Kingdom"
    /// <summary>
    ///   <para>rdfs:seeAlso : http://www.uniprot.org/manual/sequences^^xsd:anyURI</para>
    ///   <para>rdfs:label : Known Sequence^^xsd:string</para>
    ///   <a href="http://purl.uniprot.org/core/Known_Sequence">uniprot:Known_Sequence</a>
    /// </summary>
    let Known_Sequence = _prefixId.prefix "Known_Sequence"
    let LSIMS = _prefixId.prefix "LSIMS"
    /// <summary>
    ///   <para>rdfs:seeAlso : http://www.uniprot.org/manual/lipid^^xsd:anyURI</para>
    ///   <para>rdfs:comment : Covalent binding of a lipid moiety.^^xsd:string</para>
    ///   <para>rdfs:label : Lipid Binding^^xsd:string</para>
    ///   <a href="http://purl.uniprot.org/core/Lipidation_Annotation">uniprot:Lipidation_Annotation</a>
    /// </summary>
    let Lipidation_Annotation = _prefixId.prefix "Lipidation_Annotation"
    let MALDI = _prefixId.prefix "MALDI"
    /// <summary>
    ///   <para>rdfs:label : mRNA^^xsd:string</para>
    ///   <a href="http://purl.uniprot.org/core/MRNA">uniprot:MRNA</a>
    /// </summary>
    let MRNA = _prefixId.prefix "MRNA"
    /// <summary>
    ///   <para>rdfs:seeAlso : iki:Mass_spectrometry^^xsd:anyURI</para>
    ///   <para>rdfs:comment : An experimental method for measuring the mass of a molecule.^^xsd:string</para>
    ///   <para>rdfs:label : Mass Measurement^^xsd:string</para>
    ///   <a href="http://purl.uniprot.org/core/Mass_Measurement_Method">uniprot:Mass_Measurement_Method</a>
    /// </summary>
    let Mass_Measurement_Method = _prefixId.prefix "Mass_Measurement_Method"
    /// <summary>
    ///   <para>rdfs:seeAlso : http://www.uniprot.org/manual/mass_spectrometry^^xsd:anyURI</para>
    ///   <para>rdfs:comment : Indicates the mass of a sequence determined by mass spectrometry.^^xsd:string</para>
    ///   <para>rdfs:label : Mass^^xsd:string</para>
    ///   <a href="http://purl.uniprot.org/core/Mass_Spectrometry_Annotation">uniprot:Mass_Spectrometry_Annotation</a>
    /// </summary>
    let Mass_Spectrometry_Annotation = _prefixId.prefix "Mass_Spectrometry_Annotation"
    /// <summary>
    ///   <para>rdfs:seeAlso : http://www.uniprot.org/manual/metal^^xsd:anyURI</para>
    ///   <para>rdfs:comment : Binding site for a metal ion.^^xsd:string</para>
    ///   <para>rdfs:label : Metal Ion Binding Site^^xsd:string</para>
    ///   <a href="http://purl.uniprot.org/core/Metal_Binding_Annotation">uniprot:Metal_Binding_Annotation</a>
    /// </summary>
    let Metal_Binding_Annotation = _prefixId.prefix "Metal_Binding_Annotation"
    /// <summary>
    ///   <para>rdfs:comment : An experimental method.^^xsd:string</para>
    ///   <a href="http://purl.uniprot.org/core/Method">uniprot:Method</a>
    /// </summary>
    let Method = _prefixId.prefix "Method"
    let Mitochondrion = _prefixId.prefix "Mitochondrion"
    /// <summary>
    ///   <para>rdfs:comment : Describes amino acid modifications, post pre- and post-translational.^^xsd:string</para>
    ///   <para>rdfs:label : Modification^^xsd:string</para>
    ///   <a href="http://purl.uniprot.org/core/Modification_Annotation">uniprot:Modification_Annotation</a>
    /// </summary>
    let Modification_Annotation = _prefixId.prefix "Modification_Annotation"
    /// <summary>
    ///   <para>rdfs:seeAlso : http://www.uniprot.org/manual/mod_res^^xsd:anyURI</para>
    ///   <para>rdfs:comment : Posttranslational modification of a residue.^^xsd:string</para>
    ///   <para>rdfs:label : Modified Residue^^xsd:string</para>
    ///   <a href="http://purl.uniprot.org/core/Modified_Residue_Annotation">uniprot:Modified_Residue_Annotation</a>
    /// </summary>
    let Modified_Residue_Annotation = _prefixId.prefix "Modified_Residue_Annotation"
    /// <summary>
    ///   <para>rdfs:label : Modified Sequence^^xsd:string</para>
    ///   <a href="http://purl.uniprot.org/core/Modified_Sequence">uniprot:Modified_Sequence</a>
    /// </summary>
    let Modified_Sequence = _prefixId.prefix "Modified_Sequence"
    /// <summary>
    ///   <para>rdfs:comment : A biological molecule.^^xsd:string</para>
    ///   <a href="http://purl.uniprot.org/core/Molecule">uniprot:Molecule</a>
    /// </summary>
    let Molecule = _prefixId.prefix "Molecule"

    /// <summary>
    ///   <para>rdfs:label : Molecule Processing^^xsd:string</para>
    ///   <a href="http://purl.uniprot.org/core/Molecule_Processing_Annotation">uniprot:Molecule_Processing_Annotation</a>
    /// </summary>
    let Molecule_Processing_Annotation =
        _prefixId.prefix "Molecule_Processing_Annotation"

    /// <summary>
    ///   <para>rdfs:seeAlso : http://www.uniprot.org/manual/motif^^xsd:anyURI</para>
    ///   <para>rdfs:comment : Short (&lt;=20 amino acids) sequence motif of biological interest.^^xsd:string</para>
    ///   <para>rdfs:label : Motif^^xsd:string</para>
    ///   <a href="http://purl.uniprot.org/core/Motif_Annotation">uniprot:Motif_Annotation</a>
    /// </summary>
    let Motif_Annotation = _prefixId.prefix "Motif_Annotation"
    /// <summary>
    ///   <para>rdfs:seeAlso : http://www.uniprot.org/manual/mutagen^^xsd:anyURI</para>
    ///   <para>rdfs:comment : Site which has been experimentally altered.^^xsd:string</para>
    ///   <para>rdfs:label : Mutagenesis Site^^xsd:string</para>
    ///   <a href="http://purl.uniprot.org/core/Mutagenesis_Annotation">uniprot:Mutagenesis_Annotation</a>
    /// </summary>
    let Mutagenesis_Annotation = _prefixId.prefix "Mutagenesis_Annotation"
    let NMR_Spectroscopy = _prefixId.prefix "NMR_Spectroscopy"
    /// <summary>
    ///   <para>rdfs:seeAlso : http://www.uniprot.org/manual/dna_bind^^xsd:anyURI</para>
    ///   <para>rdfs:comment : Extent of a nucleotide phosphate-binding region.^^xsd:string</para>
    ///   <para>rdfs:label : Nucleotide Phosphate Binding^^xsd:string</para>
    ///   <a href="http://purl.uniprot.org/core/NP_Binding_Annotation">uniprot:NP_Binding_Annotation</a>
    /// </summary>
    let NP_Binding_Annotation = _prefixId.prefix "NP_Binding_Annotation"
    /// <summary>
    ///   <para>rdfs:seeAlso : http://www.uniprot.org/manual/variant^^xsd:anyURI</para>
    ///   <para>rdfs:comment : Authors report that sequence variants exist.^^xsd:string</para>
    ///   <para>rdfs:label : Sequence Variant^^xsd:string</para>
    ///   <a href="http://purl.uniprot.org/core/Natural_Variant_Annotation">uniprot:Natural_Variant_Annotation</a>
    /// </summary>
    let Natural_Variant_Annotation = _prefixId.prefix "Natural_Variant_Annotation"
    /// <summary>
    ///   <para>rdfs:label : Natural Variation^^xsd:string</para>
    ///   <a href="http://purl.uniprot.org/core/Natural_Variation_Annotation">uniprot:Natural_Variation_Annotation</a>
    /// </summary>
    let Natural_Variation_Annotation = _prefixId.prefix "Natural_Variation_Annotation"
    let Neutron_Diffraction = _prefixId.prefix "Neutron_Diffraction"

    /// <summary>
    ///   <para>rdfs:seeAlso : http://www.uniprot.org/manual/non_cons^^xsd:anyURI</para>
    ///   <para>rdfs:comment : Indicates that two residues in a sequence are not consecutive and that there are a number of unsequenced residues between them.^^xsd:string</para>
    ///   <para>rdfs:label : Non-consecutive Residues^^xsd:string</para>
    ///   <a href="http://purl.uniprot.org/core/Non-adjacent_Residues_Annotation">uniprot:Non-adjacent_Residues_Annotation</a>
    /// </summary>
    let Non_adjacent_Residues_Annotation =
        _prefixId.prefix "Non-adjacent_Residues_Annotation"

    let Non_photosynthetic_plastid = _prefixId.prefix "Non-photosynthetic_plastid"

    /// <summary>
    ///   <para>rdfs:seeAlso : http://www.uniprot.org/manual/non_std^^xsd:anyURI</para>
    ///   <para>rdfs:comment : Describes the occurrence of a non standard residue in the sequence record.^^xsd:string</para>
    ///   <para>rdfs:label : Non standard residue^^xsd:string</para>
    ///   <a href="http://purl.uniprot.org/core/Non-standard_Residue_Annotation">uniprot:Non-standard_Residue_Annotation</a>
    /// </summary>
    let Non_standard_Residue_Annotation =
        _prefixId.prefix "Non-standard_Residue_Annotation"

    /// <summary>
    ///   <para>rdfs:seeAlso : http://www.uniprot.org/manual/non_ter^^xsd:anyURI</para>
    ///   <para>rdfs:comment : The residue at an extremity of the sequence is not the terminal residue.^^xsd:string</para>
    ///   <para>rdfs:label : Non-terminal Residue^^xsd:string</para>
    ///   <a href="http://purl.uniprot.org/core/Non-terminal_Residue_Annotation">uniprot:Non-terminal_Residue_Annotation</a>
    /// </summary>
    let Non_terminal_Residue_Annotation =
        _prefixId.prefix "Non-terminal_Residue_Annotation"

    /// <summary>
    ///   <para>rdfs:comment : A class introduced to group all records that are currently in the database.^^xsd:string</para>
    ///   <a href="http://purl.uniprot.org/core/NotObsolete">uniprot:NotObsolete</a>
    /// </summary>
    let NotObsolete = _prefixId.prefix "NotObsolete"
    let NotObsoleteProtein = _prefixId.prefix "NotObsoleteProtein"
    let NotObsoleteTaxon = _prefixId.prefix "NotObsoleteTaxon"
    let Nucleomorph = _prefixId.prefix "Nucleomorph"
    /// <summary>
    ///   <para>rdfs:seeAlso : http://www.uniprot.org/manual/np_bind^^xsd:anyURI</para>
    ///   <para>rdfs:comment : Extent of a DNA-binding region.^^xsd:string</para>
    ///   <para>rdfs:label : DNA Binding^^xsd:string</para>
    ///   <a href="http://purl.uniprot.org/core/Nucleotide_Binding_Annotation">uniprot:Nucleotide_Binding_Annotation</a>
    /// </summary>
    let Nucleotide_Binding_Annotation = _prefixId.prefix "Nucleotide_Binding_Annotation"
    /// <summary>
    ///   <para>rdfs:comment : The relationship between a protein and a nucleotide sequence.^^xsd:string</para>
    ///   <para>rdfs:label : Nucleotide Mapping Statement^^xsd:string</para>
    ///   <a href="http://purl.uniprot.org/core/Nucleotide_Mapping_Statement">uniprot:Nucleotide_Mapping_Statement</a>
    /// </summary>
    let Nucleotide_Mapping_Statement = _prefixId.prefix "Nucleotide_Mapping_Statement"
    /// <summary>
    ///   <para>rdfs:comment : A resource that descripes a nucleotide sequence.^^xsd:string</para>
    ///   <para>rdfs:label : Nucleotide Resource^^xsd:string</para>
    ///   <a href="http://purl.uniprot.org/core/Nucleotide_Resource">uniprot:Nucleotide_Resource</a>
    /// </summary>
    let Nucleotide_Resource = _prefixId.prefix "Nucleotide_Resource"
    /// <summary>
    ///   <para>rdfs:comment : Citation of an unpublished result.^^xsd:string</para>
    ///   <para>rdfs:label : Observation Citation^^xsd:string</para>
    ///   <a href="http://purl.uniprot.org/core/Observation_Citation">uniprot:Observation_Citation</a>
    /// </summary>
    let Observation_Citation = _prefixId.prefix "Observation_Citation"
    /// <summary>
    ///   <para>rdfs:comment : The class of all obsolete records in the database (i.e. records that where once published but are now removed).^^xsd:string</para>
    ///   <a href="http://purl.uniprot.org/core/Obsolete">uniprot:Obsolete</a>
    /// </summary>
    let Obsolete = _prefixId.prefix "Obsolete"
    /// <summary>
    ///   <para>rdfs:seeAlso : http://www.uniprot.org/faq/11^^xsd:anyURI</para>
    ///   <a href="http://purl.uniprot.org/core/ObsoleteProtein">uniprot:ObsoleteProtein</a>
    /// </summary>
    let ObsoleteProtein = _prefixId.prefix "ObsoleteProtein"
    /// <summary>
    ///   <para>rdfs:seeAlso : http://www.ncbi.nlm.nih.gov/books/NBK54428/^^xsd:anyURI</para>
    ///   <para>rdfs:comment : Taxa are occasionally removed from the taxonomy database (particularly internal nodes, during a taxonomic revision) – these taxids are deleted, and are not reused.^^xsd:string</para>
    ///   <a href="http://purl.uniprot.org/core/ObsoleteTaxon">uniprot:ObsoleteTaxon</a>
    /// </summary>
    let ObsoleteTaxon = _prefixId.prefix "ObsoleteTaxon"
    let Order = _prefixId.prefix "Order"
    let Organellar_chromatophore = _prefixId.prefix "Organellar_chromatophore"
    /// <summary>
    ///   <para>rdfs:label : Organelle^^xsd:string</para>
    ///   <a href="http://purl.uniprot.org/core/Organelle">uniprot:Organelle</a>
    /// </summary>
    let Organelle = _prefixId.prefix "Organelle"
    /// <summary>
    ///   <para>rdfs:label : Orientation^^xsd:string</para>
    ///   <a href="http://purl.uniprot.org/core/Orientation">uniprot:Orientation</a>
    /// </summary>
    let Orientation = _prefixId.prefix "Orientation"
    /// <summary>
    ///   <para>rdfs:label : Other DNA^^xsd:string</para>
    ///   <a href="http://purl.uniprot.org/core/Other_DNA">uniprot:Other_DNA</a>
    /// </summary>
    let Other_DNA = _prefixId.prefix "Other_DNA"
    /// <summary>
    ///   <para>rdfs:label : Other RNA^^xsd:string</para>
    ///   <a href="http://purl.uniprot.org/core/Other_RNA">uniprot:Other_RNA</a>
    /// </summary>
    let Other_RNA = _prefixId.prefix "Other_RNA"
    let PD = _prefixId.prefix "PD"
    /// <summary>
    ///   <para>rdfs:comment : Describes the optimum pH for enzyme activity and/or the variation of enzyme activity with pH variation.^^xsd:string</para>
    ///   <para>rdfs:label : pH Dependence^^xsd:string</para>
    ///   <a href="http://purl.uniprot.org/core/PH_Dependence_Annotation">uniprot:PH_Dependence_Annotation</a>
    /// </summary>
    let PH_Dependence_Annotation = _prefixId.prefix "PH_Dependence_Annotation"
    /// <summary>
    ///   <para>rdfs:seeAlso : http://www.uniprot.org/manual/post-translational_modification^^xsd:anyURI</para>
    ///   <para>rdfs:comment : Description of a posttranslational modification.^^xsd:string</para>
    ///   <para>rdfs:label : PTM^^xsd:string</para>
    ///   <a href="http://purl.uniprot.org/core/PTM_Annotation">uniprot:PTM_Annotation</a>
    /// </summary>
    let PTM_Annotation = _prefixId.prefix "PTM_Annotation"
    /// <summary>
    ///   <para>rdfs:seeAlso : http://www.uniprot.org/manual/protein_names^^xsd:anyURI</para>
    ///   <para>rdfs:comment : Description of a part of a protein.^^xsd:string</para>
    ///   <a href="http://purl.uniprot.org/core/Part">uniprot:Part</a>
    /// </summary>
    let Part = _prefixId.prefix "Part"
    /// <summary>
    ///   <para>rdfs:seeAlso : http://www.uniprot.org/manual/binary_interactions^^xsd:anyURI</para>
    ///   <para>rdfs:comment : A participant in a protein-protein interaction.^^xsd:string</para>
    ///   <a href="http://purl.uniprot.org/core/Participant">uniprot:Participant</a>
    /// </summary>
    let Participant = _prefixId.prefix "Participant"
    let Parvorder = _prefixId.prefix "Parvorder"
    /// <summary>
    ///   <para>rdfs:comment : A patent application.^^xsd:string</para>
    ///   <para>rdfs:label : Patent Citation^^xsd:string</para>
    ///   <a href="http://purl.uniprot.org/core/Patent_Citation">uniprot:Patent_Citation</a>
    /// </summary>
    let Patent_Citation = _prefixId.prefix "Patent_Citation"
    /// <summary>
    ///   <para>rdfs:seeAlso : http://www.uniprot.org/manual/pathway^^xsd:anyURIrdfs:seeAlso : http://www.grenoble.prabi.fr/obiwarehouse/unipathway^^xsd:anyURI</para>
    ///   <para>rdfs:comment : A hierarchical discription of a metabolic pathway.^^xsd:string</para>
    ///   <a href="http://purl.uniprot.org/core/Pathway">uniprot:Pathway</a>
    /// </summary>
    let Pathway = _prefixId.prefix "Pathway"
    /// <summary>
    ///   <para>rdfs:seeAlso : http://www.uniprot.org/manual/pathway^^xsd:anyURI</para>
    ///   <para>rdfs:comment : Description of the metabolic pathways with which a protein is associated.^^xsd:string</para>
    ///   <para>rdfs:label : Pathway^^xsd:string</para>
    ///   <a href="http://purl.uniprot.org/core/Pathway_Annotation">uniprot:Pathway_Annotation</a>
    /// </summary>
    let Pathway_Annotation = _prefixId.prefix "Pathway_Annotation"
    /// <summary>
    ///   <para>rdfs:seeAlso : http://www.uniprot.org/manual/peptide^^xsd:anyURI</para>
    ///   <para>rdfs:comment : Extent of a released active peptide.^^xsd:string</para>
    ///   <para>rdfs:label : Peptide^^xsd:string</para>
    ///   <a href="http://purl.uniprot.org/core/Peptide_Annotation">uniprot:Peptide_Annotation</a>
    /// </summary>
    let Peptide_Annotation = _prefixId.prefix "Peptide_Annotation"
    /// <summary>
    ///   <para>rdfs:seeAlso : http://www.uniprot.org/manual/pharmaceutical_use^^xsd:anyURI</para>
    ///   <para>rdfs:comment : Description of the use of a protein as a pharmaceutical drug.^^xsd:string</para>
    ///   <para>rdfs:label : Pharmaceutical^^xsd:string</para>
    ///   <a href="http://purl.uniprot.org/core/Pharmaceutical_Annotation">uniprot:Pharmaceutical_Annotation</a>
    /// </summary>
    let Pharmaceutical_Annotation = _prefixId.prefix "Pharmaceutical_Annotation"
    let Phylum = _prefixId.prefix "Phylum"
    let Plastid = _prefixId.prefix "Plastid"
    /// <summary>
    ///   <para>rdfs:seeAlso : http://www.uniprot.org/manual/polymorphism^^xsd:anyURI</para>
    ///   <para>rdfs:comment : Description of polymorphisms.^^xsd:string</para>
    ///   <para>rdfs:label : Polymorphism^^xsd:string</para>
    ///   <a href="http://purl.uniprot.org/core/Polymorphism_Annotation">uniprot:Polymorphism_Annotation</a>
    /// </summary>
    let Polymorphism_Annotation = _prefixId.prefix "Polymorphism_Annotation"
    let Potential = _prefixId.prefix "Potential"
    let Predicted_Existence = _prefixId.prefix "Predicted_Existence"
    let Prediction = _prefixId.prefix "Prediction"
    let Probable = _prefixId.prefix "Probable"
    /// <summary>
    ///   <para>rdfs:seeAlso : http://www.uniprot.org/manual/propep^^xsd:anyURI</para>
    ///   <para>rdfs:comment : Extent of a propeptide.^^xsd:string</para>
    ///   <para>rdfs:label : Propeptide^^xsd:string</para>
    ///   <a href="http://purl.uniprot.org/core/Propeptide_Annotation">uniprot:Propeptide_Annotation</a>
    /// </summary>
    let Propeptide_Annotation = _prefixId.prefix "Propeptide_Annotation"
    /// <summary>
    ///   <para>rdfs:comment : Description of a protein.^^xsd:string</para>
    ///   <para>rdfs:seeAlso : http://www.uniprot.org/help/uniprotkb^^xsd:anyURI</para>
    ///   <para>rdfs:label : Protein^^xsd:string</para>
    ///   <a href="http://purl.uniprot.org/core/Protein">uniprot:Protein</a>
    /// </summary>
    let Protein = _prefixId.prefix "Protein"
    let Protein_Existence = _prefixId.prefix "Protein_Existence"
    /// <summary>
    ///   <para>rdfs:comment : Desription of a set of related proteins.^^xsd:string</para>
    ///   <para>rdfs:label : Protein Family^^xsd:string</para>
    ///   <a href="http://purl.uniprot.org/core/Protein_Family">uniprot:Protein_Family</a>
    /// </summary>
    let Protein_Family = _prefixId.prefix "Protein_Family"
    /// <summary>
    ///   <para>rdfs:seeAlso : http://www.uniprot.org/manual/references^^xsd:anyURI</para>
    ///   <para>rdfs:label : Published Citation^^xsd:string</para>
    ///   <a href="http://purl.uniprot.org/core/Published_Citation">uniprot:Published_Citation</a>
    /// </summary>
    let Published_Citation = _prefixId.prefix "Published_Citation"
    let RNA = _prefixId.prefix "RNA"
    /// <summary>
    ///   <para>rdfs:seeAlso : http://www.uniprot.org/manual/rna_editing^^xsd:anyURI</para>
    ///   <para>rdfs:comment : Description of any type of RNA editing that leads to one or more amino acid changes.^^xsd:string</para>
    ///   <para>rdfs:label : RNA Editing^^xsd:string</para>
    ///   <a href="http://purl.uniprot.org/core/RNA_Editing_Annotation">uniprot:RNA_Editing_Annotation</a>
    /// </summary>
    let RNA_Editing_Annotation = _prefixId.prefix "RNA_Editing_Annotation"
    /// <summary>
    ///   <para>rdfs:comment : A range of amino acids on a protein  sequence.^^xsd:string</para>
    ///   <a href="http://purl.uniprot.org/core/Range">uniprot:Range</a>
    /// </summary>
    let Range = _prefixId.prefix "Range"
    /// <summary>
    ///   <para>rdfs:comment : A rank of a taxon.^^xsd:string</para>
    ///   <a href="http://purl.uniprot.org/core/Rank">uniprot:Rank</a>
    /// </summary>
    let Rank = _prefixId.prefix "Rank"
    /// <summary>
    ///   <para>rdfs:comment : Reports the value of the standard (midpoint) oxido-reduction potential(s) for electron transport proteins.^^xsd:string</para>
    ///   <para>rdfs:label : Redox Potential^^xsd:string</para>
    ///   <a href="http://purl.uniprot.org/core/Redox_Potential_Annotation">uniprot:Redox_Potential_Annotation</a>
    /// </summary>
    let Redox_Potential_Annotation = _prefixId.prefix "Redox_Potential_Annotation"
    /// <summary>
    ///   <para>rdfs:label : Region^^xsd:string</para>
    ///   <a href="http://purl.uniprot.org/core/Region_Annotation">uniprot:Region_Annotation</a>
    /// </summary>
    let Region_Annotation = _prefixId.prefix "Region_Annotation"
    /// <summary>
    ///   <para>rdfs:seeAlso : http://www.uniprot.org/manual/repeat^^xsd:anyURI</para>
    ///   <para>rdfs:comment : Extent of an internal sequence repetition.^^xsd:string</para>
    ///   <para>rdfs:label : Repeat^^xsd:string</para>
    ///   <a href="http://purl.uniprot.org/core/Repeat_Annotation">uniprot:Repeat_Annotation</a>
    /// </summary>
    let Repeat_Annotation = _prefixId.prefix "Repeat_Annotation"
    /// <summary>
    ///   <para>rdfs:comment : A life science resource.^^xsd:string</para>
    ///   <a href="http://purl.uniprot.org/core/Resource">uniprot:Resource</a>
    /// </summary>
    let Resource = _prefixId.prefix "Resource"
    /// <summary>
    ///   <para>rdfs:label : Ribosomal Frameshifting^^xsd:string</para>
    ///   <a href="http://purl.uniprot.org/core/Ribosomal_Frameshifting">uniprot:Ribosomal_Frameshifting</a>
    /// </summary>
    let Ribosomal_Frameshifting = _prefixId.prefix "Ribosomal_Frameshifting"
    let SELDI = _prefixId.prefix "SELDI"

    /// <summary>
    ///   <para>rdfs:comment : Describes the secondary structure of proteins whose tertiary structure is known experimentally.^^xsd:string</para>
    ///   <para>rdfs:label : Secondary Structure^^xsd:string</para>
    ///   <a href="http://purl.uniprot.org/core/Secondary_Structure_Annotation">uniprot:Secondary_Structure_Annotation</a>
    /// </summary>
    let Secondary_Structure_Annotation =
        _prefixId.prefix "Secondary_Structure_Annotation"

    /// <summary>
    ///   <para>rdfs:seeAlso : http://www.uniprot.org/manual/sequences^^xsd:anyURIrdfs:seeAlso : http://www.uniprot.org/help/uniparc^^xsd:anyURI</para>
    ///   <para>rdfs:comment : An amino acid sequence.^^xsd:string</para>
    ///   <a href="http://purl.uniprot.org/core/Sequence">uniprot:Sequence</a>
    /// </summary>
    let Sequence = _prefixId.prefix "Sequence"
    /// <summary>
    ///   <para>rdfs:seeAlso : http://www.uniprot.org/manual/sequence_annotation^^xsd:anyURI</para>
    ///   <para>rdfs:comment : Description of a special region or site in a protein sequence.^^xsd:string</para>
    ///   <para>rdfs:label : Sequence Annotation^^xsd:string</para>
    ///   <a href="http://purl.uniprot.org/core/Sequence_Annotation">uniprot:Sequence_Annotation</a>
    /// </summary>
    let Sequence_Annotation = _prefixId.prefix "Sequence_Annotation"
    /// <summary>
    ///   <para>rdfs:seeAlso : http://www.uniprot.org/manual/sequence_caution^^xsd:anyURI</para>
    ///   <para>rdfs:comment : Warning about possible errors related to the protein sequence^^xsd:string</para>
    ///   <para>rdfs:label : Sequence Caution^^xsd:string</para>
    ///   <a href="http://purl.uniprot.org/core/Sequence_Caution_Annotation">uniprot:Sequence_Caution_Annotation</a>
    /// </summary>
    let Sequence_Caution_Annotation = _prefixId.prefix "Sequence_Caution_Annotation"
    /// <summary>
    ///   <para>rdfs:seeAlso : http://www.uniprot.org/manual/conflict^^xsd:anyURI</para>
    ///   <para>rdfs:comment : Different sources report differing sequences.^^xsd:string</para>
    ///   <para>rdfs:label : Sequence Conflict^^xsd:string</para>
    ///   <a href="http://purl.uniprot.org/core/Sequence_Conflict_Annotation">uniprot:Sequence_Conflict_Annotation</a>
    /// </summary>
    let Sequence_Conflict_Annotation = _prefixId.prefix "Sequence_Conflict_Annotation"

    /// <summary>
    ///   <para>rdfs:seeAlso : http://www.uniprot.org/manual/unsure^^xsd:anyURI</para>
    ///   <para>rdfs:comment : Used to describe region(s) of a sequence for which the authors are unsure about the sequence assignment.^^xsd:string</para>
    ///   <para>rdfs:label : Unsure Residue^^xsd:string</para>
    ///   <a href="http://purl.uniprot.org/core/Sequence_Uncertainty_Annotation">uniprot:Sequence_Uncertainty_Annotation</a>
    /// </summary>
    let Sequence_Uncertainty_Annotation =
        _prefixId.prefix "Sequence_Uncertainty_Annotation"

    /// <summary>
    ///   <para>rdfs:seeAlso : http://www.uniprot.org/manual/signal^^xsd:anyURI</para>
    ///   <para>rdfs:comment : Extent of a signal sequence (prepeptide).^^xsd:string</para>
    ///   <para>rdfs:label : Signal Peptide^^xsd:string</para>
    ///   <a href="http://purl.uniprot.org/core/Signal_Peptide_Annotation">uniprot:Signal_Peptide_Annotation</a>
    /// </summary>
    let Signal_Peptide_Annotation = _prefixId.prefix "Signal_Peptide_Annotation"
    /// <summary>
    ///   <para>rdfs:seeAlso : http://www.uniprot.org/manual/sequence_similarities^^xsd:anyURI</para>
    ///   <para>rdfs:comment : Description of the similarities (sequence or structural) of a protein with other proteins.^^xsd:string</para>
    ///   <para>rdfs:label : Similarity^^xsd:string</para>
    ///   <a href="http://purl.uniprot.org/core/Similarity_Annotation">uniprot:Similarity_Annotation</a>
    /// </summary>
    let Similarity_Annotation = _prefixId.prefix "Similarity_Annotation"
    /// <summary>
    ///   <para>rdfs:label : Simple Sequence^^xsd:string</para>
    ///   <a href="http://purl.uniprot.org/core/Simple_Sequence">uniprot:Simple_Sequence</a>
    /// </summary>
    let Simple_Sequence = _prefixId.prefix "Simple_Sequence"
    /// <summary>
    ///   <para>rdfs:seeAlso : http://www.uniprot.org/manual/site^^xsd:anyURI</para>
    ///   <para>rdfs:comment : Any interesting single amino-acid site on the sequence, that is not defined by another feature key. It can also apply to an amino acid bond which is represented by the positions of the two flanking amino acids.^^xsd:string</para>
    ///   <para>rdfs:label : Site^^xsd:string</para>
    ///   <a href="http://purl.uniprot.org/core/Site_Annotation">uniprot:Site_Annotation</a>
    /// </summary>
    let Site_Annotation = _prefixId.prefix "Site_Annotation"
    let Species = _prefixId.prefix "Species"
    let Species_Group = _prefixId.prefix "Species_Group"
    let Species_Subgroup = _prefixId.prefix "Species_Subgroup"
    /// <summary>
    ///   <para>rdfs:seeAlso : http://www.uniprot.org/manual/non_experimental_qualifiers^^xsd:anyURI</para>
    ///   <para>rdfs:comment : Indicator for the reliability of a piece of information.^^xsd:string</para>
    ///   <a href="http://purl.uniprot.org/core/Status">uniprot:Status</a>
    /// </summary>
    let Status = _prefixId.prefix "Status"
    /// <summary>
    ///   <para>rdfs:comment : A strain of a species.^^xsd:string</para>
    ///   <para>rdfs:label : Strain^^xsd:string</para>
    ///   <a href="http://purl.uniprot.org/core/Strain">uniprot:Strain</a>
    /// </summary>
    let Strain = _prefixId.prefix "Strain"

    /// <summary>
    ///   <para>rdfs:comment : An experimental method for determining the 3D structure of a protein.^^xsd:string</para>
    ///   <para>rdfs:label : Structure Determination^^xsd:string</para>
    ///   <a href="http://purl.uniprot.org/core/Structure_Determination_Method">uniprot:Structure_Determination_Method</a>
    /// </summary>
    let Structure_Determination_Method =
        _prefixId.prefix "Structure_Determination_Method"

    /// <summary>
    ///   <para>rdfs:comment : The relationship between a protein and a 3D structure.^^xsd:string</para>
    ///   <para>rdfs:label : Structure Mapping Statement^^xsd:string</para>
    ///   <a href="http://purl.uniprot.org/core/Structure_Mapping_Statement">uniprot:Structure_Mapping_Statement</a>
    /// </summary>
    let Structure_Mapping_Statement = _prefixId.prefix "Structure_Mapping_Statement"
    /// <summary>
    ///   <para>rdfs:comment : A resource that describes the 3D structure of a protein.^^xsd:string</para>
    ///   <para>rdfs:label : Structure Resource^^xsd:string</para>
    ///   <a href="http://purl.uniprot.org/core/Structure_Resource">uniprot:Structure_Resource</a>
    /// </summary>
    let Structure_Resource = _prefixId.prefix "Structure_Resource"
    /// <summary>
    ///   <para>rdfs:seeAlso : http://www.uniprot.org/manual/protein_names^^xsd:anyURI</para>
    ///   <para>rdfs:comment : A resource that holds a set of the known names for this protein together.^^xsd:string</para>
    ///   <a href="http://purl.uniprot.org/core/Structured_Name">uniprot:Structured_Name</a>
    /// </summary>
    let Structured_Name = _prefixId.prefix "Structured_Name"
    /// <summary>
    ///   <para>rdfs:seeAlso : http://www.uniprot.org/locations/^^xsd:anyURI</para>
    ///   <para>rdfs:label : Subcellular Location^^xsd:string</para>
    ///   <a href="http://purl.uniprot.org/core/Subcellular_Location">uniprot:Subcellular_Location</a>
    /// </summary>
    let Subcellular_Location = _prefixId.prefix "Subcellular_Location"

    /// <summary>
    ///   <para>rdfs:seeAlso : http://www.uniprot.org/manual/subcellular_location^^xsd:anyURI</para>
    ///   <para>rdfs:comment : Description of the subcellular location of the mature protein.^^xsd:string</para>
    ///   <para>rdfs:label : Subcellular Location^^xsd:string</para>
    ///   <a href="http://purl.uniprot.org/core/Subcellular_Location_Annotation">uniprot:Subcellular_Location_Annotation</a>
    /// </summary>
    let Subcellular_Location_Annotation =
        _prefixId.prefix "Subcellular_Location_Annotation"

    let Subclass = _prefixId.prefix "Subclass"
    let Subfamily = _prefixId.prefix "Subfamily"
    let Subgenus = _prefixId.prefix "Subgenus"
    let Subkingdom = _prefixId.prefix "Subkingdom"
    /// <summary>
    ///   <para>rdfs:comment : Data that was submitted directly to a database.^^xsd:string</para>
    ///   <para>rdfs:label : Submission Citation^^xsd:string</para>
    ///   <a href="http://purl.uniprot.org/core/Submission_Citation">uniprot:Submission_Citation</a>
    /// </summary>
    let Submission_Citation = _prefixId.prefix "Submission_Citation"
    let Suborder = _prefixId.prefix "Suborder"
    let Subphylum = _prefixId.prefix "Subphylum"
    let Subspecies = _prefixId.prefix "Subspecies"
    let Subtribe = _prefixId.prefix "Subtribe"
    /// <summary>
    ///   <para>rdfs:seeAlso : http://www.uniprot.org/manual/subunit_structure^^xsd:anyURI</para>
    ///   <para>rdfs:comment : Description of the quaternary structure of a protein.^^xsd:string</para>
    ///   <para>rdfs:label : Subunit^^xsd:string</para>
    ///   <a href="http://purl.uniprot.org/core/Subunit_Annotation">uniprot:Subunit_Annotation</a>
    /// </summary>
    let Subunit_Annotation = _prefixId.prefix "Subunit_Annotation"
    let Superclass = _prefixId.prefix "Superclass"
    let Superfamily = _prefixId.prefix "Superfamily"
    let Superkingdom = _prefixId.prefix "Superkingdom"
    let Superorder = _prefixId.prefix "Superorder"
    let Superphylum = _prefixId.prefix "Superphylum"
    /// <summary>
    ///   <para>rdfs:seeAlso : http://www.ncbi.nlm.nih.gov/books/NBK54428/^^xsd:anyURI</para>
    ///   <para>rdfs:comment : An element of a taxonomy for classifying life forms.^^xsd:string</para>
    ///   <a href="http://purl.uniprot.org/core/Taxon">uniprot:Taxon</a>
    /// </summary>
    let Taxon = _prefixId.prefix "Taxon"

    /// <summary>
    ///   <para>rdfs:comment : Indicates the optimum temperature for enzyme activity and/or the variation of enzyme activity with temperature variation; the thermostability/thermolability of the enzyme is also mentioned when it is known.^^xsd:string</para>
    ///   <para>rdfs:label : Temperature Dependence^^xsd:string</para>
    ///   <a href="http://purl.uniprot.org/core/Temperature_Dependence_Annotation">uniprot:Temperature_Dependence_Annotation</a>
    /// </summary>
    let Temperature_Dependence_Annotation =
        _prefixId.prefix "Temperature_Dependence_Annotation"

    /// <summary>
    ///   <para>rdfs:comment : A Ph.D. thesis.^^xsd:string</para>
    ///   <para>rdfs:label : Thesis Citation^^xsd:string</para>
    ///   <a href="http://purl.uniprot.org/core/Thesis_Citation">uniprot:Thesis_Citation</a>
    /// </summary>
    let Thesis_Citation = _prefixId.prefix "Thesis_Citation"
    /// <summary>
    ///   <para>rdfs:seeAlso : http://www.uniprot.org/docs/tisslist^^xsd:anyURI</para>
    ///   <para>rdfs:comment : A tissue such as lung or heart.^^xsd:string</para>
    ///   <para>rdfs:label : Tissue^^xsd:string</para>
    ///   <a href="http://purl.uniprot.org/core/Tissue">uniprot:Tissue</a>
    /// </summary>
    let Tissue = _prefixId.prefix "Tissue"
    /// <summary>
    ///   <para>rdfs:seeAlso : http://www.uniprot.org/manual/tissue_specificity^^xsd:anyURI</para>
    ///   <para>rdfs:comment : Description of the tissue specificity of a protein.^^xsd:string</para>
    ///   <para>rdfs:label : Tissue Specificity^^xsd:string</para>
    ///   <a href="http://purl.uniprot.org/core/Tissue_Specificity_Annotation">uniprot:Tissue_Specificity_Annotation</a>
    /// </summary>
    let Tissue_Specificity_Annotation = _prefixId.prefix "Tissue_Specificity_Annotation"
    /// <summary>
    ///   <para>rdfs:seeAlso : http://www.uniprot.org/manual/domain^^xsd:anyURI</para>
    ///   <para>rdfs:comment : A topological domain.^^xsd:string</para>
    ///   <para>rdfs:label : Topological Domain^^xsd:string</para>
    ///   <a href="http://purl.uniprot.org/core/Topological_Domain_Annotation">uniprot:Topological_Domain_Annotation</a>
    /// </summary>
    let Topological_Domain_Annotation = _prefixId.prefix "Topological_Domain_Annotation"
    /// <summary>
    ///   <para>rdfs:label : Topology^^xsd:string</para>
    ///   <a href="http://purl.uniprot.org/core/Topology">uniprot:Topology</a>
    /// </summary>
    let Topology = _prefixId.prefix "Topology"
    /// <summary>
    ///   <para>rdfs:seeAlso : http://www.uniprot.org/manual/toxic_dose^^xsd:anyURI</para>
    ///   <para>rdfs:comment : Information on the LD(50). LD stands for "Lethal Dose". LD(50) is the amount of a toxin, given all at once, which causes the death of 50% (one half) of a group of test animals.^^xsd:string</para>
    ///   <para>rdfs:label : Toxic Dose^^xsd:string</para>
    ///   <a href="http://purl.uniprot.org/core/Toxic_Dose_Annotation">uniprot:Toxic_Dose_Annotation</a>
    /// </summary>
    let Toxic_Dose_Annotation = _prefixId.prefix "Toxic_Dose_Annotation"
    /// <summary>
    ///   <para>rdfs:label : Transcribed RNA^^xsd:string</para>
    ///   <a href="http://purl.uniprot.org/core/Transcribed_RNA">uniprot:Transcribed_RNA</a>
    /// </summary>
    let Transcribed_RNA = _prefixId.prefix "Transcribed_RNA"
    /// <summary>
    ///   <para>rdfs:label : Transcript Resource^^xsd:string</para>
    ///   <a href="http://purl.uniprot.org/core/Transcript_Resource">uniprot:Transcript_Resource</a>
    /// </summary>
    let Transcript_Resource = _prefixId.prefix "Transcript_Resource"
    /// <summary>
    ///   <para>rdfs:seeAlso : http://www.uniprot.org/manual/transit^^xsd:anyURI</para>
    ///   <para>rdfs:comment : Extent of a transit peptide (mitochondrion, chloroplast, thylakoid, cyanelle or microbody).^^xsd:string</para>
    ///   <para>rdfs:label : Transit Peptide^^xsd:string</para>
    ///   <a href="http://purl.uniprot.org/core/Transit_Peptide_Annotation">uniprot:Transit_Peptide_Annotation</a>
    /// </summary>
    let Transit_Peptide_Annotation = _prefixId.prefix "Transit_Peptide_Annotation"
    /// <summary>
    ///   <para>rdfs:seeAlso : http://www.uniprot.org/manual/transmem^^xsd:anyURI</para>
    ///   <para>rdfs:comment : Extent of a transmembrane region.^^xsd:string</para>
    ///   <para>rdfs:label : Transmembrane^^xsd:string</para>
    ///   <a href="http://purl.uniprot.org/core/Transmembrane_Annotation">uniprot:Transmembrane_Annotation</a>
    /// </summary>
    let Transmembrane_Annotation = _prefixId.prefix "Transmembrane_Annotation"
    /// <summary>
    ///   <para>rdfs:comment : A transposon^^xsd:string</para>
    ///   <para>rdfs:label : Transposon^^xsd:string</para>
    ///   <a href="http://purl.uniprot.org/core/Transposon">uniprot:Transposon</a>
    /// </summary>
    let Transposon = _prefixId.prefix "Transposon"
    let Tribe = _prefixId.prefix "Tribe"
    /// <summary>
    ///   <para>rdfs:seeAlso : http://www.uniprot.org/manual/turn^^xsd:anyURI</para>
    ///   <para>rdfs:comment : Turns within the experimentally determined protein structure.^^xsd:string</para>
    ///   <para>rdfs:label : Turn^^xsd:string</para>
    ///   <a href="http://purl.uniprot.org/core/Turn_Annotation">uniprot:Turn_Annotation</a>
    /// </summary>
    let Turn_Annotation = _prefixId.prefix "Turn_Annotation"
    /// <summary>
    ///   <para>rdfs:label : Unassigned DNA^^xsd:string</para>
    ///   <a href="http://purl.uniprot.org/core/Unassigned_DNA">uniprot:Unassigned_DNA</a>
    /// </summary>
    let Unassigned_DNA = _prefixId.prefix "Unassigned_DNA"
    /// <summary>
    ///   <para>rdfs:label : Unassigned RNA^^xsd:string</para>
    ///   <a href="http://purl.uniprot.org/core/Unassigned_RNA">uniprot:Unassigned_RNA</a>
    /// </summary>
    let Unassigned_RNA = _prefixId.prefix "Unassigned_RNA"
    let Uncertain_Existence = _prefixId.prefix "Uncertain_Existence"
    /// <summary>
    ///   <para>rdfs:label : Unknown Sequence^^xsd:string</para>
    ///   <a href="http://purl.uniprot.org/core/Unknown_Sequence">uniprot:Unknown_Sequence</a>
    /// </summary>
    let Unknown_Sequence = _prefixId.prefix "Unknown_Sequence"
    /// <summary>
    ///   <para>rdfs:label : Unpublished Citation^^xsd:string</para>
    ///   <a href="http://purl.uniprot.org/core/Unpublished_Citation">uniprot:Unpublished_Citation</a>
    /// </summary>
    let Unpublished_Citation = _prefixId.prefix "Unpublished_Citation"
    let Varietas = _prefixId.prefix "Varietas"
    /// <summary>
    ///   <para>rdfs:comment : Positive cRNA molecule that is made from from a single stranded genomic RNA.^^xsd:string</para>
    ///   <para>rdfs:label : Viral cRNA^^xsd:string</para>
    ///   <a href="http://purl.uniprot.org/core/Viral_cRNA">uniprot:Viral_cRNA</a>
    /// </summary>
    let Viral_cRNA = _prefixId.prefix "Viral_cRNA"
    let X_Ray_Crystallography = _prefixId.prefix "X-Ray_Crystallography"
    /// <summary>
    ///   <para>rdfs:seeAlso : http://www.uniprot.org/manual/zn_fing^^xsd:anyURI</para>
    ///   <para>rdfs:comment : Extent of a zinc finger region.^^xsd:string</para>
    ///   <para>rdfs:label : Zinc Finger^^xsd:string</para>
    ///   <a href="http://purl.uniprot.org/core/Zinc_Finger_Annotation">uniprot:Zinc_Finger_Annotation</a>
    /// </summary>
    let Zinc_Finger_Annotation = _prefixId.prefix "Zinc_Finger_Annotation"
    /// <summary>
    ///   <para>rdfs:comment : True if the class does not have any direct instances.^^xsd:string</para>
    ///   <a href="http://purl.uniprot.org/core/abstract">uniprot:abstract</a>
    /// </summary>
    let abstract_ = _prefixId.prefix "abstract"
    /// <summary>
    ///   <para>rdfs:comment : The description of a catalytic activity.^^xsd:string</para>
    ///   <para>rdfs:label : catalytic activity^^xsd:string</para>
    ///   <a href="http://purl.uniprot.org/core/activity">uniprot:activity</a>
    /// </summary>
    let activity = _prefixId.prefix "activity"
    /// <summary>
    ///   <para>rdfs:comment : An alternative name used in the flat text format.^^xsd:string</para>
    ///   <a href="http://purl.uniprot.org/core/alias">uniprot:alias</a>
    /// </summary>
    let alias = _prefixId.prefix "alias"
    /// <summary>
    ///   <para>rdfs:comment : See http://www.expasy.org/cgi-bin/lists?allergen.txt^^xsd:string</para>
    ///   <a href="http://purl.uniprot.org/core/allergenName">uniprot:allergenName</a>
    /// </summary>
    let allergenName = _prefixId.prefix "allergenName"
    /// <summary>
    ///   <para>rdfs:seeAlso : http://www.uniprot.org/manual/protein_names^^xsd:anyURI</para>
    ///   <para>rdfs:comment : A synonym of the recommended name.^^xsd:string</para>
    ///   <a href="http://purl.uniprot.org/core/alternativeName">uniprot:alternativeName</a>
    /// </summary>
    let alternativeName = _prefixId.prefix "alternativeName"
    /// <summary>
    ///   <para>rdfs:comment : Attaches an annotation to a resource.^^xsd:string</para>
    ///   <a href="http://purl.uniprot.org/core/annotation">uniprot:annotation</a>
    /// </summary>
    let annotation = _prefixId.prefix "annotation"
    let attribution = _prefixId.prefix "attribution"
    /// <summary>
    ///   <para>rdfs:comment : True if the protein is divergent in sequence or has mutated functional sites.^^xsd:string</para>
    ///   <a href="http://purl.uniprot.org/core/atypical">uniprot:atypical</a>
    /// </summary>
    let atypical = _prefixId.prefix "atypical"
    /// <summary>
    ///   <para>rdfs:comment : The author of a publication.^^xsd:string</para>
    ///   <a href="http://purl.uniprot.org/core/author">uniprot:author</a>
    /// </summary>
    let author = _prefixId.prefix "author"
    let authorsIncomplete = _prefixId.prefix "authorsIncomplete"
    let base_ = _prefixId.prefix "base"
    /// <summary>
    ///   <para>rdfs:comment : The sequence on which the description of a modified sequence is based.^^xsd:string</para>
    ///   <para>rdfs:label : based on^^xsd:string</para>
    ///   <a href="http://purl.uniprot.org/core/basedOn">uniprot:basedOn</a>
    /// </summary>
    let basedOn = _prefixId.prefix "basedOn"
    /// <summary>
    ///   <para>rdfs:comment : The first position of a range.^^xsd:string</para>
    ///   <a href="http://purl.uniprot.org/core/begin">uniprot:begin</a>
    /// </summary>
    let begin_ = _prefixId.prefix "begin"
    /// <summary>
    ///   <para>rdfs:comment : A name used in a biotechnological context.^^xsd:string</para>
    ///   <a href="http://purl.uniprot.org/core/biotechName">uniprot:biotechName</a>
    /// </summary>
    let biotechName = _prefixId.prefix "biotechName"
    let category = _prefixId.prefix "category"
    /// <summary>
    ///   <para>rdfs:comment : A name from the Human Cell Differentiation Molecules (HCDM) nomenclature.^^xsd:string</para>
    ///   <a href="http://purl.uniprot.org/core/cdAntigenName">uniprot:cdAntigenName</a>
    /// </summary>
    let cdAntigenName = _prefixId.prefix "cdAntigenName"
    let cellularComponent = _prefixId.prefix "cellularComponent"
    /// <summary>
    ///   <para>rdfs:comment : False if there is any uncertainty about a statement.^^xsd:string</para>
    ///   <a href="http://purl.uniprot.org/core/certain">uniprot:certain</a>
    /// </summary>
    let certain = _prefixId.prefix "certain"
    /// <summary>
    ///   <para>rdfs:comment : Maps a series of symbols representing chains of a protein to a range of amino acids.^^xsd:string</para>
    ///   <a href="http://purl.uniprot.org/core/chain">uniprot:chain</a>
    /// </summary>
    let chain = _prefixId.prefix "chain"
    /// <summary>
    ///   <para>rdfs:comment : An caclulated value that is used to detect if there are errors in the sequence as shown due to among others IO errors. Both the crc64 and md5sum have collisions in UniProt data and cannot be used as unique keys.^^xsd:string</para>
    ///   <a href="http://purl.uniprot.org/core/checksum">uniprot:checksum</a>
    /// </summary>
    let checksum = _prefixId.prefix "checksum"
    /// <summary>
    ///   <para>rdfs:comment : A publication from which data was extracted, or which contains additional information.^^xsd:string</para>
    ///   <a href="http://purl.uniprot.org/core/citation">uniprot:citation</a>
    /// </summary>
    let citation = _prefixId.prefix "citation"
    /// <summary>
    ///   <para>rdfs:comment : A concept that classifies this resource.^^xsd:string</para>
    ///   <para>rdfs:label : classified with^^xsd:string</para>
    ///   <a href="http://purl.uniprot.org/core/classifiedWith">uniprot:classifiedWith</a>
    /// </summary>
    let classifiedWith = _prefixId.prefix "classifiedWith"
    /// <summary>
    ///   <para>rdfs:comment : A cofactor required for a catalytic activity.^^xsd:string</para>
    ///   <para>rdfs:label : cofactor^^xsd:string</para>
    ///   <a href="http://purl.uniprot.org/core/cofactor">uniprot:cofactor</a>
    /// </summary>
    let cofactor = _prefixId.prefix "cofactor"
    /// <summary>
    ///   <para>rdfs:label : common name^^xsd:string</para>
    ///   <a href="http://purl.uniprot.org/core/commonName">uniprot:commonName</a>
    /// </summary>
    let commonName = _prefixId.prefix "commonName"
    let commonTaxon = _prefixId.prefix "commonTaxon"
    /// <summary>
    ///   <para>rdfs:seeAlso : http://www.uniprot.org/faq/15^^xsd:anyURI</para>
    ///   <a href="http://purl.uniprot.org/core/complete">uniprot:complete</a>
    /// </summary>
    let complete = _prefixId.prefix "complete"
    /// <summary>
    ///   <para>rdfs:comment : A component of a protein.^^xsd:string</para>
    ///   <a href="http://purl.uniprot.org/core/component">uniprot:component</a>
    /// </summary>
    let component_ = _prefixId.prefix "component"
    let conflictingSequence = _prefixId.prefix "conflictingSequence"
    let context = _prefixId.prefix "context"
    let crc64Checksum = _prefixId.prefix "crc64Checksum"
    /// <summary>
    ///   <para>rdfs:comment : The date a resource was created.^^xsd:string</para>
    ///   <a href="http://purl.uniprot.org/core/created">uniprot:created</a>
    /// </summary>
    let created = _prefixId.prefix "created"
    let database = _prefixId.prefix "database"
    let date = _prefixId.prefix "date"
    /// <summary>
    ///   <para>rdfs:comment : A domain of a protein.^^xsd:string</para>
    ///   <a href="http://purl.uniprot.org/core/domain">uniprot:domain</a>
    /// </summary>
    let domain = _prefixId.prefix "domain"
    /// <summary>
    ///   <para>rdfs:comment : The number of domains in a protein that correspond to a family. This is almost always 1, but may be 2 if  two identical domains are fused.^^xsd:string</para>
    ///   <a href="http://purl.uniprot.org/core/domains">uniprot:domains</a>
    /// </summary>
    let domains = _prefixId.prefix "domains"
    /// <summary>
    ///   <para>rdfs:comment : The ecName is the enzyme classification associated with a structured name of the protein. Proteins are often named after their enzymatic activity but can have more than one activity leading to multiple names.^^xsd:string</para>
    ///   <a href="http://purl.uniprot.org/core/ecName">uniprot:ecName</a>
    /// </summary>
    let ecName = _prefixId.prefix "ecName"
    /// <summary>
    ///   <para>rdfs:comment : The editor of a publication.^^xsd:string</para>
    ///   <a href="http://purl.uniprot.org/core/editor">uniprot:editor</a>
    /// </summary>
    let editor = _prefixId.prefix "editor"
    /// <summary>
    ///   <para>rdfs:comment : The gene by which a protein is encoded.^^xsd:string</para>
    ///   <para>rdfs:label : encoded by^^xsd:string</para>
    ///   <a href="http://purl.uniprot.org/core/encodedBy">uniprot:encodedBy</a>
    /// </summary>
    let encodedBy = _prefixId.prefix "encodedBy"
    /// <summary>
    ///   <para>rdfs:comment : The subcellular location where a protein is encoded.^^xsd:string</para>
    ///   <para>rdfs:label : encoded in^^xsd:string</para>
    ///   <a href="http://purl.uniprot.org/core/encodedIn">uniprot:encodedIn</a>
    /// </summary>
    let encodedIn = _prefixId.prefix "encodedIn"
    /// <summary>
    ///   <para>rdfs:comment : The last position of a range.^^xsd:string</para>
    ///   <a href="http://purl.uniprot.org/core/end">uniprot:end</a>
    /// </summary>
    let end_ = _prefixId.prefix "end"
    /// <summary>
    ///   <para>rdfs:comment : The catalytic activity associated with a protein. or part of a protein.^^xsd:string</para>
    ///   <para>rdfs:label : enzyme^^xsd:string</para>
    ///   <a href="http://purl.uniprot.org/core/enzyme">uniprot:enzyme</a>
    /// </summary>
    let enzyme = _prefixId.prefix "enzyme"
    /// <summary>
    ///   <para>rdfs:comment : An erratum for a publication.^^xsd:string</para>
    ///   <a href="http://purl.uniprot.org/core/erratum">uniprot:erratum</a>
    /// </summary>
    let erratum = _prefixId.prefix "erratum"
    /// <summary>
    ///   <para>rdfs:comment : The publication which an erratum refers to.^^xsd:string</para>
    ///   <para>rdfs:label : erratum for^^xsd:string</para>
    ///   <a href="http://purl.uniprot.org/core/erratumFor">uniprot:erratumFor</a>
    /// </summary>
    let erratumFor = _prefixId.prefix "erratumFor"
    let existence = _prefixId.prefix "existence"
    let experiments = _prefixId.prefix "experiments"
    /// <summary>
    ///   <para>rdfs:comment : True if a statement is true even though it was not predicted.^^xsd:string</para>
    ///   <para>rdfs:label : false negative^^xsd:string</para>
    ///   <a href="http://purl.uniprot.org/core/falseNegative">uniprot:falseNegative</a>
    /// </summary>
    let falseNegative = _prefixId.prefix "falseNegative"
    /// <summary>
    ///   <para>rdfs:seeAlso : http://www.uniprot.org/manual/sequence_status^^xsd:anyURI</para>
    ///   <para>rdfs:comment : Indicates if a sequence is complete or consists of one or more fragments.^^xsd:string</para>
    ///   <a href="http://purl.uniprot.org/core/fragment">uniprot:fragment</a>
    /// </summary>
    let fragment = _prefixId.prefix "fragment"
    /// <summary>
    ///   <para>rdfs:comment : True if a sequence modification causes a frameshift.^^xsd:string</para>
    ///   <a href="http://purl.uniprot.org/core/frameshift">uniprot:frameshift</a>
    /// </summary>
    let frameshift = _prefixId.prefix "frameshift"
    /// <summary>
    ///   <para>rdfs:comment : The full name.^^xsd:string</para>
    ///   <a href="http://purl.uniprot.org/core/fullName">uniprot:fullName</a>
    /// </summary>
    let fullName = _prefixId.prefix "fullName"
    /// <summary>
    ///   <para>rdfs:comment : True if the rule on which the membership of a protein to a family is based does not cover the entire protein.^^xsd:string</para>
    ///   <a href="http://purl.uniprot.org/core/fused">uniprot:fused</a>
    /// </summary>
    let fused = _prefixId.prefix "fused"
    /// <summary>
    ///   <para>rdfs:comment : The group or consortium that authored a publication.^^xsd:string</para>
    ///   <a href="http://purl.uniprot.org/core/group">uniprot:group</a>
    /// </summary>
    let group = _prefixId.prefix "group"
    let height = _prefixId.prefix "height"
    /// <summary>
    ///   <para>rdfs:comment : The number of hits found in a sequence.^^xsd:string</para>
    ///   <a href="http://purl.uniprot.org/core/hits">uniprot:hits</a>
    /// </summary>
    let hits = _prefixId.prefix "hits"
    let host = _prefixId.prefix "host"
    /// <summary>
    ///   <para>rdfs:comment : The level of sequence identity in a cluster.^^xsd:string</para>
    ///   <a href="http://purl.uniprot.org/core/identity">uniprot:identity</a>
    /// </summary>
    let identity = _prefixId.prefix "identity"
    /// <summary>
    ///   <para>rdfs:comment : True if existance of this resource can be inferred.^^xsd:string</para>
    ///   <a href="http://purl.uniprot.org/core/implicit">uniprot:implicit</a>
    /// </summary>
    let implicit = _prefixId.prefix "implicit"
    let indexable = _prefixId.prefix "indexable"
    /// <summary>
    ///   <para>rdfs:comment : The institution at which a thesis was written.^^xsd:string</para>
    ///   <a href="http://purl.uniprot.org/core/institution">uniprot:institution</a>
    /// </summary>
    let institution = _prefixId.prefix "institution"
    let interaction = _prefixId.prefix "interaction"

    /// <summary>
    ///   <para>rdfs:comment : The international nonproprietary name: A generic name for a pharmaceutical substance or active pharmaceutical ingredient that is globally recognized and is a public property.^^xsd:string</para>
    ///   <a href="http://purl.uniprot.org/core/internationalNonproprietaryName">uniprot:internationalNonproprietaryName</a>
    /// </summary>
    let internationalNonproprietaryName =
        _prefixId.prefix "internationalNonproprietaryName"

    let isolatedFrom = _prefixId.prefix "isolatedFrom"
    let length = _prefixId.prefix "length"
    /// <summary>
    ///   <para>rdfs:comment : True if the range does not extend beyond the specified endpoint.^^xsd:string</para>
    ///   <a href="http://purl.uniprot.org/core/limit">uniprot:limit</a>
    /// </summary>
    let limit = _prefixId.prefix "limit"
    let locatedIn = _prefixId.prefix "locatedIn"
    /// <summary>
    ///   <para>rdfs:comment : The molecule a this resource is located on.^^xsd:string</para>
    ///   <para>rdfs:label : located on^^xsd:string</para>
    ///   <a href="http://purl.uniprot.org/core/locatedOn">uniprot:locatedOn</a>
    /// </summary>
    let locatedOn = _prefixId.prefix "locatedOn"
    let locator = _prefixId.prefix "locator"
    /// <summary>
    ///   <para>rdfs:label : locus name^^xsd:string</para>
    ///   <a href="http://purl.uniprot.org/core/locusName">uniprot:locusName</a>
    /// </summary>
    let locusName = _prefixId.prefix "locusName"
    let manual = _prefixId.prefix "manual"
    /// <summary>
    ///   <para>rdfs:comment : The mass of a sequence in Daltons.^^xsd:string</para>
    ///   <a href="http://purl.uniprot.org/core/mass">uniprot:mass</a>
    /// </summary>
    let mass = _prefixId.prefix "mass"
    /// <summary>
    ///   <para>rdfs:comment : A maximum value.^^xsd:string</para>
    ///   <a href="http://purl.uniprot.org/core/maximum">uniprot:maximum</a>
    /// </summary>
    let maximum = _prefixId.prefix "maximum"
    let md5Checksum = _prefixId.prefix "md5Checksum"
    /// <summary>
    ///   <para>rdfs:comment : The maximum velocity, Vmax.^^xsd:string</para>
    ///   <para>rdfs:label : measured activity^^xsd:string</para>
    ///   <a href="http://purl.uniprot.org/core/measuredActivity">uniprot:measuredActivity</a>
    /// </summary>
    let measuredActivity = _prefixId.prefix "measuredActivity"
    /// <summary>
    ///   <para>rdfs:comment : The Michaelis-Menten constant, Km.^^xsd:string</para>
    ///   <para>rdfs:label : measured affinity^^xsd:string</para>
    ///   <a href="http://purl.uniprot.org/core/measuredAffinity">uniprot:measuredAffinity</a>
    /// </summary>
    let measuredAffinity = _prefixId.prefix "measuredAffinity"
    /// <summary>
    ///   <para>rdfs:comment : The magnitude of the error of a value that was measured.^^xsd:string</para>
    ///   <para>rdfs:label : measured error^^xsd:string</para>
    ///   <a href="http://purl.uniprot.org/core/measuredError">uniprot:measuredError</a>
    /// </summary>
    let measuredError = _prefixId.prefix "measuredError"
    /// <summary>
    ///   <para>rdfs:comment : A value that was measured.^^xsd:string</para>
    ///   <para>rdfs:label : measured value^^xsd:string</para>
    ///   <a href="http://purl.uniprot.org/core/measuredValue">uniprot:measuredValue</a>
    /// </summary>
    let measuredValue = _prefixId.prefix "measuredValue"
    /// <summary>
    ///   <para>rdfs:comment : One of several similar resources.^^xsd:string</para>
    ///   <a href="http://purl.uniprot.org/core/member">uniprot:member</a>
    /// </summary>
    let member_ = _prefixId.prefix "member"
    /// <summary>
    ///   <para>rdfs:label : member of^^xsd:string</para>
    ///   <a href="http://purl.uniprot.org/core/memberOf">uniprot:memberOf</a>
    /// </summary>
    let memberOf = _prefixId.prefix "memberOf"
    /// <summary>
    ///   <para>rdfs:comment : The experimental method that was used.^^xsd:string</para>
    ///   <a href="http://purl.uniprot.org/core/method">uniprot:method</a>
    /// </summary>
    let method = _prefixId.prefix "method"
    /// <summary>
    ///   <para>rdfs:comment : A easy to remember identifier for a UniProtKB entry, but it is not a stable identifier and should not be used by programs to identify entries.^^xsd:string</para>
    ///   <para>rdfs:seeAlso : http://www.uniprot.org/manual/entry_name^^xsd:anyURI</para>
    ///   <a href="http://purl.uniprot.org/core/mnemonic">uniprot:mnemonic</a>
    /// </summary>
    let mnemonic = _prefixId.prefix "mnemonic"
    /// <summary>
    ///   <para>rdfs:comment : A modification of a sequence.^^xsd:string</para>
    ///   <a href="http://purl.uniprot.org/core/modification">uniprot:modification</a>
    /// </summary>
    let modification = _prefixId.prefix "modification"
    /// <summary>
    ///   <para>rdfs:comment : The date a resource was last modified.^^xsd:string</para>
    ///   <a href="http://purl.uniprot.org/core/modified">uniprot:modified</a>
    /// </summary>
    let modified = _prefixId.prefix "modified"
    /// <summary>
    ///   <para>rdfs:label : name^^xsd:string</para>
    ///   <a href="http://purl.uniprot.org/core/name">uniprot:name</a>
    /// </summary>
    let name = _prefixId.prefix "name"
    let negative = _prefixId.prefix "negative"
    /// <summary>
    ///   <para>rdfs:comment : True if this resource has been replaced or deleted.^^xsd:string</para>
    ///   <para>rdfs:label : obsolete^^xsd:string</para>
    ///   <a href="http://purl.uniprot.org/core/obsolete">uniprot:obsolete</a>
    /// </summary>
    let obsolete = _prefixId.prefix "obsolete"
    /// <summary>
    ///   <para>rdfs:comment : A mnemonic that is no longer in use for this entry.^^xsd:string</para>
    ///   <a href="http://purl.uniprot.org/core/oldMnemonic">uniprot:oldMnemonic</a>
    /// </summary>
    let oldMnemonic = _prefixId.prefix "oldMnemonic"
    /// <summary>
    ///   <para>rdfs:label : ORF name^^xsd:string</para>
    ///   <a href="http://purl.uniprot.org/core/orfName">uniprot:orfName</a>
    /// </summary>
    let orfName = _prefixId.prefix "orfName"
    /// <summary>
    ///   <para>rdfs:comment : The organism in which a protein occurs.^^xsd:string</para>
    ///   <a href="http://purl.uniprot.org/core/organism">uniprot:organism</a>
    /// </summary>
    let organism = _prefixId.prefix "organism"
    let orientation = _prefixId.prefix "orientation"
    /// <summary>
    ///   <para>rdfs:label : other name^^xsd:string</para>
    ///   <a href="http://purl.uniprot.org/core/otherName">uniprot:otherName</a>
    /// </summary>
    let otherName = _prefixId.prefix "otherName"
    /// <summary>
    ///   <para>rdfs:comment : The first and last page for a chapter or article.^^xsd:string</para>
    ///   <a href="http://purl.uniprot.org/core/pages">uniprot:pages</a>
    /// </summary>
    let pages = _prefixId.prefix "pages"
    let part = _prefixId.prefix "part"
    let partOf = _prefixId.prefix "partOf"
    /// <summary>
    ///   <para>rdfs:comment : True for taxa that can appear as part of an organism's lineage.^^xsd:string</para>
    ///   <para>rdfs:label : part of lineage^^xsd:string</para>
    ///   <a href="http://purl.uniprot.org/core/partOfLineage">uniprot:partOfLineage</a>
    /// </summary>
    let partOfLineage = _prefixId.prefix "partOfLineage"
    /// <summary>
    ///   <para>rdfs:comment : True if the pattern or profile on which the domain assignment is based did not detect the sequence because the sequence is not complete and lacks the region on which the pattern or profile is based.^^xsd:string</para>
    ///   <a href="http://purl.uniprot.org/core/partial">uniprot:partial</a>
    /// </summary>
    let partial = _prefixId.prefix "partial"
    /// <summary>
    ///   <para>rdfs:comment : A protein that participates in a protein-protein interaction.^^xsd:string</para>
    ///   <a href="http://purl.uniprot.org/core/participant">uniprot:participant</a>
    /// </summary>
    let participant = _prefixId.prefix "participant"
    /// <summary>
    ///   <para>rdfs:comment : A URL pattern, used to generate links by substituting an identifier.^^xsd:string</para>
    ///   <a href="http://purl.uniprot.org/core/pattern">uniprot:pattern</a>
    /// </summary>
    let pattern = _prefixId.prefix "pattern"
    /// <summary>
    ///   <para>rdfs:comment : The place where a publication was published. This usually includes a country name.^^xsd:string</para>
    ///   <a href="http://purl.uniprot.org/core/place">uniprot:place</a>
    /// </summary>
    let place = _prefixId.prefix "place"
    /// <summary>
    ///   <para>rdfs:comment : A position on a sequence.^^xsd:string</para>
    ///   <a href="http://purl.uniprot.org/core/position">uniprot:position</a>
    /// </summary>
    let position = _prefixId.prefix "position"
    let precursor = _prefixId.prefix "precursor"
    /// <summary>
    ///   <para>rdfs:comment : The publisher of a book.^^xsd:string</para>
    ///   <a href="http://purl.uniprot.org/core/publisher">uniprot:publisher</a>
    /// </summary>
    let publisher = _prefixId.prefix "publisher"
    /// <summary>
    ///   <para>rdfs:comment : A range of amino acids.^^xsd:string</para>
    ///   <a href="http://purl.uniprot.org/core/range">uniprot:range</a>
    /// </summary>
    let range = _prefixId.prefix "range"
    /// <summary>
    ///   <para>rdfs:comment : The rank of a taxon.^^xsd:string</para>
    ///   <a href="http://purl.uniprot.org/core/rank">uniprot:rank</a>
    /// </summary>
    let rank = _prefixId.prefix "rank"
    /// <summary>
    ///   <para>rdfs:comment : The name recommended by the UniProt consortium.^^xsd:string</para>
    ///   <a href="http://purl.uniprot.org/core/recommendedName">uniprot:recommendedName</a>
    /// </summary>
    let recommendedName = _prefixId.prefix "recommendedName"
    /// <summary>
    ///   <para>rdfs:seeAlso : http://www.uniprot.org/faq/47^^xsd:anyURI</para>
    ///   <a href="http://purl.uniprot.org/core/referenceProteome">uniprot:referenceProteome</a>
    /// </summary>
    let referenceProteome = _prefixId.prefix "referenceProteome"
    let relatedLocation = _prefixId.prefix "relatedLocation"
    /// <summary>
    ///   <para>rdfs:comment : A resource that replaces this resource.^^xsd:string</para>
    ///   <para>rdfs:label : replaced by^^xsd:string</para>
    ///   <a href="http://purl.uniprot.org/core/replacedBy">uniprot:replacedBy</a>
    /// </summary>
    let replacedBy = _prefixId.prefix "replacedBy"
    /// <summary>
    ///   <para>rdfs:comment : A resource that is replaced by this resource.^^xsd:string</para>
    ///   <a href="http://purl.uniprot.org/core/replaces">uniprot:replaces</a>
    /// </summary>
    let replaces = _prefixId.prefix "replaces"
    let representativeFor = _prefixId.prefix "representativeFor"
    /// <summary>
    ///   <para>rdfs:comment : The resolution of an experiment, in Angstrom.^^xsd:string</para>
    ///   <a href="http://purl.uniprot.org/core/resolution">uniprot:resolution</a>
    /// </summary>
    let resolution = _prefixId.prefix "resolution"
    /// <summary>
    ///   <para>rdfs:comment : Indicates whether a resource has been reviewed by a curator.^^xsd:string</para>
    ///   <a href="http://purl.uniprot.org/core/reviewed">uniprot:reviewed</a>
    /// </summary>
    let reviewed = _prefixId.prefix "reviewed"
    /// <summary>
    ///   <para>rdfs:label : scientific name^^xsd:string</para>
    ///   <a href="http://purl.uniprot.org/core/scientificName">uniprot:scientificName</a>
    /// </summary>
    let scientificName = _prefixId.prefix "scientificName"
    /// <summary>
    ///   <para>rdfs:comment : The extent of the work carried out by the authors of a publication.^^xsd:string</para>
    ///   <a href="http://purl.uniprot.org/core/scope">uniprot:scope</a>
    /// </summary>
    let scope = _prefixId.prefix "scope"
    let seedFor = _prefixId.prefix "seedFor"
    /// <summary>
    ///   <para>rdfs:comment : An amino acid sequence.^^xsd:string</para>
    ///   <a href="http://purl.uniprot.org/core/sequence">uniprot:sequence</a>
    /// </summary>
    let sequence = _prefixId.prefix "sequence"
    /// <summary>
    ///   <para>rdfs:comment : A resource that describes this sequence.^^xsd:string</para>
    ///   <para>rdfs:label : sequence for^^xsd:string</para>
    ///   <a href="http://purl.uniprot.org/core/sequenceFor">uniprot:sequenceFor</a>
    /// </summary>
    let sequenceFor = _prefixId.prefix "sequenceFor"
    /// <summary>
    ///   <para>rdfs:comment : An abbreviation of the full name or an acronym.^^xsd:string</para>
    ///   <a href="http://purl.uniprot.org/core/shortName">uniprot:shortName</a>
    /// </summary>
    let shortName = _prefixId.prefix "shortName"
    let source = _prefixId.prefix "source"
    /// <summary>
    ///   <para>rdfs:comment : The reliability of a statement.^^xsd:string</para>
    ///   <a href="http://purl.uniprot.org/core/status">uniprot:status</a>
    /// </summary>
    let status = _prefixId.prefix "status"
    let strain = _prefixId.prefix "strain"
    let structuredName = _prefixId.prefix "structuredName"
    /// <summary>
    ///   <para>rdfs:comment : All names of the protein, from commonly used to obsolete, to used in the literature..^^xsd:string</para>
    ///   <para>rdfs:seeAlso : http://www.uniprot.org/manual/protein_names^^xsd:anyURI</para>
    ///   <a href="http://purl.uniprot.org/core/structuredNameType">uniprot:structuredNameType</a>
    /// </summary>
    let structuredNameType = _prefixId.prefix "structuredNameType"
    /// <summary>
    ///   <para>rdfs:comment : A name provided by the submitter of the underlying nucleotide sequence.^^xsd:string</para>
    ///   <a href="http://purl.uniprot.org/core/submittedName">uniprot:submittedName</a>
    /// </summary>
    let submittedName = _prefixId.prefix "submittedName"
    /// <summary>
    ///   <para>rdfs:comment : The database a resource  was submitted to.^^xsd:string</para>
    ///   <a href="http://purl.uniprot.org/core/submittedTo">uniprot:submittedTo</a>
    /// </summary>
    let submittedTo = _prefixId.prefix "submittedTo"
    /// <summary>
    ///   <para>rdfs:comment : A replacement sequence.^^xsd:string</para>
    ///   <a href="http://purl.uniprot.org/core/substitution">uniprot:substitution</a>
    /// </summary>
    let substitution = _prefixId.prefix "substitution"
    let synonym = _prefixId.prefix "synonym"
    /// <summary>
    ///   <para>rdfs:comment : The title of a publication.^^xsd:string</para>
    ///   <a href="http://purl.uniprot.org/core/title">uniprot:title</a>
    /// </summary>
    let title = _prefixId.prefix "title"
    let topology = _prefixId.prefix "topology"
    let transcribedFrom = _prefixId.prefix "transcribedFrom"
    let translatedFrom = _prefixId.prefix "translatedFrom"
    let translatedTo = _prefixId.prefix "translatedTo"
    let version = _prefixId.prefix "version"
    /// <summary>
    ///   <para>rdfs:comment : The volume a publication is part of.^^xsd:string</para>
    ///   <a href="http://purl.uniprot.org/core/volume">uniprot:volume</a>
    /// </summary>
    let volume = _prefixId.prefix "volume"
    let width = _prefixId.prefix "width"
    /// <summary>
    ///   <para>rdfs:seeAlso : http://www.uniprot.org/manual/binary_interactions^^xsd:anyURI</para>
    ///   <a href="http://purl.uniprot.org/core/xeno">uniprot:xeno</a>
    /// </summary>
    let xeno = _prefixId.prefix "xeno"
