namespace http.purl.org.ctic.dcat.hash

open DoxAletheia.Rdf_Vocabulary

module ds =
    let _namespace_name = "http://purl.org/ctic/dcat#"
    /// <summary>
    /// Catalog which have defined datasets in
    /// <see href="http://purl.org/ctic/dcat#Catalog"></see></summary>
    let Catalog = Namespaced_IRI.parse _namespace_name "Catalog" |> NamespacedName
    /// <summary>
    /// A dataset
    /// <see href="http://purl.org/ctic/dcat#Dataset"></see></summary>
    let Dataset = Namespaced_IRI.parse _namespace_name "Dataset" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/ctic/dcat#accessMode-direct"></see>
    /// </summary>
    let ``accessMode-direct`` =
        Namespaced_IRI.parse _namespace_name "accessMode-direct" |> NamespacedName

    /// <summary>
    /// Concept scheme of the different access modes to the information distributions
    /// <see href="http://purl.org/ctic/dcat#accessModeScheme"></see></summary>
    let accessModeScheme =
        Namespaced_IRI.parse _namespace_name "accessModeScheme" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/ctic/dcat#accessMode-indirect"></see>
    /// </summary>
    let ``accessMode-indirect`` =
        Namespaced_IRI.parse _namespace_name "accessMode-indirect" |> NamespacedName

    /// <summary>
    /// Property which defines a Dataset member of the Catalog
    /// <see href="http://purl.org/ctic/dcat#member"></see></summary>
    let member_ = Namespaced_IRI.parse _namespace_name "member" |> NamespacedName
    /// <summary>
    /// Property which defines a Catalog that contains the Dataset
    /// <see href="http://purl.org/ctic/dcat#memberOf"></see></summary>
    let memberOf = Namespaced_IRI.parse _namespace_name "memberOf" |> NamespacedName
    /// <summary>
    /// Property which defines the status of the Dataset according to a defined taxonomy
    /// <see href="http://purl.org/ctic/dcat#status"></see></summary>
    let status = Namespaced_IRI.parse _namespace_name "status" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/ctic/dcat#status-announced"></see>
    /// </summary>
    let ``status-announced`` =
        Namespaced_IRI.parse _namespace_name "status-announced" |> NamespacedName

    /// <summary>
    /// Concept scheme of the different statuses for a catalog
    /// <see href="http://purl.org/ctic/dcat#statusScheme"></see></summary>
    let statusScheme =
        Namespaced_IRI.parse _namespace_name "statusScheme" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/ctic/dcat#status-data"></see>
    /// </summary>
    let ``status-data`` =
        Namespaced_IRI.parse _namespace_name "status-data" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/ctic/dcat#status-extinct"></see>
    /// </summary>
    let ``status-extinct`` =
        Namespaced_IRI.parse _namespace_name "status-extinct" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/ctic/dcat#status-ldFormat"></see>
    /// </summary>
    let ``status-ldFormat`` =
        Namespaced_IRI.parse _namespace_name "status-ldFormat" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/ctic/dcat#status-linkedData"></see>
    /// </summary>
    let ``status-linkedData`` =
        Namespaced_IRI.parse _namespace_name "status-linkedData" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/ctic/dcat#status-nonProprietaryFormat"></see>
    /// </summary>
    let ``status-nonProprietaryFormat`` =
        Namespaced_IRI.parse _namespace_name "status-nonProprietaryFormat" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/ctic/dcat#status-structuredData"></see>
    /// </summary>
    let ``status-structuredData`` =
        Namespaced_IRI.parse _namespace_name "status-structuredData" |> NamespacedName
