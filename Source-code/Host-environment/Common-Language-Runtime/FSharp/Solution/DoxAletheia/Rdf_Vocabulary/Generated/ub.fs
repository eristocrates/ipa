namespace http.www.lehigh.edu._zhp2._2004._0401.univ_bench.owl.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module ub =
    let _namespace_iri = Namespace_Iri ub |> NamespaceIRI
    /// <summary>
    ///   <para>ub:Course</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.lehigh.edu/~zhp2/2004/0401/univ-bench.owl#Course">http://www.lehigh.edu/~zhp2/2004/0401/univ-bench.owl#Course</seealso>
    let Course = Prefixed_Name(ub, "Course") |> PrefixedName
