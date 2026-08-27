namespace http.schemas.ogf.org.nml._2013._05._base.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module ndl =
    let _namespace_iri = Namespace_Iri ndl |> NamespaceIRI
    /// <summary>
    ///   <para>ndl:AdaptationService</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://schemas.ogf.org/nml/2013/05/base#AdaptationService">http://schemas.ogf.org/nml/2013/05/base#AdaptationService</seealso>
    let AdaptationService = Prefixed_Name(ndl, "AdaptationService") |> PrefixedName
    /// <summary>
    ///   <para>ndl:Group</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://schemas.ogf.org/nml/2013/05/base#Group">http://schemas.ogf.org/nml/2013/05/base#Group</seealso>
    let Group = Prefixed_Name(ndl, "Group") |> PrefixedName
    /// <summary>
    ///   <para>ndl:Location</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://schemas.ogf.org/nml/2013/05/base#Location">http://schemas.ogf.org/nml/2013/05/base#Location</seealso>
    let Location = Prefixed_Name(ndl, "Location") |> PrefixedName
    /// <summary>
    ///   <para>ndl:Node</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://schemas.ogf.org/nml/2013/05/base#Node">http://schemas.ogf.org/nml/2013/05/base#Node</seealso>
    let Node = Prefixed_Name(ndl, "Node") |> PrefixedName
    /// <summary>
    ///   <para>ndl:Service</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://schemas.ogf.org/nml/2013/05/base#Service">http://schemas.ogf.org/nml/2013/05/base#Service</seealso>
    let Service = Prefixed_Name(ndl, "Service") |> PrefixedName
