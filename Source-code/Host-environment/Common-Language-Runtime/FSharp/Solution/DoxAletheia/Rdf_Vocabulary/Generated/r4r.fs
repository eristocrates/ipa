namespace http.guava.iis.sinica.edu.tw.r4r.slash

open DoxAletheia.Rdf_Vocabulary

module r4r =
    let _namespace_name = "http://guava.iis.sinica.edu.tw/r4r/"
    /// <summary>
    ///   <see href="http://guava.iis.sinica.edu.tw/r4r/Article"></see>
    /// </summary>
    let Article = Namespaced_IRI.parse _namespace_name "Article" |> NamespacedName
    /// <summary>
    ///   <see href="http://guava.iis.sinica.edu.tw/r4r/Definition"></see>
    /// </summary>
    let Definition = Namespaced_IRI.parse _namespace_name "Definition" |> NamespacedName
    /// <summary>
    ///   <see href="http://guava.iis.sinica.edu.tw/r4r/RRObject"></see>
    /// </summary>
    let RRObject = Namespaced_IRI.parse _namespace_name "RRObject" |> NamespacedName
    /// <summary>
    ///   <see href="http://guava.iis.sinica.edu.tw/r4r/Code"></see>
    /// </summary>
    let Code = Namespaced_IRI.parse _namespace_name "Code" |> NamespacedName
    /// <summary>
    ///   <see href="http://guava.iis.sinica.edu.tw/r4r/Data"></see>
    /// </summary>
    let Data = Namespaced_IRI.parse _namespace_name "Data" |> NamespacedName
    /// <summary>
    ///   <see href="http://guava.iis.sinica.edu.tw/r4r/License"></see>
    /// </summary>
    let License = Namespaced_IRI.parse _namespace_name "License" |> NamespacedName
    /// <summary>
    ///   <see href="http://guava.iis.sinica.edu.tw/r4r/RRPolicy"></see>
    /// </summary>
    let RRPolicy = Namespaced_IRI.parse _namespace_name "RRPolicy" |> NamespacedName
    /// <summary>
    ///   <see href="http://guava.iis.sinica.edu.tw/r4r/Provenance"></see>
    /// </summary>
    let Provenance = Namespaced_IRI.parse _namespace_name "Provenance" |> NamespacedName
    /// <summary>
    ///   <see href="http://guava.iis.sinica.edu.tw/r4r/hasTime"></see>
    /// </summary>
    let hasTime = Namespaced_IRI.parse _namespace_name "hasTime" |> NamespacedName
    /// <summary>
    ///   <see href="http://guava.iis.sinica.edu.tw/r4r/locateAt"></see>
    /// </summary>
    let locateAt = Namespaced_IRI.parse _namespace_name "locateAt" |> NamespacedName

    /// <summary>
    ///   <see href="http://guava.iis.sinica.edu.tw/r4r/isPackagedWith"></see>
    /// </summary>
    let isPackagedWith =
        Namespaced_IRI.parse _namespace_name "isPackagedWith" |> NamespacedName

    /// <summary>
    ///   <see href="http://guava.iis.sinica.edu.tw/r4r/cites"></see>
    /// </summary>
    let cites = Namespaced_IRI.parse _namespace_name "cites" |> NamespacedName
    /// <summary>
    ///   <see href="http://guava.iis.sinica.edu.tw/r4r/isCitedBy"></see>
    /// </summary>
    let isCitedBy = Namespaced_IRI.parse _namespace_name "isCitedBy" |> NamespacedName
    /// <summary>
    ///   <see href="http://guava.iis.sinica.edu.tw/r4r/hasLicense"></see>
    /// </summary>
    let hasLicense = Namespaced_IRI.parse _namespace_name "hasLicense" |> NamespacedName

    /// <summary>
    ///   <see href="http://guava.iis.sinica.edu.tw/r4r/hasProvenance"></see>
    /// </summary>
    let hasProvenance =
        Namespaced_IRI.parse _namespace_name "hasProvenance" |> NamespacedName

    /// <summary>
    ///   <see href="http://guava.iis.sinica.edu.tw/r4r/isPartOf"></see>
    /// </summary>
    let isPartOf = Namespaced_IRI.parse _namespace_name "isPartOf" |> NamespacedName
