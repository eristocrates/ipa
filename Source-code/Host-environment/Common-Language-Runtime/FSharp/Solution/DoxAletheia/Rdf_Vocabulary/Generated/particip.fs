namespace http.purl.org.vocab.participation.schema.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module particip =
    let _namespace_iri = Namespace_Iri particip |> NamespaceIRI
    /// <summary>
    ///   <para>particip:</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.org/vocab/participation/schema#">http://purl.org/vocab/participation/schema#</seealso>
    let _prefix_iri = Prefixed_Name(particip, "") |> PrefixedName
    /// <summary>
    ///   <para>particip:Role</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The occupation of a Position by an Agent for a particular Project."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Role"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/vocab/participation/schema#Role">http://purl.org/vocab/participation/schema#Role</seealso>
    let Role = Prefixed_Name(particip, "Role") |> PrefixedName
    /// <summary>
    ///   <para>particip:holder</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.org/vocab/participation/schema#holder">http://purl.org/vocab/participation/schema#holder</seealso>
    let holder = Prefixed_Name(particip, "holder") |> PrefixedName
