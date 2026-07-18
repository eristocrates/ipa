namespace http.purl.org.voc.summa.slash

open DoxAletheia.Rdf_Vocabulary

module summa =
    let _namespace_name = "http://purl.org/voc/summa/"
    /// <summary>
    ///   <see href="http://purl.org/voc/summa/Summary"></see>
    /// </summary>
    let Summary = Namespaced_IRI.parse _namespace_name "Summary" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/voc/summa/SummaryGroup"></see>
    /// </summary>
    let SummaryGroup =
        Namespaced_IRI.parse _namespace_name "SummaryGroup" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/voc/summa/entity"></see>
    /// </summary>
    let entity = Namespaced_IRI.parse _namespace_name "entity" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/voc/summa/fixedProperty"></see>
    /// </summary>
    let fixedProperty =
        Namespaced_IRI.parse _namespace_name "fixedProperty" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/voc/summa/group"></see>
    /// </summary>
    let group = Namespaced_IRI.parse _namespace_name "group" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/voc/summa/language"></see>
    /// </summary>
    let language = Namespaced_IRI.parse _namespace_name "language" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/voc/summa/maxHops"></see>
    /// </summary>
    let maxHops = Namespaced_IRI.parse _namespace_name "maxHops" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/voc/summa/path"></see>
    /// </summary>
    let path = Namespaced_IRI.parse _namespace_name "path" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/voc/summa/statement"></see>
    /// </summary>
    let statement = Namespaced_IRI.parse _namespace_name "statement" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/voc/summa/topK"></see>
    /// </summary>
    let topK = Namespaced_IRI.parse _namespace_name "topK" |> NamespacedName
