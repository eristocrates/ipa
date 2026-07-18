namespace http.eulersharp.sourceforge.net._2003._03swap.physicalResource.hash

open DoxAletheia.Rdf_Vocabulary

module swap_physicalResource =
    let _namespace_name =
        "http://eulersharp.sourceforge.net/2003/03swap/physicalResource#"

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/physicalResource#Compound"></see>
    /// </summary>
    let Compound = Namespaced_IRI.parse _namespace_name "Compound" |> NamespacedName
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/physicalResource#Resource"></see>
    /// </summary>
    let Resource = Namespaced_IRI.parse _namespace_name "Resource" |> NamespacedName
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/physicalResource#Device"></see>
    /// </summary>
    let Device = Namespaced_IRI.parse _namespace_name "Device" |> NamespacedName
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/physicalResource#Product"></see>
    /// </summary>
    let Product = Namespaced_IRI.parse _namespace_name "Product" |> NamespacedName
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/physicalResource#Specimen"></see>
    /// </summary>
    let Specimen = Namespaced_IRI.parse _namespace_name "Specimen" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/physicalResource#complexityOf"></see>
    /// </summary>
    let complexityOf =
        Namespaced_IRI.parse _namespace_name "complexityOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/physicalResource#hasComplexity"></see>
    /// </summary>
    let hasComplexity =
        Namespaced_IRI.parse _namespace_name "hasComplexity" |> NamespacedName
