namespace http.aksw.org.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module aksw =
    let _namespace_iri = Namespace_Iri aksw |> NamespaceIRI
    /// <summary>
    ///   <para>aksw:DiegoEsteves.html</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://aksw.org/DiegoEsteves.html">http://aksw.org/DiegoEsteves.html</seealso>
    let ``DiegoEsteves.html`` = Prefixed_Name(aksw, "DiegoEsteves.html") |> PrefixedName

    /// <summary>
    ///   <para>aksw:DiegoMoussallem.html</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://aksw.org/DiegoMoussallem.html">http://aksw.org/DiegoMoussallem.html</seealso>
    let ``DiegoMoussallem.html`` =
        Prefixed_Name(aksw, "DiegoMoussallem.html") |> PrefixedName

    /// <summary>
    ///   <para>aksw:JensLehmann.html</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://aksw.org/JensLehmann.html">http://aksw.org/JensLehmann.html</seealso>
    let ``JensLehmann.html`` = Prefixed_Name(aksw, "JensLehmann.html") |> PrefixedName
    /// <summary>
    ///   <para>aksw:MarvinFrommhold</para>
    /// </summary>
    /// <remarks>
    ///   <para>dcterms:Agent</para>
    ///   <para>foaf:Person</para>
    /// </remarks>
    /// <seealso href="http://aksw.org/MarvinFrommhold">http://aksw.org/MarvinFrommhold</seealso>
    let MarvinFrommhold = Prefixed_Name(aksw, "MarvinFrommhold") |> PrefixedName

    /// <summary>
    ///   <para>aksw:Projects/RDFUnit.html</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://aksw.org/Projects/RDFUnit.html">http://aksw.org/Projects/RDFUnit.html</seealso>
    let ``Projects/RDFUnit.html`` =
        Prefixed_Name(aksw, "Projects/RDFUnit.html") |> PrefixedName

    /// <summary>
    ///   <para>aksw:SebastianTramp</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://aksw.org/SebastianTramp">http://aksw.org/SebastianTramp</seealso>
    let SebastianTramp = Prefixed_Name(aksw, "SebastianTramp") |> PrefixedName
