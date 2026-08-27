namespace http.www.w3.org.ns.dx.prof.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module prof =
    let _namespace_iri = Namespace_Iri prof |> NamespaceIRI
    /// <summary>
    ///   <para>prof:1.0</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/ns/dx/prof/1.0">http://www.w3.org/ns/dx/prof/1.0</seealso>
    let ``_1.0`` = Prefixed_Name(prof, "1.0") |> PrefixedName
    /// <summary>
    ///   <para>prof:Profile</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Profile"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/ns/dx/prof/Profile">http://www.w3.org/ns/dx/prof/Profile</seealso>
    let Profile = Prefixed_Name(prof, "Profile") |> PrefixedName
    /// <summary>
    ///   <para>prof:ResourceDescriptor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Resource Descriptor"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/dx/prof/ResourceDescriptor">http://www.w3.org/ns/dx/prof/ResourceDescriptor</seealso>
    let ResourceDescriptor = Prefixed_Name(prof, "ResourceDescriptor") |> PrefixedName
    /// <summary>
    ///   <para>prof:ResourceRole</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Resource Role"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/ns/dx/prof/ResourceRole">http://www.w3.org/ns/dx/prof/ResourceRole</seealso>
    let ResourceRole = Prefixed_Name(prof, "ResourceRole") |> PrefixedName
    /// <summary>
    ///   <para>prof:hasArtifact</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has artifact"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/ns/dx/prof/hasArtifact">http://www.w3.org/ns/dx/prof/hasArtifact</seealso>
    let hasArtifact = Prefixed_Name(prof, "hasArtifact") |> PrefixedName
    /// <summary>
    ///   <para>prof:hasResource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has resource"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/dx/prof/hasResource">http://www.w3.org/ns/dx/prof/hasResource</seealso>
    let hasResource = Prefixed_Name(prof, "hasResource") |> PrefixedName
    /// <summary>
    ///   <para>prof:hasRole</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has role"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/ns/dx/prof/hasRole">http://www.w3.org/ns/dx/prof/hasRole</seealso>
    let hasRole = Prefixed_Name(prof, "hasRole") |> PrefixedName
    /// <summary>
    ///   <para>prof:hasToken</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"has token"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/ns/dx/prof/hasToken">http://www.w3.org/ns/dx/prof/hasToken</seealso>
    let hasToken = Prefixed_Name(prof, "hasToken") |> PrefixedName
    /// <summary>
    ///   <para>prof:isInheritedFrom</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is inherited from"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/ns/dx/prof/isInheritedFrom">http://www.w3.org/ns/dx/prof/isInheritedFrom</seealso>
    let isInheritedFrom = Prefixed_Name(prof, "isInheritedFrom") |> PrefixedName
    /// <summary>
    ///   <para>prof:isProfileOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is profile of"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/ns/dx/prof/isProfileOf">http://www.w3.org/ns/dx/prof/isProfileOf</seealso>
    let isProfileOf = Prefixed_Name(prof, "isProfileOf") |> PrefixedName

    /// <summary>
    ///   <para>prof:isTransitiveProfileOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is transitive profile of"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/ns/dx/prof/isTransitiveProfileOf">http://www.w3.org/ns/dx/prof/isTransitiveProfileOf</seealso>
    let isTransitiveProfileOf =
        Prefixed_Name(prof, "isTransitiveProfileOf") |> PrefixedName

    /// <summary>
    ///   <para>prof:role/guidance</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/ns/dx/prof/role/guidance">http://www.w3.org/ns/dx/prof/role/guidance</seealso>
    let ``role/guidance`` = Prefixed_Name(prof, "role/guidance") |> PrefixedName

    /// <summary>
    ///   <para>prof:role/specification</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/ns/dx/prof/role/specification">http://www.w3.org/ns/dx/prof/role/specification</seealso>
    let ``role/specification`` =
        Prefixed_Name(prof, "role/specification") |> PrefixedName

    /// <summary>
    ///   <para>prof:role/vocabulary</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/ns/dx/prof/role/vocabulary">http://www.w3.org/ns/dx/prof/role/vocabulary</seealso>
    let ``role/vocabulary`` = Prefixed_Name(prof, "role/vocabulary") |> PrefixedName
