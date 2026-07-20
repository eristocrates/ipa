namespace https.spec.edmcouncil.org.fibo.ontology.BP.Process.MetadataBPProcess.slash

open DoxAletheia

module fibo_bp_prc_mod =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/BP/Process/MetadataBPProcess/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BP/Process/MetadataBPProcess/ProcessModule"></see>
    /// </summary>
    let ProcessModule = _prefix "ProcessModule"
