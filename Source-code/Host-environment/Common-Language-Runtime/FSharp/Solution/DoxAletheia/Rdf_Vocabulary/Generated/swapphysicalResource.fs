namespace http.eulersharp.sourceforge.net._2003._03swap.physicalResource.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module swapphysicalResource =
    let _namespace_iri = Namespace_Iri swapphysicalResource |> NamespaceIRI
    /// <summary>
    ///   <para>swapphysicalResource:</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/physicalResource#">http://eulersharp.sourceforge.net/2003/03swap/physicalResource#</seealso>
    let _prefix_iri = Prefixed_Name(swapphysicalResource, "") |> PrefixedName
    /// <summary>
    ///   <para>swapphysicalResource:Compound</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>"compound"</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/physicalResource#Compound">http://eulersharp.sourceforge.net/2003/03swap/physicalResource#Compound</seealso>
    let Compound = Prefixed_Name(swapphysicalResource, "Compound") |> PrefixedName
    /// <summary>
    ///   <para>swapphysicalResource:Device</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>"device"</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/physicalResource#Device">http://eulersharp.sourceforge.net/2003/03swap/physicalResource#Device</seealso>
    let Device = Prefixed_Name(swapphysicalResource, "Device") |> PrefixedName
    /// <summary>
    ///   <para>swapphysicalResource:Product</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>"product"</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/physicalResource#Product">http://eulersharp.sourceforge.net/2003/03swap/physicalResource#Product</seealso>
    let Product = Prefixed_Name(swapphysicalResource, "Product") |> PrefixedName
    /// <summary>
    ///   <para>swapphysicalResource:Resource</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>"physical resource"</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/physicalResource#Resource">http://eulersharp.sourceforge.net/2003/03swap/physicalResource#Resource</seealso>
    let Resource = Prefixed_Name(swapphysicalResource, "Resource") |> PrefixedName
    /// <summary>
    ///   <para>swapphysicalResource:Specimen</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>"specimen"</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/physicalResource#Specimen">http://eulersharp.sourceforge.net/2003/03swap/physicalResource#Specimen</seealso>
    let Specimen = Prefixed_Name(swapphysicalResource, "Specimen") |> PrefixedName

    /// <summary>
    ///   <para>swapphysicalResource:complexityOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/physicalResource#complexityOf">http://eulersharp.sourceforge.net/2003/03swap/physicalResource#complexityOf</seealso>
    let complexityOf =
        Prefixed_Name(swapphysicalResource, "complexityOf") |> PrefixedName

    /// <summary>
    ///   <para>swapphysicalResource:hasComplexity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/physicalResource#hasComplexity">http://eulersharp.sourceforge.net/2003/03swap/physicalResource#hasComplexity</seealso>
    let hasComplexity =
        Prefixed_Name(swapphysicalResource, "hasComplexity") |> PrefixedName
