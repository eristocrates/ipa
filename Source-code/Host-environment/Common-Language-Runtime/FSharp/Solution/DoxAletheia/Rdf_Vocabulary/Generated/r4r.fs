namespace http.guava.iis.sinica.edu.tw.r4r.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module r4r =
    let _namespace_iri = Namespace_Iri r4r |> NamespaceIRI
    /// <summary>
    ///   <para>r4r:Article</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Article"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://guava.iis.sinica.edu.tw/r4r/Article">http://guava.iis.sinica.edu.tw/r4r/Article</seealso>
    let Article = Prefixed_Name(r4r, "Article") |> PrefixedName
    /// <summary>
    ///   <para>r4r:Code</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Code"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://guava.iis.sinica.edu.tw/r4r/Code">http://guava.iis.sinica.edu.tw/r4r/Code</seealso>
    let Code = Prefixed_Name(r4r, "Code") |> PrefixedName
    /// <summary>
    ///   <para>r4r:Data</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Data"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://guava.iis.sinica.edu.tw/r4r/Data">http://guava.iis.sinica.edu.tw/r4r/Data</seealso>
    let Data = Prefixed_Name(r4r, "Data") |> PrefixedName
    /// <summary>
    ///   <para>r4r:Definition</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://guava.iis.sinica.edu.tw/r4r/Definition">http://guava.iis.sinica.edu.tw/r4r/Definition</seealso>
    let Definition = Prefixed_Name(r4r, "Definition") |> PrefixedName
    /// <summary>
    ///   <para>r4r:License</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"License"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://guava.iis.sinica.edu.tw/r4r/License">http://guava.iis.sinica.edu.tw/r4r/License</seealso>
    let License = Prefixed_Name(r4r, "License") |> PrefixedName
    /// <summary>
    ///   <para>r4r:Provenance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Provenance"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://guava.iis.sinica.edu.tw/r4r/Provenance">http://guava.iis.sinica.edu.tw/r4r/Provenance</seealso>
    let Provenance = Prefixed_Name(r4r, "Provenance") |> PrefixedName
    /// <summary>
    ///   <para>r4r:RRObject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"RRObject"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://guava.iis.sinica.edu.tw/r4r/RRObject">http://guava.iis.sinica.edu.tw/r4r/RRObject</seealso>
    let RRObject = Prefixed_Name(r4r, "RRObject") |> PrefixedName
    /// <summary>
    ///   <para>r4r:RRPolicy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"RRPolicy"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://guava.iis.sinica.edu.tw/r4r/RRPolicy">http://guava.iis.sinica.edu.tw/r4r/RRPolicy</seealso>
    let RRPolicy = Prefixed_Name(r4r, "RRPolicy") |> PrefixedName
    /// <summary>
    ///   <para>r4r:cites</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"cites"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://guava.iis.sinica.edu.tw/r4r/cites">http://guava.iis.sinica.edu.tw/r4r/cites</seealso>
    let cites = Prefixed_Name(r4r, "cites") |> PrefixedName
    /// <summary>
    ///   <para>r4r:hasLicense</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"hasLicense"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://guava.iis.sinica.edu.tw/r4r/hasLicense">http://guava.iis.sinica.edu.tw/r4r/hasLicense</seealso>
    let hasLicense = Prefixed_Name(r4r, "hasLicense") |> PrefixedName
    /// <summary>
    ///   <para>r4r:hasProvenance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"hasProvenance"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://guava.iis.sinica.edu.tw/r4r/hasProvenance">http://guava.iis.sinica.edu.tw/r4r/hasProvenance</seealso>
    let hasProvenance = Prefixed_Name(r4r, "hasProvenance") |> PrefixedName
    /// <summary>
    ///   <para>r4r:hasTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"hasTime"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://guava.iis.sinica.edu.tw/r4r/hasTime">http://guava.iis.sinica.edu.tw/r4r/hasTime</seealso>
    let hasTime = Prefixed_Name(r4r, "hasTime") |> PrefixedName
    /// <summary>
    ///   <para>r4r:isCitedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"isCitedBy"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://guava.iis.sinica.edu.tw/r4r/isCitedBy">http://guava.iis.sinica.edu.tw/r4r/isCitedBy</seealso>
    let isCitedBy = Prefixed_Name(r4r, "isCitedBy") |> PrefixedName
    /// <summary>
    ///   <para>r4r:isPackagedWith</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"isPackagedWith"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://guava.iis.sinica.edu.tw/r4r/isPackagedWith">http://guava.iis.sinica.edu.tw/r4r/isPackagedWith</seealso>
    let isPackagedWith = Prefixed_Name(r4r, "isPackagedWith") |> PrefixedName
    /// <summary>
    ///   <para>r4r:isPartOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"isPartOf"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://guava.iis.sinica.edu.tw/r4r/isPartOf">http://guava.iis.sinica.edu.tw/r4r/isPartOf</seealso>
    let isPartOf = Prefixed_Name(r4r, "isPartOf") |> PrefixedName
    /// <summary>
    ///   <para>r4r:locateAt</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"locateAt"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://guava.iis.sinica.edu.tw/r4r/locateAt">http://guava.iis.sinica.edu.tw/r4r/locateAt</seealso>
    let locateAt = Prefixed_Name(r4r, "locateAt") |> PrefixedName
