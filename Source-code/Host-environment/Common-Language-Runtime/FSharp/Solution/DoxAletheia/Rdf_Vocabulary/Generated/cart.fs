namespace http.purl.org.net.cartCoord.hash

open DoxAletheia

module cart =
    let _namespace_name = "http://purl.org/net/cartCoord#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/net/cartCoord#Point"></see>
    /// </summary>
    let Point = _prefix "Point"
    /// <summary>
    ///   <see href="http://purl.org/net/cartCoord#Point_List"></see>
    /// </summary>
    let Point_List = _prefix "Point_List"
    /// <summary>
    ///   <see href="http://purl.org/net/cartCoord#hasPlacement"></see>
    /// </summary>
    let hasPlacement = _prefix "hasPlacement"
    /// <summary>
    ///   <see href="http://purl.org/net/cartCoord#hasPoint"></see>
    /// </summary>
    let hasPoint = _prefix "hasPoint"
    /// <summary>
    ///   <see href="http://purl.org/net/cartCoord#xcoord"></see>
    /// </summary>
    let xcoord = _prefix "xcoord"
    /// <summary>
    ///   <see href="http://purl.org/net/cartCoord#ycoord"></see>
    /// </summary>
    let ycoord = _prefix "ycoord"
    /// <summary>
    ///   <see href="http://purl.org/net/cartCoord#zcoord"></see>
    /// </summary>
    let zcoord = _prefix "zcoord"
