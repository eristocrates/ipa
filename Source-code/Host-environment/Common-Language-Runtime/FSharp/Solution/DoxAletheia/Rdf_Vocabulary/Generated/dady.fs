namespace http.purl.org.NET.dady.hash

open DoxAletheia

module dady =
    let _namespace_name = "http://purl.org/NET/dady#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/NET/dady#AtomUpdateSource"></see>
    /// </summary>
    let AtomUpdateSource = _prefix "AtomUpdateSource"
    /// <summary>
    ///   <see href="http://purl.org/NET/dady#UpdateSource"></see>
    /// </summary>
    let UpdateSource = _prefix "UpdateSource"
    /// <summary>
    ///   <see href="http://purl.org/NET/dady#ChangeSetUpdateSource"></see>
    /// </summary>
    let ChangeSetUpdateSource = _prefix "ChangeSetUpdateSource"
    /// <summary>
    /// the dataset is updated high-frequently, i.e., once a day or more frequent
    /// <see href="http://purl.org/NET/dady#HighFrequentUpdates"></see></summary>
    let HighFrequentUpdates = _prefix "HighFrequentUpdates"
    /// <summary>
    ///   <see href="http://purl.org/NET/dady#UpdateFrequency"></see>
    /// </summary>
    let UpdateFrequency = _prefix "UpdateFrequency"
    /// <summary>
    /// the dataset is updated in irregular, non-predictable time intervals
    /// <see href="http://purl.org/NET/dady#IrregularUpdates"></see></summary>
    let IrregularUpdates = _prefix "IrregularUpdates"
    /// <summary>
    ///   <see href="http://purl.org/NET/dady#UpdateRegularity"></see>
    /// </summary>
    let UpdateRegularity = _prefix "UpdateRegularity"
    /// <summary>
    /// the dataset is updated low-frequently, i.e., once a year or less frequent
    /// <see href="http://purl.org/NET/dady#LowFrequentUpdates"></see></summary>
    let LowFrequentUpdates = _prefix "LowFrequentUpdates"
    /// <summary>
    /// the dataset is updated mid-frequently, i.e., from once a week to a couple of months
    /// <see href="http://purl.org/NET/dady#MidFrequentUpdates"></see></summary>
    let MidFrequentUpdates = _prefix "MidFrequentUpdates"
    /// <summary>
    /// the dataset is never updated
    /// <see href="http://purl.org/NET/dady#NoUpdates"></see></summary>
    let NoUpdates = _prefix "NoUpdates"
    /// <summary>
    /// the dataset is updated in regular time intervals
    /// <see href="http://purl.org/NET/dady#RegularUpdates"></see></summary>
    let RegularUpdates = _prefix "RegularUpdates"
    /// <summary>
    ///   <see href="http://purl.org/NET/dady#TriplifyUpdateSource"></see>
    /// </summary>
    let TriplifyUpdateSource = _prefix "TriplifyUpdateSource"
    /// <summary>
    ///   <see href="http://purl.org/NET/dady#UpdateDynamics"></see>
    /// </summary>
    let UpdateDynamics = _prefix "UpdateDynamics"
    /// <summary>
    ///   <see href="http://purl.org/NET/dady#dynamics"></see>
    /// </summary>
    let dynamics = _prefix "dynamics"
    /// <summary>
    ///   <see href="http://purl.org/NET/dady#notification"></see>
    /// </summary>
    let notification = _prefix "notification"
    /// <summary>
    ///   <see href="http://purl.org/NET/dady#update"></see>
    /// </summary>
    let update = _prefix "update"
