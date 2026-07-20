namespace http.purl.org.NET.scovo.hash

open DoxAletheia

module scovo =
    let _namespace_name = "http://purl.org/NET/scovo#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// a statistical dataset
    /// <see href="http://purl.org/NET/scovo#Dataset"></see></summary>
    let Dataset = _prefix "Dataset"
    /// <summary>
    /// a dimension of a statistical data item
    /// <see href="http://purl.org/NET/scovo#Dimension"></see></summary>
    let Dimension = _prefix "Dimension"
    /// <summary>
    /// a statistical data item
    /// <see href="http://purl.org/NET/scovo#Item"></see></summary>
    let Item = _prefix "Item"
    /// <summary>
    ///   <see href="http://purl.org/NET/scovo#dataset"></see>
    /// </summary>
    let dataset = _prefix "dataset"
    /// <summary>
    ///   <see href="http://purl.org/NET/scovo#datasetOf"></see>
    /// </summary>
    let datasetOf = _prefix "datasetOf"
    /// <summary>
    ///   <see href="http://purl.org/NET/scovo#dimension"></see>
    /// </summary>
    let dimension = _prefix "dimension"
    /// <summary>
    ///   <see href="http://purl.org/NET/scovo#max"></see>
    /// </summary>
    let max = _prefix "max"
    /// <summary>
    ///   <see href="http://purl.org/NET/scovo#min"></see>
    /// </summary>
    let min = _prefix "min"
