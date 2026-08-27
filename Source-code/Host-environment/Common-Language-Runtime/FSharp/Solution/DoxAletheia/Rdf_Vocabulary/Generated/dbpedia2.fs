namespace http.dbpedia.org.property.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module dbpedia2 =
    let _namespace_iri = Namespace_Iri dbpedia2 |> NamespaceIRI
    /// <summary>
    ///   <para>planet:property/binomial</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/property/binomial">http://dbpedia.org/property/binomial</seealso>
    let binomial = Prefixed_Name(dbpedia2, "binomial") |> PrefixedName
    /// <summary>
    ///   <para>planet:property/classis</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/property/classis">http://dbpedia.org/property/classis</seealso>
    let classis = Prefixed_Name(dbpedia2, "classis") |> PrefixedName
    /// <summary>
    ///   <para>planet:property/extension</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/property/extension">http://dbpedia.org/property/extension</seealso>
    let extension = Prefixed_Name(dbpedia2, "extension") |> PrefixedName
    /// <summary>
    ///   <para>planet:property/familia</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/property/familia">http://dbpedia.org/property/familia</seealso>
    let familia = Prefixed_Name(dbpedia2, "familia") |> PrefixedName
    /// <summary>
    ///   <para>planet:property/genus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/property/genus">http://dbpedia.org/property/genus</seealso>
    let genus = Prefixed_Name(dbpedia2, "genus") |> PrefixedName

    /// <summary>
    ///   <para>planet:property/hasPhotoCollection</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"hasPhotoCollection"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://dbpedia.org/property/hasPhotoCollection">http://dbpedia.org/property/hasPhotoCollection</seealso>
    let hasPhotoCollection =
        Prefixed_Name(dbpedia2, "hasPhotoCollection") |> PrefixedName

    /// <summary>
    ///   <para>planet:property/ordo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/property/ordo">http://dbpedia.org/property/ordo</seealso>
    let ordo = Prefixed_Name(dbpedia2, "ordo") |> PrefixedName
    /// <summary>
    ///   <para>planet:property/phylum</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/property/phylum">http://dbpedia.org/property/phylum</seealso>
    let phylum = Prefixed_Name(dbpedia2, "phylum") |> PrefixedName
    /// <summary>
    ///   <para>planet:property/regnum</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/property/regnum">http://dbpedia.org/property/regnum</seealso>
    let regnum = Prefixed_Name(dbpedia2, "regnum") |> PrefixedName
    /// <summary>
    ///   <para>planet:property/species</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/property/species">http://dbpedia.org/property/species</seealso>
    let species = Prefixed_Name(dbpedia2, "species") |> PrefixedName
    /// <summary>
    ///   <para>planet:property/synonym</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/property/synonym">http://dbpedia.org/property/synonym</seealso>
    let synonym = Prefixed_Name(dbpedia2, "synonym") |> PrefixedName
    /// <summary>
    ///   <para>planet:property/trinomial</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/property/trinomial">http://dbpedia.org/property/trinomial</seealso>
    let trinomial = Prefixed_Name(dbpedia2, "trinomial") |> PrefixedName
