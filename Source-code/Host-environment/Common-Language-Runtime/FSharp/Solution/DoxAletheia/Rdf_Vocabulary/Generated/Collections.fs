namespace https.www.omg.org.spec.Commons.Collections.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module Collections =
    let _namespace_iri = Namespace_Iri Collections |> NamespaceIRI
    /// <summary>
    ///   <para>Collections:</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://www.omg.org/spec/Commons/Collections/">https://www.omg.org/spec/Commons/Collections/</seealso>
    let _prefix_iri = Prefixed_Name(Collections, "") |> PrefixedName
    /// <summary>
    ///   <para>Collections:Arrangement</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://www.omg.org/spec/Commons/Collections/Arrangement">https://www.omg.org/spec/Commons/Collections/Arrangement</seealso>
    let Arrangement = Prefixed_Name(Collections, "Arrangement") |> PrefixedName
    /// <summary>
    ///   <para>Collections:Collection</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://www.omg.org/spec/Commons/Collections/Collection">https://www.omg.org/spec/Commons/Collections/Collection</seealso>
    let Collection = Prefixed_Name(Collections, "Collection") |> PrefixedName
    /// <summary>
    ///   <para>Collections:Constituent</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://www.omg.org/spec/Commons/Collections/Constituent">https://www.omg.org/spec/Commons/Collections/Constituent</seealso>
    let Constituent = Prefixed_Name(Collections, "Constituent") |> PrefixedName

    /// <summary>
    ///   <para>Collections:StructuredCollection</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://www.omg.org/spec/Commons/Collections/StructuredCollection">https://www.omg.org/spec/Commons/Collections/StructuredCollection</seealso>
    let StructuredCollection =
        Prefixed_Name(Collections, "StructuredCollection") |> PrefixedName

    /// <summary>
    ///   <para>Collections:comprises</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://www.omg.org/spec/Commons/Collections/comprises">https://www.omg.org/spec/Commons/Collections/comprises</seealso>
    let comprises = Prefixed_Name(Collections, "comprises") |> PrefixedName
    /// <summary>
    ///   <para>Collections:hasMember</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://www.omg.org/spec/Commons/Collections/hasMember">https://www.omg.org/spec/Commons/Collections/hasMember</seealso>
    let hasMember = Prefixed_Name(Collections, "hasMember") |> PrefixedName
    /// <summary>
    ///   <para>Collections:hasPart</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://www.omg.org/spec/Commons/Collections/hasPart">https://www.omg.org/spec/Commons/Collections/hasPart</seealso>
    let hasPart = Prefixed_Name(Collections, "hasPart") |> PrefixedName
    /// <summary>
    ///   <para>Collections:isConstituentOf</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://www.omg.org/spec/Commons/Collections/isConstituentOf">https://www.omg.org/spec/Commons/Collections/isConstituentOf</seealso>
    let isConstituentOf = Prefixed_Name(Collections, "isConstituentOf") |> PrefixedName
    /// <summary>
    ///   <para>Collections:isIncludedIn</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://www.omg.org/spec/Commons/Collections/isIncludedIn">https://www.omg.org/spec/Commons/Collections/isIncludedIn</seealso>
    let isIncludedIn = Prefixed_Name(Collections, "isIncludedIn") |> PrefixedName
    /// <summary>
    ///   <para>Collections:isMemberOf</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://www.omg.org/spec/Commons/Collections/isMemberOf">https://www.omg.org/spec/Commons/Collections/isMemberOf</seealso>
    let isMemberOf = Prefixed_Name(Collections, "isMemberOf") |> PrefixedName
    /// <summary>
    ///   <para>Collections:isPartOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="https://www.omg.org/spec/Commons/Collections/isPartOf">https://www.omg.org/spec/Commons/Collections/isPartOf</seealso>
    let isPartOf = Prefixed_Name(Collections, "isPartOf") |> PrefixedName
