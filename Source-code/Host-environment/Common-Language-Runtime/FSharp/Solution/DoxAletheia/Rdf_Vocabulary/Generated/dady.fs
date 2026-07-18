namespace http.purl.org.NET.dady.hash

open DoxAletheia.Rdf_Vocabulary

module dady =
    let _namespace_name = "http://purl.org/NET/dady#"

    /// <summary>
    ///   <see href="http://purl.org/NET/dady#AtomUpdateSource"></see>
    /// </summary>
    let AtomUpdateSource =
        Namespaced_IRI.parse _namespace_name "AtomUpdateSource" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/NET/dady#UpdateSource"></see>
    /// </summary>
    let UpdateSource =
        Namespaced_IRI.parse _namespace_name "UpdateSource" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/NET/dady#ChangeSetUpdateSource"></see>
    /// </summary>
    let ChangeSetUpdateSource =
        Namespaced_IRI.parse _namespace_name "ChangeSetUpdateSource" |> NamespacedName

    /// <summary>
    /// the dataset is updated high-frequently, i.e., once a day or more frequent
    /// <see href="http://purl.org/NET/dady#HighFrequentUpdates"></see></summary>
    let HighFrequentUpdates =
        Namespaced_IRI.parse _namespace_name "HighFrequentUpdates" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/NET/dady#UpdateFrequency"></see>
    /// </summary>
    let UpdateFrequency =
        Namespaced_IRI.parse _namespace_name "UpdateFrequency" |> NamespacedName

    /// <summary>
    /// the dataset is updated in irregular, non-predictable time intervals
    /// <see href="http://purl.org/NET/dady#IrregularUpdates"></see></summary>
    let IrregularUpdates =
        Namespaced_IRI.parse _namespace_name "IrregularUpdates" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/NET/dady#UpdateRegularity"></see>
    /// </summary>
    let UpdateRegularity =
        Namespaced_IRI.parse _namespace_name "UpdateRegularity" |> NamespacedName

    /// <summary>
    /// the dataset is updated low-frequently, i.e., once a year or less frequent
    /// <see href="http://purl.org/NET/dady#LowFrequentUpdates"></see></summary>
    let LowFrequentUpdates =
        Namespaced_IRI.parse _namespace_name "LowFrequentUpdates" |> NamespacedName

    /// <summary>
    /// the dataset is updated mid-frequently, i.e., from once a week to a couple of months
    /// <see href="http://purl.org/NET/dady#MidFrequentUpdates"></see></summary>
    let MidFrequentUpdates =
        Namespaced_IRI.parse _namespace_name "MidFrequentUpdates" |> NamespacedName

    /// <summary>
    /// the dataset is never updated
    /// <see href="http://purl.org/NET/dady#NoUpdates"></see></summary>
    let NoUpdates = Namespaced_IRI.parse _namespace_name "NoUpdates" |> NamespacedName

    /// <summary>
    /// the dataset is updated in regular time intervals
    /// <see href="http://purl.org/NET/dady#RegularUpdates"></see></summary>
    let RegularUpdates =
        Namespaced_IRI.parse _namespace_name "RegularUpdates" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/NET/dady#TriplifyUpdateSource"></see>
    /// </summary>
    let TriplifyUpdateSource =
        Namespaced_IRI.parse _namespace_name "TriplifyUpdateSource" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/NET/dady#UpdateDynamics"></see>
    /// </summary>
    let UpdateDynamics =
        Namespaced_IRI.parse _namespace_name "UpdateDynamics" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/NET/dady#dynamics"></see>
    /// </summary>
    let dynamics = Namespaced_IRI.parse _namespace_name "dynamics" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/NET/dady#notification"></see>
    /// </summary>
    let notification =
        Namespaced_IRI.parse _namespace_name "notification" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/NET/dady#update"></see>
    /// </summary>
    let update = Namespaced_IRI.parse _namespace_name "update" |> NamespacedName
