namespace https.www.omg.org.spec.Commons.CodesAndCodeSets.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module CodesAndCodeSets =
    let _namespace_iri = Namespace_Iri CodesAndCodeSets |> NamespaceIRI
    /// <summary>
    ///   <para>CodesAndCodeSets:</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://www.omg.org/spec/Commons/CodesAndCodeSets/">https://www.omg.org/spec/Commons/CodesAndCodeSets/</seealso>
    let _prefix_iri = Prefixed_Name(CodesAndCodeSets, "") |> PrefixedName
    /// <summary>
    ///   <para>CodesAndCodeSets:CodeElement</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://www.omg.org/spec/Commons/CodesAndCodeSets/CodeElement">https://www.omg.org/spec/Commons/CodesAndCodeSets/CodeElement</seealso>
    let CodeElement = Prefixed_Name(CodesAndCodeSets, "CodeElement") |> PrefixedName
    /// <summary>
    ///   <para>CodesAndCodeSets:CodeSet</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://www.omg.org/spec/Commons/CodesAndCodeSets/CodeSet">https://www.omg.org/spec/Commons/CodesAndCodeSets/CodeSet</seealso>
    let CodeSet = Prefixed_Name(CodesAndCodeSets, "CodeSet") |> PrefixedName
