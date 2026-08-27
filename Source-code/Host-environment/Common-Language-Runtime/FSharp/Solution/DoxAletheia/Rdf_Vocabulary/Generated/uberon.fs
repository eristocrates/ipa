namespace http.purl.obolibrary.org.obo.UBERON_.bare

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module uberon =
    let _namespace_iri = Namespace_Iri uberon |> NamespaceIRI
    /// <summary>
    ///   <para>cdao:UBERON_0000007</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"pituitary gland"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/UBERON_0000007">http://purl.obolibrary.org/obo/UBERON_0000007</seealso>
    let pituitary_gland = Prefixed_Name(uberon, "0000007") |> PrefixedName
    /// <summary>
    ///   <para>cdao:UBERON_0000029</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"lymph node"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/UBERON_0000029">http://purl.obolibrary.org/obo/UBERON_0000029</seealso>
    let lymph_node = Prefixed_Name(uberon, "0000029") |> PrefixedName
    /// <summary>
    ///   <para>cdao:UBERON_0000068</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/UBERON_0000068">http://purl.obolibrary.org/obo/UBERON_0000068</seealso>
    let _0000068 = Prefixed_Name(uberon, "0000068") |> PrefixedName
    /// <summary>
    ///   <para>cdao:UBERON_0000069</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/UBERON_0000069">http://purl.obolibrary.org/obo/UBERON_0000069</seealso>
    let _0000069 = Prefixed_Name(uberon, "0000069") |> PrefixedName
    /// <summary>
    ///   <para>cdao:UBERON_0000105</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"life cycle stage"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/UBERON_0000105">http://purl.obolibrary.org/obo/UBERON_0000105</seealso>
    let life_cycle_stage = Prefixed_Name(uberon, "0000105") |> PrefixedName
    /// <summary>
    ///   <para>cdao:UBERON_0000165</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"mouth"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/UBERON_0000165">http://purl.obolibrary.org/obo/UBERON_0000165</seealso>
    let mouth = Prefixed_Name(uberon, "0000165") |> PrefixedName
    /// <summary>
    ///   <para>cdao:UBERON_0000173</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"amniotic fluid"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/UBERON_0000173">http://purl.obolibrary.org/obo/UBERON_0000173</seealso>
    let amniotic_fluid = Prefixed_Name(uberon, "0000173") |> PrefixedName
    /// <summary>
    ///   <para>cdao:UBERON_0000178</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"blood"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/UBERON_0000178">http://purl.obolibrary.org/obo/UBERON_0000178</seealso>
    let blood = Prefixed_Name(uberon, "0000178") |> PrefixedName
    /// <summary>
    ///   <para>cdao:UBERON_0000310</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"breast"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/UBERON_0000310">http://purl.obolibrary.org/obo/UBERON_0000310</seealso>
    let breast = Prefixed_Name(uberon, "0000310") |> PrefixedName
    /// <summary>
    ///   <para>cdao:UBERON_0000362</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"renal medulla"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/UBERON_0000362">http://purl.obolibrary.org/obo/UBERON_0000362</seealso>
    let renal_medulla = Prefixed_Name(uberon, "0000362") |> PrefixedName
    /// <summary>
    ///   <para>cdao:UBERON_0000463</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"organism substance"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/UBERON_0000463">http://purl.obolibrary.org/obo/UBERON_0000463</seealso>
    let organism_substance = Prefixed_Name(uberon, "0000463") |> PrefixedName
    /// <summary>
    ///   <para>cdao:UBERON_0000465</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"material anatomical entity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/UBERON_0000465">http://purl.obolibrary.org/obo/UBERON_0000465</seealso>
    let material_anatomical_entity = Prefixed_Name(uberon, "0000465") |> PrefixedName
    /// <summary>
    ///   <para>cdao:UBERON_0000473</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"testis"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/UBERON_0000473">http://purl.obolibrary.org/obo/UBERON_0000473</seealso>
    let testis = Prefixed_Name(uberon, "0000473") |> PrefixedName
    /// <summary>
    ///   <para>cdao:UBERON_0000477</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"anatomical cluster"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/UBERON_0000477">http://purl.obolibrary.org/obo/UBERON_0000477</seealso>
    let anatomical_cluster = Prefixed_Name(uberon, "0000477") |> PrefixedName
    /// <summary>
    ///   <para>cdao:UBERON_0000479</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"tissue"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/UBERON_0000479">http://purl.obolibrary.org/obo/UBERON_0000479</seealso>
    let tissue = Prefixed_Name(uberon, "0000479") |> PrefixedName
    /// <summary>
    ///   <para>cdao:UBERON_0000481</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"multi-tissue structure"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/UBERON_0000481">http://purl.obolibrary.org/obo/UBERON_0000481</seealso>
    let multi_tissue_structure = Prefixed_Name(uberon, "0000481") |> PrefixedName
    /// <summary>
    ///   <para>cdao:UBERON_0000483</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"epithelium"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/UBERON_0000483">http://purl.obolibrary.org/obo/UBERON_0000483</seealso>
    let epithelium = Prefixed_Name(uberon, "0000483") |> PrefixedName
    /// <summary>
    ///   <para>cdao:UBERON_0000945</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"stomach"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/UBERON_0000945">http://purl.obolibrary.org/obo/UBERON_0000945</seealso>
    let stomach = Prefixed_Name(uberon, "0000945") |> PrefixedName
    /// <summary>
    ///   <para>cdao:UBERON_0000947</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"aorta"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/UBERON_0000947">http://purl.obolibrary.org/obo/UBERON_0000947</seealso>
    let aorta = Prefixed_Name(uberon, "0000947") |> PrefixedName
    /// <summary>
    ///   <para>cdao:UBERON_0000948</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"heart"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/UBERON_0000948">http://purl.obolibrary.org/obo/UBERON_0000948</seealso>
    let heart = Prefixed_Name(uberon, "0000948") |> PrefixedName
    /// <summary>
    ///   <para>cdao:UBERON_0000955</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"brain"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/UBERON_0000955">http://purl.obolibrary.org/obo/UBERON_0000955</seealso>
    let brain = Prefixed_Name(uberon, "0000955") |> PrefixedName
    /// <summary>
    ///   <para>cdao:UBERON_0000956</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"cerebral cortex"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/UBERON_0000956">http://purl.obolibrary.org/obo/UBERON_0000956</seealso>
    let cerebral_cortex = Prefixed_Name(uberon, "0000956") |> PrefixedName
    /// <summary>
    ///   <para>cdao:UBERON_0000992</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"ovary"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/UBERON_0000992">http://purl.obolibrary.org/obo/UBERON_0000992</seealso>
    let ovary = Prefixed_Name(uberon, "0000992") |> PrefixedName
    /// <summary>
    ///   <para>cdao:UBERON_0000995</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"uterus"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/UBERON_0000995">http://purl.obolibrary.org/obo/UBERON_0000995</seealso>
    let uterus = Prefixed_Name(uberon, "0000995") |> PrefixedName
    /// <summary>
    ///   <para>cdao:UBERON_0000996</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"vagina"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/UBERON_0000996">http://purl.obolibrary.org/obo/UBERON_0000996</seealso>
    let vagina = Prefixed_Name(uberon, "0000996") |> PrefixedName
    /// <summary>
    ///   <para>cdao:UBERON_0001013</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"adipose tissue"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/UBERON_0001013">http://purl.obolibrary.org/obo/UBERON_0001013</seealso>
    let adipose_tissue = Prefixed_Name(uberon, "0001013") |> PrefixedName
    /// <summary>
    ///   <para>cdao:UBERON_0001037</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"strand of hair"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/UBERON_0001037">http://purl.obolibrary.org/obo/UBERON_0001037</seealso>
    let strand_of_hair = Prefixed_Name(uberon, "0001037") |> PrefixedName
    /// <summary>
    ///   <para>cdao:UBERON_0001052</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"rectum"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/UBERON_0001052">http://purl.obolibrary.org/obo/UBERON_0001052</seealso>
    let rectum = Prefixed_Name(uberon, "0001052") |> PrefixedName
    /// <summary>
    ///   <para>cdao:UBERON_0001087</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"pleural fluid"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/UBERON_0001087">http://purl.obolibrary.org/obo/UBERON_0001087</seealso>
    let pleural_fluid = Prefixed_Name(uberon, "0001087") |> PrefixedName
    /// <summary>
    ///   <para>cdao:UBERON_0001088</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"urine"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/UBERON_0001088">http://purl.obolibrary.org/obo/UBERON_0001088</seealso>
    let urine = Prefixed_Name(uberon, "0001088") |> PrefixedName
    /// <summary>
    ///   <para>cdao:UBERON_0001089</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"sweat"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/UBERON_0001089">http://purl.obolibrary.org/obo/UBERON_0001089</seealso>
    let sweat = Prefixed_Name(uberon, "0001089") |> PrefixedName
    /// <summary>
    ///   <para>cdao:UBERON_0001090</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"synovial fluid"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/UBERON_0001090">http://purl.obolibrary.org/obo/UBERON_0001090</seealso>
    let synovial_fluid = Prefixed_Name(uberon, "0001090") |> PrefixedName
    /// <summary>
    ///   <para>cdao:UBERON_0001134</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"skeletal muscle tissue"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/UBERON_0001134">http://purl.obolibrary.org/obo/UBERON_0001134</seealso>
    let skeletal_muscle_tissue = Prefixed_Name(uberon, "0001134") |> PrefixedName
    /// <summary>
    ///   <para>cdao:UBERON_0001155</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"colon"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/UBERON_0001155">http://purl.obolibrary.org/obo/UBERON_0001155</seealso>
    let colon = Prefixed_Name(uberon, "0001155") |> PrefixedName
    /// <summary>
    ///   <para>cdao:UBERON_0001159</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"sigmoid colon"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/UBERON_0001159">http://purl.obolibrary.org/obo/UBERON_0001159</seealso>
    let sigmoid_colon = Prefixed_Name(uberon, "0001159") |> PrefixedName
    /// <summary>
    ///   <para>cdao:UBERON_0001225</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"cortex of kidney"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/UBERON_0001225">http://purl.obolibrary.org/obo/UBERON_0001225</seealso>
    let cortex_of_kidney = Prefixed_Name(uberon, "0001225") |> PrefixedName
    /// <summary>
    ///   <para>cdao:UBERON_0001255</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"urinary bladder"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/UBERON_0001255">http://purl.obolibrary.org/obo/UBERON_0001255</seealso>
    let urinary_bladder = Prefixed_Name(uberon, "0001255") |> PrefixedName
    /// <summary>
    ///   <para>cdao:UBERON_0001264</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"pancreas"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/UBERON_0001264">http://purl.obolibrary.org/obo/UBERON_0001264</seealso>
    let pancreas = Prefixed_Name(uberon, "0001264") |> PrefixedName
    /// <summary>
    ///   <para>cdao:UBERON_0001268</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"peritoneal fluid"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/UBERON_0001268">http://purl.obolibrary.org/obo/UBERON_0001268</seealso>
    let peritoneal_fluid = Prefixed_Name(uberon, "0001268") |> PrefixedName
    /// <summary>
    ///   <para>cdao:UBERON_0001323</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"tibial nerve"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/UBERON_0001323">http://purl.obolibrary.org/obo/UBERON_0001323</seealso>
    let tibial_nerve = Prefixed_Name(uberon, "0001323") |> PrefixedName
    /// <summary>
    ///   <para>cdao:UBERON_0001359</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"cerebrospinal fluid"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/UBERON_0001359">http://purl.obolibrary.org/obo/UBERON_0001359</seealso>
    let cerebrospinal_fluid = Prefixed_Name(uberon, "0001359") |> PrefixedName
    /// <summary>
    ///   <para>cdao:UBERON_0001567</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"cheek"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/UBERON_0001567">http://purl.obolibrary.org/obo/UBERON_0001567</seealso>
    let cheek = Prefixed_Name(uberon, "0001567") |> PrefixedName
    /// <summary>
    ///   <para>cdao:UBERON_0001621</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"coronary artery"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/UBERON_0001621">http://purl.obolibrary.org/obo/UBERON_0001621</seealso>
    let coronary_artery = Prefixed_Name(uberon, "0001621") |> PrefixedName
    /// <summary>
    ///   <para>cdao:UBERON_0001638</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"vein"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/UBERON_0001638">http://purl.obolibrary.org/obo/UBERON_0001638</seealso>
    let vein = Prefixed_Name(uberon, "0001638") |> PrefixedName
    /// <summary>
    ///   <para>cdao:UBERON_0001723</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"tongue"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/UBERON_0001723">http://purl.obolibrary.org/obo/UBERON_0001723</seealso>
    let tongue = Prefixed_Name(uberon, "0001723") |> PrefixedName
    /// <summary>
    ///   <para>cdao:UBERON_0001728</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"nasopharynx"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/UBERON_0001728">http://purl.obolibrary.org/obo/UBERON_0001728</seealso>
    let nasopharynx = Prefixed_Name(uberon, "0001728") |> PrefixedName
    /// <summary>
    ///   <para>cdao:UBERON_0001729</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"oropharynx"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/UBERON_0001729">http://purl.obolibrary.org/obo/UBERON_0001729</seealso>
    let oropharynx = Prefixed_Name(uberon, "0001729") |> PrefixedName
    /// <summary>
    ///   <para>cdao:UBERON_0001797</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"vitreous humor"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/UBERON_0001797">http://purl.obolibrary.org/obo/UBERON_0001797</seealso>
    let vitreous_humor = Prefixed_Name(uberon, "0001797") |> PrefixedName
    /// <summary>
    ///   <para>cdao:UBERON_0001830</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"minor salivary gland"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/UBERON_0001830">http://purl.obolibrary.org/obo/UBERON_0001830</seealso>
    let minor_salivary_gland = Prefixed_Name(uberon, "0001830") |> PrefixedName
    /// <summary>
    ///   <para>cdao:UBERON_0001836</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"saliva"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/UBERON_0001836">http://purl.obolibrary.org/obo/UBERON_0001836</seealso>
    let saliva = Prefixed_Name(uberon, "0001836") |> PrefixedName
    /// <summary>
    ///   <para>cdao:UBERON_0001873</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"caudate nucleus"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/UBERON_0001873">http://purl.obolibrary.org/obo/UBERON_0001873</seealso>
    let caudate_nucleus = Prefixed_Name(uberon, "0001873") |> PrefixedName
    /// <summary>
    ///   <para>cdao:UBERON_0001874</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"putamen"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/UBERON_0001874">http://purl.obolibrary.org/obo/UBERON_0001874</seealso>
    let putamen = Prefixed_Name(uberon, "0001874") |> PrefixedName
    /// <summary>
    ///   <para>cdao:UBERON_0001913</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"milk"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/UBERON_0001913">http://purl.obolibrary.org/obo/UBERON_0001913</seealso>
    let milk = Prefixed_Name(uberon, "0001913") |> PrefixedName
    /// <summary>
    ///   <para>cdao:UBERON_0001970</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"bile"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/UBERON_0001970">http://purl.obolibrary.org/obo/UBERON_0001970</seealso>
    let bile = Prefixed_Name(uberon, "0001970") |> PrefixedName
    /// <summary>
    ///   <para>cdao:UBERON_0001987</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"placenta"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/UBERON_0001987">http://purl.obolibrary.org/obo/UBERON_0001987</seealso>
    let placenta = Prefixed_Name(uberon, "0001987") |> PrefixedName
    /// <summary>
    ///   <para>cdao:UBERON_0001988</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"feces"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/UBERON_0001988">http://purl.obolibrary.org/obo/UBERON_0001988</seealso>
    let feces = Prefixed_Name(uberon, "0001988") |> PrefixedName
    /// <summary>
    ///   <para>cdao:UBERON_0002032</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"areola"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/UBERON_0002032">http://purl.obolibrary.org/obo/UBERON_0002032</seealso>
    let areola = Prefixed_Name(uberon, "0002032") |> PrefixedName
    /// <summary>
    ///   <para>cdao:UBERON_0002037</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"cerebellum"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/UBERON_0002037">http://purl.obolibrary.org/obo/UBERON_0002037</seealso>
    let cerebellum = Prefixed_Name(uberon, "0002037") |> PrefixedName
    /// <summary>
    ///   <para>cdao:UBERON_0002046</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"thyroid gland"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/UBERON_0002046">http://purl.obolibrary.org/obo/UBERON_0002046</seealso>
    let thyroid_gland = Prefixed_Name(uberon, "0002046") |> PrefixedName
    /// <summary>
    ///   <para>cdao:UBERON_0002048</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"lung"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/UBERON_0002048">http://purl.obolibrary.org/obo/UBERON_0002048</seealso>
    let lung = Prefixed_Name(uberon, "0002048") |> PrefixedName
    /// <summary>
    ///   <para>cdao:UBERON_0002067</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"dermis"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/UBERON_0002067">http://purl.obolibrary.org/obo/UBERON_0002067</seealso>
    let dermis = Prefixed_Name(uberon, "0002067") |> PrefixedName
    /// <summary>
    ///   <para>cdao:UBERON_0002072</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"hypodermis"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/UBERON_0002072">http://purl.obolibrary.org/obo/UBERON_0002072</seealso>
    let hypodermis = Prefixed_Name(uberon, "0002072") |> PrefixedName
    /// <summary>
    ///   <para>cdao:UBERON_0002097</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"skin of body"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/UBERON_0002097">http://purl.obolibrary.org/obo/UBERON_0002097</seealso>
    let skin_of_body = Prefixed_Name(uberon, "0002097") |> PrefixedName
    /// <summary>
    ///   <para>cdao:UBERON_0002106</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"spleen"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/UBERON_0002106">http://purl.obolibrary.org/obo/UBERON_0002106</seealso>
    let spleen = Prefixed_Name(uberon, "0002106") |> PrefixedName
    /// <summary>
    ///   <para>cdao:UBERON_0002107</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"liver"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/UBERON_0002107">http://purl.obolibrary.org/obo/UBERON_0002107</seealso>
    let liver = Prefixed_Name(uberon, "0002107") |> PrefixedName
    /// <summary>
    ///   <para>cdao:UBERON_0002116</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"ileum"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/UBERON_0002116">http://purl.obolibrary.org/obo/UBERON_0002116</seealso>
    let ileum = Prefixed_Name(uberon, "0002116") |> PrefixedName
    /// <summary>
    ///   <para>cdao:UBERON_0002358</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"peritoneum"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/UBERON_0002358">http://purl.obolibrary.org/obo/UBERON_0002358</seealso>
    let peritoneum = Prefixed_Name(uberon, "0002358") |> PrefixedName
    /// <summary>
    ///   <para>cdao:UBERON_0002367</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"prostate gland"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/UBERON_0002367">http://purl.obolibrary.org/obo/UBERON_0002367</seealso>
    let prostate_gland = Prefixed_Name(uberon, "0002367") |> PrefixedName
    /// <summary>
    ///   <para>cdao:UBERON_0002369</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"adrenal gland"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/UBERON_0002369">http://purl.obolibrary.org/obo/UBERON_0002369</seealso>
    let adrenal_gland = Prefixed_Name(uberon, "0002369") |> PrefixedName
    /// <summary>
    ///   <para>cdao:UBERON_0002371</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"bone marrow"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/UBERON_0002371">http://purl.obolibrary.org/obo/UBERON_0002371</seealso>
    let bone_marrow = Prefixed_Name(uberon, "0002371") |> PrefixedName
    /// <summary>
    ///   <para>cdao:UBERON_0002409</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"pericardial fluid"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/UBERON_0002409">http://purl.obolibrary.org/obo/UBERON_0002409</seealso>
    let pericardial_fluid = Prefixed_Name(uberon, "0002409") |> PrefixedName
    /// <summary>
    ///   <para>cdao:UBERON_0002469</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"esophagus mucosa"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/UBERON_0002469">http://purl.obolibrary.org/obo/UBERON_0002469</seealso>
    let esophagus_mucosa = Prefixed_Name(uberon, "0002469") |> PrefixedName
    /// <summary>
    ///   <para>cdao:UBERON_0002812</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"left cerebral hemisphere"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/UBERON_0002812">http://purl.obolibrary.org/obo/UBERON_0002812</seealso>
    let left_cerebral_hemisphere = Prefixed_Name(uberon, "0002812") |> PrefixedName
    /// <summary>
    ///   <para>cdao:UBERON_0002813</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"right cerebral hemisphere"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/UBERON_0002813">http://purl.obolibrary.org/obo/UBERON_0002813</seealso>
    let right_cerebral_hemisphere = Prefixed_Name(uberon, "0002813") |> PrefixedName
    /// <summary>
    ///   <para>cdao:UBERON_0003688</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"omentum"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/UBERON_0003688">http://purl.obolibrary.org/obo/UBERON_0003688</seealso>
    let omentum = Prefixed_Name(uberon, "0003688") |> PrefixedName
    /// <summary>
    ///   <para>cdao:UBERON_0004648</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"esophagus muscularis mucosa"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/UBERON_0004648">http://purl.obolibrary.org/obo/UBERON_0004648</seealso>
    let esophagus_muscularis_mucosa = Prefixed_Name(uberon, "0004648") |> PrefixedName
    /// <summary>
    ///   <para>cdao:UBERON_0005022</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"mucosa of nasopharynx"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/UBERON_0005022">http://purl.obolibrary.org/obo/UBERON_0005022</seealso>
    let mucosa_of_nasopharynx = Prefixed_Name(uberon, "0005022") |> PrefixedName
    /// <summary>
    ///   <para>cdao:UBERON_0005023</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"mucosa of oropharynx"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/UBERON_0005023">http://purl.obolibrary.org/obo/UBERON_0005023</seealso>
    let mucosa_of_oropharynx = Prefixed_Name(uberon, "0005023") |> PrefixedName
    /// <summary>
    ///   <para>cdao:UBERON_0006618</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"atrium auricular region"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/UBERON_0006618">http://purl.obolibrary.org/obo/UBERON_0006618</seealso>
    let atrium_auricular_region = Prefixed_Name(uberon, "0006618") |> PrefixedName

    /// <summary>
    ///   <para>cdao:UBERON_0006911</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"digestive system secreted substance"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/UBERON_0006911">http://purl.obolibrary.org/obo/UBERON_0006911</seealso>
    let digestive_system_secreted_substance =
        Prefixed_Name(uberon, "0006911") |> PrefixedName

    /// <summary>
    ///   <para>cdao:UBERON_0007311</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"sputum"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/UBERON_0007311">http://purl.obolibrary.org/obo/UBERON_0007311</seealso>
    let sputum = Prefixed_Name(uberon, "0007311") |> PrefixedName
    /// <summary>
    ///   <para>cdao:UBERON_0007610</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"tibial artery"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/UBERON_0007610">http://purl.obolibrary.org/obo/UBERON_0007610</seealso>
    let tibial_artery = Prefixed_Name(uberon, "0007610") |> PrefixedName
    /// <summary>
    ///   <para>cdao:UBERON_0007650</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"esophagogastric junction"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/UBERON_0007650">http://purl.obolibrary.org/obo/UBERON_0007650</seealso>
    let esophagogastric_junction = Prefixed_Name(uberon, "0007650") |> PrefixedName
    /// <summary>
    ///   <para>cdao:UBERON_0014406</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/UBERON_0014406">http://purl.obolibrary.org/obo/UBERON_0014406</seealso>
    let _0014406 = Prefixed_Name(uberon, "0014406") |> PrefixedName
    /// <summary>
    ///   <para>cdao:UBERON_0014857</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/UBERON_0014857">http://purl.obolibrary.org/obo/UBERON_0014857</seealso>
    let _0014857 = Prefixed_Name(uberon, "0014857") |> PrefixedName
    /// <summary>
    ///   <para>cdao:UBERON_0014859</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/UBERON_0014859">http://purl.obolibrary.org/obo/UBERON_0014859</seealso>
    let _0014859 = Prefixed_Name(uberon, "0014859") |> PrefixedName
    /// <summary>
    ///   <para>cdao:UBERON_0018241</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/UBERON_0018241">http://purl.obolibrary.org/obo/UBERON_0018241</seealso>
    let _0018241 = Prefixed_Name(uberon, "0018241") |> PrefixedName
    /// <summary>
    ///   <para>cdao:UBERON_0034919</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/UBERON_0034919">http://purl.obolibrary.org/obo/UBERON_0034919</seealso>
    let _0034919 = Prefixed_Name(uberon, "0034919") |> PrefixedName
    /// <summary>
    ///   <para>cdao:UBERON_0036149</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"suprapubic skin"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/UBERON_0036149">http://purl.obolibrary.org/obo/UBERON_0036149</seealso>
    let suprapubic_skin = Prefixed_Name(uberon, "0036149") |> PrefixedName
    /// <summary>
    ///   <para>cdao:UBERON_8200002</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/UBERON_8200002">http://purl.obolibrary.org/obo/UBERON_8200002</seealso>
    let _8200002 = Prefixed_Name(uberon, "8200002") |> PrefixedName
    /// <summary>
    ///   <para>cdao:UBERON_8200003</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/UBERON_8200003">http://purl.obolibrary.org/obo/UBERON_8200003</seealso>
    let _8200003 = Prefixed_Name(uberon, "8200003") |> PrefixedName
    /// <summary>
    ///   <para>cdao:UBERON_8200004</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/UBERON_8200004">http://purl.obolibrary.org/obo/UBERON_8200004</seealso>
    let _8200004 = Prefixed_Name(uberon, "8200004") |> PrefixedName
    /// <summary>
    ///   <para>cdao:UBERON_8200005</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/UBERON_8200005">http://purl.obolibrary.org/obo/UBERON_8200005</seealso>
    let _8200005 = Prefixed_Name(uberon, "8200005") |> PrefixedName
    /// <summary>
    ///   <para>cdao:UBERON_8200006</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/UBERON_8200006">http://purl.obolibrary.org/obo/UBERON_8200006</seealso>
    let _8200006 = Prefixed_Name(uberon, "8200006") |> PrefixedName
    /// <summary>
    ///   <para>cdao:UBERON_8200007</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/UBERON_8200007">http://purl.obolibrary.org/obo/UBERON_8200007</seealso>
    let _8200007 = Prefixed_Name(uberon, "8200007") |> PrefixedName
