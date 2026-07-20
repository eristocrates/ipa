namespace https.w3id.org.mdo.full.slash

open DoxAletheia

module mdo =
    let _namespace_name = "https://w3id.org/mdo/full/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/mdo/full/1.0/"></see>
    /// </summary>
    let ``_1.0/`` = _prefix "1.0/"
