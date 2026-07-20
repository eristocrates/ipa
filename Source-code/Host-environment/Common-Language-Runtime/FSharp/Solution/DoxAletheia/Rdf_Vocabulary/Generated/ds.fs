namespace http.purl.org.ctic.dcat.hash

open DoxAletheia

module ds =
    let _namespace_name = "http://purl.org/ctic/dcat#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// Catalog which have defined datasets in
    /// <see href="http://purl.org/ctic/dcat#Catalog"></see></summary>
    let Catalog = _prefix "Catalog"
    /// <summary>
    /// A dataset
    /// <see href="http://purl.org/ctic/dcat#Dataset"></see></summary>
    let Dataset = _prefix "Dataset"
    /// <summary>
    ///   <see href="http://purl.org/ctic/dcat#accessMode-direct"></see>
    /// </summary>
    let ``accessMode-direct`` = _prefix "accessMode-direct"
    /// <summary>
    /// Concept scheme of the different access modes to the information distributions
    /// <see href="http://purl.org/ctic/dcat#accessModeScheme"></see></summary>
    let accessModeScheme = _prefix "accessModeScheme"
    /// <summary>
    ///   <see href="http://purl.org/ctic/dcat#accessMode-indirect"></see>
    /// </summary>
    let ``accessMode-indirect`` = _prefix "accessMode-indirect"
    /// <summary>
    /// Property which defines a Dataset member of the Catalog
    /// <see href="http://purl.org/ctic/dcat#member"></see></summary>
    let member_ = _prefix "member"
    /// <summary>
    /// Property which defines a Catalog that contains the Dataset
    /// <see href="http://purl.org/ctic/dcat#memberOf"></see></summary>
    let memberOf = _prefix "memberOf"
    /// <summary>
    /// Property which defines the status of the Dataset according to a defined taxonomy
    /// <see href="http://purl.org/ctic/dcat#status"></see></summary>
    let status = _prefix "status"
    /// <summary>
    ///   <see href="http://purl.org/ctic/dcat#status-announced"></see>
    /// </summary>
    let ``status-announced`` = _prefix "status-announced"
    /// <summary>
    /// Concept scheme of the different statuses for a catalog
    /// <see href="http://purl.org/ctic/dcat#statusScheme"></see></summary>
    let statusScheme = _prefix "statusScheme"
    /// <summary>
    ///   <see href="http://purl.org/ctic/dcat#status-data"></see>
    /// </summary>
    let ``status-data`` = _prefix "status-data"
    /// <summary>
    ///   <see href="http://purl.org/ctic/dcat#status-extinct"></see>
    /// </summary>
    let ``status-extinct`` = _prefix "status-extinct"
    /// <summary>
    ///   <see href="http://purl.org/ctic/dcat#status-ldFormat"></see>
    /// </summary>
    let ``status-ldFormat`` = _prefix "status-ldFormat"
    /// <summary>
    ///   <see href="http://purl.org/ctic/dcat#status-linkedData"></see>
    /// </summary>
    let ``status-linkedData`` = _prefix "status-linkedData"
    /// <summary>
    ///   <see href="http://purl.org/ctic/dcat#status-nonProprietaryFormat"></see>
    /// </summary>
    let ``status-nonProprietaryFormat`` = _prefix "status-nonProprietaryFormat"
    /// <summary>
    ///   <see href="http://purl.org/ctic/dcat#status-structuredData"></see>
    /// </summary>
    let ``status-structuredData`` = _prefix "status-structuredData"
