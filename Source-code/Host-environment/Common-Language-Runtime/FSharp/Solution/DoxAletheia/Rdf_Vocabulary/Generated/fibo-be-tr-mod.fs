namespace https.spec.edmcouncil.org.fibo.ontology.BE.Trusts.MetadataBETrusts.slash

open DoxAletheia.Rdf_Vocabulary

module fibo_be_tr_mod =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/BE/Trusts/MetadataBETrusts/"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/Trusts/MetadataBETrusts/TrustsModule"></see>
    /// </summary>
    let TrustsModule =
        Namespaced_IRI.parse _namespace_name "TrustsModule" |> NamespacedName
