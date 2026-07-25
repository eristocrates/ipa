namespace http.purl.uniprot.org.core.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module unicore =
    let _namespace_iri = Namespace_Iri unicore |> NamespaceIRI

    /// <summary>
    ///   <para>unicore:Evidence_at_Protein_Level_Existence</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>unicore:Protein_Existence</para>
    ///
    /// labels<para>Evidence at protein level</para></remarks>
    /// <seealso href="http://purl.uniprot.org/core/Evidence_at_Protein_Level_Existence">http://purl.uniprot.org/core/Evidence_at_Protein_Level_Existence</seealso>
    let Evidence_at_Protein_Level_Existence =
        Prefixed_Name(unicore, "Evidence_at_Protein_Level_Existence") |> PrefixedName

    /// <summary>
    ///   <para>unicore:Species</para>
    /// </summary>
    /// <remarks>
    ///   <para>unicore:Rank</para>
    ///   <para>owl:Thing</para>
    ///
    /// labels<para>Taxonomic rank Species</para></remarks>
    /// <seealso href="http://purl.uniprot.org/core/Species">http://purl.uniprot.org/core/Species</seealso>
    let Species = Prefixed_Name(unicore, "Species") |> PrefixedName
    /// <summary>
    ///   <para>unicore:Subclass</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>unicore:Rank</para>
    ///
    /// labels<para>Taxonomic rank Subclass</para></remarks>
    /// <seealso href="http://purl.uniprot.org/core/Subclass">http://purl.uniprot.org/core/Subclass</seealso>
    let Subclass = Prefixed_Name(unicore, "Subclass") |> PrefixedName
    /// <summary>
    ///   <para>unicore:Superclass</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>unicore:Rank</para>
    ///
    /// labels<para>Taxonomic rank Superclass</para></remarks>
    /// <seealso href="http://purl.uniprot.org/core/Superclass">http://purl.uniprot.org/core/Superclass</seealso>
    let Superclass = Prefixed_Name(unicore, "Superclass") |> PrefixedName
    /// <summary>
    ///   <para>unicore:Order</para>
    /// </summary>
    /// <remarks>
    ///   <para>unicore:Rank</para>
    ///   <para>owl:Thing</para>
    ///
    /// labels<para>Taxonomy rank Order</para></remarks>
    /// <seealso href="http://purl.uniprot.org/core/Order">http://purl.uniprot.org/core/Order</seealso>
    let Order = Prefixed_Name(unicore, "Order") |> PrefixedName
    /// <summary>
    ///   <para>unicore:Kingdom</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>unicore:Rank</para>
    ///
    /// labels<para>Taxonomy rank Kingdom</para></remarks>
    /// <seealso href="http://purl.uniprot.org/core/Kingdom">http://purl.uniprot.org/core/Kingdom</seealso>
    let Kingdom = Prefixed_Name(unicore, "Kingdom") |> PrefixedName
    /// <summary>
    ///   <para>unicore:Subfamily</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>unicore:Rank</para>
    ///
    /// labels<para>Taxonomic rank Subfamily</para></remarks>
    /// <seealso href="http://purl.uniprot.org/core/Subfamily">http://purl.uniprot.org/core/Subfamily</seealso>
    let Subfamily = Prefixed_Name(unicore, "Subfamily") |> PrefixedName
    /// <summary>
    ///   <para>unicore:Parvorder</para>
    /// </summary>
    /// <remarks>
    ///   <para>unicore:Rank</para>
    ///   <para>owl:Thing</para>
    ///
    /// labels<para>Taxonomy rank Parvorder</para></remarks>
    /// <seealso href="http://purl.uniprot.org/core/Parvorder">http://purl.uniprot.org/core/Parvorder</seealso>
    let Parvorder = Prefixed_Name(unicore, "Parvorder") |> PrefixedName
    /// <summary>
    ///   <para>unicore:Thesis_Citation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A Ph.D. thesis.</para>
    /// labels<para>Thesis Citation</para></remarks>
    /// <seealso href="http://purl.uniprot.org/core/Thesis_Citation">http://purl.uniprot.org/core/Thesis_Citation</seealso>
    let Thesis_Citation = Prefixed_Name(unicore, "Thesis_Citation") |> PrefixedName

    /// <summary>
    ///   <para>unicore:Tissue_Specificity_Annotation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Description of the tissue specificity of a protein.</para>
    /// labels<para>Tissue Specificity</para></remarks>
    /// <seealso href="http://purl.uniprot.org/core/Tissue_Specificity_Annotation">http://purl.uniprot.org/core/Tissue_Specificity_Annotation</seealso>
    let Tissue_Specificity_Annotation =
        Prefixed_Name(unicore, "Tissue_Specificity_Annotation") |> PrefixedName

    /// <summary>
    ///   <para>unicore:Topology</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Topology</para></remarks>
    /// <seealso href="http://purl.uniprot.org/core/Topology">http://purl.uniprot.org/core/Topology</seealso>
    let Topology = Prefixed_Name(unicore, "Topology") |> PrefixedName
    /// <summary>
    ///   <para>unicore:Transcribed_RNA</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Transcribed RNA</para></remarks>
    /// <seealso href="http://purl.uniprot.org/core/Transcribed_RNA">http://purl.uniprot.org/core/Transcribed_RNA</seealso>
    let Transcribed_RNA = Prefixed_Name(unicore, "Transcribed_RNA") |> PrefixedName

    /// <summary>
    ///   <para>unicore:Transcript_Resource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Transcript Resource</para></remarks>
    /// <seealso href="http://purl.uniprot.org/core/Transcript_Resource">http://purl.uniprot.org/core/Transcript_Resource</seealso>
    let Transcript_Resource =
        Prefixed_Name(unicore, "Transcript_Resource") |> PrefixedName

    /// <summary>
    ///   <para>unicore:Transit_Peptide_Annotation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Extent of a transit peptide (mitochondrion, chloroplast, thylakoid, cyanelle or microbody).</para>
    /// labels<para>Transit Peptide</para></remarks>
    /// <seealso href="http://purl.uniprot.org/core/Transit_Peptide_Annotation">http://purl.uniprot.org/core/Transit_Peptide_Annotation</seealso>
    let Transit_Peptide_Annotation =
        Prefixed_Name(unicore, "Transit_Peptide_Annotation") |> PrefixedName

    /// <summary>
    ///   <para>unicore:Fiber_Diffraction</para>
    /// </summary>
    /// <remarks>
    ///   <para>unicore:Structure_Determination_Method</para>
    ///   <para>owl:Thing</para>
    ///
    /// labels<para>Fiber Diffraction</para></remarks>
    /// <seealso href="http://purl.uniprot.org/core/Fiber_Diffraction">http://purl.uniprot.org/core/Fiber_Diffraction</seealso>
    let Fiber_Diffraction = Prefixed_Name(unicore, "Fiber_Diffraction") |> PrefixedName

    /// <summary>
    ///   <para>unicore:Neutron_Diffraction</para>
    /// </summary>
    /// <remarks>
    ///   <para>unicore:Structure_Determination_Method</para>
    ///   <para>owl:Thing</para>
    ///
    /// labels<para>Neutron Diffraction</para></remarks>
    /// <seealso href="http://purl.uniprot.org/core/Neutron_Diffraction">http://purl.uniprot.org/core/Neutron_Diffraction</seealso>
    let Neutron_Diffraction =
        Prefixed_Name(unicore, "Neutron_Diffraction") |> PrefixedName

    /// <summary>
    ///   <para>unicore:Infrared_Spectroscopy</para>
    /// </summary>
    /// <remarks>
    ///   <para>unicore:Structure_Determination_Method</para>
    ///   <para>owl:Thing</para>
    ///   <para>A type of spectroscopy that uses the Infrared portion of the electromagnetic spectrum.</para>
    /// labels<para>Infrared Spectroscopy</para></remarks>
    /// <seealso href="http://purl.uniprot.org/core/Infrared_Spectroscopy">http://purl.uniprot.org/core/Infrared_Spectroscopy</seealso>
    let Infrared_Spectroscopy =
        Prefixed_Name(unicore, "Infrared_Spectroscopy") |> PrefixedName

    /// <summary>
    ///   <para>unicore:Cofactor_Annotation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Description of an enzyme cofactor.</para>
    /// labels<para>Cofactor</para></remarks>
    /// <seealso href="http://purl.uniprot.org/core/Cofactor_Annotation">http://purl.uniprot.org/core/Cofactor_Annotation</seealso>
    let Cofactor_Annotation =
        Prefixed_Name(unicore, "Cofactor_Annotation") |> PrefixedName

    /// <summary>
    ///   <para>unicore:Coiled_Coil_Annotation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Extent of a coiled-coil region.</para>
    /// labels<para>Coiled-Coil</para></remarks>
    /// <seealso href="http://purl.uniprot.org/core/Coiled_Coil_Annotation">http://purl.uniprot.org/core/Coiled_Coil_Annotation</seealso>
    let Coiled_Coil_Annotation =
        Prefixed_Name(unicore, "Coiled_Coil_Annotation") |> PrefixedName

    /// <summary>
    ///   <para>unicore:Concept</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A concept used to classify resources.</para>
    /// labels<para>Concept</para></remarks>
    /// <seealso href="http://purl.uniprot.org/core/Concept">http://purl.uniprot.org/core/Concept</seealso>
    let Concept = Prefixed_Name(unicore, "Concept") |> PrefixedName

    /// <summary>
    ///   <para>unicore:Cross-link_Annotation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Posttranslationally formed amino acid bonds.</para>
    /// labels<para>Crosslink</para></remarks>
    /// <seealso href="http://purl.uniprot.org/core/Cross-link_Annotation">http://purl.uniprot.org/core/Cross-link_Annotation</seealso>
    let Cross_link_Annotation =
        Prefixed_Name(unicore, "Cross-link_Annotation") |> PrefixedName

    /// <summary>
    ///   <para>unicore:DNA</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://purl.uniprot.org/core/DNA">http://purl.uniprot.org/core/DNA</seealso>
    let DNA = Prefixed_Name(unicore, "DNA") |> PrefixedName
    /// <summary>
    ///   <para>unicore:Molecule</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A biological molecule.</para>
    /// </remarks>
    /// <seealso href="http://purl.uniprot.org/core/Molecule">http://purl.uniprot.org/core/Molecule</seealso>
    let Molecule = Prefixed_Name(unicore, "Molecule") |> PrefixedName
    /// <summary>
    ///   <para>unicore:Database</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Metadata for a life science database.</para>
    /// </remarks>
    /// <seealso href="http://purl.uniprot.org/core/Database">http://purl.uniprot.org/core/Database</seealso>
    let Database = Prefixed_Name(unicore, "Database") |> PrefixedName

    /// <summary>
    ///   <para>unicore:Disruption_Phenotype_Annotation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Disruption Phenotype</para></remarks>
    /// <seealso href="http://purl.uniprot.org/core/Disruption_Phenotype_Annotation">http://purl.uniprot.org/core/Disruption_Phenotype_Annotation</seealso>
    let Disruption_Phenotype_Annotation =
        Prefixed_Name(unicore, "Disruption_Phenotype_Annotation") |> PrefixedName

    /// <summary>
    ///   <para>unicore:Domain_Annotation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Description of the domain structure of a protein.</para>
    /// labels<para>Domain</para></remarks>
    /// <seealso href="http://purl.uniprot.org/core/Domain_Annotation">http://purl.uniprot.org/core/Domain_Annotation</seealso>
    let Domain_Annotation = Prefixed_Name(unicore, "Domain_Annotation") |> PrefixedName

    /// <summary>
    ///   <para>unicore:Structure_Determination_Method</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An experimental method for determining the 3D structure of a protein.</para>
    /// labels<para>Structure Determination</para></remarks>
    /// <seealso href="http://purl.uniprot.org/core/Structure_Determination_Method">http://purl.uniprot.org/core/Structure_Determination_Method</seealso>
    let Structure_Determination_Method =
        Prefixed_Name(unicore, "Structure_Determination_Method") |> PrefixedName

    /// <summary>
    ///   <para>unicore:Endpoint_Statement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Metadata for an endpoint of a range on a sequence.</para>
    /// labels<para>Endpoint Statement</para></remarks>
    /// <seealso href="http://purl.uniprot.org/core/Endpoint_Statement">http://purl.uniprot.org/core/Endpoint_Statement</seealso>
    let Endpoint_Statement =
        Prefixed_Name(unicore, "Endpoint_Statement") |> PrefixedName

    /// <summary>
    ///   <para>unicore:replacedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A resource that replaces this resource.</para>
    /// labels<para>replaced by</para></remarks>
    /// <seealso href="http://purl.uniprot.org/core/replacedBy">http://purl.uniprot.org/core/replacedBy</seealso>
    let replacedBy = Prefixed_Name(unicore, "replacedBy") |> PrefixedName

    /// <summary>
    ///   <para>unicore:Redox_Potential_Annotation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Reports the value of the standard (midpoint) oxido-reduction potential(s) for electron transport proteins.</para>
    /// labels<para>Redox Potential</para></remarks>
    /// <seealso href="http://purl.uniprot.org/core/Redox_Potential_Annotation">http://purl.uniprot.org/core/Redox_Potential_Annotation</seealso>
    let Redox_Potential_Annotation =
        Prefixed_Name(unicore, "Redox_Potential_Annotation") |> PrefixedName

    /// <summary>
    ///   <para>unicore:Repeat_Annotation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Extent of an internal sequence repetition.</para>
    /// labels<para>Repeat</para></remarks>
    /// <seealso href="http://purl.uniprot.org/core/Repeat_Annotation">http://purl.uniprot.org/core/Repeat_Annotation</seealso>
    let Repeat_Annotation = Prefixed_Name(unicore, "Repeat_Annotation") |> PrefixedName
    /// <summary>
    ///   <para>unicore:database</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.uniprot.org/core/database">http://purl.uniprot.org/core/database</seealso>
    let database = Prefixed_Name(unicore, "database") |> PrefixedName

    /// <summary>
    ///   <para>unicore:Ribosomal_Frameshifting</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Ribosomal Frameshifting</para></remarks>
    /// <seealso href="http://purl.uniprot.org/core/Ribosomal_Frameshifting">http://purl.uniprot.org/core/Ribosomal_Frameshifting</seealso>
    let Ribosomal_Frameshifting =
        Prefixed_Name(unicore, "Ribosomal_Frameshifting") |> PrefixedName

    /// <summary>
    ///   <para>unicore:Sequence_Conflict_Annotation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Different sources report differing sequences.</para>
    /// labels<para>Sequence Conflict</para></remarks>
    /// <seealso href="http://purl.uniprot.org/core/Sequence_Conflict_Annotation">http://purl.uniprot.org/core/Sequence_Conflict_Annotation</seealso>
    let Sequence_Conflict_Annotation =
        Prefixed_Name(unicore, "Sequence_Conflict_Annotation") |> PrefixedName

    /// <summary>
    ///   <para>unicore:Sequence_Uncertainty_Annotation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Used to describe region(s) of a sequence for which the authors are unsure about the sequence assignment.</para>
    /// labels<para>Unsure Residue</para></remarks>
    /// <seealso href="http://purl.uniprot.org/core/Sequence_Uncertainty_Annotation">http://purl.uniprot.org/core/Sequence_Uncertainty_Annotation</seealso>
    let Sequence_Uncertainty_Annotation =
        Prefixed_Name(unicore, "Sequence_Uncertainty_Annotation") |> PrefixedName

    /// <summary>
    ///   <para>unicore:Signal_Peptide_Annotation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Extent of a signal sequence (prepeptide).</para>
    /// labels<para>Signal Peptide</para></remarks>
    /// <seealso href="http://purl.uniprot.org/core/Signal_Peptide_Annotation">http://purl.uniprot.org/core/Signal_Peptide_Annotation</seealso>
    let Signal_Peptide_Annotation =
        Prefixed_Name(unicore, "Signal_Peptide_Annotation") |> PrefixedName

    /// <summary>
    ///   <para>unicore:Similarity_Annotation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Description of the similarities (sequence or structural) of a protein with other proteins.</para>
    /// labels<para>Similarity</para></remarks>
    /// <seealso href="http://purl.uniprot.org/core/Similarity_Annotation">http://purl.uniprot.org/core/Similarity_Annotation</seealso>
    let Similarity_Annotation =
        Prefixed_Name(unicore, "Similarity_Annotation") |> PrefixedName

    /// <summary>
    ///   <para>unicore:otherName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>other name</para></remarks>
    /// <seealso href="http://purl.uniprot.org/core/otherName">http://purl.uniprot.org/core/otherName</seealso>
    let otherName = Prefixed_Name(unicore, "otherName") |> PrefixedName
    /// <summary>
    ///   <para>unicore:pages</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The first and last page for a chapter or article.</para>
    /// </remarks>
    /// <seealso href="http://purl.uniprot.org/core/pages">http://purl.uniprot.org/core/pages</seealso>
    let pages = Prefixed_Name(unicore, "pages") |> PrefixedName
    /// <summary>
    ///   <para>unicore:partOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.uniprot.org/core/partOf">http://purl.uniprot.org/core/partOf</seealso>
    let partOf = Prefixed_Name(unicore, "partOf") |> PrefixedName
    /// <summary>
    ///   <para>unicore:partOfLineage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>True for taxa that can appear as part of an organism's lineage.</para>
    /// labels<para>part of lineage</para></remarks>
    /// <seealso href="http://purl.uniprot.org/core/partOfLineage">http://purl.uniprot.org/core/partOfLineage</seealso>
    let partOfLineage = Prefixed_Name(unicore, "partOfLineage") |> PrefixedName
    /// <summary>
    ///   <para>unicore:participant</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A protein that participates in a protein-protein interaction.</para>
    /// </remarks>
    /// <seealso href="http://purl.uniprot.org/core/participant">http://purl.uniprot.org/core/participant</seealso>
    let participant = Prefixed_Name(unicore, "participant") |> PrefixedName
    /// <summary>
    ///   <para>unicore:pattern</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>A URL pattern, used to generate links by substituting an identifier.</para>
    /// </remarks>
    /// <seealso href="http://purl.uniprot.org/core/pattern">http://purl.uniprot.org/core/pattern</seealso>
    let pattern = Prefixed_Name(unicore, "pattern") |> PrefixedName
    /// <summary>
    ///   <para>unicore:place</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The place where a publication was published. This usually includes a country name.</para>
    /// </remarks>
    /// <seealso href="http://purl.uniprot.org/core/place">http://purl.uniprot.org/core/place</seealso>
    let place = Prefixed_Name(unicore, "place") |> PrefixedName
    /// <summary>
    ///   <para>unicore:position</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A position on a sequence.</para>
    /// </remarks>
    /// <seealso href="http://purl.uniprot.org/core/position">http://purl.uniprot.org/core/position</seealso>
    let position = Prefixed_Name(unicore, "position") |> PrefixedName
    /// <summary>
    ///   <para>unicore:precursor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.uniprot.org/core/precursor">http://purl.uniprot.org/core/precursor</seealso>
    let precursor = Prefixed_Name(unicore, "precursor") |> PrefixedName
    /// <summary>
    ///   <para>unicore:publisher</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The publisher of a book.</para>
    /// </remarks>
    /// <seealso href="http://purl.uniprot.org/core/publisher">http://purl.uniprot.org/core/publisher</seealso>
    let publisher = Prefixed_Name(unicore, "publisher") |> PrefixedName
    /// <summary>
    ///   <para>unicore:recommendedName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The name recommended by the UniProt consortium.</para>
    /// </remarks>
    /// <seealso href="http://purl.uniprot.org/core/recommendedName">http://purl.uniprot.org/core/recommendedName</seealso>
    let recommendedName = Prefixed_Name(unicore, "recommendedName") |> PrefixedName
    /// <summary>
    ///   <para>unicore:referenceProteome</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.uniprot.org/core/referenceProteome">http://purl.uniprot.org/core/referenceProteome</seealso>
    let referenceProteome = Prefixed_Name(unicore, "referenceProteome") |> PrefixedName
    /// <summary>
    ///   <para>unicore:relatedLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.uniprot.org/core/relatedLocation">http://purl.uniprot.org/core/relatedLocation</seealso>
    let relatedLocation = Prefixed_Name(unicore, "relatedLocation") |> PrefixedName
    /// <summary>
    ///   <para>unicore:representativeFor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:InverseFunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.uniprot.org/core/representativeFor">http://purl.uniprot.org/core/representativeFor</seealso>
    let representativeFor = Prefixed_Name(unicore, "representativeFor") |> PrefixedName
    /// <summary>
    ///   <para>unicore:resolution</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>The resolution of an experiment, in Angstrom.</para>
    /// </remarks>
    /// <seealso href="http://purl.uniprot.org/core/resolution">http://purl.uniprot.org/core/resolution</seealso>
    let resolution = Prefixed_Name(unicore, "resolution") |> PrefixedName
    /// <summary>
    ///   <para>unicore:reviewed</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>Indicates whether a resource has been reviewed by a curator.</para>
    /// </remarks>
    /// <seealso href="http://purl.uniprot.org/core/reviewed">http://purl.uniprot.org/core/reviewed</seealso>
    let reviewed = Prefixed_Name(unicore, "reviewed") |> PrefixedName
    /// <summary>
    ///   <para>unicore:scope</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The extent of the work carried out by the authors of a publication.</para>
    /// </remarks>
    /// <seealso href="http://purl.uniprot.org/core/scope">http://purl.uniprot.org/core/scope</seealso>
    let scope = Prefixed_Name(unicore, "scope") |> PrefixedName
    /// <summary>
    ///   <para>unicore:seedFor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.uniprot.org/core/seedFor">http://purl.uniprot.org/core/seedFor</seealso>
    let seedFor = Prefixed_Name(unicore, "seedFor") |> PrefixedName
    /// <summary>
    ///   <para>unicore:sequenceFor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A resource that describes this sequence.</para>
    /// labels<para>sequence for</para></remarks>
    /// <seealso href="http://purl.uniprot.org/core/sequenceFor">http://purl.uniprot.org/core/sequenceFor</seealso>
    let sequenceFor = Prefixed_Name(unicore, "sequenceFor") |> PrefixedName
    /// <summary>
    ///   <para>unicore:shortName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>An abbreviation of the full name or an acronym.</para>
    /// </remarks>
    /// <seealso href="http://purl.uniprot.org/core/shortName">http://purl.uniprot.org/core/shortName</seealso>
    let shortName = Prefixed_Name(unicore, "shortName") |> PrefixedName
    /// <summary>
    ///   <para>unicore:source</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.uniprot.org/core/source">http://purl.uniprot.org/core/source</seealso>
    let source = Prefixed_Name(unicore, "source") |> PrefixedName
    /// <summary>
    ///   <para>unicore:status</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The reliability of a statement.</para>
    /// </remarks>
    /// <seealso href="http://purl.uniprot.org/core/status">http://purl.uniprot.org/core/status</seealso>
    let status = Prefixed_Name(unicore, "status") |> PrefixedName
    /// <summary>
    ///   <para>unicore:strain</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.uniprot.org/core/strain">http://purl.uniprot.org/core/strain</seealso>
    let strain = Prefixed_Name(unicore, "strain") |> PrefixedName
    /// <summary>
    ///   <para>unicore:submittedName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A name provided by the submitter of the underlying nucleotide sequence.</para>
    /// </remarks>
    /// <seealso href="http://purl.uniprot.org/core/submittedName">http://purl.uniprot.org/core/submittedName</seealso>
    let submittedName = Prefixed_Name(unicore, "submittedName") |> PrefixedName
    /// <summary>
    ///   <para>unicore:substitution</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A replacement sequence.</para>
    /// </remarks>
    /// <seealso href="http://purl.uniprot.org/core/substitution">http://purl.uniprot.org/core/substitution</seealso>
    let substitution = Prefixed_Name(unicore, "substitution") |> PrefixedName
    /// <summary>
    ///   <para>unicore:Class</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>unicore:Rank</para>
    ///
    /// labels<para>Taxonomy rank Class</para></remarks>
    /// <seealso href="http://purl.uniprot.org/core/Class">http://purl.uniprot.org/core/Class</seealso>
    let Class = Prefixed_Name(unicore, "Class") |> PrefixedName
    /// <summary>
    ///   <para>unicore:Genus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>unicore:Rank</para>
    ///
    /// labels<para>Taxonomy rank Genus</para></remarks>
    /// <seealso href="http://purl.uniprot.org/core/Genus">http://purl.uniprot.org/core/Genus</seealso>
    let Genus = Prefixed_Name(unicore, "Genus") |> PrefixedName
    /// <summary>
    ///   <para>unicore:Superorder</para>
    /// </summary>
    /// <remarks>
    ///   <para>unicore:Rank</para>
    ///   <para>owl:Thing</para>
    ///
    /// labels<para>Taxonomic rank Superorder</para></remarks>
    /// <seealso href="http://purl.uniprot.org/core/Superorder">http://purl.uniprot.org/core/Superorder</seealso>
    let Superorder = Prefixed_Name(unicore, "Superorder") |> PrefixedName
    /// <summary>
    ///   <para>unicore:Superkingdom</para>
    /// </summary>
    /// <remarks>
    ///   <para>unicore:Rank</para>
    ///   <para>owl:Thing</para>
    ///
    /// labels<para>Taxonomic rank Superkingdom</para></remarks>
    /// <seealso href="http://purl.uniprot.org/core/Superkingdom">http://purl.uniprot.org/core/Superkingdom</seealso>
    let Superkingdom = Prefixed_Name(unicore, "Superkingdom") |> PrefixedName
    /// <summary>
    ///   <para>unicore:Subphylum</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>unicore:Rank</para>
    ///
    /// labels<para>Taxonomic rank Subphylum</para></remarks>
    /// <seealso href="http://purl.uniprot.org/core/Subphylum">http://purl.uniprot.org/core/Subphylum</seealso>
    let Subphylum = Prefixed_Name(unicore, "Subphylum") |> PrefixedName

    /// <summary>
    ///   <para>unicore:Predicted_Existence</para>
    /// </summary>
    /// <remarks>
    ///   <para>unicore:Protein_Existence</para>
    ///   <para>owl:Thing</para>
    ///   <para>This is used for proteins without evidence at protein, transcript, or homology levels.</para>
    /// labels<para>Predicted</para></remarks>
    /// <seealso href="http://purl.uniprot.org/core/Predicted_Existence">http://purl.uniprot.org/core/Predicted_Existence</seealso>
    let Predicted_Existence =
        Prefixed_Name(unicore, "Predicted_Existence") |> PrefixedName

    /// <summary>
    ///   <para>unicore:Apicoplast</para>
    /// </summary>
    /// <remarks>
    ///   <para>unicore:Organelle</para>
    ///   <para>owl:Thing</para>
    ///
    /// labels<para>Apicoplast</para></remarks>
    /// <seealso href="http://purl.uniprot.org/core/Apicoplast">http://purl.uniprot.org/core/Apicoplast</seealso>
    let Apicoplast = Prefixed_Name(unicore, "Apicoplast") |> PrefixedName
    /// <summary>
    ///   <para>unicore:Organelle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Organelle</para></remarks>
    /// <seealso href="http://purl.uniprot.org/core/Organelle">http://purl.uniprot.org/core/Organelle</seealso>
    let Organelle = Prefixed_Name(unicore, "Organelle") |> PrefixedName

    /// <summary>
    ///   <para>unicore:Binding_Site_Annotation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Binding site for any chemical group (co-enzyme, prosthetic group, etc.).</para>
    /// labels<para>Binding Site</para></remarks>
    /// <seealso href="http://purl.uniprot.org/core/Binding_Site_Annotation">http://purl.uniprot.org/core/Binding_Site_Annotation</seealso>
    let Binding_Site_Annotation =
        Prefixed_Name(unicore, "Binding_Site_Annotation") |> PrefixedName

    /// <summary>
    ///   <para>unicore:Organellar_chromatophore</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>unicore:Organelle</para>
    ///
    /// labels<para>Organellar chromatophore</para></remarks>
    /// <seealso href="http://purl.uniprot.org/core/Organellar_chromatophore">http://purl.uniprot.org/core/Organellar_chromatophore</seealso>
    let Organellar_chromatophore =
        Prefixed_Name(unicore, "Organellar_chromatophore") |> PrefixedName

    /// <summary>
    ///   <para>unicore:Other_DNA</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Other DNA</para></remarks>
    /// <seealso href="http://purl.uniprot.org/core/Other_DNA">http://purl.uniprot.org/core/Other_DNA</seealso>
    let Other_DNA = Prefixed_Name(unicore, "Other_DNA") |> PrefixedName
    /// <summary>
    ///   <para>unicore:Patent_Citation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A patent application.</para>
    /// labels<para>Patent Citation</para></remarks>
    /// <seealso href="http://purl.uniprot.org/core/Patent_Citation">http://purl.uniprot.org/core/Patent_Citation</seealso>
    let Patent_Citation = Prefixed_Name(unicore, "Patent_Citation") |> PrefixedName

    /// <summary>
    ///   <para>unicore:Pharmaceutical_Annotation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Description of the use of a protein as a pharmaceutical drug.</para>
    /// labels<para>Pharmaceutical</para></remarks>
    /// <seealso href="http://purl.uniprot.org/core/Pharmaceutical_Annotation">http://purl.uniprot.org/core/Pharmaceutical_Annotation</seealso>
    let Pharmaceutical_Annotation =
        Prefixed_Name(unicore, "Pharmaceutical_Annotation") |> PrefixedName

    /// <summary>
    ///   <para>unicore:Propeptide_Annotation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Extent of a propeptide.</para>
    /// labels<para>Propeptide</para></remarks>
    /// <seealso href="http://purl.uniprot.org/core/Propeptide_Annotation">http://purl.uniprot.org/core/Propeptide_Annotation</seealso>
    let Propeptide_Annotation =
        Prefixed_Name(unicore, "Propeptide_Annotation") |> PrefixedName

    /// <summary>
    ///   <para>unicore:Protein_Family</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Desription of a set of related proteins.</para>
    /// labels<para>Protein Family</para></remarks>
    /// <seealso href="http://purl.uniprot.org/core/Protein_Family">http://purl.uniprot.org/core/Protein_Family</seealso>
    let Protein_Family = Prefixed_Name(unicore, "Protein_Family") |> PrefixedName

    /// <summary>
    ///   <para>unicore:RNA_Editing_Annotation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Description of any type of RNA editing that leads to one or more amino acid changes.</para>
    /// labels<para>RNA Editing</para></remarks>
    /// <seealso href="http://purl.uniprot.org/core/RNA_Editing_Annotation">http://purl.uniprot.org/core/RNA_Editing_Annotation</seealso>
    let RNA_Editing_Annotation =
        Prefixed_Name(unicore, "RNA_Editing_Annotation") |> PrefixedName

    /// <summary>
    ///   <para>unicore:begin</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>The first position of a range.</para>
    /// </remarks>
    /// <seealso href="http://purl.uniprot.org/core/begin">http://purl.uniprot.org/core/begin</seealso>
    let begin_ = Prefixed_Name(unicore, "begin") |> PrefixedName
    /// <summary>
    ///   <para>unicore:md5Checksum</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.uniprot.org/core/md5Checksum">http://purl.uniprot.org/core/md5Checksum</seealso>
    let md5Checksum = Prefixed_Name(unicore, "md5Checksum") |> PrefixedName
    /// <summary>
    ///   <para>unicore:measuredActivity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The maximum velocity, Vmax.</para>
    /// labels<para>measured activity</para></remarks>
    /// <seealso href="http://purl.uniprot.org/core/measuredActivity">http://purl.uniprot.org/core/measuredActivity</seealso>
    let measuredActivity = Prefixed_Name(unicore, "measuredActivity") |> PrefixedName
    /// <summary>
    ///   <para>unicore:measuredAffinity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The Michaelis-Menten constant, Km.</para>
    /// labels<para>measured affinity</para></remarks>
    /// <seealso href="http://purl.uniprot.org/core/measuredAffinity">http://purl.uniprot.org/core/measuredAffinity</seealso>
    let measuredAffinity = Prefixed_Name(unicore, "measuredAffinity") |> PrefixedName
    /// <summary>
    ///   <para>unicore:measuredError</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>The magnitude of the error of a value that was measured.</para>
    /// labels<para>measured error</para></remarks>
    /// <seealso href="http://purl.uniprot.org/core/measuredError">http://purl.uniprot.org/core/measuredError</seealso>
    let measuredError = Prefixed_Name(unicore, "measuredError") |> PrefixedName
    /// <summary>
    ///   <para>unicore:Suborder</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>unicore:Rank</para>
    ///
    /// labels<para>Taxonomic rank Suborder</para></remarks>
    /// <seealso href="http://purl.uniprot.org/core/Suborder">http://purl.uniprot.org/core/Suborder</seealso>
    let Suborder = Prefixed_Name(unicore, "Suborder") |> PrefixedName
    /// <summary>
    ///   <para>unicore:Phylum</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>unicore:Rank</para>
    ///
    /// labels<para>Taxonomy rank Phylum</para></remarks>
    /// <seealso href="http://purl.uniprot.org/core/Phylum">http://purl.uniprot.org/core/Phylum</seealso>
    let Phylum = Prefixed_Name(unicore, "Phylum") |> PrefixedName
    /// <summary>
    ///   <para>unicore:Experimental</para>
    /// </summary>
    /// <remarks>
    ///   <para>unicore:Status</para>
    ///   <para>owl:Thing</para>
    ///
    /// labels<para>Indicates that there is some experimental evidence that the given annotation could apply.</para></remarks>
    /// <seealso href="http://purl.uniprot.org/core/Experimental">http://purl.uniprot.org/core/Experimental</seealso>
    let Experimental = Prefixed_Name(unicore, "Experimental") |> PrefixedName
    /// <summary>
    ///   <para>unicore:Genomic_RNA</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Genomic RNA</para></remarks>
    /// <seealso href="http://purl.uniprot.org/core/Genomic_RNA">http://purl.uniprot.org/core/Genomic_RNA</seealso>
    let Genomic_RNA = Prefixed_Name(unicore, "Genomic_RNA") |> PrefixedName
    /// <summary>
    ///   <para>unicore:Structured_Name</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A resource that holds a set of the known names for this protein together.</para>
    /// </remarks>
    /// <seealso href="http://purl.uniprot.org/core/Structured_Name">http://purl.uniprot.org/core/Structured_Name</seealso>
    let Structured_Name = Prefixed_Name(unicore, "Structured_Name") |> PrefixedName

    /// <summary>
    ///   <para>unicore:Subcellular_Location_Annotation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Description of the subcellular location of the mature protein.</para>
    /// labels<para>Subcellular Location</para></remarks>
    /// <seealso href="http://purl.uniprot.org/core/Subcellular_Location_Annotation">http://purl.uniprot.org/core/Subcellular_Location_Annotation</seealso>
    let Subcellular_Location_Annotation =
        Prefixed_Name(unicore, "Subcellular_Location_Annotation") |> PrefixedName

    /// <summary>
    ///   <para>unicore:Submission_Citation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Data that was submitted directly to a database.</para>
    /// labels<para>Submission Citation</para></remarks>
    /// <seealso href="http://purl.uniprot.org/core/Submission_Citation">http://purl.uniprot.org/core/Submission_Citation</seealso>
    let Submission_Citation =
        Prefixed_Name(unicore, "Submission_Citation") |> PrefixedName

    /// <summary>
    ///   <para>unicore:mnemonic</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A easy to remember identifier for a UniProtKB entry, but it is not a stable identifier and should not be used by programs to identify entries.</para>
    /// </remarks>
    /// <seealso href="http://purl.uniprot.org/core/mnemonic">http://purl.uniprot.org/core/mnemonic</seealso>
    let mnemonic = Prefixed_Name(unicore, "mnemonic") |> PrefixedName

    /// <summary>
    ///   <para>unicore:Temperature_Dependence_Annotation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Indicates the optimum temperature for enzyme activity and/or the variation of enzyme activity with temperature variation; the thermostability/thermolability of the enzyme is also mentioned when it is known.</para>
    /// labels<para>Temperature Dependence</para></remarks>
    /// <seealso href="http://purl.uniprot.org/core/Temperature_Dependence_Annotation">http://purl.uniprot.org/core/Temperature_Dependence_Annotation</seealso>
    let Temperature_Dependence_Annotation =
        Prefixed_Name(unicore, "Temperature_Dependence_Annotation") |> PrefixedName

    /// <summary>
    ///   <para>unicore:institution</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The institution at which a thesis was written.</para>
    /// </remarks>
    /// <seealso href="http://purl.uniprot.org/core/institution">http://purl.uniprot.org/core/institution</seealso>
    let institution = Prefixed_Name(unicore, "institution") |> PrefixedName
    /// <summary>
    ///   <para>unicore:Subspecies</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>unicore:Rank</para>
    ///
    /// labels<para>Taxonomic rank Subspecies</para></remarks>
    /// <seealso href="http://purl.uniprot.org/core/Subspecies">http://purl.uniprot.org/core/Subspecies</seealso>
    let Subspecies = Prefixed_Name(unicore, "Subspecies") |> PrefixedName
    /// <summary>
    ///   <para>unicore:Varietas</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>unicore:Rank</para>
    ///
    /// labels<para>Taxonomic rank Varietas</para></remarks>
    /// <seealso href="http://purl.uniprot.org/core/Varietas">http://purl.uniprot.org/core/Varietas</seealso>
    let Varietas = Prefixed_Name(unicore, "Varietas") |> PrefixedName
    /// <summary>
    ///   <para>unicore:NotObsoleteTaxon</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://purl.uniprot.org/core/NotObsoleteTaxon">http://purl.uniprot.org/core/NotObsoleteTaxon</seealso>
    let NotObsoleteTaxon = Prefixed_Name(unicore, "NotObsoleteTaxon") |> PrefixedName
    /// <summary>
    ///   <para>unicore:commonName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///
    /// labels<para>common name</para></remarks>
    /// <seealso href="http://purl.uniprot.org/core/commonName">http://purl.uniprot.org/core/commonName</seealso>
    let commonName = Prefixed_Name(unicore, "commonName") |> PrefixedName
    /// <summary>
    ///   <para>unicore:LSIMS</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>unicore:Mass_Measurement_Method</para>
    ///
    /// labels<para>Liquid Secondary Ionization</para></remarks>
    /// <seealso href="http://purl.uniprot.org/core/LSIMS">http://purl.uniprot.org/core/LSIMS</seealso>
    let LSIMS = Prefixed_Name(unicore, "LSIMS") |> PrefixedName

    /// <summary>
    ///   <para>unicore:PH_Dependence_Annotation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Describes the optimum pH for enzyme activity and/or the variation of enzyme activity with pH variation.</para>
    /// labels<para>pH Dependence</para></remarks>
    /// <seealso href="http://purl.uniprot.org/core/PH_Dependence_Annotation">http://purl.uniprot.org/core/PH_Dependence_Annotation</seealso>
    let PH_Dependence_Annotation =
        Prefixed_Name(unicore, "PH_Dependence_Annotation") |> PrefixedName

    /// <summary>
    ///   <para>unicore:Part</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Description of a part of a protein.</para>
    /// </remarks>
    /// <seealso href="http://purl.uniprot.org/core/Part">http://purl.uniprot.org/core/Part</seealso>
    let Part = Prefixed_Name(unicore, "Part") |> PrefixedName
    /// <summary>
    ///   <para>unicore:FAB</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>unicore:Mass_Measurement_Method</para>
    ///
    /// labels<para>Fast Atom Bombardment</para></remarks>
    /// <seealso href="http://purl.uniprot.org/core/FAB">http://purl.uniprot.org/core/FAB</seealso>
    let FAB = Prefixed_Name(unicore, "FAB") |> PrefixedName
    /// <summary>
    ///   <para>unicore:API</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>unicore:Mass_Measurement_Method</para>
    ///   <para>Mass measurement using Atmospheric Pressure Ionization</para>
    /// labels<para>Atmospheric Pressure Ionization</para></remarks>
    /// <seealso href="http://purl.uniprot.org/core/API">http://purl.uniprot.org/core/API</seealso>
    let API = Prefixed_Name(unicore, "API") |> PrefixedName
    /// <summary>
    ///   <para>unicore:Range</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A range of amino acids on a protein  sequence.</para>
    /// </remarks>
    /// <seealso href="http://purl.uniprot.org/core/Range">http://purl.uniprot.org/core/Range</seealso>
    let Range = Prefixed_Name(unicore, "Range") |> PrefixedName
    /// <summary>
    ///   <para>unicore:Protein</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Description of a protein.</para>
    /// labels<para>Protein</para></remarks>
    /// <seealso href="http://purl.uniprot.org/core/Protein">http://purl.uniprot.org/core/Protein</seealso>
    let Protein = Prefixed_Name(unicore, "Protein") |> PrefixedName
    /// <summary>
    ///   <para>unicore:Tissue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A tissue such as lung or heart.</para>
    /// labels<para>Tissue</para></remarks>
    /// <seealso href="http://purl.uniprot.org/core/Tissue">http://purl.uniprot.org/core/Tissue</seealso>
    let Tissue = Prefixed_Name(unicore, "Tissue") |> PrefixedName
    /// <summary>
    ///   <para>unicore:context</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.uniprot.org/core/context">http://purl.uniprot.org/core/context</seealso>
    let context = Prefixed_Name(unicore, "context") |> PrefixedName
    /// <summary>
    ///   <para>unicore:PD</para>
    /// </summary>
    /// <remarks>
    ///   <para>unicore:Mass_Measurement_Method</para>
    ///   <para>owl:Thing</para>
    ///   <para></para>
    /// labels<para>Plasma Desorption</para></remarks>
    /// <seealso href="http://purl.uniprot.org/core/PD">http://purl.uniprot.org/core/PD</seealso>
    let PD = Prefixed_Name(unicore, "PD") |> PrefixedName
    /// <summary>
    ///   <para>unicore:SELDI</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>unicore:Mass_Measurement_Method</para>
    ///
    /// labels<para>Surface Enhanced Laser Desorption Ionization</para></remarks>
    /// <seealso href="http://purl.uniprot.org/core/SELDI">http://purl.uniprot.org/core/SELDI</seealso>
    let SELDI = Prefixed_Name(unicore, "SELDI") |> PrefixedName
    /// <summary>
    ///   <para>unicore:ESI</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>unicore:Mass_Measurement_Method</para>
    ///
    /// labels<para>Electrospray Ionization</para></remarks>
    /// <seealso href="http://purl.uniprot.org/core/ESI">http://purl.uniprot.org/core/ESI</seealso>
    let ESI = Prefixed_Name(unicore, "ESI") |> PrefixedName
    /// <summary>
    ///   <para>unicore:Prediction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>unicore:Structure_Determination_Method</para>
    ///
    /// labels<para>Prediction</para></remarks>
    /// <seealso href="http://purl.uniprot.org/core/Prediction">http://purl.uniprot.org/core/Prediction</seealso>
    let Prediction = Prefixed_Name(unicore, "Prediction") |> PrefixedName

    /// <summary>
    ///   <para>unicore:X-Ray_Crystallography</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>unicore:Structure_Determination_Method</para>
    ///   <para>A technique in crystallography in which the pattern produced by the diffraction of x-rays through the closely spaced lattice of atoms in a crystal is recorded and then analyzed to reveal the nature of that lattice.</para>
    /// labels<para>X-Ray Crystallography</para></remarks>
    /// <seealso href="http://purl.uniprot.org/core/X-Ray_Crystallography">http://purl.uniprot.org/core/X-Ray_Crystallography</seealso>
    let X_Ray_Crystallography =
        Prefixed_Name(unicore, "X-Ray_Crystallography") |> PrefixedName

    /// <summary>
    ///   <para>unicore:Electron_Microscopy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>unicore:Structure_Determination_Method</para>
    ///   <para>The electron microscope is a microscope that can magnify very small details with high resolving power due to the use of electrons rather than light to scatter off material, magnifying at levels up to 500,000 times.</para>
    /// labels<para>Electron Microscopy</para></remarks>
    /// <seealso href="http://purl.uniprot.org/core/Electron_Microscopy">http://purl.uniprot.org/core/Electron_Microscopy</seealso>
    let Electron_Microscopy =
        Prefixed_Name(unicore, "Electron_Microscopy") |> PrefixedName

    /// <summary>
    ///   <para>unicore:end</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The last position of a range.</para>
    /// </remarks>
    /// <seealso href="http://purl.uniprot.org/core/end">http://purl.uniprot.org/core/end</seealso>
    let end_ = Prefixed_Name(unicore, "end") |> PrefixedName
    /// <summary>
    ///   <para>unicore:MALDI</para>
    /// </summary>
    /// <remarks>
    ///   <para>unicore:Mass_Measurement_Method</para>
    ///   <para>owl:Thing</para>
    ///
    /// labels<para>Matrix-Assisted Laser Desorption</para></remarks>
    /// <seealso href="http://purl.uniprot.org/core/MALDI">http://purl.uniprot.org/core/MALDI</seealso>
    let MALDI = Prefixed_Name(unicore, "MALDI") |> PrefixedName
    /// <summary>
    ///   <para>unicore:enzyme</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The catalytic activity associated with a protein. or part of a protein.</para>
    /// labels<para>enzyme</para></remarks>
    /// <seealso href="http://purl.uniprot.org/core/enzyme">http://purl.uniprot.org/core/enzyme</seealso>
    let enzyme = Prefixed_Name(unicore, "enzyme") |> PrefixedName
    /// <summary>
    ///   <para>unicore:Sequence</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An amino acid sequence.</para>
    /// </remarks>
    /// <seealso href="http://purl.uniprot.org/core/Sequence">http://purl.uniprot.org/core/Sequence</seealso>
    let Sequence = Prefixed_Name(unicore, "Sequence") |> PrefixedName

    /// <summary>
    ///   <para>unicore:Citation_Statement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The relationship between a resource and a citation.</para>
    /// labels<para>Citation Statement</para></remarks>
    /// <seealso href="http://purl.uniprot.org/core/Citation_Statement">http://purl.uniprot.org/core/Citation_Statement</seealso>
    let Citation_Statement =
        Prefixed_Name(unicore, "Citation_Statement") |> PrefixedName

    /// <summary>
    ///   <para>unicore:Strain</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A strain of a species.</para>
    /// labels<para>Strain</para></remarks>
    /// <seealso href="http://purl.uniprot.org/core/Strain">http://purl.uniprot.org/core/Strain</seealso>
    let Strain = Prefixed_Name(unicore, "Strain") |> PrefixedName
    /// <summary>
    ///   <para>unicore:Transposon</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A transposon</para>
    /// labels<para>Transposon</para></remarks>
    /// <seealso href="http://purl.uniprot.org/core/Transposon">http://purl.uniprot.org/core/Transposon</seealso>
    let Transposon = Prefixed_Name(unicore, "Transposon") |> PrefixedName
    /// <summary>
    ///   <para>unicore:Rank</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A rank of a taxon.</para>
    /// </remarks>
    /// <seealso href="http://purl.uniprot.org/core/Rank">http://purl.uniprot.org/core/Rank</seealso>
    let Rank = Prefixed_Name(unicore, "Rank") |> PrefixedName
    /// <summary>
    ///   <para>unicore:Cluster</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Cluster of proteins with similar sequences.</para>
    /// </remarks>
    /// <seealso href="http://purl.uniprot.org/core/Cluster">http://purl.uniprot.org/core/Cluster</seealso>
    let Cluster = Prefixed_Name(unicore, "Cluster") |> PrefixedName
    /// <summary>
    ///   <para>unicore:member</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>One of several similar resources.</para>
    /// </remarks>
    /// <seealso href="http://purl.uniprot.org/core/member">http://purl.uniprot.org/core/member</seealso>
    let member_ = Prefixed_Name(unicore, "member") |> PrefixedName

    /// <summary>
    ///   <para>unicore:Compositional_Bias_Annotation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Extent of a compositionally biased region.</para>
    /// labels<para>Compositionally Biased Region</para></remarks>
    /// <seealso href="http://purl.uniprot.org/core/Compositional_Bias_Annotation">http://purl.uniprot.org/core/Compositional_Bias_Annotation</seealso>
    let Compositional_Bias_Annotation =
        Prefixed_Name(unicore, "Compositional_Bias_Annotation") |> PrefixedName

    /// <summary>
    ///   <para>unicore:replaces</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A resource that is replaced by this resource.</para>
    /// </remarks>
    /// <seealso href="http://purl.uniprot.org/core/replaces">http://purl.uniprot.org/core/replaces</seealso>
    let replaces = Prefixed_Name(unicore, "replaces") |> PrefixedName

    /// <summary>
    ///   <para>unicore:Modification_Annotation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Describes amino acid modifications, post pre- and post-translational.</para>
    /// labels<para>Modification</para></remarks>
    /// <seealso href="http://purl.uniprot.org/core/Modification_Annotation">http://purl.uniprot.org/core/Modification_Annotation</seealso>
    let Modification_Annotation =
        Prefixed_Name(unicore, "Modification_Annotation") |> PrefixedName

    /// <summary>
    ///   <para>unicore:Cyanelle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>unicore:Organelle</para>
    ///
    /// labels<para>Cyanelle</para></remarks>
    /// <seealso href="http://purl.uniprot.org/core/Cyanelle">http://purl.uniprot.org/core/Cyanelle</seealso>
    let Cyanelle = Prefixed_Name(unicore, "Cyanelle") |> PrefixedName

    /// <summary>
    ///   <para>unicore:Developmental_Stage_Annotation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Description of the developmentally-specific expression of a protein.</para>
    /// labels<para>Developmental Stage</para></remarks>
    /// <seealso href="http://purl.uniprot.org/core/Developmental_Stage_Annotation">http://purl.uniprot.org/core/Developmental_Stage_Annotation</seealso>
    let Developmental_Stage_Annotation =
        Prefixed_Name(unicore, "Developmental_Stage_Annotation") |> PrefixedName

    /// <summary>
    ///   <para>unicore:Disease_Annotation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Description of the diseases associated with a deficiency of a protein.</para>
    /// labels<para>Disease</para></remarks>
    /// <seealso href="http://purl.uniprot.org/core/Disease_Annotation">http://purl.uniprot.org/core/Disease_Annotation</seealso>
    let Disease_Annotation =
        Prefixed_Name(unicore, "Disease_Annotation") |> PrefixedName

    /// <summary>
    ///   <para>unicore:Disulfide_Bond_Annotation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Describes residues which are linked by an intra-chain disulfide bond. If the endpoints are identical, the disulfide bond is an interchain one.</para>
    /// labels<para>Disulfide Bond</para></remarks>
    /// <seealso href="http://purl.uniprot.org/core/Disulfide_Bond_Annotation">http://purl.uniprot.org/core/Disulfide_Bond_Annotation</seealso>
    let Disulfide_Bond_Annotation =
        Prefixed_Name(unicore, "Disulfide_Bond_Annotation") |> PrefixedName

    /// <summary>
    ///   <para>unicore:Domain_Assignment_Statement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The relationship between a protein and a protein domain.</para>
    /// labels<para>Domain Assignment Statement</para></remarks>
    /// <seealso href="http://purl.uniprot.org/core/Domain_Assignment_Statement">http://purl.uniprot.org/core/Domain_Assignment_Statement</seealso>
    let Domain_Assignment_Statement =
        Prefixed_Name(unicore, "Domain_Assignment_Statement") |> PrefixedName

    /// <summary>
    ///   <para>unicore:Domain_Extent_Annotation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Extent of a domain, which is defined as a specific combination of secondary structures organized into a characteristic three-dimensional structure or fold.</para>
    /// labels<para>Domain Extent</para></remarks>
    /// <seealso href="http://purl.uniprot.org/core/Domain_Extent_Annotation">http://purl.uniprot.org/core/Domain_Extent_Annotation</seealso>
    let Domain_Extent_Annotation =
        Prefixed_Name(unicore, "Domain_Extent_Annotation") |> PrefixedName

    /// <summary>
    ///   <para>unicore:Electronic_Citation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An electronic publication.</para>
    /// labels<para>Electronic Citation</para></remarks>
    /// <seealso href="http://purl.uniprot.org/core/Electronic_Citation">http://purl.uniprot.org/core/Electronic_Citation</seealso>
    let Electronic_Citation =
        Prefixed_Name(unicore, "Electronic_Citation") |> PrefixedName

    /// <summary>
    ///   <para>unicore:Enzyme</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A specific catalytic activity, defined by the Enzyme Commission of the Nomenclature Committee of the International Union of Biochemistry and Molecular Biology (IUBMB).</para>
    /// labels<para>Enzyme</para></remarks>
    /// <seealso href="http://purl.uniprot.org/core/Enzyme">http://purl.uniprot.org/core/Enzyme</seealso>
    let Enzyme = Prefixed_Name(unicore, "Enzyme") |> PrefixedName

    /// <summary>
    ///   <para>unicore:Enzyme_Regulation_Annotation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Description of an enzyme regulatory mechanism.</para>
    /// labels<para>Enzyme Regulation</para></remarks>
    /// <seealso href="http://purl.uniprot.org/core/Enzyme_Regulation_Annotation">http://purl.uniprot.org/core/Enzyme_Regulation_Annotation</seealso>
    let Enzyme_Regulation_Annotation =
        Prefixed_Name(unicore, "Enzyme_Regulation_Annotation") |> PrefixedName

    /// <summary>
    ///   <para>unicore:Erroneous_Gene_Model_Prediction_Annotation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Erroneous Gene Model Prediction</para></remarks>
    /// <seealso href="http://purl.uniprot.org/core/Erroneous_Gene_Model_Prediction_Annotation">http://purl.uniprot.org/core/Erroneous_Gene_Model_Prediction_Annotation</seealso>
    let Erroneous_Gene_Model_Prediction_Annotation =
        Prefixed_Name(unicore, "Erroneous_Gene_Model_Prediction_Annotation") |> PrefixedName

    /// <summary>
    ///   <para>unicore:Sequence_Caution_Annotation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Warning about possible errors related to the protein sequence</para>
    /// labels<para>Sequence Caution</para></remarks>
    /// <seealso href="http://purl.uniprot.org/core/Sequence_Caution_Annotation">http://purl.uniprot.org/core/Sequence_Caution_Annotation</seealso>
    let Sequence_Caution_Annotation =
        Prefixed_Name(unicore, "Sequence_Caution_Annotation") |> PrefixedName

    /// <summary>
    ///   <para>unicore:Erroneous_Initiation_Annotation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Erroneous Initiation</para></remarks>
    /// <seealso href="http://purl.uniprot.org/core/Erroneous_Initiation_Annotation">http://purl.uniprot.org/core/Erroneous_Initiation_Annotation</seealso>
    let Erroneous_Initiation_Annotation =
        Prefixed_Name(unicore, "Erroneous_Initiation_Annotation") |> PrefixedName

    /// <summary>
    ///   <para>unicore:Erroneous_Termination_Annotation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Erroneous Termination</para></remarks>
    /// <seealso href="http://purl.uniprot.org/core/Erroneous_Termination_Annotation">http://purl.uniprot.org/core/Erroneous_Termination_Annotation</seealso>
    let Erroneous_Termination_Annotation =
        Prefixed_Name(unicore, "Erroneous_Termination_Annotation") |> PrefixedName

    /// <summary>
    ///   <para>unicore:Erroneous_Translation_Annotation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Erroneous Translation</para></remarks>
    /// <seealso href="http://purl.uniprot.org/core/Erroneous_Translation_Annotation">http://purl.uniprot.org/core/Erroneous_Translation_Annotation</seealso>
    let Erroneous_Translation_Annotation =
        Prefixed_Name(unicore, "Erroneous_Translation_Annotation") |> PrefixedName

    /// <summary>
    ///   <para>unicore:Protein_Existence</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://purl.uniprot.org/core/Protein_Existence">http://purl.uniprot.org/core/Protein_Existence</seealso>
    let Protein_Existence = Prefixed_Name(unicore, "Protein_Existence") |> PrefixedName

    /// <summary>
    ///   <para>unicore:Experimental_Information_Annotation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Experimental Information</para></remarks>
    /// <seealso href="http://purl.uniprot.org/core/Experimental_Information_Annotation">http://purl.uniprot.org/core/Experimental_Information_Annotation</seealso>
    let Experimental_Information_Annotation =
        Prefixed_Name(unicore, "Experimental_Information_Annotation") |> PrefixedName

    /// <summary>
    ///   <para>unicore:Sequence_Annotation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Description of a special region or site in a protein sequence.</para>
    /// labels<para>Sequence Annotation</para></remarks>
    /// <seealso href="http://purl.uniprot.org/core/Sequence_Annotation">http://purl.uniprot.org/core/Sequence_Annotation</seealso>
    let Sequence_Annotation =
        Prefixed_Name(unicore, "Sequence_Annotation") |> PrefixedName

    /// <summary>
    ///   <para>unicore:External_Sequence</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The protein described in the linked record is an alternative splice form of the same gene product as described in this record. The function between the two isoforms is highly divergent.</para>
    /// labels<para>External Sequence</para></remarks>
    /// <seealso href="http://purl.uniprot.org/core/External_Sequence">http://purl.uniprot.org/core/External_Sequence</seealso>
    let External_Sequence = Prefixed_Name(unicore, "External_Sequence") |> PrefixedName
    /// <summary>
    ///   <para>unicore:Known_Sequence</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Known Sequence</para></remarks>
    /// <seealso href="http://purl.uniprot.org/core/Known_Sequence">http://purl.uniprot.org/core/Known_Sequence</seealso>
    let Known_Sequence = Prefixed_Name(unicore, "Known_Sequence") |> PrefixedName

    /// <summary>
    ///   <para>unicore:Family_Membership_Statement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The relationship between a protein and a protein family.</para>
    /// labels<para>Family Membership Statement</para></remarks>
    /// <seealso href="http://purl.uniprot.org/core/Family_Membership_Statement">http://purl.uniprot.org/core/Family_Membership_Statement</seealso>
    let Family_Membership_Statement =
        Prefixed_Name(unicore, "Family_Membership_Statement") |> PrefixedName

    /// <summary>
    ///   <para>unicore:Frameshift_Annotation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Frameshift</para></remarks>
    /// <seealso href="http://purl.uniprot.org/core/Frameshift_Annotation">http://purl.uniprot.org/core/Frameshift_Annotation</seealso>
    let Frameshift_Annotation =
        Prefixed_Name(unicore, "Frameshift_Annotation") |> PrefixedName

    /// <summary>
    ///   <para>unicore:Gene</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://purl.uniprot.org/core/Gene">http://purl.uniprot.org/core/Gene</seealso>
    let Gene = Prefixed_Name(unicore, "Gene") |> PrefixedName
    /// <summary>
    ///   <para>unicore:RNA</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://purl.uniprot.org/core/RNA">http://purl.uniprot.org/core/RNA</seealso>
    let RNA = Prefixed_Name(unicore, "RNA") |> PrefixedName

    /// <summary>
    ///   <para>unicore:Glycosylation_Annotation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Describes the occurrence of the attachment of a glycan (mono- or polysaccharide) to a residue of a protein.</para>
    /// labels<para>Glycosylation Site</para></remarks>
    /// <seealso href="http://purl.uniprot.org/core/Glycosylation_Annotation">http://purl.uniprot.org/core/Glycosylation_Annotation</seealso>
    let Glycosylation_Annotation =
        Prefixed_Name(unicore, "Glycosylation_Annotation") |> PrefixedName

    /// <summary>
    ///   <para>unicore:Helix_Annotation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Helical regions within the experimentally determined protein structure</para>
    /// labels<para>Helix</para></remarks>
    /// <seealso href="http://purl.uniprot.org/core/Helix_Annotation">http://purl.uniprot.org/core/Helix_Annotation</seealso>
    let Helix_Annotation = Prefixed_Name(unicore, "Helix_Annotation") |> PrefixedName

    /// <summary>
    ///   <para>unicore:Induction_Annotation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Description of the compounds or conditions that stimulate the synthesis of a protein.</para>
    /// labels<para>Induction</para></remarks>
    /// <seealso href="http://purl.uniprot.org/core/Induction_Annotation">http://purl.uniprot.org/core/Induction_Annotation</seealso>
    let Induction_Annotation =
        Prefixed_Name(unicore, "Induction_Annotation") |> PrefixedName

    /// <summary>
    ///   <para>unicore:Infraclass</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>unicore:Rank</para>
    ///
    /// labels<para>Taxonomy rank Infraclass</para></remarks>
    /// <seealso href="http://purl.uniprot.org/core/Infraclass">http://purl.uniprot.org/core/Infraclass</seealso>
    let Infraclass = Prefixed_Name(unicore, "Infraclass") |> PrefixedName
    /// <summary>
    ///   <para>unicore:Infraorder</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>unicore:Rank</para>
    ///
    /// labels<para>Taxonomy rank Infraorder</para></remarks>
    /// <seealso href="http://purl.uniprot.org/core/Infraorder">http://purl.uniprot.org/core/Infraorder</seealso>
    let Infraorder = Prefixed_Name(unicore, "Infraorder") |> PrefixedName
    /// <summary>
    ///   <para>unicore:Interaction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Description of a protein-protein interaction.</para>
    /// </remarks>
    /// <seealso href="http://purl.uniprot.org/core/Interaction">http://purl.uniprot.org/core/Interaction</seealso>
    let Interaction = Prefixed_Name(unicore, "Interaction") |> PrefixedName

    /// <summary>
    ///   <para>unicore:Intramembrane_Annotation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Extent of a region located in a membrane without crossing it</para>
    /// labels<para>INTRAMEM</para></remarks>
    /// <seealso href="http://purl.uniprot.org/core/Intramembrane_Annotation">http://purl.uniprot.org/core/Intramembrane_Annotation</seealso>
    let Intramembrane_Annotation =
        Prefixed_Name(unicore, "Intramembrane_Annotation") |> PrefixedName

    /// <summary>
    ///   <para>unicore:Journal_Citation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An article published in a journal.</para>
    /// labels<para>Journal Citation</para></remarks>
    /// <seealso href="http://purl.uniprot.org/core/Journal_Citation">http://purl.uniprot.org/core/Journal_Citation</seealso>
    let Journal_Citation = Prefixed_Name(unicore, "Journal_Citation") |> PrefixedName

    /// <summary>
    ///   <para>unicore:Kinetics_Annotation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Mentions the Michaelis-Menten constant (KM) and maximal velocity (Vmax) of enzymes.</para>
    /// labels<para>Kinetics</para></remarks>
    /// <seealso href="http://purl.uniprot.org/core/Kinetics_Annotation">http://purl.uniprot.org/core/Kinetics_Annotation</seealso>
    let Kinetics_Annotation =
        Prefixed_Name(unicore, "Kinetics_Annotation") |> PrefixedName

    /// <summary>
    ///   <para>unicore:Lipidation_Annotation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Covalent binding of a lipid moiety.</para>
    /// labels<para>Lipid Binding</para></remarks>
    /// <seealso href="http://purl.uniprot.org/core/Lipidation_Annotation">http://purl.uniprot.org/core/Lipidation_Annotation</seealso>
    let Lipidation_Annotation =
        Prefixed_Name(unicore, "Lipidation_Annotation") |> PrefixedName

    /// <summary>
    ///   <para>unicore:MRNA</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>mRNA</para></remarks>
    /// <seealso href="http://purl.uniprot.org/core/MRNA">http://purl.uniprot.org/core/MRNA</seealso>
    let MRNA = Prefixed_Name(unicore, "MRNA") |> PrefixedName
    /// <summary>
    ///   <para>unicore:Method</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An experimental method.</para>
    /// </remarks>
    /// <seealso href="http://purl.uniprot.org/core/Method">http://purl.uniprot.org/core/Method</seealso>
    let Method = Prefixed_Name(unicore, "Method") |> PrefixedName

    /// <summary>
    ///   <para>unicore:Mass_Spectrometry_Annotation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Indicates the mass of a sequence determined by mass spectrometry.</para>
    /// labels<para>Mass</para></remarks>
    /// <seealso href="http://purl.uniprot.org/core/Mass_Spectrometry_Annotation">http://purl.uniprot.org/core/Mass_Spectrometry_Annotation</seealso>
    let Mass_Spectrometry_Annotation =
        Prefixed_Name(unicore, "Mass_Spectrometry_Annotation") |> PrefixedName

    /// <summary>
    ///   <para>unicore:method</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The experimental method that was used.</para>
    /// </remarks>
    /// <seealso href="http://purl.uniprot.org/core/method">http://purl.uniprot.org/core/method</seealso>
    let method = Prefixed_Name(unicore, "method") |> PrefixedName

    /// <summary>
    ///   <para>unicore:Metal_Binding_Annotation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Binding site for a metal ion.</para>
    /// labels<para>Metal Ion Binding Site</para></remarks>
    /// <seealso href="http://purl.uniprot.org/core/Metal_Binding_Annotation">http://purl.uniprot.org/core/Metal_Binding_Annotation</seealso>
    let Metal_Binding_Annotation =
        Prefixed_Name(unicore, "Metal_Binding_Annotation") |> PrefixedName

    /// <summary>
    ///   <para>unicore:Modified_Residue_Annotation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Posttranslational modification of a residue.</para>
    /// labels<para>Modified Residue</para></remarks>
    /// <seealso href="http://purl.uniprot.org/core/Modified_Residue_Annotation">http://purl.uniprot.org/core/Modified_Residue_Annotation</seealso>
    let Modified_Residue_Annotation =
        Prefixed_Name(unicore, "Modified_Residue_Annotation") |> PrefixedName

    /// <summary>
    ///   <para>unicore:Modified_Sequence</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Modified Sequence</para></remarks>
    /// <seealso href="http://purl.uniprot.org/core/Modified_Sequence">http://purl.uniprot.org/core/Modified_Sequence</seealso>
    let Modified_Sequence = Prefixed_Name(unicore, "Modified_Sequence") |> PrefixedName
    /// <summary>
    ///   <para>unicore:modification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A modification of a sequence.</para>
    /// </remarks>
    /// <seealso href="http://purl.uniprot.org/core/modification">http://purl.uniprot.org/core/modification</seealso>
    let modification = Prefixed_Name(unicore, "modification") |> PrefixedName
    /// <summary>
    ///   <para>unicore:Simple_Sequence</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Simple Sequence</para></remarks>
    /// <seealso href="http://purl.uniprot.org/core/Simple_Sequence">http://purl.uniprot.org/core/Simple_Sequence</seealso>
    let Simple_Sequence = Prefixed_Name(unicore, "Simple_Sequence") |> PrefixedName
    /// <summary>
    ///   <para>unicore:basedOn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The sequence on which the description of a modified sequence is based.</para>
    /// labels<para>based on</para></remarks>
    /// <seealso href="http://purl.uniprot.org/core/basedOn">http://purl.uniprot.org/core/basedOn</seealso>
    let basedOn = Prefixed_Name(unicore, "basedOn") |> PrefixedName
    /// <summary>
    ///   <para>unicore:Motif_Annotation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Short (&lt;=20 amino acids) sequence motif of biological interest.</para>
    /// labels<para>Motif</para></remarks>
    /// <seealso href="http://purl.uniprot.org/core/Motif_Annotation">http://purl.uniprot.org/core/Motif_Annotation</seealso>
    let Motif_Annotation = Prefixed_Name(unicore, "Motif_Annotation") |> PrefixedName

    /// <summary>
    ///   <para>unicore:Mutagenesis_Annotation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Site which has been experimentally altered.</para>
    /// labels<para>Mutagenesis Site</para></remarks>
    /// <seealso href="http://purl.uniprot.org/core/Mutagenesis_Annotation">http://purl.uniprot.org/core/Mutagenesis_Annotation</seealso>
    let Mutagenesis_Annotation =
        Prefixed_Name(unicore, "Mutagenesis_Annotation") |> PrefixedName

    /// <summary>
    ///   <para>unicore:NP_Binding_Annotation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Extent of a nucleotide phosphate-binding region.</para>
    /// labels<para>Nucleotide Phosphate Binding</para></remarks>
    /// <seealso href="http://purl.uniprot.org/core/NP_Binding_Annotation">http://purl.uniprot.org/core/NP_Binding_Annotation</seealso>
    let NP_Binding_Annotation =
        Prefixed_Name(unicore, "NP_Binding_Annotation") |> PrefixedName

    /// <summary>
    ///   <para>unicore:Natural_Variant_Annotation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Authors report that sequence variants exist.</para>
    /// labels<para>Sequence Variant</para></remarks>
    /// <seealso href="http://purl.uniprot.org/core/Natural_Variant_Annotation">http://purl.uniprot.org/core/Natural_Variant_Annotation</seealso>
    let Natural_Variant_Annotation =
        Prefixed_Name(unicore, "Natural_Variant_Annotation") |> PrefixedName

    /// <summary>
    ///   <para>unicore:Non-adjacent_Residues_Annotation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Indicates that two residues in a sequence are not consecutive and that there are a number of unsequenced residues between them.</para>
    /// labels<para>Non-consecutive Residues</para></remarks>
    /// <seealso href="http://purl.uniprot.org/core/Non-adjacent_Residues_Annotation">http://purl.uniprot.org/core/Non-adjacent_Residues_Annotation</seealso>
    let Non_adjacent_Residues_Annotation =
        Prefixed_Name(unicore, "Non-adjacent_Residues_Annotation") |> PrefixedName

    /// <summary>
    ///   <para>unicore:Non-photosynthetic_plastid</para>
    /// </summary>
    /// <remarks>
    ///   <para>unicore:Organelle</para>
    ///   <para>owl:Thing</para>
    ///
    /// labels<para>Non-photosyntethic plastid</para></remarks>
    /// <seealso href="http://purl.uniprot.org/core/Non-photosynthetic_plastid">http://purl.uniprot.org/core/Non-photosynthetic_plastid</seealso>
    let Non_photosynthetic_plastid =
        Prefixed_Name(unicore, "Non-photosynthetic_plastid") |> PrefixedName

    /// <summary>
    ///   <para>unicore:Non-standard_Residue_Annotation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Describes the occurrence of a non standard residue in the sequence record.</para>
    /// labels<para>Non standard residue</para></remarks>
    /// <seealso href="http://purl.uniprot.org/core/Non-standard_Residue_Annotation">http://purl.uniprot.org/core/Non-standard_Residue_Annotation</seealso>
    let Non_standard_Residue_Annotation =
        Prefixed_Name(unicore, "Non-standard_Residue_Annotation") |> PrefixedName

    /// <summary>
    ///   <para>unicore:Non-terminal_Residue_Annotation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The residue at an extremity of the sequence is not the terminal residue.</para>
    /// labels<para>Non-terminal Residue</para></remarks>
    /// <seealso href="http://purl.uniprot.org/core/Non-terminal_Residue_Annotation">http://purl.uniprot.org/core/Non-terminal_Residue_Annotation</seealso>
    let Non_terminal_Residue_Annotation =
        Prefixed_Name(unicore, "Non-terminal_Residue_Annotation") |> PrefixedName

    /// <summary>
    ///   <para>unicore:Obsolete</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The class of all obsolete records in the database (i.e. records that where once published but are now removed).</para>
    /// </remarks>
    /// <seealso href="http://purl.uniprot.org/core/Obsolete">http://purl.uniprot.org/core/Obsolete</seealso>
    let Obsolete = Prefixed_Name(unicore, "Obsolete") |> PrefixedName
    /// <summary>
    ///   <para>unicore:obsolete</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>True if this resource has been replaced or deleted.</para>
    /// labels<para>obsolete</para></remarks>
    /// <seealso href="http://purl.uniprot.org/core/obsolete">http://purl.uniprot.org/core/obsolete</seealso>
    let obsolete = Prefixed_Name(unicore, "obsolete") |> PrefixedName

    /// <summary>
    ///   <para>unicore:NotObsoleteProtein</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://purl.uniprot.org/core/NotObsoleteProtein">http://purl.uniprot.org/core/NotObsoleteProtein</seealso>
    let NotObsoleteProtein =
        Prefixed_Name(unicore, "NotObsoleteProtein") |> PrefixedName

    /// <summary>
    ///   <para>unicore:organism</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The organism in which a protein occurs.</para>
    /// </remarks>
    /// <seealso href="http://purl.uniprot.org/core/organism">http://purl.uniprot.org/core/organism</seealso>
    let organism = Prefixed_Name(unicore, "organism") |> PrefixedName
    /// <summary>
    ///   <para>unicore:existence</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.uniprot.org/core/existence">http://purl.uniprot.org/core/existence</seealso>
    let existence = Prefixed_Name(unicore, "existence") |> PrefixedName
    /// <summary>
    ///   <para>unicore:sequence</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>An amino acid sequence.</para>
    /// </remarks>
    /// <seealso href="http://purl.uniprot.org/core/sequence">http://purl.uniprot.org/core/sequence</seealso>
    let sequence = Prefixed_Name(unicore, "sequence") |> PrefixedName
    /// <summary>
    ///   <para>unicore:scientificName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>scientific name</para></remarks>
    /// <seealso href="http://purl.uniprot.org/core/scientificName">http://purl.uniprot.org/core/scientificName</seealso>
    let scientificName = Prefixed_Name(unicore, "scientificName") |> PrefixedName
    /// <summary>
    ///   <para>unicore:Taxon</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An element of a taxonomy for classifying life forms.</para>
    /// </remarks>
    /// <seealso href="http://purl.uniprot.org/core/Taxon">http://purl.uniprot.org/core/Taxon</seealso>
    let Taxon = Prefixed_Name(unicore, "Taxon") |> PrefixedName
    /// <summary>
    ///   <para>unicore:Nucleomorph</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>unicore:Organelle</para>
    ///
    /// labels<para>Nuleomorph</para></remarks>
    /// <seealso href="http://purl.uniprot.org/core/Nucleomorph">http://purl.uniprot.org/core/Nucleomorph</seealso>
    let Nucleomorph = Prefixed_Name(unicore, "Nucleomorph") |> PrefixedName

    /// <summary>
    ///   <para>unicore:Nucleotide_Binding_Annotation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Extent of a DNA-binding region.</para>
    /// labels<para>DNA Binding</para></remarks>
    /// <seealso href="http://purl.uniprot.org/core/Nucleotide_Binding_Annotation">http://purl.uniprot.org/core/Nucleotide_Binding_Annotation</seealso>
    let Nucleotide_Binding_Annotation =
        Prefixed_Name(unicore, "Nucleotide_Binding_Annotation") |> PrefixedName

    /// <summary>
    ///   <para>unicore:Nucleotide_Mapping_Statement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The relationship between a protein and a nucleotide sequence.</para>
    /// labels<para>Nucleotide Mapping Statement</para></remarks>
    /// <seealso href="http://purl.uniprot.org/core/Nucleotide_Mapping_Statement">http://purl.uniprot.org/core/Nucleotide_Mapping_Statement</seealso>
    let Nucleotide_Mapping_Statement =
        Prefixed_Name(unicore, "Nucleotide_Mapping_Statement") |> PrefixedName

    /// <summary>
    ///   <para>unicore:Nucleotide_Resource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A resource that descripes a nucleotide sequence.</para>
    /// labels<para>Nucleotide Resource</para></remarks>
    /// <seealso href="http://purl.uniprot.org/core/Nucleotide_Resource">http://purl.uniprot.org/core/Nucleotide_Resource</seealso>
    let Nucleotide_Resource =
        Prefixed_Name(unicore, "Nucleotide_Resource") |> PrefixedName

    /// <summary>
    ///   <para>unicore:locatedOn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The molecule a this resource is located on.</para>
    /// labels<para>located on</para></remarks>
    /// <seealso href="http://purl.uniprot.org/core/locatedOn">http://purl.uniprot.org/core/locatedOn</seealso>
    let locatedOn = Prefixed_Name(unicore, "locatedOn") |> PrefixedName

    /// <summary>
    ///   <para>unicore:Observation_Citation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Citation of an unpublished result.</para>
    /// labels<para>Observation Citation</para></remarks>
    /// <seealso href="http://purl.uniprot.org/core/Observation_Citation">http://purl.uniprot.org/core/Observation_Citation</seealso>
    let Observation_Citation =
        Prefixed_Name(unicore, "Observation_Citation") |> PrefixedName

    /// <summary>
    ///   <para>unicore:Unpublished_Citation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Unpublished Citation</para></remarks>
    /// <seealso href="http://purl.uniprot.org/core/Unpublished_Citation">http://purl.uniprot.org/core/Unpublished_Citation</seealso>
    let Unpublished_Citation =
        Prefixed_Name(unicore, "Unpublished_Citation") |> PrefixedName

    /// <summary>
    ///   <para>unicore:ObsoleteProtein</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://purl.uniprot.org/core/ObsoleteProtein">http://purl.uniprot.org/core/ObsoleteProtein</seealso>
    let ObsoleteProtein = Prefixed_Name(unicore, "ObsoleteProtein") |> PrefixedName
    /// <summary>
    ///   <para>unicore:ObsoleteTaxon</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Taxa are occasionally removed from the taxonomy database (particularly internal nodes, during a taxonomic revision) – these taxids are deleted, and are not reused.</para>
    /// </remarks>
    /// <seealso href="http://purl.uniprot.org/core/ObsoleteTaxon">http://purl.uniprot.org/core/ObsoleteTaxon</seealso>
    let ObsoleteTaxon = Prefixed_Name(unicore, "ObsoleteTaxon") |> PrefixedName
    /// <summary>
    ///   <para>unicore:created</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>The date a resource was created.</para>
    /// </remarks>
    /// <seealso href="http://purl.uniprot.org/core/created">http://purl.uniprot.org/core/created</seealso>
    let created = Prefixed_Name(unicore, "created") |> PrefixedName
    /// <summary>
    ///   <para>unicore:domain</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A domain of a protein.</para>
    /// </remarks>
    /// <seealso href="http://purl.uniprot.org/core/domain">http://purl.uniprot.org/core/domain</seealso>
    let domain = Prefixed_Name(unicore, "domain") |> PrefixedName
    /// <summary>
    ///   <para>unicore:domains</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The number of domains in a protein that correspond to a family. This is almost always 1, but may be 2 if  two identical domains are fused.</para>
    /// </remarks>
    /// <seealso href="http://purl.uniprot.org/core/domains">http://purl.uniprot.org/core/domains</seealso>
    let domains = Prefixed_Name(unicore, "domains") |> PrefixedName
    /// <summary>
    ///   <para>unicore:ecName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The ecName is the enzyme classification associated with a structured name of the protein. Proteins are often named after their enzymatic activity but can have more than one activity leading to multiple names.</para>
    /// </remarks>
    /// <seealso href="http://purl.uniprot.org/core/ecName">http://purl.uniprot.org/core/ecName</seealso>
    let ecName = Prefixed_Name(unicore, "ecName") |> PrefixedName
    /// <summary>
    ///   <para>unicore:editor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The editor of a publication.</para>
    /// </remarks>
    /// <seealso href="http://purl.uniprot.org/core/editor">http://purl.uniprot.org/core/editor</seealso>
    let editor = Prefixed_Name(unicore, "editor") |> PrefixedName
    /// <summary>
    ///   <para>unicore:encodedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The gene by which a protein is encoded.</para>
    /// labels<para>encoded by</para></remarks>
    /// <seealso href="http://purl.uniprot.org/core/encodedBy">http://purl.uniprot.org/core/encodedBy</seealso>
    let encodedBy = Prefixed_Name(unicore, "encodedBy") |> PrefixedName
    /// <summary>
    ///   <para>unicore:encodedIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The subcellular location where a protein is encoded.</para>
    /// labels<para>encoded in</para></remarks>
    /// <seealso href="http://purl.uniprot.org/core/encodedIn">http://purl.uniprot.org/core/encodedIn</seealso>
    let encodedIn = Prefixed_Name(unicore, "encodedIn") |> PrefixedName
    /// <summary>
    ///   <para>unicore:erratum</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>An erratum for a publication.</para>
    /// </remarks>
    /// <seealso href="http://purl.uniprot.org/core/erratum">http://purl.uniprot.org/core/erratum</seealso>
    let erratum = Prefixed_Name(unicore, "erratum") |> PrefixedName
    /// <summary>
    ///   <para>unicore:erratumFor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The publication which an erratum refers to.</para>
    /// labels<para>erratum for</para></remarks>
    /// <seealso href="http://purl.uniprot.org/core/erratumFor">http://purl.uniprot.org/core/erratumFor</seealso>
    let erratumFor = Prefixed_Name(unicore, "erratumFor") |> PrefixedName
    /// <summary>
    ///   <para>unicore:experiments</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.uniprot.org/core/experiments">http://purl.uniprot.org/core/experiments</seealso>
    let experiments = Prefixed_Name(unicore, "experiments") |> PrefixedName
    /// <summary>
    ///   <para>unicore:falseNegative</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>True if a statement is true even though it was not predicted.</para>
    /// labels<para>false negative</para></remarks>
    /// <seealso href="http://purl.uniprot.org/core/falseNegative">http://purl.uniprot.org/core/falseNegative</seealso>
    let falseNegative = Prefixed_Name(unicore, "falseNegative") |> PrefixedName
    /// <summary>
    ///   <para>unicore:fragment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Indicates if a sequence is complete or consists of one or more fragments.</para>
    /// </remarks>
    /// <seealso href="http://purl.uniprot.org/core/fragment">http://purl.uniprot.org/core/fragment</seealso>
    let fragment = Prefixed_Name(unicore, "fragment") |> PrefixedName
    /// <summary>
    ///   <para>unicore:frameshift</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>True if a sequence modification causes a frameshift.</para>
    /// </remarks>
    /// <seealso href="http://purl.uniprot.org/core/frameshift">http://purl.uniprot.org/core/frameshift</seealso>
    let frameshift = Prefixed_Name(unicore, "frameshift") |> PrefixedName
    /// <summary>
    ///   <para>unicore:fullName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The full name.</para>
    /// </remarks>
    /// <seealso href="http://purl.uniprot.org/core/fullName">http://purl.uniprot.org/core/fullName</seealso>
    let fullName = Prefixed_Name(unicore, "fullName") |> PrefixedName
    /// <summary>
    ///   <para>unicore:fused</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>True if the rule on which the membership of a protein to a family is based does not cover the entire protein.</para>
    /// </remarks>
    /// <seealso href="http://purl.uniprot.org/core/fused">http://purl.uniprot.org/core/fused</seealso>
    let fused = Prefixed_Name(unicore, "fused") |> PrefixedName
    /// <summary>
    ///   <para>unicore:group</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The group or consortium that authored a publication.</para>
    /// </remarks>
    /// <seealso href="http://purl.uniprot.org/core/group">http://purl.uniprot.org/core/group</seealso>
    let group = Prefixed_Name(unicore, "group") |> PrefixedName
    /// <summary>
    ///   <para>unicore:height</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.uniprot.org/core/height">http://purl.uniprot.org/core/height</seealso>
    let height = Prefixed_Name(unicore, "height") |> PrefixedName
    /// <summary>
    ///   <para>unicore:NMR_Spectroscopy</para>
    /// </summary>
    /// <remarks>
    ///   <para>unicore:Structure_Determination_Method</para>
    ///   <para>owl:Thing</para>
    ///
    /// labels<para>NMR Spectroscopy</para></remarks>
    /// <seealso href="http://purl.uniprot.org/core/NMR_Spectroscopy">http://purl.uniprot.org/core/NMR_Spectroscopy</seealso>
    let NMR_Spectroscopy = Prefixed_Name(unicore, "NMR_Spectroscopy") |> PrefixedName
    /// <summary>
    ///   <para>unicore:locator</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.uniprot.org/core/locator">http://purl.uniprot.org/core/locator</seealso>
    let locator = Prefixed_Name(unicore, "locator") |> PrefixedName
    /// <summary>
    ///   <para>unicore:locatedIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.uniprot.org/core/locatedIn">http://purl.uniprot.org/core/locatedIn</seealso>
    let locatedIn = Prefixed_Name(unicore, "locatedIn") |> PrefixedName

    /// <summary>
    ///   <para>unicore:Uncertain_Existence</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>unicore:Protein_Existence</para>
    ///
    /// labels<para>Uncertain</para></remarks>
    /// <seealso href="http://purl.uniprot.org/core/Uncertain_Existence">http://purl.uniprot.org/core/Uncertain_Existence</seealso>
    let Uncertain_Existence =
        Prefixed_Name(unicore, "Uncertain_Existence") |> PrefixedName

    /// <summary>
    ///   <para>unicore:Potential</para>
    /// </summary>
    /// <remarks>
    ///   <para>unicore:Status</para>
    ///   <para>owl:Thing</para>
    ///   <para>indicates that there is some logical or conclusive evidence that the given annotation could apply. This non-experimental qualifier is often used to present results from protein sequence analysis software tools, which are only annotated if the result makes sense in the biological context of a given protein. A typical example is the annotation of N-glycosylation sites in secreted proteins</para>
    /// labels<para>Potential</para></remarks>
    /// <seealso href="http://purl.uniprot.org/core/Potential">http://purl.uniprot.org/core/Potential</seealso>
    let Potential = Prefixed_Name(unicore, "Potential") |> PrefixedName
    /// <summary>
    ///   <para>unicore:Probable</para>
    /// </summary>
    /// <remarks>
    ///   <para>unicore:Status</para>
    ///   <para>owl:Thing</para>
    ///   <para>The status ‘Probable’ indicates stronger evidence than the qualifier ‘Potential’. This qualifier implies that there must be at least some experimental evidence, which indicates, that the information is expected to be found in the natural environment of a protein.</para>
    /// labels<para>Probable</para></remarks>
    /// <seealso href="http://purl.uniprot.org/core/Probable">http://purl.uniprot.org/core/Probable</seealso>
    let Probable = Prefixed_Name(unicore, "Probable") |> PrefixedName
    /// <summary>
    ///   <para>unicore:Turn_Annotation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Turns within the experimentally determined protein structure.</para>
    /// labels<para>Turn</para></remarks>
    /// <seealso href="http://purl.uniprot.org/core/Turn_Annotation">http://purl.uniprot.org/core/Turn_Annotation</seealso>
    let Turn_Annotation = Prefixed_Name(unicore, "Turn_Annotation") |> PrefixedName
    /// <summary>
    ///   <para>unicore:Unassigned_RNA</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Unassigned RNA</para></remarks>
    /// <seealso href="http://purl.uniprot.org/core/Unassigned_RNA">http://purl.uniprot.org/core/Unassigned_RNA</seealso>
    let Unassigned_RNA = Prefixed_Name(unicore, "Unassigned_RNA") |> PrefixedName
    /// <summary>
    ///   <para>unicore:Unknown_Sequence</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Unknown Sequence</para></remarks>
    /// <seealso href="http://purl.uniprot.org/core/Unknown_Sequence">http://purl.uniprot.org/core/Unknown_Sequence</seealso>
    let Unknown_Sequence = Prefixed_Name(unicore, "Unknown_Sequence") |> PrefixedName

    /// <summary>
    ///   <para>unicore:Zinc_Finger_Annotation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Extent of a zinc finger region.</para>
    /// labels<para>Zinc Finger</para></remarks>
    /// <seealso href="http://purl.uniprot.org/core/Zinc_Finger_Annotation">http://purl.uniprot.org/core/Zinc_Finger_Annotation</seealso>
    let Zinc_Finger_Annotation =
        Prefixed_Name(unicore, "Zinc_Finger_Annotation") |> PrefixedName

    /// <summary>
    ///   <para>unicore:activity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The description of a catalytic activity.</para>
    /// labels<para>catalytic activity</para></remarks>
    /// <seealso href="http://purl.uniprot.org/core/activity">http://purl.uniprot.org/core/activity</seealso>
    let activity = Prefixed_Name(unicore, "activity") |> PrefixedName
    /// <summary>
    ///   <para>unicore:allergenName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>See http://www.expasy.org/cgi-bin/lists?allergen.txt</para>
    /// </remarks>
    /// <seealso href="http://purl.uniprot.org/core/allergenName">http://purl.uniprot.org/core/allergenName</seealso>
    let allergenName = Prefixed_Name(unicore, "allergenName") |> PrefixedName

    /// <summary>
    ///   <para>unicore:structuredNameType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>All names of the protein, from commonly used to obsolete, to used in the literature..</para>
    /// </remarks>
    /// <seealso href="http://purl.uniprot.org/core/structuredNameType">http://purl.uniprot.org/core/structuredNameType</seealso>
    let structuredNameType =
        Prefixed_Name(unicore, "structuredNameType") |> PrefixedName

    /// <summary>
    ///   <para>unicore:alternativeName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A synonym of the recommended name.</para>
    /// </remarks>
    /// <seealso href="http://purl.uniprot.org/core/alternativeName">http://purl.uniprot.org/core/alternativeName</seealso>
    let alternativeName = Prefixed_Name(unicore, "alternativeName") |> PrefixedName
    /// <summary>
    ///   <para>unicore:attribution</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.uniprot.org/core/attribution">http://purl.uniprot.org/core/attribution</seealso>
    let attribution = Prefixed_Name(unicore, "attribution") |> PrefixedName
    /// <summary>
    ///   <para>unicore:authorsIncomplete</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.uniprot.org/core/authorsIncomplete">http://purl.uniprot.org/core/authorsIncomplete</seealso>
    let authorsIncomplete = Prefixed_Name(unicore, "authorsIncomplete") |> PrefixedName
    /// <summary>
    ///   <para>unicore:base</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.uniprot.org/core/base">http://purl.uniprot.org/core/base</seealso>
    let base_ = Prefixed_Name(unicore, "base") |> PrefixedName
    /// <summary>
    ///   <para>unicore:category</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.uniprot.org/core/category">http://purl.uniprot.org/core/category</seealso>
    let category = Prefixed_Name(unicore, "category") |> PrefixedName
    /// <summary>
    ///   <para>unicore:cdAntigenName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A name from the Human Cell Differentiation Molecules (HCDM) nomenclature.</para>
    /// </remarks>
    /// <seealso href="http://purl.uniprot.org/core/cdAntigenName">http://purl.uniprot.org/core/cdAntigenName</seealso>
    let cdAntigenName = Prefixed_Name(unicore, "cdAntigenName") |> PrefixedName
    /// <summary>
    ///   <para>unicore:cellularComponent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.uniprot.org/core/cellularComponent">http://purl.uniprot.org/core/cellularComponent</seealso>
    let cellularComponent = Prefixed_Name(unicore, "cellularComponent") |> PrefixedName
    /// <summary>
    ///   <para>unicore:topology</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.uniprot.org/core/topology">http://purl.uniprot.org/core/topology</seealso>
    let topology = Prefixed_Name(unicore, "topology") |> PrefixedName
    /// <summary>
    ///   <para>unicore:certain</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>False if there is any uncertainty about a statement.</para>
    /// </remarks>
    /// <seealso href="http://purl.uniprot.org/core/certain">http://purl.uniprot.org/core/certain</seealso>
    let certain = Prefixed_Name(unicore, "certain") |> PrefixedName
    /// <summary>
    ///   <para>unicore:synonym</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.uniprot.org/core/synonym">http://purl.uniprot.org/core/synonym</seealso>
    let synonym = Prefixed_Name(unicore, "synonym") |> PrefixedName
    /// <summary>
    ///   <para>unicore:title</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>The title of a publication.</para>
    /// </remarks>
    /// <seealso href="http://purl.uniprot.org/core/title">http://purl.uniprot.org/core/title</seealso>
    let title = Prefixed_Name(unicore, "title") |> PrefixedName
    /// <summary>
    ///   <para>unicore:transcribedFrom</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.uniprot.org/core/transcribedFrom">http://purl.uniprot.org/core/transcribedFrom</seealso>
    let transcribedFrom = Prefixed_Name(unicore, "transcribedFrom") |> PrefixedName
    /// <summary>
    ///   <para>unicore:translatedFrom</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.uniprot.org/core/translatedFrom">http://purl.uniprot.org/core/translatedFrom</seealso>
    let translatedFrom = Prefixed_Name(unicore, "translatedFrom") |> PrefixedName
    /// <summary>
    ///   <para>unicore:translatedTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.uniprot.org/core/translatedTo">http://purl.uniprot.org/core/translatedTo</seealso>
    let translatedTo = Prefixed_Name(unicore, "translatedTo") |> PrefixedName
    /// <summary>
    ///   <para>unicore:version</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.uniprot.org/core/version">http://purl.uniprot.org/core/version</seealso>
    let version = Prefixed_Name(unicore, "version") |> PrefixedName
    /// <summary>
    ///   <para>unicore:volume</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The volume a publication is part of.</para>
    /// </remarks>
    /// <seealso href="http://purl.uniprot.org/core/volume">http://purl.uniprot.org/core/volume</seealso>
    let volume = Prefixed_Name(unicore, "volume") |> PrefixedName
    /// <summary>
    ///   <para>unicore:width</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.uniprot.org/core/width">http://purl.uniprot.org/core/width</seealso>
    let width = Prefixed_Name(unicore, "width") |> PrefixedName
    /// <summary>
    ///   <para>unicore:xeno</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.uniprot.org/core/xeno">http://purl.uniprot.org/core/xeno</seealso>
    let xeno = Prefixed_Name(unicore, "xeno") |> PrefixedName

    /// <summary>
    ///   <para>unicore:Structure_Mapping_Statement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The relationship between a protein and a 3D structure.</para>
    /// labels<para>Structure Mapping Statement</para></remarks>
    /// <seealso href="http://purl.uniprot.org/core/Structure_Mapping_Statement">http://purl.uniprot.org/core/Structure_Mapping_Statement</seealso>
    let Structure_Mapping_Statement =
        Prefixed_Name(unicore, "Structure_Mapping_Statement") |> PrefixedName

    /// <summary>
    ///   <para>unicore:Structure_Resource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A resource that describes the 3D structure of a protein.</para>
    /// labels<para>Structure Resource</para></remarks>
    /// <seealso href="http://purl.uniprot.org/core/Structure_Resource">http://purl.uniprot.org/core/Structure_Resource</seealso>
    let Structure_Resource =
        Prefixed_Name(unicore, "Structure_Resource") |> PrefixedName

    /// <summary>
    ///   <para>unicore:partial</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>True if the pattern or profile on which the domain assignment is based did not detect the sequence because the sequence is not complete and lacks the region on which the pattern or profile is based.</para>
    /// </remarks>
    /// <seealso href="http://purl.uniprot.org/core/partial">http://purl.uniprot.org/core/partial</seealso>
    let partial = Prefixed_Name(unicore, "partial") |> PrefixedName
    /// <summary>
    ///   <para>unicore:By_Similarity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>unicore:Status</para>
    ///
    /// labels<para>By Similarity</para></remarks>
    /// <seealso href="http://purl.uniprot.org/core/By_Similarity">http://purl.uniprot.org/core/By_Similarity</seealso>
    let By_Similarity = Prefixed_Name(unicore, "By_Similarity") |> PrefixedName

    /// <summary>
    ///   <para>unicore:Function_Annotation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>General description of the functions of a protein.</para>
    /// labels<para>Function</para></remarks>
    /// <seealso href="http://purl.uniprot.org/core/Function_Annotation">http://purl.uniprot.org/core/Function_Annotation</seealso>
    let Function_Annotation =
        Prefixed_Name(unicore, "Function_Annotation") |> PrefixedName

    /// <summary>
    ///   <para>unicore:Genomic_DNA</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Genomic DNA</para></remarks>
    /// <seealso href="http://purl.uniprot.org/core/Genomic_DNA">http://purl.uniprot.org/core/Genomic_DNA</seealso>
    let Genomic_DNA = Prefixed_Name(unicore, "Genomic_DNA") |> PrefixedName
    /// <summary>
    ///   <para>unicore:Hydrogenosome</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>unicore:Organelle</para>
    ///
    /// labels<para>Hydrogenosome</para></remarks>
    /// <seealso href="http://purl.uniprot.org/core/Hydrogenosome">http://purl.uniprot.org/core/Hydrogenosome</seealso>
    let Hydrogenosome = Prefixed_Name(unicore, "Hydrogenosome") |> PrefixedName

    /// <summary>
    ///   <para>unicore:Initiator_Methionine_Annotation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Indicates that the initiator methionine has been cleaved off and is not shown in the sequence.</para>
    /// labels<para>Initiator Methionine</para></remarks>
    /// <seealso href="http://purl.uniprot.org/core/Initiator_Methionine_Annotation">http://purl.uniprot.org/core/Initiator_Methionine_Annotation</seealso>
    let Initiator_Methionine_Annotation =
        Prefixed_Name(unicore, "Initiator_Methionine_Annotation") |> PrefixedName

    /// <summary>
    ///   <para>unicore:submittedTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The database a resource  was submitted to.</para>
    /// </remarks>
    /// <seealso href="http://purl.uniprot.org/core/submittedTo">http://purl.uniprot.org/core/submittedTo</seealso>
    let submittedTo = Prefixed_Name(unicore, "submittedTo") |> PrefixedName

    /// <summary>
    ///   <para>unicore:Subunit_Annotation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Description of the quaternary structure of a protein.</para>
    /// labels<para>Subunit</para></remarks>
    /// <seealso href="http://purl.uniprot.org/core/Subunit_Annotation">http://purl.uniprot.org/core/Subunit_Annotation</seealso>
    let Subunit_Annotation =
        Prefixed_Name(unicore, "Subunit_Annotation") |> PrefixedName

    /// <summary>
    ///   <para>unicore:range</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A range of amino acids.</para>
    /// </remarks>
    /// <seealso href="http://purl.uniprot.org/core/range">http://purl.uniprot.org/core/range</seealso>
    let range = Prefixed_Name(unicore, "range") |> PrefixedName
    /// <summary>
    ///   <para>unicore:rank</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The rank of a taxon.</para>
    /// </remarks>
    /// <seealso href="http://purl.uniprot.org/core/rank">http://purl.uniprot.org/core/rank</seealso>
    let rank = Prefixed_Name(unicore, "rank") |> PrefixedName

    /// <summary>
    ///   <para>unicore:Topological_Domain_Annotation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A topological domain.</para>
    /// labels<para>Topological Domain</para></remarks>
    /// <seealso href="http://purl.uniprot.org/core/Topological_Domain_Annotation">http://purl.uniprot.org/core/Topological_Domain_Annotation</seealso>
    let Topological_Domain_Annotation =
        Prefixed_Name(unicore, "Topological_Domain_Annotation") |> PrefixedName

    /// <summary>
    ///   <para>unicore:Toxic_Dose_Annotation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Information on the LD(50). LD stands for "Lethal Dose". LD(50) is the amount of a toxin, given all at once, which causes the death of 50% (one half) of a group of test animals.</para>
    /// labels<para>Toxic Dose</para></remarks>
    /// <seealso href="http://purl.uniprot.org/core/Toxic_Dose_Annotation">http://purl.uniprot.org/core/Toxic_Dose_Annotation</seealso>
    let Toxic_Dose_Annotation =
        Prefixed_Name(unicore, "Toxic_Dose_Annotation") |> PrefixedName

    /// <summary>
    ///   <para>unicore:Transmembrane_Annotation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Extent of a transmembrane region.</para>
    /// labels<para>Transmembrane</para></remarks>
    /// <seealso href="http://purl.uniprot.org/core/Transmembrane_Annotation">http://purl.uniprot.org/core/Transmembrane_Annotation</seealso>
    let Transmembrane_Annotation =
        Prefixed_Name(unicore, "Transmembrane_Annotation") |> PrefixedName

    /// <summary>
    ///   <para>unicore:Unassigned_DNA</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Unassigned DNA</para></remarks>
    /// <seealso href="http://purl.uniprot.org/core/Unassigned_DNA">http://purl.uniprot.org/core/Unassigned_DNA</seealso>
    let Unassigned_DNA = Prefixed_Name(unicore, "Unassigned_DNA") |> PrefixedName
    /// <summary>
    ///   <para>unicore:Viral_cRNA</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Positive cRNA molecule that is made from from a single stranded genomic RNA.</para>
    /// labels<para>Viral cRNA</para></remarks>
    /// <seealso href="http://purl.uniprot.org/core/Viral_cRNA">http://purl.uniprot.org/core/Viral_cRNA</seealso>
    let Viral_cRNA = Prefixed_Name(unicore, "Viral_cRNA") |> PrefixedName
    /// <summary>
    ///   <para>unicore:abstract</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>True if the class does not have any direct instances.</para>
    /// </remarks>
    /// <seealso href="http://purl.uniprot.org/core/abstract">http://purl.uniprot.org/core/abstract</seealso>
    let abstract_ = Prefixed_Name(unicore, "abstract") |> PrefixedName
    /// <summary>
    ///   <para>unicore:alias</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>An alternative name used in the flat text format.</para>
    /// </remarks>
    /// <seealso href="http://purl.uniprot.org/core/alias">http://purl.uniprot.org/core/alias</seealso>
    let alias = Prefixed_Name(unicore, "alias") |> PrefixedName
    /// <summary>
    ///   <para>unicore:structuredName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.uniprot.org/core/structuredName">http://purl.uniprot.org/core/structuredName</seealso>
    let structuredName = Prefixed_Name(unicore, "structuredName") |> PrefixedName
    /// <summary>
    ///   <para>unicore:annotation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Attaches an annotation to a resource.</para>
    /// </remarks>
    /// <seealso href="http://purl.uniprot.org/core/annotation">http://purl.uniprot.org/core/annotation</seealso>
    let annotation = Prefixed_Name(unicore, "annotation") |> PrefixedName
    /// <summary>
    ///   <para>unicore:atypical</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>True if the protein is divergent in sequence or has mutated functional sites.</para>
    /// </remarks>
    /// <seealso href="http://purl.uniprot.org/core/atypical">http://purl.uniprot.org/core/atypical</seealso>
    let atypical = Prefixed_Name(unicore, "atypical") |> PrefixedName
    /// <summary>
    ///   <para>unicore:author</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The author of a publication.</para>
    /// </remarks>
    /// <seealso href="http://purl.uniprot.org/core/author">http://purl.uniprot.org/core/author</seealso>
    let author = Prefixed_Name(unicore, "author") |> PrefixedName
    /// <summary>
    ///   <para>unicore:biotechName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A name used in a biotechnological context.</para>
    /// </remarks>
    /// <seealso href="http://purl.uniprot.org/core/biotechName">http://purl.uniprot.org/core/biotechName</seealso>
    let biotechName = Prefixed_Name(unicore, "biotechName") |> PrefixedName
    /// <summary>
    ///   <para>unicore:orientation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.uniprot.org/core/orientation">http://purl.uniprot.org/core/orientation</seealso>
    let orientation = Prefixed_Name(unicore, "orientation") |> PrefixedName
    /// <summary>
    ///   <para>unicore:Mitochondrion</para>
    /// </summary>
    /// <remarks>
    ///   <para>unicore:Organelle</para>
    ///   <para>owl:Thing</para>
    ///
    /// labels<para>Mitochondion</para></remarks>
    /// <seealso href="http://purl.uniprot.org/core/Mitochondrion">http://purl.uniprot.org/core/Mitochondrion</seealso>
    let Mitochondrion = Prefixed_Name(unicore, "Mitochondrion") |> PrefixedName
    /// <summary>
    ///   <para>unicore:NotObsolete</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A class introduced to group all records that are currently in the database.</para>
    /// </remarks>
    /// <seealso href="http://purl.uniprot.org/core/NotObsolete">http://purl.uniprot.org/core/NotObsolete</seealso>
    let NotObsolete = Prefixed_Name(unicore, "NotObsolete") |> PrefixedName
    /// <summary>
    ///   <para>unicore:checksum</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>An caclulated value that is used to detect if there are errors in the sequence as shown due to among others IO errors. Both the crc64 and md5sum have collisions in UniProt data and cannot be used as unique keys.</para>
    /// </remarks>
    /// <seealso href="http://purl.uniprot.org/core/checksum">http://purl.uniprot.org/core/checksum</seealso>
    let checksum = Prefixed_Name(unicore, "checksum") |> PrefixedName
    /// <summary>
    ///   <para>unicore:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///   <para>Properties and classes used for protein annotation.</para>
    /// </remarks>
    /// <seealso href="http://purl.uniprot.org/core/">http://purl.uniprot.org/core/</seealso>
    let _prefix_iri = Prefixed_Name(unicore, "") |> PrefixedName

    /// <summary>
    ///   <para>unicore:Allergen_Annotation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Information relevant to allergenic proteins.</para>
    /// labels<para>Allergen</para></remarks>
    /// <seealso href="http://purl.uniprot.org/core/Allergen_Annotation">http://purl.uniprot.org/core/Allergen_Annotation</seealso>
    let Allergen_Annotation =
        Prefixed_Name(unicore, "Allergen_Annotation") |> PrefixedName

    /// <summary>
    ///   <para>unicore:Alternative_Promoter_Usage_Annotation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Alternative Promoter Usage</para></remarks>
    /// <seealso href="http://purl.uniprot.org/core/Alternative_Promoter_Usage_Annotation">http://purl.uniprot.org/core/Alternative_Promoter_Usage_Annotation</seealso>
    let Alternative_Promoter_Usage_Annotation =
        Prefixed_Name(unicore, "Alternative_Promoter_Usage_Annotation") |> PrefixedName

    /// <summary>
    ///   <para>unicore:Alternative_Sequence_Annotation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Description of sequence variants produced by alternative splicing.</para>
    /// labels<para>Splice Variant</para></remarks>
    /// <seealso href="http://purl.uniprot.org/core/Alternative_Sequence_Annotation">http://purl.uniprot.org/core/Alternative_Sequence_Annotation</seealso>
    let Alternative_Sequence_Annotation =
        Prefixed_Name(unicore, "Alternative_Sequence_Annotation") |> PrefixedName

    /// <summary>
    ///   <para>unicore:Attribution</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Entity used to attach evidence or provenance to a rdf statement via reification.</para>
    /// </remarks>
    /// <seealso href="http://purl.uniprot.org/core/Attribution">http://purl.uniprot.org/core/Attribution</seealso>
    let Attribution = Prefixed_Name(unicore, "Attribution") |> PrefixedName

    /// <summary>
    ///   <para>unicore:Beta_Strand_Annotation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Beta strand regions within the experimentally determined protein structure</para>
    /// labels<para>Strand</para></remarks>
    /// <seealso href="http://purl.uniprot.org/core/Beta_Strand_Annotation">http://purl.uniprot.org/core/Beta_Strand_Annotation</seealso>
    let Beta_Strand_Annotation =
        Prefixed_Name(unicore, "Beta_Strand_Annotation") |> PrefixedName

    /// <summary>
    ///   <para>unicore:Biotechnology_Annotation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Description of the use of a specific protein in a biotechnological process.</para>
    /// labels<para>Biotechnology</para></remarks>
    /// <seealso href="http://purl.uniprot.org/core/Biotechnology_Annotation">http://purl.uniprot.org/core/Biotechnology_Annotation</seealso>
    let Biotechnology_Annotation =
        Prefixed_Name(unicore, "Biotechnology_Annotation") |> PrefixedName

    /// <summary>
    ///   <para>unicore:name</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:AnnotationProperty</para>
    ///
    /// labels<para>name</para></remarks>
    /// <seealso href="http://purl.uniprot.org/core/name">http://purl.uniprot.org/core/name</seealso>
    let name = Prefixed_Name(unicore, "name") |> PrefixedName

    /// <summary>
    ///   <para>unicore:Calcium_Binding_Annotation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Extent of a calcium-binding region.</para>
    /// labels<para>Calcium Binding</para></remarks>
    /// <seealso href="http://purl.uniprot.org/core/Calcium_Binding_Annotation">http://purl.uniprot.org/core/Calcium_Binding_Annotation</seealso>
    let Calcium_Binding_Annotation =
        Prefixed_Name(unicore, "Calcium_Binding_Annotation") |> PrefixedName

    /// <summary>
    ///   <para>unicore:Caution_Annotation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Warning about possible errors and/or grounds for confusion.</para>
    /// labels<para>Caution</para></remarks>
    /// <seealso href="http://purl.uniprot.org/core/Caution_Annotation">http://purl.uniprot.org/core/Caution_Annotation</seealso>
    let Caution_Annotation =
        Prefixed_Name(unicore, "Caution_Annotation") |> PrefixedName

    /// <summary>
    ///   <para>unicore:Cellular_Component</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Cellular Component</para></remarks>
    /// <seealso href="http://purl.uniprot.org/core/Cellular_Component">http://purl.uniprot.org/core/Cellular_Component</seealso>
    let Cellular_Component =
        Prefixed_Name(unicore, "Cellular_Component") |> PrefixedName

    /// <summary>
    ///   <para>unicore:Citation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Description of a publication from which data was obtained.</para>
    /// </remarks>
    /// <seealso href="http://purl.uniprot.org/core/Citation">http://purl.uniprot.org/core/Citation</seealso>
    let Citation = Prefixed_Name(unicore, "Citation") |> PrefixedName
    /// <summary>
    ///   <para>unicore:date</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.uniprot.org/core/date">http://purl.uniprot.org/core/date</seealso>
    let date = Prefixed_Name(unicore, "date") |> PrefixedName
    /// <summary>
    ///   <para>unicore:Pathway</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A hierarchical discription of a metabolic pathway.</para>
    /// </remarks>
    /// <seealso href="http://purl.uniprot.org/core/Pathway">http://purl.uniprot.org/core/Pathway</seealso>
    let Pathway = Prefixed_Name(unicore, "Pathway") |> PrefixedName

    /// <summary>
    ///   <para>unicore:Pathway_Annotation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Description of the metabolic pathways with which a protein is associated.</para>
    /// labels<para>Pathway</para></remarks>
    /// <seealso href="http://purl.uniprot.org/core/Pathway_Annotation">http://purl.uniprot.org/core/Pathway_Annotation</seealso>
    let Pathway_Annotation =
        Prefixed_Name(unicore, "Pathway_Annotation") |> PrefixedName

    /// <summary>
    ///   <para>unicore:Peptide_Annotation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Extent of a released active peptide.</para>
    /// labels<para>Peptide</para></remarks>
    /// <seealso href="http://purl.uniprot.org/core/Peptide_Annotation">http://purl.uniprot.org/core/Peptide_Annotation</seealso>
    let Peptide_Annotation =
        Prefixed_Name(unicore, "Peptide_Annotation") |> PrefixedName

    /// <summary>
    ///   <para>unicore:Plastid</para>
    /// </summary>
    /// <remarks>
    ///   <para>unicore:Organelle</para>
    ///   <para>owl:Thing</para>
    ///
    /// labels<para>Plastid</para></remarks>
    /// <seealso href="http://purl.uniprot.org/core/Plastid">http://purl.uniprot.org/core/Plastid</seealso>
    let Plastid = Prefixed_Name(unicore, "Plastid") |> PrefixedName

    /// <summary>
    ///   <para>unicore:Polymorphism_Annotation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Description of polymorphisms.</para>
    /// labels<para>Polymorphism</para></remarks>
    /// <seealso href="http://purl.uniprot.org/core/Polymorphism_Annotation">http://purl.uniprot.org/core/Polymorphism_Annotation</seealso>
    let Polymorphism_Annotation =
        Prefixed_Name(unicore, "Polymorphism_Annotation") |> PrefixedName

    /// <summary>
    ///   <para>unicore:indexable</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.uniprot.org/core/indexable">http://purl.uniprot.org/core/indexable</seealso>
    let indexable = Prefixed_Name(unicore, "indexable") |> PrefixedName
    /// <summary>
    ///   <para>unicore:interaction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.uniprot.org/core/interaction">http://purl.uniprot.org/core/interaction</seealso>
    let interaction = Prefixed_Name(unicore, "interaction") |> PrefixedName

    /// <summary>
    ///   <para>unicore:internationalNonproprietaryName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The international nonproprietary name: A generic name for a pharmaceutical substance or active pharmaceutical ingredient that is globally recognized and is a public property.</para>
    /// </remarks>
    /// <seealso href="http://purl.uniprot.org/core/internationalNonproprietaryName">http://purl.uniprot.org/core/internationalNonproprietaryName</seealso>
    let internationalNonproprietaryName =
        Prefixed_Name(unicore, "internationalNonproprietaryName") |> PrefixedName

    /// <summary>
    ///   <para>unicore:isolatedFrom</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.uniprot.org/core/isolatedFrom">http://purl.uniprot.org/core/isolatedFrom</seealso>
    let isolatedFrom = Prefixed_Name(unicore, "isolatedFrom") |> PrefixedName
    /// <summary>
    ///   <para>unicore:length</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.uniprot.org/core/length">http://purl.uniprot.org/core/length</seealso>
    let length = Prefixed_Name(unicore, "length") |> PrefixedName
    /// <summary>
    ///   <para>unicore:limit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>True if the range does not extend beyond the specified endpoint.</para>
    /// </remarks>
    /// <seealso href="http://purl.uniprot.org/core/limit">http://purl.uniprot.org/core/limit</seealso>
    let limit = Prefixed_Name(unicore, "limit") |> PrefixedName
    /// <summary>
    ///   <para>unicore:locusName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:AnnotationProperty</para>
    ///
    /// labels<para>locus name</para></remarks>
    /// <seealso href="http://purl.uniprot.org/core/locusName">http://purl.uniprot.org/core/locusName</seealso>
    let locusName = Prefixed_Name(unicore, "locusName") |> PrefixedName
    /// <summary>
    ///   <para>unicore:manual</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.uniprot.org/core/manual">http://purl.uniprot.org/core/manual</seealso>
    let manual = Prefixed_Name(unicore, "manual") |> PrefixedName
    /// <summary>
    ///   <para>unicore:mass</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>The mass of a sequence in Daltons.</para>
    /// </remarks>
    /// <seealso href="http://purl.uniprot.org/core/mass">http://purl.uniprot.org/core/mass</seealso>
    let mass = Prefixed_Name(unicore, "mass") |> PrefixedName
    /// <summary>
    ///   <para>unicore:maximum</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A maximum value.</para>
    /// </remarks>
    /// <seealso href="http://purl.uniprot.org/core/maximum">http://purl.uniprot.org/core/maximum</seealso>
    let maximum = Prefixed_Name(unicore, "maximum") |> PrefixedName
    /// <summary>
    ///   <para>unicore:measuredValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>A value that was measured.</para>
    /// labels<para>measured value</para></remarks>
    /// <seealso href="http://purl.uniprot.org/core/measuredValue">http://purl.uniprot.org/core/measuredValue</seealso>
    let measuredValue = Prefixed_Name(unicore, "measuredValue") |> PrefixedName
    /// <summary>
    ///   <para>unicore:memberOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>member of</para></remarks>
    /// <seealso href="http://purl.uniprot.org/core/memberOf">http://purl.uniprot.org/core/memberOf</seealso>
    let memberOf = Prefixed_Name(unicore, "memberOf") |> PrefixedName
    /// <summary>
    ///   <para>unicore:modified</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>The date a resource was last modified.</para>
    /// </remarks>
    /// <seealso href="http://purl.uniprot.org/core/modified">http://purl.uniprot.org/core/modified</seealso>
    let modified = Prefixed_Name(unicore, "modified") |> PrefixedName
    /// <summary>
    ///   <para>unicore:negative</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.uniprot.org/core/negative">http://purl.uniprot.org/core/negative</seealso>
    let negative = Prefixed_Name(unicore, "negative") |> PrefixedName
    /// <summary>
    ///   <para>unicore:oldMnemonic</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A mnemonic that is no longer in use for this entry.</para>
    /// </remarks>
    /// <seealso href="http://purl.uniprot.org/core/oldMnemonic">http://purl.uniprot.org/core/oldMnemonic</seealso>
    let oldMnemonic = Prefixed_Name(unicore, "oldMnemonic") |> PrefixedName
    /// <summary>
    ///   <para>unicore:orfName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>ORF name</para></remarks>
    /// <seealso href="http://purl.uniprot.org/core/orfName">http://purl.uniprot.org/core/orfName</seealso>
    let orfName = Prefixed_Name(unicore, "orfName") |> PrefixedName
    /// <summary>
    ///   <para>unicore:chain</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Maps a series of symbols representing chains of a protein to a range of amino acids.</para>
    /// </remarks>
    /// <seealso href="http://purl.uniprot.org/core/chain">http://purl.uniprot.org/core/chain</seealso>
    let chain = Prefixed_Name(unicore, "chain") |> PrefixedName
    /// <summary>
    ///   <para>unicore:citation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A publication from which data was extracted, or which contains additional information.</para>
    /// </remarks>
    /// <seealso href="http://purl.uniprot.org/core/citation">http://purl.uniprot.org/core/citation</seealso>
    let citation = Prefixed_Name(unicore, "citation") |> PrefixedName
    /// <summary>
    ///   <para>unicore:classifiedWith</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A concept that classifies this resource.</para>
    /// labels<para>classified with</para></remarks>
    /// <seealso href="http://purl.uniprot.org/core/classifiedWith">http://purl.uniprot.org/core/classifiedWith</seealso>
    let classifiedWith = Prefixed_Name(unicore, "classifiedWith") |> PrefixedName
    /// <summary>
    ///   <para>unicore:cofactor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A cofactor required for a catalytic activity.</para>
    /// labels<para>cofactor</para></remarks>
    /// <seealso href="http://purl.uniprot.org/core/cofactor">http://purl.uniprot.org/core/cofactor</seealso>
    let cofactor = Prefixed_Name(unicore, "cofactor") |> PrefixedName
    /// <summary>
    ///   <para>unicore:commonTaxon</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.uniprot.org/core/commonTaxon">http://purl.uniprot.org/core/commonTaxon</seealso>
    let commonTaxon = Prefixed_Name(unicore, "commonTaxon") |> PrefixedName
    /// <summary>
    ///   <para>unicore:complete</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.uniprot.org/core/complete">http://purl.uniprot.org/core/complete</seealso>
    let complete = Prefixed_Name(unicore, "complete") |> PrefixedName
    /// <summary>
    ///   <para>unicore:component</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A component of a protein.</para>
    /// </remarks>
    /// <seealso href="http://purl.uniprot.org/core/component">http://purl.uniprot.org/core/component</seealso>
    let component_ = Prefixed_Name(unicore, "component") |> PrefixedName

    /// <summary>
    ///   <para>unicore:conflictingSequence</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.uniprot.org/core/conflictingSequence">http://purl.uniprot.org/core/conflictingSequence</seealso>
    let conflictingSequence =
        Prefixed_Name(unicore, "conflictingSequence") |> PrefixedName

    /// <summary>
    ///   <para>unicore:Absorption_Annotation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Indicates the wavelength in nm at which photoreactive proteins such as opsins and DNA photolyases show maximal absorption.</para>
    /// labels<para>Absorption</para></remarks>
    /// <seealso href="http://purl.uniprot.org/core/Absorption_Annotation">http://purl.uniprot.org/core/Absorption_Annotation</seealso>
    let Absorption_Annotation =
        Prefixed_Name(unicore, "Absorption_Annotation") |> PrefixedName

    /// <summary>
    ///   <para>unicore:Site_Annotation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Any interesting single amino-acid site on the sequence, that is not defined by another feature key. It can also apply to an amino acid bond which is represented by the positions of the two flanking amino acids.</para>
    /// labels<para>Site</para></remarks>
    /// <seealso href="http://purl.uniprot.org/core/Site_Annotation">http://purl.uniprot.org/core/Site_Annotation</seealso>
    let Site_Annotation = Prefixed_Name(unicore, "Site_Annotation") |> PrefixedName
    /// <summary>
    ///   <para>unicore:Annotation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Description of a resource on a specific topic.</para>
    /// </remarks>
    /// <seealso href="http://purl.uniprot.org/core/Annotation">http://purl.uniprot.org/core/Annotation</seealso>
    let Annotation = Prefixed_Name(unicore, "Annotation") |> PrefixedName

    /// <summary>
    ///   <para>unicore:Alternative_Initiation_Annotation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Alternative Initiation</para></remarks>
    /// <seealso href="http://purl.uniprot.org/core/Alternative_Initiation_Annotation">http://purl.uniprot.org/core/Alternative_Initiation_Annotation</seealso>
    let Alternative_Initiation_Annotation =
        Prefixed_Name(unicore, "Alternative_Initiation_Annotation") |> PrefixedName

    /// <summary>
    ///   <para>unicore:part</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.uniprot.org/core/part">http://purl.uniprot.org/core/part</seealso>
    let part = Prefixed_Name(unicore, "part") |> PrefixedName
    /// <summary>
    ///   <para>unicore:Resource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A life science resource.</para>
    /// </remarks>
    /// <seealso href="http://purl.uniprot.org/core/Resource">http://purl.uniprot.org/core/Resource</seealso>
    let Resource = Prefixed_Name(unicore, "Resource") |> PrefixedName
    /// <summary>
    ///   <para>unicore:crc64Checksum</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.uniprot.org/core/crc64Checksum">http://purl.uniprot.org/core/crc64Checksum</seealso>
    let crc64Checksum = Prefixed_Name(unicore, "crc64Checksum") |> PrefixedName

    /// <summary>
    ///   <para>unicore:Mass_Measurement_Method</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An experimental method for measuring the mass of a molecule.</para>
    /// labels<para>Mass Measurement</para></remarks>
    /// <seealso href="http://purl.uniprot.org/core/Mass_Measurement_Method">http://purl.uniprot.org/core/Mass_Measurement_Method</seealso>
    let Mass_Measurement_Method =
        Prefixed_Name(unicore, "Mass_Measurement_Method") |> PrefixedName

    /// <summary>
    ///   <para>unicore:Orientation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Orientation</para></remarks>
    /// <seealso href="http://purl.uniprot.org/core/Orientation">http://purl.uniprot.org/core/Orientation</seealso>
    let Orientation = Prefixed_Name(unicore, "Orientation") |> PrefixedName
    /// <summary>
    ///   <para>unicore:Other_RNA</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Other RNA</para></remarks>
    /// <seealso href="http://purl.uniprot.org/core/Other_RNA">http://purl.uniprot.org/core/Other_RNA</seealso>
    let Other_RNA = Prefixed_Name(unicore, "Other_RNA") |> PrefixedName
    /// <summary>
    ///   <para>unicore:PTM_Annotation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Description of a posttranslational modification.</para>
    /// labels<para>PTM</para></remarks>
    /// <seealso href="http://purl.uniprot.org/core/PTM_Annotation">http://purl.uniprot.org/core/PTM_Annotation</seealso>
    let PTM_Annotation = Prefixed_Name(unicore, "PTM_Annotation") |> PrefixedName
    /// <summary>
    ///   <para>unicore:Participant</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A participant in a protein-protein interaction.</para>
    /// </remarks>
    /// <seealso href="http://purl.uniprot.org/core/Participant">http://purl.uniprot.org/core/Participant</seealso>
    let Participant = Prefixed_Name(unicore, "Participant") |> PrefixedName
    /// <summary>
    ///   <para>unicore:hits</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>The number of hits found in a sequence.</para>
    /// </remarks>
    /// <seealso href="http://purl.uniprot.org/core/hits">http://purl.uniprot.org/core/hits</seealso>
    let hits = Prefixed_Name(unicore, "hits") |> PrefixedName

    /// <summary>
    ///   <para>unicore:Inferred_from_Homology_Existence</para>
    /// </summary>
    /// <remarks>
    ///   <para>unicore:Protein_Existence</para>
    ///   <para>owl:Thing</para>
    ///
    /// labels<para>Inferred from homology</para></remarks>
    /// <seealso href="http://purl.uniprot.org/core/Inferred_from_Homology_Existence">http://purl.uniprot.org/core/Inferred_from_Homology_Existence</seealso>
    let Inferred_from_Homology_Existence =
        Prefixed_Name(unicore, "Inferred_from_Homology_Existence") |> PrefixedName

    /// <summary>
    ///   <para>unicore:Evidence_at_Transcript_Level_Existence</para>
    /// </summary>
    /// <remarks>
    ///   <para>unicore:Protein_Existence</para>
    ///   <para>owl:Thing</para>
    ///   <para>Indicates that the existence of a protein has not been strictly proven but that expression data (such as existence of cDNA(s), RT-PCR or Northern blots) indicate the existence of a transcript.</para>
    /// labels<para>Evidence at transcript level</para></remarks>
    /// <seealso href="http://purl.uniprot.org/core/Evidence_at_Transcript_Level_Existence">http://purl.uniprot.org/core/Evidence_at_Transcript_Level_Existence</seealso>
    let Evidence_at_Transcript_Level_Existence =
        Prefixed_Name(unicore, "Evidence_at_Transcript_Level_Existence") |> PrefixedName

    /// <summary>
    ///   <para>unicore:Family</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>unicore:Rank</para>
    ///
    /// labels<para>Taxonomy rank Family</para></remarks>
    /// <seealso href="http://purl.uniprot.org/core/Family">http://purl.uniprot.org/core/Family</seealso>
    let Family = Prefixed_Name(unicore, "Family") |> PrefixedName
    /// <summary>
    ///   <para>unicore:Subkingdom</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>unicore:Rank</para>
    ///
    /// labels<para>Taxonomic rank Subkingdom</para></remarks>
    /// <seealso href="http://purl.uniprot.org/core/Subkingdom">http://purl.uniprot.org/core/Subkingdom</seealso>
    let Subkingdom = Prefixed_Name(unicore, "Subkingdom") |> PrefixedName
    /// <summary>
    ///   <para>unicore:Subgenus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>unicore:Rank</para>
    ///
    /// labels<para>Taxonomic rank Subgenus</para></remarks>
    /// <seealso href="http://purl.uniprot.org/core/Subgenus">http://purl.uniprot.org/core/Subgenus</seealso>
    let Subgenus = Prefixed_Name(unicore, "Subgenus") |> PrefixedName
    /// <summary>
    ///   <para>unicore:Tribe</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>unicore:Rank</para>
    ///
    /// labels<para>Taxonomic rank Tribe</para></remarks>
    /// <seealso href="http://purl.uniprot.org/core/Tribe">http://purl.uniprot.org/core/Tribe</seealso>
    let Tribe = Prefixed_Name(unicore, "Tribe") |> PrefixedName
    /// <summary>
    ///   <para>unicore:Subtribe</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>unicore:Rank</para>
    ///
    /// labels<para>Taxonomic rank Subtribe</para></remarks>
    /// <seealso href="http://purl.uniprot.org/core/Subtribe">http://purl.uniprot.org/core/Subtribe</seealso>
    let Subtribe = Prefixed_Name(unicore, "Subtribe") |> PrefixedName
    /// <summary>
    ///   <para>unicore:Superfamily</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>unicore:Rank</para>
    ///
    /// labels<para>Taxonomic rank Superfamily</para></remarks>
    /// <seealso href="http://purl.uniprot.org/core/Superfamily">http://purl.uniprot.org/core/Superfamily</seealso>
    let Superfamily = Prefixed_Name(unicore, "Superfamily") |> PrefixedName
    /// <summary>
    ///   <para>unicore:Species_Subgroup</para>
    /// </summary>
    /// <remarks>
    ///   <para>unicore:Rank</para>
    ///   <para>owl:Thing</para>
    ///
    /// labels<para>Taxonomic rank Species Subgroup</para></remarks>
    /// <seealso href="http://purl.uniprot.org/core/Species_Subgroup">http://purl.uniprot.org/core/Species_Subgroup</seealso>
    let Species_Subgroup = Prefixed_Name(unicore, "Species_Subgroup") |> PrefixedName
    /// <summary>
    ///   <para>unicore:Superphylum</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>unicore:Rank</para>
    ///
    /// labels<para>Taxonomic rank Superphylum</para></remarks>
    /// <seealso href="http://purl.uniprot.org/core/Superphylum">http://purl.uniprot.org/core/Superphylum</seealso>
    let Superphylum = Prefixed_Name(unicore, "Superphylum") |> PrefixedName
    /// <summary>
    ///   <para>unicore:Forma</para>
    /// </summary>
    /// <remarks>
    ///   <para>unicore:Rank</para>
    ///   <para>owl:Thing</para>
    ///
    /// labels<para>Taxonomy rank Forma</para></remarks>
    /// <seealso href="http://purl.uniprot.org/core/Forma">http://purl.uniprot.org/core/Forma</seealso>
    let Forma = Prefixed_Name(unicore, "Forma") |> PrefixedName
    /// <summary>
    ///   <para>unicore:Species_Group</para>
    /// </summary>
    /// <remarks>
    ///   <para>unicore:Rank</para>
    ///   <para>owl:Thing</para>
    ///
    /// labels<para>Taxonomic rank Species Group</para></remarks>
    /// <seealso href="http://purl.uniprot.org/core/Species_Group">http://purl.uniprot.org/core/Species_Group</seealso>
    let Species_Group = Prefixed_Name(unicore, "Species_Group") |> PrefixedName

    /// <summary>
    ///   <para>unicore:Biophysicochemical_Annotation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Biophysical and physicochemical data such as pH dependence, temperature dependence, kinetic parameters, redox potentials, and maximal absorption.</para>
    /// labels<para>Biophysicochemical Property</para></remarks>
    /// <seealso href="http://purl.uniprot.org/core/Biophysicochemical_Annotation">http://purl.uniprot.org/core/Biophysicochemical_Annotation</seealso>
    let Biophysicochemical_Annotation =
        Prefixed_Name(unicore, "Biophysicochemical_Annotation") |> PrefixedName

    /// <summary>
    ///   <para>unicore:Active_Site_Annotation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Amino acid(s) involved in the activity of an enzyme.</para>
    /// labels<para>Active Site</para></remarks>
    /// <seealso href="http://purl.uniprot.org/core/Active_Site_Annotation">http://purl.uniprot.org/core/Active_Site_Annotation</seealso>
    let Active_Site_Annotation =
        Prefixed_Name(unicore, "Active_Site_Annotation") |> PrefixedName

    /// <summary>
    ///   <para>unicore:Alternative_Products_Annotation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Description of the existence of related protein sequences produced by alternative splicing of the same gene or by the use of alternative initiation codons.</para>
    /// labels<para>Alternative Products</para></remarks>
    /// <seealso href="http://purl.uniprot.org/core/Alternative_Products_Annotation">http://purl.uniprot.org/core/Alternative_Products_Annotation</seealso>
    let Alternative_Products_Annotation =
        Prefixed_Name(unicore, "Alternative_Products_Annotation") |> PrefixedName

    /// <summary>
    ///   <para>unicore:Natural_Variation_Annotation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Natural Variation</para></remarks>
    /// <seealso href="http://purl.uniprot.org/core/Natural_Variation_Annotation">http://purl.uniprot.org/core/Natural_Variation_Annotation</seealso>
    let Natural_Variation_Annotation =
        Prefixed_Name(unicore, "Natural_Variation_Annotation") |> PrefixedName

    /// <summary>
    ///   <para>unicore:Alternative_Splicing_Annotation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Alternative Splicing</para></remarks>
    /// <seealso href="http://purl.uniprot.org/core/Alternative_Splicing_Annotation">http://purl.uniprot.org/core/Alternative_Splicing_Annotation</seealso>
    let Alternative_Splicing_Annotation =
        Prefixed_Name(unicore, "Alternative_Splicing_Annotation") |> PrefixedName

    /// <summary>
    ///   <para>unicore:Secondary_Structure_Annotation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Describes the secondary structure of proteins whose tertiary structure is known experimentally.</para>
    /// labels<para>Secondary Structure</para></remarks>
    /// <seealso href="http://purl.uniprot.org/core/Secondary_Structure_Annotation">http://purl.uniprot.org/core/Secondary_Structure_Annotation</seealso>
    let Secondary_Structure_Annotation =
        Prefixed_Name(unicore, "Secondary_Structure_Annotation") |> PrefixedName

    /// <summary>
    ///   <para>unicore:Book_Citation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A chapter from a book.</para>
    /// labels<para>Book Citation</para></remarks>
    /// <seealso href="http://purl.uniprot.org/core/Book_Citation">http://purl.uniprot.org/core/Book_Citation</seealso>
    let Book_Citation = Prefixed_Name(unicore, "Book_Citation") |> PrefixedName

    /// <summary>
    ///   <para>unicore:Published_Citation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Published Citation</para></remarks>
    /// <seealso href="http://purl.uniprot.org/core/Published_Citation">http://purl.uniprot.org/core/Published_Citation</seealso>
    let Published_Citation =
        Prefixed_Name(unicore, "Published_Citation") |> PrefixedName

    /// <summary>
    ///   <para>unicore:Status</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Indicator for the reliability of a piece of information.</para>
    /// </remarks>
    /// <seealso href="http://purl.uniprot.org/core/Status">http://purl.uniprot.org/core/Status</seealso>
    let Status = Prefixed_Name(unicore, "Status") |> PrefixedName
    /// <summary>
    ///   <para>unicore:Region_Annotation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Region</para></remarks>
    /// <seealso href="http://purl.uniprot.org/core/Region_Annotation">http://purl.uniprot.org/core/Region_Annotation</seealso>
    let Region_Annotation = Prefixed_Name(unicore, "Region_Annotation") |> PrefixedName

    /// <summary>
    ///   <para>unicore:Catalytic_Activity_Annotation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Description of the reactions catalyzed by an enzyme.</para>
    /// labels<para>Catalytic Activity</para></remarks>
    /// <seealso href="http://purl.uniprot.org/core/Catalytic_Activity_Annotation">http://purl.uniprot.org/core/Catalytic_Activity_Annotation</seealso>
    let Catalytic_Activity_Annotation =
        Prefixed_Name(unicore, "Catalytic_Activity_Annotation") |> PrefixedName

    /// <summary>
    ///   <para>unicore:Subcellular_Location</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Subcellular Location</para></remarks>
    /// <seealso href="http://purl.uniprot.org/core/Subcellular_Location">http://purl.uniprot.org/core/Subcellular_Location</seealso>
    let Subcellular_Location =
        Prefixed_Name(unicore, "Subcellular_Location") |> PrefixedName

    /// <summary>
    ///   <para>unicore:Chain_Annotation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Extent of a polypeptide chain in the mature protein.</para>
    /// labels<para>Chain</para></remarks>
    /// <seealso href="http://purl.uniprot.org/core/Chain_Annotation">http://purl.uniprot.org/core/Chain_Annotation</seealso>
    let Chain_Annotation = Prefixed_Name(unicore, "Chain_Annotation") |> PrefixedName

    /// <summary>
    ///   <para>unicore:Molecule_Processing_Annotation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Molecule Processing</para></remarks>
    /// <seealso href="http://purl.uniprot.org/core/Molecule_Processing_Annotation">http://purl.uniprot.org/core/Molecule_Processing_Annotation</seealso>
    let Molecule_Processing_Annotation =
        Prefixed_Name(unicore, "Molecule_Processing_Annotation") |> PrefixedName

    /// <summary>
    ///   <para>unicore:Chloroplast</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>unicore:Organelle</para>
    ///
    /// labels<para>Chloroplast</para></remarks>
    /// <seealso href="http://purl.uniprot.org/core/Chloroplast">http://purl.uniprot.org/core/Chloroplast</seealso>
    let Chloroplast = Prefixed_Name(unicore, "Chloroplast") |> PrefixedName
    /// <summary>
    ///   <para>unicore:host</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.uniprot.org/core/host">http://purl.uniprot.org/core/host</seealso>
    let host = Prefixed_Name(unicore, "host") |> PrefixedName
    /// <summary>
    ///   <para>unicore:identity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The level of sequence identity in a cluster.</para>
    /// </remarks>
    /// <seealso href="http://purl.uniprot.org/core/identity">http://purl.uniprot.org/core/identity</seealso>
    let identity = Prefixed_Name(unicore, "identity") |> PrefixedName
    /// <summary>
    ///   <para>unicore:implicit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>True if existance of this resource can be inferred.</para>
    /// </remarks>
    /// <seealso href="http://purl.uniprot.org/core/implicit">http://purl.uniprot.org/core/implicit</seealso>
    let implicit = Prefixed_Name(unicore, "implicit") |> PrefixedName
