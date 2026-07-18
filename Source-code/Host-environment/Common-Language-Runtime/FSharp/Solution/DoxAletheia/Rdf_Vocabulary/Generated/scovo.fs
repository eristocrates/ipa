namespace http.purl.org.NET.scovo.hash

open DoxAletheia.Rdf_Vocabulary

module scovo =
    let _namespace_name = "http://purl.org/NET/scovo#"
    /// <summary>
    /// a statistical dataset
    /// <see href="http://purl.org/NET/scovo#Dataset"></see></summary>
    let Dataset = Namespaced_IRI.parse _namespace_name "Dataset" |> NamespacedName
    /// <summary>
    /// a dimension of a statistical data item
    /// <see href="http://purl.org/NET/scovo#Dimension"></see></summary>
    let Dimension = Namespaced_IRI.parse _namespace_name "Dimension" |> NamespacedName
    /// <summary>
    /// a statistical data item
    /// <see href="http://purl.org/NET/scovo#Item"></see></summary>
    let Item = Namespaced_IRI.parse _namespace_name "Item" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/NET/scovo#dataset"></see>
    /// </summary>
    let dataset = Namespaced_IRI.parse _namespace_name "dataset" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/NET/scovo#datasetOf"></see>
    /// </summary>
    let datasetOf = Namespaced_IRI.parse _namespace_name "datasetOf" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/NET/scovo#dimension"></see>
    /// </summary>
    let dimension = Namespaced_IRI.parse _namespace_name "dimension" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/NET/scovo#max"></see>
    /// </summary>
    let max = Namespaced_IRI.parse _namespace_name "max" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/NET/scovo#min"></see>
    /// </summary>
    let min = Namespaced_IRI.parse _namespace_name "min" |> NamespacedName
