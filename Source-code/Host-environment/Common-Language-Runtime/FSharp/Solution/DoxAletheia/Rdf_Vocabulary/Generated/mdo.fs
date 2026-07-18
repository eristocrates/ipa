namespace https.w3id.org.mdo.full.slash

open DoxAletheia.Rdf_Vocabulary

module mdo =
    let _namespace_name = "https://w3id.org/mdo/full/"
    /// <summary>
    ///   <see href="https://w3id.org/mdo/full/1.0/"></see>
    /// </summary>
    let ``_1.0/`` = Namespaced_IRI.parse _namespace_name "1.0/" |> NamespacedName
