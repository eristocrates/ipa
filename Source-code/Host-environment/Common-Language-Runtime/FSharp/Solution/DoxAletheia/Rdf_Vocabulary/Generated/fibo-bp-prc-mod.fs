namespace https.spec.edmcouncil.org.fibo.ontology.BP.Process.MetadataBPProcess.slash

open DoxAletheia.Rdf_Vocabulary

module fibo_bp_prc_mod =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/BP/Process/MetadataBPProcess/"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BP/Process/MetadataBPProcess/ProcessModule"></see>
    /// </summary>
    let ProcessModule =
        Namespaced_IRI.parse _namespace_name "ProcessModule" |> NamespacedName
