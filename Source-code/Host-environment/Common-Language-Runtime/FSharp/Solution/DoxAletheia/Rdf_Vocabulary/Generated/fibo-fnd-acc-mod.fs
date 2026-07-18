namespace https.spec.edmcouncil.org.fibo.ontology.FND.Accounting.MetadataFNDAccounting.slash

open DoxAletheia.Rdf_Vocabulary

module fibo_fnd_acc_mod =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/FND/Accounting/MetadataFNDAccounting/"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Accounting/MetadataFNDAccounting/AccountingModule"></see>
    /// </summary>
    let AccountingModule =
        Namespaced_IRI.parse _namespace_name "AccountingModule" |> NamespacedName
