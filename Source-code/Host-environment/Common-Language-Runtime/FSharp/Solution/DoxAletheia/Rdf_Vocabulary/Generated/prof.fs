namespace http.www.w3.org.ns.dx.prof.slash

open DoxAletheia.Rdf_Vocabulary

module prof =
    let _namespace_name = "http://www.w3.org/ns/dx/prof/"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/dx/prof/1.0"></see>
    /// </summary>
    let ``_1.0`` = Namespaced_IRI.parse _namespace_name "1.0" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/ns/dx/prof/Profile"></see>
    /// </summary>
    let Profile = Namespaced_IRI.parse _namespace_name "Profile" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/dx/prof/ResourceDescriptor"></see>
    /// </summary>
    let ResourceDescriptor =
        Namespaced_IRI.parse _namespace_name "ResourceDescriptor" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/dx/prof/ResourceRole"></see>
    /// </summary>
    let ResourceRole =
        Namespaced_IRI.parse _namespace_name "ResourceRole" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/dx/prof/hasArtifact"></see>
    /// </summary>
    let hasArtifact =
        Namespaced_IRI.parse _namespace_name "hasArtifact" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/dx/prof/hasResource"></see>
    /// </summary>
    let hasResource =
        Namespaced_IRI.parse _namespace_name "hasResource" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/dx/prof/hasRole"></see>
    /// </summary>
    let hasRole = Namespaced_IRI.parse _namespace_name "hasRole" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/ns/dx/prof/hasToken"></see>
    /// </summary>
    let hasToken = Namespaced_IRI.parse _namespace_name "hasToken" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/dx/prof/isInheritedFrom"></see>
    /// </summary>
    let isInheritedFrom =
        Namespaced_IRI.parse _namespace_name "isInheritedFrom" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/dx/prof/isProfileOf"></see>
    /// </summary>
    let isProfileOf =
        Namespaced_IRI.parse _namespace_name "isProfileOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/dx/prof/isTransitiveProfileOf"></see>
    /// </summary>
    let isTransitiveProfileOf =
        Namespaced_IRI.parse _namespace_name "isTransitiveProfileOf" |> NamespacedName
