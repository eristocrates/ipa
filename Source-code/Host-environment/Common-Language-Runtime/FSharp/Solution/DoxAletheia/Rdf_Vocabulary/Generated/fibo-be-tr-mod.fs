namespace https.spec.edmcouncil.org.fibo.ontology.BE.Trusts.MetadataBETrusts.slash

open DoxAletheia

module fibo_be_tr_mod =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/BE/Trusts/MetadataBETrusts/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/Trusts/MetadataBETrusts/TrustsModule"></see>
    /// </summary>
    let TrustsModule = _prefix "TrustsModule"
