namespace https.spec.edmcouncil.org.fibo.ontology.FND.Accounting.MetadataFNDAccounting.slash

open DoxAletheia

module fibo_fnd_acc_mod =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/FND/Accounting/MetadataFNDAccounting/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Accounting/MetadataFNDAccounting/AccountingModule"></see>
    /// </summary>
    let AccountingModule = _prefix "AccountingModule"
