namespace https.www.omg.org.spec.Commons.Designators.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module Designators =
    let _namespace_iri = Namespace_Iri Designators |> NamespaceIRI
    /// <summary>
    ///   <para>Designators:</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://www.omg.org/spec/Commons/Designators/">https://www.omg.org/spec/Commons/Designators/</seealso>
    let _prefix_iri = Prefixed_Name(Designators, "") |> PrefixedName
    /// <summary>
    ///   <para>Designators:Name</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://www.omg.org/spec/Commons/Designators/Name">https://www.omg.org/spec/Commons/Designators/Name</seealso>
    let Name = Prefixed_Name(Designators, "Name") |> PrefixedName
    /// <summary>
    ///   <para>Designators:defines</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://www.omg.org/spec/Commons/Designators/defines">https://www.omg.org/spec/Commons/Designators/defines</seealso>
    let defines = Prefixed_Name(Designators, "defines") |> PrefixedName
    /// <summary>
    ///   <para>Designators:denotes</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://www.omg.org/spec/Commons/Designators/denotes">https://www.omg.org/spec/Commons/Designators/denotes</seealso>
    let denotes = Prefixed_Name(Designators, "denotes") |> PrefixedName
    /// <summary>
    ///   <para>Designators:describes</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://www.omg.org/spec/Commons/Designators/describes">https://www.omg.org/spec/Commons/Designators/describes</seealso>
    let describes = Prefixed_Name(Designators, "describes") |> PrefixedName
    /// <summary>
    ///   <para>Designators:hasDescription</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://www.omg.org/spec/Commons/Designators/hasDescription">https://www.omg.org/spec/Commons/Designators/hasDescription</seealso>
    let hasDescription = Prefixed_Name(Designators, "hasDescription") |> PrefixedName
    /// <summary>
    ///   <para>Designators:hasName</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://www.omg.org/spec/Commons/Designators/hasName">https://www.omg.org/spec/Commons/Designators/hasName</seealso>
    let hasName = Prefixed_Name(Designators, "hasName") |> PrefixedName
    /// <summary>
    ///   <para>Designators:hasTag</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://www.omg.org/spec/Commons/Designators/hasTag">https://www.omg.org/spec/Commons/Designators/hasTag</seealso>
    let hasTag = Prefixed_Name(Designators, "hasTag") |> PrefixedName
    /// <summary>
    ///   <para>Designators:hasTextualName</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://www.omg.org/spec/Commons/Designators/hasTextualName">https://www.omg.org/spec/Commons/Designators/hasTextualName</seealso>
    let hasTextualName = Prefixed_Name(Designators, "hasTextualName") |> PrefixedName
    /// <summary>
    ///   <para>Designators:isDefinedIn</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://www.omg.org/spec/Commons/Designators/isDefinedIn">https://www.omg.org/spec/Commons/Designators/isDefinedIn</seealso>
    let isDefinedIn = Prefixed_Name(Designators, "isDefinedIn") |> PrefixedName
    /// <summary>
    ///   <para>Designators:isNameOf</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://www.omg.org/spec/Commons/Designators/isNameOf">https://www.omg.org/spec/Commons/Designators/isNameOf</seealso>
    let isNameOf = Prefixed_Name(Designators, "isNameOf") |> PrefixedName
    /// <summary>
    ///   <para>Designators:isSignifiedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://www.omg.org/spec/Commons/Designators/isSignifiedBy">https://www.omg.org/spec/Commons/Designators/isSignifiedBy</seealso>
    let isSignifiedBy = Prefixed_Name(Designators, "isSignifiedBy") |> PrefixedName
