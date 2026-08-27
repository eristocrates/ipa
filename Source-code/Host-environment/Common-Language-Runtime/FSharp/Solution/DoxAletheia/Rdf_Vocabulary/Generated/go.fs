namespace http.purl.obolibrary.org.obo.GO_.bare

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module go =
    let _namespace_iri = Namespace_Iri go |> NamespaceIRI
    /// <summary>
    ///   <para>cdao:GO_0000785</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"chromatin"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/GO_0000785">http://purl.obolibrary.org/obo/GO_0000785</seealso>
    let chromatin = Prefixed_Name(go, "0000785") |> PrefixedName
    /// <summary>
    ///   <para>cdao:GO_0001047</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"core promoter binding"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/GO_0001047">http://purl.obolibrary.org/obo/GO_0001047</seealso>
    let core_promoter_binding = Prefixed_Name(go, "0001047") |> PrefixedName
    /// <summary>
    ///   <para>cdao:GO_0001508</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"action potential"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/GO_0001508">http://purl.obolibrary.org/obo/GO_0001508</seealso>
    let action_potential = Prefixed_Name(go, "0001508") |> PrefixedName

    /// <summary>
    ///   <para>cdao:GO_0001788</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"antibody-dependent cellular cytotoxicity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/GO_0001788">http://purl.obolibrary.org/obo/GO_0001788</seealso>
    let antibody_dependent_cellular_cytotoxicity =
        Prefixed_Name(go, "0001788") |> PrefixedName

    /// <summary>
    ///   <para>cdao:GO_0001806</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"type IV hypersensitivity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/GO_0001806">http://purl.obolibrary.org/obo/GO_0001806</seealso>
    let type_IV_hypersensitivity = Prefixed_Name(go, "0001806") |> PrefixedName
    /// <summary>
    ///   <para>cdao:GO_0001816</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"cytokine production"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/GO_0001816">http://purl.obolibrary.org/obo/GO_0001816</seealso>
    let cytokine_production = Prefixed_Name(go, "0001816") |> PrefixedName
    /// <summary>
    ///   <para>cdao:GO_0001906</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"cell killing"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/GO_0001906">http://purl.obolibrary.org/obo/GO_0001906</seealso>
    let cell_killing = Prefixed_Name(go, "0001906") |> PrefixedName
    /// <summary>
    ///   <para>cdao:GO_0001913</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"T cell mediated cytotoxicity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/GO_0001913">http://purl.obolibrary.org/obo/GO_0001913</seealso>
    let T_cell_mediated_cytotoxicity = Prefixed_Name(go, "0001913") |> PrefixedName
    /// <summary>
    ///   <para>cdao:GO_0002250</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"adaptive immune response"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/GO_0002250">http://purl.obolibrary.org/obo/GO_0002250</seealso>
    let adaptive_immune_response = Prefixed_Name(go, "0002250") |> PrefixedName

    /// <summary>
    ///   <para>cdao:GO_0002367</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"cytokine production involved in immune response"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/GO_0002367">http://purl.obolibrary.org/obo/GO_0002367</seealso>
    let cytokine_production_involved_in_immune_response =
        Prefixed_Name(go, "0002367") |> PrefixedName

    /// <summary>
    ///   <para>cdao:GO_0002390</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"platelet activating factor production"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/GO_0002390">http://purl.obolibrary.org/obo/GO_0002390</seealso>
    let platelet_activating_factor_production =
        Prefixed_Name(go, "0002390") |> PrefixedName

    /// <summary>
    ///   <para>cdao:GO_0002507</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"tolerance induction"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/GO_0002507">http://purl.obolibrary.org/obo/GO_0002507</seealso>
    let tolerance_induction = Prefixed_Name(go, "0002507") |> PrefixedName
    /// <summary>
    ///   <para>cdao:GO_0002514</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"B cell tolerance induction"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/GO_0002514">http://purl.obolibrary.org/obo/GO_0002514</seealso>
    let B_cell_tolerance_induction = Prefixed_Name(go, "0002514") |> PrefixedName
    /// <summary>
    ///   <para>cdao:GO_0002517</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"T cell tolerance induction"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/GO_0002517">http://purl.obolibrary.org/obo/GO_0002517</seealso>
    let T_cell_tolerance_induction = Prefixed_Name(go, "0002517") |> PrefixedName
    /// <summary>
    ///   <para>cdao:GO_0002524</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"hypersensitivity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/GO_0002524">http://purl.obolibrary.org/obo/GO_0002524</seealso>
    let hypersensitivity = Prefixed_Name(go, "0002524") |> PrefixedName

    /// <summary>
    ///   <para>cdao:GO_0002534</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"cytokine production involved in inflammatory response"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/GO_0002534">http://purl.obolibrary.org/obo/GO_0002534</seealso>
    let cytokine_production_involved_in_inflammatory_response =
        Prefixed_Name(go, "0002534") |> PrefixedName

    /// <summary>
    ///   <para>cdao:GO_0003674</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"GO:molecular_function"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/GO_0003674">http://purl.obolibrary.org/obo/GO_0003674</seealso>
    let ``GO:molecular_function`` = Prefixed_Name(go, "0003674") |> PrefixedName
    /// <summary>
    ///   <para>cdao:GO_0003823</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"antigen binding"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/GO_0003823">http://purl.obolibrary.org/obo/GO_0003823</seealso>
    let antigen_binding = Prefixed_Name(go, "0003823") |> PrefixedName
    /// <summary>
    ///   <para>cdao:GO_0003824</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"catalytic activity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/GO_0003824">http://purl.obolibrary.org/obo/GO_0003824</seealso>
    let catalytic_activity = Prefixed_Name(go, "0003824") |> PrefixedName

    /// <summary>
    ///   <para>cdao:GO_0003964</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"RNA-directed DNA polymerase activity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/GO_0003964">http://purl.obolibrary.org/obo/GO_0003964</seealso>
    let RNA_directed_DNA_polymerase_activity =
        Prefixed_Name(go, "0003964") |> PrefixedName

    /// <summary>
    ///   <para>cdao:GO_0005216</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"ion channel activity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/GO_0005216">http://purl.obolibrary.org/obo/GO_0005216</seealso>
    let ion_channel_activity = Prefixed_Name(go, "0005216") |> PrefixedName
    /// <summary>
    ///   <para>cdao:GO_0005575</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"cellular_component"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/GO_0005575">http://purl.obolibrary.org/obo/GO_0005575</seealso>
    let cellular_component = Prefixed_Name(go, "0005575") |> PrefixedName
    /// <summary>
    ///   <para>cdao:GO_0005694</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"chromosome"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/GO_0005694">http://purl.obolibrary.org/obo/GO_0005694</seealso>
    let chromosome = Prefixed_Name(go, "0005694") |> PrefixedName
    /// <summary>
    ///   <para>cdao:GO_0005739</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"mitochondrion"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/GO_0005739">http://purl.obolibrary.org/obo/GO_0005739</seealso>
    let mitochondrion = Prefixed_Name(go, "0005739") |> PrefixedName
    /// <summary>
    ///   <para>cdao:GO_0006006</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"glucose metabolic process"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/GO_0006006">http://purl.obolibrary.org/obo/GO_0006006</seealso>
    let glucose_metabolic_process = Prefixed_Name(go, "0006006") |> PrefixedName
    /// <summary>
    ///   <para>cdao:GO_0006260</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"DNA replication"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/GO_0006260">http://purl.obolibrary.org/obo/GO_0006260</seealso>
    let DNA_replication = Prefixed_Name(go, "0006260") |> PrefixedName
    /// <summary>
    ///   <para>cdao:GO_0006306</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"DNA methylation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/GO_0006306">http://purl.obolibrary.org/obo/GO_0006306</seealso>
    let DNA_methylation = Prefixed_Name(go, "0006306") |> PrefixedName
    /// <summary>
    ///   <para>cdao:GO_0006338</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"chromatin remodeling"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/GO_0006338">http://purl.obolibrary.org/obo/GO_0006338</seealso>
    let chromatin_remodeling = Prefixed_Name(go, "0006338") |> PrefixedName
    /// <summary>
    ///   <para>cdao:GO_0006909</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"phagocytosis"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/GO_0006909">http://purl.obolibrary.org/obo/GO_0006909</seealso>
    let phagocytosis = Prefixed_Name(go, "0006909") |> PrefixedName
    /// <summary>
    ///   <para>cdao:GO_0006955</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"immune response"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/GO_0006955">http://purl.obolibrary.org/obo/GO_0006955</seealso>
    let immune_response = Prefixed_Name(go, "0006955") |> PrefixedName

    /// <summary>
    ///   <para>cdao:GO_0006974</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"cellular response to DNA damage stimulus"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/GO_0006974">http://purl.obolibrary.org/obo/GO_0006974</seealso>
    let cellular_response_to_DNA_damage_stimulus =
        Prefixed_Name(go, "0006974") |> PrefixedName

    /// <summary>
    ///   <para>cdao:GO_0007049</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"cell cycle"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/GO_0007049">http://purl.obolibrary.org/obo/GO_0007049</seealso>
    let cell_cycle = Prefixed_Name(go, "0007049") |> PrefixedName
    /// <summary>
    ///   <para>cdao:GO_0007596</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"blood coagulation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/GO_0007596">http://purl.obolibrary.org/obo/GO_0007596</seealso>
    let blood_coagulation = Prefixed_Name(go, "0007596") |> PrefixedName
    /// <summary>
    ///   <para>cdao:GO_0008150</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"biological_process"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/GO_0008150">http://purl.obolibrary.org/obo/GO_0008150</seealso>
    let biological_process = Prefixed_Name(go, "0008150") |> PrefixedName
    /// <summary>
    ///   <para>cdao:GO_0008228</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"opsonization"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/GO_0008228">http://purl.obolibrary.org/obo/GO_0008228</seealso>
    let opsonization = Prefixed_Name(go, "0008228") |> PrefixedName
    /// <summary>
    ///   <para>cdao:GO_0008283</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"cell proliferation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/GO_0008283">http://purl.obolibrary.org/obo/GO_0008283</seealso>
    let cell_proliferation = Prefixed_Name(go, "0008283") |> PrefixedName
    /// <summary>
    ///   <para>cdao:GO_0009566</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"fertilization"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/GO_0009566">http://purl.obolibrary.org/obo/GO_0009566</seealso>
    let fertilization = Prefixed_Name(go, "0009566") |> PrefixedName
    /// <summary>
    ///   <para>cdao:GO_0009987</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"cellular process"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/GO_0009987">http://purl.obolibrary.org/obo/GO_0009987</seealso>
    let cellular_process = Prefixed_Name(go, "0009987") |> PrefixedName
    /// <summary>
    ///   <para>cdao:GO_0010467</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"gene expression"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/GO_0010467">http://purl.obolibrary.org/obo/GO_0010467</seealso>
    let gene_expression = Prefixed_Name(go, "0010467") |> PrefixedName

    /// <summary>
    ///   <para>cdao:GO_0010573</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"vascular endothelial growth factor production"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/GO_0010573">http://purl.obolibrary.org/obo/GO_0010573</seealso>
    let vascular_endothelial_growth_factor_production =
        Prefixed_Name(go, "0010573") |> PrefixedName

    /// <summary>
    ///   <para>cdao:GO_0016064</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"immunoglobulin mediated immune response"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/GO_0016064">http://purl.obolibrary.org/obo/GO_0016064</seealso>
    let immunoglobulin_mediated_immune_response =
        Prefixed_Name(go, "0016064") |> PrefixedName

    /// <summary>
    ///   <para>cdao:GO_0016570</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"histone modification"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/GO_0016570">http://purl.obolibrary.org/obo/GO_0016570</seealso>
    let histone_modification = Prefixed_Name(go, "0016570") |> PrefixedName
    /// <summary>
    ///   <para>cdao:GO_0019814</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"immunoglobulin complex"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/GO_0019814">http://purl.obolibrary.org/obo/GO_0019814</seealso>
    let immunoglobulin_complex = Prefixed_Name(go, "0019814") |> PrefixedName
    /// <summary>
    ///   <para>cdao:GO_0019815</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"B cell receptor complex"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/GO_0019815">http://purl.obolibrary.org/obo/GO_0019815</seealso>
    let B_cell_receptor_complex = Prefixed_Name(go, "0019815") |> PrefixedName

    /// <summary>
    ///   <para>cdao:GO_0019882</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"antigen processing and presentation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/GO_0019882">http://purl.obolibrary.org/obo/GO_0019882</seealso>
    let antigen_processing_and_presentation =
        Prefixed_Name(go, "0019882") |> PrefixedName

    /// <summary>
    ///   <para>cdao:GO_0019904</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"protein domain specific binding"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/GO_0019904">http://purl.obolibrary.org/obo/GO_0019904</seealso>
    let protein_domain_specific_binding = Prefixed_Name(go, "0019904") |> PrefixedName
    /// <summary>
    ///   <para>cdao:GO_0030041</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"actin filament polymerization"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/GO_0030041">http://purl.obolibrary.org/obo/GO_0030041</seealso>
    let actin_filament_polymerization = Prefixed_Name(go, "0030041") |> PrefixedName
    /// <summary>
    ///   <para>cdao:GO_0030097</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"hemopoiesis"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/GO_0030097">http://purl.obolibrary.org/obo/GO_0030097</seealso>
    let hemopoiesis = Prefixed_Name(go, "0030097") |> PrefixedName

    /// <summary>
    ///   <para>cdao:GO_0032601</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"connective tissue growth factor production"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/GO_0032601">http://purl.obolibrary.org/obo/GO_0032601</seealso>
    let connective_tissue_growth_factor_production =
        Prefixed_Name(go, "0032601") |> PrefixedName

    /// <summary>
    ///   <para>cdao:GO_0032602</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"chemokine production"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/GO_0032602">http://purl.obolibrary.org/obo/GO_0032602</seealso>
    let chemokine_production = Prefixed_Name(go, "0032602") |> PrefixedName

    /// <summary>
    ///   <para>cdao:GO_0032604</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"granulocyte macrophage colony-stimulating factor production"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/GO_0032604">http://purl.obolibrary.org/obo/GO_0032604</seealso>
    let granulocyte_macrophage_colony_stimulating_factor_production =
        Prefixed_Name(go, "0032604") |> PrefixedName

    /// <summary>
    ///   <para>cdao:GO_0032605</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"hepatocyte growth factor production"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/GO_0032605">http://purl.obolibrary.org/obo/GO_0032605</seealso>
    let hepatocyte_growth_factor_production =
        Prefixed_Name(go, "0032605") |> PrefixedName

    /// <summary>
    ///   <para>cdao:GO_0032606</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"type I interferon production"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/GO_0032606">http://purl.obolibrary.org/obo/GO_0032606</seealso>
    let type_I_interferon_production = Prefixed_Name(go, "0032606") |> PrefixedName
    /// <summary>
    ///   <para>cdao:GO_0032607</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"interferon-alpha production"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/GO_0032607">http://purl.obolibrary.org/obo/GO_0032607</seealso>
    let interferon_alpha_production = Prefixed_Name(go, "0032607") |> PrefixedName
    /// <summary>
    ///   <para>cdao:GO_0032608</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"interferon-beta production"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/GO_0032608">http://purl.obolibrary.org/obo/GO_0032608</seealso>
    let interferon_beta_production = Prefixed_Name(go, "0032608") |> PrefixedName
    /// <summary>
    ///   <para>cdao:GO_0032609</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"interferon-gamma production"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/GO_0032609">http://purl.obolibrary.org/obo/GO_0032609</seealso>
    let interferon_gamma_production = Prefixed_Name(go, "0032609") |> PrefixedName
    /// <summary>
    ///   <para>cdao:GO_0032610</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"interleukin-1 alpha production"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/GO_0032610">http://purl.obolibrary.org/obo/GO_0032610</seealso>
    let interleukin_1_alpha_production = Prefixed_Name(go, "0032610") |> PrefixedName
    /// <summary>
    ///   <para>cdao:GO_0032611</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"interleukin-1 beta production"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/GO_0032611">http://purl.obolibrary.org/obo/GO_0032611</seealso>
    let interleukin_1_beta_production = Prefixed_Name(go, "0032611") |> PrefixedName
    /// <summary>
    ///   <para>cdao:GO_0032612</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"interleukin-1 production"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/GO_0032612">http://purl.obolibrary.org/obo/GO_0032612</seealso>
    let interleukin_1_production = Prefixed_Name(go, "0032612") |> PrefixedName
    /// <summary>
    ///   <para>cdao:GO_0032613</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"interleukin-10 production"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/GO_0032613">http://purl.obolibrary.org/obo/GO_0032613</seealso>
    let interleukin_10_production = Prefixed_Name(go, "0032613") |> PrefixedName
    /// <summary>
    ///   <para>cdao:GO_0032614</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"interleukin-11 production"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/GO_0032614">http://purl.obolibrary.org/obo/GO_0032614</seealso>
    let interleukin_11_production = Prefixed_Name(go, "0032614") |> PrefixedName
    /// <summary>
    ///   <para>cdao:GO_0032615</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"interleukin-12 production"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/GO_0032615">http://purl.obolibrary.org/obo/GO_0032615</seealso>
    let interleukin_12_production = Prefixed_Name(go, "0032615") |> PrefixedName
    /// <summary>
    ///   <para>cdao:GO_0032616</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"interleukin-13 production"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/GO_0032616">http://purl.obolibrary.org/obo/GO_0032616</seealso>
    let interleukin_13_production = Prefixed_Name(go, "0032616") |> PrefixedName
    /// <summary>
    ///   <para>cdao:GO_0032617</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"interleukin-14 production"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/GO_0032617">http://purl.obolibrary.org/obo/GO_0032617</seealso>
    let interleukin_14_production = Prefixed_Name(go, "0032617") |> PrefixedName
    /// <summary>
    ///   <para>cdao:GO_0032618</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"interleukin-15 production"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/GO_0032618">http://purl.obolibrary.org/obo/GO_0032618</seealso>
    let interleukin_15_production = Prefixed_Name(go, "0032618") |> PrefixedName
    /// <summary>
    ///   <para>cdao:GO_0032619</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"interleukin-16 production"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/GO_0032619">http://purl.obolibrary.org/obo/GO_0032619</seealso>
    let interleukin_16_production = Prefixed_Name(go, "0032619") |> PrefixedName
    /// <summary>
    ///   <para>cdao:GO_0032620</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"interleukin-17 production"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/GO_0032620">http://purl.obolibrary.org/obo/GO_0032620</seealso>
    let interleukin_17_production = Prefixed_Name(go, "0032620") |> PrefixedName
    /// <summary>
    ///   <para>cdao:GO_0032621</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"interleukin-18 production"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/GO_0032621">http://purl.obolibrary.org/obo/GO_0032621</seealso>
    let interleukin_18_production = Prefixed_Name(go, "0032621") |> PrefixedName
    /// <summary>
    ///   <para>cdao:GO_0032622</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"interleukin-19 production"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/GO_0032622">http://purl.obolibrary.org/obo/GO_0032622</seealso>
    let interleukin_19_production = Prefixed_Name(go, "0032622") |> PrefixedName
    /// <summary>
    ///   <para>cdao:GO_0032623</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"interleukin-2 production"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/GO_0032623">http://purl.obolibrary.org/obo/GO_0032623</seealso>
    let interleukin_2_production = Prefixed_Name(go, "0032623") |> PrefixedName
    /// <summary>
    ///   <para>cdao:GO_0032624</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"interleukin-20 production"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/GO_0032624">http://purl.obolibrary.org/obo/GO_0032624</seealso>
    let interleukin_20_production = Prefixed_Name(go, "0032624") |> PrefixedName
    /// <summary>
    ///   <para>cdao:GO_0032625</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"interleukin-21 production"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/GO_0032625">http://purl.obolibrary.org/obo/GO_0032625</seealso>
    let interleukin_21_production = Prefixed_Name(go, "0032625") |> PrefixedName
    /// <summary>
    ///   <para>cdao:GO_0032626</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"interleukin-22 production"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/GO_0032626">http://purl.obolibrary.org/obo/GO_0032626</seealso>
    let interleukin_22_production = Prefixed_Name(go, "0032626") |> PrefixedName
    /// <summary>
    ///   <para>cdao:GO_0032627</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"interleukin-23 production"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/GO_0032627">http://purl.obolibrary.org/obo/GO_0032627</seealso>
    let interleukin_23_production = Prefixed_Name(go, "0032627") |> PrefixedName
    /// <summary>
    ///   <para>cdao:GO_0032628</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"interleukin-24 production"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/GO_0032628">http://purl.obolibrary.org/obo/GO_0032628</seealso>
    let interleukin_24_production = Prefixed_Name(go, "0032628") |> PrefixedName
    /// <summary>
    ///   <para>cdao:GO_0032629</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"interleukin-25 production"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/GO_0032629">http://purl.obolibrary.org/obo/GO_0032629</seealso>
    let interleukin_25_production = Prefixed_Name(go, "0032629") |> PrefixedName
    /// <summary>
    ///   <para>cdao:GO_0032630</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"interleukin-26 production"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/GO_0032630">http://purl.obolibrary.org/obo/GO_0032630</seealso>
    let interleukin_26_production = Prefixed_Name(go, "0032630") |> PrefixedName
    /// <summary>
    ///   <para>cdao:GO_0032631</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"interleukin-27 production"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/GO_0032631">http://purl.obolibrary.org/obo/GO_0032631</seealso>
    let interleukin_27_production = Prefixed_Name(go, "0032631") |> PrefixedName
    /// <summary>
    ///   <para>cdao:GO_0032632</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"interleukin-3 production"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/GO_0032632">http://purl.obolibrary.org/obo/GO_0032632</seealso>
    let interleukin_3_production = Prefixed_Name(go, "0032632") |> PrefixedName
    /// <summary>
    ///   <para>cdao:GO_0032633</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"interleukin-4 production"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/GO_0032633">http://purl.obolibrary.org/obo/GO_0032633</seealso>
    let interleukin_4_production = Prefixed_Name(go, "0032633") |> PrefixedName
    /// <summary>
    ///   <para>cdao:GO_0032634</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"interleukin-5 production"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/GO_0032634">http://purl.obolibrary.org/obo/GO_0032634</seealso>
    let interleukin_5_production = Prefixed_Name(go, "0032634") |> PrefixedName
    /// <summary>
    ///   <para>cdao:GO_0032635</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"interleukin-6 production"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/GO_0032635">http://purl.obolibrary.org/obo/GO_0032635</seealso>
    let interleukin_6_production = Prefixed_Name(go, "0032635") |> PrefixedName
    /// <summary>
    ///   <para>cdao:GO_0032636</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"interleukin-7 production"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/GO_0032636">http://purl.obolibrary.org/obo/GO_0032636</seealso>
    let interleukin_7_production = Prefixed_Name(go, "0032636") |> PrefixedName
    /// <summary>
    ///   <para>cdao:GO_0032637</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"interleukin-8 production"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/GO_0032637">http://purl.obolibrary.org/obo/GO_0032637</seealso>
    let interleukin_8_production = Prefixed_Name(go, "0032637") |> PrefixedName
    /// <summary>
    ///   <para>cdao:GO_0032638</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"interleukin-9 production"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/GO_0032638">http://purl.obolibrary.org/obo/GO_0032638</seealso>
    let interleukin_9_production = Prefixed_Name(go, "0032638") |> PrefixedName
    /// <summary>
    ///   <para>cdao:GO_0032639</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"TRAIL production"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/GO_0032639">http://purl.obolibrary.org/obo/GO_0032639</seealso>
    let TRAIL_production = Prefixed_Name(go, "0032639") |> PrefixedName
    /// <summary>
    ///   <para>cdao:GO_0032640</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"tumor necrosis factor production"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/GO_0032640">http://purl.obolibrary.org/obo/GO_0032640</seealso>
    let tumor_necrosis_factor_production = Prefixed_Name(go, "0032640") |> PrefixedName
    /// <summary>
    ///   <para>cdao:GO_0032641</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"lymphotoxin A production"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/GO_0032641">http://purl.obolibrary.org/obo/GO_0032641</seealso>
    let lymphotoxin_A_production = Prefixed_Name(go, "0032641") |> PrefixedName

    /// <summary>
    ///   <para>cdao:GO_0032905</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"transforming growth factor beta1 production"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/GO_0032905">http://purl.obolibrary.org/obo/GO_0032905</seealso>
    let transforming_growth_factor_beta1_production =
        Prefixed_Name(go, "0032905") |> PrefixedName

    /// <summary>
    ///   <para>cdao:GO_0032906</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"transforming growth factor beta2 production"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/GO_0032906">http://purl.obolibrary.org/obo/GO_0032906</seealso>
    let transforming_growth_factor_beta2_production =
        Prefixed_Name(go, "0032906") |> PrefixedName

    /// <summary>
    ///   <para>cdao:GO_0032907</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"transforming growth factor beta3 production"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/GO_0032907">http://purl.obolibrary.org/obo/GO_0032907</seealso>
    let transforming_growth_factor_beta3_production =
        Prefixed_Name(go, "0032907") |> PrefixedName

    /// <summary>
    ///   <para>cdao:GO_0033036</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"macromolecule localization"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/GO_0033036">http://purl.obolibrary.org/obo/GO_0033036</seealso>
    let macromolecule_localization = Prefixed_Name(go, "0033036") |> PrefixedName
    /// <summary>
    ///   <para>cdao:GO_0034061</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"DNA polymerase activity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/GO_0034061">http://purl.obolibrary.org/obo/GO_0034061</seealso>
    let DNA_polymerase_activity = Prefixed_Name(go, "0034061") |> PrefixedName
    /// <summary>
    ///   <para>cdao:GO_0034343</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"type III interferon production"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/GO_0034343">http://purl.obolibrary.org/obo/GO_0034343</seealso>
    let type_III_interferon_production = Prefixed_Name(go, "0034343") |> PrefixedName

    /// <summary>
    ///   <para>cdao:GO_0035393</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"chemokine (C-X-C motif) ligand 9 production"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/GO_0035393">http://purl.obolibrary.org/obo/GO_0035393</seealso>
    let ``chemokine_(C_X_C_motif)_ligand_9_production`` =
        Prefixed_Name(go, "0035393") |> PrefixedName

    /// <summary>
    ///   <para>cdao:GO_0035397</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"helper T cell enhancement of adaptive immune response"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/GO_0035397">http://purl.obolibrary.org/obo/GO_0035397</seealso>
    let helper_T_cell_enhancement_of_adaptive_immune_response =
        Prefixed_Name(go, "0035397") |> PrefixedName

    /// <summary>
    ///   <para>cdao:GO_0035398</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"helper T cell enhancement of T cell mediated immune response"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/GO_0035398">http://purl.obolibrary.org/obo/GO_0035398</seealso>
    let helper_T_cell_enhancement_of_T_cell_mediated_immune_response =
        Prefixed_Name(go, "0035398") |> PrefixedName

    /// <summary>
    ///   <para>cdao:GO_0035399</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"helper T cell enhancement of B cell mediated immune response"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/GO_0035399">http://purl.obolibrary.org/obo/GO_0035399</seealso>
    let helper_T_cell_enhancement_of_B_cell_mediated_immune_response =
        Prefixed_Name(go, "0035399") |> PrefixedName

    /// <summary>
    ///   <para>cdao:GO_0035746</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"granzyme A production"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/GO_0035746">http://purl.obolibrary.org/obo/GO_0035746</seealso>
    let granzyme_A_production = Prefixed_Name(go, "0035746") |> PrefixedName
    /// <summary>
    ///   <para>cdao:GO_0035944</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"perforin production"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/GO_0035944">http://purl.obolibrary.org/obo/GO_0035944</seealso>
    let perforin_production = Prefixed_Name(go, "0035944") |> PrefixedName
    /// <summary>
    ///   <para>cdao:GO_0036262</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"granulysin production"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/GO_0036262">http://purl.obolibrary.org/obo/GO_0036262</seealso>
    let granulysin_production = Prefixed_Name(go, "0036262") |> PrefixedName

    /// <summary>
    ///   <para>cdao:GO_0036392</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"chemokine (C-C motif) ligand 20 production"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/GO_0036392">http://purl.obolibrary.org/obo/GO_0036392</seealso>
    let ``chemokine_(C_C_motif)_ligand_20_production`` =
        Prefixed_Name(go, "0036392") |> PrefixedName

    /// <summary>
    ///   <para>cdao:GO_0040029</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"regulation of gene expression, epigenetic"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/GO_0040029">http://purl.obolibrary.org/obo/GO_0040029</seealso>
    let ``regulation_of_gene_expression,_epigenetic`` =
        Prefixed_Name(go, "0040029") |> PrefixedName

    /// <summary>
    ///   <para>cdao:GO_0040030</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"regulation of molecular function, epigenetic"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/GO_0040030">http://purl.obolibrary.org/obo/GO_0040030</seealso>
    let ``regulation_of_molecular_function,_epigenetic`` =
        Prefixed_Name(go, "0040030") |> PrefixedName

    /// <summary>
    ///   <para>cdao:GO_0042098</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"T cell proliferation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/GO_0042098">http://purl.obolibrary.org/obo/GO_0042098</seealso>
    let T_cell_proliferation = Prefixed_Name(go, "0042098") |> PrefixedName
    /// <summary>
    ///   <para>cdao:GO_0042101</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"T cell receptor complex"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/GO_0042101">http://purl.obolibrary.org/obo/GO_0042101</seealso>
    let T_cell_receptor_complex = Prefixed_Name(go, "0042101") |> PrefixedName
    /// <summary>
    ///   <para>cdao:GO_0042110</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"T cell activation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/GO_0042110">http://purl.obolibrary.org/obo/GO_0042110</seealso>
    let T_cell_activation = Prefixed_Name(go, "0042110") |> PrefixedName

    /// <summary>
    ///   <para>cdao:GO_0042571</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"immunoglobulin complex, circulating"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/GO_0042571">http://purl.obolibrary.org/obo/GO_0042571</seealso>
    let ``immunoglobulin_complex,_circulating`` =
        Prefixed_Name(go, "0042571") |> PrefixedName

    /// <summary>
    ///   <para>cdao:GO_0042575</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"DNA polymerase complex"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/GO_0042575">http://purl.obolibrary.org/obo/GO_0042575</seealso>
    let DNA_polymerase_complex = Prefixed_Name(go, "0042575") |> PrefixedName
    /// <summary>
    ///   <para>cdao:GO_0042605</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"peptide antigen binding"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/GO_0042605">http://purl.obolibrary.org/obo/GO_0042605</seealso>
    let peptide_antigen_binding = Prefixed_Name(go, "0042605") |> PrefixedName
    /// <summary>
    ///   <para>cdao:GO_0042611</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"MHC protein complex"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/GO_0042611">http://purl.obolibrary.org/obo/GO_0042611</seealso>
    let MHC_protein_complex = Prefixed_Name(go, "0042611") |> PrefixedName
    /// <summary>
    ///   <para>cdao:GO_0043227</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"membrane-bounded organelle"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/GO_0043227">http://purl.obolibrary.org/obo/GO_0043227</seealso>
    let membrane_bounded_organelle = Prefixed_Name(go, "0043227") |> PrefixedName
    /// <summary>
    ///   <para>cdao:GO_0043234</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"protein complex"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/GO_0043234">http://purl.obolibrary.org/obo/GO_0043234</seealso>
    let protein_complex = Prefixed_Name(go, "0043234") |> PrefixedName
    /// <summary>
    ///   <para>cdao:GO_0043316</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"cytotoxic T cell degranulation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/GO_0043316">http://purl.obolibrary.org/obo/GO_0043316</seealso>
    let cytotoxic_T_cell_degranulation = Prefixed_Name(go, "0043316") |> PrefixedName
    /// <summary>
    ///   <para>cdao:GO_0043565</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"sequence-specific DNA binding"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/GO_0043565">http://purl.obolibrary.org/obo/GO_0043565</seealso>
    let sequence_specific_DNA_binding = Prefixed_Name(go, "0043565") |> PrefixedName
    /// <summary>
    ///   <para>cdao:GO_0044030</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"regulation of DNA methylation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/GO_0044030">http://purl.obolibrary.org/obo/GO_0044030</seealso>
    let regulation_of_DNA_methylation = Prefixed_Name(go, "0044030") |> PrefixedName

    /// <summary>
    ///   <para>cdao:GO_0044807</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"macrophage migration inhibitory factor production"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/GO_0044807">http://purl.obolibrary.org/obo/GO_0044807</seealso>
    let macrophage_migration_inhibitory_factor_production =
        Prefixed_Name(go, "0044807") |> PrefixedName

    /// <summary>
    ///   <para>cdao:GO_0044808</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Oncostatin M production"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/GO_0044808">http://purl.obolibrary.org/obo/GO_0044808</seealso>
    let Oncostatin_M_production = Prefixed_Name(go, "0044808") |> PrefixedName

    /// <summary>
    ///   <para>cdao:GO_0044809</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"chemokine (C-C motif) ligand 17 production"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/GO_0044809">http://purl.obolibrary.org/obo/GO_0044809</seealso>
    let ``chemokine_(C_C_motif)_ligand_17_production`` =
        Prefixed_Name(go, "0044809") |> PrefixedName

    /// <summary>
    ///   <para>cdao:GO_0048869</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"cellular developmental process"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/GO_0048869">http://purl.obolibrary.org/obo/GO_0048869</seealso>
    let cellular_developmental_process = Prefixed_Name(go, "0048869") |> PrefixedName
    /// <summary>
    ///   <para>cdao:GO_0050896</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"response to stimulus"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/GO_0050896">http://purl.obolibrary.org/obo/GO_0050896</seealso>
    let response_to_stimulus = Prefixed_Name(go, "0050896") |> PrefixedName
    /// <summary>
    ///   <para>cdao:GO_0051276</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"chromosome organization"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/GO_0051276">http://purl.obolibrary.org/obo/GO_0051276</seealso>
    let chromosome_organization = Prefixed_Name(go, "0051276") |> PrefixedName

    /// <summary>
    ///   <para>cdao:GO_0070358</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"actin polymerization-dependent cell motility"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/GO_0070358">http://purl.obolibrary.org/obo/GO_0070358</seealso>
    let actin_polymerization_dependent_cell_motility =
        Prefixed_Name(go, "0070358") |> PrefixedName

    /// <summary>
    ///   <para>cdao:GO_0071604</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"transforming growth factor beta production"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/GO_0071604">http://purl.obolibrary.org/obo/GO_0071604</seealso>
    let transforming_growth_factor_beta_production =
        Prefixed_Name(go, "0071604") |> PrefixedName

    /// <summary>
    ///   <para>cdao:GO_0071605</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"monocyte chemotactic protein-1 production"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/GO_0071605">http://purl.obolibrary.org/obo/GO_0071605</seealso>
    let monocyte_chemotactic_protein_1_production =
        Prefixed_Name(go, "0071605") |> PrefixedName

    /// <summary>
    ///   <para>cdao:GO_0071606</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"chemokine (C-C motif) ligand 4 production"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/GO_0071606">http://purl.obolibrary.org/obo/GO_0071606</seealso>
    let ``chemokine_(C_C_motif)_ligand_4_production`` =
        Prefixed_Name(go, "0071606") |> PrefixedName

    /// <summary>
    ///   <para>cdao:GO_0071607</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"macrophage inflammatory protein-1 gamma production"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/GO_0071607">http://purl.obolibrary.org/obo/GO_0071607</seealso>
    let macrophage_inflammatory_protein_1_gamma_production =
        Prefixed_Name(go, "0071607") |> PrefixedName

    /// <summary>
    ///   <para>cdao:GO_0071608</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"macrophage inflammatory protein-1 alpha production"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/GO_0071608">http://purl.obolibrary.org/obo/GO_0071608</seealso>
    let macrophage_inflammatory_protein_1_alpha_production =
        Prefixed_Name(go, "0071608") |> PrefixedName

    /// <summary>
    ///   <para>cdao:GO_0071609</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"chemokine (C-C motif) ligand 5 production"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/GO_0071609">http://purl.obolibrary.org/obo/GO_0071609</seealso>
    let ``chemokine_(C_C_motif)_ligand_5_production`` =
        Prefixed_Name(go, "0071609") |> PrefixedName

    /// <summary>
    ///   <para>cdao:GO_0071610</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"chemokine (C-C motif) ligand 1 production"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/GO_0071610">http://purl.obolibrary.org/obo/GO_0071610</seealso>
    let ``chemokine_(C_C_motif)_ligand_1_production`` =
        Prefixed_Name(go, "0071610") |> PrefixedName

    /// <summary>
    ///   <para>cdao:GO_0071611</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"granulocyte colony-stimulating factor production"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/GO_0071611">http://purl.obolibrary.org/obo/GO_0071611</seealso>
    let granulocyte_colony_stimulating_factor_production =
        Prefixed_Name(go, "0071611") |> PrefixedName

    /// <summary>
    ///   <para>cdao:GO_0071612</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"IP-10 production"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/GO_0071612">http://purl.obolibrary.org/obo/GO_0071612</seealso>
    let IP_10_production = Prefixed_Name(go, "0071612") |> PrefixedName
    /// <summary>
    ///   <para>cdao:GO_0071613</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"granzyme B production"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/GO_0071613">http://purl.obolibrary.org/obo/GO_0071613</seealso>
    let granzyme_B_production = Prefixed_Name(go, "0071613") |> PrefixedName

    /// <summary>
    ///   <para>cdao:GO_0071706</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"tumor necrosis factor superfamily cytokine production"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/GO_0071706">http://purl.obolibrary.org/obo/GO_0071706</seealso>
    let tumor_necrosis_factor_superfamily_cytokine_production =
        Prefixed_Name(go, "0071706") |> PrefixedName

    /// <summary>
    ///   <para>cdao:GO_0071924</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"chemokine (C-C motif) ligand 22 production"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/GO_0071924">http://purl.obolibrary.org/obo/GO_0071924</seealso>
    let ``chemokine_(C_C_motif)_ligand_22_production`` =
        Prefixed_Name(go, "0071924") |> PrefixedName

    /// <summary>
    ///   <para>cdao:GO_0072535</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"tumor necrosis factor (ligand) superfamily member 11 production"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/GO_0072535">http://purl.obolibrary.org/obo/GO_0072535</seealso>
    let ``tumor_necrosis_factor_(ligand)_superfamily_member_11_production`` =
        Prefixed_Name(go, "0072535") |> PrefixedName

    /// <summary>
    ///   <para>cdao:GO_0097087</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"interleukin-17A production"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/GO_0097087">http://purl.obolibrary.org/obo/GO_0097087</seealso>
    let interleukin_17A_production = Prefixed_Name(go, "0097087") |> PrefixedName
    /// <summary>
    ///   <para>cdao:GO_0097088</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"interleukin-17F production"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/GO_0097088">http://purl.obolibrary.org/obo/GO_0097088</seealso>
    let interleukin_17F_production = Prefixed_Name(go, "0097088") |> PrefixedName
    /// <summary>
    ///   <para>cdao:GO_0097278</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"complement-dependent cytotoxicity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/GO_0097278">http://purl.obolibrary.org/obo/GO_0097278</seealso>
    let complement_dependent_cytotoxicity = Prefixed_Name(go, "0097278") |> PrefixedName

    /// <summary>
    ///   <para>cdao:GO_0097280</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"histamine secretion mediated by immunoglobulin"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/GO_0097280">http://purl.obolibrary.org/obo/GO_0097280</seealso>
    let histamine_secretion_mediated_by_immunoglobulin =
        Prefixed_Name(go, "0097280") |> PrefixedName

    /// <summary>
    ///   <para>cdao:GO_0097281</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"immune complex formation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/GO_0097281">http://purl.obolibrary.org/obo/GO_0097281</seealso>
    let immune_complex_formation = Prefixed_Name(go, "0097281") |> PrefixedName

    /// <summary>
    ///   <para>cdao:GO_0097282</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"immunoglobulin-mediated neutralization"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/GO_0097282">http://purl.obolibrary.org/obo/GO_0097282</seealso>
    let immunoglobulin_mediated_neutralization =
        Prefixed_Name(go, "0097282") |> PrefixedName

    /// <summary>
    ///   <para>cdao:GO_0097388</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"chemokine (C-C motif) ligand 19 production"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/GO_0097388">http://purl.obolibrary.org/obo/GO_0097388</seealso>
    let ``chemokine_(C_C_motif)_ligand_19_production`` =
        Prefixed_Name(go, "0097388") |> PrefixedName

    /// <summary>
    ///   <para>cdao:GO_0097389</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"chemokine (C-C motif) ligand 21 production"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/GO_0097389">http://purl.obolibrary.org/obo/GO_0097389</seealso>
    let ``chemokine_(C_C_motif)_ligand_21_production`` =
        Prefixed_Name(go, "0097389") |> PrefixedName

    /// <summary>
    ///   <para>cdao:GO_0097390</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"chemokine (C-X-C motif) ligand 12 production"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/GO_0097390">http://purl.obolibrary.org/obo/GO_0097390</seealso>
    let ``chemokine_(C_X_C_motif)_ligand_12_production`` =
        Prefixed_Name(go, "0097390") |> PrefixedName

    /// <summary>
    ///   <para>cdao:GO_0097391</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"chemokine (C-X-C motif) ligand 13 production"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/GO_0097391">http://purl.obolibrary.org/obo/GO_0097391</seealso>
    let ``chemokine_(C_X_C_motif)_ligand_13_production`` =
        Prefixed_Name(go, "0097391") |> PrefixedName

    /// <summary>
    ///   <para>cdao:GO_0097392</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"chemokine (C-X-C motif) ligand 16 production"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/GO_0097392">http://purl.obolibrary.org/obo/GO_0097392</seealso>
    let ``chemokine_(C_X_C_motif)_ligand_16_production`` =
        Prefixed_Name(go, "0097392") |> PrefixedName

    /// <summary>
    ///   <para>cdao:GO_0097458</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"neuron part"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/GO_0097458">http://purl.obolibrary.org/obo/GO_0097458</seealso>
    let neuron_part = Prefixed_Name(go, "0097458") |> PrefixedName
