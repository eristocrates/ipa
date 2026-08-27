namespace http.identifiers.org.idot.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module idot =
    let _namespace_iri = Namespace_Iri idot |> NamespaceIRI
    /// <summary>
    ///   <para>id:idot/alternatePrefix</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"alternate prefix"</para></remarks>
    /// <seealso href="http://identifiers.org/idot/alternatePrefix">http://identifiers.org/idot/alternatePrefix</seealso>
    let alternatePrefix = Prefixed_Name(idot, "alternatePrefix") |> PrefixedName
    /// <summary>
    ///   <para>id:idot/exampleIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"example identifier"</para></remarks>
    /// <seealso href="http://identifiers.org/idot/exampleIdentifier">http://identifiers.org/idot/exampleIdentifier</seealso>
    let exampleIdentifier = Prefixed_Name(idot, "exampleIdentifier") |> PrefixedName
    /// <summary>
    ///   <para>id:idot/identifierPattern</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"identifier pattern"</para></remarks>
    /// <seealso href="http://identifiers.org/idot/identifierPattern">http://identifiers.org/idot/identifierPattern</seealso>
    let identifierPattern = Prefixed_Name(idot, "identifierPattern") |> PrefixedName
    /// <summary>
    ///   <para>id:idot/obsolete</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"obsolete"</para></remarks>
    /// <seealso href="http://identifiers.org/idot/obsolete">http://identifiers.org/idot/obsolete</seealso>
    let obsolete = Prefixed_Name(idot, "obsolete") |> PrefixedName
    /// <summary>
    ///   <para>id:idot/preferredPrefix</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"preferred prefix"</para></remarks>
    /// <seealso href="http://identifiers.org/idot/preferredPrefix">http://identifiers.org/idot/preferredPrefix</seealso>
    let preferredPrefix = Prefixed_Name(idot, "preferredPrefix") |> PrefixedName
    /// <summary>
    ///   <para>id:idot/state</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"state"</para></remarks>
    /// <seealso href="http://identifiers.org/idot/state">http://identifiers.org/idot/state</seealso>
    let state = Prefixed_Name(idot, "state") |> PrefixedName
