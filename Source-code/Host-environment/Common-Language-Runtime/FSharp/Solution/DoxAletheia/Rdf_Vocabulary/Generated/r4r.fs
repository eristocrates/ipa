namespace http.guava.iis.sinica.edu.tw.r4r.slash

open DoxAletheia

module r4r =
    let _namespace_name = "http://guava.iis.sinica.edu.tw/r4r/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="http://guava.iis.sinica.edu.tw/r4r/Article"></see>
    /// </summary>
    let Article = _prefix "Article"
    /// <summary>
    ///   <see href="http://guava.iis.sinica.edu.tw/r4r/Definition"></see>
    /// </summary>
    let Definition = _prefix "Definition"
    /// <summary>
    ///   <see href="http://guava.iis.sinica.edu.tw/r4r/RRObject"></see>
    /// </summary>
    let RRObject = _prefix "RRObject"
    /// <summary>
    ///   <see href="http://guava.iis.sinica.edu.tw/r4r/Code"></see>
    /// </summary>
    let Code = _prefix "Code"
    /// <summary>
    ///   <see href="http://guava.iis.sinica.edu.tw/r4r/Data"></see>
    /// </summary>
    let Data = _prefix "Data"
    /// <summary>
    ///   <see href="http://guava.iis.sinica.edu.tw/r4r/License"></see>
    /// </summary>
    let License = _prefix "License"
    /// <summary>
    ///   <see href="http://guava.iis.sinica.edu.tw/r4r/RRPolicy"></see>
    /// </summary>
    let RRPolicy = _prefix "RRPolicy"
    /// <summary>
    ///   <see href="http://guava.iis.sinica.edu.tw/r4r/Provenance"></see>
    /// </summary>
    let Provenance = _prefix "Provenance"
    /// <summary>
    ///   <see href="http://guava.iis.sinica.edu.tw/r4r/hasTime"></see>
    /// </summary>
    let hasTime = _prefix "hasTime"
    /// <summary>
    ///   <see href="http://guava.iis.sinica.edu.tw/r4r/locateAt"></see>
    /// </summary>
    let locateAt = _prefix "locateAt"
    /// <summary>
    ///   <see href="http://guava.iis.sinica.edu.tw/r4r/isPackagedWith"></see>
    /// </summary>
    let isPackagedWith = _prefix "isPackagedWith"
    /// <summary>
    ///   <see href="http://guava.iis.sinica.edu.tw/r4r/cites"></see>
    /// </summary>
    let cites = _prefix "cites"
    /// <summary>
    ///   <see href="http://guava.iis.sinica.edu.tw/r4r/isCitedBy"></see>
    /// </summary>
    let isCitedBy = _prefix "isCitedBy"
    /// <summary>
    ///   <see href="http://guava.iis.sinica.edu.tw/r4r/hasLicense"></see>
    /// </summary>
    let hasLicense = _prefix "hasLicense"
    /// <summary>
    ///   <see href="http://guava.iis.sinica.edu.tw/r4r/hasProvenance"></see>
    /// </summary>
    let hasProvenance = _prefix "hasProvenance"
    /// <summary>
    ///   <see href="http://guava.iis.sinica.edu.tw/r4r/isPartOf"></see>
    /// </summary>
    let isPartOf = _prefix "isPartOf"
