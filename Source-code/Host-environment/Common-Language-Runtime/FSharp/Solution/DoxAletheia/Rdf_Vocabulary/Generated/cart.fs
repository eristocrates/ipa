namespace http.purl.org.net.cartCoord.hash

open DoxAletheia.Rdf_Vocabulary

module cart =
    let _namespace_name = "http://purl.org/net/cartCoord#"
    /// <summary>
    ///   <see href="http://purl.org/net/cartCoord#Point"></see>
    /// </summary>
    let Point = Namespaced_IRI.parse _namespace_name "Point" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/net/cartCoord#Point_List"></see>
    /// </summary>
    let Point_List = Namespaced_IRI.parse _namespace_name "Point_List" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/net/cartCoord#hasPlacement"></see>
    /// </summary>
    let hasPlacement =
        Namespaced_IRI.parse _namespace_name "hasPlacement" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/net/cartCoord#hasPoint"></see>
    /// </summary>
    let hasPoint = Namespaced_IRI.parse _namespace_name "hasPoint" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/net/cartCoord#xcoord"></see>
    /// </summary>
    let xcoord = Namespaced_IRI.parse _namespace_name "xcoord" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/net/cartCoord#ycoord"></see>
    /// </summary>
    let ycoord = Namespaced_IRI.parse _namespace_name "ycoord" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/net/cartCoord#zcoord"></see>
    /// </summary>
    let zcoord = Namespaced_IRI.parse _namespace_name "zcoord" |> NamespacedName
