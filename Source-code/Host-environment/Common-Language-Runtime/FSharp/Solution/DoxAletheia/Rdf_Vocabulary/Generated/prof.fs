namespace http.www.w3.org.ns.dx.prof.slash

open DoxAletheia

module prof =
    let _namespace_name = "http://www.w3.org/ns/dx/prof/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/dx/prof/1.0"></see>
    /// </summary>
    let ``_1.0`` = _prefix "1.0"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/dx/prof/Profile"></see>
    /// </summary>
    let Profile = _prefix "Profile"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/dx/prof/ResourceDescriptor"></see>
    /// </summary>
    let ResourceDescriptor = _prefix "ResourceDescriptor"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/dx/prof/ResourceRole"></see>
    /// </summary>
    let ResourceRole = _prefix "ResourceRole"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/dx/prof/hasArtifact"></see>
    /// </summary>
    let hasArtifact = _prefix "hasArtifact"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/dx/prof/hasResource"></see>
    /// </summary>
    let hasResource = _prefix "hasResource"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/dx/prof/hasRole"></see>
    /// </summary>
    let hasRole = _prefix "hasRole"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/dx/prof/hasToken"></see>
    /// </summary>
    let hasToken = _prefix "hasToken"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/dx/prof/isInheritedFrom"></see>
    /// </summary>
    let isInheritedFrom = _prefix "isInheritedFrom"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/dx/prof/isProfileOf"></see>
    /// </summary>
    let isProfileOf = _prefix "isProfileOf"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/dx/prof/isTransitiveProfileOf"></see>
    /// </summary>
    let isTransitiveProfileOf = _prefix "isTransitiveProfileOf"
