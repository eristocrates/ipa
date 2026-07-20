namespace http.purl.org.voc.summa.slash

open DoxAletheia

module summa =
    let _namespace_name = "http://purl.org/voc/summa/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/voc/summa/Summary"></see>
    /// </summary>
    let Summary = _prefix "Summary"
    /// <summary>
    ///   <see href="http://purl.org/voc/summa/SummaryGroup"></see>
    /// </summary>
    let SummaryGroup = _prefix "SummaryGroup"
    /// <summary>
    ///   <see href="http://purl.org/voc/summa/entity"></see>
    /// </summary>
    let entity = _prefix "entity"
    /// <summary>
    ///   <see href="http://purl.org/voc/summa/fixedProperty"></see>
    /// </summary>
    let fixedProperty = _prefix "fixedProperty"
    /// <summary>
    ///   <see href="http://purl.org/voc/summa/group"></see>
    /// </summary>
    let group = _prefix "group"
    /// <summary>
    ///   <see href="http://purl.org/voc/summa/language"></see>
    /// </summary>
    let language = _prefix "language"
    /// <summary>
    ///   <see href="http://purl.org/voc/summa/maxHops"></see>
    /// </summary>
    let maxHops = _prefix "maxHops"
    /// <summary>
    ///   <see href="http://purl.org/voc/summa/path"></see>
    /// </summary>
    let path = _prefix "path"
    /// <summary>
    ///   <see href="http://purl.org/voc/summa/statement"></see>
    /// </summary>
    let statement = _prefix "statement"
    /// <summary>
    ///   <see href="http://purl.org/voc/summa/topK"></see>
    /// </summary>
    let topK = _prefix "topK"
