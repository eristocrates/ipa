namespace http.eulersharp.sourceforge.net._2003._03swap.physicalResource.hash

open DoxAletheia

module swap_physicalResource =
    let _namespace_name =
        "http://eulersharp.sourceforge.net/2003/03swap/physicalResource#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/physicalResource#Compound"></see>
    /// </summary>
    let Compound = _prefix "Compound"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/physicalResource#Resource"></see>
    /// </summary>
    let Resource = _prefix "Resource"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/physicalResource#Device"></see>
    /// </summary>
    let Device = _prefix "Device"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/physicalResource#Product"></see>
    /// </summary>
    let Product = _prefix "Product"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/physicalResource#Specimen"></see>
    /// </summary>
    let Specimen = _prefix "Specimen"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/physicalResource#complexityOf"></see>
    /// </summary>
    let complexityOf = _prefix "complexityOf"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/physicalResource#hasComplexity"></see>
    /// </summary>
    let hasComplexity = _prefix "hasComplexity"
